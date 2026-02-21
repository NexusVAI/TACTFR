using System;
using System.Collections.Generic;
using GTA;
using GTA.Native;
using EF.PoliceMod.Data;
using EF.PoliceMod.Core;
using System.Runtime.InteropServices;

namespace EF.PoliceMod.Systems
{
    public class PoliceTerminalUI
    {
        private readonly WantedRegistry _wantedRegistry;
        private readonly Action<int, int> _onSelected;
        private readonly Action _onClosed;

        private bool _open = false;
        private int _index = 0;

        // 纹理字典 / 名称（你要把图片打包成 texture dict，或用 Scaleform）
        private const string BG_TEXTURE_DICT = "efpd_ui";
        private const string BG_TEXTURE_NAME = "terminal_bg";

        private bool _textureRequested = false;
        private bool _num8Held = false, _num2Held = false, _num5Held = false, _num0Held = false;
        private bool _num9Held = false;
        private int _uiInputDebounceMs = 150;
        private int _lastUiInputTime = 0;

        private const int KEY_PRESSED_MASK = 0x8000;
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        private enum TerminalPage
        {
            RootModeSelect,
            CaseTeamSelect,
            CaseList,
        }

        private enum CaseTeamMode
        {
            Single,
            Dual,
        }

        private sealed class TerminalOption
        {
            public int OptionId;
            public int Stars;
            public string DisplayName;
            public string SuspectName;
            public string Crime;
            public string Location;
            public string LastSeen;
            public string Reason;
        }

        private TerminalPage _page = TerminalPage.RootModeSelect;
        private CaseTeamMode _teamMode = CaseTeamMode.Single;
        private List<TerminalOption> _currentOptions = new List<TerminalOption>();

        public PoliceTerminalUI(WantedRegistry registry, Action<int, int> onSelected, Action onClosed)
        {
            _wantedRegistry = registry;
            _onSelected = onSelected;
            _onClosed = onClosed;
        }

        private bool IsRawKeyDown(System.Windows.Forms.Keys k)
        {
            return (GetAsyncKeyState((int)k) & KEY_PRESSED_MASK) != 0;
        }

        public void Open()
        {
            _open = true;
            _page = TerminalPage.RootModeSelect;
            _teamMode = CaseTeamMode.Single;
            _index = 0;
            BuildRootOptions();

            RequestTextureDict();
            EF.PoliceMod.Core.UIState.MarkPoliceTerminalOpened();
        }

        public void Close()
        {
            _open = false;
            _index = 0;
            _page = TerminalPage.RootModeSelect;
            _currentOptions.Clear();
            EF.PoliceMod.Core.UIState.MarkPoliceTerminalClosed();
        }

        public void Update()
        {
            if (!_open) return;
            if (_currentOptions == null || _currentOptions.Count == 0) BuildRootOptions();

            DrawBackground();
            DrawOptions();
            DrawDetails();
            DrawHint();
            HandleInput();
        }

        private void BuildRootOptions()
        {
            _currentOptions = new List<TerminalOption>
            {
                new TerminalOption
                {
                    OptionId = 90,
                    Stars = 0,
                    DisplayName = "巡逻模式（自由行动）",
                    SuspectName = "-",
                    Crime = "主动巡逻",
                    Location = "全域",
                    LastSeen = "系统",
                    Reason = "切换",
                },
                new TerminalOption
                {
                    OptionId = 900,
                    Stars = 1,
                    DisplayName = "案件模式（任务）",
                    SuspectName = "终端派警",
                    Crime = "案件处理",
                    Location = "终端",
                    LastSeen = "系统",
                    Reason = "接警",
                },
            };
            _index = 0;
            _page = TerminalPage.RootModeSelect;
        }

        private void BuildCaseTeamOptions()
        {
            _currentOptions = new List<TerminalOption>
            {
                new TerminalOption
                {
                    OptionId = 910,
                    Stars = 2,
                    DisplayName = "单人案件",
                    SuspectName = "1 名嫌疑人",
                    Crime = "标准处置",
                    Location = "全域",
                    LastSeen = "系统",
                    Reason = "任务",
                },
                new TerminalOption
                {
                    OptionId = 911,
                    Stars = 4,
                    DisplayName = "双人案件",
                    SuspectName = "2 名嫌疑人",
                    Crime = "协同处置",
                    Location = "全域",
                    LastSeen = "系统",
                    Reason = "任务",
                },
            };
            _index = 0;
            _page = TerminalPage.CaseTeamSelect;
        }

        private void BuildCaseList(CaseTeamMode teamMode)
        {
            var names = new[] { "杰克", "亚瑟", "汤米", "尼克", "迈卡", "唐纳德" };
            var crimesOnFoot = new[] { "盗窃", "斗殴", "扰乱治安", "非法入侵" };
            var crimesVehicle = new[] { "拒检逃逸", "危险驾驶", "肇事逃逸" };
            var rnd = new Random(Game.GameTime + (int)teamMode * 31);

            int RollStars(int baseOptionId)
            {
                if (baseOptionId >= 3)
                {
                    int r = rnd.Next(100);
                    if (r < 18) return 5;
                    if (r < 70) return (rnd.Next(2) == 0) ? 3 : 4;
                    return (rnd.Next(2) == 0) ? 2 : 3;
                }

                int r2 = rnd.Next(100);
                if (r2 < 8) return 5;
                if (r2 < 48) return (rnd.Next(2) == 0) ? 3 : 4;
                return (rnd.Next(2) == 0) ? 1 : 2;
            }

            int modeOffset = teamMode == CaseTeamMode.Dual ? 10 : 0;
            string modeText = teamMode == CaseTeamMode.Dual ? "双人" : "单人";

            _currentOptions = new List<TerminalOption>
            {
                new TerminalOption { OptionId = 0 + modeOffset, DisplayName = $"市区 · 步行嫌疑人 · {modeText}", Stars = teamMode == CaseTeamMode.Dual ? Math.Max(4, RollStars(0)) : RollStars(0), LastSeen = "-", Reason = "接警", SuspectName = RandomNames(names, rnd, teamMode), Crime = crimesOnFoot[rnd.Next(crimesOnFoot.Length)], Location = "市区" },
                new TerminalOption { OptionId = 1 + modeOffset, DisplayName = $"郊区 · 步行嫌疑人 · {modeText}", Stars = teamMode == CaseTeamMode.Dual ? Math.Max(4, RollStars(1)) : RollStars(1), LastSeen = "-", Reason = "接警", SuspectName = RandomNames(names, rnd, teamMode), Crime = crimesOnFoot[rnd.Next(crimesOnFoot.Length)], Location = "郊区" },
                new TerminalOption { OptionId = 2 + modeOffset, DisplayName = $"偏远 · 步行嫌疑人 · {modeText}", Stars = teamMode == CaseTeamMode.Dual ? Math.Max(4, RollStars(2)) : RollStars(2), LastSeen = "-", Reason = "接警", SuspectName = RandomNames(names, rnd, teamMode), Crime = crimesOnFoot[rnd.Next(crimesOnFoot.Length)], Location = "偏远" },
                new TerminalOption { OptionId = 3 + modeOffset, DisplayName = $"市区 · 驾车逃逸 · {modeText}", Stars = teamMode == CaseTeamMode.Dual ? 5 : RollStars(3), LastSeen = "-", Reason = "追车", SuspectName = RandomNames(names, rnd, teamMode), Crime = crimesVehicle[rnd.Next(crimesVehicle.Length)], Location = "市区" },
                new TerminalOption { OptionId = 4 + modeOffset, DisplayName = $"郊区 · 驾车逃逸 · {modeText}", Stars = teamMode == CaseTeamMode.Dual ? 5 : RollStars(4), LastSeen = "-", Reason = "追车", SuspectName = RandomNames(names, rnd, teamMode), Crime = crimesVehicle[rnd.Next(crimesVehicle.Length)], Location = "郊区" },
                new TerminalOption { OptionId = 5 + modeOffset, DisplayName = $"偏远 · 驾车逃逸 · {modeText}", Stars = teamMode == CaseTeamMode.Dual ? 5 : RollStars(5), LastSeen = "-", Reason = "追车", SuspectName = RandomNames(names, rnd, teamMode), Crime = crimesVehicle[rnd.Next(crimesVehicle.Length)], Location = "偏远" },
            };

            _teamMode = teamMode;
            _page = TerminalPage.CaseList;
            _index = 0;
        }

        private static string RandomNames(string[] names, Random rnd, CaseTeamMode teamMode)
        {
            if (teamMode == CaseTeamMode.Dual)
            {
                return names[rnd.Next(names.Length)] + " & " + names[rnd.Next(names.Length)];
            }
            return names[rnd.Next(names.Length)];
        }

        private void DrawBackground()
        {
            if (HasTexture())
            {
                Function.Call(Hash.DRAW_SPRITE, BG_TEXTURE_DICT, BG_TEXTURE_NAME, 0.5f, 0.5f, 1.0f, 1.0f, 0.0f, 255, 255, 255, 255);
            }
            else
            {
                DrawRect(0.5f, 0.5f, 1.0f, 1.0f, 0, 36, 77, 220);
            }
        }

        private void DrawOptions()
        {
            float x = 0.12f;
            float y = 0.16f;

            string title = "警务终端";
            if (_page == TerminalPage.RootModeSelect) title = "警务终端 · 模式选择";
            if (_page == TerminalPage.CaseTeamSelect) title = "警务终端 · 任务人数";
            if (_page == TerminalPage.CaseList) title = "警务终端 · 案件列表";
            DrawText2D(title, x, y - 0.05f, 0.4f, true);

            for (int i = 0; i < _currentOptions.Count && i < 8; i++)
            {
                var rec = _currentOptions[i];
                float yy = y + i * 0.06f;
                bool active = (i == _index);

                string stars = new string('★', Math.Max(0, Math.Min(5, rec.Stars))) + new string('☆', Math.Max(0, 5 - Math.Max(0, Math.Min(5, rec.Stars))));
                var c = GetRiskColor(rec.Stars);
                DrawText2D(rec.DisplayName + $"  {stars}  [{rec.LastSeen}]", x, yy, active ? 0.45f : 0.37f, active, false, c.r, c.g, c.b, 255);
            }
        }

        private void DrawDetails()
        {
            var cur = _currentOptions[Math.Max(0, Math.Min(_index, _currentOptions.Count - 1))];
            DrawText2D("详情:", 0.55f, 0.16f, 0.40f, true);
            DrawText2D($"姓名: {(string.IsNullOrEmpty(cur.SuspectName) ? "未知" : cur.SuspectName)}", 0.55f, 0.20f, 0.35f, false);
            DrawText2D($"罪行: {(string.IsNullOrEmpty(cur.Crime) ? "-" : cur.Crime)}", 0.55f, 0.24f, 0.35f, false);
            DrawText2D($"地点: {(string.IsNullOrEmpty(cur.Location) ? "-" : cur.Location)}", 0.55f, 0.28f, 0.35f, false);

            string riskText = (cur.Stars >= 5) ? "高危" : (cur.Stars >= 3 ? "中危" : "普通");
            var rc = GetRiskColor(cur.Stars);
            DrawText2D($"风险: {riskText}  ({cur.Stars}/5)", 0.55f, 0.32f, 0.35f, true, false, rc.r, rc.g, rc.b, 255);
            DrawText2D($"类型: {cur.DisplayName}", 0.55f, 0.36f, 0.35f, false);
        }

        private void DrawHint()
        {
            string hint = "[Num8]上  [Num2]下  [Num5]确认  [Num9]刷新  [Num0]退出";
            if (_page == TerminalPage.RootModeSelect || _page == TerminalPage.CaseTeamSelect)
            {
                hint = "[Num8]上  [Num2]下  [Num5]确认  [Num0]退出";
            }
            else if (_page == TerminalPage.CaseList)
            {
                hint = $"[Num8]上  [Num2]下  [Num5]确认  [Num9]刷新{(_teamMode == CaseTeamMode.Dual ? "双人" : "单人")}列表  [Num0]返回";
            }

            DrawText2D(hint, 0.5f, 0.92f, 0.30f, false, alignCenter: true);
        }

        private void HandleInput()
        {
            int now = Game.GameTime;

            if (IsRawKeyDown(System.Windows.Forms.Keys.NumPad8))
            {
                if (!_num8Held && now - _lastUiInputTime >= _uiInputDebounceMs)
                {
                    _index = Math.Max(0, _index - 1);
                    _num8Held = true;
                    _lastUiInputTime = now;
                }
            }
            else _num8Held = false;

            if (IsRawKeyDown(System.Windows.Forms.Keys.NumPad2))
            {
                if (!_num2Held && now - _lastUiInputTime >= _uiInputDebounceMs)
                {
                    _index = Math.Min(_currentOptions.Count - 1, _index + 1);
                    _num2Held = true;
                    _lastUiInputTime = now;
                }
            }
            else _num2Held = false;

            if (IsRawKeyDown(System.Windows.Forms.Keys.NumPad5))
            {
                if (!_num5Held && now - _lastUiInputTime >= _uiInputDebounceMs)
                {
                    _num5Held = true;
                    _lastUiInputTime = now;
                    ConfirmCurrent();
                }
            }
            else _num5Held = false;

            if (IsRawKeyDown(System.Windows.Forms.Keys.NumPad0))
            {
                if (!_num0Held && now - _lastUiInputTime >= _uiInputDebounceMs)
                {
                    _num0Held = true;
                    _lastUiInputTime = now;
                    BackOrClose();
                }
            }
            else _num0Held = false;

            if (IsRawKeyDown(System.Windows.Forms.Keys.NumPad9))
            {
                if (!_num9Held && now - _lastUiInputTime >= _uiInputDebounceMs)
                {
                    _num9Held = true;
                    _lastUiInputTime = now;
                    if (_page == TerminalPage.CaseList)
                    {
                        BuildCaseList(_teamMode);
                    }
                }
            }
            else _num9Held = false;
        }

        private void ConfirmCurrent()
        {
            if (_currentOptions == null || _currentOptions.Count == 0) return;

            var rec = _currentOptions[Math.Max(0, Math.Min(_index, _currentOptions.Count - 1))];

            // 第一层：模式选择
            if (_page == TerminalPage.RootModeSelect)
            {
                if (rec.OptionId == 90)
                {
                    _onSelected?.Invoke(90, 0);
                    return;
                }

                if (rec.OptionId == 900)
                {
                    BuildCaseTeamOptions();
                }
                return;
            }

            // 第二层：任务人数
            if (_page == TerminalPage.CaseTeamSelect)
            {
                if (rec.OptionId == 910)
                {
                    BuildCaseList(CaseTeamMode.Single);
                }
                else if (rec.OptionId == 911)
                {
                    BuildCaseList(CaseTeamMode.Dual);
                }
                return;
            }

            // 第三层：派发案件
            if (_page == TerminalPage.CaseList)
            {
                ModLog.Info($"[TerminalUI] Confirm case: index={_index}, optionId={rec.OptionId}, stars={rec.Stars}, team={_teamMode}");
                _onSelected?.Invoke(rec.OptionId, rec.Stars);
            }
        }

        private void BackOrClose()
        {
            if (_page == TerminalPage.CaseList)
            {
                BuildCaseTeamOptions();
                return;
            }

            if (_page == TerminalPage.CaseTeamSelect)
            {
                BuildRootOptions();
                return;
            }

            _onClosed?.Invoke();
        }

        private void RequestTextureDict()
        {
            if (_textureRequested) return;
            _textureRequested = true;
            Function.Call(Hash.REQUEST_STREAMED_TEXTURE_DICT, BG_TEXTURE_DICT, true);
        }

        private bool HasTexture()
        {
            try
            {
                return Function.Call<bool>(Hash.HAS_STREAMED_TEXTURE_DICT_LOADED, BG_TEXTURE_DICT);
            }
            catch { return false; }
        }

        private void DrawRect(float x, float y, float width, float height, int r, int g, int b, int a)
        {
            Function.Call(Hash.DRAW_RECT, x, y, width, height, r, g, b, a);
        }

        private (int r, int g, int b) GetRiskColor(int stars)
        {
            if (stars >= 5) return (220, 40, 40);
            if (stars >= 3) return (255, 160, 0);
            return (255, 255, 255);
        }

        private void DrawText2D(string text, float x, float y, float scale = 0.4f, bool bold = false, bool alignCenter = false, int r = 255, int g = 255, int b = 255, int a = 255)
        {
            Function.Call(Hash.SET_TEXT_FONT, 0);
            Function.Call(Hash.SET_TEXT_SCALE, scale, scale);
            Function.Call(Hash.SET_TEXT_WRAP, 0.0f, 1.0f);
            Function.Call(Hash.SET_TEXT_CENTRE, alignCenter);
            Function.Call(Hash.SET_TEXT_COLOUR, r, g, b, a);

            Function.Call(Hash.BEGIN_TEXT_COMMAND_DISPLAY_TEXT, "STRING");
            Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, text);
            Function.Call(Hash.END_TEXT_COMMAND_DISPLAY_TEXT, x, y);
        }
    }
}
