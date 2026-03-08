using System;

namespace EF.PoliceMod.Core
{
    public class StateMachine<T>
    {
        public T CurrentState { get; private set; }

        public event Action<T, T> OnStateChanged;

        public StateMachine(T initialState)
        {
            CurrentState = initialState;
        }

        public void ChangeState(T newState)
        {
            if (Equals(CurrentState, newState))
                return;

            T oldState = CurrentState;
            CurrentState = newState;
            FireStateChanged(oldState, newState);
        }

        public void ForceState(T newState)
        {
            T oldState = CurrentState;
            CurrentState = newState;
            if (!Equals(oldState, newState))
            {
                FireStateChanged(oldState, newState);
            }
        }

        private void FireStateChanged(T oldState, T newState)
        {
            var handlers = OnStateChanged;
            if (handlers == null) return;

            foreach (var del in handlers.GetInvocationList())
            {
                try
                {
                    if (del is Action<T, T> action)
                    {
                        action(oldState, newState);
                    }
                    else
                    {
                        // ���ջ��ˣ������ϲ���Ҫ��
                        del.DynamicInvoke(oldState, newState);
                    }
                }
                catch (Exception ex)
                {
                    // ��¼���󣬵���Ҫ�׳�
                    try { ModLog.Error($"[StateMachine] OnStateChanged handler threw: {ex}"); } catch { /* swallow */ }
                }
            }
        }
    }
}
