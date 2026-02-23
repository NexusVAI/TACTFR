namespace EF.PoliceMod.Core
{
    /// <summary>
    /// 拘捕菜单确认后：把“本次选择的风格”绑定到“当前锁定的嫌疑人”。
    /// 重构 Step1：不改变旧的 AttemptArrestEvent 链路，只额外发布一次风格绑定事件。
    /// </summary>
    public readonly struct SuspectArrestStyleSelectedEvent
    {
        public int SuspectHandle { get; }
        public ArrestActionStyle Style { get; }

        public SuspectArrestStyleSelectedEvent(int suspectHandle, ArrestActionStyle style)
        {
            SuspectHandle = suspectHandle;
            Style = style;
        }
    }
}
