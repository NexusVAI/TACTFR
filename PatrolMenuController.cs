using EF.PoliceMod.Core;
using GTA;
using GTA.Native;
using GTA.UI;
using System;
using System.Runtime.InteropServices;
using Keys = System.Windows.Forms.Keys;

namespace EF.PoliceMod.Systems
{
    /// <summary>
    /// 巡逻模式命令菜单（J 打开）：小键盘 8/2 选择，5 确认，J/Num0 关闭
    /// </summary>
    public sealed class PatrolMenuController
    {
        private bool _open = false;
        private int _selected = 0;
        private int _openedAtMs = 0;
        private int _lastToggleAtMs = 0;
        private const int ToggleDebounceMs = 250;

        private bool _upHeld = false;
        private bool _downHeld = false;
        private bool _confirmHeld = false;
        private bool _cancelHeld = false;

        private readonly string[] _items = new[]
        {
            "快速检查(概率)",
            "要求出示身份证(概率)",
            "搜查(概率)",
        };

        private const int KEY_PRESSED_MASK = 0x8000;
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        private bool IsRawKeyDown(System.Windows.Forms.Keys k)
        {
            return (GetAsyncKeyState((int)k) & KEY_PRESSED_MASK) != 0;
        }

        public PatrolMenuController()
        {
            EventBus.Subscribe<PatrolMenuToggledEvent>(e =>
            {
                if (e.Open) Open();
                else Close();
            });
            EventBus.Subscribe<DutyEndedEvent>(_ => Close());
        }

        private void Open()
        {
            _open = true;
            _selected = 0;
            _openedAtMs = Game.GameTime;
        }

        private void Close()
        {
            _open = false;
            _upHeld = _downHeld = _confirmHeld = _cancelHeld = false;
        }

        public void Tick()
        {
            if (!_open) return;

            DrawMenu();
            HandleInput();
        }

        private void DrawMenu()
        {
            float panelW = 0.26f;
            float rowH = 0.032f;
            float headerH = 0.038f;
            float panelH = headerH + (_items.Length * rowH) + 0.01f;
            float panelX = 0.80f;
            float panelY = 0.62f;

            try { Function.Call(Hash.DRAW_RECT, panelX, panelY, panelW, panelH, 0, 0, 0, 170); } catch { }

            try
            {
                Function.Call(Hash.SET_TEXT_FONT, 0);
                Function.Call(Hash.SET_TEXT_SCALE, 0.34f, 0.34f);
                Function.Call(Hash.SET_TEXT_CENTRE, true);
                Function.Call(Hash.SET_TEXT_COLOUR, 120, 200, 255, 255);
                Function.Call(Hash.BEGIN_TEXT_COMMAND_DISPLAY_TEXT, "STRING");
                Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, "巡逻指令(J)");
                Function.Call(Hash.END_TEXT_COMMAND_DISPLAY_TEXT, panelX, panelY - panelH / 2 + 0.01f);
            }
            catch { }

            for (int i = 0; i < _items.Length; i++)
            {
                float rowY = (panelY - panelH / 2 + headerH) + (i * rowH) + (rowH / 2);
                if (i == _selected)
                {
                    try { Function.Call(Hash.DRAW_RECT, panelX, rowY, panelW - 0.01f, rowH, 255, 255, 255, 35); } catch { }
                }

                try
                {
                    Function.Call(Hash.SET_TEXT_FONT, 0);
                    Function.Call(Hash.SET_TEXT_SCALE, 0.32f, 0.32f);
                    Function.Call(Hash.SET_TEXT_CENTRE, false);
                    Function.Call(Hash.SET_TEXT_COLOUR, 255, 255, 255, 255);
                    Function.Call(Hash.BEGIN_TEXT_COMMAND_DISPLAY_TEXT, "STRING");
                    Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, (i == _selected ? "> " : "  ") + _items[i]);
                    Function.Call(Hash.END_TEXT_COMMAND_DISPLAY_TEXT, panelX - panelW / 2 + 0.01f, rowY - 0.012f);
                }
                catch { }
            }

            try
            {
                Function.Call(Hash.SET_TEXT_FONT, 0);
                Function.Call(Hash.SET_TEXT_SCALE, 0.28f, 0.28f);
                Function.Call(Hash.SET_TEXT_CENTRE, true);
                Function.Call(Hash.SET_TEXT_COLOUR, 200, 200, 200, 255);
                Function.Call(Hash.BEGIN_TEXT_COMMAND_DISPLAY_TEXT, "STRING");
                Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, "小键盘8/2选择 5确认  J/Num0关闭");
                Function.Call(Hash.END_TEXT_COMMAND_DISPLAY_TEXT, panelX, panelY + panelH / 2 - 0.025f);
            }
            catch { }
        }

        private void HandleInput()
        {
            int now = Game.GameTime;
            bool canClose = (now - _openedAtMs) > 250;

            bool cancel = IsRawKeyDown(Keys.NumPad0)
                || IsRawKeyDown(EF.PoliceMod.Core.KeyBindings.PatrolMenu)
                || IsRawKeyDown(Keys.Back);
            if (cancel && canClose)
            {
                if (!_cancelHeld)
                {
                    _cancelHeld = true;
                    Close();
                }
                return;
            }
            _cancelHeld = false;

            bool up = IsRawKeyDown(Keys.NumPad8);
            bool down = IsRawKeyDown(Keys.NumPad2);
            bool confirm = IsRawKeyDown(Keys.NumPad5);

            if (up)
            {
                if (!_upHeld)
                {
                    _selected--;
                    if (_selected < 0) _selected = _items.Length - 1;
                }
                _upHeld = true;
            }
            else _upHeld = false;

            if (down)
            {
                if (!_downHeld)
                {
                    _selected++;
                    if (_selected >= _items.Length) _selected = 0;
                }
                _downHeld = true;
            }
            else _downHeld = false;

            if (confirm)
            {
                if (!_confirmHeld)
                {
                    ExecuteSelected();
                }
                _confirmHeld = true;
            }
            else _confirmHeld = false;
        }

        private void ExecuteSelected()
        {
            switch (_selected)
            {
                case 0:
                    EventBus.Publish(new PatrolCheckRequestedEvent());
                    break;
                case 1:
                    EventBus.Publish(new PatrolRequestIdEvent());
                    break;
                case 2:
                    EventBus.Publish(new PatrolSearchRequestedEvent());
                    break;
            }
        }
    }
}

