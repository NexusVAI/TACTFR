using EF.PoliceMod.Core;
using EF.PoliceMod.Input;
using GTA;
using GTA.Native;
using System;
using Keys = System.Windows.Forms.Keys;

namespace EF.PoliceMod.Systems
{
    /// <summary>
    /// F7 调度菜单（右上角原生绘制，类似修改器）：
    /// - 小键盘 8 上、2 下、5 确认
    /// - F7 或 Backspace 关闭
    /// </summary>
    public class DispatchMenuController
    {
        private readonly DispatchSupportSystem _support;

        private bool _open;
        private int _lastToggleAtMs;
        private const int ToggleDebounceMs = 250;
        private int _openedAtMs = 0;

        private int _selected = 0;
        private int _lastExecuteAtMs = 0;
        private const int ExecuteDebounceMs = 300;
        private readonly string[] _items = new[]
        {
            "部署钉刺带",
            "部署路障",
            "部署雪糕筒",
            "直升机勘探(嫌疑人丢失后可用)",
        };


        private bool _upHeld;
        private bool _downHeld;
        private bool _confirmHeld;
        private bool _closeHeld;

        private bool IsRawKeyDown(System.Windows.Forms.Keys k)
        {
            return Game.IsKeyPressed(k);
        }

        public DispatchMenuController(DispatchSupportSystem support)
        {
            _support = support;
            EventBus.Subscribe<Open911MenuEvent>(OnOpenRequested);
            EventBus.Subscribe<DutyEndedEvent>(_ => { try { Close(); } catch { } });
            EventBus.Subscribe<EF.PoliceMod.Core.SuspectDeliveredEvent>(_ => { try { Close(); } catch { } });
        }

        private void OnOpenRequested(Open911MenuEvent e)
        {
            ModLog.Info("[DispatchMenu] Toggle requested");

            int now = Game.GameTime;
            if (now - _lastToggleAtMs < ToggleDebounceMs) return;
            _lastToggleAtMs = now;

            if (_open) Close();
            else Open();
        }

        private void Open()
        {
            _open = true;
            UIState.MarkDispatchMenuOpen(Game.GameTime);
            _selected = 0;
            _openedAtMs = Game.GameTime;

            // 防止“按下 F7 打开后，同一帧又被 Tick 判定为 F7 关闭”
            // 这里不再强制 _closeHeld=true，否则会导致“按一次 F7 打开后按不掉（必须松开再按）”
            _closeHeld = false;

            try { Function.Call(Hash.CLEAR_HELP, true); } catch { }
        }

        private void Close()
        {
            _open = false;
            UIState.MarkDispatchMenuClosed();

            _upHeld = false;
            _downHeld = false;
            _confirmHeld = false;
            _closeHeld = false;
        }

        private void DrawMenu()
        {
            // 右上角面板布局（0..1 屏幕归一化坐标）
            float panelW = 0.24f;
            float rowH = 0.032f;
            float headerH = 0.038f;
            float panelH = headerH + (_items.Length * rowH) + 0.01f;
            float panelX = 0.88f;
            float panelY = 0.18f;

            // 背景
            try { Function.Call(Hash.DRAW_RECT, panelX, panelY, panelW, panelH, 0, 0, 0, 170); } catch { }

            // 标题
            try
            {
                Function.Call(Hash.SET_TEXT_FONT, 0);
                Function.Call(Hash.SET_TEXT_SCALE, 0.35f, 0.35f);
                Function.Call(Hash.SET_TEXT_CENTRE, true);
                Function.Call(Hash.SET_TEXT_COLOUR, 80, 170, 255, 255);
                Function.Call(Hash.BEGIN_TEXT_COMMAND_DISPLAY_TEXT, "STRING");
                Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, "调度菜单");
                Function.Call(Hash.END_TEXT_COMMAND_DISPLAY_TEXT, panelX, panelY - panelH / 2 + 0.01f);
            }
            catch { }

            // 列表
            for (int i = 0; i < _items.Length; i++)
            {
                float rowY = (panelY - panelH / 2 + headerH) + (i * rowH) + (rowH / 2);

                // 选中条
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

            // 操作提示（底部）
            try
            {
                Function.Call(Hash.SET_TEXT_FONT, 0);
                Function.Call(Hash.SET_TEXT_SCALE, 0.28f, 0.28f);
                Function.Call(Hash.SET_TEXT_CENTRE, true);
                Function.Call(Hash.SET_TEXT_COLOUR, 200, 200, 200, 255);
                Function.Call(Hash.BEGIN_TEXT_COMMAND_DISPLAY_TEXT, "STRING");
                Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, "小键盘8/2选择 5确认  F7关闭");
                Function.Call(Hash.END_TEXT_COMMAND_DISPLAY_TEXT, panelX, panelY + panelH / 2 - 0.025f);
            }
            catch { }
        }

        private void ExecuteSelected()
        {
            int now = Game.GameTime;
            if (now - _lastExecuteAtMs < ExecuteDebounceMs) return;
            _lastExecuteAtMs = now;

            switch (_selected)
            {
                case 0:
                    _support.TryDeploySpikeStrip();
                    break;
                case 1:
                    _support.TryDeployRoadblock();
                    break;
                case 2:
                    _support.TryDeployTrafficCones();
                    break;
                case 3:
                    EventBus.Publish(new HeliReconRequestedEvent());
                    break;
            }
        }

        public void Tick()
        {
            if (!_open) return;

            UIState.BeatDispatchMenu(Game.GameTime);
            DrawMenu();

            // 关闭（加入延迟，避免刚打开就被同一次按键关掉）
            int now = Game.GameTime;
            // 用原始按键状态：在某些 UI/控制接管情况下，Game.IsKeyPressed 可能检测不到
            bool closeDown = IsRawKeyDown(Keys.F7) || IsRawKeyDown(Keys.Back);
            bool canClose = (now - _openedAtMs) > 250;
            if (closeDown)
            {
                if (canClose && !_closeHeld)
                {
                    Close();
                    return;
                }
                _closeHeld = true;
            }
            else
            {
                _closeHeld = false;
            }

            // 上/下/确认：小键盘 8/2/5
            bool up = Game.IsKeyPressed(Keys.NumPad8);
            bool down = Game.IsKeyPressed(Keys.NumPad2);
            bool confirm = Game.IsKeyPressed(Keys.NumPad5);

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

        public void Shutdown()
        {
            try { EventBus.Unsubscribe<Open911MenuEvent>(OnOpenRequested); } catch { }
            try { Close(); } catch { }
        }
    }
}
