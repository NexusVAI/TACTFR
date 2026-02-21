using EF.PoliceMod;
using EF.PoliceMod.Core;
using EF.PoliceMod.Core.Contracts;
using EF.PoliceMod.Core.Contracts.Snapshots;
using GTA;
using GTA.Math;
using GTA.Native;
using GTA.UI;
using System.Collections.Generic;
using System;
using System.Linq;

namespace EF.PoliceMod
{
    public partial class CaseManager : ICaseService, EF.PoliceMod.Core.ISuspectContext
    {
        // ===== 案件生命周期控制 =====

        // 最大案件时长（毫秒），10 分钟（用在超时判定与评分）
        private const int MaxCaseDurationMs = 10 * 60 * 1000;
      
        private Ped _suspect;
        private Blip _suspectBlip;
        private Blip _suspectSearchAreaBlip;
        private Vector3 _suspectLastKnownPos;
        private int _suspectLastKnownAtMs = 0;
        private bool _suspectLost = false;
        private int _suspectRecoverAtMs = 0;
        // 双嫌疑人（阶段A）：先做“主嫌疑人驱动 + 副嫌疑人附件目标”
        // 约定：现有单嫌疑人链路（SuspectController/LockTarget/押送/交付/逼停）只围绕 primary 工作
        private readonly List<int> _suspectHandles = new List<int>(2);
        private int _primarySuspectIndex = 0;
        private Blip _secondarySuspectBlip;
        private Ped _secondarySuspect;
        private Vector3 _secondaryLastKnownPos;
        private bool _secondaryLost = false;

        // 5.4.0 Step1：统一案件嫌疑人数据（先服务于双人交付判定）
        private readonly List<EF.PoliceMod.Core.CaseSuspect> _caseSuspects = new List<EF.PoliceMod.Core.CaseSuspect>(2);
        // 案件是否已处于活动中（对外暴露 HasActiveCase）
        private bool _caseActive = false;
        // 防止重复结算的标志（EndCase 会设置它）
        private bool _caseEnded = false;

        // 标记：如果为 true，表示系统允许通过警用终端手动接警（StartCase）
        // — StartDuty 会把它设为 true；交付后也会设为 true；开始案件后设为 false
        private bool _readyForNewCase = false;
        // 新增字段（类字段区）
        private Blip _deliveryRouteBlip = null;
        private int _lastRouteCreatedAt = 0;          // Game.GameTime ms
        private int _lastRouteSuspectHandle = -1;
        private readonly Vector3 _policeStationPos = new Vector3(443.5f, -981.0f, 30.7f); // 如果想改成终端位置，后面我教你
                                                                                          // ---------- 挂起的 SuspectBoarded 事件队列（用于 case 尚未 active 时缓存） ----------
        private readonly System.Collections.Generic.Queue<EF.PoliceMod.Core.SuspectBoardedVehicleEvent> _pendingBoardedEvents
            = new System.Collections.Generic.Queue<EF.PoliceMod.Core.SuspectBoardedVehicleEvent>();

        private bool _pendingSpawn = false;
        private int _spawnDelayEndTime = 0;
        private bool _isOnDuty = false;
        private Ped _lastKnownSuspect;
        private int _lastKnownSuspectHandle = -1;
        private int _caseStartTime;
        private bool _suspectWasResisting = false;

        // --- “丢失”判定（距离版）：只保留“离得太远就丢失” ---
        private const float LostIfFartherThan = 1400f;
        private const float RecoverIfCloserThan = 420f;


        private enum CaseMode
        {
            OnFoot,
            VehicleFlee
        }

        private CaseMode _caseMode = CaseMode.OnFoot;

        // 当玩家通过通缉系统选中某个 ped 时，把 handle 存到这里，SpawnSuspect 会尝试使用这个 ped（优先）
        private int _forcedSuspectHandle = -1;

        // 对外公开的状态（其他模块用来判断能否打开终端）
        // 只有在值勤 && 无进行中案件 && 系统处于“可接警”时，终端用于接警才可用
        public bool HasActiveCase => _caseActive;
        public bool CanAcceptNewCase => _isOnDuty && !_caseActive && _readyForNewCase;
        public bool CanOpenTerminal => _isOnDuty && !_caseActive && _readyForNewCase;

        private bool _initialized = false;

        public void Initialize()
        {
            if (_initialized) return;
            _initialized = true;
            ModLog.Info("[CaseManager] Initialized");
        }

        public new void Tick()
        {
            OnTick();
        }

        public void Shutdown()
        {
            try { CleanupCase(); } catch { }
            try { ClearDeliveryRoute(); } catch { }
            _isOnDuty = false;
            _caseActive = false;
            _initialized = false;
            ModLog.Info("[CaseManager] Shutdown");
        }

        public CaseSnapshot GetSnapshot()
        {
            return new CaseSnapshot(
                _caseActive,
                CurrentSuspectHandle,
                _suspectLastKnownPos,
                _suspectLost,
                _caseStartTime,
                _terminalStars
            );
        }

        void ICaseService.StartCase()
        {
            StartCase();
        }

        void ICaseService.EndCase(CaseEndReason reason)
        {
            EndReason internalReason;
            switch (reason)
            {
                case CaseEndReason.Completed:
                    internalReason = EndReason.Completed;
                    break;
                case CaseEndReason.Failed:
                    internalReason = EndReason.Failed;
                    break;
                case CaseEndReason.Cancelled:
                    internalReason = EndReason.Cancelled;
                    break;
                case CaseEndReason.SuspectDead:
                    internalReason = EndReason.SuspectDead;
                    break;
                case CaseEndReason.Timeout:
                    internalReason = EndReason.Timeout;
                    break;
                case CaseEndReason.OffDuty:
                    internalReason = EndReason.OffDuty;
                    break;
                default:
                    internalReason = EndReason.Cancelled;
                    break;
            }
            EndCase(internalReason);
        }


        // 终端访问权限（解耦 UI 与 CaseManager）：状态由本模块发布，UI 侧只读订阅
        private bool _lastTerminalAccess = false;
        private void PublishTerminalAccessIfChanged()
        {
            bool now = CanOpenTerminal;
            if (now == _lastTerminalAccess) return;
            _lastTerminalAccess = now;
            try { EventBus.Publish(new TerminalAccessChangedEvent(now)); } catch { }
        }


        // 案件状态（供侦察/调度等系统订阅）：尽量只在变化时发布，减少事件噪音
        private bool _lastCaseActive = false;
        private bool _lastSuspectLost = false;
        private int _lastCaseStartedAtMs = 0;
        private bool _lastHeliReconUsed = false;
        private int _lastCurrentSuspectHandle = -1;
        private void PublishCaseStatusIfChanged()
        {
            bool active = HasActiveCase;
            bool lost = IsSuspectLost;
            int started = CaseStartedAtMs;
            bool reconUsed = HeliReconUsed;
            int h = CurrentSuspectHandle;

            if (active == _lastCaseActive
                && lost == _lastSuspectLost
                && started == _lastCaseStartedAtMs
                && reconUsed == _lastHeliReconUsed
                && h == _lastCurrentSuspectHandle)
                return;

            _lastCaseActive = active;
            _lastSuspectLost = lost;
            _lastCaseStartedAtMs = started;
            _lastHeliReconUsed = reconUsed;
            _lastCurrentSuspectHandle = h;

            ModLog.Info($"[CaseManager] Publishing CaseStatusChangedEvent: active={active}, lost={lost}, suspectHandle={h}");

            try
            {
                EventBus.Publish(new CaseStatusChangedEvent(active, lost, started, reconUsed, h));
            }
            catch { }
        }

        // --- 低耦合：给 Input/调度/侦察系统使用的只读状态 ---
        public bool IsOnDuty => _isOnDuty;
        public int CaseStartedAtMs => _caseStartTime;
        public bool IsSuspectLost => _suspectLost;
        public Vector3 SuspectLastKnownPos => _suspectLastKnownPos;
        public IReadOnlyList<int> SuspectHandles => _suspectHandles;
        public int CurrentSuspectHandle
        {
            get
            {
                // 优先使用 primary handle（为双嫌疑人准备）
                try
                {
                    if (_suspectHandles != null && _suspectHandles.Count > 0)
                    {
                        int idx = Math.Max(0, Math.Min(_suspectHandles.Count - 1, _primarySuspectIndex));
                        int h = _suspectHandles[idx];
                        if (h > 0) return h;
                    }
                }
                catch { }

                // 回退到旧逻辑
                return (_lastKnownSuspect != null && _lastKnownSuspect.Exists()) ? _lastKnownSuspect.Handle : _lastKnownSuspectHandle;
            }
        }

        // 本案侦察限制：每案一次
        public bool HeliReconUsed => _heliReconUsed;
        private bool _heliReconUsed = false;

        public void MarkHeliReconUsed() { _heliReconUsed = true; try { PublishCaseStatusIfChanged(); } catch { } }

        // ISuspectContext 回填：供 HeliReconSystem 等低耦合系统调用
        // 现有实现已存在同名方法（若你后续做双嫌疑人，这里可按“主嫌疑人”更新）

        // 供 PullOverSystem 等模块读取“本案嫌疑人”（避免必须先 L 锁定）
        public Ped GetCurrentSuspectPed()
        {
            try
            {
                if (_suspect != null && _suspect.Exists()) return _suspect;
            }
            catch { }

            try
            {
                if (_lastKnownSuspect != null && _lastKnownSuspect.Exists()) return _lastKnownSuspect;
            }
            catch { }

            return null;
        }

        public bool TryGetLastKnownPos(int suspectHandle, out Vector3 pos)
        {
            pos = default(Vector3);
            try
            {
                if (suspectHandle <= 0) return false;

                // primary
                if (_suspect != null && _suspect.Exists() && _suspect.Handle == suspectHandle)
                {
                    pos = _suspectLastKnownPos;
                    return true;
                }
            }
            catch { }

            try
            {
                // secondary（阶段A 临时实现）
                if (_suspectHandles.Count >= 2 && _suspectHandles[1] == suspectHandle)
                {
                    pos = _secondaryLastKnownPos;
                    return true;
                }
            }
            catch { }

            return false;
        }

        public bool IsLost(int suspectHandle)
        {
            try
            {
                if (suspectHandle <= 0) return false;
                if (_suspect != null && _suspect.Exists() && _suspect.Handle == suspectHandle) return _suspectLost;
            }
            catch { }

            try
            {
                if (_suspectHandles.Count >= 2 && _suspectHandles[1] == suspectHandle) return _secondaryLost;
            }
            catch { }

            return false;
        }


        public enum SuspectPersonality
        {
            Civilian,      // 普通嫌疑人
            Nervous,       // 紧张型（可能逃跑）
            Violent,       // 暴力型（高概率反抗）
            ArmedManiac    // 武装暴徒（必带枪）
        }
        public class SuspectProfile
        {
            public SuspectPersonality Personality;
            public float ResistChance;   // 0~1
            public bool HasFirearm;
            public string Briefing;      // 给玩家看的提示
        }

        private SuspectProfile GenerateSuspectProfile()
        {
            Random r = new Random(Game.GameTime);

            int roll = r.Next(100);

            if (roll < 10)
            {
                return new SuspectProfile
                {
                    Personality = SuspectPersonality.ArmedManiac,
                    HasFirearm = true,
                    ResistChance = 0.95f,
                    Briefing = "【高危】武装暴徒，极可能持枪反抗"
                };
            }
            else if (roll < 40)
            {
                return new SuspectProfile
                {
                    Personality = SuspectPersonality.Violent,
                    HasFirearm = false,
                    ResistChance = 0.6f,
                    Briefing = "【中危】可能有暴力倾向，嫌疑人可能反抗"
                };
            }
            else
            {
                return new SuspectProfile
                {
                    Personality = SuspectPersonality.Civilian,
                    HasFirearm = false,
                    ResistChance = 0.3f,
                    Briefing = "【普通】一般嫌疑人，注意控制即可"
                };
            }
        }



        public enum EndReason
        {
            Completed,     // 任务完成
            Failed,        // 任务失败
            Cancelled,     // 任务被取消
            SuspectDead,   // 嫌疑人死亡
            Timeout,       // 超时
            OffDuty        // 下班
        }
        private void EndCase(EndReason reason)
        {
            if (!_caseActive || _caseEnded)
                return; // ★ 防止重复结算（极其重要）

            _caseEnded = true;
            _caseActive = false;

            try { PublishTerminalAccessIfChanged(); } catch { }

            try { PublishCaseStatusIfChanged(); } catch { }

            int elapsedMs = Game.GameTime - _caseStartTime;

            int score = CalculateScore(reason, elapsedMs);
            ShowScore(reason, score, elapsedMs);

            CleanupCase();
            // 清空 pending（案件结束或已交付时）
            if (_pendingBoardedEvents.Count > 0)
            {
                ModLog.Info("[CaseManager] Clearing " + _pendingBoardedEvents.Count + " pending boarded events due to case end");
                _pendingBoardedEvents.Clear();
            }

        }

        private void OnSuspectDelivered(EF.PoliceMod.Core.SuspectDeliveredEvent e)
        {
            try
            {
                MarkDelivered(e.SuspectHandle);

                if (!AreAllCaseSuspectsDelivered())
                {
                    if (TrySwitchToNextPrimary("Delivered"))
                    {
                        try { EventBus.Publish(new EF.PoliceMod.Core.SuspectHandleListChangedEvent(_suspectHandles)); } catch { }
                    }

                    SmsNotification.Show("911调度", "交付进度", $"本案已交付 {GetDeliveredCount()}/{GetCaseSuspectCount()} 名嫌疑人，请继续押送剩余目标。");
                    return;
                }
            }
            catch { }

            EndCase(EndReason.Completed);
            ClearDeliveryRoute();
            // 取消并删除路由 blip（如果存在）
            if (_deliveryRouteBlip != null)
            {
                try
                {
                    _deliveryRouteBlip.ShowRoute = false;
                    _deliveryRouteBlip.Delete();
                }
                catch { }
                _deliveryRouteBlip = null;
            }

            // 交付后不自动生成新案件，需要玩家手动去终端接警
            _readyForNewCase = true;

            try { PublishTerminalAccessIfChanged(); } catch { }

            try { PublishCaseStatusIfChanged(); } catch { }
            ModLog.Info("[CaseManager] All suspects delivered -> awaiting manual terminal acceptance for next case");
            SmsNotification.Show("911调度", "~g~交付完成~s~", "嫌疑人已交付，请前往终端接收下一个警情（按 ~o~O~s~ 打开）");
            // 清空 pending（案件结束或已交付时）
            if (_pendingBoardedEvents.Count > 0)
            {
                ModLog.Info("[CaseManager] Clearing " + _pendingBoardedEvents.Count + " pending boarded events due to case end");
                _pendingBoardedEvents.Clear();
            }

        }

        private int GetCaseSuspectCount()
        {
            try { return Math.Max(1, _caseSuspects.Count); } catch { return 1; }
        }

        private int GetDeliveredCount()
        {
            try
            {
                int c = 0;
                foreach (var s in _caseSuspects)
                {
                    if (s != null && s.Status == EF.PoliceMod.Core.CaseSuspectStatus.Delivered) c++;
                }
                return c;
            }
            catch { return 0; }
        }

        private void MarkDelivered(int handle)
        {
            if (handle <= 0) return;
            try
            {
                foreach (var s in _caseSuspects)
                {
                    if (s == null || s.Handle != handle) continue;
                    s.Status = EF.PoliceMod.Core.CaseSuspectStatus.Delivered;
                    ModLog.Info($"[CaseManager] MarkDelivered: handle={handle}, delivered={GetDeliveredCount()}/{GetCaseSuspectCount()}");
                    return;
                }
            }
            catch { }
        }

        private bool AreAllCaseSuspectsDelivered()
        {
            try
            {
                if (_caseSuspects == null || _caseSuspects.Count == 0) return false;
                foreach (var s in _caseSuspects)
                {
                    if (s == null || s.Status != EF.PoliceMod.Core.CaseSuspectStatus.Delivered) return false;
                }
                return true;
            }
            catch { return false; }
        }


        private bool IsHandleInCurrentCase(int handle)
        {
            if (handle <= 0) return false;
            try
            {
                if (_caseSuspects != null && _caseSuspects.Count > 0)
                {
                    foreach (var s in _caseSuspects)
                    {
                        if (s != null && s.Handle == handle) return true;
                    }
                    return false;
                }

                // 回退：若尚未注册 _caseSuspects，使用旧句柄列表判定
                if (_suspectHandles != null)
                {
                    foreach (var h in _suspectHandles)
                    {
                        if (h == handle) return true;
                    }
                }
            }
            catch { }
            return false;
        }

        private void MarkDead(int handle)
        {
            if (handle <= 0) return;
            try
            {
                foreach (var s in _caseSuspects)
                {
                    if (s == null || s.Handle != handle) continue;
                    s.Status = EF.PoliceMod.Core.CaseSuspectStatus.Dead;
                    ModLog.Info($"[CaseManager] MarkDead: handle={handle}");
                    return;
                }
            }
            catch { }
        }

        private void MarkEscaped(int handle)
        {
            if (handle <= 0) return;
            try
            {
                foreach (var s in _caseSuspects)
                {
                    if (s == null || s.Handle != handle) continue;
                    s.Status = EF.PoliceMod.Core.CaseSuspectStatus.Escaped;
                    ModLog.Info($"[CaseManager] MarkEscaped: handle={handle}");
                    return;
                }
            }
            catch { }
        }

        private bool AreAllCaseSuspectsResolved()
        {
            try
            {
                if (_caseSuspects == null || _caseSuspects.Count == 0) return false;
                foreach (var s in _caseSuspects)
                {
                    if (s == null || !s.IsResolved) return false;
                }
                return true;
            }
            catch { return false; }
        }

        private bool HasAnyDeadSuspect()
        {
            try
            {
                foreach (var s in _caseSuspects)
                {
                    if (s != null && s.Status == EF.PoliceMod.Core.CaseSuspectStatus.Dead) return true;
                }
            }
            catch { }
            return false;
        }

        private bool HasAnyEscapedSuspect()
        {
            try
            {
                foreach (var s in _caseSuspects)
                {
                    if (s != null && s.Status == EF.PoliceMod.Core.CaseSuspectStatus.Escaped) return true;
                }
            }
            catch { }
            return false;
        }


        public void StartCase()
        {
            if (!_isOnDuty || _caseActive)
                return;

            _readyForNewCase = false;

            try { PublishTerminalAccessIfChanged(); } catch { }

            _suspectWasResisting = false;
            _caseActive = true;
            _caseEnded = false;
            _caseStartTime = Game.GameTime;
            _heliReconUsed = false;

            try { PublishCaseStatusIfChanged(); } catch { }

            // ★ 生成嫌疑人性格（只生成一次）
            SuspectProfile profile;
            if (_useTerminalPreset)
            {
                // 终端接警：星级决定风险档位（1~2 普通；3~4 中危；5 高危）
                if (_terminalStars >= 5)
                {
                    profile = new SuspectProfile
                    {
                        Personality = SuspectPersonality.ArmedManiac,
                        HasFirearm = true,
                        ResistChance = 0.95f,
                        Briefing = "~r~【高危】~s~武装暴徒，极可能持枪反抗"
                    };
                }
                else if (_terminalStars >= 3)
                {
                    profile = new SuspectProfile
                    {
                        Personality = SuspectPersonality.Violent,
                        HasFirearm = false,
                        ResistChance = 0.6f,
                        Briefing = "~o~【中危】~s~可能有暴力倾向，嫌疑人可能反抗"
                    };
                }
                else
                {
                    profile = new SuspectProfile
                    {
                        Personality = SuspectPersonality.Civilian,
                        HasFirearm = false,
                        ResistChance = 0.3f,
                        Briefing = "~g~【普通】~s~一般嫌疑人，注意控制即可"
                    };
                }
            }
            else
            {
                profile = GenerateSuspectProfile();
            }

            if (_caseMode == CaseMode.VehicleFlee)
            {
                profile.Briefing = profile.Briefing + "  ~b~嫌疑人正在驾车逃逸~s~（按 ~y~I~s~ 逼停，停稳后按 ~y~U~s~ 要求下车；下车后可直接按 ~y~E~s~ 押送上车）";
            }

            SmsNotification.Show("911调度", "新的警情", profile.Briefing);

            // 例：StartCase() 中把案件标记为 active 的那段后面加：
            if (_pendingBoardedEvents.Count > 0)
            {
                ModLog.Info("[CaseManager] Processing " + _pendingBoardedEvents.Count + " pending SuspectBoarded events now that case is active");
                while (_pendingBoardedEvents.Count > 0)
                {
                    var pending = _pendingBoardedEvents.Dequeue();
                    ProcessSuspectBoardedEvent(pending);
                }
            }

            // 每次新案重置“已控制/已反抗”状态，避免上一案状态串到新嫌疑人
            try
            {
                var scReset = EFCore.Instance?.GetSuspectController();
                scReset?.ForceClear();
            }
            catch { }

            SpawnSuspect(profile);

            // 用完即清：必须在 SpawnSuspect 之后，避免本次案件读不到终端预设（双人案件会退化成单人）
            _useTerminalPreset = false;
            _terminalOptionId = -1;
            _terminalStars = 0;
            _forceDualSuspects = false;
        }

        public void StartDuty()
        {
            _isOnDuty = true;
            _pendingSpawn = false;
            _readyForNewCase = true; // 上班后由玩家去终端接警

            try { PublishTerminalAccessIfChanged(); } catch { }

            try { PublishCaseStatusIfChanged(); } catch { }
            SmsNotification.Show("911调度", "~g~已开始执勤~s~", "请前往警局终端接警（按 ~o~O~s~ 打开）");
            ModLog.Info("[CaseManager] StartDuty -> on duty. Waiting for terminal acceptance.");
            // 不自动 StartCase() —— 玩家需要到终端按 5 接警
        }



        private int CalculateScore(EndReason reason, int elapsedMs)
        {
            if (elapsedMs > MaxCaseDurationMs)
                return 0;
            int baseScore = 0;

            switch (reason)
            {
                case EndReason.Completed:
                    baseScore = 10;   // ⭐ 成功交付是满分基准
                    break;

                case EndReason.SuspectDead:
                    if (_suspectWasResisting)
                        baseScore = 8;    // 合法击毙，低于活捉
                    else
                        baseScore = 2;    // 非授权击毙
                    break;

                case EndReason.Failed:
                case EndReason.Timeout:
                case EndReason.Cancelled:
                    baseScore = 0;
                    break;
            }

            float timeFactor = 1f - (float)elapsedMs / MaxCaseDurationMs;
            if (timeFactor < 0.2f)
                timeFactor = 0.2f;

            return (int)(baseScore * timeFactor);
        }
        private void ShowScore(EndReason reason, int score, int elapsedMs)
        {
            int seconds = elapsedMs / 1000;
            string reasonText = "任务结束";

            switch (reason)
            {
                case EndReason.Completed:
                    reasonText = "成功交付";
                    break;
                case EndReason.SuspectDead:
                    reasonText = "嫌疑人死亡";
                    break;
                case EndReason.Timeout:
                    reasonText = "任务超时";
                    break;
            }

            Notification.Show(
                "~y~案件结束：" + reasonText + "\n" +
                "~w~用时：" + seconds + " 秒\n" +
                "~g~评分：" + score + " / 10"
            );
        }
        public void OnDutyStarted(DutyStartedEvent e)
        {
            StartDuty();
        }

        public void OnDutyEnded(DutyEndedEvent e)
        {
            _isOnDuty = false;
            _pendingSpawn = false;

            try { PublishTerminalAccessIfChanged(); } catch { }

            // 下班未交付：必须清除导航/路线
            try { ClearDeliveryRoute(); } catch { }

            CleanupCase();
            _suspectWasResisting = false;

        }


        private void OnSuspectDead(SuspectDeadEvent e)
        {
            if (!_isOnDuty || !_caseActive) return;

            int deadHandle = -1;
            try { deadHandle = e.SuspectHandle; } catch { deadHandle = -1; }
            if (deadHandle <= 0)
            {
                try { deadHandle = (_lastKnownSuspect != null && _lastKnownSuspect.Exists()) ? _lastKnownSuspect.Handle : -1; } catch { deadHandle = -1; }
            }

            if (deadHandle > 0 && !IsHandleInCurrentCase(deadHandle))
            {
                ModLog.Info($"[CaseManager] Ignore SuspectDeadEvent for non-case handle={deadHandle}");
                return;
            }

            ModLog.Info("[CaseManager] SuspectDeadEvent received");
            try { MarkDead(deadHandle); } catch { }

            // 视觉与导航清理（仅针对当前主嫌疑人）
            try
            {
                if (_lastKnownSuspect != null && _lastKnownSuspect.Exists())
                {
                    try { Function.Call(Hash.SET_PED_TO_RAGDOLL, _lastKnownSuspect.Handle, 5000, 5000, 0, false, false, false); } catch { }
                    try { Function.Call(Hash.FREEZE_ENTITY_POSITION, _lastKnownSuspect.Handle, true); } catch { }
                }
            }
            catch (Exception ex)
            {
                ModLog.Error("[CaseManager] Error during ragdoll/freeze: " + ex);
            }

            try { ClearDeliveryRoute(); } catch (Exception ex) { ModLog.Error("[CaseManager] ClearDeliveryRoute error: " + ex); }

            // 仍有未终态嫌疑人：切换主嫌疑人并继续案件
            try
            {
                if (!AreAllCaseSuspectsResolved())
                {
                    if (TrySwitchToNextPrimary("Dead"))
                    {
                        SmsNotification.Show("911调度", "更新", "一名嫌疑人已死亡，已切换到剩余嫌疑人继续处置。");
                        return;
                    }
                }
            }
            catch { }

            // 全部嫌疑人都已终态：统一结案（Dead 优先，其次 Escaped，最后 Failed）
            EndReason finalReason = EndReason.Failed;
            try
            {
                if (HasAnyDeadSuspect()) finalReason = EndReason.SuspectDead;
                else if (HasAnyEscapedSuspect()) finalReason = EndReason.Failed;
            }
            catch { }

            try { EndCase(finalReason); }
            catch (Exception ex) { ModLog.Error("[CaseManager] EndCase error after suspect dead: " + ex); }

            _readyForNewCase = true;
            _pendingSpawn = false;
            try { PublishTerminalAccessIfChanged(); } catch { }

            SmsNotification.Show("911调度", "案件结束", "嫌疑人终态已确认，请返回终端手动接收下一案。");
        }

        private void OnSuspectEscaped(EF.PoliceMod.Core.SuspectEscapedEvent e)
        {
            if (!_isOnDuty || !_caseActive) return;

            int escapedHandle = e.SuspectHandle;
            if (escapedHandle <= 0 || !IsHandleInCurrentCase(escapedHandle)) return;

            try { MarkEscaped(escapedHandle); } catch { }

            // 仍有未终态嫌疑人则继续；否则失败结案
            try
            {
                if (!AreAllCaseSuspectsResolved())
                {
                    if (TrySwitchToNextPrimary("Escaped"))
                    {
                        SmsNotification.Show("911调度", "更新", "一名嫌疑人逃脱，已切换到剩余嫌疑人继续处置。");
                        return;
                    }
                }
            }
            catch { }

            try { EndCase(EndReason.Failed); } catch { }
            _readyForNewCase = true;
            _pendingSpawn = false;
            try { PublishTerminalAccessIfChanged(); } catch { }
            SmsNotification.Show("911调度", "案件结束", "存在嫌疑人逃脱，本案按失败结案。请返回终端接下一案。");
        }


        public void OnTick()
        {
            Ped player = Game.Player.Character;

            // ===== 1️⃣ 玩家死亡 → 案件失败 =====
            if (_isOnDuty && _caseActive && (!player.Exists() || player.IsDead))
            {
              
                EndCase(EndReason.Failed);
                return;
            }

            // ===== 2️⃣ 案件超时 → Timeout（⭐你加的逻辑，位置修正）=====
            if (_isOnDuty && _caseActive)
            {
                int elapsed = Game.GameTime - _caseStartTime;
                if (elapsed > MaxCaseDurationMs)
                {
                
                    EndCase(EndReason.Timeout);
                    return;
                }
            }

            // ===== 3️⃣ 嫌疑人死亡/消失兜底 =====
            if (_isOnDuty && _caseActive && _lastKnownSuspect != null)
            {
                // 0) 正常存在：持续刷新“最后已知位置”；并基于【未锁定时长】/【距离】判定是否进入“丢失”
                if (_lastKnownSuspect.Exists() && !_lastKnownSuspect.IsDead)
                {
                    int now = Game.GameTime;

                    try { _suspectLastKnownPos = _lastKnownSuspect.Position; } catch { }
                    _suspectLastKnownAtMs = now;
                    try { _lastKnownSuspectHandle = _lastKnownSuspect.Handle; } catch { }



                    float dist = 99999f;
                    try { dist = player.Position.DistanceTo(_suspectLastKnownPos); } catch { dist = 99999f; }

                    bool shouldLose = false;
                    if (dist >= LostIfFartherThan && now > _suspectRecoverAtMs) shouldLose = true;

                    if (!_suspectLost && shouldLose)
                    {
                        TryEnterSuspectLostState();
                    }

                    if (_suspectLost && dist <= RecoverIfCloserThan)
                    {
                        _suspectRecoverAtMs = now + 5000;
                        try { MarkSuspectFound(_lastKnownSuspect, _suspectLastKnownPos); } catch { }
                        SmsNotification.Show("911调度", "目标已重新发现", "已恢复嫌疑人精确标记（红点）。");
                    }
                }

                // 1) 真死亡：按原逻辑结案
                if (_lastKnownSuspect.Exists() && _lastKnownSuspect.IsDead)
                {
                    int handle = _lastKnownSuspect.Handle;
                    OnSuspectDead(new SuspectDeadEvent(handle));
                    return;
                }

                // 2) 消失（被流式卸载/距离太远刷没）：进入“最后已知位置”搜索圈，不直接判死
                if (!_lastKnownSuspect.Exists())
                {
                    // 兜底：记录最后一次能读到的位置
                    _suspectLastKnownAtMs = Game.GameTime;

                    TryEnterSuspectLostState();
                    return;
                }
            }

            // ===== 3.5️⃣ 副嫌疑人（阶段A）tick：刷新最后位置/简单丢失恢复 =====
            try { TickSecondarySuspect(); } catch { }


            // ===== 4️⃣ 延迟生成新案件 =====
            if (_isOnDuty && _pendingSpawn && Game.GameTime >= _spawnDelayEndTime)
            {
                ModLog.Info("[CaseManager] Auto-starting new case (pendingSpawn triggered)");
                _pendingSpawn = false;
                StartCase();     // ✅【唯一正确入口】

            }
        }
        // 终端接警参数（只对"本次 StartCase"生效，用完即清）
        private bool _useTerminalPreset = false;
        private int _terminalOptionId = -1;
        private int _terminalStars = 0;
        private bool _forceDualSuspects = false;

        public CaseManager()
        {
            EventBus.Subscribe<EF.PoliceMod.Core.SuspectDeliveredEvent>(OnSuspectDelivered);
            EventBus.Subscribe<SuspectDeadEvent>(OnSuspectDead);
            EventBus.Subscribe<EF.PoliceMod.Core.SuspectEscapedEvent>(OnSuspectEscaped);
            EventBus.Subscribe<SuspectResistingEvent>(_ =>
            {
                _suspectWasResisting = true;
            });

            // ★ 执勤生命周期事件
            EventBus.Subscribe<DutyStartedEvent>(OnDutyStarted);
            EventBus.Subscribe<DutyEndedEvent>(OnDutyEnded);
            EventBus.Subscribe<EF.PoliceMod.Core.SuspectBoardedVehicleEvent>(OnSuspectBoarded);
            EventBus.Subscribe<EF.PoliceMod.Core.WantedTargetSelectedEvent>(OnWantedSelected);
            EventBus.Subscribe<EF.PoliceMod.Core.TerminalCaseSelectedEvent>(OnTerminalCaseSelected);
        }
        private void OnTerminalCaseSelected(EF.PoliceMod.Core.TerminalCaseSelectedEvent e)
        {
            if (!_isOnDuty || _caseActive) return;

            int optionId = e.OptionId;
            int stars = e.Stars;

            bool forceDualSuspects = false;

            if (optionId >= 10 && optionId <= 15)
            {
                forceDualSuspects = true;
                optionId = optionId - 10;
                ModLog.Info($"[CaseManager] Dual suspect case selected, base optionId={optionId}");
            }

            if (optionId < 0 || optionId > 5)
                return;

            _caseMode = (optionId >= 3) ? CaseMode.VehicleFlee : CaseMode.OnFoot;
            _forcedSuspectHandle = -1;

            _useTerminalPreset = true;
            _terminalOptionId = optionId;
            _terminalStars = Math.Max(1, Math.Min(5, stars));
            _forceDualSuspects = forceDualSuspects;

            if (forceDualSuspects)
            {
                _terminalStars = Math.Max(4, _terminalStars);
            }

            ModLog.Info($"[CaseManager] Terminal preset applied: optionId={_terminalOptionId}, stars={_terminalStars}, forceDual={_forceDualSuspects}");


            StartCase();

        }

        private void OnWantedSelected(EF.PoliceMod.Core.WantedTargetSelectedEvent e)
        {
            if (!_isOnDuty || _caseActive) return;

            int requested = e.PedHandle;
            int resolvedHandle = -1;

            if (requested > 0)
            {
                try
                {
                    // 在世界里查找对应 handle，且必须不是玩家
                    var found = World.GetAllPeds().FirstOrDefault(p => p != null && p.Exists() && p.Handle == requested && p.Handle != Game.Player.Handle);
                    if (found != null && found.Exists())
                    {
                        resolvedHandle = found.Handle;
                        ModLog.Info($"[CaseManager] OnWantedSelected -> resolved existing ped handle={resolvedHandle}");
                    }
                    else
                    {
                        ModLog.Warn($"[CaseManager] OnWantedSelected -> requested handle {requested} invalid or refers to player; will spawn new suspect");
                    }
                }
                catch (Exception ex)
                {
                    ModLog.Error("[CaseManager] OnWantedSelected resolve error: " + ex);
                }
            }
            else
            {
                ModLog.Info("[CaseManager] OnWantedSelected -> no existing ped requested, will spawn new suspect");
            }

            _forcedSuspectHandle = resolvedHandle; // -1 表示随机生成
            StartCase();
        }

        private void OnSuspectBoarded(EF.PoliceMod.Core.SuspectBoardedVehicleEvent e)
        {
            try
            {
                int suspectHandle = e.SuspectHandle;
                Ped suspect = null;
                if (suspectHandle > 0)
                {
                    try
                    {
       
                        try
                        {
                            var found = World.GetAllPeds().FirstOrDefault(p => p != null && p.Exists() && p.Handle == suspectHandle);
                            if (found != null && found.Exists()) suspect = found;
                            else suspect = null;
                        }
                        catch
                        {
                            suspect = null;
                        }

                    }
                    catch { suspect = null; }
                }

                // 删除旧 blip
                if (_deliveryRouteBlip != null)
                {
                    try { _deliveryRouteBlip.ShowRoute = false; _deliveryRouteBlip.Delete(); } catch { }
                    _deliveryRouteBlip = null;
                }

                // 创建新 blip 并尝试显示路线
                _deliveryRouteBlip = World.CreateBlip(_policeStationPos);
                _deliveryRouteBlip.Sprite = BlipSprite.PoliceStation;
                _deliveryRouteBlip.Color = BlipColor.Blue;
                _deliveryRouteBlip.IsShortRange = false;
                _deliveryRouteBlip.Name = "交付地点：警局";

                bool routeSet = false;
                try
                {
                    _deliveryRouteBlip.ShowRoute = true;
                    routeSet = true;
                }
                catch { }

                // 兜底 waypoint
                try
                {
                    Function.Call(Hash.SET_NEW_WAYPOINT, _policeStationPos.X, _policeStationPos.Y);
                }
                catch { }

                _lastRouteCreatedAt = Game.GameTime;
                _lastRouteSuspectHandle = suspectHandle;

                SmsNotification.Show("911调度", "押送指令", "嫌疑人已上车，导航已设置：返回警局交付");
                ModLog.Info("[CaseManager] Delivery route set (suspect=" + suspectHandle + ")");
            }
            catch (Exception ex)
            {
                ModLog.Error("[CaseManager] OnSuspectBoarded error: " + ex);
            }
        }


        // 生成/复用后先做一次“外观/任务/手铐状态净身”，避免继承旧 ped 的姿态（被拷、跟随等）。

        // 这是针对你反馈的：交付结束后，下一个嫌疑人未接触就背手被拷并跟随的问题。
        private void ResetSuspectVisualState(Ped suspect)
        {
            if (suspect == null || !suspect.Exists()) return;
            if (suspect.IsDead) return;

            try { Function.Call(Hash.CLEAR_PED_TASKS_IMMEDIATELY, suspect.Handle); } catch { }
            try { Function.Call(Hash.CLEAR_PED_SECONDARY_TASK, suspect.Handle); } catch { }
            try { Function.Call(Hash.CLEAR_PED_TASKS, suspect.Handle); } catch { }

            // 解除手铐/绑腿（新案嫌疑人不应默认被拷）
            try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, false); } catch { }
            try { Function.Call(Hash.SET_ENABLE_BOUND_ANKLES, suspect.Handle, false); } catch { }

            // 清理姿态/步态
            try { Function.Call(Hash.RESET_PED_MOVEMENT_CLIPSET, suspect.Handle, 0.25f); } catch { }
            try { Function.Call(Hash.RESET_PED_STRAFE_CLIPSET, suspect.Handle); } catch { }
            try { Function.Call(Hash.CLEAR_PED_SECONDARY_TASK, suspect.Handle); } catch { }

            // 确保是“可控实体”
            try { Function.Call(Hash.FREEZE_ENTITY_POSITION, suspect.Handle, false); } catch { }
            try { Function.Call(Hash.SET_ENTITY_COLLISION, suspect.Handle, true, true); } catch { }
        }


        // 取消导航（公用）
        private void ClearDeliveryRoute()
        {
            // 删除 route blip
            if (_deliveryRouteBlip != null)
            {
                try { _deliveryRouteBlip.ShowRoute = false; _deliveryRouteBlip.Delete(); } catch { }
                _deliveryRouteBlip = null;
            }

            // 清除 waypoint（导航残留的根源）
            try { Function.Call(Hash.SET_WAYPOINT_OFF); } catch { }
            try { Function.Call(Hash.CLEAR_GPS_PLAYER_WAYPOINT); } catch { }
        }
        // 处理实际的 boarded 事件（创建路由，兜底 waypoint，防抖已在 OnSuspectBoarded 中处理）
        private void ProcessSuspectBoardedEvent(EF.PoliceMod.Core.SuspectBoardedVehicleEvent e)
        {
            try
            {
                int now = Game.GameTime;
                int suspectHandle = (e.SuspectHandle > 0) ? e.SuspectHandle : -1;

                // （如果你后面还需要 Ped 实例，可按需解析：）
                // Ped suspect = null;
                // if (suspectHandle > 0) {
                //     try {
                //         suspect = World.GetAllPeds().FirstOrDefault(p => p != null && p.Exists() && p.Handle == suspectHandle);
                //     } catch { suspect = null; }
                // }


                // 删除旧 blip（如果有）
                if (_deliveryRouteBlip != null)
                {
                    try { _deliveryRouteBlip.ShowRoute = false; _deliveryRouteBlip.Delete(); } catch { }
                    _deliveryRouteBlip = null;
                }

                ModLog.Info("[CaseManager] Processing SuspectBoarded -> creating delivery route to station (suspect=" + suspectHandle + ")");

                // 创建目标 blip
                _deliveryRouteBlip = World.CreateBlip(_policeStationPos);
                _deliveryRouteBlip.Sprite = BlipSprite.PoliceStation;
                _deliveryRouteBlip.Color = BlipColor.Blue;
                _deliveryRouteBlip.IsShortRange = false;
                _deliveryRouteBlip.Name = "交付地点：警局";

                bool routeSet = false;
                try
                {
                    _deliveryRouteBlip.ShowRoute = true;
                    routeSet = true;
                    ModLog.Info("[CaseManager] Delivery blip created and ShowRoute=true");
                }
                catch (Exception ex)
                {
                    ModLog.Warn("[CaseManager] ShowRoute failed: " + ex);
                }

                // 兜底 waypoint
                try
                {
                    Function.Call(Hash.SET_NEW_WAYPOINT, _policeStationPos.X, _policeStationPos.Y);
                    if (!routeSet) ModLog.Info("[CaseManager] Fallback: SET_NEW_WAYPOINT called");
                }
                catch (Exception ex)
                {
                    ModLog.Warn("[CaseManager] SET_NEW_WAYPOINT failed: " + ex);
                }

                // 记录时间/handle（如果你有防抖字段）
                _lastRouteCreatedAt = Game.GameTime;
                _lastRouteSuspectHandle = suspectHandle;

                SmsNotification.Show("911调度", "押送指令", "嫌疑人已上车，导航已设置：返回警局交付");
            }
            catch (Exception ex)
            {
                ModLog.Error("[CaseManager] ProcessSuspectBoardedEvent error: " + ex);
            }
        }

        private void SpawnSuspect(SuspectProfile profile)
        {
            Ped player = Game.Player.Character;
            if (!player.Exists())
                return;


            // 终端预设只对本次 StartCase 生效：确保 SpawnSuspect 使用的是最新选择，而不是被后续代码误清
            ModLog.Info($"[CaseManager] SpawnSuspect enter: useTerminal={_useTerminalPreset}, optionId={_terminalOptionId}, stars={_terminalStars}, forceDual={_forceDualSuspects}");



            // 1️⃣ 找生成点
            // 以玩家当前位置为种子，避免“接案后嫌疑人刷在几公里外导致看不到模型/立即丢失”
            Vector3 spawnSeed = player.Position;

            // 终端“偏远/郊区/市区”生成距离：把嫌疑人刷远一点，避免太近无聊
            float spawnRadius = 220f;
            try
            {
                int region = (_terminalOptionId >= 0 && _terminalOptionId <= 5) ? (_terminalOptionId % 3) : 0;
                if (region == 0) spawnRadius = 120f;      // 市区：尽量就近，不要开局就丢失
                else if (region == 1) spawnRadius = 220f; // 郊区
                else spawnRadius = 320f;                  // 偏远
            }
            catch { spawnRadius = 220f; }

            Vector3 spawnPos = World.GetNextPositionOnStreet(
                spawnSeed.Around(spawnRadius)
            );

            // 尝试使用玩家通过终端选中的 ped（如果有且有效），否则创建随机 Ped
            if (_forcedSuspectHandle > 0)
            {
                try
                {
                    var found = World.GetAllPeds().FirstOrDefault(p => p != null && p.Exists() && p.Handle == _forcedSuspectHandle);
                    if (found != null && found.Exists())
                    {
                        if (found.Handle == Game.Player.Handle)
                        {
                            ModLog.Warn("[CaseManager] SpawnSuspect - resolved ped is the player! Ignoring and spawning new suspect.");
                        }
                        else
                        {
                            _suspect = found;
                            ModLog.Info("[CaseManager] SpawnSuspect - using existing ped handle=" + _suspect.Handle);
                        }
                    }
                    else
                    {
                        ModLog.Info("[CaseManager] SpawnSuspect - forced handle not found in world, spawning new ped");
                    }
                }
                catch (Exception ex)
                {
                    ModLog.Error("[CaseManager] SpawnSuspect - resolving forced handle error: " + ex);
                }
            }

            // 回退：找不到就随机生成
            if (_suspect == null || !_suspect.Exists())
            {
                _suspect = World.CreateRandomPed(spawnPos);
                ModLog.Info("[CaseManager] SpawnSuspect - CreatedRandomPed -> handle=" + (_suspect?.Handle.ToString() ?? "null"));
            }

            if (_suspect == null || !_suspect.Exists())
                return;

            // ✅ 终端预设需要贯穿本次 SpawnSuspect；如果被外部逻辑误清，这里直接强制恢复
            // 目标：终端选了双人（optionId 10~15）必须稳定出第二嫌疑人
            if (_terminalStars <= 0) _terminalStars = 1;
            if (_terminalOptionId < 0) _terminalOptionId = 0;
            // 终端双人模板兜底：万一 forceDual 被误清（你日志里就是这种“被清空”现象），这里强制恢复
            // 规则：终端双人模板 optionId=10..15 会在 OnTerminalCaseSelected 映射回 0..5，
            // 所以这里用“stars>=4 且来自终端预设”作为兜底双人开关（可验收优先）。
            if (_useTerminalPreset && _terminalStars >= 4)
                _forceDualSuspects = true;



            EntityTracker.Instance.Register(_suspect, "case_suspect", "CaseManager");


            // 清空强制句柄（只用一次）
            _forcedSuspectHandle = -1;

            // 生成/复用后先做一次“外观状态重置”，避免继承旧的手铐/步态/动画。
            try { ResetSuspectVisualState(_suspect); } catch { }

            // 3️⃣ 应用性格（唯一入口）
            ModLog.Info($"[CaseManager] SpawnSuspect -> profile: Personality={profile.Personality}, HasFirearm={profile.HasFirearm}, ResistChance={profile.ResistChance}");
            var sc = EFCore.Instance
             .GetSuspectController();
            sc?.ApplyProfile(_suspect, profile);

            // ★ 同步当前嫌疑人：用于 PullOverSystem（I 逼停）等系统不必先 L 锁定
            try { sc?.TakeControl(_suspect); } catch { }

            // 4️⃣ 注册给锁定系统
            EFCore.Instance.LockTargetSystem.RegisterSuspect(_suspect);

            // 双嫌疑人模式下：日志打印主嫌疑人注册后的关键信息。
            try { ModLog.Info($"[CaseManager] After primary RegisterSuspect: handlesCount={_suspectHandles.Count}, forceDual={_forceDualSuspects}, stars={_terminalStars}, useTerminal={_useTerminalPreset}"); } catch { }




            // ===== 双嫌疑人（阶段A）：按终端星级概率生成第二名嫌疑人 =====
            // 规则：stars>=4 有概率双人；stars>=5 必定双人；双人案件选项强制双人
            ModLog.Info($"[CaseManager] Dual suspect check: _useTerminalPreset={_useTerminalPreset}, _terminalStars={_terminalStars}");
            try
            {
                _suspectHandles.Clear();
                if (_suspect != null && _suspect.Exists()) _suspectHandles.Add(_suspect.Handle);
                _primarySuspectIndex = 0;
                RegisterCaseSuspect(_suspect, 0, true);


                bool wantTwo = false;
                // 终端双人模板：强制双人（稳定、可验收）
                if (_forceDualSuspects)
                {
                    wantTwo = true;
                }
                // 非双人模板：仍保留“高星概率双人”
                else if (_useTerminalPreset)
                {
                    if (_terminalStars >= 5) wantTwo = true;
                    else if (_terminalStars >= 4) wantTwo = true; // 原先 50% 改为必出，便于测试/体验
                }


                ModLog.Info($"[CaseManager] Dual suspect: wantTwo={wantTwo}, forceDual={_forceDualSuspects}");

                if (wantTwo)
                {
                    Ped s2 = null;
                    for (int i = 0; i < 4 && (s2 == null || !s2.Exists()); i++)
                    {
                        try
                        {
                            Vector3 seed = (i == 0) ? spawnPos.Around(12f) : spawnPos.Around(12f + i * 8f);
                            Vector3 s2PosTry = World.GetNextPositionOnStreet(seed);
                            s2 = World.CreateRandomPed(s2PosTry);
                        }
                        catch
                        {
                            s2 = null;
                        }
                    }

                    if (s2 != null && s2.Exists())
                    {
                        try
                        {
                            // 强制把副嫌疑人拉到主嫌疑人附近可见范围，避免“地图有红点但看不到模型”
                            Vector3 nearPrimary = _suspect.Position.Around(8f);
                            Vector3 nearRoad = World.GetNextPositionOnStreet(nearPrimary);
                            if (nearRoad != Vector3.Zero)
                            {
                                s2.Position = nearRoad;
                            }
                            else
                            {
                                s2.Position = _suspect.Position.Around(6f);
                            }
                        }
                        catch { }

                        Vector3 s2Pos = s2.Position;
                        EntityTracker.Instance.Register(s2, "case_suspect_2", "CaseManager");

                        try { ResetSuspectVisualState(s2); } catch { }
                        try { sc?.ApplyProfile(s2, profile); } catch { }
                        try { s2.IsPersistent = true; } catch { }
                        try { s2.BlockPermanentEvents = true; } catch { }

                        _suspectHandles.Add(s2.Handle);
                        RegisterCaseSuspect(s2, 1, false);
                        _secondaryLastKnownPos = s2Pos;
                        _secondaryLost = false;

                        try
                        {
                            if (_secondarySuspectBlip != null) { try { _secondarySuspectBlip.Delete(); } catch { } _secondarySuspectBlip = null; }
                            _secondarySuspectBlip = s2.AddBlip();
                            _secondarySuspectBlip.Color = BlipColor.Red;
                            _secondarySuspectBlip.IsShortRange = false;
                            _secondarySuspectBlip.Name = "嫌疑人(2)";
                        }
                        catch { }

                        _secondarySuspect = s2;

                        ModLog.Info($"[CaseManager] Second suspect spawned: handle={s2.Handle}, total suspects={_suspectHandles.Count}");
                        SmsNotification.Show("911调度", "更新", "~o~多名嫌疑人~s~：本案为双人案件（2名嫌疑人）。主嫌疑人已标记为红点，2号嫌疑人标记为“嫌疑人(2)”。");
                    }
                    else
                    {
                        ModLog.Warn("[CaseManager] Dual suspect requested but second suspect spawn failed after retries");
                        SmsNotification.Show("911调度", "更新", "~y~双人案件补员失败：已保留主嫌疑人，建议刷新后重试。");
                    }

                }

                try { EventBus.Publish(new EF.PoliceMod.Core.SuspectHandleListChangedEvent(_suspectHandles)); } catch { }
            }
            catch (Exception ex)
            {
                ModLog.Error("[CaseManager] Dual suspect spawn failed: " + ex);
            }

            // 5️⃣ 基础行为
            _suspect.IsPersistent = true;
            _suspect.BlockPermanentEvents = true;

            // 新案生成保护期：避免刚开局就因距离判定进入 LOST（导致必须立刻直升机勘探）
            _suspectRecoverAtMs = Game.GameTime + 45000;

            Vehicle caseVehicle = null;

            if (_caseMode == CaseMode.VehicleFlee)
            {
                try
                {
                    Vector3 vehPos;
                    try { vehPos = World.GetNextPositionOnStreet(spawnPos.Around(8f)); }
                    catch { vehPos = spawnPos; }

                    try
                    {
                        VehicleHash[] pool = new VehicleHash[]
                        {
                            VehicleHash.Primo,
                            VehicleHash.Asea,
                            VehicleHash.Sultan,
                            VehicleHash.Blista,
                            VehicleHash.Futo,
                            VehicleHash.Prairie,
                            VehicleHash.Ingot,
                            VehicleHash.Adder,
                        };
                        var r = new Random(Game.GameTime + _suspect.Handle);
                        var pick = pool[r.Next(pool.Length)];
                        caseVehicle = World.CreateVehicle(pick, vehPos);
                    }
                    catch { caseVehicle = null; }

                    if (caseVehicle != null && caseVehicle.Exists())
                    {
                        try { _suspect.SetIntoVehicle(caseVehicle, VehicleSeat.Driver); } catch { }

                        if (_secondarySuspect != null && _secondarySuspect.Exists())
                        {
                            try
                            {
                                _secondarySuspect.SetIntoVehicle(caseVehicle, VehicleSeat.Passenger);
                                ModLog.Info($"[CaseManager] Second suspect set as passenger: handle={_secondarySuspect.Handle}");
                            }
                            catch { }
                        }

                        try
                        {
                            Function.Call(Hash.TASK_VEHICLE_DRIVE_WANDER, _suspect.Handle, caseVehicle.Handle, 22.0f, 786468);
                        }
                        catch { }

                        ModLog.Info($"[CaseManager] VehicleFlee case: suspect={_suspect.Handle} veh={caseVehicle.Handle}");
                    }
                    else
                    {
                        _suspect.Task.WanderAround();
                        if (_secondarySuspect != null && _secondarySuspect.Exists())
                        {
                            try { _secondarySuspect.Task.WanderAround(_secondarySuspect.Position, 20f); } catch { }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ModLog.Error("[CaseManager] VehicleFlee spawn error: " + ex);
                    try { _suspect.Task.WanderAround(); } catch { }
                }
            }
            else
            {
                _suspect.Task.WanderAround();
                if (_secondarySuspect != null && _secondarySuspect.Exists())
                {
                    try { _secondarySuspect.Task.WanderAround(_secondarySuspect.Position, 20f); } catch { }
                }
            }

            // 记录“最后已知位置”
            try { _suspectLastKnownPos = _suspect.Position; } catch { _suspectLastKnownPos = spawnPos; }
            _suspectLastKnownAtMs = Game.GameTime;
            _suspectLost = false;

            // 6️⃣ 地图红点（主嫌疑人）
            _suspectBlip = _suspect.AddBlip();
            _suspectBlip.Sprite = BlipSprite.Standard;
            _suspectBlip.Color = BlipColor.Red;
            _suspectBlip.Scale = 0.9f;
            _suspectBlip.Name = "嫌疑人(1)";


            // 若之前存在搜索圈，清掉
            try { ClearSuspectSearchArea(); } catch { }

            _caseActive = true;
            _lastKnownSuspect = _suspect;
            try { _lastKnownSuspectHandle = _suspect.Handle; } catch { }

            Notification.Show("~r~新案件：发现可疑人员");

            // 双人案件：在主红点创建后，再兜底给 2 号嫌疑人补一次 blip（防止前面 AddBlip 静默失败）
            try
            {
                if (_secondarySuspect != null && _secondarySuspect.Exists())
                {
                    if (_secondarySuspectBlip == null || !_secondarySuspectBlip.Exists())
                    {
                        _secondarySuspectBlip = _secondarySuspect.AddBlip();
                        _secondarySuspectBlip.Color = BlipColor.Red;
                        _secondarySuspectBlip.IsShortRange = false;
                        _secondarySuspectBlip.Name = "嫌疑人(2)";
                        ModLog.Info("[CaseManager] Secondary blip fallback created");
                    }
                }
            }
            catch { }
        }

        private void ClearSuspectSearchArea()
        {
            if (_suspectSearchAreaBlip != null)
            {
                try { if (_suspectSearchAreaBlip.Exists()) _suspectSearchAreaBlip.Delete(); } catch { }
            }
            _suspectSearchAreaBlip = null;
            _suspectLost = false;
        }
        public void MarkSuspectFound(Ped suspect, Vector3 pos)
        {
            try { _suspectLastKnownPos = pos; } catch { }
            _suspectLastKnownAtMs = Game.GameTime;
            _suspectRecoverAtMs = Game.GameTime + 5000;
            _suspectLost = false;

            _lastKnownSuspect = suspect;
            _suspect = suspect;
            try { _lastKnownSuspectHandle = (suspect != null && suspect.Exists()) ? suspect.Handle : _lastKnownSuspectHandle; } catch { }

            try { ClearSuspectSearchArea(); } catch { }

            try
            {
                if (_suspectBlip != null && _suspectBlip.Exists()) _suspectBlip.Delete();
            }
            catch { }
            _suspectBlip = null;

            try
            {
                if (suspect != null && suspect.Exists())
                {
                    _suspectBlip = suspect.AddBlip();
                    _suspectBlip.Sprite = BlipSprite.Standard;
                    _suspectBlip.Color = BlipColor.Red;
                    _suspectBlip.Scale = 0.9f;
                    _suspectBlip.Name = "嫌疑人";
                }
            }
            catch { }

            ModLog.Info($"[CaseManager] MarkSuspectFound: handle={suspect?.Handle}, pos={pos}, recoverProtectUntil={_suspectRecoverAtMs}");
        }


        private void TryEnterSuspectLostState()
        {
            if (_suspectLost) return;
            _suspectLost = true;

            try { PublishCaseStatusIfChanged(); } catch { }

            try
            {
                if (_suspectBlip != null && _suspectBlip.Exists()) _suspectBlip.Delete();
            }
            catch { }
            _suspectBlip = null;

            // 创建“范围圈”（红色半透明）
            try
            {
                // 半径可后续按星级/风险调整
                float radius = 140f;
                _suspectSearchAreaBlip = World.CreateBlip(_suspectLastKnownPos, radius);
                _suspectSearchAreaBlip.Color = BlipColor.Red;
                _suspectSearchAreaBlip.Alpha = 80;
                _suspectSearchAreaBlip.IsShortRange = false;
                _suspectSearchAreaBlip.Name = "嫌疑人可能位置";
            }
            catch { }

            SmsNotification.Show("911调度", "目标丢失", "嫌疑人已脱离视野：已在地图标注大致范围（红色圈）。可在调度菜单呼叫侦察支援。");
            ModLog.Warn("[CaseManager] Suspect lost -> search area blip created");
        }

        private void TickSecondarySuspect()
        {
            try
            {
                if (!_isOnDuty || !_caseActive) return;
                if (_suspectHandles == null || _suspectHandles.Count < 2) return;

                int handle2 = _suspectHandles[1];
                if (handle2 <= 0) return;

                var player = Game.Player.Character;
                if (player == null || !player.Exists()) return;

                // 找到 ped
                Ped s2 = null;
                try { s2 = World.GetAllPeds().FirstOrDefault(p => p != null && p.Exists() && p.Handle == handle2); } catch { s2 = null; }
                if (s2 == null || !s2.Exists()) return;

                try { _secondaryLastKnownPos = s2.Position; } catch { }

                float dist = 99999f;
                try { dist = player.Position.DistanceTo(_secondaryLastKnownPos); } catch { dist = 99999f; }

                if (!_secondaryLost && dist >= LostIfFartherThan)
                {
                    _secondaryLost = true;
                    // 简化：仅隐藏红点（阶段A 不创建搜索圈，避免 UI 干扰；后续可扩展）
                    try { if (_secondarySuspectBlip != null && _secondarySuspectBlip.Exists()) _secondarySuspectBlip.Delete(); } catch { }
                    _secondarySuspectBlip = null;
                }

                if (_secondaryLost && dist <= RecoverIfCloserThan)
                {
                    _secondaryLost = false;
                    try
                    {
                        if (_secondarySuspectBlip != null) { try { _secondarySuspectBlip.Delete(); } catch { } _secondarySuspectBlip = null; }
                        _secondarySuspectBlip = s2.AddBlip();
                        _secondarySuspectBlip.Color = BlipColor.Red;
                        _secondarySuspectBlip.IsShortRange = false;
                        _secondarySuspectBlip.Name = "嫌疑人(2)";
                    }
                    catch { }
                }
            }
            catch { }
        }

        private bool TrySwitchToNextPrimary(string reason)
        {
            try
            {
                if (_suspectHandles == null || _suspectHandles.Count < 2) return false;
                if (_primarySuspectIndex != 0) return false; // 只支持从 0 切到 1（阶段A）

                int nextHandle = _suspectHandles[1];
                if (nextHandle <= 0) return false;

                Ped nextPed = null;
                try { nextPed = World.GetAllPeds().FirstOrDefault(p => p != null && p.Exists() && p.Handle == nextHandle); } catch { nextPed = null; }
                if (nextPed == null || !nextPed.Exists()) return false;

                // 提升为 primary
                _primarySuspectIndex = 1;
                PromotePrimaryHandle(nextHandle);
                _suspect = nextPed;
                _lastKnownSuspect = nextPed;
                try { _lastKnownSuspectHandle = nextPed.Handle; } catch { }

                // 同步 lastKnown/lost 到 primary 的字段（保证侦察/丢失圈/红点都围绕 primary 运转）
                _suspectLastKnownPos = _secondaryLastKnownPos;
                _suspectLost = _secondaryLost;
                _secondaryLost = false;

                // 切换 blip：删除 secondary 的红点，用 primary 的红点/搜索圈显示
                try { if (_secondarySuspectBlip != null && _secondarySuspectBlip.Exists()) _secondarySuspectBlip.Delete(); } catch { }
                _secondarySuspectBlip = null;

                try
                {
                    if (_suspectBlip != null && _suspectBlip.Exists()) _suspectBlip.Delete();
                }
                catch { }
                _suspectBlip = null;

                try { ClearSuspectSearchArea(); } catch { }

                try
                {
                    if (!_suspectLost)
                    {
                        _suspectBlip = nextPed.AddBlip();
                        _suspectBlip.Sprite = BlipSprite.Standard;
                        _suspectBlip.Color = BlipColor.Red;
                        _suspectBlip.Scale = 0.9f;
                        _suspectBlip.Name = "嫌疑人";
                    }
                    else
                    {
                        TryEnterSuspectLostState();
                    }
                }
                catch { }

                // 复用现有单嫌疑人链路：TakeControl + RegisterSuspect
                try
                {
                    var sc = EFCore.Instance?.GetSuspectController();
                    sc?.TakeControl(nextPed);
                }
                catch { }

                try
                {
                    EFCore.Instance?.LockTargetSystem?.RegisterSuspect(nextPed);
                }
                catch { }

                // 广播列表变更（有系统想更新 UI 时用）
                try { EventBus.Publish(new EF.PoliceMod.Core.SuspectHandleListChangedEvent(_suspectHandles)); } catch { }

                ModLog.Info("[CaseManager] Switched primary suspect to index=1 due to " + reason);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void RegisterCaseSuspect(Ped ped, int slotIndex, bool isPrimary)
        {
            if (ped == null || !ped.Exists()) return;
            try
            {
                _caseSuspects.RemoveAll(x => x == null || x.Handle == ped.Handle);
                _caseSuspects.Add(new EF.PoliceMod.Core.CaseSuspect
                {
                    Handle = ped.Handle,
                    SlotIndex = slotIndex,
                    IsPrimary = isPrimary,
                    Status = EF.PoliceMod.Core.CaseSuspectStatus.Active,
                    LastKnownPos = ped.Position
                });
            }
            catch { }
        }

        private void PromotePrimaryHandle(int handle)
        {
            if (handle <= 0) return;
            try
            {
                foreach (var s in _caseSuspects)
                {
                    if (s == null) continue;
                    s.IsPrimary = (s.Handle == handle);
                }
            }
            catch { }
        }

        private void CleanupCase()
        {
            bool hadActiveCase = _caseActive || _suspect != null || (_suspectHandles != null && _suspectHandles.Count > 0);
            if (hadActiveCase)
            {
                EventBus.Publish(new CaseEndedEvent());
            }

            _caseActive = false;

            try { PublishCaseStatusIfChanged(); } catch { }
            try { PublishTerminalAccessIfChanged(); } catch { }

            if (_suspectBlip != null && _suspectBlip.Exists())
                _suspectBlip.Delete();
            try { ClearSuspectSearchArea(); } catch { }

            try
            {
                if (_secondarySuspectBlip != null && _secondarySuspectBlip.Exists()) _secondarySuspectBlip.Delete();
            }
            catch { }
            _secondarySuspectBlip = null;
            _secondarySuspect = null;
            _secondaryLost = false;

            if (_suspect != null && _suspect.Exists())
            {
                try { ResetSuspectVisualState(_suspect); } catch { }
                EntityTracker.Instance.CleanupEntity(_suspect.Handle);
            }

            try
            {
                if (_suspectHandles != null)
                {
                    foreach (var h in _suspectHandles)
                    {
                        if (h > 0 && (_suspect == null || h != _suspect.Handle))
                        {
                            EntityTracker.Instance.CleanupEntity(h);
                        }
                    }
                }
            }
            catch { }

            try { _suspectHandles.Clear(); } catch { }
            try { _caseSuspects.Clear(); } catch { }
            _primarySuspectIndex = 0;

            _suspectBlip = null;
            _suspect = null;
            _caseActive = false;
            _lastKnownSuspect = null;
            _lastKnownSuspectHandle = -1;
        }
    }
}
