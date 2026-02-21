using EF.PoliceMod.Core;
using EF.PoliceMod.Core.Contracts;
using EF.PoliceMod.Systems;
using GTA;
using GTA.Native;
using System;
using System.Linq;

namespace EF.PoliceMod.Systems
{
    /// <summary>
    /// 双嫌疑人“单独链路”（阶段A）：
    /// - 不影响现有单嫌疑人押送/交付链路（仍以 primary 为权威）
    /// - 仅负责：维护 2 号嫌疑人的“丢失/找回”标记（范围圈 vs 精确红点）
    /// - 目前不下任何 AI 行为任务，稳定优先
    /// </summary>
    public sealed class DualSuspectCoordinator : ISystem
    {
        private const int TickIntervalMs = 900;
        private int _lastTickAtMs = 0;

        private int _secondaryHandle = -1;
        private bool _secondaryLost = false;
        private int _secondaryRecoverAtMs = 0;

        private const float LostIfFartherThan = 1400f;
        private const float RecoverIfCloserThan = 420f;

        public void Initialize()
        {
            ModLog.Info("[DualSuspectCoordinator] Initialized");
        }

        public void Shutdown()
        {
            _secondaryHandle = -1;
            _secondaryLost = false;
            _secondaryRecoverAtMs = 0;
            ModLog.Info("[DualSuspectCoordinator] Shutdown");
        }

        public void Tick()
        {
            int now = Game.GameTime;
            if (now - _lastTickAtMs < TickIntervalMs) return;
            _lastTickAtMs = now;

            try
            {
                if (!CaseStatusQuery.HasActiveCase)
                {
                    _secondaryHandle = -1;
                    _secondaryLost = false;
                    return;
                }

                var mgr = EFCore.Instance?.GetCaseManager();
                if (mgr == null) return;

                // 约定：SuspectHandles[0]=primary，[1]=secondary
                var list = mgr.SuspectHandles;
                if (list == null || list.Count < 2)
                {
                    _secondaryHandle = -1;
                    _secondaryLost = false;
                    return;
                }

                _secondaryHandle = list[1];
                if (_secondaryHandle <= 0) return;

                var player = Game.Player.Character;
                if (player == null || !player.Exists()) return;

                Ped s2 = null;
                try { s2 = World.GetAllPeds().FirstOrDefault(p => p != null && p.Exists() && p.Handle == _secondaryHandle); } catch { s2 = null; }
                if (s2 == null || !s2.Exists()) return;

                float dist = 9999f;
                try { dist = s2.Position.DistanceTo(player.Position); } catch { dist = 9999f; }

                if (!_secondaryLost && dist >= LostIfFartherThan && now > _secondaryRecoverAtMs)
                {
                    _secondaryLost = true;
                    _secondaryRecoverAtMs = now + 5000;
                    // 这里不直接动 CaseManager 的 blip/搜索圈（避免耦合过深）；仅记录日志，后续再接入统一的“SecondarySearchAreaBlip”
                    ModLog.Info($"[DualSuspectCoordinator] Secondary LOST: handle={_secondaryHandle}, dist={dist:0}");
                }

                if (_secondaryLost && dist <= RecoverIfCloserThan)
                {
                    _secondaryLost = false;
                    _secondaryRecoverAtMs = now + 5000;
                    ModLog.Info($"[DualSuspectCoordinator] Secondary FOUND: handle={_secondaryHandle}, dist={dist:0}");
                }
            }
            catch (Exception ex)
            {
                ModLog.Error("[DualSuspectCoordinator] Tick error: " + ex);
            }
        }
    }
}
