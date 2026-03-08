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
            string line1 = (_selected == 0 ? "> " : "  ") + _items[0];
            string line2 = (_selected == 1 ? "> " : "  ") + _items[1];
            string upKey = KeyBindings.MenuUp.ToString();
            string downKey = KeyBindings.MenuDown.ToString();
            string confirmKey = KeyBindings.MenuConfirm.ToString();
            string cancelKey = KeyBindings.MenuCancel.ToString();
            Screen.ShowSubtitle(
                $"~b~拘捕动作~s~\n{line1}\n{line2}\n~c~{upKey}/{downKey}选择 {confirmKey}确认 {cancelKey}取消",
                1
            );
        }

        private void ExecuteSelected()
        {
            ArrestActionStyle selectedStyle;
            if (_selected == 0)
                selectedStyle = ArrestActionStyle.CuffAndLead;
            else
                selectedStyle = ArrestActionStyle.HandsOnHeadFollow;

            try
            {
                var core = EFCore.Instance;
                var lts = core != null ? core.LockTargetSystem : null;
                try { core?.GetSuspectController()?.SetPendingArrestStyle(selectedStyle); } catch { }
                var target = lts != null ? lts.CurrentTarget : null;
                if (target != null && target.Exists())
                {
                    EventBus.Publish(new EF.PoliceMod.Core.SuspectArrestStyleSelectedEvent(target.Handle, selectedStyle));
                }
            }
            catch { }

            EventBus.Publish(new AttemptArrestEvent());
        }

        public void Tick()
        {
            if (!_open) return;

            UIState.BeatArrestMenu(Game.GameTime);
            DrawMenu();

            bool close = Game.IsKeyPressed(KeyBindings.MenuCancel);
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

            bool up = Game.IsKeyPressed(KeyBindings.MenuUp);
            bool down = Game.IsKeyPressed(KeyBindings.MenuDown);
            bool confirm = Game.IsKeyPressed(KeyBindings.MenuConfirm);

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
                    try
                    {
                        ExecuteSelected();
                    }
                    catch (Exception ex)
                    {
                        ModLog.Error("[ArrestMenu] ExecuteSelected 失败：" + ex);
                    }
                    finally
                    {
                        Close();
                    }
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
