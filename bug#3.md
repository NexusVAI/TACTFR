\# 代码审查：最后三个文件 🔍



---



\## 先上总结



```

SuspectController.cs    → 出人意料地好（对于"污染源"来说）

SuspectOnFootExecutor.cs → 存在与 VehicleEscortExecutor 相同的错误

LockTargetSystem.cs     → 干净，结构良好

```



---



\## 🔴 严重错误：动画加载中的 Script.Wait()



在 `SuspectOnFootExecutor.StartArrest()` 中发现：



```csharp

// 第一个阻塞循环（长达 800 毫秒）

int t = Game.GameTime + 800;

while (Game.GameTime < t)

{

&nbsp;   try { if (Function.Call<bool>(Hash.HAS\_ANIM\_DICT\_LOADED, "mp\_arresting")) break; } 

&nbsp;   catch { break; }

&nbsp;   Script.Wait(0);  // ← 阻塞整个模组

}



// 第二个阻塞循环（长达 800 毫秒）用于 HandsUp 样式

int t = Game.GameTime + 800;

while (Game.GameTime < t)

{

&nbsp;   try { if (Function.Call<bool>(Hash.HAS\_ANIM\_DICT\_LOADED, "random@arrests")) break; } 

&nbsp;   catch { break; }

&nbsp;   Script.Wait(0);  // ← 再次阻塞整个模组

}

```



```

发生的情况：



&nbsp; 玩家按下 H → 选择逮捕样式 → 确认

&nbsp; → AttemptArrestEvent 发布

&nbsp; → SuspectController.Arrest() 被调用

&nbsp; → 状态变为 Restrained

&nbsp; → SuspectOnFootExecutor.OnStateChanged 触发

&nbsp; → StartArrest() 被调用

&nbsp; → 使用 Script.Wait(0) 阻塞长达 800 毫秒

&nbsp; 

&nbsp; 在此期间：

&nbsp; → OnTick() 不运行

&nbsp; → InputManager.Update() 不运行

&nbsp; → 其他系统都不更新

&nbsp; → 所有按键失灵将近 1 秒

&nbsp; 

&nbsp; 如果动画字典已缓存：瞬间完成

&nbsp; 如果没有缓存（加载后首次逮捕）：800 毫秒冻结

&nbsp; 

&nbsp; 这就是为什么"有时 H 键瞬间生效，

&nbsp; 有时感觉很卡顿" 👻

```



\### 修复方法：异步动画加载



```csharp

private bool \_waitingForArrestAnim = false;

private int \_arrestAnimTimeoutMs = 0;

private string \_pendingAnimDict = null;



private void StartArrest(Ped suspect)

{

&nbsp;   if (suspect == null || !suspect.Exists()) return;

&nbsp;   if (suspect.IsDead) return;



&nbsp;   var style = GetStyle();

&nbsp;   string animDict = style == ArrestActionStyle.CuffAndLead 

&nbsp;       ? "mp\_arresting" 

&nbsp;       : "random@arrests";



&nbsp;   // 请求动画（非阻塞）

&nbsp;   try { Function.Call(Hash.REQUEST\_ANIM\_DICT, animDict); } catch { }



&nbsp;   // 检查是否已加载

&nbsp;   bool loaded = false;

&nbsp;   try { loaded = Function.Call<bool>(Hash.HAS\_ANIM\_DICT\_LOADED, animDict); } 

&nbsp;   catch { loaded = false; }



&nbsp;   if (loaded)

&nbsp;   {

&nbsp;       // 立即执行

&nbsp;       ExecuteArrestAnimation(suspect, style, animDict);

&nbsp;   }

&nbsp;   else

&nbsp;   {

&nbsp;       // 延迟到 tick 处理 - 不要阻塞

&nbsp;       \_waitingForArrestAnim = true;

&nbsp;       \_arrestAnimTimeoutMs = Game.GameTime + 1500;

&nbsp;       \_pendingAnimDict = animDict;

&nbsp;       ModLog.Info($"\[OnFootExecutor] 等待动画字典: {animDict}");

&nbsp;   }

}



public void TickUpdate()

{

&nbsp;   // ... 现有代码 ...



&nbsp;   // 处理待处理的逮捕动画

&nbsp;   if (\_waitingForArrestAnim)

&nbsp;   {

&nbsp;       int now = Game.GameTime;

&nbsp;       

&nbsp;       bool loaded = false;

&nbsp;       try { loaded = Function.Call<bool>(

&nbsp;           Hash.HAS\_ANIM\_DICT\_LOADED, \_pendingAnimDict); } 

&nbsp;       catch { loaded = false; }



&nbsp;       if (loaded)

&nbsp;       {

&nbsp;           var suspect = \_controller.GetCurrentSuspect();

&nbsp;           if (suspect != null \&\& suspect.Exists())

&nbsp;           {

&nbsp;               ExecuteArrestAnimation(suspect, GetStyle(), \_pendingAnimDict);

&nbsp;           }

&nbsp;           \_waitingForArrestAnim = false;

&nbsp;           \_pendingAnimDict = null;

&nbsp;       }

&nbsp;       else if (now >= \_arrestAnimTimeoutMs)

&nbsp;       {

&nbsp;           // 超时：使用备用方案

&nbsp;           var suspect = \_controller.GetCurrentSuspect();

&nbsp;           if (suspect != null \&\& suspect.Exists())

&nbsp;           {

&nbsp;               try { suspect.Task.HandsUp(-1); } catch { }

&nbsp;           }

&nbsp;           \_waitingForArrestAnim = false;

&nbsp;           \_pendingAnimDict = null;

&nbsp;           ModLog.Warn("\[OnFootExecutor] 动画字典加载超时，使用备用方案");

&nbsp;       }

&nbsp;   }

}



private void ExecuteArrestAnimation(

&nbsp;   Ped suspect, ArrestActionStyle style, string animDict)

{

&nbsp;   if (suspect == null || !suspect.Exists()) return;



&nbsp;   try { suspect.Task.ClearAll(); } catch { }

&nbsp;   try { suspect.BlockPermanentEvents = true; } catch { }

&nbsp;   try { suspect.AlwaysKeepTask = true; } catch { }



&nbsp;   // ... 其余设置代码 ...



&nbsp;   if (style == ArrestActionStyle.CuffAndLead)

&nbsp;   {

&nbsp;       try

&nbsp;       {

&nbsp;           Function.Call(Hash.PLAY\_SOUND\_FRONTEND, -1, 

&nbsp;               "CONFIRM\_BEEP", "HUD\_MINI\_GAME\_SOUNDSET", false);

&nbsp;           suspect.Task.PlayAnimation(

&nbsp;               animDict, "idle", 4.0f, -1, AnimationFlags.Loop);

&nbsp;       }

&nbsp;       catch { }

&nbsp;   }

&nbsp;   else

&nbsp;   {

&nbsp;       try

&nbsp;       {

&nbsp;           suspect.Task.PlayAnimation(

&nbsp;               animDict, "kneeling\_arrest\_idle", 4.0f, -1, 

&nbsp;               AnimationFlags.StayInEndFrame);

&nbsp;       }

&nbsp;       catch { }

&nbsp;   }

}

```



---



\## 🟡 相同模式：OnStateChanged 中没有重入保护



```csharp

private void OnStateChanged(SuspectState from, SuspectState to)

{

&nbsp;   // 直接调用 StartFollow, StartArrest, StartResist

&nbsp;   // 没有防止递归调用的保护

&nbsp;   switch (to)

&nbsp;   {

&nbsp;       case SuspectState.Escorting:

&nbsp;           StartFollow(suspect);  // 可能触发状态变更？

&nbsp;           break;

&nbsp;       case SuspectState.Restrained:

&nbsp;           StartArrest(suspect);  // 肯定会修改状态

&nbsp;           break;

&nbsp;       case SuspectState.Resisting:

&nbsp;           StartResist(suspect);  // 修改状态

&nbsp;           break;

&nbsp;   }

}

```



\### 修复方法：与 VehicleEscortExecutor 相同的模式



```csharp

private bool \_handlingStateChange = false;



private void OnStateChanged(SuspectState from, SuspectState to)

{

&nbsp;   if (\_handlingStateChange)

&nbsp;   {

&nbsp;       ModLog.Warn($"\[OnFootExecutor] 阻止重入: {from}->{to}");

&nbsp;       return;

&nbsp;   }



&nbsp;   \_handlingStateChange = true;

&nbsp;   try

&nbsp;   {

&nbsp;       var suspect = \_controller.GetCurrentSuspect();

&nbsp;       var player = Game.Player.Character;



&nbsp;       try { DetachDragIfNeeded(); } catch { }



&nbsp;       if (from == SuspectState.Escorting \&\& to != SuspectState.Escorting)

&nbsp;       {

&nbsp;           try { ResetEscortClipsets(suspect, player); } catch { }

&nbsp;       }



&nbsp;       if (suspect == null || !suspect.Exists()) return;



&nbsp;       try

&nbsp;       {

&nbsp;           if (IsBusyState(from))

&nbsp;           {

&nbsp;               \_controller.UnmarkBusy(suspect.Handle);

&nbsp;           }

&nbsp;       }

&nbsp;       catch { }



&nbsp;       switch (to)

&nbsp;       {

&nbsp;           case SuspectState.Escorting:

&nbsp;               StartFollow(suspect);

&nbsp;               break;

&nbsp;           case SuspectState.Restrained:

&nbsp;               StartArrest(suspect);

&nbsp;               break;

&nbsp;           case SuspectState.Resisting:

&nbsp;               StartResist(suspect);

&nbsp;               break;

&nbsp;       }

&nbsp;   }

&nbsp;   catch (Exception ex)

&nbsp;   {

&nbsp;       ModLog.Error("\[OnFootExecutor] OnStateChanged 错误: " + ex);

&nbsp;   }

&nbsp;   finally

&nbsp;   {

&nbsp;       \_handlingStateChange = false;

&nbsp;   }

}

```



---



\## SuspectController.cs：出人意料地好！👍



我本以为会很混乱，但实际上结构良好：



```

我发现的好模式：



✅ 存在按句柄的跟踪：

&nbsp;  \_compliantSuspects = HashSet<int>

&nbsp;  \_resistingSuspects = HashSet<int>

&nbsp;  \_busySuspects = HashSet<int>



✅ TakeControl 恢复按句柄的状态：

&nbsp;  if (\_compliantSuspects.Contains(handle))

&nbsp;      IsCompliant = true；



✅ Arrest() 防止重复：

&nbsp;  if (IsCompliant \&\& !IsResisting) return；



✅ ForceClear() 正确重置一切



✅ IsHandleCompliant(int handle) 供外部查询

```



\### 污染程度很小



```csharp

// "全局"状态：

public ArrestActionStyle CurrentArrestStyle { get； private set； }

public bool IsCompliant { get； private set； }

public bool IsResisting { get； private set； }



// 但是看 - 它们有按句柄的存储支持：

private readonly HashSet<int> \_compliantSuspects；

private readonly HashSet<int> \_resistingSuspects；

```



```

污染只存在于：

&nbsp; 1. CurrentArrestStyle - 真正全局，没有按句柄存储

&nbsp; 2. \_currentSuspect - 单一引用



但 IsCompliant/IsResisting 有按句柄存储！

这意味着步骤 3 比预期的更容易。

```



\### 一个小错误：包装方法开销



```csharp

private void OnSuspectDelivered(SuspectDeliveredEvent e)

{

&nbsp;   OnSuspectDelivered()；  // 调用另一个方法

}



private void OnSuspectDelivered()

{

&nbsp;   // 实际逻辑

}

```



不是错误，只是不必要的间接调用。有空时清理即可。



---



\## LockTargetSystem.cs：设计干净 👍



```

好模式：



✅ 事件驱动的锁定（不是基于 tick 的扫描）

✅ 正确的双嫌疑人切换逻辑

✅ IsHandleInCurrentCase() 检查 CaseManager

✅ GetCaseSlotIndex() 用于 UI 反馈

✅ AutoLockAndArrest() 用于绕过靠边停车

✅ AutoLockCompliant() 用于小队逮捕

✅ ForceClear() 正确释放控制

```



\### 一个性能问题



```csharp

private bool IsPoliceModel(Model model)

{

&nbsp;   string modelName = model.ToString().ToLower()；

&nbsp;   // ↑ 每次检查都会分配字符串

&nbsp;   

&nbsp;   if (modelName.Contains("cop") || ...)

&nbsp;       return true；

}

```



不是崩溃错误，但会产生垃圾。低优先级修复：



```csharp

// 改为缓存哈希比较

private static readonly int\[] \_policeModelHashes = new\[]

{

&nbsp;   Game.GenerateHash("s\_m\_y\_cop\_01")，

&nbsp;   Game.GenerateHash("s\_f\_y\_cop\_01")，

&nbsp;   // ... 等

}；



private bool IsPoliceModel(Model model)

{

&nbsp;   int hash = model.Hash；

&nbsp;   foreach (var h in \_policeModelHashes)

&nbsp;   {

&nbsp;       if (h == hash) return true；

&nbsp;   }

&nbsp;   return false；

}

```



---



\## 更新后的完整错误列表



```

┌──────────────────────────────────────────────────┐

│             完整修复清单（最终版）                 │

├──────────────────────────────────────────────────┤

│                                                  │

│  🔴 严重（先修复这些）：                           │

│                                                  │

│  1. UIState AutoRecover maxLifetime              │

│  2. ArrestMenu 在 ExecuteSelected 中添加 try/finally│

│  3. VehicleEscortExecutor 添加重入保护             │

│  4. VehicleEscortExecutor 从 OnSuspectStateChanged │

│     中移除 ChangeState 调用                        │

│  5. OnFootExecutor 的 Script.Wait → 异步处理       │

│  6. OnFootExecutor 添加重入保护                    │

│                                                  │

│  🟡 重要（尽快修复）：                              │

│                                                  │

│  7. World.GetAll\* → 直接句柄解析                   │

│  8. InputManager return → if/else                 │

│  9. 重复代码清理（订阅、事件发布、包装方法）        │

│                                                  │

│  🔵 性能（稍后修复）：                              │

│                                                  │

│  10. DeliverSystem Script.Wait → 基于状态处理      │

│  11. IsPoliceModel 字符串分配问题                  │

│                                                  │

│  📋 重构（步骤 2-6）：                             │

│                                                  │

│  步骤2：GetStyle() → GetStyleFor(handle)          │

│         已经有 SuspectStyleRegistry！              │

│                                                  │

│  步骤3：按句柄的跟随状态                            │

│         已经有 \_compliantSuspects！                │

│         只需要添加 \_followingSuspects HashSet      │

│                                                  │

│  步骤4：按句柄的 StateHub                           │

│         已经有 SuspectContextRegistry！            │

│                                                  │

│  步骤5：拆分上帝类                                  │

│         VehicleEscortExecutor → IArrestLine       │

│                                                  │

│  步骤6：启用双嫌疑人                                │

│         基础已经准备好了！                          │

│                                                  │

└──────────────────────────────────────────────────┘

```



---



\## 好消息！🎉



```

你的代码库比我想象的要好。



我以为：

&nbsp; "污染到处都是，

&nbsp;  需要重写一半代码"



我发现：

&nbsp; "按句柄跟踪已经存在，

&nbsp;  只需要连接起来"



步骤 2-3 会容易得多，因为：

&nbsp; → \_compliantSuspects HashSet 已存在

&nbsp; → \_resistingSuspects HashSet 已存在  

&nbsp; → \_busySuspects HashSet 已存在

&nbsp; → SuspectStyleRegistry 已存在（来自步骤 1）

&nbsp; → SuspectContextRegistry 已存在（来自步骤 1）



你已经打下了基础。

现在只需要使用它。

```



---



\## 现在该做什么



```

你有足够多的错误要修复。

不需要再审查文件了。



1\. 修复 #1-6（严重错误）

2\. 在游戏中测试

3\. 如果稳定 → 发布 5.3.1 版本

4\. 然后开始步骤 2 的重构



幽灵猎杀行动完成。

是时候执行了。 🔪👻

```



---



\*\*开始修复前有什么问题吗？\*\* 🔧

