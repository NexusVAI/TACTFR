using EF.PoliceMod.Core;
using EF.PoliceMod.Core.Contracts;
using GTA;
using GTA.Math;
using GTA.Native;
using GTA.UI;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace EF.PoliceMod.Systems
{
    public class DispatchSupportSystem : IDispatchService
    {
        private int _lastActionAtMs = 0;
        private const int CooldownMs = 1200;

        private const int FollowUpdateDebounceMs = 1600;
        private int _lastFollowUpdateAtMs = 0;
        private const float FollowMaxSpeed = 58.0f;
        private bool _initialized = false;
        private int _lastFollowModeAtMs = 0;
        private const int FollowModeDebounceMs = 900;

        private enum ConvoyMode
        {
            FollowPlayer,
            FreeRoam,
        }

        private ConvoyMode _convoyMode = ConvoyMode.FreeRoam;
        private int _lastFreeRoamIssuedAtMs = 0;
        private const int FreeRoamReissueMs = 4500;
        private int _lastPlayerDamageCheckMs = 0;
        private const int PlayerDamageCheckIntervalMs = 500;
        private int _lastAttackerHandle = -1;

        private class BackupUnit
        {
            public int VehicleHandle;
            public int DriverHandle;
            public int[] CopHandles;
            public int BlipHandle;
            public bool IsFollowing;
        }

        private readonly List<BackupUnit> _backupUnits = new List<BackupUnit>();

        public int BackupCount => _backupUnits.Count;
        public bool CanRequestBackup => _backupUnits.Count < ModConfig.MaxBackupCars;

        public bool IsBackupUnit(int pedHandle)
        {
            foreach (var unit in _backupUnits)
            {
                if (unit == null) continue;
                if (unit.DriverHandle == pedHandle) return true;
                if (unit.CopHandles != null)
                {
                    foreach (var h in unit.CopHandles)
                    {
                        if (h == pedHandle) return true;
                    }
                }
            }
            return false;
        }

        public DispatchSupportSystem()
        {
            EventBus.Subscribe<DutyEndedEvent>(_ => ClearAllBackup("DutyEnded"));
            EventBus.Subscribe<EF.PoliceMod.Input.SuspectResistEvent>(OnSuspectResist);
        }

        public void Initialize()
        {
            if (_initialized) return;
            _initialized = true;
            ModLog.Info("[DispatchSupportSystem] Initialized");
        }

        public void Tick()
        {
            TickUpdate();
        }

        public void Shutdown()
        {
            ClearAllBackup("Shutdown");
            _initialized = false;
            ModLog.Info("[DispatchSupportSystem] Shutdown");
        }

        public void RequestBackup()
        {
            TrySpawnBackup();
        }

        void IDispatchService.ClearAllBackup()
        {
            ClearAllBackup("Interface");
        }


        private void OnSuspectResist(EF.PoliceMod.Input.SuspectResistEvent e)
        {
            try
            {
                if (e.Suspect == null || !e.Suspect.Exists()) return;

                foreach (var u in _backupUnits)
                {
                    if (u == null || u.CopHandles == null) continue;
                    foreach (var h in u.CopHandles)
                    {
                        var cop = Entity.FromHandle(h) as Ped;
                        if (cop == null || !cop.Exists() || cop.IsDead) continue;

                        try
                        {
                            if (_convoyMode == ConvoyMode.FreeRoam && cop.IsInVehicle())
                            {
                                cop.Task.LeaveVehicle();
                            }
                            cop.Task.ClearAll();
                            Function.Call(Hash.TASK_COMBAT_PED, cop.Handle, e.Suspect.Handle, 0, 16);
                        }
                        catch { }
                    }
                }
            }
            catch { }
        }

        private void CheckPlayerUnderAttack(Ped player)
        {
            try
            {
                int now = Game.GameTime;
                if (now - _lastPlayerDamageCheckMs < PlayerDamageCheckIntervalMs) return;
                _lastPlayerDamageCheckMs = now;

                if (!player.Exists() || player.IsDead) return;

                var nearbyPeds = World.GetNearbyPeds(player, 50f);
                foreach (var ped in nearbyPeds)
                {
                    if (ped == null || !ped.Exists() || ped.Handle == player.Handle) continue;
                    if (ped.IsDead) continue;

                    bool isAttacking = false;
                    try
                    {
                        isAttacking = Function.Call<bool>(Hash.IS_PED_SHOOTING, ped.Handle) ||
                                      Function.Call<bool>(Hash.IS_PED_IN_COMBAT, ped.Handle, player.Handle);
                    }
                    catch { }

                    if (isAttacking)
                    {
                        float dist = 0f;
                        try { dist = ped.Position.DistanceTo(player.Position); } catch { dist = 999f; }

                        if (dist <= 40f)
                        {
                            bool alreadyTargeting = (_lastAttackerHandle == ped.Handle);
                            if (!alreadyTargeting)
                            {
                                _lastAttackerHandle = ped.Handle;
                                OrderBackupToAttack(ped);
                            }
                            return;
                        }
                    }
                }

                _lastAttackerHandle = -1;
            }
            catch { }
        }

        private void OrderBackupToAttack(Ped target)
        {
            try
            {
                if (target == null || !target.Exists() || target.IsDead) return;

                foreach (var u in _backupUnits)
                {
                    if (u == null || u.CopHandles == null) continue;
                    foreach (var h in u.CopHandles)
                    {
                        if (h == 0) continue;
                        var cop = Entity.FromHandle(h) as Ped;
                        if (cop == null || !cop.Exists() || cop.IsDead) continue;

                        try
                        {
                            if (_convoyMode == ConvoyMode.FreeRoam && cop.IsInVehicle())
                            {
                                cop.Task.LeaveVehicle();
                            }
                            Function.Call(Hash.TASK_COMBAT_PED, cop.Handle, target.Handle, 0, 16);
                        }
                        catch { }
                    }
                }

                ModLog.Info("[Dispatch] Backup engaging attacker handle=" + target.Handle);
            }
            catch { }
        }

        private bool CooldownReady()
        {
            int now = Game.GameTime;
            if (now - _lastActionAtMs < CooldownMs) return false;
            _lastActionAtMs = now;
            return true;
        }

        private void DeleteBlipByHandle(int blipHandle)
        {
            if (blipHandle == 0) return;

            try
            {
                var b = new Blip(blipHandle);
                if (b != null && b.Exists()) b.Delete();
            }
            catch { }
        }

        public void SetConvoyFollowPlayer()
        {
            int now = Game.GameTime;
            if (_convoyMode == ConvoyMode.FollowPlayer && (now - _lastFollowModeAtMs) < FollowModeDebounceMs)
                return;

            _lastFollowModeAtMs = now;
            _convoyMode = ConvoyMode.FollowPlayer;
            _lastFollowUpdateAtMs = 0;
            foreach (var u in _backupUnits) u.IsFollowing = false;
            ModLog.Info($"[Dispatch] SetConvoyFollowPlayer called, units={_backupUnits.Count}");
            Notification.Show("~b~支援车队：跟随玩家");

            // 立刻重发一次，避免“选了跟随但车不动”
            try { _lastFollowUpdateAtMs = 0; } catch { }
            try { TickUpdate(); } catch { }
        }


        public void SetConvoyFreeRoam()
        {
            _convoyMode = ConvoyMode.FreeRoam;
            _lastFreeRoamIssuedAtMs = 0;
            foreach (var u in _backupUnits) u.IsFollowing = false;
            ModLog.Info($"[Dispatch] SetConvoyFreeRoam called, units={_backupUnits.Count}");
            Notification.Show("~y~支援车队：自由行动");
        }

        public void TickUpdate()
        {
            try
            {
                var player = Game.Player.Character;
                if (player == null || !player.Exists()) return;

                if (player.IsDead)
                {
                    ClearAllBackup("PlayerDead");
                    return;
                }

                CleanupInvalidUnits();
                CheckPlayerAttackBackup(player);
                if (_convoyMode == ConvoyMode.FreeRoam)
                {
                    CheckPlayerUnderAttack(player);
                }

                int now = Game.GameTime;

                if (_convoyMode == ConvoyMode.FollowPlayer)
                {
                    Vehicle pv = null;
                    try { if (player.IsInVehicle()) pv = player.CurrentVehicle; } catch { pv = null; }

                    foreach (var u in _backupUnits)
                    {
                        var veh = Entity.FromHandle(u.VehicleHandle) as Vehicle;
                        var drv = Entity.FromHandle(u.DriverHandle) as Ped;
                        if (veh == null || !veh.Exists()) continue;
                        if (drv == null || !drv.Exists() || drv.IsDead) continue;

                        try
                        {
                            try { Function.Call(Hash.SET_VEHICLE_ENGINE_ON, veh.Handle, true, true, false); } catch { }
                            try { Function.Call(Hash.SET_DRIVER_ABILITY, drv.Handle, 1.0f); } catch { }
                            try { Function.Call(Hash.SET_DRIVER_RACING_MODIFIER, drv.Handle, 1.0f); } catch { }

                            // 周期性重发“跟随任务”：避免 AI/碰撞/战斗状态把任务打断后不再跟随
                            bool shouldIssue = (!u.IsFollowing) || (now - _lastFollowUpdateAtMs >= FollowUpdateDebounceMs);
                            if (!shouldIssue) continue;

                            if (now - _lastFollowUpdateAtMs >= FollowUpdateDebounceMs)
                                _lastFollowUpdateAtMs = now;

                            try { if (drv.IsInVehicle(veh)) drv.Task.ClearSecondary(); } catch { }
                            u.IsFollowing = true;

                            Vector3 dest = player.Position;
                            try
                            {
                                if (pv != null && pv.Exists())
                                {
                                    var forward = pv.ForwardVector;
                                    dest = pv.Position - (forward * 18.0f);
                                }
                            }
                            catch { dest = player.Position; }

                            try
                            {
                                Function.Call(Hash.TASK_VEHICLE_DRIVE_TO_COORD, drv.Handle, veh.Handle, dest.X, dest.Y, dest.Z, FollowMaxSpeed, 0, veh.Model.Hash, 786603, 7.0f, 5.0f);
                            }
                            catch
                            {
                                try
                                {
                                    Function.Call(Hash.TASK_VEHICLE_FOLLOW, drv.Handle, veh.Handle, pv?.Handle ?? player.Handle, FollowMaxSpeed, 786603, 8);
                                }
                                catch { }
                            }

                            // 鍏滃簳锛氭湁鏃?AI 浼?鎵撴柟鍚戠洏浣嗕笉韪╂补闂?锛岃繖閲屽己鍒舵澗鍒硅溅/鍚姩寮曟搸骞剁粰涓€鐐瑰墠杩涢€熷害鎻愮ず
                            try { Function.Call(Hash.SET_VEHICLE_ENGINE_ON, veh.Handle, true, true, false); } catch { }
                            try { Function.Call(Hash.SET_VEHICLE_BRAKE_LIGHTS, veh.Handle, false); } catch { }
                            // 不再强推前进速度，避免 AI 在转向时出现“刹车+倒挡”抖动
                            try { Function.Call(Hash.SET_VEHICLE_OUT_OF_CONTROL, veh.Handle, false, false); } catch { }
                            try { Function.Call(Hash.SET_VEHICLE_REDUCE_GRIP, veh.Handle, false); } catch { }
                            try { Function.Call(Hash.SET_VEHICLE_DOORS_LOCKED_FOR_ALL_PLAYERS, veh.Handle, false); } catch { }
                            try { Function.Call(Hash.SET_VEHICLE_DOORS_LOCKED, veh.Handle, 1); } catch { }
                            try { Function.Call(Hash.SET_VEHICLE_UNDRIVEABLE, veh.Handle, false); } catch { }
                            try { Function.Call(Hash.SET_VEHICLE_IS_CONSIDERED_BY_PLAYER, veh.Handle, true); } catch { }

                            if (now - _lastFollowUpdateAtMs >= FollowUpdateDebounceMs)
                                _lastFollowUpdateAtMs = now;
                        }
                        catch (Exception ex) { ModLog.Error($"[Dispatch] Follow error: {ex}"); }
                    }
                }
                else
                {
                    if (now - _lastFreeRoamIssuedAtMs < FreeRoamReissueMs) return;
                    _lastFreeRoamIssuedAtMs = now;

                    foreach (var u in _backupUnits)
                    {
                        var veh = Entity.FromHandle(u.VehicleHandle) as Vehicle;
                        var drv = Entity.FromHandle(u.DriverHandle) as Ped;
                        if (veh == null || !veh.Exists()) continue;
                        if (drv == null || !drv.Exists() || drv.IsDead) continue;

                        try { Function.Call(Hash.TASK_VEHICLE_DRIVE_WANDER, drv.Handle, veh.Handle, 18.0f, 786468); } catch { }
                    }
                }
            }
            catch { }
        }

        public void TrySpawnBackup()
{
    if (!CooldownReady()) return;

    CleanupInvalidUnits();
    if (_backupUnits.Count >= ModConfig.MaxBackupCars)
    {
        Notification.Show("~y~支援已达上限（最多" + ModConfig.MaxBackupCars + "辆）");
        return;
    }

    try
    {
        var player = Game.Player.Character;
        if (player == null || !player.Exists()) return;

        float spawnRadius = 400f;
        float angleOffset = _backupUnits.Count * 45f;
        float baseAngle = player.Heading + angleOffset;
        float rad = baseAngle * (float)(Math.PI / 180.0);
        float spawnDist = spawnRadius + _backupUnits.Count * 30f;

        Vector3 spawnBase = player.Position + new Vector3(
            (float)Math.Cos(rad) * spawnDist,
            (float)Math.Sin(rad) * spawnDist,
            0f
        );

        Vector3 spawn = World.GetNextPositionOnStreet(spawnBase);

        Vehicle veh = null;
        try { veh = World.CreateVehicle(VehicleHash.Police, spawn); } catch { veh = null; }
        if (veh == null || !veh.Exists())
        {
            Notification.Show("~r~呼叫失败：无法生成警车");
            return;
        }

        Ped driver = null;
        Ped p1 = null;
        Ped p2 = null;
        Ped p3 = null;
        try { driver = veh.CreatePedOnSeat(VehicleSeat.Driver, PedHash.Cop01SMY); } catch { }
        try { p1 = veh.CreatePedOnSeat(VehicleSeat.Passenger, PedHash.Cop01SMY); } catch { }
        try { p2 = veh.CreatePedOnSeat(VehicleSeat.LeftRear, PedHash.Cop01SMY); } catch { }
        try { p3 = veh.CreatePedOnSeat(VehicleSeat.RightRear, PedHash.Cop01SMY); } catch { }

        if (driver == null || !driver.Exists())
        {
            try { veh.Delete(); } catch { }
            Notification.Show("~r~呼叫失败：无法生成司机");
            return;
        }

        try
        {
            var cops = new[] { driver, p1, p2, p3 };
            foreach (var c in cops)
            {
                if (c == null || !c.Exists() || c.IsDead) continue;
                try { c.BlockPermanentEvents = true; } catch { }
                try { c.AlwaysKeepTask = true; } catch { }
                try { Function.Call(Hash.SET_CAN_ATTACK_FRIENDLY, c.Handle, false, false); } catch { }
                try { Function.Call(Hash.SET_PED_AS_COP, c.Handle, true); } catch { }
                try { Function.Call(Hash.SET_PED_COMBAT_ABILITY, c.Handle, 2); } catch { }
                try { Function.Call(Hash.SET_PED_COMBAT_MOVEMENT, c.Handle, 2); } catch { }
                try { c.Weapons.Give(WeaponHash.Pistol, 60, false, true); } catch { }
                try { c.Weapons.Give(WeaponHash.CarbineRifle, 120, false, false); } catch { }
                try { c.Weapons.Give(WeaponHash.StunGun, 10, false, false); } catch { }
            }
        }
        catch { }

        int blipHandle = 0;
        try
        {
            var b = veh.AddBlip();
            if (b != null && b.Exists())
            {
                b.Sprite = BlipSprite.Standard;
                b.Color = BlipColor.Purple;
                b.Scale = 0.85f;
                b.IsShortRange = false;
                b.Name = "支援车队";
                blipHandle = b.Handle;
            }
        }
        catch { }

        _backupUnits.Add(new BackupUnit
        {
            VehicleHandle = veh.Handle,
            DriverHandle = driver.Handle,
            CopHandles = new[]
            {
                        driver.Handle,
                        p1 != null && p1.Exists() ? p1.Handle : 0,
                        p2 != null && p2.Exists() ? p2.Handle : 0,
                        p3 != null && p3.Exists() ? p3.Handle : 0,
                    },
            BlipHandle = blipHandle,
        });

        SmsNotification.Show("911调度", "支援已派出", "支援车队正在巡逻，按F7选择跟随");
        ModLog.Info("[Dispatch] Backup unit spawned (vehicle=" + veh.Handle + ", total=" + _backupUnits.Count + ")");

        _lastFreeRoamIssuedAtMs = 0;
        TickUpdate();
    }
    catch (Exception ex)
    {
        ModLog.Error("[Dispatch] TrySpawnBackup error: " + ex);
    }
}

private void CleanupInvalidUnits()
{
    for (int i = _backupUnits.Count - 1; i >= 0; i--)
    {
        var u = _backupUnits[i];
        var veh = Entity.FromHandle(u.VehicleHandle) as Vehicle;
        if (veh == null || !veh.Exists())
        {
            try { DeleteBlipByHandle(u.BlipHandle); } catch { }

            _backupUnits.RemoveAt(i);
            continue;
        }

        // 司机死了/没了：整车踢掉
        var drv = Entity.FromHandle(u.DriverHandle) as Ped;
        if (drv == null || !drv.Exists() || drv.IsDead)
        {
            try { DeleteBlipByHandle(u.BlipHandle); } catch { }

            try { veh.Delete(); } catch { }
            _backupUnits.RemoveAt(i);
        }
    }
}

private void CheckPlayerAttackBackup(Ped player)
{
    // 玩家攻击支援：直接撤退（并提示不可攻击）
    try
    {
        foreach (var u in _backupUnits)
        {
            foreach (var h in u.CopHandles)
            {
                if (h == 0) continue;
                var cop = Entity.FromHandle(h) as Ped;
                if (cop == null || !cop.Exists() || cop.IsDead) continue;

                bool damaged = false;
                try { damaged = Function.Call<bool>(Hash.HAS_ENTITY_BEEN_DAMAGED_BY_ENTITY, cop.Handle, player.Handle, true); } catch { damaged = false; }
                if (!damaged) continue;

                Notification.Show("~r~支援警员不可攻击！\n~w~当前支援队已撤退。");
                ClearAllBackup("PlayerAttackBackup");
                return;
            }
        }
    }
    catch { }
}

private void ClearAllBackup(string reason)
{
    try
    {
        foreach (var u in _backupUnits)
        {
            try
            {
                foreach (var h in u.CopHandles)
                {
                    if (h == 0) continue;
                    var cop = Entity.FromHandle(h) as Ped;
                    if (cop == null || !cop.Exists()) continue;
                    try { cop.Task.WanderAround(); } catch { }
                    try { cop.MarkAsNoLongerNeeded(); } catch { }
                    try { cop.Delete(); } catch { }
                }
            }
            catch { }

            try { DeleteBlipByHandle(u.BlipHandle); } catch { }

            try
            {
                var veh = Entity.FromHandle(u.VehicleHandle) as Vehicle;
                if (veh != null && veh.Exists())
                {
                    try { veh.MarkAsNoLongerNeeded(); } catch { }
                    try { veh.Delete(); } catch { }
                }
            }
            catch { }
        }
    }
    catch { }

    _backupUnits.Clear();
}

public void TryDeploySpikeStrip()
{
    if (!CooldownReady()) return;

    try
    {
        var player = Game.Player.Character;
        if (player == null || !player.Exists()) return;

        // 优先在玩家前方部署；若玩家在车内，用车辆朝向
        Vector3 basePos = player.Position;
        Vector3 forward = player.ForwardVector;
        float heading = player.Heading;

        try
        {
            if (player.IsInVehicle())
            {
                var v = player.CurrentVehicle;
                if (v != null && v.Exists())
                {
                    basePos = v.Position;
                    forward = v.ForwardVector;
                    heading = v.Heading;
                }
            }
        }
        catch { }

        Vector3 pos = basePos + forward * 8.0f;
        // 贴地，避免悬空
        try
        {
            float groundZ = 0f;
            bool ok = Function.Call<bool>(Hash.GET_GROUND_Z_FOR_3D_COORD, pos.X, pos.Y, pos.Z + 50.0f, new OutputArgument(), false);
            if (ok)
            {
                var outArg = new OutputArgument();
                ok = Function.Call<bool>(Hash.GET_GROUND_Z_FOR_3D_COORD, pos.X, pos.Y, pos.Z + 50.0f, outArg, false);
                if (ok) groundZ = outArg.GetResult<float>();
                if (ok) pos.Z = groundZ;
            }
        }
        catch { }

        // 常见钉刺带模型：P_ld_stinger_s（best-effort）
        var model = new Model("p_ld_stinger_s");
        if (!model.IsInCdImage || !model.IsValid)
        {
            Notification.Show("~y~钉刺带模型不可用（p_ld_stinger_s）");
            return;
        }

        model.Request(500);
        if (!model.IsLoaded)
        {
            Notification.Show("~y~钉刺带模型加载失败");
            return;
        }

        var prop = World.CreateProp(model, pos, true, false);
        if (prop != null && prop.Exists())
        {
            try { prop.Heading = heading; } catch { }
            try { Function.Call(Hash.PLACE_OBJECT_ON_GROUND_PROPERLY, prop.Handle); } catch { }
            try { Function.Call(Hash.FREEZE_ENTITY_POSITION, prop.Handle, true); } catch { }
        }

        Notification.Show("~g~已部署钉刺带");
        ModLog.Info("[Dispatch] Spike strip deployed");
    }
    catch (Exception ex)
    {
        ModLog.Error("[Dispatch] TryDeploySpikeStrip error: " + ex);
    }
}

public void TryDeployRoadblock()
{
    if (!CooldownReady()) return;

    try
    {
        var player = Game.Player.Character;
        if (player == null || !player.Exists()) return;

        Vector3 basePos = player.Position;
        Vector3 forward = player.ForwardVector;
        float heading = player.Heading;

        try
        {
            if (player.IsInVehicle())
            {
                var v = player.CurrentVehicle;
                if (v != null && v.Exists())
                {
                    basePos = v.Position;
                    forward = v.ForwardVector;
                    heading = v.Heading;
                }
            }
        }
        catch { }

        Vector3 pos = basePos + forward * 10.0f;
        // 贴地，避免悬空
        try
        {
            float groundZ = 0f;
            bool ok = Function.Call<bool>(Hash.GET_GROUND_Z_FOR_3D_COORD, pos.X, pos.Y, pos.Z + 50.0f, new OutputArgument(), false);
            if (ok)
            {
                var outArg = new OutputArgument();
                ok = Function.Call<bool>(Hash.GET_GROUND_Z_FOR_3D_COORD, pos.X, pos.Y, pos.Z + 50.0f, outArg, false);
                if (ok) groundZ = outArg.GetResult<float>();
                if (ok) pos.Z = groundZ;
            }
        }
        catch { }

        // 常见路障模型：prop_barrier_work05（best-effort）
        var model = new Model("prop_barrier_work05");
        if (!model.IsInCdImage || !model.IsValid)
        {
            Notification.Show("~y~路障模型不可用（prop_barrier_work05）");
            return;
        }

        model.Request(500);
        if (!model.IsLoaded)
        {
            Notification.Show("~y~路障模型加载失败");
            return;
        }

        // 放 3 个形成简易路障
        for (int i = -1; i <= 1; i++)
        {
            Vector3 side = player.RightVector * (i * 2.2f);
            var prop = World.CreateProp(model, pos + side, true, false);
            if (prop != null && prop.Exists())
            {
                try { prop.Heading = heading; } catch { }
                try { Function.Call(Hash.PLACE_OBJECT_ON_GROUND_PROPERLY, prop.Handle); } catch { }
                try { Function.Call(Hash.FREEZE_ENTITY_POSITION, prop.Handle, true); } catch { }
            }
        }

        Notification.Show("~g~已部署路障");
        ModLog.Info("[Dispatch] Roadblock deployed");
    }
    catch (Exception ex)
    {
        ModLog.Error("[Dispatch] TryDeployRoadblock error: " + ex);
    }
}
    }
}
