namespace EF.PoliceMod.Core
{
    /// <summary>
    /// 功能总开关（保留接口/代码结构，便于后续快速恢复）。
    /// 当前版本按产品要求默认关闭：双人案件、F7 车队调度。
    /// </summary>
    public static class FeatureGates
    {
        public const bool EnableDualSuspectCase = false;
        public const bool EnableF7Convoy = false;
    }
}
