using System;
using System.IO;
using GTA;
using GTA.UI;

namespace EF.PoliceMod.Core
{
    public static class ModLog
    {
        private static readonly string LogDir =
            AppDomain.CurrentDomain.BaseDirectory;

        private static readonly string LogPath =
            Path.Combine(LogDir, "TACTFR.log");

        private static readonly string LogPathBackup =
            Path.Combine(LogDir, "TACTFR_prev.log");

        public static bool Enabled = true;

        private static bool _initialized = false;
        private static bool _fileBroken = false;
        private static readonly object _lock = new object();

        private static void EnsureInitialized()
        {
            if (_initialized) return;
            _initialized = true;

            try
            {
                // 如果旧日志存在且被锁定，重命名或删除它
                if (File.Exists(LogPath))
                {
                    try
                    {
                        // 尝试将旧日志重命名为备份
                        if (File.Exists(LogPathBackup))
                        {
                            try { File.Delete(LogPathBackup); }
                            catch { }
                        }
                        File.Move(LogPath, LogPathBackup);
                    }
                    catch
                    {
                        // 移动失败 = 文件被锁定
                        // 尝试删除它
                        try { File.Delete(LogPath); }
                        catch
                        {
                            // 也无法删除
                            // 文件确实被锁定了
                            // 使用备选文件名
                            _fileBroken = true;
                        }
                    }
                }

                // 创建新的日志文件
                string path = GetActivePath();
                File.WriteAllText(path,
                    $"=== TACTFR 日志开始 {DateTime.Now:yyyy-MM-dd HH:mm:ss} ===\n");
            }
            catch
            {
                _fileBroken = true;
            }
        }

        private static string GetActivePath()
        {
            if (_fileBroken)
            {
                // 后备方案：使用带时间戳的文件名
                // 这【总是】有效，因为这是新文件
                return Path.Combine(LogDir,
                    $"TACTFR_{DateTime.Now:yyyyMMdd_HHmmss}.log");
            }
            return LogPath;
        }

        public static void Initialize()
        {
            EnsureInitialized();
        }

        public static void Info(string message)
        {
            if (!Enabled) return;
            Write("信息", message);
        }

        public static void Warn(string message)
        {
            if (!Enabled) return;
            Write("警告", message);
        }

        public static void Error(string message)
        {
            // 错误总是写入，即使 Enabled=false
            Write("错误", message);
        }

        private static void Write(string level, string message)
        {
            lock (_lock)
            {
                try
                {
                    EnsureInitialized();
                    string path = GetActivePath();

                    File.AppendAllText(
                        path,
                        $"[{DateTime.Now:HH:mm:ss}] [{level}] {message}\n"
                    );
                }
                catch (IOException)
                {
                    // 尝试所有方法后文件仍被锁定
                    // 最后手段：尝试使用备选文件
                    try
                    {
                        _fileBroken = true;
                        string fallback = GetActivePath();
                        File.AppendAllText(
                            fallback,
                            $"[{DateTime.Now:HH:mm:ss}] [{level}] {message}\n"
                        );
                    }
                    catch
                    {
                        // 绝对的最后手段
                        try
                        {
                            GTA.UI.Screen.ShowSubtitle(
                                $"~r~日志：{message}", 1500);
                        }
                        catch { }
                    }
                }
                catch
                {
                    // 非IO错误：吞掉
                }
            }
        }
    }
}
