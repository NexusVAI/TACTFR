# ENTITY - Native 函数参考

> 命名空间: ENTITY, OBJECT, ITEMSET

---

## 快速索引

| 函数名 | C# 签名 | 返回值 | 说明 |
|--------|---------|--------|------|
| `ADD_DOOR_TO_SYSTEM` | `void ADD_DOOR_TO_SYSTEM(uint doorHash, uint modelHash, float x, float y, float z, bool p5, bool scriptDoor, bool isLocal, object p8)` | void | doorHash has to be unique. scriptDoor false; relies upon getNetworkGameScriptHandler. isLocal On tru... |
| `ADD_EXTENDED_PICKUP_PROBE_AREA` | `void ADD_EXTENDED_PICKUP_PROBE_AREA(float x, float y, float z, float radius)` | void | Adds an area that seems to be related to pickup physics behavior.<br>Max amount of areas is 10. Only wo... |
| `ADD_TO_ITEMSET` | `bool ADD_TO_ITEMSET(int item, int itemset)` | bool | - |
| `ALLOW_ALL_PLAYERS_TO_COLLECT_PICKUPS_OF_TYPE` | `void ALLOW_ALL_PLAYERS_TO_COLLECT_PICKUPS_OF_TYPE(uint pickupHash)` | void | Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pi... |
| `ALLOW_DAMAGE_EVENTS_FOR_NON_NETWORKED_OBJECTS` | `void ALLOW_DAMAGE_EVENTS_FOR_NON_NETWORKED_OBJECTS(bool value)` | void | - |
| `ALLOW_PICKUP_ARROW_MARKER_WHEN_UNCOLLECTABLE` | `void ALLOW_PICKUP_ARROW_MARKER_WHEN_UNCOLLECTABLE(int pickup, bool toggle)` | void | - |
| `ALLOW_PICKUP_BY_NONE_PARTICIPANT` | `void ALLOW_PICKUP_BY_NONE_PARTICIPANT(int pickup, bool toggle)` | void | - |
| `ALLOW_PORTABLE_PICKUP_TO_MIGRATE_TO_NON_PARTICIPANTS` | `void ALLOW_PORTABLE_PICKUP_TO_MIGRATE_TO_NON_PARTICIPANTS(int pickup, bool toggle)` | void | - |
| `APPLY_FORCE_TO_ENTITY` | `void APPLY_FORCE_TO_ENTITY(int entity, int forceFlags, float x, float y, float z, float offX, float offY, float offZ, int boneIndex, bool isDirectionRel, bool ignoreUpVec, bool isForceRel, bool p12, bool p13)` | void | Documented here:<br>gtaforums.com/topic/885669-precisely-define-object-physics/<br>gtaforums.com/topic/887... |
| `APPLY_FORCE_TO_ENTITY_CENTER_OF_MASS` | `void APPLY_FORCE_TO_ENTITY_CENTER_OF_MASS(int entity, int forceType, float x, float y, float z, bool p5, bool isDirectionRel, bool isForceRel, bool p8)` | void | Applies a force to the specified entity.<br><br>**List of force types (p1)**:<br>public enum ForceType<br>{<br>    ... |
| `ARE_ENTITIES_ENTIRELY_INSIDE_GARAGE` | `bool ARE_ENTITIES_ENTIRELY_INSIDE_GARAGE(uint garageHash, bool p1, bool p2, bool p3, object p4)` | bool | - |
| `ATTACH_ENTITY_BONE_TO_ENTITY_BONE` | `void ATTACH_ENTITY_BONE_TO_ENTITY_BONE(int entity1, int entity2, int boneIndex1, int boneIndex2, bool p4, bool p5)` | void | - |
| `ATTACH_ENTITY_BONE_TO_ENTITY_BONE_Y_FORWARD` | `void ATTACH_ENTITY_BONE_TO_ENTITY_BONE_Y_FORWARD(int entity1, int entity2, int boneIndex1, int boneIndex2, bool p4, bool p5)` | void | - |
| `ATTACH_ENTITY_TO_ENTITY` | `void ATTACH_ENTITY_TO_ENTITY(int entity1, int entity2, int boneIndex, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, bool p9, bool useSoftPinning, bool collision, bool isPed, int vertexIndex, bool fixedRot, object p15)` | void | Attaches entity1 to bone (boneIndex) of entity2.<br><br>boneIndex - this is different to boneID, use GET_P... |
| `ATTACH_ENTITY_TO_ENTITY_PHYSICALLY` | `void ATTACH_ENTITY_TO_ENTITY_PHYSICALLY(int entity1, int entity2, int boneIndex1, int boneIndex2, float xPos1, float yPos1, float zPos1, float xPos2, float yPos2, float zPos2, float xRot, float yRot, float zRot, float breakForce, bool fixedRot, bool p15, bool collision, bool p17, int p18)` | void | breakForce is the amount of force required to break the bond.<br>p14 - is always 1 in scripts<br>p15 - is ... |
| `ATTACH_ENTITY_TO_ENTITY_PHYSICALLY_OVERRIDE_INVERSE_MASS` | `void ATTACH_ENTITY_TO_ENTITY_PHYSICALLY_OVERRIDE_INVERSE_MASS(int firstEntityIndex, int secondEntityIndex, int firstEntityBoneIndex, int secondEntityBoneIndex, float secondEntityOffsetX, float secondEntityOffsetY, float secondEntityOffsetZ, float firstEntityOffsetX, float firstEntityOffsetY, float firstEntityOffsetZ, float vecRotationX, float vecRotationY, float vecRotationZ, float physicalStrength, bool constrainRotation, bool doInitialWarp, bool collideWithEntity, bool addInitialSeperation, int rotOrder, float invMassScaleA, float invMassScaleB)` | void | - |
| `ATTACH_PORTABLE_PICKUP_TO_PED` | `void ATTACH_PORTABLE_PICKUP_TO_PED(int pickupObject, int ped)` | void | - |
| `BLOCK_PLAYERS_FOR_AMBIENT_PICKUP` | `void BLOCK_PLAYERS_FOR_AMBIENT_PICKUP(object p0, object p1)` | void | - |
| `BREAK_OBJECT_FRAGMENT_CHILD` | `void BREAK_OBJECT_FRAGMENT_CHILD(int p0, object p1, bool p2)` | void | - |
| `CLEAN_ITEMSET` | `void CLEAN_ITEMSET(int itemset)` | void | - |
| `CLEAR_ALL_PICKUP_REWARD_TYPE_SUPPRESSION` | `void CLEAR_ALL_PICKUP_REWARD_TYPE_SUPPRESSION()` | void | - |
| `CLEAR_ENTITY_LAST_DAMAGE_ENTITY` | `void CLEAR_ENTITY_LAST_DAMAGE_ENTITY(int entity)` | void | - |
| `CLEAR_EXTENDED_PICKUP_PROBE_AREAS` | `void CLEAR_EXTENDED_PICKUP_PROBE_AREAS()` | void | Clears all areas created by ADD_EXTENDED_PICKUP_PROBE_AREA |
| `CLEAR_GARAGE` | `void CLEAR_GARAGE(uint garageHash, bool isNetwork)` | void | - |
| `CLEAR_OBJECTS_INSIDE_GARAGE` | `void CLEAR_OBJECTS_INSIDE_GARAGE(uint garageHash, bool vehicles, bool peds, bool objects, bool isNetwork)` | void | - |
| `CLEAR_PICKUP_REWARD_TYPE_SUPPRESSION` | `void CLEAR_PICKUP_REWARD_TYPE_SUPPRESSION(int rewardType)` | void | - |
| `CLOSE_ALL_BARRIERS_FOR_RACE` | `void CLOSE_ALL_BARRIERS_FOR_RACE()` | void | Clears the fields sets by 0xC7F29CA00F46350E (1604 retail: 0x1424A7A10, 0x1424A7A11) and iterates ov... |
| `CLOSE_SAFEHOUSE_GARAGES` | `void CLOSE_SAFEHOUSE_GARAGES()` | void | - |
| `CONVERT_OLD_PICKUP_TYPE_TO_NEW` | `uint CONVERT_OLD_PICKUP_TYPE_TO_NEW(uint pickupHash)` | uint | returns pickup hash.<br><br>Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-dat... |
| `CREATE_AMBIENT_PICKUP` | `int CREATE_AMBIENT_PICKUP(uint pickupHash, float posX, float posY, float posZ, int flags, int value, uint modelHash, bool p7, bool p8)` | int | Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pi... |
| `CREATE_FORCED_OBJECT` | `void CREATE_FORCED_OBJECT(float x, float y, float z, object p3, uint modelHash, bool p5)` | void | - |
| `CREATE_ITEMSET` | `int CREATE_ITEMSET(bool p0)` | int | - |
| `CREATE_MODEL_HIDE` | `void CREATE_MODEL_HIDE(float x, float y, float z, float radius, uint modelHash, bool p5)` | void | p5 = sets as true in scripts<br>Same as the comment for CREATE_MODEL_SWAP unless for some reason p5 aff... |
| `CREATE_MODEL_HIDE_EXCLUDING_SCRIPT_OBJECTS` | `void CREATE_MODEL_HIDE_EXCLUDING_SCRIPT_OBJECTS(float x, float y, float z, float radius, uint modelHash, bool p5)` | void | - |
| `CREATE_MODEL_SWAP` | `void CREATE_MODEL_SWAP(float x, float y, float z, float radius, uint originalModel, uint newModel, bool p6)` | void | Only works with objects! |
| `CREATE_MONEY_PICKUPS` | `void CREATE_MONEY_PICKUPS(float x, float y, float z, int value, int amount, uint model)` | void | Spawns one or more money pickups.<br><br>x: The X-component of the world position to spawn the money picku... |
| `CREATE_NON_NETWORKED_AMBIENT_PICKUP` | `int CREATE_NON_NETWORKED_AMBIENT_PICKUP(uint pickupHash, float posX, float posY, float posZ, int flags, int value, uint modelHash, bool p7, bool p8)` | int | - |
| `CREATE_NON_NETWORKED_PORTABLE_PICKUP` | `int CREATE_NON_NETWORKED_PORTABLE_PICKUP(uint pickupHash, float x, float y, float z, bool placeOnGround, uint modelHash)` | int | Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pi... |
| `CREATE_OBJECT` | `int CREATE_OBJECT(uint modelHash, float x, float y, float z, bool isNetwork, bool bScriptHostObj, bool dynamic)` | int | List of object models that can be created without any additional effort like making sure ytyp is loa... |
| `CREATE_OBJECT_NO_OFFSET` | `int CREATE_OBJECT_NO_OFFSET(uint modelHash, float x, float y, float z, bool isNetwork, bool bScriptHostObj, bool dynamic, object p7)` | int | List of object models that can be created without any additional effort like making sure ytyp is loa... |
| `CREATE_PICKUP` | `int CREATE_PICKUP(uint pickupHash, float posX, float posY, float posZ, int p4, int value, bool p6, uint modelHash)` | int | Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pi... |
| `CREATE_PICKUP_ROTATE` | `int CREATE_PICKUP_ROTATE(uint pickupHash, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, int flag, int amount, object p9, bool p10, uint modelHash)` | int | flags:<br>8 (1 << 3): place on ground<br>512 (1 << 9): spin around<br><br>Full list of pickup types by DurtyFree... |
| `CREATE_PORTABLE_PICKUP` | `int CREATE_PORTABLE_PICKUP(uint pickupHash, float x, float y, float z, bool placeOnGround, uint modelHash)` | int | Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pi... |
| `DAMAGE_OBJECT_FRAGMENT_CHILD` | `void DAMAGE_OBJECT_FRAGMENT_CHILD(object p0, object p1, object p2)` | void | - |
| `DELETE_ENTITY` | `void DELETE_ENTITY(Entity* entity)` | void | Deletes the specified entity, then sets the handle pointed to by the pointer to NULL. |
| `DELETE_OBJECT` | `void DELETE_OBJECT(Object* object)` | void | Deletes the specified object, then sets the handle pointed to by the pointer to NULL. |
| `DESTROY_ITEMSET` | `void DESTROY_ITEMSET(int itemset)` | void | - |
| `DETACH_ENTITY` | `void DETACH_ENTITY(int entity, bool dynamic, bool collision)` | void | If `collision` is set to true, both entities won't collide with the other until the distance between... |
| `DETACH_PORTABLE_PICKUP_FROM_PED` | `void DETACH_PORTABLE_PICKUP_FROM_PED(int pickupObject)` | void | - |
| `DISABLE_TIDYING_UP_IN_GARAGE` | `void DISABLE_TIDYING_UP_IN_GARAGE(int id, bool toggle)` | void | Sets a flag. A valid id is 0x157DC10D |
| `DOES_ENTITY_BELONG_TO_THIS_SCRIPT` | `bool DOES_ENTITY_BELONG_TO_THIS_SCRIPT(int entity, bool p1)` | bool | - |
| `DOES_ENTITY_EXIST` | `bool DOES_ENTITY_EXIST(int entity)` | bool | Checks whether an entity exists in the game world. |
| `DOES_ENTITY_HAVE_ANIM_DIRECTOR` | `bool DOES_ENTITY_HAVE_ANIM_DIRECTOR(int entity)` | bool | - |
| `DOES_ENTITY_HAVE_DRAWABLE` | `bool DOES_ENTITY_HAVE_DRAWABLE(int entity)` | bool | - |
| `DOES_ENTITY_HAVE_PHYSICS` | `bool DOES_ENTITY_HAVE_PHYSICS(int entity)` | bool | - |
| `DOES_ENTITY_HAVE_SKELETON` | `bool DOES_ENTITY_HAVE_SKELETON(int entity)` | bool | - |
| `DOES_OBJECT_OF_TYPE_EXIST_AT_COORDS` | `bool DOES_OBJECT_OF_TYPE_EXIST_AT_COORDS(float x, float y, float z, float radius, uint hash, bool p5)` | bool | p5 is usually 0. |
| `DOES_PICKUP_EXIST` | `bool DOES_PICKUP_EXIST(int pickup)` | bool | - |
| `DOES_PICKUP_OBJECT_EXIST` | `bool DOES_PICKUP_OBJECT_EXIST(int pickupObject)` | bool | - |
| `DOES_PICKUP_OF_TYPE_EXIST_IN_AREA` | `bool DOES_PICKUP_OF_TYPE_EXIST_IN_AREA(uint pickupHash, float x, float y, float z, float radius)` | bool | Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pi... |
| `DOES_RAYFIRE_MAP_OBJECT_EXIST` | `bool DOES_RAYFIRE_MAP_OBJECT_EXIST(int object)` | bool | Returns true if a destructible object with this handle exists, false otherwise.   |
| `DOOR_SYSTEM_FIND_EXISTING_DOOR` | `bool DOOR_SYSTEM_FIND_EXISTING_DOOR(float x, float y, float z, uint modelHash, Hash* outDoorHash)` | bool | Search radius: 0.5 |
| `DOOR_SYSTEM_GET_AUTOMATIC_DISTANCE` | `float DOOR_SYSTEM_GET_AUTOMATIC_DISTANCE(uint doorHash)` | float | - |
| `DOOR_SYSTEM_GET_DOOR_PENDING_STATE` | `int DOOR_SYSTEM_GET_DOOR_PENDING_STATE(uint doorHash)` | int | - |
| `DOOR_SYSTEM_GET_DOOR_STATE` | `int DOOR_SYSTEM_GET_DOOR_STATE(uint doorHash)` | int | - |
| `DOOR_SYSTEM_GET_IS_PHYSICS_LOADED` | `bool DOOR_SYSTEM_GET_IS_PHYSICS_LOADED(object p0)` | bool | - |
| `DOOR_SYSTEM_GET_IS_SPRING_REMOVED` | `bool DOOR_SYSTEM_GET_IS_SPRING_REMOVED(uint doorHash)` | bool | - |
| `DOOR_SYSTEM_GET_OPEN_RATIO` | `float DOOR_SYSTEM_GET_OPEN_RATIO(uint doorHash)` | float | - |
| `DOOR_SYSTEM_SET_AUTOMATIC_DISTANCE` | `void DOOR_SYSTEM_SET_AUTOMATIC_DISTANCE(uint doorHash, float distance, bool requestDoor, bool forceUpdate)` | void | `forceUpdate` on true invokes DOOR_SYSTEM_SET_DOOR_STATE otherwise requestDoor is unused. |
| `DOOR_SYSTEM_SET_AUTOMATIC_RATE` | `void DOOR_SYSTEM_SET_AUTOMATIC_RATE(uint doorHash, float rate, bool requestDoor, bool forceUpdate)` | void | Includes networking check: ownership vs. or the door itself **isn't** networked.<br>`forceUpdate` on tr... |
| `DOOR_SYSTEM_SET_DOOR_OPEN_FOR_RACES` | `void DOOR_SYSTEM_SET_DOOR_OPEN_FOR_RACES(uint doorHash, bool p1)` | void | Some property related to gates. Native name between ``DOOR_SYSTEM_SET_AUTOMATIC_RATE`` and ``DOOR_SY... |
| `DOOR_SYSTEM_SET_DOOR_STATE` | `void DOOR_SYSTEM_SET_DOOR_STATE(uint doorHash, int state, bool requestDoor, bool forceUpdate)` | void | Lockstates not applied and CNetObjDoor's not created until DOOR_SYSTEM_GET_IS_PHYSICS_LOADED returns... |
| `DOOR_SYSTEM_SET_HOLD_OPEN` | `void DOOR_SYSTEM_SET_HOLD_OPEN(uint doorHash, bool toggle)` | void | Includes networking check: ownership vs. or the door itself **isn't** networked. |
| `DOOR_SYSTEM_SET_OPEN_RATIO` | `void DOOR_SYSTEM_SET_OPEN_RATIO(uint doorHash, float ajar, bool requestDoor, bool forceUpdate)` | void | Sets the ajar angle of a door.<br>Ranges from -1.0 to 1.0, and 0.0 is closed / default.<br>`forceUpdate` o... |
| `DOOR_SYSTEM_SET_SPRING_REMOVED` | `void DOOR_SYSTEM_SET_SPRING_REMOVED(uint doorHash, bool removed, bool requestDoor, bool forceUpdate)` | void | Includes networking check: ownership vs. or the door itself **isn't** networked.<br>`forceUpdate` on tr... |
| `ENABLE_ENTITY_BULLET_COLLISION` | `void ENABLE_ENTITY_BULLET_COLLISION(int entity)` | void | - |
| `ENABLE_SAVING_IN_GARAGE` | `void ENABLE_SAVING_IN_GARAGE(uint garageHash, bool toggle)` | void | - |
| `FIND_ANIM_EVENT_PHASE` | `bool FIND_ANIM_EVENT_PHASE(string animDictionary, string animName, string p2, ref object p3, ref object p4)` | bool | In the script "player_scene_t_bbfight.c4":<br>"if (ENTITY::FIND_ANIM_EVENT_PHASE(&l_16E, &l_19F[v_4/*16... |
| `FIX_OBJECT_FRAGMENT` | `void FIX_OBJECT_FRAGMENT(int object)` | void | - |
| `FORCE_ACTIVATE_PHYSICS_ON_UNFIXED_PICKUP` | `void FORCE_ACTIVATE_PHYSICS_ON_UNFIXED_PICKUP(int pickup, bool toggle)` | void | - |
| `FORCE_ENTITY_AI_AND_ANIMATION_UPDATE` | `void FORCE_ENTITY_AI_AND_ANIMATION_UPDATE(int entity)` | void | Based on carmod_shop script decompile this takes a vehicle parameter. It is called when repair is do... |
| `FORCE_PICKUP_REGENERATE` | `void FORCE_PICKUP_REGENERATE(object p0)` | void | - |
| `FORCE_PICKUP_ROTATE_FACE_UP` | `void FORCE_PICKUP_ROTATE_FACE_UP()` | void | - |
| `FORCE_PORTABLE_PICKUP_LAST_ACCESSIBLE_POSITION_SETTING` | `void FORCE_PORTABLE_PICKUP_LAST_ACCESSIBLE_POSITION_SETTING(int object)` | void | - |
| `FREEZE_ENTITY_POSITION` | `void FREEZE_ENTITY_POSITION(int entity, bool toggle)` | void | Freezes or unfreezes an entity preventing its coordinates to change by the player if set to `true`. ... |
| `GET_ANIM_DURATION` | `float GET_ANIM_DURATION(string animDict, string animName)` | float | Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-... |
| `GET_CLOSEST_OBJECT_OF_TYPE` | `int GET_CLOSEST_OBJECT_OF_TYPE(float x, float y, float z, float radius, uint modelHash, bool isMission, bool p6, bool p7)` | int | Has 8 params in the latest patches.<br><br>isMission - if true doesn't return mission objects |
| `GET_COLLISION_NORMAL_OF_LAST_HIT_FOR_ENTITY` | `Vector3 GET_COLLISION_NORMAL_OF_LAST_HIT_FOR_ENTITY(int entity)` | Vector3 | - |
| `GET_COORDS_AND_ROTATION_OF_CLOSEST_OBJECT_OF_TYPE` | `bool GET_COORDS_AND_ROTATION_OF_CLOSEST_OBJECT_OF_TYPE(float x, float y, float z, float radius, uint modelHash, ref Vector3 outPosition, ref Vector3 outRotation, int rotationOrder)` | bool | - |
| `GET_DEFAULT_AMMO_FOR_WEAPON_PICKUP` | `int GET_DEFAULT_AMMO_FOR_WEAPON_PICKUP(uint pickupHash)` | int | - |
| `GET_ENTITY_ALPHA` | `int GET_ENTITY_ALPHA(int entity)` | int | - |
| `GET_ENTITY_ANIM_CURRENT_TIME` | `float GET_ENTITY_ANIM_CURRENT_TIME(int entity, string animDict, string animName)` | float | Returns a float value representing animation's current playtime with respect to its total playtime. ... |
| `GET_ENTITY_ANIM_TOTAL_TIME` | `float GET_ENTITY_ANIM_TOTAL_TIME(int entity, string animDict, string animName)` | float | Returns a float value representing animation's total playtime in milliseconds.<br><br>Example:<br>GET_ENTITY_... |
| `GET_ENTITY_ATTACHED_TO` | `int GET_ENTITY_ATTACHED_TO(int entity)` | int | - |
| `GET_ENTITY_BONE_COUNT` | `int GET_ENTITY_BONE_COUNT(int entity)` | int | - |
| `GET_ENTITY_BONE_INDEX_BY_NAME` | `int GET_ENTITY_BONE_INDEX_BY_NAME(int entity, string boneName)` | int | Returns the index of the bone. If the bone was not found, -1 will be returned. <br><br>list:<br>https://paste... |
| `GET_ENTITY_BONE_OBJECT_POSTION` | `Vector3 GET_ENTITY_BONE_OBJECT_POSTION(int entity, int boneIndex)` | Vector3 | - |
| `GET_ENTITY_BONE_OBJECT_ROTATION` | `Vector3 GET_ENTITY_BONE_OBJECT_ROTATION(int entity, int boneIndex)` | Vector3 | Gets the local rotation of the specified bone of the specified entity. |
| `GET_ENTITY_BONE_POSTION` | `Vector3 GET_ENTITY_BONE_POSTION(int entity, int boneIndex)` | Vector3 | Gets the world position of the specified bone of the specified entity. |
| `GET_ENTITY_BONE_ROTATION` | `Vector3 GET_ENTITY_BONE_ROTATION(int entity, int boneIndex)` | Vector3 | Gets the world rotation of the specified bone of the specified entity. |
| `GET_ENTITY_CAN_BE_DAMAGED` | `bool GET_ENTITY_CAN_BE_DAMAGED(int entity)` | bool | - |
| `GET_ENTITY_COLLISION_DISABLED` | `bool GET_ENTITY_COLLISION_DISABLED(int entity)` | bool | - |
| `GET_ENTITY_COORDS` | `Vector3 GET_ENTITY_COORDS(int entity, bool alive)` | Vector3 | Gets the current coordinates for a specified entity.<br>`entity` = The entity to get the coordinates fr... |
| `GET_ENTITY_FORWARD_VECTOR` | `Vector3 GET_ENTITY_FORWARD_VECTOR(int entity)` | Vector3 | Gets the entity's forward vector. |
| `GET_ENTITY_FORWARD_X` | `float GET_ENTITY_FORWARD_X(int entity)` | float | Gets the X-component of the entity's forward vector. |
| `GET_ENTITY_FORWARD_Y` | `float GET_ENTITY_FORWARD_Y(int entity)` | float | Gets the Y-component of the entity's forward vector. |
| `GET_ENTITY_HEADING` | `float GET_ENTITY_HEADING(int entity)` | float | Returns the heading of the entity in degrees. Also know as the "Yaw" of an entity. |
| `GET_ENTITY_HEADING_FROM_EULERS` | `float GET_ENTITY_HEADING_FROM_EULERS(int entity)` | float | Gets the heading of the entity physics in degrees, which tends to be more accurate than just "GET_EN... |
| `GET_ENTITY_HEALTH` | `int GET_ENTITY_HEALTH(int entity)` | int | Returns an integer value of entity's current health.<br><br>Example of range for ped:<br>- Player [0 to 200]<br>... |
| `GET_ENTITY_HEIGHT` | `float GET_ENTITY_HEIGHT(int entity, float X, float Y, float Z, bool atTop, bool inWorldCoords)` | float | - |
| `GET_ENTITY_HEIGHT_ABOVE_GROUND` | `float GET_ENTITY_HEIGHT_ABOVE_GROUND(int entity)` | float | Return height (z-dimension) above ground. <br>Example: The pilot in a titan plane is 1.844176 above gro... |
| `GET_ENTITY_LOD_DIST` | `int GET_ENTITY_LOD_DIST(int entity)` | int | Returns the LOD distance of an entity. |
| `GET_ENTITY_MATRIX` | `void GET_ENTITY_MATRIX(int entity, ref Vector3 forwardVector, ref Vector3 rightVector, ref Vector3 upVector, ref Vector3 position)` | void | - |
| `GET_ENTITY_MAX_HEALTH` | `int GET_ENTITY_MAX_HEALTH(int entity)` | int | Return an integer value of entity's maximum health.<br><br>Example:<br>- Player = 200<br>- Ped = 150 |
| `GET_ENTITY_MODEL` | `uint GET_ENTITY_MODEL(int entity)` | uint | Returns the model hash from the entity |
| `GET_ENTITY_OF_TYPE_ATTACHED_TO_ENTITY` | `int GET_ENTITY_OF_TYPE_ATTACHED_TO_ENTITY(int entity, uint modelHash)` | int | Gets the handle of an entity with a specific model hash attached to another entity, such as an objec... |
| `GET_ENTITY_PITCH` | `float GET_ENTITY_PITCH(int entity)` | float | - |
| `GET_ENTITY_POPULATION_TYPE` | `int GET_ENTITY_POPULATION_TYPE(int entity)` | int | A population type, from the following enum: https://alloc8or.re/gta5/doc/enums/ePopulationType.txt |
| `GET_ENTITY_PROOFS` | `bool GET_ENTITY_PROOFS(int entity, ref bool bulletProof, ref bool fireProof, ref bool explosionProof, ref bool collisionProof, ref bool meleeProof, ref bool steamProof, ref bool p7, ref bool drownProof)` | bool | - |
| `GET_ENTITY_QUATERNION` | `void GET_ENTITY_QUATERNION(int entity, ref float x, ref float y, ref float z, ref float w)` | void | w is the correct parameter name! |
| `GET_ENTITY_ROLL` | `float GET_ENTITY_ROLL(int entity)` | float | Displays the current ROLL axis of the entity [-180.0000/180.0000+]<br>(Sideways Roll) such as a vehicle... |
| `GET_ENTITY_ROTATION` | `Vector3 GET_ENTITY_ROTATION(int entity, int rotationOrder)` | Vector3 | rotationOrder is the order yaw, pitch and roll is applied. Usually 2. Returns a vector where the Z c... |
| `GET_ENTITY_ROTATION_VELOCITY` | `Vector3 GET_ENTITY_ROTATION_VELOCITY(int entity)` | Vector3 | - |
| `GET_ENTITY_SCRIPT` | `string GET_ENTITY_SCRIPT(int entity, ScrHandle* script)` | string | Returns the name of the script that owns/created the entity or nullptr. Second parameter is unused, ... |
| `GET_ENTITY_SPEED` | `float GET_ENTITY_SPEED(int entity)` | float | result is in meters per second<br><br>------------------------------------------------------------<br>So woul... |
| `GET_ENTITY_SPEED_VECTOR` | `Vector3 GET_ENTITY_SPEED_VECTOR(int entity, bool relative)` | Vector3 | Relative can be used for getting speed relative to the frame of the vehicle, to determine for exampl... |
| `GET_ENTITY_SUBMERGED_LEVEL` | `float GET_ENTITY_SUBMERGED_LEVEL(int entity)` | float | Get how much of the entity is submerged.  1.0f is whole entity. |
| `GET_ENTITY_TYPE` | `int GET_ENTITY_TYPE(int entity)` | int | Returns:<br>0 = no entity<br>1 = ped<br>2 = vehicle<br>3 = object |
| `GET_ENTITY_UPRIGHT_VALUE` | `float GET_ENTITY_UPRIGHT_VALUE(int entity)` | float | - |
| `GET_ENTITY_VELOCITY` | `Vector3 GET_ENTITY_VELOCITY(int entity)` | Vector3 | - |
| `GET_HAS_OBJECT_BEEN_COMPLETELY_DESTROYED` | `bool GET_HAS_OBJECT_BEEN_COMPLETELY_DESTROYED(object p0)` | bool | - |
| `GET_INDEXED_ITEM_IN_ITEMSET` | `int GET_INDEXED_ITEM_IN_ITEMSET(int index, int itemset)` | int | - |
| `GET_IS_ARTICULATED_JOINT_AT_MAX_ANGLE` | `bool GET_IS_ARTICULATED_JOINT_AT_MAX_ANGLE(object p0, object p1)` | bool | - |
| `GET_IS_ARTICULATED_JOINT_AT_MIN_ANGLE` | `bool GET_IS_ARTICULATED_JOINT_AT_MIN_ANGLE(int object, object p1)` | bool | - |
| `GET_ITEMSET_SIZE` | `int GET_ITEMSET_SIZE(int itemset)` | int | - |
| `GET_LAST_MATERIAL_HIT_BY_ENTITY` | `uint GET_LAST_MATERIAL_HIT_BY_ENTITY(int entity)` | uint | - |
| `GET_NEAREST_PARTICIPANT_TO_ENTITY` | `int GET_NEAREST_PARTICIPANT_TO_ENTITY(int entity)` | int | - |
| `GET_NEAREST_PLAYER_TO_ENTITY` | `int GET_NEAREST_PLAYER_TO_ENTITY(int entity)` | int | - |
| `GET_NEAREST_PLAYER_TO_ENTITY_ON_TEAM` | `int GET_NEAREST_PLAYER_TO_ENTITY_ON_TEAM(int entity, int team)` | int | - |
| `GET_OBJECT_FRAGMENT_DAMAGE_HEALTH` | `float GET_OBJECT_FRAGMENT_DAMAGE_HEALTH(object p0, bool p1)` | float | - |
| `GET_OBJECT_INDEX_FROM_ENTITY_INDEX` | `int GET_OBJECT_INDEX_FROM_ENTITY_INDEX(int entity)` | int | Simply returns whatever is passed to it (Regardless of whether the handle is valid or not). |
| `GET_OBJECT_TINT_INDEX` | `int GET_OBJECT_TINT_INDEX(int object)` | int | - |
| `GET_OFFSET_FROM_COORD_AND_HEADING_IN_WORLD_COORDS` | `Vector3 GET_OFFSET_FROM_COORD_AND_HEADING_IN_WORLD_COORDS(float xPos, float yPos, float zPos, float heading, float xOffset, float yOffset, float zOffset)` | Vector3 | - |
| `GET_OFFSET_FROM_ENTITY_GIVEN_WORLD_COORDS` | `Vector3 GET_OFFSET_FROM_ENTITY_GIVEN_WORLD_COORDS(int entity, float posX, float posY, float posZ)` | Vector3 | Converts world coords (posX - Z) to coords relative to the entity<br><br>Example:<br>posX is given as 50<br>enti... |
| `GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS` | `Vector3 GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(int entity, float offsetX, float offsetY, float offsetZ)` | Vector3 | Offset values are relative to the entity.<br><br>x = left/right<br>y = forward/backward<br>z = up/down |
| `GET_PED_INDEX_FROM_ENTITY_INDEX` | `int GET_PED_INDEX_FROM_ENTITY_INDEX(int entity)` | int | Simply returns whatever is passed to it (Regardless of whether the handle is valid or not). |
| `GET_PICKUP_COORDS` | `Vector3 GET_PICKUP_COORDS(int pickup)` | Vector3 | - |
| `GET_PICKUP_GENERATION_RANGE_MULTIPLIER` | `float GET_PICKUP_GENERATION_RANGE_MULTIPLIER()` | float | - |
| `GET_PICKUP_OBJECT` | `int GET_PICKUP_OBJECT(int pickup)` | int | - |
| `GET_PICKUP_TYPE_FROM_WEAPON_HASH` | `uint GET_PICKUP_TYPE_FROM_WEAPON_HASH(uint weaponHash)` | uint | Returns the pickup hash for the given weapon hash |
| `GET_RAYFIRE_MAP_OBJECT` | `int GET_RAYFIRE_MAP_OBJECT(float x, float y, float z, float radius, string name)` | int | Example:<br>OBJECT::GET_RAYFIRE_MAP_OBJECT(-809.9619750976562, 170.919, 75.7406997680664, 3.0, "des_tvs... |
| `GET_RAYFIRE_MAP_OBJECT_ANIM_PHASE` | `float GET_RAYFIRE_MAP_OBJECT_ANIM_PHASE(int object)` | float | `object`: The des-object handle to get the animation progress from.<br>Return value is a float between ... |
| `GET_SAFE_PICKUP_COORDS` | `Vector3 GET_SAFE_PICKUP_COORDS(float x, float y, float z, float p3, float p4)` | Vector3 | - |
| `GET_STATE_OF_CLOSEST_DOOR_OF_TYPE` | `void GET_STATE_OF_CLOSEST_DOOR_OF_TYPE(uint type, float x, float y, float z, ref bool locked, ref float heading)` | void | locked is 0 if no door is found<br>locked is 0 if door is unlocked<br>locked is 1 if door is found and unl... |
| `GET_STATE_OF_RAYFIRE_MAP_OBJECT` | `int GET_STATE_OF_RAYFIRE_MAP_OBJECT(int object)` | int | Get a destructible object's state.<br>Substract 1 to get the real state.<br>See SET_STATE_OF_RAYFIRE_MAP_O... |
| `GET_VEHICLE_INDEX_FROM_ENTITY_INDEX` | `int GET_VEHICLE_INDEX_FROM_ENTITY_INDEX(int entity)` | int | Simply returns whatever is passed to it (Regardless of whether the handle is valid or not). |
| `GET_WEAPON_TYPE_FROM_PICKUP_TYPE` | `uint GET_WEAPON_TYPE_FROM_PICKUP_TYPE(uint pickupHash)` | uint | Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pi... |
| `GET_WORLD_POSITION_OF_ENTITY_BONE` | `Vector3 GET_WORLD_POSITION_OF_ENTITY_BONE(int entity, int boneIndex)` | Vector3 | Returns the coordinates of an entity-bone. |
| `HAS_ANIM_EVENT_FIRED` | `bool HAS_ANIM_EVENT_FIRED(int entity, uint actionHash)` | bool | if (ENTITY::HAS_ANIM_EVENT_FIRED(PLAYER::PLAYER_PED_ID(), MISC::GET_HASH_KEY("CreateObject"))) |
| `HAS_CLOSEST_OBJECT_OF_TYPE_BEEN_BROKEN` | `bool HAS_CLOSEST_OBJECT_OF_TYPE_BEEN_BROKEN(float p0, float p1, float p2, float p3, uint modelHash, object p5)` | bool | - |
| `HAS_CLOSEST_OBJECT_OF_TYPE_BEEN_COMPLETELY_DESTROYED` | `bool HAS_CLOSEST_OBJECT_OF_TYPE_BEEN_COMPLETELY_DESTROYED(float x, float y, float z, float radius, uint modelHash, bool p5)` | bool | - |
| `HAS_COLLISION_LOADED_AROUND_ENTITY` | `bool HAS_COLLISION_LOADED_AROUND_ENTITY(int entity)` | bool | - |
| `HAS_ENTITY_ANIM_FINISHED` | `bool HAS_ENTITY_ANIM_FINISHED(int entity, string animDict, string animName, int p3)` | bool | P3 is always 3 as far as i cant tell<br><br>Full list of animation dictionaries and anims by DurtyFree: ht... |
| `HAS_ENTITY_BEEN_DAMAGED_BY_ANY_OBJECT` | `bool HAS_ENTITY_BEEN_DAMAGED_BY_ANY_OBJECT(int entity)` | bool | - |
| `HAS_ENTITY_BEEN_DAMAGED_BY_ANY_PED` | `bool HAS_ENTITY_BEEN_DAMAGED_BY_ANY_PED(int entity)` | bool | - |
| `HAS_ENTITY_BEEN_DAMAGED_BY_ANY_VEHICLE` | `bool HAS_ENTITY_BEEN_DAMAGED_BY_ANY_VEHICLE(int entity)` | bool | - |
| `HAS_ENTITY_BEEN_DAMAGED_BY_ENTITY` | `bool HAS_ENTITY_BEEN_DAMAGED_BY_ENTITY(int entity1, int entity2, bool p2)` | bool | Entity 1 = Victim<br>Entity 2 = Attacker<br><br>p2 seems to always be 1 |
| `HAS_ENTITY_CLEAR_LOS_TO_ENTITY` | `bool HAS_ENTITY_CLEAR_LOS_TO_ENTITY(int entity1, int entity2, int traceType)` | bool | traceType is always 17 in the scripts.<br><br>There is other codes used for traceType:<br>19 - in jewelry_pre... |
| `HAS_ENTITY_CLEAR_LOS_TO_ENTITY_ADJUST_FOR_COVER` | `bool HAS_ENTITY_CLEAR_LOS_TO_ENTITY_ADJUST_FOR_COVER(int entity1, int entity2, int traceType)` | bool | - |
| `HAS_ENTITY_CLEAR_LOS_TO_ENTITY_IN_FRONT` | `bool HAS_ENTITY_CLEAR_LOS_TO_ENTITY_IN_FRONT(int entity1, int entity2)` | bool | Has the entity1 got a clear line of sight to the other entity2 from the direction entity1 is facing.... |
| `HAS_ENTITY_COLLIDED_WITH_ANYTHING` | `bool HAS_ENTITY_COLLIDED_WITH_ANYTHING(int entity)` | bool | Called on tick.<br>Tested with vehicles, returns true whenever the vehicle is touching any entity.<br><br>Not... |
| `HAS_OBJECT_BEEN_BROKEN` | `bool HAS_OBJECT_BEEN_BROKEN(int object, object p1)` | bool | - |
| `HAS_PICKUP_BEEN_COLLECTED` | `bool HAS_PICKUP_BEEN_COLLECTED(int pickup)` | bool | - |
| `HIDE_PORTABLE_PICKUP_WHEN_DETACHED` | `void HIDE_PORTABLE_PICKUP_WHEN_DETACHED(int pickupObject, bool toggle)` | void | - |
| `IS_ANY_ENTITY_ENTIRELY_INSIDE_GARAGE` | `bool IS_ANY_ENTITY_ENTIRELY_INSIDE_GARAGE(uint garageHash, bool p1, bool p2, bool p3, object p4)` | bool | - |
| `IS_ANY_OBJECT_NEAR_POINT` | `bool IS_ANY_OBJECT_NEAR_POINT(float x, float y, float z, float range, bool p4)` | bool | - |
| `IS_AN_ENTITY` | `bool IS_AN_ENTITY(int handle)` | bool | - |
| `IS_DOOR_CLOSED` | `bool IS_DOOR_CLOSED(uint doorHash)` | bool | - |
| `IS_DOOR_REGISTERED_WITH_SYSTEM` | `bool IS_DOOR_REGISTERED_WITH_SYSTEM(uint doorHash)` | bool | if (OBJECT::IS_DOOR_REGISTERED_WITH_SYSTEM(doorHash)) <br>{<br>    OBJECT::REMOVE_DOOR_FROM_SYSTEM(doorHas... |
| `IS_ENTITY_AN_OBJECT` | `bool IS_ENTITY_AN_OBJECT(int entity)` | bool | - |
| `IS_ENTITY_ATTACHED` | `bool IS_ENTITY_ATTACHED(int entity)` | bool | Whether the entity is attached to any other entity. |
| `IS_ENTITY_ATTACHED_TO_ANY_OBJECT` | `bool IS_ENTITY_ATTACHED_TO_ANY_OBJECT(int entity)` | bool | - |
| `IS_ENTITY_ATTACHED_TO_ANY_PED` | `bool IS_ENTITY_ATTACHED_TO_ANY_PED(int entity)` | bool | - |
| `IS_ENTITY_ATTACHED_TO_ANY_VEHICLE` | `bool IS_ENTITY_ATTACHED_TO_ANY_VEHICLE(int entity)` | bool | - |
| `IS_ENTITY_ATTACHED_TO_ENTITY` | `bool IS_ENTITY_ATTACHED_TO_ENTITY(int from, int to)` | bool | - |
| `IS_ENTITY_AT_COORD` | `bool IS_ENTITY_AT_COORD(int entity, float xPos, float yPos, float zPos, float xSize, float ySize, float zSize, bool p7, bool p8, int p9)` | bool | Checks if entity is within x/y/zSize distance of x/y/z. <br><br>Last three are unknown ints, almost always... |
| `IS_ENTITY_AT_ENTITY` | `bool IS_ENTITY_AT_ENTITY(int entity1, int entity2, float xSize, float ySize, float zSize, bool p5, bool p6, int p7)` | bool | Checks if entity1 is within the box defined by x/y/zSize of entity2.<br><br>Last three parameters are almo... |
| `IS_ENTITY_A_MISSION_ENTITY` | `bool IS_ENTITY_A_MISSION_ENTITY(int entity)` | bool | - |
| `IS_ENTITY_A_PED` | `bool IS_ENTITY_A_PED(int entity)` | bool | - |
| `IS_ENTITY_A_VEHICLE` | `bool IS_ENTITY_A_VEHICLE(int entity)` | bool | - |
| `IS_ENTITY_DEAD` | `bool IS_ENTITY_DEAD(int entity, bool p1)` | bool | - |
| `IS_ENTITY_IN_AIR` | `bool IS_ENTITY_IN_AIR(int entity)` | bool | - |
| `IS_ENTITY_IN_ANGLED_AREA` | `bool IS_ENTITY_IN_ANGLED_AREA(int entity, float x1, float y1, float z1, float x2, float y2, float z2, float width, bool debug, bool includeZ, object p10)` | bool | `p8` is a debug flag invoking functions in the same path as ``DRAW_MARKER``<br>`p10` is some entity fla... |
| `IS_ENTITY_IN_AREA` | `bool IS_ENTITY_IN_AREA(int entity, float x1, float y1, float z1, float x2, float y2, float z2, bool p7, bool p8, object p9)` | bool | - |
| `IS_ENTITY_IN_WATER` | `bool IS_ENTITY_IN_WATER(int entity)` | bool | - |
| `IS_ENTITY_IN_ZONE` | `bool IS_ENTITY_IN_ZONE(int entity, string zone)` | bool | Full list of zones by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/zones.jso... |
| `IS_ENTITY_OCCLUDED` | `bool IS_ENTITY_OCCLUDED(int entity)` | bool | - |
| `IS_ENTITY_ON_SCREEN` | `bool IS_ENTITY_ON_SCREEN(int entity)` | bool | Returns true if the entity is in between the minimum and maximum values for the 2d screen coords. <br>T... |
| `IS_ENTITY_PLAYING_ANIM` | `bool IS_ENTITY_PLAYING_ANIM(int entity, string animDict, string animName, int taskFlag)` | bool | See also PED::IS_SCRIPTED_SCENARIO_PED_USING_CONDITIONAL_ANIM 0x6EC47A344923E1ED 0x3C30B447<br><br>Taken f... |
| `IS_ENTITY_STATIC` | `bool IS_ENTITY_STATIC(int entity)` | bool | a static ped will not react to natives like "APPLY_FORCE_TO_ENTITY" or "SET_ENTITY_VELOCITY" and oft... |
| `IS_ENTITY_TOUCHING_ENTITY` | `bool IS_ENTITY_TOUCHING_ENTITY(int entity, int targetEntity)` | bool | - |
| `IS_ENTITY_TOUCHING_MODEL` | `bool IS_ENTITY_TOUCHING_MODEL(int entity, uint modelHash)` | bool | - |
| `IS_ENTITY_UPRIGHT` | `bool IS_ENTITY_UPRIGHT(int entity, float angle)` | bool | - |
| `IS_ENTITY_UPSIDEDOWN` | `bool IS_ENTITY_UPSIDEDOWN(int entity)` | bool | - |
| `IS_ENTITY_VISIBLE` | `bool IS_ENTITY_VISIBLE(int entity)` | bool | - |
| `IS_ENTITY_VISIBLE_TO_SCRIPT` | `bool IS_ENTITY_VISIBLE_TO_SCRIPT(int entity)` | bool | - |
| `IS_ENTITY_WAITING_FOR_WORLD_COLLISION` | `bool IS_ENTITY_WAITING_FOR_WORLD_COLLISION(int entity)` | bool | - |
| `IS_GARAGE_EMPTY` | `bool IS_GARAGE_EMPTY(uint garageHash, bool p1, int p2)` | bool | - |
| `IS_IN_ITEMSET` | `bool IS_IN_ITEMSET(int item, int itemset)` | bool | - |
| `IS_ITEMSET_VALID` | `bool IS_ITEMSET_VALID(int itemset)` | bool | - |
| `IS_OBJECT_A_PICKUP` | `bool IS_OBJECT_A_PICKUP(int object)` | bool | - |
| `IS_OBJECT_A_PORTABLE_PICKUP` | `bool IS_OBJECT_A_PORTABLE_PICKUP(int object)` | bool | - |
| `IS_OBJECT_ENTIRELY_INSIDE_GARAGE` | `bool IS_OBJECT_ENTIRELY_INSIDE_GARAGE(uint garageHash, int entity, float p2, int p3)` | bool | Despite the name, it does work for any entity type. |
| `IS_OBJECT_NEAR_POINT` | `bool IS_OBJECT_NEAR_POINT(uint objectHash, float x, float y, float z, float range)` | bool | - |
| `IS_OBJECT_PARTIALLY_INSIDE_GARAGE` | `bool IS_OBJECT_PARTIALLY_INSIDE_GARAGE(uint garageHash, int entity, int p2)` | bool | Despite the name, it does work for any entity type. |
| `IS_OBJECT_VISIBLE` | `bool IS_OBJECT_VISIBLE(int object)` | bool | - |
| `IS_PICKUP_WEAPON_OBJECT_VALID` | `bool IS_PICKUP_WEAPON_OBJECT_VALID(int object)` | bool | - |
| `IS_PLAYER_ENTIRELY_INSIDE_GARAGE` | `bool IS_PLAYER_ENTIRELY_INSIDE_GARAGE(uint garageHash, int player, float p2, int p3)` | bool | - |
| `IS_PLAYER_PARTIALLY_INSIDE_GARAGE` | `bool IS_PLAYER_PARTIALLY_INSIDE_GARAGE(uint garageHash, int player, int p2)` | bool | - |
| `IS_POINT_IN_ANGLED_AREA` | `bool IS_POINT_IN_ANGLED_AREA(float xPos, float yPos, float zPos, float x1, float y1, float z1, float x2, float y2, float z2, float width, bool debug, bool includeZ)` | bool | An angled area is an X-Z oriented rectangle with three parameters:<br>1. origin: the mid-point along a ... |
| `IS_PROP_LIGHT_OVERRIDEN` | `bool IS_PROP_LIGHT_OVERRIDEN(int object)` | bool | - |
| `ONLY_CLEAN_UP_OBJECT_WHEN_OUT_OF_RANGE` | `void ONLY_CLEAN_UP_OBJECT_WHEN_OUT_OF_RANGE(int object)` | void | - |
| `OPEN_ALL_BARRIERS_FOR_RACE` | `void OPEN_ALL_BARRIERS_FOR_RACE(bool p0)` | void | - |
| `PLACE_OBJECT_ON_GROUND_OR_OBJECT_PROPERLY` | `bool PLACE_OBJECT_ON_GROUND_OR_OBJECT_PROPERLY(int object)` | bool | - |
| `PLACE_OBJECT_ON_GROUND_PROPERLY` | `bool PLACE_OBJECT_ON_GROUND_PROPERLY(int object)` | bool | - |
| `PLAY_ENTITY_ANIM` | `bool PLAY_ENTITY_ANIM(int entity, string animName, string animDict, float p3, bool loop, bool stayInAnim, bool p6, float delta, object bitset)` | bool | delta and bitset are guessed fields. They are based on the fact that most of the calls have 0 or nil... |
| `PLAY_OBJECT_AUTO_START_ANIM` | `void PLAY_OBJECT_AUTO_START_ANIM(object p0)` | void | - |
| `PLAY_SYNCHRONIZED_ENTITY_ANIM` | `bool PLAY_SYNCHRONIZED_ENTITY_ANIM(int entity, int syncedScene, string animation, string propName, float p4, float p5, object p6, float p7)` | bool | p4 and p7 are usually 1000.0f.<br><br>Full list of animation dictionaries and anims by DurtyFree: https://... |
| `PLAY_SYNCHRONIZED_MAP_ENTITY_ANIM` | `bool PLAY_SYNCHRONIZED_MAP_ENTITY_ANIM(float x1, float y1, float z1, float x2, object y2, float z2, string p6, string p7, float p8, float p9, object p10, float p11)` | bool | p6,p7 probably animname and animdict<br><br>Full list of animation dictionaries and anims by DurtyFree: ht... |
| `PREVENT_COLLECTION_OF_PORTABLE_PICKUP` | `void PREVENT_COLLECTION_OF_PORTABLE_PICKUP(int object, bool p1, bool p2)` | void | - |
| `PROCESS_ENTITY_ATTACHMENTS` | `void PROCESS_ENTITY_ATTACHMENTS(int entity)` | void | Called to update entity attachments. |
| `REMOVE_ALL_PICKUPS_OF_TYPE` | `void REMOVE_ALL_PICKUPS_OF_TYPE(uint pickupHash)` | void | Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pi... |
| `REMOVE_DOOR_FROM_SYSTEM` | `void REMOVE_DOOR_FROM_SYSTEM(uint doorHash, object p1)` | void | CDoor and CDoorSystemData still internally allocated (and their associations between doorHash, model... |
| `REMOVE_FORCED_OBJECT` | `void REMOVE_FORCED_OBJECT(float x, float y, float z, float p3, uint modelHash)` | void | - |
| `REMOVE_FROM_ITEMSET` | `void REMOVE_FROM_ITEMSET(int item, int itemset)` | void | - |
| `REMOVE_MODEL_HIDE` | `void REMOVE_MODEL_HIDE(float x, float y, float z, float radius, uint modelHash, bool p5)` | void | This native makes entities visible that are hidden by the native CREATE_MODEL_HIDE.<br>p5 should be fal... |
| `REMOVE_MODEL_SWAP` | `void REMOVE_MODEL_SWAP(float x, float y, float z, float radius, uint originalModel, uint newModel, bool p6)` | void | - |
| `REMOVE_OBJECT_HIGH_DETAIL_MODEL` | `void REMOVE_OBJECT_HIGH_DETAIL_MODEL(int object)` | void | - |
| `REMOVE_PICKUP` | `void REMOVE_PICKUP(int pickup)` | void | - |
| `RENDER_FAKE_PICKUP_GLOW` | `void RENDER_FAKE_PICKUP_GLOW(float x, float y, float z, int colorIndex)` | void | draws circular marker at pos<br>-1 = none<br>0 = red<br>1 = green<br>2 = blue<br>3 = green larger<br>4 = nothing<br>5 = g... |
| `RESET_ENTITY_ALPHA` | `void RESET_ENTITY_ALPHA(int entity)` | void | - |
| `RESET_PICKUP_ENTITY_GLOW` | `void RESET_PICKUP_ENTITY_GLOW(int entity)` | void | Similar to RESET_ENTITY_ALPHA |
| `ROTATE_OBJECT` | `bool ROTATE_OBJECT(int object, float p1, float p2, bool p3)` | bool | - |
| `SET_ACTIVATE_OBJECT_PHYSICS_AS_SOON_AS_IT_IS_UNFROZEN` | `void SET_ACTIVATE_OBJECT_PHYSICS_AS_SOON_AS_IT_IS_UNFROZEN(int object, bool toggle)` | void | - |
| `SET_ALLOW_MIGRATE_TO_SPECTATOR` | `void SET_ALLOW_MIGRATE_TO_SPECTATOR(int entity, object p1)` | void | p1 is always set to 1 |
| `SET_CAN_AUTO_VAULT_ON_ENTITY` | `void SET_CAN_AUTO_VAULT_ON_ENTITY(int entity, bool toggle)` | void | p1 always false. |
| `SET_CAN_CLIMB_ON_ENTITY` | `void SET_CAN_CLIMB_ON_ENTITY(int entity, bool toggle)` | void | p1 always false. |
| `SET_CUSTOM_PICKUP_WEAPON_HASH` | `void SET_CUSTOM_PICKUP_WEAPON_HASH(uint pickupHash, int pickup)` | void | - |
| `SET_CUTSCENES_WEAPON_FLASHLIGHT_ON_THIS_FRAME` | `void SET_CUTSCENES_WEAPON_FLASHLIGHT_ON_THIS_FRAME(int object, bool toggle)` | void | Requires a component_at_*_flsh to be attached to the weapon object |
| `SET_DISABLE_COLLISIONS_BETWEEN_CARS_AND_CAR_PARACHUTE` | `void SET_DISABLE_COLLISIONS_BETWEEN_CARS_AND_CAR_PARACHUTE(object p0)` | void | - |
| `SET_DRIVE_ARTICULATED_JOINT` | `void SET_DRIVE_ARTICULATED_JOINT(int object, bool toggle, int p2)` | void | Activate the physics to: "xs_prop_arena_{flipper,wall,bollard,turntable,pit}" |
| `SET_DRIVE_ARTICULATED_JOINT_WITH_INFLICTOR` | `void SET_DRIVE_ARTICULATED_JOINT_WITH_INFLICTOR(int object, bool toggle, int p2, int ped)` | void | - |
| `SET_ENTITY_ALPHA` | `void SET_ENTITY_ALPHA(int entity, int alphaLevel, bool skin)` | void | skin - everything alpha except skin<br>Set entity alpha level. Ranging from 0 to 255 but chnages occur ... |
| `SET_ENTITY_ALWAYS_PRERENDER` | `void SET_ENTITY_ALWAYS_PRERENDER(int entity, bool toggle)` | void | - |
| `SET_ENTITY_ANGULAR_VELOCITY` | `void SET_ENTITY_ANGULAR_VELOCITY(int entity, float x, float y, float z)` | void | - |
| `SET_ENTITY_ANIM_CURRENT_TIME` | `void SET_ENTITY_ANIM_CURRENT_TIME(int entity, string animDictionary, string animName, float time)` | void | Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-... |
| `SET_ENTITY_ANIM_SPEED` | `void SET_ENTITY_ANIM_SPEED(int entity, string animDictionary, string animName, float speedMultiplier)` | void | Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-... |
| `SET_ENTITY_AS_MISSION_ENTITY` | `void SET_ENTITY_AS_MISSION_ENTITY(int entity, bool p1, bool p2)` | void | Makes the specified entity (ped, vehicle or object) persistent. Persistent entities will not automat... |
| `SET_ENTITY_AS_NO_LONGER_NEEDED` | `void SET_ENTITY_AS_NO_LONGER_NEEDED(Entity* entity)` | void | Marks the specified entity (ped, vehicle or object) as no longer needed if its population type is se... |
| `SET_ENTITY_CANT_CAUSE_COLLISION_DAMAGED_ENTITY` | `void SET_ENTITY_CANT_CAUSE_COLLISION_DAMAGED_ENTITY(int entity1, int entity2)` | void | - |
| `SET_ENTITY_CAN_BE_DAMAGED` | `void SET_ENTITY_CAN_BE_DAMAGED(int entity, bool toggle)` | void | - |
| `SET_ENTITY_CAN_BE_DAMAGED_BY_RELATIONSHIP_GROUP` | `void SET_ENTITY_CAN_BE_DAMAGED_BY_RELATIONSHIP_GROUP(int entity, bool bCanBeDamaged, int relGroup)` | void | - |
| `SET_ENTITY_CAN_BE_TARGETED_WITHOUT_LOS` | `void SET_ENTITY_CAN_BE_TARGETED_WITHOUT_LOS(int entity, bool toggle)` | void | Sets whether the entity can be targeted without being in line-of-sight. |
| `SET_ENTITY_CAN_ONLY_BE_DAMAGED_BY_ENTITY` | `void SET_ENTITY_CAN_ONLY_BE_DAMAGED_BY_ENTITY(int entity1, int entity2)` | void | - |
| `SET_ENTITY_CAN_ONLY_BE_DAMAGED_BY_SCRIPT_PARTICIPANTS` | `void SET_ENTITY_CAN_ONLY_BE_DAMAGED_BY_SCRIPT_PARTICIPANTS(int entity, bool toggle)` | void | - |
| `SET_ENTITY_COLLISION` | `void SET_ENTITY_COLLISION(int entity, bool toggle, bool keepPhysics)` | void | - |
| `SET_ENTITY_COMPLETELY_DISABLE_COLLISION` | `void SET_ENTITY_COMPLETELY_DISABLE_COLLISION(int entity, bool toggle, bool keepPhysics)` | void | - |
| `SET_ENTITY_COORDS` | `void SET_ENTITY_COORDS(int entity, float xPos, float yPos, float zPos, bool xAxis, bool yAxis, bool zAxis, bool clearArea)` | void | p7 is always 1 in the scripts. Set to 1, an area around the destination coords for the moved entity ... |
| `SET_ENTITY_COORDS_NO_OFFSET` | `void SET_ENTITY_COORDS_NO_OFFSET(int entity, float xPos, float yPos, float zPos, bool xAxis, bool yAxis, bool zAxis)` | void | Axis - Invert Axis Flags |
| `SET_ENTITY_COORDS_WITHOUT_PLANTS_RESET` | `void SET_ENTITY_COORDS_WITHOUT_PLANTS_RESET(int entity, float xPos, float yPos, float zPos, bool alive, bool deadFlag, bool ragdollFlag, bool clearArea)` | void | - |
| `SET_ENTITY_DYNAMIC` | `void SET_ENTITY_DYNAMIC(int entity, bool toggle)` | void | - |
| `SET_ENTITY_FLAG_RENDER_SMALL_SHADOW` | `void SET_ENTITY_FLAG_RENDER_SMALL_SHADOW(int object, bool toggle)` | void | - |
| `SET_ENTITY_FLAG_SUPPRESS_SHADOW` | `void SET_ENTITY_FLAG_SUPPRESS_SHADOW(int entity, bool toggle)` | void | Sets entity+38 to C (when false) or 0xFF3f (when true) |
| `SET_ENTITY_HAS_GRAVITY` | `void SET_ENTITY_HAS_GRAVITY(int entity, bool toggle)` | void | - |
| `SET_ENTITY_HEADING` | `void SET_ENTITY_HEADING(int entity, float heading)` | void | Set the heading of an entity in degrees also known as "Yaw". |
| `SET_ENTITY_HEALTH` | `void SET_ENTITY_HEALTH(int entity, int health, int instigator, uint weaponType)` | void | health >= 0<br>male ped ~= 100 - 200<br>female ped ~= 0 - 100 |
| `SET_ENTITY_INVINCIBLE` | `void SET_ENTITY_INVINCIBLE(int entity, bool toggle, bool dontResetOnCleanup)` | void | Sets a ped or an object totally invincible. It doesn't take any kind of damage. Peds will not ragdol... |
| `SET_ENTITY_IS_IN_VEHICLE` | `void SET_ENTITY_IS_IN_VEHICLE(int entity)` | void | - |
| `SET_ENTITY_IS_TARGET_PRIORITY` | `void SET_ENTITY_IS_TARGET_PRIORITY(int entity, bool p1, float p2)` | void | - |
| `SET_ENTITY_LIGHTS` | `void SET_ENTITY_LIGHTS(int entity, bool toggle)` | void | - |
| `SET_ENTITY_LOAD_COLLISION_FLAG` | `void SET_ENTITY_LOAD_COLLISION_FLAG(int entity, bool toggle, object p2)` | void | Loads collision grid for an entity spawned outside of a player's loaded area. This allows peds to ex... |
| `SET_ENTITY_LOD_DIST` | `void SET_ENTITY_LOD_DIST(int entity, int value)` | void | LOD distance can be 0 to 0xFFFF (higher values will result in 0xFFFF) as it is actually stored as a ... |
| `SET_ENTITY_MAX_HEALTH` | `void SET_ENTITY_MAX_HEALTH(int entity, int value)` | void | For instance: ENTITY::SET_ENTITY_MAX_HEALTH(PLAYER::PLAYER_PED_ID(), 200); // director_mode.c4: 6784... |
| `SET_ENTITY_MAX_SPEED` | `void SET_ENTITY_MAX_SPEED(int entity, float speed)` | void | - |
| `SET_ENTITY_MIRROR_REFLECTION_FLAG` | `void SET_ENTITY_MIRROR_REFLECTION_FLAG(int entity, bool p1)` | void | - |
| `SET_ENTITY_MOTION_BLUR` | `void SET_ENTITY_MOTION_BLUR(int entity, bool toggle)` | void | - |
| `SET_ENTITY_NOWEAPONDECALS` | `void SET_ENTITY_NOWEAPONDECALS(int entity, bool p1)` | void | - |
| `SET_ENTITY_NO_COLLISION_ENTITY` | `void SET_ENTITY_NO_COLLISION_ENTITY(int entity1, int entity2, bool thisFrameOnly)` | void | Calling this function disables collision between two entities.<br>The importance of the order for entit... |
| `SET_ENTITY_ONLY_DAMAGED_BY_PLAYER` | `void SET_ENTITY_ONLY_DAMAGED_BY_PLAYER(int entity, bool toggle)` | void | - |
| `SET_ENTITY_ONLY_DAMAGED_BY_RELATIONSHIP_GROUP` | `void SET_ENTITY_ONLY_DAMAGED_BY_RELATIONSHIP_GROUP(int entity, bool p1, object p2)` | void | - |
| `SET_ENTITY_PROOFS` | `void SET_ENTITY_PROOFS(int entity, bool bulletProof, bool fireProof, bool explosionProof, bool collisionProof, bool meleeProof, bool steamProof, bool dontResetOnCleanup, bool waterProof)` | void | Enable / disable each type of damage.<br><br>waterProof is damage related to water not drowning<br>----------... |
| `SET_ENTITY_QUATERNION` | `void SET_ENTITY_QUATERNION(int entity, float x, float y, float z, float w)` | void | w is the correct parameter name! |
| `SET_ENTITY_RECORDS_COLLISIONS` | `void SET_ENTITY_RECORDS_COLLISIONS(int entity, bool toggle)` | void | - |
| `SET_ENTITY_RENDER_SCORCHED` | `void SET_ENTITY_RENDER_SCORCHED(int entity, bool toggle)` | void | - |
| `SET_ENTITY_REQUIRES_MORE_EXPENSIVE_RIVER_CHECK` | `void SET_ENTITY_REQUIRES_MORE_EXPENSIVE_RIVER_CHECK(int entity, bool toggle)` | void | - |
| `SET_ENTITY_ROTATION` | `void SET_ENTITY_ROTATION(int entity, float pitch, float roll, float yaw, int rotationOrder, bool p5)` | void | rotationOrder refers to the order yaw pitch roll is applied<br>value ranges from 0 to 5. What you use f... |
| `SET_ENTITY_SHOULD_FREEZE_WAITING_ON_COLLISION` | `void SET_ENTITY_SHOULD_FREEZE_WAITING_ON_COLLISION(int entity, bool toggle)` | void | True means it can be deleted by the engine when switching lobbies/missions/etc, false means the scri... |
| `SET_ENTITY_SORT_BIAS` | `void SET_ENTITY_SORT_BIAS(int entity, float p1)` | void | Only called once in the scripts.<br><br>Related to weapon objects.<br> |
| `SET_ENTITY_TRAFFICLIGHT_OVERRIDE` | `void SET_ENTITY_TRAFFICLIGHT_OVERRIDE(int entity, int state)` | void | Example here: www.gtaforums.com/topic/830463-help-with-turning-lights-green-and-causing-peds-to-cras... |
| `SET_ENTITY_USE_MAX_DISTANCE_FOR_WATER_REFLECTION` | `void SET_ENTITY_USE_MAX_DISTANCE_FOR_WATER_REFLECTION(int entity, bool p1)` | void | - |
| `SET_ENTITY_VELOCITY` | `void SET_ENTITY_VELOCITY(int entity, float x, float y, float z)` | void | Note that the third parameter(denoted as z) is "up and down" with positive numbers encouraging upwar... |
| `SET_ENTITY_VISIBLE` | `void SET_ENTITY_VISIBLE(int entity, bool toggle, bool p2)` | void | p2 is always 0. |
| `SET_ENTITY_WATER_REFLECTION_FLAG` | `void SET_ENTITY_WATER_REFLECTION_FLAG(int entity, bool toggle)` | void | - |
| `SET_FORCE_OBJECT_THIS_FRAME` | `void SET_FORCE_OBJECT_THIS_FRAME(float x, float y, float z, float p3)` | void | - |
| `SET_IS_OBJECT_ARTICULATED` | `void SET_IS_OBJECT_ARTICULATED(int object, bool toggle)` | void | - |
| `SET_IS_OBJECT_BALL` | `void SET_IS_OBJECT_BALL(int object, bool toggle)` | void | - |
| `SET_LOCAL_PLAYER_CAN_COLLECT_PORTABLE_PICKUPS` | `void SET_LOCAL_PLAYER_CAN_COLLECT_PORTABLE_PICKUPS(bool toggle)` | void | - |
| `SET_LOCAL_PLAYER_PERMITTED_TO_COLLECT_PICKUPS_WITH_MODEL` | `void SET_LOCAL_PLAYER_PERMITTED_TO_COLLECT_PICKUPS_WITH_MODEL(uint modelHash, bool toggle)` | void | Maximum amount of pickup models that can be disallowed is 30. |
| `SET_LOCKED_UNSTREAMED_IN_DOOR_OF_TYPE` | `void SET_LOCKED_UNSTREAMED_IN_DOOR_OF_TYPE(uint modelHash, float x, float y, float z, bool locked, float xRotMult, float yRotMult, float zRotMult)` | void | Hardcoded not to work in multiplayer environments.<br>When you set locked to 0 the door open and to 1 t... |
| `SET_MAX_NUM_PORTABLE_PICKUPS_CARRIED_BY_PLAYER` | `void SET_MAX_NUM_PORTABLE_PICKUPS_CARRIED_BY_PLAYER(uint modelHash, int number)` | void | - |
| `SET_OBJECT_ALLOW_LOW_LOD_BUOYANCY` | `void SET_OBJECT_ALLOW_LOW_LOD_BUOYANCY(int object, bool toggle)` | void | Overrides the climbing/blocking flags of the object, used in the native scripts mostly for "prop_doc... |
| `SET_OBJECT_AS_NO_LONGER_NEEDED` | `void SET_OBJECT_AS_NO_LONGER_NEEDED(Object* object)` | void | This is an alias of SET_ENTITY_AS_NO_LONGER_NEEDED. |
| `SET_OBJECT_FORCE_VEHICLES_TO_AVOID` | `void SET_OBJECT_FORCE_VEHICLES_TO_AVOID(int object, bool toggle)` | void | Overrides a flag on the object which determines if the object should be avoided by a vehicle in task... |
| `SET_OBJECT_GLOW_IN_SAME_TEAM` | `void SET_OBJECT_GLOW_IN_SAME_TEAM(int pickup)` | void | - |
| `SET_OBJECT_IS_A_PRESSURE_PLATE` | `void SET_OBJECT_IS_A_PRESSURE_PLATE(int object, bool toggle)` | void | - |
| `SET_OBJECT_IS_SPECIAL_GOLFBALL` | `void SET_OBJECT_IS_SPECIAL_GOLFBALL(int object, bool toggle)` | void | - |
| `SET_OBJECT_IS_VISIBLE_IN_MIRRORS` | `void SET_OBJECT_IS_VISIBLE_IN_MIRRORS(int object, bool toggle)` | void | - |
| `SET_OBJECT_PHYSICS_PARAMS` | `void SET_OBJECT_PHYSICS_PARAMS(int object, float weight, float p2, float p3, float p4, float p5, float gravity, float p7, float p8, float p9, float p10, float buoyancy)` | void | Adjust the physics parameters of a prop, or otherwise known as "object". This is useful for simulate... |
| `SET_OBJECT_SPEED_BOOST_AMOUNT` | `void SET_OBJECT_SPEED_BOOST_AMOUNT(int object, object p1)` | void | - |
| `SET_OBJECT_SPEED_BOOST_DURATION` | `void SET_OBJECT_SPEED_BOOST_DURATION(int object, float duration)` | void | - |
| `SET_OBJECT_TAKES_DAMAGE_FROM_COLLIDING_WITH_BUILDINGS` | `void SET_OBJECT_TAKES_DAMAGE_FROM_COLLIDING_WITH_BUILDINGS(object p0, bool p1)` | void | - |
| `SET_OBJECT_TARGETTABLE` | `void SET_OBJECT_TARGETTABLE(int object, bool targettable, object p2)` | void | - |
| `SET_OBJECT_TINT_INDEX` | `void SET_OBJECT_TINT_INDEX(int object, int textureVariation)` | void | enum ObjectPaintVariants<br>{<br> Pacific = 0,<br>  Azure = 1,<br>    Nautical = 2,<br> Continental = 3,<br>  Battlesh... |
| `SET_ONLY_ALLOW_AMMO_COLLECTION_WHEN_LOW` | `void SET_ONLY_ALLOW_AMMO_COLLECTION_WHEN_LOW(bool p0)` | void | - |
| `SET_PED_AS_NO_LONGER_NEEDED` | `void SET_PED_AS_NO_LONGER_NEEDED(Ped* ped)` | void | This is an alias of SET_ENTITY_AS_NO_LONGER_NEEDED. |
| `SET_PICKUP_COLLIDES_WITH_PROJECTILES` | `void SET_PICKUP_COLLIDES_WITH_PROJECTILES(object p0, object p1)` | void | - |
| `SET_PICKUP_GENERATION_RANGE_MULTIPLIER` | `void SET_PICKUP_GENERATION_RANGE_MULTIPLIER(float multiplier)` | void | - |
| `SET_PICKUP_GLOW_OFFSET` | `void SET_PICKUP_GLOW_OFFSET(int pickup, float p1)` | void | p1 is always 0.51. This native is called before SET_PICKUP_REGENERATION_TIME in all occurances. |
| `SET_PICKUP_HIDDEN_WHEN_UNCOLLECTABLE` | `void SET_PICKUP_HIDDEN_WHEN_UNCOLLECTABLE(int pickup, bool toggle)` | void | - |
| `SET_PICKUP_OBJECT_ALPHA_WHEN_TRANSPARENT` | `void SET_PICKUP_OBJECT_ALPHA_WHEN_TRANSPARENT(int p0)` | void | p0 is either 0 or 50 in scripts. |
| `SET_PICKUP_OBJECT_ARROW_MARKER` | `void SET_PICKUP_OBJECT_ARROW_MARKER(int pickup, bool toggle)` | void | - |
| `SET_PICKUP_OBJECT_COLLECTABLE_IN_VEHICLE` | `void SET_PICKUP_OBJECT_COLLECTABLE_IN_VEHICLE(int pickup)` | void | - |
| `SET_PICKUP_OBJECT_GLOW_OFFSET` | `void SET_PICKUP_OBJECT_GLOW_OFFSET(int pickup, float p1, bool p2)` | void | p1 is always -0.2 in scripts and p2 is always true in scripts. |
| `SET_PICKUP_OBJECT_GLOW_WHEN_UNCOLLECTABLE` | `void SET_PICKUP_OBJECT_GLOW_WHEN_UNCOLLECTABLE(int pickup, bool toggle)` | void | - |
| `SET_PICKUP_OBJECT_TRANSPARENT_WHEN_UNCOLLECTABLE` | `void SET_PICKUP_OBJECT_TRANSPARENT_WHEN_UNCOLLECTABLE(int pickup, bool toggle)` | void | - |
| `SET_PICKUP_REGENERATION_TIME` | `void SET_PICKUP_REGENERATION_TIME(int pickup, int duration)` | void | - |
| `SET_PICKUP_TRACK_DAMAGE_EVENTS` | `void SET_PICKUP_TRACK_DAMAGE_EVENTS(int pickup, bool toggle)` | void | - |
| `SET_PICKUP_TRANSPARENT_WHEN_UNCOLLECTABLE` | `void SET_PICKUP_TRANSPARENT_WHEN_UNCOLLECTABLE(int pickup, bool toggle)` | void | - |
| `SET_PICKUP_UNCOLLECTABLE` | `void SET_PICKUP_UNCOLLECTABLE(int pickup, bool toggle)` | void | - |
| `SET_PICK_UP_BY_CARGOBOB_DISABLED` | `void SET_PICK_UP_BY_CARGOBOB_DISABLED(int entity, bool toggle)` | void | - |
| `SET_PLAYER_PERMITTED_TO_COLLECT_PICKUPS_OF_TYPE` | `void SET_PLAYER_PERMITTED_TO_COLLECT_PICKUPS_OF_TYPE(int player, uint pickupHash, bool toggle)` | void | Disabling/enabling a player from getting pickups. From the scripts:<br><br>OBJECT::SET_PLAYER_PERMITTED_TO... |
| `SET_PORTABLE_PICKUP_PERSIST` | `void SET_PORTABLE_PICKUP_PERSIST(int pickup, bool toggle)` | void | - |
| `SET_PROJECTILES_SHOULD_EXPLODE_ON_CONTACT` | `void SET_PROJECTILES_SHOULD_EXPLODE_ON_CONTACT(int entity, object p1)` | void | - |
| `SET_PROP_LIGHT_COLOR` | `bool SET_PROP_LIGHT_COLOR(int object, bool p1, int r, int g, int b)` | bool | - |
| `SET_PROP_TINT_INDEX` | `void SET_PROP_TINT_INDEX(object p0, object p1)` | void | - |
| `SET_STATE_OF_CLOSEST_DOOR_OF_TYPE` | `void SET_STATE_OF_CLOSEST_DOOR_OF_TYPE(uint type, float x, float y, float z, bool locked, float heading, bool p6)` | void | Hardcoded to not work in multiplayer.<br><br><br>Used to lock/unlock doors to interior areas of the game.<br><br>(P... |
| `SET_STATE_OF_RAYFIRE_MAP_OBJECT` | `void SET_STATE_OF_RAYFIRE_MAP_OBJECT(int object, int state)` | void | Defines the state of a destructible object.<br>Use the GET_RAYFIRE_MAP_OBJECT native to find an object'... |
| `SET_TEAM_PICKUP_OBJECT` | `void SET_TEAM_PICKUP_OBJECT(int object, object p1, bool p2)` | void | - |
| `SET_TINT_INDEX_CLOSEST_BUILDING_OF_TYPE` | `bool SET_TINT_INDEX_CLOSEST_BUILDING_OF_TYPE(float x, float y, float z, float radius, uint modelHash, int textureVariation)` | bool | - |
| `SET_VEHICLE_AS_NO_LONGER_NEEDED` | `void SET_VEHICLE_AS_NO_LONGER_NEEDED(Vehicle* vehicle)` | void | This is an alias of SET_ENTITY_AS_NO_LONGER_NEEDED. |
| `SET_WAIT_FOR_COLLISIONS_BEFORE_PROBE` | `void SET_WAIT_FOR_COLLISIONS_BEFORE_PROBE(int entity, bool toggle)` | void | Only called within 1 script for x360. 'fm_mission_controller' and it used on an object. <br><br>Ran after ... |
| `SET_WEAPON_IMPACTS_APPLY_GREATER_FORCE` | `void SET_WEAPON_IMPACTS_APPLY_GREATER_FORCE(int object, bool p1)` | void | - |
| `SLIDE_OBJECT` | `bool SLIDE_OBJECT(int object, float toX, float toY, float toZ, float speedX, float speedY, float speedZ, bool collision)` | bool | Returns true if the object has finished moving.<br><br>If false, moves the object towards the specified X,... |
| `STOP_ENTITY_ANIM` | `bool STOP_ENTITY_ANIM(int entity, string animation, string animGroup, float p3)` | bool | Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-... |
| `STOP_SYNCHRONIZED_ENTITY_ANIM` | `bool STOP_SYNCHRONIZED_ENTITY_ANIM(int entity, float p1, bool p2)` | bool | - |
| `STOP_SYNCHRONIZED_MAP_ENTITY_ANIM` | `bool STOP_SYNCHRONIZED_MAP_ENTITY_ANIM(float x1, float y1, float z1, float x2, object y2, float z2)` | bool | - |
| `SUPPRESS_PICKUP_REWARD_TYPE` | `void SUPPRESS_PICKUP_REWARD_TYPE(int rewardType, bool suppress)` | void | enum ePickupRewardType<br>{<br>    PICKUP_REWARD_TYPE_AMMO = (1 << 0),<br>    PICKUP_REWARD_TYPE_BULLET_MP = ... |
| `SUPPRESS_PICKUP_SOUND_FOR_PICKUP` | `void SUPPRESS_PICKUP_SOUND_FOR_PICKUP(object p0, object p1)` | void | - |
| `TRACK_OBJECT_VISIBILITY` | `void TRACK_OBJECT_VISIBILITY(int object)` | void | - |
| `WOULD_ENTITY_BE_OCCLUDED` | `bool WOULD_ENTITY_BE_OCCLUDED(uint entityModelHash, float x, float y, float z, bool p4)` | bool | - |
| `_GET_LAST_ENTITY_HIT_BY_ENTITY` | `int _GET_LAST_ENTITY_HIT_BY_ENTITY(int entity)` | int | - |
| `_SET_ENTITY_NO_COLLISION_WITH_NETWORKED_ENTITY` | `void _SET_ENTITY_NO_COLLISION_WITH_NETWORKED_ENTITY(int entity1, int entity2)` | void | - |
| `_SET_OBJECT_TARGETTABLE_BY_PLAYER` | `void _SET_OBJECT_TARGETTABLE_BY_PLAYER(int object, bool setFlag34, bool setFlag35)` | void | Sets the 34th and 35th object flags related to player peds. |
| `_SET_PICKUP_GLOW_DISABLED` | `void _SET_PICKUP_GLOW_DISABLED(int pickup, bool toggle)` | void | - |

---

## 详细说明

### ADD_DOOR_TO_SYSTEM

- **命名空间:** `OBJECT`
- **Hash:** `0x6F8838D03D1DC226`
- **JHash:** `0x9D2D778D`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_DOOR_TO_SYSTEM(uint doorHash, uint modelHash, float x, float y, float z, bool p5, bool scriptDoor, bool isLocal, object p8)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `doorHash` | `Hash` | `uint` | - |
| `modelHash` | `Hash` | `uint` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p5` | `BOOL` | `bool` | - |
| `scriptDoor` | `BOOL` | `bool` | - |
| `isLocal` | `BOOL` | `bool` | - |
| `p8` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
doorHash has to be unique. scriptDoor false; relies upon getNetworkGameScriptHandler. isLocal On true disables the creation CRequestDoorEvent's in DOOR_SYSTEM_SET_DOOR_STATE.
p5 only set to true in single player native scripts.
If scriptDoor is true, register the door on the script handler host (note: there's a hardcap on the number of script IDs that can be added to the system at a given time). If scriptDoor and isLocal are both false, the door is considered to be in a "Persists w/o netobj" state.

door hashes normally look like PROP_[int]_DOOR_[int] for interior doors and PROP_BUILDING_[int]_DOOR_[int] exterior doors but you can just make up your own hash if you want
All doors need to be registered with ADD_DOOR_TO_SYSTEM before they can be manipulated with the door natives and the easiest way to get door models is just find the door in codewalker.

Example: AddDoorToSystem("PROP_43_DOOR_0", "hei_v_ilev_fh_heistdoor2", -1456.818, -520.5037, 69.67043, 0, 0, 0)
```

---

### ADD_EXTENDED_PICKUP_PROBE_AREA

- **命名空间:** `OBJECT`
- **Hash:** `0xD4A7A435B3710D05`
- **Build:** `1290`

**C# 签名:**
```csharp
void ADD_EXTENDED_PICKUP_PROBE_AREA(float x, float y, float z, float radius)
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
Adds an area that seems to be related to pickup physics behavior.
Max amount of areas is 10. Only works in multiplayer.
```

---

### ADD_TO_ITEMSET

- **命名空间:** `ITEMSET`
- **Hash:** `0xE3945201F14637DD`
- **JHash:** `0x6B0FE61B`
- **Build:** `323`

**C# 签名:**
```csharp
bool ADD_TO_ITEMSET(int item, int itemset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `item` | `ScrHandle` | `int` | - |
| `itemset` | `ScrHandle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### ALLOW_ALL_PLAYERS_TO_COLLECT_PICKUPS_OF_TYPE

- **命名空间:** `OBJECT`
- **Hash:** `0xFDC07C58E8AAB715`
- **Build:** `1734`

**C# 签名:**
```csharp
void ALLOW_ALL_PLAYERS_TO_COLLECT_PICKUPS_OF_TYPE(uint pickupHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickupHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
```

---

### ALLOW_DAMAGE_EVENTS_FOR_NON_NETWORKED_OBJECTS

- **命名空间:** `OBJECT`
- **Hash:** `0xABDABF4E1EDECBFA`
- **Build:** `1365`

**C# 签名:**
```csharp
void ALLOW_DAMAGE_EVENTS_FOR_NON_NETWORKED_OBJECTS(bool value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### ALLOW_PICKUP_ARROW_MARKER_WHEN_UNCOLLECTABLE

- **命名空间:** `OBJECT`
- **Hash:** `0x834344A414C7C85D`
- **Build:** `2372`

**C# 签名:**
```csharp
void ALLOW_PICKUP_ARROW_MARKER_WHEN_UNCOLLECTABLE(int pickup, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### ALLOW_PICKUP_BY_NONE_PARTICIPANT

- **命名空间:** `OBJECT`
- **Hash:** `0xAA059C615DE9DD03`
- **Build:** `1180`

**C# 签名:**
```csharp
void ALLOW_PICKUP_BY_NONE_PARTICIPANT(int pickup, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### ALLOW_PORTABLE_PICKUP_TO_MIGRATE_TO_NON_PARTICIPANTS

- **命名空间:** `OBJECT`
- **Hash:** `0x641F272B52E2F0F8`
- **Build:** `877`

**C# 签名:**
```csharp
void ALLOW_PORTABLE_PICKUP_TO_MIGRATE_TO_NON_PARTICIPANTS(int pickup, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### APPLY_FORCE_TO_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0xC5F68BE9613E2D18`
- **JHash:** `0xC1C0855A`
- **Build:** `323`

**C# 签名:**
```csharp
void APPLY_FORCE_TO_ENTITY(int entity, int forceFlags, float x, float y, float z, float offX, float offY, float offZ, int boneIndex, bool isDirectionRel, bool ignoreUpVec, bool isForceRel, bool p12, bool p13)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `forceFlags` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `offX` | `float` | `float` | - |
| `offY` | `float` | `float` | - |
| `offZ` | `float` | `float` | - |
| `boneIndex` | `int` | `int` | - |
| `isDirectionRel` | `BOOL` | `bool` | - |
| `ignoreUpVec` | `BOOL` | `bool` | - |
| `isForceRel` | `BOOL` | `bool` | - |
| `p12` | `BOOL` | `bool` | - |
| `p13` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Documented here:
gtaforums.com/topic/885669-precisely-define-object-physics/
gtaforums.com/topic/887362-apply-forces-and-momentums-to-entityobject/

forceFlags:
First bit (lowest): Strong force flag, factor 100
Second bit: Unkown flag
Third bit: Momentum flag=1 (vector (x,y,z) is a momentum, more research needed)
If higher bits are unequal 0 the function doesn't applay any forces at all.
(As integer possible values are 0-7)

0: weak force
1: strong force
2: same as 0 (2nd bit?)
3: same as 1
4: weak momentum
5: strong momentum
6: same as 4
7: same as 5

isLocal: vector defined in local (body-fixed) coordinate frame
isMassRel: if true the force gets multiplied with the objects mass (this is why it was known as highForce) and different objects will have the same acceleration.

p8 !!! Whenever I set this !=0, my script stopped.
```

---

### APPLY_FORCE_TO_ENTITY_CENTER_OF_MASS

- **命名空间:** `ENTITY`
- **Hash:** `0x18FF00FC7EFF559E`
- **JHash:** `0x28924E98`
- **Build:** `323`

**C# 签名:**
```csharp
void APPLY_FORCE_TO_ENTITY_CENTER_OF_MASS(int entity, int forceType, float x, float y, float z, bool p5, bool isDirectionRel, bool isForceRel, bool p8)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `forceType` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p5` | `BOOL` | `bool` | - |
| `isDirectionRel` | `BOOL` | `bool` | - |
| `isForceRel` | `BOOL` | `bool` | - |
| `p8` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Applies a force to the specified entity.

**List of force types (p1)**:
public enum ForceType
{
    MinForce = 0,
    MaxForceRot = 1,
    MinForce2 = 2,
    MaxForceRot2 = 3,
    ForceNoRot = 4,
    ForceRotPlusForce = 5
}
Research/documentation on the gtaforums can be found here https://gtaforums.com/topic/885669-precisely-define-object-physics/) and here https://gtaforums.com/topic/887362-apply-forces-and-momentums-to-entityobject/.

p6/relative - makes the xyz force not relative to world coords, but to something else
p7/highForce - setting false will make the force really low
```

---

### ARE_ENTITIES_ENTIRELY_INSIDE_GARAGE

- **命名空间:** `OBJECT`
- **Hash:** `0x85B6C850546FDDE2`
- **JHash:** `0x4BD59750`
- **Build:** `323`

**C# 签名:**
```csharp
bool ARE_ENTITIES_ENTIRELY_INSIDE_GARAGE(uint garageHash, bool p1, bool p2, bool p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `garageHash` | `Hash` | `uint` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### ATTACH_ENTITY_BONE_TO_ENTITY_BONE

- **命名空间:** `ENTITY`
- **Hash:** `0x5C48B75732C8456C`
- **Build:** `791`

**C# 签名:**
```csharp
void ATTACH_ENTITY_BONE_TO_ENTITY_BONE(int entity1, int entity2, int boneIndex1, int boneIndex2, bool p4, bool p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity1` | `Entity` | `int` | - |
| `entity2` | `Entity` | `int` | - |
| `boneIndex1` | `int` | `int` | - |
| `boneIndex2` | `int` | `int` | - |
| `p4` | `BOOL` | `bool` | - |
| `p5` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### ATTACH_ENTITY_BONE_TO_ENTITY_BONE_Y_FORWARD

- **命名空间:** `ENTITY`
- **Hash:** `0xFD1695C5D3B05439`
- **Build:** `791`

**C# 签名:**
```csharp
void ATTACH_ENTITY_BONE_TO_ENTITY_BONE_Y_FORWARD(int entity1, int entity2, int boneIndex1, int boneIndex2, bool p4, bool p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity1` | `Entity` | `int` | - |
| `entity2` | `Entity` | `int` | - |
| `boneIndex1` | `int` | `int` | - |
| `boneIndex2` | `int` | `int` | - |
| `p4` | `BOOL` | `bool` | - |
| `p5` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### ATTACH_ENTITY_TO_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0x6B9BBD38AB0796DF`
- **JHash:** `0xEC024237`
- **Build:** `323`

**C# 签名:**
```csharp
void ATTACH_ENTITY_TO_ENTITY(int entity1, int entity2, int boneIndex, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, bool p9, bool useSoftPinning, bool collision, bool isPed, int vertexIndex, bool fixedRot, object p15)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity1` | `Entity` | `int` | - |
| `entity2` | `Entity` | `int` | - |
| `boneIndex` | `int` | `int` | - |
| `xPos` | `float` | `float` | - |
| `yPos` | `float` | `float` | - |
| `zPos` | `float` | `float` | - |
| `xRot` | `float` | `float` | - |
| `yRot` | `float` | `float` | - |
| `zRot` | `float` | `float` | - |
| `p9` | `BOOL` | `bool` | - |
| `useSoftPinning` | `BOOL` | `bool` | - |
| `collision` | `BOOL` | `bool` | - |
| `isPed` | `BOOL` | `bool` | - |
| `vertexIndex` | `int` | `int` | - |
| `fixedRot` | `BOOL` | `bool` | - |
| `p15` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Attaches entity1 to bone (boneIndex) of entity2.

boneIndex - this is different to boneID, use GET_PED_BONE_INDEX to get the index from the ID. use the index for attaching to specific bones. entity1 will be attached to entity2's centre if bone index given doesn't correspond to bone indexes for that entity type.

useSoftPinning - if set to false attached entity will not detach when fixed
collision - controls collision between the two entities (FALSE disables collision).
isPed - pitch doesnt work when false and roll will only work on negative numbers (only peds)
vertexIndex - position of vertex
fixedRot - if false it ignores entity vector 

```

---

### ATTACH_ENTITY_TO_ENTITY_PHYSICALLY

- **命名空间:** `ENTITY`
- **Hash:** `0xC3675780C92F90F9`
- **JHash:** `0x0547417F`
- **Build:** `323`

**C# 签名:**
```csharp
void ATTACH_ENTITY_TO_ENTITY_PHYSICALLY(int entity1, int entity2, int boneIndex1, int boneIndex2, float xPos1, float yPos1, float zPos1, float xPos2, float yPos2, float zPos2, float xRot, float yRot, float zRot, float breakForce, bool fixedRot, bool p15, bool collision, bool p17, int p18)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity1` | `Entity` | `int` | - |
| `entity2` | `Entity` | `int` | - |
| `boneIndex1` | `int` | `int` | - |
| `boneIndex2` | `int` | `int` | - |
| `xPos1` | `float` | `float` | - |
| `yPos1` | `float` | `float` | - |
| `zPos1` | `float` | `float` | - |
| `xPos2` | `float` | `float` | - |
| `yPos2` | `float` | `float` | - |
| `zPos2` | `float` | `float` | - |
| `xRot` | `float` | `float` | - |
| `yRot` | `float` | `float` | - |
| `zRot` | `float` | `float` | - |
| `breakForce` | `float` | `float` | - |
| `fixedRot` | `BOOL` | `bool` | - |
| `p15` | `BOOL` | `bool` | - |
| `collision` | `BOOL` | `bool` | - |
| `p17` | `BOOL` | `bool` | - |
| `p18` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
breakForce is the amount of force required to break the bond.
p14 - is always 1 in scripts
p15 - is 1 or 0 in scripts - unknoun what it does
p16 - controls collision between the two entities (FALSE disables collision).
p17 - do not teleport entity to be attached to the position of the bone Index of the target entity (if 1, entity will not be teleported to target bone)
p18 - is always 2 in scripts.


```

---

### ATTACH_ENTITY_TO_ENTITY_PHYSICALLY_OVERRIDE_INVERSE_MASS

- **命名空间:** `ENTITY`
- **Hash:** `0x168A09D1B25B0BA4`
- **Build:** `2944`

**C# 签名:**
```csharp
void ATTACH_ENTITY_TO_ENTITY_PHYSICALLY_OVERRIDE_INVERSE_MASS(int firstEntityIndex, int secondEntityIndex, int firstEntityBoneIndex, int secondEntityBoneIndex, float secondEntityOffsetX, float secondEntityOffsetY, float secondEntityOffsetZ, float firstEntityOffsetX, float firstEntityOffsetY, float firstEntityOffsetZ, float vecRotationX, float vecRotationY, float vecRotationZ, float physicalStrength, bool constrainRotation, bool doInitialWarp, bool collideWithEntity, bool addInitialSeperation, int rotOrder, float invMassScaleA, float invMassScaleB)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `firstEntityIndex` | `Entity` | `int` | - |
| `secondEntityIndex` | `Entity` | `int` | - |
| `firstEntityBoneIndex` | `int` | `int` | - |
| `secondEntityBoneIndex` | `int` | `int` | - |
| `secondEntityOffsetX` | `float` | `float` | - |
| `secondEntityOffsetY` | `float` | `float` | - |
| `secondEntityOffsetZ` | `float` | `float` | - |
| `firstEntityOffsetX` | `float` | `float` | - |
| `firstEntityOffsetY` | `float` | `float` | - |
| `firstEntityOffsetZ` | `float` | `float` | - |
| `vecRotationX` | `float` | `float` | - |
| `vecRotationY` | `float` | `float` | - |
| `vecRotationZ` | `float` | `float` | - |
| `physicalStrength` | `float` | `float` | - |
| `constrainRotation` | `BOOL` | `bool` | - |
| `doInitialWarp` | `BOOL` | `bool` | - |
| `collideWithEntity` | `BOOL` | `bool` | - |
| `addInitialSeperation` | `BOOL` | `bool` | - |
| `rotOrder` | `int` | `int` | - |
| `invMassScaleA` | `float` | `float` | - |
| `invMassScaleB` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### ATTACH_PORTABLE_PICKUP_TO_PED

- **命名空间:** `OBJECT`
- **Hash:** `0x8DC39368BDD57755`
- **JHash:** `0x184F6AB3`
- **Build:** `323`

**C# 签名:**
```csharp
void ATTACH_PORTABLE_PICKUP_TO_PED(int pickupObject, int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickupObject` | `Object` | `int` | - |
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### BLOCK_PLAYERS_FOR_AMBIENT_PICKUP

- **命名空间:** `OBJECT`
- **Hash:** `0x1E3F1B1B891A2AAA`
- **Build:** `573`

**C# 签名:**
```csharp
void BLOCK_PLAYERS_FOR_AMBIENT_PICKUP(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### BREAK_OBJECT_FRAGMENT_CHILD

- **命名空间:** `OBJECT`
- **Hash:** `0xE7E4C198B0185900`
- **JHash:** `0x1E82C2AE`
- **Build:** `323`

**C# 签名:**
```csharp
void BREAK_OBJECT_FRAGMENT_CHILD(int p0, object p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Object` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAN_ITEMSET

- **命名空间:** `ITEMSET`
- **Hash:** `0x41BC0D722FC04221`
- **JHash:** `0x919A4858`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAN_ITEMSET(int itemset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `itemset` | `ScrHandle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_ALL_PICKUP_REWARD_TYPE_SUPPRESSION

- **命名空间:** `OBJECT`
- **Hash:** `0xA2C1F5E92AFE49ED`
- **JHash:** `0xB241806C`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_ALL_PICKUP_REWARD_TYPE_SUPPRESSION()
```

**返回值:** `void` (Native: `void`)

---

### CLEAR_ENTITY_LAST_DAMAGE_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0xA72CD9CA74A5ECBA`
- **JHash:** `0x2B83F43B`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_ENTITY_LAST_DAMAGE_ENTITY(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_EXTENDED_PICKUP_PROBE_AREAS

- **命名空间:** `OBJECT`
- **Hash:** `0xB7C6D80FB371659A`
- **Build:** `1290`

**C# 签名:**
```csharp
void CLEAR_EXTENDED_PICKUP_PROBE_AREAS()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Clears all areas created by ADD_EXTENDED_PICKUP_PROBE_AREA
```

---

### CLEAR_GARAGE

- **命名空间:** `OBJECT`
- **Hash:** `0xDA05194260CDCDF9`
- **Build:** `678`

**C# 签名:**
```csharp
void CLEAR_GARAGE(uint garageHash, bool isNetwork)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `garageHash` | `Hash` | `uint` | - |
| `isNetwork` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_OBJECTS_INSIDE_GARAGE

- **命名空间:** `OBJECT`
- **Hash:** `0x190428512B240692`
- **JHash:** `0xA565E27E`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_OBJECTS_INSIDE_GARAGE(uint garageHash, bool vehicles, bool peds, bool objects, bool isNetwork)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `garageHash` | `Hash` | `uint` | - |
| `vehicles` | `BOOL` | `bool` | - |
| `peds` | `BOOL` | `bool` | - |
| `objects` | `BOOL` | `bool` | - |
| `isNetwork` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PICKUP_REWARD_TYPE_SUPPRESSION

- **命名空间:** `OBJECT`
- **Hash:** `0x762DB2D380B48D04`
- **JHash:** `0xD1BAAFB7`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PICKUP_REWARD_TYPE_SUPPRESSION(int rewardType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `rewardType` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLOSE_ALL_BARRIERS_FOR_RACE

- **命名空间:** `OBJECT`
- **Hash:** `0x701FDA1E82076BA4`
- **JHash:** `0xF592AD10`
- **Build:** `323`

**C# 签名:**
```csharp
void CLOSE_ALL_BARRIERS_FOR_RACE()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Clears the fields sets by 0xC7F29CA00F46350E (1604 retail: 0x1424A7A10, 0x1424A7A11) and iterates over the global CDoor's bucket-list.
Related to its "Pre-networked state"?
```

---

### CLOSE_SAFEHOUSE_GARAGES

- **命名空间:** `OBJECT`
- **Hash:** `0x66A49D021870FE88`
- **JHash:** `0x6158959E`
- **Build:** `323`

**C# 签名:**
```csharp
void CLOSE_SAFEHOUSE_GARAGES()
```

**返回值:** `void` (Native: `void`)

---

### CONVERT_OLD_PICKUP_TYPE_TO_NEW

- **命名空间:** `OBJECT`
- **Hash:** `0x5EAAD83F8CFB4575`
- **JHash:** `0x6AE36192`
- **Build:** `323`

**C# 签名:**
```csharp
uint CONVERT_OLD_PICKUP_TYPE_TO_NEW(uint pickupHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickupHash` | `Hash` | `uint` | - |

**返回值:** `uint` (Native: `Hash`)

**说明:**
```
returns pickup hash.

Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
```

---

### CREATE_AMBIENT_PICKUP

- **命名空间:** `OBJECT`
- **Hash:** `0x673966A0C0FD7171`
- **JHash:** `0x17B99CE7`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_AMBIENT_PICKUP(uint pickupHash, float posX, float posY, float posZ, int flags, int value, uint modelHash, bool p7, bool p8)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickupHash` | `Hash` | `uint` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `flags` | `int` | `int` | - |
| `value` | `int` | `int` | - |
| `modelHash` | `Hash` | `uint` | - |
| `p7` | `BOOL` | `bool` | - |
| `p8` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `Object`)

**说明:**
```
Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
```

---

### CREATE_FORCED_OBJECT

- **命名空间:** `ENTITY`
- **Hash:** `0x150E808B375A385A`
- **JHash:** `0x335190A2`
- **Build:** `323`

**C# 签名:**
```csharp
void CREATE_FORCED_OBJECT(float x, float y, float z, object p3, uint modelHash, bool p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p3` | `Any` | `object` | - |
| `modelHash` | `Hash` | `uint` | - |
| `p5` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### CREATE_ITEMSET

- **命名空间:** `ITEMSET`
- **Hash:** `0x35AD299F50D91B24`
- **JHash:** `0x0A113B2C`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_ITEMSET(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `ScrHandle`)

---

### CREATE_MODEL_HIDE

- **命名空间:** `ENTITY`
- **Hash:** `0x8A97BCA30A0CE478`
- **JHash:** `0x7BD5CF2F`
- **Build:** `323`

**C# 签名:**
```csharp
void CREATE_MODEL_HIDE(float x, float y, float z, float radius, uint modelHash, bool p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `modelHash` | `Hash` | `uint` | - |
| `p5` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p5 = sets as true in scripts
Same as the comment for CREATE_MODEL_SWAP unless for some reason p5 affects it this only works with objects as well.

Network players do not see changes done with this.
```

---

### CREATE_MODEL_HIDE_EXCLUDING_SCRIPT_OBJECTS

- **命名空间:** `ENTITY`
- **Hash:** `0x3A52AE588830BF7F`
- **JHash:** `0x07AAF22C`
- **Build:** `323`

**C# 签名:**
```csharp
void CREATE_MODEL_HIDE_EXCLUDING_SCRIPT_OBJECTS(float x, float y, float z, float radius, uint modelHash, bool p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `modelHash` | `Hash` | `uint` | - |
| `p5` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### CREATE_MODEL_SWAP

- **命名空间:** `ENTITY`
- **Hash:** `0x92C47782FDA8B2A3`
- **JHash:** `0x0BC12F9E`
- **Build:** `323`

**C# 签名:**
```csharp
void CREATE_MODEL_SWAP(float x, float y, float z, float radius, uint originalModel, uint newModel, bool p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `originalModel` | `Hash` | `uint` | - |
| `newModel` | `Hash` | `uint` | - |
| `p6` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Only works with objects!
```

---

### CREATE_MONEY_PICKUPS

- **命名空间:** `OBJECT`
- **Hash:** `0x0589B5E791CE9B2B`
- **JHash:** `0x36C9A5EA`
- **Build:** `323`

**C# 签名:**
```csharp
void CREATE_MONEY_PICKUPS(float x, float y, float z, int value, int amount, uint model)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `value` | `int` | `int` | - |
| `amount` | `int` | `int` | - |
| `model` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Spawns one or more money pickups.

x: The X-component of the world position to spawn the money pickups at.
y: The Y-component of the world position to spawn the money pickups at.
z: The Z-component of the world position to spawn the money pickups at.
value: The combined value of the pickups (in dollars).
amount: The number of pickups to spawn.
model: The model to use, or 0 for default money model.

Example:
CREATE_MONEY_PICKUPS(x, y, z, 1000, 3, 0x684a97ae);

Spawns 3 spray cans that'll collectively give $1000 when picked up. (Three spray cans, each giving $334, $334, $332 = $1000).

==============================================

Max is 2000 in MP. So if you put the amount to 20, but the value to $400,000 eg. They will only be able to pickup 20 - $2,000 bags. So, $40,000
```

---

### CREATE_NON_NETWORKED_AMBIENT_PICKUP

- **命名空间:** `OBJECT`
- **Hash:** `0x9C93764223E29C50`
- **Build:** `2372`

**C# 签名:**
```csharp
int CREATE_NON_NETWORKED_AMBIENT_PICKUP(uint pickupHash, float posX, float posY, float posZ, int flags, int value, uint modelHash, bool p7, bool p8)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickupHash` | `Hash` | `uint` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `flags` | `int` | `int` | - |
| `value` | `int` | `int` | - |
| `modelHash` | `Hash` | `uint` | - |
| `p7` | `BOOL` | `bool` | - |
| `p8` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `Object`)

---

### CREATE_NON_NETWORKED_PORTABLE_PICKUP

- **命名空间:** `OBJECT`
- **Hash:** `0x125494B98A21AAF7`
- **JHash:** `0x56A02502`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_NON_NETWORKED_PORTABLE_PICKUP(uint pickupHash, float x, float y, float z, bool placeOnGround, uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickupHash` | `Hash` | `uint` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `placeOnGround` | `BOOL` | `bool` | - |
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `Object`)

**说明:**
```
Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
```

---

### CREATE_OBJECT

- **命名空间:** `OBJECT`
- **Hash:** `0x509D5878EB39E842`
- **JHash:** `0x2F7AA05C`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_OBJECT(uint modelHash, float x, float y, float z, bool isNetwork, bool bScriptHostObj, bool dynamic)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `isNetwork` | `BOOL` | `bool` | - |
| `bScriptHostObj` | `BOOL` | `bool` | - |
| `dynamic` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `Object`)

**说明:**
```
List of object models that can be created without any additional effort like making sure ytyp is loaded etc: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/ObjectList.ini
```

---

### CREATE_OBJECT_NO_OFFSET

- **命名空间:** `OBJECT`
- **Hash:** `0x9A294B2138ABB884`
- **JHash:** `0x58040420`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_OBJECT_NO_OFFSET(uint modelHash, float x, float y, float z, bool isNetwork, bool bScriptHostObj, bool dynamic, object p7)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `isNetwork` | `BOOL` | `bool` | - |
| `bScriptHostObj` | `BOOL` | `bool` | - |
| `dynamic` | `BOOL` | `bool` | - |
| `p7` | `Any` | `object` | - |

**返回值:** `int` (Native: `Object`)

**说明:**
```
List of object models that can be created without any additional effort like making sure ytyp is loaded etc: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/ObjectList.ini
```

---

### CREATE_PICKUP

- **命名空间:** `OBJECT`
- **Hash:** `0xFBA08C503DD5FA58`
- **JHash:** `0x5E14DF68`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_PICKUP(uint pickupHash, float posX, float posY, float posZ, int p4, int value, bool p6, uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickupHash` | `Hash` | `uint` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `p4` | `int` | `int` | - |
| `value` | `int` | `int` | - |
| `p6` | `BOOL` | `bool` | - |
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `Pickup`)

**说明:**
```
Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
```

---

### CREATE_PICKUP_ROTATE

- **命名空间:** `OBJECT`
- **Hash:** `0x891804727E0A98B7`
- **JHash:** `0xF015BFE2`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_PICKUP_ROTATE(uint pickupHash, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, int flag, int amount, object p9, bool p10, uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickupHash` | `Hash` | `uint` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `rotX` | `float` | `float` | - |
| `rotY` | `float` | `float` | - |
| `rotZ` | `float` | `float` | - |
| `flag` | `int` | `int` | - |
| `amount` | `int` | `int` | - |
| `p9` | `Any` | `object` | - |
| `p10` | `BOOL` | `bool` | - |
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `Pickup`)

**说明:**
```
flags:
8 (1 << 3): place on ground
512 (1 << 9): spin around

Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
```

---

### CREATE_PORTABLE_PICKUP

- **命名空间:** `OBJECT`
- **Hash:** `0x2EAF1FDB2FB55698`
- **JHash:** `0x8C886BE5`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_PORTABLE_PICKUP(uint pickupHash, float x, float y, float z, bool placeOnGround, uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickupHash` | `Hash` | `uint` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `placeOnGround` | `BOOL` | `bool` | - |
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `Object`)

**说明:**
```
Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
```

---

### DAMAGE_OBJECT_FRAGMENT_CHILD

- **命名空间:** `OBJECT`
- **Hash:** `0xE05F6AEEFEB0BB02`
- **Build:** `1180`

**C# 签名:**
```csharp
void DAMAGE_OBJECT_FRAGMENT_CHILD(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### DELETE_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0xAE3CBE5BF394C9C9`
- **JHash:** `0xFAA3D236`
- **Build:** `323`

**C# 签名:**
```csharp
void DELETE_ENTITY(Entity* entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity*` | `Entity*` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Deletes the specified entity, then sets the handle pointed to by the pointer to NULL.
```

---

### DELETE_OBJECT

- **命名空间:** `OBJECT`
- **Hash:** `0x539E0AE3E6634B9F`
- **JHash:** `0xD6EF9DA7`
- **Build:** `323`

**C# 签名:**
```csharp
void DELETE_OBJECT(Object* object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object*` | `Object*` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Deletes the specified object, then sets the handle pointed to by the pointer to NULL.
```

---

### DESTROY_ITEMSET

- **命名空间:** `ITEMSET`
- **Hash:** `0xDE18220B1C183EDA`
- **JHash:** `0x83CE1A4C`
- **Build:** `323`

**C# 签名:**
```csharp
void DESTROY_ITEMSET(int itemset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `itemset` | `ScrHandle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DETACH_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0x961AC54BF0613F5D`
- **JHash:** `0xC8EFCB41`
- **Build:** `323`

**C# 签名:**
```csharp
void DETACH_ENTITY(int entity, bool dynamic, bool collision)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `dynamic` | `BOOL` | `bool` | - |
| `collision` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
If `collision` is set to true, both entities won't collide with the other until the distance between them is above 4 meters.
Set `dynamic` to true to keep velocity after dettaching
```

---

### DETACH_PORTABLE_PICKUP_FROM_PED

- **命名空间:** `OBJECT`
- **Hash:** `0xCF463D1E9A0AECB1`
- **JHash:** `0x1D094562`
- **Build:** `323`

**C# 签名:**
```csharp
void DETACH_PORTABLE_PICKUP_FROM_PED(int pickupObject)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickupObject` | `Object` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DISABLE_TIDYING_UP_IN_GARAGE

- **命名空间:** `OBJECT`
- **Hash:** `0x659F9D71F52843F8`
- **Build:** `1290`

**C# 签名:**
```csharp
void DISABLE_TIDYING_UP_IN_GARAGE(int id, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `id` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets a flag. A valid id is 0x157DC10D
```

---

### DOES_ENTITY_BELONG_TO_THIS_SCRIPT

- **命名空间:** `ENTITY`
- **Hash:** `0xDDE6DF5AE89981D2`
- **JHash:** `0xACFEB3F9`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_ENTITY_BELONG_TO_THIS_SCRIPT(int entity, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DOES_ENTITY_EXIST

- **命名空间:** `ENTITY`
- **Hash:** `0x7239B21A38F536BA`
- **JHash:** `0x3AC90869`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_ENTITY_EXIST(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Checks whether an entity exists in the game world.
```

---

### DOES_ENTITY_HAVE_ANIM_DIRECTOR

- **命名空间:** `ENTITY`
- **Hash:** `0x2158E81A6AF65EA9`
- **Build:** `2699`

**C# 签名:**
```csharp
bool DOES_ENTITY_HAVE_ANIM_DIRECTOR(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DOES_ENTITY_HAVE_DRAWABLE

- **命名空间:** `ENTITY`
- **Hash:** `0x060D6E96F8B8E48D`
- **JHash:** `0xA5B33300`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_ENTITY_HAVE_DRAWABLE(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DOES_ENTITY_HAVE_PHYSICS

- **命名空间:** `ENTITY`
- **Hash:** `0xDA95EA3317CC5064`
- **JHash:** `0x9BCD2979`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_ENTITY_HAVE_PHYSICS(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DOES_ENTITY_HAVE_SKELETON

- **命名空间:** `ENTITY`
- **Hash:** `0x764EB96874EFFDC1`
- **Build:** `2699`

**C# 签名:**
```csharp
bool DOES_ENTITY_HAVE_SKELETON(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DOES_OBJECT_OF_TYPE_EXIST_AT_COORDS

- **命名空间:** `OBJECT`
- **Hash:** `0xBFA48E2FF417213F`
- **JHash:** `0x23FF2BA4`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_OBJECT_OF_TYPE_EXIST_AT_COORDS(float x, float y, float z, float radius, uint hash, bool p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `hash` | `Hash` | `uint` | - |
| `p5` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p5 is usually 0.
```

---

### DOES_PICKUP_EXIST

- **命名空间:** `OBJECT`
- **Hash:** `0xAFC1CA75AD4074D1`
- **JHash:** `0x9C6DA0B3`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_PICKUP_EXIST(int pickup)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DOES_PICKUP_OBJECT_EXIST

- **命名空间:** `OBJECT`
- **Hash:** `0xD9EFB6DBF7DAAEA3`
- **JHash:** `0xE0B32108`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_PICKUP_OBJECT_EXIST(int pickupObject)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickupObject` | `Object` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DOES_PICKUP_OF_TYPE_EXIST_IN_AREA

- **命名空间:** `OBJECT`
- **Hash:** `0xF9C36251F6E48E33`
- **JHash:** `0xF139681B`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_PICKUP_OF_TYPE_EXIST_IN_AREA(uint pickupHash, float x, float y, float z, float radius)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickupHash` | `Hash` | `uint` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
```

---

### DOES_RAYFIRE_MAP_OBJECT_EXIST

- **命名空间:** `OBJECT`
- **Hash:** `0x52AF537A0C5B8AAD`
- **JHash:** `0xE08C834D`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_RAYFIRE_MAP_OBJECT_EXIST(int object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if a destructible object with this handle exists, false otherwise.  
```

---

### DOOR_SYSTEM_FIND_EXISTING_DOOR

- **命名空间:** `OBJECT`
- **Hash:** `0x589F80B325CC82C5`
- **JHash:** `0xE9AE494F`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOOR_SYSTEM_FIND_EXISTING_DOOR(float x, float y, float z, uint modelHash, Hash* outDoorHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `modelHash` | `Hash` | `uint` | - |
| `outDoorHash` | `Hash*` | `Hash*` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Search radius: 0.5
```

---

### DOOR_SYSTEM_GET_AUTOMATIC_DISTANCE

- **命名空间:** `OBJECT`
- **Hash:** `0xE851471AEFC3374F`
- **Build:** `1868`

**C# 签名:**
```csharp
float DOOR_SYSTEM_GET_AUTOMATIC_DISTANCE(uint doorHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `doorHash` | `Hash` | `uint` | - |

**返回值:** `float` (Native: `float`)

---

### DOOR_SYSTEM_GET_DOOR_PENDING_STATE

- **命名空间:** `OBJECT`
- **Hash:** `0x4BC2854478F3A749`
- **JHash:** `0xD649B7E1`
- **Build:** `323`

**C# 签名:**
```csharp
int DOOR_SYSTEM_GET_DOOR_PENDING_STATE(uint doorHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `doorHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

---

### DOOR_SYSTEM_GET_DOOR_STATE

- **命名空间:** `OBJECT`
- **Hash:** `0x160AA1B32F6139B8`
- **JHash:** `0xD42A41C2`
- **Build:** `323`

**C# 签名:**
```csharp
int DOOR_SYSTEM_GET_DOOR_STATE(uint doorHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `doorHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

---

### DOOR_SYSTEM_GET_IS_PHYSICS_LOADED

- **命名空间:** `OBJECT`
- **Hash:** `0xDF97CDD4FC08FD34`
- **JHash:** `0x17FF9393`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOOR_SYSTEM_GET_IS_PHYSICS_LOADED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DOOR_SYSTEM_GET_IS_SPRING_REMOVED

- **命名空间:** `OBJECT`
- **Hash:** `0x8562FD8AB1E94D39`
- **Build:** `3407`

**C# 签名:**
```csharp
bool DOOR_SYSTEM_GET_IS_SPRING_REMOVED(uint doorHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `doorHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DOOR_SYSTEM_GET_OPEN_RATIO

- **命名空间:** `OBJECT`
- **Hash:** `0x65499865FCA6E5EC`
- **JHash:** `0xB74C3BD7`
- **Build:** `323`

**C# 签名:**
```csharp
float DOOR_SYSTEM_GET_OPEN_RATIO(uint doorHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `doorHash` | `Hash` | `uint` | - |

**返回值:** `float` (Native: `float`)

---

### DOOR_SYSTEM_SET_AUTOMATIC_DISTANCE

- **命名空间:** `OBJECT`
- **Hash:** `0x9BA001CB45CBF627`
- **JHash:** `0x47531446`
- **Build:** `323`

**C# 签名:**
```csharp
void DOOR_SYSTEM_SET_AUTOMATIC_DISTANCE(uint doorHash, float distance, bool requestDoor, bool forceUpdate)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `doorHash` | `Hash` | `uint` | - |
| `distance` | `float` | `float` | - |
| `requestDoor` | `BOOL` | `bool` | - |
| `forceUpdate` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
`forceUpdate` on true invokes DOOR_SYSTEM_SET_DOOR_STATE otherwise requestDoor is unused.
```

---

### DOOR_SYSTEM_SET_AUTOMATIC_RATE

- **命名空间:** `OBJECT`
- **Hash:** `0x03C27E13B42A0E82`
- **JHash:** `0x4F44AF21`
- **Build:** `323`

**C# 签名:**
```csharp
void DOOR_SYSTEM_SET_AUTOMATIC_RATE(uint doorHash, float rate, bool requestDoor, bool forceUpdate)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `doorHash` | `Hash` | `uint` | - |
| `rate` | `float` | `float` | - |
| `requestDoor` | `BOOL` | `bool` | - |
| `forceUpdate` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Includes networking check: ownership vs. or the door itself **isn't** networked.
`forceUpdate` on true invokes DOOR_SYSTEM_SET_DOOR_STATE otherwise requestDoor is unused.
```

---

### DOOR_SYSTEM_SET_DOOR_OPEN_FOR_RACES

- **命名空间:** `OBJECT`
- **Hash:** `0xA85A21582451E951`
- **JHash:** `0xF736227C`
- **Build:** `323`

**C# 签名:**
```csharp
void DOOR_SYSTEM_SET_DOOR_OPEN_FOR_RACES(uint doorHash, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `doorHash` | `Hash` | `uint` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Some property related to gates. Native name between ``DOOR_SYSTEM_SET_AUTOMATIC_RATE`` and ``DOOR_SYSTEM_SET_DOOR_STATE``.
```

---

### DOOR_SYSTEM_SET_DOOR_STATE

- **命名空间:** `OBJECT`
- **Hash:** `0x6BAB9442830C7F53`
- **JHash:** `0xDF83DB47`
- **Build:** `323`

**C# 签名:**
```csharp
void DOOR_SYSTEM_SET_DOOR_STATE(uint doorHash, int state, bool requestDoor, bool forceUpdate)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `doorHash` | `Hash` | `uint` | - |
| `state` | `int` | `int` | - |
| `requestDoor` | `BOOL` | `bool` | - |
| `forceUpdate` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Lockstates not applied and CNetObjDoor's not created until DOOR_SYSTEM_GET_IS_PHYSICS_LOADED returns true.
`requestDoor` on true, and when door system is configured to, i.e., "persists w/o netobj", generate a CRequestDoorEvent.
`forceUpdate` on true, forces an update on the door system (same path as netObjDoor_applyDoorStuff)
Door lock states:
0: UNLOCKED
1: LOCKED
2: DOORSTATE_FORCE_LOCKED_UNTIL_OUT_OF_AREA
3: DOORSTATE_FORCE_UNLOCKED_THIS_FRAME
4: DOORSTATE_FORCE_LOCKED_THIS_FRAME
5: DOORSTATE_FORCE_OPEN_THIS_FRAME
6: DOORSTATE_FORCE_CLOSED_THIS_FRAME
```

---

### DOOR_SYSTEM_SET_HOLD_OPEN

- **命名空间:** `OBJECT`
- **Hash:** `0xD9B71952F78A2640`
- **JHash:** `0xECE58AE0`
- **Build:** `323`

**C# 签名:**
```csharp
void DOOR_SYSTEM_SET_HOLD_OPEN(uint doorHash, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `doorHash` | `Hash` | `uint` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Includes networking check: ownership vs. or the door itself **isn't** networked.
```

---

### DOOR_SYSTEM_SET_OPEN_RATIO

- **命名空间:** `OBJECT`
- **Hash:** `0xB6E6FBA95C7324AC`
- **JHash:** `0x34883DE3`
- **Build:** `323`

**C# 签名:**
```csharp
void DOOR_SYSTEM_SET_OPEN_RATIO(uint doorHash, float ajar, bool requestDoor, bool forceUpdate)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `doorHash` | `Hash` | `uint` | - |
| `ajar` | `float` | `float` | - |
| `requestDoor` | `BOOL` | `bool` | - |
| `forceUpdate` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the ajar angle of a door.
Ranges from -1.0 to 1.0, and 0.0 is closed / default.
`forceUpdate` on true invokes DOOR_SYSTEM_SET_DOOR_STATE otherwise requestDoor is unused.
```

---

### DOOR_SYSTEM_SET_SPRING_REMOVED

- **命名空间:** `OBJECT`
- **Hash:** `0xC485E07E4F0B7958`
- **JHash:** `0xB4A9A558`
- **Build:** `323`

**C# 签名:**
```csharp
void DOOR_SYSTEM_SET_SPRING_REMOVED(uint doorHash, bool removed, bool requestDoor, bool forceUpdate)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `doorHash` | `Hash` | `uint` | - |
| `removed` | `BOOL` | `bool` | - |
| `requestDoor` | `BOOL` | `bool` | - |
| `forceUpdate` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Includes networking check: ownership vs. or the door itself **isn't** networked.
`forceUpdate` on true invokes DOOR_SYSTEM_SET_DOOR_STATE otherwise requestDoor is unused.
```

---

### ENABLE_ENTITY_BULLET_COLLISION

- **命名空间:** `ENTITY`
- **Hash:** `0x6CE177D014502E8A`
- **Build:** `877`

**C# 签名:**
```csharp
void ENABLE_ENTITY_BULLET_COLLISION(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### ENABLE_SAVING_IN_GARAGE

- **命名空间:** `OBJECT`
- **Hash:** `0xF2E1A7133DD356A6`
- **JHash:** `0x43BB7E48`
- **Build:** `323`

**C# 签名:**
```csharp
void ENABLE_SAVING_IN_GARAGE(uint garageHash, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `garageHash` | `Hash` | `uint` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### FIND_ANIM_EVENT_PHASE

- **命名空间:** `ENTITY`
- **Hash:** `0x07F1BE2BCCAA27A7`
- **JHash:** `0xC41DDA62`
- **Build:** `323`

**C# 签名:**
```csharp
bool FIND_ANIM_EVENT_PHASE(string animDictionary, string animName, string p2, ref object p3, ref object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `animDictionary` | `const char*` | `string` | - |
| `animName` | `const char*` | `string` | - |
| `p2` | `const char*` | `string` | - |
| `p3` | `Any*` | `ref object` | - |
| `p4` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
In the script "player_scene_t_bbfight.c4":
"if (ENTITY::FIND_ANIM_EVENT_PHASE(&l_16E, &l_19F[v_4/*16*/], v_9, &v_A, &v_B))"
-- &l_16E (p0) is requested as an anim dictionary earlier in the script.
-- &l_19F[v_4/*16*/] (p1) is used in other natives in the script as the "animation" param.
-- v_9 (p2) is instantiated as "victim_fall"; I'm guessing that's another anim
--v_A and v_B (p3 & p4) are both set as -1.0, but v_A is used immediately after this native for: 
"if (v_A < ENTITY::GET_ENTITY_ANIM_CURRENT_TIME(...))"
Both v_A and v_B are seemingly used to contain both Vector3's and floats, so I can't say what either really is other than that they are both output parameters. p4 looks more like a *Vector3 though

Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### FIX_OBJECT_FRAGMENT

- **命名空间:** `OBJECT`
- **Hash:** `0xF9C1681347C8BD15`
- **Build:** `323`

**C# 签名:**
```csharp
void FIX_OBJECT_FRAGMENT(int object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### FORCE_ACTIVATE_PHYSICS_ON_UNFIXED_PICKUP

- **命名空间:** `OBJECT`
- **Hash:** `0x4C134B4DF76025D0`
- **Build:** `1180`

**C# 签名:**
```csharp
void FORCE_ACTIVATE_PHYSICS_ON_UNFIXED_PICKUP(int pickup, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### FORCE_ENTITY_AI_AND_ANIMATION_UPDATE

- **命名空间:** `ENTITY`
- **Hash:** `0x40FDEDB72F8293B2`
- **JHash:** `0x58D9775F`
- **Build:** `323`

**C# 签名:**
```csharp
void FORCE_ENTITY_AI_AND_ANIMATION_UPDATE(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Based on carmod_shop script decompile this takes a vehicle parameter. It is called when repair is done on initial enter.
```

---

### FORCE_PICKUP_REGENERATE

- **命名空间:** `OBJECT`
- **Hash:** `0x758A5C1B3B1E1990`
- **Build:** `1011`

**C# 签名:**
```csharp
void FORCE_PICKUP_REGENERATE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### FORCE_PICKUP_ROTATE_FACE_UP

- **命名空间:** `OBJECT`
- **Hash:** `0x394CD08E31313C28`
- **Build:** `944`

**C# 签名:**
```csharp
void FORCE_PICKUP_ROTATE_FACE_UP()
```

**返回值:** `void` (Native: `void`)

---

### FORCE_PORTABLE_PICKUP_LAST_ACCESSIBLE_POSITION_SETTING

- **命名空间:** `OBJECT`
- **Hash:** `0x5CE2E45A5CE2E45A`
- **Build:** `2545`

**C# 签名:**
```csharp
void FORCE_PORTABLE_PICKUP_LAST_ACCESSIBLE_POSITION_SETTING(int object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### FREEZE_ENTITY_POSITION

- **命名空间:** `ENTITY`
- **Hash:** `0x428CA6DBD1094446`
- **JHash:** `0x65C16D57`
- **Build:** `323`

**C# 签名:**
```csharp
void FREEZE_ENTITY_POSITION(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Freezes or unfreezes an entity preventing its coordinates to change by the player if set to `true`. You can still change the entity position using SET_ENTITY_COORDS.
```

---

### GET_ANIM_DURATION

- **命名空间:** `ENTITY`
- **Hash:** `0xFEDDF04D62B8D790`
- **JHash:** `0x8B5E3E3D`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_ANIM_DURATION(string animDict, string animName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `animDict` | `const char*` | `string` | - |
| `animName` | `const char*` | `string` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### GET_CLOSEST_OBJECT_OF_TYPE

- **命名空间:** `OBJECT`
- **Hash:** `0xE143FA2249364369`
- **JHash:** `0x45619B33`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_CLOSEST_OBJECT_OF_TYPE(float x, float y, float z, float radius, uint modelHash, bool isMission, bool p6, bool p7)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `modelHash` | `Hash` | `uint` | - |
| `isMission` | `BOOL` | `bool` | - |
| `p6` | `BOOL` | `bool` | - |
| `p7` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `Object`)

**说明:**
```
Has 8 params in the latest patches.

isMission - if true doesn't return mission objects
```

---

### GET_COLLISION_NORMAL_OF_LAST_HIT_FOR_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0xE465D4AB7CA6AE72`
- **JHash:** `0xAB415C07`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_COLLISION_NORMAL_OF_LAST_HIT_FOR_ENTITY(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

---

### GET_COORDS_AND_ROTATION_OF_CLOSEST_OBJECT_OF_TYPE

- **命名空间:** `OBJECT`
- **Hash:** `0x163F8B586BC95F2A`
- **JHash:** `0x65213FC3`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_COORDS_AND_ROTATION_OF_CLOSEST_OBJECT_OF_TYPE(float x, float y, float z, float radius, uint modelHash, ref Vector3 outPosition, ref Vector3 outRotation, int rotationOrder)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `modelHash` | `Hash` | `uint` | - |
| `outPosition` | `Vector3*` | `ref Vector3` | - |
| `outRotation` | `Vector3*` | `ref Vector3` | - |
| `rotationOrder` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_DEFAULT_AMMO_FOR_WEAPON_PICKUP

- **命名空间:** `OBJECT`
- **Hash:** `0xDB41D07A45A6D4B7`
- **JHash:** `0x000E92DC`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_DEFAULT_AMMO_FOR_WEAPON_PICKUP(uint pickupHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickupHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

---

### GET_ENTITY_ALPHA

- **命名空间:** `ENTITY`
- **Hash:** `0x5A47B3B5E63E94C6`
- **JHash:** `0x1560B017`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_ENTITY_ALPHA(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_ENTITY_ANIM_CURRENT_TIME

- **命名空间:** `ENTITY`
- **Hash:** `0x346D81500D088F42`
- **JHash:** `0x83943F41`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_ENTITY_ANIM_CURRENT_TIME(int entity, string animDict, string animName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `animDict` | `const char*` | `string` | - |
| `animName` | `const char*` | `string` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Returns a float value representing animation's current playtime with respect to its total playtime. This value increasing in a range from [0 to 1] and wrap back to 0 when it reach 1.

Example:
0.000000 - mark the starting of animation.
0.500000 - mark the midpoint of the animation.
1.000000 - mark the end of animation.

Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### GET_ENTITY_ANIM_TOTAL_TIME

- **命名空间:** `ENTITY`
- **Hash:** `0x50BD2730B191E360`
- **JHash:** `0x433A9D18`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_ENTITY_ANIM_TOTAL_TIME(int entity, string animDict, string animName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `animDict` | `const char*` | `string` | - |
| `animName` | `const char*` | `string` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Returns a float value representing animation's total playtime in milliseconds.

Example:
GET_ENTITY_ANIM_TOTAL_TIME(PLAYER_ID(),"amb@world_human_yoga@female@base","base_b") 
return 20800.000000

Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### GET_ENTITY_ATTACHED_TO

- **命名空间:** `ENTITY`
- **Hash:** `0x48C2BED9180FE123`
- **JHash:** `0xFE1589F9`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_ENTITY_ATTACHED_TO(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `int` (Native: `Entity`)

---

### GET_ENTITY_BONE_COUNT

- **命名空间:** `ENTITY`
- **Hash:** `0xB328DCC3A3AA401B`
- **Build:** `791`

**C# 签名:**
```csharp
int GET_ENTITY_BONE_COUNT(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_ENTITY_BONE_INDEX_BY_NAME

- **命名空间:** `ENTITY`
- **Hash:** `0xFB71170B7E76ACBA`
- **JHash:** `0xE4ECAC22`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_ENTITY_BONE_INDEX_BY_NAME(int entity, string boneName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `boneName` | `const char*` | `string` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns the index of the bone. If the bone was not found, -1 will be returned. 

list:
https://pastebin.com/D7JMnX1g

BoneNames:
  chassis,
  windscreen,
   seat_pside_r,
 seat_dside_r,
 bodyshell,
    suspension_lm,
    suspension_lr,
    platelight,
   attach_female,
    attach_male,
  bonnet,
   boot,
 chassis_dummy,  //Center of the dummy
 chassis_Control,    //Not found yet
   door_dside_f,   //Door left, front
    door_dside_r,   //Door left, back
 door_pside_f,   //Door right, front
   door_pside_r,   //Door right, back
    Gun_GripR,
    windscreen_f,
 platelight, //Position where the light above the numberplate is located
   VFX_Emitter,
  window_lf,  //Window left, front
  window_lr,  //Window left, back
   window_rf,  //Window right, front
 window_rr,  //Window right, back
  engine, //Position of the engine
  gun_ammo,
 ROPE_ATTATCH,   //Not misspelled. In script "finale_heist2b.c4".
    wheel_lf,   //Wheel left, front
   wheel_lr,   //Wheel left, back
    wheel_rf,   //Wheel right, front
  wheel_rr,   //Wheel right, back
   exhaust,    //Exhaust. shows only the position of the stock-exhaust
   overheat,   //A position on the engine(not exactly sure, how to name it)
  misc_e, //Not a car-bone.
 seat_dside_f,   //Driver-seat
 seat_pside_f,   //Seat next to driver
 Gun_Nuzzle,
   seat_r

I doubt that the function is case-sensitive, since I found a "Chassis" and a "chassis". - Just tested: Definitely not case-sensitive.


```

---

### GET_ENTITY_BONE_OBJECT_POSTION

- **命名空间:** `ENTITY`
- **Hash:** `0xCF1247CC86961FD6`
- **Build:** `2802`

**C# 签名:**
```csharp
Vector3 GET_ENTITY_BONE_OBJECT_POSTION(int entity, int boneIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `boneIndex` | `int` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

---

### GET_ENTITY_BONE_OBJECT_ROTATION

- **命名空间:** `ENTITY`
- **Hash:** `0xBD8D32550E5CEBFE`
- **Build:** `1734`

**C# 签名:**
```csharp
Vector3 GET_ENTITY_BONE_OBJECT_ROTATION(int entity, int boneIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `boneIndex` | `int` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
Gets the local rotation of the specified bone of the specified entity.
```

---

### GET_ENTITY_BONE_POSTION

- **命名空间:** `ENTITY`
- **Hash:** `0x46F8696933A63C9B`
- **Build:** `877`

**C# 签名:**
```csharp
Vector3 GET_ENTITY_BONE_POSTION(int entity, int boneIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `boneIndex` | `int` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
Gets the world position of the specified bone of the specified entity.
```

---

### GET_ENTITY_BONE_ROTATION

- **命名空间:** `ENTITY`
- **Hash:** `0xCE6294A232D03786`
- **Build:** `791`

**C# 签名:**
```csharp
Vector3 GET_ENTITY_BONE_ROTATION(int entity, int boneIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `boneIndex` | `int` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
Gets the world rotation of the specified bone of the specified entity.
```

---

### GET_ENTITY_CAN_BE_DAMAGED

- **命名空间:** `ENTITY`
- **Hash:** `0xD95CC5D2AB15A09F`
- **JHash:** `0xE4938B5D`
- **Build:** `757`

**C# 签名:**
```csharp
bool GET_ENTITY_CAN_BE_DAMAGED(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_ENTITY_COLLISION_DISABLED

- **命名空间:** `ENTITY`
- **Hash:** `0xCCF1E97BEFDAE480`
- **JHash:** `0xE8C0C629`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_ENTITY_COLLISION_DISABLED(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_ENTITY_COORDS

- **命名空间:** `ENTITY`
- **Hash:** `0x3FEF770D40960D5A`
- **JHash:** `0x1647F1CB`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_ENTITY_COORDS(int entity, bool alive)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `alive` | `BOOL` | `bool` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
Gets the current coordinates for a specified entity.
`entity` = The entity to get the coordinates from.
`alive` = Unused by the game, potentially used by debug builds of GTA in order to assert whether or not an entity was alive.
```

---

### GET_ENTITY_FORWARD_VECTOR

- **命名空间:** `ENTITY`
- **Hash:** `0x0A794A5A57F8DF91`
- **JHash:** `0x84DCECBF`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_ENTITY_FORWARD_VECTOR(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
Gets the entity's forward vector.
```

---

### GET_ENTITY_FORWARD_X

- **命名空间:** `ENTITY`
- **Hash:** `0x8BB4EF4214E0E6D5`
- **JHash:** `0x49FAE914`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_ENTITY_FORWARD_X(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Gets the X-component of the entity's forward vector.
```

---

### GET_ENTITY_FORWARD_Y

- **命名空间:** `ENTITY`
- **Hash:** `0x866A4A5FAE349510`
- **JHash:** `0x9E2F917C`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_ENTITY_FORWARD_Y(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Gets the Y-component of the entity's forward vector.
```

---

### GET_ENTITY_HEADING

- **命名空间:** `ENTITY`
- **Hash:** `0xE83D4F9BA2A38914`
- **JHash:** `0x972CC383`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_ENTITY_HEADING(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Returns the heading of the entity in degrees. Also know as the "Yaw" of an entity.
```

---

### GET_ENTITY_HEADING_FROM_EULERS

- **命名空间:** `ENTITY`
- **Hash:** `0x846BF6291198A71E`
- **JHash:** `0x9320E642`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_ENTITY_HEADING_FROM_EULERS(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Gets the heading of the entity physics in degrees, which tends to be more accurate than just "GET_ENTITY_HEADING". This can be clearly seen while, for example, ragdolling a ped/player.

NOTE: The name and description of this native are based on independent research. If you find this native to be more suitable under a different name and/or described differently, please feel free to do so.
```

---

### GET_ENTITY_HEALTH

- **命名空间:** `ENTITY`
- **Hash:** `0xEEF059FAD016D209`
- **JHash:** `0x8E3222B7`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_ENTITY_HEALTH(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns an integer value of entity's current health.

Example of range for ped:
- Player [0 to 200]
- Ped [100 to 200]
- Vehicle [0 to 1000]
- Object [0 to 1000]

Health is actually a float value but this native casts it to int.
In order to get the actual value, do:
float health = *(float *)(entityAddress + 0x280);
```

---

### GET_ENTITY_HEIGHT

- **命名空间:** `ENTITY`
- **Hash:** `0x5A504562485944DD`
- **JHash:** `0xEE443481`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_ENTITY_HEIGHT(int entity, float X, float Y, float Z, bool atTop, bool inWorldCoords)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `X` | `float` | `float` | - |
| `Y` | `float` | `float` | - |
| `Z` | `float` | `float` | - |
| `atTop` | `BOOL` | `bool` | - |
| `inWorldCoords` | `BOOL` | `bool` | - |

**返回值:** `float` (Native: `float`)

---

### GET_ENTITY_HEIGHT_ABOVE_GROUND

- **命名空间:** `ENTITY`
- **Hash:** `0x1DD55701034110E5`
- **JHash:** `0x57F56A4D`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_ENTITY_HEIGHT_ABOVE_GROUND(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Return height (z-dimension) above ground. 
Example: The pilot in a titan plane is 1.844176 above ground.

How can i convert it to meters?
Everything seems to be in meters, probably this too.
```

---

### GET_ENTITY_LOD_DIST

- **命名空间:** `ENTITY`
- **Hash:** `0x4159C2762B5791D6`
- **JHash:** `0x4DA3D51F`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_ENTITY_LOD_DIST(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns the LOD distance of an entity.
```

---

### GET_ENTITY_MATRIX

- **命名空间:** `ENTITY`
- **Hash:** `0xECB2FC7235A7D137`
- **JHash:** `0xEB9EB001`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_ENTITY_MATRIX(int entity, ref Vector3 forwardVector, ref Vector3 rightVector, ref Vector3 upVector, ref Vector3 position)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `forwardVector` | `Vector3*` | `ref Vector3` | - |
| `rightVector` | `Vector3*` | `ref Vector3` | - |
| `upVector` | `Vector3*` | `ref Vector3` | - |
| `position` | `Vector3*` | `ref Vector3` | - |

**返回值:** `void` (Native: `void`)

---

### GET_ENTITY_MAX_HEALTH

- **命名空间:** `ENTITY`
- **Hash:** `0x15D757606D170C3C`
- **JHash:** `0xC7AE6AA1`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_ENTITY_MAX_HEALTH(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Return an integer value of entity's maximum health.

Example:
- Player = 200
- Ped = 150
```

---

### GET_ENTITY_MODEL

- **命名空间:** `ENTITY`
- **Hash:** `0x9F47B058362C84B5`
- **JHash:** `0xDAFCB3EC`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_ENTITY_MODEL(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `uint` (Native: `Hash`)

**说明:**
```
Returns the model hash from the entity
```

---

### GET_ENTITY_OF_TYPE_ATTACHED_TO_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0x1F922734E259BD26`
- **Build:** `1180`

**C# 签名:**
```csharp
int GET_ENTITY_OF_TYPE_ATTACHED_TO_ENTITY(int entity, uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `Entity`)

**说明:**
```
Gets the handle of an entity with a specific model hash attached to another entity, such as an object attached to a ped.
 This native does not appear to have anything to do with pickups as in scripts it is used with objects.

Example from fm_mission_controller_2020.c:

iVar8 = ENTITY::GET_ENTITY_OF_TYPE_ATTACHED_TO_ENTITY(bParam0->f_9, joaat("p_cs_clipboard"));
```

---

### GET_ENTITY_PITCH

- **命名空间:** `ENTITY`
- **Hash:** `0xD45DC2893621E1FE`
- **JHash:** `0xFCE6ECE5`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_ENTITY_PITCH(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_ENTITY_POPULATION_TYPE

- **命名空间:** `ENTITY`
- **Hash:** `0xF6F5161F4534EDFF`
- **JHash:** `0xFC30DDFF`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_ENTITY_POPULATION_TYPE(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
A population type, from the following enum: https://alloc8or.re/gta5/doc/enums/ePopulationType.txt
```

---

### GET_ENTITY_PROOFS

- **命名空间:** `ENTITY`
- **Hash:** `0xBE8CD9BE829BBEBF`
- **Build:** `1604`

**C# 签名:**
```csharp
bool GET_ENTITY_PROOFS(int entity, ref bool bulletProof, ref bool fireProof, ref bool explosionProof, ref bool collisionProof, ref bool meleeProof, ref bool steamProof, ref bool p7, ref bool drownProof)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `bulletProof` | `BOOL*` | `ref bool` | - |
| `fireProof` | `BOOL*` | `ref bool` | - |
| `explosionProof` | `BOOL*` | `ref bool` | - |
| `collisionProof` | `BOOL*` | `ref bool` | - |
| `meleeProof` | `BOOL*` | `ref bool` | - |
| `steamProof` | `BOOL*` | `ref bool` | - |
| `p7` | `BOOL*` | `ref bool` | - |
| `drownProof` | `BOOL*` | `ref bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_ENTITY_QUATERNION

- **命名空间:** `ENTITY`
- **Hash:** `0x7B3703D2D32DFA18`
- **JHash:** `0x5154EC90`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_ENTITY_QUATERNION(int entity, ref float x, ref float y, ref float z, ref float w)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `x` | `float*` | `ref float` | - |
| `y` | `float*` | `ref float` | - |
| `z` | `float*` | `ref float` | - |
| `w` | `float*` | `ref float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
w is the correct parameter name!
```

---

### GET_ENTITY_ROLL

- **命名空间:** `ENTITY`
- **Hash:** `0x831E0242595560DF`
- **JHash:** `0x36610842`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_ENTITY_ROLL(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Displays the current ROLL axis of the entity [-180.0000/180.0000+]
(Sideways Roll) such as a vehicle tipped on its side
```

---

### GET_ENTITY_ROTATION

- **命名空间:** `ENTITY`
- **Hash:** `0xAFBD61CC738D9EB9`
- **JHash:** `0x8FF45B04`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_ENTITY_ROTATION(int entity, int rotationOrder)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `rotationOrder` | `int` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
rotationOrder is the order yaw, pitch and roll is applied. Usually 2. Returns a vector where the Z coordinate is the yaw.

rotationOrder refers to the order yaw pitch roll is applied; value ranges from 0 to 5 and is usually *2* in scripts.
What you use for rotationOrder when getting must be the same as rotationOrder when setting the rotation.

What it returns is the yaw on the z part of the vector, which makes sense considering R* considers z as vertical. Here's a picture for those of you who don't understand pitch, yaw, and roll: www.allstar.fiu.edu/aero/images/pic5-1.gif

Rotation Orders:
0: ZYX - Rotate around the z-axis, then the y-axis and finally the x-axis.
1: YZX - Rotate around the y-axis, then the z-axis and finally the x-axis.
2: ZXY - Rotate around the z-axis, then the x-axis and finally the y-axis.
3: XZY - Rotate around the x-axis, then the z-axis and finally the y-axis.
4: YXZ - Rotate around the y-axis, then the x-axis and finally the z-axis.
5: XYZ - Rotate around the x-axis, then the y-axis and finally the z-axis.
```

---

### GET_ENTITY_ROTATION_VELOCITY

- **命名空间:** `ENTITY`
- **Hash:** `0x213B91045D09B983`
- **JHash:** `0x9BF8A73F`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_ENTITY_ROTATION_VELOCITY(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

---

### GET_ENTITY_SCRIPT

- **命名空间:** `ENTITY`
- **Hash:** `0xA6E9C38DB51D7748`
- **JHash:** `0xB7F70784`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_ENTITY_SCRIPT(int entity, ScrHandle* script)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `script` | `ScrHandle*` | `ScrHandle*` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Returns the name of the script that owns/created the entity or nullptr. Second parameter is unused, can just be a nullptr.
```

---

### GET_ENTITY_SPEED

- **命名空间:** `ENTITY`
- **Hash:** `0xD5037BA82E12416F`
- **JHash:** `0x9E1E4798`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_ENTITY_SPEED(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
result is in meters per second

------------------------------------------------------------
So would the conversion to mph and km/h, be along the lines of this.

float speed = GET_ENTITY_SPEED(veh);
float kmh = (speed * 3.6);
float mph = (speed * 2.236936);
------------------------------------------------------------
```

---

### GET_ENTITY_SPEED_VECTOR

- **命名空间:** `ENTITY`
- **Hash:** `0x9A8D700A51CB7B0D`
- **JHash:** `0x3ED2B997`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_ENTITY_SPEED_VECTOR(int entity, bool relative)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `relative` | `BOOL` | `bool` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
Relative can be used for getting speed relative to the frame of the vehicle, to determine for example, if you are going in reverse (-y speed) or not (+y speed). 
```

---

### GET_ENTITY_SUBMERGED_LEVEL

- **命名空间:** `ENTITY`
- **Hash:** `0xE81AFC1BC4CC41CE`
- **JHash:** `0x0170F68C`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_ENTITY_SUBMERGED_LEVEL(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Get how much of the entity is submerged.  1.0f is whole entity.
```

---

### GET_ENTITY_TYPE

- **命名空间:** `ENTITY`
- **Hash:** `0x8ACD366038D14505`
- **JHash:** `0x0B1BD08D`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_ENTITY_TYPE(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns:
0 = no entity
1 = ped
2 = vehicle
3 = object
```

---

### GET_ENTITY_UPRIGHT_VALUE

- **命名空间:** `ENTITY`
- **Hash:** `0x95EED5A694951F9F`
- **JHash:** `0xF4268190`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_ENTITY_UPRIGHT_VALUE(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_ENTITY_VELOCITY

- **命名空间:** `ENTITY`
- **Hash:** `0x4805D2B1D8CF94A9`
- **JHash:** `0xC14C9B6B`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_ENTITY_VELOCITY(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

---

### GET_HAS_OBJECT_BEEN_COMPLETELY_DESTROYED

- **命名空间:** `OBJECT`
- **Hash:** `0x2542269291C6AC84`
- **Build:** `1180`

**C# 签名:**
```csharp
bool GET_HAS_OBJECT_BEEN_COMPLETELY_DESTROYED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_INDEXED_ITEM_IN_ITEMSET

- **命名空间:** `ITEMSET`
- **Hash:** `0x7A197E2521EE2BAB`
- **JHash:** `0x3F712874`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_INDEXED_ITEM_IN_ITEMSET(int index, int itemset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |
| `itemset` | `ScrHandle` | `int` | - |

**返回值:** `int` (Native: `ScrHandle`)

---

### GET_IS_ARTICULATED_JOINT_AT_MAX_ANGLE

- **命名空间:** `OBJECT`
- **Hash:** `0x3BD770D281982DB5`
- **Build:** `1604`

**C# 签名:**
```csharp
bool GET_IS_ARTICULATED_JOINT_AT_MAX_ANGLE(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_IS_ARTICULATED_JOINT_AT_MIN_ANGLE

- **命名空间:** `OBJECT`
- **Hash:** `0x43C677F1E1158005`
- **Build:** `1604`

**C# 签名:**
```csharp
bool GET_IS_ARTICULATED_JOINT_AT_MIN_ANGLE(int object, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_ITEMSET_SIZE

- **命名空间:** `ITEMSET`
- **Hash:** `0xD9127E83ABF7C631`
- **JHash:** `0x2B31F41A`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_ITEMSET_SIZE(int itemset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `itemset` | `ScrHandle` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_LAST_MATERIAL_HIT_BY_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0x5C3D0A935F535C4C`
- **JHash:** `0xC0E3AA47`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_LAST_MATERIAL_HIT_BY_ENTITY(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `uint` (Native: `Hash`)

---

### GET_NEAREST_PARTICIPANT_TO_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0xFFBD7052D65BE0FF`
- **Build:** `2944`

**C# 签名:**
```csharp
int GET_NEAREST_PARTICIPANT_TO_ENTITY(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_NEAREST_PLAYER_TO_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0x7196842CB375CDB3`
- **JHash:** `0xCE17FDEC`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NEAREST_PLAYER_TO_ENTITY(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `int` (Native: `Player`)

---

### GET_NEAREST_PLAYER_TO_ENTITY_ON_TEAM

- **命名空间:** `ENTITY`
- **Hash:** `0x4DC9A62F844D9337`
- **JHash:** `0xB1808F56`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NEAREST_PLAYER_TO_ENTITY_ON_TEAM(int entity, int team)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `team` | `int` | `int` | - |

**返回值:** `int` (Native: `Player`)

---

### GET_OBJECT_FRAGMENT_DAMAGE_HEALTH

- **命名空间:** `OBJECT`
- **Hash:** `0xB6FBFD079B8D0596`
- **JHash:** `0xF0B330AD`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_OBJECT_FRAGMENT_DAMAGE_HEALTH(object p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `float` (Native: `float`)

---

### GET_OBJECT_INDEX_FROM_ENTITY_INDEX

- **命名空间:** `ENTITY`
- **Hash:** `0xD7E3B9735C0F89D6`
- **JHash:** `0xBC5A9C58`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_OBJECT_INDEX_FROM_ENTITY_INDEX(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `int` (Native: `Object`)

**说明:**
```
Simply returns whatever is passed to it (Regardless of whether the handle is valid or not).
```

---

### GET_OBJECT_TINT_INDEX

- **命名空间:** `OBJECT`
- **Hash:** `0xE84EB93729C5F36A`
- **Build:** `757`

**C# 签名:**
```csharp
int GET_OBJECT_TINT_INDEX(int object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_OFFSET_FROM_COORD_AND_HEADING_IN_WORLD_COORDS

- **命名空间:** `OBJECT`
- **Hash:** `0x163E252DE035A133`
- **JHash:** `0x87A42A12`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_OFFSET_FROM_COORD_AND_HEADING_IN_WORLD_COORDS(float xPos, float yPos, float zPos, float heading, float xOffset, float yOffset, float zOffset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `xPos` | `float` | `float` | - |
| `yPos` | `float` | `float` | - |
| `zPos` | `float` | `float` | - |
| `heading` | `float` | `float` | - |
| `xOffset` | `float` | `float` | - |
| `yOffset` | `float` | `float` | - |
| `zOffset` | `float` | `float` | - |

**返回值:** `Vector3` (Native: `Vector3`)

---

### GET_OFFSET_FROM_ENTITY_GIVEN_WORLD_COORDS

- **命名空间:** `ENTITY`
- **Hash:** `0x2274BC1C4885E333`
- **JHash:** `0x6477EC9E`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_OFFSET_FROM_ENTITY_GIVEN_WORLD_COORDS(int entity, float posX, float posY, float posZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
Converts world coords (posX - Z) to coords relative to the entity

Example:
posX is given as 50
entity's x coord is 40
the returned x coord will then be 10 or -10, not sure haven't used this in a while (think it is 10 though).
```

---

### GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS

- **命名空间:** `ENTITY`
- **Hash:** `0x1899F328B0E12848`
- **JHash:** `0xABCF043A`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(int entity, float offsetX, float offsetY, float offsetZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `offsetX` | `float` | `float` | - |
| `offsetY` | `float` | `float` | - |
| `offsetZ` | `float` | `float` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
Offset values are relative to the entity.

x = left/right
y = forward/backward
z = up/down
```

---

### GET_PED_INDEX_FROM_ENTITY_INDEX

- **命名空间:** `ENTITY`
- **Hash:** `0x04A2A40C73395041`
- **JHash:** `0xC46F74AC`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_INDEX_FROM_ENTITY_INDEX(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `int` (Native: `Ped`)

**说明:**
```
Simply returns whatever is passed to it (Regardless of whether the handle is valid or not).
```

---

### GET_PICKUP_COORDS

- **命名空间:** `OBJECT`
- **Hash:** `0x225B8B35C88029B3`
- **JHash:** `0xC2E1E2C5`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_PICKUP_COORDS(int pickup)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

---

### GET_PICKUP_GENERATION_RANGE_MULTIPLIER

- **命名空间:** `OBJECT`
- **Hash:** `0xB3ECA65C7317F174`
- **Build:** `944`

**C# 签名:**
```csharp
float GET_PICKUP_GENERATION_RANGE_MULTIPLIER()
```

**返回值:** `float` (Native: `float`)

---

### GET_PICKUP_OBJECT

- **命名空间:** `OBJECT`
- **Hash:** `0x5099BC55630B25AE`
- **JHash:** `0x6052E62E`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PICKUP_OBJECT(int pickup)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |

**返回值:** `int` (Native: `Object`)

---

### GET_PICKUP_TYPE_FROM_WEAPON_HASH

- **命名空间:** `OBJECT`
- **Hash:** `0xD6429A016084F1A5`
- **Build:** `1290`

**C# 签名:**
```csharp
uint GET_PICKUP_TYPE_FROM_WEAPON_HASH(uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `uint` (Native: `Hash`)

**说明:**
```
Returns the pickup hash for the given weapon hash
```

---

### GET_RAYFIRE_MAP_OBJECT

- **命名空间:** `OBJECT`
- **Hash:** `0xB48FCED898292E52`
- **JHash:** `0xA286DE96`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_RAYFIRE_MAP_OBJECT(float x, float y, float z, float radius, string name)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `name` | `const char*` | `string` | - |

**返回值:** `int` (Native: `Object`)

**说明:**
```
Example:
OBJECT::GET_RAYFIRE_MAP_OBJECT(-809.9619750976562, 170.919, 75.7406997680664, 3.0, "des_tvsmash");
```

---

### GET_RAYFIRE_MAP_OBJECT_ANIM_PHASE

- **命名空间:** `OBJECT`
- **Hash:** `0x260EE4FDBDF4DB01`
- **JHash:** `0x020497DE`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_RAYFIRE_MAP_OBJECT_ANIM_PHASE(int object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
`object`: The des-object handle to get the animation progress from.
Return value is a float between 0.0 and 1.0, 0.0 is the beginning of the animation, 1.0 is the end. Value resets to 0.0 instantly after reaching 1.0.
```

---

### GET_SAFE_PICKUP_COORDS

- **命名空间:** `OBJECT`
- **Hash:** `0x6E16BC2503FF1FF0`
- **JHash:** `0x618B5F67`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_SAFE_PICKUP_COORDS(float x, float y, float z, float p3, float p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `float` | `float` | - |

**返回值:** `Vector3` (Native: `Vector3`)

---

### GET_STATE_OF_CLOSEST_DOOR_OF_TYPE

- **命名空间:** `OBJECT`
- **Hash:** `0xEDC1A5B84AEF33FF`
- **JHash:** `0x4B44A83D`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_STATE_OF_CLOSEST_DOOR_OF_TYPE(uint type, float x, float y, float z, ref bool locked, ref float heading)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `type` | `Hash` | `uint` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `locked` | `BOOL*` | `ref bool` | - |
| `heading` | `float*` | `ref float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
locked is 0 if no door is found
locked is 0 if door is unlocked
locked is 1 if door is found and unlocked.

-------------
the locked bool is either 0(unlocked)(false) or 1(locked)(true)
```

---

### GET_STATE_OF_RAYFIRE_MAP_OBJECT

- **命名空间:** `OBJECT`
- **Hash:** `0x899BA936634A322E`
- **JHash:** `0xF1B8817A`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_STATE_OF_RAYFIRE_MAP_OBJECT(int object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Get a destructible object's state.
Substract 1 to get the real state.
See SET_STATE_OF_RAYFIRE_MAP_OBJECT to see the different states
For example, if the object just spawned (state 2), the native will return 3.
```

---

### GET_VEHICLE_INDEX_FROM_ENTITY_INDEX

- **命名空间:** `ENTITY`
- **Hash:** `0x4B53F92932ADFAC0`
- **JHash:** `0xC69CF43D`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_INDEX_FROM_ENTITY_INDEX(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `int` (Native: `Vehicle`)

**说明:**
```
Simply returns whatever is passed to it (Regardless of whether the handle is valid or not).
```

---

### GET_WEAPON_TYPE_FROM_PICKUP_TYPE

- **命名空间:** `OBJECT`
- **Hash:** `0x08F96CA6C551AD51`
- **JHash:** `0xEDD01937`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_WEAPON_TYPE_FROM_PICKUP_TYPE(uint pickupHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickupHash` | `Hash` | `uint` | - |

**返回值:** `uint` (Native: `Hash`)

**说明:**
```
Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
```

---

### GET_WORLD_POSITION_OF_ENTITY_BONE

- **命名空间:** `ENTITY`
- **Hash:** `0x44A8FCB8ED227738`
- **JHash:** `0x7C6339DF`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_WORLD_POSITION_OF_ENTITY_BONE(int entity, int boneIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `boneIndex` | `int` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
Returns the coordinates of an entity-bone.
```

---

### HAS_ANIM_EVENT_FIRED

- **命名空间:** `ENTITY`
- **Hash:** `0xEAF4CD9EA3E7E922`
- **JHash:** `0x66571CA0`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_ANIM_EVENT_FIRED(int entity, uint actionHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `actionHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
if (ENTITY::HAS_ANIM_EVENT_FIRED(PLAYER::PLAYER_PED_ID(), MISC::GET_HASH_KEY("CreateObject")))
```

---

### HAS_CLOSEST_OBJECT_OF_TYPE_BEEN_BROKEN

- **命名空间:** `OBJECT`
- **Hash:** `0x761B0E69AC4D007E`
- **JHash:** `0x6FC0353D`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_CLOSEST_OBJECT_OF_TYPE_BEEN_BROKEN(float p0, float p1, float p2, float p3, uint modelHash, object p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `modelHash` | `Hash` | `uint` | - |
| `p5` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_CLOSEST_OBJECT_OF_TYPE_BEEN_COMPLETELY_DESTROYED

- **命名空间:** `OBJECT`
- **Hash:** `0x46494A2475701343`
- **JHash:** `0x7DB578DD`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_CLOSEST_OBJECT_OF_TYPE_BEEN_COMPLETELY_DESTROYED(float x, float y, float z, float radius, uint modelHash, bool p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `modelHash` | `Hash` | `uint` | - |
| `p5` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_COLLISION_LOADED_AROUND_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0xE9676F61BC0B3321`
- **JHash:** `0x851687F9`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_COLLISION_LOADED_AROUND_ENTITY(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_ENTITY_ANIM_FINISHED

- **命名空间:** `ENTITY`
- **Hash:** `0x20B711662962B472`
- **JHash:** `0x1D9CAB92`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_ENTITY_ANIM_FINISHED(int entity, string animDict, string animName, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `animDict` | `const char*` | `string` | - |
| `animName` | `const char*` | `string` | - |
| `p3` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
P3 is always 3 as far as i cant tell

Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### HAS_ENTITY_BEEN_DAMAGED_BY_ANY_OBJECT

- **命名空间:** `ENTITY`
- **Hash:** `0x95EB9964FF5C5C65`
- **JHash:** `0x6B74582E`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_ENTITY_BEEN_DAMAGED_BY_ANY_OBJECT(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_ENTITY_BEEN_DAMAGED_BY_ANY_PED

- **命名空间:** `ENTITY`
- **Hash:** `0x605F5A140F202491`
- **JHash:** `0x53FD4A25`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_ENTITY_BEEN_DAMAGED_BY_ANY_PED(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_ENTITY_BEEN_DAMAGED_BY_ANY_VEHICLE

- **命名空间:** `ENTITY`
- **Hash:** `0xDFD5033FDBA0A9C8`
- **JHash:** `0x878C2CE0`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_ENTITY_BEEN_DAMAGED_BY_ANY_VEHICLE(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_ENTITY_BEEN_DAMAGED_BY_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0xC86D67D52A707CF8`
- **JHash:** `0x07FC77E0`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_ENTITY_BEEN_DAMAGED_BY_ENTITY(int entity1, int entity2, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity1` | `Entity` | `int` | - |
| `entity2` | `Entity` | `int` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Entity 1 = Victim
Entity 2 = Attacker

p2 seems to always be 1
```

---

### HAS_ENTITY_CLEAR_LOS_TO_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0xFCDFF7B72D23A1AC`
- **JHash:** `0x53576FA7`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_ENTITY_CLEAR_LOS_TO_ENTITY(int entity1, int entity2, int traceType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity1` | `Entity` | `int` | - |
| `entity2` | `Entity` | `int` | - |
| `traceType` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
traceType is always 17 in the scripts.

There is other codes used for traceType:
19 - in jewelry_prep1a
126 - in am_hunt_the_beast
256 & 287 - in fm_mission_controller
```

---

### HAS_ENTITY_CLEAR_LOS_TO_ENTITY_ADJUST_FOR_COVER

- **命名空间:** `ENTITY`
- **Hash:** `0x394BDE2A7BBA031E`
- **Build:** `1868`

**C# 签名:**
```csharp
bool HAS_ENTITY_CLEAR_LOS_TO_ENTITY_ADJUST_FOR_COVER(int entity1, int entity2, int traceType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity1` | `Entity` | `int` | - |
| `entity2` | `Entity` | `int` | - |
| `traceType` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_ENTITY_CLEAR_LOS_TO_ENTITY_IN_FRONT

- **命名空间:** `ENTITY`
- **Hash:** `0x0267D00AF114F17A`
- **JHash:** `0x210D87C8`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_ENTITY_CLEAR_LOS_TO_ENTITY_IN_FRONT(int entity1, int entity2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity1` | `Entity` | `int` | - |
| `entity2` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Has the entity1 got a clear line of sight to the other entity2 from the direction entity1 is facing.
This is one of the most CPU demanding BOOL natives in the game; avoid calling this in things like nested for-loops
```

---

### HAS_ENTITY_COLLIDED_WITH_ANYTHING

- **命名空间:** `ENTITY`
- **Hash:** `0x8BAD02F0368D9E14`
- **JHash:** `0x662A2F41`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_ENTITY_COLLIDED_WITH_ANYTHING(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Called on tick.
Tested with vehicles, returns true whenever the vehicle is touching any entity.

Note: for vehicles, the wheels can touch the ground and it will still return false, but if the body of the vehicle touches the ground, it will return true.
```

---

### HAS_OBJECT_BEEN_BROKEN

- **命名空间:** `OBJECT`
- **Hash:** `0x8ABFB70C49CC43E2`
- **JHash:** `0xFE21F891`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_OBJECT_BEEN_BROKEN(int object, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_PICKUP_BEEN_COLLECTED

- **命名空间:** `OBJECT`
- **Hash:** `0x80EC48E6679313F9`
- **JHash:** `0x0BE5CCED`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_PICKUP_BEEN_COLLECTED(int pickup)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HIDE_PORTABLE_PICKUP_WHEN_DETACHED

- **命名空间:** `OBJECT`
- **Hash:** `0x867458251D47CCB2`
- **JHash:** `0x1F63B042`
- **Build:** `463`

**C# 签名:**
```csharp
void HIDE_PORTABLE_PICKUP_WHEN_DETACHED(int pickupObject, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickupObject` | `Object` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### IS_ANY_ENTITY_ENTIRELY_INSIDE_GARAGE

- **命名空间:** `OBJECT`
- **Hash:** `0x673ED815D6E323B7`
- **JHash:** `0x7B44D659`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ANY_ENTITY_ENTIRELY_INSIDE_GARAGE(uint garageHash, bool p1, bool p2, bool p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `garageHash` | `Hash` | `uint` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ANY_OBJECT_NEAR_POINT

- **命名空间:** `OBJECT`
- **Hash:** `0x397DC58FF00298D1`
- **JHash:** `0xE9E46941`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ANY_OBJECT_NEAR_POINT(float x, float y, float z, float range, bool p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `range` | `float` | `float` | - |
| `p4` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_AN_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0x731EC8A916BD11A1`
- **JHash:** `0xD4B9715A`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_AN_ENTITY(int handle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `handle` | `ScrHandle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_DOOR_CLOSED

- **命名空间:** `OBJECT`
- **Hash:** `0xC531EE8A1145A149`
- **JHash:** `0x48659CD7`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_DOOR_CLOSED(uint doorHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `doorHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_DOOR_REGISTERED_WITH_SYSTEM

- **命名空间:** `OBJECT`
- **Hash:** `0xC153C43EA202C8C1`
- **JHash:** `0x5AFCD8A1`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_DOOR_REGISTERED_WITH_SYSTEM(uint doorHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `doorHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
if (OBJECT::IS_DOOR_REGISTERED_WITH_SYSTEM(doorHash)) 
{
    OBJECT::REMOVE_DOOR_FROM_SYSTEM(doorHash);
}
```

---

### IS_ENTITY_AN_OBJECT

- **命名空间:** `ENTITY`
- **Hash:** `0x8D68C8FD0FACA94E`
- **JHash:** `0x3F52E561`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_AN_OBJECT(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_ATTACHED

- **命名空间:** `ENTITY`
- **Hash:** `0xB346476EF1A64897`
- **JHash:** `0xEC1479D5`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_ATTACHED(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Whether the entity is attached to any other entity.
```

---

### IS_ENTITY_ATTACHED_TO_ANY_OBJECT

- **命名空间:** `ENTITY`
- **Hash:** `0xCF511840CEEDE0CC`
- **JHash:** `0x0B5DE340`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_ATTACHED_TO_ANY_OBJECT(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_ATTACHED_TO_ANY_PED

- **命名空间:** `ENTITY`
- **Hash:** `0xB1632E9A5F988D11`
- **JHash:** `0x9D7A609C`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_ATTACHED_TO_ANY_PED(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_ATTACHED_TO_ANY_VEHICLE

- **命名空间:** `ENTITY`
- **Hash:** `0x26AA915AD89BFB4B`
- **JHash:** `0xDE5C995E`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_ATTACHED_TO_ANY_VEHICLE(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_ATTACHED_TO_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0xEFBE71898A993728`
- **JHash:** `0xB0ABFEA8`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_ATTACHED_TO_ENTITY(int from, int to)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `from` | `Entity` | `int` | - |
| `to` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_AT_COORD

- **命名空间:** `ENTITY`
- **Hash:** `0x20B60995556D004F`
- **JHash:** `0xD749B606`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_AT_COORD(int entity, float xPos, float yPos, float zPos, float xSize, float ySize, float zSize, bool p7, bool p8, int p9)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `xPos` | `float` | `float` | - |
| `yPos` | `float` | `float` | - |
| `zPos` | `float` | `float` | - |
| `xSize` | `float` | `float` | - |
| `ySize` | `float` | `float` | - |
| `zSize` | `float` | `float` | - |
| `p7` | `BOOL` | `bool` | - |
| `p8` | `BOOL` | `bool` | - |
| `p9` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Checks if entity is within x/y/zSize distance of x/y/z. 

Last three are unknown ints, almost always p7 = 0, p8 = 1, p9 = 0
```

---

### IS_ENTITY_AT_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0x751B70C3D034E187`
- **JHash:** `0xDABDCB52`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_AT_ENTITY(int entity1, int entity2, float xSize, float ySize, float zSize, bool p5, bool p6, int p7)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity1` | `Entity` | `int` | - |
| `entity2` | `Entity` | `int` | - |
| `xSize` | `float` | `float` | - |
| `ySize` | `float` | `float` | - |
| `zSize` | `float` | `float` | - |
| `p5` | `BOOL` | `bool` | - |
| `p6` | `BOOL` | `bool` | - |
| `p7` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Checks if entity1 is within the box defined by x/y/zSize of entity2.

Last three parameters are almost alwasy p5 = 0, p6 = 1, p7 = 0
```

---

### IS_ENTITY_A_MISSION_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0x0A7B270912999B3C`
- **JHash:** `0x2632E124`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_A_MISSION_ENTITY(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_A_PED

- **命名空间:** `ENTITY`
- **Hash:** `0x524AC5ECEA15343E`
- **JHash:** `0x55D33EAB`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_A_PED(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_A_VEHICLE

- **命名空间:** `ENTITY`
- **Hash:** `0x6AC7003FA6E5575E`
- **JHash:** `0xBE800B01`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_A_VEHICLE(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_DEAD

- **命名空间:** `ENTITY`
- **Hash:** `0x5F9532F3B5CC2551`
- **JHash:** `0xB6F7CBAC`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_DEAD(int entity, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_IN_AIR

- **命名空间:** `ENTITY`
- **Hash:** `0x886E37EC497200B6`
- **JHash:** `0xA4157987`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_IN_AIR(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_IN_ANGLED_AREA

- **命名空间:** `ENTITY`
- **Hash:** `0x51210CED3DA1C78A`
- **JHash:** `0x883622FA`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_IN_ANGLED_AREA(int entity, float x1, float y1, float z1, float x2, float y2, float z2, float width, bool debug, bool includeZ, object p10)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |
| `z2` | `float` | `float` | - |
| `width` | `float` | `float` | - |
| `debug` | `BOOL` | `bool` | - |
| `includeZ` | `BOOL` | `bool` | - |
| `p10` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
`p8` is a debug flag invoking functions in the same path as ``DRAW_MARKER``
`p10` is some entity flag check, also used in `IS_ENTITY_AT_ENTITY`, `IS_ENTITY_IN_AREA`, and `IS_ENTITY_AT_COORD`.
See IS_POINT_IN_ANGLED_AREA for the definition of an angled area.
```

---

### IS_ENTITY_IN_AREA

- **命名空间:** `ENTITY`
- **Hash:** `0x54736AA40E271165`
- **JHash:** `0x8C2DFA9D`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_IN_AREA(int entity, float x1, float y1, float z1, float x2, float y2, float z2, bool p7, bool p8, object p9)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |
| `z2` | `float` | `float` | - |
| `p7` | `BOOL` | `bool` | - |
| `p8` | `BOOL` | `bool` | - |
| `p9` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_IN_WATER

- **命名空间:** `ENTITY`
- **Hash:** `0xCFB0A0D8EDD145A3`
- **JHash:** `0x4C3C2508`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_IN_WATER(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_IN_ZONE

- **命名空间:** `ENTITY`
- **Hash:** `0xB6463CF6AF527071`
- **JHash:** `0x45C82B21`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_IN_ZONE(int entity, string zone)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `zone` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of zones by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/zones.json
```

---

### IS_ENTITY_OCCLUDED

- **命名空间:** `ENTITY`
- **Hash:** `0xE31C2C72B8692B64`
- **JHash:** `0x46BC5B40`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_OCCLUDED(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_ON_SCREEN

- **命名空间:** `ENTITY`
- **Hash:** `0xE659E47AF827484B`
- **JHash:** `0xC1FEC5ED`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_ON_SCREEN(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if the entity is in between the minimum and maximum values for the 2d screen coords. 
This means that it will return true even if the entity is behind a wall for example, as long as you're looking at their location. 
Chipping
```

---

### IS_ENTITY_PLAYING_ANIM

- **命名空间:** `ENTITY`
- **Hash:** `0x1F0B79228E461EC9`
- **JHash:** `0x0D130D34`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_PLAYING_ANIM(int entity, string animDict, string animName, int taskFlag)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `animDict` | `const char*` | `string` | - |
| `animName` | `const char*` | `string` | - |
| `taskFlag` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
See also PED::IS_SCRIPTED_SCENARIO_PED_USING_CONDITIONAL_ANIM 0x6EC47A344923E1ED 0x3C30B447

Taken from ENTITY::IS_ENTITY_PLAYING_ANIM(PLAYER::PLAYER_PED_ID(), "creatures@shark@move", "attack_player", 3)

p4 is always 3 in the scripts.

Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### IS_ENTITY_STATIC

- **命名空间:** `ENTITY`
- **Hash:** `0x1218E6886D3D8327`
- **JHash:** `0x928E12E9`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_STATIC(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
a static ped will not react to natives like "APPLY_FORCE_TO_ENTITY" or "SET_ENTITY_VELOCITY" and oftentimes will not react to task-natives like "TASK::TASK_COMBAT_PED". The only way I know of to make one of these peds react is to ragdoll them (or sometimes to use CLEAR_PED_TASKS_IMMEDIATELY(). Static peds include almost all far-away peds, beach-combers, peds in certain scenarios, peds crossing a crosswalk, peds walking to get back into their cars, and others. If anyone knows how to make a ped non-static without ragdolling them, please edit this with the solution.
```

---

### IS_ENTITY_TOUCHING_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0x17FFC1B2BA35A494`
- **JHash:** `0x6B931477`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_TOUCHING_ENTITY(int entity, int targetEntity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `targetEntity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_TOUCHING_MODEL

- **命名空间:** `ENTITY`
- **Hash:** `0x0F42323798A58C8C`
- **JHash:** `0x307E7611`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_TOUCHING_MODEL(int entity, uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_UPRIGHT

- **命名空间:** `ENTITY`
- **Hash:** `0x5333F526F6AB19AA`
- **JHash:** `0x3BCDF4E1`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_UPRIGHT(int entity, float angle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `angle` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_UPSIDEDOWN

- **命名空间:** `ENTITY`
- **Hash:** `0x1DBD58820FA61D71`
- **JHash:** `0x5ACAA48F`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_UPSIDEDOWN(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_VISIBLE

- **命名空间:** `ENTITY`
- **Hash:** `0x47D6F43D77935C75`
- **JHash:** `0x120B4ED5`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_VISIBLE(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_VISIBLE_TO_SCRIPT

- **命名空间:** `ENTITY`
- **Hash:** `0xD796CB5BA8F20E32`
- **JHash:** `0x5D240E9D`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_VISIBLE_TO_SCRIPT(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_WAITING_FOR_WORLD_COLLISION

- **命名空间:** `ENTITY`
- **Hash:** `0xD05BFF0C0A12C68F`
- **JHash:** `0x00AB7A4A`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_WAITING_FOR_WORLD_COLLISION(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_GARAGE_EMPTY

- **命名空间:** `OBJECT`
- **Hash:** `0x90E47239EA1980B8`
- **JHash:** `0xA8B37DEA`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_GARAGE_EMPTY(uint garageHash, bool p1, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `garageHash` | `Hash` | `uint` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_IN_ITEMSET

- **命名空间:** `ITEMSET`
- **Hash:** `0x2D0FC594D1E9C107`
- **JHash:** `0x0D4B9730`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_IN_ITEMSET(int item, int itemset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `item` | `ScrHandle` | `int` | - |
| `itemset` | `ScrHandle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ITEMSET_VALID

- **命名空间:** `ITEMSET`
- **Hash:** `0xB1B1EA596344DFAB`
- **JHash:** `0xD201FC29`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ITEMSET_VALID(int itemset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `itemset` | `ScrHandle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_OBJECT_A_PICKUP

- **命名空间:** `OBJECT`
- **Hash:** `0xFC481C641EBBD27D`
- **JHash:** `0x93D23399`
- **Build:** `1365`

**C# 签名:**
```csharp
bool IS_OBJECT_A_PICKUP(int object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_OBJECT_A_PORTABLE_PICKUP

- **命名空间:** `OBJECT`
- **Hash:** `0x0378C08504160D0D`
- **JHash:** `0x0F0E94FF`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_OBJECT_A_PORTABLE_PICKUP(int object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_OBJECT_ENTIRELY_INSIDE_GARAGE

- **命名空间:** `OBJECT`
- **Hash:** `0x372EF6699146A1E4`
- **JHash:** `0x142C8F76`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_OBJECT_ENTIRELY_INSIDE_GARAGE(uint garageHash, int entity, float p2, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `garageHash` | `Hash` | `uint` | - |
| `entity` | `Entity` | `int` | - |
| `p2` | `float` | `float` | - |
| `p3` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Despite the name, it does work for any entity type.
```

---

### IS_OBJECT_NEAR_POINT

- **命名空间:** `OBJECT`
- **Hash:** `0x8C90FE4B381BA60A`
- **JHash:** `0x50A62C43`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_OBJECT_NEAR_POINT(uint objectHash, float x, float y, float z, float range)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `objectHash` | `Hash` | `uint` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `range` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_OBJECT_PARTIALLY_INSIDE_GARAGE

- **命名空间:** `OBJECT`
- **Hash:** `0xF0EED5A6BC7B237A`
- **JHash:** `0x95A9AB2B`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_OBJECT_PARTIALLY_INSIDE_GARAGE(uint garageHash, int entity, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `garageHash` | `Hash` | `uint` | - |
| `entity` | `Entity` | `int` | - |
| `p2` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Despite the name, it does work for any entity type.
```

---

### IS_OBJECT_VISIBLE

- **命名空间:** `OBJECT`
- **Hash:** `0x8B32ACE6326A7546`
- **JHash:** `0xF4FD8AE4`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_OBJECT_VISIBLE(int object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PICKUP_WEAPON_OBJECT_VALID

- **命名空间:** `OBJECT`
- **Hash:** `0x11D1E53A726891FE`
- **JHash:** `0x883DAB2D`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PICKUP_WEAPON_OBJECT_VALID(int object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PLAYER_ENTIRELY_INSIDE_GARAGE

- **命名空间:** `OBJECT`
- **Hash:** `0x024A60DEB0EA69F0`
- **JHash:** `0xC33ED360`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_ENTIRELY_INSIDE_GARAGE(uint garageHash, int player, float p2, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `garageHash` | `Hash` | `uint` | - |
| `player` | `Player` | `int` | - |
| `p2` | `float` | `float` | - |
| `p3` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PLAYER_PARTIALLY_INSIDE_GARAGE

- **命名空间:** `OBJECT`
- **Hash:** `0x1761DC5D8471CBAA`
- **JHash:** `0x41924877`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_PARTIALLY_INSIDE_GARAGE(uint garageHash, int player, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `garageHash` | `Hash` | `uint` | - |
| `player` | `Player` | `int` | - |
| `p2` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_POINT_IN_ANGLED_AREA

- **命名空间:** `OBJECT`
- **Hash:** `0x2A70BAE8883E4C81`
- **JHash:** `0x73BCFFDC`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_POINT_IN_ANGLED_AREA(float xPos, float yPos, float zPos, float x1, float y1, float z1, float x2, float y2, float z2, float width, bool debug, bool includeZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `xPos` | `float` | `float` | - |
| `yPos` | `float` | `float` | - |
| `zPos` | `float` | `float` | - |
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |
| `z2` | `float` | `float` | - |
| `width` | `float` | `float` | - |
| `debug` | `BOOL` | `bool` | - |
| `includeZ` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
An angled area is an X-Z oriented rectangle with three parameters:
1. origin: the mid-point along a base edge of the rectangle;
2. extent: the mid-point of opposite base edge on the other Z;
3. width: the length of the base edge; (named derived from logging strings ``CNetworkRoadNodeWorldStateData``).

The oriented rectangle can then be derived from the direction of the two points (``norm(origin - extent)``), its orthonormal, and the width, e.g:
1. golf_mp https://i.imgur.com/JhsQAK9.png
2. am_taxi https://i.imgur.com/TJWCZaT.jpg
```

---

### IS_PROP_LIGHT_OVERRIDEN

- **命名空间:** `OBJECT`
- **Hash:** `0xADF084FB8F075D06`
- **Build:** `1604`

**C# 签名:**
```csharp
bool IS_PROP_LIGHT_OVERRIDEN(int object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### ONLY_CLEAN_UP_OBJECT_WHEN_OUT_OF_RANGE

- **命名空间:** `OBJECT`
- **Hash:** `0xADBE4809F19F927A`
- **JHash:** `0x2048A7DD`
- **Build:** `323`

**C# 签名:**
```csharp
void ONLY_CLEAN_UP_OBJECT_WHEN_OUT_OF_RANGE(int object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### OPEN_ALL_BARRIERS_FOR_RACE

- **命名空间:** `OBJECT`
- **Hash:** `0xC7F29CA00F46350E`
- **JHash:** `0x9BF33E41`
- **Build:** `323`

**C# 签名:**
```csharp
void OPEN_ALL_BARRIERS_FOR_RACE(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### PLACE_OBJECT_ON_GROUND_OR_OBJECT_PROPERLY

- **命名空间:** `OBJECT`
- **Hash:** `0xD76EEEF746057FD6`
- **Build:** `505`

**C# 签名:**
```csharp
bool PLACE_OBJECT_ON_GROUND_OR_OBJECT_PROPERLY(int object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### PLACE_OBJECT_ON_GROUND_PROPERLY

- **命名空间:** `OBJECT`
- **Hash:** `0x58A850EAEE20FAA3`
- **JHash:** `0x8F95A20B`
- **Build:** `323`

**C# 签名:**
```csharp
bool PLACE_OBJECT_ON_GROUND_PROPERLY(int object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### PLAY_ENTITY_ANIM

- **命名空间:** `ENTITY`
- **Hash:** `0x7FB218262B810701`
- **JHash:** `0x878753D5`
- **Build:** `323`

**C# 签名:**
```csharp
bool PLAY_ENTITY_ANIM(int entity, string animName, string animDict, float p3, bool loop, bool stayInAnim, bool p6, float delta, object bitset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `animName` | `const char*` | `string` | - |
| `animDict` | `const char*` | `string` | - |
| `p3` | `float` | `float` | - |
| `loop` | `BOOL` | `bool` | - |
| `stayInAnim` | `BOOL` | `bool` | - |
| `p6` | `BOOL` | `bool` | - |
| `delta` | `float` | `float` | - |
| `bitset` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
delta and bitset are guessed fields. They are based on the fact that most of the calls have 0 or nil field types passed in.

The only time bitset has a value is 0x4000 and the only time delta has a value is during stealth with usually <1.0f values.

Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### PLAY_OBJECT_AUTO_START_ANIM

- **命名空间:** `OBJECT`
- **Hash:** `0x006E4B040ED37EC3`
- **Build:** `1868`

**C# 签名:**
```csharp
void PLAY_OBJECT_AUTO_START_ANIM(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAY_SYNCHRONIZED_ENTITY_ANIM

- **命名空间:** `ENTITY`
- **Hash:** `0xC77720A12FE14A86`
- **JHash:** `0x012760AA`
- **Build:** `323`

**C# 签名:**
```csharp
bool PLAY_SYNCHRONIZED_ENTITY_ANIM(int entity, int syncedScene, string animation, string propName, float p4, float p5, object p6, float p7)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `syncedScene` | `int` | `int` | - |
| `animation` | `const char*` | `string` | - |
| `propName` | `const char*` | `string` | - |
| `p4` | `float` | `float` | - |
| `p5` | `float` | `float` | - |
| `p6` | `Any` | `object` | - |
| `p7` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p4 and p7 are usually 1000.0f.

Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### PLAY_SYNCHRONIZED_MAP_ENTITY_ANIM

- **命名空间:** `ENTITY`
- **Hash:** `0xB9C54555ED30FBC4`
- **JHash:** `0xEB4CBA74`
- **Build:** `323`

**C# 签名:**
```csharp
bool PLAY_SYNCHRONIZED_MAP_ENTITY_ANIM(float x1, float y1, float z1, float x2, object y2, float z2, string p6, string p7, float p8, float p9, object p10, float p11)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `Any` | `object` | - |
| `z2` | `float` | `float` | - |
| `p6` | `const char*` | `string` | - |
| `p7` | `const char*` | `string` | - |
| `p8` | `float` | `float` | - |
| `p9` | `float` | `float` | - |
| `p10` | `Any` | `object` | - |
| `p11` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p6,p7 probably animname and animdict

Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### PREVENT_COLLECTION_OF_PORTABLE_PICKUP

- **命名空间:** `OBJECT`
- **Hash:** `0x92AEFB5F6E294023`
- **JHash:** `0xCBB5F9B6`
- **Build:** `323`

**C# 签名:**
```csharp
void PREVENT_COLLECTION_OF_PORTABLE_PICKUP(int object, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### PROCESS_ENTITY_ATTACHMENTS

- **命名空间:** `ENTITY`
- **Hash:** `0xF4080490ADC51C6F`
- **JHash:** `0x6909BA59`
- **Build:** `323`

**C# 签名:**
```csharp
void PROCESS_ENTITY_ATTACHMENTS(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Called to update entity attachments.
```

---

### REMOVE_ALL_PICKUPS_OF_TYPE

- **命名空间:** `OBJECT`
- **Hash:** `0x27F9D613092159CF`
- **JHash:** `0x40062C53`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_ALL_PICKUPS_OF_TYPE(uint pickupHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickupHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
```

---

### REMOVE_DOOR_FROM_SYSTEM

- **命名空间:** `OBJECT`
- **Hash:** `0x464D8E1427156FE4`
- **JHash:** `0x00253286`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_DOOR_FROM_SYSTEM(uint doorHash, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `doorHash` | `Hash` | `uint` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
CDoor and CDoorSystemData still internally allocated (and their associations between doorHash, modelHash, and coordinates).
Only its NetObj removed and flag ``*(v2 + 192) |= 8u`` (1604 retail) toggled.
```

---

### REMOVE_FORCED_OBJECT

- **命名空间:** `ENTITY`
- **Hash:** `0x61B6775E83C0DB6F`
- **JHash:** `0xAED73ADD`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_FORCED_OBJECT(float x, float y, float z, float p3, uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_FROM_ITEMSET

- **命名空间:** `ITEMSET`
- **Hash:** `0x25E68244B0177686`
- **JHash:** `0xA9565228`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_FROM_ITEMSET(int item, int itemset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `item` | `ScrHandle` | `int` | - |
| `itemset` | `ScrHandle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_MODEL_HIDE

- **命名空间:** `ENTITY`
- **Hash:** `0xD9E3006FB3CBD765`
- **JHash:** `0x993DBC10`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_MODEL_HIDE(float x, float y, float z, float radius, uint modelHash, bool p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `modelHash` | `Hash` | `uint` | - |
| `p5` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native makes entities visible that are hidden by the native CREATE_MODEL_HIDE.
p5 should be false, true does nothing
```

---

### REMOVE_MODEL_SWAP

- **命名空间:** `ENTITY`
- **Hash:** `0x033C0F9A64E229AE`
- **JHash:** `0xCE0AA8BC`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_MODEL_SWAP(float x, float y, float z, float radius, uint originalModel, uint newModel, bool p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `originalModel` | `Hash` | `uint` | - |
| `newModel` | `Hash` | `uint` | - |
| `p6` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_OBJECT_HIGH_DETAIL_MODEL

- **命名空间:** `OBJECT`
- **Hash:** `0x4A39DB43E47CF3AA`
- **JHash:** `0xE3261B35`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_OBJECT_HIGH_DETAIL_MODEL(int object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_PICKUP

- **命名空间:** `OBJECT`
- **Hash:** `0x3288D8ACAECD2AB2`
- **JHash:** `0x64A7A0E0`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_PICKUP(int pickup)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RENDER_FAKE_PICKUP_GLOW

- **命名空间:** `OBJECT`
- **Hash:** `0x3430676B11CDF21D`
- **JHash:** `0x63B02FAD`
- **Build:** `323`

**C# 签名:**
```csharp
void RENDER_FAKE_PICKUP_GLOW(float x, float y, float z, int colorIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `colorIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
draws circular marker at pos
-1 = none
0 = red
1 = green
2 = blue
3 = green larger
4 = nothing
5 = green small
```

---

### RESET_ENTITY_ALPHA

- **命名空间:** `ENTITY`
- **Hash:** `0x9B1E824FFBB7027A`
- **JHash:** `0x8A30761C`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_ENTITY_ALPHA(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESET_PICKUP_ENTITY_GLOW

- **命名空间:** `ENTITY`
- **Hash:** `0x490861B88F4FD846`
- **Build:** `944`

**C# 签名:**
```csharp
void RESET_PICKUP_ENTITY_GLOW(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Similar to RESET_ENTITY_ALPHA
```

---

### ROTATE_OBJECT

- **命名空间:** `OBJECT`
- **Hash:** `0xAFE24E4D29249E4A`
- **Build:** `1734`

**C# 签名:**
```csharp
bool ROTATE_OBJECT(int object, float p1, float p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### SET_ACTIVATE_OBJECT_PHYSICS_AS_SOON_AS_IT_IS_UNFROZEN

- **命名空间:** `OBJECT`
- **Hash:** `0x406137F8EF90EAF5`
- **JHash:** `0x3E263AE1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ACTIVATE_OBJECT_PHYSICS_AS_SOON_AS_IT_IS_UNFROZEN(int object, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ALLOW_MIGRATE_TO_SPECTATOR

- **命名空间:** `ENTITY`
- **Hash:** `0x36F32DE87082343E`
- **Build:** `1011`

**C# 签名:**
```csharp
void SET_ALLOW_MIGRATE_TO_SPECTATOR(int entity, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 is always set to 1
```

---

### SET_CAN_AUTO_VAULT_ON_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0xE12ABE5E3A389A6C`
- **JHash:** `0x44767B31`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAN_AUTO_VAULT_ON_ENTITY(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 always false.
```

---

### SET_CAN_CLIMB_ON_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0xA80AE305E0A3044F`
- **JHash:** `0xE224A6A5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAN_CLIMB_ON_ENTITY(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 always false.
```

---

### SET_CUSTOM_PICKUP_WEAPON_HASH

- **命名空间:** `OBJECT`
- **Hash:** `0x826D1EE4D1CAFC78`
- **Build:** `505`

**C# 签名:**
```csharp
void SET_CUSTOM_PICKUP_WEAPON_HASH(uint pickupHash, int pickup)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickupHash` | `Hash` | `uint` | - |
| `pickup` | `Pickup` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CUTSCENES_WEAPON_FLASHLIGHT_ON_THIS_FRAME

- **命名空间:** `OBJECT`
- **Hash:** `0xBCE595371A5FBAAF`
- **JHash:** `0x3A68AA46`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CUTSCENES_WEAPON_FLASHLIGHT_ON_THIS_FRAME(int object, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Requires a component_at_*_flsh to be attached to the weapon object
```

---

### SET_DISABLE_COLLISIONS_BETWEEN_CARS_AND_CAR_PARACHUTE

- **命名空间:** `OBJECT`
- **Hash:** `0x8CAAB2BD3EA58BD4`
- **Build:** `1011`

**C# 签名:**
```csharp
void SET_DISABLE_COLLISIONS_BETWEEN_CARS_AND_CAR_PARACHUTE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DRIVE_ARTICULATED_JOINT

- **命名空间:** `OBJECT`
- **Hash:** `0x911024442F4898F0`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_DRIVE_ARTICULATED_JOINT(int object, bool toggle, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |
| `p2` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Activate the physics to: "xs_prop_arena_{flipper,wall,bollard,turntable,pit}"
```

---

### SET_DRIVE_ARTICULATED_JOINT_WITH_INFLICTOR

- **命名空间:** `OBJECT`
- **Hash:** `0xB20834A7DD3D8896`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_DRIVE_ARTICULATED_JOINT_WITH_INFLICTOR(int object, bool toggle, int p2, int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |
| `p2` | `int` | `int` | - |
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_ALPHA

- **命名空间:** `ENTITY`
- **Hash:** `0x44A0870B7E92D7C0`
- **JHash:** `0xAE667CB0`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_ALPHA(int entity, int alphaLevel, bool skin)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `alphaLevel` | `int` | `int` | - |
| `skin` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
skin - everything alpha except skin
Set entity alpha level. Ranging from 0 to 255 but chnages occur after every 20 percent (after every 51).
```

---

### SET_ENTITY_ALWAYS_PRERENDER

- **命名空间:** `ENTITY`
- **Hash:** `0xACAD101E1FB66689`
- **JHash:** `0xD8FF798A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_ALWAYS_PRERENDER(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_ANGULAR_VELOCITY

- **命名空间:** `ENTITY`
- **Hash:** `0x8339643499D1222E`
- **Build:** `2372`

**C# 签名:**
```csharp
void SET_ENTITY_ANGULAR_VELOCITY(int entity, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_ANIM_CURRENT_TIME

- **命名空间:** `ENTITY`
- **Hash:** `0x4487C259F0F70977`
- **JHash:** `0x99D90735`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_ANIM_CURRENT_TIME(int entity, string animDictionary, string animName, float time)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `animDictionary` | `const char*` | `string` | - |
| `animName` | `const char*` | `string` | - |
| `time` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### SET_ENTITY_ANIM_SPEED

- **命名空间:** `ENTITY`
- **Hash:** `0x28D1A16553C51776`
- **JHash:** `0x3990C90A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_ANIM_SPEED(int entity, string animDictionary, string animName, float speedMultiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `animDictionary` | `const char*` | `string` | - |
| `animName` | `const char*` | `string` | - |
| `speedMultiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### SET_ENTITY_AS_MISSION_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0xAD738C3085FE7E11`
- **JHash:** `0x5D1F9E0F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_AS_MISSION_ENTITY(int entity, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Makes the specified entity (ped, vehicle or object) persistent. Persistent entities will not automatically be removed by the engine.

p1 has no effect when either its on or off 
maybe a quick disassembly will tell us what it does

p2 has no effect when either its on or off 
maybe a quick disassembly will tell us what it does
```

---

### SET_ENTITY_AS_NO_LONGER_NEEDED

- **命名空间:** `ENTITY`
- **Hash:** `0xB736A491E64A32CF`
- **JHash:** `0xADF2267C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_AS_NO_LONGER_NEEDED(Entity* entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity*` | `Entity*` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Marks the specified entity (ped, vehicle or object) as no longer needed if its population type is set to the mission type.
If the entity is ped, it will also clear their tasks immediately just like when CLEAR_PED_TASKS_IMMEDIATELY is called.
Entities marked as no longer needed, will be deleted as the engine sees fit.
Use this if you just want to just let the game delete the ped:
void MarkPedAsAmbientPed(Ped ped) {
  auto addr = getScriptHandleBaseAddress(ped);

  if (!addr) {
    return;
  }

  //the game uses only lower 4 bits as entity population type 
  BYTE origValue = *(BYTE *)(addr + 0xDA);
  *(BYTE *)(addr + 0xDA) = ((origValue & 0xF0) | ePopulationType::POPTYPE_RANDOM_AMBIENT);
}
```

---

### SET_ENTITY_CANT_CAUSE_COLLISION_DAMAGED_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0x68B562E124CC0AEF`
- **Build:** `1180`

**C# 签名:**
```csharp
void SET_ENTITY_CANT_CAUSE_COLLISION_DAMAGED_ENTITY(int entity1, int entity2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity1` | `Entity` | `int` | - |
| `entity2` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_CAN_BE_DAMAGED

- **命名空间:** `ENTITY`
- **Hash:** `0x1760FFA8AB074D66`
- **JHash:** `0x60B6E744`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_CAN_BE_DAMAGED(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_CAN_BE_DAMAGED_BY_RELATIONSHIP_GROUP

- **命名空间:** `ENTITY`
- **Hash:** `0xE22D8FDE858B8119`
- **JHash:** `0x34165B5D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_CAN_BE_DAMAGED_BY_RELATIONSHIP_GROUP(int entity, bool bCanBeDamaged, int relGroup)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `bCanBeDamaged` | `BOOL` | `bool` | - |
| `relGroup` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_CAN_BE_TARGETED_WITHOUT_LOS

- **命名空间:** `ENTITY`
- **Hash:** `0xD3997889736FD899`
- **JHash:** `0x3B13797C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_CAN_BE_TARGETED_WITHOUT_LOS(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets whether the entity can be targeted without being in line-of-sight.
```

---

### SET_ENTITY_CAN_ONLY_BE_DAMAGED_BY_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0xB17BC6453F6CF5AC`
- **Build:** `944`

**C# 签名:**
```csharp
void SET_ENTITY_CAN_ONLY_BE_DAMAGED_BY_ENTITY(int entity1, int entity2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity1` | `Entity` | `int` | - |
| `entity2` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_CAN_ONLY_BE_DAMAGED_BY_SCRIPT_PARTICIPANTS

- **命名空间:** `ENTITY`
- **Hash:** `0x352E2B5CF420BF3B`
- **Build:** `573`

**C# 签名:**
```csharp
void SET_ENTITY_CAN_ONLY_BE_DAMAGED_BY_SCRIPT_PARTICIPANTS(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_COLLISION

- **命名空间:** `ENTITY`
- **Hash:** `0x1A9205C1B9EE827F`
- **JHash:** `0x139FD37D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_COLLISION(int entity, bool toggle, bool keepPhysics)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |
| `keepPhysics` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_COMPLETELY_DISABLE_COLLISION

- **命名空间:** `ENTITY`
- **Hash:** `0x9EBC85ED0FFFE51C`
- **JHash:** `0xBD0D4831`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_COMPLETELY_DISABLE_COLLISION(int entity, bool toggle, bool keepPhysics)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |
| `keepPhysics` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_COORDS

- **命名空间:** `ENTITY`
- **Hash:** `0x06843DA7060A026B`
- **JHash:** `0xDF70B41B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_COORDS(int entity, float xPos, float yPos, float zPos, bool xAxis, bool yAxis, bool zAxis, bool clearArea)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `xPos` | `float` | `float` | - |
| `yPos` | `float` | `float` | - |
| `zPos` | `float` | `float` | - |
| `xAxis` | `BOOL` | `bool` | - |
| `yAxis` | `BOOL` | `bool` | - |
| `zAxis` | `BOOL` | `bool` | - |
| `clearArea` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p7 is always 1 in the scripts. Set to 1, an area around the destination coords for the moved entity is cleared from other entities. 
 
Often ends with 1, 0, 0, 1); in the scripts. It works. 

Axis - Invert Axis Flags
```

---

### SET_ENTITY_COORDS_NO_OFFSET

- **命名空间:** `ENTITY`
- **Hash:** `0x239A3351AC1DA385`
- **JHash:** `0x4C83DE8D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_COORDS_NO_OFFSET(int entity, float xPos, float yPos, float zPos, bool xAxis, bool yAxis, bool zAxis)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `xPos` | `float` | `float` | - |
| `yPos` | `float` | `float` | - |
| `zPos` | `float` | `float` | - |
| `xAxis` | `BOOL` | `bool` | - |
| `yAxis` | `BOOL` | `bool` | - |
| `zAxis` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Axis - Invert Axis Flags
```

---

### SET_ENTITY_COORDS_WITHOUT_PLANTS_RESET

- **命名空间:** `ENTITY`
- **Hash:** `0x621873ECE1178967`
- **JHash:** `0x749B282E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_COORDS_WITHOUT_PLANTS_RESET(int entity, float xPos, float yPos, float zPos, bool alive, bool deadFlag, bool ragdollFlag, bool clearArea)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `xPos` | `float` | `float` | - |
| `yPos` | `float` | `float` | - |
| `zPos` | `float` | `float` | - |
| `alive` | `BOOL` | `bool` | - |
| `deadFlag` | `BOOL` | `bool` | - |
| `ragdollFlag` | `BOOL` | `bool` | - |
| `clearArea` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_DYNAMIC

- **命名空间:** `ENTITY`
- **Hash:** `0x1718DE8E3F2823CA`
- **JHash:** `0x236F525B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_DYNAMIC(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_FLAG_RENDER_SMALL_SHADOW

- **命名空间:** `OBJECT`
- **Hash:** `0xB2D0BDE54F0E8E5A`
- **JHash:** `0x132B6D92`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_FLAG_RENDER_SMALL_SHADOW(int object, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_FLAG_SUPPRESS_SHADOW

- **命名空间:** `OBJECT`
- **Hash:** `0xD05A3241B9A86F19`
- **Build:** `1180`

**C# 签名:**
```csharp
void SET_ENTITY_FLAG_SUPPRESS_SHADOW(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets entity+38 to C (when false) or 0xFF3f (when true)
```

---

### SET_ENTITY_HAS_GRAVITY

- **命名空间:** `ENTITY`
- **Hash:** `0x4A4722448F18EEF5`
- **JHash:** `0xE2F262BF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_HAS_GRAVITY(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_HEADING

- **命名空间:** `ENTITY`
- **Hash:** `0x8E2530AA8ADA980E`
- **JHash:** `0xE0FF064D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_HEADING(int entity, float heading)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `heading` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Set the heading of an entity in degrees also known as "Yaw".
```

---

### SET_ENTITY_HEALTH

- **命名空间:** `ENTITY`
- **Hash:** `0x6B76DC1F3AE6E6A3`
- **JHash:** `0xFBCD1831`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_HEALTH(int entity, int health, int instigator, uint weaponType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `health` | `int` | `int` | - |
| `instigator` | `Entity` | `int` | - |
| `weaponType` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
health >= 0
male ped ~= 100 - 200
female ped ~= 0 - 100
```

---

### SET_ENTITY_INVINCIBLE

- **命名空间:** `ENTITY`
- **Hash:** `0x3882114BDE571AD4`
- **JHash:** `0xC1213A21`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_INVINCIBLE(int entity, bool toggle, bool dontResetOnCleanup)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |
| `dontResetOnCleanup` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets a ped or an object totally invincible. It doesn't take any kind of damage. Peds will not ragdoll on explosions and the tazer animation won't apply either.

If you use this for a ped and you want Ragdoll to stay enabled, then do:
*(DWORD *)(pedAddress + 0x188) |= (1 << 9);

Use this if you want to get the invincibility status:
  bool IsPedInvincible(Ped ped)
 {
     auto addr = getScriptHandleBaseAddress(ped);    

        if (addr)
     {
         DWORD flag = *(DWORD *)(addr + 0x188);
            return ((flag & (1 << 8)) != 0) || ((flag & (1 << 9)) != 0);
      }

       return false;
 }
```

---

### SET_ENTITY_IS_IN_VEHICLE

- **命名空间:** `ENTITY`
- **Hash:** `0x78E8E3A640178255`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_IS_IN_VEHICLE(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_IS_TARGET_PRIORITY

- **命名空间:** `ENTITY`
- **Hash:** `0xEA02E132F5C68722`
- **JHash:** `0x9729EE32`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_IS_TARGET_PRIORITY(int entity, bool p1, float p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_LIGHTS

- **命名空间:** `ENTITY`
- **Hash:** `0x7CFBA6A80BDF3874`
- **JHash:** `0xE8FC85AF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_LIGHTS(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_LOAD_COLLISION_FLAG

- **命名空间:** `ENTITY`
- **Hash:** `0x0DC7CABAB1E9B67E`
- **JHash:** `0xC52F295B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_LOAD_COLLISION_FLAG(int entity, bool toggle, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Loads collision grid for an entity spawned outside of a player's loaded area. This allows peds to execute tasks rather than sit dormant because of a lack of a physics grid.
Certainly not the main usage of this native but when set to true for a Vehicle, it will prevent the vehicle to explode if it is spawned far away from the player.
```

---

### SET_ENTITY_LOD_DIST

- **命名空间:** `ENTITY`
- **Hash:** `0x5927F96A78577363`
- **JHash:** `0xD7ACC7AD`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_LOD_DIST(int entity, int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `value` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
LOD distance can be 0 to 0xFFFF (higher values will result in 0xFFFF) as it is actually stored as a 16-bit value (aka uint16_t).
```

---

### SET_ENTITY_MAX_HEALTH

- **命名空间:** `ENTITY`
- **Hash:** `0x166E7CF68597D8B5`
- **JHash:** `0x96F84DF8`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_MAX_HEALTH(int entity, int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `value` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
For instance: ENTITY::SET_ENTITY_MAX_HEALTH(PLAYER::PLAYER_PED_ID(), 200); // director_mode.c4: 67849
```

---

### SET_ENTITY_MAX_SPEED

- **命名空间:** `ENTITY`
- **Hash:** `0x0E46A3FCBDE2A1B1`
- **JHash:** `0x46AFFED3`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_MAX_SPEED(int entity, float speed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `speed` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_MIRROR_REFLECTION_FLAG

- **命名空间:** `ENTITY`
- **Hash:** `0xE66377CDDADA4810`
- **Build:** `1734`

**C# 签名:**
```csharp
void SET_ENTITY_MIRROR_REFLECTION_FLAG(int entity, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_MOTION_BLUR

- **命名空间:** `ENTITY`
- **Hash:** `0x295D82A8559F9150`
- **JHash:** `0xE90005B8`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_MOTION_BLUR(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_NOWEAPONDECALS

- **命名空间:** `ENTITY`
- **Hash:** `0x2C2E3DC128F44309`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_NOWEAPONDECALS(int entity, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_NO_COLLISION_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0xA53ED5520C07654A`
- **JHash:** `0x1E11BFE9`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_NO_COLLISION_ENTITY(int entity1, int entity2, bool thisFrameOnly)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity1` | `Entity` | `int` | - |
| `entity2` | `Entity` | `int` | - |
| `thisFrameOnly` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Calling this function disables collision between two entities.
The importance of the order for entity1 and entity2 is unclear.
The third parameter, `thisFrame`, decides whether the collision is to be disabled until it is turned back on, or if it's just this frame.
```

---

### SET_ENTITY_ONLY_DAMAGED_BY_PLAYER

- **命名空间:** `ENTITY`
- **Hash:** `0x79F020FF9EDC0748`
- **JHash:** `0x4B707F50`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_ONLY_DAMAGED_BY_PLAYER(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_ONLY_DAMAGED_BY_RELATIONSHIP_GROUP

- **命名空间:** `ENTITY`
- **Hash:** `0x7022BD828FA0B082`
- **JHash:** `0x202237E2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_ONLY_DAMAGED_BY_RELATIONSHIP_GROUP(int entity, bool p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_PROOFS

- **命名空间:** `ENTITY`
- **Hash:** `0xFAEE099C6F890BB8`
- **JHash:** `0x7E9EAB66`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_PROOFS(int entity, bool bulletProof, bool fireProof, bool explosionProof, bool collisionProof, bool meleeProof, bool steamProof, bool dontResetOnCleanup, bool waterProof)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `bulletProof` | `BOOL` | `bool` | - |
| `fireProof` | `BOOL` | `bool` | - |
| `explosionProof` | `BOOL` | `bool` | - |
| `collisionProof` | `BOOL` | `bool` | - |
| `meleeProof` | `BOOL` | `bool` | - |
| `steamProof` | `BOOL` | `bool` | - |
| `dontResetOnCleanup` | `BOOL` | `bool` | - |
| `waterProof` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Enable / disable each type of damage.

waterProof is damage related to water not drowning
--------------
p7 is to to '1' in am_mp_property_ext/int: ENTITY::SET_ENTITY_PROOFS(uParam0->f_19, true, true, true, true, true, true, 1, true);

```

---

### SET_ENTITY_QUATERNION

- **命名空间:** `ENTITY`
- **Hash:** `0x77B21BE7AC540F07`
- **JHash:** `0x83B6046F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_QUATERNION(int entity, float x, float y, float z, float w)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `w` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
w is the correct parameter name!
```

---

### SET_ENTITY_RECORDS_COLLISIONS

- **命名空间:** `ENTITY`
- **Hash:** `0x0A50A1EEDAD01E65`
- **JHash:** `0x6B189A1A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_RECORDS_COLLISIONS(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_RENDER_SCORCHED

- **命名空间:** `ENTITY`
- **Hash:** `0x730F5F8D3F0F2050`
- **JHash:** `0xAAC9317B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_RENDER_SCORCHED(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_REQUIRES_MORE_EXPENSIVE_RIVER_CHECK

- **命名空间:** `ENTITY`
- **Hash:** `0x694E00132F2823ED`
- **JHash:** `0x40C84A74`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_REQUIRES_MORE_EXPENSIVE_RIVER_CHECK(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_ROTATION

- **命名空间:** `ENTITY`
- **Hash:** `0x8524A8B0171D5E07`
- **JHash:** `0x0A345EFE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_ROTATION(int entity, float pitch, float roll, float yaw, int rotationOrder, bool p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `pitch` | `float` | `float` | - |
| `roll` | `float` | `float` | - |
| `yaw` | `float` | `float` | - |
| `rotationOrder` | `int` | `int` | - |
| `p5` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
rotationOrder refers to the order yaw pitch roll is applied
value ranges from 0 to 5. What you use for rotationOrder when setting must be the same as rotationOrder when getting the rotation. 
Unsure what value corresponds to what rotation order, more testing will be needed for that.
For the most part R* uses 1 or 2 as the order.
p5 is usually set as true

```

---

### SET_ENTITY_SHOULD_FREEZE_WAITING_ON_COLLISION

- **命名空间:** `ENTITY`
- **Hash:** `0x3910051CCECDB00C`
- **JHash:** `0xD3850671`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_SHOULD_FREEZE_WAITING_ON_COLLISION(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
True means it can be deleted by the engine when switching lobbies/missions/etc, false means the script is expected to clean it up.

"Allow Freeze If No Collision"
```

---

### SET_ENTITY_SORT_BIAS

- **命名空间:** `ENTITY`
- **Hash:** `0x5C3B791D580E0BC2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_SORT_BIAS(int entity, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Only called once in the scripts.

Related to weapon objects.

```

---

### SET_ENTITY_TRAFFICLIGHT_OVERRIDE

- **命名空间:** `ENTITY`
- **Hash:** `0x57C5DB656185EAC4`
- **JHash:** `0xC47F5B91`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_TRAFFICLIGHT_OVERRIDE(int entity, int state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `state` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Example here: www.gtaforums.com/topic/830463-help-with-turning-lights-green-and-causing-peds-to-crash-into-each-other/#entry1068211340

0 = green
1 = red
2 = yellow
3 = reset changes
changing lights may not change the behavior of vehicles
```

---

### SET_ENTITY_USE_MAX_DISTANCE_FOR_WATER_REFLECTION

- **命名空间:** `ENTITY`
- **Hash:** `0x1A092BB0C3808B96`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_USE_MAX_DISTANCE_FOR_WATER_REFLECTION(int entity, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_VELOCITY

- **命名空间:** `ENTITY`
- **Hash:** `0x1C99BB7B6E96D16F`
- **JHash:** `0xFF5A1988`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_VELOCITY(int entity, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Note that the third parameter(denoted as z) is "up and down" with positive numbers encouraging upwards movement.
```

---

### SET_ENTITY_VISIBLE

- **命名空间:** `ENTITY`
- **Hash:** `0xEA1C610A04DB6BBB`
- **JHash:** `0xD043E8E1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_VISIBLE(int entity, bool toggle, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p2 is always 0.
```

---

### SET_ENTITY_WATER_REFLECTION_FLAG

- **命名空间:** `ENTITY`
- **Hash:** `0xC34BC448DA29F5E9`
- **Build:** `573`

**C# 签名:**
```csharp
void SET_ENTITY_WATER_REFLECTION_FLAG(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FORCE_OBJECT_THIS_FRAME

- **命名空间:** `OBJECT`
- **Hash:** `0xF538081986E49E9D`
- **JHash:** `0x3DA41C1A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FORCE_OBJECT_THIS_FRAME(float x, float y, float z, float p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p3` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_IS_OBJECT_ARTICULATED

- **命名空间:** `OBJECT`
- **Hash:** `0x1C57C94A6446492A`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_IS_OBJECT_ARTICULATED(int object, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_IS_OBJECT_BALL

- **命名空间:** `OBJECT`
- **Hash:** `0xB5B7742424BD4445`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_IS_OBJECT_BALL(int object, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_LOCAL_PLAYER_CAN_COLLECT_PORTABLE_PICKUPS

- **命名空间:** `OBJECT`
- **Hash:** `0x78857FC65CADB909`
- **JHash:** `0xA3CDF152`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_LOCAL_PLAYER_CAN_COLLECT_PORTABLE_PICKUPS(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_LOCAL_PLAYER_PERMITTED_TO_COLLECT_PICKUPS_WITH_MODEL

- **命名空间:** `OBJECT`
- **Hash:** `0x88EAEC617CD26926`
- **JHash:** `0x3A8F1BF7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_LOCAL_PLAYER_PERMITTED_TO_COLLECT_PICKUPS_WITH_MODEL(uint modelHash, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Maximum amount of pickup models that can be disallowed is 30.
```

---

### SET_LOCKED_UNSTREAMED_IN_DOOR_OF_TYPE

- **命名空间:** `OBJECT`
- **Hash:** `0x9B12F9A24FABEDB0`
- **JHash:** `0x4E0A260B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_LOCKED_UNSTREAMED_IN_DOOR_OF_TYPE(uint modelHash, float x, float y, float z, bool locked, float xRotMult, float yRotMult, float zRotMult)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `locked` | `BOOL` | `bool` | - |
| `xRotMult` | `float` | `float` | - |
| `yRotMult` | `float` | `float` | - |
| `zRotMult` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Hardcoded not to work in multiplayer environments.
When you set locked to 0 the door open and to 1 the door close
OBJECT::SET_LOCKED_UNSTREAMED_IN_DOOR_OF_TYPE(${prop_gate_prison_01}, 1845.0, 2605.0, 45.0, 0, 0.0, 50.0, 0);  //door open

OBJECT::SET_LOCKED_UNSTREAMED_IN_DOOR_OF_TYPE(${prop_gate_prison_01}, 1845.0, 2605.0, 45.0, 1, 0.0, 50.0, 0);  //door close
```

---

### SET_MAX_NUM_PORTABLE_PICKUPS_CARRIED_BY_PLAYER

- **命名空间:** `OBJECT`
- **Hash:** `0x0BF3B3BD47D79C08`
- **JHash:** `0x7EFBA039`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_MAX_NUM_PORTABLE_PICKUPS_CARRIED_BY_PLAYER(uint modelHash, int number)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |
| `number` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_OBJECT_ALLOW_LOW_LOD_BUOYANCY

- **命名空间:** `OBJECT`
- **Hash:** `0x4D89D607CB3DD1D2`
- **JHash:** `0x19B17769`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_OBJECT_ALLOW_LOW_LOD_BUOYANCY(int object, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Overrides the climbing/blocking flags of the object, used in the native scripts mostly for "prop_dock_bouy_*"
```

---

### SET_OBJECT_AS_NO_LONGER_NEEDED

- **命名空间:** `ENTITY`
- **Hash:** `0x3AE22DEB5BA5A3E6`
- **JHash:** `0x3F6B949F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_OBJECT_AS_NO_LONGER_NEEDED(Object* object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object*` | `Object*` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This is an alias of SET_ENTITY_AS_NO_LONGER_NEEDED.
```

---

### SET_OBJECT_FORCE_VEHICLES_TO_AVOID

- **命名空间:** `OBJECT`
- **Hash:** `0x77F33F2CCF64B3AA`
- **JHash:** `0x483C5C88`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_OBJECT_FORCE_VEHICLES_TO_AVOID(int object, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Overrides a flag on the object which determines if the object should be avoided by a vehicle in task CTaskVehicleGoToPointWithAvoidanceAutomobile.
```

---

### SET_OBJECT_GLOW_IN_SAME_TEAM

- **命名空间:** `OBJECT`
- **Hash:** `0x62454A641B41F3C5`
- **Build:** `678`

**C# 签名:**
```csharp
void SET_OBJECT_GLOW_IN_SAME_TEAM(int pickup)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_OBJECT_IS_A_PRESSURE_PLATE

- **命名空间:** `OBJECT`
- **Hash:** `0x734E1714D077DA9A`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_OBJECT_IS_A_PRESSURE_PLATE(int object, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_OBJECT_IS_SPECIAL_GOLFBALL

- **命名空间:** `OBJECT`
- **Hash:** `0xC6033D32241F6FB5`
- **JHash:** `0xF4A1A14A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_OBJECT_IS_SPECIAL_GOLFBALL(int object, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_OBJECT_IS_VISIBLE_IN_MIRRORS

- **命名空间:** `OBJECT`
- **Hash:** `0x3B2FD68DB5F8331C`
- **Build:** `757`

**C# 签名:**
```csharp
void SET_OBJECT_IS_VISIBLE_IN_MIRRORS(int object, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_OBJECT_PHYSICS_PARAMS

- **命名空间:** `OBJECT`
- **Hash:** `0xF6DF6E90DE7DF90F`
- **JHash:** `0xE8D11C58`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_OBJECT_PHYSICS_PARAMS(int object, float weight, float p2, float p3, float p4, float p5, float gravity, float p7, float p8, float p9, float p10, float buoyancy)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `weight` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `float` | `float` | - |
| `p5` | `float` | `float` | - |
| `gravity` | `float` | `float` | - |
| `p7` | `float` | `float` | - |
| `p8` | `float` | `float` | - |
| `p9` | `float` | `float` | - |
| `p10` | `float` | `float` | - |
| `buoyancy` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Adjust the physics parameters of a prop, or otherwise known as "object". This is useful for simulated gravity.

Other parameters seem to be unknown.

p2: seems to be weight and gravity related. Higher value makes the obj fall faster. Very sensitive?
p3: seems similar to p2
p4: makes obj fall slower the higher the value
p5: similar to p4
```

---

### SET_OBJECT_SPEED_BOOST_AMOUNT

- **命名空间:** `OBJECT`
- **Hash:** `0x96EE0EBA0163DF80`
- **Build:** `791`

**C# 签名:**
```csharp
void SET_OBJECT_SPEED_BOOST_AMOUNT(int object, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_OBJECT_SPEED_BOOST_DURATION

- **命名空间:** `OBJECT`
- **Hash:** `0xDF6CA0330F2E737B`
- **Build:** `791`

**C# 签名:**
```csharp
void SET_OBJECT_SPEED_BOOST_DURATION(int object, float duration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `duration` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_OBJECT_TAKES_DAMAGE_FROM_COLLIDING_WITH_BUILDINGS

- **命名空间:** `OBJECT`
- **Hash:** `0xEB6F1A9B5510A5D2`
- **JHash:** `0xAF016CC1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_OBJECT_TAKES_DAMAGE_FROM_COLLIDING_WITH_BUILDINGS(object p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_OBJECT_TARGETTABLE

- **命名空间:** `OBJECT`
- **Hash:** `0x8A7391690F5AFD81`
- **JHash:** `0x3F88CD86`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_OBJECT_TARGETTABLE(int object, bool targettable, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `targettable` | `BOOL` | `bool` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_OBJECT_TINT_INDEX

- **命名空间:** `OBJECT`
- **Hash:** `0x971DA0055324D033`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_OBJECT_TINT_INDEX(int object, int textureVariation)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `textureVariation` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
enum ObjectPaintVariants
{
 Pacific = 0,
  Azure = 1,
    Nautical = 2,
 Continental = 3,
  Battleship = 4,
   Intrepid = 5,
 Uniform = 6,
  Classico = 7,
 Mediterranean = 8,
    Command = 9,
  Mariner = 10,
 Ruby = 11,
    Vintage = 12,
 Pristine = 13,
    Merchant = 14,
    Voyager = 15
};
```

---

### SET_ONLY_ALLOW_AMMO_COLLECTION_WHEN_LOW

- **命名空间:** `OBJECT`
- **Hash:** `0x31F924B53EADDF65`
- **JHash:** `0xDB18FA01`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ONLY_ALLOW_AMMO_COLLECTION_WHEN_LOW(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_AS_NO_LONGER_NEEDED

- **命名空间:** `ENTITY`
- **Hash:** `0x2595DD4236549CE3`
- **JHash:** `0x9A388380`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_AS_NO_LONGER_NEEDED(Ped* ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped*` | `Ped*` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This is an alias of SET_ENTITY_AS_NO_LONGER_NEEDED.
```

---

### SET_PICKUP_COLLIDES_WITH_PROJECTILES

- **命名空间:** `ENTITY`
- **Hash:** `0xCEA7C8E1B48FF68C`
- **Build:** `678`

**C# 签名:**
```csharp
void SET_PICKUP_COLLIDES_WITH_PROJECTILES(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PICKUP_GENERATION_RANGE_MULTIPLIER

- **命名空间:** `OBJECT`
- **Hash:** `0x318516E02DE3ECE2`
- **JHash:** `0x9879AC51`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PICKUP_GENERATION_RANGE_MULTIPLIER(float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PICKUP_GLOW_OFFSET

- **命名空间:** `OBJECT`
- **Hash:** `0x0596843B34B95CE5`
- **Build:** `505`

**C# 签名:**
```csharp
void SET_PICKUP_GLOW_OFFSET(int pickup, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 is always 0.51. This native is called before SET_PICKUP_REGENERATION_TIME in all occurances.
```

---

### SET_PICKUP_HIDDEN_WHEN_UNCOLLECTABLE

- **命名空间:** `OBJECT`
- **Hash:** `0x3ED2B83AB2E82799`
- **Build:** `757`

**C# 签名:**
```csharp
void SET_PICKUP_HIDDEN_WHEN_UNCOLLECTABLE(int pickup, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PICKUP_OBJECT_ALPHA_WHEN_TRANSPARENT

- **命名空间:** `OBJECT`
- **Hash:** `0x8CFF648FBD7330F1`
- **Build:** `757`

**C# 签名:**
```csharp
void SET_PICKUP_OBJECT_ALPHA_WHEN_TRANSPARENT(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p0 is either 0 or 50 in scripts.
```

---

### SET_PICKUP_OBJECT_ARROW_MARKER

- **命名空间:** `OBJECT`
- **Hash:** `0x39A5FB7EAF150840`
- **Build:** `678`

**C# 签名:**
```csharp
void SET_PICKUP_OBJECT_ARROW_MARKER(int pickup, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PICKUP_OBJECT_COLLECTABLE_IN_VEHICLE

- **命名空间:** `OBJECT`
- **Hash:** `0x7813E8B8C4AE4799`
- **Build:** `1734`

**C# 签名:**
```csharp
void SET_PICKUP_OBJECT_COLLECTABLE_IN_VEHICLE(int pickup)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PICKUP_OBJECT_GLOW_OFFSET

- **命名空间:** `OBJECT`
- **Hash:** `0xA08FE5E49BDC39DD`
- **JHash:** `0x276A7807`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PICKUP_OBJECT_GLOW_OFFSET(int pickup, float p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |
| `p1` | `float` | `float` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 is always -0.2 in scripts and p2 is always true in scripts.
```

---

### SET_PICKUP_OBJECT_GLOW_WHEN_UNCOLLECTABLE

- **命名空间:** `OBJECT`
- **Hash:** `0x27F248C3FEBFAAD3`
- **Build:** `2372`

**C# 签名:**
```csharp
void SET_PICKUP_OBJECT_GLOW_WHEN_UNCOLLECTABLE(int pickup, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PICKUP_OBJECT_TRANSPARENT_WHEN_UNCOLLECTABLE

- **命名空间:** `OBJECT`
- **Hash:** `0x8881C98A31117998`
- **Build:** `678`

**C# 签名:**
```csharp
void SET_PICKUP_OBJECT_TRANSPARENT_WHEN_UNCOLLECTABLE(int pickup, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PICKUP_REGENERATION_TIME

- **命名空间:** `OBJECT`
- **Hash:** `0x78015C9B4B3ECC9D`
- **JHash:** `0xAB11267D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PICKUP_REGENERATION_TIME(int pickup, int duration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |
| `duration` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PICKUP_TRACK_DAMAGE_EVENTS

- **命名空间:** `OBJECT`
- **Hash:** `0xBFFE53AE7E67FCDC`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_PICKUP_TRACK_DAMAGE_EVENTS(int pickup, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PICKUP_TRANSPARENT_WHEN_UNCOLLECTABLE

- **命名空间:** `OBJECT`
- **Hash:** `0x858EC9FD25DE04AA`
- **Build:** `757`

**C# 签名:**
```csharp
void SET_PICKUP_TRANSPARENT_WHEN_UNCOLLECTABLE(int pickup, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PICKUP_UNCOLLECTABLE

- **命名空间:** `OBJECT`
- **Hash:** `0x1C1B69FAE509BA97`
- **Build:** `757`

**C# 签名:**
```csharp
void SET_PICKUP_UNCOLLECTABLE(int pickup, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PICK_UP_BY_CARGOBOB_DISABLED

- **命名空间:** `ENTITY`
- **Hash:** `0xD7B80E7C3BEFC396`
- **Build:** `1180`

**C# 签名:**
```csharp
void SET_PICK_UP_BY_CARGOBOB_DISABLED(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_PERMITTED_TO_COLLECT_PICKUPS_OF_TYPE

- **命名空间:** `OBJECT`
- **Hash:** `0x616093EC6B139DD9`
- **JHash:** `0x7FADB4B9`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_PERMITTED_TO_COLLECT_PICKUPS_OF_TYPE(int player, uint pickupHash, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `pickupHash` | `Hash` | `uint` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Disabling/enabling a player from getting pickups. From the scripts:

OBJECT::SET_PLAYER_PERMITTED_TO_COLLECT_PICKUPS_OF_TYPE(PLAYER::PLAYER_ID(), ${pickup_portable_package}, 0);
OBJECT::SET_PLAYER_PERMITTED_TO_COLLECT_PICKUPS_OF_TYPE(PLAYER::PLAYER_ID(), ${pickup_portable_package}, 0);
OBJECT::SET_PLAYER_PERMITTED_TO_COLLECT_PICKUPS_OF_TYPE(PLAYER::PLAYER_ID(), ${pickup_portable_package}, 1);
OBJECT::SET_PLAYER_PERMITTED_TO_COLLECT_PICKUPS_OF_TYPE(PLAYER::PLAYER_ID(), ${pickup_portable_package}, 0);
OBJECT::SET_PLAYER_PERMITTED_TO_COLLECT_PICKUPS_OF_TYPE(PLAYER::PLAYER_ID(), ${pickup_armour_standard}, 0);
OBJECT::SET_PLAYER_PERMITTED_TO_COLLECT_PICKUPS_OF_TYPE(PLAYER::PLAYER_ID(), ${pickup_armour_standard}, 1);

Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
```

---

### SET_PORTABLE_PICKUP_PERSIST

- **命名空间:** `OBJECT`
- **Hash:** `0x46F3ADD1E2D5BAF2`
- **Build:** `877`

**C# 签名:**
```csharp
void SET_PORTABLE_PICKUP_PERSIST(int pickup, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PROJECTILES_SHOULD_EXPLODE_ON_CONTACT

- **命名空间:** `OBJECT`
- **Hash:** `0x63ECF581BC70E363`
- **Build:** `1365`

**C# 签名:**
```csharp
void SET_PROJECTILES_SHOULD_EXPLODE_ON_CONTACT(int entity, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PROP_LIGHT_COLOR

- **命名空间:** `OBJECT`
- **Hash:** `0x5F048334B4A4E774`
- **Build:** `1493`

**C# 签名:**
```csharp
bool SET_PROP_LIGHT_COLOR(int object, bool p1, int r, int g, int b)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `r` | `int` | `int` | - |
| `g` | `int` | `int` | - |
| `b` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### SET_PROP_TINT_INDEX

- **命名空间:** `OBJECT`
- **Hash:** `0x31574B1B41268673`
- **Build:** `2189`

**C# 签名:**
```csharp
void SET_PROP_TINT_INDEX(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_STATE_OF_CLOSEST_DOOR_OF_TYPE

- **命名空间:** `OBJECT`
- **Hash:** `0xF82D8F1926A02C3D`
- **JHash:** `0x38C951A4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_STATE_OF_CLOSEST_DOOR_OF_TYPE(uint type, float x, float y, float z, bool locked, float heading, bool p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `type` | `Hash` | `uint` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `locked` | `BOOL` | `bool` | - |
| `heading` | `float` | `float` | - |
| `p6` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Hardcoded to not work in multiplayer.


Used to lock/unlock doors to interior areas of the game.

(Possible) Door Types:

https://pastebin.com/9S2m3qA4

Heading is either 1, 0 or -1 in the scripts. Means default closed(0) or opened either into(1) or out(-1) of the interior.
Locked means that the heading is locked.  
p6 is always 0. 

225 door types, model names and coords found in stripclub.c4:
https://pastebin.com/gywnbzsH

get door info: https://pastebin.com/i14rbekD
```

---

### SET_STATE_OF_RAYFIRE_MAP_OBJECT

- **命名空间:** `OBJECT`
- **Hash:** `0x5C29F698D404C5E1`
- **JHash:** `0x21F51560`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_STATE_OF_RAYFIRE_MAP_OBJECT(int object, int state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `state` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Defines the state of a destructible object.
Use the GET_RAYFIRE_MAP_OBJECT native to find an object's handle with its name / coords.
State 2 == object just spawned
State 4 == Beginning of the animation
State 6 == Start animation
State 9 == End of the animation
```

---

### SET_TEAM_PICKUP_OBJECT

- **命名空间:** `OBJECT`
- **Hash:** `0x53E0DF1A2A3CF0CA`
- **JHash:** `0x77687DC5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TEAM_PICKUP_OBJECT(int object, object p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TINT_INDEX_CLOSEST_BUILDING_OF_TYPE

- **命名空间:** `OBJECT`
- **Hash:** `0xF12E33034D887F66`
- **Build:** `1103`

**C# 签名:**
```csharp
bool SET_TINT_INDEX_CLOSEST_BUILDING_OF_TYPE(float x, float y, float z, float radius, uint modelHash, int textureVariation)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `modelHash` | `Hash` | `uint` | - |
| `textureVariation` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### SET_VEHICLE_AS_NO_LONGER_NEEDED

- **命名空间:** `ENTITY`
- **Hash:** `0x629BFA74418D6239`
- **JHash:** `0x9B0E10BE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_AS_NO_LONGER_NEEDED(Vehicle* vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle*` | `Vehicle*` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This is an alias of SET_ENTITY_AS_NO_LONGER_NEEDED.
```

---

### SET_WAIT_FOR_COLLISIONS_BEFORE_PROBE

- **命名空间:** `ENTITY`
- **Hash:** `0xDC6F8601FAF2E893`
- **JHash:** `0xA0466A69`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_WAIT_FOR_COLLISIONS_BEFORE_PROBE(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Only called within 1 script for x360. 'fm_mission_controller' and it used on an object. 

Ran after these 2 natives,
set_object_targettable(uParam0, 0);
set_entity_invincible(uParam0, 1);
```

---

### SET_WEAPON_IMPACTS_APPLY_GREATER_FORCE

- **命名空间:** `OBJECT`
- **Hash:** `0x1A6CBB06E2D0D79D`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_WEAPON_IMPACTS_APPLY_GREATER_FORCE(int object, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SLIDE_OBJECT

- **命名空间:** `OBJECT`
- **Hash:** `0x2FDFF4107B8C1147`
- **JHash:** `0x63BFA7A0`
- **Build:** `323`

**C# 签名:**
```csharp
bool SLIDE_OBJECT(int object, float toX, float toY, float toZ, float speedX, float speedY, float speedZ, bool collision)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `toX` | `float` | `float` | - |
| `toY` | `float` | `float` | - |
| `toZ` | `float` | `float` | - |
| `speedX` | `float` | `float` | - |
| `speedY` | `float` | `float` | - |
| `speedZ` | `float` | `float` | - |
| `collision` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if the object has finished moving.

If false, moves the object towards the specified X, Y and Z coordinates with the specified X, Y and Z speed.

See also: https://gtagmodding.com/opcode-database/opcode/034E/
Has to be looped until it returns true.
```

---

### STOP_ENTITY_ANIM

- **命名空间:** `ENTITY`
- **Hash:** `0x28004F88151E03E0`
- **JHash:** `0xC4769830`
- **Build:** `323`

**C# 签名:**
```csharp
bool STOP_ENTITY_ANIM(int entity, string animation, string animGroup, float p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `animation` | `const char*` | `string` | - |
| `animGroup` | `const char*` | `string` | - |
| `p3` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json

RAGEPluginHook list: docs.ragepluginhook.net/html/62951c37-a440-478c-b389-c471230ddfc5.htm
```

---

### STOP_SYNCHRONIZED_ENTITY_ANIM

- **命名空间:** `ENTITY`
- **Hash:** `0x43D3807C077261E3`
- **JHash:** `0xE27D2FC1`
- **Build:** `323`

**C# 签名:**
```csharp
bool STOP_SYNCHRONIZED_ENTITY_ANIM(int entity, float p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `p1` | `float` | `float` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### STOP_SYNCHRONIZED_MAP_ENTITY_ANIM

- **命名空间:** `ENTITY`
- **Hash:** `0x11E79CAB7183B6F5`
- **JHash:** `0x7253D5B2`
- **Build:** `323`

**C# 签名:**
```csharp
bool STOP_SYNCHRONIZED_MAP_ENTITY_ANIM(float x1, float y1, float z1, float x2, object y2, float z2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `Any` | `object` | - |
| `z2` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### SUPPRESS_PICKUP_REWARD_TYPE

- **命名空间:** `OBJECT`
- **Hash:** `0xF92099527DB8E2A7`
- **JHash:** `0xA7E936FD`
- **Build:** `323`

**C# 签名:**
```csharp
void SUPPRESS_PICKUP_REWARD_TYPE(int rewardType, bool suppress)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `rewardType` | `int` | `int` | - |
| `suppress` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
enum ePickupRewardType
{
    PICKUP_REWARD_TYPE_AMMO = (1 << 0),
    PICKUP_REWARD_TYPE_BULLET_MP = (1 << 1),
    PICKUP_REWARD_TYPE_MISSILE_MP = (1 << 2),
    PICKUP_REWARD_TYPE_GRENADE_LAUNCHER_MP = (1 << 3),
    PICKUP_REWARD_TYPE_ARMOUR = (1 << 4),
    PICKUP_REWARD_TYPE_HEALTH = (1 << 5),
    PICKUP_REWARD_TYPE_HEALTH_VARIABLE = PICKUP_REWARD_TYPE_HEALTH,
    PICKUP_REWARD_TYPE_MONEY_FIXED = (1 << 6),
    PICKUP_REWARD_TYPE_MONEY_VARIABLE = PICKUP_REWARD_TYPE_MONEY_FIXED,
    PICKUP_REWARD_TYPE_WEAPON = (1 << 7),
    PICKUP_REWARD_TYPE_STAT = (1 << 8),
    PICKUP_REWARD_TYPE_STAT_VARIABLE = PICKUP_REWARD_TYPE_STAT,
    PICKUP_REWARD_TYPE_VEHICLE_FIX = (1 << 9),
    PICKUP_REWARD_TYPE_FIREWORK_MP = (1 << 10),
};
```

---

### SUPPRESS_PICKUP_SOUND_FOR_PICKUP

- **命名空间:** `OBJECT`
- **Hash:** `0x8DCA505A5C196F05`
- **Build:** `1180`

**C# 签名:**
```csharp
void SUPPRESS_PICKUP_SOUND_FOR_PICKUP(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### TRACK_OBJECT_VISIBILITY

- **命名空间:** `OBJECT`
- **Hash:** `0xB252BC036B525623`
- **JHash:** `0x46D06B9A`
- **Build:** `323`

**C# 签名:**
```csharp
void TRACK_OBJECT_VISIBILITY(int object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### WOULD_ENTITY_BE_OCCLUDED

- **命名空间:** `ENTITY`
- **Hash:** `0xEE5D2A122E09EC42`
- **JHash:** `0xEA127CBC`
- **Build:** `323`

**C# 签名:**
```csharp
bool WOULD_ENTITY_BE_OCCLUDED(uint entityModelHash, float x, float y, float z, bool p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entityModelHash` | `Hash` | `uint` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p4` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### _GET_LAST_ENTITY_HIT_BY_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0xA75EE4F689B85391`
- **Build:** `2802`

**C# 签名:**
```csharp
int _GET_LAST_ENTITY_HIT_BY_ENTITY(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `int` (Native: `Entity`)

---

### _SET_ENTITY_NO_COLLISION_WITH_NETWORKED_ENTITY

- **命名空间:** `ENTITY`
- **Hash:** `0x0A27A7827347B3B1`
- **Build:** `3407`

**C# 签名:**
```csharp
void _SET_ENTITY_NO_COLLISION_WITH_NETWORKED_ENTITY(int entity1, int entity2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity1` | `Entity` | `int` | - |
| `entity2` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### _SET_OBJECT_TARGETTABLE_BY_PLAYER

- **命名空间:** `OBJECT`
- **Hash:** `0xB39F03368DB0CAA2`
- **Build:** `3258`

**C# 签名:**
```csharp
void _SET_OBJECT_TARGETTABLE_BY_PLAYER(int object, bool setFlag34, bool setFlag35)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `setFlag34` | `BOOL` | `bool` | - |
| `setFlag35` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the 34th and 35th object flags related to player peds.
```

---

### _SET_PICKUP_GLOW_DISABLED

- **命名空间:** `OBJECT`
- **Hash:** `0x08BD8BA5BDE2C2FA`
- **Build:** `3407`

**C# 签名:**
```csharp
void _SET_PICKUP_GLOW_DISABLED(int pickup, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---
