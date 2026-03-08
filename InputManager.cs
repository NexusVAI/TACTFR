using EF.PoliceMod.Core;
using EF.PoliceMod.Input;
using GTA;
using GTA.Native;
using GTA.UI;
using System;
using Keys = System.Windows.Forms.Keys;

namespace EF.PoliceMod.Input
{
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
        private bool _unlockHeld = false;
        private bool _f8Held = false;
        private bool _hHeldRaw = false;
        private bool _gHeldRaw = false;
        private bool _eHeldRaw = false;
        private bool _yHeldRaw = false;
        private bool _pHeldRaw = false;
        private int _lastAimedPublishedAtMs = 0;
        private Ped _lastAimedTarget = null;
        private bool _wasAiming = false;
        private int _lastAimedHandle = 0;
        private const int AIM_PUBLISH_MIN_INTERVAL_MS = 200;

        private DateTime _lastTerminalToggle = DateTime.MinValue;
        private readonly TimeSpan _terminalDebounce = TimeSpan.FromMilliseconds(220);

        private bool IsRawKeyDown(System.Windows.Forms.Keys k)
        {
            return Game.IsKeyPressed(k);
        }

        public struct SuspectKilledByPlayerEvent
        {
            public int SuspectHandle { get; }
            public SuspectKilledByPlayerEvent(int suspectHandle) { SuspectHandle = suspectHandle; }
        }

        public void Update()
        {
            int now = Game.GameTime;
            try { EF.PoliceMod.Core.UIState.AutoRecover(now); } catch { }

            bool pressedO = IsRawKeyDown(EF.PoliceMod.Core.KeyBindings.OpenTerminal) || IsRawKeyDown(System.Windows.Forms.Keys.OemQuestion);
            bool pressedT = IsRawKeyDown(EF.PoliceMod.Core.KeyBindings.VehicleTerminal);

            bool patrolMenuHotkey = IsRawKeyDown(EF.PoliceMod.Core.KeyBindings.ArrestMenu);
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
                            ModLog.Info("[Input] H pressed -> PatrolMenu opened");
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

            bool isAiming = false;
            try
            {
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

            now = Game.GameTime;
            bool enoughTimePassed = now - _lastAimedPublishedAtMs >= AIM_PUBLISH_MIN_INTERVAL_MS;

            if (isAiming)
            {
                if (enoughTimePassed)
                {
                    _lastAimedPublishedAtMs = now;
#if DEBUG
                    ModLog.Info("[Input] Player is aiming");
#endif
                }
            }
            else
            {
                _lastAimedPublishedAtMs = now;
            }

            try
            {
                var core = EFCore.Instance;
                bool hasLockedTarget = core != null && core.LockTargetSystem != null && core.LockTargetSystem.HasTarget;

                bool patrolOn = EF.PoliceMod.Systems.PatrolModeQuery.Enabled;
                bool hasActiveCase = EF.PoliceMod.Systems.CaseStatusQuery.HasActiveCase;

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
                ModLog.Error("[Input] Error while evaluating H-arrest path: " + ex);
                _arrestKeyHeld = false;
            }

            if (Game.Player.Character.IsShooting)
            {
            }

            if (IsRawKeyDown(EF.PoliceMod.Core.KeyBindings.DispatchMenu) || IsRawKeyDown(System.Windows.Forms.Keys.F7))
            {
                if (!_dispatchMenuHeld)
                {
                    _dispatchMenuHeld = true;

                    if (!EF.PoliceMod.Core.FeatureGates.EnableF7DispatchMenu)
                    {
                        Notification.Show("~y~当前版本已暂时关闭 F7 调度菜单");
                    }
                    else
                    {
                        bool onDuty = false;
                        try { onDuty = EF.PoliceMod.Systems.DutyQuery.IsOnDuty; } catch { onDuty = false; }
                        if (!onDuty)
                        {
                            Notification.Show("~y~请先开始执勤");
                        }
                        else
                        {
                            EventBus.Publish(new Open911MenuEvent());
                        }
                    }
                }
            }
            else
            {
                _dispatchMenuHeld = false;
            }

            if (EF.PoliceMod.Core.UIState.IsPoliceTerminalOpen
                || EF.PoliceMod.Core.UIState.IsDispatchMenuOpen
                || EF.PoliceMod.Core.UIState.IsArrestMenuOpen
                || EF.PoliceMod.Core.UIState.IsUniformMenuOpen
                || EF.PoliceMod.Core.UIState.IsOfficerSquadMenuOpen)
            {
                return;
            }

            if (IsRawKeyDown(EF.PoliceMod.Core.KeyBindings.EscortRequest))
            {
                if (!_gHeldRaw)
                {
                    _gHeldRaw = true;

                    bool gOk = false;
                    try
                    {
                        var core = EFCore.Instance;
                        gOk = core != null
                            && core.LockTargetSystem != null
                            && core.LockTargetSystem.HasTarget
                            && core.LockTargetSystem.IsCurrentTargetArrested;
                    }
                    catch { }

                    if (gOk)
                    {
                        EventBus.Publish(new SuspectFollowRequestEvent());
                    }
                    else
                    {
                        Notification.Show("~y~需要先锁定并拘捕嫌疑人（L 锁定，H 菜单拘捕）");
                    }
                }
            }
            else
            {
                _gHeldRaw = false;
            }

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

            bool ctrlDown = IsRawKeyDown(Keys.ControlKey) || IsRawKeyDown(Keys.LControlKey) || IsRawKeyDown(Keys.RControlKey);
            if (ctrlDown)
            {
                if (!_unlockHeld)
                {
                    _unlockHeld = true;
                    try
                    {
                        var core = EFCore.Instance;
                        var lts = core != null ? core.LockTargetSystem : null;
                        if (lts != null && lts.HasTarget && lts.IsPlayerAimingCurrentTarget())
                        {
                            EventBus.Publish(new LockTargetClearRequestedEvent());
                            Notification.Show("~y~已解除锁定");
                        }
                    }
                    catch { }
                }
            }
            else
            {
                _unlockHeld = false;
            }

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

            if (Game.IsKeyPressed(EF.PoliceMod.Core.KeyBindings.OfficerSquadMenu))
            {
                if (!_f8Held)
                {
                    _f8Held = true;

                    bool onDuty = false;
                    try { onDuty = EF.PoliceMod.Systems.DutyQuery.IsOnDuty; } catch { onDuty = false; }

                    if (onDuty)
                    {
                        EventBus.Publish(new OpenOfficerSquadMenuEvent());
                    }
                    else
                    {
                        Notification.Show("~y~请先开始执勤");
                    }
                }
            }
            else
            {
                _f8Held = false;
            }

            if (IsRawKeyDown(EF.PoliceMod.Core.KeyBindings.PullOver))
            {
                if (!_pullOverHeld)
                {
                    _pullOverHeld = true;

                    ModLog.Info("[Input] I pressed (pull over)");

                    if (isAiming)
                    {
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

                                if (player != null && player.Exists())
                                {
                                    float dist = 9999f;
                                    try { dist = player.Position.DistanceTo(suspect.Position); } catch { dist = 9999f; }

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
                    else
                    {
                        Notification.Show("~y~请先瞄准嫌疑车辆再按 I 逼停");
                    }
                }
            }
            else
            {
                _pullOverHeld = false;
            }

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
