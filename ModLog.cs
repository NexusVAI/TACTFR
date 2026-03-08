using System;
using System.IO;
using System.Text;

namespace EF.PoliceMod.Core
{
    public static class ModLog
    {
        private static readonly string LogDir = AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string LogPath = Path.Combine(LogDir, "TACTFR.log");
        private static readonly string LogPathBackup = Path.Combine(LogDir, "TACTFR_prev.log");
        private static readonly object _lock = new object();
        private static readonly StringBuilder _buffer = new StringBuilder(4096);
        private const int FlushIntervalMs = 2000;
        public static bool Enabled = true;
        private static bool _initialized = false;
        private static string _activeLogPath = null;
        private static int _lastFlushAtTick = 0;

        public static void Initialize()
        {
            lock (_lock)
            {
                if (_initialized) return;
                _initialized = true;
                try
                {
                    if (File.Exists(LogPath))
                    {
                        try
                        {
                            if (File.Exists(LogPathBackup))
                                File.Delete(LogPathBackup);
                            File.Move(LogPath, LogPathBackup);
                        }
                        catch
                        {
                            try { File.Delete(LogPath); } catch { }
                        }
                    }
                }
                catch { }

                try
                {
                    File.WriteAllText(LogPath, $"=== TACTFR Log Started {DateTime.Now:yyyy-MM-dd HH:mm:ss} ===\n");
                    _activeLogPath = LogPath;
                }
                catch
                {
                    try
                    {
                        string fallback = Path.Combine(LogDir, $"TACTFR_{DateTime.Now:yyyyMMdd_HHmmss}.log");
                        File.WriteAllText(fallback, $"=== TACTFR Log Started {DateTime.Now:yyyy-MM-dd HH:mm:ss} (fallback) ===\n");
                        _activeLogPath = fallback;
                    }
                    catch
                    {
                        _activeLogPath = null;
                    }
                }
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
            Write("ERROR", message);
        }

        private static void Write(string level, string message)
        {
            lock (_lock)
            {
                try
                {
                    if (!_initialized) Initialize();
                    if (_activeLogPath == null) return;

                    _buffer.Append('[')
                        .Append(DateTime.Now.ToString("HH:mm:ss"))
                        .Append("] [")
                        .Append(level)
                        .Append("] ")
                        .Append(message)
                        .Append('\n');

                    int now = Environment.TickCount;
                    bool shouldFlush = level == "ERROR"
                        || now - _lastFlushAtTick >= FlushIntervalMs
                        || _buffer.Length > 4096;
                    if (shouldFlush)
                    {
                        FlushUnsafe();
                        _lastFlushAtTick = now;
                    }
                }
                catch
                {
                    if (level == "ERROR")
                    {
                        try { GTA.UI.Screen.ShowSubtitle($"~r~LOG: {message}", 2000); } catch { }
                    }
                }
            }
        }

        public static void Flush()
        {
            lock (_lock)
            {
                try
                {
                    if (!_initialized) Initialize();
                    if (_activeLogPath == null) return;
                    FlushUnsafe();
                }
                catch { }
            }
        }

        private static void FlushUnsafe()
        {
            if (_activeLogPath == null || _buffer.Length <= 0) return;
            try
            {
                File.AppendAllText(_activeLogPath, _buffer.ToString());
                _buffer.Clear();
                EnforceSizeLimitUnsafe();
            }
            catch { }
        }

        private static void EnforceSizeLimitUnsafe()
        {
            try
            {
                if (ModConfig.LogMaxSizeKB <= 0) return;
                var fi = new FileInfo(_activeLogPath);
                if (!fi.Exists) return;
                long maxBytes = ModConfig.LogMaxSizeKB * 1024L;
                if (fi.Length <= maxBytes) return;
                File.WriteAllText(
                    _activeLogPath,
                    $"=== TACTFR Log Truncated {DateTime.Now:yyyy-MM-dd HH:mm:ss} (MaxSizeKB={ModConfig.LogMaxSizeKB}) ===\n"
                );
            }
            catch { }
        }
    }
}
