using EF.PoliceMod.Core;

namespace EF.PoliceMod.Systems
{
    /// <summary>
    /// 巡逻模式“搜查结果”独立系统：目前只做通知/留口子，避免混入案件系统。
    /// </summary>
    public sealed class PatrolSearchSystem
    {
        public PatrolSearchSystem()
        {
            EventBus.Subscribe<PatrolContrabandFoundEvent>(OnFound);
        }

        private void OnFound(PatrolContrabandFoundEvent e)
        {
            try
            {
                if (e.WeaponFound)
                    SmsNotification.Show("警务终端", "巡逻搜查", "记录：发现武器。");
                else
                    SmsNotification.Show("警务终端", "巡逻搜查", "记录：发现违禁品。");
            }
            catch { }
        }
    }
}
