using System;
using System.IO;
using GTA;
using GTA.UI;

namespace EF.PoliceMod.Core
{
    public static class ModLog
    {
        private static readonly string LogPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TACTFR.log");

        public static bool Enabled = true;
        private static bool _initialized = false;
        private static bool _writeFailed = false;

        public static void Initialize()
        {
            if (_initialized) return;
            _initialized = true;

            try
            {
                var dir = Path.GetDirectoryName(LogPath);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                File.AppendAllText(LogPath, $"[{DateTime.Now:HH:mm:ss}] [INFO] TACTFR Log Initialized\n");
                _writeFailed = false;
            }
            catch (Exception ex)
            {
                _writeFailed = true;
                try
                {
                    Notification.Show("~r~TACTFR 日志初始化失败，日志将不可用");
                }
                catch { }
            }
        }

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
            if (!_initialized)
            {
                Initialize();
            }

            if (_writeFailed) return;

            try
            {
                File.AppendAllText(
                    LogPath,
                    $"[{DateTime.Now:HH:mm:ss}] [{level}] {message}\n"
                );
            }
            catch
            {
                _writeFailed = true;
            }
        }
    }
}
