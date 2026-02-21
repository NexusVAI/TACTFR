using EF.PoliceMod.Core;
using EF.PoliceMod.Core.Contracts;
using EF.PoliceMod.Executors;
using EF.PoliceMod.Gameplay;
using EF.PoliceMod.Input;
using EFPoliceMod;
using GTA;
using GTA.Native;
using System;
//using static EF.PoliceMod.Core.SuspectEscortRequestEvent;


namespace EF.PoliceMod
{

    public class EFCore : Script
    {
        private EF.PoliceMod.Debug.DebugHud _debugHud;
        private OfficerState _currentOfficerState = OfficerState.Idle;
        private bool _lawAuthorityActive = false;
        private BehaviorKeeper _behaviorKeeper;
      
        private SuspectVehicleEscortExecutor _suspectVehicleEscortExecutor;
        private SuspectOnFootExecutor _suspectOnFootExecutor;
        private SuspectStateHub _suspectStateHub;
        private EF.PoliceMod.Data.WantedRegistry _wantedRegistry;
        private EF.PoliceMod.Systems.PoliceTerminalController _terminalController;


        public static EFCore Instance { get; private set; }
        private SuspectController _suspectController;
        public SuspectController GetSuspectController()
        {
          

            return _suspectController;
        }

        public LockTargetSystem LockTargetSystem { get; private set; }
        public StateMachine<OfficerState> OfficerStateMachine { get; private set; }
        private DutyLifecycleController _dutyController;
        private CaseManager _caseManager;
        // Help controller: 负责处理 F10 的帮助显示
        private EF.PoliceMod.Core.HelpController _helpController;

        private InputManager _input;
        private DeliverSystem _deliverSystem;
        private EF.PoliceMod.Systems.PullOverSystem _pullOverSystem;
        private EF.PoliceMod.Systems.DispatchSupportSystem _dispatchSupport;
        private EF.PoliceMod.Systems.DispatchMenuController _dispatchMenu;
        private EF.PoliceMod.Systems.HeliReconSystem _heliRecon;
        private EF.PoliceMod.Systems.DualSuspectCoordinator _dualSuspect;
        private EF.PoliceMod.Systems.ArrestMenuController _arrestMenu;

        private EF.PoliceMod.Systems.CuffingSequenceSystem _cuffSeq;
        private EF.PoliceMod.Systems.PoliceUniformSystem _uniformSystem;
        private EF.PoliceMod.Systems.OfficerSquadSystem _officerSquad;
        private EF.PoliceMod.Systems.OfficerSquadMenuController _officerSquadMenu;
        private EF.PoliceMod.Systems.SquadStatusHud _squadHud;
        private EF.PoliceMod.Systems.ArrestSuppressionSystem _arrestSuppression;
        private EF.PoliceMod.Systems.PatrolSystem _patrol;


        private EF.PoliceMod.Systems.PatrolFleeSystem _patrolFlee;
        private EF.PoliceMod.Systems.PatrolResistSystem _patrolResist;

        private EF.PoliceMod.Systems.PatrolSearchSystem _patrolSearch;
        private bool _patrolEnabled = false;
        public bool IsPatrolEnabled => _patrolEnabled;
        private EF.PoliceMod.Systems.PatrolMenuController _patrolMenu;

        private EF.PoliceMod.Systems.DutyCleanupService _dutyCleanup;

        private EF.PoliceMod.Systems.DutyStateService _dutyState;

        private EF.PoliceMod.Systems.PlayerRespawnFixSystem _respawnFix;

        public EFCore()
        {
            try
            {
                // 在 EFCore() 构造里最开始处加入：
                try
                {
                    AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
                    {
                        try
                        {
                            var ex = args.ExceptionObject as Exception;
                            ModLog.Error("[EFCore] UnhandledException: " + (ex?.ToString() ?? args.ExceptionObject.ToString()));
                        }
                        catch { /* 防止二次抛出 */ }
                    };
                }
                catch (Exception) { /* best effort */ }

            ModLog.Info("EFCore initialized");
            Instance = this;

            var _dutyQueryInit = EF.PoliceMod.Systems.DutyQuery.IsOnDuty;

            _caseManager = new CaseManager();
            _dutyController = new DutyLifecycleController();
            _input = new InputManager();   // ✅【必须加】

            _dutyState = new EF.PoliceMod.Systems.DutyStateService();
            EventBus.Subscribe<DutyStartedEvent>(_ =>
            {
                ModLog.Info("DutyStarted");
                _lawAuthorityActive = true;
                EnableLawAuthority();
            });


            EventBus.Subscribe<DutyEndedEvent>(_ =>
            {
                ModLog.Info("DutyEnded");
                _lawAuthorityActive = false;
                DisableLawAuthority();
            });

            _wantedRegistry = new EF.PoliceMod.Data.WantedRegistry();
            _terminalController = new EF.PoliceMod.Systems.PoliceTerminalController(_wantedRegistry);
            _helpController = new EF.PoliceMod.Core.HelpController();
            _suspectStateHub = new SuspectStateHub();
            _suspectController = new SuspectController();

            // 步行执行器（监听 SuspectStateHub + 每帧牵引维护）
            _suspectOnFootExecutor = new SuspectOnFootExecutor(
                _suspectController,
                _suspectStateHub
            );



            // —— 确保 SuspectResistEvent 被订阅 ——
            // 当有人发布 SuspectResistEvent 且目标是当前被控制嫌疑人，
            // 我们把 SuspectState 切到 Resisting，交给 Executor 执行行为。
            EventBus.Subscribe<EF.PoliceMod.Input.SuspectResistEvent>(e =>
            {
                try
                {
                    if (e.Suspect == null || !e.Suspect.Exists())
                    {
                        ModLog.Info("[EFCore] SuspectResistEvent ignored: event suspect invalid");
                        return;
                    }

                    var current = _suspectController.GetCurrentSuspect();
                    if (current == null || !current.Exists() || current.Handle != e.Suspect.Handle)
                    {
                        ModLog.Info("[EFCore] SuspectResistEvent ignored: not matching current suspect");
                        return;
                    }

                    // 反抗必须优先：哪怕之前被标记 busy（例如拘捕流程里），也要先解除 busy 再切状态。
                    try { _suspectController.UnmarkBusy(current.Handle); } catch { }

                    if (_suspectStateHub.Is(SuspectState.Resisting))
                    {
                        ModLog.Info("[EFCore] SuspectResistEvent ignored: already Resisting");
                        return;
                    }

                    _suspectStateHub.ChangeState(SuspectState.Resisting);
                    ModLog.Info("[EFCore] Event -> State: SuspectResistEvent -> Resisting");
                }
                catch (Exception ex)
                {
                    ModLog.Error("[EFCore] SuspectResistEvent handler exception: " + ex);
                }
            });
            // 实例化并保存：车辆上下车执行器（构造中会 Subscribe EscortVehicleInteractEvent、并监听 StateHub）
            _suspectVehicleEscortExecutor = new SuspectVehicleEscortExecutor(
                _suspectController,
                _suspectStateHub
            );

            // 事件 → 状态 映射：把 gameplay 事件映射为 SuspectStateHub 的状态变更
            // 这样：SuspectEscortBeginEvent 发布后，状态机会进入 Escorting，从而触发 OnFootExecutor 的 StartFollow
            EventBus.Subscribe<EF.PoliceMod.Input.SuspectEscortBeginEvent>(_ =>
            {
                _suspectStateHub.ChangeState(SuspectState.Escorting);
                ModLog.Info("[EFCore] Event -> State: SuspectEscortBeginEvent -> Escorting");
            });



            // 把 SuspectArrestedEvent 映射为 Restrained（与 OnFootExecutor 的 case 对应）
            // 注意：事件类型在 EF.PoliceMod.Core 命名空间（SuspectController 发布的也是这个）
            EventBus.Subscribe<EF.PoliceMod.Core.SuspectArrestedEvent>(_ =>
            {
                try
                {
                    _suspectStateHub.ChangeState(SuspectState.Restrained);
                    ModLog.Info("[EFCore] Event -> State: SuspectArrestedEvent -> Restrained");
                }
                catch (Exception ex)
                {
                    ModLog.Error("[EFCore] SuspectArrestedEvent handler exception: " + ex);
                }
            });





            LockTargetSystem = new LockTargetSystem(_suspectController);
            LockTargetSystem.Initialize();

   
            _behaviorKeeper = new BehaviorKeeper();


         

            _deliverSystem = new DeliverSystem(LockTargetSystem);
            _deliverSystem.Initialize();


            // 统一清理服务：收敛“交付/下班无遗留”逻辑，减少 EFCore 粘连
            _dutyCleanup = new EF.PoliceMod.Systems.DutyCleanupService(
                LockTargetSystem,
                _suspectController,
                _suspectStateHub,
                _behaviorKeeper
            );


            // 切模型后死亡无法重生：稳定兜底
            _respawnFix = new EF.PoliceMod.Systems.PlayerRespawnFixSystem();

            // I 键逼停（嫌疑人驾车逃逸）—— 必须保存实例并在 OnTick 驱动 TickUpdate，否则停稳检测不会更新
            _pullOverSystem = new EF.PoliceMod.Systems.PullOverSystem(_suspectController);

            // F7 调度菜单 / 双嫌疑人：当前版本关闭（保留接口待后续重启）
            if (EF.PoliceMod.Core.FeatureGates.EnableF7Convoy)
            {
                _dispatchSupport = new EF.PoliceMod.Systems.DispatchSupportSystem();
                _dispatchMenu = new EF.PoliceMod.Systems.DispatchMenuController(_dispatchSupport);
            }
            _heliRecon = new EF.PoliceMod.Systems.HeliReconSystem();
            if (EF.PoliceMod.Core.FeatureGates.EnableDualSuspectCase)
            {
                _dualSuspect = new EF.PoliceMod.Systems.DualSuspectCoordinator();
            }



            // H 拘捕动作菜单
            _arrestMenu = new EF.PoliceMod.Systems.ArrestMenuController();
            // 上拷演出系统
            _cuffSeq = new EF.PoliceMod.Systems.CuffingSequenceSystem();

            // 警服更换点（警局内蓝色圈+衣服图标 blip）
            _uniformSystem = new EF.PoliceMod.Systems.PoliceUniformSystem();

            // 警员小队系统（F8 菜单 + AI + HUD）
            _officerSquad = new EF.PoliceMod.Systems.OfficerSquadSystem(_suspectController, LockTargetSystem);
            _officerSquadMenu = new EF.PoliceMod.Systems.OfficerSquadMenuController(_officerSquad);
            _squadHud = new EF.PoliceMod.Systems.SquadStatusHud(_officerSquad);
            EventBus.Subscribe<OfficerSquadSummonRequestedEvent>(_ =>
            {
                try { _officerSquad?.SummonIfNeeded(2); } catch { }
            });

            _arrestSuppression = new EF.PoliceMod.Systems.ArrestSuppressionSystem(_officerSquad, _suspectController, LockTargetSystem);
            _patrol = new EF.PoliceMod.Systems.PatrolSystem(LockTargetSystem);


            _patrolFlee = new EF.PoliceMod.Systems.PatrolFleeSystem();
            _patrolResist = new EF.PoliceMod.Systems.PatrolResistSystem();

            _patrolSearch = new EF.PoliceMod.Systems.PatrolSearchSystem();
            _patrolMenu = new EF.PoliceMod.Systems.PatrolMenuController();
            EventBus.Subscribe<EF.PoliceMod.Core.TogglePatrolModeEvent>(_ =>
            {
                _patrolEnabled = !_patrolEnabled;
                EventBus.Publish(new EF.PoliceMod.Core.PatrolModeToggledEvent(_patrolEnabled));
                try { GTA.UI.Notification.Show(_patrolEnabled ? "~g~巡逻模式：开启" : "~y~巡逻模式：关闭"); } catch { }
            });

            Tick += OnTick;
            Aborted += OnAborted;

            RegisterSystemsToCompositionRoot();

            var _initCaseStatusQuery = EF.PoliceMod.Systems.CaseStatusQuery.HasActiveCase;
            var _initTerminalAccessQuery = EF.PoliceMod.Systems.TerminalAccessQuery.CanOpenTerminal;

            GTA.UI.Notification.Show("5.3.99-TACTFR警察模组加载成功！玩家动力@某宇原创制作 最后更新时间2026/02/16，祝大家新年快乐~模组QQ反馈群1079691553");
            ModLog.Info("[EFCore] EF Police Mod v5.3.99 loaded");
            }
            catch (Exception ex)
            {
                try { ModLog.Error("[EFCore] Constructor failed: " + ex); } catch { }
                try { GTA.UI.Notification.Show("~r~警察模组初始化失败，已写入 EF_PoliceMod.log"); } catch { }
            }
        }

        public CaseManager GetCaseManager()
        {
            return _caseManager;
        }

        public EF.PoliceMod.Systems.OfficerSquadSystem GetOfficerSquad()
        {
            return _officerSquad;
        }

        public EF.PoliceMod.Systems.DispatchSupportSystem GetDispatchSupport()
        {
            return _dispatchSupport;
        }

        public DutyLifecycleController GetDutyController()
        {
            return _dutyController;
        }



        private bool _lastDutyState = false;

        private int _lastWantedEnforceAtMs = 0;
        private const int WantedEnforceIntervalMs = 750;

        private void EnableLawAuthority()
        {
            // 目标：只要在执勤，就无论什么模型/状态，强制禁用通缉（best-effort，多路兜底）
            try { Function.Call(Hash.SET_MAX_WANTED_LEVEL, 0); } catch { }
            try { Function.Call(Hash.SET_WANTED_LEVEL_MULTIPLIER, 0.0f); } catch { }

            try
            {
                // 禁用调度派警（对单机有效）
                Function.Call(Hash.SET_DISPATCH_COPS_FOR_PLAYER, Game.Player.Handle, false);
            }
            catch { }

            try
            {
                // 让警察忽略玩家（对“瞬间加星”更有效）
                Function.Call(Hash.SET_POLICE_IGNORE_PLAYER, Game.Player.Handle, true);
            }
            catch { }

            try
            {
                Function.Call(Hash.SET_PLAYER_WANTED_LEVEL, Game.Player.Handle, 0, false);
                Function.Call(Hash.SET_PLAYER_WANTED_LEVEL_NOW, Game.Player.Handle, false);
                Function.Call(Hash.CLEAR_PLAYER_WANTED_LEVEL, Game.Player.Handle);
            }
            catch { }

            try { Game.Player.WantedLevel = 0; } catch { }

            _lastWantedEnforceAtMs = 0;
        }

        private void DisableLawAuthority()
        {
            // 恢复原生通缉系统（best-effort）
            try { Function.Call(Hash.SET_MAX_WANTED_LEVEL, 5); } catch { }
            try { Function.Call(Hash.SET_WANTED_LEVEL_MULTIPLIER, 1.0f); } catch { }

            try { Function.Call(Hash.SET_DISPATCH_COPS_FOR_PLAYER, Game.Player.Handle, true); } catch { }
            try { Function.Call(Hash.SET_POLICE_IGNORE_PLAYER, Game.Player.Handle, false); } catch { }
        }
        public SuspectStateHub GetSuspectStateHub()
        {
            return _suspectStateHub;
        }

        private void OnTick(object sender, EventArgs e)
        {
            Ped player = Game.Player.Character;

            // 玩家死亡时由 DutyLifecycleController / PlayerRespawnFixSystem 处理，
            // 这里不要每帧广播 DutyEndedEvent，避免事件风暴。

            if (_lawAuthorityActive)
            {
                // 有些情况下 MaxWantedLevel 会被别的脚本/任务改回去，这里定期重申一次
                int now = Game.GameTime;
                if (now - _lastWantedEnforceAtMs >= WantedEnforceIntervalMs)
                {
                    _lastWantedEnforceAtMs = now;
                    try { EnableLawAuthority(); } catch { }
                }

                try
                {
                    if (Game.Player.WantedLevel > 0)
                        Game.Player.WantedLevel = 0;
                }
                catch { }
            }

            // input 仍直接 update（已在 InputManager 内部保护）
            try { _input?.Update(); } catch (Exception ex) { ModLog.Error("[EFCore] Input.Update exception: " + ex); }

            // Duty controller 本身应有保护
            try { _dutyController?.Tick(); } catch (Exception ex) { ModLog.Error("[EFCore] DutyController.Tick exception: " + ex); }

            // LockTargetSystem（native 操作密集）包一层保护
            try
            {
                LockTargetSystem?.Update();
            }
            catch (Exception ex)
            {
                ModLog.Error("[EFCore] LockTargetSystem.Update exception: " + ex);
            }

            // 车辆押送执行器：用于每帧确认 EnteringVehicle/InVehicle 与 ExitingVehicle/Escorting 过渡完成
            try { _suspectVehicleEscortExecutor?.TickUpdate(); } catch (Exception ex) { ModLog.Error("[EFCore] SuspectVehicleEscortExecutor.TickUpdate exception: " + ex); }

            // 步行押送牵引维护（Escorting 状态：持续跟随/防打断/距离过远自动拉回）
            try { _suspectOnFootExecutor?.TickUpdate(); } catch (Exception ex) { ModLog.Error("[EFCore] SuspectOnFootExecutor.TickUpdate exception: " + ex); }

            // 行为 keeper
            try { _behaviorKeeper?.Update(); } catch (Exception ex) { ModLog.Error("[EFCore] BehaviorKeeper.Update exception: " + ex); }

            // Deliver system
            try { _deliverSystem?.Update(); } catch (Exception ex) { ModLog.Error("[EFCore] DeliverSystem.Update exception: " + ex); }

            // PullOver system
            try { _pullOverSystem?.TickUpdate(); } catch (Exception ex) { ModLog.Error("[EFCore] PullOverSystem.TickUpdate exception: " + ex); }

            // Dispatch backup AI（当前版本关闭）
            if (EF.PoliceMod.Core.FeatureGates.EnableF7Convoy)
            {
                try { _dispatchSupport?.TickUpdate(); } catch (Exception ex) { ModLog.Error("[EFCore] DispatchSupport.TickUpdate exception: " + ex); }
            }

            // Menus
            if (EF.PoliceMod.Core.FeatureGates.EnableF7Convoy)
            {
                try { _dispatchMenu?.Tick(); } catch (Exception ex) { ModLog.Error("[EFCore] DispatchMenu.Tick exception: " + ex); }
            }
            try { _heliRecon?.Tick(); } catch (Exception ex) { ModLog.Error("[EFCore] HeliRecon.Tick exception: " + ex); }
            try { _arrestMenu?.Tick(); } catch (Exception ex) { ModLog.Error("[EFCore] ArrestMenu.Tick exception: " + ex); }
            // 双嫌疑人专项链路（当前版本关闭，保留接口）
            if (EF.PoliceMod.Core.FeatureGates.EnableDualSuspectCase)
            {
                try { _dualSuspect?.Tick(); } catch (Exception ex) { ModLog.Error("[EFCore] DualSuspectCoordinator.Tick exception: " + ex); }
            }
            // Cuffing sequence

            try { _cuffSeq?.Tick(); } catch (Exception ex) { ModLog.Error("[EFCore] CuffingSequence.Tick exception: " + ex); }

            // Uniform system
            try { _uniformSystem?.Tick(); } catch (Exception ex) { ModLog.Error("[EFCore] UniformSystem.Tick exception: " + ex); }

            // Officer squad (AI + menu + HUD)
            try { _officerSquad?.Tick(); } catch (Exception ex) { ModLog.Error("[EFCore] OfficerSquad.Tick exception: " + ex); }
            try { _officerSquadMenu?.Tick(); } catch (Exception ex) { ModLog.Error("[EFCore] OfficerSquadMenu.Tick exception: " + ex); }
            try { _squadHud?.Tick(); } catch (Exception ex) { ModLog.Error("[EFCore] SquadHud.Tick exception: " + ex); }
            try { _arrestSuppression?.Tick(); } catch (Exception ex) { ModLog.Error("[EFCore] ArrestSuppression.Tick exception: " + ex); }
            try { _patrol?.Tick(); } catch (Exception ex) { ModLog.Error("[EFCore] Patrol.Tick exception: " + ex); }
            try { _patrolMenu?.Tick(); } catch (Exception ex) { ModLog.Error("[EFCore] PatrolMenu.Tick exception: " + ex); }

            // 其他系统（受保护调用，避免任何异常冒泡）
            try { _caseManager.OnTick(); } catch (Exception ex) { ModLog.Error("[EFCore] CaseManager.OnTick exception: " + ex); }
            try { _terminalController?.Tick(); } catch (Exception ex) { ModLog.Error("[EFCore] TerminalController.Tick exception: " + ex); }

            // NOTE: Removed duplicate calls to _caseManager.OnTick() and _terminalController?.Tick()
            // to prevent double execution and potential side-effects.


            // 切模型后死亡卡重生：稳定兜底（放最后）
            try { _respawnFix?.Tick(); } catch { }
        }



        public void EndCurrentDuty(DutyEndReason reason)
        {
            GTA.UI.Notification.Show($"~r~执法结束：{reason}");

            // 通知 CaseManager：执法被强制结束
            // B 阶段不需要 CaseManager 处理下班原因


            // Core 层只负责收尾，不管案件逻辑
            LockTargetSystem?.ForceClear();
            _suspectController?.ForceClear();
        }






        private void OnOfficerStateChanged(
       OfficerState oldState, OfficerState newState)
        {
            _currentOfficerState = newState;
        }


        private void OnAborted(object sender, EventArgs e)
        {
            ModLog.Warn("EFCore aborted / unloaded");

            try
            {
                CompositionRoot.Instance.ShutdownAll();
            }
            catch (Exception ex)
            {
                ModLog.Error("[EFCore] CompositionRoot.ShutdownAll failed: " + ex);
            }

            LockTargetSystem?.Shutdown();
            EventBus.ClearAll();
            _deliverSystem?.Shutdown();
        }

        private void RegisterSystemsToCompositionRoot()
        {
            ModLog.Info("[EFCore] Registering systems to CompositionRoot...");

            var root = CompositionRoot.Instance;

            if (_dutyController is ISystem dutySystem)
                root.RegisterSystem(dutySystem);

            if (_caseManager is ISystem caseSystem)
                root.RegisterSystem(caseSystem);

            if (_suspectController is ISystem suspectSystem)
                root.RegisterSystem(suspectSystem);

            if (_patrol is ISystem patrolSystem)
                root.RegisterSystem(patrolSystem);

            if (EF.PoliceMod.Core.FeatureGates.EnableF7Convoy && _dispatchSupport is ISystem dispatchSystem)
                root.RegisterSystem(dispatchSystem);


            // 双嫌疑人专项链路（阶段A）
            if (EF.PoliceMod.Core.FeatureGates.EnableDualSuspectCase && _dualSuspect is ISystem dualSystem)
                root.RegisterSystem(dualSystem);



            root.InitializeAll();

            ModLog.Info($"[EFCore] CompositionRoot initialized with {root.SystemCount} systems");
        }
    }
}
