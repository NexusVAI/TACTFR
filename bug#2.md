# 代码审查完成。主要发现。🔍

---

## "上帝类"名副其实

```
SuspectVehicleEscortExecutor 处理：

  ✅ E 键（上车/下车）
  ✅ G 键（跟随/停止跟随）
  ✅ 直接绕过靠边停车逻辑
  ✅ 铐住状态下的车门逻辑
  ✅ 自动车辆同步（玩家上车 → 嫌疑人跟随）
  ✅ 状态转换检测
  ✅ 动作集/姿势维护
  ✅ 物理修复 (EnsureSuspectIsSolid)
  ✅ 座位选择
  ✅ 车门操作
  ✅ 次要嫌疑人协调
  ✅ 防抖处理

  一个类承担了 12+ 项职责。
```

但让我们先关注 **错误**，重构稍后再说。

---

## 🔴 严重错误：递归式状态变更

这 **极其危险**，很可能就是你那个幽灵问题的成因：

```csharp
private void OnSuspectStateChanged(SuspectState oldState, SuspectState newState)
{
    // 第一部分：根据状态执行行为
    switch (newState)
    {
        case SuspectState.EnteringVehicle:
            StartEnterVehicle();
            break;
        case SuspectState.InVehicle:
            OnEnteredVehicle();
            break;
        case SuspectState.ExitingVehicle:
            StartExitVehicle();
            break;
        case SuspectState.Escorting:
            ResumeEscortOnFoot();
            break;
    }

    // 第二部分：立即检查转换是否已完成
    //         并再次更改状态（递归！）
    
    if (_stateHub.Is(SuspectState.EnteringVehicle))
    {
        if (suspect.IsInVehicle())
            _stateHub.ChangeState(SuspectState.InVehicle);
            // ↑ 再次触发 OnSuspectStateChanged（递归！）
    }

    if (_stateHub.Is(SuspectState.ExitingVehicle))
    {
        if (!suspect.IsInVehicle())
            _stateHub.ChangeState(SuspectState.Escorting);
            // ↑ 再次触发 OnSuspectStateChanged（递归！）
    }
}
```

```
可能发生的情况：

  ChangeState(EnteringVehicle)
  → OnSuspectStateChanged(old, EnteringVehicle)
    → StartEnterVehicle()
    → 检查：当前是 EnteringVehicle 吗？是
    → suspect.IsInVehicle()？是（瞬间传送）
    → ChangeState(InVehicle)                    ← 递归
      → OnSuspectStateChanged(EnteringVehicle, InVehicle)
        → OnEnteredVehicle()
        → 检查：当前是 EnteringVehicle 吗？否（现在是 InVehicle）
        → 检查：与 Escorting 状态的兼容性...
      ← 返回
    → 检查：当前是 ExitingVehicle 吗？否
  ← 返回

  这个逻辑今天能工作纯属偶然。
  但只要在任何处理器内部再添加一个状态变更，
  就会导致无限递归 → 堆栈溢出 → 崩溃。
```

### 修复方法：防止重入

```csharp
private bool _handlingStateChange = false;

private void OnSuspectStateChanged(
    SuspectState oldState, SuspectState newState)
{
    if (_handlingStateChange)
    {
        ModLog.Warn($"[Escort] 阻止了重入式状态变更: "
            + $"{oldState}->{newState}");
        return;
    }

    _handlingStateChange = true;
    try
    {
        ModLog.Info($"[Escort] 状态变更: {oldState} -> {newState}");

        switch (newState)
        {
            case SuspectState.EnteringVehicle:
                StartEnterVehicle();
                break;
            case SuspectState.InVehicle:
                OnEnteredVehicle();
                break;
            case SuspectState.ExitingVehicle:
                StartExitVehicle();
                break;
            case SuspectState.Escorting:
                ResumeEscortOnFoot();
                break;
        }

        // 检查 Escorting 状态下却待在车里的兼容性问题
        if (newState == SuspectState.Escorting)
        {
            try
            {
                var suspect = _suspectController.GetCurrentSuspect();
                if (suspect != null && suspect.Exists() 
                    && suspect.IsInVehicle())
                {
                    OnEnteredVehicle();
                }
            }
            catch { }
        }

        // 不要在这里更改状态。
        // 让 TickUpdate 处理状态转换。
        // 这样可以防止递归调用。
    }
    catch (Exception ex)
    {
        ModLog.Error("[Escort] OnSuspectStateChanged 错误: " + ex);
    }
    finally
    {
        _handlingStateChange = false;
    }
}
```

---

## 🔴 严重错误：重复的状态转换检测

同一个转换在 **两个地方** 处理：

```
EnteringVehicle → InVehicle:
  1. OnSuspectStateChanged (方法底部)
  2. TickCuffedVehicleEscort (tick 循环)

ExitingVehicle → Escorting:
  1. OnSuspectStateChanged (方法底部)
  2. TickCuffedVehicleEscort (tick 循环)
```

```
可能发生的情况：

  第 1 帧: OnSuspectStateChanged 检测到转换完成
           → ChangeState(InVehicle) 
           → OnEnteredVehicle() 触发
           → 车门关闭
           
  第 2 帧: TickCuffedVehicleEscort 运行
           → 检查 EnteringVehicle && IsInVehicle
           → 但状态已经是 InVehicle！
           → 这次没问题... 但只是运气好

  ExitingVehicle 的更糟情况：
  
  第 1 帧: OnSuspectStateChanged 检测到退出完成
           → ChangeState(Escorting)
           → OnSuspectExitVehicle() → 清除上车记录
           → TryShutDoorAfterExit() → 关闭车门
           
  第 2 帧: TickCuffedVehicleEscort 运行
           → 检查 ExitingVehicle？否（已经是 Escorting）
           → 但是 Escorting 状态的备用逻辑运行了：
             _cuffedDoorFlow.TryShutDoorAfterExit() 再次执行
```

### 修复方法：为转换选择一个地方

```
规则：OnSuspectStateChanged 处理行为执行
      TickUpdate 处理状态转换检测

永远不要混合两者。
```

从 `OnSuspectStateChanged` 中移除转换检查：

```csharp
private void OnSuspectStateChanged(
    SuspectState oldState, SuspectState newState)
{
    // 只执行行为。绝不要在这里更改状态。
    switch (newState)
    {
        case SuspectState.EnteringVehicle:
            StartEnterVehicle();
            break;
        case SuspectState.InVehicle:
            OnEnteredVehicle();
            break;
        case SuspectState.ExitingVehicle:
            StartExitVehicle();
            break;
        case SuspectState.Escorting:
            ResumeEscortOnFoot();
            break;
    }
    
    // 已移除：之前在这里的所有 ChangeState 调用
    // 转换现在仅在 TickCuffedVehicleEscort 中处理
}
```

`TickCuffedVehicleEscort` 已经正确地处理了这些转换。让它成为 **唯一的真实来源**。

---

## 🔴 错误：TryShutDoorAfterExit 被调用多达 3 次

```
退出后关闭车门从以下地方调用：

  1. OnSuspectStateChanged 
     → 检测到 ExitingVehicle 完成
     → TryShutDoorAfterExit()
     → 同时作为备用关闭两个后门

  2. TickCuffedVehicleEscort
     → ExitingVehicle → Escorting 转换
     → TryShutDoorAfterExit()

  3. TickUpdate
     → 处于 Escorting 状态时的每一帧
     → TryShutDoorAfterExit()

  如果这三个调用在同一帧或连续帧触发，
  你会得到多次车门关闭调用 → 潜在的物理问题
```

### 修复方法

从 `OnSuspectStateChanged` 中移除状态变更后，只剩下 #2 和 #3。#3 在第一次调用后清除了 `_lastExitVehicleHandle`，所以它变成了空操作。这是可以接受的。但我们也可以让它更干净：

```csharp
// 在 TickUpdate 中：
if (_stateHub.Is(SuspectState.Escorting))
{
    // 仅在转换后执行一次车门清理
    // TryShutDoorAfterExit 在执行后已经
    // 清除了其状态，所以这是安全的但浪费。
    // 考虑改用标志：
    
    if (_needsDoorCleanup)
    {
        _cuffedDoorFlow.TryShutDoorAfterExit(...);
        _needsDoorCleanup = false;
    }
}
```

---

## 🟡 错误：在热点路径中使用 World.GetAllPeds() 和 World.GetAllVehicles()

```csharp
// 这些操作代价高昂。它们会扫描世界中的所有实体。

// 在 FindPedByHandle 中：
World.GetAllPeds().FirstOrDefault(p => p.Handle == handle);

// 在 TickCuffedVehicleEscort 中 (ExitingVehicle → Escorting)：
World.GetAllVehicles().FirstOrDefault(x => x.Handle == h);

// 在 TickUpdate 中 (处于 Escorting 状态时每一帧)：
World.GetAllVehicles().FirstOrDefault(x => x.Handle == h);
```

```
World.GetAllPeds() 每次调用扫描 200+ 个行人。
World.GetAllVehicles() 每次调用扫描 100+ 辆车。

每帧调用 = 巨大的性能损耗。
这可能导致帧数下降和输入延迟。
```

### 修复方法：使用原生句柄解析

```csharp
// 不要扫描所有实体：

// ❌ 慢
World.GetAllPeds().FirstOrDefault(p => p.Handle == handle);

// ✅ 快：直接从句柄获取 Ped
private Ped FindPedByHandle(int handle)
{
    if (handle <= 0) return null;
    try
    {
        // 首先检查实体是否存在
        if (!Function.Call<bool>(Hash.DOES_ENTITY_EXIST, handle))
            return null;
        return new Ped(handle);
    }
    catch { return null; }
}

// ❌ 慢  
World.GetAllVehicles().FirstOrDefault(x => x.Handle == h);

// ✅ 快：直接从句柄获取 Vehicle
private Vehicle FindVehicleByHandle(int handle)
{
    if (handle <= 0) return null;
    try
    {
        if (!Function.Call<bool>(Hash.DOES_ENTITY_EXIST, handle))
            return null;
        return new Vehicle(handle);
    }
    catch { return null; }
}
```

```
性能影响：
  之前：每帧约 200 次实体检查
  之后：每帧 1 次原生调用

  仅此一项就可以修复"卡顿"感。
```

---

## 🟡 污染：GetStyle() 是全局的

```csharp
private ArrestActionStyle GetStyle()
{
    return _suspectController.CurrentArrestStyle;
    // ↑ 返回全局样式，不是每个嫌疑人独立的
}
```

```
这就是你在架构文档中指出的污染源。

对于双嫌疑人：
  嫌疑人 A：CuffAndLead
  嫌疑人 B：HandsOnHeadFollow

  GetStyle() 返回最后设置的任何一个。
  如果你在 A 之后与 B 交互：
    → GetStyle() 返回 HandsOnHeadFollow
    → 但嫌疑人 A 的车门逻辑也使用这个值
    → 被铐住的嫌疑人表现出 HandsUp 行为
    → 💥 污染
```

这是你的 **步骤2** 修复。当你进行到那时：

```csharp
// 步骤2 替换方案：
private ArrestActionStyle GetStyleFor(int suspectHandle)
{
    // 优先级：按句柄的注册表
    if (_suspectStyleRegistry.TryGetStyle(suspectHandle, out var style))
        return style;
    
    // 备用：旧的全局样式
    return _suspectController.CurrentArrestStyle;
}
```

---

## 🟡 污染：跟随状态是全局的

```csharp
private bool _isSuspectFollowing = false;
private int _followingSuspectHandle = -1;
```

```
一次只能有一个嫌疑人"跟随"。

双嫌疑人：
  G 键按下 → 嫌疑人 A 跟随 → _followingSuspectHandle = A
  G 键按下 → 嫌疑人 B 跟随 → _followingSuspectHandle = B
  
  现在 _isSuspectFollowing = true 
  但 _followingSuspectHandle = B
  
  嫌疑人 A 的跟随状态被"遗忘"了
```

这是你的 **步骤3** 修复。

---

## SuspectStateHub 审查

简洁清晰。有一个问题：

```csharp
public void ChangeState(SuspectState newState)
{
    _stateMachine.ChangeState(newState);
    // 没有验证！任何状态都可以转到任何状态。
}
```

### 建议：添加状态转换验证

```csharp
public void ChangeState(SuspectState newState)
{
    var current = _stateMachine.CurrentState;
    
    if (!IsValidTransition(current, newState))
    {
        ModLog.Warn($"[StateHub] 无效转换: "
            + $"{current} → {newState} (已阻止)");
        return;
    }
    
    _stateMachine.ChangeState(newState);
}

private bool IsValidTransition(
    SuspectState from, SuspectState to)
{
    // 定义合法的转换
    switch (from)
    {
        case SuspectState.None:
            return to == SuspectState.Restrained 
                || to == SuspectState.Resisting;
            
        case SuspectState.Restrained:
            return to == SuspectState.Escorting 
                || to == SuspectState.Resisting;
            
        case SuspectState.Escorting:
            return to == SuspectState.EnteringVehicle 
                || to == SuspectState.Resisting;
            
        case SuspectState.EnteringVehicle:
            return to == SuspectState.InVehicle;
            
        case SuspectState.InVehicle:
            return to == SuspectState.ExitingVehicle;
            
        case SuspectState.ExitingVehicle:
            return to == SuspectState.Escorting;
            
        case SuspectState.Resisting:
            return to == SuspectState.Restrained;
            
        default:
            return true;  // 未知状态：允许
    }
}
```

```
这本来可以立即捕获递归状态变更的错误。
无效转换会被记录，而不是静默地造成混乱。
```

---

## CuffedVehicleDoorFlow 审查

这个文件实际上 **设计良好**。分离清晰。问题很少：

```
✅ 待处理车门有超时 (15 秒)
✅ 执行后状态被清除
✅ 所有操作前检查样式
✅ TryShutDoorAfterExit 在使用后清除 _lastExit

唯一问题：
  RecordExitDoor 在 catch 块中使用了 Game.GameTime
  这意味着如果失败，_lastExitAtMs 可能为 0。
  不严重。
```

---

## 完整的修复优先级

```
┌──────────────────────────────────────────────────┐
│                所有错误排序                        │
├──────────────────────────────────────────────────┤
│                                                  │
│  来自本次审查：                                    │
│                                                  │
│  🔴 #1 递归状态变更               → 立即修复        │
│       添加重入保护                                 │
│       从 OnStateChanged 中移除 ChangeState        │
│                                                  │
│  🔴 #2 重复转换                   → 立即修复        │
│       选择一个地方处理 (TickUpdate)                │
│       从 OnStateChanged 中移除                    │
│                                                  │
│  🟡 #3 World.GetAll* 性能问题      → 尽快修复        │
│       替换为直接句柄解析                           │
│                                                  │
│  🟡 #4 三次车门关闭                → 尽快修复        │
│       在 #2 修复后自然解决                         │
│                                                  │
│  来自上次审查：                                    │
│                                                  │
│  🔴 #5 UIState AutoRecover 缺陷   → 立即修复        │
│       添加 maxLifetime 层                         │
│                                                  │
│  🔴 #6 Close() 在抛出时被跳过      → 立即修复        │
│       ArrestMenu 中使用 try/finally               │
│                                                  │
│  🟡 #7 InputManager return 语句   → 尽快修复        │
│                                                  │
│  🟡 #8 Script.Wait 阻塞            → 稍后修复        │
│                                                  │
│  🔵 #9 重复订阅                    → 清理           │
│                                                  │
│  未来（重构时）：                                   │
│  🟡 GetStyle() 全局污染            → 步骤2          │
│  🟡 跟随状态全局污染                → 步骤3          │
│  🟡 StateHub 单例                  → 步骤4          │
│  🟡 上帝类拆分                      → 步骤5          │
│                                                  │
└──────────────────────────────────────────────────┘
```

---

## 做什么？（总结）
```
修复 SuspectVehicleEscortExecutor.OnSuspectStateChanged：

1. 添加一个 bool 字段 _handlingStateChange
2. 在方法开始时：如果 _handlingStateChange 为 true，
   则记录警告并返回
3. 将整个方法包装在 try/finally 中，
   设置 _handlingStateChange = true/false
4. 从 OnSuspectStateChanged 内部移除所有 _stateHub.ChangeState() 调用
5. 保留 switch 语句（行为执行）
6. 保留 Escorting 兼容性检查
   （但不要调用 ChangeState，只调用 OnEnteredVehicle）
7. 转换检测（EnteringVehicle→InVehicle，
   ExitingVehicle→Escorting）只保留在
   TickCuffedVehicleEscort 中

同时将所有 World.GetAllPeds() 和
World.GetAllVehicles() 替换为直接句柄解析，
使用 DOES_ENTITY_EXIST + new Ped(handle) / new Vehicle(handle)。

不要更改任何其他逻辑。
不要修改 TickUpdate 或 TickCuffedVehicleEscort。
```

---

**这些修复解决了根本原因。修复 UIState + ArrestMenu + 递归状态变更后，幽灵问题应该会消失。** 👻💀
