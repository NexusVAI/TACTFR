using System;
using System.IO;
using GTA;

namespace EF.PoliceMod.Core
{
    public static class ModLog
    {
        private static readonly string LogPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TACTFR.log");

        public static bool Enabled = true;

        public static void Info(string message)
        {
            if (!Enabled) return;
            Write("INFO", message);
        }

        public static void Warn(string message)
        {
            if (!Enabled) return;
            Write("WARN", message);
        }

        public static void Error(string message)
        {
            if (!Enabled) return;
            Write("ERROR", message);
        }

        private static void Write(string level, string message)
        {
            try
            {
                File.AppendAllText(
                    LogPath,
                    $"[{DateTime.Now:HH:mm:ss}] [{level}] {message}\n"
                );
            }
            catch
            {
                // ❗日志系统唯一允许 swallow 的地方
                // 防止 IO 错误导致游戏崩
            }
        }
    }
}
