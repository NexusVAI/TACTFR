using EF.PoliceMod;
using EF.PoliceMod.Core;
using EF.PoliceMod.Gameplay;
using EF.PoliceMod.Input; // ensure Input event types are directly visible
using GTA;
using GTA.Math;
using GTA.Native;
using GTA.UI;
using System;
using System.Linq;

namespace EF.PoliceMod.Executors
{
    /// <summary>
    /// 嫌疑人车辆押送执行器
    /// - 不持有私有状态
    /// - 不决定状态迁移
    /// - 只监听 SuspectStateHub 并执行行为
    /// </summary>
    public class SuspectVehicleEscortExecutor
    {
        private static readonly Random _rand = new Random();

        private readonly SuspectController _suspectController;
        private readonly SuspectStateHub _stateHub;

        // I 逼停线旁路（抱头线专用）：允许免 L 锁定 + H 拘捕 直接 G/E 操作。
        private const int PULLOVER_BYPASS_TTL_MS = 90 * 1000;
        private readonly PullOverEscortBypassState _pullOverBypass = new PullOverEscortBypassState(PULLOVER_BYPASS_TTL_MS);

        // --- 跟随控制状态（用于强制：必须先按 G 使嫌疑人跟随，才允许按 E 上车） ---
        private bool _isSuspectFollowing = false;
        private int _followingSuspectHandle = -1;
        // 去重/状态记录：防止重复发布 boarded 事件
        private int _lastBoardedSuspectHandle = -1;
        private int _lastBoardedAtMs = 0; // Game.GameTime ms
                                          // 配置：是否强制先按 G 让嫌疑人跟随，才能按 E 让其上车
                                          // 强制：必须先按 G 让嫌疑人进入“跟随/押送”状态，才允许按 E 让其上车。
        private bool _requireFollowBeforeBoard = true;

        // 玩家上下车边沿检测：实现“玩家上车后嫌疑人自动上车 / 玩家下车后嫌疑人自动下车”
        private bool _wasPlayerInVehicle = false;

        private readonly CuffedVehicleDoorFlow _cuffedDoorFlow = new CuffedVehicleDoorFlow();
        // 被拷嫌疑人步态/背手姿势的“时间戳状态”（具体 native 行为已抽离到 CuffedPoseOps）


        private int _lastClipsetRequestMs = 0;
        private int _lastClipsetApplyMs = 0;
        private const int CLIPSET_REQUEST_COOLDOWN_MS = 1500;
        private const int CLIPSET_REAPPLY_COOLDOWN_MS = 650;

        private int _lastCuffedUpperBodyPoseMs = 0;
        private const int CUFFED_UPPERBODY_COOLDOWN_MS = 650;

        private void EnsureCuffedClipset(Ped suspect)
        {
            if (suspect == null || !suspect.Exists()) return;
            if (suspect.IsDead) return;
            if (!VehicleEscortLine.IsCuffed(GetStyle())) return;

            CuffedPoseOps.EnsureClipset(
                suspect,
                ref _lastClipsetRequestMs,
                ref _lastClipsetApplyMs,
                CLIPSET_REQUEST_COOLDOWN_MS,
                CLIPSET_REAPPLY_COOLDOWN_MS
            );
        }

        private void EnsureCuffedUpperBodyPose(Ped suspect)
        {
            if (suspect == null || !suspect.Exists()) return;
            if (suspect.IsDead) return;
            if (!VehicleEscortLine.IsCuffed(GetStyle())) return;

            CuffedPoseOps.EnsureUpperBodyIdle(
                suspect,
                ref _lastCuffedUpperBodyPoseMs,
                CUFFED_UPPERBODY_COOLDOWN_MS
            );
        }





        // === 合并：CuffedVehicleEscortFlow / CuffedVehicleEscortTickFlow ===



        private void StartCuffedExitVehicle(Ped suspect, ArrestActionStyle style)
        {
            if (_suspectController == null) return;
            if (suspect == null || !suspect.Exists() || suspect.IsDead) return;
            if (!suspect.IsInVehicle()) return;

            try
            {
                if (_suspectController.IsBusy(suspect)) return;
            }
            catch { }

            try
            {
                try { _suspectController.MarkBusy(suspect.Handle); } catch { }

                try
                {
                    if (ShouldAutoDoors(style))
                    {
                        var veh = suspect.CurrentVehicle;
                        if (veh != null && veh.Exists())
                        {
                            int doorIndex = GetRearDoorIndexForSuspect(veh, suspect);
                            doorIndex = NormalizeDoorIndex(veh, doorIndex);
                            try { _cuffedDoorFlow.RecordExitDoor(veh.Handle, doorIndex); } catch { }
                            try { VehicleDoorOps.OpenDoor(veh, doorIndex); } catch { }
                        }
                    }
                }
                catch { }

                try { suspect.Task.ClearAll(); } catch { }
                try
                {
                    var veh2 = suspect.CurrentVehicle;
                    if (veh2 != null && veh2.Exists())
                        Function.Call(Hash.TASK_LEAVE_VEHICLE, suspect.Handle, veh2.Handle, 0);
                }
                catch { }
            }
            catch
            {
                try { _suspectController.UnmarkBusy(suspect.Handle); } catch { }
            }
        }

        private void OnCuffedEnteredVehicle(Ped suspect, ArrestActionStyle style, int nowMs)
        {
            if (_suspectController == null) return;
            if (suspect == null || !suspect.Exists()) return;
            if (!suspect.IsInVehicle()) return;

            int handle = suspect.Handle;
            if (_lastBoardedSuspectHandle == handle && nowMs - _lastBoardedAtMs < 2000) return;

            if (_requireFollowBeforeBoard && (!_isSuspectFollowing || _followingSuspectHandle != handle)) return;

            _lastBoardedSuspectHandle = handle;
            _lastBoardedAtMs = nowMs;

            try { EventBus.Publish(new EF.PoliceMod.Core.SuspectBoardedVehicleEvent(handle)); } catch { }
            try { _cuffedDoorFlow.TryShutDoorImmediatelyAfterBoard(suspect.CurrentVehicle, nowMs, style); } catch { }

            try { _suspectController.UnmarkBusy(handle); } catch { }

            _isSuspectFollowing = false;
            _followingSuspectHandle = -1;
        }

        private bool TickCuffedVehicleEscort(
            Ped suspect,
            Ped player,
            ArrestActionStyle style,
            int nowMs)
        {
            if (_stateHub == null) return false;
            if (suspect == null || !suspect.Exists()) return false;
            if (player == null || !player.Exists()) return false;

            bool playerInVehicle = false;
            try { playerInVehicle = player.IsInVehicle(); } catch { playerInVehicle = false; }

            // 过渡期保持手铐/姿势
            try
            {
                if (ShouldAutoVehicleSync(style)
                    && (_stateHub.Is(SuspectState.EnteringVehicle) || _stateHub.Is(SuspectState.InVehicle) || _stateHub.Is(SuspectState.ExitingVehicle)))
                {
                    try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, true); } catch { }
                    try { Function.Call(Hash.SET_ENABLE_BOUND_ANKLES, suspect.Handle, true); } catch { }
                    try { EnsureCuffedClipset(suspect); } catch { }
                    try { EnsureCuffedUpperBodyPose(suspect); } catch { }
                }
            }
            catch { }

            // pending 关门
            try { _cuffedDoorFlow.TickPendingShutDoor(suspect, nowMs, style); } catch { }

            // 玩家上车边沿：嫌疑人自动上车（仅被拷线）
            if (playerInVehicle && !_wasPlayerInVehicle)
            {
                try
                {
                    if (ShouldAutoVehicleSync(style)
                        && _stateHub.Is(SuspectState.Escorting)
                        && !suspect.IsInVehicle()
                        && player.CurrentVehicle != null
                        && player.CurrentVehicle.Exists())
                    {
                        bool gettingIn = false;
                        try { gettingIn = Function.Call<bool>(Hash.IS_PED_GETTING_INTO_A_VEHICLE, suspect.Handle); } catch { gettingIn = false; }
                        if (!gettingIn && suspect.Position.DistanceTo(player.Position) < 7.0f)
                        {
                            _stateHub.ChangeState(SuspectState.EnteringVehicle);
                            _wasPlayerInVehicle = playerInVehicle;
                            return true;
                        }
                    }
                }
                catch { }
            }

            // 玩家下车边沿：嫌疑人自动下车（仅被拷线）
            if (!playerInVehicle && _wasPlayerInVehicle)
            {
                try
                {
                    if (ShouldAutoVehicleSync(style)
                        && _stateHub.Is(SuspectState.InVehicle)
                        && suspect.IsInVehicle())
                    {
                        bool gettingIn = false;
                        try { gettingIn = Function.Call<bool>(Hash.IS_PED_GETTING_INTO_A_VEHICLE, suspect.Handle); } catch { gettingIn = false; }
                        if (!gettingIn)
                        {
                            _stateHub.ChangeState(SuspectState.ExitingVehicle);
                            _wasPlayerInVehicle = playerInVehicle;
                            return true;
                        }
                    }
                }
                catch { }
            }

            _wasPlayerInVehicle = playerInVehicle;

            // EnteringVehicle -> InVehicle
            if (_stateHub.Is(SuspectState.EnteringVehicle) && suspect.IsInVehicle())
            {
                _stateHub.ChangeState(SuspectState.InVehicle);
                try
                {
                    var veh = suspect.CurrentVehicle;
                    if (veh != null && veh.Exists() && !_cuffedDoorFlow.HasPendingDoor())
                    {
                        int doorIndex = GetRearDoorIndexForSuspect(veh, suspect);
                        doorIndex = NormalizeDoorIndex(veh, doorIndex);
                        if (ShouldAutoDoors(style))
                        {
                            try { VehicleDoorOps.ShutDoor(veh, doorIndex); } catch { }
                        }
                    }
                }
                catch { }

                return true;
            }

            // ExitingVehicle -> Escorting
            if (_stateHub.Is(SuspectState.ExitingVehicle) && !suspect.IsInVehicle())
            {
                _stateHub.ChangeState(SuspectState.Escorting);
                try { OnSuspectExitVehicle(); } catch { }
                return true;
            }

            return false;
        }

        private static VehicleSeat FindAvailableSeatForSuspect(Vehicle vehicle)
        {
            if (vehicle == null || !vehicle.Exists()) return VehicleSeat.None;

            try
            {
                if (vehicle.IsSeatFree(VehicleSeat.RightRear)) return VehicleSeat.RightRear;
                if (vehicle.IsSeatFree(VehicleSeat.LeftRear)) return VehicleSeat.LeftRear;
            }
            catch { }

            try { if (vehicle.IsSeatFree(VehicleSeat.Passenger)) return VehicleSeat.Passenger; } catch { }
            return VehicleSeat.None;
        }

        private static int GetDoorIndexForSeat(VehicleSeat seat)
        {
            if (seat == VehicleSeat.RightRear) return 3;
            if (seat == VehicleSeat.LeftRear) return 1;
            if (seat == VehicleSeat.Passenger) return 2;
            return 2;
        }

        private static int NormalizeDoorIndex(Vehicle vehicle, int desiredDoorId)
        {
            if (vehicle == null || !vehicle.Exists()) return desiredDoorId;
            try
            {
                bool valid = Function.Call<bool>(Hash.GET_IS_DOOR_VALID, vehicle.Handle, desiredDoorId);
                if (valid) return desiredDoorId;
            }
            catch { }

            if (desiredDoorId == 1) return 2;
            if (desiredDoorId == 3) return 2;
            return desiredDoorId;
        }
        // (removed) duplicated GetRearDoorIndexForSuspect(Vehicle, Ped)
        // NOTE：保持对旧调用点（VehicleEscortLine.*）的兼容，但真实规则以本类为准。
        // 后续会把外部引用逐步切到 SuspectVehicleEscortExecutor 内部静态类，再删除独立文件。

        internal static class VehicleEscortLine
        {
            internal const float DEFAULT_MAX_E_INTERACT_DISTANCE = 7.0f;

            internal static bool IsCuffed(ArrestActionStyle style) => style == ArrestActionStyle.CuffAndLead;
            internal static bool ShouldAutoDoors(ArrestActionStyle style) => IsCuffed(style);
            internal static bool ShouldAutoVehicleSync(ArrestActionStyle style) => IsCuffed(style);

            internal static float MaxEInteractDistance(ArrestActionStyle style)
            {
                // 先给保守默认值：避免 E 在远处误触发造成状态机抖动
                return DEFAULT_MAX_E_INTERACT_DISTANCE;
            }
        }

        internal static class VehicleSeatDoorOps
        {
            internal static int GetSeatIndexForDoorId(int doorId)
            {
                // 兼容：仅覆盖常见门 id；未知门 id fallback passenger
                // GTA V 常见：                // 0=FL, 1=FR, 2=RL, 3=RR（不同 API/脚本会有差异，这里按本项目既有使用方式兜底）

                if (doorId == 3) return (int)VehicleSeat.RightRear;
                if (doorId == 2) return (int)VehicleSeat.Passenger;
                if (doorId == 1) return (int)VehicleSeat.LeftRear;
                return (int)VehicleSeat.Passenger;
            }
        }
        

        private static bool IsCuffed(ArrestActionStyle style) => VehicleEscortLine.IsCuffed(style);
        private static bool ShouldAutoDoors(ArrestActionStyle style) => VehicleEscortLine.ShouldAutoDoors(style);
        private static bool ShouldAutoVehicleSync(ArrestActionStyle style) => VehicleEscortLine.ShouldAutoVehicleSync(style);





        // 兜底：部分“同步上拷场景/任务切换”可能导致嫌疑人变成非实体（无碰撞/冻结/不动态）
        // 这里每帧做一次 best-effort 修复，避免出现你说的“能穿模过去、嫌疑人一动不动”。
        private void EnsureSuspectIsSolid(Ped suspect)
        {
            if (suspect == null || !suspect.Exists()) return;
            if (suspect.IsDead) return;

            // ENTITY
            try { Function.Call(Hash.FREEZE_ENTITY_POSITION, suspect.Handle, false); } catch { }
            // 有些情况下仅 SET_ENTITY_COLLISION=true 仍然无法恢复（实体被“完全禁用碰撞”）
            try { Function.Call(Hash.SET_ENTITY_COMPLETELY_DISABLE_COLLISION, suspect.Handle, false, false); } catch { }
            try { Function.Call(Hash.SET_ENTITY_COLLISION, suspect.Handle, true, true); } catch { }
            try { Function.Call(Hash.SET_ENTITY_DYNAMIC, suspect.Handle, true); } catch { }
            try { Function.Call(Hash.SET_ENTITY_HAS_GRAVITY, suspect.Handle, true); } catch { }
            try { Function.Call(Hash.ACTIVATE_PHYSICS, suspect.Handle); } catch { }

            // PED：被同步场景/手铐状态搞乱时，强制恢复可物理交互的标志（不触发 ragdoll，仅恢复能力）
            try { Function.Call(Hash.SET_PED_CAN_RAGDOLL, suspect.Handle, true); } catch { }
            try { Function.Call(Hash.SET_PED_CAN_RAGDOLL_FROM_PLAYER_IMPACT, suspect.Handle, true); } catch { }
        }


        public SuspectVehicleEscortExecutor(
            SuspectController suspectController,

            SuspectStateHub stateHub
        )
        {
            _suspectController = suspectController;
            _stateHub = stateHub;

            // 输入 = 意图
            EventBus.Subscribe<EscortVehicleInteractEvent>(OnVehicleInteract);
            // 订阅：G 按键（跟随 / 下车）发布的事件
            EventBus.Subscribe<SuspectFollowRequestEvent>(OnFollowRequest);
            // 订阅：I 逼停自动下车后激活"免锁定/免拘捕"的 E 旁路（仅抱头线）
            EventBus.Subscribe<PullOverEscortBypassActivatedEvent>(OnPullOverBypassActivated);
            // 订阅：案件结束事件，重置跟随状态
            EventBus.Subscribe<CaseEndedEvent>(OnCaseEnded);

            // 状态 = 法律
            _stateHub.OnStateChanged += OnSuspectStateChanged;


            ModLog.Info("[Escort][Vehicle] Executor initialized (StateHub driven)");
        }

        private ArrestActionStyle GetStyle()
        {
            try { return _suspectController != null ? _suspectController.CurrentArrestStyle : ArrestActionStyle.CuffAndLead; }
            catch { return ArrestActionStyle.CuffAndLead; }
        }

        private int GetSeatIndexForDoorId(int doorId) => VehicleSeatDoorOps.GetSeatIndexForDoorId(doorId);

        private Ped FindPedByHandle(int handle)
        {
            if (handle <= 0) return null;
            try { return World.GetAllPeds().FirstOrDefault(p => p != null && p.Exists() && p.Handle == handle); } catch { return null; }
        }

        private void ApplyActionToOtherCompliantCaseSuspects(int currentHandle, Action<Ped> action)
        {
            if (action == null) return;
            try
            {
                var mgr = EFCore.Instance?.GetCaseManager();
                var handles = mgr?.SuspectHandles;
                if (handles == null) return;

                foreach (var h in handles)
                {
                    if (h <= 0 || h == currentHandle) continue;
                    try
                    {
                        if (_suspectController == null || !_suspectController.IsHandleCompliant(h)) continue;
                        var ped = FindPedByHandle(h);
                        if (ped == null || !ped.Exists() || ped.IsDead) continue;
                        action(ped);
                    }
                    catch { }
                }
            }
            catch { }
        }

        private void TryMakeSecondaryFollow(Ped suspect)
        {
            if (suspect == null || !suspect.Exists() || suspect.IsDead) return;
            if (suspect.IsInVehicle()) return;
            try
            {
                if (GetStyle() == ArrestActionStyle.CuffAndLead)
                {
                    try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, true); } catch { }
                    try { Function.Call(Hash.SET_ENABLE_BOUND_ANKLES, suspect.Handle, true); } catch { }
                }
                SuspectFollowOps.StartFollow(_suspectController, suspect, GetStyle());
            }
            catch { }
        }

        private bool IsPlayerNearSuspectInteractionPoint(Ped suspect, Ped player, float extraPadding = 0.0f)
        {
            if (suspect == null || !suspect.Exists() || player == null || !player.Exists()) return false;

            float baseDist = VehicleEscortLine.MaxEInteractDistance(GetStyle()) + extraPadding;
            Vector3 playerPos = player.Position;
            Vector3 suspectPos = suspect.Position;

            try { if (playerPos.DistanceTo(suspectPos) <= baseDist) return true; } catch { }

            // 被拷状态下增加两个交互点（左右两侧），降低双人案 E 交互失败率。
            if (GetStyle() != ArrestActionStyle.CuffAndLead) return false;

            try
            {
                Vector3 fwd = suspect.ForwardVector;
                fwd.Z = 0f;
                float fwdLenSq = (fwd.X * fwd.X) + (fwd.Y * fwd.Y) + (fwd.Z * fwd.Z);
                if (fwdLenSq < 0.001f) fwd = Game.Player.Character.ForwardVector;
                fwd.Normalize();

                Vector3 right = new Vector3(fwd.Y, -fwd.X, 0f);
                Vector3 p1 = suspectPos + right * 1.0f;
                Vector3 p2 = suspectPos - right * 1.0f;
                Vector3 p3 = suspectPos + right * 0.85f + fwd * 0.75f;
                Vector3 p4 = suspectPos - right * 0.85f + fwd * 0.75f;
                float pointRange = 1.7f + extraPadding;

                if (playerPos.DistanceTo(p1) <= pointRange) return true;
                if (playerPos.DistanceTo(p2) <= pointRange) return true;
                if (playerPos.DistanceTo(p3) <= pointRange) return true;
                if (playerPos.DistanceTo(p4) <= pointRange) return true;
            }
            catch { }

            return false;
        }

        private bool IsCaseSuspectInteractable(Ped ped)
        {
            if (ped == null || !ped.Exists() || ped.IsDead) return false;

            bool compliant = false;
            try { compliant = _suspectController != null && _suspectController.IsHandleCompliant(ped.Handle); } catch { compliant = false; }
            if (compliant) return true;

            try
            {
                if (Function.Call<bool>(Hash.IS_PED_CUFFED, ped.Handle)) return true;
            }
            catch { }

            return false;
        }

        private Ped TryResolveInteractSuspect(Ped current, Ped player)
        {
            if (current != null && current.Exists() && !current.IsDead)
            {
                if (IsPlayerNearSuspectInteractionPoint(current, player, 0.2f)) return current;
            }

            try
            {
                var mgr = EFCore.Instance?.GetCaseManager();
                var handles = mgr?.SuspectHandles;
                if (handles == null) return current;

                Ped best = null;
                float bestDist = 99999f;
                foreach (var h in handles)
                {
                    if (h <= 0) continue;
                    var ped = FindPedByHandle(h);
                    if (!IsCaseSuspectInteractable(ped)) continue;
                    if (!IsPlayerNearSuspectInteractionPoint(ped, player, 0.5f)) continue;

                    float d = 99999f;
                    try { d = ped.Position.DistanceTo(player.Position); } catch { d = 99999f; }
                    if (d < bestDist)
                    {
                        bestDist = d;
                        best = ped;
                    }
                }

                if (best != null && best.Exists())
                {
                    try { _suspectController.TakeControl(best); } catch { }
                    return best;
                }
            }
            catch { }

            return current;
        }

        private void TryMakeSecondaryBoard(Ped suspect, Ped player)
        {
            if (suspect == null || !suspect.Exists() || suspect.IsDead) return;
            if (player == null || !player.Exists()) return;
            if (suspect.IsInVehicle()) return;

            Vehicle targetVeh = null;
            try
            {
                if (player.IsInVehicle()) targetVeh = player.CurrentVehicle;
                else targetVeh = World.GetNearbyVehicles(player, 6.0f).FirstOrDefault(v => v != null && v.Exists());
            }
            catch { targetVeh = null; }
            if (targetVeh == null || !targetVeh.Exists()) return;

            var seat = FindAvailableSeatForSuspect(targetVeh);
            if (seat == VehicleSeat.None) return;

            try
            {
                if (ShouldAutoDoors(GetStyle()))
                {
                    int doorIndex = NormalizeDoorIndex(targetVeh, GetDoorIndexForSeat(seat));
                    try { VehicleDoorOps.OpenDoor(targetVeh, doorIndex); } catch { }
                    try { _cuffedDoorFlow.ArmPendingShutDoor(targetVeh.Handle, doorIndex, suspect.Handle, Game.GameTime); } catch { }
                }
            }
            catch { }

            try { suspect.Task.ClearAll(); } catch { }
            if (GetStyle() == ArrestActionStyle.CuffAndLead)
            {
                try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, true); } catch { }
                try { EnsureCuffedClipset(suspect); } catch { }
            }
            try { suspect.Task.EnterVehicle(targetVeh, seat, -1, 1.6f); } catch { }
        }

        // 让嫌疑人跟随玩家（调用 native 任务）
        private void MakeSuspectFollow(Ped suspect)
        {
            SuspectFollowOps.StartFollow(_suspectController, suspect, GetStyle());
            ;
        }

        private void StopSuspectFollow(Ped suspect)
        {
            SuspectFollowOps.StopFollow(_suspectController, suspect);
        }



        /// <summary>
        /// 玩家与车辆交互（只发意图，不执行行为）
        /// </summary>
        private void OnVehicleInteract(EscortVehicleInteractEvent e)
        {
            var suspect = _suspectController.GetCurrentSuspect();
            var player = Game.Player.Character;

            try { suspect = TryResolveInteractSuspect(suspect, player); } catch { }

            // 基本有效性检查
            if (suspect == null || !suspect.Exists())
            {
                ModLog.Warn("[Escort][Vehicle] E pressed but no current suspect");
                Notification.Show("~y~当前无可交互嫌疑人（请靠近嫌疑人(1)/(2)）");
                return;
            }

            if (suspect.IsDead || suspect.IsRagdoll)
            {
                ModLog.Warn("[Escort][Vehicle] E pressed but suspect not controllable");
                return;
            }

            // 防止在中间态重复触发（去抖）
            if (_stateHub.Is(SuspectState.EnteringVehicle) || _stateHub.Is(SuspectState.ExitingVehicle))
            {
                ModLog.Info("[Escort][Vehicle] E pressed but suspect is transitioning");
                return;
            }

            // 先验证 player 是否有效（避免直接访问 player 时发生异常）
            if (player == null || !player.Exists())
            {
                ModLog.Warn("[Escort][Vehicle] E pressed but player invalid");
                return;
            }

            // E 门禁：按线路分流（被拷线 vs 抱头线）
            bool pullOverBypass = false;
            try { pullOverBypass = _pullOverBypass.IsActive(GetStyle(), suspect.Handle, Game.GameTime); } catch { pullOverBypass = false; }

            if (!VehicleEscortInteractGate.EnsureAllowed(GetStyle(), suspect, pullOverBypass))
                return;

            // 上车：Escorting（步行押送）
            if (_stateHub.Is(SuspectState.Escorting))
            {
                if (_requireFollowBeforeBoard)
                {
                    if (!_isSuspectFollowing || _followingSuspectHandle != suspect.Handle)
                    {
                        Notification.Show("~y~请先按 G 让嫌疑人跟随，再按 E 上车");
                        return;
                    }
                }

                // 上拷牵走：允许玩家下车状态下把嫌疑人塞进附近车辆后座（更符合“警察开门塞人”体验）
                try
                {
                    if (GetStyle() == ArrestActionStyle.CuffAndLead && !player.IsInVehicle())
                    {
                        Vehicle nearVeh = null;
                        try { nearVeh = World.GetNearbyVehicles(player, 6.0f).FirstOrDefault(v => v != null && v.Exists()); } catch { nearVeh = null; }
                        if (nearVeh == null || !nearVeh.Exists())
                        {
                            Notification.Show("~y~附近没有车辆");
                            return;
                        }

                        var seat2 = FindAvailableSeatForSuspect(nearVeh);
                        if (seat2 == VehicleSeat.None)
                        {
                            Notification.Show("~y~车辆无空位");
                            return;
                        }

                        // 近距触发保障
                        try
                        {
                            if (!IsPlayerNearSuspectInteractionPoint(suspect, player, 0.2f))
                            {
                                Notification.Show("~y~离嫌疑人太远");
                                return;
                            }
                        }
                        catch { }

                        // 开后门（best-effort）+ 记录 pending 关门（仅被拷线需要）
                        try
                        {
                            int doorIndex = NormalizeDoorIndex(nearVeh, GetDoorIndexForSeat(seat2));

                            // 先把门打开，避免 AI 找不到进车点
                            try { VehicleDoorOps.OpenDoor(nearVeh, doorIndex); } catch { }
                            try { _cuffedDoorFlow.ArmPendingShutDoor(nearVeh.Handle, doorIndex, suspect.Handle, Game.GameTime); } catch { }
                        }
                        catch { }

                        // 发起 EnterVehicle
                        try { suspect.Task.ClearAll(); } catch { }
                        try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, true); } catch { }
                        try { EnsureCuffedClipset(suspect); } catch { }
                        try { suspect.Task.EnterVehicle(nearVeh, seat2, -1, 1.6f); } catch { }

                        _stateHub.ChangeState(SuspectState.EnteringVehicle);
                        try { ApplyActionToOtherCompliantCaseSuspects(suspect.Handle, p => TryMakeSecondaryBoard(p, player)); } catch { }
                        ModLog.Info("[Escort][Vehicle] CuffAndLead on-foot E -> EnteringVehicle issued");
                        return;
                    }
                }
                catch { }

                // 其它情况：保持旧逻辑（要求玩家在车内）
                if (!player.IsInVehicle())
                {
                    ModLog.Info("[Escort][Vehicle] E pressed but player not in vehicle");
                    return;
                }

                var vehicle = player.CurrentVehicle;
                if (vehicle == null || !vehicle.Exists())
                {
                    ModLog.Info("[Escort][Vehicle] E pressed but no valid player vehicle");
                    return;
                }

                var seat = FindAvailableSeatForSuspect(vehicle);
                if (seat == VehicleSeat.None)
                {
                    ModLog.Info("[Escort][Vehicle] No available seat");
                    return;
                }

                // 近距触发保障（避免远处误触）
                try
                {
                    if (!IsPlayerNearSuspectInteractionPoint(suspect, player, 0.2f))
                    {
                        ModLog.Info("[Escort][Vehicle] E pressed but suspect too far");
                        return;
                    }
                }
                catch (Exception exPos)
                {
                    ModLog.Error("[Escort][Vehicle] Distance check failed: " + exPos);
                    return;
                }

                // 进入过渡态：只切状态，由 OnStateChanged 统一执行 StartEnterVehicle（避免重复下任务）
                _stateHub.ChangeState(SuspectState.EnteringVehicle);
                try { ApplyActionToOtherCompliantCaseSuspects(suspect.Handle, p => TryMakeSecondaryBoard(p, player)); } catch { }
                ModLog.Info("[Escort][Vehicle] E pressed → EnteringVehicle issued");

                return;
            }

            // 下车：仅在 InVehicle 时触发
            if (_stateHub.Is(SuspectState.InVehicle))
            {
                // 同样做近距与可控性保障
                if (suspect.Position.DistanceTo(player.Position) > 6.0f)
                {
                    ModLog.Info("[Escort][Vehicle] E pressed but suspect too far to exit safely");
                    return;
                }
                // 同上：只切状态，由 OnStateChanged 统一执行 StartExitVehicle（避免重复下任务）
                _stateHub.ChangeState(SuspectState.ExitingVehicle);
                ModLog.Info("[Escort][Vehicle] E pressed → ExitingVehicle issued");
                ;
                return;
            }

            // 其他状态不处理
            ModLog.Info("[Escort][Vehicle] E pressed but no action for current suspect state");
        }
        /// <summary>
        /// 处理玩家按 G 的意图（跟随 / 下车）
        /// 事件来源：InputManager 发布 SuspectFollowRequestEvent
        /// 语义：第一次按 G -> 让当前嫌疑人跟随；再次按 G -> 取消跟随并请求其下车（若在车内）
        /// </summary>
        private void OnFollowRequest(SuspectFollowRequestEvent e)
        {
            try
            {
                var suspect = _suspectController.GetCurrentSuspect();
                if (suspect == null || !suspect.Exists())
                {
                    ModLog.Warn("[Escort][Follow] Follow requested but no current suspect");
                    Notification.Show("当前无可操作的嫌疑人");
                    return;
                }

                // 上车/下车过渡态：忽略 G（否则会把 EnteringVehicle 流程打断，日志里反复出现 transition）
                try
                {
                    if (_stateHub.Is(SuspectState.EnteringVehicle) || _stateHub.Is(SuspectState.ExitingVehicle))
                    {
                        Notification.Show("~y~嫌疑人正在上下车，请稍等");
                        return;
                    }
                }
                catch { }

                // 如果当前嫌疑人在车内 -> 请求其下车（优先下车）
                if (suspect.IsInVehicle())
                {
                    // 取消跟随标记（如果之前有）
                    _isSuspectFollowing = false;
                    _followingSuspectHandle = -1;

                    // 发起下车流程：只切状态，由 OnStateChanged 统一执行 StartExitVehicle（避免重复下任务）
                    _stateHub.ChangeState(SuspectState.ExitingVehicle);
                    ModLog.Info("[Escort][Follow] Follow pressed -> suspect in vehicle -> ExitVehicle issued");

                    Notification.Show("请求嫌疑人下车");
                    return;
                }

                // 如果不在车内：切换跟随/取消跟随
                if (!_isSuspectFollowing || _followingSuspectHandle != suspect.Handle)
                {
                    // 关闭“受惊逃跑”随机触发：按 G 只负责进入跟随，避免流程被随机打断。

                    _isSuspectFollowing = true;
                    _followingSuspectHandle = suspect.Handle;

                    // 被拷线：按 G 的瞬间强制维持被拷态（双手在后）
                    try
                    {
                        if (GetStyle() == ArrestActionStyle.CuffAndLead)
                        {
                            try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, true); } catch { }
                            try { Function.Call(Hash.SET_ENABLE_BOUND_ANKLES, suspect.Handle, true); } catch { }
                            try { EnsureCuffedClipset(suspect); } catch { }
                            try { EnsureCuffedUpperBodyPose(suspect); } catch { }
                        }
                    }
                    catch { }

                    // 真正下达“跟随”任务（之前只改了标记，容易出现你说的“按 G 没反应”）
                    try { MakeSuspectFollow(suspect); } catch { }
                    try { ApplyActionToOtherCompliantCaseSuspects(suspect.Handle, p => TryMakeSecondaryFollow(p)); } catch { }

                    ModLog.Info("[Escort][Follow] Suspect set to follow (handle=" + suspect.Handle + ")");
                    Notification.Show("已下达跟随：所有已拘捕嫌疑人将跟随");
                }
                else
                {
                    // 已经在跟随 -> 取消跟随
                    _isSuspectFollowing = false;
                    _followingSuspectHandle = -1;

                    try { StopSuspectFollow(suspect); } catch { }

                    ModLog.Info("[Escort][Follow] Suspect follow cancelled (handle=" + suspect.Handle + ")");
                    Notification.Show("已取消跟随");
                }
            }
            catch (Exception ex)
            {
                ModLog.Error("[Escort][Follow] OnFollowRequest error: " + ex);
            }
        }

        private void OnPullOverBypassActivated(PullOverEscortBypassActivatedEvent e)
        {
            try
            {
                if (e == null) return;
                if (e.SuspectHandle <= 0) return;

                _pullOverBypass.Activate(e.SuspectHandle, Game.GameTime);
                ModLog.Info($"[Escort][Vehicle] PullOver bypass activated: suspect={e.SuspectHandle} ttlMs={PULLOVER_BYPASS_TTL_MS}");
            }
            catch (Exception ex)
            {
                ModLog.Error("[Escort][Vehicle] OnPullOverBypassActivated error: " + ex);
            }
        }

        private void OnCaseEnded(CaseEndedEvent e)
        {
            try
            {
                _isSuspectFollowing = false;
                _followingSuspectHandle = -1;
                ModLog.Info("[Escort][Vehicle] Case ended - reset follow state");
            }
            catch (Exception ex)
            {
                ModLog.Error("[Escort][Vehicle] OnCaseEnded error: " + ex);
            }
        }

        /// <summary>
        /// 在嫌疑人真正离开车辆（ExitingVehicle -> Escorting）后调用：
        /// - 清理上车去重记录（允许下次再次发布 boarded event）
        /// - 保留/恢复跟随状态（根据业务）
        /// </summary>
        private void OnSuspectExitVehicle()
        {
            try
            {
                var suspect = _suspectController.GetCurrentSuspect();
                int handle = suspect != null && suspect.Exists() ? suspect.Handle : -1;

                // 清理上车去重状态，这样下一次上车会再次发布 boarded event
                _lastBoardedSuspectHandle = -1;
                _lastBoardedAtMs = 0;



                ModLog.Info("[Escort][Vehicle] Suspect exited vehicle - cleared boarded record (handle=" + handle + ")");
                try { _suspectController.UnmarkBusy(handle); } catch (Exception ex) { ModLog.Error("[Escort][Vehicle] UnmarkBusy after OnSuspectExitVehicle failed: " + ex); }

            }
            catch (Exception ex)
            {
                ModLog.Error("[Escort][Vehicle] OnSuspectExitVehicle error: " + ex);
            }
        }


        /// <summary>
        /// 监听嫌疑人状态变化（唯一执行入口）
        /// </summary>
        private void OnSuspectStateChanged(
            SuspectState oldState,
            SuspectState newState
        )
        {
            ModLog.Info($"[Escort][Vehicle] StateChanged: {oldState} -> {newState}");

            switch (newState)
            {

                case SuspectState.EnteringVehicle:
                    StartEnterVehicle();
                    break;

                case SuspectState.InVehicle:
                    OnEnteredVehicle();
                    break;

                case SuspectState.ExitingVehicle:
                    StartExitVehicle();
                    break;

                case SuspectState.Escorting:
                    ResumeEscortOnFoot();
                    break;
            }
            // 兼容性保护：如果状态变成 Escorting，但嫌疑人已经在车内（某些时机会直接跳过 InVehicle 状态），
            // 我们仍然需要触发 OnEnteredVehicle 以发布 SuspectBoardedVehicleEvent（导航等依赖）
            if (newState == SuspectState.Escorting)
            {
                try
                {
                    var suspect = _suspectController.GetCurrentSuspect();
                    if (suspect != null && suspect.Exists() && suspect.IsInVehicle())
                    {
                        ModLog.Info("[Escort][Vehicle] Detected Escorting but suspect is in vehicle -> invoking OnEnteredVehicle");
                        OnEnteredVehicle();
                    }
                }
                catch (Exception ex)
                {
                    ModLog.Error("[Escort][Vehicle] Error in Escorting->InVehicle compatibility check: " + ex);
                }
            }

            // —— 过渡态完成检测（放在 switch 之后） ——

            // EnteringVehicle -> InVehicle
            if (_stateHub.Is(SuspectState.EnteringVehicle))
            {
                var suspect = _suspectController.GetCurrentSuspect();
                if (suspect != null && suspect.Exists() && suspect.IsInVehicle())
                {
                    _stateHub.ChangeState(SuspectState.InVehicle);
                    ModLog.Info("[Escort][Vehicle] Enter vehicle confirmed → State = InVehicle");
                }
            }

            // ExitingVehicle -> Escorting
            if (_stateHub.Is(SuspectState.ExitingVehicle))
            {
                var suspect = _suspectController.GetCurrentSuspect();
                if (suspect != null && suspect.Exists() && !suspect.IsInVehicle())
                {
                    _stateHub.ChangeState(SuspectState.Escorting);
                    ModLog.Info("[Escort][Vehicle] Exit vehicle confirmed → State = Escorting");

                    // 在确认下车后清理 boarded 去重（保证下次上车能正确触发）
                    OnSuspectExitVehicle();

                    // 下车后关门（best-effort；避免 TickUpdate 未驱动时残留开门）
                    try
                    {
                        _cuffedDoorFlow.TryShutDoorAfterExit(
                            GetStyle(),
                            (h) => World.GetAllVehicles().FirstOrDefault(x => x != null && x.Exists() && x.Handle == h),
                            (v, d) => NormalizeDoorIndex(v, d)
                        );
                    }
                    catch { }

                    // 下车后关门（best-effort；避免 TickUpdate 未驱动时残留开门）
                    try
                    {
                        _cuffedDoorFlow.TryShutDoorAfterExit(
                            GetStyle(),
                            (h) => World.GetAllVehicles().FirstOrDefault(x => x != null && x.Exists() && x.Handle == h),
                            (v, d) => NormalizeDoorIndex(v, d)
                        );
                    }
                    catch { }
                }
            }
        }

        private int GetRearDoorIndexForSuspect(Vehicle vehicle, Ped suspect)
        {
            if (vehicle == null || !vehicle.Exists()) return 2;
            if (suspect == null || !suspect.Exists()) return 2;

            // seat index：-1 driver, 0 front passenger, 1 left rear, 2 right rear（常见约定）
            try
            {
                int leftRear = Function.Call<int>(Hash.GET_PED_IN_VEHICLE_SEAT, vehicle.Handle, 1);
                if (leftRear == suspect.Handle) return NormalizeDoorIndex(vehicle, 1); // 后左门
            }
            catch { }

            try
            {
                int rightRear = Function.Call<int>(Hash.GET_PED_IN_VEHICLE_SEAT, vehicle.Handle, 2);
                if (rightRear == suspect.Handle) return NormalizeDoorIndex(vehicle, 3); // 后右门
            }
            catch { }

            try
            {
                int frontPassenger = Function.Call<int>(Hash.GET_PED_IN_VEHICLE_SEAT, vehicle.Handle, 0);
                if (frontPassenger == suspect.Handle) return NormalizeDoorIndex(vehicle, 2); // 副驾门
            }
            catch { }

            return NormalizeDoorIndex(vehicle, 2);
        }


        private void StartExitVehicle()
        {
            var suspect = _suspectController.GetCurrentSuspect();
            StartCuffedExitVehicle(suspect, GetStyle());
        }




        // =========================
        // 行为执行（当前阶段：空壳）
        // 下一刀会把你原本“变淡”的 Task 代码塞进        // =========================

        private void StartEnterVehicle()
        {

            var suspect = _suspectController.GetCurrentSuspect();
            var player = Game.Player.Character;
            if (suspect == null || !suspect.Exists()) return;
            if (player == null || !player.Exists())
            {
                ModLog.Warn("[Escort][Vehicle] StartEnterVehicle aborted: player invalid");
                return;
            }

            Vehicle vehicle = null;
            if (player.IsInVehicle())
            {
                vehicle = player.CurrentVehicle;
            }
            else
            {
                // 允许玩家不在车内时也能“塞人上车”：选择最近车辆（保守距离）
                try { vehicle = World.GetAllVehicles().OrderBy(v => v.Position.DistanceTo(player.Position)).FirstOrDefault(); } catch { vehicle = null; }
            }

            if (vehicle == null || !vehicle.Exists()) return;

            var seat = FindAvailableSeatForSuspect(vehicle);
            if (seat == VehicleSeat.None) return;

            try
            {
                // 仅在需要自动开门时处理车门
                if (ShouldAutoDoors(GetStyle()))
                {
                    int doorIndex = NormalizeDoorIndex(vehicle, GetDoorIndexForSeat(seat));
                    try { VehicleDoorOps.OpenDoor(vehicle, doorIndex); } catch { }
                    try { _cuffedDoorFlow.ArmPendingShutDoor(vehicle.Handle, doorIndex, suspect.Handle, Game.GameTime); } catch { }
                }
            }
            catch { }

            try { suspect.Task.ClearAll(); } catch { }
            try { EnsureCuffedClipset(suspect); } catch { }
            try { EnsureCuffedUpperBodyPose(suspect); } catch { }

            try { suspect.Task.EnterVehicle(vehicle, seat); } catch { }
        }


        // 兼容遗留调用点：之前有部分流程会调用 _cuffedEscortFlow 的方法；
        // 现在统一走本类的合并实现。
        private void StartEnterVehicleLegacy() => StartEnterVehicle();






        // 替换 OnEnteredVehicle() 或相应检测上车处
        private void OnEnteredVehicle()
        {
            var suspect = _suspectController.GetCurrentSuspect();
            int now = Game.GameTime;
            OnCuffedEnteredVehicle(suspect, GetStyle(), now);
        }




        /// <summary>
        /// 每帧检测“上车/下车”过渡态是否完成。
        /// 只在 StateChanged 里检测会漏掉：任务完成发生在后续帧，但没有新的状态事件。
        /// </summary>
        public void TickUpdate()
        {
            try
            {
                var suspect = _suspectController.GetCurrentSuspect();
                var player = Game.Player.Character;
                var style = GetStyle();

                // 兜底：嫌疑人被上拷后偶发变“非实体可穿模”，这里每帧强制恢复（仅在已控制时）
                try
                {
                    if (_suspectController != null && _suspectController.IsCompliant)
                        EnsureSuspectIsSolid(suspect);
                }
                catch { }
                if (TickCuffedVehicleEscort(suspect, player, style, Game.GameTime))
                    return;

                // 下车后关门（兜底，避免 door pending 残留）
                try
                {
                    if (_stateHub.Is(SuspectState.Escorting))
                    {
                        _cuffedDoorFlow.TryShutDoorAfterExit(
                            style,
                            (h) => World.GetAllVehicles().FirstOrDefault(x => x != null && x.Exists() && x.Handle == h),
                            (v, d) => NormalizeDoorIndex(v, d)
                        );
                    }
                }
                catch { }
            }
            catch (Exception ex)

            {
                ModLog.Error("[Escort][Vehicle] TickUpdate error: " + ex);
            }
        }

        // 兼容遗留调用点：之前有部分流程会调用 _cuffedEscortFlow 的方法；
        // 现在统一走本类的合并实现。
   
        private void ResumeEscortOnFoot()
        {
            ModLog.Info("[Escort][Vehicle] Execute: ResumeEscortOnFoot");
            // TODO: 恢复押送跟随
            // Escort 状态下，Follow Executor 会自然接管

        }
    }
}


