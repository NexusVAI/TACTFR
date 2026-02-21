# AI - Native 函数参考

> 命名空间: BRAIN, EVENT, PATHFIND

---

## 快速索引

| 函数名 | C# 签名 | 返回值 | 说明 |
|--------|---------|--------|------|
| `ADD_NAVMESH_BLOCKING_OBJECT` | `int ADD_NAVMESH_BLOCKING_OBJECT(float p0, float p1, float p2, float p3, float p4, float p5, float p6, bool p7, object p8)` | int | - |
| `ADD_NAVMESH_REQUIRED_REGION` | `void ADD_NAVMESH_REQUIRED_REGION(float x, float y, float radius)` | void | - |
| `ADD_SCRIPT_TO_RANDOM_PED` | `void ADD_SCRIPT_TO_RANDOM_PED(string name, uint model, float p2, float p3)` | void | BRAIN::ADD_SCRIPT_TO_RANDOM_PED("pb_prostitute", ${s_f_y_hooker_01}, 100, 0);<br><br>- Nacorpio<br><br>-----<br><br>Ha... |
| `ADD_SHOCKING_EVENT_AT_POSITION` | `int ADD_SHOCKING_EVENT_AT_POSITION(int eventType, float x, float y, float z, float duration)` | int | eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt |
| `ADD_SHOCKING_EVENT_FOR_ENTITY` | `int ADD_SHOCKING_EVENT_FOR_ENTITY(int eventType, int entity, float duration)` | int | eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt |
| `ADJUST_AMBIENT_PED_SPAWN_DENSITIES_THIS_FRAME` | `void ADJUST_AMBIENT_PED_SPAWN_DENSITIES_THIS_FRAME(object p0, object p1, object p2, object p3, object p4, object p5, object p6)` | void | - |
| `ARE_ALL_NAVMESH_REGIONS_LOADED` | `bool ARE_ALL_NAVMESH_REGIONS_LOADED()` | bool | - |
| `ARE_NODES_LOADED_FOR_AREA` | `bool ARE_NODES_LOADED_FOR_AREA(float x1, float y1, float x2, float y2)` | bool | - |
| `BLOCK_DECISION_MAKER_EVENT` | `void BLOCK_DECISION_MAKER_EVENT(uint name, int eventType)` | void | eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt<br><br>This is limited to 4 blocked events at... |
| `CALCULATE_TRAVEL_DISTANCE_BETWEEN_POINTS` | `float CALCULATE_TRAVEL_DISTANCE_BETWEEN_POINTS(float x1, float y1, float z1, float x2, float y2, float z2)` | float | Calculates the travel distance between a set of points.<br><br>Doesn't seem to correlate with distance on ... |
| `CLEAR_DECISION_MAKER_EVENT_RESPONSE` | `void CLEAR_DECISION_MAKER_EVENT_RESPONSE(uint name, int eventType)` | void | eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt |
| `CLEAR_GPS_DISABLED_ZONE_AT_INDEX` | `void CLEAR_GPS_DISABLED_ZONE_AT_INDEX(int index)` | void | Clears a disabled GPS route area from a certain index previously set using `SET_GPS_DISABLED_ZONE_AT... |
| `DISABLE_NAVMESH_IN_AREA` | `void DISABLE_NAVMESH_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool toggle)` | void | Set toggle true to disable navmesh.<br>Set toggle false to enable navmesh. |
| `DISABLE_SCRIPT_BRAIN_SET` | `void DISABLE_SCRIPT_BRAIN_SET(int brainSet)` | void | - |
| `DOES_NAVMESH_BLOCKING_OBJECT_EXIST` | `bool DOES_NAVMESH_BLOCKING_OBJECT_EXIST(object p0)` | bool | - |
| `ENABLE_SCRIPT_BRAIN_SET` | `void ENABLE_SCRIPT_BRAIN_SET(int brainSet)` | void | - |
| `GENERATE_DIRECTIONS_TO_COORD` | `int GENERATE_DIRECTIONS_TO_COORD(float x, float y, float z, bool p3, ref int direction, ref float p5, ref float distToNxJunction)` | int | p3 is 0 in the only game script occurrence (trevor3) but 1 doesn't seem to make a difference<br><br>distTo... |
| `GET_APPROX_FLOOR_FOR_AREA` | `float GET_APPROX_FLOOR_FOR_AREA(float x1, float y1, float x2, float y2)` | float | Returns CGameWorldHeightMap's minimum Z among all grid nodes that intersect with the specified recta... |
| `GET_APPROX_FLOOR_FOR_POINT` | `float GET_APPROX_FLOOR_FOR_POINT(float x, float y)` | float | Returns CGameWorldHeightMap's minimum Z value at specified point (grid node). |
| `GET_APPROX_HEIGHT_FOR_AREA` | `float GET_APPROX_HEIGHT_FOR_AREA(float x1, float y1, float x2, float y2)` | float | Returns CGameWorldHeightMap's maximum Z among all grid nodes that intersect with the specified recta... |
| `GET_APPROX_HEIGHT_FOR_POINT` | `float GET_APPROX_HEIGHT_FOR_POINT(float x, float y)` | float | Returns CGameWorldHeightMap's maximum Z value at specified point (grid node). |
| `GET_CLOSEST_MAJOR_VEHICLE_NODE` | `bool GET_CLOSEST_MAJOR_VEHICLE_NODE(float x, float y, float z, ref Vector3 outPosition, float unknown1, float unknown2)` | bool | Get the closest vehicle node to a given position. |
| `GET_CLOSEST_ROAD` | `bool GET_CLOSEST_ROAD(float x, float y, float z, float p3, int p4, ref Vector3 p5, ref Vector3 p6, ref object p7, ref object p8, ref float p9, bool p10)` | bool | p1 seems to be always 1.0f in the scripts |
| `GET_CLOSEST_VEHICLE_NODE` | `bool GET_CLOSEST_VEHICLE_NODE(float x, float y, float z, ref Vector3 outPosition, int nodeFlags, float p5, float p6)` | bool | https://gtaforums.com/topic/843561-pathfind-node-types |
| `GET_CLOSEST_VEHICLE_NODE_WITH_HEADING` | `bool GET_CLOSEST_VEHICLE_NODE_WITH_HEADING(float x, float y, float z, ref Vector3 outPosition, ref float outHeading, int nodeType, float p6, float p7)` | bool | p5, p6 and p7 seems to be about the same as p4, p5 and p6 for GET_CLOSEST_VEHICLE_NODE. p6 and/or p7... |
| `GET_GPS_BLIP_ROUTE_FOUND` | `bool GET_GPS_BLIP_ROUTE_FOUND()` | bool | - |
| `GET_GPS_BLIP_ROUTE_LENGTH` | `int GET_GPS_BLIP_ROUTE_LENGTH()` | int | - |
| `GET_NEXT_GPS_DISABLED_ZONE_INDEX` | `int GET_NEXT_GPS_DISABLED_ZONE_INDEX()` | int | Gets the next zone that has been disabled using SET_GPS_DISABLED_ZONE_AT_INDEX. |
| `GET_NTH_CLOSEST_VEHICLE_NODE` | `bool GET_NTH_CLOSEST_VEHICLE_NODE(float x, float y, float z, int nthClosest, ref Vector3 outPosition, int nodeFlags, float unknown1, float unknown2)` | bool | - |
| `GET_NTH_CLOSEST_VEHICLE_NODE_FAVOUR_DIRECTION` | `bool GET_NTH_CLOSEST_VEHICLE_NODE_FAVOUR_DIRECTION(float x, float y, float z, float desiredX, float desiredY, float desiredZ, int nthClosest, ref Vector3 outPosition, ref float outHeading, int nodeFlags, float p10, float p11)` | bool | See gtaforums.com/topic/843561-pathfind-node-types for node type info. 0 = paved road only, 1 = any ... |
| `GET_NTH_CLOSEST_VEHICLE_NODE_ID` | `int GET_NTH_CLOSEST_VEHICLE_NODE_ID(float x, float y, float z, int nth, int nodeFlags, float p5, float p6)` | int | Returns the id. |
| `GET_NTH_CLOSEST_VEHICLE_NODE_ID_WITH_HEADING` | `int GET_NTH_CLOSEST_VEHICLE_NODE_ID_WITH_HEADING(float x, float y, float z, int nthClosest, ref Vector3 outPosition, ref float outHeading, int nodeFlags, float p7, float p8)` | int | - |
| `GET_NTH_CLOSEST_VEHICLE_NODE_WITH_HEADING` | `bool GET_NTH_CLOSEST_VEHICLE_NODE_WITH_HEADING(float x, float y, float z, int nthClosest, ref Vector3 outPosition, ref float outHeading, ref int outNumLanes, int nodeFlags, float unknown3, float unknown4)` | bool | Get the nth closest vehicle node and its heading. |
| `GET_NUM_NAVMESHES_EXISTING_IN_AREA` | `int GET_NUM_NAVMESHES_EXISTING_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2)` | int | - |
| `GET_POSITION_BY_SIDE_OF_ROAD` | `bool GET_POSITION_BY_SIDE_OF_ROAD(float x, float y, float z, int p3, ref Vector3 outPosition)` | bool | - |
| `GET_POS_ALONG_GPS_TYPE_ROUTE` | `bool GET_POS_ALONG_GPS_TYPE_ROUTE(ref Vector3 result, bool p1, float p2, int p3)` | bool | p3 can be 0, 1 or 2. |
| `GET_RANDOM_VEHICLE_NODE` | `bool GET_RANDOM_VEHICLE_NODE(float x, float y, float z, float radius, bool p4, bool p5, bool p6, ref Vector3 outPosition, ref int nodeId)` | bool | - |
| `GET_ROAD_BOUNDARY_USING_HEADING` | `bool GET_ROAD_BOUNDARY_USING_HEADING(float x, float y, float z, float heading, ref Vector3 outPosition)` | bool | - |
| `GET_SAFE_COORD_FOR_PED` | `bool GET_SAFE_COORD_FOR_PED(float x, float y, float z, bool onGround, ref Vector3 outPosition, int flags)` | bool | Flags are:<br>1 = 1 = B02_IsFootpath<br>2 = 4 = !B15_InteractionUnk<br>4 = 0x20 = !B14_IsInterior<br>8 = 0x40 = ... |
| `GET_SPAWN_COORDS_FOR_VEHICLE_NODE` | `void GET_SPAWN_COORDS_FOR_VEHICLE_NODE(int nodeAddress, float towardsCoorsX, float towardsCoorsY, float towardsCoorsZ, ref Vector3 centrePoint, ref float heading)` | void | - |
| `GET_STREET_NAME_AT_COORD` | `void GET_STREET_NAME_AT_COORD(float x, float y, float z, Hash* streetName, Hash* crossingRoad)` | void | Determines the name of the street which is the closest to the given coordinates.<br><br>x,y,z - the coordi... |
| `GET_VEHICLE_NODE_IS_GPS_ALLOWED` | `bool GET_VEHICLE_NODE_IS_GPS_ALLOWED(int nodeID)` | bool | Returns false for nodes that aren't used for GPS routes.<br>Example:<br>Nodes in Fort Zancudo and LSIA are... |
| `GET_VEHICLE_NODE_IS_SWITCHED_OFF` | `bool GET_VEHICLE_NODE_IS_SWITCHED_OFF(int nodeID)` | bool | Returns true when the node is Offroad. Alleys, some dirt roads, and carparks return true.<br>Normal roa... |
| `GET_VEHICLE_NODE_POSITION` | `void GET_VEHICLE_NODE_POSITION(int nodeId, ref Vector3 outPosition)` | void | Calling this with an invalid node id, will crash the game.<br>Note that IS_VEHICLE_NODE_ID_VALID simply... |
| `GET_VEHICLE_NODE_PROPERTIES` | `bool GET_VEHICLE_NODE_PROPERTIES(float x, float y, float z, ref int density, ref int flags)` | bool | Gets the density and flags of the closest node to the specified position.<br>Density is a value between... |
| `IS_NAVMESH_LOADED_IN_AREA` | `bool IS_NAVMESH_LOADED_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2)` | bool | Returns whether navmesh for the region is loaded. The region is a rectangular prism defined by it's ... |
| `IS_NAVMESH_REQUIRED_REGION_IN_USE` | `bool IS_NAVMESH_REQUIRED_REGION_IN_USE()` | bool | - |
| `IS_OBJECT_WITHIN_BRAIN_ACTIVATION_RANGE` | `bool IS_OBJECT_WITHIN_BRAIN_ACTIVATION_RANGE(int object)` | bool | - |
| `IS_POINT_ON_ROAD` | `bool IS_POINT_ON_ROAD(float x, float y, float z, int vehicle)` | bool | Gets a value indicating whether the specified position is on a road.<br>The vehicle parameter is not im... |
| `IS_SHOCKING_EVENT_IN_SPHERE` | `bool IS_SHOCKING_EVENT_IN_SPHERE(int eventType, float x, float y, float z, float radius)` | bool | eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt |
| `IS_VEHICLE_NODE_ID_VALID` | `bool IS_VEHICLE_NODE_ID_VALID(int vehicleNodeId)` | bool | Returns true if the id is non zero. |
| `IS_WORLD_POINT_WITHIN_BRAIN_ACTIVATION_RANGE` | `bool IS_WORLD_POINT_WITHIN_BRAIN_ACTIVATION_RANGE()` | bool | Gets whether the world point the calling script is registered to is within desired range of the play... |
| `LOAD_ALL_PATH_NODES` | `bool LOAD_ALL_PATH_NODES(bool set)` | bool | - |
| `REACTIVATE_ALL_OBJECT_BRAINS_THAT_ARE_WAITING_TILL_OUT_OF_RANGE` | `void REACTIVATE_ALL_OBJECT_BRAINS_THAT_ARE_WAITING_TILL_OUT_OF_RANGE()` | void | - |
| `REACTIVATE_ALL_WORLD_BRAINS_THAT_ARE_WAITING_TILL_OUT_OF_RANGE` | `void REACTIVATE_ALL_WORLD_BRAINS_THAT_ARE_WAITING_TILL_OUT_OF_RANGE()` | void | - |
| `REACTIVATE_NAMED_OBJECT_BRAINS_WAITING_TILL_OUT_OF_RANGE` | `void REACTIVATE_NAMED_OBJECT_BRAINS_WAITING_TILL_OUT_OF_RANGE(string scriptName)` | void | Looks like a cousin of above function _6D6840CEE8845831 as it was found among them. Must be similar<br>... |
| `REACTIVATE_NAMED_WORLD_BRAINS_WAITING_TILL_OUT_OF_RANGE` | `void REACTIVATE_NAMED_WORLD_BRAINS_WAITING_TILL_OUT_OF_RANGE(string scriptName)` | void | Possible values:<br><br>act_cinema<br>am_mp_carwash_launch<br>am_mp_carwash_control<br>am_mp_property_ext<br>chop<br>fair... |
| `REGISTER_OBJECT_SCRIPT_BRAIN` | `void REGISTER_OBJECT_SCRIPT_BRAIN(string scriptName, uint modelHash, int p2, float activationRange, int p4, int p5)` | void | Registers a script for any object with a specific model hash.<br><br>BRAIN::REGISTER_OBJECT_SCRIPT_BRAIN("... |
| `REGISTER_WORLD_POINT_SCRIPT_BRAIN` | `void REGISTER_WORLD_POINT_SCRIPT_BRAIN(string scriptName, float activationRange, int p2)` | void | - |
| `REMOVE_ALL_SHOCKING_EVENTS` | `void REMOVE_ALL_SHOCKING_EVENTS(bool p0)` | void | - |
| `REMOVE_NAVMESH_BLOCKING_OBJECT` | `void REMOVE_NAVMESH_BLOCKING_OBJECT(object p0)` | void | - |
| `REMOVE_NAVMESH_REQUIRED_REGIONS` | `void REMOVE_NAVMESH_REQUIRED_REGIONS()` | void | - |
| `REMOVE_SHOCKING_EVENT` | `bool REMOVE_SHOCKING_EVENT(int event)` | bool | - |
| `REMOVE_SHOCKING_EVENT_SPAWN_BLOCKING_AREAS` | `void REMOVE_SHOCKING_EVENT_SPAWN_BLOCKING_AREAS()` | void | - |
| `REQUEST_PATH_NODES_IN_AREA_THIS_FRAME` | `bool REQUEST_PATH_NODES_IN_AREA_THIS_FRAME(float x1, float y1, float x2, float y2)` | bool | Used internally for long range tasks |
| `SET_ALLOW_STREAM_HEIST_ISLAND_NODES` | `void SET_ALLOW_STREAM_HEIST_ISLAND_NODES(int type)` | void | Activates Cayo Perico path nodes if passed `1`. GPS navigation will start working, maybe more stuff ... |
| `SET_ALLOW_STREAM_PROLOGUE_NODES` | `void SET_ALLOW_STREAM_PROLOGUE_NODES(bool toggle)` | void | - |
| `SET_AMBIENT_PED_RANGE_MULTIPLIER_THIS_FRAME` | `void SET_AMBIENT_PED_RANGE_MULTIPLIER_THIS_FRAME(float multiplier)` | void | - |
| `SET_DECISION_MAKER` | `void SET_DECISION_MAKER(int ped, uint name)` | void | - |
| `SET_GPS_DISABLED_ZONE` | `void SET_GPS_DISABLED_ZONE(float x1, float y1, float z1, float x2, float y2, float z3)` | void | - |
| `SET_GPS_DISABLED_ZONE_AT_INDEX` | `void SET_GPS_DISABLED_ZONE_AT_INDEX(float x1, float y1, float z1, float x2, float y2, float z2, int index)` | void | Disables the GPS route displayed on the minimap while within a certain zone (area). When in a disabl... |
| `SET_IGNORE_NO_GPS_FLAG` | `void SET_IGNORE_NO_GPS_FLAG(bool toggle)` | void | - |
| `SET_IGNORE_NO_GPS_FLAG_UNTIL_FIRST_NORMAL_NODE` | `void SET_IGNORE_NO_GPS_FLAG_UNTIL_FIRST_NORMAL_NODE(bool toggle)` | void | See: SET_BLIP_ROUTE |
| `SET_PED_PATHS_BACK_TO_ORIGINAL` | `void SET_PED_PATHS_BACK_TO_ORIGINAL(float x1, float y1, float z1, float x2, float y2, float z2, object p6)` | void | p6 is always 0 |
| `SET_PED_PATHS_IN_AREA` | `void SET_PED_PATHS_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool p6, object p7)` | void | - |
| `SET_ROADS_BACK_TO_ORIGINAL` | `void SET_ROADS_BACK_TO_ORIGINAL(float p0, float p1, float p2, float p3, float p4, float p5, object p6)` | void | - |
| `SET_ROADS_BACK_TO_ORIGINAL_IN_ANGLED_AREA` | `void SET_ROADS_BACK_TO_ORIGINAL_IN_ANGLED_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float width, object p7)` | void | See IS_POINT_IN_ANGLED_AREA for the definition of an angled area.<br>bool p7 - always 1 |
| `SET_ROADS_IN_ANGLED_AREA` | `void SET_ROADS_IN_ANGLED_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float width, bool unknown1, bool unknown2, bool unknown3)` | void | unknown3 is related to `SEND_SCRIPT_WORLD_STATE_EVENT > CNetworkRoadNodeWorldStateData` in networked... |
| `SET_ROADS_IN_AREA` | `void SET_ROADS_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool nodeEnabled, bool unknown2)` | void | When nodeEnabled is set to false, all nodes in the area get disabled.<br>`GET_VEHICLE_NODE_IS_SWITCHED_... |
| `SUPPRESS_AGITATION_EVENTS_NEXT_FRAME` | `void SUPPRESS_AGITATION_EVENTS_NEXT_FRAME()` | void | - |
| `SUPPRESS_SHOCKING_EVENTS_NEXT_FRAME` | `void SUPPRESS_SHOCKING_EVENTS_NEXT_FRAME()` | void | - |
| `SUPPRESS_SHOCKING_EVENT_TYPE_NEXT_FRAME` | `void SUPPRESS_SHOCKING_EVENT_TYPE_NEXT_FRAME(int eventType)` | void | eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt |
| `UNBLOCK_DECISION_MAKER_EVENT` | `void UNBLOCK_DECISION_MAKER_EVENT(uint name, int eventType)` | void | eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt |
| `UPDATE_NAVMESH_BLOCKING_OBJECT` | `void UPDATE_NAVMESH_BLOCKING_OBJECT(object p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, object p8)` | void | - |

---

## 详细说明

### ADD_NAVMESH_BLOCKING_OBJECT

- **命名空间:** `PATHFIND`
- **Hash:** `0xFCD5C8E06E502F5A`
- **JHash:** `0x2952BA56`
- **Build:** `323`

**C# 签名:**
```csharp
int ADD_NAVMESH_BLOCKING_OBJECT(float p0, float p1, float p2, float p3, float p4, float p5, float p6, bool p7, object p8)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `float` | `float` | - |
| `p5` | `float` | `float` | - |
| `p6` | `float` | `float` | - |
| `p7` | `BOOL` | `bool` | - |
| `p8` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### ADD_NAVMESH_REQUIRED_REGION

- **命名空间:** `PATHFIND`
- **Hash:** `0x387EAD7EE42F6685`
- **JHash:** `0x12B086EA`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_NAVMESH_REQUIRED_REGION(float x, float y, float radius)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `radius` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### ADD_SCRIPT_TO_RANDOM_PED

- **命名空间:** `BRAIN`
- **Hash:** `0x4EE5367468A65CCC`
- **JHash:** `0xECC76C3D`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_SCRIPT_TO_RANDOM_PED(string name, uint model, float p2, float p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |
| `model` | `Hash` | `uint` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
BRAIN::ADD_SCRIPT_TO_RANDOM_PED("pb_prostitute", ${s_f_y_hooker_01}, 100, 0);

- Nacorpio

-----

Hardcoded to not work in Multiplayer.
```

---

### ADD_SHOCKING_EVENT_AT_POSITION

- **命名空间:** `EVENT`
- **Hash:** `0xD9F8455409B525E9`
- **JHash:** `0x0B30F779`
- **Build:** `323`

**C# 签名:**
```csharp
int ADD_SHOCKING_EVENT_AT_POSITION(int eventType, float x, float y, float z, float duration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `eventType` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `duration` | `float` | `float` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt
```

---

### ADD_SHOCKING_EVENT_FOR_ENTITY

- **命名空间:** `EVENT`
- **Hash:** `0x7FD8F3BE76F89422`
- **JHash:** `0xA81B5B71`
- **Build:** `323`

**C# 签名:**
```csharp
int ADD_SHOCKING_EVENT_FOR_ENTITY(int eventType, int entity, float duration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `eventType` | `int` | `int` | - |
| `entity` | `Entity` | `int` | - |
| `duration` | `float` | `float` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt
```

---

### ADJUST_AMBIENT_PED_SPAWN_DENSITIES_THIS_FRAME

- **命名空间:** `PATHFIND`
- **Hash:** `0xAA76052DDA9BFC3E`
- **JHash:** `0xD0F51299`
- **Build:** `323`

**C# 签名:**
```csharp
void ADJUST_AMBIENT_PED_SPAWN_DENSITIES_THIS_FRAME(object p0, object p1, object p2, object p3, object p4, object p5, object p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |
| `p5` | `Any` | `object` | - |
| `p6` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### ARE_ALL_NAVMESH_REGIONS_LOADED

- **命名空间:** `PATHFIND`
- **Hash:** `0x8415D95B194A3AEA`
- **JHash:** `0x34C4E789`
- **Build:** `323`

**C# 签名:**
```csharp
bool ARE_ALL_NAVMESH_REGIONS_LOADED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### ARE_NODES_LOADED_FOR_AREA

- **命名空间:** `PATHFIND`
- **Hash:** `0xF7B79A50B905A30D`
- **JHash:** `0x86E80A17`
- **Build:** `323`

**C# 签名:**
```csharp
bool ARE_NODES_LOADED_FOR_AREA(float x1, float y1, float x2, float y2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### BLOCK_DECISION_MAKER_EVENT

- **命名空间:** `EVENT`
- **Hash:** `0xE42FCDFD0E4196F7`
- **JHash:** `0x57506EA6`
- **Build:** `323`

**C# 签名:**
```csharp
void BLOCK_DECISION_MAKER_EVENT(uint name, int eventType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `Hash` | `uint` | - |
| `eventType` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt

This is limited to 4 blocked events at a time.
```

---

### CALCULATE_TRAVEL_DISTANCE_BETWEEN_POINTS

- **命名空间:** `PATHFIND`
- **Hash:** `0xADD95C7005C4A197`
- **JHash:** `0xB114489B`
- **Build:** `323`

**C# 签名:**
```csharp
float CALCULATE_TRAVEL_DISTANCE_BETWEEN_POINTS(float x1, float y1, float z1, float x2, float y2, float z2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |
| `z2` | `float` | `float` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Calculates the travel distance between a set of points.

Doesn't seem to correlate with distance on gps sometimes.
This function returns the value 100000.0 over long distances, seems to be a failure mode result, potentially occurring when not all path nodes are loaded into pathfind.
```

---

### CLEAR_DECISION_MAKER_EVENT_RESPONSE

- **命名空间:** `EVENT`
- **Hash:** `0x4FC9381A7AEE8968`
- **JHash:** `0x07ABD94D`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_DECISION_MAKER_EVENT_RESPONSE(uint name, int eventType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `Hash` | `uint` | - |
| `eventType` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt
```

---

### CLEAR_GPS_DISABLED_ZONE_AT_INDEX

- **命名空间:** `PATHFIND`
- **Hash:** `0x2801D0012266DF07`
- **JHash:** `0x59090745`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_GPS_DISABLED_ZONE_AT_INDEX(int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Clears a disabled GPS route area from a certain index previously set using `SET_GPS_DISABLED_ZONE_AT_INDEX`.
```

---

### DISABLE_NAVMESH_IN_AREA

- **命名空间:** `PATHFIND`
- **Hash:** `0x4C8872D8CDBE1B8B`
- **JHash:** `0x6E37F132`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_NAVMESH_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |
| `z2` | `float` | `float` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Set toggle true to disable navmesh.
Set toggle false to enable navmesh.
```

---

### DISABLE_SCRIPT_BRAIN_SET

- **命名空间:** `BRAIN`
- **Hash:** `0x14D8518E9760F08F`
- **JHash:** `0xFBD13FAD`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_SCRIPT_BRAIN_SET(int brainSet)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `brainSet` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DOES_NAVMESH_BLOCKING_OBJECT_EXIST

- **命名空间:** `PATHFIND`
- **Hash:** `0x0EAEB0DB4B132399`
- **JHash:** `0x4B67D7EE`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_NAVMESH_BLOCKING_OBJECT_EXIST(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### ENABLE_SCRIPT_BRAIN_SET

- **命名空间:** `BRAIN`
- **Hash:** `0x67AA4D73F0CFA86B`
- **JHash:** `0x2765919F`
- **Build:** `323`

**C# 签名:**
```csharp
void ENABLE_SCRIPT_BRAIN_SET(int brainSet)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `brainSet` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### GENERATE_DIRECTIONS_TO_COORD

- **命名空间:** `PATHFIND`
- **Hash:** `0xF90125F1F79ECDF8`
- **JHash:** `0xED35C094`
- **Build:** `323`

**C# 签名:**
```csharp
int GENERATE_DIRECTIONS_TO_COORD(float x, float y, float z, bool p3, ref int direction, ref float p5, ref float distToNxJunction)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p3` | `BOOL` | `bool` | - |
| `direction` | `int*` | `ref int` | - |
| `p5` | `float*` | `ref float` | - |
| `distToNxJunction` | `float*` | `ref float` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
p3 is 0 in the only game script occurrence (trevor3) but 1 doesn't seem to make a difference

distToNxJunction seems to be the distance in metres * 10.0f

direction:
0 = This happens randomly during the drive for seemingly no reason but if you consider that this native is only used in trevor3, it seems to mean "Next frame, stop whatever's being said and tell the player the direction."
1 = Route is being calculated or the player is going in the wrong direction
2 = Please Proceed the Highlighted Route
3 = In (distToNxJunction) Turn Left
4 = In (distToNxJunction) Turn Right
5 = In (distToNxJunction) Keep Straight
6 = In (distToNxJunction) Turn Sharply To The Left
7 = In (distToNxJunction) Turn Sharply To The Right
8 = Route is being recalculated or the navmesh is confusing. This happens randomly during the drive but consistently at {2044.0358, 2996.6116, 44.9717} if you face towards the bar and the route needs you to turn right. In that particular case, it could be a bug with how the turn appears to be 270 deg. CCW instead of "right." Either way, this seems to be the engine saying "I don't know the route right now."

return value set to 0 always
```

---

### GET_APPROX_FLOOR_FOR_AREA

- **命名空间:** `PATHFIND`
- **Hash:** `0x3599D741C9AC6310`
- **JHash:** `0x76751DD4`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_APPROX_FLOOR_FOR_AREA(float x1, float y1, float x2, float y2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Returns CGameWorldHeightMap's minimum Z among all grid nodes that intersect with the specified rectangle.
```

---

### GET_APPROX_FLOOR_FOR_POINT

- **命名空间:** `PATHFIND`
- **Hash:** `0x336511A34F2E5185`
- **JHash:** `0xA07C5B7D`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_APPROX_FLOOR_FOR_POINT(float x, float y)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Returns CGameWorldHeightMap's minimum Z value at specified point (grid node).
```

---

### GET_APPROX_HEIGHT_FOR_AREA

- **命名空间:** `PATHFIND`
- **Hash:** `0x8ABE8608576D9CE3`
- **JHash:** `0x3ED21C90`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_APPROX_HEIGHT_FOR_AREA(float x1, float y1, float x2, float y2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Returns CGameWorldHeightMap's maximum Z among all grid nodes that intersect with the specified rectangle.
```

---

### GET_APPROX_HEIGHT_FOR_POINT

- **命名空间:** `PATHFIND`
- **Hash:** `0x29C24BFBED8AB8FB`
- **JHash:** `0x3FE8C5A0`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_APPROX_HEIGHT_FOR_POINT(float x, float y)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Returns CGameWorldHeightMap's maximum Z value at specified point (grid node).
```

---

### GET_CLOSEST_MAJOR_VEHICLE_NODE

- **命名空间:** `PATHFIND`
- **Hash:** `0x2EABE3B06F58C1BE`
- **JHash:** `0x04B5F15B`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_CLOSEST_MAJOR_VEHICLE_NODE(float x, float y, float z, ref Vector3 outPosition, float unknown1, float unknown2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `outPosition` | `Vector3*` | `ref Vector3` | - |
| `unknown1` | `float` | `float` | - |
| `unknown2` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Get the closest vehicle node to a given position.
```

---

### GET_CLOSEST_ROAD

- **命名空间:** `PATHFIND`
- **Hash:** `0x132F52BBA570FE92`
- **JHash:** `0x567B0E11`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_CLOSEST_ROAD(float x, float y, float z, float p3, int p4, ref Vector3 p5, ref Vector3 p6, ref object p7, ref object p8, ref float p9, bool p10)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `int` | `int` | - |
| `p5` | `Vector3*` | `ref Vector3` | - |
| `p6` | `Vector3*` | `ref Vector3` | - |
| `p7` | `Any*` | `ref object` | - |
| `p8` | `Any*` | `ref object` | - |
| `p9` | `float*` | `ref float` | - |
| `p10` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p1 seems to be always 1.0f in the scripts
```

---

### GET_CLOSEST_VEHICLE_NODE

- **命名空间:** `PATHFIND`
- **Hash:** `0x240A18690AE96513`
- **JHash:** `0x6F5F1E6C`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_CLOSEST_VEHICLE_NODE(float x, float y, float z, ref Vector3 outPosition, int nodeFlags, float p5, float p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `outPosition` | `Vector3*` | `ref Vector3` | - |
| `nodeFlags` | `int` | `int` | - |
| `p5` | `float` | `float` | - |
| `p6` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
https://gtaforums.com/topic/843561-pathfind-node-types
```

---

### GET_CLOSEST_VEHICLE_NODE_WITH_HEADING

- **命名空间:** `PATHFIND`
- **Hash:** `0xFF071FB798B803B0`
- **JHash:** `0x8BD5759B`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_CLOSEST_VEHICLE_NODE_WITH_HEADING(float x, float y, float z, ref Vector3 outPosition, ref float outHeading, int nodeType, float p6, float p7)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `outPosition` | `Vector3*` | `ref Vector3` | - |
| `outHeading` | `float*` | `ref float` | - |
| `nodeType` | `int` | `int` | - |
| `p6` | `float` | `float` | - |
| `p7` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p5, p6 and p7 seems to be about the same as p4, p5 and p6 for GET_CLOSEST_VEHICLE_NODE. p6 and/or p7 has something to do with finding a node on the same path/road and same direction(at least for this native, something to do with the heading maybe). Edit this when you find out more.

nodeType: 0 = main roads, 1 = any dry path, 3 = water
p6 is always 3.0
p7 is always 0

gtaforums.com/topic/843561-pathfind-node-types

Example of usage, moving vehicle to closest path/road:
Vector3 coords = ENTITY::GET_ENTITY_COORDS(playerVeh, true);
Vector3 closestVehicleNodeCoords; 
float roadHeading; 
PATHFIND::GET_CLOSEST_VEHICLE_NODE_WITH_HEADING(coords.x, coords.y, coords.z, &closestVehicleNodeCoords, &roadHeading, 1, 3, 0); 
ENTITY::SET_ENTITY_HEADING(playerVeh, roadHeading);
ENTITY::SET_ENTITY_COORDS(playerVeh, closestVehicleNodeCoords.x, closestVehicleNodeCoords.y, closestVehicleNodeCoords.z, 1, 0, 0, 1);
VEHICLE::SET_VEHICLE_ON_GROUND_PROPERLY(playerVeh);

------------------------------------------------------------------
C# Example (ins1de) : https://pastebin.com/fxtMWAHD
```

---

### GET_GPS_BLIP_ROUTE_FOUND

- **命名空间:** `PATHFIND`
- **Hash:** `0x869DAACBBE9FA006`
- **JHash:** `0x286F82CC`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_GPS_BLIP_ROUTE_FOUND()
```

**返回值:** `bool` (Native: `BOOL`)

---

### GET_GPS_BLIP_ROUTE_LENGTH

- **命名空间:** `PATHFIND`
- **Hash:** `0xBBB45C3CF5C8AA85`
- **JHash:** `0x4B770634`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_GPS_BLIP_ROUTE_LENGTH()
```

**返回值:** `int` (Native: `int`)

---

### GET_NEXT_GPS_DISABLED_ZONE_INDEX

- **命名空间:** `PATHFIND`
- **Hash:** `0xD3A6A0EF48823A8C`
- **JHash:** `0xBE92551F`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NEXT_GPS_DISABLED_ZONE_INDEX()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Gets the next zone that has been disabled using SET_GPS_DISABLED_ZONE_AT_INDEX.
```

---

### GET_NTH_CLOSEST_VEHICLE_NODE

- **命名空间:** `PATHFIND`
- **Hash:** `0xE50E52416CCF948B`
- **JHash:** `0xF125BFCC`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_NTH_CLOSEST_VEHICLE_NODE(float x, float y, float z, int nthClosest, ref Vector3 outPosition, int nodeFlags, float unknown1, float unknown2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `nthClosest` | `int` | `int` | - |
| `outPosition` | `Vector3*` | `ref Vector3` | - |
| `nodeFlags` | `int` | `int` | - |
| `unknown1` | `float` | `float` | - |
| `unknown2` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_NTH_CLOSEST_VEHICLE_NODE_FAVOUR_DIRECTION

- **命名空间:** `PATHFIND`
- **Hash:** `0x45905BE8654AE067`
- **JHash:** `0x928A4DEC`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_NTH_CLOSEST_VEHICLE_NODE_FAVOUR_DIRECTION(float x, float y, float z, float desiredX, float desiredY, float desiredZ, int nthClosest, ref Vector3 outPosition, ref float outHeading, int nodeFlags, float p10, float p11)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `desiredX` | `float` | `float` | - |
| `desiredY` | `float` | `float` | - |
| `desiredZ` | `float` | `float` | - |
| `nthClosest` | `int` | `int` | - |
| `outPosition` | `Vector3*` | `ref Vector3` | - |
| `outHeading` | `float*` | `ref float` | - |
| `nodeFlags` | `int` | `int` | - |
| `p10` | `float` | `float` | - |
| `p11` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
See gtaforums.com/topic/843561-pathfind-node-types for node type info. 0 = paved road only, 1 = any road, 3 = water

p10 always equals 3.0
p11 always equals 0
```

---

### GET_NTH_CLOSEST_VEHICLE_NODE_ID

- **命名空间:** `PATHFIND`
- **Hash:** `0x22D7275A79FE8215`
- **JHash:** `0x3F358BEA`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NTH_CLOSEST_VEHICLE_NODE_ID(float x, float y, float z, int nth, int nodeFlags, float p5, float p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `nth` | `int` | `int` | - |
| `nodeFlags` | `int` | `int` | - |
| `p5` | `float` | `float` | - |
| `p6` | `float` | `float` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns the id.
```

---

### GET_NTH_CLOSEST_VEHICLE_NODE_ID_WITH_HEADING

- **命名空间:** `PATHFIND`
- **Hash:** `0x6448050E9C2A7207`
- **JHash:** `0xC1AEB88D`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NTH_CLOSEST_VEHICLE_NODE_ID_WITH_HEADING(float x, float y, float z, int nthClosest, ref Vector3 outPosition, ref float outHeading, int nodeFlags, float p7, float p8)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `nthClosest` | `int` | `int` | - |
| `outPosition` | `Vector3*` | `ref Vector3` | - |
| `outHeading` | `float*` | `ref float` | - |
| `nodeFlags` | `int` | `int` | - |
| `p7` | `float` | `float` | - |
| `p8` | `float` | `float` | - |

**返回值:** `int` (Native: `int`)

---

### GET_NTH_CLOSEST_VEHICLE_NODE_WITH_HEADING

- **命名空间:** `PATHFIND`
- **Hash:** `0x80CA6A8B6C094CC4`
- **JHash:** `0x7349C856`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_NTH_CLOSEST_VEHICLE_NODE_WITH_HEADING(float x, float y, float z, int nthClosest, ref Vector3 outPosition, ref float outHeading, ref int outNumLanes, int nodeFlags, float unknown3, float unknown4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `nthClosest` | `int` | `int` | - |
| `outPosition` | `Vector3*` | `ref Vector3` | - |
| `outHeading` | `float*` | `ref float` | - |
| `outNumLanes` | `int*` | `ref int` | - |
| `nodeFlags` | `int` | `int` | - |
| `unknown3` | `float` | `float` | - |
| `unknown4` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Get the nth closest vehicle node and its heading.
```

---

### GET_NUM_NAVMESHES_EXISTING_IN_AREA

- **命名空间:** `PATHFIND`
- **Hash:** `0x01708E8DD3FF8C65`
- **JHash:** `0x76AFFBB5`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUM_NAVMESHES_EXISTING_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |
| `z2` | `float` | `float` | - |

**返回值:** `int` (Native: `int`)

---

### GET_POSITION_BY_SIDE_OF_ROAD

- **命名空间:** `PATHFIND`
- **Hash:** `0x16F46FB18C8009E4`
- **JHash:** `0xF6422F9A`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_POSITION_BY_SIDE_OF_ROAD(float x, float y, float z, int p3, ref Vector3 outPosition)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p3` | `int` | `int` | - |
| `outPosition` | `Vector3*` | `ref Vector3` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_POS_ALONG_GPS_TYPE_ROUTE

- **命名空间:** `PATHFIND`
- **Hash:** `0xF3162836C28F9DA5`
- **Build:** `505`

**C# 签名:**
```csharp
bool GET_POS_ALONG_GPS_TYPE_ROUTE(ref Vector3 result, bool p1, float p2, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `result` | `Vector3*` | `ref Vector3` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `float` | `float` | - |
| `p3` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p3 can be 0, 1 or 2.
```

---

### GET_RANDOM_VEHICLE_NODE

- **命名空间:** `PATHFIND`
- **Hash:** `0x93E0DB8440B73A7D`
- **JHash:** `0xAD1476EA`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_RANDOM_VEHICLE_NODE(float x, float y, float z, float radius, bool p4, bool p5, bool p6, ref Vector3 outPosition, ref int nodeId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `p4` | `BOOL` | `bool` | - |
| `p5` | `BOOL` | `bool` | - |
| `p6` | `BOOL` | `bool` | - |
| `outPosition` | `Vector3*` | `ref Vector3` | - |
| `nodeId` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_ROAD_BOUNDARY_USING_HEADING

- **命名空间:** `PATHFIND`
- **Hash:** `0xA0F8A7517A273C05`
- **JHash:** `0x5E440AC7`
- **Build:** `463`

**C# 签名:**
```csharp
bool GET_ROAD_BOUNDARY_USING_HEADING(float x, float y, float z, float heading, ref Vector3 outPosition)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `heading` | `float` | `float` | - |
| `outPosition` | `Vector3*` | `ref Vector3` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_SAFE_COORD_FOR_PED

- **命名空间:** `PATHFIND`
- **Hash:** `0xB61C8E878A4199CA`
- **JHash:** `0xB370270A`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_SAFE_COORD_FOR_PED(float x, float y, float z, bool onGround, ref Vector3 outPosition, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `onGround` | `BOOL` | `bool` | - |
| `outPosition` | `Vector3*` | `ref Vector3` | - |
| `flags` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Flags are:
1 = 1 = B02_IsFootpath
2 = 4 = !B15_InteractionUnk
4 = 0x20 = !B14_IsInterior
8 = 0x40 = !B07_IsWater
16 = 0x200 = B17_IsFlatGround
When onGround == true outPosition is a position located on the nearest pavement.

When a safe coord could not be found the result of a function is false and outPosition == Vector3.Zero.

In the scripts these flags are used: 0, 14, 12, 16, 20, 21, 28. 0 is most commonly used, then 16. 

16 works for me, 0 crashed the script.
```

---

### GET_SPAWN_COORDS_FOR_VEHICLE_NODE

- **命名空间:** `PATHFIND`
- **Hash:** `0x809549AFC7AEC597`
- **Build:** `2944`

**C# 签名:**
```csharp
void GET_SPAWN_COORDS_FOR_VEHICLE_NODE(int nodeAddress, float towardsCoorsX, float towardsCoorsY, float towardsCoorsZ, ref Vector3 centrePoint, ref float heading)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `nodeAddress` | `int` | `int` | - |
| `towardsCoorsX` | `float` | `float` | - |
| `towardsCoorsY` | `float` | `float` | - |
| `towardsCoorsZ` | `float` | `float` | - |
| `centrePoint` | `Vector3*` | `ref Vector3` | - |
| `heading` | `float*` | `ref float` | - |

**返回值:** `void` (Native: `void`)

---

### GET_STREET_NAME_AT_COORD

- **命名空间:** `PATHFIND`
- **Hash:** `0x2EB41072B4C1E4C0`
- **JHash:** `0xDEBEEFCF`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_STREET_NAME_AT_COORD(float x, float y, float z, Hash* streetName, Hash* crossingRoad)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `streetName` | `Hash*` | `Hash*` | - |
| `crossingRoad` | `Hash*` | `Hash*` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Determines the name of the street which is the closest to the given coordinates.

x,y,z - the coordinates of the street
streetName - returns a hash to the name of the street the coords are on
crossingRoad - if the coordinates are on an intersection, a hash to the name of the crossing road

Note: the names are returned as hashes, the strings can be returned using the function HUD::GET_STREET_NAME_FROM_HASH_KEY.
```

---

### GET_VEHICLE_NODE_IS_GPS_ALLOWED

- **命名空间:** `PATHFIND`
- **Hash:** `0xA2AE5C478B96E3B6`
- **JHash:** `0xEE4B1219`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_VEHICLE_NODE_IS_GPS_ALLOWED(int nodeID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `nodeID` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns false for nodes that aren't used for GPS routes.
Example:
Nodes in Fort Zancudo and LSIA are false
```

---

### GET_VEHICLE_NODE_IS_SWITCHED_OFF

- **命名空间:** `PATHFIND`
- **Hash:** `0x4F5070AA58F69279`
- **JHash:** `0x56737A3C`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_VEHICLE_NODE_IS_SWITCHED_OFF(int nodeID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `nodeID` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true when the node is Offroad. Alleys, some dirt roads, and carparks return true.
Normal roads where plenty of Peds spawn will return false
```

---

### GET_VEHICLE_NODE_POSITION

- **命名空间:** `PATHFIND`
- **Hash:** `0x703123E5E7D429C2`
- **JHash:** `0xE38E252D`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_VEHICLE_NODE_POSITION(int nodeId, ref Vector3 outPosition)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `nodeId` | `int` | `int` | - |
| `outPosition` | `Vector3*` | `ref Vector3` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Calling this with an invalid node id, will crash the game.
Note that IS_VEHICLE_NODE_ID_VALID simply checks if nodeId is not zero. It does not actually ensure that the id is valid.
Eg. IS_VEHICLE_NODE_ID_VALID(1) will return true, but will crash when calling GET_VEHICLE_NODE_POSITION().
```

---

### GET_VEHICLE_NODE_PROPERTIES

- **命名空间:** `PATHFIND`
- **Hash:** `0x0568566ACBB5DEDC`
- **JHash:** `0xCC90110B`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_VEHICLE_NODE_PROPERTIES(float x, float y, float z, ref int density, ref int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `density` | `int*` | `ref int` | - |
| `flags` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Gets the density and flags of the closest node to the specified position.
Density is a value between 0 and 15, indicating how busy the road is.
Flags is a bit field.
```

---

### IS_NAVMESH_LOADED_IN_AREA

- **命名空间:** `PATHFIND`
- **Hash:** `0xF813C7E63F9062A5`
- **JHash:** `0x4C2BA99E`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_NAVMESH_LOADED_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |
| `z2` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns whether navmesh for the region is loaded. The region is a rectangular prism defined by it's top left deepest corner to it's bottom right shallowest corner.

If you can re-word this so it makes more sense, please do. I'm horrible with words sometimes...
```

---

### IS_NAVMESH_REQUIRED_REGION_IN_USE

- **命名空间:** `PATHFIND`
- **Hash:** `0x705A844002B39DC0`
- **Build:** `944`

**C# 签名:**
```csharp
bool IS_NAVMESH_REQUIRED_REGION_IN_USE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_OBJECT_WITHIN_BRAIN_ACTIVATION_RANGE

- **命名空间:** `BRAIN`
- **Hash:** `0xCCBA154209823057`
- **JHash:** `0xBA4CAA56`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_OBJECT_WITHIN_BRAIN_ACTIVATION_RANGE(int object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_POINT_ON_ROAD

- **命名空间:** `PATHFIND`
- **Hash:** `0x125BF4ABFC536B09`
- **JHash:** `0xCF198055`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_POINT_ON_ROAD(float x, float y, float z, int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Gets a value indicating whether the specified position is on a road.
The vehicle parameter is not implemented (ignored).
```

---

### IS_SHOCKING_EVENT_IN_SPHERE

- **命名空间:** `EVENT`
- **Hash:** `0x1374ABB7C15BAB92`
- **JHash:** `0x2F98823E`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SHOCKING_EVENT_IN_SPHERE(int eventType, float x, float y, float z, float radius)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `eventType` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt
```

---

### IS_VEHICLE_NODE_ID_VALID

- **命名空间:** `PATHFIND`
- **Hash:** `0x1EAF30FCFBF5AF74`
- **JHash:** `0x57DFB1EF`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_NODE_ID_VALID(int vehicleNodeId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicleNodeId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if the id is non zero.
```

---

### IS_WORLD_POINT_WITHIN_BRAIN_ACTIVATION_RANGE

- **命名空间:** `BRAIN`
- **Hash:** `0xC5042CC6F5E3D450`
- **JHash:** `0x2CF305A0`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_WORLD_POINT_WITHIN_BRAIN_ACTIVATION_RANGE()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Gets whether the world point the calling script is registered to is within desired range of the player.
```

---

### LOAD_ALL_PATH_NODES

- **命名空间:** `PATHFIND`
- **Hash:** `0xC2AB6BFE34E92F8B`
- **Build:** `2802`

**C# 签名:**
```csharp
bool LOAD_ALL_PATH_NODES(bool set)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `set` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### REACTIVATE_ALL_OBJECT_BRAINS_THAT_ARE_WAITING_TILL_OUT_OF_RANGE

- **命名空间:** `BRAIN`
- **Hash:** `0x4D953DF78EBF8158`
- **JHash:** `0xF3A3AB08`
- **Build:** `323`

**C# 签名:**
```csharp
void REACTIVATE_ALL_OBJECT_BRAINS_THAT_ARE_WAITING_TILL_OUT_OF_RANGE()
```

**返回值:** `void` (Native: `void`)

---

### REACTIVATE_ALL_WORLD_BRAINS_THAT_ARE_WAITING_TILL_OUT_OF_RANGE

- **命名空间:** `BRAIN`
- **Hash:** `0x0B40ED49D7D6FF84`
- **JHash:** `0x19B27825`
- **Build:** `323`

**C# 签名:**
```csharp
void REACTIVATE_ALL_WORLD_BRAINS_THAT_ARE_WAITING_TILL_OUT_OF_RANGE()
```

**返回值:** `void` (Native: `void`)

---

### REACTIVATE_NAMED_OBJECT_BRAINS_WAITING_TILL_OUT_OF_RANGE

- **命名空间:** `BRAIN`
- **Hash:** `0x6E91B04E08773030`
- **JHash:** `0x29CE8BAA`
- **Build:** `323`

**C# 签名:**
```csharp
void REACTIVATE_NAMED_OBJECT_BRAINS_WAITING_TILL_OUT_OF_RANGE(string scriptName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scriptName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Looks like a cousin of above function _6D6840CEE8845831 as it was found among them. Must be similar

Here are possible values of argument - 

"ob_tv"
"launcher_Darts"
```

---

### REACTIVATE_NAMED_WORLD_BRAINS_WAITING_TILL_OUT_OF_RANGE

- **命名空间:** `BRAIN`
- **Hash:** `0x6D6840CEE8845831`
- **JHash:** `0x949FE53E`
- **Build:** `323`

**C# 签名:**
```csharp
void REACTIVATE_NAMED_WORLD_BRAINS_WAITING_TILL_OUT_OF_RANGE(string scriptName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scriptName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Possible values:

act_cinema
am_mp_carwash_launch
am_mp_carwash_control
am_mp_property_ext
chop
fairgroundHub
launcher_BasejumpHeli
launcher_BasejumpPack
launcher_CarWash
launcher_golf
launcher_Hunting_Ambient
launcher_MrsPhilips
launcher_OffroadRacing
launcher_pilotschool
launcher_Racing
launcher_rampage
launcher_rampage
launcher_range
launcher_stunts
launcher_stunts
launcher_tennis
launcher_Tonya
launcher_Triathlon
launcher_Yoga
ob_mp_bed_low
ob_mp_bed_med
```

---

### REGISTER_OBJECT_SCRIPT_BRAIN

- **命名空间:** `BRAIN`
- **Hash:** `0x0BE84C318BA6EC22`
- **JHash:** `0xB6BCC608`
- **Build:** `323`

**C# 签名:**
```csharp
void REGISTER_OBJECT_SCRIPT_BRAIN(string scriptName, uint modelHash, int p2, float activationRange, int p4, int p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scriptName` | `const char*` | `string` | - |
| `modelHash` | `Hash` | `uint` | - |
| `p2` | `int` | `int` | - |
| `activationRange` | `float` | `float` | - |
| `p4` | `int` | `int` | - |
| `p5` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Registers a script for any object with a specific model hash.

BRAIN::REGISTER_OBJECT_SCRIPT_BRAIN("ob_telescope", ${prop_telescope_01}, 100, 4.0, -1, 9);

- Nacorpio
```

---

### REGISTER_WORLD_POINT_SCRIPT_BRAIN

- **命名空间:** `BRAIN`
- **Hash:** `0x3CDC7136613284BD`
- **JHash:** `0x725D91F7`
- **Build:** `323`

**C# 签名:**
```csharp
void REGISTER_WORLD_POINT_SCRIPT_BRAIN(string scriptName, float activationRange, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scriptName` | `const char*` | `string` | - |
| `activationRange` | `float` | `float` | - |
| `p2` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_ALL_SHOCKING_EVENTS

- **命名空间:** `EVENT`
- **Hash:** `0xEAABE8FDFA21274C`
- **JHash:** `0x64DF6282`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_ALL_SHOCKING_EVENTS(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_NAVMESH_BLOCKING_OBJECT

- **命名空间:** `PATHFIND`
- **Hash:** `0x46399A7895957C0E`
- **JHash:** `0x098602B0`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_NAVMESH_BLOCKING_OBJECT(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_NAVMESH_REQUIRED_REGIONS

- **命名空间:** `PATHFIND`
- **Hash:** `0x916F0A3CDEC3445E`
- **JHash:** `0x637BB680`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_NAVMESH_REQUIRED_REGIONS()
```

**返回值:** `void` (Native: `void`)

---

### REMOVE_SHOCKING_EVENT

- **命名空间:** `EVENT`
- **Hash:** `0x2CDA538C44C6CCE5`
- **JHash:** `0xF82D5A87`
- **Build:** `323`

**C# 签名:**
```csharp
bool REMOVE_SHOCKING_EVENT(int event)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `event` | `ScrHandle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### REMOVE_SHOCKING_EVENT_SPAWN_BLOCKING_AREAS

- **命名空间:** `EVENT`
- **Hash:** `0x340F1415B68AEADE`
- **JHash:** `0xA0CE89C8`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_SHOCKING_EVENT_SPAWN_BLOCKING_AREAS()
```

**返回值:** `void` (Native: `void`)

---

### REQUEST_PATH_NODES_IN_AREA_THIS_FRAME

- **命名空间:** `PATHFIND`
- **Hash:** `0x07FB139B592FA687`
- **JHash:** `0x2CDA5012`
- **Build:** `323`

**C# 签名:**
```csharp
bool REQUEST_PATH_NODES_IN_AREA_THIS_FRAME(float x1, float y1, float x2, float y2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Used internally for long range tasks
```

---

### SET_ALLOW_STREAM_HEIST_ISLAND_NODES

- **命名空间:** `PATHFIND`
- **Hash:** `0xF74B1FFA4A15FBEA`
- **Build:** `2189`

**C# 签名:**
```csharp
void SET_ALLOW_STREAM_HEIST_ISLAND_NODES(int type)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `type` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Activates Cayo Perico path nodes if passed `1`. GPS navigation will start working, maybe more stuff will change, not sure. It seems if you try to unload (pass `0`) when close to the island, your game might crash.
```

---

### SET_ALLOW_STREAM_PROLOGUE_NODES

- **命名空间:** `PATHFIND`
- **Hash:** `0x228E5C6AD4D74BFD`
- **JHash:** `0xD6A3B458`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ALLOW_STREAM_PROLOGUE_NODES(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_AMBIENT_PED_RANGE_MULTIPLIER_THIS_FRAME

- **命名空间:** `PATHFIND`
- **Hash:** `0x0B919E1FB47CC4E0`
- **JHash:** `0x3C5085E4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AMBIENT_PED_RANGE_MULTIPLIER_THIS_FRAME(float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DECISION_MAKER

- **命名空间:** `EVENT`
- **Hash:** `0xB604A2942ADED0EE`
- **JHash:** `0x19CEAC9E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DECISION_MAKER(int ped, uint name)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `name` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GPS_DISABLED_ZONE

- **命名空间:** `PATHFIND`
- **Hash:** `0xDC20483CD3DD5201`
- **JHash:** `0x720B8073`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GPS_DISABLED_ZONE(float x1, float y1, float z1, float x2, float y2, float z3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |
| `z3` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GPS_DISABLED_ZONE_AT_INDEX

- **命名空间:** `PATHFIND`
- **Hash:** `0xD0BC1C6FB18EE154`
- **JHash:** `0x98BDB311`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GPS_DISABLED_ZONE_AT_INDEX(float x1, float y1, float z1, float x2, float y2, float z2, int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |
| `z2` | `float` | `float` | - |
| `index` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Disables the GPS route displayed on the minimap while within a certain zone (area). When in a disabled zone and creating a waypoint, the GPS route is not shown on the minimap until you are outside of the zone. When disabled, the direct distance is shown on minimap opposed to distance to travel. Seems to only work before setting a waypoint.
You can clear the disabled zone with CLEAR_GPS_DISABLED_ZONE_AT_INDEX.

**Setting a waypoint at the same coordinate:**
Disabled Zone: https://i.imgur.com/P9VUuxM.png
Enabled Zone (normal): https://i.imgur.com/BPi24aw.png
```

---

### SET_IGNORE_NO_GPS_FLAG

- **命名空间:** `PATHFIND`
- **Hash:** `0x72751156E7678833`
- **JHash:** `0xB72CF194`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_IGNORE_NO_GPS_FLAG(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_IGNORE_NO_GPS_FLAG_UNTIL_FIRST_NORMAL_NODE

- **命名空间:** `PATHFIND`
- **Hash:** `0x1FC289A0C3FF470F`
- **JHash:** `0x90DF7A4C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_IGNORE_NO_GPS_FLAG_UNTIL_FIRST_NORMAL_NODE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
See: SET_BLIP_ROUTE
```

---

### SET_PED_PATHS_BACK_TO_ORIGINAL

- **命名空间:** `PATHFIND`
- **Hash:** `0xE04B48F2CC926253`
- **JHash:** `0x3F1ABDA4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_PATHS_BACK_TO_ORIGINAL(float x1, float y1, float z1, float x2, float y2, float z2, object p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |
| `z2` | `float` | `float` | - |
| `p6` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p6 is always 0
```

---

### SET_PED_PATHS_IN_AREA

- **命名空间:** `PATHFIND`
- **Hash:** `0x34F060F4BF92E018`
- **JHash:** `0x2148EA84`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_PATHS_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool p6, object p7)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |
| `z2` | `float` | `float` | - |
| `p6` | `BOOL` | `bool` | - |
| `p7` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ROADS_BACK_TO_ORIGINAL

- **命名空间:** `PATHFIND`
- **Hash:** `0x1EE7063B80FFC77C`
- **JHash:** `0x86AC4A85`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ROADS_BACK_TO_ORIGINAL(float p0, float p1, float p2, float p3, float p4, float p5, object p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `float` | `float` | - |
| `p5` | `float` | `float` | - |
| `p6` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ROADS_BACK_TO_ORIGINAL_IN_ANGLED_AREA

- **命名空间:** `PATHFIND`
- **Hash:** `0x0027501B9F3B407E`
- **JHash:** `0x9DB5D209`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ROADS_BACK_TO_ORIGINAL_IN_ANGLED_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float width, object p7)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |
| `z2` | `float` | `float` | - |
| `width` | `float` | `float` | - |
| `p7` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
See IS_POINT_IN_ANGLED_AREA for the definition of an angled area.
bool p7 - always 1
```

---

### SET_ROADS_IN_ANGLED_AREA

- **命名空间:** `PATHFIND`
- **Hash:** `0x1A5AA1208AF5DB59`
- **JHash:** `0xBD088F4B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ROADS_IN_ANGLED_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float width, bool unknown1, bool unknown2, bool unknown3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |
| `z2` | `float` | `float` | - |
| `width` | `float` | `float` | - |
| `unknown1` | `BOOL` | `bool` | - |
| `unknown2` | `BOOL` | `bool` | - |
| `unknown3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
unknown3 is related to `SEND_SCRIPT_WORLD_STATE_EVENT > CNetworkRoadNodeWorldStateData` in networked environments.
See IS_POINT_IN_ANGLED_AREA for the definition of an angled area.
```

---

### SET_ROADS_IN_AREA

- **命名空间:** `PATHFIND`
- **Hash:** `0xBF1A602B5BA52FEE`
- **JHash:** `0xEBC7B918`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ROADS_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool nodeEnabled, bool unknown2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |
| `z2` | `float` | `float` | - |
| `nodeEnabled` | `BOOL` | `bool` | - |
| `unknown2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
When nodeEnabled is set to false, all nodes in the area get disabled.
`GET_VEHICLE_NODE_IS_SWITCHED_OFF` returns true afterwards.
If it's true, `GET_VEHICLE_NODE_IS_SWITCHED_OFF` returns false.
```

---

### SUPPRESS_AGITATION_EVENTS_NEXT_FRAME

- **命名空间:** `EVENT`
- **Hash:** `0x5F3B7749C112D552`
- **JHash:** `0x80340396`
- **Build:** `323`

**C# 签名:**
```csharp
void SUPPRESS_AGITATION_EVENTS_NEXT_FRAME()
```

**返回值:** `void` (Native: `void`)

---

### SUPPRESS_SHOCKING_EVENTS_NEXT_FRAME

- **命名空间:** `EVENT`
- **Hash:** `0x2F9A292AD0A3BD89`
- **JHash:** `0x4CC674B5`
- **Build:** `323`

**C# 签名:**
```csharp
void SUPPRESS_SHOCKING_EVENTS_NEXT_FRAME()
```

**返回值:** `void` (Native: `void`)

---

### SUPPRESS_SHOCKING_EVENT_TYPE_NEXT_FRAME

- **命名空间:** `EVENT`
- **Hash:** `0x3FD2EC8BF1F1CF30`
- **JHash:** `0xA0FDCB82`
- **Build:** `323`

**C# 签名:**
```csharp
void SUPPRESS_SHOCKING_EVENT_TYPE_NEXT_FRAME(int eventType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `eventType` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt
```

---

### UNBLOCK_DECISION_MAKER_EVENT

- **命名空间:** `EVENT`
- **Hash:** `0xD7CD9CF34F2C99E8`
- **JHash:** `0x62A3161D`
- **Build:** `323`

**C# 签名:**
```csharp
void UNBLOCK_DECISION_MAKER_EVENT(uint name, int eventType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `Hash` | `uint` | - |
| `eventType` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt
```

---

### UPDATE_NAVMESH_BLOCKING_OBJECT

- **命名空间:** `PATHFIND`
- **Hash:** `0x109E99373F290687`
- **JHash:** `0x4E9776D0`
- **Build:** `323`

**C# 签名:**
```csharp
void UPDATE_NAVMESH_BLOCKING_OBJECT(object p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, object p8)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `float` | `float` | - |
| `p5` | `float` | `float` | - |
| `p6` | `float` | `float` | - |
| `p7` | `float` | `float` | - |
| `p8` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---
