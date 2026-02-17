namespace EF.PoliceMod.Core
{
    /// <summary>
    /// 功能总开关（保留接口/代码结构，便于后续快速恢复）。
    /// 当前版本默认关闭双人案件；F7 调度功能已恢复。
    /// </summary>
    public static class FeatureGates
    {
        public const bool EnableDualSuspectCase = false;
        public const bool EnableF7Convoy = false;
    }
}
