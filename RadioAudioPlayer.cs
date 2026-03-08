using EF.PoliceMod.Core;
using System;
using System.IO;
using System.Media;

namespace EF.PoliceMod.Systems
{
    public sealed class RadioAudioPlayer : IDisposable
    {
        private SoundPlayer _player;
        private int _playEndAtTick;
        private bool _isPlaying;

        public bool IsPlaying => _isPlaying;

        public bool Play(string filePath, float volume = 0.8f)
        {
            try
            {
                Stop();
                if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
                {
                    ModLog.Warn("[RadioAudio] File missing: " + filePath);
                    return false;
                }

                _player = new SoundPlayer(filePath);
                _player.LoadAsync();
                _player.Play();
                int durationMs = TryReadWavDurationMs(filePath);
                _playEndAtTick = unchecked(Environment.TickCount + durationMs);
                _isPlaying = true;
                return true;
            }
            catch (Exception ex)
            {
                ModLog.Error("[RadioAudio] Play failed: " + ex);
                Stop();
                return false;
            }
        }

        public void Tick()
        {
            if (!_isPlaying) return;
            if (HasElapsed(_playEndAtTick))
            {
                _isPlaying = false;
                try { _player?.Stop(); } catch { }
                try { _player?.Dispose(); } catch { }
                _player = null;
            }
        }

        public void Stop()
        {
            _isPlaying = false;
            try { _player?.Stop(); } catch { }
            try { _player?.Dispose(); } catch { }
            _player = null;
            _playEndAtTick = 0;
        }

        public void Dispose()
        {
            Stop();
        }

        private static bool HasElapsed(int targetTick)
        {
            return unchecked(Environment.TickCount - targetTick) >= 0;
        }

        private static int TryReadWavDurationMs(string filePath)
        {
            try
            {
                using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (var br = new BinaryReader(fs))
                {
                    if (fs.Length < 44) return 1800;
                    var riff = new string(br.ReadChars(4));
                    br.ReadInt32();
                    var wave = new string(br.ReadChars(4));
                    if (!string.Equals(riff, "RIFF", StringComparison.Ordinal) ||
                        !string.Equals(wave, "WAVE", StringComparison.Ordinal))
                    {
                        return 1800;
                    }

                    while (fs.Position + 8 <= fs.Length)
                    {
                        var chunkId = new string(br.ReadChars(4));
                        var chunkSize = br.ReadInt32();
                        if (chunkSize < 0) return 1800;
                        if (string.Equals(chunkId, "fmt ", StringComparison.Ordinal))
                        {
                            if (chunkSize < 16) return 1800;
                            var audioFormat = br.ReadInt16();
                            var channels = br.ReadInt16();
                            var sampleRate = br.ReadInt32();
                            br.ReadInt32();
                            br.ReadInt16();
                            var bitsPerSample = br.ReadInt16();
                            if (chunkSize > 16)
                            {
                                fs.Position += (chunkSize - 16);
                            }

                            while (fs.Position + 8 <= fs.Length)
                            {
                                var id = new string(br.ReadChars(4));
                                var size = br.ReadInt32();
                                if (size < 0) return 1800;
                                if (string.Equals(id, "data", StringComparison.Ordinal))
                                {
                                    if (channels <= 0 || sampleRate <= 0 || bitsPerSample <= 0) return 1800;
                                    if (audioFormat != 1 && audioFormat != 3) return 1800;
                                    double bytesPerSecond = sampleRate * channels * (bitsPerSample / 8.0);
                                    if (bytesPerSecond <= 0.0) return 1800;
                                    var ms = (int)Math.Ceiling((size / bytesPerSecond) * 1000.0);
                                    if (ms < 350) ms = 350;
                                    if (ms > 30000) ms = 30000;
                                    return ms;
                                }
                                fs.Position += size;
                                if ((size & 1) == 1 && fs.Position < fs.Length) fs.Position += 1;
                            }

                            return 1800;
                        }

                        fs.Position += chunkSize;
                        if ((chunkSize & 1) == 1 && fs.Position < fs.Length) fs.Position += 1;
                    }
                }
            }
            catch { }

            return 1800;
        }
    }
}
