using System.Collections.Generic;
using System;
using System.IO;
using GTA;
using Keys = System.Windows.Forms.Keys;

namespace EF.PoliceMod.Core
{
    public static class ModConfig
    {
        public static bool EnableAimToPickupByAiming { get; set; } = false;

        public const float LockDistance = 15f;
        public const float LoseDistance = 100f;
        public const float ArrestDistance = 8f;

        public static int MaxBackupCars { get; set; } = 4;

        // Support cooldowns
        // Heli recon: 使用一次后 120s 内不得再次使用
        public const int HeliReconCooldownMs = 120 * 1000;

        public static void EnableAimPickup() => EnableAimToPickupByAiming = true;
        public static void DisableAimPickup() => EnableAimToPickupByAiming = false;
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

        private static readonly Dictionary<string, Keys> _defaultBindings = new Dictionary<string, Keys>
        {
            { "DeliverSuspect", Keys.Z },
            { "LockTarget", Keys.L },
            { "OpenTerminal", Keys.O },
            { "VehicleTerminal", Keys.T },
            { "PatrolMenu", Keys.H },
            { "ArrestMenu", Keys.H },
            { "EscortRequest", Keys.G },
            { "VehicleInteract", Keys.E },
            { "PullOver", Keys.I },
            { "PullOverExit", Keys.U },
            { "DispatchMenu", Keys.F7 },
            { "OfficerSquadMenu", Keys.F8 },
            { "ToggleHelp", Keys.F10 }
        };

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
        }

        public static string GetKeyDisplayName(Keys key)
        {
            return key.ToString();
        }

        static KeyBindings()
        {
            LoadFromIni();
        }

        public static void LoadFromIni()
        {
            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string scriptsDir = Path.Combine(baseDir, "scripts");
                string iniPath = Path.Combine(scriptsDir, "TACTFR.ini");

                if (!Directory.Exists(scriptsDir))
                {
                    Directory.CreateDirectory(scriptsDir);
                }

                if (!File.Exists(iniPath))
                {
                    var sample = new[]
                    {
                        "[KeyBindings]",
                        "DeliverSuspect=Z",
                        "LockTarget=L",
                        "OpenTerminal=O",
                        "VehicleTerminal=T",
                        "PatrolMenu=J",
                        "ArrestMenu=H",
                        "EscortRequest=G",
                        "VehicleInteract=E",
                        "PullOver=I",
                        "PullOverExit=U",
                        "DispatchMenu=F7",
                        "OfficerSquadMenu=F8",
                        "ToggleHelp=F10",
                    };
                    File.WriteAllLines(iniPath, sample);
                    return;
                }

                bool inBindings = false;
                foreach (var raw in File.ReadAllLines(iniPath))
                {
                    var line = (raw ?? string.Empty).Trim();
                    if (line.Length == 0 || line.StartsWith(";") || line.StartsWith("#")) continue;

                    if (line.StartsWith("[") && line.EndsWith("]"))
                    {
                        inBindings = string.Equals(line, "[KeyBindings]", StringComparison.OrdinalIgnoreCase);
                        continue;
                    }

                    if (!inBindings) continue;
                    int idx = line.IndexOf('=');
                    if (idx <= 0) continue;

                    string key = line.Substring(0, idx).Trim();
                    string value = line.Substring(idx + 1).Trim();
                    if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(value)) continue;

                    if (!Enum.TryParse(value, true, out Keys parsed)) continue;

                    switch (key)
                    {
                        case "DeliverSuspect": DeliverSuspect = parsed; break;
                        case "LockTarget": LockTarget = parsed; break;
                        case "OpenTerminal": OpenTerminal = parsed; break;
                        case "VehicleTerminal": VehicleTerminal = parsed; break;
                        case "PatrolMenu": PatrolMenu = parsed; break;
                        case "ArrestMenu": ArrestMenu = parsed; break;
                        case "EscortRequest": EscortRequest = parsed; break;
                        case "VehicleInteract": VehicleInteract = parsed; break;
                        case "PullOver": PullOver = parsed; break;
                        case "PullOverExit": PullOverExit = parsed; break;
                        case "DispatchMenu": DispatchMenu = parsed; break;
                        case "OfficerSquadMenu": OfficerSquadMenu = parsed; break;
                        case "ToggleHelp": ToggleHelp = parsed; break;
                    }
                }
            }
            catch { }
        }
    }
}
