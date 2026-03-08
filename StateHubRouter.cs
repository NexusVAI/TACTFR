using EF.PoliceMod.Core;

namespace EF.PoliceMod.Suspects
{
    public sealed class StateHubRouter
    {
        private readonly SuspectContextRegistry _ctxRegistry;
        private readonly SuspectStateHub _legacyHub;
        private readonly StateWriterGate _writerGate;

        public StateHubRouter(SuspectContextRegistry ctxRegistry, SuspectStateHub legacyHub, StateWriterGate writerGate)
        {
            _ctxRegistry = ctxRegistry;
            _legacyHub = legacyHub;
            _writerGate = writerGate;
        }

        public SuspectStateHub GetHubFor(int suspectHandle)
        {
            try
            {
                if (_writerGate == null || !_writerGate.AnyEnabled())
                {
                    return _legacyHub;
                }

                if (_ctxRegistry != null
                    && _ctxRegistry.TryGet(suspectHandle, out var ctx)
                    && ctx != null
                    && ctx.StateHub != null)
                {
                    return ctx.StateHub;
                }
            }
            catch { }
            return _legacyHub;
        }

        public SuspectStateHub GetLegacyHub() => _legacyHub;

        public SuspectStateHub GetWriterHubFor(int suspectHandle, SuspectState state)
        {
            try
            {
                if (_writerGate != null && _writerGate.AllowsPerHandleWrite(state))
                    return GetHubFor(suspectHandle);
            }
            catch { }
            return _legacyHub;
        }
    }
}
