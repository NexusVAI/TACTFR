using EF.PoliceMod.Core;
using EF.PoliceMod.Core.Contracts;
using EF.PoliceMod.Core.Contracts.Snapshots;
using EF.PoliceMod.Gameplay;
using GTA;
using GTA.Native;
using GTA.UI;
using System;
using System.Linq;

namespace EF.PoliceMod.Systems
{
    public sealed class PatrolSystem : IPatrolService
    {
        private readonly LockTargetSystem _lockTargetSystem;

        private bool _enabled = false;
        private int _lastActionAtMs = 0;
        private const int ActionDebounceMs = 600;
        private int _checksCompleted = 0;
        private bool _initialized = false;

        public bool IsEnabled => _enabled;

        public PatrolSystem(LockTargetSystem lockTargetSystem)
        {
            _lockTargetSystem = lockTargetSystem;

            EventBus.Subscribe<DutyEndedEvent>(_ => _enabled = false);
            EventBus.Subscribe<PatrolModeToggledEvent>(e => _enabled = e.Enabled);
            EventBus.Subscribe<PatrolCheckRequestedEvent>(_ => RequestCheck());
            EventBus.Subscribe<PatrolRequestIdEvent>(_ => RequestIdCheck());
            EventBus.Subscribe<PatrolSearchRequestedEvent>(_ => RequestSearch());
        }

        public void Initialize()
        {
            if (_initialized) return;
            _initialized = true;
            ModLog.Info("[PatrolSystem] Initialized");
        }

        public new void Tick()
        {
        }

        public void Shutdown()
        {
            _enabled = false;
            _checksCompleted = 0;
            _initialized = false;
            ModLog.Info("[PatrolSystem] Shutdown");
        }

        public PatrolSnapshot GetSnapshot()
        {
            return new PatrolSnapshot(_enabled, _checksCompleted);
        }

        public void Enable()
        {
            if (_enabled) return;
            _enabled = true;
            EventBus.Publish(new PatrolModeToggledEvent(true));
            ModLog.Info("[PatrolSystem] Enabled");
        }

        public void Disable()
        {
            if (!_enabled) return;
            _enabled = false;
            EventBus.Publish(new PatrolModeToggledEvent(false));
            ModLog.Info("[PatrolSystem] Disabled");
        }

        public void Toggle()
        {
            if (_enabled)
                Disable();
            else
                Enable();
        }

        public void RequestCheck()
        {
            if (!_enabled) { Notification.Show("~y~巡逻模式未开启"); return; }
            if (!Debounce()) return;

            var target = ResolveTarget();
            if (target == null || !target.Exists()) { Notification.Show("~y~请先用 L 锁定目标"); return; }

            int roll = new Random(Game.GameTime + target.Handle).Next(100);
            if (roll < 70)
            {
                SmsNotification.Show("警务终端", "巡逻检查", "未发现异常。");
            }
            else
            {
                SmsNotification.Show("警务终端", "巡逻检查", "该对象行为可疑：建议查身份证或搜查。");
            }

            _checksCompleted++;
        }

        public void RequestIdCheck()
        {
            if (!_enabled) { Notification.Show("~y~巡逻模式未开启"); return; }
            if (!Debounce()) return;

            var target = ResolveTarget();
            if (target == null || !target.Exists()) { Notification.Show("~y~请先用 L 锁定目标"); return; }

            int roll = new Random(Game.GameTime + target.Handle * 7).Next(100);
            if (roll < 65)
            {
                SmsNotification.Show("警务终端", "身份证", "对方配合出示身份证（姓名/信息待后续扩展）。");
                _checksCompleted++;
                return;
            }
            if (roll < 85)
            {
                SmsNotification.Show("警务终端", "身份证", "对方拒绝配合并开始逃跑！");
                try { EventBus.Publish(new PatrolSuspectFleeEvent(target, Game.Player.Character)); } catch { }
                _checksCompleted++;
                return;
            }

            SmsNotification.Show("警务终端", "身份证", "对方突然反抗！");
            try { EventBus.Publish(new PatrolSuspectResistEvent(target, Game.Player.Character)); } catch { }
            _checksCompleted++;
        }

        public void RequestSearch()
        {
            if (!_enabled) { Notification.Show("~y~巡逻模式未开启"); return; }
            if (!Debounce()) return;

            var target = ResolveTarget();
            if (target == null || !target.Exists()) { Notification.Show("~y~请先用 L 锁定目标"); return; }

            PlaySearchAnimation(target);

            int roll = new Random(Game.GameTime + target.Handle * 13).Next(100);
            if (roll < 75)
            {
                SmsNotification.Show("警务终端", "搜查", "搜查结果：未发现违禁品。");
                _checksCompleted++;
                return;
            }
            if (roll < 92)
            {
                SmsNotification.Show("警务终端", "搜查", "~o~发现违禁品~s~：对方可能会逃跑或反抗！");
                try { EventBus.Publish(new PatrolContrabandFoundEvent(target, false)); } catch { }
                try { EventBus.Publish(new PatrolSuspectFleeEvent(target, Game.Player.Character)); } catch { }
                _checksCompleted++;
                return;
            }

            SmsNotification.Show("警务终端", "搜查", "~r~发现携带武器~s~：对方反抗！");
            try { EventBus.Publish(new PatrolContrabandFoundEvent(target, true)); } catch { }
            try { EventBus.Publish(new PatrolSuspectResistEvent(target, Game.Player.Character)); } catch { }
            _checksCompleted++;
        }

        private void PlaySearchAnimation(Ped target)
        {
            try
            {
                var player = Game.Player.Character;
                if (player == null || !player.Exists()) return;

                bool playerControlLocked = false;
                bool playerFrozen = false;
                bool targetFrozen = false;

                Function.Call(Hash.REQUEST_ANIM_DICT, "missfbi5ig_22");
                Function.Call(Hash.REQUEST_ANIM_DICT, "random@arrests");

                int timeout = 0;
                while (!Function.Call<bool>(Hash.HAS_ANIM_DICT_LOADED, "missfbi5ig_22") && timeout < 50)
                {
                    GTA.Script.Wait(10);
                    timeout++;
                }

                if (Function.Call<bool>(Hash.HAS_ANIM_DICT_LOADED, "missfbi5ig_22"))
                {
                    try
                    {
                        try { Function.Call(Hash.SET_PLAYER_CONTROL, Game.Player.Handle, false, 0); playerControlLocked = true; } catch { }
                        try { Function.Call(Hash.FREEZE_ENTITY_POSITION, player.Handle, true); playerFrozen = true; } catch { }
                        try { if (target != null && target.Exists()) { Function.Call(Hash.FREEZE_ENTITY_POSITION, target.Handle, true); targetFrozen = true; } } catch { }

                        player.Task.ClearAll();
                        player.Task.PlayAnimation("missfbi5ig_22", "fbi_5ig_22_pistol_whip_ped", 8.0f, -1, AnimationFlags.StayInEndFrame);
                    }
                    catch { }
                }

                if (target != null && target.Exists())
                {
                    try
                    {
                        target.Task.ClearAll();
                        target.Task.StandStill(3000);
                        target.Task.HandsUp(-1);
                    }
                    catch { }
                }

                GTA.Script.Wait(2000);

                try
                {
                    player.Task.ClearAll();
                }
                catch { }

                try { if (targetFrozen && target != null && target.Exists()) Function.Call(Hash.FREEZE_ENTITY_POSITION, target.Handle, false); } catch { }
                try { if (playerFrozen) Function.Call(Hash.FREEZE_ENTITY_POSITION, player.Handle, false); } catch { }
                try { if (playerControlLocked) Function.Call(Hash.SET_PLAYER_CONTROL, Game.Player.Handle, true, 0); } catch { }

                ModLog.Info("[PatrolSystem] Search animation played");
            }
            catch (Exception ex)
            {
                ModLog.Error("[PatrolSystem] Search animation failed: " + ex);
            }
        }

        private Ped ResolveTarget()
        {
            try
            {
                var t = _lockTargetSystem?.CurrentTarget;
                if (t != null && t.Exists()) return t;
            }
            catch { }

            return null;
        }

        private bool Debounce()
        {
            int now = Game.GameTime;
            if (now - _lastActionAtMs < ActionDebounceMs) return false;
            _lastActionAtMs = now;
            return true;
        }
    }
}

