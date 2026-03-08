using EF.PoliceMod.Core;
using GTA;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EF.PoliceMod.Systems
{
    public enum RadioEvent
    {
        DutyStart,
        CaseAccepted,
        CaseEnded,
        TargetLocked,
        Robbery,
        Gunfire,
        ShotsFired,
        ResistArrest,
        BrandishingWeapon,
        AssaultDeadlyWeapon,
        VehicleAccident,
        HitAndRun,
        GrandTheftAuto,
        AssistanceRequired,
        RequestAirSupport,
        AmbulanceRequested,
        OfficerNeedsAssistance,
        UnitResponding,
        RequestBackup,
        HeliApproaching,
        HeliMayday,
        SuspectOnFoot,
        SuspectInCar,
        SuspectOnBike,
        SuspectCrashed,
        SuspectEnteredFreeway
    }

    public sealed class PoliceRadioSystem : IDisposable
    {
        private struct RadioPlayRequest
        {
            public string FilePath;
            public float Volume;
        }

        private static readonly Random Rand = new Random();
        private readonly Dictionary<RadioEvent, List<string>> _fileMap = new Dictionary<RadioEvent, List<string>>();
        private readonly Dictionary<RadioEvent, int> _playCursor = new Dictionary<RadioEvent, int>();
        private readonly Queue<RadioPlayRequest> _queue = new Queue<RadioPlayRequest>();
        private readonly RadioAudioPlayer _player = new RadioAudioPlayer();
        private readonly List<string> _audioRoots;
        private int _lastPlayEndAtMs;
        private bool _wasPlaying;
        private const int MinGapBetweenCallsMs = 800;
        private const int MaxQueueSize = 12;

        public PoliceRadioSystem()
        {
            _audioRoots = ResolveAudioRoots();
            BuildFileMap();
            ModLog.Info("[Radio] Initialized. Audio roots: " + string.Join(" | ", _audioRoots));
            ModLog.Info("[Radio] Loaded event map count: " + _fileMap.Count);
        }

        public void PlayRadio(RadioEvent evt, float volume = 0.7f)
        {
            try
            {
                if (!_fileMap.TryGetValue(evt, out var files) || files == null || files.Count == 0)
                {
                    ModLog.Warn("[Radio] No mapped wav for event: " + evt);
                    return;
                }

                string file = NextFile(evt, files);
                var request = new RadioPlayRequest { FilePath = file, Volume = volume };

                if (_player.IsPlaying || _queue.Count > 0)
                {
                    if (_queue.Count >= MaxQueueSize)
                    {
                        _queue.Dequeue();
                    }
                    _queue.Enqueue(request);
                    ModLog.Info("[Radio] Queued: " + Path.GetFileName(file));
                    return;
                }

                if (CanPlayNow())
                {
                    PlayNow(request);
                }
                else
                {
                    _queue.Enqueue(request);
                    ModLog.Info("[Radio] Queued by gap: " + Path.GetFileName(file));
                }
            }
            catch (Exception ex)
            {
                ModLog.Error("[Radio] PlayRadio failed: " + ex);
            }
        }

        public void Tick()
        {
            try
            {
                _player.Tick();
                bool nowPlaying = _player.IsPlaying;

                if (_wasPlaying && !nowPlaying)
                {
                    _lastPlayEndAtMs = Game.GameTime;
                }
                _wasPlaying = nowPlaying;

                if (nowPlaying || _queue.Count <= 0) return;
                if (!CanPlayNow()) return;

                var next = _queue.Dequeue();
                PlayNow(next);
            }
            catch (Exception ex)
            {
                ModLog.Error("[Radio] Tick failed: " + ex);
            }
        }

        public void Dispose()
        {
            try { _player.Dispose(); } catch { }
            _queue.Clear();
        }

        private bool CanPlayNow()
        {
            int now = Game.GameTime;
            return now - _lastPlayEndAtMs >= MinGapBetweenCallsMs;
        }

        private void PlayNow(RadioPlayRequest request)
        {
            if (_player.Play(request.FilePath, request.Volume))
            {
                _wasPlaying = true;
                ModLog.Info("[Radio] Playing: " + Path.GetFileName(request.FilePath));
            }
        }

        private List<string> ResolveAudioRoots()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string parent = SafeGetFullPath(Path.Combine(baseDir, ".."));
            string grandParent = SafeGetFullPath(Path.Combine(baseDir, "..", ".."));
            var candidates = new[]
            {
                Path.Combine(baseDir, "scripts", "TACTFR_Audio"),
                Path.Combine(baseDir, "scripts", "Audio"),
                Path.Combine(baseDir, "TACTFR_Audio"),
                Path.Combine(baseDir, "Audio"),
                Path.Combine(parent, "scripts", "TACTFR_Audio"),
                Path.Combine(parent, "scripts", "Audio"),
                Path.Combine(parent, "TACTFR_Audio"),
                Path.Combine(parent, "Audio"),
                Path.Combine(grandParent, "scripts", "TACTFR_Audio"),
                Path.Combine(grandParent, "scripts", "Audio"),
                Path.Combine(grandParent, "TACTFR_Audio"),
                Path.Combine(grandParent, "Audio")
            };

            var roots = new List<string>();
            foreach (var path in candidates)
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(path) && Directory.Exists(path))
                    {
                        bool exists = roots.Any(x => string.Equals(x, path, StringComparison.OrdinalIgnoreCase));
                        if (!exists) roots.Add(path);
                    }
                }
                catch { }
            }

            if (roots.Count == 0)
            {
                roots.Add(Path.Combine(baseDir, "scripts", "Audio"));
                roots.Add(Path.Combine(baseDir, "Audio"));
            }
            return roots;
        }

        private void BuildFileMap()
        {
            MapFiles(RadioEvent.DutyStart, "ATTENTION_ALL_UNITS_", "ATTENTION_ALL_SWAT_UNITS_");
            MapFiles(RadioEvent.CaseAccepted, "ASSISTANCE_REQUIRED_", "OP_REQUIRED");
            MapFiles(RadioEvent.CaseEnded, "REPORT_RESPONSE_COPY_", "OP_TRANSPORT");
            MapFiles(RadioEvent.TargetLocked, "WE_HAVE_", "OFFICERS_REPORT_", "CITIZENS_REPORT_");
            MapFiles(RadioEvent.Robbery, "CRIME_ROBBERY_");
            MapFiles(RadioEvent.Gunfire, "CRIME_GUNFIRE_");
            MapFiles(RadioEvent.ShotsFired, "CRIME_SHOTS_FIRED_");
            MapFiles(RadioEvent.ResistArrest, "CRIME_RESIST_ARREST_");
            MapFiles(RadioEvent.BrandishingWeapon, "CRIME_BRANDISHING_WEAPON_");
            MapFiles(RadioEvent.AssaultDeadlyWeapon, "CRIME_ASSAULT_WITH_A_DEADLY_WEAPON_", "ASSAULT_WITH_AN_DEADLY_WEAPON");
            MapFiles(RadioEvent.VehicleAccident, "CRIME_MOTOR_VEHICLE_ACCIDENT_");
            MapFiles(RadioEvent.HitAndRun, "CRIME_HIT_AND_RUN_");
            MapFiles(RadioEvent.GrandTheftAuto, "CRIME_GRAND_THEFT_AUTO_");
            MapFiles(RadioEvent.AssistanceRequired, "ASSISTANCE_REQUIRED_");
            MapFiles(RadioEvent.RequestAirSupport, "CRIME_OFFICER_REQUESTS_AIR_SUPPORT_");
            MapFiles(RadioEvent.AmbulanceRequested, "CRIME_AMBULANCE_REQUESTED_");
            MapFiles(RadioEvent.OfficerNeedsAssistance, "CRIME_OFFICER_IN_NEED_OF_ASSISTANCE_");
            MapFiles(RadioEvent.UnitResponding, "UNIT_RESPONDING_DISPATCH_");
            MapFiles(RadioEvent.RequestBackup, "REQUEST_BACKUP_");
            MapFiles(RadioEvent.HeliApproaching, "HELI_APPROACHING_DISPATCH_");
            MapFiles(RadioEvent.HeliMayday, "HELI_MAYDAY_DISPATCH_");
            MapFiles(RadioEvent.SuspectOnFoot, "SUSPECT_IS_ON_FOOT_");
            MapFiles(RadioEvent.SuspectInCar, "SUSPECT_IS_IN_CAR_");
            MapFiles(RadioEvent.SuspectOnBike, "SUSPECT_IS_ON_BIKE_");
            MapFiles(RadioEvent.SuspectCrashed, "SUSPECT_CRASHED_");
            MapFiles(RadioEvent.SuspectEnteredFreeway, "SUSPECT_ENTERED_FREEWAY_");
        }

        private void MapFiles(RadioEvent evt, params string[] prefixes)
        {
            try
            {
                var files = new List<string>();
                for (int r = 0; r < _audioRoots.Count; r++)
                {
                    var root = _audioRoots[r];
                    if (!Directory.Exists(root)) continue;
                    files.AddRange(Directory.EnumerateFiles(root, "*.wav", SearchOption.AllDirectories)
                        .Where(path =>
                        {
                            var name = Path.GetFileNameWithoutExtension(path);
                            for (int i = 0; i < prefixes.Length; i++)
                            {
                                if (name.StartsWith(prefixes[i], StringComparison.OrdinalIgnoreCase))
                                {
                                    return true;
                                }
                            }
                            return false;
                        }));
                }
                files = files
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .ToList();

                if (files.Count > 0)
                {
                    _fileMap[evt] = files;
                    if (!_playCursor.ContainsKey(evt))
                    {
                        _playCursor[evt] = Rand.Next(files.Count);
                    }
                }
            }
            catch (Exception ex)
            {
                ModLog.Error("[Radio] MapFiles failed for " + evt + ": " + ex);
            }
        }

        private string NextFile(RadioEvent evt, List<string> files)
        {
            if (files == null || files.Count == 0) return null;
            if (files.Count == 1) return files[0];
            if (!_playCursor.TryGetValue(evt, out var index))
            {
                index = Rand.Next(files.Count);
            }
            if (index < 0 || index >= files.Count) index = 0;
            string file = files[index];
            _playCursor[evt] = (index + 1) % files.Count;
            return file;
        }

        private static string SafeGetFullPath(string path)
        {
            try
            {
                return Path.GetFullPath(path);
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
