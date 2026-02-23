using System.Collections.Generic;

namespace EF.PoliceMod.Core
{
    /// <summary>
    /// 每名嫌疑人的拘捕风格注册表（重构 Step1）：
    /// - 支持双嫌疑人不同风格
    /// - 当前阶段：只做存储，不改变旧行为；旧逻辑仍可继续读取 SuspectController.CurrentArrestStyle
    /// </summary>
    public sealed class SuspectStyleRegistry
    {
        private readonly Dictionary<int, ArrestActionStyle> _styleByHandle = new Dictionary<int, ArrestActionStyle>();

        public void SetStyle(int suspectHandle, ArrestActionStyle style)
        {
            if (suspectHandle <= 0) return;
            _styleByHandle[suspectHandle] = style;
        }

        public ArrestActionStyle GetStyleOrDefault(int suspectHandle, ArrestActionStyle fallback = ArrestActionStyle.CuffAndLead)
        {
            if (suspectHandle <= 0) return fallback;
            if (_styleByHandle.TryGetValue(suspectHandle, out var s)) return s;
            return fallback;
        }

        public void ClearStyle(int suspectHandle)
        {
            if (suspectHandle <= 0) return;
            _styleByHandle.Remove(suspectHandle);
        }

        public void ClearAll()
        {
            _styleByHandle.Clear();
        }
    }
}
