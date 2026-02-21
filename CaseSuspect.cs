using GTA.Math;

namespace EF.PoliceMod.Core
{
    public enum CaseSuspectStatus
    {
        Active = 0,
        Delivered = 1,
        Dead = 2,
        Escaped = 3
    }

    /// <summary>
    /// 案件嫌疑人数据（5.4.0 Step1）
    /// - 先用于 CaseManager 的双人交付判定，不改 UI 表现。
    /// </summary>
    public sealed class CaseSuspect
    {
        public int Handle { get; set; }
        public int SlotIndex { get; set; }
        public bool IsPrimary { get; set; }
        public CaseSuspectStatus Status { get; set; }
        public Vector3 LastKnownPos { get; set; }

        public bool IsResolved =>
            Status == CaseSuspectStatus.Delivered ||
            Status == CaseSuspectStatus.Dead ||
            Status == CaseSuspectStatus.Escaped;
    }
}
