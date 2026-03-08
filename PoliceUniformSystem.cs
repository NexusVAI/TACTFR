using EF.PoliceMod.Core;
using GTA;
using GTA.Math;
using GTA.Native;
using GTA.UI;
using System;
using System.Collections.Generic;

namespace EF.PoliceMod.Systems
{
    /// <summary>
    /// 警服更换点：警局内蓝色圈 + 衣服图标 Blip。
    /// 按 E 打开简易“衣柜视角”菜单：男警服 / 女警服 / 恢复原外观。
    /// </summary>
    public class PoliceUniformSystem
    {
        // 位置：警局内换装点（可按需微调）
        private readonly Vector3 _wardrobePos = new Vector3(448.66333f, -988.790955f, 30.68965f);
        private const float InteractRadius = 1.8f;

        private Blip _blip;

        // menu state
        private bool _menuOpen = false;
        private int _menuIndex = 0;
        private int _menuOpenedAtMs = 0;

        // key edge-detect（防止按住一次跳多格）
        private bool _upHeld = false;
        private bool _downHeld = false;
        private bool _confirmHeld = false;
        private bool _cancelHeld = false;

        // appearance snapshot (best-effort)
        private int _savedModelHash = 0;
        private bool _hasSavedAppearance = false;
        private readonly int[] _savedDrawable = new int[12];
        private readonly int[] _savedTexture = new int[12];
        private readonly int[] _savedPalette = new int[12];
        private readonly int[] _savedPropIndex = new int[8];
        private readonly int[] _savedPropTexture = new int[8];

        // camera
        private int _camHandle = 0;

        public PoliceUniformSystem()
        {
            CreateBlip();

            // 兜底：下班时关掉菜单/相机
            EventBus.Subscribe<DutyEndedEvent>(_ => ForceCloseMenu("DutyEnded"));
        }

        public void Tick()
        {
            var player = Game.Player.Character;
            if (player == null || !player.Exists()) return;

            int now = Game.GameTime;

            if (_menuOpen)
            {
                // heartbeat
                try { UIState.BeatUniformMenu(now); } catch { }

                DrawMenuThisFrame();
                HandleMenuInput(player, now);
                return;
            }

            float dist = 9999f;
            try { dist = player.Position.DistanceTo(_wardrobePos); } catch { dist = 9999f; }

            // marker（蓝色圈）
            try { DrawWardrobeMarker(); } catch { }

            if (dist > InteractRadius) return;

            // 用字幕提示，避免与其它系统的 HELP 文本互相覆盖/被 CLEAR_HELP 清掉
            try { Screen.ShowSubtitle("~w~[~b~E~w~] 更换警服", 1); } catch { }

            if (Game.IsControlJustPressed(Control.Context))
            {
                OpenMenu(player, now);
            }
        }

        private void CreateBlip()
        {
            try
            {
                _blip = World.CreateBlip(_wardrobePos);
                if (_blip == null) return;

                // ★修复点4：换装点图标改“衣服”
                // 走 native，避免 BlipSprite 枚举缺失（参考“增强版函数”）。
                // 73：常用“服装店/衣服”类图标。
                try { Function.Call(Hash.SET_BLIP_SPRITE, _blip.Handle, 73); } catch { }

                _blip.Color = BlipColor.Blue;
                _blip.Scale = 0.75f;
                _blip.IsShortRange = true;
                _blip.Name = "更换警服";
            }
            catch (Exception ex)
            {
                ModLog.Error("[PoliceUniformSystem] CreateBlip failed: " + ex);
            }
        }

        private void DrawWardrobeMarker()
        {
            // DRAW_MARKER type=1（圆柱），颜色蓝
            Function.Call(
                Hash.DRAW_MARKER,
                1,
                _wardrobePos.X, _wardrobePos.Y, _wardrobePos.Z - 1.0f,
                0f, 0f, 0f,
                0f, 0f, 0f,
                1.0f, 1.0f, 1.0f,
                30, 144, 255, 140,
                false, true, 2,
                false, 0, 0, false
            );
        }

        private void ShowHelpThisFrame(string message)
        {
            Function.Call(Hash.BEGIN_TEXT_COMMAND_DISPLAY_HELP, "STRING");
            Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, message);
            Function.Call(Hash.END_TEXT_COMMAND_DISPLAY_HELP, 0, false, true, -1);
        }

        private void OpenMenu(Ped player, int now)
        {
            try
            {
                if (!_hasSavedAppearance)
                {
                    SaveAppearance(player);
                }

                _menuOpen = true;
                _menuIndex = 0;
                _menuOpenedAtMs = now;

                try { UIState.MarkUniformMenuOpen(now); } catch { }

                SetupWardrobeCamera(player);

                Notification.Show("~b~衣柜：小键盘8/2选择，5确认，Back取消");
            }
            catch (Exception ex)
            {
                ModLog.Error("[PoliceUniformSystem] OpenMenu failed: " + ex);
                ForceCloseMenu("OpenMenuFail");
            }
        }

        private void ForceCloseMenu(string reason)
        {
            try
            {
                if (!_menuOpen) return;

                _menuOpen = false;
                _menuIndex = 0;

                try { UIState.MarkUniformMenuClosed(); } catch { }

                DestroyWardrobeCamera();
            }
            catch (Exception ex)
            {
                ModLog.Error("[PoliceUniformSystem] ForceCloseMenu error: " + ex);
            }
        }

        private void DrawMenuThisFrame()
        {
            var items = new List<string>
            {
                "男警服",
                "女警服",
                "特警服(SWAT)",
                "恢复原外观"
            };

            if (_menuIndex < 0) _menuIndex = 0;
            if (_menuIndex >= items.Count) _menuIndex = items.Count - 1;
            string text = $"~b~[更换警服]~s~\n~c~{KeyBindings.MenuUp}/{KeyBindings.MenuDown}选择  {KeyBindings.MenuConfirm}确认  {KeyBindings.MenuCancel}取消~s~\n";
            for (int i = 0; i < items.Count; i++)
            {
                text += (i == _menuIndex ? "~y~> " : "~w~  ") + items[i] + "~s~\n";
            }

            Screen.ShowSubtitle(text, 1);
        }

        private void HandleMenuInput(Ped player, int now)
        {
            if (now - _menuOpenedAtMs < 150) return;

            try
            {
                int maxIndex = 3;

                bool up = Game.IsKeyPressed(KeyBindings.MenuUp);
                bool down = Game.IsKeyPressed(KeyBindings.MenuDown);
                bool confirm = Game.IsKeyPressed(KeyBindings.MenuConfirm);
                bool cancel = Game.IsKeyPressed(KeyBindings.MenuCancel);

                if (up)
                {
                    if (!_upHeld)
                    {
                        _menuIndex--;
                        if (_menuIndex < 0) _menuIndex = maxIndex;
                    }
                    _upHeld = true;
                }
                else _upHeld = false;

                if (down)
                {
                    if (!_downHeld)
                    {
                        _menuIndex++;
                        if (_menuIndex > maxIndex) _menuIndex = 0;
                    }
                    _downHeld = true;
                }
                else _downHeld = false;

                if (confirm)
                {
                    if (!_confirmHeld)
                    {
                        ApplySelection(player, _menuIndex);
                        ForceCloseMenu("Applied");
                    }
                    _confirmHeld = true;
                }
                else _confirmHeld = false;

                if (cancel)
                {
                    if (!_cancelHeld)
                    {
                        ForceCloseMenu("Canceled");
                    }
                    _cancelHeld = true;
                }
                else _cancelHeld = false;
            }
            catch (Exception ex)
            {
                ModLog.Error("[PoliceUniformSystem] HandleMenuInput error: " + ex);
                ForceCloseMenu("InputError");
            }
        }

        private void ApplySelection(Ped player, int index)
        {
            try
            {
                switch (index)
                {
                    case 0:
                        ApplyCopModel(player, PedHash.Cop01SMY);
                        Notification.Show("~g~已更换：男警服");
                        break;
                    case 1:
                        ApplyCopModel(player, PedHash.Cop01SFY);
                        Notification.Show("~g~已更换：女警服");
                        break;
                    case 2:
                        ApplyCopModel(player, PedHash.Swat01SMY);
                        Notification.Show("~g~已更换：特警服(SWAT)");
                        break;
                    case 3:
                        RestoreAppearance(player);
                        Notification.Show("~y~已恢复原外观");
                        break;
                }
            }
            catch (Exception ex)
            {
                ModLog.Error("[PoliceUniformSystem] ApplySelection failed: " + ex);
            }
        }

        private void ApplyCopModel(Ped player, PedHash hash)
        {
            try
            {
                var m = new Model(hash);
                if (!m.IsInCdImage || !m.IsValid) return;

                m.Request(1000);
                if (!m.IsLoaded) return;

                Function.Call(Hash.SET_PLAYER_MODEL, Game.Player.Handle, (int)m.Hash);
                m.MarkAsNoLongerNeeded();

                // re-fetch
                var p = Game.Player.Character;
                try { Function.Call(Hash.SET_PED_DEFAULT_COMPONENT_VARIATION, p.Handle); } catch { }
                try { Function.Call(Hash.SET_PED_CAN_SWITCH_WEAPON, p.Handle, true); } catch { }


                try { Function.Call(Hash.FREEZE_ENTITY_POSITION, p.Handle, false); } catch { }

                try { Function.Call(Hash.SET_PLAYER_CONTROL, Game.Player.Handle, true, 0); } catch { }
                try { Function.Call(Hash.ENABLE_ALL_CONTROL_ACTIONS, 0); } catch { }
                try { Function.Call(Hash.RENDER_SCRIPT_CAMS, false, false, 0, true, false); } catch { }


                // 换成警员模型后给基础执法武器（best-effort）
                try { p.Weapons.Give(WeaponHash.StunGun, 10, true, true); } catch { }
                try { p.Weapons.Give(WeaponHash.Nightstick, 1, false, false); } catch { }
                try { p.Weapons.Give(WeaponHash.Pistol, 60, false, false); } catch { }
                try { p.Weapons.Give(WeaponHash.CarbineRifle, 120, false, false); } catch { }
            }
            catch (Exception ex)
            {
                ModLog.Error("[PoliceUniformSystem] ApplyCopModel failed: " + ex);
            }
        }

        private void SaveAppearance(Ped player)
        {
            try
            {
                _savedModelHash = player.Model.Hash;

                for (int i = 0; i < 12; i++)
                {
                    _savedDrawable[i] = Function.Call<int>(Hash.GET_PED_DRAWABLE_VARIATION, player.Handle, i);
                    _savedTexture[i] = Function.Call<int>(Hash.GET_PED_TEXTURE_VARIATION, player.Handle, i);
                    _savedPalette[i] = Function.Call<int>(Hash.GET_PED_PALETTE_VARIATION, player.Handle, i);
                }

                for (int p = 0; p < 8; p++)
                {
                    _savedPropIndex[p] = Function.Call<int>(Hash.GET_PED_PROP_INDEX, player.Handle, p);
                    _savedPropTexture[p] = Function.Call<int>(Hash.GET_PED_PROP_TEXTURE_INDEX, player.Handle, p);
                }

                _hasSavedAppearance = true;
                ModLog.Info("[PoliceUniformSystem] Saved player appearance");
            }
            catch (Exception ex)
            {
                ModLog.Error("[PoliceUniformSystem] SaveAppearance failed: " + ex);
                _hasSavedAppearance = false;
            }
        }

        private void RestoreAppearance(Ped player)
        {
            if (!_hasSavedAppearance) return;

            try
            {
                // 若模型不同，先切回原模型
                if (player.Model.Hash != _savedModelHash)
                {
                    var m = new Model(_savedModelHash);
                    if (m.IsInCdImage && m.IsValid)
                    {
                        m.Request(1000);
                        if (m.IsLoaded)
                        {
                            Function.Call(Hash.SET_PLAYER_MODEL, Game.Player.Handle, (int)m.Hash);
                            m.MarkAsNoLongerNeeded();
                        }
                    }
                }

                var p = Game.Player.Character;
                if (p == null || !p.Exists()) return;

                for (int i = 0; i < 12; i++)
                {
                    Function.Call(Hash.SET_PED_COMPONENT_VARIATION, p.Handle, i, _savedDrawable[i], _savedTexture[i], _savedPalette[i]);
                }

                for (int pr = 0; pr < 8; pr++)
                {
                    int idx = _savedPropIndex[pr];
                    if (idx < 0)
                        Function.Call(Hash.CLEAR_PED_PROP, p.Handle, pr);
                    else
                        Function.Call(Hash.SET_PED_PROP_INDEX, p.Handle, pr, idx, _savedPropTexture[pr], true);
                }
            }
            catch (Exception ex)
            {
                ModLog.Error("[PoliceUniformSystem] RestoreAppearance failed: " + ex);
            }
        }

        private void SetupWardrobeCamera(Ped player)
        {
            try
            {
                DestroyWardrobeCamera();

                // 冻结玩家，避免菜单期间乱动
                try { Function.Call(Hash.FREEZE_ENTITY_POSITION, player.Handle, true); } catch { }

                // 在玩家正前方放一个相机，对准玩家（避免相机与实体/墙体穿模导致看不到）
                Vector3 fwd = player.ForwardVector;
                Vector3 camPos = player.Position - fwd * 1.6f + new Vector3(0f, 0f, 0.75f);

                _camHandle = Function.Call<int>(Hash.CREATE_CAM_WITH_PARAMS,
                    "DEFAULT_SCRIPTED_CAMERA",
                    camPos.X, camPos.Y, camPos.Z,
                    0f, 0f, 0f,
                    50f,
                    true,
                    2
                );

                if (_camHandle != 0)
                {
                    Function.Call(Hash.POINT_CAM_AT_ENTITY, _camHandle, player.Handle, 0f, 0f, 0.65f, true);
                    Function.Call(Hash.SET_CAM_ACTIVE, _camHandle, true);
                    Function.Call(Hash.RENDER_SCRIPT_CAMS, true, false, 0, true, false);
                }
            }
            catch (Exception ex)
            {
                ModLog.Error("[PoliceUniformSystem] SetupWardrobeCamera failed: " + ex);
            }
        }

        private void DestroyWardrobeCamera()
        {
            try
            {
                var player = Game.Player.Character;
                if (player != null && player.Exists())
                {
                    try { Function.Call(Hash.FREEZE_ENTITY_POSITION, player.Handle, false); } catch { }
                }

                if (_camHandle != 0)
                {
                    try { Function.Call(Hash.RENDER_SCRIPT_CAMS, false, false, 0, true, false); } catch { }
                    try { Function.Call(Hash.SET_CAM_ACTIVE, _camHandle, false); } catch { }
                    try { Function.Call(Hash.DESTROY_CAM, _camHandle, true); } catch { }
                    _camHandle = 0;
                }
            }
            catch { }
        }
    }
}
