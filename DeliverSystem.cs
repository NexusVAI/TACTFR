using EF.PoliceMod.Core;
using GTA;
using GTA.Math;
using GTA.Native;
using GTA.UI;
using System;
using System.Linq;


namespace EF.PoliceMod.Gameplay
{
    public class DeliverSystem
    {
        private readonly LockTargetSystem _lockTargetSystem;

        // Mission Row Police Station（与 DutyLifecycleController 保持一致；另加 CaseManager 的坐标作兼容）
        private readonly Vector3 _policeStationPos = new Vector3(441.2f, -981.9f, 30.7f);
        private readonly Vector3 _policeStationPosAlt = new Vector3(443.5f, -981.0f, 30.7f);
        private const float DeliverRadius = 18.0f;
        private Ped GetDeliverTarget()
        {
            // Step3：案件链路优先（主嫌疑人），避免巡逻/非案件锁定目标误交付
            try
            {
                var cm = EFCore.Instance?.GetCaseManager();
                if (cm != null && cm.HasActiveCase)
                {
                    int activeHandle = cm.CurrentSuspectHandle;
                    if (activeHandle > 0)
                    {
                        var ped = World.GetAllPeds().FirstOrDefault(x => x != null && x.Exists() && x.Handle == activeHandle);
                        if (ped != null && ped.Exists()) return ped;
                    }
                }
            }
            catch { }

            try
            {
                Ped locked = _lockTargetSystem != null ? _lockTargetSystem.CurrentTarget : null;
                if (locked != null && locked.Exists()) return locked;
            }
            catch { }


        private bool IsCaseTarget(Ped suspect)
        {
            if (suspect == null || !suspect.Exists()) return false;
            try
            {
                var cm = EFCore.Instance?.GetCaseManager();
                if (cm == null || !cm.HasActiveCase) return false;

                if (cm.CurrentSuspectHandle == suspect.Handle) return true;

                var handles = cm.SuspectHandles;
                if (handles != null)
                {
                    foreach (var h in handles)
                    {
                        if (h == suspect.Handle) return true;
                    }
                }
            }
            catch { }

            return false;
        }

            return null;
        }

        private bool IsDeliverReady(Ped player, Ped suspect)
        {
            if (player == null || !player.Exists()) return false;
            if (suspect == null || !suspect.Exists()) return false;

            // 玩家必须在警局附近
            if (!IsNearPoliceStation(player.Position)) return false;

            // ★关键：嫌疑人也必须在警局附近（避免“刚接任务站在警局就能交付远处嫌疑人”）
            if (!IsNearPoliceStation(suspect.Position)) return false;

            // 建议交付条件：嫌疑人必须被你押送到位——
            // 1) 同车（嫌疑人在你的车里），或
            // 2) 已下车但贴近你（例如下车后站在门口）
            try
            {
                if (player.IsInVehicle())
                {
                    var pv = player.CurrentVehicle;
                    if (pv != null && pv.Exists() && suspect.IsInVehicle(pv)) return true;
                }
            }
            catch { }

            try
            {
                if (suspect.Position.DistanceTo(player.Position) <= 6.0f) return true;
            }
            catch { }

            return false;
        }

        private bool CanShowDeliverHint()
        {
            Ped target = GetDeliverTarget();
            if (target == null || !target.Exists())
                return false;

            Ped player = Game.Player.Character;
            if (!player.Exists())
                return false;

            return IsDeliverReady(player, target);
        }
        private bool SupportsAnimatedExit(Vehicle veh)
        {
            int seatCount = Function.Call<int>(
                Hash.GET_VEHICLE_MODEL_NUMBER_OF_SEATS,
                veh.Model.Hash
            );

            return seatCount >= 4;
        }




        public DeliverSystem(LockTargetSystem lockTargetSystem)
        {
            _lockTargetSystem = lockTargetSystem;

            EventBus.Subscribe<EF.PoliceMod.Core.DeliverRequestedEvent>(_ => OnDeliverRequested());
            EventBus.Subscribe<DutyEndedEvent>(_ => { try { _lockTargetSystem?.ForceClear(); } catch { } });
            EventBus.Subscribe<EF.PoliceMod.Core.SuspectDeliveredEvent>(_ => { try { _lockTargetSystem?.ForceClear(); } catch { } });
        }
        private void OnDeliverRequested()
        {
            if (!CanDeliver())
                return;

            Deliver();
        }

        private void FinalizeDeliveredSuspect(Ped suspect)
        {
            if (suspect == null || !suspect.Exists())
                return;

         

            try
            {
                try { suspect.Task.ClearAllImmediately(); } catch (Exception) { /* best effort */ }
                try { suspect.MarkAsNoLongerNeeded(); } catch (Exception) { /* best effort */ }
                try { suspect.Delete(); } catch (Exception ex) { ModLog.Error("[Deliver] FinalizeDeliveredSuspect Delete failed: " + ex); }
                ModLog.Info($"[Deliver] FinalizeDeliveredSuspect: cleaned suspect {suspect.Handle}");
            }
            catch (Exception ex)
            {
                ModLog.Error("[Deliver] FinalizeDeliveredSuspect failed: " + ex);
            }
        }

        public void Initialize()
        {
            // 这里暂时不靠事件，走 Tick 检测（更稳定）
        }

            // 仅允许交付当前案件嫌疑人，隔离巡逻模式目标
            if (!IsCaseTarget(target))
                return false;

        public void Shutdown()
        {
        }

        /// <summary>
        /// 每帧调用（在 EFCore.OnTick 或主循环里调）
        /// </summary>
        public void Update()
        {
            

            if (!CanShowDeliverHint())
                return;

            GTA.UI.Screen.ShowSubtitle($"~y~按 {EF.PoliceMod.Core.KeyBindings.DeliverSuspect} 键交付嫌疑人", 1);

        }


        private bool CanDeliver()
        {
            Ped target = GetDeliverTarget();
            if (target == null || !target.Exists())
                return false;

            Ped player = Game.Player.Character;
            if (!player.Exists())
                return false;

            return IsDeliverReady(player, target);
        }


        private bool IsNearPoliceStation(Vector3 playerPos)
        {
            try
            {
                if (playerPos.DistanceTo(_policeStationPos) <= DeliverRadius) return true;
            }
            catch { }

            try
            {
                if (playerPos.DistanceTo(_policeStationPosAlt) <= DeliverRadius) return true;
            }
            catch { }

            return false;
        }



        private void Deliver()
        {
            Ped target = GetDeliverTarget();
            if (target == null || !target.Exists())
                return;

            if (target.IsInVehicle())
            {
                

                try
                {
                    try { target.Task.ClearAll(); } catch (Exception) { /* best effort */ }
                    target.BlockPermanentEvents = true;
                    target.AlwaysKeepTask = true;

                    Vehicle veh = target.CurrentVehicle;
                    Script.Wait(0);

                    if (veh == null || !veh.Exists())
                    {
                        ModLog.Info("[Deliver] Deliver aborted: vehicle invalid");
                        return;
                    }

                    if (SupportsAnimatedExit(veh))
                    {
                        // 正常动画下车 —— 用 try/catch 保护
                        try
                        {
                            target.Task.LeaveVehicle(veh, LeaveVehicleFlags.None);

                            int timeout = Game.GameTime + 5000;
                            while (target.Exists() && target.IsInVehicle() && Game.GameTime < timeout)
                            {
                                Script.Wait(0);
                            }
                        }
                        catch (Exception ex)
                        {
                            ModLog.Error("[Deliver] LeaveVehicle failed: " + ex);
                            // 兜底：尝试 warp out
                            try { target.Task.WarpOutOfVehicle(veh); } catch (Exception ex2) { ModLog.Error("[Deliver] WarpOut fallback failed: " + ex2); }
                        }
                    }
                    else
                    {
                        // 兜底：安全瞬移（避免卡模型）
                        try
                        {
                            target.Task.WarpOutOfVehicle(veh);
                            Vector3 offset = veh.RightVector * 1.5f;
                            target.Position = veh.Position + offset;
                        }
                        catch (Exception ex)
                        {
                            ModLog.Error("[Deliver] WarpOutOfVehicle failed: " + ex);
                        }
                    }
                }
                catch (Exception ex)
                {
                    ModLog.Error("[Deliver] Deliver vehicle-exit sequence failed: " + ex);
                }
            }


            // 奖励与提示
            Game.Player.Money += 10000;
            GTA.UI.Notification.Show("~g~嫌疑人已成功交付\n~w~+$10000");

            // ★ 先通知案件完成（保证订阅者在 Ped 仍可用时接收通知）
            // 这样订阅方在收到事件时还能安全地对 Ped 做 Exists()/Task 查询。
            // 同时用 try/catch 保护防止订阅者抛异常影响本流程。
            try
            {
                EventBus.Publish(new EF.PoliceMod.Core.SuspectDeliveredEvent(target.Handle));
            }
            catch (Exception exPub)
            {
                ModLog.Error("[Deliver] Publish SuspectDeliveredEvent failed: " + exPub);
            }

            // ★ 最终清理（在事件发布后再清理 Ped）
            try
            {
                FinalizeDeliveredSuspect(target);
            }
            catch (Exception exFinalize)
            {
                ModLog.Error("[Deliver] FinalizeDeliveredSuspect failed: " + exFinalize);
            }

            // ★ 清空锁定（放在清理之后也可以；如果你希望在发布事件后立即解除锁定以避免并发访问，也可将此行移到事件发布后；此处保守地在清理后执行）
            try
            {
                _lockTargetSystem.ForceClear();
            }
            catch (Exception exClear)
            {
                ModLog.Error("[Deliver] LockTargetSystem.ForceClear failed: " + exClear);
            }
        }
    }
}
