
using System.Collections.Generic;

namespace EF.PoliceMod.Suspects
{
    /// <summary>
    /// 嫌疑人上下文注册表（重构 Step1）：
    /// - 以 handle -> SuspectRuntimeContext 映射
    /// - 当前阶段：仅提供创建/查询/移除，不主动驱动旧系统
    /// </summary>
    public sealed class SuspectContextRegistry
    {
        private readonly Dictionary<int, SuspectRuntimeContext> _byHandle = new Dictionary<int, SuspectRuntimeContext>();

        public SuspectRuntimeContext GetOrCreate(int handle)
        {
            if (handle <= 0) return null;
            if (_byHandle.TryGetValue(handle, out var ctx)) return ctx;
            ctx = new SuspectRuntimeContext(handle);
            _byHandle[handle] = ctx;
            return ctx;
        }


        /// <summary>
        /// Step4c/Step6 预留：当句柄列表变化时，确保所有嫌疑人上下文都已创建。
        /// </summary>
        public void EnsureAll(System.Collections.Generic.IReadOnlyList<int> handles)
        {
            if (handles == null) return;
            for (int i = 0; i < handles.Count; i++)
            {
                int h = handles[i];
                if (h > 0) GetOrCreate(h);
            }
        }

        public bool TryGet(int handle, out SuspectRuntimeContext ctx)
        {
            ctx = null;
            if (handle <= 0) return false;
            return _byHandle.TryGetValue(handle, out ctx);
        }

        public void Remove(int handle)
        {
            if (handle <= 0) return;
            _byHandle.Remove(handle);
        }

        public void Clear()
        {
            _byHandle.Clear();
        }
    }
}

