# TASK - Native 函数参考

> 命名空间: TASK, BRAIN

---

## 快速索引

| 函数名 | C# 签名 | 返回值 | 说明 |
|--------|---------|--------|------|
| `ADD_COVER_BLOCKING_AREA` | `void ADD_COVER_BLOCKING_AREA(float startX, float startY, float startZ, float endX, float endY, float endZ, bool blockObjects, bool blockVehicles, bool blockMap, bool blockPlayer)` | void | - |
| `ADD_COVER_POINT` | `int ADD_COVER_POINT(float x, float y, float z, float direction, int usage, int height, int arc, bool isPriority)` | int | - |
| `ADD_PATROL_ROUTE_LINK` | `void ADD_PATROL_ROUTE_LINK(int nodeId1, int nodeId2)` | void | - |
| `ADD_PATROL_ROUTE_NODE` | `void ADD_PATROL_ROUTE_NODE(int nodeId, string nodeType, float posX, float posY, float posZ, float headingX, float headingY, float headingZ, int duration)` | void | Example: <br>TASK::ADD_PATROL_ROUTE_NODE(2, "WORLD_HUMAN_GUARD_STAND", -193.4915, -2378.864990234375, 1... |
| `ADD_SCRIPTED_COVER_AREA` | `void ADD_SCRIPTED_COVER_AREA(float x, float y, float z, float radius)` | void | - |
| `ADD_SCRIPT_TO_RANDOM_PED` | `void ADD_SCRIPT_TO_RANDOM_PED(string name, uint model, float p2, float p3)` | void | BRAIN::ADD_SCRIPT_TO_RANDOM_PED("pb_prostitute", ${s_f_y_hooker_01}, 100, 0);<br><br>- Nacorpio<br><br>-----<br><br>Ha... |
| `ADD_VEHICLE_SUBTASK_ATTACK_COORD` | `void ADD_VEHICLE_SUBTASK_ATTACK_COORD(int ped, float x, float y, float z)` | void | x, y, z: offset in world coords from some entity. |
| `ADD_VEHICLE_SUBTASK_ATTACK_PED` | `void ADD_VEHICLE_SUBTASK_ATTACK_PED(int ped, int target)` | void | - |
| `ASSISTED_MOVEMENT_IS_ROUTE_LOADED` | `bool ASSISTED_MOVEMENT_IS_ROUTE_LOADED(string route)` | bool | - |
| `ASSISTED_MOVEMENT_OVERRIDE_LOAD_DISTANCE_THIS_FRAME` | `void ASSISTED_MOVEMENT_OVERRIDE_LOAD_DISTANCE_THIS_FRAME(float dist)` | void | - |
| `ASSISTED_MOVEMENT_REMOVE_ROUTE` | `void ASSISTED_MOVEMENT_REMOVE_ROUTE(string route)` | void | - |
| `ASSISTED_MOVEMENT_REQUEST_ROUTE` | `void ASSISTED_MOVEMENT_REQUEST_ROUTE(string route)` | void | Routes: "1_FIBStairs", "2_FIBStairs", "3_FIBStairs", "4_FIBStairs", "5_FIBStairs", "5_TowardsFire", ... |
| `ASSISTED_MOVEMENT_SET_ROUTE_PROPERTIES` | `void ASSISTED_MOVEMENT_SET_ROUTE_PROPERTIES(string route, int props)` | void | - |
| `CLEAR_DEFAULT_PRIMARY_TASK` | `void CLEAR_DEFAULT_PRIMARY_TASK(int ped)` | void | - |
| `CLEAR_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK` | `void CLEAR_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK(int ped)` | void | - |
| `CLEAR_PED_SCRIPT_TASK_IF_RUNNING_THREAT_RESPONSE_NON_TEMP_TASK` | `void CLEAR_PED_SCRIPT_TASK_IF_RUNNING_THREAT_RESPONSE_NON_TEMP_TASK(int ped)` | void | - |
| `CLEAR_PED_SECONDARY_TASK` | `void CLEAR_PED_SECONDARY_TASK(int ped)` | void | - |
| `CLEAR_PED_TASKS` | `void CLEAR_PED_TASKS(int ped)` | void | - |
| `CLEAR_PED_TASKS_IMMEDIATELY` | `void CLEAR_PED_TASKS_IMMEDIATELY(int ped)` | void | Immediately stops the pedestrian from whatever it's doing. They stop fighting, animations, etc. they... |
| `CLEAR_PRIMARY_VEHICLE_TASK` | `void CLEAR_PRIMARY_VEHICLE_TASK(int vehicle)` | void | This native is very useful when switching the player to a ped inside a vehicle that has a task assig... |
| `CLEAR_SEQUENCE_TASK` | `void CLEAR_SEQUENCE_TASK(ref int taskSequenceId)` | void | - |
| `CLEAR_VEHICLE_CRASH_TASK` | `void CLEAR_VEHICLE_CRASH_TASK(int vehicle)` | void | - |
| `CLOSE_PATROL_ROUTE` | `void CLOSE_PATROL_ROUTE()` | void | - |
| `CLOSE_SEQUENCE_TASK` | `void CLOSE_SEQUENCE_TASK(int taskSequenceId)` | void | - |
| `CONTROL_MOUNTED_WEAPON` | `bool CONTROL_MOUNTED_WEAPON(int ped)` | bool | Forces the ped to use the mounted weapon.<br>Returns false if task is not possible. |
| `CREATE_PATROL_ROUTE` | `void CREATE_PATROL_ROUTE()` | void | - |
| `DELETE_PATROL_ROUTE` | `void DELETE_PATROL_ROUTE(string patrolRoute)` | void | From the b617d scripts:<br><br>TASK::DELETE_PATROL_ROUTE("miss_merc0");<br>TASK::DELETE_PATROL_ROUTE("miss_me... |
| `DISABLE_SCRIPT_BRAIN_SET` | `void DISABLE_SCRIPT_BRAIN_SET(int brainSet)` | void | - |
| `DOES_SCENARIO_EXIST_IN_AREA` | `bool DOES_SCENARIO_EXIST_IN_AREA(float x, float y, float z, float radius, bool mustBeFree)` | bool | - |
| `DOES_SCENARIO_GROUP_EXIST` | `bool DOES_SCENARIO_GROUP_EXIST(string scenarioGroup)` | bool | Full list of scenario groups used in scripts by DurtyFree: https://github.com/DurtyFree/gta-v-data-d... |
| `DOES_SCENARIO_OF_TYPE_EXIST_IN_AREA` | `bool DOES_SCENARIO_OF_TYPE_EXIST_IN_AREA(float x, float y, float z, string scenarioName, float radius, bool mustBeFree)` | bool | - |
| `DOES_SCRIPTED_COVER_POINT_EXIST_AT_COORDS` | `bool DOES_SCRIPTED_COVER_POINT_EXIST_AT_COORDS(float x, float y, float z)` | bool | Checks if there is a cover point at position |
| `ENABLE_SCRIPT_BRAIN_SET` | `void ENABLE_SCRIPT_BRAIN_SET(int brainSet)` | void | - |
| `GET_ACTIVE_VEHICLE_MISSION_TYPE` | `int GET_ACTIVE_VEHICLE_MISSION_TYPE(int vehicle)` | int | https://alloc8or.re/gta5/doc/enums/eVehicleMissionType.txt |
| `GET_CLIP_SET_FOR_SCRIPTED_GUN_TASK` | `string GET_CLIP_SET_FOR_SCRIPTED_GUN_TASK(int gunTaskType)` | string | - |
| `GET_IS_TASK_ACTIVE` | `bool GET_IS_TASK_ACTIVE(int ped, int taskIndex)` | bool | Task index enum: https://alloc8or.re/gta5/doc/enums/eTaskTypeIndex.txt |
| `GET_IS_WAYPOINT_RECORDING_LOADED` | `bool GET_IS_WAYPOINT_RECORDING_LOADED(string name)` | bool | Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/ma... |
| `GET_NAVMESH_ROUTE_DISTANCE_REMAINING` | `int GET_NAVMESH_ROUTE_DISTANCE_REMAINING(int ped, ref float distanceRemaining, ref bool isPathReady)` | int | Looks like the last parameter returns true if the path has been calculated, while the first returns ... |
| `GET_NAVMESH_ROUTE_RESULT` | `int GET_NAVMESH_ROUTE_RESULT(int ped)` | int | See GET_NAVMESH_ROUTE_DISTANCE_REMAINING for more details. |
| `GET_PATROL_TASK_INFO` | `bool GET_PATROL_TASK_INFO(int ped, ref int timeLeftAtNode, ref int nodeId)` | bool | - |
| `GET_PED_DESIRED_MOVE_BLEND_RATIO` | `float GET_PED_DESIRED_MOVE_BLEND_RATIO(int ped)` | float | - |
| `GET_PED_WAYPOINT_DISTANCE` | `float GET_PED_WAYPOINT_DISTANCE(object p0)` | float | - |
| `GET_PED_WAYPOINT_PROGRESS` | `int GET_PED_WAYPOINT_PROGRESS(int ped)` | int | - |
| `GET_PHONE_GESTURE_ANIM_CURRENT_TIME` | `float GET_PHONE_GESTURE_ANIM_CURRENT_TIME(int ped)` | float | - |
| `GET_PHONE_GESTURE_ANIM_TOTAL_TIME` | `float GET_PHONE_GESTURE_ANIM_TOTAL_TIME(int ped)` | float | - |
| `GET_SCRIPTED_COVER_POINT_COORDS` | `Vector3 GET_SCRIPTED_COVER_POINT_COORDS(int coverpoint)` | Vector3 | - |
| `GET_SCRIPT_TASK_STATUS` | `int GET_SCRIPT_TASK_STATUS(int ped, uint taskHash)` | int | Gets the status of a script-assigned task.<br>taskHash: https://alloc8or.re/gta5/doc/enums/eScriptTaskH... |
| `GET_SEQUENCE_PROGRESS` | `int GET_SEQUENCE_PROGRESS(int ped)` | int | returned values:<br>0 to 7 = task that's currently in progress, 0 meaning the first one.<br>-1 no task seq... |
| `GET_TASK_MOVE_NETWORK_EVENT` | `bool GET_TASK_MOVE_NETWORK_EVENT(int ped, string eventName)` | bool | - |
| `GET_TASK_MOVE_NETWORK_SIGNAL_BOOL` | `bool GET_TASK_MOVE_NETWORK_SIGNAL_BOOL(int ped, string signalName)` | bool | - |
| `GET_TASK_MOVE_NETWORK_SIGNAL_FLOAT` | `float GET_TASK_MOVE_NETWORK_SIGNAL_FLOAT(int ped, string signalName)` | float | - |
| `GET_TASK_MOVE_NETWORK_STATE` | `string GET_TASK_MOVE_NETWORK_STATE(int ped)` | string | - |
| `GET_TASK_RAPPEL_DOWN_WALL_STATE` | `int GET_TASK_RAPPEL_DOWN_WALL_STATE(int ped)` | int | - |
| `GET_VEHICLE_WAYPOINT_PROGRESS` | `int GET_VEHICLE_WAYPOINT_PROGRESS(int vehicle)` | int | - |
| `GET_VEHICLE_WAYPOINT_TARGET_POINT` | `int GET_VEHICLE_WAYPOINT_TARGET_POINT(int vehicle)` | int | - |
| `GET_WAYPOINT_DISTANCE_ALONG_ROUTE` | `float GET_WAYPOINT_DISTANCE_ALONG_ROUTE(string name, int point)` | float | - |
| `IS_CONTROLLED_VEHICLE_UNABLE_TO_GET_TO_ROAD` | `bool IS_CONTROLLED_VEHICLE_UNABLE_TO_GET_TO_ROAD(int ped)` | bool | - |
| `IS_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK` | `bool IS_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK(int ped)` | bool | - |
| `IS_MOUNTED_WEAPON_TASK_UNDERNEATH_DRIVING_TASK` | `bool IS_MOUNTED_WEAPON_TASK_UNDERNEATH_DRIVING_TASK(int ped)` | bool | - |
| `IS_MOVE_BLEND_RATIO_RUNNING` | `bool IS_MOVE_BLEND_RATIO_RUNNING(int ped)` | bool | - |
| `IS_MOVE_BLEND_RATIO_SPRINTING` | `bool IS_MOVE_BLEND_RATIO_SPRINTING(int ped)` | bool | - |
| `IS_MOVE_BLEND_RATIO_STILL` | `bool IS_MOVE_BLEND_RATIO_STILL(int ped)` | bool | - |
| `IS_MOVE_BLEND_RATIO_WALKING` | `bool IS_MOVE_BLEND_RATIO_WALKING(int ped)` | bool | - |
| `IS_OBJECT_WITHIN_BRAIN_ACTIVATION_RANGE` | `bool IS_OBJECT_WITHIN_BRAIN_ACTIVATION_RANGE(int object)` | bool | - |
| `IS_PED_ACTIVE_IN_SCENARIO` | `bool IS_PED_ACTIVE_IN_SCENARIO(int ped)` | bool | - |
| `IS_PED_BEING_ARRESTED` | `bool IS_PED_BEING_ARRESTED(int ped)` | bool | This function is hard-coded to always return 0. |
| `IS_PED_CUFFED` | `bool IS_PED_CUFFED(int ped)` | bool | - |
| `IS_PED_GETTING_UP` | `bool IS_PED_GETTING_UP(int ped)` | bool | - |
| `IS_PED_IN_WRITHE` | `bool IS_PED_IN_WRITHE(int ped)` | bool | This native checks if a ped is on the ground, in pain from a (gunshot) wound.<br>Returns `true` if the ... |
| `IS_PED_PLAYING_BASE_CLIP_IN_SCENARIO` | `bool IS_PED_PLAYING_BASE_CLIP_IN_SCENARIO(int ped)` | bool | Used only once (am_mp_property_int)<br><br>ped was PLAYER_PED_ID()<br><br>Related to CTaskAmbientClips. |
| `IS_PED_RUNNING` | `bool IS_PED_RUNNING(int ped)` | bool | - |
| `IS_PED_RUNNING_ARREST_TASK` | `bool IS_PED_RUNNING_ARREST_TASK(int ped)` | bool | - |
| `IS_PED_SPRINTING` | `bool IS_PED_SPRINTING(int ped)` | bool | - |
| `IS_PED_STILL` | `bool IS_PED_STILL(int ped)` | bool | - |
| `IS_PED_STRAFING` | `bool IS_PED_STRAFING(int ped)` | bool | - |
| `IS_PED_WALKING` | `bool IS_PED_WALKING(int ped)` | bool | - |
| `IS_PLAYING_PHONE_GESTURE_ANIM` | `bool IS_PLAYING_PHONE_GESTURE_ANIM(int ped)` | bool | - |
| `IS_SCENARIO_GROUP_ENABLED` | `bool IS_SCENARIO_GROUP_ENABLED(string scenarioGroup)` | bool | Full list of scenario groups used in scripts by DurtyFree: https://github.com/DurtyFree/gta-v-data-d... |
| `IS_SCENARIO_OCCUPIED` | `bool IS_SCENARIO_OCCUPIED(float x, float y, float z, float maxRange, bool onlyUsersActuallyAtScenario)` | bool | - |
| `IS_SCENARIO_TYPE_ENABLED` | `bool IS_SCENARIO_TYPE_ENABLED(string scenarioType)` | bool | Full list of scenario types used in scripts by DurtyFree: https://github.com/DurtyFree/gta-v-data-du... |
| `IS_TASK_MOVE_NETWORK_ACTIVE` | `bool IS_TASK_MOVE_NETWORK_ACTIVE(int ped)` | bool | - |
| `IS_TASK_MOVE_NETWORK_READY_FOR_TRANSITION` | `bool IS_TASK_MOVE_NETWORK_READY_FOR_TRANSITION(int ped)` | bool | - |
| `IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_PED` | `bool IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_PED(int ped)` | bool | - |
| `IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_VEHICLE` | `bool IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_VEHICLE(int vehicle)` | bool | - |
| `IS_WORLD_POINT_WITHIN_BRAIN_ACTIVATION_RANGE` | `bool IS_WORLD_POINT_WITHIN_BRAIN_ACTIVATION_RANGE()` | bool | Gets whether the world point the calling script is registered to is within desired range of the play... |
| `OPEN_PATROL_ROUTE` | `void OPEN_PATROL_ROUTE(string patrolRoute)` | void |  patrolRoutes found in the b617d scripts:<br> "miss_Ass0",<br> "miss_Ass1",<br> "miss_Ass2",<br> "miss_Ass3",<br> "... |
| `OPEN_SEQUENCE_TASK` | `void OPEN_SEQUENCE_TASK(ref int taskSequenceId)` | void | - |
| `PED_HAS_USE_SCENARIO_TASK` | `bool PED_HAS_USE_SCENARIO_TASK(int ped)` | bool | - |
| `PLAY_ANIM_ON_RUNNING_SCENARIO` | `void PLAY_ANIM_ON_RUNNING_SCENARIO(int ped, string animDict, string animName)` | void | Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-... |
| `PLAY_ENTITY_SCRIPTED_ANIM` | `void PLAY_ENTITY_SCRIPTED_ANIM(int entity, ref int priorityLowData, ref int priorityMidData, ref int priorityHighData, float blendInDelta, float blendOutDelta)` | void | - |
| `REACTIVATE_ALL_OBJECT_BRAINS_THAT_ARE_WAITING_TILL_OUT_OF_RANGE` | `void REACTIVATE_ALL_OBJECT_BRAINS_THAT_ARE_WAITING_TILL_OUT_OF_RANGE()` | void | - |
| `REACTIVATE_ALL_WORLD_BRAINS_THAT_ARE_WAITING_TILL_OUT_OF_RANGE` | `void REACTIVATE_ALL_WORLD_BRAINS_THAT_ARE_WAITING_TILL_OUT_OF_RANGE()` | void | - |
| `REACTIVATE_NAMED_OBJECT_BRAINS_WAITING_TILL_OUT_OF_RANGE` | `void REACTIVATE_NAMED_OBJECT_BRAINS_WAITING_TILL_OUT_OF_RANGE(string scriptName)` | void | Looks like a cousin of above function _6D6840CEE8845831 as it was found among them. Must be similar<br>... |
| `REACTIVATE_NAMED_WORLD_BRAINS_WAITING_TILL_OUT_OF_RANGE` | `void REACTIVATE_NAMED_WORLD_BRAINS_WAITING_TILL_OUT_OF_RANGE(string scriptName)` | void | Possible values:<br><br>act_cinema<br>am_mp_carwash_launch<br>am_mp_carwash_control<br>am_mp_property_ext<br>chop<br>fair... |
| `REGISTER_OBJECT_SCRIPT_BRAIN` | `void REGISTER_OBJECT_SCRIPT_BRAIN(string scriptName, uint modelHash, int p2, float activationRange, int p4, int p5)` | void | Registers a script for any object with a specific model hash.<br><br>BRAIN::REGISTER_OBJECT_SCRIPT_BRAIN("... |
| `REGISTER_WORLD_POINT_SCRIPT_BRAIN` | `void REGISTER_WORLD_POINT_SCRIPT_BRAIN(string scriptName, float activationRange, int p2)` | void | - |
| `REMOVE_ALL_COVER_BLOCKING_AREAS` | `void REMOVE_ALL_COVER_BLOCKING_AREAS()` | void | - |
| `REMOVE_COVER_BLOCKING_AREAS_AT_POSITION` | `void REMOVE_COVER_BLOCKING_AREAS_AT_POSITION(float x, float y, float z)` | void | - |
| `REMOVE_COVER_POINT` | `void REMOVE_COVER_POINT(int coverpoint)` | void | - |
| `REMOVE_SPECIFIC_COVER_BLOCKING_AREAS` | `void REMOVE_SPECIFIC_COVER_BLOCKING_AREAS(float startX, float startY, float startZ, float endX, float endY, float endZ, bool blockObjects, bool blockVehicles, bool blockMap, bool blockPlayer)` | void | - |
| `REMOVE_WAYPOINT_RECORDING` | `void REMOVE_WAYPOINT_RECORDING(string name)` | void | Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/ma... |
| `REQUEST_TASK_MOVE_NETWORK_STATE_TRANSITION` | `bool REQUEST_TASK_MOVE_NETWORK_STATE_TRANSITION(int ped, string name)` | bool | - |
| `REQUEST_WAYPOINT_RECORDING` | `void REQUEST_WAYPOINT_RECORDING(string name)` | void | Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/ma... |
| `RESET_EXCLUSIVE_SCENARIO_GROUP` | `void RESET_EXCLUSIVE_SCENARIO_GROUP()` | void | - |
| `RESET_SCENARIO_GROUPS_ENABLED` | `void RESET_SCENARIO_GROUPS_ENABLED()` | void | - |
| `RESET_SCENARIO_TYPES_ENABLED` | `void RESET_SCENARIO_TYPES_ENABLED()` | void | - |
| `SET_ANIM_LOOPED` | `void SET_ANIM_LOOPED(int entity, bool looped, int priority, bool secondary)` | void | - |
| `SET_ANIM_PHASE` | `void SET_ANIM_PHASE(int entity, float phase, int priority, bool secondary)` | void | - |
| `SET_ANIM_RATE` | `void SET_ANIM_RATE(int entity, float rate, int priority, bool secondary)` | void | - |
| `SET_ANIM_WEIGHT` | `void SET_ANIM_WEIGHT(int entity, float weight, int priority, int index, bool secondary)` | void | - |
| `SET_DRIVEBY_TASK_TARGET` | `void SET_DRIVEBY_TASK_TARGET(int shootingPed, int targetPed, int targetVehicle, float x, float y, float z)` | void | For p1 & p2 (Ped, Vehicle). I could be wrong, as the only time this native is called in scripts is o... |
| `SET_DRIVE_TASK_CRUISE_SPEED` | `void SET_DRIVE_TASK_CRUISE_SPEED(int driver, float cruiseSpeed)` | void | - |
| `SET_DRIVE_TASK_DRIVING_STYLE` | `void SET_DRIVE_TASK_DRIVING_STYLE(int ped, int drivingStyle)` | void | This native is used to set the driving style for specific ped.<br><br>Driving styles id seems to be:<br>78646... |
| `SET_DRIVE_TASK_MAX_CRUISE_SPEED` | `void SET_DRIVE_TASK_MAX_CRUISE_SPEED(int ped, float speed, bool updateBaseTask)` | void | - |
| `SET_EXCLUSIVE_SCENARIO_GROUP` | `void SET_EXCLUSIVE_SCENARIO_GROUP(string scenarioGroup)` | void | Full list of scenario groups used in scripts by DurtyFree: https://github.com/DurtyFree/gta-v-data-d... |
| `SET_EXPECTED_CLONE_NEXT_TASK_MOVE_NETWORK_STATE` | `bool SET_EXPECTED_CLONE_NEXT_TASK_MOVE_NETWORK_STATE(int ped, string state)` | bool | Used only once in the scripts (fm_mission_controller) like so:<br><br>TASK::SET_EXPECTED_CLONE_NEXT_TASK_M... |
| `SET_GLOBAL_MIN_BIRD_FLIGHT_HEIGHT` | `void SET_GLOBAL_MIN_BIRD_FLIGHT_HEIGHT(float height)` | void | Needs to be looped! And yes, it does work and is not a hash collision.<br>Birds will try to reach the g... |
| `SET_HIGH_FALL_TASK` | `void SET_HIGH_FALL_TASK(int ped, int minTime, int maxTime, int entryType)` | void | Makes the ped ragdoll like when falling from a great height |
| `SET_MOUNTED_WEAPON_TARGET` | `void SET_MOUNTED_WEAPON_TARGET(int shootingPed, int targetPed, int targetVehicle, float x, float y, float z, int taskMode, bool ignoreTargetVehDeadCheck)` | void | Note: Look in decompiled scripts and the times that p1 and p2 aren't 0. They are filled with vars. I... |
| `SET_NEXT_DESIRED_MOVE_STATE` | `void SET_NEXT_DESIRED_MOVE_STATE(float nextMoveState)` | void | This native does absolutely nothing, just a nullsub<br><br>R* Comment:<br>SET_NEXT_DESIRED_MOVE_STATE - Funct... |
| `SET_PARACHUTE_TASK_TARGET` | `void SET_PARACHUTE_TASK_TARGET(int ped, float x, float y, float z)` | void | - |
| `SET_PARACHUTE_TASK_THRUST` | `void SET_PARACHUTE_TASK_THRUST(int ped, float thrust)` | void | - |
| `SET_PED_CAN_PLAY_AMBIENT_IDLES` | `void SET_PED_CAN_PLAY_AMBIENT_IDLES(int ped, bool blockIdleClips, bool removeIdleClipIfPlaying)` | void | Appears only in fm_mission_controller and used only 3 times.<br><br>ped was always PLAYER_PED_ID()<br>p1 was ... |
| `SET_PED_DESIRED_MOVE_BLEND_RATIO` | `void SET_PED_DESIRED_MOVE_BLEND_RATIO(int ped, float newMoveBlendRatio)` | void | - |
| `SET_PED_PATH_AVOID_FIRE` | `void SET_PED_PATH_AVOID_FIRE(int ped, bool avoidFire)` | void | - |
| `SET_PED_PATH_CAN_DROP_FROM_HEIGHT` | `void SET_PED_PATH_CAN_DROP_FROM_HEIGHT(int ped, bool Toggle)` | void | - |
| `SET_PED_PATH_CAN_USE_CLIMBOVERS` | `void SET_PED_PATH_CAN_USE_CLIMBOVERS(int ped, bool Toggle)` | void | - |
| `SET_PED_PATH_CAN_USE_LADDERS` | `void SET_PED_PATH_CAN_USE_LADDERS(int ped, bool Toggle)` | void | - |
| `SET_PED_PATH_CLIMB_COST_MODIFIER` | `void SET_PED_PATH_CLIMB_COST_MODIFIER(int ped, float modifier)` | void | Default modifier is 1.0, minimum is 0.0 and maximum is 10.0. |
| `SET_PED_PATH_MAY_ENTER_WATER` | `void SET_PED_PATH_MAY_ENTER_WATER(int ped, bool mayEnterWater)` | void | - |
| `SET_PED_PATH_PREFER_TO_AVOID_WATER` | `void SET_PED_PATH_PREFER_TO_AVOID_WATER(int ped, bool avoidWater)` | void | - |
| `SET_PED_WAYPOINT_PROGRESS` | `void SET_PED_WAYPOINT_PROGRESS(int ped, int progress)` | void | - |
| `SET_PED_WAYPOINT_ROUTE_OFFSET` | `bool SET_PED_WAYPOINT_ROUTE_OFFSET(int ped, float x, float y, float z)` | bool | - |
| `SET_SCENARIO_GROUP_ENABLED` | `void SET_SCENARIO_GROUP_ENABLED(string scenarioGroup, bool enabled)` | void | Full list of scenario groups used in scripts by DurtyFree: https://github.com/DurtyFree/gta-v-data-d... |
| `SET_SCENARIO_TYPE_ENABLED` | `void SET_SCENARIO_TYPE_ENABLED(string scenarioType, bool toggle)` | void | Full list of scenario types used in scripts by DurtyFree: https://github.com/DurtyFree/gta-v-data-du... |
| `SET_SEQUENCE_PREVENT_MIGRATION` | `void SET_SEQUENCE_PREVENT_MIGRATION(int taskSequenceId)` | void | - |
| `SET_SEQUENCE_TO_REPEAT` | `void SET_SEQUENCE_TO_REPEAT(int taskSequenceId, bool repeat)` | void | - |
| `SET_TASK_MOVE_NETWORK_ANIM_SET` | `void SET_TASK_MOVE_NETWORK_ANIM_SET(int ped, uint clipSet, uint variableClipSet)` | void | - |
| `SET_TASK_MOVE_NETWORK_ENABLE_COLLISION_ON_NETWORK_CLONE_WHEN_FIXED` | `bool SET_TASK_MOVE_NETWORK_ENABLE_COLLISION_ON_NETWORK_CLONE_WHEN_FIXED(int ped, bool enable)` | bool | Doesn't actually return anything. |
| `SET_TASK_MOVE_NETWORK_SIGNAL_BOOL` | `void SET_TASK_MOVE_NETWORK_SIGNAL_BOOL(int ped, string signalName, bool value)` | void | - |
| `SET_TASK_MOVE_NETWORK_SIGNAL_FLOAT` | `void SET_TASK_MOVE_NETWORK_SIGNAL_FLOAT(int ped, string signalName, float value)` | void | signalName - "Phase", "Wobble", "x_axis","y_axis","introphase","speed".<br>p2 - From what i can see it ... |
| `SET_TASK_MOVE_NETWORK_SIGNAL_FLOAT_LERP_RATE` | `void SET_TASK_MOVE_NETWORK_SIGNAL_FLOAT_LERP_RATE(int ped, string signalName, float value)` | void | - |
| `SET_TASK_MOVE_NETWORK_SIGNAL_LOCAL_FLOAT` | `void SET_TASK_MOVE_NETWORK_SIGNAL_LOCAL_FLOAT(int ped, string signalName, float value)` | void | - |
| `SET_TASK_VEHICLE_CHASE_BEHAVIOR_FLAG` | `void SET_TASK_VEHICLE_CHASE_BEHAVIOR_FLAG(int ped, int flag, bool set)` | void | Flag 8: Medium-aggressive boxing tactic with a bit of PIT<br>Flag 1: Aggressive ramming of suspect<br>Flag... |
| `SET_TASK_VEHICLE_CHASE_IDEAL_PURSUIT_DISTANCE` | `void SET_TASK_VEHICLE_CHASE_IDEAL_PURSUIT_DISTANCE(int ped, float distance)` | void | - |
| `STOP_ANIM_PLAYBACK` | `void STOP_ANIM_PLAYBACK(int entity, int priority, bool secondary)` | void | Looks like p1 may be a flag, still need to do some research, though. |
| `STOP_ANIM_TASK` | `void STOP_ANIM_TASK(int entity, string animDictionary, string animationName, float blendDelta)` | void | Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-... |
| `TASK_ACHIEVE_HEADING` | `void TASK_ACHIEVE_HEADING(int ped, float heading, int timeout)` | void | Makes the specified ped achieve the specified heading.<br><br>pedHandle: The handle of the ped to assign t... |
| `TASK_AGITATED_ACTION_CONFRONT_RESPONSE` | `void TASK_AGITATED_ACTION_CONFRONT_RESPONSE(int ped, int ped2)` | void | - |
| `TASK_AIM_GUN_AT_COORD` | `void TASK_AIM_GUN_AT_COORD(int ped, float x, float y, float z, int time, bool instantBlendToAim, bool playAnimIntro)` | void | - |
| `TASK_AIM_GUN_AT_ENTITY` | `void TASK_AIM_GUN_AT_ENTITY(int ped, int entity, int duration, bool instantBlendToAim)` | void | duration: the amount of time in milliseconds to do the task.  -1 will keep the task going until eith... |
| `TASK_AIM_GUN_SCRIPTED` | `void TASK_AIM_GUN_SCRIPTED(int ped, uint scriptTask, bool disableBlockingClip, bool instantBlendToAim)` | void | - |
| `TASK_AIM_GUN_SCRIPTED_WITH_TARGET` | `void TASK_AIM_GUN_SCRIPTED_WITH_TARGET(int ped, int target, float x, float y, float z, int gunTaskType, bool disableBlockingClip, bool forceAim)` | void | - |
| `TASK_ARREST_PED` | `void TASK_ARREST_PED(int ped, int target)` | void | Example from "me_amanda1.ysc.c4":<br>TASK::TASK_ARREST_PED(l_19F /* This is a Ped */ , PLAYER::PLAYER_P... |
| `TASK_BOAT_MISSION` | `void TASK_BOAT_MISSION(int pedDriver, int vehicle, int targetVehicle, int targetPed, float x, float y, float z, int mission, float maxSpeed, int drivingStyle, float targetReached, object boatFlags)` | void | You need to call PED::SET_BLOCKING_OF_NON_TEMPORARY_EVENTS after TASK_BOAT_MISSION in order for the ... |
| `TASK_CHAT_TO_PED` | `void TASK_CHAT_TO_PED(int ped, int target, int flags, float goToLocationX, float goToLocationY, float goToLocationZ, float headingDegs, float idleTime)` | void | p2 tend to be 16, 17 or 1<br>p3 to p7 tend to be 0.0 |
| `TASK_CLEAR_DEFENSIVE_AREA` | `void TASK_CLEAR_DEFENSIVE_AREA(int ped)` | void | - |
| `TASK_CLEAR_LOOK_AT` | `void TASK_CLEAR_LOOK_AT(int ped)` | void | - |
| `TASK_CLIMB` | `void TASK_CLIMB(int ped, bool usePlayerLaunchForce)` | void | Climbs or vaults the nearest thing.<br>usePlayerLaunchForce is unused. |
| `TASK_CLIMB_LADDER` | `void TASK_CLIMB_LADDER(int ped, bool fast)` | void | - |
| `TASK_COMBAT_HATED_TARGETS_AROUND_PED` | `void TASK_COMBAT_HATED_TARGETS_AROUND_PED(int ped, float radius, int combatFlags)` | void | Despite its name, it only attacks ONE hated target. The one closest hated target.<br><br>p2 seems to be al... |
| `TASK_COMBAT_HATED_TARGETS_AROUND_PED_TIMED` | `void TASK_COMBAT_HATED_TARGETS_AROUND_PED_TIMED(int ped, float radius, int time, int combatFlags)` | void | - |
| `TASK_COMBAT_HATED_TARGETS_IN_AREA` | `void TASK_COMBAT_HATED_TARGETS_IN_AREA(int ped, float x, float y, float z, float radius, int combatFlags)` | void | Despite its name, it only attacks ONE hated target. The one closest to the specified position. |
| `TASK_COMBAT_PED` | `void TASK_COMBAT_PED(int ped, int targetPed, int combatFlags, int threatResponseFlags)` | void | Makes the specified ped attack the target ped.<br>p2 should be 0<br>p3 should be 16 |
| `TASK_COMBAT_PED_TIMED` | `void TASK_COMBAT_PED_TIMED(int ped, int target, int time, int flags)` | void | - |
| `TASK_COWER` | `void TASK_COWER(int ped, int duration)` | void | - |
| `TASK_DRIVE_BY` | `void TASK_DRIVE_BY(int driverPed, int targetPed, int targetVehicle, float targetX, float targetY, float targetZ, float distanceToShoot, int pedAccuracy, bool pushUnderneathDrivingTaskIfDriving, uint firingPattern)` | void | Example:<br><br>TASK::TASK_DRIVE_BY(l_467[1/*22*/], PLAYER::PLAYER_PED_ID(), 0, 0.0, 0.0, 2.0, 300.0, 100,... |
| `TASK_ENTER_VEHICLE` | `void TASK_ENTER_VEHICLE(int ped, int vehicle, int timeout, int seat, float speed, int flag, string overrideEntryClipsetName)` | void | speed 1.0 = walk, 2.0 = run<br>p5 1 = normal, 3 = teleport to vehicle, 16 = teleport directly into vehi... |
| `TASK_EVERYONE_LEAVE_VEHICLE` | `void TASK_EVERYONE_LEAVE_VEHICLE(int vehicle)` | void | - |
| `TASK_EXIT_COVER` | `void TASK_EXIT_COVER(int ped, int exitType, float x, float y, float z)` | void | p1 is 1, 2, or 3 in scripts |
| `TASK_EXTEND_ROUTE` | `void TASK_EXTEND_ROUTE(float x, float y, float z)` | void | MulleKD19: Adds a new point to the current point route. Call TASK_FLUSH_ROUTE before the first call ... |
| `TASK_FLUSH_ROUTE` | `void TASK_FLUSH_ROUTE()` | void | MulleKD19: Clears the current point route. Call this before TASK_EXTEND_ROUTE and TASK_FOLLOW_POINT_... |
| `TASK_FOLLOW_NAV_MESH_TO_COORD` | `void TASK_FOLLOW_NAV_MESH_TO_COORD(int ped, float x, float y, float z, float moveBlendRatio, int time, float targetRadius, int flags, float targetHeading)` | void | If no timeout, set timeout to -1. |
| `TASK_FOLLOW_NAV_MESH_TO_COORD_ADVANCED` | `void TASK_FOLLOW_NAV_MESH_TO_COORD_ADVANCED(int ped, float x, float y, float z, float moveBlendRatio, int time, float targetRadius, int flags, float slideToCoordHeading, float maxSlopeNavigable, float clampMaxSearchDistance, float targetHeading)` | void | - |
| `TASK_FOLLOW_POINT_ROUTE` | `void TASK_FOLLOW_POINT_ROUTE(int ped, float speed, int mode)` | void | MulleKD19: Makes the ped go on the created point route.<br><br>ped: The ped to give the task to.<br>speed: Th... |
| `TASK_FOLLOW_TO_OFFSET_OF_ENTITY` | `void TASK_FOLLOW_TO_OFFSET_OF_ENTITY(int ped, int entity, float offsetX, float offsetY, float offsetZ, float movementSpeed, int timeout, float stoppingRange, bool persistFollowing)` | void | p6 always -1<br>p7 always 10.0<br>p8 always 1 |
| `TASK_FOLLOW_WAYPOINT_RECORDING` | `void TASK_FOLLOW_WAYPOINT_RECORDING(int ped, string name, int p2, int p3, int p4)` | void | - |
| `TASK_FORCE_MOTION_STATE` | `void TASK_FORCE_MOTION_STATE(int ped, uint state, bool forceRestart)` | void | p2 always false<br><br>[30/03/2017] ins1de :<br><br>See FORCE_PED_MOTION_STATE |
| `TASK_GET_OFF_BOAT` | `void TASK_GET_OFF_BOAT(int ped, int boat)` | void | - |
| `TASK_GOTO_ENTITY_AIMING` | `void TASK_GOTO_ENTITY_AIMING(int ped, int target, float distanceToStopAt, float StartAimingDist)` | void | eg<br><br> TASK::TASK_GOTO_ENTITY_AIMING(v_2, PLAYER::PLAYER_PED_ID(), 5.0, 25.0);<br><br>ped = Ped you want to ... |
| `TASK_GOTO_ENTITY_OFFSET` | `void TASK_GOTO_ENTITY_OFFSET(int ped, int entity, int time, float seekRadius, float seekAngleDeg, float moveBlendRatio, int gotoEntityOffsetFlags)` | void | enum ESEEK_ENTITY_OFFSET_FLAGS<br>{<br>	ESEEK_OFFSET_ORIENTATES_WITH_ENTITY = 0x01,<br>	ESEEK_KEEP_TO_PAVEMEN... |
| `TASK_GOTO_ENTITY_OFFSET_XY` | `void TASK_GOTO_ENTITY_OFFSET_XY(int ped, int entity, int duration, float targetRadius, float offsetX, float offsetY, float moveBlendRatio, int gotoEntityOffsetFlags)` | void | - |
| `TASK_GO_STRAIGHT_TO_COORD` | `void TASK_GO_STRAIGHT_TO_COORD(int ped, float x, float y, float z, float speed, int timeout, float targetHeading, float distanceToSlide)` | void | - |
| `TASK_GO_STRAIGHT_TO_COORD_RELATIVE_TO_ENTITY` | `void TASK_GO_STRAIGHT_TO_COORD_RELATIVE_TO_ENTITY(int ped, int entity, float x, float y, float z, float moveBlendRatio, int time)` | void | - |
| `TASK_GO_TO_COORD_AND_AIM_AT_HATED_ENTITIES_NEAR_COORD` | `void TASK_GO_TO_COORD_AND_AIM_AT_HATED_ENTITIES_NEAR_COORD(int pedHandle, float goToLocationX, float goToLocationY, float goToLocationZ, float focusLocationX, float focusLocationY, float focusLocationZ, float speed, bool shootAtEnemies, float distanceToStopAt, float noRoadsDistance, bool useNavMesh, int navFlags, int taskFlags, uint firingPattern)` | void | The ped will walk or run towards goToLocation, aiming towards goToLocation or focusLocation (dependi... |
| `TASK_GO_TO_COORD_ANY_MEANS` | `void TASK_GO_TO_COORD_ANY_MEANS(int ped, float x, float y, float z, float moveBlendRatio, int vehicle, bool useLongRangeVehiclePathing, int drivingFlags, float maxRangeToShootTargets)` | void | example from fm_mission_controller<br><br>TASK::TASK_GO_TO_COORD_ANY_MEANS(l_649, sub_f7e86(-1, 0), 1.0, 0... |
| `TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS` | `void TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS(int ped, float x, float y, float z, float moveBlendRatio, int vehicle, bool useLongRangeVehiclePathing, int drivingFlags, float maxRangeToShootTargets, float extraVehToTargetDistToPreferVehicle, float driveStraightLineDistance, int extraFlags, float warpTimerMS)` | void | - |
| `TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS_WITH_CRUISE_SPEED` | `void TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS_WITH_CRUISE_SPEED(int ped, float x, float y, float z, float moveBlendRatio, int vehicle, bool useLongRangeVehiclePathing, int drivingFlags, float maxRangeToShootTargets, float extraVehToTargetDistToPreferVehicle, float driveStraightLineDistance, int extraFlags, float cruiseSpeed, float targetArriveDist)` | void | - |
| `TASK_GO_TO_COORD_WHILE_AIMING_AT_COORD` | `void TASK_GO_TO_COORD_WHILE_AIMING_AT_COORD(int ped, float x, float y, float z, float aimAtX, float aimAtY, float aimAtZ, float moveBlendRatio, bool shoot, float targetRadius, float slowDistance, bool useNavMesh, int navFlags, bool instantBlendToAim, uint firingPattern)` | void | movement_speed: mostly 2f, but also 1/1.2f, etc.<br>p8: always false<br>p9: 2f<br>p10: 0.5f<br>p11: true<br>p12: 0 ... |
| `TASK_GO_TO_COORD_WHILE_AIMING_AT_ENTITY` | `void TASK_GO_TO_COORD_WHILE_AIMING_AT_ENTITY(int ped, float x, float y, float z, int aimAtID, float moveBlendRatio, bool shoot, float targetRadius, float slowDistance, bool useNavMesh, int navFlags, bool instantBlendToAim, uint firingPattern, int time)` | void | - |
| `TASK_GO_TO_ENTITY` | `void TASK_GO_TO_ENTITY(int entity, int target, int duration, float distance, float moveBlendRatio, float slowDownDistance, int flags)` | void | The entity will move towards the target until time is over (duration) or get in target's range (dist... |
| `TASK_GO_TO_ENTITY_WHILE_AIMING_AT_COORD` | `void TASK_GO_TO_ENTITY_WHILE_AIMING_AT_COORD(int ped, int entity, float aimX, float aimY, float aimZ, float moveBlendRatio, bool shoot, float targetRadius, float slowDistance, bool useNavMesh, bool instantBlendToAim, uint firingPattern)` | void | - |
| `TASK_GO_TO_ENTITY_WHILE_AIMING_AT_ENTITY` | `void TASK_GO_TO_ENTITY_WHILE_AIMING_AT_ENTITY(int ped, int entityToWalkTo, int entityToAimAt, float speed, bool shootatEntity, float targetRadius, float slowDistance, bool useNavMesh, bool instantBlendToAim, uint firingPattern)` | void | shootatEntity:<br>If true, peds will shoot at Entity till it is dead.<br>If false, peds will just walk til... |
| `TASK_GUARD_ASSIGNED_DEFENSIVE_AREA` | `void TASK_GUARD_ASSIGNED_DEFENSIVE_AREA(int ped, float x, float y, float z, float heading, float maxPatrolProximity, int timer)` | void | - |
| `TASK_GUARD_CURRENT_POSITION` | `void TASK_GUARD_CURRENT_POSITION(int ped, float maxPatrolProximity, float defensiveAreaRadius, bool setDefensiveArea)` | void | From re_prisonvanbreak:<br><br>TASK::TASK_GUARD_CURRENT_POSITION(l_DD, 35.0, 35.0, 1); |
| `TASK_GUARD_SPHERE_DEFENSIVE_AREA` | `void TASK_GUARD_SPHERE_DEFENSIVE_AREA(int ped, float defendPositionX, float defendPositionY, float defendPositionZ, float heading, float maxPatrolProximity, int time, float x, float y, float z, float defensiveAreaRadius)` | void | - |
| `TASK_HANDS_UP` | `void TASK_HANDS_UP(int ped, int duration, int facingPed, int timeToFacePed, int flags)` | void | In the scripts, p3 was always -1.<br><br>p3 seems to be duration or timeout of turn animation.<br>Also facing... |
| `TASK_HELI_CHASE` | `void TASK_HELI_CHASE(int pilot, int entityToFollow, float x, float y, float z)` | void | Ped pilot should be in a heli.<br>EntityToFollow can be a vehicle or Ped.<br><br>x,y,z appear to be how close... |
| `TASK_HELI_ESCORT_HELI` | `void TASK_HELI_ESCORT_HELI(int pilot, int heli1, int heli2, float offsetX, float offsetY, float offsetZ)` | void | - |
| `TASK_HELI_MISSION` | `void TASK_HELI_MISSION(int pilot, int aircraft, int targetVehicle, int targetPed, float destinationX, float destinationY, float destinationZ, int missionFlag, float maxSpeed, float radius, float targetHeading, int maxHeight, int minHeight, float slowDownDistance, int behaviorFlags)` | void | Must have targetVehicle, targetPed, OR destination X/Y/Z set<br>Will follow targeted vehicle/ped, or fl... |
| `TASK_JUMP` | `void TASK_JUMP(int ped, bool usePlayerLaunchForce, bool doSuperJump, bool useFullSuperJumpForce)` | void | Definition is wrong. This has 4 parameters (Not sure when they were added. v350 has 2, v678 has 4).<br>... |
| `TASK_LEAVE_ANY_VEHICLE` | `void TASK_LEAVE_ANY_VEHICLE(int ped, int delayTime, int flags)` | void | Flags are the same flags used in TASK_LEAVE_VEHICLE |
| `TASK_LEAVE_VEHICLE` | `void TASK_LEAVE_VEHICLE(int ped, int vehicle, int flags)` | void | Flags from decompiled scripts:<br>0 = normal exit and closes door.<br>1 = normal exit and closes door.<br>16 ... |
| `TASK_LOOK_AT_COORD` | `void TASK_LOOK_AT_COORD(int entity, float x, float y, float z, int duration, int flags, int priority)` | void | enum eScriptLookatFlags<br>{<br>	SLF_SLOW_TURN_RATE            = 1,    // turn the head toward the target ... |
| `TASK_LOOK_AT_ENTITY` | `void TASK_LOOK_AT_ENTITY(int ped, int lookAt, int duration, int flags, int priority)` | void | For flags, please refer to TASK_LOOK_AT_COORD. |
| `TASK_MOVE_NETWORK_ADVANCED_BY_NAME` | `void TASK_MOVE_NETWORK_ADVANCED_BY_NAME(int ped, string network, float x, float y, float z, float rotX, float rotY, float rotZ, int rotOrder, float blendDuration, bool allowOverrideCloneUpdate, string animDict, int flags)` | void | Example:<br>TASK::TASK_MOVE_NETWORK_ADVANCED_BY_NAME(PLAYER::PLAYER_PED_ID(), "minigame_tattoo_michael_... |
| `TASK_MOVE_NETWORK_ADVANCED_BY_NAME_WITH_INIT_PARAMS` | `void TASK_MOVE_NETWORK_ADVANCED_BY_NAME_WITH_INIT_PARAMS(int ped, string network, ref int initialParameters, float x, float y, float z, float rotX, float rotY, float rotZ, int rotOrder, float blendDuration, bool allowOverrideCloneUpdate, string dictionary, int flags)` | void | - |
| `TASK_MOVE_NETWORK_BY_NAME` | `void TASK_MOVE_NETWORK_BY_NAME(int ped, string task, float multiplier, bool allowOverrideCloneUpdate, string animDict, int flags)` | void | Example:<br>TASK::TASK_MOVE_NETWORK_BY_NAME(PLAYER::PLAYER_PED_ID(), "arm_wrestling_sweep_paired_a_rev3... |
| `TASK_MOVE_NETWORK_BY_NAME_WITH_INIT_PARAMS` | `void TASK_MOVE_NETWORK_BY_NAME_WITH_INIT_PARAMS(int ped, string network, ref int initialParameters, float blendDuration, bool allowOverrideCloneUpdate, string animDict, int flags)` | void | Used only once in the scripts (am_mp_nightclub) |
| `TASK_OPEN_VEHICLE_DOOR` | `void TASK_OPEN_VEHICLE_DOOR(int ped, int vehicle, int timeOut, int seat, float speed)` | void | The given ped will try to open the nearest door to 'seat'.<br>Example: telling the ped to open the door... |
| `TASK_PARACHUTE` | `void TASK_PARACHUTE(int ped, bool giveParachuteItem, bool instant)` | void | Second parameter is unused.<br><br>second parameter was for jetpack in the early stages of gta and the har... |
| `TASK_PARACHUTE_TO_TARGET` | `void TASK_PARACHUTE_TO_TARGET(int ped, float x, float y, float z)` | void | makes ped parachute to coords x y z. Works well with PATHFIND::GET_SAFE_COORD_FOR_PED |
| `TASK_PATROL` | `void TASK_PATROL(int ped, string patrolRouteName, int alertState, bool canChatToPeds, bool useHeadLookAt)` | void | After looking at some scripts the second parameter seems to be an id of some kind. Here are some I f... |
| `TASK_PAUSE` | `void TASK_PAUSE(int ped, int ms)` | void | Stand still (?) |
| `TASK_PED_SLIDE_TO_COORD` | `void TASK_PED_SLIDE_TO_COORD(int ped, float x, float y, float z, float heading, float speed)` | void | - |
| `TASK_PED_SLIDE_TO_COORD_HDG_RATE` | `void TASK_PED_SLIDE_TO_COORD_HDG_RATE(int ped, float x, float y, float z, float heading, float speed, float headingChangeRate)` | void | - |
| `TASK_PERFORM_SEQUENCE` | `void TASK_PERFORM_SEQUENCE(int ped, int taskSequenceId)` | void | - |
| `TASK_PERFORM_SEQUENCE_FROM_PROGRESS` | `void TASK_PERFORM_SEQUENCE_FROM_PROGRESS(int ped, int taskIndex, int progress1, int progress2)` | void | - |
| `TASK_PERFORM_SEQUENCE_LOCALLY` | `void TASK_PERFORM_SEQUENCE_LOCALLY(int ped, int taskSequenceId)` | void | - |
| `TASK_PLANE_CHASE` | `void TASK_PLANE_CHASE(int pilot, int entityToFollow, float x, float y, float z)` | void | - |
| `TASK_PLANE_GOTO_PRECISE_VTOL` | `void TASK_PLANE_GOTO_PRECISE_VTOL(int ped, int vehicle, float x, float y, float z, int flightHeight, int minHeightAboveTerrain, bool useDesiredOrientation, float desiredOrientation, bool autopilot)` | void | - |
| `TASK_PLANE_LAND` | `void TASK_PLANE_LAND(int pilot, int plane, float runwayStartX, float runwayStartY, float runwayStartZ, float runwayEndX, float runwayEndY, float runwayEndZ)` | void | - |
| `TASK_PLANE_MISSION` | `void TASK_PLANE_MISSION(int pilot, int aircraft, int targetVehicle, int targetPed, float destinationX, float destinationY, float destinationZ, int missionFlag, float angularDrag, float targetReached, float targetHeading, float maxZ, float minZ, bool precise)` | void | EXAMPLE USAGE:<br><br>Fly around target (Precautiously, keeps high altitude):<br>Function.Call(Hash.TASK_PLAN... |
| `TASK_PLANE_TAXI` | `void TASK_PLANE_TAXI(int pilot, int aircraft, float x, float y, float z, float cruiseSpeed, float targetReached)` | void | - |
| `TASK_PLANT_BOMB` | `void TASK_PLANT_BOMB(int ped, float x, float y, float z, float heading)` | void | - |
| `TASK_PLAY_ANIM` | `void TASK_PLAY_ANIM(int ped, string animDictionary, string animationName, float blendInSpeed, float blendOutSpeed, int duration, int flag, float playbackRate, bool lockX, bool lockY, bool lockZ)` | void | Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-... |
| `TASK_PLAY_ANIM_ADVANCED` | `void TASK_PLAY_ANIM_ADVANCED(int ped, string animDict, string animName, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float animEnterSpeed, float animExitSpeed, int duration, object flag, float animTime, int rotOrder, int ikFlags)` | void | It's similar to TASK_PLAY_ANIM, except the first 6 floats let you specify the initial position and r... |
| `TASK_PLAY_PHONE_GESTURE_ANIMATION` | `void TASK_PLAY_PHONE_GESTURE_ANIMATION(int ped, string animDict, string animation, string boneMaskType, float blendInDuration, float blendOutDuration, bool isLooping, bool holdLastFrame)` | void | Example from the scripts:<br>TASK::TASK_PLAY_PHONE_GESTURE_ANIMATION(PLAYER::PLAYER_PED_ID(), v_3, v_2,... |
| `TASK_PUT_PED_DIRECTLY_INTO_COVER` | `void TASK_PUT_PED_DIRECTLY_INTO_COVER(int ped, float x, float y, float z, int time, bool allowPeekingAndFiring, float blendInDuration, bool forceInitialFacingDirection, bool forceFaceLeft, int identifier, bool doEntry)` | void | - |
| `TASK_PUT_PED_DIRECTLY_INTO_MELEE` | `void TASK_PUT_PED_DIRECTLY_INTO_MELEE(int ped, int meleeTarget, float blendInDuration, float timeInMelee, float strafePhaseSync, int aiCombatFlags)` | void | from armenian3.c4<br><br>TASK::TASK_PUT_PED_DIRECTLY_INTO_MELEE(PlayerPed, armenianPed, 0.0, -1.0, 0.0, 0)... |
| `TASK_RAPPEL_DOWN_WALL_USING_CLIPSET_OVERRIDE` | `void TASK_RAPPEL_DOWN_WALL_USING_CLIPSET_OVERRIDE(int ped, float x1, float y1, float z1, float x2, float y2, float z2, float minZ, int ropeHandle, string clipSet, object p10, object p11)` | void | Attaches a ped to a rope and allows player control to rappel down a wall. Disables all collisions wh... |
| `TASK_RAPPEL_FROM_HELI` | `void TASK_RAPPEL_FROM_HELI(int ped, float minHeightAboveGround)` | void | minHeightAboveGround: the minimum height above ground the heli must be at before the ped can start r... |
| `TASK_REACT_AND_FLEE_PED` | `void TASK_REACT_AND_FLEE_PED(int ped, int fleeTarget)` | void | - |
| `TASK_RELOAD_WEAPON` | `void TASK_RELOAD_WEAPON(int ped, bool drawWeapon)` | void | The 2nd param (drawWeapon) is not implemented.<br><br>----------------------------------------------------... |
| `TASK_SCRIPTED_ANIMATION` | `void TASK_SCRIPTED_ANIMATION(int ped, ref int priorityLowData, ref int priorityMidData, ref int priorityHighData, float blendInDelta, float blendOutDelta)` | void | From fm_mission_controller.c:<br>reserve_network_mission_objects(get_num_reserved_mission_objects(0) + ... |
| `TASK_SEEK_COVER_FROM_PED` | `void TASK_SEEK_COVER_FROM_PED(int ped, int target, int duration, bool allowPeekingAndFiring)` | void | - |
| `TASK_SEEK_COVER_FROM_POS` | `void TASK_SEEK_COVER_FROM_POS(int ped, float x, float y, float z, int duration, bool allowPeekingAndFiring)` | void | - |
| `TASK_SEEK_COVER_TO_COORDS` | `void TASK_SEEK_COVER_TO_COORDS(int ped, float x1, float y1, float z1, float x2, float y2, float z2, int timeout, bool shortRoute)` | void | p8 causes the ped to take the shortest route to the cover position. It may have something to do with... |
| `TASK_SEEK_COVER_TO_COVER_POINT` | `void TASK_SEEK_COVER_TO_COVER_POINT(int ped, int coverpoint, float x, float y, float z, int time, bool allowPeekingAndFiring)` | void | p5 is always -1 |
| `TASK_SET_BLOCKING_OF_NON_TEMPORARY_EVENTS` | `void TASK_SET_BLOCKING_OF_NON_TEMPORARY_EVENTS(int ped, bool toggle)` | void | I cant believe I have to define this, this is one of the best natives.<br><br>It makes the ped ignore basi... |
| `TASK_SET_DECISION_MAKER` | `void TASK_SET_DECISION_MAKER(int ped, uint decisionMakerId)` | void | p1 is always GET_HASH_KEY("empty") in scripts, for the rare times this is used |
| `TASK_SET_SPHERE_DEFENSIVE_AREA` | `void TASK_SET_SPHERE_DEFENSIVE_AREA(int ped, float x, float y, float z, float radius)` | void | - |
| `TASK_SHARK_CIRCLE_COORD` | `void TASK_SHARK_CIRCLE_COORD(int ped, float x, float y, float z, float moveBlendRatio, float radius)` | void | - |
| `TASK_SHOCKING_EVENT_REACT` | `void TASK_SHOCKING_EVENT_REACT(int ped, int eventHandle)` | void | - |
| `TASK_SHOOT_AT_COORD` | `void TASK_SHOOT_AT_COORD(int ped, float x, float y, float z, int duration, uint firingPattern)` | void | Firing Pattern Hash Information: https://pastebin.com/Px036isB |
| `TASK_SHOOT_AT_ENTITY` | `void TASK_SHOOT_AT_ENTITY(int entity, int target, int duration, uint firingPattern)` | void | //this part of the code is to determine at which entity the player is aiming, for example if you wan... |
| `TASK_SHUFFLE_TO_NEXT_VEHICLE_SEAT` | `void TASK_SHUFFLE_TO_NEXT_VEHICLE_SEAT(int ped, int vehicle, bool useAlternateShuffle)` | void | Makes the specified ped shuffle to the next vehicle seat.<br>The ped MUST be in a vehicle and the vehic... |
| `TASK_SKY_DIVE` | `void TASK_SKY_DIVE(int ped, bool instant)` | void | - |
| `TASK_SMART_FLEE_COORD` | `void TASK_SMART_FLEE_COORD(int ped, float x, float y, float z, float distance, int time, bool preferPavements, bool quitIfOutOfRange)` | void | Makes the specified ped flee the specified distance from the specified position. |
| `TASK_SMART_FLEE_PED` | `void TASK_SMART_FLEE_PED(int ped, int fleeTarget, float safeDistance, int fleeTime, bool preferPavements, bool updateToNearestHatedPed)` | void | Makes a ped run away from another ped (fleeTarget).<br><br>distance = ped will flee this distance.<br>fleeTim... |
| `TASK_STAND_GUARD` | `void TASK_STAND_GUARD(int ped, float x, float y, float z, float heading, string scenarioName)` | void | scenarioName example: "WORLD_HUMAN_GUARD_STAND" |
| `TASK_STAND_STILL` | `void TASK_STAND_STILL(int ped, int time)` | void | Makes the specified ped stand still for (time) milliseconds. |
| `TASK_START_SCENARIO_AT_POSITION` | `void TASK_START_SCENARIO_AT_POSITION(int ped, string scenarioName, float x, float y, float z, float heading, int duration, bool sittingScenario, bool teleport)` | void | Full list of ped scenarios by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/s... |
| `TASK_START_SCENARIO_IN_PLACE` | `void TASK_START_SCENARIO_IN_PLACE(int ped, string scenarioName, int unkDelay, bool playEnterAnim)` | void | Plays a scenario on a Ped at their current location.<br><br>unkDelay - Usually 0 or -1, doesn't seem to ha... |
| `TASK_STAY_IN_COVER` | `void TASK_STAY_IN_COVER(int ped)` | void | Makes the ped run to take cover |
| `TASK_STEALTH_KILL` | `void TASK_STEALTH_KILL(int killer, int target, uint stealthKillActionResultHash, float desiredMoveBlendRatio, int stealthFlags)` | void | known "killTypes" are: "AR_stealth_kill_knife" and "AR_stealth_kill_a". |
| `TASK_STOP_PHONE_GESTURE_ANIMATION` | `void TASK_STOP_PHONE_GESTURE_ANIMATION(int ped, float blendOutOverride)` | void | - |
| `TASK_SUBMARINE_GOTO_AND_STOP` | `void TASK_SUBMARINE_GOTO_AND_STOP(int ped, int submarine, float x, float y, float z, bool autopilot)` | void | Used in am_vehicle_spawn.ysc and am_mp_submarine.ysc.<br><br>p0 is always 0, p5 is always 1<br><br>p1 is the veh... |
| `TASK_SWAP_WEAPON` | `void TASK_SWAP_WEAPON(int ped, bool drawWeapon)` | void | - |
| `TASK_SWEEP_AIM_ENTITY` | `void TASK_SWEEP_AIM_ENTITY(int ped, string animDict, string lowAnimName, string medAnimName, string hiAnimName, int runtime, int targetEntity, float turnRate, float blendInDuration)` | void | This function is called on peds in vehicles.<br><br>anim: animation name<br>p2, p3, p4: "sweep_low", "sweep_m... |
| `TASK_SWEEP_AIM_POSITION` | `void TASK_SWEEP_AIM_POSITION(int ped, string animDict, string lowAnimName, string medAnimName, string hiAnimName, int runtime, float x, float y, float z, float turnRate, float blendInDuration)` | void | - |
| `TASK_SYNCHRONIZED_SCENE` | `void TASK_SYNCHRONIZED_SCENE(int ped, int scene, string animDictionary, string animationName, float blendIn, float blendOut, int flags, int ragdollBlockingFlags, float moverBlendDelta, int ikFlags)` | void |  TASK::TASK_SYNCHRONIZED_SCENE(ped, scene, "creatures@rottweiler@in_vehicle@std_car", "get_in", 1000... |
| `TASK_THROW_PROJECTILE` | `void TASK_THROW_PROJECTILE(int ped, float x, float y, float z, int ignoreCollisionEntityIndex, bool createInvincibleProjectile)` | void | In every case of this native, I've only seen the first parameter passed as 0, although I believe it'... |
| `TASK_TOGGLE_DUCK` | `void TASK_TOGGLE_DUCK(int ped, int toggleType)` | void | used in sequence task<br><br>both parameters seems to be always 0 |
| `TASK_TURN_PED_TO_FACE_COORD` | `void TASK_TURN_PED_TO_FACE_COORD(int ped, float x, float y, float z, int duration)` | void | duration in milliseconds |
| `TASK_TURN_PED_TO_FACE_ENTITY` | `void TASK_TURN_PED_TO_FACE_ENTITY(int ped, int entity, int duration)` | void | duration: the amount of time in milliseconds to do the task. -1 will keep the task going until eithe... |
| `TASK_USE_MOBILE_PHONE` | `void TASK_USE_MOBILE_PHONE(int ped, bool usePhone, int desiredPhoneMode)` | void | Actually has 3 params, not 2.<br><br>p0: Ped<br>p1: int (or bool?)<br>p2: int |
| `TASK_USE_MOBILE_PHONE_TIMED` | `void TASK_USE_MOBILE_PHONE_TIMED(int ped, int duration)` | void | - |
| `TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD` | `void TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD(int ped, float x, float y, float z, float maxRange, int timeToLeave)` | void | p5 is always 0 in scripts |
| `TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD_WARP` | `void TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD_WARP(int ped, float x, float y, float z, float radius, int timeToLeave)` | void | p5 is always -1 or 0 in scripts |
| `TASK_USE_NEAREST_SCENARIO_TO_COORD` | `void TASK_USE_NEAREST_SCENARIO_TO_COORD(int ped, float x, float y, float z, float distance, int duration)` | void | Updated variables<br><br>An alternative to TASK::TASK_USE_NEAREST_SCENARIO_TO_COORD_WARP. Makes the ped wa... |
| `TASK_USE_NEAREST_SCENARIO_TO_COORD_WARP` | `void TASK_USE_NEAREST_SCENARIO_TO_COORD_WARP(int ped, float x, float y, float z, float radius, int timeToLeave)` | void | - |
| `TASK_VEHICLE_AIM_AT_COORD` | `void TASK_VEHICLE_AIM_AT_COORD(int ped, float x, float y, float z)` | void | - |
| `TASK_VEHICLE_AIM_AT_PED` | `void TASK_VEHICLE_AIM_AT_PED(int ped, int target)` | void | - |
| `TASK_VEHICLE_CHASE` | `void TASK_VEHICLE_CHASE(int driver, int targetEnt)` | void | chases targetEnt fast and aggressively<br>--<br>Makes ped (needs to be in vehicle) chase targetEnt. |
| `TASK_VEHICLE_DRIVE_TO_COORD` | `void TASK_VEHICLE_DRIVE_TO_COORD(int ped, int vehicle, float x, float y, float z, float speed, object p6, uint vehicleModel, int drivingMode, float stopRange, float straightLineDistance)` | void | info about driving modes: https://gtaforums.com/topic/822314-guide-driving-styles/ |
| `TASK_VEHICLE_DRIVE_TO_COORD_LONGRANGE` | `void TASK_VEHICLE_DRIVE_TO_COORD_LONGRANGE(int ped, int vehicle, float x, float y, float z, float speed, int driveMode, float stopRange)` | void | - |
| `TASK_VEHICLE_DRIVE_WANDER` | `void TASK_VEHICLE_DRIVE_WANDER(int ped, int vehicle, float speed, int drivingStyle)` | void | - |
| `TASK_VEHICLE_ESCORT` | `void TASK_VEHICLE_ESCORT(int ped, int vehicle, int targetVehicle, int mode, float speed, int drivingStyle, float minDistance, int minHeightAboveTerrain, float noRoadsDistance)` | void | Makes a ped follow the targetVehicle with <minDistance> in between.<br><br>note: minDistance is ignored if... |
| `TASK_VEHICLE_FOLLOW` | `void TASK_VEHICLE_FOLLOW(int driver, int vehicle, int targetEntity, float speed, int drivingStyle, int minDistance)` | void | Makes a ped in a vehicle follow an entity (ped, vehicle, etc.)<br><br>drivingStyle: http://gtaforums.com/t... |
| `TASK_VEHICLE_FOLLOW_WAYPOINT_RECORDING` | `void TASK_VEHICLE_FOLLOW_WAYPOINT_RECORDING(int ped, int vehicle, string WPRecording, int p3, int p4, int p5, int p6, float p7, bool p8, float p9)` | void | <br><br>p2 = Waypoint recording string (found in update\update.rpf\x64\levels\gta5\waypointrec.rpf<br>p3 = 78... |
| `TASK_VEHICLE_GOTO_NAVMESH` | `void TASK_VEHICLE_GOTO_NAVMESH(int ped, int vehicle, float x, float y, float z, float speed, int behaviorFlag, float stoppingRange)` | void | Differs from TASK_VEHICLE_DRIVE_TO_COORDS in that it will pick the shortest possible road route with... |
| `TASK_VEHICLE_HELI_PROTECT` | `void TASK_VEHICLE_HELI_PROTECT(int pilot, int vehicle, int entityToFollow, float targetSpeed, int drivingFlags, float radius, int altitude, int heliFlags)` | void | pilot, vehicle and altitude are rather self-explanatory.<br><br>p4: is unused variable in the function.<br><br>e... |
| `TASK_VEHICLE_MISSION` | `void TASK_VEHICLE_MISSION(int driver, int vehicle, int vehicleTarget, int missionType, float cruiseSpeed, int drivingStyle, float targetReached, float straightLineDistance, bool DriveAgainstTraffic)` | void | missionType: https://alloc8or.re/gta5/doc/enums/eVehicleMissionType.txt |
| `TASK_VEHICLE_MISSION_COORS_TARGET` | `void TASK_VEHICLE_MISSION_COORS_TARGET(int ped, int vehicle, float x, float y, float z, int mission, float cruiseSpeed, int drivingStyle, float targetReached, float straightLineDistance, bool DriveAgainstTraffic)` | void | See TASK_VEHICLE_MISSION |
| `TASK_VEHICLE_MISSION_PED_TARGET` | `void TASK_VEHICLE_MISSION_PED_TARGET(int ped, int vehicle, int pedTarget, int missionType, float maxSpeed, int drivingStyle, float minDistance, float straightLineDistance, bool DriveAgainstTraffic)` | void | See TASK_VEHICLE_MISSION |
| `TASK_VEHICLE_PARK` | `void TASK_VEHICLE_PARK(int ped, int vehicle, float x, float y, float z, float heading, int mode, float radius, bool keepEngineOn)` | void | Modes:<br>0 - ignore heading<br>1 - park forward<br>2 - park backwards<br><br>Depending on the angle of approach, t... |
| `TASK_VEHICLE_PLAY_ANIM` | `void TASK_VEHICLE_PLAY_ANIM(int vehicle, string animationSet, string animationName)` | void | Most probably plays a specific animation on vehicle. For example getting chop out of van etc...<br><br>Her... |
| `TASK_VEHICLE_SHOOT_AT_COORD` | `void TASK_VEHICLE_SHOOT_AT_COORD(int ped, float x, float y, float z, float fireTolerance)` | void | - |
| `TASK_VEHICLE_SHOOT_AT_PED` | `void TASK_VEHICLE_SHOOT_AT_PED(int ped, int target, float fireTolerance)` | void | - |
| `TASK_VEHICLE_TEMP_ACTION` | `void TASK_VEHICLE_TEMP_ACTION(int driver, int vehicle, int action, int time)` | void | '1 - brake<br>'3 - brake + reverse<br>'4 - turn left 90 + braking<br>'5 - turn right 90 + braking<br>'6 - brake ... |
| `TASK_WANDER_IN_AREA` | `void TASK_WANDER_IN_AREA(int ped, float x, float y, float z, float radius, float minimalLength, float timeBetweenWalks)` | void | - |
| `TASK_WANDER_SPECIFIC` | `void TASK_WANDER_SPECIFIC(int ped, string conditionalAnimGroupStr, string conditionalAnimStr, float heading)` | void | - |
| `TASK_WANDER_STANDARD` | `void TASK_WANDER_STANDARD(int ped, float heading, int flags)` | void | Makes ped walk around the area.<br><br>set p1 to 10.0f and p2 to 10 if you want the ped to walk anywhere w... |
| `TASK_WARP_PED_DIRECTLY_INTO_COVER` | `void TASK_WARP_PED_DIRECTLY_INTO_COVER(int ped, int time, bool allowPeekingAndFiring, bool forceInitialFacingDirection, bool forceFaceLeft, int identifier)` | void | - |
| `TASK_WARP_PED_INTO_VEHICLE` | `void TASK_WARP_PED_INTO_VEHICLE(int ped, int vehicle, int seat)` | void | Seat Numbers<br>-------------------------------<br>Driver = -1<br>Any = -2<br>Left-Rear = 1<br>Right-Front = 0<br>Righ... |
| `TASK_WRITHE` | `void TASK_WRITHE(int ped, int target, int minFireLoops, int startState, bool forceShootOnGround, int shootFromGroundTimer)` | void | EX: Function.Call(Ped1, Ped2, Time, 0);<br><br>The last parameter is always 0 for some reason I do not kno... |
| `UNCUFF_PED` | `void UNCUFF_PED(int ped)` | void | - |
| `UPDATE_TASK_AIM_GUN_SCRIPTED_TARGET` | `void UPDATE_TASK_AIM_GUN_SCRIPTED_TARGET(int ped, int target, float x, float y, float z, bool disableBlockingClip)` | void | - |
| `UPDATE_TASK_HANDS_UP_DURATION` | `void UPDATE_TASK_HANDS_UP_DURATION(int ped, int duration)` | void | - |
| `UPDATE_TASK_SWEEP_AIM_ENTITY` | `void UPDATE_TASK_SWEEP_AIM_ENTITY(int ped, int entity)` | void | - |
| `UPDATE_TASK_SWEEP_AIM_POSITION` | `void UPDATE_TASK_SWEEP_AIM_POSITION(int ped, float x, float y, float z)` | void | - |
| `USE_WAYPOINT_RECORDING_AS_ASSISTED_MOVEMENT_ROUTE` | `void USE_WAYPOINT_RECORDING_AS_ASSISTED_MOVEMENT_ROUTE(string name, bool p1, float p2, float p3)` | void | - |
| `VEHICLE_WAYPOINT_PLAYBACK_GET_IS_PAUSED` | `bool VEHICLE_WAYPOINT_PLAYBACK_GET_IS_PAUSED(int vehicle)` | bool | - |
| `VEHICLE_WAYPOINT_PLAYBACK_OVERRIDE_SPEED` | `void VEHICLE_WAYPOINT_PLAYBACK_OVERRIDE_SPEED(int vehicle, float speed)` | void | - |
| `VEHICLE_WAYPOINT_PLAYBACK_PAUSE` | `void VEHICLE_WAYPOINT_PLAYBACK_PAUSE(int vehicle)` | void | - |
| `VEHICLE_WAYPOINT_PLAYBACK_RESUME` | `void VEHICLE_WAYPOINT_PLAYBACK_RESUME(int vehicle)` | void | - |
| `VEHICLE_WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED` | `void VEHICLE_WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED(int vehicle)` | void | - |
| `WAYPOINT_PLAYBACK_GET_IS_PAUSED` | `bool WAYPOINT_PLAYBACK_GET_IS_PAUSED(object p0)` | bool | - |
| `WAYPOINT_PLAYBACK_OVERRIDE_SPEED` | `void WAYPOINT_PLAYBACK_OVERRIDE_SPEED(object p0, float p1, bool p2)` | void | - |
| `WAYPOINT_PLAYBACK_PAUSE` | `void WAYPOINT_PLAYBACK_PAUSE(object p0, bool p1, bool p2)` | void | - |
| `WAYPOINT_PLAYBACK_RESUME` | `void WAYPOINT_PLAYBACK_RESUME(object p0, bool p1, object p2, object p3)` | void | - |
| `WAYPOINT_PLAYBACK_START_AIMING_AT_COORD` | `void WAYPOINT_PLAYBACK_START_AIMING_AT_COORD(int ped, float x, float y, float z, bool p4)` | void | - |
| `WAYPOINT_PLAYBACK_START_AIMING_AT_PED` | `void WAYPOINT_PLAYBACK_START_AIMING_AT_PED(int ped, int target, bool p2)` | void | - |
| `WAYPOINT_PLAYBACK_START_SHOOTING_AT_COORD` | `void WAYPOINT_PLAYBACK_START_SHOOTING_AT_COORD(int ped, float x, float y, float z, bool p4, uint firingPattern)` | void | - |
| `WAYPOINT_PLAYBACK_START_SHOOTING_AT_PED` | `void WAYPOINT_PLAYBACK_START_SHOOTING_AT_PED(int ped, int ped2, bool p2, bool p3)` | void | - |
| `WAYPOINT_PLAYBACK_STOP_AIMING_OR_SHOOTING` | `void WAYPOINT_PLAYBACK_STOP_AIMING_OR_SHOOTING(int ped)` | void | - |
| `WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED` | `void WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED(object p0)` | void | - |
| `WAYPOINT_RECORDING_GET_CLOSEST_WAYPOINT` | `bool WAYPOINT_RECORDING_GET_CLOSEST_WAYPOINT(string name, float x, float y, float z, ref int point)` | bool | Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/ma... |
| `WAYPOINT_RECORDING_GET_COORD` | `bool WAYPOINT_RECORDING_GET_COORD(string name, int point, ref Vector3 coord)` | bool | Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/ma... |
| `WAYPOINT_RECORDING_GET_NUM_POINTS` | `bool WAYPOINT_RECORDING_GET_NUM_POINTS(string name, ref int points)` | bool | Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/ma... |
| `WAYPOINT_RECORDING_GET_SPEED_AT_POINT` | `float WAYPOINT_RECORDING_GET_SPEED_AT_POINT(string name, int point)` | float | Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/ma... |
| `_SET_AMBIENT_PED_ENABLE_COLLISION_ON_NETWORK_CLONE_WHEN_FIXED` | `void _SET_AMBIENT_PED_ENABLE_COLLISION_ON_NETWORK_CLONE_WHEN_FIXED(int ped, bool enable)` | void | - |
| `_SET_SCRIPT_TASK_ENABLE_COLLISION_ON_NETWORK_CLONE_WHEN_FIXED` | `void _SET_SCRIPT_TASK_ENABLE_COLLISION_ON_NETWORK_CLONE_WHEN_FIXED(int ped, bool enable)` | void | - |

---

## 详细说明

### ADD_COVER_BLOCKING_AREA

- **命名空间:** `TASK`
- **Hash:** `0x45C597097DD7CB81`
- **JHash:** `0x3536946F`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_COVER_BLOCKING_AREA(float startX, float startY, float startZ, float endX, float endY, float endZ, bool blockObjects, bool blockVehicles, bool blockMap, bool blockPlayer)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `startX` | `float` | `float` | - |
| `startY` | `float` | `float` | - |
| `startZ` | `float` | `float` | - |
| `endX` | `float` | `float` | - |
| `endY` | `float` | `float` | - |
| `endZ` | `float` | `float` | - |
| `blockObjects` | `BOOL` | `bool` | - |
| `blockVehicles` | `BOOL` | `bool` | - |
| `blockMap` | `BOOL` | `bool` | - |
| `blockPlayer` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### ADD_COVER_POINT

- **命名空间:** `TASK`
- **Hash:** `0xD5C12A75C7B9497F`
- **JHash:** `0xA0AF0B98`
- **Build:** `323`

**C# 签名:**
```csharp
int ADD_COVER_POINT(float x, float y, float z, float direction, int usage, int height, int arc, bool isPriority)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `direction` | `float` | `float` | - |
| `usage` | `int` | `int` | - |
| `height` | `int` | `int` | - |
| `arc` | `int` | `int` | - |
| `isPriority` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `ScrHandle`)

---

### ADD_PATROL_ROUTE_LINK

- **命名空间:** `TASK`
- **Hash:** `0x23083260DEC3A551`
- **JHash:** `0xD8761BB3`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_PATROL_ROUTE_LINK(int nodeId1, int nodeId2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `nodeId1` | `int` | `int` | - |
| `nodeId2` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### ADD_PATROL_ROUTE_NODE

- **命名空间:** `TASK`
- **Hash:** `0x8EDF950167586B7C`
- **JHash:** `0x21B48F10`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_PATROL_ROUTE_NODE(int nodeId, string nodeType, float posX, float posY, float posZ, float headingX, float headingY, float headingZ, int duration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `nodeId` | `int` | `int` | - |
| `nodeType` | `const char*` | `string` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `headingX` | `float` | `float` | - |
| `headingY` | `float` | `float` | - |
| `headingZ` | `float` | `float` | - |
| `duration` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Example: 
TASK::ADD_PATROL_ROUTE_NODE(2, "WORLD_HUMAN_GUARD_STAND", -193.4915, -2378.864990234375, 10.9719, -193.4915, -2378.864990234375, 10.9719, 3000);

p0 is between 0 and 4 in the scripts.

p1 is "WORLD_HUMAN_GUARD_STAND" or "StandGuard".

p2, p3 and p4 is only one parameter sometimes in the scripts. Most likely a Vector3 hence p2, p3 and p4 are coordinates. 
Examples: 
TASK::ADD_PATROL_ROUTE_NODE(1, "WORLD_HUMAN_GUARD_STAND", l_739[7/*3*/], 0.0, 0.0, 0.0, 0);

TASK::ADD_PATROL_ROUTE_NODE(1, "WORLD_HUMAN_GUARD_STAND", l_B0[17/*44*/]._f3, l_B0[17/*44*/]._f3, 2000);

p5, p6 and p7 are for example set to: 1599.0406494140625, 2713.392578125, 44.4309.

p8 is an int, often random set to for example: MISC::GET_RANDOM_INT_IN_RANGE(5000, 10000).
```

---

### ADD_SCRIPTED_COVER_AREA

- **命名空间:** `TASK`
- **Hash:** `0x28B7B9BFDAF274AA`
- **Build:** `2545`

**C# 签名:**
```csharp
void ADD_SCRIPTED_COVER_AREA(float x, float y, float z, float radius)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
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

### ADD_VEHICLE_SUBTASK_ATTACK_COORD

- **命名空间:** `TASK`
- **Hash:** `0x5CF0D8F9BBA0DD75`
- **JHash:** `0x50779A2C`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_VEHICLE_SUBTASK_ATTACK_COORD(int ped, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
x, y, z: offset in world coords from some entity.
```

---

### ADD_VEHICLE_SUBTASK_ATTACK_PED

- **命名空间:** `TASK`
- **Hash:** `0x85F462BADC7DA47F`
- **JHash:** `0x80461113`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_VEHICLE_SUBTASK_ATTACK_PED(int ped, int target)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `target` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### ASSISTED_MOVEMENT_IS_ROUTE_LOADED

- **命名空间:** `TASK`
- **Hash:** `0x60F9A4393A21F741`
- **JHash:** `0x79B067AF`
- **Build:** `323`

**C# 签名:**
```csharp
bool ASSISTED_MOVEMENT_IS_ROUTE_LOADED(string route)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `route` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### ASSISTED_MOVEMENT_OVERRIDE_LOAD_DISTANCE_THIS_FRAME

- **命名空间:** `TASK`
- **Hash:** `0x13945951E16EF912`
- **JHash:** `0x8FB923EC`
- **Build:** `323`

**C# 签名:**
```csharp
void ASSISTED_MOVEMENT_OVERRIDE_LOAD_DISTANCE_THIS_FRAME(float dist)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `dist` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### ASSISTED_MOVEMENT_REMOVE_ROUTE

- **命名空间:** `TASK`
- **Hash:** `0x3548536485DD792B`
- **JHash:** `0xB3CEC06F`
- **Build:** `323`

**C# 签名:**
```csharp
void ASSISTED_MOVEMENT_REMOVE_ROUTE(string route)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `route` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### ASSISTED_MOVEMENT_REQUEST_ROUTE

- **命名空间:** `TASK`
- **Hash:** `0x817268968605947A`
- **JHash:** `0x48262EDA`
- **Build:** `323`

**C# 签名:**
```csharp
void ASSISTED_MOVEMENT_REQUEST_ROUTE(string route)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `route` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Routes: "1_FIBStairs", "2_FIBStairs", "3_FIBStairs", "4_FIBStairs", "5_FIBStairs", "5_TowardsFire", "6a_FIBStairs", "7_FIBStairs", "8_FIBStairs", "Aprtmnt_1", "AssAfterLift", "ATM_1", "coroner2", "coroner_stairs", "f5_jimmy1", "fame1", "family5b", "family5c", "Family5d", "family5d", "FIB_Glass1", "FIB_Glass2", "FIB_Glass3", "finaBroute1A", "finalb1st", "finalB1sta", "finalbround", "finalbroute2", "Hairdresser1", "jan_foyet_ft_door", "Jo_3", "Lemar1", "Lemar2", "mansion_1", "Mansion_1", "pols_1", "pols_2", "pols_3", "pols_4", "pols_5", "pols_6", "pols_7", "pols_8", "Pro_S1", "Pro_S1a", "Pro_S2", "Towards_case", "trev_steps", "tunrs1", "tunrs2", "tunrs3", "Wave01457s"
```

---

### ASSISTED_MOVEMENT_SET_ROUTE_PROPERTIES

- **命名空间:** `TASK`
- **Hash:** `0xD5002D78B7162E1B`
- **JHash:** `0x01CAAFCC`
- **Build:** `323`

**C# 签名:**
```csharp
void ASSISTED_MOVEMENT_SET_ROUTE_PROPERTIES(string route, int props)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `route` | `const char*` | `string` | - |
| `props` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_DEFAULT_PRIMARY_TASK

- **命名空间:** `TASK`
- **Hash:** `0x6100B3CEFD43452E`
- **Build:** `2189`

**C# 签名:**
```csharp
void CLEAR_DEFAULT_PRIMARY_TASK(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK

- **命名空间:** `TASK`
- **Hash:** `0xC35B5CDB2824CF69`
- **JHash:** `0x9B76F7E6`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PED_SCRIPT_TASK_IF_RUNNING_THREAT_RESPONSE_NON_TEMP_TASK

- **命名空间:** `TASK`
- **Hash:** `0xF6DC48E56BE1243A`
- **Build:** `3407`

**C# 签名:**
```csharp
void CLEAR_PED_SCRIPT_TASK_IF_RUNNING_THREAT_RESPONSE_NON_TEMP_TASK(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PED_SECONDARY_TASK

- **命名空间:** `TASK`
- **Hash:** `0x176CECF6F920D707`
- **JHash:** `0xA635F451`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_SECONDARY_TASK(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PED_TASKS

- **命名空间:** `TASK`
- **Hash:** `0xE1EF3C1216AFF2CD`
- **JHash:** `0xDE3316AB`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_TASKS(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PED_TASKS_IMMEDIATELY

- **命名空间:** `TASK`
- **Hash:** `0xAAA34F8A7CB32098`
- **JHash:** `0xBC045625`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_TASKS_IMMEDIATELY(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Immediately stops the pedestrian from whatever it's doing. They stop fighting, animations, etc. they forget what they were doing.
```

---

### CLEAR_PRIMARY_VEHICLE_TASK

- **命名空间:** `TASK`
- **Hash:** `0xDBBC7A2432524127`
- **Build:** `1290`

**C# 签名:**
```csharp
void CLEAR_PRIMARY_VEHICLE_TASK(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native is very useful when switching the player to a ped inside a vehicle that has a task assigned prior to the player switch.
It is necessary to clear the ped's tasks AND call this native with the vehicle the player is switching into in order to allow the player to control the vehicle after the player switches.
```

---

### CLEAR_SEQUENCE_TASK

- **命名空间:** `TASK`
- **Hash:** `0x3841422E9C488D8C`
- **JHash:** `0x47ED03CE`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_SEQUENCE_TASK(ref int taskSequenceId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `taskSequenceId` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_VEHICLE_CRASH_TASK

- **命名空间:** `TASK`
- **Hash:** `0x53DDC75BC3AC0A90`
- **Build:** `1290`

**C# 签名:**
```csharp
void CLEAR_VEHICLE_CRASH_TASK(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLOSE_PATROL_ROUTE

- **命名空间:** `TASK`
- **Hash:** `0xB043ECA801B8CBC1`
- **JHash:** `0x67305E59`
- **Build:** `323`

**C# 签名:**
```csharp
void CLOSE_PATROL_ROUTE()
```

**返回值:** `void` (Native: `void`)

---

### CLOSE_SEQUENCE_TASK

- **命名空间:** `TASK`
- **Hash:** `0x39E72BC99E6360CB`
- **JHash:** `0x1A7CEBD0`
- **Build:** `323`

**C# 签名:**
```csharp
void CLOSE_SEQUENCE_TASK(int taskSequenceId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `taskSequenceId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CONTROL_MOUNTED_WEAPON

- **命名空间:** `TASK`
- **Hash:** `0xDCFE42068FE0135A`
- **JHash:** `0x500D9244`
- **Build:** `323`

**C# 签名:**
```csharp
bool CONTROL_MOUNTED_WEAPON(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Forces the ped to use the mounted weapon.
Returns false if task is not possible.
```

---

### CREATE_PATROL_ROUTE

- **命名空间:** `TASK`
- **Hash:** `0xAF8A443CCC8018DC`
- **JHash:** `0x0A6C7864`
- **Build:** `323`

**C# 签名:**
```csharp
void CREATE_PATROL_ROUTE()
```

**返回值:** `void` (Native: `void`)

---

### DELETE_PATROL_ROUTE

- **命名空间:** `TASK`
- **Hash:** `0x7767DD9D65E91319`
- **JHash:** `0x2A4E6706`
- **Build:** `323`

**C# 签名:**
```csharp
void DELETE_PATROL_ROUTE(string patrolRoute)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `patrolRoute` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
From the b617d scripts:

TASK::DELETE_PATROL_ROUTE("miss_merc0");
TASK::DELETE_PATROL_ROUTE("miss_merc1");
TASK::DELETE_PATROL_ROUTE("miss_merc2");
TASK::DELETE_PATROL_ROUTE("miss_dock");
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

### DOES_SCENARIO_EXIST_IN_AREA

- **命名空间:** `TASK`
- **Hash:** `0x5A59271FFADD33C1`
- **JHash:** `0xFA7F5047`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_SCENARIO_EXIST_IN_AREA(float x, float y, float z, float radius, bool mustBeFree)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `mustBeFree` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DOES_SCENARIO_GROUP_EXIST

- **命名空间:** `TASK`
- **Hash:** `0xF9034C136C9E00D3`
- **JHash:** `0x5F072EB9`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_SCENARIO_GROUP_EXIST(string scenarioGroup)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scenarioGroup` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of scenario groups used in scripts by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/scenarioGroupNames.json
Occurrences in the b617d scripts:

"ARMY_GUARD",
"ARMY_HELI",
"Cinema_Downtown",
"Cinema_Morningwood",
"Cinema_Textile",
"City_Banks",
"Countryside_Banks",
"DEALERSHIP",
"GRAPESEED_PLANES",
"KORTZ_SECURITY",
"LOST_BIKERS",
"LSA_Planes",
"LSA_Planes",
"MP_POLICE",
"Observatory_Bikers", 
"POLICE_POUND1",
"POLICE_POUND2",
"POLICE_POUND3",
"POLICE_POUND4",
"POLICE_POUND5"
"QUARRY",
"SANDY_PLANES",
"SCRAP_SECURITY",
"SEW_MACHINE",
"SOLOMON_GATE",
"Triathlon_1_Start", 
"Triathlon_2_Start", 
"Triathlon_3_Start"

Sometimes used with IS_SCENARIO_GROUP_ENABLED:
if (TASK::DOES_SCENARIO_GROUP_EXIST("Observatory_Bikers") && (!TASK::IS_SCENARIO_GROUP_ENABLED("Observatory_Bikers"))) {
else if (TASK::IS_SCENARIO_GROUP_ENABLED("BLIMP")) {

```

---

### DOES_SCENARIO_OF_TYPE_EXIST_IN_AREA

- **命名空间:** `TASK`
- **Hash:** `0x0A9D0C2A3BBC86C1`
- **JHash:** `0x0FB138A5`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_SCENARIO_OF_TYPE_EXIST_IN_AREA(float x, float y, float z, string scenarioName, float radius, bool mustBeFree)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `scenarioName` | `const char*` | `string` | - |
| `radius` | `float` | `float` | - |
| `mustBeFree` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DOES_SCRIPTED_COVER_POINT_EXIST_AT_COORDS

- **命名空间:** `TASK`
- **Hash:** `0xA98B8E3C088E5A31`
- **JHash:** `0x29F97A71`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_SCRIPTED_COVER_POINT_EXIST_AT_COORDS(float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Checks if there is a cover point at position
```

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

### GET_ACTIVE_VEHICLE_MISSION_TYPE

- **命名空间:** `TASK`
- **Hash:** `0x534AEBA6E5ED4CAB`
- **JHash:** `0xAFA914EF`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_ACTIVE_VEHICLE_MISSION_TYPE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
https://alloc8or.re/gta5/doc/enums/eVehicleMissionType.txt
```

---

### GET_CLIP_SET_FOR_SCRIPTED_GUN_TASK

- **命名空间:** `TASK`
- **Hash:** `0x3A8CADC7D37AACC5`
- **JHash:** `0x249EB4EB`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_CLIP_SET_FOR_SCRIPTED_GUN_TASK(int gunTaskType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gunTaskType` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

---

### GET_IS_TASK_ACTIVE

- **命名空间:** `TASK`
- **Hash:** `0xB0760331C7AA4155`
- **JHash:** `0x86FDDF55`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_IS_TASK_ACTIVE(int ped, int taskIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `taskIndex` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Task index enum: https://alloc8or.re/gta5/doc/enums/eTaskTypeIndex.txt
```

---

### GET_IS_WAYPOINT_RECORDING_LOADED

- **命名空间:** `TASK`
- **Hash:** `0xCB4E8BE8A0063C5D`
- **JHash:** `0x87125F5D`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_IS_WAYPOINT_RECORDING_LOADED(string name)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/waypointRecordings.json
```

---

### GET_NAVMESH_ROUTE_DISTANCE_REMAINING

- **命名空间:** `TASK`
- **Hash:** `0xC6F5C0BCDC74D62D`
- **JHash:** `0xD9281778`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NAVMESH_ROUTE_DISTANCE_REMAINING(int ped, ref float distanceRemaining, ref bool isPathReady)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `distanceRemaining` | `float*` | `ref float` | - |
| `isPathReady` | `BOOL*` | `ref bool` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Looks like the last parameter returns true if the path has been calculated, while the first returns the remaining distance to the end of the path.
Return value of native is the same as GET_NAVMESH_ROUTE_RESULT
Looks like the native returns an int for the path's state:
1 - ???
2 - ???
3 - Finished Generating 
```

---

### GET_NAVMESH_ROUTE_RESULT

- **命名空间:** `TASK`
- **Hash:** `0x632E831F382A0FA8`
- **JHash:** `0x96491602`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NAVMESH_ROUTE_RESULT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
See GET_NAVMESH_ROUTE_DISTANCE_REMAINING for more details.
```

---

### GET_PATROL_TASK_INFO

- **命名空间:** `TASK`
- **Hash:** `0x52F734CEBE20DFBA`
- **Build:** `2545`

**C# 签名:**
```csharp
bool GET_PATROL_TASK_INFO(int ped, ref int timeLeftAtNode, ref int nodeId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `timeLeftAtNode` | `int*` | `ref int` | - |
| `nodeId` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_PED_DESIRED_MOVE_BLEND_RATIO

- **命名空间:** `TASK`
- **Hash:** `0x8517D4A6CA8513ED`
- **JHash:** `0x5FEFAB72`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_PED_DESIRED_MOVE_BLEND_RATIO(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_PED_WAYPOINT_DISTANCE

- **命名空间:** `TASK`
- **Hash:** `0xE6A877C64CAF1BC5`
- **JHash:** `0x084B35B0`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_PED_WAYPOINT_DISTANCE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `float` (Native: `float`)

---

### GET_PED_WAYPOINT_PROGRESS

- **命名空间:** `TASK`
- **Hash:** `0x2720AAA75001E094`
- **JHash:** `0x3595B104`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_WAYPOINT_PROGRESS(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_PHONE_GESTURE_ANIM_CURRENT_TIME

- **命名空间:** `TASK`
- **Hash:** `0x47619ABE8B268C60`
- **JHash:** `0x7B72AFD1`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_PHONE_GESTURE_ANIM_CURRENT_TIME(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_PHONE_GESTURE_ANIM_TOTAL_TIME

- **命名空间:** `TASK`
- **Hash:** `0x1EE0F68A7C25DEC6`
- **JHash:** `0xEF8C3959`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_PHONE_GESTURE_ANIM_TOTAL_TIME(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_SCRIPTED_COVER_POINT_COORDS

- **命名空间:** `TASK`
- **Hash:** `0x594A1028FC2A3E85`
- **JHash:** `0xC6B6CCC1`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_SCRIPTED_COVER_POINT_COORDS(int coverpoint)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `coverpoint` | `ScrHandle` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

---

### GET_SCRIPT_TASK_STATUS

- **命名空间:** `TASK`
- **Hash:** `0x77F1BEB8863288D5`
- **JHash:** `0xB2477B23`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_SCRIPT_TASK_STATUS(int ped, uint taskHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `taskHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Gets the status of a script-assigned task.
taskHash: https://alloc8or.re/gta5/doc/enums/eScriptTaskHash.txt
```

---

### GET_SEQUENCE_PROGRESS

- **命名空间:** `TASK`
- **Hash:** `0x00A9010CFE1E3533`
- **JHash:** `0xA3419909`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_SEQUENCE_PROGRESS(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
returned values:
0 to 7 = task that's currently in progress, 0 meaning the first one.
-1 no task sequence in progress.
```

---

### GET_TASK_MOVE_NETWORK_EVENT

- **命名空间:** `TASK`
- **Hash:** `0xB4F47213DF45A64C`
- **JHash:** `0x72FA5EF2`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_TASK_MOVE_NETWORK_EVENT(int ped, string eventName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `eventName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_TASK_MOVE_NETWORK_SIGNAL_BOOL

- **命名空间:** `TASK`
- **Hash:** `0xA7FFBA498E4AAF67`
- **JHash:** `0x1EBB6F3D`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_TASK_MOVE_NETWORK_SIGNAL_BOOL(int ped, string signalName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `signalName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_TASK_MOVE_NETWORK_SIGNAL_FLOAT

- **命名空间:** `TASK`
- **Hash:** `0x44AB0B3AFECCE242`
- **Build:** `1493`

**C# 签名:**
```csharp
float GET_TASK_MOVE_NETWORK_SIGNAL_FLOAT(int ped, string signalName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `signalName` | `const char*` | `string` | - |

**返回值:** `float` (Native: `float`)

---

### GET_TASK_MOVE_NETWORK_STATE

- **命名空间:** `TASK`
- **Hash:** `0x717E4D1F2048376D`
- **JHash:** `0x96C0277B`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_TASK_MOVE_NETWORK_STATE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `string` (Native: `const char*`)

---

### GET_TASK_RAPPEL_DOWN_WALL_STATE

- **命名空间:** `TASK`
- **Hash:** `0x9D252648778160DF`
- **Build:** `1868`

**C# 签名:**
```csharp
int GET_TASK_RAPPEL_DOWN_WALL_STATE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_VEHICLE_WAYPOINT_PROGRESS

- **命名空间:** `TASK`
- **Hash:** `0x9824CFF8FC66E159`
- **JHash:** `0xD3CCF64E`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_WAYPOINT_PROGRESS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_VEHICLE_WAYPOINT_TARGET_POINT

- **命名空间:** `TASK`
- **Hash:** `0x416B62AC8B9E5BBD`
- **JHash:** `0x81049608`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_WAYPOINT_TARGET_POINT(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_WAYPOINT_DISTANCE_ALONG_ROUTE

- **命名空间:** `TASK`
- **Hash:** `0xA5B769058763E497`
- **JHash:** `0xE8422AC4`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_WAYPOINT_DISTANCE_ALONG_ROUTE(string name, int point)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |
| `point` | `int` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### IS_CONTROLLED_VEHICLE_UNABLE_TO_GET_TO_ROAD

- **命名空间:** `TASK`
- **Hash:** `0x3E38E28A1D80DDF6`
- **JHash:** `0x54856309`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_CONTROLLED_VEHICLE_UNABLE_TO_GET_TO_ROAD(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK

- **命名空间:** `TASK`
- **Hash:** `0x8785E6E40C7A8818`
- **JHash:** `0xB23F46E6`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_MOUNTED_WEAPON_TASK_UNDERNEATH_DRIVING_TASK

- **命名空间:** `TASK`
- **Hash:** `0xA320EF046186FA3B`
- **JHash:** `0x291E938C`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_MOUNTED_WEAPON_TASK_UNDERNEATH_DRIVING_TASK(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_MOVE_BLEND_RATIO_RUNNING

- **命名空间:** `TASK`
- **Hash:** `0xD4D8636C0199A939`
- **JHash:** `0xE76A2353`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_MOVE_BLEND_RATIO_RUNNING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_MOVE_BLEND_RATIO_SPRINTING

- **命名空间:** `TASK`
- **Hash:** `0x24A2AD74FA9814E2`
- **JHash:** `0xDD616893`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_MOVE_BLEND_RATIO_SPRINTING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_MOVE_BLEND_RATIO_STILL

- **命名空间:** `TASK`
- **Hash:** `0x349CE7B56DAFD95C`
- **JHash:** `0xE9DAF877`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_MOVE_BLEND_RATIO_STILL(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_MOVE_BLEND_RATIO_WALKING

- **命名空间:** `TASK`
- **Hash:** `0xF133BBBE91E1691F`
- **JHash:** `0xD21639A8`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_MOVE_BLEND_RATIO_WALKING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

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

### IS_PED_ACTIVE_IN_SCENARIO

- **命名空间:** `TASK`
- **Hash:** `0xAA135F9482C82CC3`
- **JHash:** `0x05038F1A`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_ACTIVE_IN_SCENARIO(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_BEING_ARRESTED

- **命名空间:** `TASK`
- **Hash:** `0x90A09F3A45FED688`
- **JHash:** `0x5FF6C2ED`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_BEING_ARRESTED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
This function is hard-coded to always return 0.
```

---

### IS_PED_CUFFED

- **命名空间:** `TASK`
- **Hash:** `0x74E559B3BC910685`
- **JHash:** `0x511CE741`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_CUFFED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_GETTING_UP

- **命名空间:** `TASK`
- **Hash:** `0x2A74E1D5F2F00EEC`
- **JHash:** `0x320813E6`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_GETTING_UP(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_IN_WRITHE

- **命名空间:** `TASK`
- **Hash:** `0xDEB6D52126E7D640`
- **JHash:** `0x09E61921`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_IN_WRITHE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
This native checks if a ped is on the ground, in pain from a (gunshot) wound.
Returns `true` if the ped is in writhe, `false` otherwise.
```

---

### IS_PED_PLAYING_BASE_CLIP_IN_SCENARIO

- **命名空间:** `TASK`
- **Hash:** `0x621C6E4729388E41`
- **JHash:** `0xA0DA6B1D`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_PLAYING_BASE_CLIP_IN_SCENARIO(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Used only once (am_mp_property_int)

ped was PLAYER_PED_ID()

Related to CTaskAmbientClips.
```

---

### IS_PED_RUNNING

- **命名空间:** `TASK`
- **Hash:** `0xC5286FFC176F28A2`
- **JHash:** `0xE9A5578F`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_RUNNING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_RUNNING_ARREST_TASK

- **命名空间:** `TASK`
- **Hash:** `0x3DC52677769B4AE0`
- **JHash:** `0x6942DB7A`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_RUNNING_ARREST_TASK(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_SPRINTING

- **命名空间:** `TASK`
- **Hash:** `0x57E457CD2C0FC168`
- **JHash:** `0x4F3E0633`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_SPRINTING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_STILL

- **命名空间:** `TASK`
- **Hash:** `0xAC29253EEF8F0180`
- **JHash:** `0x09E3418D`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_STILL(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_STRAFING

- **命名空间:** `TASK`
- **Hash:** `0xE45B7F222DE47E09`
- **JHash:** `0xEFEED13C`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_STRAFING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_WALKING

- **命名空间:** `TASK`
- **Hash:** `0xDE4C184B2B9B071A`
- **JHash:** `0x4B865C4A`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_WALKING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PLAYING_PHONE_GESTURE_ANIM

- **命名空间:** `TASK`
- **Hash:** `0xB8EBB1E9D3588C10`
- **JHash:** `0x500B6805`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYING_PHONE_GESTURE_ANIM(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SCENARIO_GROUP_ENABLED

- **命名空间:** `TASK`
- **Hash:** `0x367A09DED4E05B99`
- **JHash:** `0x90991122`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SCENARIO_GROUP_ENABLED(string scenarioGroup)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scenarioGroup` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of scenario groups used in scripts by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/scenarioGroupNames.json
Occurrences in the b617d scripts: 

 "ARMY_GUARD",
 "ARMY_HELI",
 "BLIMP",
 "Cinema_Downtown",
 "Cinema_Morningwood",
 "Cinema_Textile",
 "City_Banks",
 "Countryside_Banks",
 "DEALERSHIP",
 "KORTZ_SECURITY",
 "LSA_Planes",
 "MP_POLICE",
 "Observatory_Bikers",
 "POLICE_POUND1",
 "POLICE_POUND2",
 "POLICE_POUND3",
 "POLICE_POUND4",
 "POLICE_POUND5",
 "Rampage1",
 "SANDY_PLANES",
 "SCRAP_SECURITY",
 "SEW_MACHINE",
 "SOLOMON_GATE"

Sometimes used with DOES_SCENARIO_GROUP_EXIST:
if (TASK::DOES_SCENARIO_GROUP_EXIST("Observatory_Bikers") &&   (!TASK::IS_SCENARIO_GROUP_ENABLED("Observatory_Bikers"))) {
else if (TASK::IS_SCENARIO_GROUP_ENABLED("BLIMP")) {
```

---

### IS_SCENARIO_OCCUPIED

- **命名空间:** `TASK`
- **Hash:** `0x788756D73AC2E07C`
- **JHash:** `0x697FC008`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SCENARIO_OCCUPIED(float x, float y, float z, float maxRange, bool onlyUsersActuallyAtScenario)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `maxRange` | `float` | `float` | - |
| `onlyUsersActuallyAtScenario` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SCENARIO_TYPE_ENABLED

- **命名空间:** `TASK`
- **Hash:** `0x3A815DB3EA088722`
- **JHash:** `0xAE37E969`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SCENARIO_TYPE_ENABLED(string scenarioType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scenarioType` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of scenario types used in scripts by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/scenariosCompact.json
Occurrences in the b617d scripts:
"PROP_HUMAN_SEAT_CHAIR",
"WORLD_HUMAN_DRINKING",
"WORLD_HUMAN_HANG_OUT_STREET",
"WORLD_HUMAN_SMOKING",
"WORLD_MOUNTAIN_LION_WANDER",
"WORLD_HUMAN_DRINKING"

Sometimes used together with MISC::IS_STRING_NULL_OR_EMPTY in the scripts.

scenarioType could be the same as scenarioName, used in for example TASK::TASK_START_SCENARIO_AT_POSITION.

```

---

### IS_TASK_MOVE_NETWORK_ACTIVE

- **命名空间:** `TASK`
- **Hash:** `0x921CE12C489C4C41`
- **JHash:** `0x902656EB`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_TASK_MOVE_NETWORK_ACTIVE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_TASK_MOVE_NETWORK_READY_FOR_TRANSITION

- **命名空间:** `TASK`
- **Hash:** `0x30ED88D5E0C56A37`
- **JHash:** `0x92FDBAE6`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_TASK_MOVE_NETWORK_READY_FOR_TRANSITION(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_PED

- **命名空间:** `TASK`
- **Hash:** `0xE03B3F2D3DC59B64`
- **JHash:** `0x85B7725F`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_PED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_VEHICLE

- **命名空间:** `TASK`
- **Hash:** `0xF5134943EA29868C`
- **JHash:** `0x80DD15DB`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_VEHICLE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

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

### OPEN_PATROL_ROUTE

- **命名空间:** `TASK`
- **Hash:** `0xA36BFB5EE89F3D82`
- **JHash:** `0xF33F83CA`
- **Build:** `323`

**C# 签名:**
```csharp
void OPEN_PATROL_ROUTE(string patrolRoute)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `patrolRoute` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
 patrolRoutes found in the b617d scripts:
 "miss_Ass0",
 "miss_Ass1",
 "miss_Ass2",
 "miss_Ass3",
 "miss_Ass4",
 "miss_Ass5",
 "miss_Ass6",
 "MISS_PATROL_6",
 "MISS_PATROL_7",
 "MISS_PATROL_8",
 "MISS_PATROL_9",
 "miss_Tower_01",
 "miss_Tower_02",
 "miss_Tower_03",
 "miss_Tower_04",
 "miss_Tower_05",
 "miss_Tower_06",
 "miss_Tower_07",
 "miss_Tower_08",
 "miss_Tower_10"
```

---

### OPEN_SEQUENCE_TASK

- **命名空间:** `TASK`
- **Hash:** `0xE8854A4326B9E12B`
- **JHash:** `0xABA6923E`
- **Build:** `323`

**C# 签名:**
```csharp
void OPEN_SEQUENCE_TASK(ref int taskSequenceId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `taskSequenceId` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

---

### PED_HAS_USE_SCENARIO_TASK

- **命名空间:** `TASK`
- **Hash:** `0x295E3CCEC879CCD7`
- **JHash:** `0x9BE9C691`
- **Build:** `323`

**C# 签名:**
```csharp
bool PED_HAS_USE_SCENARIO_TASK(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### PLAY_ANIM_ON_RUNNING_SCENARIO

- **命名空间:** `TASK`
- **Hash:** `0x748040460F8DF5DC`
- **JHash:** `0x1984A5D1`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_ANIM_ON_RUNNING_SCENARIO(int ped, string animDict, string animName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `animDict` | `const char*` | `string` | - |
| `animName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### PLAY_ENTITY_SCRIPTED_ANIM

- **命名空间:** `TASK`
- **Hash:** `0x77A1EEC547E7FCF1`
- **JHash:** `0x02F72AE5`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_ENTITY_SCRIPTED_ANIM(int entity, ref int priorityLowData, ref int priorityMidData, ref int priorityHighData, float blendInDelta, float blendOutDelta)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `priorityLowData` | `int*` | `ref int` | - |
| `priorityMidData` | `int*` | `ref int` | - |
| `priorityHighData` | `int*` | `ref int` | - |
| `blendInDelta` | `float` | `float` | - |
| `blendOutDelta` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

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

### REMOVE_ALL_COVER_BLOCKING_AREAS

- **命名空间:** `TASK`
- **Hash:** `0xDB6708C0B46F56D8`
- **JHash:** `0xCF9221A7`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_ALL_COVER_BLOCKING_AREAS()
```

**返回值:** `void` (Native: `void`)

---

### REMOVE_COVER_BLOCKING_AREAS_AT_POSITION

- **命名空间:** `TASK`
- **Hash:** `0xFA83CA6776038F64`
- **Build:** `1493`

**C# 签名:**
```csharp
void REMOVE_COVER_BLOCKING_AREAS_AT_POSITION(float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_COVER_POINT

- **命名空间:** `TASK`
- **Hash:** `0xAE287C923D891715`
- **JHash:** `0x0776888B`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_COVER_POINT(int coverpoint)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `coverpoint` | `ScrHandle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_SPECIFIC_COVER_BLOCKING_AREAS

- **命名空间:** `TASK`
- **Hash:** `0x1F351CF1C6475734`
- **Build:** `505`

**C# 签名:**
```csharp
void REMOVE_SPECIFIC_COVER_BLOCKING_AREAS(float startX, float startY, float startZ, float endX, float endY, float endZ, bool blockObjects, bool blockVehicles, bool blockMap, bool blockPlayer)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `startX` | `float` | `float` | - |
| `startY` | `float` | `float` | - |
| `startZ` | `float` | `float` | - |
| `endX` | `float` | `float` | - |
| `endY` | `float` | `float` | - |
| `endZ` | `float` | `float` | - |
| `blockObjects` | `BOOL` | `bool` | - |
| `blockVehicles` | `BOOL` | `bool` | - |
| `blockMap` | `BOOL` | `bool` | - |
| `blockPlayer` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_WAYPOINT_RECORDING

- **命名空间:** `TASK`
- **Hash:** `0xFF1B8B4AA1C25DC8`
- **JHash:** `0x624530B0`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_WAYPOINT_RECORDING(string name)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/waypointRecordings.json
```

---

### REQUEST_TASK_MOVE_NETWORK_STATE_TRANSITION

- **命名空间:** `TASK`
- **Hash:** `0xD01015C7316AE176`
- **JHash:** `0x885724DE`
- **Build:** `323`

**C# 签名:**
```csharp
bool REQUEST_TASK_MOVE_NETWORK_STATE_TRANSITION(int ped, string name)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `name` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### REQUEST_WAYPOINT_RECORDING

- **命名空间:** `TASK`
- **Hash:** `0x9EEFB62EB27B5792`
- **JHash:** `0xAFABFB5D`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_WAYPOINT_RECORDING(string name)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/waypointRecordings.json
For a full list of the points, see here: goo.gl/wIH0vn

Max number of loaded recordings is 32.
```

---

### RESET_EXCLUSIVE_SCENARIO_GROUP

- **命名空间:** `TASK`
- **Hash:** `0x4202BBCB8684563D`
- **JHash:** `0x17F9DFE8`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_EXCLUSIVE_SCENARIO_GROUP()
```

**返回值:** `void` (Native: `void`)

---

### RESET_SCENARIO_GROUPS_ENABLED

- **命名空间:** `TASK`
- **Hash:** `0xDD902D0349AFAD3A`
- **JHash:** `0xBF55025D`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_SCENARIO_GROUPS_ENABLED()
```

**返回值:** `void` (Native: `void`)

---

### RESET_SCENARIO_TYPES_ENABLED

- **命名空间:** `TASK`
- **Hash:** `0x0D40EE2A7F2B2D6D`
- **JHash:** `0xF58FDEB4`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_SCENARIO_TYPES_ENABLED()
```

**返回值:** `void` (Native: `void`)

---

### SET_ANIM_LOOPED

- **命名空间:** `TASK`
- **Hash:** `0x70033C3CC29A1FF4`
- **JHash:** `0x095D61A4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ANIM_LOOPED(int entity, bool looped, int priority, bool secondary)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `looped` | `BOOL` | `bool` | - |
| `priority` | `int` | `int` | - |
| `secondary` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ANIM_PHASE

- **命名空间:** `TASK`
- **Hash:** `0xDDF3CB5A0A4C0B49`
- **JHash:** `0xB621E7E4`
- **Build:** `2372`

**C# 签名:**
```csharp
void SET_ANIM_PHASE(int entity, float phase, int priority, bool secondary)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `phase` | `float` | `float` | - |
| `priority` | `int` | `int` | - |
| `secondary` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ANIM_RATE

- **命名空间:** `TASK`
- **Hash:** `0x032D49C5E359C847`
- **JHash:** `0x6DB46584`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ANIM_RATE(int entity, float rate, int priority, bool secondary)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `rate` | `float` | `float` | - |
| `priority` | `int` | `int` | - |
| `secondary` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ANIM_WEIGHT

- **命名空间:** `TASK`
- **Hash:** `0x207F1A47C0342F48`
- **JHash:** `0x17229D98`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ANIM_WEIGHT(int entity, float weight, int priority, int index, bool secondary)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `weight` | `float` | `float` | - |
| `priority` | `int` | `int` | - |
| `index` | `int` | `int` | - |
| `secondary` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DRIVEBY_TASK_TARGET

- **命名空间:** `TASK`
- **Hash:** `0xE5B302114D8162EE`
- **JHash:** `0xDA6A6FC1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DRIVEBY_TASK_TARGET(int shootingPed, int targetPed, int targetVehicle, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `shootingPed` | `Ped` | `int` | - |
| `targetPed` | `Ped` | `int` | - |
| `targetVehicle` | `Vehicle` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
For p1 & p2 (Ped, Vehicle). I could be wrong, as the only time this native is called in scripts is once and both are 0, but I assume this native will work like SET_MOUNTED_WEAPON_TARGET in which has the same exact amount of parameters and the 1st and last 3 parameters are right and the same for both natives.
```

---

### SET_DRIVE_TASK_CRUISE_SPEED

- **命名空间:** `TASK`
- **Hash:** `0x5C9B84BD7D31D908`
- **JHash:** `0x3CEC07B1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DRIVE_TASK_CRUISE_SPEED(int driver, float cruiseSpeed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `driver` | `Ped` | `int` | - |
| `cruiseSpeed` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DRIVE_TASK_DRIVING_STYLE

- **命名空间:** `TASK`
- **Hash:** `0xDACE1BE37D88AF67`
- **JHash:** `0x59C5FAD7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DRIVE_TASK_DRIVING_STYLE(int ped, int drivingStyle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `drivingStyle` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native is used to set the driving style for specific ped.

Driving styles id seems to be:
786468
262144
786469

http://gtaforums.com/topic/822314-guide-driving-styles/
```

---

### SET_DRIVE_TASK_MAX_CRUISE_SPEED

- **命名空间:** `TASK`
- **Hash:** `0x404A5AA9B9F0B746`
- **JHash:** `0x7FDF6131`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DRIVE_TASK_MAX_CRUISE_SPEED(int ped, float speed, bool updateBaseTask)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `speed` | `float` | `float` | - |
| `updateBaseTask` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_EXCLUSIVE_SCENARIO_GROUP

- **命名空间:** `TASK`
- **Hash:** `0x535E97E1F7FC0C6A`
- **JHash:** `0x59DB8F26`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_EXCLUSIVE_SCENARIO_GROUP(string scenarioGroup)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scenarioGroup` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of scenario groups used in scripts by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/scenarioGroupNames.json
Groups found in the scripts used with this native:

"AMMUNATION",
"QUARRY",
"Triathlon_1",
"Triathlon_2",
"Triathlon_3"
```

---

### SET_EXPECTED_CLONE_NEXT_TASK_MOVE_NETWORK_STATE

- **命名空间:** `TASK`
- **Hash:** `0xAB13A5565480B6D9`
- **JHash:** `0x1E58A7AD`
- **Build:** `323`

**C# 签名:**
```csharp
bool SET_EXPECTED_CLONE_NEXT_TASK_MOVE_NETWORK_STATE(int ped, string state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `state` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Used only once in the scripts (fm_mission_controller) like so:

TASK::SET_EXPECTED_CLONE_NEXT_TASK_MOVE_NETWORK_STATE(iLocal_3160, "Cutting");
```

---

### SET_GLOBAL_MIN_BIRD_FLIGHT_HEIGHT

- **命名空间:** `TASK`
- **Hash:** `0x6C6B148586F934F7`
- **JHash:** `0x2AFB14B8`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GLOBAL_MIN_BIRD_FLIGHT_HEIGHT(float height)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `height` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Needs to be looped! And yes, it does work and is not a hash collision.
Birds will try to reach the given height.
```

---

### SET_HIGH_FALL_TASK

- **命名空间:** `TASK`
- **Hash:** `0x8C825BDC7741D37C`
- **JHash:** `0xBBB26172`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_HIGH_FALL_TASK(int ped, int minTime, int maxTime, int entryType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `minTime` | `int` | `int` | - |
| `maxTime` | `int` | `int` | - |
| `entryType` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Makes the ped ragdoll like when falling from a great height
```

---

### SET_MOUNTED_WEAPON_TARGET

- **命名空间:** `TASK`
- **Hash:** `0xCCD892192C6D2BB9`
- **JHash:** `0x98713C68`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_MOUNTED_WEAPON_TARGET(int shootingPed, int targetPed, int targetVehicle, float x, float y, float z, int taskMode, bool ignoreTargetVehDeadCheck)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `shootingPed` | `Ped` | `int` | - |
| `targetPed` | `Ped` | `int` | - |
| `targetVehicle` | `Vehicle` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `taskMode` | `int` | `int` | - |
| `ignoreTargetVehDeadCheck` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Note: Look in decompiled scripts and the times that p1 and p2 aren't 0. They are filled with vars. If you look through out that script what other natives those vars are used in, you can tell p1 is a ped and p2 is a vehicle. Which most likely means if you want the mounted weapon to target a ped set targetVehicle to 0 or vice-versa.
```

---

### SET_NEXT_DESIRED_MOVE_STATE

- **命名空间:** `TASK`
- **Hash:** `0xF1B9F16E89E2C93A`
- **JHash:** `0x4E937D57`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_NEXT_DESIRED_MOVE_STATE(float nextMoveState)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `nextMoveState` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native does absolutely nothing, just a nullsub

R* Comment:
SET_NEXT_DESIRED_MOVE_STATE - Function is deprecated - do not use anymore
```

---

### SET_PARACHUTE_TASK_TARGET

- **命名空间:** `TASK`
- **Hash:** `0xC313379AF0FCEDA7`
- **JHash:** `0x6ED3AD81`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARACHUTE_TASK_TARGET(int ped, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PARACHUTE_TASK_THRUST

- **命名空间:** `TASK`
- **Hash:** `0x0729BAC1B8C64317`
- **JHash:** `0xD07C8AAA`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARACHUTE_TASK_THRUST(int ped, float thrust)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `thrust` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_PLAY_AMBIENT_IDLES

- **命名空间:** `TASK`
- **Hash:** `0x8FD89A6240813FD0`
- **JHash:** `0xB5AD044E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_PLAY_AMBIENT_IDLES(int ped, bool blockIdleClips, bool removeIdleClipIfPlaying)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `blockIdleClips` | `BOOL` | `bool` | - |
| `removeIdleClipIfPlaying` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Appears only in fm_mission_controller and used only 3 times.

ped was always PLAYER_PED_ID()
p1 was always true
p2 was always true
```

---

### SET_PED_DESIRED_MOVE_BLEND_RATIO

- **命名空间:** `TASK`
- **Hash:** `0x1E982AC8716912C5`
- **JHash:** `0xC65FC712`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_DESIRED_MOVE_BLEND_RATIO(int ped, float newMoveBlendRatio)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `newMoveBlendRatio` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_PATH_AVOID_FIRE

- **命名空间:** `TASK`
- **Hash:** `0x4455517B28441E60`
- **JHash:** `0xDCC5B934`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_PATH_AVOID_FIRE(int ped, bool avoidFire)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `avoidFire` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_PATH_CAN_DROP_FROM_HEIGHT

- **命名空间:** `TASK`
- **Hash:** `0xE361C5C71C431A4F`
- **JHash:** `0x394B7AC9`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_PATH_CAN_DROP_FROM_HEIGHT(int ped, bool Toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `Toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_PATH_CAN_USE_CLIMBOVERS

- **命名空间:** `TASK`
- **Hash:** `0x8E06A6FE76C9EFF4`
- **JHash:** `0xB7B7D442`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_PATH_CAN_USE_CLIMBOVERS(int ped, bool Toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `Toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_PATH_CAN_USE_LADDERS

- **命名空间:** `TASK`
- **Hash:** `0x77A5B103C87F476E`
- **JHash:** `0x53A879EE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_PATH_CAN_USE_LADDERS(int ped, bool Toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `Toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_PATH_CLIMB_COST_MODIFIER

- **命名空间:** `TASK`
- **Hash:** `0x88E32DB8C1A4AA4B`
- **JHash:** `0x55E06443`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_PATH_CLIMB_COST_MODIFIER(int ped, float modifier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `modifier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Default modifier is 1.0, minimum is 0.0 and maximum is 10.0.
```

---

### SET_PED_PATH_MAY_ENTER_WATER

- **命名空间:** `TASK`
- **Hash:** `0xF35425A4204367EC`
- **JHash:** `0x9C606EE3`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_PATH_MAY_ENTER_WATER(int ped, bool mayEnterWater)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `mayEnterWater` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_PATH_PREFER_TO_AVOID_WATER

- **命名空间:** `TASK`
- **Hash:** `0x38FE1EC73743793C`
- **JHash:** `0x0EA39A29`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_PATH_PREFER_TO_AVOID_WATER(int ped, bool avoidWater)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `avoidWater` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_WAYPOINT_PROGRESS

- **命名空间:** `TASK`
- **Hash:** `0x686ECCD99D4E61BB`
- **Build:** `3570`

**C# 签名:**
```csharp
void SET_PED_WAYPOINT_PROGRESS(int ped, int progress)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `progress` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_WAYPOINT_ROUTE_OFFSET

- **命名空间:** `TASK`
- **Hash:** `0xED98E10B0AFCE4B4`
- **JHash:** `0xF867F747`
- **Build:** `323`

**C# 签名:**
```csharp
bool SET_PED_WAYPOINT_ROUTE_OFFSET(int ped, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### SET_SCENARIO_GROUP_ENABLED

- **命名空间:** `TASK`
- **Hash:** `0x02C8E5B49848664E`
- **JHash:** `0x116997B1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SCENARIO_GROUP_ENABLED(string scenarioGroup, bool enabled)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scenarioGroup` | `const char*` | `string` | - |
| `enabled` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of scenario groups used in scripts by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/scenarioGroupNames.json
Occurrences in the b617d scripts: https://pastebin.com/Tvg2PRHU
```

---

### SET_SCENARIO_TYPE_ENABLED

- **命名空间:** `TASK`
- **Hash:** `0xEB47EC4E34FB7EE1`
- **JHash:** `0xDB18E5DE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SCENARIO_TYPE_ENABLED(string scenarioType, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scenarioType` | `const char*` | `string` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of scenario types used in scripts by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/scenariosCompact.json
seems to enable/disable specific scenario-types from happening in the game world.

Here are some scenario types from the scripts:
"WORLD_MOUNTAIN_LION_REST"                                             
"WORLD_MOUNTAIN_LION_WANDER"                                            
"DRIVE"                                                                  
"WORLD_VEHICLE_POLICE_BIKE"                                             
"WORLD_VEHICLE_POLICE_CAR"                                             
"WORLD_VEHICLE_POLICE_NEXT_TO_CAR"                                        
"WORLD_VEHICLE_DRIVE_SOLO"                                                 
"WORLD_VEHICLE_BIKER"                                                      
"WORLD_VEHICLE_DRIVE_PASSENGERS"                                           
"WORLD_VEHICLE_SALTON_DIRT_BIKE"                                           
"WORLD_VEHICLE_BICYCLE_MOUNTAIN"                                           
"PROP_HUMAN_SEAT_CHAIR"                                             
"WORLD_VEHICLE_ATTRACTOR"                                             
"WORLD_HUMAN_LEANING"                                                 
"WORLD_HUMAN_HANG_OUT_STREET"                                        
"WORLD_HUMAN_DRINKING"                                                
"WORLD_HUMAN_SMOKING"                                                
"WORLD_HUMAN_GUARD_STAND"                                            
"WORLD_HUMAN_CLIPBOARD"                                              
"WORLD_HUMAN_HIKER"                                                  
"WORLD_VEHICLE_EMPTY"                                                      
"WORLD_VEHICLE_BIKE_OFF_ROAD_RACE"                                      
"WORLD_HUMAN_PAPARAZZI"                                               
"WORLD_VEHICLE_PARK_PERPENDICULAR_NOSE_IN"                            
"WORLD_VEHICLE_PARK_PARALLEL"                                              
"WORLD_VEHICLE_CONSTRUCTION_SOLO"                               
"WORLD_VEHICLE_CONSTRUCTION_PASSENGERS"                                                                    
"WORLD_VEHICLE_TRUCK_LOGS"

scenarioType could be the same as scenarioName, used in for example TASK::TASK_START_SCENARIO_AT_POSITION.
```

---

### SET_SEQUENCE_PREVENT_MIGRATION

- **命名空间:** `TASK`
- **Hash:** `0xF5D1F489147CB683`
- **Build:** `3570`

**C# 签名:**
```csharp
void SET_SEQUENCE_PREVENT_MIGRATION(int taskSequenceId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `taskSequenceId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SEQUENCE_TO_REPEAT

- **命名空间:** `TASK`
- **Hash:** `0x58C70CF3A41E4AE7`
- **JHash:** `0xCDDF1508`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SEQUENCE_TO_REPEAT(int taskSequenceId, bool repeat)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `taskSequenceId` | `int` | `int` | - |
| `repeat` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TASK_MOVE_NETWORK_ANIM_SET

- **命名空间:** `TASK`
- **Hash:** `0x8423541E8B3A1589`
- **Build:** `1493`

**C# 签名:**
```csharp
void SET_TASK_MOVE_NETWORK_ANIM_SET(int ped, uint clipSet, uint variableClipSet)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `clipSet` | `Hash` | `uint` | - |
| `variableClipSet` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TASK_MOVE_NETWORK_ENABLE_COLLISION_ON_NETWORK_CLONE_WHEN_FIXED

- **命名空间:** `TASK`
- **Hash:** `0x0FFB3C758E8C07B9`
- **Build:** `2060`

**C# 签名:**
```csharp
bool SET_TASK_MOVE_NETWORK_ENABLE_COLLISION_ON_NETWORK_CLONE_WHEN_FIXED(int ped, bool enable)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `enable` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Doesn't actually return anything.
```

---

### SET_TASK_MOVE_NETWORK_SIGNAL_BOOL

- **命名空间:** `TASK`
- **Hash:** `0xB0A6CFD2C69C1088`
- **JHash:** `0xF3538041`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TASK_MOVE_NETWORK_SIGNAL_BOOL(int ped, string signalName, bool value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `signalName` | `const char*` | `string` | - |
| `value` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TASK_MOVE_NETWORK_SIGNAL_FLOAT

- **命名空间:** `TASK`
- **Hash:** `0xD5BB4025AE449A4E`
- **JHash:** `0xA79BE783`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TASK_MOVE_NETWORK_SIGNAL_FLOAT(int ped, string signalName, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `signalName` | `const char*` | `string` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
signalName - "Phase", "Wobble", "x_axis","y_axis","introphase","speed".
p2 - From what i can see it goes up to 1f (maybe).

Example: TASK::SET_TASK_MOVE_NETWORK_SIGNAL_FLOAT(PLAYER::PLAYER_PED_ID(), "Phase", 0.5);
```

---

### SET_TASK_MOVE_NETWORK_SIGNAL_FLOAT_LERP_RATE

- **命名空间:** `TASK`
- **Hash:** `0x8634CEF2522D987B`
- **Build:** `1493`

**C# 签名:**
```csharp
void SET_TASK_MOVE_NETWORK_SIGNAL_FLOAT_LERP_RATE(int ped, string signalName, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `signalName` | `const char*` | `string` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TASK_MOVE_NETWORK_SIGNAL_LOCAL_FLOAT

- **命名空间:** `TASK`
- **Hash:** `0x373EF409B82697A3`
- **Build:** `1493`

**C# 签名:**
```csharp
void SET_TASK_MOVE_NETWORK_SIGNAL_LOCAL_FLOAT(int ped, string signalName, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `signalName` | `const char*` | `string` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TASK_VEHICLE_CHASE_BEHAVIOR_FLAG

- **命名空间:** `TASK`
- **Hash:** `0xCC665AAC360D31E7`
- **JHash:** `0x2A83083F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TASK_VEHICLE_CHASE_BEHAVIOR_FLAG(int ped, int flag, bool set)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `flag` | `int` | `int` | - |
| `set` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Flag 8: Medium-aggressive boxing tactic with a bit of PIT
Flag 1: Aggressive ramming of suspect
Flag 2: Ram attempts
Flag 32: Stay back from suspect, no tactical contact. Convoy-like.
Flag 16: Ramming, seems to be slightly less aggressive than 1-2.
```

---

### SET_TASK_VEHICLE_CHASE_IDEAL_PURSUIT_DISTANCE

- **命名空间:** `TASK`
- **Hash:** `0x639B642FACBE4EDD`
- **JHash:** `0x04FD3EE7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TASK_VEHICLE_CHASE_IDEAL_PURSUIT_DISTANCE(int ped, float distance)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `distance` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### STOP_ANIM_PLAYBACK

- **命名空间:** `TASK`
- **Hash:** `0xEE08C992D238C5D1`
- **JHash:** `0xE5F16398`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_ANIM_PLAYBACK(int entity, int priority, bool secondary)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `priority` | `int` | `int` | - |
| `secondary` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Looks like p1 may be a flag, still need to do some research, though.
```

---

### STOP_ANIM_TASK

- **命名空间:** `TASK`
- **Hash:** `0x97FF36A1D40EA00A`
- **JHash:** `0x2B520A57`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_ANIM_TASK(int entity, string animDictionary, string animationName, float blendDelta)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `animDictionary` | `const char*` | `string` | - |
| `animationName` | `const char*` | `string` | - |
| `blendDelta` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### TASK_ACHIEVE_HEADING

- **命名空间:** `TASK`
- **Hash:** `0x93B93A37987F1F3D`
- **JHash:** `0x0A0E9B42`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_ACHIEVE_HEADING(int ped, float heading, int timeout)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `heading` | `float` | `float` | - |
| `timeout` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Makes the specified ped achieve the specified heading.

pedHandle: The handle of the ped to assign the task to.
heading: The desired heading.
timeout: The time, in milliseconds, to allow the task to complete. If the task times out, it is cancelled, and the ped will stay at the heading it managed to reach in the time.
```

---

### TASK_AGITATED_ACTION_CONFRONT_RESPONSE

- **命名空间:** `TASK`
- **Hash:** `0x19D1B791CB3670FE`
- **Build:** `877`

**C# 签名:**
```csharp
void TASK_AGITATED_ACTION_CONFRONT_RESPONSE(int ped, int ped2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `ped2` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_AIM_GUN_AT_COORD

- **命名空间:** `TASK`
- **Hash:** `0x6671F3EEC681BDA1`
- **JHash:** `0xFBF44AD3`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_AIM_GUN_AT_COORD(int ped, float x, float y, float z, int time, bool instantBlendToAim, bool playAnimIntro)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `time` | `int` | `int` | - |
| `instantBlendToAim` | `BOOL` | `bool` | - |
| `playAnimIntro` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_AIM_GUN_AT_ENTITY

- **命名空间:** `TASK`
- **Hash:** `0x9B53BB6E8943AF53`
- **JHash:** `0xBE32B3B6`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_AIM_GUN_AT_ENTITY(int ped, int entity, int duration, bool instantBlendToAim)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `entity` | `Entity` | `int` | - |
| `duration` | `int` | `int` | - |
| `instantBlendToAim` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
duration: the amount of time in milliseconds to do the task.  -1 will keep the task going until either another task is applied, or CLEAR_ALL_TASKS() is called with the ped
```

---

### TASK_AIM_GUN_SCRIPTED

- **命名空间:** `TASK`
- **Hash:** `0x7A192BE16D373D00`
- **JHash:** `0x9D296BCD`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_AIM_GUN_SCRIPTED(int ped, uint scriptTask, bool disableBlockingClip, bool instantBlendToAim)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `scriptTask` | `Hash` | `uint` | - |
| `disableBlockingClip` | `BOOL` | `bool` | - |
| `instantBlendToAim` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_AIM_GUN_SCRIPTED_WITH_TARGET

- **命名空间:** `TASK`
- **Hash:** `0x8605AF0DE8B3A5AC`
- **JHash:** `0xFD517CE3`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_AIM_GUN_SCRIPTED_WITH_TARGET(int ped, int target, float x, float y, float z, int gunTaskType, bool disableBlockingClip, bool forceAim)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `target` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `gunTaskType` | `int` | `int` | - |
| `disableBlockingClip` | `BOOL` | `bool` | - |
| `forceAim` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_ARREST_PED

- **命名空间:** `TASK`
- **Hash:** `0xF3B9A78A178572B1`
- **JHash:** `0xBC0F153D`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_ARREST_PED(int ped, int target)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `target` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Example from "me_amanda1.ysc.c4":
TASK::TASK_ARREST_PED(l_19F /* This is a Ped */ , PLAYER::PLAYER_PED_ID());

Example from "armenian1.ysc.c4":
if (!PED::IS_PED_INJURED(l_B18[0/*1*/])) {
    TASK::TASK_ARREST_PED(l_B18[0/*1*/], PLAYER::PLAYER_PED_ID());
}

I would love to have time to experiment to see if a player Ped can arrest another Ped. Might make for a good cop mod.


Looks like only the player can be arrested this way. Peds react and try to arrest you if you task them, but the player charater doesn't do anything if tasked to arrest another ped.
```

---

### TASK_BOAT_MISSION

- **命名空间:** `TASK`
- **Hash:** `0x15C86013127CE63F`
- **JHash:** `0x5865B031`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_BOAT_MISSION(int pedDriver, int vehicle, int targetVehicle, int targetPed, float x, float y, float z, int mission, float maxSpeed, int drivingStyle, float targetReached, object boatFlags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pedDriver` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `targetVehicle` | `Vehicle` | `int` | - |
| `targetPed` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `mission` | `int` | `int` | - |
| `maxSpeed` | `float` | `float` | - |
| `drivingStyle` | `int` | `int` | - |
| `targetReached` | `float` | `float` | - |
| `boatFlags` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
You need to call PED::SET_BLOCKING_OF_NON_TEMPORARY_EVENTS after TASK_BOAT_MISSION in order for the task to execute.

Working example
float vehicleMaxSpeed = VEHICLE::GET_VEHICLE_ESTIMATED_MAX_SPEED(ENTITY::GET_ENTITY_MODEL(pedVehicle));
TASK::TASK_BOAT_MISSION(pedDriver, pedVehicle, 0, 0, waypointCoord.x, waypointCoord.y, waypointCoord.z, 4, vehicleMaxSpeed, 786469, -1.0, 7);
PED::SET_BLOCKING_OF_NON_TEMPORARY_EVENTS(pedDriver, 1);

P8 appears to be driving style flag - see gtaforums.com/topic/822314-guide-driving-styles/ for documentation
```

---

### TASK_CHAT_TO_PED

- **命名空间:** `TASK`
- **Hash:** `0x8C338E0263E4FD19`
- **JHash:** `0xA2BE1821`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_CHAT_TO_PED(int ped, int target, int flags, float goToLocationX, float goToLocationY, float goToLocationZ, float headingDegs, float idleTime)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `target` | `Ped` | `int` | - |
| `flags` | `int` | `int` | - |
| `goToLocationX` | `float` | `float` | - |
| `goToLocationY` | `float` | `float` | - |
| `goToLocationZ` | `float` | `float` | - |
| `headingDegs` | `float` | `float` | - |
| `idleTime` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p2 tend to be 16, 17 or 1
p3 to p7 tend to be 0.0
```

---

### TASK_CLEAR_DEFENSIVE_AREA

- **命名空间:** `TASK`
- **Hash:** `0x95A6C46A31D1917D`
- **JHash:** `0x7A05BF0D`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_CLEAR_DEFENSIVE_AREA(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_CLEAR_LOOK_AT

- **命名空间:** `TASK`
- **Hash:** `0x0F804F1DB19B9689`
- **JHash:** `0x60EB4054`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_CLEAR_LOOK_AT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_CLIMB

- **命名空间:** `TASK`
- **Hash:** `0x89D9FCC2435112F1`
- **JHash:** `0x90847790`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_CLIMB(int ped, bool usePlayerLaunchForce)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `usePlayerLaunchForce` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Climbs or vaults the nearest thing.
usePlayerLaunchForce is unused.
```

---

### TASK_CLIMB_LADDER

- **命名空间:** `TASK`
- **Hash:** `0xB6C987F9285A3814`
- **JHash:** `0x35BB4EE0`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_CLIMB_LADDER(int ped, bool fast)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `fast` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_COMBAT_HATED_TARGETS_AROUND_PED

- **命名空间:** `TASK`
- **Hash:** `0x7BF835BB9E2698C8`
- **JHash:** `0x2E7064E4`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_COMBAT_HATED_TARGETS_AROUND_PED(int ped, float radius, int combatFlags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `radius` | `float` | `float` | - |
| `combatFlags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Despite its name, it only attacks ONE hated target. The one closest hated target.

p2 seems to be always 0
```

---

### TASK_COMBAT_HATED_TARGETS_AROUND_PED_TIMED

- **命名空间:** `TASK`
- **Hash:** `0x2BBA30B854534A0C`
- **JHash:** `0xF127AD6A`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_COMBAT_HATED_TARGETS_AROUND_PED_TIMED(int ped, float radius, int time, int combatFlags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `radius` | `float` | `float` | - |
| `time` | `int` | `int` | - |
| `combatFlags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_COMBAT_HATED_TARGETS_IN_AREA

- **命名空间:** `TASK`
- **Hash:** `0x4CF5F55DAC3280A0`
- **JHash:** `0xDF099E18`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_COMBAT_HATED_TARGETS_IN_AREA(int ped, float x, float y, float z, float radius, int combatFlags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `combatFlags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Despite its name, it only attacks ONE hated target. The one closest to the specified position.
```

---

### TASK_COMBAT_PED

- **命名空间:** `TASK`
- **Hash:** `0xF166E48407BAC484`
- **JHash:** `0xCB0D8932`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_COMBAT_PED(int ped, int targetPed, int combatFlags, int threatResponseFlags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `targetPed` | `Ped` | `int` | - |
| `combatFlags` | `int` | `int` | - |
| `threatResponseFlags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Makes the specified ped attack the target ped.
p2 should be 0
p3 should be 16
```

---

### TASK_COMBAT_PED_TIMED

- **命名空间:** `TASK`
- **Hash:** `0x944F30DCB7096BDE`
- **JHash:** `0xF5CA2A45`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_COMBAT_PED_TIMED(int ped, int target, int time, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `target` | `Ped` | `int` | - |
| `time` | `int` | `int` | - |
| `flags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_COWER

- **命名空间:** `TASK`
- **Hash:** `0x3EB1FE9E8E908E15`
- **JHash:** `0x9CF1C19B`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_COWER(int ped, int duration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `duration` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_DRIVE_BY

- **命名空间:** `TASK`
- **Hash:** `0x2F8AF0E82773A171`
- **JHash:** `0x2B84D1C4`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_DRIVE_BY(int driverPed, int targetPed, int targetVehicle, float targetX, float targetY, float targetZ, float distanceToShoot, int pedAccuracy, bool pushUnderneathDrivingTaskIfDriving, uint firingPattern)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `driverPed` | `Ped` | `int` | - |
| `targetPed` | `Ped` | `int` | - |
| `targetVehicle` | `Vehicle` | `int` | - |
| `targetX` | `float` | `float` | - |
| `targetY` | `float` | `float` | - |
| `targetZ` | `float` | `float` | - |
| `distanceToShoot` | `float` | `float` | - |
| `pedAccuracy` | `int` | `int` | - |
| `pushUnderneathDrivingTaskIfDriving` | `BOOL` | `bool` | - |
| `firingPattern` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Example:

TASK::TASK_DRIVE_BY(l_467[1/*22*/], PLAYER::PLAYER_PED_ID(), 0, 0.0, 0.0, 2.0, 300.0, 100, 0, ${firing_pattern_burst_fire_driveby});




Needs working example. Doesn't seem to do anything.

I marked p2 as targetVehicle as all these shooting related tasks seem to have that in common.
I marked p6 as distanceToShoot as if you think of GTA's Logic with the native SET_VEHICLE_SHOOT natives, it won't shoot till it gets within a certain distance of the target.
I marked p7 as pedAccuracy as it seems it's mostly 100 (Completely Accurate), 75, 90, etc. Although this could be the ammo count within the gun, but I highly doubt it. I will change this comment once I find out if it's ammo count or not.
```

---

### TASK_ENTER_VEHICLE

- **命名空间:** `TASK`
- **Hash:** `0xC20E50AA46D09CA8`
- **JHash:** `0xB8689B4E`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_ENTER_VEHICLE(int ped, int vehicle, int timeout, int seat, float speed, int flag, string overrideEntryClipsetName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `timeout` | `int` | `int` | - |
| `seat` | `int` | `int` | - |
| `speed` | `float` | `float` | - |
| `flag` | `int` | `int` | - |
| `overrideEntryClipsetName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
speed 1.0 = walk, 2.0 = run
p5 1 = normal, 3 = teleport to vehicle, 16 = teleport directly into vehicle
p6 is always 0

Usage of seat 
-1 = driver
0 = passenger
1 = left back seat
2 = right back seat
3 = outside left
4 = outside right
```

---

### TASK_EVERYONE_LEAVE_VEHICLE

- **命名空间:** `TASK`
- **Hash:** `0x7F93691AB4B92272`
- **JHash:** `0xC1971F30`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_EVERYONE_LEAVE_VEHICLE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_EXIT_COVER

- **命名空间:** `TASK`
- **Hash:** `0x79B258E397854D29`
- **JHash:** `0xC829FAC9`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_EXIT_COVER(int ped, int exitType, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `exitType` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 is 1, 2, or 3 in scripts
```

---

### TASK_EXTEND_ROUTE

- **命名空间:** `TASK`
- **Hash:** `0x1E7889778264843A`
- **JHash:** `0x43271F69`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_EXTEND_ROUTE(float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
MulleKD19: Adds a new point to the current point route. Call TASK_FLUSH_ROUTE before the first call to this. Call TASK_FOLLOW_POINT_ROUTE to make the Ped go the route.

A maximum of 8 points can be added.
```

---

### TASK_FLUSH_ROUTE

- **命名空间:** `TASK`
- **Hash:** `0x841142A1376E9006`
- **JHash:** `0x34219154`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_FLUSH_ROUTE()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
MulleKD19: Clears the current point route. Call this before TASK_EXTEND_ROUTE and TASK_FOLLOW_POINT_ROUTE.
```

---

### TASK_FOLLOW_NAV_MESH_TO_COORD

- **命名空间:** `TASK`
- **Hash:** `0x15D3A79D4E44B913`
- **JHash:** `0xFE4A10D9`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_FOLLOW_NAV_MESH_TO_COORD(int ped, float x, float y, float z, float moveBlendRatio, int time, float targetRadius, int flags, float targetHeading)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `moveBlendRatio` | `float` | `float` | - |
| `time` | `int` | `int` | - |
| `targetRadius` | `float` | `float` | - |
| `flags` | `int` | `int` | - |
| `targetHeading` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
If no timeout, set timeout to -1.
```

---

### TASK_FOLLOW_NAV_MESH_TO_COORD_ADVANCED

- **命名空间:** `TASK`
- **Hash:** `0x17F58B88D085DBAC`
- **JHash:** `0x6BF6E296`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_FOLLOW_NAV_MESH_TO_COORD_ADVANCED(int ped, float x, float y, float z, float moveBlendRatio, int time, float targetRadius, int flags, float slideToCoordHeading, float maxSlopeNavigable, float clampMaxSearchDistance, float targetHeading)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `moveBlendRatio` | `float` | `float` | - |
| `time` | `int` | `int` | - |
| `targetRadius` | `float` | `float` | - |
| `flags` | `int` | `int` | - |
| `slideToCoordHeading` | `float` | `float` | - |
| `maxSlopeNavigable` | `float` | `float` | - |
| `clampMaxSearchDistance` | `float` | `float` | - |
| `targetHeading` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_FOLLOW_POINT_ROUTE

- **命名空间:** `TASK`
- **Hash:** `0x595583281858626E`
- **JHash:** `0xB837C816`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_FOLLOW_POINT_ROUTE(int ped, float speed, int mode)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `speed` | `float` | `float` | - |
| `mode` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
MulleKD19: Makes the ped go on the created point route.

ped: The ped to give the task to.
speed: The speed to move at in m/s.
int: Unknown. Can be 0, 1, 2 or 3.

Example:
TASK_FLUSH_ROUTE();
TASK_EXTEND_ROUTE(0f, 0f, 70f);
TASK_EXTEND_ROUTE(10f, 0f, 70f);
TASK_EXTEND_ROUTE(10f, 10f, 70f);
TASK_FOLLOW_POINT_ROUTE(GET_PLAYER_PED(), 1f, 0);
```

---

### TASK_FOLLOW_TO_OFFSET_OF_ENTITY

- **命名空间:** `TASK`
- **Hash:** `0x304AE42E357B8C7E`
- **JHash:** `0x2DF5A6AC`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_FOLLOW_TO_OFFSET_OF_ENTITY(int ped, int entity, float offsetX, float offsetY, float offsetZ, float movementSpeed, int timeout, float stoppingRange, bool persistFollowing)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `entity` | `Entity` | `int` | - |
| `offsetX` | `float` | `float` | - |
| `offsetY` | `float` | `float` | - |
| `offsetZ` | `float` | `float` | - |
| `movementSpeed` | `float` | `float` | - |
| `timeout` | `int` | `int` | - |
| `stoppingRange` | `float` | `float` | - |
| `persistFollowing` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p6 always -1
p7 always 10.0
p8 always 1
```

---

### TASK_FOLLOW_WAYPOINT_RECORDING

- **命名空间:** `TASK`
- **Hash:** `0x0759591819534F7B`
- **JHash:** `0xADF9904D`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_FOLLOW_WAYPOINT_RECORDING(int ped, string name, int p2, int p3, int p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `name` | `const char*` | `string` | - |
| `p2` | `int` | `int` | - |
| `p3` | `int` | `int` | - |
| `p4` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_FORCE_MOTION_STATE

- **命名空间:** `TASK`
- **Hash:** `0x4F056E1AFFEF17AB`
- **JHash:** `0xCAD2EF77`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_FORCE_MOTION_STATE(int ped, uint state, bool forceRestart)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `state` | `Hash` | `uint` | - |
| `forceRestart` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p2 always false

[30/03/2017] ins1de :

See FORCE_PED_MOTION_STATE
```

---

### TASK_GET_OFF_BOAT

- **命名空间:** `TASK`
- **Hash:** `0x9C00E77AF14B2DFF`
- **JHash:** `0x4293601F`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_GET_OFF_BOAT(int ped, int boat)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `boat` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_GOTO_ENTITY_AIMING

- **命名空间:** `TASK`
- **Hash:** `0xA9DA48FAB8A76C12`
- **JHash:** `0xF1C493CF`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_GOTO_ENTITY_AIMING(int ped, int target, float distanceToStopAt, float StartAimingDist)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `target` | `Entity` | `int` | - |
| `distanceToStopAt` | `float` | `float` | - |
| `StartAimingDist` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
eg

 TASK::TASK_GOTO_ENTITY_AIMING(v_2, PLAYER::PLAYER_PED_ID(), 5.0, 25.0);

ped = Ped you want to perform this task.
target = the Entity they should aim at.
distanceToStopAt = distance from the target, where the ped should stop to aim.
StartAimingDist = distance where the ped should start to aim.
```

---

### TASK_GOTO_ENTITY_OFFSET

- **命名空间:** `TASK`
- **Hash:** `0xE39B4FF4FDEBDE27`
- **JHash:** `0x1A17A85E`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_GOTO_ENTITY_OFFSET(int ped, int entity, int time, float seekRadius, float seekAngleDeg, float moveBlendRatio, int gotoEntityOffsetFlags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `entity` | `Entity` | `int` | - |
| `time` | `int` | `int` | - |
| `seekRadius` | `float` | `float` | - |
| `seekAngleDeg` | `float` | `float` | - |
| `moveBlendRatio` | `float` | `float` | - |
| `gotoEntityOffsetFlags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
enum ESEEK_ENTITY_OFFSET_FLAGS
{
	ESEEK_OFFSET_ORIENTATES_WITH_ENTITY = 0x01,
	ESEEK_KEEP_TO_PAVEMENTS = 0x02
};
```

---

### TASK_GOTO_ENTITY_OFFSET_XY

- **命名空间:** `TASK`
- **Hash:** `0x338E7EF52B6095A9`
- **JHash:** `0xBC1E3D0A`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_GOTO_ENTITY_OFFSET_XY(int ped, int entity, int duration, float targetRadius, float offsetX, float offsetY, float moveBlendRatio, int gotoEntityOffsetFlags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `entity` | `Entity` | `int` | - |
| `duration` | `int` | `int` | - |
| `targetRadius` | `float` | `float` | - |
| `offsetX` | `float` | `float` | - |
| `offsetY` | `float` | `float` | - |
| `moveBlendRatio` | `float` | `float` | - |
| `gotoEntityOffsetFlags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_GO_STRAIGHT_TO_COORD

- **命名空间:** `TASK`
- **Hash:** `0xD76B57B44F1E6F8B`
- **JHash:** `0x80A9E7A7`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_GO_STRAIGHT_TO_COORD(int ped, float x, float y, float z, float speed, int timeout, float targetHeading, float distanceToSlide)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `speed` | `float` | `float` | - |
| `timeout` | `int` | `int` | - |
| `targetHeading` | `float` | `float` | - |
| `distanceToSlide` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_GO_STRAIGHT_TO_COORD_RELATIVE_TO_ENTITY

- **命名空间:** `TASK`
- **Hash:** `0x61E360B7E040D12E`
- **JHash:** `0xD26CAC68`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_GO_STRAIGHT_TO_COORD_RELATIVE_TO_ENTITY(int ped, int entity, float x, float y, float z, float moveBlendRatio, int time)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `entity` | `Entity` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `moveBlendRatio` | `float` | `float` | - |
| `time` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_GO_TO_COORD_AND_AIM_AT_HATED_ENTITIES_NEAR_COORD

- **命名空间:** `TASK`
- **Hash:** `0xA55547801EB331FC`
- **JHash:** `0x3F91358E`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_GO_TO_COORD_AND_AIM_AT_HATED_ENTITIES_NEAR_COORD(int pedHandle, float goToLocationX, float goToLocationY, float goToLocationZ, float focusLocationX, float focusLocationY, float focusLocationZ, float speed, bool shootAtEnemies, float distanceToStopAt, float noRoadsDistance, bool useNavMesh, int navFlags, int taskFlags, uint firingPattern)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pedHandle` | `Ped` | `int` | - |
| `goToLocationX` | `float` | `float` | - |
| `goToLocationY` | `float` | `float` | - |
| `goToLocationZ` | `float` | `float` | - |
| `focusLocationX` | `float` | `float` | - |
| `focusLocationY` | `float` | `float` | - |
| `focusLocationZ` | `float` | `float` | - |
| `speed` | `float` | `float` | - |
| `shootAtEnemies` | `BOOL` | `bool` | - |
| `distanceToStopAt` | `float` | `float` | - |
| `noRoadsDistance` | `float` | `float` | - |
| `useNavMesh` | `BOOL` | `bool` | - |
| `navFlags` | `int` | `int` | - |
| `taskFlags` | `int` | `int` | - |
| `firingPattern` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
The ped will walk or run towards goToLocation, aiming towards goToLocation or focusLocation (depending on the aimingFlag) and shooting if shootAtEnemies = true to any enemy in his path.

If the ped is closer than noRoadsDistance, the ped will ignore pathing/navmesh and go towards goToLocation directly. This could cause the ped to get stuck behind tall walls if the goToLocation is on the other side. To avoid this, use 0.0f and the ped will always use pathing/navmesh to reach his destination.

If the speed is set to 0.0f, the ped will just stand there while aiming, if set to 1.0f he will walk while aiming, 2.0f will run while aiming.

The ped will stop aiming when he is closer than distanceToStopAt to goToLocation.

I still can't figure out what unkTrue is used for. I don't notice any difference if I set it to false but in the decompiled scripts is always true.

I think that unkFlag, like the driving styles, could be a flag that "work as a list of 32 bits converted to a decimal integer. Each bit acts as a flag, and enables or disables a function". What leads me to this conclusion is the fact that in the decompiled scripts, unkFlag takes values like: 0, 1, 5 (101 in binary) and 4097 (4096 + 1 or 1000000000001 in binary). For now, I don't know what behavior enable or disable this possible flag so I leave it at 0.

Note: After some testing, using unkFlag = 16 (0x10) enables the use of sidewalks while moving towards goToLocation.

The aimingFlag takes 2 values: 0 to aim at the focusLocation, 1 to aim at where the ped is heading (goToLocation).

Example:

enum AimFlag
{
   AimAtFocusLocation,
   AimAtGoToLocation
};

Vector3 goToLocation1 = { 996.2867f, 0, -2143.044f, 0, 28.4763f, 0 }; // remember the padding.

Vector3 goToLocation2 = { 990.2867f, 0, -2140.044f, 0, 28.4763f, 0 }; // remember the padding.

Vector3 focusLocation = { 994.3478f, 0, -2136.118f, 0, 29.2463f, 0 }; // the coord z should be a little higher, around +1.0f to avoid aiming at the ground

// 1st example
TASK::TASK_GO_TO_COORD_AND_AIM_AT_HATED_ENTITIES_NEAR_COORD(pedHandle, goToLocation1.x, goToLocation1.y, goToLocation1.z, focusLocation.x, focusLocation.y, focusLocation.z, 2.0f /*run*/, true /*shoot*/, 3.0f /*stop at*/, 0.0f /*noRoadsDistance*/, true /*always true*/, 0 /*possible flag*/, AimFlag::AimAtGoToLocation, -957453492 /*FullAuto pattern*/);

// 2nd example
TASK::TASK_GO_TO_COORD_AND_AIM_AT_HATED_ENTITIES_NEAR_COORD(pedHandle, goToLocation2.x, goToLocation2.y, goToLocation2.z, focusLocation.x, focusLocation.y, focusLocation.z, 1.0f /*walk*/, false /*don't shoot*/, 3.0f /*stop at*/, 0.0f /*noRoadsDistance*/, true /*always true*/, 0 /*possible flag*/, AimFlag::AimAtFocusLocation, -957453492 /*FullAuto pattern*/);


1st example: The ped (pedhandle) will run towards goToLocation1. While running and aiming towards goToLocation1, the ped will shoot on sight to any enemy in his path, using "FullAuto" firing pattern. The ped will stop once he is closer than distanceToStopAt to goToLocation1.

2nd example: The ped will walk towards goToLocation2. This time, while walking towards goToLocation2 and aiming at focusLocation, the ped will point his weapon on sight to any enemy in his path without shooting. The ped will stop once he is closer than distanceToStopAt to goToLocation2.
```

---

### TASK_GO_TO_COORD_ANY_MEANS

- **命名空间:** `TASK`
- **Hash:** `0x5BC448CB78FA3E88`
- **JHash:** `0xF91DF93B`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_GO_TO_COORD_ANY_MEANS(int ped, float x, float y, float z, float moveBlendRatio, int vehicle, bool useLongRangeVehiclePathing, int drivingFlags, float maxRangeToShootTargets)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `moveBlendRatio` | `float` | `float` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `useLongRangeVehiclePathing` | `BOOL` | `bool` | - |
| `drivingFlags` | `int` | `int` | - |
| `maxRangeToShootTargets` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
example from fm_mission_controller

TASK::TASK_GO_TO_COORD_ANY_MEANS(l_649, sub_f7e86(-1, 0), 1.0, 0, 0, 786603, 0xbf800000);
 
```

---

### TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS

- **命名空间:** `TASK`
- **Hash:** `0x1DD45F9ECFDB1BC9`
- **JHash:** `0x094B75EF`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS(int ped, float x, float y, float z, float moveBlendRatio, int vehicle, bool useLongRangeVehiclePathing, int drivingFlags, float maxRangeToShootTargets, float extraVehToTargetDistToPreferVehicle, float driveStraightLineDistance, int extraFlags, float warpTimerMS)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `moveBlendRatio` | `float` | `float` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `useLongRangeVehiclePathing` | `BOOL` | `bool` | - |
| `drivingFlags` | `int` | `int` | - |
| `maxRangeToShootTargets` | `float` | `float` | - |
| `extraVehToTargetDistToPreferVehicle` | `float` | `float` | - |
| `driveStraightLineDistance` | `float` | `float` | - |
| `extraFlags` | `int` | `int` | - |
| `warpTimerMS` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS_WITH_CRUISE_SPEED

- **命名空间:** `TASK`
- **Hash:** `0xB8ECD61F531A7B02`
- **JHash:** `0x86DC03F9`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS_WITH_CRUISE_SPEED(int ped, float x, float y, float z, float moveBlendRatio, int vehicle, bool useLongRangeVehiclePathing, int drivingFlags, float maxRangeToShootTargets, float extraVehToTargetDistToPreferVehicle, float driveStraightLineDistance, int extraFlags, float cruiseSpeed, float targetArriveDist)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `moveBlendRatio` | `float` | `float` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `useLongRangeVehiclePathing` | `BOOL` | `bool` | - |
| `drivingFlags` | `int` | `int` | - |
| `maxRangeToShootTargets` | `float` | `float` | - |
| `extraVehToTargetDistToPreferVehicle` | `float` | `float` | - |
| `driveStraightLineDistance` | `float` | `float` | - |
| `extraFlags` | `int` | `int` | - |
| `cruiseSpeed` | `float` | `float` | - |
| `targetArriveDist` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_GO_TO_COORD_WHILE_AIMING_AT_COORD

- **命名空间:** `TASK`
- **Hash:** `0x11315AB3385B8AC0`
- **JHash:** `0x1552DC91`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_GO_TO_COORD_WHILE_AIMING_AT_COORD(int ped, float x, float y, float z, float aimAtX, float aimAtY, float aimAtZ, float moveBlendRatio, bool shoot, float targetRadius, float slowDistance, bool useNavMesh, int navFlags, bool instantBlendToAim, uint firingPattern)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `aimAtX` | `float` | `float` | - |
| `aimAtY` | `float` | `float` | - |
| `aimAtZ` | `float` | `float` | - |
| `moveBlendRatio` | `float` | `float` | - |
| `shoot` | `BOOL` | `bool` | - |
| `targetRadius` | `float` | `float` | - |
| `slowDistance` | `float` | `float` | - |
| `useNavMesh` | `BOOL` | `bool` | - |
| `navFlags` | `int` | `int` | - |
| `instantBlendToAim` | `BOOL` | `bool` | - |
| `firingPattern` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
movement_speed: mostly 2f, but also 1/1.2f, etc.
p8: always false
p9: 2f
p10: 0.5f
p11: true
p12: 0 / 512 / 513, etc.
p13: 0
firing_pattern: ${firing_pattern_full_auto}, 0xC6EE6B4C
```

---

### TASK_GO_TO_COORD_WHILE_AIMING_AT_ENTITY

- **命名空间:** `TASK`
- **Hash:** `0xB2A16444EAD9AE47`
- **JHash:** `0x9BD52ABD`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_GO_TO_COORD_WHILE_AIMING_AT_ENTITY(int ped, float x, float y, float z, int aimAtID, float moveBlendRatio, bool shoot, float targetRadius, float slowDistance, bool useNavMesh, int navFlags, bool instantBlendToAim, uint firingPattern, int time)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `aimAtID` | `Entity` | `int` | - |
| `moveBlendRatio` | `float` | `float` | - |
| `shoot` | `BOOL` | `bool` | - |
| `targetRadius` | `float` | `float` | - |
| `slowDistance` | `float` | `float` | - |
| `useNavMesh` | `BOOL` | `bool` | - |
| `navFlags` | `int` | `int` | - |
| `instantBlendToAim` | `BOOL` | `bool` | - |
| `firingPattern` | `Hash` | `uint` | - |
| `time` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_GO_TO_ENTITY

- **命名空间:** `TASK`
- **Hash:** `0x6A071245EB0D1882`
- **JHash:** `0x374827C2`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_GO_TO_ENTITY(int entity, int target, int duration, float distance, float moveBlendRatio, float slowDownDistance, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `target` | `Entity` | `int` | - |
| `duration` | `int` | `int` | - |
| `distance` | `float` | `float` | - |
| `moveBlendRatio` | `float` | `float` | - |
| `slowDownDistance` | `float` | `float` | - |
| `flags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
The entity will move towards the target until time is over (duration) or get in target's range (distance). p5 and p6 are unknown, but you could leave p5 = 1073741824 or 100 or even 0 (didn't see any difference but on the decompiled scripts, they use 1073741824 mostly) and p6 = 0

Note: I've only tested it on entity -> ped and target -> vehicle. It could work differently on other entities, didn't try it yet.

Example: TASK::TASK_GO_TO_ENTITY(pedHandle, vehicleHandle, 5000, 4.0, 100, 1073741824, 0)

Ped will run towards the vehicle for 5 seconds and stop when time is over or when he gets 4 meters(?) around the vehicle (with duration = -1, the task duration will be ignored).

enum EGOTO_ENTITY_SCRIPT_FLAGS
{
	EGOTO_ENTITY_NEVER_SLOW_FOR_PATH_LENGTH = 0x01,
};
```

---

### TASK_GO_TO_ENTITY_WHILE_AIMING_AT_COORD

- **命名空间:** `TASK`
- **Hash:** `0x04701832B739DCE5`
- **JHash:** `0xD896CD82`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_GO_TO_ENTITY_WHILE_AIMING_AT_COORD(int ped, int entity, float aimX, float aimY, float aimZ, float moveBlendRatio, bool shoot, float targetRadius, float slowDistance, bool useNavMesh, bool instantBlendToAim, uint firingPattern)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `entity` | `Entity` | `int` | - |
| `aimX` | `float` | `float` | - |
| `aimY` | `float` | `float` | - |
| `aimZ` | `float` | `float` | - |
| `moveBlendRatio` | `float` | `float` | - |
| `shoot` | `BOOL` | `bool` | - |
| `targetRadius` | `float` | `float` | - |
| `slowDistance` | `float` | `float` | - |
| `useNavMesh` | `BOOL` | `bool` | - |
| `instantBlendToAim` | `BOOL` | `bool` | - |
| `firingPattern` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_GO_TO_ENTITY_WHILE_AIMING_AT_ENTITY

- **命名空间:** `TASK`
- **Hash:** `0x97465886D35210E9`
- **JHash:** `0x68E36B7A`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_GO_TO_ENTITY_WHILE_AIMING_AT_ENTITY(int ped, int entityToWalkTo, int entityToAimAt, float speed, bool shootatEntity, float targetRadius, float slowDistance, bool useNavMesh, bool instantBlendToAim, uint firingPattern)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `entityToWalkTo` | `Entity` | `int` | - |
| `entityToAimAt` | `Entity` | `int` | - |
| `speed` | `float` | `float` | - |
| `shootatEntity` | `BOOL` | `bool` | - |
| `targetRadius` | `float` | `float` | - |
| `slowDistance` | `float` | `float` | - |
| `useNavMesh` | `BOOL` | `bool` | - |
| `instantBlendToAim` | `BOOL` | `bool` | - |
| `firingPattern` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
shootatEntity:
If true, peds will shoot at Entity till it is dead.
If false, peds will just walk till they reach the entity and will cease shooting.
```

---

### TASK_GUARD_ASSIGNED_DEFENSIVE_AREA

- **命名空间:** `TASK`
- **Hash:** `0xD2A207EEBDF9889B`
- **JHash:** `0x7AF0133D`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_GUARD_ASSIGNED_DEFENSIVE_AREA(int ped, float x, float y, float z, float heading, float maxPatrolProximity, int timer)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `heading` | `float` | `float` | - |
| `maxPatrolProximity` | `float` | `float` | - |
| `timer` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_GUARD_CURRENT_POSITION

- **命名空间:** `TASK`
- **Hash:** `0x4A58A47A72E3FCB4`
- **JHash:** `0x2FB099E9`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_GUARD_CURRENT_POSITION(int ped, float maxPatrolProximity, float defensiveAreaRadius, bool setDefensiveArea)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `maxPatrolProximity` | `float` | `float` | - |
| `defensiveAreaRadius` | `float` | `float` | - |
| `setDefensiveArea` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
From re_prisonvanbreak:

TASK::TASK_GUARD_CURRENT_POSITION(l_DD, 35.0, 35.0, 1);
```

---

### TASK_GUARD_SPHERE_DEFENSIVE_AREA

- **命名空间:** `TASK`
- **Hash:** `0xC946FE14BE0EB5E2`
- **JHash:** `0x86B76CB7`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_GUARD_SPHERE_DEFENSIVE_AREA(int ped, float defendPositionX, float defendPositionY, float defendPositionZ, float heading, float maxPatrolProximity, int time, float x, float y, float z, float defensiveAreaRadius)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `defendPositionX` | `float` | `float` | - |
| `defendPositionY` | `float` | `float` | - |
| `defendPositionZ` | `float` | `float` | - |
| `heading` | `float` | `float` | - |
| `maxPatrolProximity` | `float` | `float` | - |
| `time` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `defensiveAreaRadius` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_HANDS_UP

- **命名空间:** `TASK`
- **Hash:** `0xF2EAB31979A7F910`
- **JHash:** `0x8DCC19C5`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_HANDS_UP(int ped, int duration, int facingPed, int timeToFacePed, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `duration` | `int` | `int` | - |
| `facingPed` | `Ped` | `int` | - |
| `timeToFacePed` | `int` | `int` | - |
| `flags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
In the scripts, p3 was always -1.

p3 seems to be duration or timeout of turn animation.
Also facingPed can be 0 or -1 so ped will just raise hands up.
```

---

### TASK_HELI_CHASE

- **命名空间:** `TASK`
- **Hash:** `0xAC83B1DB38D0ADA0`
- **JHash:** `0xAC290A21`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_HELI_CHASE(int pilot, int entityToFollow, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pilot` | `Ped` | `int` | - |
| `entityToFollow` | `Entity` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Ped pilot should be in a heli.
EntityToFollow can be a vehicle or Ped.

x,y,z appear to be how close to the EntityToFollow the heli should be. Scripts use 0.0, 0.0, 80.0. Then the heli tries to position itself 80 units above the EntityToFollow. If you reduce it to -5.0, it tries to go below (if the EntityToFollow is a heli or plane)


NOTE: If the pilot finds enemies, it will engage them, then remain there idle, not continuing to chase the Entity given.
```

---

### TASK_HELI_ESCORT_HELI

- **命名空间:** `TASK`
- **Hash:** `0xB385523325077210`
- **Build:** `1290`

**C# 签名:**
```csharp
void TASK_HELI_ESCORT_HELI(int pilot, int heli1, int heli2, float offsetX, float offsetY, float offsetZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pilot` | `Ped` | `int` | - |
| `heli1` | `Vehicle` | `int` | - |
| `heli2` | `Vehicle` | `int` | - |
| `offsetX` | `float` | `float` | - |
| `offsetY` | `float` | `float` | - |
| `offsetZ` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_HELI_MISSION

- **命名空间:** `TASK`
- **Hash:** `0xDAD029E187A2BEB4`
- **JHash:** `0x0C143E97`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_HELI_MISSION(int pilot, int aircraft, int targetVehicle, int targetPed, float destinationX, float destinationY, float destinationZ, int missionFlag, float maxSpeed, float radius, float targetHeading, int maxHeight, int minHeight, float slowDownDistance, int behaviorFlags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pilot` | `Ped` | `int` | - |
| `aircraft` | `Vehicle` | `int` | - |
| `targetVehicle` | `Vehicle` | `int` | - |
| `targetPed` | `Ped` | `int` | - |
| `destinationX` | `float` | `float` | - |
| `destinationY` | `float` | `float` | - |
| `destinationZ` | `float` | `float` | - |
| `missionFlag` | `int` | `int` | - |
| `maxSpeed` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `targetHeading` | `float` | `float` | - |
| `maxHeight` | `int` | `int` | - |
| `minHeight` | `int` | `int` | - |
| `slowDownDistance` | `float` | `float` | - |
| `behaviorFlags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Must have targetVehicle, targetPed, OR destination X/Y/Z set
Will follow targeted vehicle/ped, or fly to destination
Set whichever is not being used to 0


Mission mode type:
 - 4, 7: Forces heli to snap to the heading if set, flies to destination or tracks specified entity (mode 4 only works for coordinates, 7 works for coordinates OR ped/vehicle)
 - 6: Attacks the target ped/vehicle with mounted weapons. If radius is set, will maintain that distance from target.
 - 8: Makes the heli flee from the ped/vehicle/coordinate
 - 9: Circles around target ped/vehicle, snaps to angle if set. Behavior flag (last parameter) of 2048 switches from counter-clockwise to clockwise circling. Does not work with coordinate destination.
 - 10, 11: Follows ped/vehicle target and imitates target heading. Only works with ped/vehicle target, not coord target
 - 19: Heli lands at specified coordinate, ignores heading (lands facing whatever direction it is facing when the task is started)
 - 20: Makes the heli land when near target ped. It won't resume chasing.
 - 21: Emulates a helicopter crash
 - 23: makes the heli circle erratically around ped


Heli will fly at maxSpeed (up to actual maximum speed defined by the model's handling config)
You can use SET_DRIVE_TASK_CRUISE_SPEED to modulate the speed based on distance to the target without having to re-invoke the task native. Setting to 8.0 when close to the destination results in a much smoother approach.

If minHeight and maxHeight are set, heli will fly between those specified elevations, relative to ground level and any obstructions/buildings below. You can specify -1 for either if you only want to specify one. Usually it is easiest to leave maxHeight at -1, and specify a reasonable minHeight to ensure clearance over any obstacles. Note this MUST be passed as an INT, not a FLOAT. 

Radius affects how closely the heli will follow tracked ped/vehicle, and when circling (mission type 9) sets the radius (in meters) that it will circle the target from

Heading is -1.0 for default behavior, which will point the nose of the helicopter towards the destination. Set a heading and the heli will lock to that direction when near its destination/target, but may still turn towards the destination when flying at higher speed from a further distance.

Behavior Flags is a bitwise value that modifies the AI behavior. Not clear what all flags do, but here are some guesses/notes:
   1: Forces heading to face E
   2: Unknown
   4: Tight circles around coordinate destination
   8: Unknown
  16: Circles around coordinate destination facing towards destination
  32: Flys to normally, then lands at coordinate destination and stays on the ground (using mission type 4)
  64: Ignores obstacles when flying, will follow at specified minHeight above ground level but will not avoid buildings, vehicles, etc.
 128: Unknown
 256: Unknown
 512: Unknown
1024: Unknown 
2048: Reverses direction of circling (mission type 9) to clockwise
4096: Hugs closer to the ground, maintains minHeight from ground generally, but barely clears buildings and dips down more between buildings instead of taking a more efficient/safe route
8192: Unknown

Unk3 is a float value, you may see -1082130432 for this value in decompiled native scripts, this is the equivalent to -1.0f. Seems to affect acceleration/aggressiveness, but not sure exactly how it works. Higher value seems to result in lower acceleration/less aggressive flying. Almost always -1.0 in native scripts, occasionally 20.0 or 50.0. Setting to 400.0 seems to work well for making the pilot not overshoot the destination when using coordinate destination.

Notes updated by PNWParksFan, May 2021

```

---

### TASK_JUMP

- **命名空间:** `TASK`
- **Hash:** `0x0AE4086104E067B1`
- **JHash:** `0x0356E3CE`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_JUMP(int ped, bool usePlayerLaunchForce, bool doSuperJump, bool useFullSuperJumpForce)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `usePlayerLaunchForce` | `BOOL` | `bool` | - |
| `doSuperJump` | `BOOL` | `bool` | - |
| `useFullSuperJumpForce` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Definition is wrong. This has 4 parameters (Not sure when they were added. v350 has 2, v678 has 4).

v350: Ped ped, bool unused
v678: Ped ped, bool unused, bool flag1, bool flag2

flag1 = super jump, flag2 = do nothing if flag1 is false and doubles super jump height if flag1 is true.
```

---

### TASK_LEAVE_ANY_VEHICLE

- **命名空间:** `TASK`
- **Hash:** `0x504D54DF3F6F2247`
- **JHash:** `0xDBDD79FA`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_LEAVE_ANY_VEHICLE(int ped, int delayTime, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `delayTime` | `int` | `int` | - |
| `flags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Flags are the same flags used in TASK_LEAVE_VEHICLE
```

---

### TASK_LEAVE_VEHICLE

- **命名空间:** `TASK`
- **Hash:** `0xD3DBCE61A490BE02`
- **JHash:** `0x7B1141C6`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_LEAVE_VEHICLE(int ped, int vehicle, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `flags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Flags from decompiled scripts:
0 = normal exit and closes door.
1 = normal exit and closes door.
16 = teleports outside, door kept closed.
64 = normal exit and closes door, maybe a bit slower animation than 0.
256 = normal exit but does not close the door.
4160 = ped is throwing himself out, even when the vehicle is still.
262144 = ped moves to passenger seat first, then exits normally

Others to be tried out: 320, 512, 131072.
```

---

### TASK_LOOK_AT_COORD

- **命名空间:** `TASK`
- **Hash:** `0x6FA46612594F7973`
- **JHash:** `0x7B784DD8`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_LOOK_AT_COORD(int entity, float x, float y, float z, int duration, int flags, int priority)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `duration` | `int` | `int` | - |
| `flags` | `int` | `int` | - |
| `priority` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
enum eScriptLookatFlags
{
	SLF_SLOW_TURN_RATE            = 1,    // turn the head toward the target slowly
	SLF_FAST_TURN_RATE            = 2,    // turn the head toward the target quickly
	SLF_EXTEND_YAW_LIMIT        = 4,    // wide yaw head limits
	SLF_EXTEND_PITCH_LIMIT        = 8,    // wide pitch head limit
	SLF_WIDEST_YAW_LIMIT        = 16,   // widest yaw head limit
	SLF_WIDEST_PITCH_LIMIT        = 32,   // widest pitch head limit
	SLF_NARROW_YAW_LIMIT        = 64,   // narrow yaw head limits
	SLF_NARROW_PITCH_LIMIT        = 128,  // narrow pitch head limit
	SLF_NARROWEST_YAW_LIMIT        = 256,  // narrowest yaw head limit
	SLF_NARROWEST_PITCH_LIMIT    = 512,  // narrowest pitch head limit
	SLF_USE_TORSO                = 1024, // use the torso aswell as the neck and head (currently disabled)
	SLF_WHILE_NOT_IN_FOV        = 2048, // keep tracking the target even if they are not in the hard coded FOV
	SLF_USE_CAMERA_FOCUS        = 4096, // use the camera as the target
	SLF_USE_EYES_ONLY            = 8192, // only track the target with the eyes  
	SLF_USE_LOOK_DIR            = 16384, // use information in look dir DOF
	SLF_FROM_SCRIPT                = 32768, // internal use only
	SLF_USE_REF_DIR_ABSOLUTE    = 65536  // use absolute reference direction mode for solver
};
```

---

### TASK_LOOK_AT_ENTITY

- **命名空间:** `TASK`
- **Hash:** `0x69F4BE8C8CC4796C`
- **JHash:** `0x991D6619`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_LOOK_AT_ENTITY(int ped, int lookAt, int duration, int flags, int priority)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `lookAt` | `Entity` | `int` | - |
| `duration` | `int` | `int` | - |
| `flags` | `int` | `int` | - |
| `priority` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
For flags, please refer to TASK_LOOK_AT_COORD.
```

---

### TASK_MOVE_NETWORK_ADVANCED_BY_NAME

- **命名空间:** `TASK`
- **Hash:** `0xD5B35BEA41919ACB`
- **JHash:** `0x71A5C5DB`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_MOVE_NETWORK_ADVANCED_BY_NAME(int ped, string network, float x, float y, float z, float rotX, float rotY, float rotZ, int rotOrder, float blendDuration, bool allowOverrideCloneUpdate, string animDict, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `network` | `const char*` | `string` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `rotX` | `float` | `float` | - |
| `rotY` | `float` | `float` | - |
| `rotZ` | `float` | `float` | - |
| `rotOrder` | `int` | `int` | - |
| `blendDuration` | `float` | `float` | - |
| `allowOverrideCloneUpdate` | `BOOL` | `bool` | - |
| `animDict` | `const char*` | `string` | - |
| `flags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Example:
TASK::TASK_MOVE_NETWORK_ADVANCED_BY_NAME(PLAYER::PLAYER_PED_ID(), "minigame_tattoo_michael_parts", 324.13f, 181.29f, 102.6f, 0.0f, 0.0f, 22.32f, 2, 0, false, 0, 0);
```

---

### TASK_MOVE_NETWORK_ADVANCED_BY_NAME_WITH_INIT_PARAMS

- **命名空间:** `TASK`
- **Hash:** `0x29682E2CCF21E9B5`
- **Build:** `1868`

**C# 签名:**
```csharp
void TASK_MOVE_NETWORK_ADVANCED_BY_NAME_WITH_INIT_PARAMS(int ped, string network, ref int initialParameters, float x, float y, float z, float rotX, float rotY, float rotZ, int rotOrder, float blendDuration, bool allowOverrideCloneUpdate, string dictionary, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `network` | `const char*` | `string` | - |
| `initialParameters` | `int*` | `ref int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `rotX` | `float` | `float` | - |
| `rotY` | `float` | `float` | - |
| `rotZ` | `float` | `float` | - |
| `rotOrder` | `int` | `int` | - |
| `blendDuration` | `float` | `float` | - |
| `allowOverrideCloneUpdate` | `BOOL` | `bool` | - |
| `dictionary` | `const char*` | `string` | - |
| `flags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_MOVE_NETWORK_BY_NAME

- **命名空间:** `TASK`
- **Hash:** `0x2D537BA194896636`
- **JHash:** `0x6F5D215F`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_MOVE_NETWORK_BY_NAME(int ped, string task, float multiplier, bool allowOverrideCloneUpdate, string animDict, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `task` | `const char*` | `string` | - |
| `multiplier` | `float` | `float` | - |
| `allowOverrideCloneUpdate` | `BOOL` | `bool` | - |
| `animDict` | `const char*` | `string` | - |
| `flags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Example:
TASK::TASK_MOVE_NETWORK_BY_NAME(PLAYER::PLAYER_PED_ID(), "arm_wrestling_sweep_paired_a_rev3", 0.0f, true, "mini@arm_wrestling", 0);
```

---

### TASK_MOVE_NETWORK_BY_NAME_WITH_INIT_PARAMS

- **命名空间:** `TASK`
- **Hash:** `0x3D45B0B355C5E0C9`
- **Build:** `1493`

**C# 签名:**
```csharp
void TASK_MOVE_NETWORK_BY_NAME_WITH_INIT_PARAMS(int ped, string network, ref int initialParameters, float blendDuration, bool allowOverrideCloneUpdate, string animDict, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `network` | `const char*` | `string` | - |
| `initialParameters` | `int*` | `ref int` | - |
| `blendDuration` | `float` | `float` | - |
| `allowOverrideCloneUpdate` | `BOOL` | `bool` | - |
| `animDict` | `const char*` | `string` | - |
| `flags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Used only once in the scripts (am_mp_nightclub)
```

---

### TASK_OPEN_VEHICLE_DOOR

- **命名空间:** `TASK`
- **Hash:** `0x965791A9A488A062`
- **JHash:** `0x8EE06BF4`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_OPEN_VEHICLE_DOOR(int ped, int vehicle, int timeOut, int seat, float speed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `timeOut` | `int` | `int` | - |
| `seat` | `int` | `int` | - |
| `speed` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
The given ped will try to open the nearest door to 'seat'.
Example: telling the ped to open the door for the driver seat does not necessarily mean it will open the driver door, it may choose to open the passenger door instead if that one is closer.
```

---

### TASK_PARACHUTE

- **命名空间:** `TASK`
- **Hash:** `0xD2F1C53C97EE81AB`
- **JHash:** `0xEC3060A2`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_PARACHUTE(int ped, bool giveParachuteItem, bool instant)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `giveParachuteItem` | `BOOL` | `bool` | - |
| `instant` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Second parameter is unused.

second parameter was for jetpack in the early stages of gta and the hard coded code is now removed
```

---

### TASK_PARACHUTE_TO_TARGET

- **命名空间:** `TASK`
- **Hash:** `0xB33E291AFA6BD03A`
- **JHash:** `0xE0104D6C`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_PARACHUTE_TO_TARGET(int ped, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
makes ped parachute to coords x y z. Works well with PATHFIND::GET_SAFE_COORD_FOR_PED
```

---

### TASK_PATROL

- **命名空间:** `TASK`
- **Hash:** `0xBDA5DF49D080FE4E`
- **JHash:** `0xB92E5AF6`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_PATROL(int ped, string patrolRouteName, int alertState, bool canChatToPeds, bool useHeadLookAt)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `patrolRouteName` | `const char*` | `string` | - |
| `alertState` | `int` | `int` | - |
| `canChatToPeds` | `BOOL` | `bool` | - |
| `useHeadLookAt` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
After looking at some scripts the second parameter seems to be an id of some kind. Here are some I found from some R* scripts:

"miss_Tower_01" (this went from 01 - 10)
"miss_Ass0" (0, 4, 6, 3)
"MISS_PATROL_8"

I think they're patrol routes, but I'm not sure. And I believe the 3rd parameter is a BOOL, but I can't confirm other than only seeing 0 and 1 being passed.


As far as I can see the patrol routes names such as "miss_Ass0" have been defined earlier in the scripts. This leads me to believe we can defined our own new patrol routes by following the same approach. 
From the scripts

    TASK::OPEN_PATROL_ROUTE("miss_Ass0");
    TASK::ADD_PATROL_ROUTE_NODE(0, "WORLD_HUMAN_GUARD_STAND", l_738[0/*3*/], -139.4076690673828, -993.4732055664062, 26.2754, MISC::GET_RANDOM_INT_IN_RANGE(5000, 10000));
    TASK::ADD_PATROL_ROUTE_NODE(1, "WORLD_HUMAN_GUARD_STAND", l_738[1/*3*/], -116.1391830444336, -987.4984130859375, 26.38541030883789, MISC::GET_RANDOM_INT_IN_RANGE(5000, 10000));
    TASK::ADD_PATROL_ROUTE_NODE(2, "WORLD_HUMAN_GUARD_STAND", l_738[2/*3*/], -128.46847534179688, -979.0340576171875, 26.2754, MISC::GET_RANDOM_INT_IN_RANGE(5000, 10000));
    TASK::ADD_PATROL_ROUTE_LINK(0, 1);
    TASK::ADD_PATROL_ROUTE_LINK(1, 2);
    TASK::ADD_PATROL_ROUTE_LINK(2, 0);
    TASK::CLOSE_PATROL_ROUTE();
    TASK::CREATE_PATROL_ROUTE();


```

---

### TASK_PAUSE

- **命名空间:** `TASK`
- **Hash:** `0xE73A266DB0CA9042`
- **JHash:** `0x17A64668`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_PAUSE(int ped, int ms)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `ms` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Stand still (?)
```

---

### TASK_PED_SLIDE_TO_COORD

- **命名空间:** `TASK`
- **Hash:** `0xD04FE6765D990A06`
- **JHash:** `0x225380EF`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_PED_SLIDE_TO_COORD(int ped, float x, float y, float z, float heading, float speed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `heading` | `float` | `float` | - |
| `speed` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_PED_SLIDE_TO_COORD_HDG_RATE

- **命名空间:** `TASK`
- **Hash:** `0x5A4A6A6D3DC64F52`
- **JHash:** `0x38A995C1`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_PED_SLIDE_TO_COORD_HDG_RATE(int ped, float x, float y, float z, float heading, float speed, float headingChangeRate)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `heading` | `float` | `float` | - |
| `speed` | `float` | `float` | - |
| `headingChangeRate` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_PERFORM_SEQUENCE

- **命名空间:** `TASK`
- **Hash:** `0x5ABA3986D90D8A3B`
- **JHash:** `0x4D9FBD11`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_PERFORM_SEQUENCE(int ped, int taskSequenceId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `taskSequenceId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_PERFORM_SEQUENCE_FROM_PROGRESS

- **命名空间:** `TASK`
- **Hash:** `0x89221B16730234F0`
- **JHash:** `0xFA60601B`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_PERFORM_SEQUENCE_FROM_PROGRESS(int ped, int taskIndex, int progress1, int progress2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `taskIndex` | `int` | `int` | - |
| `progress1` | `int` | `int` | - |
| `progress2` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_PERFORM_SEQUENCE_LOCALLY

- **命名空间:** `TASK`
- **Hash:** `0x8C33220C8D78CA0D`
- **Build:** `944`

**C# 签名:**
```csharp
void TASK_PERFORM_SEQUENCE_LOCALLY(int ped, int taskSequenceId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `taskSequenceId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_PLANE_CHASE

- **命名空间:** `TASK`
- **Hash:** `0x2D2386F273FF7A25`
- **JHash:** `0x12FA1C28`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_PLANE_CHASE(int pilot, int entityToFollow, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pilot` | `Ped` | `int` | - |
| `entityToFollow` | `Entity` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_PLANE_GOTO_PRECISE_VTOL

- **命名空间:** `TASK`
- **Hash:** `0xF7F9DCCA89E7505B`
- **Build:** `1290`

**C# 签名:**
```csharp
void TASK_PLANE_GOTO_PRECISE_VTOL(int ped, int vehicle, float x, float y, float z, int flightHeight, int minHeightAboveTerrain, bool useDesiredOrientation, float desiredOrientation, bool autopilot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `flightHeight` | `int` | `int` | - |
| `minHeightAboveTerrain` | `int` | `int` | - |
| `useDesiredOrientation` | `BOOL` | `bool` | - |
| `desiredOrientation` | `float` | `float` | - |
| `autopilot` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_PLANE_LAND

- **命名空间:** `TASK`
- **Hash:** `0xBF19721FA34D32C0`
- **JHash:** `0x5F7E23EA`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_PLANE_LAND(int pilot, int plane, float runwayStartX, float runwayStartY, float runwayStartZ, float runwayEndX, float runwayEndY, float runwayEndZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pilot` | `Ped` | `int` | - |
| `plane` | `Vehicle` | `int` | - |
| `runwayStartX` | `float` | `float` | - |
| `runwayStartY` | `float` | `float` | - |
| `runwayStartZ` | `float` | `float` | - |
| `runwayEndX` | `float` | `float` | - |
| `runwayEndY` | `float` | `float` | - |
| `runwayEndZ` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_PLANE_MISSION

- **命名空间:** `TASK`
- **Hash:** `0x23703CD154E83B88`
- **JHash:** `0x1D007E65`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_PLANE_MISSION(int pilot, int aircraft, int targetVehicle, int targetPed, float destinationX, float destinationY, float destinationZ, int missionFlag, float angularDrag, float targetReached, float targetHeading, float maxZ, float minZ, bool precise)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pilot` | `Ped` | `int` | - |
| `aircraft` | `Vehicle` | `int` | - |
| `targetVehicle` | `Vehicle` | `int` | - |
| `targetPed` | `Ped` | `int` | - |
| `destinationX` | `float` | `float` | - |
| `destinationY` | `float` | `float` | - |
| `destinationZ` | `float` | `float` | - |
| `missionFlag` | `int` | `int` | - |
| `angularDrag` | `float` | `float` | - |
| `targetReached` | `float` | `float` | - |
| `targetHeading` | `float` | `float` | - |
| `maxZ` | `float` | `float` | - |
| `minZ` | `float` | `float` | - |
| `precise` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
EXAMPLE USAGE:

Fly around target (Precautiously, keeps high altitude):
Function.Call(Hash.TASK_PLANE_MISSION, pilot, selectedAirplane, 0, 0, Target.X, Target.Y, Target.Z, 4, 100f, 0f, 90f, 0, 200f);

Fly around target (Dangerously, keeps VERY low altitude):
Function.Call(Hash.TASK_PLANE_MISSION, pilot, selectedAirplane, 0, 0, Target.X, Target.Y, Target.Z, 4, 100f, 0f, 90f, 0, -500f);

Fly directly into target:
Function.Call(Hash.TASK_PLANE_MISSION, pilot, selectedAirplane, 0, 0, Target.X, Target.Y, Target.Z, 4, 100f, 0f, 90f, 0, -5000f);

EXPANDED INFORMATION FOR ADVANCED USAGE (custom pilot)

'physicsSpeed': (THIS IS NOT YOUR ORDINARY SPEED PARAMETER: READ!!)
Think of this -first- as a radius value, not a true speed value.  The ACTUAL effective speed of the plane will be that of the maximum speed permissible to successfully fly in a -circle- with a radius of 'physicsSpeed'.  This also means that the plane must complete a circle before it can begin its "bombing run", its straight line pass towards the target.  p9 appears to influence the angle at which a "bombing run" begins, although I can't confirm yet.

VERY IMPORTANT: A "bombing run" will only occur if a plane can successfully determine a possible navigable route (the slower the value of 'physicsSpeed', the more precise the pilot can be due to less influence of physics on flightpath).  Otherwise, the pilot will continue to patrol around Destination (be it a dynamic Entity position vector or a fixed world coordinate vector.)

0 = Plane's physics are almost entirely frozen, plane appears to "orbit" around precise destination point
1-299 = Blend of "frozen, small radius" vs. normal vs. "accelerated, hyperfast, large radius"
300+ =  Vehicle behaves entirely like a normal gameplay plane.

'patrolBlend' (The lower the value, the more the Destination is treated as a "fly AT" rather than a "fly AROUND point".)

Scenario: Destination is an Entity on ground level, wide open field
-5000 = Pilot kamikazes directly into Entity
-1000 = Pilot flies extremely low -around- Entity, very prone to crashing
-200 = Pilot flies lower than average around Entity.
0 = Pilot flies around Entity, normal altitude
200 = Pilot flies an extra eighty units or so higher than 0 while flying around Destination (this doesn't seem to correlate directly into distance units.)

-- Valid mission types found in the exe: --

0 = None
1 = Unk
2 = CTaskVehicleRam
3 = CTaskVehicleBlock
4 = CTaskVehicleGoToPlane
5 = CTaskVehicleStop
6 = CTaskVehicleAttack
7 = CTaskVehicleFollow
8 = CTaskVehicleFleeAirborne
9= CTaskVehicleCircle
10 = CTaskVehicleEscort
15 = CTaskVehicleFollowRecording
16 = CTaskVehiclePoliceBehaviour
17 = CTaskVehicleCrash
```

---

### TASK_PLANE_TAXI

- **命名空间:** `TASK`
- **Hash:** `0x92C360B5F15D2302`
- **Build:** `1103`

**C# 签名:**
```csharp
void TASK_PLANE_TAXI(int pilot, int aircraft, float x, float y, float z, float cruiseSpeed, float targetReached)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pilot` | `Ped` | `int` | - |
| `aircraft` | `Vehicle` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `cruiseSpeed` | `float` | `float` | - |
| `targetReached` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_PLANT_BOMB

- **命名空间:** `TASK`
- **Hash:** `0x965FEC691D55E9BF`
- **JHash:** `0x33457535`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_PLANT_BOMB(int ped, float x, float y, float z, float heading)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `heading` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_PLAY_ANIM

- **命名空间:** `TASK`
- **Hash:** `0xEA47FE3719165B94`
- **JHash:** `0x5AB552C6`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_PLAY_ANIM(int ped, string animDictionary, string animationName, float blendInSpeed, float blendOutSpeed, int duration, int flag, float playbackRate, bool lockX, bool lockY, bool lockZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `animDictionary` | `const char*` | `string` | - |
| `animationName` | `const char*` | `string` | - |
| `blendInSpeed` | `float` | `float` | - |
| `blendOutSpeed` | `float` | `float` | - |
| `duration` | `int` | `int` | - |
| `flag` | `int` | `int` | - |
| `playbackRate` | `float` | `float` | - |
| `lockX` | `BOOL` | `bool` | - |
| `lockY` | `BOOL` | `bool` | - |
| `lockZ` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json

float speed > normal speed is 8.0f
----------------------

float speedMultiplier > multiply the playback speed
----------------------

int duration: time in millisecond
----------------------
-1 _ _ _ _ _ _ _> Default (see flag)
0 _ _ _ _ _ _ _ > Not play at all
Small value _ _ > Slow down animation speed
Other _ _ _ _ _ > freeze player control until specific time (ms) has 
_ _ _ _ _ _ _ _ _ passed. (No effect if flag is set to be 
_ _ _ _ _ _ _ _ _ controllable.)

int flag:
----------------------
enum eAnimationFlags
{
 ANIM_FLAG_NORMAL = 0,
   ANIM_FLAG_REPEAT = 1,
   ANIM_FLAG_STOP_LAST_FRAME = 2,
   ANIM_FLAG_UPPERBODY = 16,
   ANIM_FLAG_ENABLE_PLAYER_CONTROL = 32,
   ANIM_FLAG_CANCELABLE = 120,
};
Odd number : loop infinitely
Even number : Freeze at last frame
Multiple of 4: Freeze at last frame but controllable

01 to 15 > Full body
10 to 31 > Upper body
32 to 47 > Full body > Controllable
48 to 63 > Upper body > Controllable
...
001 to 255 > Normal
256 to 511 > Garbled
...

playbackRate:

values are between 0.0 and 1.0


lockX:  

0 in most cases 1 for rcmepsilonism8 and rcmpaparazzo_3
> 1 for mini@sprunk
 

lockY:

0 in most cases 
1 for missfam5_yoga, missfra1mcs_2_crew_react


lockZ: 

    0 for single player 
    Can be 1 but only for MP 
```

---

### TASK_PLAY_ANIM_ADVANCED

- **命名空间:** `TASK`
- **Hash:** `0x83CDB10EA29B370B`
- **JHash:** `0x3DDEB0E6`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_PLAY_ANIM_ADVANCED(int ped, string animDict, string animName, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float animEnterSpeed, float animExitSpeed, int duration, object flag, float animTime, int rotOrder, int ikFlags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `animDict` | `const char*` | `string` | - |
| `animName` | `const char*` | `string` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `rotX` | `float` | `float` | - |
| `rotY` | `float` | `float` | - |
| `rotZ` | `float` | `float` | - |
| `animEnterSpeed` | `float` | `float` | - |
| `animExitSpeed` | `float` | `float` | - |
| `duration` | `int` | `int` | - |
| `flag` | `Any` | `object` | - |
| `animTime` | `float` | `float` | - |
| `rotOrder` | `int` | `int` | - |
| `ikFlags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
It's similar to TASK_PLAY_ANIM, except the first 6 floats let you specify the initial position and rotation of the task. (Ped gets teleported to the position).

Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### TASK_PLAY_PHONE_GESTURE_ANIMATION

- **命名空间:** `TASK`
- **Hash:** `0x8FBB6758B3B3E9EC`
- **JHash:** `0x1582162C`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_PLAY_PHONE_GESTURE_ANIMATION(int ped, string animDict, string animation, string boneMaskType, float blendInDuration, float blendOutDuration, bool isLooping, bool holdLastFrame)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `animDict` | `const char*` | `string` | - |
| `animation` | `const char*` | `string` | - |
| `boneMaskType` | `const char*` | `string` | - |
| `blendInDuration` | `float` | `float` | - |
| `blendOutDuration` | `float` | `float` | - |
| `isLooping` | `BOOL` | `bool` | - |
| `holdLastFrame` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Example from the scripts:
TASK::TASK_PLAY_PHONE_GESTURE_ANIMATION(PLAYER::PLAYER_PED_ID(), v_3, v_2, v_4, 0.25, 0.25, 0, 0);

=========================================================
^^ No offense, but Idk how that would really help anyone.

As for the animDict & animation, they're both store in a global in all 5 scripts. So if anyone would be so kind as to read that global and comment what strings they use. Thanks.

Known boneMaskTypes'
"BONEMASK_HEADONLY"
"BONEMASK_HEAD_NECK_AND_ARMS"
"BONEMASK_HEAD_NECK_AND_L_ARM"
"BONEMASK_HEAD_NECK_AND_R_ARM"

p4 known args - 0.0f, 0.5f, 0.25f
p5 known args - 0.0f, 0.25f
p6 known args - 1 if a global if check is passed.
p7 known args - 1 if a global if check is passed.

The values found above, I found within the 5 scripts this is ever called in. (fmmc_launcher, fm_deathmatch_controller, fm_impromptu_dm_controller, fm_mission_controller, and freemode).
=========================================================

Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### TASK_PUT_PED_DIRECTLY_INTO_COVER

- **命名空间:** `TASK`
- **Hash:** `0x4172393E6BE1FECE`
- **JHash:** `0xC9F00E68`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_PUT_PED_DIRECTLY_INTO_COVER(int ped, float x, float y, float z, int time, bool allowPeekingAndFiring, float blendInDuration, bool forceInitialFacingDirection, bool forceFaceLeft, int identifier, bool doEntry)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `time` | `int` | `int` | - |
| `allowPeekingAndFiring` | `BOOL` | `bool` | - |
| `blendInDuration` | `float` | `float` | - |
| `forceInitialFacingDirection` | `BOOL` | `bool` | - |
| `forceFaceLeft` | `BOOL` | `bool` | - |
| `identifier` | `int` | `int` | - |
| `doEntry` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_PUT_PED_DIRECTLY_INTO_MELEE

- **命名空间:** `TASK`
- **Hash:** `0x1C6CD14A876FFE39`
- **JHash:** `0x79E1D27D`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_PUT_PED_DIRECTLY_INTO_MELEE(int ped, int meleeTarget, float blendInDuration, float timeInMelee, float strafePhaseSync, int aiCombatFlags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `meleeTarget` | `Ped` | `int` | - |
| `blendInDuration` | `float` | `float` | - |
| `timeInMelee` | `float` | `float` | - |
| `strafePhaseSync` | `float` | `float` | - |
| `aiCombatFlags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
from armenian3.c4

TASK::TASK_PUT_PED_DIRECTLY_INTO_MELEE(PlayerPed, armenianPed, 0.0, -1.0, 0.0, 0);

```

---

### TASK_RAPPEL_DOWN_WALL_USING_CLIPSET_OVERRIDE

- **命名空间:** `TASK`
- **Hash:** `0xEAF66ACDDC794793`
- **Build:** `1868`

**C# 签名:**
```csharp
void TASK_RAPPEL_DOWN_WALL_USING_CLIPSET_OVERRIDE(int ped, float x1, float y1, float z1, float x2, float y2, float z2, float minZ, int ropeHandle, string clipSet, object p10, object p11)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |
| `z2` | `float` | `float` | - |
| `minZ` | `float` | `float` | - |
| `ropeHandle` | `int` | `int` | - |
| `clipSet` | `const char*` | `string` | - |
| `p10` | `Any` | `object` | - |
| `p11` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Attaches a ped to a rope and allows player control to rappel down a wall. Disables all collisions while on the rope.
p10: Usually 1 in the scripts, clipSet: Clipset to use for the task, minZ: Minimum Z that the player can descend to, ropeHandle: Rope to attach this task to created with ADD_ROPE
```

---

### TASK_RAPPEL_FROM_HELI

- **命名空间:** `TASK`
- **Hash:** `0x09693B0312F91649`
- **JHash:** `0x2C7ADB93`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_RAPPEL_FROM_HELI(int ped, float minHeightAboveGround)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `minHeightAboveGround` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
minHeightAboveGround: the minimum height above ground the heli must be at before the ped can start rappelling

Only appears twice in the scripts.

TASK::TASK_RAPPEL_FROM_HELI(PLAYER::PLAYER_PED_ID(), 10.0f);
TASK::TASK_RAPPEL_FROM_HELI(a_0, 10.0f);
```

---

### TASK_REACT_AND_FLEE_PED

- **命名空间:** `TASK`
- **Hash:** `0x72C896464915D1B1`
- **JHash:** `0x8A632BD8`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_REACT_AND_FLEE_PED(int ped, int fleeTarget)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `fleeTarget` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_RELOAD_WEAPON

- **命名空间:** `TASK`
- **Hash:** `0x62D2916F56B9CD2D`
- **JHash:** `0xCA6E91FD`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_RELOAD_WEAPON(int ped, bool drawWeapon)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `drawWeapon` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
The 2nd param (drawWeapon) is not implemented.

-----------------------------------------------------------------------

The only occurrence I found in a R* script ("assassin_construction.ysc.c4"):

            if (((v_3 < v_4) && (TASK::GET_SCRIPT_TASK_STATUS(PLAYER::PLAYER_PED_ID(), 0x6a67a5cc) != 1)) && (v_5 > v_3)) {
                TASK::TASK_RELOAD_WEAPON(PLAYER::PLAYER_PED_ID(), 1);
            }
```

---

### TASK_SCRIPTED_ANIMATION

- **命名空间:** `TASK`
- **Hash:** `0x126EF75F1E17ABE5`
- **JHash:** `0xFC2DCF47`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_SCRIPTED_ANIMATION(int ped, ref int priorityLowData, ref int priorityMidData, ref int priorityHighData, float blendInDelta, float blendOutDelta)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `priorityLowData` | `int*` | `ref int` | - |
| `priorityMidData` | `int*` | `ref int` | - |
| `priorityHighData` | `int*` | `ref int` | - |
| `blendInDelta` | `float` | `float` | - |
| `blendOutDelta` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
From fm_mission_controller.c:
reserve_network_mission_objects(get_num_reserved_mission_objects(0) + 1);
           vVar28 = {0.094f, 0.02f, -0.005f};
            vVar29 = {-92.24f, 63.64f, 150.24f};
          func_253(&uVar30, joaat("prop_ld_case_01"), Global_1592429.imm_34757[iParam1 <268>], 1, 1, 0, 1);
         set_entity_lod_dist(net_to_ent(uVar30), 500);
         attach_entity_to_entity(net_to_ent(uVar30), iParam0, get_ped_bone_index(iParam0, 28422), vVar28, vVar29, 1, 0, 0, 0, 2, 1);
           Var31.imm_4 = 1065353216;
         Var31.imm_5 = 1065353216;
         Var31.imm_9 = 1065353216;
         Var31.imm_10 = 1065353216;
            Var31.imm_14 = 1065353216;
            Var31.imm_15 = 1065353216;
            Var31.imm_17 = 1040187392;
            Var31.imm_18 = 1040187392;
            Var31.imm_19 = -1;
            Var32.imm_4 = 1065353216;
         Var32.imm_5 = 1065353216;
         Var32.imm_9 = 1065353216;
         Var32.imm_10 = 1065353216;
            Var32.imm_14 = 1065353216;
            Var32.imm_15 = 1065353216;
            Var32.imm_17 = 1040187392;
            Var32.imm_18 = 1040187392;
            Var32.imm_19 = -1;
            Var31 = 1;
            Var31.imm_1 = "weapons@misc@jerrycan@mp_male";
          Var31.imm_2 = "idle";
           Var31.imm_20 = 1048633;
           Var31.imm_4 = 0.5f;
           Var31.imm_16 = get_hash_key("BONEMASK_ARMONLY_R");
          task_scripted_animation(iParam0, &Var31, &Var32, &Var32, 0f, 0.25f);
          set_model_as_no_longer_needed(joaat("prop_ld_case_01"));
            remove_anim_dict("anim@heists@biolab@");
```

---

### TASK_SEEK_COVER_FROM_PED

- **命名空间:** `TASK`
- **Hash:** `0x84D32B3BEC531324`
- **JHash:** `0xC1EC907E`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_SEEK_COVER_FROM_PED(int ped, int target, int duration, bool allowPeekingAndFiring)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `target` | `Ped` | `int` | - |
| `duration` | `int` | `int` | - |
| `allowPeekingAndFiring` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_SEEK_COVER_FROM_POS

- **命名空间:** `TASK`
- **Hash:** `0x75AC2B60386D89F2`
- **JHash:** `0x83F18EE9`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_SEEK_COVER_FROM_POS(int ped, float x, float y, float z, int duration, bool allowPeekingAndFiring)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `duration` | `int` | `int` | - |
| `allowPeekingAndFiring` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_SEEK_COVER_TO_COORDS

- **命名空间:** `TASK`
- **Hash:** `0x39246A6958EF072C`
- **JHash:** `0xFFFE754E`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_SEEK_COVER_TO_COORDS(int ped, float x1, float y1, float z1, float x2, float y2, float z2, int timeout, bool shortRoute)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |
| `z2` | `float` | `float` | - |
| `timeout` | `int` | `int` | - |
| `shortRoute` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p8 causes the ped to take the shortest route to the cover position. It may have something to do with navmesh or pathfinding mechanics.

from michael2:
TASK::TASK_SEEK_COVER_TO_COORDS(ped, 967.5164794921875, -2121.603515625, 30.479299545288086, 978.94677734375, -2125.84130859375, 29.4752, -1, 1);


appears to be shorter variation
from michael3:
TASK::TASK_SEEK_COVER_TO_COORDS(ped, -2231.011474609375, 263.6326599121094, 173.60195922851562, -1, 0);
```

---

### TASK_SEEK_COVER_TO_COVER_POINT

- **命名空间:** `TASK`
- **Hash:** `0xD43D95C7A869447F`
- **JHash:** `0x3D026B29`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_SEEK_COVER_TO_COVER_POINT(int ped, int coverpoint, float x, float y, float z, int time, bool allowPeekingAndFiring)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `coverpoint` | `ScrHandle` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `time` | `int` | `int` | - |
| `allowPeekingAndFiring` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p5 is always -1
```

---

### TASK_SET_BLOCKING_OF_NON_TEMPORARY_EVENTS

- **命名空间:** `TASK`
- **Hash:** `0x90D2156198831D69`
- **JHash:** `0x1B54FB6B`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_SET_BLOCKING_OF_NON_TEMPORARY_EVENTS(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
I cant believe I have to define this, this is one of the best natives.

It makes the ped ignore basically all shocking events around it. Occasionally the ped may comment or gesture, but other than that they just continue their daily activities. This includes shooting and wounding the ped. And - most importantly - they do not flee.

Since it is a task, every time the native is called the ped will stop for a moment. 
```

---

### TASK_SET_DECISION_MAKER

- **命名空间:** `TASK`
- **Hash:** `0xEB8517DDA73720DA`
- **JHash:** `0x830AD50C`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_SET_DECISION_MAKER(int ped, uint decisionMakerId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `decisionMakerId` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 is always GET_HASH_KEY("empty") in scripts, for the rare times this is used
```

---

### TASK_SET_SPHERE_DEFENSIVE_AREA

- **命名空间:** `TASK`
- **Hash:** `0x933C06518B52A9A4`
- **JHash:** `0x9F3C5D6A`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_SET_SPHERE_DEFENSIVE_AREA(int ped, float x, float y, float z, float radius)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_SHARK_CIRCLE_COORD

- **命名空间:** `TASK`
- **Hash:** `0x60A19CF85FF4CEFA`
- **Build:** `3407`

**C# 签名:**
```csharp
void TASK_SHARK_CIRCLE_COORD(int ped, float x, float y, float z, float moveBlendRatio, float radius)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `moveBlendRatio` | `float` | `float` | - |
| `radius` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_SHOCKING_EVENT_REACT

- **命名空间:** `TASK`
- **Hash:** `0x452419CBD838065B`
- **JHash:** `0x9BD00ACF`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_SHOCKING_EVENT_REACT(int ped, int eventHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `eventHandle` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_SHOOT_AT_COORD

- **命名空间:** `TASK`
- **Hash:** `0x46A6CC01E0826106`
- **JHash:** `0x601C22E3`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_SHOOT_AT_COORD(int ped, float x, float y, float z, int duration, uint firingPattern)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `duration` | `int` | `int` | - |
| `firingPattern` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Firing Pattern Hash Information: https://pastebin.com/Px036isB
```

---

### TASK_SHOOT_AT_ENTITY

- **命名空间:** `TASK`
- **Hash:** `0x08DA95E8298AE772`
- **JHash:** `0xAC0631C9`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_SHOOT_AT_ENTITY(int entity, int target, int duration, uint firingPattern)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `target` | `Entity` | `int` | - |
| `duration` | `int` | `int` | - |
| `firingPattern` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
//this part of the code is to determine at which entity the player is aiming, for example if you want to create a mod where you give orders to peds
Entity aimedentity;
Player player = PLAYER::PLAYER_ID();
PLAYER::_GET_AIMED_ENTITY(player, &aimedentity);

//bg is an array of peds
TASK::TASK_SHOOT_AT_ENTITY(bg[i], aimedentity, 5000, MISC::GET_HASH_KEY("FIRING_PATTERN_FULL_AUTO"));

in practical usage, getting the entity the player is aiming at and then task the peds to shoot at the entity, at a button press event would be better.

Firing Pattern Hash Information: https://pastebin.com/Px036isB
```

---

### TASK_SHUFFLE_TO_NEXT_VEHICLE_SEAT

- **命名空间:** `TASK`
- **Hash:** `0x7AA80209BDA643EB`
- **JHash:** `0xBEAF8F67`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_SHUFFLE_TO_NEXT_VEHICLE_SEAT(int ped, int vehicle, bool useAlternateShuffle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `useAlternateShuffle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Makes the specified ped shuffle to the next vehicle seat.
The ped MUST be in a vehicle and the vehicle parameter MUST be the ped's current vehicle.
```

---

### TASK_SKY_DIVE

- **命名空间:** `TASK`
- **Hash:** `0x601736CFE536B0A0`
- **JHash:** `0xD3874AFA`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_SKY_DIVE(int ped, bool instant)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `instant` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_SMART_FLEE_COORD

- **命名空间:** `TASK`
- **Hash:** `0x94587F17E9C365D5`
- **JHash:** `0xB2E686FC`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_SMART_FLEE_COORD(int ped, float x, float y, float z, float distance, int time, bool preferPavements, bool quitIfOutOfRange)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `distance` | `float` | `float` | - |
| `time` | `int` | `int` | - |
| `preferPavements` | `BOOL` | `bool` | - |
| `quitIfOutOfRange` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Makes the specified ped flee the specified distance from the specified position.
```

---

### TASK_SMART_FLEE_PED

- **命名空间:** `TASK`
- **Hash:** `0x22B0D0E37CCB840D`
- **JHash:** `0xE52EB560`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_SMART_FLEE_PED(int ped, int fleeTarget, float safeDistance, int fleeTime, bool preferPavements, bool updateToNearestHatedPed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `fleeTarget` | `Ped` | `int` | - |
| `safeDistance` | `float` | `float` | - |
| `fleeTime` | `int` | `int` | - |
| `preferPavements` | `BOOL` | `bool` | - |
| `updateToNearestHatedPed` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Makes a ped run away from another ped (fleeTarget).

distance = ped will flee this distance.
fleeTime = ped will flee for this amount of time, set to "-1" to flee forever
```

---

### TASK_STAND_GUARD

- **命名空间:** `TASK`
- **Hash:** `0xAE032F8BBA959E90`
- **JHash:** `0xD130F636`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_STAND_GUARD(int ped, float x, float y, float z, float heading, string scenarioName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `heading` | `float` | `float` | - |
| `scenarioName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
scenarioName example: "WORLD_HUMAN_GUARD_STAND"
```

---

### TASK_STAND_STILL

- **命名空间:** `TASK`
- **Hash:** `0x919BE13EED931959`
- **JHash:** `0x6F80965D`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_STAND_STILL(int ped, int time)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `time` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Makes the specified ped stand still for (time) milliseconds.
```

---

### TASK_START_SCENARIO_AT_POSITION

- **命名空间:** `TASK`
- **Hash:** `0xFA4EFC79F69D4F07`
- **JHash:** `0xAA2C4AC2`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_START_SCENARIO_AT_POSITION(int ped, string scenarioName, float x, float y, float z, float heading, int duration, bool sittingScenario, bool teleport)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `scenarioName` | `const char*` | `string` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `heading` | `float` | `float` | - |
| `duration` | `int` | `int` | - |
| `sittingScenario` | `BOOL` | `bool` | - |
| `teleport` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of ped scenarios by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/scenariosCompact.json

Also a few more listed at TASK::TASK_START_SCENARIO_IN_PLACE just above.
---------------
The first parameter in every scenario has always been a Ped of some sort. The second like TASK_START_SCENARIO_IN_PLACE is the name of the scenario. 

The next 4 parameters were harder to decipher. After viewing "hairdo_shop_mp.ysc.c4", and being confused from seeing the case in other scripts, they passed the first three of the arguments as one array from a function, and it looked like it was obviously x, y, and z.

I haven't seen the sixth parameter go to or over 360, making me believe that it is rotation, but I really can't confirm anything.

I have no idea what the last 3 parameters are, but I'll try to find out.

-going on the last 3 parameters, they appear to always be "0, 0, 1"

p6 -1 also used in scrips

p7 used for sitting scenarios

p8 teleports ped to position
```

---

### TASK_START_SCENARIO_IN_PLACE

- **命名空间:** `TASK`
- **Hash:** `0x142A02425FF02BD9`
- **JHash:** `0xE50D6DDE`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_START_SCENARIO_IN_PLACE(int ped, string scenarioName, int unkDelay, bool playEnterAnim)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `scenarioName` | `const char*` | `string` | - |
| `unkDelay` | `int` | `int` | - |
| `playEnterAnim` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Plays a scenario on a Ped at their current location.

unkDelay - Usually 0 or -1, doesn't seem to have any effect. Might be a delay between sequences.
playEnterAnim - Plays the "Enter" anim if true, otherwise plays the "Exit" anim. Scenarios that don't have any "Enter" anims won't play if this is set to true.

----

From "am_hold_up.ysc.c4" at line 339:

TASK::TASK_START_SCENARIO_IN_PLACE(NETWORK::NET_TO_PED(l_8D._f4), sub_adf(), 0, 1);

I'm unsure of what the last two parameters are, however sub_adf() randomly returns 1 of 3 scenarios, those being:
WORLD_HUMAN_SMOKING
WORLD_HUMAN_HANG_OUT_STREET
WORLD_HUMAN_STAND_MOBILE

This makes sense, as these are what I commonly see when going by a liquor store.
-------------------------
List of scenarioNames: https://pastebin.com/6mrYTdQv
(^ Thank you so fucking much for this)

Also these:
WORLD_FISH_FLEE
DRIVE
WORLD_HUMAN_HIKER
WORLD_VEHICLE_ATTRACTOR
WORLD_VEHICLE_BICYCLE_MOUNTAIN
WORLD_VEHICLE_BIKE_OFF_ROAD_RACE
WORLD_VEHICLE_BIKER
WORLD_VEHICLE_CONSTRUCTION_PASSENGERS
WORLD_VEHICLE_CONSTRUCTION_SOLO
WORLD_VEHICLE_DRIVE_PASSENGERS
WORLD_VEHICLE_DRIVE_SOLO
WORLD_VEHICLE_EMPTY
WORLD_VEHICLE_PARK_PARALLEL
WORLD_VEHICLE_PARK_PERPENDICULAR_NOSE_IN
WORLD_VEHICLE_POLICE_BIKE
WORLD_VEHICLE_POLICE_CAR
WORLD_VEHICLE_POLICE_NEXT_TO_CAR
WORLD_VEHICLE_SALTON_DIRT_BIKE
WORLD_VEHICLE_TRUCK_LOGS

Full list of ped scenarios by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/scenariosCompact.json
```

---

### TASK_STAY_IN_COVER

- **命名空间:** `TASK`
- **Hash:** `0xE5DA8615A6180789`
- **JHash:** `0xA27A9413`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_STAY_IN_COVER(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Makes the ped run to take cover
```

---

### TASK_STEALTH_KILL

- **命名空间:** `TASK`
- **Hash:** `0xAA5DC05579D60BD9`
- **JHash:** `0x0D64C2FA`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_STEALTH_KILL(int killer, int target, uint stealthKillActionResultHash, float desiredMoveBlendRatio, int stealthFlags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `killer` | `Ped` | `int` | - |
| `target` | `Ped` | `int` | - |
| `stealthKillActionResultHash` | `Hash` | `uint` | - |
| `desiredMoveBlendRatio` | `float` | `float` | - |
| `stealthFlags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
known "killTypes" are: "AR_stealth_kill_knife" and "AR_stealth_kill_a".
```

---

### TASK_STOP_PHONE_GESTURE_ANIMATION

- **命名空间:** `TASK`
- **Hash:** `0x3FA00D4F4641BFAE`
- **JHash:** `0x5A32D4B4`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_STOP_PHONE_GESTURE_ANIMATION(int ped, float blendOutOverride)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `blendOutOverride` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_SUBMARINE_GOTO_AND_STOP

- **命名空间:** `TASK`
- **Hash:** `0xC22B40579A498CA4`
- **Build:** `2189`

**C# 签名:**
```csharp
void TASK_SUBMARINE_GOTO_AND_STOP(int ped, int submarine, float x, float y, float z, bool autopilot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `submarine` | `Vehicle` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `autopilot` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Used in am_vehicle_spawn.ysc and am_mp_submarine.ysc.

p0 is always 0, p5 is always 1

p1 is the vehicle handle of the submarine. Submarine must have a driver, but the ped handle is not passed to the native.

Speed can be set by calling SET_DRIVE_TASK_CRUISE_SPEED after
```

---

### TASK_SWAP_WEAPON

- **命名空间:** `TASK`
- **Hash:** `0xA21C51255B205245`
- **JHash:** `0xDAF4F8FC`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_SWAP_WEAPON(int ped, bool drawWeapon)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `drawWeapon` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_SWEEP_AIM_ENTITY

- **命名空间:** `TASK`
- **Hash:** `0x2047C02158D6405A`
- **JHash:** `0x4D210467`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_SWEEP_AIM_ENTITY(int ped, string animDict, string lowAnimName, string medAnimName, string hiAnimName, int runtime, int targetEntity, float turnRate, float blendInDuration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `animDict` | `const char*` | `string` | - |
| `lowAnimName` | `const char*` | `string` | - |
| `medAnimName` | `const char*` | `string` | - |
| `hiAnimName` | `const char*` | `string` | - |
| `runtime` | `int` | `int` | - |
| `targetEntity` | `Entity` | `int` | - |
| `turnRate` | `float` | `float` | - |
| `blendInDuration` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This function is called on peds in vehicles.

anim: animation name
p2, p3, p4: "sweep_low", "sweep_med" or "sweep_high"
p5: no idea what it does but is usually -1
```

---

### TASK_SWEEP_AIM_POSITION

- **命名空间:** `TASK`
- **Hash:** `0x7AFE8FDC10BC07D2`
- **JHash:** `0x1683FE66`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_SWEEP_AIM_POSITION(int ped, string animDict, string lowAnimName, string medAnimName, string hiAnimName, int runtime, float x, float y, float z, float turnRate, float blendInDuration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `animDict` | `const char*` | `string` | - |
| `lowAnimName` | `const char*` | `string` | - |
| `medAnimName` | `const char*` | `string` | - |
| `hiAnimName` | `const char*` | `string` | - |
| `runtime` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `turnRate` | `float` | `float` | - |
| `blendInDuration` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_SYNCHRONIZED_SCENE

- **命名空间:** `TASK`
- **Hash:** `0xEEA929141F699854`
- **JHash:** `0x4F217E7B`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_SYNCHRONIZED_SCENE(int ped, int scene, string animDictionary, string animationName, float blendIn, float blendOut, int flags, int ragdollBlockingFlags, float moverBlendDelta, int ikFlags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `scene` | `int` | `int` | - |
| `animDictionary` | `const char*` | `string` | - |
| `animationName` | `const char*` | `string` | - |
| `blendIn` | `float` | `float` | - |
| `blendOut` | `float` | `float` | - |
| `flags` | `int` | `int` | - |
| `ragdollBlockingFlags` | `int` | `int` | - |
| `moverBlendDelta` | `float` | `float` | - |
| `ikFlags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
 TASK::TASK_SYNCHRONIZED_SCENE(ped, scene, "creatures@rottweiler@in_vehicle@std_car", "get_in", 1000.0, -8.0, 4, 0, 0x447a0000, 0);

Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### TASK_THROW_PROJECTILE

- **命名空间:** `TASK`
- **Hash:** `0x7285951DBF6B5A51`
- **JHash:** `0xF65C20A7`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_THROW_PROJECTILE(int ped, float x, float y, float z, int ignoreCollisionEntityIndex, bool createInvincibleProjectile)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `ignoreCollisionEntityIndex` | `int` | `int` | - |
| `createInvincibleProjectile` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
In every case of this native, I've only seen the first parameter passed as 0, although I believe it's a Ped after seeing tasks around it using 0. That's because it's used in a Sequence Task.

The last 3 parameters are definitely coordinates after seeing them passed in other scripts, and even being used straight from the player's coordinates.
---
It seems that - in the decompiled scripts - this native was used on a ped who was in a vehicle to throw a projectile out the window at the player. This is something any ped will naturally do if they have a throwable and they are doing driveby-combat (although not very accurately).
It is possible, however, that this is how SWAT throws smoke grenades at the player when in cover.
----------------------------------------------------
The first comment is right it definately is the ped as if you look in script finale_heist2b.c line 59628 in Xbox Scripts atleast you will see task_throw_projectile and the first param is Local_559[2 <14>] if you look above it a little bit line 59622 give_weapon_to_ped uses the same exact param Local_559[2 <14>] and we all know the first param of that native is ped. So it guaranteed has to be ped. 0 just may mean to use your ped by default for some reason.
```

---

### TASK_TOGGLE_DUCK

- **命名空间:** `TASK`
- **Hash:** `0xAC96609B9995EDF8`
- **JHash:** `0x61CFBCBF`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_TOGGLE_DUCK(int ped, int toggleType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggleType` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
used in sequence task

both parameters seems to be always 0
```

---

### TASK_TURN_PED_TO_FACE_COORD

- **命名空间:** `TASK`
- **Hash:** `0x1DDA930A0AC38571`
- **JHash:** `0x30463D73`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_TURN_PED_TO_FACE_COORD(int ped, float x, float y, float z, int duration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `duration` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
duration in milliseconds
```

---

### TASK_TURN_PED_TO_FACE_ENTITY

- **命名空间:** `TASK`
- **Hash:** `0x5AD23D40115353AC`
- **JHash:** `0x3C37C767`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_TURN_PED_TO_FACE_ENTITY(int ped, int entity, int duration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `entity` | `Entity` | `int` | - |
| `duration` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
duration: the amount of time in milliseconds to do the task. -1 will keep the task going until either another task is applied, or CLEAR_ALL_TASKS() is called with the ped
```

---

### TASK_USE_MOBILE_PHONE

- **命名空间:** `TASK`
- **Hash:** `0xBD2A8EC3AF4DE7DB`
- **JHash:** `0x225A38C8`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_USE_MOBILE_PHONE(int ped, bool usePhone, int desiredPhoneMode)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `usePhone` | `BOOL` | `bool` | - |
| `desiredPhoneMode` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Actually has 3 params, not 2.

p0: Ped
p1: int (or bool?)
p2: int
```

---

### TASK_USE_MOBILE_PHONE_TIMED

- **命名空间:** `TASK`
- **Hash:** `0x5EE02954A14C69DB`
- **JHash:** `0xC99C19F5`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_USE_MOBILE_PHONE_TIMED(int ped, int duration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `duration` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD

- **命名空间:** `TASK`
- **Hash:** `0x9FDA1B3D7E7028B3`
- **JHash:** `0xE32FFB22`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD(int ped, float x, float y, float z, float maxRange, int timeToLeave)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `maxRange` | `float` | `float` | - |
| `timeToLeave` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p5 is always 0 in scripts
```

---

### TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD_WARP

- **命名空间:** `TASK`
- **Hash:** `0x97A28E63F0BA5631`
- **JHash:** `0xBAB4C0AE`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD_WARP(int ped, float x, float y, float z, float radius, int timeToLeave)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `timeToLeave` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p5 is always -1 or 0 in scripts
```

---

### TASK_USE_NEAREST_SCENARIO_TO_COORD

- **命名空间:** `TASK`
- **Hash:** `0x277F471BA9DB000B`
- **JHash:** `0x9C50FBF0`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_USE_NEAREST_SCENARIO_TO_COORD(int ped, float x, float y, float z, float distance, int duration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `distance` | `float` | `float` | - |
| `duration` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Updated variables

An alternative to TASK::TASK_USE_NEAREST_SCENARIO_TO_COORD_WARP. Makes the ped walk to the scenario instead.
```

---

### TASK_USE_NEAREST_SCENARIO_TO_COORD_WARP

- **命名空间:** `TASK`
- **Hash:** `0x58E2E0F23F6B76C3`
- **JHash:** `0x1BE9D65C`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_USE_NEAREST_SCENARIO_TO_COORD_WARP(int ped, float x, float y, float z, float radius, int timeToLeave)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `timeToLeave` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_VEHICLE_AIM_AT_COORD

- **命名空间:** `TASK`
- **Hash:** `0x447C1E9EF844BC0F`
- **JHash:** `0x010F47CE`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_VEHICLE_AIM_AT_COORD(int ped, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_VEHICLE_AIM_AT_PED

- **命名空间:** `TASK`
- **Hash:** `0xE41885592B08B097`
- **JHash:** `0x920AE6DB`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_VEHICLE_AIM_AT_PED(int ped, int target)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `target` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_VEHICLE_CHASE

- **命名空间:** `TASK`
- **Hash:** `0x3C08A8E30363B353`
- **JHash:** `0x55634798`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_VEHICLE_CHASE(int driver, int targetEnt)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `driver` | `Ped` | `int` | - |
| `targetEnt` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
chases targetEnt fast and aggressively
--
Makes ped (needs to be in vehicle) chase targetEnt.
```

---

### TASK_VEHICLE_DRIVE_TO_COORD

- **命名空间:** `TASK`
- **Hash:** `0xE2A2AA2F659D77A7`
- **JHash:** `0xE4AC0387`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_VEHICLE_DRIVE_TO_COORD(int ped, int vehicle, float x, float y, float z, float speed, object p6, uint vehicleModel, int drivingMode, float stopRange, float straightLineDistance)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `speed` | `float` | `float` | - |
| `p6` | `Any` | `object` | - |
| `vehicleModel` | `Hash` | `uint` | - |
| `drivingMode` | `int` | `int` | - |
| `stopRange` | `float` | `float` | - |
| `straightLineDistance` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
info about driving modes: https://gtaforums.com/topic/822314-guide-driving-styles/
```

---

### TASK_VEHICLE_DRIVE_TO_COORD_LONGRANGE

- **命名空间:** `TASK`
- **Hash:** `0x158BB33F920D360C`
- **JHash:** `0x1490182A`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_VEHICLE_DRIVE_TO_COORD_LONGRANGE(int ped, int vehicle, float x, float y, float z, float speed, int driveMode, float stopRange)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `speed` | `float` | `float` | - |
| `driveMode` | `int` | `int` | - |
| `stopRange` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_VEHICLE_DRIVE_WANDER

- **命名空间:** `TASK`
- **Hash:** `0x480142959D337D00`
- **JHash:** `0x36EC0EB0`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_VEHICLE_DRIVE_WANDER(int ped, int vehicle, float speed, int drivingStyle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `speed` | `float` | `float` | - |
| `drivingStyle` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_VEHICLE_ESCORT

- **命名空间:** `TASK`
- **Hash:** `0x0FA6E4B75F302400`
- **JHash:** `0x9FDCB250`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_VEHICLE_ESCORT(int ped, int vehicle, int targetVehicle, int mode, float speed, int drivingStyle, float minDistance, int minHeightAboveTerrain, float noRoadsDistance)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `targetVehicle` | `Vehicle` | `int` | - |
| `mode` | `int` | `int` | - |
| `speed` | `float` | `float` | - |
| `drivingStyle` | `int` | `int` | - |
| `minDistance` | `float` | `float` | - |
| `minHeightAboveTerrain` | `int` | `int` | - |
| `noRoadsDistance` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Makes a ped follow the targetVehicle with <minDistance> in between.

note: minDistance is ignored if drivingstyle is avoiding traffic, but Rushed is fine.

Mode: The mode defines the relative position to the targetVehicle. The ped will try to position its vehicle there.
-1 = behind
0 = ahead
1 = left
2 = right
3 = back left
4 = back right

if the target is closer than noRoadsDistance, the driver will ignore pathing/roads and follow you directly.

Driving Styles guide: gtaforums.com/topic/822314-guide-driving-styles/
```

---

### TASK_VEHICLE_FOLLOW

- **命名空间:** `TASK`
- **Hash:** `0xFC545A9F0626E3B6`
- **JHash:** `0xA8B917D7`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_VEHICLE_FOLLOW(int driver, int vehicle, int targetEntity, float speed, int drivingStyle, int minDistance)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `driver` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `targetEntity` | `Entity` | `int` | - |
| `speed` | `float` | `float` | - |
| `drivingStyle` | `int` | `int` | - |
| `minDistance` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Makes a ped in a vehicle follow an entity (ped, vehicle, etc.)

drivingStyle: http://gtaforums.com/topic/822314-guide-driving-styles/
```

---

### TASK_VEHICLE_FOLLOW_WAYPOINT_RECORDING

- **命名空间:** `TASK`
- **Hash:** `0x3123FAA6DB1CF7ED`
- **JHash:** `0x959818B6`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_VEHICLE_FOLLOW_WAYPOINT_RECORDING(int ped, int vehicle, string WPRecording, int p3, int p4, int p5, int p6, float p7, bool p8, float p9)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `WPRecording` | `const char*` | `string` | - |
| `p3` | `int` | `int` | - |
| `p4` | `int` | `int` | - |
| `p5` | `int` | `int` | - |
| `p6` | `int` | `int` | - |
| `p7` | `float` | `float` | - |
| `p8` | `BOOL` | `bool` | - |
| `p9` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```


p2 = Waypoint recording string (found in update\update.rpf\x64\levels\gta5\waypointrec.rpf
p3 = 786468
p4 = 0
p5 = 16
p6 = -1 (angle?)
p7/8/9 = usually v3.zero
p10 = bool (repeat?)
p11 = 1073741824

Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/waypointRecordings.json
```

---

### TASK_VEHICLE_GOTO_NAVMESH

- **命名空间:** `TASK`
- **Hash:** `0x195AEEB13CEFE2EE`
- **JHash:** `0x55CF3BCD`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_VEHICLE_GOTO_NAVMESH(int ped, int vehicle, float x, float y, float z, float speed, int behaviorFlag, float stoppingRange)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `speed` | `float` | `float` | - |
| `behaviorFlag` | `int` | `int` | - |
| `stoppingRange` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Differs from TASK_VEHICLE_DRIVE_TO_COORDS in that it will pick the shortest possible road route without taking one-way streets and other "road laws" into consideration.

WARNING:
A behaviorFlag value of 0 will result in a clunky, stupid driver!

Recommended settings:
speed = 30.0f,
behaviorFlag = 156, 
stoppingRange = 5.0f;

If you simply want to have your driver move to a fixed location, call it only once, or, when necessary in the event of interruption. 

If using this to continually follow a Ped who is on foot:  You will need to run this in a tick loop.  Call it in with the Ped's updated coordinates every 20 ticks or so and you will have one hell of a smart, fast-reacting NPC driver -- provided he doesn't get stuck.  If your update frequency is too fast, the Ped may not have enough time to figure his way out of being stuck, and thus, remain stuck.  One way around this would be to implement an "anti-stuck" mechanism, which allows the driver to realize he's stuck, temporarily pause the tick, unstuck, then resume the tick.

EDIT:  This is being discussed in more detail at http://gtaforums.com/topic/818504-any-idea-on-how-to-make-peds-clever-and-insanely-fast-c/  
```

---

### TASK_VEHICLE_HELI_PROTECT

- **命名空间:** `TASK`
- **Hash:** `0x1E09C32048FEFD1C`
- **JHash:** `0x0CB415EE`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_VEHICLE_HELI_PROTECT(int pilot, int vehicle, int entityToFollow, float targetSpeed, int drivingFlags, float radius, int altitude, int heliFlags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pilot` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `entityToFollow` | `Entity` | `int` | - |
| `targetSpeed` | `float` | `float` | - |
| `drivingFlags` | `int` | `int` | - |
| `radius` | `float` | `float` | - |
| `altitude` | `int` | `int` | - |
| `heliFlags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
pilot, vehicle and altitude are rather self-explanatory.

p4: is unused variable in the function.

entityToFollow: you can provide a Vehicle entity or a Ped entity, the heli will protect them.

'targetSpeed':  The pilot will dip the nose AS MUCH AS POSSIBLE so as to reach this value AS FAST AS POSSIBLE.  As such, you'll want to modulate it as opposed to calling it via a hard-wired, constant #.

'radius' isn't just "stop within radius of X of target" like with ground vehicles.  In this case, the pilot will fly an entire circle around 'radius' and continue to do so.

NOT CONFIRMED:  p7 appears to be a FlyingStyle enum.  Still investigating it as of this writing, but playing around with values here appears to result in different -behavior- as opposed to offsetting coordinates, altitude, target speed, etc.

NOTE: If the pilot finds enemies, it will engage them until it kills them, but will return to protect the ped/vehicle given shortly thereafter.
```

---

### TASK_VEHICLE_MISSION

- **命名空间:** `TASK`
- **Hash:** `0x659427E0EF36BCDE`
- **JHash:** `0x20609E56`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_VEHICLE_MISSION(int driver, int vehicle, int vehicleTarget, int missionType, float cruiseSpeed, int drivingStyle, float targetReached, float straightLineDistance, bool DriveAgainstTraffic)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `driver` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `vehicleTarget` | `Vehicle` | `int` | - |
| `missionType` | `int` | `int` | - |
| `cruiseSpeed` | `float` | `float` | - |
| `drivingStyle` | `int` | `int` | - |
| `targetReached` | `float` | `float` | - |
| `straightLineDistance` | `float` | `float` | - |
| `DriveAgainstTraffic` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
missionType: https://alloc8or.re/gta5/doc/enums/eVehicleMissionType.txt
```

---

### TASK_VEHICLE_MISSION_COORS_TARGET

- **命名空间:** `TASK`
- **Hash:** `0xF0AF20AA7731F8C3`
- **JHash:** `0x6719C109`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_VEHICLE_MISSION_COORS_TARGET(int ped, int vehicle, float x, float y, float z, int mission, float cruiseSpeed, int drivingStyle, float targetReached, float straightLineDistance, bool DriveAgainstTraffic)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `mission` | `int` | `int` | - |
| `cruiseSpeed` | `float` | `float` | - |
| `drivingStyle` | `int` | `int` | - |
| `targetReached` | `float` | `float` | - |
| `straightLineDistance` | `float` | `float` | - |
| `DriveAgainstTraffic` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
See TASK_VEHICLE_MISSION
```

---

### TASK_VEHICLE_MISSION_PED_TARGET

- **命名空间:** `TASK`
- **Hash:** `0x9454528DF15D657A`
- **JHash:** `0xC81C4677`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_VEHICLE_MISSION_PED_TARGET(int ped, int vehicle, int pedTarget, int missionType, float maxSpeed, int drivingStyle, float minDistance, float straightLineDistance, bool DriveAgainstTraffic)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `pedTarget` | `Ped` | `int` | - |
| `missionType` | `int` | `int` | - |
| `maxSpeed` | `float` | `float` | - |
| `drivingStyle` | `int` | `int` | - |
| `minDistance` | `float` | `float` | - |
| `straightLineDistance` | `float` | `float` | - |
| `DriveAgainstTraffic` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
See TASK_VEHICLE_MISSION
```

---

### TASK_VEHICLE_PARK

- **命名空间:** `TASK`
- **Hash:** `0x0F3E34E968EA374E`
- **JHash:** `0x5C85FF90`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_VEHICLE_PARK(int ped, int vehicle, float x, float y, float z, float heading, int mode, float radius, bool keepEngineOn)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `heading` | `float` | `float` | - |
| `mode` | `int` | `int` | - |
| `radius` | `float` | `float` | - |
| `keepEngineOn` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Modes:
0 - ignore heading
1 - park forward
2 - park backwards

Depending on the angle of approach, the vehicle can park at the specified heading or at its exact opposite (-180) angle.

Radius seems to define how close the vehicle has to be -after parking- to the position for this task considered completed. If the value is too small, the vehicle will try to park again until it's exactly where it should be. 20.0 Works well but lower values don't, like the radius is measured in centimeters or something.
```

---

### TASK_VEHICLE_PLAY_ANIM

- **命名空间:** `TASK`
- **Hash:** `0x69F5C3BD0F3EBD89`
- **JHash:** `0x2B28F598`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_VEHICLE_PLAY_ANIM(int vehicle, string animationSet, string animationName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `animationSet` | `const char*` | `string` | - |
| `animationName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Most probably plays a specific animation on vehicle. For example getting chop out of van etc...

Here's how its used - 

TASK::TASK_VEHICLE_PLAY_ANIM(l_325, "rcmnigel1b", "idle_speedo");

TASK::TASK_VEHICLE_PLAY_ANIM(l_556[0/*1*/], "missfra0_chop_drhome", "InCar_GetOutofBack_Speedo");

FYI : Speedo is the name of van in which chop was put in the mission.
```

---

### TASK_VEHICLE_SHOOT_AT_COORD

- **命名空间:** `TASK`
- **Hash:** `0x5190796ED39C9B6D`
- **JHash:** `0xA7AAA4D6`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_VEHICLE_SHOOT_AT_COORD(int ped, float x, float y, float z, float fireTolerance)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `fireTolerance` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_VEHICLE_SHOOT_AT_PED

- **命名空间:** `TASK`
- **Hash:** `0x10AB107B887214D8`
- **JHash:** `0x59677BA0`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_VEHICLE_SHOOT_AT_PED(int ped, int target, float fireTolerance)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `target` | `Ped` | `int` | - |
| `fireTolerance` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_VEHICLE_TEMP_ACTION

- **命名空间:** `TASK`
- **Hash:** `0xC429DCEEB339E129`
- **JHash:** `0x0679DFB8`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_VEHICLE_TEMP_ACTION(int driver, int vehicle, int action, int time)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `driver` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `action` | `int` | `int` | - |
| `time` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
'1 - brake
'3 - brake + reverse
'4 - turn left 90 + braking
'5 - turn right 90 + braking
'6 - brake strong (handbrake?) until time ends
'7 - turn left + accelerate
'8 - turn right + accelerate
'9 - weak acceleration
'10 - turn left + restore wheel pos to center in the end
'11 - turn right + restore wheel pos to center in the end
'13 - turn left + go reverse
'14 - turn left + go reverse
'16 - crash the game after like 2 seconds :)
'17 - keep actual state, game crashed after few tries
'18 - game crash
'19 - strong brake + turn left/right
'20 - weak brake + turn left then turn right
'21 - weak brake + turn right then turn left
'22 - brake + reverse
'23 - accelerate fast
'24 - brake
'25 - brake turning left then when almost stopping it turns left more
'26 - brake turning right then when almost stopping it turns right more
'27 - brake until car stop or until time ends
'28 - brake + strong reverse acceleration
'30 - performs a burnout (brake until stop + brake and accelerate)
'31 - accelerate + handbrake
'32 - accelerate very strong

Seems to be this:
Works on NPCs, but overrides their current task. If inside a task sequence (and not being the last task), "time" will work, otherwise the task will be performed forever until tasked with something else
```

---

### TASK_WANDER_IN_AREA

- **命名空间:** `TASK`
- **Hash:** `0xE054346CA3A0F315`
- **JHash:** `0xC6981FB9`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_WANDER_IN_AREA(int ped, float x, float y, float z, float radius, float minimalLength, float timeBetweenWalks)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `minimalLength` | `float` | `float` | - |
| `timeBetweenWalks` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_WANDER_SPECIFIC

- **命名空间:** `TASK`
- **Hash:** `0x6919A2F136426098`
- **Build:** `1868`

**C# 签名:**
```csharp
void TASK_WANDER_SPECIFIC(int ped, string conditionalAnimGroupStr, string conditionalAnimStr, float heading)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `conditionalAnimGroupStr` | `const char*` | `string` | - |
| `conditionalAnimStr` | `const char*` | `string` | - |
| `heading` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_WANDER_STANDARD

- **命名空间:** `TASK`
- **Hash:** `0xBB9CE077274F6A1B`
- **JHash:** `0xAF59151A`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_WANDER_STANDARD(int ped, float heading, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `heading` | `float` | `float` | - |
| `flags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Makes ped walk around the area.

set p1 to 10.0f and p2 to 10 if you want the ped to walk anywhere without a duration.
```

---

### TASK_WARP_PED_DIRECTLY_INTO_COVER

- **命名空间:** `TASK`
- **Hash:** `0x6E01E9E8D89F8276`
- **Build:** `2545`

**C# 签名:**
```csharp
void TASK_WARP_PED_DIRECTLY_INTO_COVER(int ped, int time, bool allowPeekingAndFiring, bool forceInitialFacingDirection, bool forceFaceLeft, int identifier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `time` | `int` | `int` | - |
| `allowPeekingAndFiring` | `BOOL` | `bool` | - |
| `forceInitialFacingDirection` | `BOOL` | `bool` | - |
| `forceFaceLeft` | `BOOL` | `bool` | - |
| `identifier` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TASK_WARP_PED_INTO_VEHICLE

- **命名空间:** `TASK`
- **Hash:** `0x9A7D091411C5F684`
- **JHash:** `0x65D4A35D`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_WARP_PED_INTO_VEHICLE(int ped, int vehicle, int seat)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `seat` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Seat Numbers
-------------------------------
Driver = -1
Any = -2
Left-Rear = 1
Right-Front = 0
Right-Rear = 2
Extra seats = 3-14(This may differ from vehicle type e.g. Firetruck Rear Stand, Ambulance Rear)
```

---

### TASK_WRITHE

- **命名空间:** `TASK`
- **Hash:** `0xCDDC2B77CE54AC6E`
- **JHash:** `0x0FDC54FC`
- **Build:** `323`

**C# 签名:**
```csharp
void TASK_WRITHE(int ped, int target, int minFireLoops, int startState, bool forceShootOnGround, int shootFromGroundTimer)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `target` | `Ped` | `int` | - |
| `minFireLoops` | `int` | `int` | - |
| `startState` | `int` | `int` | - |
| `forceShootOnGround` | `BOOL` | `bool` | - |
| `shootFromGroundTimer` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
EX: Function.Call(Ped1, Ped2, Time, 0);

The last parameter is always 0 for some reason I do not know. The first parameter is the pedestrian who will writhe to the pedestrian in the other parameter. The third paremeter is how long until the Writhe task ends. When the task ends, the ped will die. If set to -1, he will not die automatically, and the task will continue until something causes it to end. This can be being touched by an entity, being shot, explosion, going into ragdoll, having task cleared. Anything that ends the current task will kill the ped at this point.



Third parameter does not appear to be time. The last parameter is not implemented (It's not used, regardless of value).
```

---

### UNCUFF_PED

- **命名空间:** `TASK`
- **Hash:** `0x67406F2C8F87FC4F`
- **JHash:** `0xA23A1D61`
- **Build:** `323`

**C# 签名:**
```csharp
void UNCUFF_PED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### UPDATE_TASK_AIM_GUN_SCRIPTED_TARGET

- **命名空间:** `TASK`
- **Hash:** `0x9724FB59A3E72AD0`
- **JHash:** `0x67E73525`
- **Build:** `323`

**C# 签名:**
```csharp
void UPDATE_TASK_AIM_GUN_SCRIPTED_TARGET(int ped, int target, float x, float y, float z, bool disableBlockingClip)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `target` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `disableBlockingClip` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### UPDATE_TASK_HANDS_UP_DURATION

- **命名空间:** `TASK`
- **Hash:** `0xA98FCAFD7893C834`
- **JHash:** `0x3AA39BE9`
- **Build:** `323`

**C# 签名:**
```csharp
void UPDATE_TASK_HANDS_UP_DURATION(int ped, int duration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `duration` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### UPDATE_TASK_SWEEP_AIM_ENTITY

- **命名空间:** `TASK`
- **Hash:** `0xE4973DBDBE6E44B3`
- **JHash:** `0xF65F0F4F`
- **Build:** `323`

**C# 签名:**
```csharp
void UPDATE_TASK_SWEEP_AIM_ENTITY(int ped, int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### UPDATE_TASK_SWEEP_AIM_POSITION

- **命名空间:** `TASK`
- **Hash:** `0xBB106883F5201FC4`
- **JHash:** `0x6345EC80`
- **Build:** `323`

**C# 签名:**
```csharp
void UPDATE_TASK_SWEEP_AIM_POSITION(int ped, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### USE_WAYPOINT_RECORDING_AS_ASSISTED_MOVEMENT_ROUTE

- **命名空间:** `TASK`
- **Hash:** `0x5A353B8E6B1095B5`
- **JHash:** `0x4DFD5FEC`
- **Build:** `323`

**C# 签名:**
```csharp
void USE_WAYPOINT_RECORDING_AS_ASSISTED_MOVEMENT_ROUTE(string name, bool p1, float p2, float p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### VEHICLE_WAYPOINT_PLAYBACK_GET_IS_PAUSED

- **命名空间:** `TASK`
- **Hash:** `0xE435D3539EFDCD1B`
- **Build:** `3570`

**C# 签名:**
```csharp
bool VEHICLE_WAYPOINT_PLAYBACK_GET_IS_PAUSED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### VEHICLE_WAYPOINT_PLAYBACK_OVERRIDE_SPEED

- **命名空间:** `TASK`
- **Hash:** `0x121F0593E0A431D7`
- **JHash:** `0xBE1E7BB4`
- **Build:** `323`

**C# 签名:**
```csharp
void VEHICLE_WAYPOINT_PLAYBACK_OVERRIDE_SPEED(int vehicle, float speed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `speed` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### VEHICLE_WAYPOINT_PLAYBACK_PAUSE

- **命名空间:** `TASK`
- **Hash:** `0x8A4E6AC373666BC5`
- **JHash:** `0x7C00B415`
- **Build:** `323`

**C# 签名:**
```csharp
void VEHICLE_WAYPOINT_PLAYBACK_PAUSE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### VEHICLE_WAYPOINT_PLAYBACK_RESUME

- **命名空间:** `TASK`
- **Hash:** `0xDC04FCAA7839D492`
- **JHash:** `0xBEB14C82`
- **Build:** `323`

**C# 签名:**
```csharp
void VEHICLE_WAYPOINT_PLAYBACK_RESUME(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### VEHICLE_WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED

- **命名空间:** `TASK`
- **Hash:** `0x5CEB25A7D2848963`
- **JHash:** `0x923C3AA4`
- **Build:** `323`

**C# 签名:**
```csharp
void VEHICLE_WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### WAYPOINT_PLAYBACK_GET_IS_PAUSED

- **命名空间:** `TASK`
- **Hash:** `0x701375A7D43F01CB`
- **JHash:** `0xA6BB5717`
- **Build:** `323`

**C# 签名:**
```csharp
bool WAYPOINT_PLAYBACK_GET_IS_PAUSED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### WAYPOINT_PLAYBACK_OVERRIDE_SPEED

- **命名空间:** `TASK`
- **Hash:** `0x7D7D2B47FA788E85`
- **JHash:** `0x23E6BA96`
- **Build:** `323`

**C# 签名:**
```csharp
void WAYPOINT_PLAYBACK_OVERRIDE_SPEED(object p0, float p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `float` | `float` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### WAYPOINT_PLAYBACK_PAUSE

- **命名空间:** `TASK`
- **Hash:** `0x0F342546AA06FED5`
- **JHash:** `0xFE39ECF8`
- **Build:** `323`

**C# 签名:**
```csharp
void WAYPOINT_PLAYBACK_PAUSE(object p0, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### WAYPOINT_PLAYBACK_RESUME

- **命名空间:** `TASK`
- **Hash:** `0x244F70C84C547D2D`
- **JHash:** `0x50F392EF`
- **Build:** `323`

**C# 签名:**
```csharp
void WAYPOINT_PLAYBACK_RESUME(object p0, bool p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### WAYPOINT_PLAYBACK_START_AIMING_AT_COORD

- **命名空间:** `TASK`
- **Hash:** `0x8968400D900ED8B3`
- **JHash:** `0xF120A34E`
- **Build:** `323`

**C# 签名:**
```csharp
void WAYPOINT_PLAYBACK_START_AIMING_AT_COORD(int ped, float x, float y, float z, bool p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p4` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### WAYPOINT_PLAYBACK_START_AIMING_AT_PED

- **命名空间:** `TASK`
- **Hash:** `0x20E330937C399D29`
- **JHash:** `0x75E60CF6`
- **Build:** `323`

**C# 签名:**
```csharp
void WAYPOINT_PLAYBACK_START_AIMING_AT_PED(int ped, int target, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `target` | `Ped` | `int` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### WAYPOINT_PLAYBACK_START_SHOOTING_AT_COORD

- **命名空间:** `TASK`
- **Hash:** `0x057A25CFCC9DB671`
- **JHash:** `0xCDDB44D5`
- **Build:** `323`

**C# 签名:**
```csharp
void WAYPOINT_PLAYBACK_START_SHOOTING_AT_COORD(int ped, float x, float y, float z, bool p4, uint firingPattern)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p4` | `BOOL` | `bool` | - |
| `firingPattern` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### WAYPOINT_PLAYBACK_START_SHOOTING_AT_PED

- **命名空间:** `TASK`
- **Hash:** `0xE70BA7B90F8390DC`
- **JHash:** `0xBD5F0EB8`
- **Build:** `323`

**C# 签名:**
```csharp
void WAYPOINT_PLAYBACK_START_SHOOTING_AT_PED(int ped, int ped2, bool p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `ped2` | `Ped` | `int` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### WAYPOINT_PLAYBACK_STOP_AIMING_OR_SHOOTING

- **命名空间:** `TASK`
- **Hash:** `0x47EFA040EBB8E2EA`
- **JHash:** `0x6D7CF40C`
- **Build:** `323`

**C# 签名:**
```csharp
void WAYPOINT_PLAYBACK_STOP_AIMING_OR_SHOOTING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED

- **命名空间:** `TASK`
- **Hash:** `0x6599D834B12D0800`
- **JHash:** `0x1BBB2CAC`
- **Build:** `323`

**C# 签名:**
```csharp
void WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### WAYPOINT_RECORDING_GET_CLOSEST_WAYPOINT

- **命名空间:** `TASK`
- **Hash:** `0xB629A298081F876F`
- **JHash:** `0xC4CD35AF`
- **Build:** `323`

**C# 签名:**
```csharp
bool WAYPOINT_RECORDING_GET_CLOSEST_WAYPOINT(string name, float x, float y, float z, ref int point)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `point` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/waypointRecordings.json
For a full list of the points, see here: goo.gl/wIH0vn
```

---

### WAYPOINT_RECORDING_GET_COORD

- **命名空间:** `TASK`
- **Hash:** `0x2FB897405C90B361`
- **JHash:** `0x19266913`
- **Build:** `323`

**C# 签名:**
```csharp
bool WAYPOINT_RECORDING_GET_COORD(string name, int point, ref Vector3 coord)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |
| `point` | `int` | `int` | - |
| `coord` | `Vector3*` | `ref Vector3` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/waypointRecordings.json
For a full list of the points, see here: goo.gl/wIH0vn
```

---

### WAYPOINT_RECORDING_GET_NUM_POINTS

- **命名空间:** `TASK`
- **Hash:** `0x5343532C01A07234`
- **JHash:** `0xF5F9B71E`
- **Build:** `323`

**C# 签名:**
```csharp
bool WAYPOINT_RECORDING_GET_NUM_POINTS(string name, ref int points)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |
| `points` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/waypointRecordings.json
For a full list of the points, see here: goo.gl/wIH0vn
```

---

### WAYPOINT_RECORDING_GET_SPEED_AT_POINT

- **命名空间:** `TASK`
- **Hash:** `0x005622AEBC33ACA9`
- **JHash:** `0xC765633A`
- **Build:** `323`

**C# 签名:**
```csharp
float WAYPOINT_RECORDING_GET_SPEED_AT_POINT(string name, int point)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |
| `point` | `int` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/waypointRecordings.json
```

---

### _SET_AMBIENT_PED_ENABLE_COLLISION_ON_NETWORK_CLONE_WHEN_FIXED

- **命名空间:** `TASK`
- **Hash:** `0x0EFE4834A2F40563`
- **Build:** `3570`

**C# 签名:**
```csharp
void _SET_AMBIENT_PED_ENABLE_COLLISION_ON_NETWORK_CLONE_WHEN_FIXED(int ped, bool enable)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `enable` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### _SET_SCRIPT_TASK_ENABLE_COLLISION_ON_NETWORK_CLONE_WHEN_FIXED

- **命名空间:** `TASK`
- **Hash:** `0x32F6EEF031F943DC`
- **Build:** `3095`

**C# 签名:**
```csharp
void _SET_SCRIPT_TASK_ENABLE_COLLISION_ON_NETWORK_CLONE_WHEN_FIXED(int ped, bool enable)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `enable` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---
