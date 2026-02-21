# VEHICLE - Native 函数参考

> 命名空间: VEHICLE

---

## 快速索引

| 函数名 | C# 签名 | 返回值 | 说明 |
|--------|---------|--------|------|
| `ADD_ROAD_NODE_SPEED_ZONE` | `int ADD_ROAD_NODE_SPEED_ZONE(float x, float y, float z, float radius, float speed, bool p5)` | int | - |
| `ADD_VEHICLE_COMBAT_ANGLED_AVOIDANCE_AREA` | `int ADD_VEHICLE_COMBAT_ANGLED_AVOIDANCE_AREA(float p0, float p1, float p2, float p3, float p4, float p5, float p6)` | int | - |
| `ADD_VEHICLE_PHONE_EXPLOSIVE_DEVICE` | `void ADD_VEHICLE_PHONE_EXPLOSIVE_DEVICE(int vehicle)` | void | - |
| `ADD_VEHICLE_STUCK_CHECK_WITH_WARP` | `void ADD_VEHICLE_STUCK_CHECK_WITH_WARP(object p0, float p1, object p2, bool p3, bool p4, bool p5, object p6)` | void | - |
| `ADD_VEHICLE_UPSIDEDOWN_CHECK` | `void ADD_VEHICLE_UPSIDEDOWN_CHECK(int vehicle)` | void | - |
| `ALLOW_AMBIENT_VEHICLES_TO_AVOID_ADVERSE_CONDITIONS` | `void ALLOW_AMBIENT_VEHICLES_TO_AVOID_ADVERSE_CONDITIONS(int vehicle)` | void | This native doesn't seem to do anything, might be a debug-only native.<br><br>Confirmed, it is a debug nat... |
| `ALLOW_BOAT_BOOM_TO_ANIMATE` | `void ALLOW_BOAT_BOOM_TO_ANIMATE(int vehicle, bool toggle)` | void | - |
| `ALLOW_TRAIN_TO_BE_REMOVED_BY_POPULATION` | `void ALLOW_TRAIN_TO_BE_REMOVED_BY_POPULATION(object p0)` | void | - |
| `APPLY_EMP_EFFECT` | `void APPLY_EMP_EFFECT(int vehicle)` | void | - |
| `ARE_ALL_VEHICLE_WINDOWS_INTACT` | `bool ARE_ALL_VEHICLE_WINDOWS_INTACT(int vehicle)` | bool | Appears to return false if any window is broken. |
| `ARE_ANY_VEHICLE_SEATS_FREE` | `bool ARE_ANY_VEHICLE_SEATS_FREE(int vehicle)` | bool | Returns false if every seat is occupied. |
| `ARE_FOLDING_WINGS_DEPLOYED` | `bool ARE_FOLDING_WINGS_DEPLOYED(int vehicle)` | bool | Only used with the "akula" and "annihilator2" in the decompiled native scripts. |
| `ARE_PLANE_CONTROL_PANELS_INTACT` | `bool ARE_PLANE_CONTROL_PANELS_INTACT(int vehicle, bool p1)` | bool | - |
| `ARE_PLANE_PROPELLERS_INTACT` | `bool ARE_PLANE_PROPELLERS_INTACT(int plane)` | bool | - |
| `ARE_WINGS_OF_PLANE_INTACT` | `bool ARE_WINGS_OF_PLANE_INTACT(int plane)` | bool | - |
| `ATTACH_CONTAINER_TO_HANDLER_FRAME_WHEN_LINED_UP` | `void ATTACH_CONTAINER_TO_HANDLER_FRAME_WHEN_LINED_UP(int vehicle, int entity)` | void | - |
| `ATTACH_ENTITY_TO_CARGOBOB` | `void ATTACH_ENTITY_TO_CARGOBOB(object p0, object p1, object p2, object p3, object p4, object p5)` | void | - |
| `ATTACH_VEHICLE_ON_TO_TRAILER` | `void ATTACH_VEHICLE_ON_TO_TRAILER(int vehicle, int trailer, float offsetX, float offsetY, float offsetZ, float coordsX, float coordsY, float coordsZ, float rotationX, float rotationY, float rotationZ, float disableCollisions)` | void | This is the proper way of attaching vehicles to the car carrier, it's what Rockstar uses. Video Demo... |
| `ATTACH_VEHICLE_TO_CARGOBOB` | `void ATTACH_VEHICLE_TO_CARGOBOB(int cargobob, int vehicle, int p2, float x, float y, float z)` | void | - |
| `ATTACH_VEHICLE_TO_TOW_TRUCK` | `void ATTACH_VEHICLE_TO_TOW_TRUCK(int towTruck, int vehicle, bool rear, float hookOffsetX, float hookOffsetY, float hookOffsetZ)` | void | HookOffset defines where the hook is attached. leave at 0 for default attachment. |
| `ATTACH_VEHICLE_TO_TRAILER` | `void ATTACH_VEHICLE_TO_TRAILER(int vehicle, int trailer, float radius)` | void | - |
| `BRING_VEHICLE_TO_HALT` | `void BRING_VEHICLE_TO_HALT(int vehicle, float distance, int duration, bool p3)` | void | This native makes the vehicle stop immediately, as happens when we enter a MP garage.<br><br>. distance de... |
| `CAN_ANCHOR_BOAT_HERE` | `bool CAN_ANCHOR_BOAT_HERE(int vehicle)` | bool | - |
| `CAN_ANCHOR_BOAT_HERE_IGNORE_PLAYERS` | `bool CAN_ANCHOR_BOAT_HERE_IGNORE_PLAYERS(int vehicle)` | bool | - |
| `CAN_CARGOBOB_PICK_UP_ENTITY` | `bool CAN_CARGOBOB_PICK_UP_ENTITY(object p0, object p1)` | bool | - |
| `CAN_SHUFFLE_SEAT` | `bool CAN_SHUFFLE_SEAT(int vehicle, int seatIndex)` | bool | - |
| `CLEAR_LAST_DRIVEN_VEHICLE` | `void CLEAR_LAST_DRIVEN_VEHICLE()` | void | - |
| `CLEAR_NITROUS` | `void CLEAR_NITROUS(int vehicle)` | void | - |
| `CLEAR_VEHICLE_CUSTOM_PRIMARY_COLOUR` | `void CLEAR_VEHICLE_CUSTOM_PRIMARY_COLOUR(int vehicle)` | void | - |
| `CLEAR_VEHICLE_CUSTOM_SECONDARY_COLOUR` | `void CLEAR_VEHICLE_CUSTOM_SECONDARY_COLOUR(int vehicle)` | void | - |
| `CLEAR_VEHICLE_GENERATOR_AREA_OF_INTEREST` | `void CLEAR_VEHICLE_GENERATOR_AREA_OF_INTEREST()` | void | - |
| `CLEAR_VEHICLE_PETROLTANK_FIRE_CULPRIT` | `void CLEAR_VEHICLE_PETROLTANK_FIRE_CULPRIT(int vehicle)` | void | - |
| `CLEAR_VEHICLE_PHONE_EXPLOSIVE_DEVICE` | `void CLEAR_VEHICLE_PHONE_EXPLOSIVE_DEVICE()` | void | - |
| `CLEAR_VEHICLE_ROUTE_HISTORY` | `void CLEAR_VEHICLE_ROUTE_HISTORY(int vehicle)` | void | - |
| `CLOSE_BOMB_BAY_DOORS` | `void CLOSE_BOMB_BAY_DOORS(int vehicle)` | void | - |
| `CONTROL_LANDING_GEAR` | `void CONTROL_LANDING_GEAR(int vehicle, int state)` | void | Works for vehicles with a retractable landing gear<br><br>Landing gear states:<br><br>0: Deployed<br>1: Closing<br>2: ... |
| `COPY_VEHICLE_DAMAGES` | `void COPY_VEHICLE_DAMAGES(int sourceVehicle, int targetVehicle)` | void | Copies sourceVehicle's damage (broken bumpers, broken lights, etc.) to targetVehicle. |
| `CREATE_MISSION_TRAIN` | `int CREATE_MISSION_TRAIN(int variation, float x, float y, float z, bool direction, object p5, object p6)` | int | Train models HAVE TO be loaded (requested) before you use this.<br>For variation 15 - request:<br><br>freight... |
| `CREATE_PICK_UP_ROPE_FOR_CARGOBOB` | `void CREATE_PICK_UP_ROPE_FOR_CARGOBOB(int cargobob, int state)` | void | Drops the Hook/Magnet on a cargobob<br><br>state<br>enum eCargobobHook<br>{<br>  CARGOBOB_HOOK = 0,<br>    CARGOBOB_MA... |
| `CREATE_SCRIPT_VEHICLE_GENERATOR` | `int CREATE_SCRIPT_VEHICLE_GENERATOR(float x, float y, float z, float heading, float p4, float p5, uint modelHash, int p7, int p8, int p9, int p10, bool p11, bool p12, bool p13, bool p14, bool p15, int p16)` | int | Creates a script vehicle generator at the given coordinates. Most parameters after the model hash ar... |
| `CREATE_VEHICLE` | `int CREATE_VEHICLE(uint modelHash, float x, float y, float z, float heading, bool isNetwork, bool bScriptHostVeh, bool p7)` | int | p7 when set to true allows you to spawn vehicles under -100 z.<br>Full list of vehicles by DurtyFree: h... |
| `DELETE_ALL_TRAINS` | `void DELETE_ALL_TRAINS()` | void | - |
| `DELETE_MISSION_TRAIN` | `void DELETE_MISSION_TRAIN(Vehicle* train)` | void | - |
| `DELETE_SCRIPT_VEHICLE_GENERATOR` | `void DELETE_SCRIPT_VEHICLE_GENERATOR(int vehicleGenerator)` | void | - |
| `DELETE_VEHICLE` | `void DELETE_VEHICLE(Vehicle* vehicle)` | void | Deletes a vehicle.<br>The vehicle must be a mission entity to delete, so call this before deleting: SET... |
| `DETACH_CONTAINER_FROM_HANDLER_FRAME` | `void DETACH_CONTAINER_FROM_HANDLER_FRAME(int vehicle)` | void | - |
| `DETACH_ENTITY_FROM_CARGOBOB` | `bool DETACH_ENTITY_FROM_CARGOBOB(int cargobob, int entity)` | bool | - |
| `DETACH_VEHICLE_FROM_ANY_CARGOBOB` | `bool DETACH_VEHICLE_FROM_ANY_CARGOBOB(int vehicle)` | bool | - |
| `DETACH_VEHICLE_FROM_ANY_TOW_TRUCK` | `bool DETACH_VEHICLE_FROM_ANY_TOW_TRUCK(int vehicle)` | bool | - |
| `DETACH_VEHICLE_FROM_CARGOBOB` | `void DETACH_VEHICLE_FROM_CARGOBOB(int vehicle, int cargobob)` | void | - |
| `DETACH_VEHICLE_FROM_TOW_TRUCK` | `void DETACH_VEHICLE_FROM_TOW_TRUCK(int towTruck, int vehicle)` | void | First two parameters swapped. Scripts verify that towTruck is the first parameter, not the second. |
| `DETACH_VEHICLE_FROM_TRAILER` | `void DETACH_VEHICLE_FROM_TRAILER(int vehicle)` | void | - |
| `DETONATE_VEHICLE_PHONE_EXPLOSIVE_DEVICE` | `void DETONATE_VEHICLE_PHONE_EXPLOSIVE_DEVICE()` | void | - |
| `DISABLE_INDIVIDUAL_PLANE_PROPELLER` | `void DISABLE_INDIVIDUAL_PLANE_PROPELLER(int vehicle, int propeller)` | void | - |
| `DISABLE_PLANE_AILERON` | `void DISABLE_PLANE_AILERON(int vehicle, bool p1, bool p2)` | void | - |
| `DISABLE_VEHCILE_DYNAMIC_AMBIENT_SCALES` | `void DISABLE_VEHCILE_DYNAMIC_AMBIENT_SCALES(int vehicle, int p1, int p2)` | void | Adds some kind of shadow to the vehicle.<br><br>p1 and p2 use values from 0-255 and both make the shadow d... |
| `DISABLE_VEHICLE_EXPLOSION_BREAK_OFF_PARTS` | `void DISABLE_VEHICLE_EXPLOSION_BREAK_OFF_PARTS()` | void | - |
| `DISABLE_VEHICLE_TURRET_MOVEMENT_THIS_FRAME` | `void DISABLE_VEHICLE_TURRET_MOVEMENT_THIS_FRAME(int vehicle)` | void | - |
| `DISABLE_VEHICLE_WEAPON` | `void DISABLE_VEHICLE_WEAPON(bool disabled, uint weaponHash, int vehicle, int owner)` | void | Full list of weapons by DurtyFree (Search for VEHICLE_*): https://github.com/DurtyFree/gta-v-data-du... |
| `DOES_CARGOBOB_HAVE_PICKUP_MAGNET` | `bool DOES_CARGOBOB_HAVE_PICKUP_MAGNET(int cargobob)` | bool | Returns true only when the magnet is active, will return false if the hook is active |
| `DOES_CARGOBOB_HAVE_PICK_UP_ROPE` | `bool DOES_CARGOBOB_HAVE_PICK_UP_ROPE(int cargobob)` | bool | Returns true only when the hook is active, will return false if the magnet is active |
| `DOES_EXTRA_EXIST` | `bool DOES_EXTRA_EXIST(int vehicle, int extraId)` | bool | Checks via CVehicleModelInfo |
| `DOES_SCRIPT_VEHICLE_GENERATOR_EXIST` | `bool DOES_SCRIPT_VEHICLE_GENERATOR_EXIST(int vehicleGenerator)` | bool | - |
| `DOES_VEHICLE_ALLOW_RAPPEL` | `bool DOES_VEHICLE_ALLOW_RAPPEL(int vehicle)` | bool | Returns true if the vehicle has the FLAG_ALLOWS_RAPPEL flag set. |
| `DOES_VEHICLE_EXIST_WITH_DECORATOR` | `int DOES_VEHICLE_EXIST_WITH_DECORATOR(string decorator)` | int | - |
| `DOES_VEHICLE_HAVE_ROOF` | `bool DOES_VEHICLE_HAVE_ROOF(int vehicle)` | bool | - |
| `DOES_VEHICLE_HAVE_SEARCHLIGHT` | `bool DOES_VEHICLE_HAVE_SEARCHLIGHT(int vehicle)` | bool | - |
| `DOES_VEHICLE_HAVE_STUCK_VEHICLE_CHECK` | `bool DOES_VEHICLE_HAVE_STUCK_VEHICLE_CHECK(int vehicle)` | bool | Maximum amount of vehicles with vehicle stuck check appears to be 16. |
| `DOES_VEHICLE_HAVE_WEAPONS` | `bool DOES_VEHICLE_HAVE_WEAPONS(int vehicle)` | bool | - |
| `ENABLE_VEHICLE_DYNAMIC_AMBIENT_SCALES` | `void ENABLE_VEHICLE_DYNAMIC_AMBIENT_SCALES(int vehicle)` | void | Remove the weird shadow applied by DISABLE_VEHCILE_DYNAMIC_AMBIENT_SCALES. |
| `EXPLODE_VEHICLE` | `void EXPLODE_VEHICLE(int vehicle, bool isAudible, bool isInvisible)` | void | Explodes a selected vehicle.<br><br>Vehicle vehicle = Vehicle you want to explode.<br>BOOL isAudible = If exp... |
| `EXPLODE_VEHICLE_IN_CUTSCENE` | `void EXPLODE_VEHICLE_IN_CUTSCENE(int vehicle, bool p1)` | void | - |
| `FIND_HANDLER_VEHICLE_CONTAINER_IS_ATTACHED_TO` | `int FIND_HANDLER_VEHICLE_CONTAINER_IS_ATTACHED_TO(int entity)` | int | Finds the vehicle that is carrying this entity with a handler frame.<br>The model of the entity must be... |
| `FIND_SPAWN_COORDINATES_FOR_HELI` | `Vector3 FIND_SPAWN_COORDINATES_FOR_HELI(int ped)` | Vector3 | Native is significantly more complicated than simply generating a random vector & length.<br>The 'point... |
| `FIX_VEHICLE_WINDOW` | `void FIX_VEHICLE_WINDOW(int vehicle, int windowIndex)` | void | windowIndex:<br>0 = Front Left Window<br>1 = Front Right Window<br>2 = Rear Left Window<br>3 = Rear Right Window... |
| `FORCE_PLAYBACK_RECORDED_VEHICLE_UPDATE` | `void FORCE_PLAYBACK_RECORDED_VEHICLE_UPDATE(int vehicle, bool p1)` | void | Often called after START_PLAYBACK_RECORDED_VEHICLE and SKIP_TIME_IN_PLAYBACK_RECORDED_VEHICLE; simil... |
| `FORCE_SUBMARINE_NEURTAL_BUOYANCY` | `void FORCE_SUBMARINE_NEURTAL_BUOYANCY(object p0, object p1)` | void | - |
| `FORCE_SUBMARINE_SURFACE_MODE` | `void FORCE_SUBMARINE_SURFACE_MODE(int vehicle, bool toggle)` | void | - |
| `FORCE_SUB_THROTTLE_FOR_TIME` | `void FORCE_SUB_THROTTLE_FOR_TIME(int vehicle, float p1, float p2)` | void | - |
| `FULLY_CHARGE_NITROUS` | `void FULLY_CHARGE_NITROUS(int vehicle)` | void | - |
| `GENERATE_VEHICLE_CREATION_POS_FROM_PATHS` | `bool GENERATE_VEHICLE_CREATION_POS_FROM_PATHS(ref Vector3 outVec, object p1, ref Vector3 outVec1, object p3, object p4, object p5, object p6, object p7, object p8)` | bool | - |
| `GET_ALL_VEHICLES` | `int GET_ALL_VEHICLES(ref object vehsStruct)` | int | - |
| `GET_ARE_BOMB_BAY_DOORS_OPEN` | `bool GET_ARE_BOMB_BAY_DOORS_OPEN(int aircraft)` | bool | Returns true when the bomb bay doors of this plane are open. False if they're closed. |
| `GET_ATTACHED_PICK_UP_HOOK_POSITION` | `Vector3 GET_ATTACHED_PICK_UP_HOOK_POSITION(int cargobob)` | Vector3 | Gets the position of the cargobob hook, in world coords. |
| `GET_BOAT_BOOM_POSITION_RATIO` | `float GET_BOAT_BOOM_POSITION_RATIO(int vehicle)` | float | - |
| `GET_BOAT_VEHICLE_MODEL_AGILITY` | `float GET_BOAT_VEHICLE_MODEL_AGILITY(uint modelHash)` | float | Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicl... |
| `GET_BOTH_VEHICLE_HEADLIGHTS_DAMAGED` | `bool GET_BOTH_VEHICLE_HEADLIGHTS_DAMAGED(int vehicle)` | bool | Returns true when both headlights are broken. This does not include extralights. |
| `GET_CAN_VEHICLE_BE_PLACED_HERE` | `bool GET_CAN_VEHICLE_BE_PLACED_HERE(int vehicle, float x, float y, float z, float rotX, float rotY, float rotZ, int p7, object p8)` | bool | Used in decompiled scripts in combination with GET_VEHICLE_SIZE<br>p7 is usually 2<br>p8 is usually 1 |
| `GET_CAR_HAS_JUMP` | `bool GET_CAR_HAS_JUMP(int vehicle)` | bool | Returns true if the vehicle has the FLAG_JUMPING_CAR flag set. |
| `GET_CLOSEST_VEHICLE` | `int GET_CLOSEST_VEHICLE(float x, float y, float z, float radius, uint modelHash, int flags)` | int | Example usage<br>VEHICLE::GET_CLOSEST_VEHICLE(x, y, z, radius, hash, unknown leave at 70) <br><br>x, y, z: Po... |
| `GET_CONVERTIBLE_ROOF_STATE` | `int GET_CONVERTIBLE_ROOF_STATE(int vehicle)` | int | 0 -> up<br>1 -> lowering down<br>2 -> down<br>3 -> raising up |
| `GET_CURRENT_PLAYBACK_FOR_VEHICLE` | `int GET_CURRENT_PLAYBACK_FOR_VEHICLE(int vehicle)` | int | - |
| `GET_DISPLAY_NAME_FROM_VEHICLE_MODEL` | `string GET_DISPLAY_NAME_FROM_VEHICLE_MODEL(uint modelHash)` | string | Returns model name of vehicle in all caps. Needs to be displayed through localizing text natives to ... |
| `GET_DOES_VEHICLE_HAVE_DAMAGE_DECALS` | `bool GET_DOES_VEHICLE_HAVE_DAMAGE_DECALS(int vehicle)` | bool | Appears to return true if the vehicle has any damage, including cosmetically. |
| `GET_DOES_VEHICLE_HAVE_TOMBSTONE` | `bool GET_DOES_VEHICLE_HAVE_TOMBSTONE(int vehicle)` | bool | Returns true only if the "tombstone" bone is attached to the vehicle, irrespective of "FLAG_HAS_TOMB... |
| `GET_DRIFT_TYRES_SET` | `bool GET_DRIFT_TYRES_SET(int vehicle)` | bool | - |
| `GET_ENTITY_ATTACHED_TO_CARGOBOB` | `int GET_ENTITY_ATTACHED_TO_CARGOBOB(object p0)` | int | - |
| `GET_ENTITY_ATTACHED_TO_TOW_TRUCK` | `int GET_ENTITY_ATTACHED_TO_TOW_TRUCK(int towTruck)` | int | - |
| `GET_ENTRY_POINT_POSITION` | `Vector3 GET_ENTRY_POINT_POSITION(int vehicle, int doorId)` | Vector3 | doorId: see SET_VEHICLE_DOOR_SHUT |
| `GET_FAKE_SUSPENSION_LOWERING_AMOUNT` | `float GET_FAKE_SUSPENSION_LOWERING_AMOUNT(int vehicle)` | float | Gets the height of the vehicle's suspension.<br>The higher the value the lower the suspension. Each 0.0... |
| `GET_FLYING_VEHICLE_MODEL_AGILITY` | `float GET_FLYING_VEHICLE_MODEL_AGILITY(uint modelHash)` | float | Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicl... |
| `GET_HAS_RETRACTABLE_WHEELS` | `bool GET_HAS_RETRACTABLE_WHEELS(int vehicle)` | bool | - |
| `GET_HAS_ROCKET_BOOST` | `bool GET_HAS_ROCKET_BOOST(int vehicle)` | bool | - |
| `GET_HAS_VEHICLE_BEEN_HIT_BY_SHUNT` | `bool GET_HAS_VEHICLE_BEEN_HIT_BY_SHUNT(int vehicle)` | bool | - |
| `GET_HELI_MAIN_ROTOR_HEALTH` | `float GET_HELI_MAIN_ROTOR_HEALTH(int vehicle)` | float | Max 1000.<br>At 0 the main rotor will stall. |
| `GET_HELI_TAIL_BOOM_HEALTH` | `float GET_HELI_TAIL_BOOM_HEALTH(int vehicle)` | float | Max 1000.<br>At -100 both helicopter rotors will stall. |
| `GET_HELI_TAIL_ROTOR_HEALTH` | `float GET_HELI_TAIL_ROTOR_HEALTH(int vehicle)` | float | Max 1000.<br>At 0 the tail rotor will stall. |
| `GET_HYDRAULIC_SUSPENSION_RAISE_FACTOR` | `float GET_HYDRAULIC_SUSPENSION_RAISE_FACTOR(int vehicle, int wheelId)` | float | - |
| `GET_IN_VEHICLE_CLIPSET_HASH_FOR_SEAT` | `uint GET_IN_VEHICLE_CLIPSET_HASH_FOR_SEAT(int vehicle, int p1)` | uint | - |
| `GET_IS_BOAT_CAPSIZED` | `bool GET_IS_BOAT_CAPSIZED(int vehicle)` | bool | - |
| `GET_IS_DOOR_VALID` | `bool GET_IS_DOOR_VALID(int vehicle, int doorId)` | bool | doorId: see SET_VEHICLE_DOOR_SHUT |
| `GET_IS_LEFT_VEHICLE_HEADLIGHT_DAMAGED` | `bool GET_IS_LEFT_VEHICLE_HEADLIGHT_DAMAGED(int vehicle)` | bool | From the driver's perspective, is the left headlight broken. |
| `GET_IS_RIGHT_VEHICLE_HEADLIGHT_DAMAGED` | `bool GET_IS_RIGHT_VEHICLE_HEADLIGHT_DAMAGED(int vehicle)` | bool | From the driver's perspective, is the right headlight broken. |
| `GET_IS_VEHICLE_DISABLED_BY_EMP` | `bool GET_IS_VEHICLE_DISABLED_BY_EMP(int vehicle)` | bool | Returns whether this vehicle is currently disabled by an EMP mine. |
| `GET_IS_VEHICLE_ENGINE_RUNNING` | `bool GET_IS_VEHICLE_ENGINE_RUNNING(int vehicle)` | bool | Returns true when in a vehicle, false whilst entering/exiting. |
| `GET_IS_VEHICLE_PRIMARY_COLOUR_CUSTOM` | `bool GET_IS_VEHICLE_PRIMARY_COLOUR_CUSTOM(int vehicle)` | bool | - |
| `GET_IS_VEHICLE_SECONDARY_COLOUR_CUSTOM` | `bool GET_IS_VEHICLE_SECONDARY_COLOUR_CUSTOM(int vehicle)` | bool | Check if Vehicle Secondary is avaliable for customize |
| `GET_IS_VEHICLE_SHUNTING` | `bool GET_IS_VEHICLE_SHUNTING(int vehicle)` | bool | - |
| `GET_IS_WHEELS_RETRACTED` | `bool GET_IS_WHEELS_RETRACTED(int vehicle)` | bool | - |
| `GET_LANDING_GEAR_STATE` | `int GET_LANDING_GEAR_STATE(int vehicle)` | int | Landing gear states:<br><br>0: Deployed<br>1: Closing (Retracting)<br>2: (Landing gear state 2 is never used.)<br>3... |
| `GET_LAST_DRIVEN_VEHICLE` | `int GET_LAST_DRIVEN_VEHICLE()` | int | - |
| `GET_LAST_PED_IN_VEHICLE_SEAT` | `int GET_LAST_PED_IN_VEHICLE_SEAT(int vehicle, int seatIndex)` | int | - |
| `GET_LAST_SHUNT_VEHICLE` | `int GET_LAST_SHUNT_VEHICLE(int vehicle)` | int | Returns last vehicle that was rammed by the given vehicle using the shunt boost. |
| `GET_LIVERY_NAME` | `string GET_LIVERY_NAME(int vehicle, int liveryIndex)` | string | Returns the text label of the vehicle's liveryIndex, as specified by the liveryNames section of the ... |
| `GET_MAKE_NAME_FROM_VEHICLE_MODEL` | `string GET_MAKE_NAME_FROM_VEHICLE_MODEL(uint modelHash)` | string | Will return a vehicle's manufacturer display label.<br>Returns "CARNOTFOUND" if the hash doesn't match ... |
| `GET_MOD_SLOT_NAME` | `string GET_MOD_SLOT_NAME(int vehicle, int modType)` | string | Returns the name for the type of vehicle mod(Armour, engine etc)<br> |
| `GET_MOD_TEXT_LABEL` | `string GET_MOD_TEXT_LABEL(int vehicle, int modType, int modValue)` | string | Returns the text label of a mod type for a given vehicle<br><br>Use GET_FILENAME_FOR_AUDIO_CONVERSATION to... |
| `GET_NUMBER_OF_VEHICLE_COLOURS` | `int GET_NUMBER_OF_VEHICLE_COLOURS(int vehicle)` | int | Returns the total amount of color combinations found in the vehicle's carvariations.meta entry. |
| `GET_NUMBER_OF_VEHICLE_DOORS` | `int GET_NUMBER_OF_VEHICLE_DOORS(int vehicle)` | int | - |
| `GET_NUMBER_OF_VEHICLE_NUMBER_PLATES` | `int GET_NUMBER_OF_VEHICLE_NUMBER_PLATES()` | int | Returns the number of *types* of licence plates, enumerated below in SET_VEHICLE_NUMBER_PLATE_TEXT_I... |
| `GET_NUM_MOD_COLORS` | `int GET_NUM_MOD_COLORS(int paintType, bool p1)` | int | paintType:<br>0: Normal<br>1: Metallic<br>2: Pearl<br>3: Matte<br>4: Metal<br>5: Chrome<br>6: Chameleon |
| `GET_NUM_MOD_KITS` | `int GET_NUM_MOD_KITS(int vehicle)` | int | - |
| `GET_NUM_VEHICLE_MODS` | `int GET_NUM_VEHICLE_MODS(int vehicle, int modType)` | int | Returns how many possible mods a vehicle has for a given mod type |
| `GET_NUM_VEHICLE_WINDOW_TINTS` | `int GET_NUM_VEHICLE_WINDOW_TINTS()` | int | - |
| `GET_OUTRIGGERS_DEPLOYED` | `bool GET_OUTRIGGERS_DEPLOYED(int vehicle)` | bool | Checks if Chernobog's stabilizers are deployed or not.<br>These are the metal supports that allow it to... |
| `GET_PED_IN_VEHICLE_SEAT` | `int GET_PED_IN_VEHICLE_SEAT(int vehicle, int seatIndex, bool p2)` | int | If there is no ped in the seat, and the game considers the vehicle as ambient population, this will ... |
| `GET_PED_USING_VEHICLE_DOOR` | `int GET_PED_USING_VEHICLE_DOOR(int vehicle, int doord)` | int | doorId: see SET_VEHICLE_DOOR_SHUT |
| `GET_POSITION_IN_RECORDING` | `float GET_POSITION_IN_RECORDING(int vehicle)` | float | Distance traveled in the vehicles current recording. |
| `GET_POSITION_OF_VEHICLE_RECORDING_AT_TIME` | `Vector3 GET_POSITION_OF_VEHICLE_RECORDING_AT_TIME(int recording, float time, string script)` | Vector3 | This native does no interpolation between pathpoints. The same position will be returned for all tim... |
| `GET_POSITION_OF_VEHICLE_RECORDING_ID_AT_TIME` | `Vector3 GET_POSITION_OF_VEHICLE_RECORDING_ID_AT_TIME(int id, float time)` | Vector3 | - |
| `GET_RANDOM_VEHICLE_BACK_BUMPER_IN_SPHERE` | `int GET_RANDOM_VEHICLE_BACK_BUMPER_IN_SPHERE(float p0, float p1, float p2, float p3, int p4, int p5, int p6)` | int | - |
| `GET_RANDOM_VEHICLE_FRONT_BUMPER_IN_SPHERE` | `int GET_RANDOM_VEHICLE_FRONT_BUMPER_IN_SPHERE(float p0, float p1, float p2, float p3, int p4, int p5, int p6)` | int | - |
| `GET_RANDOM_VEHICLE_IN_SPHERE` | `int GET_RANDOM_VEHICLE_IN_SPHERE(float x, float y, float z, float radius, uint modelHash, int flags)` | int | Gets a random vehicle in a sphere at the specified position, of the specified radius.<br><br>x: The X-comp... |
| `GET_RANDOM_VEHICLE_MODEL_IN_MEMORY` | `void GET_RANDOM_VEHICLE_MODEL_IN_MEMORY(bool p0, Hash* modelHash, ref int successIndicator)` | void | Not present in the retail version! It's just a nullsub.<br><br>p0 always true (except in one case)<br>success... |
| `GET_ROTATION_OF_VEHICLE_RECORDING_AT_TIME` | `Vector3 GET_ROTATION_OF_VEHICLE_RECORDING_AT_TIME(int recording, float time, string script)` | Vector3 | This native does no interpolation between pathpoints. The same rotation will be returned for all tim... |
| `GET_ROTATION_OF_VEHICLE_RECORDING_ID_AT_TIME` | `Vector3 GET_ROTATION_OF_VEHICLE_RECORDING_ID_AT_TIME(int id, float time)` | Vector3 | - |
| `GET_SUBMARINE_IS_UNDER_DESIGN_DEPTH` | `bool GET_SUBMARINE_IS_UNDER_DESIGN_DEPTH(int submarine)` | bool | - |
| `GET_SUBMARINE_NUMBER_OF_AIR_LEAKS` | `int GET_SUBMARINE_NUMBER_OF_AIR_LEAKS(int submarine)` | int | - |
| `GET_TIME_POSITION_IN_RECORDING` | `float GET_TIME_POSITION_IN_RECORDING(int vehicle)` | float | Can be used with GET_TOTAL_DURATION_OF_VEHICLE_RECORDING{_ID} to compute a percentage. |
| `GET_TOTAL_DURATION_OF_VEHICLE_RECORDING` | `float GET_TOTAL_DURATION_OF_VEHICLE_RECORDING(int recording, string script)` | float | See REQUEST_VEHICLE_RECORDING |
| `GET_TOTAL_DURATION_OF_VEHICLE_RECORDING_ID` | `float GET_TOTAL_DURATION_OF_VEHICLE_RECORDING_ID(int id)` | float | - |
| `GET_TRAIN_CARRIAGE` | `int GET_TRAIN_CARRIAGE(int train, int trailerNumber)` | int | Corrected p1. it's basically the 'carriage/trailer number'. So if the train has 3 trailers you'd cal... |
| `GET_TYRE_HEALTH` | `float GET_TYRE_HEALTH(int vehicle, int wheelIndex)` | float | Usable wheels:<br>0: wheel_lf<br>1: wheel_rf<br>2: wheel_lm1<br>3: wheel_rm1<br>4: wheel_lr<br>5: wheel_rr |
| `GET_TYRE_WEAR_RATE` | `float GET_TYRE_WEAR_RATE(int vehicle, int wheelIndex)` | float | Returns the multiplier value from SET_TYRE_WEAR_RATE<br><br>Usable wheels:<br>0: wheel_lf<br>1: wheel_rf<br>2: whee... |
| `GET_VEHICLE_ACCELERATION` | `float GET_VEHICLE_ACCELERATION(int vehicle)` | float | static - max acceleration |
| `GET_VEHICLE_ATTACHED_TO_CARGOBOB` | `int GET_VEHICLE_ATTACHED_TO_CARGOBOB(int cargobob)` | int | Returns attached vehicle (Vehicle in parameter must be cargobob) |
| `GET_VEHICLE_BODY_HEALTH` | `float GET_VEHICLE_BODY_HEALTH(int vehicle)` | float | Seems related to vehicle health, like the one in IV.<br>Max 1000, min 0.<br>Vehicle does not necessarily e... |
| `GET_VEHICLE_BOMB_AMMO` | `int GET_VEHICLE_BOMB_AMMO(int vehicle)` | int | Gets the amount of bombs that this vehicle has. As far as I know, this does _not_ impact vehicle wea... |
| `GET_VEHICLE_CAN_DEPLOY_PARACHUTE` | `bool GET_VEHICLE_CAN_DEPLOY_PARACHUTE(int vehicle)` | bool | - |
| `GET_VEHICLE_CAUSE_OF_DESTRUCTION` | `uint GET_VEHICLE_CAUSE_OF_DESTRUCTION(int vehicle)` | uint | iVar3 = get_vehicle_cause_of_destruction(uLocal_248[iVar2]);<br>if (iVar3 == joaat("weapon_stickybomb")... |
| `GET_VEHICLE_CLASS` | `int GET_VEHICLE_CLASS(int vehicle)` | int | Returns an int<br><br>Vehicle Classes:<br>0: Compacts<br>1: Sedans<br>2: SUVs<br>3: Coupes<br>4: Muscle<br>5: Sports Classic... |
| `GET_VEHICLE_CLASS_ESTIMATED_MAX_SPEED` | `float GET_VEHICLE_CLASS_ESTIMATED_MAX_SPEED(int vehicleClass)` | float | - |
| `GET_VEHICLE_CLASS_FROM_NAME` | `int GET_VEHICLE_CLASS_FROM_NAME(uint modelHash)` | int | char buffer[128];<br>std::sprintf(buffer, "VEH_CLASS_%i", VEHICLE::GET_VEHICLE_CLASS_FROM_NAME (hash));... |
| `GET_VEHICLE_CLASS_MAX_ACCELERATION` | `float GET_VEHICLE_CLASS_MAX_ACCELERATION(int vehicleClass)` | float | - |
| `GET_VEHICLE_CLASS_MAX_AGILITY` | `float GET_VEHICLE_CLASS_MAX_AGILITY(int vehicleClass)` | float | - |
| `GET_VEHICLE_CLASS_MAX_BRAKING` | `float GET_VEHICLE_CLASS_MAX_BRAKING(int vehicleClass)` | float | - |
| `GET_VEHICLE_CLASS_MAX_TRACTION` | `float GET_VEHICLE_CLASS_MAX_TRACTION(int vehicleClass)` | float | - |
| `GET_VEHICLE_COLOR` | `void GET_VEHICLE_COLOR(int vehicle, ref int r, ref int g, ref int b)` | void | What's this for? Primary and Secondary RGB have their own natives and this one doesn't seem specific... |
| `GET_VEHICLE_COLOURS` | `void GET_VEHICLE_COLOURS(int vehicle, ref int colorPrimary, ref int colorSecondary)` | void | - |
| `GET_VEHICLE_COLOURS_WHICH_CAN_BE_SET` | `int GET_VEHICLE_COLOURS_WHICH_CAN_BE_SET(int vehicle)` | int | Some kind of flags. |
| `GET_VEHICLE_COLOUR_COMBINATION` | `int GET_VEHICLE_COLOUR_COMBINATION(int vehicle)` | int | Returns the index of the color combination found in the vehicle's carvariations.meta entry. |
| `GET_VEHICLE_COUNTERMEASURE_AMMO` | `int GET_VEHICLE_COUNTERMEASURE_AMMO(int vehicle)` | int | Similar to `GET_VEHICLE_BOMB_AMMO`, this gets the amount of countermeasures that are present on this... |
| `GET_VEHICLE_CURRENT_TIME_IN_SLIP_STREAM` | `float GET_VEHICLE_CURRENT_TIME_IN_SLIP_STREAM(int vehicle)` | float | Returns a float value between 0.0 and 3.0 related to its slipstream draft (boost/speedup). |
| `GET_VEHICLE_CUSTOM_PRIMARY_COLOUR` | `void GET_VEHICLE_CUSTOM_PRIMARY_COLOUR(int vehicle, ref int r, ref int g, ref int b)` | void | - |
| `GET_VEHICLE_CUSTOM_SECONDARY_COLOUR` | `void GET_VEHICLE_CUSTOM_SECONDARY_COLOUR(int vehicle, ref int r, ref int g, ref int b)` | void | - |
| `GET_VEHICLE_DEFORMATION_AT_POS` | `Vector3 GET_VEHICLE_DEFORMATION_AT_POS(int vehicle, float offsetX, float offsetY, float offsetZ)` | Vector3 | The only example I can find of this function in the scripts, is this:<br><br>struct _s = VEHICLE::GET_VEHI... |
| `GET_VEHICLE_DIRT_LEVEL` | `float GET_VEHICLE_DIRT_LEVEL(int vehicle)` | float | Dirt level does not become greater than 15.0 |
| `GET_VEHICLE_DOORS_LOCKED_FOR_PLAYER` | `bool GET_VEHICLE_DOORS_LOCKED_FOR_PLAYER(int vehicle, int player)` | bool | - |
| `GET_VEHICLE_DOOR_ANGLE_RATIO` | `float GET_VEHICLE_DOOR_ANGLE_RATIO(int vehicle, int doorId)` | float | doorId: see SET_VEHICLE_DOOR_SHUT |
| `GET_VEHICLE_DOOR_LOCK_STATUS` | `int GET_VEHICLE_DOOR_LOCK_STATUS(int vehicle)` | int | enum VehicleLockStatus = {<br>    None = 0,<br>    Unlocked = 1,<br>    Locked = 2,<br>    LockedForPlayer = 3,<br>... |
| `GET_VEHICLE_ENGINE_HEALTH` | `float GET_VEHICLE_ENGINE_HEALTH(int vehicle)` | float | Returns 1000.0 if the function is unable to get the address of the specified vehicle or if it's not ... |
| `GET_VEHICLE_ENVEFF_SCALE` | `float GET_VEHICLE_ENVEFF_SCALE(int vehicle)` | float | The result is a value from 0-1, where 0 is fresh paint. |
| `GET_VEHICLE_ESTIMATED_MAX_SPEED` | `float GET_VEHICLE_ESTIMATED_MAX_SPEED(int vehicle)` | float | - |
| `GET_VEHICLE_EXTRA_COLOURS` | `void GET_VEHICLE_EXTRA_COLOURS(int vehicle, ref int pearlescentColor, ref int wheelColor)` | void | - |
| `GET_VEHICLE_EXTRA_COLOUR_5` | `void GET_VEHICLE_EXTRA_COLOUR_5(int vehicle, ref int color)` | void | - |
| `GET_VEHICLE_EXTRA_COLOUR_6` | `void GET_VEHICLE_EXTRA_COLOUR_6(int vehicle, ref int color)` | void | - |
| `GET_VEHICLE_FLIGHT_NOZZLE_POSITION` | `float GET_VEHICLE_FLIGHT_NOZZLE_POSITION(int plane)` | float | - |
| `GET_VEHICLE_HAS_KERS` | `bool GET_VEHICLE_HAS_KERS(int vehicle)` | bool | Returns true if the vehicle has a HF_HAS_KERS (strHandlingFlags 0x4) handing flag set, for instance ... |
| `GET_VEHICLE_HAS_LANDING_GEAR` | `bool GET_VEHICLE_HAS_LANDING_GEAR(int vehicle)` | bool | - |
| `GET_VEHICLE_HAS_PARACHUTE` | `bool GET_VEHICLE_HAS_PARACHUTE(int vehicle)` | bool | - |
| `GET_VEHICLE_HEALTH_PERCENTAGE` | `float GET_VEHICLE_HEALTH_PERCENTAGE(int vehicle, float maxEngineHealth, float maxPetrolTankHealth, float maxBodyHealth, float maxMainRotorHealth, float maxTailRotorHealth, float maxUnkHealth)` | float | 0 min 100 max<br>starts at 100<br>Seams to have health zones<br>Front of vehicle when damaged goes from 100-5... |
| `GET_VEHICLE_HOMING_LOCKEDONTO_STATE` | `int GET_VEHICLE_HOMING_LOCKEDONTO_STATE(object p0)` | int | - |
| `GET_VEHICLE_HOMING_LOCKON_STATE` | `int GET_VEHICLE_HOMING_LOCKON_STATE(int vehicle)` | int | Returns a value depending on the lock-on state of vehicle weapons.<br>0: not locked on<br>1: locking on<br>2:... |
| `GET_VEHICLE_INDIVIDUAL_DOOR_LOCK_STATUS` | `int GET_VEHICLE_INDIVIDUAL_DOOR_LOCK_STATUS(int vehicle, int doorId)` | int | Returns vehicle door lock state previously set with SET_VEHICLE_INDIVIDUAL_DOORS_LOCKED |
| `GET_VEHICLE_IS_DUMMY` | `bool GET_VEHICLE_IS_DUMMY(object p0)` | bool | - |
| `GET_VEHICLE_IS_MERCENARY` | `bool GET_VEHICLE_IS_MERCENARY(int vehicle)` | bool | - |
| `GET_VEHICLE_LAYOUT_HASH` | `uint GET_VEHICLE_LAYOUT_HASH(int vehicle)` | uint | Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicl... |
| `GET_VEHICLE_LIGHTS_STATE` | `bool GET_VEHICLE_LIGHTS_STATE(int vehicle, ref bool lightsOn, ref bool highbeamsOn)` | bool | - |
| `GET_VEHICLE_LIVERY` | `int GET_VEHICLE_LIVERY(int vehicle)` | int | -1 = no livery |
| `GET_VEHICLE_LIVERY2` | `int GET_VEHICLE_LIVERY2(int vehicle)` | int | Returns index of the current vehicle's secondary livery. A getter for SET_VEHICLE_LIVERY2. |
| `GET_VEHICLE_LIVERY2_COUNT` | `int GET_VEHICLE_LIVERY2_COUNT(int vehicle)` | int | Returns a number of available secondary liveries, or -1 if vehicle has no secondary liveries availab... |
| `GET_VEHICLE_LIVERY_COUNT` | `int GET_VEHICLE_LIVERY_COUNT(int vehicle)` | int | Returns -1 if the vehicle has no livery |
| `GET_VEHICLE_LOCK_ON_TARGET` | `bool GET_VEHICLE_LOCK_ON_TARGET(int vehicle, Entity* entity)` | bool | - |
| `GET_VEHICLE_MAX_BRAKING` | `float GET_VEHICLE_MAX_BRAKING(int vehicle)` | float | - |
| `GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS` | `int GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS(int vehicle)` | int | - |
| `GET_VEHICLE_MAX_TRACTION` | `float GET_VEHICLE_MAX_TRACTION(int vehicle)` | float | - |
| `GET_VEHICLE_MOD` | `int GET_VEHICLE_MOD(int vehicle, int modType)` | int | In b944, there are 50 (0 - 49) mod types. See SET_VEHICLE_MOD for the list.<br><br>Returns -1 if the vehic... |
| `GET_VEHICLE_MODEL_ACCELERATION` | `float GET_VEHICLE_MODEL_ACCELERATION(uint modelHash)` | float | Returns the acceleration of the specified model.<br><br>Full list of vehicles by DurtyFree: https://github... |
| `GET_VEHICLE_MODEL_ACCELERATION_MAX_MODS` | `float GET_VEHICLE_MODEL_ACCELERATION_MAX_MODS(uint modelHash)` | float | 9.8 * thrust if air vehicle, else 0.38 + drive force?<br><br>Full list of vehicles by DurtyFree: https://g... |
| `GET_VEHICLE_MODEL_ESTIMATED_MAX_SPEED` | `float GET_VEHICLE_MODEL_ESTIMATED_MAX_SPEED(uint modelHash)` | float | Returns max speed (without mods) of the specified vehicle model in m/s.<br><br>Full list of vehicles by Du... |
| `GET_VEHICLE_MODEL_MAX_BRAKING` | `float GET_VEHICLE_MODEL_MAX_BRAKING(uint modelHash)` | float | Returns max braking of the specified vehicle model.<br><br>Full list of vehicles by DurtyFree: https://git... |
| `GET_VEHICLE_MODEL_MAX_BRAKING_MAX_MODS` | `float GET_VEHICLE_MODEL_MAX_BRAKING_MAX_MODS(uint modelHash)` | float | Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicl... |
| `GET_VEHICLE_MODEL_MAX_TRACTION` | `float GET_VEHICLE_MODEL_MAX_TRACTION(uint modelHash)` | float | Returns max traction of the specified vehicle model.<br><br>Full list of vehicles by DurtyFree: https://gi... |
| `GET_VEHICLE_MODEL_NUMBER_OF_SEATS` | `int GET_VEHICLE_MODEL_NUMBER_OF_SEATS(uint modelHash)` | int | Returns max number of passengers (including the driver) for the specified vehicle model.<br><br>Full list ... |
| `GET_VEHICLE_MODEL_VALUE` | `int GET_VEHICLE_MODEL_VALUE(uint vehicleModel)` | int | Returns `nMonetaryValue` from handling.meta for specific model. |
| `GET_VEHICLE_MOD_COLOR_1` | `void GET_VEHICLE_MOD_COLOR_1(int vehicle, ref int paintType, ref int color, ref int pearlescentColor)` | void | - |
| `GET_VEHICLE_MOD_COLOR_1_NAME` | `string GET_VEHICLE_MOD_COLOR_1_NAME(int vehicle, bool p1)` | string | Returns a string which is the codename of the vehicle's currently selected primary color<br><br>p1 is alwa... |
| `GET_VEHICLE_MOD_COLOR_2` | `void GET_VEHICLE_MOD_COLOR_2(int vehicle, ref int paintType, ref int color)` | void | - |
| `GET_VEHICLE_MOD_COLOR_2_NAME` | `string GET_VEHICLE_MOD_COLOR_2_NAME(int vehicle)` | string | Returns a string which is the codename of the vehicle's currently selected secondary color |
| `GET_VEHICLE_MOD_IDENTIFIER_HASH` | `uint GET_VEHICLE_MOD_IDENTIFIER_HASH(int vehicle, int modType, int modIndex)` | uint | Can be used for IS_DLC_VEHICLE_MOD and GET_DLC_VEHICLE_MOD_LOCK_HASH |
| `GET_VEHICLE_MOD_KIT` | `int GET_VEHICLE_MOD_KIT(int vehicle)` | int | - |
| `GET_VEHICLE_MOD_KIT_TYPE` | `int GET_VEHICLE_MOD_KIT_TYPE(int vehicle)` | int | - |
| `GET_VEHICLE_MOD_MODIFIER_VALUE` | `int GET_VEHICLE_MOD_MODIFIER_VALUE(int vehicle, int modType, int modIndex)` | int | - |
| `GET_VEHICLE_MOD_VARIATION` | `int GET_VEHICLE_MOD_VARIATION(int vehicle, int modType)` | int | Only used for wheels(ModType = 23/24) Returns true if the wheels are custom wheels |
| `GET_VEHICLE_NEON_COLOUR` | `void GET_VEHICLE_NEON_COLOUR(int vehicle, ref int r, ref int g, ref int b)` | void | Gets the color of the neon lights of the specified vehicle.<br><br>See SET_VEHICLE_NEON_COLOUR (0x8E0A5822... |
| `GET_VEHICLE_NEON_ENABLED` | `bool GET_VEHICLE_NEON_ENABLED(int vehicle, int index)` | bool | indices:<br>0 = Left<br>1 = Right<br>2 = Front<br>3 = Back |
| `GET_VEHICLE_NUMBER_OF_PASSENGERS` | `int GET_VEHICLE_NUMBER_OF_PASSENGERS(int vehicle, bool includeDriver, bool includeDeadOccupants)` | int | Gets the number of passengers.<br><br>This native was modified in b2545 to take two additional parameters,... |
| `GET_VEHICLE_NUMBER_PLATE_TEXT` | `string GET_VEHICLE_NUMBER_PLATE_TEXT(int vehicle)` | string | Returns the license plate text from a vehicle. 8 chars maximum. |
| `GET_VEHICLE_NUMBER_PLATE_TEXT_INDEX` | `int GET_VEHICLE_NUMBER_PLATE_TEXT_INDEX(int vehicle)` | int | Returns the PlateType of a vehicle<br>      Blue_on_White_1 = 3,<br>      Blue_on_White_2 = 0,<br>      Blue_... |
| `GET_VEHICLE_NUM_OF_BROKEN_LOOSEN_PARTS` | `int GET_VEHICLE_NUM_OF_BROKEN_LOOSEN_PARTS(int vehicle)` | int | - |
| `GET_VEHICLE_NUM_OF_BROKEN_OFF_PARTS` | `int GET_VEHICLE_NUM_OF_BROKEN_OFF_PARTS(int vehicle)` | int | Also includes some "turnOffBones" when vehicle mods are installed. |
| `GET_VEHICLE_PETROL_TANK_HEALTH` | `float GET_VEHICLE_PETROL_TANK_HEALTH(int vehicle)` | float | 1000 is max health<br>Begins leaking gas at around 650 health<br>-999.90002441406 appears to be minimum he... |
| `GET_VEHICLE_PLATE_TYPE` | `int GET_VEHICLE_PLATE_TYPE(int vehicle)` | int | - |
| `GET_VEHICLE_RECORDING_ID` | `int GET_VEHICLE_RECORDING_ID(int recording, string script)` | int | See REQUEST_VEHICLE_RECORDING |
| `GET_VEHICLE_SIZE` | `void GET_VEHICLE_SIZE(int vehicle, ref Vector3 out1, ref Vector3 out2)` | void | Outputs 2 Vector3's.<br>Scripts check if out2.x - out1.x > someshit.x<br>Could be suspension related, as i... |
| `GET_VEHICLE_TRAILER_VEHICLE` | `bool GET_VEHICLE_TRAILER_VEHICLE(int vehicle, Vehicle* trailer)` | bool | Gets the trailer of a vehicle and puts it into the trailer parameter. |
| `GET_VEHICLE_TYRES_CAN_BURST` | `bool GET_VEHICLE_TYRES_CAN_BURST(int vehicle)` | bool | - |
| `GET_VEHICLE_TYRE_SMOKE_COLOR` | `void GET_VEHICLE_TYRE_SMOKE_COLOR(int vehicle, ref int r, ref int g, ref int b)` | void | - |
| `GET_VEHICLE_WEAPON_RESTRICTED_AMMO` | `int GET_VEHICLE_WEAPON_RESTRICTED_AMMO(int vehicle, int weaponIndex)` | int | - |
| `GET_VEHICLE_WHEEL_TYPE` | `int GET_VEHICLE_WHEEL_TYPE(int vehicle)` | int | Returns an int<br><br>Wheel Types:<br>0: Sport<br>1: Muscle<br>2: Lowrider<br>3: SUV<br>4: Offroad<br>5: Tuner<br>6: Bike Wheel... |
| `GET_VEHICLE_WINDOW_TINT` | `int GET_VEHICLE_WINDOW_TINT(int vehicle)` | int | - |
| `GET_VEHICLE_XENON_LIGHT_COLOR_INDEX` | `int GET_VEHICLE_XENON_LIGHT_COLOR_INDEX(int vehicle)` | int | Returns the headlight color index from the vehicle. Value between 0, 12.<br>Use SET_VEHICLE_XENON_LIGHT... |
| `HAS_INSTANT_FILL_VEHICLE_POPULATION_FINISHED` | `bool HAS_INSTANT_FILL_VEHICLE_POPULATION_FINISHED()` | bool | - |
| `HAS_PRELOAD_MODS_FINISHED` | `bool HAS_PRELOAD_MODS_FINISHED(int vehicle)` | bool | - |
| `HAS_VEHICLE_ASSET_LOADED` | `bool HAS_VEHICLE_ASSET_LOADED(int vehicleAsset)` | bool | - |
| `HAS_VEHICLE_PETROLTANK_SET_ON_FIRE_BY_ENTITY` | `bool HAS_VEHICLE_PETROLTANK_SET_ON_FIRE_BY_ENTITY(object p0, object p1)` | bool | - |
| `HAS_VEHICLE_PHONE_EXPLOSIVE_DEVICE` | `bool HAS_VEHICLE_PHONE_EXPLOSIVE_DEVICE()` | bool | - |
| `HAS_VEHICLE_RECORDING_BEEN_LOADED` | `bool HAS_VEHICLE_RECORDING_BEEN_LOADED(int recording, string script)` | bool | See REQUEST_VEHICLE_RECORDING |
| `HAVE_VEHICLE_MODS_STREAMED_IN` | `bool HAVE_VEHICLE_MODS_STREAMED_IN(int vehicle)` | bool | - |
| `HAVE_VEHICLE_REAR_DOORS_BEEN_BLOWN_OPEN_BY_STICKYBOMB` | `bool HAVE_VEHICLE_REAR_DOORS_BEEN_BLOWN_OPEN_BY_STICKYBOMB(int vehicle)` | bool | - |
| `HIDE_TOMBSTONE` | `void HIDE_TOMBSTONE(int vehicle, bool toggle)` | void | Disables detachable bumber from domnator4, dominator5, dominator6, see https://gfycat.com/SecondUnlu... |
| `INSTANTLY_FILL_VEHICLE_POPULATION` | `void INSTANTLY_FILL_VEHICLE_POPULATION()` | void | - |
| `IS_ANY_ENTITY_ATTACHED_TO_HANDLER_FRAME` | `bool IS_ANY_ENTITY_ATTACHED_TO_HANDLER_FRAME(int vehicle)` | bool | - |
| `IS_ANY_PED_RAPPELLING_FROM_HELI` | `bool IS_ANY_PED_RAPPELLING_FROM_HELI(int vehicle)` | bool | - |
| `IS_ANY_VEHICLE_NEAR_POINT` | `bool IS_ANY_VEHICLE_NEAR_POINT(float x, float y, float z, float radius)` | bool | - |
| `IS_BIG_VEHICLE` | `bool IS_BIG_VEHICLE(int vehicle)` | bool | Returns true if MF_IS_BIG (strModelFlags 0x8) handling model flag is set. |
| `IS_BOAT_ANCHORED` | `bool IS_BOAT_ANCHORED(int vehicle)` | bool | - |
| `IS_COP_VEHICLE_IN_AREA_3D` | `bool IS_COP_VEHICLE_IN_AREA_3D(float x1, float x2, float y1, float y2, float z1, float z2)` | bool | Usage:<br><br>public bool isCopInRange(Vector3 Location, float Range)<br>        {<br>            return Functio... |
| `IS_ENTITY_ATTACHED_TO_HANDLER_FRAME` | `bool IS_ENTITY_ATTACHED_TO_HANDLER_FRAME(int vehicle, int entity)` | bool | - |
| `IS_ENTRY_POINT_FOR_SEAT_CLEAR` | `bool IS_ENTRY_POINT_FOR_SEAT_CLEAR(int ped, int vehicle, int seatIndex, bool side, bool onEnter)` | bool | Check if a vehicle seat is accessible. If you park your vehicle near a wall and the ped cannot enter... |
| `IS_EXTRA_BROKEN_OFF` | `bool IS_EXTRA_BROKEN_OFF(int vehicle, int extraId)` | bool | Returns true if specified extra part is broken off. It only works for extras that can break off duri... |
| `IS_HANDLER_FRAME_LINED_UP_WITH_CONTAINER` | `bool IS_HANDLER_FRAME_LINED_UP_WITH_CONTAINER(int vehicle, int entity)` | bool | - |
| `IS_HELI_LANDING_AREA_BLOCKED` | `bool IS_HELI_LANDING_AREA_BLOCKED(int vehicle)` | bool | - |
| `IS_HELI_PART_BROKEN` | `bool IS_HELI_PART_BROKEN(int vehicle, bool p1, bool p2, bool p3)` | bool | - |
| `IS_MISSION_TRAIN` | `bool IS_MISSION_TRAIN(int train)` | bool | - |
| `IS_NITROUS_ACTIVE` | `bool IS_NITROUS_ACTIVE(int vehicle)` | bool | - |
| `IS_PED_EXCLUSIVE_DRIVER_OF_VEHICLE` | `bool IS_PED_EXCLUSIVE_DRIVER_OF_VEHICLE(int ped, int vehicle, ref int outIndex)` | bool | - |
| `IS_PLANE_LANDING_GEAR_INTACT` | `bool IS_PLANE_LANDING_GEAR_INTACT(int plane)` | bool | - |
| `IS_PLAYBACK_GOING_ON_FOR_VEHICLE` | `bool IS_PLAYBACK_GOING_ON_FOR_VEHICLE(int vehicle)` | bool | - |
| `IS_PLAYBACK_USING_AI_GOING_ON_FOR_VEHICLE` | `bool IS_PLAYBACK_USING_AI_GOING_ON_FOR_VEHICLE(int vehicle)` | bool | - |
| `IS_ROCKET_BOOST_ACTIVE` | `bool IS_ROCKET_BOOST_ACTIVE(int vehicle)` | bool | - |
| `IS_SEAT_WARP_ONLY` | `bool IS_SEAT_WARP_ONLY(int vehicle, int seatIndex)` | bool | - |
| `IS_TAXI_LIGHT_ON` | `bool IS_TAXI_LIGHT_ON(int vehicle)` | bool | - |
| `IS_THIS_MODEL_AN_AMPHIBIOUS_CAR` | `bool IS_THIS_MODEL_AN_AMPHIBIOUS_CAR(uint model)` | bool | - |
| `IS_THIS_MODEL_AN_AMPHIBIOUS_QUADBIKE` | `bool IS_THIS_MODEL_AN_AMPHIBIOUS_QUADBIKE(uint model)` | bool | - |
| `IS_THIS_MODEL_A_BICYCLE` | `bool IS_THIS_MODEL_A_BICYCLE(uint model)` | bool | - |
| `IS_THIS_MODEL_A_BIKE` | `bool IS_THIS_MODEL_A_BIKE(uint model)` | bool | - |
| `IS_THIS_MODEL_A_BOAT` | `bool IS_THIS_MODEL_A_BOAT(uint model)` | bool | - |
| `IS_THIS_MODEL_A_CAR` | `bool IS_THIS_MODEL_A_CAR(uint model)` | bool | To check if the model is an amphibious car, use IS_THIS_MODEL_AN_AMPHIBIOUS_CAR. |
| `IS_THIS_MODEL_A_HELI` | `bool IS_THIS_MODEL_A_HELI(uint model)` | bool | - |
| `IS_THIS_MODEL_A_JETSKI` | `bool IS_THIS_MODEL_A_JETSKI(uint model)` | bool | Checks if model is a boat, then checks for FLAG_IS_JETSKI. |
| `IS_THIS_MODEL_A_PLANE` | `bool IS_THIS_MODEL_A_PLANE(uint model)` | bool | - |
| `IS_THIS_MODEL_A_QUADBIKE` | `bool IS_THIS_MODEL_A_QUADBIKE(uint model)` | bool | - |
| `IS_THIS_MODEL_A_TRAIN` | `bool IS_THIS_MODEL_A_TRAIN(uint model)` | bool | - |
| `IS_TOGGLE_MOD_ON` | `bool IS_TOGGLE_MOD_ON(int vehicle, int modType)` | bool | - |
| `IS_TURRET_SEAT` | `bool IS_TURRET_SEAT(int vehicle, int seatIndex)` | bool | - |
| `IS_VEHICLE_ALARM_ACTIVATED` | `bool IS_VEHICLE_ALARM_ACTIVATED(int vehicle)` | bool | - |
| `IS_VEHICLE_ATTACHED_TO_CARGOBOB` | `bool IS_VEHICLE_ATTACHED_TO_CARGOBOB(int cargobob, int vehicleAttached)` | bool | - |
| `IS_VEHICLE_ATTACHED_TO_TOW_TRUCK` | `bool IS_VEHICLE_ATTACHED_TO_TOW_TRUCK(int towTruck, int vehicle)` | bool | Scripts verify that towTruck is the first parameter, not the second. |
| `IS_VEHICLE_ATTACHED_TO_TRAILER` | `bool IS_VEHICLE_ATTACHED_TO_TRAILER(int vehicle)` | bool | - |
| `IS_VEHICLE_A_CONVERTIBLE` | `bool IS_VEHICLE_A_CONVERTIBLE(int vehicle, bool p1)` | bool | Returns true if the vehicle has a convertible roof.<br><br>p1 is false almost always. However, in launcher... |
| `IS_VEHICLE_BEING_BROUGHT_TO_HALT` | `bool IS_VEHICLE_BEING_BROUGHT_TO_HALT(int vehicle)` | bool | Returns true if vehicle is halted by BRING_VEHICLE_TO_HALT |
| `IS_VEHICLE_BUMPER_BOUNCING` | `bool IS_VEHICLE_BUMPER_BOUNCING(int vehicle, bool frontBumper)` | bool | - |
| `IS_VEHICLE_BUMPER_BROKEN_OFF` | `bool IS_VEHICLE_BUMPER_BROKEN_OFF(int vehicle, bool frontBumper)` | bool | - |
| `IS_VEHICLE_DOOR_DAMAGED` | `bool IS_VEHICLE_DOOR_DAMAGED(int veh, int doorID)` | bool | doorID starts at 0, not seeming to skip any numbers. Four door vehicles intuitively range from 0 to ... |
| `IS_VEHICLE_DOOR_FULLY_OPEN` | `bool IS_VEHICLE_DOOR_FULLY_OPEN(int vehicle, int doorId)` | bool | doorId: see SET_VEHICLE_DOOR_SHUT |
| `IS_VEHICLE_DRIVEABLE` | `bool IS_VEHICLE_DRIVEABLE(int vehicle, bool isOnFireCheck)` | bool | p1 is always 0 in the scripts.<br><br>p1 = check if vehicle is on fire |
| `IS_VEHICLE_EXTRA_TURNED_ON` | `bool IS_VEHICLE_EXTRA_TURNED_ON(int vehicle, int extraId)` | bool | - |
| `IS_VEHICLE_HIGH_DETAIL` | `bool IS_VEHICLE_HIGH_DETAIL(int vehicle)` | bool | - |
| `IS_VEHICLE_IN_BURNOUT` | `bool IS_VEHICLE_IN_BURNOUT(int vehicle)` | bool | Returns whether the specified vehicle is currently in a burnout.<br><br><br>vb.net<br>Public Function isVehicleI... |
| `IS_VEHICLE_IN_GARAGE_AREA` | `bool IS_VEHICLE_IN_GARAGE_AREA(string garageName, int vehicle)` | bool | garageName example "Michael - Beverly Hills"<br><br>Full list of garages by DurtyFree: https://github.com/... |
| `IS_VEHICLE_IN_SUBMARINE_MODE` | `bool IS_VEHICLE_IN_SUBMARINE_MODE(int vehicle)` | bool | - |
| `IS_VEHICLE_MODEL` | `bool IS_VEHICLE_MODEL(int vehicle, uint model)` | bool | - |
| `IS_VEHICLE_MOD_GEN9_EXCLUSIVE` | `bool IS_VEHICLE_MOD_GEN9_EXCLUSIVE(int vehicle, int modType, int modIndex)` | bool | Returns true for any mod part listed in GEN9_EXCLUSIVE_ASSETS_VEHICLES_FILE. |
| `IS_VEHICLE_ON_ALL_WHEELS` | `bool IS_VEHICLE_ON_ALL_WHEELS(int vehicle)` | bool |  Public Function isVehicleOnAllWheels(vh As Vehicle) As Boolean<br>        Return Native.Function.Call(... |
| `IS_VEHICLE_PARACHUTE_DEPLOYED` | `bool IS_VEHICLE_PARACHUTE_DEPLOYED(int vehicle)` | bool | - |
| `IS_VEHICLE_PRODUCING_SLIP_STREAM` | `bool IS_VEHICLE_PRODUCING_SLIP_STREAM(int vehicle)` | bool | Returns true if the vehicle is being slipstreamed by another vehicle |
| `IS_VEHICLE_SEARCHLIGHT_ON` | `bool IS_VEHICLE_SEARCHLIGHT_ON(int vehicle)` | bool | Possibly: Returns whether the searchlight (found on police vehicles) is toggled on.<br><br>@Author Nac |
| `IS_VEHICLE_SEAT_FREE` | `bool IS_VEHICLE_SEAT_FREE(int vehicle, int seatIndex, bool isTaskRunning)` | bool | Check if a vehicle seat is free.<br><br>seatIndex  = -1 being the driver seat.<br>Use GET_VEHICLE_MAX_NUMBER_... |
| `IS_VEHICLE_SIREN_AUDIO_ON` | `bool IS_VEHICLE_SIREN_AUDIO_ON(int vehicle)` | bool | - |
| `IS_VEHICLE_SIREN_ON` | `bool IS_VEHICLE_SIREN_ON(int vehicle)` | bool | - |
| `IS_VEHICLE_SPRAYABLE` | `bool IS_VEHICLE_SPRAYABLE(int vehicle)` | bool | Returns false if the vehicle has the FLAG_NO_RESPRAY flag set. |
| `IS_VEHICLE_STOLEN` | `bool IS_VEHICLE_STOLEN(int vehicle)` | bool | Only returns true if the vehicle was marked as stolen with SET_VEHICLE_IS_STOLEN. |
| `IS_VEHICLE_STOPPED` | `bool IS_VEHICLE_STOPPED(int vehicle)` | bool | Returns true if the vehicle's current speed is less than, or equal to 0.0025f.<br><br>For some vehicles it... |
| `IS_VEHICLE_STOPPED_AT_TRAFFIC_LIGHTS` | `bool IS_VEHICLE_STOPPED_AT_TRAFFIC_LIGHTS(int vehicle)` | bool | - |
| `IS_VEHICLE_STUCK_ON_ROOF` | `bool IS_VEHICLE_STUCK_ON_ROOF(int vehicle)` | bool | - |
| `IS_VEHICLE_STUCK_TIMER_UP` | `bool IS_VEHICLE_STUCK_TIMER_UP(int vehicle, int p1, int ms)` | bool | p1 can be anywhere from 0 to 3 in the scripts.<br>p2 being how long in milliseconds the vehicle has bee... |
| `IS_VEHICLE_TYRE_BURST` | `bool IS_VEHICLE_TYRE_BURST(int vehicle, int wheelID, bool completely)` | bool | wheelID used for 4 wheelers seem to be (0, 1, 4, 5)<br>completely - is to check if tire completely gone... |
| `IS_VEHICLE_VISIBLE` | `bool IS_VEHICLE_VISIBLE(int vehicle)` | bool | must be called after TRACK_VEHICLE_VISIBILITY <br><br>it's not instant so probabilly must pass an 'update'... |
| `IS_VEHICLE_WEAPON_DISABLED` | `bool IS_VEHICLE_WEAPON_DISABLED(uint weaponHash, int vehicle, int owner)` | bool | Full list of weapons by DurtyFree (Search for VEHICLE_*): https://github.com/DurtyFree/gta-v-data-du... |
| `IS_VEHICLE_WINDOW_INTACT` | `bool IS_VEHICLE_WINDOW_INTACT(int vehicle, int windowIndex)` | bool | This will return false if the window is broken, or rolled down.<br>Window indexes:<br>0 = Front Right Wind... |
| `LOCK_DOORS_WHEN_NO_LONGER_NEEDED` | `void LOCK_DOORS_WHEN_NO_LONGER_NEEDED(int vehicle)` | void | - |
| `LOWER_CONVERTIBLE_ROOF` | `void LOWER_CONVERTIBLE_ROOF(int vehicle, bool instantlyLower)` | void | - |
| `LOWER_FORKLIFT_FORKS` | `void LOWER_FORKLIFT_FORKS(int forklift)` | void | - |
| `MODIFY_VEHICLE_TOP_SPEED` | `void MODIFY_VEHICLE_TOP_SPEED(int vehicle, float value)` | void | - |
| `NETWORK_CAP_EMPTY_CROWDING_VEHICLES_REMOVAL` | `void NETWORK_CAP_EMPTY_CROWDING_VEHICLES_REMOVAL(int p0)` | void | Default:1000\|\|This sets a value which is used when NETWORK_ENABLE_EMPTY_CROWDING_VEHICLES_REMOVAL(tr... |
| `NETWORK_ENABLE_EMPTY_CROWDING_VEHICLES_REMOVAL` | `void NETWORK_ENABLE_EMPTY_CROWDING_VEHICLES_REMOVAL(bool toggle)` | void | - |
| `NETWORK_USE_HIGH_PRECISION_TRAIN_BLENDING` | `void NETWORK_USE_HIGH_PRECISION_TRAIN_BLENDING(int vehicle, bool toggle)` | void | Implemented only for trains. |
| `OPEN_BOMB_BAY_DOORS` | `void OPEN_BOMB_BAY_DOORS(int vehicle)` | void | - |
| `OVERRIDE_PLANE_DAMAGE_THREHSOLD` | `void OVERRIDE_PLANE_DAMAGE_THREHSOLD(int vehicle, float health)` | void | Used for helis. |
| `PAUSE_PLAYBACK_RECORDED_VEHICLE` | `void PAUSE_PLAYBACK_RECORDED_VEHICLE(int vehicle)` | void | - |
| `POP_OFF_VEHICLE_ROOF_WITH_IMPULSE` | `void POP_OFF_VEHICLE_ROOF_WITH_IMPULSE(int vehicle, float x, float y, float z)` | void | Pops off the "roof" bone in the direction of the specified offset from the vehicle. |
| `POP_OUT_VEHICLE_WINDSCREEN` | `void POP_OUT_VEHICLE_WINDSCREEN(int vehicle)` | void | Detaches the vehicle's windscreen.<br>For further information, see : gtaforums.com/topic/859570-glass/#... |
| `PRELOAD_VEHICLE_MOD` | `void PRELOAD_VEHICLE_MOD(int vehicle, int modType, int modIndex)` | void | - |
| `RAISE_CONVERTIBLE_ROOF` | `void RAISE_CONVERTIBLE_ROOF(int vehicle, bool instantlyRaise)` | void | - |
| `RELEASE_PRELOAD_MODS` | `void RELEASE_PRELOAD_MODS(int vehicle)` | void | - |
| `REMOVE_PICK_UP_ROPE_FOR_CARGOBOB` | `void REMOVE_PICK_UP_ROPE_FOR_CARGOBOB(int cargobob)` | void | Retracts the hook on the cargobob.<br><br>Note: after you retract it the natives for dropping the hook no ... |
| `REMOVE_ROAD_NODE_SPEED_ZONE` | `bool REMOVE_ROAD_NODE_SPEED_ZONE(int speedzone)` | bool | - |
| `REMOVE_VEHICLES_FROM_GENERATORS_IN_AREA` | `void REMOVE_VEHICLES_FROM_GENERATORS_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, object p6)` | void | - |
| `REMOVE_VEHICLE_ASSET` | `void REMOVE_VEHICLE_ASSET(int vehicleAsset)` | void | - |
| `REMOVE_VEHICLE_COMBAT_AVOIDANCE_AREA` | `void REMOVE_VEHICLE_COMBAT_AVOIDANCE_AREA(int p0)` | void | - |
| `REMOVE_VEHICLE_HIGH_DETAIL_MODEL` | `void REMOVE_VEHICLE_HIGH_DETAIL_MODEL(int vehicle)` | void | - |
| `REMOVE_VEHICLE_MOD` | `void REMOVE_VEHICLE_MOD(int vehicle, int modType)` | void | - |
| `REMOVE_VEHICLE_RECORDING` | `void REMOVE_VEHICLE_RECORDING(int recording, string script)` | void | See REQUEST_VEHICLE_RECORDING |
| `REMOVE_VEHICLE_STUCK_CHECK` | `void REMOVE_VEHICLE_STUCK_CHECK(int vehicle)` | void | - |
| `REMOVE_VEHICLE_UPSIDEDOWN_CHECK` | `void REMOVE_VEHICLE_UPSIDEDOWN_CHECK(int vehicle)` | void | - |
| `REMOVE_VEHICLE_WINDOW` | `void REMOVE_VEHICLE_WINDOW(int vehicle, int windowIndex)` | void | windowIndex:<br>0 = Front Right Window<br>1 = Front Left Window<br>2 = Back Right Window<br>3 = Back Left Window... |
| `REQUEST_VEHICLE_ASSET` | `void REQUEST_VEHICLE_ASSET(uint vehicleHash, int vehicleAsset)` | void | REQUEST_VEHICLE_ASSET(GET_HASH_KEY(cargobob3), 3);<br><br>vehicle found that have asset's:<br>cargobob3<br>subme... |
| `REQUEST_VEHICLE_DIAL` | `void REQUEST_VEHICLE_DIAL(int vehicle)` | void | - |
| `REQUEST_VEHICLE_HIGH_DETAIL_MODEL` | `void REQUEST_VEHICLE_HIGH_DETAIL_MODEL(int vehicle)` | void | - |
| `REQUEST_VEHICLE_RECORDING` | `void REQUEST_VEHICLE_RECORDING(int recording, string script)` | void | Request the vehicle recording defined by the lowercase format string "%s%03d.yvr". For example, REQU... |
| `RESET_FORMATION_LEADER` | `void RESET_FORMATION_LEADER()` | void | Resets the effect of SET_FORMATION_LEADER |
| `RESET_VEHICLE_STUCK_TIMER` | `void RESET_VEHICLE_STUCK_TIMER(int vehicle, int nullAttributes)` | void | The inner function has a switch on the second parameter. It's the stuck timer index.<br><br>Here's some ps... |
| `RESET_VEHICLE_WHEELS` | `void RESET_VEHICLE_WHEELS(int vehicle, bool toggle)` | void | - |
| `ROLL_DOWN_WINDOW` | `void ROLL_DOWN_WINDOW(int vehicle, int windowIndex)` | void | windowIndex:<br>0 = Front Left Window<br>1 = Front Right Window<br>2 = Rear Left Window<br>3 = Rear Right Window... |
| `ROLL_DOWN_WINDOWS` | `void ROLL_DOWN_WINDOWS(int vehicle)` | void | Roll down all the windows of the vehicle passed through the first parameter. |
| `ROLL_UP_WINDOW` | `void ROLL_UP_WINDOW(int vehicle, int windowIndex)` | void | windowIndex:<br>0 = Front Left Window<br>1 = Front Right Window<br>2 = Rear Left Window<br>3 = Rear Right Window... |
| `SET_ADDITIONAL_ROTATION_FOR_RECORDED_VEHICLE_PLAYBACK` | `void SET_ADDITIONAL_ROTATION_FOR_RECORDED_VEHICLE_PLAYBACK(int vehicle, float x, float y, float z, object p4)` | void | - |
| `SET_AIRCRAFT_IGNORE_HIGHTMAP_OPTIMISATION` | `void SET_AIRCRAFT_IGNORE_HIGHTMAP_OPTIMISATION(int vehicle, int p1)` | void | - |
| `SET_AIRCRAFT_PILOT_SKILL_NOISE_SCALAR` | `void SET_AIRCRAFT_PILOT_SKILL_NOISE_SCALAR(int vehicle, float p1)` | void | - |
| `SET_ALLOW_RAMMING_SOOP_OR_RAMP` | `void SET_ALLOW_RAMMING_SOOP_OR_RAMP(object p0, object p1)` | void | - |
| `SET_ALLOW_VEHICLE_EXPLODES_ON_CONTACT` | `void SET_ALLOW_VEHICLE_EXPLODES_ON_CONTACT(int vehicle, bool toggle)` | void | - |
| `SET_ALL_LOW_PRIORITY_VEHICLE_GENERATORS_ACTIVE` | `void SET_ALL_LOW_PRIORITY_VEHICLE_GENERATORS_ACTIVE(bool active)` | void | - |
| `SET_ALL_VEHICLE_GENERATORS_ACTIVE` | `void SET_ALL_VEHICLE_GENERATORS_ACTIVE()` | void | - |
| `SET_ALL_VEHICLE_GENERATORS_ACTIVE_IN_AREA` | `void SET_ALL_VEHICLE_GENERATORS_ACTIVE_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool toggle, bool p7)` | void | When p6 is true, vehicle generators are active.<br>p7 seems to always be true in story mode scripts, bu... |
| `SET_AMBIENT_VEHICLE_NEON_ENABLED` | `void SET_AMBIENT_VEHICLE_NEON_ENABLED(bool p0)` | void | - |
| `SET_AMBIENT_VEHICLE_RANGE_MULTIPLIER_THIS_FRAME` | `void SET_AMBIENT_VEHICLE_RANGE_MULTIPLIER_THIS_FRAME(float value)` | void | - |
| `SET_ARRIVE_DISTANCE_OVERRIDE_FOR_VEHICLE_PERSUIT_ATTACK` | `void SET_ARRIVE_DISTANCE_OVERRIDE_FOR_VEHICLE_PERSUIT_ATTACK(int vehicle, float p1)` | void | - |
| `SET_BIKE_EASY_TO_LAND` | `void SET_BIKE_EASY_TO_LAND(int vehicle, bool toggle)` | void | When enabled, the player won't fall off the bike when landing from large heights. |
| `SET_BIKE_ON_STAND` | `void SET_BIKE_ON_STAND(int vehicle, float x, float y)` | void | Only works on bikes, both X and Y work in the -1 - 1 range.<br><br>X forces the bike to turn left or right... |
| `SET_BOAT_ANCHOR` | `void SET_BOAT_ANCHOR(int vehicle, bool toggle)` | void | - |
| `SET_BOAT_DISABLE_AVOIDANCE` | `void SET_BOAT_DISABLE_AVOIDANCE(int vehicle, bool p1)` | void | - |
| `SET_BOAT_IGNORE_LAND_PROBES` | `void SET_BOAT_IGNORE_LAND_PROBES(object p0, object p1)` | void | - |
| `SET_BOAT_LOW_LOD_ANCHOR_DISTANCE` | `void SET_BOAT_LOW_LOD_ANCHOR_DISTANCE(int vehicle, float value)` | void | - |
| `SET_BOAT_REMAINS_ANCHORED_WHILE_PLAYER_IS_DRIVER` | `void SET_BOAT_REMAINS_ANCHORED_WHILE_PLAYER_IS_DRIVER(int vehicle, bool toggle)` | void | - |
| `SET_BOAT_SINKS_WHEN_WRECKED` | `void SET_BOAT_SINKS_WHEN_WRECKED(int vehicle, bool toggle)` | void | - |
| `SET_BOAT_WRECKED` | `void SET_BOAT_WRECKED(int vehicle)` | void | - |
| `SET_CAN_ADJUST_GROUND_CLEARANCE` | `void SET_CAN_ADJUST_GROUND_CLEARANCE(int vehicle, bool p1)` | void | - |
| `SET_CAN_RESPRAY_VEHICLE` | `void SET_CAN_RESPRAY_VEHICLE(int vehicle, bool state)` | void | Hardcoded to not work in multiplayer. |
| `SET_CAN_USE_HYDRAULICS` | `void SET_CAN_USE_HYDRAULICS(int vehicle, bool toggle)` | void | - |
| `SET_CARGOBOB_EXCLUDE_FROM_PICKUP_ENTITY` | `void SET_CARGOBOB_EXCLUDE_FROM_PICKUP_ENTITY(object p0, object p1)` | void | - |
| `SET_CARGOBOB_EXTA_PICKUP_RANGE` | `void SET_CARGOBOB_EXTA_PICKUP_RANGE(object p0, object p1)` | void | - |
| `SET_CARGOBOB_FORCE_DONT_DETACH_VEHICLE` | `void SET_CARGOBOB_FORCE_DONT_DETACH_VEHICLE(int cargobob, bool toggle)` | void | Stops cargobob from being able to detach the attached vehicle. |
| `SET_CARGOBOB_PICKUP_MAGNET_ACTIVE` | `void SET_CARGOBOB_PICKUP_MAGNET_ACTIVE(int cargobob, bool isActive)` | void | Won't attract or magnetize to any helicopters or planes of course, but that's common sense. |
| `SET_CARGOBOB_PICKUP_MAGNET_ENSURE_PICKUP_ENTITY_UPRIGHT` | `void SET_CARGOBOB_PICKUP_MAGNET_ENSURE_PICKUP_ENTITY_UPRIGHT(int vehicle, bool p1)` | void | - |
| `SET_CARGOBOB_PICKUP_MAGNET_FALLOFF` | `void SET_CARGOBOB_PICKUP_MAGNET_FALLOFF(int cargobob, float p1)` | void | - |
| `SET_CARGOBOB_PICKUP_MAGNET_PULL_ROPE_LENGTH` | `void SET_CARGOBOB_PICKUP_MAGNET_PULL_ROPE_LENGTH(int vehicle, float p1)` | void | - |
| `SET_CARGOBOB_PICKUP_MAGNET_PULL_STRENGTH` | `void SET_CARGOBOB_PICKUP_MAGNET_PULL_STRENGTH(int cargobob, float p1)` | void | - |
| `SET_CARGOBOB_PICKUP_MAGNET_REDUCED_FALLOFF` | `void SET_CARGOBOB_PICKUP_MAGNET_REDUCED_FALLOFF(int cargobob, float p1)` | void | - |
| `SET_CARGOBOB_PICKUP_MAGNET_REDUCED_STRENGTH` | `void SET_CARGOBOB_PICKUP_MAGNET_REDUCED_STRENGTH(int cargobob, float p1)` | void | - |
| `SET_CARGOBOB_PICKUP_MAGNET_SET_AMBIENT_MODE` | `void SET_CARGOBOB_PICKUP_MAGNET_SET_AMBIENT_MODE(int vehicle, bool p1, bool p2)` | void | - |
| `SET_CARGOBOB_PICKUP_MAGNET_SET_TARGETED_MODE` | `void SET_CARGOBOB_PICKUP_MAGNET_SET_TARGETED_MODE(int vehicle, int cargobob)` | void | - |
| `SET_CARGOBOB_PICKUP_MAGNET_STRENGTH` | `void SET_CARGOBOB_PICKUP_MAGNET_STRENGTH(int cargobob, float strength)` | void | - |
| `SET_CARGOBOB_PICKUP_ROPE_DAMPING_MULTIPLIER` | `void SET_CARGOBOB_PICKUP_ROPE_DAMPING_MULTIPLIER(object p0, object p1)` | void | - |
| `SET_CARGOBOB_PICKUP_ROPE_TYPE` | `void SET_CARGOBOB_PICKUP_ROPE_TYPE(object p0, object p1)` | void | - |
| `SET_CARJACK_MISSION_REMOVAL_PARAMETERS` | `void SET_CARJACK_MISSION_REMOVAL_PARAMETERS(object p0, object p1)` | void | - |
| `SET_CAR_BOOT_OPEN` | `void SET_CAR_BOOT_OPEN(int vehicle)` | void | Initially used in Max Payne 3, that's why we know the name. |
| `SET_CAR_HIGH_SPEED_BUMP_SEVERITY_MULTIPLIER` | `void SET_CAR_HIGH_SPEED_BUMP_SEVERITY_MULTIPLIER(float multiplier)` | void | - |
| `SET_CHECK_FOR_ENOUGH_ROOM_FOR_PED` | `void SET_CHECK_FOR_ENOUGH_ROOM_FOR_PED(int vehicle, bool p1)` | void | Only used in R* Script fm_content_cargo |
| `SET_CLEAR_FREEZE_WAITING_ON_COLLISION_ONCE_PLAYER_ENTERS` | `void SET_CLEAR_FREEZE_WAITING_ON_COLLISION_ONCE_PLAYER_ENTERS(int vehicle, bool toggle)` | void | - |
| `SET_CONVERTIBLE_ROOF` | `void SET_CONVERTIBLE_ROOF(int vehicle, bool p1)` | void | - |
| `SET_CONVERTIBLE_ROOF_LATCH_STATE` | `void SET_CONVERTIBLE_ROOF_LATCH_STATE(int vehicle, bool state)` | void | - |
| `SET_DEPLOY_FOLDING_WINGS` | `void SET_DEPLOY_FOLDING_WINGS(int vehicle, bool deploy, bool p2)` | void | Only used with the "akula" and "annihilator2" in the decompiled native scripts. |
| `SET_DIP_STRAIGHT_DOWN_WHEN_CRASHING_PLANE` | `void SET_DIP_STRAIGHT_DOWN_WHEN_CRASHING_PLANE(int vehicle, bool toggle)` | void | - |
| `SET_DISABLE_AUTOMATIC_CRASH_TASK` | `void SET_DISABLE_AUTOMATIC_CRASH_TASK(int vehicle, bool toggle)` | void | Sets a flag on heli and another vehicle type. |
| `SET_DISABLE_BMX_EXTRA_TRICK_FORCES` | `void SET_DISABLE_BMX_EXTRA_TRICK_FORCES(object p0)` | void | - |
| `SET_DISABLE_DAMAGE_WITH_PICKED_UP_ENTITY` | `bool SET_DISABLE_DAMAGE_WITH_PICKED_UP_ENTITY(object p0, object p1)` | bool | - |
| `SET_DISABLE_EXPLODE_FROM_BODY_DAMAGE_ON_COLLISION` | `void SET_DISABLE_EXPLODE_FROM_BODY_DAMAGE_ON_COLLISION(int vehicle, bool disable)` | void | Prevents the vehicle from exploding when taking body damage if it was caused by a collision. Only wo... |
| `SET_DISABLE_HELI_EXPLODE_FROM_BODY_DAMAGE` | `void SET_DISABLE_HELI_EXPLODE_FROM_BODY_DAMAGE(int vehicle, bool disable)` | void | Prevents the vehicle from exploding when taking body damage. Only works for helis and planes. |
| `SET_DISABLE_HOVER_MODE_FLIGHT` | `void SET_DISABLE_HOVER_MODE_FLIGHT(int vehicle, bool toggle)` | void | Disables "wings" for some flying vehicles. Works only for oppressor _2_ and deluxo.<br>For deluxo it ju... |
| `SET_DISABLE_MAP_COLLISION` | `void SET_DISABLE_MAP_COLLISION(int vehicle)` | void | Disables collision for this vehicle (maybe it also supports other entities, not sure).<br>Only world/bu... |
| `SET_DISABLE_PED_STAND_ON_TOP` | `void SET_DISABLE_PED_STAND_ON_TOP(int vehicle, bool toggle)` | void | - |
| `SET_DISABLE_PRETEND_OCCUPANTS` | `void SET_DISABLE_PRETEND_OCCUPANTS(int vehicle, bool toggle)` | void | - |
| `SET_DISABLE_RANDOM_TRAINS_THIS_FRAME` | `void SET_DISABLE_RANDOM_TRAINS_THIS_FRAME(bool toggle)` | void | - |
| `SET_DISABLE_RETRACTING_WEAPON_BLADES` | `void SET_DISABLE_RETRACTING_WEAPON_BLADES(bool toggle)` | void | - |
| `SET_DISABLE_SUPERDUMMY` | `void SET_DISABLE_SUPERDUMMY(int vehicle, bool p1)` | void | - |
| `SET_DISABLE_TURRET_MOVEMENT` | `void SET_DISABLE_TURRET_MOVEMENT(int vehicle, int turretId)` | void | Disables turret movement when called in a loop. You can still fire and aim. You cannot shoot backwar... |
| `SET_DISABLE_VEHICLE_ENGINE_FIRES` | `void SET_DISABLE_VEHICLE_ENGINE_FIRES(int vehicle, bool toggle)` | void | - |
| `SET_DISABLE_VEHICLE_EXPLOSIONS_DAMAGE` | `void SET_DISABLE_VEHICLE_EXPLOSIONS_DAMAGE(bool toggle)` | void | - |
| `SET_DISABLE_VEHICLE_PETROL_TANK_DAMAGE` | `void SET_DISABLE_VEHICLE_PETROL_TANK_DAMAGE(int vehicle, bool toggle)` | void | - |
| `SET_DISABLE_VEHICLE_PETROL_TANK_FIRES` | `void SET_DISABLE_VEHICLE_PETROL_TANK_FIRES(int vehicle, bool toggle)` | void | - |
| `SET_DISABLE_VERTICAL_FLIGHT_MODE_TRANSITION` | `void SET_DISABLE_VERTICAL_FLIGHT_MODE_TRANSITION(int vehicle, bool toggle)` | void | True stops vtols from switching modes. Doesn't stop the sound though. |
| `SET_DISABLE_WANTED_CONES_RESPONSE` | `void SET_DISABLE_WANTED_CONES_RESPONSE(int vehicle, bool toggle)` | void | - |
| `SET_DISABLE_WEAPON_BLADE_FORCES` | `void SET_DISABLE_WEAPON_BLADE_FORCES(bool toggle)` | void | Sets some global vehicle related bool |
| `SET_DISTANT_CARS_ENABLED` | `void SET_DISTANT_CARS_ENABLED(bool toggle)` | void | Toggles to render distant vehicles. They may not be vehicles but images to look like vehicles. |
| `SET_DONT_ALLOW_PLAYER_TO_ENTER_VEHICLE_IF_LOCKED_FOR_PLAYER` | `void SET_DONT_ALLOW_PLAYER_TO_ENTER_VEHICLE_IF_LOCKED_FOR_PLAYER(int vehicle, bool p1)` | void | - |
| `SET_DONT_PROCESS_VEHICLE_GLASS` | `void SET_DONT_PROCESS_VEHICLE_GLASS(int vehicle, bool toggle)` | void | R* used it to "remove" vehicle windows when "nightshark" had some mod, which adding some kind of arm... |
| `SET_DOOR_ALLOWED_TO_BE_BROKEN_OFF` | `void SET_DOOR_ALLOWED_TO_BE_BROKEN_OFF(int vehicle, int doorId, bool isBreakable)` | void | doorId: see SET_VEHICLE_DOOR_SHUT |
| `SET_DRIFT_TYRES` | `void SET_DRIFT_TYRES(int vehicle, bool toggle)` | void | - |
| `SET_ENABLE_VEHICLE_SLIPSTREAMING` | `void SET_ENABLE_VEHICLE_SLIPSTREAMING(bool toggle)` | void | Enable/Disables global slipstream physics |
| `SET_FAR_DRAW_VEHICLES` | `void SET_FAR_DRAW_VEHICLES(bool toggle)` | void | - |
| `SET_FLEEING_VEHICLES_USE_SWITCHED_OFF_NODES` | `void SET_FLEEING_VEHICLES_USE_SWITCHED_OFF_NODES(object p0)` | void | - |
| `SET_FORCE_FIX_LINK_MATRICES` | `void SET_FORCE_FIX_LINK_MATRICES(int vehicle)` | void | - |
| `SET_FORCE_HD_VEHICLE` | `void SET_FORCE_HD_VEHICLE(int vehicle, bool toggle)` | void | - |
| `SET_FORCE_LOW_LOD_ANCHOR_MODE` | `void SET_FORCE_LOW_LOD_ANCHOR_MODE(int vehicle, bool p1)` | void | No observed effect. |
| `SET_FORCE_VEHICLE_ENGINE_DAMAGE_BY_BULLET` | `void SET_FORCE_VEHICLE_ENGINE_DAMAGE_BY_BULLET(object p0, bool p1)` | void | - |
| `SET_FORKLIFT_FORK_HEIGHT` | `void SET_FORKLIFT_FORK_HEIGHT(int vehicle, float height)` | void | 0.0 = Lowest 1.0 = Highest. This is best to be used if you wanna pick-up a car since un-realisticall... |
| `SET_FORMATION_LEADER` | `void SET_FORMATION_LEADER(int vehicle, float x, float y, float z, float p4)` | void | - |
| `SET_GARBAGE_TRUCKS` | `void SET_GARBAGE_TRUCKS(bool toggle)` | void | - |
| `SET_GLIDER_ACTIVE` | `void SET_GLIDER_ACTIVE(int vehicle, bool state)` | void | Set state to true to extend the wings, false to retract them. |
| `SET_GLOBAL_POSITION_OFFSET_FOR_RECORDED_VEHICLE_PLAYBACK` | `void SET_GLOBAL_POSITION_OFFSET_FOR_RECORDED_VEHICLE_PLAYBACK(int vehicle, float x, float y, float z)` | void | - |
| `SET_GOON_BOSS_VEHICLE` | `void SET_GOON_BOSS_VEHICLE(int vehicle, bool toggle)` | void | Used for GTAO CEO/Associate spawned vehicles. |
| `SET_GROUND_EFFECT_REDUCES_DRAG` | `void SET_GROUND_EFFECT_REDUCES_DRAG(bool toggle)` | void | - |
| `SET_HELI_BLADES_FULL_SPEED` | `void SET_HELI_BLADES_FULL_SPEED(int vehicle)` | void | Equivalent of SET_HELI_BLADES_SPEED(vehicleHandle, 1.0f); |
| `SET_HELI_BLADES_SPEED` | `void SET_HELI_BLADES_SPEED(int vehicle, float speed)` | void | Sets the speed of the helicopter blades in percentage of the full speed.<br><br>vehicleHandle: The helicop... |
| `SET_HELI_CAN_PICKUP_ENTITY_THAT_HAS_PICK_UP_DISABLED` | `void SET_HELI_CAN_PICKUP_ENTITY_THAT_HAS_PICK_UP_DISABLED(int vehicle, bool toggle)` | void | Stops the cargobob from being able to attach any vehicle |
| `SET_HELI_COMBAT_OFFSET` | `void SET_HELI_COMBAT_OFFSET(int vehicle, float x, float y, float z)` | void | - |
| `SET_HELI_CONTROL_LAGGING_RATE_SCALAR` | `void SET_HELI_CONTROL_LAGGING_RATE_SCALAR(int helicopter, float multiplier)` | void | value between 0.0 and 1.0 |
| `SET_HELI_MAIN_ROTOR_HEALTH` | `void SET_HELI_MAIN_ROTOR_HEALTH(int vehicle, float health)` | void | - |
| `SET_HELI_RESIST_TO_EXPLOSION` | `void SET_HELI_RESIST_TO_EXPLOSION(int vehicle, bool toggle)` | void | - |
| `SET_HELI_TAIL_BOOM_CAN_BREAK_OFF` | `bool SET_HELI_TAIL_BOOM_CAN_BREAK_OFF(int vehicle, bool toggle)` | bool | - |
| `SET_HELI_TAIL_ROTOR_HEALTH` | `void SET_HELI_TAIL_ROTOR_HEALTH(int vehicle, float health)` | void | - |
| `SET_HELI_TURBULENCE_SCALAR` | `void SET_HELI_TURBULENCE_SCALAR(int vehicle, float p1)` | void | - |
| `SET_HOVER_MODE_WING_RATIO` | `void SET_HOVER_MODE_WING_RATIO(int vehicle, float ratio)` | void | - |
| `SET_HYDRAULICS_CONTROL` | `void SET_HYDRAULICS_CONTROL(int vehicle, bool toggle)` | void | If false, lowers hydraulics (if raised) and disables hydraulics controls. If true, raises hydraulics... |
| `SET_HYDRAULIC_SUSPENSION_RAISE_FACTOR` | `void SET_HYDRAULIC_SUSPENSION_RAISE_FACTOR(int vehicle, int wheelId, float value)` | void | Works only on vehicles that support hydraulics. |
| `SET_HYDRAULIC_VEHICLE_STATE` | `void SET_HYDRAULIC_VEHICLE_STATE(int vehicle, int state)` | void | States:<br>4 = raise<br>5 = lower<br>6 = jump |
| `SET_HYDRAULIC_WHEEL_STATE` | `void SET_HYDRAULIC_WHEEL_STATE(int vehicle, int wheelId, int state, float value, object p4)` | void | Sets vehicle wheel hydraulic states transition. Known states:<br>0 - reset<br>1 - raise wheel (uses value ... |
| `SET_IGNORE_PLANES_SMALL_PITCH_CHANGE` | `void SET_IGNORE_PLANES_SMALL_PITCH_CHANGE(object p0, object p1)` | void | - |
| `SET_INCREASE_WHEEL_CRUSH_DAMAGE` | `void SET_INCREASE_WHEEL_CRUSH_DAMAGE(int vehicle, bool toggle)` | void | - |
| `SET_INVERT_VEHICLE_CONTROLS` | `void SET_INVERT_VEHICLE_CONTROLS(int vehicle, bool state)` | void | Inverts vehicle's controls. So INPUT_VEH_ACCELERATE will be INPUT_VEH_BRAKE and vise versa (same for... |
| `SET_LAST_DRIVEN_VEHICLE` | `void SET_LAST_DRIVEN_VEHICLE(int vehicle)` | void | - |
| `SET_LIGHTS_CUTOFF_DISTANCE_TWEAK` | `void SET_LIGHTS_CUTOFF_DISTANCE_TWEAK(float distance)` | void | - |
| `SET_MISSION_TRAIN_AS_NO_LONGER_NEEDED` | `void SET_MISSION_TRAIN_AS_NO_LONGER_NEEDED(Vehicle* train, bool p1)` | void | p1 is always 0 |
| `SET_MISSION_TRAIN_COORDS` | `void SET_MISSION_TRAIN_COORDS(int train, float x, float y, float z)` | void | - |
| `SET_NITROUS_IS_ACTIVE` | `void SET_NITROUS_IS_ACTIVE(int vehicle, bool toggle)` | void | - |
| `SET_NUMBER_OF_PARKED_VEHICLES` | `void SET_NUMBER_OF_PARKED_VEHICLES(int value)` | void | - |
| `SET_OPEN_REAR_DOORS_ON_EXPLOSION` | `void SET_OPEN_REAR_DOORS_ON_EXPLOSION(int vehicle, bool toggle)` | void | - |
| `SET_OVERRIDE_NITROUS_LEVEL` | `void SET_OVERRIDE_NITROUS_LEVEL(int vehicle, bool toggle, float level, float power, float rechargeTime, bool disableSound)` | void | - |
| `SET_OVERRIDE_VEHICLE_DOOR_TORQUE` | `void SET_OVERRIDE_VEHICLE_DOOR_TORQUE(object p0, object p1, object p2)` | void | - |
| `SET_PARKED_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME` | `void SET_PARKED_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier)` | void | - |
| `SET_PEDS_CAN_FALL_OFF_THIS_VEHICLE_FROM_LARGE_FALL_DAMAGE` | `void SET_PEDS_CAN_FALL_OFF_THIS_VEHICLE_FROM_LARGE_FALL_DAMAGE(int vehicle, bool toggle, float p2)` | void | Sets some bit and float of vehicle. float is >= 0 |
| `SET_PICKUP_ROPE_LENGTH_FOR_CARGOBOB` | `void SET_PICKUP_ROPE_LENGTH_FOR_CARGOBOB(int cargobob, float length1, float length2, bool p3)` | void | min: 1.9f, max: 100.0f |
| `SET_PICKUP_ROPE_LENGTH_WITHOUT_CREATING_ROPE_FOR_CARGOBOB` | `void SET_PICKUP_ROPE_LENGTH_WITHOUT_CREATING_ROPE_FOR_CARGOBOB(object p0, object p1, object p2)` | void | - |
| `SET_PLANE_CONTROL_SECTIONS_SHOULD_BREAK_OFF_FROM_EXPLOSIONS` | `void SET_PLANE_CONTROL_SECTIONS_SHOULD_BREAK_OFF_FROM_EXPLOSIONS(int vehicle, bool toggle)` | void | - |
| `SET_PLANE_ENGINE_HEALTH` | `void SET_PLANE_ENGINE_HEALTH(int vehicle, float health)` | void | Works just like SET_VEHICLE_ENGINE_HEALTH, but only for planes. |
| `SET_PLANE_PROPELLER_HEALTH` | `bool SET_PLANE_PROPELLER_HEALTH(int plane, float health)` | bool | - |
| `SET_PLANE_RESIST_TO_EXPLOSION` | `void SET_PLANE_RESIST_TO_EXPLOSION(int vehicle, bool toggle)` | void | - |
| `SET_PLANE_SECTION_DAMAGE_SCALE` | `void SET_PLANE_SECTION_DAMAGE_SCALE(int vehicle, object p1, object p2)` | void | - |
| `SET_PLANE_TURBULENCE_MULTIPLIER` | `void SET_PLANE_TURBULENCE_MULTIPLIER(int vehicle, float multiplier)` | void | This native sets the turbulence multiplier. It only works for planes.<br>0.0 = no turbulence at all.<br>1.... |
| `SET_PLAYBACK_SPEED` | `void SET_PLAYBACK_SPEED(int vehicle, float speed)` | void | - |
| `SET_PLAYBACK_TO_USE_AI` | `void SET_PLAYBACK_TO_USE_AI(int vehicle, int drivingStyle)` | void | Identical to SET_PLAYBACK_TO_USE_AI_TRY_TO_REVERT_BACK_LATER with 0 as arguments for p1 and p3. |
| `SET_PLAYBACK_TO_USE_AI_TRY_TO_REVERT_BACK_LATER` | `void SET_PLAYBACK_TO_USE_AI_TRY_TO_REVERT_BACK_LATER(int vehicle, int time, int drivingStyle, bool p3)` | void | Time is number of milliseconds before reverting, zero for indefinitely. |
| `SET_PLAYERS_LAST_VEHICLE` | `void SET_PLAYERS_LAST_VEHICLE(int vehicle)` | void | - |
| `SET_POLICE_FOCUS_WILL_TRACK_VEHICLE` | `void SET_POLICE_FOCUS_WILL_TRACK_VEHICLE(int vehicle, bool toggle)` | void | - |
| `SET_POSITION_OFFSET_FOR_RECORDED_VEHICLE_PLAYBACK` | `void SET_POSITION_OFFSET_FOR_RECORDED_VEHICLE_PLAYBACK(int vehicle, float x, float y, float z)` | void | - |
| `SET_RANDOM_BOATS` | `void SET_RANDOM_BOATS(bool toggle)` | void | - |
| `SET_RANDOM_BOATS_MP` | `void SET_RANDOM_BOATS_MP(bool toggle)` | void | - |
| `SET_RANDOM_TRAINS` | `void SET_RANDOM_TRAINS(bool toggle)` | void | - |
| `SET_RANDOM_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME` | `void SET_RANDOM_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier)` | void | - |
| `SET_REDUCED_SUSPENSION_FORCE` | `void SET_REDUCED_SUSPENSION_FORCE(int vehicle, bool enable)` | void | Lowers the vehicle's stance. Only works for vehicles that have strAdvancedFlags 0x8000 and 0x4000000... |
| `SET_RENDER_TRAIN_AS_DERAILED` | `void SET_RENDER_TRAIN_AS_DERAILED(int train, bool toggle)` | void | Makes the train all jumbled up and derailed as it moves on the tracks (though that wont stop it from... |
| `SET_ROCKET_BOOST_ACTIVE` | `void SET_ROCKET_BOOST_ACTIVE(int vehicle, bool active)` | void | - |
| `SET_ROCKET_BOOST_FILL` | `void SET_ROCKET_BOOST_FILL(int vehicle, float percentage)` | void | - |
| `SET_SCRIPT_RAMP_IMPULSE_SCALE` | `void SET_SCRIPT_RAMP_IMPULSE_SCALE(int vehicle, float impulseScale)` | void | - |
| `SET_SCRIPT_ROCKET_BOOST_RECHARGE_TIME` | `void SET_SCRIPT_ROCKET_BOOST_RECHARGE_TIME(int vehicle, float seconds)` | void | - |
| `SET_SCRIPT_VEHICLE_GENERATOR` | `void SET_SCRIPT_VEHICLE_GENERATOR(int vehicleGenerator, bool enabled)` | void | Only called once in the decompiled scripts. Presumably activates the specified generator. |
| `SET_SHORT_SLOWDOWN_FOR_LANDING` | `void SET_SHORT_SLOWDOWN_FOR_LANDING(int vehicle)` | void | Used on helicopters and blimps during the CTaskVehicleLand task. Sets a value on the task to 10f |
| `SET_SHOULD_LERP_FROM_AI_TO_FULL_RECORDING` | `void SET_SHOULD_LERP_FROM_AI_TO_FULL_RECORDING(int vehicle, bool p1)` | void | A vehicle recording playback flag only used in jewelry_heist |
| `SET_SHOULD_RESET_TURRET_IN_SCRIPTED_CAMERAS` | `void SET_SHOULD_RESET_TURRET_IN_SCRIPTED_CAMERAS(int vehicle, bool shouldReset)` | void | Resets the vehicle's turret to its default position in scripted cameras. Doesn't seem to affect turr... |
| `SET_SLOW_DOWN_EFFECT_DISABLED` | `void SET_SLOW_DOWN_EFFECT_DISABLED(bool disabled)` | void | Disables the screen effects and sound effects when driving over a slowdown pad. |
| `SET_SPECIAL_FLIGHT_MODE_ALLOWED` | `void SET_SPECIAL_FLIGHT_MODE_ALLOWED(int vehicle, bool toggle)` | void | It will override the ability to transform deluxo. For oppressor it will work just like SET_DISABLE_H... |
| `SET_SPECIAL_FLIGHT_MODE_RATIO` | `void SET_SPECIAL_FLIGHT_MODE_RATIO(int vehicle, float ratio)` | void | Used in conjunction with SET_SPECIAL_FLIGHT_MODE_TARGET_RATIO, in Rockstar's scripts. Using this wil... |
| `SET_SPECIAL_FLIGHT_MODE_TARGET_RATIO` | `void SET_SPECIAL_FLIGHT_MODE_TARGET_RATIO(int vehicle, float targetRatio)` | void | Used in conjunction with SET_SPECIAL_FLIGHT_MODE_RATIO, in Rockstar's scripts. The vehicle will tran... |
| `SET_SPEED_BOOST_EFFECT_DISABLED` | `void SET_SPEED_BOOST_EFFECT_DISABLED(bool disabled)` | void | Disables the screen effects and sound effects when driving over a speed boost pad. |
| `SET_SUBMARINE_CRUSH_DEPTHS` | `void SET_SUBMARINE_CRUSH_DEPTHS(int vehicle, bool p1, float depth1, float depth2, float depth3)` | void | - |
| `SET_TASK_VEHICLE_GOTO_PLANE_MIN_HEIGHT_ABOVE_TERRAIN` | `void SET_TASK_VEHICLE_GOTO_PLANE_MIN_HEIGHT_ABOVE_TERRAIN(int plane, int height)` | void | - |
| `SET_TAXI_LIGHTS` | `void SET_TAXI_LIGHTS(int vehicle, bool state)` | void | This is not tested - it's just an assumption.<br>- Nac<br><br>Doesn't seem to work.  I'll try with an int ins... |
| `SET_TRAILER_ATTACHMENT_ENABLED` | `void SET_TRAILER_ATTACHMENT_ENABLED(object p0, object p1)` | void | - |
| `SET_TRAILER_INVERSE_MASS_SCALE` | `void SET_TRAILER_INVERSE_MASS_SCALE(int vehicle, float p1)` | void | - |
| `SET_TRAILER_LEGS_LOWERED` | `void SET_TRAILER_LEGS_LOWERED(int vehicle)` | void | - |
| `SET_TRAILER_LEGS_RAISED` | `void SET_TRAILER_LEGS_RAISED(int vehicle)` | void | in the decompiled scripts, seems to be always called on the vehicle right after being attached to a ... |
| `SET_TRAIN_CRUISE_SPEED` | `void SET_TRAIN_CRUISE_SPEED(int train, float speed)` | void | - |
| `SET_TRAIN_SPEED` | `void SET_TRAIN_SPEED(int train, float speed)` | void | - |
| `SET_TRAIN_TRACK_SPAWN_FREQUENCY` | `void SET_TRAIN_TRACK_SPAWN_FREQUENCY(int trackIndex, int frequency)` | void | Only called once inside main_persitant with the parameters p0 = 0, p1 = 120000<br><br>trackIndex: 0 - 26<br>F... |
| `SET_TRANSFORM_RATE_FOR_ANIMATION` | `void SET_TRANSFORM_RATE_FOR_ANIMATION(int vehicle, float transformRate)` | void | Affects the playback speed of the submarine car conversion animations. Does not affect hardcoded ani... |
| `SET_TRANSFORM_TO_SUBMARINE_USES_ALTERNATE_INPUT` | `void SET_TRANSFORM_TO_SUBMARINE_USES_ALTERNATE_INPUT(int vehicle, bool toggle)` | void | When set to true, the key to transform a car to submarine mode changes from raise/lower convertible ... |
| `SET_TURRET_HIDDEN` | `void SET_TURRET_HIDDEN(int vehicle, int index, bool toggle)` | void | Toggles specific flag on turret |
| `SET_TYRE_HEALTH` | `void SET_TYRE_HEALTH(int vehicle, int wheelIndex, float health)` | void | SET_TYRE_WEAR_RATE must be active, otherwise values set to <1000.0f will default to 350.0f<br><br>Usable w... |
| `SET_TYRE_MAXIMUM_GRIP_DIFFERENCE_DUE_TO_WEAR_RATE` | `void SET_TYRE_MAXIMUM_GRIP_DIFFERENCE_DUE_TO_WEAR_RATE(int vehicle, int wheelIndex, float multiplier)` | void | Controls how much traction the wheel loses.<br><br>Default values from Rockstar's Open Wheel Race JSON's:<br>... |
| `SET_TYRE_WEAR_RATE` | `void SET_TYRE_WEAR_RATE(int vehicle, int wheelIndex, float multiplier)` | void | Needs to be run for tire wear to work. Multiplier affects the downforce and how fast the tires will ... |
| `SET_TYRE_WEAR_RATE_SCALE` | `void SET_TYRE_WEAR_RATE_SCALE(int vehicle, int wheelIndex, float multiplier)` | void | Controls how fast the tires wear out.<br><br>Default values from Rockstar's Open Wheel Race JSON's:<br>"owrts... |
| `SET_USE_DESIRED_Z_CRUISE_SPEED_FOR_LANDING` | `void SET_USE_DESIRED_Z_CRUISE_SPEED_FOR_LANDING(int vehicle, bool toggle)` | void | - |
| `SET_USE_DOUBLE_CLICK_FOR_CAR_JUMP` | `void SET_USE_DOUBLE_CLICK_FOR_CAR_JUMP(bool toggle)` | void | Changes the car jump control to require a double-tap to activate. |
| `SET_USE_HIGHER_CAR_JUMP` | `void SET_USE_HIGHER_CAR_JUMP(int vehicle, bool toggle)` | void | Allows vehicles with the FLAG_JUMPING_CAR flag to jump higher (i.e. Ruiner 2000). |
| `SET_VEHICLE_ACTIVE_DURING_PLAYBACK` | `void SET_VEHICLE_ACTIVE_DURING_PLAYBACK(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_ACTIVE_FOR_PED_NAVIGATION` | `void SET_VEHICLE_ACTIVE_FOR_PED_NAVIGATION(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_ACT_AS_IF_HAS_SIREN_ON` | `void SET_VEHICLE_ACT_AS_IF_HAS_SIREN_ON(int vehicle, bool p1)` | void | - |
| `SET_VEHICLE_ACT_AS_IF_HIGH_SPEED_FOR_FRAG_SMASHING` | `void SET_VEHICLE_ACT_AS_IF_HIGH_SPEED_FOR_FRAG_SMASHING(int vehicle, bool p1)` | void | - |
| `SET_VEHICLE_AI_CAN_USE_EXCLUSIVE_SEATS` | `void SET_VEHICLE_AI_CAN_USE_EXCLUSIVE_SEATS(int vehicle, bool toggle)` | void | Used to be incorrectly named SET_VEHICLE_EXCLUSIVE_DRIVER<br>Toggles a flag related to SET_VEHICLE_EXCL... |
| `SET_VEHICLE_ALARM` | `void SET_VEHICLE_ALARM(int vehicle, bool state)` | void | - |
| `SET_VEHICLE_ALLOW_HOMING_MISSLE_LOCKON` | `void SET_VEHICLE_ALLOW_HOMING_MISSLE_LOCKON(int vehicle, bool toggle, bool p2)` | void | - |
| `SET_VEHICLE_ALLOW_HOMING_MISSLE_LOCKON_SYNCED` | `void SET_VEHICLE_ALLOW_HOMING_MISSLE_LOCKON_SYNCED(int vehicle, bool canBeLockedOn, bool p2)` | void | - |
| `SET_VEHICLE_ALLOW_NO_PASSENGERS_LOCKON` | `void SET_VEHICLE_ALLOW_NO_PASSENGERS_LOCKON(int veh, bool toggle)` | void | Makes the vehicle accept no passengers. |
| `SET_VEHICLE_AUTOMATICALLY_ATTACHES` | `int SET_VEHICLE_AUTOMATICALLY_ATTACHES(int vehicle, bool p1, object p2)` | int | - |
| `SET_VEHICLE_AVOID_PLAYER_VEHICLE_RIOT_VAN_MISSION` | `void SET_VEHICLE_AVOID_PLAYER_VEHICLE_RIOT_VAN_MISSION(object p0)` | void | - |
| `SET_VEHICLE_BLIP_THROTTLE_RANDOMLY` | `void SET_VEHICLE_BLIP_THROTTLE_RANDOMLY(int vehicle, bool p1)` | void | - |
| `SET_VEHICLE_BOBBLEHEAD_VELOCITY` | `void SET_VEHICLE_BOBBLEHEAD_VELOCITY(float x, float y, float p2)` | void | Controls how fast bobbleheads and tsurikawas move on each axis.<br><br>p2 is probably z, but changing that... |
| `SET_VEHICLE_BODY_HEALTH` | `void SET_VEHICLE_BODY_HEALTH(int vehicle, float value)` | void | p2 often set to 1000.0 in the decompiled scripts. |
| `SET_VEHICLE_BOMB_AMMO` | `void SET_VEHICLE_BOMB_AMMO(int vehicle, int bombCount)` | void | Sets the amount of bombs that this vehicle has. As far as I know, this does _not_ impact vehicle wea... |
| `SET_VEHICLE_BRAKE` | `void SET_VEHICLE_BRAKE(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_BRAKE_LIGHTS` | `void SET_VEHICLE_BRAKE_LIGHTS(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_BROKEN_PARTS_DONT_AFFECT_AI_HANDLING` | `void SET_VEHICLE_BROKEN_PARTS_DONT_AFFECT_AI_HANDLING(int vehicle, bool p1)` | void | - |
| `SET_VEHICLE_BULLDOZER_ARM_POSITION` | `void SET_VEHICLE_BULLDOZER_ARM_POSITION(int vehicle, float position, bool p2)` | void | Sets the arm position of a bulldozer. Position must be a value between 0.0 and 1.0. Ignored when `p2... |
| `SET_VEHICLE_BURNOUT` | `void SET_VEHICLE_BURNOUT(int vehicle, bool toggle)` | void | On accelerating, spins the driven wheels with the others braked, so you don't go anywhere. |
| `SET_VEHICLE_CAN_BE_TARGETTED` | `void SET_VEHICLE_CAN_BE_TARGETTED(int vehicle, bool state)` | void | This has not yet been tested - it's just an assumption of what the types could be. |
| `SET_VEHICLE_CAN_BE_USED_BY_FLEEING_PEDS` | `void SET_VEHICLE_CAN_BE_USED_BY_FLEEING_PEDS(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_CAN_BE_VISIBLY_DAMAGED` | `void SET_VEHICLE_CAN_BE_VISIBLY_DAMAGED(int vehicle, bool state)` | void | - |
| `SET_VEHICLE_CAN_BREAK` | `void SET_VEHICLE_CAN_BREAK(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_CAN_DEFORM_WHEELS` | `void SET_VEHICLE_CAN_DEFORM_WHEELS(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_CAN_EJECT_PASSENGERS_IF_LOCKED` | `void SET_VEHICLE_CAN_EJECT_PASSENGERS_IF_LOCKED(object p0, object p1)` | void | - |
| `SET_VEHICLE_CAN_ENGINE_MISSFIRE` | `void SET_VEHICLE_CAN_ENGINE_MISSFIRE(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_CAN_LEAK_OIL` | `void SET_VEHICLE_CAN_LEAK_OIL(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_CAN_LEAK_PETROL` | `void SET_VEHICLE_CAN_LEAK_PETROL(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_CAN_SAVE_IN_GARAGE` | `void SET_VEHICLE_CAN_SAVE_IN_GARAGE(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_CAUSES_SWERVING` | `void SET_VEHICLE_CAUSES_SWERVING(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_CEILING_HEIGHT` | `void SET_VEHICLE_CEILING_HEIGHT(int vehicle, float height)` | void | - |
| `SET_VEHICLE_CHEAT_POWER_INCREASE` | `void SET_VEHICLE_CHEAT_POWER_INCREASE(int vehicle, float value)` | void | <1.0 - Decreased torque<br>=1.0 - Default torque<br>>1.0 - Increased torque<br><br>Negative values will cause th... |
| `SET_VEHICLE_COLOURS` | `void SET_VEHICLE_COLOURS(int vehicle, int colorPrimary, int colorSecondary)` | void | colorPrimary & colorSecondary are the paint index for the vehicle.<br>For a list of valid paint indexes... |
| `SET_VEHICLE_COLOUR_COMBINATION` | `void SET_VEHICLE_COLOUR_COMBINATION(int vehicle, int colorCombination)` | void | Sets the selected vehicle's colors to the specified index of the color combination found in the vehi... |
| `SET_VEHICLE_COMBAT_MODE` | `void SET_VEHICLE_COMBAT_MODE(bool toggle)` | void | Does nothing. It's a nullsub. |
| `SET_VEHICLE_COUNTERMEASURE_AMMO` | `void SET_VEHICLE_COUNTERMEASURE_AMMO(int vehicle, int counterMeasureCount)` | void | Similar to SET_VEHICLE_BOMB_AMMO, this sets the amount of countermeasures that are present on this v... |
| `SET_VEHICLE_CUSTOM_PATH_NODE_STREAMING_RADIUS` | `void SET_VEHICLE_CUSTOM_PATH_NODE_STREAMING_RADIUS(int vehicle, float p1)` | void | - |
| `SET_VEHICLE_CUSTOM_PRIMARY_COLOUR` | `void SET_VEHICLE_CUSTOM_PRIMARY_COLOUR(int vehicle, int r, int g, int b)` | void | p1, p2, p3 are RGB values for color (255,0,0 for Red, ect) |
| `SET_VEHICLE_CUSTOM_SECONDARY_COLOUR` | `void SET_VEHICLE_CUSTOM_SECONDARY_COLOUR(int vehicle, int r, int g, int b)` | void | p1, p2, p3 are RGB values for color (255,0,0 for Red, ect) |
| `SET_VEHICLE_DAMAGE` | `void SET_VEHICLE_DAMAGE(int vehicle, float xOffset, float yOffset, float zOffset, float damage, float radius, bool focusOnModel)` | void | Apply damage to vehicle at a location. Location is relative to vehicle model (not world).<br><br>Radius of... |
| `SET_VEHICLE_DAMAGE_SCALE` | `bool SET_VEHICLE_DAMAGE_SCALE(int vehicle, float p1)` | bool | - |
| `SET_VEHICLE_DAMAGE_SCALES` | `void SET_VEHICLE_DAMAGE_SCALES(int vehicle, object p1, object p2, object p3, object p4)` | void | - |
| `SET_VEHICLE_DEFORMATION_FIXED` | `void SET_VEHICLE_DEFORMATION_FIXED(int vehicle)` | void | This fixes the deformation of a vehicle but the vehicle health doesn't improve |
| `SET_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME` | `void SET_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier)` | void | Use this native inside a looped function.<br>Values:<br>- `0.0` = no vehicles on streets<br>- `1.0` = normal ... |
| `SET_VEHICLE_DETONATION_MODE` | `void SET_VEHICLE_DETONATION_MODE(bool toggle)` | void | Does nothing. It's a nullsub. |
| `SET_VEHICLE_DIRT_LEVEL` | `void SET_VEHICLE_DIRT_LEVEL(int vehicle, float dirtLevel)` | void | You can't use values greater than 15.0<br>Also, R* does (float)(rand() % 15) to get a random dirt level... |
| `SET_VEHICLE_DISABLE_COLLISION_UPON_CREATION` | `void SET_VEHICLE_DISABLE_COLLISION_UPON_CREATION(int vehicle, bool disable)` | void | - |
| `SET_VEHICLE_DISABLE_HEIGHT_MAP_AVOIDANCE` | `void SET_VEHICLE_DISABLE_HEIGHT_MAP_AVOIDANCE(int vehicle, bool p1)` | void | - |
| `SET_VEHICLE_DISABLE_TOWING` | `void SET_VEHICLE_DISABLE_TOWING(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_DONT_TERMINATE_TASK_WHEN_ACHIEVED` | `void SET_VEHICLE_DONT_TERMINATE_TASK_WHEN_ACHIEVED(int vehicle)` | void | - |
| `SET_VEHICLE_DOORS_LOCKED` | `void SET_VEHICLE_DOORS_LOCKED(int vehicle, int doorLockStatus)` | void | enum eVehicleLockState<br>{<br>	VEHICLELOCK_NONE,<br>	VEHICLELOCK_UNLOCKED,<br>	VEHICLELOCK_LOCKED,<br>	VEHICLELOCK... |
| `SET_VEHICLE_DOORS_LOCKED_FOR_ALL_PLAYERS` | `void SET_VEHICLE_DOORS_LOCKED_FOR_ALL_PLAYERS(int vehicle, bool toggle)` | void | After some analysis, I've decided that these are what the parameters are.<br><br>We can see this being use... |
| `SET_VEHICLE_DOORS_LOCKED_FOR_ALL_TEAMS` | `void SET_VEHICLE_DOORS_LOCKED_FOR_ALL_TEAMS(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_DOORS_LOCKED_FOR_NON_SCRIPT_PLAYERS` | `void SET_VEHICLE_DOORS_LOCKED_FOR_NON_SCRIPT_PLAYERS(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_DOORS_LOCKED_FOR_PLAYER` | `void SET_VEHICLE_DOORS_LOCKED_FOR_PLAYER(int vehicle, int player, bool toggle)` | void | - |
| `SET_VEHICLE_DOORS_LOCKED_FOR_TEAM` | `void SET_VEHICLE_DOORS_LOCKED_FOR_TEAM(int vehicle, int team, bool toggle)` | void | - |
| `SET_VEHICLE_DOORS_SHUT` | `void SET_VEHICLE_DOORS_SHUT(int vehicle, bool closeInstantly)` | void | Closes all doors of a vehicle: |
| `SET_VEHICLE_DOOR_AUTO_LOCK` | `void SET_VEHICLE_DOOR_AUTO_LOCK(int vehicle, int doorId, bool toggle)` | void | doorId: see SET_VEHICLE_DOOR_SHUT<br><br>Usually used alongside other vehicle door natives. |
| `SET_VEHICLE_DOOR_BROKEN` | `void SET_VEHICLE_DOOR_BROKEN(int vehicle, int doorId, bool deleteDoor)` | void | doorId: see SET_VEHICLE_DOOR_SHUT |
| `SET_VEHICLE_DOOR_CONTROL` | `void SET_VEHICLE_DOOR_CONTROL(int vehicle, int doorId, int speed, float angle)` | void | doorId: see SET_VEHICLE_DOOR_SHUT |
| `SET_VEHICLE_DOOR_LATCHED` | `void SET_VEHICLE_DOOR_LATCHED(int vehicle, int doorId, bool p2, bool p3, bool p4)` | void | doorId: see SET_VEHICLE_DOOR_SHUT |
| `SET_VEHICLE_DOOR_OPEN` | `void SET_VEHICLE_DOOR_OPEN(int vehicle, int doorId, bool loose, bool openInstantly)` | void | doorId: see SET_VEHICLE_DOOR_SHUT |
| `SET_VEHICLE_DOOR_SHUT` | `void SET_VEHICLE_DOOR_SHUT(int vehicle, int doorId, bool closeInstantly)` | void | enum eDoorId<br>{<br>	VEH_EXT_DOOR_INVALID_ID = -1,<br>	VEH_EXT_DOOR_DSIDE_F,<br>	VEH_EXT_DOOR_DSIDE_R,<br>	VEH_EXT... |
| `SET_VEHICLE_DROPS_MONEY_WHEN_BLOWN_UP` | `void SET_VEHICLE_DROPS_MONEY_WHEN_BLOWN_UP(int vehicle, bool toggle)` | void | Money pickups are created around cars when they explode. Only works when the vehicle model is a car.... |
| `SET_VEHICLE_ENGINE_CAN_DEGRADE` | `void SET_VEHICLE_ENGINE_CAN_DEGRADE(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_ENGINE_HEALTH` | `void SET_VEHICLE_ENGINE_HEALTH(int vehicle, float health)` | void | 1000 is max health<br>Begins leaking gas at around 650 health<br>Minimum: -4000<br>Maximum: 1000<br><br>-4000: Engi... |
| `SET_VEHICLE_ENGINE_ON` | `void SET_VEHICLE_ENGINE_ON(int vehicle, bool value, bool instantly, bool disableAutoStart)` | void | Starts or stops the engine on the specified vehicle.<br><br>vehicle: The vehicle to start or stop the engi... |
| `SET_VEHICLE_ENVEFF_SCALE` | `void SET_VEHICLE_ENVEFF_SCALE(int vehicle, float fade)` | void | The parameter fade is a value from 0-1, where 0 is fresh paint. |
| `SET_VEHICLE_EXCLUSIVE_DRIVER` | `void SET_VEHICLE_EXCLUSIVE_DRIVER(int vehicle, int ped, int index)` | void | index: 0 - 1<br><br>Used to be incorrectly named _SET_VEHICLE_EXCLUSIVE_DRIVER_2 |
| `SET_VEHICLE_EXPLODES_ON_EXPLOSION_DAMAGE_AT_ZERO_BODY_HEALTH` | `void SET_VEHICLE_EXPLODES_ON_EXPLOSION_DAMAGE_AT_ZERO_BODY_HEALTH(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_EXPLODES_ON_HIGH_EXPLOSION_DAMAGE` | `void SET_VEHICLE_EXPLODES_ON_HIGH_EXPLOSION_DAMAGE(int vehicle, bool toggle)` | void | Sets a vehicle to be strongly resistant to explosions. p0 is the vehicle; set p1 to false to toggle ... |
| `SET_VEHICLE_EXTENDED_REMOVAL_RANGE` | `void SET_VEHICLE_EXTENDED_REMOVAL_RANGE(int vehicle, int range)` | void | Max value is 32767 |
| `SET_VEHICLE_EXTRA` | `void SET_VEHICLE_EXTRA(int vehicle, int extraId, bool disable)` | void | Available extraIds are 1-14, however none of the vehicles have extras above 12. |
| `SET_VEHICLE_EXTRA_COLOURS` | `void SET_VEHICLE_EXTRA_COLOURS(int vehicle, int pearlescentColor, int wheelColor)` | void | They use the same color indexs as SET_VEHICLE_COLOURS. |
| `SET_VEHICLE_EXTRA_COLOUR_5` | `void SET_VEHICLE_EXTRA_COLOUR_5(int vehicle, int color)` | void | - |
| `SET_VEHICLE_EXTRA_COLOUR_6` | `void SET_VEHICLE_EXTRA_COLOUR_6(int vehicle, int color)` | void | - |
| `SET_VEHICLE_FIXED` | `void SET_VEHICLE_FIXED(int vehicle)` | void | This fixes a vehicle.<br>If the vehicle's engine's broken then you cannot fix it with this native. |
| `SET_VEHICLE_FLIGHT_NOZZLE_POSITION` | `void SET_VEHICLE_FLIGHT_NOZZLE_POSITION(int vehicle, float angleRatio)` | void | - |
| `SET_VEHICLE_FLIGHT_NOZZLE_POSITION_IMMEDIATE` | `void SET_VEHICLE_FLIGHT_NOZZLE_POSITION_IMMEDIATE(int vehicle, float angle)` | void | - |
| `SET_VEHICLE_FORCE_AFTERBURNER` | `void SET_VEHICLE_FORCE_AFTERBURNER(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_FORCE_INTERIORLIGHT` | `void SET_VEHICLE_FORCE_INTERIORLIGHT(int vehicle, bool toggle)` | void | Sets some bit of vehicle |
| `SET_VEHICLE_FORWARD_SPEED` | `void SET_VEHICLE_FORWARD_SPEED(int vehicle, float speed)` | void | SCALE: Setting the speed to 30 would result in a speed of roughly 60mph, according to speedometer.<br><br>... |
| `SET_VEHICLE_FORWARD_SPEED_XY` | `void SET_VEHICLE_FORWARD_SPEED_XY(int vehicle, float speed)` | void | Seems to be identical to SET_VEHICLE_FORWARD_SPEED |
| `SET_VEHICLE_FRICTION_OVERRIDE` | `void SET_VEHICLE_FRICTION_OVERRIDE(int vehicle, float friction)` | void | Seems to be related to the metal parts, not tyres (like i was expecting lol) |
| `SET_VEHICLE_FULLBEAM` | `void SET_VEHICLE_FULLBEAM(int vehicle, bool toggle)` | void | It switch to highbeam when p1 is set to true. |
| `SET_VEHICLE_GENERATES_ENGINE_SHOCKING_EVENTS` | `void SET_VEHICLE_GENERATES_ENGINE_SHOCKING_EVENTS(int vehicle, bool toggle)` | void | Allows creation of CEventShockingPlaneFlyby, CEventShockingHelicopterOverhead, and other(?) Shocking... |
| `SET_VEHICLE_GENERATOR_AREA_OF_INTEREST` | `void SET_VEHICLE_GENERATOR_AREA_OF_INTEREST(float x, float y, float z, float radius)` | void | Related to car generators & CPlayerSwitchMgrLong |
| `SET_VEHICLE_GRAVITY` | `void SET_VEHICLE_GRAVITY(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_HANDBRAKE` | `void SET_VEHICLE_HANDBRAKE(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_HANDLING_OVERRIDE` | `void SET_VEHICLE_HANDLING_OVERRIDE(int vehicle, uint hash)` | void | Use the "AIHandling" string found in handling.meta |
| `SET_VEHICLE_HAS_BEEN_DRIVEN_FLAG` | `void SET_VEHICLE_HAS_BEEN_DRIVEN_FLAG(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_HAS_BEEN_OWNED_BY_PLAYER` | `void SET_VEHICLE_HAS_BEEN_OWNED_BY_PLAYER(int vehicle, bool owned)` | void | - |
| `SET_VEHICLE_HAS_MUTED_SIRENS` | `void SET_VEHICLE_HAS_MUTED_SIRENS(int vehicle, bool toggle)` | void | If set to true, prevents vehicle sirens from having sound, leaving only the lights. |
| `SET_VEHICLE_HAS_STRONG_AXLES` | `void SET_VEHICLE_HAS_STRONG_AXLES(int vehicle, bool toggle)` | void | if true, axles won't bend. |
| `SET_VEHICLE_HAS_UNBREAKABLE_LIGHTS` | `void SET_VEHICLE_HAS_UNBREAKABLE_LIGHTS(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_HEADLIGHT_SHADOWS` | `void SET_VEHICLE_HEADLIGHT_SHADOWS(int vehicle, int p1)` | void | p1 can be either 0, 1 or 2.<br><br>Determines how vehicle lights behave when toggled.<br><br>0 = Default (Lights... |
| `SET_VEHICLE_HOMING_LOCKEDONTO_STATE` | `void SET_VEHICLE_HOMING_LOCKEDONTO_STATE(object p0, object p1)` | void | - |
| `SET_VEHICLE_IMPATIENCE_TIMER` | `void SET_VEHICLE_IMPATIENCE_TIMER(int vehicle, object p1)` | void | Seems to copy some values in vehicle |
| `SET_VEHICLE_INACTIVE_DURING_PLAYBACK` | `void SET_VEHICLE_INACTIVE_DURING_PLAYBACK(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_INDICATOR_LIGHTS` | `void SET_VEHICLE_INDICATOR_LIGHTS(int vehicle, int turnSignal, bool toggle)` | void | Sets the turn signal enabled for a vehicle.<br>Set turnSignal to 1 for left light, 0 for right light. |
| `SET_VEHICLE_INDIVIDUAL_DOORS_LOCKED` | `void SET_VEHICLE_INDIVIDUAL_DOORS_LOCKED(int vehicle, int doorId, int doorLockStatus)` | void | doorId: see SET_VEHICLE_DOOR_SHUT |
| `SET_VEHICLE_INFLUENCES_WANTED_LEVEL` | `void SET_VEHICLE_INFLUENCES_WANTED_LEVEL(object p0, bool p1)` | void | - |
| `SET_VEHICLE_INTERIORLIGHT` | `void SET_VEHICLE_INTERIORLIGHT(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_IN_CAR_MOD_SHOP` | `void SET_VEHICLE_IN_CAR_MOD_SHOP(int vehicle, bool toggle)` | void | If set to TRUE, it seems to suppress door noises and doesn't allow the horn to be continuous. |
| `SET_VEHICLE_IS_CONSIDERED_BY_PLAYER` | `void SET_VEHICLE_IS_CONSIDERED_BY_PLAYER(int vehicle, bool toggle)` | void | Setting this to false, makes the specified vehicle to where if you press Y your character doesn't ev... |
| `SET_VEHICLE_IS_RACING` | `void SET_VEHICLE_IS_RACING(int vehicle, bool toggle)` | void | p1 (toggle) was always 1 (true) except in one case in the b678 scripts. |
| `SET_VEHICLE_IS_STOLEN` | `void SET_VEHICLE_IS_STOLEN(int vehicle, bool isStolen)` | void | - |
| `SET_VEHICLE_IS_WANTED` | `void SET_VEHICLE_IS_WANTED(int vehicle, bool state)` | void | Sets the wanted state of this vehicle. |
| `SET_VEHICLE_KEEP_ENGINE_ON_WHEN_ABANDONED` | `void SET_VEHICLE_KEEP_ENGINE_ON_WHEN_ABANDONED(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_KERS_ALLOWED` | `void SET_VEHICLE_KERS_ALLOWED(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_LIGHTS` | `void SET_VEHICLE_LIGHTS(int vehicle, int state)` | void | set's if the vehicle has lights or not.<br>not an on off toggle.<br>p1 = 0 ;vehicle normal lights, off the... |
| `SET_VEHICLE_LIGHT_MULTIPLIER` | `void SET_VEHICLE_LIGHT_MULTIPLIER(int vehicle, float multiplier)` | void | multiplier = brightness of head lights.<br>this value isn't capped afaik.<br><br>multiplier = 0.0 no lights<br>m... |
| `SET_VEHICLE_LIMIT_SPEED_WHEN_PLAYER_INACTIVE` | `void SET_VEHICLE_LIMIT_SPEED_WHEN_PLAYER_INACTIVE(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_LIVERY` | `void SET_VEHICLE_LIVERY(int vehicle, int livery)` | void | - |
| `SET_VEHICLE_LIVERY2` | `void SET_VEHICLE_LIVERY2(int vehicle, int livery)` | void | Used to set the secondary livery (the roof on Tornado Custom being one such example.)<br><br>Livery value ... |
| `SET_VEHICLE_LOD_MULTIPLIER` | `void SET_VEHICLE_LOD_MULTIPLIER(int vehicle, float multiplier)` | void | - |
| `SET_VEHICLE_MAX_SPEED` | `void SET_VEHICLE_MAX_SPEED(int vehicle, float speed)` | void | To reset the max speed, set the `speed` value to `0.0` or lower. |
| `SET_VEHICLE_MAY_BE_USED_BY_GOTO_POINT_ANY_MEANS` | `void SET_VEHICLE_MAY_BE_USED_BY_GOTO_POINT_ANY_MEANS(int vehicle, bool p1)` | void | - |
| `SET_VEHICLE_MOD` | `void SET_VEHICLE_MOD(int vehicle, int modType, int modIndex, bool customTires)` | void | In b944, there are 50 (0 - 49) mod types.<br><br>Sets the vehicle mod.<br>The vehicle must have a mod kit fir... |
| `SET_VEHICLE_MODEL_IS_SUPPRESSED` | `void SET_VEHICLE_MODEL_IS_SUPPRESSED(uint model, bool suppressed)` | void | Makes the vehicle stop spawning naturally in traffic. Here's an essential example:<br><br>VEHICLE::SET_VEH... |
| `SET_VEHICLE_MOD_COLOR_1` | `void SET_VEHICLE_MOD_COLOR_1(int vehicle, int paintType, int color, int pearlescentColor)` | void | paintType:<br>0: Normal<br>1: Metallic<br>2: Pearl<br>3: Matte<br>4: Metal<br>5: Chrome<br>6: Chameleon<br><br>color: number of... |
| `SET_VEHICLE_MOD_COLOR_2` | `void SET_VEHICLE_MOD_COLOR_2(int vehicle, int paintType, int color)` | void | Changes the secondary paint type and color<br>paintType:<br>0: Normal<br>1: Metallic<br>2: Pearl<br>3: Matte<br>4: Met... |
| `SET_VEHICLE_MOD_KIT` | `void SET_VEHICLE_MOD_KIT(int vehicle, int modKit)` | void | Set modKit to 0 if you plan to call SET_VEHICLE_MOD. That's what the game does. Most body modificati... |
| `SET_VEHICLE_NAME_DEBUG` | `void SET_VEHICLE_NAME_DEBUG(int vehicle, string name)` | void | NOTE: Debugging functions are not present in the retail version of the game. |
| `SET_VEHICLE_NEEDS_TO_BE_HOTWIRED` | `void SET_VEHICLE_NEEDS_TO_BE_HOTWIRED(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_NEON_COLOUR` | `void SET_VEHICLE_NEON_COLOUR(int vehicle, int r, int g, int b)` | void | Sets the color of the neon lights of the specified vehicle. |
| `SET_VEHICLE_NEON_ENABLED` | `void SET_VEHICLE_NEON_ENABLED(int vehicle, int index, bool toggle)` | void | Sets the neon lights of the specified vehicle on/off.<br><br>Indices:<br>0 = Left<br>1 = Right<br>2 = Front<br>3 = Bac... |
| `SET_VEHICLE_NEON_INDEX_COLOUR` | `void SET_VEHICLE_NEON_INDEX_COLOUR(int vehicle, int index)` | void | Index references CVehicleModelColor |
| `SET_VEHICLE_NOT_STEALABLE_AMBIENTLY` | `void SET_VEHICLE_NOT_STEALABLE_AMBIENTLY(int vehicle, bool p1)` | void | - |
| `SET_VEHICLE_NO_EXPLOSION_DAMAGE_FROM_DRIVER` | `void SET_VEHICLE_NO_EXPLOSION_DAMAGE_FROM_DRIVER(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_NUMBER_PLATE_TEXT` | `void SET_VEHICLE_NUMBER_PLATE_TEXT(int vehicle, string plateText)` | void | Sets a vehicle's license plate text.  8 chars maximum.<br><br>Example:<br>Ped playerPed = PLAYER::PLAYER_PED_... |
| `SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX` | `void SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX(int vehicle, int plateIndex)` | void | Plates:<br>Blue/White - 0<br>Yellow/black - 1<br>Yellow/Blue - 2<br>Blue/White2 - 3<br>Blue/White3 - 4<br>Yankton - 5 |
| `SET_VEHICLE_OCCUPANTS_TAKE_EXPLOSIVE_DAMAGE` | `void SET_VEHICLE_OCCUPANTS_TAKE_EXPLOSIVE_DAMAGE(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_ON_GROUND_PROPERLY` | `bool SET_VEHICLE_ON_GROUND_PROPERLY(int vehicle, float p1)` | bool | Sets a vehicle on the ground on all wheels.  Returns whether or not the operation was successful.<br><br>s... |
| `SET_VEHICLE_OUT_OF_CONTROL` | `void SET_VEHICLE_OUT_OF_CONTROL(int vehicle, bool killDriver, bool explodeOnImpact)` | void | Tested on the player's current vehicle. Unless you kill the driver, the vehicle doesn't loose contro... |
| `SET_VEHICLE_PETROL_TANK_HEALTH` | `void SET_VEHICLE_PETROL_TANK_HEALTH(int vehicle, float health)` | void | 1000 is max health<br>Begins leaking gas at around 650 health<br>-999.90002441406 appears to be minimum he... |
| `SET_VEHICLE_PROVIDES_COVER` | `void SET_VEHICLE_PROVIDES_COVER(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_READY_FOR_CLEANUP` | `void SET_VEHICLE_READY_FOR_CLEANUP(object p0)` | void | - |
| `SET_VEHICLE_REDUCE_GRIP` | `void SET_VEHICLE_REDUCE_GRIP(int vehicle, bool toggle)` | void | Reduces grip significantly so it's hard to go anywhere. |
| `SET_VEHICLE_REDUCE_GRIP_LEVEL` | `void SET_VEHICLE_REDUCE_GRIP_LEVEL(int vehicle, int val)` | void | val is 0-3<br>Often used in conjunction with: SET_VEHICLE_REDUCE_GRIP |
| `SET_VEHICLE_REMOVE_AGGRESSIVE_CARJACK_MISSION` | `void SET_VEHICLE_REMOVE_AGGRESSIVE_CARJACK_MISSION(object p0)` | void | - |
| `SET_VEHICLE_RESPECTS_LOCKS_WHEN_HAS_DRIVER` | `void SET_VEHICLE_RESPECTS_LOCKS_WHEN_HAS_DRIVER(int vehicle, bool p1)` | void | - |
| `SET_VEHICLE_RUDDER_BROKEN` | `void SET_VEHICLE_RUDDER_BROKEN(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_SEARCHLIGHT` | `void SET_VEHICLE_SEARCHLIGHT(int heli, bool toggle, bool canBeUsedByAI)` | void | Only works during nighttime. |
| `SET_VEHICLE_SHOOT_AT_TARGET` | `void SET_VEHICLE_SHOOT_AT_TARGET(int driver, int entity, float xTarget, float yTarget, float zTarget)` | void | Commands the driver of an armed vehicle (p0) to shoot its weapon at a target (p1). p3, p4 and p5 are... |
| `SET_VEHICLE_SHUNT_ON_STICK` | `void SET_VEHICLE_SHUNT_ON_STICK(bool toggle)` | void | Does nothing. It's a nullsub. |
| `SET_VEHICLE_SIREN` | `void SET_VEHICLE_SIREN(int vehicle, bool toggle)` | void | Activate siren on vehicle (Only works if the vehicle has a siren). |
| `SET_VEHICLE_SLIPSTREAMING_SHOULD_TIME_OUT` | `void SET_VEHICLE_SLIPSTREAMING_SHOULD_TIME_OUT(bool toggle)` | void | - |
| `SET_VEHICLE_STAYS_FROZEN_WHEN_CLEANED_UP` | `void SET_VEHICLE_STAYS_FROZEN_WHEN_CLEANED_UP(int vehicle, bool toggle)` | void | Has something to do with trains. Always precedes SET_MISSION_TRAIN_AS_NO_LONGER_NEEDED.<br>May be true ... |
| `SET_VEHICLE_STEERING_BIAS_SCALAR` | `void SET_VEHICLE_STEERING_BIAS_SCALAR(object p0, float p1)` | void | - |
| `SET_VEHICLE_STEER_BIAS` | `void SET_VEHICLE_STEER_BIAS(int vehicle, float value)` | void | Locks the vehicle's steering to the desired angle, explained below.<br><br>Requires to be called onTick. S... |
| `SET_VEHICLE_STEER_FOR_BUILDINGS` | `void SET_VEHICLE_STEER_FOR_BUILDINGS(int vehicle, object p1)` | void | - |
| `SET_VEHICLE_STOP_INSTANTLY_WHEN_PLAYER_INACTIVE` | `void SET_VEHICLE_STOP_INSTANTLY_WHEN_PLAYER_INACTIVE(int vehicle, bool toggle)` | void | sfink: sets bit in vehicle's structure, used by maintransition, fm_mission_controller, mission_race ... |
| `SET_VEHICLE_STRONG` | `void SET_VEHICLE_STRONG(int vehicle, bool toggle)` | void | If set to true, vehicle will not take crash damage, but is still susceptible to damage from bullets ... |
| `SET_VEHICLE_TAIL_BROKEN` | `void SET_VEHICLE_TAIL_BROKEN(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_TAIL_LIGHTS` | `void SET_VEHICLE_TAIL_LIGHTS(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_TANK_STATIONARY` | `void SET_VEHICLE_TANK_STATIONARY(int vehicle, bool p1)` | void | - |
| `SET_VEHICLE_TANK_TURRET_POSITION` | `void SET_VEHICLE_TANK_TURRET_POSITION(int vehicle, float position, bool p2)` | void | - |
| `SET_VEHICLE_TIMED_EXPLOSION` | `void SET_VEHICLE_TIMED_EXPLOSION(int vehicle, int ped, bool toggle)` | void | - |
| `SET_VEHICLE_TOW_TRUCK_ARM_POSITION` | `void SET_VEHICLE_TOW_TRUCK_ARM_POSITION(int vehicle, float position)` | void | Sets how much the crane on the tow truck is raised, where 0.0 is fully lowered and 1.0 is fully rais... |
| `SET_VEHICLE_TURRET_SPEED_THIS_FRAME` | `void SET_VEHICLE_TURRET_SPEED_THIS_FRAME(int vehicle, float speed)` | void | - |
| `SET_VEHICLE_TURRET_TARGET` | `void SET_VEHICLE_TURRET_TARGET(int vehicle, bool p1, float x, float y, float z, bool p5)` | void | - |
| `SET_VEHICLE_TYRES_CAN_BURST` | `void SET_VEHICLE_TYRES_CAN_BURST(int vehicle, bool toggle)` | void | Allows you to toggle bulletproof tires. |
| `SET_VEHICLE_TYRE_BURST` | `void SET_VEHICLE_TYRE_BURST(int vehicle, int index, bool onRim, float p3)` | void | "To burst tyres VEHICLE::SET_VEHICLE_TYRE_BURST(vehicle, 0, true, 1000.0)<br>to burst all tyres type it... |
| `SET_VEHICLE_TYRE_FIXED` | `void SET_VEHICLE_TYRE_FIXED(int vehicle, int tyreIndex)` | void | tyreIndex = 0 to 4 on normal vehicles<br><br>'0 = wheel_lf / bike, plane or jet front<br>'1 = wheel_rf<br>'2 = w... |
| `SET_VEHICLE_TYRE_SMOKE_COLOR` | `void SET_VEHICLE_TYRE_SMOKE_COLOR(int vehicle, int r, int g, int b)` | void | Sets the tire smoke's color of this vehicle.<br><br>vehicle: The vehicle that is the target of this method... |
| `SET_VEHICLE_UNDRIVEABLE` | `void SET_VEHICLE_UNDRIVEABLE(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_USED_FOR_PILOT_SCHOOL` | `void SET_VEHICLE_USED_FOR_PILOT_SCHOOL(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_USES_LARGE_REAR_RAMP` | `void SET_VEHICLE_USES_LARGE_REAR_RAMP(int vehicle, bool toggle)` | void | vehicle must be a plane |
| `SET_VEHICLE_USES_MP_PLAYER_DAMAGE_MULTIPLIER` | `void SET_VEHICLE_USES_MP_PLAYER_DAMAGE_MULTIPLIER(object p0, object p1)` | void | - |
| `SET_VEHICLE_USE_ALTERNATE_HANDLING` | `void SET_VEHICLE_USE_ALTERNATE_HANDLING(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_USE_BOOST_BUTTON_FOR_WHEEL_RETRACT` | `void SET_VEHICLE_USE_BOOST_BUTTON_FOR_WHEEL_RETRACT(bool toggle)` | void | Used for blazer5. Changes the quadbike-jetski transformation input from raise/lower convertible roof... |
| `SET_VEHICLE_USE_CUTSCENE_WHEEL_COMPRESSION` | `bool SET_VEHICLE_USE_CUTSCENE_WHEEL_COMPRESSION(int p0, bool p1, bool p2, bool p3)` | bool | - |
| `SET_VEHICLE_USE_MORE_RESTRICTIVE_SPAWN_CHECKS` | `void SET_VEHICLE_USE_MORE_RESTRICTIVE_SPAWN_CHECKS(int vehicle, bool p1)` | void | - |
| `SET_VEHICLE_USE_PLAYER_LIGHT_SETTINGS` | `void SET_VEHICLE_USE_PLAYER_LIGHT_SETTINGS(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_WEAPON_CAN_TARGET_OBJECTS` | `void SET_VEHICLE_WEAPON_CAN_TARGET_OBJECTS(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_WEAPON_DAMAGE_SCALE` | `bool SET_VEHICLE_WEAPON_DAMAGE_SCALE(int vehicle, float multiplier)` | bool | - |
| `SET_VEHICLE_WEAPON_RESTRICTED_AMMO` | `void SET_VEHICLE_WEAPON_RESTRICTED_AMMO(int vehicle, int weaponIndex, int capacity)` | void | Set vehicle's primary mounted weapon 2 ammo. For example, use it on APC.<br>For example, you can "remov... |
| `SET_VEHICLE_WHEELS_CAN_BREAK` | `void SET_VEHICLE_WHEELS_CAN_BREAK(int vehicle, bool enabled)` | void | - |
| `SET_VEHICLE_WHEELS_CAN_BREAK_OFF_WHEN_BLOW_UP` | `void SET_VEHICLE_WHEELS_CAN_BREAK_OFF_WHEN_BLOW_UP(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_WHEEL_TYPE` | `void SET_VEHICLE_WHEEL_TYPE(int vehicle, int WheelType)` | void | 0: Sport<br>1: Muscle<br>2: Lowrider<br>3: SUV<br>4: Offroad<br>5: Tuner<br>6: Bike Wheels<br>7: High End<br>8: Benny's Orig... |
| `SET_VEHICLE_WILL_FORCE_OTHER_VEHICLES_TO_STOP` | `void SET_VEHICLE_WILL_FORCE_OTHER_VEHICLES_TO_STOP(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_WILL_TELL_OTHERS_TO_HURRY` | `void SET_VEHICLE_WILL_TELL_OTHERS_TO_HURRY(int vehicle, bool p1)` | void | - |
| `SET_VEHICLE_WINDOW_TINT` | `void SET_VEHICLE_WINDOW_TINT(int vehicle, int tint)` | void | enum WindowTints<br>{<br> WINDOWTINT_NONE,<br>  WINDOWTINT_PURE_BLACK,<br>    WINDOWTINT_DARKSMOKE,<br> WINDOWTINT_... |
| `SET_VEHICLE_XENON_LIGHT_COLOR_INDEX` | `void SET_VEHICLE_XENON_LIGHT_COLOR_INDEX(int vehicle, int colorIndex)` | void | `color`: is the paint index for the vehicle.<br>Paint index goes from 0 to 12.<br>Be aware that it only wo... |
| `SET_WHEELIE_ENABLED` | `void SET_WHEELIE_ENABLED(int vehicle, bool enabled)` | void | Enables/disables the ability to wheelie on motorcycles. |
| `SET_WHEELS_EXTENDED_INSTANTLY` | `void SET_WHEELS_EXTENDED_INSTANTLY(int vehicle)` | void | - |
| `SET_WHEELS_RETRACTED_INSTANTLY` | `void SET_WHEELS_RETRACTED_INSTANTLY(int vehicle)` | void | - |
| `SKIP_TIME_IN_PLAYBACK_RECORDED_VEHICLE` | `void SKIP_TIME_IN_PLAYBACK_RECORDED_VEHICLE(int vehicle, float time)` | void | SET_TIME_POSITION_IN_RECORDING can be emulated by: desired_time - GET_TIME_POSITION_IN_RECORDING(veh... |
| `SKIP_TO_END_AND_STOP_PLAYBACK_RECORDED_VEHICLE` | `void SKIP_TO_END_AND_STOP_PLAYBACK_RECORDED_VEHICLE(int vehicle)` | void | - |
| `SMASH_VEHICLE_WINDOW` | `void SMASH_VEHICLE_WINDOW(int vehicle, int windowIndex)` | void | windowIndex:<br>0 = Front Left Window<br>1 = Front Right Window<br>2 = Rear Left Window<br>3 = Rear Right Window... |
| `STABILISE_ENTITY_ATTACHED_TO_HELI` | `void STABILISE_ENTITY_ATTACHED_TO_HELI(int vehicle, int entity, float p2)` | void | - |
| `START_PLAYBACK_RECORDED_VEHICLE` | `void START_PLAYBACK_RECORDED_VEHICLE(int vehicle, int recording, string script, bool p3)` | void | p3 is some flag related to 'trailers' (invokes CVehicle::GetTrailer).<br><br>See REQUEST_VEHICLE_RECORDING |
| `START_PLAYBACK_RECORDED_VEHICLE_USING_AI` | `void START_PLAYBACK_RECORDED_VEHICLE_USING_AI(int vehicle, int recording, string script, float speed, int drivingStyle)` | void | AI abides by the provided driving style (e.g., stopping at red lights or waiting behind traffic) whi... |
| `START_PLAYBACK_RECORDED_VEHICLE_WITH_FLAGS` | `void START_PLAYBACK_RECORDED_VEHICLE_WITH_FLAGS(int vehicle, int recording, string script, int flags, int time, int drivingStyle)` | void | flags requires further research, e.g., 0x4/0x8 are related to the AI driving task and 0x20 is intern... |
| `START_VEHICLE_ALARM` | `void START_VEHICLE_ALARM(int vehicle)` | void | - |
| `START_VEHICLE_HORN` | `void START_VEHICLE_HORN(int vehicle, int duration, uint mode, bool forever)` | void | Sounds the horn for the specified vehicle.<br><br>vehicle: The vehicle to activate the horn for.<br>mode: The... |
| `STOP_ALL_GARAGE_ACTIVITY` | `void STOP_ALL_GARAGE_ACTIVITY()` | void | - |
| `STOP_BRINGING_VEHICLE_TO_HALT` | `void STOP_BRINGING_VEHICLE_TO_HALT(int vehicle)` | void | Stops CTaskBringVehicleToHalt |
| `STOP_PLAYBACK_RECORDED_VEHICLE` | `void STOP_PLAYBACK_RECORDED_VEHICLE(int vehicle)` | void | - |
| `SUPPRESS_NEONS_ON_VEHICLE` | `void SUPPRESS_NEONS_ON_VEHICLE(int vehicle, bool toggle)` | void | - |
| `SWING_BOAT_BOOM_FREELY` | `void SWING_BOAT_BOOM_FREELY(int vehicle, bool toggle)` | void | Same call as ALLOW_BOAT_BOOM_TO_ANIMATE |
| `SWING_BOAT_BOOM_TO_RATIO` | `void SWING_BOAT_BOOM_TO_RATIO(int vehicle, float ratio)` | void | Sets the boat boom position for the `TR3` trailer.<br>Ratio value is between `0.0` and `1.0`, where `0.... |
| `SWITCH_TRAIN_TRACK` | `void SWITCH_TRAIN_TRACK(int trackId, bool state)` | void | Toggles whether ambient trains can spawn on the specified track or not<br><br>`trackId` is the internal id... |
| `TOGGLE_VEHICLE_MOD` | `void TOGGLE_VEHICLE_MOD(int vehicle, int modType, bool toggle)` | void | Toggles:<br>UNK17 - 17<br>Turbo - 18<br>UNK19 - 19<br>Tire Smoke - 20<br>UNK21 - 21<br>Xenon Headlights - 22 |
| `TRACK_VEHICLE_VISIBILITY` | `void TRACK_VEHICLE_VISIBILITY(int vehicle)` | void | in script hook .net <br><br>Vehicle v = ...;<br>Function.Call(Hash.TRACK_VEHICLE_VISIBILITY, v.Handle); |
| `TRANSFORM_TO_CAR` | `void TRANSFORM_TO_CAR(int vehicle, bool noAnimation)` | void | Transforms the `stormberg`/`toreador` to its "road vehicle" variant. If the vehicle is already in th... |
| `TRANSFORM_TO_SUBMARINE` | `bool TRANSFORM_TO_SUBMARINE(int vehicle, bool noAnimation)` | bool | Transforms the `stormberg`/`toreador` to its "submarine" variant. If the vehicle is already in that ... |
| `UNPAUSE_PLAYBACK_RECORDED_VEHICLE` | `void UNPAUSE_PLAYBACK_RECORDED_VEHICLE(int vehicle)` | void | - |
| `VEHICLE_SET_ENABLE_NORMALISE_RAMP_CAR_VERTICAL_VELOCTIY` | `void VEHICLE_SET_ENABLE_NORMALISE_RAMP_CAR_VERTICAL_VELOCTIY(object p0, object p1)` | void | - |
| `VEHICLE_SET_ENABLE_RAMP_CAR_SIDE_IMPULSE` | `void VEHICLE_SET_ENABLE_RAMP_CAR_SIDE_IMPULSE(object p0, object p1)` | void | - |
| `VEHICLE_SET_EXTENABLE_SIDE_TARGET_RATIO` | `int VEHICLE_SET_EXTENABLE_SIDE_TARGET_RATIO(object p0, object p1)` | int | - |
| `VEHICLE_SET_JET_WASH_FORCE_ENABLED` | `void VEHICLE_SET_JET_WASH_FORCE_ENABLED(object p0)` | void | - |
| `VEHICLE_SET_OVERRIDE_EXTENABLE_SIDE_RATIO` | `int VEHICLE_SET_OVERRIDE_EXTENABLE_SIDE_RATIO(object p0, object p1)` | int | - |
| `VEHICLE_SET_OVERRIDE_SIDE_RATIO` | `int VEHICLE_SET_OVERRIDE_SIDE_RATIO(object p0, object p1)` | int | - |
| `VEHICLE_SET_PARACHUTE_MODEL_OVERRIDE` | `void VEHICLE_SET_PARACHUTE_MODEL_OVERRIDE(int vehicle, uint modelHash)` | void | Parachute models:<br>- sr_prop_specraces_para_s_01<br>- imp_prop_impexp_para_s (SecuroServ; Default)<br>Plus,... |
| `VEHICLE_SET_PARACHUTE_MODEL_TINT_INDEX` | `void VEHICLE_SET_PARACHUTE_MODEL_TINT_INDEX(int vehicle, int textureVariation)` | void | Variations available for the generic parachute (sr_prop_specraces_para_s_01):<br>- 0: Rainbow<br>- 1: Red<br>... |
| `VEHICLE_SET_RAMP_AND_RAMMING_CARS_TAKE_DAMAGE` | `void VEHICLE_SET_RAMP_AND_RAMMING_CARS_TAKE_DAMAGE(int vehicle, bool toggle)` | void | - |
| `VEHICLE_START_PARACHUTING` | `void VEHICLE_START_PARACHUTING(int vehicle, bool active)` | void | - |
| `_ARE_MISSILE_BAYS_DEPLOYED` | `bool _ARE_MISSILE_BAYS_DEPLOYED(int vehicle)` | bool | - |
| `_ENABLE_INDIVIDUAL_PLANE_PROPELLER` | `void _ENABLE_INDIVIDUAL_PLANE_PROPELLER(int vehicle, int propeller)` | void | - |
| `_GET_IS_VEHICLE_ELECTRIC` | `bool _GET_IS_VEHICLE_ELECTRIC(uint vehicleModel)` | bool | - |
| `_GET_MISSION_TRAIN_CONFIG_INDEX_BY_NAME` | `int _GET_MISSION_TRAIN_CONFIG_INDEX_BY_NAME(string name)` | int | - |
| `_GET_REMAINING_NITROUS_DURATION` | `float _GET_REMAINING_NITROUS_DURATION(int vehicle)` | float | - |
| `_GET_VEHICLE_ALLOW_HOMING_MISSLE_LOCKON_SYNCED` | `bool _GET_VEHICLE_ALLOW_HOMING_MISSLE_LOCKON_SYNCED(int vehicle)` | bool | - |
| `_GET_VEHICLE_CURRENT_DRIVE_GEAR` | `int _GET_VEHICLE_CURRENT_DRIVE_GEAR(int vehicle)` | int | - |
| `_GET_VEHICLE_CURRENT_REV_RATIO` | `float _GET_VEHICLE_CURRENT_REV_RATIO(int vehicle)` | float | - |
| `_GET_VEHICLE_DESIRED_DRIVE_GEAR` | `int _GET_VEHICLE_DESIRED_DRIVE_GEAR(int vehicle)` | int | - |
| `_GET_VEHICLE_DRIVETRAIN_TYPE` | `int _GET_VEHICLE_DRIVETRAIN_TYPE(uint vehicleModel)` | int | Returns the vehicle's drivetrain type.<br><br>enum eVehicleDrivetrainType<br>{<br>	VehicleDrivetrainType_INVALID... |
| `_GET_VEHICLE_EXHAUST_BONE` | `bool _GET_VEHICLE_EXHAUST_BONE(int vehicle, int index, ref int boneIndex, ref bool axisX)` | bool | - |
| `_GET_VEHICLE_MAX_DRIVE_GEAR_COUNT` | `int _GET_VEHICLE_MAX_DRIVE_GEAR_COUNT(int vehicle)` | int | - |
| `_GET_VEHICLE_MAX_EXHAUST_BONE_COUNT` | `int _GET_VEHICLE_MAX_EXHAUST_BONE_COUNT()` | int | - |
| `_GET_VEHICLE_MODEL_NUM_DRIVE_GEARS` | `int _GET_VEHICLE_MODEL_NUM_DRIVE_GEARS(uint vehicleModel)` | int | - |
| `_GET_VEHICLE_THROTTLE` | `float _GET_VEHICLE_THROTTLE(int vehicle)` | float | - |
| `_GET_VEHICLE_TRAILER_PARENT_VEHICLE` | `int _GET_VEHICLE_TRAILER_PARENT_VEHICLE(int trailer)` | int | - |
| `_IS_VEHICLE_GEN9_EXCLUSIVE_MODEL` | `bool _IS_VEHICLE_GEN9_EXCLUSIVE_MODEL(uint vehicleModel)` | bool | - |
| `_IS_VEHICLE_ON_BOOST_PAD` | `bool _IS_VEHICLE_ON_BOOST_PAD(int vehicle)` | bool | - |
| `_SET_ALLOW_COLLISION_WHEN_IN_VEHICLE` | `void _SET_ALLOW_COLLISION_WHEN_IN_VEHICLE(int vehicle, bool toggle)` | void | _SET_ALLOW_R* - _SET_ALLOW_V* |
| `_SET_ATTACHED_VEHICLE_TO_TOW_TRUCK_ARM` | `void _SET_ATTACHED_VEHICLE_TO_TOW_TRUCK_ARM(int towTruck, int vehicle)` | void | - |
| `_SET_BOUNDS_AFFECT_WATER_PROBES` | `void _SET_BOUNDS_AFFECT_WATER_PROBES(int vehicle, bool toggle)` | void | Use the vehicle bounds (instead of viewport) when deciding if a vehicle is sufficiently above the wa... |
| `_SET_DEPLOY_MISSILE_BAYS` | `void _SET_DEPLOY_MISSILE_BAYS(int vehicle, bool deploy)` | void | - |
| `_SET_DISABLE_EXPLODE_FROM_BODY_DAMAGE_RECEIVED_BY_AI_VEHICLE` | `void _SET_DISABLE_EXPLODE_FROM_BODY_DAMAGE_RECEIVED_BY_AI_VEHICLE(int vehicle, bool disable)` | void | Prevents the vehicle from exploding when taking body damage if the inflictor is an AI-controlled veh... |
| `_SET_DRIFT_SLIP_ANGLE_LIMITS` | `void _SET_DRIFT_SLIP_ANGLE_LIMITS(int vehicle, float durationScalar, float amplitudeScalar, float slipAngleLimit)` | void | First two floats relate to rumble, the last is a threshold |
| `_SET_MAKE_TRAIN_SCAN_FOR_BLOCKING_ENTITIES` | `void _SET_MAKE_TRAIN_SCAN_FOR_BLOCKING_ENTITIES(int train, bool toggle)` | void | - |
| `_SET_MINIMUM_TIME_BETWEEN_GEAR_SHIFTS` | `void _SET_MINIMUM_TIME_BETWEEN_GEAR_SHIFTS(int vehicle, int time)` | void | - |
| `_SET_NITROUS_IS_VISIBLE` | `void _SET_NITROUS_IS_VISIBLE(int vehicle, bool enabled)` | void | - |
| `_SET_OVERRIDE_TRACTION_LOSS_MULTIPLIER` | `void _SET_OVERRIDE_TRACTION_LOSS_MULTIPLIER(int vehicle, float modifier)` | void | - |
| `_SET_PLANE_AVOIDS_OTHERS` | `void _SET_PLANE_AVOIDS_OTHERS(int vehicle, bool toggle)` | void | - |
| `_SET_REMAINING_NITROUS_DURATION` | `void _SET_REMAINING_NITROUS_DURATION(int vehicle, float duration)` | void | - |
| `_SET_TRANSMISSION_REDUCED_GEAR_RATIO` | `void _SET_TRANSMISSION_REDUCED_GEAR_RATIO(int vehicle, bool toggle)` | void | - |
| `_SET_VEHICLE_EXPLOSIVE_DAMAGE_SCALE` | `object _SET_VEHICLE_EXPLOSIVE_DAMAGE_SCALE(int vehicle, float scale)` | object | Does not actually return anything. |
| `_SET_VEHICLE_MAX_LAUNCH_ENGINE_REVS` | `void _SET_VEHICLE_MAX_LAUNCH_ENGINE_REVS(int vehicle, float modifier)` | void | 0.0f = engine rev minimum<br>1.0f = engine rev limit |
| `_SET_VEHICLE_USE_HORN_BUTTON_FOR_NITROUS` | `void _SET_VEHICLE_USE_HORN_BUTTON_FOR_NITROUS(bool toggle)` | void | - |

---

## 详细说明

### ADD_ROAD_NODE_SPEED_ZONE

- **命名空间:** `VEHICLE`
- **Hash:** `0x2CE544C68FB812A0`
- **JHash:** `0xD6685803`
- **Build:** `323`

**C# 签名:**
```csharp
int ADD_ROAD_NODE_SPEED_ZONE(float x, float y, float z, float radius, float speed, bool p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `speed` | `float` | `float` | - |
| `p5` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `int`)

---

### ADD_VEHICLE_COMBAT_ANGLED_AVOIDANCE_AREA

- **命名空间:** `VEHICLE`
- **Hash:** `0x54B0F614960F4A5F`
- **JHash:** `0x5AB26C2B`
- **Build:** `323`

**C# 签名:**
```csharp
int ADD_VEHICLE_COMBAT_ANGLED_AVOIDANCE_AREA(float p0, float p1, float p2, float p3, float p4, float p5, float p6)
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

**返回值:** `int` (Native: `int`)

---

### ADD_VEHICLE_PHONE_EXPLOSIVE_DEVICE

- **命名空间:** `VEHICLE`
- **Hash:** `0x99AD4CCCB128CBC9`
- **JHash:** `0x811373DE`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_VEHICLE_PHONE_EXPLOSIVE_DEVICE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### ADD_VEHICLE_STUCK_CHECK_WITH_WARP

- **命名空间:** `VEHICLE`
- **Hash:** `0x2FA9923062DD396C`
- **JHash:** `0xC8B789AD`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_VEHICLE_STUCK_CHECK_WITH_WARP(object p0, float p1, object p2, bool p3, bool p4, bool p5, object p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `float` | `float` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `BOOL` | `bool` | - |
| `p5` | `BOOL` | `bool` | - |
| `p6` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### ADD_VEHICLE_UPSIDEDOWN_CHECK

- **命名空间:** `VEHICLE`
- **Hash:** `0xB72E26D81006005B`
- **JHash:** `0x3A13D384`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_VEHICLE_UPSIDEDOWN_CHECK(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### ALLOW_AMBIENT_VEHICLES_TO_AVOID_ADVERSE_CONDITIONS

- **命名空间:** `VEHICLE`
- **Hash:** `0xB264C4D2F2B0A78B`
- **JHash:** `0x45F72495`
- **Build:** `323`

**C# 签名:**
```csharp
void ALLOW_AMBIENT_VEHICLES_TO_AVOID_ADVERSE_CONDITIONS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native doesn't seem to do anything, might be a debug-only native.

Confirmed, it is a debug native.
```

---

### ALLOW_BOAT_BOOM_TO_ANIMATE

- **命名空间:** `VEHICLE`
- **Hash:** `0x0F3B4D4E43177236`
- **JHash:** `0x113DF5FD`
- **Build:** `323`

**C# 签名:**
```csharp
void ALLOW_BOAT_BOOM_TO_ANIMATE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### ALLOW_TRAIN_TO_BE_REMOVED_BY_POPULATION

- **命名空间:** `VEHICLE`
- **Hash:** `0x2310A8F9421EBF43`
- **Build:** `2372`

**C# 签名:**
```csharp
void ALLOW_TRAIN_TO_BE_REMOVED_BY_POPULATION(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### APPLY_EMP_EFFECT

- **命名空间:** `VEHICLE`
- **Hash:** `0x249249D74F813EB2`
- **Build:** `3095`

**C# 签名:**
```csharp
void APPLY_EMP_EFFECT(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### ARE_ALL_VEHICLE_WINDOWS_INTACT

- **命名空间:** `VEHICLE`
- **Hash:** `0x11D862A3E977A9EF`
- **JHash:** `0xBB619744`
- **Build:** `323`

**C# 签名:**
```csharp
bool ARE_ALL_VEHICLE_WINDOWS_INTACT(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Appears to return false if any window is broken.
```

---

### ARE_ANY_VEHICLE_SEATS_FREE

- **命名空间:** `VEHICLE`
- **Hash:** `0x2D34FC3BC4ADB780`
- **JHash:** `0x648E685A`
- **Build:** `323`

**C# 签名:**
```csharp
bool ARE_ANY_VEHICLE_SEATS_FREE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns false if every seat is occupied.
```

---

### ARE_FOLDING_WINGS_DEPLOYED

- **命名空间:** `VEHICLE`
- **Hash:** `0xAEF12960FA943792`
- **Build:** `1290`

**C# 签名:**
```csharp
bool ARE_FOLDING_WINGS_DEPLOYED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Only used with the "akula" and "annihilator2" in the decompiled native scripts.
```

---

### ARE_PLANE_CONTROL_PANELS_INTACT

- **命名空间:** `VEHICLE`
- **Hash:** `0xF78F94D60248C737`
- **JHash:** `0x3B51B348`
- **Build:** `323`

**C# 签名:**
```csharp
bool ARE_PLANE_CONTROL_PANELS_INTACT(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### ARE_PLANE_PROPELLERS_INTACT

- **命名空间:** `VEHICLE`
- **Hash:** `0x755D6D5267CBBD7E`
- **JHash:** `0xABBDD5C6`
- **Build:** `323`

**C# 签名:**
```csharp
bool ARE_PLANE_PROPELLERS_INTACT(int plane)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `plane` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### ARE_WINGS_OF_PLANE_INTACT

- **命名空间:** `VEHICLE`
- **Hash:** `0x5991A01434CE9677`
- **JHash:** `0xAF8CB3DF`
- **Build:** `323`

**C# 签名:**
```csharp
bool ARE_WINGS_OF_PLANE_INTACT(int plane)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `plane` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### ATTACH_CONTAINER_TO_HANDLER_FRAME_WHEN_LINED_UP

- **命名空间:** `VEHICLE`
- **Hash:** `0x6A98C2ECF57FA5D4`
- **JHash:** `0x20AB5783`
- **Build:** `323`

**C# 签名:**
```csharp
void ATTACH_CONTAINER_TO_HANDLER_FRAME_WHEN_LINED_UP(int vehicle, int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### ATTACH_ENTITY_TO_CARGOBOB

- **命名空间:** `VEHICLE`
- **Hash:** `0xA1DD82F3CCF9A01E`
- **JHash:** `0xAEB29F98`
- **Build:** `944`

**C# 签名:**
```csharp
void ATTACH_ENTITY_TO_CARGOBOB(object p0, object p1, object p2, object p3, object p4, object p5)
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

**返回值:** `void` (Native: `void`)

---

### ATTACH_VEHICLE_ON_TO_TRAILER

- **命名空间:** `VEHICLE`
- **Hash:** `0x16B5E274BDE402F8`
- **JHash:** `0x12AC1A16`
- **Build:** `323`

**C# 签名:**
```csharp
void ATTACH_VEHICLE_ON_TO_TRAILER(int vehicle, int trailer, float offsetX, float offsetY, float offsetZ, float coordsX, float coordsY, float coordsZ, float rotationX, float rotationY, float rotationZ, float disableCollisions)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `trailer` | `Vehicle` | `int` | - |
| `offsetX` | `float` | `float` | - |
| `offsetY` | `float` | `float` | - |
| `offsetZ` | `float` | `float` | - |
| `coordsX` | `float` | `float` | - |
| `coordsY` | `float` | `float` | - |
| `coordsZ` | `float` | `float` | - |
| `rotationX` | `float` | `float` | - |
| `rotationY` | `float` | `float` | - |
| `rotationZ` | `float` | `float` | - |
| `disableCollisions` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This is the proper way of attaching vehicles to the car carrier, it's what Rockstar uses. Video Demo: https://www.youtube.com/watch?v=2lVEIzf7bgo
```

---

### ATTACH_VEHICLE_TO_CARGOBOB

- **命名空间:** `VEHICLE`
- **Hash:** `0x4127F1D84E347769`
- **JHash:** `0x607DC9D5`
- **Build:** `323`

**C# 签名:**
```csharp
void ATTACH_VEHICLE_TO_CARGOBOB(int cargobob, int vehicle, int p2, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cargobob` | `Vehicle` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `p2` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### ATTACH_VEHICLE_TO_TOW_TRUCK

- **命名空间:** `VEHICLE`
- **Hash:** `0x29A16F8D621C4508`
- **JHash:** `0x8151571A`
- **Build:** `323`

**C# 签名:**
```csharp
void ATTACH_VEHICLE_TO_TOW_TRUCK(int towTruck, int vehicle, bool rear, float hookOffsetX, float hookOffsetY, float hookOffsetZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `towTruck` | `Vehicle` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `rear` | `BOOL` | `bool` | - |
| `hookOffsetX` | `float` | `float` | - |
| `hookOffsetY` | `float` | `float` | - |
| `hookOffsetZ` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
HookOffset defines where the hook is attached. leave at 0 for default attachment.
```

---

### ATTACH_VEHICLE_TO_TRAILER

- **命名空间:** `VEHICLE`
- **Hash:** `0x3C7D42D58F770B54`
- **JHash:** `0x2133977F`
- **Build:** `323`

**C# 签名:**
```csharp
void ATTACH_VEHICLE_TO_TRAILER(int vehicle, int trailer, float radius)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `trailer` | `Vehicle` | `int` | - |
| `radius` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### BRING_VEHICLE_TO_HALT

- **命名空间:** `VEHICLE`
- **Hash:** `0x260BE8F09E326A20`
- **JHash:** `0xCBC7D3C8`
- **Build:** `323`

**C# 签名:**
```csharp
void BRING_VEHICLE_TO_HALT(int vehicle, float distance, int duration, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `distance` | `float` | `float` | - |
| `duration` | `int` | `int` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native makes the vehicle stop immediately, as happens when we enter a MP garage.

. distance defines how far it will travel until stopping. Garage doors use 3.0.

. If killEngine is set to 1, you cannot resume driving the vehicle once it stops. This looks like is a bitmapped integer.
```

---

### CAN_ANCHOR_BOAT_HERE

- **命名空间:** `VEHICLE`
- **Hash:** `0x26C10ECBDA5D043B`
- **JHash:** `0xE97A4F5E`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_ANCHOR_BOAT_HERE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_ANCHOR_BOAT_HERE_IGNORE_PLAYERS

- **命名空间:** `VEHICLE`
- **Hash:** `0x24F4121D07579880`
- **Build:** `678`

**C# 签名:**
```csharp
bool CAN_ANCHOR_BOAT_HERE_IGNORE_PLAYERS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_CARGOBOB_PICK_UP_ENTITY

- **命名空间:** `VEHICLE`
- **Hash:** `0x2C1D8B3B19E517CC`
- **Build:** `757`

**C# 签名:**
```csharp
bool CAN_CARGOBOB_PICK_UP_ENTITY(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_SHUFFLE_SEAT

- **命名空间:** `VEHICLE`
- **Hash:** `0x30785D90C956BF35`
- **JHash:** `0xB3EB01ED`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_SHUFFLE_SEAT(int vehicle, int seatIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `seatIndex` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CLEAR_LAST_DRIVEN_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0xE01903C47C7AC89E`
- **JHash:** `0x07186AD9`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_LAST_DRIVEN_VEHICLE()
```

**返回值:** `void` (Native: `void`)

---

### CLEAR_NITROUS

- **命名空间:** `VEHICLE`
- **Hash:** `0xC889AE921400E1ED`
- **Build:** `3095`

**C# 签名:**
```csharp
void CLEAR_NITROUS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_VEHICLE_CUSTOM_PRIMARY_COLOUR

- **命名空间:** `VEHICLE`
- **Hash:** `0x55E1D2758F34E437`
- **JHash:** `0x51E1E33D`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_VEHICLE_CUSTOM_PRIMARY_COLOUR(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_VEHICLE_CUSTOM_SECONDARY_COLOUR

- **命名空间:** `VEHICLE`
- **Hash:** `0x5FFBDEEC3E8E2009`
- **JHash:** `0x7CE00B29`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_VEHICLE_CUSTOM_SECONDARY_COLOUR(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_VEHICLE_GENERATOR_AREA_OF_INTEREST

- **命名空间:** `VEHICLE`
- **Hash:** `0x0A436B8643716D14`
- **JHash:** `0x6C73E45A`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_VEHICLE_GENERATOR_AREA_OF_INTEREST()
```

**返回值:** `void` (Native: `void`)

---

### CLEAR_VEHICLE_PETROLTANK_FIRE_CULPRIT

- **命名空间:** `VEHICLE`
- **Hash:** `0x4419966C9936071A`
- **Build:** `463`

**C# 签名:**
```csharp
void CLEAR_VEHICLE_PETROLTANK_FIRE_CULPRIT(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_VEHICLE_PHONE_EXPLOSIVE_DEVICE

- **命名空间:** `VEHICLE`
- **Hash:** `0xAA3F739ABDDCF21F`
- **Build:** `463`

**C# 签名:**
```csharp
void CLEAR_VEHICLE_PHONE_EXPLOSIVE_DEVICE()
```

**返回值:** `void` (Native: `void`)

---

### CLEAR_VEHICLE_ROUTE_HISTORY

- **命名空间:** `VEHICLE`
- **Hash:** `0x6D6AF961B72728AE`
- **JHash:** `0x8DD9AA0C`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_VEHICLE_ROUTE_HISTORY(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLOSE_BOMB_BAY_DOORS

- **命名空间:** `VEHICLE`
- **Hash:** `0x3556041742A0DC74`
- **JHash:** `0xF8EC5751`
- **Build:** `323`

**C# 签名:**
```csharp
void CLOSE_BOMB_BAY_DOORS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CONTROL_LANDING_GEAR

- **命名空间:** `VEHICLE`
- **Hash:** `0xCFC8BE9A5E1FE575`
- **JHash:** `0x24F873FB`
- **Build:** `323`

**C# 签名:**
```csharp
void CONTROL_LANDING_GEAR(int vehicle, int state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `state` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Works for vehicles with a retractable landing gear

Landing gear states:

0: Deployed
1: Closing
2: Opening
3: Retracted
```

---

### COPY_VEHICLE_DAMAGES

- **命名空间:** `VEHICLE`
- **Hash:** `0xE44A982368A4AF23`
- **JHash:** `0xBAE491C7`
- **Build:** `323`

**C# 签名:**
```csharp
void COPY_VEHICLE_DAMAGES(int sourceVehicle, int targetVehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `sourceVehicle` | `Vehicle` | `int` | - |
| `targetVehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Copies sourceVehicle's damage (broken bumpers, broken lights, etc.) to targetVehicle.
```

---

### CREATE_MISSION_TRAIN

- **命名空间:** `VEHICLE`
- **Hash:** `0x63C6CCA8E68AE8C8`
- **JHash:** `0xD4C2EAFD`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_MISSION_TRAIN(int variation, float x, float y, float z, bool direction, object p5, object p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `variation` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `direction` | `BOOL` | `bool` | - |
| `p5` | `Any` | `object` | - |
| `p6` | `Any` | `object` | - |

**返回值:** `int` (Native: `Vehicle`)

**说明:**
```
Train models HAVE TO be loaded (requested) before you use this.
For variation 15 - request:

freight
freightcar
freightgrain
freightcont1
freightcont2
freighttrailer


```

---

### CREATE_PICK_UP_ROPE_FOR_CARGOBOB

- **命名空间:** `VEHICLE`
- **Hash:** `0x7BEB0C7A235F6F3B`
- **JHash:** `0x4D3C9A99`
- **Build:** `323`

**C# 签名:**
```csharp
void CREATE_PICK_UP_ROPE_FOR_CARGOBOB(int cargobob, int state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cargobob` | `Vehicle` | `int` | - |
| `state` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Drops the Hook/Magnet on a cargobob

state
enum eCargobobHook
{
  CARGOBOB_HOOK = 0,
    CARGOBOB_MAGNET = 1,
};
```

---

### CREATE_SCRIPT_VEHICLE_GENERATOR

- **命名空间:** `VEHICLE`
- **Hash:** `0x9DEF883114668116`
- **JHash:** `0x25A9A261`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_SCRIPT_VEHICLE_GENERATOR(float x, float y, float z, float heading, float p4, float p5, uint modelHash, int p7, int p8, int p9, int p10, bool p11, bool p12, bool p13, bool p14, bool p15, int p16)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `heading` | `float` | `float` | - |
| `p4` | `float` | `float` | - |
| `p5` | `float` | `float` | - |
| `modelHash` | `Hash` | `uint` | - |
| `p7` | `int` | `int` | - |
| `p8` | `int` | `int` | - |
| `p9` | `int` | `int` | - |
| `p10` | `int` | `int` | - |
| `p11` | `BOOL` | `bool` | - |
| `p12` | `BOOL` | `bool` | - |
| `p13` | `BOOL` | `bool` | - |
| `p14` | `BOOL` | `bool` | - |
| `p15` | `BOOL` | `bool` | - |
| `p16` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Creates a script vehicle generator at the given coordinates. Most parameters after the model hash are unknown.

Parameters:
x/y/z - Generator position
heading - Generator heading
p4 - Unknown (always 5.0)
p5 - Unknown (always 3.0)
modelHash - Vehicle model hash
p7/8/9/10 - Unknown (always -1)
p11 - Unknown (usually TRUE, only one instance of FALSE)
p12/13 - Unknown (always FALSE)
p14 - Unknown (usally FALSE, only two instances of TRUE)
p15 - Unknown (always TRUE)
p16 - Unknown (always -1)

Vector3 coords = GET_ENTITY_COORDS(PLAYER_PED_ID(), 0);    CREATE_SCRIPT_VEHICLE_GENERATOR(coords.x, coords.y, coords.z, 1.0f, 5.0f, 3.0f, GET_HASH_KEY("adder"), -1. -1, -1, -1, -1, true, false, false, false, true, -1);
```

---

### CREATE_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0xAF35D0D2583051B0`
- **JHash:** `0xDD75460A`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_VEHICLE(uint modelHash, float x, float y, float z, float heading, bool isNetwork, bool bScriptHostVeh, bool p7)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `heading` | `float` | `float` | - |
| `isNetwork` | `BOOL` | `bool` | - |
| `bScriptHostVeh` | `BOOL` | `bool` | - |
| `p7` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `Vehicle`)

**说明:**
```
p7 when set to true allows you to spawn vehicles under -100 z.
Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
```

---

### DELETE_ALL_TRAINS

- **命名空间:** `VEHICLE`
- **Hash:** `0x736A718577F39C7D`
- **JHash:** `0x83DE7ABF`
- **Build:** `323`

**C# 签名:**
```csharp
void DELETE_ALL_TRAINS()
```

**返回值:** `void` (Native: `void`)

---

### DELETE_MISSION_TRAIN

- **命名空间:** `VEHICLE`
- **Hash:** `0x5B76B14AE875C795`
- **JHash:** `0x86C9497D`
- **Build:** `323`

**C# 签名:**
```csharp
void DELETE_MISSION_TRAIN(Vehicle* train)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `train` | `Vehicle*` | `Vehicle*` | - |

**返回值:** `void` (Native: `void`)

---

### DELETE_SCRIPT_VEHICLE_GENERATOR

- **命名空间:** `VEHICLE`
- **Hash:** `0x22102C9ABFCF125D`
- **JHash:** `0xE4328E3F`
- **Build:** `323`

**C# 签名:**
```csharp
void DELETE_SCRIPT_VEHICLE_GENERATOR(int vehicleGenerator)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicleGenerator` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DELETE_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0xEA386986E786A54F`
- **JHash:** `0x9803AF60`
- **Build:** `323`

**C# 签名:**
```csharp
void DELETE_VEHICLE(Vehicle* vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle*` | `Vehicle*` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Deletes a vehicle.
The vehicle must be a mission entity to delete, so call this before deleting: SET_ENTITY_AS_MISSION_ENTITY(vehicle, true, true);

eg how to use:
SET_ENTITY_AS_MISSION_ENTITY(vehicle, true, true);
DELETE_VEHICLE(&vehicle);

Deletes the specified vehicle, then sets the handle pointed to by the pointer to NULL.
```

---

### DETACH_CONTAINER_FROM_HANDLER_FRAME

- **命名空间:** `VEHICLE`
- **Hash:** `0x7C0043FDFF6436BC`
- **JHash:** `0x0F11D01F`
- **Build:** `323`

**C# 签名:**
```csharp
void DETACH_CONTAINER_FROM_HANDLER_FRAME(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DETACH_ENTITY_FROM_CARGOBOB

- **命名空间:** `VEHICLE`
- **Hash:** `0xAF03011701811146`
- **Build:** `678`

**C# 签名:**
```csharp
bool DETACH_ENTITY_FROM_CARGOBOB(int cargobob, int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cargobob` | `Vehicle` | `int` | - |
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DETACH_VEHICLE_FROM_ANY_CARGOBOB

- **命名空间:** `VEHICLE`
- **Hash:** `0xADF7BE450512C12F`
- **JHash:** `0x50E0EABE`
- **Build:** `323`

**C# 签名:**
```csharp
bool DETACH_VEHICLE_FROM_ANY_CARGOBOB(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DETACH_VEHICLE_FROM_ANY_TOW_TRUCK

- **命名空间:** `VEHICLE`
- **Hash:** `0xD0E9CE05A1E68CD8`
- **JHash:** `0x3BF93651`
- **Build:** `323`

**C# 签名:**
```csharp
bool DETACH_VEHICLE_FROM_ANY_TOW_TRUCK(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DETACH_VEHICLE_FROM_CARGOBOB

- **命名空间:** `VEHICLE`
- **Hash:** `0x0E21D3DF1051399D`
- **JHash:** `0x83D3D331`
- **Build:** `323`

**C# 签名:**
```csharp
void DETACH_VEHICLE_FROM_CARGOBOB(int vehicle, int cargobob)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `cargobob` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DETACH_VEHICLE_FROM_TOW_TRUCK

- **命名空间:** `VEHICLE`
- **Hash:** `0xC2DB6B6708350ED8`
- **JHash:** `0xC666CF33`
- **Build:** `323`

**C# 签名:**
```csharp
void DETACH_VEHICLE_FROM_TOW_TRUCK(int towTruck, int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `towTruck` | `Vehicle` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
First two parameters swapped. Scripts verify that towTruck is the first parameter, not the second.
```

---

### DETACH_VEHICLE_FROM_TRAILER

- **命名空间:** `VEHICLE`
- **Hash:** `0x90532EDF0D2BDD86`
- **JHash:** `0xB5DBF91D`
- **Build:** `323`

**C# 签名:**
```csharp
void DETACH_VEHICLE_FROM_TRAILER(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DETONATE_VEHICLE_PHONE_EXPLOSIVE_DEVICE

- **命名空间:** `VEHICLE`
- **Hash:** `0xEF49CF0270307CBE`
- **JHash:** `0x65255524`
- **Build:** `323`

**C# 签名:**
```csharp
void DETONATE_VEHICLE_PHONE_EXPLOSIVE_DEVICE()
```

**返回值:** `void` (Native: `void`)

---

### DISABLE_INDIVIDUAL_PLANE_PROPELLER

- **命名空间:** `VEHICLE`
- **Hash:** `0x500873A45724C863`
- **JHash:** `0x004926A3`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_INDIVIDUAL_PLANE_PROPELLER(int vehicle, int propeller)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `propeller` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DISABLE_PLANE_AILERON

- **命名空间:** `VEHICLE`
- **Hash:** `0x23428FC53C60919C`
- **JHash:** `0x7E84C45C`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_PLANE_AILERON(int vehicle, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### DISABLE_VEHCILE_DYNAMIC_AMBIENT_SCALES

- **命名空间:** `VEHICLE`
- **Hash:** `0xF0E4BA16D1DB546C`
- **JHash:** `0x5BD8D82D`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_VEHCILE_DYNAMIC_AMBIENT_SCALES(int vehicle, int p1, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Adds some kind of shadow to the vehicle.

p1 and p2 use values from 0-255 and both make the shadow darker the lower the value is. -1 disables the effect.
```

---

### DISABLE_VEHICLE_EXPLOSION_BREAK_OFF_PARTS

- **命名空间:** `VEHICLE`
- **Hash:** `0xF25E02CB9C5818F8`
- **JHash:** `0xF0E59BC1`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_VEHICLE_EXPLOSION_BREAK_OFF_PARTS()
```

**返回值:** `void` (Native: `void`)

---

### DISABLE_VEHICLE_TURRET_MOVEMENT_THIS_FRAME

- **命名空间:** `VEHICLE`
- **Hash:** `0x32CAEDF24A583345`
- **Build:** `463`

**C# 签名:**
```csharp
void DISABLE_VEHICLE_TURRET_MOVEMENT_THIS_FRAME(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DISABLE_VEHICLE_WEAPON

- **命名空间:** `VEHICLE`
- **Hash:** `0xF4FC6A6F67D8D856`
- **JHash:** `0xA688B7D1`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_VEHICLE_WEAPON(bool disabled, uint weaponHash, int vehicle, int owner)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `disabled` | `BOOL` | `bool` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `owner` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of weapons by DurtyFree (Search for VEHICLE_*): https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### DOES_CARGOBOB_HAVE_PICKUP_MAGNET

- **命名空间:** `VEHICLE`
- **Hash:** `0x6E08BF5B3722BAC9`
- **JHash:** `0x4778CA0A`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_CARGOBOB_HAVE_PICKUP_MAGNET(int cargobob)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cargobob` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true only when the magnet is active, will return false if the hook is active
```

---

### DOES_CARGOBOB_HAVE_PICK_UP_ROPE

- **命名空间:** `VEHICLE`
- **Hash:** `0x1821D91AD4B56108`
- **JHash:** `0xAF769B81`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_CARGOBOB_HAVE_PICK_UP_ROPE(int cargobob)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cargobob` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true only when the hook is active, will return false if the magnet is active
```

---

### DOES_EXTRA_EXIST

- **命名空间:** `VEHICLE`
- **Hash:** `0x1262D55792428154`
- **JHash:** `0x409411CC`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_EXTRA_EXIST(int vehicle, int extraId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `extraId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Checks via CVehicleModelInfo
```

---

### DOES_SCRIPT_VEHICLE_GENERATOR_EXIST

- **命名空间:** `VEHICLE`
- **Hash:** `0xF6086BC836400876`
- **JHash:** `0xF6BDDA30`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_SCRIPT_VEHICLE_GENERATOR_EXIST(int vehicleGenerator)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicleGenerator` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DOES_VEHICLE_ALLOW_RAPPEL

- **命名空间:** `VEHICLE`
- **Hash:** `0x4E417C547182C84D`
- **Build:** `757`

**C# 签名:**
```csharp
bool DOES_VEHICLE_ALLOW_RAPPEL(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if the vehicle has the FLAG_ALLOWS_RAPPEL flag set.
```

---

### DOES_VEHICLE_EXIST_WITH_DECORATOR

- **命名空间:** `VEHICLE`
- **Hash:** `0x956B409B984D9BF7`
- **JHash:** `0x39E68EDD`
- **Build:** `323`

**C# 签名:**
```csharp
int DOES_VEHICLE_EXIST_WITH_DECORATOR(string decorator)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `decorator` | `const char*` | `string` | - |

**返回值:** `int` (Native: `Vehicle`)

---

### DOES_VEHICLE_HAVE_ROOF

- **命名空间:** `VEHICLE`
- **Hash:** `0x8AC862B0B32C5B80`
- **JHash:** `0xDB817403`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_VEHICLE_HAVE_ROOF(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DOES_VEHICLE_HAVE_SEARCHLIGHT

- **命名空间:** `VEHICLE`
- **Hash:** `0x99015ED7DBEA5113`
- **Build:** `2189`

**C# 签名:**
```csharp
bool DOES_VEHICLE_HAVE_SEARCHLIGHT(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DOES_VEHICLE_HAVE_STUCK_VEHICLE_CHECK

- **命名空间:** `VEHICLE`
- **Hash:** `0x57E4C39DE5EE8470`
- **JHash:** `0x5D91D9AC`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_VEHICLE_HAVE_STUCK_VEHICLE_CHECK(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Maximum amount of vehicles with vehicle stuck check appears to be 16.
```

---

### DOES_VEHICLE_HAVE_WEAPONS

- **命名空间:** `VEHICLE`
- **Hash:** `0x25ECB9F8017D98E0`
- **JHash:** `0xB2E1E1FB`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_VEHICLE_HAVE_WEAPONS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### ENABLE_VEHICLE_DYNAMIC_AMBIENT_SCALES

- **命名空间:** `VEHICLE`
- **Hash:** `0xF87D9F2301F7D206`
- **JHash:** `0x450AD03A`
- **Build:** `323`

**C# 签名:**
```csharp
void ENABLE_VEHICLE_DYNAMIC_AMBIENT_SCALES(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Remove the weird shadow applied by DISABLE_VEHCILE_DYNAMIC_AMBIENT_SCALES.
```

---

### EXPLODE_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0xBA71116ADF5B514C`
- **JHash:** `0xBEDEACEB`
- **Build:** `323`

**C# 签名:**
```csharp
void EXPLODE_VEHICLE(int vehicle, bool isAudible, bool isInvisible)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `isAudible` | `BOOL` | `bool` | - |
| `isInvisible` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Explodes a selected vehicle.

Vehicle vehicle = Vehicle you want to explode.
BOOL isAudible = If explosion makes a sound.
BOOL isInvisible = If the explosion is invisible or not.

First BOOL does not give any visual explosion, the vehicle just falls apart completely but slowly and starts to burn.
```

---

### EXPLODE_VEHICLE_IN_CUTSCENE

- **命名空间:** `VEHICLE`
- **Hash:** `0x786A4EB67B01BF0B`
- **JHash:** `0xA85207B5`
- **Build:** `323`

**C# 签名:**
```csharp
void EXPLODE_VEHICLE_IN_CUTSCENE(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### FIND_HANDLER_VEHICLE_CONTAINER_IS_ATTACHED_TO

- **命名空间:** `VEHICLE`
- **Hash:** `0x375E7FC44F21C8AB`
- **JHash:** `0x70DD5E25`
- **Build:** `323`

**C# 签名:**
```csharp
int FIND_HANDLER_VEHICLE_CONTAINER_IS_ATTACHED_TO(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `int` (Native: `Vehicle`)

**说明:**
```
Finds the vehicle that is carrying this entity with a handler frame.
The model of the entity must be prop_contr_03b_ld or the function will return 0.
```

---

### FIND_SPAWN_COORDINATES_FOR_HELI

- **命名空间:** `VEHICLE`
- **Hash:** `0x8DC9675797123522`
- **Build:** `1290`

**C# 签名:**
```csharp
Vector3 FIND_SPAWN_COORDINATES_FOR_HELI(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
Native is significantly more complicated than simply generating a random vector & length.
The 'point' is either 400.0 or 250.0 units away from the Ped's current coordinates; and paths into functions like rage::grcViewport___IsSphereVisible
```

---

### FIX_VEHICLE_WINDOW

- **命名空间:** `VEHICLE`
- **Hash:** `0x772282EBEB95E682`
- **JHash:** `0x6B8E990D`
- **Build:** `323`

**C# 签名:**
```csharp
void FIX_VEHICLE_WINDOW(int vehicle, int windowIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `windowIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
windowIndex:
0 = Front Left Window
1 = Front Right Window
2 = Rear Left Window
3 = Rear Right Window
4 = Front Windscreen
5 = Rear Windscreen
6 = Mid Left
7 = Mid Right
8 = Invalid

Additional information: FIX_VEHICLE_WINDOW (0x140D0BB88) references an array of bone vehicle indices (0x141D4B3E0) { 2Ah, 2Bh, 2Ch, 2Dh, 2Eh, 2Fh, 28h, 29h } that correspond to: window_lf, window_rf, window_lr, window_rr, window_lm, window_rm, windscreen, windscreen_r. This array is used by most vehwindow natives.

Also, this function is coded to not work on vehicles of type: CBike, Bmx, CBoat, CTrain, and CSubmarine.
```

---

### FORCE_PLAYBACK_RECORDED_VEHICLE_UPDATE

- **命名空间:** `VEHICLE`
- **Hash:** `0x1F2E4E06DEA8992B`
- **JHash:** `0x01B91CD0`
- **Build:** `323`

**C# 签名:**
```csharp
void FORCE_PLAYBACK_RECORDED_VEHICLE_UPDATE(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Often called after START_PLAYBACK_RECORDED_VEHICLE and SKIP_TIME_IN_PLAYBACK_RECORDED_VEHICLE; similar in use to FORCE_ENTITY_AI_AND_ANIMATION_UPDATE.
```

---

### FORCE_SUBMARINE_NEURTAL_BUOYANCY

- **命名空间:** `VEHICLE`
- **Hash:** `0xC67DB108A9ADE3BE`
- **Build:** `2189`

**C# 签名:**
```csharp
void FORCE_SUBMARINE_NEURTAL_BUOYANCY(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### FORCE_SUBMARINE_SURFACE_MODE

- **命名空间:** `VEHICLE`
- **Hash:** `0x33506883545AC0DF`
- **JHash:** `0x54E9EE75`
- **Build:** `323`

**C# 签名:**
```csharp
void FORCE_SUBMARINE_SURFACE_MODE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### FORCE_SUB_THROTTLE_FOR_TIME

- **命名空间:** `VEHICLE`
- **Hash:** `0x99CAD8E7AFDB60FA`
- **JHash:** `0x1128A45B`
- **Build:** `323`

**C# 签名:**
```csharp
void FORCE_SUB_THROTTLE_FOR_TIME(int vehicle, float p1, float p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### FULLY_CHARGE_NITROUS

- **命名空间:** `VEHICLE`
- **Hash:** `0x1A2BCC8C636F9226`
- **Build:** `3095`

**C# 签名:**
```csharp
void FULLY_CHARGE_NITROUS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### GENERATE_VEHICLE_CREATION_POS_FROM_PATHS

- **命名空间:** `VEHICLE`
- **Hash:** `0xA4822F1CF23F4810`
- **JHash:** `0x34E02FCD`
- **Build:** `323`

**C# 签名:**
```csharp
bool GENERATE_VEHICLE_CREATION_POS_FROM_PATHS(ref Vector3 outVec, object p1, ref Vector3 outVec1, object p3, object p4, object p5, object p6, object p7, object p8)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `outVec` | `Vector3*` | `ref Vector3` | - |
| `p1` | `Any` | `object` | - |
| `outVec1` | `Vector3*` | `ref Vector3` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |
| `p5` | `Any` | `object` | - |
| `p6` | `Any` | `object` | - |
| `p7` | `Any` | `object` | - |
| `p8` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_ALL_VEHICLES

- **命名空间:** `VEHICLE`
- **Hash:** `0x9B8E1BF04B51F2E8`
- **Build:** `1103`

**C# 签名:**
```csharp
int GET_ALL_VEHICLES(ref object vehsStruct)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehsStruct` | `Any*` | `ref object` | - |

**返回值:** `int` (Native: `int`)

---

### GET_ARE_BOMB_BAY_DOORS_OPEN

- **命名空间:** `VEHICLE`
- **Hash:** `0xD0917A423314BBA8`
- **Build:** `1180`

**C# 签名:**
```csharp
bool GET_ARE_BOMB_BAY_DOORS_OPEN(int aircraft)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `aircraft` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true when the bomb bay doors of this plane are open. False if they're closed.
```

---

### GET_ATTACHED_PICK_UP_HOOK_POSITION

- **命名空间:** `VEHICLE`
- **Hash:** `0xCBDB9B923CACC92D`
- **JHash:** `0xE6633DCF`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_ATTACHED_PICK_UP_HOOK_POSITION(int cargobob)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cargobob` | `Vehicle` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
Gets the position of the cargobob hook, in world coords.
```

---

### GET_BOAT_BOOM_POSITION_RATIO

- **命名空间:** `VEHICLE`
- **Hash:** `0x6636C535F6CC2725`
- **JHash:** `0x7C8D6464`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_BOAT_BOOM_POSITION_RATIO(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_BOAT_VEHICLE_MODEL_AGILITY

- **命名空间:** `VEHICLE`
- **Hash:** `0x5AA3F878A178C4FC`
- **JHash:** `0x87C5D271`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_BOAT_VEHICLE_MODEL_AGILITY(uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
```

---

### GET_BOTH_VEHICLE_HEADLIGHTS_DAMAGED

- **命名空间:** `VEHICLE`
- **Hash:** `0xEC69ADF931AAE0C3`
- **Build:** `505`

**C# 签名:**
```csharp
bool GET_BOTH_VEHICLE_HEADLIGHTS_DAMAGED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true when both headlights are broken. This does not include extralights.
```

---

### GET_CAN_VEHICLE_BE_PLACED_HERE

- **命名空间:** `VEHICLE`
- **Hash:** `0x51F30DB60626A20E`
- **Build:** `1180`

**C# 签名:**
```csharp
bool GET_CAN_VEHICLE_BE_PLACED_HERE(int vehicle, float x, float y, float z, float rotX, float rotY, float rotZ, int p7, object p8)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `rotX` | `float` | `float` | - |
| `rotY` | `float` | `float` | - |
| `rotZ` | `float` | `float` | - |
| `p7` | `int` | `int` | - |
| `p8` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Used in decompiled scripts in combination with GET_VEHICLE_SIZE
p7 is usually 2
p8 is usually 1
```

---

### GET_CAR_HAS_JUMP

- **命名空间:** `VEHICLE`
- **Hash:** `0x9078C0C5EF8C19E9`
- **Build:** `944`

**C# 签名:**
```csharp
bool GET_CAR_HAS_JUMP(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if the vehicle has the FLAG_JUMPING_CAR flag set.
```

---

### GET_CLOSEST_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0xF73EB622C4F1689B`
- **JHash:** `0xD7E26B2C`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_CLOSEST_VEHICLE(float x, float y, float z, float radius, uint modelHash, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `modelHash` | `Hash` | `uint` | - |
| `flags` | `int` | `int` | - |

**返回值:** `int` (Native: `Vehicle`)

**说明:**
```
Example usage
VEHICLE::GET_CLOSEST_VEHICLE(x, y, z, radius, hash, unknown leave at 70) 

x, y, z: Position to get closest vehicle to.
radius: Max radius to get a vehicle.
modelHash: Limit to vehicles with this model. 0 for any.
flags: The bitwise flags altering the function's behaviour.

Does not return police cars or helicopters.

It seems to return police cars for me, does not seem to return helicopters, planes or boats for some reason

Only returns non police cars and motorbikes with the flag set to 70 and modelHash to 0. ModelHash seems to always be 0 when not a modelHash in the scripts, as stated above. 

These flags were found in the b617d scripts: 0,2,4,6,7,23,127,260,2146,2175,12294,16384,16386,20503,32768,67590,67711,98309,100359.
Converted to binary, each bit probably represents a flag as explained regarding another native here: gtaforums.com/topic/822314-guide-driving-styles

Conversion of found flags to binary: https://pastebin.com/kghNFkRi

At exactly 16384 which is 0100000000000000 in binary and 4000 in hexadecimal only planes are returned. 

It's probably more convenient to use worldGetAllVehicles(int *arr, int arrSize) and check the shortest distance yourself and sort if you want by checking the vehicle type with for example VEHICLE::IS_THIS_MODEL_A_BOAT

-------------------------------------------------------------------------

Conclusion: This native is not worth trying to use. Use something like this instead: https://pastebin.com/xiFdXa7h

Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
```

---

### GET_CONVERTIBLE_ROOF_STATE

- **命名空间:** `VEHICLE`
- **Hash:** `0xF8C397922FC03F41`
- **JHash:** `0x1B09714D`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_CONVERTIBLE_ROOF_STATE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
0 -> up
1 -> lowering down
2 -> down
3 -> raising up
```

---

### GET_CURRENT_PLAYBACK_FOR_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x42BC05C27A946054`
- **JHash:** `0xA3F44390`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_CURRENT_PLAYBACK_FOR_VEHICLE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_DISPLAY_NAME_FROM_VEHICLE_MODEL

- **命名空间:** `VEHICLE`
- **Hash:** `0xB215AAC32D25D019`
- **JHash:** `0xEC86DF39`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_DISPLAY_NAME_FROM_VEHICLE_MODEL(uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Returns model name of vehicle in all caps. Needs to be displayed through localizing text natives to get proper display name.
-----------------------------------------------------------------------------------------------------------------------------------------
While often the case, this does not simply return the model name of the vehicle (which could be hashed to return the model hash). Variations of the same vehicle may also use the same display name.
-----------------------------------------------------------------------------------------------------------------------------------------

Returns "CARNOTFOUND" if the hash doesn't match a vehicle hash.

Using HUD::GET_FILENAME_FOR_AUDIO_CONVERSATION, you can get the localized name.

Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
```

---

### GET_DOES_VEHICLE_HAVE_DAMAGE_DECALS

- **命名空间:** `VEHICLE`
- **Hash:** `0xBCDC5017D3CE1E9E`
- **JHash:** `0xDAC523BC`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_DOES_VEHICLE_HAVE_DAMAGE_DECALS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Appears to return true if the vehicle has any damage, including cosmetically.
```

---

### GET_DOES_VEHICLE_HAVE_TOMBSTONE

- **命名空间:** `VEHICLE`
- **Hash:** `0x71AFB258CCED3A27`
- **Build:** `1604`

**C# 签名:**
```csharp
bool GET_DOES_VEHICLE_HAVE_TOMBSTONE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true only if the "tombstone" bone is attached to the vehicle, irrespective of "FLAG_HAS_TOMBSTONE" being present or not. Detaching the tombstone will return false.
```

---

### GET_DRIFT_TYRES_SET

- **命名空间:** `VEHICLE`
- **Hash:** `0x2F5A72430E78C8D3`
- **Build:** `2372`

**C# 签名:**
```csharp
bool GET_DRIFT_TYRES_SET(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_ENTITY_ATTACHED_TO_CARGOBOB

- **命名空间:** `VEHICLE`
- **Hash:** `0x99093F60746708CA`
- **Build:** `1103`

**C# 签名:**
```csharp
int GET_ENTITY_ATTACHED_TO_CARGOBOB(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `int` (Native: `Entity`)

---

### GET_ENTITY_ATTACHED_TO_TOW_TRUCK

- **命名空间:** `VEHICLE`
- **Hash:** `0xEFEA18DCF10F8F75`
- **JHash:** `0x11EC7844`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_ENTITY_ATTACHED_TO_TOW_TRUCK(int towTruck)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `towTruck` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `Entity`)

---

### GET_ENTRY_POINT_POSITION

- **命名空间:** `VEHICLE`
- **Hash:** `0xC0572928C0ABFDA3`
- **Build:** `944`

**C# 签名:**
```csharp
Vector3 GET_ENTRY_POINT_POSITION(int vehicle, int doorId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `doorId` | `int` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
doorId: see SET_VEHICLE_DOOR_SHUT
```

---

### GET_FAKE_SUSPENSION_LOWERING_AMOUNT

- **命名空间:** `VEHICLE`
- **Hash:** `0x53952FD2BAA19F17`
- **JHash:** `0xB73A1486`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_FAKE_SUSPENSION_LOWERING_AMOUNT(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Gets the height of the vehicle's suspension.
The higher the value the lower the suspension. Each 0.002 corresponds with one more level lowered.
0.000 is the stock suspension.
0.008 is Ultra Suspension.
```

---

### GET_FLYING_VEHICLE_MODEL_AGILITY

- **命名空间:** `VEHICLE`
- **Hash:** `0xC6AD107DDC9054CC`
- **JHash:** `0x95BB67EB`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_FLYING_VEHICLE_MODEL_AGILITY(uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
```

---

### GET_HAS_RETRACTABLE_WHEELS

- **命名空间:** `VEHICLE`
- **Hash:** `0xDCA174A42133F08C`
- **Build:** `944`

**C# 签名:**
```csharp
bool GET_HAS_RETRACTABLE_WHEELS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_HAS_ROCKET_BOOST

- **命名空间:** `VEHICLE`
- **Hash:** `0x36D782F68B309BDA`
- **Build:** `944`

**C# 签名:**
```csharp
bool GET_HAS_ROCKET_BOOST(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_HAS_VEHICLE_BEEN_HIT_BY_SHUNT

- **命名空间:** `VEHICLE`
- **Hash:** `0xE8718FAF591FD224`
- **Build:** `1604`

**C# 签名:**
```csharp
bool GET_HAS_VEHICLE_BEEN_HIT_BY_SHUNT(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_HELI_MAIN_ROTOR_HEALTH

- **命名空间:** `VEHICLE`
- **Hash:** `0xE4CB7541F413D2C5`
- **JHash:** `0xF01E2AAB`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_HELI_MAIN_ROTOR_HEALTH(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Max 1000.
At 0 the main rotor will stall.
```

---

### GET_HELI_TAIL_BOOM_HEALTH

- **命名空间:** `VEHICLE`
- **Hash:** `0xAC51915D27E4A5F7`
- **JHash:** `0x8A68388F`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_HELI_TAIL_BOOM_HEALTH(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Max 1000.
At -100 both helicopter rotors will stall.
```

---

### GET_HELI_TAIL_ROTOR_HEALTH

- **命名空间:** `VEHICLE`
- **Hash:** `0xAE8CE82A4219AC8C`
- **JHash:** `0xA41BC13D`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_HELI_TAIL_ROTOR_HEALTH(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Max 1000.
At 0 the tail rotor will stall.
```

---

### GET_HYDRAULIC_SUSPENSION_RAISE_FACTOR

- **命名空间:** `VEHICLE`
- **Hash:** `0x0BB5CBDDD0F25AE3`
- **Build:** `2372`

**C# 签名:**
```csharp
float GET_HYDRAULIC_SUSPENSION_RAISE_FACTOR(int vehicle, int wheelId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `wheelId` | `int` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_IN_VEHICLE_CLIPSET_HASH_FOR_SEAT

- **命名空间:** `VEHICLE`
- **Hash:** `0xA01BC64DD4BFBBAC`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_IN_VEHICLE_CLIPSET_HASH_FOR_SEAT(int vehicle, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `uint` (Native: `Hash`)

---

### GET_IS_BOAT_CAPSIZED

- **命名空间:** `VEHICLE`
- **Hash:** `0xBA91D045575699AD`
- **Build:** `877`

**C# 签名:**
```csharp
bool GET_IS_BOAT_CAPSIZED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_IS_DOOR_VALID

- **命名空间:** `VEHICLE`
- **Hash:** `0x645F4B6E8499F632`
- **Build:** `944`

**C# 签名:**
```csharp
bool GET_IS_DOOR_VALID(int vehicle, int doorId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `doorId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
doorId: see SET_VEHICLE_DOOR_SHUT
```

---

### GET_IS_LEFT_VEHICLE_HEADLIGHT_DAMAGED

- **命名空间:** `VEHICLE`
- **Hash:** `0x5EF77C9ADD3B11A3`
- **JHash:** `0xA0777943`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_IS_LEFT_VEHICLE_HEADLIGHT_DAMAGED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
From the driver's perspective, is the left headlight broken.
```

---

### GET_IS_RIGHT_VEHICLE_HEADLIGHT_DAMAGED

- **命名空间:** `VEHICLE`
- **Hash:** `0xA7ECB73355EB2F20`
- **JHash:** `0xF178390B`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_IS_RIGHT_VEHICLE_HEADLIGHT_DAMAGED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
From the driver's perspective, is the right headlight broken.
```

---

### GET_IS_VEHICLE_DISABLED_BY_EMP

- **命名空间:** `VEHICLE`
- **Hash:** `0x0506ED94363AD905`
- **Build:** `1604`

**C# 签名:**
```csharp
bool GET_IS_VEHICLE_DISABLED_BY_EMP(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns whether this vehicle is currently disabled by an EMP mine.
```

---

### GET_IS_VEHICLE_ENGINE_RUNNING

- **命名空间:** `VEHICLE`
- **Hash:** `0xAE31E7DF9B5B132E`
- **JHash:** `0x7DC6D022`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_IS_VEHICLE_ENGINE_RUNNING(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true when in a vehicle, false whilst entering/exiting.
```

---

### GET_IS_VEHICLE_PRIMARY_COLOUR_CUSTOM

- **命名空间:** `VEHICLE`
- **Hash:** `0xF095C0405307B21B`
- **JHash:** `0xD7EC8760`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_IS_VEHICLE_PRIMARY_COLOUR_CUSTOM(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_IS_VEHICLE_SECONDARY_COLOUR_CUSTOM

- **命名空间:** `VEHICLE`
- **Hash:** `0x910A32E7AAD2656C`
- **JHash:** `0x288AD228`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_IS_VEHICLE_SECONDARY_COLOUR_CUSTOM(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Check if Vehicle Secondary is avaliable for customize
```

---

### GET_IS_VEHICLE_SHUNTING

- **命名空间:** `VEHICLE`
- **Hash:** `0xA2459F72C14E2E8D`
- **Build:** `1604`

**C# 签名:**
```csharp
bool GET_IS_VEHICLE_SHUNTING(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_IS_WHEELS_RETRACTED

- **命名空间:** `VEHICLE`
- **Hash:** `0x1DA0DA9CB3F0C8BF`
- **Build:** `944`

**C# 签名:**
```csharp
bool GET_IS_WHEELS_RETRACTED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_LANDING_GEAR_STATE

- **命名空间:** `VEHICLE`
- **Hash:** `0x9B0F3DCA3DB0F4CD`
- **JHash:** `0xA6F02670`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_LANDING_GEAR_STATE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Landing gear states:

0: Deployed
1: Closing (Retracting)
2: (Landing gear state 2 is never used.)
3: Opening (Deploying)
4: Retracted

Returns the current state of the vehicles landing gear.
```

---

### GET_LAST_DRIVEN_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0xB2D06FAEDE65B577`
- **JHash:** `0xFEB0C0C8`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_LAST_DRIVEN_VEHICLE()
```

**返回值:** `int` (Native: `Vehicle`)

---

### GET_LAST_PED_IN_VEHICLE_SEAT

- **命名空间:** `VEHICLE`
- **Hash:** `0x83F969AA1EE2A664`
- **JHash:** `0xF7C6792D`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_LAST_PED_IN_VEHICLE_SEAT(int vehicle, int seatIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `seatIndex` | `int` | `int` | - |

**返回值:** `int` (Native: `Ped`)

---

### GET_LAST_SHUNT_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x04F2FA6E234162F7`
- **Build:** `1604`

**C# 签名:**
```csharp
int GET_LAST_SHUNT_VEHICLE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `Vehicle`)

**说明:**
```
Returns last vehicle that was rammed by the given vehicle using the shunt boost.
```

---

### GET_LIVERY_NAME

- **命名空间:** `VEHICLE`
- **Hash:** `0xB4C7A93837C91A1F`
- **JHash:** `0xED80B5BE`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_LIVERY_NAME(int vehicle, int liveryIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `liveryIndex` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Returns the text label of the vehicle's liveryIndex, as specified by the liveryNames section of the vehicle's modkit data in the carcols file.

example 

int count = VEHICLE::GET_VEHICLE_LIVERY_COUNT(veh);
for (int i = 0; i < count; i++)  
  {
     const char* LiveryName = VEHICLE::GET_LIVERY_NAME(veh, i);
  }


this example will work fine to fetch all names 
for example for Sanchez we get 

SANC_LV1
SANC_LV2
SANC_LV3
SANC_LV4
SANC_LV5


Use GET_FILENAME_FOR_AUDIO_CONVERSATION, to get the localized livery name.

Full list of vehicle mod kits and mods by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicleModKits.json
```

---

### GET_MAKE_NAME_FROM_VEHICLE_MODEL

- **命名空间:** `VEHICLE`
- **Hash:** `0xF7AF4F159FF99F97`
- **Build:** `1868`

**C# 签名:**
```csharp
string GET_MAKE_NAME_FROM_VEHICLE_MODEL(uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Will return a vehicle's manufacturer display label.
Returns "CARNOTFOUND" if the hash doesn't match a vehicle hash.

Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
```

---

### GET_MOD_SLOT_NAME

- **命名空间:** `VEHICLE`
- **Hash:** `0x51F0FEB9F6AE98C0`
- **JHash:** `0x5E113483`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_MOD_SLOT_NAME(int vehicle, int modType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `modType` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Returns the name for the type of vehicle mod(Armour, engine etc)

```

---

### GET_MOD_TEXT_LABEL

- **命名空间:** `VEHICLE`
- **Hash:** `0x8935624F8C5592CC`
- **JHash:** `0x0BA39CA7`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_MOD_TEXT_LABEL(int vehicle, int modType, int modValue)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `modType` | `int` | `int` | - |
| `modValue` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Returns the text label of a mod type for a given vehicle

Use GET_FILENAME_FOR_AUDIO_CONVERSATION to get the part name in the game's language
```

---

### GET_NUMBER_OF_VEHICLE_COLOURS

- **命名空间:** `VEHICLE`
- **Hash:** `0x3B963160CD65D41E`
- **JHash:** `0xF2442EE2`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUMBER_OF_VEHICLE_COLOURS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns the total amount of color combinations found in the vehicle's carvariations.meta entry.
```

---

### GET_NUMBER_OF_VEHICLE_DOORS

- **命名空间:** `VEHICLE`
- **Hash:** `0x92922A607497B14D`
- **Build:** `463`

**C# 签名:**
```csharp
int GET_NUMBER_OF_VEHICLE_DOORS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_NUMBER_OF_VEHICLE_NUMBER_PLATES

- **命名空间:** `VEHICLE`
- **Hash:** `0x4C4D6B2644F458CB`
- **JHash:** `0xD24BC1AE`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUMBER_OF_VEHICLE_NUMBER_PLATES()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns the number of *types* of licence plates, enumerated below in SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX.
```

---

### GET_NUM_MOD_COLORS

- **命名空间:** `VEHICLE`
- **Hash:** `0xA551BE18C11A476D`
- **JHash:** `0x73722CD9`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUM_MOD_COLORS(int paintType, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `paintType` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
paintType:
0: Normal
1: Metallic
2: Pearl
3: Matte
4: Metal
5: Chrome
6: Chameleon
```

---

### GET_NUM_MOD_KITS

- **命名空间:** `VEHICLE`
- **Hash:** `0x33F2E3FE70EAAE1D`
- **JHash:** `0xE4903AA0`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUM_MOD_KITS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_NUM_VEHICLE_MODS

- **命名空间:** `VEHICLE`
- **Hash:** `0xE38E9162A2500646`
- **JHash:** `0x8A814FF9`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUM_VEHICLE_MODS(int vehicle, int modType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `modType` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns how many possible mods a vehicle has for a given mod type
```

---

### GET_NUM_VEHICLE_WINDOW_TINTS

- **命名空间:** `VEHICLE`
- **Hash:** `0x9D1224004B3A6707`
- **JHash:** `0x625C7B66`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUM_VEHICLE_WINDOW_TINTS()
```

**返回值:** `int` (Native: `int`)

---

### GET_OUTRIGGERS_DEPLOYED

- **命名空间:** `VEHICLE`
- **Hash:** `0x3A9128352EAC9E85`
- **Build:** `1290`

**C# 签名:**
```csharp
bool GET_OUTRIGGERS_DEPLOYED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Checks if Chernobog's stabilizers are deployed or not.
These are the metal supports that allow it to fire.
This native only applies to the Chernobog.
```

---

### GET_PED_IN_VEHICLE_SEAT

- **命名空间:** `VEHICLE`
- **Hash:** `0xBB40DD2270B65366`
- **JHash:** `0x388FDE9A`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_IN_VEHICLE_SEAT(int vehicle, int seatIndex, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `seatIndex` | `int` | `int` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `Ped`)

**说明:**
```
If there is no ped in the seat, and the game considers the vehicle as ambient population, this will create a random occupant ped in the seat, which may be cleaned up by the game fairly soon if not marked as script-owned mission entity.

Seat indexes:
-1 = Driver
0 = Front Right Passenger
1 = Back Left Passenger
2 = Back Right Passenger
3 = Further Back Left Passenger (vehicles > 4 seats)
4 = Further Back Right Passenger (vehicles > 4 seats)
etc.

If p2 is true it uses a different GetOccupant function.
```

---

### GET_PED_USING_VEHICLE_DOOR

- **命名空间:** `VEHICLE`
- **Hash:** `0x218297BF0CFD853B`
- **JHash:** `0x0630101F`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_USING_VEHICLE_DOOR(int vehicle, int doord)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `doord` | `int` | `int` | - |

**返回值:** `int` (Native: `Ped`)

**说明:**
```
doorId: see SET_VEHICLE_DOOR_SHUT
```

---

### GET_POSITION_IN_RECORDING

- **命名空间:** `VEHICLE`
- **Hash:** `0x2DACD605FC681475`
- **JHash:** `0x7DCD644C`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_POSITION_IN_RECORDING(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Distance traveled in the vehicles current recording.
```

---

### GET_POSITION_OF_VEHICLE_RECORDING_AT_TIME

- **命名空间:** `VEHICLE`
- **Hash:** `0xD242728AA6F0FBA2`
- **JHash:** `0x7178558D`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_POSITION_OF_VEHICLE_RECORDING_AT_TIME(int recording, float time, string script)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `recording` | `int` | `int` | - |
| `time` | `float` | `float` | - |
| `script` | `const char*` | `string` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
This native does no interpolation between pathpoints. The same position will be returned for all times up to the next pathpoint in the recording.

See REQUEST_VEHICLE_RECORDING
```

---

### GET_POSITION_OF_VEHICLE_RECORDING_ID_AT_TIME

- **命名空间:** `VEHICLE`
- **Hash:** `0x92523B76657A517D`
- **JHash:** `0xF31973BB`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_POSITION_OF_VEHICLE_RECORDING_ID_AT_TIME(int id, float time)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `id` | `int` | `int` | - |
| `time` | `float` | `float` | - |

**返回值:** `Vector3` (Native: `Vector3`)

---

### GET_RANDOM_VEHICLE_BACK_BUMPER_IN_SPHERE

- **命名空间:** `VEHICLE`
- **Hash:** `0xB50807EABE20A8DC`
- **JHash:** `0xD6343F6B`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_RANDOM_VEHICLE_BACK_BUMPER_IN_SPHERE(float p0, float p1, float p2, float p3, int p4, int p5, int p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `int` | `int` | - |
| `p5` | `int` | `int` | - |
| `p6` | `int` | `int` | - |

**返回值:** `int` (Native: `Vehicle`)

---

### GET_RANDOM_VEHICLE_FRONT_BUMPER_IN_SPHERE

- **命名空间:** `VEHICLE`
- **Hash:** `0xC5574E0AEB86BA68`
- **JHash:** `0xDCADEB66`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_RANDOM_VEHICLE_FRONT_BUMPER_IN_SPHERE(float p0, float p1, float p2, float p3, int p4, int p5, int p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `int` | `int` | - |
| `p5` | `int` | `int` | - |
| `p6` | `int` | `int` | - |

**返回值:** `int` (Native: `Vehicle`)

---

### GET_RANDOM_VEHICLE_IN_SPHERE

- **命名空间:** `VEHICLE`
- **Hash:** `0x386F6CE5BAF6091C`
- **JHash:** `0x57216D03`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_RANDOM_VEHICLE_IN_SPHERE(float x, float y, float z, float radius, uint modelHash, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `modelHash` | `Hash` | `uint` | - |
| `flags` | `int` | `int` | - |

**返回值:** `int` (Native: `Vehicle`)

**说明:**
```
Gets a random vehicle in a sphere at the specified position, of the specified radius.

x: The X-component of the position of the sphere.
y: The Y-component of the position of the sphere.
z: The Z-component of the position of the sphere.
radius: The radius of the sphere. Max is 9999.9004.
modelHash: The vehicle model to limit the selection to. Pass 0 for any model.
flags: The bitwise flags that modifies the behaviour of this function.

Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
```

---

### GET_RANDOM_VEHICLE_MODEL_IN_MEMORY

- **命名空间:** `VEHICLE`
- **Hash:** `0x055BF0AC0C34F4FD`
- **JHash:** `0xE2C45631`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_RANDOM_VEHICLE_MODEL_IN_MEMORY(bool p0, Hash* modelHash, ref int successIndicator)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `modelHash` | `Hash*` | `Hash*` | - |
| `successIndicator` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Not present in the retail version! It's just a nullsub.

p0 always true (except in one case)
successIndicator: 0 if success, -1 if failed
```

---

### GET_ROTATION_OF_VEHICLE_RECORDING_AT_TIME

- **命名空间:** `VEHICLE`
- **Hash:** `0x2058206FBE79A8AD`
- **JHash:** `0xD96DEC68`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_ROTATION_OF_VEHICLE_RECORDING_AT_TIME(int recording, float time, string script)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `recording` | `int` | `int` | - |
| `time` | `float` | `float` | - |
| `script` | `const char*` | `string` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
This native does no interpolation between pathpoints. The same rotation will be returned for all times up to the next pathpoint in the recording.

See REQUEST_VEHICLE_RECORDING
```

---

### GET_ROTATION_OF_VEHICLE_RECORDING_ID_AT_TIME

- **命名空间:** `VEHICLE`
- **Hash:** `0xF0F2103EFAF8CBA7`
- **JHash:** `0x4D1C15C2`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_ROTATION_OF_VEHICLE_RECORDING_ID_AT_TIME(int id, float time)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `id` | `int` | `int` | - |
| `time` | `float` | `float` | - |

**返回值:** `Vector3` (Native: `Vector3`)

---

### GET_SUBMARINE_IS_UNDER_DESIGN_DEPTH

- **命名空间:** `VEHICLE`
- **Hash:** `0x3E71D0B300B7AA79`
- **Build:** `2189`

**C# 签名:**
```csharp
bool GET_SUBMARINE_IS_UNDER_DESIGN_DEPTH(int submarine)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `submarine` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_SUBMARINE_NUMBER_OF_AIR_LEAKS

- **命名空间:** `VEHICLE`
- **Hash:** `0x093D6DDCA5B8FBAE`
- **Build:** `2189`

**C# 签名:**
```csharp
int GET_SUBMARINE_NUMBER_OF_AIR_LEAKS(int submarine)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `submarine` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_TIME_POSITION_IN_RECORDING

- **命名空间:** `VEHICLE`
- **Hash:** `0x5746F3A7AB7FE544`
- **JHash:** `0xF8C3E4A2`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_TIME_POSITION_IN_RECORDING(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Can be used with GET_TOTAL_DURATION_OF_VEHICLE_RECORDING{_ID} to compute a percentage.
```

---

### GET_TOTAL_DURATION_OF_VEHICLE_RECORDING

- **命名空间:** `VEHICLE`
- **Hash:** `0x0E48D1C262390950`
- **JHash:** `0x5B35EEB7`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_TOTAL_DURATION_OF_VEHICLE_RECORDING(int recording, string script)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `recording` | `int` | `int` | - |
| `script` | `const char*` | `string` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
See REQUEST_VEHICLE_RECORDING
```

---

### GET_TOTAL_DURATION_OF_VEHICLE_RECORDING_ID

- **命名空间:** `VEHICLE`
- **Hash:** `0x102D125411A7B6E6`
- **JHash:** `0x7116785E`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_TOTAL_DURATION_OF_VEHICLE_RECORDING_ID(int id)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `id` | `int` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_TRAIN_CARRIAGE

- **命名空间:** `VEHICLE`
- **Hash:** `0x08AAFD0814722BC3`
- **JHash:** `0x2544E7A6`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_TRAIN_CARRIAGE(int train, int trailerNumber)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `train` | `Vehicle` | `int` | - |
| `trailerNumber` | `int` | `int` | - |

**返回值:** `int` (Native: `Vehicle`)

**说明:**
```
Corrected p1. it's basically the 'carriage/trailer number'. So if the train has 3 trailers you'd call the native once with a var or 3 times with 1, 2, 3.
```

---

### GET_TYRE_HEALTH

- **命名空间:** `VEHICLE`
- **Hash:** `0x55EAB010FAEE9380`
- **Build:** `1868`

**C# 签名:**
```csharp
float GET_TYRE_HEALTH(int vehicle, int wheelIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `wheelIndex` | `int` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Usable wheels:
0: wheel_lf
1: wheel_rf
2: wheel_lm1
3: wheel_rm1
4: wheel_lr
5: wheel_rr
```

---

### GET_TYRE_WEAR_RATE

- **命名空间:** `VEHICLE`
- **Hash:** `0x6E387895952F4F71`
- **Build:** `2060`

**C# 签名:**
```csharp
float GET_TYRE_WEAR_RATE(int vehicle, int wheelIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `wheelIndex` | `int` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Returns the multiplier value from SET_TYRE_WEAR_RATE

Usable wheels:
0: wheel_lf
1: wheel_rf
2: wheel_lm1
3: wheel_rm1
4: wheel_lr
5: wheel_rr
```

---

### GET_VEHICLE_ACCELERATION

- **命名空间:** `VEHICLE`
- **Hash:** `0x5DD35C8D074E57AE`
- **JHash:** `0x00478321`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_ACCELERATION(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
static - max acceleration
```

---

### GET_VEHICLE_ATTACHED_TO_CARGOBOB

- **命名空间:** `VEHICLE`
- **Hash:** `0x873B82D42AC2B9E5`
- **JHash:** `0x301A1D24`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_ATTACHED_TO_CARGOBOB(int cargobob)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cargobob` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `Vehicle`)

**说明:**
```
Returns attached vehicle (Vehicle in parameter must be cargobob)
```

---

### GET_VEHICLE_BODY_HEALTH

- **命名空间:** `VEHICLE`
- **Hash:** `0xF271147EB7B40F12`
- **JHash:** `0x2B2FCC28`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_BODY_HEALTH(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Seems related to vehicle health, like the one in IV.
Max 1000, min 0.
Vehicle does not necessarily explode or become undrivable at 0.
```

---

### GET_VEHICLE_BOMB_AMMO

- **命名空间:** `VEHICLE`
- **Hash:** `0xEA12BD130D7569A1`
- **Build:** `1180`

**C# 签名:**
```csharp
int GET_VEHICLE_BOMB_AMMO(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Gets the amount of bombs that this vehicle has. As far as I know, this does _not_ impact vehicle weapons or the ammo of those weapons in any way, it is just a way to keep track of the amount of bombs in a specific plane.
```

---

### GET_VEHICLE_CAN_DEPLOY_PARACHUTE

- **命名空间:** `VEHICLE`
- **Hash:** `0xA916396DF4154EE3`
- **Build:** `944`

**C# 签名:**
```csharp
bool GET_VEHICLE_CAN_DEPLOY_PARACHUTE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_VEHICLE_CAUSE_OF_DESTRUCTION

- **命名空间:** `VEHICLE`
- **Hash:** `0xE495D1EF4C91FD20`
- **JHash:** `0x7F8C20DD`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_VEHICLE_CAUSE_OF_DESTRUCTION(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `uint` (Native: `Hash`)

**说明:**
```
iVar3 = get_vehicle_cause_of_destruction(uLocal_248[iVar2]);
if (iVar3 == joaat("weapon_stickybomb"))
{
	func_171(726);
	iLocal_260 = 1;
}
```

---

### GET_VEHICLE_CLASS

- **命名空间:** `VEHICLE`
- **Hash:** `0x29439776AAA00A62`
- **JHash:** `0xC025338E`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_CLASS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns an int

Vehicle Classes:
0: Compacts
1: Sedans
2: SUVs
3: Coupes
4: Muscle
5: Sports Classics
6: Sports
7: Super
8: Motorcycles
9: Off-road
10: Industrial
11: Utility
12: Vans
13: Cycles
14: Boats
15: Helicopters
16: Planes
17: Service
18: Emergency
19: Military
20: Commercial
21: Trains

char buffer[128];
std::sprintf(buffer, "VEH_CLASS_%i", VEHICLE::GET_VEHICLE_CLASS(vehicle));

const char* className = HUD::GET_FILENAME_FOR_AUDIO_CONVERSATION(buffer);
```

---

### GET_VEHICLE_CLASS_ESTIMATED_MAX_SPEED

- **命名空间:** `VEHICLE`
- **Hash:** `0x00C09F246ABEDD82`
- **JHash:** `0xCE67162C`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_CLASS_ESTIMATED_MAX_SPEED(int vehicleClass)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicleClass` | `int` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_VEHICLE_CLASS_FROM_NAME

- **命名空间:** `VEHICLE`
- **Hash:** `0xDEDF1C8BD47C2200`
- **JHash:** `0xEA469980`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_CLASS_FROM_NAME(uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
char buffer[128];
std::sprintf(buffer, "VEH_CLASS_%i", VEHICLE::GET_VEHICLE_CLASS_FROM_NAME (hash));

const char* className = HUD::GET_FILENAME_FOR_AUDIO_CONVERSATION(buffer);

Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
```

---

### GET_VEHICLE_CLASS_MAX_ACCELERATION

- **命名空间:** `VEHICLE`
- **Hash:** `0x2F83E7E45D9EA7AE`
- **JHash:** `0x3E220A9B`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_CLASS_MAX_ACCELERATION(int vehicleClass)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicleClass` | `int` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_VEHICLE_CLASS_MAX_AGILITY

- **命名空间:** `VEHICLE`
- **Hash:** `0x4F930AD022D6DE3B`
- **JHash:** `0x45F2BD83`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_CLASS_MAX_AGILITY(int vehicleClass)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicleClass` | `int` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_VEHICLE_CLASS_MAX_BRAKING

- **命名空间:** `VEHICLE`
- **Hash:** `0x4BF54C16EC8FEC03`
- **JHash:** `0xD08CC1A5`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_CLASS_MAX_BRAKING(int vehicleClass)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicleClass` | `int` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_VEHICLE_CLASS_MAX_TRACTION

- **命名空间:** `VEHICLE`
- **Hash:** `0xDBC86D85C5059461`
- **JHash:** `0x5B4FDC16`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_CLASS_MAX_TRACTION(int vehicleClass)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicleClass` | `int` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_VEHICLE_COLOR

- **命名空间:** `VEHICLE`
- **Hash:** `0xF3CC740D36221548`
- **JHash:** `0x03BC8F1B`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_VEHICLE_COLOR(int vehicle, ref int r, ref int g, ref int b)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `r` | `int*` | `ref int` | - |
| `g` | `int*` | `ref int` | - |
| `b` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
What's this for? Primary and Secondary RGB have their own natives and this one doesn't seem specific.
```

---

### GET_VEHICLE_COLOURS

- **命名空间:** `VEHICLE`
- **Hash:** `0xA19435F193E081AC`
- **JHash:** `0x40D82D88`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_VEHICLE_COLOURS(int vehicle, ref int colorPrimary, ref int colorSecondary)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `colorPrimary` | `int*` | `ref int` | - |
| `colorSecondary` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

---

### GET_VEHICLE_COLOURS_WHICH_CAN_BE_SET

- **命名空间:** `VEHICLE`
- **Hash:** `0xEEBFC7A7EFDC35B4`
- **JHash:** `0x749DEEA2`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_COLOURS_WHICH_CAN_BE_SET(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Some kind of flags.
```

---

### GET_VEHICLE_COLOUR_COMBINATION

- **命名空间:** `VEHICLE`
- **Hash:** `0x6A842D197F845D56`
- **JHash:** `0x77AC1B4C`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_COLOUR_COMBINATION(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns the index of the color combination found in the vehicle's carvariations.meta entry.
```

---

### GET_VEHICLE_COUNTERMEASURE_AMMO

- **命名空间:** `VEHICLE`
- **Hash:** `0xF846AA63DF56B804`
- **Build:** `1180`

**C# 签名:**
```csharp
int GET_VEHICLE_COUNTERMEASURE_AMMO(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Similar to `GET_VEHICLE_BOMB_AMMO`, this gets the amount of countermeasures that are present on this vehicle.
Use SET_VEHICLE_COUNTERMEASURE_AMMO to set the current amount.
```

---

### GET_VEHICLE_CURRENT_TIME_IN_SLIP_STREAM

- **命名空间:** `VEHICLE`
- **Hash:** `0x36492C2F0D134C56`
- **JHash:** `0xA4A75FCF`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_CURRENT_TIME_IN_SLIP_STREAM(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Returns a float value between 0.0 and 3.0 related to its slipstream draft (boost/speedup).
```

---

### GET_VEHICLE_CUSTOM_PRIMARY_COLOUR

- **命名空间:** `VEHICLE`
- **Hash:** `0xB64CF2CCA9D95F52`
- **JHash:** `0x1C2B9FEF`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_VEHICLE_CUSTOM_PRIMARY_COLOUR(int vehicle, ref int r, ref int g, ref int b)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `r` | `int*` | `ref int` | - |
| `g` | `int*` | `ref int` | - |
| `b` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

---

### GET_VEHICLE_CUSTOM_SECONDARY_COLOUR

- **命名空间:** `VEHICLE`
- **Hash:** `0x8389CD56CA8072DC`
- **JHash:** `0x3FF247A2`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_VEHICLE_CUSTOM_SECONDARY_COLOUR(int vehicle, ref int r, ref int g, ref int b)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `r` | `int*` | `ref int` | - |
| `g` | `int*` | `ref int` | - |
| `b` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

---

### GET_VEHICLE_DEFORMATION_AT_POS

- **命名空间:** `VEHICLE`
- **Hash:** `0x4EC6CFBC7B2E9536`
- **JHash:** `0xABF02075`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_VEHICLE_DEFORMATION_AT_POS(int vehicle, float offsetX, float offsetY, float offsetZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `offsetX` | `float` | `float` | - |
| `offsetY` | `float` | `float` | - |
| `offsetZ` | `float` | `float` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
The only example I can find of this function in the scripts, is this:

struct _s = VEHICLE::GET_VEHICLE_DEFORMATION_AT_POS(rPtr((A_0) + 4), 1.21f, 6.15f, 0.3f);

-----------------------------------------------------------------------------------------------------------------------------------------
PC scripts:

v_5/*{3}*/ = VEHICLE::GET_VEHICLE_DEFORMATION_AT_POS(a_0._f1, 1.21, 6.15, 0.3);
```

---

### GET_VEHICLE_DIRT_LEVEL

- **命名空间:** `VEHICLE`
- **Hash:** `0x8F17BC8BA08DA62B`
- **JHash:** `0xFD15C065`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_DIRT_LEVEL(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Dirt level does not become greater than 15.0
```

---

### GET_VEHICLE_DOORS_LOCKED_FOR_PLAYER

- **命名空间:** `VEHICLE`
- **Hash:** `0xF6AF6CB341349015`
- **JHash:** `0x1DC50247`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_VEHICLE_DOORS_LOCKED_FOR_PLAYER(int vehicle, int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_VEHICLE_DOOR_ANGLE_RATIO

- **命名空间:** `VEHICLE`
- **Hash:** `0xFE3F9C29F7B32BD5`
- **JHash:** `0x0E399C26`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_DOOR_ANGLE_RATIO(int vehicle, int doorId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `doorId` | `int` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
doorId: see SET_VEHICLE_DOOR_SHUT
```

---

### GET_VEHICLE_DOOR_LOCK_STATUS

- **命名空间:** `VEHICLE`
- **Hash:** `0x25BC98A59C2EA962`
- **JHash:** `0x0D72CEF2`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_DOOR_LOCK_STATUS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
enum VehicleLockStatus = {
    None = 0,
    Unlocked = 1,
    Locked = 2,
    LockedForPlayer = 3,
    StickPlayerInside = 4, -- Doesn't allow players to exit the vehicle with the exit vehicle key.
    CanBeBrokenInto = 7, -- Can be broken into the car. If the glass is broken, the value will be set to 1
    CanBeBrokenIntoPersist = 8, -- Can be broken into persist
    CannotBeTriedToEnter = 10, -- Cannot be tried to enter (Nothing happens when you press the vehicle enter key).
}
```

---

### GET_VEHICLE_ENGINE_HEALTH

- **命名空间:** `VEHICLE`
- **Hash:** `0xC45D23BAF168AAB8`
- **JHash:** `0x8880038A`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_ENGINE_HEALTH(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Returns 1000.0 if the function is unable to get the address of the specified vehicle or if it's not a vehicle.

Minimum: -4000
Maximum: 1000

-4000: Engine is destroyed
0 and below: Engine catches fire and health rapidly declines
300: Engine is smoking and losing functionality
1000: Engine is perfect
```

---

### GET_VEHICLE_ENVEFF_SCALE

- **命名空间:** `VEHICLE`
- **Hash:** `0xA82819CAC9C4C403`
- **JHash:** `0xD5F1EEE1`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_ENVEFF_SCALE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
The result is a value from 0-1, where 0 is fresh paint.
```

---

### GET_VEHICLE_ESTIMATED_MAX_SPEED

- **命名空间:** `VEHICLE`
- **Hash:** `0x53AF99BAA671CA47`
- **JHash:** `0x7D1A0616`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_ESTIMATED_MAX_SPEED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_VEHICLE_EXTRA_COLOURS

- **命名空间:** `VEHICLE`
- **Hash:** `0x3BC4245933A166F7`
- **JHash:** `0x80E4659B`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_VEHICLE_EXTRA_COLOURS(int vehicle, ref int pearlescentColor, ref int wheelColor)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `pearlescentColor` | `int*` | `ref int` | - |
| `wheelColor` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

---

### GET_VEHICLE_EXTRA_COLOUR_5

- **命名空间:** `VEHICLE`
- **Hash:** `0x7D1464D472D32136`
- **Build:** `505`

**C# 签名:**
```csharp
void GET_VEHICLE_EXTRA_COLOUR_5(int vehicle, ref int color)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `color` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

---

### GET_VEHICLE_EXTRA_COLOUR_6

- **命名空间:** `VEHICLE`
- **Hash:** `0xB7635E80A5C31BFF`
- **Build:** `505`

**C# 签名:**
```csharp
void GET_VEHICLE_EXTRA_COLOUR_6(int vehicle, ref int color)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `color` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

---

### GET_VEHICLE_FLIGHT_NOZZLE_POSITION

- **命名空间:** `VEHICLE`
- **Hash:** `0xDA62027C8BDB326E`
- **JHash:** `0xAD40AD55`
- **Build:** `1180`

**C# 签名:**
```csharp
float GET_VEHICLE_FLIGHT_NOZZLE_POSITION(int plane)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `plane` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_VEHICLE_HAS_KERS

- **命名空间:** `VEHICLE`
- **Hash:** `0x50634E348C8D44EF`
- **JHash:** `0x0761E635`
- **Build:** `372`

**C# 签名:**
```csharp
bool GET_VEHICLE_HAS_KERS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if the vehicle has a HF_HAS_KERS (strHandlingFlags 0x4) handing flag set, for instance the lectro/vindicator bikes or the open wheelers.
```

---

### GET_VEHICLE_HAS_LANDING_GEAR

- **命名空间:** `VEHICLE`
- **Hash:** `0xE43701C36CAFF1A4`
- **Build:** `1180`

**C# 签名:**
```csharp
bool GET_VEHICLE_HAS_LANDING_GEAR(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_VEHICLE_HAS_PARACHUTE

- **命名空间:** `VEHICLE`
- **Hash:** `0xBC9CFF381338CB4F`
- **Build:** `944`

**C# 签名:**
```csharp
bool GET_VEHICLE_HAS_PARACHUTE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_VEHICLE_HEALTH_PERCENTAGE

- **命名空间:** `VEHICLE`
- **Hash:** `0xB8EF61207C2393A9`
- **JHash:** `0x196BA503`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_HEALTH_PERCENTAGE(int vehicle, float maxEngineHealth, float maxPetrolTankHealth, float maxBodyHealth, float maxMainRotorHealth, float maxTailRotorHealth, float maxUnkHealth)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `maxEngineHealth` | `float` | `float` | - |
| `maxPetrolTankHealth` | `float` | `float` | - |
| `maxBodyHealth` | `float` | `float` | - |
| `maxMainRotorHealth` | `float` | `float` | - |
| `maxTailRotorHealth` | `float` | `float` | - |
| `maxUnkHealth` | `float` | `float` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
0 min 100 max
starts at 100
Seams to have health zones
Front of vehicle when damaged goes from 100-50 and stops at 50.
Rear can be damaged from 100-0
Only tested with two cars.

any idea how this differs from the first one?

--
May return the vehicle health on a scale of 0.0 - 100.0 (needs to be confirmed)

example:

v_F = ENTITY::GET_ENTITY_MODEL(v_3);
if (((v_F == ${tanker}) || (v_F == ${armytanker})) || (v_F == ${tanker2})) {
    if (VEHICLE::GET_VEHICLE_HEALTH_PERCENTAGE(v_3) <= 1.0) {
        NETWORK::NETWORK_EXPLODE_VEHICLE(v_3, 1, 1, -1);
    }
}
```

---

### GET_VEHICLE_HOMING_LOCKEDONTO_STATE

- **命名空间:** `VEHICLE`
- **Hash:** `0x6EAAEFC76ACC311F`
- **Build:** `757`

**C# 签名:**
```csharp
int GET_VEHICLE_HOMING_LOCKEDONTO_STATE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### GET_VEHICLE_HOMING_LOCKON_STATE

- **命名空间:** `VEHICLE`
- **Hash:** `0xE6B0E8CFC3633BF0`
- **JHash:** `0xFBDE9FD8`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_HOMING_LOCKON_STATE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns a value depending on the lock-on state of vehicle weapons.
0: not locked on
1: locking on
2: locked on
```

---

### GET_VEHICLE_INDIVIDUAL_DOOR_LOCK_STATUS

- **命名空间:** `VEHICLE`
- **Hash:** `0xCA4AC3EAAE46EC7B`
- **Build:** `1103`

**C# 签名:**
```csharp
int GET_VEHICLE_INDIVIDUAL_DOOR_LOCK_STATUS(int vehicle, int doorId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `doorId` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns vehicle door lock state previously set with SET_VEHICLE_INDIVIDUAL_DOORS_LOCKED
```

---

### GET_VEHICLE_IS_DUMMY

- **命名空间:** `VEHICLE`
- **Hash:** `0x8533CAFDE1F0F336`
- **Build:** `505`

**C# 签名:**
```csharp
bool GET_VEHICLE_IS_DUMMY(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_VEHICLE_IS_MERCENARY

- **命名空间:** `VEHICLE`
- **Hash:** `0xD4C4642CB7F50B5D`
- **JHash:** `0x575504DE`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_VEHICLE_IS_MERCENARY(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_VEHICLE_LAYOUT_HASH

- **命名空间:** `VEHICLE`
- **Hash:** `0x28D37D4F71AC5C58`
- **JHash:** `0xE0B35187`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_VEHICLE_LAYOUT_HASH(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `uint` (Native: `Hash`)

**说明:**
```
Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
```

---

### GET_VEHICLE_LIGHTS_STATE

- **命名空间:** `VEHICLE`
- **Hash:** `0xB91B4C20085BD12F`
- **JHash:** `0x7C278621`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_VEHICLE_LIGHTS_STATE(int vehicle, ref bool lightsOn, ref bool highbeamsOn)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `lightsOn` | `BOOL*` | `ref bool` | - |
| `highbeamsOn` | `BOOL*` | `ref bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_VEHICLE_LIVERY

- **命名空间:** `VEHICLE`
- **Hash:** `0x2BB9230590DA5E8A`
- **JHash:** `0xEC82A51D`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_LIVERY(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
-1 = no livery
```

---

### GET_VEHICLE_LIVERY2

- **命名空间:** `VEHICLE`
- **Hash:** `0x60190048C0764A26`
- **Build:** `505`

**C# 签名:**
```csharp
int GET_VEHICLE_LIVERY2(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns index of the current vehicle's secondary livery. A getter for SET_VEHICLE_LIVERY2.
```

---

### GET_VEHICLE_LIVERY2_COUNT

- **命名空间:** `VEHICLE`
- **Hash:** `0x5ECB40269053C0D4`
- **Build:** `505`

**C# 签名:**
```csharp
int GET_VEHICLE_LIVERY2_COUNT(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns a number of available secondary liveries, or -1 if vehicle has no secondary liveries available.
```

---

### GET_VEHICLE_LIVERY_COUNT

- **命名空间:** `VEHICLE`
- **Hash:** `0x87B63E25A529D526`
- **JHash:** `0xFB0CA947`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_LIVERY_COUNT(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns -1 if the vehicle has no livery
```

---

### GET_VEHICLE_LOCK_ON_TARGET

- **命名空间:** `VEHICLE`
- **Hash:** `0x8F5EBAB1F260CFCE`
- **JHash:** `0x4A557117`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_VEHICLE_LOCK_ON_TARGET(int vehicle, Entity* entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `entity` | `Entity*` | `Entity*` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_VEHICLE_MAX_BRAKING

- **命名空间:** `VEHICLE`
- **Hash:** `0xAD7E85FC227197C4`
- **JHash:** `0x03B926F6`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_MAX_BRAKING(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS

- **命名空间:** `VEHICLE`
- **Hash:** `0xA7C4F2C6E744A550`
- **JHash:** `0x0A2FC08C`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_VEHICLE_MAX_TRACTION

- **命名空间:** `VEHICLE`
- **Hash:** `0xA132FB5370554DB0`
- **JHash:** `0x7E5A1587`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_MAX_TRACTION(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_VEHICLE_MOD

- **命名空间:** `VEHICLE`
- **Hash:** `0x772960298DA26FDB`
- **JHash:** `0xDC520069`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_MOD(int vehicle, int modType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `modType` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
In b944, there are 50 (0 - 49) mod types. See SET_VEHICLE_MOD for the list.

Returns -1 if the vehicle mod is stock
```

---

### GET_VEHICLE_MODEL_ACCELERATION

- **命名空间:** `VEHICLE`
- **Hash:** `0x8C044C5C84505B6A`
- **JHash:** `0x29CB3537`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_MODEL_ACCELERATION(uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Returns the acceleration of the specified model.

Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
```

---

### GET_VEHICLE_MODEL_ACCELERATION_MAX_MODS

- **命名空间:** `VEHICLE`
- **Hash:** `0x53409B5163D5B846`
- **JHash:** `0x37FBA7BC`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_MODEL_ACCELERATION_MAX_MODS(uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
9.8 * thrust if air vehicle, else 0.38 + drive force?

Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
```

---

### GET_VEHICLE_MODEL_ESTIMATED_MAX_SPEED

- **命名空间:** `VEHICLE`
- **Hash:** `0xF417C2502FFFED43`
- **JHash:** `0x8F291C4A`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_MODEL_ESTIMATED_MAX_SPEED(uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Returns max speed (without mods) of the specified vehicle model in m/s.

Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
```

---

### GET_VEHICLE_MODEL_MAX_BRAKING

- **命名空间:** `VEHICLE`
- **Hash:** `0xDC53FD41B4ED944C`
- **JHash:** `0x7EF02883`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_MODEL_MAX_BRAKING(uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Returns max braking of the specified vehicle model.

Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
```

---

### GET_VEHICLE_MODEL_MAX_BRAKING_MAX_MODS

- **命名空间:** `VEHICLE`
- **Hash:** `0xBFBA3BA79CFF7EBF`
- **JHash:** `0xF3A7293F`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_MODEL_MAX_BRAKING_MAX_MODS(uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
```

---

### GET_VEHICLE_MODEL_MAX_TRACTION

- **命名空间:** `VEHICLE`
- **Hash:** `0x539DE94D44FDFD0D`
- **JHash:** `0x7F985597`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_MODEL_MAX_TRACTION(uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Returns max traction of the specified vehicle model.

Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
```

---

### GET_VEHICLE_MODEL_NUMBER_OF_SEATS

- **命名空间:** `VEHICLE`
- **Hash:** `0x2AD93716F184EDA4`
- **JHash:** `0x838F7BF7`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_MODEL_NUMBER_OF_SEATS(uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns max number of passengers (including the driver) for the specified vehicle model.

Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
```

---

### GET_VEHICLE_MODEL_VALUE

- **命名空间:** `VEHICLE`
- **Hash:** `0x5873C14A52D74236`
- **JHash:** `0x58FEFC3D`
- **Build:** `463`

**C# 签名:**
```csharp
int GET_VEHICLE_MODEL_VALUE(uint vehicleModel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicleModel` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns `nMonetaryValue` from handling.meta for specific model.
```

---

### GET_VEHICLE_MOD_COLOR_1

- **命名空间:** `VEHICLE`
- **Hash:** `0xE8D65CA700C9A693`
- **JHash:** `0xE625510A`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_VEHICLE_MOD_COLOR_1(int vehicle, ref int paintType, ref int color, ref int pearlescentColor)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `paintType` | `int*` | `ref int` | - |
| `color` | `int*` | `ref int` | - |
| `pearlescentColor` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

---

### GET_VEHICLE_MOD_COLOR_1_NAME

- **命名空间:** `VEHICLE`
- **Hash:** `0xB45085B721EFD38C`
- **JHash:** `0x9A0840FD`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_VEHICLE_MOD_COLOR_1_NAME(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Returns a string which is the codename of the vehicle's currently selected primary color

p1 is always 0
```

---

### GET_VEHICLE_MOD_COLOR_2

- **命名空间:** `VEHICLE`
- **Hash:** `0x81592BE4E3878728`
- **JHash:** `0x9B76BB8E`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_VEHICLE_MOD_COLOR_2(int vehicle, ref int paintType, ref int color)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `paintType` | `int*` | `ref int` | - |
| `color` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

---

### GET_VEHICLE_MOD_COLOR_2_NAME

- **命名空间:** `VEHICLE`
- **Hash:** `0x4967A516ED23A5A1`
- **JHash:** `0x9BDC0B49`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_VEHICLE_MOD_COLOR_2_NAME(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Returns a string which is the codename of the vehicle's currently selected secondary color
```

---

### GET_VEHICLE_MOD_IDENTIFIER_HASH

- **命名空间:** `VEHICLE`
- **Hash:** `0x4593CF82AA179706`
- **JHash:** `0x94850968`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_VEHICLE_MOD_IDENTIFIER_HASH(int vehicle, int modType, int modIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `modType` | `int` | `int` | - |
| `modIndex` | `int` | `int` | - |

**返回值:** `uint` (Native: `Hash`)

**说明:**
```
Can be used for IS_DLC_VEHICLE_MOD and GET_DLC_VEHICLE_MOD_LOCK_HASH
```

---

### GET_VEHICLE_MOD_KIT

- **命名空间:** `VEHICLE`
- **Hash:** `0x6325D1A044AE510D`
- **JHash:** `0x9FE60927`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_MOD_KIT(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_VEHICLE_MOD_KIT_TYPE

- **命名空间:** `VEHICLE`
- **Hash:** `0xFC058F5121E54C32`
- **JHash:** `0xE5F76765`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_MOD_KIT_TYPE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_VEHICLE_MOD_MODIFIER_VALUE

- **命名空间:** `VEHICLE`
- **Hash:** `0x90A38E9838E0A8C1`
- **JHash:** `0x73AE5505`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_MOD_MODIFIER_VALUE(int vehicle, int modType, int modIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `modType` | `int` | `int` | - |
| `modIndex` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_VEHICLE_MOD_VARIATION

- **命名空间:** `VEHICLE`
- **Hash:** `0xB3924ECD70E095DC`
- **JHash:** `0xC1B92003`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_MOD_VARIATION(int vehicle, int modType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `modType` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Only used for wheels(ModType = 23/24) Returns true if the wheels are custom wheels
```

---

### GET_VEHICLE_NEON_COLOUR

- **命名空间:** `VEHICLE`
- **Hash:** `0x7619EEE8C886757F`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_VEHICLE_NEON_COLOUR(int vehicle, ref int r, ref int g, ref int b)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `r` | `int*` | `ref int` | - |
| `g` | `int*` | `ref int` | - |
| `b` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Gets the color of the neon lights of the specified vehicle.

See SET_VEHICLE_NEON_COLOUR (0x8E0A582209A62695) for more information
```

---

### GET_VEHICLE_NEON_ENABLED

- **命名空间:** `VEHICLE`
- **Hash:** `0x8C4B92553E4766A5`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_VEHICLE_NEON_ENABLED(int vehicle, int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `index` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
indices:
0 = Left
1 = Right
2 = Front
3 = Back
```

---

### GET_VEHICLE_NUMBER_OF_PASSENGERS

- **命名空间:** `VEHICLE`
- **Hash:** `0x24CB2137731FFE89`
- **JHash:** `0x1EF20849`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_NUMBER_OF_PASSENGERS(int vehicle, bool includeDriver, bool includeDeadOccupants)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `includeDriver` | `BOOL` | `bool` | - |
| `includeDeadOccupants` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Gets the number of passengers.

This native was modified in b2545 to take two additional parameters, allowing you to include the driver or exclude dead passengers.

To keep it working like before b2545, set includeDriver to false and includeDeadOccupants to true.
```

---

### GET_VEHICLE_NUMBER_PLATE_TEXT

- **命名空间:** `VEHICLE`
- **Hash:** `0x7CE1CCB9B293020E`
- **JHash:** `0xE8522D58`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_VEHICLE_NUMBER_PLATE_TEXT(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Returns the license plate text from a vehicle. 8 chars maximum.
```

---

### GET_VEHICLE_NUMBER_PLATE_TEXT_INDEX

- **命名空间:** `VEHICLE`
- **Hash:** `0xF11BC2DD9A3E7195`
- **JHash:** `0x499747B6`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_NUMBER_PLATE_TEXT_INDEX(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns the PlateType of a vehicle
      Blue_on_White_1 = 3,
      Blue_on_White_2 = 0,
      Blue_on_White_3 = 4,
      Yellow_on_Blue = 2,
       Yellow_on_Black = 1,
      North_Yankton = 5,
```

---

### GET_VEHICLE_NUM_OF_BROKEN_LOOSEN_PARTS

- **命名空间:** `VEHICLE`
- **Hash:** `0x2C8CBFE1EA5FC631`
- **JHash:** `0xABC99E21`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_NUM_OF_BROKEN_LOOSEN_PARTS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_VEHICLE_NUM_OF_BROKEN_OFF_PARTS

- **命名空间:** `VEHICLE`
- **Hash:** `0x42A4BEB35D372407`
- **JHash:** `0x8CDB0C09`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_NUM_OF_BROKEN_OFF_PARTS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Also includes some "turnOffBones" when vehicle mods are installed.
```

---

### GET_VEHICLE_PETROL_TANK_HEALTH

- **命名空间:** `VEHICLE`
- **Hash:** `0x7D5DABE888D2D074`
- **JHash:** `0xE41595CE`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_VEHICLE_PETROL_TANK_HEALTH(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
1000 is max health
Begins leaking gas at around 650 health
-999.90002441406 appears to be minimum health, although nothing special occurs
```

---

### GET_VEHICLE_PLATE_TYPE

- **命名空间:** `VEHICLE`
- **Hash:** `0x9CCC9525BF2408E0`
- **JHash:** `0x65CA9286`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_PLATE_TYPE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_VEHICLE_RECORDING_ID

- **命名空间:** `VEHICLE`
- **Hash:** `0x21543C612379DB3C`
- **JHash:** `0x328D601D`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_RECORDING_ID(int recording, string script)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `recording` | `int` | `int` | - |
| `script` | `const char*` | `string` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
See REQUEST_VEHICLE_RECORDING
```

---

### GET_VEHICLE_SIZE

- **命名空间:** `VEHICLE`
- **Hash:** `0xDF7E3EEB29642C38`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_VEHICLE_SIZE(int vehicle, ref Vector3 out1, ref Vector3 out2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `out1` | `Vector3*` | `ref Vector3` | - |
| `out2` | `Vector3*` | `ref Vector3` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Outputs 2 Vector3's.
Scripts check if out2.x - out1.x > someshit.x
Could be suspension related, as in max suspension height and min suspension height, considering the natives location.
```

---

### GET_VEHICLE_TRAILER_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x1CDD6BADC297830D`
- **JHash:** `0xAE84D758`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_VEHICLE_TRAILER_VEHICLE(int vehicle, Vehicle* trailer)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `trailer` | `Vehicle*` | `Vehicle*` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Gets the trailer of a vehicle and puts it into the trailer parameter.
```

---

### GET_VEHICLE_TYRES_CAN_BURST

- **命名空间:** `VEHICLE`
- **Hash:** `0x678B9BB8C3F58FEB`
- **JHash:** `0x4D76CD2F`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_VEHICLE_TYRES_CAN_BURST(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_VEHICLE_TYRE_SMOKE_COLOR

- **命名空间:** `VEHICLE`
- **Hash:** `0xB635392A4938B3C3`
- **JHash:** `0x75280015`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_VEHICLE_TYRE_SMOKE_COLOR(int vehicle, ref int r, ref int g, ref int b)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `r` | `int*` | `ref int` | - |
| `g` | `int*` | `ref int` | - |
| `b` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

---

### GET_VEHICLE_WEAPON_RESTRICTED_AMMO

- **命名空间:** `VEHICLE`
- **Hash:** `0x8181CE2F25CB9BB7`
- **Build:** `1011`

**C# 签名:**
```csharp
int GET_VEHICLE_WEAPON_RESTRICTED_AMMO(int vehicle, int weaponIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `weaponIndex` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_VEHICLE_WHEEL_TYPE

- **命名空间:** `VEHICLE`
- **Hash:** `0xB3ED1BFB4BE636DC`
- **JHash:** `0xDA58D7AE`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_WHEEL_TYPE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns an int

Wheel Types:
0: Sport
1: Muscle
2: Lowrider
3: SUV
4: Offroad
5: Tuner
6: Bike Wheels
7: High End
8: Benny's Originals
9: Benny's Bespoke
10: Racing
11: Street
12: Track

Tested in Los Santos Customs
```

---

### GET_VEHICLE_WINDOW_TINT

- **命名空间:** `VEHICLE`
- **Hash:** `0x0EE21293DAD47C95`
- **JHash:** `0x13D53892`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_WINDOW_TINT(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_VEHICLE_XENON_LIGHT_COLOR_INDEX

- **命名空间:** `VEHICLE`
- **Hash:** `0x3DFF319A831E0CDB`
- **Build:** `1604`

**C# 签名:**
```csharp
int GET_VEHICLE_XENON_LIGHT_COLOR_INDEX(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns the headlight color index from the vehicle. Value between 0, 12.
Use SET_VEHICLE_XENON_LIGHT_COLOR_INDEX to set the headlights color for the vehicle.
Must enable xenon headlights before it'll take affect.

Returns an int, value between 0-12 or 255 if no color is set.
```

---

### HAS_INSTANT_FILL_VEHICLE_POPULATION_FINISHED

- **命名空间:** `VEHICLE`
- **Hash:** `0x91D6DD290888CBAB`
- **JHash:** `0x71D898EF`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_INSTANT_FILL_VEHICLE_POPULATION_FINISHED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_PRELOAD_MODS_FINISHED

- **命名空间:** `VEHICLE`
- **Hash:** `0x06F43E5175EB6D96`
- **JHash:** `0xA8A0D246`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_PRELOAD_MODS_FINISHED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_VEHICLE_ASSET_LOADED

- **命名空间:** `VEHICLE`
- **Hash:** `0x1BBE0523B8DB9A21`
- **JHash:** `0x8DAAC3CB`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_VEHICLE_ASSET_LOADED(int vehicleAsset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicleAsset` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_VEHICLE_PETROLTANK_SET_ON_FIRE_BY_ENTITY

- **命名空间:** `VEHICLE`
- **Hash:** `0x5BA68A0840D546AC`
- **Build:** `463`

**C# 签名:**
```csharp
bool HAS_VEHICLE_PETROLTANK_SET_ON_FIRE_BY_ENTITY(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_VEHICLE_PHONE_EXPLOSIVE_DEVICE

- **命名空间:** `VEHICLE`
- **Hash:** `0x6ADAABD3068C5235`
- **JHash:** `0xA4E69134`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_VEHICLE_PHONE_EXPLOSIVE_DEVICE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_VEHICLE_RECORDING_BEEN_LOADED

- **命名空间:** `VEHICLE`
- **Hash:** `0x300D614A4C785FC4`
- **JHash:** `0xF52CD7F5`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_VEHICLE_RECORDING_BEEN_LOADED(int recording, string script)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `recording` | `int` | `int` | - |
| `script` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
See REQUEST_VEHICLE_RECORDING
```

---

### HAVE_VEHICLE_MODS_STREAMED_IN

- **命名空间:** `VEHICLE`
- **Hash:** `0x9A83F5F9963775EF`
- **JHash:** `0x112D637A`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAVE_VEHICLE_MODS_STREAMED_IN(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAVE_VEHICLE_REAR_DOORS_BEEN_BLOWN_OPEN_BY_STICKYBOMB

- **命名空间:** `VEHICLE`
- **Hash:** `0x6B407F2525E93644`
- **Build:** `2944`

**C# 签名:**
```csharp
bool HAVE_VEHICLE_REAR_DOORS_BEEN_BLOWN_OPEN_BY_STICKYBOMB(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HIDE_TOMBSTONE

- **命名空间:** `VEHICLE`
- **Hash:** `0xAE71FB656C600587`
- **Build:** `1604`

**C# 签名:**
```csharp
void HIDE_TOMBSTONE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Disables detachable bumber from domnator4, dominator5, dominator6, see https://gfycat.com/SecondUnluckyGosling
```

---

### INSTANTLY_FILL_VEHICLE_POPULATION

- **命名空间:** `VEHICLE`
- **Hash:** `0x48ADC8A773564670`
- **JHash:** `0x37BC6ACB`
- **Build:** `323`

**C# 签名:**
```csharp
void INSTANTLY_FILL_VEHICLE_POPULATION()
```

**返回值:** `void` (Native: `void`)

---

### IS_ANY_ENTITY_ATTACHED_TO_HANDLER_FRAME

- **命名空间:** `VEHICLE`
- **Hash:** `0x62CA17B74C435651`
- **JHash:** `0x593143B9`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ANY_ENTITY_ATTACHED_TO_HANDLER_FRAME(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ANY_PED_RAPPELLING_FROM_HELI

- **命名空间:** `VEHICLE`
- **Hash:** `0x291E373D483E7EE7`
- **JHash:** `0xD656E7E5`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ANY_PED_RAPPELLING_FROM_HELI(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ANY_VEHICLE_NEAR_POINT

- **命名空间:** `VEHICLE`
- **Hash:** `0x61E1DD6125A3EEE6`
- **JHash:** `0x2867A834`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ANY_VEHICLE_NEAR_POINT(float x, float y, float z, float radius)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_BIG_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x9F243D3919F442FE`
- **JHash:** `0x9CDBA8DE`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_BIG_VEHICLE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if MF_IS_BIG (strModelFlags 0x8) handling model flag is set.
```

---

### IS_BOAT_ANCHORED

- **命名空间:** `VEHICLE`
- **Hash:** `0xB0AD1238A709B1A2`
- **Build:** `573`

**C# 签名:**
```csharp
bool IS_BOAT_ANCHORED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_COP_VEHICLE_IN_AREA_3D

- **命名空间:** `VEHICLE`
- **Hash:** `0x7EEF65D5F153E26A`
- **JHash:** `0xFB16C6D1`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_COP_VEHICLE_IN_AREA_3D(float x1, float x2, float y1, float y2, float z1, float z2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `y2` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `z2` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Usage:

public bool isCopInRange(Vector3 Location, float Range)
        {
            return Function.Call<bool>(Hash.IS_COP_PED_IN_AREA_3D, Location.X - Range, Location.Y - Range, Location.Z - Range, Location.X + Range, Location.Y + Range, Location.Z + Range);
        }
```

---

### IS_ENTITY_ATTACHED_TO_HANDLER_FRAME

- **命名空间:** `VEHICLE`
- **Hash:** `0x57715966069157AD`
- **JHash:** `0x7FB25568`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_ATTACHED_TO_HANDLER_FRAME(int vehicle, int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTRY_POINT_FOR_SEAT_CLEAR

- **命名空间:** `VEHICLE`
- **Hash:** `0x639431E895B9AA57`
- **JHash:** `0xAB0E79EB`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTRY_POINT_FOR_SEAT_CLEAR(int ped, int vehicle, int seatIndex, bool side, bool onEnter)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `seatIndex` | `int` | `int` | - |
| `side` | `BOOL` | `bool` | - |
| `onEnter` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Check if a vehicle seat is accessible. If you park your vehicle near a wall and the ped cannot enter/exit this side, the return value toggles from true (not blocked) to false (blocked).

seatIndex  = -1 being the driver seat.
Use GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS(vehicle) - 1 for last seat index.
side = only relevant for bikes/motorcycles to check if the left (false)/right (true) side is blocked.
onEnter = check if you can enter (true) or exit (false) a vehicle.
```

---

### IS_EXTRA_BROKEN_OFF

- **命名空间:** `VEHICLE`
- **Hash:** `0x534E36D4DB9ECC5D`
- **Build:** `1493`

**C# 签名:**
```csharp
bool IS_EXTRA_BROKEN_OFF(int vehicle, int extraId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `extraId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if specified extra part is broken off. It only works for extras that can break off during collisions, non-breakable extras always return false. Also returns true if the breakable extra is toggled off through script.
```

---

### IS_HANDLER_FRAME_LINED_UP_WITH_CONTAINER

- **命名空间:** `VEHICLE`
- **Hash:** `0x89D630CF5EA96D23`
- **JHash:** `0xFBF5536A`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_HANDLER_FRAME_LINED_UP_WITH_CONTAINER(int vehicle, int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_HELI_LANDING_AREA_BLOCKED

- **命名空间:** `VEHICLE`
- **Hash:** `0x634148744F385576`
- **JHash:** `0x6346B7CC`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_HELI_LANDING_AREA_BLOCKED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_HELI_PART_BROKEN

- **命名空间:** `VEHICLE`
- **Hash:** `0xBC74B4BE25EB6C8A`
- **JHash:** `0xF4E4C439`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_HELI_PART_BROKEN(int vehicle, bool p1, bool p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_MISSION_TRAIN

- **命名空间:** `VEHICLE`
- **Hash:** `0xAD464F2E18836BFC`
- **Build:** `2372`

**C# 签名:**
```csharp
bool IS_MISSION_TRAIN(int train)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `train` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_NITROUS_ACTIVE

- **命名空间:** `VEHICLE`
- **Hash:** `0x491E822B2C464FE4`
- **Build:** `3095`

**C# 签名:**
```csharp
bool IS_NITROUS_ACTIVE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_EXCLUSIVE_DRIVER_OF_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0xB09D25E77C33EB3F`
- **Build:** `463`

**C# 签名:**
```csharp
bool IS_PED_EXCLUSIVE_DRIVER_OF_VEHICLE(int ped, int vehicle, ref int outIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `outIndex` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PLANE_LANDING_GEAR_INTACT

- **命名空间:** `VEHICLE`
- **Hash:** `0x4198AB0022B15F87`
- **JHash:** `0xBD085DCA`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLANE_LANDING_GEAR_INTACT(int plane)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `plane` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PLAYBACK_GOING_ON_FOR_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x1C8A4C2C19E68EEC`
- **JHash:** `0x61F7650D`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYBACK_GOING_ON_FOR_VEHICLE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PLAYBACK_USING_AI_GOING_ON_FOR_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0xAEA8FD591FAD4106`
- **JHash:** `0x63022C58`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYBACK_USING_AI_GOING_ON_FOR_VEHICLE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ROCKET_BOOST_ACTIVE

- **命名空间:** `VEHICLE`
- **Hash:** `0x3D34E80EED4AE3BE`
- **Build:** `944`

**C# 签名:**
```csharp
bool IS_ROCKET_BOOST_ACTIVE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SEAT_WARP_ONLY

- **命名空间:** `VEHICLE`
- **Hash:** `0xF7F203E31F96F6A1`
- **JHash:** `0x769E5CF2`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SEAT_WARP_ONLY(int vehicle, int seatIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `seatIndex` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_TAXI_LIGHT_ON

- **命名空间:** `VEHICLE`
- **Hash:** `0x7504C0F113AB50FC`
- **JHash:** `0x6FC4924A`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_TAXI_LIGHT_ON(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_THIS_MODEL_AN_AMPHIBIOUS_CAR

- **命名空间:** `VEHICLE`
- **Hash:** `0x633F6F44A537EBB6`
- **Build:** `944`

**C# 签名:**
```csharp
bool IS_THIS_MODEL_AN_AMPHIBIOUS_CAR(uint model)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `model` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_THIS_MODEL_AN_AMPHIBIOUS_QUADBIKE

- **命名空间:** `VEHICLE`
- **Hash:** `0xA1A9FC1C76A6730D`
- **Build:** `1103`

**C# 签名:**
```csharp
bool IS_THIS_MODEL_AN_AMPHIBIOUS_QUADBIKE(uint model)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `model` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_THIS_MODEL_A_BICYCLE

- **命名空间:** `VEHICLE`
- **Hash:** `0xBF94DD42F63BDED2`
- **JHash:** `0x328E6FF5`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_THIS_MODEL_A_BICYCLE(uint model)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `model` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_THIS_MODEL_A_BIKE

- **命名空间:** `VEHICLE`
- **Hash:** `0xB50C0B0CEDC6CE84`
- **JHash:** `0x7E702CDD`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_THIS_MODEL_A_BIKE(uint model)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `model` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_THIS_MODEL_A_BOAT

- **命名空间:** `VEHICLE`
- **Hash:** `0x45A9187928F4B9E3`
- **JHash:** `0x10F6085C`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_THIS_MODEL_A_BOAT(uint model)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `model` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_THIS_MODEL_A_CAR

- **命名空间:** `VEHICLE`
- **Hash:** `0x7F6DB52EEFC96DF8`
- **JHash:** `0x60E4C22F`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_THIS_MODEL_A_CAR(uint model)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `model` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
To check if the model is an amphibious car, use IS_THIS_MODEL_AN_AMPHIBIOUS_CAR.
```

---

### IS_THIS_MODEL_A_HELI

- **命名空间:** `VEHICLE`
- **Hash:** `0xDCE4334788AF94EA`
- **JHash:** `0x8AF7F568`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_THIS_MODEL_A_HELI(uint model)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `model` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_THIS_MODEL_A_JETSKI

- **命名空间:** `VEHICLE`
- **Hash:** `0x9537097412CF75FE`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_THIS_MODEL_A_JETSKI(uint model)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `model` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Checks if model is a boat, then checks for FLAG_IS_JETSKI.
```

---

### IS_THIS_MODEL_A_PLANE

- **命名空间:** `VEHICLE`
- **Hash:** `0xA0948AB42D7BA0DE`
- **JHash:** `0x3B3907BB`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_THIS_MODEL_A_PLANE(uint model)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `model` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_THIS_MODEL_A_QUADBIKE

- **命名空间:** `VEHICLE`
- **Hash:** `0x39DAC362EE65FA28`
- **JHash:** `0xC1625277`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_THIS_MODEL_A_QUADBIKE(uint model)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `model` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_THIS_MODEL_A_TRAIN

- **命名空间:** `VEHICLE`
- **Hash:** `0xAB935175B22E822B`
- **JHash:** `0xF87DCFFD`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_THIS_MODEL_A_TRAIN(uint model)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `model` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_TOGGLE_MOD_ON

- **命名空间:** `VEHICLE`
- **Hash:** `0x84B233A8C8FC8AE7`
- **JHash:** `0xF0E1689F`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_TOGGLE_MOD_ON(int vehicle, int modType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `modType` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_TURRET_SEAT

- **命名空间:** `VEHICLE`
- **Hash:** `0xE33FFA906CE74880`
- **JHash:** `0x7C43D32A`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_TURRET_SEAT(int vehicle, int seatIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `seatIndex` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_VEHICLE_ALARM_ACTIVATED

- **命名空间:** `VEHICLE`
- **Hash:** `0x4319E335B71FFF34`
- **JHash:** `0xF2630A4C`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_ALARM_ACTIVATED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_VEHICLE_ATTACHED_TO_CARGOBOB

- **命名空间:** `VEHICLE`
- **Hash:** `0xD40148F22E81A1D9`
- **JHash:** `0x5DEEC76C`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_ATTACHED_TO_CARGOBOB(int cargobob, int vehicleAttached)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cargobob` | `Vehicle` | `int` | - |
| `vehicleAttached` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_VEHICLE_ATTACHED_TO_TOW_TRUCK

- **命名空间:** `VEHICLE`
- **Hash:** `0x146DF9EC4C4B9FD4`
- **JHash:** `0x9699CFDC`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_ATTACHED_TO_TOW_TRUCK(int towTruck, int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `towTruck` | `Vehicle` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Scripts verify that towTruck is the first parameter, not the second.
```

---

### IS_VEHICLE_ATTACHED_TO_TRAILER

- **命名空间:** `VEHICLE`
- **Hash:** `0xE7CF3C4F9F489F0C`
- **JHash:** `0xE142BBCC`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_ATTACHED_TO_TRAILER(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_VEHICLE_A_CONVERTIBLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x52F357A30698BCCE`
- **JHash:** `0x6EF54490`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_A_CONVERTIBLE(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if the vehicle has a convertible roof.

p1 is false almost always. However, in launcher_carwash/carwash1/carwash2 scripts, p1 is true and is accompanied by DOES_VEHICLE_HAVE_ROOF. If p1 is true, it seems that every single vehicle will return true irrespective of being a convertible.
```

---

### IS_VEHICLE_BEING_BROUGHT_TO_HALT

- **命名空间:** `VEHICLE`
- **Hash:** `0xC69BB1D832A710EF`
- **Build:** `1493`

**C# 签名:**
```csharp
bool IS_VEHICLE_BEING_BROUGHT_TO_HALT(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if vehicle is halted by BRING_VEHICLE_TO_HALT
```

---

### IS_VEHICLE_BUMPER_BOUNCING

- **命名空间:** `VEHICLE`
- **Hash:** `0x27B926779DEB502D`
- **JHash:** `0xB3A2CC4F`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_BUMPER_BOUNCING(int vehicle, bool frontBumper)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `frontBumper` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_VEHICLE_BUMPER_BROKEN_OFF

- **命名空间:** `VEHICLE`
- **Hash:** `0x468056A6BB6F3846`
- **JHash:** `0xAF25C027`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_BUMPER_BROKEN_OFF(int vehicle, bool frontBumper)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `frontBumper` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_VEHICLE_DOOR_DAMAGED

- **命名空间:** `VEHICLE`
- **Hash:** `0xB8E181E559464527`
- **JHash:** `0x4999E3C3`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_DOOR_DAMAGED(int veh, int doorID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `veh` | `Vehicle` | `int` | - |
| `doorID` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
doorID starts at 0, not seeming to skip any numbers. Four door vehicles intuitively range from 0 to 3.
```

---

### IS_VEHICLE_DOOR_FULLY_OPEN

- **命名空间:** `VEHICLE`
- **Hash:** `0x3E933CFF7B111C22`
- **JHash:** `0xC2385B6F`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_DOOR_FULLY_OPEN(int vehicle, int doorId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `doorId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
doorId: see SET_VEHICLE_DOOR_SHUT
```

---

### IS_VEHICLE_DRIVEABLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x4C241E39B23DF959`
- **JHash:** `0x41A7267A`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_DRIVEABLE(int vehicle, bool isOnFireCheck)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `isOnFireCheck` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p1 is always 0 in the scripts.

p1 = check if vehicle is on fire
```

---

### IS_VEHICLE_EXTRA_TURNED_ON

- **命名空间:** `VEHICLE`
- **Hash:** `0xD2E6822DBFD6C8BD`
- **JHash:** `0x042098B5`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_EXTRA_TURNED_ON(int vehicle, int extraId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `extraId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_VEHICLE_HIGH_DETAIL

- **命名空间:** `VEHICLE`
- **Hash:** `0x1F25887F3C104278`
- **JHash:** `0x55D41928`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_HIGH_DETAIL(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_VEHICLE_IN_BURNOUT

- **命名空间:** `VEHICLE`
- **Hash:** `0x1297A88E081430EB`
- **JHash:** `0x6632BC12`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_IN_BURNOUT(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns whether the specified vehicle is currently in a burnout.


vb.net
Public Function isVehicleInBurnout(vh As Vehicle) As Boolean
        Return Native.Function.Call(Of Boolean)(Hash.IS_VEHICLE_IN_BURNOUT, vh)
    End Function
```

---

### IS_VEHICLE_IN_GARAGE_AREA

- **命名空间:** `VEHICLE`
- **Hash:** `0xCEE4490CD57BB3C2`
- **JHash:** `0xA90EC257`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_IN_GARAGE_AREA(string garageName, int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `garageName` | `const char*` | `string` | - |
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
garageName example "Michael - Beverly Hills"

Full list of garages by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/garages.json
```

---

### IS_VEHICLE_IN_SUBMARINE_MODE

- **命名空间:** `VEHICLE`
- **Hash:** `0xA77DC70BD689A1E5`
- **JHash:** `0xE2FF06DB`
- **Build:** `1290`

**C# 签名:**
```csharp
bool IS_VEHICLE_IN_SUBMARINE_MODE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_VEHICLE_MODEL

- **命名空间:** `VEHICLE`
- **Hash:** `0x423E8DE37D934D89`
- **JHash:** `0x013B10B6`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_MODEL(int vehicle, uint model)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `model` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_VEHICLE_MOD_GEN9_EXCLUSIVE

- **命名空间:** `VEHICLE`
- **Hash:** `0x00834EAC4A96E010`
- **Build:** `2699`

**C# 签名:**
```csharp
bool IS_VEHICLE_MOD_GEN9_EXCLUSIVE(int vehicle, int modType, int modIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `modType` | `int` | `int` | - |
| `modIndex` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true for any mod part listed in GEN9_EXCLUSIVE_ASSETS_VEHICLES_FILE.
```

---

### IS_VEHICLE_ON_ALL_WHEELS

- **命名空间:** `VEHICLE`
- **Hash:** `0xB104CD1BABF302E2`
- **JHash:** `0x10089F8E`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_ON_ALL_WHEELS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
 Public Function isVehicleOnAllWheels(vh As Vehicle) As Boolean
        Return Native.Function.Call(Of Boolean)(Hash.IS_VEHICLE_ON_ALL_WHEELS, vh)
    End Function

```

---

### IS_VEHICLE_PARACHUTE_DEPLOYED

- **命名空间:** `VEHICLE`
- **Hash:** `0x3DE51E9C80B116CF`
- **Build:** `1011`

**C# 签名:**
```csharp
bool IS_VEHICLE_PARACHUTE_DEPLOYED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_VEHICLE_PRODUCING_SLIP_STREAM

- **命名空间:** `VEHICLE`
- **Hash:** `0x48C633E94A8142A7`
- **Build:** `877`

**C# 签名:**
```csharp
bool IS_VEHICLE_PRODUCING_SLIP_STREAM(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if the vehicle is being slipstreamed by another vehicle
```

---

### IS_VEHICLE_SEARCHLIGHT_ON

- **命名空间:** `VEHICLE`
- **Hash:** `0xC0F97FCE55094987`
- **JHash:** `0xADAF3513`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_SEARCHLIGHT_ON(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Possibly: Returns whether the searchlight (found on police vehicles) is toggled on.

@Author Nac
```

---

### IS_VEHICLE_SEAT_FREE

- **命名空间:** `VEHICLE`
- **Hash:** `0x22AC59A870E6A669`
- **JHash:** `0xDAF42B02`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_SEAT_FREE(int vehicle, int seatIndex, bool isTaskRunning)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `seatIndex` | `int` | `int` | - |
| `isTaskRunning` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Check if a vehicle seat is free.

seatIndex  = -1 being the driver seat.
Use GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS(vehicle) - 1 for last seat index.
isTaskRunning = on true the function returns already false while a task on the target seat is running (TASK_ENTER_VEHICLE/TASK_SHUFFLE_TO_NEXT_VEHICLE_SEAT) - on false only when a ped is finally sitting in the seat.
```

---

### IS_VEHICLE_SIREN_AUDIO_ON

- **命名空间:** `VEHICLE`
- **Hash:** `0xB5CC40FBCB586380`
- **JHash:** `0xC9458688`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_SIREN_AUDIO_ON(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_VEHICLE_SIREN_ON

- **命名空间:** `VEHICLE`
- **Hash:** `0x4C9BF537BE2634B2`
- **JHash:** `0x25EB5873`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_SIREN_ON(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_VEHICLE_SPRAYABLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x8D474C8FAEFF6CDE`
- **JHash:** `0x5EB00A6A`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_SPRAYABLE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns false if the vehicle has the FLAG_NO_RESPRAY flag set.
```

---

### IS_VEHICLE_STOLEN

- **命名空间:** `VEHICLE`
- **Hash:** `0x4AF9BD80EEBEB453`
- **JHash:** `0x20B61DDE`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_STOLEN(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Only returns true if the vehicle was marked as stolen with SET_VEHICLE_IS_STOLEN.
```

---

### IS_VEHICLE_STOPPED

- **命名空间:** `VEHICLE`
- **Hash:** `0x5721B434AD84D57A`
- **JHash:** `0x655F072C`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_STOPPED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if the vehicle's current speed is less than, or equal to 0.0025f.

For some vehicles it returns true if the current speed is <= 0.00039999999.
```

---

### IS_VEHICLE_STOPPED_AT_TRAFFIC_LIGHTS

- **命名空间:** `VEHICLE`
- **Hash:** `0x2959F696AE390A99`
- **JHash:** `0x69200FA4`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_STOPPED_AT_TRAFFIC_LIGHTS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_VEHICLE_STUCK_ON_ROOF

- **命名空间:** `VEHICLE`
- **Hash:** `0xB497F06B288DCFDF`
- **JHash:** `0x18D07C6C`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_STUCK_ON_ROOF(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_VEHICLE_STUCK_TIMER_UP

- **命名空间:** `VEHICLE`
- **Hash:** `0x679BE1DAF71DA874`
- **JHash:** `0x2FCF58C1`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_STUCK_TIMER_UP(int vehicle, int p1, int ms)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `int` | `int` | - |
| `ms` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p1 can be anywhere from 0 to 3 in the scripts.
p2 being how long in milliseconds the vehicle has been stuck
```

---

### IS_VEHICLE_TYRE_BURST

- **命名空间:** `VEHICLE`
- **Hash:** `0xBA291848A0815CA9`
- **JHash:** `0x48C80210`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_TYRE_BURST(int vehicle, int wheelID, bool completely)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `wheelID` | `int` | `int` | - |
| `completely` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
wheelID used for 4 wheelers seem to be (0, 1, 4, 5)
completely - is to check if tire completely gone from rim.

'0 = wheel_lf / bike, plane or jet front
'1 = wheel_rf
'2 = wheel_lm / in 6 wheels trailer, plane or jet is first one on left
'3 = wheel_rm / in 6 wheels trailer, plane or jet is first one on right
'4 = wheel_lr / bike rear / in 6 wheels trailer, plane or jet is last one on left
'5 = wheel_rr / in 6 wheels trailer, plane or jet is last one on right
'45 = 6 wheels trailer mid wheel left
'47 = 6 wheels trailer mid wheel right
```

---

### IS_VEHICLE_VISIBLE

- **命名空间:** `VEHICLE`
- **Hash:** `0xAA0A52D24FB98293`
- **JHash:** `0x7E0D6056`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_VISIBLE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
must be called after TRACK_VEHICLE_VISIBILITY 

it's not instant so probabilly must pass an 'update' to see correct result.
```

---

### IS_VEHICLE_WEAPON_DISABLED

- **命名空间:** `VEHICLE`
- **Hash:** `0x563B65A643ED072E`
- **Build:** `1011`

**C# 签名:**
```csharp
bool IS_VEHICLE_WEAPON_DISABLED(uint weaponHash, int vehicle, int owner)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `owner` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of weapons by DurtyFree (Search for VEHICLE_*): https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### IS_VEHICLE_WINDOW_INTACT

- **命名空间:** `VEHICLE`
- **Hash:** `0x46E571A0E20D01F1`
- **JHash:** `0xAC4EF23D`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_WINDOW_INTACT(int vehicle, int windowIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `windowIndex` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
This will return false if the window is broken, or rolled down.
Window indexes:
0 = Front Right Window
1 = Front Left Window
2 = Back Right Window
3 = Back Left Window


Those numbers go on for vehicles that have more than 4 doors with windows.
```

---

### LOCK_DOORS_WHEN_NO_LONGER_NEEDED

- **命名空间:** `VEHICLE`
- **Hash:** `0xCFD778E7904C255E`
- **JHash:** `0x3FBE904F`
- **Build:** `323`

**C# 签名:**
```csharp
void LOCK_DOORS_WHEN_NO_LONGER_NEEDED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### LOWER_CONVERTIBLE_ROOF

- **命名空间:** `VEHICLE`
- **Hash:** `0xDED51F703D0FA83D`
- **JHash:** `0xC5F72EAE`
- **Build:** `323`

**C# 签名:**
```csharp
void LOWER_CONVERTIBLE_ROOF(int vehicle, bool instantlyLower)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `instantlyLower` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### LOWER_FORKLIFT_FORKS

- **命名空间:** `VEHICLE`
- **Hash:** `0x923A293361DF44E5`
- **Build:** `2802`

**C# 签名:**
```csharp
void LOWER_FORKLIFT_FORKS(int forklift)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `forklift` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### MODIFY_VEHICLE_TOP_SPEED

- **命名空间:** `VEHICLE`
- **Hash:** `0x93A3996368C94158`
- **JHash:** `0xE943B09C`
- **Build:** `323`

**C# 签名:**
```csharp
void MODIFY_VEHICLE_TOP_SPEED(int vehicle, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_CAP_EMPTY_CROWDING_VEHICLES_REMOVAL

- **命名空间:** `VEHICLE`
- **Hash:** `0xA4A9A4C40E615885`
- **Build:** `1604`

**C# 签名:**
```csharp
void NETWORK_CAP_EMPTY_CROWDING_VEHICLES_REMOVAL(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Default:1000||This sets a value which is used when NETWORK_ENABLE_EMPTY_CROWDING_VEHICLES_REMOVAL(true) is called each frame.
```

---

### NETWORK_ENABLE_EMPTY_CROWDING_VEHICLES_REMOVAL

- **命名空间:** `VEHICLE`
- **Hash:** `0x51DB102F4A3BA5E0`
- **JHash:** `0x0B0523B0`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_ENABLE_EMPTY_CROWDING_VEHICLES_REMOVAL(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_USE_HIGH_PRECISION_TRAIN_BLENDING

- **命名空间:** `VEHICLE`
- **Hash:** `0xEC0C1D4922AF9754`
- **Build:** `2372`

**C# 签名:**
```csharp
void NETWORK_USE_HIGH_PRECISION_TRAIN_BLENDING(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Implemented only for trains.
```

---

### OPEN_BOMB_BAY_DOORS

- **命名空间:** `VEHICLE`
- **Hash:** `0x87E7F24270732CB1`
- **JHash:** `0x6574041D`
- **Build:** `323`

**C# 签名:**
```csharp
void OPEN_BOMB_BAY_DOORS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### OVERRIDE_PLANE_DAMAGE_THREHSOLD

- **命名空间:** `VEHICLE`
- **Hash:** `0x5EE5632F47AE9695`
- **Build:** `463`

**C# 签名:**
```csharp
void OVERRIDE_PLANE_DAMAGE_THREHSOLD(int vehicle, float health)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `health` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Used for helis.
```

---

### PAUSE_PLAYBACK_RECORDED_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x632A689BF42301B1`
- **JHash:** `0xCCF54912`
- **Build:** `323`

**C# 签名:**
```csharp
void PAUSE_PLAYBACK_RECORDED_VEHICLE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### POP_OFF_VEHICLE_ROOF_WITH_IMPULSE

- **命名空间:** `VEHICLE`
- **Hash:** `0xE38CB9D7D39FDBCC`
- **JHash:** `0xFDA7B6CA`
- **Build:** `323`

**C# 签名:**
```csharp
void POP_OFF_VEHICLE_ROOF_WITH_IMPULSE(int vehicle, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Pops off the "roof" bone in the direction of the specified offset from the vehicle.
```

---

### POP_OUT_VEHICLE_WINDSCREEN

- **命名空间:** `VEHICLE`
- **Hash:** `0x6D645D59FB5F5AD3`
- **JHash:** `0xCC95C96B`
- **Build:** `323`

**C# 签名:**
```csharp
void POP_OUT_VEHICLE_WINDSCREEN(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Detaches the vehicle's windscreen.
For further information, see : gtaforums.com/topic/859570-glass/#entry1068894566
```

---

### PRELOAD_VEHICLE_MOD

- **命名空间:** `VEHICLE`
- **Hash:** `0x758F49C24925568A`
- **JHash:** `0x6EA5F4A8`
- **Build:** `323`

**C# 签名:**
```csharp
void PRELOAD_VEHICLE_MOD(int vehicle, int modType, int modIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `modType` | `int` | `int` | - |
| `modIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RAISE_CONVERTIBLE_ROOF

- **命名空间:** `VEHICLE`
- **Hash:** `0x8F5FB35D7E88FC70`
- **JHash:** `0xA4E4CBA3`
- **Build:** `323`

**C# 签名:**
```csharp
void RAISE_CONVERTIBLE_ROOF(int vehicle, bool instantlyRaise)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `instantlyRaise` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### RELEASE_PRELOAD_MODS

- **命名空间:** `VEHICLE`
- **Hash:** `0x445D79F995508307`
- **JHash:** `0xD442521F`
- **Build:** `323`

**C# 签名:**
```csharp
void RELEASE_PRELOAD_MODS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_PICK_UP_ROPE_FOR_CARGOBOB

- **命名空间:** `VEHICLE`
- **Hash:** `0x9768CF648F54C804`
- **JHash:** `0xA8211EE9`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_PICK_UP_ROPE_FOR_CARGOBOB(int cargobob)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cargobob` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Retracts the hook on the cargobob.

Note: after you retract it the natives for dropping the hook no longer work
```

---

### REMOVE_ROAD_NODE_SPEED_ZONE

- **命名空间:** `VEHICLE`
- **Hash:** `0x1033371FC8E842A7`
- **JHash:** `0x0C0332A6`
- **Build:** `323`

**C# 签名:**
```csharp
bool REMOVE_ROAD_NODE_SPEED_ZONE(int speedzone)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `speedzone` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### REMOVE_VEHICLES_FROM_GENERATORS_IN_AREA

- **命名空间:** `VEHICLE`
- **Hash:** `0x46A1E1A299EC4BBA`
- **JHash:** `0x42CC15E0`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_VEHICLES_FROM_GENERATORS_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, object p6)
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

---

### REMOVE_VEHICLE_ASSET

- **命名空间:** `VEHICLE`
- **Hash:** `0xACE699C71AB9DEB5`
- **JHash:** `0x9620E9C6`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_VEHICLE_ASSET(int vehicleAsset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicleAsset` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_VEHICLE_COMBAT_AVOIDANCE_AREA

- **命名空间:** `VEHICLE`
- **Hash:** `0xE30524E1871F481D`
- **JHash:** `0xEF05F807`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_VEHICLE_COMBAT_AVOIDANCE_AREA(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_VEHICLE_HIGH_DETAIL_MODEL

- **命名空间:** `VEHICLE`
- **Hash:** `0x00689CDE5F7C6787`
- **JHash:** `0x382BE070`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_VEHICLE_HIGH_DETAIL_MODEL(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_VEHICLE_MOD

- **命名空间:** `VEHICLE`
- **Hash:** `0x92D619E420858204`
- **JHash:** `0x9CC80A43`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_VEHICLE_MOD(int vehicle, int modType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `modType` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_VEHICLE_RECORDING

- **命名空间:** `VEHICLE`
- **Hash:** `0xF1160ACCF98A3FC8`
- **JHash:** `0xD3C05B00`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_VEHICLE_RECORDING(int recording, string script)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `recording` | `int` | `int` | - |
| `script` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
See REQUEST_VEHICLE_RECORDING
```

---

### REMOVE_VEHICLE_STUCK_CHECK

- **命名空间:** `VEHICLE`
- **Hash:** `0x8386BFB614D06749`
- **JHash:** `0x81594917`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_VEHICLE_STUCK_CHECK(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_VEHICLE_UPSIDEDOWN_CHECK

- **命名空间:** `VEHICLE`
- **Hash:** `0xC53EB42A499A7E90`
- **JHash:** `0xF390BA1B`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_VEHICLE_UPSIDEDOWN_CHECK(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_VEHICLE_WINDOW

- **命名空间:** `VEHICLE`
- **Hash:** `0xA711568EEDB43069`
- **JHash:** `0xBB8104A3`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_VEHICLE_WINDOW(int vehicle, int windowIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `windowIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
windowIndex:
0 = Front Right Window
1 = Front Left Window
2 = Back Right Window
3 = Back Left Window
4 = Unknown
5 = Unknown
6 = Windscreen
7 = Rear Windscreen
```

---

### REQUEST_VEHICLE_ASSET

- **命名空间:** `VEHICLE`
- **Hash:** `0x81A15811460FAB3A`
- **JHash:** `0x902B4F06`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_VEHICLE_ASSET(uint vehicleHash, int vehicleAsset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicleHash` | `Hash` | `uint` | - |
| `vehicleAsset` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
REQUEST_VEHICLE_ASSET(GET_HASH_KEY(cargobob3), 3);

vehicle found that have asset's:
cargobob3
submersible
blazer
```

---

### REQUEST_VEHICLE_DIAL

- **命名空间:** `VEHICLE`
- **Hash:** `0xDBA3C090E3D74690`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_VEHICLE_DIAL(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REQUEST_VEHICLE_HIGH_DETAIL_MODEL

- **命名空间:** `VEHICLE`
- **Hash:** `0xA6E9FDCB2C76785E`
- **JHash:** `0x9DA21956`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_VEHICLE_HIGH_DETAIL_MODEL(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REQUEST_VEHICLE_RECORDING

- **命名空间:** `VEHICLE`
- **Hash:** `0xAF514CABE74CBF15`
- **JHash:** `0x91AFEFD9`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_VEHICLE_RECORDING(int recording, string script)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `recording` | `int` | `int` | - |
| `script` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Request the vehicle recording defined by the lowercase format string "%s%03d.yvr". For example, REQUEST_VEHICLE_RECORDING(1, "FBIs1UBER") corresponds to fbis1uber001.yvr.
For all vehicle recording/playback natives, "script" is a common prefix that usually corresponds to the script/mission the recording is used in, "recording" is its int suffix, and "id" (e.g., in native GET_TOTAL_DURATION_OF_VEHICLE_RECORDING_ID) corresponds to a unique identifier within the recording streaming module.
Note that only 24 recordings (hardcoded in multiple places) can ever active at a given time before clobbering begins.
```

---

### RESET_FORMATION_LEADER

- **命名空间:** `VEHICLE`
- **Hash:** `0xE2F53F172B45EDE1`
- **Build:** `877`

**C# 签名:**
```csharp
void RESET_FORMATION_LEADER()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Resets the effect of SET_FORMATION_LEADER
```

---

### RESET_VEHICLE_STUCK_TIMER

- **命名空间:** `VEHICLE`
- **Hash:** `0xD7591B0065AFAA7A`
- **JHash:** `0xEF2A6016`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_VEHICLE_STUCK_TIMER(int vehicle, int nullAttributes)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `nullAttributes` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
The inner function has a switch on the second parameter. It's the stuck timer index.

Here's some pseudo code I wrote for the inner function:
void __fastcall NATIVE_RESET_VEHICLE_STUCK_TIMER_INNER(CUnknown* unknownClassInVehicle, int timerIndex)
{
 switch (timerIndex)
   {
 case 0:
       unknownClassInVehicle->FirstStuckTimer = (WORD)0u;
 case 1:
       unknownClassInVehicle->SecondStuckTimer = (WORD)0u;
    case 2:
       unknownClassInVehicle->ThirdStuckTimer = (WORD)0u;
 case 3:
       unknownClassInVehicle->FourthStuckTimer = (WORD)0u;
    case 4:
       unknownClassInVehicle->FirstStuckTimer = (WORD)0u;
     unknownClassInVehicle->SecondStuckTimer = (WORD)0u;
        unknownClassInVehicle->ThirdStuckTimer = (WORD)0u;
     unknownClassInVehicle->FourthStuckTimer = (WORD)0u;
        break;
    };
}
```

---

### RESET_VEHICLE_WHEELS

- **命名空间:** `VEHICLE`
- **Hash:** `0x21D2E5662C1F6FED`
- **JHash:** `0xD5FFE779`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_VEHICLE_WHEELS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### ROLL_DOWN_WINDOW

- **命名空间:** `VEHICLE`
- **Hash:** `0x7AD9E6CE657D69E3`
- **JHash:** `0xF840134C`
- **Build:** `323`

**C# 签名:**
```csharp
void ROLL_DOWN_WINDOW(int vehicle, int windowIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `windowIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
windowIndex:
0 = Front Left Window
1 = Front Right Window
2 = Rear Left Window
3 = Rear Right Window
4 = Front Windscreen
5 = Rear Windscreen
6 = Mid Left
7 = Mid Right
8 = Invalid
```

---

### ROLL_DOWN_WINDOWS

- **命名空间:** `VEHICLE`
- **Hash:** `0x85796B0549DDE156`
- **JHash:** `0x51A16DC6`
- **Build:** `323`

**C# 签名:**
```csharp
void ROLL_DOWN_WINDOWS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Roll down all the windows of the vehicle passed through the first parameter.
```

---

### ROLL_UP_WINDOW

- **命名空间:** `VEHICLE`
- **Hash:** `0x602E548F46E24D59`
- **JHash:** `0x83B7E06A`
- **Build:** `323`

**C# 签名:**
```csharp
void ROLL_UP_WINDOW(int vehicle, int windowIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `windowIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
windowIndex:
0 = Front Left Window
1 = Front Right Window
2 = Rear Left Window
3 = Rear Right Window
4 = Front Windscreen
5 = Rear Windscreen
6 = Mid Left
7 = Mid Right
8 = Invalid
```

---

### SET_ADDITIONAL_ROTATION_FOR_RECORDED_VEHICLE_PLAYBACK

- **命名空间:** `VEHICLE`
- **Hash:** `0x5845066D8A1EA7F7`
- **JHash:** `0x943A58EB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ADDITIONAL_ROTATION_FOR_RECORDED_VEHICLE_PLAYBACK(int vehicle, float x, float y, float z, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_AIRCRAFT_IGNORE_HIGHTMAP_OPTIMISATION

- **命名空间:** `VEHICLE`
- **Hash:** `0xF8B49F5BA7F850E7`
- **Build:** `2060`

**C# 签名:**
```csharp
void SET_AIRCRAFT_IGNORE_HIGHTMAP_OPTIMISATION(int vehicle, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_AIRCRAFT_PILOT_SKILL_NOISE_SCALAR

- **命名空间:** `VEHICLE`
- **Hash:** `0xE5810AC70602F2F5`
- **JHash:** `0xB6BE07E0`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AIRCRAFT_PILOT_SKILL_NOISE_SCALAR(int vehicle, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ALLOW_RAMMING_SOOP_OR_RAMP

- **命名空间:** `VEHICLE`
- **Hash:** `0x80E3357FDEF45C21`
- **Build:** `944`

**C# 签名:**
```csharp
void SET_ALLOW_RAMMING_SOOP_OR_RAMP(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ALLOW_VEHICLE_EXPLODES_ON_CONTACT

- **命名空间:** `VEHICLE`
- **Hash:** `0x3441CAD2F2231923`
- **JHash:** `0xC306A9A3`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ALLOW_VEHICLE_EXPLODES_ON_CONTACT(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ALL_LOW_PRIORITY_VEHICLE_GENERATORS_ACTIVE

- **命名空间:** `VEHICLE`
- **Hash:** `0x608207E7A8FB787C`
- **JHash:** `0x87F767F2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ALL_LOW_PRIORITY_VEHICLE_GENERATORS_ACTIVE(bool active)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `active` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ALL_VEHICLE_GENERATORS_ACTIVE

- **命名空间:** `VEHICLE`
- **Hash:** `0x34AD89078831A4BC`
- **JHash:** `0xAB1FDD76`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ALL_VEHICLE_GENERATORS_ACTIVE()
```

**返回值:** `void` (Native: `void`)

---

### SET_ALL_VEHICLE_GENERATORS_ACTIVE_IN_AREA

- **命名空间:** `VEHICLE`
- **Hash:** `0xC12321827687FE4D`
- **JHash:** `0xB4E0E69A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ALL_VEHICLE_GENERATORS_ACTIVE_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool toggle, bool p7)
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
| `p7` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
When p6 is true, vehicle generators are active.
p7 seems to always be true in story mode scripts, but it's sometimes false in online scripts.
```

---

### SET_AMBIENT_VEHICLE_NEON_ENABLED

- **命名空间:** `VEHICLE`
- **Hash:** `0x35E0654F4BAD7971`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AMBIENT_VEHICLE_NEON_ENABLED(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_AMBIENT_VEHICLE_RANGE_MULTIPLIER_THIS_FRAME

- **命名空间:** `VEHICLE`
- **Hash:** `0x90B6DA738A9A25DA`
- **JHash:** `0xDAE2A2BE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AMBIENT_VEHICLE_RANGE_MULTIPLIER_THIS_FRAME(float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ARRIVE_DISTANCE_OVERRIDE_FOR_VEHICLE_PERSUIT_ATTACK

- **命名空间:** `VEHICLE`
- **Hash:** `0x0205F5365292D2EB`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_ARRIVE_DISTANCE_OVERRIDE_FOR_VEHICLE_PERSUIT_ATTACK(int vehicle, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_BIKE_EASY_TO_LAND

- **命名空间:** `VEHICLE`
- **Hash:** `0x73561D4425A021A2`
- **Build:** `791`

**C# 签名:**
```csharp
void SET_BIKE_EASY_TO_LAND(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
When enabled, the player won't fall off the bike when landing from large heights.
```

---

### SET_BIKE_ON_STAND

- **命名空间:** `VEHICLE`
- **Hash:** `0x9CFA4896C3A53CBB`
- **JHash:** `0x15D40761`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_BIKE_ON_STAND(int vehicle, float x, float y)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Only works on bikes, both X and Y work in the -1 - 1 range.

X forces the bike to turn left or right (-1, 1)
Y forces the bike to lean to the left or to the right (-1, 1)

Example with X -1/Y 1
http://i.imgur.com/TgIuAPJ.jpg
```

---

### SET_BOAT_ANCHOR

- **命名空间:** `VEHICLE`
- **Hash:** `0x75DBEC174AEEAD10`
- **JHash:** `0xA3906284`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_BOAT_ANCHOR(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_BOAT_DISABLE_AVOIDANCE

- **命名空间:** `VEHICLE`
- **Hash:** `0x0A6A279F3AA4FD70`
- **JHash:** `0x4C0E4031`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_BOAT_DISABLE_AVOIDANCE(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_BOAT_IGNORE_LAND_PROBES

- **命名空间:** `VEHICLE`
- **Hash:** `0xED5EDE9E676643C9`
- **Build:** `944`

**C# 签名:**
```csharp
void SET_BOAT_IGNORE_LAND_PROBES(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_BOAT_LOW_LOD_ANCHOR_DISTANCE

- **命名空间:** `VEHICLE`
- **Hash:** `0xE842A9398079BD82`
- **JHash:** `0x66FA450C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_BOAT_LOW_LOD_ANCHOR_DISTANCE(int vehicle, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_BOAT_REMAINS_ANCHORED_WHILE_PLAYER_IS_DRIVER

- **命名空间:** `VEHICLE`
- **Hash:** `0xE3EBAAE484798530`
- **JHash:** `0x0ED84792`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_BOAT_REMAINS_ANCHORED_WHILE_PLAYER_IS_DRIVER(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_BOAT_SINKS_WHEN_WRECKED

- **命名空间:** `VEHICLE`
- **Hash:** `0x8F719973E1445BA2`
- **JHash:** `0x35614622`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_BOAT_SINKS_WHEN_WRECKED(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_BOAT_WRECKED

- **命名空间:** `VEHICLE`
- **Hash:** `0xBD32E46AA95C1DD2`
- **Build:** `757`

**C# 签名:**
```csharp
void SET_BOAT_WRECKED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAN_ADJUST_GROUND_CLEARANCE

- **命名空间:** `VEHICLE`
- **Hash:** `0xA7DCDF4DED40A8F4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAN_ADJUST_GROUND_CLEARANCE(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAN_RESPRAY_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x52BBA29D5EC69356`
- **JHash:** `0x37677590`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAN_RESPRAY_VEHICLE(int vehicle, bool state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `state` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Hardcoded to not work in multiplayer.
```

---

### SET_CAN_USE_HYDRAULICS

- **命名空间:** `VEHICLE`
- **Hash:** `0x1201E8A3290A3B98`
- **Build:** `505`

**C# 签名:**
```csharp
void SET_CAN_USE_HYDRAULICS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CARGOBOB_EXCLUDE_FROM_PICKUP_ENTITY

- **命名空间:** `VEHICLE`
- **Hash:** `0x1F34B0626C594380`
- **Build:** `757`

**C# 签名:**
```csharp
void SET_CARGOBOB_EXCLUDE_FROM_PICKUP_ENTITY(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CARGOBOB_EXTA_PICKUP_RANGE

- **命名空间:** `VEHICLE`
- **Hash:** `0x72BECCF4B829522E`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_CARGOBOB_EXTA_PICKUP_RANGE(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CARGOBOB_FORCE_DONT_DETACH_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x571FEB383F629926`
- **JHash:** `0x49949FDA`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CARGOBOB_FORCE_DONT_DETACH_VEHICLE(int cargobob, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cargobob` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Stops cargobob from being able to detach the attached vehicle.
```

---

### SET_CARGOBOB_PICKUP_MAGNET_ACTIVE

- **命名空间:** `VEHICLE`
- **Hash:** `0x9A665550F8DA349B`
- **JHash:** `0xF57066DA`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CARGOBOB_PICKUP_MAGNET_ACTIVE(int cargobob, bool isActive)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cargobob` | `Vehicle` | `int` | - |
| `isActive` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Won't attract or magnetize to any helicopters or planes of course, but that's common sense.
```

---

### SET_CARGOBOB_PICKUP_MAGNET_ENSURE_PICKUP_ENTITY_UPRIGHT

- **命名空间:** `VEHICLE`
- **Hash:** `0x56EB5E94318D3FB6`
- **JHash:** `0x30F43FE3`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CARGOBOB_PICKUP_MAGNET_ENSURE_PICKUP_ENTITY_UPRIGHT(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CARGOBOB_PICKUP_MAGNET_FALLOFF

- **命名空间:** `VEHICLE`
- **Hash:** `0xA17BAD153B51547E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CARGOBOB_PICKUP_MAGNET_FALLOFF(int cargobob, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cargobob` | `Vehicle` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CARGOBOB_PICKUP_MAGNET_PULL_ROPE_LENGTH

- **命名空间:** `VEHICLE`
- **Hash:** `0x685D5561680D088B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CARGOBOB_PICKUP_MAGNET_PULL_ROPE_LENGTH(int vehicle, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CARGOBOB_PICKUP_MAGNET_PULL_STRENGTH

- **命名空间:** `VEHICLE`
- **Hash:** `0xED8286F71A819BAA`
- **JHash:** `0x8191BC1A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CARGOBOB_PICKUP_MAGNET_PULL_STRENGTH(int cargobob, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cargobob` | `Vehicle` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CARGOBOB_PICKUP_MAGNET_REDUCED_FALLOFF

- **命名空间:** `VEHICLE`
- **Hash:** `0x6D8EAC07506291FB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CARGOBOB_PICKUP_MAGNET_REDUCED_FALLOFF(int cargobob, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cargobob` | `Vehicle` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CARGOBOB_PICKUP_MAGNET_REDUCED_STRENGTH

- **命名空间:** `VEHICLE`
- **Hash:** `0x66979ACF5102FD2F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CARGOBOB_PICKUP_MAGNET_REDUCED_STRENGTH(int cargobob, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cargobob` | `Vehicle` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CARGOBOB_PICKUP_MAGNET_SET_AMBIENT_MODE

- **命名空间:** `VEHICLE`
- **Hash:** `0x9BDDC73CC6A115D4`
- **JHash:** `0x50CDB295`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CARGOBOB_PICKUP_MAGNET_SET_AMBIENT_MODE(int vehicle, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CARGOBOB_PICKUP_MAGNET_SET_TARGETED_MODE

- **命名空间:** `VEHICLE`
- **Hash:** `0xE301BD63E9E13CF0`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CARGOBOB_PICKUP_MAGNET_SET_TARGETED_MODE(int vehicle, int cargobob)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `cargobob` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CARGOBOB_PICKUP_MAGNET_STRENGTH

- **命名空间:** `VEHICLE`
- **Hash:** `0xBCBFCD9D1DAC19E2`
- **JHash:** `0xCC3CF97D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CARGOBOB_PICKUP_MAGNET_STRENGTH(int cargobob, float strength)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cargobob` | `Vehicle` | `int` | - |
| `strength` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CARGOBOB_PICKUP_ROPE_DAMPING_MULTIPLIER

- **命名空间:** `VEHICLE`
- **Hash:** `0xCF1182F682F65307`
- **JHash:** `0x7D927E1B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CARGOBOB_PICKUP_ROPE_DAMPING_MULTIPLIER(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CARGOBOB_PICKUP_ROPE_TYPE

- **命名空间:** `VEHICLE`
- **Hash:** `0x0D5F65A8F4EBDAB5`
- **JHash:** `0xF258ADA1`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_CARGOBOB_PICKUP_ROPE_TYPE(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CARJACK_MISSION_REMOVAL_PARAMETERS

- **命名空间:** `VEHICLE`
- **Hash:** `0xB9562064627FF9DB`
- **Build:** `573`

**C# 签名:**
```csharp
void SET_CARJACK_MISSION_REMOVAL_PARAMETERS(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAR_BOOT_OPEN

- **命名空间:** `VEHICLE`
- **Hash:** `0xFC40CBF7B90CA77C`
- **Build:** `877`

**C# 签名:**
```csharp
void SET_CAR_BOOT_OPEN(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Initially used in Max Payne 3, that's why we know the name.
```

---

### SET_CAR_HIGH_SPEED_BUMP_SEVERITY_MULTIPLIER

- **命名空间:** `VEHICLE`
- **Hash:** `0x84FD40F56075E816`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAR_HIGH_SPEED_BUMP_SEVERITY_MULTIPLIER(float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CHECK_FOR_ENOUGH_ROOM_FOR_PED

- **命名空间:** `VEHICLE`
- **Hash:** `0xEF9D388F8D377F44`
- **Build:** `2699`

**C# 签名:**
```csharp
void SET_CHECK_FOR_ENOUGH_ROOM_FOR_PED(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Only used in R* Script fm_content_cargo
```

---

### SET_CLEAR_FREEZE_WAITING_ON_COLLISION_ONCE_PLAYER_ENTERS

- **命名空间:** `VEHICLE`
- **Hash:** `0xB2E0C0D6922D31F2`
- **Build:** `944`

**C# 签名:**
```csharp
void SET_CLEAR_FREEZE_WAITING_ON_COLLISION_ONCE_PLAYER_ENTERS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CONVERTIBLE_ROOF

- **命名空间:** `VEHICLE`
- **Hash:** `0xF39C4F538B5124C2`
- **JHash:** `0xC87B6A51`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CONVERTIBLE_ROOF(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CONVERTIBLE_ROOF_LATCH_STATE

- **命名空间:** `VEHICLE`
- **Hash:** `0x1A78AD3D8240536F`
- **JHash:** `0x0858678C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CONVERTIBLE_ROOF_LATCH_STATE(int vehicle, bool state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `state` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DEPLOY_FOLDING_WINGS

- **命名空间:** `VEHICLE`
- **Hash:** `0xB251E0B33E58B424`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_DEPLOY_FOLDING_WINGS(int vehicle, bool deploy, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `deploy` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Only used with the "akula" and "annihilator2" in the decompiled native scripts.
```

---

### SET_DIP_STRAIGHT_DOWN_WHEN_CRASHING_PLANE

- **命名空间:** `VEHICLE`
- **Hash:** `0xAA653AE61924B0A0`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_DIP_STRAIGHT_DOWN_WHEN_CRASHING_PLANE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DISABLE_AUTOMATIC_CRASH_TASK

- **命名空间:** `VEHICLE`
- **Hash:** `0x97841634EF7DF1D6`
- **Build:** `1180`

**C# 签名:**
```csharp
void SET_DISABLE_AUTOMATIC_CRASH_TASK(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets a flag on heli and another vehicle type.
```

---

### SET_DISABLE_BMX_EXTRA_TRICK_FORCES

- **命名空间:** `VEHICLE`
- **Hash:** `0x26D99D5A82FD18E8`
- **Build:** `463`

**C# 签名:**
```csharp
void SET_DISABLE_BMX_EXTRA_TRICK_FORCES(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DISABLE_DAMAGE_WITH_PICKED_UP_ENTITY

- **命名空间:** `VEHICLE`
- **Hash:** `0xD4196117AF7BB974`
- **Build:** `757`

**C# 签名:**
```csharp
bool SET_DISABLE_DAMAGE_WITH_PICKED_UP_ENTITY(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### SET_DISABLE_EXPLODE_FROM_BODY_DAMAGE_ON_COLLISION

- **命名空间:** `VEHICLE`
- **Hash:** `0x26E13D440E7F6064`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_DISABLE_EXPLODE_FROM_BODY_DAMAGE_ON_COLLISION(int vehicle, bool disable)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `disable` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Prevents the vehicle from exploding when taking body damage if it was caused by a collision. Only works for planes.
```

---

### SET_DISABLE_HELI_EXPLODE_FROM_BODY_DAMAGE

- **命名空间:** `VEHICLE`
- **Hash:** `0xEDBC8405B3895CC9`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_DISABLE_HELI_EXPLODE_FROM_BODY_DAMAGE(int vehicle, bool disable)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `disable` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Prevents the vehicle from exploding when taking body damage. Only works for helis and planes.
```

---

### SET_DISABLE_HOVER_MODE_FLIGHT

- **命名空间:** `VEHICLE`
- **Hash:** `0x2D55FE374D5FDB91`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_DISABLE_HOVER_MODE_FLIGHT(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Disables "wings" for some flying vehicles. Works only for oppressor _2_ and deluxo.
For deluxo it just immediately removes vehicle's "wings" and you will be not able to fly up.
For oppressor 2 it will remove wings right after you land. And you will not able to fly up anymore too.
But for opressor 2 you still can fly if you somehow get back in the air.
```

---

### SET_DISABLE_MAP_COLLISION

- **命名空间:** `VEHICLE`
- **Hash:** `0x75627043C6AA90AD`
- **Build:** `1180`

**C# 签名:**
```csharp
void SET_DISABLE_MAP_COLLISION(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Disables collision for this vehicle (maybe it also supports other entities, not sure).
Only world/building/fixed world objects will have their collisions disabled, props, peds, or any other entity still collides with the vehicle.
Example: https://streamable.com/6n45d5
Not sure if there is a native (and if so, which one) that resets the collisions.
```

---

### SET_DISABLE_PED_STAND_ON_TOP

- **命名空间:** `VEHICLE`
- **Hash:** `0x8235F1BEAD557629`
- **Build:** `1180`

**C# 签名:**
```csharp
void SET_DISABLE_PED_STAND_ON_TOP(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DISABLE_PRETEND_OCCUPANTS

- **命名空间:** `VEHICLE`
- **Hash:** `0x25367DE49D64CF16`
- **JHash:** `0xCBD98BA1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DISABLE_PRETEND_OCCUPANTS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DISABLE_RANDOM_TRAINS_THIS_FRAME

- **命名空间:** `VEHICLE`
- **Hash:** `0xD4B8E3D1917BC86B`
- **JHash:** `0x09462665`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DISABLE_RANDOM_TRAINS_THIS_FRAME(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DISABLE_RETRACTING_WEAPON_BLADES

- **命名空间:** `VEHICLE`
- **Hash:** `0x8F0D5BA1C2CC91D7`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_DISABLE_RETRACTING_WEAPON_BLADES(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DISABLE_SUPERDUMMY

- **命名空间:** `VEHICLE`
- **Hash:** `0xB088E9A47AE6EDD5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DISABLE_SUPERDUMMY(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DISABLE_TURRET_MOVEMENT

- **命名空间:** `VEHICLE`
- **Hash:** `0xE615BB7A7752C76A`
- **Build:** `1365`

**C# 签名:**
```csharp
void SET_DISABLE_TURRET_MOVEMENT(int vehicle, int turretId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `turretId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Disables turret movement when called in a loop. You can still fire and aim. You cannot shoot backwards though.
```

---

### SET_DISABLE_VEHICLE_ENGINE_FIRES

- **命名空间:** `VEHICLE`
- **Hash:** `0x91A0BD635321F145`
- **JHash:** `0x1784BA1A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DISABLE_VEHICLE_ENGINE_FIRES(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DISABLE_VEHICLE_EXPLOSIONS_DAMAGE

- **命名空间:** `VEHICLE`
- **Hash:** `0x143921E45EC44D62`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_DISABLE_VEHICLE_EXPLOSIONS_DAMAGE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DISABLE_VEHICLE_PETROL_TANK_DAMAGE

- **命名空间:** `VEHICLE`
- **Hash:** `0x37C8252A7C92D017`
- **JHash:** `0xAD3E05F2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DISABLE_VEHICLE_PETROL_TANK_DAMAGE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DISABLE_VEHICLE_PETROL_TANK_FIRES

- **命名空间:** `VEHICLE`
- **Hash:** `0x465BF26AB9684352`
- **JHash:** `0xC40192B5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DISABLE_VEHICLE_PETROL_TANK_FIRES(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DISABLE_VERTICAL_FLIGHT_MODE_TRANSITION

- **命名空间:** `VEHICLE`
- **Hash:** `0xCE2B43770B655F8F`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_DISABLE_VERTICAL_FLIGHT_MODE_TRANSITION(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
True stops vtols from switching modes. Doesn't stop the sound though.
```

---

### SET_DISABLE_WANTED_CONES_RESPONSE

- **命名空间:** `VEHICLE`
- **Hash:** `0x4AD280EB48B2D8E6`
- **Build:** `1868`

**C# 签名:**
```csharp
void SET_DISABLE_WANTED_CONES_RESPONSE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DISABLE_WEAPON_BLADE_FORCES

- **命名空间:** `VEHICLE`
- **Hash:** `0x211E95CE9903940C`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_DISABLE_WEAPON_BLADE_FORCES(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets some global vehicle related bool
```

---

### SET_DISTANT_CARS_ENABLED

- **命名空间:** `VEHICLE`
- **Hash:** `0xF796359A959DF65D`
- **JHash:** `0xB5CC548B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DISTANT_CARS_ENABLED(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Toggles to render distant vehicles. They may not be vehicles but images to look like vehicles.
```

---

### SET_DONT_ALLOW_PLAYER_TO_ENTER_VEHICLE_IF_LOCKED_FOR_PLAYER

- **命名空间:** `VEHICLE`
- **Hash:** `0xDBC631F109350B8C`
- **JHash:** `0x486C1280`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DONT_ALLOW_PLAYER_TO_ENTER_VEHICLE_IF_LOCKED_FOR_PLAYER(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DONT_PROCESS_VEHICLE_GLASS

- **命名空间:** `VEHICLE`
- **Hash:** `0x1087BC8EC540DAEB`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_DONT_PROCESS_VEHICLE_GLASS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
R* used it to "remove" vehicle windows when "nightshark" had some mod, which adding some kind of armored windows. When enabled, you can't break vehicles glass. All your bullets wiil shoot through glass. You also will not able to break the glass with any other way (hitting and etc)
```

---

### SET_DOOR_ALLOWED_TO_BE_BROKEN_OFF

- **命名空间:** `VEHICLE`
- **Hash:** `0x2FA133A4A9D37ED8`
- **JHash:** `0x065B92B3`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DOOR_ALLOWED_TO_BE_BROKEN_OFF(int vehicle, int doorId, bool isBreakable)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `doorId` | `int` | `int` | - |
| `isBreakable` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
doorId: see SET_VEHICLE_DOOR_SHUT
```

---

### SET_DRIFT_TYRES

- **命名空间:** `VEHICLE`
- **Hash:** `0x5AC79C98C5C17F05`
- **Build:** `2372`

**C# 签名:**
```csharp
void SET_DRIFT_TYRES(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENABLE_VEHICLE_SLIPSTREAMING

- **命名空间:** `VEHICLE`
- **Hash:** `0xE6C0C80B8C867537`
- **JHash:** `0xD2B8ACBD`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENABLE_VEHICLE_SLIPSTREAMING(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Enable/Disables global slipstream physics
```

---

### SET_FAR_DRAW_VEHICLES

- **命名空间:** `VEHICLE`
- **Hash:** `0x26324F33423F3CC3`
- **JHash:** `0x9F019C49`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FAR_DRAW_VEHICLES(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FLEEING_VEHICLES_USE_SWITCHED_OFF_NODES

- **命名空间:** `VEHICLE`
- **Hash:** `0xA247F9EF01D8082E`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_FLEEING_VEHICLES_USE_SWITCHED_OFF_NODES(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FORCE_FIX_LINK_MATRICES

- **命名空间:** `VEHICLE`
- **Hash:** `0x887FA38787DE8C72`
- **Build:** `1365`

**C# 签名:**
```csharp
void SET_FORCE_FIX_LINK_MATRICES(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FORCE_HD_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x97CE68CB032583F0`
- **JHash:** `0xE0FC6A32`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FORCE_HD_VEHICLE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FORCE_LOW_LOD_ANCHOR_MODE

- **命名空间:** `VEHICLE`
- **Hash:** `0xB28B1FE5BFADD7F5`
- **JHash:** `0xA739012A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FORCE_LOW_LOD_ANCHOR_MODE(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
No observed effect.
```

---

### SET_FORCE_VEHICLE_ENGINE_DAMAGE_BY_BULLET

- **命名空间:** `VEHICLE`
- **Hash:** `0x4D9D109F63FEE1D4`
- **JHash:** `0x900C878C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FORCE_VEHICLE_ENGINE_DAMAGE_BY_BULLET(object p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FORKLIFT_FORK_HEIGHT

- **命名空间:** `VEHICLE`
- **Hash:** `0x37EBBF3117BD6A25`
- **JHash:** `0x943A6CFC`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FORKLIFT_FORK_HEIGHT(int vehicle, float height)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `height` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
0.0 = Lowest 1.0 = Highest. This is best to be used if you wanna pick-up a car since un-realistically on GTA V forklifts can't pick up much of anything due to vehicle mass. If you put this under a car then set it above 0.0 to a 'lifted-value' it will raise the car with no issue lol
```

---

### SET_FORMATION_LEADER

- **命名空间:** `VEHICLE`
- **Hash:** `0x428AD3E26C8D9EB0`
- **Build:** `877`

**C# 签名:**
```csharp
void SET_FORMATION_LEADER(int vehicle, float x, float y, float z, float p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p4` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GARBAGE_TRUCKS

- **命名空间:** `VEHICLE`
- **Hash:** `0x2AFD795EEAC8D30D`
- **JHash:** `0xD9ABB0FF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GARBAGE_TRUCKS(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GLIDER_ACTIVE

- **命名空间:** `VEHICLE`
- **Hash:** `0x544996C0081ABDEB`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_GLIDER_ACTIVE(int vehicle, bool state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `state` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Set state to true to extend the wings, false to retract them.
```

---

### SET_GLOBAL_POSITION_OFFSET_FOR_RECORDED_VEHICLE_PLAYBACK

- **命名空间:** `VEHICLE`
- **Hash:** `0xFAF2A78061FD9EF4`
- **JHash:** `0xCD83C393`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GLOBAL_POSITION_OFFSET_FOR_RECORDED_VEHICLE_PLAYBACK(int vehicle, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GOON_BOSS_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0xAB31EF4DE6800CE9`
- **Build:** `573`

**C# 签名:**
```csharp
void SET_GOON_BOSS_VEHICLE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Used for GTAO CEO/Associate spawned vehicles.
```

---

### SET_GROUND_EFFECT_REDUCES_DRAG

- **命名空间:** `VEHICLE`
- **Hash:** `0x430A7631A84C9BE7`
- **Build:** `1180`

**C# 签名:**
```csharp
void SET_GROUND_EFFECT_REDUCES_DRAG(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_HELI_BLADES_FULL_SPEED

- **命名空间:** `VEHICLE`
- **Hash:** `0xA178472EBB8AE60D`
- **JHash:** `0x033A9408`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_HELI_BLADES_FULL_SPEED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Equivalent of SET_HELI_BLADES_SPEED(vehicleHandle, 1.0f);
```

---

### SET_HELI_BLADES_SPEED

- **命名空间:** `VEHICLE`
- **Hash:** `0xFD280B4D7F3ABC4D`
- **JHash:** `0x5C7D4EA9`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_HELI_BLADES_SPEED(int vehicle, float speed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `speed` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the speed of the helicopter blades in percentage of the full speed.

vehicleHandle: The helicopter.
speed: The speed in percentage, 0.0f being 0% and 1.0f being 100%.
```

---

### SET_HELI_CAN_PICKUP_ENTITY_THAT_HAS_PICK_UP_DISABLED

- **命名空间:** `VEHICLE`
- **Hash:** `0x94A68DA412C4007D`
- **Build:** `1180`

**C# 签名:**
```csharp
void SET_HELI_CAN_PICKUP_ENTITY_THAT_HAS_PICK_UP_DISABLED(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Stops the cargobob from being able to attach any vehicle
```

---

### SET_HELI_COMBAT_OFFSET

- **命名空间:** `VEHICLE`
- **Hash:** `0x0A3F820A9A9A9AC5`
- **Build:** `1180`

**C# 签名:**
```csharp
void SET_HELI_COMBAT_OFFSET(int vehicle, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_HELI_CONTROL_LAGGING_RATE_SCALAR

- **命名空间:** `VEHICLE`
- **Hash:** `0x6E0859B530A365CC`
- **JHash:** `0x6E67FD35`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_HELI_CONTROL_LAGGING_RATE_SCALAR(int helicopter, float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `helicopter` | `Vehicle` | `int` | - |
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
value between 0.0 and 1.0
```

---

### SET_HELI_MAIN_ROTOR_HEALTH

- **命名空间:** `VEHICLE`
- **Hash:** `0x4056EA1105F5ABD7`
- **Build:** `463`

**C# 签名:**
```csharp
void SET_HELI_MAIN_ROTOR_HEALTH(int vehicle, float health)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `health` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_HELI_RESIST_TO_EXPLOSION

- **命名空间:** `VEHICLE`
- **Hash:** `0x8074CC1886802912`
- **Build:** `2545`

**C# 签名:**
```csharp
void SET_HELI_RESIST_TO_EXPLOSION(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_HELI_TAIL_BOOM_CAN_BREAK_OFF

- **命名空间:** `VEHICLE`
- **Hash:** `0x3EC8BF18AA453FE9`
- **JHash:** `0x2916D69B`
- **Build:** `323`

**C# 签名:**
```csharp
bool SET_HELI_TAIL_BOOM_CAN_BREAK_OFF(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### SET_HELI_TAIL_ROTOR_HEALTH

- **命名空间:** `VEHICLE`
- **Hash:** `0xFE205F38AAA58E5B`
- **Build:** `463`

**C# 签名:**
```csharp
void SET_HELI_TAIL_ROTOR_HEALTH(int vehicle, float health)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `health` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_HELI_TURBULENCE_SCALAR

- **命名空间:** `VEHICLE`
- **Hash:** `0xE6F13851780394DA`
- **JHash:** `0xCCB41A55`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_HELI_TURBULENCE_SCALAR(int vehicle, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_HOVER_MODE_WING_RATIO

- **命名空间:** `VEHICLE`
- **Hash:** `0x70A252F60A3E036B`
- **Build:** `1365`

**C# 签名:**
```csharp
void SET_HOVER_MODE_WING_RATIO(int vehicle, float ratio)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `ratio` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_HYDRAULICS_CONTROL

- **命名空间:** `VEHICLE`
- **Hash:** `0x28B18377EB6E25F6`
- **Build:** `505`

**C# 签名:**
```csharp
void SET_HYDRAULICS_CONTROL(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
If false, lowers hydraulics (if raised) and disables hydraulics controls. If true, raises hydraulics and enables hydraulics controls.

Only used once in each carmod script, on a car that does not have hydraulics to begin with.
```

---

### SET_HYDRAULIC_SUSPENSION_RAISE_FACTOR

- **命名空间:** `VEHICLE`
- **Hash:** `0x84EA99C62CB3EF0C`
- **Build:** `505`

**C# 签名:**
```csharp
void SET_HYDRAULIC_SUSPENSION_RAISE_FACTOR(int vehicle, int wheelId, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `wheelId` | `int` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Works only on vehicles that support hydraulics.
```

---

### SET_HYDRAULIC_VEHICLE_STATE

- **命名空间:** `VEHICLE`
- **Hash:** `0x8EA86DF356801C7D`
- **Build:** `505`

**C# 签名:**
```csharp
void SET_HYDRAULIC_VEHICLE_STATE(int vehicle, int state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `state` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
States:
4 = raise
5 = lower
6 = jump
```

---

### SET_HYDRAULIC_WHEEL_STATE

- **命名空间:** `VEHICLE`
- **Hash:** `0xC24075310A8B9CD1`
- **Build:** `505`

**C# 签名:**
```csharp
void SET_HYDRAULIC_WHEEL_STATE(int vehicle, int wheelId, int state, float value, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `wheelId` | `int` | `int` | - |
| `state` | `int` | `int` | - |
| `value` | `float` | `float` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets vehicle wheel hydraulic states transition. Known states:
0 - reset
1 - raise wheel (uses value arg, works just like _SET_VEHICLE_HYDRAULIC_WHEEL_VALUE)
2 - jump using wheel
```

---

### SET_IGNORE_PLANES_SMALL_PITCH_CHANGE

- **命名空间:** `VEHICLE`
- **Hash:** `0x8664170EF165C4A6`
- **Build:** `2189`

**C# 签名:**
```csharp
void SET_IGNORE_PLANES_SMALL_PITCH_CHANGE(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_INCREASE_WHEEL_CRUSH_DAMAGE

- **命名空间:** `VEHICLE`
- **Hash:** `0x2970EAA18FD5E42F`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_INCREASE_WHEEL_CRUSH_DAMAGE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_INVERT_VEHICLE_CONTROLS

- **命名空间:** `VEHICLE`
- **Hash:** `0x5B91B229243351A8`
- **Build:** `791`

**C# 签名:**
```csharp
void SET_INVERT_VEHICLE_CONTROLS(int vehicle, bool state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `state` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Inverts vehicle's controls. So INPUT_VEH_ACCELERATE will be INPUT_VEH_BRAKE and vise versa (same for A/D controls)
Doesn't work for planes/helis.
```

---

### SET_LAST_DRIVEN_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0xACFB2463CC22BED2`
- **JHash:** `0xD1B71A25`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_LAST_DRIVEN_VEHICLE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_LIGHTS_CUTOFF_DISTANCE_TWEAK

- **命名空间:** `VEHICLE`
- **Hash:** `0xBC3CCA5844452B06`
- **JHash:** `0x929801C6`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_LIGHTS_CUTOFF_DISTANCE_TWEAK(float distance)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `distance` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_MISSION_TRAIN_AS_NO_LONGER_NEEDED

- **命名空间:** `VEHICLE`
- **Hash:** `0xBBE7648349B49BE8`
- **JHash:** `0x19808560`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_MISSION_TRAIN_AS_NO_LONGER_NEEDED(Vehicle* train, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `train` | `Vehicle*` | `Vehicle*` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 is always 0
```

---

### SET_MISSION_TRAIN_COORDS

- **命名空间:** `VEHICLE`
- **Hash:** `0x591CA673AA6AB736`
- **JHash:** `0xD6D70803`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_MISSION_TRAIN_COORDS(int train, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `train` | `Vehicle` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_NITROUS_IS_ACTIVE

- **命名空间:** `VEHICLE`
- **Hash:** `0x9E566EA551F4F1A6`
- **Build:** `3407`

**C# 签名:**
```csharp
void SET_NITROUS_IS_ACTIVE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_NUMBER_OF_PARKED_VEHICLES

- **命名空间:** `VEHICLE`
- **Hash:** `0xCAA15F13EBD417FF`
- **JHash:** `0x206A58E8`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_NUMBER_OF_PARKED_VEHICLES(int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_OPEN_REAR_DOORS_ON_EXPLOSION

- **命名空间:** `VEHICLE`
- **Hash:** `0x1B212B26DD3C04DF`
- **Build:** `757`

**C# 签名:**
```csharp
void SET_OPEN_REAR_DOORS_ON_EXPLOSION(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_OVERRIDE_NITROUS_LEVEL

- **命名空间:** `VEHICLE`
- **Hash:** `0xC8E9B6B71B8E660D`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_OVERRIDE_NITROUS_LEVEL(int vehicle, bool toggle, float level, float power, float rechargeTime, bool disableSound)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |
| `level` | `float` | `float` | - |
| `power` | `float` | `float` | - |
| `rechargeTime` | `float` | `float` | - |
| `disableSound` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_OVERRIDE_VEHICLE_DOOR_TORQUE

- **命名空间:** `VEHICLE`
- **Hash:** `0x66E3AAFACE2D1EB8`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_OVERRIDE_VEHICLE_DOOR_TORQUE(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PARKED_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME

- **命名空间:** `VEHICLE`
- **Hash:** `0xEAE6DCC7EEE3DB1D`
- **JHash:** `0xDD46CEBE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARKED_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PEDS_CAN_FALL_OFF_THIS_VEHICLE_FROM_LARGE_FALL_DAMAGE

- **命名空间:** `VEHICLE`
- **Hash:** `0x59C3757B3B7408E8`
- **Build:** `1493`

**C# 签名:**
```csharp
void SET_PEDS_CAN_FALL_OFF_THIS_VEHICLE_FROM_LARGE_FALL_DAMAGE(int vehicle, bool toggle, float p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |
| `p2` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets some bit and float of vehicle. float is >= 0
```

---

### SET_PICKUP_ROPE_LENGTH_FOR_CARGOBOB

- **命名空间:** `VEHICLE`
- **Hash:** `0x877C1EAEAC531023`
- **JHash:** `0x3A8AB081`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PICKUP_ROPE_LENGTH_FOR_CARGOBOB(int cargobob, float length1, float length2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cargobob` | `Vehicle` | `int` | - |
| `length1` | `float` | `float` | - |
| `length2` | `float` | `float` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
min: 1.9f, max: 100.0f
```

---

### SET_PICKUP_ROPE_LENGTH_WITHOUT_CREATING_ROPE_FOR_CARGOBOB

- **命名空间:** `VEHICLE`
- **Hash:** `0xC0ED6438E6D39BA8`
- **Build:** `944`

**C# 签名:**
```csharp
void SET_PICKUP_ROPE_LENGTH_WITHOUT_CREATING_ROPE_FOR_CARGOBOB(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLANE_CONTROL_SECTIONS_SHOULD_BREAK_OFF_FROM_EXPLOSIONS

- **命名空间:** `VEHICLE`
- **Hash:** `0xDD8A2D3337F04196`
- **Build:** `3407`

**C# 签名:**
```csharp
void SET_PLANE_CONTROL_SECTIONS_SHOULD_BREAK_OFF_FROM_EXPLOSIONS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLANE_ENGINE_HEALTH

- **命名空间:** `VEHICLE`
- **Hash:** `0x2A86A0475B6A1434`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_PLANE_ENGINE_HEALTH(int vehicle, float health)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `health` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Works just like SET_VEHICLE_ENGINE_HEALTH, but only for planes.
```

---

### SET_PLANE_PROPELLER_HEALTH

- **命名空间:** `VEHICLE`
- **Hash:** `0x4C815EB175086F84`
- **Build:** `1103`

**C# 签名:**
```csharp
bool SET_PLANE_PROPELLER_HEALTH(int plane, float health)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `plane` | `Vehicle` | `int` | - |
| `health` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### SET_PLANE_RESIST_TO_EXPLOSION

- **命名空间:** `VEHICLE`
- **Hash:** `0xE16142B94664DEFD`
- **JHash:** `0xFBBA699A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLANE_RESIST_TO_EXPLOSION(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLANE_SECTION_DAMAGE_SCALE

- **命名空间:** `VEHICLE`
- **Hash:** `0x0BBB9A7A8FFE931B`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_PLANE_SECTION_DAMAGE_SCALE(int vehicle, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLANE_TURBULENCE_MULTIPLIER

- **命名空间:** `VEHICLE`
- **Hash:** `0xAD2D28A1AFDFF131`
- **JHash:** `0xED159AE6`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLANE_TURBULENCE_MULTIPLIER(int vehicle, float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native sets the turbulence multiplier. It only works for planes.
0.0 = no turbulence at all.
1.0 = heavy turbulence.
Works by just calling it once, does not need to be called every tick.
```

---

### SET_PLAYBACK_SPEED

- **命名空间:** `VEHICLE`
- **Hash:** `0x6683AB880E427778`
- **JHash:** `0x684E26E4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYBACK_SPEED(int vehicle, float speed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `speed` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYBACK_TO_USE_AI

- **命名空间:** `VEHICLE`
- **Hash:** `0xA549C3B37EA28131`
- **JHash:** `0xB536CCD7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYBACK_TO_USE_AI(int vehicle, int drivingStyle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `drivingStyle` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Identical to SET_PLAYBACK_TO_USE_AI_TRY_TO_REVERT_BACK_LATER with 0 as arguments for p1 and p3.
```

---

### SET_PLAYBACK_TO_USE_AI_TRY_TO_REVERT_BACK_LATER

- **命名空间:** `VEHICLE`
- **Hash:** `0x6E63860BBB190730`
- **JHash:** `0x0C8ABAA4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYBACK_TO_USE_AI_TRY_TO_REVERT_BACK_LATER(int vehicle, int time, int drivingStyle, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `time` | `int` | `int` | - |
| `drivingStyle` | `int` | `int` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Time is number of milliseconds before reverting, zero for indefinitely.
```

---

### SET_PLAYERS_LAST_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0xBCDF8BAF56C87B6A`
- **JHash:** `0xDE86447D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYERS_LAST_VEHICLE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_POLICE_FOCUS_WILL_TRACK_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x4E74E62E0A97E901`
- **JHash:** `0x5690F6C3`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_POLICE_FOCUS_WILL_TRACK_VEHICLE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_POSITION_OFFSET_FOR_RECORDED_VEHICLE_PLAYBACK

- **命名空间:** `VEHICLE`
- **Hash:** `0x796A877E459B99EA`
- **JHash:** `0x5C9F477C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_POSITION_OFFSET_FOR_RECORDED_VEHICLE_PLAYBACK(int vehicle, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_RANDOM_BOATS

- **命名空间:** `VEHICLE`
- **Hash:** `0x84436EC293B1415F`
- **JHash:** `0xB505BD89`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_RANDOM_BOATS(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_RANDOM_BOATS_MP

- **命名空间:** `VEHICLE`
- **Hash:** `0xDA5E12F728DB30CA`
- **Build:** `2372`

**C# 签名:**
```csharp
void SET_RANDOM_BOATS_MP(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_RANDOM_TRAINS

- **命名空间:** `VEHICLE`
- **Hash:** `0x80D9F74197EA47D9`
- **JHash:** `0xD461CA7F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_RANDOM_TRAINS(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_RANDOM_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME

- **命名空间:** `VEHICLE`
- **Hash:** `0xB3B3359379FE77D3`
- **JHash:** `0x543F712B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_RANDOM_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_REDUCED_SUSPENSION_FORCE

- **命名空间:** `VEHICLE`
- **Hash:** `0x3A375167F5782A65`
- **Build:** `2372`

**C# 签名:**
```csharp
void SET_REDUCED_SUSPENSION_FORCE(int vehicle, bool enable)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `enable` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Lowers the vehicle's stance. Only works for vehicles that have strAdvancedFlags 0x8000 and 0x4000000 set.
```

---

### SET_RENDER_TRAIN_AS_DERAILED

- **命名空间:** `VEHICLE`
- **Hash:** `0x317B11A312DF5534`
- **JHash:** `0x899D9092`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_RENDER_TRAIN_AS_DERAILED(int train, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `train` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Makes the train all jumbled up and derailed as it moves on the tracks (though that wont stop it from its normal operations)
```

---

### SET_ROCKET_BOOST_ACTIVE

- **命名空间:** `VEHICLE`
- **Hash:** `0x81E1552E35DC3839`
- **Build:** `944`

**C# 签名:**
```csharp
void SET_ROCKET_BOOST_ACTIVE(int vehicle, bool active)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `active` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ROCKET_BOOST_FILL

- **命名空间:** `VEHICLE`
- **Hash:** `0xFEB2DDED3509562E`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_ROCKET_BOOST_FILL(int vehicle, float percentage)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `percentage` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SCRIPT_RAMP_IMPULSE_SCALE

- **命名空间:** `VEHICLE`
- **Hash:** `0xEFC13B1CE30D755D`
- **Build:** `944`

**C# 签名:**
```csharp
void SET_SCRIPT_RAMP_IMPULSE_SCALE(int vehicle, float impulseScale)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `impulseScale` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SCRIPT_ROCKET_BOOST_RECHARGE_TIME

- **命名空间:** `VEHICLE`
- **Hash:** `0xE00F2AB100B76E89`
- **Build:** `944`

**C# 签名:**
```csharp
void SET_SCRIPT_ROCKET_BOOST_RECHARGE_TIME(int vehicle, float seconds)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `seconds` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SCRIPT_VEHICLE_GENERATOR

- **命名空间:** `VEHICLE`
- **Hash:** `0xD9D620E0AC6DC4B0`
- **JHash:** `0x40D73747`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SCRIPT_VEHICLE_GENERATOR(int vehicleGenerator, bool enabled)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicleGenerator` | `int` | `int` | - |
| `enabled` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Only called once in the decompiled scripts. Presumably activates the specified generator.
```

---

### SET_SHORT_SLOWDOWN_FOR_LANDING

- **命名空间:** `VEHICLE`
- **Hash:** `0x107A473D7A6647A9`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_SHORT_SLOWDOWN_FOR_LANDING(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Used on helicopters and blimps during the CTaskVehicleLand task. Sets a value on the task to 10f
```

---

### SET_SHOULD_LERP_FROM_AI_TO_FULL_RECORDING

- **命名空间:** `VEHICLE`
- **Hash:** `0x063AE2B2CC273588`
- **JHash:** `0x2EF8435C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SHOULD_LERP_FROM_AI_TO_FULL_RECORDING(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
A vehicle recording playback flag only used in jewelry_heist
```

---

### SET_SHOULD_RESET_TURRET_IN_SCRIPTED_CAMERAS

- **命名空间:** `VEHICLE`
- **Hash:** `0x78CEEE41F49F421F`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_SHOULD_RESET_TURRET_IN_SCRIPTED_CAMERAS(int vehicle, bool shouldReset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `shouldReset` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Resets the vehicle's turret to its default position in scripted cameras. Doesn't seem to affect turrets that are occupied by a ped.
```

---

### SET_SLOW_DOWN_EFFECT_DISABLED

- **命名空间:** `VEHICLE`
- **Hash:** `0x65B080555EA48149`
- **Build:** `1011`

**C# 签名:**
```csharp
void SET_SLOW_DOWN_EFFECT_DISABLED(bool disabled)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `disabled` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Disables the screen effects and sound effects when driving over a slowdown pad.
```

---

### SET_SPECIAL_FLIGHT_MODE_ALLOWED

- **命名空间:** `VEHICLE`
- **Hash:** `0xF1211889DF15A763`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_SPECIAL_FLIGHT_MODE_ALLOWED(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
It will override the ability to transform deluxo. For oppressor it will work just like SET_DISABLE_HOVER_MODE_FLIGHT
```

---

### SET_SPECIAL_FLIGHT_MODE_RATIO

- **命名空间:** `VEHICLE`
- **Hash:** `0xD138FA15C9776837`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_SPECIAL_FLIGHT_MODE_RATIO(int vehicle, float ratio)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `ratio` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Used in conjunction with SET_SPECIAL_FLIGHT_MODE_TARGET_RATIO, in Rockstar's scripts. Using this will instantly transform the vehicle into hover mode starting from the given ratio (ranging from 0.0 to 1.0, values greater than 1.0 will put the vehicle into a glitched state.) If this is not used alongside SET_SPECIAL_FLIGHT_MODE_TARGET_RATIO, the vehicle will automatically transform back into car mode.

Usable only with the deluxo and other vehicles with deluxo-like hover mode toggle, modded or otherwise. Does nothing when used on oppressor2.

Example:
Ped playerPed = PLAYER::PLAYER_PED_ID();
Vehicle veh = PED::GET_VEHICLE_PED_IS_USING(playerPed);
VEHICLE::SET_SPECIAL_FLIGHT_MODE_RATIO(veh, 0.7f);
VEHICLE::SET_SPECIAL_FLIGHT_MODE_TARGET_RATIO(veh, 1.0f);
```

---

### SET_SPECIAL_FLIGHT_MODE_TARGET_RATIO

- **命名空间:** `VEHICLE`
- **Hash:** `0x438B3D7CA026FE91`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_SPECIAL_FLIGHT_MODE_TARGET_RATIO(int vehicle, float targetRatio)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `targetRatio` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Used in conjunction with SET_SPECIAL_FLIGHT_MODE_RATIO, in Rockstar's scripts. The vehicle will transform into the given targetRatio, starting from the vehicle's current hover mode transform ratio (which can also be manually set by SET_SPECIAL_FLIGHT_MODE_RATIO,) i.e. setting targetRatio to 0.0 while the vehicle is in hover mode will transform the vehicle into car mode, likewise setting targetRatio to 1.0 while the vehicle is in car mode will transform the vehicle into hover mode, and if the current transform ratio is set to 0.7 while targetRatio is 1.0 the vehicle will transform into hover mode starting from being already partially transformed.

targetRatio is recommended to always be 0.0 or 1.0, otherwise the vehicle will transform into a glitched state.

Usable only with the deluxo and other vehicles with deluxo-like hover mode toggle, modded or otherwise. Does nothing when used on oppressor2.

Example:
Ped playerPed = PLAYER::PLAYER_PED_ID();
Vehicle veh = PED::GET_VEHICLE_PED_IS_USING(playerPed);
VEHICLE::SET_SPECIAL_FLIGHT_MODE_RATIO(veh, 0.7f);
VEHICLE::SET_SPECIAL_FLIGHT_MODE_TARGET_RATIO(veh, 1.0f);
```

---

### SET_SPEED_BOOST_EFFECT_DISABLED

- **命名空间:** `VEHICLE`
- **Hash:** `0x7BBE7FF626A591FE`
- **Build:** `877`

**C# 签名:**
```csharp
void SET_SPEED_BOOST_EFFECT_DISABLED(bool disabled)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `disabled` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Disables the screen effects and sound effects when driving over a speed boost pad.
```

---

### SET_SUBMARINE_CRUSH_DEPTHS

- **命名空间:** `VEHICLE`
- **Hash:** `0xC59872A5134879C7`
- **JHash:** `0x4A46E814`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SUBMARINE_CRUSH_DEPTHS(int vehicle, bool p1, float depth1, float depth2, float depth3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `depth1` | `float` | `float` | - |
| `depth2` | `float` | `float` | - |
| `depth3` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TASK_VEHICLE_GOTO_PLANE_MIN_HEIGHT_ABOVE_TERRAIN

- **命名空间:** `VEHICLE`
- **Hash:** `0xB893215D8D4C015B`
- **JHash:** `0x8C4B63E2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TASK_VEHICLE_GOTO_PLANE_MIN_HEIGHT_ABOVE_TERRAIN(int plane, int height)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `plane` | `Vehicle` | `int` | - |
| `height` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TAXI_LIGHTS

- **命名空间:** `VEHICLE`
- **Hash:** `0x598803E85E8448D9`
- **JHash:** `0x68639D85`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TAXI_LIGHTS(int vehicle, bool state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `state` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This is not tested - it's just an assumption.
- Nac

Doesn't seem to work.  I'll try with an int instead. --JT

Read the scripts, im dumpass. 

                            if (!VEHICLE::IS_TAXI_LIGHT_ON(l_115)) {
                                VEHICLE::SET_TAXI_LIGHTS(l_115, 1);
                            }
```

---

### SET_TRAILER_ATTACHMENT_ENABLED

- **命名空间:** `VEHICLE`
- **Hash:** `0x2FA2494B47FDD009`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_TRAILER_ATTACHMENT_ENABLED(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TRAILER_INVERSE_MASS_SCALE

- **命名空间:** `VEHICLE`
- **Hash:** `0x2A8F319B392E7B3F`
- **JHash:** `0xE74E85CE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TRAILER_INVERSE_MASS_SCALE(int vehicle, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TRAILER_LEGS_LOWERED

- **命名空间:** `VEHICLE`
- **Hash:** `0x878C75C09FBDB942`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_TRAILER_LEGS_LOWERED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TRAILER_LEGS_RAISED

- **命名空间:** `VEHICLE`
- **Hash:** `0x95CF53B3D687F9FA`
- **JHash:** `0x06C47A6F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TRAILER_LEGS_RAISED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
in the decompiled scripts, seems to be always called on the vehicle right after being attached to a trailer.
```

---

### SET_TRAIN_CRUISE_SPEED

- **命名空间:** `VEHICLE`
- **Hash:** `0x16469284DB8C62B5`
- **JHash:** `0xB507F51D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TRAIN_CRUISE_SPEED(int train, float speed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `train` | `Vehicle` | `int` | - |
| `speed` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TRAIN_SPEED

- **命名空间:** `VEHICLE`
- **Hash:** `0xAA0BC91BE0B796E3`
- **JHash:** `0xDFC35E4D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TRAIN_SPEED(int train, float speed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `train` | `Vehicle` | `int` | - |
| `speed` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TRAIN_TRACK_SPAWN_FREQUENCY

- **命名空间:** `VEHICLE`
- **Hash:** `0x21973BBF8D17EDFA`
- **JHash:** `0xD5774FB7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TRAIN_TRACK_SPAWN_FREQUENCY(int trackIndex, int frequency)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `trackIndex` | `int` | `int` | - |
| `frequency` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Only called once inside main_persitant with the parameters p0 = 0, p1 = 120000

trackIndex: 0 - 26
Full list of all train tracks + track nodes by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/traintracks.json
```

---

### SET_TRANSFORM_RATE_FOR_ANIMATION

- **命名空间:** `VEHICLE`
- **Hash:** `0x498218259FB7C72D`
- **Build:** `1365`

**C# 签名:**
```csharp
void SET_TRANSFORM_RATE_FOR_ANIMATION(int vehicle, float transformRate)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `transformRate` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Affects the playback speed of the submarine car conversion animations. Does not affect hardcoded animations such as the wheels being retracted.
```

---

### SET_TRANSFORM_TO_SUBMARINE_USES_ALTERNATE_INPUT

- **命名空间:** `VEHICLE`
- **Hash:** `0x41B9FB92EDED32A6`
- **Build:** `1365`

**C# 签名:**
```csharp
void SET_TRANSFORM_TO_SUBMARINE_USES_ALTERNATE_INPUT(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
When set to true, the key to transform a car to submarine mode changes from raise/lower convertible roof (hold H by default) to special vehicle transform (press X by default.)
```

---

### SET_TURRET_HIDDEN

- **命名空间:** `VEHICLE`
- **Hash:** `0xC60060EB0D8AC7B1`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_TURRET_HIDDEN(int vehicle, int index, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `index` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Toggles specific flag on turret
```

---

### SET_TYRE_HEALTH

- **命名空间:** `VEHICLE`
- **Hash:** `0x74C68EF97645E79D`
- **Build:** `1868`

**C# 签名:**
```csharp
void SET_TYRE_HEALTH(int vehicle, int wheelIndex, float health)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `wheelIndex` | `int` | `int` | - |
| `health` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
SET_TYRE_WEAR_RATE must be active, otherwise values set to <1000.0f will default to 350.0f

Usable wheels:
0: wheel_lf
1: wheel_rf
2: wheel_lm1
3: wheel_rm1
4: wheel_lr
5: wheel_rr
```

---

### SET_TYRE_MAXIMUM_GRIP_DIFFERENCE_DUE_TO_WEAR_RATE

- **命名空间:** `VEHICLE`
- **Hash:** `0xC970D0E0FC31D768`
- **Build:** `2060`

**C# 签名:**
```csharp
void SET_TYRE_MAXIMUM_GRIP_DIFFERENCE_DUE_TO_WEAR_RATE(int vehicle, int wheelIndex, float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `wheelIndex` | `int` | `int` | - |
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Controls how much traction the wheel loses.

Default values from Rockstar's Open Wheel Race JSON's:
"owrtds" (Soft): 0.05
"owrtdm" (Medium): 0.45
"owrtdh" (Hard): 0.8

Usable wheels:
0: wheel_lf
1: wheel_rf
2: wheel_lm1
3: wheel_rm1
4: wheel_lr
5: wheel_rr
```

---

### SET_TYRE_WEAR_RATE

- **命名空间:** `VEHICLE`
- **Hash:** `0x01894E2EDE923CA2`
- **Build:** `1868`

**C# 签名:**
```csharp
void SET_TYRE_WEAR_RATE(int vehicle, int wheelIndex, float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `wheelIndex` | `int` | `int` | - |
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Needs to be run for tire wear to work. Multiplier affects the downforce and how fast the tires will wear out, higher values essentially make the vehicle slower on straights and its tires will wear down quicker when cornering. Value must be >0f.
Default value in Rockstar's Open Wheel Race JSON's ("owrtws", "owrtwm", "owrtwh") is 1.0

Usable wheels:
0: wheel_lf
1: wheel_rf
2: wheel_lm1
3: wheel_rm1
4: wheel_lr
5: wheel_rr
```

---

### SET_TYRE_WEAR_RATE_SCALE

- **命名空间:** `VEHICLE`
- **Hash:** `0x392183BB9EA57697`
- **Build:** `2060`

**C# 签名:**
```csharp
void SET_TYRE_WEAR_RATE_SCALE(int vehicle, int wheelIndex, float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `wheelIndex` | `int` | `int` | - |
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Controls how fast the tires wear out.

Default values from Rockstar's Open Wheel Race JSON's:
"owrtss" (Soft): 2.2
"owrtsm" (Medium): 1.7
"owrtsh" (Hard): 1.2

Usable wheels:
0: wheel_lf
1: wheel_rf
2: wheel_lm1
3: wheel_rm1
4: wheel_lr
5: wheel_rr
```

---

### SET_USE_DESIRED_Z_CRUISE_SPEED_FOR_LANDING

- **命名空间:** `VEHICLE`
- **Hash:** `0xB68CFAF83A02768D`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_USE_DESIRED_Z_CRUISE_SPEED_FOR_LANDING(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_USE_DOUBLE_CLICK_FOR_CAR_JUMP

- **命名空间:** `VEHICLE`
- **Hash:** `0x5BBCF35BF6E456F7`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_USE_DOUBLE_CLICK_FOR_CAR_JUMP(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Changes the car jump control to require a double-tap to activate.
```

---

### SET_USE_HIGHER_CAR_JUMP

- **命名空间:** `VEHICLE`
- **Hash:** `0xF06A16CA55D138D8`
- **Build:** `944`

**C# 签名:**
```csharp
void SET_USE_HIGHER_CAR_JUMP(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Allows vehicles with the FLAG_JUMPING_CAR flag to jump higher (i.e. Ruiner 2000).
```

---

### SET_VEHICLE_ACTIVE_DURING_PLAYBACK

- **命名空间:** `VEHICLE`
- **Hash:** `0xDFFCEF48E511DB48`
- **JHash:** `0xEB7D7C27`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_ACTIVE_DURING_PLAYBACK(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_ACTIVE_FOR_PED_NAVIGATION

- **命名空间:** `VEHICLE`
- **Hash:** `0x21115BCD6E44656A`
- **JHash:** `0xEBC225C1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_ACTIVE_FOR_PED_NAVIGATION(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_ACT_AS_IF_HAS_SIREN_ON

- **命名空间:** `VEHICLE`
- **Hash:** `0x9BECD4B9FEF3F8A6`
- **JHash:** `0xACAB8FF3`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_ACT_AS_IF_HAS_SIREN_ON(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_ACT_AS_IF_HIGH_SPEED_FOR_FRAG_SMASHING

- **命名空间:** `VEHICLE`
- **Hash:** `0x1F9FB66F3A3842D2`
- **JHash:** `0x4D840FC4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_ACT_AS_IF_HIGH_SPEED_FOR_FRAG_SMASHING(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_AI_CAN_USE_EXCLUSIVE_SEATS

- **命名空间:** `VEHICLE`
- **Hash:** `0x41062318F23ED854`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_AI_CAN_USE_EXCLUSIVE_SEATS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Used to be incorrectly named SET_VEHICLE_EXCLUSIVE_DRIVER
Toggles a flag related to SET_VEHICLE_EXCLUSIVE_DRIVER, however, doesn't enable that feature (or trigger script events related to it).
```

---

### SET_VEHICLE_ALARM

- **命名空间:** `VEHICLE`
- **Hash:** `0xCDE5E70C1DDB954C`
- **JHash:** `0x24877D84`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_ALARM(int vehicle, bool state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `state` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_ALLOW_HOMING_MISSLE_LOCKON

- **命名空间:** `VEHICLE`
- **Hash:** `0x7D6F9A3EF26136A0`
- **JHash:** `0xBB54ECCA`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_ALLOW_HOMING_MISSLE_LOCKON(int vehicle, bool toggle, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_ALLOW_HOMING_MISSLE_LOCKON_SYNCED

- **命名空间:** `VEHICLE`
- **Hash:** `0x1DDA078D12879EEE`
- **Build:** `463`

**C# 签名:**
```csharp
void SET_VEHICLE_ALLOW_HOMING_MISSLE_LOCKON_SYNCED(int vehicle, bool canBeLockedOn, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `canBeLockedOn` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_ALLOW_NO_PASSENGERS_LOCKON

- **命名空间:** `VEHICLE`
- **Hash:** `0x5D14D4154BFE7B2C`
- **JHash:** `0x8BAAC437`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_ALLOW_NO_PASSENGERS_LOCKON(int veh, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `veh` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Makes the vehicle accept no passengers.
```

---

### SET_VEHICLE_AUTOMATICALLY_ATTACHES

- **命名空间:** `VEHICLE`
- **Hash:** `0x8BA6F76BC53A1493`
- **JHash:** `0x4273A8D3`
- **Build:** `323`

**C# 签名:**
```csharp
int SET_VEHICLE_AUTOMATICALLY_ATTACHES(int vehicle, bool p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `int` (Native: `Entity`)

---

### SET_VEHICLE_AVOID_PLAYER_VEHICLE_RIOT_VAN_MISSION

- **命名空间:** `VEHICLE`
- **Hash:** `0xD3301660A57C9272`
- **Build:** `757`

**C# 签名:**
```csharp
void SET_VEHICLE_AVOID_PLAYER_VEHICLE_RIOT_VAN_MISSION(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_BLIP_THROTTLE_RANDOMLY

- **命名空间:** `VEHICLE`
- **Hash:** `0x9F3F689B814F2599`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_BLIP_THROTTLE_RANDOMLY(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_BOBBLEHEAD_VELOCITY

- **命名空间:** `VEHICLE`
- **Hash:** `0x870B8B7A766615C8`
- **Build:** `505`

**C# 签名:**
```csharp
void SET_VEHICLE_BOBBLEHEAD_VELOCITY(float x, float y, float p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `p2` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Controls how fast bobbleheads and tsurikawas move on each axis.

p2 is probably z, but changing that value didn't seem to have a noticeable effect.
```

---

### SET_VEHICLE_BODY_HEALTH

- **命名空间:** `VEHICLE`
- **Hash:** `0xB77D05AC8C78AADB`
- **JHash:** `0x920C2517`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_BODY_HEALTH(int vehicle, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p2 often set to 1000.0 in the decompiled scripts.
```

---

### SET_VEHICLE_BOMB_AMMO

- **命名空间:** `VEHICLE`
- **Hash:** `0xF4B2ED59DEB5D774`
- **Build:** `1180`

**C# 签名:**
```csharp
void SET_VEHICLE_BOMB_AMMO(int vehicle, int bombCount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `bombCount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the amount of bombs that this vehicle has. As far as I know, this does _not_ impact vehicle weapons or the ammo of those weapons in any way, it is just a way to keep track of the amount of bombs in a specific plane.
```

---

### SET_VEHICLE_BRAKE

- **命名空间:** `VEHICLE`
- **Hash:** `0xE4E2FD323574965C`
- **JHash:** `0x5A36BC37`
- **Build:** `757`

**C# 签名:**
```csharp
void SET_VEHICLE_BRAKE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_BRAKE_LIGHTS

- **命名空间:** `VEHICLE`
- **Hash:** `0x92B35082E0B42F66`
- **JHash:** `0x6D9BA11E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_BRAKE_LIGHTS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_BROKEN_PARTS_DONT_AFFECT_AI_HANDLING

- **命名空间:** `VEHICLE`
- **Hash:** `0xC361AA040D6637A8`
- **JHash:** `0x819CD954`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_BROKEN_PARTS_DONT_AFFECT_AI_HANDLING(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_BULLDOZER_ARM_POSITION

- **命名空间:** `VEHICLE`
- **Hash:** `0xF8EBCCC96ADB9FB7`
- **JHash:** `0xED23C8A3`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_BULLDOZER_ARM_POSITION(int vehicle, float position, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `position` | `float` | `float` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the arm position of a bulldozer. Position must be a value between 0.0 and 1.0. Ignored when `p2` is set to false, instead incrementing arm position by 0.1 (or 10%).
```

---

### SET_VEHICLE_BURNOUT

- **命名空间:** `VEHICLE`
- **Hash:** `0xFB8794444A7D60FB`
- **JHash:** `0x9B6EF0EA`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_BURNOUT(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
On accelerating, spins the driven wheels with the others braked, so you don't go anywhere.
```

---

### SET_VEHICLE_CAN_BE_TARGETTED

- **命名空间:** `VEHICLE`
- **Hash:** `0x3750146A28097A82`
- **JHash:** `0x64B70B1D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_CAN_BE_TARGETTED(int vehicle, bool state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `state` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This has not yet been tested - it's just an assumption of what the types could be.
```

---

### SET_VEHICLE_CAN_BE_USED_BY_FLEEING_PEDS

- **命名空间:** `VEHICLE`
- **Hash:** `0x300504B23BD3B711`
- **JHash:** `0x5130DB1E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_CAN_BE_USED_BY_FLEEING_PEDS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_CAN_BE_VISIBLY_DAMAGED

- **命名空间:** `VEHICLE`
- **Hash:** `0x4C7028F78FFD3681`
- **JHash:** `0xC5D94017`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_CAN_BE_VISIBLY_DAMAGED(int vehicle, bool state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `state` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_CAN_BREAK

- **命名空间:** `VEHICLE`
- **Hash:** `0x59BF8C3D52C92F66`
- **JHash:** `0x90A810D1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_CAN_BREAK(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_CAN_DEFORM_WHEELS

- **命名空间:** `VEHICLE`
- **Hash:** `0x0CDDA42F9E360CA6`
- **JHash:** `0x9B581DE7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_CAN_DEFORM_WHEELS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_CAN_EJECT_PASSENGERS_IF_LOCKED

- **命名空间:** `VEHICLE`
- **Hash:** `0x065D03A9D6B2C6B5`
- **Build:** `463`

**C# 签名:**
```csharp
void SET_VEHICLE_CAN_EJECT_PASSENGERS_IF_LOCKED(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_CAN_ENGINE_MISSFIRE

- **命名空间:** `VEHICLE`
- **Hash:** `0x206BC5DC9D1AC70A`
- **JHash:** `0x8EACBD13`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_CAN_ENGINE_MISSFIRE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_CAN_LEAK_OIL

- **命名空间:** `VEHICLE`
- **Hash:** `0x51BB2D88D31A914B`
- **JHash:** `0x88F0F7E7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_CAN_LEAK_OIL(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_CAN_LEAK_PETROL

- **命名空间:** `VEHICLE`
- **Hash:** `0x192547247864DFDD`
- **JHash:** `0x90D6EE57`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_CAN_LEAK_PETROL(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_CAN_SAVE_IN_GARAGE

- **命名空间:** `VEHICLE`
- **Hash:** `0x428BACCDF5E26EAD`
- **JHash:** `0x1604C2F5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_CAN_SAVE_IN_GARAGE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_CAUSES_SWERVING

- **命名空间:** `VEHICLE`
- **Hash:** `0x9849DE24FCF23CCC`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_VEHICLE_CAUSES_SWERVING(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_CEILING_HEIGHT

- **命名空间:** `VEHICLE`
- **Hash:** `0xA46413066687A328`
- **JHash:** `0x98A10A86`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_CEILING_HEIGHT(int vehicle, float height)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `height` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_CHEAT_POWER_INCREASE

- **命名空间:** `VEHICLE`
- **Hash:** `0xB59E4BD37AE292DB`
- **JHash:** `0x642DA5AA`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_CHEAT_POWER_INCREASE(int vehicle, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
<1.0 - Decreased torque
=1.0 - Default torque
>1.0 - Increased torque

Negative values will cause the vehicle to go backwards instead of forwards while accelerating.

value - is between 0.2 and 1.8 in the decompiled scripts. 

This needs to be called every frame to take effect.
```

---

### SET_VEHICLE_COLOURS

- **命名空间:** `VEHICLE`
- **Hash:** `0x4F1D4BE3A7F24601`
- **JHash:** `0x57F24253`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_COLOURS(int vehicle, int colorPrimary, int colorSecondary)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `colorPrimary` | `int` | `int` | - |
| `colorSecondary` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
colorPrimary & colorSecondary are the paint index for the vehicle.
For a list of valid paint indexes, view: https://pastebin.com/pwHci0xK
-------------------------------------------------------------------------
Note: minimum color index is 0, maximum color index is (numColorIndices - 1)

Full list of vehicle colors by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicleColors.json
```

---

### SET_VEHICLE_COLOUR_COMBINATION

- **命名空间:** `VEHICLE`
- **Hash:** `0x33E8CD3322E2FE31`
- **JHash:** `0xA557AEAD`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_COLOUR_COMBINATION(int vehicle, int colorCombination)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `colorCombination` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the selected vehicle's colors to the specified index of the color combination found in the vehicle's carvariations.meta entry.
```

---

### SET_VEHICLE_COMBAT_MODE

- **命名空间:** `VEHICLE`
- **Hash:** `0x36DE109527A2C0C4`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_VEHICLE_COMBAT_MODE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Does nothing. It's a nullsub.
```

---

### SET_VEHICLE_COUNTERMEASURE_AMMO

- **命名空间:** `VEHICLE`
- **Hash:** `0x9BDA23BF666F0855`
- **Build:** `1180`

**C# 签名:**
```csharp
void SET_VEHICLE_COUNTERMEASURE_AMMO(int vehicle, int counterMeasureCount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `counterMeasureCount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Similar to SET_VEHICLE_BOMB_AMMO, this sets the amount of countermeasures that are present on this vehicle.
Use GET_VEHICLE_BOMB_AMMO to get the current amount.
```

---

### SET_VEHICLE_CUSTOM_PATH_NODE_STREAMING_RADIUS

- **命名空间:** `VEHICLE`
- **Hash:** `0x182F266C2D9E2BEB`
- **JHash:** `0x7D0DE7EA`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_CUSTOM_PATH_NODE_STREAMING_RADIUS(int vehicle, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_CUSTOM_PRIMARY_COLOUR

- **命名空间:** `VEHICLE`
- **Hash:** `0x7141766F91D15BEA`
- **JHash:** `0x8DF9F9BC`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_CUSTOM_PRIMARY_COLOUR(int vehicle, int r, int g, int b)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `r` | `int` | `int` | - |
| `g` | `int` | `int` | - |
| `b` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1, p2, p3 are RGB values for color (255,0,0 for Red, ect)
```

---

### SET_VEHICLE_CUSTOM_SECONDARY_COLOUR

- **命名空间:** `VEHICLE`
- **Hash:** `0x36CED73BFED89754`
- **JHash:** `0x9D77259E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_CUSTOM_SECONDARY_COLOUR(int vehicle, int r, int g, int b)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `r` | `int` | `int` | - |
| `g` | `int` | `int` | - |
| `b` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1, p2, p3 are RGB values for color (255,0,0 for Red, ect)
```

---

### SET_VEHICLE_DAMAGE

- **命名空间:** `VEHICLE`
- **Hash:** `0xA1DD317EA8FD4F29`
- **JHash:** `0x21B458B2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_DAMAGE(int vehicle, float xOffset, float yOffset, float zOffset, float damage, float radius, bool focusOnModel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `xOffset` | `float` | `float` | - |
| `yOffset` | `float` | `float` | - |
| `zOffset` | `float` | `float` | - |
| `damage` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `focusOnModel` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Apply damage to vehicle at a location. Location is relative to vehicle model (not world).

Radius of effect damage applied in a sphere at impact location
When `focusOnModel` set to `true`, the damage sphere will travel towards the vehicle from the given point, thus guaranteeing an impact
```

---

### SET_VEHICLE_DAMAGE_SCALE

- **命名空间:** `VEHICLE`
- **Hash:** `0x4E20D2A627011E8E`
- **Build:** `757`

**C# 签名:**
```csharp
bool SET_VEHICLE_DAMAGE_SCALE(int vehicle, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### SET_VEHICLE_DAMAGE_SCALES

- **命名空间:** `VEHICLE`
- **Hash:** `0x9640E30A7F395E4B`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_VEHICLE_DAMAGE_SCALES(int vehicle, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_DEFORMATION_FIXED

- **命名空间:** `VEHICLE`
- **Hash:** `0x953DA1E1B12C0491`
- **JHash:** `0xDD2920C8`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_DEFORMATION_FIXED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This fixes the deformation of a vehicle but the vehicle health doesn't improve
```

---

### SET_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME

- **命名空间:** `VEHICLE`
- **Hash:** `0x245A6883D966D537`
- **JHash:** `0xF4187E51`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Use this native inside a looped function.
Values:
- `0.0` = no vehicles on streets
- `1.0` = normal vehicles on streets
```

---

### SET_VEHICLE_DETONATION_MODE

- **命名空间:** `VEHICLE`
- **Hash:** `0x82E0AC411E41A5B4`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_VEHICLE_DETONATION_MODE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Does nothing. It's a nullsub.
```

---

### SET_VEHICLE_DIRT_LEVEL

- **命名空间:** `VEHICLE`
- **Hash:** `0x79D3B596FE44EE8B`
- **JHash:** `0x2B39128B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_DIRT_LEVEL(int vehicle, float dirtLevel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `dirtLevel` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
You can't use values greater than 15.0
Also, R* does (float)(rand() % 15) to get a random dirt level when generating a vehicle.
```

---

### SET_VEHICLE_DISABLE_COLLISION_UPON_CREATION

- **命名空间:** `VEHICLE`
- **Hash:** `0xAF60E6A2936F982A`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_VEHICLE_DISABLE_COLLISION_UPON_CREATION(int vehicle, bool disable)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `disable` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_DISABLE_HEIGHT_MAP_AVOIDANCE

- **命名空间:** `VEHICLE`
- **Hash:** `0x8AA9180DE2FEDD45`
- **JHash:** `0xAE040377`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_DISABLE_HEIGHT_MAP_AVOIDANCE(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_DISABLE_TOWING

- **命名空间:** `VEHICLE`
- **Hash:** `0x2B6747FAA9DB9D6B`
- **JHash:** `0x95A9ACCB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_DISABLE_TOWING(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_DONT_TERMINATE_TASK_WHEN_ACHIEVED

- **命名空间:** `VEHICLE`
- **Hash:** `0x76D26A22750E849E`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_VEHICLE_DONT_TERMINATE_TASK_WHEN_ACHIEVED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_DOORS_LOCKED

- **命名空间:** `VEHICLE`
- **Hash:** `0xB664292EAECF7FA6`
- **JHash:** `0x4CDD35D0`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_DOORS_LOCKED(int vehicle, int doorLockStatus)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `doorLockStatus` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
enum eVehicleLockState
{
	VEHICLELOCK_NONE,
	VEHICLELOCK_UNLOCKED,
	VEHICLELOCK_LOCKED,
	VEHICLELOCK_LOCKOUT_PLAYER_ONLY,
	VEHICLELOCK_LOCKED_PLAYER_INSIDE,
	VEHICLELOCK_LOCKED_INITIALLY,
	VEHICLELOCK_FORCE_SHUT_DOORS,
	VEHICLELOCK_LOCKED_BUT_CAN_BE_DAMAGED,
	VEHICLELOCK_LOCKED_BUT_BOOT_UNLOCKED,
	VEHICLELOCK_LOCKED_NO_PASSENGERS,
	VEHICLELOCK_CANNOT_ENTER	
};
```

---

### SET_VEHICLE_DOORS_LOCKED_FOR_ALL_PLAYERS

- **命名空间:** `VEHICLE`
- **Hash:** `0xA2F80B8D040727CC`
- **JHash:** `0x891BA8A4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_DOORS_LOCKED_FOR_ALL_PLAYERS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
After some analysis, I've decided that these are what the parameters are.

We can see this being used in R* scripts such as "am_mp_property_int.ysc.c4":
l_11A1 = PED::GET_VEHICLE_PED_IS_IN(PLAYER::PLAYER_PED_ID(), 1);
...
VEHICLE::SET_VEHICLE_DOORS_LOCKED_FOR_ALL_PLAYERS(l_11A1, 1);
```

---

### SET_VEHICLE_DOORS_LOCKED_FOR_ALL_TEAMS

- **命名空间:** `VEHICLE`
- **Hash:** `0x203B527D1B77904C`
- **Build:** `1365`

**C# 签名:**
```csharp
void SET_VEHICLE_DOORS_LOCKED_FOR_ALL_TEAMS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_DOORS_LOCKED_FOR_NON_SCRIPT_PLAYERS

- **命名空间:** `VEHICLE`
- **Hash:** `0x9737A37136F07E75`
- **JHash:** `0xE4EF6514`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_DOORS_LOCKED_FOR_NON_SCRIPT_PLAYERS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_DOORS_LOCKED_FOR_PLAYER

- **命名空间:** `VEHICLE`
- **Hash:** `0x517AAF684BB50CD1`
- **JHash:** `0x49829236`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_DOORS_LOCKED_FOR_PLAYER(int vehicle, int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_DOORS_LOCKED_FOR_TEAM

- **命名空间:** `VEHICLE`
- **Hash:** `0xB81F6D4A8F5EEBA8`
- **JHash:** `0x4F85E783`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_DOORS_LOCKED_FOR_TEAM(int vehicle, int team, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `team` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_DOORS_SHUT

- **命名空间:** `VEHICLE`
- **Hash:** `0x781B3D62BB013EF5`
- **JHash:** `0xBB1FF6E7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_DOORS_SHUT(int vehicle, bool closeInstantly)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `closeInstantly` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Closes all doors of a vehicle:
```

---

### SET_VEHICLE_DOOR_AUTO_LOCK

- **命名空间:** `VEHICLE`
- **Hash:** `0x3B458DDB57038F08`
- **Build:** `877`

**C# 签名:**
```csharp
void SET_VEHICLE_DOOR_AUTO_LOCK(int vehicle, int doorId, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `doorId` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
doorId: see SET_VEHICLE_DOOR_SHUT

Usually used alongside other vehicle door natives.
```

---

### SET_VEHICLE_DOOR_BROKEN

- **命名空间:** `VEHICLE`
- **Hash:** `0xD4D4F6A4AB575A33`
- **JHash:** `0x8147FEA7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_DOOR_BROKEN(int vehicle, int doorId, bool deleteDoor)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `doorId` | `int` | `int` | - |
| `deleteDoor` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
doorId: see SET_VEHICLE_DOOR_SHUT
```

---

### SET_VEHICLE_DOOR_CONTROL

- **命名空间:** `VEHICLE`
- **Hash:** `0xF2BFA0430F0A0FCB`
- **JHash:** `0x572DD360`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_DOOR_CONTROL(int vehicle, int doorId, int speed, float angle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `doorId` | `int` | `int` | - |
| `speed` | `int` | `int` | - |
| `angle` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
doorId: see SET_VEHICLE_DOOR_SHUT
```

---

### SET_VEHICLE_DOOR_LATCHED

- **命名空间:** `VEHICLE`
- **Hash:** `0xA5A9653A8D2CAF48`
- **JHash:** `0x4EB7BBFC`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_DOOR_LATCHED(int vehicle, int doorId, bool p2, bool p3, bool p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `doorId` | `int` | `int` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
doorId: see SET_VEHICLE_DOOR_SHUT
```

---

### SET_VEHICLE_DOOR_OPEN

- **命名空间:** `VEHICLE`
- **Hash:** `0x7C65DAC73C35C862`
- **JHash:** `0xBB75D38B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_DOOR_OPEN(int vehicle, int doorId, bool loose, bool openInstantly)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `doorId` | `int` | `int` | - |
| `loose` | `BOOL` | `bool` | - |
| `openInstantly` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
doorId: see SET_VEHICLE_DOOR_SHUT
```

---

### SET_VEHICLE_DOOR_SHUT

- **命名空间:** `VEHICLE`
- **Hash:** `0x93D9BD300D7789E5`
- **JHash:** `0x142606BD`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_DOOR_SHUT(int vehicle, int doorId, bool closeInstantly)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `doorId` | `int` | `int` | - |
| `closeInstantly` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
enum eDoorId
{
	VEH_EXT_DOOR_INVALID_ID = -1,
	VEH_EXT_DOOR_DSIDE_F,
	VEH_EXT_DOOR_DSIDE_R,
	VEH_EXT_DOOR_PSIDE_F,
	VEH_EXT_DOOR_PSIDE_R,
	VEH_EXT_BONNET,
	VEH_EXT_BOOT
};
```

---

### SET_VEHICLE_DROPS_MONEY_WHEN_BLOWN_UP

- **命名空间:** `VEHICLE`
- **Hash:** `0x068F64F2470F9656`
- **JHash:** `0x4BB5605D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_DROPS_MONEY_WHEN_BLOWN_UP(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Money pickups are created around cars when they explode. Only works when the vehicle model is a car. A single pickup is between 1 and 18 dollars in size. All car models seem to give the same amount of money.

youtu.be/3arlUxzHl5Y 
i.imgur.com/WrNpYFs.jpg
```

---

### SET_VEHICLE_ENGINE_CAN_DEGRADE

- **命名空间:** `VEHICLE`
- **Hash:** `0x983765856F2564F9`
- **JHash:** `0x081DAC12`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_ENGINE_CAN_DEGRADE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_ENGINE_HEALTH

- **命名空间:** `VEHICLE`
- **Hash:** `0x45F6D8EEF34ABEF1`
- **JHash:** `0x1B760FB5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_ENGINE_HEALTH(int vehicle, float health)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `health` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
1000 is max health
Begins leaking gas at around 650 health
Minimum: -4000
Maximum: 1000

-4000: Engine is destroyed
0 and below: Engine catches fire and health rapidly declines
300: Engine is smoking and losing functionality
1000: Engine is perfect
```

---

### SET_VEHICLE_ENGINE_ON

- **命名空间:** `VEHICLE`
- **Hash:** `0x2497C4717C8B881E`
- **JHash:** `0x7FBC86F1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_ENGINE_ON(int vehicle, bool value, bool instantly, bool disableAutoStart)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `value` | `BOOL` | `bool` | - |
| `instantly` | `BOOL` | `bool` | - |
| `disableAutoStart` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Starts or stops the engine on the specified vehicle.

vehicle: The vehicle to start or stop the engine on.
value: true to turn the vehicle on; false to turn it off.
instantly: if true, the vehicle will be set to the state immediately; otherwise, the current driver will physically turn on or off the engine.
disableAutoStart: If true, the system will prevent the engine from starting when the player got into it.
```

---

### SET_VEHICLE_ENVEFF_SCALE

- **命名空间:** `VEHICLE`
- **Hash:** `0x3AFDC536C3D01674`
- **JHash:** `0x8332730C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_ENVEFF_SCALE(int vehicle, float fade)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `fade` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
The parameter fade is a value from 0-1, where 0 is fresh paint.
```

---

### SET_VEHICLE_EXCLUSIVE_DRIVER

- **命名空间:** `VEHICLE`
- **Hash:** `0xB5C51B5502E85E83`
- **JHash:** `0xAA8BD440`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_EXCLUSIVE_DRIVER(int vehicle, int ped, int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `ped` | `Ped` | `int` | - |
| `index` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
index: 0 - 1

Used to be incorrectly named _SET_VEHICLE_EXCLUSIVE_DRIVER_2
```

---

### SET_VEHICLE_EXPLODES_ON_EXPLOSION_DAMAGE_AT_ZERO_BODY_HEALTH

- **命名空间:** `VEHICLE`
- **Hash:** `0xD565F438137F0E10`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_VEHICLE_EXPLODES_ON_EXPLOSION_DAMAGE_AT_ZERO_BODY_HEALTH(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_EXPLODES_ON_HIGH_EXPLOSION_DAMAGE

- **命名空间:** `VEHICLE`
- **Hash:** `0x71B0892EC081D60A`
- **JHash:** `0x38CC692B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_EXPLODES_ON_HIGH_EXPLOSION_DAMAGE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets a vehicle to be strongly resistant to explosions. p0 is the vehicle; set p1 to false to toggle the effect on/off.
```

---

### SET_VEHICLE_EXTENDED_REMOVAL_RANGE

- **命名空间:** `VEHICLE`
- **Hash:** `0x79DF7E806202CE01`
- **JHash:** `0xAEF9611C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_EXTENDED_REMOVAL_RANGE(int vehicle, int range)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `range` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Max value is 32767
```

---

### SET_VEHICLE_EXTRA

- **命名空间:** `VEHICLE`
- **Hash:** `0x7EE3A3C5E4A40CC9`
- **JHash:** `0x642D065C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_EXTRA(int vehicle, int extraId, bool disable)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `extraId` | `int` | `int` | - |
| `disable` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Available extraIds are 1-14, however none of the vehicles have extras above 12.
```

---

### SET_VEHICLE_EXTRA_COLOURS

- **命名空间:** `VEHICLE`
- **Hash:** `0x2036F561ADD12E33`
- **JHash:** `0x515DB2A0`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_EXTRA_COLOURS(int vehicle, int pearlescentColor, int wheelColor)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `pearlescentColor` | `int` | `int` | - |
| `wheelColor` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
They use the same color indexs as SET_VEHICLE_COLOURS.
```

---

### SET_VEHICLE_EXTRA_COLOUR_5

- **命名空间:** `VEHICLE`
- **Hash:** `0xF40DD601A65F7F19`
- **Build:** `505`

**C# 签名:**
```csharp
void SET_VEHICLE_EXTRA_COLOUR_5(int vehicle, int color)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `color` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_EXTRA_COLOUR_6

- **命名空间:** `VEHICLE`
- **Hash:** `0x6089CDF6A57F326C`
- **Build:** `505`

**C# 签名:**
```csharp
void SET_VEHICLE_EXTRA_COLOUR_6(int vehicle, int color)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `color` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_FIXED

- **命名空间:** `VEHICLE`
- **Hash:** `0x115722B1B9C14C1C`
- **JHash:** `0x17469AA1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_FIXED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This fixes a vehicle.
If the vehicle's engine's broken then you cannot fix it with this native.
```

---

### SET_VEHICLE_FLIGHT_NOZZLE_POSITION

- **命名空间:** `VEHICLE`
- **Hash:** `0x30D779DE7C4F6DD3`
- **JHash:** `0xA7DF64D7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_FLIGHT_NOZZLE_POSITION(int vehicle, float angleRatio)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `angleRatio` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_FLIGHT_NOZZLE_POSITION_IMMEDIATE

- **命名空间:** `VEHICLE`
- **Hash:** `0x9AA47FFF660CB932`
- **JHash:** `0xDD7936F5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_FLIGHT_NOZZLE_POSITION_IMMEDIATE(int vehicle, float angle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `angle` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_FORCE_AFTERBURNER

- **命名空间:** `VEHICLE`
- **Hash:** `0xB055A34527CB8FD7`
- **JHash:** `0xC195803B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_FORCE_AFTERBURNER(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_FORCE_INTERIORLIGHT

- **命名空间:** `VEHICLE`
- **Hash:** `0x8821196D91FA2DE5`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_VEHICLE_FORCE_INTERIORLIGHT(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets some bit of vehicle
```

---

### SET_VEHICLE_FORWARD_SPEED

- **命名空间:** `VEHICLE`
- **Hash:** `0xAB54A438726D25D5`
- **JHash:** `0x69880D14`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_FORWARD_SPEED(int vehicle, float speed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `speed` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
SCALE: Setting the speed to 30 would result in a speed of roughly 60mph, according to speedometer.

Speed is in meters per second
You can convert meters/s to mph here:
http://www.calculateme.com/Speed/MetersperSecond/ToMilesperHour.htm
```

---

### SET_VEHICLE_FORWARD_SPEED_XY

- **命名空间:** `VEHICLE`
- **Hash:** `0x6501129C9E0FFA05`
- **Build:** `877`

**C# 签名:**
```csharp
void SET_VEHICLE_FORWARD_SPEED_XY(int vehicle, float speed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `speed` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Seems to be identical to SET_VEHICLE_FORWARD_SPEED
```

---

### SET_VEHICLE_FRICTION_OVERRIDE

- **命名空间:** `VEHICLE`
- **Hash:** `0x1837AF7C627009BA`
- **JHash:** `0x32AFD42E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_FRICTION_OVERRIDE(int vehicle, float friction)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `friction` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Seems to be related to the metal parts, not tyres (like i was expecting lol)
```

---

### SET_VEHICLE_FULLBEAM

- **命名空间:** `VEHICLE`
- **Hash:** `0x8B7FD87F0DDB421E`
- **JHash:** `0x9C49CC15`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_FULLBEAM(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
It switch to highbeam when p1 is set to true.
```

---

### SET_VEHICLE_GENERATES_ENGINE_SHOCKING_EVENTS

- **命名空间:** `VEHICLE`
- **Hash:** `0x279D50DE5652D935`
- **JHash:** `0xB3200F72`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_GENERATES_ENGINE_SHOCKING_EVENTS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Allows creation of CEventShockingPlaneFlyby, CEventShockingHelicopterOverhead, and other(?) Shocking events
```

---

### SET_VEHICLE_GENERATOR_AREA_OF_INTEREST

- **命名空间:** `VEHICLE`
- **Hash:** `0x9A75585FB2E54FAD`
- **JHash:** `0x935A95DA`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_GENERATOR_AREA_OF_INTEREST(float x, float y, float z, float radius)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Related to car generators & CPlayerSwitchMgrLong
```

---

### SET_VEHICLE_GRAVITY

- **命名空间:** `VEHICLE`
- **Hash:** `0x89F149B6131E57DA`
- **JHash:** `0x07B2A6DC`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_GRAVITY(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_HANDBRAKE

- **命名空间:** `VEHICLE`
- **Hash:** `0x684785568EF26A22`
- **JHash:** `0xBA729A25`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_HANDBRAKE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_HANDLING_OVERRIDE

- **命名空间:** `VEHICLE`
- **Hash:** `0x10655FAB9915623D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_HANDLING_OVERRIDE(int vehicle, uint hash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `hash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Use the "AIHandling" string found in handling.meta
```

---

### SET_VEHICLE_HAS_BEEN_DRIVEN_FLAG

- **命名空间:** `VEHICLE`
- **Hash:** `0x02398B627547189C`
- **JHash:** `0x08CD58F9`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_HAS_BEEN_DRIVEN_FLAG(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_HAS_BEEN_OWNED_BY_PLAYER

- **命名空间:** `VEHICLE`
- **Hash:** `0x2B5F9D2AF1F1722D`
- **JHash:** `0xB4D3DBFB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_HAS_BEEN_OWNED_BY_PLAYER(int vehicle, bool owned)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `owned` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_HAS_MUTED_SIRENS

- **命名空间:** `VEHICLE`
- **Hash:** `0xD8050E0EB60CF274`
- **JHash:** `0xC54156A9`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_HAS_MUTED_SIRENS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
If set to true, prevents vehicle sirens from having sound, leaving only the lights.
```

---

### SET_VEHICLE_HAS_STRONG_AXLES

- **命名空间:** `VEHICLE`
- **Hash:** `0x92F0CF722BC4202F`
- **JHash:** `0x0D1CBC65`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_HAS_STRONG_AXLES(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
if true, axles won't bend.
```

---

### SET_VEHICLE_HAS_UNBREAKABLE_LIGHTS

- **命名空间:** `VEHICLE`
- **Hash:** `0x1AA8A837D2169D94`
- **JHash:** `0x009AB49E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_HAS_UNBREAKABLE_LIGHTS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_HEADLIGHT_SHADOWS

- **命名空间:** `VEHICLE`
- **Hash:** `0x1FD09E7390A74D54`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_HEADLIGHT_SHADOWS(int vehicle, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 can be either 0, 1 or 2.

Determines how vehicle lights behave when toggled.

0 = Default (Lights can be toggled between off, normal and high beams)
1 = Lights Disabled (Lights are fully disabled, cannot be toggled)
2 = Always On (Lights can be toggled between normal and high beams)
```

---

### SET_VEHICLE_HOMING_LOCKEDONTO_STATE

- **命名空间:** `VEHICLE`
- **Hash:** `0x407DC5E97DB1A4D3`
- **Build:** `1493`

**C# 签名:**
```csharp
void SET_VEHICLE_HOMING_LOCKEDONTO_STATE(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_IMPATIENCE_TIMER

- **命名空间:** `VEHICLE`
- **Hash:** `0x6A973569BA094650`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_VEHICLE_IMPATIENCE_TIMER(int vehicle, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Seems to copy some values in vehicle
```

---

### SET_VEHICLE_INACTIVE_DURING_PLAYBACK

- **命名空间:** `VEHICLE`
- **Hash:** `0x06582AFF74894C75`
- **JHash:** `0x50F89338`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_INACTIVE_DURING_PLAYBACK(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_INDICATOR_LIGHTS

- **命名空间:** `VEHICLE`
- **Hash:** `0xB5D45264751B7DF0`
- **JHash:** `0xA6073B5D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_INDICATOR_LIGHTS(int vehicle, int turnSignal, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `turnSignal` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the turn signal enabled for a vehicle.
Set turnSignal to 1 for left light, 0 for right light.
```

---

### SET_VEHICLE_INDIVIDUAL_DOORS_LOCKED

- **命名空间:** `VEHICLE`
- **Hash:** `0xBE70724027F85BCD`
- **JHash:** `0xD61D182D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_INDIVIDUAL_DOORS_LOCKED(int vehicle, int doorId, int doorLockStatus)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `doorId` | `int` | `int` | - |
| `doorLockStatus` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
doorId: see SET_VEHICLE_DOOR_SHUT
```

---

### SET_VEHICLE_INFLUENCES_WANTED_LEVEL

- **命名空间:** `VEHICLE`
- **Hash:** `0x0AD9E8F87FF7C16F`
- **JHash:** `0x04F5546C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_INFLUENCES_WANTED_LEVEL(object p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_INTERIORLIGHT

- **命名空间:** `VEHICLE`
- **Hash:** `0xBC2042F090AF6AD3`
- **JHash:** `0x9AD1FE1E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_INTERIORLIGHT(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_IN_CAR_MOD_SHOP

- **命名空间:** `VEHICLE`
- **Hash:** `0x9D44FCCE98450843`
- **JHash:** `0x968E5770`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_IN_CAR_MOD_SHOP(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
If set to TRUE, it seems to suppress door noises and doesn't allow the horn to be continuous.
```

---

### SET_VEHICLE_IS_CONSIDERED_BY_PLAYER

- **命名空间:** `VEHICLE`
- **Hash:** `0x31B927BBC44156CD`
- **JHash:** `0x14413319`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_IS_CONSIDERED_BY_PLAYER(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Setting this to false, makes the specified vehicle to where if you press Y your character doesn't even attempt the animation to enter the vehicle. Hence it's not considered aka ignored.
```

---

### SET_VEHICLE_IS_RACING

- **命名空间:** `VEHICLE`
- **Hash:** `0x07116E24E9D1929D`
- **JHash:** `0xA59E3DCD`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_IS_RACING(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 (toggle) was always 1 (true) except in one case in the b678 scripts.
```

---

### SET_VEHICLE_IS_STOLEN

- **命名空间:** `VEHICLE`
- **Hash:** `0x67B2C79AA7FF5738`
- **JHash:** `0x70912E42`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_IS_STOLEN(int vehicle, bool isStolen)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `isStolen` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_IS_WANTED

- **命名空间:** `VEHICLE`
- **Hash:** `0xF7EC25A3EBEEC726`
- **JHash:** `0xDAA388E8`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_IS_WANTED(int vehicle, bool state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `state` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the wanted state of this vehicle.
```

---

### SET_VEHICLE_KEEP_ENGINE_ON_WHEN_ABANDONED

- **命名空间:** `VEHICLE`
- **Hash:** `0xB8FBC8B1330CA9B4`
- **JHash:** `0x51E0064F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_KEEP_ENGINE_ON_WHEN_ABANDONED(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_KERS_ALLOWED

- **命名空间:** `VEHICLE`
- **Hash:** `0x99C82F8A139F3E4E`
- **JHash:** `0x71CDD52F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_KERS_ALLOWED(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_LIGHTS

- **命名空间:** `VEHICLE`
- **Hash:** `0x34E710FF01247C5A`
- **JHash:** `0xE8930226`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_LIGHTS(int vehicle, int state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `state` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
set's if the vehicle has lights or not.
not an on off toggle.
p1 = 0 ;vehicle normal lights, off then lowbeams, then highbeams
p1 = 1 ;vehicle doesn't have lights, always off
p1 = 2 ;vehicle has always on lights
p1 = 3 ;or even larger like 4,5,... normal lights like =1
note1: when using =2 on day it's lowbeam,highbeam
but at night it's lowbeam,lowbeam,highbeam
note2: when using =0 it's affected by day or night for highbeams don't exist in daytime.
```

---

### SET_VEHICLE_LIGHT_MULTIPLIER

- **命名空间:** `VEHICLE`
- **Hash:** `0xB385454F8791F57C`
- **JHash:** `0x48039D6A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_LIGHT_MULTIPLIER(int vehicle, float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
multiplier = brightness of head lights.
this value isn't capped afaik.

multiplier = 0.0 no lights
multiplier = 1.0 default game value

```

---

### SET_VEHICLE_LIMIT_SPEED_WHEN_PLAYER_INACTIVE

- **命名空间:** `VEHICLE`
- **Hash:** `0xC50CE861B55EAB8B`
- **JHash:** `0x40C323AE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_LIMIT_SPEED_WHEN_PLAYER_INACTIVE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_LIVERY

- **命名空间:** `VEHICLE`
- **Hash:** `0x60BF608F1B8CD1B6`
- **JHash:** `0x7AD87059`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_LIVERY(int vehicle, int livery)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `livery` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_LIVERY2

- **命名空间:** `VEHICLE`
- **Hash:** `0xA6D3A8750DC73270`
- **Build:** `505`

**C# 签名:**
```csharp
void SET_VEHICLE_LIVERY2(int vehicle, int livery)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `livery` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Used to set the secondary livery (the roof on Tornado Custom being one such example.)

Livery value is dependent on the amount of liveries present in the vehicle's texture dictionary, for Tornado Custom this would be 0-6.
```

---

### SET_VEHICLE_LOD_MULTIPLIER

- **命名空间:** `VEHICLE`
- **Hash:** `0x93AE6A61BE015BF1`
- **JHash:** `0x569E5AE3`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_LOD_MULTIPLIER(int vehicle, float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_MAX_SPEED

- **命名空间:** `VEHICLE`
- **Hash:** `0xBAA045B4E42F3C06`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_VEHICLE_MAX_SPEED(int vehicle, float speed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `speed` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
To reset the max speed, set the `speed` value to `0.0` or lower.
```

---

### SET_VEHICLE_MAY_BE_USED_BY_GOTO_POINT_ANY_MEANS

- **命名空间:** `VEHICLE`
- **Hash:** `0xE851E480B814D4BA`
- **JHash:** `0x2F98B4B7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_MAY_BE_USED_BY_GOTO_POINT_ANY_MEANS(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_MOD

- **命名空间:** `VEHICLE`
- **Hash:** `0x6AF0636DDEDCB6DD`
- **JHash:** `0xB52E5ED5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_MOD(int vehicle, int modType, int modIndex, bool customTires)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `modType` | `int` | `int` | - |
| `modIndex` | `int` | `int` | - |
| `customTires` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
In b944, there are 50 (0 - 49) mod types.

Sets the vehicle mod.
The vehicle must have a mod kit first.

Any out of range ModIndex is stock.

#Mod Type
Spoilers - 0
Front Bumper - 1
Rear Bumper - 2
Side Skirt - 3
Exhaust - 4
Frame - 5
Grille - 6
Hood - 7
Fender - 8
Right Fender - 9
Roof - 10
Engine - 11
Brakes - 12
Transmission - 13
Horns - 14 (modIndex from 0 to 51)
Suspension - 15
Armor - 16
Front Wheels - 23
Back Wheels - 24 //only for motocycles
Plate holders - 25
Trim Design - 27
Ornaments - 28
Dial Design - 30
Steering Wheel - 33
Shifter Leavers - 34
Plaques - 35
Hydraulics - 38
Livery - 48

ENUMS: https://pastebin.com/QzEAn02v
```

---

### SET_VEHICLE_MODEL_IS_SUPPRESSED

- **命名空间:** `VEHICLE`
- **Hash:** `0x0FC2D89AC25A5814`
- **JHash:** `0x42A08C9B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_MODEL_IS_SUPPRESSED(uint model, bool suppressed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `model` | `Hash` | `uint` | - |
| `suppressed` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Makes the vehicle stop spawning naturally in traffic. Here's an essential example:

VEHICLE::SET_VEHICLE_MODEL_IS_SUPPRESSED(MISC::GET_HASH_KEY("taco"), true);

Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
```

---

### SET_VEHICLE_MOD_COLOR_1

- **命名空间:** `VEHICLE`
- **Hash:** `0x43FEB945EE7F85B8`
- **JHash:** `0xCBE9A54D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_MOD_COLOR_1(int vehicle, int paintType, int color, int pearlescentColor)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `paintType` | `int` | `int` | - |
| `color` | `int` | `int` | - |
| `pearlescentColor` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
paintType:
0: Normal
1: Metallic
2: Pearl
3: Matte
4: Metal
5: Chrome
6: Chameleon

color: number of the color.

p3 seems to always be 0.

Full list of vehicle colors and vehicle plates by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicleColors.json
```

---

### SET_VEHICLE_MOD_COLOR_2

- **命名空间:** `VEHICLE`
- **Hash:** `0x816562BADFDEC83E`
- **JHash:** `0xC32613C2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_MOD_COLOR_2(int vehicle, int paintType, int color)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `paintType` | `int` | `int` | - |
| `color` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Changes the secondary paint type and color
paintType:
0: Normal
1: Metallic
2: Pearl
3: Matte
4: Metal
5: Chrome
6: Chameleon

color: number of the color

Full list of vehicle colors and vehicle plates by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicleColors.json
```

---

### SET_VEHICLE_MOD_KIT

- **命名空间:** `VEHICLE`
- **Hash:** `0x1F2AA07F00B3217A`
- **JHash:** `0xB8132158`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_MOD_KIT(int vehicle, int modKit)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `modKit` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Set modKit to 0 if you plan to call SET_VEHICLE_MOD. That's what the game does. Most body modifications through SET_VEHICLE_MOD will not take effect until this is set to 0.

Full list of vehicle mod kits and mods by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicleModKits.json
```

---

### SET_VEHICLE_NAME_DEBUG

- **命名空间:** `VEHICLE`
- **Hash:** `0xBFDF984E2C22B94F`
- **JHash:** `0xA712FF5C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_NAME_DEBUG(int vehicle, string name)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `name` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
NOTE: Debugging functions are not present in the retail version of the game.
```

---

### SET_VEHICLE_NEEDS_TO_BE_HOTWIRED

- **命名空间:** `VEHICLE`
- **Hash:** `0xFBA550EA44404EE6`
- **JHash:** `0xD8260751`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_NEEDS_TO_BE_HOTWIRED(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_NEON_COLOUR

- **命名空间:** `VEHICLE`
- **Hash:** `0x8E0A582209A62695`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_NEON_COLOUR(int vehicle, int r, int g, int b)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `r` | `int` | `int` | - |
| `g` | `int` | `int` | - |
| `b` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the color of the neon lights of the specified vehicle.
```

---

### SET_VEHICLE_NEON_ENABLED

- **命名空间:** `VEHICLE`
- **Hash:** `0x2AA720E4287BF269`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_NEON_ENABLED(int vehicle, int index, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `index` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the neon lights of the specified vehicle on/off.

Indices:
0 = Left
1 = Right
2 = Front
3 = Back
```

---

### SET_VEHICLE_NEON_INDEX_COLOUR

- **命名空间:** `VEHICLE`
- **Hash:** `0xB93B2867F7B479D1`
- **Build:** `1493`

**C# 签名:**
```csharp
void SET_VEHICLE_NEON_INDEX_COLOUR(int vehicle, int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `index` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Index references CVehicleModelColor
```

---

### SET_VEHICLE_NOT_STEALABLE_AMBIENTLY

- **命名空间:** `VEHICLE`
- **Hash:** `0xAB04325045427AAE`
- **JHash:** `0x1984F88D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_NOT_STEALABLE_AMBIENTLY(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_NO_EXPLOSION_DAMAGE_FROM_DRIVER

- **命名空间:** `VEHICLE`
- **Hash:** `0x5E569EC46EC21CAE`
- **JHash:** `0xBC649C49`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_NO_EXPLOSION_DAMAGE_FROM_DRIVER(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_NUMBER_PLATE_TEXT

- **命名空间:** `VEHICLE`
- **Hash:** `0x95A88F0B409CDA47`
- **JHash:** `0x400F9556`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_NUMBER_PLATE_TEXT(int vehicle, string plateText)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `plateText` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets a vehicle's license plate text.  8 chars maximum.

Example:
Ped playerPed = PLAYER::PLAYER_PED_ID();
Vehicle veh = PED::GET_VEHICLE_PED_IS_USING(playerPed);
char *plateText = "KING";
VEHICLE::SET_VEHICLE_NUMBER_PLATE_TEXT(veh, plateText);
```

---

### SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX

- **命名空间:** `VEHICLE`
- **Hash:** `0x9088EB5A43FFB0A1`
- **JHash:** `0xA1A1890E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX(int vehicle, int plateIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `plateIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Plates:
Blue/White - 0
Yellow/black - 1
Yellow/Blue - 2
Blue/White2 - 3
Blue/White3 - 4
Yankton - 5
```

---

### SET_VEHICLE_OCCUPANTS_TAKE_EXPLOSIVE_DAMAGE

- **命名空间:** `VEHICLE`
- **Hash:** `0x35BB21DE06784373`
- **Build:** `463`

**C# 签名:**
```csharp
void SET_VEHICLE_OCCUPANTS_TAKE_EXPLOSIVE_DAMAGE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_ON_GROUND_PROPERLY

- **命名空间:** `VEHICLE`
- **Hash:** `0x49733E92263139D1`
- **JHash:** `0xE14FDBA6`
- **Build:** `323`

**C# 签名:**
```csharp
bool SET_VEHICLE_ON_GROUND_PROPERLY(int vehicle, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Sets a vehicle on the ground on all wheels.  Returns whether or not the operation was successful.

sfink: This has an additional param(Vehicle vehicle, float p1) which is always set to 5.0f in the b944 scripts.
```

---

### SET_VEHICLE_OUT_OF_CONTROL

- **命名空间:** `VEHICLE`
- **Hash:** `0xF19D095E42D430CC`
- **JHash:** `0x3764D734`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_OUT_OF_CONTROL(int vehicle, bool killDriver, bool explodeOnImpact)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `killDriver` | `BOOL` | `bool` | - |
| `explodeOnImpact` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Tested on the player's current vehicle. Unless you kill the driver, the vehicle doesn't loose control, however, if enabled, explodeOnImpact is still active. The moment you crash, boom.
```

---

### SET_VEHICLE_PETROL_TANK_HEALTH

- **命名空间:** `VEHICLE`
- **Hash:** `0x70DB57649FA8D0D8`
- **JHash:** `0x660A3692`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_PETROL_TANK_HEALTH(int vehicle, float health)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `health` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
1000 is max health
Begins leaking gas at around 650 health
-999.90002441406 appears to be minimum health, although nothing special occurs
```

---

### SET_VEHICLE_PROVIDES_COVER

- **命名空间:** `VEHICLE`
- **Hash:** `0x5AFEEDD9BB2899D7`
- **JHash:** `0xEFC01CA9`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_PROVIDES_COVER(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_READY_FOR_CLEANUP

- **命名空间:** `VEHICLE`
- **Hash:** `0xCF9159024555488C`
- **Build:** `944`

**C# 签名:**
```csharp
void SET_VEHICLE_READY_FOR_CLEANUP(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_REDUCE_GRIP

- **命名空间:** `VEHICLE`
- **Hash:** `0x222FF6A823D122E2`
- **JHash:** `0x90D3A0D9`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_REDUCE_GRIP(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Reduces grip significantly so it's hard to go anywhere.
```

---

### SET_VEHICLE_REDUCE_GRIP_LEVEL

- **命名空间:** `VEHICLE`
- **Hash:** `0x6DEE944E1EE90CFB`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_VEHICLE_REDUCE_GRIP_LEVEL(int vehicle, int val)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `val` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
val is 0-3
Often used in conjunction with: SET_VEHICLE_REDUCE_GRIP
```

---

### SET_VEHICLE_REMOVE_AGGRESSIVE_CARJACK_MISSION

- **命名空间:** `VEHICLE`
- **Hash:** `0xC4B3347BD68BD609`
- **Build:** `573`

**C# 签名:**
```csharp
void SET_VEHICLE_REMOVE_AGGRESSIVE_CARJACK_MISSION(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_RESPECTS_LOCKS_WHEN_HAS_DRIVER

- **命名空间:** `VEHICLE`
- **Hash:** `0x2311DD7159F00582`
- **JHash:** `0x758C5E2E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_RESPECTS_LOCKS_WHEN_HAS_DRIVER(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_RUDDER_BROKEN

- **命名空间:** `VEHICLE`
- **Hash:** `0x09606148B6C71DEF`
- **JHash:** `0x3FAC3CD4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_RUDDER_BROKEN(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_SEARCHLIGHT

- **命名空间:** `VEHICLE`
- **Hash:** `0x14E85C5EE7A4D542`
- **JHash:** `0xE2C0DD8A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_SEARCHLIGHT(int heli, bool toggle, bool canBeUsedByAI)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `heli` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |
| `canBeUsedByAI` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Only works during nighttime.
```

---

### SET_VEHICLE_SHOOT_AT_TARGET

- **命名空间:** `VEHICLE`
- **Hash:** `0x74CD9A9327A282EA`
- **JHash:** `0x2343FFDF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_SHOOT_AT_TARGET(int driver, int entity, float xTarget, float yTarget, float zTarget)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `driver` | `Ped` | `int` | - |
| `entity` | `Entity` | `int` | - |
| `xTarget` | `float` | `float` | - |
| `yTarget` | `float` | `float` | - |
| `zTarget` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Commands the driver of an armed vehicle (p0) to shoot its weapon at a target (p1). p3, p4 and p5 are the coordinates of the target. Example:

WEAPON::SET_CURRENT_PED_VEHICLE_WEAPON(pilot,MISC::GET_HASH_KEY("VEHICLE_WEAPON_PLANE_ROCKET"));                        VEHICLE::SET_VEHICLE_SHOOT_AT_TARGET(pilot, target, targPos.x, targPos.y, targPos.z);
```

---

### SET_VEHICLE_SHUNT_ON_STICK

- **命名空间:** `VEHICLE`
- **Hash:** `0x99A05839C46CE316`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_VEHICLE_SHUNT_ON_STICK(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Does nothing. It's a nullsub.
```

---

### SET_VEHICLE_SIREN

- **命名空间:** `VEHICLE`
- **Hash:** `0xF4924635A19EB37D`
- **JHash:** `0x4AC1EFC7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_SIREN(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Activate siren on vehicle (Only works if the vehicle has a siren).
```

---

### SET_VEHICLE_SLIPSTREAMING_SHOULD_TIME_OUT

- **命名空间:** `VEHICLE`
- **Hash:** `0xF051D9BFB6BA39C0`
- **Build:** `877`

**C# 签名:**
```csharp
void SET_VEHICLE_SLIPSTREAMING_SHOULD_TIME_OUT(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_STAYS_FROZEN_WHEN_CLEANED_UP

- **命名空间:** `VEHICLE`
- **Hash:** `0x1CF38D529D7441D9`
- **JHash:** `0xDF594D8D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_STAYS_FROZEN_WHEN_CLEANED_UP(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Has something to do with trains. Always precedes SET_MISSION_TRAIN_AS_NO_LONGER_NEEDED.
May be true that it can be used with trains not sure, but not specifically for trains. Go find Xbox360 decompiled scripts and search for 'func_1333' in freemode.c it isn't used just for trains. Thanks for the info tho.
```

---

### SET_VEHICLE_STEERING_BIAS_SCALAR

- **命名空间:** `VEHICLE`
- **Hash:** `0x9007A2F21DC108D4`
- **JHash:** `0x585E49B6`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_STEERING_BIAS_SCALAR(object p0, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_STEER_BIAS

- **命名空间:** `VEHICLE`
- **Hash:** `0x42A8EC77D5150CBE`
- **JHash:** `0x7357C1EB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_STEER_BIAS(int vehicle, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Locks the vehicle's steering to the desired angle, explained below.

Requires to be called onTick. Steering is unlocked the moment the function stops being called on the vehicle.

Steer bias:
-1.0 = full right
0.0 = centered steering
1.0 = full left
```

---

### SET_VEHICLE_STEER_FOR_BUILDINGS

- **命名空间:** `VEHICLE`
- **Hash:** `0xDCE97BDF8A0EABC8`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_VEHICLE_STEER_FOR_BUILDINGS(int vehicle, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_STOP_INSTANTLY_WHEN_PLAYER_INACTIVE

- **命名空间:** `VEHICLE`
- **Hash:** `0x6EBFB22D646FFC18`
- **JHash:** `0x847F1304`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_STOP_INSTANTLY_WHEN_PLAYER_INACTIVE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
sfink: sets bit in vehicle's structure, used by maintransition, fm_mission_controller, mission_race and a couple of other scripts. see dissassembly: 
CVehicle *__fastcall sub_140CDAA10(signed int a1, char a2)
{
    CVehicle *result; // rax@1

    result = EntityAsCVehicle(a1);
    if ( result )
    {
        result->field_886 &= 0xEFu;
        result->field_886 |= 16 * (a2 & 1);
    }
    return result;
}
```

---

### SET_VEHICLE_STRONG

- **命名空间:** `VEHICLE`
- **Hash:** `0x3E8C8727991A8A0B`
- **JHash:** `0xC758D19F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_STRONG(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
If set to true, vehicle will not take crash damage, but is still susceptible to damage from bullets and explosives
```

---

### SET_VEHICLE_TAIL_BROKEN

- **命名空间:** `VEHICLE`
- **Hash:** `0x6CB5B84B78AC55FE`
- **Build:** `3717`

**C# 签名:**
```csharp
void SET_VEHICLE_TAIL_BROKEN(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_TAIL_LIGHTS

- **命名空间:** `VEHICLE`
- **Hash:** `0x5815BD2763178DF4`
- **Build:** `2802`

**C# 签名:**
```csharp
void SET_VEHICLE_TAIL_LIGHTS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_TANK_STATIONARY

- **命名空间:** `VEHICLE`
- **Hash:** `0x737E398138550FFF`
- **Build:** `944`

**C# 签名:**
```csharp
void SET_VEHICLE_TANK_STATIONARY(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_TANK_TURRET_POSITION

- **命名空间:** `VEHICLE`
- **Hash:** `0x56B94C6D7127DFBA`
- **JHash:** `0xB1A52EF7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_TANK_TURRET_POSITION(int vehicle, float position, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `position` | `float` | `float` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_TIMED_EXPLOSION

- **命名空间:** `VEHICLE`
- **Hash:** `0x2E0A74E1002380B1`
- **JHash:** `0xDB8CB8E2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_TIMED_EXPLOSION(int vehicle, int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_TOW_TRUCK_ARM_POSITION

- **命名空间:** `VEHICLE`
- **Hash:** `0xFE54B92A344583CA`
- **JHash:** `0x88236E22`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_TOW_TRUCK_ARM_POSITION(int vehicle, float position)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `position` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets how much the crane on the tow truck is raised, where 0.0 is fully lowered and 1.0 is fully raised.
```

---

### SET_VEHICLE_TURRET_SPEED_THIS_FRAME

- **命名空间:** `VEHICLE`
- **Hash:** `0x1093408B4B9D1146`
- **JHash:** `0xF30C566F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_TURRET_SPEED_THIS_FRAME(int vehicle, float speed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `speed` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_TURRET_TARGET

- **命名空间:** `VEHICLE`
- **Hash:** `0x0581730AB9380412`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_VEHICLE_TURRET_TARGET(int vehicle, bool p1, float x, float y, float z, bool p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p5` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_TYRES_CAN_BURST

- **命名空间:** `VEHICLE`
- **Hash:** `0xEB9DC3C7D8596C46`
- **JHash:** `0xA198DB54`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_TYRES_CAN_BURST(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Allows you to toggle bulletproof tires.
```

---

### SET_VEHICLE_TYRE_BURST

- **命名空间:** `VEHICLE`
- **Hash:** `0xEC6A202EE4960385`
- **JHash:** `0x89D28068`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_TYRE_BURST(int vehicle, int index, bool onRim, float p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `index` | `int` | `int` | - |
| `onRim` | `BOOL` | `bool` | - |
| `p3` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
"To burst tyres VEHICLE::SET_VEHICLE_TYRE_BURST(vehicle, 0, true, 1000.0)
to burst all tyres type it 8 times where p1 = 0 to 7.

p3 seems to be how much damage it has taken. 0 doesn't deflate them, 1000 completely deflates them.

'0 = wheel_lf / bike, plane or jet front
'1 = wheel_rf
'2 = wheel_lm / in 6 wheels trailer, plane or jet is first one on left
'3 = wheel_rm / in 6 wheels trailer, plane or jet is first one on right
'4 = wheel_lr / bike rear / in 6 wheels trailer, plane or jet is last one on left
'5 = wheel_rr / in 6 wheels trailer, plane or jet is last one on right
'45 = 6 wheels trailer mid wheel left
'47 = 6 wheels trailer mid wheel right
```

---

### SET_VEHICLE_TYRE_FIXED

- **命名空间:** `VEHICLE`
- **Hash:** `0x6E13FC662B882D1D`
- **JHash:** `0xA42EFA6B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_TYRE_FIXED(int vehicle, int tyreIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `tyreIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
tyreIndex = 0 to 4 on normal vehicles

'0 = wheel_lf / bike, plane or jet front
'1 = wheel_rf
'2 = wheel_lm / in 6 wheels trailer, plane or jet is first one on left
'3 = wheel_rm / in 6 wheels trailer, plane or jet is first one on right
'4 = wheel_lr / bike rear / in 6 wheels trailer, plane or jet is last one on left
'5 = wheel_rr / in 6 wheels trailer, plane or jet is last one on right
'45 = 6 wheels trailer mid wheel left
'47 = 6 wheels trailer mid wheel right
```

---

### SET_VEHICLE_TYRE_SMOKE_COLOR

- **命名空间:** `VEHICLE`
- **Hash:** `0xB5BA80F839791C0F`
- **JHash:** `0x3EDEC0DB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_TYRE_SMOKE_COLOR(int vehicle, int r, int g, int b)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `r` | `int` | `int` | - |
| `g` | `int` | `int` | - |
| `b` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the tire smoke's color of this vehicle.

vehicle: The vehicle that is the target of this method.
r: The red level in the RGB color code.
g: The green level in the RGB color code.
b: The blue level in the RGB color code.

Note: setting r,g,b to 0 will give the car the "Patriot" tire smoke.
```

---

### SET_VEHICLE_UNDRIVEABLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x8ABA6AF54B942B95`
- **JHash:** `0x48D02A4E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_UNDRIVEABLE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_USED_FOR_PILOT_SCHOOL

- **命名空间:** `VEHICLE`
- **Hash:** `0xE05DD0E9707003A3`
- **JHash:** `0x123E5B90`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_USED_FOR_PILOT_SCHOOL(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_USES_LARGE_REAR_RAMP

- **命名空间:** `VEHICLE`
- **Hash:** `0xCAC66558B944DA67`
- **JHash:** `0x0B200CE2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_USES_LARGE_REAR_RAMP(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
vehicle must be a plane
```

---

### SET_VEHICLE_USES_MP_PLAYER_DAMAGE_MULTIPLIER

- **命名空间:** `VEHICLE`
- **Hash:** `0xBB2333BB87DDD87F`
- **Build:** `757`

**C# 签名:**
```csharp
void SET_VEHICLE_USES_MP_PLAYER_DAMAGE_MULTIPLIER(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_USE_ALTERNATE_HANDLING

- **命名空间:** `VEHICLE`
- **Hash:** `0x1D97D1E3A70A649F`
- **JHash:** `0xA03E42DF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_USE_ALTERNATE_HANDLING(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_USE_BOOST_BUTTON_FOR_WHEEL_RETRACT

- **命名空间:** `VEHICLE`
- **Hash:** `0x41290B40FA63E6DA`
- **Build:** `1011`

**C# 签名:**
```csharp
void SET_VEHICLE_USE_BOOST_BUTTON_FOR_WHEEL_RETRACT(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Used for blazer5. Changes the quadbike-jetski transformation input from raise/lower convertible roof (hold H by default) to horn (press E by default.)
```

---

### SET_VEHICLE_USE_CUTSCENE_WHEEL_COMPRESSION

- **命名空间:** `VEHICLE`
- **Hash:** `0xE023E8AC4EF7C117`
- **JHash:** `0xA0909ADB`
- **Build:** `323`

**C# 签名:**
```csharp
bool SET_VEHICLE_USE_CUTSCENE_WHEEL_COMPRESSION(int p0, bool p1, bool p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### SET_VEHICLE_USE_MORE_RESTRICTIVE_SPAWN_CHECKS

- **命名空间:** `VEHICLE`
- **Hash:** `0x88BC673CA9E0AE99`
- **JHash:** `0xF0E5C41D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_USE_MORE_RESTRICTIVE_SPAWN_CHECKS(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_USE_PLAYER_LIGHT_SETTINGS

- **命名空间:** `VEHICLE`
- **Hash:** `0xC45C27EF50F36ADC`
- **JHash:** `0x4221E435`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_USE_PLAYER_LIGHT_SETTINGS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_WEAPON_CAN_TARGET_OBJECTS

- **命名空间:** `VEHICLE`
- **Hash:** `0x86B4B6212CB8B627`
- **Build:** `1011`

**C# 签名:**
```csharp
void SET_VEHICLE_WEAPON_CAN_TARGET_OBJECTS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_WEAPON_DAMAGE_SCALE

- **命名空间:** `VEHICLE`
- **Hash:** `0x45A561A9421AB6AD`
- **Build:** `944`

**C# 签名:**
```csharp
bool SET_VEHICLE_WEAPON_DAMAGE_SCALE(int vehicle, float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `multiplier` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### SET_VEHICLE_WEAPON_RESTRICTED_AMMO

- **命名空间:** `VEHICLE`
- **Hash:** `0x44CD1F493DB2A0A6`
- **Build:** `944`

**C# 签名:**
```csharp
void SET_VEHICLE_WEAPON_RESTRICTED_AMMO(int vehicle, int weaponIndex, int capacity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `weaponIndex` | `int` | `int` | - |
| `capacity` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Set vehicle's primary mounted weapon 2 ammo. For example, use it on APC.
For example, you can "remove" any vehicle weapon from any vehicle.
ammoAmount -1 = infinite ammo (default value for any spawned vehicle tho)
```

---

### SET_VEHICLE_WHEELS_CAN_BREAK

- **命名空间:** `VEHICLE`
- **Hash:** `0x29B18B4FD460CA8F`
- **JHash:** `0x829ED654`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_WHEELS_CAN_BREAK(int vehicle, bool enabled)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `enabled` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_WHEELS_CAN_BREAK_OFF_WHEN_BLOW_UP

- **命名空间:** `VEHICLE`
- **Hash:** `0xA37B9A517B133349`
- **JHash:** `0x670913A4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_WHEELS_CAN_BREAK_OFF_WHEN_BLOW_UP(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_WHEEL_TYPE

- **命名空间:** `VEHICLE`
- **Hash:** `0x487EB21CC7295BA1`
- **JHash:** `0x64BDAAAD`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_WHEEL_TYPE(int vehicle, int WheelType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `WheelType` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
0: Sport
1: Muscle
2: Lowrider
3: SUV
4: Offroad
5: Tuner
6: Bike Wheels
7: High End
8: Benny's Originals
9: Benny's Bespoke
10: Racing
11: Street
12: Track
```

---

### SET_VEHICLE_WILL_FORCE_OTHER_VEHICLES_TO_STOP

- **命名空间:** `VEHICLE`
- **Hash:** `0xBE5C1255A1830FF5`
- **JHash:** `0xA6D8D7A5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_WILL_FORCE_OTHER_VEHICLES_TO_STOP(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_WILL_TELL_OTHERS_TO_HURRY

- **命名空间:** `VEHICLE`
- **Hash:** `0x2C4A1590ABF43E8B`
- **JHash:** `0x2EC19A8B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_WILL_TELL_OTHERS_TO_HURRY(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_WINDOW_TINT

- **命名空间:** `VEHICLE`
- **Hash:** `0x57C51E6BAD752696`
- **JHash:** `0x497C8787`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_WINDOW_TINT(int vehicle, int tint)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `tint` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
enum WindowTints
{
 WINDOWTINT_NONE,
  WINDOWTINT_PURE_BLACK,
    WINDOWTINT_DARKSMOKE,
 WINDOWTINT_LIGHTSMOKE,
    WINDOWTINT_STOCK,
 WINDOWTINT_LIMO,
  WINDOWTINT_GREEN
};
Full list of all vehicle window tints by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicleColors.json
```

---

### SET_VEHICLE_XENON_LIGHT_COLOR_INDEX

- **命名空间:** `VEHICLE`
- **Hash:** `0xE41033B25D003A07`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_VEHICLE_XENON_LIGHT_COLOR_INDEX(int vehicle, int colorIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `colorIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
`color`: is the paint index for the vehicle.
Paint index goes from 0 to 12.
Be aware that it only works on xenon lights. Example: https://i.imgur.com/yV3cpG9.png
Full list of all vehicle xenon lights by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicleColors.json
```

---

### SET_WHEELIE_ENABLED

- **命名空间:** `VEHICLE`
- **Hash:** `0x1312DDD8385AEE4E`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_WHEELIE_ENABLED(int vehicle, bool enabled)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `enabled` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Enables/disables the ability to wheelie on motorcycles.
```

---

### SET_WHEELS_EXTENDED_INSTANTLY

- **命名空间:** `VEHICLE`
- **Hash:** `0xF660602546D27BA8`
- **Build:** `944`

**C# 签名:**
```csharp
void SET_WHEELS_EXTENDED_INSTANTLY(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_WHEELS_RETRACTED_INSTANTLY

- **命名空间:** `VEHICLE`
- **Hash:** `0x5335BE58C083E74E`
- **Build:** `1011`

**C# 签名:**
```csharp
void SET_WHEELS_RETRACTED_INSTANTLY(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SKIP_TIME_IN_PLAYBACK_RECORDED_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x9438F7AD68771A20`
- **JHash:** `0xCF3EFA4B`
- **Build:** `323`

**C# 签名:**
```csharp
void SKIP_TIME_IN_PLAYBACK_RECORDED_VEHICLE(int vehicle, float time)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `time` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
SET_TIME_POSITION_IN_RECORDING can be emulated by: desired_time - GET_TIME_POSITION_IN_RECORDING(vehicle)
```

---

### SKIP_TO_END_AND_STOP_PLAYBACK_RECORDED_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0xAB8E2EDA0C0A5883`
- **JHash:** `0x8DEA18C8`
- **Build:** `323`

**C# 签名:**
```csharp
void SKIP_TO_END_AND_STOP_PLAYBACK_RECORDED_VEHICLE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SMASH_VEHICLE_WINDOW

- **命名空间:** `VEHICLE`
- **Hash:** `0x9E5B5E4D2CCD2259`
- **JHash:** `0xDDD9A8C2`
- **Build:** `323`

**C# 签名:**
```csharp
void SMASH_VEHICLE_WINDOW(int vehicle, int windowIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `windowIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
windowIndex:
0 = Front Left Window
1 = Front Right Window
2 = Rear Left Window
3 = Rear Right Window
4 = Front Windscreen
5 = Rear Windscreen
6 = Mid Left
7 = Mid Right
8 = Invalid
```

---

### STABILISE_ENTITY_ATTACHED_TO_HELI

- **命名空间:** `VEHICLE`
- **Hash:** `0x374706271354CB18`
- **JHash:** `0x40C4763F`
- **Build:** `323`

**C# 签名:**
```csharp
void STABILISE_ENTITY_ATTACHED_TO_HELI(int vehicle, int entity, float p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `entity` | `Entity` | `int` | - |
| `p2` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### START_PLAYBACK_RECORDED_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x3F878F92B3A7A071`
- **JHash:** `0xCF614CA8`
- **Build:** `323`

**C# 签名:**
```csharp
void START_PLAYBACK_RECORDED_VEHICLE(int vehicle, int recording, string script, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `recording` | `int` | `int` | - |
| `script` | `const char*` | `string` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p3 is some flag related to 'trailers' (invokes CVehicle::GetTrailer).

See REQUEST_VEHICLE_RECORDING
```

---

### START_PLAYBACK_RECORDED_VEHICLE_USING_AI

- **命名空间:** `VEHICLE`
- **Hash:** `0x29DE5FA52D00428C`
- **JHash:** `0x8DE8E24E`
- **Build:** `323`

**C# 签名:**
```csharp
void START_PLAYBACK_RECORDED_VEHICLE_USING_AI(int vehicle, int recording, string script, float speed, int drivingStyle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `recording` | `int` | `int` | - |
| `script` | `const char*` | `string` | - |
| `speed` | `float` | `float` | - |
| `drivingStyle` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
AI abides by the provided driving style (e.g., stopping at red lights or waiting behind traffic) while executing the specificed vehicle recording.

FORCE_PLAYBACK_RECORDED_VEHICLE_UPDATE is a related native that deals with the AI physics for such recordings.
```

---

### START_PLAYBACK_RECORDED_VEHICLE_WITH_FLAGS

- **命名空间:** `VEHICLE`
- **Hash:** `0x7D80FD645D4DA346`
- **JHash:** `0x4E721AD2`
- **Build:** `323`

**C# 签名:**
```csharp
void START_PLAYBACK_RECORDED_VEHICLE_WITH_FLAGS(int vehicle, int recording, string script, int flags, int time, int drivingStyle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `recording` | `int` | `int` | - |
| `script` | `const char*` | `string` | - |
| `flags` | `int` | `int` | - |
| `time` | `int` | `int` | - |
| `drivingStyle` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
flags requires further research, e.g., 0x4/0x8 are related to the AI driving task and 0x20 is internally set and interacts with dynamic entity components.

time, often zero and capped at 500, is related to SET_PLAYBACK_TO_USE_AI_TRY_TO_REVERT_BACK_LATER
```

---

### START_VEHICLE_ALARM

- **命名空间:** `VEHICLE`
- **Hash:** `0xB8FF7AB45305C345`
- **JHash:** `0x5B451FF7`
- **Build:** `323`

**C# 签名:**
```csharp
void START_VEHICLE_ALARM(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### START_VEHICLE_HORN

- **命名空间:** `VEHICLE`
- **Hash:** `0x9C8C6504B5B63D2C`
- **JHash:** `0x0DF5ADB3`
- **Build:** `323`

**C# 签名:**
```csharp
void START_VEHICLE_HORN(int vehicle, int duration, uint mode, bool forever)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `duration` | `int` | `int` | - |
| `mode` | `Hash` | `uint` | - |
| `forever` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sounds the horn for the specified vehicle.

vehicle: The vehicle to activate the horn for.
mode: The hash of "NORMAL" or "HELDDOWN". Can be 0.
duration: The duration to sound the horn, in milliseconds.

Note: If a player is in the vehicle, it will only sound briefly.
```

---

### STOP_ALL_GARAGE_ACTIVITY

- **命名空间:** `VEHICLE`
- **Hash:** `0x0F87E938BDF29D66`
- **JHash:** `0x17A0BCE5`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_ALL_GARAGE_ACTIVITY()
```

**返回值:** `void` (Native: `void`)

---

### STOP_BRINGING_VEHICLE_TO_HALT

- **命名空间:** `VEHICLE`
- **Hash:** `0x7C06330BFDDA182E`
- **Build:** `1103`

**C# 签名:**
```csharp
void STOP_BRINGING_VEHICLE_TO_HALT(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Stops CTaskBringVehicleToHalt
```

---

### STOP_PLAYBACK_RECORDED_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x54833611C17ABDEA`
- **JHash:** `0xAE99C57C`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_PLAYBACK_RECORDED_VEHICLE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SUPPRESS_NEONS_ON_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x83F813570FF519DE`
- **Build:** `573`

**C# 签名:**
```csharp
void SUPPRESS_NEONS_ON_VEHICLE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SWING_BOAT_BOOM_FREELY

- **命名空间:** `VEHICLE`
- **Hash:** `0xC1F981A6F74F0C23`
- **JHash:** `0x00966934`
- **Build:** `323`

**C# 签名:**
```csharp
void SWING_BOAT_BOOM_FREELY(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Same call as ALLOW_BOAT_BOOM_TO_ANIMATE
```

---

### SWING_BOAT_BOOM_TO_RATIO

- **命名空间:** `VEHICLE`
- **Hash:** `0xF488C566413B4232`
- **JHash:** `0xA25CCB8C`
- **Build:** `323`

**C# 签名:**
```csharp
void SWING_BOAT_BOOM_TO_RATIO(int vehicle, float ratio)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `ratio` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the boat boom position for the `TR3` trailer.
Ratio value is between `0.0` and `1.0`, where `0.0` is 90 degrees to the left of the boat, and `1.0` is just slightly to the right/back of the boat.
To get the current boom position ratio, use GET_BOAT_BOOM_POSITION_RATIO
```

---

### SWITCH_TRAIN_TRACK

- **命名空间:** `VEHICLE`
- **Hash:** `0xFD813BB7DB977F20`
- **JHash:** `0x68BFDD61`
- **Build:** `323`

**C# 签名:**
```csharp
void SWITCH_TRAIN_TRACK(int trackId, bool state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `trackId` | `int` | `int` | - |
| `state` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Toggles whether ambient trains can spawn on the specified track or not

`trackId` is the internal id of the train track to switch.
`state` is whether ambient trains can spawn or not

trackIds
0 (`trains1.dat`) Main track around SA
1 (`trains2.dat`) Davis Quartz Quarry branch
2 (`trains3.dat`) Second track alongside live track along Roy Lewenstein Blv.
3 (`trains4.dat`) Metro track circuit
4 (`trains5.dat`) Branch in Mirror Park Railyard
5 (`trains6.dat`) Branch in Mirror Park Railyard
6 (`trains7.dat`) LS branch to Mirror Park Railyard
7 (`trains8.dat`) Overground part of metro track along Forum Dr.
8 (`trains9.dat`) Branch to Mirror Park Railyard
9 (`trains10.dat`) Yankton train
10 (`trains11.dat`) Part of metro track near mission row
11 (`trains12.dat`) Yankton prologue mission train
Full list of all train tracks + track nodes by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/traintracks.json
```

---

### TOGGLE_VEHICLE_MOD

- **命名空间:** `VEHICLE`
- **Hash:** `0x2A1F4F37F95BAD08`
- **JHash:** `0xD095F811`
- **Build:** `323`

**C# 签名:**
```csharp
void TOGGLE_VEHICLE_MOD(int vehicle, int modType, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `modType` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Toggles:
UNK17 - 17
Turbo - 18
UNK19 - 19
Tire Smoke - 20
UNK21 - 21
Xenon Headlights - 22
```

---

### TRACK_VEHICLE_VISIBILITY

- **命名空间:** `VEHICLE`
- **Hash:** `0x64473AEFDCF47DCA`
- **JHash:** `0x78122DC1`
- **Build:** `323`

**C# 签名:**
```csharp
void TRACK_VEHICLE_VISIBILITY(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
in script hook .net 

Vehicle v = ...;
Function.Call(Hash.TRACK_VEHICLE_VISIBILITY, v.Handle);
```

---

### TRANSFORM_TO_CAR

- **命名空间:** `VEHICLE`
- **Hash:** `0x2A69FFD1B42BFF9E`
- **JHash:** `0xD8B90941`
- **Build:** `1290`

**C# 签名:**
```csharp
void TRANSFORM_TO_CAR(int vehicle, bool noAnimation)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `noAnimation` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Transforms the `stormberg`/`toreador` to its "road vehicle" variant. If the vehicle is already in that state then the vehicle transformation audio will still play, but the vehicle won't change at all.
```

---

### TRANSFORM_TO_SUBMARINE

- **命名空间:** `VEHICLE`
- **Hash:** `0xBE4C854FFDB6EEBE`
- **JHash:** `0xCAFE5FE0`
- **Build:** `1365`

**C# 签名:**
```csharp
bool TRANSFORM_TO_SUBMARINE(int vehicle, bool noAnimation)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `noAnimation` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Transforms the `stormberg`/`toreador` to its "submarine" variant. If the vehicle is already in that state then the vehicle transformation audio will still play, but the vehicle won't change at all.
```

---

### UNPAUSE_PLAYBACK_RECORDED_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x8879EE09268305D5`
- **JHash:** `0x59060F75`
- **Build:** `323`

**C# 签名:**
```csharp
void UNPAUSE_PLAYBACK_RECORDED_VEHICLE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### VEHICLE_SET_ENABLE_NORMALISE_RAMP_CAR_VERTICAL_VELOCTIY

- **命名空间:** `VEHICLE`
- **Hash:** `0x756AE6E962168A04`
- **Build:** `944`

**C# 签名:**
```csharp
void VEHICLE_SET_ENABLE_NORMALISE_RAMP_CAR_VERTICAL_VELOCTIY(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### VEHICLE_SET_ENABLE_RAMP_CAR_SIDE_IMPULSE

- **命名空间:** `VEHICLE`
- **Hash:** `0x1BBAC99C0BC53656`
- **Build:** `944`

**C# 签名:**
```csharp
void VEHICLE_SET_ENABLE_RAMP_CAR_SIDE_IMPULSE(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### VEHICLE_SET_EXTENABLE_SIDE_TARGET_RATIO

- **命名空间:** `VEHICLE`
- **Hash:** `0xF3B0E0AED097A3F5`
- **Build:** `1103`

**C# 签名:**
```csharp
int VEHICLE_SET_EXTENABLE_SIDE_TARGET_RATIO(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### VEHICLE_SET_JET_WASH_FORCE_ENABLED

- **命名空间:** `VEHICLE`
- **Hash:** `0x9D30687C57BAA0BB`
- **Build:** `1011`

**C# 签名:**
```csharp
void VEHICLE_SET_JET_WASH_FORCE_ENABLED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### VEHICLE_SET_OVERRIDE_EXTENABLE_SIDE_RATIO

- **命名空间:** `VEHICLE`
- **Hash:** `0x0419B167EE128F33`
- **Build:** `1103`

**C# 签名:**
```csharp
int VEHICLE_SET_OVERRIDE_EXTENABLE_SIDE_RATIO(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### VEHICLE_SET_OVERRIDE_SIDE_RATIO

- **命名空间:** `VEHICLE`
- **Hash:** `0xD3E51C0AB8C26EEE`
- **Build:** `1103`

**C# 签名:**
```csharp
int VEHICLE_SET_OVERRIDE_SIDE_RATIO(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### VEHICLE_SET_PARACHUTE_MODEL_OVERRIDE

- **命名空间:** `VEHICLE`
- **Hash:** `0x4D610C6B56031351`
- **Build:** `1011`

**C# 签名:**
```csharp
void VEHICLE_SET_PARACHUTE_MODEL_OVERRIDE(int vehicle, uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Parachute models:
- sr_prop_specraces_para_s_01
- imp_prop_impexp_para_s (SecuroServ; Default)
Plus, many more props can be used as vehicle parachutes, like umbrellas (prop_beach_parasol_03), and unlike SET_PLAYER_PARACHUTE_MODEL_OVERRIDE, you won't get stuck mid-air when using an umbrella.
```

---

### VEHICLE_SET_PARACHUTE_MODEL_TINT_INDEX

- **命名空间:** `VEHICLE`
- **Hash:** `0xA74AD2439468C883`
- **Build:** `1011`

**C# 签名:**
```csharp
void VEHICLE_SET_PARACHUTE_MODEL_TINT_INDEX(int vehicle, int textureVariation)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `textureVariation` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Variations available for the generic parachute (sr_prop_specraces_para_s_01):
- 0: Rainbow
- 1: Red
- 2: White, blue, yellow
- 3: Black, red, white
- 4: Red, white, blue
- 5: Blue
- 6: Black
- 7: Black, yellow
```

---

### VEHICLE_SET_RAMP_AND_RAMMING_CARS_TAKE_DAMAGE

- **命名空间:** `VEHICLE`
- **Hash:** `0x28D034A93FE31BF5`
- **Build:** `944`

**C# 签名:**
```csharp
void VEHICLE_SET_RAMP_AND_RAMMING_CARS_TAKE_DAMAGE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### VEHICLE_START_PARACHUTING

- **命名空间:** `VEHICLE`
- **Hash:** `0x0BFFB028B3DD0A97`
- **Build:** `944`

**C# 签名:**
```csharp
void VEHICLE_START_PARACHUTING(int vehicle, bool active)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `active` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### _ARE_MISSILE_BAYS_DEPLOYED

- **命名空间:** `VEHICLE`
- **Hash:** `0xEA4743874D515F13`
- **Build:** `2944`

**C# 签名:**
```csharp
bool _ARE_MISSILE_BAYS_DEPLOYED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### _ENABLE_INDIVIDUAL_PLANE_PROPELLER

- **命名空间:** `VEHICLE`
- **Hash:** `0xDC05D2777F855F44`
- **Build:** `3407`

**C# 签名:**
```csharp
void _ENABLE_INDIVIDUAL_PLANE_PROPELLER(int vehicle, int propeller)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `propeller` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### _GET_IS_VEHICLE_ELECTRIC

- **命名空间:** `VEHICLE`
- **Hash:** `0x1FCB07FE230B6639`
- **Build:** `3258`

**C# 签名:**
```csharp
bool _GET_IS_VEHICLE_ELECTRIC(uint vehicleModel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicleModel` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### _GET_MISSION_TRAIN_CONFIG_INDEX_BY_NAME

- **命名空间:** `VEHICLE`
- **Hash:** `0x7DFAD92A34F09C00`
- **Build:** `3717`

**C# 签名:**
```csharp
int _GET_MISSION_TRAIN_CONFIG_INDEX_BY_NAME(string name)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |

**返回值:** `int` (Native: `int`)

---

### _GET_REMAINING_NITROUS_DURATION

- **命名空间:** `VEHICLE`
- **Hash:** `0xBEC4B8653462450E`
- **Build:** `3095`

**C# 签名:**
```csharp
float _GET_REMAINING_NITROUS_DURATION(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### _GET_VEHICLE_ALLOW_HOMING_MISSLE_LOCKON_SYNCED

- **命名空间:** `VEHICLE`
- **Hash:** `0x613A431BCD5A22EB`
- **Build:** `3717`

**C# 签名:**
```csharp
bool _GET_VEHICLE_ALLOW_HOMING_MISSLE_LOCKON_SYNCED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### _GET_VEHICLE_CURRENT_DRIVE_GEAR

- **命名空间:** `VEHICLE`
- **Hash:** `0x56185A25D45A0DCD`
- **Build:** `3095`

**C# 签名:**
```csharp
int _GET_VEHICLE_CURRENT_DRIVE_GEAR(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### _GET_VEHICLE_CURRENT_REV_RATIO

- **命名空间:** `VEHICLE`
- **Hash:** `0xF9DDA40BC293A61E`
- **Build:** `3095`

**C# 签名:**
```csharp
float _GET_VEHICLE_CURRENT_REV_RATIO(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### _GET_VEHICLE_DESIRED_DRIVE_GEAR

- **命名空间:** `VEHICLE`
- **Hash:** `0xFD8CE53356B5D745`
- **Build:** `3095`

**C# 签名:**
```csharp
int _GET_VEHICLE_DESIRED_DRIVE_GEAR(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### _GET_VEHICLE_DRIVETRAIN_TYPE

- **命名空间:** `VEHICLE`
- **Hash:** `0x1423725069EE1D14`
- **Build:** `3258`

**C# 签名:**
```csharp
int _GET_VEHICLE_DRIVETRAIN_TYPE(uint vehicleModel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicleModel` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns the vehicle's drivetrain type.

enum eVehicleDrivetrainType
{
	VehicleDrivetrainType_INVALID,
	VehicleDrivetrainType_FWD,
	VehicleDrivetrainType_RWD,
	VehicleDrivetrainType_AWD
};

_GET_VEHICLE_DE* - _GET_VEHICLE_DI*
```

---

### _GET_VEHICLE_EXHAUST_BONE

- **命名空间:** `VEHICLE`
- **Hash:** `0xE728F090D538CB18`
- **Build:** `3095`

**C# 签名:**
```csharp
bool _GET_VEHICLE_EXHAUST_BONE(int vehicle, int index, ref int boneIndex, ref bool axisX)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `index` | `int` | `int` | - |
| `boneIndex` | `int*` | `ref int` | - |
| `axisX` | `BOOL*` | `ref bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### _GET_VEHICLE_MAX_DRIVE_GEAR_COUNT

- **命名空间:** `VEHICLE`
- **Hash:** `0x24910C3D66BA770D`
- **Build:** `3095`

**C# 签名:**
```csharp
int _GET_VEHICLE_MAX_DRIVE_GEAR_COUNT(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### _GET_VEHICLE_MAX_EXHAUST_BONE_COUNT

- **命名空间:** `VEHICLE`
- **Hash:** `0x3EE18B00CD86C54F`
- **Build:** `3095`

**C# 签名:**
```csharp
int _GET_VEHICLE_MAX_EXHAUST_BONE_COUNT()
```

**返回值:** `int` (Native: `int`)

---

### _GET_VEHICLE_MODEL_NUM_DRIVE_GEARS

- **命名空间:** `VEHICLE`
- **Hash:** `0x61F02E4E9A7A61EA`
- **Build:** `3095`

**C# 签名:**
```csharp
int _GET_VEHICLE_MODEL_NUM_DRIVE_GEARS(uint vehicleModel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicleModel` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

---

### _GET_VEHICLE_THROTTLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x92D96892FC06AF22`
- **Build:** `3095`

**C# 签名:**
```csharp
float _GET_VEHICLE_THROTTLE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### _GET_VEHICLE_TRAILER_PARENT_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x80D9D32636369C92`
- **Build:** `2802`

**C# 签名:**
```csharp
int _GET_VEHICLE_TRAILER_PARENT_VEHICLE(int trailer)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `trailer` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `Vehicle`)

---

### _IS_VEHICLE_GEN9_EXCLUSIVE_MODEL

- **命名空间:** `VEHICLE`
- **Hash:** `0x6638C0F19DE692FE`
- **Build:** `3095`

**C# 签名:**
```csharp
bool _IS_VEHICLE_GEN9_EXCLUSIVE_MODEL(uint vehicleModel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicleModel` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### _IS_VEHICLE_ON_BOOST_PAD

- **命名空间:** `VEHICLE`
- **Hash:** `0x71C6302CBCA6CA35`
- **Build:** `3407`

**C# 签名:**
```csharp
bool _IS_VEHICLE_ON_BOOST_PAD(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### _SET_ALLOW_COLLISION_WHEN_IN_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x27D27223E8EF22ED`
- **Build:** `3095`

**C# 签名:**
```csharp
void _SET_ALLOW_COLLISION_WHEN_IN_VEHICLE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
_SET_ALLOW_R* - _SET_ALLOW_V*
```

---

### _SET_ATTACHED_VEHICLE_TO_TOW_TRUCK_ARM

- **命名空间:** `VEHICLE`
- **Hash:** `0x48BD57D0DD17786A`
- **Build:** `3095`

**C# 签名:**
```csharp
void _SET_ATTACHED_VEHICLE_TO_TOW_TRUCK_ARM(int towTruck, int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `towTruck` | `Vehicle` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### _SET_BOUNDS_AFFECT_WATER_PROBES

- **命名空间:** `VEHICLE`
- **Hash:** `0x85FC953F6C6CBDE1`
- **Build:** `2802`

**C# 签名:**
```csharp
void _SET_BOUNDS_AFFECT_WATER_PROBES(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Use the vehicle bounds (instead of viewport) when deciding if a vehicle is sufficiently above the water (waterheight.dat), bypassing wave simulation checks
```

---

### _SET_DEPLOY_MISSILE_BAYS

- **命名空间:** `VEHICLE`
- **Hash:** `0x0C02468829E4AA65`
- **Build:** `2944`

**C# 签名:**
```csharp
void _SET_DEPLOY_MISSILE_BAYS(int vehicle, bool deploy)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `deploy` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### _SET_DISABLE_EXPLODE_FROM_BODY_DAMAGE_RECEIVED_BY_AI_VEHICLE

- **命名空间:** `VEHICLE`
- **Hash:** `0xB0B7DF5CB876FF5E`
- **Build:** `3407`

**C# 签名:**
```csharp
void _SET_DISABLE_EXPLODE_FROM_BODY_DAMAGE_RECEIVED_BY_AI_VEHICLE(int vehicle, bool disable)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `disable` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Prevents the vehicle from exploding when taking body damage if the inflictor is an AI-controlled vehicle. Only works for planes.
```

---

### _SET_DRIFT_SLIP_ANGLE_LIMITS

- **命名空间:** `VEHICLE`
- **Hash:** `0xDAF4C98C18AC6F06`
- **Build:** `3095`

**C# 签名:**
```csharp
void _SET_DRIFT_SLIP_ANGLE_LIMITS(int vehicle, float durationScalar, float amplitudeScalar, float slipAngleLimit)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `durationScalar` | `float` | `float` | - |
| `amplitudeScalar` | `float` | `float` | - |
| `slipAngleLimit` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
First two floats relate to rumble, the last is a threshold
```

---

### _SET_MAKE_TRAIN_SCAN_FOR_BLOCKING_ENTITIES

- **命名空间:** `VEHICLE`
- **Hash:** `0x559B6073DB7FFFF9`
- **Build:** `3717`

**C# 签名:**
```csharp
void _SET_MAKE_TRAIN_SCAN_FOR_BLOCKING_ENTITIES(int train, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `train` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### _SET_MINIMUM_TIME_BETWEEN_GEAR_SHIFTS

- **命名空间:** `VEHICLE`
- **Hash:** `0x16CFBC5E7EB32861`
- **Build:** `3095`

**C# 签名:**
```csharp
void _SET_MINIMUM_TIME_BETWEEN_GEAR_SHIFTS(int vehicle, int time)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `time` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### _SET_NITROUS_IS_VISIBLE

- **命名空间:** `VEHICLE`
- **Hash:** `0x465EEA70AF251045`
- **Build:** `3095`

**C# 签名:**
```csharp
void _SET_NITROUS_IS_VISIBLE(int vehicle, bool enabled)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `enabled` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### _SET_OVERRIDE_TRACTION_LOSS_MULTIPLIER

- **命名空间:** `VEHICLE`
- **Hash:** `0xAFD262ACCA64479A`
- **Build:** `3095`

**C# 签名:**
```csharp
void _SET_OVERRIDE_TRACTION_LOSS_MULTIPLIER(int vehicle, float modifier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `modifier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### _SET_PLANE_AVOIDS_OTHERS

- **命名空间:** `VEHICLE`
- **Hash:** `0xBAFB99B304BC52A7`
- **Build:** `3407`

**C# 签名:**
```csharp
void _SET_PLANE_AVOIDS_OTHERS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### _SET_REMAINING_NITROUS_DURATION

- **命名空间:** `VEHICLE`
- **Hash:** `0x1AD0F63A94E10EFF`
- **Build:** `3407`

**C# 签名:**
```csharp
void _SET_REMAINING_NITROUS_DURATION(int vehicle, float duration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `duration` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### _SET_TRANSMISSION_REDUCED_GEAR_RATIO

- **命名空间:** `VEHICLE`
- **Hash:** `0x337EF33DA3DDB990`
- **Build:** `3095`

**C# 签名:**
```csharp
void _SET_TRANSMISSION_REDUCED_GEAR_RATIO(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### _SET_VEHICLE_EXPLOSIVE_DAMAGE_SCALE

- **命名空间:** `VEHICLE`
- **Hash:** `0x84D7FFD223CAAFFD`
- **Build:** `3407`

**C# 签名:**
```csharp
object _SET_VEHICLE_EXPLOSIVE_DAMAGE_SCALE(int vehicle, float scale)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `scale` | `float` | `float` | - |

**返回值:** `object` (Native: `Any`)

**说明:**
```
Does not actually return anything.
```

---

### _SET_VEHICLE_MAX_LAUNCH_ENGINE_REVS

- **命名空间:** `VEHICLE`
- **Hash:** `0x5AE614ECA5FDD423`
- **Build:** `3095`

**C# 签名:**
```csharp
void _SET_VEHICLE_MAX_LAUNCH_ENGINE_REVS(int vehicle, float modifier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `modifier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
0.0f = engine rev minimum
1.0f = engine rev limit
```

---

### _SET_VEHICLE_USE_HORN_BUTTON_FOR_NITROUS

- **命名空间:** `VEHICLE`
- **Hash:** `0x1980F68872CC2C3D`
- **Build:** `3095`

**C# 签名:**
```csharp
void _SET_VEHICLE_USE_HORN_BUTTON_FOR_NITROUS(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---
