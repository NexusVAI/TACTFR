
using EF.PoliceMod.Core;

namespace EF.PoliceMod.Suspects
{
    /// <summary>
    /// 迁移期写入门禁：控制哪些状态允许写入 per-handle hub。
    /// 目的：避免 legacy hub 与 per-handle hub 同时“写同一状态”导致冲突。
    /// </summary>
    public sealed class StateWriterGate
    {
        public bool UsePerHandleForEscorting { get; set; } = false;
        public bool UsePerHandleForEnteringVehicle { get; set; } = false;
        public bool UsePerHandleForInVehicle { get; set; } = false;
        public bool UsePerHandleForExitingVehicle { get; set; } = false;
        public bool UsePerHandleForRestrained { get; set; } = false;
        public bool UsePerHandleForResisting { get; set; } = false;

        public bool AllowsPerHandleWrite(SuspectState state)
        {
            switch (state)
            {
                case SuspectState.Escorting: return UsePerHandleForEscorting;
                case SuspectState.EnteringVehicle: return UsePerHandleForEnteringVehicle;
                case SuspectState.InVehicle: return UsePerHandleForInVehicle;
                case SuspectState.ExitingVehicle: return UsePerHandleForExitingVehicle;
                case SuspectState.Restrained: return UsePerHandleForRestrained;
                case SuspectState.Resisting: return UsePerHandleForResisting;
                default:
                    return false;
            }
        }
    }
}

