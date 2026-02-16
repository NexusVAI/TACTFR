using EF.PoliceMod.Core;
using EF.PoliceMod.Gameplay;
using GTA;
using GTA.Native;
using System;
using System.Collections.Generic;

namespace EF.PoliceMod.Executors
{
    /// <summary>
    /// 嫌疑人跟随/停止跟随的任务封装。
    /// 注意：这里只做 native 任务下达与 busy 标记的 best-effort 维护。
    /// </summary>
    internal static class SuspectFollowOps
    {
        private static readonly Dictionary<int, int> _busyTimestamps = new Dictionary<int, int>();
        private const int BUSY_TIMEOUT_MS = 8000;
        public static void StartFollow(SuspectController suspectController, Ped suspect, ArrestActionStyle style)
        {
            if (suspectController == null) return;
            if (suspect == null || !suspect.Exists()) return;
            if (suspect.IsDead) return;

            try
            {
                // 若已经 busy，则检查是否超时，若超时则强制覆盖
                if (suspectController.IsBusy(suspect))
                {
                    int now = Game.GameTime;
                    if (_busyTimestamps.TryGetValue(suspect.Handle, out int ts) && now - ts > BUSY_TIMEOUT_MS)
                    {
                        ModLog.Info($"[Escort] StartFollow: busy timeout, forcing follow for suspect {suspect.Handle}");
                        try { suspectController.UnmarkBusy(suspect.Handle); } catch { }
                        _busyTimestamps.Remove(suspect.Handle);
                    }
                    else
                    {
                        ModLog.Info($"[Escort] StartFollow skipped: suspect {suspect.Handle} is busy");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                ModLog.Error("[Escort] StartFollow IsBusy check failed: " + ex);
            }

            var player = Game.Player.Character;
            if (player == null || !player.Exists())
            {
                ModLog.Warn("[Escort] StartFollow aborted: player invalid");
                try { suspectController.UnmarkBusy(suspect.Handle); } catch { }
                return;
            }

            try
            {
                // 标记 busy：防止其它逻辑破坏任务
                try { suspectController.MarkBusy(suspect.Handle); } catch { }
                _busyTimestamps[suspect.Handle] = Game.GameTime;

                try
                {
                    // ★修复：如果嫌疑人刚被小队上拷，仍处于同步场景/站立任务，
                    // 不先清任务会导致按 G “没反应”。
                    try { Function.Call(Hash.CLEAR_PED_TASKS_IMMEDIATELY, suspect.Handle); } catch { }

                    if (style == ArrestActionStyle.CuffAndLead)
                    {
                        try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, true); } catch { }
                        try { Function.Call(Hash.SET_ENABLE_BOUND_ANKLES, suspect.Handle, true); } catch { }
                        try
                        {
                            Function.Call(Hash.REQUEST_ANIM_DICT, "mp_arresting");
                            if (Function.Call<bool>(Hash.HAS_ANIM_DICT_LOADED, "mp_arresting"))
                            {
                                Function.Call(Hash.TASK_PLAY_ANIM, suspect.Handle, "mp_arresting", "idle", 4.0f, -4.0f, -1, 49, 0.0f, false, false, false);
                            }
                        }
                        catch { }
                    }
                    else
                    {
                        try { Function.Call(Hash.SET_ENABLE_HANDCUFFS, suspect.Handle, false); } catch { }
                        try { Function.Call(Hash.SET_ENABLE_BOUND_ANKLES, suspect.Handle, false); } catch { }
                    }

                    // TASK.md: offsetY 负值=在玩家身后；timeout=-1；persistFollowing=true
                    float offY = style == ArrestActionStyle.CuffAndLead ? -0.9f : -1.35f;
                    float speed = style == ArrestActionStyle.CuffAndLead ? 1.2f : 1.0f;
                    float stopRange = style == ArrestActionStyle.CuffAndLead ? 0.9f : 1.35f;
                    Function.Call(Hash.TASK_FOLLOW_TO_OFFSET_OF_ENTITY, suspect.Handle, player.Handle, 0f, offY, 0f, speed, -1, stopRange, true);
                    ModLog.Info($"[Escort] StartFollow issued (handle={suspect.Handle})");
                }
                catch (Exception exTask)
                {
                    ModLog.Error("[Escort] StartFollow native call failed: " + exTask);
                    // 失败时取消 busy，防止永远被标记
                    try { suspectController.UnmarkBusy(suspect.Handle); } catch { }
                    return;
                }
            }
            catch (Exception ex)
            {
                ModLog.Error("[Escort] StartFollow error: " + ex);
                try { suspectController.UnmarkBusy(suspect.Handle); } catch { }
            }
        }

        public static void StopFollow(SuspectController suspectController, Ped suspect)
        {
            if (suspectController == null) return;
            if (suspect == null || !suspect.Exists()) return;

            try
            {
                // 如果嫌疑人不是 busy，则只是清任务；如果 busy，依然先尝试清任务，但不强行解除其它 owner 的 busy
                try { Function.Call(Hash.CLEAR_PED_TASKS, suspect.Handle); } catch (Exception ex) { ModLog.Error("[Escort] CLEAR_PED_TASKS failed: " + ex); }
                ModLog.Info($"[Escort] StopFollow issued (handle={suspect.Handle})");
            }
            catch (Exception ex)
            {
                ModLog.Error("[Escort] StopFollow error: " + ex);
            }
            finally
            {
                try { suspectController.UnmarkBusy(suspect.Handle); } catch { }
                _busyTimestamps.Remove(suspect.Handle);
            }
        }
    }
}