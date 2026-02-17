using EF.PoliceMod.Core;
using EF.PoliceMod.Gameplay;
using GTA;
using GTA.Math;
using GTA.Native;
using GTA.UI;
using System;
using System.Collections.Generic;

namespace EF.PoliceMod.Systems
{
    public enum OfficerCommand
    {
        Summon2,
        Follow,
        Hold,
        Regroup,
        EnterPlayerVehicle,
        ExitVehicle,
        AttackLockedSuspect,
        AttackResistingTarget,
        ModeNonLethal,
        ModeLethal,
        ToggleArrestMode,
        Dismiss,
        DismissAll
    }

    public enum OfficerTargetSelection
    {
        Officer1,
        Officer2,
        All
    }

    /// <summary>
    /// 警员小队（上限2人）：
    /// - 只对“反抗”嫌疑人开火
    /// - 抓捕模式：距离<=5m 且持续瞄准2s -> 嫌疑人跪地抱头 + SetCompliant + AutoLockCompliant
    /// </summary>
    public class OfficerSquadSystem
    {
        private const int MaxOfficers = 2;
        private const float FollowOffsetY = -2.3f;
        private const float FollowSpeed = 1.2f;

        private const float AimArrestDistance = 5.0f;
        private const int AimArrestHoldMs = 2000;

        private readonly SuspectController _suspectController;
        private readonly LockTargetSystem _lockTargetSystem;

        private readonly List<Ped> _officers = new List<Ped>();
        private readonly List<Blip> _blips = new List<Blip>();

        private bool _modeNonLethal = true;
        private bool _arrestMode = false;

        private int _aimStartAtMs = 0;
        private int _aimSuspectHandle = 0;

        private int _lastCuffedSuspectHandle = 0;
        private int _lastCuffAtMs = 0;

        private int _postCuffUntilMs = 0;
        private int _postCuffSuspectHandle = 0;
        private int _postCuffCuffOfficerHandle = 0;
        private int _postCuffCoverOfficerHandle = 0;

        private readonly Dictionary<int, int> _lastVehicleSyncAtMs = new Dictionary<int, int>();
        private const int VehicleSyncDebounceMs = 1500;

        // 抓捕模式追捕：持续刷新目标位置（嫌疑人会移动），并做去抖避免每帧狂刷任务
        private int _lastPursuitTaskAtMs = 0;
        private const int PursuitTaskDebounceMs = 800;
        private int _lastFarArrestWarnAtMs = 0;
        private const int FarArrestWarnCooldownMs = 1800;
        private const float MaxSquadArrestDistanceFromPlayer = 75.0f;

        // 远离玩家时自动补发“跟随”任务，确保小队一直跟着你
        // NOTE: Hold（原地待命）时应禁止该逻辑，否则会出现“待命但离远又追上来”的不合理表现
        private int _lastAutoFollowAtMs = 0;
        private const int AutoFollowDebounceMs = 900;
        private bool _holdMode = false;

        public int OfficerCount
        {
            get
            {
                int c = 0;
                foreach (var o in _officers) if (o != null && o.Exists() && !o.IsDead) c++;
                return c;
            }
        }

        public bool ModeNonLethal => _modeNonLethal;
        public bool ArrestMode => _arrestMode;
        public IReadOnlyList<Ped> Officers => _officers;

        public OfficerSquadSystem(SuspectController suspectController, LockTargetSystem lockTargetSystem)
        {
            _suspectController = suspectController;
            _lockTargetSystem = lockTargetSystem;

            EventBus.Subscribe<DutyEndedEvent>(_ => DismissAll("DutyEnded"));
        }

        public void Tick()
        {
            CleanupInvalid();
            EnsureBlips();
            EnsureGroupAndLoyalty();
            PostCuffTick();

            // ★小队常驻跟随：非抓捕模式/非战斗时，距离过远就补发跟随任务
            try
            {
                int now = Game.GameTime;
                if (now - _lastAutoFollowAtMs >= AutoFollowDebounceMs)
                {
                    _lastAutoFollowAtMs = now;

                    var player = Game.Player.Character;
                    if (player != null && player.Exists())
                    {
                        foreach (var o in _officers)
                        {
                            if (o == null || !o.Exists() || o.IsDead) continue;

                            // 抓捕模式里由追捕逻辑接管；战斗中也不打断
                            if (_arrestMode) continue;
                            if (_holdMode) continue;

                            bool inCombat = false;
                            try { inCombat = Function.Call<bool>(Hash.IS_PED_IN_COMBAT, o.Handle, 0); } catch { inCombat = false; }
                            if (inCombat) continue;

                            float dist = 0f;
                            try { dist = o.Position.DistanceTo(player.Position); } catch { dist = 0f; }
                            if (dist >= 12.0f)
                            {
                                FollowPlayer(o);
                            }
                        }
                    }
                }
            }
            catch { }

            // 嫌疑人反抗：警员自动介入（无需菜单手动下达攻击指令）
            try
            {
                var suspect = _suspectController?.GetCurrentSuspect();
                if (suspect != null && suspect.Exists() && _suspectController.IsResisting)
                {
                    foreach (var o in _officers)
                    {
                        if (o == null || !o.Exists() || o.IsDead) continue;
                        CombatTarget(o, suspect);
                    }
                }
            }
            catch { }

            if (_arrestMode)
            {
                TryAimArrestTick();
            }
        }

        public void SummonIfNeeded(int desiredCount)
        {
            desiredCount = Math.Max(0, Math.Min(MaxOfficers, desiredCount));

            // 第一次呼叫且目标是2人：让他们开车过来（更容易被看见/跟随/上下车）
            if (OfficerCount == 0 && desiredCount == 2)
            {
                if (SpawnSquadCarApproach())
                    return;
            }

            while (OfficerCount < desiredCount)
            {
                SpawnOfficerOffscreen();
            }
        }

        public void Execute(OfficerTargetSelection sel, OfficerCommand cmd)
        {
            // 全局命令
            if (cmd == OfficerCommand.ModeNonLethal)
            {
                _modeNonLethal = true;
                Notification.Show("~b~小队模式：非致命");
                ApplyWeaponPolicy();
                return;
            }
            if (cmd == OfficerCommand.ModeLethal)
            {
                _modeNonLethal = false;
                Notification.Show("~r~小队模式：致命");
                ApplyWeaponPolicy();
                return;
            }
            if (cmd == OfficerCommand.ToggleArrestMode)
            {
                _arrestMode = !_arrestMode;
                ResetAimTrack();
                _lastPursuitTaskAtMs = 0;

                ModLog.Info($"[OfficerSquad] ToggleArrestMode -> {_arrestMode}");

                if (_arrestMode)
                {
                    // 立刻跑一次，避免出现“要等关掉/等一会儿才开始动”的错觉
                    try { TryAimArrestTick(); } catch { }
                    Notification.Show("~g~抓捕模式：开启（自动追捕当前嫌疑人）");
                }
                else
                {
                    // 关闭抓捕模式：强制把警员拉回到跟随，避免残留的追捕任务造成“关了反而去抓”的现象
                    try
                    {
                        foreach (var o in _officers)
                        {
                            if (o == null || !o.Exists() || o.IsDead) continue;
                            try { o.Task.ClearAll(); } catch { }
                            FollowPlayer(o);
                        }
                    }
                    catch { }

                    Notification.Show("~y~抓捕模式：关闭");
                }

                return;
            }
            if (cmd == OfficerCommand.DismissAll)
            {
                DismissAll("Menu");
                return;
            }
            if (cmd == OfficerCommand.Summon2)
            {
                SummonIfNeeded(2);
                return;
            }

            if (sel == OfficerTargetSelection.All)
            {
                foreach (var o in _officers) ExecuteOnOfficer(o, cmd);
            }
            else
            {
                var o = (sel == OfficerTargetSelection.Officer1) ? GetOfficer(0) : GetOfficer(1);
                ExecuteOnOfficer(o, cmd);
            }
        }

        private void ExecuteOnOfficer(Ped officer, OfficerCommand cmd)
        {
            if (officer == null || !officer.Exists() || officer.IsDead) return;

            switch (cmd)
            {
                case OfficerCommand.Follow:
                    _holdMode = false;
                    FollowPlayer(officer);
                    break;
                case OfficerCommand.Hold:
                    _holdMode = true;
                    HoldPosition(officer);
                    break;
                case OfficerCommand.Regroup:
                    _holdMode = false;
                    Regroup(officer);
                    break;
                case OfficerCommand.EnterPlayerVehicle:
                    EnterPlayerVehicle(officer);
                    break;
                case OfficerCommand.ExitVehicle:
                    ExitVehicle(officer);
                    break;
                case OfficerCommand.AttackLockedSuspect:
                    AttackLockedSuspect(officer);
                    break;
                case OfficerCommand.AttackResistingTarget:
                    AttackResisting(officer);
                    break;
                case OfficerCommand.Dismiss:
                    Dismiss(officer, "Menu");
                    break;
            }
        }

        private void FollowPlayer(Ped officer)
        {
            var player = Game.Player.Character;
            if (player == null || !player.Exists()) return;

            // 玩家在车内：跟随=上车（否则会出现“下车跟随→又被同步上车→循环开关门”）
            try
            {
                if (player.IsInVehicle())
                {
                    EnterPlayerVehicle(officer);
                    return;
                }
            }
            catch { }

            // 用“玩家编队”能更稳定地跟随/上下车
            SetupOfficerAsSquad(officer);

            try { officer.Task.ClearAll(); } catch { }
            try { Function.Call(Hash.TASK_FOLLOW_TO_OFFSET_OF_ENTITY, officer.Handle, player.Handle, 0f, FollowOffsetY, 0f, FollowSpeed, -1, 1.5f, true); } catch { }
        }

        private void HoldPosition(Ped officer)
        {
            try { officer.Task.ClearAll(); } catch { }
            try { Function.Call(Hash.TASK_STAND_STILL, officer.Handle, -1); } catch { }
        }

        private void Regroup(Ped officer)
        {
            var player = Game.Player.Character;
            if (player == null || !player.Exists()) return;

            // 玩家在车内：集合=上车（否则停着时会不断“走向玩家→下车→再上车”）
            try
            {
                if (player.IsInVehicle())
                {
                    EnterPlayerVehicle(officer);
                    return;
                }
            }
            catch { }

            SetupOfficerAsSquad(officer);

            try { officer.Task.ClearAll(); } catch { }
            try { Function.Call(Hash.TASK_GO_TO_ENTITY, officer.Handle, player.Handle, -1, 2.0f, 2.0f, 1073741824, 0); } catch { }
        }

        private void AttackLockedSuspect(Ped officer)
        {
            var target = EFCore.Instance?.LockTargetSystem?.CurrentTarget;
            if (target == null || !target.Exists()) return;
            if (!IsSuspectResisting(target)) return;

            CombatTarget(officer, target);
        }

        private void AttackResisting(Ped officer)
        {
            var target = EFCore.Instance?.LockTargetSystem?.CurrentTarget;
            if (target == null || !target.Exists()) return;
            if (!IsSuspectResisting(target)) return;

            CombatTarget(officer, target);
        }

        private void CombatTarget(Ped officer, Ped suspect)
        {
            if (officer == null || !officer.Exists()) return;
            if (suspect == null || !suspect.Exists()) return;

            ApplyWeaponPolicy(officer);

            // ★驾车逃逸线：警员在玩家车内也必须开火
            try
            {
                var player = Game.Player.Character;
                if (player != null && player.Exists() && player.IsInVehicle() && officer.IsInVehicle())
                {
                    var pv = player.CurrentVehicle;
                    if (pv != null && pv.Exists() && officer.CurrentVehicle != null && officer.CurrentVehicle.Exists() && officer.CurrentVehicle.Handle == pv.Handle)
                    {
                        try { Function.Call(Hash.TASK_SHOOT_AT_ENTITY, officer.Handle, suspect.Handle, 2500, 0); } catch { }
                        try { Function.Call(Hash.SET_PED_SHOOTS_AT_COORD, officer.Handle, suspect.Position.X, suspect.Position.Y, suspect.Position.Z, true); } catch { }
                        return;
                    }
                }
            }
            catch { }

            try { Function.Call(Hash.CLEAR_PED_TASKS_IMMEDIATELY, officer.Handle); } catch { }
            try { Function.Call(Hash.TASK_COMBAT_PED, officer.Handle, suspect.Handle, 0, 16); } catch { }
        }

        private void ApplyWeaponPolicy()
        {
            foreach (var o in _officers) ApplyWeaponPolicy(o);
        }

        private void ApplyWeaponPolicy(Ped officer)
        {
            if (officer == null || !officer.Exists()) return;

            try
            {
                if (_modeNonLethal)
                    officer.Weapons.Give(WeaponHash.StunGun, 10, true, true);
                else
                    officer.Weapons.Give(WeaponHash.Pistol, 60, true, true);
            }
            catch { }
        }

        private void TryAimArrestTick()
        {
            // 抓捕模式（双保镖自动拘捕）：
            // 1) 确保当前案件嫌疑人有效
            // 2) 两名警员自动跑向嫌疑人，其中一人压制瞄准，一人上拷
            // 3) 上拷完成后直接 SuspectController.Arrest，使玩家可直接按 G 押送（跳过 L/H）

            // 优先使用玩家锁定目标；没有锁定时，直接使用“当前案件嫌疑人”
            var lts = EFCore.Instance?.LockTargetSystem;
            var suspect = lts?.CurrentTarget;
            if (suspect == null || !suspect.Exists()) suspect = lts?.CurrentSuspect;
            if (suspect == null || !suspect.Exists()) { ResetAimTrack(); return; }

            try
            {
                if (suspect.IsDead)
                {
                    _arrestMode = false;
                    ResetAimTrack();
                    Notification.Show("~y~目标已死亡，已自动关闭小队抓捕模式");
                    return;
                }
            }
            catch { }

            try
            {
                var player = Game.Player.Character;
                if (player != null && player.Exists())
                {
                    float distToPlayer = suspect.Position.DistanceTo(player.Position);
                    if (distToPlayer > MaxSquadArrestDistanceFromPlayer)
                    {
                        int nowWarn = Game.GameTime;
                        if (nowWarn - _lastFarArrestWarnAtMs >= FarArrestWarnCooldownMs)
                        {
                            _lastFarArrestWarnAtMs = nowWarn;
                            Notification.Show("~y~嫌疑人距离过远，无法要求小队步行逮捕");
                        }
                        ResetAimTrack();
                        return;
                    }
                }
            }
            catch { }

            // 绑定当前案件嫌疑人：若还没 TakeControl，就在这里接管（实现“锁定->小队自动拘捕”闭环）
            try
            {
                var cur = _suspectController?.GetCurrentSuspect();
                if (cur == null || !cur.Exists() || cur.Handle != suspect.Handle)
                {
                    _suspectController?.TakeControl(suspect);
                }
            }
            catch { }

            // 已经拘捕/可押送：自动关闭抓捕模式，避免重复循环
            try
            {
                var cur = _suspectController?.GetCurrentSuspect();
                if (cur != null && cur.Exists() && cur.Handle == suspect.Handle && _suspectController.IsCompliant && !_suspectController.IsResisting)
                {
                    _arrestMode = false;
                    Notification.Show("~g~目标已被控制，抓捕模式已自动关闭");
                    ResetAimTrack();
                    return;
                }
            }
            catch { }

            if (IsSuspectResisting(suspect)) { ResetAimTrack(); return; }

            // 确保 2 人到位
            try { SummonIfNeeded(2); } catch { }

            var o1 = GetOfficer(0);
            var o2 = GetOfficer(1);
            if (o1 == null || !o1.Exists()) { ResetAimTrack(); return; }

            int now = Game.GameTime;

            // 去重：同一个嫌疑人短时间只执行一次
            if (_lastCuffedSuspectHandle == suspect.Handle && now - _lastCuffAtMs < 5000)
            {
                ResetAimTrack();
                return;
            }

            // 选一个“上拷手”=离嫌疑人更近的警员
            Ped cuffOfficer = o1;
            Ped coverOfficer = o2;
            try
            {
                if (o2 != null && o2.Exists() && !o2.IsDead)
                {
                    float d1 = o1.Position.DistanceTo(suspect.Position);
                    float d2 = o2.Position.DistanceTo(suspect.Position);
                    if (d2 < d1)
                    {
                        cuffOfficer = o2;
                        coverOfficer = o1;
                    }
                }
            }
            catch { cuffOfficer = o1; coverOfficer = o2; }

            // 让两名警员都跑向嫌疑人（不瞬移）
            // 注意：嫌疑人会移动，所以需要“持续刷新任务”，否则会出现追到一半停下/跑去旧位置。
            if (now - _lastPursuitTaskAtMs >= PursuitTaskDebounceMs)
            {
                _lastPursuitTaskAtMs = now;

                try
                {
                    if (cuffOfficer != null && cuffOfficer.Exists() && !cuffOfficer.IsDead)
                    {
                        // 上拷必须从嫌疑人身后贴近（避免跑到脸上导致穿模/同步场景错位）
                        Vector3 behind = Function.Call<Vector3>(Hash.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS, suspect.Handle, 0.12f, -0.95f, 0.0f);
                        Function.Call(Hash.TASK_GO_TO_COORD_ANY_MEANS, cuffOfficer.Handle, behind.X, behind.Y, behind.Z, 2.8f, 0, false, 786468, 0.0f);
                    }
                }
                catch { }

                try
                {
                    if (coverOfficer != null && coverOfficer.Exists() && !coverOfficer.IsDead)
                    {
                        Function.Call(Hash.TASK_GO_TO_ENTITY, coverOfficer.Handle, suspect.Handle, -1, 3.8f, 2.0f, 1073741824, 0);
                        Function.Call(Hash.TASK_AIM_GUN_AT_ENTITY, coverOfficer.Handle, suspect.Handle, 1200, false);
                    }
                }
                catch { }
            }

            // 近距离才上拷
            float d = 9999f;
            try { d = cuffOfficer.Position.DistanceTo(suspect.Position); } catch { d = 9999f; }
            if (d > 2.35f)
            {
                ResetAimTrack();
                return;
            }

            // 压制计时（避免刚碰到就上拷，观感突兀）
            if (_aimSuspectHandle != suspect.Handle)
            {
                _aimSuspectHandle = suspect.Handle;
                _aimStartAtMs = now;
                return;
            }
            if (_aimStartAtMs <= 0) _aimStartAtMs = now;
            if (now - _aimStartAtMs < 650) return;

            // ★修复点2/3：高危嫌疑人不应被小队拘捕/上拷。
            // 在“要求拘捕”的节点直接触发反抗（开枪）。
            try
            {
                bool highRisk = false;
                try
                {
                    highRisk = _suspectController != null && (_suspectController.HasFirearm || _suspectController.ResistChance >= 0.85f);
                }
                catch { highRisk = false; }

                if (highRisk)
                {
                    // 立刻取消“上拷/压制”相关任务，避免警员卡住（T pose/僵直）
                    try { if (cuffOfficer != null && cuffOfficer.Exists()) Function.Call(Hash.CLEAR_PED_TASKS_IMMEDIATELY, cuffOfficer.Handle); } catch { }
                    try { if (coverOfficer != null && coverOfficer.Exists()) Function.Call(Hash.CLEAR_PED_TASKS_IMMEDIATELY, coverOfficer.Handle); } catch { }

                    // 不要给高危嫌疑人上拷：直接转入反抗
                    try { Function.Call(Hash.CLEAR_PED_TASKS, suspect.Handle); } catch { }
                    try { Function.Call(Hash.FREEZE_ENTITY_POSITION, suspect.Handle, false); } catch { }
                    try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, false); } catch { }
                    try { Function.Call(Hash.SET_ENABLE_BOUND_ANKLES, suspect.Handle, false); } catch { }

                    try { _suspectController?.SetResisting(suspect); } catch { }
                    try { EventBus.Publish(new EF.PoliceMod.Input.SuspectResistEvent(suspect, Game.Player.Character)); } catch { }

                    // 让小队立刻开火接战（否则会站着发呆）
                    try { if (cuffOfficer != null && cuffOfficer.Exists()) CombatTarget(cuffOfficer, suspect); } catch { }
                    try { if (coverOfficer != null && coverOfficer.Exists()) CombatTarget(coverOfficer, suspect); } catch { }

                    Notification.Show("~r~高危嫌疑人拒捕：开枪反抗！");
                    ResetAimTrack();
                    return;
                }
            }
            catch { }

            // 上拷动画（同步场景，减少错位；并等待字典加载）
            try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, true); } catch { }
            try { Function.Call(Hash.TASK_STAND_STILL, suspect.Handle, 2500); } catch { }

            try
            {
                // 不要在 Tick 里 while 等待：会阻塞脚本，导致追捕/菜单输入看起来“反了/延迟”。
                Function.Call(Hash.REQUEST_ANIM_DICT, "mp_arrest_paired");
                if (!Function.Call<bool>(Hash.HAS_ANIM_DICT_LOADED, "mp_arrest_paired"))
                {
                    // 下个 Tick 再试
                    return;
                }

                // ★关键：在进同步场景前做一次“对位”，减少警员卡在嫌疑人身体里穿模
                try
                {
                    Vector3 cuffPos = Function.Call<Vector3>(Hash.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS, suspect.Handle, 0.12f, -0.95f, 0.0f);
                    Function.Call(Hash.SET_ENTITY_COORDS_NO_OFFSET, cuffOfficer.Handle, cuffPos.X, cuffPos.Y, cuffPos.Z, false, false, false);
                    Function.Call(Hash.SET_ENTITY_HEADING, cuffOfficer.Handle, suspect.Heading);
                }
                catch { }

                try { Function.Call(Hash.PLACE_OBJECT_ON_GROUND_PROPERLY, cuffOfficer.Handle); } catch { }
                try { Function.Call(Hash.PLACE_OBJECT_ON_GROUND_PROPERLY, suspect.Handle); } catch { }

                // 确保双方恢复碰撞（同步场景+走位时可能被设置为 no-collision）
                try { Function.Call(Hash.SET_ENTITY_NO_COLLISION_ENTITY, cuffOfficer.Handle, suspect.Handle, false); } catch { }
                try { Function.Call(Hash.SET_ENTITY_NO_COLLISION_ENTITY, suspect.Handle, cuffOfficer.Handle, false); } catch { }

                var pos = suspect.Position;
                float heading = suspect.Heading;
                int scene = Function.Call<int>(Hash.CREATE_SYNCHRONIZED_SCENE, pos.X, pos.Y, pos.Z, 0f, 0f, heading, 2);
                Function.Call(Hash.TASK_SYNCHRONIZED_SCENE, cuffOfficer.Handle, scene, "mp_arrest_paired", "cop_p2_back_left", 4.0f, -4.0f, 0, 0, 0f, 0);
                Function.Call(Hash.TASK_SYNCHRONIZED_SCENE, suspect.Handle, scene, "mp_arrest_paired", "crook_p2_back_left", 4.0f, -4.0f, 0, 0, 0f, 0);
                Function.Call(Hash.SET_SYNCHRONIZED_SCENE_LOOPED, scene, false);
            }
            catch { }

            // 防止“穿人/无碰撞”异常（best-effort 强制恢复）
            try { Function.Call(Hash.FREEZE_ENTITY_POSITION, suspect.Handle, false); } catch { }
            try { Function.Call(Hash.SET_ENTITY_COLLISION, suspect.Handle, true, true); } catch { }
            try { Function.Call(Hash.FREEZE_ENTITY_POSITION, cuffOfficer.Handle, false); } catch { }
            try { Function.Call(Hash.SET_ENTITY_COLLISION, cuffOfficer.Handle, true, true); } catch { }
            try { if (coverOfficer != null && coverOfficer.Exists()) Function.Call(Hash.SET_ENTITY_COLLISION, coverOfficer.Handle, true, true); } catch { }

            // 进入“已拘捕/可押送”状态：默认拷线，玩家可按 G 押送
            try { ArrestStyleState.SelectedStyle = ArrestActionStyle.CuffAndLead; } catch { }
            try { _suspectController?.Arrest(suspect); } catch { }
            try { _lockTargetSystem?.AutoLockCompliant(suspect); } catch { }

            // ★修复：警员上拷后，嫌疑人必须立刻保持“被拷态”（双手在后），不等玩家按 G。
            try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, true); } catch { }
            try { Function.Call(Hash.SET_ENABLE_BOUND_ANKLES, suspect.Handle, true); } catch { }
            try
            {
                Function.Call(Hash.REQUEST_ANIM_DICT, "mp_arresting");
                if (Function.Call<bool>(Hash.HAS_ANIM_DICT_LOADED, "mp_arresting"))
                {
                    // flags=49: Loop + UpperBodyOnly
                    Function.Call(Hash.TASK_PLAY_ANIM, suspect.Handle, "mp_arresting", "idle", 4.0f, -4.0f, -1, 49, 0.0f, false, false, false);
                }
            }
            catch { }

            _lastCuffedSuspectHandle = suspect.Handle;
            _lastCuffAtMs = now;

            // 抓捕完成后自动关闭抓捕模式，避免继续尝试抓捕无效目标。
            _arrestMode = false;

            // 延迟后处理：让警员恢复跟随，避免一直站着变“雕像”
            // 窗口过长会导致“同步场景结束后姿态掉一段时间”；缩短让后处理更快接管
            _postCuffUntilMs = now + 900;
            _postCuffSuspectHandle = suspect.Handle;
            _postCuffCuffOfficerHandle = cuffOfficer.Handle;
            _postCuffCoverOfficerHandle = (coverOfficer != null && coverOfficer.Exists()) ? coverOfficer.Handle : 0;

            Notification.Show("~g~小队已上拷：抓捕模式已自动关闭，按 G 押送");
            ResetAimTrack();
        }

        private void PostCuffTick()
        {
            if (_postCuffUntilMs <= 0) return;

            int now = Game.GameTime;

            // 在“上拷后的短窗口”内，每帧强制恢复实体碰撞/冻结状态，避免嫌疑人/警员出现“非实体/可穿模/卡死”。
            try
            {
                // 嫌疑人兜底恢复
                var suspect = (_postCuffSuspectHandle != 0) ? (Entity.FromHandle(_postCuffSuspectHandle) as Ped) : null;
                if (suspect != null && suspect.Exists())
                {
                    try { Function.Call(Hash.FREEZE_ENTITY_POSITION, suspect.Handle, false); } catch { }
                    try { Function.Call(Hash.SET_ENTITY_COMPLETELY_DISABLE_COLLISION, suspect.Handle, false, false); } catch { }
                    try { Function.Call(Hash.SET_ENTITY_COLLISION, suspect.Handle, true, true); } catch { }
                    try { Function.Call(Hash.SET_ENTITY_DYNAMIC, suspect.Handle, true); } catch { }
                    try { Function.Call(Hash.SET_ENTITY_HAS_GRAVITY, suspect.Handle, true); } catch { }
                    try { Function.Call(Hash.ACTIVATE_PHYSICS, suspect.Handle); } catch { }

                    // ★修复点1：同步场景结束后的 0~1s 内姿态会掉；在窗口内持续补“被拷态”
                    try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, true); } catch { }
                    try { Function.Call(Hash.SET_ENABLE_BOUND_ANKLES, suspect.Handle, true); } catch { }
                    try
                    {
                        bool playing = false;
                        try { playing = Function.Call<bool>(Hash.IS_ENTITY_PLAYING_ANIM, suspect.Handle, "mp_arresting", "idle", 3); } catch { playing = false; }
                        if (!playing)
                        {
                            Function.Call(Hash.REQUEST_ANIM_DICT, "mp_arresting");
                            if (Function.Call<bool>(Hash.HAS_ANIM_DICT_LOADED, "mp_arresting"))
                            {
                                Function.Call(Hash.TASK_PLAY_ANIM, suspect.Handle, "mp_arresting", "idle", 4.0f, -4.0f, -1, 49, 0.0f, false, false, false);
                            }
                        }
                    }
                    catch { }
                }

                // 上拷警员兜底恢复（同步场景偶发把参与者碰撞搞没）
                if (_postCuffCuffOfficerHandle != 0)
                {
                    var o = Entity.FromHandle(_postCuffCuffOfficerHandle) as Ped;
                    if (o != null && o.Exists() && !o.IsDead)
                    {
                        try { Function.Call(Hash.FREEZE_ENTITY_POSITION, o.Handle, false); } catch { }
                        try { Function.Call(Hash.SET_ENTITY_COLLISION, o.Handle, true, true); } catch { }
                        try { Function.Call(Hash.SET_ENTITY_DYNAMIC, o.Handle, true); } catch { }
                        try { Function.Call(Hash.ACTIVATE_PHYSICS, o.Handle); } catch { }
                    }
                }
                if (_postCuffCoverOfficerHandle != 0)
                {
                    var o = Entity.FromHandle(_postCuffCoverOfficerHandle) as Ped;
                    if (o != null && o.Exists() && !o.IsDead)
                    {
                        try { Function.Call(Hash.FREEZE_ENTITY_POSITION, o.Handle, false); } catch { }
                        try { Function.Call(Hash.SET_ENTITY_COLLISION, o.Handle, true, true); } catch { }
                        try { Function.Call(Hash.SET_ENTITY_DYNAMIC, o.Handle, true); } catch { }
                        try { Function.Call(Hash.ACTIVATE_PHYSICS, o.Handle); } catch { }
                    }
                }
            }
            catch { }

            if (now < _postCuffUntilMs) return;

            _postCuffUntilMs = 0;

            try
            {
                // 上拷动画结束后：强制清理嫌疑人的僵直任务（否则会出现“一动不动且穿模”）
                try
                {
                    var suspect = (_postCuffSuspectHandle != 0) ? (Entity.FromHandle(_postCuffSuspectHandle) as Ped) : null;
                    if (suspect != null && suspect.Exists() && !suspect.IsDead)
                    {
                        try { Function.Call(Hash.CLEAR_PED_TASKS_IMMEDIATELY, suspect.Handle); } catch { }

                        // ★修复点1：清任务会把背手姿态一起清掉；这里立刻重施加“被拷态”。
                        try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, true); } catch { }
                        try { Function.Call(Hash.SET_ENABLE_BOUND_ANKLES, suspect.Handle, true); } catch { }
                        try
                        {
                            Function.Call(Hash.REQUEST_ANIM_DICT, "mp_arresting");
                            if (Function.Call<bool>(Hash.HAS_ANIM_DICT_LOADED, "mp_arresting"))
                            {
                                Function.Call(Hash.TASK_PLAY_ANIM, suspect.Handle, "mp_arresting", "idle", 4.0f, -4.0f, -1, 49, 0.0f, false, false, false);
                            }
                        }
                        catch { }
                    }
                }
                catch { }

                var player = Game.Player.Character;
                if (player == null || !player.Exists()) return;

                if (_postCuffCuffOfficerHandle != 0)
                {
                    var o = Entity.FromHandle(_postCuffCuffOfficerHandle) as Ped;
                    if (o != null && o.Exists() && !o.IsDead)
                    {
                        try { o.Task.ClearAll(); } catch { }
                        try { Function.Call(Hash.TASK_FOLLOW_TO_OFFSET_OF_ENTITY, o.Handle, player.Handle, 0f, FollowOffsetY, 0f, FollowSpeed, -1, 1.5f, true); } catch { }
                    }
                }

                if (_postCuffCoverOfficerHandle != 0)
                {
                    var o = Entity.FromHandle(_postCuffCoverOfficerHandle) as Ped;
                    if (o != null && o.Exists() && !o.IsDead)
                    {
                        try { o.Task.ClearAll(); } catch { }
                        try { Function.Call(Hash.TASK_FOLLOW_TO_OFFSET_OF_ENTITY, o.Handle, player.Handle, 0f, FollowOffsetY, 0f, FollowSpeed, -1, 1.5f, true); } catch { }
                    }
                }
            }
            catch { }

            _postCuffSuspectHandle = 0;
            _postCuffCuffOfficerHandle = 0;
            _postCuffCoverOfficerHandle = 0;
        }

        private void ResetAimTrack()
        {
            _aimStartAtMs = 0;
            _aimSuspectHandle = 0;
        }

        private void ResetAimTrackIfMismatch(Ped suspect)
        {
            if (suspect == null || !suspect.Exists()) { ResetAimTrack(); return; }
            if (_aimSuspectHandle != suspect.Handle) ResetAimTrack();
        }

        private bool IsSuspectResisting(Ped suspect)
        {
            try
            {
                var cur = _suspectController?.GetCurrentSuspect();
                if (cur != null && cur.Exists() && suspect != null && suspect.Exists() && cur.Handle == suspect.Handle)
                {
                    return _suspectController.IsResisting;
                }
            }
            catch { }

            return false;
        }

        private Ped GetOfficer(int index)
        {
            if (index < 0 || index >= _officers.Count) return null;
            var o = _officers[index];
            if (o == null || !o.Exists() || o.IsDead) return null;
            return o;
        }

        private void CleanupInvalid()
        {
            for (int i = _officers.Count - 1; i >= 0; i--)
            {
                var o = _officers[i];
                if (o == null || !o.Exists() || o.IsDead)
                {
                    try { RemoveBlip(i); } catch { }
                    _officers.RemoveAt(i);
                }
            }
        }

        private void EnsureBlips()
        {
            while (_blips.Count < _officers.Count) _blips.Add(null);
            while (_blips.Count > _officers.Count) _blips.RemoveAt(_blips.Count - 1);

            for (int i = 0; i < _officers.Count; i++)
            {
                var o = _officers[i];
                if (o == null || !o.Exists()) continue;

                if (_blips[i] == null)
                {
                    try
                    {
                        var b = o.AddBlip();
                        b.Color = BlipColor.Blue;
                        b.Scale = 0.65f;
                        b.IsShortRange = true;
                        b.Name = "警员" + (i + 1);
                        _blips[i] = b;
                    }
                    catch { }
                }
            }
        }

        private void RemoveBlip(int index)
        {
            if (index < 0 || index >= _blips.Count) return;
            var b = _blips[index];
            if (b != null)
            {
                try { b.Delete(); } catch { }
            }
            _blips[index] = null;
        }

        private void Dismiss(Ped officer, string reason)
        {
            if (officer == null || !officer.Exists()) return;

            try
            {
                try { officer.Task.WanderAround(); } catch { }
                try { officer.MarkAsNoLongerNeeded(); } catch { }
                try { officer.Delete(); } catch { }
            }
            catch { }

            CleanupInvalid();
            Notification.Show("~y~警员已解雇");
        }

        private void DismissAll(string reason)
        {
            foreach (var o in _officers)
            {
                try
                {
                    if (o == null || !o.Exists()) continue;
                    try { o.Task.WanderAround(); } catch { }
                    try { o.MarkAsNoLongerNeeded(); } catch { }
                    try { o.Delete(); } catch { }
                }
                catch { }
            }

            _officers.Clear();

            foreach (var b in _blips)
            {
                try { b?.Delete(); } catch { }
            }
            _blips.Clear();

            ResetAimTrack();
            _arrestMode = false;
        }

        private void EnsureGroupAndLoyalty()
        {
            for (int i = 0; i < _officers.Count; i++)
            {
                var o = _officers[i];
                if (o == null || !o.Exists() || o.IsDead) continue;
                SetupOfficerAsSquad(o);
            }
        }

        private void SetupOfficerAsSquad(Ped officer)
        {
            if (officer == null || !officer.Exists() || officer.IsDead) return;

            // 关键：避免被玩家误伤后进入“敌对/自发反击/下车乱跑”等非指挥行为
            try { officer.BlockPermanentEvents = true; } catch { }
            try { officer.AlwaysKeepTask = true; } catch { }

            // 不加入玩家编队：编队成员在主角瞬移/传送时可能“瞬移跟随”，视觉很跳；
            // 这里改为只做友军/警察属性，跟随靠 TASK_FOLLOW... 来跑过来。

            // 友军关系：跟玩家同关系组，且双方互相 Friendly（防止被玩家打到后反抗/举枪）
            try
            {
                var player = Game.Player.Character;
                if (player != null && player.Exists())
                {
                    int pGrp = 0;
                    try { pGrp = player.RelationshipGroup.Hash; } catch { pGrp = 0; }
                    if (pGrp != 0)
                    {
                        try { officer.RelationshipGroup = player.RelationshipGroup; } catch { }
                        try { Function.Call(Hash.SET_RELATIONSHIP_BETWEEN_GROUPS, 0, pGrp, pGrp); } catch { }
                    }
                }
            }
            catch { }

            // 禁止攻击友军/玩家
            try { Function.Call(Hash.SET_CAN_ATTACK_FRIENDLY, officer.Handle, false, false); } catch { }

            // 让他们更“队友化”
            try { Function.Call(Hash.SET_PED_AS_COP, officer.Handle, true); } catch { }
            try { Function.Call(Hash.SET_PED_COMBAT_ATTRIBUTES, officer.Handle, 46, true); } catch { } // BF_CanFightArmedPedsWhenNotArmed
            try { Function.Call(Hash.SET_PED_COMBAT_ATTRIBUTES, officer.Handle, 17, false); } catch { } // BF_AlwaysFight

            // 避免车辆停下时“反复上下车/开关门”
            try { Function.Call(Hash.SET_PED_STAY_IN_VEHICLE_WHEN_JACKED, officer.Handle, true); } catch { }
            try { Function.Call(Hash.SET_PED_CAN_BE_DRAGGED_OUT, officer.Handle, false); } catch { }
        }

        private void EnsureVehicleSync(Ped officer)
        {
            var player = Game.Player.Character;
            if (player == null || !player.Exists()) return;

            int now = Game.GameTime;
            int key = officer.Handle;
            int last = 0;
            try { _lastVehicleSyncAtMs.TryGetValue(key, out last); } catch { last = 0; }
            if (last > 0 && now - last < VehicleSyncDebounceMs) return;

            // 这里只做“上车同步”（不再强制下车），避免停车时频繁开关车门
            if (!player.IsInVehicle()) return;

            var pv = player.CurrentVehicle;
            if (pv == null || !pv.Exists()) return;

            // 已在同一辆车：不干预（增强版 Hash 可能缺 TASK_STAY_IN_VEHICLE；这里仅刷新去抖时间）
            if (officer.IsInVehicle())
            {
                var ov = officer.CurrentVehicle;
                if (ov != null && ov.Exists() && ov.Handle == pv.Handle)
                {
                    _lastVehicleSyncAtMs[key] = now;
                    return;
                }
            }

            // 不使用 officer.IsGettingIntoAVehicle（增强版 API 可能没有该属性），依赖去抖即可

            int seat = GetPreferredSeatForOfficer(officer, pv);
            if (seat == int.MinValue) return;

            _lastVehicleSyncAtMs[key] = now;
            try { Function.Call(Hash.TASK_ENTER_VEHICLE, officer.Handle, pv.Handle, -1, seat, 2.0f, 1, 0); } catch { }
        }

        private int FindAnyFreePassengerSeat(Vehicle vehicle)
        {
            if (vehicle == null || !vehicle.Exists()) return int.MinValue;

            // 座位索引（GTA）：-1=驾驶，0=副驾，1/2=后排，之后依次延伸。
            // 需求：有座就上，但绝对不能坐主驾驶。
            int[] seats = new int[] { 0, 2, 1, 3, 4, 5, 6, 7 };

            for (int i = 0; i < seats.Length; i++)
            {
                int s = seats[i];
                if (s == (int)VehicleSeat.Driver) continue;

                try
                {
                    bool free = Function.Call<bool>(Hash.IS_VEHICLE_SEAT_FREE, vehicle.Handle, s, false);
                    if (free) return s;
                }
                catch { }
            }

            // 没座位就别硬塞（避免 AI 去“抢驾驶/拽人”）
            return int.MinValue;
        }

        private int GetPreferredSeatForOfficer(Ped officer, Vehicle vehicle)
        {
            // 目的：尽量分配不同座位，且永远不选驾驶位。
            int idx = -1;
            try { idx = _officers.IndexOf(officer); } catch { idx = -1; }

            int preferred = (idx == 1) ? (int)VehicleSeat.RightRear : (int)VehicleSeat.Passenger;
            if (preferred == (int)VehicleSeat.Driver) preferred = (int)VehicleSeat.Passenger;

            try
            {
                bool free = Function.Call<bool>(Hash.IS_VEHICLE_SEAT_FREE, vehicle.Handle, preferred, false);
                if (free) return preferred;
            }
            catch { }

            return FindAnyFreePassengerSeat(vehicle);
        }

        private void EnterPlayerVehicle(Ped officer)
        {
            var player = Game.Player.Character;
            if (player == null || !player.Exists()) return;
            if (!player.IsInVehicle()) return;

            var v = player.CurrentVehicle;
            if (v == null || !v.Exists()) return;

            // 已在同一辆车：不打断（避免反复开关门/抢座）
            try
            {
                if (officer.IsInVehicle() && officer.CurrentVehicle != null && officer.CurrentVehicle.Exists() && officer.CurrentVehicle.Handle == v.Handle)
                    return;
            }
            catch { }

            SetupOfficerAsSquad(officer);

            int seat = GetPreferredSeatForOfficer(officer, v);
            if (seat == int.MinValue) return;

            try { officer.Task.ClearAll(); } catch { }
            try { Function.Call(Hash.TASK_ENTER_VEHICLE, officer.Handle, v.Handle, -1, seat, 2.0f, 1, 0); } catch { }
        }

        private void ExitVehicle(Ped officer)
        {
            if (officer == null || !officer.Exists()) return;
            if (!officer.IsInVehicle()) return;

            try { Function.Call(Hash.TASK_LEAVE_VEHICLE, officer.Handle, officer.CurrentVehicle.Handle, 256); } catch { }
        }

        private bool SpawnSquadCarApproach()
        {
            var player = Game.Player.Character;
            if (player == null || !player.Exists()) return false;

            // 生成点：玩家后方远一点，保证可见且不会“刷没”
            Vector3 spawn = player.Position - player.ForwardVector * 80f;

            try
            {
                // 尽量落地
                var outPos = new OutputArgument();
                bool ok = Function.Call<bool>(Hash.GET_SAFE_COORD_FOR_PED, spawn.X, spawn.Y, spawn.Z, true, outPos, 0);
                if (ok) spawn = outPos.GetResult<Vector3>();
            }
            catch { }

            try
            {
                var vehModel = new Model(VehicleHash.Police);
                vehModel.Request(1000);
                if (!vehModel.IsLoaded) return false;

                Vehicle car = World.CreateVehicle(vehModel, spawn);
                vehModel.MarkAsNoLongerNeeded();
                if (car == null || !car.Exists()) return false;

                try { car.IsPersistent = true; } catch { }
                try { Function.Call(Hash.SET_ENTITY_AS_MISSION_ENTITY, car.Handle, true, true); } catch { }

                var pedModel = new Model(PedHash.Cop01SMY);
                pedModel.Request(1000);
                if (!pedModel.IsLoaded) return false;

                Ped driver = World.CreatePed(pedModel, spawn);
                Ped mate = World.CreatePed(pedModel, spawn);
                pedModel.MarkAsNoLongerNeeded();

                if (driver == null || !driver.Exists()) return false;
                if (mate == null || !mate.Exists()) return false;

                try { Function.Call(Hash.SET_ENTITY_AS_MISSION_ENTITY, driver.Handle, true, true); } catch { }
                try { Function.Call(Hash.SET_ENTITY_AS_MISSION_ENTITY, mate.Handle, true, true); } catch { }

                try { driver.SetIntoVehicle(car, VehicleSeat.Driver); } catch { }
                try { mate.SetIntoVehicle(car, VehicleSeat.Passenger); } catch { }

                ApplyWeaponPolicy(driver);
                ApplyWeaponPolicy(mate);

                _officers.Add(driver);
                _officers.Add(mate);

                SetupOfficerAsSquad(driver);
                SetupOfficerAsSquad(mate);

                // 驾驶到玩家附近
                Vector3 dest = player.Position + player.ForwardVector * 8f;
                try { Function.Call(Hash.TASK_VEHICLE_DRIVE_TO_COORD, driver.Handle, car.Handle, dest.X, dest.Y, dest.Z, 18.0f, 0, car.Model.Hash, 786468, 5.0f, 5.0f); } catch { }

                Notification.Show("~b~两名增援警员已驱车赶来");
                return true;
            }
            catch (Exception ex)
            {
                ModLog.Error("[OfficerSquadSystem] SpawnSquadCarApproach failed: " + ex);
                return false;
            }
        }

        private void SpawnOfficerOffscreen()
        {
            var player = Game.Player.Character;
            if (player == null || !player.Exists()) return;

            Vector3 spawn = player.Position - player.ForwardVector * 45f;

            // 1) 尽量找“视线外 + 室外 + 安全落脚点”
            try
            {
                Vector3 best = spawn;
                float dist = 45f;

                for (int i = 0; i < 12; i++)
                {
                    float ang = (float)(i * (Math.PI / 6.0));
                    Vector3 dir = new Vector3((float)Math.Cos(ang), (float)Math.Sin(ang), 0f);
                    Vector3 candidate = player.Position + dir * dist;

                    // 尽量在室外（interior id == 0）
                    int interior = 0;
                    try { interior = Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, candidate.X, candidate.Y, candidate.Z); } catch { interior = 0; }
                    if (interior != 0) continue;

                    // 尽量视线外
                    bool visible = false;
                    try { visible = Function.Call<bool>(Hash.IS_SPHERE_VISIBLE, candidate.X, candidate.Y, candidate.Z, 2.0f); } catch { visible = false; }
                    if (visible) continue;

                    // 安全坐标（onGround=true）
                    try
                    {
                        var outPos = new OutputArgument();
                        bool ok = Function.Call<bool>(Hash.GET_SAFE_COORD_FOR_PED, candidate.X, candidate.Y, candidate.Z, true, outPos, 0);
                        if (ok)
                        {
                            best = outPos.GetResult<Vector3>();
                            break;
                        }
                    }
                    catch { }

                    best = candidate;
                }

                spawn = best;
            }
            catch { }

            // 2) 生成 + 友好关系（防止电击玩家）
            try
            {
                var model = new Model(PedHash.Cop01SMY);
                model.Request(1000);
                if (!model.IsLoaded) return;

                var o = World.CreatePed(model, spawn);
                model.MarkAsNoLongerNeeded();
                if (o == null || !o.Exists()) return;

                // 关键：加入玩家编队，保证忠诚/听令/能上下车
                SetupOfficerAsSquad(o);

                ApplyWeaponPolicy(o);
                _officers.Add(o);

                // 让他跑向玩家
                try { Function.Call(Hash.TASK_GO_TO_ENTITY, o.Handle, player.Handle, -1, 2.0f, 2.0f, 1073741824, 0); } catch { }

                Notification.Show("~b~增援警员已出发");
            }
            catch (Exception ex)
            {
                ModLog.Error("[OfficerSquadSystem] SpawnOfficerOffscreen failed: " + ex);
            }
        }
    }
}