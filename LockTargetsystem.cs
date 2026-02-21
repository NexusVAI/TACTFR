using EF.PoliceMod.Core;
using EF.PoliceMod.Input;
using GTA;
using GTA.Math;
using GTA.UI;
using System;

namespace EF.PoliceMod.Gameplay
{
    public class LockTargetSystem
    {
        private Ped _currentTarget;
        private Ped _suspect;                 // 当前案件嫌疑人（由 CaseManager 注册）
        private TargetState _currentState = TargetState.None;

        // 供小队系统等模块读取“当前案件嫌疑人”（不要求玩家先 L 锁定）
        public Ped CurrentSuspect => _suspect;
        private readonly SuspectController _suspectController;
        private bool _everLocked = false;
        private bool _lockPressureTriggered = false;
        // 巡逻模式：允许锁定任意 ped（通过事件驱动，避免 CaseManager/具体系统耦合）
        private bool _allowLockAnyPed = false;

        public Ped CurrentTarget => _currentTarget;
        public bool HasTarget => _currentTarget != null && _currentTarget.Exists();
        public bool IsCurrentTargetArrested => _currentState == TargetState.Arrested;

        public bool IsPlayerAimingCurrentTarget()
        {
            try
            {
                var player = Game.Player.Character;
                if (player == null || !player.Exists()) return false;
                if (_currentTarget == null || !_currentTarget.Exists()) return false;

                var aimed = FindPedInFront(player, 10.0f);
                return aimed != null && aimed.Exists() && aimed.Handle == _currentTarget.Handle;
            }
            catch { return false; }
        }

        public LockTargetSystem(SuspectController suspectController)
        {
            _suspectController = suspectController
                ?? throw new ArgumentNullException(nameof(suspectController));

            // 巡逻模式：允许锁定任意路人（但不改变“案件嫌疑人”注册逻辑）
            // 通过事件驱动开关，保持低耦合
            try { EventBus.Subscribe<EF.PoliceMod.Core.PatrolModeToggledEvent>(e => SetAllowLockAnyPed(e.Enabled)); } catch { }
        }

        private void SetAllowLockAnyPed(bool enabled)
        {
            _allowLockAnyPed = enabled;

            // 退出巡逻：若当前锁定的不是“案件嫌疑人”，则清掉，避免影响任务执法链路
            if (!_allowLockAnyPed)
            {
                try
                {
                    bool isCaseSuspect = _currentTarget != null && _currentTarget.Exists()
                        && _suspect != null && _suspect.Exists()
                        && _currentTarget.Handle == _suspect.Handle;
                    if (!isCaseSuspect)
                    {
                        ForceClear();
                    }
                }
                catch { }
            }
        }

        private bool IsHandleInCurrentCase(int handle)
        {
            if (handle <= 0) return false;
            try
            {
                var mgr = EFCore.Instance?.GetCaseManager();
                if (mgr?.SuspectHandles != null)
                {
                    foreach (var h in mgr.SuspectHandles)
                    {
                        if (h == handle) return true;
                    }
                }
            }
            catch { }
            return false;
        }

        private int GetCaseSlotIndex(int handle)
        {
            if (handle <= 0) return -1;
            try
            {
                var mgr = EFCore.Instance?.GetCaseManager();
                if (mgr?.SuspectHandles != null)
                {
                    for (int i = 0; i < mgr.SuspectHandles.Count; i++)
                    {
                        if (mgr.SuspectHandles[i] == handle) return i;
                    }
                }
            }
            catch { }
            return -1;
        }

        /// <summary>
        /// CaseManager 在生成嫌疑人后调用
        /// </summary>
        public void RegisterSuspect(Ped suspect)
        {
            // ★ 注册新嫌疑人前，彻底清空旧状态
            ForceClear();

            _suspect = suspect;
        }

        /// <summary>
        /// 驾车逃逸线：停稳下车后直接“自动锁定+标记已拘捕”，让玩家可直接按 G 跟随 / E 上下车。
        /// 注意：仍允许玩家之后按 L 解除锁定并重新用 H 选择拘捕风格。
        /// </summary>
        public void AutoLockAndArrest(Ped suspect)
        {
            try
            {
                if (suspect == null || !suspect.Exists()) return;

                _currentTarget = suspect;
                _suspect = suspect;
                _currentState = TargetState.Arrested;
                _everLocked = true;
                _lockPressureTriggered = false;

                // 注意：不要在这里 TakeControl()，否则会把 PullOverSystem 刚设置的 IsCompliant=true 重置掉，
                // 导致按 G 不会触发押送/跟随。

                ModLog.Info($"[LockTargetSystem] AutoLockAndArrest handle={_currentTarget.Handle}");
            }
            catch (Exception ex)
            {
                ModLog.Error("[LockTargetSystem] AutoLockAndArrest failed: " + ex);
            }
        }

        /// <summary>
        /// 警员“压制逮捕”用：把嫌疑人设为当前锁定目标（Locked），但不触发 TakeControl()。
        /// 这样不会把 SuspectController.SetCompliant() 的状态重置掉。
        /// </summary>
        public void AutoLockCompliant(Ped suspect)
        {
            try
            {
                if (suspect == null || !suspect.Exists()) return;

                _currentTarget = suspect;
                _suspect = suspect;
                // 该入口用于“已被控制/可押送”的情况：需要视为 Arrested，才能放行 G/E 等后续交互。
                _currentState = TargetState.Arrested;
                _everLocked = true;
                _lockPressureTriggered = false;

                ModLog.Info($"[LockTargetSystem] AutoLockCompliant handle={_currentTarget.Handle}");
            }
            catch (Exception ex)
            {
                ModLog.Error("[LockTargetSystem] AutoLockCompliant failed: " + ex);
            }
        }

        private void OnLockTargetRequested(LockTargetEvent e)
        {
            Ped player = Game.Player.Character;
            if (player == null || !player.Exists())
                return;

            bool hadLockedTarget = false;
            try
            {
                hadLockedTarget = _currentTarget != null && _currentTarget.Exists()
                    && (_currentState == TargetState.Locked || _currentState == TargetState.Arrested);
            }
            catch { hadLockedTarget = false; }

            // 非巡逻：只能锁定“本案嫌疑人”
            if (!_allowLockAnyPed)
            {
                if (_suspect == null || !_suspect.Exists())
                {
                    Notification.Show("~y~当前没有可锁定的嫌疑人");
                    return;
                }
            }

            Ped target = FindPedInFront(player, 10.0f);
            if (target == null || !target.Exists())
            {
                Notification.Show("~y~未找到可锁定的目标");
                return;
            }

            // 双嫌疑人链路：已锁定 A 时，瞄到 B 再按 L => 切换锁定而不是直接解锁。
            if (hadLockedTarget)
            {
                try
                {
                    if (target.Handle == _currentTarget.Handle)
                    {
                        ForceClear();
                        Notification.Show("~y~已解除锁定");
                        return;
                    }

                    bool canSwitch = _allowLockAnyPed || IsHandleInCurrentCase(target.Handle);
                    if (canSwitch)
                    {
                        _currentTarget = target;
                        _currentState = TargetState.Locked;
                        _everLocked = true;
                        _lockPressureTriggered = false;

                        bool isCaseSuspect = false;
                        try { isCaseSuspect = IsHandleInCurrentCase(target.Handle); } catch { isCaseSuspect = false; }
                        if (isCaseSuspect)
                        {
                            try { _suspectController?.TakeControl(_currentTarget); } catch { }
                        }

                        int slotIndex = GetCaseSlotIndex(target.Handle);
                        if (slotIndex >= 0) Notification.Show($"~g~已锁定嫌疑人({slotIndex + 1})");
                        else Notification.Show(_allowLockAnyPed ? "~g~已锁定目标" : "~g~已锁定嫌疑人");

                        ModLog.Info($"[LockTargetSystem] Switched lock target handle={_currentTarget.Handle} slot={slotIndex}");
                        return;
                    }

                    ForceClear();
                    Notification.Show("~y~已解除锁定");
                    return;
                }
                catch { }
            }

            if (!_allowLockAnyPed)
            {
                if (!IsHandleInCurrentCase(target.Handle))
                {
                    Notification.Show("~y~只能锁定本案嫌疑人");
                    return;
                }
            }

            try
            {
                // 设置为当前锁定目标（引用并进入 Locked 状态）
                _currentTarget = target;
                _currentState = TargetState.Locked;
                _everLocked = true;
                _lockPressureTriggered = false;

                // 仅“案件嫌疑人”才 TakeControl；巡逻锁定路人不接管，避免污染任务执法链路
                bool isCaseSuspect = false;
                try { isCaseSuspect = IsHandleInCurrentCase(_currentTarget.Handle); } catch { isCaseSuspect = false; }
                if (isCaseSuspect)
                {
                    try
                    {
                        _suspectController?.TakeControl(_currentTarget);
                    }
                    catch (Exception exCtrl)
                    {
                        ModLog.Error("[LockTargetSystem] TakeControl failed: " + exCtrl);
                    }
                }

                int slotIndex = GetCaseSlotIndex(_currentTarget.Handle);
                if (!_allowLockAnyPed && slotIndex >= 0) Notification.Show($"~g~已锁定嫌疑人({slotIndex + 1})");
                else Notification.Show(_allowLockAnyPed ? "~g~已锁定目标" : "~g~已锁定嫌疑人");
                ModLog.Info($"[LockTargetSystem] Locked target handle={_currentTarget.Handle} allowAny={_allowLockAnyPed} slot={slotIndex}");
            }
            catch (Exception ex)
            {
                ModLog.Error("[LockTargetSystem] OnLockTargetRequested error: " + ex);
                Notification.Show("~r~锁定失败（内部错误）");
            }
        }



        public void Initialize()
        {
            EventBus.Subscribe<LockTargetEvent>(OnLockTargetRequested);
            EventBus.Subscribe<AttemptArrestEvent>(OnAttemptArrestEvent);
            EventBus.Subscribe<SuspectEscapedEvent>(OnSuspectEscaped);
            EventBus.Subscribe<LockTargetClearRequestedEvent>(OnLockTargetClearRequested);
        }

        public void Shutdown()
        {
            EventBus.Unsubscribe<LockTargetEvent>(OnLockTargetRequested);
            EventBus.Unsubscribe<AttemptArrestEvent>(OnAttemptArrestEvent);
            EventBus.Unsubscribe<SuspectEscapedEvent>(OnSuspectEscaped);
            EventBus.Unsubscribe<LockTargetClearRequestedEvent>(OnLockTargetClearRequested);
        }


        private void OnAttemptArrestEvent(AttemptArrestEvent e)
        {
            OnAttemptArrest();
        }


        public void Update()
        {
            UpdateTargetState();

            if (_currentState != TargetState.Locked)
                return;

            if (_currentTarget == null || !_currentTarget.Exists())
                return;

            Ped player = Game.Player.Character;
            if (!player.Exists())
                return;

            float dist = player.Position.DistanceTo(_currentTarget.Position);

            // ★ 锁定 + 5 米压迫触发
            if (dist <= 5.0f && !_lockPressureTriggered)
            {
                _lockPressureTriggered = true;

            }
        }

        private void OnAttemptArrest()
        {
            if (_currentTarget == null || !_currentTarget.Exists())
            {
                Notification.Show("~r~没有可拘捕的目标");
                return;
            }

            // 允许：已锁定 或 已处于“自动拘捕/已控制”(Arrested) 状态下重新选择拘捕风格（例如驾车逃逸线默认跳过拘捕阶段）
            if (_currentState != TargetState.Locked && _currentState != TargetState.Arrested)
            {
                // 双嫌疑人链路兜底：若目标仍存在但状态意外丢失，自动恢复为 Locked，避免误报“未锁定嫌疑人”。
                if (_currentTarget != null && _currentTarget.Exists())
                {
                    _currentState = TargetState.Locked;
                    _everLocked = true;
                    ModLog.Warn("[LockTargetSystem] Recovered lock state before arrest attempt");
                }
                else
                {
                    Notification.Show("~y~未锁定嫌疑人");
                    return;
                }
            }

            Ped player = Game.Player.Character;
            if (!player.Exists()) return;

            bool arrested = false;

            // 不再使用“嫌疑人正忙”概念阻塞拘捕：始终走朝向/距离等安全校验，然后 TryAttemptArrest。

            // 后备：朝向/距离校验
            Vector3 toTarget = _currentTarget.Position - player.Position;
            toTarget.Z = 0f;
            Vector3 forward = player.ForwardVector;
            forward.Z = 0f;
            float facingDot = Vector3.Dot(Vector3.Normalize(toTarget), Vector3.Normalize(forward));
            if (facingDot < 0.5f)
            {
                Notification.Show("~y~你没有正面对嫌疑人");
                return;
            }

            float distance = player.Position.DistanceTo(_currentTarget.Position);
            if (distance > ModConfig.ArrestDistance)
            {
                Notification.Show("~y~距离过远，无法拘捕");
                return;
            }

            try
            {
                arrested = false;
                if (_suspectController != null)
                {
                    arrested = _suspectController.TryAttemptArrest(player);
                }
            }
            catch (Exception exArrest)
            {
                ModLog.Error("[LockTargetSystem] TryAttemptArrest threw: " + exArrest);
                arrested = false;
            }

            if (arrested)
            {
                try
                {
                    _currentState = TargetState.Arrested;
                    Notification.Show("~g~嫌疑人已被控制");

                    // 若选择“上拷牵走”，触发一次上拷演出（短暂禁控+走到背后+动画）
                    try
                    {
                        if (EF.PoliceMod.Core.ArrestStyleState.SelectedStyle == EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead)
                        {
                            EventBus.Publish(new EF.PoliceMod.Core.CuffingSequenceRequestedEvent(_currentTarget.Handle));
                        }
                    }
                    catch { }
                }
                catch (Exception exSet)
                {
                    ModLog.Error("[LockTargetSystem] Post-arrest finalization error: " + exSet);
                }
            }
        }

        private void UpdateTargetState()
        {
            Ped player = Game.Player.Character;

            if (_currentTarget == null || !_currentTarget.Exists())
            {
                LoseTarget("目标丢失");
                return;
            }

            if (_currentTarget.IsDead)
            {
                // ★ 案件系统会处理死亡，这里不再插手
                ForceClear();
                return;
            }

            // 在进行距离/朝向判断前先确保 player 有效
            if (player == null || !player.Exists())
            {
                // 无法判断玩家位置，延后检测
                return;
            }

            // 锁定不再因距离丢失：只在嫌疑人死亡/消失或玩家手动按 L 解锁时才解除。
        }

        private void OnSuspectEscaped(SuspectEscapedEvent e)
        {
            try
            {
                if (_currentTarget == null || !_currentTarget.Exists()) return;
                if (_currentTarget.Handle != e.SuspectHandle) return;

                ForceClear();
                Notification.Show("~r~嫌疑人逃跑！请重新锁定并拘捕");
            }
            catch { }
        }

        private void OnLockTargetClearRequested(LockTargetClearRequestedEvent e)
        {
            try
            {
                ForceClear();
                ModLog.Info("[LockTargetSystem] Cleared by LockTargetClearRequestedEvent");
            }
            catch { }
        }

        private void LoseTarget(string reason)
        {
            if (!_everLocked)
                return;

            if (_currentTarget != null && _currentTarget.Exists())
            {
                _suspectController.ReleaseControl(_currentTarget);
            }

            _currentTarget = null;
            _currentState = TargetState.None;
            _everLocked = false;

            Notification.Show(reason);
        }

        public void ForceClear()
        {
            if (_currentTarget != null && _currentTarget.Exists())
            {
                _suspectController.ReleaseControl(_currentTarget);
            }

            _currentTarget = null;
            _currentState = TargetState.None;
            _everLocked = false;
        }

        private Ped FindPedInFront(Ped player, float distance)
        {
            // 1) 优先射线命中（最准）
            try
            {
                Vector3 start = player.Position + new Vector3(0f, 0f, 0.5f);
                Vector3 end = start + player.ForwardVector * distance;

                RaycastResult ray = World.Raycast(
                    start,
                    end,
                    IntersectFlags.Peds,
                    player
                );

                if (ray.DidHit)
                {
                    var hit = ray.HitEntity as Ped;
                    if (hit != null && hit.Exists() && hit.Handle != player.Handle && !IsExcludedPed(hit))
                        return hit;
                }
            }
            catch { }

            // 2) 兜底：射线没命中时，用“前方扇形”找最近的 ped（提升 L 键灵敏度）
            try
            {
                var peds = World.GetNearbyPeds(player, distance);
                if (peds == null || peds.Length == 0) return null;

                Ped best = null;
                float bestDist = 9999f;

                foreach (var ped in peds)
                {
                    if (ped == null || !ped.Exists()) continue;
                    if (ped.Handle == player.Handle) continue;
                    if (IsExcludedPed(ped)) continue;

                    float d = 9999f;
                    try { d = ped.Position.DistanceTo(player.Position); } catch { d = 9999f; }
                    if (d > distance) continue;

                    // 前方扇形（放宽到约 155°：dot > cos(77°)≈0.22），但仍避免锁到背后路人
                    try
                    {
                        var to = ped.Position - player.Position;
                        to.Z = 0f;
                        var fwd = player.ForwardVector;
                        fwd.Z = 0f;
                        float dot = Vector3.Dot(Vector3.Normalize(to), Vector3.Normalize(fwd));
                        if (dot < 0.22f) continue;
                    }
                    catch { continue; }

                    if (d < bestDist)
                    {
                        bestDist = d;
                        best = ped;
                    }
                }

                return best;
            }
            catch { }

            return null;
        }

        private bool IsExcludedPed(Ped ped)
        {
            if (ped == null || !ped.Exists()) return true;
            try { if (ped.IsDead) return true; } catch { }

            if (EF.PoliceMod.Systems.DutyQuery.IsOnDuty)
            {
                if (IsPoliceModel(ped.Model))
                {
                    ModLog.Info($"[LockTarget] Excluding police ped (on duty): handle={ped.Handle}");
                    return true;
                }
            }

            try
            {
                var squad = EFCore.Instance?.GetOfficerSquad();
                if (squad != null)
                {
                    foreach (var officer in squad.Officers)
                    {
                        if (officer != null && officer.Exists() && officer.Handle == ped.Handle)
                        {
                            ModLog.Info($"[LockTarget] Excluding squad officer: handle={ped.Handle}");
                            return true;
                        }
                    }
                }
            }
            catch { }

            try
            {
                var dispatch = EFCore.Instance?.GetDispatchSupport();
                if (dispatch != null && dispatch.BackupCount > 0)
                {
                    if (dispatch.IsBackupUnit(ped.Handle))
                    {
                        ModLog.Info($"[LockTarget] Excluding backup unit: handle={ped.Handle}");
                        return true;
                    }
                }
            }
            catch { }

            return false;
        }

        private bool IsPoliceModel(Model model)
        {
            if (model == null || !model.IsValid) return false;

            string modelName = model.ToString().ToLower();
            if (modelName.Contains("cop") || modelName.Contains("swat") || modelName.Contains("fib") || modelName.Contains("army") || modelName.Contains("marine") || modelName.Contains("sheriff") || modelName.Contains("lspd") || modelName.Contains("police") || modelName.Contains("ranger") || modelName.Contains("security"))
                return true;

            return false;
        }
    }
}
