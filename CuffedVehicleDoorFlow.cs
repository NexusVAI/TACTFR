using EF.PoliceMod.Core;
using EF.PoliceMod.Executors;
using GTA;
using System;

namespace EF.PoliceMod.Executors
{
    /// <summary>
    /// 被拷线（CuffAndLead）车辆门流程：
    /// - 上车前开门
    /// - 入座后关门（含 pending 兜底/超时清理）
    /// - 下车时开门/下车后关门
    /// </summary>
    internal sealed class CuffedVehicleDoorFlow
    {
        private int _pendingShutDoorVehicleHandle = 0;
        private int _pendingShutDoorIndex = -1;
        private int _pendingShutDoorAtMs = 0;
        private int _pendingShutDoorSuspectHandle = -1;
        private int _pendingShutDoorExpireAtMs = 0;

        private int _lastExitVehicleHandle = 0;
        private int _lastExitDoorIndex = -1;

        public void ArmPendingShutDoor(int vehicleHandle, int doorIndex, int suspectHandle, int nowMs)
        {
            if (vehicleHandle == 0) return;
            if (doorIndex < 0) return;
            if (suspectHandle <= 0) return;

            _pendingShutDoorVehicleHandle = vehicleHandle;
            _pendingShutDoorIndex = doorIndex;
            _pendingShutDoorAtMs = nowMs + 400;
            _pendingShutDoorSuspectHandle = suspectHandle;
            _pendingShutDoorExpireAtMs = nowMs + 15000;
        }

        public void TryShutDoorImmediatelyAfterBoard(Vehicle vehicle, int nowMs, ArrestActionStyle style)
        {
            if (!SuspectVehicleEscortExecutor.VehicleEscortLine.ShouldAutoDoors(style)) return;
            if (vehicle == null || !vehicle.Exists()) return;

            if (_pendingShutDoorVehicleHandle == vehicle.Handle && _pendingShutDoorIndex >= 0)
            {
                try { VehicleDoorOps.ShutDoor(vehicle, _pendingShutDoorIndex); } catch { }
                _pendingShutDoorVehicleHandle = 0;
                _pendingShutDoorIndex = -1;
                _pendingShutDoorAtMs = 0;
                _pendingShutDoorSuspectHandle = -1;
                _pendingShutDoorExpireAtMs = 0;
            }
        }

        public void TickPendingShutDoor(Ped suspect, int nowMs, ArrestActionStyle style)
        {
            if (!SuspectVehicleEscortExecutor.VehicleEscortLine.ShouldAutoDoors(style)) return;
            if (suspect == null || !suspect.Exists()) return;

            if (_pendingShutDoorVehicleHandle == 0 || _pendingShutDoorIndex < 0) return;
            if (_pendingShutDoorSuspectHandle != suspect.Handle) return;
            if (nowMs < _pendingShutDoorAtMs) return;

            // 只有确认嫌疑人已经在车内，才允许关门
            if (suspect.IsInVehicle() && suspect.CurrentVehicle != null && suspect.CurrentVehicle.Exists() && suspect.CurrentVehicle.Handle == _pendingShutDoorVehicleHandle)
            {
                try { VehicleDoorOps.ShutDoor(suspect.CurrentVehicle, _pendingShutDoorIndex); } catch { }

                _pendingShutDoorVehicleHandle = 0;
                _pendingShutDoorIndex = -1;
                _pendingShutDoorAtMs = 0;
                _pendingShutDoorSuspectHandle = -1;
                _pendingShutDoorExpireAtMs = 0;
                return;
            }

            // 超时兜底：避免永远残留 pending
            if (_pendingShutDoorExpireAtMs != 0 && nowMs >= _pendingShutDoorExpireAtMs)
            {
                _pendingShutDoorVehicleHandle = 0;
                _pendingShutDoorIndex = -1;
                _pendingShutDoorAtMs = 0;
                _pendingShutDoorSuspectHandle = -1;
                _pendingShutDoorExpireAtMs = 0;
            }
        }

        public bool HasPendingDoor() => _pendingShutDoorVehicleHandle != 0;

        public void RecordExitDoor(int vehicleHandle, int doorIndex)
        {
            _lastExitVehicleHandle = vehicleHandle;
            _lastExitDoorIndex = doorIndex;
        }

        public void TryShutDoorAfterExit(ArrestActionStyle style, Func<int, Vehicle> vehicleResolver, Func<Vehicle, int, int> normalizeDoorIndex)
        {
            if (!SuspectVehicleEscortExecutor.VehicleEscortLine.ShouldAutoDoors(style)) return;
            if (_lastExitVehicleHandle == 0 || _lastExitDoorIndex < 0) return;

            try
            {
                var veh = vehicleResolver != null ? vehicleResolver(_lastExitVehicleHandle) : null;
                if (veh != null && veh.Exists())
                {
                    int shutDoor = normalizeDoorIndex != null ? normalizeDoorIndex(veh, _lastExitDoorIndex) : _lastExitDoorIndex;
                    try { VehicleDoorOps.ShutDoor(veh, shutDoor); } catch { }
                }
            }
            catch { }
            finally
            {
                _lastExitVehicleHandle = 0;
                _lastExitDoorIndex = -1;
            }
        }
    }
}
