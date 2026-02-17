using EF.PoliceMod.Core;
using EF.PoliceMod.Gameplay;
using GTA;
using GTA.Math;
using GTA.Native;
using GTA.UI;
using System;
using System.Linq;
using EF.PoliceMod.Executors;

namespace EF.PoliceMod.Systems
{
    /// <summary>
    /// “嫌疑人驾车逃逸/逼停”系统（社区级可用版）：
    /// - I 键发布 PullOverRequestedEvent
    /// - 本系统订阅后，对当前嫌疑人所在车辆的司机下达靠边停车任务
    /// </summary>
    public class PullOverSystem
    {
        private readonly SuspectController _suspectController;

        private int _lastPullOverAtMs = 0;
        private const int PullOverCooldownMs = 1500;

        // 当前正在进行的“逼停会话”（简化：同一时间只处理一个）
        private int _activeDriverHandle = -1;
        private int _activeVehicleHandle = -1;
        private int _parkIssuedAtMs = 0;
        private int _lastHaltReissueAtMs = 0;

        // 停稳后自动下车的延迟（给音频/广播留空间）
        private const int AutoExitDelayMs = 1500;
        private int _pulledOverReadyAtMs = 0;

        // I 逼停指令最大有效距离（不要求贴脸；过远仍禁止，避免跨半张地图控车）
        private const float MaxPullOverCommandDistance = 75f;

        private bool _pulledOverReady = false;   // 已停稳，可进入下车流程
        private bool _exitRequested = false;     // 已下达下车
        private int _exitIssuedAtMs = 0;

        private Vector3 _parkTargetPos;
        private float _parkTargetHeading;

        // 逼停后下车的后续行为（按会话记录）
        private bool _exitWillResist = false;
        private string _riskTag = "";

        public PullOverSystem(SuspectController suspectController)
        {
            _suspectController = suspectController;
            EventBus.Subscribe<PullOverRequestedEvent>(OnPullOverRequested);
            EventBus.Subscribe<PullOverExitRequestedEvent>(OnPullOverExitRequested);
        }

        /// <summary>
        /// 每帧驱动：
        /// 1) 维护“是否已停稳”的标志（允许按 U 要求下车）
        /// 2) 若已按 U 且超时未下车，兜底 WarpOutOfVehicle
        /// 3) 下车后自动 HandsUp，方便 L 锁定 + H 拘捕
        /// </summary>
        public void TickUpdate()
        {
            try
            {
                if (_activeDriverHandle <= 0 || _activeVehicleHandle <= 0)
                    return;

                var driver = World.GetAllPeds().FirstOrDefault(p => p != null && p.Exists() && p.Handle == _activeDriverHandle);
                var veh = World.GetAllVehicles().FirstOrDefault(v => v != null && v.Exists() && v.Handle == _activeVehicleHandle);

                if (driver == null || !driver.Exists() || veh == null || !veh.Exists())
                {
                    _activeDriverHandle = -1;
                    _activeVehicleHandle = -1;
                    _parkIssuedAtMs = 0;
                    _pulledOverReady = false;
                    _exitRequested = false;
                    _exitIssuedAtMs = 0;
                    return;
                }

                // 给停车任务一点时间，避免刚下达就判定“没动”
                if (Game.GameTime - _parkIssuedAtMs < 250)
                    return;

                // 持续兜底：BRING_VEHICLE_TO_HALT 的 duration 到时后，AI 可能又继续行驶。
                // 这里在“尚未停稳”阶段周期性重发一次，直到判定停稳。
                if (!_pulledOverReady)
                {
                    bool needReissue = false;
                    try { needReissue = veh.Speed > 2.0f; } catch { needReissue = false; }

                    if (needReissue && (Game.GameTime - _lastHaltReissueAtMs) > 700)
                    {
                        _lastHaltReissueAtMs = Game.GameTime;
                        try { Function.Call(Hash.BRING_VEHICLE_TO_HALT, veh.Handle, 3.0f, 2500, false); } catch { }
                    }
                }

                bool stopped = false;
                try { stopped = Function.Call<bool>(Hash.IS_VEHICLE_STOPPED, veh.Handle); } catch { stopped = false; }

                float distToTarget = 9999f;
                try { distToTarget = veh.Position.DistanceTo(_parkTargetPos); } catch { distToTarget = 9999f; }

                // 停稳判定（更宽松）：
                // - 有些情况下 TASK_VEHICLE_PARK 会停在“不是 parkPos 的精确位置”，导致 distToTarget 永远过大。
                // - 因此：只要车辆确实停住/很慢，并且“接近目标点”或“任务已执行足够久”，就允许下车。
                bool slow = false;
                try { slow = veh.Speed <= 1.0f; } catch { slow = false; }
                bool longEnough = (Game.GameTime - _parkIssuedAtMs) >= 2500;
                bool readyNow = (stopped || slow) && ((distToTarget <= 12.0f) || longEnough);

                // 记录首次“停稳”的时刻，用于延迟自动下车
                if (readyNow)
                {
                    if (_pulledOverReadyAtMs <= 0) _pulledOverReadyAtMs = Game.GameTime;
                }
                else
                {
                    _pulledOverReadyAtMs = 0;
                }

                _pulledOverReady = readyNow;

                // 已经靠边：持续施加手刹/速度钳制，避免“抖动停不住”
                if (_pulledOverReady && !_exitRequested)
                {
                    try { Function.Call(Hash.SET_VEHICLE_HANDBRAKE, veh.Handle, true); } catch { }
                    try { Function.Call(Hash.SET_VEHICLE_FORWARD_SPEED, veh.Handle, 0f); } catch { }

                    // 更像原版：停稳后开启双闪（按你的“模组所有函数”参考表：使用 SET_VEHICLE_INDICATOR_LIGHTS）
                    // 0=左灯，1=右灯；同时开启即“近似双闪”
                    try { Function.Call(Hash.SET_VEHICLE_INDICATOR_LIGHTS, veh.Handle, 0, true); } catch { }
                    try { Function.Call(Hash.SET_VEHICLE_INDICATOR_LIGHTS, veh.Handle, 1, true); } catch { }

                    // 给 1~2 秒的空隙：留给后续音频/广播
                    if (_pulledOverReadyAtMs > 0 && (Game.GameTime - _pulledOverReadyAtMs) < AutoExitDelayMs)
                        return;

                    // 停稳后自动下车举手（U 仍可兜底）
                    try { driver.Task.ClearAll(); } catch { }
                    try { driver.Task.LeaveVehicle(veh, LeaveVehicleFlags.None); } catch { }
                    _exitRequested = true;
                    _exitIssuedAtMs = Game.GameTime;
                    Notification.Show("~b~已下达下车指令");
                    ModLog.Info("[PullOver] Auto-exit issued (after delay)");
                }

                if (!_exitRequested)
                    return;

                // 已请求下车：若卡住则兜底 WarpOut
                if (driver.IsInVehicle(veh))
                {
                    if (Game.GameTime - _exitIssuedAtMs > 6000)
                    {
                        try { driver.Task.WarpOutOfVehicle(veh); } catch { }
                        ModLog.Warn($"[PullOver] Exit timeout -> WarpOutOfVehicle (driver={driver.Handle})");
                    }
                    return;
                }

                // ★必修：自动下车完成后关门（best-effort）
                try
                {
                    if (veh != null && veh.Exists())
                    {
                        // 0=驾驶门（DSIDE_F）
                        try { VehicleDoorOps.ShutDoor(veh, 0); } catch { }
                        // 关闭双闪（若之前开启）
                        try { Function.Call(Hash.SET_VEHICLE_INDICATOR_LIGHTS, veh.Handle, 0, false); } catch { }
                        try { Function.Call(Hash.SET_VEHICLE_INDICATOR_LIGHTS, veh.Handle, 1, false); } catch { }
                    }
                }
                catch { }

                // 已下车：根据风险决定举手 or 反抗
                if (_exitWillResist)
                {
                    try { driver.Task.ClearAll(); } catch { }
                    try { EventBus.Publish(new EF.PoliceMod.Input.SuspectResistEvent(driver, Game.Player.Character)); } catch { }
                    Notification.Show("~r~嫌疑人拒捕！" + (string.IsNullOrEmpty(_riskTag) ? "" : ("（" + _riskTag + "）")));
                    ModLog.Info($"[PullOver] Driver exited -> resist (driver={driver.Handle}) tag={_riskTag}");
                }
                else
                {
                    try { driver.Task.ClearAll(); } catch { }
                    // 永久举手：直到玩家按 G 要求跟随 / 或手动拘捕 / 或案件结束。
                    try { driver.Task.HandsUp(-1); } catch { }

                    // 逼停自动下车：默认走“抱头线”（顺从但不自动押送）。
                    // 玩家按 G 才进入押送/跟随，然后按 E 让其上车。
                    try
                    {
                        _suspectController?.TakeControl(driver);
                        _suspectController?.SetCompliant(driver); // SetCompliant 内部默认 CurrentArrestStyle=HandsOnHeadFollow
                        try { EventBus.Publish(new PullOverEscortBypassActivatedEvent(driver.Handle)); } catch { }

                        // ★必修：驾车逃逸线默认跳过“拘捕阶段”——直接标记为已锁定+已控制。
                        try { EFCore.Instance?.LockTargetSystem?.AutoLockAndArrest(driver); } catch { }
                    }
                    catch { }

                    Notification.Show("~g~嫌疑人已下车举手（可直接按 ~y~G~s~ 跟随 / ~y~E~s~ 上下车；也可下车后按 ~y~H~s~ 重新选择拘捕风格）");
                    ModLog.Info($"[PullOver] Driver exited -> hands up (infinite) -> auto locked+arrested (driver={driver.Handle})");
                }

                _activeDriverHandle = -1;
                _activeVehicleHandle = -1;
                _parkIssuedAtMs = 0;
                _pulledOverReady = false;
                _exitRequested = false;
                _exitIssuedAtMs = 0;
                _exitWillResist = false;
                _riskTag = "";
            }
            catch (Exception ex)
            {
                ModLog.Error("[PullOver] TickUpdate error: " + ex);
            }
        }

        private void OnPullOverExitRequested(PullOverExitRequestedEvent e)
        {
            try
            {
                if (_activeDriverHandle <= 0 || _activeVehicleHandle <= 0)
                {
                    Notification.Show("~y~请先对嫌疑人按 I 下达逼停");
                    return;
                }

                var driver = World.GetAllPeds().FirstOrDefault(p => p != null && p.Exists() && p.Handle == _activeDriverHandle);
                var veh = World.GetAllVehicles().FirstOrDefault(v => v != null && v.Exists() && v.Handle == _activeVehicleHandle);
                if (driver == null || !driver.Exists() || veh == null || !veh.Exists())
                    return;

                if (!driver.IsInVehicle(veh))
                    return;

                if (!_pulledOverReady)
                {
                    float speed = 0f;
                    float dist = 9999f;
                    try { speed = veh.Speed; } catch { }
                    try { dist = veh.Position.DistanceTo(_parkTargetPos); } catch { }
                    ModLog.Info($"[PullOver] U pressed but not ready: speed={speed:F2} distToTarget={dist:F1}");
                    Notification.Show("~y~车辆未停稳，稍等再按 U");
                    return;
                }

                // 若已自动下车流程在跑，U 仅作为兜底，不重复下达
                if (_exitRequested)
                {
                    Notification.Show("~b~已在下车流程中");
                    return;
                }

                // 不用 ClearAllImmediately：会导致瞬移/无动画，改为温和清任务再下车
                try { driver.Task.ClearAll(); } catch { }
                try { driver.Task.LeaveVehicle(veh, LeaveVehicleFlags.None); } catch { }

                _exitRequested = true;
                _exitIssuedAtMs = Game.GameTime;
                Notification.Show("~b~已下达下车指令（兜底）");
                ModLog.Info("[PullOver] U pressed -> LeaveVehicle issued (manual fallback)");
            }
            catch (Exception ex)
            {
                ModLog.Error("[PullOver] OnPullOverExitRequested error: " + ex);
            }
        }

        private void OnPullOverRequested(PullOverRequestedEvent e)
        {
            try
            {
                int now = Game.GameTime;
                if (now - _lastPullOverAtMs < PullOverCooldownMs)
                    return;
                _lastPullOverAtMs = now;

                var player = Game.Player.Character;
                if (player == null || !player.Exists())
                    return;

                // 允许车内/车外都能下达逼停指令（车外同样按射线/评分选车）

                // --- 目标选择：优先使用“瞄准射线”选目标，其次回退到当前案件嫌疑人 ---
                Ped suspect = null;

                // 1) 射线：从相机朝向找 ped/vehicle（范围更广）
                try
                {
                    Vector3 start = GameplayCamera.Position;
                    Vector3 end = start + GameplayCamera.Direction * 220f;
                    RaycastResult rr = World.Raycast(start, end, IntersectFlags.Vehicles | IntersectFlags.Peds, player);
                    if (rr.DidHit && rr.HitEntity != null && rr.HitEntity.Exists())
                    {
                        if (rr.HitEntity is Ped)
                        {
                            var p = rr.HitEntity as Ped;
                            if (p != null && p.Exists() && p.IsInVehicle()) suspect = p;
                            else if (p != null && p.Exists()) suspect = p;
                        }
                        else if (rr.HitEntity is Vehicle)
                        {
                            var v = rr.HitEntity as Vehicle;
                            if (v != null && v.Exists())
                            {
                                try
                                {
                                    var d2 = v.Driver;
                                    if (d2 != null && d2.Exists()) suspect = d2;
                                }
                                catch { }
                            }
                        }
                    }
                }
                catch { suspect = null; }

                // 2) 回退：只允许对“当前案件嫌疑人”下达逼停
                if (suspect == null || !suspect.Exists())
                {
                    try { suspect = _suspectController?.GetCurrentSuspect(); } catch { suspect = null; }
                }

                // 兜底：部分流程下 SuspectController 的引用可能被清空，这里从 CaseManager 再取一次
                if (suspect == null || !suspect.Exists())
                {
                    try { suspect = EFCore.Instance?.GetCaseManager()?.GetCurrentSuspectPed(); } catch { suspect = null; }
                }

                if (suspect == null || !suspect.Exists())
                {
                    Notification.Show("~y~当前没有嫌疑人，无法逼停");
                    return;
                }

                if (!suspect.IsInVehicle())
                {
                    Notification.Show("~y~嫌疑人不在车内，无需逼停");
                    return;
                }

                // 距离限制：不要求贴脸，但也不要太离谱
                try
                {
                    float d = player.Position.DistanceTo(suspect.Position);
                    if (d > MaxPullOverCommandDistance)
                    {
                        Notification.Show("~y~距离过远，靠近一点再按 I（" + ((int)d).ToString() + "m）");
                        return;
                    }
                }
                catch { }

                Vehicle veh = null;
                Ped driver = null;
                try { veh = suspect.CurrentVehicle; } catch { veh = null; }
                if (veh == null || !veh.Exists())
                    return;

                try { driver = veh.Driver; } catch { driver = null; }
                if (driver == null || !driver.Exists())
                    return;

                // 必须是嫌疑人本人在驾驶位（避免误判同车其他乘客）
                if (driver.Handle != suspect.Handle)
                {
                    Notification.Show("~y~嫌疑人不在驾驶位，无法逼停");
                    return;
                }



                // 追车三档（按你需求重做）：
                // 1) 普通：按 I 必停（不反抗）
                // 2) 中危：有概率逃逸；提示玩家打爆轮胎/PIT/强制拽出
                // 3) 高危：高概率车内反抗（开枪）；提示“已授权击毙”，该案不走“下车拘捕”流程
                try
                {
                    bool isHigh = false;
                    bool isMid = false;

                    try
                    {
                        float rc = _suspectController != null ? _suspectController.ResistChance : 0f;
                        bool firearm = _suspectController != null && _suspectController.HasFirearm;
                        isHigh = firearm || rc >= 0.80f;
                        isMid = !isHigh && rc >= 0.50f;
                    }
                    catch
                    {
                        isHigh = false;
                        isMid = false;
                    }

                    _riskTag = isHigh ? "高危" : (isMid ? "中危" : "普通");
                    var rng = new Random(Game.GameTime + driver.Handle);

                    // ===== 高危：直接进入武装反抗（车内开枪 + 逃逸），不进入逼停会话 =====
                    if (isHigh)
                    {
                        ModLog.Info("[PullOver] 高危 -> armed resist (in-vehicle)");
                        EF.PoliceMod.Core.SmsNotification.Show(
                            "911调度",
                            "高危嫌疑人",
                            "目标武装反抗，正在驾车逃逸！\n已授权使用致命武力。"
                        );

                        try { driver.Task.ClearAll(); } catch { }

                        // 车内反抗：确保有“可车内射击”的武器（霰弹枪无法 drive-by）
                        try
                        {
                            driver.Weapons.Give(WeaponHash.MicroSMG, 240, true, true);
                            Function.Call(Hash.SET_CURRENT_PED_WEAPON, driver.Handle, (uint)WeaponHash.MicroSMG, true);
                        }
                        catch { }

                        // 追逐并猛撞：先追玩家（比 Wander 更主动）
                        try { Function.Call(Hash.TASK_VEHICLE_CHASE, driver.Handle, player.Handle); } catch { }

                        // 激进驾驶参数（best effort）
                        try { Function.Call(Hash.SET_DRIVER_AGGRESSIVENESS, driver.Handle, 1.0f); } catch { }
                        try { Function.Call(Hash.SET_DRIVER_RACING_MODIFIER, driver.Handle, 1.0f); } catch { }
                        try { Function.Call(Hash.SET_DRIVE_TASK_DRIVING_STYLE, driver.Handle, 786468); } catch { }

                        // 车内射击（best-effort）。注意：不要立刻用 DriveWander 覆盖 chase，否则会变成“随便开”。
                        try
                        {
                            var dist = player.Position.DistanceTo(driver.Position);
                            if (dist < 70f)
                            {
                                Function.Call(Hash.TASK_DRIVE_BY, driver.Handle, player.Handle, 0, 0f, 0f, 0f, 85f, 600, true, Game.GenerateHash("FIRING_PATTERN_FULL_AUTO"));
                            }
                        }
                        catch { }

                        _activeDriverHandle = -1;
                        _activeVehicleHandle = -1;
                        _parkIssuedAtMs = 0;
                        _exitWillResist = false;
                        return;
                    }

                    // ===== 中危：概率逃逸（不再“下车后反抗”） =====
                    if (isMid)
                    {
                        int fleeRoll = rng.Next(100);
                        bool flee = fleeRoll < 30; // “一定概率”
                        if (flee)
                        {
                            ModLog.Info("[PullOver] 中危 -> fleeing");
                            EF.PoliceMod.Core.SmsNotification.Show(
                                "911调度",
                                "中危嫌疑人",
                                "目标拒检逃逸！\n建议：PIT/打爆轮胎迫使其停车，然后将其从车内拽出并锁定拘捕。"
                            );

                            try { driver.Task.ClearAll(); } catch { }
                            try { Function.Call(Hash.TASK_VEHICLE_DRIVE_WANDER, driver.Handle, veh.Handle, 35.0f, 786468); } catch { }

                            _activeDriverHandle = -1;
                            _activeVehicleHandle = -1;
                            _parkIssuedAtMs = 0;
                            _exitWillResist = false;
                            return;
                        }
                    }

                    // ===== 普通/中危(未逃逸)：必停，且不走“下车反抗” =====
                    _exitWillResist = false;
                }
                catch { }

                // 选一个右侧道路点作为靠边点（尽量避免直接用当前点导致卡住）
                Vector3 hintPos = veh.Position + veh.RightVector * 8.0f;
                Vector3 parkPos;
                try
                {
                    parkPos = World.GetNextPositionOnStreet(hintPos);
                }
                catch
                {
                    parkPos = veh.Position;
                }

                float heading = veh.Heading;

                // 先清理司机当前任务，避免与逃逸任务对抗
                try { driver.Task.ClearAll(); } catch { }

                try
                {
                    // ScriptHookV 报错：FATAL: Can't find native 0x000000002623D5A9
                    // 该错误通常是“当前 ScriptHookV 的 native 表里没有某个任务函数”。
                    // 为了稳定性，这里不再使用 TASK_VEHICLE_PARK，改用你提供的“模组所有函数”表内的：BRING_VEHICLE_TO_HALT。
                    // BRING_VEHICLE_TO_HALT(Vehicle vehicle, float distance, int duration, BOOL unknown)
                    try { Function.Call(Hash.BRING_VEHICLE_TO_HALT, veh.Handle, 3.0f, 4000, false); } catch { }

                    // 记录会话：等待停稳后允许 U 下车（仍允许玩家走锁定/拘捕流程）
                    _activeDriverHandle = driver.Handle;
                    _activeVehicleHandle = veh.Handle;
                    _parkIssuedAtMs = Game.GameTime;
                    _pulledOverReady = false;
                    _exitRequested = false;
                    _exitIssuedAtMs = 0;
                    _parkTargetPos = parkPos;
                    _parkTargetHeading = heading;

                    ModLog.Info($"[PullOver] BRING_VEHICLE_TO_HALT issued driver={driver.Handle} veh={veh.Handle} pos={parkPos}");
                    EF.PoliceMod.Core.SmsNotification.Show(
                        "911调度",
                        "逼停指令",
                        "已下达逼停（" + _riskTag + "）\n目标停稳后将自动下车举手（U 为兜底）"
                    );
                }
                catch (Exception exTask)
                {
                    ModLog.Error("[PullOver] TASK_VEHICLE_PARK failed: " + exTask);
                    Notification.Show("~r~逼停失败（任务下达异常）");
                }
            }
            catch (Exception ex)
            {
                ModLog.Error("[PullOver] OnPullOverRequested error: " + ex);
            }
        }
    }
}
