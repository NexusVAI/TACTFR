using EF.PoliceMod.Core;
using EF.PoliceMod.Gameplay;
using GTA;
using GTA.UI;

namespace EF.PoliceMod.Executors
{
    /// <summary>
    /// 车辆押送交互门禁（E 键）：
    /// - 被拷线（CuffAndLead）：必须 L 锁定 + 已拘捕
    /// - 抱头线（HandsOnHeadFollow）：默认同样要求 L+已拘捕，但允许 I 逼停线旁路
    /// </summary>
    internal static class VehicleEscortInteractGate
    {
        public static bool EnsureAllowed(
            ArrestActionStyle style,
            Ped suspect,
            bool pullOverBypassActive
        )
        {
            // 抱头线：允许两种入口
            // 1) I 逼停旁路激活（免 L+拘捕）
            // 2) 已 L 锁定到当前嫌疑人（不再强制必须“已拘捕”）
            if (style == ArrestActionStyle.HandsOnHeadFollow)
            {
                if (pullOverBypassActive) return true;

                try
                {
                    var core2 = EFCore.Instance;
                    var lts2 = core2 != null ? core2.LockTargetSystem : null;
                    if (lts2 != null
                        && lts2.HasTarget
                        && lts2.CurrentTarget != null
                        && lts2.CurrentTarget.Exists()
                        && suspect != null
                        && suspect.Exists()
                        && lts2.CurrentTarget.Handle == suspect.Handle)
                    {
                        return true;
                    }
                }
                catch { }

                Notification.Show("~y~需要先锁定当前嫌疑人（L）或先执行 I 逼停");
                return false;
            }

            // 其它情况：统一强制要求 L 锁定 + 已拘捕
            try
            {
                var core = EFCore.Instance;
                var lts = core != null ? core.LockTargetSystem : null;
                if (lts == null
                    || !lts.HasTarget
                    || !lts.IsCurrentTargetArrested
                    || lts.CurrentTarget == null
                    || !lts.CurrentTarget.Exists()
                    || suspect == null
                    || !suspect.Exists()
                    || lts.CurrentTarget.Handle != suspect.Handle)
                {
                    Notification.Show("~y~需要先锁定并拘捕嫌疑人（L 锁定，H 菜单拘捕）");
                    return false;
                }
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
