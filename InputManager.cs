using EF.PoliceMod.Core;
using EF.PoliceMod.Input;
using GTA;
using GTA.Native;
using GTA.UI;
using System;
using Keys = System.Windows.Forms.Keys;
using System.Runtime.InteropServices;

namespace EF.PoliceMod.Input
{
    // 注意：SuspectDeliveredEvent 统一使用 EF.PoliceMod.Core.SuspectDeliveredEvent（传 handle）。
    // 这里不要再定义同名事件类型，否则会导致 EventBus 订阅/发布类型不一致，从而出现“交付后被判定死亡”。

    public class InputManager
    {
        private bool _arrestKeyHeld;
        private bool _escortRequested;
        private bool _escortInteractHeld;
        private bool _openTerminalHeld = false;
        private bool _f10Held = false;
        private bool _pullOverHeld = false;
        private bool _pullOverExitHeld = false;
        private bool _dispatchMenuHeld = false;
        private bool _lockHeld = false;
        private bool _f8Held = false;
        private bool _hHeldRaw = false;
        private bool _gHeldRaw = false;
        private bool _eHeldRaw = false;
        private bool _yHeldRaw = false;
        private bool _pHeldRaw = false;
    // AIM HANDLER FIELDS REMOVED (TEMP)
    // _lastAimedPublishedAtMs, _lastAimedTarget, _wasAiming disabled to prevent aim->event spam/crash.
    private int _lastAimedPublishedAtMs = 0;
    private Ped _lastAimedTarget = null;
    private bool _wasAiming = false;
    private int _lastAimedHandle = 0;
    private const int AIM_PUBLISH_MIN_INTERVAL_MS = 200;
    private const int KEY_PRESSED_MASK = 0x8000;
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        private DateTime _lastTerminalToggle = DateTime.MinValue;
        private readonly TimeSpan _terminalDebounce = TimeSpan.FromMilliseconds(220);

        private bool IsRawKeyDown(System.Windows.Forms.Keys k)
        {
            return (GetAsyncKeyState((int)k) & KEY_PRESSED_MASK) != 0;
        }

    // === 删除上面多余的全局 PlayerAimedAtPedEvent 定义 ===
    // 不要在这里重复定义 PlayerAimedAtPedEvent：我们把这个类型统一放在 InputEvents.cs（EF.PoliceMod.Input）中。


    public struct SuspectKilledByPlayerEvent
        {
            public int SuspectHandle { get; }
            public SuspectKilledByPlayerEvent(int suspectHandle) { SuspectHandle = suspectHandle; }
        }

        public void Update()
        {
            int now = Game.GameTime;
            try { EF.PoliceMod.Core.UIState.AutoRecover(now); } catch { }

            // 先处理打开终端的按键（默认 O） —— 使用原生按键检测以避免被游戏 control 层吞掉
            // 支持 O 和 /（部分键盘布局为 OemQuestion）
            // 额外支持：上班后坐在警车里按 T 打开（更贴合“车载终端”）
            bool pressedO = IsRawKeyDown(EF.PoliceMod.Core.KeyBindings.OpenTerminal) || IsRawKeyDown(System.Windows.Forms.Keys.OemQuestion);
            bool pressedT = IsRawKeyDown(EF.PoliceMod.Core.KeyBindings.VehicleTerminal);


            // 巡逻指令菜单（J 打开）：巡逻模式开启 + 已锁定目标 + 当前不在案件链路，才允许打开。
            // 说明：巡逻链路与案件链路分离；案件进行中时 H 保留给拘捕菜单。
            bool patrolMenuHotkey = IsRawKeyDown(EF.PoliceMod.Core.KeyBindings.PatrolMenu);
            if (patrolMenuHotkey)
            {
                if (!_yHeldRaw)
                {
                    _yHeldRaw = true;
                    try
                    {
                        bool patrolOn = EF.PoliceMod.Systems.PatrolModeQuery.Enabled;
                        bool hasActiveCase = EF.PoliceMod.Systems.CaseStatusQuery.HasActiveCase;
                        var core = EFCore.Instance;
                        bool hasLockedTarget = core != null && core.LockTargetSystem != null && core.LockTargetSystem.HasTarget;

                        if (patrolOn && hasLockedTarget && !hasActiveCase)
                        {
                            EventBus.Publish(new EF.PoliceMod.Core.PatrolMenuToggledEvent(true));
                            ModLog.Info("[Input] J pressed -> PatrolMenu opened");
                        }
                    }
                    catch { }
                }
            }
            else
            {
                _yHeldRaw = false;
            }

            if (pressedO || pressedT)
            {
                if (!_openTerminalHeld)
                {
                    _openTerminalHeld = true;
                    if (DateTime.UtcNow - _lastTerminalToggle > _terminalDebounce)
                    {
                        _lastTerminalToggle = DateTime.UtcNow;
                        bool allow = true;
                        try
                        {
                            var player = Game.Player.Character;
                            bool inVehicle = player != null && player.Exists() && player.IsInVehicle();
                            bool onDuty = EF.PoliceMod.Systems.DutyQuery.IsOnDuty;

                            if (pressedT)
                            {
                                allow = onDuty && inVehicle;
                                ModLog.Info($"[Input] T pressed: onDuty={onDuty}, inVehicle={inVehicle}, allow={allow}");
                                if (!allow)
                                {
                                    if (!onDuty)
                                        Notification.Show("~y~车载终端：需先开始执勤");
                                    else if (!inVehicle)
                                        Notification.Show("~y~车载终端：需坐入车辆内");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            ModLog.Error("[Input] T key check failed: " + ex);
                        }

                        if (allow)
                        {
                            try
                            {
                                var src = pressedT
                                    ? EF.PoliceMod.Input.OpenPoliceTerminalSource.VehicleTerminal
                                    : EF.PoliceMod.Input.OpenPoliceTerminalSource.StationTerminal;
                                EventBus.Publish(new OpenPoliceTerminalEvent(src));
                                ModLog.Info($"[Input] OpenPoliceTerminalEvent published, source={src}");
                            }
                            catch
                            {
                                EventBus.Publish(new OpenPoliceTerminalEvent(EF.PoliceMod.Input.OpenPoliceTerminalSource.StationTerminal));
                            }
                        }
                    }
                }
            }
            else
            {
                _openTerminalHeld = false;
            }

            // -------- SAFE aim detection (no target-native calls) --------
            // 安全策略：不要在每帧调用 GET_ENTITY_PLAYER_IS_FREE_AIMING_AT 或对 Ped 做 Exists()/Handle 查询。
            // 这些 native 在极少数情况下会导致访问冲突 (0xC0000005)，进而直接崩溃游戏进程。
            // 我们只检测玩家是否按下瞄准键（作为输入状态），但不读取目标 Ped。
            // 任何需要“已锁定目标”的操作必须通过 L 键（LockTargetEvent）显式锁定后才能执行。

            bool isAiming = false;
            try
            {
                // 仅检测按键，不读取目标实体
                // 车内瞄准与步行瞄准是不同 control：两者任一按下都视为“正在瞄准”
                bool onFootAim = false;
                bool vehicleAim = false;
                try { onFootAim = Function.Call<bool>(Hash.IS_CONTROL_PRESSED, 0, (int)GTA.Control.Aim); } catch { onFootAim = false; }
                try { vehicleAim = Function.Call<bool>(Hash.IS_CONTROL_PRESSED, 0, (int)GTA.Control.VehicleAim); } catch { vehicleAim = false; }
                isAiming = onFootAim || vehicleAim;
            }
            catch (Exception ex)
            {
                ModLog.Error("[Input] Exception calling IS_CONTROL_PRESSED: " + ex);
                isAiming = false;
            }

            // 节流标记（只用于减少日志量），但不持有 Ped handle
            now = Game.GameTime;
            bool enoughTimePassed = now - _lastAimedPublishedAtMs >= AIM_PUBLISH_MIN_INTERVAL_MS;

            if (isAiming)
            {
                if (enoughTimePassed)
                {
                    _lastAimedPublishedAtMs = now;
                    ModLog.Info("[Input] Player is aiming (target-query disabled)");
                }
            }
            else
            {
                _lastAimedPublishedAtMs = now;
            }

            // -------- 修改：H 键（拘捕）不再依赖“动态瞄准到任意 Ped”。
            // 要执行拘捕，必须先通过 L 键锁定目标（LockTargetEvent），或由 LockTargetSystem 提供已锁定目标。
            // 只有存在已锁定目标时才发布 AttemptArrestEvent。
            try
            {
                var core = EFCore.Instance;
                bool hasLockedTarget = core != null && core.LockTargetSystem != null && core.LockTargetSystem.HasTarget;

                bool patrolOn = EF.PoliceMod.Systems.PatrolModeQuery.Enabled;
                bool hasActiveCase = EF.PoliceMod.Systems.CaseStatusQuery.HasActiveCase;

                // H 菜单（案件链路）：仅当不在巡逻模式，或当前存在案件时，才走拘捕菜单。
                // 用 RawKey 做边沿检测：避免换模型后 Game.IsKeyPressed(H) 偶发失灵。
                bool openArrestMenu = IsRawKeyDown(EF.PoliceMod.Core.KeyBindings.ArrestMenu)
                    && hasLockedTarget
                    && (!patrolOn || hasActiveCase);

                if (openArrestMenu)
                {
                    if (!_hHeldRaw)
                    {
                        _hHeldRaw = true;
                        EventBus.Publish(new OpenArrestActionMenuEvent());
                    }
                }
                else
                {
                    _hHeldRaw = false;
                }
            }
            catch (Exception ex)
            {
                // 兜底：不要让输入系统因为查询 core 引用抛出异常
                ModLog.Error("[Input] Error while evaluating H-arrest path: " + ex);
                _arrestKeyHeld = false;
            }



            // 检测射击伤害（简化方式：检测 last damage source or subscribe to SuspectDeadEvent with killer info）
            if (Game.Player.Character.IsShooting)
            {
                // 可能需要在 SuspectController/CaseManager 定位到被击中的 suspect 并由其发出 PlayerShotPedEvent
            }

            // 如果 UI 正在打开中（接管输入），就不要继续发布其他输入事件
            // PoliceTerminalUI / DispatchMenuController 自行处理按键
            if (EF.PoliceMod.Core.UIState.IsPoliceTerminalOpen
                || EF.PoliceMod.Core.UIState.IsDispatchMenuOpen
                || EF.PoliceMod.Core.UIState.IsArrestMenuOpen
                || EF.PoliceMod.Core.UIState.IsUniformMenuOpen
                || EF.PoliceMod.Core.UIState.IsOfficerSquadMenuOpen)
            {
                // 直接返回，阻止 G / L / H / E / Y 等键触发游戏事件
                return;
            }

            // ----- 常规输入处理（仅在 UI 未接管时运行） -----
            // G 键处理（请求跟随 / 押送）
            // 用 RawKey：换模型后 Game.IsKeyPressed(G) 可能偶发失灵。
            // 规则：必须【已锁定】且【已完成拘捕】才允许开始押送。
            if (IsRawKeyDown(EF.PoliceMod.Core.KeyBindings.EscortRequest))
            {
                if (!_gHeldRaw)
                {
                    _gHeldRaw = true;

                    try
                    {
                        var core = EFCore.Instance;
                        bool ok = core != null
                            && core.LockTargetSystem != null
                            && core.LockTargetSystem.HasTarget
                            && core.LockTargetSystem.IsCurrentTargetArrested;

                        if (!ok)
                        {
                            Notification.Show("~y~需要先锁定并拘捕嫌疑人（L 锁定，H 菜单拘捕）");
                            return;
                        }
                    }
                    catch { }

                    EventBus.Publish(new SuspectFollowRequestEvent());
                }
            }
            else
            {
                _gHeldRaw = false;
            }

           
            // L：锁定目标（用 RawKey 做边沿检测，避免偶发"一按就锁定又取消"的抖动）
            if (IsRawKeyDown(EF.PoliceMod.Core.KeyBindings.LockTarget))
            {
                if (!_lockHeld)
                {
                    _lockHeld = true;
                    EventBus.Publish(new LockTargetEvent());
                }
            }
            else
            {
                _lockHeld = false;
            }

            // H 拘捕已由“拘捕动作菜单”接管（见上方 OpenArrestActionMenuEvent），这里不再重复发布。
            // F10: 切换帮助文本（去抖：按住只触发一次）
            if (Game.IsKeyPressed(EF.PoliceMod.Core.KeyBindings.ToggleHelp))
            {
                if (!_f10Held)
                {
                    _f10Held = true;
                    EventBus.Publish(new EF.PoliceMod.Core.ToggleHelpEvent());
#if DEBUG
                    ModLog.Info("[Input] F10 pressed -> ToggleHelpEvent published");
#endif
                }
            }
            else
            {
                _f10Held = false;
            }



            // F7：调度菜单（仅执勤后可用）
            if (IsRawKeyDown(EF.PoliceMod.Core.KeyBindings.DispatchMenu))
            {
                if (!_dispatchMenuHeld)
                {
                    _dispatchMenuHeld = true;


                    bool onDuty = false;
                    try { onDuty = EF.PoliceMod.Systems.DutyQuery.IsOnDuty; } catch { onDuty = false; }
                    if (!onDuty)
                    {
                        Notification.Show("~y~请先开始执勤");
                        return;
                    }

                    EventBus.Publish(new Open911MenuEvent());
                }
            }
            else
            {
                _dispatchMenuHeld = false;
            }

            // F8：警员小队控制菜单（仅执勤后可用）
            if (Game.IsKeyPressed(EF.PoliceMod.Core.KeyBindings.OfficerSquadMenu))
            {
                if (!_f8Held)
                {
                    _f8Held = true;


                    bool onDuty = false;
                    try { onDuty = EF.PoliceMod.Systems.DutyQuery.IsOnDuty; } catch { onDuty = false; }
                    if (!onDuty)
                    {
                        Notification.Show("~y~请先开始执勤");
                        return;
                    }

                    EventBus.Publish(new OpenOfficerSquadMenuEvent());
                }
            }
            else
            {
                _f8Held = false;
            }

            // I 键：逼停（用于"嫌疑人驾车逃逸"案件）
            if (IsRawKeyDown(EF.PoliceMod.Core.KeyBindings.PullOver))
            {
                if (!_pullOverHeld)
                {
                    _pullOverHeld = true;

                    ModLog.Info("[Input] I pressed (pull over)");

                    if (!isAiming)
                    {
                        Notification.Show("~y~请先瞄准嫌疑车辆再按 I 逼停");
                        return;
                    }

                    bool ok = false;
                    try
                    {
                        var core = EFCore.Instance;
                        var lts = core != null ? core.LockTargetSystem : null;
                        var suspect = lts != null ? (lts.CurrentTarget ?? lts.CurrentSuspect) : null;

                        if (suspect == null || !suspect.Exists())
                        {
                            Notification.Show("~y~当前没有可逼停的嫌疑人");
                            ok = false;
                        }
                        else
                        {
                            var player = Game.Player.Character;

                            // 1) 射线命中车辆（优先）
                            if (player != null && player.Exists())
                            {
                                float dist = 9999f;
                                try { dist = player.Position.DistanceTo(suspect.Position); } catch { dist = 9999f; }

                                // 距离再放宽一点，避免“就在面前”但 dist 判定被高度/坐标误差卡住
                                if (dist <= 220f)
                                {
                                    RaycastResult rayVeh = World.Raycast(
                                        GameplayCamera.Position,
                                        GameplayCamera.Position + GameplayCamera.Direction * 280f,
                                        IntersectFlags.Vehicles,
                                        player
                                    );

                                    var hitVeh = rayVeh.DidHit ? (rayVeh.HitEntity as Vehicle) : null;
                                    if (hitVeh != null && hitVeh.Exists())
                                    {
                                        Vehicle suspectVeh = null;
                                        try { suspectVeh = suspect.CurrentVehicle; } catch { suspectVeh = null; }

                                        if (suspectVeh != null && suspectVeh.Exists() && hitVeh.Handle == suspectVeh.Handle)
                                            ok = true;
                                        else
                                        {
                                            // 兜底：命中车的驾驶员就是嫌疑人
                                            try
                                            {
                                                var driver = hitVeh.GetPedOnSeat(VehicleSeat.Driver);
                                                if (driver != null && driver.Exists() && driver.Handle == suspect.Handle)
                                                    ok = true;
                                            }
                                            catch { }
                                        }
                                    }
                                }
                            }

                            // 2) 已 L 锁定：允许直接触发（兼容玩家不方便瞄准车辆时）
                            try
                            {
                                if (!ok && lts != null && lts.HasTarget && lts.CurrentTarget != null && lts.CurrentTarget.Exists() && lts.CurrentTarget.Handle == suspect.Handle)
                                    ok = true;
                            }
                            catch { }
                        }
                    }
                    catch (Exception ex)
                    {
                        ModLog.Error("[Input] Pull over check failed: " + ex);
                        ok = false;
                    }

                    if (ok)
                    {
                        ModLog.Info("[Input] PullOverRequestedEvent published");
                        EventBus.Publish(new EF.PoliceMod.Core.PullOverRequestedEvent());
                    }
                    else
                    {
                        Notification.Show("~y~请把准星对准嫌疑车辆再按 I（距离太远也不行）");
                    }
                }
            }
            else
            {
                _pullOverHeld = false;
            }

            // U 键：要求嫌疑人下车（逼停流程）
            if (Game.IsKeyPressed(EF.PoliceMod.Core.KeyBindings.PullOverExit))
            {
                if (!_pullOverExitHeld)
                {
                    _pullOverExitHeld = true;
                    EventBus.Publish(new EF.PoliceMod.Core.PullOverExitRequestedEvent());
                }
            }
            else
            {
                _pullOverExitHeld = false;
            }

            // 交付嫌疑人（使用可配置按键，默认 Z）
            if (IsRawKeyDown(EF.PoliceMod.Core.KeyBindings.DeliverSuspect))
            {
                if (!_pHeldRaw)
                {
                    _pHeldRaw = true;
                    EventBus.Publish(new DeliverRequestedEvent());
                    ModLog.Info($"[Input] {EF.PoliceMod.Core.KeyBindings.DeliverSuspect} pressed -> DeliverRequestedEvent");
                }
            }
            else
            {
                _pHeldRaw = false;
            }

            // E 键：嫌疑人上下车（明确指令，用 RawKey）
            if (IsRawKeyDown(EF.PoliceMod.Core.KeyBindings.VehicleInteract))
            {
                if (!_eHeldRaw)
                {
                    _eHeldRaw = true;
                    var player = Game.Player.Character;
                    if (player != null && player.Exists())
                    {
                        EventBus.Publish(new EscortVehicleInteractEvent(player.Handle));
                        ModLog.Info("[Input] E pressed → EscortVehicleInteractEvent");
                    }
                }
            }
            else
            {
                _eHeldRaw = false;
            }
        }
    }
}


