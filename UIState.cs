namespace EF.PoliceMod.Core
{
    public static class UIState
    {
        public static bool IsPoliceTerminalOpen = false;
        public static bool IsDispatchMenuOpen = false;
        public static bool IsArrestMenuOpen = false;
        public static bool IsUniformMenuOpen = false;
        public static bool IsOfficerSquadMenuOpen = false;

        private static int _policeTerminalHeartbeatAtMs = 0;
        private static int _dispatchMenuHeartbeatAtMs = 0;
        private static int _arrestMenuHeartbeatAtMs = 0;
        private static int _uniformMenuHeartbeatAtMs = 0;
        private static int _officerSquadMenuHeartbeatAtMs = 0;

        private static int _policeTerminalOpenedAtMs = 0;
        private static int _dispatchMenuOpenedAtMs = 0;
        private static int _arrestMenuOpenedAtMs = 0;
        private static int _uniformMenuOpenedAtMs = 0;
        private static int _officerSquadMenuOpenedAtMs = 0;

        public static void MarkPoliceTerminalOpen(int nowMs)
        {
            IsPoliceTerminalOpen = true;
            _policeTerminalHeartbeatAtMs = nowMs;
            _policeTerminalOpenedAtMs = nowMs;
        }

        public static void MarkPoliceTerminalClosed()
        {
            IsPoliceTerminalOpen = false;
            _policeTerminalHeartbeatAtMs = 0;
            _policeTerminalOpenedAtMs = 0;
        }

        public static void BeatPoliceTerminal(int nowMs)
        {
            if (IsPoliceTerminalOpen) _policeTerminalHeartbeatAtMs = nowMs;
        }

        public static void MarkDispatchMenuOpen(int nowMs)
        {
            IsDispatchMenuOpen = true;
            _dispatchMenuHeartbeatAtMs = nowMs;
            _dispatchMenuOpenedAtMs = nowMs;
        }

        public static void MarkDispatchMenuClosed()
        {
            IsDispatchMenuOpen = false;
            _dispatchMenuHeartbeatAtMs = 0;
            _dispatchMenuOpenedAtMs = 0;
        }

        public static void BeatDispatchMenu(int nowMs)
        {
            if (IsDispatchMenuOpen) _dispatchMenuHeartbeatAtMs = nowMs;
        }

        public static void MarkArrestMenuOpen(int nowMs)
        {
            IsArrestMenuOpen = true;
            _arrestMenuHeartbeatAtMs = nowMs;
            _arrestMenuOpenedAtMs = nowMs;
        }

        public static void MarkArrestMenuClosed()
        {
            IsArrestMenuOpen = false;
            _arrestMenuHeartbeatAtMs = 0;
            _arrestMenuOpenedAtMs = 0;
        }

        public static void BeatArrestMenu(int nowMs)
        {
            if (IsArrestMenuOpen) _arrestMenuHeartbeatAtMs = nowMs;
        }

        public static void MarkUniformMenuOpen(int nowMs)
        {
            IsUniformMenuOpen = true;
            _uniformMenuHeartbeatAtMs = nowMs;
            _uniformMenuOpenedAtMs = nowMs;
        }

        public static void MarkUniformMenuClosed()
        {
            IsUniformMenuOpen = false;
            _uniformMenuHeartbeatAtMs = 0;
            _uniformMenuOpenedAtMs = 0;
        }

        public static void BeatUniformMenu(int nowMs)
        {
            if (IsUniformMenuOpen) _uniformMenuHeartbeatAtMs = nowMs;
        }

        public static void MarkOfficerSquadMenuOpen(int nowMs)
        {
            IsOfficerSquadMenuOpen = true;
            _officerSquadMenuHeartbeatAtMs = nowMs;
            _officerSquadMenuOpenedAtMs = nowMs;
        }

        public static void MarkOfficerSquadMenuClosed()
        {
            IsOfficerSquadMenuOpen = false;
            _officerSquadMenuHeartbeatAtMs = 0;
            _officerSquadMenuOpenedAtMs = 0;
        }

        public static void BeatOfficerSquadMenu(int nowMs)
        {
            if (IsOfficerSquadMenuOpen) _officerSquadMenuHeartbeatAtMs = nowMs;
        }

        public static void AutoRecover(int nowMs, int heartbeatTimeoutMs = 1500, int maxLifetimeMs = 15000)
        {
            try
            {
                if (IsPoliceTerminalOpen)
                {
                    bool heartbeatStale = _policeTerminalHeartbeatAtMs > 0 && nowMs - _policeTerminalHeartbeatAtMs > heartbeatTimeoutMs;
                    bool tooOld = _policeTerminalOpenedAtMs > 0 && nowMs - _policeTerminalOpenedAtMs > 30000;
                    if (heartbeatStale || tooOld)
                    {
                        ModLog.Warn($"[UIState] PoliceTerminal 自动重置 (stale={heartbeatStale}, tooOld={tooOld})");
                        MarkPoliceTerminalClosed();
                    }
                }

                if (IsDispatchMenuOpen)
                {
                    bool heartbeatStale = _dispatchMenuHeartbeatAtMs > 0 && nowMs - _dispatchMenuHeartbeatAtMs > heartbeatTimeoutMs;
                    bool tooOld = _dispatchMenuOpenedAtMs > 0 && nowMs - _dispatchMenuOpenedAtMs > maxLifetimeMs;
                    if (heartbeatStale || tooOld)
                    {
                        ModLog.Warn($"[UIState] DispatchMenu 自动重置 (stale={heartbeatStale}, tooOld={tooOld})");
                        MarkDispatchMenuClosed();
                    }
                }

                if (IsArrestMenuOpen)
                {
                    bool heartbeatStale = _arrestMenuHeartbeatAtMs > 0 && nowMs - _arrestMenuHeartbeatAtMs > heartbeatTimeoutMs;
                    bool tooOld = _arrestMenuOpenedAtMs > 0 && nowMs - _arrestMenuOpenedAtMs > maxLifetimeMs;
                    if (heartbeatStale || tooOld)
                    {
                        ModLog.Warn($"[UIState] ArrestMenu 自动重置 (stale={heartbeatStale}, tooOld={tooOld})");
                        MarkArrestMenuClosed();
                    }
                }

                if (IsUniformMenuOpen)
                {
                    bool heartbeatStale = _uniformMenuHeartbeatAtMs > 0 && nowMs - _uniformMenuHeartbeatAtMs > heartbeatTimeoutMs;
                    bool tooOld = _uniformMenuOpenedAtMs > 0 && nowMs - _uniformMenuOpenedAtMs > maxLifetimeMs;
                    if (heartbeatStale || tooOld)
                    {
                        ModLog.Warn($"[UIState] UniformMenu 自动重置 (stale={heartbeatStale}, tooOld={tooOld})");
                        MarkUniformMenuClosed();
                    }
                }

                if (IsOfficerSquadMenuOpen)
                {
                    bool heartbeatStale = _officerSquadMenuHeartbeatAtMs > 0 && nowMs - _officerSquadMenuHeartbeatAtMs > heartbeatTimeoutMs;
                    bool tooOld = _officerSquadMenuOpenedAtMs > 0 && nowMs - _officerSquadMenuOpenedAtMs > maxLifetimeMs;
                    if (heartbeatStale || tooOld)
                    {
                        ModLog.Warn($"[UIState] OfficerSquadMenu 自动重置 (stale={heartbeatStale}, tooOld={tooOld})");
                        MarkOfficerSquadMenuClosed();
                    }
                }
            }
            catch { }
        }
    }
}
