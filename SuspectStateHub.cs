using System;

namespace EF.PoliceMod.Core
{
    public class SuspectStateHub
    {
        private readonly StateMachine<SuspectState> _stateMachine;
        public int SuspectHandle { get; }

        public SuspectState CurrentState => _stateMachine.CurrentState;

        public event Action<SuspectState, SuspectState> OnStateChanged;
        public SuspectStateHub() : this(-1) { }

        public SuspectStateHub(int suspectHandle)
        {
            SuspectHandle = suspectHandle;
            _stateMachine = new StateMachine<SuspectState>(SuspectState.None);
            _stateMachine.OnStateChanged += HandleStateChanged;
        }

        private void HandleStateChanged(SuspectState oldState, SuspectState newState)
        {
            OnStateChanged?.Invoke(oldState, newState);
        }

        public void ChangeState(SuspectState newState)
        {
            var current = _stateMachine.CurrentState;

            if (!IsValidTransition(current, newState))
            {
                ModLog.Warn($"[StateHub] 无效转换: {current} → {newState} (已阻止)");
                return;
            }

            _stateMachine.ChangeState(newState);
        }

        private bool IsValidTransition(SuspectState from, SuspectState to)
        {
            if (from == to) return false;

            switch (from)
            {
                case SuspectState.None:
                    return to == SuspectState.Restrained
                        || to == SuspectState.Resisting;

                case SuspectState.Restrained:
                    return to == SuspectState.Escorting
                        || to == SuspectState.Resisting;

                case SuspectState.Escorting:
                    return to == SuspectState.EnteringVehicle
                        || to == SuspectState.Resisting;

                case SuspectState.EnteringVehicle:
                    return to == SuspectState.InVehicle;

                case SuspectState.InVehicle:
                    return to == SuspectState.ExitingVehicle;

                case SuspectState.ExitingVehicle:
                    return to == SuspectState.Escorting;

                case SuspectState.Resisting:
                    return to == SuspectState.Restrained;

                default:
                    return true;
            }
        }

        public bool Is(SuspectState state) => _stateMachine.CurrentState == state;

        public void Reset()
        {
            _stateMachine.ChangeState(SuspectState.None);
        }

        public void ResetTo(SuspectState state)
        {
            _stateMachine.ChangeState(state);
        }
    }
}
