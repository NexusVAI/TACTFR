# GTA5 Native API 快速参考表

> 按功能分类的 Native 函数速查表

---

## PED

| 函数名 | 签名 | 返回值 |
|--------|------|--------|
| `ADD_ARMOUR_TO_PED` | `void ADD_ARMOUR_TO_PED(int ped, int amount)` | void |
| `ADD_PED_DECORATION_FROM_HASHES` | `void ADD_PED_DECORATION_FROM_HASHES(int ped, uint collection, uint overlay)` | void |
| `ADD_PED_DECORATION_FROM_HASHES_IN_CORONA` | `void ADD_PED_DECORATION_FROM_HASHES_IN_CORONA(int ped, uint collection, uint overlay)` | void |
| `ADD_RELATIONSHIP_GROUP` | `bool ADD_RELATIONSHIP_GROUP(string name, Hash* groupHash)` | bool |
| `ADD_SCENARIO_BLOCKING_AREA` | `int ADD_SCENARIO_BLOCKING_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool p6, bool p7, bool p8, bool p9, object p10)` | int |
| `APPLY_DAMAGE_TO_PED` | `void APPLY_DAMAGE_TO_PED(int ped, int damageAmount, bool p2, object p3, uint weaponType)` | void |
| `APPLY_PED_BLOOD` | `void APPLY_PED_BLOOD(int ped, int boneIndex, float xRot, float yRot, float zRot, string woundType)` | void |
| `APPLY_PED_BLOOD_BY_ZONE` | `void APPLY_PED_BLOOD_BY_ZONE(int ped, int p1, float p2, float p3, string p4)` | void |
| `APPLY_PED_BLOOD_DAMAGE_BY_ZONE` | `void APPLY_PED_BLOOD_DAMAGE_BY_ZONE(int ped, object p1, float p2, float p3, object p4)` | void |
| `APPLY_PED_BLOOD_SPECIFIC` | `void APPLY_PED_BLOOD_SPECIFIC(int ped, int p1, float p2, float p3, float p4, float p5, int p6, float p7, string p8)` | void |
| `APPLY_PED_DAMAGE_DECAL` | `void APPLY_PED_DAMAGE_DECAL(int ped, int damageZone, float xOffset, float yOffset, float heading, float scale, float alpha, int variation, bool fadeIn, string decalName)` | void |
| `APPLY_PED_DAMAGE_PACK` | `void APPLY_PED_DAMAGE_PACK(int ped, string damagePack, float damage, float mult)` | void |
| `ATTACH_SYNCHRONIZED_SCENE_TO_ENTITY` | `void ATTACH_SYNCHRONIZED_SCENE_TO_ENTITY(int sceneID, int entity, int boneIndex)` | void |
| `BLOCK_PED_FROM_GENERATING_DEAD_BODY_EVENTS_WHEN_DEAD` | `void BLOCK_PED_FROM_GENERATING_DEAD_BODY_EVENTS_WHEN_DEAD(int ped, bool toggle)` | void |
| `CAN_CREATE_RANDOM_BIKE_RIDER` | `bool CAN_CREATE_RANDOM_BIKE_RIDER()` | bool |
| `CAN_CREATE_RANDOM_COPS` | `bool CAN_CREATE_RANDOM_COPS()` | bool |
| `CAN_CREATE_RANDOM_DRIVER` | `bool CAN_CREATE_RANDOM_DRIVER()` | bool |
| `CAN_CREATE_RANDOM_PED` | `bool CAN_CREATE_RANDOM_PED(bool p0)` | bool |
| `CAN_KNOCK_PED_OFF_VEHICLE` | `bool CAN_KNOCK_PED_OFF_VEHICLE(int ped)` | bool |
| `CAN_PED_IN_COMBAT_SEE_TARGET` | `bool CAN_PED_IN_COMBAT_SEE_TARGET(int ped, int target)` | bool |
| `CAN_PED_RAGDOLL` | `bool CAN_PED_RAGDOLL(int ped)` | bool |
| `CAN_PED_SEE_HATED_PED` | `bool CAN_PED_SEE_HATED_PED(int ped1, int ped2)` | bool |
| `CAN_PED_SHUFFLE_TO_OR_FROM_EXTRA_SEAT` | `bool CAN_PED_SHUFFLE_TO_OR_FROM_EXTRA_SEAT(int ped, ref int p1)` | bool |
| `CAN_PED_SHUFFLE_TO_OR_FROM_TURRET_SEAT` | `bool CAN_PED_SHUFFLE_TO_OR_FROM_TURRET_SEAT(int ped, ref int p1)` | bool |
| `CLEAR_ALL_PED_PROPS` | `void CLEAR_ALL_PED_PROPS(int ped, object p1)` | void |
| `CLEAR_ALL_PED_VEHICLE_FORCED_SEAT_USAGE` | `void CLEAR_ALL_PED_VEHICLE_FORCED_SEAT_USAGE(int ped)` | void |
| `CLEAR_COVER_POINT_FOR_PED` | `void CLEAR_COVER_POINT_FOR_PED(int ped)` | void |
| `CLEAR_FACIAL_IDLE_ANIM_OVERRIDE` | `void CLEAR_FACIAL_IDLE_ANIM_OVERRIDE(int ped)` | void |
| `CLEAR_PED_ALTERNATE_MOVEMENT_ANIM` | `void CLEAR_PED_ALTERNATE_MOVEMENT_ANIM(int ped, int stance, float p2)` | void |
| `CLEAR_PED_ALTERNATE_WALK_ANIM` | `void CLEAR_PED_ALTERNATE_WALK_ANIM(int ped, float p1)` | void |
| `CLEAR_PED_BLOOD_DAMAGE` | `void CLEAR_PED_BLOOD_DAMAGE(int ped)` | void |
| `CLEAR_PED_BLOOD_DAMAGE_BY_ZONE` | `void CLEAR_PED_BLOOD_DAMAGE_BY_ZONE(int ped, int p1)` | void |
| `CLEAR_PED_DAMAGE_DECAL_BY_ZONE` | `void CLEAR_PED_DAMAGE_DECAL_BY_ZONE(int ped, int p1, string p2)` | void |
| `CLEAR_PED_DECORATIONS` | `void CLEAR_PED_DECORATIONS(int ped)` | void |
| `CLEAR_PED_DECORATIONS_LEAVE_SCARS` | `void CLEAR_PED_DECORATIONS_LEAVE_SCARS(int ped)` | void |
| `CLEAR_PED_DRIVE_BY_CLIPSET_OVERRIDE` | `void CLEAR_PED_DRIVE_BY_CLIPSET_OVERRIDE(int ped)` | void |
| `CLEAR_PED_ENV_DIRT` | `void CLEAR_PED_ENV_DIRT(int ped)` | void |
| `CLEAR_PED_FALL_UPPER_BODY_CLIPSET_OVERRIDE` | `void CLEAR_PED_FALL_UPPER_BODY_CLIPSET_OVERRIDE(int ped)` | void |
| `CLEAR_PED_LAST_DAMAGE_BONE` | `void CLEAR_PED_LAST_DAMAGE_BONE(int ped)` | void |
| `CLEAR_PED_MOTION_IN_COVER_CLIPSET_OVERRIDE` | `void CLEAR_PED_MOTION_IN_COVER_CLIPSET_OVERRIDE(int ped)` | void |
| `CLEAR_PED_NON_CREATION_AREA` | `void CLEAR_PED_NON_CREATION_AREA()` | void |
| `CLEAR_PED_PARACHUTE_PACK_VARIATION` | `void CLEAR_PED_PARACHUTE_PACK_VARIATION(int ped)` | void |
| `CLEAR_PED_PROP` | `void CLEAR_PED_PROP(int ped, int propId, object p2)` | void |
| `CLEAR_PED_SCUBA_GEAR_VARIATION` | `void CLEAR_PED_SCUBA_GEAR_VARIATION(int ped)` | void |
| `CLEAR_PED_STORED_HAT_PROP` | `void CLEAR_PED_STORED_HAT_PROP(int ped)` | void |
| `CLEAR_PED_WETNESS` | `void CLEAR_PED_WETNESS(int ped)` | void |
| `CLEAR_RAGDOLL_BLOCKING_FLAGS` | `void CLEAR_RAGDOLL_BLOCKING_FLAGS(int ped, int blockingFlag)` | void |
| `CLEAR_RELATIONSHIP_BETWEEN_GROUPS` | `void CLEAR_RELATIONSHIP_BETWEEN_GROUPS(int relationship, uint group1, uint group2)` | void |
| `CLONE_PED` | `int CLONE_PED(int ped, bool isNetwork, bool bScriptHostPed, bool copyHeadBlendFlag)` | int |
| `CLONE_PED_ALT` | `int CLONE_PED_ALT(int ped, bool isNetwork, bool bScriptHostPed, bool copyHeadBlendFlag, bool p4)` | int |
| `CLONE_PED_TO_TARGET` | `void CLONE_PED_TO_TARGET(int ped, int targetPed)` | void |
| `CLONE_PED_TO_TARGET_ALT` | `void CLONE_PED_TO_TARGET_ALT(int ped, int targetPed, bool p2)` | void |
| `COUNT_PEDS_IN_COMBAT_WITH_TARGET` | `int COUNT_PEDS_IN_COMBAT_WITH_TARGET(int ped)` | int |
| `COUNT_PEDS_IN_COMBAT_WITH_TARGET_WITHIN_RADIUS` | `int COUNT_PEDS_IN_COMBAT_WITH_TARGET_WITHIN_RADIUS(int ped, float x, float y, float z, float radius)` | int |
| `CREATE_GROUP` | `int CREATE_GROUP(int unused)` | int |
| `CREATE_NM_MESSAGE` | `void CREATE_NM_MESSAGE(bool startImmediately, int messageId)` | void |
| `CREATE_PARACHUTE_BAG_OBJECT` | `int CREATE_PARACHUTE_BAG_OBJECT(int ped, bool p1, bool p2)` | int |
| `CREATE_PED` | `int CREATE_PED(int pedType, uint modelHash, float x, float y, float z, float heading, bool isNetwork, bool bScriptHostPed)` | int |
| `CREATE_PED_INSIDE_VEHICLE` | `int CREATE_PED_INSIDE_VEHICLE(int vehicle, int pedType, uint modelHash, int seat, bool isNetwork, bool bScriptHostPed)` | int |
| `CREATE_RANDOM_PED` | `int CREATE_RANDOM_PED(float posX, float posY, float posZ)` | int |
| `CREATE_RANDOM_PED_AS_DRIVER` | `int CREATE_RANDOM_PED_AS_DRIVER(int vehicle, bool returnHandle)` | int |
| `CREATE_SYNCHRONIZED_SCENE` | `int CREATE_SYNCHRONIZED_SCENE(float x, float y, float z, float roll, float pitch, float yaw, int p6)` | int |
| `CREATE_SYNCHRONIZED_SCENE_AT_MAP_OBJECT` | `int CREATE_SYNCHRONIZED_SCENE_AT_MAP_OBJECT(float x, float y, float z, float radius, uint object)` | int |
| `DELETE_PED` | `void DELETE_PED(Ped* ped)` | void |
| `DETACH_SYNCHRONIZED_SCENE` | `void DETACH_SYNCHRONIZED_SCENE(int sceneID)` | void |
| `DISABLE_HEAD_BLEND_PALETTE_COLOR` | `void DISABLE_HEAD_BLEND_PALETTE_COLOR(int ped)` | void |
| `DISABLE_PED_HEATSCALE_OVERRIDE` | `void DISABLE_PED_HEATSCALE_OVERRIDE(int ped)` | void |
| `DISABLE_PED_INJURED_ON_GROUND_BEHAVIOUR` | `void DISABLE_PED_INJURED_ON_GROUND_BEHAVIOUR(int ped)` | void |
| `DOES_GROUP_EXIST` | `bool DOES_GROUP_EXIST(int groupId)` | bool |
| `DOES_RELATIONSHIP_GROUP_EXIST` | `bool DOES_RELATIONSHIP_GROUP_EXIST(uint groupHash)` | bool |
| `DOES_SCENARIO_BLOCKING_AREA_EXISTS` | `bool DOES_SCENARIO_BLOCKING_AREA_EXISTS(float x1, float y1, float z1, float x2, float y2, float z2)` | bool |
| `DROP_AMBIENT_PROP` | `void DROP_AMBIENT_PROP(int ped)` | void |
| `ENABLE_MP_LIGHT` | `void ENABLE_MP_LIGHT(int ped, bool toggle)` | void |
| `EXPLODE_PED_HEAD` | `void EXPLODE_PED_HEAD(int ped, uint weaponHash)` | void |
| `FINALIZE_HEAD_BLEND` | `void FINALIZE_HEAD_BLEND(int ped)` | void |
| `FORCE_ALL_HEADING_VALUES_TO_ALIGN` | `void FORCE_ALL_HEADING_VALUES_TO_ALIGN(int ped)` | void |
| `FORCE_INSTANT_LEG_IK_SETUP` | `void FORCE_INSTANT_LEG_IK_SETUP(int ped)` | void |
| `FORCE_PED_AI_AND_ANIMATION_UPDATE` | `void FORCE_PED_AI_AND_ANIMATION_UPDATE(int ped, bool p1, bool p2)` | void |
| `FORCE_PED_MOTION_STATE` | `bool FORCE_PED_MOTION_STATE(int ped, uint motionStateHash, bool p2, int p3, bool p4)` | bool |
| `FORCE_PED_TO_OPEN_PARACHUTE` | `void FORCE_PED_TO_OPEN_PARACHUTE(int ped)` | void |
| `FORCE_ZERO_MASS_IN_COLLISIONS` | `void FORCE_ZERO_MASS_IN_COLLISIONS(int ped)` | void |
| `GET_ANIM_INITIAL_OFFSET_POSITION` | `Vector3 GET_ANIM_INITIAL_OFFSET_POSITION(string animDict, string animName, float x, float y, float z, float xRot, float yRot, float zRot, float p8, int p9)` | Vector3 |
| `GET_ANIM_INITIAL_OFFSET_ROTATION` | `Vector3 GET_ANIM_INITIAL_OFFSET_ROTATION(string animDict, string animName, float x, float y, float z, float xRot, float yRot, float zRot, float p8, int p9)` | Vector3 |
| `GET_CAN_PED_BE_GRABBED_BY_SCRIPT` | `bool GET_CAN_PED_BE_GRABBED_BY_SCRIPT(int ped, bool p1, bool p2, bool p3, bool p4, bool p5, bool p6, bool p7, object p8)` | bool |
| `GET_CLOSEST_PED` | `bool GET_CLOSEST_PED(float x, float y, float z, float radius, bool p4, bool p5, Ped* outPed, bool p7, bool p8, int pedType)` | bool |
| `GET_COMBAT_FLOAT` | `float GET_COMBAT_FLOAT(int ped, int p1)` | float |
| `GET_DEAD_PED_PICKUP_COORDS` | `Vector3 GET_DEAD_PED_PICKUP_COORDS(int ped, float p1, float p2)` | Vector3 |
| `GET_DEFAULT_SECONDARY_TINT_FOR_BARBER` | `int GET_DEFAULT_SECONDARY_TINT_FOR_BARBER(int colorID)` | int |
| `GET_DEFAULT_SECONDARY_TINT_FOR_CREATOR` | `int GET_DEFAULT_SECONDARY_TINT_FOR_CREATOR(int colorId)` | int |
| `GET_FM_FEMALE_SHOP_PED_APPAREL_ITEM_INDEX` | `int GET_FM_FEMALE_SHOP_PED_APPAREL_ITEM_INDEX(int p0)` | int |
| `GET_FM_MALE_SHOP_PED_APPAREL_ITEM_INDEX` | `int GET_FM_MALE_SHOP_PED_APPAREL_ITEM_INDEX(int p0)` | int |
| `GET_GROUP_SIZE` | `void GET_GROUP_SIZE(int groupID, ref object p1, ref int sizeInMembers)` | void |
| `GET_HEAD_BLEND_EYE_COLOR` | `int GET_HEAD_BLEND_EYE_COLOR(int ped)` | int |
| `GET_JACK_TARGET` | `int GET_JACK_TARGET(int ped)` | int |
| `GET_MELEE_TARGET_FOR_PED` | `int GET_MELEE_TARGET_FOR_PED(int ped)` | int |
| `GET_MOUNT` | `int GET_MOUNT(int ped)` | int |
| `GET_MP_LIGHT_ENABLED` | `bool GET_MP_LIGHT_ENABLED(int ped)` | bool |
| `GET_MP_OUTFIT_DATA_FROM_METADATA` | `bool GET_MP_OUTFIT_DATA_FROM_METADATA(ref object p0, ref object p1)` | bool |
| `GET_NUMBER_OF_PED_DRAWABLE_VARIATIONS` | `int GET_NUMBER_OF_PED_DRAWABLE_VARIATIONS(int ped, int componentId)` | int |
| `GET_NUMBER_OF_PED_PROP_DRAWABLE_VARIATIONS` | `int GET_NUMBER_OF_PED_PROP_DRAWABLE_VARIATIONS(int ped, int propId)` | int |
| `GET_NUMBER_OF_PED_PROP_TEXTURE_VARIATIONS` | `int GET_NUMBER_OF_PED_PROP_TEXTURE_VARIATIONS(int ped, int propId, int drawableId)` | int |
| `GET_NUMBER_OF_PED_TEXTURE_VARIATIONS` | `int GET_NUMBER_OF_PED_TEXTURE_VARIATIONS(int ped, int componentId, int drawableId)` | int |
| `GET_NUM_PED_HAIR_TINTS` | `int GET_NUM_PED_HAIR_TINTS()` | int |
| `GET_NUM_PED_MAKEUP_TINTS` | `int GET_NUM_PED_MAKEUP_TINTS()` | int |
| `GET_PEDHEADSHOT_TXD_STRING` | `string GET_PEDHEADSHOT_TXD_STRING(int id)` | string |
| `GET_PEDS_JACKER` | `int GET_PEDS_JACKER(int ped)` | int |
| `GET_PED_ACCURACY` | `int GET_PED_ACCURACY(int ped)` | int |
| `GET_PED_ALERTNESS` | `int GET_PED_ALERTNESS(int ped)` | int |
| `GET_PED_ARMOUR` | `int GET_PED_ARMOUR(int ped)` | int |
| `GET_PED_AS_GROUP_LEADER` | `int GET_PED_AS_GROUP_LEADER(int groupID)` | int |
| `GET_PED_AS_GROUP_MEMBER` | `int GET_PED_AS_GROUP_MEMBER(int groupID, int memberNumber)` | int |
| `GET_PED_BONE_COORDS` | `Vector3 GET_PED_BONE_COORDS(int ped, int boneId, float offsetX, float offsetY, float offsetZ)` | Vector3 |
| `GET_PED_BONE_INDEX` | `int GET_PED_BONE_INDEX(int ped, int boneId)` | int |
| `GET_PED_CAUSE_OF_DEATH` | `uint GET_PED_CAUSE_OF_DEATH(int ped)` | uint |
| `GET_PED_COMBAT_MOVEMENT` | `int GET_PED_COMBAT_MOVEMENT(int ped)` | int |
| `GET_PED_COMBAT_RANGE` | `int GET_PED_COMBAT_RANGE(int ped)` | int |
| `GET_PED_CONFIG_FLAG` | `bool GET_PED_CONFIG_FLAG(int ped, int flagId, bool p2)` | bool |
| `GET_PED_CURRENT_MOVE_BLEND_RATIO` | `bool GET_PED_CURRENT_MOVE_BLEND_RATIO(int ped, ref float speedX, ref float speedY)` | bool |
| `GET_PED_DECORATIONS_STATE` | `int GET_PED_DECORATIONS_STATE(int ped)` | int |
| `GET_PED_DECORATION_ZONE_FROM_HASHES` | `int GET_PED_DECORATION_ZONE_FROM_HASHES(uint collection, uint overlay)` | int |
| `GET_PED_DEFENSIVE_AREA_POSITION` | `Vector3 GET_PED_DEFENSIVE_AREA_POSITION(int ped, bool p1)` | Vector3 |
| `GET_PED_DIES_IN_WATER` | `bool GET_PED_DIES_IN_WATER(int ped)` | bool |
| `GET_PED_DRAWABLE_VARIATION` | `int GET_PED_DRAWABLE_VARIATION(int ped, int componentId)` | int |
| `GET_PED_EMISSIVE_SCALE` | `float GET_PED_EMISSIVE_SCALE(int ped)` | float |
| `GET_PED_ENVEFF_SCALE` | `float GET_PED_ENVEFF_SCALE(int ped)` | float |
| `GET_PED_EXTRACTED_DISPLACEMENT` | `Vector3 GET_PED_EXTRACTED_DISPLACEMENT(int ped, bool worldSpace)` | Vector3 |
| `GET_PED_GROUP_INDEX` | `int GET_PED_GROUP_INDEX(int ped)` | int |
| `GET_PED_HAIR_TINT_COLOR` | `void GET_PED_HAIR_TINT_COLOR(int hairColorIndex, ref int outR, ref int outG, ref int outB)` | void |
| `GET_PED_HEAD_BLEND_DATA` | `bool GET_PED_HEAD_BLEND_DATA(int ped, ref object headBlendData)` | bool |
| `GET_PED_HEAD_BLEND_FIRST_INDEX` | `int GET_PED_HEAD_BLEND_FIRST_INDEX(int type)` | int |
| `GET_PED_HEAD_BLEND_NUM_HEADS` | `int GET_PED_HEAD_BLEND_NUM_HEADS(int type)` | int |
| `GET_PED_HEAD_OVERLAY` | `int GET_PED_HEAD_OVERLAY(int ped, int overlayID)` | int |
| `GET_PED_HEAD_OVERLAY_NUM` | `int GET_PED_HEAD_OVERLAY_NUM(int overlayID)` | int |
| `GET_PED_HELMET_STORED_HAT_PROP_INDEX` | `int GET_PED_HELMET_STORED_HAT_PROP_INDEX(int ped)` | int |
| `GET_PED_HELMET_STORED_HAT_TEX_INDEX` | `int GET_PED_HELMET_STORED_HAT_TEX_INDEX(int ped)` | int |
| `GET_PED_LAST_DAMAGE_BONE` | `bool GET_PED_LAST_DAMAGE_BONE(int ped, ref int outBone)` | bool |
| `GET_PED_MAKEUP_TINT_COLOR` | `void GET_PED_MAKEUP_TINT_COLOR(int makeupColorIndex, ref int outR, ref int outG, ref int outB)` | void |
| `GET_PED_MAX_HEALTH` | `int GET_PED_MAX_HEALTH(int ped)` | int |
| `GET_PED_MONEY` | `int GET_PED_MONEY(int ped)` | int |
| `GET_PED_NEARBY_PEDS` | `int GET_PED_NEARBY_PEDS(int ped, ref object sizeAndPeds, int ignore)` | int |
| `GET_PED_NEARBY_VEHICLES` | `int GET_PED_NEARBY_VEHICLES(int ped, ref object sizeAndVehs)` | int |
| `GET_PED_PALETTE_VARIATION` | `int GET_PED_PALETTE_VARIATION(int ped, int componentId)` | int |
| `GET_PED_PARACHUTE_LANDING_TYPE` | `int GET_PED_PARACHUTE_LANDING_TYPE(int ped)` | int |
| `GET_PED_PARACHUTE_STATE` | `int GET_PED_PARACHUTE_STATE(int ped)` | int |
| `GET_PED_PARACHUTE_TINT_INDEX` | `void GET_PED_PARACHUTE_TINT_INDEX(int ped, ref int outTintIndex)` | void |
| `GET_PED_PROP_INDEX` | `int GET_PED_PROP_INDEX(int ped, int componentId, object p2)` | int |
| `GET_PED_PROP_TEXTURE_INDEX` | `int GET_PED_PROP_TEXTURE_INDEX(int ped, int componentId)` | int |
| `GET_PED_RAGDOLL_BONE_INDEX` | `int GET_PED_RAGDOLL_BONE_INDEX(int ped, int bone)` | int |
| `GET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH` | `uint GET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH(int ped)` | uint |
| `GET_PED_RELATIONSHIP_GROUP_HASH` | `uint GET_PED_RELATIONSHIP_GROUP_HASH(int ped)` | uint |
| `GET_PED_RESET_FLAG` | `bool GET_PED_RESET_FLAG(int ped, int flagId)` | bool |
| `GET_PED_SOURCE_OF_DEATH` | `int GET_PED_SOURCE_OF_DEATH(int ped)` | int |
| `GET_PED_STEALTH_MOVEMENT` | `bool GET_PED_STEALTH_MOVEMENT(int ped)` | bool |
| `GET_PED_TARGET_FROM_COMBAT_PED` | `int GET_PED_TARGET_FROM_COMBAT_PED(int ped, object p1)` | int |
| `GET_PED_TEXTURE_VARIATION` | `int GET_PED_TEXTURE_VARIATION(int ped, int componentId)` | int |
| `GET_PED_TIME_OF_DEATH` | `int GET_PED_TIME_OF_DEATH(int ped)` | int |
| `GET_PED_TYPE` | `int GET_PED_TYPE(int ped)` | int |
| `GET_PED_VISUAL_FIELD_CENTER_ANGLE` | `float GET_PED_VISUAL_FIELD_CENTER_ANGLE(int ped)` | float |
| `GET_PLAYER_PED_IS_FOLLOWING` | `int GET_PLAYER_PED_IS_FOLLOWING(int ped)` | int |
| `GET_POS_FROM_FIRED_EVENT` | `bool GET_POS_FROM_FIRED_EVENT(int ped, int eventType, ref object outData)` | bool |
| `GET_RANDOM_PED_AT_COORD` | `int GET_RANDOM_PED_AT_COORD(float x, float y, float z, float xRadius, float yRadius, float zRadius, int pedType)` | int |
| `GET_RELATIONSHIP_BETWEEN_GROUPS` | `int GET_RELATIONSHIP_BETWEEN_GROUPS(uint group1, uint group2)` | int |
| `GET_RELATIONSHIP_BETWEEN_PEDS` | `int GET_RELATIONSHIP_BETWEEN_PEDS(int ped1, int ped2)` | int |
| `GET_SEAT_PED_IS_TRYING_TO_ENTER` | `int GET_SEAT_PED_IS_TRYING_TO_ENTER(int ped)` | int |
| `GET_SYNCHRONIZED_SCENE_PHASE` | `float GET_SYNCHRONIZED_SCENE_PHASE(int sceneID)` | float |
| `GET_SYNCHRONIZED_SCENE_RATE` | `float GET_SYNCHRONIZED_SCENE_RATE(int sceneID)` | float |
| `GET_TIME_PED_DAMAGED_BY_WEAPON` | `int GET_TIME_PED_DAMAGED_BY_WEAPON(int ped, uint weaponHash)` | int |
| `GET_TINT_INDEX_FOR_LAST_GEN_HAIR_TEXTURE` | `int GET_TINT_INDEX_FOR_LAST_GEN_HAIR_TEXTURE(uint modelHash, int drawableId, int textureId)` | int |
| `GET_TRACKED_PED_PIXELCOUNT` | `int GET_TRACKED_PED_PIXELCOUNT(int ped)` | int |
| `GET_VEHICLE_PED_IS_ENTERING` | `int GET_VEHICLE_PED_IS_ENTERING(int ped)` | int |
| `GET_VEHICLE_PED_IS_IN` | `int GET_VEHICLE_PED_IS_IN(int ped, bool includeEntering)` | int |
| `GET_VEHICLE_PED_IS_TRYING_TO_ENTER` | `int GET_VEHICLE_PED_IS_TRYING_TO_ENTER(int ped)` | int |
| `GET_VEHICLE_PED_IS_USING` | `int GET_VEHICLE_PED_IS_USING(int ped)` | int |
| `GIVE_PED_HELMET` | `void GIVE_PED_HELMET(int ped, bool cannotRemove, int helmetFlag, int textureIndex)` | void |
| `GIVE_PED_NM_MESSAGE` | `void GIVE_PED_NM_MESSAGE(int ped)` | void |
| `HAS_ACTION_MODE_ASSET_LOADED` | `bool HAS_ACTION_MODE_ASSET_LOADED(string asset)` | bool |
| `HAS_PEDHEADSHOT_IMG_UPLOAD_FAILED` | `bool HAS_PEDHEADSHOT_IMG_UPLOAD_FAILED()` | bool |
| `HAS_PEDHEADSHOT_IMG_UPLOAD_SUCCEEDED` | `bool HAS_PEDHEADSHOT_IMG_UPLOAD_SUCCEEDED()` | bool |
| `HAS_PED_HEAD_BLEND_FINISHED` | `bool HAS_PED_HEAD_BLEND_FINISHED(int ped)` | bool |
| `HAS_PED_PRELOAD_PROP_DATA_FINISHED` | `bool HAS_PED_PRELOAD_PROP_DATA_FINISHED(int ped)` | bool |
| `HAS_PED_PRELOAD_VARIATION_DATA_FINISHED` | `bool HAS_PED_PRELOAD_VARIATION_DATA_FINISHED(int ped)` | bool |
| `HAS_PED_RECEIVED_EVENT` | `bool HAS_PED_RECEIVED_EVENT(int ped, int eventId)` | bool |
| `HAS_STEALTH_MODE_ASSET_LOADED` | `bool HAS_STEALTH_MODE_ASSET_LOADED(string asset)` | bool |
| `HAVE_ALL_STREAMING_REQUESTS_COMPLETED` | `bool HAVE_ALL_STREAMING_REQUESTS_COMPLETED(int ped)` | bool |
| `HIDE_PED_BLOOD_DAMAGE_BY_ZONE` | `void HIDE_PED_BLOOD_DAMAGE_BY_ZONE(int ped, object p1, bool p2)` | void |
| `INSTANTLY_FILL_PED_POPULATION` | `void INSTANTLY_FILL_PED_POPULATION()` | void |
| `IS_ANY_HOSTILE_PED_NEAR_POINT` | `bool IS_ANY_HOSTILE_PED_NEAR_POINT(int ped, float x, float y, float z, float radius)` | bool |
| `IS_ANY_PED_NEAR_POINT` | `bool IS_ANY_PED_NEAR_POINT(float x, float y, float z, float radius)` | bool |
| `IS_ANY_PED_SHOOTING_IN_AREA` | `bool IS_ANY_PED_SHOOTING_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool p6, bool p7)` | bool |
| `IS_CONVERSATION_PED_DEAD` | `bool IS_CONVERSATION_PED_DEAD(int ped)` | bool |
| `IS_COP_PED_IN_AREA_3D` | `bool IS_COP_PED_IN_AREA_3D(float x1, float y1, float z1, float x2, float y2, float z2)` | bool |
| `IS_CURRENT_HEAD_PROP_A_HELMET` | `bool IS_CURRENT_HEAD_PROP_A_HELMET(object p0)` | bool |
| `IS_MOBILE_PHONE_TO_PED_EAR` | `bool IS_MOBILE_PHONE_TO_PED_EAR(int ped)` | bool |
| `IS_PEDHEADSHOT_IMG_UPLOAD_AVAILABLE` | `bool IS_PEDHEADSHOT_IMG_UPLOAD_AVAILABLE()` | bool |
| `IS_PEDHEADSHOT_READY` | `bool IS_PEDHEADSHOT_READY(int id)` | bool |
| `IS_PEDHEADSHOT_VALID` | `bool IS_PEDHEADSHOT_VALID(int id)` | bool |
| `IS_PED_AIMING_FROM_COVER` | `bool IS_PED_AIMING_FROM_COVER(int ped)` | bool |
| `IS_PED_A_PLAYER` | `bool IS_PED_A_PLAYER(int ped)` | bool |
| `IS_PED_BEING_JACKED` | `bool IS_PED_BEING_JACKED(int ped)` | bool |
| `IS_PED_BEING_STEALTH_KILLED` | `bool IS_PED_BEING_STEALTH_KILLED(int ped)` | bool |
| `IS_PED_BEING_STUNNED` | `bool IS_PED_BEING_STUNNED(int ped, int p1)` | bool |
| `IS_PED_BLUSH_FACEPAINT_TINT_FOR_BARBER` | `bool IS_PED_BLUSH_FACEPAINT_TINT_FOR_BARBER(int colorId)` | bool |
| `IS_PED_BLUSH_TINT_FOR_BARBER` | `bool IS_PED_BLUSH_TINT_FOR_BARBER(int colorID)` | bool |
| `IS_PED_BLUSH_TINT_FOR_CREATOR` | `bool IS_PED_BLUSH_TINT_FOR_CREATOR(int colorId)` | bool |
| `IS_PED_CLIMBING` | `bool IS_PED_CLIMBING(int ped)` | bool |
| `IS_PED_COMPONENT_VARIATION_VALID` | `bool IS_PED_COMPONENT_VARIATION_VALID(int ped, int componentId, int drawableId, int textureId)` | bool |
| `IS_PED_DEAD_OR_DYING` | `bool IS_PED_DEAD_OR_DYING(int ped, bool p1)` | bool |
| `IS_PED_DEFENSIVE_AREA_ACTIVE` | `bool IS_PED_DEFENSIVE_AREA_ACTIVE(int ped, bool p1)` | bool |
| `IS_PED_DIVING` | `bool IS_PED_DIVING(int ped)` | bool |
| `IS_PED_DOING_A_BEAST_JUMP` | `bool IS_PED_DOING_A_BEAST_JUMP(object p0)` | bool |
| `IS_PED_DOING_DRIVEBY` | `bool IS_PED_DOING_DRIVEBY(int ped)` | bool |
| `IS_PED_DUCKING` | `bool IS_PED_DUCKING(int ped)` | bool |
| `IS_PED_EVASIVE_DIVING` | `bool IS_PED_EVASIVE_DIVING(int ped, Entity* evadingEntity)` | bool |
| `IS_PED_FACING_PED` | `bool IS_PED_FACING_PED(int ped, int otherPed, float angle)` | bool |
| `IS_PED_FALLING` | `bool IS_PED_FALLING(int ped)` | bool |
| `IS_PED_FATALLY_INJURED` | `bool IS_PED_FATALLY_INJURED(int ped)` | bool |
| `IS_PED_FLEEING` | `bool IS_PED_FLEEING(int ped)` | bool |
| `IS_PED_GESTURING` | `bool IS_PED_GESTURING(object p0)` | bool |
| `IS_PED_GETTING_INTO_A_VEHICLE` | `bool IS_PED_GETTING_INTO_A_VEHICLE(int ped)` | bool |
| `IS_PED_GOING_INTO_COVER` | `bool IS_PED_GOING_INTO_COVER(int ped)` | bool |
| `IS_PED_GROUP_MEMBER` | `bool IS_PED_GROUP_MEMBER(int ped, int groupId)` | bool |
| `IS_PED_HAIR_TINT_FOR_BARBER` | `bool IS_PED_HAIR_TINT_FOR_BARBER(int colorID)` | bool |
| `IS_PED_HAIR_TINT_FOR_CREATOR` | `bool IS_PED_HAIR_TINT_FOR_CREATOR(int colorId)` | bool |
| `IS_PED_HANGING_ON_TO_VEHICLE` | `bool IS_PED_HANGING_ON_TO_VEHICLE(int ped)` | bool |
| `IS_PED_HEADING_TOWARDS_POSITION` | `bool IS_PED_HEADING_TOWARDS_POSITION(int ped, float x, float y, float z, float p4)` | bool |
| `IS_PED_HEADTRACKING_ENTITY` | `bool IS_PED_HEADTRACKING_ENTITY(int ped, int entity)` | bool |
| `IS_PED_HEADTRACKING_PED` | `bool IS_PED_HEADTRACKING_PED(int ped1, int ped2)` | bool |
| `IS_PED_HELMET_VISOR_UP` | `bool IS_PED_HELMET_VISOR_UP(int ped)` | bool |
| `IS_PED_HUMAN` | `bool IS_PED_HUMAN(int ped)` | bool |
| `IS_PED_HURT` | `bool IS_PED_HURT(int ped)` | bool |
| `IS_PED_INJURED` | `bool IS_PED_INJURED(int ped)` | bool |
| `IS_PED_IN_ANY_BOAT` | `bool IS_PED_IN_ANY_BOAT(int ped)` | bool |
| `IS_PED_IN_ANY_HELI` | `bool IS_PED_IN_ANY_HELI(int ped)` | bool |
| `IS_PED_IN_ANY_PLANE` | `bool IS_PED_IN_ANY_PLANE(int ped)` | bool |
| `IS_PED_IN_ANY_POLICE_VEHICLE` | `bool IS_PED_IN_ANY_POLICE_VEHICLE(int ped)` | bool |
| `IS_PED_IN_ANY_SUB` | `bool IS_PED_IN_ANY_SUB(int ped)` | bool |
| `IS_PED_IN_ANY_TAXI` | `bool IS_PED_IN_ANY_TAXI(int ped)` | bool |
| `IS_PED_IN_ANY_TRAIN` | `bool IS_PED_IN_ANY_TRAIN(int ped)` | bool |
| `IS_PED_IN_ANY_VEHICLE` | `bool IS_PED_IN_ANY_VEHICLE(int ped, bool atGetIn)` | bool |
| `IS_PED_IN_COMBAT` | `bool IS_PED_IN_COMBAT(int ped, int target)` | bool |
| `IS_PED_IN_COVER` | `bool IS_PED_IN_COVER(int ped, bool exceptUseWeapon)` | bool |
| `IS_PED_IN_COVER_FACING_LEFT` | `bool IS_PED_IN_COVER_FACING_LEFT(int ped)` | bool |
| `IS_PED_IN_FLYING_VEHICLE` | `bool IS_PED_IN_FLYING_VEHICLE(int ped)` | bool |
| `IS_PED_IN_GROUP` | `bool IS_PED_IN_GROUP(int ped)` | bool |
| `IS_PED_IN_HIGH_COVER` | `bool IS_PED_IN_HIGH_COVER(int ped)` | bool |
| `IS_PED_IN_MELEE_COMBAT` | `bool IS_PED_IN_MELEE_COMBAT(int ped)` | bool |
| `IS_PED_IN_MODEL` | `bool IS_PED_IN_MODEL(int ped, uint modelHash)` | bool |
| `IS_PED_IN_PARACHUTE_FREE_FALL` | `bool IS_PED_IN_PARACHUTE_FREE_FALL(int ped)` | bool |
| `IS_PED_IN_VEHICLE` | `bool IS_PED_IN_VEHICLE(int ped, int vehicle, bool atGetIn)` | bool |
| `IS_PED_JACKING` | `bool IS_PED_JACKING(int ped)` | bool |
| `IS_PED_JUMPING` | `bool IS_PED_JUMPING(int ped)` | bool |
| `IS_PED_JUMPING_OUT_OF_VEHICLE` | `bool IS_PED_JUMPING_OUT_OF_VEHICLE(int ped)` | bool |
| `IS_PED_LANDING` | `bool IS_PED_LANDING(object p0)` | bool |
| `IS_PED_LIPSTICK_TINT_FOR_BARBER` | `bool IS_PED_LIPSTICK_TINT_FOR_BARBER(int colorID)` | bool |
| `IS_PED_LIPSTICK_TINT_FOR_CREATOR` | `bool IS_PED_LIPSTICK_TINT_FOR_CREATOR(int colorId)` | bool |
| `IS_PED_MALE` | `bool IS_PED_MALE(int ped)` | bool |
| `IS_PED_MODEL` | `bool IS_PED_MODEL(int ped, uint modelHash)` | bool |
| `IS_PED_ON_ANY_BIKE` | `bool IS_PED_ON_ANY_BIKE(int ped)` | bool |
| `IS_PED_ON_FOOT` | `bool IS_PED_ON_FOOT(int ped)` | bool |
| `IS_PED_ON_MOUNT` | `bool IS_PED_ON_MOUNT(int ped)` | bool |
| `IS_PED_ON_SPECIFIC_VEHICLE` | `bool IS_PED_ON_SPECIFIC_VEHICLE(int ped, int vehicle)` | bool |
| `IS_PED_ON_VEHICLE` | `bool IS_PED_ON_VEHICLE(int ped)` | bool |
| `IS_PED_OPENING_DOOR` | `bool IS_PED_OPENING_DOOR(int ped)` | bool |
| `IS_PED_PERFORMING_A_COUNTER_ATTACK` | `bool IS_PED_PERFORMING_A_COUNTER_ATTACK(int ped)` | bool |
| `IS_PED_PERFORMING_MELEE_ACTION` | `bool IS_PED_PERFORMING_MELEE_ACTION(int ped)` | bool |
| `IS_PED_PERFORMING_STEALTH_KILL` | `bool IS_PED_PERFORMING_STEALTH_KILL(int ped)` | bool |
| `IS_PED_PLANTING_BOMB` | `bool IS_PED_PLANTING_BOMB(int ped)` | bool |
| `IS_PED_PRONE` | `bool IS_PED_PRONE(int ped)` | bool |
| `IS_PED_RAGDOLL` | `bool IS_PED_RAGDOLL(int ped)` | bool |
| `IS_PED_RELOADING` | `bool IS_PED_RELOADING(int ped)` | bool |
| `IS_PED_RESPONDING_TO_EVENT` | `bool IS_PED_RESPONDING_TO_EVENT(int ped, object event)` | bool |
| `IS_PED_RUNNING_MELEE_TASK` | `bool IS_PED_RUNNING_MELEE_TASK(int ped)` | bool |
| `IS_PED_RUNNING_MOBILE_PHONE_TASK` | `bool IS_PED_RUNNING_MOBILE_PHONE_TASK(int ped)` | bool |
| `IS_PED_RUNNING_RAGDOLL_TASK` | `bool IS_PED_RUNNING_RAGDOLL_TASK(int ped)` | bool |
| `IS_PED_SHADER_READY` | `bool IS_PED_SHADER_READY(int ped)` | bool |
| `IS_PED_SHELTERED` | `bool IS_PED_SHELTERED(int ped)` | bool |
| `IS_PED_SHOOTING` | `bool IS_PED_SHOOTING(int ped)` | bool |
| `IS_PED_SHOOTING_IN_AREA` | `bool IS_PED_SHOOTING_IN_AREA(int ped, float x1, float y1, float z1, float x2, float y2, float z2, bool p7, bool p8)` | bool |
| `IS_PED_SITTING_IN_ANY_VEHICLE` | `bool IS_PED_SITTING_IN_ANY_VEHICLE(int ped)` | bool |
| `IS_PED_SITTING_IN_VEHICLE` | `bool IS_PED_SITTING_IN_VEHICLE(int ped, int vehicle)` | bool |
| `IS_PED_STOPPED` | `bool IS_PED_STOPPED(int ped)` | bool |
| `IS_PED_SWIMMING` | `bool IS_PED_SWIMMING(int ped)` | bool |
| `IS_PED_SWIMMING_UNDER_WATER` | `bool IS_PED_SWIMMING_UNDER_WATER(int ped)` | bool |
| `IS_PED_SWITCHING_WEAPON` | `bool IS_PED_SWITCHING_WEAPON(int Ped)` | bool |
| `IS_PED_TAKING_OFF_HELMET` | `bool IS_PED_TAKING_OFF_HELMET(int ped)` | bool |
| `IS_PED_TRACKED` | `bool IS_PED_TRACKED(int ped)` | bool |
| `IS_PED_TRYING_TO_ENTER_A_LOCKED_VEHICLE` | `bool IS_PED_TRYING_TO_ENTER_A_LOCKED_VEHICLE(int ped)` | bool |
| `IS_PED_USING_ACTION_MODE` | `bool IS_PED_USING_ACTION_MODE(int ped)` | bool |
| `IS_PED_USING_ANY_SCENARIO` | `bool IS_PED_USING_ANY_SCENARIO(int ped)` | bool |
| `IS_PED_USING_SCENARIO` | `bool IS_PED_USING_SCENARIO(int ped, string scenario)` | bool |
| `IS_PED_VAULTING` | `bool IS_PED_VAULTING(int ped)` | bool |
| `IS_PED_WEARING_HELMET` | `bool IS_PED_WEARING_HELMET(int ped)` | bool |
| `IS_SCRIPTED_SCENARIO_PED_USING_CONDITIONAL_ANIM` | `bool IS_SCRIPTED_SCENARIO_PED_USING_CONDITIONAL_ANIM(int ped, string animDict, string anim)` | bool |
| `IS_SYNCHRONIZED_SCENE_HOLD_LAST_FRAME` | `bool IS_SYNCHRONIZED_SCENE_HOLD_LAST_FRAME(int sceneID)` | bool |
| `IS_SYNCHRONIZED_SCENE_LOOPED` | `bool IS_SYNCHRONIZED_SCENE_LOOPED(int sceneID)` | bool |
| `IS_SYNCHRONIZED_SCENE_RUNNING` | `bool IS_SYNCHRONIZED_SCENE_RUNNING(int sceneId)` | bool |
| `IS_TARGET_PED_IN_PERCEPTION_AREA` | `bool IS_TARGET_PED_IN_PERCEPTION_AREA(int ped, int targetPed, float p2, float p3, float p4, float p5)` | bool |
| `IS_TRACKED_PED_VISIBLE` | `bool IS_TRACKED_PED_VISIBLE(int ped)` | bool |
| `IS_USING_PED_SCUBA_GEAR_VARIATION` | `bool IS_USING_PED_SCUBA_GEAR_VARIATION(object p0)` | bool |
| `KNOCK_OFF_PED_PROP` | `void KNOCK_OFF_PED_PROP(int ped, bool p1, bool p2, bool p3, bool p4)` | void |
| `KNOCK_PED_OFF_VEHICLE` | `void KNOCK_PED_OFF_VEHICLE(int ped)` | void |
| `MARK_PED_DECORATIONS_AS_CLONED_FROM_LOCAL_PLAYER` | `void MARK_PED_DECORATIONS_AS_CLONED_FROM_LOCAL_PLAYER(int ped, bool p1)` | void |
| `PED_HAS_SEXINESS_FLAG_SET` | `bool PED_HAS_SEXINESS_FLAG_SET(int ped, int sexinessFlag)` | bool |
| `PLAY_FACIAL_ANIM` | `void PLAY_FACIAL_ANIM(int ped, string animName, string animDict)` | void |
| `REGISTER_HATED_TARGETS_AROUND_PED` | `void REGISTER_HATED_TARGETS_AROUND_PED(int ped, float radius)` | void |
| `REGISTER_PEDHEADSHOT` | `int REGISTER_PEDHEADSHOT(int ped)` | int |
| `REGISTER_PEDHEADSHOT_HIRES` | `int REGISTER_PEDHEADSHOT_HIRES(int ped)` | int |
| `REGISTER_PEDHEADSHOT_TRANSPARENT` | `int REGISTER_PEDHEADSHOT_TRANSPARENT(int ped)` | int |
| `REGISTER_TARGET` | `void REGISTER_TARGET(int ped, int target)` | void |
| `RELEASE_PEDHEADSHOT_IMG_UPLOAD` | `void RELEASE_PEDHEADSHOT_IMG_UPLOAD(int id)` | void |
| `RELEASE_PED_PRELOAD_PROP_DATA` | `void RELEASE_PED_PRELOAD_PROP_DATA(int ped)` | void |
| `RELEASE_PED_PRELOAD_VARIATION_DATA` | `void RELEASE_PED_PRELOAD_VARIATION_DATA(int ped)` | void |
| `REMOVE_ACTION_MODE_ASSET` | `void REMOVE_ACTION_MODE_ASSET(string asset)` | void |
| `REMOVE_GROUP` | `void REMOVE_GROUP(int groupId)` | void |
| `REMOVE_PED_DEFENSIVE_AREA` | `void REMOVE_PED_DEFENSIVE_AREA(int ped, bool toggle)` | void |
| `REMOVE_PED_ELEGANTLY` | `void REMOVE_PED_ELEGANTLY(Ped* ped)` | void |
| `REMOVE_PED_FROM_GROUP` | `void REMOVE_PED_FROM_GROUP(int ped)` | void |
| `REMOVE_PED_HELMET` | `void REMOVE_PED_HELMET(int ped, bool instantly)` | void |
| `REMOVE_PED_PREFERRED_COVER_SET` | `void REMOVE_PED_PREFERRED_COVER_SET(int ped)` | void |
| `REMOVE_RELATIONSHIP_GROUP` | `void REMOVE_RELATIONSHIP_GROUP(uint groupHash)` | void |
| `REMOVE_SCENARIO_BLOCKING_AREA` | `void REMOVE_SCENARIO_BLOCKING_AREA(object p0, bool p1)` | void |
| `REMOVE_SCENARIO_BLOCKING_AREAS` | `void REMOVE_SCENARIO_BLOCKING_AREAS()` | void |
| `REMOVE_STEALTH_MODE_ASSET` | `void REMOVE_STEALTH_MODE_ASSET(string asset)` | void |
| `REQUEST_ACTION_MODE_ASSET` | `void REQUEST_ACTION_MODE_ASSET(string asset)` | void |
| `REQUEST_PEDHEADSHOT_IMG_UPLOAD` | `bool REQUEST_PEDHEADSHOT_IMG_UPLOAD(int id)` | bool |
| `REQUEST_PED_RESTRICTED_VEHICLE_VISIBILITY_TRACKING` | `void REQUEST_PED_RESTRICTED_VEHICLE_VISIBILITY_TRACKING(int ped, bool p1)` | void |
| `REQUEST_PED_USE_SMALL_BBOX_VISIBILITY_TRACKING` | `void REQUEST_PED_USE_SMALL_BBOX_VISIBILITY_TRACKING(int ped, bool p1)` | void |
| `REQUEST_PED_VEHICLE_VISIBILITY_TRACKING` | `void REQUEST_PED_VEHICLE_VISIBILITY_TRACKING(int ped, bool p1)` | void |
| `REQUEST_PED_VISIBILITY_TRACKING` | `void REQUEST_PED_VISIBILITY_TRACKING(int ped)` | void |
| `REQUEST_RAGDOLL_BOUNDS_UPDATE` | `void REQUEST_RAGDOLL_BOUNDS_UPDATE(object p0, object p1)` | void |
| `REQUEST_STEALTH_MODE_ASSET` | `void REQUEST_STEALTH_MODE_ASSET(string asset)` | void |
| `RESET_AI_MELEE_WEAPON_DAMAGE_MODIFIER` | `void RESET_AI_MELEE_WEAPON_DAMAGE_MODIFIER()` | void |
| `RESET_AI_WEAPON_DAMAGE_MODIFIER` | `void RESET_AI_WEAPON_DAMAGE_MODIFIER()` | void |
| `RESET_FACIAL_IDLE_ANIM` | `void RESET_FACIAL_IDLE_ANIM(int ped)` | void |
| `RESET_GROUP_FORMATION_DEFAULT_SPACING` | `void RESET_GROUP_FORMATION_DEFAULT_SPACING(int groupHandle)` | void |
| `RESET_PED_IN_VEHICLE_CONTEXT` | `void RESET_PED_IN_VEHICLE_CONTEXT(int ped)` | void |
| `RESET_PED_LAST_VEHICLE` | `void RESET_PED_LAST_VEHICLE(int ped)` | void |
| `RESET_PED_MOVEMENT_CLIPSET` | `void RESET_PED_MOVEMENT_CLIPSET(int ped, float p1)` | void |
| `RESET_PED_RAGDOLL_TIMER` | `void RESET_PED_RAGDOLL_TIMER(int ped)` | void |
| `RESET_PED_STRAFE_CLIPSET` | `void RESET_PED_STRAFE_CLIPSET(int ped)` | void |
| `RESET_PED_VISIBLE_DAMAGE` | `void RESET_PED_VISIBLE_DAMAGE(int ped)` | void |
| `RESET_PED_WEAPON_MOVEMENT_CLIPSET` | `void RESET_PED_WEAPON_MOVEMENT_CLIPSET(int ped)` | void |
| `RESURRECT_PED` | `void RESURRECT_PED(int ped)` | void |
| `REVIVE_INJURED_PED` | `void REVIVE_INJURED_PED(int ped)` | void |
| `SET_AI_MELEE_WEAPON_DAMAGE_MODIFIER` | `void SET_AI_MELEE_WEAPON_DAMAGE_MODIFIER(float modifier)` | void |
| `SET_AI_WEAPON_DAMAGE_MODIFIER` | `void SET_AI_WEAPON_DAMAGE_MODIFIER(float value)` | void |
| `SET_ALLOW_LOCKON_TO_PED_IF_FRIENDLY` | `void SET_ALLOW_LOCKON_TO_PED_IF_FRIENDLY(int ped, bool toggle)` | void |
| `SET_ALLOW_STUNT_JUMP_CAMERA` | `void SET_ALLOW_STUNT_JUMP_CAMERA(int ped, bool toggle)` | void |
| `SET_AMBIENT_LAW_PED_ACCURACY_MODIFIER` | `void SET_AMBIENT_LAW_PED_ACCURACY_MODIFIER(float multiplier)` | void |
| `SET_AMBIENT_PEDS_DROP_MONEY` | `void SET_AMBIENT_PEDS_DROP_MONEY(bool p0)` | void |
| `SET_BLOCKING_OF_NON_TEMPORARY_EVENTS` | `void SET_BLOCKING_OF_NON_TEMPORARY_EVENTS(int ped, bool toggle)` | void |
| `SET_BLOCKING_OF_NON_TEMPORARY_EVENTS_FOR_AMBIENT_PEDS_THIS_FRAME` | `void SET_BLOCKING_OF_NON_TEMPORARY_EVENTS_FOR_AMBIENT_PEDS_THIS_FRAME(bool p0)` | void |
| `SET_CAN_ATTACK_FRIENDLY` | `void SET_CAN_ATTACK_FRIENDLY(int ped, bool toggle, bool p2)` | void |
| `SET_COMBAT_FLOAT` | `void SET_COMBAT_FLOAT(int ped, int combatType, float p2)` | void |
| `SET_COP_PERCEPTION_OVERRIDES` | `void SET_COP_PERCEPTION_OVERRIDES(float seeingRange, float seeingRangePeripheral, float hearingRange, float visualFieldMinAzimuthAngle, float visualFieldMaxAzimuthAngle, float fieldOfGazeMaxAngle, float p6)` | void |
| `SET_CORPSE_RAGDOLL_FRICTION` | `void SET_CORPSE_RAGDOLL_FRICTION(int ped, float p1)` | void |
| `SET_CREATE_RANDOM_COPS` | `void SET_CREATE_RANDOM_COPS(bool toggle)` | void |
| `SET_CREATE_RANDOM_COPS_NOT_ON_SCENARIOS` | `void SET_CREATE_RANDOM_COPS_NOT_ON_SCENARIOS(bool toggle)` | void |
| `SET_CREATE_RANDOM_COPS_ON_SCENARIOS` | `void SET_CREATE_RANDOM_COPS_ON_SCENARIOS(bool toggle)` | void |
| `SET_DISABLE_HIGH_FALL_DEATH` | `void SET_DISABLE_HIGH_FALL_DEATH(int ped, bool toggle)` | void |
| `SET_DISABLE_PED_MAP_COLLISION` | `void SET_DISABLE_PED_MAP_COLLISION(int ped)` | void |
| `SET_DRIVER_ABILITY` | `void SET_DRIVER_ABILITY(int driver, float ability)` | void |
| `SET_DRIVER_AGGRESSIVENESS` | `void SET_DRIVER_AGGRESSIVENESS(int driver, float aggressiveness)` | void |
| `SET_DRIVER_RACING_MODIFIER` | `void SET_DRIVER_RACING_MODIFIER(int driver, float modifier)` | void |
| `SET_ENABLE_BOUND_ANKLES` | `void SET_ENABLE_BOUND_ANKLES(int ped, bool toggle)` | void |
| `SET_ENABLE_HANDCUFFS` | `void SET_ENABLE_HANDCUFFS(int ped, bool toggle)` | void |
| `SET_ENABLE_PED_ENVEFF_SCALE` | `void SET_ENABLE_PED_ENVEFF_SCALE(int ped, bool toggle)` | void |
| `SET_ENABLE_SCUBA` | `void SET_ENABLE_SCUBA(int ped, bool toggle)` | void |
| `SET_FACIAL_CLIPSET` | `void SET_FACIAL_CLIPSET(int ped, string animDict)` | void |
| `SET_FACIAL_IDLE_ANIM_OVERRIDE` | `void SET_FACIAL_IDLE_ANIM_OVERRIDE(int ped, string animName, string animDict)` | void |
| `SET_FORCE_FOOTSTEP_UPDATE` | `void SET_FORCE_FOOTSTEP_UPDATE(int ped, bool toggle)` | void |
| `SET_FORCE_STEP_TYPE` | `void SET_FORCE_STEP_TYPE(int ped, bool p1, int type, int p3)` | void |
| `SET_GROUP_FORMATION` | `void SET_GROUP_FORMATION(int groupId, int formationType)` | void |
| `SET_GROUP_FORMATION_SPACING` | `void SET_GROUP_FORMATION_SPACING(int groupId, float x, float y, float z)` | void |
| `SET_GROUP_SEPARATION_RANGE` | `void SET_GROUP_SEPARATION_RANGE(int groupHandle, float separationRange)` | void |
| `SET_HEAD_BLEND_EYE_COLOR` | `void SET_HEAD_BLEND_EYE_COLOR(int ped, int index)` | void |
| `SET_HEAD_BLEND_PALETTE_COLOR` | `void SET_HEAD_BLEND_PALETTE_COLOR(int ped, int r, int g, int b, int id)` | void |
| `SET_HEALTH_SNACKS_CARRIED_BY_ALL_NEW_PEDS` | `void SET_HEALTH_SNACKS_CARRIED_BY_ALL_NEW_PEDS(float p0, object p1)` | void |
| `SET_IK_TARGET` | `void SET_IK_TARGET(int ped, int ikIndex, int entityLookAt, int boneLookAt, float offsetX, float offsetY, float offsetZ, object p7, int blendInDuration, int blendOutDuration)` | void |
| `SET_LADDER_CLIMB_INPUT_STATE` | `void SET_LADDER_CLIMB_INPUT_STATE(int ped, int p1)` | void |
| `SET_MOVEMENT_MODE_OVERRIDE` | `void SET_MOVEMENT_MODE_OVERRIDE(int ped, string name)` | void |
| `SET_PED_ACCURACY` | `void SET_PED_ACCURACY(int ped, int accuracy)` | void |
| `SET_PED_ALERTNESS` | `void SET_PED_ALERTNESS(int ped, int value)` | void |
| `SET_PED_ALLOWED_TO_DUCK` | `void SET_PED_ALLOWED_TO_DUCK(int ped, bool toggle)` | void |
| `SET_PED_ALLOW_HURT_COMBAT_FOR_ALL_MISSION_PEDS` | `void SET_PED_ALLOW_HURT_COMBAT_FOR_ALL_MISSION_PEDS(bool toggle)` | void |
| `SET_PED_ALLOW_MINOR_REACTIONS_AS_MISSION_PED` | `void SET_PED_ALLOW_MINOR_REACTIONS_AS_MISSION_PED(int ped, bool toggle)` | void |
| `SET_PED_ALLOW_VEHICLES_OVERRIDE` | `void SET_PED_ALLOW_VEHICLES_OVERRIDE(int ped, bool toggle)` | void |
| `SET_PED_ALTERNATE_MOVEMENT_ANIM` | `void SET_PED_ALTERNATE_MOVEMENT_ANIM(int ped, int stance, string animDictionary, string animationName, float p4, bool p5)` | void |
| `SET_PED_ALTERNATE_WALK_ANIM` | `void SET_PED_ALTERNATE_WALK_ANIM(int ped, string animDict, string animName, float p3, bool p4)` | void |
| `SET_PED_ANGLED_DEFENSIVE_AREA` | `void SET_PED_ANGLED_DEFENSIVE_AREA(int ped, float p1, float p2, float p3, float p4, float p5, float p6, float p7, bool p8, bool p9)` | void |
| `SET_PED_AO_BLOB_RENDERING` | `void SET_PED_AO_BLOB_RENDERING(int ped, bool toggle)` | void |
| `SET_PED_ARMOUR` | `void SET_PED_ARMOUR(int ped, int amount)` | void |
| `SET_PED_AS_COP` | `void SET_PED_AS_COP(int ped, bool toggle)` | void |
| `SET_PED_AS_ENEMY` | `void SET_PED_AS_ENEMY(int ped, bool toggle)` | void |
| `SET_PED_AS_GROUP_LEADER` | `void SET_PED_AS_GROUP_LEADER(int ped, int groupId)` | void |
| `SET_PED_AS_GROUP_MEMBER` | `void SET_PED_AS_GROUP_MEMBER(int ped, int groupId)` | void |
| `SET_PED_BLEND_FROM_PARENTS` | `void SET_PED_BLEND_FROM_PARENTS(int ped, object p1, object p2, float p3, float p4)` | void |
| `SET_PED_BLOCKS_PATHING_WHEN_DEAD` | `void SET_PED_BLOCKS_PATHING_WHEN_DEAD(int ped, bool toggle)` | void |
| `SET_PED_BOUNDS_ORIENTATION` | `void SET_PED_BOUNDS_ORIENTATION(int ped, float p1, float p2, float x, float y, float z)` | void |
| `SET_PED_CAN_ARM_IK` | `void SET_PED_CAN_ARM_IK(int ped, bool toggle)` | void |
| `SET_PED_CAN_BE_DRAGGED_OUT` | `void SET_PED_CAN_BE_DRAGGED_OUT(int ped, bool toggle)` | void |
| `SET_PED_CAN_BE_KNOCKED_OFF_BIKE` | `void SET_PED_CAN_BE_KNOCKED_OFF_BIKE(object p0, object p1)` | void |
| `SET_PED_CAN_BE_KNOCKED_OFF_VEHICLE` | `void SET_PED_CAN_BE_KNOCKED_OFF_VEHICLE(int ped, int state)` | void |
| `SET_PED_CAN_BE_SHOT_IN_VEHICLE` | `void SET_PED_CAN_BE_SHOT_IN_VEHICLE(int ped, bool toggle)` | void |
| `SET_PED_CAN_BE_TARGETED_WHEN_INJURED` | `void SET_PED_CAN_BE_TARGETED_WHEN_INJURED(int ped, bool toggle)` | void |
| `SET_PED_CAN_BE_TARGETED_WITHOUT_LOS` | `void SET_PED_CAN_BE_TARGETED_WITHOUT_LOS(int ped, bool toggle)` | void |
| `SET_PED_CAN_BE_TARGETTED` | `void SET_PED_CAN_BE_TARGETTED(int ped, bool toggle)` | void |
| `SET_PED_CAN_BE_TARGETTED_BY_PLAYER` | `void SET_PED_CAN_BE_TARGETTED_BY_PLAYER(int ped, int player, bool toggle)` | void |
| `SET_PED_CAN_BE_TARGETTED_BY_TEAM` | `void SET_PED_CAN_BE_TARGETTED_BY_TEAM(int ped, int team, bool toggle)` | void |
| `SET_PED_CAN_BODY_RECOIL_IK` | `void SET_PED_CAN_BODY_RECOIL_IK(int ped, bool toggle)` | void |
| `SET_PED_CAN_COWER_IN_COVER` | `void SET_PED_CAN_COWER_IN_COVER(int ped, bool toggle)` | void |
| `SET_PED_CAN_EVASIVE_DIVE` | `void SET_PED_CAN_EVASIVE_DIVE(int ped, bool toggle)` | void |
| `SET_PED_CAN_HEAD_IK` | `void SET_PED_CAN_HEAD_IK(int ped, bool toggle)` | void |
| `SET_PED_CAN_LEG_IK` | `void SET_PED_CAN_LEG_IK(int ped, bool toggle)` | void |
| `SET_PED_CAN_LOSE_PROPS_ON_DAMAGE` | `void SET_PED_CAN_LOSE_PROPS_ON_DAMAGE(int ped, bool toggle, int p2)` | void |
| `SET_PED_CAN_PEEK_IN_COVER` | `void SET_PED_CAN_PEEK_IN_COVER(int ped, bool toggle)` | void |
| `SET_PED_CAN_PLAY_AMBIENT_ANIMS` | `void SET_PED_CAN_PLAY_AMBIENT_ANIMS(int ped, bool toggle)` | void |
| `SET_PED_CAN_PLAY_AMBIENT_BASE_ANIMS` | `void SET_PED_CAN_PLAY_AMBIENT_BASE_ANIMS(int ped, bool toggle)` | void |
| `SET_PED_CAN_PLAY_GESTURE_ANIMS` | `void SET_PED_CAN_PLAY_GESTURE_ANIMS(int ped, bool toggle)` | void |
| `SET_PED_CAN_PLAY_IN_CAR_IDLES` | `void SET_PED_CAN_PLAY_IN_CAR_IDLES(int ped, bool toggle)` | void |
| `SET_PED_CAN_PLAY_VISEME_ANIMS` | `void SET_PED_CAN_PLAY_VISEME_ANIMS(int ped, bool toggle, bool p2)` | void |
| `SET_PED_CAN_RAGDOLL` | `void SET_PED_CAN_RAGDOLL(int ped, bool toggle)` | void |
| `SET_PED_CAN_RAGDOLL_FROM_PLAYER_IMPACT` | `void SET_PED_CAN_RAGDOLL_FROM_PLAYER_IMPACT(int ped, bool toggle)` | void |
| `SET_PED_CAN_SMASH_GLASS` | `void SET_PED_CAN_SMASH_GLASS(int ped, bool p1, bool p2)` | void |
| `SET_PED_CAN_SWITCH_WEAPON` | `void SET_PED_CAN_SWITCH_WEAPON(int ped, bool toggle)` | void |
| `SET_PED_CAN_TELEPORT_TO_GROUP_LEADER` | `void SET_PED_CAN_TELEPORT_TO_GROUP_LEADER(int pedHandle, int groupHandle, bool toggle)` | void |
| `SET_PED_CAN_TORSO_IK` | `void SET_PED_CAN_TORSO_IK(int ped, bool toggle)` | void |
| `SET_PED_CAN_TORSO_REACT_IK` | `void SET_PED_CAN_TORSO_REACT_IK(int ped, bool p1)` | void |
| `SET_PED_CAN_TORSO_VEHICLE_IK` | `void SET_PED_CAN_TORSO_VEHICLE_IK(int ped, bool p1)` | void |
| `SET_PED_CAN_USE_AUTO_CONVERSATION_LOOKAT` | `void SET_PED_CAN_USE_AUTO_CONVERSATION_LOOKAT(int ped, bool toggle)` | void |
| `SET_PED_CAPSULE` | `void SET_PED_CAPSULE(int ped, float value)` | void |
| `SET_PED_CLOTH_PACKAGE_INDEX` | `void SET_PED_CLOTH_PACKAGE_INDEX(object p0, object p1)` | void |
| `SET_PED_CLOTH_PIN_FRAMES` | `void SET_PED_CLOTH_PIN_FRAMES(object p0, object p1)` | void |
| `SET_PED_CLOTH_PRONE` | `void SET_PED_CLOTH_PRONE(object p0, bool p1)` | void |
| `SET_PED_COMBAT_ABILITY` | `void SET_PED_COMBAT_ABILITY(int ped, int abilityLevel)` | void |
| `SET_PED_COMBAT_ATTRIBUTES` | `void SET_PED_COMBAT_ATTRIBUTES(int ped, int attributeId, bool enabled)` | void |
| `SET_PED_COMBAT_MOVEMENT` | `void SET_PED_COMBAT_MOVEMENT(int ped, int combatMovement)` | void |
| `SET_PED_COMBAT_RANGE` | `void SET_PED_COMBAT_RANGE(int ped, int combatRange)` | void |
| `SET_PED_COMPONENT_VARIATION` | `void SET_PED_COMPONENT_VARIATION(int ped, int componentId, int drawableId, int textureId, int paletteId)` | void |
| `SET_PED_CONFIG_FLAG` | `void SET_PED_CONFIG_FLAG(int ped, int flagId, bool value)` | void |
| `SET_PED_COORDS_KEEP_VEHICLE` | `void SET_PED_COORDS_KEEP_VEHICLE(int ped, float posX, float posY, float posZ)` | void |
| `SET_PED_COORDS_NO_GANG` | `void SET_PED_COORDS_NO_GANG(int ped, float posX, float posY, float posZ)` | void |
| `SET_PED_COWER_HASH` | `void SET_PED_COWER_HASH(int ped, string p1)` | void |
| `SET_PED_DEFAULT_COMPONENT_VARIATION` | `void SET_PED_DEFAULT_COMPONENT_VARIATION(int ped)` | void |
| `SET_PED_DEFENSIVE_AREA_ATTACHED_TO_PED` | `void SET_PED_DEFENSIVE_AREA_ATTACHED_TO_PED(int ped, int attachPed, float p2, float p3, float p4, float p5, float p6, float p7, float p8, bool p9, bool p10)` | void |
| `SET_PED_DEFENSIVE_AREA_DIRECTION` | `void SET_PED_DEFENSIVE_AREA_DIRECTION(int ped, float p1, float p2, float p3, bool p4)` | void |
| `SET_PED_DEFENSIVE_SPHERE_ATTACHED_TO_PED` | `void SET_PED_DEFENSIVE_SPHERE_ATTACHED_TO_PED(int ped, int target, float xOffset, float yOffset, float zOffset, float radius, bool p6)` | void |
| `SET_PED_DEFENSIVE_SPHERE_ATTACHED_TO_VEHICLE` | `void SET_PED_DEFENSIVE_SPHERE_ATTACHED_TO_VEHICLE(int ped, int target, float xOffset, float yOffset, float zOffset, float radius, bool p6)` | void |
| `SET_PED_DENSITY_MULTIPLIER_THIS_FRAME` | `void SET_PED_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier)` | void |
| `SET_PED_DESIRED_HEADING` | `void SET_PED_DESIRED_HEADING(int ped, float heading)` | void |
| `SET_PED_DIES_INSTANTLY_IN_WATER` | `void SET_PED_DIES_INSTANTLY_IN_WATER(int ped, bool toggle)` | void |
| `SET_PED_DIES_IN_SINKING_VEHICLE` | `void SET_PED_DIES_IN_SINKING_VEHICLE(int ped, bool toggle)` | void |
| `SET_PED_DIES_IN_VEHICLE` | `void SET_PED_DIES_IN_VEHICLE(int ped, bool toggle)` | void |
| `SET_PED_DIES_IN_WATER` | `void SET_PED_DIES_IN_WATER(int ped, bool toggle)` | void |
| `SET_PED_DIES_WHEN_INJURED` | `void SET_PED_DIES_WHEN_INJURED(int ped, bool toggle)` | void |
| `SET_PED_DRIVE_BY_CLIPSET_OVERRIDE` | `void SET_PED_DRIVE_BY_CLIPSET_OVERRIDE(int ped, string clipset)` | void |
| `SET_PED_DUCKING` | `void SET_PED_DUCKING(int ped, bool toggle)` | void |
| `SET_PED_EMISSIVE_SCALE` | `void SET_PED_EMISSIVE_SCALE(int ped, float intensity)` | void |
| `SET_PED_ENABLE_CREW_EMBLEM` | `void SET_PED_ENABLE_CREW_EMBLEM(int ped, bool toggle)` | void |
| `SET_PED_ENABLE_WEAPON_BLOCKING` | `void SET_PED_ENABLE_WEAPON_BLOCKING(int ped, bool toggle)` | void |
| `SET_PED_ENVEFF_COLOR_MODULATOR` | `void SET_PED_ENVEFF_COLOR_MODULATOR(int ped, int p1, int p2, int p3)` | void |
| `SET_PED_ENVEFF_CPV_ADD` | `void SET_PED_ENVEFF_CPV_ADD(int ped, float p1)` | void |
| `SET_PED_ENVEFF_SCALE` | `void SET_PED_ENVEFF_SCALE(int ped, float value)` | void |
| `SET_PED_FIRING_PATTERN` | `void SET_PED_FIRING_PATTERN(int ped, uint patternHash)` | void |
| `SET_PED_FLEE_ATTRIBUTES` | `void SET_PED_FLEE_ATTRIBUTES(int ped, int attributeFlags, bool enable)` | void |
| `SET_PED_GENERATES_DEAD_BODY_EVENTS` | `void SET_PED_GENERATES_DEAD_BODY_EVENTS(int ped, bool toggle)` | void |
| `SET_PED_GESTURE_GROUP` | `void SET_PED_GESTURE_GROUP(int ped, string animGroupGesture)` | void |
| `SET_PED_GET_OUT_UPSIDE_DOWN_VEHICLE` | `void SET_PED_GET_OUT_UPSIDE_DOWN_VEHICLE(int ped, bool toggle)` | void |
| `SET_PED_GRAVITY` | `void SET_PED_GRAVITY(int ped, bool toggle)` | void |
| `SET_PED_GROUP_MEMBER_PASSENGER_INDEX` | `void SET_PED_GROUP_MEMBER_PASSENGER_INDEX(int ped, int index)` | void |
| `SET_PED_HAIR_TINT` | `void SET_PED_HAIR_TINT(int ped, int colorID, int highlightColorID)` | void |
| `SET_PED_HEAD_BLEND_DATA` | `void SET_PED_HEAD_BLEND_DATA(int ped, int shapeFirstID, int shapeSecondID, int shapeThirdID, int skinFirstID, int skinSecondID, int skinThirdID, float shapeMix, float skinMix, float thirdMix, bool isParent)` | void |
| `SET_PED_HEAD_OVERLAY` | `void SET_PED_HEAD_OVERLAY(int ped, int overlayID, int index, float opacity)` | void |
| `SET_PED_HEAD_OVERLAY_TINT` | `void SET_PED_HEAD_OVERLAY_TINT(int ped, int overlayID, int colorType, int colorID, int secondColorID)` | void |
| `SET_PED_HEALTH_PENDING_LAST_DAMAGE_EVENT_OVERRIDE_FLAG` | `void SET_PED_HEALTH_PENDING_LAST_DAMAGE_EVENT_OVERRIDE_FLAG(bool toggle)` | void |
| `SET_PED_HEARING_RANGE` | `void SET_PED_HEARING_RANGE(int ped, float value)` | void |
| `SET_PED_HEATSCALE_OVERRIDE` | `void SET_PED_HEATSCALE_OVERRIDE(int ped, float heatScale)` | void |
| `SET_PED_HELMET` | `void SET_PED_HELMET(int ped, bool canWearHelmet)` | void |
| `SET_PED_HELMET_FLAG` | `void SET_PED_HELMET_FLAG(int ped, int helmetFlag)` | void |
| `SET_PED_HELMET_PROP_INDEX` | `void SET_PED_HELMET_PROP_INDEX(int ped, int propIndex, bool p2)` | void |
| `SET_PED_HELMET_TEXTURE_INDEX` | `void SET_PED_HELMET_TEXTURE_INDEX(int ped, int textureIndex)` | void |
| `SET_PED_HELMET_VISOR_PROP_INDICES` | `void SET_PED_HELMET_VISOR_PROP_INDICES(int ped, bool p1, int p2, int p3)` | void |
| `SET_PED_HIGHLY_PERCEPTIVE` | `void SET_PED_HIGHLY_PERCEPTIVE(int ped, bool toggle)` | void |
| `SET_PED_ID_RANGE` | `void SET_PED_ID_RANGE(int ped, float value)` | void |
| `SET_PED_INCREASED_AVOIDANCE_RADIUS` | `void SET_PED_INCREASED_AVOIDANCE_RADIUS(int ped)` | void |
| `SET_PED_INJURED_ON_GROUND_BEHAVIOUR` | `void SET_PED_INJURED_ON_GROUND_BEHAVIOUR(int ped, float p1)` | void |
| `SET_PED_INTO_VEHICLE` | `void SET_PED_INTO_VEHICLE(int ped, int vehicle, int seatIndex)` | void |
| `SET_PED_IN_VEHICLE_CONTEXT` | `void SET_PED_IN_VEHICLE_CONTEXT(int ped, uint context)` | void |
| `SET_PED_IS_AVOIDED_BY_OTHERS` | `void SET_PED_IS_AVOIDED_BY_OTHERS(object p0, bool p1)` | void |
| `SET_PED_IS_IGNORED_BY_AUTO_OPEN_DOORS` | `void SET_PED_IS_IGNORED_BY_AUTO_OPEN_DOORS(int ped, bool p1)` | void |
| `SET_PED_KEEP_TASK` | `void SET_PED_KEEP_TASK(int ped, bool toggle)` | void |
| `SET_PED_LEG_IK_MODE` | `void SET_PED_LEG_IK_MODE(int ped, int mode)` | void |
| `SET_PED_LOD_MULTIPLIER` | `void SET_PED_LOD_MULTIPLIER(int ped, float multiplier)` | void |
| `SET_PED_MAX_HEALTH` | `void SET_PED_MAX_HEALTH(int ped, int value)` | void |
| `SET_PED_MAX_MOVE_BLEND_RATIO` | `void SET_PED_MAX_MOVE_BLEND_RATIO(int ped, float value)` | void |
| `SET_PED_MAX_TIME_IN_WATER` | `void SET_PED_MAX_TIME_IN_WATER(int ped, float value)` | void |
| `SET_PED_MAX_TIME_UNDERWATER` | `void SET_PED_MAX_TIME_UNDERWATER(int ped, float value)` | void |
| `SET_PED_MICRO_MORPH` | `void SET_PED_MICRO_MORPH(int ped, int index, float scale)` | void |
| `SET_PED_MIN_GROUND_TIME_FOR_STUNGUN` | `void SET_PED_MIN_GROUND_TIME_FOR_STUNGUN(int ped, int ms)` | void |
| `SET_PED_MIN_MOVE_BLEND_RATIO` | `void SET_PED_MIN_MOVE_BLEND_RATIO(int ped, float value)` | void |
| `SET_PED_MODEL_IS_SUPPRESSED` | `void SET_PED_MODEL_IS_SUPPRESSED(uint modelHash, bool toggle)` | void |
| `SET_PED_MONEY` | `void SET_PED_MONEY(int ped, int amount)` | void |
| `SET_PED_MOTION_BLUR` | `void SET_PED_MOTION_BLUR(int ped, bool toggle)` | void |
| `SET_PED_MOTION_IN_COVER_CLIPSET_OVERRIDE` | `void SET_PED_MOTION_IN_COVER_CLIPSET_OVERRIDE(int ped, string p1)` | void |
| `SET_PED_MOVEMENT_CLIPSET` | `void SET_PED_MOVEMENT_CLIPSET(int ped, string clipSet, float transitionSpeed)` | void |
| `SET_PED_MOVE_ANIMS_BLEND_OUT` | `void SET_PED_MOVE_ANIMS_BLEND_OUT(int ped)` | void |
| `SET_PED_MOVE_RATE_IN_WATER_OVERRIDE` | `void SET_PED_MOVE_RATE_IN_WATER_OVERRIDE(int ped, float p1)` | void |
| `SET_PED_MOVE_RATE_OVERRIDE` | `void SET_PED_MOVE_RATE_OVERRIDE(int ped, float value)` | void |
| `SET_PED_NAME_DEBUG` | `void SET_PED_NAME_DEBUG(int ped, string name)` | void |
| `SET_PED_NEVER_LEAVES_GROUP` | `void SET_PED_NEVER_LEAVES_GROUP(int ped, bool toggle)` | void |
| `SET_PED_NON_CREATION_AREA` | `void SET_PED_NON_CREATION_AREA(float x1, float y1, float z1, float x2, float y2, float z2)` | void |
| `SET_PED_NO_TIME_DELAY_BEFORE_SHOT` | `void SET_PED_NO_TIME_DELAY_BEFORE_SHOT(object p0)` | void |
| `SET_PED_PANIC_EXIT_SCENARIO` | `bool SET_PED_PANIC_EXIT_SCENARIO(object p0, object p1, object p2, object p3)` | bool |
| `SET_PED_PARACHUTE_TINT_INDEX` | `void SET_PED_PARACHUTE_TINT_INDEX(int ped, int tintIndex)` | void |
| `SET_PED_PHONE_PALETTE_IDX` | `void SET_PED_PHONE_PALETTE_IDX(object p0, object p1)` | void |
| `SET_PED_PINNED_DOWN` | `bool SET_PED_PINNED_DOWN(int ped, bool pinned, int i)` | bool |
| `SET_PED_PLAYS_HEAD_ON_HORN_ANIM_WHEN_DIES_IN_VEHICLE` | `void SET_PED_PLAYS_HEAD_ON_HORN_ANIM_WHEN_DIES_IN_VEHICLE(int ped, bool toggle)` | void |
| `SET_PED_PREFERRED_COVER_SET` | `void SET_PED_PREFERRED_COVER_SET(int ped, object itemSet)` | void |
| `SET_PED_PRELOAD_PROP_DATA` | `int SET_PED_PRELOAD_PROP_DATA(int ped, int componentId, int drawableId, int TextureId)` | int |
| `SET_PED_PRELOAD_VARIATION_DATA` | `int SET_PED_PRELOAD_VARIATION_DATA(int ped, int slot, int drawableId, int textureId)` | int |
| `SET_PED_PRIMARY_LOOKAT` | `void SET_PED_PRIMARY_LOOKAT(int ped, int lookAt)` | void |
| `SET_PED_PROP_INDEX` | `void SET_PED_PROP_INDEX(int ped, int componentId, int drawableId, int TextureId, bool attach, object p5)` | void |
| `SET_PED_RAGDOLL_FORCE_FALL` | `void SET_PED_RAGDOLL_FORCE_FALL(int ped)` | void |
| `SET_PED_RAGDOLL_ON_COLLISION` | `void SET_PED_RAGDOLL_ON_COLLISION(int ped, bool toggle)` | void |
| `SET_PED_RANDOM_COMPONENT_VARIATION` | `void SET_PED_RANDOM_COMPONENT_VARIATION(int ped, int p1)` | void |
| `SET_PED_RANDOM_PROPS` | `void SET_PED_RANDOM_PROPS(int ped)` | void |
| `SET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH` | `void SET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH(int ped, uint hash)` | void |
| `SET_PED_RELATIONSHIP_GROUP_HASH` | `void SET_PED_RELATIONSHIP_GROUP_HASH(int ped, uint hash)` | void |
| `SET_PED_RESERVE_PARACHUTE_TINT_INDEX` | `void SET_PED_RESERVE_PARACHUTE_TINT_INDEX(int ped, object p1)` | void |
| `SET_PED_RESET_FLAG` | `void SET_PED_RESET_FLAG(int ped, int flagId, bool doReset)` | void |
| `SET_PED_SCUBA_GEAR_VARIATION` | `void SET_PED_SCUBA_GEAR_VARIATION(int ped)` | void |
| `SET_PED_SEEING_RANGE` | `void SET_PED_SEEING_RANGE(int ped, float value)` | void |
| `SET_PED_SHOOTS_AT_COORD` | `void SET_PED_SHOOTS_AT_COORD(int ped, float x, float y, float z, bool toggle)` | void |
| `SET_PED_SHOOT_RATE` | `void SET_PED_SHOOT_RATE(int ped, int shootRate)` | void |
| `SET_PED_SHOULD_IGNORE_SCENARIO_EXIT_COLLISION_CHECKS` | `void SET_PED_SHOULD_IGNORE_SCENARIO_EXIT_COLLISION_CHECKS(int ped, bool p1)` | void |
| `SET_PED_SHOULD_IGNORE_SCENARIO_NAV_CHECKS` | `void SET_PED_SHOULD_IGNORE_SCENARIO_NAV_CHECKS(object p0, bool p1)` | void |
| `SET_PED_SHOULD_PLAY_DIRECTED_NORMAL_SCENARIO_EXIT` | `bool SET_PED_SHOULD_PLAY_DIRECTED_NORMAL_SCENARIO_EXIT(object p0, object p1, object p2, object p3)` | bool |
| `SET_PED_SHOULD_PLAY_FLEE_SCENARIO_EXIT` | `bool SET_PED_SHOULD_PLAY_FLEE_SCENARIO_EXIT(int ped, object p1, object p2, object p3)` | bool |
| `SET_PED_SHOULD_PLAY_IMMEDIATE_SCENARIO_EXIT` | `void SET_PED_SHOULD_PLAY_IMMEDIATE_SCENARIO_EXIT(int ped)` | void |
| `SET_PED_SHOULD_PLAY_NORMAL_SCENARIO_EXIT` | `void SET_PED_SHOULD_PLAY_NORMAL_SCENARIO_EXIT(int ped)` | void |
| `SET_PED_SHOULD_PROBE_FOR_SCENARIO_EXITS_IN_ONE_FRAME` | `void SET_PED_SHOULD_PROBE_FOR_SCENARIO_EXITS_IN_ONE_FRAME(object p0, bool p1)` | void |
| `SET_PED_SPHERE_DEFENSIVE_AREA` | `void SET_PED_SPHERE_DEFENSIVE_AREA(int ped, float x, float y, float z, float radius, bool p5, bool p6)` | void |
| `SET_PED_STAY_IN_VEHICLE_WHEN_JACKED` | `void SET_PED_STAY_IN_VEHICLE_WHEN_JACKED(int ped, bool toggle)` | void |
| `SET_PED_STEALTH_MOVEMENT` | `void SET_PED_STEALTH_MOVEMENT(int ped, bool p1, string action)` | void |
| `SET_PED_STEERS_AROUND_DEAD_BODIES` | `void SET_PED_STEERS_AROUND_DEAD_BODIES(int ped, bool toggle)` | void |
| `SET_PED_STEERS_AROUND_OBJECTS` | `void SET_PED_STEERS_AROUND_OBJECTS(int ped, bool toggle)` | void |
| `SET_PED_STEERS_AROUND_PEDS` | `void SET_PED_STEERS_AROUND_PEDS(int ped, bool toggle)` | void |
| `SET_PED_STEERS_AROUND_VEHICLES` | `void SET_PED_STEERS_AROUND_VEHICLES(int ped, bool toggle)` | void |
| `SET_PED_STEER_BIAS` | `void SET_PED_STEER_BIAS(int ped, float value)` | void |
| `SET_PED_STRAFE_CLIPSET` | `void SET_PED_STRAFE_CLIPSET(int ped, string clipSet)` | void |
| `SET_PED_SUFFERS_CRITICAL_HITS` | `void SET_PED_SUFFERS_CRITICAL_HITS(int ped, bool toggle)` | void |
| `SET_PED_SWEAT` | `void SET_PED_SWEAT(int ped, float sweat)` | void |
| `SET_PED_TARGET_LOSS_RESPONSE` | `void SET_PED_TARGET_LOSS_RESPONSE(int ped, int responseType)` | void |
| `SET_PED_TO_INFORM_RESPECTED_FRIENDS` | `void SET_PED_TO_INFORM_RESPECTED_FRIENDS(int ped, float radius, int maxFriends)` | void |
| `SET_PED_TO_LOAD_COVER` | `void SET_PED_TO_LOAD_COVER(int ped, bool toggle)` | void |
| `SET_PED_TO_RAGDOLL` | `bool SET_PED_TO_RAGDOLL(int ped, int time1, int time2, int ragdollType, bool p4, bool p5, bool p6)` | bool |
| `SET_PED_TO_RAGDOLL_WITH_FALL` | `bool SET_PED_TO_RAGDOLL_WITH_FALL(int ped, int time, int p2, int ragdollType, float x, float y, float z, float velocity, float p8, float p9, float p10, float p11, float p12, float p13)` | bool |
| `SET_PED_TREATED_AS_FRIENDLY` | `void SET_PED_TREATED_AS_FRIENDLY(object p0, object p1, object p2)` | void |
| `SET_PED_UPPER_BODY_DAMAGE_ONLY` | `void SET_PED_UPPER_BODY_DAMAGE_ONLY(int ped, bool toggle)` | void |
| `SET_PED_USING_ACTION_MODE` | `void SET_PED_USING_ACTION_MODE(int ped, bool p1, int p2, string action)` | void |
| `SET_PED_VEHICLE_FORCED_SEAT_USAGE` | `void SET_PED_VEHICLE_FORCED_SEAT_USAGE(int ped, int vehicle, int seatIndex, int flags, object p4)` | void |
| `SET_PED_VISUAL_FIELD_CENTER_ANGLE` | `void SET_PED_VISUAL_FIELD_CENTER_ANGLE(int ped, float angle)` | void |
| `SET_PED_VISUAL_FIELD_MAX_ANGLE` | `void SET_PED_VISUAL_FIELD_MAX_ANGLE(int ped, float value)` | void |
| `SET_PED_VISUAL_FIELD_MAX_ELEVATION_ANGLE` | `void SET_PED_VISUAL_FIELD_MAX_ELEVATION_ANGLE(int ped, float angle)` | void |
| `SET_PED_VISUAL_FIELD_MIN_ANGLE` | `void SET_PED_VISUAL_FIELD_MIN_ANGLE(int ped, float value)` | void |
| `SET_PED_VISUAL_FIELD_MIN_ELEVATION_ANGLE` | `void SET_PED_VISUAL_FIELD_MIN_ELEVATION_ANGLE(int ped, float angle)` | void |
| `SET_PED_VISUAL_FIELD_PERIPHERAL_RANGE` | `void SET_PED_VISUAL_FIELD_PERIPHERAL_RANGE(int ped, float range)` | void |
| `SET_PED_WEAPON_MOVEMENT_CLIPSET` | `void SET_PED_WEAPON_MOVEMENT_CLIPSET(int ped, string clipSet)` | void |
| `SET_PED_WETNESS` | `void SET_PED_WETNESS(int ped, float wetLevel)` | void |
| `SET_PED_WETNESS_ENABLED_THIS_FRAME` | `void SET_PED_WETNESS_ENABLED_THIS_FRAME(int ped)` | void |
| `SET_PED_WETNESS_HEIGHT` | `void SET_PED_WETNESS_HEIGHT(int ped, float height)` | void |
| `SET_PED_WILL_ONLY_ATTACK_WANTED_PLAYER` | `void SET_PED_WILL_ONLY_ATTACK_WANTED_PLAYER(object p0, object p1)` | void |
| `SET_POP_CONTROL_SPHERE_THIS_FRAME` | `void SET_POP_CONTROL_SPHERE_THIS_FRAME(float x, float y, float z, float min, float max)` | void |
| `SET_RAGDOLL_BLOCKING_FLAGS` | `void SET_RAGDOLL_BLOCKING_FLAGS(int ped, int blockingFlag)` | void |
| `SET_RELATIONSHIP_BETWEEN_GROUPS` | `void SET_RELATIONSHIP_BETWEEN_GROUPS(int relationship, uint group1, uint group2)` | void |
| `SET_RELATIONSHIP_GROUP_AFFECTS_WANTED_LEVEL` | `void SET_RELATIONSHIP_GROUP_AFFECTS_WANTED_LEVEL(uint group, bool p1)` | void |
| `SET_SCENARIO_PEDS_SPAWN_IN_SPHERE_AREA` | `void SET_SCENARIO_PEDS_SPAWN_IN_SPHERE_AREA(float x, float y, float z, float range, int p4)` | void |
| `SET_SCENARIO_PEDS_TO_BE_RETURNED_BY_NEXT_COMMAND` | `void SET_SCENARIO_PEDS_TO_BE_RETURNED_BY_NEXT_COMMAND(bool value)` | void |
| `SET_SCENARIO_PED_DENSITY_MULTIPLIER_THIS_FRAME` | `void SET_SCENARIO_PED_DENSITY_MULTIPLIER_THIS_FRAME(float p0, float p1)` | void |
| `SET_SCRIPTED_ANIM_SEAT_OFFSET` | `void SET_SCRIPTED_ANIM_SEAT_OFFSET(int ped, float p1)` | void |
| `SET_SCRIPTED_CONVERSION_COORD_THIS_FRAME` | `void SET_SCRIPTED_CONVERSION_COORD_THIS_FRAME(float x, float y, float z)` | void |
| `SET_SYNCHRONIZED_SCENE_HOLD_LAST_FRAME` | `void SET_SYNCHRONIZED_SCENE_HOLD_LAST_FRAME(int sceneID, bool toggle)` | void |
| `SET_SYNCHRONIZED_SCENE_LOOPED` | `void SET_SYNCHRONIZED_SCENE_LOOPED(int sceneID, bool toggle)` | void |
| `SET_SYNCHRONIZED_SCENE_ORIGIN` | `void SET_SYNCHRONIZED_SCENE_ORIGIN(int sceneID, float x, float y, float z, float roll, float pitch, float yaw, bool p7)` | void |
| `SET_SYNCHRONIZED_SCENE_PHASE` | `void SET_SYNCHRONIZED_SCENE_PHASE(int sceneID, float phase)` | void |
| `SET_SYNCHRONIZED_SCENE_RATE` | `void SET_SYNCHRONIZED_SCENE_RATE(int sceneID, float rate)` | void |
| `SET_TREAT_AS_AMBIENT_PED_FOR_DRIVER_LOCKON` | `void SET_TREAT_AS_AMBIENT_PED_FOR_DRIVER_LOCKON(int ped, bool p1)` | void |
| `SET_USE_CAMERA_HEADING_FOR_DESIRED_DIRECTION_LOCK_ON_TEST` | `void SET_USE_CAMERA_HEADING_FOR_DESIRED_DIRECTION_LOCK_ON_TEST(int ped, bool toggle)` | void |
| `SPAWNPOINTS_CANCEL_SEARCH` | `void SPAWNPOINTS_CANCEL_SEARCH()` | void |
| `SPAWNPOINTS_GET_NUM_SEARCH_RESULTS` | `int SPAWNPOINTS_GET_NUM_SEARCH_RESULTS()` | int |
| `SPAWNPOINTS_GET_SEARCH_RESULT` | `void SPAWNPOINTS_GET_SEARCH_RESULT(int randomInt, ref float x, ref float y, ref float z)` | void |
| `SPAWNPOINTS_GET_SEARCH_RESULT_FLAGS` | `void SPAWNPOINTS_GET_SEARCH_RESULT_FLAGS(int p0, ref int p1)` | void |
| `SPAWNPOINTS_IS_SEARCH_ACTIVE` | `bool SPAWNPOINTS_IS_SEARCH_ACTIVE()` | bool |
| `SPAWNPOINTS_IS_SEARCH_COMPLETE` | `bool SPAWNPOINTS_IS_SEARCH_COMPLETE()` | bool |
| `SPAWNPOINTS_IS_SEARCH_FAILED` | `bool SPAWNPOINTS_IS_SEARCH_FAILED()` | bool |
| `SPAWNPOINTS_START_SEARCH` | `void SPAWNPOINTS_START_SEARCH(float p0, float p1, float p2, float p3, float p4, int interiorFlags, float scale, int duration)` | void |
| `SPAWNPOINTS_START_SEARCH_IN_ANGLED_AREA` | `void SPAWNPOINTS_START_SEARCH_IN_ANGLED_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float width, int interiorFlags, float scale, int duration)` | void |
| `SPECIAL_FUNCTION_DO_NOT_USE` | `void SPECIAL_FUNCTION_DO_NOT_USE(int ped, bool p1)` | void |
| `STOP_ANY_PED_MODEL_BEING_SUPPRESSED` | `void STOP_ANY_PED_MODEL_BEING_SUPPRESSED()` | void |
| `STOP_PED_WEAPON_FIRING_WHEN_DROPPED` | `void STOP_PED_WEAPON_FIRING_WHEN_DROPPED(int ped)` | void |
| `SUPPRESS_AMBIENT_PED_AGGRESSIVE_CLEANUP_THIS_FRAME` | `void SUPPRESS_AMBIENT_PED_AGGRESSIVE_CLEANUP_THIS_FRAME()` | void |
| `TAKE_OWNERSHIP_OF_SYNCHRONIZED_SCENE` | `void TAKE_OWNERSHIP_OF_SYNCHRONIZED_SCENE(int scene)` | void |
| `TELL_GROUP_PEDS_IN_AREA_TO_ATTACK` | `void TELL_GROUP_PEDS_IN_AREA_TO_ATTACK(int ped, object p1, float p2, uint hash, object p4, object p5)` | void |
| `TOGGLE_SCENARIO_PED_COWER_IN_PLACE` | `void TOGGLE_SCENARIO_PED_COWER_IN_PLACE(int ped, bool toggle)` | void |
| `TRIGGER_IDLE_ANIMATION_ON_PED` | `void TRIGGER_IDLE_ANIMATION_ON_PED(int ped)` | void |
| `TRIGGER_PED_SCENARIO_PANICEXITTOFLEE` | `bool TRIGGER_PED_SCENARIO_PANICEXITTOFLEE(object p0, object p1, object p2, object p3)` | bool |
| `UNREGISTER_PEDHEADSHOT` | `void UNREGISTER_PEDHEADSHOT(int id)` | void |
| `UPDATE_PED_HEAD_BLEND_DATA` | `void UPDATE_PED_HEAD_BLEND_DATA(int ped, float shapeMix, float skinMix, float thirdMix)` | void |
| `WAS_PED_KILLED_BY_STEALTH` | `bool WAS_PED_KILLED_BY_STEALTH(int ped)` | bool |
| `WAS_PED_KILLED_BY_TAKEDOWN` | `bool WAS_PED_KILLED_BY_TAKEDOWN(int ped)` | bool |
| `WAS_PED_KNOCKED_OUT` | `bool WAS_PED_KNOCKED_OUT(int ped)` | bool |
| `WAS_PED_SKELETON_UPDATED` | `bool WAS_PED_SKELETON_UPDATED(int ped)` | bool |
| `_HAS_PED_CLEAR_LOS_TO_ENTITY` | `bool _HAS_PED_CLEAR_LOS_TO_ENTITY(int ped, int entity, float x, float y, float z, int p5, bool p6, bool p7)` | bool |
| `_SET_BLOCK_AMBIENT_PEDS_FROM_DROPPING_WEAPONS_THIS_FRAME` | `void _SET_BLOCK_AMBIENT_PEDS_FROM_DROPPING_WEAPONS_THIS_FRAME()` | void |
| `_SET_PED_SURVIVES_BEING_OUT_OF_WATER` | `bool _SET_PED_SURVIVES_BEING_OUT_OF_WATER(int ped, bool toggle)` | bool |

---

## TASK

| 函数名 | 签名 | 返回值 |
|--------|------|--------|
| `ADD_COVER_BLOCKING_AREA` | `void ADD_COVER_BLOCKING_AREA(float startX, float startY, float startZ, float endX, float endY, float endZ, bool blockObjects, bool blockVehicles, bool blockMap, bool blockPlayer)` | void |
| `ADD_COVER_POINT` | `int ADD_COVER_POINT(float x, float y, float z, float direction, int usage, int height, int arc, bool isPriority)` | int |
| `ADD_PATROL_ROUTE_LINK` | `void ADD_PATROL_ROUTE_LINK(int nodeId1, int nodeId2)` | void |
| `ADD_PATROL_ROUTE_NODE` | `void ADD_PATROL_ROUTE_NODE(int nodeId, string nodeType, float posX, float posY, float posZ, float headingX, float headingY, float headingZ, int duration)` | void |
| `ADD_SCRIPTED_COVER_AREA` | `void ADD_SCRIPTED_COVER_AREA(float x, float y, float z, float radius)` | void |
| `ADD_SCRIPT_TO_RANDOM_PED` | `void ADD_SCRIPT_TO_RANDOM_PED(string name, uint model, float p2, float p3)` | void |
| `ADD_VEHICLE_SUBTASK_ATTACK_COORD` | `void ADD_VEHICLE_SUBTASK_ATTACK_COORD(int ped, float x, float y, float z)` | void |
| `ADD_VEHICLE_SUBTASK_ATTACK_PED` | `void ADD_VEHICLE_SUBTASK_ATTACK_PED(int ped, int target)` | void |
| `ASSISTED_MOVEMENT_IS_ROUTE_LOADED` | `bool ASSISTED_MOVEMENT_IS_ROUTE_LOADED(string route)` | bool |
| `ASSISTED_MOVEMENT_OVERRIDE_LOAD_DISTANCE_THIS_FRAME` | `void ASSISTED_MOVEMENT_OVERRIDE_LOAD_DISTANCE_THIS_FRAME(float dist)` | void |
| `ASSISTED_MOVEMENT_REMOVE_ROUTE` | `void ASSISTED_MOVEMENT_REMOVE_ROUTE(string route)` | void |
| `ASSISTED_MOVEMENT_REQUEST_ROUTE` | `void ASSISTED_MOVEMENT_REQUEST_ROUTE(string route)` | void |
| `ASSISTED_MOVEMENT_SET_ROUTE_PROPERTIES` | `void ASSISTED_MOVEMENT_SET_ROUTE_PROPERTIES(string route, int props)` | void |
| `CLEAR_DEFAULT_PRIMARY_TASK` | `void CLEAR_DEFAULT_PRIMARY_TASK(int ped)` | void |
| `CLEAR_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK` | `void CLEAR_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK(int ped)` | void |
| `CLEAR_PED_SCRIPT_TASK_IF_RUNNING_THREAT_RESPONSE_NON_TEMP_TASK` | `void CLEAR_PED_SCRIPT_TASK_IF_RUNNING_THREAT_RESPONSE_NON_TEMP_TASK(int ped)` | void |
| `CLEAR_PED_SECONDARY_TASK` | `void CLEAR_PED_SECONDARY_TASK(int ped)` | void |
| `CLEAR_PED_TASKS` | `void CLEAR_PED_TASKS(int ped)` | void |
| `CLEAR_PED_TASKS_IMMEDIATELY` | `void CLEAR_PED_TASKS_IMMEDIATELY(int ped)` | void |
| `CLEAR_PRIMARY_VEHICLE_TASK` | `void CLEAR_PRIMARY_VEHICLE_TASK(int vehicle)` | void |
| `CLEAR_SEQUENCE_TASK` | `void CLEAR_SEQUENCE_TASK(ref int taskSequenceId)` | void |
| `CLEAR_VEHICLE_CRASH_TASK` | `void CLEAR_VEHICLE_CRASH_TASK(int vehicle)` | void |
| `CLOSE_PATROL_ROUTE` | `void CLOSE_PATROL_ROUTE()` | void |
| `CLOSE_SEQUENCE_TASK` | `void CLOSE_SEQUENCE_TASK(int taskSequenceId)` | void |
| `CONTROL_MOUNTED_WEAPON` | `bool CONTROL_MOUNTED_WEAPON(int ped)` | bool |
| `CREATE_PATROL_ROUTE` | `void CREATE_PATROL_ROUTE()` | void |
| `DELETE_PATROL_ROUTE` | `void DELETE_PATROL_ROUTE(string patrolRoute)` | void |
| `DISABLE_SCRIPT_BRAIN_SET` | `void DISABLE_SCRIPT_BRAIN_SET(int brainSet)` | void |
| `DOES_SCENARIO_EXIST_IN_AREA` | `bool DOES_SCENARIO_EXIST_IN_AREA(float x, float y, float z, float radius, bool mustBeFree)` | bool |
| `DOES_SCENARIO_GROUP_EXIST` | `bool DOES_SCENARIO_GROUP_EXIST(string scenarioGroup)` | bool |
| `DOES_SCENARIO_OF_TYPE_EXIST_IN_AREA` | `bool DOES_SCENARIO_OF_TYPE_EXIST_IN_AREA(float x, float y, float z, string scenarioName, float radius, bool mustBeFree)` | bool |
| `DOES_SCRIPTED_COVER_POINT_EXIST_AT_COORDS` | `bool DOES_SCRIPTED_COVER_POINT_EXIST_AT_COORDS(float x, float y, float z)` | bool |
| `ENABLE_SCRIPT_BRAIN_SET` | `void ENABLE_SCRIPT_BRAIN_SET(int brainSet)` | void |
| `GET_ACTIVE_VEHICLE_MISSION_TYPE` | `int GET_ACTIVE_VEHICLE_MISSION_TYPE(int vehicle)` | int |
| `GET_CLIP_SET_FOR_SCRIPTED_GUN_TASK` | `string GET_CLIP_SET_FOR_SCRIPTED_GUN_TASK(int gunTaskType)` | string |
| `GET_IS_TASK_ACTIVE` | `bool GET_IS_TASK_ACTIVE(int ped, int taskIndex)` | bool |
| `GET_IS_WAYPOINT_RECORDING_LOADED` | `bool GET_IS_WAYPOINT_RECORDING_LOADED(string name)` | bool |
| `GET_NAVMESH_ROUTE_DISTANCE_REMAINING` | `int GET_NAVMESH_ROUTE_DISTANCE_REMAINING(int ped, ref float distanceRemaining, ref bool isPathReady)` | int |
| `GET_NAVMESH_ROUTE_RESULT` | `int GET_NAVMESH_ROUTE_RESULT(int ped)` | int |
| `GET_PATROL_TASK_INFO` | `bool GET_PATROL_TASK_INFO(int ped, ref int timeLeftAtNode, ref int nodeId)` | bool |
| `GET_PED_DESIRED_MOVE_BLEND_RATIO` | `float GET_PED_DESIRED_MOVE_BLEND_RATIO(int ped)` | float |
| `GET_PED_WAYPOINT_DISTANCE` | `float GET_PED_WAYPOINT_DISTANCE(object p0)` | float |
| `GET_PED_WAYPOINT_PROGRESS` | `int GET_PED_WAYPOINT_PROGRESS(int ped)` | int |
| `GET_PHONE_GESTURE_ANIM_CURRENT_TIME` | `float GET_PHONE_GESTURE_ANIM_CURRENT_TIME(int ped)` | float |
| `GET_PHONE_GESTURE_ANIM_TOTAL_TIME` | `float GET_PHONE_GESTURE_ANIM_TOTAL_TIME(int ped)` | float |
| `GET_SCRIPTED_COVER_POINT_COORDS` | `Vector3 GET_SCRIPTED_COVER_POINT_COORDS(int coverpoint)` | Vector3 |
| `GET_SCRIPT_TASK_STATUS` | `int GET_SCRIPT_TASK_STATUS(int ped, uint taskHash)` | int |
| `GET_SEQUENCE_PROGRESS` | `int GET_SEQUENCE_PROGRESS(int ped)` | int |
| `GET_TASK_MOVE_NETWORK_EVENT` | `bool GET_TASK_MOVE_NETWORK_EVENT(int ped, string eventName)` | bool |
| `GET_TASK_MOVE_NETWORK_SIGNAL_BOOL` | `bool GET_TASK_MOVE_NETWORK_SIGNAL_BOOL(int ped, string signalName)` | bool |
| `GET_TASK_MOVE_NETWORK_SIGNAL_FLOAT` | `float GET_TASK_MOVE_NETWORK_SIGNAL_FLOAT(int ped, string signalName)` | float |
| `GET_TASK_MOVE_NETWORK_STATE` | `string GET_TASK_MOVE_NETWORK_STATE(int ped)` | string |
| `GET_TASK_RAPPEL_DOWN_WALL_STATE` | `int GET_TASK_RAPPEL_DOWN_WALL_STATE(int ped)` | int |
| `GET_VEHICLE_WAYPOINT_PROGRESS` | `int GET_VEHICLE_WAYPOINT_PROGRESS(int vehicle)` | int |
| `GET_VEHICLE_WAYPOINT_TARGET_POINT` | `int GET_VEHICLE_WAYPOINT_TARGET_POINT(int vehicle)` | int |
| `GET_WAYPOINT_DISTANCE_ALONG_ROUTE` | `float GET_WAYPOINT_DISTANCE_ALONG_ROUTE(string name, int point)` | float |
| `IS_CONTROLLED_VEHICLE_UNABLE_TO_GET_TO_ROAD` | `bool IS_CONTROLLED_VEHICLE_UNABLE_TO_GET_TO_ROAD(int ped)` | bool |
| `IS_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK` | `bool IS_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK(int ped)` | bool |
| `IS_MOUNTED_WEAPON_TASK_UNDERNEATH_DRIVING_TASK` | `bool IS_MOUNTED_WEAPON_TASK_UNDERNEATH_DRIVING_TASK(int ped)` | bool |
| `IS_MOVE_BLEND_RATIO_RUNNING` | `bool IS_MOVE_BLEND_RATIO_RUNNING(int ped)` | bool |
| `IS_MOVE_BLEND_RATIO_SPRINTING` | `bool IS_MOVE_BLEND_RATIO_SPRINTING(int ped)` | bool |
| `IS_MOVE_BLEND_RATIO_STILL` | `bool IS_MOVE_BLEND_RATIO_STILL(int ped)` | bool |
| `IS_MOVE_BLEND_RATIO_WALKING` | `bool IS_MOVE_BLEND_RATIO_WALKING(int ped)` | bool |
| `IS_OBJECT_WITHIN_BRAIN_ACTIVATION_RANGE` | `bool IS_OBJECT_WITHIN_BRAIN_ACTIVATION_RANGE(int object)` | bool |
| `IS_PED_ACTIVE_IN_SCENARIO` | `bool IS_PED_ACTIVE_IN_SCENARIO(int ped)` | bool |
| `IS_PED_BEING_ARRESTED` | `bool IS_PED_BEING_ARRESTED(int ped)` | bool |
| `IS_PED_CUFFED` | `bool IS_PED_CUFFED(int ped)` | bool |
| `IS_PED_GETTING_UP` | `bool IS_PED_GETTING_UP(int ped)` | bool |
| `IS_PED_IN_WRITHE` | `bool IS_PED_IN_WRITHE(int ped)` | bool |
| `IS_PED_PLAYING_BASE_CLIP_IN_SCENARIO` | `bool IS_PED_PLAYING_BASE_CLIP_IN_SCENARIO(int ped)` | bool |
| `IS_PED_RUNNING` | `bool IS_PED_RUNNING(int ped)` | bool |
| `IS_PED_RUNNING_ARREST_TASK` | `bool IS_PED_RUNNING_ARREST_TASK(int ped)` | bool |
| `IS_PED_SPRINTING` | `bool IS_PED_SPRINTING(int ped)` | bool |
| `IS_PED_STILL` | `bool IS_PED_STILL(int ped)` | bool |
| `IS_PED_STRAFING` | `bool IS_PED_STRAFING(int ped)` | bool |
| `IS_PED_WALKING` | `bool IS_PED_WALKING(int ped)` | bool |
| `IS_PLAYING_PHONE_GESTURE_ANIM` | `bool IS_PLAYING_PHONE_GESTURE_ANIM(int ped)` | bool |
| `IS_SCENARIO_GROUP_ENABLED` | `bool IS_SCENARIO_GROUP_ENABLED(string scenarioGroup)` | bool |
| `IS_SCENARIO_OCCUPIED` | `bool IS_SCENARIO_OCCUPIED(float x, float y, float z, float maxRange, bool onlyUsersActuallyAtScenario)` | bool |
| `IS_SCENARIO_TYPE_ENABLED` | `bool IS_SCENARIO_TYPE_ENABLED(string scenarioType)` | bool |
| `IS_TASK_MOVE_NETWORK_ACTIVE` | `bool IS_TASK_MOVE_NETWORK_ACTIVE(int ped)` | bool |
| `IS_TASK_MOVE_NETWORK_READY_FOR_TRANSITION` | `bool IS_TASK_MOVE_NETWORK_READY_FOR_TRANSITION(int ped)` | bool |
| `IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_PED` | `bool IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_PED(int ped)` | bool |
| `IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_VEHICLE` | `bool IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_VEHICLE(int vehicle)` | bool |
| `IS_WORLD_POINT_WITHIN_BRAIN_ACTIVATION_RANGE` | `bool IS_WORLD_POINT_WITHIN_BRAIN_ACTIVATION_RANGE()` | bool |
| `OPEN_PATROL_ROUTE` | `void OPEN_PATROL_ROUTE(string patrolRoute)` | void |
| `OPEN_SEQUENCE_TASK` | `void OPEN_SEQUENCE_TASK(ref int taskSequenceId)` | void |
| `PED_HAS_USE_SCENARIO_TASK` | `bool PED_HAS_USE_SCENARIO_TASK(int ped)` | bool |
| `PLAY_ANIM_ON_RUNNING_SCENARIO` | `void PLAY_ANIM_ON_RUNNING_SCENARIO(int ped, string animDict, string animName)` | void |
| `PLAY_ENTITY_SCRIPTED_ANIM` | `void PLAY_ENTITY_SCRIPTED_ANIM(int entity, ref int priorityLowData, ref int priorityMidData, ref int priorityHighData, float blendInDelta, float blendOutDelta)` | void |
| `REACTIVATE_ALL_OBJECT_BRAINS_THAT_ARE_WAITING_TILL_OUT_OF_RANGE` | `void REACTIVATE_ALL_OBJECT_BRAINS_THAT_ARE_WAITING_TILL_OUT_OF_RANGE()` | void |
| `REACTIVATE_ALL_WORLD_BRAINS_THAT_ARE_WAITING_TILL_OUT_OF_RANGE` | `void REACTIVATE_ALL_WORLD_BRAINS_THAT_ARE_WAITING_TILL_OUT_OF_RANGE()` | void |
| `REACTIVATE_NAMED_OBJECT_BRAINS_WAITING_TILL_OUT_OF_RANGE` | `void REACTIVATE_NAMED_OBJECT_BRAINS_WAITING_TILL_OUT_OF_RANGE(string scriptName)` | void |
| `REACTIVATE_NAMED_WORLD_BRAINS_WAITING_TILL_OUT_OF_RANGE` | `void REACTIVATE_NAMED_WORLD_BRAINS_WAITING_TILL_OUT_OF_RANGE(string scriptName)` | void |
| `REGISTER_OBJECT_SCRIPT_BRAIN` | `void REGISTER_OBJECT_SCRIPT_BRAIN(string scriptName, uint modelHash, int p2, float activationRange, int p4, int p5)` | void |
| `REGISTER_WORLD_POINT_SCRIPT_BRAIN` | `void REGISTER_WORLD_POINT_SCRIPT_BRAIN(string scriptName, float activationRange, int p2)` | void |
| `REMOVE_ALL_COVER_BLOCKING_AREAS` | `void REMOVE_ALL_COVER_BLOCKING_AREAS()` | void |
| `REMOVE_COVER_BLOCKING_AREAS_AT_POSITION` | `void REMOVE_COVER_BLOCKING_AREAS_AT_POSITION(float x, float y, float z)` | void |
| `REMOVE_COVER_POINT` | `void REMOVE_COVER_POINT(int coverpoint)` | void |
| `REMOVE_SPECIFIC_COVER_BLOCKING_AREAS` | `void REMOVE_SPECIFIC_COVER_BLOCKING_AREAS(float startX, float startY, float startZ, float endX, float endY, float endZ, bool blockObjects, bool blockVehicles, bool blockMap, bool blockPlayer)` | void |
| `REMOVE_WAYPOINT_RECORDING` | `void REMOVE_WAYPOINT_RECORDING(string name)` | void |
| `REQUEST_TASK_MOVE_NETWORK_STATE_TRANSITION` | `bool REQUEST_TASK_MOVE_NETWORK_STATE_TRANSITION(int ped, string name)` | bool |
| `REQUEST_WAYPOINT_RECORDING` | `void REQUEST_WAYPOINT_RECORDING(string name)` | void |
| `RESET_EXCLUSIVE_SCENARIO_GROUP` | `void RESET_EXCLUSIVE_SCENARIO_GROUP()` | void |
| `RESET_SCENARIO_GROUPS_ENABLED` | `void RESET_SCENARIO_GROUPS_ENABLED()` | void |
| `RESET_SCENARIO_TYPES_ENABLED` | `void RESET_SCENARIO_TYPES_ENABLED()` | void |
| `SET_ANIM_LOOPED` | `void SET_ANIM_LOOPED(int entity, bool looped, int priority, bool secondary)` | void |
| `SET_ANIM_PHASE` | `void SET_ANIM_PHASE(int entity, float phase, int priority, bool secondary)` | void |
| `SET_ANIM_RATE` | `void SET_ANIM_RATE(int entity, float rate, int priority, bool secondary)` | void |
| `SET_ANIM_WEIGHT` | `void SET_ANIM_WEIGHT(int entity, float weight, int priority, int index, bool secondary)` | void |
| `SET_DRIVEBY_TASK_TARGET` | `void SET_DRIVEBY_TASK_TARGET(int shootingPed, int targetPed, int targetVehicle, float x, float y, float z)` | void |
| `SET_DRIVE_TASK_CRUISE_SPEED` | `void SET_DRIVE_TASK_CRUISE_SPEED(int driver, float cruiseSpeed)` | void |
| `SET_DRIVE_TASK_DRIVING_STYLE` | `void SET_DRIVE_TASK_DRIVING_STYLE(int ped, int drivingStyle)` | void |
| `SET_DRIVE_TASK_MAX_CRUISE_SPEED` | `void SET_DRIVE_TASK_MAX_CRUISE_SPEED(int ped, float speed, bool updateBaseTask)` | void |
| `SET_EXCLUSIVE_SCENARIO_GROUP` | `void SET_EXCLUSIVE_SCENARIO_GROUP(string scenarioGroup)` | void |
| `SET_EXPECTED_CLONE_NEXT_TASK_MOVE_NETWORK_STATE` | `bool SET_EXPECTED_CLONE_NEXT_TASK_MOVE_NETWORK_STATE(int ped, string state)` | bool |
| `SET_GLOBAL_MIN_BIRD_FLIGHT_HEIGHT` | `void SET_GLOBAL_MIN_BIRD_FLIGHT_HEIGHT(float height)` | void |
| `SET_HIGH_FALL_TASK` | `void SET_HIGH_FALL_TASK(int ped, int minTime, int maxTime, int entryType)` | void |
| `SET_MOUNTED_WEAPON_TARGET` | `void SET_MOUNTED_WEAPON_TARGET(int shootingPed, int targetPed, int targetVehicle, float x, float y, float z, int taskMode, bool ignoreTargetVehDeadCheck)` | void |
| `SET_NEXT_DESIRED_MOVE_STATE` | `void SET_NEXT_DESIRED_MOVE_STATE(float nextMoveState)` | void |
| `SET_PARACHUTE_TASK_TARGET` | `void SET_PARACHUTE_TASK_TARGET(int ped, float x, float y, float z)` | void |
| `SET_PARACHUTE_TASK_THRUST` | `void SET_PARACHUTE_TASK_THRUST(int ped, float thrust)` | void |
| `SET_PED_CAN_PLAY_AMBIENT_IDLES` | `void SET_PED_CAN_PLAY_AMBIENT_IDLES(int ped, bool blockIdleClips, bool removeIdleClipIfPlaying)` | void |
| `SET_PED_DESIRED_MOVE_BLEND_RATIO` | `void SET_PED_DESIRED_MOVE_BLEND_RATIO(int ped, float newMoveBlendRatio)` | void |
| `SET_PED_PATH_AVOID_FIRE` | `void SET_PED_PATH_AVOID_FIRE(int ped, bool avoidFire)` | void |
| `SET_PED_PATH_CAN_DROP_FROM_HEIGHT` | `void SET_PED_PATH_CAN_DROP_FROM_HEIGHT(int ped, bool Toggle)` | void |
| `SET_PED_PATH_CAN_USE_CLIMBOVERS` | `void SET_PED_PATH_CAN_USE_CLIMBOVERS(int ped, bool Toggle)` | void |
| `SET_PED_PATH_CAN_USE_LADDERS` | `void SET_PED_PATH_CAN_USE_LADDERS(int ped, bool Toggle)` | void |
| `SET_PED_PATH_CLIMB_COST_MODIFIER` | `void SET_PED_PATH_CLIMB_COST_MODIFIER(int ped, float modifier)` | void |
| `SET_PED_PATH_MAY_ENTER_WATER` | `void SET_PED_PATH_MAY_ENTER_WATER(int ped, bool mayEnterWater)` | void |
| `SET_PED_PATH_PREFER_TO_AVOID_WATER` | `void SET_PED_PATH_PREFER_TO_AVOID_WATER(int ped, bool avoidWater)` | void |
| `SET_PED_WAYPOINT_PROGRESS` | `void SET_PED_WAYPOINT_PROGRESS(int ped, int progress)` | void |
| `SET_PED_WAYPOINT_ROUTE_OFFSET` | `bool SET_PED_WAYPOINT_ROUTE_OFFSET(int ped, float x, float y, float z)` | bool |
| `SET_SCENARIO_GROUP_ENABLED` | `void SET_SCENARIO_GROUP_ENABLED(string scenarioGroup, bool enabled)` | void |
| `SET_SCENARIO_TYPE_ENABLED` | `void SET_SCENARIO_TYPE_ENABLED(string scenarioType, bool toggle)` | void |
| `SET_SEQUENCE_PREVENT_MIGRATION` | `void SET_SEQUENCE_PREVENT_MIGRATION(int taskSequenceId)` | void |
| `SET_SEQUENCE_TO_REPEAT` | `void SET_SEQUENCE_TO_REPEAT(int taskSequenceId, bool repeat)` | void |
| `SET_TASK_MOVE_NETWORK_ANIM_SET` | `void SET_TASK_MOVE_NETWORK_ANIM_SET(int ped, uint clipSet, uint variableClipSet)` | void |
| `SET_TASK_MOVE_NETWORK_ENABLE_COLLISION_ON_NETWORK_CLONE_WHEN_FIXED` | `bool SET_TASK_MOVE_NETWORK_ENABLE_COLLISION_ON_NETWORK_CLONE_WHEN_FIXED(int ped, bool enable)` | bool |
| `SET_TASK_MOVE_NETWORK_SIGNAL_BOOL` | `void SET_TASK_MOVE_NETWORK_SIGNAL_BOOL(int ped, string signalName, bool value)` | void |
| `SET_TASK_MOVE_NETWORK_SIGNAL_FLOAT` | `void SET_TASK_MOVE_NETWORK_SIGNAL_FLOAT(int ped, string signalName, float value)` | void |
| `SET_TASK_MOVE_NETWORK_SIGNAL_FLOAT_LERP_RATE` | `void SET_TASK_MOVE_NETWORK_SIGNAL_FLOAT_LERP_RATE(int ped, string signalName, float value)` | void |
| `SET_TASK_MOVE_NETWORK_SIGNAL_LOCAL_FLOAT` | `void SET_TASK_MOVE_NETWORK_SIGNAL_LOCAL_FLOAT(int ped, string signalName, float value)` | void |
| `SET_TASK_VEHICLE_CHASE_BEHAVIOR_FLAG` | `void SET_TASK_VEHICLE_CHASE_BEHAVIOR_FLAG(int ped, int flag, bool set)` | void |
| `SET_TASK_VEHICLE_CHASE_IDEAL_PURSUIT_DISTANCE` | `void SET_TASK_VEHICLE_CHASE_IDEAL_PURSUIT_DISTANCE(int ped, float distance)` | void |
| `STOP_ANIM_PLAYBACK` | `void STOP_ANIM_PLAYBACK(int entity, int priority, bool secondary)` | void |
| `STOP_ANIM_TASK` | `void STOP_ANIM_TASK(int entity, string animDictionary, string animationName, float blendDelta)` | void |
| `TASK_ACHIEVE_HEADING` | `void TASK_ACHIEVE_HEADING(int ped, float heading, int timeout)` | void |
| `TASK_AGITATED_ACTION_CONFRONT_RESPONSE` | `void TASK_AGITATED_ACTION_CONFRONT_RESPONSE(int ped, int ped2)` | void |
| `TASK_AIM_GUN_AT_COORD` | `void TASK_AIM_GUN_AT_COORD(int ped, float x, float y, float z, int time, bool instantBlendToAim, bool playAnimIntro)` | void |
| `TASK_AIM_GUN_AT_ENTITY` | `void TASK_AIM_GUN_AT_ENTITY(int ped, int entity, int duration, bool instantBlendToAim)` | void |
| `TASK_AIM_GUN_SCRIPTED` | `void TASK_AIM_GUN_SCRIPTED(int ped, uint scriptTask, bool disableBlockingClip, bool instantBlendToAim)` | void |
| `TASK_AIM_GUN_SCRIPTED_WITH_TARGET` | `void TASK_AIM_GUN_SCRIPTED_WITH_TARGET(int ped, int target, float x, float y, float z, int gunTaskType, bool disableBlockingClip, bool forceAim)` | void |
| `TASK_ARREST_PED` | `void TASK_ARREST_PED(int ped, int target)` | void |
| `TASK_BOAT_MISSION` | `void TASK_BOAT_MISSION(int pedDriver, int vehicle, int targetVehicle, int targetPed, float x, float y, float z, int mission, float maxSpeed, int drivingStyle, float targetReached, object boatFlags)` | void |
| `TASK_CHAT_TO_PED` | `void TASK_CHAT_TO_PED(int ped, int target, int flags, float goToLocationX, float goToLocationY, float goToLocationZ, float headingDegs, float idleTime)` | void |
| `TASK_CLEAR_DEFENSIVE_AREA` | `void TASK_CLEAR_DEFENSIVE_AREA(int ped)` | void |
| `TASK_CLEAR_LOOK_AT` | `void TASK_CLEAR_LOOK_AT(int ped)` | void |
| `TASK_CLIMB` | `void TASK_CLIMB(int ped, bool usePlayerLaunchForce)` | void |
| `TASK_CLIMB_LADDER` | `void TASK_CLIMB_LADDER(int ped, bool fast)` | void |
| `TASK_COMBAT_HATED_TARGETS_AROUND_PED` | `void TASK_COMBAT_HATED_TARGETS_AROUND_PED(int ped, float radius, int combatFlags)` | void |
| `TASK_COMBAT_HATED_TARGETS_AROUND_PED_TIMED` | `void TASK_COMBAT_HATED_TARGETS_AROUND_PED_TIMED(int ped, float radius, int time, int combatFlags)` | void |
| `TASK_COMBAT_HATED_TARGETS_IN_AREA` | `void TASK_COMBAT_HATED_TARGETS_IN_AREA(int ped, float x, float y, float z, float radius, int combatFlags)` | void |
| `TASK_COMBAT_PED` | `void TASK_COMBAT_PED(int ped, int targetPed, int combatFlags, int threatResponseFlags)` | void |
| `TASK_COMBAT_PED_TIMED` | `void TASK_COMBAT_PED_TIMED(int ped, int target, int time, int flags)` | void |
| `TASK_COWER` | `void TASK_COWER(int ped, int duration)` | void |
| `TASK_DRIVE_BY` | `void TASK_DRIVE_BY(int driverPed, int targetPed, int targetVehicle, float targetX, float targetY, float targetZ, float distanceToShoot, int pedAccuracy, bool pushUnderneathDrivingTaskIfDriving, uint firingPattern)` | void |
| `TASK_ENTER_VEHICLE` | `void TASK_ENTER_VEHICLE(int ped, int vehicle, int timeout, int seat, float speed, int flag, string overrideEntryClipsetName)` | void |
| `TASK_EVERYONE_LEAVE_VEHICLE` | `void TASK_EVERYONE_LEAVE_VEHICLE(int vehicle)` | void |
| `TASK_EXIT_COVER` | `void TASK_EXIT_COVER(int ped, int exitType, float x, float y, float z)` | void |
| `TASK_EXTEND_ROUTE` | `void TASK_EXTEND_ROUTE(float x, float y, float z)` | void |
| `TASK_FLUSH_ROUTE` | `void TASK_FLUSH_ROUTE()` | void |
| `TASK_FOLLOW_NAV_MESH_TO_COORD` | `void TASK_FOLLOW_NAV_MESH_TO_COORD(int ped, float x, float y, float z, float moveBlendRatio, int time, float targetRadius, int flags, float targetHeading)` | void |
| `TASK_FOLLOW_NAV_MESH_TO_COORD_ADVANCED` | `void TASK_FOLLOW_NAV_MESH_TO_COORD_ADVANCED(int ped, float x, float y, float z, float moveBlendRatio, int time, float targetRadius, int flags, float slideToCoordHeading, float maxSlopeNavigable, float clampMaxSearchDistance, float targetHeading)` | void |
| `TASK_FOLLOW_POINT_ROUTE` | `void TASK_FOLLOW_POINT_ROUTE(int ped, float speed, int mode)` | void |
| `TASK_FOLLOW_TO_OFFSET_OF_ENTITY` | `void TASK_FOLLOW_TO_OFFSET_OF_ENTITY(int ped, int entity, float offsetX, float offsetY, float offsetZ, float movementSpeed, int timeout, float stoppingRange, bool persistFollowing)` | void |
| `TASK_FOLLOW_WAYPOINT_RECORDING` | `void TASK_FOLLOW_WAYPOINT_RECORDING(int ped, string name, int p2, int p3, int p4)` | void |
| `TASK_FORCE_MOTION_STATE` | `void TASK_FORCE_MOTION_STATE(int ped, uint state, bool forceRestart)` | void |
| `TASK_GET_OFF_BOAT` | `void TASK_GET_OFF_BOAT(int ped, int boat)` | void |
| `TASK_GOTO_ENTITY_AIMING` | `void TASK_GOTO_ENTITY_AIMING(int ped, int target, float distanceToStopAt, float StartAimingDist)` | void |
| `TASK_GOTO_ENTITY_OFFSET` | `void TASK_GOTO_ENTITY_OFFSET(int ped, int entity, int time, float seekRadius, float seekAngleDeg, float moveBlendRatio, int gotoEntityOffsetFlags)` | void |
| `TASK_GOTO_ENTITY_OFFSET_XY` | `void TASK_GOTO_ENTITY_OFFSET_XY(int ped, int entity, int duration, float targetRadius, float offsetX, float offsetY, float moveBlendRatio, int gotoEntityOffsetFlags)` | void |
| `TASK_GO_STRAIGHT_TO_COORD` | `void TASK_GO_STRAIGHT_TO_COORD(int ped, float x, float y, float z, float speed, int timeout, float targetHeading, float distanceToSlide)` | void |
| `TASK_GO_STRAIGHT_TO_COORD_RELATIVE_TO_ENTITY` | `void TASK_GO_STRAIGHT_TO_COORD_RELATIVE_TO_ENTITY(int ped, int entity, float x, float y, float z, float moveBlendRatio, int time)` | void |
| `TASK_GO_TO_COORD_AND_AIM_AT_HATED_ENTITIES_NEAR_COORD` | `void TASK_GO_TO_COORD_AND_AIM_AT_HATED_ENTITIES_NEAR_COORD(int pedHandle, float goToLocationX, float goToLocationY, float goToLocationZ, float focusLocationX, float focusLocationY, float focusLocationZ, float speed, bool shootAtEnemies, float distanceToStopAt, float noRoadsDistance, bool useNavMesh, int navFlags, int taskFlags, uint firingPattern)` | void |
| `TASK_GO_TO_COORD_ANY_MEANS` | `void TASK_GO_TO_COORD_ANY_MEANS(int ped, float x, float y, float z, float moveBlendRatio, int vehicle, bool useLongRangeVehiclePathing, int drivingFlags, float maxRangeToShootTargets)` | void |
| `TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS` | `void TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS(int ped, float x, float y, float z, float moveBlendRatio, int vehicle, bool useLongRangeVehiclePathing, int drivingFlags, float maxRangeToShootTargets, float extraVehToTargetDistToPreferVehicle, float driveStraightLineDistance, int extraFlags, float warpTimerMS)` | void |
| `TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS_WITH_CRUISE_SPEED` | `void TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS_WITH_CRUISE_SPEED(int ped, float x, float y, float z, float moveBlendRatio, int vehicle, bool useLongRangeVehiclePathing, int drivingFlags, float maxRangeToShootTargets, float extraVehToTargetDistToPreferVehicle, float driveStraightLineDistance, int extraFlags, float cruiseSpeed, float targetArriveDist)` | void |
| `TASK_GO_TO_COORD_WHILE_AIMING_AT_COORD` | `void TASK_GO_TO_COORD_WHILE_AIMING_AT_COORD(int ped, float x, float y, float z, float aimAtX, float aimAtY, float aimAtZ, float moveBlendRatio, bool shoot, float targetRadius, float slowDistance, bool useNavMesh, int navFlags, bool instantBlendToAim, uint firingPattern)` | void |
| `TASK_GO_TO_COORD_WHILE_AIMING_AT_ENTITY` | `void TASK_GO_TO_COORD_WHILE_AIMING_AT_ENTITY(int ped, float x, float y, float z, int aimAtID, float moveBlendRatio, bool shoot, float targetRadius, float slowDistance, bool useNavMesh, int navFlags, bool instantBlendToAim, uint firingPattern, int time)` | void |
| `TASK_GO_TO_ENTITY` | `void TASK_GO_TO_ENTITY(int entity, int target, int duration, float distance, float moveBlendRatio, float slowDownDistance, int flags)` | void |
| `TASK_GO_TO_ENTITY_WHILE_AIMING_AT_COORD` | `void TASK_GO_TO_ENTITY_WHILE_AIMING_AT_COORD(int ped, int entity, float aimX, float aimY, float aimZ, float moveBlendRatio, bool shoot, float targetRadius, float slowDistance, bool useNavMesh, bool instantBlendToAim, uint firingPattern)` | void |
| `TASK_GO_TO_ENTITY_WHILE_AIMING_AT_ENTITY` | `void TASK_GO_TO_ENTITY_WHILE_AIMING_AT_ENTITY(int ped, int entityToWalkTo, int entityToAimAt, float speed, bool shootatEntity, float targetRadius, float slowDistance, bool useNavMesh, bool instantBlendToAim, uint firingPattern)` | void |
| `TASK_GUARD_ASSIGNED_DEFENSIVE_AREA` | `void TASK_GUARD_ASSIGNED_DEFENSIVE_AREA(int ped, float x, float y, float z, float heading, float maxPatrolProximity, int timer)` | void |
| `TASK_GUARD_CURRENT_POSITION` | `void TASK_GUARD_CURRENT_POSITION(int ped, float maxPatrolProximity, float defensiveAreaRadius, bool setDefensiveArea)` | void |
| `TASK_GUARD_SPHERE_DEFENSIVE_AREA` | `void TASK_GUARD_SPHERE_DEFENSIVE_AREA(int ped, float defendPositionX, float defendPositionY, float defendPositionZ, float heading, float maxPatrolProximity, int time, float x, float y, float z, float defensiveAreaRadius)` | void |
| `TASK_HANDS_UP` | `void TASK_HANDS_UP(int ped, int duration, int facingPed, int timeToFacePed, int flags)` | void |
| `TASK_HELI_CHASE` | `void TASK_HELI_CHASE(int pilot, int entityToFollow, float x, float y, float z)` | void |
| `TASK_HELI_ESCORT_HELI` | `void TASK_HELI_ESCORT_HELI(int pilot, int heli1, int heli2, float offsetX, float offsetY, float offsetZ)` | void |
| `TASK_HELI_MISSION` | `void TASK_HELI_MISSION(int pilot, int aircraft, int targetVehicle, int targetPed, float destinationX, float destinationY, float destinationZ, int missionFlag, float maxSpeed, float radius, float targetHeading, int maxHeight, int minHeight, float slowDownDistance, int behaviorFlags)` | void |
| `TASK_JUMP` | `void TASK_JUMP(int ped, bool usePlayerLaunchForce, bool doSuperJump, bool useFullSuperJumpForce)` | void |
| `TASK_LEAVE_ANY_VEHICLE` | `void TASK_LEAVE_ANY_VEHICLE(int ped, int delayTime, int flags)` | void |
| `TASK_LEAVE_VEHICLE` | `void TASK_LEAVE_VEHICLE(int ped, int vehicle, int flags)` | void |
| `TASK_LOOK_AT_COORD` | `void TASK_LOOK_AT_COORD(int entity, float x, float y, float z, int duration, int flags, int priority)` | void |
| `TASK_LOOK_AT_ENTITY` | `void TASK_LOOK_AT_ENTITY(int ped, int lookAt, int duration, int flags, int priority)` | void |
| `TASK_MOVE_NETWORK_ADVANCED_BY_NAME` | `void TASK_MOVE_NETWORK_ADVANCED_BY_NAME(int ped, string network, float x, float y, float z, float rotX, float rotY, float rotZ, int rotOrder, float blendDuration, bool allowOverrideCloneUpdate, string animDict, int flags)` | void |
| `TASK_MOVE_NETWORK_ADVANCED_BY_NAME_WITH_INIT_PARAMS` | `void TASK_MOVE_NETWORK_ADVANCED_BY_NAME_WITH_INIT_PARAMS(int ped, string network, ref int initialParameters, float x, float y, float z, float rotX, float rotY, float rotZ, int rotOrder, float blendDuration, bool allowOverrideCloneUpdate, string dictionary, int flags)` | void |
| `TASK_MOVE_NETWORK_BY_NAME` | `void TASK_MOVE_NETWORK_BY_NAME(int ped, string task, float multiplier, bool allowOverrideCloneUpdate, string animDict, int flags)` | void |
| `TASK_MOVE_NETWORK_BY_NAME_WITH_INIT_PARAMS` | `void TASK_MOVE_NETWORK_BY_NAME_WITH_INIT_PARAMS(int ped, string network, ref int initialParameters, float blendDuration, bool allowOverrideCloneUpdate, string animDict, int flags)` | void |
| `TASK_OPEN_VEHICLE_DOOR` | `void TASK_OPEN_VEHICLE_DOOR(int ped, int vehicle, int timeOut, int seat, float speed)` | void |
| `TASK_PARACHUTE` | `void TASK_PARACHUTE(int ped, bool giveParachuteItem, bool instant)` | void |
| `TASK_PARACHUTE_TO_TARGET` | `void TASK_PARACHUTE_TO_TARGET(int ped, float x, float y, float z)` | void |
| `TASK_PATROL` | `void TASK_PATROL(int ped, string patrolRouteName, int alertState, bool canChatToPeds, bool useHeadLookAt)` | void |
| `TASK_PAUSE` | `void TASK_PAUSE(int ped, int ms)` | void |
| `TASK_PED_SLIDE_TO_COORD` | `void TASK_PED_SLIDE_TO_COORD(int ped, float x, float y, float z, float heading, float speed)` | void |
| `TASK_PED_SLIDE_TO_COORD_HDG_RATE` | `void TASK_PED_SLIDE_TO_COORD_HDG_RATE(int ped, float x, float y, float z, float heading, float speed, float headingChangeRate)` | void |
| `TASK_PERFORM_SEQUENCE` | `void TASK_PERFORM_SEQUENCE(int ped, int taskSequenceId)` | void |
| `TASK_PERFORM_SEQUENCE_FROM_PROGRESS` | `void TASK_PERFORM_SEQUENCE_FROM_PROGRESS(int ped, int taskIndex, int progress1, int progress2)` | void |
| `TASK_PERFORM_SEQUENCE_LOCALLY` | `void TASK_PERFORM_SEQUENCE_LOCALLY(int ped, int taskSequenceId)` | void |
| `TASK_PLANE_CHASE` | `void TASK_PLANE_CHASE(int pilot, int entityToFollow, float x, float y, float z)` | void |
| `TASK_PLANE_GOTO_PRECISE_VTOL` | `void TASK_PLANE_GOTO_PRECISE_VTOL(int ped, int vehicle, float x, float y, float z, int flightHeight, int minHeightAboveTerrain, bool useDesiredOrientation, float desiredOrientation, bool autopilot)` | void |
| `TASK_PLANE_LAND` | `void TASK_PLANE_LAND(int pilot, int plane, float runwayStartX, float runwayStartY, float runwayStartZ, float runwayEndX, float runwayEndY, float runwayEndZ)` | void |
| `TASK_PLANE_MISSION` | `void TASK_PLANE_MISSION(int pilot, int aircraft, int targetVehicle, int targetPed, float destinationX, float destinationY, float destinationZ, int missionFlag, float angularDrag, float targetReached, float targetHeading, float maxZ, float minZ, bool precise)` | void |
| `TASK_PLANE_TAXI` | `void TASK_PLANE_TAXI(int pilot, int aircraft, float x, float y, float z, float cruiseSpeed, float targetReached)` | void |
| `TASK_PLANT_BOMB` | `void TASK_PLANT_BOMB(int ped, float x, float y, float z, float heading)` | void |
| `TASK_PLAY_ANIM` | `void TASK_PLAY_ANIM(int ped, string animDictionary, string animationName, float blendInSpeed, float blendOutSpeed, int duration, int flag, float playbackRate, bool lockX, bool lockY, bool lockZ)` | void |
| `TASK_PLAY_ANIM_ADVANCED` | `void TASK_PLAY_ANIM_ADVANCED(int ped, string animDict, string animName, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float animEnterSpeed, float animExitSpeed, int duration, object flag, float animTime, int rotOrder, int ikFlags)` | void |
| `TASK_PLAY_PHONE_GESTURE_ANIMATION` | `void TASK_PLAY_PHONE_GESTURE_ANIMATION(int ped, string animDict, string animation, string boneMaskType, float blendInDuration, float blendOutDuration, bool isLooping, bool holdLastFrame)` | void |
| `TASK_PUT_PED_DIRECTLY_INTO_COVER` | `void TASK_PUT_PED_DIRECTLY_INTO_COVER(int ped, float x, float y, float z, int time, bool allowPeekingAndFiring, float blendInDuration, bool forceInitialFacingDirection, bool forceFaceLeft, int identifier, bool doEntry)` | void |
| `TASK_PUT_PED_DIRECTLY_INTO_MELEE` | `void TASK_PUT_PED_DIRECTLY_INTO_MELEE(int ped, int meleeTarget, float blendInDuration, float timeInMelee, float strafePhaseSync, int aiCombatFlags)` | void |
| `TASK_RAPPEL_DOWN_WALL_USING_CLIPSET_OVERRIDE` | `void TASK_RAPPEL_DOWN_WALL_USING_CLIPSET_OVERRIDE(int ped, float x1, float y1, float z1, float x2, float y2, float z2, float minZ, int ropeHandle, string clipSet, object p10, object p11)` | void |
| `TASK_RAPPEL_FROM_HELI` | `void TASK_RAPPEL_FROM_HELI(int ped, float minHeightAboveGround)` | void |
| `TASK_REACT_AND_FLEE_PED` | `void TASK_REACT_AND_FLEE_PED(int ped, int fleeTarget)` | void |
| `TASK_RELOAD_WEAPON` | `void TASK_RELOAD_WEAPON(int ped, bool drawWeapon)` | void |
| `TASK_SCRIPTED_ANIMATION` | `void TASK_SCRIPTED_ANIMATION(int ped, ref int priorityLowData, ref int priorityMidData, ref int priorityHighData, float blendInDelta, float blendOutDelta)` | void |
| `TASK_SEEK_COVER_FROM_PED` | `void TASK_SEEK_COVER_FROM_PED(int ped, int target, int duration, bool allowPeekingAndFiring)` | void |
| `TASK_SEEK_COVER_FROM_POS` | `void TASK_SEEK_COVER_FROM_POS(int ped, float x, float y, float z, int duration, bool allowPeekingAndFiring)` | void |
| `TASK_SEEK_COVER_TO_COORDS` | `void TASK_SEEK_COVER_TO_COORDS(int ped, float x1, float y1, float z1, float x2, float y2, float z2, int timeout, bool shortRoute)` | void |
| `TASK_SEEK_COVER_TO_COVER_POINT` | `void TASK_SEEK_COVER_TO_COVER_POINT(int ped, int coverpoint, float x, float y, float z, int time, bool allowPeekingAndFiring)` | void |
| `TASK_SET_BLOCKING_OF_NON_TEMPORARY_EVENTS` | `void TASK_SET_BLOCKING_OF_NON_TEMPORARY_EVENTS(int ped, bool toggle)` | void |
| `TASK_SET_DECISION_MAKER` | `void TASK_SET_DECISION_MAKER(int ped, uint decisionMakerId)` | void |
| `TASK_SET_SPHERE_DEFENSIVE_AREA` | `void TASK_SET_SPHERE_DEFENSIVE_AREA(int ped, float x, float y, float z, float radius)` | void |
| `TASK_SHARK_CIRCLE_COORD` | `void TASK_SHARK_CIRCLE_COORD(int ped, float x, float y, float z, float moveBlendRatio, float radius)` | void |
| `TASK_SHOCKING_EVENT_REACT` | `void TASK_SHOCKING_EVENT_REACT(int ped, int eventHandle)` | void |
| `TASK_SHOOT_AT_COORD` | `void TASK_SHOOT_AT_COORD(int ped, float x, float y, float z, int duration, uint firingPattern)` | void |
| `TASK_SHOOT_AT_ENTITY` | `void TASK_SHOOT_AT_ENTITY(int entity, int target, int duration, uint firingPattern)` | void |
| `TASK_SHUFFLE_TO_NEXT_VEHICLE_SEAT` | `void TASK_SHUFFLE_TO_NEXT_VEHICLE_SEAT(int ped, int vehicle, bool useAlternateShuffle)` | void |
| `TASK_SKY_DIVE` | `void TASK_SKY_DIVE(int ped, bool instant)` | void |
| `TASK_SMART_FLEE_COORD` | `void TASK_SMART_FLEE_COORD(int ped, float x, float y, float z, float distance, int time, bool preferPavements, bool quitIfOutOfRange)` | void |
| `TASK_SMART_FLEE_PED` | `void TASK_SMART_FLEE_PED(int ped, int fleeTarget, float safeDistance, int fleeTime, bool preferPavements, bool updateToNearestHatedPed)` | void |
| `TASK_STAND_GUARD` | `void TASK_STAND_GUARD(int ped, float x, float y, float z, float heading, string scenarioName)` | void |
| `TASK_STAND_STILL` | `void TASK_STAND_STILL(int ped, int time)` | void |
| `TASK_START_SCENARIO_AT_POSITION` | `void TASK_START_SCENARIO_AT_POSITION(int ped, string scenarioName, float x, float y, float z, float heading, int duration, bool sittingScenario, bool teleport)` | void |
| `TASK_START_SCENARIO_IN_PLACE` | `void TASK_START_SCENARIO_IN_PLACE(int ped, string scenarioName, int unkDelay, bool playEnterAnim)` | void |
| `TASK_STAY_IN_COVER` | `void TASK_STAY_IN_COVER(int ped)` | void |
| `TASK_STEALTH_KILL` | `void TASK_STEALTH_KILL(int killer, int target, uint stealthKillActionResultHash, float desiredMoveBlendRatio, int stealthFlags)` | void |
| `TASK_STOP_PHONE_GESTURE_ANIMATION` | `void TASK_STOP_PHONE_GESTURE_ANIMATION(int ped, float blendOutOverride)` | void |
| `TASK_SUBMARINE_GOTO_AND_STOP` | `void TASK_SUBMARINE_GOTO_AND_STOP(int ped, int submarine, float x, float y, float z, bool autopilot)` | void |
| `TASK_SWAP_WEAPON` | `void TASK_SWAP_WEAPON(int ped, bool drawWeapon)` | void |
| `TASK_SWEEP_AIM_ENTITY` | `void TASK_SWEEP_AIM_ENTITY(int ped, string animDict, string lowAnimName, string medAnimName, string hiAnimName, int runtime, int targetEntity, float turnRate, float blendInDuration)` | void |
| `TASK_SWEEP_AIM_POSITION` | `void TASK_SWEEP_AIM_POSITION(int ped, string animDict, string lowAnimName, string medAnimName, string hiAnimName, int runtime, float x, float y, float z, float turnRate, float blendInDuration)` | void |
| `TASK_SYNCHRONIZED_SCENE` | `void TASK_SYNCHRONIZED_SCENE(int ped, int scene, string animDictionary, string animationName, float blendIn, float blendOut, int flags, int ragdollBlockingFlags, float moverBlendDelta, int ikFlags)` | void |
| `TASK_THROW_PROJECTILE` | `void TASK_THROW_PROJECTILE(int ped, float x, float y, float z, int ignoreCollisionEntityIndex, bool createInvincibleProjectile)` | void |
| `TASK_TOGGLE_DUCK` | `void TASK_TOGGLE_DUCK(int ped, int toggleType)` | void |
| `TASK_TURN_PED_TO_FACE_COORD` | `void TASK_TURN_PED_TO_FACE_COORD(int ped, float x, float y, float z, int duration)` | void |
| `TASK_TURN_PED_TO_FACE_ENTITY` | `void TASK_TURN_PED_TO_FACE_ENTITY(int ped, int entity, int duration)` | void |
| `TASK_USE_MOBILE_PHONE` | `void TASK_USE_MOBILE_PHONE(int ped, bool usePhone, int desiredPhoneMode)` | void |
| `TASK_USE_MOBILE_PHONE_TIMED` | `void TASK_USE_MOBILE_PHONE_TIMED(int ped, int duration)` | void |
| `TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD` | `void TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD(int ped, float x, float y, float z, float maxRange, int timeToLeave)` | void |
| `TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD_WARP` | `void TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD_WARP(int ped, float x, float y, float z, float radius, int timeToLeave)` | void |
| `TASK_USE_NEAREST_SCENARIO_TO_COORD` | `void TASK_USE_NEAREST_SCENARIO_TO_COORD(int ped, float x, float y, float z, float distance, int duration)` | void |
| `TASK_USE_NEAREST_SCENARIO_TO_COORD_WARP` | `void TASK_USE_NEAREST_SCENARIO_TO_COORD_WARP(int ped, float x, float y, float z, float radius, int timeToLeave)` | void |
| `TASK_VEHICLE_AIM_AT_COORD` | `void TASK_VEHICLE_AIM_AT_COORD(int ped, float x, float y, float z)` | void |
| `TASK_VEHICLE_AIM_AT_PED` | `void TASK_VEHICLE_AIM_AT_PED(int ped, int target)` | void |
| `TASK_VEHICLE_CHASE` | `void TASK_VEHICLE_CHASE(int driver, int targetEnt)` | void |
| `TASK_VEHICLE_DRIVE_TO_COORD` | `void TASK_VEHICLE_DRIVE_TO_COORD(int ped, int vehicle, float x, float y, float z, float speed, object p6, uint vehicleModel, int drivingMode, float stopRange, float straightLineDistance)` | void |
| `TASK_VEHICLE_DRIVE_TO_COORD_LONGRANGE` | `void TASK_VEHICLE_DRIVE_TO_COORD_LONGRANGE(int ped, int vehicle, float x, float y, float z, float speed, int driveMode, float stopRange)` | void |
| `TASK_VEHICLE_DRIVE_WANDER` | `void TASK_VEHICLE_DRIVE_WANDER(int ped, int vehicle, float speed, int drivingStyle)` | void |
| `TASK_VEHICLE_ESCORT` | `void TASK_VEHICLE_ESCORT(int ped, int vehicle, int targetVehicle, int mode, float speed, int drivingStyle, float minDistance, int minHeightAboveTerrain, float noRoadsDistance)` | void |
| `TASK_VEHICLE_FOLLOW` | `void TASK_VEHICLE_FOLLOW(int driver, int vehicle, int targetEntity, float speed, int drivingStyle, int minDistance)` | void |
| `TASK_VEHICLE_FOLLOW_WAYPOINT_RECORDING` | `void TASK_VEHICLE_FOLLOW_WAYPOINT_RECORDING(int ped, int vehicle, string WPRecording, int p3, int p4, int p5, int p6, float p7, bool p8, float p9)` | void |
| `TASK_VEHICLE_GOTO_NAVMESH` | `void TASK_VEHICLE_GOTO_NAVMESH(int ped, int vehicle, float x, float y, float z, float speed, int behaviorFlag, float stoppingRange)` | void |
| `TASK_VEHICLE_HELI_PROTECT` | `void TASK_VEHICLE_HELI_PROTECT(int pilot, int vehicle, int entityToFollow, float targetSpeed, int drivingFlags, float radius, int altitude, int heliFlags)` | void |
| `TASK_VEHICLE_MISSION` | `void TASK_VEHICLE_MISSION(int driver, int vehicle, int vehicleTarget, int missionType, float cruiseSpeed, int drivingStyle, float targetReached, float straightLineDistance, bool DriveAgainstTraffic)` | void |
| `TASK_VEHICLE_MISSION_COORS_TARGET` | `void TASK_VEHICLE_MISSION_COORS_TARGET(int ped, int vehicle, float x, float y, float z, int mission, float cruiseSpeed, int drivingStyle, float targetReached, float straightLineDistance, bool DriveAgainstTraffic)` | void |
| `TASK_VEHICLE_MISSION_PED_TARGET` | `void TASK_VEHICLE_MISSION_PED_TARGET(int ped, int vehicle, int pedTarget, int missionType, float maxSpeed, int drivingStyle, float minDistance, float straightLineDistance, bool DriveAgainstTraffic)` | void |
| `TASK_VEHICLE_PARK` | `void TASK_VEHICLE_PARK(int ped, int vehicle, float x, float y, float z, float heading, int mode, float radius, bool keepEngineOn)` | void |
| `TASK_VEHICLE_PLAY_ANIM` | `void TASK_VEHICLE_PLAY_ANIM(int vehicle, string animationSet, string animationName)` | void |
| `TASK_VEHICLE_SHOOT_AT_COORD` | `void TASK_VEHICLE_SHOOT_AT_COORD(int ped, float x, float y, float z, float fireTolerance)` | void |
| `TASK_VEHICLE_SHOOT_AT_PED` | `void TASK_VEHICLE_SHOOT_AT_PED(int ped, int target, float fireTolerance)` | void |
| `TASK_VEHICLE_TEMP_ACTION` | `void TASK_VEHICLE_TEMP_ACTION(int driver, int vehicle, int action, int time)` | void |
| `TASK_WANDER_IN_AREA` | `void TASK_WANDER_IN_AREA(int ped, float x, float y, float z, float radius, float minimalLength, float timeBetweenWalks)` | void |
| `TASK_WANDER_SPECIFIC` | `void TASK_WANDER_SPECIFIC(int ped, string conditionalAnimGroupStr, string conditionalAnimStr, float heading)` | void |
| `TASK_WANDER_STANDARD` | `void TASK_WANDER_STANDARD(int ped, float heading, int flags)` | void |
| `TASK_WARP_PED_DIRECTLY_INTO_COVER` | `void TASK_WARP_PED_DIRECTLY_INTO_COVER(int ped, int time, bool allowPeekingAndFiring, bool forceInitialFacingDirection, bool forceFaceLeft, int identifier)` | void |
| `TASK_WARP_PED_INTO_VEHICLE` | `void TASK_WARP_PED_INTO_VEHICLE(int ped, int vehicle, int seat)` | void |
| `TASK_WRITHE` | `void TASK_WRITHE(int ped, int target, int minFireLoops, int startState, bool forceShootOnGround, int shootFromGroundTimer)` | void |
| `UNCUFF_PED` | `void UNCUFF_PED(int ped)` | void |
| `UPDATE_TASK_AIM_GUN_SCRIPTED_TARGET` | `void UPDATE_TASK_AIM_GUN_SCRIPTED_TARGET(int ped, int target, float x, float y, float z, bool disableBlockingClip)` | void |
| `UPDATE_TASK_HANDS_UP_DURATION` | `void UPDATE_TASK_HANDS_UP_DURATION(int ped, int duration)` | void |
| `UPDATE_TASK_SWEEP_AIM_ENTITY` | `void UPDATE_TASK_SWEEP_AIM_ENTITY(int ped, int entity)` | void |
| `UPDATE_TASK_SWEEP_AIM_POSITION` | `void UPDATE_TASK_SWEEP_AIM_POSITION(int ped, float x, float y, float z)` | void |
| `USE_WAYPOINT_RECORDING_AS_ASSISTED_MOVEMENT_ROUTE` | `void USE_WAYPOINT_RECORDING_AS_ASSISTED_MOVEMENT_ROUTE(string name, bool p1, float p2, float p3)` | void |
| `VEHICLE_WAYPOINT_PLAYBACK_GET_IS_PAUSED` | `bool VEHICLE_WAYPOINT_PLAYBACK_GET_IS_PAUSED(int vehicle)` | bool |
| `VEHICLE_WAYPOINT_PLAYBACK_OVERRIDE_SPEED` | `void VEHICLE_WAYPOINT_PLAYBACK_OVERRIDE_SPEED(int vehicle, float speed)` | void |
| `VEHICLE_WAYPOINT_PLAYBACK_PAUSE` | `void VEHICLE_WAYPOINT_PLAYBACK_PAUSE(int vehicle)` | void |
| `VEHICLE_WAYPOINT_PLAYBACK_RESUME` | `void VEHICLE_WAYPOINT_PLAYBACK_RESUME(int vehicle)` | void |
| `VEHICLE_WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED` | `void VEHICLE_WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED(int vehicle)` | void |
| `WAYPOINT_PLAYBACK_GET_IS_PAUSED` | `bool WAYPOINT_PLAYBACK_GET_IS_PAUSED(object p0)` | bool |
| `WAYPOINT_PLAYBACK_OVERRIDE_SPEED` | `void WAYPOINT_PLAYBACK_OVERRIDE_SPEED(object p0, float p1, bool p2)` | void |
| `WAYPOINT_PLAYBACK_PAUSE` | `void WAYPOINT_PLAYBACK_PAUSE(object p0, bool p1, bool p2)` | void |
| `WAYPOINT_PLAYBACK_RESUME` | `void WAYPOINT_PLAYBACK_RESUME(object p0, bool p1, object p2, object p3)` | void |
| `WAYPOINT_PLAYBACK_START_AIMING_AT_COORD` | `void WAYPOINT_PLAYBACK_START_AIMING_AT_COORD(int ped, float x, float y, float z, bool p4)` | void |
| `WAYPOINT_PLAYBACK_START_AIMING_AT_PED` | `void WAYPOINT_PLAYBACK_START_AIMING_AT_PED(int ped, int target, bool p2)` | void |
| `WAYPOINT_PLAYBACK_START_SHOOTING_AT_COORD` | `void WAYPOINT_PLAYBACK_START_SHOOTING_AT_COORD(int ped, float x, float y, float z, bool p4, uint firingPattern)` | void |
| `WAYPOINT_PLAYBACK_START_SHOOTING_AT_PED` | `void WAYPOINT_PLAYBACK_START_SHOOTING_AT_PED(int ped, int ped2, bool p2, bool p3)` | void |
| `WAYPOINT_PLAYBACK_STOP_AIMING_OR_SHOOTING` | `void WAYPOINT_PLAYBACK_STOP_AIMING_OR_SHOOTING(int ped)` | void |
| `WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED` | `void WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED(object p0)` | void |
| `WAYPOINT_RECORDING_GET_CLOSEST_WAYPOINT` | `bool WAYPOINT_RECORDING_GET_CLOSEST_WAYPOINT(string name, float x, float y, float z, ref int point)` | bool |
| `WAYPOINT_RECORDING_GET_COORD` | `bool WAYPOINT_RECORDING_GET_COORD(string name, int point, ref Vector3 coord)` | bool |
| `WAYPOINT_RECORDING_GET_NUM_POINTS` | `bool WAYPOINT_RECORDING_GET_NUM_POINTS(string name, ref int points)` | bool |
| `WAYPOINT_RECORDING_GET_SPEED_AT_POINT` | `float WAYPOINT_RECORDING_GET_SPEED_AT_POINT(string name, int point)` | float |
| `_SET_AMBIENT_PED_ENABLE_COLLISION_ON_NETWORK_CLONE_WHEN_FIXED` | `void _SET_AMBIENT_PED_ENABLE_COLLISION_ON_NETWORK_CLONE_WHEN_FIXED(int ped, bool enable)` | void |
| `_SET_SCRIPT_TASK_ENABLE_COLLISION_ON_NETWORK_CLONE_WHEN_FIXED` | `void _SET_SCRIPT_TASK_ENABLE_COLLISION_ON_NETWORK_CLONE_WHEN_FIXED(int ped, bool enable)` | void |

---

## ENTITY

| 函数名 | 签名 | 返回值 |
|--------|------|--------|
| `ADD_DOOR_TO_SYSTEM` | `void ADD_DOOR_TO_SYSTEM(uint doorHash, uint modelHash, float x, float y, float z, bool p5, bool scriptDoor, bool isLocal, object p8)` | void |
| `ADD_EXTENDED_PICKUP_PROBE_AREA` | `void ADD_EXTENDED_PICKUP_PROBE_AREA(float x, float y, float z, float radius)` | void |
| `ADD_TO_ITEMSET` | `bool ADD_TO_ITEMSET(int item, int itemset)` | bool |
| `ALLOW_ALL_PLAYERS_TO_COLLECT_PICKUPS_OF_TYPE` | `void ALLOW_ALL_PLAYERS_TO_COLLECT_PICKUPS_OF_TYPE(uint pickupHash)` | void |
| `ALLOW_DAMAGE_EVENTS_FOR_NON_NETWORKED_OBJECTS` | `void ALLOW_DAMAGE_EVENTS_FOR_NON_NETWORKED_OBJECTS(bool value)` | void |
| `ALLOW_PICKUP_ARROW_MARKER_WHEN_UNCOLLECTABLE` | `void ALLOW_PICKUP_ARROW_MARKER_WHEN_UNCOLLECTABLE(int pickup, bool toggle)` | void |
| `ALLOW_PICKUP_BY_NONE_PARTICIPANT` | `void ALLOW_PICKUP_BY_NONE_PARTICIPANT(int pickup, bool toggle)` | void |
| `ALLOW_PORTABLE_PICKUP_TO_MIGRATE_TO_NON_PARTICIPANTS` | `void ALLOW_PORTABLE_PICKUP_TO_MIGRATE_TO_NON_PARTICIPANTS(int pickup, bool toggle)` | void |
| `APPLY_FORCE_TO_ENTITY` | `void APPLY_FORCE_TO_ENTITY(int entity, int forceFlags, float x, float y, float z, float offX, float offY, float offZ, int boneIndex, bool isDirectionRel, bool ignoreUpVec, bool isForceRel, bool p12, bool p13)` | void |
| `APPLY_FORCE_TO_ENTITY_CENTER_OF_MASS` | `void APPLY_FORCE_TO_ENTITY_CENTER_OF_MASS(int entity, int forceType, float x, float y, float z, bool p5, bool isDirectionRel, bool isForceRel, bool p8)` | void |
| `ARE_ENTITIES_ENTIRELY_INSIDE_GARAGE` | `bool ARE_ENTITIES_ENTIRELY_INSIDE_GARAGE(uint garageHash, bool p1, bool p2, bool p3, object p4)` | bool |
| `ATTACH_ENTITY_BONE_TO_ENTITY_BONE` | `void ATTACH_ENTITY_BONE_TO_ENTITY_BONE(int entity1, int entity2, int boneIndex1, int boneIndex2, bool p4, bool p5)` | void |
| `ATTACH_ENTITY_BONE_TO_ENTITY_BONE_Y_FORWARD` | `void ATTACH_ENTITY_BONE_TO_ENTITY_BONE_Y_FORWARD(int entity1, int entity2, int boneIndex1, int boneIndex2, bool p4, bool p5)` | void |
| `ATTACH_ENTITY_TO_ENTITY` | `void ATTACH_ENTITY_TO_ENTITY(int entity1, int entity2, int boneIndex, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, bool p9, bool useSoftPinning, bool collision, bool isPed, int vertexIndex, bool fixedRot, object p15)` | void |
| `ATTACH_ENTITY_TO_ENTITY_PHYSICALLY` | `void ATTACH_ENTITY_TO_ENTITY_PHYSICALLY(int entity1, int entity2, int boneIndex1, int boneIndex2, float xPos1, float yPos1, float zPos1, float xPos2, float yPos2, float zPos2, float xRot, float yRot, float zRot, float breakForce, bool fixedRot, bool p15, bool collision, bool p17, int p18)` | void |
| `ATTACH_ENTITY_TO_ENTITY_PHYSICALLY_OVERRIDE_INVERSE_MASS` | `void ATTACH_ENTITY_TO_ENTITY_PHYSICALLY_OVERRIDE_INVERSE_MASS(int firstEntityIndex, int secondEntityIndex, int firstEntityBoneIndex, int secondEntityBoneIndex, float secondEntityOffsetX, float secondEntityOffsetY, float secondEntityOffsetZ, float firstEntityOffsetX, float firstEntityOffsetY, float firstEntityOffsetZ, float vecRotationX, float vecRotationY, float vecRotationZ, float physicalStrength, bool constrainRotation, bool doInitialWarp, bool collideWithEntity, bool addInitialSeperation, int rotOrder, float invMassScaleA, float invMassScaleB)` | void |
| `ATTACH_PORTABLE_PICKUP_TO_PED` | `void ATTACH_PORTABLE_PICKUP_TO_PED(int pickupObject, int ped)` | void |
| `BLOCK_PLAYERS_FOR_AMBIENT_PICKUP` | `void BLOCK_PLAYERS_FOR_AMBIENT_PICKUP(object p0, object p1)` | void |
| `BREAK_OBJECT_FRAGMENT_CHILD` | `void BREAK_OBJECT_FRAGMENT_CHILD(int p0, object p1, bool p2)` | void |
| `CLEAN_ITEMSET` | `void CLEAN_ITEMSET(int itemset)` | void |
| `CLEAR_ALL_PICKUP_REWARD_TYPE_SUPPRESSION` | `void CLEAR_ALL_PICKUP_REWARD_TYPE_SUPPRESSION()` | void |
| `CLEAR_ENTITY_LAST_DAMAGE_ENTITY` | `void CLEAR_ENTITY_LAST_DAMAGE_ENTITY(int entity)` | void |
| `CLEAR_EXTENDED_PICKUP_PROBE_AREAS` | `void CLEAR_EXTENDED_PICKUP_PROBE_AREAS()` | void |
| `CLEAR_GARAGE` | `void CLEAR_GARAGE(uint garageHash, bool isNetwork)` | void |
| `CLEAR_OBJECTS_INSIDE_GARAGE` | `void CLEAR_OBJECTS_INSIDE_GARAGE(uint garageHash, bool vehicles, bool peds, bool objects, bool isNetwork)` | void |
| `CLEAR_PICKUP_REWARD_TYPE_SUPPRESSION` | `void CLEAR_PICKUP_REWARD_TYPE_SUPPRESSION(int rewardType)` | void |
| `CLOSE_ALL_BARRIERS_FOR_RACE` | `void CLOSE_ALL_BARRIERS_FOR_RACE()` | void |
| `CLOSE_SAFEHOUSE_GARAGES` | `void CLOSE_SAFEHOUSE_GARAGES()` | void |
| `CONVERT_OLD_PICKUP_TYPE_TO_NEW` | `uint CONVERT_OLD_PICKUP_TYPE_TO_NEW(uint pickupHash)` | uint |
| `CREATE_AMBIENT_PICKUP` | `int CREATE_AMBIENT_PICKUP(uint pickupHash, float posX, float posY, float posZ, int flags, int value, uint modelHash, bool p7, bool p8)` | int |
| `CREATE_FORCED_OBJECT` | `void CREATE_FORCED_OBJECT(float x, float y, float z, object p3, uint modelHash, bool p5)` | void |
| `CREATE_ITEMSET` | `int CREATE_ITEMSET(bool p0)` | int |
| `CREATE_MODEL_HIDE` | `void CREATE_MODEL_HIDE(float x, float y, float z, float radius, uint modelHash, bool p5)` | void |
| `CREATE_MODEL_HIDE_EXCLUDING_SCRIPT_OBJECTS` | `void CREATE_MODEL_HIDE_EXCLUDING_SCRIPT_OBJECTS(float x, float y, float z, float radius, uint modelHash, bool p5)` | void |
| `CREATE_MODEL_SWAP` | `void CREATE_MODEL_SWAP(float x, float y, float z, float radius, uint originalModel, uint newModel, bool p6)` | void |
| `CREATE_MONEY_PICKUPS` | `void CREATE_MONEY_PICKUPS(float x, float y, float z, int value, int amount, uint model)` | void |
| `CREATE_NON_NETWORKED_AMBIENT_PICKUP` | `int CREATE_NON_NETWORKED_AMBIENT_PICKUP(uint pickupHash, float posX, float posY, float posZ, int flags, int value, uint modelHash, bool p7, bool p8)` | int |
| `CREATE_NON_NETWORKED_PORTABLE_PICKUP` | `int CREATE_NON_NETWORKED_PORTABLE_PICKUP(uint pickupHash, float x, float y, float z, bool placeOnGround, uint modelHash)` | int |
| `CREATE_OBJECT` | `int CREATE_OBJECT(uint modelHash, float x, float y, float z, bool isNetwork, bool bScriptHostObj, bool dynamic)` | int |
| `CREATE_OBJECT_NO_OFFSET` | `int CREATE_OBJECT_NO_OFFSET(uint modelHash, float x, float y, float z, bool isNetwork, bool bScriptHostObj, bool dynamic, object p7)` | int |
| `CREATE_PICKUP` | `int CREATE_PICKUP(uint pickupHash, float posX, float posY, float posZ, int p4, int value, bool p6, uint modelHash)` | int |
| `CREATE_PICKUP_ROTATE` | `int CREATE_PICKUP_ROTATE(uint pickupHash, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, int flag, int amount, object p9, bool p10, uint modelHash)` | int |
| `CREATE_PORTABLE_PICKUP` | `int CREATE_PORTABLE_PICKUP(uint pickupHash, float x, float y, float z, bool placeOnGround, uint modelHash)` | int |
| `DAMAGE_OBJECT_FRAGMENT_CHILD` | `void DAMAGE_OBJECT_FRAGMENT_CHILD(object p0, object p1, object p2)` | void |
| `DELETE_ENTITY` | `void DELETE_ENTITY(Entity* entity)` | void |
| `DELETE_OBJECT` | `void DELETE_OBJECT(Object* object)` | void |
| `DESTROY_ITEMSET` | `void DESTROY_ITEMSET(int itemset)` | void |
| `DETACH_ENTITY` | `void DETACH_ENTITY(int entity, bool dynamic, bool collision)` | void |
| `DETACH_PORTABLE_PICKUP_FROM_PED` | `void DETACH_PORTABLE_PICKUP_FROM_PED(int pickupObject)` | void |
| `DISABLE_TIDYING_UP_IN_GARAGE` | `void DISABLE_TIDYING_UP_IN_GARAGE(int id, bool toggle)` | void |
| `DOES_ENTITY_BELONG_TO_THIS_SCRIPT` | `bool DOES_ENTITY_BELONG_TO_THIS_SCRIPT(int entity, bool p1)` | bool |
| `DOES_ENTITY_EXIST` | `bool DOES_ENTITY_EXIST(int entity)` | bool |
| `DOES_ENTITY_HAVE_ANIM_DIRECTOR` | `bool DOES_ENTITY_HAVE_ANIM_DIRECTOR(int entity)` | bool |
| `DOES_ENTITY_HAVE_DRAWABLE` | `bool DOES_ENTITY_HAVE_DRAWABLE(int entity)` | bool |
| `DOES_ENTITY_HAVE_PHYSICS` | `bool DOES_ENTITY_HAVE_PHYSICS(int entity)` | bool |
| `DOES_ENTITY_HAVE_SKELETON` | `bool DOES_ENTITY_HAVE_SKELETON(int entity)` | bool |
| `DOES_OBJECT_OF_TYPE_EXIST_AT_COORDS` | `bool DOES_OBJECT_OF_TYPE_EXIST_AT_COORDS(float x, float y, float z, float radius, uint hash, bool p5)` | bool |
| `DOES_PICKUP_EXIST` | `bool DOES_PICKUP_EXIST(int pickup)` | bool |
| `DOES_PICKUP_OBJECT_EXIST` | `bool DOES_PICKUP_OBJECT_EXIST(int pickupObject)` | bool |
| `DOES_PICKUP_OF_TYPE_EXIST_IN_AREA` | `bool DOES_PICKUP_OF_TYPE_EXIST_IN_AREA(uint pickupHash, float x, float y, float z, float radius)` | bool |
| `DOES_RAYFIRE_MAP_OBJECT_EXIST` | `bool DOES_RAYFIRE_MAP_OBJECT_EXIST(int object)` | bool |
| `DOOR_SYSTEM_FIND_EXISTING_DOOR` | `bool DOOR_SYSTEM_FIND_EXISTING_DOOR(float x, float y, float z, uint modelHash, Hash* outDoorHash)` | bool |
| `DOOR_SYSTEM_GET_AUTOMATIC_DISTANCE` | `float DOOR_SYSTEM_GET_AUTOMATIC_DISTANCE(uint doorHash)` | float |
| `DOOR_SYSTEM_GET_DOOR_PENDING_STATE` | `int DOOR_SYSTEM_GET_DOOR_PENDING_STATE(uint doorHash)` | int |
| `DOOR_SYSTEM_GET_DOOR_STATE` | `int DOOR_SYSTEM_GET_DOOR_STATE(uint doorHash)` | int |
| `DOOR_SYSTEM_GET_IS_PHYSICS_LOADED` | `bool DOOR_SYSTEM_GET_IS_PHYSICS_LOADED(object p0)` | bool |
| `DOOR_SYSTEM_GET_IS_SPRING_REMOVED` | `bool DOOR_SYSTEM_GET_IS_SPRING_REMOVED(uint doorHash)` | bool |
| `DOOR_SYSTEM_GET_OPEN_RATIO` | `float DOOR_SYSTEM_GET_OPEN_RATIO(uint doorHash)` | float |
| `DOOR_SYSTEM_SET_AUTOMATIC_DISTANCE` | `void DOOR_SYSTEM_SET_AUTOMATIC_DISTANCE(uint doorHash, float distance, bool requestDoor, bool forceUpdate)` | void |
| `DOOR_SYSTEM_SET_AUTOMATIC_RATE` | `void DOOR_SYSTEM_SET_AUTOMATIC_RATE(uint doorHash, float rate, bool requestDoor, bool forceUpdate)` | void |
| `DOOR_SYSTEM_SET_DOOR_OPEN_FOR_RACES` | `void DOOR_SYSTEM_SET_DOOR_OPEN_FOR_RACES(uint doorHash, bool p1)` | void |
| `DOOR_SYSTEM_SET_DOOR_STATE` | `void DOOR_SYSTEM_SET_DOOR_STATE(uint doorHash, int state, bool requestDoor, bool forceUpdate)` | void |
| `DOOR_SYSTEM_SET_HOLD_OPEN` | `void DOOR_SYSTEM_SET_HOLD_OPEN(uint doorHash, bool toggle)` | void |
| `DOOR_SYSTEM_SET_OPEN_RATIO` | `void DOOR_SYSTEM_SET_OPEN_RATIO(uint doorHash, float ajar, bool requestDoor, bool forceUpdate)` | void |
| `DOOR_SYSTEM_SET_SPRING_REMOVED` | `void DOOR_SYSTEM_SET_SPRING_REMOVED(uint doorHash, bool removed, bool requestDoor, bool forceUpdate)` | void |
| `ENABLE_ENTITY_BULLET_COLLISION` | `void ENABLE_ENTITY_BULLET_COLLISION(int entity)` | void |
| `ENABLE_SAVING_IN_GARAGE` | `void ENABLE_SAVING_IN_GARAGE(uint garageHash, bool toggle)` | void |
| `FIND_ANIM_EVENT_PHASE` | `bool FIND_ANIM_EVENT_PHASE(string animDictionary, string animName, string p2, ref object p3, ref object p4)` | bool |
| `FIX_OBJECT_FRAGMENT` | `void FIX_OBJECT_FRAGMENT(int object)` | void |
| `FORCE_ACTIVATE_PHYSICS_ON_UNFIXED_PICKUP` | `void FORCE_ACTIVATE_PHYSICS_ON_UNFIXED_PICKUP(int pickup, bool toggle)` | void |
| `FORCE_ENTITY_AI_AND_ANIMATION_UPDATE` | `void FORCE_ENTITY_AI_AND_ANIMATION_UPDATE(int entity)` | void |
| `FORCE_PICKUP_REGENERATE` | `void FORCE_PICKUP_REGENERATE(object p0)` | void |
| `FORCE_PICKUP_ROTATE_FACE_UP` | `void FORCE_PICKUP_ROTATE_FACE_UP()` | void |
| `FORCE_PORTABLE_PICKUP_LAST_ACCESSIBLE_POSITION_SETTING` | `void FORCE_PORTABLE_PICKUP_LAST_ACCESSIBLE_POSITION_SETTING(int object)` | void |
| `FREEZE_ENTITY_POSITION` | `void FREEZE_ENTITY_POSITION(int entity, bool toggle)` | void |
| `GET_ANIM_DURATION` | `float GET_ANIM_DURATION(string animDict, string animName)` | float |
| `GET_CLOSEST_OBJECT_OF_TYPE` | `int GET_CLOSEST_OBJECT_OF_TYPE(float x, float y, float z, float radius, uint modelHash, bool isMission, bool p6, bool p7)` | int |
| `GET_COLLISION_NORMAL_OF_LAST_HIT_FOR_ENTITY` | `Vector3 GET_COLLISION_NORMAL_OF_LAST_HIT_FOR_ENTITY(int entity)` | Vector3 |
| `GET_COORDS_AND_ROTATION_OF_CLOSEST_OBJECT_OF_TYPE` | `bool GET_COORDS_AND_ROTATION_OF_CLOSEST_OBJECT_OF_TYPE(float x, float y, float z, float radius, uint modelHash, ref Vector3 outPosition, ref Vector3 outRotation, int rotationOrder)` | bool |
| `GET_DEFAULT_AMMO_FOR_WEAPON_PICKUP` | `int GET_DEFAULT_AMMO_FOR_WEAPON_PICKUP(uint pickupHash)` | int |
| `GET_ENTITY_ALPHA` | `int GET_ENTITY_ALPHA(int entity)` | int |
| `GET_ENTITY_ANIM_CURRENT_TIME` | `float GET_ENTITY_ANIM_CURRENT_TIME(int entity, string animDict, string animName)` | float |
| `GET_ENTITY_ANIM_TOTAL_TIME` | `float GET_ENTITY_ANIM_TOTAL_TIME(int entity, string animDict, string animName)` | float |
| `GET_ENTITY_ATTACHED_TO` | `int GET_ENTITY_ATTACHED_TO(int entity)` | int |
| `GET_ENTITY_BONE_COUNT` | `int GET_ENTITY_BONE_COUNT(int entity)` | int |
| `GET_ENTITY_BONE_INDEX_BY_NAME` | `int GET_ENTITY_BONE_INDEX_BY_NAME(int entity, string boneName)` | int |
| `GET_ENTITY_BONE_OBJECT_POSTION` | `Vector3 GET_ENTITY_BONE_OBJECT_POSTION(int entity, int boneIndex)` | Vector3 |
| `GET_ENTITY_BONE_OBJECT_ROTATION` | `Vector3 GET_ENTITY_BONE_OBJECT_ROTATION(int entity, int boneIndex)` | Vector3 |
| `GET_ENTITY_BONE_POSTION` | `Vector3 GET_ENTITY_BONE_POSTION(int entity, int boneIndex)` | Vector3 |
| `GET_ENTITY_BONE_ROTATION` | `Vector3 GET_ENTITY_BONE_ROTATION(int entity, int boneIndex)` | Vector3 |
| `GET_ENTITY_CAN_BE_DAMAGED` | `bool GET_ENTITY_CAN_BE_DAMAGED(int entity)` | bool |
| `GET_ENTITY_COLLISION_DISABLED` | `bool GET_ENTITY_COLLISION_DISABLED(int entity)` | bool |
| `GET_ENTITY_COORDS` | `Vector3 GET_ENTITY_COORDS(int entity, bool alive)` | Vector3 |
| `GET_ENTITY_FORWARD_VECTOR` | `Vector3 GET_ENTITY_FORWARD_VECTOR(int entity)` | Vector3 |
| `GET_ENTITY_FORWARD_X` | `float GET_ENTITY_FORWARD_X(int entity)` | float |
| `GET_ENTITY_FORWARD_Y` | `float GET_ENTITY_FORWARD_Y(int entity)` | float |
| `GET_ENTITY_HEADING` | `float GET_ENTITY_HEADING(int entity)` | float |
| `GET_ENTITY_HEADING_FROM_EULERS` | `float GET_ENTITY_HEADING_FROM_EULERS(int entity)` | float |
| `GET_ENTITY_HEALTH` | `int GET_ENTITY_HEALTH(int entity)` | int |
| `GET_ENTITY_HEIGHT` | `float GET_ENTITY_HEIGHT(int entity, float X, float Y, float Z, bool atTop, bool inWorldCoords)` | float |
| `GET_ENTITY_HEIGHT_ABOVE_GROUND` | `float GET_ENTITY_HEIGHT_ABOVE_GROUND(int entity)` | float |
| `GET_ENTITY_LOD_DIST` | `int GET_ENTITY_LOD_DIST(int entity)` | int |
| `GET_ENTITY_MATRIX` | `void GET_ENTITY_MATRIX(int entity, ref Vector3 forwardVector, ref Vector3 rightVector, ref Vector3 upVector, ref Vector3 position)` | void |
| `GET_ENTITY_MAX_HEALTH` | `int GET_ENTITY_MAX_HEALTH(int entity)` | int |
| `GET_ENTITY_MODEL` | `uint GET_ENTITY_MODEL(int entity)` | uint |
| `GET_ENTITY_OF_TYPE_ATTACHED_TO_ENTITY` | `int GET_ENTITY_OF_TYPE_ATTACHED_TO_ENTITY(int entity, uint modelHash)` | int |
| `GET_ENTITY_PITCH` | `float GET_ENTITY_PITCH(int entity)` | float |
| `GET_ENTITY_POPULATION_TYPE` | `int GET_ENTITY_POPULATION_TYPE(int entity)` | int |
| `GET_ENTITY_PROOFS` | `bool GET_ENTITY_PROOFS(int entity, ref bool bulletProof, ref bool fireProof, ref bool explosionProof, ref bool collisionProof, ref bool meleeProof, ref bool steamProof, ref bool p7, ref bool drownProof)` | bool |
| `GET_ENTITY_QUATERNION` | `void GET_ENTITY_QUATERNION(int entity, ref float x, ref float y, ref float z, ref float w)` | void |
| `GET_ENTITY_ROLL` | `float GET_ENTITY_ROLL(int entity)` | float |
| `GET_ENTITY_ROTATION` | `Vector3 GET_ENTITY_ROTATION(int entity, int rotationOrder)` | Vector3 |
| `GET_ENTITY_ROTATION_VELOCITY` | `Vector3 GET_ENTITY_ROTATION_VELOCITY(int entity)` | Vector3 |
| `GET_ENTITY_SCRIPT` | `string GET_ENTITY_SCRIPT(int entity, ScrHandle* script)` | string |
| `GET_ENTITY_SPEED` | `float GET_ENTITY_SPEED(int entity)` | float |
| `GET_ENTITY_SPEED_VECTOR` | `Vector3 GET_ENTITY_SPEED_VECTOR(int entity, bool relative)` | Vector3 |
| `GET_ENTITY_SUBMERGED_LEVEL` | `float GET_ENTITY_SUBMERGED_LEVEL(int entity)` | float |
| `GET_ENTITY_TYPE` | `int GET_ENTITY_TYPE(int entity)` | int |
| `GET_ENTITY_UPRIGHT_VALUE` | `float GET_ENTITY_UPRIGHT_VALUE(int entity)` | float |
| `GET_ENTITY_VELOCITY` | `Vector3 GET_ENTITY_VELOCITY(int entity)` | Vector3 |
| `GET_HAS_OBJECT_BEEN_COMPLETELY_DESTROYED` | `bool GET_HAS_OBJECT_BEEN_COMPLETELY_DESTROYED(object p0)` | bool |
| `GET_INDEXED_ITEM_IN_ITEMSET` | `int GET_INDEXED_ITEM_IN_ITEMSET(int index, int itemset)` | int |
| `GET_IS_ARTICULATED_JOINT_AT_MAX_ANGLE` | `bool GET_IS_ARTICULATED_JOINT_AT_MAX_ANGLE(object p0, object p1)` | bool |
| `GET_IS_ARTICULATED_JOINT_AT_MIN_ANGLE` | `bool GET_IS_ARTICULATED_JOINT_AT_MIN_ANGLE(int object, object p1)` | bool |
| `GET_ITEMSET_SIZE` | `int GET_ITEMSET_SIZE(int itemset)` | int |
| `GET_LAST_MATERIAL_HIT_BY_ENTITY` | `uint GET_LAST_MATERIAL_HIT_BY_ENTITY(int entity)` | uint |
| `GET_NEAREST_PARTICIPANT_TO_ENTITY` | `int GET_NEAREST_PARTICIPANT_TO_ENTITY(int entity)` | int |
| `GET_NEAREST_PLAYER_TO_ENTITY` | `int GET_NEAREST_PLAYER_TO_ENTITY(int entity)` | int |
| `GET_NEAREST_PLAYER_TO_ENTITY_ON_TEAM` | `int GET_NEAREST_PLAYER_TO_ENTITY_ON_TEAM(int entity, int team)` | int |
| `GET_OBJECT_FRAGMENT_DAMAGE_HEALTH` | `float GET_OBJECT_FRAGMENT_DAMAGE_HEALTH(object p0, bool p1)` | float |
| `GET_OBJECT_INDEX_FROM_ENTITY_INDEX` | `int GET_OBJECT_INDEX_FROM_ENTITY_INDEX(int entity)` | int |
| `GET_OBJECT_TINT_INDEX` | `int GET_OBJECT_TINT_INDEX(int object)` | int |
| `GET_OFFSET_FROM_COORD_AND_HEADING_IN_WORLD_COORDS` | `Vector3 GET_OFFSET_FROM_COORD_AND_HEADING_IN_WORLD_COORDS(float xPos, float yPos, float zPos, float heading, float xOffset, float yOffset, float zOffset)` | Vector3 |
| `GET_OFFSET_FROM_ENTITY_GIVEN_WORLD_COORDS` | `Vector3 GET_OFFSET_FROM_ENTITY_GIVEN_WORLD_COORDS(int entity, float posX, float posY, float posZ)` | Vector3 |
| `GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS` | `Vector3 GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(int entity, float offsetX, float offsetY, float offsetZ)` | Vector3 |
| `GET_PED_INDEX_FROM_ENTITY_INDEX` | `int GET_PED_INDEX_FROM_ENTITY_INDEX(int entity)` | int |
| `GET_PICKUP_COORDS` | `Vector3 GET_PICKUP_COORDS(int pickup)` | Vector3 |
| `GET_PICKUP_GENERATION_RANGE_MULTIPLIER` | `float GET_PICKUP_GENERATION_RANGE_MULTIPLIER()` | float |
| `GET_PICKUP_OBJECT` | `int GET_PICKUP_OBJECT(int pickup)` | int |
| `GET_PICKUP_TYPE_FROM_WEAPON_HASH` | `uint GET_PICKUP_TYPE_FROM_WEAPON_HASH(uint weaponHash)` | uint |
| `GET_RAYFIRE_MAP_OBJECT` | `int GET_RAYFIRE_MAP_OBJECT(float x, float y, float z, float radius, string name)` | int |
| `GET_RAYFIRE_MAP_OBJECT_ANIM_PHASE` | `float GET_RAYFIRE_MAP_OBJECT_ANIM_PHASE(int object)` | float |
| `GET_SAFE_PICKUP_COORDS` | `Vector3 GET_SAFE_PICKUP_COORDS(float x, float y, float z, float p3, float p4)` | Vector3 |
| `GET_STATE_OF_CLOSEST_DOOR_OF_TYPE` | `void GET_STATE_OF_CLOSEST_DOOR_OF_TYPE(uint type, float x, float y, float z, ref bool locked, ref float heading)` | void |
| `GET_STATE_OF_RAYFIRE_MAP_OBJECT` | `int GET_STATE_OF_RAYFIRE_MAP_OBJECT(int object)` | int |
| `GET_VEHICLE_INDEX_FROM_ENTITY_INDEX` | `int GET_VEHICLE_INDEX_FROM_ENTITY_INDEX(int entity)` | int |
| `GET_WEAPON_TYPE_FROM_PICKUP_TYPE` | `uint GET_WEAPON_TYPE_FROM_PICKUP_TYPE(uint pickupHash)` | uint |
| `GET_WORLD_POSITION_OF_ENTITY_BONE` | `Vector3 GET_WORLD_POSITION_OF_ENTITY_BONE(int entity, int boneIndex)` | Vector3 |
| `HAS_ANIM_EVENT_FIRED` | `bool HAS_ANIM_EVENT_FIRED(int entity, uint actionHash)` | bool |
| `HAS_CLOSEST_OBJECT_OF_TYPE_BEEN_BROKEN` | `bool HAS_CLOSEST_OBJECT_OF_TYPE_BEEN_BROKEN(float p0, float p1, float p2, float p3, uint modelHash, object p5)` | bool |
| `HAS_CLOSEST_OBJECT_OF_TYPE_BEEN_COMPLETELY_DESTROYED` | `bool HAS_CLOSEST_OBJECT_OF_TYPE_BEEN_COMPLETELY_DESTROYED(float x, float y, float z, float radius, uint modelHash, bool p5)` | bool |
| `HAS_COLLISION_LOADED_AROUND_ENTITY` | `bool HAS_COLLISION_LOADED_AROUND_ENTITY(int entity)` | bool |
| `HAS_ENTITY_ANIM_FINISHED` | `bool HAS_ENTITY_ANIM_FINISHED(int entity, string animDict, string animName, int p3)` | bool |
| `HAS_ENTITY_BEEN_DAMAGED_BY_ANY_OBJECT` | `bool HAS_ENTITY_BEEN_DAMAGED_BY_ANY_OBJECT(int entity)` | bool |
| `HAS_ENTITY_BEEN_DAMAGED_BY_ANY_PED` | `bool HAS_ENTITY_BEEN_DAMAGED_BY_ANY_PED(int entity)` | bool |
| `HAS_ENTITY_BEEN_DAMAGED_BY_ANY_VEHICLE` | `bool HAS_ENTITY_BEEN_DAMAGED_BY_ANY_VEHICLE(int entity)` | bool |
| `HAS_ENTITY_BEEN_DAMAGED_BY_ENTITY` | `bool HAS_ENTITY_BEEN_DAMAGED_BY_ENTITY(int entity1, int entity2, bool p2)` | bool |
| `HAS_ENTITY_CLEAR_LOS_TO_ENTITY` | `bool HAS_ENTITY_CLEAR_LOS_TO_ENTITY(int entity1, int entity2, int traceType)` | bool |
| `HAS_ENTITY_CLEAR_LOS_TO_ENTITY_ADJUST_FOR_COVER` | `bool HAS_ENTITY_CLEAR_LOS_TO_ENTITY_ADJUST_FOR_COVER(int entity1, int entity2, int traceType)` | bool |
| `HAS_ENTITY_CLEAR_LOS_TO_ENTITY_IN_FRONT` | `bool HAS_ENTITY_CLEAR_LOS_TO_ENTITY_IN_FRONT(int entity1, int entity2)` | bool |
| `HAS_ENTITY_COLLIDED_WITH_ANYTHING` | `bool HAS_ENTITY_COLLIDED_WITH_ANYTHING(int entity)` | bool |
| `HAS_OBJECT_BEEN_BROKEN` | `bool HAS_OBJECT_BEEN_BROKEN(int object, object p1)` | bool |
| `HAS_PICKUP_BEEN_COLLECTED` | `bool HAS_PICKUP_BEEN_COLLECTED(int pickup)` | bool |
| `HIDE_PORTABLE_PICKUP_WHEN_DETACHED` | `void HIDE_PORTABLE_PICKUP_WHEN_DETACHED(int pickupObject, bool toggle)` | void |
| `IS_ANY_ENTITY_ENTIRELY_INSIDE_GARAGE` | `bool IS_ANY_ENTITY_ENTIRELY_INSIDE_GARAGE(uint garageHash, bool p1, bool p2, bool p3, object p4)` | bool |
| `IS_ANY_OBJECT_NEAR_POINT` | `bool IS_ANY_OBJECT_NEAR_POINT(float x, float y, float z, float range, bool p4)` | bool |
| `IS_AN_ENTITY` | `bool IS_AN_ENTITY(int handle)` | bool |
| `IS_DOOR_CLOSED` | `bool IS_DOOR_CLOSED(uint doorHash)` | bool |
| `IS_DOOR_REGISTERED_WITH_SYSTEM` | `bool IS_DOOR_REGISTERED_WITH_SYSTEM(uint doorHash)` | bool |
| `IS_ENTITY_AN_OBJECT` | `bool IS_ENTITY_AN_OBJECT(int entity)` | bool |
| `IS_ENTITY_ATTACHED` | `bool IS_ENTITY_ATTACHED(int entity)` | bool |
| `IS_ENTITY_ATTACHED_TO_ANY_OBJECT` | `bool IS_ENTITY_ATTACHED_TO_ANY_OBJECT(int entity)` | bool |
| `IS_ENTITY_ATTACHED_TO_ANY_PED` | `bool IS_ENTITY_ATTACHED_TO_ANY_PED(int entity)` | bool |
| `IS_ENTITY_ATTACHED_TO_ANY_VEHICLE` | `bool IS_ENTITY_ATTACHED_TO_ANY_VEHICLE(int entity)` | bool |
| `IS_ENTITY_ATTACHED_TO_ENTITY` | `bool IS_ENTITY_ATTACHED_TO_ENTITY(int from, int to)` | bool |
| `IS_ENTITY_AT_COORD` | `bool IS_ENTITY_AT_COORD(int entity, float xPos, float yPos, float zPos, float xSize, float ySize, float zSize, bool p7, bool p8, int p9)` | bool |
| `IS_ENTITY_AT_ENTITY` | `bool IS_ENTITY_AT_ENTITY(int entity1, int entity2, float xSize, float ySize, float zSize, bool p5, bool p6, int p7)` | bool |
| `IS_ENTITY_A_MISSION_ENTITY` | `bool IS_ENTITY_A_MISSION_ENTITY(int entity)` | bool |
| `IS_ENTITY_A_PED` | `bool IS_ENTITY_A_PED(int entity)` | bool |
| `IS_ENTITY_A_VEHICLE` | `bool IS_ENTITY_A_VEHICLE(int entity)` | bool |
| `IS_ENTITY_DEAD` | `bool IS_ENTITY_DEAD(int entity, bool p1)` | bool |
| `IS_ENTITY_IN_AIR` | `bool IS_ENTITY_IN_AIR(int entity)` | bool |
| `IS_ENTITY_IN_ANGLED_AREA` | `bool IS_ENTITY_IN_ANGLED_AREA(int entity, float x1, float y1, float z1, float x2, float y2, float z2, float width, bool debug, bool includeZ, object p10)` | bool |
| `IS_ENTITY_IN_AREA` | `bool IS_ENTITY_IN_AREA(int entity, float x1, float y1, float z1, float x2, float y2, float z2, bool p7, bool p8, object p9)` | bool |
| `IS_ENTITY_IN_WATER` | `bool IS_ENTITY_IN_WATER(int entity)` | bool |
| `IS_ENTITY_IN_ZONE` | `bool IS_ENTITY_IN_ZONE(int entity, string zone)` | bool |
| `IS_ENTITY_OCCLUDED` | `bool IS_ENTITY_OCCLUDED(int entity)` | bool |
| `IS_ENTITY_ON_SCREEN` | `bool IS_ENTITY_ON_SCREEN(int entity)` | bool |
| `IS_ENTITY_PLAYING_ANIM` | `bool IS_ENTITY_PLAYING_ANIM(int entity, string animDict, string animName, int taskFlag)` | bool |
| `IS_ENTITY_STATIC` | `bool IS_ENTITY_STATIC(int entity)` | bool |
| `IS_ENTITY_TOUCHING_ENTITY` | `bool IS_ENTITY_TOUCHING_ENTITY(int entity, int targetEntity)` | bool |
| `IS_ENTITY_TOUCHING_MODEL` | `bool IS_ENTITY_TOUCHING_MODEL(int entity, uint modelHash)` | bool |
| `IS_ENTITY_UPRIGHT` | `bool IS_ENTITY_UPRIGHT(int entity, float angle)` | bool |
| `IS_ENTITY_UPSIDEDOWN` | `bool IS_ENTITY_UPSIDEDOWN(int entity)` | bool |
| `IS_ENTITY_VISIBLE` | `bool IS_ENTITY_VISIBLE(int entity)` | bool |
| `IS_ENTITY_VISIBLE_TO_SCRIPT` | `bool IS_ENTITY_VISIBLE_TO_SCRIPT(int entity)` | bool |
| `IS_ENTITY_WAITING_FOR_WORLD_COLLISION` | `bool IS_ENTITY_WAITING_FOR_WORLD_COLLISION(int entity)` | bool |
| `IS_GARAGE_EMPTY` | `bool IS_GARAGE_EMPTY(uint garageHash, bool p1, int p2)` | bool |
| `IS_IN_ITEMSET` | `bool IS_IN_ITEMSET(int item, int itemset)` | bool |
| `IS_ITEMSET_VALID` | `bool IS_ITEMSET_VALID(int itemset)` | bool |
| `IS_OBJECT_A_PICKUP` | `bool IS_OBJECT_A_PICKUP(int object)` | bool |
| `IS_OBJECT_A_PORTABLE_PICKUP` | `bool IS_OBJECT_A_PORTABLE_PICKUP(int object)` | bool |
| `IS_OBJECT_ENTIRELY_INSIDE_GARAGE` | `bool IS_OBJECT_ENTIRELY_INSIDE_GARAGE(uint garageHash, int entity, float p2, int p3)` | bool |
| `IS_OBJECT_NEAR_POINT` | `bool IS_OBJECT_NEAR_POINT(uint objectHash, float x, float y, float z, float range)` | bool |
| `IS_OBJECT_PARTIALLY_INSIDE_GARAGE` | `bool IS_OBJECT_PARTIALLY_INSIDE_GARAGE(uint garageHash, int entity, int p2)` | bool |
| `IS_OBJECT_VISIBLE` | `bool IS_OBJECT_VISIBLE(int object)` | bool |
| `IS_PICKUP_WEAPON_OBJECT_VALID` | `bool IS_PICKUP_WEAPON_OBJECT_VALID(int object)` | bool |
| `IS_PLAYER_ENTIRELY_INSIDE_GARAGE` | `bool IS_PLAYER_ENTIRELY_INSIDE_GARAGE(uint garageHash, int player, float p2, int p3)` | bool |
| `IS_PLAYER_PARTIALLY_INSIDE_GARAGE` | `bool IS_PLAYER_PARTIALLY_INSIDE_GARAGE(uint garageHash, int player, int p2)` | bool |
| `IS_POINT_IN_ANGLED_AREA` | `bool IS_POINT_IN_ANGLED_AREA(float xPos, float yPos, float zPos, float x1, float y1, float z1, float x2, float y2, float z2, float width, bool debug, bool includeZ)` | bool |
| `IS_PROP_LIGHT_OVERRIDEN` | `bool IS_PROP_LIGHT_OVERRIDEN(int object)` | bool |
| `ONLY_CLEAN_UP_OBJECT_WHEN_OUT_OF_RANGE` | `void ONLY_CLEAN_UP_OBJECT_WHEN_OUT_OF_RANGE(int object)` | void |
| `OPEN_ALL_BARRIERS_FOR_RACE` | `void OPEN_ALL_BARRIERS_FOR_RACE(bool p0)` | void |
| `PLACE_OBJECT_ON_GROUND_OR_OBJECT_PROPERLY` | `bool PLACE_OBJECT_ON_GROUND_OR_OBJECT_PROPERLY(int object)` | bool |
| `PLACE_OBJECT_ON_GROUND_PROPERLY` | `bool PLACE_OBJECT_ON_GROUND_PROPERLY(int object)` | bool |
| `PLAY_ENTITY_ANIM` | `bool PLAY_ENTITY_ANIM(int entity, string animName, string animDict, float p3, bool loop, bool stayInAnim, bool p6, float delta, object bitset)` | bool |
| `PLAY_OBJECT_AUTO_START_ANIM` | `void PLAY_OBJECT_AUTO_START_ANIM(object p0)` | void |
| `PLAY_SYNCHRONIZED_ENTITY_ANIM` | `bool PLAY_SYNCHRONIZED_ENTITY_ANIM(int entity, int syncedScene, string animation, string propName, float p4, float p5, object p6, float p7)` | bool |
| `PLAY_SYNCHRONIZED_MAP_ENTITY_ANIM` | `bool PLAY_SYNCHRONIZED_MAP_ENTITY_ANIM(float x1, float y1, float z1, float x2, object y2, float z2, string p6, string p7, float p8, float p9, object p10, float p11)` | bool |
| `PREVENT_COLLECTION_OF_PORTABLE_PICKUP` | `void PREVENT_COLLECTION_OF_PORTABLE_PICKUP(int object, bool p1, bool p2)` | void |
| `PROCESS_ENTITY_ATTACHMENTS` | `void PROCESS_ENTITY_ATTACHMENTS(int entity)` | void |
| `REMOVE_ALL_PICKUPS_OF_TYPE` | `void REMOVE_ALL_PICKUPS_OF_TYPE(uint pickupHash)` | void |
| `REMOVE_DOOR_FROM_SYSTEM` | `void REMOVE_DOOR_FROM_SYSTEM(uint doorHash, object p1)` | void |
| `REMOVE_FORCED_OBJECT` | `void REMOVE_FORCED_OBJECT(float x, float y, float z, float p3, uint modelHash)` | void |
| `REMOVE_FROM_ITEMSET` | `void REMOVE_FROM_ITEMSET(int item, int itemset)` | void |
| `REMOVE_MODEL_HIDE` | `void REMOVE_MODEL_HIDE(float x, float y, float z, float radius, uint modelHash, bool p5)` | void |
| `REMOVE_MODEL_SWAP` | `void REMOVE_MODEL_SWAP(float x, float y, float z, float radius, uint originalModel, uint newModel, bool p6)` | void |
| `REMOVE_OBJECT_HIGH_DETAIL_MODEL` | `void REMOVE_OBJECT_HIGH_DETAIL_MODEL(int object)` | void |
| `REMOVE_PICKUP` | `void REMOVE_PICKUP(int pickup)` | void |
| `RENDER_FAKE_PICKUP_GLOW` | `void RENDER_FAKE_PICKUP_GLOW(float x, float y, float z, int colorIndex)` | void |
| `RESET_ENTITY_ALPHA` | `void RESET_ENTITY_ALPHA(int entity)` | void |
| `RESET_PICKUP_ENTITY_GLOW` | `void RESET_PICKUP_ENTITY_GLOW(int entity)` | void |
| `ROTATE_OBJECT` | `bool ROTATE_OBJECT(int object, float p1, float p2, bool p3)` | bool |
| `SET_ACTIVATE_OBJECT_PHYSICS_AS_SOON_AS_IT_IS_UNFROZEN` | `void SET_ACTIVATE_OBJECT_PHYSICS_AS_SOON_AS_IT_IS_UNFROZEN(int object, bool toggle)` | void |
| `SET_ALLOW_MIGRATE_TO_SPECTATOR` | `void SET_ALLOW_MIGRATE_TO_SPECTATOR(int entity, object p1)` | void |
| `SET_CAN_AUTO_VAULT_ON_ENTITY` | `void SET_CAN_AUTO_VAULT_ON_ENTITY(int entity, bool toggle)` | void |
| `SET_CAN_CLIMB_ON_ENTITY` | `void SET_CAN_CLIMB_ON_ENTITY(int entity, bool toggle)` | void |
| `SET_CUSTOM_PICKUP_WEAPON_HASH` | `void SET_CUSTOM_PICKUP_WEAPON_HASH(uint pickupHash, int pickup)` | void |
| `SET_CUTSCENES_WEAPON_FLASHLIGHT_ON_THIS_FRAME` | `void SET_CUTSCENES_WEAPON_FLASHLIGHT_ON_THIS_FRAME(int object, bool toggle)` | void |
| `SET_DISABLE_COLLISIONS_BETWEEN_CARS_AND_CAR_PARACHUTE` | `void SET_DISABLE_COLLISIONS_BETWEEN_CARS_AND_CAR_PARACHUTE(object p0)` | void |
| `SET_DRIVE_ARTICULATED_JOINT` | `void SET_DRIVE_ARTICULATED_JOINT(int object, bool toggle, int p2)` | void |
| `SET_DRIVE_ARTICULATED_JOINT_WITH_INFLICTOR` | `void SET_DRIVE_ARTICULATED_JOINT_WITH_INFLICTOR(int object, bool toggle, int p2, int ped)` | void |
| `SET_ENTITY_ALPHA` | `void SET_ENTITY_ALPHA(int entity, int alphaLevel, bool skin)` | void |
| `SET_ENTITY_ALWAYS_PRERENDER` | `void SET_ENTITY_ALWAYS_PRERENDER(int entity, bool toggle)` | void |
| `SET_ENTITY_ANGULAR_VELOCITY` | `void SET_ENTITY_ANGULAR_VELOCITY(int entity, float x, float y, float z)` | void |
| `SET_ENTITY_ANIM_CURRENT_TIME` | `void SET_ENTITY_ANIM_CURRENT_TIME(int entity, string animDictionary, string animName, float time)` | void |
| `SET_ENTITY_ANIM_SPEED` | `void SET_ENTITY_ANIM_SPEED(int entity, string animDictionary, string animName, float speedMultiplier)` | void |
| `SET_ENTITY_AS_MISSION_ENTITY` | `void SET_ENTITY_AS_MISSION_ENTITY(int entity, bool p1, bool p2)` | void |
| `SET_ENTITY_AS_NO_LONGER_NEEDED` | `void SET_ENTITY_AS_NO_LONGER_NEEDED(Entity* entity)` | void |
| `SET_ENTITY_CANT_CAUSE_COLLISION_DAMAGED_ENTITY` | `void SET_ENTITY_CANT_CAUSE_COLLISION_DAMAGED_ENTITY(int entity1, int entity2)` | void |
| `SET_ENTITY_CAN_BE_DAMAGED` | `void SET_ENTITY_CAN_BE_DAMAGED(int entity, bool toggle)` | void |
| `SET_ENTITY_CAN_BE_DAMAGED_BY_RELATIONSHIP_GROUP` | `void SET_ENTITY_CAN_BE_DAMAGED_BY_RELATIONSHIP_GROUP(int entity, bool bCanBeDamaged, int relGroup)` | void |
| `SET_ENTITY_CAN_BE_TARGETED_WITHOUT_LOS` | `void SET_ENTITY_CAN_BE_TARGETED_WITHOUT_LOS(int entity, bool toggle)` | void |
| `SET_ENTITY_CAN_ONLY_BE_DAMAGED_BY_ENTITY` | `void SET_ENTITY_CAN_ONLY_BE_DAMAGED_BY_ENTITY(int entity1, int entity2)` | void |
| `SET_ENTITY_CAN_ONLY_BE_DAMAGED_BY_SCRIPT_PARTICIPANTS` | `void SET_ENTITY_CAN_ONLY_BE_DAMAGED_BY_SCRIPT_PARTICIPANTS(int entity, bool toggle)` | void |
| `SET_ENTITY_COLLISION` | `void SET_ENTITY_COLLISION(int entity, bool toggle, bool keepPhysics)` | void |
| `SET_ENTITY_COMPLETELY_DISABLE_COLLISION` | `void SET_ENTITY_COMPLETELY_DISABLE_COLLISION(int entity, bool toggle, bool keepPhysics)` | void |
| `SET_ENTITY_COORDS` | `void SET_ENTITY_COORDS(int entity, float xPos, float yPos, float zPos, bool xAxis, bool yAxis, bool zAxis, bool clearArea)` | void |
| `SET_ENTITY_COORDS_NO_OFFSET` | `void SET_ENTITY_COORDS_NO_OFFSET(int entity, float xPos, float yPos, float zPos, bool xAxis, bool yAxis, bool zAxis)` | void |
| `SET_ENTITY_COORDS_WITHOUT_PLANTS_RESET` | `void SET_ENTITY_COORDS_WITHOUT_PLANTS_RESET(int entity, float xPos, float yPos, float zPos, bool alive, bool deadFlag, bool ragdollFlag, bool clearArea)` | void |
| `SET_ENTITY_DYNAMIC` | `void SET_ENTITY_DYNAMIC(int entity, bool toggle)` | void |
| `SET_ENTITY_FLAG_RENDER_SMALL_SHADOW` | `void SET_ENTITY_FLAG_RENDER_SMALL_SHADOW(int object, bool toggle)` | void |
| `SET_ENTITY_FLAG_SUPPRESS_SHADOW` | `void SET_ENTITY_FLAG_SUPPRESS_SHADOW(int entity, bool toggle)` | void |
| `SET_ENTITY_HAS_GRAVITY` | `void SET_ENTITY_HAS_GRAVITY(int entity, bool toggle)` | void |
| `SET_ENTITY_HEADING` | `void SET_ENTITY_HEADING(int entity, float heading)` | void |
| `SET_ENTITY_HEALTH` | `void SET_ENTITY_HEALTH(int entity, int health, int instigator, uint weaponType)` | void |
| `SET_ENTITY_INVINCIBLE` | `void SET_ENTITY_INVINCIBLE(int entity, bool toggle, bool dontResetOnCleanup)` | void |
| `SET_ENTITY_IS_IN_VEHICLE` | `void SET_ENTITY_IS_IN_VEHICLE(int entity)` | void |
| `SET_ENTITY_IS_TARGET_PRIORITY` | `void SET_ENTITY_IS_TARGET_PRIORITY(int entity, bool p1, float p2)` | void |
| `SET_ENTITY_LIGHTS` | `void SET_ENTITY_LIGHTS(int entity, bool toggle)` | void |
| `SET_ENTITY_LOAD_COLLISION_FLAG` | `void SET_ENTITY_LOAD_COLLISION_FLAG(int entity, bool toggle, object p2)` | void |
| `SET_ENTITY_LOD_DIST` | `void SET_ENTITY_LOD_DIST(int entity, int value)` | void |
| `SET_ENTITY_MAX_HEALTH` | `void SET_ENTITY_MAX_HEALTH(int entity, int value)` | void |
| `SET_ENTITY_MAX_SPEED` | `void SET_ENTITY_MAX_SPEED(int entity, float speed)` | void |
| `SET_ENTITY_MIRROR_REFLECTION_FLAG` | `void SET_ENTITY_MIRROR_REFLECTION_FLAG(int entity, bool p1)` | void |
| `SET_ENTITY_MOTION_BLUR` | `void SET_ENTITY_MOTION_BLUR(int entity, bool toggle)` | void |
| `SET_ENTITY_NOWEAPONDECALS` | `void SET_ENTITY_NOWEAPONDECALS(int entity, bool p1)` | void |
| `SET_ENTITY_NO_COLLISION_ENTITY` | `void SET_ENTITY_NO_COLLISION_ENTITY(int entity1, int entity2, bool thisFrameOnly)` | void |
| `SET_ENTITY_ONLY_DAMAGED_BY_PLAYER` | `void SET_ENTITY_ONLY_DAMAGED_BY_PLAYER(int entity, bool toggle)` | void |
| `SET_ENTITY_ONLY_DAMAGED_BY_RELATIONSHIP_GROUP` | `void SET_ENTITY_ONLY_DAMAGED_BY_RELATIONSHIP_GROUP(int entity, bool p1, object p2)` | void |
| `SET_ENTITY_PROOFS` | `void SET_ENTITY_PROOFS(int entity, bool bulletProof, bool fireProof, bool explosionProof, bool collisionProof, bool meleeProof, bool steamProof, bool dontResetOnCleanup, bool waterProof)` | void |
| `SET_ENTITY_QUATERNION` | `void SET_ENTITY_QUATERNION(int entity, float x, float y, float z, float w)` | void |
| `SET_ENTITY_RECORDS_COLLISIONS` | `void SET_ENTITY_RECORDS_COLLISIONS(int entity, bool toggle)` | void |
| `SET_ENTITY_RENDER_SCORCHED` | `void SET_ENTITY_RENDER_SCORCHED(int entity, bool toggle)` | void |
| `SET_ENTITY_REQUIRES_MORE_EXPENSIVE_RIVER_CHECK` | `void SET_ENTITY_REQUIRES_MORE_EXPENSIVE_RIVER_CHECK(int entity, bool toggle)` | void |
| `SET_ENTITY_ROTATION` | `void SET_ENTITY_ROTATION(int entity, float pitch, float roll, float yaw, int rotationOrder, bool p5)` | void |
| `SET_ENTITY_SHOULD_FREEZE_WAITING_ON_COLLISION` | `void SET_ENTITY_SHOULD_FREEZE_WAITING_ON_COLLISION(int entity, bool toggle)` | void |
| `SET_ENTITY_SORT_BIAS` | `void SET_ENTITY_SORT_BIAS(int entity, float p1)` | void |
| `SET_ENTITY_TRAFFICLIGHT_OVERRIDE` | `void SET_ENTITY_TRAFFICLIGHT_OVERRIDE(int entity, int state)` | void |
| `SET_ENTITY_USE_MAX_DISTANCE_FOR_WATER_REFLECTION` | `void SET_ENTITY_USE_MAX_DISTANCE_FOR_WATER_REFLECTION(int entity, bool p1)` | void |
| `SET_ENTITY_VELOCITY` | `void SET_ENTITY_VELOCITY(int entity, float x, float y, float z)` | void |
| `SET_ENTITY_VISIBLE` | `void SET_ENTITY_VISIBLE(int entity, bool toggle, bool p2)` | void |
| `SET_ENTITY_WATER_REFLECTION_FLAG` | `void SET_ENTITY_WATER_REFLECTION_FLAG(int entity, bool toggle)` | void |
| `SET_FORCE_OBJECT_THIS_FRAME` | `void SET_FORCE_OBJECT_THIS_FRAME(float x, float y, float z, float p3)` | void |
| `SET_IS_OBJECT_ARTICULATED` | `void SET_IS_OBJECT_ARTICULATED(int object, bool toggle)` | void |
| `SET_IS_OBJECT_BALL` | `void SET_IS_OBJECT_BALL(int object, bool toggle)` | void |
| `SET_LOCAL_PLAYER_CAN_COLLECT_PORTABLE_PICKUPS` | `void SET_LOCAL_PLAYER_CAN_COLLECT_PORTABLE_PICKUPS(bool toggle)` | void |
| `SET_LOCAL_PLAYER_PERMITTED_TO_COLLECT_PICKUPS_WITH_MODEL` | `void SET_LOCAL_PLAYER_PERMITTED_TO_COLLECT_PICKUPS_WITH_MODEL(uint modelHash, bool toggle)` | void |
| `SET_LOCKED_UNSTREAMED_IN_DOOR_OF_TYPE` | `void SET_LOCKED_UNSTREAMED_IN_DOOR_OF_TYPE(uint modelHash, float x, float y, float z, bool locked, float xRotMult, float yRotMult, float zRotMult)` | void |
| `SET_MAX_NUM_PORTABLE_PICKUPS_CARRIED_BY_PLAYER` | `void SET_MAX_NUM_PORTABLE_PICKUPS_CARRIED_BY_PLAYER(uint modelHash, int number)` | void |
| `SET_OBJECT_ALLOW_LOW_LOD_BUOYANCY` | `void SET_OBJECT_ALLOW_LOW_LOD_BUOYANCY(int object, bool toggle)` | void |
| `SET_OBJECT_AS_NO_LONGER_NEEDED` | `void SET_OBJECT_AS_NO_LONGER_NEEDED(Object* object)` | void |
| `SET_OBJECT_FORCE_VEHICLES_TO_AVOID` | `void SET_OBJECT_FORCE_VEHICLES_TO_AVOID(int object, bool toggle)` | void |
| `SET_OBJECT_GLOW_IN_SAME_TEAM` | `void SET_OBJECT_GLOW_IN_SAME_TEAM(int pickup)` | void |
| `SET_OBJECT_IS_A_PRESSURE_PLATE` | `void SET_OBJECT_IS_A_PRESSURE_PLATE(int object, bool toggle)` | void |
| `SET_OBJECT_IS_SPECIAL_GOLFBALL` | `void SET_OBJECT_IS_SPECIAL_GOLFBALL(int object, bool toggle)` | void |
| `SET_OBJECT_IS_VISIBLE_IN_MIRRORS` | `void SET_OBJECT_IS_VISIBLE_IN_MIRRORS(int object, bool toggle)` | void |
| `SET_OBJECT_PHYSICS_PARAMS` | `void SET_OBJECT_PHYSICS_PARAMS(int object, float weight, float p2, float p3, float p4, float p5, float gravity, float p7, float p8, float p9, float p10, float buoyancy)` | void |
| `SET_OBJECT_SPEED_BOOST_AMOUNT` | `void SET_OBJECT_SPEED_BOOST_AMOUNT(int object, object p1)` | void |
| `SET_OBJECT_SPEED_BOOST_DURATION` | `void SET_OBJECT_SPEED_BOOST_DURATION(int object, float duration)` | void |
| `SET_OBJECT_TAKES_DAMAGE_FROM_COLLIDING_WITH_BUILDINGS` | `void SET_OBJECT_TAKES_DAMAGE_FROM_COLLIDING_WITH_BUILDINGS(object p0, bool p1)` | void |
| `SET_OBJECT_TARGETTABLE` | `void SET_OBJECT_TARGETTABLE(int object, bool targettable, object p2)` | void |
| `SET_OBJECT_TINT_INDEX` | `void SET_OBJECT_TINT_INDEX(int object, int textureVariation)` | void |
| `SET_ONLY_ALLOW_AMMO_COLLECTION_WHEN_LOW` | `void SET_ONLY_ALLOW_AMMO_COLLECTION_WHEN_LOW(bool p0)` | void |
| `SET_PED_AS_NO_LONGER_NEEDED` | `void SET_PED_AS_NO_LONGER_NEEDED(Ped* ped)` | void |
| `SET_PICKUP_COLLIDES_WITH_PROJECTILES` | `void SET_PICKUP_COLLIDES_WITH_PROJECTILES(object p0, object p1)` | void |
| `SET_PICKUP_GENERATION_RANGE_MULTIPLIER` | `void SET_PICKUP_GENERATION_RANGE_MULTIPLIER(float multiplier)` | void |
| `SET_PICKUP_GLOW_OFFSET` | `void SET_PICKUP_GLOW_OFFSET(int pickup, float p1)` | void |
| `SET_PICKUP_HIDDEN_WHEN_UNCOLLECTABLE` | `void SET_PICKUP_HIDDEN_WHEN_UNCOLLECTABLE(int pickup, bool toggle)` | void |
| `SET_PICKUP_OBJECT_ALPHA_WHEN_TRANSPARENT` | `void SET_PICKUP_OBJECT_ALPHA_WHEN_TRANSPARENT(int p0)` | void |
| `SET_PICKUP_OBJECT_ARROW_MARKER` | `void SET_PICKUP_OBJECT_ARROW_MARKER(int pickup, bool toggle)` | void |
| `SET_PICKUP_OBJECT_COLLECTABLE_IN_VEHICLE` | `void SET_PICKUP_OBJECT_COLLECTABLE_IN_VEHICLE(int pickup)` | void |
| `SET_PICKUP_OBJECT_GLOW_OFFSET` | `void SET_PICKUP_OBJECT_GLOW_OFFSET(int pickup, float p1, bool p2)` | void |
| `SET_PICKUP_OBJECT_GLOW_WHEN_UNCOLLECTABLE` | `void SET_PICKUP_OBJECT_GLOW_WHEN_UNCOLLECTABLE(int pickup, bool toggle)` | void |
| `SET_PICKUP_OBJECT_TRANSPARENT_WHEN_UNCOLLECTABLE` | `void SET_PICKUP_OBJECT_TRANSPARENT_WHEN_UNCOLLECTABLE(int pickup, bool toggle)` | void |
| `SET_PICKUP_REGENERATION_TIME` | `void SET_PICKUP_REGENERATION_TIME(int pickup, int duration)` | void |
| `SET_PICKUP_TRACK_DAMAGE_EVENTS` | `void SET_PICKUP_TRACK_DAMAGE_EVENTS(int pickup, bool toggle)` | void |
| `SET_PICKUP_TRANSPARENT_WHEN_UNCOLLECTABLE` | `void SET_PICKUP_TRANSPARENT_WHEN_UNCOLLECTABLE(int pickup, bool toggle)` | void |
| `SET_PICKUP_UNCOLLECTABLE` | `void SET_PICKUP_UNCOLLECTABLE(int pickup, bool toggle)` | void |
| `SET_PICK_UP_BY_CARGOBOB_DISABLED` | `void SET_PICK_UP_BY_CARGOBOB_DISABLED(int entity, bool toggle)` | void |
| `SET_PLAYER_PERMITTED_TO_COLLECT_PICKUPS_OF_TYPE` | `void SET_PLAYER_PERMITTED_TO_COLLECT_PICKUPS_OF_TYPE(int player, uint pickupHash, bool toggle)` | void |
| `SET_PORTABLE_PICKUP_PERSIST` | `void SET_PORTABLE_PICKUP_PERSIST(int pickup, bool toggle)` | void |
| `SET_PROJECTILES_SHOULD_EXPLODE_ON_CONTACT` | `void SET_PROJECTILES_SHOULD_EXPLODE_ON_CONTACT(int entity, object p1)` | void |
| `SET_PROP_LIGHT_COLOR` | `bool SET_PROP_LIGHT_COLOR(int object, bool p1, int r, int g, int b)` | bool |
| `SET_PROP_TINT_INDEX` | `void SET_PROP_TINT_INDEX(object p0, object p1)` | void |
| `SET_STATE_OF_CLOSEST_DOOR_OF_TYPE` | `void SET_STATE_OF_CLOSEST_DOOR_OF_TYPE(uint type, float x, float y, float z, bool locked, float heading, bool p6)` | void |
| `SET_STATE_OF_RAYFIRE_MAP_OBJECT` | `void SET_STATE_OF_RAYFIRE_MAP_OBJECT(int object, int state)` | void |
| `SET_TEAM_PICKUP_OBJECT` | `void SET_TEAM_PICKUP_OBJECT(int object, object p1, bool p2)` | void |
| `SET_TINT_INDEX_CLOSEST_BUILDING_OF_TYPE` | `bool SET_TINT_INDEX_CLOSEST_BUILDING_OF_TYPE(float x, float y, float z, float radius, uint modelHash, int textureVariation)` | bool |
| `SET_VEHICLE_AS_NO_LONGER_NEEDED` | `void SET_VEHICLE_AS_NO_LONGER_NEEDED(Vehicle* vehicle)` | void |
| `SET_WAIT_FOR_COLLISIONS_BEFORE_PROBE` | `void SET_WAIT_FOR_COLLISIONS_BEFORE_PROBE(int entity, bool toggle)` | void |
| `SET_WEAPON_IMPACTS_APPLY_GREATER_FORCE` | `void SET_WEAPON_IMPACTS_APPLY_GREATER_FORCE(int object, bool p1)` | void |
| `SLIDE_OBJECT` | `bool SLIDE_OBJECT(int object, float toX, float toY, float toZ, float speedX, float speedY, float speedZ, bool collision)` | bool |
| `STOP_ENTITY_ANIM` | `bool STOP_ENTITY_ANIM(int entity, string animation, string animGroup, float p3)` | bool |
| `STOP_SYNCHRONIZED_ENTITY_ANIM` | `bool STOP_SYNCHRONIZED_ENTITY_ANIM(int entity, float p1, bool p2)` | bool |
| `STOP_SYNCHRONIZED_MAP_ENTITY_ANIM` | `bool STOP_SYNCHRONIZED_MAP_ENTITY_ANIM(float x1, float y1, float z1, float x2, object y2, float z2)` | bool |
| `SUPPRESS_PICKUP_REWARD_TYPE` | `void SUPPRESS_PICKUP_REWARD_TYPE(int rewardType, bool suppress)` | void |
| `SUPPRESS_PICKUP_SOUND_FOR_PICKUP` | `void SUPPRESS_PICKUP_SOUND_FOR_PICKUP(object p0, object p1)` | void |
| `TRACK_OBJECT_VISIBILITY` | `void TRACK_OBJECT_VISIBILITY(int object)` | void |
| `WOULD_ENTITY_BE_OCCLUDED` | `bool WOULD_ENTITY_BE_OCCLUDED(uint entityModelHash, float x, float y, float z, bool p4)` | bool |
| `_GET_LAST_ENTITY_HIT_BY_ENTITY` | `int _GET_LAST_ENTITY_HIT_BY_ENTITY(int entity)` | int |
| `_SET_ENTITY_NO_COLLISION_WITH_NETWORKED_ENTITY` | `void _SET_ENTITY_NO_COLLISION_WITH_NETWORKED_ENTITY(int entity1, int entity2)` | void |
| `_SET_OBJECT_TARGETTABLE_BY_PLAYER` | `void _SET_OBJECT_TARGETTABLE_BY_PLAYER(int object, bool setFlag34, bool setFlag35)` | void |
| `_SET_PICKUP_GLOW_DISABLED` | `void _SET_PICKUP_GLOW_DISABLED(int pickup, bool toggle)` | void |

---

## PLAYER

| 函数名 | 签名 | 返回值 |
|--------|------|--------|
| `ADD_PLAYER_TARGETABLE_ENTITY` | `void ADD_PLAYER_TARGETABLE_ENTITY(int player, int entity)` | void |
| `ALLOW_EVASION_HUD_IF_DISABLING_HIDDEN_EVASION_THIS_FRAME` | `void ALLOW_EVASION_HUD_IF_DISABLING_HIDDEN_EVASION_THIS_FRAME(int player, object p1)` | void |
| `ARE_PLAYER_FLASHING_STARS_ABOUT_TO_DROP` | `bool ARE_PLAYER_FLASHING_STARS_ABOUT_TO_DROP(int player)` | bool |
| `ARE_PLAYER_STARS_GREYED_OUT` | `bool ARE_PLAYER_STARS_GREYED_OUT(int player)` | bool |
| `ASSISTED_MOVEMENT_CLOSE_ROUTE` | `void ASSISTED_MOVEMENT_CLOSE_ROUTE()` | void |
| `ASSISTED_MOVEMENT_FLUSH_ROUTE` | `void ASSISTED_MOVEMENT_FLUSH_ROUTE()` | void |
| `CAN_PED_HEAR_PLAYER` | `bool CAN_PED_HEAR_PLAYER(int player, int ped)` | bool |
| `CAN_PLAYER_START_MISSION` | `bool CAN_PLAYER_START_MISSION(int player)` | bool |
| `CHANGE_PLAYER_PED` | `void CHANGE_PLAYER_PED(int player, int ped, bool p2, bool resetDamage)` | void |
| `CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED` | `void CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED(int player)` | void |
| `CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_PED` | `void CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_PED(int player)` | void |
| `CLEAR_PLAYER_PARACHUTE_MODEL_OVERRIDE` | `void CLEAR_PLAYER_PARACHUTE_MODEL_OVERRIDE(int player)` | void |
| `CLEAR_PLAYER_PARACHUTE_PACK_MODEL_OVERRIDE` | `void CLEAR_PLAYER_PARACHUTE_PACK_MODEL_OVERRIDE(int player)` | void |
| `CLEAR_PLAYER_PARACHUTE_VARIATION_OVERRIDE` | `void CLEAR_PLAYER_PARACHUTE_VARIATION_OVERRIDE(int player)` | void |
| `CLEAR_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE` | `void CLEAR_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE(int player)` | void |
| `CLEAR_PLAYER_WANTED_LEVEL` | `void CLEAR_PLAYER_WANTED_LEVEL(int player)` | void |
| `DISABLE_CAMERA_VIEW_MODE_CYCLE` | `void DISABLE_CAMERA_VIEW_MODE_CYCLE(int player)` | void |
| `DISABLE_PLAYER_FIRING` | `void DISABLE_PLAYER_FIRING(int player, bool toggle)` | void |
| `DISABLE_PLAYER_HEALTH_RECHARGE` | `void DISABLE_PLAYER_HEALTH_RECHARGE(int player)` | void |
| `DISABLE_PLAYER_THROW_GRENADE_WHILE_USING_GUN` | `void DISABLE_PLAYER_THROW_GRENADE_WHILE_USING_GUN()` | void |
| `DISABLE_PLAYER_VEHICLE_REWARDS` | `void DISABLE_PLAYER_VEHICLE_REWARDS(int player)` | void |
| `DISPLAY_SYSTEM_SIGNIN_UI` | `void DISPLAY_SYSTEM_SIGNIN_UI(bool p0)` | void |
| `ENABLE_SPECIAL_ABILITY` | `void ENABLE_SPECIAL_ABILITY(int player, bool toggle, object p2)` | void |
| `EXTEND_WORLD_BOUNDARY_FOR_PLAYER` | `void EXTEND_WORLD_BOUNDARY_FOR_PLAYER(float x, float y, float z)` | void |
| `FORCE_CLEANUP` | `void FORCE_CLEANUP(int cleanupFlags)` | void |
| `FORCE_CLEANUP_FOR_ALL_THREADS_WITH_THIS_NAME` | `void FORCE_CLEANUP_FOR_ALL_THREADS_WITH_THIS_NAME(string name, int cleanupFlags)` | void |
| `FORCE_CLEANUP_FOR_THREAD_WITH_THIS_ID` | `void FORCE_CLEANUP_FOR_THREAD_WITH_THIS_ID(int id, int cleanupFlags)` | void |
| `FORCE_START_HIDDEN_EVASION` | `void FORCE_START_HIDDEN_EVASION(int player)` | void |
| `GET_ACHIEVEMENT_PROGRESS` | `int GET_ACHIEVEMENT_PROGRESS(int achievementId)` | int |
| `GET_ARE_CAMERA_CONTROLS_DISABLED` | `bool GET_ARE_CAMERA_CONTROLS_DISABLED()` | bool |
| `GET_CAUSE_OF_MOST_RECENT_FORCE_CLEANUP` | `int GET_CAUSE_OF_MOST_RECENT_FORCE_CLEANUP()` | int |
| `GET_ENTITY_PLAYER_IS_FREE_AIMING_AT` | `bool GET_ENTITY_PLAYER_IS_FREE_AIMING_AT(int player, Entity* entity)` | bool |
| `GET_IS_MOPPING_AREA_FREE_IN_FRONT_OF_PLAYER` | `bool GET_IS_MOPPING_AREA_FREE_IN_FRONT_OF_PLAYER(int player, float p1)` | bool |
| `GET_IS_PLAYER_DRIVING_ON_HIGHWAY` | `bool GET_IS_PLAYER_DRIVING_ON_HIGHWAY(int player)` | bool |
| `GET_IS_PLAYER_DRIVING_WRECKLESS` | `bool GET_IS_PLAYER_DRIVING_WRECKLESS(int player, int p1)` | bool |
| `GET_IS_USING_FPS_THIRD_PERSON_COVER` | `bool GET_IS_USING_FPS_THIRD_PERSON_COVER()` | bool |
| `GET_IS_USING_HOOD_CAMERA` | `bool GET_IS_USING_HOOD_CAMERA()` | bool |
| `GET_MAX_WANTED_LEVEL` | `int GET_MAX_WANTED_LEVEL()` | int |
| `GET_NUMBER_OF_PLAYERS` | `int GET_NUMBER_OF_PLAYERS()` | int |
| `GET_NUMBER_OF_PLAYERS_IN_TEAM` | `int GET_NUMBER_OF_PLAYERS_IN_TEAM(int team)` | int |
| `GET_PLAYERS_LAST_VEHICLE` | `int GET_PLAYERS_LAST_VEHICLE()` | int |
| `GET_PLAYER_CURRENT_STEALTH_NOISE` | `float GET_PLAYER_CURRENT_STEALTH_NOISE(int player)` | float |
| `GET_PLAYER_DEBUG_INVINCIBLE` | `bool GET_PLAYER_DEBUG_INVINCIBLE(int player)` | bool |
| `GET_PLAYER_FAKE_WANTED_LEVEL` | `int GET_PLAYER_FAKE_WANTED_LEVEL(int player)` | int |
| `GET_PLAYER_GROUP` | `int GET_PLAYER_GROUP(int player)` | int |
| `GET_PLAYER_HAS_RESERVE_PARACHUTE` | `bool GET_PLAYER_HAS_RESERVE_PARACHUTE(int player)` | bool |
| `GET_PLAYER_HEALTH_RECHARGE_MAX_PERCENT` | `float GET_PLAYER_HEALTH_RECHARGE_MAX_PERCENT(int player)` | float |
| `GET_PLAYER_INDEX` | `int GET_PLAYER_INDEX()` | int |
| `GET_PLAYER_INVINCIBLE` | `bool GET_PLAYER_INVINCIBLE(int player)` | bool |
| `GET_PLAYER_MAX_ARMOUR` | `int GET_PLAYER_MAX_ARMOUR(int player)` | int |
| `GET_PLAYER_NAME` | `string GET_PLAYER_NAME(int player)` | string |
| `GET_PLAYER_PARACHUTE_MODEL_OVERRIDE` | `uint GET_PLAYER_PARACHUTE_MODEL_OVERRIDE(int player)` | uint |
| `GET_PLAYER_PARACHUTE_PACK_TINT_INDEX` | `void GET_PLAYER_PARACHUTE_PACK_TINT_INDEX(int player, ref int tintIndex)` | void |
| `GET_PLAYER_PARACHUTE_SMOKE_TRAIL_COLOR` | `void GET_PLAYER_PARACHUTE_SMOKE_TRAIL_COLOR(int player, ref int r, ref int g, ref int b)` | void |
| `GET_PLAYER_PARACHUTE_TINT_INDEX` | `void GET_PLAYER_PARACHUTE_TINT_INDEX(int player, ref int tintIndex)` | void |
| `GET_PLAYER_PED` | `int GET_PLAYER_PED(int player)` | int |
| `GET_PLAYER_PED_SCRIPT_INDEX` | `int GET_PLAYER_PED_SCRIPT_INDEX(int player)` | int |
| `GET_PLAYER_RECEIVED_BATTLE_EVENT_RECENTLY` | `bool GET_PLAYER_RECEIVED_BATTLE_EVENT_RECENTLY(int player, int p1, bool p2)` | bool |
| `GET_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE` | `uint GET_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE(int player)` | uint |
| `GET_PLAYER_RESERVE_PARACHUTE_TINT_INDEX` | `void GET_PLAYER_RESERVE_PARACHUTE_TINT_INDEX(int player, ref int index)` | void |
| `GET_PLAYER_RGB_COLOUR` | `void GET_PLAYER_RGB_COLOUR(int player, ref int r, ref int g, ref int b)` | void |
| `GET_PLAYER_SPRINT_STAMINA_REMAINING` | `float GET_PLAYER_SPRINT_STAMINA_REMAINING(int player)` | float |
| `GET_PLAYER_SPRINT_TIME_REMAINING` | `float GET_PLAYER_SPRINT_TIME_REMAINING(int player)` | float |
| `GET_PLAYER_TARGETING_MODE` | `int GET_PLAYER_TARGETING_MODE()` | int |
| `GET_PLAYER_TARGET_ENTITY` | `bool GET_PLAYER_TARGET_ENTITY(int player, Entity* entity)` | bool |
| `GET_PLAYER_TEAM` | `int GET_PLAYER_TEAM(int player)` | int |
| `GET_PLAYER_UNDERWATER_TIME_REMAINING` | `float GET_PLAYER_UNDERWATER_TIME_REMAINING(int player)` | float |
| `GET_PLAYER_WANTED_CENTRE_POSITION` | `Vector3 GET_PLAYER_WANTED_CENTRE_POSITION(int player)` | Vector3 |
| `GET_PLAYER_WANTED_LEVEL` | `int GET_PLAYER_WANTED_LEVEL(int player)` | int |
| `GET_TIME_SINCE_LAST_ARREST` | `int GET_TIME_SINCE_LAST_ARREST()` | int |
| `GET_TIME_SINCE_LAST_DEATH` | `int GET_TIME_SINCE_LAST_DEATH()` | int |
| `GET_TIME_SINCE_PLAYER_DROVE_AGAINST_TRAFFIC` | `int GET_TIME_SINCE_PLAYER_DROVE_AGAINST_TRAFFIC(int player)` | int |
| `GET_TIME_SINCE_PLAYER_DROVE_ON_PAVEMENT` | `int GET_TIME_SINCE_PLAYER_DROVE_ON_PAVEMENT(int player)` | int |
| `GET_TIME_SINCE_PLAYER_HIT_PED` | `int GET_TIME_SINCE_PLAYER_HIT_PED(int player)` | int |
| `GET_TIME_SINCE_PLAYER_HIT_VEHICLE` | `int GET_TIME_SINCE_PLAYER_HIT_VEHICLE(int player)` | int |
| `GET_WANTED_LEVEL_RADIUS` | `float GET_WANTED_LEVEL_RADIUS(int player)` | float |
| `GET_WANTED_LEVEL_THRESHOLD` | `int GET_WANTED_LEVEL_THRESHOLD(int wantedLevel)` | int |
| `GET_WANTED_LEVEL_TIME_TO_ESCAPE` | `int GET_WANTED_LEVEL_TIME_TO_ESCAPE()` | int |
| `GIVE_ACHIEVEMENT_TO_PLAYER` | `bool GIVE_ACHIEVEMENT_TO_PLAYER(int achievementId)` | bool |
| `GIVE_PLAYER_RAGDOLL_CONTROL` | `void GIVE_PLAYER_RAGDOLL_CONTROL(int player, bool toggle)` | void |
| `HAS_ACHIEVEMENT_BEEN_PASSED` | `bool HAS_ACHIEVEMENT_BEEN_PASSED(int achievementId)` | bool |
| `HAS_FORCE_CLEANUP_OCCURRED` | `bool HAS_FORCE_CLEANUP_OCCURRED(int cleanupFlags)` | bool |
| `HAS_PLAYER_BEEN_SPOTTED_IN_STOLEN_VEHICLE` | `bool HAS_PLAYER_BEEN_SPOTTED_IN_STOLEN_VEHICLE(int player)` | bool |
| `HAS_PLAYER_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED` | `bool HAS_PLAYER_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED(int player)` | bool |
| `HAS_PLAYER_DAMAGED_AT_LEAST_ONE_PED` | `bool HAS_PLAYER_DAMAGED_AT_LEAST_ONE_PED(int player)` | bool |
| `HAS_PLAYER_LEFT_THE_WORLD` | `bool HAS_PLAYER_LEFT_THE_WORLD(int player)` | bool |
| `INCREASE_PLAYER_JUMP_SUPPRESSION_RANGE` | `void INCREASE_PLAYER_JUMP_SUPPRESSION_RANGE(int player)` | void |
| `INT_TO_PARTICIPANTINDEX` | `int INT_TO_PARTICIPANTINDEX(int value)` | int |
| `INT_TO_PLAYERINDEX` | `int INT_TO_PLAYERINDEX(int value)` | int |
| `IS_PLAYER_BATTLE_AWARE` | `bool IS_PLAYER_BATTLE_AWARE(int player)` | bool |
| `IS_PLAYER_BEING_ARRESTED` | `bool IS_PLAYER_BEING_ARRESTED(int player, bool atArresting)` | bool |
| `IS_PLAYER_BLUETOOTH_ENABLE` | `bool IS_PLAYER_BLUETOOTH_ENABLE(int player)` | bool |
| `IS_PLAYER_CLIMBING` | `bool IS_PLAYER_CLIMBING(int player)` | bool |
| `IS_PLAYER_CONTROL_ON` | `bool IS_PLAYER_CONTROL_ON(int player)` | bool |
| `IS_PLAYER_DEAD` | `bool IS_PLAYER_DEAD(int player)` | bool |
| `IS_PLAYER_FREE_AIMING` | `bool IS_PLAYER_FREE_AIMING(int player)` | bool |
| `IS_PLAYER_FREE_AIMING_AT_ENTITY` | `bool IS_PLAYER_FREE_AIMING_AT_ENTITY(int player, int entity)` | bool |
| `IS_PLAYER_FREE_FOR_AMBIENT_TASK` | `bool IS_PLAYER_FREE_FOR_AMBIENT_TASK(int player)` | bool |
| `IS_PLAYER_LOGGING_IN_NP` | `bool IS_PLAYER_LOGGING_IN_NP()` | bool |
| `IS_PLAYER_ONLINE` | `bool IS_PLAYER_ONLINE()` | bool |
| `IS_PLAYER_PLAYING` | `bool IS_PLAYER_PLAYING(int player)` | bool |
| `IS_PLAYER_PRESSING_HORN` | `bool IS_PLAYER_PRESSING_HORN(int player)` | bool |
| `IS_PLAYER_READY_FOR_CUTSCENE` | `bool IS_PLAYER_READY_FOR_CUTSCENE(int player)` | bool |
| `IS_PLAYER_RIDING_TRAIN` | `bool IS_PLAYER_RIDING_TRAIN(int player)` | bool |
| `IS_PLAYER_SCRIPT_CONTROL_ON` | `bool IS_PLAYER_SCRIPT_CONTROL_ON(int player)` | bool |
| `IS_PLAYER_TARGETTING_ANYTHING` | `bool IS_PLAYER_TARGETTING_ANYTHING(int player)` | bool |
| `IS_PLAYER_TARGETTING_ENTITY` | `bool IS_PLAYER_TARGETTING_ENTITY(int player, int entity)` | bool |
| `IS_PLAYER_TELEPORT_ACTIVE` | `bool IS_PLAYER_TELEPORT_ACTIVE()` | bool |
| `IS_PLAYER_VEHICLE_WEAPON_TOGGLED_TO_NON_HOMING` | `bool IS_PLAYER_VEHICLE_WEAPON_TOGGLED_TO_NON_HOMING(object p0)` | bool |
| `IS_PLAYER_WANTED_LEVEL_GREATER` | `bool IS_PLAYER_WANTED_LEVEL_GREATER(int player, int wantedLevel)` | bool |
| `IS_REMOTE_PLAYER_IN_NON_CLONED_VEHICLE` | `bool IS_REMOTE_PLAYER_IN_NON_CLONED_VEHICLE(int player)` | bool |
| `IS_SPECIAL_ABILITY_ACTIVE` | `bool IS_SPECIAL_ABILITY_ACTIVE(int player, object p1)` | bool |
| `IS_SPECIAL_ABILITY_ENABLED` | `bool IS_SPECIAL_ABILITY_ENABLED(int player, object p1)` | bool |
| `IS_SPECIAL_ABILITY_METER_FULL` | `bool IS_SPECIAL_ABILITY_METER_FULL(int player, object p1)` | bool |
| `IS_SPECIAL_ABILITY_UNLOCKED` | `bool IS_SPECIAL_ABILITY_UNLOCKED(uint playerModel)` | bool |
| `IS_SYSTEM_UI_BEING_DISPLAYED` | `bool IS_SYSTEM_UI_BEING_DISPLAYED()` | bool |
| `IS_WANTED_AND_HAS_BEEN_SEEN_BY_COPS` | `bool IS_WANTED_AND_HAS_BEEN_SEEN_BY_COPS(int player)` | bool |
| `NETWORK_PLAYER_ID_TO_INT` | `int NETWORK_PLAYER_ID_TO_INT()` | int |
| `PLAYER_ATTACH_VIRTUAL_BOUND` | `void PLAYER_ATTACH_VIRTUAL_BOUND(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7)` | void |
| `PLAYER_DETACH_VIRTUAL_BOUND` | `void PLAYER_DETACH_VIRTUAL_BOUND()` | void |
| `PLAYER_ID` | `int PLAYER_ID()` | int |
| `PLAYER_PED_ID` | `int PLAYER_PED_ID()` | int |
| `REMOVE_PLAYER_HELMET` | `void REMOVE_PLAYER_HELMET(int player, bool p2)` | void |
| `REMOVE_PLAYER_TARGETABLE_ENTITY` | `void REMOVE_PLAYER_TARGETABLE_ENTITY(int player, int entity)` | void |
| `REMOVE_SCRIPT_FIRE_POSITION` | `void REMOVE_SCRIPT_FIRE_POSITION()` | void |
| `REPORT_CRIME` | `void REPORT_CRIME(int player, int crimeType, int wantedLvlThresh)` | void |
| `REPORT_POLICE_SPOTTED_PLAYER` | `void REPORT_POLICE_SPOTTED_PLAYER(int player)` | void |
| `RESET_LAW_RESPONSE_DELAY_OVERRIDE` | `void RESET_LAW_RESPONSE_DELAY_OVERRIDE()` | void |
| `RESET_PLAYER_ARREST_STATE` | `void RESET_PLAYER_ARREST_STATE(int player)` | void |
| `RESET_PLAYER_INPUT_GAIT` | `void RESET_PLAYER_INPUT_GAIT(int player)` | void |
| `RESET_PLAYER_STAMINA` | `void RESET_PLAYER_STAMINA(int player)` | void |
| `RESET_WANTED_LEVEL_DIFFICULTY` | `void RESET_WANTED_LEVEL_DIFFICULTY(int player)` | void |
| `RESET_WANTED_LEVEL_HIDDEN_ESCAPE_TIME` | `void RESET_WANTED_LEVEL_HIDDEN_ESCAPE_TIME(int player)` | void |
| `RESET_WORLD_BOUNDARY_FOR_PLAYER` | `void RESET_WORLD_BOUNDARY_FOR_PLAYER()` | void |
| `RESTORE_PLAYER_STAMINA` | `void RESTORE_PLAYER_STAMINA(int player, float p1)` | void |
| `SET_ACHIEVEMENT_PROGRESS` | `bool SET_ACHIEVEMENT_PROGRESS(int achievementId, int progress)` | bool |
| `SET_AIR_DRAG_MULTIPLIER_FOR_PLAYERS_VEHICLE` | `void SET_AIR_DRAG_MULTIPLIER_FOR_PLAYERS_VEHICLE(int player, float multiplier)` | void |
| `SET_ALL_NEUTRAL_RANDOM_PEDS_FLEE` | `void SET_ALL_NEUTRAL_RANDOM_PEDS_FLEE(int player, bool toggle)` | void |
| `SET_ALL_NEUTRAL_RANDOM_PEDS_FLEE_THIS_FRAME` | `void SET_ALL_NEUTRAL_RANDOM_PEDS_FLEE_THIS_FRAME(int player)` | void |
| `SET_ALL_RANDOM_PEDS_FLEE` | `void SET_ALL_RANDOM_PEDS_FLEE(int player, bool toggle)` | void |
| `SET_ALL_RANDOM_PEDS_FLEE_THIS_FRAME` | `void SET_ALL_RANDOM_PEDS_FLEE_THIS_FRAME(int player)` | void |
| `SET_APPLY_WAYPOINT_OF_PLAYER` | `void SET_APPLY_WAYPOINT_OF_PLAYER(int player, int hudColor)` | void |
| `SET_AUTO_GIVE_PARACHUTE_WHEN_ENTER_PLANE` | `void SET_AUTO_GIVE_PARACHUTE_WHEN_ENTER_PLANE(int player, bool toggle)` | void |
| `SET_AUTO_GIVE_SCUBA_GEAR_WHEN_EXIT_VEHICLE` | `void SET_AUTO_GIVE_SCUBA_GEAR_WHEN_EXIT_VEHICLE(int player, bool toggle)` | void |
| `SET_DISABLE_AMBIENT_MELEE_MOVE` | `void SET_DISABLE_AMBIENT_MELEE_MOVE(int player, bool toggle)` | void |
| `SET_DISPATCH_COPS_FOR_PLAYER` | `void SET_DISPATCH_COPS_FOR_PLAYER(int player, bool toggle)` | void |
| `SET_EVERYONE_IGNORE_PLAYER` | `void SET_EVERYONE_IGNORE_PLAYER(int player, bool toggle)` | void |
| `SET_IGNORE_LOW_PRIORITY_SHOCKING_EVENTS` | `void SET_IGNORE_LOW_PRIORITY_SHOCKING_EVENTS(int player, bool toggle)` | void |
| `SET_LAW_PEDS_CAN_ATTACK_NON_WANTED_PLAYER_THIS_FRAME` | `void SET_LAW_PEDS_CAN_ATTACK_NON_WANTED_PLAYER_THIS_FRAME(int player)` | void |
| `SET_LAW_RESPONSE_DELAY_OVERRIDE` | `void SET_LAW_RESPONSE_DELAY_OVERRIDE(float p0)` | void |
| `SET_MAX_WANTED_LEVEL` | `void SET_MAX_WANTED_LEVEL(int maxWantedLevel)` | void |
| `SET_PLAYER_BLUETOOTH_STATE` | `void SET_PLAYER_BLUETOOTH_STATE(int player, bool state)` | void |
| `SET_PLAYER_CAN_BE_HASSLED_BY_GANGS` | `void SET_PLAYER_CAN_BE_HASSLED_BY_GANGS(int player, bool toggle)` | void |
| `SET_PLAYER_CAN_COLLECT_DROPPED_MONEY` | `void SET_PLAYER_CAN_COLLECT_DROPPED_MONEY(int player, bool p1)` | void |
| `SET_PLAYER_CAN_DAMAGE_PLAYER` | `void SET_PLAYER_CAN_DAMAGE_PLAYER(int player1, int player2, bool toggle)` | void |
| `SET_PLAYER_CAN_DO_DRIVE_BY` | `void SET_PLAYER_CAN_DO_DRIVE_BY(int player, bool toggle)` | void |
| `SET_PLAYER_CAN_LEAVE_PARACHUTE_SMOKE_TRAIL` | `void SET_PLAYER_CAN_LEAVE_PARACHUTE_SMOKE_TRAIL(int player, bool enabled)` | void |
| `SET_PLAYER_CAN_USE_COVER` | `void SET_PLAYER_CAN_USE_COVER(int player, bool toggle)` | void |
| `SET_PLAYER_CLOTH_LOCK_COUNTER` | `void SET_PLAYER_CLOTH_LOCK_COUNTER(int value)` | void |
| `SET_PLAYER_CLOTH_PACKAGE_INDEX` | `void SET_PLAYER_CLOTH_PACKAGE_INDEX(int index)` | void |
| `SET_PLAYER_CLOTH_PIN_FRAMES` | `void SET_PLAYER_CLOTH_PIN_FRAMES(int player, int p1)` | void |
| `SET_PLAYER_CONTROL` | `void SET_PLAYER_CONTROL(int player, bool bHasControl, int flags)` | void |
| `SET_PLAYER_EXPLOSIVE_DAMAGE_MODIFIER` | `void SET_PLAYER_EXPLOSIVE_DAMAGE_MODIFIER(int player, object p1)` | void |
| `SET_PLAYER_FALL_DISTANCE_TO_TRIGGER_RAGDOLL_OVERRIDE` | `void SET_PLAYER_FALL_DISTANCE_TO_TRIGGER_RAGDOLL_OVERRIDE(int player, float p1)` | void |
| `SET_PLAYER_FORCED_AIM` | `void SET_PLAYER_FORCED_AIM(int player, bool toggle)` | void |
| `SET_PLAYER_FORCED_ZOOM` | `void SET_PLAYER_FORCED_ZOOM(int player, bool toggle)` | void |
| `SET_PLAYER_FORCE_SKIP_AIM_INTRO` | `void SET_PLAYER_FORCE_SKIP_AIM_INTRO(int player, bool toggle)` | void |
| `SET_PLAYER_HAS_RESERVE_PARACHUTE` | `void SET_PLAYER_HAS_RESERVE_PARACHUTE(int player)` | void |
| `SET_PLAYER_HEALTH_RECHARGE_MAX_PERCENT` | `void SET_PLAYER_HEALTH_RECHARGE_MAX_PERCENT(int player, float limit)` | void |
| `SET_PLAYER_HEALTH_RECHARGE_MULTIPLIER` | `void SET_PLAYER_HEALTH_RECHARGE_MULTIPLIER(int player, float regenRate)` | void |
| `SET_PLAYER_HOMING_DISABLED_FOR_ALL_VEHICLE_WEAPONS` | `void SET_PLAYER_HOMING_DISABLED_FOR_ALL_VEHICLE_WEAPONS(object p0, object p1)` | void |
| `SET_PLAYER_INVINCIBLE` | `void SET_PLAYER_INVINCIBLE(int player, bool toggle)` | void |
| `SET_PLAYER_INVINCIBLE_BUT_HAS_REACTIONS` | `void SET_PLAYER_INVINCIBLE_BUT_HAS_REACTIONS(int player, bool toggle)` | void |
| `SET_PLAYER_LEAVE_PED_BEHIND` | `void SET_PLAYER_LEAVE_PED_BEHIND(int player, bool toggle)` | void |
| `SET_PLAYER_LOCKON` | `void SET_PLAYER_LOCKON(int player, bool toggle)` | void |
| `SET_PLAYER_LOCKON_RANGE_OVERRIDE` | `void SET_PLAYER_LOCKON_RANGE_OVERRIDE(int player, float range)` | void |
| `SET_PLAYER_MAX_ARMOUR` | `void SET_PLAYER_MAX_ARMOUR(int player, int value)` | void |
| `SET_PLAYER_MAX_EXPLOSIVE_DAMAGE` | `void SET_PLAYER_MAX_EXPLOSIVE_DAMAGE(int player, float p1)` | void |
| `SET_PLAYER_MAY_NOT_ENTER_ANY_VEHICLE` | `void SET_PLAYER_MAY_NOT_ENTER_ANY_VEHICLE(int player)` | void |
| `SET_PLAYER_MAY_ONLY_ENTER_THIS_VEHICLE` | `void SET_PLAYER_MAY_ONLY_ENTER_THIS_VEHICLE(int player, int vehicle)` | void |
| `SET_PLAYER_MELEE_WEAPON_DAMAGE_MODIFIER` | `void SET_PLAYER_MELEE_WEAPON_DAMAGE_MODIFIER(int player, float modifier, bool p2)` | void |
| `SET_PLAYER_MELEE_WEAPON_DEFENSE_MODIFIER` | `void SET_PLAYER_MELEE_WEAPON_DEFENSE_MODIFIER(int player, float modifier)` | void |
| `SET_PLAYER_MODEL` | `void SET_PLAYER_MODEL(int player, uint model)` | void |
| `SET_PLAYER_NOISE_MULTIPLIER` | `void SET_PLAYER_NOISE_MULTIPLIER(int player, float multiplier)` | void |
| `SET_PLAYER_PARACHUTE_MODEL_OVERRIDE` | `void SET_PLAYER_PARACHUTE_MODEL_OVERRIDE(int player, uint model)` | void |
| `SET_PLAYER_PARACHUTE_PACK_MODEL_OVERRIDE` | `void SET_PLAYER_PARACHUTE_PACK_MODEL_OVERRIDE(int player, uint model)` | void |
| `SET_PLAYER_PARACHUTE_PACK_TINT_INDEX` | `void SET_PLAYER_PARACHUTE_PACK_TINT_INDEX(int player, int tintIndex)` | void |
| `SET_PLAYER_PARACHUTE_SMOKE_TRAIL_COLOR` | `void SET_PLAYER_PARACHUTE_SMOKE_TRAIL_COLOR(int player, int r, int g, int b)` | void |
| `SET_PLAYER_PARACHUTE_TINT_INDEX` | `void SET_PLAYER_PARACHUTE_TINT_INDEX(int player, int tintIndex)` | void |
| `SET_PLAYER_PARACHUTE_VARIATION_OVERRIDE` | `void SET_PLAYER_PARACHUTE_VARIATION_OVERRIDE(int player, int p1, object p2, object p3, bool p4)` | void |
| `SET_PLAYER_PHONE_PALETTE_IDX` | `void SET_PLAYER_PHONE_PALETTE_IDX(int player, int idx)` | void |
| `SET_PLAYER_PREVIOUS_VARIATION_DATA` | `void SET_PLAYER_PREVIOUS_VARIATION_DATA(int player, int p1, int p2, object p3, object p4, object p5)` | void |
| `SET_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE` | `void SET_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE(int player, uint model)` | void |
| `SET_PLAYER_RESERVE_PARACHUTE_TINT_INDEX` | `void SET_PLAYER_RESERVE_PARACHUTE_TINT_INDEX(int player, int index)` | void |
| `SET_PLAYER_SIMULATE_AIMING` | `void SET_PLAYER_SIMULATE_AIMING(int player, bool toggle)` | void |
| `SET_PLAYER_SNEAKING_NOISE_MULTIPLIER` | `void SET_PLAYER_SNEAKING_NOISE_MULTIPLIER(int player, float multiplier)` | void |
| `SET_PLAYER_SPECTATED_VEHICLE_RADIO_OVERRIDE` | `void SET_PLAYER_SPECTATED_VEHICLE_RADIO_OVERRIDE(bool p0)` | void |
| `SET_PLAYER_SPRINT` | `void SET_PLAYER_SPRINT(int player, bool toggle)` | void |
| `SET_PLAYER_STEALTH_PERCEPTION_MODIFIER` | `void SET_PLAYER_STEALTH_PERCEPTION_MODIFIER(int player, float value)` | void |
| `SET_PLAYER_TARGETING_MODE` | `void SET_PLAYER_TARGETING_MODE(int targetMode)` | void |
| `SET_PLAYER_TARGET_LEVEL` | `void SET_PLAYER_TARGET_LEVEL(int targetLevel)` | void |
| `SET_PLAYER_TEAM` | `void SET_PLAYER_TEAM(int player, int team)` | void |
| `SET_PLAYER_UNDERWATER_BREATH_PERCENT_REMAINING` | `float SET_PLAYER_UNDERWATER_BREATH_PERCENT_REMAINING(int player, float time)` | float |
| `SET_PLAYER_VEHICLE_DAMAGE_MODIFIER` | `void SET_PLAYER_VEHICLE_DAMAGE_MODIFIER(int player, float modifier)` | void |
| `SET_PLAYER_VEHICLE_DEFENSE_MODIFIER` | `void SET_PLAYER_VEHICLE_DEFENSE_MODIFIER(int player, float modifier)` | void |
| `SET_PLAYER_VEHICLE_WEAPON_TO_NON_HOMING` | `void SET_PLAYER_VEHICLE_WEAPON_TO_NON_HOMING(object p0)` | void |
| `SET_PLAYER_WANTED_CENTRE_POSITION` | `void SET_PLAYER_WANTED_CENTRE_POSITION(int player, ref Vector3 position, bool p2, bool p3)` | void |
| `SET_PLAYER_WANTED_LEVEL` | `void SET_PLAYER_WANTED_LEVEL(int player, int wantedLevel, bool disableNoMission)` | void |
| `SET_PLAYER_WANTED_LEVEL_NOW` | `void SET_PLAYER_WANTED_LEVEL_NOW(int player, bool p1)` | void |
| `SET_PLAYER_WANTED_LEVEL_NO_DROP` | `void SET_PLAYER_WANTED_LEVEL_NO_DROP(int player, int wantedLevel, bool p2)` | void |
| `SET_PLAYER_WEAPON_DAMAGE_MODIFIER` | `void SET_PLAYER_WEAPON_DAMAGE_MODIFIER(int player, float modifier)` | void |
| `SET_PLAYER_WEAPON_DEFENSE_MODIFIER` | `void SET_PLAYER_WEAPON_DEFENSE_MODIFIER(int player, float modifier)` | void |
| `SET_PLAYER_WEAPON_MINIGUN_DEFENSE_MODIFIER` | `void SET_PLAYER_WEAPON_MINIGUN_DEFENSE_MODIFIER(int player, float modifier)` | void |
| `SET_PLAYER_WEAPON_TAKEDOWN_DEFENSE_MODIFIER` | `void SET_PLAYER_WEAPON_TAKEDOWN_DEFENSE_MODIFIER(int player, float p1)` | void |
| `SET_POLICE_IGNORE_PLAYER` | `void SET_POLICE_IGNORE_PLAYER(int player, bool toggle)` | void |
| `SET_POLICE_RADAR_BLIPS` | `void SET_POLICE_RADAR_BLIPS(bool toggle)` | void |
| `SET_RUN_SPRINT_MULTIPLIER_FOR_PLAYER` | `void SET_RUN_SPRINT_MULTIPLIER_FOR_PLAYER(int player, float multiplier)` | void |
| `SET_SCRIPT_FIRE_POSITION` | `void SET_SCRIPT_FIRE_POSITION(float coordX, float coordY, float coordZ)` | void |
| `SET_SPECIAL_ABILITY_MP` | `void SET_SPECIAL_ABILITY_MP(int player, int p1, object p2)` | void |
| `SET_SPECIAL_ABILITY_MULTIPLIER` | `void SET_SPECIAL_ABILITY_MULTIPLIER(float multiplier)` | void |
| `SET_SWIM_MULTIPLIER_FOR_PLAYER` | `void SET_SWIM_MULTIPLIER_FOR_PLAYER(int player, float multiplier)` | void |
| `SET_WANTED_LEVEL_DIFFICULTY` | `void SET_WANTED_LEVEL_DIFFICULTY(int player, float difficulty)` | void |
| `SET_WANTED_LEVEL_HIDDEN_ESCAPE_TIME` | `void SET_WANTED_LEVEL_HIDDEN_ESCAPE_TIME(int player, int wantedLevel, int lossTime)` | void |
| `SET_WANTED_LEVEL_MULTIPLIER` | `void SET_WANTED_LEVEL_MULTIPLIER(float multiplier)` | void |
| `SIMULATE_PLAYER_INPUT_GAIT` | `void SIMULATE_PLAYER_INPUT_GAIT(int player, float amount, int gaitType, float speed, bool p4, bool p5, object p6)` | void |
| `SPECIAL_ABILITY_ACTIVATE` | `void SPECIAL_ABILITY_ACTIVATE(int player, int p1)` | void |
| `SPECIAL_ABILITY_CHARGE_ABSOLUTE` | `void SPECIAL_ABILITY_CHARGE_ABSOLUTE(int player, int p1, bool p2, object p3)` | void |
| `SPECIAL_ABILITY_CHARGE_CONTINUOUS` | `void SPECIAL_ABILITY_CHARGE_CONTINUOUS(int player, int p1, object p2)` | void |
| `SPECIAL_ABILITY_CHARGE_LARGE` | `void SPECIAL_ABILITY_CHARGE_LARGE(int player, bool p1, bool p2, object p3)` | void |
| `SPECIAL_ABILITY_CHARGE_MEDIUM` | `void SPECIAL_ABILITY_CHARGE_MEDIUM(int player, bool p1, bool p2, object p3)` | void |
| `SPECIAL_ABILITY_CHARGE_NORMALIZED` | `void SPECIAL_ABILITY_CHARGE_NORMALIZED(int player, float normalizedValue, bool p2, object p3)` | void |
| `SPECIAL_ABILITY_CHARGE_ON_MISSION_FAILED` | `void SPECIAL_ABILITY_CHARGE_ON_MISSION_FAILED(int player, object p1)` | void |
| `SPECIAL_ABILITY_CHARGE_SMALL` | `void SPECIAL_ABILITY_CHARGE_SMALL(int player, bool p1, bool p2, object p3)` | void |
| `SPECIAL_ABILITY_DEACTIVATE` | `void SPECIAL_ABILITY_DEACTIVATE(int player, object p1)` | void |
| `SPECIAL_ABILITY_DEACTIVATE_FAST` | `void SPECIAL_ABILITY_DEACTIVATE_FAST(int player, object p1)` | void |
| `SPECIAL_ABILITY_DEACTIVATE_MP` | `void SPECIAL_ABILITY_DEACTIVATE_MP(int player, int p1)` | void |
| `SPECIAL_ABILITY_DEPLETE_METER` | `void SPECIAL_ABILITY_DEPLETE_METER(int player, bool p1, object p2)` | void |
| `SPECIAL_ABILITY_FILL_METER` | `void SPECIAL_ABILITY_FILL_METER(int player, bool p1, object p2)` | void |
| `SPECIAL_ABILITY_LOCK` | `void SPECIAL_ABILITY_LOCK(uint playerModel, object p1)` | void |
| `SPECIAL_ABILITY_RESET` | `void SPECIAL_ABILITY_RESET(int player, object p1)` | void |
| `SPECIAL_ABILITY_UNLOCK` | `void SPECIAL_ABILITY_UNLOCK(uint playerModel, object p1)` | void |
| `START_FIRING_AMNESTY` | `void START_FIRING_AMNESTY(int duration)` | void |
| `START_PLAYER_TELEPORT` | `void START_PLAYER_TELEPORT(int player, float x, float y, float z, float heading, bool p5, bool findCollisionLand, bool p7)` | void |
| `STOP_PLAYER_TELEPORT` | `void STOP_PLAYER_TELEPORT()` | void |
| `SUPPRESS_CRIME_THIS_FRAME` | `void SUPPRESS_CRIME_THIS_FRAME(int player, int crimeType)` | void |
| `SUPPRESS_LOSING_WANTED_LEVEL_IF_HIDDEN_THIS_FRAME` | `void SUPPRESS_LOSING_WANTED_LEVEL_IF_HIDDEN_THIS_FRAME(int player)` | void |
| `SUPPRESS_WITNESSES_CALLING_POLICE_THIS_FRAME` | `void SUPPRESS_WITNESSES_CALLING_POLICE_THIS_FRAME(int player)` | void |
| `UPDATE_PLAYER_TELEPORT` | `bool UPDATE_PLAYER_TELEPORT(int player)` | bool |
| `UPDATE_SPECIAL_ABILITY_FROM_STAT` | `void UPDATE_SPECIAL_ABILITY_FROM_STAT(int player, object p1)` | void |
| `UPDATE_WANTED_POSITION_THIS_FRAME` | `void UPDATE_WANTED_POSITION_THIS_FRAME(int player)` | void |

---

## WEAPON

| 函数名 | 签名 | 返回值 |
|--------|------|--------|
| `ADD_AMMO_TO_PED` | `void ADD_AMMO_TO_PED(int ped, uint weaponHash, int ammo)` | void |
| `ADD_PED_AMMO_BY_TYPE` | `void ADD_PED_AMMO_BY_TYPE(int ped, uint ammoTypeHash, int ammo)` | void |
| `CAN_USE_WEAPON_ON_PARACHUTE` | `bool CAN_USE_WEAPON_ON_PARACHUTE(uint weaponHash)` | bool |
| `CLEAR_ENTITY_LAST_WEAPON_DAMAGE` | `void CLEAR_ENTITY_LAST_WEAPON_DAMAGE(int entity)` | void |
| `CLEAR_PED_LAST_WEAPON_DAMAGE` | `void CLEAR_PED_LAST_WEAPON_DAMAGE(int ped)` | void |
| `CREATE_AIR_DEFENCE_ANGLED_AREA` | `int CREATE_AIR_DEFENCE_ANGLED_AREA(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float radius, uint weaponHash)` | int |
| `CREATE_AIR_DEFENCE_SPHERE` | `int CREATE_AIR_DEFENCE_SPHERE(float x, float y, float z, float radius, float p4, float p5, float p6, uint weaponHash)` | int |
| `CREATE_WEAPON_OBJECT` | `int CREATE_WEAPON_OBJECT(uint weaponHash, int ammoCount, float x, float y, float z, bool showWorldModel, float scale, object p7, object p8, object p9)` | int |
| `DOES_AIR_DEFENCE_SPHERE_EXIST` | `bool DOES_AIR_DEFENCE_SPHERE_EXIST(int zoneId)` | bool |
| `DOES_WEAPON_TAKE_WEAPON_COMPONENT` | `bool DOES_WEAPON_TAKE_WEAPON_COMPONENT(uint weaponHash, uint componentHash)` | bool |
| `ENABLE_LASER_SIGHT_RENDERING` | `void ENABLE_LASER_SIGHT_RENDERING(bool toggle)` | void |
| `EXPLODE_PROJECTILES` | `void EXPLODE_PROJECTILES(int ped, uint weaponHash, bool p2)` | void |
| `FIRE_AIR_DEFENCE_SPHERE_WEAPON_AT_POSITION` | `void FIRE_AIR_DEFENCE_SPHERE_WEAPON_AT_POSITION(int zoneId, float x, float y, float z)` | void |
| `GET_AMMO_IN_CLIP` | `bool GET_AMMO_IN_CLIP(int ped, uint weaponHash, ref int ammo)` | bool |
| `GET_AMMO_IN_PED_WEAPON` | `int GET_AMMO_IN_PED_WEAPON(int ped, uint weaponhash)` | int |
| `GET_BEST_PED_WEAPON` | `uint GET_BEST_PED_WEAPON(int ped, bool p1)` | uint |
| `GET_CURRENT_PED_VEHICLE_WEAPON` | `bool GET_CURRENT_PED_VEHICLE_WEAPON(int ped, Hash* weaponHash)` | bool |
| `GET_CURRENT_PED_WEAPON` | `bool GET_CURRENT_PED_WEAPON(int ped, Hash* weaponHash, bool p2)` | bool |
| `GET_CURRENT_PED_WEAPON_ENTITY_INDEX` | `int GET_CURRENT_PED_WEAPON_ENTITY_INDEX(int ped, object p1)` | int |
| `GET_IS_PED_GADGET_EQUIPPED` | `bool GET_IS_PED_GADGET_EQUIPPED(int ped, uint gadgetHash)` | bool |
| `GET_LOCKON_DISTANCE_OF_CURRENT_PED_WEAPON` | `float GET_LOCKON_DISTANCE_OF_CURRENT_PED_WEAPON(int ped)` | float |
| `GET_MAX_AMMO` | `bool GET_MAX_AMMO(int ped, uint weaponHash, ref int ammo)` | bool |
| `GET_MAX_AMMO_BY_TYPE` | `bool GET_MAX_AMMO_BY_TYPE(int ped, uint ammoTypeHash, ref int ammo)` | bool |
| `GET_MAX_AMMO_IN_CLIP` | `int GET_MAX_AMMO_IN_CLIP(int ped, uint weaponHash, bool p2)` | int |
| `GET_MAX_RANGE_OF_CURRENT_PED_WEAPON` | `float GET_MAX_RANGE_OF_CURRENT_PED_WEAPON(int ped)` | float |
| `GET_PED_AMMO_BY_TYPE` | `int GET_PED_AMMO_BY_TYPE(int ped, uint ammoTypeHash)` | int |
| `GET_PED_AMMO_TYPE_FROM_WEAPON` | `uint GET_PED_AMMO_TYPE_FROM_WEAPON(int ped, uint weaponHash)` | uint |
| `GET_PED_LAST_WEAPON_IMPACT_COORD` | `bool GET_PED_LAST_WEAPON_IMPACT_COORD(int ped, ref Vector3 coords)` | bool |
| `GET_PED_ORIGINAL_AMMO_TYPE_FROM_WEAPON` | `uint GET_PED_ORIGINAL_AMMO_TYPE_FROM_WEAPON(int ped, uint weaponHash)` | uint |
| `GET_PED_WEAPONTYPE_IN_SLOT` | `uint GET_PED_WEAPONTYPE_IN_SLOT(int ped, uint weaponSlot)` | uint |
| `GET_PED_WEAPON_CAMO_INDEX` | `int GET_PED_WEAPON_CAMO_INDEX(int ped, uint weaponHash)` | int |
| `GET_PED_WEAPON_COMPONENT_TINT_INDEX` | `int GET_PED_WEAPON_COMPONENT_TINT_INDEX(int ped, uint weaponHash, uint camoComponentHash)` | int |
| `GET_PED_WEAPON_TINT_INDEX` | `int GET_PED_WEAPON_TINT_INDEX(int ped, uint weaponHash)` | int |
| `GET_SELECTED_PED_WEAPON` | `uint GET_SELECTED_PED_WEAPON(int ped)` | uint |
| `GET_WEAPONTYPE_GROUP` | `uint GET_WEAPONTYPE_GROUP(uint weaponHash)` | uint |
| `GET_WEAPONTYPE_MODEL` | `uint GET_WEAPONTYPE_MODEL(uint weaponHash)` | uint |
| `GET_WEAPONTYPE_SLOT` | `uint GET_WEAPONTYPE_SLOT(uint weaponHash)` | uint |
| `GET_WEAPON_CLIP_SIZE` | `int GET_WEAPON_CLIP_SIZE(uint weaponHash)` | int |
| `GET_WEAPON_COMPONENT_HUD_STATS` | `bool GET_WEAPON_COMPONENT_HUD_STATS(uint componentHash, ref object outData)` | bool |
| `GET_WEAPON_COMPONENT_TYPE_MODEL` | `uint GET_WEAPON_COMPONENT_TYPE_MODEL(uint componentHash)` | uint |
| `GET_WEAPON_COMPONENT_VARIANT_EXTRA_COUNT` | `int GET_WEAPON_COMPONENT_VARIANT_EXTRA_COUNT(uint componentHash)` | int |
| `GET_WEAPON_COMPONENT_VARIANT_EXTRA_MODEL` | `uint GET_WEAPON_COMPONENT_VARIANT_EXTRA_MODEL(uint componentHash, int extraComponentIndex)` | uint |
| `GET_WEAPON_DAMAGE` | `float GET_WEAPON_DAMAGE(uint weaponHash, uint componentHash)` | float |
| `GET_WEAPON_DAMAGE_TYPE` | `int GET_WEAPON_DAMAGE_TYPE(uint weaponHash)` | int |
| `GET_WEAPON_HUD_STATS` | `bool GET_WEAPON_HUD_STATS(uint weaponHash, ref object outData)` | bool |
| `GET_WEAPON_OBJECT_COMPONENT_TINT_INDEX` | `int GET_WEAPON_OBJECT_COMPONENT_TINT_INDEX(int weaponObject, uint camoComponentHash)` | int |
| `GET_WEAPON_OBJECT_FROM_PED` | `int GET_WEAPON_OBJECT_FROM_PED(int ped, bool p1)` | int |
| `GET_WEAPON_OBJECT_TINT_INDEX` | `int GET_WEAPON_OBJECT_TINT_INDEX(int weapon)` | int |
| `GET_WEAPON_TIME_BETWEEN_SHOTS` | `float GET_WEAPON_TIME_BETWEEN_SHOTS(uint weaponHash)` | float |
| `GET_WEAPON_TINT_COUNT` | `int GET_WEAPON_TINT_COUNT(uint weaponHash)` | int |
| `GIVE_DELAYED_WEAPON_TO_PED` | `void GIVE_DELAYED_WEAPON_TO_PED(int ped, uint weaponHash, int ammoCount, bool bForceInHand)` | void |
| `GIVE_LOADOUT_TO_PED` | `void GIVE_LOADOUT_TO_PED(int ped, uint loadoutHash)` | void |
| `GIVE_WEAPON_COMPONENT_TO_PED` | `void GIVE_WEAPON_COMPONENT_TO_PED(int ped, uint weaponHash, uint componentHash)` | void |
| `GIVE_WEAPON_COMPONENT_TO_WEAPON_OBJECT` | `void GIVE_WEAPON_COMPONENT_TO_WEAPON_OBJECT(int weaponObject, uint componentHash)` | void |
| `GIVE_WEAPON_OBJECT_TO_PED` | `void GIVE_WEAPON_OBJECT_TO_PED(int weaponObject, int ped)` | void |
| `GIVE_WEAPON_TO_PED` | `void GIVE_WEAPON_TO_PED(int ped, uint weaponHash, int ammoCount, bool isHidden, bool bForceInHand)` | void |
| `HAS_ENTITY_BEEN_DAMAGED_BY_WEAPON` | `bool HAS_ENTITY_BEEN_DAMAGED_BY_WEAPON(int entity, uint weaponHash, int weaponType)` | bool |
| `HAS_PED_BEEN_DAMAGED_BY_WEAPON` | `bool HAS_PED_BEEN_DAMAGED_BY_WEAPON(int ped, uint weaponHash, int weaponType)` | bool |
| `HAS_PED_GOT_WEAPON` | `bool HAS_PED_GOT_WEAPON(int ped, uint weaponHash, bool p2)` | bool |
| `HAS_PED_GOT_WEAPON_COMPONENT` | `bool HAS_PED_GOT_WEAPON_COMPONENT(int ped, uint weaponHash, uint componentHash)` | bool |
| `HAS_VEHICLE_GOT_PROJECTILE_ATTACHED` | `bool HAS_VEHICLE_GOT_PROJECTILE_ATTACHED(int driver, int vehicle, uint weaponHash, object p3)` | bool |
| `HAS_WEAPON_ASSET_LOADED` | `bool HAS_WEAPON_ASSET_LOADED(uint weaponHash)` | bool |
| `HAS_WEAPON_GOT_WEAPON_COMPONENT` | `bool HAS_WEAPON_GOT_WEAPON_COMPONENT(int weapon, uint componentHash)` | bool |
| `HIDE_PED_WEAPON_FOR_SCRIPTED_CUTSCENE` | `void HIDE_PED_WEAPON_FOR_SCRIPTED_CUTSCENE(int ped, bool toggle)` | void |
| `IS_AIR_DEFENCE_SPHERE_IN_AREA` | `bool IS_AIR_DEFENCE_SPHERE_IN_AREA(float x, float y, float z, float radius, ref int outZoneId)` | bool |
| `IS_FLASH_LIGHT_ON` | `bool IS_FLASH_LIGHT_ON(int ped)` | bool |
| `IS_PED_ARMED` | `bool IS_PED_ARMED(int ped, int typeFlags)` | bool |
| `IS_PED_CURRENT_WEAPON_SILENCED` | `bool IS_PED_CURRENT_WEAPON_SILENCED(int ped)` | bool |
| `IS_PED_WEAPON_COMPONENT_ACTIVE` | `bool IS_PED_WEAPON_COMPONENT_ACTIVE(int ped, uint weaponHash, uint componentHash)` | bool |
| `IS_PED_WEAPON_READY_TO_SHOOT` | `bool IS_PED_WEAPON_READY_TO_SHOOT(int ped)` | bool |
| `IS_WEAPON_VALID` | `bool IS_WEAPON_VALID(uint weaponHash)` | bool |
| `MAKE_PED_RELOAD` | `bool MAKE_PED_RELOAD(int ped)` | bool |
| `REFILL_AMMO_INSTANTLY` | `bool REFILL_AMMO_INSTANTLY(int ped)` | bool |
| `REMOVE_AIR_DEFENCE_SPHERE` | `bool REMOVE_AIR_DEFENCE_SPHERE(int zoneId)` | bool |
| `REMOVE_ALL_AIR_DEFENCE_SPHERES` | `void REMOVE_ALL_AIR_DEFENCE_SPHERES()` | void |
| `REMOVE_ALL_PED_WEAPONS` | `void REMOVE_ALL_PED_WEAPONS(int ped, bool p1)` | void |
| `REMOVE_ALL_PROJECTILES_OF_TYPE` | `void REMOVE_ALL_PROJECTILES_OF_TYPE(uint weaponHash, bool explode)` | void |
| `REMOVE_WEAPON_ASSET` | `void REMOVE_WEAPON_ASSET(uint weaponHash)` | void |
| `REMOVE_WEAPON_COMPONENT_FROM_PED` | `void REMOVE_WEAPON_COMPONENT_FROM_PED(int ped, uint weaponHash, uint componentHash)` | void |
| `REMOVE_WEAPON_COMPONENT_FROM_WEAPON_OBJECT` | `void REMOVE_WEAPON_COMPONENT_FROM_WEAPON_OBJECT(int object, uint componentHash)` | void |
| `REMOVE_WEAPON_FROM_PED` | `void REMOVE_WEAPON_FROM_PED(int ped, uint weaponHash)` | void |
| `REQUEST_WEAPON_ASSET` | `void REQUEST_WEAPON_ASSET(uint weaponHash, int p1, int p2)` | void |
| `REQUEST_WEAPON_HIGH_DETAIL_MODEL` | `void REQUEST_WEAPON_HIGH_DETAIL_MODEL(int weaponObject)` | void |
| `SET_AMMO_IN_CLIP` | `bool SET_AMMO_IN_CLIP(int ped, uint weaponHash, int ammo)` | bool |
| `SET_CAN_PED_SELECT_ALL_WEAPONS` | `void SET_CAN_PED_SELECT_ALL_WEAPONS(int ped, bool toggle)` | void |
| `SET_CAN_PED_SELECT_INVENTORY_WEAPON` | `void SET_CAN_PED_SELECT_INVENTORY_WEAPON(int ped, uint weaponHash, bool toggle)` | void |
| `SET_CURRENT_PED_VEHICLE_WEAPON` | `bool SET_CURRENT_PED_VEHICLE_WEAPON(int ped, uint weaponHash)` | bool |
| `SET_CURRENT_PED_WEAPON` | `void SET_CURRENT_PED_WEAPON(int ped, uint weaponHash, bool bForceInHand)` | void |
| `SET_EQIPPED_WEAPON_START_SPINNING_AT_FULL_SPEED` | `void SET_EQIPPED_WEAPON_START_SPINNING_AT_FULL_SPEED(int ped)` | void |
| `SET_FLASH_LIGHT_ACTIVE_HISTORY` | `void SET_FLASH_LIGHT_ACTIVE_HISTORY(int ped, bool toggle)` | void |
| `SET_FLASH_LIGHT_FADE_DISTANCE` | `bool SET_FLASH_LIGHT_FADE_DISTANCE(float distance)` | bool |
| `SET_PED_AMMO` | `void SET_PED_AMMO(int ped, uint weaponHash, int ammo, bool p3)` | void |
| `SET_PED_AMMO_BY_TYPE` | `void SET_PED_AMMO_BY_TYPE(int ped, uint ammoTypeHash, int ammo)` | void |
| `SET_PED_AMMO_TO_DROP` | `void SET_PED_AMMO_TO_DROP(int ped, int p1)` | void |
| `SET_PED_CHANCE_OF_FIRING_BLANKS` | `void SET_PED_CHANCE_OF_FIRING_BLANKS(int ped, float xBias, float yBias)` | void |
| `SET_PED_CURRENT_WEAPON_VISIBLE` | `void SET_PED_CURRENT_WEAPON_VISIBLE(int ped, bool visible, bool deselectWeapon, bool p3, bool p4)` | void |
| `SET_PED_CYCLE_VEHICLE_WEAPONS_ONLY` | `void SET_PED_CYCLE_VEHICLE_WEAPONS_ONLY(int ped)` | void |
| `SET_PED_DROPS_INVENTORY_WEAPON` | `void SET_PED_DROPS_INVENTORY_WEAPON(int ped, uint weaponHash, float xOffset, float yOffset, float zOffset, int ammoCount)` | void |
| `SET_PED_DROPS_WEAPON` | `void SET_PED_DROPS_WEAPON(int ped)` | void |
| `SET_PED_DROPS_WEAPONS_WHEN_DEAD` | `void SET_PED_DROPS_WEAPONS_WHEN_DEAD(int ped, bool toggle)` | void |
| `SET_PED_GADGET` | `void SET_PED_GADGET(int ped, uint gadgetHash, bool p2)` | void |
| `SET_PED_INFINITE_AMMO` | `void SET_PED_INFINITE_AMMO(int ped, bool toggle, uint weaponHash)` | void |
| `SET_PED_INFINITE_AMMO_CLIP` | `void SET_PED_INFINITE_AMMO_CLIP(int ped, bool toggle)` | void |
| `SET_PED_SHOOT_ORDNANCE_WEAPON` | `int SET_PED_SHOOT_ORDNANCE_WEAPON(int ped, float p1)` | int |
| `SET_PED_STUN_GUN_FINITE_AMMO` | `void SET_PED_STUN_GUN_FINITE_AMMO(object p0, object p1)` | void |
| `SET_PED_WEAPON_COMPONENT_TINT_INDEX` | `void SET_PED_WEAPON_COMPONENT_TINT_INDEX(int ped, uint weaponHash, uint camoComponentHash, int colorIndex)` | void |
| `SET_PED_WEAPON_TINT_INDEX` | `void SET_PED_WEAPON_TINT_INDEX(int ped, uint weaponHash, int tintIndex)` | void |
| `SET_PICKUP_AMMO_AMOUNT_SCALER` | `void SET_PICKUP_AMMO_AMOUNT_SCALER(float p0)` | void |
| `SET_PLAYER_TARGETTABLE_FOR_AIR_DEFENCE_SPHERE` | `void SET_PLAYER_TARGETTABLE_FOR_AIR_DEFENCE_SPHERE(int player, int zoneId, bool enable)` | void |
| `SET_WEAPON_ANIMATION_OVERRIDE` | `void SET_WEAPON_ANIMATION_OVERRIDE(int ped, uint animStyle)` | void |
| `SET_WEAPON_AOE_MODIFIER` | `void SET_WEAPON_AOE_MODIFIER(uint weaponHash, float multiplier)` | void |
| `SET_WEAPON_DAMAGE_MODIFIER` | `void SET_WEAPON_DAMAGE_MODIFIER(uint weaponHash, float damageMultiplier)` | void |
| `SET_WEAPON_EFFECT_DURATION_MODIFIER` | `void SET_WEAPON_EFFECT_DURATION_MODIFIER(uint p0, float p1)` | void |
| `SET_WEAPON_OBJECT_CAMO_INDEX` | `void SET_WEAPON_OBJECT_CAMO_INDEX(int weaponObject, int p1)` | void |
| `SET_WEAPON_OBJECT_COMPONENT_TINT_INDEX` | `void SET_WEAPON_OBJECT_COMPONENT_TINT_INDEX(int weaponObject, uint camoComponentHash, int colorIndex)` | void |
| `SET_WEAPON_OBJECT_TINT_INDEX` | `void SET_WEAPON_OBJECT_TINT_INDEX(int weapon, int tintIndex)` | void |
| `_GET_AMMO_IN_VEHICLE_WEAPON_CLIP` | `bool _GET_AMMO_IN_VEHICLE_WEAPON_CLIP(int vehicle, int seat, ref int ammo)` | bool |
| `_GET_TIME_BEFORE_VEHICLE_WEAPON_RELOAD_FINISHES` | `int _GET_TIME_BEFORE_VEHICLE_WEAPON_RELOAD_FINISHES(int vehicle, int seat)` | int |
| `_GET_VEHICLE_WEAPON_RELOAD_TIME` | `float _GET_VEHICLE_WEAPON_RELOAD_TIME(int vehicle, int seat)` | float |
| `_HAS_WEAPON_RELOADING_IN_VEHICLE` | `bool _HAS_WEAPON_RELOADING_IN_VEHICLE(int vehicle, int seat)` | bool |
| `_SET_AMMO_IN_VEHICLE_WEAPON_CLIP` | `bool _SET_AMMO_IN_VEHICLE_WEAPON_CLIP(int vehicle, int seat, int ammo)` | bool |
| `_SET_WEAPON_PED_DAMAGE_MODIFIER` | `void _SET_WEAPON_PED_DAMAGE_MODIFIER(uint weapon, float damageModifier)` | void |
| `_TRIGGER_VEHICLE_WEAPON_RELOAD` | `bool _TRIGGER_VEHICLE_WEAPON_RELOAD(int vehicle, int seat, int ped)` | bool |

---

## AI

| 函数名 | 签名 | 返回值 |
|--------|------|--------|
| `ADD_NAVMESH_BLOCKING_OBJECT` | `int ADD_NAVMESH_BLOCKING_OBJECT(float p0, float p1, float p2, float p3, float p4, float p5, float p6, bool p7, object p8)` | int |
| `ADD_NAVMESH_REQUIRED_REGION` | `void ADD_NAVMESH_REQUIRED_REGION(float x, float y, float radius)` | void |
| `ADD_SCRIPT_TO_RANDOM_PED` | `void ADD_SCRIPT_TO_RANDOM_PED(string name, uint model, float p2, float p3)` | void |
| `ADD_SHOCKING_EVENT_AT_POSITION` | `int ADD_SHOCKING_EVENT_AT_POSITION(int eventType, float x, float y, float z, float duration)` | int |
| `ADD_SHOCKING_EVENT_FOR_ENTITY` | `int ADD_SHOCKING_EVENT_FOR_ENTITY(int eventType, int entity, float duration)` | int |
| `ADJUST_AMBIENT_PED_SPAWN_DENSITIES_THIS_FRAME` | `void ADJUST_AMBIENT_PED_SPAWN_DENSITIES_THIS_FRAME(object p0, object p1, object p2, object p3, object p4, object p5, object p6)` | void |
| `ARE_ALL_NAVMESH_REGIONS_LOADED` | `bool ARE_ALL_NAVMESH_REGIONS_LOADED()` | bool |
| `ARE_NODES_LOADED_FOR_AREA` | `bool ARE_NODES_LOADED_FOR_AREA(float x1, float y1, float x2, float y2)` | bool |
| `BLOCK_DECISION_MAKER_EVENT` | `void BLOCK_DECISION_MAKER_EVENT(uint name, int eventType)` | void |
| `CALCULATE_TRAVEL_DISTANCE_BETWEEN_POINTS` | `float CALCULATE_TRAVEL_DISTANCE_BETWEEN_POINTS(float x1, float y1, float z1, float x2, float y2, float z2)` | float |
| `CLEAR_DECISION_MAKER_EVENT_RESPONSE` | `void CLEAR_DECISION_MAKER_EVENT_RESPONSE(uint name, int eventType)` | void |
| `CLEAR_GPS_DISABLED_ZONE_AT_INDEX` | `void CLEAR_GPS_DISABLED_ZONE_AT_INDEX(int index)` | void |
| `DISABLE_NAVMESH_IN_AREA` | `void DISABLE_NAVMESH_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool toggle)` | void |
| `DISABLE_SCRIPT_BRAIN_SET` | `void DISABLE_SCRIPT_BRAIN_SET(int brainSet)` | void |
| `DOES_NAVMESH_BLOCKING_OBJECT_EXIST` | `bool DOES_NAVMESH_BLOCKING_OBJECT_EXIST(object p0)` | bool |
| `ENABLE_SCRIPT_BRAIN_SET` | `void ENABLE_SCRIPT_BRAIN_SET(int brainSet)` | void |
| `GENERATE_DIRECTIONS_TO_COORD` | `int GENERATE_DIRECTIONS_TO_COORD(float x, float y, float z, bool p3, ref int direction, ref float p5, ref float distToNxJunction)` | int |
| `GET_APPROX_FLOOR_FOR_AREA` | `float GET_APPROX_FLOOR_FOR_AREA(float x1, float y1, float x2, float y2)` | float |
| `GET_APPROX_FLOOR_FOR_POINT` | `float GET_APPROX_FLOOR_FOR_POINT(float x, float y)` | float |
| `GET_APPROX_HEIGHT_FOR_AREA` | `float GET_APPROX_HEIGHT_FOR_AREA(float x1, float y1, float x2, float y2)` | float |
| `GET_APPROX_HEIGHT_FOR_POINT` | `float GET_APPROX_HEIGHT_FOR_POINT(float x, float y)` | float |
| `GET_CLOSEST_MAJOR_VEHICLE_NODE` | `bool GET_CLOSEST_MAJOR_VEHICLE_NODE(float x, float y, float z, ref Vector3 outPosition, float unknown1, float unknown2)` | bool |
| `GET_CLOSEST_ROAD` | `bool GET_CLOSEST_ROAD(float x, float y, float z, float p3, int p4, ref Vector3 p5, ref Vector3 p6, ref object p7, ref object p8, ref float p9, bool p10)` | bool |
| `GET_CLOSEST_VEHICLE_NODE` | `bool GET_CLOSEST_VEHICLE_NODE(float x, float y, float z, ref Vector3 outPosition, int nodeFlags, float p5, float p6)` | bool |
| `GET_CLOSEST_VEHICLE_NODE_WITH_HEADING` | `bool GET_CLOSEST_VEHICLE_NODE_WITH_HEADING(float x, float y, float z, ref Vector3 outPosition, ref float outHeading, int nodeType, float p6, float p7)` | bool |
| `GET_GPS_BLIP_ROUTE_FOUND` | `bool GET_GPS_BLIP_ROUTE_FOUND()` | bool |
| `GET_GPS_BLIP_ROUTE_LENGTH` | `int GET_GPS_BLIP_ROUTE_LENGTH()` | int |
| `GET_NEXT_GPS_DISABLED_ZONE_INDEX` | `int GET_NEXT_GPS_DISABLED_ZONE_INDEX()` | int |
| `GET_NTH_CLOSEST_VEHICLE_NODE` | `bool GET_NTH_CLOSEST_VEHICLE_NODE(float x, float y, float z, int nthClosest, ref Vector3 outPosition, int nodeFlags, float unknown1, float unknown2)` | bool |
| `GET_NTH_CLOSEST_VEHICLE_NODE_FAVOUR_DIRECTION` | `bool GET_NTH_CLOSEST_VEHICLE_NODE_FAVOUR_DIRECTION(float x, float y, float z, float desiredX, float desiredY, float desiredZ, int nthClosest, ref Vector3 outPosition, ref float outHeading, int nodeFlags, float p10, float p11)` | bool |
| `GET_NTH_CLOSEST_VEHICLE_NODE_ID` | `int GET_NTH_CLOSEST_VEHICLE_NODE_ID(float x, float y, float z, int nth, int nodeFlags, float p5, float p6)` | int |
| `GET_NTH_CLOSEST_VEHICLE_NODE_ID_WITH_HEADING` | `int GET_NTH_CLOSEST_VEHICLE_NODE_ID_WITH_HEADING(float x, float y, float z, int nthClosest, ref Vector3 outPosition, ref float outHeading, int nodeFlags, float p7, float p8)` | int |
| `GET_NTH_CLOSEST_VEHICLE_NODE_WITH_HEADING` | `bool GET_NTH_CLOSEST_VEHICLE_NODE_WITH_HEADING(float x, float y, float z, int nthClosest, ref Vector3 outPosition, ref float outHeading, ref int outNumLanes, int nodeFlags, float unknown3, float unknown4)` | bool |
| `GET_NUM_NAVMESHES_EXISTING_IN_AREA` | `int GET_NUM_NAVMESHES_EXISTING_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2)` | int |
| `GET_POSITION_BY_SIDE_OF_ROAD` | `bool GET_POSITION_BY_SIDE_OF_ROAD(float x, float y, float z, int p3, ref Vector3 outPosition)` | bool |
| `GET_POS_ALONG_GPS_TYPE_ROUTE` | `bool GET_POS_ALONG_GPS_TYPE_ROUTE(ref Vector3 result, bool p1, float p2, int p3)` | bool |
| `GET_RANDOM_VEHICLE_NODE` | `bool GET_RANDOM_VEHICLE_NODE(float x, float y, float z, float radius, bool p4, bool p5, bool p6, ref Vector3 outPosition, ref int nodeId)` | bool |
| `GET_ROAD_BOUNDARY_USING_HEADING` | `bool GET_ROAD_BOUNDARY_USING_HEADING(float x, float y, float z, float heading, ref Vector3 outPosition)` | bool |
| `GET_SAFE_COORD_FOR_PED` | `bool GET_SAFE_COORD_FOR_PED(float x, float y, float z, bool onGround, ref Vector3 outPosition, int flags)` | bool |
| `GET_SPAWN_COORDS_FOR_VEHICLE_NODE` | `void GET_SPAWN_COORDS_FOR_VEHICLE_NODE(int nodeAddress, float towardsCoorsX, float towardsCoorsY, float towardsCoorsZ, ref Vector3 centrePoint, ref float heading)` | void |
| `GET_STREET_NAME_AT_COORD` | `void GET_STREET_NAME_AT_COORD(float x, float y, float z, Hash* streetName, Hash* crossingRoad)` | void |
| `GET_VEHICLE_NODE_IS_GPS_ALLOWED` | `bool GET_VEHICLE_NODE_IS_GPS_ALLOWED(int nodeID)` | bool |
| `GET_VEHICLE_NODE_IS_SWITCHED_OFF` | `bool GET_VEHICLE_NODE_IS_SWITCHED_OFF(int nodeID)` | bool |
| `GET_VEHICLE_NODE_POSITION` | `void GET_VEHICLE_NODE_POSITION(int nodeId, ref Vector3 outPosition)` | void |
| `GET_VEHICLE_NODE_PROPERTIES` | `bool GET_VEHICLE_NODE_PROPERTIES(float x, float y, float z, ref int density, ref int flags)` | bool |
| `IS_NAVMESH_LOADED_IN_AREA` | `bool IS_NAVMESH_LOADED_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2)` | bool |
| `IS_NAVMESH_REQUIRED_REGION_IN_USE` | `bool IS_NAVMESH_REQUIRED_REGION_IN_USE()` | bool |
| `IS_OBJECT_WITHIN_BRAIN_ACTIVATION_RANGE` | `bool IS_OBJECT_WITHIN_BRAIN_ACTIVATION_RANGE(int object)` | bool |
| `IS_POINT_ON_ROAD` | `bool IS_POINT_ON_ROAD(float x, float y, float z, int vehicle)` | bool |
| `IS_SHOCKING_EVENT_IN_SPHERE` | `bool IS_SHOCKING_EVENT_IN_SPHERE(int eventType, float x, float y, float z, float radius)` | bool |
| `IS_VEHICLE_NODE_ID_VALID` | `bool IS_VEHICLE_NODE_ID_VALID(int vehicleNodeId)` | bool |
| `IS_WORLD_POINT_WITHIN_BRAIN_ACTIVATION_RANGE` | `bool IS_WORLD_POINT_WITHIN_BRAIN_ACTIVATION_RANGE()` | bool |
| `LOAD_ALL_PATH_NODES` | `bool LOAD_ALL_PATH_NODES(bool set)` | bool |
| `REACTIVATE_ALL_OBJECT_BRAINS_THAT_ARE_WAITING_TILL_OUT_OF_RANGE` | `void REACTIVATE_ALL_OBJECT_BRAINS_THAT_ARE_WAITING_TILL_OUT_OF_RANGE()` | void |
| `REACTIVATE_ALL_WORLD_BRAINS_THAT_ARE_WAITING_TILL_OUT_OF_RANGE` | `void REACTIVATE_ALL_WORLD_BRAINS_THAT_ARE_WAITING_TILL_OUT_OF_RANGE()` | void |
| `REACTIVATE_NAMED_OBJECT_BRAINS_WAITING_TILL_OUT_OF_RANGE` | `void REACTIVATE_NAMED_OBJECT_BRAINS_WAITING_TILL_OUT_OF_RANGE(string scriptName)` | void |
| `REACTIVATE_NAMED_WORLD_BRAINS_WAITING_TILL_OUT_OF_RANGE` | `void REACTIVATE_NAMED_WORLD_BRAINS_WAITING_TILL_OUT_OF_RANGE(string scriptName)` | void |
| `REGISTER_OBJECT_SCRIPT_BRAIN` | `void REGISTER_OBJECT_SCRIPT_BRAIN(string scriptName, uint modelHash, int p2, float activationRange, int p4, int p5)` | void |
| `REGISTER_WORLD_POINT_SCRIPT_BRAIN` | `void REGISTER_WORLD_POINT_SCRIPT_BRAIN(string scriptName, float activationRange, int p2)` | void |
| `REMOVE_ALL_SHOCKING_EVENTS` | `void REMOVE_ALL_SHOCKING_EVENTS(bool p0)` | void |
| `REMOVE_NAVMESH_BLOCKING_OBJECT` | `void REMOVE_NAVMESH_BLOCKING_OBJECT(object p0)` | void |
| `REMOVE_NAVMESH_REQUIRED_REGIONS` | `void REMOVE_NAVMESH_REQUIRED_REGIONS()` | void |
| `REMOVE_SHOCKING_EVENT` | `bool REMOVE_SHOCKING_EVENT(int event)` | bool |
| `REMOVE_SHOCKING_EVENT_SPAWN_BLOCKING_AREAS` | `void REMOVE_SHOCKING_EVENT_SPAWN_BLOCKING_AREAS()` | void |
| `REQUEST_PATH_NODES_IN_AREA_THIS_FRAME` | `bool REQUEST_PATH_NODES_IN_AREA_THIS_FRAME(float x1, float y1, float x2, float y2)` | bool |
| `SET_ALLOW_STREAM_HEIST_ISLAND_NODES` | `void SET_ALLOW_STREAM_HEIST_ISLAND_NODES(int type)` | void |
| `SET_ALLOW_STREAM_PROLOGUE_NODES` | `void SET_ALLOW_STREAM_PROLOGUE_NODES(bool toggle)` | void |
| `SET_AMBIENT_PED_RANGE_MULTIPLIER_THIS_FRAME` | `void SET_AMBIENT_PED_RANGE_MULTIPLIER_THIS_FRAME(float multiplier)` | void |
| `SET_DECISION_MAKER` | `void SET_DECISION_MAKER(int ped, uint name)` | void |
| `SET_GPS_DISABLED_ZONE` | `void SET_GPS_DISABLED_ZONE(float x1, float y1, float z1, float x2, float y2, float z3)` | void |
| `SET_GPS_DISABLED_ZONE_AT_INDEX` | `void SET_GPS_DISABLED_ZONE_AT_INDEX(float x1, float y1, float z1, float x2, float y2, float z2, int index)` | void |
| `SET_IGNORE_NO_GPS_FLAG` | `void SET_IGNORE_NO_GPS_FLAG(bool toggle)` | void |
| `SET_IGNORE_NO_GPS_FLAG_UNTIL_FIRST_NORMAL_NODE` | `void SET_IGNORE_NO_GPS_FLAG_UNTIL_FIRST_NORMAL_NODE(bool toggle)` | void |
| `SET_PED_PATHS_BACK_TO_ORIGINAL` | `void SET_PED_PATHS_BACK_TO_ORIGINAL(float x1, float y1, float z1, float x2, float y2, float z2, object p6)` | void |
| `SET_PED_PATHS_IN_AREA` | `void SET_PED_PATHS_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool p6, object p7)` | void |
| `SET_ROADS_BACK_TO_ORIGINAL` | `void SET_ROADS_BACK_TO_ORIGINAL(float p0, float p1, float p2, float p3, float p4, float p5, object p6)` | void |
| `SET_ROADS_BACK_TO_ORIGINAL_IN_ANGLED_AREA` | `void SET_ROADS_BACK_TO_ORIGINAL_IN_ANGLED_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float width, object p7)` | void |
| `SET_ROADS_IN_ANGLED_AREA` | `void SET_ROADS_IN_ANGLED_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float width, bool unknown1, bool unknown2, bool unknown3)` | void |
| `SET_ROADS_IN_AREA` | `void SET_ROADS_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool nodeEnabled, bool unknown2)` | void |
| `SUPPRESS_AGITATION_EVENTS_NEXT_FRAME` | `void SUPPRESS_AGITATION_EVENTS_NEXT_FRAME()` | void |
| `SUPPRESS_SHOCKING_EVENTS_NEXT_FRAME` | `void SUPPRESS_SHOCKING_EVENTS_NEXT_FRAME()` | void |
| `SUPPRESS_SHOCKING_EVENT_TYPE_NEXT_FRAME` | `void SUPPRESS_SHOCKING_EVENT_TYPE_NEXT_FRAME(int eventType)` | void |
| `UNBLOCK_DECISION_MAKER_EVENT` | `void UNBLOCK_DECISION_MAKER_EVENT(uint name, int eventType)` | void |
| `UPDATE_NAVMESH_BLOCKING_OBJECT` | `void UPDATE_NAVMESH_BLOCKING_OBJECT(object p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, object p8)` | void |

---

## CAMERA

| 函数名 | 签名 | 返回值 |
|--------|------|--------|
| `ADD_CAM_SPLINE_NODE` | `void ADD_CAM_SPLINE_NODE(int camera, float x, float y, float z, float xRot, float yRot, float zRot, int length, int smoothingStyle, int rotationOrder)` | void |
| `ADD_CAM_SPLINE_NODE_USING_CAMERA` | `void ADD_CAM_SPLINE_NODE_USING_CAMERA(int cam, int cam2, int length, int p3)` | void |
| `ADD_CAM_SPLINE_NODE_USING_CAMERA_FRAME` | `void ADD_CAM_SPLINE_NODE_USING_CAMERA_FRAME(int cam, int cam2, int length, int p3)` | void |
| `ADD_CAM_SPLINE_NODE_USING_GAMEPLAY_FRAME` | `void ADD_CAM_SPLINE_NODE_USING_GAMEPLAY_FRAME(int cam, int length, int p2)` | void |
| `ALLOW_MOTION_BLUR_DECAY` | `void ALLOW_MOTION_BLUR_DECAY(object p0, bool p1)` | void |
| `ANIMATED_SHAKE_CAM` | `void ANIMATED_SHAKE_CAM(int cam, string p1, string p2, string p3, float amplitude)` | void |
| `ANIMATED_SHAKE_SCRIPT_GLOBAL` | `void ANIMATED_SHAKE_SCRIPT_GLOBAL(string p0, string p1, string p2, float p3)` | void |
| `ARE_WIDESCREEN_BORDERS_ACTIVE` | `bool ARE_WIDESCREEN_BORDERS_ACTIVE()` | bool |
| `ATTACH_CAM_TO_ENTITY` | `void ATTACH_CAM_TO_ENTITY(int cam, int entity, float xOffset, float yOffset, float zOffset, bool isRelative)` | void |
| `ATTACH_CAM_TO_PED_BONE` | `void ATTACH_CAM_TO_PED_BONE(int cam, int ped, int boneIndex, float x, float y, float z, bool heading)` | void |
| `ATTACH_CAM_TO_VEHICLE_BONE` | `void ATTACH_CAM_TO_VEHICLE_BONE(int cam, int vehicle, int boneIndex, bool relativeRotation, float rotX, float rotY, float rotZ, float offsetX, float offsetY, float offsetZ, bool fixedDirection)` | void |
| `BLOCK_FIRST_PERSON_ORIENTATION_RESET_THIS_UPDATE` | `void BLOCK_FIRST_PERSON_ORIENTATION_RESET_THIS_UPDATE()` | void |
| `BYPASS_CAMERA_COLLISION_BUOYANCY_TEST_THIS_UPDATE` | `void BYPASS_CAMERA_COLLISION_BUOYANCY_TEST_THIS_UPDATE()` | void |
| `BYPASS_CUTSCENE_CAM_RENDERING_THIS_UPDATE` | `void BYPASS_CUTSCENE_CAM_RENDERING_THIS_UPDATE()` | void |
| `CAMERA_PREVENT_COLLISION_SETTINGS_FOR_TRIPLEHEAD_IN_INTERIORS_THIS_UPDATE` | `void CAMERA_PREVENT_COLLISION_SETTINGS_FOR_TRIPLEHEAD_IN_INTERIORS_THIS_UPDATE()` | void |
| `CREATE_CAM` | `int CREATE_CAM(string camName, bool p1)` | int |
| `CREATE_CAMERA` | `int CREATE_CAMERA(uint camHash, bool p1)` | int |
| `CREATE_CAMERA_WITH_PARAMS` | `int CREATE_CAMERA_WITH_PARAMS(uint camHash, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fov, bool p8, object p9)` | int |
| `CREATE_CAM_WITH_PARAMS` | `int CREATE_CAM_WITH_PARAMS(string camName, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fov, bool p8, int p9)` | int |
| `CREATE_CINEMATIC_SHOT` | `void CREATE_CINEMATIC_SHOT(uint p0, int time, bool p2, int entity)` | void |
| `DESTROY_ALL_CAMS` | `void DESTROY_ALL_CAMS(bool bScriptHostCam)` | void |
| `DESTROY_CAM` | `void DESTROY_CAM(int cam, bool bScriptHostCam)` | void |
| `DETACH_CAM` | `void DETACH_CAM(int cam)` | void |
| `DISABLE_AIM_CAM_THIS_UPDATE` | `void DISABLE_AIM_CAM_THIS_UPDATE()` | void |
| `DISABLE_CAM_COLLISION_FOR_OBJECT` | `void DISABLE_CAM_COLLISION_FOR_OBJECT(int entity)` | void |
| `DISABLE_CINEMATIC_BONNET_CAMERA_THIS_UPDATE` | `void DISABLE_CINEMATIC_BONNET_CAMERA_THIS_UPDATE()` | void |
| `DISABLE_CINEMATIC_SLOW_MO_THIS_UPDATE` | `bool DISABLE_CINEMATIC_SLOW_MO_THIS_UPDATE()` | bool |
| `DISABLE_CINEMATIC_VEHICLE_IDLE_MODE_THIS_UPDATE` | `void DISABLE_CINEMATIC_VEHICLE_IDLE_MODE_THIS_UPDATE()` | void |
| `DISABLE_FIRST_PERSON_CAMERA_WATER_CLIPPING_TEST_THIS_UPDATE` | `void DISABLE_FIRST_PERSON_CAMERA_WATER_CLIPPING_TEST_THIS_UPDATE()` | void |
| `DISABLE_FIRST_PERSON_FLASH_EFFECT_THIS_UPDATE` | `void DISABLE_FIRST_PERSON_FLASH_EFFECT_THIS_UPDATE()` | void |
| `DISABLE_GAMEPLAY_CAM_ALTITUDE_FOV_SCALING_THIS_UPDATE` | `void DISABLE_GAMEPLAY_CAM_ALTITUDE_FOV_SCALING_THIS_UPDATE()` | void |
| `DISABLE_NEAR_CLIP_SCAN_THIS_UPDATE` | `void DISABLE_NEAR_CLIP_SCAN_THIS_UPDATE()` | void |
| `DISABLE_ON_FOOT_FIRST_PERSON_VIEW_THIS_UPDATE` | `void DISABLE_ON_FOOT_FIRST_PERSON_VIEW_THIS_UPDATE()` | void |
| `DOES_CAM_EXIST` | `bool DOES_CAM_EXIST(int cam)` | bool |
| `DO_SCREEN_FADE_IN` | `void DO_SCREEN_FADE_IN(int duration)` | void |
| `DO_SCREEN_FADE_OUT` | `void DO_SCREEN_FADE_OUT(int duration)` | void |
| `FORCE_BONNET_CAMERA_RELATIVE_HEADING_AND_PITCH` | `void FORCE_BONNET_CAMERA_RELATIVE_HEADING_AND_PITCH(float p0, float p1)` | void |
| `FORCE_CAMERA_RELATIVE_HEADING_AND_PITCH` | `void FORCE_CAMERA_RELATIVE_HEADING_AND_PITCH(float roll, float pitch, float yaw)` | void |
| `FORCE_CAM_FAR_CLIP` | `void FORCE_CAM_FAR_CLIP(int cam, float p1)` | void |
| `FORCE_CINEMATIC_RENDERING_THIS_UPDATE` | `void FORCE_CINEMATIC_RENDERING_THIS_UPDATE(bool toggle)` | void |
| `FORCE_TIGHTSPACE_CUSTOM_FRAMING_THIS_UPDATE` | `void FORCE_TIGHTSPACE_CUSTOM_FRAMING_THIS_UPDATE()` | void |
| `FORCE_VEHICLE_CAM_STUNT_SETTINGS_THIS_UPDATE` | `void FORCE_VEHICLE_CAM_STUNT_SETTINGS_THIS_UPDATE()` | void |
| `GET_CAM_ACTIVE_VIEW_MODE_CONTEXT` | `int GET_CAM_ACTIVE_VIEW_MODE_CONTEXT()` | int |
| `GET_CAM_ANIM_CURRENT_PHASE` | `float GET_CAM_ANIM_CURRENT_PHASE(int cam)` | float |
| `GET_CAM_COORD` | `Vector3 GET_CAM_COORD(int cam)` | Vector3 |
| `GET_CAM_DOF_STRENGTH` | `float GET_CAM_DOF_STRENGTH(int cam)` | float |
| `GET_CAM_FAR_CLIP` | `float GET_CAM_FAR_CLIP(int cam)` | float |
| `GET_CAM_FAR_DOF` | `float GET_CAM_FAR_DOF(int cam)` | float |
| `GET_CAM_FOV` | `float GET_CAM_FOV(int cam)` | float |
| `GET_CAM_NEAR_CLIP` | `float GET_CAM_NEAR_CLIP(int cam)` | float |
| `GET_CAM_NEAR_DOF` | `float GET_CAM_NEAR_DOF(int cam)` | float |
| `GET_CAM_ROT` | `Vector3 GET_CAM_ROT(int cam, int rotationOrder)` | Vector3 |
| `GET_CAM_SPLINE_NODE_INDEX` | `int GET_CAM_SPLINE_NODE_INDEX(int cam)` | int |
| `GET_CAM_SPLINE_NODE_PHASE` | `float GET_CAM_SPLINE_NODE_PHASE(int cam)` | float |
| `GET_CAM_SPLINE_PHASE` | `float GET_CAM_SPLINE_PHASE(int cam)` | float |
| `GET_CAM_VIEW_MODE_FOR_CONTEXT` | `int GET_CAM_VIEW_MODE_FOR_CONTEXT(int context)` | int |
| `GET_DEBUG_CAM` | `int GET_DEBUG_CAM()` | int |
| `GET_FINAL_RENDERED_CAM_COORD` | `Vector3 GET_FINAL_RENDERED_CAM_COORD()` | Vector3 |
| `GET_FINAL_RENDERED_CAM_FAR_CLIP` | `float GET_FINAL_RENDERED_CAM_FAR_CLIP()` | float |
| `GET_FINAL_RENDERED_CAM_FAR_DOF` | `float GET_FINAL_RENDERED_CAM_FAR_DOF()` | float |
| `GET_FINAL_RENDERED_CAM_FOV` | `float GET_FINAL_RENDERED_CAM_FOV()` | float |
| `GET_FINAL_RENDERED_CAM_MOTION_BLUR_STRENGTH` | `float GET_FINAL_RENDERED_CAM_MOTION_BLUR_STRENGTH()` | float |
| `GET_FINAL_RENDERED_CAM_NEAR_CLIP` | `float GET_FINAL_RENDERED_CAM_NEAR_CLIP()` | float |
| `GET_FINAL_RENDERED_CAM_NEAR_DOF` | `float GET_FINAL_RENDERED_CAM_NEAR_DOF()` | float |
| `GET_FINAL_RENDERED_CAM_ROT` | `Vector3 GET_FINAL_RENDERED_CAM_ROT(int rotationOrder)` | Vector3 |
| `GET_FINAL_RENDERED_REMOTE_PLAYER_CAM_FOV` | `float GET_FINAL_RENDERED_REMOTE_PLAYER_CAM_FOV(int player)` | float |
| `GET_FINAL_RENDERED_REMOTE_PLAYER_CAM_ROT` | `Vector3 GET_FINAL_RENDERED_REMOTE_PLAYER_CAM_ROT(int player, int rotationOrder)` | Vector3 |
| `GET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR` | `float GET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR()` | float |
| `GET_FOCUS_PED_ON_SCREEN` | `int GET_FOCUS_PED_ON_SCREEN(float p0, int p1, float p2, float p3, float p4, float p5, float p6, int p7, int p8)` | int |
| `GET_FOLLOW_PED_CAM_VIEW_MODE` | `int GET_FOLLOW_PED_CAM_VIEW_MODE()` | int |
| `GET_FOLLOW_PED_CAM_ZOOM_LEVEL` | `int GET_FOLLOW_PED_CAM_ZOOM_LEVEL()` | int |
| `GET_FOLLOW_VEHICLE_CAM_VIEW_MODE` | `int GET_FOLLOW_VEHICLE_CAM_VIEW_MODE()` | int |
| `GET_FOLLOW_VEHICLE_CAM_ZOOM_LEVEL` | `int GET_FOLLOW_VEHICLE_CAM_ZOOM_LEVEL()` | int |
| `GET_GAMEPLAY_CAM_COORD` | `Vector3 GET_GAMEPLAY_CAM_COORD()` | Vector3 |
| `GET_GAMEPLAY_CAM_FOV` | `float GET_GAMEPLAY_CAM_FOV()` | float |
| `GET_GAMEPLAY_CAM_RELATIVE_HEADING` | `float GET_GAMEPLAY_CAM_RELATIVE_HEADING()` | float |
| `GET_GAMEPLAY_CAM_RELATIVE_PITCH` | `float GET_GAMEPLAY_CAM_RELATIVE_PITCH()` | float |
| `GET_GAMEPLAY_CAM_ROT` | `Vector3 GET_GAMEPLAY_CAM_ROT(int rotationOrder)` | Vector3 |
| `GET_RENDERING_CAM` | `int GET_RENDERING_CAM()` | int |
| `HARD_ATTACH_CAM_TO_ENTITY` | `void HARD_ATTACH_CAM_TO_ENTITY(int cam, int entity, float xRot, float yRot, float zRot, float xOffset, float yOffset, float zOffset, bool isRelative)` | void |
| `HARD_ATTACH_CAM_TO_PED_BONE` | `void HARD_ATTACH_CAM_TO_PED_BONE(int cam, int ped, int boneIndex, float p3, float p4, float p5, float p6, float p7, float p8, bool p9)` | void |
| `IGNORE_MENU_PREFERENCE_FOR_BONNET_CAMERA_THIS_UPDATE` | `void IGNORE_MENU_PREFERENCE_FOR_BONNET_CAMERA_THIS_UPDATE()` | void |
| `INVALIDATE_CINEMATIC_VEHICLE_IDLE_MODE` | `void INVALIDATE_CINEMATIC_VEHICLE_IDLE_MODE()` | void |
| `INVALIDATE_IDLE_CAM` | `void INVALIDATE_IDLE_CAM()` | void |
| `IS_AIM_CAM_ACTIVE` | `bool IS_AIM_CAM_ACTIVE()` | bool |
| `IS_AIM_CAM_ACTIVE_IN_ACCURATE_MODE` | `bool IS_AIM_CAM_ACTIVE_IN_ACCURATE_MODE()` | bool |
| `IS_ALLOWED_INDEPENDENT_CAMERA_MODES` | `bool IS_ALLOWED_INDEPENDENT_CAMERA_MODES()` | bool |
| `IS_BONNET_CINEMATIC_CAM_RENDERING` | `bool IS_BONNET_CINEMATIC_CAM_RENDERING()` | bool |
| `IS_CAM_ACTIVE` | `bool IS_CAM_ACTIVE(int cam)` | bool |
| `IS_CAM_INTERPOLATING` | `bool IS_CAM_INTERPOLATING(int cam)` | bool |
| `IS_CAM_PLAYING_ANIM` | `bool IS_CAM_PLAYING_ANIM(int cam, string animName, string animDictionary)` | bool |
| `IS_CAM_RENDERING` | `bool IS_CAM_RENDERING(int cam)` | bool |
| `IS_CAM_SHAKING` | `bool IS_CAM_SHAKING(int cam)` | bool |
| `IS_CAM_SPLINE_PAUSED` | `bool IS_CAM_SPLINE_PAUSED(int cam)` | bool |
| `IS_CINEMATIC_CAM_INPUT_ACTIVE` | `bool IS_CINEMATIC_CAM_INPUT_ACTIVE()` | bool |
| `IS_CINEMATIC_CAM_RENDERING` | `bool IS_CINEMATIC_CAM_RENDERING()` | bool |
| `IS_CINEMATIC_CAM_SHAKING` | `bool IS_CINEMATIC_CAM_SHAKING()` | bool |
| `IS_CINEMATIC_FIRST_PERSON_VEHICLE_INTERIOR_CAM_RENDERING` | `bool IS_CINEMATIC_FIRST_PERSON_VEHICLE_INTERIOR_CAM_RENDERING()` | bool |
| `IS_CINEMATIC_IDLE_CAM_RENDERING` | `bool IS_CINEMATIC_IDLE_CAM_RENDERING()` | bool |
| `IS_CINEMATIC_SHOT_ACTIVE` | `bool IS_CINEMATIC_SHOT_ACTIVE(uint p0)` | bool |
| `IS_CODE_GAMEPLAY_HINT_ACTIVE` | `bool IS_CODE_GAMEPLAY_HINT_ACTIVE()` | bool |
| `IS_FIRST_PERSON_AIM_CAM_ACTIVE` | `bool IS_FIRST_PERSON_AIM_CAM_ACTIVE()` | bool |
| `IS_FOLLOW_PED_CAM_ACTIVE` | `bool IS_FOLLOW_PED_CAM_ACTIVE()` | bool |
| `IS_FOLLOW_VEHICLE_CAM_ACTIVE` | `bool IS_FOLLOW_VEHICLE_CAM_ACTIVE()` | bool |
| `IS_GAMEPLAY_CAM_LOOKING_BEHIND` | `bool IS_GAMEPLAY_CAM_LOOKING_BEHIND()` | bool |
| `IS_GAMEPLAY_CAM_RENDERING` | `bool IS_GAMEPLAY_CAM_RENDERING()` | bool |
| `IS_GAMEPLAY_CAM_SHAKING` | `bool IS_GAMEPLAY_CAM_SHAKING()` | bool |
| `IS_GAMEPLAY_HINT_ACTIVE` | `bool IS_GAMEPLAY_HINT_ACTIVE()` | bool |
| `IS_INTERPOLATING_FROM_SCRIPT_CAMS` | `bool IS_INTERPOLATING_FROM_SCRIPT_CAMS()` | bool |
| `IS_INTERPOLATING_TO_SCRIPT_CAMS` | `bool IS_INTERPOLATING_TO_SCRIPT_CAMS()` | bool |
| `IS_IN_VEHICLE_MOBILE_PHONE_CAMERA_RENDERING` | `bool IS_IN_VEHICLE_MOBILE_PHONE_CAMERA_RENDERING()` | bool |
| `IS_SCREEN_FADED_IN` | `bool IS_SCREEN_FADED_IN()` | bool |
| `IS_SCREEN_FADED_OUT` | `bool IS_SCREEN_FADED_OUT()` | bool |
| `IS_SCREEN_FADING_IN` | `bool IS_SCREEN_FADING_IN()` | bool |
| `IS_SCREEN_FADING_OUT` | `bool IS_SCREEN_FADING_OUT()` | bool |
| `IS_SCRIPT_GLOBAL_SHAKING` | `bool IS_SCRIPT_GLOBAL_SHAKING()` | bool |
| `IS_SPHERE_VISIBLE` | `bool IS_SPHERE_VISIBLE(float x, float y, float z, float radius)` | bool |
| `OVERRIDE_CAM_SPLINE_MOTION_BLUR` | `void OVERRIDE_CAM_SPLINE_MOTION_BLUR(int cam, int p1, float p2, float p3)` | void |
| `OVERRIDE_CAM_SPLINE_VELOCITY` | `void OVERRIDE_CAM_SPLINE_VELOCITY(int cam, int p1, float p2, float p3)` | void |
| `PLAY_CAM_ANIM` | `bool PLAY_CAM_ANIM(int cam, string animName, string animDictionary, float x, float y, float z, float xRot, float yRot, float zRot, bool p9, int p10)` | bool |
| `PLAY_SYNCHRONIZED_CAM_ANIM` | `bool PLAY_SYNCHRONIZED_CAM_ANIM(object p0, object p1, string animName, string animDictionary)` | bool |
| `POINT_CAM_AT_COORD` | `void POINT_CAM_AT_COORD(int cam, float x, float y, float z)` | void |
| `POINT_CAM_AT_ENTITY` | `void POINT_CAM_AT_ENTITY(int cam, int entity, float p2, float p3, float p4, bool p5)` | void |
| `POINT_CAM_AT_PED_BONE` | `void POINT_CAM_AT_PED_BONE(int cam, int ped, int boneIndex, float x, float y, float z, bool p6)` | void |
| `RENDER_SCRIPT_CAMS` | `void RENDER_SCRIPT_CAMS(bool render, bool ease, int easeTime, bool p3, bool p4, object p5)` | void |
| `REPLAY_GET_MAX_DISTANCE_ALLOWED_FROM_PLAYER` | `float REPLAY_GET_MAX_DISTANCE_ALLOWED_FROM_PLAYER()` | float |
| `RESET_GAMEPLAY_CAM_FULL_ATTACH_PARENT_TRANSFORM_TIMER` | `void RESET_GAMEPLAY_CAM_FULL_ATTACH_PARENT_TRANSFORM_TIMER()` | void |
| `SET_ALLOW_CUSTOM_VEHICLE_DRIVE_BY_CAM_THIS_UPDATE` | `void SET_ALLOW_CUSTOM_VEHICLE_DRIVE_BY_CAM_THIS_UPDATE(bool p0)` | void |
| `SET_CAM_ACTIVE` | `void SET_CAM_ACTIVE(int cam, bool active)` | void |
| `SET_CAM_ACTIVE_WITH_INTERP` | `void SET_CAM_ACTIVE_WITH_INTERP(int camTo, int camFrom, int duration, int easeLocation, int easeRotation)` | void |
| `SET_CAM_AFFECTS_AIMING` | `void SET_CAM_AFFECTS_AIMING(int cam, bool toggle)` | void |
| `SET_CAM_ANIM_CURRENT_PHASE` | `void SET_CAM_ANIM_CURRENT_PHASE(int cam, float phase)` | void |
| `SET_CAM_CONTROLS_MINI_MAP_HEADING` | `void SET_CAM_CONTROLS_MINI_MAP_HEADING(int cam, bool toggle)` | void |
| `SET_CAM_COORD` | `void SET_CAM_COORD(int cam, float posX, float posY, float posZ)` | void |
| `SET_CAM_DEATH_FAIL_EFFECT_STATE` | `void SET_CAM_DEATH_FAIL_EFFECT_STATE(int p0)` | void |
| `SET_CAM_DEBUG_NAME` | `void SET_CAM_DEBUG_NAME(int camera, string name)` | void |
| `SET_CAM_DOF_FNUMBER_OF_LENS` | `void SET_CAM_DOF_FNUMBER_OF_LENS(int camera, float p1)` | void |
| `SET_CAM_DOF_FOCAL_LENGTH_MULTIPLIER` | `void SET_CAM_DOF_FOCAL_LENGTH_MULTIPLIER(int camera, float multiplier)` | void |
| `SET_CAM_DOF_FOCUS_DISTANCE_BIAS` | `void SET_CAM_DOF_FOCUS_DISTANCE_BIAS(int camera, float p1)` | void |
| `SET_CAM_DOF_MAX_NEAR_IN_FOCUS_DISTANCE` | `void SET_CAM_DOF_MAX_NEAR_IN_FOCUS_DISTANCE(int camera, float p1)` | void |
| `SET_CAM_DOF_MAX_NEAR_IN_FOCUS_DISTANCE_BLEND_LEVEL` | `void SET_CAM_DOF_MAX_NEAR_IN_FOCUS_DISTANCE_BLEND_LEVEL(int camera, float p1)` | void |
| `SET_CAM_DOF_OVERRIDDEN_FOCUS_DISTANCE` | `void SET_CAM_DOF_OVERRIDDEN_FOCUS_DISTANCE(int camera, float p1)` | void |
| `SET_CAM_DOF_OVERRIDDEN_FOCUS_DISTANCE_BLEND_LEVEL` | `void SET_CAM_DOF_OVERRIDDEN_FOCUS_DISTANCE_BLEND_LEVEL(object p0, float p1)` | void |
| `SET_CAM_DOF_PLANES` | `void SET_CAM_DOF_PLANES(int cam, float p1, float p2, float p3, float p4)` | void |
| `SET_CAM_DOF_SHOULD_KEEP_LOOK_AT_TARGET_IN_FOCUS` | `void SET_CAM_DOF_SHOULD_KEEP_LOOK_AT_TARGET_IN_FOCUS(int camera, bool state)` | void |
| `SET_CAM_DOF_STRENGTH` | `void SET_CAM_DOF_STRENGTH(int cam, float dofStrength)` | void |
| `SET_CAM_FAR_CLIP` | `void SET_CAM_FAR_CLIP(int cam, float farClip)` | void |
| `SET_CAM_FAR_DOF` | `void SET_CAM_FAR_DOF(int cam, float farDOF)` | void |
| `SET_CAM_FOV` | `void SET_CAM_FOV(int cam, float fieldOfView)` | void |
| `SET_CAM_INHERIT_ROLL_VEHICLE` | `void SET_CAM_INHERIT_ROLL_VEHICLE(int cam, bool p1)` | void |
| `SET_CAM_IS_INSIDE_VEHICLE` | `void SET_CAM_IS_INSIDE_VEHICLE(int cam, bool toggle)` | void |
| `SET_CAM_MOTION_BLUR_STRENGTH` | `void SET_CAM_MOTION_BLUR_STRENGTH(int cam, float strength)` | void |
| `SET_CAM_NEAR_CLIP` | `void SET_CAM_NEAR_CLIP(int cam, float nearClip)` | void |
| `SET_CAM_NEAR_DOF` | `void SET_CAM_NEAR_DOF(int cam, float nearDOF)` | void |
| `SET_CAM_PARAMS` | `void SET_CAM_PARAMS(int cam, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fieldOfView, object p8, int p9, int p10, int p11)` | void |
| `SET_CAM_ROT` | `void SET_CAM_ROT(int cam, float rotX, float rotY, float rotZ, int rotationOrder)` | void |
| `SET_CAM_SHAKE_AMPLITUDE` | `void SET_CAM_SHAKE_AMPLITUDE(int cam, float amplitude)` | void |
| `SET_CAM_SPLINE_DURATION` | `void SET_CAM_SPLINE_DURATION(int cam, int timeDuration)` | void |
| `SET_CAM_SPLINE_NODE_EASE` | `void SET_CAM_SPLINE_NODE_EASE(int cam, int easingFunction, int p2, float p3)` | void |
| `SET_CAM_SPLINE_NODE_EXTRA_FLAGS` | `void SET_CAM_SPLINE_NODE_EXTRA_FLAGS(int cam, int p1, int flags)` | void |
| `SET_CAM_SPLINE_NODE_VELOCITY_SCALE` | `void SET_CAM_SPLINE_NODE_VELOCITY_SCALE(int cam, int p1, float scale)` | void |
| `SET_CAM_SPLINE_PHASE` | `void SET_CAM_SPLINE_PHASE(int cam, float p1)` | void |
| `SET_CAM_SPLINE_SMOOTHING_STYLE` | `void SET_CAM_SPLINE_SMOOTHING_STYLE(int cam, int smoothingStyle)` | void |
| `SET_CAM_USE_SHALLOW_DOF_MODE` | `void SET_CAM_USE_SHALLOW_DOF_MODE(int cam, bool toggle)` | void |
| `SET_CAM_VIEW_MODE_FOR_CONTEXT` | `void SET_CAM_VIEW_MODE_FOR_CONTEXT(int context, int viewMode)` | void |
| `SET_CINEMATIC_BUTTON_ACTIVE` | `void SET_CINEMATIC_BUTTON_ACTIVE(bool p0)` | void |
| `SET_CINEMATIC_CAM_SHAKE_AMPLITUDE` | `void SET_CINEMATIC_CAM_SHAKE_AMPLITUDE(float p0)` | void |
| `SET_CINEMATIC_MODE_ACTIVE` | `void SET_CINEMATIC_MODE_ACTIVE(bool toggle)` | void |
| `SET_CINEMATIC_NEWS_CHANNEL_ACTIVE_THIS_UPDATE` | `void SET_CINEMATIC_NEWS_CHANNEL_ACTIVE_THIS_UPDATE()` | void |
| `SET_CUTSCENE_CAM_FAR_CLIP_THIS_UPDATE` | `void SET_CUTSCENE_CAM_FAR_CLIP_THIS_UPDATE(float p0)` | void |
| `SET_FIRST_PERSON_AIM_CAM_NEAR_CLIP_THIS_UPDATE` | `void SET_FIRST_PERSON_AIM_CAM_NEAR_CLIP_THIS_UPDATE(float p0)` | void |
| `SET_FIRST_PERSON_AIM_CAM_RELATIVE_HEADING_LIMITS_THIS_UPDATE` | `void SET_FIRST_PERSON_AIM_CAM_RELATIVE_HEADING_LIMITS_THIS_UPDATE(float p0, float p1)` | void |
| `SET_FIRST_PERSON_AIM_CAM_RELATIVE_PITCH_LIMITS_THIS_UPDATE` | `void SET_FIRST_PERSON_AIM_CAM_RELATIVE_PITCH_LIMITS_THIS_UPDATE(float p0, float p1)` | void |
| `SET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR` | `void SET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR(float zoomFactor)` | void |
| `SET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR_LIMITS_THIS_UPDATE` | `void SET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR_LIMITS_THIS_UPDATE(float p0, float p1)` | void |
| `SET_FIRST_PERSON_FLASH_EFFECT_TYPE` | `void SET_FIRST_PERSON_FLASH_EFFECT_TYPE(object p0)` | void |
| `SET_FIRST_PERSON_FLASH_EFFECT_VEHICLE_MODEL_HASH` | `void SET_FIRST_PERSON_FLASH_EFFECT_VEHICLE_MODEL_HASH(uint vehicleModel)` | void |
| `SET_FIRST_PERSON_FLASH_EFFECT_VEHICLE_MODEL_NAME` | `void SET_FIRST_PERSON_FLASH_EFFECT_VEHICLE_MODEL_NAME(string vehicleName)` | void |
| `SET_FIRST_PERSON_SHOOTER_CAMERA_HEADING` | `void SET_FIRST_PERSON_SHOOTER_CAMERA_HEADING(float yaw)` | void |
| `SET_FIRST_PERSON_SHOOTER_CAMERA_PITCH` | `void SET_FIRST_PERSON_SHOOTER_CAMERA_PITCH(float pitch)` | void |
| `SET_FLY_CAM_COORD_AND_CONSTRAIN` | `void SET_FLY_CAM_COORD_AND_CONSTRAIN(int cam, float x, float y, float z)` | void |
| `SET_FLY_CAM_HORIZONTAL_RESPONSE` | `void SET_FLY_CAM_HORIZONTAL_RESPONSE(int cam, float p1, float p2, float p3)` | void |
| `SET_FLY_CAM_MAX_HEIGHT` | `void SET_FLY_CAM_MAX_HEIGHT(int cam, float height)` | void |
| `SET_FLY_CAM_VERTICAL_CONTROLS_THIS_UPDATE` | `void SET_FLY_CAM_VERTICAL_CONTROLS_THIS_UPDATE(int cam)` | void |
| `SET_FLY_CAM_VERTICAL_RESPONSE` | `void SET_FLY_CAM_VERTICAL_RESPONSE(int cam, float p1, float p2, float p3)` | void |
| `SET_FOLLOW_CAM_IGNORE_ATTACH_PARENT_MOVEMENT_THIS_UPDATE` | `void SET_FOLLOW_CAM_IGNORE_ATTACH_PARENT_MOVEMENT_THIS_UPDATE()` | void |
| `SET_FOLLOW_PED_CAM_LADDER_ALIGN_THIS_UPDATE` | `void SET_FOLLOW_PED_CAM_LADDER_ALIGN_THIS_UPDATE()` | void |
| `SET_FOLLOW_PED_CAM_THIS_UPDATE` | `bool SET_FOLLOW_PED_CAM_THIS_UPDATE(string camName, int p1)` | bool |
| `SET_FOLLOW_PED_CAM_VIEW_MODE` | `void SET_FOLLOW_PED_CAM_VIEW_MODE(int viewMode)` | void |
| `SET_FOLLOW_VEHICLE_CAM_HIGH_ANGLE_MODE_EVERY_UPDATE` | `void SET_FOLLOW_VEHICLE_CAM_HIGH_ANGLE_MODE_EVERY_UPDATE(bool p0, bool p1)` | void |
| `SET_FOLLOW_VEHICLE_CAM_HIGH_ANGLE_MODE_THIS_UPDATE` | `void SET_FOLLOW_VEHICLE_CAM_HIGH_ANGLE_MODE_THIS_UPDATE(bool p0)` | void |
| `SET_FOLLOW_VEHICLE_CAM_SEAT_THIS_UPDATE` | `void SET_FOLLOW_VEHICLE_CAM_SEAT_THIS_UPDATE(int seatIndex)` | void |
| `SET_FOLLOW_VEHICLE_CAM_VIEW_MODE` | `void SET_FOLLOW_VEHICLE_CAM_VIEW_MODE(int viewMode)` | void |
| `SET_FOLLOW_VEHICLE_CAM_ZOOM_LEVEL` | `void SET_FOLLOW_VEHICLE_CAM_ZOOM_LEVEL(int zoomLevel)` | void |
| `SET_GAMEPLAY_CAM_ALTITUDE_FOV_SCALING_STATE` | `void SET_GAMEPLAY_CAM_ALTITUDE_FOV_SCALING_STATE(bool p0)` | void |
| `SET_GAMEPLAY_CAM_ENTITY_TO_LIMIT_FOCUS_OVER_BOUNDING_SPHERE_THIS_UPDATE` | `void SET_GAMEPLAY_CAM_ENTITY_TO_LIMIT_FOCUS_OVER_BOUNDING_SPHERE_THIS_UPDATE(int entity)` | void |
| `SET_GAMEPLAY_CAM_FOLLOW_PED_THIS_UPDATE` | `void SET_GAMEPLAY_CAM_FOLLOW_PED_THIS_UPDATE(int ped)` | void |
| `SET_GAMEPLAY_CAM_IGNORE_ENTITY_COLLISION_THIS_UPDATE` | `void SET_GAMEPLAY_CAM_IGNORE_ENTITY_COLLISION_THIS_UPDATE(int entity)` | void |
| `SET_GAMEPLAY_CAM_MAX_MOTION_BLUR_STRENGTH_THIS_UPDATE` | `void SET_GAMEPLAY_CAM_MAX_MOTION_BLUR_STRENGTH_THIS_UPDATE(float p0)` | void |
| `SET_GAMEPLAY_CAM_MOTION_BLUR_SCALING_THIS_UPDATE` | `void SET_GAMEPLAY_CAM_MOTION_BLUR_SCALING_THIS_UPDATE(float p0)` | void |
| `SET_GAMEPLAY_CAM_RELATIVE_HEADING` | `void SET_GAMEPLAY_CAM_RELATIVE_HEADING(float heading)` | void |
| `SET_GAMEPLAY_CAM_RELATIVE_PITCH` | `void SET_GAMEPLAY_CAM_RELATIVE_PITCH(float angle, float scalingFactor)` | void |
| `SET_GAMEPLAY_CAM_SHAKE_AMPLITUDE` | `void SET_GAMEPLAY_CAM_SHAKE_AMPLITUDE(float amplitude)` | void |
| `SET_GAMEPLAY_COORD_HINT` | `void SET_GAMEPLAY_COORD_HINT(float x, float y, float z, int duration, int blendOutDuration, int blendInDuration, int p6)` | void |
| `SET_GAMEPLAY_ENTITY_HINT` | `void SET_GAMEPLAY_ENTITY_HINT(int entity, float xOffset, float yOffset, float zOffset, bool p4, int time, int easeInTime, int easeOutTime, int p8)` | void |
| `SET_GAMEPLAY_HINT_BASE_ORBIT_PITCH_OFFSET` | `void SET_GAMEPLAY_HINT_BASE_ORBIT_PITCH_OFFSET(float value)` | void |
| `SET_GAMEPLAY_HINT_CAMERA_BLEND_TO_FOLLOW_PED_MEDIUM_VIEW_MODE` | `void SET_GAMEPLAY_HINT_CAMERA_BLEND_TO_FOLLOW_PED_MEDIUM_VIEW_MODE(bool toggle)` | void |
| `SET_GAMEPLAY_HINT_CAMERA_RELATIVE_SIDE_OFFSET` | `void SET_GAMEPLAY_HINT_CAMERA_RELATIVE_SIDE_OFFSET(float xOffset)` | void |
| `SET_GAMEPLAY_HINT_CAMERA_RELATIVE_VERTICAL_OFFSET` | `void SET_GAMEPLAY_HINT_CAMERA_RELATIVE_VERTICAL_OFFSET(float yOffset)` | void |
| `SET_GAMEPLAY_HINT_FOLLOW_DISTANCE_SCALAR` | `void SET_GAMEPLAY_HINT_FOLLOW_DISTANCE_SCALAR(float value)` | void |
| `SET_GAMEPLAY_HINT_FOV` | `void SET_GAMEPLAY_HINT_FOV(float FOV)` | void |
| `SET_GAMEPLAY_OBJECT_HINT` | `void SET_GAMEPLAY_OBJECT_HINT(int object, float xOffset, float yOffset, float zOffset, bool p4, int time, int easeInTime, int easeOutTime)` | void |
| `SET_GAMEPLAY_PED_HINT` | `void SET_GAMEPLAY_PED_HINT(int ped, float x1, float y1, float z1, bool p4, int duration, int blendOutDuration, int blendInDuration)` | void |
| `SET_GAMEPLAY_VEHICLE_HINT` | `void SET_GAMEPLAY_VEHICLE_HINT(int vehicle, float offsetX, float offsetY, float offsetZ, bool p4, int time, int easeInTime, int easeOutTime)` | void |
| `SET_IN_VEHICLE_CAM_STATE_THIS_UPDATE` | `void SET_IN_VEHICLE_CAM_STATE_THIS_UPDATE(int p0, int p1)` | void |
| `SET_SCRIPTED_CAMERA_IS_FIRST_PERSON_THIS_FRAME` | `void SET_SCRIPTED_CAMERA_IS_FIRST_PERSON_THIS_FRAME(bool p0)` | void |
| `SET_TABLE_GAMES_CAMERA_THIS_UPDATE` | `bool SET_TABLE_GAMES_CAMERA_THIS_UPDATE(uint hash)` | bool |
| `SET_THIRD_PERSON_AIM_CAM_NEAR_CLIP_THIS_UPDATE` | `void SET_THIRD_PERSON_AIM_CAM_NEAR_CLIP_THIS_UPDATE(float p0)` | void |
| `SET_THIRD_PERSON_CAM_ORBIT_DISTANCE_LIMITS_THIS_UPDATE` | `void SET_THIRD_PERSON_CAM_ORBIT_DISTANCE_LIMITS_THIS_UPDATE(float p0, float distance)` | void |
| `SET_THIRD_PERSON_CAM_RELATIVE_HEADING_LIMITS_THIS_UPDATE` | `void SET_THIRD_PERSON_CAM_RELATIVE_HEADING_LIMITS_THIS_UPDATE(float minimum, float maximum)` | void |
| `SET_THIRD_PERSON_CAM_RELATIVE_PITCH_LIMITS_THIS_UPDATE` | `void SET_THIRD_PERSON_CAM_RELATIVE_PITCH_LIMITS_THIS_UPDATE(float minimum, float maximum)` | void |
| `SET_USE_HI_DOF` | `void SET_USE_HI_DOF()` | void |
| `SET_USE_HI_DOF_ON_SYNCED_SCENE_THIS_UPDATE` | `void SET_USE_HI_DOF_ON_SYNCED_SCENE_THIS_UPDATE()` | void |
| `SET_WIDESCREEN_BORDERS` | `void SET_WIDESCREEN_BORDERS(bool p0, int p1)` | void |
| `SHAKE_CAM` | `void SHAKE_CAM(int cam, string type, float amplitude)` | void |
| `SHAKE_CINEMATIC_CAM` | `void SHAKE_CINEMATIC_CAM(string shakeType, float amount)` | void |
| `SHAKE_GAMEPLAY_CAM` | `void SHAKE_GAMEPLAY_CAM(string shakeName, float intensity)` | void |
| `SHAKE_SCRIPT_GLOBAL` | `void SHAKE_SCRIPT_GLOBAL(string p0, float p1)` | void |
| `STOP_CAM_POINTING` | `void STOP_CAM_POINTING(int cam)` | void |
| `STOP_CAM_SHAKING` | `void STOP_CAM_SHAKING(int cam, bool p1)` | void |
| `STOP_CINEMATIC_CAM_SHAKING` | `void STOP_CINEMATIC_CAM_SHAKING(bool p0)` | void |
| `STOP_CINEMATIC_SHOT` | `void STOP_CINEMATIC_SHOT(uint p0)` | void |
| `STOP_CODE_GAMEPLAY_HINT` | `void STOP_CODE_GAMEPLAY_HINT(bool p0)` | void |
| `STOP_CUTSCENE_CAM_SHAKING` | `void STOP_CUTSCENE_CAM_SHAKING(object p0)` | void |
| `STOP_GAMEPLAY_CAM_SHAKING` | `void STOP_GAMEPLAY_CAM_SHAKING(bool p0)` | void |
| `STOP_GAMEPLAY_HINT` | `void STOP_GAMEPLAY_HINT(bool p0)` | void |
| `STOP_GAMEPLAY_HINT_BEING_CANCELLED_THIS_UPDATE` | `void STOP_GAMEPLAY_HINT_BEING_CANCELLED_THIS_UPDATE(bool p0)` | void |
| `STOP_RENDERING_SCRIPT_CAMS_USING_CATCH_UP` | `void STOP_RENDERING_SCRIPT_CAMS_USING_CATCH_UP(bool render, float p1, int p2, object p3)` | void |
| `STOP_SCRIPT_GLOBAL_SHAKING` | `void STOP_SCRIPT_GLOBAL_SHAKING(bool p0)` | void |
| `TRIGGER_VEHICLE_PART_BROKEN_CAMERA_SHAKE` | `void TRIGGER_VEHICLE_PART_BROKEN_CAMERA_SHAKE(int vehicle, int p1, float p2)` | void |
| `USE_DEDICATED_STUNT_CAMERA_THIS_UPDATE` | `void USE_DEDICATED_STUNT_CAMERA_THIS_UPDATE(string camName)` | void |
| `USE_SCRIPT_CAM_FOR_AMBIENT_POPULATION_ORIGIN_THIS_FRAME` | `void USE_SCRIPT_CAM_FOR_AMBIENT_POPULATION_ORIGIN_THIS_FRAME(bool p0, bool p1)` | void |
| `USE_VEHICLE_CAM_STUNT_SETTINGS_THIS_UPDATE` | `void USE_VEHICLE_CAM_STUNT_SETTINGS_THIS_UPDATE()` | void |
| `WAS_FLY_CAM_CONSTRAINED_ON_PREVIOUS_UDPATE` | `bool WAS_FLY_CAM_CONSTRAINED_ON_PREVIOUS_UDPATE(int cam)` | bool |
| `_ACTIVATE_CAM_WITH_INTERP_AND_FOV_CURVE` | `void _ACTIVATE_CAM_WITH_INTERP_AND_FOV_CURVE(int camTo, int camFrom, int duration, int easeLocation, int easeRotation, int easeFov)` | void |
| `_GET_THIRD_PERSON_CAM_MAX_ORBIT_DISTANCE_SPRING` | `float _GET_THIRD_PERSON_CAM_MAX_ORBIT_DISTANCE_SPRING()` | float |
| `_GET_THIRD_PERSON_CAM_MIN_ORBIT_DISTANCE_SPRING` | `float _GET_THIRD_PERSON_CAM_MIN_ORBIT_DISTANCE_SPRING()` | float |
| `_INTERPOLATE_CAM_WITH_PARAMS` | `void _INTERPOLATE_CAM_WITH_PARAMS(int camera, float camPosX, float camPosY, float camPosZ, float camRotX, float camRotY, float camRotZ, float fov, int duration, int posCurveType, int rotCurveType, int rotOrder, int fovCurveType)` | void |

---

## HUD_UI

| 函数名 | 签名 | 返回值 |
|--------|------|--------|
| `ACTIVATE_FRONTEND_MENU` | `void ACTIVATE_FRONTEND_MENU(uint menuhash, bool togglePause, int component)` | void |
| `ADD_BLIP_FOR_AREA` | `int ADD_BLIP_FOR_AREA(float x, float y, float z, float width, float height)` | int |
| `ADD_BLIP_FOR_COORD` | `int ADD_BLIP_FOR_COORD(float x, float y, float z)` | int |
| `ADD_BLIP_FOR_ENTITY` | `int ADD_BLIP_FOR_ENTITY(int entity)` | int |
| `ADD_BLIP_FOR_PICKUP` | `int ADD_BLIP_FOR_PICKUP(int pickup)` | int |
| `ADD_BLIP_FOR_RADIUS` | `int ADD_BLIP_FOR_RADIUS(float posX, float posY, float posZ, float radius)` | int |
| `ADD_NEXT_MESSAGE_TO_PREVIOUS_BRIEFS` | `void ADD_NEXT_MESSAGE_TO_PREVIOUS_BRIEFS(bool p0)` | void |
| `ADD_POINT_TO_GPS_CUSTOM_ROUTE` | `void ADD_POINT_TO_GPS_CUSTOM_ROUTE(float x, float y, float z)` | void |
| `ADD_POINT_TO_GPS_MULTI_ROUTE` | `void ADD_POINT_TO_GPS_MULTI_ROUTE(float x, float y, float z)` | void |
| `ADD_TEXT_COMPONENT_FLOAT` | `void ADD_TEXT_COMPONENT_FLOAT(float value, int decimalPlaces)` | void |
| `ADD_TEXT_COMPONENT_FORMATTED_INTEGER` | `void ADD_TEXT_COMPONENT_FORMATTED_INTEGER(int value, bool commaSeparated)` | void |
| `ADD_TEXT_COMPONENT_INTEGER` | `void ADD_TEXT_COMPONENT_INTEGER(int value)` | void |
| `ADD_TEXT_COMPONENT_SUBSTRING_BLIP_NAME` | `void ADD_TEXT_COMPONENT_SUBSTRING_BLIP_NAME(int blip)` | void |
| `ADD_TEXT_COMPONENT_SUBSTRING_KEYBOARD_DISPLAY` | `void ADD_TEXT_COMPONENT_SUBSTRING_KEYBOARD_DISPLAY(string string)` | void |
| `ADD_TEXT_COMPONENT_SUBSTRING_PHONE_NUMBER` | `void ADD_TEXT_COMPONENT_SUBSTRING_PHONE_NUMBER(string p0, int p1)` | void |
| `ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME` | `void ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME(string text)` | void |
| `ADD_TEXT_COMPONENT_SUBSTRING_TEXT_LABEL` | `void ADD_TEXT_COMPONENT_SUBSTRING_TEXT_LABEL(string labelName)` | void |
| `ADD_TEXT_COMPONENT_SUBSTRING_TEXT_LABEL_HASH_KEY` | `void ADD_TEXT_COMPONENT_SUBSTRING_TEXT_LABEL_HASH_KEY(uint gxtEntryHash)` | void |
| `ADD_TEXT_COMPONENT_SUBSTRING_TIME` | `void ADD_TEXT_COMPONENT_SUBSTRING_TIME(int timestamp, int flags)` | void |
| `ADD_TEXT_COMPONENT_SUBSTRING_WEBSITE` | `void ADD_TEXT_COMPONENT_SUBSTRING_WEBSITE(string website)` | void |
| `ADD_VALID_VEHICLE_HIT_HASH` | `void ADD_VALID_VEHICLE_HIT_HASH(object p0)` | void |
| `ALLOW_DISPLAY_OF_MULTIPLAYER_CASH_TEXT` | `void ALLOW_DISPLAY_OF_MULTIPLAYER_CASH_TEXT(bool allow)` | void |
| `ALLOW_PAUSE_WHEN_NOT_IN_STATE_OF_PLAY_THIS_FRAME` | `void ALLOW_PAUSE_WHEN_NOT_IN_STATE_OF_PLAY_THIS_FRAME()` | void |
| `ALLOW_SONAR_BLIPS` | `void ALLOW_SONAR_BLIPS(bool toggle)` | void |
| `ARE_ONLINE_POLICIES_UP_TO_DATE` | `bool ARE_ONLINE_POLICIES_UP_TO_DATE()` | bool |
| `BEGIN_TEXT_COMMAND_ADD_DIRECTLY_TO_PREVIOUS_BRIEFS` | `void BEGIN_TEXT_COMMAND_ADD_DIRECTLY_TO_PREVIOUS_BRIEFS(string p0)` | void |
| `BEGIN_TEXT_COMMAND_BUSYSPINNER_ON` | `void BEGIN_TEXT_COMMAND_BUSYSPINNER_ON(string string)` | void |
| `BEGIN_TEXT_COMMAND_CLEAR_PRINT` | `void BEGIN_TEXT_COMMAND_CLEAR_PRINT(string text)` | void |
| `BEGIN_TEXT_COMMAND_DISPLAY_HELP` | `void BEGIN_TEXT_COMMAND_DISPLAY_HELP(string inputType)` | void |
| `BEGIN_TEXT_COMMAND_DISPLAY_TEXT` | `void BEGIN_TEXT_COMMAND_DISPLAY_TEXT(string text)` | void |
| `BEGIN_TEXT_COMMAND_GET_NUMBER_OF_LINES_FOR_STRING` | `void BEGIN_TEXT_COMMAND_GET_NUMBER_OF_LINES_FOR_STRING(string entry)` | void |
| `BEGIN_TEXT_COMMAND_GET_SCREEN_WIDTH_OF_DISPLAY_TEXT` | `void BEGIN_TEXT_COMMAND_GET_SCREEN_WIDTH_OF_DISPLAY_TEXT(string text)` | void |
| `BEGIN_TEXT_COMMAND_IS_MESSAGE_DISPLAYED` | `void BEGIN_TEXT_COMMAND_IS_MESSAGE_DISPLAYED(string text)` | void |
| `BEGIN_TEXT_COMMAND_IS_THIS_HELP_MESSAGE_BEING_DISPLAYED` | `void BEGIN_TEXT_COMMAND_IS_THIS_HELP_MESSAGE_BEING_DISPLAYED(string labelName)` | void |
| `BEGIN_TEXT_COMMAND_OVERRIDE_BUTTON_TEXT` | `void BEGIN_TEXT_COMMAND_OVERRIDE_BUTTON_TEXT(string gxtEntry)` | void |
| `BEGIN_TEXT_COMMAND_PRINT` | `void BEGIN_TEXT_COMMAND_PRINT(string GxtEntry)` | void |
| `BEGIN_TEXT_COMMAND_SET_BLIP_NAME` | `void BEGIN_TEXT_COMMAND_SET_BLIP_NAME(string textLabel)` | void |
| `BEGIN_TEXT_COMMAND_THEFEED_POST` | `void BEGIN_TEXT_COMMAND_THEFEED_POST(string text)` | void |
| `BUSYSPINNER_IS_DISPLAYING` | `bool BUSYSPINNER_IS_DISPLAYING()` | bool |
| `BUSYSPINNER_IS_ON` | `bool BUSYSPINNER_IS_ON()` | bool |
| `BUSYSPINNER_OFF` | `void BUSYSPINNER_OFF()` | void |
| `CAN_PHONE_BE_SEEN_ON_SCREEN` | `bool CAN_PHONE_BE_SEEN_ON_SCREEN()` | bool |
| `CELL_CAM_ACTIVATE` | `void CELL_CAM_ACTIVATE(bool p0, bool p1)` | void |
| `CELL_CAM_ACTIVATE_SELFIE_MODE` | `void CELL_CAM_ACTIVATE_SELFIE_MODE(bool toggle)` | void |
| `CELL_CAM_ACTIVATE_SHALLOW_DOF_MODE` | `void CELL_CAM_ACTIVATE_SHALLOW_DOF_MODE(bool toggle)` | void |
| `CELL_CAM_IS_CHAR_VISIBLE_NO_FACE_CHECK` | `bool CELL_CAM_IS_CHAR_VISIBLE_NO_FACE_CHECK(int entity)` | bool |
| `CELL_CAM_SET_SELFIE_MODE_DISTANCE_SCALING` | `void CELL_CAM_SET_SELFIE_MODE_DISTANCE_SCALING(float distanceScaling)` | void |
| `CELL_CAM_SET_SELFIE_MODE_HEAD_PITCH_OFFSET` | `void CELL_CAM_SET_SELFIE_MODE_HEAD_PITCH_OFFSET(float pitch)` | void |
| `CELL_CAM_SET_SELFIE_MODE_HEAD_ROLL_OFFSET` | `void CELL_CAM_SET_SELFIE_MODE_HEAD_ROLL_OFFSET(float roll)` | void |
| `CELL_CAM_SET_SELFIE_MODE_HEAD_YAW_OFFSET` | `void CELL_CAM_SET_SELFIE_MODE_HEAD_YAW_OFFSET(float yaw)` | void |
| `CELL_CAM_SET_SELFIE_MODE_HORZ_PAN_OFFSET` | `void CELL_CAM_SET_SELFIE_MODE_HORZ_PAN_OFFSET(float horizontalPan)` | void |
| `CELL_CAM_SET_SELFIE_MODE_ROLL_OFFSET` | `void CELL_CAM_SET_SELFIE_MODE_ROLL_OFFSET(float roll)` | void |
| `CELL_CAM_SET_SELFIE_MODE_SIDE_OFFSET_SCALING` | `void CELL_CAM_SET_SELFIE_MODE_SIDE_OFFSET_SCALING(float p0)` | void |
| `CELL_CAM_SET_SELFIE_MODE_VERT_PAN_OFFSET` | `void CELL_CAM_SET_SELFIE_MODE_VERT_PAN_OFFSET(float vertPan)` | void |
| `CELL_HORIZONTAL_MODE_TOGGLE` | `void CELL_HORIZONTAL_MODE_TOGGLE(bool toggle)` | void |
| `CELL_SET_INPUT` | `void CELL_SET_INPUT(int direction)` | void |
| `CHANGE_FAKE_MP_CASH` | `void CHANGE_FAKE_MP_CASH(int cash, int bank)` | void |
| `CLEAR_ADDITIONAL_TEXT` | `void CLEAR_ADDITIONAL_TEXT(int p0, bool p1)` | void |
| `CLEAR_ALL_BLIP_ROUTES` | `void CLEAR_ALL_BLIP_ROUTES()` | void |
| `CLEAR_ALL_HELP_MESSAGES` | `void CLEAR_ALL_HELP_MESSAGES()` | void |
| `CLEAR_BRIEF` | `void CLEAR_BRIEF()` | void |
| `CLEAR_DYNAMIC_PAUSE_MENU_ERROR_MESSAGE` | `void CLEAR_DYNAMIC_PAUSE_MENU_ERROR_MESSAGE()` | void |
| `CLEAR_FAKE_CONE_ARRAY` | `void CLEAR_FAKE_CONE_ARRAY()` | void |
| `CLEAR_FLOATING_HELP` | `void CLEAR_FLOATING_HELP(int hudIndex, bool p1)` | void |
| `CLEAR_GPS_CUSTOM_ROUTE` | `void CLEAR_GPS_CUSTOM_ROUTE()` | void |
| `CLEAR_GPS_FLAGS` | `void CLEAR_GPS_FLAGS()` | void |
| `CLEAR_GPS_MULTI_ROUTE` | `void CLEAR_GPS_MULTI_ROUTE()` | void |
| `CLEAR_GPS_PLAYER_WAYPOINT` | `void CLEAR_GPS_PLAYER_WAYPOINT()` | void |
| `CLEAR_GPS_RACE_TRACK` | `void CLEAR_GPS_RACE_TRACK()` | void |
| `CLEAR_HELP` | `void CLEAR_HELP(bool toggle)` | void |
| `CLEAR_PED_IN_PAUSE_MENU` | `void CLEAR_PED_IN_PAUSE_MENU()` | void |
| `CLEAR_PRINTS` | `void CLEAR_PRINTS()` | void |
| `CLEAR_REMINDER_MESSAGE` | `void CLEAR_REMINDER_MESSAGE()` | void |
| `CLEAR_SMALL_PRINTS` | `void CLEAR_SMALL_PRINTS()` | void |
| `CLEAR_THIS_PRINT` | `void CLEAR_THIS_PRINT(string p0)` | void |
| `CLEAR_VALID_VEHICLE_HIT_HASHES` | `void CLEAR_VALID_VEHICLE_HIT_HASHES()` | void |
| `CLOSE_MP_TEXT_CHAT` | `void CLOSE_MP_TEXT_CHAT()` | void |
| `CLOSE_SOCIAL_CLUB_MENU` | `void CLOSE_SOCIAL_CLUB_MENU()` | void |
| `CODE_WANTS_SCRIPT_TO_TAKE_CONTROL` | `bool CODE_WANTS_SCRIPT_TO_TAKE_CONTROL()` | bool |
| `CREATE_FAKE_MP_GAMER_TAG` | `int CREATE_FAKE_MP_GAMER_TAG(int ped, string username, bool pointedClanTag, bool isRockstarClan, string clanTag, int clanFlag)` | int |
| `CREATE_MOBILE_PHONE` | `void CREATE_MOBILE_PHONE(int phoneType)` | void |
| `CREATE_MP_GAMER_TAG_WITH_CREW_COLOR` | `void CREATE_MP_GAMER_TAG_WITH_CREW_COLOR(int player, string username, bool pointedClanTag, bool isRockstarClan, string clanTag, int clanFlag, int r, int g, int b)` | void |
| `CUSTOM_MINIMAP_CLEAR_BLIPS` | `void CUSTOM_MINIMAP_CLEAR_BLIPS()` | void |
| `CUSTOM_MINIMAP_CREATE_BLIP` | `int CUSTOM_MINIMAP_CREATE_BLIP(float x, float y, float z)` | int |
| `CUSTOM_MINIMAP_SET_ACTIVE` | `void CUSTOM_MINIMAP_SET_ACTIVE(bool toggle)` | void |
| `CUSTOM_MINIMAP_SET_BLIP_OBJECT` | `void CUSTOM_MINIMAP_SET_BLIP_OBJECT(int spriteId)` | void |
| `DELETE_WAYPOINTS_FROM_THIS_PLAYER` | `void DELETE_WAYPOINTS_FROM_THIS_PLAYER()` | void |
| `DESTROY_MOBILE_PHONE` | `void DESTROY_MOBILE_PHONE()` | void |
| `DISABLE_FRONTEND_THIS_FRAME` | `void DISABLE_FRONTEND_THIS_FRAME()` | void |
| `DISABLE_PAUSEMENU_SPINNER` | `void DISABLE_PAUSEMENU_SPINNER(bool p0)` | void |
| `DISPLAY_AMMO_THIS_FRAME` | `void DISPLAY_AMMO_THIS_FRAME(bool display)` | void |
| `DISPLAY_AREA_NAME` | `void DISPLAY_AREA_NAME(bool toggle)` | void |
| `DISPLAY_CASH` | `void DISPLAY_CASH(bool toggle)` | void |
| `DISPLAY_HELP_TEXT_THIS_FRAME` | `void DISPLAY_HELP_TEXT_THIS_FRAME(string message, bool p1)` | void |
| `DISPLAY_HUD` | `void DISPLAY_HUD(bool toggle)` | void |
| `DISPLAY_HUD_WHEN_NOT_IN_STATE_OF_PLAY_THIS_FRAME` | `void DISPLAY_HUD_WHEN_NOT_IN_STATE_OF_PLAY_THIS_FRAME()` | void |
| `DISPLAY_HUD_WHEN_PAUSED_THIS_FRAME` | `void DISPLAY_HUD_WHEN_PAUSED_THIS_FRAME()` | void |
| `DISPLAY_PLAYER_NAME_TAGS_ON_BLIPS` | `void DISPLAY_PLAYER_NAME_TAGS_ON_BLIPS(bool toggle)` | void |
| `DISPLAY_RADAR` | `void DISPLAY_RADAR(bool toggle)` | void |
| `DISPLAY_SNIPER_SCOPE_THIS_FRAME` | `void DISPLAY_SNIPER_SCOPE_THIS_FRAME()` | void |
| `DOES_BLIP_EXIST` | `bool DOES_BLIP_EXIST(int blip)` | bool |
| `DOES_BLIP_HAVE_GPS_ROUTE` | `bool DOES_BLIP_HAVE_GPS_ROUTE(int blip)` | bool |
| `DOES_PED_HAVE_AI_BLIP` | `bool DOES_PED_HAVE_AI_BLIP(int ped)` | bool |
| `DOES_TEXT_BLOCK_EXIST` | `bool DOES_TEXT_BLOCK_EXIST(string gxt)` | bool |
| `DOES_TEXT_LABEL_EXIST` | `bool DOES_TEXT_LABEL_EXIST(string gxt)` | bool |
| `DONT_TILT_MINIMAP_THIS_FRAME` | `void DONT_TILT_MINIMAP_THIS_FRAME()` | void |
| `DONT_ZOOM_MINIMAP_WHEN_RUNNING_THIS_FRAME` | `void DONT_ZOOM_MINIMAP_WHEN_RUNNING_THIS_FRAME()` | void |
| `DONT_ZOOM_MINIMAP_WHEN_SNIPING_THIS_FRAME` | `void DONT_ZOOM_MINIMAP_WHEN_SNIPING_THIS_FRAME()` | void |
| `DRAW_FRONTEND_BACKGROUND_THIS_FRAME` | `void DRAW_FRONTEND_BACKGROUND_THIS_FRAME()` | void |
| `DRAW_HUD_OVER_FADE_THIS_FRAME` | `void DRAW_HUD_OVER_FADE_THIS_FRAME()` | void |
| `END_TEXT_COMMAND_ADD_DIRECTLY_TO_PREVIOUS_BRIEFS` | `void END_TEXT_COMMAND_ADD_DIRECTLY_TO_PREVIOUS_BRIEFS(bool p0)` | void |
| `END_TEXT_COMMAND_BUSYSPINNER_ON` | `void END_TEXT_COMMAND_BUSYSPINNER_ON(int busySpinnerType)` | void |
| `END_TEXT_COMMAND_CLEAR_PRINT` | `void END_TEXT_COMMAND_CLEAR_PRINT()` | void |
| `END_TEXT_COMMAND_DISPLAY_HELP` | `void END_TEXT_COMMAND_DISPLAY_HELP(int p0, bool loop, bool beep, int shape)` | void |
| `END_TEXT_COMMAND_DISPLAY_TEXT` | `void END_TEXT_COMMAND_DISPLAY_TEXT(float x, float y, int p2)` | void |
| `END_TEXT_COMMAND_GET_NUMBER_OF_LINES_FOR_STRING` | `int END_TEXT_COMMAND_GET_NUMBER_OF_LINES_FOR_STRING(float x, float y)` | int |
| `END_TEXT_COMMAND_GET_SCREEN_WIDTH_OF_DISPLAY_TEXT` | `float END_TEXT_COMMAND_GET_SCREEN_WIDTH_OF_DISPLAY_TEXT(bool p0)` | float |
| `END_TEXT_COMMAND_IS_MESSAGE_DISPLAYED` | `bool END_TEXT_COMMAND_IS_MESSAGE_DISPLAYED()` | bool |
| `END_TEXT_COMMAND_IS_THIS_HELP_MESSAGE_BEING_DISPLAYED` | `bool END_TEXT_COMMAND_IS_THIS_HELP_MESSAGE_BEING_DISPLAYED(int p0)` | bool |
| `END_TEXT_COMMAND_OVERRIDE_BUTTON_TEXT` | `void END_TEXT_COMMAND_OVERRIDE_BUTTON_TEXT(int p0)` | void |
| `END_TEXT_COMMAND_PRINT` | `void END_TEXT_COMMAND_PRINT(int duration, bool drawImmediately)` | void |
| `END_TEXT_COMMAND_SET_BLIP_NAME` | `void END_TEXT_COMMAND_SET_BLIP_NAME(int blip)` | void |
| `END_TEXT_COMMAND_THEFEED_POST_AWARD` | `int END_TEXT_COMMAND_THEFEED_POST_AWARD(string textureDict, string textureName, int rpBonus, int colorOverlay, string titleLabel)` | int |
| `END_TEXT_COMMAND_THEFEED_POST_CREWTAG` | `int END_TEXT_COMMAND_THEFEED_POST_CREWTAG(bool p0, bool p1, ref int p2, int p3, bool isLeader, bool unk0, int clanDesc, int R, int G, int B)` | int |
| `END_TEXT_COMMAND_THEFEED_POST_CREWTAG_WITH_GAME_NAME` | `int END_TEXT_COMMAND_THEFEED_POST_CREWTAG_WITH_GAME_NAME(bool p0, bool p1, ref int p2, int p3, bool isLeader, bool unk0, int clanDesc, string playerName, int R, int G, int B)` | int |
| `END_TEXT_COMMAND_THEFEED_POST_CREW_RANKUP_WITH_LITERAL_FLAG` | `int END_TEXT_COMMAND_THEFEED_POST_CREW_RANKUP_WITH_LITERAL_FLAG(string p0, string p1, string p2, bool p3, bool p4)` | int |
| `END_TEXT_COMMAND_THEFEED_POST_MESSAGETEXT` | `int END_TEXT_COMMAND_THEFEED_POST_MESSAGETEXT(string txdName, string textureName, bool flash, int iconType, string sender, string subject)` | int |
| `END_TEXT_COMMAND_THEFEED_POST_MESSAGETEXT_SUBTITLE_LABEL` | `int END_TEXT_COMMAND_THEFEED_POST_MESSAGETEXT_SUBTITLE_LABEL(string txdName, string textureName, bool flash, int iconType, string sender, string subject)` | int |
| `END_TEXT_COMMAND_THEFEED_POST_MESSAGETEXT_TU` | `int END_TEXT_COMMAND_THEFEED_POST_MESSAGETEXT_TU(string txdName, string textureName, bool flash, int iconType, string sender, string subject, float duration)` | int |
| `END_TEXT_COMMAND_THEFEED_POST_MESSAGETEXT_WITH_CREW_TAG` | `int END_TEXT_COMMAND_THEFEED_POST_MESSAGETEXT_WITH_CREW_TAG(string txdName, string textureName, bool flash, int iconType, string sender, string subject, float duration, string clanTag)` | int |
| `END_TEXT_COMMAND_THEFEED_POST_MESSAGETEXT_WITH_CREW_TAG_AND_ADDITIONAL_ICON` | `int END_TEXT_COMMAND_THEFEED_POST_MESSAGETEXT_WITH_CREW_TAG_AND_ADDITIONAL_ICON(string txdName, string textureName, bool flash, int iconType1, string sender, string subject, float duration, string clanTag, int iconType2, int p9)` | int |
| `END_TEXT_COMMAND_THEFEED_POST_MPTICKER` | `int END_TEXT_COMMAND_THEFEED_POST_MPTICKER(bool blink, bool p1)` | int |
| `END_TEXT_COMMAND_THEFEED_POST_REPLAY` | `int END_TEXT_COMMAND_THEFEED_POST_REPLAY(int type, int image, string text)` | int |
| `END_TEXT_COMMAND_THEFEED_POST_REPLAY_INPUT` | `int END_TEXT_COMMAND_THEFEED_POST_REPLAY_INPUT(int type, string button, string text)` | int |
| `END_TEXT_COMMAND_THEFEED_POST_STATS` | `int END_TEXT_COMMAND_THEFEED_POST_STATS(string statTitle, int iconEnum, bool stepVal, int barValue, bool isImportant, string pictureTextureDict, string pictureTextureName)` | int |
| `END_TEXT_COMMAND_THEFEED_POST_TICKER` | `int END_TEXT_COMMAND_THEFEED_POST_TICKER(bool blink, bool p1)` | int |
| `END_TEXT_COMMAND_THEFEED_POST_TICKER_FORCED` | `int END_TEXT_COMMAND_THEFEED_POST_TICKER_FORCED(bool blink, bool p1)` | int |
| `END_TEXT_COMMAND_THEFEED_POST_TICKER_WITH_TOKENS` | `int END_TEXT_COMMAND_THEFEED_POST_TICKER_WITH_TOKENS(bool blink, bool p1)` | int |
| `END_TEXT_COMMAND_THEFEED_POST_UNLOCK` | `int END_TEXT_COMMAND_THEFEED_POST_UNLOCK(string gxtLabel1, int p1, string gxtLabel2)` | int |
| `END_TEXT_COMMAND_THEFEED_POST_UNLOCK_TU` | `int END_TEXT_COMMAND_THEFEED_POST_UNLOCK_TU(string gxtLabel1, int p1, string gxtLabel2, int p3)` | int |
| `END_TEXT_COMMAND_THEFEED_POST_UNLOCK_TU_WITH_COLOR` | `int END_TEXT_COMMAND_THEFEED_POST_UNLOCK_TU_WITH_COLOR(object p0, object p1, object p2, object p3, object p4, object p5)` | int |
| `END_TEXT_COMMAND_THEFEED_POST_VERSUS_TU` | `int END_TEXT_COMMAND_THEFEED_POST_VERSUS_TU(string txdName1, string textureName1, int count1, string txdName2, string textureName2, int count2, int hudColor1, int hudColor2)` | int |
| `FLAG_PLAYER_CONTEXT_IN_TOURNAMENT` | `void FLAG_PLAYER_CONTEXT_IN_TOURNAMENT(bool toggle)` | void |
| `FLASH_ABILITY_BAR` | `void FLASH_ABILITY_BAR(int millisecondsToFlash)` | void |
| `FLASH_MINIMAP_DISPLAY` | `void FLASH_MINIMAP_DISPLAY()` | void |
| `FLASH_MINIMAP_DISPLAY_WITH_COLOR` | `void FLASH_MINIMAP_DISPLAY_WITH_COLOR(int hudColorIndex)` | void |
| `FLASH_WANTED_DISPLAY` | `void FLASH_WANTED_DISPLAY(bool p0)` | void |
| `FORCE_CLOSE_REPORTUGC_MENU` | `void FORCE_CLOSE_REPORTUGC_MENU()` | void |
| `FORCE_CLOSE_TEXT_INPUT_BOX` | `void FORCE_CLOSE_TEXT_INPUT_BOX()` | void |
| `FORCE_NEXT_MESSAGE_TO_PREVIOUS_BRIEFS_LIST` | `void FORCE_NEXT_MESSAGE_TO_PREVIOUS_BRIEFS_LIST(int p0)` | void |
| `FORCE_OFF_WANTED_STAR_FLASH` | `void FORCE_OFF_WANTED_STAR_FLASH(bool toggle)` | void |
| `FORCE_SCRIPTED_GFX_WHEN_FRONTEND_ACTIVE` | `void FORCE_SCRIPTED_GFX_WHEN_FRONTEND_ACTIVE(string p0)` | void |
| `FORCE_SONAR_BLIPS_THIS_FRAME` | `bool FORCE_SONAR_BLIPS_THIS_FRAME()` | bool |
| `GET_AI_PED_PED_BLIP_INDEX` | `int GET_AI_PED_PED_BLIP_INDEX(int ped)` | int |
| `GET_AI_PED_VEHICLE_BLIP_INDEX` | `int GET_AI_PED_VEHICLE_BLIP_INDEX(int ped)` | int |
| `GET_BLIP_ALPHA` | `int GET_BLIP_ALPHA(int blip)` | int |
| `GET_BLIP_COLOUR` | `int GET_BLIP_COLOUR(int blip)` | int |
| `GET_BLIP_COORDS` | `Vector3 GET_BLIP_COORDS(int blip)` | Vector3 |
| `GET_BLIP_FADE_DIRECTION` | `int GET_BLIP_FADE_DIRECTION(int blip)` | int |
| `GET_BLIP_FROM_ENTITY` | `int GET_BLIP_FROM_ENTITY(int entity)` | int |
| `GET_BLIP_HUD_COLOUR` | `int GET_BLIP_HUD_COLOUR(int blip)` | int |
| `GET_BLIP_INFO_ID_COORD` | `Vector3 GET_BLIP_INFO_ID_COORD(int blip)` | Vector3 |
| `GET_BLIP_INFO_ID_DISPLAY` | `int GET_BLIP_INFO_ID_DISPLAY(int blip)` | int |
| `GET_BLIP_INFO_ID_ENTITY_INDEX` | `int GET_BLIP_INFO_ID_ENTITY_INDEX(int blip)` | int |
| `GET_BLIP_INFO_ID_PICKUP_INDEX` | `int GET_BLIP_INFO_ID_PICKUP_INDEX(int blip)` | int |
| `GET_BLIP_INFO_ID_TYPE` | `int GET_BLIP_INFO_ID_TYPE(int blip)` | int |
| `GET_BLIP_ROTATION` | `int GET_BLIP_ROTATION(int blip)` | int |
| `GET_BLIP_SPRITE` | `int GET_BLIP_SPRITE(int blip)` | int |
| `GET_CHARACTER_FROM_AUDIO_CONVERSATION_FILENAME` | `string GET_CHARACTER_FROM_AUDIO_CONVERSATION_FILENAME(string text, int position, int length)` | string |
| `GET_CHARACTER_FROM_AUDIO_CONVERSATION_FILENAME_BYTES` | `string GET_CHARACTER_FROM_AUDIO_CONVERSATION_FILENAME_BYTES(string text, int startPosition, int endPosition)` | string |
| `GET_CHARACTER_FROM_AUDIO_CONVERSATION_FILENAME_WITH_BYTE_LIMIT` | `string GET_CHARACTER_FROM_AUDIO_CONVERSATION_FILENAME_WITH_BYTE_LIMIT(string text, int position, int length, int maxLength)` | string |
| `GET_CHARACTER_MENU_PED_FLOAT_STAT` | `bool GET_CHARACTER_MENU_PED_FLOAT_STAT(float statHash, ref float outValue, bool p2)` | bool |
| `GET_CHARACTER_MENU_PED_INT_STAT` | `bool GET_CHARACTER_MENU_PED_INT_STAT(object p0, ref object p1, object p2)` | bool |
| `GET_CHARACTER_MENU_PED_MASKED_INT_STAT` | `bool GET_CHARACTER_MENU_PED_MASKED_INT_STAT(uint statHash, ref object outValue, int p2, int mask, bool p4)` | bool |
| `GET_CLOSEST_BLIP_INFO_ID` | `int GET_CLOSEST_BLIP_INFO_ID(int blipSprite)` | int |
| `GET_CURRENT_FRONTEND_MENU_VERSION` | `uint GET_CURRENT_FRONTEND_MENU_VERSION()` | uint |
| `GET_CURRENT_WEBPAGE_ID` | `int GET_CURRENT_WEBPAGE_ID()` | int |
| `GET_CURRENT_WEBSITE_ID` | `int GET_CURRENT_WEBSITE_ID()` | int |
| `GET_DEFAULT_SCRIPT_RENDERTARGET_RENDER_ID` | `int GET_DEFAULT_SCRIPT_RENDERTARGET_RENDER_ID()` | int |
| `GET_FAKE_SPECTATOR_MODE` | `bool GET_FAKE_SPECTATOR_MODE()` | bool |
| `GET_FILENAME_FOR_AUDIO_CONVERSATION` | `string GET_FILENAME_FOR_AUDIO_CONVERSATION(string labelName)` | string |
| `GET_FIRST_BLIP_INFO_ID` | `int GET_FIRST_BLIP_INFO_ID(int blipSprite)` | int |
| `GET_FIRST_N_CHARACTERS_OF_LITERAL_STRING` | `string GET_FIRST_N_CHARACTERS_OF_LITERAL_STRING(string string, int length)` | string |
| `GET_GLOBAL_ACTIONSCRIPT_FLAG` | `int GET_GLOBAL_ACTIONSCRIPT_FLAG(int flagIndex)` | int |
| `GET_HUD_COLOUR` | `void GET_HUD_COLOUR(int hudColorIndex, ref int r, ref int g, ref int b, ref int a)` | void |
| `GET_HUD_COMPONENT_POSITION` | `Vector3 GET_HUD_COMPONENT_POSITION(int id)` | Vector3 |
| `GET_HUD_SCREEN_POSITION_FROM_WORLD_POSITION` | `int GET_HUD_SCREEN_POSITION_FROM_WORLD_POSITION(float worldX, float worldY, float worldZ, ref float screenX, ref float screenY)` | int |
| `GET_LENGTH_OF_LITERAL_STRING` | `int GET_LENGTH_OF_LITERAL_STRING(string string)` | int |
| `GET_LENGTH_OF_LITERAL_STRING_IN_BYTES` | `int GET_LENGTH_OF_LITERAL_STRING_IN_BYTES(string string)` | int |
| `GET_LENGTH_OF_STRING_WITH_THIS_TEXT_LABEL` | `int GET_LENGTH_OF_STRING_WITH_THIS_TEXT_LABEL(string gxt)` | int |
| `GET_MAIN_PLAYER_BLIP_ID` | `int GET_MAIN_PLAYER_BLIP_ID()` | int |
| `GET_MENU_LAYOUT_CHANGED_EVENT_DETAILS` | `void GET_MENU_LAYOUT_CHANGED_EVENT_DETAILS(ref int lastItemMenuId, ref int selectedItemMenuId, ref int selectedItemUniqueId)` | void |
| `GET_MENU_PED_BOOL_STAT` | `bool GET_MENU_PED_BOOL_STAT(uint statHash, ref bool outValue)` | bool |
| `GET_MENU_PED_FLOAT_STAT` | `bool GET_MENU_PED_FLOAT_STAT(uint statHash, ref float outValue)` | bool |
| `GET_MENU_PED_INT_STAT` | `bool GET_MENU_PED_INT_STAT(object p0, ref object p1)` | bool |
| `GET_MENU_PED_MASKED_INT_STAT` | `bool GET_MENU_PED_MASKED_INT_STAT(uint statHash, ref int outValue, int mask, bool p3)` | bool |
| `GET_MENU_TRIGGER_EVENT_DETAILS` | `void GET_MENU_TRIGGER_EVENT_DETAILS(ref int lastItemMenuId, ref int selectedItemUniqueId)` | void |
| `GET_MINIMAP_FOW_COORDINATE_IS_REVEALED` | `bool GET_MINIMAP_FOW_COORDINATE_IS_REVEALED(float x, float y, float z)` | bool |
| `GET_MINIMAP_FOW_DISCOVERY_RATIO` | `float GET_MINIMAP_FOW_DISCOVERY_RATIO()` | float |
| `GET_MOBILE_PHONE_POSITION` | `void GET_MOBILE_PHONE_POSITION(ref Vector3 position)` | void |
| `GET_MOBILE_PHONE_RENDER_ID` | `void GET_MOBILE_PHONE_RENDER_ID(ref int renderId)` | void |
| `GET_MOBILE_PHONE_ROTATION` | `void GET_MOBILE_PHONE_ROTATION(ref Vector3 rotation, int p1)` | void |
| `GET_MOUSE_EVENT` | `bool GET_MOUSE_EVENT(int scaleformHandle, ref object p1, ref object p2, ref object p3)` | bool |
| `GET_NAMED_RENDERTARGET_RENDER_ID` | `int GET_NAMED_RENDERTARGET_RENDER_ID(string name)` | int |
| `GET_NEW_SELECTED_MISSION_CREATOR_BLIP` | `int GET_NEW_SELECTED_MISSION_CREATOR_BLIP()` | int |
| `GET_NEXT_BLIP_INFO_ID` | `int GET_NEXT_BLIP_INFO_ID(int blipSprite)` | int |
| `GET_NORTH_BLID_INDEX` | `int GET_NORTH_BLID_INDEX()` | int |
| `GET_NUMBER_OF_ACTIVE_BLIPS` | `int GET_NUMBER_OF_ACTIVE_BLIPS()` | int |
| `GET_PAUSE_MENU_POSITION` | `Vector3 GET_PAUSE_MENU_POSITION()` | Vector3 |
| `GET_PAUSE_MENU_STATE` | `int GET_PAUSE_MENU_STATE()` | int |
| `GET_PM_PLAYER_CREW_COLOR` | `bool GET_PM_PLAYER_CREW_COLOR(ref int r, ref int g, ref int b)` | bool |
| `GET_RENDERED_CHARACTER_HEIGHT` | `float GET_RENDERED_CHARACTER_HEIGHT(float size, int font)` | float |
| `GET_SCREEN_CODE_WANTS_SCRIPT_TO_CONTROL` | `int GET_SCREEN_CODE_WANTS_SCRIPT_TO_CONTROL()` | int |
| `GET_STANDARD_BLIP_ENUM_ID` | `int GET_STANDARD_BLIP_ENUM_ID()` | int |
| `GET_STREET_NAME_FROM_HASH_KEY` | `string GET_STREET_NAME_FROM_HASH_KEY(uint hash)` | string |
| `GET_WARNING_SCREEN_MESSAGE_HASH` | `uint GET_WARNING_SCREEN_MESSAGE_HASH()` | uint |
| `GET_WAYPOINT_BLIP_ENUM_ID` | `int GET_WAYPOINT_BLIP_ENUM_ID()` | int |
| `GET_WAYPOINT_CLEAR_ON_ARRIVAL_MODE` | `int GET_WAYPOINT_CLEAR_ON_ARRIVAL_MODE()` | int |
| `GIVE_PED_TO_PAUSE_MENU` | `void GIVE_PED_TO_PAUSE_MENU(int ped, int p1)` | void |
| `HAS_ADDITIONAL_TEXT_LOADED` | `bool HAS_ADDITIONAL_TEXT_LOADED(int slot)` | bool |
| `HAS_DIRECTOR_MODE_BEEN_LAUNCHED_BY_CODE` | `bool HAS_DIRECTOR_MODE_BEEN_LAUNCHED_BY_CODE()` | bool |
| `HAS_MENU_LAYOUT_CHANGED_EVENT_OCCURRED` | `bool HAS_MENU_LAYOUT_CHANGED_EVENT_OCCURRED()` | bool |
| `HAS_MENU_TRIGGER_EVENT_OCCURRED` | `bool HAS_MENU_TRIGGER_EVENT_OCCURRED()` | bool |
| `HAS_SCRIPT_HIDDEN_HELP_THIS_FRAME` | `bool HAS_SCRIPT_HIDDEN_HELP_THIS_FRAME()` | bool |
| `HAS_THIS_ADDITIONAL_TEXT_LOADED` | `bool HAS_THIS_ADDITIONAL_TEXT_LOADED(string gxt, int slot)` | bool |
| `HIDE_HELP_TEXT_THIS_FRAME` | `void HIDE_HELP_TEXT_THIS_FRAME()` | void |
| `HIDE_HUDMARKERS_THIS_FRAME` | `void HIDE_HUDMARKERS_THIS_FRAME()` | void |
| `HIDE_HUD_AND_RADAR_THIS_FRAME` | `void HIDE_HUD_AND_RADAR_THIS_FRAME()` | void |
| `HIDE_HUD_COMPONENT_THIS_FRAME` | `void HIDE_HUD_COMPONENT_THIS_FRAME(int id)` | void |
| `HIDE_LOADING_ON_FADE_THIS_FRAME` | `void HIDE_LOADING_ON_FADE_THIS_FRAME()` | void |
| `HIDE_MINIMAP_EXTERIOR_MAP_THIS_FRAME` | `void HIDE_MINIMAP_EXTERIOR_MAP_THIS_FRAME()` | void |
| `HIDE_MINIMAP_INTERIOR_MAP_THIS_FRAME` | `void HIDE_MINIMAP_INTERIOR_MAP_THIS_FRAME()` | void |
| `HIDE_NUMBER_ON_BLIP` | `void HIDE_NUMBER_ON_BLIP(int blip)` | void |
| `HIDE_SCRIPTED_HUD_COMPONENT_THIS_FRAME` | `void HIDE_SCRIPTED_HUD_COMPONENT_THIS_FRAME(int id)` | void |
| `HIDE_STREET_AND_CAR_NAMES_THIS_FRAME` | `void HIDE_STREET_AND_CAR_NAMES_THIS_FRAME()` | void |
| `HUD_FORCE_SPECIAL_VEHICLE_WEAPON_WHEEL` | `void HUD_FORCE_SPECIAL_VEHICLE_WEAPON_WHEEL()` | void |
| `HUD_FORCE_WEAPON_WHEEL` | `void HUD_FORCE_WEAPON_WHEEL(bool show)` | void |
| `HUD_GET_WEAPON_WHEEL_CURRENTLY_HIGHLIGHTED` | `uint HUD_GET_WEAPON_WHEEL_CURRENTLY_HIGHLIGHTED()` | uint |
| `HUD_GET_WEAPON_WHEEL_TOP_SLOT` | `uint HUD_GET_WEAPON_WHEEL_TOP_SLOT(int weaponTypeIndex)` | uint |
| `HUD_SET_WEAPON_WHEEL_TOP_SLOT` | `void HUD_SET_WEAPON_WHEEL_TOP_SLOT(uint weaponHash)` | void |
| `HUD_SHOWING_CHARACTER_SWITCH_SELECTION` | `void HUD_SHOWING_CHARACTER_SWITCH_SELECTION(bool toggle)` | void |
| `HUD_SUPPRESS_WEAPON_WHEEL_RESULTS_THIS_FRAME` | `void HUD_SUPPRESS_WEAPON_WHEEL_RESULTS_THIS_FRAME()` | void |
| `IS_BLIP_FLASHING` | `bool IS_BLIP_FLASHING(int blip)` | bool |
| `IS_BLIP_ON_MINIMAP` | `bool IS_BLIP_ON_MINIMAP(int blip)` | bool |
| `IS_BLIP_SHORT_RANGE` | `bool IS_BLIP_SHORT_RANGE(int blip)` | bool |
| `IS_FLOATING_HELP_TEXT_ON_SCREEN` | `bool IS_FLOATING_HELP_TEXT_ON_SCREEN(int hudIndex)` | bool |
| `IS_FRONTEND_READY_FOR_CONTROL` | `bool IS_FRONTEND_READY_FOR_CONTROL()` | bool |
| `IS_HELP_MESSAGE_BEING_DISPLAYED` | `bool IS_HELP_MESSAGE_BEING_DISPLAYED()` | bool |
| `IS_HELP_MESSAGE_FADING_OUT` | `bool IS_HELP_MESSAGE_FADING_OUT()` | bool |
| `IS_HELP_MESSAGE_ON_SCREEN` | `bool IS_HELP_MESSAGE_ON_SCREEN()` | bool |
| `IS_HOVERING_OVER_MISSION_CREATOR_BLIP` | `bool IS_HOVERING_OVER_MISSION_CREATOR_BLIP()` | bool |
| `IS_HUD_COMPONENT_ACTIVE` | `bool IS_HUD_COMPONENT_ACTIVE(int id)` | bool |
| `IS_HUD_COMPONENT_HIDDEN_THIS_FRAME` | `bool IS_HUD_COMPONENT_HIDDEN_THIS_FRAME(int id)` | bool |
| `IS_HUD_HIDDEN` | `bool IS_HUD_HIDDEN()` | bool |
| `IS_HUD_PREFERENCE_SWITCHED_ON` | `bool IS_HUD_PREFERENCE_SWITCHED_ON()` | bool |
| `IS_IME_IN_PROGRESS` | `bool IS_IME_IN_PROGRESS()` | bool |
| `IS_MESSAGE_BEING_DISPLAYED` | `bool IS_MESSAGE_BEING_DISPLAYED()` | bool |
| `IS_MINIMAP_RENDERING` | `bool IS_MINIMAP_RENDERING()` | bool |
| `IS_MISSION_CREATOR_BLIP` | `bool IS_MISSION_CREATOR_BLIP(int blip)` | bool |
| `IS_MOUSE_ROLLED_OVER_INSTRUCTIONAL_BUTTONS` | `bool IS_MOUSE_ROLLED_OVER_INSTRUCTIONAL_BUTTONS()` | bool |
| `IS_MP_GAMER_TAG_ACTIVE` | `bool IS_MP_GAMER_TAG_ACTIVE(int gamerTagId)` | bool |
| `IS_MP_GAMER_TAG_FREE` | `bool IS_MP_GAMER_TAG_FREE(int gamerTagId)` | bool |
| `IS_MP_GAMER_TAG_MOVIE_ACTIVE` | `bool IS_MP_GAMER_TAG_MOVIE_ACTIVE()` | bool |
| `IS_MP_TEXT_CHAT_TYPING` | `bool IS_MP_TEXT_CHAT_TYPING()` | bool |
| `IS_NAMED_RENDERTARGET_LINKED` | `bool IS_NAMED_RENDERTARGET_LINKED(uint modelHash)` | bool |
| `IS_NAMED_RENDERTARGET_REGISTERED` | `bool IS_NAMED_RENDERTARGET_REGISTERED(string name)` | bool |
| `IS_NAVIGATING_MENU_CONTENT` | `bool IS_NAVIGATING_MENU_CONTENT()` | bool |
| `IS_ONLINE_POLICIES_MENU_ACTIVE` | `bool IS_ONLINE_POLICIES_MENU_ACTIVE()` | bool |
| `IS_PAUSEMAP_IN_INTERIOR_MODE` | `bool IS_PAUSEMAP_IN_INTERIOR_MODE()` | bool |
| `IS_PAUSE_MENU_ACTIVE` | `bool IS_PAUSE_MENU_ACTIVE()` | bool |
| `IS_PAUSE_MENU_RESTARTING` | `bool IS_PAUSE_MENU_RESTARTING()` | bool |
| `IS_RADAR_HIDDEN` | `bool IS_RADAR_HIDDEN()` | bool |
| `IS_RADAR_PREFERENCE_SWITCHED_ON` | `bool IS_RADAR_PREFERENCE_SWITCHED_ON()` | bool |
| `IS_REPORTUGC_MENU_OPEN` | `bool IS_REPORTUGC_MENU_OPEN()` | bool |
| `IS_SCRIPTED_HUD_COMPONENT_ACTIVE` | `bool IS_SCRIPTED_HUD_COMPONENT_ACTIVE(int id)` | bool |
| `IS_SCRIPTED_HUD_COMPONENT_HIDDEN_THIS_FRAME` | `bool IS_SCRIPTED_HUD_COMPONENT_HIDDEN_THIS_FRAME(int id)` | bool |
| `IS_SOCIAL_CLUB_ACTIVE` | `bool IS_SOCIAL_CLUB_ACTIVE()` | bool |
| `IS_STORE_PENDING_NETWORK_SHUTDOWN_TO_OPEN` | `bool IS_STORE_PENDING_NETWORK_SHUTDOWN_TO_OPEN()` | bool |
| `IS_STREAMING_ADDITIONAL_TEXT` | `bool IS_STREAMING_ADDITIONAL_TEXT(int p0)` | bool |
| `IS_SUBTITLE_PREFERENCE_SWITCHED_ON` | `bool IS_SUBTITLE_PREFERENCE_SWITCHED_ON()` | bool |
| `IS_UPDATING_MP_GAMER_TAG_NAME_AND_CREW_DETAILS` | `bool IS_UPDATING_MP_GAMER_TAG_NAME_AND_CREW_DETAILS(int gamerTagId)` | bool |
| `IS_WARNING_MESSAGE_ACTIVE` | `bool IS_WARNING_MESSAGE_ACTIVE()` | bool |
| `IS_WARNING_MESSAGE_READY_FOR_CONTROL` | `bool IS_WARNING_MESSAGE_READY_FOR_CONTROL()` | bool |
| `IS_WAYPOINT_ACTIVE` | `bool IS_WAYPOINT_ACTIVE()` | bool |
| `LINK_NAMED_RENDERTARGET` | `void LINK_NAMED_RENDERTARGET(uint modelHash)` | void |
| `LOCK_MINIMAP_ANGLE` | `void LOCK_MINIMAP_ANGLE(int angle)` | void |
| `LOCK_MINIMAP_POSITION` | `void LOCK_MINIMAP_POSITION(float x, float y)` | void |
| `MP_TEXT_CHAT_DISABLE` | `void MP_TEXT_CHAT_DISABLE(bool toggle)` | void |
| `MP_TEXT_CHAT_IS_TEAM_JOB` | `void MP_TEXT_CHAT_IS_TEAM_JOB(object p0)` | void |
| `OPEN_ONLINE_POLICIES_MENU` | `void OPEN_ONLINE_POLICIES_MENU()` | void |
| `OPEN_REPORTUGC_MENU` | `void OPEN_REPORTUGC_MENU()` | void |
| `OPEN_SOCIAL_CLUB_MENU` | `void OPEN_SOCIAL_CLUB_MENU(uint menu)` | void |
| `OVERRIDE_MP_TEXT_CHAT_COLOR` | `void OVERRIDE_MP_TEXT_CHAT_COLOR(int p0, int hudColor)` | void |
| `OVERRIDE_MP_TEXT_CHAT_TEAM_STRING` | `void OVERRIDE_MP_TEXT_CHAT_TEAM_STRING(uint gxtEntryHash)` | void |
| `PAUSE_MENUCEPTION_GO_DEEPER` | `void PAUSE_MENUCEPTION_GO_DEEPER(int page)` | void |
| `PAUSE_MENUCEPTION_THE_KICK` | `void PAUSE_MENUCEPTION_THE_KICK()` | void |
| `PAUSE_MENU_ACTIVATE_CONTEXT` | `void PAUSE_MENU_ACTIVATE_CONTEXT(uint contextHash)` | void |
| `PAUSE_MENU_DEACTIVATE_CONTEXT` | `void PAUSE_MENU_DEACTIVATE_CONTEXT(uint contextHash)` | void |
| `PAUSE_MENU_GET_HAIR_COLOUR_INDEX` | `int PAUSE_MENU_GET_HAIR_COLOUR_INDEX()` | int |
| `PAUSE_MENU_GET_MOUSE_CLICK_EVENT` | `bool PAUSE_MENU_GET_MOUSE_CLICK_EVENT(ref object p0, ref object p1, ref object p2)` | bool |
| `PAUSE_MENU_GET_MOUSE_HOVER_INDEX` | `int PAUSE_MENU_GET_MOUSE_HOVER_INDEX()` | int |
| `PAUSE_MENU_GET_MOUSE_HOVER_UNIQUE_ID` | `int PAUSE_MENU_GET_MOUSE_HOVER_UNIQUE_ID()` | int |
| `PAUSE_MENU_IS_CONTEXT_ACTIVE` | `bool PAUSE_MENU_IS_CONTEXT_ACTIVE(uint contextHash)` | bool |
| `PAUSE_MENU_IS_CONTEXT_MENU_ACTIVE` | `bool PAUSE_MENU_IS_CONTEXT_MENU_ACTIVE()` | bool |
| `PAUSE_MENU_REDRAW_INSTRUCTIONAL_BUTTONS` | `void PAUSE_MENU_REDRAW_INSTRUCTIONAL_BUTTONS(int p0)` | void |
| `PAUSE_MENU_SET_BUSY_SPINNER` | `void PAUSE_MENU_SET_BUSY_SPINNER(bool p0, int position, int spinnerIndex)` | void |
| `PAUSE_MENU_SET_WARN_ON_TAB_CHANGE` | `void PAUSE_MENU_SET_WARN_ON_TAB_CHANGE(bool p0)` | void |
| `PAUSE_TOGGLE_FULLSCREEN_MAP` | `void PAUSE_TOGGLE_FULLSCREEN_MAP(object p0)` | void |
| `PRELOAD_BUSYSPINNER` | `void PRELOAD_BUSYSPINNER()` | void |
| `PULSE_BLIP` | `void PULSE_BLIP(int blip)` | void |
| `REFRESH_WAYPOINT` | `void REFRESH_WAYPOINT()` | void |
| `REGISTER_NAMED_RENDERTARGET` | `bool REGISTER_NAMED_RENDERTARGET(string name, bool p1)` | bool |
| `RELEASE_CONTROL_OF_FRONTEND` | `void RELEASE_CONTROL_OF_FRONTEND()` | void |
| `RELEASE_NAMED_RENDERTARGET` | `bool RELEASE_NAMED_RENDERTARGET(string name)` | bool |
| `RELOAD_MAP_MENU` | `void RELOAD_MAP_MENU()` | void |
| `REMOVE_BLIP` | `void REMOVE_BLIP(Blip* blip)` | void |
| `REMOVE_COP_BLIP_FROM_PED` | `void REMOVE_COP_BLIP_FROM_PED(int ped)` | void |
| `REMOVE_FAKE_CONE_DATA` | `void REMOVE_FAKE_CONE_DATA(int blip)` | void |
| `REMOVE_MP_GAMER_TAG` | `void REMOVE_MP_GAMER_TAG(int gamerTagId)` | void |
| `REMOVE_MULTIPLAYER_BANK_CASH` | `void REMOVE_MULTIPLAYER_BANK_CASH()` | void |
| `REMOVE_MULTIPLAYER_HUD_CASH` | `void REMOVE_MULTIPLAYER_HUD_CASH()` | void |
| `REMOVE_MULTIPLAYER_WALLET_CASH` | `void REMOVE_MULTIPLAYER_WALLET_CASH()` | void |
| `REMOVE_WARNING_MESSAGE_OPTION_ITEMS` | `void REMOVE_WARNING_MESSAGE_OPTION_ITEMS()` | void |
| `REPLACE_HUD_COLOUR` | `void REPLACE_HUD_COLOUR(int hudColorIndex, int hudColorIndex2)` | void |
| `REPLACE_HUD_COLOUR_WITH_RGBA` | `void REPLACE_HUD_COLOUR_WITH_RGBA(int hudColorIndex, int r, int g, int b, int a)` | void |
| `REQUEST_ADDITIONAL_TEXT` | `void REQUEST_ADDITIONAL_TEXT(string gxt, int slot)` | void |
| `REQUEST_ADDITIONAL_TEXT_FOR_DLC` | `void REQUEST_ADDITIONAL_TEXT_FOR_DLC(string gxt, int slot)` | void |
| `RESET_GLOBAL_ACTIONSCRIPT_FLAG` | `void RESET_GLOBAL_ACTIONSCRIPT_FLAG(int flagIndex)` | void |
| `RESET_HUD_COMPONENT_VALUES` | `void RESET_HUD_COMPONENT_VALUES(int id)` | void |
| `RESET_RETICULE_VALUES` | `void RESET_RETICULE_VALUES()` | void |
| `RESTART_FRONTEND_MENU` | `void RESTART_FRONTEND_MENU(uint menuHash, int p1)` | void |
| `SCRIPT_IS_MOVING_MOBILE_PHONE_OFFSCREEN` | `void SCRIPT_IS_MOVING_MOBILE_PHONE_OFFSCREEN(bool toggle)` | void |
| `SETUP_FAKE_CONE_DATA` | `void SETUP_FAKE_CONE_DATA(int blip, float p1, float p2, float p3, float p4, float p5, float p6, object p7, int p8)` | void |
| `SET_ABILITY_BAR_VALUE` | `void SET_ABILITY_BAR_VALUE(float p0, float p1)` | void |
| `SET_ABILITY_BAR_VISIBILITY` | `void SET_ABILITY_BAR_VISIBILITY(bool visible)` | void |
| `SET_ALLOW_ABILITY_BAR` | `void SET_ALLOW_ABILITY_BAR(bool toggle)` | void |
| `SET_ALLOW_COMMA_ON_TEXT_INPUT` | `void SET_ALLOW_COMMA_ON_TEXT_INPUT(object p0)` | void |
| `SET_ALL_MP_GAMER_TAGS_VISIBILITY` | `void SET_ALL_MP_GAMER_TAGS_VISIBILITY(int gamerTagId, bool toggle)` | void |
| `SET_BIGMAP_ACTIVE` | `void SET_BIGMAP_ACTIVE(bool toggleBigMap, bool showFullMap)` | void |
| `SET_BLIP_ALPHA` | `void SET_BLIP_ALPHA(int blip, int alpha)` | void |
| `SET_BLIP_AS_FRIENDLY` | `void SET_BLIP_AS_FRIENDLY(int blip, bool toggle)` | void |
| `SET_BLIP_AS_MINIMAL_ON_EDGE` | `void SET_BLIP_AS_MINIMAL_ON_EDGE(int blip, bool toggle)` | void |
| `SET_BLIP_AS_MISSION_CREATOR_BLIP` | `void SET_BLIP_AS_MISSION_CREATOR_BLIP(int blip, bool toggle)` | void |
| `SET_BLIP_AS_SHORT_RANGE` | `void SET_BLIP_AS_SHORT_RANGE(int blip, bool toggle)` | void |
| `SET_BLIP_BRIGHT` | `void SET_BLIP_BRIGHT(int blip, bool toggle)` | void |
| `SET_BLIP_CATEGORY` | `void SET_BLIP_CATEGORY(int blip, int index)` | void |
| `SET_BLIP_COLOUR` | `void SET_BLIP_COLOUR(int blip, int color)` | void |
| `SET_BLIP_COORDS` | `void SET_BLIP_COORDS(int blip, float posX, float posY, float posZ)` | void |
| `SET_BLIP_DISPLAY` | `void SET_BLIP_DISPLAY(int blip, int displayId)` | void |
| `SET_BLIP_EXTENDED_HEIGHT_THRESHOLD` | `void SET_BLIP_EXTENDED_HEIGHT_THRESHOLD(int blip, bool toggle)` | void |
| `SET_BLIP_FADE` | `void SET_BLIP_FADE(int blip, int opacity, int duration)` | void |
| `SET_BLIP_FLASHES` | `void SET_BLIP_FLASHES(int blip, bool toggle)` | void |
| `SET_BLIP_FLASHES_ALTERNATE` | `void SET_BLIP_FLASHES_ALTERNATE(int blip, bool toggle)` | void |
| `SET_BLIP_FLASH_INTERVAL` | `void SET_BLIP_FLASH_INTERVAL(int blip, object p1)` | void |
| `SET_BLIP_FLASH_TIMER` | `void SET_BLIP_FLASH_TIMER(int blip, int duration)` | void |
| `SET_BLIP_HIDDEN_ON_LEGEND` | `void SET_BLIP_HIDDEN_ON_LEGEND(int blip, bool toggle)` | void |
| `SET_BLIP_HIGH_DETAIL` | `void SET_BLIP_HIGH_DETAIL(int blip, bool toggle)` | void |
| `SET_BLIP_MARKER_LONG_DISTANCE` | `void SET_BLIP_MARKER_LONG_DISTANCE(object p0, object p1)` | void |
| `SET_BLIP_NAME_FROM_TEXT_FILE` | `void SET_BLIP_NAME_FROM_TEXT_FILE(int blip, string gxtEntry)` | void |
| `SET_BLIP_NAME_TO_PLAYER_NAME` | `void SET_BLIP_NAME_TO_PLAYER_NAME(int blip, int player)` | void |
| `SET_BLIP_PRIORITY` | `void SET_BLIP_PRIORITY(int blip, int priority)` | void |
| `SET_BLIP_ROTATION` | `void SET_BLIP_ROTATION(int blip, int rotation)` | void |
| `SET_BLIP_ROTATION_WITH_FLOAT` | `void SET_BLIP_ROTATION_WITH_FLOAT(int blip, float heading)` | void |
| `SET_BLIP_ROUTE` | `void SET_BLIP_ROUTE(int blip, bool enabled)` | void |
| `SET_BLIP_ROUTE_COLOUR` | `void SET_BLIP_ROUTE_COLOUR(int blip, int colour)` | void |
| `SET_BLIP_SCALE` | `void SET_BLIP_SCALE(int blip, float scale)` | void |
| `SET_BLIP_SCALE_2D` | `void SET_BLIP_SCALE_2D(int blip, float xScale, float yScale)` | void |
| `SET_BLIP_SECONDARY_COLOUR` | `void SET_BLIP_SECONDARY_COLOUR(int blip, int r, int g, int b)` | void |
| `SET_BLIP_SHORT_HEIGHT_THRESHOLD` | `void SET_BLIP_SHORT_HEIGHT_THRESHOLD(object p0, object p1)` | void |
| `SET_BLIP_SHOW_CONE` | `void SET_BLIP_SHOW_CONE(int blip, bool toggle, int hudColorIndex)` | void |
| `SET_BLIP_SPRITE` | `void SET_BLIP_SPRITE(int blip, int spriteId)` | void |
| `SET_BLIP_USE_HEIGHT_INDICATOR_ON_EDGE` | `void SET_BLIP_USE_HEIGHT_INDICATOR_ON_EDGE(int blip, object p1)` | void |
| `SET_BLOCK_WANTED_FLASH` | `void SET_BLOCK_WANTED_FLASH(bool disabled)` | void |
| `SET_COLOUR_OF_NEXT_TEXT_COMPONENT` | `void SET_COLOUR_OF_NEXT_TEXT_COMPONENT(int hudColor)` | void |
| `SET_COP_BLIP_SPRITE` | `void SET_COP_BLIP_SPRITE(int p0, float p1)` | void |
| `SET_COP_BLIP_SPRITE_AS_STANDARD` | `void SET_COP_BLIP_SPRITE_AS_STANDARD()` | void |
| `SET_CUSTOM_MP_HUD_COLOR` | `void SET_CUSTOM_MP_HUD_COLOR(int hudColorId)` | void |
| `SET_DESCRIPTION_FOR_UGC_MISSION_EIGHT_STRINGS` | `void SET_DESCRIPTION_FOR_UGC_MISSION_EIGHT_STRINGS(bool p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8)` | void |
| `SET_DIRECTOR_MODE_AVAILABLE` | `void SET_DIRECTOR_MODE_AVAILABLE(bool toggle)` | void |
| `SET_DIRECTOR_MODE_LAUNCHED_BY_SCRIPT` | `void SET_DIRECTOR_MODE_LAUNCHED_BY_SCRIPT()` | void |
| `SET_FAKE_GPS_PLAYER_POSITION_THIS_FRAME` | `void SET_FAKE_GPS_PLAYER_POSITION_THIS_FRAME(float x, float y, float z)` | void |
| `SET_FAKE_MINIMAP_MAX_ALTIMETER_HEIGHT` | `void SET_FAKE_MINIMAP_MAX_ALTIMETER_HEIGHT(float altitude, bool p1, object p2)` | void |
| `SET_FAKE_PAUSEMAP_PLAYER_POSITION_THIS_FRAME` | `void SET_FAKE_PAUSEMAP_PLAYER_POSITION_THIS_FRAME(float x, float y)` | void |
| `SET_FAKE_SPECTATOR_MODE` | `void SET_FAKE_SPECTATOR_MODE(bool toggle)` | void |
| `SET_FLOATING_HELP_TEXT_SCREEN_POSITION` | `void SET_FLOATING_HELP_TEXT_SCREEN_POSITION(int hudIndex, float x, float y)` | void |
| `SET_FLOATING_HELP_TEXT_STYLE` | `void SET_FLOATING_HELP_TEXT_STYLE(int hudIndex, int p1, int p2, int p3, int p4, int p5)` | void |
| `SET_FLOATING_HELP_TEXT_TO_ENTITY` | `void SET_FLOATING_HELP_TEXT_TO_ENTITY(int hudIndex, int entity, float offsetX, float offsetY)` | void |
| `SET_FLOATING_HELP_TEXT_WORLD_POSITION` | `void SET_FLOATING_HELP_TEXT_WORLD_POSITION(int hudIndex, float x, float y, float z)` | void |
| `SET_FORCE_SHOW_GPS` | `void SET_FORCE_SHOW_GPS(bool toggle)` | void |
| `SET_FRONTEND_ACTIVE` | `void SET_FRONTEND_ACTIVE(bool active)` | void |
| `SET_GPS_CUSTOM_ROUTE_RENDER` | `void SET_GPS_CUSTOM_ROUTE_RENDER(bool toggle, int radarThickness, int mapThickness)` | void |
| `SET_GPS_FLAGS` | `void SET_GPS_FLAGS(int p0, float p1)` | void |
| `SET_GPS_FLASHES` | `void SET_GPS_FLASHES(bool toggle)` | void |
| `SET_GPS_MULTI_ROUTE_RENDER` | `void SET_GPS_MULTI_ROUTE_RENDER(bool toggle)` | void |
| `SET_HEALTH_HUD_DISPLAY_VALUES` | `void SET_HEALTH_HUD_DISPLAY_VALUES(int health, int capacity, bool wasAdded)` | void |
| `SET_HELP_MESSAGE_STYLE` | `void SET_HELP_MESSAGE_STYLE(int style, int hudColor, int alpha, int p3, int p4)` | void |
| `SET_HUD_COMPONENT_POSITION` | `void SET_HUD_COMPONENT_POSITION(int id, float x, float y)` | void |
| `SET_INSIDE_VERY_LARGE_INTERIOR` | `void SET_INSIDE_VERY_LARGE_INTERIOR(bool toggle)` | void |
| `SET_INSIDE_VERY_SMALL_INTERIOR` | `void SET_INSIDE_VERY_SMALL_INTERIOR(bool toggle)` | void |
| `SET_MAX_ARMOUR_HUD_DISPLAY` | `void SET_MAX_ARMOUR_HUD_DISPLAY(int maximumValue)` | void |
| `SET_MAX_HEALTH_HUD_DISPLAY` | `void SET_MAX_HEALTH_HUD_DISPLAY(int maximumValue)` | void |
| `SET_MINIMAP_BACKGROUND_HIDDEN` | `void SET_MINIMAP_BACKGROUND_HIDDEN(bool toggle)` | void |
| `SET_MINIMAP_BLOCK_WAYPOINT` | `void SET_MINIMAP_BLOCK_WAYPOINT(bool toggle)` | void |
| `SET_MINIMAP_COMPONENT` | `bool SET_MINIMAP_COMPONENT(int componentId, bool toggle, int overrideColor)` | bool |
| `SET_MINIMAP_FOW_DO_NOT_UPDATE` | `void SET_MINIMAP_FOW_DO_NOT_UPDATE(bool p0)` | void |
| `SET_MINIMAP_FOW_REVEAL_COORDINATE` | `void SET_MINIMAP_FOW_REVEAL_COORDINATE(float x, float y, float z)` | void |
| `SET_MINIMAP_GOLF_COURSE` | `void SET_MINIMAP_GOLF_COURSE(int hole)` | void |
| `SET_MINIMAP_GOLF_COURSE_OFF` | `void SET_MINIMAP_GOLF_COURSE_OFF()` | void |
| `SET_MINIMAP_HIDE_FOW` | `void SET_MINIMAP_HIDE_FOW(bool toggle)` | void |
| `SET_MINIMAP_IN_PROLOGUE` | `void SET_MINIMAP_IN_PROLOGUE(bool toggle)` | void |
| `SET_MINIMAP_IN_SPECTATOR_MODE` | `void SET_MINIMAP_IN_SPECTATOR_MODE(bool toggle, int ped)` | void |
| `SET_MINIMAP_SONAR_SWEEP` | `void SET_MINIMAP_SONAR_SWEEP(bool toggle)` | void |
| `SET_MISSION_NAME` | `void SET_MISSION_NAME(bool p0, string name)` | void |
| `SET_MISSION_NAME_FOR_UGC_MISSION` | `void SET_MISSION_NAME_FOR_UGC_MISSION(bool p0, string name)` | void |
| `SET_MOBILE_PHONE_DOF_STATE` | `void SET_MOBILE_PHONE_DOF_STATE(bool toggle)` | void |
| `SET_MOBILE_PHONE_POSITION` | `void SET_MOBILE_PHONE_POSITION(float posX, float posY, float posZ)` | void |
| `SET_MOBILE_PHONE_ROTATION` | `void SET_MOBILE_PHONE_ROTATION(float rotX, float rotY, float rotZ, object p3)` | void |
| `SET_MOBILE_PHONE_SCALE` | `void SET_MOBILE_PHONE_SCALE(float scale)` | void |
| `SET_MOUSE_CURSOR_STYLE` | `void SET_MOUSE_CURSOR_STYLE(int spriteId)` | void |
| `SET_MOUSE_CURSOR_THIS_FRAME` | `void SET_MOUSE_CURSOR_THIS_FRAME()` | void |
| `SET_MOUSE_CURSOR_VISIBLE` | `void SET_MOUSE_CURSOR_VISIBLE(bool toggle)` | void |
| `SET_MP_GAMER_TAGS_POINT_HEALTH` | `void SET_MP_GAMER_TAGS_POINT_HEALTH(int gamerTagId, int value, int maximumValue)` | void |
| `SET_MP_GAMER_TAGS_SHOULD_USE_POINTS_HEALTH` | `void SET_MP_GAMER_TAGS_SHOULD_USE_POINTS_HEALTH(int gamerTagId, bool toggle)` | void |
| `SET_MP_GAMER_TAGS_SHOULD_USE_VEHICLE_HEALTH` | `void SET_MP_GAMER_TAGS_SHOULD_USE_VEHICLE_HEALTH(int gamerTagId, bool toggle)` | void |
| `SET_MP_GAMER_TAG_ALPHA` | `void SET_MP_GAMER_TAG_ALPHA(int gamerTagId, int component, int alpha)` | void |
| `SET_MP_GAMER_TAG_BIG_TEXT` | `void SET_MP_GAMER_TAG_BIG_TEXT(int gamerTagId, string string)` | void |
| `SET_MP_GAMER_TAG_COLOUR` | `void SET_MP_GAMER_TAG_COLOUR(int gamerTagId, int component, int hudColorIndex)` | void |
| `SET_MP_GAMER_TAG_HEALTH_BAR_COLOUR` | `void SET_MP_GAMER_TAG_HEALTH_BAR_COLOUR(int gamerTagId, int hudColorIndex)` | void |
| `SET_MP_GAMER_TAG_NAME` | `void SET_MP_GAMER_TAG_NAME(int gamerTagId, string string)` | void |
| `SET_MP_GAMER_TAG_NUM_PACKAGES` | `void SET_MP_GAMER_TAG_NUM_PACKAGES(int gamerTagId, int p1)` | void |
| `SET_MP_GAMER_TAG_VISIBILITY` | `void SET_MP_GAMER_TAG_VISIBILITY(int gamerTagId, int component, bool toggle, object p3)` | void |
| `SET_MP_GAMER_TAG_WANTED_LEVEL` | `void SET_MP_GAMER_TAG_WANTED_LEVEL(int gamerTagId, int wantedlvl)` | void |
| `SET_MULTIPLAYER_BANK_CASH` | `void SET_MULTIPLAYER_BANK_CASH()` | void |
| `SET_MULTIPLAYER_HUD_CASH` | `void SET_MULTIPLAYER_HUD_CASH(int p0, bool p1)` | void |
| `SET_MULTIPLAYER_WALLET_CASH` | `void SET_MULTIPLAYER_WALLET_CASH()` | void |
| `SET_NEW_WAYPOINT` | `void SET_NEW_WAYPOINT(float x, float y)` | void |
| `SET_PAUSE_MENU_ACTIVE` | `void SET_PAUSE_MENU_ACTIVE(bool toggle)` | void |
| `SET_PAUSE_MENU_PED_LIGHTING` | `void SET_PAUSE_MENU_PED_LIGHTING(bool state)` | void |
| `SET_PAUSE_MENU_PED_SLEEP_STATE` | `void SET_PAUSE_MENU_PED_SLEEP_STATE(bool state)` | void |
| `SET_PED_AI_BLIP_FORCED_ON` | `void SET_PED_AI_BLIP_FORCED_ON(int ped, bool toggle)` | void |
| `SET_PED_AI_BLIP_GANG_ID` | `void SET_PED_AI_BLIP_GANG_ID(int ped, int gangId)` | void |
| `SET_PED_AI_BLIP_HAS_CONE` | `void SET_PED_AI_BLIP_HAS_CONE(int ped, bool toggle)` | void |
| `SET_PED_AI_BLIP_NOTICE_RANGE` | `void SET_PED_AI_BLIP_NOTICE_RANGE(int ped, float range)` | void |
| `SET_PED_AI_BLIP_SPRITE` | `void SET_PED_AI_BLIP_SPRITE(int ped, int spriteId)` | void |
| `SET_PED_HAS_AI_BLIP` | `void SET_PED_HAS_AI_BLIP(int ped, bool hasCone)` | void |
| `SET_PED_HAS_AI_BLIP_WITH_COLOUR` | `void SET_PED_HAS_AI_BLIP_WITH_COLOUR(int ped, bool hasCone, int color)` | void |
| `SET_PLAYER_ICON_COLOUR` | `void SET_PLAYER_ICON_COLOUR(int color)` | void |
| `SET_PLAYER_IS_IN_DIRECTOR_MODE` | `void SET_PLAYER_IS_IN_DIRECTOR_MODE(bool toggle)` | void |
| `SET_PM_WARNINGSCREEN_ACTIVE` | `void SET_PM_WARNINGSCREEN_ACTIVE(bool p0)` | void |
| `SET_RACE_TRACK_RENDER` | `void SET_RACE_TRACK_RENDER(bool toggle)` | void |
| `SET_RADAR_AS_EXTERIOR_THIS_FRAME` | `void SET_RADAR_AS_EXTERIOR_THIS_FRAME()` | void |
| `SET_RADAR_AS_INTERIOR_THIS_FRAME` | `void SET_RADAR_AS_INTERIOR_THIS_FRAME(uint interior, float x, float y, int z, int zoom)` | void |
| `SET_RADAR_ZOOM` | `void SET_RADAR_ZOOM(int zoomLevel)` | void |
| `SET_RADAR_ZOOM_PRECISE` | `void SET_RADAR_ZOOM_PRECISE(float zoom)` | void |
| `SET_RADAR_ZOOM_TO_BLIP` | `void SET_RADAR_ZOOM_TO_BLIP(int blip, float zoom)` | void |
| `SET_RADAR_ZOOM_TO_DISTANCE` | `void SET_RADAR_ZOOM_TO_DISTANCE(float zoom)` | void |
| `SET_RADIUS_BLIP_EDGE` | `void SET_RADIUS_BLIP_EDGE(int blip, bool toggle)` | void |
| `SET_SAVEGAME_LIST_UNIQUE_ID` | `void SET_SAVEGAME_LIST_UNIQUE_ID(object p0)` | void |
| `SET_SCRIPT_VARIABLE_HUD_COLOUR` | `void SET_SCRIPT_VARIABLE_HUD_COLOUR(int r, int g, int b, int a)` | void |
| `SET_SECOND_SCRIPT_VARIABLE_HUD_COLOUR` | `void SET_SECOND_SCRIPT_VARIABLE_HUD_COLOUR(int r, int g, int b, int a)` | void |
| `SET_SOCIAL_CLUB_TOUR` | `void SET_SOCIAL_CLUB_TOUR(string name)` | void |
| `SET_TEXT_CENTRE` | `void SET_TEXT_CENTRE(bool align)` | void |
| `SET_TEXT_COLOUR` | `void SET_TEXT_COLOUR(int red, int green, int blue, int alpha)` | void |
| `SET_TEXT_DROPSHADOW` | `void SET_TEXT_DROPSHADOW(int distance, int r, int g, int b, int a)` | void |
| `SET_TEXT_DROP_SHADOW` | `void SET_TEXT_DROP_SHADOW()` | void |
| `SET_TEXT_EDGE` | `void SET_TEXT_EDGE(int p0, int r, int g, int b, int a)` | void |
| `SET_TEXT_FONT` | `void SET_TEXT_FONT(int fontType)` | void |
| `SET_TEXT_INPUT_BOX_ENABLED` | `void SET_TEXT_INPUT_BOX_ENABLED(bool p0)` | void |
| `SET_TEXT_JUSTIFICATION` | `void SET_TEXT_JUSTIFICATION(int justifyType)` | void |
| `SET_TEXT_LEADING` | `void SET_TEXT_LEADING(int p0)` | void |
| `SET_TEXT_LINE_HEIGHT_MULT` | `void SET_TEXT_LINE_HEIGHT_MULT(float lineHeightMult)` | void |
| `SET_TEXT_OUTLINE` | `void SET_TEXT_OUTLINE()` | void |
| `SET_TEXT_PROPORTIONAL` | `void SET_TEXT_PROPORTIONAL(bool p0)` | void |
| `SET_TEXT_RENDER_ID` | `void SET_TEXT_RENDER_ID(int renderId)` | void |
| `SET_TEXT_RIGHT_JUSTIFY` | `void SET_TEXT_RIGHT_JUSTIFY(bool toggle)` | void |
| `SET_TEXT_SCALE` | `void SET_TEXT_SCALE(float scale, float size)` | void |
| `SET_TEXT_WRAP` | `void SET_TEXT_WRAP(float start, float end)` | void |
| `SET_USE_ISLAND_MAP` | `void SET_USE_ISLAND_MAP(bool toggle)` | void |
| `SET_USE_SET_DESTINATION_IN_PAUSE_MAP` | `void SET_USE_SET_DESTINATION_IN_PAUSE_MAP(bool toggle)` | void |
| `SET_WARNING_MESSAGE` | `void SET_WARNING_MESSAGE(string titleMsg, int flags, string promptMsg, bool p3, int p4, string p5, string p6, bool showBackground, int errorCode)` | void |
| `SET_WARNING_MESSAGE_OPTION_HIGHLIGHT` | `bool SET_WARNING_MESSAGE_OPTION_HIGHLIGHT(object p0)` | bool |
| `SET_WARNING_MESSAGE_OPTION_ITEMS` | `bool SET_WARNING_MESSAGE_OPTION_ITEMS(int index, string name, int cash, int rp, int lvl, int colour)` | bool |
| `SET_WARNING_MESSAGE_WITH_HEADER` | `void SET_WARNING_MESSAGE_WITH_HEADER(string entryHeader, string entryLine1, int instructionalKey, string entryLine2, bool p4, object p5, ref object showBackground, ref object p7, bool p8, object p9)` | void |
| `SET_WARNING_MESSAGE_WITH_HEADER_AND_SUBSTRING_FLAGS` | `void SET_WARNING_MESSAGE_WITH_HEADER_AND_SUBSTRING_FLAGS(string entryHeader, string entryLine1, int instructionalKey, string entryLine2, bool p4, object p5, object additionalIntInfo, string additionalTextInfoLine1, string additionalTextInfoLine2, bool showBackground, int errorCode)` | void |
| `SET_WARNING_MESSAGE_WITH_HEADER_AND_SUBSTRING_FLAGS_EXTENDED` | `void SET_WARNING_MESSAGE_WITH_HEADER_AND_SUBSTRING_FLAGS_EXTENDED(string labelTitle, string labelMessage, int p2, int p3, string labelMessage2, bool p5, int p6, int p7, string p8, string p9, bool background, int errorCode)` | void |
| `SET_WARNING_MESSAGE_WITH_HEADER_EXTENDED` | `void SET_WARNING_MESSAGE_WITH_HEADER_EXTENDED(string entryHeader, string entryLine1, int flags, string entryLine2, bool p4, object p5, ref object p6, ref object p7, bool showBg, object p9, object p10)` | void |
| `SET_WAYPOINT_CLEAR_ON_ARRIVAL_MODE` | `void SET_WAYPOINT_CLEAR_ON_ARRIVAL_MODE(int mode)` | void |
| `SET_WAYPOINT_OFF` | `void SET_WAYPOINT_OFF()` | void |
| `SET_WIDESCREEN_FORMAT` | `void SET_WIDESCREEN_FORMAT(object p0)` | void |
| `SHOW_ACCOUNT_PICKER` | `void SHOW_ACCOUNT_PICKER()` | void |
| `SHOW_CONTACT_INSTRUCTIONAL_BUTTON` | `void SHOW_CONTACT_INSTRUCTIONAL_BUTTON(bool toggle)` | void |
| `SHOW_CREW_INDICATOR_ON_BLIP` | `void SHOW_CREW_INDICATOR_ON_BLIP(int blip, bool toggle)` | void |
| `SHOW_FOR_SALE_ICON_ON_BLIP` | `void SHOW_FOR_SALE_ICON_ON_BLIP(int blip, bool toggle)` | void |
| `SHOW_FRIEND_INDICATOR_ON_BLIP` | `void SHOW_FRIEND_INDICATOR_ON_BLIP(int blip, bool toggle)` | void |
| `SHOW_GOLD_TICK_ON_BLIP` | `void SHOW_GOLD_TICK_ON_BLIP(int blip, bool toggle)` | void |
| `SHOW_HEADING_INDICATOR_ON_BLIP` | `void SHOW_HEADING_INDICATOR_ON_BLIP(int blip, bool toggle)` | void |
| `SHOW_HEIGHT_ON_BLIP` | `void SHOW_HEIGHT_ON_BLIP(int blip, bool toggle)` | void |
| `SHOW_HUD_COMPONENT_THIS_FRAME` | `void SHOW_HUD_COMPONENT_THIS_FRAME(int id)` | void |
| `SHOW_NUMBER_ON_BLIP` | `void SHOW_NUMBER_ON_BLIP(int blip, int number)` | void |
| `SHOW_OUTLINE_INDICATOR_ON_BLIP` | `void SHOW_OUTLINE_INDICATOR_ON_BLIP(int blip, bool toggle)` | void |
| `SHOW_SCRIPTED_HUD_COMPONENT_THIS_FRAME` | `void SHOW_SCRIPTED_HUD_COMPONENT_THIS_FRAME(int id)` | void |
| `SHOW_START_MISSION_INSTRUCTIONAL_BUTTON` | `void SHOW_START_MISSION_INSTRUCTIONAL_BUTTON(bool toggle)` | void |
| `SHOW_TICK_ON_BLIP` | `void SHOW_TICK_ON_BLIP(int blip, bool toggle)` | void |
| `START_GPS_CUSTOM_ROUTE` | `void START_GPS_CUSTOM_ROUTE(int hudColor, bool displayOnFoot, bool followPlayer)` | void |
| `START_GPS_MULTI_ROUTE` | `void START_GPS_MULTI_ROUTE(int hudColor, bool routeFromPlayer, bool displayOnFoot)` | void |
| `SUPPRESS_FRONTEND_RENDERING_THIS_FRAME` | `void SUPPRESS_FRONTEND_RENDERING_THIS_FRAME()` | void |
| `TAKE_CONTROL_OF_FRONTEND` | `void TAKE_CONTROL_OF_FRONTEND()` | void |
| `THEFEED_AUTO_POST_GAMETIPS_OFF` | `void THEFEED_AUTO_POST_GAMETIPS_OFF()` | void |
| `THEFEED_AUTO_POST_GAMETIPS_ON` | `void THEFEED_AUTO_POST_GAMETIPS_ON()` | void |
| `THEFEED_CLEAR_FROZEN_POST` | `void THEFEED_CLEAR_FROZEN_POST()` | void |
| `THEFEED_FLUSH_QUEUE` | `void THEFEED_FLUSH_QUEUE()` | void |
| `THEFEED_FORCE_RENDER_OFF` | `void THEFEED_FORCE_RENDER_OFF()` | void |
| `THEFEED_FORCE_RENDER_ON` | `void THEFEED_FORCE_RENDER_ON()` | void |
| `THEFEED_FREEZE_NEXT_POST` | `void THEFEED_FREEZE_NEXT_POST()` | void |
| `THEFEED_GET_LAST_SHOWN_PHONE_ACTIVATABLE_FEED_ID` | `int THEFEED_GET_LAST_SHOWN_PHONE_ACTIVATABLE_FEED_ID()` | int |
| `THEFEED_HIDE` | `void THEFEED_HIDE()` | void |
| `THEFEED_HIDE_THIS_FRAME` | `void THEFEED_HIDE_THIS_FRAME()` | void |
| `THEFEED_IS_PAUSED` | `bool THEFEED_IS_PAUSED()` | bool |
| `THEFEED_ONLY_SHOW_TOOLTIPS` | `void THEFEED_ONLY_SHOW_TOOLTIPS(bool toggle)` | void |
| `THEFEED_PAUSE` | `void THEFEED_PAUSE()` | void |
| `THEFEED_REMOVE_ITEM` | `void THEFEED_REMOVE_ITEM(int notificationId)` | void |
| `THEFEED_REPORT_LOGO_OFF` | `void THEFEED_REPORT_LOGO_OFF()` | void |
| `THEFEED_REPORT_LOGO_ON` | `void THEFEED_REPORT_LOGO_ON()` | void |
| `THEFEED_RESET_ALL_PARAMETERS` | `void THEFEED_RESET_ALL_PARAMETERS()` | void |
| `THEFEED_RESUME` | `void THEFEED_RESUME()` | void |
| `THEFEED_SET_BACKGROUND_COLOR_FOR_NEXT_POST` | `void THEFEED_SET_BACKGROUND_COLOR_FOR_NEXT_POST(int hudColorIndex)` | void |
| `THEFEED_SET_FLASH_DURATION_PARAMETER_FOR_NEXT_MESSAGE` | `void THEFEED_SET_FLASH_DURATION_PARAMETER_FOR_NEXT_MESSAGE(int count)` | void |
| `THEFEED_SET_RGBA_PARAMETER_FOR_NEXT_MESSAGE` | `void THEFEED_SET_RGBA_PARAMETER_FOR_NEXT_MESSAGE(int red, int green, int blue, int alpha)` | void |
| `THEFEED_SET_SCRIPTED_MENU_HEIGHT` | `void THEFEED_SET_SCRIPTED_MENU_HEIGHT(float pos)` | void |
| `THEFEED_SET_SNAP_FEED_ITEM_POSITIONS` | `void THEFEED_SET_SNAP_FEED_ITEM_POSITIONS(bool p0)` | void |
| `THEFEED_SET_VIBRATE_PARAMETER_FOR_NEXT_MESSAGE` | `void THEFEED_SET_VIBRATE_PARAMETER_FOR_NEXT_MESSAGE(bool toggle)` | void |
| `THEFEED_SHOW` | `void THEFEED_SHOW()` | void |
| `THEFEED_UPDATE_ITEM_TEXTURE` | `void THEFEED_UPDATE_ITEM_TEXTURE(string txdString1, string txnString1, string txdString2, string txnString2)` | void |
| `TOGGLE_STEALTH_RADAR` | `void TOGGLE_STEALTH_RADAR(bool toggle)` | void |
| `TRIGGER_SONAR_BLIP` | `void TRIGGER_SONAR_BLIP(float posX, float posY, float posZ, float radius, int p4)` | void |
| `UNLOCK_MINIMAP_ANGLE` | `void UNLOCK_MINIMAP_ANGLE()` | void |
| `UNLOCK_MINIMAP_POSITION` | `void UNLOCK_MINIMAP_POSITION()` | void |
| `UPDATE_RADAR_ZOOM_TO_BLIP` | `void UPDATE_RADAR_ZOOM_TO_BLIP()` | void |
| `USE_FAKE_MP_CASH` | `void USE_FAKE_MP_CASH(bool toggle)` | void |
| `USE_VEHICLE_TARGETING_RETICULE` | `void USE_VEHICLE_TARGETING_RETICULE(object p0)` | void |
| `_SET_BLIP_GPS_ROUTE_DISPLAY_DISTANCE` | `void _SET_BLIP_GPS_ROUTE_DISPLAY_DISTANCE(int blip, int blipChangeParam46, bool blipChangeParam47)` | void |
| `_SET_PAUSE_EXTERIOR_RENDERING_WHILE_IN_INTERIOR` | `void _SET_PAUSE_EXTERIOR_RENDERING_WHILE_IN_INTERIOR()` | void |
| `_SHOW_PURCHASE_INSTRUCTIONAL_BUTTON` | `void _SHOW_PURCHASE_INSTRUCTIONAL_BUTTON(bool toggle)` | void |
| `_USE_VEHICLE_TARGETING_RETICULE_ON_VEHICLES` | `void _USE_VEHICLE_TARGETING_RETICULE_ON_VEHICLES(bool enable)` | void |

---

## GRAPHICS

| 函数名 | 签名 | 返回值 |
|--------|------|--------|
| `ABORT_VEHICLE_CREW_EMBLEM_REQUEST` | `bool ABORT_VEHICLE_CREW_EMBLEM_REQUEST(ref int p0)` | bool |
| `ADD_DECAL` | `int ADD_DECAL(int decalType, float posX, float posY, float posZ, float p4, float p5, float p6, float p7, float p8, float p9, float width, float height, float rCoef, float gCoef, float bCoef, float opacity, float timeout, bool p17, bool p18, bool p19)` | int |
| `ADD_ENTITY_ICON` | `int ADD_ENTITY_ICON(int entity, string icon)` | int |
| `ADD_OIL_DECAL` | `int ADD_OIL_DECAL(float x, float y, float z, float groundLvl, float width, float transparency)` | int |
| `ADD_PETROL_DECAL` | `int ADD_PETROL_DECAL(float x, float y, float z, float groundLvl, float width, float transparency)` | int |
| `ADD_PETROL_TRAIL_DECAL_INFO` | `void ADD_PETROL_TRAIL_DECAL_INFO(float x, float y, float z, float p3)` | void |
| `ADD_TCMODIFIER_OVERRIDE` | `void ADD_TCMODIFIER_OVERRIDE(string modifierName1, string modifierName2)` | void |
| `ADD_VEHICLE_CREW_EMBLEM` | `bool ADD_VEHICLE_CREW_EMBLEM(int vehicle, int ped, int boneIndex, float x1, float x2, float x3, float y1, float y2, float y3, float z1, float z2, float z3, float scale, object p13, int alpha)` | bool |
| `ADJUST_NEXT_POS_SIZE_AS_NORMALIZED_16_9` | `void ADJUST_NEXT_POS_SIZE_AS_NORMALIZED_16_9()` | void |
| `ANIMPOSTFX_GET_CURRENT_TIME` | `float ANIMPOSTFX_GET_CURRENT_TIME(string effectName)` | float |
| `ANIMPOSTFX_IS_RUNNING` | `bool ANIMPOSTFX_IS_RUNNING(string effectName)` | bool |
| `ANIMPOSTFX_PLAY` | `void ANIMPOSTFX_PLAY(string effectName, int duration, bool looped)` | void |
| `ANIMPOSTFX_STOP` | `void ANIMPOSTFX_STOP(string effectName)` | void |
| `ANIMPOSTFX_STOP_ALL` | `void ANIMPOSTFX_STOP_ALL()` | void |
| `ANIMPOSTFX_STOP_AND_FLUSH_REQUESTS` | `void ANIMPOSTFX_STOP_AND_FLUSH_REQUESTS(string effectName)` | void |
| `ATTACH_TV_AUDIO_TO_ENTITY` | `void ATTACH_TV_AUDIO_TO_ENTITY(int entity)` | void |
| `BEGIN_CREATE_LOW_QUALITY_COPY_OF_PHOTO` | `bool BEGIN_CREATE_LOW_QUALITY_COPY_OF_PHOTO(object p0)` | bool |
| `BEGIN_CREATE_MISSION_CREATOR_PHOTO_PREVIEW` | `bool BEGIN_CREATE_MISSION_CREATOR_PHOTO_PREVIEW()` | bool |
| `BEGIN_SCALEFORM_MOVIE_METHOD` | `bool BEGIN_SCALEFORM_MOVIE_METHOD(int scaleform, string methodName)` | bool |
| `BEGIN_SCALEFORM_MOVIE_METHOD_ON_FRONTEND` | `bool BEGIN_SCALEFORM_MOVIE_METHOD_ON_FRONTEND(string methodName)` | bool |
| `BEGIN_SCALEFORM_MOVIE_METHOD_ON_FRONTEND_HEADER` | `bool BEGIN_SCALEFORM_MOVIE_METHOD_ON_FRONTEND_HEADER(string methodName)` | bool |
| `BEGIN_SCALEFORM_SCRIPT_HUD_MOVIE_METHOD` | `bool BEGIN_SCALEFORM_SCRIPT_HUD_MOVIE_METHOD(int hudComponent, string methodName)` | bool |
| `BEGIN_TAKE_HIGH_QUALITY_PHOTO` | `bool BEGIN_TAKE_HIGH_QUALITY_PHOTO()` | bool |
| `BEGIN_TAKE_MISSION_CREATOR_PHOTO` | `bool BEGIN_TAKE_MISSION_CREATOR_PHOTO()` | bool |
| `BEGIN_TEXT_COMMAND_SCALEFORM_STRING` | `void BEGIN_TEXT_COMMAND_SCALEFORM_STRING(string componentType)` | void |
| `CALL_SCALEFORM_MOVIE_METHOD` | `void CALL_SCALEFORM_MOVIE_METHOD(int scaleform, string method)` | void |
| `CALL_SCALEFORM_MOVIE_METHOD_WITH_NUMBER` | `void CALL_SCALEFORM_MOVIE_METHOD_WITH_NUMBER(int scaleform, string methodName, float param1, float param2, float param3, float param4, float param5)` | void |
| `CALL_SCALEFORM_MOVIE_METHOD_WITH_NUMBER_AND_STRING` | `void CALL_SCALEFORM_MOVIE_METHOD_WITH_NUMBER_AND_STRING(int scaleform, string methodName, float floatParam1, float floatParam2, float floatParam3, float floatParam4, float floatParam5, string stringParam1, string stringParam2, string stringParam3, string stringParam4, string stringParam5)` | void |
| `CALL_SCALEFORM_MOVIE_METHOD_WITH_STRING` | `void CALL_SCALEFORM_MOVIE_METHOD_WITH_STRING(int scaleform, string methodName, string param1, string param2, string param3, string param4, string param5)` | void |
| `CAN_REQUEST_ASSETS_FOR_CUTSCENE_ENTITY` | `bool CAN_REQUEST_ASSETS_FOR_CUTSCENE_ENTITY()` | bool |
| `CAN_SET_ENTER_STATE_FOR_REGISTERED_ENTITY` | `bool CAN_SET_ENTER_STATE_FOR_REGISTERED_ENTITY(string cutsceneEntName, uint modelHash)` | bool |
| `CAN_SET_EXIT_STATE_FOR_CAMERA` | `bool CAN_SET_EXIT_STATE_FOR_CAMERA(bool p0)` | bool |
| `CAN_SET_EXIT_STATE_FOR_REGISTERED_ENTITY` | `bool CAN_SET_EXIT_STATE_FOR_REGISTERED_ENTITY(string cutsceneEntName, uint modelHash)` | bool |
| `CAN_USE_MOBILE_PHONE_DURING_CUTSCENE` | `bool CAN_USE_MOBILE_PHONE_DURING_CUTSCENE()` | bool |
| `CASCADE_SHADOWS_CLEAR_SHADOW_SAMPLE_TYPE` | `void CASCADE_SHADOWS_CLEAR_SHADOW_SAMPLE_TYPE()` | void |
| `CASCADE_SHADOWS_ENABLE_ENTITY_TRACKER` | `void CASCADE_SHADOWS_ENABLE_ENTITY_TRACKER(bool toggle)` | void |
| `CASCADE_SHADOWS_ENABLE_FREEZER` | `void CASCADE_SHADOWS_ENABLE_FREEZER(bool p0)` | void |
| `CASCADE_SHADOWS_INIT_SESSION` | `void CASCADE_SHADOWS_INIT_SESSION()` | void |
| `CASCADE_SHADOWS_SET_AIRCRAFT_MODE` | `void CASCADE_SHADOWS_SET_AIRCRAFT_MODE(bool p0)` | void |
| `CASCADE_SHADOWS_SET_BOUND_POSITION` | `void CASCADE_SHADOWS_SET_BOUND_POSITION(object p0)` | void |
| `CASCADE_SHADOWS_SET_CASCADE_BOUNDS` | `void CASCADE_SHADOWS_SET_CASCADE_BOUNDS(object p0, bool p1, float p2, float p3, float p4, float p5, bool p6, float p7)` | void |
| `CASCADE_SHADOWS_SET_CASCADE_BOUNDS_SCALE` | `void CASCADE_SHADOWS_SET_CASCADE_BOUNDS_SCALE(float p0)` | void |
| `CASCADE_SHADOWS_SET_DYNAMIC_DEPTH_MODE` | `void CASCADE_SHADOWS_SET_DYNAMIC_DEPTH_MODE(bool p0)` | void |
| `CASCADE_SHADOWS_SET_DYNAMIC_DEPTH_VALUE` | `void CASCADE_SHADOWS_SET_DYNAMIC_DEPTH_VALUE(float p0)` | void |
| `CASCADE_SHADOWS_SET_ENTITY_TRACKER_SCALE` | `void CASCADE_SHADOWS_SET_ENTITY_TRACKER_SCALE(float p0)` | void |
| `CASCADE_SHADOWS_SET_SCREEN_SIZE_CHECK_ENABLED` | `void CASCADE_SHADOWS_SET_SCREEN_SIZE_CHECK_ENABLED(bool p0)` | void |
| `CASCADE_SHADOWS_SET_SHADOW_SAMPLE_TYPE` | `void CASCADE_SHADOWS_SET_SHADOW_SAMPLE_TYPE(string type)` | void |
| `CASCADE_SHADOWS_SET_SPLIT_Z_EXP_WEIGHT` | `void CASCADE_SHADOWS_SET_SPLIT_Z_EXP_WEIGHT(float p0)` | void |
| `CLEAR_ALL_TCMODIFIER_OVERRIDES` | `void CLEAR_ALL_TCMODIFIER_OVERRIDES(string p0)` | void |
| `CLEAR_DRAW_ORIGIN` | `void CLEAR_DRAW_ORIGIN()` | void |
| `CLEAR_EXTRA_TCMODIFIER` | `void CLEAR_EXTRA_TCMODIFIER()` | void |
| `CLEAR_PARTICLE_FX_SHOOTOUT_BOAT` | `void CLEAR_PARTICLE_FX_SHOOTOUT_BOAT()` | void |
| `CLEAR_STATUS_OF_SORTED_LIST_OPERATION` | `void CLEAR_STATUS_OF_SORTED_LIST_OPERATION()` | void |
| `CLEAR_TIMECYCLE_MODIFIER` | `void CLEAR_TIMECYCLE_MODIFIER()` | void |
| `CLEAR_TV_CHANNEL_PLAYLIST` | `void CLEAR_TV_CHANNEL_PLAYLIST(int tvChannel)` | void |
| `CREATE_CHECKPOINT` | `int CREATE_CHECKPOINT(int type, float posX1, float posY1, float posZ1, float posX2, float posY2, float posZ2, float diameter, int red, int green, int blue, int alpha, int reserved)` | int |
| `CREATE_TRACKED_POINT` | `int CREATE_TRACKED_POINT()` | int |
| `DELETE_CHECKPOINT` | `void DELETE_CHECKPOINT(int checkpoint)` | void |
| `DESTROY_TRACKED_POINT` | `void DESTROY_TRACKED_POINT(int point)` | void |
| `DISABLE_COMPOSITE_SHOTGUN_DECALS` | `void DISABLE_COMPOSITE_SHOTGUN_DECALS(bool toggle)` | void |
| `DISABLE_DOWNWASH_PTFX` | `void DISABLE_DOWNWASH_PTFX(bool toggle)` | void |
| `DISABLE_HDTEX_THIS_FRAME` | `void DISABLE_HDTEX_THIS_FRAME()` | void |
| `DISABLE_IN_WATER_PTFX` | `void DISABLE_IN_WATER_PTFX(bool toggle)` | void |
| `DISABLE_MOON_CYCLE_OVERRIDE` | `void DISABLE_MOON_CYCLE_OVERRIDE()` | void |
| `DISABLE_OCCLUSION_THIS_FRAME` | `void DISABLE_OCCLUSION_THIS_FRAME()` | void |
| `DISABLE_PROCOBJ_CREATION` | `void DISABLE_PROCOBJ_CREATION()` | void |
| `DISABLE_REGION_VFX` | `void DISABLE_REGION_VFX(object p0)` | void |
| `DISABLE_SCREENBLUR_FADE` | `void DISABLE_SCREENBLUR_FADE()` | void |
| `DISABLE_SCUFF_DECALS` | `void DISABLE_SCUFF_DECALS(bool toggle)` | void |
| `DISABLE_VEHICLE_DISTANTLIGHTS` | `void DISABLE_VEHICLE_DISTANTLIGHTS(bool toggle)` | void |
| `DOES_CUTSCENE_ENTITY_EXIST` | `bool DOES_CUTSCENE_ENTITY_EXIST(string cutsceneEntName, uint modelHash)` | bool |
| `DOES_CUTSCENE_HANDLE_EXIST` | `int DOES_CUTSCENE_HANDLE_EXIST(int cutsceneHandle)` | int |
| `DOES_LATEST_BRIEF_STRING_EXIST` | `bool DOES_LATEST_BRIEF_STRING_EXIST(int p0)` | bool |
| `DOES_PARTICLE_FX_LOOPED_EXIST` | `bool DOES_PARTICLE_FX_LOOPED_EXIST(int ptfxHandle)` | bool |
| `DOES_THIS_PHOTO_SLOT_CONTAIN_A_VALID_PHOTO` | `bool DOES_THIS_PHOTO_SLOT_CONTAIN_A_VALID_PHOTO(object p0)` | bool |
| `DOES_VEHICLE_HAVE_CREW_EMBLEM` | `bool DOES_VEHICLE_HAVE_CREW_EMBLEM(int vehicle, int p1)` | bool |
| `DONT_RENDER_IN_GAME_UI` | `void DONT_RENDER_IN_GAME_UI(bool p0)` | void |
| `DRAW_BINK_MOVIE` | `void DRAW_BINK_MOVIE(int binkMovie, float p1, float p2, float p3, float p4, float p5, int r, int g, int b, int a)` | void |
| `DRAW_BOX` | `void DRAW_BOX(float x1, float y1, float z1, float x2, float y2, float z2, int red, int green, int blue, int alpha)` | void |
| `DRAW_DEBUG_BOX` | `void DRAW_DEBUG_BOX(float x1, float y1, float z1, float x2, float y2, float z2, int r, int g, int b, int alpha)` | void |
| `DRAW_DEBUG_CROSS` | `void DRAW_DEBUG_CROSS(float x, float y, float z, float size, int red, int green, int blue, int alpha)` | void |
| `DRAW_DEBUG_LINE` | `void DRAW_DEBUG_LINE(float x1, float y1, float z1, float x2, float y2, float z2, int r, int g, int b, int alpha)` | void |
| `DRAW_DEBUG_LINE_WITH_TWO_COLOURS` | `void DRAW_DEBUG_LINE_WITH_TWO_COLOURS(float x1, float y1, float z1, float x2, float y2, float z2, int r1, int g1, int b1, int r2, int g2, int b2, int alpha1, int alpha2)` | void |
| `DRAW_DEBUG_SPHERE` | `void DRAW_DEBUG_SPHERE(float x, float y, float z, float radius, int red, int green, int blue, int alpha)` | void |
| `DRAW_DEBUG_TEXT` | `void DRAW_DEBUG_TEXT(string text, float x, float y, float z, int red, int green, int blue, int alpha)` | void |
| `DRAW_DEBUG_TEXT_2D` | `void DRAW_DEBUG_TEXT_2D(string text, float x, float y, float z, int red, int green, int blue, int alpha)` | void |
| `DRAW_LIGHT_WITH_RANGE` | `void DRAW_LIGHT_WITH_RANGE(float posX, float posY, float posZ, int colorR, int colorG, int colorB, float range, float intensity)` | void |
| `DRAW_LIGHT_WITH_RANGEEX` | `void DRAW_LIGHT_WITH_RANGEEX(float x, float y, float z, int r, int g, int b, float range, float intensity, float shadow)` | void |
| `DRAW_LINE` | `void DRAW_LINE(float x1, float y1, float z1, float x2, float y2, float z2, int red, int green, int blue, int alpha)` | void |
| `DRAW_LOW_QUALITY_PHOTO_TO_PHONE` | `void DRAW_LOW_QUALITY_PHOTO_TO_PHONE(bool p0, bool p1)` | void |
| `DRAW_MARKER` | `void DRAW_MARKER(int type, float posX, float posY, float posZ, float dirX, float dirY, float dirZ, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ, int red, int green, int blue, int alpha, bool bobUpAndDown, bool faceCamera, int p19, bool rotate, string textureDict, string textureName, bool drawOnEnts)` | void |
| `DRAW_MARKER_EX` | `void DRAW_MARKER_EX(int type, float posX, float posY, float posZ, float dirX, float dirY, float dirZ, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ, int red, int green, int blue, int alpha, bool bobUpAndDown, bool faceCamera, object p19, bool rotate, string textureDict, string textureName, bool drawOnEnts, bool p24, bool p25)` | void |
| `DRAW_MARKER_SPHERE` | `void DRAW_MARKER_SPHERE(float x, float y, float z, float radius, int red, int green, int blue, float alpha)` | void |
| `DRAW_POLY` | `void DRAW_POLY(float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, int red, int green, int blue, int alpha)` | void |
| `DRAW_RECT` | `void DRAW_RECT(float x, float y, float width, float height, int r, int g, int b, int a, bool p8)` | void |
| `DRAW_SCALEFORM_MOVIE` | `void DRAW_SCALEFORM_MOVIE(int scaleformHandle, float x, float y, float width, float height, int red, int green, int blue, int alpha, int p9)` | void |
| `DRAW_SCALEFORM_MOVIE_3D` | `void DRAW_SCALEFORM_MOVIE_3D(int scaleform, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float p7, float p8, float p9, float scaleX, float scaleY, float scaleZ, int rotationOrder)` | void |
| `DRAW_SCALEFORM_MOVIE_3D_SOLID` | `void DRAW_SCALEFORM_MOVIE_3D_SOLID(int scaleform, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float p7, float p8, float p9, float scaleX, float scaleY, float scaleZ, int rotationOrder)` | void |
| `DRAW_SCALEFORM_MOVIE_FULLSCREEN` | `void DRAW_SCALEFORM_MOVIE_FULLSCREEN(int scaleform, int red, int green, int blue, int alpha, int p5)` | void |
| `DRAW_SCALEFORM_MOVIE_FULLSCREEN_MASKED` | `void DRAW_SCALEFORM_MOVIE_FULLSCREEN_MASKED(int scaleform1, int scaleform2, int red, int green, int blue, int alpha)` | void |
| `DRAW_SHADOWED_SPOT_LIGHT` | `void DRAW_SHADOWED_SPOT_LIGHT(float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int colorR, int colorG, int colorB, float distance, float brightness, float roundness, float radius, float falloff, int shadowId)` | void |
| `DRAW_SPOT_LIGHT` | `void DRAW_SPOT_LIGHT(float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int colorR, int colorG, int colorB, float distance, float brightness, float hardness, float radius, float falloff)` | void |
| `DRAW_SPRITE` | `void DRAW_SPRITE(string textureDict, string textureName, float screenX, float screenY, float width, float height, float heading, int red, int green, int blue, int alpha, bool p11, object p12)` | void |
| `DRAW_SPRITE_ARX` | `void DRAW_SPRITE_ARX(string textureDict, string textureName, float x, float y, float width, float height, float p6, int red, int green, int blue, int alpha, object p11, object p12)` | void |
| `DRAW_SPRITE_ARX_WITH_UV` | `void DRAW_SPRITE_ARX_WITH_UV(string textureDict, string textureName, float x, float y, float width, float height, float u1, float v1, float u2, float v2, float heading, int red, int green, int blue, int alpha, object p15)` | void |
| `DRAW_SPRITE_NAMED_RENDERTARGET` | `void DRAW_SPRITE_NAMED_RENDERTARGET(string textureDict, string textureName, float screenX, float screenY, float width, float height, float heading, int red, int green, int blue, int alpha, object p11)` | void |
| `DRAW_TEXTURED_POLY` | `void DRAW_TEXTURED_POLY(float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, int red, int green, int blue, int alpha, string textureDict, string textureName, float u1, float v1, float w1, float u2, float v2, float w2, float u3, float v3, float w3)` | void |
| `DRAW_TEXTURED_POLY_WITH_THREE_COLOURS` | `void DRAW_TEXTURED_POLY_WITH_THREE_COLOURS(float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, float red1, float green1, float blue1, int alpha1, float red2, float green2, float blue2, int alpha2, float red3, float green3, float blue3, int alpha3, string textureDict, string textureName, float u1, float v1, float w1, float u2, float v2, float w2, float u3, float v3, float w3)` | void |
| `DRAW_TV_CHANNEL` | `void DRAW_TV_CHANNEL(float xPos, float yPos, float xScale, float yScale, float rotation, int red, int green, int blue, int alpha)` | void |
| `ENABLE_ALIEN_BLOOD_VFX` | `void ENABLE_ALIEN_BLOOD_VFX(bool toggle)` | void |
| `ENABLE_CLOWN_BLOOD_VFX` | `void ENABLE_CLOWN_BLOOD_VFX(bool toggle)` | void |
| `ENABLE_MOON_CYCLE_OVERRIDE` | `void ENABLE_MOON_CYCLE_OVERRIDE(float strength)` | void |
| `ENABLE_MOVIE_KEYFRAME_WAIT` | `void ENABLE_MOVIE_KEYFRAME_WAIT(bool toggle)` | void |
| `ENABLE_MOVIE_SUBTITLES` | `void ENABLE_MOVIE_SUBTITLES(bool toggle)` | void |
| `ENABLE_PROCOBJ_CREATION` | `void ENABLE_PROCOBJ_CREATION()` | void |
| `END_PETROL_TRAIL_DECALS` | `void END_PETROL_TRAIL_DECALS()` | void |
| `END_SCALEFORM_MOVIE_METHOD` | `void END_SCALEFORM_MOVIE_METHOD()` | void |
| `END_SCALEFORM_MOVIE_METHOD_RETURN_VALUE` | `int END_SCALEFORM_MOVIE_METHOD_RETURN_VALUE()` | int |
| `END_TEXT_COMMAND_SCALEFORM_STRING` | `void END_TEXT_COMMAND_SCALEFORM_STRING()` | void |
| `END_TEXT_COMMAND_UNPARSED_SCALEFORM_STRING` | `void END_TEXT_COMMAND_UNPARSED_SCALEFORM_STRING()` | void |
| `FADE_DECALS_IN_RANGE` | `void FADE_DECALS_IN_RANGE(float x, float y, float z, float p3, float p4)` | void |
| `FADE_UP_PED_LIGHT` | `void FADE_UP_PED_LIGHT(float p0)` | void |
| `FORCE_EXPOSURE_READBACK` | `void FORCE_EXPOSURE_READBACK(bool toggle)` | void |
| `FORCE_PARTICLE_FX_IN_VEHICLE_INTERIOR` | `void FORCE_PARTICLE_FX_IN_VEHICLE_INTERIOR(object p0, object p1)` | void |
| `FORCE_POSTFX_BULLET_IMPACTS_AFTER_HUD` | `void FORCE_POSTFX_BULLET_IMPACTS_AFTER_HUD(bool p0)` | void |
| `FORCE_RENDER_IN_GAME_UI` | `void FORCE_RENDER_IN_GAME_UI(bool toggle)` | void |
| `FREE_MEMORY_FOR_HIGH_QUALITY_PHOTO` | `void FREE_MEMORY_FOR_HIGH_QUALITY_PHOTO()` | void |
| `FREE_MEMORY_FOR_LOW_QUALITY_PHOTO` | `void FREE_MEMORY_FOR_LOW_QUALITY_PHOTO()` | void |
| `FREE_MEMORY_FOR_MISSION_CREATOR_PHOTO` | `void FREE_MEMORY_FOR_MISSION_CREATOR_PHOTO()` | void |
| `FREE_MEMORY_FOR_MISSION_CREATOR_PHOTO_PREVIEW` | `void FREE_MEMORY_FOR_MISSION_CREATOR_PHOTO_PREVIEW()` | void |
| `GET_ACTUAL_SCREEN_RESOLUTION` | `void GET_ACTUAL_SCREEN_RESOLUTION(ref int x, ref int y)` | void |
| `GET_ASPECT_RATIO` | `float GET_ASPECT_RATIO(bool b)` | float |
| `GET_BINK_MOVIE_TIME` | `float GET_BINK_MOVIE_TIME(int binkMovie)` | float |
| `GET_CURRENT_NUMBER_OF_CLOUD_PHOTOS` | `int GET_CURRENT_NUMBER_OF_CLOUD_PHOTOS()` | int |
| `GET_CURRENT_TV_CLIP_NAMEHASH` | `uint GET_CURRENT_TV_CLIP_NAMEHASH()` | uint |
| `GET_CUTSCENE_CONCAT_SECTION_PLAYING` | `int GET_CUTSCENE_CONCAT_SECTION_PLAYING()` | int |
| `GET_CUTSCENE_END_TIME` | `int GET_CUTSCENE_END_TIME()` | int |
| `GET_CUTSCENE_PLAY_DURATION` | `int GET_CUTSCENE_PLAY_DURATION()` | int |
| `GET_CUTSCENE_PLAY_TIME` | `int GET_CUTSCENE_PLAY_TIME()` | int |
| `GET_CUTSCENE_SECTION_PLAYING` | `int GET_CUTSCENE_SECTION_PLAYING()` | int |
| `GET_CUTSCENE_TIME` | `int GET_CUTSCENE_TIME()` | int |
| `GET_CUTSCENE_TOTAL_DURATION` | `int GET_CUTSCENE_TOTAL_DURATION()` | int |
| `GET_CUT_FILE_CONCAT_COUNT` | `int GET_CUT_FILE_CONCAT_COUNT(string cutsceneName)` | int |
| `GET_CUT_FILE_OFFSET` | `Vector3 GET_CUT_FILE_OFFSET(string cutsceneName, int index)` | Vector3 |
| `GET_DECAL_WASH_LEVEL` | `float GET_DECAL_WASH_LEVEL(int decal)` | float |
| `GET_ENTITY_INDEX_OF_CUTSCENE_ENTITY` | `int GET_ENTITY_INDEX_OF_CUTSCENE_ENTITY(string cutsceneEntName, uint modelHash)` | int |
| `GET_ENTITY_INDEX_OF_REGISTERED_ENTITY` | `int GET_ENTITY_INDEX_OF_REGISTERED_ENTITY(string cutsceneEntName, uint modelHash)` | int |
| `GET_EXTRA_TCMODIFIER` | `int GET_EXTRA_TCMODIFIER()` | int |
| `GET_IS_HIDEF` | `bool GET_IS_HIDEF()` | bool |
| `GET_IS_PETROL_DECAL_IN_RANGE` | `bool GET_IS_PETROL_DECAL_IN_RANGE(float xCoord, float yCoord, float zCoord, float radius)` | bool |
| `GET_IS_TIMECYCLE_TRANSITIONING_OUT` | `bool GET_IS_TIMECYCLE_TRANSITIONING_OUT()` | bool |
| `GET_IS_WIDESCREEN` | `bool GET_IS_WIDESCREEN()` | bool |
| `GET_LIGHT_OVERRIDE_MAX_INTENSITY_SCALE` | `float GET_LIGHT_OVERRIDE_MAX_INTENSITY_SCALE()` | float |
| `GET_LOAD_HIGH_QUALITY_PHOTO_STATUS` | `int GET_LOAD_HIGH_QUALITY_PHOTO_STATUS(int p0)` | int |
| `GET_MAXIMUM_NUMBER_OF_CLOUD_PHOTOS` | `int GET_MAXIMUM_NUMBER_OF_CLOUD_PHOTOS()` | int |
| `GET_MAXIMUM_NUMBER_OF_PHOTOS` | `int GET_MAXIMUM_NUMBER_OF_PHOTOS()` | int |
| `GET_MOTIONBLUR_MAX_VEL_SCALER` | `float GET_MOTIONBLUR_MAX_VEL_SCALER()` | float |
| `GET_REQUESTINGNIGHTVISION` | `bool GET_REQUESTINGNIGHTVISION()` | bool |
| `GET_SAFE_ZONE_SIZE` | `float GET_SAFE_ZONE_SIZE()` | float |
| `GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_BOOL` | `bool GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_BOOL(int methodReturn)` | bool |
| `GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_INT` | `int GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_INT(int methodReturn)` | int |
| `GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_STRING` | `string GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_STRING(int methodReturn)` | string |
| `GET_SCREENBLUR_FADE_CURRENT_TIME` | `float GET_SCREENBLUR_FADE_CURRENT_TIME()` | float |
| `GET_SCREEN_ASPECT_RATIO` | `float GET_SCREEN_ASPECT_RATIO()` | float |
| `GET_SCREEN_COORD_FROM_WORLD_COORD` | `bool GET_SCREEN_COORD_FROM_WORLD_COORD(float worldX, float worldY, float worldZ, ref float screenX, ref float screenY)` | bool |
| `GET_SCREEN_RESOLUTION` | `void GET_SCREEN_RESOLUTION(ref int x, ref int y)` | void |
| `GET_SCRIPT_GFX_ALIGN_POSITION` | `void GET_SCRIPT_GFX_ALIGN_POSITION(float x, float y, ref float calculatedX, ref float calculatedY)` | void |
| `GET_STATUS_OF_CREATE_LOW_QUALITY_COPY_OF_PHOTO` | `int GET_STATUS_OF_CREATE_LOW_QUALITY_COPY_OF_PHOTO(int p0)` | int |
| `GET_STATUS_OF_CREATE_MISSION_CREATOR_PHOTO_PREVIEW` | `int GET_STATUS_OF_CREATE_MISSION_CREATOR_PHOTO_PREVIEW()` | int |
| `GET_STATUS_OF_LOAD_MISSION_CREATOR_PHOTO` | `int GET_STATUS_OF_LOAD_MISSION_CREATOR_PHOTO(ref object p0)` | int |
| `GET_STATUS_OF_SAVE_HIGH_QUALITY_PHOTO` | `int GET_STATUS_OF_SAVE_HIGH_QUALITY_PHOTO()` | int |
| `GET_STATUS_OF_SORTED_LIST_OPERATION` | `int GET_STATUS_OF_SORTED_LIST_OPERATION(object p0)` | int |
| `GET_STATUS_OF_TAKE_HIGH_QUALITY_PHOTO` | `int GET_STATUS_OF_TAKE_HIGH_QUALITY_PHOTO()` | int |
| `GET_STATUS_OF_TAKE_MISSION_CREATOR_PHOTO` | `int GET_STATUS_OF_TAKE_MISSION_CREATOR_PHOTO()` | int |
| `GET_TEXTURE_RESOLUTION` | `Vector3 GET_TEXTURE_RESOLUTION(string textureDict, string textureName)` | Vector3 |
| `GET_TIMECYCLE_MODIFIER_INDEX` | `int GET_TIMECYCLE_MODIFIER_INDEX()` | int |
| `GET_TIMECYCLE_TRANSITION_MODIFIER_INDEX` | `int GET_TIMECYCLE_TRANSITION_MODIFIER_INDEX()` | int |
| `GET_TOGGLE_PAUSED_RENDERPHASES_STATUS` | `bool GET_TOGGLE_PAUSED_RENDERPHASES_STATUS()` | bool |
| `GET_TV_CHANNEL` | `int GET_TV_CHANNEL()` | int |
| `GET_TV_VOLUME` | `float GET_TV_VOLUME()` | float |
| `GET_USINGNIGHTVISION` | `bool GET_USINGNIGHTVISION()` | bool |
| `GET_USINGSEETHROUGH` | `bool GET_USINGSEETHROUGH()` | bool |
| `GET_VEHICLE_CREW_EMBLEM_REQUEST_STATE` | `int GET_VEHICLE_CREW_EMBLEM_REQUEST_STATE(int vehicle, int p1)` | int |
| `GOLF_TRAIL_GET_MAX_HEIGHT` | `float GOLF_TRAIL_GET_MAX_HEIGHT()` | float |
| `GOLF_TRAIL_GET_VISUAL_CONTROL_POINT` | `Vector3 GOLF_TRAIL_GET_VISUAL_CONTROL_POINT(int p0)` | Vector3 |
| `GOLF_TRAIL_SET_COLOUR` | `void GOLF_TRAIL_SET_COLOUR(int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11)` | void |
| `GOLF_TRAIL_SET_ENABLED` | `void GOLF_TRAIL_SET_ENABLED(bool toggle)` | void |
| `GOLF_TRAIL_SET_FACING` | `void GOLF_TRAIL_SET_FACING(bool p0)` | void |
| `GOLF_TRAIL_SET_FIXED_CONTROL_POINT` | `void GOLF_TRAIL_SET_FIXED_CONTROL_POINT(int type, float xPos, float yPos, float zPos, float p4, int red, int green, int blue, int alpha)` | void |
| `GOLF_TRAIL_SET_FIXED_CONTROL_POINT_ENABLE` | `void GOLF_TRAIL_SET_FIXED_CONTROL_POINT_ENABLE(bool p0)` | void |
| `GOLF_TRAIL_SET_PATH` | `void GOLF_TRAIL_SET_PATH(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, bool p8)` | void |
| `GOLF_TRAIL_SET_RADIUS` | `void GOLF_TRAIL_SET_RADIUS(float p0, float p1, float p2)` | void |
| `GOLF_TRAIL_SET_SHADER_PARAMS` | `void GOLF_TRAIL_SET_SHADER_PARAMS(float p0, float p1, float p2, float p3, float p4)` | void |
| `GOLF_TRAIL_SET_TESSELLATION` | `void GOLF_TRAIL_SET_TESSELLATION(int p0, int p1)` | void |
| `GRAB_PAUSEMENU_OWNERSHIP` | `void GRAB_PAUSEMENU_OWNERSHIP()` | void |
| `GRASSBATCH_DISABLE_FLATTENING` | `void GRASSBATCH_DISABLE_FLATTENING()` | void |
| `GRASSBATCH_ENABLE_FLATTENING_EXT_IN_SPHERE` | `void GRASSBATCH_ENABLE_FLATTENING_EXT_IN_SPHERE(float x, float y, float z, object p3, float p4, float p5, float p6, float scale)` | void |
| `GRASSBATCH_ENABLE_FLATTENING_IN_SPHERE` | `void GRASSBATCH_ENABLE_FLATTENING_IN_SPHERE(float x, float y, float z, float radius, float p4, float p5, float p6)` | void |
| `HAS_CUTSCENE_CUT_THIS_FRAME` | `bool HAS_CUTSCENE_CUT_THIS_FRAME()` | bool |
| `HAS_CUTSCENE_FINISHED` | `bool HAS_CUTSCENE_FINISHED()` | bool |
| `HAS_CUTSCENE_LOADED` | `bool HAS_CUTSCENE_LOADED()` | bool |
| `HAS_CUT_FILE_LOADED` | `bool HAS_CUT_FILE_LOADED(string cutsceneName)` | bool |
| `HAS_SCALEFORM_CONTAINER_MOVIE_LOADED_INTO_PARENT` | `bool HAS_SCALEFORM_CONTAINER_MOVIE_LOADED_INTO_PARENT(int scaleformHandle)` | bool |
| `HAS_SCALEFORM_MOVIE_FILENAME_LOADED` | `bool HAS_SCALEFORM_MOVIE_FILENAME_LOADED(string scaleformName)` | bool |
| `HAS_SCALEFORM_MOVIE_LOADED` | `bool HAS_SCALEFORM_MOVIE_LOADED(int scaleformHandle)` | bool |
| `HAS_SCALEFORM_SCRIPT_HUD_MOVIE_LOADED` | `bool HAS_SCALEFORM_SCRIPT_HUD_MOVIE_LOADED(int hudComponent)` | bool |
| `HAS_STREAMED_TEXTURE_DICT_LOADED` | `bool HAS_STREAMED_TEXTURE_DICT_LOADED(string textureDict)` | bool |
| `HAS_THIS_CUTSCENE_LOADED` | `bool HAS_THIS_CUTSCENE_LOADED(string cutsceneName)` | bool |
| `IS_ACTIVE_SCALEFORM_MOVIE_DELETING` | `bool IS_ACTIVE_SCALEFORM_MOVIE_DELETING(int val)` | bool |
| `IS_CUTSCENE_ACTIVE` | `bool IS_CUTSCENE_ACTIVE()` | bool |
| `IS_CUTSCENE_AUTHORIZED` | `bool IS_CUTSCENE_AUTHORIZED(string cutsceneName)` | bool |
| `IS_CUTSCENE_PLAYBACK_FLAG_SET` | `bool IS_CUTSCENE_PLAYBACK_FLAG_SET(int flag)` | bool |
| `IS_CUTSCENE_PLAYING` | `bool IS_CUTSCENE_PLAYING()` | bool |
| `IS_DECAL_ALIVE` | `bool IS_DECAL_ALIVE(int decal)` | bool |
| `IS_MULTIHEAD_FADE_UP` | `bool IS_MULTIHEAD_FADE_UP()` | bool |
| `IS_PLAYLIST_ON_CHANNEL` | `bool IS_PLAYLIST_ON_CHANNEL(int tvChannel, object p1)` | bool |
| `IS_SCALEFORM_MOVIE_DELETING` | `bool IS_SCALEFORM_MOVIE_DELETING(int val)` | bool |
| `IS_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_READY` | `bool IS_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_READY(int methodReturn)` | bool |
| `IS_SCREENBLUR_FADE_RUNNING` | `bool IS_SCREENBLUR_FADE_RUNNING()` | bool |
| `IS_TRACKED_POINT_VISIBLE` | `bool IS_TRACKED_POINT_VISIBLE(int point)` | bool |
| `IS_TVSHOW_CURRENTLY_PLAYING` | `bool IS_TVSHOW_CURRENTLY_PLAYING(uint videoCliphash)` | bool |
| `LOAD_HIGH_QUALITY_PHOTO` | `bool LOAD_HIGH_QUALITY_PHOTO(object p0)` | bool |
| `LOAD_MISSION_CREATOR_PHOTO` | `bool LOAD_MISSION_CREATOR_PHOTO(ref object p0, object p1, object p2, object p3)` | bool |
| `LOAD_MOVIE_MESH_SET` | `int LOAD_MOVIE_MESH_SET(string movieMeshSetName)` | int |
| `MOVE_VEHICLE_DECALS` | `void MOVE_VEHICLE_DECALS(object p0, object p1)` | void |
| `NETWORK_SET_MOCAP_CUTSCENE_CAN_BE_SKIPPED` | `void NETWORK_SET_MOCAP_CUTSCENE_CAN_BE_SKIPPED(bool toggle)` | void |
| `OVERRIDE_INTERIOR_SMOKE_END` | `void OVERRIDE_INTERIOR_SMOKE_END()` | void |
| `OVERRIDE_INTERIOR_SMOKE_LEVEL` | `void OVERRIDE_INTERIOR_SMOKE_LEVEL(float level)` | void |
| `OVERRIDE_INTERIOR_SMOKE_NAME` | `void OVERRIDE_INTERIOR_SMOKE_NAME(string name)` | void |
| `OVERRIDE_NIGHTVISION_LIGHT_RANGE` | `void OVERRIDE_NIGHTVISION_LIGHT_RANGE(float p0)` | void |
| `OVERRIDE_PED_CREW_LOGO_TEXTURE` | `bool OVERRIDE_PED_CREW_LOGO_TEXTURE(int ped, string txd, string txn)` | bool |
| `PASS_KEYBOARD_INPUT_TO_SCALEFORM` | `bool PASS_KEYBOARD_INPUT_TO_SCALEFORM(int scaleformHandle)` | bool |
| `PATCH_DECAL_DIFFUSE_MAP` | `void PATCH_DECAL_DIFFUSE_MAP(int decalType, string textureDict, string textureName)` | void |
| `PHONEPHOTOEDITOR_IS_ACTIVE` | `bool PHONEPHOTOEDITOR_IS_ACTIVE()` | bool |
| `PHONEPHOTOEDITOR_SET_FRAME_TXD` | `bool PHONEPHOTOEDITOR_SET_FRAME_TXD(string textureDict, bool p1)` | bool |
| `PHONEPHOTOEDITOR_TOGGLE` | `bool PHONEPHOTOEDITOR_TOGGLE(bool p0)` | bool |
| `PLAY_BINK_MOVIE` | `void PLAY_BINK_MOVIE(int binkMovie)` | void |
| `POP_TIMECYCLE_MODIFIER` | `void POP_TIMECYCLE_MODIFIER()` | void |
| `PRESET_INTERIOR_AMBIENT_CACHE` | `void PRESET_INTERIOR_AMBIENT_CACHE(string timecycleModifierName)` | void |
| `PROCGRASS_DISABLE_AMBSCALESCAN` | `void PROCGRASS_DISABLE_AMBSCALESCAN()` | void |
| `PROCGRASS_DISABLE_CULLSPHERE` | `void PROCGRASS_DISABLE_CULLSPHERE(int handle)` | void |
| `PROCGRASS_ENABLE_AMBSCALESCAN` | `void PROCGRASS_ENABLE_AMBSCALESCAN()` | void |
| `PROCGRASS_ENABLE_CULLSPHERE` | `void PROCGRASS_ENABLE_CULLSPHERE(int handle, float x, float y, float z, float scale)` | void |
| `PROCGRASS_IS_CULLSPHERE_ENABLED` | `bool PROCGRASS_IS_CULLSPHERE_ENABLED(int handle)` | bool |
| `PUSH_TIMECYCLE_MODIFIER` | `void PUSH_TIMECYCLE_MODIFIER()` | void |
| `QUERY_MOVIE_MESH_SET_STATE` | `int QUERY_MOVIE_MESH_SET_STATE(object p0)` | int |
| `QUEUE_OPERATION_TO_CREATE_SORTED_LIST_OF_PHOTOS` | `bool QUEUE_OPERATION_TO_CREATE_SORTED_LIST_OF_PHOTOS(object p0)` | bool |
| `REGISTER_ENTITY_FOR_CUTSCENE` | `void REGISTER_ENTITY_FOR_CUTSCENE(int cutscenePed, string cutsceneEntName, int p2, uint modelHash, int p4)` | void |
| `REGISTER_NOIR_LENS_EFFECT` | `void REGISTER_NOIR_LENS_EFFECT()` | void |
| `REGISTER_POSTFX_BULLET_IMPACT` | `void REGISTER_POSTFX_BULLET_IMPACT(float weaponWorldPosX, float weaponWorldPosY, float weaponWorldPosZ, float intensity)` | void |
| `RELEASE_BINK_MOVIE` | `void RELEASE_BINK_MOVIE(int binkMovie)` | void |
| `RELEASE_MOVIE_MESH_SET` | `void RELEASE_MOVIE_MESH_SET(int movieMeshSet)` | void |
| `REMOVE_CUTSCENE` | `void REMOVE_CUTSCENE()` | void |
| `REMOVE_CUT_FILE` | `void REMOVE_CUT_FILE(string cutsceneName)` | void |
| `REMOVE_DECAL` | `void REMOVE_DECAL(int decal)` | void |
| `REMOVE_DECALS_FROM_OBJECT` | `void REMOVE_DECALS_FROM_OBJECT(int obj)` | void |
| `REMOVE_DECALS_FROM_OBJECT_FACING` | `void REMOVE_DECALS_FROM_OBJECT_FACING(int obj, float x, float y, float z)` | void |
| `REMOVE_DECALS_FROM_VEHICLE` | `void REMOVE_DECALS_FROM_VEHICLE(int vehicle)` | void |
| `REMOVE_DECALS_IN_RANGE` | `void REMOVE_DECALS_IN_RANGE(float x, float y, float z, float range)` | void |
| `REMOVE_GRASS_CULL_SPHERE` | `void REMOVE_GRASS_CULL_SPHERE(int handle)` | void |
| `REMOVE_PARTICLE_FX` | `void REMOVE_PARTICLE_FX(int ptfxHandle, bool p1)` | void |
| `REMOVE_PARTICLE_FX_FROM_ENTITY` | `void REMOVE_PARTICLE_FX_FROM_ENTITY(int entity)` | void |
| `REMOVE_PARTICLE_FX_IN_RANGE` | `void REMOVE_PARTICLE_FX_IN_RANGE(float X, float Y, float Z, float radius)` | void |
| `REMOVE_SCALEFORM_SCRIPT_HUD_MOVIE` | `void REMOVE_SCALEFORM_SCRIPT_HUD_MOVIE(int hudComponent)` | void |
| `REMOVE_VEHICLE_CREW_EMBLEM` | `void REMOVE_VEHICLE_CREW_EMBLEM(int vehicle, int p1)` | void |
| `RENDER_SHADOWED_LIGHTS_WITH_NO_SHADOWS` | `void RENDER_SHADOWED_LIGHTS_WITH_NO_SHADOWS(bool p0)` | void |
| `REQUEST_CUTSCENE` | `void REQUEST_CUTSCENE(string cutsceneName, int flags)` | void |
| `REQUEST_CUTSCENE_WITH_PLAYBACK_LIST` | `void REQUEST_CUTSCENE_WITH_PLAYBACK_LIST(string cutsceneName, int playbackFlags, int flags)` | void |
| `REQUEST_CUT_FILE` | `void REQUEST_CUT_FILE(string cutsceneName)` | void |
| `REQUEST_EARLY_LIGHT_CHECK` | `void REQUEST_EARLY_LIGHT_CHECK()` | void |
| `REQUEST_SCALEFORM_MOVIE` | `int REQUEST_SCALEFORM_MOVIE(string scaleformName)` | int |
| `REQUEST_SCALEFORM_MOVIE_INSTANCE` | `int REQUEST_SCALEFORM_MOVIE_INSTANCE(string scaleformName)` | int |
| `REQUEST_SCALEFORM_MOVIE_SKIP_RENDER_WHILE_PAUSED` | `int REQUEST_SCALEFORM_MOVIE_SKIP_RENDER_WHILE_PAUSED(string scaleformName)` | int |
| `REQUEST_SCALEFORM_MOVIE_WITH_IGNORE_SUPER_WIDESCREEN` | `int REQUEST_SCALEFORM_MOVIE_WITH_IGNORE_SUPER_WIDESCREEN(string scaleformName)` | int |
| `REQUEST_SCALEFORM_SCRIPT_HUD_MOVIE` | `void REQUEST_SCALEFORM_SCRIPT_HUD_MOVIE(int hudComponent)` | void |
| `REQUEST_STREAMED_TEXTURE_DICT` | `void REQUEST_STREAMED_TEXTURE_DICT(string textureDict, bool p1)` | void |
| `RESET_ADAPTATION` | `void RESET_ADAPTATION(int p0)` | void |
| `RESET_PARTICLE_FX_OVERRIDE` | `void RESET_PARTICLE_FX_OVERRIDE(string name)` | void |
| `RESET_PAUSED_RENDERPHASES` | `void RESET_PAUSED_RENDERPHASES()` | void |
| `RESET_SCRIPT_GFX_ALIGN` | `void RESET_SCRIPT_GFX_ALIGN()` | void |
| `SAVE_HIGH_QUALITY_PHOTO` | `bool SAVE_HIGH_QUALITY_PHOTO(int unused)` | bool |
| `SCALEFORM_MOVIE_METHOD_ADD_PARAM_BOOL` | `void SCALEFORM_MOVIE_METHOD_ADD_PARAM_BOOL(bool value)` | void |
| `SCALEFORM_MOVIE_METHOD_ADD_PARAM_FLOAT` | `void SCALEFORM_MOVIE_METHOD_ADD_PARAM_FLOAT(float value)` | void |
| `SCALEFORM_MOVIE_METHOD_ADD_PARAM_INT` | `void SCALEFORM_MOVIE_METHOD_ADD_PARAM_INT(int value)` | void |
| `SCALEFORM_MOVIE_METHOD_ADD_PARAM_LATEST_BRIEF_STRING` | `void SCALEFORM_MOVIE_METHOD_ADD_PARAM_LATEST_BRIEF_STRING(int value)` | void |
| `SCALEFORM_MOVIE_METHOD_ADD_PARAM_LITERAL_STRING` | `void SCALEFORM_MOVIE_METHOD_ADD_PARAM_LITERAL_STRING(string string)` | void |
| `SCALEFORM_MOVIE_METHOD_ADD_PARAM_PLAYER_NAME_STRING` | `void SCALEFORM_MOVIE_METHOD_ADD_PARAM_PLAYER_NAME_STRING(string string)` | void |
| `SCALEFORM_MOVIE_METHOD_ADD_PARAM_TEXTURE_NAME_STRING` | `void SCALEFORM_MOVIE_METHOD_ADD_PARAM_TEXTURE_NAME_STRING(string string)` | void |
| `SEETHROUGH_GET_MAX_THICKNESS` | `float SEETHROUGH_GET_MAX_THICKNESS()` | float |
| `SEETHROUGH_RESET` | `void SEETHROUGH_RESET()` | void |
| `SEETHROUGH_SET_COLOR_NEAR` | `void SEETHROUGH_SET_COLOR_NEAR(int red, int green, int blue)` | void |
| `SEETHROUGH_SET_FADE_ENDDISTANCE` | `void SEETHROUGH_SET_FADE_ENDDISTANCE(float distance)` | void |
| `SEETHROUGH_SET_FADE_STARTDISTANCE` | `void SEETHROUGH_SET_FADE_STARTDISTANCE(float distance)` | void |
| `SEETHROUGH_SET_HEATSCALE` | `void SEETHROUGH_SET_HEATSCALE(int index, float heatScale)` | void |
| `SEETHROUGH_SET_HIGHLIGHT_NOISE` | `void SEETHROUGH_SET_HIGHLIGHT_NOISE(float noise)` | void |
| `SEETHROUGH_SET_HILIGHT_INTENSITY` | `void SEETHROUGH_SET_HILIGHT_INTENSITY(float intensity)` | void |
| `SEETHROUGH_SET_MAX_THICKNESS` | `void SEETHROUGH_SET_MAX_THICKNESS(float thickness)` | void |
| `SEETHROUGH_SET_NOISE_MAX` | `void SEETHROUGH_SET_NOISE_MAX(float amount)` | void |
| `SEETHROUGH_SET_NOISE_MIN` | `void SEETHROUGH_SET_NOISE_MIN(float amount)` | void |
| `SET_ARENA_THEME_AND_VARIATION_FOR_TAKEN_PHOTO` | `void SET_ARENA_THEME_AND_VARIATION_FOR_TAKEN_PHOTO(object p0, int p1)` | void |
| `SET_ARTIFICIAL_LIGHTS_STATE` | `void SET_ARTIFICIAL_LIGHTS_STATE(bool state)` | void |
| `SET_ARTIFICIAL_VEHICLE_LIGHTS_STATE` | `void SET_ARTIFICIAL_VEHICLE_LIGHTS_STATE(bool toggle)` | void |
| `SET_BACKFACECULLING` | `void SET_BACKFACECULLING(bool toggle)` | void |
| `SET_BINK_MOVIE` | `int SET_BINK_MOVIE(string name)` | int |
| `SET_BINK_MOVIE_AUDIO_FRONTEND` | `void SET_BINK_MOVIE_AUDIO_FRONTEND(int binkMovie, bool p1)` | void |
| `SET_BINK_MOVIE_TIME` | `void SET_BINK_MOVIE_TIME(int binkMovie, float progress)` | void |
| `SET_BINK_MOVIE_VOLUME` | `void SET_BINK_MOVIE_VOLUME(int binkMovie, float value)` | void |
| `SET_BINK_SHOULD_SKIP` | `void SET_BINK_SHOULD_SKIP(int binkMovie, bool bShouldSkip)` | void |
| `SET_CAN_DISPLAY_MINIMAP_DURING_CUTSCENE_THIS_UPDATE` | `void SET_CAN_DISPLAY_MINIMAP_DURING_CUTSCENE_THIS_UPDATE()` | void |
| `SET_CAR_GENERATORS_CAN_UPDATE_DURING_CUTSCENE` | `void SET_CAR_GENERATORS_CAN_UPDATE_DURING_CUTSCENE(bool p0)` | void |
| `SET_CHECKPOINT_CLIPPLANE_WITH_POS_NORM` | `void SET_CHECKPOINT_CLIPPLANE_WITH_POS_NORM(int checkpoint, float posX, float posY, float posZ, float unkX, float unkY, float unkZ)` | void |
| `SET_CHECKPOINT_CYLINDER_HEIGHT` | `void SET_CHECKPOINT_CYLINDER_HEIGHT(int checkpoint, float nearHeight, float farHeight, float radius)` | void |
| `SET_CHECKPOINT_DECAL_ROT_ALIGNED_TO_CAMERA_ROT` | `void SET_CHECKPOINT_DECAL_ROT_ALIGNED_TO_CAMERA_ROT(int checkpoint)` | void |
| `SET_CHECKPOINT_DIRECTION` | `void SET_CHECKPOINT_DIRECTION(int checkpoint, float posX, float posY, float posZ)` | void |
| `SET_CHECKPOINT_FORCE_DIRECTION` | `void SET_CHECKPOINT_FORCE_DIRECTION(int checkpoint)` | void |
| `SET_CHECKPOINT_FORCE_OLD_ARROW_POINTING` | `void SET_CHECKPOINT_FORCE_OLD_ARROW_POINTING(int checkpoint)` | void |
| `SET_CHECKPOINT_INSIDE_CYLINDER_HEIGHT_SCALE` | `void SET_CHECKPOINT_INSIDE_CYLINDER_HEIGHT_SCALE(int checkpoint, float scale)` | void |
| `SET_CHECKPOINT_INSIDE_CYLINDER_SCALE` | `void SET_CHECKPOINT_INSIDE_CYLINDER_SCALE(int checkpoint, float scale)` | void |
| `SET_CHECKPOINT_RGBA` | `void SET_CHECKPOINT_RGBA(int checkpoint, int red, int green, int blue, int alpha)` | void |
| `SET_CHECKPOINT_RGBA2` | `void SET_CHECKPOINT_RGBA2(int checkpoint, int red, int green, int blue, int alpha)` | void |
| `SET_CURRENT_PLAYER_TCMODIFIER` | `void SET_CURRENT_PLAYER_TCMODIFIER(string modifierName)` | void |
| `SET_CUTSCENE_CAN_BE_SKIPPED` | `void SET_CUTSCENE_CAN_BE_SKIPPED(bool p0)` | void |
| `SET_CUTSCENE_ENTITY_STREAMING_FLAGS` | `void SET_CUTSCENE_ENTITY_STREAMING_FLAGS(string cutsceneEntName, int p1, int p2)` | void |
| `SET_CUTSCENE_FADE_VALUES` | `void SET_CUTSCENE_FADE_VALUES(bool p0, bool p1, bool p2, bool p3)` | void |
| `SET_CUTSCENE_MULTIHEAD_FADE` | `void SET_CUTSCENE_MULTIHEAD_FADE(bool p0, bool p1, bool p2, bool p3)` | void |
| `SET_CUTSCENE_MULTIHEAD_FADE_MANUAL` | `void SET_CUTSCENE_MULTIHEAD_FADE_MANUAL(bool p0)` | void |
| `SET_CUTSCENE_ORIGIN` | `void SET_CUTSCENE_ORIGIN(float x, float y, float z, float p3, int p4)` | void |
| `SET_CUTSCENE_ORIGIN_AND_ORIENTATION` | `void SET_CUTSCENE_ORIGIN_AND_ORIENTATION(float x1, float y1, float z1, float x2, float y2, float z2, int p6)` | void |
| `SET_CUTSCENE_PED_COMPONENT_VARIATION` | `void SET_CUTSCENE_PED_COMPONENT_VARIATION(string cutsceneEntName, int componentId, int drawableId, int textureId, uint modelHash)` | void |
| `SET_CUTSCENE_PED_COMPONENT_VARIATION_FROM_PED` | `void SET_CUTSCENE_PED_COMPONENT_VARIATION_FROM_PED(string cutsceneEntName, int ped, uint modelHash)` | void |
| `SET_CUTSCENE_PED_PROP_VARIATION` | `void SET_CUTSCENE_PED_PROP_VARIATION(string cutsceneEntName, int componentId, int drawableId, int textureId, uint modelHash)` | void |
| `SET_CUTSCENE_TRIGGER_AREA` | `void SET_CUTSCENE_TRIGGER_AREA(float x1, float y1, float z1, float x2, float y2, float z2)` | void |
| `SET_DEBUG_LINES_AND_SPHERES_DRAWING_ACTIVE` | `void SET_DEBUG_LINES_AND_SPHERES_DRAWING_ACTIVE(bool enabled)` | void |
| `SET_DECAL_BULLET_IMPACT_RANGE_SCALE` | `void SET_DECAL_BULLET_IMPACT_RANGE_SCALE(float p0)` | void |
| `SET_DEPTHWRITING` | `void SET_DEPTHWRITING(bool toggle)` | void |
| `SET_DISABLE_DECAL_RENDERING_THIS_FRAME` | `void SET_DISABLE_DECAL_RENDERING_THIS_FRAME()` | void |
| `SET_DISABLE_PETROL_DECALS_IGNITING_THIS_FRAME` | `void SET_DISABLE_PETROL_DECALS_IGNITING_THIS_FRAME()` | void |
| `SET_DISABLE_PETROL_DECALS_RECYCLING_THIS_FRAME` | `void SET_DISABLE_PETROL_DECALS_RECYCLING_THIS_FRAME()` | void |
| `SET_DISTANCE_BLUR_STRENGTH_OVERRIDE` | `void SET_DISTANCE_BLUR_STRENGTH_OVERRIDE(float p0)` | void |
| `SET_DRAW_ORIGIN` | `void SET_DRAW_ORIGIN(float x, float y, float z, bool p3)` | void |
| `SET_ENTITY_ICON_COLOR` | `void SET_ENTITY_ICON_COLOR(int entity, int red, int green, int blue, int alpha)` | void |
| `SET_ENTITY_ICON_VISIBILITY` | `void SET_ENTITY_ICON_VISIBILITY(int entity, bool toggle)` | void |
| `SET_EXPOSURETWEAK` | `void SET_EXPOSURETWEAK(bool toggle)` | void |
| `SET_EXTRA_TCMODIFIER` | `void SET_EXTRA_TCMODIFIER(string modifierName)` | void |
| `SET_FLASH` | `void SET_FLASH(float p0, float p1, float fadeIn, float duration, float fadeOut)` | void |
| `SET_FORCE_MOTIONBLUR` | `void SET_FORCE_MOTIONBLUR(bool toggle)` | void |
| `SET_GRASS_CULL_SPHERE` | `int SET_GRASS_CULL_SPHERE(float p0, float p1, float p2, float p3)` | int |
| `SET_HIDOF_OVERRIDE` | `void SET_HIDOF_OVERRIDE(bool p0, bool p1, float nearplaneOut, float nearplaneIn, float farplaneOut, float farplaneIn)` | void |
| `SET_LIGHT_OVERRIDE_MAX_INTENSITY_SCALE` | `void SET_LIGHT_OVERRIDE_MAX_INTENSITY_SCALE(object p0)` | void |
| `SET_LOCK_ADAPTIVE_DOF_DISTANCE` | `void SET_LOCK_ADAPTIVE_DOF_DISTANCE(bool p0)` | void |
| `SET_MOTIONBLUR_MAX_VEL_SCALER` | `void SET_MOTIONBLUR_MAX_VEL_SCALER(float p0)` | void |
| `SET_NEXT_PLAYER_TCMODIFIER` | `void SET_NEXT_PLAYER_TCMODIFIER(string modifierName)` | void |
| `SET_NIGHTVISION` | `void SET_NIGHTVISION(bool toggle)` | void |
| `SET_NOISEOVERIDE` | `void SET_NOISEOVERIDE(bool toggle)` | void |
| `SET_NOISINESSOVERIDE` | `void SET_NOISINESSOVERIDE(float value)` | void |
| `SET_ON_ISLAND_X_FOR_TAKEN_PHOTO` | `void SET_ON_ISLAND_X_FOR_TAKEN_PHOTO(object p0)` | void |
| `SET_PAD_CAN_SHAKE_DURING_CUTSCENE` | `void SET_PAD_CAN_SHAKE_DURING_CUTSCENE(bool toggle)` | void |
| `SET_PARTICLE_FX_BANG_SCRAPE_LODRANGE_SCALE` | `void SET_PARTICLE_FX_BANG_SCRAPE_LODRANGE_SCALE(float p0)` | void |
| `SET_PARTICLE_FX_BLOOD_SCALE` | `void SET_PARTICLE_FX_BLOOD_SCALE(object p0)` | void |
| `SET_PARTICLE_FX_BULLET_IMPACT_LODRANGE_SCALE` | `void SET_PARTICLE_FX_BULLET_IMPACT_LODRANGE_SCALE(float p0)` | void |
| `SET_PARTICLE_FX_BULLET_IMPACT_SCALE` | `void SET_PARTICLE_FX_BULLET_IMPACT_SCALE(float scale)` | void |
| `SET_PARTICLE_FX_BULLET_TRACE_NO_ANGLE_REJECT` | `void SET_PARTICLE_FX_BULLET_TRACE_NO_ANGLE_REJECT(bool p0)` | void |
| `SET_PARTICLE_FX_CAM_INSIDE_NONPLAYER_VEHICLE` | `void SET_PARTICLE_FX_CAM_INSIDE_NONPLAYER_VEHICLE(int vehicle, bool p1)` | void |
| `SET_PARTICLE_FX_CAM_INSIDE_VEHICLE` | `void SET_PARTICLE_FX_CAM_INSIDE_VEHICLE(bool p0)` | void |
| `SET_PARTICLE_FX_FOOT_LODRANGE_SCALE` | `void SET_PARTICLE_FX_FOOT_LODRANGE_SCALE(float p0)` | void |
| `SET_PARTICLE_FX_FOOT_OVERRIDE_NAME` | `void SET_PARTICLE_FX_FOOT_OVERRIDE_NAME(string p0)` | void |
| `SET_PARTICLE_FX_FORCE_VEHICLE_INTERIOR` | `void SET_PARTICLE_FX_FORCE_VEHICLE_INTERIOR(bool toggle)` | void |
| `SET_PARTICLE_FX_LOOPED_ALPHA` | `void SET_PARTICLE_FX_LOOPED_ALPHA(int ptfxHandle, float alpha)` | void |
| `SET_PARTICLE_FX_LOOPED_COLOUR` | `void SET_PARTICLE_FX_LOOPED_COLOUR(int ptfxHandle, float r, float g, float b, bool p4)` | void |
| `SET_PARTICLE_FX_LOOPED_EVOLUTION` | `void SET_PARTICLE_FX_LOOPED_EVOLUTION(int ptfxHandle, string propertyName, float amount, bool noNetwork)` | void |
| `SET_PARTICLE_FX_LOOPED_FAR_CLIP_DIST` | `void SET_PARTICLE_FX_LOOPED_FAR_CLIP_DIST(int ptfxHandle, float range)` | void |
| `SET_PARTICLE_FX_LOOPED_OFFSETS` | `void SET_PARTICLE_FX_LOOPED_OFFSETS(int ptfxHandle, float x, float y, float z, float rotX, float rotY, float rotZ)` | void |
| `SET_PARTICLE_FX_LOOPED_SCALE` | `void SET_PARTICLE_FX_LOOPED_SCALE(int ptfxHandle, float scale)` | void |
| `SET_PARTICLE_FX_NON_LOOPED_ALPHA` | `void SET_PARTICLE_FX_NON_LOOPED_ALPHA(float alpha)` | void |
| `SET_PARTICLE_FX_NON_LOOPED_COLOUR` | `void SET_PARTICLE_FX_NON_LOOPED_COLOUR(float r, float g, float b)` | void |
| `SET_PARTICLE_FX_NON_LOOPED_EMITTER_SIZE` | `void SET_PARTICLE_FX_NON_LOOPED_EMITTER_SIZE(float p0, float p1, float scale)` | void |
| `SET_PARTICLE_FX_NON_LOOPED_SCALE` | `void SET_PARTICLE_FX_NON_LOOPED_SCALE(float scale)` | void |
| `SET_PARTICLE_FX_OVERRIDE` | `void SET_PARTICLE_FX_OVERRIDE(string oldAsset, string newAsset)` | void |
| `SET_PARTICLE_FX_SHOOTOUT_BOAT` | `void SET_PARTICLE_FX_SHOOTOUT_BOAT(object p0)` | void |
| `SET_PARTICLE_FX_SLIPSTREAM_LODRANGE_SCALE` | `void SET_PARTICLE_FX_SLIPSTREAM_LODRANGE_SCALE(float scale)` | void |
| `SET_PLAYER_TCMODIFIER_TRANSITION` | `void SET_PLAYER_TCMODIFIER_TRANSITION(float value)` | void |
| `SET_PTFX_FORCE_VEHICLE_INTERIOR_FLAG` | `void SET_PTFX_FORCE_VEHICLE_INTERIOR_FLAG(object p0)` | void |
| `SET_SCALEFORM_MOVIE_AS_NO_LONGER_NEEDED` | `void SET_SCALEFORM_MOVIE_AS_NO_LONGER_NEEDED(ref int scaleformHandle)` | void |
| `SET_SCALEFORM_MOVIE_TO_USE_LARGE_RT` | `void SET_SCALEFORM_MOVIE_TO_USE_LARGE_RT(int scaleformHandle, bool toggle)` | void |
| `SET_SCALEFORM_MOVIE_TO_USE_SUPER_LARGE_RT` | `void SET_SCALEFORM_MOVIE_TO_USE_SUPER_LARGE_RT(int scaleformHandle, bool toggle)` | void |
| `SET_SCALEFORM_MOVIE_TO_USE_SYSTEM_TIME` | `void SET_SCALEFORM_MOVIE_TO_USE_SYSTEM_TIME(int scaleform, bool toggle)` | void |
| `SET_SCRIPT_CAN_START_CUTSCENE` | `void SET_SCRIPT_CAN_START_CUTSCENE(int threadId)` | void |
| `SET_SCRIPT_GFX_ALIGN` | `void SET_SCRIPT_GFX_ALIGN(int horizontalAlign, int verticalAlign)` | void |
| `SET_SCRIPT_GFX_ALIGN_PARAMS` | `void SET_SCRIPT_GFX_ALIGN_PARAMS(float x, float y, float w, float h)` | void |
| `SET_SCRIPT_GFX_DRAW_BEHIND_PAUSEMENU` | `void SET_SCRIPT_GFX_DRAW_BEHIND_PAUSEMENU(bool toggle)` | void |
| `SET_SCRIPT_GFX_DRAW_ORDER` | `void SET_SCRIPT_GFX_DRAW_ORDER(int drawOrder)` | void |
| `SET_SEETHROUGH` | `void SET_SEETHROUGH(bool toggle)` | void |
| `SET_SKIDMARK_RANGE_SCALE` | `void SET_SKIDMARK_RANGE_SCALE(float scale)` | void |
| `SET_STREAMED_TEXTURE_DICT_AS_NO_LONGER_NEEDED` | `void SET_STREAMED_TEXTURE_DICT_AS_NO_LONGER_NEEDED(string textureDict)` | void |
| `SET_TAKEN_PHOTO_IS_MUGSHOT` | `void SET_TAKEN_PHOTO_IS_MUGSHOT(bool toggle)` | void |
| `SET_TIMECYCLE_MODIFIER` | `void SET_TIMECYCLE_MODIFIER(string modifierName)` | void |
| `SET_TIMECYCLE_MODIFIER_STRENGTH` | `void SET_TIMECYCLE_MODIFIER_STRENGTH(float strength)` | void |
| `SET_TRACKED_POINT_INFO` | `void SET_TRACKED_POINT_INFO(int point, float x, float y, float z, float radius)` | void |
| `SET_TRANSITION_OUT_OF_TIMECYCLE_MODIFIER` | `void SET_TRANSITION_OUT_OF_TIMECYCLE_MODIFIER(float strength)` | void |
| `SET_TRANSITION_TIMECYCLE_MODIFIER` | `void SET_TRANSITION_TIMECYCLE_MODIFIER(string modifierName, float transition)` | void |
| `SET_TV_AUDIO_FRONTEND` | `void SET_TV_AUDIO_FRONTEND(bool toggle)` | void |
| `SET_TV_CHANNEL` | `void SET_TV_CHANNEL(int channel)` | void |
| `SET_TV_CHANNEL_PLAYLIST` | `void SET_TV_CHANNEL_PLAYLIST(int tvChannel, string playlistName, bool restart)` | void |
| `SET_TV_CHANNEL_PLAYLIST_AT_HOUR` | `void SET_TV_CHANNEL_PLAYLIST_AT_HOUR(int tvChannel, string playlistName, int hour)` | void |
| `SET_TV_PLAYER_WATCHING_THIS_FRAME` | `void SET_TV_PLAYER_WATCHING_THIS_FRAME(object p0)` | void |
| `SET_TV_VOLUME` | `void SET_TV_VOLUME(float volume)` | void |
| `SET_VEHICLE_MODEL_PLAYER_WILL_EXIT_SCENE` | `void SET_VEHICLE_MODEL_PLAYER_WILL_EXIT_SCENE(uint modelHash)` | void |
| `SET_WEATHER_PTFX_OVERRIDE_CURR_LEVEL` | `void SET_WEATHER_PTFX_OVERRIDE_CURR_LEVEL(float p0)` | void |
| `SET_WEATHER_PTFX_USE_OVERRIDE_SETTINGS` | `void SET_WEATHER_PTFX_USE_OVERRIDE_SETTINGS(bool p0)` | void |
| `START_CUTSCENE` | `void START_CUTSCENE(int flags)` | void |
| `START_CUTSCENE_AT_COORDS` | `void START_CUTSCENE_AT_COORDS(float x, float y, float z, int flags)` | void |
| `START_NETWORKED_PARTICLE_FX_LOOPED_ON_ENTITY` | `int START_NETWORKED_PARTICLE_FX_LOOPED_ON_ENTITY(string effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis, float r, float g, float b, float a)` | int |
| `START_NETWORKED_PARTICLE_FX_LOOPED_ON_ENTITY_BONE` | `int START_NETWORKED_PARTICLE_FX_LOOPED_ON_ENTITY_BONE(string effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, bool xAxis, bool yAxis, bool zAxis, float r, float g, float b, float a)` | int |
| `START_NETWORKED_PARTICLE_FX_NON_LOOPED_AT_COORD` | `bool START_NETWORKED_PARTICLE_FX_NON_LOOPED_AT_COORD(string effectName, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis, bool p11)` | bool |
| `START_NETWORKED_PARTICLE_FX_NON_LOOPED_ON_ENTITY` | `bool START_NETWORKED_PARTICLE_FX_NON_LOOPED_ON_ENTITY(string effectName, int entity, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, float scale, bool axisX, bool axisY, bool axisZ)` | bool |
| `START_NETWORKED_PARTICLE_FX_NON_LOOPED_ON_PED_BONE` | `bool START_NETWORKED_PARTICLE_FX_NON_LOOPED_ON_PED_BONE(string effectName, int ped, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, int boneIndex, float scale, bool axisX, bool axisY, bool axisZ)` | bool |
| `START_PARTICLE_FX_LOOPED_AT_COORD` | `int START_PARTICLE_FX_LOOPED_AT_COORD(string effectName, float x, float y, float z, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis, bool p11)` | int |
| `START_PARTICLE_FX_LOOPED_ON_ENTITY` | `int START_PARTICLE_FX_LOOPED_ON_ENTITY(string effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis)` | int |
| `START_PARTICLE_FX_LOOPED_ON_ENTITY_BONE` | `int START_PARTICLE_FX_LOOPED_ON_ENTITY_BONE(string effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, bool xAxis, bool yAxis, bool zAxis)` | int |
| `START_PARTICLE_FX_LOOPED_ON_PED_BONE` | `int START_PARTICLE_FX_LOOPED_ON_PED_BONE(string effectName, int ped, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, bool xAxis, bool yAxis, bool zAxis)` | int |
| `START_PARTICLE_FX_NON_LOOPED_AT_COORD` | `bool START_PARTICLE_FX_NON_LOOPED_AT_COORD(string effectName, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis)` | bool |
| `START_PARTICLE_FX_NON_LOOPED_ON_ENTITY` | `bool START_PARTICLE_FX_NON_LOOPED_ON_ENTITY(string effectName, int entity, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, float scale, bool axisX, bool axisY, bool axisZ)` | bool |
| `START_PARTICLE_FX_NON_LOOPED_ON_ENTITY_BONE` | `bool START_PARTICLE_FX_NON_LOOPED_ON_ENTITY_BONE(string effectName, int entity, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, int boneIndex, float scale, bool axisX, bool axisY, bool axisZ)` | bool |
| `START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE` | `bool START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE(string effectName, int ped, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, int boneIndex, float scale, bool axisX, bool axisY, bool axisZ)` | bool |
| `START_PETROL_TRAIL_DECALS` | `void START_PETROL_TRAIL_DECALS(float p0)` | void |
| `STOP_BINK_MOVIE` | `void STOP_BINK_MOVIE(int binkMovie)` | void |
| `STOP_CUTSCENE` | `void STOP_CUTSCENE(bool p0)` | void |
| `STOP_CUTSCENE_IMMEDIATELY` | `void STOP_CUTSCENE_IMMEDIATELY()` | void |
| `STOP_PARTICLE_FX_LOOPED` | `void STOP_PARTICLE_FX_LOOPED(int ptfxHandle, bool p1)` | void |
| `TERRAINGRID_ACTIVATE` | `void TERRAINGRID_ACTIVATE(bool toggle)` | void |
| `TERRAINGRID_SET_COLOURS` | `void TERRAINGRID_SET_COLOURS(int lowR, int lowG, int lowB, int lowAlpha, int r, int g, int b, int alpha, int highR, int highG, int highB, int highAlpha)` | void |
| `TERRAINGRID_SET_PARAMS` | `void TERRAINGRID_SET_PARAMS(float x, float y, float z, float forwardX, float forwardY, float forwardZ, float sizeX, float sizeY, float sizeZ, float gridScale, float glowIntensity, float normalHeight, float heightDiff)` | void |
| `TOGGLE_PAUSED_RENDERPHASES` | `void TOGGLE_PAUSED_RENDERPHASES(bool toggle)` | void |
| `TOGGLE_PLAYER_DAMAGE_OVERLAY` | `void TOGGLE_PLAYER_DAMAGE_OVERLAY(bool toggle)` | void |
| `TRIGGER_SCREENBLUR_FADE_IN` | `bool TRIGGER_SCREENBLUR_FADE_IN(float transitionTime)` | bool |
| `TRIGGER_SCREENBLUR_FADE_OUT` | `bool TRIGGER_SCREENBLUR_FADE_OUT(float transitionTime)` | bool |
| `UI3DSCENE_ASSIGN_PED_TO_SLOT` | `bool UI3DSCENE_ASSIGN_PED_TO_SLOT(string presetName, int ped, int slot, float posX, float posY, float posZ)` | bool |
| `UI3DSCENE_CLEAR_PATCHED_DATA` | `void UI3DSCENE_CLEAR_PATCHED_DATA()` | void |
| `UI3DSCENE_IS_AVAILABLE` | `bool UI3DSCENE_IS_AVAILABLE()` | bool |
| `UI3DSCENE_MAKE_PUSHED_PRESET_PERSISTENT` | `void UI3DSCENE_MAKE_PUSHED_PRESET_PERSISTENT(bool toggle)` | void |
| `UI3DSCENE_PUSH_PRESET` | `bool UI3DSCENE_PUSH_PRESET(string presetName)` | bool |
| `UNPATCH_DECAL_DIFFUSE_MAP` | `void UNPATCH_DECAL_DIFFUSE_MAP(int decalType)` | void |
| `UPDATE_LIGHTS_ON_ENTITY` | `void UPDATE_LIGHTS_ON_ENTITY(int entity)` | void |
| `USE_PARTICLE_FX_ASSET` | `void USE_PARTICLE_FX_ASSET(string name)` | void |
| `USE_SNOW_FOOT_VFX_WHEN_UNSHELTERED` | `void USE_SNOW_FOOT_VFX_WHEN_UNSHELTERED(bool toggle)` | void |
| `USE_SNOW_WHEEL_VFX_WHEN_UNSHELTERED` | `void USE_SNOW_WHEEL_VFX_WHEN_UNSHELTERED(bool toggle)` | void |
| `WASH_DECALS_FROM_VEHICLE` | `void WASH_DECALS_FROM_VEHICLE(int vehicle, float p1)` | void |
| `WASH_DECALS_IN_RANGE` | `void WASH_DECALS_IN_RANGE(float x, float y, float z, float range, float p4)` | void |
| `WAS_CUTSCENE_SKIPPED` | `bool WAS_CUTSCENE_SKIPPED()` | bool |
| `WATER_REFLECTION_SET_SCRIPT_OBJECT_VISIBILITY` | `void WATER_REFLECTION_SET_SCRIPT_OBJECT_VISIBILITY(object p0)` | void |
| `_FORCE_ALLOW_SNOW_FOOT_VFX_ON_ICE` | `void _FORCE_ALLOW_SNOW_FOOT_VFX_ON_ICE(bool toggle)` | void |
| `_FORCE_GROUND_SNOW_PASS` | `void _FORCE_GROUND_SNOW_PASS(bool toggle)` | void |
| `_HAS_SCALEFORM_MOVIE_NAMED_LOADED` | `bool _HAS_SCALEFORM_MOVIE_NAMED_LOADED(ref int scaleformHandle, string scaleformName)` | bool |
| `_SET_PARTICLE_FX_LOOPED_CAMERA_BIAS` | `void _SET_PARTICLE_FX_LOOPED_CAMERA_BIAS(int ptfxHandle, float p1)` | void |
| `_SET_SCALEFORM_MOVIE_NAMED_AS_NO_LONGER_NEEDED` | `void _SET_SCALEFORM_MOVIE_NAMED_AS_NO_LONGER_NEEDED(int scaleformHandle, string scaleformName)` | void |
| `_SET_TV_CHANNEL_PLAYLIST_DIRTY` | `object _SET_TV_CHANNEL_PLAYLIST_DIRTY(int tvChannel, bool p1)` | object |
| `_START_VEHICLE_PARTICLE_FX_LOOPED` | `int _START_VEHICLE_PARTICLE_FX_LOOPED(int vehicle, string effectName, bool frontBack, bool leftRight, bool localOnly)` | int |

---

## AUDIO

| 函数名 | 签名 | 返回值 |
|--------|------|--------|
| `ACTIVATE_AUDIO_SLOWMO_MODE` | `void ACTIVATE_AUDIO_SLOWMO_MODE(string mode)` | void |
| `ADD_ENTITY_TO_AUDIO_MIX_GROUP` | `void ADD_ENTITY_TO_AUDIO_MIX_GROUP(int entity, string groupName, float p2)` | void |
| `ADD_LINE_TO_CONVERSATION` | `void ADD_LINE_TO_CONVERSATION(int index, string p1, string p2, int p3, int p4, bool p5, bool p6, bool p7, bool p8, int p9, bool p10, bool p11, bool p12)` | void |
| `ADD_PED_TO_CONVERSATION` | `void ADD_PED_TO_CONVERSATION(int index, int ped, string p2)` | void |
| `AUDIO_IS_MUSIC_PLAYING` | `bool AUDIO_IS_MUSIC_PLAYING()` | bool |
| `AUDIO_IS_SCRIPTED_MUSIC_PLAYING` | `bool AUDIO_IS_SCRIPTED_MUSIC_PLAYING()` | bool |
| `BLIP_SIREN` | `void BLIP_SIREN(int vehicle)` | void |
| `BLOCK_ALL_SPEECH_FROM_PED` | `void BLOCK_ALL_SPEECH_FROM_PED(int ped, bool p1, bool p2)` | void |
| `BLOCK_DEATH_JINGLE` | `void BLOCK_DEATH_JINGLE(bool toggle)` | void |
| `BLOCK_SPEECH_CONTEXT_GROUP` | `void BLOCK_SPEECH_CONTEXT_GROUP(string p0, int p1)` | void |
| `CANCEL_ALL_POLICE_REPORTS` | `void CANCEL_ALL_POLICE_REPORTS()` | void |
| `CANCEL_MUSIC_EVENT` | `bool CANCEL_MUSIC_EVENT(string eventName)` | bool |
| `CAN_VEHICLE_RECEIVE_CB_RADIO` | `bool CAN_VEHICLE_RECEIVE_CB_RADIO(int vehicle)` | bool |
| `CLEAR_ALL_BROKEN_GLASS` | `void CLEAR_ALL_BROKEN_GLASS()` | void |
| `CLEAR_AMBIENT_ZONE_LIST_STATE` | `void CLEAR_AMBIENT_ZONE_LIST_STATE(string ambientZone, bool p1)` | void |
| `CLEAR_AMBIENT_ZONE_STATE` | `void CLEAR_AMBIENT_ZONE_STATE(string zoneName, bool p1)` | void |
| `CLEAR_CUSTOM_RADIO_TRACK_LIST` | `void CLEAR_CUSTOM_RADIO_TRACK_LIST(string radioStation)` | void |
| `CREATE_NEW_SCRIPTED_CONVERSATION` | `void CREATE_NEW_SCRIPTED_CONVERSATION()` | void |
| `DEACTIVATE_AUDIO_SLOWMO_MODE` | `void DEACTIVATE_AUDIO_SLOWMO_MODE(string mode)` | void |
| `DISABLE_PED_PAIN_AUDIO` | `void DISABLE_PED_PAIN_AUDIO(int ped, bool toggle)` | void |
| `DISTANT_COP_CAR_SIRENS` | `void DISTANT_COP_CAR_SIRENS(bool value)` | void |
| `DOES_CONTEXT_EXIST_FOR_THIS_PED` | `bool DOES_CONTEXT_EXIST_FOR_THIS_PED(int ped, string speechName, bool p2)` | bool |
| `DOES_PLAYER_VEH_HAVE_RADIO` | `bool DOES_PLAYER_VEH_HAVE_RADIO()` | bool |
| `ENABLE_STALL_WARNING_SOUNDS` | `void ENABLE_STALL_WARNING_SOUNDS(int vehicle, bool toggle)` | void |
| `ENABLE_STUNT_JUMP_AUDIO` | `void ENABLE_STUNT_JUMP_AUDIO()` | void |
| `ENABLE_VEHICLE_EXHAUST_POPS` | `void ENABLE_VEHICLE_EXHAUST_POPS(int vehicle, bool toggle)` | void |
| `ENABLE_VEHICLE_FANBELT_DAMAGE` | `void ENABLE_VEHICLE_FANBELT_DAMAGE(int vehicle, bool toggle)` | void |
| `FIND_RADIO_STATION_INDEX` | `int FIND_RADIO_STATION_INDEX(uint stationNameHash)` | int |
| `FORCE_MUSIC_TRACK_LIST` | `void FORCE_MUSIC_TRACK_LIST(string radioStation, string trackListName, int milliseconds)` | void |
| `FORCE_PED_PANIC_WALLA` | `void FORCE_PED_PANIC_WALLA()` | void |
| `FORCE_USE_AUDIO_GAME_OBJECT` | `void FORCE_USE_AUDIO_GAME_OBJECT(int vehicle, string audioName)` | void |
| `FREEZE_MICROPHONE` | `void FREEZE_MICROPHONE()` | void |
| `FREEZE_RADIO_STATION` | `void FREEZE_RADIO_STATION(string radioStation)` | void |
| `GET_AMBIENT_VOICE_NAME_HASH` | `uint GET_AMBIENT_VOICE_NAME_HASH(int ped)` | uint |
| `GET_AUDIBLE_MUSIC_TRACK_TEXT_ID` | `int GET_AUDIBLE_MUSIC_TRACK_TEXT_ID()` | int |
| `GET_CURRENT_SCRIPTED_CONVERSATION_LINE` | `int GET_CURRENT_SCRIPTED_CONVERSATION_LINE()` | int |
| `GET_CURRENT_TRACK_PLAY_TIME` | `int GET_CURRENT_TRACK_PLAY_TIME(string radioStationName)` | int |
| `GET_CURRENT_TRACK_SOUND_NAME` | `uint GET_CURRENT_TRACK_SOUND_NAME(string radioStationName)` | uint |
| `GET_CURRENT_TV_SHOW_PLAY_TIME` | `int GET_CURRENT_TV_SHOW_PLAY_TIME()` | int |
| `GET_IS_PRELOADED_CONVERSATION_READY` | `bool GET_IS_PRELOADED_CONVERSATION_READY()` | bool |
| `GET_MUSIC_PLAYTIME` | `int GET_MUSIC_PLAYTIME()` | int |
| `GET_MUSIC_VOL_SLIDER` | `int GET_MUSIC_VOL_SLIDER()` | int |
| `GET_NETWORK_ID_FROM_SOUND_ID` | `int GET_NETWORK_ID_FROM_SOUND_ID(int soundId)` | int |
| `GET_NEXT_AUDIBLE_BEAT` | `bool GET_NEXT_AUDIBLE_BEAT(ref float out1, ref float out2, ref int out3)` | bool |
| `GET_NUM_UNLOCKED_RADIO_STATIONS` | `int GET_NUM_UNLOCKED_RADIO_STATIONS()` | int |
| `GET_PLAYER_RADIO_STATION_GENRE` | `int GET_PLAYER_RADIO_STATION_GENRE()` | int |
| `GET_PLAYER_RADIO_STATION_INDEX` | `int GET_PLAYER_RADIO_STATION_INDEX()` | int |
| `GET_PLAYER_RADIO_STATION_NAME` | `string GET_PLAYER_RADIO_STATION_NAME()` | string |
| `GET_RADIO_STATION_NAME` | `string GET_RADIO_STATION_NAME(int radioStation)` | string |
| `GET_SOUND_ID` | `int GET_SOUND_ID()` | int |
| `GET_SOUND_ID_FROM_NETWORK_ID` | `int GET_SOUND_ID_FROM_NETWORK_ID(int netId)` | int |
| `GET_STREAM_PLAY_TIME` | `int GET_STREAM_PLAY_TIME()` | int |
| `GET_VARIATION_CHOSEN_FOR_SCRIPTED_LINE` | `int GET_VARIATION_CHOSEN_FOR_SCRIPTED_LINE(ref object p0)` | int |
| `GET_VEHICLE_DEFAULT_HORN` | `uint GET_VEHICLE_DEFAULT_HORN(int vehicle)` | uint |
| `GET_VEHICLE_DEFAULT_HORN_IGNORE_MODS` | `uint GET_VEHICLE_DEFAULT_HORN_IGNORE_MODS(int vehicle)` | uint |
| `GET_VEHICLE_HORN_SOUND_INDEX` | `int GET_VEHICLE_HORN_SOUND_INDEX(int vehicle)` | int |
| `HAS_LOADED_MP_DATA_SET` | `bool HAS_LOADED_MP_DATA_SET()` | bool |
| `HAS_LOADED_SP_DATA_SET` | `bool HAS_LOADED_SP_DATA_SET()` | bool |
| `HAS_SOUND_FINISHED` | `bool HAS_SOUND_FINISHED(int soundId)` | bool |
| `HINT_AMBIENT_AUDIO_BANK` | `bool HINT_AMBIENT_AUDIO_BANK(string audioBank, bool p1, object p2)` | bool |
| `HINT_MISSION_AUDIO_BANK` | `bool HINT_MISSION_AUDIO_BANK(string audioBank, bool p1, object p2)` | bool |
| `HINT_SCRIPT_AUDIO_BANK` | `bool HINT_SCRIPT_AUDIO_BANK(string audioBank, bool p1, object p2)` | bool |
| `INIT_SYNCH_SCENE_AUDIO_WITH_ENTITY` | `void INIT_SYNCH_SCENE_AUDIO_WITH_ENTITY(string audioEvent, int entity)` | void |
| `INIT_SYNCH_SCENE_AUDIO_WITH_POSITION` | `void INIT_SYNCH_SCENE_AUDIO_WITH_POSITION(string audioEvent, float x, float y, float z)` | void |
| `INTERRUPT_CONVERSATION` | `void INTERRUPT_CONVERSATION(int ped, string voiceline, string speaker)` | void |
| `INTERRUPT_CONVERSATION_AND_PAUSE` | `void INTERRUPT_CONVERSATION_AND_PAUSE(int ped, string p1, string speaker)` | void |
| `IS_ALARM_PLAYING` | `bool IS_ALARM_PLAYING(string alarmName)` | bool |
| `IS_AMBIENT_SPEECH_DISABLED` | `bool IS_AMBIENT_SPEECH_DISABLED(int ped)` | bool |
| `IS_AMBIENT_SPEECH_PLAYING` | `bool IS_AMBIENT_SPEECH_PLAYING(int ped)` | bool |
| `IS_AMBIENT_ZONE_ENABLED` | `bool IS_AMBIENT_ZONE_ENABLED(string ambientZone)` | bool |
| `IS_ANIMAL_VOCALIZATION_PLAYING` | `bool IS_ANIMAL_VOCALIZATION_PLAYING(int pedHandle)` | bool |
| `IS_ANY_POSITIONAL_SPEECH_PLAYING` | `bool IS_ANY_POSITIONAL_SPEECH_PLAYING()` | bool |
| `IS_ANY_SPEECH_PLAYING` | `bool IS_ANY_SPEECH_PLAYING(int ped)` | bool |
| `IS_AUDIO_SCENE_ACTIVE` | `bool IS_AUDIO_SCENE_ACTIVE(string scene)` | bool |
| `IS_GAME_IN_CONTROL_OF_MUSIC` | `bool IS_GAME_IN_CONTROL_OF_MUSIC()` | bool |
| `IS_HORN_ACTIVE` | `bool IS_HORN_ACTIVE(int vehicle)` | bool |
| `IS_MISSION_COMPLETE_PLAYING` | `bool IS_MISSION_COMPLETE_PLAYING()` | bool |
| `IS_MISSION_COMPLETE_READY_FOR_UI` | `bool IS_MISSION_COMPLETE_READY_FOR_UI()` | bool |
| `IS_MISSION_NEWS_STORY_UNLOCKED` | `bool IS_MISSION_NEWS_STORY_UNLOCKED(int newsStory)` | bool |
| `IS_MOBILE_INTERFERENCE_ACTIVE` | `bool IS_MOBILE_INTERFERENCE_ACTIVE()` | bool |
| `IS_MOBILE_PHONE_CALL_ONGOING` | `bool IS_MOBILE_PHONE_CALL_ONGOING()` | bool |
| `IS_MOBILE_PHONE_RADIO_ACTIVE` | `bool IS_MOBILE_PHONE_RADIO_ACTIVE()` | bool |
| `IS_MUSIC_ONESHOT_PLAYING` | `bool IS_MUSIC_ONESHOT_PLAYING()` | bool |
| `IS_PED_IN_CURRENT_CONVERSATION` | `bool IS_PED_IN_CURRENT_CONVERSATION(int ped)` | bool |
| `IS_PED_RINGTONE_PLAYING` | `bool IS_PED_RINGTONE_PLAYING(int ped)` | bool |
| `IS_PLAYER_VEH_RADIO_ENABLE` | `bool IS_PLAYER_VEH_RADIO_ENABLE()` | bool |
| `IS_RADIO_FADED_OUT` | `bool IS_RADIO_FADED_OUT()` | bool |
| `IS_RADIO_RETUNING` | `bool IS_RADIO_RETUNING()` | bool |
| `IS_RADIO_STATION_FAVOURITED` | `bool IS_RADIO_STATION_FAVOURITED(string radioStation)` | bool |
| `IS_SCRIPTED_CONVERSATION_LOADED` | `bool IS_SCRIPTED_CONVERSATION_LOADED()` | bool |
| `IS_SCRIPTED_CONVERSATION_ONGOING` | `bool IS_SCRIPTED_CONVERSATION_ONGOING()` | bool |
| `IS_SCRIPTED_SPEECH_PLAYING` | `bool IS_SCRIPTED_SPEECH_PLAYING(int p0)` | bool |
| `IS_STREAM_PLAYING` | `bool IS_STREAM_PLAYING()` | bool |
| `IS_VEHICLE_AUDIBLY_DAMAGED` | `bool IS_VEHICLE_AUDIBLY_DAMAGED(int vehicle)` | bool |
| `IS_VEHICLE_RADIO_ON` | `bool IS_VEHICLE_RADIO_ON(int vehicle)` | bool |
| `LINK_STATIC_EMITTER_TO_ENTITY` | `void LINK_STATIC_EMITTER_TO_ENTITY(string emitterName, int entity)` | void |
| `LOAD_STREAM` | `bool LOAD_STREAM(string streamName, string soundSet)` | bool |
| `LOAD_STREAM_WITH_START_OFFSET` | `bool LOAD_STREAM_WITH_START_OFFSET(string streamName, int startOffset, string soundSet)` | bool |
| `LOCK_RADIO_STATION` | `void LOCK_RADIO_STATION(string radioStationName, bool toggle)` | void |
| `LOCK_RADIO_STATION_TRACK_LIST` | `void LOCK_RADIO_STATION_TRACK_LIST(string radioStation, string trackListName)` | void |
| `OVERRIDE_MICROPHONE_SETTINGS` | `void OVERRIDE_MICROPHONE_SETTINGS(uint hash, bool toggle)` | void |
| `OVERRIDE_PLAYER_GROUND_MATERIAL` | `void OVERRIDE_PLAYER_GROUND_MATERIAL(uint hash, bool toggle)` | void |
| `OVERRIDE_TREVOR_RAGE` | `void OVERRIDE_TREVOR_RAGE(string voiceEffect)` | void |
| `OVERRIDE_UNDERWATER_STREAM` | `void OVERRIDE_UNDERWATER_STREAM(string p0, bool p1)` | void |
| `OVERRIDE_VEH_HORN` | `void OVERRIDE_VEH_HORN(int vehicle, bool override, int hornHash)` | void |
| `PAUSE_SCRIPTED_CONVERSATION` | `void PAUSE_SCRIPTED_CONVERSATION(bool p0)` | void |
| `PLAY_AMBIENT_SPEECH_FROM_POSITION_NATIVE` | `void PLAY_AMBIENT_SPEECH_FROM_POSITION_NATIVE(string speechName, string voiceName, float x, float y, float z, string speechParam)` | void |
| `PLAY_ANIMAL_VOCALIZATION` | `void PLAY_ANIMAL_VOCALIZATION(int pedHandle, int p1, string speechName)` | void |
| `PLAY_DEFERRED_SOUND_FRONTEND` | `void PLAY_DEFERRED_SOUND_FRONTEND(string soundName, string soundsetName)` | void |
| `PLAY_END_CREDITS_MUSIC` | `void PLAY_END_CREDITS_MUSIC(bool play)` | void |
| `PLAY_MISSION_COMPLETE_AUDIO` | `void PLAY_MISSION_COMPLETE_AUDIO(string audioName)` | void |
| `PLAY_PAIN` | `void PLAY_PAIN(int ped, int painID, int p1, object p3)` | void |
| `PLAY_PED_AMBIENT_SPEECH_AND_CLONE_NATIVE` | `void PLAY_PED_AMBIENT_SPEECH_AND_CLONE_NATIVE(int ped, string speechName, string speechParam, object p3)` | void |
| `PLAY_PED_AMBIENT_SPEECH_NATIVE` | `void PLAY_PED_AMBIENT_SPEECH_NATIVE(int ped, string speechName, string speechParam, object p3)` | void |
| `PLAY_PED_AMBIENT_SPEECH_WITH_VOICE_NATIVE` | `void PLAY_PED_AMBIENT_SPEECH_WITH_VOICE_NATIVE(int ped, string speechName, string voiceName, string speechParam, bool p4)` | void |
| `PLAY_PED_AUDIO_EVENT_ANIM` | `void PLAY_PED_AUDIO_EVENT_ANIM(int pedHandle, string audioEvent)` | void |
| `PLAY_PED_RINGTONE` | `void PLAY_PED_RINGTONE(string ringtoneName, int ped, bool p2)` | void |
| `PLAY_POLICE_REPORT` | `int PLAY_POLICE_REPORT(string name, float p1)` | int |
| `PLAY_SOUND` | `void PLAY_SOUND(int soundId, string audioName, string audioRef, bool p3, object p4, bool p5)` | void |
| `PLAY_SOUND_FROM_COORD` | `void PLAY_SOUND_FROM_COORD(int soundId, string audioName, float x, float y, float z, string audioRef, bool isNetwork, int range, bool p8)` | void |
| `PLAY_SOUND_FROM_ENTITY` | `void PLAY_SOUND_FROM_ENTITY(int soundId, string audioName, int entity, string audioRef, bool isNetwork, object p5)` | void |
| `PLAY_SOUND_FROM_ENTITY_HASH` | `void PLAY_SOUND_FROM_ENTITY_HASH(int soundId, uint model, int entity, uint soundSetHash, object p4, object p5)` | void |
| `PLAY_SOUND_FRONTEND` | `void PLAY_SOUND_FRONTEND(int soundId, string audioName, string audioRef, bool p3)` | void |
| `PLAY_STREAM_FROM_OBJECT` | `void PLAY_STREAM_FROM_OBJECT(int object)` | void |
| `PLAY_STREAM_FROM_PED` | `void PLAY_STREAM_FROM_PED(int ped)` | void |
| `PLAY_STREAM_FROM_POSITION` | `void PLAY_STREAM_FROM_POSITION(float x, float y, float z)` | void |
| `PLAY_STREAM_FROM_VEHICLE` | `void PLAY_STREAM_FROM_VEHICLE(int vehicle)` | void |
| `PLAY_STREAM_FRONTEND` | `void PLAY_STREAM_FRONTEND()` | void |
| `PLAY_SYNCHRONIZED_AUDIO_EVENT` | `bool PLAY_SYNCHRONIZED_AUDIO_EVENT(int sceneID)` | bool |
| `PLAY_VEHICLE_DOOR_CLOSE_SOUND` | `void PLAY_VEHICLE_DOOR_CLOSE_SOUND(int vehicle, int doorId)` | void |
| `PLAY_VEHICLE_DOOR_OPEN_SOUND` | `void PLAY_VEHICLE_DOOR_OPEN_SOUND(int vehicle, int doorId)` | void |
| `PRELOAD_SCRIPT_CONVERSATION` | `void PRELOAD_SCRIPT_CONVERSATION(bool p0, bool p1, bool p2, bool p3)` | void |
| `PRELOAD_SCRIPT_PHONE_CONVERSATION` | `void PRELOAD_SCRIPT_PHONE_CONVERSATION(bool p0, bool p1)` | void |
| `PRELOAD_VEHICLE_AUDIO_BANK` | `void PRELOAD_VEHICLE_AUDIO_BANK(uint vehicleModel)` | void |
| `PREPARE_ALARM` | `bool PREPARE_ALARM(string alarmName)` | bool |
| `PREPARE_MUSIC_EVENT` | `bool PREPARE_MUSIC_EVENT(string eventName)` | bool |
| `PREPARE_SYNCHRONIZED_AUDIO_EVENT` | `bool PREPARE_SYNCHRONIZED_AUDIO_EVENT(string audioEvent, object p1)` | bool |
| `PREPARE_SYNCHRONIZED_AUDIO_EVENT_FOR_SCENE` | `bool PREPARE_SYNCHRONIZED_AUDIO_EVENT_FOR_SCENE(int sceneID, string audioEvent)` | bool |
| `RECORD_BROKEN_GLASS` | `void RECORD_BROKEN_GLASS(float x, float y, float z, float radius)` | void |
| `REFRESH_CLOSEST_OCEAN_SHORELINE` | `void REFRESH_CLOSEST_OCEAN_SHORELINE()` | void |
| `REGISTER_SCRIPT_WITH_AUDIO` | `void REGISTER_SCRIPT_WITH_AUDIO(int p0)` | void |
| `RELEASE_AMBIENT_AUDIO_BANK` | `void RELEASE_AMBIENT_AUDIO_BANK()` | void |
| `RELEASE_MISSION_AUDIO_BANK` | `void RELEASE_MISSION_AUDIO_BANK()` | void |
| `RELEASE_NAMED_SCRIPT_AUDIO_BANK` | `void RELEASE_NAMED_SCRIPT_AUDIO_BANK(string audioBank)` | void |
| `RELEASE_SCRIPT_AUDIO_BANK` | `void RELEASE_SCRIPT_AUDIO_BANK()` | void |
| `RELEASE_SOUND_ID` | `void RELEASE_SOUND_ID(int soundId)` | void |
| `RELEASE_WEAPON_AUDIO` | `void RELEASE_WEAPON_AUDIO()` | void |
| `REMOVE_ENTITY_FROM_AUDIO_MIX_GROUP` | `void REMOVE_ENTITY_FROM_AUDIO_MIX_GROUP(int entity, float p1)` | void |
| `REMOVE_INDIVIDUAL_PORTAL_SETTINGS_OVERRIDE` | `void REMOVE_INDIVIDUAL_PORTAL_SETTINGS_OVERRIDE(uint interiorNameHash, int roomIndex, int doorIndex)` | void |
| `REMOVE_PORTAL_SETTINGS_OVERRIDE` | `void REMOVE_PORTAL_SETTINGS_OVERRIDE(string p0)` | void |
| `REQUEST_AMBIENT_AUDIO_BANK` | `bool REQUEST_AMBIENT_AUDIO_BANK(string audioBank, bool p1, object p2)` | bool |
| `REQUEST_MISSION_AUDIO_BANK` | `bool REQUEST_MISSION_AUDIO_BANK(string audioBank, bool p1, object p2)` | bool |
| `REQUEST_SCRIPT_AUDIO_BANK` | `bool REQUEST_SCRIPT_AUDIO_BANK(string audioBank, bool p1, object p2)` | bool |
| `REQUEST_TENNIS_BANKS` | `void REQUEST_TENNIS_BANKS(int ped)` | void |
| `RESET_PED_AUDIO_FLAGS` | `void RESET_PED_AUDIO_FLAGS(int ped)` | void |
| `RESET_TREVOR_RAGE` | `void RESET_TREVOR_RAGE()` | void |
| `RESET_VEHICLE_STARTUP_REV_SOUND` | `void RESET_VEHICLE_STARTUP_REV_SOUND(int vehicle)` | void |
| `RESTART_SCRIPTED_CONVERSATION` | `void RESTART_SCRIPTED_CONVERSATION()` | void |
| `SCRIPT_OVERRIDES_WIND_ELEVATION` | `void SCRIPT_OVERRIDES_WIND_ELEVATION(bool p0, object p1)` | void |
| `SET_AGGRESSIVE_HORNS` | `void SET_AGGRESSIVE_HORNS(bool toggle)` | void |
| `SET_AMBIENT_VOICE_NAME` | `void SET_AMBIENT_VOICE_NAME(int ped, string name)` | void |
| `SET_AMBIENT_VOICE_NAME_HASH` | `void SET_AMBIENT_VOICE_NAME_HASH(int ped, uint hash)` | void |
| `SET_AMBIENT_ZONE_LIST_STATE` | `void SET_AMBIENT_ZONE_LIST_STATE(string ambientZone, bool p1, bool p2)` | void |
| `SET_AMBIENT_ZONE_LIST_STATE_PERSISTENT` | `void SET_AMBIENT_ZONE_LIST_STATE_PERSISTENT(string ambientZone, bool p1, bool p2)` | void |
| `SET_AMBIENT_ZONE_STATE` | `void SET_AMBIENT_ZONE_STATE(string zoneName, bool p1, bool p2)` | void |
| `SET_AMBIENT_ZONE_STATE_PERSISTENT` | `void SET_AMBIENT_ZONE_STATE_PERSISTENT(string ambientZone, bool p1, bool p2)` | void |
| `SET_ANIMAL_MOOD` | `void SET_ANIMAL_MOOD(int animal, int mood)` | void |
| `SET_AUDIO_FLAG` | `void SET_AUDIO_FLAG(string flagName, bool toggle)` | void |
| `SET_AUDIO_SCENE_VARIABLE` | `void SET_AUDIO_SCENE_VARIABLE(string scene, string variable, float value)` | void |
| `SET_AUDIO_SCRIPT_CLEANUP_TIME` | `void SET_AUDIO_SCRIPT_CLEANUP_TIME(int time)` | void |
| `SET_AUDIO_SPECIAL_EFFECT_MODE` | `void SET_AUDIO_SPECIAL_EFFECT_MODE(int mode)` | void |
| `SET_AUDIO_VEHICLE_PRIORITY` | `void SET_AUDIO_VEHICLE_PRIORITY(int vehicle, object p1)` | void |
| `SET_CONVERSATION_AUDIO_CONTROLLED_BY_ANIM` | `void SET_CONVERSATION_AUDIO_CONTROLLED_BY_ANIM(bool p0)` | void |
| `SET_CONVERSATION_AUDIO_PLACEHOLDER` | `void SET_CONVERSATION_AUDIO_PLACEHOLDER(bool p0)` | void |
| `SET_CUSTOM_RADIO_TRACK_LIST` | `void SET_CUSTOM_RADIO_TRACK_LIST(string radioStation, string trackListName, bool p2)` | void |
| `SET_CUTSCENE_AUDIO_OVERRIDE` | `void SET_CUTSCENE_AUDIO_OVERRIDE(string name)` | void |
| `SET_EMITTER_RADIO_STATION` | `void SET_EMITTER_RADIO_STATION(string emitterName, string radioStation, object p2)` | void |
| `SET_ENTITY_FOR_NULL_CONV_PED` | `void SET_ENTITY_FOR_NULL_CONV_PED(int p0, int entity)` | void |
| `SET_FRONTEND_RADIO_ACTIVE` | `void SET_FRONTEND_RADIO_ACTIVE(bool active)` | void |
| `SET_GLOBAL_RADIO_SIGNAL_LEVEL` | `void SET_GLOBAL_RADIO_SIGNAL_LEVEL(object p0)` | void |
| `SET_GPS_ACTIVE` | `void SET_GPS_ACTIVE(bool active)` | void |
| `SET_HORN_ENABLED` | `void SET_HORN_ENABLED(int vehicle, bool toggle)` | void |
| `SET_HORN_PERMANENTLY_ON` | `void SET_HORN_PERMANENTLY_ON(int vehicle)` | void |
| `SET_HORN_PERMANENTLY_ON_TIME` | `void SET_HORN_PERMANENTLY_ON_TIME(int vehicle, float time)` | void |
| `SET_INDIVIDUAL_PORTAL_SETTINGS_OVERRIDE` | `void SET_INDIVIDUAL_PORTAL_SETTINGS_OVERRIDE(uint interiorNameHash, int roomIndex, int doorIndex, string newPortalSettingsName)` | void |
| `SET_INITIAL_PLAYER_STATION` | `void SET_INITIAL_PLAYER_STATION(string radioStation)` | void |
| `SET_MICROPHONE_POSITION` | `void SET_MICROPHONE_POSITION(bool toggle, float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3)` | void |
| `SET_MOBILE_PHONE_RADIO_STATE` | `void SET_MOBILE_PHONE_RADIO_STATE(bool state)` | void |
| `SET_MOBILE_RADIO_ENABLED_DURING_GAMEPLAY` | `void SET_MOBILE_RADIO_ENABLED_DURING_GAMEPLAY(bool toggle)` | void |
| `SET_NEXT_RADIO_TRACK` | `void SET_NEXT_RADIO_TRACK(string radioName, string radioTrack, string p2, string p3)` | void |
| `SET_NO_DUCKING_FOR_CONVERSATION` | `void SET_NO_DUCKING_FOR_CONVERSATION(bool p0)` | void |
| `SET_PED_CLOTH_EVENTS_ENABLED` | `void SET_PED_CLOTH_EVENTS_ENABLED(int ped, bool toggle)` | void |
| `SET_PED_FOOTSTEPS_EVENTS_ENABLED` | `void SET_PED_FOOTSTEPS_EVENTS_ENABLED(int ped, bool toggle)` | void |
| `SET_PED_GENDER` | `void SET_PED_GENDER(int ped, bool p1)` | void |
| `SET_PED_INTERIOR_WALLA_DENSITY` | `void SET_PED_INTERIOR_WALLA_DENSITY(float p0, float p1)` | void |
| `SET_PED_IS_DRUNK` | `void SET_PED_IS_DRUNK(int ped, bool toggle)` | void |
| `SET_PED_RACE_AND_VOICE_GROUP` | `void SET_PED_RACE_AND_VOICE_GROUP(int ped, int p1, uint voiceGroup)` | void |
| `SET_PED_VOICE_FULL` | `void SET_PED_VOICE_FULL(int ped)` | void |
| `SET_PED_VOICE_GROUP` | `void SET_PED_VOICE_GROUP(int ped, uint voiceGroupHash)` | void |
| `SET_PED_VOICE_GROUP_FROM_RACE_TO_PVG` | `void SET_PED_VOICE_GROUP_FROM_RACE_TO_PVG(int ped, uint voiceGroupHash)` | void |
| `SET_PED_WALLA_DENSITY` | `void SET_PED_WALLA_DENSITY(float p0, float p1)` | void |
| `SET_PLAYER_ANGRY` | `void SET_PLAYER_ANGRY(int ped, bool toggle)` | void |
| `SET_PLAYER_VEHICLE_ALARM_AUDIO_ACTIVE` | `void SET_PLAYER_VEHICLE_ALARM_AUDIO_ACTIVE(int vehicle, bool toggle)` | void |
| `SET_PORTAL_SETTINGS_OVERRIDE` | `void SET_PORTAL_SETTINGS_OVERRIDE(string p0, string p1)` | void |
| `SET_POSITIONED_PLAYER_VEHICLE_RADIO_EMITTER_ENABLED` | `void SET_POSITIONED_PLAYER_VEHICLE_RADIO_EMITTER_ENABLED(object p0)` | void |
| `SET_POSITION_FOR_NULL_CONV_PED` | `void SET_POSITION_FOR_NULL_CONV_PED(object p0, float p1, float p2, float p3)` | void |
| `SET_RADIO_AUTO_UNFREEZE` | `void SET_RADIO_AUTO_UNFREEZE(bool toggle)` | void |
| `SET_RADIO_FRONTEND_FADE_TIME` | `void SET_RADIO_FRONTEND_FADE_TIME(float fadeTime)` | void |
| `SET_RADIO_POSITION_AUDIO_MUTE` | `void SET_RADIO_POSITION_AUDIO_MUTE(bool p0)` | void |
| `SET_RADIO_RETUNE_DOWN` | `void SET_RADIO_RETUNE_DOWN()` | void |
| `SET_RADIO_RETUNE_UP` | `void SET_RADIO_RETUNE_UP()` | void |
| `SET_RADIO_STATION_AS_FAVOURITE` | `void SET_RADIO_STATION_AS_FAVOURITE(string radioStation, bool toggle)` | void |
| `SET_RADIO_STATION_MUSIC_ONLY` | `void SET_RADIO_STATION_MUSIC_ONLY(string radioStation, bool toggle)` | void |
| `SET_RADIO_TO_STATION_INDEX` | `void SET_RADIO_TO_STATION_INDEX(int radioStation)` | void |
| `SET_RADIO_TO_STATION_NAME` | `void SET_RADIO_TO_STATION_NAME(string stationName)` | void |
| `SET_RADIO_TRACK` | `void SET_RADIO_TRACK(string radioStation, string radioTrack)` | void |
| `SET_RADIO_TRACK_WITH_START_OFFSET` | `void SET_RADIO_TRACK_WITH_START_OFFSET(string radioStationName, string mixName, int p2)` | void |
| `SET_SCRIPT_UPDATE_DOOR_AUDIO` | `void SET_SCRIPT_UPDATE_DOOR_AUDIO(uint doorHash, bool toggle)` | void |
| `SET_SIREN_BYPASS_MP_DRIVER_CHECK` | `void SET_SIREN_BYPASS_MP_DRIVER_CHECK(int vehicle, bool toggle)` | void |
| `SET_SIREN_CAN_BE_CONTROLLED_BY_AUDIO` | `void SET_SIREN_CAN_BE_CONTROLLED_BY_AUDIO(int vehicle, bool p1)` | void |
| `SET_SIREN_WITH_NO_DRIVER` | `void SET_SIREN_WITH_NO_DRIVER(int vehicle, bool toggle)` | void |
| `SET_SKIP_MINIGUN_SPIN_UP_AUDIO` | `void SET_SKIP_MINIGUN_SPIN_UP_AUDIO(bool p0)` | void |
| `SET_STATIC_EMITTER_ENABLED` | `void SET_STATIC_EMITTER_ENABLED(string emitterName, bool toggle)` | void |
| `SET_USER_RADIO_CONTROL_ENABLED` | `void SET_USER_RADIO_CONTROL_ENABLED(bool toggle)` | void |
| `SET_VARIABLE_ON_SOUND` | `void SET_VARIABLE_ON_SOUND(int soundId, string variable, float p2)` | void |
| `SET_VARIABLE_ON_STREAM` | `void SET_VARIABLE_ON_STREAM(string variable, float p1)` | void |
| `SET_VARIABLE_ON_SYNCH_SCENE_AUDIO` | `void SET_VARIABLE_ON_SYNCH_SCENE_AUDIO(string variableName, float value)` | void |
| `SET_VARIABLE_ON_UNDER_WATER_STREAM` | `void SET_VARIABLE_ON_UNDER_WATER_STREAM(string variableName, float value)` | void |
| `SET_VEHICLE_AUDIO_BODY_DAMAGE_FACTOR` | `void SET_VEHICLE_AUDIO_BODY_DAMAGE_FACTOR(int vehicle, float intensity)` | void |
| `SET_VEHICLE_AUDIO_ENGINE_DAMAGE_FACTOR` | `void SET_VEHICLE_AUDIO_ENGINE_DAMAGE_FACTOR(int vehicle, float damageFactor)` | void |
| `SET_VEHICLE_BOOST_ACTIVE` | `void SET_VEHICLE_BOOST_ACTIVE(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_CONVERSATIONS_PERSIST` | `void SET_VEHICLE_CONVERSATIONS_PERSIST(bool p0, bool p1)` | void |
| `SET_VEHICLE_CONVERSATIONS_PERSIST_NEW` | `void SET_VEHICLE_CONVERSATIONS_PERSIST_NEW(bool p0, bool p1, bool p2)` | void |
| `SET_VEHICLE_FORCE_REVERSE_WARNING` | `void SET_VEHICLE_FORCE_REVERSE_WARNING(object p0, object p1)` | void |
| `SET_VEHICLE_HORN_SOUND_INDEX` | `void SET_VEHICLE_HORN_SOUND_INDEX(int vehicle, int value)` | void |
| `SET_VEHICLE_MISSILE_WARNING_ENABLED` | `void SET_VEHICLE_MISSILE_WARNING_ENABLED(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_RADIO_ENABLED` | `void SET_VEHICLE_RADIO_ENABLED(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_RADIO_LOUD` | `void SET_VEHICLE_RADIO_LOUD(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_STARTUP_REV_SOUND` | `void SET_VEHICLE_STARTUP_REV_SOUND(int vehicle, string p1, string p2)` | void |
| `SET_VEH_FORCED_RADIO_THIS_FRAME` | `void SET_VEH_FORCED_RADIO_THIS_FRAME(int vehicle)` | void |
| `SET_VEH_HAS_NORMAL_RADIO` | `void SET_VEH_HAS_NORMAL_RADIO(int vehicle)` | void |
| `SET_VEH_RADIO_STATION` | `void SET_VEH_RADIO_STATION(int vehicle, string radioStation)` | void |
| `SKIP_RADIO_FORWARD` | `void SKIP_RADIO_FORWARD()` | void |
| `SKIP_TO_NEXT_SCRIPTED_CONVERSATION_LINE` | `void SKIP_TO_NEXT_SCRIPTED_CONVERSATION_LINE()` | void |
| `START_ALARM` | `void START_ALARM(string alarmName, bool p2)` | void |
| `START_AUDIO_SCENE` | `bool START_AUDIO_SCENE(string scene)` | bool |
| `START_PRELOADED_CONVERSATION` | `void START_PRELOADED_CONVERSATION()` | void |
| `START_SCRIPT_CONVERSATION` | `void START_SCRIPT_CONVERSATION(bool p0, bool p1, bool p2, bool p3)` | void |
| `START_SCRIPT_PHONE_CONVERSATION` | `void START_SCRIPT_PHONE_CONVERSATION(bool p0, bool p1)` | void |
| `STOP_ALARM` | `void STOP_ALARM(string alarmName, bool toggle)` | void |
| `STOP_ALL_ALARMS` | `void STOP_ALL_ALARMS(bool stop)` | void |
| `STOP_AUDIO_SCENE` | `void STOP_AUDIO_SCENE(string scene)` | void |
| `STOP_AUDIO_SCENES` | `void STOP_AUDIO_SCENES()` | void |
| `STOP_CURRENT_PLAYING_AMBIENT_SPEECH` | `void STOP_CURRENT_PLAYING_AMBIENT_SPEECH(int ped)` | void |
| `STOP_CURRENT_PLAYING_SPEECH` | `void STOP_CURRENT_PLAYING_SPEECH(int ped)` | void |
| `STOP_CUTSCENE_AUDIO` | `void STOP_CUTSCENE_AUDIO()` | void |
| `STOP_PED_RINGTONE` | `void STOP_PED_RINGTONE(int ped)` | void |
| `STOP_PED_SPEAKING` | `void STOP_PED_SPEAKING(int ped, bool shaking)` | void |
| `STOP_PED_SPEAKING_SYNCED` | `void STOP_PED_SPEAKING_SYNCED(int ped, bool p1)` | void |
| `STOP_SCRIPTED_CONVERSATION` | `int STOP_SCRIPTED_CONVERSATION(bool p0)` | int |
| `STOP_SMOKE_GRENADE_EXPLOSION_SOUNDS` | `void STOP_SMOKE_GRENADE_EXPLOSION_SOUNDS()` | void |
| `STOP_SOUND` | `void STOP_SOUND(int soundId)` | void |
| `STOP_STREAM` | `void STOP_STREAM()` | void |
| `STOP_SYNCHRONIZED_AUDIO_EVENT` | `bool STOP_SYNCHRONIZED_AUDIO_EVENT(int sceneID)` | bool |
| `TRIGGER_MUSIC_EVENT` | `bool TRIGGER_MUSIC_EVENT(string eventName)` | bool |
| `TRIGGER_SIREN_AUDIO` | `void TRIGGER_SIREN_AUDIO(int vehicle)` | void |
| `UNBLOCK_SPEECH_CONTEXT_GROUP` | `void UNBLOCK_SPEECH_CONTEXT_GROUP(string p0)` | void |
| `UNFREEZE_RADIO_STATION` | `void UNFREEZE_RADIO_STATION(string radioStation)` | void |
| `UNHINT_AMBIENT_AUDIO_BANK` | `void UNHINT_AMBIENT_AUDIO_BANK()` | void |
| `UNHINT_NAMED_SCRIPT_AUDIO_BANK` | `void UNHINT_NAMED_SCRIPT_AUDIO_BANK(string audioBank)` | void |
| `UNHINT_SCRIPT_AUDIO_BANK` | `void UNHINT_SCRIPT_AUDIO_BANK()` | void |
| `UNLOCK_MISSION_NEWS_STORY` | `void UNLOCK_MISSION_NEWS_STORY(int newsStory)` | void |
| `UNLOCK_RADIO_STATION_TRACK_LIST` | `void UNLOCK_RADIO_STATION_TRACK_LIST(string radioStation, string trackListName)` | void |
| `UNREGISTER_SCRIPT_WITH_AUDIO` | `void UNREGISTER_SCRIPT_WITH_AUDIO()` | void |
| `UNREQUEST_TENNIS_BANKS` | `void UNREQUEST_TENNIS_BANKS()` | void |
| `UPDATE_SOUND_COORD` | `void UPDATE_SOUND_COORD(int soundId, float x, float y, float z)` | void |
| `UPDATE_UNLOCKABLE_DJ_RADIO_TRACKS` | `void UPDATE_UNLOCKABLE_DJ_RADIO_TRACKS(bool enableMixes)` | void |
| `USE_FOOTSTEP_SCRIPT_SWEETENERS` | `void USE_FOOTSTEP_SCRIPT_SWEETENERS(int ped, bool p1, uint hash)` | void |
| `USE_SIREN_AS_HORN` | `void USE_SIREN_AS_HORN(int vehicle, bool toggle)` | void |
| `_ENABLE_DRAG_RACE_STATIONARY_WARNING_SOUNDS` | `void _ENABLE_DRAG_RACE_STATIONARY_WARNING_SOUNDS(int vehicle, bool enable)` | void |
| `_FORCE_VEHICLE_ENGINE_SYNTH` | `void _FORCE_VEHICLE_ENGINE_SYNTH(int vehicle, bool force)` | void |

---

## NETWORK

| 函数名 | 签名 | 返回值 |
|--------|------|--------|
| `ACTIVATE_DAMAGE_TRACKER_ON_NETWORK_ID` | `void ACTIVATE_DAMAGE_TRACKER_ON_NETWORK_ID(int netID, bool toggle)` | void |
| `ACTIVATE_DAMAGE_TRACKER_ON_PLAYER` | `void ACTIVATE_DAMAGE_TRACKER_ON_PLAYER(int player, bool toggle)` | void |
| `ARE_CUTSCENE_ENTITIES_NETWORKED` | `bool ARE_CUTSCENE_ENTITIES_NETWORKED()` | bool |
| `BAD_SPORT_PLAYER_LEFT_DETECTED` | `bool BAD_SPORT_PLAYER_LEFT_DETECTED(ref object gamerHandle, int event, int amountReceived)` | bool |
| `CAN_REGISTER_MISSION_DOORS` | `bool CAN_REGISTER_MISSION_DOORS(object p0)` | bool |
| `CAN_REGISTER_MISSION_ENTITIES` | `bool CAN_REGISTER_MISSION_ENTITIES(int ped_amt, int vehicle_amt, int object_amt, int pickup_amt)` | bool |
| `CAN_REGISTER_MISSION_OBJECTS` | `bool CAN_REGISTER_MISSION_OBJECTS(int amount)` | bool |
| `CAN_REGISTER_MISSION_PEDS` | `bool CAN_REGISTER_MISSION_PEDS(int amount)` | bool |
| `CAN_REGISTER_MISSION_PICKUPS` | `bool CAN_REGISTER_MISSION_PICKUPS(int amount)` | bool |
| `CAN_REGISTER_MISSION_VEHICLES` | `bool CAN_REGISTER_MISSION_VEHICLES(int amount)` | bool |
| `CLEAR_SERVICE_EVENT_ARGUMENTS` | `void CLEAR_SERVICE_EVENT_ARGUMENTS()` | void |
| `CLOUD_CHECK_AVAILABILITY` | `void CLOUD_CHECK_AVAILABILITY()` | void |
| `CLOUD_DELETE_MEMBER_FILE` | `int CLOUD_DELETE_MEMBER_FILE(string p0)` | int |
| `CLOUD_DID_REQUEST_SUCCEED` | `bool CLOUD_DID_REQUEST_SUCCEED(int requestId)` | bool |
| `CLOUD_GET_AVAILABILITY_CHECK_RESULT` | `bool CLOUD_GET_AVAILABILITY_CHECK_RESULT()` | bool |
| `CLOUD_HAS_REQUEST_COMPLETED` | `bool CLOUD_HAS_REQUEST_COMPLETED(int requestId)` | bool |
| `CLOUD_IS_CHECKING_AVAILABILITY` | `bool CLOUD_IS_CHECKING_AVAILABILITY()` | bool |
| `CONVERT_POSIX_TIME` | `void CONVERT_POSIX_TIME(int posixTime, ref object timeStructure)` | void |
| `DELAY_MP_STORE_OPEN` | `void DELAY_MP_STORE_OPEN()` | void |
| `FACEBOOK_CAN_POST_TO_FACEBOOK` | `bool FACEBOOK_CAN_POST_TO_FACEBOOK()` | bool |
| `FACEBOOK_DID_POST_SUCCEED` | `bool FACEBOOK_DID_POST_SUCCEED()` | bool |
| `FACEBOOK_HAS_POST_COMPLETED` | `bool FACEBOOK_HAS_POST_COMPLETED()` | bool |
| `FACEBOOK_POST_COMPLETED_HEIST` | `bool FACEBOOK_POST_COMPLETED_HEIST(string heistName, int cashEarned, int xpEarned)` | bool |
| `FACEBOOK_POST_COMPLETED_MILESTONE` | `bool FACEBOOK_POST_COMPLETED_MILESTONE(int milestoneId)` | bool |
| `FACEBOOK_POST_CREATE_CHARACTER` | `bool FACEBOOK_POST_CREATE_CHARACTER()` | bool |
| `FADE_OUT_LOCAL_PLAYER` | `void FADE_OUT_LOCAL_PLAYER(bool p0)` | void |
| `FILLOUT_PM_PLAYER_LIST` | `bool FILLOUT_PM_PLAYER_LIST(ref object gamerHandle, object p1, object p2)` | bool |
| `FILLOUT_PM_PLAYER_LIST_WITH_NAMES` | `bool FILLOUT_PM_PLAYER_LIST_WITH_NAMES(ref object p0, ref object p1, object p2, object p3)` | bool |
| `GET_CLOUD_TIME_AS_INT` | `int GET_CLOUD_TIME_AS_INT()` | int |
| `GET_CLOUD_TIME_AS_STRING` | `string GET_CLOUD_TIME_AS_STRING()` | string |
| `GET_COMMERCE_ITEM_CAT` | `string GET_COMMERCE_ITEM_CAT(int index, int index2)` | string |
| `GET_COMMERCE_ITEM_ID` | `string GET_COMMERCE_ITEM_ID(int index)` | string |
| `GET_COMMERCE_ITEM_NAME` | `string GET_COMMERCE_ITEM_NAME(int index)` | string |
| `GET_COMMERCE_ITEM_NUM_CATS` | `int GET_COMMERCE_ITEM_NUM_CATS(int index)` | int |
| `GET_COMMERCE_ITEM_TEXTURENAME` | `string GET_COMMERCE_ITEM_TEXTURENAME(int index)` | string |
| `GET_COMMERCE_PRODUCT_PRICE` | `string GET_COMMERCE_PRODUCT_PRICE(int index)` | string |
| `GET_CONTENT_TO_LOAD_TYPE` | `int GET_CONTENT_TO_LOAD_TYPE()` | int |
| `GET_IS_LAUNCH_FROM_LIVE_AREA` | `bool GET_IS_LAUNCH_FROM_LIVE_AREA()` | bool |
| `GET_IS_LIVE_AREA_LAUNCH_WITH_CONTENT` | `bool GET_IS_LIVE_AREA_LAUNCH_WITH_CONTENT()` | bool |
| `GET_MAX_NUM_NETWORK_OBJECTS` | `int GET_MAX_NUM_NETWORK_OBJECTS()` | int |
| `GET_MAX_NUM_NETWORK_PEDS` | `int GET_MAX_NUM_NETWORK_PEDS()` | int |
| `GET_MAX_NUM_NETWORK_PICKUPS` | `int GET_MAX_NUM_NETWORK_PICKUPS()` | int |
| `GET_MAX_NUM_NETWORK_VEHICLES` | `int GET_MAX_NUM_NETWORK_VEHICLES()` | int |
| `GET_NETWORK_TIME` | `int GET_NETWORK_TIME()` | int |
| `GET_NETWORK_TIME_ACCURATE` | `int GET_NETWORK_TIME_ACCURATE()` | int |
| `GET_NUM_COMMERCE_ITEMS` | `int GET_NUM_COMMERCE_ITEMS()` | int |
| `GET_NUM_CREATED_MISSION_OBJECTS` | `int GET_NUM_CREATED_MISSION_OBJECTS(bool p0)` | int |
| `GET_NUM_CREATED_MISSION_PEDS` | `int GET_NUM_CREATED_MISSION_PEDS(bool p0)` | int |
| `GET_NUM_CREATED_MISSION_VEHICLES` | `int GET_NUM_CREATED_MISSION_VEHICLES(bool p0)` | int |
| `GET_NUM_RESERVED_MISSION_OBJECTS` | `int GET_NUM_RESERVED_MISSION_OBJECTS(bool p0, object p1)` | int |
| `GET_NUM_RESERVED_MISSION_PEDS` | `int GET_NUM_RESERVED_MISSION_PEDS(bool p0, object p1)` | int |
| `GET_NUM_RESERVED_MISSION_VEHICLES` | `int GET_NUM_RESERVED_MISSION_VEHICLES(bool p0, object p1)` | int |
| `GET_ONLINE_VERSION` | `string GET_ONLINE_VERSION()` | string |
| `GET_RESERVED_MISSION_ENTITIES_IN_AREA` | `void GET_RESERVED_MISSION_ENTITIES_IN_AREA(float x, float y, float z, object p3, ref object out1, ref object out2, ref object out3)` | void |
| `GET_STATUS_OF_TEXTURE_DOWNLOAD` | `int GET_STATUS_OF_TEXTURE_DOWNLOAD(int p0)` | int |
| `GET_TIME_AS_STRING` | `string GET_TIME_AS_STRING(int time)` | string |
| `GET_TIME_DIFFERENCE` | `int GET_TIME_DIFFERENCE(int timeA, int timeB)` | int |
| `GET_TIME_OFFSET` | `int GET_TIME_OFFSET(int timeA, int timeB)` | int |
| `GET_USER_PREMIUM_ACCESS` | `int GET_USER_PREMIUM_ACCESS()` | int |
| `GET_USER_STARTER_ACCESS` | `int GET_USER_STARTER_ACCESS()` | int |
| `HAS_NETWORK_TIME_STARTED` | `bool HAS_NETWORK_TIME_STARTED()` | bool |
| `IS_COMMERCE_DATA_FETCH_IN_PROGRESS` | `bool IS_COMMERCE_DATA_FETCH_IN_PROGRESS()` | bool |
| `IS_COMMERCE_DATA_VALID` | `bool IS_COMMERCE_DATA_VALID()` | bool |
| `IS_COMMERCE_STORE_OPEN` | `bool IS_COMMERCE_STORE_OPEN()` | bool |
| `IS_DAMAGE_TRACKER_ACTIVE_ON_NETWORK_ID` | `bool IS_DAMAGE_TRACKER_ACTIVE_ON_NETWORK_ID(int netID)` | bool |
| `IS_DAMAGE_TRACKER_ACTIVE_ON_PLAYER` | `bool IS_DAMAGE_TRACKER_ACTIVE_ON_PLAYER(int player)` | bool |
| `IS_ENTITY_A_GHOST` | `bool IS_ENTITY_A_GHOST(int entity)` | bool |
| `IS_ENTITY_IN_GHOST_COLLISION` | `bool IS_ENTITY_IN_GHOST_COLLISION(int entity)` | bool |
| `IS_NETWORK_ID_OWNED_BY_PARTICIPANT` | `bool IS_NETWORK_ID_OWNED_BY_PARTICIPANT(int netId)` | bool |
| `IS_NETWORK_VEHICLE_RUNNING_RESPOT_TIMER` | `bool IS_NETWORK_VEHICLE_RUNNING_RESPOT_TIMER(int networkID)` | bool |
| `IS_OBJECT_REASSIGNMENT_IN_PROGRESS` | `bool IS_OBJECT_REASSIGNMENT_IN_PROGRESS()` | bool |
| `IS_PLAYER_IN_CUTSCENE` | `bool IS_PLAYER_IN_CUTSCENE(int player)` | bool |
| `IS_SPHERE_VISIBLE_TO_ANOTHER_MACHINE` | `bool IS_SPHERE_VISIBLE_TO_ANOTHER_MACHINE(float p0, float p1, float p2, float p3)` | bool |
| `IS_SPHERE_VISIBLE_TO_PLAYER` | `bool IS_SPHERE_VISIBLE_TO_PLAYER(object p0, float p1, float p2, float p3, float p4)` | bool |
| `IS_STORE_AVAILABLE_TO_USER` | `bool IS_STORE_AVAILABLE_TO_USER()` | bool |
| `IS_TIME_EQUAL_TO` | `bool IS_TIME_EQUAL_TO(int timeA, int timeB)` | bool |
| `IS_TIME_LESS_THAN` | `bool IS_TIME_LESS_THAN(int timeA, int timeB)` | bool |
| `IS_TIME_MORE_THAN` | `bool IS_TIME_MORE_THAN(int timeA, int timeB)` | bool |
| `IS_USER_OLD_ENOUGH_TO_ACCESS_STORE` | `bool IS_USER_OLD_ENOUGH_TO_ACCESS_STORE()` | bool |
| `LOBBY_AUTO_MULTIPLAYER_EVENT` | `bool LOBBY_AUTO_MULTIPLAYER_EVENT()` | bool |
| `LOBBY_AUTO_MULTIPLAYER_FREEMODE` | `bool LOBBY_AUTO_MULTIPLAYER_FREEMODE()` | bool |
| `LOBBY_AUTO_MULTIPLAYER_MENU` | `bool LOBBY_AUTO_MULTIPLAYER_MENU()` | bool |
| `LOBBY_AUTO_MULTIPLAYER_RANDOM_JOB` | `bool LOBBY_AUTO_MULTIPLAYER_RANDOM_JOB()` | bool |
| `LOBBY_SET_AUTO_MP_RANDOM_JOB` | `void LOBBY_SET_AUTO_MP_RANDOM_JOB(bool toggle)` | void |
| `LOBBY_SET_AUTO_MULTIPLAYER` | `void LOBBY_SET_AUTO_MULTIPLAYER(bool toggle)` | void |
| `LOBBY_SET_AUTO_MULTIPLAYER_EVENT` | `void LOBBY_SET_AUTO_MULTIPLAYER_EVENT(bool toggle)` | void |
| `NETWORK_ACCEPT_PRESENCE_INVITE` | `bool NETWORK_ACCEPT_PRESENCE_INVITE(int p0)` | bool |
| `NETWORK_ACCESS_TUNABLE_BOOL` | `bool NETWORK_ACCESS_TUNABLE_BOOL(string tunableContext, string tunableName)` | bool |
| `NETWORK_ACCESS_TUNABLE_BOOL_HASH` | `bool NETWORK_ACCESS_TUNABLE_BOOL_HASH(uint tunableContext, uint tunableName)` | bool |
| `NETWORK_ACCESS_TUNABLE_BOOL_MODIFICATION_DETECTION_REGISTRATION_HASH` | `bool NETWORK_ACCESS_TUNABLE_BOOL_MODIFICATION_DETECTION_REGISTRATION_HASH(uint contextHash, uint nameHash, ref bool value)` | bool |
| `NETWORK_ACCESS_TUNABLE_FLOAT` | `bool NETWORK_ACCESS_TUNABLE_FLOAT(string tunableContext, string tunableName, ref float value)` | bool |
| `NETWORK_ACCESS_TUNABLE_FLOAT_HASH` | `bool NETWORK_ACCESS_TUNABLE_FLOAT_HASH(uint tunableContext, uint tunableName, ref float value)` | bool |
| `NETWORK_ACCESS_TUNABLE_FLOAT_MODIFICATION_DETECTION_REGISTRATION_HASH` | `bool NETWORK_ACCESS_TUNABLE_FLOAT_MODIFICATION_DETECTION_REGISTRATION_HASH(uint contextHash, uint nameHash, ref float value)` | bool |
| `NETWORK_ACCESS_TUNABLE_INT` | `bool NETWORK_ACCESS_TUNABLE_INT(string tunableContext, string tunableName, ref int value)` | bool |
| `NETWORK_ACCESS_TUNABLE_INT_HASH` | `bool NETWORK_ACCESS_TUNABLE_INT_HASH(uint tunableContext, uint tunableName, ref int value)` | bool |
| `NETWORK_ACCESS_TUNABLE_INT_MODIFICATION_DETECTION_REGISTRATION_HASH` | `bool NETWORK_ACCESS_TUNABLE_INT_MODIFICATION_DETECTION_REGISTRATION_HASH(uint contextHash, uint nameHash, ref int value)` | bool |
| `NETWORK_ACCESS_TUNABLE_MODIFICATION_DETECTION_CLEAR` | `bool NETWORK_ACCESS_TUNABLE_MODIFICATION_DETECTION_CLEAR()` | bool |
| `NETWORK_ACTION_FOLLOW_INVITE` | `bool NETWORK_ACTION_FOLLOW_INVITE()` | bool |
| `NETWORK_ADD_CLIENT_ENTITY_ANGLED_AREA` | `int NETWORK_ADD_CLIENT_ENTITY_ANGLED_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float radius)` | int |
| `NETWORK_ADD_CLIENT_ENTITY_AREA` | `int NETWORK_ADD_CLIENT_ENTITY_AREA(float x1, float y1, float z1, float x2, float y2, float z2)` | int |
| `NETWORK_ADD_ENTITY_ANGLED_AREA` | `int NETWORK_ADD_ENTITY_ANGLED_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float width)` | int |
| `NETWORK_ADD_ENTITY_AREA` | `int NETWORK_ADD_ENTITY_AREA(float x1, float y1, float z1, float x2, float y2, float z2)` | int |
| `NETWORK_ADD_ENTITY_TO_SYNCHRONISED_SCENE` | `void NETWORK_ADD_ENTITY_TO_SYNCHRONISED_SCENE(int entity, int netScene, string animDict, string animName, float speed, float speedMulitiplier, int flag)` | void |
| `NETWORK_ADD_FOLLOWERS` | `void NETWORK_ADD_FOLLOWERS(ref int p0, int p1)` | void |
| `NETWORK_ADD_FRIEND` | `bool NETWORK_ADD_FRIEND(ref object gamerHandle, string message)` | bool |
| `NETWORK_ADD_INVALID_OBJECT_MODEL` | `void NETWORK_ADD_INVALID_OBJECT_MODEL(uint modelHash, object p1)` | void |
| `NETWORK_ADD_MAP_ENTITY_TO_SYNCHRONISED_SCENE` | `void NETWORK_ADD_MAP_ENTITY_TO_SYNCHRONISED_SCENE(int netScene, uint modelHash, float x, float y, float z, float p5, string p6, float p7, float p8, int flags)` | void |
| `NETWORK_ADD_PED_TO_SYNCHRONISED_SCENE` | `void NETWORK_ADD_PED_TO_SYNCHRONISED_SCENE(int ped, int netScene, string animDict, string animnName, float speed, float speedMultiplier, int duration, int flag, float playbackRate, object p9)` | void |
| `NETWORK_ADD_PED_TO_SYNCHRONISED_SCENE_WITH_IK` | `void NETWORK_ADD_PED_TO_SYNCHRONISED_SCENE_WITH_IK(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9)` | void |
| `NETWORK_ADD_SYNCHRONISED_SCENE_CAMERA` | `void NETWORK_ADD_SYNCHRONISED_SCENE_CAMERA(int netScene, string animDict, string animName)` | void |
| `NETWORK_ALLOW_CLONING_WHILE_IN_TUTORIAL` | `void NETWORK_ALLOW_CLONING_WHILE_IN_TUTORIAL(object p0, object p1)` | void |
| `NETWORK_ALLOW_GANG_TO_JOIN_TUTORIAL_SESSION` | `void NETWORK_ALLOW_GANG_TO_JOIN_TUTORIAL_SESSION(int teamId, int instanceId)` | void |
| `NETWORK_ALLOW_INVITE_PROCESS_IN_PLAYER_SWITCH` | `void NETWORK_ALLOW_INVITE_PROCESS_IN_PLAYER_SWITCH(bool p0)` | void |
| `NETWORK_ALLOW_REMOTE_ATTACHMENT_MODIFICATION` | `void NETWORK_ALLOW_REMOTE_ATTACHMENT_MODIFICATION(int entity, bool toggle)` | void |
| `NETWORK_ALLOW_REMOTE_SYNCED_SCENE_LOCAL_PLAYER_REQUESTS` | `void NETWORK_ALLOW_REMOTE_SYNCED_SCENE_LOCAL_PLAYER_REQUESTS(object p0)` | void |
| `NETWORK_AM_I_BLOCKED_BY_GAMER` | `bool NETWORK_AM_I_BLOCKED_BY_GAMER(ref object gamerHandle)` | bool |
| `NETWORK_AM_I_BLOCKED_BY_PLAYER` | `bool NETWORK_AM_I_BLOCKED_BY_PLAYER(int player)` | bool |
| `NETWORK_AM_I_MUTED_BY_GAMER` | `bool NETWORK_AM_I_MUTED_BY_GAMER(ref object gamerHandle)` | bool |
| `NETWORK_AM_I_MUTED_BY_PLAYER` | `bool NETWORK_AM_I_MUTED_BY_PLAYER(int player)` | bool |
| `NETWORK_APPLY_CACHED_PLAYER_HEAD_BLEND_DATA` | `bool NETWORK_APPLY_CACHED_PLAYER_HEAD_BLEND_DATA(int ped, int player)` | bool |
| `NETWORK_APPLY_PED_SCAR_DATA` | `void NETWORK_APPLY_PED_SCAR_DATA(int ped, int p1)` | void |
| `NETWORK_APPLY_TRANSITION_PARAMETER` | `void NETWORK_APPLY_TRANSITION_PARAMETER(int p0, int p1)` | void |
| `NETWORK_APPLY_TRANSITION_PARAMETER_STRING` | `void NETWORK_APPLY_TRANSITION_PARAMETER_STRING(int p0, string string, bool p2)` | void |
| `NETWORK_APPLY_VOICE_PROXIMITY_OVERRIDE` | `void NETWORK_APPLY_VOICE_PROXIMITY_OVERRIDE(float x, float y, float z)` | void |
| `NETWORK_ARE_HANDLES_THE_SAME` | `bool NETWORK_ARE_HANDLES_THE_SAME(ref object gamerHandle1, ref object gamerHandle2)` | bool |
| `NETWORK_ARE_PLAYERS_IN_SAME_TUTORIAL_SESSION` | `bool NETWORK_ARE_PLAYERS_IN_SAME_TUTORIAL_SESSION(int player, int index)` | bool |
| `NETWORK_ARE_SOCIAL_CLUB_POLICIES_CURRENT` | `bool NETWORK_ARE_SOCIAL_CLUB_POLICIES_CURRENT()` | bool |
| `NETWORK_ARE_TRANSITION_DETAILS_VALID` | `bool NETWORK_ARE_TRANSITION_DETAILS_VALID(object p0)` | bool |
| `NETWORK_ATTACH_SYNCHRONISED_SCENE_TO_ENTITY` | `void NETWORK_ATTACH_SYNCHRONISED_SCENE_TO_ENTITY(int netScene, int entity, int bone)` | void |
| `NETWORK_BAIL` | `void NETWORK_BAIL(int p0, int p1, int p2)` | void |
| `NETWORK_BAIL_TRANSITION` | `void NETWORK_BAIL_TRANSITION(int p0, int p1, int p2)` | void |
| `NETWORK_BLOCK_INVITES` | `void NETWORK_BLOCK_INVITES(bool toggle)` | void |
| `NETWORK_BLOCK_JOIN_QUEUE_INVITES` | `void NETWORK_BLOCK_JOIN_QUEUE_INVITES(bool toggle)` | void |
| `NETWORK_BLOCK_PROXY_MIGRATION_BETWEEN_TUTORIAL_SESSIONS` | `void NETWORK_BLOCK_PROXY_MIGRATION_BETWEEN_TUTORIAL_SESSIONS(object p0)` | void |
| `NETWORK_CACHE_LOCAL_PLAYER_HEAD_BLEND_DATA` | `void NETWORK_CACHE_LOCAL_PLAYER_HEAD_BLEND_DATA()` | void |
| `NETWORK_CANCEL_RESPAWN_SEARCH` | `void NETWORK_CANCEL_RESPAWN_SEARCH()` | void |
| `NETWORK_CANCEL_TRANSITION_MATCHMAKING` | `void NETWORK_CANCEL_TRANSITION_MATCHMAKING()` | void |
| `NETWORK_CAN_ACCESS_MULTIPLAYER` | `bool NETWORK_CAN_ACCESS_MULTIPLAYER(ref int loadingState)` | bool |
| `NETWORK_CAN_BAIL` | `bool NETWORK_CAN_BAIL()` | bool |
| `NETWORK_CAN_COMMUNICATE_WITH_GAMER` | `bool NETWORK_CAN_COMMUNICATE_WITH_GAMER(ref object gamerHandle)` | bool |
| `NETWORK_CAN_ENTER_MULTIPLAYER` | `bool NETWORK_CAN_ENTER_MULTIPLAYER()` | bool |
| `NETWORK_CAN_GAMER_PLAY_MULTIPLAYER_WITH_ME` | `bool NETWORK_CAN_GAMER_PLAY_MULTIPLAYER_WITH_ME(ref object gamerHandle)` | bool |
| `NETWORK_CAN_PLAY_MULTIPLAYER_WITH_GAMER` | `bool NETWORK_CAN_PLAY_MULTIPLAYER_WITH_GAMER(ref object gamerHandle)` | bool |
| `NETWORK_CAN_QUEUE_FOR_PREVIOUS_SESSION_JOIN` | `bool NETWORK_CAN_QUEUE_FOR_PREVIOUS_SESSION_JOIN()` | bool |
| `NETWORK_CAN_RECEIVE_LOCAL_INVITE` | `bool NETWORK_CAN_RECEIVE_LOCAL_INVITE(ref object gamerHandle)` | bool |
| `NETWORK_CAN_SEND_LOCAL_INVITE` | `bool NETWORK_CAN_SEND_LOCAL_INVITE(ref object gamerHandle)` | bool |
| `NETWORK_CAN_SESSION_END` | `bool NETWORK_CAN_SESSION_END()` | bool |
| `NETWORK_CAN_SET_WAYPOINT` | `bool NETWORK_CAN_SET_WAYPOINT()` | bool |
| `NETWORK_CAN_TEXT_CHAT_WITH_GAMER` | `bool NETWORK_CAN_TEXT_CHAT_WITH_GAMER(ref object gamerHandle)` | bool |
| `NETWORK_CAN_VIEW_GAMER_USER_CONTENT` | `bool NETWORK_CAN_VIEW_GAMER_USER_CONTENT(ref object gamerHandle)` | bool |
| `NETWORK_CHANGE_TRANSITION_SLOTS` | `void NETWORK_CHANGE_TRANSITION_SLOTS(object p0, bool p1)` | void |
| `NETWORK_CHECK_CAN_ACCESS_AND_ALERT` | `bool NETWORK_CHECK_CAN_ACCESS_AND_ALERT()` | bool |
| `NETWORK_CHECK_COMMUNICATION_PRIVILEGES` | `bool NETWORK_CHECK_COMMUNICATION_PRIVILEGES(int p0, int p1, bool p2)` | bool |
| `NETWORK_CHECK_DATA_MANAGER_FOR_HANDLE` | `bool NETWORK_CHECK_DATA_MANAGER_FOR_HANDLE(object p0, ref object gamerHandle)` | bool |
| `NETWORK_CHECK_DATA_MANAGER_SUCCEEDED_FOR_HANDLE` | `bool NETWORK_CHECK_DATA_MANAGER_SUCCEEDED_FOR_HANDLE(int p0, ref object gamerHandle)` | bool |
| `NETWORK_CHECK_ONLINE_PRIVILEGES` | `bool NETWORK_CHECK_ONLINE_PRIVILEGES(object p0, bool p1)` | bool |
| `NETWORK_CHECK_PRIVILEGES` | `bool NETWORK_CHECK_PRIVILEGES(object p0, object p1, object p2)` | bool |
| `NETWORK_CHECK_ROS_LINK_WENTDOWN_NOT_NET` | `bool NETWORK_CHECK_ROS_LINK_WENTDOWN_NOT_NET()` | bool |
| `NETWORK_CHECK_TEXT_COMMUNICATION_PRIVILEGES` | `bool NETWORK_CHECK_TEXT_COMMUNICATION_PRIVILEGES(object p0, object p1, object p2)` | bool |
| `NETWORK_CHECK_USER_CONTENT_PRIVILEGES` | `bool NETWORK_CHECK_USER_CONTENT_PRIVILEGES(int p0, int p1, bool p2)` | bool |
| `NETWORK_CLAN_ANY_DOWNLOAD_MEMBERSHIP_PENDING` | `bool NETWORK_CLAN_ANY_DOWNLOAD_MEMBERSHIP_PENDING()` | bool |
| `NETWORK_CLAN_CREWINFO_GET_CREWRANKTITLE` | `bool NETWORK_CLAN_CREWINFO_GET_CREWRANKTITLE(int p0, string p1)` | bool |
| `NETWORK_CLAN_CREWINFO_GET_STRING_VALUE` | `bool NETWORK_CLAN_CREWINFO_GET_STRING_VALUE(string animDict, string animName)` | bool |
| `NETWORK_CLAN_DOWNLOAD_MEMBERSHIP` | `bool NETWORK_CLAN_DOWNLOAD_MEMBERSHIP(ref object gamerHandle)` | bool |
| `NETWORK_CLAN_DOWNLOAD_MEMBERSHIP_PENDING` | `bool NETWORK_CLAN_DOWNLOAD_MEMBERSHIP_PENDING(ref object p0)` | bool |
| `NETWORK_CLAN_GET_EMBLEM_TXD_NAME` | `bool NETWORK_CLAN_GET_EMBLEM_TXD_NAME(ref object netHandle, string txdName)` | bool |
| `NETWORK_CLAN_GET_LOCAL_MEMBERSHIPS_COUNT` | `int NETWORK_CLAN_GET_LOCAL_MEMBERSHIPS_COUNT()` | int |
| `NETWORK_CLAN_GET_MEMBERSHIP` | `bool NETWORK_CLAN_GET_MEMBERSHIP(ref int p0, ref object clanMembership, int p2)` | bool |
| `NETWORK_CLAN_GET_MEMBERSHIP_COUNT` | `int NETWORK_CLAN_GET_MEMBERSHIP_COUNT(ref int p0)` | int |
| `NETWORK_CLAN_GET_MEMBERSHIP_DESC` | `bool NETWORK_CLAN_GET_MEMBERSHIP_DESC(ref object memberDesc, int p1)` | bool |
| `NETWORK_CLAN_GET_MEMBERSHIP_VALID` | `bool NETWORK_CLAN_GET_MEMBERSHIP_VALID(ref int p0, object p1)` | bool |
| `NETWORK_CLAN_GET_UI_FORMATTED_TAG` | `void NETWORK_CLAN_GET_UI_FORMATTED_TAG(ref object clanDesc, int bufferSize, string formattedTag)` | void |
| `NETWORK_CLAN_HAS_CREWINFO_METADATA_BEEN_RECEIVED` | `bool NETWORK_CLAN_HAS_CREWINFO_METADATA_BEEN_RECEIVED()` | bool |
| `NETWORK_CLAN_IS_EMBLEM_READY` | `bool NETWORK_CLAN_IS_EMBLEM_READY(object p0, ref object p1)` | bool |
| `NETWORK_CLAN_IS_ROCKSTAR_CLAN` | `bool NETWORK_CLAN_IS_ROCKSTAR_CLAN(ref object clanDesc, int bufferSize)` | bool |
| `NETWORK_CLAN_JOIN` | `bool NETWORK_CLAN_JOIN(int clanDesc)` | bool |
| `NETWORK_CLAN_PLAYER_GET_DESC` | `bool NETWORK_CLAN_PLAYER_GET_DESC(ref object clanDesc, int bufferSize, ref object gamerHandle)` | bool |
| `NETWORK_CLAN_PLAYER_IS_ACTIVE` | `bool NETWORK_CLAN_PLAYER_IS_ACTIVE(ref object gamerHandle)` | bool |
| `NETWORK_CLAN_RELEASE_EMBLEM` | `void NETWORK_CLAN_RELEASE_EMBLEM(object p0)` | void |
| `NETWORK_CLAN_REMOTE_MEMBERSHIPS_ARE_IN_CACHE` | `bool NETWORK_CLAN_REMOTE_MEMBERSHIPS_ARE_IN_CACHE(ref int p0)` | bool |
| `NETWORK_CLAN_REQUEST_EMBLEM` | `bool NETWORK_CLAN_REQUEST_EMBLEM(object p0)` | bool |
| `NETWORK_CLAN_SERVICE_IS_VALID` | `bool NETWORK_CLAN_SERVICE_IS_VALID()` | bool |
| `NETWORK_CLEAR_CLOCK_TIME_OVERRIDE` | `void NETWORK_CLEAR_CLOCK_TIME_OVERRIDE()` | void |
| `NETWORK_CLEAR_FOLLOWERS` | `void NETWORK_CLEAR_FOLLOWERS()` | void |
| `NETWORK_CLEAR_FOLLOW_INVITE` | `bool NETWORK_CLEAR_FOLLOW_INVITE()` | bool |
| `NETWORK_CLEAR_FOUND_GAMERS` | `void NETWORK_CLEAR_FOUND_GAMERS()` | void |
| `NETWORK_CLEAR_GET_GAMER_STATUS` | `void NETWORK_CLEAR_GET_GAMER_STATUS()` | void |
| `NETWORK_CLEAR_GROUP_ACTIVITY` | `void NETWORK_CLEAR_GROUP_ACTIVITY()` | void |
| `NETWORK_CLEAR_INVALID_OBJECT_MODELS` | `void NETWORK_CLEAR_INVALID_OBJECT_MODELS()` | void |
| `NETWORK_CLEAR_OFFLINE_INVITE_PENDING` | `void NETWORK_CLEAR_OFFLINE_INVITE_PENDING()` | void |
| `NETWORK_CLEAR_QUEUED_JOIN_REQUEST` | `void NETWORK_CLEAR_QUEUED_JOIN_REQUEST()` | void |
| `NETWORK_CLEAR_TRANSITION_CREATOR_HANDLE` | `void NETWORK_CLEAR_TRANSITION_CREATOR_HANDLE()` | void |
| `NETWORK_CLEAR_VOICE_CHANNEL` | `void NETWORK_CLEAR_VOICE_CHANNEL()` | void |
| `NETWORK_CLEAR_VOICE_PROXIMITY_OVERRIDE` | `void NETWORK_CLEAR_VOICE_PROXIMITY_OVERRIDE()` | void |
| `NETWORK_CLOSE_TRANSITION_MATCHMAKING` | `void NETWORK_CLOSE_TRANSITION_MATCHMAKING()` | void |
| `NETWORK_CONCEAL_ENTITY` | `void NETWORK_CONCEAL_ENTITY(int entity, bool toggle)` | void |
| `NETWORK_CONCEAL_PLAYER` | `void NETWORK_CONCEAL_PLAYER(int player, bool toggle, bool p2)` | void |
| `NETWORK_CREATE_SYNCHRONISED_SCENE` | `int NETWORK_CREATE_SYNCHRONISED_SCENE(float x, float y, float z, float xRot, float yRot, float zRot, int rotationOrder, bool useOcclusionPortal, bool looped, float p9, float animTime, float p11)` | int |
| `NETWORK_DID_FIND_GAMERS_SUCCEED` | `bool NETWORK_DID_FIND_GAMERS_SUCCEED()` | bool |
| `NETWORK_DID_GET_GAMER_STATUS_SUCCEED` | `bool NETWORK_DID_GET_GAMER_STATUS_SUCCEED()` | bool |
| `NETWORK_DISABLE_INVINCIBLE_FLASHING` | `void NETWORK_DISABLE_INVINCIBLE_FLASHING(int player, bool toggle)` | void |
| `NETWORK_DISABLE_LEAVE_REMOTE_PED_BEHIND` | `void NETWORK_DISABLE_LEAVE_REMOTE_PED_BEHIND(bool toggle)` | void |
| `NETWORK_DISABLE_PROXIMITY_MIGRATION` | `void NETWORK_DISABLE_PROXIMITY_MIGRATION(int netID)` | void |
| `NETWORK_DISABLE_REALTIME_MULTIPLAYER` | `void NETWORK_DISABLE_REALTIME_MULTIPLAYER()` | void |
| `NETWORK_DISABLE_VOICE_BANDWIDTH_RESTRICTION` | `void NETWORK_DISABLE_VOICE_BANDWIDTH_RESTRICTION(int player)` | void |
| `NETWORK_DISPLAYNAMES_FROM_HANDLES_START` | `int NETWORK_DISPLAYNAMES_FROM_HANDLES_START(ref object p0, object p1)` | int |
| `NETWORK_DOES_ENTITY_EXIST_WITH_NETWORK_ID` | `bool NETWORK_DOES_ENTITY_EXIST_WITH_NETWORK_ID(int netId)` | bool |
| `NETWORK_DOES_NETWORK_ID_EXIST` | `bool NETWORK_DOES_NETWORK_ID_EXIST(int netId)` | bool |
| `NETWORK_DOES_TUNABLE_EXIST` | `bool NETWORK_DOES_TUNABLE_EXIST(string tunableContext, string tunableName)` | bool |
| `NETWORK_DOES_TUNABLE_EXIST_HASH` | `bool NETWORK_DOES_TUNABLE_EXIST_HASH(uint tunableContext, uint tunableName)` | bool |
| `NETWORK_DO_TRANSITION_QUICKMATCH` | `bool NETWORK_DO_TRANSITION_QUICKMATCH(object p0, object p1, object p2, object p3, object p4, object p5)` | bool |
| `NETWORK_DO_TRANSITION_QUICKMATCH_ASYNC` | `bool NETWORK_DO_TRANSITION_QUICKMATCH_ASYNC(object p0, object p1, object p2, object p3, object p4, object p5)` | bool |
| `NETWORK_DO_TRANSITION_QUICKMATCH_WITH_GROUP` | `bool NETWORK_DO_TRANSITION_QUICKMATCH_WITH_GROUP(object p0, object p1, object p2, object p3, ref object p4, object p5, object p6, object p7)` | bool |
| `NETWORK_DO_TRANSITION_TO_FREEMODE` | `bool NETWORK_DO_TRANSITION_TO_FREEMODE(ref object p0, object p1, bool p2, int players, bool p4)` | bool |
| `NETWORK_DO_TRANSITION_TO_GAME` | `bool NETWORK_DO_TRANSITION_TO_GAME(bool p0, int maxPlayers)` | bool |
| `NETWORK_DO_TRANSITION_TO_NEW_FREEMODE` | `bool NETWORK_DO_TRANSITION_TO_NEW_FREEMODE(ref object p0, object p1, int players, bool p3, bool p4, bool p5)` | bool |
| `NETWORK_DO_TRANSITION_TO_NEW_GAME` | `bool NETWORK_DO_TRANSITION_TO_NEW_GAME(bool p0, int maxPlayers, bool p2)` | bool |
| `NETWORK_DUMP_NET_IF_CONFIG` | `void NETWORK_DUMP_NET_IF_CONFIG()` | void |
| `NETWORK_ENABLE_EXTRA_VEHICLE_ORIENTATION_BLEND_CHECKS` | `void NETWORK_ENABLE_EXTRA_VEHICLE_ORIENTATION_BLEND_CHECKS(int netId, bool toggle)` | void |
| `NETWORK_ENABLE_VOICE_BANDWIDTH_RESTRICTION` | `void NETWORK_ENABLE_VOICE_BANDWIDTH_RESTRICTION(int player)` | void |
| `NETWORK_END_TUTORIAL_SESSION` | `void NETWORK_END_TUTORIAL_SESSION()` | void |
| `NETWORK_ENTITY_AREA_DOES_EXIST` | `bool NETWORK_ENTITY_AREA_DOES_EXIST(int areaHandle)` | bool |
| `NETWORK_ENTITY_AREA_HAVE_ALL_REPLIED` | `bool NETWORK_ENTITY_AREA_HAVE_ALL_REPLIED(int areaHandle)` | bool |
| `NETWORK_ENTITY_AREA_IS_OCCUPIED` | `bool NETWORK_ENTITY_AREA_IS_OCCUPIED(int areaHandle)` | bool |
| `NETWORK_ENTITY_GET_OBJECT_ID` | `int NETWORK_ENTITY_GET_OBJECT_ID(int entity)` | int |
| `NETWORK_ENTITY_USE_HIGH_PRECISION_ROTATION` | `void NETWORK_ENTITY_USE_HIGH_PRECISION_ROTATION(int netId, bool toggle)` | void |
| `NETWORK_EXPLODE_HELI` | `void NETWORK_EXPLODE_HELI(int vehicle, bool isAudible, bool isInvisible, int netId)` | void |
| `NETWORK_EXPLODE_VEHICLE` | `bool NETWORK_EXPLODE_VEHICLE(int vehicle, bool isAudible, bool isInvisible, int netId)` | bool |
| `NETWORK_FADE_IN_ENTITY` | `void NETWORK_FADE_IN_ENTITY(int entity, bool state, object p2)` | void |
| `NETWORK_FADE_OUT_ENTITY` | `void NETWORK_FADE_OUT_ENTITY(int entity, bool normal, bool slow)` | void |
| `NETWORK_FIND_GAMERS_IN_CREW` | `bool NETWORK_FIND_GAMERS_IN_CREW(int crewId)` | bool |
| `NETWORK_FIND_LARGEST_BUNCH_OF_PLAYERS` | `bool NETWORK_FIND_LARGEST_BUNCH_OF_PLAYERS(int p0, object p1)` | bool |
| `NETWORK_FIND_MATCHED_GAMERS` | `bool NETWORK_FIND_MATCHED_GAMERS(int attribute, float fallbackLimit, float lowerLimit, float upperLimit)` | bool |
| `NETWORK_FINISH_BROADCASTING_DATA` | `void NETWORK_FINISH_BROADCASTING_DATA()` | void |
| `NETWORK_FORCE_LOCAL_PLAYER_SCAR_SYNC` | `void NETWORK_FORCE_LOCAL_PLAYER_SCAR_SYNC()` | void |
| `NETWORK_FORCE_LOCAL_USE_OF_SYNCED_SCENE_CAMERA` | `void NETWORK_FORCE_LOCAL_USE_OF_SYNCED_SCENE_CAMERA(int netScene)` | void |
| `NETWORK_GAMERTAG_FROM_HANDLE_PENDING` | `bool NETWORK_GAMERTAG_FROM_HANDLE_PENDING()` | bool |
| `NETWORK_GAMERTAG_FROM_HANDLE_START` | `bool NETWORK_GAMERTAG_FROM_HANDLE_START(ref object gamerHandle)` | bool |
| `NETWORK_GAMERTAG_FROM_HANDLE_SUCCEEDED` | `bool NETWORK_GAMERTAG_FROM_HANDLE_SUCCEEDED()` | bool |
| `NETWORK_GAMER_HAS_HEADSET` | `bool NETWORK_GAMER_HAS_HEADSET(ref object gamerHandle)` | bool |
| `NETWORK_GET_ACTIVITY_PLAYER_NUM` | `int NETWORK_GET_ACTIVITY_PLAYER_NUM(bool p0)` | int |
| `NETWORK_GET_AGE_GROUP` | `int NETWORK_GET_AGE_GROUP()` | int |
| `NETWORK_GET_ASSISTED_DAMAGE_OF_ENTITY` | `bool NETWORK_GET_ASSISTED_DAMAGE_OF_ENTITY(int player, int entity, ref int p2)` | bool |
| `NETWORK_GET_ASSISTED_KILL_OF_ENTITY` | `bool NETWORK_GET_ASSISTED_KILL_OF_ENTITY(int player, int entity, ref int p2)` | bool |
| `NETWORK_GET_AVERAGE_LATENCY` | `float NETWORK_GET_AVERAGE_LATENCY(int player)` | float |
| `NETWORK_GET_AVERAGE_PACKET_LOSS` | `float NETWORK_GET_AVERAGE_PACKET_LOSS(int player)` | float |
| `NETWORK_GET_AVERAGE_PING` | `float NETWORK_GET_AVERAGE_PING(int player)` | float |
| `NETWORK_GET_BONE_ID_OF_FATAL_HIT` | `int NETWORK_GET_BONE_ID_OF_FATAL_HIT()` | int |
| `NETWORK_GET_CONTENT_MODIFIER_LIST_ID` | `int NETWORK_GET_CONTENT_MODIFIER_LIST_ID(uint contentHash)` | int |
| `NETWORK_GET_CURRENTLY_SELECTED_GAMER_HANDLE_FROM_INVITE_MENU` | `bool NETWORK_GET_CURRENTLY_SELECTED_GAMER_HANDLE_FROM_INVITE_MENU(ref object p0)` | bool |
| `NETWORK_GET_DESTROYER_OF_ENTITY` | `int NETWORK_GET_DESTROYER_OF_ENTITY(int entity, Hash* weaponHash)` | int |
| `NETWORK_GET_DESTROYER_OF_NETWORK_ID` | `int NETWORK_GET_DESTROYER_OF_NETWORK_ID(int netId, Hash* weaponHash)` | int |
| `NETWORK_GET_DISPLAYNAMES_FROM_HANDLES` | `int NETWORK_GET_DISPLAYNAMES_FROM_HANDLES(object p0, object p1, object p2)` | int |
| `NETWORK_GET_ENTITY_FROM_NETWORK_ID` | `int NETWORK_GET_ENTITY_FROM_NETWORK_ID(int netId)` | int |
| `NETWORK_GET_ENTITY_FROM_OBJECT_ID` | `int NETWORK_GET_ENTITY_FROM_OBJECT_ID(object p0)` | int |
| `NETWORK_GET_ENTITY_IS_LOCAL` | `bool NETWORK_GET_ENTITY_IS_LOCAL(int entity)` | bool |
| `NETWORK_GET_ENTITY_IS_NETWORKED` | `bool NETWORK_GET_ENTITY_IS_NETWORKED(int entity)` | bool |
| `NETWORK_GET_ENTITY_KILLER_OF_PLAYER` | `int NETWORK_GET_ENTITY_KILLER_OF_PLAYER(int player, Hash* weaponHash)` | int |
| `NETWORK_GET_FOUND_GAMER` | `bool NETWORK_GET_FOUND_GAMER(ref object p0, object p1)` | bool |
| `NETWORK_GET_FRIEND_COUNT` | `int NETWORK_GET_FRIEND_COUNT()` | int |
| `NETWORK_GET_FRIEND_DISPLAY_NAME` | `string NETWORK_GET_FRIEND_DISPLAY_NAME(int friendIndex)` | string |
| `NETWORK_GET_FRIEND_NAME` | `string NETWORK_GET_FRIEND_NAME(int friendIndex)` | string |
| `NETWORK_GET_GAMERTAG_FROM_HANDLE` | `string NETWORK_GET_GAMERTAG_FROM_HANDLE(ref object gamerHandle)` | string |
| `NETWORK_GET_GAMER_STATUS_FROM_QUEUE` | `bool NETWORK_GET_GAMER_STATUS_FROM_QUEUE()` | bool |
| `NETWORK_GET_GAMER_STATUS_RESULT` | `bool NETWORK_GET_GAMER_STATUS_RESULT(ref object p0, object p1)` | bool |
| `NETWORK_GET_GAME_MODE` | `int NETWORK_GET_GAME_MODE()` | int |
| `NETWORK_GET_GLOBAL_MULTIPLAYER_CLOCK` | `void NETWORK_GET_GLOBAL_MULTIPLAYER_CLOCK(ref int hours, ref int minutes, ref int seconds)` | void |
| `NETWORK_GET_HIGHEST_RELIABLE_RESEND_COUNT` | `int NETWORK_GET_HIGHEST_RELIABLE_RESEND_COUNT(int player)` | int |
| `NETWORK_GET_HOST_OF_SCRIPT` | `int NETWORK_GET_HOST_OF_SCRIPT(string scriptName, int instance_id, int position_hash)` | int |
| `NETWORK_GET_HOST_OF_THIS_SCRIPT` | `int NETWORK_GET_HOST_OF_THIS_SCRIPT()` | int |
| `NETWORK_GET_HOST_OF_THREAD` | `int NETWORK_GET_HOST_OF_THREAD(int threadId)` | int |
| `NETWORK_GET_HOST_PLAYER_INDEX` | `int NETWORK_GET_HOST_PLAYER_INDEX()` | int |
| `NETWORK_GET_INSTANCE_ID_OF_THIS_SCRIPT` | `int NETWORK_GET_INSTANCE_ID_OF_THIS_SCRIPT()` | int |
| `NETWORK_GET_INVITE_REPLY_STATUS` | `int NETWORK_GET_INVITE_REPLY_STATUS(object p0)` | int |
| `NETWORK_GET_KILLER_OF_PLAYER` | `int NETWORK_GET_KILLER_OF_PLAYER(int player, Hash* weaponHash)` | int |
| `NETWORK_GET_LAST_ENTITY_POS_RECEIVED_OVER_NETWORK` | `Vector3 NETWORK_GET_LAST_ENTITY_POS_RECEIVED_OVER_NETWORK(int entity)` | Vector3 |
| `NETWORK_GET_LAST_PLAYER_POS_RECEIVED_OVER_NETWORK` | `Vector3 NETWORK_GET_LAST_PLAYER_POS_RECEIVED_OVER_NETWORK(int player)` | Vector3 |
| `NETWORK_GET_LAST_VEL_RECEIVED_OVER_NETWORK` | `Vector3 NETWORK_GET_LAST_VEL_RECEIVED_OVER_NETWORK(int entity)` | Vector3 |
| `NETWORK_GET_LOCAL_HANDLE` | `void NETWORK_GET_LOCAL_HANDLE(ref object gamerHandle, int gamerHandleSize)` | void |
| `NETWORK_GET_LOCAL_SCENE_FROM_NETWORK_ID` | `int NETWORK_GET_LOCAL_SCENE_FROM_NETWORK_ID(int netId)` | int |
| `NETWORK_GET_MAX_FRIENDS` | `int NETWORK_GET_MAX_FRIENDS()` | int |
| `NETWORK_GET_MAX_NUM_PARTICIPANTS` | `int NETWORK_GET_MAX_NUM_PARTICIPANTS()` | int |
| `NETWORK_GET_MUTE_COUNT_FOR_PLAYER` | `void NETWORK_GET_MUTE_COUNT_FOR_PLAYER(int p0, ref float p1, ref float p2)` | void |
| `NETWORK_GET_NETWORK_ID_FROM_ENTITY` | `int NETWORK_GET_NETWORK_ID_FROM_ENTITY(int entity)` | int |
| `NETWORK_GET_NET_STATISTICS_INFO` | `void NETWORK_GET_NET_STATISTICS_INFO(ref object p0)` | void |
| `NETWORK_GET_NP_UNAVAILABLE_REASON` | `int NETWORK_GET_NP_UNAVAILABLE_REASON()` | int |
| `NETWORK_GET_NUMBER_BODY_TRACKER_HITS` | `int NETWORK_GET_NUMBER_BODY_TRACKER_HITS()` | int |
| `NETWORK_GET_NUM_CONNECTED_PLAYERS` | `int NETWORK_GET_NUM_CONNECTED_PLAYERS()` | int |
| `NETWORK_GET_NUM_FOUND_GAMERS` | `int NETWORK_GET_NUM_FOUND_GAMERS()` | int |
| `NETWORK_GET_NUM_PARTICIPANTS` | `int NETWORK_GET_NUM_PARTICIPANTS()` | int |
| `NETWORK_GET_NUM_PRESENCE_INVITES` | `int NETWORK_GET_NUM_PRESENCE_INVITES()` | int |
| `NETWORK_GET_NUM_SCRIPT_PARTICIPANTS` | `int NETWORK_GET_NUM_SCRIPT_PARTICIPANTS(string scriptName, int instance_id, int position_hash)` | int |
| `NETWORK_GET_NUM_TRANSITION_NON_ASYNC_GAMERS` | `int NETWORK_GET_NUM_TRANSITION_NON_ASYNC_GAMERS()` | int |
| `NETWORK_GET_NUM_UNACKED_RELIABLES` | `int NETWORK_GET_NUM_UNACKED_RELIABLES(int player)` | int |
| `NETWORK_GET_PARTICIPANT_INDEX` | `int NETWORK_GET_PARTICIPANT_INDEX(int index)` | int |
| `NETWORK_GET_PLATFORM_PARTY_MEMBERS` | `int NETWORK_GET_PLATFORM_PARTY_MEMBERS(ref object data, int dataSize)` | int |
| `NETWORK_GET_PLATFORM_PARTY_MEMBER_COUNT` | `int NETWORK_GET_PLATFORM_PARTY_MEMBER_COUNT()` | int |
| `NETWORK_GET_PLAYER_ACCOUNT_ID` | `int NETWORK_GET_PLAYER_ACCOUNT_ID(int player)` | int |
| `NETWORK_GET_PLAYER_FROM_GAMER_HANDLE` | `int NETWORK_GET_PLAYER_FROM_GAMER_HANDLE(ref object gamerHandle)` | int |
| `NETWORK_GET_PLAYER_INDEX` | `int NETWORK_GET_PLAYER_INDEX(int player)` | int |
| `NETWORK_GET_PLAYER_INDEX_FROM_PED` | `int NETWORK_GET_PLAYER_INDEX_FROM_PED(int ped)` | int |
| `NETWORK_GET_PLAYER_LOUDNESS` | `float NETWORK_GET_PLAYER_LOUDNESS(int player)` | float |
| `NETWORK_GET_PLAYER_OWNS_WAYPOINT` | `bool NETWORK_GET_PLAYER_OWNS_WAYPOINT(int player)` | bool |
| `NETWORK_GET_PLAYER_TUTORIAL_SESSION_INSTANCE` | `int NETWORK_GET_PLAYER_TUTORIAL_SESSION_INSTANCE(int player)` | int |
| `NETWORK_GET_POSITION_HASH_OF_THIS_SCRIPT` | `uint NETWORK_GET_POSITION_HASH_OF_THIS_SCRIPT()` | uint |
| `NETWORK_GET_PREDICTED_VELOCITY` | `Vector3 NETWORK_GET_PREDICTED_VELOCITY(int entity, float maxSpeedToPredict)` | Vector3 |
| `NETWORK_GET_PRESENCE_INVITE_CONTENT_ID` | `string NETWORK_GET_PRESENCE_INVITE_CONTENT_ID(int p0)` | string |
| `NETWORK_GET_PRESENCE_INVITE_FROM_ADMIN` | `bool NETWORK_GET_PRESENCE_INVITE_FROM_ADMIN(int p0)` | bool |
| `NETWORK_GET_PRESENCE_INVITE_HANDLE` | `bool NETWORK_GET_PRESENCE_INVITE_HANDLE(object p0, ref object p1)` | bool |
| `NETWORK_GET_PRESENCE_INVITE_ID` | `int NETWORK_GET_PRESENCE_INVITE_ID(int p0)` | int |
| `NETWORK_GET_PRESENCE_INVITE_INDEX_BY_ID` | `int NETWORK_GET_PRESENCE_INVITE_INDEX_BY_ID(int p0)` | int |
| `NETWORK_GET_PRESENCE_INVITE_INVITER` | `string NETWORK_GET_PRESENCE_INVITE_INVITER(int p0)` | string |
| `NETWORK_GET_PRESENCE_INVITE_IS_TOURNAMENT` | `bool NETWORK_GET_PRESENCE_INVITE_IS_TOURNAMENT(object p0)` | bool |
| `NETWORK_GET_PRESENCE_INVITE_PLAYLIST_CURRENT` | `int NETWORK_GET_PRESENCE_INVITE_PLAYLIST_CURRENT(int p0)` | int |
| `NETWORK_GET_PRESENCE_INVITE_PLAYLIST_LENGTH` | `int NETWORK_GET_PRESENCE_INVITE_PLAYLIST_LENGTH(int p0)` | int |
| `NETWORK_GET_PRESENCE_INVITE_SESSION_ID` | `int NETWORK_GET_PRESENCE_INVITE_SESSION_ID(object p0)` | int |
| `NETWORK_GET_PRIMARY_CLAN_DATA_CANCEL` | `void NETWORK_GET_PRIMARY_CLAN_DATA_CANCEL()` | void |
| `NETWORK_GET_PRIMARY_CLAN_DATA_CLEAR` | `bool NETWORK_GET_PRIMARY_CLAN_DATA_CLEAR()` | bool |
| `NETWORK_GET_PRIMARY_CLAN_DATA_NEW` | `bool NETWORK_GET_PRIMARY_CLAN_DATA_NEW(ref object p0, ref object p1)` | bool |
| `NETWORK_GET_PRIMARY_CLAN_DATA_PENDING` | `bool NETWORK_GET_PRIMARY_CLAN_DATA_PENDING()` | bool |
| `NETWORK_GET_PRIMARY_CLAN_DATA_START` | `bool NETWORK_GET_PRIMARY_CLAN_DATA_START(ref object p0, object p1)` | bool |
| `NETWORK_GET_PRIMARY_CLAN_DATA_SUCCESS` | `bool NETWORK_GET_PRIMARY_CLAN_DATA_SUCCESS()` | bool |
| `NETWORK_GET_RANDOM_INT` | `int NETWORK_GET_RANDOM_INT()` | int |
| `NETWORK_GET_RANDOM_INT_RANGED` | `int NETWORK_GET_RANDOM_INT_RANGED(int rangeStart, int rangeEnd)` | int |
| `NETWORK_GET_RESPAWN_RESULT` | `void NETWORK_GET_RESPAWN_RESULT(int randomInt, ref Vector3 coordinates, ref float heading)` | void |
| `NETWORK_GET_RESPAWN_RESULT_FLAGS` | `int NETWORK_GET_RESPAWN_RESULT_FLAGS(int p0)` | int |
| `NETWORK_GET_SCRIPT_STATUS` | `int NETWORK_GET_SCRIPT_STATUS()` | int |
| `NETWORK_GET_SIGNALLING_INFO` | `void NETWORK_GET_SIGNALLING_INFO(ref object p0)` | void |
| `NETWORK_GET_TALKER_PROXIMITY` | `float NETWORK_GET_TALKER_PROXIMITY()` | float |
| `NETWORK_GET_THIS_SCRIPT_IS_NETWORK_SCRIPT` | `bool NETWORK_GET_THIS_SCRIPT_IS_NETWORK_SCRIPT()` | bool |
| `NETWORK_GET_TIMEOUT_TIME` | `int NETWORK_GET_TIMEOUT_TIME()` | int |
| `NETWORK_GET_TOTAL_NUM_PLAYERS` | `int NETWORK_GET_TOTAL_NUM_PLAYERS()` | int |
| `NETWORK_GET_TRANSITION_HOST` | `bool NETWORK_GET_TRANSITION_HOST(ref object gamerHandle)` | bool |
| `NETWORK_GET_TRANSITION_MEMBERS` | `int NETWORK_GET_TRANSITION_MEMBERS(ref object data, int dataCount)` | int |
| `NETWORK_GET_TUNABLE_CLOUD_CRC` | `int NETWORK_GET_TUNABLE_CLOUD_CRC()` | int |
| `NETWORK_GET_UNRELIABLE_RESEND_COUNT` | `int NETWORK_GET_UNRELIABLE_RESEND_COUNT(int player)` | int |
| `NETWORK_HANDLE_FROM_FRIEND` | `void NETWORK_HANDLE_FROM_FRIEND(int friendIndex, ref object gamerHandle, int gamerHandleSize)` | void |
| `NETWORK_HANDLE_FROM_MEMBER_ID` | `void NETWORK_HANDLE_FROM_MEMBER_ID(string memberId, ref object gamerHandle, int gamerHandleSize)` | void |
| `NETWORK_HANDLE_FROM_PLAYER` | `void NETWORK_HANDLE_FROM_PLAYER(int player, ref object gamerHandle, int gamerHandleSize)` | void |
| `NETWORK_HANDLE_FROM_USER_ID` | `void NETWORK_HANDLE_FROM_USER_ID(string userId, ref object gamerHandle, int gamerHandleSize)` | void |
| `NETWORK_HASH_FROM_GAMER_HANDLE` | `uint NETWORK_HASH_FROM_GAMER_HANDLE(ref object gamerHandle)` | uint |
| `NETWORK_HASH_FROM_PLAYER_HANDLE` | `uint NETWORK_HASH_FROM_PLAYER_HANDLE(int player)` | uint |
| `NETWORK_HAS_AGE_RESTRICTIONS` | `bool NETWORK_HAS_AGE_RESTRICTIONS()` | bool |
| `NETWORK_HAS_AUTOMUTE_OVERRIDE` | `bool NETWORK_HAS_AUTOMUTE_OVERRIDE()` | bool |
| `NETWORK_HAS_BONE_BEEN_HIT_BY_KILLER` | `bool NETWORK_HAS_BONE_BEEN_HIT_BY_KILLER(int boneIndex)` | bool |
| `NETWORK_HAS_CACHED_PLAYER_HEAD_BLEND_DATA` | `bool NETWORK_HAS_CACHED_PLAYER_HEAD_BLEND_DATA(int player)` | bool |
| `NETWORK_HAS_CONFIRMED_INVITE` | `bool NETWORK_HAS_CONFIRMED_INVITE()` | bool |
| `NETWORK_HAS_CONTROL_OF_DOOR` | `bool NETWORK_HAS_CONTROL_OF_DOOR(uint doorHash)` | bool |
| `NETWORK_HAS_CONTROL_OF_ENTITY` | `bool NETWORK_HAS_CONTROL_OF_ENTITY(int entity)` | bool |
| `NETWORK_HAS_CONTROL_OF_NETWORK_ID` | `bool NETWORK_HAS_CONTROL_OF_NETWORK_ID(int netId)` | bool |
| `NETWORK_HAS_CONTROL_OF_PICKUP` | `bool NETWORK_HAS_CONTROL_OF_PICKUP(int pickup)` | bool |
| `NETWORK_HAS_ENTITY_BEEN_REGISTERED_WITH_THIS_THREAD` | `bool NETWORK_HAS_ENTITY_BEEN_REGISTERED_WITH_THIS_THREAD(int entity)` | bool |
| `NETWORK_HAS_FOLLOW_INVITE` | `bool NETWORK_HAS_FOLLOW_INVITE()` | bool |
| `NETWORK_HAS_HEADSET` | `bool NETWORK_HAS_HEADSET()` | bool |
| `NETWORK_HAS_INVITED_GAMER` | `bool NETWORK_HAS_INVITED_GAMER(ref object p0)` | bool |
| `NETWORK_HAS_INVITED_GAMER_TO_TRANSITION` | `bool NETWORK_HAS_INVITED_GAMER_TO_TRANSITION(ref object p0)` | bool |
| `NETWORK_HAS_MADE_INVITE_DECISION` | `bool NETWORK_HAS_MADE_INVITE_DECISION(ref object gamerHandle)` | bool |
| `NETWORK_HAS_PENDING_INVITE` | `bool NETWORK_HAS_PENDING_INVITE()` | bool |
| `NETWORK_HAS_PLAYER_STARTED_TRANSITION` | `bool NETWORK_HAS_PLAYER_STARTED_TRANSITION(int player)` | bool |
| `NETWORK_HAS_RECEIVED_HOST_BROADCAST_DATA` | `bool NETWORK_HAS_RECEIVED_HOST_BROADCAST_DATA()` | bool |
| `NETWORK_HAS_ROS_PRIVILEGE` | `bool NETWORK_HAS_ROS_PRIVILEGE(int index)` | bool |
| `NETWORK_HAS_ROS_PRIVILEGE_END_DATE` | `bool NETWORK_HAS_ROS_PRIVILEGE_END_DATE(int privilege, ref int banType, ref object timeData)` | bool |
| `NETWORK_HAS_ROS_PRIVILEGE_PLAYED_LAST_GEN` | `bool NETWORK_HAS_ROS_PRIVILEGE_PLAYED_LAST_GEN()` | bool |
| `NETWORK_HAS_ROS_PRIVILEGE_SPECIAL_EDITION_CONTENT` | `bool NETWORK_HAS_ROS_PRIVILEGE_SPECIAL_EDITION_CONTENT()` | bool |
| `NETWORK_HAS_SC_MEMBERSHIP` | `bool NETWORK_HAS_SC_MEMBERSHIP()` | bool |
| `NETWORK_HAS_SOCIAL_CLUB_ACCOUNT` | `bool NETWORK_HAS_SOCIAL_CLUB_ACCOUNT()` | bool |
| `NETWORK_HAS_SOCIAL_NETWORKING_SHARING_PRIV` | `bool NETWORK_HAS_SOCIAL_NETWORKING_SHARING_PRIV()` | bool |
| `NETWORK_HAS_TRANSITION_INVITE_BEEN_ACKED` | `bool NETWORK_HAS_TRANSITION_INVITE_BEEN_ACKED(ref object p0)` | bool |
| `NETWORK_HAS_VALID_ROS_CREDENTIALS` | `bool NETWORK_HAS_VALID_ROS_CREDENTIALS()` | bool |
| `NETWORK_HAS_VIEW_GAMER_USER_CONTENT_RESULT` | `bool NETWORK_HAS_VIEW_GAMER_USER_CONTENT_RESULT(ref object gamerHandle)` | bool |
| `NETWORK_HAVE_COMMUNICATION_PRIVILEGES` | `bool NETWORK_HAVE_COMMUNICATION_PRIVILEGES(int p0, int player)` | bool |
| `NETWORK_HAVE_ONLINE_PRIVILEGES` | `bool NETWORK_HAVE_ONLINE_PRIVILEGES()` | bool |
| `NETWORK_HAVE_PLATFORM_SUBSCRIPTION` | `bool NETWORK_HAVE_PLATFORM_SUBSCRIPTION()` | bool |
| `NETWORK_HAVE_ROS_BANNED_PRIV` | `bool NETWORK_HAVE_ROS_BANNED_PRIV()` | bool |
| `NETWORK_HAVE_ROS_CREATE_TICKET_PRIV` | `bool NETWORK_HAVE_ROS_CREATE_TICKET_PRIV()` | bool |
| `NETWORK_HAVE_ROS_LEADERBOARD_WRITE_PRIV` | `bool NETWORK_HAVE_ROS_LEADERBOARD_WRITE_PRIV()` | bool |
| `NETWORK_HAVE_ROS_MULTIPLAYER_PRIV` | `bool NETWORK_HAVE_ROS_MULTIPLAYER_PRIV()` | bool |
| `NETWORK_HAVE_ROS_SOCIAL_CLUB_PRIV` | `bool NETWORK_HAVE_ROS_SOCIAL_CLUB_PRIV()` | bool |
| `NETWORK_HAVE_SCS_PRIVATE_MSG_PRIV` | `bool NETWORK_HAVE_SCS_PRIVATE_MSG_PRIV()` | bool |
| `NETWORK_HAVE_USER_CONTENT_PRIVILEGES` | `bool NETWORK_HAVE_USER_CONTENT_PRIVILEGES(int p0)` | bool |
| `NETWORK_HIDE_PROJECTILE_IN_CUTSCENE` | `void NETWORK_HIDE_PROJECTILE_IN_CUTSCENE()` | void |
| `NETWORK_HOST_TRANSITION` | `bool NETWORK_HOST_TRANSITION(int p0, int p1, int p2, int p3, object p4, bool p5, bool p6, int p7, object p8, int p9)` | bool |
| `NETWORK_IGNORE_REMOTE_WAYPOINTS` | `void NETWORK_IGNORE_REMOTE_WAYPOINTS()` | void |
| `NETWORK_INVITE_GAMERS` | `bool NETWORK_INVITE_GAMERS(ref object p0, object p1, ref object p2, object p3)` | bool |
| `NETWORK_INVITE_GAMERS_TO_TRANSITION` | `bool NETWORK_INVITE_GAMERS_TO_TRANSITION(ref object p0, object p1)` | bool |
| `NETWORK_IS_ACTIVITY_SESSION` | `bool NETWORK_IS_ACTIVITY_SESSION()` | bool |
| `NETWORK_IS_ACTIVITY_SPECTATOR` | `bool NETWORK_IS_ACTIVITY_SPECTATOR()` | bool |
| `NETWORK_IS_ACTIVITY_SPECTATOR_FROM_HANDLE` | `bool NETWORK_IS_ACTIVITY_SPECTATOR_FROM_HANDLE(ref object gamerHandle)` | bool |
| `NETWORK_IS_ADDING_FRIEND` | `bool NETWORK_IS_ADDING_FRIEND()` | bool |
| `NETWORK_IS_ANY_PLAYER_NEAR` | `bool NETWORK_IS_ANY_PLAYER_NEAR(object p0, object p1, object p2, object p3, object p4, object p5, object p6)` | bool |
| `NETWORK_IS_CABLE_CONNECTED` | `bool NETWORK_IS_CABLE_CONNECTED()` | bool |
| `NETWORK_IS_CHATTING_IN_PLATFORM_PARTY` | `bool NETWORK_IS_CHATTING_IN_PLATFORM_PARTY(ref object gamerHandle)` | bool |
| `NETWORK_IS_CLOCK_TIME_OVERRIDDEN` | `bool NETWORK_IS_CLOCK_TIME_OVERRIDDEN()` | bool |
| `NETWORK_IS_CLOUD_AVAILABLE` | `bool NETWORK_IS_CLOUD_AVAILABLE()` | bool |
| `NETWORK_IS_CLOUD_BACKGROUND_SCRIPT_REQUEST_PENDING` | `bool NETWORK_IS_CLOUD_BACKGROUND_SCRIPT_REQUEST_PENDING()` | bool |
| `NETWORK_IS_CONNECTED_VIA_RELAY` | `bool NETWORK_IS_CONNECTED_VIA_RELAY(int player)` | bool |
| `NETWORK_IS_CONNETED_TO_NP_PRESENCE` | `bool NETWORK_IS_CONNETED_TO_NP_PRESENCE()` | bool |
| `NETWORK_IS_DOOR_NETWORKED` | `bool NETWORK_IS_DOOR_NETWORKED(uint doorHash)` | bool |
| `NETWORK_IS_ENTITY_CONCEALED` | `bool NETWORK_IS_ENTITY_CONCEALED(int entity)` | bool |
| `NETWORK_IS_ENTITY_FADING` | `bool NETWORK_IS_ENTITY_FADING(int entity)` | bool |
| `NETWORK_IS_FINDING_GAMERS` | `bool NETWORK_IS_FINDING_GAMERS()` | bool |
| `NETWORK_IS_FRIEND` | `bool NETWORK_IS_FRIEND(ref object gamerHandle)` | bool |
| `NETWORK_IS_FRIEND_HANDLE_ONLINE` | `bool NETWORK_IS_FRIEND_HANDLE_ONLINE(ref object gamerHandle)` | bool |
| `NETWORK_IS_FRIEND_INDEX_ONLINE` | `bool NETWORK_IS_FRIEND_INDEX_ONLINE(int friendIndex)` | bool |
| `NETWORK_IS_FRIEND_IN_MULTIPLAYER` | `bool NETWORK_IS_FRIEND_IN_MULTIPLAYER(string friendName)` | bool |
| `NETWORK_IS_FRIEND_IN_SAME_TITLE` | `bool NETWORK_IS_FRIEND_IN_SAME_TITLE(string friendName)` | bool |
| `NETWORK_IS_FRIEND_ONLINE` | `bool NETWORK_IS_FRIEND_ONLINE(string name)` | bool |
| `NETWORK_IS_GAMER_BLOCKED_BY_ME` | `bool NETWORK_IS_GAMER_BLOCKED_BY_ME(ref object gamerHandle)` | bool |
| `NETWORK_IS_GAMER_IN_MY_SESSION` | `bool NETWORK_IS_GAMER_IN_MY_SESSION(ref object gamerHandle)` | bool |
| `NETWORK_IS_GAMER_MUTED_BY_ME` | `bool NETWORK_IS_GAMER_MUTED_BY_ME(ref object gamerHandle)` | bool |
| `NETWORK_IS_GAMER_TALKING` | `bool NETWORK_IS_GAMER_TALKING(ref object gamerHandle)` | bool |
| `NETWORK_IS_GAME_IN_PROGRESS` | `bool NETWORK_IS_GAME_IN_PROGRESS()` | bool |
| `NETWORK_IS_GETTING_GAMER_STATUS` | `bool NETWORK_IS_GETTING_GAMER_STATUS()` | bool |
| `NETWORK_IS_HANDLE_VALID` | `bool NETWORK_IS_HANDLE_VALID(ref object gamerHandle, int gamerHandleSize)` | bool |
| `NETWORK_IS_HOST` | `bool NETWORK_IS_HOST()` | bool |
| `NETWORK_IS_HOST_OF_THIS_SCRIPT` | `bool NETWORK_IS_HOST_OF_THIS_SCRIPT()` | bool |
| `NETWORK_IS_INACTIVE_PROFILE` | `bool NETWORK_IS_INACTIVE_PROFILE(ref object p0)` | bool |
| `NETWORK_IS_IN_MP_CUTSCENE` | `bool NETWORK_IS_IN_MP_CUTSCENE()` | bool |
| `NETWORK_IS_IN_PLATFORM_PARTY` | `bool NETWORK_IS_IN_PLATFORM_PARTY()` | bool |
| `NETWORK_IS_IN_PLATFORM_PARTY_CHAT` | `bool NETWORK_IS_IN_PLATFORM_PARTY_CHAT()` | bool |
| `NETWORK_IS_IN_SESSION` | `bool NETWORK_IS_IN_SESSION()` | bool |
| `NETWORK_IS_IN_SPECTATOR_MODE` | `bool NETWORK_IS_IN_SPECTATOR_MODE()` | bool |
| `NETWORK_IS_IN_TRANSITION` | `bool NETWORK_IS_IN_TRANSITION()` | bool |
| `NETWORK_IS_IN_TUTORIAL_SESSION` | `bool NETWORK_IS_IN_TUTORIAL_SESSION()` | bool |
| `NETWORK_IS_LOCAL_PLAYER_INVINCIBLE` | `bool NETWORK_IS_LOCAL_PLAYER_INVINCIBLE()` | bool |
| `NETWORK_IS_LOGGED_IN_TO_PSN` | `bool NETWORK_IS_LOGGED_IN_TO_PSN()` | bool |
| `NETWORK_IS_MULTIPLAYER_DISABLED` | `bool NETWORK_IS_MULTIPLAYER_DISABLED()` | bool |
| `NETWORK_IS_NETWORK_ID_REMOTELY_CONTROLLED` | `bool NETWORK_IS_NETWORK_ID_REMOTELY_CONTROLLED(int netId)` | bool |
| `NETWORK_IS_NP_AVAILABLE` | `bool NETWORK_IS_NP_AVAILABLE()` | bool |
| `NETWORK_IS_NP_PENDING` | `bool NETWORK_IS_NP_PENDING()` | bool |
| `NETWORK_IS_OFFLINE_INVITE_PENDING` | `bool NETWORK_IS_OFFLINE_INVITE_PENDING()` | bool |
| `NETWORK_IS_PARTICIPANT_ACTIVE` | `bool NETWORK_IS_PARTICIPANT_ACTIVE(int p0)` | bool |
| `NETWORK_IS_PENDING_FRIEND` | `bool NETWORK_IS_PENDING_FRIEND(object p0)` | bool |
| `NETWORK_IS_PLATFORM_SUBSCRIPTION_CHECK_PENDING` | `bool NETWORK_IS_PLATFORM_SUBSCRIPTION_CHECK_PENDING()` | bool |
| `NETWORK_IS_PLAYER_ACTIVE` | `bool NETWORK_IS_PLAYER_ACTIVE(int player)` | bool |
| `NETWORK_IS_PLAYER_A_PARTICIPANT` | `bool NETWORK_IS_PLAYER_A_PARTICIPANT(int player)` | bool |
| `NETWORK_IS_PLAYER_A_PARTICIPANT_ON_SCRIPT` | `bool NETWORK_IS_PLAYER_A_PARTICIPANT_ON_SCRIPT(int player, string script, int instance_id)` | bool |
| `NETWORK_IS_PLAYER_BLOCKED_BY_ME` | `bool NETWORK_IS_PLAYER_BLOCKED_BY_ME(int player)` | bool |
| `NETWORK_IS_PLAYER_CONCEALED` | `bool NETWORK_IS_PLAYER_CONCEALED(int player)` | bool |
| `NETWORK_IS_PLAYER_CONNECTED` | `bool NETWORK_IS_PLAYER_CONNECTED(int player)` | bool |
| `NETWORK_IS_PLAYER_FADING` | `bool NETWORK_IS_PLAYER_FADING(int player)` | bool |
| `NETWORK_IS_PLAYER_IN_MP_CUTSCENE` | `bool NETWORK_IS_PLAYER_IN_MP_CUTSCENE(int player)` | bool |
| `NETWORK_IS_PLAYER_MUTED_BY_ME` | `bool NETWORK_IS_PLAYER_MUTED_BY_ME(int player)` | bool |
| `NETWORK_IS_PLAYER_ON_BLOCKLIST` | `bool NETWORK_IS_PLAYER_ON_BLOCKLIST(ref object gamerHandle)` | bool |
| `NETWORK_IS_PLAYER_TALKING` | `bool NETWORK_IS_PLAYER_TALKING(int player)` | bool |
| `NETWORK_IS_PRIVILEGE_CHECK_IN_PROGRESS` | `bool NETWORK_IS_PRIVILEGE_CHECK_IN_PROGRESS()` | bool |
| `NETWORK_IS_PUSH_TO_TALK_ACTIVE` | `bool NETWORK_IS_PUSH_TO_TALK_ACTIVE()` | bool |
| `NETWORK_IS_QUEUING_FOR_SESSION_JOIN` | `bool NETWORK_IS_QUEUING_FOR_SESSION_JOIN()` | bool |
| `NETWORK_IS_REFRESHING_ROS_CREDENTIALS` | `bool NETWORK_IS_REFRESHING_ROS_CREDENTIALS()` | bool |
| `NETWORK_IS_SCRIPT_ACTIVE` | `bool NETWORK_IS_SCRIPT_ACTIVE(string scriptName, int instance_id, bool p2, int position_hash)` | bool |
| `NETWORK_IS_SCRIPT_ACTIVE_BY_HASH` | `bool NETWORK_IS_SCRIPT_ACTIVE_BY_HASH(uint scriptHash, int p1, bool p2, int p3)` | bool |
| `NETWORK_IS_SESSION_ACTIVE` | `bool NETWORK_IS_SESSION_ACTIVE()` | bool |
| `NETWORK_IS_SESSION_BUSY` | `bool NETWORK_IS_SESSION_BUSY()` | bool |
| `NETWORK_IS_SESSION_STARTED` | `bool NETWORK_IS_SESSION_STARTED()` | bool |
| `NETWORK_IS_SHOWING_SYSTEM_UI_OR_RECENTLY_REQUESTED_UPSELL` | `bool NETWORK_IS_SHOWING_SYSTEM_UI_OR_RECENTLY_REQUESTED_UPSELL()` | bool |
| `NETWORK_IS_SIGNED_IN` | `bool NETWORK_IS_SIGNED_IN()` | bool |
| `NETWORK_IS_SIGNED_ONLINE` | `bool NETWORK_IS_SIGNED_ONLINE()` | bool |
| `NETWORK_IS_THREAD_A_NETWORK_SCRIPT` | `bool NETWORK_IS_THREAD_A_NETWORK_SCRIPT(int threadId)` | bool |
| `NETWORK_IS_TITLE_UPDATE_REQUIRED` | `bool NETWORK_IS_TITLE_UPDATE_REQUIRED()` | bool |
| `NETWORK_IS_TRANSITION_BUSY` | `bool NETWORK_IS_TRANSITION_BUSY()` | bool |
| `NETWORK_IS_TRANSITION_CLOSED_CREW` | `bool NETWORK_IS_TRANSITION_CLOSED_CREW()` | bool |
| `NETWORK_IS_TRANSITION_CLOSED_FRIENDS` | `bool NETWORK_IS_TRANSITION_CLOSED_FRIENDS()` | bool |
| `NETWORK_IS_TRANSITION_HOST` | `bool NETWORK_IS_TRANSITION_HOST()` | bool |
| `NETWORK_IS_TRANSITION_HOST_FROM_HANDLE` | `bool NETWORK_IS_TRANSITION_HOST_FROM_HANDLE(ref object gamerHandle)` | bool |
| `NETWORK_IS_TRANSITION_LEAVE_POSTPONED` | `bool NETWORK_IS_TRANSITION_LEAVE_POSTPONED()` | bool |
| `NETWORK_IS_TRANSITION_MATCHMAKING` | `bool NETWORK_IS_TRANSITION_MATCHMAKING()` | bool |
| `NETWORK_IS_TRANSITION_OPEN_TO_MATCHMAKING` | `bool NETWORK_IS_TRANSITION_OPEN_TO_MATCHMAKING()` | bool |
| `NETWORK_IS_TRANSITION_PRIVATE` | `bool NETWORK_IS_TRANSITION_PRIVATE()` | bool |
| `NETWORK_IS_TRANSITION_SOLO` | `bool NETWORK_IS_TRANSITION_SOLO()` | bool |
| `NETWORK_IS_TRANSITION_STARTED` | `bool NETWORK_IS_TRANSITION_STARTED()` | bool |
| `NETWORK_IS_TRANSITION_TO_GAME` | `bool NETWORK_IS_TRANSITION_TO_GAME()` | bool |
| `NETWORK_IS_TRANSITION_VISIBILITY_LOCKED` | `bool NETWORK_IS_TRANSITION_VISIBILITY_LOCKED()` | bool |
| `NETWORK_IS_TUNABLE_CLOUD_REQUEST_PENDING` | `bool NETWORK_IS_TUNABLE_CLOUD_REQUEST_PENDING()` | bool |
| `NETWORK_IS_TUTORIAL_SESSION_CHANGE_PENDING` | `bool NETWORK_IS_TUTORIAL_SESSION_CHANGE_PENDING()` | bool |
| `NETWORK_IS_USING_ONLINE_PROMOTION` | `bool NETWORK_IS_USING_ONLINE_PROMOTION()` | bool |
| `NETWORK_JOIN_GROUP_ACTIVITY` | `bool NETWORK_JOIN_GROUP_ACTIVITY()` | bool |
| `NETWORK_JOIN_PREVIOUSLY_FAILED_SESSION` | `bool NETWORK_JOIN_PREVIOUSLY_FAILED_SESSION()` | bool |
| `NETWORK_JOIN_PREVIOUSLY_FAILED_TRANSITION` | `bool NETWORK_JOIN_PREVIOUSLY_FAILED_TRANSITION()` | bool |
| `NETWORK_JOIN_TRANSITION` | `bool NETWORK_JOIN_TRANSITION(int player)` | bool |
| `NETWORK_KEEP_ENTITY_COLLISION_DISABLED_AFTER_ANIM_SCENE` | `void NETWORK_KEEP_ENTITY_COLLISION_DISABLED_AFTER_ANIM_SCENE(object p0, object p1)` | void |
| `NETWORK_LAUNCH_TRANSITION` | `bool NETWORK_LAUNCH_TRANSITION()` | bool |
| `NETWORK_LEAVE_PED_BEHIND_BEFORE_CUTSCENE` | `void NETWORK_LEAVE_PED_BEHIND_BEFORE_CUTSCENE(int player, bool p1)` | void |
| `NETWORK_LEAVE_PED_BEHIND_BEFORE_WARP` | `void NETWORK_LEAVE_PED_BEHIND_BEFORE_WARP(int player, float x, float y, float z, bool p4, bool p5)` | void |
| `NETWORK_LEAVE_TRANSITION` | `bool NETWORK_LEAVE_TRANSITION()` | bool |
| `NETWORK_MARK_AS_PREFERRED_ACTIVITY` | `void NETWORK_MARK_AS_PREFERRED_ACTIVITY(bool p0)` | void |
| `NETWORK_MARK_AS_WAITING_ASYNC` | `void NETWORK_MARK_AS_WAITING_ASYNC(bool p0)` | void |
| `NETWORK_MARK_TRANSITION_GAMER_AS_FULLY_JOINED` | `bool NETWORK_MARK_TRANSITION_GAMER_AS_FULLY_JOINED(ref object p0)` | bool |
| `NETWORK_MEMBER_ID_FROM_GAMER_HANDLE` | `string NETWORK_MEMBER_ID_FROM_GAMER_HANDLE(ref object gamerHandle)` | string |
| `NETWORK_NEED_TO_START_NEW_GAME_BUT_BLOCKED` | `bool NETWORK_NEED_TO_START_NEW_GAME_BUT_BLOCKED()` | bool |
| `NETWORK_ON_RETURN_TO_SINGLE_PLAYER` | `void NETWORK_ON_RETURN_TO_SINGLE_PLAYER()` | void |
| `NETWORK_OPEN_TRANSITION_MATCHMAKING` | `void NETWORK_OPEN_TRANSITION_MATCHMAKING()` | void |
| `NETWORK_OVERRIDE_CHAT_RESTRICTIONS` | `void NETWORK_OVERRIDE_CHAT_RESTRICTIONS(int player, bool toggle)` | void |
| `NETWORK_OVERRIDE_CLOCK_RATE` | `void NETWORK_OVERRIDE_CLOCK_RATE(int ms)` | void |
| `NETWORK_OVERRIDE_CLOCK_TIME` | `void NETWORK_OVERRIDE_CLOCK_TIME(int hours, int minutes, int seconds)` | void |
| `NETWORK_OVERRIDE_COORDS_AND_HEADING` | `void NETWORK_OVERRIDE_COORDS_AND_HEADING(int entity, float x, float y, float z, float heading)` | void |
| `NETWORK_OVERRIDE_RECEIVE_RESTRICTIONS` | `void NETWORK_OVERRIDE_RECEIVE_RESTRICTIONS(int player, bool toggle)` | void |
| `NETWORK_OVERRIDE_RECEIVE_RESTRICTIONS_ALL` | `void NETWORK_OVERRIDE_RECEIVE_RESTRICTIONS_ALL(bool toggle)` | void |
| `NETWORK_OVERRIDE_SEND_RESTRICTIONS` | `void NETWORK_OVERRIDE_SEND_RESTRICTIONS(int player, bool toggle)` | void |
| `NETWORK_OVERRIDE_SEND_RESTRICTIONS_ALL` | `void NETWORK_OVERRIDE_SEND_RESTRICTIONS_ALL(bool toggle)` | void |
| `NETWORK_OVERRIDE_TEAM_RESTRICTIONS` | `void NETWORK_OVERRIDE_TEAM_RESTRICTIONS(int team, bool toggle)` | void |
| `NETWORK_OVERRIDE_TRANSITION_CHAT` | `void NETWORK_OVERRIDE_TRANSITION_CHAT(bool p0)` | void |
| `NETWORK_PATCH_POST_CUTSCENE_HS4F_TUN_ENT` | `void NETWORK_PATCH_POST_CUTSCENE_HS4F_TUN_ENT(int ped)` | void |
| `NETWORK_PERMISSIONS_HAS_GAMER_RECORD` | `bool NETWORK_PERMISSIONS_HAS_GAMER_RECORD(ref object gamerHandle)` | bool |
| `NETWORK_PLAYER_GET_CHEATER_REASON` | `int NETWORK_PLAYER_GET_CHEATER_REASON()` | int |
| `NETWORK_PLAYER_GET_NAME` | `string NETWORK_PLAYER_GET_NAME(int player)` | string |
| `NETWORK_PLAYER_GET_USERID` | `string NETWORK_PLAYER_GET_USERID(int player, ref int userID)` | string |
| `NETWORK_PLAYER_HAS_HEADSET` | `bool NETWORK_PLAYER_HAS_HEADSET(int player)` | bool |
| `NETWORK_PLAYER_INDEX_IS_CHEATER` | `bool NETWORK_PLAYER_INDEX_IS_CHEATER(int player)` | bool |
| `NETWORK_PLAYER_IS_BADSPORT` | `bool NETWORK_PLAYER_IS_BADSPORT()` | bool |
| `NETWORK_PLAYER_IS_CHEATER` | `bool NETWORK_PLAYER_IS_CHEATER()` | bool |
| `NETWORK_PLAYER_IS_ROCKSTAR_DEV` | `bool NETWORK_PLAYER_IS_ROCKSTAR_DEV(int player)` | bool |
| `NETWORK_PREVENT_SCRIPT_HOST_MIGRATION` | `void NETWORK_PREVENT_SCRIPT_HOST_MIGRATION()` | void |
| `NETWORK_QUERY_RESPAWN_RESULTS` | `int NETWORK_QUERY_RESPAWN_RESULTS(ref object p0)` | int |
| `NETWORK_QUEUE_GAMER_FOR_STATUS` | `bool NETWORK_QUEUE_GAMER_FOR_STATUS(ref object p0)` | bool |
| `NETWORK_QUIT_MP_TO_DESKTOP` | `void NETWORK_QUIT_MP_TO_DESKTOP()` | void |
| `NETWORK_REGISTER_ENTITY_AS_NETWORKED` | `void NETWORK_REGISTER_ENTITY_AS_NETWORKED(int entity)` | void |
| `NETWORK_REGISTER_HIGH_FREQUENCY_HOST_BROADCAST_VARIABLES` | `void NETWORK_REGISTER_HIGH_FREQUENCY_HOST_BROADCAST_VARIABLES(object p0, object p1, object p2)` | void |
| `NETWORK_REGISTER_HIGH_FREQUENCY_PLAYER_BROADCAST_VARIABLES` | `void NETWORK_REGISTER_HIGH_FREQUENCY_PLAYER_BROADCAST_VARIABLES(object p0, object p1, object p2)` | void |
| `NETWORK_REGISTER_HOST_BROADCAST_VARIABLES` | `void NETWORK_REGISTER_HOST_BROADCAST_VARIABLES(ref int vars, int numVars, string debugName)` | void |
| `NETWORK_REGISTER_PLAYER_BROADCAST_VARIABLES` | `void NETWORK_REGISTER_PLAYER_BROADCAST_VARIABLES(ref int vars, int numVars, string debugName)` | void |
| `NETWORK_REMAIN_IN_GAME_CHAT` | `void NETWORK_REMAIN_IN_GAME_CHAT(bool p0)` | void |
| `NETWORK_REMOVE_ALL_QUEUED_JOIN_REQUESTS` | `void NETWORK_REMOVE_ALL_QUEUED_JOIN_REQUESTS()` | void |
| `NETWORK_REMOVE_ALL_TRANSITION_INVITE` | `void NETWORK_REMOVE_ALL_TRANSITION_INVITE()` | void |
| `NETWORK_REMOVE_AND_CANCEL_ALL_INVITES` | `void NETWORK_REMOVE_AND_CANCEL_ALL_INVITES()` | void |
| `NETWORK_REMOVE_AND_CANCEL_ALL_TRANSITION_INVITES` | `void NETWORK_REMOVE_AND_CANCEL_ALL_TRANSITION_INVITES()` | void |
| `NETWORK_REMOVE_ENTITY_AREA` | `bool NETWORK_REMOVE_ENTITY_AREA(int areaHandle)` | bool |
| `NETWORK_REMOVE_INVALID_OBJECT_MODEL` | `void NETWORK_REMOVE_INVALID_OBJECT_MODEL(uint modelHash)` | void |
| `NETWORK_REMOVE_PRESENCE_INVITE` | `bool NETWORK_REMOVE_PRESENCE_INVITE(int p0)` | bool |
| `NETWORK_REMOVE_TRANSITION_INVITE` | `void NETWORK_REMOVE_TRANSITION_INVITE(ref object p0)` | void |
| `NETWORK_REPORT_CODE_TAMPER` | `void NETWORK_REPORT_CODE_TAMPER()` | void |
| `NETWORK_REQUEST_CLOUD_BACKGROUND_SCRIPTS` | `bool NETWORK_REQUEST_CLOUD_BACKGROUND_SCRIPTS()` | bool |
| `NETWORK_REQUEST_CLOUD_TUNABLES` | `void NETWORK_REQUEST_CLOUD_TUNABLES()` | void |
| `NETWORK_REQUEST_CONTROL_OF_DOOR` | `bool NETWORK_REQUEST_CONTROL_OF_DOOR(int doorID)` | bool |
| `NETWORK_REQUEST_CONTROL_OF_ENTITY` | `bool NETWORK_REQUEST_CONTROL_OF_ENTITY(int entity)` | bool |
| `NETWORK_REQUEST_CONTROL_OF_NETWORK_ID` | `bool NETWORK_REQUEST_CONTROL_OF_NETWORK_ID(int netId)` | bool |
| `NETWORK_REQUEST_INVITE_CONFIRMED_EVENT` | `bool NETWORK_REQUEST_INVITE_CONFIRMED_EVENT()` | bool |
| `NETWORK_REQUEST_TO_BE_HOST_OF_THIS_SCRIPT` | `void NETWORK_REQUEST_TO_BE_HOST_OF_THIS_SCRIPT()` | void |
| `NETWORK_RESET_BODY_TRACKER` | `void NETWORK_RESET_BODY_TRACKER()` | void |
| `NETWORK_RESOLVE_PRIVILEGE_USER_CONTENT` | `bool NETWORK_RESOLVE_PRIVILEGE_USER_CONTENT()` | bool |
| `NETWORK_RESURRECT_LOCAL_PLAYER` | `void NETWORK_RESURRECT_LOCAL_PLAYER(float x, float y, float z, float heading, bool p4, bool changetime, bool p6, int p7, int p8)` | void |
| `NETWORK_RETAIN_ACTIVITY_GROUP` | `void NETWORK_RETAIN_ACTIVITY_GROUP()` | void |
| `NETWORK_SEED_RANDOM_NUMBER_GENERATOR` | `void NETWORK_SEED_RANDOM_NUMBER_GENERATOR(int seed)` | void |
| `NETWORK_SEND_IMPORTANT_TRANSITION_INVITE_VIA_PRESENCE` | `bool NETWORK_SEND_IMPORTANT_TRANSITION_INVITE_VIA_PRESENCE(ref object gamerHandle, string p1, int dataCount, int p3)` | bool |
| `NETWORK_SEND_INVITE_VIA_PRESENCE` | `bool NETWORK_SEND_INVITE_VIA_PRESENCE(ref object gamerHandle, string p1, int dataCount, int p3)` | bool |
| `NETWORK_SEND_QUEUED_JOIN_REQUEST` | `void NETWORK_SEND_QUEUED_JOIN_REQUEST()` | void |
| `NETWORK_SEND_TEXT_MESSAGE` | `bool NETWORK_SEND_TEXT_MESSAGE(string message, ref object gamerHandle)` | bool |
| `NETWORK_SEND_TRANSITION_GAMER_INSTRUCTION` | `bool NETWORK_SEND_TRANSITION_GAMER_INSTRUCTION(ref object gamerHandle, string p1, int p2, int p3, bool p4)` | bool |
| `NETWORK_SEND_TRANSITION_INVITE_VIA_PRESENCE` | `bool NETWORK_SEND_TRANSITION_INVITE_VIA_PRESENCE(ref object gamerHandle, string p1, int dataCount, int p3)` | bool |
| `NETWORK_SESSION_ADD_ACTIVE_MATCHMAKING_GROUP` | `void NETWORK_SESSION_ADD_ACTIVE_MATCHMAKING_GROUP(int groupId)` | void |
| `NETWORK_SESSION_BLOCK_JOIN_REQUESTS` | `void NETWORK_SESSION_BLOCK_JOIN_REQUESTS(bool toggle)` | void |
| `NETWORK_SESSION_CANCEL_INVITE` | `void NETWORK_SESSION_CANCEL_INVITE()` | void |
| `NETWORK_SESSION_CHANGE_SLOTS` | `void NETWORK_SESSION_CHANGE_SLOTS(int slots, bool p1)` | void |
| `NETWORK_SESSION_DO_ACTIVITY_QUICKMATCH` | `bool NETWORK_SESSION_DO_ACTIVITY_QUICKMATCH(object p0, object p1, object p2, object p3, object p4)` | bool |
| `NETWORK_SESSION_DO_CREW_MATCHMAKING` | `bool NETWORK_SESSION_DO_CREW_MATCHMAKING(int crewId, int p1, int p2, int maxPlayers)` | bool |
| `NETWORK_SESSION_DO_FREEROAM_QUICKMATCH` | `bool NETWORK_SESSION_DO_FREEROAM_QUICKMATCH(object p0, object p1, object p2)` | bool |
| `NETWORK_SESSION_DO_FRIEND_MATCHMAKING` | `bool NETWORK_SESSION_DO_FRIEND_MATCHMAKING(int p0, int p1, int p2)` | bool |
| `NETWORK_SESSION_FORCE_CANCEL_INVITE` | `void NETWORK_SESSION_FORCE_CANCEL_INVITE()` | void |
| `NETWORK_SESSION_GET_HOST_AIM_PREFERENCE` | `int NETWORK_SESSION_GET_HOST_AIM_PREFERENCE()` | int |
| `NETWORK_SESSION_GET_INVITER` | `void NETWORK_SESSION_GET_INVITER(ref object gamerHandle)` | void |
| `NETWORK_SESSION_GET_KICK_VOTE` | `bool NETWORK_SESSION_GET_KICK_VOTE(int player)` | bool |
| `NETWORK_SESSION_GET_MATCHMAKING_GROUP_FREE` | `int NETWORK_SESSION_GET_MATCHMAKING_GROUP_FREE(int p0)` | int |
| `NETWORK_SESSION_GET_PRIVATE_SLOTS` | `int NETWORK_SESSION_GET_PRIVATE_SLOTS()` | int |
| `NETWORK_SESSION_GET_UNIQUE_CREW_LIMIT` | `int NETWORK_SESSION_GET_UNIQUE_CREW_LIMIT()` | int |
| `NETWORK_SESSION_HOST` | `bool NETWORK_SESSION_HOST(int p0, int maxPlayers, bool p2)` | bool |
| `NETWORK_SESSION_HOST_CLOSED` | `bool NETWORK_SESSION_HOST_CLOSED(int p0, int maxPlayers)` | bool |
| `NETWORK_SESSION_HOST_FRIENDS_ONLY` | `bool NETWORK_SESSION_HOST_FRIENDS_ONLY(int p0, int maxPlayers)` | bool |
| `NETWORK_SESSION_HOST_SINGLE_PLAYER` | `void NETWORK_SESSION_HOST_SINGLE_PLAYER(int p0)` | void |
| `NETWORK_SESSION_IS_AWAITING_INVITE_RESPONSE` | `bool NETWORK_SESSION_IS_AWAITING_INVITE_RESPONSE()` | bool |
| `NETWORK_SESSION_IS_CLOSED_CREW` | `bool NETWORK_SESSION_IS_CLOSED_CREW()` | bool |
| `NETWORK_SESSION_IS_CLOSED_FRIENDS` | `bool NETWORK_SESSION_IS_CLOSED_FRIENDS()` | bool |
| `NETWORK_SESSION_IS_DISPLAYING_INVITE_CONFIRMATION` | `bool NETWORK_SESSION_IS_DISPLAYING_INVITE_CONFIRMATION()` | bool |
| `NETWORK_SESSION_IS_IN_VOICE_SESSION` | `bool NETWORK_SESSION_IS_IN_VOICE_SESSION()` | bool |
| `NETWORK_SESSION_IS_PRIVATE` | `bool NETWORK_SESSION_IS_PRIVATE()` | bool |
| `NETWORK_SESSION_IS_SOLO` | `bool NETWORK_SESSION_IS_SOLO()` | bool |
| `NETWORK_SESSION_IS_VISIBLE` | `bool NETWORK_SESSION_IS_VISIBLE()` | bool |
| `NETWORK_SESSION_IS_VOICE_SESSION_ACTIVE` | `bool NETWORK_SESSION_IS_VOICE_SESSION_ACTIVE()` | bool |
| `NETWORK_SESSION_IS_VOICE_SESSION_BUSY` | `bool NETWORK_SESSION_IS_VOICE_SESSION_BUSY()` | bool |
| `NETWORK_SESSION_JOIN_INVITE` | `void NETWORK_SESSION_JOIN_INVITE()` | void |
| `NETWORK_SESSION_KICK_PLAYER` | `void NETWORK_SESSION_KICK_PLAYER(int player)` | void |
| `NETWORK_SESSION_LEAVE` | `bool NETWORK_SESSION_LEAVE(object p0)` | bool |
| `NETWORK_SESSION_LEAVE_SINGLE_PLAYER` | `void NETWORK_SESSION_LEAVE_SINGLE_PLAYER()` | void |
| `NETWORK_SESSION_MARK_VISIBLE` | `void NETWORK_SESSION_MARK_VISIBLE(bool toggle)` | void |
| `NETWORK_SESSION_RESERVE_SLOTS_TRANSITION` | `bool NETWORK_SESSION_RESERVE_SLOTS_TRANSITION(object p0, object p1, object p2)` | bool |
| `NETWORK_SESSION_SET_CREW_LIMIT_MAX_MEMBERS_TRANSITION` | `void NETWORK_SESSION_SET_CREW_LIMIT_MAX_MEMBERS_TRANSITION(object p0)` | void |
| `NETWORK_SESSION_SET_GAMEMODE` | `void NETWORK_SESSION_SET_GAMEMODE(object p0)` | void |
| `NETWORK_SESSION_SET_MATCHMAKING_GROUP` | `void NETWORK_SESSION_SET_MATCHMAKING_GROUP(int matchmakingGroup)` | void |
| `NETWORK_SESSION_SET_MATCHMAKING_GROUP_MAX` | `void NETWORK_SESSION_SET_MATCHMAKING_GROUP_MAX(int playerType, int playerCount)` | void |
| `NETWORK_SESSION_SET_MATCHMAKING_MENTAL_STATE` | `void NETWORK_SESSION_SET_MATCHMAKING_MENTAL_STATE(int p0)` | void |
| `NETWORK_SESSION_SET_MATCHMAKING_PROPERTY_ID` | `void NETWORK_SESSION_SET_MATCHMAKING_PROPERTY_ID(bool p0)` | void |
| `NETWORK_SESSION_SET_NUM_BOSSES` | `void NETWORK_SESSION_SET_NUM_BOSSES(int num)` | void |
| `NETWORK_SESSION_SET_SCRIPT_VALIDATE_JOIN` | `void NETWORK_SESSION_SET_SCRIPT_VALIDATE_JOIN()` | void |
| `NETWORK_SESSION_SET_UNIQUE_CREW_LIMIT` | `void NETWORK_SESSION_SET_UNIQUE_CREW_LIMIT(object p0)` | void |
| `NETWORK_SESSION_SET_UNIQUE_CREW_LIMIT_TRANSITION` | `void NETWORK_SESSION_SET_UNIQUE_CREW_LIMIT_TRANSITION(object p0)` | void |
| `NETWORK_SESSION_SET_UNIQUE_CREW_ONLY_CREWS_TRANSITION` | `void NETWORK_SESSION_SET_UNIQUE_CREW_ONLY_CREWS_TRANSITION(bool p0)` | void |
| `NETWORK_SESSION_VALIDATE_JOIN` | `void NETWORK_SESSION_VALIDATE_JOIN(bool p0)` | void |
| `NETWORK_SESSION_VOICE_CONNECT_TO_PLAYER` | `void NETWORK_SESSION_VOICE_CONNECT_TO_PLAYER(ref object gamerHandle)` | void |
| `NETWORK_SESSION_VOICE_HOST` | `bool NETWORK_SESSION_VOICE_HOST()` | bool |
| `NETWORK_SESSION_VOICE_LEAVE` | `bool NETWORK_SESSION_VOICE_LEAVE()` | bool |
| `NETWORK_SESSION_VOICE_RESPOND_TO_REQUEST` | `void NETWORK_SESSION_VOICE_RESPOND_TO_REQUEST(bool p0, int p1)` | void |
| `NETWORK_SESSION_VOICE_SET_TIMEOUT` | `void NETWORK_SESSION_VOICE_SET_TIMEOUT(int timeout)` | void |
| `NETWORK_SESSION_WAS_INVITED` | `bool NETWORK_SESSION_WAS_INVITED()` | bool |
| `NETWORK_SET_ACTIVITY_PLAYER_MAX` | `void NETWORK_SET_ACTIVITY_PLAYER_MAX(object p0)` | void |
| `NETWORK_SET_ACTIVITY_SPECTATOR` | `void NETWORK_SET_ACTIVITY_SPECTATOR(bool toggle)` | void |
| `NETWORK_SET_ACTIVITY_SPECTATOR_MAX` | `void NETWORK_SET_ACTIVITY_SPECTATOR_MAX(int maxSpectators)` | void |
| `NETWORK_SET_ANTAGONISTIC_TO_PLAYER` | `void NETWORK_SET_ANTAGONISTIC_TO_PLAYER(bool toggle, int player)` | void |
| `NETWORK_SET_ATTRIBUTE_DAMAGE_TO_PLAYER` | `bool NETWORK_SET_ATTRIBUTE_DAMAGE_TO_PLAYER(int ped, int player)` | bool |
| `NETWORK_SET_CAN_RECEIVE_RS_INVITES` | `void NETWORK_SET_CAN_RECEIVE_RS_INVITES(bool p0)` | void |
| `NETWORK_SET_CURRENTLY_SELECTED_GAMER_HANDLE_FROM_INVITE_MENU` | `bool NETWORK_SET_CURRENTLY_SELECTED_GAMER_HANDLE_FROM_INVITE_MENU(ref object p0)` | bool |
| `NETWORK_SET_CURRENT_CHAT_OPTION` | `void NETWORK_SET_CURRENT_CHAT_OPTION(int newChatOption)` | void |
| `NETWORK_SET_CURRENT_DATA_MANAGER_HANDLE` | `bool NETWORK_SET_CURRENT_DATA_MANAGER_HANDLE(ref object p0)` | bool |
| `NETWORK_SET_CURRENT_PUBLIC_CONTENT_ID` | `void NETWORK_SET_CURRENT_PUBLIC_CONTENT_ID(string missionId)` | void |
| `NETWORK_SET_CURRENT_SPAWN_LOCATION_OPTION` | `void NETWORK_SET_CURRENT_SPAWN_LOCATION_OPTION(uint mpSettingSpawn)` | void |
| `NETWORK_SET_CUSTOM_ARENA_BALL_PARAMS` | `void NETWORK_SET_CUSTOM_ARENA_BALL_PARAMS(int netId)` | void |
| `NETWORK_SET_DO_NOT_LAUNCH_FROM_JOIN_AS_MIGRATED_HOST` | `void NETWORK_SET_DO_NOT_LAUNCH_FROM_JOIN_AS_MIGRATED_HOST(bool toggle)` | void |
| `NETWORK_SET_ENTITY_CAN_BLEND` | `void NETWORK_SET_ENTITY_CAN_BLEND(int entity, bool toggle)` | void |
| `NETWORK_SET_ENTITY_ONLY_EXISTS_FOR_PARTICIPANTS` | `void NETWORK_SET_ENTITY_ONLY_EXISTS_FOR_PARTICIPANTS(int entity, bool toggle)` | void |
| `NETWORK_SET_FRIENDLY_FIRE_OPTION` | `void NETWORK_SET_FRIENDLY_FIRE_OPTION(bool toggle)` | void |
| `NETWORK_SET_GAMER_INVITED_TO_TRANSITION` | `void NETWORK_SET_GAMER_INVITED_TO_TRANSITION(ref object gamerHandle)` | void |
| `NETWORK_SET_IGNORE_SPECTATOR_CHAT_LIMITS_SAME_TEAM` | `void NETWORK_SET_IGNORE_SPECTATOR_CHAT_LIMITS_SAME_TEAM(bool toggle)` | void |
| `NETWORK_SET_INVITE_FAILED_MESSAGE_FOR_INVITE_MENU` | `void NETWORK_SET_INVITE_FAILED_MESSAGE_FOR_INVITE_MENU(ref object p0, ref object p1)` | void |
| `NETWORK_SET_INVITE_ON_CALL_FOR_INVITE_MENU` | `void NETWORK_SET_INVITE_ON_CALL_FOR_INVITE_MENU(ref object p0)` | void |
| `NETWORK_SET_IN_FREE_CAM_MODE` | `void NETWORK_SET_IN_FREE_CAM_MODE(bool toggle)` | void |
| `NETWORK_SET_IN_MP_CUTSCENE` | `void NETWORK_SET_IN_MP_CUTSCENE(bool p0, bool p1)` | void |
| `NETWORK_SET_IN_PROGRESS_FINISH_TIME` | `void NETWORK_SET_IN_PROGRESS_FINISH_TIME(object p0)` | void |
| `NETWORK_SET_IN_SPECTATOR_MODE` | `void NETWORK_SET_IN_SPECTATOR_MODE(bool toggle, int playerPed)` | void |
| `NETWORK_SET_IN_SPECTATOR_MODE_EXTENDED` | `void NETWORK_SET_IN_SPECTATOR_MODE_EXTENDED(bool toggle, int playerPed, bool p2)` | void |
| `NETWORK_SET_LOCAL_PLAYER_INVINCIBLE_TIME` | `void NETWORK_SET_LOCAL_PLAYER_INVINCIBLE_TIME(int time)` | void |
| `NETWORK_SET_LOCAL_PLAYER_SYNC_LOOK_AT` | `void NETWORK_SET_LOCAL_PLAYER_SYNC_LOOK_AT(bool toggle)` | void |
| `NETWORK_SET_LOOK_AT_TALKERS` | `void NETWORK_SET_LOOK_AT_TALKERS(bool p0)` | void |
| `NETWORK_SET_MINIMUM_RANK_FOR_MISSION` | `void NETWORK_SET_MINIMUM_RANK_FOR_MISSION(bool p0)` | void |
| `NETWORK_SET_MISSION_FINISHED` | `void NETWORK_SET_MISSION_FINISHED()` | void |
| `NETWORK_SET_NO_LONGER_NEEDED` | `void NETWORK_SET_NO_LONGER_NEEDED(int entity, bool toggle)` | void |
| `NETWORK_SET_NO_SPECTATOR_CHAT` | `void NETWORK_SET_NO_SPECTATOR_CHAT(bool toggle)` | void |
| `NETWORK_SET_OBJECT_CAN_BLEND_WHEN_FIXED` | `void NETWORK_SET_OBJECT_CAN_BLEND_WHEN_FIXED(int object, bool toggle)` | void |
| `NETWORK_SET_OBJECT_SCOPE_DISTANCE` | `void NETWORK_SET_OBJECT_SCOPE_DISTANCE(int object, float range)` | void |
| `NETWORK_SET_OVERRIDE_SPECTATOR_MODE` | `void NETWORK_SET_OVERRIDE_SPECTATOR_MODE(bool toggle)` | void |
| `NETWORK_SET_OVERRIDE_TUTORIAL_SESSION_CHAT` | `void NETWORK_SET_OVERRIDE_TUTORIAL_SESSION_CHAT(bool toggle)` | void |
| `NETWORK_SET_PLAYER_IS_PASSIVE` | `void NETWORK_SET_PLAYER_IS_PASSIVE(bool toggle)` | void |
| `NETWORK_SET_PLAYER_MENTAL_STATE` | `void NETWORK_SET_PLAYER_MENTAL_STATE(int p0)` | void |
| `NETWORK_SET_PRESENCE_SESSION_INVITES_BLOCKED` | `void NETWORK_SET_PRESENCE_SESSION_INVITES_BLOCKED(bool toggle)` | void |
| `NETWORK_SET_PRIVILEGE_CHECK_RESULT_NOT_NEEDED` | `void NETWORK_SET_PRIVILEGE_CHECK_RESULT_NOT_NEEDED()` | void |
| `NETWORK_SET_PROXIMITY_AFFECTS_TEAM` | `void NETWORK_SET_PROXIMITY_AFFECTS_TEAM(bool toggle)` | void |
| `NETWORK_SET_RICH_PRESENCE` | `void NETWORK_SET_RICH_PRESENCE(int p0, int p1, object p2, object p3)` | void |
| `NETWORK_SET_RICH_PRESENCE_STRING` | `void NETWORK_SET_RICH_PRESENCE_STRING(int p0, string textLabel)` | void |
| `NETWORK_SET_SAME_TEAM_AS_LOCAL_PLAYER` | `bool NETWORK_SET_SAME_TEAM_AS_LOCAL_PLAYER(object p0, object p1)` | bool |
| `NETWORK_SET_SCRIPT_AUTOMUTED` | `bool NETWORK_SET_SCRIPT_AUTOMUTED(object p0)` | bool |
| `NETWORK_SET_SCRIPT_CONTROLLING_TEAMS` | `void NETWORK_SET_SCRIPT_CONTROLLING_TEAMS(object p0)` | void |
| `NETWORK_SET_SCRIPT_READY_FOR_EVENTS` | `void NETWORK_SET_SCRIPT_READY_FOR_EVENTS(bool toggle)` | void |
| `NETWORK_SET_SPECTATOR_TO_NON_SPECTATOR_TEXT_CHAT` | `void NETWORK_SET_SPECTATOR_TO_NON_SPECTATOR_TEXT_CHAT(bool toggle)` | void |
| `NETWORK_SET_TALKER_PROXIMITY` | `void NETWORK_SET_TALKER_PROXIMITY(float value)` | void |
| `NETWORK_SET_TASK_CUTSCENE_INSCOPE_MULTIPLER` | `void NETWORK_SET_TASK_CUTSCENE_INSCOPE_MULTIPLER(float multiplier)` | void |
| `NETWORK_SET_TEAM_ONLY_CHAT` | `void NETWORK_SET_TEAM_ONLY_CHAT(bool toggle)` | void |
| `NETWORK_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT` | `void NETWORK_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT(int maxNumMissionParticipants, bool p1, int instanceId)` | void |
| `NETWORK_SET_TRANSITION_ACTIVITY_ID` | `void NETWORK_SET_TRANSITION_ACTIVITY_ID(object p0)` | void |
| `NETWORK_SET_TRANSITION_CREATOR_HANDLE` | `void NETWORK_SET_TRANSITION_CREATOR_HANDLE(ref object p0)` | void |
| `NETWORK_SET_TRANSITION_VISIBILITY_LOCK` | `void NETWORK_SET_TRANSITION_VISIBILITY_LOCK(bool p0, bool p1)` | void |
| `NETWORK_SET_VEHICLE_DRIVEN_IN_TEST_DRIVE` | `void NETWORK_SET_VEHICLE_DRIVEN_IN_TEST_DRIVE(bool toggle)` | void |
| `NETWORK_SET_VEHICLE_DRIVEN_LOCATION` | `void NETWORK_SET_VEHICLE_DRIVEN_LOCATION(uint location)` | void |
| `NETWORK_SET_VOICE_ACTIVE` | `void NETWORK_SET_VOICE_ACTIVE(bool toggle)` | void |
| `NETWORK_SET_VOICE_CHANNEL` | `void NETWORK_SET_VOICE_CHANNEL(int channel)` | void |
| `NETWORK_SHOULD_SHOW_PROMOTION_ALERT_SCREEN` | `bool NETWORK_SHOULD_SHOW_PROMOTION_ALERT_SCREEN()` | bool |
| `NETWORK_SHOULD_SHOW_STRICT_NAT_WARNING` | `bool NETWORK_SHOULD_SHOW_STRICT_NAT_WARNING()` | bool |
| `NETWORK_SHOW_ACCOUNT_UPGRADE_UI` | `void NETWORK_SHOW_ACCOUNT_UPGRADE_UI()` | void |
| `NETWORK_SHOW_CHAT_RESTRICTION_MSC` | `void NETWORK_SHOW_CHAT_RESTRICTION_MSC(int player)` | void |
| `NETWORK_SHOW_PROFILE_UI` | `void NETWORK_SHOW_PROFILE_UI(ref object gamerHandle)` | void |
| `NETWORK_SHOW_PSN_UGC_RESTRICTION` | `void NETWORK_SHOW_PSN_UGC_RESTRICTION()` | void |
| `NETWORK_SKIP_RADIO_RESET_NEXT_CLOSE` | `void NETWORK_SKIP_RADIO_RESET_NEXT_CLOSE()` | void |
| `NETWORK_SKIP_RADIO_RESET_NEXT_OPEN` | `void NETWORK_SKIP_RADIO_RESET_NEXT_OPEN()` | void |
| `NETWORK_SKIP_RADIO_WARNING` | `bool NETWORK_SKIP_RADIO_WARNING()` | bool |
| `NETWORK_START_RESPAWN_SEARCH_FOR_PLAYER` | `bool NETWORK_START_RESPAWN_SEARCH_FOR_PLAYER(int player, float x, float y, float z, float radius, float p5, float p6, float p7, int flags)` | bool |
| `NETWORK_START_RESPAWN_SEARCH_IN_ANGLED_AREA_FOR_PLAYER` | `bool NETWORK_START_RESPAWN_SEARCH_IN_ANGLED_AREA_FOR_PLAYER(int player, float x1, float y1, float z1, float x2, float y2, float z2, float width, float p8, float p9, float p10, int flags)` | bool |
| `NETWORK_START_SOLO_TUTORIAL_SESSION` | `void NETWORK_START_SOLO_TUTORIAL_SESSION()` | void |
| `NETWORK_START_SYNCHRONISED_SCENE` | `void NETWORK_START_SYNCHRONISED_SCENE(int netScene)` | void |
| `NETWORK_START_USER_CONTENT_PERMISSIONS_CHECK` | `int NETWORK_START_USER_CONTENT_PERMISSIONS_CHECK(ref object netHandle)` | int |
| `NETWORK_STOP_SYNCHRONISED_SCENE` | `void NETWORK_STOP_SYNCHRONISED_SCENE(int netScene)` | void |
| `NETWORK_STORE_INVITE_THROUGH_RESTART` | `void NETWORK_STORE_INVITE_THROUGH_RESTART()` | void |
| `NETWORK_SUPPRESS_INVITE` | `void NETWORK_SUPPRESS_INVITE(bool toggle)` | void |
| `NETWORK_SYNC_CLOCK_TIME_OVERRIDE` | `void NETWORK_SYNC_CLOCK_TIME_OVERRIDE()` | void |
| `NETWORK_TEXT_CHAT_IS_TYPING` | `bool NETWORK_TEXT_CHAT_IS_TYPING()` | bool |
| `NETWORK_TRANSITION_ADD_STAGE` | `bool NETWORK_TRANSITION_ADD_STAGE(uint hash, int p1, int p2, int state, int p4)` | bool |
| `NETWORK_TRANSITION_BLOCK_JOIN_REQUESTS` | `void NETWORK_TRANSITION_BLOCK_JOIN_REQUESTS(bool p0)` | void |
| `NETWORK_TRANSITION_FINISH` | `bool NETWORK_TRANSITION_FINISH(object p0, object p1, object p2)` | bool |
| `NETWORK_TRANSITION_SET_ACTIVITY_ISLAND` | `void NETWORK_TRANSITION_SET_ACTIVITY_ISLAND(object p0)` | void |
| `NETWORK_TRANSITION_SET_CONTENT_CREATOR` | `void NETWORK_TRANSITION_SET_CONTENT_CREATOR(object p0)` | void |
| `NETWORK_TRANSITION_SET_IN_PROGRESS` | `void NETWORK_TRANSITION_SET_IN_PROGRESS(object p0)` | void |
| `NETWORK_TRANSITION_START` | `bool NETWORK_TRANSITION_START(int p0, object p1, object p2, object p3)` | bool |
| `NETWORK_TRIGGER_DAMAGE_EVENT_FOR_ZERO_DAMAGE` | `void NETWORK_TRIGGER_DAMAGE_EVENT_FOR_ZERO_DAMAGE(int entity, bool toggle)` | void |
| `NETWORK_TRIGGER_DAMAGE_EVENT_FOR_ZERO_WEAPON_HASH` | `void NETWORK_TRIGGER_DAMAGE_EVENT_FOR_ZERO_WEAPON_HASH(int entity, bool toggle)` | void |
| `NETWORK_TRY_ACCESS_TUNABLE_BOOL_HASH` | `bool NETWORK_TRY_ACCESS_TUNABLE_BOOL_HASH(uint tunableContext, uint tunableName, bool defaultValue)` | bool |
| `NETWORK_TRY_TO_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT` | `bool NETWORK_TRY_TO_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT(object p0, bool p1, object p2)` | bool |
| `NETWORK_UGC_NAV` | `void NETWORK_UGC_NAV(object p0, object p1)` | void |
| `NETWORK_UNREGISTER_NETWORKED_ENTITY` | `void NETWORK_UNREGISTER_NETWORKED_ENTITY(int entity)` | void |
| `NETWORK_USE_HIGH_PRECISION_BLENDING` | `void NETWORK_USE_HIGH_PRECISION_BLENDING(int netID, bool toggle)` | void |
| `NETWORK_USE_LOGARITHMIC_BLENDING_THIS_FRAME` | `void NETWORK_USE_LOGARITHMIC_BLENDING_THIS_FRAME(int entity)` | void |
| `NETWORK_WAITING_POP_CLEAR_TUTORIAL_SESSION` | `bool NETWORK_WAITING_POP_CLEAR_TUTORIAL_SESSION()` | bool |
| `NETWORK_WAS_GAME_SUSPENDED` | `bool NETWORK_WAS_GAME_SUSPENDED()` | bool |
| `NET_GAMESERVER_BASKET_ADD_ITEM` | `bool NET_GAMESERVER_BASKET_ADD_ITEM(ref object itemData, int quantity)` | bool |
| `NET_GAMESERVER_BASKET_APPLY_SERVER_DATA` | `bool NET_GAMESERVER_BASKET_APPLY_SERVER_DATA(object p0, ref object p1)` | bool |
| `NET_GAMESERVER_BASKET_END` | `bool NET_GAMESERVER_BASKET_END()` | bool |
| `NET_GAMESERVER_BASKET_IS_ACTIVE` | `bool NET_GAMESERVER_BASKET_IS_ACTIVE()` | bool |
| `NET_GAMESERVER_BASKET_IS_FULL` | `bool NET_GAMESERVER_BASKET_IS_FULL()` | bool |
| `NET_GAMESERVER_BASKET_START` | `bool NET_GAMESERVER_BASKET_START(ref int transactionId, uint categoryHash, uint actionHash, int flags)` | bool |
| `NET_GAMESERVER_BEGIN_SERVICE` | `bool NET_GAMESERVER_BEGIN_SERVICE(ref int transactionId, uint categoryHash, uint itemHash, uint actionTypeHash, int value, int flags)` | bool |
| `NET_GAMESERVER_CATALOG_IS_VALID` | `bool NET_GAMESERVER_CATALOG_IS_VALID()` | bool |
| `NET_GAMESERVER_CATALOG_ITEM_IS_VALID` | `bool NET_GAMESERVER_CATALOG_ITEM_IS_VALID(string name)` | bool |
| `NET_GAMESERVER_CATALOG_ITEM_KEY_IS_VALID` | `bool NET_GAMESERVER_CATALOG_ITEM_KEY_IS_VALID(uint hash)` | bool |
| `NET_GAMESERVER_CHECKOUT_PENDING` | `bool NET_GAMESERVER_CHECKOUT_PENDING(int transactionId)` | bool |
| `NET_GAMESERVER_CHECKOUT_START` | `bool NET_GAMESERVER_CHECKOUT_START(int transactionId)` | bool |
| `NET_GAMESERVER_CLEAR_SESSION` | `bool NET_GAMESERVER_CLEAR_SESSION(int p0)` | bool |
| `NET_GAMESERVER_DELETE_CHARACTER` | `bool NET_GAMESERVER_DELETE_CHARACTER(int slot, bool transfer, uint reason)` | bool |
| `NET_GAMESERVER_DELETE_CHARACTER_GET_STATUS` | `int NET_GAMESERVER_DELETE_CHARACTER_GET_STATUS()` | int |
| `NET_GAMESERVER_DELETE_SET_TELEMETRY_NONCE_SEED` | `bool NET_GAMESERVER_DELETE_SET_TELEMETRY_NONCE_SEED()` | bool |
| `NET_GAMESERVER_END_SERVICE` | `bool NET_GAMESERVER_END_SERVICE(int transactionId)` | bool |
| `NET_GAMESERVER_GET_CATALOG_CLOUD_CRC` | `uint NET_GAMESERVER_GET_CATALOG_CLOUD_CRC()` | uint |
| `NET_GAMESERVER_GET_PRICE` | `int NET_GAMESERVER_GET_PRICE(uint itemHash, uint categoryHash, bool p2)` | int |
| `NET_GAMESERVER_GET_SESSION_STATE_AND_STATUS` | `bool NET_GAMESERVER_GET_SESSION_STATE_AND_STATUS(ref int p0, ref bool p1)` | bool |
| `NET_GAMESERVER_INIT_SESSION` | `bool NET_GAMESERVER_INIT_SESSION()` | bool |
| `NET_GAMESERVER_IS_CATALOG_CURRENT` | `bool NET_GAMESERVER_IS_CATALOG_CURRENT()` | bool |
| `NET_GAMESERVER_IS_SESSION_REFRESH_PENDING` | `bool NET_GAMESERVER_IS_SESSION_REFRESH_PENDING()` | bool |
| `NET_GAMESERVER_IS_SESSION_VALID` | `bool NET_GAMESERVER_IS_SESSION_VALID(int charSlot)` | bool |
| `NET_GAMESERVER_REFRESH_SERVER_CATALOG` | `bool NET_GAMESERVER_REFRESH_SERVER_CATALOG()` | bool |
| `NET_GAMESERVER_RETRIEVE_CATALOG_REFRESH_STATUS` | `bool NET_GAMESERVER_RETRIEVE_CATALOG_REFRESH_STATUS(ref int state)` | bool |
| `NET_GAMESERVER_RETRIEVE_INIT_SESSION_STATUS` | `bool NET_GAMESERVER_RETRIEVE_INIT_SESSION_STATUS(ref int p0)` | bool |
| `NET_GAMESERVER_RETRIEVE_SESSION_ERROR_CODE` | `bool NET_GAMESERVER_RETRIEVE_SESSION_ERROR_CODE(ref int p0)` | bool |
| `NET_GAMESERVER_RETRIEVE_START_SESSION_STATUS` | `bool NET_GAMESERVER_RETRIEVE_START_SESSION_STATUS(ref int p0)` | bool |
| `NET_GAMESERVER_SESSION_APPLY_RECEIVED_DATA` | `bool NET_GAMESERVER_SESSION_APPLY_RECEIVED_DATA(int charSlot)` | bool |
| `NET_GAMESERVER_SET_TELEMETRY_NONCE_SEED` | `bool NET_GAMESERVER_SET_TELEMETRY_NONCE_SEED(int p0)` | bool |
| `NET_GAMESERVER_START_SESSION` | `bool NET_GAMESERVER_START_SESSION(int charSlot)` | bool |
| `NET_GAMESERVER_START_SESSION_PENDING` | `bool NET_GAMESERVER_START_SESSION_PENDING()` | bool |
| `NET_GAMESERVER_START_SESSION_RESTART` | `bool NET_GAMESERVER_START_SESSION_RESTART(bool inventory, bool playerbalance)` | bool |
| `NET_GAMESERVER_TRANSACTION_IN_PROGRESS` | `bool NET_GAMESERVER_TRANSACTION_IN_PROGRESS()` | bool |
| `NET_GAMESERVER_TRANSFER_BANK_TO_WALLET` | `bool NET_GAMESERVER_TRANSFER_BANK_TO_WALLET(int charSlot, int amount)` | bool |
| `NET_GAMESERVER_TRANSFER_BANK_TO_WALLET_GET_STATUS` | `int NET_GAMESERVER_TRANSFER_BANK_TO_WALLET_GET_STATUS()` | int |
| `NET_GAMESERVER_TRANSFER_CASH_SET_TELEMETRY_NONCE_SEED` | `bool NET_GAMESERVER_TRANSFER_CASH_SET_TELEMETRY_NONCE_SEED()` | bool |
| `NET_GAMESERVER_TRANSFER_WALLET_TO_BANK` | `bool NET_GAMESERVER_TRANSFER_WALLET_TO_BANK(int charSlot, int amount)` | bool |
| `NET_GAMESERVER_TRANSFER_WALLET_TO_BANK_GET_STATUS` | `int NET_GAMESERVER_TRANSFER_WALLET_TO_BANK_GET_STATUS()` | int |
| `NET_GAMESERVER_USE_SERVER_TRANSACTIONS` | `bool NET_GAMESERVER_USE_SERVER_TRANSACTIONS()` | bool |
| `NET_TO_ENT` | `int NET_TO_ENT(int netHandle)` | int |
| `NET_TO_OBJ` | `int NET_TO_OBJ(int netHandle)` | int |
| `NET_TO_PED` | `int NET_TO_PED(int netHandle)` | int |
| `NET_TO_VEH` | `int NET_TO_VEH(int netHandle)` | int |
| `OBJ_TO_NET` | `int OBJ_TO_NET(int object)` | int |
| `OPEN_COMMERCE_STORE` | `void OPEN_COMMERCE_STORE(string p0, string p1, int p2)` | void |
| `PARTICIPANT_ID` | `int PARTICIPANT_ID()` | int |
| `PARTICIPANT_ID_TO_INT` | `int PARTICIPANT_ID_TO_INT()` | int |
| `PED_TO_NET` | `int PED_TO_NET(int ped)` | int |
| `REFRESH_PLAYER_LIST_STATS` | `bool REFRESH_PLAYER_LIST_STATS(int p0)` | bool |
| `RELEASE_ALL_COMMERCE_ITEM_IMAGES` | `void RELEASE_ALL_COMMERCE_ITEM_IMAGES()` | void |
| `REMOTE_CHEATER_PLAYER_DETECTED` | `bool REMOTE_CHEATER_PLAYER_DETECTED(int player, int a, int b)` | bool |
| `REMOVE_ALL_STICKY_BOMBS_FROM_ENTITY` | `void REMOVE_ALL_STICKY_BOMBS_FROM_ENTITY(int entity, int ped)` | void |
| `REQUEST_COMMERCE_ITEM_IMAGE` | `bool REQUEST_COMMERCE_ITEM_IMAGE(int index)` | bool |
| `RESERVE_LOCAL_NETWORK_MISSION_OBJECTS` | `void RESERVE_LOCAL_NETWORK_MISSION_OBJECTS(int amount)` | void |
| `RESERVE_LOCAL_NETWORK_MISSION_PEDS` | `void RESERVE_LOCAL_NETWORK_MISSION_PEDS(int amount)` | void |
| `RESERVE_LOCAL_NETWORK_MISSION_VEHICLES` | `void RESERVE_LOCAL_NETWORK_MISSION_VEHICLES(int amount)` | void |
| `RESERVE_NETWORK_MISSION_OBJECTS` | `void RESERVE_NETWORK_MISSION_OBJECTS(int amount)` | void |
| `RESERVE_NETWORK_MISSION_PEDS` | `void RESERVE_NETWORK_MISSION_PEDS(int amount)` | void |
| `RESERVE_NETWORK_MISSION_VEHICLES` | `void RESERVE_NETWORK_MISSION_VEHICLES(int amount)` | void |
| `RESET_GHOST_ALPHA` | `void RESET_GHOST_ALPHA()` | void |
| `RESET_STORE_NETWORK_GAME_TRACKING` | `void RESET_STORE_NETWORK_GAME_TRACKING()` | void |
| `SET_ENTITY_GHOSTED_FOR_GHOST_PLAYERS` | `void SET_ENTITY_GHOSTED_FOR_GHOST_PLAYERS(int entity, bool toggle)` | void |
| `SET_ENTITY_LOCALLY_INVISIBLE` | `void SET_ENTITY_LOCALLY_INVISIBLE(int entity)` | void |
| `SET_ENTITY_LOCALLY_VISIBLE` | `void SET_ENTITY_LOCALLY_VISIBLE(int entity)` | void |
| `SET_ENTITY_VISIBLE_IN_CUTSCENE` | `void SET_ENTITY_VISIBLE_IN_CUTSCENE(object p0, bool p1, bool p2)` | void |
| `SET_GHOST_ALPHA` | `void SET_GHOST_ALPHA(int alpha)` | void |
| `SET_INVERT_GHOSTING` | `void SET_INVERT_GHOSTING(bool p0)` | void |
| `SET_LAST_VIEWED_SHOP_ITEM` | `void SET_LAST_VIEWED_SHOP_ITEM(uint p0, int p1, uint p2)` | void |
| `SET_LOCAL_PLAYER_AS_GHOST` | `void SET_LOCAL_PLAYER_AS_GHOST(bool toggle, bool p1)` | void |
| `SET_LOCAL_PLAYER_INVISIBLE_LOCALLY` | `void SET_LOCAL_PLAYER_INVISIBLE_LOCALLY(bool bIncludePlayersVehicle)` | void |
| `SET_LOCAL_PLAYER_VISIBLE_IN_CUTSCENE` | `void SET_LOCAL_PLAYER_VISIBLE_IN_CUTSCENE(bool p0, bool p1)` | void |
| `SET_LOCAL_PLAYER_VISIBLE_LOCALLY` | `void SET_LOCAL_PLAYER_VISIBLE_LOCALLY(bool bIncludePlayersVehicle)` | void |
| `SET_NETWORK_CUTSCENE_ENTITIES` | `void SET_NETWORK_CUTSCENE_ENTITIES(bool toggle)` | void |
| `SET_NETWORK_ENABLE_HIGH_SPEED_EDGE_FALL_DETECTION` | `void SET_NETWORK_ENABLE_HIGH_SPEED_EDGE_FALL_DETECTION(int vehicle, bool toggle)` | void |
| `SET_NETWORK_ID_ALWAYS_EXISTS_FOR_PLAYER` | `void SET_NETWORK_ID_ALWAYS_EXISTS_FOR_PLAYER(int netId, int player, bool toggle)` | void |
| `SET_NETWORK_ID_CAN_BE_REASSIGNED` | `void SET_NETWORK_ID_CAN_BE_REASSIGNED(int netId, bool toggle)` | void |
| `SET_NETWORK_ID_CAN_MIGRATE` | `void SET_NETWORK_ID_CAN_MIGRATE(int netId, bool toggle)` | void |
| `SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES` | `void SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES(int netId, bool toggle)` | void |
| `SET_NETWORK_ID_PASS_CONTROL_IN_TUTORIAL` | `void SET_NETWORK_ID_PASS_CONTROL_IN_TUTORIAL(int netId, bool state)` | void |
| `SET_NETWORK_ID_VISIBLE_IN_CUTSCENE` | `void SET_NETWORK_ID_VISIBLE_IN_CUTSCENE(int netId, bool p1, bool p2)` | void |
| `SET_NETWORK_ID_VISIBLE_IN_CUTSCENE_HACK` | `void SET_NETWORK_ID_VISIBLE_IN_CUTSCENE_HACK(int netId, bool p1, bool p2)` | void |
| `SET_NETWORK_ID_VISIBLE_IN_CUTSCENE_REMAIN_HACK` | `void SET_NETWORK_ID_VISIBLE_IN_CUTSCENE_REMAIN_HACK(object p0, object p1, object p2)` | void |
| `SET_NETWORK_VEHICLE_AS_GHOST` | `void SET_NETWORK_VEHICLE_AS_GHOST(int vehicle, bool toggle)` | void |
| `SET_NETWORK_VEHICLE_MAX_POSITION_DELTA_MULTIPLIER` | `void SET_NETWORK_VEHICLE_MAX_POSITION_DELTA_MULTIPLIER(int vehicle, float multiplier)` | void |
| `SET_NETWORK_VEHICLE_RESPOT_TIMER` | `void SET_NETWORK_VEHICLE_RESPOT_TIMER(int netId, int time, object p2, object p3)` | void |
| `SET_NON_PARTICIPANTS_OF_THIS_SCRIPT_AS_GHOSTS` | `void SET_NON_PARTICIPANTS_OF_THIS_SCRIPT_AS_GHOSTS(bool p0)` | void |
| `SET_PLAYER_INVISIBLE_LOCALLY` | `void SET_PLAYER_INVISIBLE_LOCALLY(int player, bool bIncludePlayersVehicle)` | void |
| `SET_PLAYER_VISIBLE_LOCALLY` | `void SET_PLAYER_VISIBLE_LOCALLY(int player, bool bIncludePlayersVehicle)` | void |
| `SET_REMOTE_PLAYER_AS_GHOST` | `void SET_REMOTE_PLAYER_AS_GHOST(int player, bool p1)` | void |
| `SET_REMOTE_PLAYER_VISIBLE_IN_CUTSCENE` | `void SET_REMOTE_PLAYER_VISIBLE_IN_CUTSCENE(int player, bool locallyVisible)` | void |
| `SET_STORE_ENABLED` | `void SET_STORE_ENABLED(bool toggle)` | void |
| `SHUTDOWN_AND_LAUNCH_SINGLE_PLAYER_GAME` | `void SHUTDOWN_AND_LAUNCH_SINGLE_PLAYER_GAME()` | void |
| `SHUTDOWN_AND_LOAD_MOST_RECENT_SAVE` | `bool SHUTDOWN_AND_LOAD_MOST_RECENT_SAVE()` | bool |
| `SHUTDOWN_SESSION_CLEARS_AUTO_MULTIPLAYER` | `void SHUTDOWN_SESSION_CLEARS_AUTO_MULTIPLAYER(bool toggle)` | void |
| `TEXTURE_DOWNLOAD_GET_NAME` | `string TEXTURE_DOWNLOAD_GET_NAME(int p0)` | string |
| `TEXTURE_DOWNLOAD_HAS_FAILED` | `bool TEXTURE_DOWNLOAD_HAS_FAILED(int p0)` | bool |
| `TEXTURE_DOWNLOAD_RELEASE` | `void TEXTURE_DOWNLOAD_RELEASE(int p0)` | void |
| `TEXTURE_DOWNLOAD_REQUEST` | `int TEXTURE_DOWNLOAD_REQUEST(ref object gamerHandle, string filePath, string name, bool p3)` | int |
| `TITLE_TEXTURE_DOWNLOAD_REQUEST` | `int TITLE_TEXTURE_DOWNLOAD_REQUEST(string filePath, string name, bool p2)` | int |
| `TRIGGER_COMMERCE_DATA_FETCH` | `void TRIGGER_COMMERCE_DATA_FETCH(object p0)` | void |
| `UGC_CANCEL_QUERY` | `void UGC_CANCEL_QUERY()` | void |
| `UGC_CLEAR_CREATE_RESULT` | `void UGC_CLEAR_CREATE_RESULT()` | void |
| `UGC_CLEAR_MODIFY_RESULT` | `void UGC_CLEAR_MODIFY_RESULT()` | void |
| `UGC_CLEAR_OFFLINE_QUERY` | `void UGC_CLEAR_OFFLINE_QUERY()` | void |
| `UGC_CLEAR_QUERY_RESULTS` | `void UGC_CLEAR_QUERY_RESULTS()` | void |
| `UGC_COPY_CONTENT` | `bool UGC_COPY_CONTENT(ref object p0, ref object p1)` | bool |
| `UGC_DID_CREATE_SUCCEED` | `bool UGC_DID_CREATE_SUCCEED()` | bool |
| `UGC_DID_DESCRIPTION_REQUEST_SUCCEED` | `bool UGC_DID_DESCRIPTION_REQUEST_SUCCEED(object p0)` | bool |
| `UGC_DID_GET_SUCCEED` | `bool UGC_DID_GET_SUCCEED()` | bool |
| `UGC_DID_MODIFY_SUCCEED` | `bool UGC_DID_MODIFY_SUCCEED()` | bool |
| `UGC_DID_QUERY_CREATORS_SUCCEED` | `bool UGC_DID_QUERY_CREATORS_SUCCEED()` | bool |
| `UGC_GET_BOOKMARKED_CONTENT` | `bool UGC_GET_BOOKMARKED_CONTENT(object p0, object p1, string p2, ref object p3)` | bool |
| `UGC_GET_CACHED_DESCRIPTION` | `string UGC_GET_CACHED_DESCRIPTION(object p0, object p1)` | string |
| `UGC_GET_CONTENT_CATEGORY` | `int UGC_GET_CONTENT_CATEGORY(int p0)` | int |
| `UGC_GET_CONTENT_CREATED_BY_LOCAL_PLAYER` | `bool UGC_GET_CONTENT_CREATED_BY_LOCAL_PLAYER(object p0)` | bool |
| `UGC_GET_CONTENT_CREATOR_GAMER_HANDLE` | `bool UGC_GET_CONTENT_CREATOR_GAMER_HANDLE(int p0, ref object p1)` | bool |
| `UGC_GET_CONTENT_DESCRIPTION` | `string UGC_GET_CONTENT_DESCRIPTION(int index)` | string |
| `UGC_GET_CONTENT_DESCRIPTION_HASH` | `int UGC_GET_CONTENT_DESCRIPTION_HASH(object p0)` | int |
| `UGC_GET_CONTENT_FILE_VERSION` | `int UGC_GET_CONTENT_FILE_VERSION(object p0, object p1)` | int |
| `UGC_GET_CONTENT_HASH` | `uint UGC_GET_CONTENT_HASH()` | uint |
| `UGC_GET_CONTENT_HAS_HI_RES_PHOTO` | `bool UGC_GET_CONTENT_HAS_HI_RES_PHOTO(int p0)` | bool |
| `UGC_GET_CONTENT_HAS_LO_RES_PHOTO` | `bool UGC_GET_CONTENT_HAS_LO_RES_PHOTO(int p0)` | bool |
| `UGC_GET_CONTENT_HAS_PLAYER_BOOKMARKED` | `bool UGC_GET_CONTENT_HAS_PLAYER_BOOKMARKED(object p0)` | bool |
| `UGC_GET_CONTENT_HAS_PLAYER_RECORD` | `bool UGC_GET_CONTENT_HAS_PLAYER_RECORD(object p0)` | bool |
| `UGC_GET_CONTENT_ID` | `string UGC_GET_CONTENT_ID(int p0)` | string |
| `UGC_GET_CONTENT_IS_PUBLISHED` | `bool UGC_GET_CONTENT_IS_PUBLISHED(object p0)` | bool |
| `UGC_GET_CONTENT_IS_USING_SC_NICKNAME` | `bool UGC_GET_CONTENT_IS_USING_SC_NICKNAME(object p0)` | bool |
| `UGC_GET_CONTENT_IS_VERIFIED` | `bool UGC_GET_CONTENT_IS_VERIFIED(object p0)` | bool |
| `UGC_GET_CONTENT_LANGUAGE` | `int UGC_GET_CONTENT_LANGUAGE(object p0)` | int |
| `UGC_GET_CONTENT_NAME` | `string UGC_GET_CONTENT_NAME(object p0)` | string |
| `UGC_GET_CONTENT_NUM` | `int UGC_GET_CONTENT_NUM()` | int |
| `UGC_GET_CONTENT_PATH` | `string UGC_GET_CONTENT_PATH(int p0, int p1)` | string |
| `UGC_GET_CONTENT_RATING` | `float UGC_GET_CONTENT_RATING(object p0, object p1)` | float |
| `UGC_GET_CONTENT_RATING_COUNT` | `int UGC_GET_CONTENT_RATING_COUNT(object p0, object p1)` | int |
| `UGC_GET_CONTENT_RATING_NEGATIVE_COUNT` | `int UGC_GET_CONTENT_RATING_NEGATIVE_COUNT(object p0, object p1)` | int |
| `UGC_GET_CONTENT_RATING_POSITIVE_COUNT` | `int UGC_GET_CONTENT_RATING_POSITIVE_COUNT(object p0, object p1)` | int |
| `UGC_GET_CONTENT_TOTAL` | `int UGC_GET_CONTENT_TOTAL()` | int |
| `UGC_GET_CONTENT_UPDATED_DATE` | `void UGC_GET_CONTENT_UPDATED_DATE(object p0, ref object p1)` | void |
| `UGC_GET_CONTENT_USER_ID` | `string UGC_GET_CONTENT_USER_ID(int p0)` | string |
| `UGC_GET_CONTENT_USER_NAME` | `string UGC_GET_CONTENT_USER_NAME(object p0)` | string |
| `UGC_GET_CREATE_CONTENT_ID` | `string UGC_GET_CREATE_CONTENT_ID()` | string |
| `UGC_GET_CREATE_RESULT` | `int UGC_GET_CREATE_RESULT()` | int |
| `UGC_GET_CREATORS_BY_USER_ID` | `bool UGC_GET_CREATORS_BY_USER_ID(ref object p0, ref object p1)` | bool |
| `UGC_GET_CREATOR_NUM` | `int UGC_GET_CREATOR_NUM()` | int |
| `UGC_GET_CREW_CONTENT` | `bool UGC_GET_CREW_CONTENT(object p0, object p1, object p2, string p3, ref object p4)` | bool |
| `UGC_GET_FRIEND_CONTENT` | `bool UGC_GET_FRIEND_CONTENT(object p0, object p1, string p2, ref object p3)` | bool |
| `UGC_GET_GET_BY_CATEGORY` | `bool UGC_GET_GET_BY_CATEGORY(object p0, object p1, object p2, string p3, ref object p4)` | bool |
| `UGC_GET_GET_BY_CONTENT_ID` | `bool UGC_GET_GET_BY_CONTENT_ID(string contentId, string contentTypeName)` | bool |
| `UGC_GET_GET_BY_CONTENT_IDS` | `bool UGC_GET_GET_BY_CONTENT_IDS(ref object data, int dataCount, string contentTypeName)` | bool |
| `UGC_GET_MODIFY_RESULT` | `int UGC_GET_MODIFY_RESULT()` | int |
| `UGC_GET_MOST_RECENTLY_CREATED_CONTENT` | `bool UGC_GET_MOST_RECENTLY_CREATED_CONTENT(object p0, object p1, ref object p2, ref object p3)` | bool |
| `UGC_GET_MOST_RECENTLY_PLAYED_CONTENT` | `bool UGC_GET_MOST_RECENTLY_PLAYED_CONTENT(object p0, object p1, ref object p2, ref object p3)` | bool |
| `UGC_GET_MY_CONTENT` | `bool UGC_GET_MY_CONTENT(object p0, object p1, string p2, ref object p3)` | bool |
| `UGC_GET_QUERY_RESULT` | `int UGC_GET_QUERY_RESULT()` | int |
| `UGC_GET_ROOT_CONTENT_ID` | `string UGC_GET_ROOT_CONTENT_ID(int p0)` | string |
| `UGC_GET_TOP_RATED_CONTENT` | `bool UGC_GET_TOP_RATED_CONTENT(object p0, object p1, ref object p2, ref object p3)` | bool |
| `UGC_HAS_CREATE_FINISHED` | `bool UGC_HAS_CREATE_FINISHED()` | bool |
| `UGC_HAS_DESCRIPTION_REQUEST_FINISHED` | `bool UGC_HAS_DESCRIPTION_REQUEST_FINISHED(object p0)` | bool |
| `UGC_HAS_GET_FINISHED` | `bool UGC_HAS_GET_FINISHED()` | bool |
| `UGC_HAS_MODIFY_FINISHED` | `bool UGC_HAS_MODIFY_FINISHED()` | bool |
| `UGC_HAS_PERMISSION_TO_WRITE` | `bool UGC_HAS_PERMISSION_TO_WRITE()` | bool |
| `UGC_HAS_QUERY_CREATORS_FINISHED` | `bool UGC_HAS_QUERY_CREATORS_FINISHED()` | bool |
| `UGC_IS_CREATING` | `bool UGC_IS_CREATING()` | bool |
| `UGC_IS_DESCRIPTION_REQUEST_IN_PROGRESS` | `bool UGC_IS_DESCRIPTION_REQUEST_IN_PROGRESS(object p0)` | bool |
| `UGC_IS_GETTING` | `bool UGC_IS_GETTING()` | bool |
| `UGC_IS_LANGUAGE_SUPPORTED` | `bool UGC_IS_LANGUAGE_SUPPORTED(object p0)` | bool |
| `UGC_IS_MODIFYING` | `bool UGC_IS_MODIFYING()` | bool |
| `UGC_LOAD_OFFLINE_QUERY` | `bool UGC_LOAD_OFFLINE_QUERY(object p0)` | bool |
| `UGC_PUBLISH` | `bool UGC_PUBLISH(string contentId, string baseContentId, string contentTypeName)` | bool |
| `UGC_QUERY_BY_CATEGORY` | `bool UGC_QUERY_BY_CATEGORY(object p0, object p1, object p2, string p3, object p4, bool p5)` | bool |
| `UGC_QUERY_BY_CONTENT_ID` | `bool UGC_QUERY_BY_CONTENT_ID(string contentId, bool latestVersion, string contentTypeName)` | bool |
| `UGC_QUERY_BY_CONTENT_IDS` | `bool UGC_QUERY_BY_CONTENT_IDS(ref object data, int count, bool latestVersion, string contentTypeName)` | bool |
| `UGC_QUERY_MOST_RECENTLY_CREATED_CONTENT` | `bool UGC_QUERY_MOST_RECENTLY_CREATED_CONTENT(int offset, int count, string contentTypeName, int p3)` | bool |
| `UGC_QUERY_MY_CONTENT` | `bool UGC_QUERY_MY_CONTENT(object p0, object p1, ref object p2, object p3, object p4, object p5)` | bool |
| `UGC_RELEASE_ALL_CACHED_DESCRIPTIONS` | `void UGC_RELEASE_ALL_CACHED_DESCRIPTIONS()` | void |
| `UGC_RELEASE_CACHED_DESCRIPTION` | `bool UGC_RELEASE_CACHED_DESCRIPTION(object p0)` | bool |
| `UGC_REQUEST_CACHED_DESCRIPTION` | `int UGC_REQUEST_CACHED_DESCRIPTION(int p0)` | int |
| `UGC_REQUEST_CONTENT_DATA_FROM_INDEX` | `int UGC_REQUEST_CONTENT_DATA_FROM_INDEX(int p0, int p1)` | int |
| `UGC_REQUEST_CONTENT_DATA_FROM_PARAMS` | `int UGC_REQUEST_CONTENT_DATA_FROM_PARAMS(string contentTypeName, string contentId, int p2, int p3, int p4)` | int |
| `UGC_SET_BOOKMARKED` | `bool UGC_SET_BOOKMARKED(string contentId, bool bookmarked, string contentTypeName)` | bool |
| `UGC_SET_DELETED` | `bool UGC_SET_DELETED(ref object p0, bool p1, string p2)` | bool |
| `UGC_SET_QUERY_DATA_FROM_OFFLINE` | `void UGC_SET_QUERY_DATA_FROM_OFFLINE(bool p0)` | void |
| `UGC_SET_USING_OFFLINE_CONTENT` | `void UGC_SET_USING_OFFLINE_CONTENT(bool p0)` | void |
| `UGC_TEXTURE_DOWNLOAD_REQUEST` | `int UGC_TEXTURE_DOWNLOAD_REQUEST(string p0, int p1, int p2, int p3, string p4, bool p5)` | int |
| `UGC_WAS_QUERY_FORCE_CANCELLED` | `bool UGC_WAS_QUERY_FORCE_CANCELLED()` | bool |
| `USE_PLAYER_COLOUR_INSTEAD_OF_TEAM_COLOUR` | `void USE_PLAYER_COLOUR_INSTEAD_OF_TEAM_COLOUR(bool toggle)` | void |
| `VEH_TO_NET` | `int VEH_TO_NET(int vehicle)` | int |
| `_NETWORK_CAN_TEXT_FROM_GAMER_BE_VIEWED` | `bool _NETWORK_CAN_TEXT_FROM_GAMER_BE_VIEWED(ref object gamerHandle)` | bool |
| `_NETWORK_CLEAR_CLOCK_SYNC_TIME_OVERRIDE` | `void _NETWORK_CLEAR_CLOCK_SYNC_TIME_OVERRIDE(bool startGlobalTransition, int transitionTime)` | void |
| `_NETWORK_CLEAR_TUNABLES_REGISTRATION_CONTEXTS` | `void _NETWORK_CLEAR_TUNABLES_REGISTRATION_CONTEXTS()` | void |
| `_NETWORK_CONFIRM_GAME_RESTART` | `void _NETWORK_CONFIRM_GAME_RESTART()` | void |
| `_NETWORK_DOES_COMMUNICATION_GROUP_HAVE_PERMISSION` | `bool _NETWORK_DOES_COMMUNICATION_GROUP_HAVE_PERMISSION(int communicationType)` | bool |
| `_NETWORK_DOES_COMMUNICATION_GROUP_HAVE_SETTINGS_ENABLED` | `bool _NETWORK_DOES_COMMUNICATION_GROUP_HAVE_SETTINGS_ENABLED(int communicationType)` | bool |
| `_NETWORK_GET_ACCESS_CODE_LABEL_BODY` | `string _NETWORK_GET_ACCESS_CODE_LABEL_BODY(int accessCode)` | string |
| `_NETWORK_GET_ACCESS_CODE_LABEL_HEADING` | `string _NETWORK_GET_ACCESS_CODE_LABEL_HEADING(int accessCode)` | string |
| `_NETWORK_GET_BATTLEYE_ERROR_MESSAGE_LABEL` | `string _NETWORK_GET_BATTLEYE_ERROR_MESSAGE_LABEL(int errorCode)` | string |
| `_NETWORK_GET_BROADCAST_DATA_HOST_UPDATE_SIZE` | `int _NETWORK_GET_BROADCAST_DATA_HOST_UPDATE_SIZE(uint scriptNameHash, int instance, uint positionHash, int handlerNum)` | int |
| `_NETWORK_GET_BROADCAST_DATA_PLAYER_UPDATE_SIZE` | `int _NETWORK_GET_BROADCAST_DATA_PLAYER_UPDATE_SIZE(uint scriptNameHash, int instance, uint positionHash, int handlerNum)` | int |
| `_NETWORK_GET_COMMUNICATION_GROUP_DEFAULT_FLAGS` | `int _NETWORK_GET_COMMUNICATION_GROUP_DEFAULT_FLAGS(int communicationType)` | int |
| `_NETWORK_GET_COMMUNICATION_GROUP_FLAGS` | `int _NETWORK_GET_COMMUNICATION_GROUP_FLAGS(int communicationType)` | int |
| `_NETWORK_GET_COMMUNICATION_GROUP_VALUE` | `int _NETWORK_GET_COMMUNICATION_GROUP_VALUE(int communicationType)` | int |
| `_NETWORK_GET_DUMP_OF_ASSET_VERIFIER` | `void _NETWORK_GET_DUMP_OF_ASSET_VERIFIER(ref object p0)` | void |
| `_NETWORK_GET_GAME_RESTART_REASON` | `int _NETWORK_GET_GAME_RESTART_REASON()` | int |
| `_NETWORK_GET_GAME_RESTART_REASON_MESSAGE_LABEL` | `string _NETWORK_GET_GAME_RESTART_REASON_MESSAGE_LABEL()` | string |
| `_NETWORK_GET_HOST_BROADCAST_DATA_SIZE_UNSYNCED` | `int _NETWORK_GET_HOST_BROADCAST_DATA_SIZE_UNSYNCED(uint scriptNameHash, int instance, uint positionHash, int handlerNum)` | int |
| `_NETWORK_GET_PLAYER_BROADCAST_DATA_SIZE_UNSYNCED` | `int _NETWORK_GET_PLAYER_BROADCAST_DATA_SIZE_UNSYNCED(uint scriptNameHash, int instance, uint positionHash, int handlerNum)` | int |
| `_NETWORK_GET_RANDOM_FLOAT_RANGED` | `float _NETWORK_GET_RANDOM_FLOAT_RANGED(float rangeStart, float rangeEnd)` | float |
| `_NETWORK_GET_TUNABLES_REGISTRATION_BOOL` | `bool _NETWORK_GET_TUNABLES_REGISTRATION_BOOL(uint tunableName, bool defaultValue)` | bool |
| `_NETWORK_GET_TUNABLES_REGISTRATION_FLOAT` | `float _NETWORK_GET_TUNABLES_REGISTRATION_FLOAT(uint tunableName, float defaultValue)` | float |
| `_NETWORK_GET_TUNABLES_REGISTRATION_INT` | `int _NETWORK_GET_TUNABLES_REGISTRATION_INT(uint tunableName, int defaultValue)` | int |
| `_NETWORK_HAS_PLAYER_PASSED_CHECK_TYPE` | `bool _NETWORK_HAS_PLAYER_PASSED_CHECK_TYPE(int checkType, ref object gamerHandle)` | bool |
| `_NETWORK_HAS_ROS_PRIVILEGE_MP_TEXT_COMMUNICATION` | `bool _NETWORK_HAS_ROS_PRIVILEGE_MP_TEXT_COMMUNICATION()` | bool |
| `_NETWORK_HAS_ROS_PRIVILEGE_MP_VOICE_COMMUNICATION` | `bool _NETWORK_HAS_ROS_PRIVILEGE_MP_VOICE_COMMUNICATION()` | bool |
| `_NETWORK_HAS_ROS_PRIVILEGE_REPORTING` | `bool _NETWORK_HAS_ROS_PRIVILEGE_REPORTING()` | bool |
| `_NETWORK_HAVE_PLATFORM_COMMUNICATION_PRIVILEGES` | `bool _NETWORK_HAVE_PLATFORM_COMMUNICATION_PRIVILEGES()` | bool |
| `_NETWORK_HIDE_ENTITY_IN_TUTORIAL_SESSION` | `void _NETWORK_HIDE_ENTITY_IN_TUTORIAL_SESSION(int netHandle, bool hide)` | void |
| `_NETWORK_INVITE_CLEAR_JOIN_FAIL_REASON` | `void _NETWORK_INVITE_CLEAR_JOIN_FAIL_REASON()` | void |
| `_NETWORK_INVITE_GET_JOIN_FAIL_REASON` | `string _NETWORK_INVITE_GET_JOIN_FAIL_REASON()` | string |
| `_NETWORK_IS_AMERICAS_VERSION` | `bool _NETWORK_IS_AMERICAS_VERSION()` | bool |
| `_NETWORK_IS_SPECIAL_TUTORIAL_SESSION` | `bool _NETWORK_IS_SPECIAL_TUTORIAL_SESSION()` | bool |
| `_NETWORK_LOAD_GAMER_DISPLAY_NAME` | `string _NETWORK_LOAD_GAMER_DISPLAY_NAME(ref object gamerHandle)` | string |
| `_NETWORK_MULTIPLAYER_CROSSPLAY_NOT_ALLOWED` | `bool _NETWORK_MULTIPLAYER_CROSSPLAY_NOT_ALLOWED()` | bool |
| `_NETWORK_SESSION_LEAVE_INCLUDING_REASON` | `bool _NETWORK_SESSION_LEAVE_INCLUDING_REASON(int leaveFlags, int leaveReason)` | bool |
| `_NETWORK_SET_COMMUNICATION_GROUP_FLAGS` | `void _NETWORK_SET_COMMUNICATION_GROUP_FLAGS(int communicationType, int communicationGroupFlag)` | void |
| `_NETWORK_SET_IGNORE_VEHICLE_RAMMED_BY_NON_VEHICLE` | `void _NETWORK_SET_IGNORE_VEHICLE_RAMMED_BY_NON_VEHICLE(bool toggle)` | void |
| `_NETWORK_SET_TUNABLES_REGISTRATION_CONTEXTS` | `void _NETWORK_SET_TUNABLES_REGISTRATION_CONTEXTS(ref object tunableContextData)` | void |
| `_NETWORK_SET_TUTORIAL_SPECIAL_SESSION` | `void _NETWORK_SET_TUTORIAL_SPECIAL_SESSION(bool toggle)` | void |
| `_NETWORK_TRIGGER_DAMAGE_EVENT_FOR_ZERO_PED_DAMAGE` | `void _NETWORK_TRIGGER_DAMAGE_EVENT_FOR_ZERO_PED_DAMAGE(int entity, bool trigger)` | void |
| `_SET_FREEMODE_REPORT_DATA` | `void _SET_FREEMODE_REPORT_DATA(ref object gamerHandle, ref object reportData)` | void |

---

## STATS

| 函数名 | 签名 | 返回值 |
|--------|------|--------|
| `CAN_PAY_AMOUNT_TO_BOSS` | `bool CAN_PAY_AMOUNT_TO_BOSS(int p0, int p1, int amount, ref int p3)` | bool |
| `CHANGE_GOON_LOOKING_FOR_WORK` | `void CHANGE_GOON_LOOKING_FOR_WORK(object p0)` | void |
| `CHANGE_UNIFORM` | `void CHANGE_UNIFORM(object p0, object p1, object p2)` | void |
| `DEPOSIT_VC` | `bool DEPOSIT_VC(int amount)` | bool |
| `END_BEING_BOSS` | `void END_BEING_BOSS(object p0, object p1, object p2)` | void |
| `END_BEING_GOON` | `void END_BEING_GOON(object p0, object p1, object p2, object p3, object p4)` | void |
| `FORCE_CLOUD_MP_STATS_DOWNLOAD_AND_OVERWRITE_LOCAL_SAVE` | `void FORCE_CLOUD_MP_STATS_DOWNLOAD_AND_OVERWRITE_LOCAL_SAVE()` | void |
| `GET_BOSS_GOON_UUID` | `void GET_BOSS_GOON_UUID(int characterSlot, object p1, object p2)` | void |
| `GET_PACKED_INT_STAT_KEY` | `uint GET_PACKED_INT_STAT_KEY(int index, bool spStat, bool charStat, int character)` | uint |
| `GET_PACKED_NG_INT_STAT_KEY` | `uint GET_PACKED_NG_INT_STAT_KEY(int index, bool spStat, bool charStat, int character, string section)` | uint |
| `GET_PACKED_STAT_BOOL_CODE` | `bool GET_PACKED_STAT_BOOL_CODE(int index, int characterSlot)` | bool |
| `GET_PACKED_STAT_INT_CODE` | `int GET_PACKED_STAT_INT_CODE(int index, int characterSlot)` | int |
| `GET_PACKED_TU_INT_STAT_KEY` | `uint GET_PACKED_TU_INT_STAT_KEY(int index, bool spStat, bool charStat, int character)` | uint |
| `GET_PLAYER_HAS_DRIVEN_ALL_VEHICLES` | `bool GET_PLAYER_HAS_DRIVEN_ALL_VEHICLES()` | bool |
| `HAS_VC_WITHDRAWAL_COMPLETED` | `bool HAS_VC_WITHDRAWAL_COMPLETED(object p0)` | bool |
| `HIRED_LIMO` | `void HIRED_LIMO(object p0, object p1)` | void |
| `LEADERBOARDS2_READ_BY_HANDLE` | `bool LEADERBOARDS2_READ_BY_HANDLE(ref object p0, ref object p1)` | bool |
| `LEADERBOARDS2_READ_BY_PLAFORM` | `bool LEADERBOARDS2_READ_BY_PLAFORM(ref object p0, string gamerHandleCsv, string platformName)` | bool |
| `LEADERBOARDS2_READ_BY_RADIUS` | `bool LEADERBOARDS2_READ_BY_RADIUS(ref object p0, object p1, ref object p2)` | bool |
| `LEADERBOARDS2_READ_BY_RANK` | `bool LEADERBOARDS2_READ_BY_RANK(ref object p0, object p1, object p2)` | bool |
| `LEADERBOARDS2_READ_BY_SCORE_FLOAT` | `bool LEADERBOARDS2_READ_BY_SCORE_FLOAT(ref object p0, float p1, object p2)` | bool |
| `LEADERBOARDS2_READ_BY_SCORE_INT` | `bool LEADERBOARDS2_READ_BY_SCORE_INT(ref object p0, object p1, object p2)` | bool |
| `LEADERBOARDS2_READ_FRIENDS_BY_ROW` | `bool LEADERBOARDS2_READ_FRIENDS_BY_ROW(ref object p0, ref object p1, object p2, bool p3, object p4, object p5)` | bool |
| `LEADERBOARDS2_READ_GET_ROW_DATA_END` | `void LEADERBOARDS2_READ_GET_ROW_DATA_END()` | void |
| `LEADERBOARDS2_READ_GET_ROW_DATA_FLOAT` | `float LEADERBOARDS2_READ_GET_ROW_DATA_FLOAT(object p0, object p1)` | float |
| `LEADERBOARDS2_READ_GET_ROW_DATA_INFO` | `bool LEADERBOARDS2_READ_GET_ROW_DATA_INFO(object p0, ref object p1)` | bool |
| `LEADERBOARDS2_READ_GET_ROW_DATA_INT` | `int LEADERBOARDS2_READ_GET_ROW_DATA_INT(object p0, object p1)` | int |
| `LEADERBOARDS2_READ_GET_ROW_DATA_START` | `bool LEADERBOARDS2_READ_GET_ROW_DATA_START(ref object p0)` | bool |
| `LEADERBOARDS2_READ_RANK_PREDICTION` | `bool LEADERBOARDS2_READ_RANK_PREDICTION(ref object p0, ref object p1, ref object p2)` | bool |
| `LEADERBOARDS2_WRITE_DATA` | `bool LEADERBOARDS2_WRITE_DATA(ref object p0)` | bool |
| `LEADERBOARDS2_WRITE_DATA_FOR_EVENT_TYPE` | `bool LEADERBOARDS2_WRITE_DATA_FOR_EVENT_TYPE(ref object p0, ref object p1)` | bool |
| `LEADERBOARDS_CACHE_DATA_ROW` | `bool LEADERBOARDS_CACHE_DATA_ROW(ref object p0)` | bool |
| `LEADERBOARDS_CLEAR_CACHE_DATA` | `void LEADERBOARDS_CLEAR_CACHE_DATA()` | void |
| `LEADERBOARDS_CLEAR_CACHE_DATA_ID` | `void LEADERBOARDS_CLEAR_CACHE_DATA_ID(object p0)` | void |
| `LEADERBOARDS_GET_CACHE_DATA_ROW` | `bool LEADERBOARDS_GET_CACHE_DATA_ROW(object p0, object p1, ref object p2)` | bool |
| `LEADERBOARDS_GET_CACHE_EXISTS` | `bool LEADERBOARDS_GET_CACHE_EXISTS(object p0)` | bool |
| `LEADERBOARDS_GET_CACHE_NUMBER_OF_ROWS` | `int LEADERBOARDS_GET_CACHE_NUMBER_OF_ROWS(object p0)` | int |
| `LEADERBOARDS_GET_CACHE_TIME` | `int LEADERBOARDS_GET_CACHE_TIME(object p0)` | int |
| `LEADERBOARDS_GET_COLUMN_ID` | `int LEADERBOARDS_GET_COLUMN_ID(int p0, int p1, int p2)` | int |
| `LEADERBOARDS_GET_COLUMN_TYPE` | `int LEADERBOARDS_GET_COLUMN_TYPE(int p0, object p1, object p2)` | int |
| `LEADERBOARDS_GET_NUMBER_OF_COLUMNS` | `int LEADERBOARDS_GET_NUMBER_OF_COLUMNS(int p0, object p1)` | int |
| `LEADERBOARDS_READ_ANY_PENDING` | `bool LEADERBOARDS_READ_ANY_PENDING()` | bool |
| `LEADERBOARDS_READ_CLEAR` | `int LEADERBOARDS_READ_CLEAR(object p0, object p1, object p2)` | int |
| `LEADERBOARDS_READ_CLEAR_ALL` | `int LEADERBOARDS_READ_CLEAR_ALL()` | int |
| `LEADERBOARDS_READ_PENDING` | `bool LEADERBOARDS_READ_PENDING(object p0, object p1, object p2)` | bool |
| `LEADERBOARDS_READ_SUCCESSFUL` | `bool LEADERBOARDS_READ_SUCCESSFUL(object p0, object p1, object p2)` | bool |
| `LEADERBOARDS_WRITE_ADD_COLUMN` | `void LEADERBOARDS_WRITE_ADD_COLUMN(object p0, object p1, float p2)` | void |
| `LEADERBOARDS_WRITE_ADD_COLUMN_LONG` | `void LEADERBOARDS_WRITE_ADD_COLUMN_LONG(object p0, object p1, object p2)` | void |
| `NETWORK_BUY_AIRSTRIKE` | `void NETWORK_BUY_AIRSTRIKE(int cost, bool p1, bool p2, object p3)` | void |
| `NETWORK_BUY_BACKUP_GANG` | `void NETWORK_BUY_BACKUP_GANG(int p0, int p1, bool p2, bool p3, int npcProvider)` | void |
| `NETWORK_BUY_BOUNTY` | `void NETWORK_BUY_BOUNTY(int amount, int victim, bool p2, bool p3, object p4)` | void |
| `NETWORK_BUY_CONTRABAND_MISSION` | `void NETWORK_BUY_CONTRABAND_MISSION(int p0, int p1, uint p2, bool p3, bool p4)` | void |
| `NETWORK_BUY_FAIRGROUND_RIDE` | `void NETWORK_BUY_FAIRGROUND_RIDE(int amount, object p1, bool p2, bool p3, object p4)` | void |
| `NETWORK_BUY_HEALTHCARE` | `void NETWORK_BUY_HEALTHCARE(int cost, bool p1, bool p2)` | void |
| `NETWORK_BUY_HELI_STRIKE` | `void NETWORK_BUY_HELI_STRIKE(int cost, bool p1, bool p2, object p3)` | void |
| `NETWORK_BUY_ITEM` | `void NETWORK_BUY_ITEM(int amount, uint item, object p2, object p3, bool p4, string item_name, object p6, object p7, object p8, bool p9)` | void |
| `NETWORK_BUY_PROPERTY` | `void NETWORK_BUY_PROPERTY(int cost, uint propertyName, bool p2, bool p3)` | void |
| `NETWORK_BUY_SMOKES` | `void NETWORK_BUY_SMOKES(int p0, bool p1, bool p2)` | void |
| `NETWORK_CAN_BET` | `bool NETWORK_CAN_BET(int amount)` | bool |
| `NETWORK_CAN_RECEIVE_PLAYER_CASH` | `bool NETWORK_CAN_RECEIVE_PLAYER_CASH(object p0, object p1, object p2, object p3)` | bool |
| `NETWORK_CAN_SHARE_JOB_CASH` | `bool NETWORK_CAN_SHARE_JOB_CASH()` | bool |
| `NETWORK_CAN_SPEND_MONEY` | `bool NETWORK_CAN_SPEND_MONEY(object p0, bool p1, bool p2, bool p3, object p4, object p5)` | bool |
| `NETWORK_CAN_SPEND_MONEY2` | `bool NETWORK_CAN_SPEND_MONEY2(object p0, bool p1, bool p2, bool p3, ref object p4, object p5, object p6)` | bool |
| `NETWORK_CASINO_BUY_CHIPS` | `bool NETWORK_CASINO_BUY_CHIPS(int p0, int p1)` | bool |
| `NETWORK_CASINO_CAN_BET` | `bool NETWORK_CASINO_CAN_BET(uint hash)` | bool |
| `NETWORK_CASINO_CAN_BET_AMOUNT` | `bool NETWORK_CASINO_CAN_BET_AMOUNT(object p0)` | bool |
| `NETWORK_CASINO_CAN_BET_PVC` | `bool NETWORK_CASINO_CAN_BET_PVC()` | bool |
| `NETWORK_CASINO_CAN_BUY_CHIPS_PVC` | `bool NETWORK_CASINO_CAN_BUY_CHIPS_PVC()` | bool |
| `NETWORK_CASINO_SELL_CHIPS` | `bool NETWORK_CASINO_SELL_CHIPS(int p0, int p1)` | bool |
| `NETWORK_CLEAR_CHARACTER_WALLET` | `void NETWORK_CLEAR_CHARACTER_WALLET(int characterSlot)` | void |
| `NETWORK_DEDUCT_CASH` | `void NETWORK_DEDUCT_CASH(int amount, string p1, string p2, bool p3, bool p4, bool p5)` | void |
| `NETWORK_DEFER_CASH_TRANSACTIONS_UNTIL_SHOP_SAVE` | `void NETWORK_DEFER_CASH_TRANSACTIONS_UNTIL_SHOP_SAVE()` | void |
| `NETWORK_DELETE_CHARACTER` | `void NETWORK_DELETE_CHARACTER(int characterSlot, bool p1, bool p2)` | void |
| `NETWORK_EARN_AGENCY` | `void NETWORK_EARN_AGENCY(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_EARN_AGENCY_CONTRACT` | `void NETWORK_EARN_AGENCY_CONTRACT(object p0, object p1)` | void |
| `NETWORK_EARN_AGENCY_PHONE` | `void NETWORK_EARN_AGENCY_PHONE(object p0, object p1, object p2)` | void |
| `NETWORK_EARN_AGENCY_SAFE` | `void NETWORK_EARN_AGENCY_SAFE(object p0, object p1)` | void |
| `NETWORK_EARN_ARCADE` | `void NETWORK_EARN_ARCADE(object p0, object p1, object p2, object p3, object p4, object p5)` | void |
| `NETWORK_EARN_ARENA_CAREER_PROGRESSION` | `void NETWORK_EARN_ARENA_CAREER_PROGRESSION(int amount, object p1)` | void |
| `NETWORK_EARN_ARENA_SKILL_LEVEL_PROGRESSION` | `void NETWORK_EARN_ARENA_SKILL_LEVEL_PROGRESSION(int amount, object p1)` | void |
| `NETWORK_EARN_ARENA_WAR` | `void NETWORK_EARN_ARENA_WAR(int amount, object p1, object p2, object p3)` | void |
| `NETWORK_EARN_ARENA_WAR_ASSASSINATE_TARGET` | `void NETWORK_EARN_ARENA_WAR_ASSASSINATE_TARGET(int amount)` | void |
| `NETWORK_EARN_ARENA_WAR_EVENT_CARGO` | `void NETWORK_EARN_ARENA_WAR_EVENT_CARGO(int amount)` | void |
| `NETWORK_EARN_ASSASSINATE_TARGET_KILLED` | `void NETWORK_EARN_ASSASSINATE_TARGET_KILLED(int amount)` | void |
| `NETWORK_EARN_AUTOSHOP_BUSINESS` | `void NETWORK_EARN_AUTOSHOP_BUSINESS(object p0, object p1, object p2)` | void |
| `NETWORK_EARN_AUTOSHOP_INCOME` | `void NETWORK_EARN_AUTOSHOP_INCOME(object p0, int p1)` | void |
| `NETWORK_EARN_AWARD_CONTRACT` | `void NETWORK_EARN_AWARD_CONTRACT(object p0, object p1)` | void |
| `NETWORK_EARN_AWARD_FIXER_MISSION` | `void NETWORK_EARN_AWARD_FIXER_MISSION(object p0, object p1)` | void |
| `NETWORK_EARN_AWARD_PHONE` | `void NETWORK_EARN_AWARD_PHONE(object p0, object p1)` | void |
| `NETWORK_EARN_AWARD_SHORT_TRIP` | `void NETWORK_EARN_AWARD_SHORT_TRIP(object p0, object p1)` | void |
| `NETWORK_EARN_BB_EVENT_BONUS` | `void NETWORK_EARN_BB_EVENT_BONUS(int amount)` | void |
| `NETWORK_EARN_BEACH_PARTY_LOST_FOUND` | `void NETWORK_EARN_BEACH_PARTY_LOST_FOUND(object p0, object p1, object p2)` | void |
| `NETWORK_EARN_BIKER` | `void NETWORK_EARN_BIKER(object p0)` | void |
| `NETWORK_EARN_BIKER_SHOP` | `void NETWORK_EARN_BIKER_SHOP(object p0, object p1)` | void |
| `NETWORK_EARN_BOSS` | `void NETWORK_EARN_BOSS(object p0, object p1, object p2)` | void |
| `NETWORK_EARN_BOUNTY_HUNTER_REWARD` | `void NETWORK_EARN_BOUNTY_HUNTER_REWARD(object p0)` | void |
| `NETWORK_EARN_CARCLUB_MEMBERSHIP` | `void NETWORK_EARN_CARCLUB_MEMBERSHIP(object p0)` | void |
| `NETWORK_EARN_CASINO_AWARD` | `void NETWORK_EARN_CASINO_AWARD(int amount, uint hash)` | void |
| `NETWORK_EARN_CASINO_COLLECTABLE_COMPLETED_COLLECTION` | `void NETWORK_EARN_CASINO_COLLECTABLE_COMPLETED_COLLECTION(int amount)` | void |
| `NETWORK_EARN_CASINO_HEIST` | `void NETWORK_EARN_CASINO_HEIST(object p0, object p1, object p2, object p3, object p4, object p5, object p6)` | void |
| `NETWORK_EARN_CASINO_HEIST_AWARDS` | `void NETWORK_EARN_CASINO_HEIST_AWARDS(object p0, object p1, object p2, object p3, object p4)` | void |
| `NETWORK_EARN_CASINO_MISSION_PARTICIPATION` | `void NETWORK_EARN_CASINO_MISSION_PARTICIPATION(int amount)` | void |
| `NETWORK_EARN_CASINO_MISSION_REWARD` | `void NETWORK_EARN_CASINO_MISSION_REWARD(int amount)` | void |
| `NETWORK_EARN_CASINO_STORY_MISSION_REWARD` | `void NETWORK_EARN_CASINO_STORY_MISSION_REWARD(int amount)` | void |
| `NETWORK_EARN_CASINO_TIME_TRIAL_WIN` | `void NETWORK_EARN_CASINO_TIME_TRIAL_WIN(int amount)` | void |
| `NETWORK_EARN_CHALLENGE` | `void NETWORK_EARN_CHALLENGE(int amount, object p1, object p2)` | void |
| `NETWORK_EARN_COLLECTABLES` | `void NETWORK_EARN_COLLECTABLES(object p0, object p1, object p2)` | void |
| `NETWORK_EARN_COLLECTABLES_ACTION_FIGURES` | `void NETWORK_EARN_COLLECTABLES_ACTION_FIGURES(int amount)` | void |
| `NETWORK_EARN_COLLECTABLE_COMPLETED_COLLECTION` | `void NETWORK_EARN_COLLECTABLE_COMPLETED_COLLECTION(int amount, object p1)` | void |
| `NETWORK_EARN_COLLECTABLE_ITEM` | `void NETWORK_EARN_COLLECTABLE_ITEM(int amount, object p1)` | void |
| `NETWORK_EARN_DAILY_OBJECTIVE_EVENT` | `void NETWORK_EARN_DAILY_OBJECTIVE_EVENT(int amount)` | void |
| `NETWORK_EARN_DAILY_VEHICLE` | `void NETWORK_EARN_DAILY_VEHICLE(object p0, object p1)` | void |
| `NETWORK_EARN_DAILY_VEHICLE_BONUS` | `void NETWORK_EARN_DAILY_VEHICLE_BONUS(object p0)` | void |
| `NETWORK_EARN_DAR_CHALLENGE` | `void NETWORK_EARN_DAR_CHALLENGE(int amount, object p1)` | void |
| `NETWORK_EARN_DISPATCH_CALL` | `void NETWORK_EARN_DISPATCH_CALL(int amount, object p1)` | void |
| `NETWORK_EARN_DOOMSDAY_FINALE_BONUS` | `void NETWORK_EARN_DOOMSDAY_FINALE_BONUS(int amount, uint vehicleHash)` | void |
| `NETWORK_EARN_FIRST_TIME_BONUS` | `void NETWORK_EARN_FIRST_TIME_BONUS(object p0, object p1, object p2)` | void |
| `NETWORK_EARN_FIXER_AGENCY_SHORT_TRIP` | `void NETWORK_EARN_FIXER_AGENCY_SHORT_TRIP(object p0, object p1)` | void |
| `NETWORK_EARN_FIXER_FINALE` | `void NETWORK_EARN_FIXER_FINALE(object p0, object p1)` | void |
| `NETWORK_EARN_FIXER_PREP` | `void NETWORK_EARN_FIXER_PREP(object p0, object p1)` | void |
| `NETWORK_EARN_FIXER_RIVAL_DELIVERY` | `void NETWORK_EARN_FIXER_RIVAL_DELIVERY(object p0, object p1)` | void |
| `NETWORK_EARN_FMBB_WAGE_BONUS` | `void NETWORK_EARN_FMBB_WAGE_BONUS(object p0)` | void |
| `NETWORK_EARN_FROM_AI_TARGET_KILL` | `void NETWORK_EARN_FROM_AI_TARGET_KILL(object p0, object p1)` | void |
| `NETWORK_EARN_FROM_AMBIENT_JOB` | `void NETWORK_EARN_FROM_AMBIENT_JOB(int p0, string p1, ref object p2)` | void |
| `NETWORK_EARN_FROM_BEND_JOB` | `void NETWORK_EARN_FROM_BEND_JOB(int amount, string heistHash)` | void |
| `NETWORK_EARN_FROM_BETTING` | `void NETWORK_EARN_FROM_BETTING(int amount, string p1)` | void |
| `NETWORK_EARN_FROM_BOUNTY` | `void NETWORK_EARN_FROM_BOUNTY(int amount, ref object gamerHandle, ref object p2, object p3)` | void |
| `NETWORK_EARN_FROM_BUSINESS_BATTLE` | `void NETWORK_EARN_FROM_BUSINESS_BATTLE(object p0)` | void |
| `NETWORK_EARN_FROM_BUSINESS_HUB_SELL` | `void NETWORK_EARN_FROM_BUSINESS_HUB_SELL(object p0, object p1, object p2)` | void |
| `NETWORK_EARN_FROM_BUSINESS_PRODUCT` | `void NETWORK_EARN_FROM_BUSINESS_PRODUCT(int amount, object p1, object p2, object p3)` | void |
| `NETWORK_EARN_FROM_CASHING_OUT` | `void NETWORK_EARN_FROM_CASHING_OUT(int amount)` | void |
| `NETWORK_EARN_FROM_CHALLENGE_WIN` | `void NETWORK_EARN_FROM_CHALLENGE_WIN(object p0, ref object p1, bool p2)` | void |
| `NETWORK_EARN_FROM_CLUB_MANAGEMENT_PARTICIPATION` | `void NETWORK_EARN_FROM_CLUB_MANAGEMENT_PARTICIPATION(object p0, int p1)` | void |
| `NETWORK_EARN_FROM_CONTRABAND` | `void NETWORK_EARN_FROM_CONTRABAND(int amount, object p1)` | void |
| `NETWORK_EARN_FROM_CRATE_DROP` | `void NETWORK_EARN_FROM_CRATE_DROP(int amount)` | void |
| `NETWORK_EARN_FROM_CRIMINAL_MASTERMIND` | `void NETWORK_EARN_FROM_CRIMINAL_MASTERMIND(object p0, object p1, object p2)` | void |
| `NETWORK_EARN_FROM_DAILY_OBJECTIVES` | `void NETWORK_EARN_FROM_DAILY_OBJECTIVES(int amount, string type, int characterSlot)` | void |
| `NETWORK_EARN_FROM_DESTROYING_CONTRABAND` | `void NETWORK_EARN_FROM_DESTROYING_CONTRABAND(object p0, object p1, object p2)` | void |
| `NETWORK_EARN_FROM_FMBB_BOSS_WORK` | `void NETWORK_EARN_FROM_FMBB_BOSS_WORK(object p0)` | void |
| `NETWORK_EARN_FROM_FMBB_PHONECALL_MISSION` | `void NETWORK_EARN_FROM_FMBB_PHONECALL_MISSION(object p0)` | void |
| `NETWORK_EARN_FROM_GANGATTACK_PICKUP` | `void NETWORK_EARN_FROM_GANGATTACK_PICKUP(int amount)` | void |
| `NETWORK_EARN_FROM_HANGAR_TRADE` | `void NETWORK_EARN_FROM_HANGAR_TRADE(object p0, object p1)` | void |
| `NETWORK_EARN_FROM_HOLDUPS` | `void NETWORK_EARN_FROM_HOLDUPS(int amount)` | void |
| `NETWORK_EARN_FROM_IMPORT_EXPORT` | `void NETWORK_EARN_FROM_IMPORT_EXPORT(int amount, uint modelHash)` | void |
| `NETWORK_EARN_FROM_ISLAND_HEIST_DJ_MISSION` | `void NETWORK_EARN_FROM_ISLAND_HEIST_DJ_MISSION(object p0, object p1)` | void |
| `NETWORK_EARN_FROM_JOB` | `void NETWORK_EARN_FROM_JOB(int amount, string p1)` | void |
| `NETWORK_EARN_FROM_JOBX2` | `void NETWORK_EARN_FROM_JOBX2(int amount, string p1)` | void |
| `NETWORK_EARN_FROM_JOB_BONUS` | `void NETWORK_EARN_FROM_JOB_BONUS(object p0, ref object p1, ref object p2)` | void |
| `NETWORK_EARN_FROM_NOT_BADSPORT` | `void NETWORK_EARN_FROM_NOT_BADSPORT(int amount)` | void |
| `NETWORK_EARN_FROM_PERSONAL_VEHICLE` | `void NETWORK_EARN_FROM_PERSONAL_VEHICLE(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8)` | void |
| `NETWORK_EARN_FROM_PICKUP` | `void NETWORK_EARN_FROM_PICKUP(int amount)` | void |
| `NETWORK_EARN_FROM_PREMIUM_JOB` | `void NETWORK_EARN_FROM_PREMIUM_JOB(int amount, string p1)` | void |
| `NETWORK_EARN_FROM_PROPERTY` | `void NETWORK_EARN_FROM_PROPERTY(int amount, uint propertyName)` | void |
| `NETWORK_EARN_FROM_ROB_ARMORED_CARS` | `void NETWORK_EARN_FROM_ROB_ARMORED_CARS(int amount)` | void |
| `NETWORK_EARN_FROM_SELL_BUNKER` | `void NETWORK_EARN_FROM_SELL_BUNKER(int amount, uint bunkerHash)` | void |
| `NETWORK_EARN_FROM_SMUGGLER_WORK` | `void NETWORK_EARN_FROM_SMUGGLER_WORK(object p0, object p1, object p2, object p3, object p4, object p5)` | void |
| `NETWORK_EARN_FROM_VEHICLE` | `void NETWORK_EARN_FROM_VEHICLE(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7)` | void |
| `NETWORK_EARN_FROM_VEHICLE_EXPORT` | `void NETWORK_EARN_FROM_VEHICLE_EXPORT(int amount, object p1, object p2)` | void |
| `NETWORK_EARN_FROM_WAREHOUSE` | `void NETWORK_EARN_FROM_WAREHOUSE(int amount, int id)` | void |
| `NETWORK_EARN_GANGOPS_AWARD` | `void NETWORK_EARN_GANGOPS_AWARD(int amount, string p1, object p2)` | void |
| `NETWORK_EARN_GANGOPS_ELITE` | `void NETWORK_EARN_GANGOPS_ELITE(int amount, string p1, int actIndex)` | void |
| `NETWORK_EARN_GANGOPS_FINALE` | `void NETWORK_EARN_GANGOPS_FINALE(int amount, string p1)` | void |
| `NETWORK_EARN_GANGOPS_PREP_PARTICIPATION` | `void NETWORK_EARN_GANGOPS_PREP_PARTICIPATION(int amount)` | void |
| `NETWORK_EARN_GANGOPS_SETUP` | `void NETWORK_EARN_GANGOPS_SETUP(int amount, string p1)` | void |
| `NETWORK_EARN_GANGOPS_WAGES` | `void NETWORK_EARN_GANGOPS_WAGES(int amount, int p1)` | void |
| `NETWORK_EARN_GANGOPS_WAGES_BONUS` | `void NETWORK_EARN_GANGOPS_WAGES_BONUS(int amount, int p1)` | void |
| `NETWORK_EARN_GOON` | `void NETWORK_EARN_GOON(object p0, object p1, object p2)` | void |
| `NETWORK_EARN_HACKER_TRUCK` | `void NETWORK_EARN_HACKER_TRUCK(object p0, int amount, object p2, object p3)` | void |
| `NETWORK_EARN_HEIST_AWARD` | `void NETWORK_EARN_HEIST_AWARD(object p0, object p1, object p2)` | void |
| `NETWORK_EARN_ISLAND_HEIST` | `void NETWORK_EARN_ISLAND_HEIST(int amount1, object p1, object p2, object p3, int amount2, int p5)` | void |
| `NETWORK_EARN_NIGHTCLUB` | `void NETWORK_EARN_NIGHTCLUB(object p0, object p1)` | void |
| `NETWORK_EARN_NIGHTCLUB_AND_WAREHOUSE` | `void NETWORK_EARN_NIGHTCLUB_AND_WAREHOUSE(object p0, object p1, object p2, object p3, object p4, object p5, object p6)` | void |
| `NETWORK_EARN_NIGHTCLUB_DANCING` | `void NETWORK_EARN_NIGHTCLUB_DANCING(object p0)` | void |
| `NETWORK_EARN_PURCHASE_CLUB_HOUSE` | `void NETWORK_EARN_PURCHASE_CLUB_HOUSE(object p0, object p1)` | void |
| `NETWORK_EARN_RC_TIME_TRIAL` | `void NETWORK_EARN_RC_TIME_TRIAL(int amount)` | void |
| `NETWORK_EARN_RDR_BONUS` | `void NETWORK_EARN_RDR_BONUS(int amount, object p1)` | void |
| `NETWORK_EARN_SELL_BASE` | `void NETWORK_EARN_SELL_BASE(int amount, uint baseNameHash)` | void |
| `NETWORK_EARN_SELL_PRIZE_VEHICLE` | `void NETWORK_EARN_SELL_PRIZE_VEHICLE(int amount, object p1, object p2)` | void |
| `NETWORK_EARN_SIGHTSEEING_REWARD` | `void NETWORK_EARN_SIGHTSEEING_REWARD(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_EARN_SMUGGLER_AGENCY` | `void NETWORK_EARN_SMUGGLER_AGENCY(int amount, object p1, object p2, object p3)` | void |
| `NETWORK_EARN_SPIN_THE_WHEEL_CASH` | `void NETWORK_EARN_SPIN_THE_WHEEL_CASH(int amount)` | void |
| `NETWORK_EARN_TARGET_REFUND` | `void NETWORK_EARN_TARGET_REFUND(int amount, int p1)` | void |
| `NETWORK_EARN_TUNER_AWARD` | `void NETWORK_EARN_TUNER_AWARD(object p0, object p1, object p2)` | void |
| `NETWORK_EARN_TUNER_ROBBERY` | `void NETWORK_EARN_TUNER_ROBBERY(object p0, object p1, object p2, object p3, object p4)` | void |
| `NETWORK_EARN_UPGRADE_AGENCY` | `void NETWORK_EARN_UPGRADE_AGENCY(object p0, object p1)` | void |
| `NETWORK_EARN_UPGRADE_ARCADE` | `void NETWORK_EARN_UPGRADE_ARCADE(object p0, object p1, object p2)` | void |
| `NETWORK_EARN_UPGRADE_AUTOSHOP` | `void NETWORK_EARN_UPGRADE_AUTOSHOP(object p0, object p1)` | void |
| `NETWORK_EARN_WAGE_PAYMENT` | `void NETWORK_EARN_WAGE_PAYMENT(int amount, object p1)` | void |
| `NETWORK_EARN_WAGE_PAYMENT_BONUS` | `void NETWORK_EARN_WAGE_PAYMENT_BONUS(int amount)` | void |
| `NETWORK_EARN_YATCH_MISSION` | `void NETWORK_EARN_YATCH_MISSION(int amount, object p1)` | void |
| `NETWORK_ECONOMY_HAS_FIXED_CRAZY_NUMBERS` | `bool NETWORK_ECONOMY_HAS_FIXED_CRAZY_NUMBERS()` | bool |
| `NETWORK_GET_CAN_SPEND_FROM_BANK` | `bool NETWORK_GET_CAN_SPEND_FROM_BANK(int amount)` | bool |
| `NETWORK_GET_CAN_SPEND_FROM_BANK_AND_WALLET` | `bool NETWORK_GET_CAN_SPEND_FROM_BANK_AND_WALLET(int amount, int characterSlot)` | bool |
| `NETWORK_GET_CAN_SPEND_FROM_WALLET` | `bool NETWORK_GET_CAN_SPEND_FROM_WALLET(int amount, int characterSlot)` | bool |
| `NETWORK_GET_CAN_TRANSFER_CASH` | `bool NETWORK_GET_CAN_TRANSFER_CASH(int amount)` | bool |
| `NETWORK_GET_EVC_BALANCE` | `int NETWORK_GET_EVC_BALANCE()` | int |
| `NETWORK_GET_PLAYER_IS_HIGH_EARNER` | `bool NETWORK_GET_PLAYER_IS_HIGH_EARNER()` | bool |
| `NETWORK_GET_PVC_BALANCE` | `int NETWORK_GET_PVC_BALANCE()` | int |
| `NETWORK_GET_PVC_TRANSFER_BALANCE` | `int NETWORK_GET_PVC_TRANSFER_BALANCE()` | int |
| `NETWORK_GET_REMAINING_TRANSFER_BALANCE` | `int NETWORK_GET_REMAINING_TRANSFER_BALANCE()` | int |
| `NETWORK_GET_STRING_BANK_BALANCE` | `string NETWORK_GET_STRING_BANK_BALANCE()` | string |
| `NETWORK_GET_STRING_BANK_WALLET_BALANCE` | `string NETWORK_GET_STRING_BANK_WALLET_BALANCE(int character)` | string |
| `NETWORK_GET_STRING_WALLET_BALANCE` | `string NETWORK_GET_STRING_WALLET_BALANCE(int characterSlot)` | string |
| `NETWORK_GET_VC_BALANCE` | `int NETWORK_GET_VC_BALANCE()` | int |
| `NETWORK_GET_VC_BANK_BALANCE` | `int NETWORK_GET_VC_BANK_BALANCE()` | int |
| `NETWORK_GET_VC_WALLET_BALANCE` | `int NETWORK_GET_VC_WALLET_BALANCE(int characterSlot)` | int |
| `NETWORK_GIVE_PLAYER_JOBSHARE_CASH` | `void NETWORK_GIVE_PLAYER_JOBSHARE_CASH(int amount, ref object gamerHandle)` | void |
| `NETWORK_INITIALIZE_CASH` | `void NETWORK_INITIALIZE_CASH(int wallet, int bank)` | void |
| `NETWORK_MANUAL_DELETE_CHARACTER` | `void NETWORK_MANUAL_DELETE_CHARACTER(int characterSlot)` | void |
| `NETWORK_MONEY_CAN_BET` | `bool NETWORK_MONEY_CAN_BET(int amount, bool p1, bool p2)` | bool |
| `NETWORK_PAY_EMPLOYEE_WAGE` | `void NETWORK_PAY_EMPLOYEE_WAGE(object p0, bool p1, bool p2)` | void |
| `NETWORK_PAY_MATCH_ENTRY_FEE` | `void NETWORK_PAY_MATCH_ENTRY_FEE(int amount, string matchId, bool p2, bool p3)` | void |
| `NETWORK_RECEIVE_PLAYER_JOBSHARE_CASH` | `void NETWORK_RECEIVE_PLAYER_JOBSHARE_CASH(int value, ref object gamerHandle)` | void |
| `NETWORK_REFUND_CASH` | `void NETWORK_REFUND_CASH(int index, string context, string reason, bool p3)` | void |
| `NETWORK_SERVICE_EARN_GANGOPS_RIVAL_DELIVERY` | `void NETWORK_SERVICE_EARN_GANGOPS_RIVAL_DELIVERY(int earnedMoney)` | void |
| `NETWORK_SPEND_AGENCY` | `void NETWORK_SPEND_AGENCY(object p0, object p1, object p2, object p3, object p4)` | void |
| `NETWORK_SPEND_APARTMENT_UTILITIES` | `void NETWORK_SPEND_APARTMENT_UTILITIES(int amount, bool p1, bool p2, ref object data)` | void |
| `NETWORK_SPEND_ARCADE` | `void NETWORK_SPEND_ARCADE(object p0, object p1, object p2, object p3, object p4)` | void |
| `NETWORK_SPEND_ARCADE_MGMT` | `void NETWORK_SPEND_ARCADE_MGMT(object p0, object p1, object p2, object p3, object p4)` | void |
| `NETWORK_SPEND_ARENA_PREMIUM` | `void NETWORK_SPEND_ARENA_PREMIUM(int amount, bool p1, bool p2)` | void |
| `NETWORK_SPEND_ARENA_SPECTATOR_BOX` | `void NETWORK_SPEND_ARENA_SPECTATOR_BOX(int amount, int type, bool p2, bool p3)` | void |
| `NETWORK_SPEND_AUTOSHOP_MODIFY` | `void NETWORK_SPEND_AUTOSHOP_MODIFY(object p0, object p1, object p2, object p3, object p4)` | void |
| `NETWORK_SPEND_BEACH_PARTY` | `void NETWORK_SPEND_BEACH_PARTY(object p0)` | void |
| `NETWORK_SPEND_BIKE_SHOP` | `void NETWORK_SPEND_BIKE_SHOP(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_BOSS` | `void NETWORK_SPEND_BOSS(object p0, object p1, object p2)` | void |
| `NETWORK_SPEND_BOUNTY_HUNTER_MISSION` | `void NETWORK_SPEND_BOUNTY_HUNTER_MISSION(int amount, bool p1, bool p2)` | void |
| `NETWORK_SPEND_BUSINESS_PROPERTY_FEES` | `void NETWORK_SPEND_BUSINESS_PROPERTY_FEES(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_BUY_AGENCY` | `void NETWORK_SPEND_BUY_AGENCY(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_BUY_ARCADE` | `void NETWORK_SPEND_BUY_ARCADE(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_BUY_ARENA` | `void NETWORK_SPEND_BUY_ARENA(int amount, bool p1, bool p2, string p3)` | void |
| `NETWORK_SPEND_BUY_AUTOSHOP` | `void NETWORK_SPEND_BUY_AUTOSHOP(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_BUY_CASINO` | `void NETWORK_SPEND_BUY_CASINO(int amount, bool p1, bool p2, ref object data)` | void |
| `NETWORK_SPEND_BUY_SUB` | `void NETWORK_SPEND_BUY_SUB(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_CAR_CLUB_BAR` | `void NETWORK_SPEND_CAR_CLUB_BAR(object p0, bool p1, bool p2, object p3)` | void |
| `NETWORK_SPEND_CAR_CLUB_MEMBERSHIP` | `void NETWORK_SPEND_CAR_CLUB_MEMBERSHIP(int amount1, object p1, object p2, int amount2, object p4)` | void |
| `NETWORK_SPEND_CAR_CLUB_TAKEOVER` | `void NETWORK_SPEND_CAR_CLUB_TAKEOVER(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_CASINO_CLUB` | `void NETWORK_SPEND_CASINO_CLUB(int amount1, object p1, bool p2, object p3, int p4, int p5, int p6, int amount2, object p8)` | void |
| `NETWORK_SPEND_CASINO_GENERIC` | `void NETWORK_SPEND_CASINO_GENERIC(int amount, object p1, object p2, object p3, object p4)` | void |
| `NETWORK_SPEND_CASINO_HEIST` | `void NETWORK_SPEND_CASINO_HEIST(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9, object p10)` | void |
| `NETWORK_SPEND_CASINO_HEIST_SKIP_MISSION` | `void NETWORK_SPEND_CASINO_HEIST_SKIP_MISSION(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_CASINO_MEMBERSHIP` | `void NETWORK_SPEND_CASINO_MEMBERSHIP(int amount, bool p1, bool p2, int p3)` | void |
| `NETWORK_SPEND_COMP_SUV` | `void NETWORK_SPEND_COMP_SUV(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_EARNED_FROM_BANK_AND_WALLETS` | `int NETWORK_SPEND_EARNED_FROM_BANK_AND_WALLETS(int amount)` | int |
| `NETWORK_SPEND_GANGOPS_CANNON` | `void NETWORK_SPEND_GANGOPS_CANNON(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_GANGOPS_REPAIR_COST` | `void NETWORK_SPEND_GANGOPS_REPAIR_COST(object p0, object p1, object p2)` | void |
| `NETWORK_SPEND_GANGOPS_SKIP_MISSION` | `void NETWORK_SPEND_GANGOPS_SKIP_MISSION(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_GANGOPS_START_STRAND` | `void NETWORK_SPEND_GANGOPS_START_STRAND(int type, int amount, bool p2, bool p3)` | void |
| `NETWORK_SPEND_GANGOPS_TRIP_SKIP` | `void NETWORK_SPEND_GANGOPS_TRIP_SKIP(int amount, bool p1, bool p2)` | void |
| `NETWORK_SPEND_GOON` | `void NETWORK_SPEND_GOON(int p0, int p1, int amount)` | void |
| `NETWORK_SPEND_GUNRUNNING` | `void NETWORK_SPEND_GUNRUNNING(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_HIDDEN` | `void NETWORK_SPEND_HIDDEN(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_INTERACTION_MENU_ABILITY` | `void NETWORK_SPEND_INTERACTION_MENU_ABILITY(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_ISLAND_HEIST` | `void NETWORK_SPEND_ISLAND_HEIST(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_MAKE_IT_RAIN` | `void NETWORK_SPEND_MAKE_IT_RAIN(int amount, bool p1, bool p2)` | void |
| `NETWORK_SPEND_NIGHTCLUB_AND_WAREHOUSE` | `void NETWORK_SPEND_NIGHTCLUB_AND_WAREHOUSE(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_NIGHTCLUB_BAR_DRINK` | `void NETWORK_SPEND_NIGHTCLUB_BAR_DRINK(int amount, object p1, bool p2, bool p3)` | void |
| `NETWORK_SPEND_PLAY_ARCADE` | `void NETWORK_SPEND_PLAY_ARCADE(object p0, object p1, object p2, object p3, object p4)` | void |
| `NETWORK_SPEND_SET_COMMON_FIELDS` | `void NETWORK_SPEND_SET_COMMON_FIELDS(object p0, object p1, object p2, bool p3)` | void |
| `NETWORK_SPEND_SET_DISCOUNT` | `void NETWORK_SPEND_SET_DISCOUNT(bool p0)` | void |
| `NETWORK_SPEND_SOURCE_BIKE` | `void NETWORK_SPEND_SOURCE_BIKE(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_SPIN_THE_WHEEL_PAYMENT` | `void NETWORK_SPEND_SPIN_THE_WHEEL_PAYMENT(int amount, object p1, bool p2)` | void |
| `NETWORK_SPEND_SUBMARINE` | `void NETWORK_SPEND_SUBMARINE(object p0, object p1, object p2, object p3, object p4, object p5)` | void |
| `NETWORK_SPEND_SUPPLY` | `void NETWORK_SPEND_SUPPLY(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_SUV_FST_TRVL` | `void NETWORK_SPEND_SUV_FST_TRVL(int p0, bool p1, bool p2, object p3)` | void |
| `NETWORK_SPEND_UPGRADE_AGENCY` | `void NETWORK_SPEND_UPGRADE_AGENCY(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_UPGRADE_ARCADE` | `void NETWORK_SPEND_UPGRADE_ARCADE(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_UPGRADE_ARENA` | `void NETWORK_SPEND_UPGRADE_ARENA(int amount, bool p1, bool p2, string p3)` | void |
| `NETWORK_SPEND_UPGRADE_AUTOSHOP` | `void NETWORK_SPEND_UPGRADE_AUTOSHOP(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_UPGRADE_CASINO` | `void NETWORK_SPEND_UPGRADE_CASINO(int amount, bool p1, bool p2, ref object data)` | void |
| `NETWORK_SPEND_UPGRADE_SUB` | `void NETWORK_SPEND_UPGRADE_SUB(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPEND_VEHICLE_REQUESTED` | `void NETWORK_SPEND_VEHICLE_REQUESTED(object p0, object p1, object p2, object p3, object p4)` | void |
| `NETWORK_SPENT_AMMO_DROP` | `void NETWORK_SPENT_AMMO_DROP(object p0, bool p1, bool p2, object p3)` | void |
| `NETWORK_SPENT_ARENA_JOIN_SPECTATOR` | `void NETWORK_SPENT_ARENA_JOIN_SPECTATOR(int amount, object p1, bool p2, bool p3)` | void |
| `NETWORK_SPENT_ARREST_BAIL` | `void NETWORK_SPENT_ARREST_BAIL(object p0, bool p1, bool p2)` | void |
| `NETWORK_SPENT_BALLISTIC_EQUIPMENT` | `void NETWORK_SPENT_BALLISTIC_EQUIPMENT(int amount, bool p1, bool p2)` | void |
| `NETWORK_SPENT_BANK_INTEREST` | `void NETWORK_SPENT_BANK_INTEREST(int p0, bool p1, bool p2)` | void |
| `NETWORK_SPENT_BETTING` | `void NETWORK_SPENT_BETTING(int amount, int p1, string matchId, bool p3, bool p4)` | void |
| `NETWORK_SPENT_BOAT_PICKUP` | `void NETWORK_SPENT_BOAT_PICKUP(object p0, bool p1, bool p2, object p3)` | void |
| `NETWORK_SPENT_BOSS_GOON` | `bool NETWORK_SPENT_BOSS_GOON(int amount, bool p1, bool p2)` | bool |
| `NETWORK_SPENT_BOUNTY` | `void NETWORK_SPENT_BOUNTY(object p0, bool p1, bool p2)` | void |
| `NETWORK_SPENT_BULL_SHARK` | `void NETWORK_SPENT_BULL_SHARK(object p0, bool p1, bool p2, object p3)` | void |
| `NETWORK_SPENT_BUY_BASE` | `void NETWORK_SPENT_BUY_BASE(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_BUY_BUNKER` | `void NETWORK_SPENT_BUY_BUNKER(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_BUY_OFFTHERADAR` | `void NETWORK_SPENT_BUY_OFFTHERADAR(object p0, bool p1, bool p2, object p3)` | void |
| `NETWORK_SPENT_BUY_PASSIVE_MODE` | `void NETWORK_SPENT_BUY_PASSIVE_MODE(object p0, bool p1, bool p2, object p3)` | void |
| `NETWORK_SPENT_BUY_REVEAL_PLAYERS` | `void NETWORK_SPENT_BUY_REVEAL_PLAYERS(object p0, bool p1, bool p2, object p3)` | void |
| `NETWORK_SPENT_BUY_TILTROTOR` | `void NETWORK_SPENT_BUY_TILTROTOR(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_BUY_TRUCK` | `void NETWORK_SPENT_BUY_TRUCK(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_BUY_WANTEDLEVEL` | `void NETWORK_SPENT_BUY_WANTEDLEVEL(object p0, ref object p1, bool p2, bool p3, object p4)` | void |
| `NETWORK_SPENT_CALL_PLAYER` | `void NETWORK_SPENT_CALL_PLAYER(object p0, ref object p1, bool p2, bool p3)` | void |
| `NETWORK_SPENT_CARGO_SOURCING` | `void NETWORK_SPENT_CARGO_SOURCING(object p0, object p1, object p2, object p3, object p4, object p5, object p6)` | void |
| `NETWORK_SPENT_CARWASH` | `void NETWORK_SPENT_CARWASH(object p0, object p1, object p2, bool p3, bool p4)` | void |
| `NETWORK_SPENT_CASH_DROP` | `void NETWORK_SPENT_CASH_DROP(int amount, bool p1, bool p2)` | void |
| `NETWORK_SPENT_CHANGE_APPEARANCE` | `void NETWORK_SPENT_CHANGE_APPEARANCE(object p0, object p1, object p2)` | void |
| `NETWORK_SPENT_CINEMA` | `void NETWORK_SPENT_CINEMA(object p0, object p1, bool p2, bool p3)` | void |
| `NETWORK_SPENT_EMPLOY_ASSASSINS` | `void NETWORK_SPENT_EMPLOY_ASSASSINS(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_FROM_ROCKSTAR` | `void NETWORK_SPENT_FROM_ROCKSTAR(int p0, bool p1, bool p2)` | void |
| `NETWORK_SPENT_HANGAR_STAFF_CHARGES` | `void NETWORK_SPENT_HANGAR_STAFF_CHARGES(int amount, bool p1, bool p2)` | void |
| `NETWORK_SPENT_HANGAR_UTILITY_CHARGES` | `void NETWORK_SPENT_HANGAR_UTILITY_CHARGES(int amount, bool p1, bool p2)` | void |
| `NETWORK_SPENT_HELI_PICKUP` | `void NETWORK_SPENT_HELI_PICKUP(object p0, bool p1, bool p2, object p3)` | void |
| `NETWORK_SPENT_HIRE_MERCENARY` | `void NETWORK_SPENT_HIRE_MERCENARY(object p0, bool p1, bool p2, object p3)` | void |
| `NETWORK_SPENT_HIRE_MUGGER` | `void NETWORK_SPENT_HIRE_MUGGER(object p0, bool p1, bool p2, object p3)` | void |
| `NETWORK_SPENT_HOLDUPS` | `void NETWORK_SPENT_HOLDUPS(object p0, bool p1, bool p2)` | void |
| `NETWORK_SPENT_IMPORT_EXPORT_REPAIR` | `void NETWORK_SPENT_IMPORT_EXPORT_REPAIR(object p0, object p1, object p2)` | void |
| `NETWORK_SPENT_IN_STRIPCLUB` | `void NETWORK_SPENT_IN_STRIPCLUB(object p0, bool p1, object p2, bool p3)` | void |
| `NETWORK_SPENT_JOB_SKIP` | `void NETWORK_SPENT_JOB_SKIP(int amount, string matchId, bool p2, bool p3)` | void |
| `NETWORK_SPENT_JUKEBOX` | `void NETWORK_SPENT_JUKEBOX(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_MC_ABILITY` | `void NETWORK_SPENT_MC_ABILITY(object p0, object p1, object p2, object p3, object p4)` | void |
| `NETWORK_SPENT_MOVE_SUBMARINE` | `void NETWORK_SPENT_MOVE_SUBMARINE(object p0, object p1, object p2)` | void |
| `NETWORK_SPENT_MOVE_YACHT` | `void NETWORK_SPENT_MOVE_YACHT(int amount, bool p1, bool p2)` | void |
| `NETWORK_SPENT_NIGHTCLUB_ENTRY_FEE` | `void NETWORK_SPENT_NIGHTCLUB_ENTRY_FEE(int player, int amount, object p1, bool p2, bool p3)` | void |
| `NETWORK_SPENT_NO_COPS` | `void NETWORK_SPENT_NO_COPS(object p0, bool p1, bool p2, object p3)` | void |
| `NETWORK_SPENT_ORDER_BODYGUARD_VEHICLE` | `void NETWORK_SPENT_ORDER_BODYGUARD_VEHICLE(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_ORDER_WAREHOUSE_VEHICLE` | `void NETWORK_SPENT_ORDER_WAREHOUSE_VEHICLE(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_PAY_BUSINESS_SUPPLIES` | `void NETWORK_SPENT_PAY_BUSINESS_SUPPLIES(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_PAY_VEHICLE_INSURANCE_PREMIUM` | `void NETWORK_SPENT_PAY_VEHICLE_INSURANCE_PREMIUM(int amount, uint vehicleModel, ref object gamerHandle, bool notBankrupt, bool hasTheMoney)` | void |
| `NETWORK_SPENT_PA_HELI_PICKUP` | `void NETWORK_SPENT_PA_HELI_PICKUP(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_PA_SERVICE_DANCER` | `void NETWORK_SPENT_PA_SERVICE_DANCER(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_PA_SERVICE_HELI` | `void NETWORK_SPENT_PA_SERVICE_HELI(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_PA_SERVICE_IMPOUND` | `void NETWORK_SPENT_PA_SERVICE_IMPOUND(object p0, object p1, object p2)` | void |
| `NETWORK_SPENT_PA_SERVICE_SNACK` | `void NETWORK_SPENT_PA_SERVICE_SNACK(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_PA_SERVICE_VEHICLE` | `void NETWORK_SPENT_PA_SERVICE_VEHICLE(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_PLAYER_HEALTHCARE` | `void NETWORK_SPENT_PLAYER_HEALTHCARE(int p0, int p1, bool p2, bool p3)` | void |
| `NETWORK_SPENT_PROSTITUTES` | `void NETWORK_SPENT_PROSTITUTES(object p0, bool p1, bool p2)` | void |
| `NETWORK_SPENT_PURCHASE_BUSINESS_PROPERTY` | `void NETWORK_SPENT_PURCHASE_BUSINESS_PROPERTY(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_PURCHASE_CLUB_HOUSE` | `void NETWORK_SPENT_PURCHASE_CLUB_HOUSE(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_PURCHASE_HACKER_TRUCK` | `void NETWORK_SPENT_PURCHASE_HACKER_TRUCK(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_PURCHASE_HANGAR` | `void NETWORK_SPENT_PURCHASE_HANGAR(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_PURCHASE_IMPEXP_WAREHOUSE_PROPERTY` | `void NETWORK_SPENT_PURCHASE_IMPEXP_WAREHOUSE_PROPERTY(int amount, ref object data, bool p2, bool p3)` | void |
| `NETWORK_SPENT_PURCHASE_NIGHTCLUB_AND_WAREHOUSE` | `void NETWORK_SPENT_PURCHASE_NIGHTCLUB_AND_WAREHOUSE(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_PURCHASE_OFFICE_GARAGE` | `void NETWORK_SPENT_PURCHASE_OFFICE_GARAGE(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_PURCHASE_OFFICE_PROPERTY` | `void NETWORK_SPENT_PURCHASE_OFFICE_PROPERTY(object p0, object p1, object p2, object p3, object p4)` | void |
| `NETWORK_SPENT_PURCHASE_WAREHOUSE_PROPERTY` | `void NETWORK_SPENT_PURCHASE_WAREHOUSE_PROPERTY(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_RDR_HATCHET_BONUS` | `void NETWORK_SPENT_RDR_HATCHET_BONUS(int amount, bool p1, bool p2)` | void |
| `NETWORK_SPENT_REHIRE_DJ` | `void NETWORK_SPENT_REHIRE_DJ(int amount, object p1, bool p2, bool p3)` | void |
| `NETWORK_SPENT_RENAME_ORGANIZATION` | `void NETWORK_SPENT_RENAME_ORGANIZATION(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_REQUEST_HEIST` | `void NETWORK_SPENT_REQUEST_HEIST(object p0, bool p1, bool p2, object p3)` | void |
| `NETWORK_SPENT_REQUEST_JOB` | `void NETWORK_SPENT_REQUEST_JOB(object p0, bool p1, bool p2, object p3)` | void |
| `NETWORK_SPENT_ROBBED_BY_MUGGER` | `void NETWORK_SPENT_ROBBED_BY_MUGGER(int amount, bool p1, bool p2, object p3)` | void |
| `NETWORK_SPENT_TAXI` | `void NETWORK_SPENT_TAXI(int amount, bool p1, bool p2, object p3, object p4)` | void |
| `NETWORK_SPENT_TELESCOPE` | `void NETWORK_SPENT_TELESCOPE(object p0, bool p1, bool p2)` | void |
| `NETWORK_SPENT_TRADE_BUSINESS_PROPERTY` | `void NETWORK_SPENT_TRADE_BUSINESS_PROPERTY(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_TRADE_IMPEXP_WAREHOUSE_PROPERTY` | `void NETWORK_SPENT_TRADE_IMPEXP_WAREHOUSE_PROPERTY(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_UPGRADE_BASE` | `void NETWORK_SPENT_UPGRADE_BASE(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_UPGRADE_BUSINESS_PROPERTY` | `void NETWORK_SPENT_UPGRADE_BUSINESS_PROPERTY(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_UPGRADE_CLUB_HOUSE` | `void NETWORK_SPENT_UPGRADE_CLUB_HOUSE(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_UPGRADE_HACKER_TRUCK` | `void NETWORK_SPENT_UPGRADE_HACKER_TRUCK(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_UPGRADE_HANGAR` | `void NETWORK_SPENT_UPGRADE_HANGAR(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_UPGRADE_IMPEXP_WAREHOUSE_PROPERTY` | `void NETWORK_SPENT_UPGRADE_IMPEXP_WAREHOUSE_PROPERTY(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_UPGRADE_NIGHTCLUB_AND_WAREHOUSE` | `void NETWORK_SPENT_UPGRADE_NIGHTCLUB_AND_WAREHOUSE(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_UPGRADE_OFFICE_GARAGE` | `void NETWORK_SPENT_UPGRADE_OFFICE_GARAGE(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_UPGRADE_OFFICE_PROPERTY` | `void NETWORK_SPENT_UPGRADE_OFFICE_PROPERTY(object p0, object p1, object p2, object p3, object p4)` | void |
| `NETWORK_SPENT_UPGRADE_TILTROTOR` | `void NETWORK_SPENT_UPGRADE_TILTROTOR(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_UPGRADE_TRUCK` | `void NETWORK_SPENT_UPGRADE_TRUCK(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_UPGRADE_WAREHOUSE_PROPERTY` | `void NETWORK_SPENT_UPGRADE_WAREHOUSE_PROPERTY(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_UPRADE_BUNKER` | `void NETWORK_SPENT_UPRADE_BUNKER(object p0, object p1, object p2, object p3)` | void |
| `NETWORK_SPENT_VEHICLE_EXPORT_MODS` | `void NETWORK_SPENT_VEHICLE_EXPORT_MODS(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9)` | void |
| `NETWORK_SPENT_WAGER` | `void NETWORK_SPENT_WAGER(object p0, object p1, int amount)` | void |
| `NETWORK_YOHAN_SOURCE_GOODS` | `void NETWORK_YOHAN_SOURCE_GOODS(object p0, object p1, object p2, object p3)` | void |
| `ORDER_BOSS_VEHICLE` | `void ORDER_BOSS_VEHICLE(object p0, object p1, uint vehicleHash)` | void |
| `PACKED_STAT_GET_INT_STAT_INDEX` | `int PACKED_STAT_GET_INT_STAT_INDEX(int p0)` | int |
| `PLAYSTATS_ABANDONED_MC` | `void PLAYSTATS_ABANDONED_MC(object p0, object p1, object p2, object p3, object p4)` | void |
| `PLAYSTATS_ACQUIRED_HIDDEN_PACKAGE` | `void PLAYSTATS_ACQUIRED_HIDDEN_PACKAGE(object p0)` | void |
| `PLAYSTATS_ACTIVITY_DONE` | `void PLAYSTATS_ACTIVITY_DONE(int p0, int activityId, object p2)` | void |
| `PLAYSTATS_APPEND_DIRECTOR_METRIC` | `void PLAYSTATS_APPEND_DIRECTOR_METRIC(ref object p0)` | void |
| `PLAYSTATS_ARCADE_CABINET` | `void PLAYSTATS_ARCADE_CABINET(object p0)` | void |
| `PLAYSTATS_ARCADE_GAME` | `void PLAYSTATS_ARCADE_GAME(object p0, object p1, object p2, object p3, object p4, object p5, object p6)` | void |
| `PLAYSTATS_ARCADE_LOVE_MATCH` | `void PLAYSTATS_ARCADE_LOVE_MATCH(object p0, object p1)` | void |
| `PLAYSTATS_ARENA_WARS_ENDED` | `void PLAYSTATS_ARENA_WARS_ENDED(ref object data)` | void |
| `PLAYSTATS_ARENA_WARS_SPECTATOR` | `void PLAYSTATS_ARENA_WARS_SPECTATOR(int p0, int p1, int p2, int p3, int p4)` | void |
| `PLAYSTATS_AWARD_BAD_SPORT` | `void PLAYSTATS_AWARD_BAD_SPORT(int id)` | void |
| `PLAYSTATS_AWARD_NAV` | `void PLAYSTATS_AWARD_NAV(object p0, object p1, object p2, object p3)` | void |
| `PLAYSTATS_AWARD_XP` | `void PLAYSTATS_AWARD_XP(int amount, uint type, uint category)` | void |
| `PLAYSTATS_BACKGROUND_SCRIPT_ACTION` | `void PLAYSTATS_BACKGROUND_SCRIPT_ACTION(string action, int value)` | void |
| `PLAYSTATS_BAN_ALERT` | `void PLAYSTATS_BAN_ALERT(int p0)` | void |
| `PLAYSTATS_BC_CAR_JACKING` | `void PLAYSTATS_BC_CAR_JACKING(object p0)` | void |
| `PLAYSTATS_BC_CASHING` | `void PLAYSTATS_BC_CASHING(object p0)` | void |
| `PLAYSTATS_BC_FINDERS_KEEPERS` | `void PLAYSTATS_BC_FINDERS_KEEPERS(object p0)` | void |
| `PLAYSTATS_BC_MOST_WANTED` | `void PLAYSTATS_BC_MOST_WANTED(object p0)` | void |
| `PLAYSTATS_BC_POINT_TO_POINT` | `void PLAYSTATS_BC_POINT_TO_POINT(object p0)` | void |
| `PLAYSTATS_BC_PROTECTION_RACKET` | `void PLAYSTATS_BC_PROTECTION_RACKET(object p0)` | void |
| `PLAYSTATS_BC_SALVAGE` | `void PLAYSTATS_BC_SALVAGE(object p0)` | void |
| `PLAYSTATS_BC_SMASH_AND_GRAB` | `void PLAYSTATS_BC_SMASH_AND_GRAB(object p0)` | void |
| `PLAYSTATS_BUSINESS_BATTLE_ENDED` | `void PLAYSTATS_BUSINESS_BATTLE_ENDED(object p0)` | void |
| `PLAYSTATS_BUY_CONTRABAND_MISSION` | `void PLAYSTATS_BUY_CONTRABAND_MISSION(ref object data)` | void |
| `PLAYSTATS_BW_AIR_FREIGHT` | `void PLAYSTATS_BW_AIR_FREIGHT(object p0)` | void |
| `PLAYSTATS_BW_ASSAULT` | `void PLAYSTATS_BW_ASSAULT(object p0)` | void |
| `PLAYSTATS_BW_BELLY_OF_THE_BEAST` | `void PLAYSTATS_BW_BELLY_OF_THE_BEAST(object p0)` | void |
| `PLAYSTATS_BW_BOSSONBOSSDEATHMATCH` | `void PLAYSTATS_BW_BOSSONBOSSDEATHMATCH(object p0)` | void |
| `PLAYSTATS_BW_FRAGILE_GOODS` | `void PLAYSTATS_BW_FRAGILE_GOODS(object p0)` | void |
| `PLAYSTATS_BW_HEAD_HUNTER` | `void PLAYSTATS_BW_HEAD_HUNTER(object p0)` | void |
| `PLAYSTATS_BW_HUNT_THE_BOSS` | `void PLAYSTATS_BW_HUNT_THE_BOSS(object p0)` | void |
| `PLAYSTATS_BW_SIGHTSEER` | `void PLAYSTATS_BW_SIGHTSEER(object p0)` | void |
| `PLAYSTATS_BW_YATCHATTACK` | `void PLAYSTATS_BW_YATCHATTACK(object p0)` | void |
| `PLAYSTATS_CARCLUB_CHALLENGE` | `void PLAYSTATS_CARCLUB_CHALLENGE(object p0, object p1, object p2, object p3)` | void |
| `PLAYSTATS_CARCLUB_POINTS` | `void PLAYSTATS_CARCLUB_POINTS(object p0)` | void |
| `PLAYSTATS_CARCLUB_PRIZE` | `void PLAYSTATS_CARCLUB_PRIZE(int p0, uint vehicleModel)` | void |
| `PLAYSTATS_CASINO_BLACKJACK` | `void PLAYSTATS_CASINO_BLACKJACK(object p0)` | void |
| `PLAYSTATS_CASINO_BLACKJACK_LIGHT` | `void PLAYSTATS_CASINO_BLACKJACK_LIGHT(object p0)` | void |
| `PLAYSTATS_CASINO_CHIP` | `void PLAYSTATS_CASINO_CHIP(object p0)` | void |
| `PLAYSTATS_CASINO_INSIDE_TRACK` | `void PLAYSTATS_CASINO_INSIDE_TRACK(object p0)` | void |
| `PLAYSTATS_CASINO_INSIDE_TRACK_LIGHT` | `void PLAYSTATS_CASINO_INSIDE_TRACK_LIGHT(object p0)` | void |
| `PLAYSTATS_CASINO_LUCKY_SEVEN` | `void PLAYSTATS_CASINO_LUCKY_SEVEN(object p0)` | void |
| `PLAYSTATS_CASINO_ROULETTE` | `void PLAYSTATS_CASINO_ROULETTE(object p0)` | void |
| `PLAYSTATS_CASINO_ROULETTE_LIGHT` | `void PLAYSTATS_CASINO_ROULETTE_LIGHT(object p0)` | void |
| `PLAYSTATS_CASINO_SLOT_MACHINE` | `void PLAYSTATS_CASINO_SLOT_MACHINE(object p0)` | void |
| `PLAYSTATS_CASINO_SLOT_MACHINE_LIGHT` | `void PLAYSTATS_CASINO_SLOT_MACHINE_LIGHT(object p0)` | void |
| `PLAYSTATS_CASINO_STORY_MISSION_ENDED` | `void PLAYSTATS_CASINO_STORY_MISSION_ENDED(object p0, object p1)` | void |
| `PLAYSTATS_CASINO_THREE_CARD_POKER` | `void PLAYSTATS_CASINO_THREE_CARD_POKER(object p0)` | void |
| `PLAYSTATS_CASINO_THREE_CARD_POKER_LIGHT` | `void PLAYSTATS_CASINO_THREE_CARD_POKER_LIGHT(object p0)` | void |
| `PLAYSTATS_CHANGE_MC_OUTFIT` | `void PLAYSTATS_CHANGE_MC_OUTFIT(object p0, object p1, object p2, object p3, object p4)` | void |
| `PLAYSTATS_CHANGE_MC_ROLE` | `void PLAYSTATS_CHANGE_MC_ROLE(object p0, object p1, object p2, object p3, int role, int p5, object p6)` | void |
| `PLAYSTATS_CHEAT_APPLIED` | `void PLAYSTATS_CHEAT_APPLIED(string cheat)` | void |
| `PLAYSTATS_CLOTH_CHANGE` | `void PLAYSTATS_CLOTH_CHANGE(int p0, object p1, object p2, object p3, object p4)` | void |
| `PLAYSTATS_COLLECTIBLE_PICKED_UP` | `void PLAYSTATS_COLLECTIBLE_PICKED_UP(int p0, uint objectHash, object p2, object p3, int moneyAmount, int rpAmount, int chipsAmount, object p7, int p8, object p9, object p10)` | void |
| `PLAYSTATS_COPY_RANK_INTO_NEW_SLOT` | `void PLAYSTATS_COPY_RANK_INTO_NEW_SLOT(object p0, object p1, object p2, object p3, object p4, object p5, object p6)` | void |
| `PLAYSTATS_CRATE_CREATED` | `void PLAYSTATS_CRATE_CREATED(float p0, float p1, float p2)` | void |
| `PLAYSTATS_CRATE_DROP_MISSION_DONE` | `void PLAYSTATS_CRATE_DROP_MISSION_DONE(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7)` | void |
| `PLAYSTATS_CREATE_MATCH_HISTORY_ID_2` | `bool PLAYSTATS_CREATE_MATCH_HISTORY_ID_2(ref int playerAccountId, ref int posixTime)` | bool |
| `PLAYSTATS_DAR_CHECKPOINT` | `void PLAYSTATS_DAR_CHECKPOINT(ref object data)` | void |
| `PLAYSTATS_DEFEND_CONTRABAND_MISSION` | `void PLAYSTATS_DEFEND_CONTRABAND_MISSION(ref object data)` | void |
| `PLAYSTATS_DJ_MISSION_ENDED` | `void PLAYSTATS_DJ_MISSION_ENDED(object p0)` | void |
| `PLAYSTATS_DJ_USAGE` | `void PLAYSTATS_DJ_USAGE(object p0, object p1)` | void |
| `PLAYSTATS_DRONE_USAGE` | `void PLAYSTATS_DRONE_USAGE(int p0, int p1, int p2)` | void |
| `PLAYSTATS_DUPE_DETECTED` | `void PLAYSTATS_DUPE_DETECTED(ref object data)` | void |
| `PLAYSTATS_EARNED_MC_POINTS` | `void PLAYSTATS_EARNED_MC_POINTS(object p0, object p1, object p2, object p3, object p4, object p5)` | void |
| `PLAYSTATS_ENTER_SESSION_PACK` | `void PLAYSTATS_ENTER_SESSION_PACK(ref object data)` | void |
| `PLAYSTATS_EXTRA_EVENT` | `void PLAYSTATS_EXTRA_EVENT(object p0)` | void |
| `PLAYSTATS_FAST_TRVL` | `void PLAYSTATS_FAST_TRVL(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9, object p10)` | void |
| `PLAYSTATS_FM_EVENT_ATOB` | `void PLAYSTATS_FM_EVENT_ATOB(object p0)` | void |
| `PLAYSTATS_FM_EVENT_CHALLENGES` | `void PLAYSTATS_FM_EVENT_CHALLENGES(object p0)` | void |
| `PLAYSTATS_FM_EVENT_CHECKPOINTCOLLECTION` | `void PLAYSTATS_FM_EVENT_CHECKPOINTCOLLECTION(object p0)` | void |
| `PLAYSTATS_FM_EVENT_COMPETITIVEURBANWARFARE` | `void PLAYSTATS_FM_EVENT_COMPETITIVEURBANWARFARE(object p0)` | void |
| `PLAYSTATS_FM_EVENT_CRIMINALDAMAGE` | `void PLAYSTATS_FM_EVENT_CRIMINALDAMAGE(object p0)` | void |
| `PLAYSTATS_FM_EVENT_DEADDROP` | `void PLAYSTATS_FM_EVENT_DEADDROP(object p0)` | void |
| `PLAYSTATS_FM_EVENT_HOTPROPERTY` | `void PLAYSTATS_FM_EVENT_HOTPROPERTY(object p0)` | void |
| `PLAYSTATS_FM_EVENT_HUNTBEAST` | `void PLAYSTATS_FM_EVENT_HUNTBEAST(object p0)` | void |
| `PLAYSTATS_FM_EVENT_KINGOFTHECASTLE` | `void PLAYSTATS_FM_EVENT_KINGOFTHECASTLE(object p0)` | void |
| `PLAYSTATS_FM_EVENT_PASSTHEPARCEL` | `void PLAYSTATS_FM_EVENT_PASSTHEPARCEL(object p0)` | void |
| `PLAYSTATS_FM_EVENT_PENNEDIN` | `void PLAYSTATS_FM_EVENT_PENNEDIN(object p0)` | void |
| `PLAYSTATS_FM_EVENT_URBANWARFARE` | `void PLAYSTATS_FM_EVENT_URBANWARFARE(object p0)` | void |
| `PLAYSTATS_FM_EVENT_VEHICLETARGET` | `void PLAYSTATS_FM_EVENT_VEHICLETARGET(object p0)` | void |
| `PLAYSTATS_FM_HEIST_PREP_ENDED` | `void PLAYSTATS_FM_HEIST_PREP_ENDED(ref object data)` | void |
| `PLAYSTATS_FM_MISSION_END` | `void PLAYSTATS_FM_MISSION_END(object p0, object p1, object p2, object p3)` | void |
| `PLAYSTATS_FREEMODE_CASINO_MISSION_ENDED` | `void PLAYSTATS_FREEMODE_CASINO_MISSION_ENDED(ref object data)` | void |
| `PLAYSTATS_FRIEND_ACTIVITY` | `void PLAYSTATS_FRIEND_ACTIVITY(int p0, bool p1)` | void |
| `PLAYSTATS_GUNRUNNING_MISSION_ENDED` | `void PLAYSTATS_GUNRUNNING_MISSION_ENDED(ref object data)` | void |
| `PLAYSTATS_GUNRUNNING_RND` | `void PLAYSTATS_GUNRUNNING_RND(object p0)` | void |
| `PLAYSTATS_HEIST3_DRONE` | `void PLAYSTATS_HEIST3_DRONE(object p0)` | void |
| `PLAYSTATS_HEIST3_FINALE` | `void PLAYSTATS_HEIST3_FINALE(object p0)` | void |
| `PLAYSTATS_HEIST3_HACK` | `void PLAYSTATS_HEIST3_HACK(object p0, object p1, object p2, object p3, object p4, object p5)` | void |
| `PLAYSTATS_HEIST3_PREP` | `void PLAYSTATS_HEIST3_PREP(object p0)` | void |
| `PLAYSTATS_HEIST4_FINALE` | `void PLAYSTATS_HEIST4_FINALE(object p0)` | void |
| `PLAYSTATS_HEIST4_HACK` | `void PLAYSTATS_HEIST4_HACK(object p0, object p1, object p2, object p3, object p4)` | void |
| `PLAYSTATS_HEIST4_PREP` | `void PLAYSTATS_HEIST4_PREP(object p0)` | void |
| `PLAYSTATS_HEIST_SAVE_CHEAT` | `void PLAYSTATS_HEIST_SAVE_CHEAT(uint hash, int p1)` | void |
| `PLAYSTATS_HIT_CONTRABAND_DESTROY_LIMIT` | `void PLAYSTATS_HIT_CONTRABAND_DESTROY_LIMIT(object p0)` | void |
| `PLAYSTATS_HOLD_UP_MISSION_DONE` | `void PLAYSTATS_HOLD_UP_MISSION_DONE(object p0, object p1, object p2, object p3)` | void |
| `PLAYSTATS_HUB_ENTRY` | `void PLAYSTATS_HUB_ENTRY(object p0)` | void |
| `PLAYSTATS_HUB_EXIT` | `void PLAYSTATS_HUB_EXIT(object p0)` | void |
| `PLAYSTATS_IDLE_KICK` | `void PLAYSTATS_IDLE_KICK(int msStoodIdle)` | void |
| `PLAYSTATS_IMPEXP_MISSION_ENDED` | `void PLAYSTATS_IMPEXP_MISSION_ENDED(object p0)` | void |
| `PLAYSTATS_IMPORT_EXPORT_MISSION_DONE` | `void PLAYSTATS_IMPORT_EXPORT_MISSION_DONE(object p0, object p1, object p2, object p3)` | void |
| `PLAYSTATS_INSTANCED_HEIST_ENDED` | `void PLAYSTATS_INSTANCED_HEIST_ENDED(ref object data, object p1, object p2, object p3)` | void |
| `PLAYSTATS_INST_MISSION_END` | `void PLAYSTATS_INST_MISSION_END(object p0)` | void |
| `PLAYSTATS_INVENTORY` | `void PLAYSTATS_INVENTORY(object p0)` | void |
| `PLAYSTATS_JOB_ACTIVITY_END` | `void PLAYSTATS_JOB_ACTIVITY_END(ref object p0, ref object p1, ref object p2, ref object p3)` | void |
| `PLAYSTATS_JOB_BEND` | `void PLAYSTATS_JOB_BEND(ref object p0, ref object p1, ref object p2, ref object p3)` | void |
| `PLAYSTATS_JOB_LTS_END` | `void PLAYSTATS_JOB_LTS_END(ref object p0, ref object p1, ref object p2, ref object p3)` | void |
| `PLAYSTATS_JOB_LTS_ROUND_END` | `void PLAYSTATS_JOB_LTS_ROUND_END(ref object p0, ref object p1, ref object p2, ref object p3)` | void |
| `PLAYSTATS_LEAVE_JOB_CHAIN` | `void PLAYSTATS_LEAVE_JOB_CHAIN(object p0, object p1, object p2, object p3, object p4)` | void |
| `PLAYSTATS_MASTER_CONTROL` | `void PLAYSTATS_MASTER_CONTROL(object p0, object p1, object p2, object p3, object p4)` | void |
| `PLAYSTATS_MATCH_STARTED` | `void PLAYSTATS_MATCH_STARTED(object p0, object p1, object p2)` | void |
| `PLAYSTATS_MC_CLUBHOUSE_ACTIVITY` | `void PLAYSTATS_MC_CLUBHOUSE_ACTIVITY(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7)` | void |
| `PLAYSTATS_MC_FORMATION_ENDS` | `void PLAYSTATS_MC_FORMATION_ENDS(object p0, object p1, object p2, object p3, object p4, object p5, object p6)` | void |
| `PLAYSTATS_MC_KILLED_RIVAL_MC_MEMBER` | `void PLAYSTATS_MC_KILLED_RIVAL_MC_MEMBER(object p0, object p1, object p2, object p3, object p4)` | void |
| `PLAYSTATS_MC_REQUEST_BIKE` | `void PLAYSTATS_MC_REQUEST_BIKE(object p0, object p1, object p2, object p3, object p4)` | void |
| `PLAYSTATS_MINIGAME_USAGE` | `void PLAYSTATS_MINIGAME_USAGE(object p0, object p1, object p2)` | void |
| `PLAYSTATS_MISSION_CHECKPOINT` | `void PLAYSTATS_MISSION_CHECKPOINT(string p0, object p1, object p2, object p3)` | void |
| `PLAYSTATS_MISSION_ENDED` | `void PLAYSTATS_MISSION_ENDED(object p0)` | void |
| `PLAYSTATS_MISSION_OVER` | `void PLAYSTATS_MISSION_OVER(string p0, object p1, object p2, bool p3, bool p4, bool p5)` | void |
| `PLAYSTATS_MISSION_STARTED` | `void PLAYSTATS_MISSION_STARTED(string p0, object p1, object p2, bool p3)` | void |
| `PLAYSTATS_MISSION_VOTE` | `void PLAYSTATS_MISSION_VOTE(object p0)` | void |
| `PLAYSTATS_NIGHTCLUB_MISSION_ENDED` | `void PLAYSTATS_NIGHTCLUB_MISSION_ENDED(object p0)` | void |
| `PLAYSTATS_NJVS_VOTE` | `void PLAYSTATS_NJVS_VOTE(object p0)` | void |
| `PLAYSTATS_NPC_INVITE` | `void PLAYSTATS_NPC_INVITE(string p0)` | void |
| `PLAYSTATS_NPC_PHONE` | `void PLAYSTATS_NPC_PHONE(ref object p0)` | void |
| `PLAYSTATS_ODDJOB_DONE` | `void PLAYSTATS_ODDJOB_DONE(int totalTimeMs, int p1, bool p2)` | void |
| `PLAYSTATS_PEGASUS_AS_PERSONAL_AIRCRAFT` | `void PLAYSTATS_PEGASUS_AS_PERSONAL_AIRCRAFT(uint modelHash)` | void |
| `PLAYSTATS_PIMENU_HIDE_OPTIONS` | `void PLAYSTATS_PIMENU_HIDE_OPTIONS(ref object data)` | void |
| `PLAYSTATS_PROP_CHANGE` | `void PLAYSTATS_PROP_CHANGE(int p0, int p1, int p2, int p3)` | void |
| `PLAYSTATS_QUICKFIX_TOOL` | `void PLAYSTATS_QUICKFIX_TOOL(int element, string item)` | void |
| `PLAYSTATS_QUIT_MODE` | `void PLAYSTATS_QUIT_MODE(object p0, object p1, object p2, object p3, object p4)` | void |
| `PLAYSTATS_RACE_CHECKPOINT` | `void PLAYSTATS_RACE_CHECKPOINT(int p0, object p1, int p2, int p3, object p4)` | void |
| `PLAYSTATS_RACE_TO_POINT_MISSION_DONE` | `void PLAYSTATS_RACE_TO_POINT_MISSION_DONE(int p0, object p1, object p2, object p3)` | void |
| `PLAYSTATS_RANDOM_MISSION_DONE` | `void PLAYSTATS_RANDOM_MISSION_DONE(string name, object p1, object p2, object p3)` | void |
| `PLAYSTATS_RANK_UP` | `void PLAYSTATS_RANK_UP(int rank)` | void |
| `PLAYSTATS_RECOVER_CONTRABAND_MISSION` | `void PLAYSTATS_RECOVER_CONTRABAND_MISSION(ref object data)` | void |
| `PLAYSTATS_RIVAL_BEHAVIOR` | `void PLAYSTATS_RIVAL_BEHAVIOR(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9)` | void |
| `PLAYSTATS_ROBBERY_FINALE` | `void PLAYSTATS_ROBBERY_FINALE(object p0)` | void |
| `PLAYSTATS_ROBBERY_PREP` | `void PLAYSTATS_ROBBERY_PREP(object p0)` | void |
| `PLAYSTATS_ROS_BET` | `void PLAYSTATS_ROS_BET(int amount, int act, int player, float cm)` | void |
| `PLAYSTATS_SELL_CONTRABAND_MISSION` | `void PLAYSTATS_SELL_CONTRABAND_MISSION(ref object data)` | void |
| `PLAYSTATS_SET_JOIN_TYPE` | `void PLAYSTATS_SET_JOIN_TYPE(int joinType)` | void |
| `PLAYSTATS_SHOP_ITEM` | `void PLAYSTATS_SHOP_ITEM(object p0, object p1, object p2, object p3, object p4)` | void |
| `PLAYSTATS_SMUGGLER_MISSION_ENDED` | `void PLAYSTATS_SMUGGLER_MISSION_ENDED(ref object data)` | void |
| `PLAYSTATS_SPENT_PI_CUSTOM_LOADOUT` | `void PLAYSTATS_SPENT_PI_CUSTOM_LOADOUT(int amount)` | void |
| `PLAYSTATS_SPIN_WHEEL` | `void PLAYSTATS_SPIN_WHEEL(int p0, int p1, int p2, int p3)` | void |
| `PLAYSTATS_STARTED_SESSION_IN_OFFLINEMODE` | `void PLAYSTATS_STARTED_SESSION_IN_OFFLINEMODE()` | void |
| `PLAYSTATS_START_TRACKING_STUNTS` | `void PLAYSTATS_START_TRACKING_STUNTS()` | void |
| `PLAYSTATS_STONE_HATCHET_ENDED` | `void PLAYSTATS_STONE_HATCHET_ENDED(ref object data)` | void |
| `PLAYSTATS_STOP_TRACKING_STUNTS` | `void PLAYSTATS_STOP_TRACKING_STUNTS()` | void |
| `PLAYSTATS_SUB_WEAP` | `void PLAYSTATS_SUB_WEAP(object p0, object p1, object p2, object p3)` | void |
| `PLAYSTATS_SWITCH_MC_EMBLEM` | `void PLAYSTATS_SWITCH_MC_EMBLEM(object p0, object p1, object p2, object p3, object p4)` | void |
| `PLAYSTATS_SWITCH_PASSIVE_MODE` | `void PLAYSTATS_SWITCH_PASSIVE_MODE(bool p0, int p1, int p2, int p3)` | void |
| `PLAYSTATS_VEH_DEL` | `void PLAYSTATS_VEH_DEL(int bossId1, int bossId2, int bossType, int vehicleID, int reason)` | void |
| `PLAYSTATS_WAREHOUSE_MISSION_ENDED` | `void PLAYSTATS_WAREHOUSE_MISSION_ENDED(object p0)` | void |
| `PLAYSTATS_WEAPON_MODE_CHANGE` | `void PLAYSTATS_WEAPON_MODE_CHANGE(uint weaponHash, uint componentHashTo, uint componentHashFrom)` | void |
| `PLAYSTATS_WEBSITE_VISITED` | `void PLAYSTATS_WEBSITE_VISITED(uint scaleformHash, int p1)` | void |
| `PRESENCE_EVENT_UPDATESTAT_FLOAT` | `void PRESENCE_EVENT_UPDATESTAT_FLOAT(uint statHash, float value, int p2)` | void |
| `PRESENCE_EVENT_UPDATESTAT_INT` | `void PRESENCE_EVENT_UPDATESTAT_INT(uint statHash, int value, int p2)` | void |
| `PRESENCE_EVENT_UPDATESTAT_INT_WITH_STRING` | `void PRESENCE_EVENT_UPDATESTAT_INT_WITH_STRING(uint statHash, int value, int p2, string string)` | void |
| `PROCESS_CASH_GIFT` | `string PROCESS_CASH_GIFT(ref int p0, ref int p1, string p2)` | string |
| `SEND_METRIC_GHOSTING_TO_PLAYER` | `void SEND_METRIC_GHOSTING_TO_PLAYER(object p0)` | void |
| `SEND_METRIC_PUNISH_BODYGUARD` | `void SEND_METRIC_PUNISH_BODYGUARD(object p0)` | void |
| `SEND_METRIC_VIP_POACH` | `void SEND_METRIC_VIP_POACH(object p0, object p1, object p2)` | void |
| `SET_FREEMODE_PROLOGUE_DONE` | `void SET_FREEMODE_PROLOGUE_DONE(object p0, int characterSlot)` | void |
| `SET_FREEMODE_STRAND_PROGRESSION_STATUS` | `void SET_FREEMODE_STRAND_PROGRESSION_STATUS(int profileSetting, int settingValue)` | void |
| `SET_HAS_POSTED_ALL_VEHICLES_DRIVEN` | `void SET_HAS_POSTED_ALL_VEHICLES_DRIVEN()` | void |
| `SET_HAS_SPECIALEDITION_CONTENT` | `void SET_HAS_SPECIALEDITION_CONTENT(int value)` | void |
| `SET_JOB_ACTIVITY_ID_STARTED` | `void SET_JOB_ACTIVITY_ID_STARTED(object p0, int characterSlot)` | void |
| `SET_PACKED_STAT_BOOL_CODE` | `void SET_PACKED_STAT_BOOL_CODE(int index, bool value, int characterSlot)` | void |
| `SET_PACKED_STAT_INT_CODE` | `void SET_PACKED_STAT_INT_CODE(int index, int value, int characterSlot)` | void |
| `SET_PROFILE_SETTING_CREATOR_CTF_DONE` | `void SET_PROFILE_SETTING_CREATOR_CTF_DONE(int value)` | void |
| `SET_PROFILE_SETTING_CREATOR_DM_DONE` | `void SET_PROFILE_SETTING_CREATOR_DM_DONE(int value)` | void |
| `SET_PROFILE_SETTING_CREATOR_RACES_DONE` | `void SET_PROFILE_SETTING_CREATOR_RACES_DONE(int value)` | void |
| `SET_PROFILE_SETTING_PROLOGUE_COMPLETE` | `void SET_PROFILE_SETTING_PROLOGUE_COMPLETE()` | void |
| `SET_PROFILE_SETTING_SP_CHOP_MISSION_COMPLETE` | `void SET_PROFILE_SETTING_SP_CHOP_MISSION_COMPLETE()` | void |
| `SET_SAVE_MIGRATION_TRANSACTION_ID_WARNING` | `void SET_SAVE_MIGRATION_TRANSACTION_ID_WARNING(int transactionId)` | void |
| `START_BEING_BOSS` | `void START_BEING_BOSS(object p0, object p1, object p2)` | void |
| `START_BEING_GOON` | `void START_BEING_GOON(object p0, object p1, object p2)` | void |
| `STATS_COMPLETED_CHARACTER_CREATION` | `void STATS_COMPLETED_CHARACTER_CREATION(object p0)` | void |
| `STAT_CLEAR_DIRTY_READ_DETECTED` | `void STAT_CLEAR_DIRTY_READ_DETECTED()` | void |
| `STAT_CLEAR_PENDING_SAVES` | `void STAT_CLEAR_PENDING_SAVES(object p0)` | void |
| `STAT_CLEAR_SLOT_FOR_RELOAD` | `bool STAT_CLEAR_SLOT_FOR_RELOAD(int statSlot)` | bool |
| `STAT_CLOUD_SLOT_LOAD_FAILED` | `bool STAT_CLOUD_SLOT_LOAD_FAILED(int p0)` | bool |
| `STAT_CLOUD_SLOT_LOAD_FAILED_CODE` | `int STAT_CLOUD_SLOT_LOAD_FAILED_CODE(object p0)` | int |
| `STAT_CLOUD_SLOT_SAVE_FAILED` | `bool STAT_CLOUD_SLOT_SAVE_FAILED(object p0)` | bool |
| `STAT_COMMUNITY_GET_HISTORY` | `bool STAT_COMMUNITY_GET_HISTORY(uint statName, int p1, ref float outValue)` | bool |
| `STAT_COMMUNITY_START_SYNCH` | `bool STAT_COMMUNITY_START_SYNCH()` | bool |
| `STAT_COMMUNITY_SYNCH_IS_PENDING` | `bool STAT_COMMUNITY_SYNCH_IS_PENDING()` | bool |
| `STAT_DELETE_SLOT` | `bool STAT_DELETE_SLOT(int p0)` | bool |
| `STAT_DISABLE_STATS_TRACKING` | `void STAT_DISABLE_STATS_TRACKING()` | void |
| `STAT_ENABLE_STATS_TRACKING` | `void STAT_ENABLE_STATS_TRACKING()` | void |
| `STAT_GET_BLOCK_SAVES` | `bool STAT_GET_BLOCK_SAVES()` | bool |
| `STAT_GET_BOOL` | `bool STAT_GET_BOOL(uint statHash, ref bool outValue, object p2)` | bool |
| `STAT_GET_CANCEL_SAVE_MIGRATION_STATUS` | `int STAT_GET_CANCEL_SAVE_MIGRATION_STATUS()` | int |
| `STAT_GET_CHALLENGE_FLYING_DIST` | `float STAT_GET_CHALLENGE_FLYING_DIST()` | float |
| `STAT_GET_CURRENT_DRIVE_NOCRASH_DISTANCE` | `float STAT_GET_CURRENT_DRIVE_NOCRASH_DISTANCE()` | float |
| `STAT_GET_CURRENT_DRIVING_REVERSE_DISTANCE` | `float STAT_GET_CURRENT_DRIVING_REVERSE_DISTANCE()` | float |
| `STAT_GET_CURRENT_FRONT_WHEEL_DISTANCE` | `float STAT_GET_CURRENT_FRONT_WHEEL_DISTANCE()` | float |
| `STAT_GET_CURRENT_JUMP_DISTANCE` | `float STAT_GET_CURRENT_JUMP_DISTANCE()` | float |
| `STAT_GET_CURRENT_NEAR_MISS_NOCRASH_PRECISE` | `int STAT_GET_CURRENT_NEAR_MISS_NOCRASH_PRECISE()` | int |
| `STAT_GET_CURRENT_REAR_WHEEL_DISTANCE` | `float STAT_GET_CURRENT_REAR_WHEEL_DISTANCE()` | float |
| `STAT_GET_CURRENT_SKYDIVING_DISTANCE` | `float STAT_GET_CURRENT_SKYDIVING_DISTANCE()` | float |
| `STAT_GET_CURRENT_SPEED` | `float STAT_GET_CURRENT_SPEED()` | float |
| `STAT_GET_DATE` | `bool STAT_GET_DATE(uint statHash, ref object outValue, int numFields, object p3)` | bool |
| `STAT_GET_FLOAT` | `bool STAT_GET_FLOAT(uint statHash, ref float outValue, object p2)` | bool |
| `STAT_GET_FLYING_ALTITUDE` | `bool STAT_GET_FLYING_ALTITUDE(ref float outValue)` | bool |
| `STAT_GET_INT` | `bool STAT_GET_INT(uint statHash, ref int outValue, int p2)` | bool |
| `STAT_GET_LICENSE_PLATE` | `string STAT_GET_LICENSE_PLATE(uint statName)` | string |
| `STAT_GET_LOAD_SAFE_TO_PROGRESS_TO_MP_FROM_SP` | `bool STAT_GET_LOAD_SAFE_TO_PROGRESS_TO_MP_FROM_SP()` | bool |
| `STAT_GET_MASKED_INT` | `bool STAT_GET_MASKED_INT(uint statHash, ref int outValue, int p2, int p3, object p4)` | bool |
| `STAT_GET_NUMBER_OF_DAYS` | `int STAT_GET_NUMBER_OF_DAYS(uint statName)` | int |
| `STAT_GET_NUMBER_OF_HOURS` | `int STAT_GET_NUMBER_OF_HOURS(uint statName)` | int |
| `STAT_GET_NUMBER_OF_MINUTES` | `int STAT_GET_NUMBER_OF_MINUTES(uint statName)` | int |
| `STAT_GET_NUMBER_OF_SECONDS` | `int STAT_GET_NUMBER_OF_SECONDS(uint statName)` | int |
| `STAT_GET_POS` | `bool STAT_GET_POS(uint statName, ref float outX, ref float outY, ref float outZ, object p4)` | bool |
| `STAT_GET_RECORDED_VALUE` | `bool STAT_GET_RECORDED_VALUE(ref float value)` | bool |
| `STAT_GET_SAVE_MIGRATION_CONSUME_CONTENT_STATUS` | `int STAT_GET_SAVE_MIGRATION_CONSUME_CONTENT_STATUS(ref int p0)` | int |
| `STAT_GET_SAVE_MIGRATION_STATUS` | `int STAT_GET_SAVE_MIGRATION_STATUS(ref object data)` | int |
| `STAT_GET_STRING` | `string STAT_GET_STRING(uint statHash, int p1)` | string |
| `STAT_GET_USER_ID` | `string STAT_GET_USER_ID(uint statHash)` | string |
| `STAT_GET_VEHICLE_BAIL_DISTANCE` | `float STAT_GET_VEHICLE_BAIL_DISTANCE()` | float |
| `STAT_INCREMENT` | `void STAT_INCREMENT(uint statName, float value)` | void |
| `STAT_IS_PLAYER_VEHICLE_ABOVE_OCEAN` | `bool STAT_IS_PLAYER_VEHICLE_ABOVE_OCEAN()` | bool |
| `STAT_IS_RECORDING_STAT` | `bool STAT_IS_RECORDING_STAT()` | bool |
| `STAT_IS_STATS_TRACKING_ENABLED` | `bool STAT_IS_STATS_TRACKING_ENABLED()` | bool |
| `STAT_LOAD` | `bool STAT_LOAD(int statSlot)` | bool |
| `STAT_LOAD_DIRTY_READ_DETECTED` | `bool STAT_LOAD_DIRTY_READ_DETECTED()` | bool |
| `STAT_LOAD_PENDING` | `bool STAT_LOAD_PENDING(int statSlot)` | bool |
| `STAT_LOCAL_RESET_ALL_ONLINE_CHARACTER_STATS` | `void STAT_LOCAL_RESET_ALL_ONLINE_CHARACTER_STATS(int p0)` | void |
| `STAT_MIGRATE_CHECK_ALREADY_DONE` | `bool STAT_MIGRATE_CHECK_ALREADY_DONE()` | bool |
| `STAT_MIGRATE_CHECK_GET_IS_PLATFORM_AVAILABLE` | `int STAT_MIGRATE_CHECK_GET_IS_PLATFORM_AVAILABLE(int p0)` | int |
| `STAT_MIGRATE_CHECK_GET_PLATFORM_STATUS` | `int STAT_MIGRATE_CHECK_GET_PLATFORM_STATUS(int p0, ref object p1)` | int |
| `STAT_MIGRATE_CHECK_START` | `bool STAT_MIGRATE_CHECK_START()` | bool |
| `STAT_MIGRATE_CLEAR_FOR_RESTART` | `void STAT_MIGRATE_CLEAR_FOR_RESTART()` | void |
| `STAT_MIGRATE_SAVEGAME_GET_STATUS` | `int STAT_MIGRATE_SAVEGAME_GET_STATUS()` | int |
| `STAT_MIGRATE_SAVEGAME_START` | `bool STAT_MIGRATE_SAVEGAME_START(string platformName)` | bool |
| `STAT_NETWORK_INCREMENT_ON_SUICIDE` | `void STAT_NETWORK_INCREMENT_ON_SUICIDE(object p0, float p1)` | void |
| `STAT_RESET_ALL_ONLINE_CHARACTER_STATS` | `void STAT_RESET_ALL_ONLINE_CHARACTER_STATS(int p0)` | void |
| `STAT_ROLLBACK_SAVE_MIGRATION` | `bool STAT_ROLLBACK_SAVE_MIGRATION()` | bool |
| `STAT_SAVE` | `bool STAT_SAVE(int p0, bool p1, int p2, bool p3)` | bool |
| `STAT_SAVE_MIGRATION_CANCEL_PENDING_OPERATION` | `bool STAT_SAVE_MIGRATION_CANCEL_PENDING_OPERATION()` | bool |
| `STAT_SAVE_MIGRATION_CONSUME_CONTENT` | `bool STAT_SAVE_MIGRATION_CONSUME_CONTENT(uint contentId, string srcPlatform, string srcGamerHandle)` | bool |
| `STAT_SAVE_PENDING` | `bool STAT_SAVE_PENDING()` | bool |
| `STAT_SAVE_PENDING_OR_REQUESTED` | `bool STAT_SAVE_PENDING_OR_REQUESTED()` | bool |
| `STAT_SET_BLOCK_SAVES` | `void STAT_SET_BLOCK_SAVES(bool toggle)` | void |
| `STAT_SET_BOOL` | `bool STAT_SET_BOOL(uint statName, bool value, bool save)` | bool |
| `STAT_SET_CHEAT_IS_ACTIVE` | `void STAT_SET_CHEAT_IS_ACTIVE()` | void |
| `STAT_SET_CURRENT_POSIX_TIME` | `bool STAT_SET_CURRENT_POSIX_TIME(uint statName, bool p1)` | bool |
| `STAT_SET_DATE` | `bool STAT_SET_DATE(uint statName, ref object value, int numFields, bool save)` | bool |
| `STAT_SET_FLOAT` | `bool STAT_SET_FLOAT(uint statName, float value, bool save)` | bool |
| `STAT_SET_GXT_LABEL` | `bool STAT_SET_GXT_LABEL(uint statName, string value, bool save)` | bool |
| `STAT_SET_INT` | `bool STAT_SET_INT(uint statName, int value, bool save)` | bool |
| `STAT_SET_LICENSE_PLATE` | `bool STAT_SET_LICENSE_PLATE(uint statName, string str)` | bool |
| `STAT_SET_MASKED_INT` | `bool STAT_SET_MASKED_INT(uint statName, int p1, int p2, int p3, bool save)` | bool |
| `STAT_SET_OPEN_SAVETYPE_IN_JOB` | `void STAT_SET_OPEN_SAVETYPE_IN_JOB(int p0)` | void |
| `STAT_SET_POS` | `bool STAT_SET_POS(uint statName, float x, float y, float z, bool save)` | bool |
| `STAT_SET_PROFILE_SETTING_VALUE` | `void STAT_SET_PROFILE_SETTING_VALUE(int profileSetting, int value)` | void |
| `STAT_SET_STRING` | `bool STAT_SET_STRING(uint statName, string value, bool save)` | bool |
| `STAT_SET_USER_ID` | `bool STAT_SET_USER_ID(uint statName, string value, bool save)` | bool |
| `STAT_SLOT_IS_LOADED` | `bool STAT_SLOT_IS_LOADED(int statSlot)` | bool |
| `STAT_START_RECORD_STAT` | `bool STAT_START_RECORD_STAT(int statType, int valueType)` | bool |
| `STAT_STOP_RECORD_STAT` | `bool STAT_STOP_RECORD_STAT()` | bool |
| `WAS_VC_WITHDRAWAL_SUCCESSFUL` | `bool WAS_VC_WITHDRAWAL_SUCCESSFUL(object p0)` | bool |
| `WITHDRAW_VC` | `int WITHDRAW_VC(int amount)` | int |
| `_GET_STAT_HASH_FOR_CHARACTER_STAT` | `uint _GET_STAT_HASH_FOR_CHARACTER_STAT(int dataType, int statIndex, int charSlot)` | uint |
| `_NETWORK_CLEAR_TRANSACTION_TELEMETRY_NONCE` | `void _NETWORK_CLEAR_TRANSACTION_TELEMETRY_NONCE()` | void |
| `_NETWORK_EARN_AVENGER` | `void _NETWORK_EARN_AVENGER(int amount, int p1)` | void |
| `_NETWORK_EARN_AWARD_ACID_LAB` | `void _NETWORK_EARN_AWARD_ACID_LAB(object p0, object p1)` | void |
| `_NETWORK_EARN_AWARD_DAILY_STASH` | `void _NETWORK_EARN_AWARD_DAILY_STASH(object p0, object p1)` | void |
| `_NETWORK_EARN_AWARD_DEAD_DROP` | `void _NETWORK_EARN_AWARD_DEAD_DROP(object p0, object p1)` | void |
| `_NETWORK_EARN_AWARD_JUGGALO_MISSION` | `void _NETWORK_EARN_AWARD_JUGGALO_MISSION(object p0, object p1)` | void |
| `_NETWORK_EARN_AWARD_RANDOM_EVENT` | `void _NETWORK_EARN_AWARD_RANDOM_EVENT(object p0, object p1)` | void |
| `_NETWORK_EARN_AWARD_TAXI` | `void _NETWORK_EARN_AWARD_TAXI(object p0, object p1)` | void |
| `_NETWORK_EARN_BONUS_OBJECTIVE` | `void _NETWORK_EARN_BONUS_OBJECTIVE(int amount, object p1, object p2)` | void |
| `_NETWORK_EARN_DAILY_STASH_HOUSE_COMPLETED` | `void _NETWORK_EARN_DAILY_STASH_HOUSE_COMPLETED(object p0, object p1)` | void |
| `_NETWORK_EARN_DAILY_STASH_HOUSE_PARTICIPATION` | `void _NETWORK_EARN_DAILY_STASH_HOUSE_PARTICIPATION(object p0, object p1)` | void |
| `_NETWORK_EARN_FOOLIGAN_JOB` | `void _NETWORK_EARN_FOOLIGAN_JOB(object p0, object p1)` | void |
| `_NETWORK_EARN_FOOLIGAN_JOB_PARTICIPATION` | `void _NETWORK_EARN_FOOLIGAN_JOB_PARTICIPATION(object p0, object p1)` | void |
| `_NETWORK_EARN_GENERIC` | `void _NETWORK_EARN_GENERIC(int amount, uint earn, string p2, string p3, ref object data)` | void |
| `_NETWORK_EARN_JUGGALO_STORY_MISSION` | `void _NETWORK_EARN_JUGGALO_STORY_MISSION(object p0, object p1)` | void |
| `_NETWORK_EARN_JUGGALO_STORY_MISSION_PARTICIPATION` | `void _NETWORK_EARN_JUGGALO_STORY_MISSION_PARTICIPATION(object p0, object p1)` | void |
| `_NETWORK_EARN_PROGRESS_HUB` | `void _NETWORK_EARN_PROGRESS_HUB(object p0, object p1)` | void |
| `_NETWORK_EARN_SELL_ACID` | `void _NETWORK_EARN_SELL_ACID(object p0, object p1)` | void |
| `_NETWORK_EARN_SELL_PARTICIPATION_ACID_LAB` | `void _NETWORK_EARN_SELL_PARTICIPATION_ACID_LAB(object p0, object p1)` | void |
| `_NETWORK_EARN_SETUP_PARTICIPATION_ACID_LAB` | `void _NETWORK_EARN_SETUP_PARTICIPATION_ACID_LAB(object p0, object p1)` | void |
| `_NETWORK_EARN_SMUGGLER_OPS` | `void _NETWORK_EARN_SMUGGLER_OPS(object p0, object p1, object p2)` | void |
| `_NETWORK_EARN_SOURCE_PARTICIPATION_ACID_LAB` | `void _NETWORK_EARN_SOURCE_PARTICIPATION_ACID_LAB(object p0, object p1)` | void |
| `_NETWORK_EARN_STREET_DEALER` | `void _NETWORK_EARN_STREET_DEALER(object p0, object p1)` | void |
| `_NETWORK_EARN_TAXI_JOB` | `void _NETWORK_EARN_TAXI_JOB(object p0, object p1)` | void |
| `_NETWORK_SPEND_BUY_ACID_LAB` | `void _NETWORK_SPEND_BUY_ACID_LAB(object p0, object p1, object p2, object p3)` | void |
| `_NETWORK_SPEND_BUY_MFGARAGE` | `void _NETWORK_SPEND_BUY_MFGARAGE(object p0, object p1, object p2, object p3)` | void |
| `_NETWORK_SPEND_BUY_SUPPLIES` | `void _NETWORK_SPEND_BUY_SUPPLIES(int p0, bool p1, bool p2, int p3)` | void |
| `_NETWORK_SPEND_RENAME_ACID_LAB` | `void _NETWORK_SPEND_RENAME_ACID_LAB(object p0, object p1, object p2, object p3)` | void |
| `_NETWORK_SPEND_RENAME_ACID_PRODUCT` | `void _NETWORK_SPEND_RENAME_ACID_PRODUCT(object p0, object p1, object p2, object p3)` | void |
| `_NETWORK_SPEND_UPGRADE_ACID_LAB_ARMOR` | `void _NETWORK_SPEND_UPGRADE_ACID_LAB_ARMOR(int p0, bool p1, bool p2, int p3)` | void |
| `_NETWORK_SPEND_UPGRADE_ACID_LAB_EQUIPMENT` | `void _NETWORK_SPEND_UPGRADE_ACID_LAB_EQUIPMENT(object p0, object p1, object p2, object p3)` | void |
| `_NETWORK_SPEND_UPGRADE_ACID_LAB_MINES` | `void _NETWORK_SPEND_UPGRADE_ACID_LAB_MINES(int p0, bool p1, bool p2, int p3)` | void |
| `_NETWORK_SPEND_UPGRADE_ACID_LAB_SCOOP` | `void _NETWORK_SPEND_UPGRADE_ACID_LAB_SCOOP(int p0, bool p1, bool p2, int p3)` | void |
| `_NETWORK_SPEND_UPGRADE_MFGARAGE` | `void _NETWORK_SPEND_UPGRADE_MFGARAGE(object p0, object p1, object p2, object p3)` | void |
| `_NETWORK_SPENT_AIR_FREIGHT` | `void _NETWORK_SPENT_AIR_FREIGHT(int hangarCargoSourcingPrice, bool fromBank, bool fromBankAndWallet, int cost, int warehouseId, int warehouseSlot, object p6)` | void |
| `_NETWORK_SPENT_GENERIC` | `void _NETWORK_SPENT_GENERIC(int price, bool p1, bool p2, uint stat, uint spent, string p5, string p6, ref object data)` | void |
| `_NETWORK_SPENT_MISSILE_JAMMER` | `void _NETWORK_SPENT_MISSILE_JAMMER(int amount, bool fromBank, bool fromBankAndWallet, uint p3)` | void |
| `_NETWORK_SPENT_SKIP_CARGO_SOURCE_SETUP` | `void _NETWORK_SPENT_SKIP_CARGO_SOURCE_SETUP(int amount, bool fromBank, bool fromBankAndWallet, int cost)` | void |
| `_NETWORK_SPENT_STEALTH_MODULE` | `void _NETWORK_SPENT_STEALTH_MODULE(int amount, bool fromBank, bool fromBankAndWallet, uint p3)` | void |
| `_PLAYSTATS_ACID_MISSION_END` | `void _PLAYSTATS_ACID_MISSION_END(object p0)` | void |
| `_PLAYSTATS_ACID_RND` | `void _PLAYSTATS_ACID_RND(object p0)` | void |
| `_PLAYSTATS_ALERT` | `void _PLAYSTATS_ALERT(ref object data)` | void |
| `_PLAYSTATS_ATTRITION_STAGE_END` | `void _PLAYSTATS_ATTRITION_STAGE_END(object p0)` | void |
| `_PLAYSTATS_CREATOR_END` | `void _PLAYSTATS_CREATOR_END(ref object p0)` | void |
| `_PLAYSTATS_DEATH_INFO` | `void _PLAYSTATS_DEATH_INFO(int victimPed, int killerPed, int mentalState, bool revengeKill, int victimKvK, int killerKvK)` | void |
| `_PLAYSTATS_FLOW_HIGH` | `void _PLAYSTATS_FLOW_HIGH(float posX, float posY, float posZ, string action, bool p4, int p5)` | void |
| `_PLAYSTATS_FLOW_LOW` | `void _PLAYSTATS_FLOW_LOW(float posX, float posY, float posZ, string action, bool p4, int p5)` | void |
| `_PLAYSTATS_FLOW_MEDIUM` | `void _PLAYSTATS_FLOW_MEDIUM(float posX, float posY, float posZ, string action, bool p4, int p5)` | void |
| `_PLAYSTATS_IDLE` | `void _PLAYSTATS_IDLE(object p0, object p1, object p2)` | void |
| `_PLAYSTATS_INIT_MULTIPLAYER` | `void _PLAYSTATS_INIT_MULTIPLAYER(object p0, object p1, object p2)` | void |
| `_PLAYSTATS_LOBBY_EXIT` | `void _PLAYSTATS_LOBBY_EXIT(ref object p0)` | void |
| `_PLAYSTATS_LOBBY_STARTED` | `void _PLAYSTATS_LOBBY_STARTED(ref object p0)` | void |
| `_PLAYSTATS_NAMED_USER_CONTENT` | `void _PLAYSTATS_NAMED_USER_CONTENT(bool isBoss, int bossType, int bossId1, int bossId2, int textType, string textString, int textSource)` | void |
| `_PLAYSTATS_PIMENU_NAV` | `void _PLAYSTATS_PIMENU_NAV(ref object data)` | void |
| `_PLAYSTATS_PLAYER_STYLE` | `void _PLAYSTATS_PLAYER_STYLE(object p0)` | void |
| `_PLAYSTATS_RANDOM_EVENT` | `void _PLAYSTATS_RANDOM_EVENT(object p0)` | void |
| `_PLAYSTATS_RECOVER_VEHICLE` | `void _PLAYSTATS_RECOVER_VEHICLE(ref object data)` | void |
| `_PLAYSTATS_SCRIPT_EVENT_FPOM` | `void _PLAYSTATS_SCRIPT_EVENT_FPOM(ref object data)` | void |
| `_PLAYSTATS_SHOPMENU_NAV` | `void _PLAYSTATS_SHOPMENU_NAV(object p0, object p1, object p2, object p3)` | void |
| `_PLAYSTATS_SHOWROOM_NAV` | `void _PLAYSTATS_SHOWROOM_NAV(object p0, object p1, uint entity)` | void |
| `_PLAYSTATS_SHOWROOM_OVERVIEW` | `void _PLAYSTATS_SHOWROOM_OVERVIEW(ref object data)` | void |

---

## VEHICLE

| 函数名 | 签名 | 返回值 |
|--------|------|--------|
| `ADD_ROAD_NODE_SPEED_ZONE` | `int ADD_ROAD_NODE_SPEED_ZONE(float x, float y, float z, float radius, float speed, bool p5)` | int |
| `ADD_VEHICLE_COMBAT_ANGLED_AVOIDANCE_AREA` | `int ADD_VEHICLE_COMBAT_ANGLED_AVOIDANCE_AREA(float p0, float p1, float p2, float p3, float p4, float p5, float p6)` | int |
| `ADD_VEHICLE_PHONE_EXPLOSIVE_DEVICE` | `void ADD_VEHICLE_PHONE_EXPLOSIVE_DEVICE(int vehicle)` | void |
| `ADD_VEHICLE_STUCK_CHECK_WITH_WARP` | `void ADD_VEHICLE_STUCK_CHECK_WITH_WARP(object p0, float p1, object p2, bool p3, bool p4, bool p5, object p6)` | void |
| `ADD_VEHICLE_UPSIDEDOWN_CHECK` | `void ADD_VEHICLE_UPSIDEDOWN_CHECK(int vehicle)` | void |
| `ALLOW_AMBIENT_VEHICLES_TO_AVOID_ADVERSE_CONDITIONS` | `void ALLOW_AMBIENT_VEHICLES_TO_AVOID_ADVERSE_CONDITIONS(int vehicle)` | void |
| `ALLOW_BOAT_BOOM_TO_ANIMATE` | `void ALLOW_BOAT_BOOM_TO_ANIMATE(int vehicle, bool toggle)` | void |
| `ALLOW_TRAIN_TO_BE_REMOVED_BY_POPULATION` | `void ALLOW_TRAIN_TO_BE_REMOVED_BY_POPULATION(object p0)` | void |
| `APPLY_EMP_EFFECT` | `void APPLY_EMP_EFFECT(int vehicle)` | void |
| `ARE_ALL_VEHICLE_WINDOWS_INTACT` | `bool ARE_ALL_VEHICLE_WINDOWS_INTACT(int vehicle)` | bool |
| `ARE_ANY_VEHICLE_SEATS_FREE` | `bool ARE_ANY_VEHICLE_SEATS_FREE(int vehicle)` | bool |
| `ARE_FOLDING_WINGS_DEPLOYED` | `bool ARE_FOLDING_WINGS_DEPLOYED(int vehicle)` | bool |
| `ARE_PLANE_CONTROL_PANELS_INTACT` | `bool ARE_PLANE_CONTROL_PANELS_INTACT(int vehicle, bool p1)` | bool |
| `ARE_PLANE_PROPELLERS_INTACT` | `bool ARE_PLANE_PROPELLERS_INTACT(int plane)` | bool |
| `ARE_WINGS_OF_PLANE_INTACT` | `bool ARE_WINGS_OF_PLANE_INTACT(int plane)` | bool |
| `ATTACH_CONTAINER_TO_HANDLER_FRAME_WHEN_LINED_UP` | `void ATTACH_CONTAINER_TO_HANDLER_FRAME_WHEN_LINED_UP(int vehicle, int entity)` | void |
| `ATTACH_ENTITY_TO_CARGOBOB` | `void ATTACH_ENTITY_TO_CARGOBOB(object p0, object p1, object p2, object p3, object p4, object p5)` | void |
| `ATTACH_VEHICLE_ON_TO_TRAILER` | `void ATTACH_VEHICLE_ON_TO_TRAILER(int vehicle, int trailer, float offsetX, float offsetY, float offsetZ, float coordsX, float coordsY, float coordsZ, float rotationX, float rotationY, float rotationZ, float disableCollisions)` | void |
| `ATTACH_VEHICLE_TO_CARGOBOB` | `void ATTACH_VEHICLE_TO_CARGOBOB(int cargobob, int vehicle, int p2, float x, float y, float z)` | void |
| `ATTACH_VEHICLE_TO_TOW_TRUCK` | `void ATTACH_VEHICLE_TO_TOW_TRUCK(int towTruck, int vehicle, bool rear, float hookOffsetX, float hookOffsetY, float hookOffsetZ)` | void |
| `ATTACH_VEHICLE_TO_TRAILER` | `void ATTACH_VEHICLE_TO_TRAILER(int vehicle, int trailer, float radius)` | void |
| `BRING_VEHICLE_TO_HALT` | `void BRING_VEHICLE_TO_HALT(int vehicle, float distance, int duration, bool p3)` | void |
| `CAN_ANCHOR_BOAT_HERE` | `bool CAN_ANCHOR_BOAT_HERE(int vehicle)` | bool |
| `CAN_ANCHOR_BOAT_HERE_IGNORE_PLAYERS` | `bool CAN_ANCHOR_BOAT_HERE_IGNORE_PLAYERS(int vehicle)` | bool |
| `CAN_CARGOBOB_PICK_UP_ENTITY` | `bool CAN_CARGOBOB_PICK_UP_ENTITY(object p0, object p1)` | bool |
| `CAN_SHUFFLE_SEAT` | `bool CAN_SHUFFLE_SEAT(int vehicle, int seatIndex)` | bool |
| `CLEAR_LAST_DRIVEN_VEHICLE` | `void CLEAR_LAST_DRIVEN_VEHICLE()` | void |
| `CLEAR_NITROUS` | `void CLEAR_NITROUS(int vehicle)` | void |
| `CLEAR_VEHICLE_CUSTOM_PRIMARY_COLOUR` | `void CLEAR_VEHICLE_CUSTOM_PRIMARY_COLOUR(int vehicle)` | void |
| `CLEAR_VEHICLE_CUSTOM_SECONDARY_COLOUR` | `void CLEAR_VEHICLE_CUSTOM_SECONDARY_COLOUR(int vehicle)` | void |
| `CLEAR_VEHICLE_GENERATOR_AREA_OF_INTEREST` | `void CLEAR_VEHICLE_GENERATOR_AREA_OF_INTEREST()` | void |
| `CLEAR_VEHICLE_PETROLTANK_FIRE_CULPRIT` | `void CLEAR_VEHICLE_PETROLTANK_FIRE_CULPRIT(int vehicle)` | void |
| `CLEAR_VEHICLE_PHONE_EXPLOSIVE_DEVICE` | `void CLEAR_VEHICLE_PHONE_EXPLOSIVE_DEVICE()` | void |
| `CLEAR_VEHICLE_ROUTE_HISTORY` | `void CLEAR_VEHICLE_ROUTE_HISTORY(int vehicle)` | void |
| `CLOSE_BOMB_BAY_DOORS` | `void CLOSE_BOMB_BAY_DOORS(int vehicle)` | void |
| `CONTROL_LANDING_GEAR` | `void CONTROL_LANDING_GEAR(int vehicle, int state)` | void |
| `COPY_VEHICLE_DAMAGES` | `void COPY_VEHICLE_DAMAGES(int sourceVehicle, int targetVehicle)` | void |
| `CREATE_MISSION_TRAIN` | `int CREATE_MISSION_TRAIN(int variation, float x, float y, float z, bool direction, object p5, object p6)` | int |
| `CREATE_PICK_UP_ROPE_FOR_CARGOBOB` | `void CREATE_PICK_UP_ROPE_FOR_CARGOBOB(int cargobob, int state)` | void |
| `CREATE_SCRIPT_VEHICLE_GENERATOR` | `int CREATE_SCRIPT_VEHICLE_GENERATOR(float x, float y, float z, float heading, float p4, float p5, uint modelHash, int p7, int p8, int p9, int p10, bool p11, bool p12, bool p13, bool p14, bool p15, int p16)` | int |
| `CREATE_VEHICLE` | `int CREATE_VEHICLE(uint modelHash, float x, float y, float z, float heading, bool isNetwork, bool bScriptHostVeh, bool p7)` | int |
| `DELETE_ALL_TRAINS` | `void DELETE_ALL_TRAINS()` | void |
| `DELETE_MISSION_TRAIN` | `void DELETE_MISSION_TRAIN(Vehicle* train)` | void |
| `DELETE_SCRIPT_VEHICLE_GENERATOR` | `void DELETE_SCRIPT_VEHICLE_GENERATOR(int vehicleGenerator)` | void |
| `DELETE_VEHICLE` | `void DELETE_VEHICLE(Vehicle* vehicle)` | void |
| `DETACH_CONTAINER_FROM_HANDLER_FRAME` | `void DETACH_CONTAINER_FROM_HANDLER_FRAME(int vehicle)` | void |
| `DETACH_ENTITY_FROM_CARGOBOB` | `bool DETACH_ENTITY_FROM_CARGOBOB(int cargobob, int entity)` | bool |
| `DETACH_VEHICLE_FROM_ANY_CARGOBOB` | `bool DETACH_VEHICLE_FROM_ANY_CARGOBOB(int vehicle)` | bool |
| `DETACH_VEHICLE_FROM_ANY_TOW_TRUCK` | `bool DETACH_VEHICLE_FROM_ANY_TOW_TRUCK(int vehicle)` | bool |
| `DETACH_VEHICLE_FROM_CARGOBOB` | `void DETACH_VEHICLE_FROM_CARGOBOB(int vehicle, int cargobob)` | void |
| `DETACH_VEHICLE_FROM_TOW_TRUCK` | `void DETACH_VEHICLE_FROM_TOW_TRUCK(int towTruck, int vehicle)` | void |
| `DETACH_VEHICLE_FROM_TRAILER` | `void DETACH_VEHICLE_FROM_TRAILER(int vehicle)` | void |
| `DETONATE_VEHICLE_PHONE_EXPLOSIVE_DEVICE` | `void DETONATE_VEHICLE_PHONE_EXPLOSIVE_DEVICE()` | void |
| `DISABLE_INDIVIDUAL_PLANE_PROPELLER` | `void DISABLE_INDIVIDUAL_PLANE_PROPELLER(int vehicle, int propeller)` | void |
| `DISABLE_PLANE_AILERON` | `void DISABLE_PLANE_AILERON(int vehicle, bool p1, bool p2)` | void |
| `DISABLE_VEHCILE_DYNAMIC_AMBIENT_SCALES` | `void DISABLE_VEHCILE_DYNAMIC_AMBIENT_SCALES(int vehicle, int p1, int p2)` | void |
| `DISABLE_VEHICLE_EXPLOSION_BREAK_OFF_PARTS` | `void DISABLE_VEHICLE_EXPLOSION_BREAK_OFF_PARTS()` | void |
| `DISABLE_VEHICLE_TURRET_MOVEMENT_THIS_FRAME` | `void DISABLE_VEHICLE_TURRET_MOVEMENT_THIS_FRAME(int vehicle)` | void |
| `DISABLE_VEHICLE_WEAPON` | `void DISABLE_VEHICLE_WEAPON(bool disabled, uint weaponHash, int vehicle, int owner)` | void |
| `DOES_CARGOBOB_HAVE_PICKUP_MAGNET` | `bool DOES_CARGOBOB_HAVE_PICKUP_MAGNET(int cargobob)` | bool |
| `DOES_CARGOBOB_HAVE_PICK_UP_ROPE` | `bool DOES_CARGOBOB_HAVE_PICK_UP_ROPE(int cargobob)` | bool |
| `DOES_EXTRA_EXIST` | `bool DOES_EXTRA_EXIST(int vehicle, int extraId)` | bool |
| `DOES_SCRIPT_VEHICLE_GENERATOR_EXIST` | `bool DOES_SCRIPT_VEHICLE_GENERATOR_EXIST(int vehicleGenerator)` | bool |
| `DOES_VEHICLE_ALLOW_RAPPEL` | `bool DOES_VEHICLE_ALLOW_RAPPEL(int vehicle)` | bool |
| `DOES_VEHICLE_EXIST_WITH_DECORATOR` | `int DOES_VEHICLE_EXIST_WITH_DECORATOR(string decorator)` | int |
| `DOES_VEHICLE_HAVE_ROOF` | `bool DOES_VEHICLE_HAVE_ROOF(int vehicle)` | bool |
| `DOES_VEHICLE_HAVE_SEARCHLIGHT` | `bool DOES_VEHICLE_HAVE_SEARCHLIGHT(int vehicle)` | bool |
| `DOES_VEHICLE_HAVE_STUCK_VEHICLE_CHECK` | `bool DOES_VEHICLE_HAVE_STUCK_VEHICLE_CHECK(int vehicle)` | bool |
| `DOES_VEHICLE_HAVE_WEAPONS` | `bool DOES_VEHICLE_HAVE_WEAPONS(int vehicle)` | bool |
| `ENABLE_VEHICLE_DYNAMIC_AMBIENT_SCALES` | `void ENABLE_VEHICLE_DYNAMIC_AMBIENT_SCALES(int vehicle)` | void |
| `EXPLODE_VEHICLE` | `void EXPLODE_VEHICLE(int vehicle, bool isAudible, bool isInvisible)` | void |
| `EXPLODE_VEHICLE_IN_CUTSCENE` | `void EXPLODE_VEHICLE_IN_CUTSCENE(int vehicle, bool p1)` | void |
| `FIND_HANDLER_VEHICLE_CONTAINER_IS_ATTACHED_TO` | `int FIND_HANDLER_VEHICLE_CONTAINER_IS_ATTACHED_TO(int entity)` | int |
| `FIND_SPAWN_COORDINATES_FOR_HELI` | `Vector3 FIND_SPAWN_COORDINATES_FOR_HELI(int ped)` | Vector3 |
| `FIX_VEHICLE_WINDOW` | `void FIX_VEHICLE_WINDOW(int vehicle, int windowIndex)` | void |
| `FORCE_PLAYBACK_RECORDED_VEHICLE_UPDATE` | `void FORCE_PLAYBACK_RECORDED_VEHICLE_UPDATE(int vehicle, bool p1)` | void |
| `FORCE_SUBMARINE_NEURTAL_BUOYANCY` | `void FORCE_SUBMARINE_NEURTAL_BUOYANCY(object p0, object p1)` | void |
| `FORCE_SUBMARINE_SURFACE_MODE` | `void FORCE_SUBMARINE_SURFACE_MODE(int vehicle, bool toggle)` | void |
| `FORCE_SUB_THROTTLE_FOR_TIME` | `void FORCE_SUB_THROTTLE_FOR_TIME(int vehicle, float p1, float p2)` | void |
| `FULLY_CHARGE_NITROUS` | `void FULLY_CHARGE_NITROUS(int vehicle)` | void |
| `GENERATE_VEHICLE_CREATION_POS_FROM_PATHS` | `bool GENERATE_VEHICLE_CREATION_POS_FROM_PATHS(ref Vector3 outVec, object p1, ref Vector3 outVec1, object p3, object p4, object p5, object p6, object p7, object p8)` | bool |
| `GET_ALL_VEHICLES` | `int GET_ALL_VEHICLES(ref object vehsStruct)` | int |
| `GET_ARE_BOMB_BAY_DOORS_OPEN` | `bool GET_ARE_BOMB_BAY_DOORS_OPEN(int aircraft)` | bool |
| `GET_ATTACHED_PICK_UP_HOOK_POSITION` | `Vector3 GET_ATTACHED_PICK_UP_HOOK_POSITION(int cargobob)` | Vector3 |
| `GET_BOAT_BOOM_POSITION_RATIO` | `float GET_BOAT_BOOM_POSITION_RATIO(int vehicle)` | float |
| `GET_BOAT_VEHICLE_MODEL_AGILITY` | `float GET_BOAT_VEHICLE_MODEL_AGILITY(uint modelHash)` | float |
| `GET_BOTH_VEHICLE_HEADLIGHTS_DAMAGED` | `bool GET_BOTH_VEHICLE_HEADLIGHTS_DAMAGED(int vehicle)` | bool |
| `GET_CAN_VEHICLE_BE_PLACED_HERE` | `bool GET_CAN_VEHICLE_BE_PLACED_HERE(int vehicle, float x, float y, float z, float rotX, float rotY, float rotZ, int p7, object p8)` | bool |
| `GET_CAR_HAS_JUMP` | `bool GET_CAR_HAS_JUMP(int vehicle)` | bool |
| `GET_CLOSEST_VEHICLE` | `int GET_CLOSEST_VEHICLE(float x, float y, float z, float radius, uint modelHash, int flags)` | int |
| `GET_CONVERTIBLE_ROOF_STATE` | `int GET_CONVERTIBLE_ROOF_STATE(int vehicle)` | int |
| `GET_CURRENT_PLAYBACK_FOR_VEHICLE` | `int GET_CURRENT_PLAYBACK_FOR_VEHICLE(int vehicle)` | int |
| `GET_DISPLAY_NAME_FROM_VEHICLE_MODEL` | `string GET_DISPLAY_NAME_FROM_VEHICLE_MODEL(uint modelHash)` | string |
| `GET_DOES_VEHICLE_HAVE_DAMAGE_DECALS` | `bool GET_DOES_VEHICLE_HAVE_DAMAGE_DECALS(int vehicle)` | bool |
| `GET_DOES_VEHICLE_HAVE_TOMBSTONE` | `bool GET_DOES_VEHICLE_HAVE_TOMBSTONE(int vehicle)` | bool |
| `GET_DRIFT_TYRES_SET` | `bool GET_DRIFT_TYRES_SET(int vehicle)` | bool |
| `GET_ENTITY_ATTACHED_TO_CARGOBOB` | `int GET_ENTITY_ATTACHED_TO_CARGOBOB(object p0)` | int |
| `GET_ENTITY_ATTACHED_TO_TOW_TRUCK` | `int GET_ENTITY_ATTACHED_TO_TOW_TRUCK(int towTruck)` | int |
| `GET_ENTRY_POINT_POSITION` | `Vector3 GET_ENTRY_POINT_POSITION(int vehicle, int doorId)` | Vector3 |
| `GET_FAKE_SUSPENSION_LOWERING_AMOUNT` | `float GET_FAKE_SUSPENSION_LOWERING_AMOUNT(int vehicle)` | float |
| `GET_FLYING_VEHICLE_MODEL_AGILITY` | `float GET_FLYING_VEHICLE_MODEL_AGILITY(uint modelHash)` | float |
| `GET_HAS_RETRACTABLE_WHEELS` | `bool GET_HAS_RETRACTABLE_WHEELS(int vehicle)` | bool |
| `GET_HAS_ROCKET_BOOST` | `bool GET_HAS_ROCKET_BOOST(int vehicle)` | bool |
| `GET_HAS_VEHICLE_BEEN_HIT_BY_SHUNT` | `bool GET_HAS_VEHICLE_BEEN_HIT_BY_SHUNT(int vehicle)` | bool |
| `GET_HELI_MAIN_ROTOR_HEALTH` | `float GET_HELI_MAIN_ROTOR_HEALTH(int vehicle)` | float |
| `GET_HELI_TAIL_BOOM_HEALTH` | `float GET_HELI_TAIL_BOOM_HEALTH(int vehicle)` | float |
| `GET_HELI_TAIL_ROTOR_HEALTH` | `float GET_HELI_TAIL_ROTOR_HEALTH(int vehicle)` | float |
| `GET_HYDRAULIC_SUSPENSION_RAISE_FACTOR` | `float GET_HYDRAULIC_SUSPENSION_RAISE_FACTOR(int vehicle, int wheelId)` | float |
| `GET_IN_VEHICLE_CLIPSET_HASH_FOR_SEAT` | `uint GET_IN_VEHICLE_CLIPSET_HASH_FOR_SEAT(int vehicle, int p1)` | uint |
| `GET_IS_BOAT_CAPSIZED` | `bool GET_IS_BOAT_CAPSIZED(int vehicle)` | bool |
| `GET_IS_DOOR_VALID` | `bool GET_IS_DOOR_VALID(int vehicle, int doorId)` | bool |
| `GET_IS_LEFT_VEHICLE_HEADLIGHT_DAMAGED` | `bool GET_IS_LEFT_VEHICLE_HEADLIGHT_DAMAGED(int vehicle)` | bool |
| `GET_IS_RIGHT_VEHICLE_HEADLIGHT_DAMAGED` | `bool GET_IS_RIGHT_VEHICLE_HEADLIGHT_DAMAGED(int vehicle)` | bool |
| `GET_IS_VEHICLE_DISABLED_BY_EMP` | `bool GET_IS_VEHICLE_DISABLED_BY_EMP(int vehicle)` | bool |
| `GET_IS_VEHICLE_ENGINE_RUNNING` | `bool GET_IS_VEHICLE_ENGINE_RUNNING(int vehicle)` | bool |
| `GET_IS_VEHICLE_PRIMARY_COLOUR_CUSTOM` | `bool GET_IS_VEHICLE_PRIMARY_COLOUR_CUSTOM(int vehicle)` | bool |
| `GET_IS_VEHICLE_SECONDARY_COLOUR_CUSTOM` | `bool GET_IS_VEHICLE_SECONDARY_COLOUR_CUSTOM(int vehicle)` | bool |
| `GET_IS_VEHICLE_SHUNTING` | `bool GET_IS_VEHICLE_SHUNTING(int vehicle)` | bool |
| `GET_IS_WHEELS_RETRACTED` | `bool GET_IS_WHEELS_RETRACTED(int vehicle)` | bool |
| `GET_LANDING_GEAR_STATE` | `int GET_LANDING_GEAR_STATE(int vehicle)` | int |
| `GET_LAST_DRIVEN_VEHICLE` | `int GET_LAST_DRIVEN_VEHICLE()` | int |
| `GET_LAST_PED_IN_VEHICLE_SEAT` | `int GET_LAST_PED_IN_VEHICLE_SEAT(int vehicle, int seatIndex)` | int |
| `GET_LAST_SHUNT_VEHICLE` | `int GET_LAST_SHUNT_VEHICLE(int vehicle)` | int |
| `GET_LIVERY_NAME` | `string GET_LIVERY_NAME(int vehicle, int liveryIndex)` | string |
| `GET_MAKE_NAME_FROM_VEHICLE_MODEL` | `string GET_MAKE_NAME_FROM_VEHICLE_MODEL(uint modelHash)` | string |
| `GET_MOD_SLOT_NAME` | `string GET_MOD_SLOT_NAME(int vehicle, int modType)` | string |
| `GET_MOD_TEXT_LABEL` | `string GET_MOD_TEXT_LABEL(int vehicle, int modType, int modValue)` | string |
| `GET_NUMBER_OF_VEHICLE_COLOURS` | `int GET_NUMBER_OF_VEHICLE_COLOURS(int vehicle)` | int |
| `GET_NUMBER_OF_VEHICLE_DOORS` | `int GET_NUMBER_OF_VEHICLE_DOORS(int vehicle)` | int |
| `GET_NUMBER_OF_VEHICLE_NUMBER_PLATES` | `int GET_NUMBER_OF_VEHICLE_NUMBER_PLATES()` | int |
| `GET_NUM_MOD_COLORS` | `int GET_NUM_MOD_COLORS(int paintType, bool p1)` | int |
| `GET_NUM_MOD_KITS` | `int GET_NUM_MOD_KITS(int vehicle)` | int |
| `GET_NUM_VEHICLE_MODS` | `int GET_NUM_VEHICLE_MODS(int vehicle, int modType)` | int |
| `GET_NUM_VEHICLE_WINDOW_TINTS` | `int GET_NUM_VEHICLE_WINDOW_TINTS()` | int |
| `GET_OUTRIGGERS_DEPLOYED` | `bool GET_OUTRIGGERS_DEPLOYED(int vehicle)` | bool |
| `GET_PED_IN_VEHICLE_SEAT` | `int GET_PED_IN_VEHICLE_SEAT(int vehicle, int seatIndex, bool p2)` | int |
| `GET_PED_USING_VEHICLE_DOOR` | `int GET_PED_USING_VEHICLE_DOOR(int vehicle, int doord)` | int |
| `GET_POSITION_IN_RECORDING` | `float GET_POSITION_IN_RECORDING(int vehicle)` | float |
| `GET_POSITION_OF_VEHICLE_RECORDING_AT_TIME` | `Vector3 GET_POSITION_OF_VEHICLE_RECORDING_AT_TIME(int recording, float time, string script)` | Vector3 |
| `GET_POSITION_OF_VEHICLE_RECORDING_ID_AT_TIME` | `Vector3 GET_POSITION_OF_VEHICLE_RECORDING_ID_AT_TIME(int id, float time)` | Vector3 |
| `GET_RANDOM_VEHICLE_BACK_BUMPER_IN_SPHERE` | `int GET_RANDOM_VEHICLE_BACK_BUMPER_IN_SPHERE(float p0, float p1, float p2, float p3, int p4, int p5, int p6)` | int |
| `GET_RANDOM_VEHICLE_FRONT_BUMPER_IN_SPHERE` | `int GET_RANDOM_VEHICLE_FRONT_BUMPER_IN_SPHERE(float p0, float p1, float p2, float p3, int p4, int p5, int p6)` | int |
| `GET_RANDOM_VEHICLE_IN_SPHERE` | `int GET_RANDOM_VEHICLE_IN_SPHERE(float x, float y, float z, float radius, uint modelHash, int flags)` | int |
| `GET_RANDOM_VEHICLE_MODEL_IN_MEMORY` | `void GET_RANDOM_VEHICLE_MODEL_IN_MEMORY(bool p0, Hash* modelHash, ref int successIndicator)` | void |
| `GET_ROTATION_OF_VEHICLE_RECORDING_AT_TIME` | `Vector3 GET_ROTATION_OF_VEHICLE_RECORDING_AT_TIME(int recording, float time, string script)` | Vector3 |
| `GET_ROTATION_OF_VEHICLE_RECORDING_ID_AT_TIME` | `Vector3 GET_ROTATION_OF_VEHICLE_RECORDING_ID_AT_TIME(int id, float time)` | Vector3 |
| `GET_SUBMARINE_IS_UNDER_DESIGN_DEPTH` | `bool GET_SUBMARINE_IS_UNDER_DESIGN_DEPTH(int submarine)` | bool |
| `GET_SUBMARINE_NUMBER_OF_AIR_LEAKS` | `int GET_SUBMARINE_NUMBER_OF_AIR_LEAKS(int submarine)` | int |
| `GET_TIME_POSITION_IN_RECORDING` | `float GET_TIME_POSITION_IN_RECORDING(int vehicle)` | float |
| `GET_TOTAL_DURATION_OF_VEHICLE_RECORDING` | `float GET_TOTAL_DURATION_OF_VEHICLE_RECORDING(int recording, string script)` | float |
| `GET_TOTAL_DURATION_OF_VEHICLE_RECORDING_ID` | `float GET_TOTAL_DURATION_OF_VEHICLE_RECORDING_ID(int id)` | float |
| `GET_TRAIN_CARRIAGE` | `int GET_TRAIN_CARRIAGE(int train, int trailerNumber)` | int |
| `GET_TYRE_HEALTH` | `float GET_TYRE_HEALTH(int vehicle, int wheelIndex)` | float |
| `GET_TYRE_WEAR_RATE` | `float GET_TYRE_WEAR_RATE(int vehicle, int wheelIndex)` | float |
| `GET_VEHICLE_ACCELERATION` | `float GET_VEHICLE_ACCELERATION(int vehicle)` | float |
| `GET_VEHICLE_ATTACHED_TO_CARGOBOB` | `int GET_VEHICLE_ATTACHED_TO_CARGOBOB(int cargobob)` | int |
| `GET_VEHICLE_BODY_HEALTH` | `float GET_VEHICLE_BODY_HEALTH(int vehicle)` | float |
| `GET_VEHICLE_BOMB_AMMO` | `int GET_VEHICLE_BOMB_AMMO(int vehicle)` | int |
| `GET_VEHICLE_CAN_DEPLOY_PARACHUTE` | `bool GET_VEHICLE_CAN_DEPLOY_PARACHUTE(int vehicle)` | bool |
| `GET_VEHICLE_CAUSE_OF_DESTRUCTION` | `uint GET_VEHICLE_CAUSE_OF_DESTRUCTION(int vehicle)` | uint |
| `GET_VEHICLE_CLASS` | `int GET_VEHICLE_CLASS(int vehicle)` | int |
| `GET_VEHICLE_CLASS_ESTIMATED_MAX_SPEED` | `float GET_VEHICLE_CLASS_ESTIMATED_MAX_SPEED(int vehicleClass)` | float |
| `GET_VEHICLE_CLASS_FROM_NAME` | `int GET_VEHICLE_CLASS_FROM_NAME(uint modelHash)` | int |
| `GET_VEHICLE_CLASS_MAX_ACCELERATION` | `float GET_VEHICLE_CLASS_MAX_ACCELERATION(int vehicleClass)` | float |
| `GET_VEHICLE_CLASS_MAX_AGILITY` | `float GET_VEHICLE_CLASS_MAX_AGILITY(int vehicleClass)` | float |
| `GET_VEHICLE_CLASS_MAX_BRAKING` | `float GET_VEHICLE_CLASS_MAX_BRAKING(int vehicleClass)` | float |
| `GET_VEHICLE_CLASS_MAX_TRACTION` | `float GET_VEHICLE_CLASS_MAX_TRACTION(int vehicleClass)` | float |
| `GET_VEHICLE_COLOR` | `void GET_VEHICLE_COLOR(int vehicle, ref int r, ref int g, ref int b)` | void |
| `GET_VEHICLE_COLOURS` | `void GET_VEHICLE_COLOURS(int vehicle, ref int colorPrimary, ref int colorSecondary)` | void |
| `GET_VEHICLE_COLOURS_WHICH_CAN_BE_SET` | `int GET_VEHICLE_COLOURS_WHICH_CAN_BE_SET(int vehicle)` | int |
| `GET_VEHICLE_COLOUR_COMBINATION` | `int GET_VEHICLE_COLOUR_COMBINATION(int vehicle)` | int |
| `GET_VEHICLE_COUNTERMEASURE_AMMO` | `int GET_VEHICLE_COUNTERMEASURE_AMMO(int vehicle)` | int |
| `GET_VEHICLE_CURRENT_TIME_IN_SLIP_STREAM` | `float GET_VEHICLE_CURRENT_TIME_IN_SLIP_STREAM(int vehicle)` | float |
| `GET_VEHICLE_CUSTOM_PRIMARY_COLOUR` | `void GET_VEHICLE_CUSTOM_PRIMARY_COLOUR(int vehicle, ref int r, ref int g, ref int b)` | void |
| `GET_VEHICLE_CUSTOM_SECONDARY_COLOUR` | `void GET_VEHICLE_CUSTOM_SECONDARY_COLOUR(int vehicle, ref int r, ref int g, ref int b)` | void |
| `GET_VEHICLE_DEFORMATION_AT_POS` | `Vector3 GET_VEHICLE_DEFORMATION_AT_POS(int vehicle, float offsetX, float offsetY, float offsetZ)` | Vector3 |
| `GET_VEHICLE_DIRT_LEVEL` | `float GET_VEHICLE_DIRT_LEVEL(int vehicle)` | float |
| `GET_VEHICLE_DOORS_LOCKED_FOR_PLAYER` | `bool GET_VEHICLE_DOORS_LOCKED_FOR_PLAYER(int vehicle, int player)` | bool |
| `GET_VEHICLE_DOOR_ANGLE_RATIO` | `float GET_VEHICLE_DOOR_ANGLE_RATIO(int vehicle, int doorId)` | float |
| `GET_VEHICLE_DOOR_LOCK_STATUS` | `int GET_VEHICLE_DOOR_LOCK_STATUS(int vehicle)` | int |
| `GET_VEHICLE_ENGINE_HEALTH` | `float GET_VEHICLE_ENGINE_HEALTH(int vehicle)` | float |
| `GET_VEHICLE_ENVEFF_SCALE` | `float GET_VEHICLE_ENVEFF_SCALE(int vehicle)` | float |
| `GET_VEHICLE_ESTIMATED_MAX_SPEED` | `float GET_VEHICLE_ESTIMATED_MAX_SPEED(int vehicle)` | float |
| `GET_VEHICLE_EXTRA_COLOURS` | `void GET_VEHICLE_EXTRA_COLOURS(int vehicle, ref int pearlescentColor, ref int wheelColor)` | void |
| `GET_VEHICLE_EXTRA_COLOUR_5` | `void GET_VEHICLE_EXTRA_COLOUR_5(int vehicle, ref int color)` | void |
| `GET_VEHICLE_EXTRA_COLOUR_6` | `void GET_VEHICLE_EXTRA_COLOUR_6(int vehicle, ref int color)` | void |
| `GET_VEHICLE_FLIGHT_NOZZLE_POSITION` | `float GET_VEHICLE_FLIGHT_NOZZLE_POSITION(int plane)` | float |
| `GET_VEHICLE_HAS_KERS` | `bool GET_VEHICLE_HAS_KERS(int vehicle)` | bool |
| `GET_VEHICLE_HAS_LANDING_GEAR` | `bool GET_VEHICLE_HAS_LANDING_GEAR(int vehicle)` | bool |
| `GET_VEHICLE_HAS_PARACHUTE` | `bool GET_VEHICLE_HAS_PARACHUTE(int vehicle)` | bool |
| `GET_VEHICLE_HEALTH_PERCENTAGE` | `float GET_VEHICLE_HEALTH_PERCENTAGE(int vehicle, float maxEngineHealth, float maxPetrolTankHealth, float maxBodyHealth, float maxMainRotorHealth, float maxTailRotorHealth, float maxUnkHealth)` | float |
| `GET_VEHICLE_HOMING_LOCKEDONTO_STATE` | `int GET_VEHICLE_HOMING_LOCKEDONTO_STATE(object p0)` | int |
| `GET_VEHICLE_HOMING_LOCKON_STATE` | `int GET_VEHICLE_HOMING_LOCKON_STATE(int vehicle)` | int |
| `GET_VEHICLE_INDIVIDUAL_DOOR_LOCK_STATUS` | `int GET_VEHICLE_INDIVIDUAL_DOOR_LOCK_STATUS(int vehicle, int doorId)` | int |
| `GET_VEHICLE_IS_DUMMY` | `bool GET_VEHICLE_IS_DUMMY(object p0)` | bool |
| `GET_VEHICLE_IS_MERCENARY` | `bool GET_VEHICLE_IS_MERCENARY(int vehicle)` | bool |
| `GET_VEHICLE_LAYOUT_HASH` | `uint GET_VEHICLE_LAYOUT_HASH(int vehicle)` | uint |
| `GET_VEHICLE_LIGHTS_STATE` | `bool GET_VEHICLE_LIGHTS_STATE(int vehicle, ref bool lightsOn, ref bool highbeamsOn)` | bool |
| `GET_VEHICLE_LIVERY` | `int GET_VEHICLE_LIVERY(int vehicle)` | int |
| `GET_VEHICLE_LIVERY2` | `int GET_VEHICLE_LIVERY2(int vehicle)` | int |
| `GET_VEHICLE_LIVERY2_COUNT` | `int GET_VEHICLE_LIVERY2_COUNT(int vehicle)` | int |
| `GET_VEHICLE_LIVERY_COUNT` | `int GET_VEHICLE_LIVERY_COUNT(int vehicle)` | int |
| `GET_VEHICLE_LOCK_ON_TARGET` | `bool GET_VEHICLE_LOCK_ON_TARGET(int vehicle, Entity* entity)` | bool |
| `GET_VEHICLE_MAX_BRAKING` | `float GET_VEHICLE_MAX_BRAKING(int vehicle)` | float |
| `GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS` | `int GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS(int vehicle)` | int |
| `GET_VEHICLE_MAX_TRACTION` | `float GET_VEHICLE_MAX_TRACTION(int vehicle)` | float |
| `GET_VEHICLE_MOD` | `int GET_VEHICLE_MOD(int vehicle, int modType)` | int |
| `GET_VEHICLE_MODEL_ACCELERATION` | `float GET_VEHICLE_MODEL_ACCELERATION(uint modelHash)` | float |
| `GET_VEHICLE_MODEL_ACCELERATION_MAX_MODS` | `float GET_VEHICLE_MODEL_ACCELERATION_MAX_MODS(uint modelHash)` | float |
| `GET_VEHICLE_MODEL_ESTIMATED_MAX_SPEED` | `float GET_VEHICLE_MODEL_ESTIMATED_MAX_SPEED(uint modelHash)` | float |
| `GET_VEHICLE_MODEL_MAX_BRAKING` | `float GET_VEHICLE_MODEL_MAX_BRAKING(uint modelHash)` | float |
| `GET_VEHICLE_MODEL_MAX_BRAKING_MAX_MODS` | `float GET_VEHICLE_MODEL_MAX_BRAKING_MAX_MODS(uint modelHash)` | float |
| `GET_VEHICLE_MODEL_MAX_TRACTION` | `float GET_VEHICLE_MODEL_MAX_TRACTION(uint modelHash)` | float |
| `GET_VEHICLE_MODEL_NUMBER_OF_SEATS` | `int GET_VEHICLE_MODEL_NUMBER_OF_SEATS(uint modelHash)` | int |
| `GET_VEHICLE_MODEL_VALUE` | `int GET_VEHICLE_MODEL_VALUE(uint vehicleModel)` | int |
| `GET_VEHICLE_MOD_COLOR_1` | `void GET_VEHICLE_MOD_COLOR_1(int vehicle, ref int paintType, ref int color, ref int pearlescentColor)` | void |
| `GET_VEHICLE_MOD_COLOR_1_NAME` | `string GET_VEHICLE_MOD_COLOR_1_NAME(int vehicle, bool p1)` | string |
| `GET_VEHICLE_MOD_COLOR_2` | `void GET_VEHICLE_MOD_COLOR_2(int vehicle, ref int paintType, ref int color)` | void |
| `GET_VEHICLE_MOD_COLOR_2_NAME` | `string GET_VEHICLE_MOD_COLOR_2_NAME(int vehicle)` | string |
| `GET_VEHICLE_MOD_IDENTIFIER_HASH` | `uint GET_VEHICLE_MOD_IDENTIFIER_HASH(int vehicle, int modType, int modIndex)` | uint |
| `GET_VEHICLE_MOD_KIT` | `int GET_VEHICLE_MOD_KIT(int vehicle)` | int |
| `GET_VEHICLE_MOD_KIT_TYPE` | `int GET_VEHICLE_MOD_KIT_TYPE(int vehicle)` | int |
| `GET_VEHICLE_MOD_MODIFIER_VALUE` | `int GET_VEHICLE_MOD_MODIFIER_VALUE(int vehicle, int modType, int modIndex)` | int |
| `GET_VEHICLE_MOD_VARIATION` | `int GET_VEHICLE_MOD_VARIATION(int vehicle, int modType)` | int |
| `GET_VEHICLE_NEON_COLOUR` | `void GET_VEHICLE_NEON_COLOUR(int vehicle, ref int r, ref int g, ref int b)` | void |
| `GET_VEHICLE_NEON_ENABLED` | `bool GET_VEHICLE_NEON_ENABLED(int vehicle, int index)` | bool |
| `GET_VEHICLE_NUMBER_OF_PASSENGERS` | `int GET_VEHICLE_NUMBER_OF_PASSENGERS(int vehicle, bool includeDriver, bool includeDeadOccupants)` | int |
| `GET_VEHICLE_NUMBER_PLATE_TEXT` | `string GET_VEHICLE_NUMBER_PLATE_TEXT(int vehicle)` | string |
| `GET_VEHICLE_NUMBER_PLATE_TEXT_INDEX` | `int GET_VEHICLE_NUMBER_PLATE_TEXT_INDEX(int vehicle)` | int |
| `GET_VEHICLE_NUM_OF_BROKEN_LOOSEN_PARTS` | `int GET_VEHICLE_NUM_OF_BROKEN_LOOSEN_PARTS(int vehicle)` | int |
| `GET_VEHICLE_NUM_OF_BROKEN_OFF_PARTS` | `int GET_VEHICLE_NUM_OF_BROKEN_OFF_PARTS(int vehicle)` | int |
| `GET_VEHICLE_PETROL_TANK_HEALTH` | `float GET_VEHICLE_PETROL_TANK_HEALTH(int vehicle)` | float |
| `GET_VEHICLE_PLATE_TYPE` | `int GET_VEHICLE_PLATE_TYPE(int vehicle)` | int |
| `GET_VEHICLE_RECORDING_ID` | `int GET_VEHICLE_RECORDING_ID(int recording, string script)` | int |
| `GET_VEHICLE_SIZE` | `void GET_VEHICLE_SIZE(int vehicle, ref Vector3 out1, ref Vector3 out2)` | void |
| `GET_VEHICLE_TRAILER_VEHICLE` | `bool GET_VEHICLE_TRAILER_VEHICLE(int vehicle, Vehicle* trailer)` | bool |
| `GET_VEHICLE_TYRES_CAN_BURST` | `bool GET_VEHICLE_TYRES_CAN_BURST(int vehicle)` | bool |
| `GET_VEHICLE_TYRE_SMOKE_COLOR` | `void GET_VEHICLE_TYRE_SMOKE_COLOR(int vehicle, ref int r, ref int g, ref int b)` | void |
| `GET_VEHICLE_WEAPON_RESTRICTED_AMMO` | `int GET_VEHICLE_WEAPON_RESTRICTED_AMMO(int vehicle, int weaponIndex)` | int |
| `GET_VEHICLE_WHEEL_TYPE` | `int GET_VEHICLE_WHEEL_TYPE(int vehicle)` | int |
| `GET_VEHICLE_WINDOW_TINT` | `int GET_VEHICLE_WINDOW_TINT(int vehicle)` | int |
| `GET_VEHICLE_XENON_LIGHT_COLOR_INDEX` | `int GET_VEHICLE_XENON_LIGHT_COLOR_INDEX(int vehicle)` | int |
| `HAS_INSTANT_FILL_VEHICLE_POPULATION_FINISHED` | `bool HAS_INSTANT_FILL_VEHICLE_POPULATION_FINISHED()` | bool |
| `HAS_PRELOAD_MODS_FINISHED` | `bool HAS_PRELOAD_MODS_FINISHED(int vehicle)` | bool |
| `HAS_VEHICLE_ASSET_LOADED` | `bool HAS_VEHICLE_ASSET_LOADED(int vehicleAsset)` | bool |
| `HAS_VEHICLE_PETROLTANK_SET_ON_FIRE_BY_ENTITY` | `bool HAS_VEHICLE_PETROLTANK_SET_ON_FIRE_BY_ENTITY(object p0, object p1)` | bool |
| `HAS_VEHICLE_PHONE_EXPLOSIVE_DEVICE` | `bool HAS_VEHICLE_PHONE_EXPLOSIVE_DEVICE()` | bool |
| `HAS_VEHICLE_RECORDING_BEEN_LOADED` | `bool HAS_VEHICLE_RECORDING_BEEN_LOADED(int recording, string script)` | bool |
| `HAVE_VEHICLE_MODS_STREAMED_IN` | `bool HAVE_VEHICLE_MODS_STREAMED_IN(int vehicle)` | bool |
| `HAVE_VEHICLE_REAR_DOORS_BEEN_BLOWN_OPEN_BY_STICKYBOMB` | `bool HAVE_VEHICLE_REAR_DOORS_BEEN_BLOWN_OPEN_BY_STICKYBOMB(int vehicle)` | bool |
| `HIDE_TOMBSTONE` | `void HIDE_TOMBSTONE(int vehicle, bool toggle)` | void |
| `INSTANTLY_FILL_VEHICLE_POPULATION` | `void INSTANTLY_FILL_VEHICLE_POPULATION()` | void |
| `IS_ANY_ENTITY_ATTACHED_TO_HANDLER_FRAME` | `bool IS_ANY_ENTITY_ATTACHED_TO_HANDLER_FRAME(int vehicle)` | bool |
| `IS_ANY_PED_RAPPELLING_FROM_HELI` | `bool IS_ANY_PED_RAPPELLING_FROM_HELI(int vehicle)` | bool |
| `IS_ANY_VEHICLE_NEAR_POINT` | `bool IS_ANY_VEHICLE_NEAR_POINT(float x, float y, float z, float radius)` | bool |
| `IS_BIG_VEHICLE` | `bool IS_BIG_VEHICLE(int vehicle)` | bool |
| `IS_BOAT_ANCHORED` | `bool IS_BOAT_ANCHORED(int vehicle)` | bool |
| `IS_COP_VEHICLE_IN_AREA_3D` | `bool IS_COP_VEHICLE_IN_AREA_3D(float x1, float x2, float y1, float y2, float z1, float z2)` | bool |
| `IS_ENTITY_ATTACHED_TO_HANDLER_FRAME` | `bool IS_ENTITY_ATTACHED_TO_HANDLER_FRAME(int vehicle, int entity)` | bool |
| `IS_ENTRY_POINT_FOR_SEAT_CLEAR` | `bool IS_ENTRY_POINT_FOR_SEAT_CLEAR(int ped, int vehicle, int seatIndex, bool side, bool onEnter)` | bool |
| `IS_EXTRA_BROKEN_OFF` | `bool IS_EXTRA_BROKEN_OFF(int vehicle, int extraId)` | bool |
| `IS_HANDLER_FRAME_LINED_UP_WITH_CONTAINER` | `bool IS_HANDLER_FRAME_LINED_UP_WITH_CONTAINER(int vehicle, int entity)` | bool |
| `IS_HELI_LANDING_AREA_BLOCKED` | `bool IS_HELI_LANDING_AREA_BLOCKED(int vehicle)` | bool |
| `IS_HELI_PART_BROKEN` | `bool IS_HELI_PART_BROKEN(int vehicle, bool p1, bool p2, bool p3)` | bool |
| `IS_MISSION_TRAIN` | `bool IS_MISSION_TRAIN(int train)` | bool |
| `IS_NITROUS_ACTIVE` | `bool IS_NITROUS_ACTIVE(int vehicle)` | bool |
| `IS_PED_EXCLUSIVE_DRIVER_OF_VEHICLE` | `bool IS_PED_EXCLUSIVE_DRIVER_OF_VEHICLE(int ped, int vehicle, ref int outIndex)` | bool |
| `IS_PLANE_LANDING_GEAR_INTACT` | `bool IS_PLANE_LANDING_GEAR_INTACT(int plane)` | bool |
| `IS_PLAYBACK_GOING_ON_FOR_VEHICLE` | `bool IS_PLAYBACK_GOING_ON_FOR_VEHICLE(int vehicle)` | bool |
| `IS_PLAYBACK_USING_AI_GOING_ON_FOR_VEHICLE` | `bool IS_PLAYBACK_USING_AI_GOING_ON_FOR_VEHICLE(int vehicle)` | bool |
| `IS_ROCKET_BOOST_ACTIVE` | `bool IS_ROCKET_BOOST_ACTIVE(int vehicle)` | bool |
| `IS_SEAT_WARP_ONLY` | `bool IS_SEAT_WARP_ONLY(int vehicle, int seatIndex)` | bool |
| `IS_TAXI_LIGHT_ON` | `bool IS_TAXI_LIGHT_ON(int vehicle)` | bool |
| `IS_THIS_MODEL_AN_AMPHIBIOUS_CAR` | `bool IS_THIS_MODEL_AN_AMPHIBIOUS_CAR(uint model)` | bool |
| `IS_THIS_MODEL_AN_AMPHIBIOUS_QUADBIKE` | `bool IS_THIS_MODEL_AN_AMPHIBIOUS_QUADBIKE(uint model)` | bool |
| `IS_THIS_MODEL_A_BICYCLE` | `bool IS_THIS_MODEL_A_BICYCLE(uint model)` | bool |
| `IS_THIS_MODEL_A_BIKE` | `bool IS_THIS_MODEL_A_BIKE(uint model)` | bool |
| `IS_THIS_MODEL_A_BOAT` | `bool IS_THIS_MODEL_A_BOAT(uint model)` | bool |
| `IS_THIS_MODEL_A_CAR` | `bool IS_THIS_MODEL_A_CAR(uint model)` | bool |
| `IS_THIS_MODEL_A_HELI` | `bool IS_THIS_MODEL_A_HELI(uint model)` | bool |
| `IS_THIS_MODEL_A_JETSKI` | `bool IS_THIS_MODEL_A_JETSKI(uint model)` | bool |
| `IS_THIS_MODEL_A_PLANE` | `bool IS_THIS_MODEL_A_PLANE(uint model)` | bool |
| `IS_THIS_MODEL_A_QUADBIKE` | `bool IS_THIS_MODEL_A_QUADBIKE(uint model)` | bool |
| `IS_THIS_MODEL_A_TRAIN` | `bool IS_THIS_MODEL_A_TRAIN(uint model)` | bool |
| `IS_TOGGLE_MOD_ON` | `bool IS_TOGGLE_MOD_ON(int vehicle, int modType)` | bool |
| `IS_TURRET_SEAT` | `bool IS_TURRET_SEAT(int vehicle, int seatIndex)` | bool |
| `IS_VEHICLE_ALARM_ACTIVATED` | `bool IS_VEHICLE_ALARM_ACTIVATED(int vehicle)` | bool |
| `IS_VEHICLE_ATTACHED_TO_CARGOBOB` | `bool IS_VEHICLE_ATTACHED_TO_CARGOBOB(int cargobob, int vehicleAttached)` | bool |
| `IS_VEHICLE_ATTACHED_TO_TOW_TRUCK` | `bool IS_VEHICLE_ATTACHED_TO_TOW_TRUCK(int towTruck, int vehicle)` | bool |
| `IS_VEHICLE_ATTACHED_TO_TRAILER` | `bool IS_VEHICLE_ATTACHED_TO_TRAILER(int vehicle)` | bool |
| `IS_VEHICLE_A_CONVERTIBLE` | `bool IS_VEHICLE_A_CONVERTIBLE(int vehicle, bool p1)` | bool |
| `IS_VEHICLE_BEING_BROUGHT_TO_HALT` | `bool IS_VEHICLE_BEING_BROUGHT_TO_HALT(int vehicle)` | bool |
| `IS_VEHICLE_BUMPER_BOUNCING` | `bool IS_VEHICLE_BUMPER_BOUNCING(int vehicle, bool frontBumper)` | bool |
| `IS_VEHICLE_BUMPER_BROKEN_OFF` | `bool IS_VEHICLE_BUMPER_BROKEN_OFF(int vehicle, bool frontBumper)` | bool |
| `IS_VEHICLE_DOOR_DAMAGED` | `bool IS_VEHICLE_DOOR_DAMAGED(int veh, int doorID)` | bool |
| `IS_VEHICLE_DOOR_FULLY_OPEN` | `bool IS_VEHICLE_DOOR_FULLY_OPEN(int vehicle, int doorId)` | bool |
| `IS_VEHICLE_DRIVEABLE` | `bool IS_VEHICLE_DRIVEABLE(int vehicle, bool isOnFireCheck)` | bool |
| `IS_VEHICLE_EXTRA_TURNED_ON` | `bool IS_VEHICLE_EXTRA_TURNED_ON(int vehicle, int extraId)` | bool |
| `IS_VEHICLE_HIGH_DETAIL` | `bool IS_VEHICLE_HIGH_DETAIL(int vehicle)` | bool |
| `IS_VEHICLE_IN_BURNOUT` | `bool IS_VEHICLE_IN_BURNOUT(int vehicle)` | bool |
| `IS_VEHICLE_IN_GARAGE_AREA` | `bool IS_VEHICLE_IN_GARAGE_AREA(string garageName, int vehicle)` | bool |
| `IS_VEHICLE_IN_SUBMARINE_MODE` | `bool IS_VEHICLE_IN_SUBMARINE_MODE(int vehicle)` | bool |
| `IS_VEHICLE_MODEL` | `bool IS_VEHICLE_MODEL(int vehicle, uint model)` | bool |
| `IS_VEHICLE_MOD_GEN9_EXCLUSIVE` | `bool IS_VEHICLE_MOD_GEN9_EXCLUSIVE(int vehicle, int modType, int modIndex)` | bool |
| `IS_VEHICLE_ON_ALL_WHEELS` | `bool IS_VEHICLE_ON_ALL_WHEELS(int vehicle)` | bool |
| `IS_VEHICLE_PARACHUTE_DEPLOYED` | `bool IS_VEHICLE_PARACHUTE_DEPLOYED(int vehicle)` | bool |
| `IS_VEHICLE_PRODUCING_SLIP_STREAM` | `bool IS_VEHICLE_PRODUCING_SLIP_STREAM(int vehicle)` | bool |
| `IS_VEHICLE_SEARCHLIGHT_ON` | `bool IS_VEHICLE_SEARCHLIGHT_ON(int vehicle)` | bool |
| `IS_VEHICLE_SEAT_FREE` | `bool IS_VEHICLE_SEAT_FREE(int vehicle, int seatIndex, bool isTaskRunning)` | bool |
| `IS_VEHICLE_SIREN_AUDIO_ON` | `bool IS_VEHICLE_SIREN_AUDIO_ON(int vehicle)` | bool |
| `IS_VEHICLE_SIREN_ON` | `bool IS_VEHICLE_SIREN_ON(int vehicle)` | bool |
| `IS_VEHICLE_SPRAYABLE` | `bool IS_VEHICLE_SPRAYABLE(int vehicle)` | bool |
| `IS_VEHICLE_STOLEN` | `bool IS_VEHICLE_STOLEN(int vehicle)` | bool |
| `IS_VEHICLE_STOPPED` | `bool IS_VEHICLE_STOPPED(int vehicle)` | bool |
| `IS_VEHICLE_STOPPED_AT_TRAFFIC_LIGHTS` | `bool IS_VEHICLE_STOPPED_AT_TRAFFIC_LIGHTS(int vehicle)` | bool |
| `IS_VEHICLE_STUCK_ON_ROOF` | `bool IS_VEHICLE_STUCK_ON_ROOF(int vehicle)` | bool |
| `IS_VEHICLE_STUCK_TIMER_UP` | `bool IS_VEHICLE_STUCK_TIMER_UP(int vehicle, int p1, int ms)` | bool |
| `IS_VEHICLE_TYRE_BURST` | `bool IS_VEHICLE_TYRE_BURST(int vehicle, int wheelID, bool completely)` | bool |
| `IS_VEHICLE_VISIBLE` | `bool IS_VEHICLE_VISIBLE(int vehicle)` | bool |
| `IS_VEHICLE_WEAPON_DISABLED` | `bool IS_VEHICLE_WEAPON_DISABLED(uint weaponHash, int vehicle, int owner)` | bool |
| `IS_VEHICLE_WINDOW_INTACT` | `bool IS_VEHICLE_WINDOW_INTACT(int vehicle, int windowIndex)` | bool |
| `LOCK_DOORS_WHEN_NO_LONGER_NEEDED` | `void LOCK_DOORS_WHEN_NO_LONGER_NEEDED(int vehicle)` | void |
| `LOWER_CONVERTIBLE_ROOF` | `void LOWER_CONVERTIBLE_ROOF(int vehicle, bool instantlyLower)` | void |
| `LOWER_FORKLIFT_FORKS` | `void LOWER_FORKLIFT_FORKS(int forklift)` | void |
| `MODIFY_VEHICLE_TOP_SPEED` | `void MODIFY_VEHICLE_TOP_SPEED(int vehicle, float value)` | void |
| `NETWORK_CAP_EMPTY_CROWDING_VEHICLES_REMOVAL` | `void NETWORK_CAP_EMPTY_CROWDING_VEHICLES_REMOVAL(int p0)` | void |
| `NETWORK_ENABLE_EMPTY_CROWDING_VEHICLES_REMOVAL` | `void NETWORK_ENABLE_EMPTY_CROWDING_VEHICLES_REMOVAL(bool toggle)` | void |
| `NETWORK_USE_HIGH_PRECISION_TRAIN_BLENDING` | `void NETWORK_USE_HIGH_PRECISION_TRAIN_BLENDING(int vehicle, bool toggle)` | void |
| `OPEN_BOMB_BAY_DOORS` | `void OPEN_BOMB_BAY_DOORS(int vehicle)` | void |
| `OVERRIDE_PLANE_DAMAGE_THREHSOLD` | `void OVERRIDE_PLANE_DAMAGE_THREHSOLD(int vehicle, float health)` | void |
| `PAUSE_PLAYBACK_RECORDED_VEHICLE` | `void PAUSE_PLAYBACK_RECORDED_VEHICLE(int vehicle)` | void |
| `POP_OFF_VEHICLE_ROOF_WITH_IMPULSE` | `void POP_OFF_VEHICLE_ROOF_WITH_IMPULSE(int vehicle, float x, float y, float z)` | void |
| `POP_OUT_VEHICLE_WINDSCREEN` | `void POP_OUT_VEHICLE_WINDSCREEN(int vehicle)` | void |
| `PRELOAD_VEHICLE_MOD` | `void PRELOAD_VEHICLE_MOD(int vehicle, int modType, int modIndex)` | void |
| `RAISE_CONVERTIBLE_ROOF` | `void RAISE_CONVERTIBLE_ROOF(int vehicle, bool instantlyRaise)` | void |
| `RELEASE_PRELOAD_MODS` | `void RELEASE_PRELOAD_MODS(int vehicle)` | void |
| `REMOVE_PICK_UP_ROPE_FOR_CARGOBOB` | `void REMOVE_PICK_UP_ROPE_FOR_CARGOBOB(int cargobob)` | void |
| `REMOVE_ROAD_NODE_SPEED_ZONE` | `bool REMOVE_ROAD_NODE_SPEED_ZONE(int speedzone)` | bool |
| `REMOVE_VEHICLES_FROM_GENERATORS_IN_AREA` | `void REMOVE_VEHICLES_FROM_GENERATORS_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, object p6)` | void |
| `REMOVE_VEHICLE_ASSET` | `void REMOVE_VEHICLE_ASSET(int vehicleAsset)` | void |
| `REMOVE_VEHICLE_COMBAT_AVOIDANCE_AREA` | `void REMOVE_VEHICLE_COMBAT_AVOIDANCE_AREA(int p0)` | void |
| `REMOVE_VEHICLE_HIGH_DETAIL_MODEL` | `void REMOVE_VEHICLE_HIGH_DETAIL_MODEL(int vehicle)` | void |
| `REMOVE_VEHICLE_MOD` | `void REMOVE_VEHICLE_MOD(int vehicle, int modType)` | void |
| `REMOVE_VEHICLE_RECORDING` | `void REMOVE_VEHICLE_RECORDING(int recording, string script)` | void |
| `REMOVE_VEHICLE_STUCK_CHECK` | `void REMOVE_VEHICLE_STUCK_CHECK(int vehicle)` | void |
| `REMOVE_VEHICLE_UPSIDEDOWN_CHECK` | `void REMOVE_VEHICLE_UPSIDEDOWN_CHECK(int vehicle)` | void |
| `REMOVE_VEHICLE_WINDOW` | `void REMOVE_VEHICLE_WINDOW(int vehicle, int windowIndex)` | void |
| `REQUEST_VEHICLE_ASSET` | `void REQUEST_VEHICLE_ASSET(uint vehicleHash, int vehicleAsset)` | void |
| `REQUEST_VEHICLE_DIAL` | `void REQUEST_VEHICLE_DIAL(int vehicle)` | void |
| `REQUEST_VEHICLE_HIGH_DETAIL_MODEL` | `void REQUEST_VEHICLE_HIGH_DETAIL_MODEL(int vehicle)` | void |
| `REQUEST_VEHICLE_RECORDING` | `void REQUEST_VEHICLE_RECORDING(int recording, string script)` | void |
| `RESET_FORMATION_LEADER` | `void RESET_FORMATION_LEADER()` | void |
| `RESET_VEHICLE_STUCK_TIMER` | `void RESET_VEHICLE_STUCK_TIMER(int vehicle, int nullAttributes)` | void |
| `RESET_VEHICLE_WHEELS` | `void RESET_VEHICLE_WHEELS(int vehicle, bool toggle)` | void |
| `ROLL_DOWN_WINDOW` | `void ROLL_DOWN_WINDOW(int vehicle, int windowIndex)` | void |
| `ROLL_DOWN_WINDOWS` | `void ROLL_DOWN_WINDOWS(int vehicle)` | void |
| `ROLL_UP_WINDOW` | `void ROLL_UP_WINDOW(int vehicle, int windowIndex)` | void |
| `SET_ADDITIONAL_ROTATION_FOR_RECORDED_VEHICLE_PLAYBACK` | `void SET_ADDITIONAL_ROTATION_FOR_RECORDED_VEHICLE_PLAYBACK(int vehicle, float x, float y, float z, object p4)` | void |
| `SET_AIRCRAFT_IGNORE_HIGHTMAP_OPTIMISATION` | `void SET_AIRCRAFT_IGNORE_HIGHTMAP_OPTIMISATION(int vehicle, int p1)` | void |
| `SET_AIRCRAFT_PILOT_SKILL_NOISE_SCALAR` | `void SET_AIRCRAFT_PILOT_SKILL_NOISE_SCALAR(int vehicle, float p1)` | void |
| `SET_ALLOW_RAMMING_SOOP_OR_RAMP` | `void SET_ALLOW_RAMMING_SOOP_OR_RAMP(object p0, object p1)` | void |
| `SET_ALLOW_VEHICLE_EXPLODES_ON_CONTACT` | `void SET_ALLOW_VEHICLE_EXPLODES_ON_CONTACT(int vehicle, bool toggle)` | void |
| `SET_ALL_LOW_PRIORITY_VEHICLE_GENERATORS_ACTIVE` | `void SET_ALL_LOW_PRIORITY_VEHICLE_GENERATORS_ACTIVE(bool active)` | void |
| `SET_ALL_VEHICLE_GENERATORS_ACTIVE` | `void SET_ALL_VEHICLE_GENERATORS_ACTIVE()` | void |
| `SET_ALL_VEHICLE_GENERATORS_ACTIVE_IN_AREA` | `void SET_ALL_VEHICLE_GENERATORS_ACTIVE_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool toggle, bool p7)` | void |
| `SET_AMBIENT_VEHICLE_NEON_ENABLED` | `void SET_AMBIENT_VEHICLE_NEON_ENABLED(bool p0)` | void |
| `SET_AMBIENT_VEHICLE_RANGE_MULTIPLIER_THIS_FRAME` | `void SET_AMBIENT_VEHICLE_RANGE_MULTIPLIER_THIS_FRAME(float value)` | void |
| `SET_ARRIVE_DISTANCE_OVERRIDE_FOR_VEHICLE_PERSUIT_ATTACK` | `void SET_ARRIVE_DISTANCE_OVERRIDE_FOR_VEHICLE_PERSUIT_ATTACK(int vehicle, float p1)` | void |
| `SET_BIKE_EASY_TO_LAND` | `void SET_BIKE_EASY_TO_LAND(int vehicle, bool toggle)` | void |
| `SET_BIKE_ON_STAND` | `void SET_BIKE_ON_STAND(int vehicle, float x, float y)` | void |
| `SET_BOAT_ANCHOR` | `void SET_BOAT_ANCHOR(int vehicle, bool toggle)` | void |
| `SET_BOAT_DISABLE_AVOIDANCE` | `void SET_BOAT_DISABLE_AVOIDANCE(int vehicle, bool p1)` | void |
| `SET_BOAT_IGNORE_LAND_PROBES` | `void SET_BOAT_IGNORE_LAND_PROBES(object p0, object p1)` | void |
| `SET_BOAT_LOW_LOD_ANCHOR_DISTANCE` | `void SET_BOAT_LOW_LOD_ANCHOR_DISTANCE(int vehicle, float value)` | void |
| `SET_BOAT_REMAINS_ANCHORED_WHILE_PLAYER_IS_DRIVER` | `void SET_BOAT_REMAINS_ANCHORED_WHILE_PLAYER_IS_DRIVER(int vehicle, bool toggle)` | void |
| `SET_BOAT_SINKS_WHEN_WRECKED` | `void SET_BOAT_SINKS_WHEN_WRECKED(int vehicle, bool toggle)` | void |
| `SET_BOAT_WRECKED` | `void SET_BOAT_WRECKED(int vehicle)` | void |
| `SET_CAN_ADJUST_GROUND_CLEARANCE` | `void SET_CAN_ADJUST_GROUND_CLEARANCE(int vehicle, bool p1)` | void |
| `SET_CAN_RESPRAY_VEHICLE` | `void SET_CAN_RESPRAY_VEHICLE(int vehicle, bool state)` | void |
| `SET_CAN_USE_HYDRAULICS` | `void SET_CAN_USE_HYDRAULICS(int vehicle, bool toggle)` | void |
| `SET_CARGOBOB_EXCLUDE_FROM_PICKUP_ENTITY` | `void SET_CARGOBOB_EXCLUDE_FROM_PICKUP_ENTITY(object p0, object p1)` | void |
| `SET_CARGOBOB_EXTA_PICKUP_RANGE` | `void SET_CARGOBOB_EXTA_PICKUP_RANGE(object p0, object p1)` | void |
| `SET_CARGOBOB_FORCE_DONT_DETACH_VEHICLE` | `void SET_CARGOBOB_FORCE_DONT_DETACH_VEHICLE(int cargobob, bool toggle)` | void |
| `SET_CARGOBOB_PICKUP_MAGNET_ACTIVE` | `void SET_CARGOBOB_PICKUP_MAGNET_ACTIVE(int cargobob, bool isActive)` | void |
| `SET_CARGOBOB_PICKUP_MAGNET_ENSURE_PICKUP_ENTITY_UPRIGHT` | `void SET_CARGOBOB_PICKUP_MAGNET_ENSURE_PICKUP_ENTITY_UPRIGHT(int vehicle, bool p1)` | void |
| `SET_CARGOBOB_PICKUP_MAGNET_FALLOFF` | `void SET_CARGOBOB_PICKUP_MAGNET_FALLOFF(int cargobob, float p1)` | void |
| `SET_CARGOBOB_PICKUP_MAGNET_PULL_ROPE_LENGTH` | `void SET_CARGOBOB_PICKUP_MAGNET_PULL_ROPE_LENGTH(int vehicle, float p1)` | void |
| `SET_CARGOBOB_PICKUP_MAGNET_PULL_STRENGTH` | `void SET_CARGOBOB_PICKUP_MAGNET_PULL_STRENGTH(int cargobob, float p1)` | void |
| `SET_CARGOBOB_PICKUP_MAGNET_REDUCED_FALLOFF` | `void SET_CARGOBOB_PICKUP_MAGNET_REDUCED_FALLOFF(int cargobob, float p1)` | void |
| `SET_CARGOBOB_PICKUP_MAGNET_REDUCED_STRENGTH` | `void SET_CARGOBOB_PICKUP_MAGNET_REDUCED_STRENGTH(int cargobob, float p1)` | void |
| `SET_CARGOBOB_PICKUP_MAGNET_SET_AMBIENT_MODE` | `void SET_CARGOBOB_PICKUP_MAGNET_SET_AMBIENT_MODE(int vehicle, bool p1, bool p2)` | void |
| `SET_CARGOBOB_PICKUP_MAGNET_SET_TARGETED_MODE` | `void SET_CARGOBOB_PICKUP_MAGNET_SET_TARGETED_MODE(int vehicle, int cargobob)` | void |
| `SET_CARGOBOB_PICKUP_MAGNET_STRENGTH` | `void SET_CARGOBOB_PICKUP_MAGNET_STRENGTH(int cargobob, float strength)` | void |
| `SET_CARGOBOB_PICKUP_ROPE_DAMPING_MULTIPLIER` | `void SET_CARGOBOB_PICKUP_ROPE_DAMPING_MULTIPLIER(object p0, object p1)` | void |
| `SET_CARGOBOB_PICKUP_ROPE_TYPE` | `void SET_CARGOBOB_PICKUP_ROPE_TYPE(object p0, object p1)` | void |
| `SET_CARJACK_MISSION_REMOVAL_PARAMETERS` | `void SET_CARJACK_MISSION_REMOVAL_PARAMETERS(object p0, object p1)` | void |
| `SET_CAR_BOOT_OPEN` | `void SET_CAR_BOOT_OPEN(int vehicle)` | void |
| `SET_CAR_HIGH_SPEED_BUMP_SEVERITY_MULTIPLIER` | `void SET_CAR_HIGH_SPEED_BUMP_SEVERITY_MULTIPLIER(float multiplier)` | void |
| `SET_CHECK_FOR_ENOUGH_ROOM_FOR_PED` | `void SET_CHECK_FOR_ENOUGH_ROOM_FOR_PED(int vehicle, bool p1)` | void |
| `SET_CLEAR_FREEZE_WAITING_ON_COLLISION_ONCE_PLAYER_ENTERS` | `void SET_CLEAR_FREEZE_WAITING_ON_COLLISION_ONCE_PLAYER_ENTERS(int vehicle, bool toggle)` | void |
| `SET_CONVERTIBLE_ROOF` | `void SET_CONVERTIBLE_ROOF(int vehicle, bool p1)` | void |
| `SET_CONVERTIBLE_ROOF_LATCH_STATE` | `void SET_CONVERTIBLE_ROOF_LATCH_STATE(int vehicle, bool state)` | void |
| `SET_DEPLOY_FOLDING_WINGS` | `void SET_DEPLOY_FOLDING_WINGS(int vehicle, bool deploy, bool p2)` | void |
| `SET_DIP_STRAIGHT_DOWN_WHEN_CRASHING_PLANE` | `void SET_DIP_STRAIGHT_DOWN_WHEN_CRASHING_PLANE(int vehicle, bool toggle)` | void |
| `SET_DISABLE_AUTOMATIC_CRASH_TASK` | `void SET_DISABLE_AUTOMATIC_CRASH_TASK(int vehicle, bool toggle)` | void |
| `SET_DISABLE_BMX_EXTRA_TRICK_FORCES` | `void SET_DISABLE_BMX_EXTRA_TRICK_FORCES(object p0)` | void |
| `SET_DISABLE_DAMAGE_WITH_PICKED_UP_ENTITY` | `bool SET_DISABLE_DAMAGE_WITH_PICKED_UP_ENTITY(object p0, object p1)` | bool |
| `SET_DISABLE_EXPLODE_FROM_BODY_DAMAGE_ON_COLLISION` | `void SET_DISABLE_EXPLODE_FROM_BODY_DAMAGE_ON_COLLISION(int vehicle, bool disable)` | void |
| `SET_DISABLE_HELI_EXPLODE_FROM_BODY_DAMAGE` | `void SET_DISABLE_HELI_EXPLODE_FROM_BODY_DAMAGE(int vehicle, bool disable)` | void |
| `SET_DISABLE_HOVER_MODE_FLIGHT` | `void SET_DISABLE_HOVER_MODE_FLIGHT(int vehicle, bool toggle)` | void |
| `SET_DISABLE_MAP_COLLISION` | `void SET_DISABLE_MAP_COLLISION(int vehicle)` | void |
| `SET_DISABLE_PED_STAND_ON_TOP` | `void SET_DISABLE_PED_STAND_ON_TOP(int vehicle, bool toggle)` | void |
| `SET_DISABLE_PRETEND_OCCUPANTS` | `void SET_DISABLE_PRETEND_OCCUPANTS(int vehicle, bool toggle)` | void |
| `SET_DISABLE_RANDOM_TRAINS_THIS_FRAME` | `void SET_DISABLE_RANDOM_TRAINS_THIS_FRAME(bool toggle)` | void |
| `SET_DISABLE_RETRACTING_WEAPON_BLADES` | `void SET_DISABLE_RETRACTING_WEAPON_BLADES(bool toggle)` | void |
| `SET_DISABLE_SUPERDUMMY` | `void SET_DISABLE_SUPERDUMMY(int vehicle, bool p1)` | void |
| `SET_DISABLE_TURRET_MOVEMENT` | `void SET_DISABLE_TURRET_MOVEMENT(int vehicle, int turretId)` | void |
| `SET_DISABLE_VEHICLE_ENGINE_FIRES` | `void SET_DISABLE_VEHICLE_ENGINE_FIRES(int vehicle, bool toggle)` | void |
| `SET_DISABLE_VEHICLE_EXPLOSIONS_DAMAGE` | `void SET_DISABLE_VEHICLE_EXPLOSIONS_DAMAGE(bool toggle)` | void |
| `SET_DISABLE_VEHICLE_PETROL_TANK_DAMAGE` | `void SET_DISABLE_VEHICLE_PETROL_TANK_DAMAGE(int vehicle, bool toggle)` | void |
| `SET_DISABLE_VEHICLE_PETROL_TANK_FIRES` | `void SET_DISABLE_VEHICLE_PETROL_TANK_FIRES(int vehicle, bool toggle)` | void |
| `SET_DISABLE_VERTICAL_FLIGHT_MODE_TRANSITION` | `void SET_DISABLE_VERTICAL_FLIGHT_MODE_TRANSITION(int vehicle, bool toggle)` | void |
| `SET_DISABLE_WANTED_CONES_RESPONSE` | `void SET_DISABLE_WANTED_CONES_RESPONSE(int vehicle, bool toggle)` | void |
| `SET_DISABLE_WEAPON_BLADE_FORCES` | `void SET_DISABLE_WEAPON_BLADE_FORCES(bool toggle)` | void |
| `SET_DISTANT_CARS_ENABLED` | `void SET_DISTANT_CARS_ENABLED(bool toggle)` | void |
| `SET_DONT_ALLOW_PLAYER_TO_ENTER_VEHICLE_IF_LOCKED_FOR_PLAYER` | `void SET_DONT_ALLOW_PLAYER_TO_ENTER_VEHICLE_IF_LOCKED_FOR_PLAYER(int vehicle, bool p1)` | void |
| `SET_DONT_PROCESS_VEHICLE_GLASS` | `void SET_DONT_PROCESS_VEHICLE_GLASS(int vehicle, bool toggle)` | void |
| `SET_DOOR_ALLOWED_TO_BE_BROKEN_OFF` | `void SET_DOOR_ALLOWED_TO_BE_BROKEN_OFF(int vehicle, int doorId, bool isBreakable)` | void |
| `SET_DRIFT_TYRES` | `void SET_DRIFT_TYRES(int vehicle, bool toggle)` | void |
| `SET_ENABLE_VEHICLE_SLIPSTREAMING` | `void SET_ENABLE_VEHICLE_SLIPSTREAMING(bool toggle)` | void |
| `SET_FAR_DRAW_VEHICLES` | `void SET_FAR_DRAW_VEHICLES(bool toggle)` | void |
| `SET_FLEEING_VEHICLES_USE_SWITCHED_OFF_NODES` | `void SET_FLEEING_VEHICLES_USE_SWITCHED_OFF_NODES(object p0)` | void |
| `SET_FORCE_FIX_LINK_MATRICES` | `void SET_FORCE_FIX_LINK_MATRICES(int vehicle)` | void |
| `SET_FORCE_HD_VEHICLE` | `void SET_FORCE_HD_VEHICLE(int vehicle, bool toggle)` | void |
| `SET_FORCE_LOW_LOD_ANCHOR_MODE` | `void SET_FORCE_LOW_LOD_ANCHOR_MODE(int vehicle, bool p1)` | void |
| `SET_FORCE_VEHICLE_ENGINE_DAMAGE_BY_BULLET` | `void SET_FORCE_VEHICLE_ENGINE_DAMAGE_BY_BULLET(object p0, bool p1)` | void |
| `SET_FORKLIFT_FORK_HEIGHT` | `void SET_FORKLIFT_FORK_HEIGHT(int vehicle, float height)` | void |
| `SET_FORMATION_LEADER` | `void SET_FORMATION_LEADER(int vehicle, float x, float y, float z, float p4)` | void |
| `SET_GARBAGE_TRUCKS` | `void SET_GARBAGE_TRUCKS(bool toggle)` | void |
| `SET_GLIDER_ACTIVE` | `void SET_GLIDER_ACTIVE(int vehicle, bool state)` | void |
| `SET_GLOBAL_POSITION_OFFSET_FOR_RECORDED_VEHICLE_PLAYBACK` | `void SET_GLOBAL_POSITION_OFFSET_FOR_RECORDED_VEHICLE_PLAYBACK(int vehicle, float x, float y, float z)` | void |
| `SET_GOON_BOSS_VEHICLE` | `void SET_GOON_BOSS_VEHICLE(int vehicle, bool toggle)` | void |
| `SET_GROUND_EFFECT_REDUCES_DRAG` | `void SET_GROUND_EFFECT_REDUCES_DRAG(bool toggle)` | void |
| `SET_HELI_BLADES_FULL_SPEED` | `void SET_HELI_BLADES_FULL_SPEED(int vehicle)` | void |
| `SET_HELI_BLADES_SPEED` | `void SET_HELI_BLADES_SPEED(int vehicle, float speed)` | void |
| `SET_HELI_CAN_PICKUP_ENTITY_THAT_HAS_PICK_UP_DISABLED` | `void SET_HELI_CAN_PICKUP_ENTITY_THAT_HAS_PICK_UP_DISABLED(int vehicle, bool toggle)` | void |
| `SET_HELI_COMBAT_OFFSET` | `void SET_HELI_COMBAT_OFFSET(int vehicle, float x, float y, float z)` | void |
| `SET_HELI_CONTROL_LAGGING_RATE_SCALAR` | `void SET_HELI_CONTROL_LAGGING_RATE_SCALAR(int helicopter, float multiplier)` | void |
| `SET_HELI_MAIN_ROTOR_HEALTH` | `void SET_HELI_MAIN_ROTOR_HEALTH(int vehicle, float health)` | void |
| `SET_HELI_RESIST_TO_EXPLOSION` | `void SET_HELI_RESIST_TO_EXPLOSION(int vehicle, bool toggle)` | void |
| `SET_HELI_TAIL_BOOM_CAN_BREAK_OFF` | `bool SET_HELI_TAIL_BOOM_CAN_BREAK_OFF(int vehicle, bool toggle)` | bool |
| `SET_HELI_TAIL_ROTOR_HEALTH` | `void SET_HELI_TAIL_ROTOR_HEALTH(int vehicle, float health)` | void |
| `SET_HELI_TURBULENCE_SCALAR` | `void SET_HELI_TURBULENCE_SCALAR(int vehicle, float p1)` | void |
| `SET_HOVER_MODE_WING_RATIO` | `void SET_HOVER_MODE_WING_RATIO(int vehicle, float ratio)` | void |
| `SET_HYDRAULICS_CONTROL` | `void SET_HYDRAULICS_CONTROL(int vehicle, bool toggle)` | void |
| `SET_HYDRAULIC_SUSPENSION_RAISE_FACTOR` | `void SET_HYDRAULIC_SUSPENSION_RAISE_FACTOR(int vehicle, int wheelId, float value)` | void |
| `SET_HYDRAULIC_VEHICLE_STATE` | `void SET_HYDRAULIC_VEHICLE_STATE(int vehicle, int state)` | void |
| `SET_HYDRAULIC_WHEEL_STATE` | `void SET_HYDRAULIC_WHEEL_STATE(int vehicle, int wheelId, int state, float value, object p4)` | void |
| `SET_IGNORE_PLANES_SMALL_PITCH_CHANGE` | `void SET_IGNORE_PLANES_SMALL_PITCH_CHANGE(object p0, object p1)` | void |
| `SET_INCREASE_WHEEL_CRUSH_DAMAGE` | `void SET_INCREASE_WHEEL_CRUSH_DAMAGE(int vehicle, bool toggle)` | void |
| `SET_INVERT_VEHICLE_CONTROLS` | `void SET_INVERT_VEHICLE_CONTROLS(int vehicle, bool state)` | void |
| `SET_LAST_DRIVEN_VEHICLE` | `void SET_LAST_DRIVEN_VEHICLE(int vehicle)` | void |
| `SET_LIGHTS_CUTOFF_DISTANCE_TWEAK` | `void SET_LIGHTS_CUTOFF_DISTANCE_TWEAK(float distance)` | void |
| `SET_MISSION_TRAIN_AS_NO_LONGER_NEEDED` | `void SET_MISSION_TRAIN_AS_NO_LONGER_NEEDED(Vehicle* train, bool p1)` | void |
| `SET_MISSION_TRAIN_COORDS` | `void SET_MISSION_TRAIN_COORDS(int train, float x, float y, float z)` | void |
| `SET_NITROUS_IS_ACTIVE` | `void SET_NITROUS_IS_ACTIVE(int vehicle, bool toggle)` | void |
| `SET_NUMBER_OF_PARKED_VEHICLES` | `void SET_NUMBER_OF_PARKED_VEHICLES(int value)` | void |
| `SET_OPEN_REAR_DOORS_ON_EXPLOSION` | `void SET_OPEN_REAR_DOORS_ON_EXPLOSION(int vehicle, bool toggle)` | void |
| `SET_OVERRIDE_NITROUS_LEVEL` | `void SET_OVERRIDE_NITROUS_LEVEL(int vehicle, bool toggle, float level, float power, float rechargeTime, bool disableSound)` | void |
| `SET_OVERRIDE_VEHICLE_DOOR_TORQUE` | `void SET_OVERRIDE_VEHICLE_DOOR_TORQUE(object p0, object p1, object p2)` | void |
| `SET_PARKED_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME` | `void SET_PARKED_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier)` | void |
| `SET_PEDS_CAN_FALL_OFF_THIS_VEHICLE_FROM_LARGE_FALL_DAMAGE` | `void SET_PEDS_CAN_FALL_OFF_THIS_VEHICLE_FROM_LARGE_FALL_DAMAGE(int vehicle, bool toggle, float p2)` | void |
| `SET_PICKUP_ROPE_LENGTH_FOR_CARGOBOB` | `void SET_PICKUP_ROPE_LENGTH_FOR_CARGOBOB(int cargobob, float length1, float length2, bool p3)` | void |
| `SET_PICKUP_ROPE_LENGTH_WITHOUT_CREATING_ROPE_FOR_CARGOBOB` | `void SET_PICKUP_ROPE_LENGTH_WITHOUT_CREATING_ROPE_FOR_CARGOBOB(object p0, object p1, object p2)` | void |
| `SET_PLANE_CONTROL_SECTIONS_SHOULD_BREAK_OFF_FROM_EXPLOSIONS` | `void SET_PLANE_CONTROL_SECTIONS_SHOULD_BREAK_OFF_FROM_EXPLOSIONS(int vehicle, bool toggle)` | void |
| `SET_PLANE_ENGINE_HEALTH` | `void SET_PLANE_ENGINE_HEALTH(int vehicle, float health)` | void |
| `SET_PLANE_PROPELLER_HEALTH` | `bool SET_PLANE_PROPELLER_HEALTH(int plane, float health)` | bool |
| `SET_PLANE_RESIST_TO_EXPLOSION` | `void SET_PLANE_RESIST_TO_EXPLOSION(int vehicle, bool toggle)` | void |
| `SET_PLANE_SECTION_DAMAGE_SCALE` | `void SET_PLANE_SECTION_DAMAGE_SCALE(int vehicle, object p1, object p2)` | void |
| `SET_PLANE_TURBULENCE_MULTIPLIER` | `void SET_PLANE_TURBULENCE_MULTIPLIER(int vehicle, float multiplier)` | void |
| `SET_PLAYBACK_SPEED` | `void SET_PLAYBACK_SPEED(int vehicle, float speed)` | void |
| `SET_PLAYBACK_TO_USE_AI` | `void SET_PLAYBACK_TO_USE_AI(int vehicle, int drivingStyle)` | void |
| `SET_PLAYBACK_TO_USE_AI_TRY_TO_REVERT_BACK_LATER` | `void SET_PLAYBACK_TO_USE_AI_TRY_TO_REVERT_BACK_LATER(int vehicle, int time, int drivingStyle, bool p3)` | void |
| `SET_PLAYERS_LAST_VEHICLE` | `void SET_PLAYERS_LAST_VEHICLE(int vehicle)` | void |
| `SET_POLICE_FOCUS_WILL_TRACK_VEHICLE` | `void SET_POLICE_FOCUS_WILL_TRACK_VEHICLE(int vehicle, bool toggle)` | void |
| `SET_POSITION_OFFSET_FOR_RECORDED_VEHICLE_PLAYBACK` | `void SET_POSITION_OFFSET_FOR_RECORDED_VEHICLE_PLAYBACK(int vehicle, float x, float y, float z)` | void |
| `SET_RANDOM_BOATS` | `void SET_RANDOM_BOATS(bool toggle)` | void |
| `SET_RANDOM_BOATS_MP` | `void SET_RANDOM_BOATS_MP(bool toggle)` | void |
| `SET_RANDOM_TRAINS` | `void SET_RANDOM_TRAINS(bool toggle)` | void |
| `SET_RANDOM_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME` | `void SET_RANDOM_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier)` | void |
| `SET_REDUCED_SUSPENSION_FORCE` | `void SET_REDUCED_SUSPENSION_FORCE(int vehicle, bool enable)` | void |
| `SET_RENDER_TRAIN_AS_DERAILED` | `void SET_RENDER_TRAIN_AS_DERAILED(int train, bool toggle)` | void |
| `SET_ROCKET_BOOST_ACTIVE` | `void SET_ROCKET_BOOST_ACTIVE(int vehicle, bool active)` | void |
| `SET_ROCKET_BOOST_FILL` | `void SET_ROCKET_BOOST_FILL(int vehicle, float percentage)` | void |
| `SET_SCRIPT_RAMP_IMPULSE_SCALE` | `void SET_SCRIPT_RAMP_IMPULSE_SCALE(int vehicle, float impulseScale)` | void |
| `SET_SCRIPT_ROCKET_BOOST_RECHARGE_TIME` | `void SET_SCRIPT_ROCKET_BOOST_RECHARGE_TIME(int vehicle, float seconds)` | void |
| `SET_SCRIPT_VEHICLE_GENERATOR` | `void SET_SCRIPT_VEHICLE_GENERATOR(int vehicleGenerator, bool enabled)` | void |
| `SET_SHORT_SLOWDOWN_FOR_LANDING` | `void SET_SHORT_SLOWDOWN_FOR_LANDING(int vehicle)` | void |
| `SET_SHOULD_LERP_FROM_AI_TO_FULL_RECORDING` | `void SET_SHOULD_LERP_FROM_AI_TO_FULL_RECORDING(int vehicle, bool p1)` | void |
| `SET_SHOULD_RESET_TURRET_IN_SCRIPTED_CAMERAS` | `void SET_SHOULD_RESET_TURRET_IN_SCRIPTED_CAMERAS(int vehicle, bool shouldReset)` | void |
| `SET_SLOW_DOWN_EFFECT_DISABLED` | `void SET_SLOW_DOWN_EFFECT_DISABLED(bool disabled)` | void |
| `SET_SPECIAL_FLIGHT_MODE_ALLOWED` | `void SET_SPECIAL_FLIGHT_MODE_ALLOWED(int vehicle, bool toggle)` | void |
| `SET_SPECIAL_FLIGHT_MODE_RATIO` | `void SET_SPECIAL_FLIGHT_MODE_RATIO(int vehicle, float ratio)` | void |
| `SET_SPECIAL_FLIGHT_MODE_TARGET_RATIO` | `void SET_SPECIAL_FLIGHT_MODE_TARGET_RATIO(int vehicle, float targetRatio)` | void |
| `SET_SPEED_BOOST_EFFECT_DISABLED` | `void SET_SPEED_BOOST_EFFECT_DISABLED(bool disabled)` | void |
| `SET_SUBMARINE_CRUSH_DEPTHS` | `void SET_SUBMARINE_CRUSH_DEPTHS(int vehicle, bool p1, float depth1, float depth2, float depth3)` | void |
| `SET_TASK_VEHICLE_GOTO_PLANE_MIN_HEIGHT_ABOVE_TERRAIN` | `void SET_TASK_VEHICLE_GOTO_PLANE_MIN_HEIGHT_ABOVE_TERRAIN(int plane, int height)` | void |
| `SET_TAXI_LIGHTS` | `void SET_TAXI_LIGHTS(int vehicle, bool state)` | void |
| `SET_TRAILER_ATTACHMENT_ENABLED` | `void SET_TRAILER_ATTACHMENT_ENABLED(object p0, object p1)` | void |
| `SET_TRAILER_INVERSE_MASS_SCALE` | `void SET_TRAILER_INVERSE_MASS_SCALE(int vehicle, float p1)` | void |
| `SET_TRAILER_LEGS_LOWERED` | `void SET_TRAILER_LEGS_LOWERED(int vehicle)` | void |
| `SET_TRAILER_LEGS_RAISED` | `void SET_TRAILER_LEGS_RAISED(int vehicle)` | void |
| `SET_TRAIN_CRUISE_SPEED` | `void SET_TRAIN_CRUISE_SPEED(int train, float speed)` | void |
| `SET_TRAIN_SPEED` | `void SET_TRAIN_SPEED(int train, float speed)` | void |
| `SET_TRAIN_TRACK_SPAWN_FREQUENCY` | `void SET_TRAIN_TRACK_SPAWN_FREQUENCY(int trackIndex, int frequency)` | void |
| `SET_TRANSFORM_RATE_FOR_ANIMATION` | `void SET_TRANSFORM_RATE_FOR_ANIMATION(int vehicle, float transformRate)` | void |
| `SET_TRANSFORM_TO_SUBMARINE_USES_ALTERNATE_INPUT` | `void SET_TRANSFORM_TO_SUBMARINE_USES_ALTERNATE_INPUT(int vehicle, bool toggle)` | void |
| `SET_TURRET_HIDDEN` | `void SET_TURRET_HIDDEN(int vehicle, int index, bool toggle)` | void |
| `SET_TYRE_HEALTH` | `void SET_TYRE_HEALTH(int vehicle, int wheelIndex, float health)` | void |
| `SET_TYRE_MAXIMUM_GRIP_DIFFERENCE_DUE_TO_WEAR_RATE` | `void SET_TYRE_MAXIMUM_GRIP_DIFFERENCE_DUE_TO_WEAR_RATE(int vehicle, int wheelIndex, float multiplier)` | void |
| `SET_TYRE_WEAR_RATE` | `void SET_TYRE_WEAR_RATE(int vehicle, int wheelIndex, float multiplier)` | void |
| `SET_TYRE_WEAR_RATE_SCALE` | `void SET_TYRE_WEAR_RATE_SCALE(int vehicle, int wheelIndex, float multiplier)` | void |
| `SET_USE_DESIRED_Z_CRUISE_SPEED_FOR_LANDING` | `void SET_USE_DESIRED_Z_CRUISE_SPEED_FOR_LANDING(int vehicle, bool toggle)` | void |
| `SET_USE_DOUBLE_CLICK_FOR_CAR_JUMP` | `void SET_USE_DOUBLE_CLICK_FOR_CAR_JUMP(bool toggle)` | void |
| `SET_USE_HIGHER_CAR_JUMP` | `void SET_USE_HIGHER_CAR_JUMP(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_ACTIVE_DURING_PLAYBACK` | `void SET_VEHICLE_ACTIVE_DURING_PLAYBACK(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_ACTIVE_FOR_PED_NAVIGATION` | `void SET_VEHICLE_ACTIVE_FOR_PED_NAVIGATION(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_ACT_AS_IF_HAS_SIREN_ON` | `void SET_VEHICLE_ACT_AS_IF_HAS_SIREN_ON(int vehicle, bool p1)` | void |
| `SET_VEHICLE_ACT_AS_IF_HIGH_SPEED_FOR_FRAG_SMASHING` | `void SET_VEHICLE_ACT_AS_IF_HIGH_SPEED_FOR_FRAG_SMASHING(int vehicle, bool p1)` | void |
| `SET_VEHICLE_AI_CAN_USE_EXCLUSIVE_SEATS` | `void SET_VEHICLE_AI_CAN_USE_EXCLUSIVE_SEATS(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_ALARM` | `void SET_VEHICLE_ALARM(int vehicle, bool state)` | void |
| `SET_VEHICLE_ALLOW_HOMING_MISSLE_LOCKON` | `void SET_VEHICLE_ALLOW_HOMING_MISSLE_LOCKON(int vehicle, bool toggle, bool p2)` | void |
| `SET_VEHICLE_ALLOW_HOMING_MISSLE_LOCKON_SYNCED` | `void SET_VEHICLE_ALLOW_HOMING_MISSLE_LOCKON_SYNCED(int vehicle, bool canBeLockedOn, bool p2)` | void |
| `SET_VEHICLE_ALLOW_NO_PASSENGERS_LOCKON` | `void SET_VEHICLE_ALLOW_NO_PASSENGERS_LOCKON(int veh, bool toggle)` | void |
| `SET_VEHICLE_AUTOMATICALLY_ATTACHES` | `int SET_VEHICLE_AUTOMATICALLY_ATTACHES(int vehicle, bool p1, object p2)` | int |
| `SET_VEHICLE_AVOID_PLAYER_VEHICLE_RIOT_VAN_MISSION` | `void SET_VEHICLE_AVOID_PLAYER_VEHICLE_RIOT_VAN_MISSION(object p0)` | void |
| `SET_VEHICLE_BLIP_THROTTLE_RANDOMLY` | `void SET_VEHICLE_BLIP_THROTTLE_RANDOMLY(int vehicle, bool p1)` | void |
| `SET_VEHICLE_BOBBLEHEAD_VELOCITY` | `void SET_VEHICLE_BOBBLEHEAD_VELOCITY(float x, float y, float p2)` | void |
| `SET_VEHICLE_BODY_HEALTH` | `void SET_VEHICLE_BODY_HEALTH(int vehicle, float value)` | void |
| `SET_VEHICLE_BOMB_AMMO` | `void SET_VEHICLE_BOMB_AMMO(int vehicle, int bombCount)` | void |
| `SET_VEHICLE_BRAKE` | `void SET_VEHICLE_BRAKE(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_BRAKE_LIGHTS` | `void SET_VEHICLE_BRAKE_LIGHTS(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_BROKEN_PARTS_DONT_AFFECT_AI_HANDLING` | `void SET_VEHICLE_BROKEN_PARTS_DONT_AFFECT_AI_HANDLING(int vehicle, bool p1)` | void |
| `SET_VEHICLE_BULLDOZER_ARM_POSITION` | `void SET_VEHICLE_BULLDOZER_ARM_POSITION(int vehicle, float position, bool p2)` | void |
| `SET_VEHICLE_BURNOUT` | `void SET_VEHICLE_BURNOUT(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_CAN_BE_TARGETTED` | `void SET_VEHICLE_CAN_BE_TARGETTED(int vehicle, bool state)` | void |
| `SET_VEHICLE_CAN_BE_USED_BY_FLEEING_PEDS` | `void SET_VEHICLE_CAN_BE_USED_BY_FLEEING_PEDS(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_CAN_BE_VISIBLY_DAMAGED` | `void SET_VEHICLE_CAN_BE_VISIBLY_DAMAGED(int vehicle, bool state)` | void |
| `SET_VEHICLE_CAN_BREAK` | `void SET_VEHICLE_CAN_BREAK(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_CAN_DEFORM_WHEELS` | `void SET_VEHICLE_CAN_DEFORM_WHEELS(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_CAN_EJECT_PASSENGERS_IF_LOCKED` | `void SET_VEHICLE_CAN_EJECT_PASSENGERS_IF_LOCKED(object p0, object p1)` | void |
| `SET_VEHICLE_CAN_ENGINE_MISSFIRE` | `void SET_VEHICLE_CAN_ENGINE_MISSFIRE(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_CAN_LEAK_OIL` | `void SET_VEHICLE_CAN_LEAK_OIL(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_CAN_LEAK_PETROL` | `void SET_VEHICLE_CAN_LEAK_PETROL(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_CAN_SAVE_IN_GARAGE` | `void SET_VEHICLE_CAN_SAVE_IN_GARAGE(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_CAUSES_SWERVING` | `void SET_VEHICLE_CAUSES_SWERVING(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_CEILING_HEIGHT` | `void SET_VEHICLE_CEILING_HEIGHT(int vehicle, float height)` | void |
| `SET_VEHICLE_CHEAT_POWER_INCREASE` | `void SET_VEHICLE_CHEAT_POWER_INCREASE(int vehicle, float value)` | void |
| `SET_VEHICLE_COLOURS` | `void SET_VEHICLE_COLOURS(int vehicle, int colorPrimary, int colorSecondary)` | void |
| `SET_VEHICLE_COLOUR_COMBINATION` | `void SET_VEHICLE_COLOUR_COMBINATION(int vehicle, int colorCombination)` | void |
| `SET_VEHICLE_COMBAT_MODE` | `void SET_VEHICLE_COMBAT_MODE(bool toggle)` | void |
| `SET_VEHICLE_COUNTERMEASURE_AMMO` | `void SET_VEHICLE_COUNTERMEASURE_AMMO(int vehicle, int counterMeasureCount)` | void |
| `SET_VEHICLE_CUSTOM_PATH_NODE_STREAMING_RADIUS` | `void SET_VEHICLE_CUSTOM_PATH_NODE_STREAMING_RADIUS(int vehicle, float p1)` | void |
| `SET_VEHICLE_CUSTOM_PRIMARY_COLOUR` | `void SET_VEHICLE_CUSTOM_PRIMARY_COLOUR(int vehicle, int r, int g, int b)` | void |
| `SET_VEHICLE_CUSTOM_SECONDARY_COLOUR` | `void SET_VEHICLE_CUSTOM_SECONDARY_COLOUR(int vehicle, int r, int g, int b)` | void |
| `SET_VEHICLE_DAMAGE` | `void SET_VEHICLE_DAMAGE(int vehicle, float xOffset, float yOffset, float zOffset, float damage, float radius, bool focusOnModel)` | void |
| `SET_VEHICLE_DAMAGE_SCALE` | `bool SET_VEHICLE_DAMAGE_SCALE(int vehicle, float p1)` | bool |
| `SET_VEHICLE_DAMAGE_SCALES` | `void SET_VEHICLE_DAMAGE_SCALES(int vehicle, object p1, object p2, object p3, object p4)` | void |
| `SET_VEHICLE_DEFORMATION_FIXED` | `void SET_VEHICLE_DEFORMATION_FIXED(int vehicle)` | void |
| `SET_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME` | `void SET_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier)` | void |
| `SET_VEHICLE_DETONATION_MODE` | `void SET_VEHICLE_DETONATION_MODE(bool toggle)` | void |
| `SET_VEHICLE_DIRT_LEVEL` | `void SET_VEHICLE_DIRT_LEVEL(int vehicle, float dirtLevel)` | void |
| `SET_VEHICLE_DISABLE_COLLISION_UPON_CREATION` | `void SET_VEHICLE_DISABLE_COLLISION_UPON_CREATION(int vehicle, bool disable)` | void |
| `SET_VEHICLE_DISABLE_HEIGHT_MAP_AVOIDANCE` | `void SET_VEHICLE_DISABLE_HEIGHT_MAP_AVOIDANCE(int vehicle, bool p1)` | void |
| `SET_VEHICLE_DISABLE_TOWING` | `void SET_VEHICLE_DISABLE_TOWING(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_DONT_TERMINATE_TASK_WHEN_ACHIEVED` | `void SET_VEHICLE_DONT_TERMINATE_TASK_WHEN_ACHIEVED(int vehicle)` | void |
| `SET_VEHICLE_DOORS_LOCKED` | `void SET_VEHICLE_DOORS_LOCKED(int vehicle, int doorLockStatus)` | void |
| `SET_VEHICLE_DOORS_LOCKED_FOR_ALL_PLAYERS` | `void SET_VEHICLE_DOORS_LOCKED_FOR_ALL_PLAYERS(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_DOORS_LOCKED_FOR_ALL_TEAMS` | `void SET_VEHICLE_DOORS_LOCKED_FOR_ALL_TEAMS(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_DOORS_LOCKED_FOR_NON_SCRIPT_PLAYERS` | `void SET_VEHICLE_DOORS_LOCKED_FOR_NON_SCRIPT_PLAYERS(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_DOORS_LOCKED_FOR_PLAYER` | `void SET_VEHICLE_DOORS_LOCKED_FOR_PLAYER(int vehicle, int player, bool toggle)` | void |
| `SET_VEHICLE_DOORS_LOCKED_FOR_TEAM` | `void SET_VEHICLE_DOORS_LOCKED_FOR_TEAM(int vehicle, int team, bool toggle)` | void |
| `SET_VEHICLE_DOORS_SHUT` | `void SET_VEHICLE_DOORS_SHUT(int vehicle, bool closeInstantly)` | void |
| `SET_VEHICLE_DOOR_AUTO_LOCK` | `void SET_VEHICLE_DOOR_AUTO_LOCK(int vehicle, int doorId, bool toggle)` | void |
| `SET_VEHICLE_DOOR_BROKEN` | `void SET_VEHICLE_DOOR_BROKEN(int vehicle, int doorId, bool deleteDoor)` | void |
| `SET_VEHICLE_DOOR_CONTROL` | `void SET_VEHICLE_DOOR_CONTROL(int vehicle, int doorId, int speed, float angle)` | void |
| `SET_VEHICLE_DOOR_LATCHED` | `void SET_VEHICLE_DOOR_LATCHED(int vehicle, int doorId, bool p2, bool p3, bool p4)` | void |
| `SET_VEHICLE_DOOR_OPEN` | `void SET_VEHICLE_DOOR_OPEN(int vehicle, int doorId, bool loose, bool openInstantly)` | void |
| `SET_VEHICLE_DOOR_SHUT` | `void SET_VEHICLE_DOOR_SHUT(int vehicle, int doorId, bool closeInstantly)` | void |
| `SET_VEHICLE_DROPS_MONEY_WHEN_BLOWN_UP` | `void SET_VEHICLE_DROPS_MONEY_WHEN_BLOWN_UP(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_ENGINE_CAN_DEGRADE` | `void SET_VEHICLE_ENGINE_CAN_DEGRADE(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_ENGINE_HEALTH` | `void SET_VEHICLE_ENGINE_HEALTH(int vehicle, float health)` | void |
| `SET_VEHICLE_ENGINE_ON` | `void SET_VEHICLE_ENGINE_ON(int vehicle, bool value, bool instantly, bool disableAutoStart)` | void |
| `SET_VEHICLE_ENVEFF_SCALE` | `void SET_VEHICLE_ENVEFF_SCALE(int vehicle, float fade)` | void |
| `SET_VEHICLE_EXCLUSIVE_DRIVER` | `void SET_VEHICLE_EXCLUSIVE_DRIVER(int vehicle, int ped, int index)` | void |
| `SET_VEHICLE_EXPLODES_ON_EXPLOSION_DAMAGE_AT_ZERO_BODY_HEALTH` | `void SET_VEHICLE_EXPLODES_ON_EXPLOSION_DAMAGE_AT_ZERO_BODY_HEALTH(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_EXPLODES_ON_HIGH_EXPLOSION_DAMAGE` | `void SET_VEHICLE_EXPLODES_ON_HIGH_EXPLOSION_DAMAGE(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_EXTENDED_REMOVAL_RANGE` | `void SET_VEHICLE_EXTENDED_REMOVAL_RANGE(int vehicle, int range)` | void |
| `SET_VEHICLE_EXTRA` | `void SET_VEHICLE_EXTRA(int vehicle, int extraId, bool disable)` | void |
| `SET_VEHICLE_EXTRA_COLOURS` | `void SET_VEHICLE_EXTRA_COLOURS(int vehicle, int pearlescentColor, int wheelColor)` | void |
| `SET_VEHICLE_EXTRA_COLOUR_5` | `void SET_VEHICLE_EXTRA_COLOUR_5(int vehicle, int color)` | void |
| `SET_VEHICLE_EXTRA_COLOUR_6` | `void SET_VEHICLE_EXTRA_COLOUR_6(int vehicle, int color)` | void |
| `SET_VEHICLE_FIXED` | `void SET_VEHICLE_FIXED(int vehicle)` | void |
| `SET_VEHICLE_FLIGHT_NOZZLE_POSITION` | `void SET_VEHICLE_FLIGHT_NOZZLE_POSITION(int vehicle, float angleRatio)` | void |
| `SET_VEHICLE_FLIGHT_NOZZLE_POSITION_IMMEDIATE` | `void SET_VEHICLE_FLIGHT_NOZZLE_POSITION_IMMEDIATE(int vehicle, float angle)` | void |
| `SET_VEHICLE_FORCE_AFTERBURNER` | `void SET_VEHICLE_FORCE_AFTERBURNER(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_FORCE_INTERIORLIGHT` | `void SET_VEHICLE_FORCE_INTERIORLIGHT(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_FORWARD_SPEED` | `void SET_VEHICLE_FORWARD_SPEED(int vehicle, float speed)` | void |
| `SET_VEHICLE_FORWARD_SPEED_XY` | `void SET_VEHICLE_FORWARD_SPEED_XY(int vehicle, float speed)` | void |
| `SET_VEHICLE_FRICTION_OVERRIDE` | `void SET_VEHICLE_FRICTION_OVERRIDE(int vehicle, float friction)` | void |
| `SET_VEHICLE_FULLBEAM` | `void SET_VEHICLE_FULLBEAM(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_GENERATES_ENGINE_SHOCKING_EVENTS` | `void SET_VEHICLE_GENERATES_ENGINE_SHOCKING_EVENTS(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_GENERATOR_AREA_OF_INTEREST` | `void SET_VEHICLE_GENERATOR_AREA_OF_INTEREST(float x, float y, float z, float radius)` | void |
| `SET_VEHICLE_GRAVITY` | `void SET_VEHICLE_GRAVITY(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_HANDBRAKE` | `void SET_VEHICLE_HANDBRAKE(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_HANDLING_OVERRIDE` | `void SET_VEHICLE_HANDLING_OVERRIDE(int vehicle, uint hash)` | void |
| `SET_VEHICLE_HAS_BEEN_DRIVEN_FLAG` | `void SET_VEHICLE_HAS_BEEN_DRIVEN_FLAG(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_HAS_BEEN_OWNED_BY_PLAYER` | `void SET_VEHICLE_HAS_BEEN_OWNED_BY_PLAYER(int vehicle, bool owned)` | void |
| `SET_VEHICLE_HAS_MUTED_SIRENS` | `void SET_VEHICLE_HAS_MUTED_SIRENS(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_HAS_STRONG_AXLES` | `void SET_VEHICLE_HAS_STRONG_AXLES(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_HAS_UNBREAKABLE_LIGHTS` | `void SET_VEHICLE_HAS_UNBREAKABLE_LIGHTS(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_HEADLIGHT_SHADOWS` | `void SET_VEHICLE_HEADLIGHT_SHADOWS(int vehicle, int p1)` | void |
| `SET_VEHICLE_HOMING_LOCKEDONTO_STATE` | `void SET_VEHICLE_HOMING_LOCKEDONTO_STATE(object p0, object p1)` | void |
| `SET_VEHICLE_IMPATIENCE_TIMER` | `void SET_VEHICLE_IMPATIENCE_TIMER(int vehicle, object p1)` | void |
| `SET_VEHICLE_INACTIVE_DURING_PLAYBACK` | `void SET_VEHICLE_INACTIVE_DURING_PLAYBACK(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_INDICATOR_LIGHTS` | `void SET_VEHICLE_INDICATOR_LIGHTS(int vehicle, int turnSignal, bool toggle)` | void |
| `SET_VEHICLE_INDIVIDUAL_DOORS_LOCKED` | `void SET_VEHICLE_INDIVIDUAL_DOORS_LOCKED(int vehicle, int doorId, int doorLockStatus)` | void |
| `SET_VEHICLE_INFLUENCES_WANTED_LEVEL` | `void SET_VEHICLE_INFLUENCES_WANTED_LEVEL(object p0, bool p1)` | void |
| `SET_VEHICLE_INTERIORLIGHT` | `void SET_VEHICLE_INTERIORLIGHT(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_IN_CAR_MOD_SHOP` | `void SET_VEHICLE_IN_CAR_MOD_SHOP(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_IS_CONSIDERED_BY_PLAYER` | `void SET_VEHICLE_IS_CONSIDERED_BY_PLAYER(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_IS_RACING` | `void SET_VEHICLE_IS_RACING(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_IS_STOLEN` | `void SET_VEHICLE_IS_STOLEN(int vehicle, bool isStolen)` | void |
| `SET_VEHICLE_IS_WANTED` | `void SET_VEHICLE_IS_WANTED(int vehicle, bool state)` | void |
| `SET_VEHICLE_KEEP_ENGINE_ON_WHEN_ABANDONED` | `void SET_VEHICLE_KEEP_ENGINE_ON_WHEN_ABANDONED(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_KERS_ALLOWED` | `void SET_VEHICLE_KERS_ALLOWED(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_LIGHTS` | `void SET_VEHICLE_LIGHTS(int vehicle, int state)` | void |
| `SET_VEHICLE_LIGHT_MULTIPLIER` | `void SET_VEHICLE_LIGHT_MULTIPLIER(int vehicle, float multiplier)` | void |
| `SET_VEHICLE_LIMIT_SPEED_WHEN_PLAYER_INACTIVE` | `void SET_VEHICLE_LIMIT_SPEED_WHEN_PLAYER_INACTIVE(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_LIVERY` | `void SET_VEHICLE_LIVERY(int vehicle, int livery)` | void |
| `SET_VEHICLE_LIVERY2` | `void SET_VEHICLE_LIVERY2(int vehicle, int livery)` | void |
| `SET_VEHICLE_LOD_MULTIPLIER` | `void SET_VEHICLE_LOD_MULTIPLIER(int vehicle, float multiplier)` | void |
| `SET_VEHICLE_MAX_SPEED` | `void SET_VEHICLE_MAX_SPEED(int vehicle, float speed)` | void |
| `SET_VEHICLE_MAY_BE_USED_BY_GOTO_POINT_ANY_MEANS` | `void SET_VEHICLE_MAY_BE_USED_BY_GOTO_POINT_ANY_MEANS(int vehicle, bool p1)` | void |
| `SET_VEHICLE_MOD` | `void SET_VEHICLE_MOD(int vehicle, int modType, int modIndex, bool customTires)` | void |
| `SET_VEHICLE_MODEL_IS_SUPPRESSED` | `void SET_VEHICLE_MODEL_IS_SUPPRESSED(uint model, bool suppressed)` | void |
| `SET_VEHICLE_MOD_COLOR_1` | `void SET_VEHICLE_MOD_COLOR_1(int vehicle, int paintType, int color, int pearlescentColor)` | void |
| `SET_VEHICLE_MOD_COLOR_2` | `void SET_VEHICLE_MOD_COLOR_2(int vehicle, int paintType, int color)` | void |
| `SET_VEHICLE_MOD_KIT` | `void SET_VEHICLE_MOD_KIT(int vehicle, int modKit)` | void |
| `SET_VEHICLE_NAME_DEBUG` | `void SET_VEHICLE_NAME_DEBUG(int vehicle, string name)` | void |
| `SET_VEHICLE_NEEDS_TO_BE_HOTWIRED` | `void SET_VEHICLE_NEEDS_TO_BE_HOTWIRED(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_NEON_COLOUR` | `void SET_VEHICLE_NEON_COLOUR(int vehicle, int r, int g, int b)` | void |
| `SET_VEHICLE_NEON_ENABLED` | `void SET_VEHICLE_NEON_ENABLED(int vehicle, int index, bool toggle)` | void |
| `SET_VEHICLE_NEON_INDEX_COLOUR` | `void SET_VEHICLE_NEON_INDEX_COLOUR(int vehicle, int index)` | void |
| `SET_VEHICLE_NOT_STEALABLE_AMBIENTLY` | `void SET_VEHICLE_NOT_STEALABLE_AMBIENTLY(int vehicle, bool p1)` | void |
| `SET_VEHICLE_NO_EXPLOSION_DAMAGE_FROM_DRIVER` | `void SET_VEHICLE_NO_EXPLOSION_DAMAGE_FROM_DRIVER(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_NUMBER_PLATE_TEXT` | `void SET_VEHICLE_NUMBER_PLATE_TEXT(int vehicle, string plateText)` | void |
| `SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX` | `void SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX(int vehicle, int plateIndex)` | void |
| `SET_VEHICLE_OCCUPANTS_TAKE_EXPLOSIVE_DAMAGE` | `void SET_VEHICLE_OCCUPANTS_TAKE_EXPLOSIVE_DAMAGE(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_ON_GROUND_PROPERLY` | `bool SET_VEHICLE_ON_GROUND_PROPERLY(int vehicle, float p1)` | bool |
| `SET_VEHICLE_OUT_OF_CONTROL` | `void SET_VEHICLE_OUT_OF_CONTROL(int vehicle, bool killDriver, bool explodeOnImpact)` | void |
| `SET_VEHICLE_PETROL_TANK_HEALTH` | `void SET_VEHICLE_PETROL_TANK_HEALTH(int vehicle, float health)` | void |
| `SET_VEHICLE_PROVIDES_COVER` | `void SET_VEHICLE_PROVIDES_COVER(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_READY_FOR_CLEANUP` | `void SET_VEHICLE_READY_FOR_CLEANUP(object p0)` | void |
| `SET_VEHICLE_REDUCE_GRIP` | `void SET_VEHICLE_REDUCE_GRIP(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_REDUCE_GRIP_LEVEL` | `void SET_VEHICLE_REDUCE_GRIP_LEVEL(int vehicle, int val)` | void |
| `SET_VEHICLE_REMOVE_AGGRESSIVE_CARJACK_MISSION` | `void SET_VEHICLE_REMOVE_AGGRESSIVE_CARJACK_MISSION(object p0)` | void |
| `SET_VEHICLE_RESPECTS_LOCKS_WHEN_HAS_DRIVER` | `void SET_VEHICLE_RESPECTS_LOCKS_WHEN_HAS_DRIVER(int vehicle, bool p1)` | void |
| `SET_VEHICLE_RUDDER_BROKEN` | `void SET_VEHICLE_RUDDER_BROKEN(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_SEARCHLIGHT` | `void SET_VEHICLE_SEARCHLIGHT(int heli, bool toggle, bool canBeUsedByAI)` | void |
| `SET_VEHICLE_SHOOT_AT_TARGET` | `void SET_VEHICLE_SHOOT_AT_TARGET(int driver, int entity, float xTarget, float yTarget, float zTarget)` | void |
| `SET_VEHICLE_SHUNT_ON_STICK` | `void SET_VEHICLE_SHUNT_ON_STICK(bool toggle)` | void |
| `SET_VEHICLE_SIREN` | `void SET_VEHICLE_SIREN(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_SLIPSTREAMING_SHOULD_TIME_OUT` | `void SET_VEHICLE_SLIPSTREAMING_SHOULD_TIME_OUT(bool toggle)` | void |
| `SET_VEHICLE_STAYS_FROZEN_WHEN_CLEANED_UP` | `void SET_VEHICLE_STAYS_FROZEN_WHEN_CLEANED_UP(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_STEERING_BIAS_SCALAR` | `void SET_VEHICLE_STEERING_BIAS_SCALAR(object p0, float p1)` | void |
| `SET_VEHICLE_STEER_BIAS` | `void SET_VEHICLE_STEER_BIAS(int vehicle, float value)` | void |
| `SET_VEHICLE_STEER_FOR_BUILDINGS` | `void SET_VEHICLE_STEER_FOR_BUILDINGS(int vehicle, object p1)` | void |
| `SET_VEHICLE_STOP_INSTANTLY_WHEN_PLAYER_INACTIVE` | `void SET_VEHICLE_STOP_INSTANTLY_WHEN_PLAYER_INACTIVE(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_STRONG` | `void SET_VEHICLE_STRONG(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_TAIL_BROKEN` | `void SET_VEHICLE_TAIL_BROKEN(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_TAIL_LIGHTS` | `void SET_VEHICLE_TAIL_LIGHTS(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_TANK_STATIONARY` | `void SET_VEHICLE_TANK_STATIONARY(int vehicle, bool p1)` | void |
| `SET_VEHICLE_TANK_TURRET_POSITION` | `void SET_VEHICLE_TANK_TURRET_POSITION(int vehicle, float position, bool p2)` | void |
| `SET_VEHICLE_TIMED_EXPLOSION` | `void SET_VEHICLE_TIMED_EXPLOSION(int vehicle, int ped, bool toggle)` | void |
| `SET_VEHICLE_TOW_TRUCK_ARM_POSITION` | `void SET_VEHICLE_TOW_TRUCK_ARM_POSITION(int vehicle, float position)` | void |
| `SET_VEHICLE_TURRET_SPEED_THIS_FRAME` | `void SET_VEHICLE_TURRET_SPEED_THIS_FRAME(int vehicle, float speed)` | void |
| `SET_VEHICLE_TURRET_TARGET` | `void SET_VEHICLE_TURRET_TARGET(int vehicle, bool p1, float x, float y, float z, bool p5)` | void |
| `SET_VEHICLE_TYRES_CAN_BURST` | `void SET_VEHICLE_TYRES_CAN_BURST(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_TYRE_BURST` | `void SET_VEHICLE_TYRE_BURST(int vehicle, int index, bool onRim, float p3)` | void |
| `SET_VEHICLE_TYRE_FIXED` | `void SET_VEHICLE_TYRE_FIXED(int vehicle, int tyreIndex)` | void |
| `SET_VEHICLE_TYRE_SMOKE_COLOR` | `void SET_VEHICLE_TYRE_SMOKE_COLOR(int vehicle, int r, int g, int b)` | void |
| `SET_VEHICLE_UNDRIVEABLE` | `void SET_VEHICLE_UNDRIVEABLE(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_USED_FOR_PILOT_SCHOOL` | `void SET_VEHICLE_USED_FOR_PILOT_SCHOOL(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_USES_LARGE_REAR_RAMP` | `void SET_VEHICLE_USES_LARGE_REAR_RAMP(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_USES_MP_PLAYER_DAMAGE_MULTIPLIER` | `void SET_VEHICLE_USES_MP_PLAYER_DAMAGE_MULTIPLIER(object p0, object p1)` | void |
| `SET_VEHICLE_USE_ALTERNATE_HANDLING` | `void SET_VEHICLE_USE_ALTERNATE_HANDLING(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_USE_BOOST_BUTTON_FOR_WHEEL_RETRACT` | `void SET_VEHICLE_USE_BOOST_BUTTON_FOR_WHEEL_RETRACT(bool toggle)` | void |
| `SET_VEHICLE_USE_CUTSCENE_WHEEL_COMPRESSION` | `bool SET_VEHICLE_USE_CUTSCENE_WHEEL_COMPRESSION(int p0, bool p1, bool p2, bool p3)` | bool |
| `SET_VEHICLE_USE_MORE_RESTRICTIVE_SPAWN_CHECKS` | `void SET_VEHICLE_USE_MORE_RESTRICTIVE_SPAWN_CHECKS(int vehicle, bool p1)` | void |
| `SET_VEHICLE_USE_PLAYER_LIGHT_SETTINGS` | `void SET_VEHICLE_USE_PLAYER_LIGHT_SETTINGS(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_WEAPON_CAN_TARGET_OBJECTS` | `void SET_VEHICLE_WEAPON_CAN_TARGET_OBJECTS(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_WEAPON_DAMAGE_SCALE` | `bool SET_VEHICLE_WEAPON_DAMAGE_SCALE(int vehicle, float multiplier)` | bool |
| `SET_VEHICLE_WEAPON_RESTRICTED_AMMO` | `void SET_VEHICLE_WEAPON_RESTRICTED_AMMO(int vehicle, int weaponIndex, int capacity)` | void |
| `SET_VEHICLE_WHEELS_CAN_BREAK` | `void SET_VEHICLE_WHEELS_CAN_BREAK(int vehicle, bool enabled)` | void |
| `SET_VEHICLE_WHEELS_CAN_BREAK_OFF_WHEN_BLOW_UP` | `void SET_VEHICLE_WHEELS_CAN_BREAK_OFF_WHEN_BLOW_UP(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_WHEEL_TYPE` | `void SET_VEHICLE_WHEEL_TYPE(int vehicle, int WheelType)` | void |
| `SET_VEHICLE_WILL_FORCE_OTHER_VEHICLES_TO_STOP` | `void SET_VEHICLE_WILL_FORCE_OTHER_VEHICLES_TO_STOP(int vehicle, bool toggle)` | void |
| `SET_VEHICLE_WILL_TELL_OTHERS_TO_HURRY` | `void SET_VEHICLE_WILL_TELL_OTHERS_TO_HURRY(int vehicle, bool p1)` | void |
| `SET_VEHICLE_WINDOW_TINT` | `void SET_VEHICLE_WINDOW_TINT(int vehicle, int tint)` | void |
| `SET_VEHICLE_XENON_LIGHT_COLOR_INDEX` | `void SET_VEHICLE_XENON_LIGHT_COLOR_INDEX(int vehicle, int colorIndex)` | void |
| `SET_WHEELIE_ENABLED` | `void SET_WHEELIE_ENABLED(int vehicle, bool enabled)` | void |
| `SET_WHEELS_EXTENDED_INSTANTLY` | `void SET_WHEELS_EXTENDED_INSTANTLY(int vehicle)` | void |
| `SET_WHEELS_RETRACTED_INSTANTLY` | `void SET_WHEELS_RETRACTED_INSTANTLY(int vehicle)` | void |
| `SKIP_TIME_IN_PLAYBACK_RECORDED_VEHICLE` | `void SKIP_TIME_IN_PLAYBACK_RECORDED_VEHICLE(int vehicle, float time)` | void |
| `SKIP_TO_END_AND_STOP_PLAYBACK_RECORDED_VEHICLE` | `void SKIP_TO_END_AND_STOP_PLAYBACK_RECORDED_VEHICLE(int vehicle)` | void |
| `SMASH_VEHICLE_WINDOW` | `void SMASH_VEHICLE_WINDOW(int vehicle, int windowIndex)` | void |
| `STABILISE_ENTITY_ATTACHED_TO_HELI` | `void STABILISE_ENTITY_ATTACHED_TO_HELI(int vehicle, int entity, float p2)` | void |
| `START_PLAYBACK_RECORDED_VEHICLE` | `void START_PLAYBACK_RECORDED_VEHICLE(int vehicle, int recording, string script, bool p3)` | void |
| `START_PLAYBACK_RECORDED_VEHICLE_USING_AI` | `void START_PLAYBACK_RECORDED_VEHICLE_USING_AI(int vehicle, int recording, string script, float speed, int drivingStyle)` | void |
| `START_PLAYBACK_RECORDED_VEHICLE_WITH_FLAGS` | `void START_PLAYBACK_RECORDED_VEHICLE_WITH_FLAGS(int vehicle, int recording, string script, int flags, int time, int drivingStyle)` | void |
| `START_VEHICLE_ALARM` | `void START_VEHICLE_ALARM(int vehicle)` | void |
| `START_VEHICLE_HORN` | `void START_VEHICLE_HORN(int vehicle, int duration, uint mode, bool forever)` | void |
| `STOP_ALL_GARAGE_ACTIVITY` | `void STOP_ALL_GARAGE_ACTIVITY()` | void |
| `STOP_BRINGING_VEHICLE_TO_HALT` | `void STOP_BRINGING_VEHICLE_TO_HALT(int vehicle)` | void |
| `STOP_PLAYBACK_RECORDED_VEHICLE` | `void STOP_PLAYBACK_RECORDED_VEHICLE(int vehicle)` | void |
| `SUPPRESS_NEONS_ON_VEHICLE` | `void SUPPRESS_NEONS_ON_VEHICLE(int vehicle, bool toggle)` | void |
| `SWING_BOAT_BOOM_FREELY` | `void SWING_BOAT_BOOM_FREELY(int vehicle, bool toggle)` | void |
| `SWING_BOAT_BOOM_TO_RATIO` | `void SWING_BOAT_BOOM_TO_RATIO(int vehicle, float ratio)` | void |
| `SWITCH_TRAIN_TRACK` | `void SWITCH_TRAIN_TRACK(int trackId, bool state)` | void |
| `TOGGLE_VEHICLE_MOD` | `void TOGGLE_VEHICLE_MOD(int vehicle, int modType, bool toggle)` | void |
| `TRACK_VEHICLE_VISIBILITY` | `void TRACK_VEHICLE_VISIBILITY(int vehicle)` | void |
| `TRANSFORM_TO_CAR` | `void TRANSFORM_TO_CAR(int vehicle, bool noAnimation)` | void |
| `TRANSFORM_TO_SUBMARINE` | `bool TRANSFORM_TO_SUBMARINE(int vehicle, bool noAnimation)` | bool |
| `UNPAUSE_PLAYBACK_RECORDED_VEHICLE` | `void UNPAUSE_PLAYBACK_RECORDED_VEHICLE(int vehicle)` | void |
| `VEHICLE_SET_ENABLE_NORMALISE_RAMP_CAR_VERTICAL_VELOCTIY` | `void VEHICLE_SET_ENABLE_NORMALISE_RAMP_CAR_VERTICAL_VELOCTIY(object p0, object p1)` | void |
| `VEHICLE_SET_ENABLE_RAMP_CAR_SIDE_IMPULSE` | `void VEHICLE_SET_ENABLE_RAMP_CAR_SIDE_IMPULSE(object p0, object p1)` | void |
| `VEHICLE_SET_EXTENABLE_SIDE_TARGET_RATIO` | `int VEHICLE_SET_EXTENABLE_SIDE_TARGET_RATIO(object p0, object p1)` | int |
| `VEHICLE_SET_JET_WASH_FORCE_ENABLED` | `void VEHICLE_SET_JET_WASH_FORCE_ENABLED(object p0)` | void |
| `VEHICLE_SET_OVERRIDE_EXTENABLE_SIDE_RATIO` | `int VEHICLE_SET_OVERRIDE_EXTENABLE_SIDE_RATIO(object p0, object p1)` | int |
| `VEHICLE_SET_OVERRIDE_SIDE_RATIO` | `int VEHICLE_SET_OVERRIDE_SIDE_RATIO(object p0, object p1)` | int |
| `VEHICLE_SET_PARACHUTE_MODEL_OVERRIDE` | `void VEHICLE_SET_PARACHUTE_MODEL_OVERRIDE(int vehicle, uint modelHash)` | void |
| `VEHICLE_SET_PARACHUTE_MODEL_TINT_INDEX` | `void VEHICLE_SET_PARACHUTE_MODEL_TINT_INDEX(int vehicle, int textureVariation)` | void |
| `VEHICLE_SET_RAMP_AND_RAMMING_CARS_TAKE_DAMAGE` | `void VEHICLE_SET_RAMP_AND_RAMMING_CARS_TAKE_DAMAGE(int vehicle, bool toggle)` | void |
| `VEHICLE_START_PARACHUTING` | `void VEHICLE_START_PARACHUTING(int vehicle, bool active)` | void |
| `_ARE_MISSILE_BAYS_DEPLOYED` | `bool _ARE_MISSILE_BAYS_DEPLOYED(int vehicle)` | bool |
| `_ENABLE_INDIVIDUAL_PLANE_PROPELLER` | `void _ENABLE_INDIVIDUAL_PLANE_PROPELLER(int vehicle, int propeller)` | void |
| `_GET_IS_VEHICLE_ELECTRIC` | `bool _GET_IS_VEHICLE_ELECTRIC(uint vehicleModel)` | bool |
| `_GET_MISSION_TRAIN_CONFIG_INDEX_BY_NAME` | `int _GET_MISSION_TRAIN_CONFIG_INDEX_BY_NAME(string name)` | int |
| `_GET_REMAINING_NITROUS_DURATION` | `float _GET_REMAINING_NITROUS_DURATION(int vehicle)` | float |
| `_GET_VEHICLE_ALLOW_HOMING_MISSLE_LOCKON_SYNCED` | `bool _GET_VEHICLE_ALLOW_HOMING_MISSLE_LOCKON_SYNCED(int vehicle)` | bool |
| `_GET_VEHICLE_CURRENT_DRIVE_GEAR` | `int _GET_VEHICLE_CURRENT_DRIVE_GEAR(int vehicle)` | int |
| `_GET_VEHICLE_CURRENT_REV_RATIO` | `float _GET_VEHICLE_CURRENT_REV_RATIO(int vehicle)` | float |
| `_GET_VEHICLE_DESIRED_DRIVE_GEAR` | `int _GET_VEHICLE_DESIRED_DRIVE_GEAR(int vehicle)` | int |
| `_GET_VEHICLE_DRIVETRAIN_TYPE` | `int _GET_VEHICLE_DRIVETRAIN_TYPE(uint vehicleModel)` | int |
| `_GET_VEHICLE_EXHAUST_BONE` | `bool _GET_VEHICLE_EXHAUST_BONE(int vehicle, int index, ref int boneIndex, ref bool axisX)` | bool |
| `_GET_VEHICLE_MAX_DRIVE_GEAR_COUNT` | `int _GET_VEHICLE_MAX_DRIVE_GEAR_COUNT(int vehicle)` | int |
| `_GET_VEHICLE_MAX_EXHAUST_BONE_COUNT` | `int _GET_VEHICLE_MAX_EXHAUST_BONE_COUNT()` | int |
| `_GET_VEHICLE_MODEL_NUM_DRIVE_GEARS` | `int _GET_VEHICLE_MODEL_NUM_DRIVE_GEARS(uint vehicleModel)` | int |
| `_GET_VEHICLE_THROTTLE` | `float _GET_VEHICLE_THROTTLE(int vehicle)` | float |
| `_GET_VEHICLE_TRAILER_PARENT_VEHICLE` | `int _GET_VEHICLE_TRAILER_PARENT_VEHICLE(int trailer)` | int |
| `_IS_VEHICLE_GEN9_EXCLUSIVE_MODEL` | `bool _IS_VEHICLE_GEN9_EXCLUSIVE_MODEL(uint vehicleModel)` | bool |
| `_IS_VEHICLE_ON_BOOST_PAD` | `bool _IS_VEHICLE_ON_BOOST_PAD(int vehicle)` | bool |
| `_SET_ALLOW_COLLISION_WHEN_IN_VEHICLE` | `void _SET_ALLOW_COLLISION_WHEN_IN_VEHICLE(int vehicle, bool toggle)` | void |
| `_SET_ATTACHED_VEHICLE_TO_TOW_TRUCK_ARM` | `void _SET_ATTACHED_VEHICLE_TO_TOW_TRUCK_ARM(int towTruck, int vehicle)` | void |
| `_SET_BOUNDS_AFFECT_WATER_PROBES` | `void _SET_BOUNDS_AFFECT_WATER_PROBES(int vehicle, bool toggle)` | void |
| `_SET_DEPLOY_MISSILE_BAYS` | `void _SET_DEPLOY_MISSILE_BAYS(int vehicle, bool deploy)` | void |
| `_SET_DISABLE_EXPLODE_FROM_BODY_DAMAGE_RECEIVED_BY_AI_VEHICLE` | `void _SET_DISABLE_EXPLODE_FROM_BODY_DAMAGE_RECEIVED_BY_AI_VEHICLE(int vehicle, bool disable)` | void |
| `_SET_DRIFT_SLIP_ANGLE_LIMITS` | `void _SET_DRIFT_SLIP_ANGLE_LIMITS(int vehicle, float durationScalar, float amplitudeScalar, float slipAngleLimit)` | void |
| `_SET_MAKE_TRAIN_SCAN_FOR_BLOCKING_ENTITIES` | `void _SET_MAKE_TRAIN_SCAN_FOR_BLOCKING_ENTITIES(int train, bool toggle)` | void |
| `_SET_MINIMUM_TIME_BETWEEN_GEAR_SHIFTS` | `void _SET_MINIMUM_TIME_BETWEEN_GEAR_SHIFTS(int vehicle, int time)` | void |
| `_SET_NITROUS_IS_VISIBLE` | `void _SET_NITROUS_IS_VISIBLE(int vehicle, bool enabled)` | void |
| `_SET_OVERRIDE_TRACTION_LOSS_MULTIPLIER` | `void _SET_OVERRIDE_TRACTION_LOSS_MULTIPLIER(int vehicle, float modifier)` | void |
| `_SET_PLANE_AVOIDS_OTHERS` | `void _SET_PLANE_AVOIDS_OTHERS(int vehicle, bool toggle)` | void |
| `_SET_REMAINING_NITROUS_DURATION` | `void _SET_REMAINING_NITROUS_DURATION(int vehicle, float duration)` | void |
| `_SET_TRANSMISSION_REDUCED_GEAR_RATIO` | `void _SET_TRANSMISSION_REDUCED_GEAR_RATIO(int vehicle, bool toggle)` | void |
| `_SET_VEHICLE_EXPLOSIVE_DAMAGE_SCALE` | `object _SET_VEHICLE_EXPLOSIVE_DAMAGE_SCALE(int vehicle, float scale)` | object |
| `_SET_VEHICLE_MAX_LAUNCH_ENGINE_REVS` | `void _SET_VEHICLE_MAX_LAUNCH_ENGINE_REVS(int vehicle, float modifier)` | void |
| `_SET_VEHICLE_USE_HORN_BUTTON_FOR_NITROUS` | `void _SET_VEHICLE_USE_HORN_BUTTON_FOR_NITROUS(bool toggle)` | void |

---
