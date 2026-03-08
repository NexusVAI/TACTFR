using System;
using System.IO;
using Keys = System.Windows.Forms.Keys;

namespace EF.PoliceMod.Core
{
    public static class ModConfig
    {
        private static readonly string ConfigPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TACTFR.ini");

        private static bool _loaded = false;

        public static bool EnableAimToPickupByAiming { get; set; } = false;
        public const float LockDistance = 15f;
        public const float LoseDistance = 100f;
        public const float ArrestDistance = 8f;
        public static int MaxBackupCars { get; set; } = 4;
        public const int HeliReconCooldownMs = 120 * 1000;

        public static bool LogEnabled = true;
        public static int LogMaxSizeKB = 512;

        public static void EnableAimPickup() => EnableAimToPickupByAiming = true;
        public static void DisableAimPickup() => EnableAimToPickupByAiming = false;

        public static void Load()
        {
            if (_loaded) return;
            _loaded = true;
            try
            {
                EnsureConfigExists();
                KeyBindings.ResetToDefaults();
                LoadKeyBindings();
                LoadLogging();
                ModLog.Info("[ModConfig] Configuration loaded from TACTFR.ini");
            }
            catch (Exception ex)
            {
                ModLog.Error("[ModConfig] Failed to load config: " + ex);
            }
        }

        private static void EnsureConfigExists()
        {
            if (File.Exists(ConfigPath)) return;
            try
            {
                string defaults = @"; TACTFR Police Mod Configuration
; Place this file next to the .dll

[KeyBindings]
LockTarget = L
ArrestMenu = H
EscortRequest = G
VehicleInteract = E
DeliverSuspect = Z
PullOver = I
PullOverExit = U
OpenTerminal = O
VehicleTerminal = T
DispatchMenu = F7
OfficerSquadMenu = F8
ToggleHelp = F10

[MenuNavigation]
MenuUp = NumPad8
MenuDown = NumPad2
MenuConfirm = NumPad5
MenuCancel = Back
MenuLeft = NumPad4
MenuRight = NumPad6
MenuRefresh = NumPad9

[Logging]
Enabled = true
MaxSizeKB = 512
";
                File.WriteAllText(ConfigPath, defaults);
                ModLog.Info("[ModConfig] Created default TACTFR.ini");
            }
            catch { }
        }

        private static string ReadIniValue(string section, string key, string fallback)
        {
            try
            {
                if (!File.Exists(ConfigPath)) return fallback;
                string currentSection = "";
                foreach (var rawLine in File.ReadAllLines(ConfigPath))
                {
                    string line = rawLine.Trim();
                    if (string.IsNullOrEmpty(line)) continue;
                    if (line.StartsWith(";") || line.StartsWith("#")) continue;

                    if (line.StartsWith("[") && line.EndsWith("]"))
                    {
                        currentSection = line.Substring(1, line.Length - 2).Trim();
                        continue;
                    }

                    if (!string.Equals(currentSection, section, StringComparison.OrdinalIgnoreCase))
                        continue;

                    int eq = line.IndexOf('=');
                    if (eq < 0) continue;

                    string k = line.Substring(0, eq).Trim();
                    string v = line.Substring(eq + 1).Trim();
                    int commentIdx = v.IndexOf(';');
                    if (commentIdx >= 0) v = v.Substring(0, commentIdx).Trim();

                    if (string.Equals(k, key, StringComparison.OrdinalIgnoreCase))
                        return v;
                }
            }
            catch { }
            return fallback;
        }

        private static Keys ParseKey(string value, Keys fallback)
        {
            if (string.IsNullOrWhiteSpace(value)) return fallback;
            try
            {
                if (Enum.TryParse(value.Trim(), true, out Keys parsed))
                    return parsed;
            }
            catch { }
            return fallback;
        }

        private static void LoadKeyBindings()
        {
            KeyBindings.LockTarget = ParseKey(ReadIniValue("KeyBindings", "LockTarget", "L"), Keys.L);
            KeyBindings.ArrestMenu = ParseKey(ReadIniValue("KeyBindings", "ArrestMenu", "H"), Keys.H);
            KeyBindings.EscortRequest = ParseKey(ReadIniValue("KeyBindings", "EscortRequest", "G"), Keys.G);
            KeyBindings.VehicleInteract = ParseKey(ReadIniValue("KeyBindings", "VehicleInteract", "E"), Keys.E);
            KeyBindings.DeliverSuspect = ParseKey(ReadIniValue("KeyBindings", "DeliverSuspect", "Z"), Keys.Z);
            KeyBindings.PullOver = ParseKey(ReadIniValue("KeyBindings", "PullOver", "I"), Keys.I);
            KeyBindings.PullOverExit = ParseKey(ReadIniValue("KeyBindings", "PullOverExit", "U"), Keys.U);

            KeyBindings.OpenTerminal = ParseKey(ReadIniValue("KeyBindings", "OpenTerminal", "O"), Keys.O);
            KeyBindings.VehicleTerminal = ParseKey(ReadIniValue("KeyBindings", "VehicleTerminal", "T"), Keys.T);
            KeyBindings.DispatchMenu = ParseKey(ReadIniValue("KeyBindings", "DispatchMenu", "F7"), Keys.F7);
            KeyBindings.OfficerSquadMenu = ParseKey(ReadIniValue("KeyBindings", "OfficerSquadMenu", "F8"), Keys.F8);
            KeyBindings.ToggleHelp = ParseKey(ReadIniValue("KeyBindings", "ToggleHelp", "F10"), Keys.F10);
            KeyBindings.PatrolMenu = ParseKey(ReadIniValue("KeyBindings", "PatrolMenu", "H"), Keys.H);

            KeyBindings.MenuUp = ParseKey(ReadIniValue("MenuNavigation", "MenuUp", "NumPad8"), Keys.NumPad8);
            KeyBindings.MenuDown = ParseKey(ReadIniValue("MenuNavigation", "MenuDown", "NumPad2"), Keys.NumPad2);
            KeyBindings.MenuConfirm = ParseKey(ReadIniValue("MenuNavigation", "MenuConfirm", "NumPad5"), Keys.NumPad5);
            KeyBindings.MenuCancel = ParseKey(ReadIniValue("MenuNavigation", "MenuCancel", "Back"), Keys.Back);
            KeyBindings.MenuLeft = ParseKey(ReadIniValue("MenuNavigation", "MenuLeft", "NumPad4"), Keys.NumPad4);
            KeyBindings.MenuRight = ParseKey(ReadIniValue("MenuNavigation", "MenuRight", "NumPad6"), Keys.NumPad6);
            KeyBindings.MenuRefresh = ParseKey(ReadIniValue("MenuNavigation", "MenuRefresh", "NumPad9"), Keys.NumPad9);
        }

        private static void LoadLogging()
        {
            string enabled = ReadIniValue("Logging", "Enabled", "true");
            LogEnabled = string.Equals(enabled.Trim(), "true", StringComparison.OrdinalIgnoreCase);
            ModLog.Enabled = LogEnabled;

            string maxSize = ReadIniValue("Logging", "MaxSizeKB", "512");
            if (int.TryParse(maxSize.Trim(), out int kb) && kb >= 0)
                LogMaxSizeKB = kb;
        }
    }

    public static class KeyBindings
    {
        public static Keys DeliverSuspect { get; set; } = Keys.Z;
        public static Keys LockTarget { get; set; } = Keys.L;
        public static Keys OpenTerminal { get; set; } = Keys.O;
        public static Keys VehicleTerminal { get; set; } = Keys.T;
        public static Keys PatrolMenu { get; set; } = Keys.H;
        public static Keys ArrestMenu { get; set; } = Keys.H;
        public static Keys EscortRequest { get; set; } = Keys.G;
        public static Keys VehicleInteract { get; set; } = Keys.E;
        public static Keys PullOver { get; set; } = Keys.I;
        public static Keys PullOverExit { get; set; } = Keys.U;
        public static Keys DispatchMenu { get; set; } = Keys.F7;
        public static Keys OfficerSquadMenu { get; set; } = Keys.F8;
        public static Keys ToggleHelp { get; set; } = Keys.F10;
        public static Keys MenuUp { get; set; } = Keys.NumPad8;
        public static Keys MenuDown { get; set; } = Keys.NumPad2;
        public static Keys MenuConfirm { get; set; } = Keys.NumPad5;
        public static Keys MenuCancel { get; set; } = Keys.Back;
        public static Keys MenuLeft { get; set; } = Keys.NumPad4;
        public static Keys MenuRight { get; set; } = Keys.NumPad6;
        public static Keys MenuRefresh { get; set; } = Keys.NumPad9;

        public static void ResetToDefaults()
        {
            DeliverSuspect = Keys.Z;
            LockTarget = Keys.L;
            OpenTerminal = Keys.O;
            VehicleTerminal = Keys.T;
            PatrolMenu = Keys.H;
            ArrestMenu = Keys.H;
            EscortRequest = Keys.G;
            VehicleInteract = Keys.E;
            PullOver = Keys.I;
            PullOverExit = Keys.U;
            DispatchMenu = Keys.F7;
            OfficerSquadMenu = Keys.F8;
            ToggleHelp = Keys.F10;
            MenuUp = Keys.NumPad8;
            MenuDown = Keys.NumPad2;
            MenuConfirm = Keys.NumPad5;
            MenuCancel = Keys.Back;
            MenuLeft = Keys.NumPad4;
            MenuRight = Keys.NumPad6;
            MenuRefresh = Keys.NumPad9;
        }

        public static string GetKeyDisplayName(Keys key) => key.ToString();
    }
}
