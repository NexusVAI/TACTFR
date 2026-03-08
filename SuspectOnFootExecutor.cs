using EF.PoliceMod.Core;
using EF.PoliceMod.Gameplay;
using GTA;
using GTA.Math;
using GTA.Native;
using System;

public class SuspectOnFootExecutor
{
    private readonly SuspectController _controller;
    private readonly SuspectStateHub _stateHub;
    private readonly SuspectStyleRegistry _styleRegistry;
    private readonly EF.PoliceMod.Suspects.StateHubRouter _hubRouter;

    private int _lastFollowReissueMs = 0;

    private const float ReissueFollowDistance = 3.8f;
    private const int ReissueFollowCooldownMs = 800;

    private const string CLIPSET_PRISONER_CUFFED = "move_m@prisoner_cuffed";
    private const string CLIPSET_PRISON_GUARD = "move_m@prison_guard";
    private bool _escortClipsetApplied = false;
    private int _lastClipsetRequestMs = 0;
    private const int CLIPSET_REQUEST_COOLDOWN_MS = 1500;
    private int _lastClipsetApplyMs = 0;
    private const int CLIPSET_REAPPLY_COOLDOWN_MS = 650;

    private int _lastCuffedUpperBodyPoseMs = 0;
    private const int CUFFED_UPPERBODY_COOLDOWN_MS = 850;

    private bool _dragAttached = false;
    private int _draggedSuspectHandle = -1;
    private const float DragAttachDistance = 1.25f;
    private const float DragDetachDistance = 2.20f;

    private bool _handlingStateChange = false;

    private bool _arrestAnimPending = false;
    private int _arrestAnimTargetHandle = -1;
    private int _arrestAnimRequestTime = 0;
    private const int ARREST_ANIM_TIMEOUT_MS = 1500;
    private EF.PoliceMod.Core.ArrestActionStyle _arrestAnimStyle = EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead;

    private EF.PoliceMod.Core.ArrestActionStyle GetStyle()
    {
        try
        {
            var suspect = _controller?.GetCurrentSuspect();
            if (suspect != null && suspect.Exists() && _styleRegistry != null)
            {
                return _styleRegistry.GetStyleOrDefault(
                    suspect.Handle,
                    _controller.CurrentArrestStyle
                );
            }
        }
        catch { }

        try { return _controller != null ? _controller.CurrentArrestStyle : EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead; }
        catch { return EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead; }
    }

    public SuspectOnFootExecutor(
        SuspectController controller,
        SuspectStateHub stateHub,
        SuspectStyleRegistry styleRegistry,
        EF.PoliceMod.Suspects.StateHubRouter hubRouter)
    {
        _controller = controller;
        _stateHub = stateHub;
        _styleRegistry = styleRegistry;
        _hubRouter = hubRouter;

        _stateHub.OnStateChanged += OnStateChanged;

        EventBus.Subscribe<SuspectFollowRequestEvent>(OnFollowRequested);
    }

    private SuspectStateHub GetActiveHub()
    {
        try
        {
            var suspect = _controller?.GetCurrentSuspect();
            if (suspect != null && suspect.Exists() && _hubRouter != null)
                return _hubRouter.GetHubFor(suspect.Handle);
        }
        catch { }
        return _stateHub;
    }

    private bool IsState(SuspectState state)
    {
        return GetActiveHub().Is(state);
    }

    public void SubscribeToPerHandleHub(SuspectStateHub perHandleHub)
    {
        if (perHandleHub == null) return;
        try { perHandleHub.OnStateChanged -= OnStateChanged; } catch { }
        perHandleHub.OnStateChanged += OnStateChanged;
        ModLog.Info($"[OnFootExecutor] Subscribed to per-handle hub (handle={perHandleHub.SuspectHandle})");
    }

    private bool IsBusyState(SuspectState s)
    {
        return s == SuspectState.Escorting
            || s == SuspectState.EnteringVehicle
            || s == SuspectState.InVehicle
            || s == SuspectState.ExitingVehicle
            || s == SuspectState.Resisting
            || s == SuspectState.Restrained;
    }

    public void TickUpdate()
    {
        try
        {
            if (_arrestAnimPending)
            {
                TryCompleteArrestAnim();
            }

            if (!IsState(SuspectState.Escorting)) return;

            var suspect = _controller.GetCurrentSuspect();
            var player = Game.Player.Character;

            if (suspect == null || !suspect.Exists()) return;
            if (player == null || !player.Exists()) return;
            if (suspect.IsDead || suspect.Health <= 0) return;

            if (suspect.IsInVehicle() || player.IsInVehicle()) return;
            if (IsState(SuspectState.EnteringVehicle) || IsState(SuspectState.ExitingVehicle) || IsState(SuspectState.InVehicle)) return;

            var style = GetStyle();

            DetachDragIfNeeded();

            if (style == EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead)
                EnsureEscortClipsets(suspect, player);
            else if (_escortClipsetApplied)
                ResetEscortClipsets(suspect, player);

            EnsureEscortConstraints(suspect, style);

            if (style == EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead)
            {
                try { EnsureSuspectIsSolid(suspect, player); } catch { }
            }

            MaintainCuffedUpperBodyPoseIfNeeded(suspect, player, style);

            float dist = 0f;
            try { dist = suspect.Position.DistanceTo(player.Position); } catch { dist = 0f; }

            try
            {
                if (suspect.IsRagdoll || suspect.IsFalling)
                    return;
            }
            catch { }

            if (dist > ReissueFollowDistance)
            {
                int now = Game.GameTime;
                if (now - _lastFollowReissueMs > ReissueFollowCooldownMs)
                {
                    _lastFollowReissueMs = now;
                    ReissueFollowTask(suspect, player, clearTasks: false);
                }
            }
        }
        catch (Exception ex)
        {
            ModLog.Error("[SuspectOnFootExecutor] TickUpdate crashed: " + ex);
        }
    }

    private void OnFollowRequested(SuspectFollowRequestEvent e)
    {
        try
        {
            if (!IsState(SuspectState.Escorting))
                return;

            var suspect = _controller.GetCurrentSuspect();
            var player = Game.Player.Character;
            if (suspect == null || !suspect.Exists()) return;
            if (player == null || !player.Exists()) return;
            if (suspect.IsDead || suspect.Health <= 0) return;
            if (suspect.IsInVehicle() || player.IsInVehicle()) return;

            var style = GetStyle();
            try { EnsureEscortConstraints(suspect, style); } catch { }

            if (style == EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead)
            {
                try { EnsureEscortClipsets(suspect, player); } catch { }
            }

            try
            {
                float offY = style == EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead ? -0.9f : -1.35f;
                float speed = style == EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead ? 1.2f : 1.0f;
                float stopRange = style == EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead ? 0.9f : 1.35f;
                Function.Call(Hash.TASK_FOLLOW_TO_OFFSET_OF_ENTITY, suspect.Handle, player.Handle, 0f, offY, 0f, speed, -1, stopRange, true);
            }
            catch { }
        }
        catch { }
    }

    private void MaintainCuffedUpperBodyPoseIfNeeded(Ped suspect, Ped player, EF.PoliceMod.Core.ArrestActionStyle style)
    {
        if (style != EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead) return;
        if (suspect == null || !suspect.Exists()) return;
        if (player == null || !player.Exists()) return;

        try
        {
            int now = Game.GameTime;
            if (now - _lastCuffedUpperBodyPoseMs < CUFFED_UPPERBODY_COOLDOWN_MS) return;
            _lastCuffedUpperBodyPoseMs = now;

            try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, true); } catch { }
            try { Function.Call(Hash.SET_ENABLE_BOUND_ANKLES, suspect.Handle, true); } catch { }

            bool playing = false;
            try { playing = Function.Call<bool>(Hash.IS_ENTITY_PLAYING_ANIM, suspect.Handle, "mp_arresting", "idle", 3); } catch { playing = false; }
            if (playing) return;

            try { Function.Call(Hash.REQUEST_ANIM_DICT, "mp_arresting"); } catch { }
            try
            {
                if (!Function.Call<bool>(Hash.HAS_ANIM_DICT_LOADED, "mp_arresting"))
                    return;
            }
            catch { return; }

            try
            {
                Function.Call(Hash.TASK_PLAY_ANIM, suspect.Handle, "mp_arresting", "idle", 4.0f, -4.0f, -1, 49, 0.0f, false, false, false);
            }
            catch { }
        }
        catch { }
    }

    private void EnsureEscortClipsets(Ped suspect, Ped player)
    {
        if (suspect == null || !suspect.Exists()) return;
        if (player == null || !player.Exists()) return;

        try
        {
            int now = Game.GameTime;
            if (now - _lastClipsetRequestMs > CLIPSET_REQUEST_COOLDOWN_MS)
            {
                _lastClipsetRequestMs = now;
                try { Function.Call(Hash.REQUEST_ANIM_SET, CLIPSET_PRISONER_CUFFED); } catch { }
                try { Function.Call(Hash.REQUEST_ANIM_SET, CLIPSET_PRISON_GUARD); } catch { }
            }

            bool prisonerLoaded = false;
            bool guardLoaded = false;
            try { prisonerLoaded = Function.Call<bool>(Hash.HAS_ANIM_SET_LOADED, CLIPSET_PRISONER_CUFFED); } catch { }
            try { guardLoaded = Function.Call<bool>(Hash.HAS_ANIM_SET_LOADED, CLIPSET_PRISON_GUARD); } catch { }

            if (!prisonerLoaded || !guardLoaded) return;

            if (_escortClipsetApplied && now - _lastClipsetApplyMs < CLIPSET_REAPPLY_COOLDOWN_MS) return;

            try { Function.Call(Hash.SET_PED_MOVEMENT_CLIPSET, suspect.Handle, CLIPSET_PRISONER_CUFFED, 0.25f); } catch { }
            try { Function.Call(Hash.SET_PED_MOVEMENT_CLIPSET, player.Handle, CLIPSET_PRISON_GUARD, 0.25f); } catch { }

            _escortClipsetApplied = true;
            _lastClipsetApplyMs = now;
        }
        catch { }
    }

    private void ResetEscortClipsets(Ped suspect, Ped player)
    {
        try
        {
            if (!_escortClipsetApplied) return;

            if (suspect != null && suspect.Exists())
            {
                try { Function.Call(Hash.RESET_PED_MOVEMENT_CLIPSET, suspect.Handle, 0.25f); } catch { }
            }

            if (player != null && player.Exists())
            {
                try { Function.Call(Hash.RESET_PED_MOVEMENT_CLIPSET, player.Handle, 0.25f); } catch { }
            }
        }
        catch { }
        finally
        {
            _escortClipsetApplied = false;
        }

        try { Function.Call(Hash.REMOVE_ANIM_SET, CLIPSET_PRISONER_CUFFED); } catch { }
        try { Function.Call(Hash.REMOVE_ANIM_SET, CLIPSET_PRISON_GUARD); } catch { }
    }

    private void EnsureEscortConstraints(Ped suspect, EF.PoliceMod.Core.ArrestActionStyle style)
    {
        if (suspect == null || !suspect.Exists()) return;
        if (style == EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead)
        {
            try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, true); } catch { }
            try { Function.Call(Hash.SET_ENABLE_BOUND_ANKLES, suspect.Handle, true); } catch { }
            try { Function.Call(Hash.SET_PED_CAN_SWITCH_WEAPON, suspect.Handle, false); } catch { }
            try { Function.Call(Hash.SET_PED_CAN_PLAY_AMBIENT_ANIMS, suspect.Handle, false); } catch { }
            try { Function.Call(Hash.SET_PED_CAN_PLAY_AMBIENT_BASE_ANIMS, suspect.Handle, false); } catch { }
            try { Function.Call(Hash.SET_PED_CAN_RAGDOLL, suspect.Handle, false); } catch { }
            try { Function.Call(Hash.SET_ENTITY_COLLISION, suspect.Handle, true, true); } catch { }
            try { suspect.BlockPermanentEvents = true; } catch { }
            try { suspect.AlwaysKeepTask = true; } catch { }
        }
        else
        {
            try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, false); } catch { }
            try { Function.Call(Hash.SET_ENABLE_BOUND_ANKLES, suspect.Handle, false); } catch { }
            try { Function.Call(Hash.SET_PED_CAN_SWITCH_WEAPON, suspect.Handle, false); } catch { }
            try { Function.Call(Hash.SET_PED_CAN_PLAY_AMBIENT_ANIMS, suspect.Handle, false); } catch { }
            try { Function.Call(Hash.SET_PED_CAN_PLAY_AMBIENT_BASE_ANIMS, suspect.Handle, false); } catch { }
            try { Function.Call(Hash.SET_ENTITY_COLLISION, suspect.Handle, true, true); } catch { }
            try { suspect.BlockPermanentEvents = true; } catch { }
            try { suspect.AlwaysKeepTask = true; } catch { }
        }
    }

    private void EnsureSuspectIsSolid(Ped suspect, Ped player)
    {
        if (suspect == null || !suspect.Exists()) return;
        if (suspect.IsDead) return;

        try { Function.Call(Hash.FREEZE_ENTITY_POSITION, suspect.Handle, false); } catch { }
        try { Function.Call(Hash.SET_ENTITY_COMPLETELY_DISABLE_COLLISION, suspect.Handle, false, false); } catch { }
        try { Function.Call(Hash.SET_ENTITY_COLLISION, suspect.Handle, true, true); } catch { }
        try { Function.Call(Hash.SET_ENTITY_DYNAMIC, suspect.Handle, true); } catch { }
        try { Function.Call(Hash.SET_ENTITY_HAS_GRAVITY, suspect.Handle, true); } catch { }
        try { Function.Call(Hash.ACTIVATE_PHYSICS, suspect.Handle); } catch { }

        try
        {
            if (player != null && player.Exists())
            {
                Function.Call(Hash.SET_ENTITY_NO_COLLISION_ENTITY, player.Handle, suspect.Handle, false);
                Function.Call(Hash.SET_ENTITY_NO_COLLISION_ENTITY, suspect.Handle, player.Handle, false);
            }
        }
        catch { }

        try { Function.Call(Hash.SET_PED_CAN_RAGDOLL, suspect.Handle, true); } catch { }
        try { Function.Call(Hash.SET_PED_CAN_RAGDOLL_FROM_PLAYER_IMPACT, suspect.Handle, true); } catch { }
    }

    private void MaintainDragIfNeeded(Ped suspect, Ped player, float dist)
    {
        try
        {
            DetachDragIfNeeded();
            return;
        }
        catch { }
    }

    private void AttachDrag(Ped suspect, Ped player)
    {
        DetachDragIfNeeded();
    }

    private void DetachDragIfNeeded()
    {
        if (!_dragAttached) return;

        try
        {
            var suspect = _controller.GetCurrentSuspect();
            var player = Game.Player.Character;

            if (suspect != null && suspect.Exists())
            {
                try { Function.Call(Hash.DETACH_ENTITY, suspect.Handle, true, true); } catch { }
            }

            try
            {
                if (player != null && player.Exists() && suspect != null && suspect.Exists())
                {
                    try { Function.Call(Hash.SET_ENTITY_NO_COLLISION_ENTITY, player.Handle, suspect.Handle, false); } catch { }
                    try { Function.Call(Hash.SET_ENTITY_NO_COLLISION_ENTITY, suspect.Handle, player.Handle, false); } catch { }
                }
            }
            catch { }
        }
        catch { }
        finally
        {
            _dragAttached = false;
            _draggedSuspectHandle = -1;
        }
    }

    private void ReissueFollowTask(Ped suspect, Ped player, bool clearTasks)
    {
        if (suspect == null || !suspect.Exists()) return;
        if (player == null || !player.Exists()) return;

        try
        {
            if (clearTasks)
            {
                try { Function.Call(Hash.CLEAR_PED_TASKS, suspect.Handle); } catch { }
            }

            var style = GetStyle();

            try
            {
                float offY = style == EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead ? -0.9f : -1.35f;
                float speed = style == EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead ? 1.2f : 1.0f;
                float stopRange = style == EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead ? 0.9f : 1.35f;
                Function.Call(Hash.TASK_FOLLOW_TO_OFFSET_OF_ENTITY, suspect.Handle, player.Handle, 0f, offY, 0f, speed, -1, stopRange, true);
            }
            catch { }
        }
        catch { }
    }

    private void OnStateChanged(SuspectState from, SuspectState to)
    {
        if (_handlingStateChange)
        {
            ModLog.Warn($"[SuspectOnFootExecutor] 阻止了重入式状态变更: {from}->{to}");
            return;
        }

        _handlingStateChange = true;
        try
        {
            var suspect = _controller.GetCurrentSuspect();
            var player = Game.Player.Character;

            try { DetachDragIfNeeded(); } catch { }

            try
            {
                if (from == SuspectState.Escorting && to != SuspectState.Escorting)
                {
                    ResetEscortClipsets(suspect, player);
                }
            }
            catch { }

            if (suspect == null || !suspect.Exists())
                return;

            int handle = suspect.Handle;

            try
            {
                if (IsBusyState(from))
                {
                    _controller.UnmarkBusy(handle);
                    ModLog.Info($"[SuspectOnFootExecutor] Unmarked busy for ped={handle} (from {from})");
                }
            }
            catch (Exception ex)
            {
                ModLog.Error("[SuspectOnFootExecutor] Error while unmarking busy: " + ex);
            }

            switch (to)
            {
                case SuspectState.Escorting:
                    StartFollow(suspect);
                    break;

                case SuspectState.Restrained:
                    StartArrest(suspect);
                    break;

                case SuspectState.Resisting:
                    StartResist(suspect);
                    break;
            }
        }
        catch (Exception ex)
        {
            ModLog.Error($"[SuspectOnFootExecutor] OnStateChanged crashed: {ex}");
        }
        finally
        {
            _handlingStateChange = false;
        }
    }

    private void StartFollow(Ped suspect)
    {
        if (suspect == null || !suspect.Exists()) return;
        if (suspect.IsDead || suspect.Health <= 0)
        {
            ModLog.Info($"[SuspectOnFootExecutor] StartFollow aborted: suspect {suspect.Handle} dead/invalid");
            return;
        }

        try
        {
            var player = Game.Player.Character;
            if (player == null || !player.Exists())
            {
                ModLog.Info($"[SuspectOnFootExecutor] StartFollow aborted: player invalid when issuing FollowToOffset for suspect {suspect.Handle}");
                return;
            }

            var style = GetStyle();

            try { EnsureEscortConstraints(suspect, style); } catch { }
            try
            {
                if (style == EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead)
                    EnsureEscortClipsets(suspect, player);
                else if (_escortClipsetApplied)
                    ResetEscortClipsets(suspect, player);
            }
            catch { }

            try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, style == EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead); } catch { }

            try { Function.Call(Hash.CLEAR_PED_TASKS, suspect.Handle); } catch { }
            try
            {
                float offY = style == EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead ? -0.9f : -1.35f;
                float speed = style == EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead ? 1.2f : 1.0f;
                float stopRange = style == EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead ? 0.9f : 1.35f;
                Function.Call(Hash.TASK_FOLLOW_TO_OFFSET_OF_ENTITY, suspect.Handle, player.Handle, 0f, offY, 0f, speed, -1, stopRange, true);
                ModLog.Info($"[SuspectOnFootExecutor] Suspect {suspect.Handle} FollowToOffset issued.");
            }
            catch (Exception exTask)
            {
                ModLog.Error("[SuspectOnFootExecutor] StartFollow Task call failed: " + exTask);
                try { _controller.UnmarkBusy(suspect.Handle); } catch { }
                return;
            }
        }
        catch (Exception ex)
        {
            ModLog.Error("[SuspectOnFootExecutor] StartFollow crashed: " + ex);
            try { _controller.UnmarkBusy(suspect.Handle); } catch { }
        }
    }

    private void StartArrest(Ped suspect)
    {
        if (suspect == null || !suspect.Exists()) return;
        if (suspect.IsDead || suspect.Health <= 0)
        {
            ModLog.Info($"[SuspectOnFootExecutor] StartArrest aborted: suspect {suspect?.Handle} dead/invalid");
            return;
        }

        try
        {
            if (!suspect.Exists() || suspect.IsDead)
                return;

            var style = GetStyle();

            try { suspect.Task.ClearAll(); } catch { }

            try
            {
                suspect.BlockPermanentEvents = true;
                suspect.AlwaysKeepTask = true;

                try { Function.Call(Hash.SET_ENTITY_COLLISION, suspect.Handle, true, true); } catch { }
                try
                {
                    var player = Game.Player.Character;
                    if (player != null && player.Exists())
                    {
                        try { Function.Call(Hash.SET_ENTITY_NO_COLLISION_ENTITY, player.Handle, suspect.Handle, false); } catch { }
                        try { Function.Call(Hash.SET_ENTITY_NO_COLLISION_ENTITY, suspect.Handle, player.Handle, false); } catch { }
                    }
                }
                catch { }

                try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, style == EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead); } catch { }
                try { Function.Call(Hash.SET_PED_CAN_SWITCH_WEAPON, suspect.Handle, false); } catch { }
                try { Function.Call(Hash.SET_PED_AS_ENEMY, suspect.Handle, false); } catch { }

                _arrestAnimPending = true;
                _arrestAnimTargetHandle = suspect.Handle;
                _arrestAnimRequestTime = Game.GameTime;
                _arrestAnimStyle = style;

                string animDict = style == EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead
                    ? "mp_arresting"
                    : "random@arrests";
                try { Function.Call(Hash.REQUEST_ANIM_DICT, animDict); } catch { }
            }
            catch { }
        }
        catch (Exception ex)
        {
            ModLog.Error("[SuspectOnFootExecutor] StartArrest crashed: " + ex);
        }
    }

    private void TryCompleteArrestAnim()
    {
        if (!_arrestAnimPending) return;

        try
        {
            int now = Game.GameTime;
            if (now - _arrestAnimRequestTime > ARREST_ANIM_TIMEOUT_MS)
            {
                ModLog.Warn("[SuspectOnFootExecutor] Arrest anim timeout, falling back to HandsUp");
                _arrestAnimPending = false;
                try
                {
                    var targetPed = Entity.FromHandle(_arrestAnimTargetHandle) as Ped;
                    if (targetPed != null && targetPed.Exists() && !targetPed.IsDead)
                    {
                        try { targetPed.Task.HandsUp(-1); } catch { }
                    }
                }
                catch { }
                return;
            }

            string animDict = _arrestAnimStyle == EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead
                ? "mp_arresting"
                : "random@arrests";

            bool loaded = false;
            try { loaded = Function.Call<bool>(Hash.HAS_ANIM_DICT_LOADED, animDict); } catch { loaded = false; }

            if (!loaded) return;

            var suspect = Entity.FromHandle(_arrestAnimTargetHandle) as Ped;
            if (suspect == null || !suspect.Exists() || suspect.IsDead)
            {
                _arrestAnimPending = false;
                return;
            }

            _arrestAnimPending = false;

            try
            {
                try { Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "CONFIRM_BEEP", "HUD_MINI_GAME_SOUNDSET", false); } catch { }
                try { Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "TIMER_STOP", "HUD_MINI_GAME_SOUNDSET", false); } catch { }
            }
            catch { }

            if (_arrestAnimStyle == EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead)
            {
                try { suspect.Task.PlayAnimation("mp_arresting", "idle", 4.0f, -1, AnimationFlags.Loop); } catch { }
            }
            else
            {
                try { suspect.Task.PlayAnimation("random@arrests", "kneeling_arrest_idle", 4.0f, -1, AnimationFlags.StayInEndFrame); } catch { }
            }

            ModLog.Info($"[SuspectOnFootExecutor] Arrest anim played for ped={_arrestAnimTargetHandle}");
        }
        catch (Exception ex)
        {
            ModLog.Error("[SuspectOnFootExecutor] TryCompleteArrestAnim crashed: " + ex);
            _arrestAnimPending = false;
        }
    }

    private void StartResist(Ped suspect)
    {
        if (suspect == null || !suspect.Exists()) return;
        if (suspect.IsDead || suspect.Health <= 0) return;

        var player = Game.Player.Character;
        if (player == null || !player.Exists()) return;

        try
        {
            try { suspect.BlockPermanentEvents = false; } catch { }
            try { suspect.AlwaysKeepTask = true; } catch { }

            try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, false); } catch { }
            try { Function.Call(Hash.SET_ENABLE_BOUND_ANKLES, suspect.Handle, false); } catch { }
            try { Function.Call(Hash.SET_PED_CAN_SWITCH_WEAPON, suspect.Handle, true); } catch { }
            try { Function.Call(Hash.SET_PED_AS_ENEMY, suspect.Handle, true); } catch { }
            try { Function.Call(Hash.SET_PED_CAN_PLAY_AMBIENT_ANIMS, suspect.Handle, true); } catch { }
            try { Function.Call(Hash.SET_PED_CAN_PLAY_AMBIENT_BASE_ANIMS, suspect.Handle, true); } catch { }
            try { Function.Call(Hash.SET_PED_CAN_RAGDOLL, suspect.Handle, true); } catch { }

            try { Function.Call(Hash.CLEAR_PED_TASKS_IMMEDIATELY, suspect.Handle); } catch { }
            try { Function.Call(Hash.TASK_COMBAT_PED, suspect.Handle, player.Handle, 0, 16); } catch { }
        }
        catch (Exception ex)
        {
            ModLog.Error("[SuspectOnFootExecutor] StartResist crashed (native or managed): " + ex);
        }
    }
}
