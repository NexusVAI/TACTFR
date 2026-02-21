using EF.PoliceMod.Core;
using GTA;
using GTA.Native;
using GTA.Math;
using System;

namespace EF.PoliceMod.Systems
{
    public sealed class PlayerRespawnFixSystem
    {
        private int _lastHandledDeadAtMs = -999999;
        private const int DeadHandleDebounceMs = 2500;
        private int _firstDeadAtMs = -1;
        private const int ForceRespawnAfterMs = 6000;
        private bool _wasDead = false;

        public PlayerRespawnFixSystem()
        {
            EventBus.Subscribe<DutyEndedEvent>(_ => { _lastHandledDeadAtMs = -999999; });
        }

        public void Tick()
        {
            try
            {
                var p = Game.Player.Character;
                if (p == null || !p.Exists()) return;

                if (p.IsDead)
                {
                    if (!_wasDead)
                    {
                        _wasDead = true;
                        _firstDeadAtMs = Game.GameTime;
                        ModLog.Info("[PlayerRespawnFixSystem] Player death detected");
                    }

                    int now = Game.GameTime;
                    if (now - _lastHandledDeadAtMs < DeadHandleDebounceMs) return;
                    _lastHandledDeadAtMs = now;

                    try { Function.Call(Hash.FREEZE_ENTITY_POSITION, p.Handle, false); } catch { }
                    try { Function.Call(Hash.SET_PLAYER_CONTROL, Game.Player.Handle, true, 0); } catch { }
                    try { Function.Call(Hash.ENABLE_ALL_CONTROL_ACTIONS, 0); } catch { }
                    try { Function.Call(Hash.RENDER_SCRIPT_CAMS, false, false, 0, true, false); } catch { }
                    // 兜底：黑屏卡圈常见是 screen fade / death camera 卡死
                    try { Function.Call(Hash.DO_SCREEN_FADE_IN, 0); } catch { }
                    try { Function.Call(Hash.CLEAR_FOCUS); } catch { }
                    int deadForMs = (_firstDeadAtMs > 0) ? (now - _firstDeadAtMs) : 0;
                    if (deadForMs >= ForceRespawnAfterMs)
                    {
                        try
                        {
                            Vector3 pos = p.Position;
                            Function.Call(Hash.NETWORK_RESURRECT_LOCAL_PLAYER, pos.X, pos.Y, pos.Z, p.Heading, true, false);
                        }
                        catch { }

                        try { Function.Call(Hash.RESURRECT_PED, p.Handle); } catch { }
                        try { Function.Call(Hash.CLEAR_PED_TASKS_IMMEDIATELY, p.Handle); } catch { }
                        try { Function.Call(Hash.CLEAR_PED_BLOOD_DAMAGE, p.Handle); } catch { }
                        try { Function.Call(Hash.RESET_PED_VISIBLE_DAMAGE, p.Handle); } catch { }
                        try { Function.Call(Hash.SET_ENTITY_INVINCIBLE, p.Handle, false); } catch { }
                        try { Function.Call(Hash.SET_ENTITY_HEALTH, p.Handle, 200); } catch { }
                        try { Function.Call(Hash.DO_SCREEN_FADE_IN, 300); } catch { }
                    }
                }
                else if (_wasDead)
                {
                    _wasDead = false;
                    _firstDeadAtMs = -1;
                    ModLog.Info("[PlayerRespawnFixSystem] Player respawned, restoring state");
                    OnPlayerRespawned();
                }
            }
            catch { }
        }

        private void OnPlayerRespawned()
        {
            try
            {
                var dutyController = EFCore.Instance?.GetDutyController();
                if (dutyController != null)
                {
                    dutyController.RestorePlayerState();
                    ModLog.Info("[PlayerRespawnFixSystem] Player state restored after respawn");
                }
            }
            catch (Exception ex)
            {
                ModLog.Error("[PlayerRespawnFixSystem] OnPlayerRespawned failed: " + ex);
            }
        }
    }
}
