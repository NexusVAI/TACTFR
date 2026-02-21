using EF.PoliceMod.Core;
using EF.PoliceMod.Input;
using GTA;
using GTA.UI;
using System;
using Keys = System.Windows.Forms.Keys;

namespace EF.PoliceMod.Systems
{
    /// <summary>
    /// H 键拘捕动作菜单：
    /// 1) 铐起嫌疑人并牵着走
    /// 2) 要求嫌疑人抱头自己跟随
    /// 小键盘 8/2 选择，5 确认；Backspace 取消。
    /// </summary>
    public class ArrestMenuController
    {
        private bool _open;

        private int _selected = 0;
        private readonly string[] _items = new[]
        {
            "1. 铐起嫌疑人拉着他",
            "2. 抱头跟随",
        };

        private bool _upHeld;
        private bool _downHeld;
        private bool _confirmHeld;
        private bool _closeHeld;

        public ArrestMenuController()
        {
            EventBus.Subscribe<OpenArrestActionMenuEvent>(OnOpenRequested);
            EventBus.Subscribe<DutyEndedEvent>(_ => { try { Close(); } catch { } });
            EventBus.Subscribe<EF.PoliceMod.Core.SuspectDeliveredEvent>(_ => { try { Close(); } catch { } });
        }

        private void OnOpenRequested(OpenArrestActionMenuEvent e)
        {
            if (_open) return;
            Open();
        }

        private void Open()
        {
            _open = true;
            UIState.MarkArrestMenuOpen(Game.GameTime);
            _selected = 0;
        }

        private void Close()
        {
            _open = false;
            UIState.MarkArrestMenuClosed();

            _upHeld = false;
            _downHeld = false;
            _confirmHeld = false;
            _closeHeld = false;
        }

        private void DrawMenu()
        {
            // 兼容版 UI：不依赖 Native Hash，避免与本地自定义 Hash 枚举冲突导致编译失败。
            string line1 = (_selected == 0 ? "> " : "  ") + _items[0];
            string line2 = (_selected == 1 ? "> " : "  ") + _items[1];
            Screen.ShowSubtitle("~b~拘捕动作~s~\n" + line1 + "\n" + line2 + "\n~c~小键盘8/2选择 5确认  Back取消", 1);
        }

        private void ExecuteSelected()
        {
            if (_selected == 0)
                ArrestStyleState.SelectedStyle = ArrestActionStyle.CuffAndLead;
            else
                ArrestStyleState.SelectedStyle = ArrestActionStyle.HandsOnHeadFollow;

            EventBus.Publish(new AttemptArrestEvent());
        }

        public void Tick()
        {
            if (!_open) return;

            UIState.BeatArrestMenu(Game.GameTime);
            DrawMenu();

            bool close = Game.IsKeyPressed(Keys.Back);
            if (close)
            {
                if (!_closeHeld)
                {
                    _closeHeld = true;
                    Close();
                }
                return;
            }
            _closeHeld = false;

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
                    Close();
                }
                _confirmHeld = true;
            }
            else _confirmHeld = false;
        }

        public void Shutdown()
        {
            try { EventBus.Unsubscribe<OpenArrestActionMenuEvent>(OnOpenRequested); } catch { }
            try { Close(); } catch { }
        }
    }
}
