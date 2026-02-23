
using EF.PoliceMod.Core;
using GTA;

namespace EF.PoliceMod.Suspects
{
    /// <summary>
    /// 嫌疑人运行时上下文（重构 Step1）：
    /// - 以 handle 为主键；不直接依赖 SuspectController 的“当前嫌疑人”单例字段
    /// - 支持每个嫌疑人独立风格（被拷线 / 举手线）、独立状态机
    /// - 当前阶段：仅作为数据容器，暂不接管旧逻辑
    /// </summary>
    public sealed class SuspectRuntimeContext
    {
        public int Handle { get; }
        public SuspectStateHub StateHub { get; }

        /// <summary>
        /// 每名嫌疑人独立的拘捕风格（未来会取代 SuspectController.CurrentArrestStyle 的单例实现）
        /// </summary>
        public ArrestActionStyle ArrestStyle { get; set; } = ArrestActionStyle.CuffAndLead;

        /// <summary>
        /// “E 前置 G”：该嫌疑人是否已被下达跟随指令（由 G 触发）
        /// </summary>
        public bool FollowRequested { get; set; } = false;

        /// <summary>
        /// 过渡态/关键任务门禁（避免重复 EnterVehicle/LeaveVehicle）
        /// </summary>
        public bool Busy { get; set; } = false;

        public int LastCommandAtMs { get; set; } = 0;

        public SuspectRuntimeContext(int handle)
        {
            Handle = handle;
            // Step4b：每个嫌疑人上下文持有自己的 StateHub（记录句柄归属）
            StateHub = new SuspectStateHub(handle);
        }


        public Ped TryResolvePed()
        {
            try
            {
                if (Handle <= 0) return null;
                // World.GetAllPeds() 成本较高，但 Step1 只用于少量调用与调试；后续可接 EntityTracker 缓存。
                foreach (var p in World.GetAllPeds())
                {
                    if (p != null && p.Exists() && p.Handle == Handle)
                        return p;
                }
            }
            catch { }
            return null;
        }
    }
}

