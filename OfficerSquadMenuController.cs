using EF.PoliceMod.Core;
using EF.PoliceMod.Input;
using GTA;
using GTA.Native;
using System;
using System.Runtime.InteropServices;
using Keys = System.Windows.Forms.Keys;

namespace EF.PoliceMod.Systems
{
    /// <summary>
    /// F8：警员小队控制菜单
    /// - 4/6 切换对象（1/2/全体）
    /// - 8/2 选择命令
    /// - 5 确认
    /// - Back 取消
    /// </summary>
    public class OfficerSquadMenuController
    {
        private readonly OfficerSquadSystem _squad;

        private bool _open = false;
        private int _selectedCmd = 0;
        private int _targetIndex = 2; // 0=1,1=2,2=all

        private int _openedAtMs = 0;
        private int _lastToggleAtMs = 0;
        private const int ToggleDebounceMs = 250;

        private const int KEY_PRESSED_MASK = 0x8000;
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        private bool IsRawKeyDown(System.Windows.Forms.Keys k)
        {
            return (GetAsyncKeyState((int)k) & KEY_PRESSED_MASK) != 0;
        }

        private bool _upHeld = false;
        private bool _downHeld = false;
        private bool _leftHeld = false;
        private bool _rightHeld = false;
        private bool _confirmHeld = false;
        private bool _cancelHeld = false;

        private readonly (string title, OfficerCommand cmd)[] _items = new (string, OfficerCommand)[]
        {
            ("呼叫增援（2人）", OfficerCommand.Summon2),
            ("跟随我", OfficerCommand.Follow),
            ("原地待命", OfficerCommand.Hold),
            ("全部集合到我身边", OfficerCommand.Regroup),
            ("上我的车(我在车内)", OfficerCommand.EnterPlayerVehicle),
            ("下车", OfficerCommand.ExitVehicle),
            ("模式：非致命", OfficerCommand.ModeNonLethal),
            ("模式：致命", OfficerCommand.ModeLethal),
            ("抓捕模式(自动追捕/上拷，无需L锁定)", OfficerCommand.ToggleArrestMode),
            ("解雇当前(散伙)", OfficerCommand.Dismiss),
            ("解雇全部(散伙)", OfficerCommand.DismissAll),
        };

        public OfficerSquadMenuController(OfficerSquadSystem squad)
        {
            _squad = squad;
            EventBus.Subscribe<OpenOfficerSquadMenuEvent>(_ => Toggle());
            EventBus.Subscribe<DutyEndedEvent>(_ => Close());
        }

        private void Toggle()
        {
            int now = Game.GameTime;
            if (now - _lastToggleAtMs < ToggleDebounceMs) return;
            _lastToggleAtMs = now;

            if (_open) Close(); else Open();
        }

        private void Open()
        {
            _open = true;
            _selectedCmd = 0;
            _openedAtMs = Game.GameTime;
            UIState.MarkOfficerSquadMenuOpen(Game.GameTime);
        }

        private void Close()
        {
            _open = false;
            UIState.MarkOfficerSquadMenuClosed();

            _upHeld = _downHeld = _leftHeld = _rightHeld = _confirmHeld = _cancelHeld = false;
        }

        public void Tick()
        {
            if (!_open) return;

            UIState.BeatOfficerSquadMenu(Game.GameTime);

            // F8 关闭（用 raw key + 延迟，避免刚打开就同一帧关掉）
            int now = Game.GameTime;
            bool canClose = (now - _openedAtMs) > 250;
            if (canClose && IsRawKeyDown(Keys.F8))
            {
                if (now - _lastToggleAtMs >= ToggleDebounceMs)
                {
                    _lastToggleAtMs = now;
                    Close();
                    return;
                }
            }

            Draw();
            HandleInput();
        }

        private OfficerTargetSelection CurrentTarget
        {
            get
            {
                if (_targetIndex == 0) return OfficerTargetSelection.Officer1;
                if (_targetIndex == 1) return OfficerTargetSelection.Officer2;
                return OfficerTargetSelection.All;
            }
        }

        private string TargetLabel
        {
            get
            {
                if (_targetIndex == 0) return "警员1";
                if (_targetIndex == 1) return "警员2";
                return "全体";
            }
        }

        private void Draw()
        {
            float panelW = 0.34f;
            float rowH = 0.030f;
            float headerH = 0.040f;
            float panelH = headerH + (_items.Length * rowH) + 0.012f;
            float x = 0.83f;
            float y = 0.28f;

            try { Function.Call(Hash.DRAW_RECT, x, y, panelW, panelH, 0, 0, 0, 190); } catch { }

            try
            {
                Function.Call(Hash.SET_TEXT_FONT, 0);
                Function.Call(Hash.SET_TEXT_SCALE, 0.34f, 0.34f);
                Function.Call(Hash.SET_TEXT_CENTRE, true);
                Function.Call(Hash.SET_TEXT_COLOUR, 120, 200, 255, 255);
                Function.Call(Hash.BEGIN_TEXT_COMMAND_DISPLAY_TEXT, "STRING");
                string mode = (_squad != null && _squad.ModeNonLethal) ? "非致命" : "致命";
                string arrest = (_squad != null && _squad.ArrestMode) ? "抓捕:开" : "抓捕:关";
                Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, $"警员小队(F8)  目标:{TargetLabel}  {mode}  {arrest}");
                Function.Call(Hash.END_TEXT_COMMAND_DISPLAY_TEXT, x, y - panelH / 2 + 0.01f);
            }
            catch { }

            for (int i = 0; i < _items.Length; i++)
            {
                float rowY = (y - panelH / 2 + headerH) + (i * rowH) + (rowH / 2);
                if (i == _selectedCmd)
                {
                    try { Function.Call(Hash.DRAW_RECT, x, rowY, panelW - 0.01f, rowH, 255, 255, 255, 35); } catch { }
                }

                try
                {
                    Function.Call(Hash.SET_TEXT_FONT, 0);
                    Function.Call(Hash.SET_TEXT_SCALE, 0.29f, 0.29f);
                    Function.Call(Hash.SET_TEXT_CENTRE, false);
                    Function.Call(Hash.SET_TEXT_COLOUR, 255, 255, 255, 255);
                    Function.Call(Hash.BEGIN_TEXT_COMMAND_DISPLAY_TEXT, "STRING");
                    Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, (i == _selectedCmd ? "> " : "  ") + _items[i].title);
                    Function.Call(Hash.END_TEXT_COMMAND_DISPLAY_TEXT, x - panelW / 2 + 0.01f, rowY - 0.012f);
                }
                catch { }
            }

            try
            {
                Function.Call(Hash.SET_TEXT_FONT, 0);
                Function.Call(Hash.SET_TEXT_SCALE, 0.26f, 0.26f);
                Function.Call(Hash.SET_TEXT_CENTRE, true);
                Function.Call(Hash.SET_TEXT_COLOUR, 200, 200, 200, 255);
                Function.Call(Hash.BEGIN_TEXT_COMMAND_DISPLAY_TEXT, "STRING");
                string leftKey = KeyBindings.MenuLeft.ToString();
                string rightKey = KeyBindings.MenuRight.ToString();
                string upKey = KeyBindings.MenuUp.ToString();
                string downKey = KeyBindings.MenuDown.ToString();
                string confirmKey = KeyBindings.MenuConfirm.ToString();
                string cancelKey = KeyBindings.MenuCancel.ToString();
                Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, $"{leftKey}/{rightKey}切换对象 {upKey}/{downKey}选择 {confirmKey}确认 {cancelKey}取消");
                Function.Call(Hash.END_TEXT_COMMAND_DISPLAY_TEXT, x, y + panelH / 2 - 0.025f);
            }
            catch { }
        }

        private void HandleInput()
        {
            bool cancel = Game.IsKeyPressed(KeyBindings.MenuCancel);
            if (cancel)
            {
                if (!_cancelHeld)
                {
                    _cancelHeld = true;
                    Close();
                }
                return;
            }
            _cancelHeld = false;

            bool left = Game.IsKeyPressed(KeyBindings.MenuLeft);
            bool right = Game.IsKeyPressed(KeyBindings.MenuRight);
            bool up = Game.IsKeyPressed(KeyBindings.MenuUp);
            bool down = Game.IsKeyPressed(KeyBindings.MenuDown);
            bool confirm = Game.IsKeyPressed(KeyBindings.MenuConfirm);

            if (left)
            {
                if (!_leftHeld)
                {
                    _targetIndex--;
                    if (_targetIndex < 0) _targetIndex = 2;
                }
                _leftHeld = true;
            }
            else _leftHeld = false;

            if (right)
            {
                if (!_rightHeld)
                {
                    _targetIndex++;
                    if (_targetIndex > 2) _targetIndex = 0;
                }
                _rightHeld = true;
            }
            else _rightHeld = false;

            if (up)
            {
                if (!_upHeld)
                {
                    _selectedCmd--;
                    if (_selectedCmd < 0) _selectedCmd = _items.Length - 1;
                }
                _upHeld = true;
            }
            else _upHeld = false;

            if (down)
            {
                if (!_downHeld)
                {
                    _selectedCmd++;
                    if (_selectedCmd >= _items.Length) _selectedCmd = 0;
                }
                _downHeld = true;
            }
            else _downHeld = false;

            if (confirm)
            {
                if (!_confirmHeld)
                {
                    var cmd = _items[_selectedCmd].cmd;
                    _squad.Execute(CurrentTarget, cmd);

                    // 低耦合：呼叫小队音效触发
                    try
                    {
                        if (cmd == OfficerCommand.Summon2)
                            EventBus.Publish(new OfficerSquadSummonRequestedEvent());
                    }
                    catch { }
                }
                _confirmHeld = true;
            }
            else _confirmHeld = false;
        }
    }
}
