using EF.PoliceMod.Core;
using EF.PoliceMod.Core.Contracts;
using EF.PoliceMod.Core.Contracts.Snapshots;
using EF.PoliceMod.Executors;
using EF.PoliceMod.Input;
using EFPoliceMod;
using GTA;
using GTA.Math;
using GTA.Native;
using GTA.UI;
using System;
using System.Drawing;
using System.Collections.Generic;

namespace EF.PoliceMod.Gameplay
{
    public class SuspectController : ISuspectService
    {
        private Ped _currentSuspect;
        private bool _initialized = false;

        public EF.PoliceMod.Core.ArrestActionStyle CurrentArrestStyle { get; private set; } = EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead;

        private bool _wasShotByPlayer = false;

        private bool _deathEventFired = false;
        public bool IsCompliant { get; private set; } = false;
        public bool IsResisting { get; private set; } = false;

        private float _resistChance = 0f;
        private bool _hasFirearm = false;

        // 关闭“瞄准/拘捕时受惊逃跑”随机链路，避免案件流程被随机打断。
        private const bool DisableFrightenedEscapeOnArrest = true;

        // 只读暴露：供 PullOverSystem 等模块做“高危”判定
        public float ResistChance => _resistChance;
        public bool HasFirearm => _hasFirearm;

        // Aim debounce & busy tracking
        private Ped _potentialAimedTarget = null; // compatibility placeholder: 防止旧代码引用未声明导致编译错误

        private readonly HashSet<int> _busySuspects = new HashSet<int>(); // 存储正在被执行关键任务的 suspect handle
        private readonly HashSet<int> _compliantSuspects = new HashSet<int>();
        private readonly HashSet<int> _resistingSuspects = new HashSet<int>();
        private ArrestActionStyle _pendingArrestStyle = ArrestActionStyle.CuffAndLead;
        private bool _menuArrestContext = false;

        public struct SuspectCompliantEvent
{
    public Ped Suspect;
    public SuspectCompliantEvent(Ped suspect)
    {
        Suspect = suspect;
    }
}

        private static readonly Random _rand = new Random();

        public SuspectController()
        {
            EventBus.Subscribe<SuspectFollowRequestEvent>(OnFollowRequested);
            EventBus.Subscribe<EF.PoliceMod.Core.SuspectDeliveredEvent>(OnSuspectDelivered);
            EventBus.Subscribe<DutyEndedEvent>(OnDutyEnded);
            EventBus.Subscribe<CaseEndedEvent>(OnCaseEnded);
            // EventBus.Subscribe<EF.PoliceMod.Input.PlayerAimedAtPedEvent>(OnPlayerAimedAt); // TEMP 禁用
        }


        // 如果没有现成方法签名匹配的，新增一个适配方法：
        private void OnDutyEnded(DutyEndedEvent e)
        {
            ForceClear();
        }

        private void OnCaseEnded(CaseEndedEvent e)
        {
            ForceClear();
        }
        private void OnSuspectDelivered(EF.PoliceMod.Core.SuspectDeliveredEvent e)
        {
            OnSuspectDelivered(); // 调用原实现（如果你喜欢也可以直接把逻辑放进这里）
        }

        // OnPlayerAimedAt 已禁用：PlayerAimedAtPedEvent 不再携带 Ped，
        // 为避免编译错误与潜在运行时风险，这里保留空实现仅记录调用并直接返回。
        public void OnPlayerAimedAt(EF.PoliceMod.Input.PlayerAimedAtPedEvent evt)
        {
            try
            {
                // 记录一次调用以便调试（不会访问 evt 中不存在的字段）
                ModLog.Info("[SuspectController] OnPlayerAimedAt called but aim-driven logic disabled.");
            }
            catch (Exception ex)
            {
                // 兜底记录，绝不抛出
                ModLog.Error("[SuspectController] OnPlayerAimedAt (disabled) exception: " + ex);
            }

            return;
        }
        public void OnShotOrDamagedByPlayer()
        {
            // 标记为被击倒情况，等站起后做判断
            // 记录时间 / attacker info
            _wasShotByPlayer = true;
        }

        // 在嫌疑人站起（或复活）处：
        private void OnSuspectRecovered()
        {
            if (_wasShotByPlayer && !IsResisting)
            {
                // 如果没有抵抗记录，则设为合规并举手
                try
                {
                    if (_currentSuspect != null && _currentSuspect.Exists())
                    {
                        // 特性临时禁用：跳过 TASK_HANDS_UP 调用，避免潜在 native 崩溃
                        // Function.Call(Hash.TASK_HANDS_UP, _currentSuspect.Handle, 10000, Game.Player.Character.Handle, -1, 0);
                        // IsCompliant = true;
                        ModLog.Info("[SuspectController] OnSuspectRecovered: TASK_HANDS_UP disabled (feature flag).");

                        ModLog.Info("[SuspectController] Suspect recovered then set to compliant (was shot but did not resist)");
                    }
                }
                catch (Exception ex)
                {
                    ModLog.Error("[SuspectController] OnSuspectRecovered error: " + ex);
                }
            }
            _wasShotByPlayer = false;
        }

        public void ApplyProfile(
     Ped suspect,
     CaseManager.SuspectProfile profile
 )
        {
            if (suspect == null || !suspect.Exists())
                return;
            _hasFirearm = profile.HasFirearm;
            _resistChance = profile.ResistChance;

            // Debug: 记录 ApplyProfile 执行情况（便于确认是否赋枪）
            ModLog.Info($"[SuspectController] ApplyProfile -> ped={suspect.Handle}, Personality={profile.Personality}, HasFirearm={_hasFirearm}, ResistChance={_resistChance}");

            // ★ 清空原有武器，防止随机刷枪
            suspect.Weapons.RemoveAll();


            // ★ 根据性格配置武器

            switch (profile.Personality)
            {
                case CaseManager.SuspectPersonality.ArmedManiac:
                    suspect.Weapons.Give(
                        WeaponHash.PumpShotgun,
                        24,
                        true,
                        true
                    );

                    suspect.RelationshipGroup = Game.GenerateHash("HATES_PLAYER");

                    Ped player = Game.Player.Character;
                    if (player.Exists())
                    {
                        // 只配置属性，不下任何 Task
                    }
                    break;

                case CaseManager.SuspectPersonality.Violent:
                    if (_rand.Next(100) < 50)
                    {
                        suspect.Weapons.Give(WeaponHash.Machete, 1, true, true);
                    }
                    else
                    {
                        suspect.Weapons.Give(WeaponHash.Pistol, 36, true, true);
                    }
                    break;

                case CaseManager.SuspectPersonality.Civilian:
                default:
                    // 不带武器
                    break;
            }
        }


        private void OnSuspectDelivered()
        {

            if (_currentSuspect != null && _currentSuspect.Exists())
            {
                try { _compliantSuspects.Remove(_currentSuspect.Handle); } catch { }
                try { _resistingSuspects.Remove(_currentSuspect.Handle); } catch { }
                _currentSuspect = null;
            }

            // 交付/切案后必须复位，否则下一名嫌疑人可能继承上一名的“被拷姿态/跟随任务”
            try { CurrentArrestStyle = EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead; } catch { }
            try { IsCompliant = false; } catch { }
            try { IsResisting = false; } catch { }
            try { _wasShotByPlayer = false; } catch { }
            try { _deathEventFired = false; } catch { }
        }
        public Ped GetCurrentSuspect()

        {
            return _currentSuspect;
        }
        public void ReleaseControl(Ped ped)
        {
            if (_currentSuspect == ped)
            {
                _currentSuspect = null;
                CurrentArrestStyle = EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead;
                IsCompliant = false;
                IsResisting = false;
            }



            
        }




        private void OnFollowRequested(SuspectFollowRequestEvent e)
        {
            // G 键只表示“请求对当前控制/已选中的嫌疑人开始跟随/押送”。
            if (_currentSuspect == null || !_currentSuspect.Exists())
                return;

            // 只有“已被控制/顺从”的嫌疑人才能开始押送
            // 使用控制器自身的状态（IsCompliant）判断，避免依赖事件体字段。
            if (!IsCompliant)
            {
                ModLog.Info("[SuspectController] Follow request ignored: suspect not compliant");
                Notification.Show("~y~嫌疑人未配合，无法开始押送");
                return;
            }

            // 🔔 通知行为层：押送正式开始
            EventBus.Publish(new EF.PoliceMod.Input.SuspectEscortBeginEvent(_currentSuspect, Game.Player.Character));
        }





        public void TakeControl(Ped ped)
        {
            if (ped == null || !ped.Exists())
                return;

            // ★关键修复：如果重复 TakeControl 到同一个嫌疑人（例如已上拷后玩家再次按 L 锁定），
            // 不应把 IsCompliant/IsResisting 重置掉，否则会导致按 G/E 没反应。
            try
            {
                if (_currentSuspect != null && _currentSuspect.Exists() && _currentSuspect.Handle == ped.Handle)
                {
                    _currentSuspect = ped;
                    return;
                }
            }
            catch { }

            _deathEventFired = false;   // ★ 必须：为新嫌疑犯重置死亡标记

            _currentSuspect = ped;

            CurrentArrestStyle = EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead;

            // 双嫌疑人切换：按句柄恢复该嫌疑人的“已控制/反抗”状态，避免切换后误丢状态。
            bool compliant = false;
            bool resisting = false;
            try { compliant = _compliantSuspects.Contains(ped.Handle); } catch { compliant = false; }
            try { resisting = _resistingSuspects.Contains(ped.Handle); } catch { resisting = false; }

            if (resisting)
            {
                IsResisting = true;
                IsCompliant = false;
            }
            else if (compliant)
            {
                IsResisting = false;
                IsCompliant = true;
            }
            else
            {
                IsCompliant = false;
                IsResisting = false;
            }

            // ❌ 5.0.99：TakeControl 只接管“引用”和“状态”，不碰 Ped 行为

        }

        // 逼停/特殊流程用：把目标标记为“已配合”（不发布 Arrested 事件，不改变状态机）
        public void SetCompliant(Ped ped)
        {
            if (ped == null || !ped.Exists()) return;
            _currentSuspect = ped;
            IsResisting = false;
            IsCompliant = true;
            try { _resistingSuspects.Remove(ped.Handle); } catch { }
            try { _compliantSuspects.Add(ped.Handle); } catch { }

            // 逼停/临时顺从：默认按“抱头跟随”处理，避免误上拷/拽着走
            CurrentArrestStyle = EF.PoliceMod.Core.ArrestActionStyle.HandsOnHeadFollow;
        }

        // 供小队/逼停等系统在“要求拘捕节点”直接切入反抗态
        public void SetResisting(Ped ped)
        {
            if (ped == null || !ped.Exists()) return;
            _currentSuspect = ped;
            IsResisting = true;
            IsCompliant = false;
            try { _compliantSuspects.Remove(ped.Handle); } catch { }
            try { _resistingSuspects.Add(ped.Handle); } catch { }
        }

        public void ForceClear()
        {
            _currentSuspect = null;

            CurrentArrestStyle = EF.PoliceMod.Core.ArrestActionStyle.CuffAndLead;
            _pendingArrestStyle = ArrestActionStyle.CuffAndLead;
            _menuArrestContext = false;
            IsCompliant = false;
            IsResisting = false;
            _wasShotByPlayer = false;
            _deathEventFired = false;
            try { _compliantSuspects.Clear(); } catch { }
            try { _resistingSuspects.Clear(); } catch { }
        }

        public void SetPendingArrestStyle(ArrestActionStyle style)
        {
            _pendingArrestStyle = style;
        }


        public void Arrest(Ped ped)
        {
            if (ped == null || !ped.Exists())
                return;
            if (!_menuArrestContext)
            {
                ModLog.Warn($"[SuspectController] Arrest blocked outside menu flow: ped={ped.Handle}");
                return;
            }

            // 去重：避免重复发布 SuspectArrestedEvent（会导致状态机/行为重复执行）
            try
            {
                if (_currentSuspect != null && _currentSuspect.Exists() && _currentSuspect.Handle == ped.Handle && IsCompliant && !IsResisting)
                    return;
            }
            catch { }

            _deathEventFired = false;
            _currentSuspect = ped;

            // 记录本次拘捕选择的动作风格（后续跟随/上车/下车都以此为准）
            CurrentArrestStyle = _pendingArrestStyle;

            // 拘捕成功后：标记为“可押送/已控制”
            IsResisting = false;
            IsCompliant = true;
            try { _resistingSuspects.Remove(ped.Handle); } catch { }
            try { _compliantSuspects.Add(ped.Handle); } catch { }

            // ✅ 只发布“正确 handle”的事件
            EventBus.Publish(
                new EF.PoliceMod.Core.SuspectArrestedEvent(ped.Handle)
            );
        }




        /// <summary>
        /// 每帧调用：处理自动上车
        /// </summary>


        private bool CanResist(Ped player)
        {
            if (_currentSuspect == null || !_currentSuspect.Exists())
                return false;

            // 玩家距离太近（贴脸）→ 不具备反抗空间
            if (_currentSuspect.Position.DistanceTo(player.Position) < 1.2f)
                return false;

            // 注：不要把玩家是否在瞄准作为彻底禁止反抗的条件。
            //      高危嫌疑人（带枪）即便面对瞄准也应有概率反抗。
            // 没枪也可能反抗（例如暴力型徒手反抗）：用抵抗概率做兜底阈值
            if (!_hasFirearm && _resistChance < 0.50f)
                return false;

            return true;
        }


        private void TriggerResistance(Ped player)
        {


            // 进入反抗：状态应立即反映为“不合规/反抗中”
            IsResisting = true;
            IsCompliant = false;
            try { if (_currentSuspect != null && _currentSuspect.Exists()) _compliantSuspects.Remove(_currentSuspect.Handle); } catch { }
            try { if (_currentSuspect != null && _currentSuspect.Exists()) _resistingSuspects.Add(_currentSuspect.Handle); } catch { }

            EventBus.Publish(new EF.PoliceMod.Input.SuspectResistEvent(_currentSuspect, player));





            // EventBus.Publish(new SuspectResistingEvent(_currentSuspect));

            Notification.Show(
                "~r~调度中心：嫌疑犯正在暴力反抗！\n~w~已授权使用致命武力！"
            );
        }

     
        public void TryTriggerResistanceByLock(Ped player)
        {
            // ❌ 锁定阶段不允许触发反抗
            return;
        }

        // 替换/新增方法：把“尝试逮捕”的判定逻辑放在这里，供 LockTargetSystem 调用。
        // 返回 true = 拘捕成功并已执行 Arrest； false = 未能拘捕（可能触发了反抗）
        // 假定类内有 HashSet<int> _busySuspects; 并且有 MarkBusy/UnmarkBusy 方法已实现
        public bool TryAttemptArrest(Ped player)
        {
            if (_currentSuspect == null || !_currentSuspect.Exists())
                return false;

            int handle = _currentSuspect.Handle;
            try
            {
                bool canResist = CanResist(player);
                double roll = _rand.NextDouble();
                ModLog.Info($"[SuspectController] TryAttemptArrest: ped={handle}, canResist={canResist}, roll={roll:F3}, escapeDisabled={DisableFrightenedEscapeOnArrest}");

                // 按需关闭“受惊逃跑/反抗”随机链路：玩家瞄准并执行拘捕时不再随机逃跑。
                if (!DisableFrightenedEscapeOnArrest && canResist && roll < _resistChance)
                {
                    ModLog.Info($"[SuspectController] Resistance condition met for ped={handle} → TriggerResistance");

                    // 反抗需要立刻交给状态机/执行器处理；不要 MarkBusy，否则会把反抗流程挡住
                    TriggerResistance(player);
                    return false;
                }

                // 不触发随机反抗 → 执行拘捕
                _menuArrestContext = true;
                Arrest(_currentSuspect);
                _menuArrestContext = false;
                return true;
            }
            catch (Exception ex)
            {
                ModLog.Error("[SuspectController] TryAttemptArrest exception: " + ex);
                _menuArrestContext = false;
                try { _busySuspects.Remove(handle); } catch { }
                return false;
            }
        }

        // 助手方法（若不存在请添加到 SuspectController）
        public void MarkBusy(int handle)
        {
            try
            {
                if (!_busySuspects.Contains(handle)) _busySuspects.Add(handle);
            }
            catch { }
        }

        public void UnmarkBusy(int handle)
        {
            try
            {
                if (_busySuspects.Contains(handle)) _busySuspects.Remove(handle);
            }
            catch { }
        }

        public bool IsBusy(Ped p)
        {
            if (p == null || !p.Exists()) return false;
            return _busySuspects.Contains(p.Handle);
        }

        public void Initialize()
        {
            if (_initialized) return;
            _initialized = true;
            ModLog.Info("[SuspectController] Initialized");
        }

        public void Tick()
        {
        }

        public void Shutdown()
        {
            ForceClear();
            _initialized = false;
            ModLog.Info("[SuspectController] Shutdown");
        }

        public SuspectSnapshot GetSnapshot()
        {
            bool exists = _currentSuspect != null && _currentSuspect.Exists();
            return new SuspectSnapshot(
                exists ? _currentSuspect.Handle : -1,
                exists,
                IsCompliant,
                IsResisting,
                exists && _currentSuspect.IsInVehicle(),
                exists ? _currentSuspect.Position : GTA.Math.Vector3.Zero
            );
        }

        Ped ISuspectService.GetCurrentSuspect()
        {
            return _currentSuspect;
        }

        public bool HasSuspect => _currentSuspect != null && _currentSuspect.Exists();

        public bool IsHandleCompliant(int handle)
        {
            if (handle <= 0) return false;
            try { return _compliantSuspects.Contains(handle); } catch { return false; }
        }

        void ISuspectService.ReleaseControl()
        {
            ForceClear();
        }
    }
}
