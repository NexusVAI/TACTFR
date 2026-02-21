# GTA5 Native API 文档生成汇总

> 基于 nativedb.dotindustries.dev 数据生成

---

## 生成文件列表

| `AI.md` | 2,472 行 | 68.01 KB |
| `AUDIO.md` | 7,304 行 | 177.92 KB |
| `CAMERA.md` | 6,167 行 | 148.76 KB |
| `ENTITY.md` | 10,181 行 | 266.39 KB |
| `GRAPHICS.md` | 12,266 行 | 321.57 KB |
| `HUD_UI.md` | 13,745 行 | 329.79 KB |
| `NETWORK.md` | 20,919 行 | 488.38 KB |
| `PED.md` | 17,426 行 | 424.72 KB |
| `PLAYER.md` | 6,652 行 | 155.85 KB |
| `QUICK_REFERENCE.md` | 5,781 行 | 605.88 KB |
| `README.md` | 148 行 | 6.31 KB |
| `STATS.md` | 16,825 行 | 394.24 KB |
| `TASK.md` | 9,970 行 | 287.28 KB |
| `VEHICLE.md` | 21,014 行 | 522.19 KB |
| `WEAPON.md` | 3,639 行 | 93.94 KB |

---

## 统计信息

- **文件总数:** 15
- **总行数:** 154,509
- **总大小:** 4291.24 KB (4.19 MB)

## 类别函数数量统计

| 类别 | 命名空间 | 函数数量 |
|------|---------|----------|
| PED | PED | 615 |
| TASK | TASK, BRAIN | 324 |
| ENTITY | ENTITY, OBJECT, ITEMSET | 364 |
| PLAYER | PLAYER | 250 |
| WEAPON | WEAPON | 123 |
| AI | BRAIN, EVENT, PATHFIND | 84 |
| CAMERA | CAM | 248 |
| HUD_UI | HUD, MOBILE | 544 |
| GRAPHICS | GRAPHICS, CUTSCENE | 457 |
| AUDIO | AUDIO | 281 |
| NETWORK | NETWORK, NETSHOPPING, LOBBY | 927 |
| STATS | STATS, MONEY | 689 |
| VEHICLE | VEHICLE | 779 |

---

## 使用说明

1. **README.md** - 主索引文件，包含所有类别的概览
2. **QUICK_REFERENCE.md** - 快速参考表，适合快速查阅
3. **{CATEGORY}.md** - 各类别详细文档，包含完整函数说明

### 文档格式

每个类别文档包含:
- **快速索引** - 所有函数的表格列表
- **详细说明** - 每个函数的完整信息
  - Hash / JHash 值
  - C# 签名
  - 参数列表 (含类型映射)
  - 返回值
  - 注释说明

---

## 类型映射参考

| Native 类型 | C# 类型 | 说明 |
|------------|---------|------|
| `void` | `void` | 无返回值 |
| `BOOL` | `bool` | 布尔值 |
| `int` | `int` | 整数 |
| `float` | `float` | 浮点数 |
| `const char*` | `string` | 字符串 |
| `Hash` | `uint` | 哈希值 |
| `Ped` | `int` | Ped 句柄 |
| `Vehicle` | `int` | 载具句柄 |
| `Player` | `int` | 玩家索引 |
| `Entity` | `int` | 实体句柄 |
| `Cam` | `int` | 摄像机句柄 |
| `Blip` | `int` | 标记句柄 |
| `Any` | `object` | 任意类型 |
| `Any*` | `ref object` | 引用参数 |
