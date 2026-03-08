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
        private readonly SuspectStyleRegistry _styleRegistry;
        private readonly EF.PoliceMod.Suspects.SuspectContextRegistry _ctxRegistry;
        private readonly EF.PoliceMod.Suspects.StateHubRouter _hubRouter;

        // 车门动作节流：避免每帧重复 Open/Close 导致车辆物理抖动/倾斜甚至翻车
        private const int DOOR_ACTION_COOLDOWN_MS = 650;
        private int _lastDoorActionAtMs = 0;
        private int _lastDoorActionVehicleHandle = -1;
        private int _lastDoorActionDoorIndex = -1;
        private bool TryBeginDoorAction(int nowMs, Vehicle veh, int doorIndex)
        {
            if (veh == null || !veh.Exists()) return false;
            int vh = veh.Handle;
            if (_lastDoorActionVehicleHandle == vh
                && _lastDoorActionDoorIndex == doorIndex
                && nowMs - _lastDoorActionAtMs < DOOR_ACTION_COOLDOWN_MS)
                return false;
            _lastDoorActionVehicleHandle = vh;
            _lastDoorActionDoorIndex = doorIndex;
            _lastDoorActionAtMs = nowMs;
            return true;
        }

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
        private int _lastVehicleInteractRejectAtMs = 0;

        // 玩家上下车边沿检测：实现“玩家上车后嫌疑人自动上车 / 玩家下车后嫌疑人自动下车”
        private bool _wasPlayerInVehicle = false;

        private readonly CuffedVehicleDoorFlow _cuffedDoorFlow = new CuffedVehicleDoorFlow();

        private bool _handlingStateChange = false;
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
            if (!VehicleEscortLine.IsCuffed(GetStyleFor(suspect.Handle))) return;

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
            if (!VehicleEscortLine.IsCuffed(GetStyleFor(suspect.Handle))) return;

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
                            try
                            {
                                if (TryBeginDoorAction(Game.GameTime, veh, doorIndex))
                                    VehicleDoorOps.OpenDoor(veh, doorIndex);
                            }
                            catch { }
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

            if (_requireFollowBeforeBoard && !IsSuspectFollowing(handle)) return;
            _lastBoardedSuspectHandle = handle;
            _lastBoardedAtMs = nowMs;
            try { EventBus.Publish(new EF.PoliceMod.Core.SuspectBoardedVehicleEvent(handle)); } catch { }
            try
            {
                var veh = suspect.CurrentVehicle;
                if (veh != null && veh.Exists())
                {
                    int doorIndex = GetRearDoorIndexForSuspect(veh, suspect);
                    doorIndex = NormalizeDoorIndex(veh, doorIndex);
                    if (ShouldAutoDoors(style) && TryBeginDoorAction(nowMs, veh, doorIndex))
                        VehicleDoorOps.ShutDoor(veh, doorIndex);
                }
            }
            catch { }

            try { _suspectController.UnmarkBusy(handle); } catch { }

            SetSuspectFollowing(handle, false);
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
                    && (IsState(SuspectState.EnteringVehicle) || IsState(SuspectState.InVehicle) || IsState(SuspectState.ExitingVehicle)))
                {
                    try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, true); } catch { }
                    try { Function.Call(Hash.SET_ENABLE_BOUND_ANKLES, suspect.Handle, true); } catch { }
                    try { EnsureCuffedClipset(suspect); } catch { }
                    try { EnsureCuffedUpperBodyPose(suspect); } catch { }
                }
            }
            catch { }

            // 玩家上车边沿：嫌疑人自动上车（仅被拷线）
            if (playerInVehicle && !_wasPlayerInVehicle)
            {
                try
                {
                    if (ShouldAutoVehicleSync(style)
                        && IsState(SuspectState.Escorting)
                        && !suspect.IsInVehicle()
                        && player.CurrentVehicle != null
                        && player.CurrentVehicle.Exists())
                    {
                        bool gettingIn = false;
                        try { gettingIn = Function.Call<bool>(Hash.IS_PED_GETTING_INTO_A_VEHICLE, suspect.Handle); } catch { gettingIn = false; }
                        if (!gettingIn && suspect.Position.DistanceTo(player.Position) < 7.0f)
                        {
                            ChangeState(SuspectState.EnteringVehicle);
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
                        && IsState(SuspectState.InVehicle)
                        && suspect.IsInVehicle())
                    {
                        bool gettingIn = false;
                        try { gettingIn = Function.Call<bool>(Hash.IS_PED_GETTING_INTO_A_VEHICLE, suspect.Handle); } catch { gettingIn = false; }
                        if (!gettingIn)
                        {
                            ChangeState(SuspectState.ExitingVehicle);
                            _wasPlayerInVehicle = playerInVehicle;
                            return true;
                        }
                    }
                }
                catch { }
            }

            _wasPlayerInVehicle = playerInVehicle;

            // EnteringVehicle -> InVehicle
            if (IsState(SuspectState.EnteringVehicle) && suspect.IsInVehicle())
            {
                ChangeState(SuspectState.InVehicle);
                try { OnCuffedEnteredVehicle(suspect, style, nowMs); } catch { }
                return true;
            }


            // ExitingVehicle -> Escorting
            if (IsState(SuspectState.ExitingVehicle) && !suspect.IsInVehicle())
            {
                ChangeState(SuspectState.Escorting);
                try { OnSuspectExitVehicle(); } catch { }
                try
                {
                    _cuffedDoorFlow.TryShutDoorAfterExit(
                        style,
                        (h) => FindVehicleByHandle(h),
                        (v, d) => NormalizeDoorIndex(v, d)
                    );
                }
                catch { }
                try
                {
                    if (ShouldAutoDoors(style))
                    {
                        var veh = player != null && player.Exists() ? player.CurrentVehicle : null;
                        if (veh == null || !veh.Exists()) veh = World.GetNearbyVehicles(suspect, 10.0f).FirstOrDefault(v => v != null && v.Exists());
                        if (veh != null && veh.Exists())
                        {
                            try { VehicleDoorOps.ShutDoor(veh, NormalizeDoorIndex(veh, 1)); } catch { }
                            try { VehicleDoorOps.ShutDoor(veh, NormalizeDoorIndex(veh, 3)); } catch { }
                        }
                    }
                }
                catch { }
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

        public static class VehicleEscortLine
        {
            internal const float DEFAULT_MAX_E_INTERACT_DISTANCE = 9.5f;

            internal const float PLAYER_SUSPECT_E_INTERACT_DISTANCE = 6.5f;
            internal static bool IsCuffed(ArrestActionStyle style) => style == ArrestActionStyle.CuffAndLead;

            internal static bool ShouldAutoDoors(ArrestActionStyle style) => IsCuffed(style);
            internal static bool ShouldAutoVehicleSync(ArrestActionStyle style) => IsCuffed(style);

            internal static float MaxEInteractDistance(ArrestActionStyle style)
            {
                // 单人被拷线适当放宽，减少“明明在押送但 E 提示太远”的误判。
                if (IsCuffed(style)) return 11.0f;
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
            SuspectStateHub stateHub,
            SuspectStyleRegistry styleRegistry,
            EF.PoliceMod.Suspects.SuspectContextRegistry ctxRegistry,
            EF.PoliceMod.Suspects.StateHubRouter hubRouter)
        {
            _suspectController = suspectController;
            _stateHub = stateHub;
            _styleRegistry = styleRegistry;
            _ctxRegistry = ctxRegistry;
            _hubRouter = hubRouter;

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

        private SuspectStateHub GetActiveHub()
        {
            try
            {
                var suspect = _suspectController?.GetCurrentSuspect();
                if (suspect != null && suspect.Exists() && _hubRouter != null)
                {
                    return _hubRouter.GetHubFor(suspect.Handle);
                }
            }
            catch { }
            return _stateHub;
        }

        private SuspectStateHub GetActiveHubFor(int handle)
        {
            try
            {
                if (handle > 0 && _hubRouter != null)
                {
                    return _hubRouter.GetHubFor(handle);
                }
            }
            catch { }
            return _stateHub;
        }

        private bool IsState(SuspectState state)
        {
            return GetActiveHub().Is(state);
        }

        private bool IsStateFor(int handle, SuspectState state)
        {
            return GetActiveHubFor(handle).Is(state);
        }

        private void ChangeState(SuspectState newState)
        {
            try
            {
                var suspect = _suspectController?.GetCurrentSuspect();
                int h = suspect != null && suspect.Exists() ? suspect.Handle : -1;
                if (_hubRouter != null)
                {
                    var hub = _hubRouter.GetWriterHubFor(h, newState);
                    hub.ChangeState(newState);
                    return;
                }
            }
            catch { }
            _stateHub.ChangeState(newState);
        }

        public void SubscribeToPerHandleHub(SuspectStateHub perHandleHub)
        {
            if (perHandleHub == null) return;
            try { perHandleHub.OnStateChanged -= OnSuspectStateChanged; } catch { }
            perHandleHub.OnStateChanged += OnSuspectStateChanged;
            ModLog.Info($"[Escort][Vehicle] Subscribed to per-handle hub (handle={perHandleHub.SuspectHandle})");
        }

        private ArrestActionStyle GetStyle()
        {
            try
            {
                var suspect = _suspectController?.GetCurrentSuspect();
                if (suspect != null && suspect.Exists() && _styleRegistry != null)
                {
                    return _styleRegistry.GetStyleOrDefault(
                        suspect.Handle,
                        _suspectController.CurrentArrestStyle
                    );
                }
            }
            catch { }

            try { return _suspectController != null ? _suspectController.CurrentArrestStyle : ArrestActionStyle.CuffAndLead; }
            catch { return ArrestActionStyle.CuffAndLead; }
        }

        private ArrestActionStyle GetStyleFor(int suspectHandle)
        {
            try
            {
                if (suspectHandle > 0 && _styleRegistry != null)
                {
                    return _styleRegistry.GetStyleOrDefault(
                        suspectHandle,
                        ArrestActionStyle.CuffAndLead
                    );
                }
            }
            catch { }

            try { return _suspectController != null ? _suspectController.CurrentArrestStyle : ArrestActionStyle.CuffAndLead; }
            catch { return ArrestActionStyle.CuffAndLead; }
        }

        private bool IsSuspectFollowing(int handle)
        {
            try
            {
                if (handle > 0 && _ctxRegistry != null)
                {
                    if (_ctxRegistry.TryGet(handle, out var ctx))
                    {
                        return ctx.FollowRequested;
                    }
                }
            }
            catch { }

            return _isSuspectFollowing && _followingSuspectHandle == handle;
        }

        private void SetSuspectFollowing(int handle, bool following)
        {
            try
            {
                if (handle > 0 && _ctxRegistry != null)
                {
                    var ctx = _ctxRegistry.GetOrCreate(handle);
                    if (ctx != null)
                    {
                        ctx.FollowRequested = following;
                    }
                }
            }
            catch { }

            if (following)
            {
                _isSuspectFollowing = true;
                _followingSuspectHandle = handle;
            }
            else
            {
                _isSuspectFollowing = false;
                _followingSuspectHandle = -1;
            }
        }

        private int GetSeatIndexForDoorId(int doorId) => VehicleSeatDoorOps.GetSeatIndexForDoorId(doorId);

        private Ped FindPedByHandle(int handle)
        {
            if (handle <= 0) return null;
            try
            {
                if (!Function.Call<bool>(Hash.DOES_ENTITY_EXIST, handle))
                    return null;
                return Entity.FromHandle(handle) as Ped;
            }
            catch { return null; }
        }

        private Vehicle FindVehicleByHandle(int handle)
        {
            if (handle <= 0) return null;
            try
            {
                if (!Function.Call<bool>(Hash.DOES_ENTITY_EXIST, handle))
                    return null;
                return Entity.FromHandle(handle) as Vehicle;
            }
            catch { return null; }
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
                var style = GetStyleFor(suspect.Handle);
                if (style == ArrestActionStyle.CuffAndLead)
                {
                    try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, true); } catch { }
                    try { Function.Call(Hash.SET_ENABLE_BOUND_ANKLES, suspect.Handle, true); } catch { }
                }
                SuspectFollowOps.StartFollow(_suspectController, suspect, style);
            }
            catch { }
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
                int doorIndex = NormalizeDoorIndex(targetVeh, GetDoorIndexForSeat(seat));
                try { VehicleDoorOps.OpenDoor(targetVeh, doorIndex); } catch { }
                try { _cuffedDoorFlow.ArmPendingShutDoor(targetVeh.Handle, doorIndex, suspect.Handle, Game.GameTime); } catch { }
            }
            catch { }

            try { suspect.Task.ClearAll(); } catch { }
            try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, true); } catch { }
            try { EnsureCuffedClipset(suspect); } catch { }
            try { suspect.Task.EnterVehicle(targetVeh, seat, -1, 1.6f); } catch { }
        }

        // 让嫌疑人跟随玩家（调用 native 任务）
        private void MakeSuspectFollow(Ped suspect)
        {
            SuspectFollowOps.StartFollow(_suspectController, suspect, GetStyleFor(suspect.Handle));
            ;
        }

        private void StopSuspectFollow(Ped suspect)
        {
            SuspectFollowOps.StopFollow(_suspectController, suspect);
        }

        private bool IsVehicleBoardingContextNear(Ped suspect, Ped player, Vehicle vehicle, float maxDist)
        {
            try
            {
                if (vehicle == null || !vehicle.Exists() || suspect == null || !suspect.Exists() || player == null || !player.Exists()) return false;

                // 玩家在车门附近 + 嫌疑人在车辆附近即可触发上车，不再死卡玩家-嫌疑人点位。
                float playerToVeh = player.Position.DistanceTo(vehicle.Position);
                float suspectToVeh = suspect.Position.DistanceTo(vehicle.Position);
                if (playerToVeh <= 7.0f && suspectToVeh <= maxDist) return true;
            }
            catch { }
            return false;
        }

        private void NotifyVehicleInteractReject(string message, int debounceMs = 800)
        {
            int now = Game.GameTime;
            if ((now - _lastVehicleInteractRejectAtMs) < debounceMs) return;
            _lastVehicleInteractRejectAtMs = now;
            Notification.Show(message);
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

            if (suspect.IsDead || (suspect.IsRagdoll && !IsState(SuspectState.InVehicle)))
            {
                ModLog.Warn("[Escort][Vehicle] E pressed but suspect not controllable");
                return;
            }

            // 防止在中间态重复触发（去抖）
            if (IsState(SuspectState.EnteringVehicle) || IsState(SuspectState.ExitingVehicle))
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
            ArrestActionStyle interactStyle = GetStyleFor(suspect.Handle);
            try { pullOverBypass = _pullOverBypass.IsActive(interactStyle, suspect.Handle, Game.GameTime); } catch { pullOverBypass = false; }

            if (!VehicleEscortInteractGate.EnsureAllowed(interactStyle, suspect, pullOverBypass))
                return;

            // 规则：E 只负责“上下车”；前置必须先按 G 进入押送。
            // Restrained 状态下按 E 只提示，不做任何自动跟随/自动押送。
            if (IsState(SuspectState.Restrained))
            {
                Notification.Show("~y~请先按 G 让嫌疑人跟随，再按 E 上下车");
                return;
            }


            // 上车：Escorting（步行押送）
            if (IsState(SuspectState.Escorting))
            {
                bool requireFollow = _requireFollowBeforeBoard;
                try
                {
                    if (GetStyle() == ArrestActionStyle.HandsOnHeadFollow)
                        requireFollow = false;
                }
                catch { }
                if (requireFollow)
                {
                    // E 前置 G：如果没按 G（跟随未开启），直接拒绝（不再由 E 自动补跟随）。
                    if (!IsSuspectFollowing(suspect.Handle))
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
                            if (!IsPlayerNearSuspectInteractionPoint(suspect, player, VehicleEscortLine.PLAYER_SUSPECT_E_INTERACT_DISTANCE))
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

                        ChangeState(SuspectState.EnteringVehicle);
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
                    Notification.Show("~y~请在车内按 E，或靠近车辆按 E 塞入后座");
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
                    Notification.Show("~y~车辆无空位");
                    return;
                }

                // 近距触发保障（避免远处误触）
                try
                {
                    if (!IsPlayerNearSuspectInteractionPoint(suspect, player, VehicleEscortLine.PLAYER_SUSPECT_E_INTERACT_DISTANCE))
                    {
                        ModLog.Info("[Escort][Vehicle] E pressed but suspect too far");
;
                        Notification.Show("~y~嫌疑人距离过远，请先按 G 保持跟随并靠近后再按 E");
                        return;
                    }
                }
                catch (Exception exPos)
                {
                    ModLog.Error("[Escort][Vehicle] Distance check failed: " + exPos);
                    return;
                }

                // 进入过渡态：只切状态，由 OnStateChanged 统一执行 StartEnterVehicle（避免重复下任务）
                ChangeState(SuspectState.EnteringVehicle);
                try { ApplyActionToOtherCompliantCaseSuspects(suspect.Handle, p => TryMakeSecondaryBoard(p, player)); } catch { }
                ModLog.Info("[Escort][Vehicle] E pressed → EnteringVehicle issued");

                return;
            }

            // 下车：仅在 InVehicle 时触发
            if (IsState(SuspectState.InVehicle))
            {
                // 同样做近距与可控性保障
                if (suspect.Position.DistanceTo(player.Position) > 6.0f)
                {
                    ModLog.Info("[Escort][Vehicle] E pressed but suspect too far to exit safely");
                    return;
                }
                // 同上：只切状态，由 OnStateChanged 统一执行 StartExitVehicle（避免重复下任务）
                ChangeState(SuspectState.ExitingVehicle);
                ModLog.Info("[Escort][Vehicle] E pressed → ExitingVehicle issued");
                return;
            }

            // 其他状态不处理
            ModLog.Info("[Escort][Vehicle] E pressed but no action for current suspect state");
            Notification.Show("~y~当前状态不可上车：请先完成拘捕并进入押送");
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
                    if (IsState(SuspectState.EnteringVehicle) || IsState(SuspectState.ExitingVehicle))
                    {
                        Notification.Show("~y~嫌疑人正在上下车，请稍等");
                        return;
                    }
                }
                catch { }

                // 如果当前嫌疑人在车内 -> 请求其下车（优先下车）
                if (suspect.IsInVehicle())
                {
                    SetSuspectFollowing(suspect.Handle, false);

                    // 发起下车流程：只切状态，由 OnStateChanged 统一执行 StartExitVehicle（避免重复下任务）
                    ChangeState(SuspectState.ExitingVehicle);
                    ModLog.Info("[Escort][Follow] Follow pressed -> suspect in vehicle -> ExitVehicle issued");

                    Notification.Show("请求嫌疑人下车");
                    return;
                }

                // 如果不在车内：切换跟随/取消跟随
                if (!IsSuspectFollowing(suspect.Handle))
                {
                    // 关闭“受惊逃跑”随机触发：按 G 只负责进入跟随，避免流程被随机打断。

                    SetSuspectFollowing(suspect.Handle, true);

                    // 被拷线：按 G 的瞬间强制维持被拷态（双手在后）
                    try
                    {
                        if (GetStyleFor(suspect.Handle) == ArrestActionStyle.CuffAndLead)
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
                    SetSuspectFollowing(suspect.Handle, false);

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
                SetSuspectFollowing(-1, false);
                try
                {
                    if (_ctxRegistry != null)
                        _ctxRegistry.Clear();
                }
                catch { }
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
            if (_handlingStateChange)
            {
                ModLog.Warn($"[Escort][Vehicle] 阻止了重入式状态变更: {oldState}->{newState}");
                return;
            }

            _handlingStateChange = true;
            try
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
            }
            catch (Exception ex)
            {
                ModLog.Error("[Escort][Vehicle] OnSuspectStateChanged error: " + ex);
            }
            finally
            {
                _handlingStateChange = false;
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
                // 允许玩家不在车内时也能“塞人上车”：选择玩家附近车辆，避免误选远处车辆。
                try { vehicle = World.GetNearbyVehicles(player, 10.0f).OrderBy(v => v.Position.DistanceTo(player.Position)).FirstOrDefault(v => v != null && v.Exists()); } catch { vehicle = null; }
            }

            if (vehicle == null || !vehicle.Exists()) return;

            var seat = FindAvailableSeatForSuspect(vehicle);
            if (seat == VehicleSeat.None) return;

            var style = GetStyleFor(suspect.Handle);
            try
            {
                // 仅在需要自动开门时处理车门
                if (ShouldAutoDoors(style))
                {
                    int doorIndex = NormalizeDoorIndex(vehicle, GetDoorIndexForSeat(seat));
                    try { VehicleDoorOps.OpenDoor(vehicle, doorIndex); } catch { }
                    try { _cuffedDoorFlow.ArmPendingShutDoor(vehicle.Handle, doorIndex, suspect.Handle, Game.GameTime); } catch { }
                }
            }
            catch { }

            try { suspect.Task.ClearAll(); } catch { }
            if (ShouldAutoVehicleSync(style))
            {
                try { EnsureCuffedClipset(suspect); } catch { }
                try { EnsureCuffedUpperBodyPose(suspect); } catch { }
            }

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
            OnCuffedEnteredVehicle(suspect, GetStyleFor(suspect != null && suspect.Exists() ? suspect.Handle : -1), now);
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
                    if (IsState(SuspectState.Escorting))
                    {
                        _cuffedDoorFlow.TryShutDoorAfterExit(
                            style,
                            (h) => FindVehicleByHandle(h),
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
        }

        private Ped TryResolveInteractSuspect(Ped suspect, Ped player)
        {
            if (suspect != null && suspect.Exists()) return suspect;
            var target = _suspectController.GetCurrentSuspect();
            if (target != null && target.Exists()) return target;
            return null;
        }

        private bool IsPlayerNearSuspectInteractionPoint(Ped suspect, Ped player, float threshold)
        {
            if (suspect == null || !suspect.Exists() || player == null || !player.Exists())
                return false;
            var suspectPos = suspect.Position;
            var playerPos = player.Position;
            // 放宽：E 上下车不应要求“贴身 1m”，否则玩家体验很差；这里统一按阈值判断。
            return suspectPos.DistanceTo(playerPos) <= threshold;
        }

    }
}




