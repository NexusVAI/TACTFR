# GTA5 Native 函数 C# 调用参考大全

> 数据来源: [alloc8or/gta5-nativedb-data](https://github.com/alloc8or/gta5-nativedb-data)
> 
> 最后更新: 2025年12月 (游戏版本 3717/1013)

## 📊 数据统计

- **Native 函数总数**: 6,673 个
- **命名空间**: 45 个
- **文档版本**: 2025.12

## 📁 文件列表

| 文件名 | 大小 | 说明 |
|--------|------|------|
| `GTA5_Native_CSharp_Reference.md` | ~3.7 MB | 完整参考文档（Markdown格式） |
| `GTA5_Native_CSharp_Reference.txt` | ~1.9 MB | 完整参考文档（TXT格式） |
| `GTA5_Native_Quick_Reference.md` | ~470 KB | 快速查找表（Markdown格式） |
| `GTA5_Native_Hash_Enum.cs` | ~388 KB | C# Hash枚举定义 |
| `GTA5_Native_Wrapper.cs` | ~50 KB | C# 常用函数包装类 |
| `README.md` | - | 本文件 |

## 📖 命名空间列表

| 序号 | 命名空间 | 函数数量 | 说明 |
|------|---------|---------|------|
| 1 | BUILTIN | 26 | 内置函数 |
| 2 | APP | 17 | 应用相关 |
| 3 | AUDIO | 281 | 音频相关 |
| 4 | BRAIN | 11 | AI行为 |
| 5 | CAM | 248 | 摄像机相关 |
| 6 | CLOCK | 16 | 时间相关 |
| 7 | CUTSCENE | 56 | 过场动画 |
| 8 | DATAFILE | 57 | 数据文件 |
| 9 | DECORATOR | 12 | 装饰器 |
| 10 | DLC | 11 | DLC相关 |
| 11 | ENTITY | 189 | 实体相关 |
| 12 | EVENT | 13 | 事件相关 |
| 13 | EXTRAMETADATA | 49 | 元数据 |
| 14 | FIRE | 21 | 火焰相关 |
| 15 | GRAPHICS | 401 | 图形渲染 |
| 16 | HUD | 519 | 界面显示 |
| 17 | INTERIOR | 45 | 室内场景 |
| 18 | ITEMSET | 9 | 物品集 |
| 19 | LOBBY | 8 | 大厅相关 |
| 20 | LOCALIZATION | 3 | 本地化 |
| 21 | MISC | 334 | 杂项功能 |
| 22 | MOBILE | 25 | 手机相关 |
| 23 | MONEY | 356 | 金钱相关 |
| 24 | NETSHOPPING | 41 | 网络购物 |
| 25 | NETWORK | 878 | 网络相关 |
| 26 | OBJECT | 166 | 物体相关 |
| 27 | PAD | 50 | 控制器输入 |
| 28 | PATHFIND | 60 | 路径查找 |
| 29 | PED | 615 | 角色相关 |
| 30 | PHYSICS | 49 | 物理相关 |
| 31 | PLAYER | 250 | 玩家相关 |
| 32 | RECORDING | 17 | 录制相关 |
| 33 | REPLAY | 6 | 回放相关 |
| 34 | SAVEMIGRATION | 7 | 存档迁移 |
| 35 | SCRIPT | 37 | 脚本相关 |
| 36 | SECURITY | 3 | 安全相关 |
| 37 | SHAPETEST | 11 | 形状测试 |
| 38 | SOCIALCLUB | 84 | Social Club |
| 39 | STATS | 333 | 统计相关 |
| 40 | STREAMING | 123 | 流式加载 |
| 41 | TASK | 313 | 任务相关 |
| 42 | VEHICLE | 779 | 载具相关 |
| 43 | WATER | 12 | 水面相关 |
| 44 | WEAPON | 123 | 武器相关 |
| 45 | ZONE | 9 | 区域相关 |

## 🚀 快速开始

### 1. 使用 Hash 枚举

```csharp
using GTA;
using GTA.Native;

// 等待1000毫秒
Function.Call(Hash.WAIT, 1000);

// 获取玩家角色
Ped playerPed = Function.Call<Ped>(Hash.GET_PLAYER_PED, Game.Player);

// 生成载具
Vehicle vehicle = Function.Call<Vehicle>(Hash.CREATE_VEHICLE, 
    (uint)VehicleHash.Adder, 
    position.X, position.Y, position.Z, 
    heading, false, false);
```

### 2. 使用包装类

```csharp
using GTA5Modding;

// 等待
GTA5Native.Wait(1000);

// 获取玩家角色
Ped player = GTA5Native.GetPlayerPed(Game.Player);

// 设置玩家无敌
GTA5Native.SetPlayerInvincible(Game.Player, true);

// 创建载具
Vehicle car = GTA5Native.CreateVehicle((uint)VehicleHash.Adder, position, heading, false, false);

// 显示通知
GTA5Native.Notification("Hello GTA5!");
```

## 📋 类型对照表

| C++ 类型 | C# 类型 | 说明 |
|---------|--------|------|
| `void` | `void` | 无返回值 |
| `int` | `int` | 整数 |
| `float` | `float` | 浮点数 |
| `bool` / `BOOL` | `bool` | 布尔值 |
| `const char*` | `string` | 字符串 |
| `Hash` | `uint` | 哈希值 |
| `Entity` | `int` | 实体句柄 |
| `Ped` | `int` | 角色句柄 |
| `Vehicle` | `int` | 载具句柄 |
| `Object` | `int` | 物体句柄 |
| `Player` | `int` | 玩家句柄 |
| `Cam` | `int` | 摄像机句柄 |
| `Blip` | `int` | 地图标记句柄 |
| `Any` | `object` | 任意类型 |
| `Any*` | `IntPtr` | 指针类型 |
| `Vector3` | `Vector3` | 三维向量 |

## 🔧 常用函数示例

### 玩家相关
```csharp
// 设置玩家无敌
Function.Call(Hash.SET_PLAYER_INVINCIBLE, Game.Player, true);

// 设置玩家生命值
Function.Call(Hash.SET_PLAYER_HEALTH, Game.Player, 100);

// 清除通缉等级
Function.Call(Hash.CLEAR_PLAYER_WANTED_LEVEL, Game.Player);

// 设置玩家模型
Function.Call(Hash.SET_PLAYER_MODEL, Game.Player, (uint)PedHash.Michael);
```

### 载具相关
```csharp
// 创建载具
Vehicle vehicle = Function.Call<Vehicle>(Hash.CREATE_VEHICLE, 
    (uint)VehicleHash.Adder, x, y, z, heading, false, false);

// 设置载具颜色
Function.Call(Hash.SET_VEHICLE_COLOURS, vehicle, 0, 0);

// 设置引擎状态
Function.Call(Hash.SET_VEHICLE_ENGINE_ON, vehicle, true, false, false);

// 修复载具
Function.Call(Hash.SET_VEHICLE_FIXED, vehicle);
```

### 角色相关
```csharp
// 创建角色
Ped ped = Function.Call<Ped>(Hash.CREATE_PED, 
    26, (uint)PedHash.Michael, x, y, z, heading, false, false);

// 设置角色健康值
Function.Call(Hash.SET_ENTITY_HEALTH, ped, 100);

// 设置角色无敌
Function.Call(Hash.SET_ENTITY_INVINCIBLE, ped, true);

// 设置角色坐标
Function.Call(Hash.SET_ENTITY_COORDS, ped, x, y, z, false, false, false, false);

// 获取角色坐标
Vector3 pos = Function.Call<Vector3>(Hash.GET_ENTITY_COORDS, ped, true);
```

### 武器相关
```csharp
// 给角色武器
Function.Call(Hash.GIVE_WEAPON_TO_PED, ped, (uint)WeaponHash.Pistol, 999, false, true);

// 设置当前武器
Function.Call(Hash.SET_CURRENT_PED_WEAPON, ped, (uint)WeaponHash.Pistol, true);

// 设置弹药
Function.Call(Hash.SET_PED_AMMO, ped, (uint)WeaponHash.Pistol, 999);
```

### UI相关
```csharp
// 显示通知
Function.Call(Hash.BEGIN_TEXT_COMMAND_THEFEED_POST, "STRING");
Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, "Hello World!");
Function.Call(Hash.END_TEXT_COMMAND_THEFEED_POST_TICKER, false, true);

// 显示帮助文本
Function.Call(Hash.BEGIN_TEXT_COMMAND_DISPLAY_HELP, "STRING");
Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, "Press ~INPUT_CONTEXT~ to interact");
Function.Call(Hash.END_TEXT_COMMAND_DISPLAY_HELP, 0, false, true, -1);

// 添加地图标记
Blip blip = Function.Call<Blip>(Hash.ADD_BLIP_FOR_COORD, x, y, z);
Function.Call(Hash.SET_BLIP_SPRITE, blip, 1);
Function.Call(Hash.SET_BLIP_COLOUR, blip, 5);
```

### 世界相关
```csharp
// 设置天气
Function.Call(Hash.SET_WEATHER_TYPE_NOW, "CLEAR");

// 设置时间
Function.Call(Hash.NETWORK_OVERRIDE_CLOCK_TIME, 12, 0, 0);

// 添加爆炸
Function.Call(Hash.ADD_EXPLOSION, x, y, z, 4, 1.0f, true, false, 1.0f);
```

## 📚 参考资料

- [GTA5 Native DB](https://alloc8or.re/gta5/nativedb/)
- [ScriptHookVDotNet](https://github.com/crosire/scripthookvdotnet)
- [FiveM Native Reference](https://docs.fivem.net/natives/)

## ⚠️ 免责声明

本文档仅供学习和研究使用，所有数据来源于公开的 GTA5 Native 数据库。
使用本文档进行模组开发时，请遵守相关法律法规和游戏使用条款。

---

**生成时间**: 2026-02-06
**数据版本**: GTA5 3717/1013
