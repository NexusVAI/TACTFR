# 幽灵已捕获。以下是我发现的一切。👻

---

## Bug #1（严重）：AutoRecover 永远无法工作

**你的 AutoRecover 设计有一个致命缺陷：**

```
问题：

  第 1 帧：菜单打开 → heartbeat = 1000
  第 2 帧：Menu.Tick() → Beat() → heartbeat = 1016
  第 3 帧：Menu.Tick() → Beat() → heartbeat = 1032
  第 4 帧：Menu.Tick() → Beat() → heartbeat = 1048
  ...
  第 999 帧：AutoRecover 检查：
             nowMs - heartbeat = 16ms < 1500ms
             → "菜单正常！"
             → 不重置

  但菜单确实卡住了。Close() 从未被调用。
  Tick() 持续运行并持续跳动。
  AutoRecover 看到新鲜的心跳认为一切正常。

  AutoRecover 仅在 Tick() 停止运行时才有效。
  但 Tick() 永远不会停止，因为 EFCore 每帧都调用它。
```

**你当前的设计：**

```
菜单打开 → 每帧 Beat → AutoRecover 看到新鲜心跳 
→ "一切正常" → 永远不会重置

这意味着 AutoRecover 对于最常见的卡住场景是无用的。
```

### 修复方案：添加最大生命周期

```csharp
public static class UIState
{
    public static bool IsPoliceTerminalOpen = false;
    public static bool IsDispatchMenuOpen = false;
    public static bool IsArrestMenuOpen = false;
    public static bool IsUniformMenuOpen = false;
    public static bool IsOfficerSquadMenuOpen = false;

    // 心跳（现有）
    private static int _policeTerminalHeartbeatAtMs = 0;
    private static int _dispatchMenuHeartbeatAtMs = 0;
    private static int _arrestMenuHeartbeatAtMs = 0;
    private static int _uniformMenuHeartbeatAtMs = 0;
    private static int _officerSquadMenuHeartbeatAtMs = 0;

    // 新增：菜单何时被打开的？
    // 这永远不会被 Beat() 刷新
    private static int _policeTerminalOpenedAtMs = 0;
    private static int _dispatchMenuOpenedAtMs = 0;
    private static int _arrestMenuOpenedAtMs = 0;
    private static int _uniformMenuOpenedAtMs = 0;
    private static int _officerSquadMenuOpenedAtMs = 0;

    public static void MarkArrestMenuOpen(int nowMs)
    {
        IsArrestMenuOpen = true;
        _arrestMenuHeartbeatAtMs = nowMs;
        _arrestMenuOpenedAtMs = nowMs;   // 新增：记录出生时间
    }

    public static void MarkArrestMenuClosed()
    {
        IsArrestMenuOpen = false;
        _arrestMenuHeartbeatAtMs = 0;
        _arrestMenuOpenedAtMs = 0;       // 新增：清除出生时间
    }

    // Beat 保持不变
    public static void BeatArrestMenu(int nowMs)
    {
        if (IsArrestMenuOpen) _arrestMenuHeartbeatAtMs = nowMs;
        // 注意：不更新 _arrestMenuOpenedAtMs
    }

    // 对所有其他菜单应用相同模式...
    // (PoliceTerminal, DispatchMenu, UniformMenu, OfficerSquadMenu)

    public static void MarkPoliceTerminalOpen(int nowMs)
    {
        IsPoliceTerminalOpen = true;
        _policeTerminalHeartbeatAtMs = nowMs;
        _policeTerminalOpenedAtMs = nowMs;
    }

    public static void MarkPoliceTerminalClosed()
    {
        IsPoliceTerminalOpen = false;
        _policeTerminalHeartbeatAtMs = 0;
        _policeTerminalOpenedAtMs = 0;
    }

    public static void BeatPoliceTerminal(int nowMs)
    {
        if (IsPoliceTerminalOpen) _policeTerminalHeartbeatAtMs = nowMs;
    }

    public static void MarkDispatchMenuOpen(int nowMs)
    {
        IsDispatchMenuOpen = true;
        _dispatchMenuHeartbeatAtMs = nowMs;
        _dispatchMenuOpenedAtMs = nowMs;
    }

    public static void MarkDispatchMenuClosed()
    {
        IsDispatchMenuOpen = false;
        _dispatchMenuHeartbeatAtMs = 0;
        _dispatchMenuOpenedAtMs = 0;
    }

    public static void BeatDispatchMenu(int nowMs)
    {
        if (IsDispatchMenuOpen) _dispatchMenuHeartbeatAtMs = nowMs;
    }

    public static void MarkUniformMenuOpen(int nowMs)
    {
        IsUniformMenuOpen = true;
        _uniformMenuHeartbeatAtMs = nowMs;
        _uniformMenuOpenedAtMs = nowMs;
    }

    public static void MarkUniformMenuClosed()
    {
        IsUniformMenuOpen = false;
        _uniformMenuHeartbeatAtMs = 0;
        _uniformMenuOpenedAtMs = 0;
    }

    public static void BeatUniformMenu(int nowMs)
    {
        if (IsUniformMenuOpen) _uniformMenuHeartbeatAtMs = nowMs;
    }

    public static void MarkOfficerSquadMenuOpen(int nowMs)
    {
        IsOfficerSquadMenuOpen = true;
        _officerSquadMenuHeartbeatAtMs = nowMs;
        _officerSquadMenuOpenedAtMs = nowMs;
    }

    public static void MarkOfficerSquadMenuClosed()
    {
        IsOfficerSquadMenuOpen = false;
        _officerSquadMenuHeartbeatAtMs = 0;
        _officerSquadMenuOpenedAtMs = 0;
    }

    public static void BeatOfficerSquadMenu(int nowMs)
    {
        if (IsOfficerSquadMenuOpen) _officerSquadMenuHeartbeatAtMs = nowMs;
    }

    /// <summary>
    /// 双层自动恢复：
    /// 第 1 层：心跳过期（Tick 停止）→ 1.5 秒超时
    /// 第 2 层：菜单打开时间过长（Tick 运行但 Close() 从未调用）→ 最大生命周期
    /// </summary>
    public static void AutoRecover(
        int nowMs, 
        int heartbeatTimeoutMs = 1500,
        int maxLifetimeMs = 15000)   // 没有菜单应该打开超过 15 秒
    {
        try
        {
            // --- 逮捕菜单 ---
            if (IsArrestMenuOpen)
            {
                bool heartbeatStale = _arrestMenuHeartbeatAtMs > 0 
                    && nowMs - _arrestMenuHeartbeatAtMs > heartbeatTimeoutMs;
                    
                bool tooOld = _arrestMenuOpenedAtMs > 0 
                    && nowMs - _arrestMenuOpenedAtMs > maxLifetimeMs;

                if (heartbeatStale || tooOld)
                {
                    ModLog.Warn($"[UIState] ArrestMenu 自动重置 "
                        + $"(stale={heartbeatStale}, tooOld={tooOld})");
                    MarkArrestMenuClosed();
                }
            }

            // --- 警察终端 ---
            // 终端可能需要合法打开更长时间，使用 30 秒
            if (IsPoliceTerminalOpen)
            {
                bool heartbeatStale = _policeTerminalHeartbeatAtMs > 0 
                    && nowMs - _policeTerminalHeartbeatAtMs > heartbeatTimeoutMs;
                    
                bool tooOld = _policeTerminalOpenedAtMs > 0 
                    && nowMs - _policeTerminalOpenedAtMs > 30000;

                if (heartbeatStale || tooOld)
                {
                    ModLog.Warn($"[UIState] PoliceTerminal 自动重置 "
                        + $"(stale={heartbeatStale}, tooOld={tooOld})");
                    MarkPoliceTerminalClosed();
                }
            }

            // --- 调度菜单 ---
            if (IsDispatchMenuOpen)
            {
                bool heartbeatStale = _dispatchMenuHeartbeatAtMs > 0 
                    && nowMs - _dispatchMenuHeartbeatAtMs > heartbeatTimeoutMs;
                    
                bool tooOld = _dispatchMenuOpenedAtMs > 0 
                    && nowMs - _dispatchMenuOpenedAtMs > maxLifetimeMs;

                if (heartbeatStale || tooOld)
                {
                    ModLog.Warn($"[UIState] DispatchMenu 自动重置 "
                        + $"(stale={heartbeatStale}, tooOld={tooOld})");
                    MarkDispatchMenuClosed();
                }
            }

            // --- 制服菜单 ---
            if (IsUniformMenuOpen)
            {
                bool heartbeatStale = _uniformMenuHeartbeatAtMs > 0 
                    && nowMs - _uniformMenuHeartbeatAtMs > heartbeatTimeoutMs;
                    
                bool tooOld = _uniformMenuOpenedAtMs > 0 
                    && nowMs - _uniformMenuOpenedAtMs > maxLifetimeMs;

                if (heartbeatStale || tooOld)
                {
                    ModLog.Warn($"[UIState] UniformMenu 自动重置 "
                        + $"(stale={heartbeatStale}, tooOld={tooOld})");
                    MarkUniformMenuClosed();
                }
            }

            // --- 警官小队菜单 ---
            if (IsOfficerSquadMenuOpen)
            {
                bool heartbeatStale = _officerSquadMenuHeartbeatAtMs > 0 
                    && nowMs - _officerSquadMenuHeartbeatAtMs > heartbeatTimeoutMs;
                    
                bool tooOld = _officerSquadMenuOpenedAtMs > 0 
                    && nowMs - _officerSquadMenuOpenedAtMs > maxLifetimeMs;

                if (heartbeatStale || tooOld)
                {
                    ModLog.Warn($"[UIState] OfficerSquadMenu 自动重置 "
                        + $"(stale={heartbeatStale}, tooOld={tooOld})");
                    MarkOfficerSquadMenuClosed();
                }
            }
        }
        catch { }
    }
}
```

**现在 AutoRecover 有两层：**

```
第 1 层（现有）：心跳过期
  → Tick 停止运行
  → 1.5 秒后重置
  
第 2 层（新增）：最大生命周期
  → Tick 正在运行，Beat 是新鲜的
  → 但菜单已打开超过 15 秒
  → 出问题了 → 强制重置
  → 这能捕获"卡住打开"的幽灵

没有任何合法的菜单交互需要 15 秒。
如果需要，强制关闭并让玩家重新打开。
```

---

## Bug #2：ArrestMenuController.ExecuteSelected() 有重复代码

```csharp
private void ExecuteSelected()
{
    // ...设置样式...

    // 块 A：发布 SuspectArrestStyleSelectedEvent
    try { ... EventBus.Publish(new SuspectArrestStyleSelectedEvent(...)); } catch { }

    // 块 B：完全相同的代码（复制粘贴事故）
    try { ... EventBus.Publish(new SuspectArrestStyleSelectedEvent(...)); } catch { }

    EventBus.Publish(new AttemptArrestEvent());
}
```

**在 EFCore 构造函数中，订阅也被重复了：**

```csharp
// 第一次订阅
EventBus.Subscribe<SuspectArrestStyleSelectedEvent>(e => { ... });

// 第二次订阅（相同）
EventBus.Subscribe<SuspectArrestStyleSelectedEvent>(e => { ... });
```

**结果：**
```
2 次发布 × 2 个订阅者 = 4 次 SetStyle() 调用

不是崩溃 bug，但浪费 CPU 并表明
复制粘贴的技术债可能在以后导致真正的问题。
```

### 修复方案

**在 ArrestMenuController.ExecuteSelected() 中，删除重复块：**

```csharp
private void ExecuteSelected()
{
    if (_selected == 0)
        ArrestStyleState.SelectedStyle = ArrestActionStyle.CuffAndLead;
    else
        ArrestStyleState.SelectedStyle = ArrestActionStyle.HandsOnHeadFollow;

    // 步骤 1：将样式绑定到当前锁定的嫌疑人（仅一次）
    try
    {
        var core = EFCore.Instance;
        var lts = core != null ? core.LockTargetSystem : null;
        var target = lts != null ? lts.CurrentTarget : null;
        if (target != null && target.Exists())
        {
            EventBus.Publish(new SuspectArrestStyleSelectedEvent(
                target.Handle, ArrestStyleState.SelectedStyle));
        }
    }
    catch { }

    // 删除这里重复的块

    EventBus.Publish(new AttemptArrestEvent());
}
```

**在 EFCore 构造函数中，删除重复订阅：**

```csharp
// 保留一个订阅
EventBus.Subscribe<SuspectArrestStyleSelectedEvent>(e =>
{
    try { _suspectStyleRegistry?.SetStyle(e.SuspectHandle, e.Style); } catch { }
});

// 删除这里重复的订阅
```

---

## Bug #3：ExecuteSelected() 可能跳过 Close()

```csharp
// 在 ArrestMenuController.Tick() 中：
if (confirm)
{
    if (!_confirmHeld)
    {
        ExecuteSelected();   // ← 如果这个抛出异常...
        Close();             // ← ...这个永远不会运行
    }
    _confirmHeld = true;
}
```

**场景：**
```
1. 玩家按下 NumPad5
2. ExecuteSelected() 抛出意外异常
3. 异常传播出 Tick()
4. EFCore 捕获它：ModLog.Error("ArrestMenu.Tick exception")
5. Close() 从未被调用
6. _open 保持为 true
7. 下一帧：Tick() 运行 → Beat() 刷新生效心跳
8. AutoRecover："心跳是新鲜的" → 什么都不做
9. 菜单永远卡住打开
10. 所有按键被阻塞
11. 👻 幽灵
```

### 修复方案：保护 Close()

```csharp
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
            Close();   // 总是关闭，即使 ExecuteSelected 抛出异常
        }
    }
    _confirmHeld = true;
}
```

---

## Bug #4：InputManager return 语句杀死其他按键

**已经讨论过。三个地方：**

```
G 处理程序：return → 杀死 Z、E、L、I、U
F8 处理程序：return → 杀死 I、U、Z、E
I 处理程序：return → 杀死 U、Z、E
```

**修复：将所有 return 替换为 if/else 流程**

**之前消息中已提供详细修复。每个的模式：**

```csharp
// ❌ return 杀死下方所有内容
if (!ok)
{
    Notification.Show("...");
    return;
}
EventBus.Publish(...);

// ✅ if/else 仅跳过此按键的动作
if (ok)
{
    EventBus.Publish(...);
}
else
{
    Notification.Show("...");
}
// 处理继续到下一个按键
```

---

## 完整 Bug 总结

```
┌─────────────────────────────────────────────────┐
│              发现的所有 BUG                      │
├─────────────────────────────────────────────────┤
│                                                 │
│  #1 AutoRecover 设计缺陷         🔴 幽灵根源    │
│     Beat() 阻止恢复                             │
│     修复：添加 maxLifetime 层                    │
│                                                 │
│  #2 异常时跳过 Close()          🔴 幽灵根源     │
│     ExecuteSelected 抛出 → Close 从不运行        │
│     修复：在 ExecuteSelected 周围使用 try/finally│
│                                                 │
│  #3 return 语句                  🟡 加剧问题    │
│     单帧按键丢失                                │
│     修复：用 if/else 替换 return                 │
│                                                 │
│  #4 重复代码                     🟡 技术债      │
│     2x 发布 + 2x 订阅 = 4x 调用                   │
│     修复：删除重复                              │
│                                                 │
│  #5 Script.Wait 阻塞             🟡 冻结        │
│     DeliverSystem 阻塞 5 秒                      │
│     修复：基于状态（之前已提供）                 │
│                                                 │
│  #6 ModLog 0KB                   🔵 独立问题    │
│     静默文件锁定失败                            │
│     修复：初始化检查 + 回退通知                  │
│                                                 │
└─────────────────────────────────────────────────┘
```

**幽灵是 #1 和 #2 的组合：**

```
ExecuteSelected 中的异常
  → Close() 被跳过
  → 菜单卡住打开
  → Beat() 保持心跳新鲜
  → AutoRecover 认为"菜单正常"
  → 按键永远被阻塞
  → 重新加载修复它（重置静态状态）
  
  同时修复两者，幽灵就死了。👻💀
```

---

## 优先修复顺序

```
1. 修复 #2 (try/finally)     → 30 秒，防止根本原因
2. 修复 #1 (maxLifetime)     → 5 分钟，捕获任何卡住的菜单
3. 修复 #4 (删除重复)        → 30 秒，清理
4. 修复 #3 (移除 return)     → 5 分钟，防止按键丢失
5. 修复 #5 (基于状态)        → 15 分钟，防止冻结
6. 修复 #6 (日志初始化)      → 2 分钟，诊断

先修复 #2。只需 30 秒的工作就能杀死幽灵。🔪👻
```