# PED - Native 函数参考

> 命名空间: PED

---

## 快速索引

| 函数名 | C# 签名 | 返回值 | 说明 |
|--------|---------|--------|------|
| `ADD_ARMOUR_TO_PED` | `void ADD_ARMOUR_TO_PED(int ped, int amount)` | void | Same as SET_PED_ARMOUR, but ADDS 'amount' to the armor the Ped already has. |
| `ADD_PED_DECORATION_FROM_HASHES` | `void ADD_PED_DECORATION_FROM_HASHES(int ped, uint collection, uint overlay)` | void | Applies an Item from a PedDecorationCollection to a ped. These include tattoos and shirt decals.<br><br>co... |
| `ADD_PED_DECORATION_FROM_HASHES_IN_CORONA` | `void ADD_PED_DECORATION_FROM_HASHES_IN_CORONA(int ped, uint collection, uint overlay)` | void | Full list of ped overlays / decorations by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/... |
| `ADD_RELATIONSHIP_GROUP` | `bool ADD_RELATIONSHIP_GROUP(string name, Hash* groupHash)` | bool | Can't select void. This function returns nothing. The hash of the created relationship group is outp... |
| `ADD_SCENARIO_BLOCKING_AREA` | `int ADD_SCENARIO_BLOCKING_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool p6, bool p7, bool p8, bool p9, object p10)` | int | - |
| `APPLY_DAMAGE_TO_PED` | `void APPLY_DAMAGE_TO_PED(int ped, int damageAmount, bool p2, object p3, uint weaponType)` | void | damages a ped with the given amount |
| `APPLY_PED_BLOOD` | `void APPLY_PED_BLOOD(int ped, int boneIndex, float xRot, float yRot, float zRot, string woundType)` | void | woundTypes:<br>- soak_splat<br>- wound_sheet<br>- BulletSmall<br>- BulletLarge<br>- ShotgunSmall<br>- ShotgunSmallMono... |
| `APPLY_PED_BLOOD_BY_ZONE` | `void APPLY_PED_BLOOD_BY_ZONE(int ped, int p1, float p2, float p3, string p4)` | void | - |
| `APPLY_PED_BLOOD_DAMAGE_BY_ZONE` | `void APPLY_PED_BLOOD_DAMAGE_BY_ZONE(int ped, object p1, float p2, float p3, object p4)` | void | - |
| `APPLY_PED_BLOOD_SPECIFIC` | `void APPLY_PED_BLOOD_SPECIFIC(int ped, int p1, float p2, float p3, float p4, float p5, int p6, float p7, string p8)` | void | - |
| `APPLY_PED_DAMAGE_DECAL` | `void APPLY_PED_DAMAGE_DECAL(int ped, int damageZone, float xOffset, float yOffset, float heading, float scale, float alpha, int variation, bool fadeIn, string decalName)` | void | enum eDamageZone<br>{<br>	DZ_Torso = 0,<br>	DZ_Head,<br>	DZ_LeftArm,<br>	DZ_RightArm,<br>	DZ_LeftLeg,<br>	DZ_RightLeg,<br>};... |
| `APPLY_PED_DAMAGE_PACK` | `void APPLY_PED_DAMAGE_PACK(int ped, string damagePack, float damage, float mult)` | void | Damage Packs:<br><br>"SCR_TrevorTreeBang"<br>"HOSPITAL_0"<br>"HOSPITAL_1"<br>"HOSPITAL_2"<br>"HOSPITAL_3"<br>"HOSPITAL_4"... |
| `ATTACH_SYNCHRONIZED_SCENE_TO_ENTITY` | `void ATTACH_SYNCHRONIZED_SCENE_TO_ENTITY(int sceneID, int entity, int boneIndex)` | void | - |
| `BLOCK_PED_FROM_GENERATING_DEAD_BODY_EVENTS_WHEN_DEAD` | `void BLOCK_PED_FROM_GENERATING_DEAD_BODY_EVENTS_WHEN_DEAD(int ped, bool toggle)` | void | - |
| `CAN_CREATE_RANDOM_BIKE_RIDER` | `bool CAN_CREATE_RANDOM_BIKE_RIDER()` | bool | - |
| `CAN_CREATE_RANDOM_COPS` | `bool CAN_CREATE_RANDOM_COPS()` | bool | - |
| `CAN_CREATE_RANDOM_DRIVER` | `bool CAN_CREATE_RANDOM_DRIVER()` | bool | - |
| `CAN_CREATE_RANDOM_PED` | `bool CAN_CREATE_RANDOM_PED(bool p0)` | bool | - |
| `CAN_KNOCK_PED_OFF_VEHICLE` | `bool CAN_KNOCK_PED_OFF_VEHICLE(int ped)` | bool | - |
| `CAN_PED_IN_COMBAT_SEE_TARGET` | `bool CAN_PED_IN_COMBAT_SEE_TARGET(int ped, int target)` | bool | - |
| `CAN_PED_RAGDOLL` | `bool CAN_PED_RAGDOLL(int ped)` | bool | Prevents the ped from going limp.<br><br>[Example: Can prevent peds from falling when standing on moving v... |
| `CAN_PED_SEE_HATED_PED` | `bool CAN_PED_SEE_HATED_PED(int ped1, int ped2)` | bool | - |
| `CAN_PED_SHUFFLE_TO_OR_FROM_EXTRA_SEAT` | `bool CAN_PED_SHUFFLE_TO_OR_FROM_EXTRA_SEAT(int ped, ref int p1)` | bool | - |
| `CAN_PED_SHUFFLE_TO_OR_FROM_TURRET_SEAT` | `bool CAN_PED_SHUFFLE_TO_OR_FROM_TURRET_SEAT(int ped, ref int p1)` | bool | - |
| `CLEAR_ALL_PED_PROPS` | `void CLEAR_ALL_PED_PROPS(int ped, object p1)` | void | List of component/props ID<br>gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html |
| `CLEAR_ALL_PED_VEHICLE_FORCED_SEAT_USAGE` | `void CLEAR_ALL_PED_VEHICLE_FORCED_SEAT_USAGE(int ped)` | void | - |
| `CLEAR_COVER_POINT_FOR_PED` | `void CLEAR_COVER_POINT_FOR_PED(int ped)` | void | - |
| `CLEAR_FACIAL_IDLE_ANIM_OVERRIDE` | `void CLEAR_FACIAL_IDLE_ANIM_OVERRIDE(int ped)` | void | - |
| `CLEAR_PED_ALTERNATE_MOVEMENT_ANIM` | `void CLEAR_PED_ALTERNATE_MOVEMENT_ANIM(int ped, int stance, float p2)` | void | - |
| `CLEAR_PED_ALTERNATE_WALK_ANIM` | `void CLEAR_PED_ALTERNATE_WALK_ANIM(int ped, float p1)` | void | - |
| `CLEAR_PED_BLOOD_DAMAGE` | `void CLEAR_PED_BLOOD_DAMAGE(int ped)` | void | - |
| `CLEAR_PED_BLOOD_DAMAGE_BY_ZONE` | `void CLEAR_PED_BLOOD_DAMAGE_BY_ZONE(int ped, int p1)` | void | Somehow related to changing ped's clothes. |
| `CLEAR_PED_DAMAGE_DECAL_BY_ZONE` | `void CLEAR_PED_DAMAGE_DECAL_BY_ZONE(int ped, int p1, string p2)` | void | p1: from 0 to 5 in the b617d scripts.<br>p2: "blushing" and "ALL" found in the b617d scripts. |
| `CLEAR_PED_DECORATIONS` | `void CLEAR_PED_DECORATIONS(int ped)` | void | - |
| `CLEAR_PED_DECORATIONS_LEAVE_SCARS` | `void CLEAR_PED_DECORATIONS_LEAVE_SCARS(int ped)` | void | - |
| `CLEAR_PED_DRIVE_BY_CLIPSET_OVERRIDE` | `void CLEAR_PED_DRIVE_BY_CLIPSET_OVERRIDE(int ped)` | void | - |
| `CLEAR_PED_ENV_DIRT` | `void CLEAR_PED_ENV_DIRT(int ped)` | void | - |
| `CLEAR_PED_FALL_UPPER_BODY_CLIPSET_OVERRIDE` | `void CLEAR_PED_FALL_UPPER_BODY_CLIPSET_OVERRIDE(int ped)` | void | - |
| `CLEAR_PED_LAST_DAMAGE_BONE` | `void CLEAR_PED_LAST_DAMAGE_BONE(int ped)` | void | - |
| `CLEAR_PED_MOTION_IN_COVER_CLIPSET_OVERRIDE` | `void CLEAR_PED_MOTION_IN_COVER_CLIPSET_OVERRIDE(int ped)` | void | - |
| `CLEAR_PED_NON_CREATION_AREA` | `void CLEAR_PED_NON_CREATION_AREA()` | void | - |
| `CLEAR_PED_PARACHUTE_PACK_VARIATION` | `void CLEAR_PED_PARACHUTE_PACK_VARIATION(int ped)` | void | - |
| `CLEAR_PED_PROP` | `void CLEAR_PED_PROP(int ped, int propId, object p2)` | void | List of component/props ID<br>gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html |
| `CLEAR_PED_SCUBA_GEAR_VARIATION` | `void CLEAR_PED_SCUBA_GEAR_VARIATION(int ped)` | void | Removes the scubagear (for mp male: component id: 8, drawableId: 123, textureId: any) from peds. Doe... |
| `CLEAR_PED_STORED_HAT_PROP` | `void CLEAR_PED_STORED_HAT_PROP(int ped)` | void | - |
| `CLEAR_PED_WETNESS` | `void CLEAR_PED_WETNESS(int ped)` | void | It clears the wetness of the selected Ped/Player. Clothes have to be wet to notice the difference. |
| `CLEAR_RAGDOLL_BLOCKING_FLAGS` | `void CLEAR_RAGDOLL_BLOCKING_FLAGS(int ped, int blockingFlag)` | void | See SET_RAGDOLL_BLOCKING_FLAGS for flags |
| `CLEAR_RELATIONSHIP_BETWEEN_GROUPS` | `void CLEAR_RELATIONSHIP_BETWEEN_GROUPS(int relationship, uint group1, uint group2)` | void | Clears the relationship between two groups. This should be called twice (once for each group).<br><br>Rela... |
| `CLONE_PED` | `int CLONE_PED(int ped, bool isNetwork, bool bScriptHostPed, bool copyHeadBlendFlag)` | int | - |
| `CLONE_PED_ALT` | `int CLONE_PED_ALT(int ped, bool isNetwork, bool bScriptHostPed, bool copyHeadBlendFlag, bool p4)` | int | - |
| `CLONE_PED_TO_TARGET` | `void CLONE_PED_TO_TARGET(int ped, int targetPed)` | void | Copies ped's components and props to targetPed. |
| `CLONE_PED_TO_TARGET_ALT` | `void CLONE_PED_TO_TARGET_ALT(int ped, int targetPed, bool p2)` | void | - |
| `COUNT_PEDS_IN_COMBAT_WITH_TARGET` | `int COUNT_PEDS_IN_COMBAT_WITH_TARGET(int ped)` | int | - |
| `COUNT_PEDS_IN_COMBAT_WITH_TARGET_WITHIN_RADIUS` | `int COUNT_PEDS_IN_COMBAT_WITH_TARGET_WITHIN_RADIUS(int ped, float x, float y, float z, float radius)` | int | - |
| `CREATE_GROUP` | `int CREATE_GROUP(int unused)` | int | Creates a new ped group.<br>Groups can contain up to 8 peds.<br><br>The parameter is unused.<br><br>Returns a handl... |
| `CREATE_NM_MESSAGE` | `void CREATE_NM_MESSAGE(bool startImmediately, int messageId)` | void | Creates a new NaturalMotion message.<br><br>startImmediately: If set to true, the character will perform t... |
| `CREATE_PARACHUTE_BAG_OBJECT` | `int CREATE_PARACHUTE_BAG_OBJECT(int ped, bool p1, bool p2)` | int | - |
| `CREATE_PED` | `int CREATE_PED(int pedType, uint modelHash, float x, float y, float z, float heading, bool isNetwork, bool bScriptHostPed)` | int | https://alloc8or.re/gta5/doc/enums/ePedType.txt<br><br>Full list of peds by DurtyFree: https://github.com/... |
| `CREATE_PED_INSIDE_VEHICLE` | `int CREATE_PED_INSIDE_VEHICLE(int vehicle, int pedType, uint modelHash, int seat, bool isNetwork, bool bScriptHostPed)` | int | pedType: see CREATE_PED<br><br>Full list of peds by DurtyFree: https://github.com/DurtyFree/gta-v-data-dum... |
| `CREATE_RANDOM_PED` | `int CREATE_RANDOM_PED(float posX, float posY, float posZ)` | int | vb.net<br>Dim ped_handle As Integer<br>                    With Game.Player.Character<br>                    ... |
| `CREATE_RANDOM_PED_AS_DRIVER` | `int CREATE_RANDOM_PED_AS_DRIVER(int vehicle, bool returnHandle)` | int | - |
| `CREATE_SYNCHRONIZED_SCENE` | `int CREATE_SYNCHRONIZED_SCENE(float x, float y, float z, float roll, float pitch, float yaw, int p6)` | int | p6 always 2 (but it doesnt seem to matter...)<br><br>roll and pitch 0<br>yaw to Ped.rotation |
| `CREATE_SYNCHRONIZED_SCENE_AT_MAP_OBJECT` | `int CREATE_SYNCHRONIZED_SCENE_AT_MAP_OBJECT(float x, float y, float z, float radius, uint object)` | int | - |
| `DELETE_PED` | `void DELETE_PED(Ped* ped)` | void | Deletes the specified ped, then sets the handle pointed to by the pointer to NULL. |
| `DETACH_SYNCHRONIZED_SCENE` | `void DETACH_SYNCHRONIZED_SCENE(int sceneID)` | void | - |
| `DISABLE_HEAD_BLEND_PALETTE_COLOR` | `void DISABLE_HEAD_BLEND_PALETTE_COLOR(int ped)` | void | - |
| `DISABLE_PED_HEATSCALE_OVERRIDE` | `void DISABLE_PED_HEATSCALE_OVERRIDE(int ped)` | void | - |
| `DISABLE_PED_INJURED_ON_GROUND_BEHAVIOUR` | `void DISABLE_PED_INJURED_ON_GROUND_BEHAVIOUR(int ped)` | void | - |
| `DOES_GROUP_EXIST` | `bool DOES_GROUP_EXIST(int groupId)` | bool | - |
| `DOES_RELATIONSHIP_GROUP_EXIST` | `bool DOES_RELATIONSHIP_GROUP_EXIST(uint groupHash)` | bool | - |
| `DOES_SCENARIO_BLOCKING_AREA_EXISTS` | `bool DOES_SCENARIO_BLOCKING_AREA_EXISTS(float x1, float y1, float z1, float x2, float y2, float z2)` | bool | - |
| `DROP_AMBIENT_PROP` | `void DROP_AMBIENT_PROP(int ped)` | void | - |
| `ENABLE_MP_LIGHT` | `void ENABLE_MP_LIGHT(int ped, bool toggle)` | void | - |
| `EXPLODE_PED_HEAD` | `void EXPLODE_PED_HEAD(int ped, uint weaponHash)` | void | Forces the ped to fall back and kills it.<br><br>It doesn't really explode the ped's head but it kills the... |
| `FINALIZE_HEAD_BLEND` | `void FINALIZE_HEAD_BLEND(int ped)` | void | - |
| `FORCE_ALL_HEADING_VALUES_TO_ALIGN` | `void FORCE_ALL_HEADING_VALUES_TO_ALIGN(int ped)` | void | - |
| `FORCE_INSTANT_LEG_IK_SETUP` | `void FORCE_INSTANT_LEG_IK_SETUP(int ped)` | void | - |
| `FORCE_PED_AI_AND_ANIMATION_UPDATE` | `void FORCE_PED_AI_AND_ANIMATION_UPDATE(int ped, bool p1, bool p2)` | void | - |
| `FORCE_PED_MOTION_STATE` | `bool FORCE_PED_MOTION_STATE(int ped, uint motionStateHash, bool p2, int p3, bool p4)` | bool | Regarding p2, p3 and p4: Most common is 0, 0, 0); followed by 0, 1, 0); and 1, 1, 0); in R* scripts.... |
| `FORCE_PED_TO_OPEN_PARACHUTE` | `void FORCE_PED_TO_OPEN_PARACHUTE(int ped)` | void | - |
| `FORCE_ZERO_MASS_IN_COLLISIONS` | `void FORCE_ZERO_MASS_IN_COLLISIONS(int ped)` | void | - |
| `GET_ANIM_INITIAL_OFFSET_POSITION` | `Vector3 GET_ANIM_INITIAL_OFFSET_POSITION(string animDict, string animName, float x, float y, float z, float xRot, float yRot, float zRot, float p8, int p9)` | Vector3 | Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-... |
| `GET_ANIM_INITIAL_OFFSET_ROTATION` | `Vector3 GET_ANIM_INITIAL_OFFSET_ROTATION(string animDict, string animName, float x, float y, float z, float xRot, float yRot, float zRot, float p8, int p9)` | Vector3 | Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-... |
| `GET_CAN_PED_BE_GRABBED_BY_SCRIPT` | `bool GET_CAN_PED_BE_GRABBED_BY_SCRIPT(int ped, bool p1, bool p2, bool p3, bool p4, bool p5, bool p6, bool p7, object p8)` | bool | - |
| `GET_CLOSEST_PED` | `bool GET_CLOSEST_PED(float x, float y, float z, float radius, bool p4, bool p5, Ped* outPed, bool p7, bool p8, int pedType)` | bool | Gets the closest ped in a radius.<br><br>Ped Types:<br>Any ped = -1<br>Player = 1<br>Male = 4 <br>Female = 5 <br>Cop = 6<br>... |
| `GET_COMBAT_FLOAT` | `float GET_COMBAT_FLOAT(int ped, int p1)` | float | p0: Ped Handle<br>p1: int i \| 0 <= i <= 27<br><br>p1 probably refers to the attributes configured in combatbe... |
| `GET_DEAD_PED_PICKUP_COORDS` | `Vector3 GET_DEAD_PED_PICKUP_COORDS(int ped, float p1, float p2)` | Vector3 | - |
| `GET_DEFAULT_SECONDARY_TINT_FOR_BARBER` | `int GET_DEFAULT_SECONDARY_TINT_FOR_BARBER(int colorID)` | int | - |
| `GET_DEFAULT_SECONDARY_TINT_FOR_CREATOR` | `int GET_DEFAULT_SECONDARY_TINT_FOR_CREATOR(int colorId)` | int | - |
| `GET_FM_FEMALE_SHOP_PED_APPAREL_ITEM_INDEX` | `int GET_FM_FEMALE_SHOP_PED_APPAREL_ITEM_INDEX(int p0)` | int | - |
| `GET_FM_MALE_SHOP_PED_APPAREL_ITEM_INDEX` | `int GET_FM_MALE_SHOP_PED_APPAREL_ITEM_INDEX(int p0)` | int | - |
| `GET_GROUP_SIZE` | `void GET_GROUP_SIZE(int groupID, ref object p1, ref int sizeInMembers)` | void | p1 may be a BOOL representing whether or not the group even exists |
| `GET_HEAD_BLEND_EYE_COLOR` | `int GET_HEAD_BLEND_EYE_COLOR(int ped)` | int | A getter for _SET_PED_EYE_COLOR. Returns -1 if fails to get. |
| `GET_JACK_TARGET` | `int GET_JACK_TARGET(int ped)` | int | - |
| `GET_MELEE_TARGET_FOR_PED` | `int GET_MELEE_TARGET_FOR_PED(int ped)` | int | - |
| `GET_MOUNT` | `int GET_MOUNT(int ped)` | int | <br>Function just returns 0<br>void __fastcall ped__get_mount(NativeContext *a1)<br>{<br>  NativeContext *v1; //... |
| `GET_MP_LIGHT_ENABLED` | `bool GET_MP_LIGHT_ENABLED(int ped)` | bool | - |
| `GET_MP_OUTFIT_DATA_FROM_METADATA` | `bool GET_MP_OUTFIT_DATA_FROM_METADATA(ref object p0, ref object p1)` | bool | - |
| `GET_NUMBER_OF_PED_DRAWABLE_VARIATIONS` | `int GET_NUMBER_OF_PED_DRAWABLE_VARIATIONS(int ped, int componentId)` | int | List of component/props ID<br>gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html |
| `GET_NUMBER_OF_PED_PROP_DRAWABLE_VARIATIONS` | `int GET_NUMBER_OF_PED_PROP_DRAWABLE_VARIATIONS(int ped, int propId)` | int | List of component/props ID<br>gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html |
| `GET_NUMBER_OF_PED_PROP_TEXTURE_VARIATIONS` | `int GET_NUMBER_OF_PED_PROP_TEXTURE_VARIATIONS(int ped, int propId, int drawableId)` | int | Need to check behavior when drawableId = -1<br><br>- Doofy.Ass<br>Why this function doesn't work and return n... |
| `GET_NUMBER_OF_PED_TEXTURE_VARIATIONS` | `int GET_NUMBER_OF_PED_TEXTURE_VARIATIONS(int ped, int componentId, int drawableId)` | int | List of component/props ID<br>gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html |
| `GET_NUM_PED_HAIR_TINTS` | `int GET_NUM_PED_HAIR_TINTS()` | int | - |
| `GET_NUM_PED_MAKEUP_TINTS` | `int GET_NUM_PED_MAKEUP_TINTS()` | int | - |
| `GET_PEDHEADSHOT_TXD_STRING` | `string GET_PEDHEADSHOT_TXD_STRING(int id)` | string | gtaforums.com/topic/885580-ped-headshotmugshot-txd/ |
| `GET_PEDS_JACKER` | `int GET_PEDS_JACKER(int ped)` | int | - |
| `GET_PED_ACCURACY` | `int GET_PED_ACCURACY(int ped)` | int | - |
| `GET_PED_ALERTNESS` | `int GET_PED_ALERTNESS(int ped)` | int | Returns the ped's alertness (0-3).<br><br>Values : <br><br>0 : Neutral<br>1 : Heard something (gun shot, hit, etc)<br>... |
| `GET_PED_ARMOUR` | `int GET_PED_ARMOUR(int ped)` | int | - |
| `GET_PED_AS_GROUP_LEADER` | `int GET_PED_AS_GROUP_LEADER(int groupID)` | int | - |
| `GET_PED_AS_GROUP_MEMBER` | `int GET_PED_AS_GROUP_MEMBER(int groupID, int memberNumber)` | int | from fm_mission_controller.c4 (variable names changed for clarity):<br><br>int groupID = PLAYER::GET_PLAYE... |
| `GET_PED_BONE_COORDS` | `Vector3 GET_PED_BONE_COORDS(int ped, int boneId, float offsetX, float offsetY, float offsetZ)` | Vector3 | Gets the position of the specified bone of the specified ped.<br><br>ped: The ped to get the position of a... |
| `GET_PED_BONE_INDEX` | `int GET_PED_BONE_INDEX(int ped, int boneId)` | int | no bone= -1<br><br>boneIds:<br>        SKEL_ROOT = 0x0,<br>   SKEL_Pelvis = 0x2e28,<br> SKEL_L_Thigh = 0xe39f,<br>    ... |
| `GET_PED_CAUSE_OF_DEATH` | `uint GET_PED_CAUSE_OF_DEATH(int ped)` | uint | Returns the hash of the weapon/model/object that killed the ped. |
| `GET_PED_COMBAT_MOVEMENT` | `int GET_PED_COMBAT_MOVEMENT(int ped)` | int | See SET_PED_COMBAT_MOVEMENT |
| `GET_PED_COMBAT_RANGE` | `int GET_PED_COMBAT_RANGE(int ped)` | int | See SET_PED_COMBAT_RANGE |
| `GET_PED_CONFIG_FLAG` | `bool GET_PED_CONFIG_FLAG(int ped, int flagId, bool p2)` | bool | See SET_PED_CONFIG_FLAG |
| `GET_PED_CURRENT_MOVE_BLEND_RATIO` | `bool GET_PED_CURRENT_MOVE_BLEND_RATIO(int ped, ref float speedX, ref float speedY)` | bool | - |
| `GET_PED_DECORATIONS_STATE` | `int GET_PED_DECORATIONS_STATE(int ped)` | int | - |
| `GET_PED_DECORATION_ZONE_FROM_HASHES` | `int GET_PED_DECORATION_ZONE_FROM_HASHES(uint collection, uint overlay)` | int | Returns the zoneID for the overlay if it is a member of collection.<br>enum ePedDecorationZone<br>{<br>	ZONE_... |
| `GET_PED_DEFENSIVE_AREA_POSITION` | `Vector3 GET_PED_DEFENSIVE_AREA_POSITION(int ped, bool p1)` | Vector3 | - |
| `GET_PED_DIES_IN_WATER` | `bool GET_PED_DIES_IN_WATER(int ped)` | bool | - |
| `GET_PED_DRAWABLE_VARIATION` | `int GET_PED_DRAWABLE_VARIATION(int ped, int componentId)` | int | Ids<br>0 - Head<br>1 - Beard<br>2 - Hair<br>3 - Torso<br>4 - Legs<br>5 - Hands<br>6 - Foot<br>7 - ------<br>8 - Accessories 1<br>9... |
| `GET_PED_EMISSIVE_SCALE` | `float GET_PED_EMISSIVE_SCALE(int ped)` | float | Use 0x4E90D746056E273D to set the illuminated clothing glow intensity for a specific ped.<br>Returns a ... |
| `GET_PED_ENVEFF_SCALE` | `float GET_PED_ENVEFF_SCALE(int ped)` | float | - |
| `GET_PED_EXTRACTED_DISPLACEMENT` | `Vector3 GET_PED_EXTRACTED_DISPLACEMENT(int ped, bool worldSpace)` | Vector3 | Gets the offset the specified ped has moved since the previous tick.<br><br>If worldSpace is false, the re... |
| `GET_PED_GROUP_INDEX` | `int GET_PED_GROUP_INDEX(int ped)` | int | Returns the group id of which the specified ped is a member of. |
| `GET_PED_HAIR_TINT_COLOR` | `void GET_PED_HAIR_TINT_COLOR(int hairColorIndex, ref int outR, ref int outG, ref int outB)` | void | Input: Haircolor index, value between 0 and 63 (inclusive).<br>Output: RGB values for the haircolor spe... |
| `GET_PED_HEAD_BLEND_DATA` | `bool GET_PED_HEAD_BLEND_DATA(int ped, ref object headBlendData)` | bool | The pointer is to a padded struct that matches the arguments to SET_PED_HEAD_BLEND_DATA(...). There ... |
| `GET_PED_HEAD_BLEND_FIRST_INDEX` | `int GET_PED_HEAD_BLEND_FIRST_INDEX(int type)` | int | Type equals 0 for male non-dlc, 1 for female non-dlc, 2 for male dlc, and 3 for female dlc.<br><br>Used wh... |
| `GET_PED_HEAD_BLEND_NUM_HEADS` | `int GET_PED_HEAD_BLEND_NUM_HEADS(int type)` | int | Type equals 0 for male non-dlc, 1 for female non-dlc, 2 for male dlc, and 3 for female dlc. |
| `GET_PED_HEAD_OVERLAY` | `int GET_PED_HEAD_OVERLAY(int ped, int overlayID)` | int | Likely a char, if that overlay is not set, e.i. "None" option, returns 255;<br><br>This might be the once ... |
| `GET_PED_HEAD_OVERLAY_NUM` | `int GET_PED_HEAD_OVERLAY_NUM(int overlayID)` | int | - |
| `GET_PED_HELMET_STORED_HAT_PROP_INDEX` | `int GET_PED_HELMET_STORED_HAT_PROP_INDEX(int ped)` | int | - |
| `GET_PED_HELMET_STORED_HAT_TEX_INDEX` | `int GET_PED_HELMET_STORED_HAT_TEX_INDEX(int ped)` | int | - |
| `GET_PED_LAST_DAMAGE_BONE` | `bool GET_PED_LAST_DAMAGE_BONE(int ped, ref int outBone)` | bool | - |
| `GET_PED_MAKEUP_TINT_COLOR` | `void GET_PED_MAKEUP_TINT_COLOR(int makeupColorIndex, ref int outR, ref int outG, ref int outB)` | void | Input: Makeup color index, value between 0 and 63 (inclusive).<br>Output: RGB values for the makeup col... |
| `GET_PED_MAX_HEALTH` | `int GET_PED_MAX_HEALTH(int ped)` | int | - |
| `GET_PED_MONEY` | `int GET_PED_MONEY(int ped)` | int | - |
| `GET_PED_NEARBY_PEDS` | `int GET_PED_NEARBY_PEDS(int ped, ref object sizeAndPeds, int ignore)` | int | sizeAndPeds - is a pointer to an array. The array is filled with peds found nearby the ped supplied ... |
| `GET_PED_NEARBY_VEHICLES` | `int GET_PED_NEARBY_VEHICLES(int ped, ref object sizeAndVehs)` | int | Returns size of array, passed into the second variable.<br><br>See below for usage information.<br><br>This func... |
| `GET_PED_PALETTE_VARIATION` | `int GET_PED_PALETTE_VARIATION(int ped, int componentId)` | int | List of component/props ID<br>gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html |
| `GET_PED_PARACHUTE_LANDING_TYPE` | `int GET_PED_PARACHUTE_LANDING_TYPE(int ped)` | int | -1: no landing<br>0: landing on both feet<br>1: stumbling<br>2: rolling<br>3: ragdoll |
| `GET_PED_PARACHUTE_STATE` | `int GET_PED_PARACHUTE_STATE(int ped)` | int | Returns:<br><br>-1: Normal<br>0: Wearing parachute on back<br>1: Parachute opening<br>2: Parachute open<br>3: Falling ... |
| `GET_PED_PARACHUTE_TINT_INDEX` | `void GET_PED_PARACHUTE_TINT_INDEX(int ped, ref int outTintIndex)` | void | - |
| `GET_PED_PROP_INDEX` | `int GET_PED_PROP_INDEX(int ped, int componentId, object p2)` | int | List of component/props ID<br>gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html |
| `GET_PED_PROP_TEXTURE_INDEX` | `int GET_PED_PROP_TEXTURE_INDEX(int ped, int componentId)` | int | List of component/props ID<br>gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html |
| `GET_PED_RAGDOLL_BONE_INDEX` | `int GET_PED_RAGDOLL_BONE_INDEX(int ped, int bone)` | int | - |
| `GET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH` | `uint GET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH(int ped)` | uint | - |
| `GET_PED_RELATIONSHIP_GROUP_HASH` | `uint GET_PED_RELATIONSHIP_GROUP_HASH(int ped)` | uint | - |
| `GET_PED_RESET_FLAG` | `bool GET_PED_RESET_FLAG(int ped, int flagId)` | bool | - |
| `GET_PED_SOURCE_OF_DEATH` | `int GET_PED_SOURCE_OF_DEATH(int ped)` | int | Returns the Entity (Ped, Vehicle, or ?Object?) that killed the 'ped'<br><br>Is best to check if the Ped is... |
| `GET_PED_STEALTH_MOVEMENT` | `bool GET_PED_STEALTH_MOVEMENT(int ped)` | bool | Returns whether the entity is in stealth mode |
| `GET_PED_TARGET_FROM_COMBAT_PED` | `int GET_PED_TARGET_FROM_COMBAT_PED(int ped, object p1)` | int | - |
| `GET_PED_TEXTURE_VARIATION` | `int GET_PED_TEXTURE_VARIATION(int ped, int componentId)` | int | List of component/props ID<br>gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html |
| `GET_PED_TIME_OF_DEATH` | `int GET_PED_TIME_OF_DEATH(int ped)` | int | - |
| `GET_PED_TYPE` | `int GET_PED_TYPE(int ped)` | int | https://alloc8or.re/gta5/doc/enums/ePedType.txt |
| `GET_PED_VISUAL_FIELD_CENTER_ANGLE` | `float GET_PED_VISUAL_FIELD_CENTER_ANGLE(int ped)` | float | - |
| `GET_PLAYER_PED_IS_FOLLOWING` | `int GET_PLAYER_PED_IS_FOLLOWING(int ped)` | int | - |
| `GET_POS_FROM_FIRED_EVENT` | `bool GET_POS_FROM_FIRED_EVENT(int ped, int eventType, ref object outData)` | bool | - |
| `GET_RANDOM_PED_AT_COORD` | `int GET_RANDOM_PED_AT_COORD(float x, float y, float z, float xRadius, float yRadius, float zRadius, int pedType)` | int | Gets a random ped in the x/y/zRadius near the x/y/z coordinates passed. <br><br>Ped Types:<br>Any = -1<br>Player... |
| `GET_RELATIONSHIP_BETWEEN_GROUPS` | `int GET_RELATIONSHIP_BETWEEN_GROUPS(uint group1, uint group2)` | int | Gets the relationship between two groups. This should be called twice (once for each group).<br><br>Relati... |
| `GET_RELATIONSHIP_BETWEEN_PEDS` | `int GET_RELATIONSHIP_BETWEEN_PEDS(int ped1, int ped2)` | int | Gets the relationship between two peds. This should be called twice (once for each ped).<br><br>Relationsh... |
| `GET_SEAT_PED_IS_TRYING_TO_ENTER` | `int GET_SEAT_PED_IS_TRYING_TO_ENTER(int ped)` | int | - |
| `GET_SYNCHRONIZED_SCENE_PHASE` | `float GET_SYNCHRONIZED_SCENE_PHASE(int sceneID)` | float | - |
| `GET_SYNCHRONIZED_SCENE_RATE` | `float GET_SYNCHRONIZED_SCENE_RATE(int sceneID)` | float | - |
| `GET_TIME_PED_DAMAGED_BY_WEAPON` | `int GET_TIME_PED_DAMAGED_BY_WEAPON(int ped, uint weaponHash)` | int | - |
| `GET_TINT_INDEX_FOR_LAST_GEN_HAIR_TEXTURE` | `int GET_TINT_INDEX_FOR_LAST_GEN_HAIR_TEXTURE(uint modelHash, int drawableId, int textureId)` | int | - |
| `GET_TRACKED_PED_PIXELCOUNT` | `int GET_TRACKED_PED_PIXELCOUNT(int ped)` | int | - |
| `GET_VEHICLE_PED_IS_ENTERING` | `int GET_VEHICLE_PED_IS_ENTERING(int ped)` | int | - |
| `GET_VEHICLE_PED_IS_IN` | `int GET_VEHICLE_PED_IS_IN(int ped, bool includeEntering)` | int | Gets the vehicle the specified Ped is in. Returns 0 if the ped is/was not in a vehicle. |
| `GET_VEHICLE_PED_IS_TRYING_TO_ENTER` | `int GET_VEHICLE_PED_IS_TRYING_TO_ENTER(int ped)` | int | - |
| `GET_VEHICLE_PED_IS_USING` | `int GET_VEHICLE_PED_IS_USING(int ped)` | int | Gets ID of vehicle player using. It means it can get ID at any interaction with vehicle. Enter\exit ... |
| `GIVE_PED_HELMET` | `void GIVE_PED_HELMET(int ped, bool cannotRemove, int helmetFlag, int textureIndex)` | void | PoliceMotorcycleHelmet   1024    <br>RegularMotorcycleHelmet   4096    <br>FiremanHelmet 16384   <br>PilotHea... |
| `GIVE_PED_NM_MESSAGE` | `void GIVE_PED_NM_MESSAGE(int ped)` | void | Sends the message that was created by a call to CREATE_NM_MESSAGE to the specified Ped.<br><br>If a messag... |
| `HAS_ACTION_MODE_ASSET_LOADED` | `bool HAS_ACTION_MODE_ASSET_LOADED(string asset)` | bool | - |
| `HAS_PEDHEADSHOT_IMG_UPLOAD_FAILED` | `bool HAS_PEDHEADSHOT_IMG_UPLOAD_FAILED()` | bool | - |
| `HAS_PEDHEADSHOT_IMG_UPLOAD_SUCCEEDED` | `bool HAS_PEDHEADSHOT_IMG_UPLOAD_SUCCEEDED()` | bool | - |
| `HAS_PED_HEAD_BLEND_FINISHED` | `bool HAS_PED_HEAD_BLEND_FINISHED(int ped)` | bool | - |
| `HAS_PED_PRELOAD_PROP_DATA_FINISHED` | `bool HAS_PED_PRELOAD_PROP_DATA_FINISHED(int ped)` | bool | - |
| `HAS_PED_PRELOAD_VARIATION_DATA_FINISHED` | `bool HAS_PED_PRELOAD_VARIATION_DATA_FINISHED(int ped)` | bool | - |
| `HAS_PED_RECEIVED_EVENT` | `bool HAS_PED_RECEIVED_EVENT(int ped, int eventId)` | bool | - |
| `HAS_STEALTH_MODE_ASSET_LOADED` | `bool HAS_STEALTH_MODE_ASSET_LOADED(string asset)` | bool | - |
| `HAVE_ALL_STREAMING_REQUESTS_COMPLETED` | `bool HAVE_ALL_STREAMING_REQUESTS_COMPLETED(int ped)` | bool | - |
| `HIDE_PED_BLOOD_DAMAGE_BY_ZONE` | `void HIDE_PED_BLOOD_DAMAGE_BY_ZONE(int ped, object p1, bool p2)` | void | - |
| `INSTANTLY_FILL_PED_POPULATION` | `void INSTANTLY_FILL_PED_POPULATION()` | void | - |
| `IS_ANY_HOSTILE_PED_NEAR_POINT` | `bool IS_ANY_HOSTILE_PED_NEAR_POINT(int ped, float x, float y, float z, float radius)` | bool | - |
| `IS_ANY_PED_NEAR_POINT` | `bool IS_ANY_PED_NEAR_POINT(float x, float y, float z, float radius)` | bool | - |
| `IS_ANY_PED_SHOOTING_IN_AREA` | `bool IS_ANY_PED_SHOOTING_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool p6, bool p7)` | bool | - |
| `IS_CONVERSATION_PED_DEAD` | `bool IS_CONVERSATION_PED_DEAD(int ped)` | bool | - |
| `IS_COP_PED_IN_AREA_3D` | `bool IS_COP_PED_IN_AREA_3D(float x1, float y1, float z1, float x2, float y2, float z2)` | bool | xyz - relative to the world origin. |
| `IS_CURRENT_HEAD_PROP_A_HELMET` | `bool IS_CURRENT_HEAD_PROP_A_HELMET(object p0)` | bool | - |
| `IS_MOBILE_PHONE_TO_PED_EAR` | `bool IS_MOBILE_PHONE_TO_PED_EAR(int ped)` | bool | - |
| `IS_PEDHEADSHOT_IMG_UPLOAD_AVAILABLE` | `bool IS_PEDHEADSHOT_IMG_UPLOAD_AVAILABLE()` | bool | - |
| `IS_PEDHEADSHOT_READY` | `bool IS_PEDHEADSHOT_READY(int id)` | bool | gtaforums.com/topic/885580-ped-headshotmugshot-txd/ |
| `IS_PEDHEADSHOT_VALID` | `bool IS_PEDHEADSHOT_VALID(int id)` | bool | gtaforums.com/topic/885580-ped-headshotmugshot-txd/ |
| `IS_PED_AIMING_FROM_COVER` | `bool IS_PED_AIMING_FROM_COVER(int ped)` | bool | - |
| `IS_PED_A_PLAYER` | `bool IS_PED_A_PLAYER(int ped)` | bool | Returns true if the given ped has a valid pointer to CPlayerInfo in its CPed class. That's all. |
| `IS_PED_BEING_JACKED` | `bool IS_PED_BEING_JACKED(int ped)` | bool | - |
| `IS_PED_BEING_STEALTH_KILLED` | `bool IS_PED_BEING_STEALTH_KILLED(int ped)` | bool | - |
| `IS_PED_BEING_STUNNED` | `bool IS_PED_BEING_STUNNED(int ped, int p1)` | bool | p1 is always 0 |
| `IS_PED_BLUSH_FACEPAINT_TINT_FOR_BARBER` | `bool IS_PED_BLUSH_FACEPAINT_TINT_FOR_BARBER(int colorId)` | bool | - |
| `IS_PED_BLUSH_TINT_FOR_BARBER` | `bool IS_PED_BLUSH_TINT_FOR_BARBER(int colorID)` | bool | - |
| `IS_PED_BLUSH_TINT_FOR_CREATOR` | `bool IS_PED_BLUSH_TINT_FOR_CREATOR(int colorId)` | bool | - |
| `IS_PED_CLIMBING` | `bool IS_PED_CLIMBING(int ped)` | bool | - |
| `IS_PED_COMPONENT_VARIATION_VALID` | `bool IS_PED_COMPONENT_VARIATION_VALID(int ped, int componentId, int drawableId, int textureId)` | bool | Checks if the component variation is valid, this works great for randomizing components using loops.... |
| `IS_PED_DEAD_OR_DYING` | `bool IS_PED_DEAD_OR_DYING(int ped, bool p1)` | bool | Seems to consistently return true if the ped is dead.<br><br>p1 is always passed 1 in the scripts.<br><br>I sugg... |
| `IS_PED_DEFENSIVE_AREA_ACTIVE` | `bool IS_PED_DEFENSIVE_AREA_ACTIVE(int ped, bool p1)` | bool | - |
| `IS_PED_DIVING` | `bool IS_PED_DIVING(int ped)` | bool | - |
| `IS_PED_DOING_A_BEAST_JUMP` | `bool IS_PED_DOING_A_BEAST_JUMP(object p0)` | bool | - |
| `IS_PED_DOING_DRIVEBY` | `bool IS_PED_DOING_DRIVEBY(int ped)` | bool | - |
| `IS_PED_DUCKING` | `bool IS_PED_DUCKING(int ped)` | bool | - |
| `IS_PED_EVASIVE_DIVING` | `bool IS_PED_EVASIVE_DIVING(int ped, Entity* evadingEntity)` | bool | Presumably returns the Entity that the Ped is currently diving out of the way of.<br><br>var num3;<br>    if ... |
| `IS_PED_FACING_PED` | `bool IS_PED_FACING_PED(int ped, int otherPed, float angle)` | bool | angle is ped's view cone |
| `IS_PED_FALLING` | `bool IS_PED_FALLING(int ped)` | bool | - |
| `IS_PED_FATALLY_INJURED` | `bool IS_PED_FATALLY_INJURED(int ped)` | bool | Gets a value indicating whether this ped's health is below its fatally injured threshold. The defaul... |
| `IS_PED_FLEEING` | `bool IS_PED_FLEEING(int ped)` | bool | - |
| `IS_PED_GESTURING` | `bool IS_PED_GESTURING(object p0)` | bool | - |
| `IS_PED_GETTING_INTO_A_VEHICLE` | `bool IS_PED_GETTING_INTO_A_VEHICLE(int ped)` | bool | - |
| `IS_PED_GOING_INTO_COVER` | `bool IS_PED_GOING_INTO_COVER(int ped)` | bool | - |
| `IS_PED_GROUP_MEMBER` | `bool IS_PED_GROUP_MEMBER(int ped, int groupId)` | bool | - |
| `IS_PED_HAIR_TINT_FOR_BARBER` | `bool IS_PED_HAIR_TINT_FOR_BARBER(int colorID)` | bool | - |
| `IS_PED_HAIR_TINT_FOR_CREATOR` | `bool IS_PED_HAIR_TINT_FOR_CREATOR(int colorId)` | bool | - |
| `IS_PED_HANGING_ON_TO_VEHICLE` | `bool IS_PED_HANGING_ON_TO_VEHICLE(int ped)` | bool | - |
| `IS_PED_HEADING_TOWARDS_POSITION` | `bool IS_PED_HEADING_TOWARDS_POSITION(int ped, float x, float y, float z, float p4)` | bool | - |
| `IS_PED_HEADTRACKING_ENTITY` | `bool IS_PED_HEADTRACKING_ENTITY(int ped, int entity)` | bool | - |
| `IS_PED_HEADTRACKING_PED` | `bool IS_PED_HEADTRACKING_PED(int ped1, int ped2)` | bool | - |
| `IS_PED_HELMET_VISOR_UP` | `bool IS_PED_HELMET_VISOR_UP(int ped)` | bool | - |
| `IS_PED_HUMAN` | `bool IS_PED_HUMAN(int ped)` | bool | Returns true/false if the ped is/isn't humanoid. |
| `IS_PED_HURT` | `bool IS_PED_HURT(int ped)` | bool | Returns whether the specified ped is hurt. |
| `IS_PED_INJURED` | `bool IS_PED_INJURED(int ped)` | bool | Gets a value indicating whether this ped's health is below its injured threshold.<br><br>The default thres... |
| `IS_PED_IN_ANY_BOAT` | `bool IS_PED_IN_ANY_BOAT(int ped)` | bool | - |
| `IS_PED_IN_ANY_HELI` | `bool IS_PED_IN_ANY_HELI(int ped)` | bool | - |
| `IS_PED_IN_ANY_PLANE` | `bool IS_PED_IN_ANY_PLANE(int ped)` | bool | - |
| `IS_PED_IN_ANY_POLICE_VEHICLE` | `bool IS_PED_IN_ANY_POLICE_VEHICLE(int ped)` | bool | - |
| `IS_PED_IN_ANY_SUB` | `bool IS_PED_IN_ANY_SUB(int ped)` | bool | - |
| `IS_PED_IN_ANY_TAXI` | `bool IS_PED_IN_ANY_TAXI(int ped)` | bool | - |
| `IS_PED_IN_ANY_TRAIN` | `bool IS_PED_IN_ANY_TRAIN(int ped)` | bool | - |
| `IS_PED_IN_ANY_VEHICLE` | `bool IS_PED_IN_ANY_VEHICLE(int ped, bool atGetIn)` | bool | Gets a value indicating whether the specified ped is in any vehicle.<br><br>If 'atGetIn' is false, the fun... |
| `IS_PED_IN_COMBAT` | `bool IS_PED_IN_COMBAT(int ped, int target)` | bool | Checks to see if ped and target are in combat with eachother. Only goes one-way: if target is engage... |
| `IS_PED_IN_COVER` | `bool IS_PED_IN_COVER(int ped, bool exceptUseWeapon)` | bool | p1 is nearly always 0 in the scripts.  |
| `IS_PED_IN_COVER_FACING_LEFT` | `bool IS_PED_IN_COVER_FACING_LEFT(int ped)` | bool | - |
| `IS_PED_IN_FLYING_VEHICLE` | `bool IS_PED_IN_FLYING_VEHICLE(int ped)` | bool | - |
| `IS_PED_IN_GROUP` | `bool IS_PED_IN_GROUP(int ped)` | bool | - |
| `IS_PED_IN_HIGH_COVER` | `bool IS_PED_IN_HIGH_COVER(int ped)` | bool | - |
| `IS_PED_IN_MELEE_COMBAT` | `bool IS_PED_IN_MELEE_COMBAT(int ped)` | bool | Notes: The function only returns true while the ped is: <br>A.) Swinging a random melee attack (includi... |
| `IS_PED_IN_MODEL` | `bool IS_PED_IN_MODEL(int ped, uint modelHash)` | bool | - |
| `IS_PED_IN_PARACHUTE_FREE_FALL` | `bool IS_PED_IN_PARACHUTE_FREE_FALL(int ped)` | bool | - |
| `IS_PED_IN_VEHICLE` | `bool IS_PED_IN_VEHICLE(int ped, int vehicle, bool atGetIn)` | bool | Gets a value indicating whether the specified ped is in the specified vehicle.<br><br>If 'atGetIn' is fals... |
| `IS_PED_JACKING` | `bool IS_PED_JACKING(int ped)` | bool | - |
| `IS_PED_JUMPING` | `bool IS_PED_JUMPING(int ped)` | bool | - |
| `IS_PED_JUMPING_OUT_OF_VEHICLE` | `bool IS_PED_JUMPING_OUT_OF_VEHICLE(int ped)` | bool | - |
| `IS_PED_LANDING` | `bool IS_PED_LANDING(object p0)` | bool | - |
| `IS_PED_LIPSTICK_TINT_FOR_BARBER` | `bool IS_PED_LIPSTICK_TINT_FOR_BARBER(int colorID)` | bool | - |
| `IS_PED_LIPSTICK_TINT_FOR_CREATOR` | `bool IS_PED_LIPSTICK_TINT_FOR_CREATOR(int colorId)` | bool | - |
| `IS_PED_MALE` | `bool IS_PED_MALE(int ped)` | bool | Returns true/false if the ped is/isn't male. |
| `IS_PED_MODEL` | `bool IS_PED_MODEL(int ped, uint modelHash)` | bool | - |
| `IS_PED_ON_ANY_BIKE` | `bool IS_PED_ON_ANY_BIKE(int ped)` | bool | - |
| `IS_PED_ON_FOOT` | `bool IS_PED_ON_FOOT(int ped)` | bool | - |
| `IS_PED_ON_MOUNT` | `bool IS_PED_ON_MOUNT(int ped)` | bool | Same function call as PED::GET_MOUNT, aka just returns 0 |
| `IS_PED_ON_SPECIFIC_VEHICLE` | `bool IS_PED_ON_SPECIFIC_VEHICLE(int ped, int vehicle)` | bool | - |
| `IS_PED_ON_VEHICLE` | `bool IS_PED_ON_VEHICLE(int ped)` | bool | Gets a value indicating whether the specified ped is on top of any vehicle.<br><br>Return 1 when ped is on... |
| `IS_PED_OPENING_DOOR` | `bool IS_PED_OPENING_DOOR(int ped)` | bool | Returns true if the ped is currently opening a door (CTaskOpenDoor). |
| `IS_PED_PERFORMING_A_COUNTER_ATTACK` | `bool IS_PED_PERFORMING_A_COUNTER_ATTACK(int ped)` | bool | - |
| `IS_PED_PERFORMING_MELEE_ACTION` | `bool IS_PED_PERFORMING_MELEE_ACTION(int ped)` | bool | - |
| `IS_PED_PERFORMING_STEALTH_KILL` | `bool IS_PED_PERFORMING_STEALTH_KILL(int ped)` | bool | - |
| `IS_PED_PLANTING_BOMB` | `bool IS_PED_PLANTING_BOMB(int ped)` | bool | - |
| `IS_PED_PRONE` | `bool IS_PED_PRONE(int ped)` | bool | - |
| `IS_PED_RAGDOLL` | `bool IS_PED_RAGDOLL(int ped)` | bool | If the ped handle passed through the parenthesis is in a ragdoll state this will return true. |
| `IS_PED_RELOADING` | `bool IS_PED_RELOADING(int ped)` | bool | Returns whether the specified ped is reloading. |
| `IS_PED_RESPONDING_TO_EVENT` | `bool IS_PED_RESPONDING_TO_EVENT(int ped, object event)` | bool | - |
| `IS_PED_RUNNING_MELEE_TASK` | `bool IS_PED_RUNNING_MELEE_TASK(int ped)` | bool | - |
| `IS_PED_RUNNING_MOBILE_PHONE_TASK` | `bool IS_PED_RUNNING_MOBILE_PHONE_TASK(int ped)` | bool | - |
| `IS_PED_RUNNING_RAGDOLL_TASK` | `bool IS_PED_RUNNING_RAGDOLL_TASK(int ped)` | bool | - |
| `IS_PED_SHADER_READY` | `bool IS_PED_SHADER_READY(int ped)` | bool | - |
| `IS_PED_SHELTERED` | `bool IS_PED_SHELTERED(int ped)` | bool | - |
| `IS_PED_SHOOTING` | `bool IS_PED_SHOOTING(int ped)` | bool | Returns whether the specified ped is shooting. |
| `IS_PED_SHOOTING_IN_AREA` | `bool IS_PED_SHOOTING_IN_AREA(int ped, float x1, float y1, float z1, float x2, float y2, float z2, bool p7, bool p8)` | bool | - |
| `IS_PED_SITTING_IN_ANY_VEHICLE` | `bool IS_PED_SITTING_IN_ANY_VEHICLE(int ped)` | bool | Detect if ped is in any vehicle<br>[True/False] |
| `IS_PED_SITTING_IN_VEHICLE` | `bool IS_PED_SITTING_IN_VEHICLE(int ped, int vehicle)` | bool | Detect if ped is sitting in the specified vehicle<br>[True/False] |
| `IS_PED_STOPPED` | `bool IS_PED_STOPPED(int ped)` | bool | Returns true if the ped doesn't do any movement. If the ped is being pushed forwards by using APPLY_... |
| `IS_PED_SWIMMING` | `bool IS_PED_SWIMMING(int ped)` | bool | - |
| `IS_PED_SWIMMING_UNDER_WATER` | `bool IS_PED_SWIMMING_UNDER_WATER(int ped)` | bool | - |
| `IS_PED_SWITCHING_WEAPON` | `bool IS_PED_SWITCHING_WEAPON(int Ped)` | bool | - |
| `IS_PED_TAKING_OFF_HELMET` | `bool IS_PED_TAKING_OFF_HELMET(int ped)` | bool | - |
| `IS_PED_TRACKED` | `bool IS_PED_TRACKED(int ped)` | bool | - |
| `IS_PED_TRYING_TO_ENTER_A_LOCKED_VEHICLE` | `bool IS_PED_TRYING_TO_ENTER_A_LOCKED_VEHICLE(int ped)` | bool | - |
| `IS_PED_USING_ACTION_MODE` | `bool IS_PED_USING_ACTION_MODE(int ped)` | bool | - |
| `IS_PED_USING_ANY_SCENARIO` | `bool IS_PED_USING_ANY_SCENARIO(int ped)` | bool | - |
| `IS_PED_USING_SCENARIO` | `bool IS_PED_USING_SCENARIO(int ped, string scenario)` | bool | Full list of ped scenarios by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/s... |
| `IS_PED_VAULTING` | `bool IS_PED_VAULTING(int ped)` | bool | - |
| `IS_PED_WEARING_HELMET` | `bool IS_PED_WEARING_HELMET(int ped)` | bool | Returns true if the ped passed through the parenthesis is wearing a helmet. |
| `IS_SCRIPTED_SCENARIO_PED_USING_CONDITIONAL_ANIM` | `bool IS_SCRIPTED_SCENARIO_PED_USING_CONDITIONAL_ANIM(int ped, string animDict, string anim)` | bool | Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-... |
| `IS_SYNCHRONIZED_SCENE_HOLD_LAST_FRAME` | `bool IS_SYNCHRONIZED_SCENE_HOLD_LAST_FRAME(int sceneID)` | bool | - |
| `IS_SYNCHRONIZED_SCENE_LOOPED` | `bool IS_SYNCHRONIZED_SCENE_LOOPED(int sceneID)` | bool | - |
| `IS_SYNCHRONIZED_SCENE_RUNNING` | `bool IS_SYNCHRONIZED_SCENE_RUNNING(int sceneId)` | bool | Returns true if a synchronized scene is running |
| `IS_TARGET_PED_IN_PERCEPTION_AREA` | `bool IS_TARGET_PED_IN_PERCEPTION_AREA(int ped, int targetPed, float p2, float p3, float p4, float p5)` | bool | - |
| `IS_TRACKED_PED_VISIBLE` | `bool IS_TRACKED_PED_VISIBLE(int ped)` | bool | returns whether or not a ped is visible within your FOV, not this check auto's to false after a cert... |
| `IS_USING_PED_SCUBA_GEAR_VARIATION` | `bool IS_USING_PED_SCUBA_GEAR_VARIATION(object p0)` | bool | - |
| `KNOCK_OFF_PED_PROP` | `void KNOCK_OFF_PED_PROP(int ped, bool p1, bool p2, bool p3, bool p4)` | void | List of component/props ID<br>gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html |
| `KNOCK_PED_OFF_VEHICLE` | `void KNOCK_PED_OFF_VEHICLE(int ped)` | void | - |
| `MARK_PED_DECORATIONS_AS_CLONED_FROM_LOCAL_PLAYER` | `void MARK_PED_DECORATIONS_AS_CLONED_FROM_LOCAL_PLAYER(int ped, bool p1)` | void | - |
| `PED_HAS_SEXINESS_FLAG_SET` | `bool PED_HAS_SEXINESS_FLAG_SET(int ped, int sexinessFlag)` | bool | Checks if the specified sexiness flag is set<br><br>enum eSexinessFlags<br>{<br> SF_JEER_AT_HOT_PED = 0,<br> SF_HUR... |
| `PLAY_FACIAL_ANIM` | `void PLAY_FACIAL_ANIM(int ped, string animName, string animDict)` | void | Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-... |
| `REGISTER_HATED_TARGETS_AROUND_PED` | `void REGISTER_HATED_TARGETS_AROUND_PED(int ped, float radius)` | void | Based on TASK_COMBAT_HATED_TARGETS_AROUND_PED, the parameters are likely similar (PedHandle, and are... |
| `REGISTER_PEDHEADSHOT` | `int REGISTER_PEDHEADSHOT(int ped)` | int | gtaforums.com/topic/885580-ped-headshotmugshot-txd/ |
| `REGISTER_PEDHEADSHOT_HIRES` | `int REGISTER_PEDHEADSHOT_HIRES(int ped)` | int | - |
| `REGISTER_PEDHEADSHOT_TRANSPARENT` | `int REGISTER_PEDHEADSHOT_TRANSPARENT(int ped)` | int | Similar to REGISTER_PEDHEADSHOT but creates a transparent background instead of black. Example: http... |
| `REGISTER_TARGET` | `void REGISTER_TARGET(int ped, int target)` | void | PED::REGISTER_TARGET(l_216, PLAYER::PLAYER_PED_ID()); from re_prisonbreak.txt.<br><br>l_216 = RECSBRobber1 |
| `RELEASE_PEDHEADSHOT_IMG_UPLOAD` | `void RELEASE_PEDHEADSHOT_IMG_UPLOAD(int id)` | void | - |
| `RELEASE_PED_PRELOAD_PROP_DATA` | `void RELEASE_PED_PRELOAD_PROP_DATA(int ped)` | void | - |
| `RELEASE_PED_PRELOAD_VARIATION_DATA` | `void RELEASE_PED_PRELOAD_VARIATION_DATA(int ped)` | void | - |
| `REMOVE_ACTION_MODE_ASSET` | `void REMOVE_ACTION_MODE_ASSET(string asset)` | void | - |
| `REMOVE_GROUP` | `void REMOVE_GROUP(int groupId)` | void | - |
| `REMOVE_PED_DEFENSIVE_AREA` | `void REMOVE_PED_DEFENSIVE_AREA(int ped, bool toggle)` | void | Ped will no longer get angry when you stay near him. |
| `REMOVE_PED_ELEGANTLY` | `void REMOVE_PED_ELEGANTLY(Ped* ped)` | void | Judging purely from a quick disassembly, if the ped is in a vehicle, the ped will be deleted immedia... |
| `REMOVE_PED_FROM_GROUP` | `void REMOVE_PED_FROM_GROUP(int ped)` | void | - |
| `REMOVE_PED_HELMET` | `void REMOVE_PED_HELMET(int ped, bool instantly)` | void | - |
| `REMOVE_PED_PREFERRED_COVER_SET` | `void REMOVE_PED_PREFERRED_COVER_SET(int ped)` | void | - |
| `REMOVE_RELATIONSHIP_GROUP` | `void REMOVE_RELATIONSHIP_GROUP(uint groupHash)` | void | - |
| `REMOVE_SCENARIO_BLOCKING_AREA` | `void REMOVE_SCENARIO_BLOCKING_AREA(object p0, bool p1)` | void | - |
| `REMOVE_SCENARIO_BLOCKING_AREAS` | `void REMOVE_SCENARIO_BLOCKING_AREAS()` | void | - |
| `REMOVE_STEALTH_MODE_ASSET` | `void REMOVE_STEALTH_MODE_ASSET(string asset)` | void | - |
| `REQUEST_ACTION_MODE_ASSET` | `void REQUEST_ACTION_MODE_ASSET(string asset)` | void | - |
| `REQUEST_PEDHEADSHOT_IMG_UPLOAD` | `bool REQUEST_PEDHEADSHOT_IMG_UPLOAD(int id)` | bool | - |
| `REQUEST_PED_RESTRICTED_VEHICLE_VISIBILITY_TRACKING` | `void REQUEST_PED_RESTRICTED_VEHICLE_VISIBILITY_TRACKING(int ped, bool p1)` | void | - |
| `REQUEST_PED_USE_SMALL_BBOX_VISIBILITY_TRACKING` | `void REQUEST_PED_USE_SMALL_BBOX_VISIBILITY_TRACKING(int ped, bool p1)` | void | - |
| `REQUEST_PED_VEHICLE_VISIBILITY_TRACKING` | `void REQUEST_PED_VEHICLE_VISIBILITY_TRACKING(int ped, bool p1)` | void | - |
| `REQUEST_PED_VISIBILITY_TRACKING` | `void REQUEST_PED_VISIBILITY_TRACKING(int ped)` | void | - |
| `REQUEST_RAGDOLL_BOUNDS_UPDATE` | `void REQUEST_RAGDOLL_BOUNDS_UPDATE(object p0, object p1)` | void | This native does absolutely nothing, just a nullsub |
| `REQUEST_STEALTH_MODE_ASSET` | `void REQUEST_STEALTH_MODE_ASSET(string asset)` | void | - |
| `RESET_AI_MELEE_WEAPON_DAMAGE_MODIFIER` | `void RESET_AI_MELEE_WEAPON_DAMAGE_MODIFIER()` | void | - |
| `RESET_AI_WEAPON_DAMAGE_MODIFIER` | `void RESET_AI_WEAPON_DAMAGE_MODIFIER()` | void | - |
| `RESET_FACIAL_IDLE_ANIM` | `void RESET_FACIAL_IDLE_ANIM(int ped)` | void | - |
| `RESET_GROUP_FORMATION_DEFAULT_SPACING` | `void RESET_GROUP_FORMATION_DEFAULT_SPACING(int groupHandle)` | void | - |
| `RESET_PED_IN_VEHICLE_CONTEXT` | `void RESET_PED_IN_VEHICLE_CONTEXT(int ped)` | void | - |
| `RESET_PED_LAST_VEHICLE` | `void RESET_PED_LAST_VEHICLE(int ped)` | void | Resets the value for the last vehicle driven by the Ped. |
| `RESET_PED_MOVEMENT_CLIPSET` | `void RESET_PED_MOVEMENT_CLIPSET(int ped, float p1)` | void | If p1 is 0.0, I believe you are back to normal. <br>If p1 is 1.0, it looks like you can only rotate the... |
| `RESET_PED_RAGDOLL_TIMER` | `void RESET_PED_RAGDOLL_TIMER(int ped)` | void | - |
| `RESET_PED_STRAFE_CLIPSET` | `void RESET_PED_STRAFE_CLIPSET(int ped)` | void | - |
| `RESET_PED_VISIBLE_DAMAGE` | `void RESET_PED_VISIBLE_DAMAGE(int ped)` | void | - |
| `RESET_PED_WEAPON_MOVEMENT_CLIPSET` | `void RESET_PED_WEAPON_MOVEMENT_CLIPSET(int ped)` | void | - |
| `RESURRECT_PED` | `void RESURRECT_PED(int ped)` | void | This function will simply bring the dead person back to life.<br><br>Try not to use it alone, since using ... |
| `REVIVE_INJURED_PED` | `void REVIVE_INJURED_PED(int ped)` | void | It will revive/cure the injured ped. The condition is ped must not be dead.<br><br>Upon setting and conver... |
| `SET_AI_MELEE_WEAPON_DAMAGE_MODIFIER` | `void SET_AI_MELEE_WEAPON_DAMAGE_MODIFIER(float modifier)` | void | - |
| `SET_AI_WEAPON_DAMAGE_MODIFIER` | `void SET_AI_WEAPON_DAMAGE_MODIFIER(float value)` | void | - |
| `SET_ALLOW_LOCKON_TO_PED_IF_FRIENDLY` | `void SET_ALLOW_LOCKON_TO_PED_IF_FRIENDLY(int ped, bool toggle)` | void | - |
| `SET_ALLOW_STUNT_JUMP_CAMERA` | `void SET_ALLOW_STUNT_JUMP_CAMERA(int ped, bool toggle)` | void | - |
| `SET_AMBIENT_LAW_PED_ACCURACY_MODIFIER` | `void SET_AMBIENT_LAW_PED_ACCURACY_MODIFIER(float multiplier)` | void | - |
| `SET_AMBIENT_PEDS_DROP_MONEY` | `void SET_AMBIENT_PEDS_DROP_MONEY(bool p0)` | void | - |
| `SET_BLOCKING_OF_NON_TEMPORARY_EVENTS` | `void SET_BLOCKING_OF_NON_TEMPORARY_EVENTS(int ped, bool toggle)` | void | works with TASK::TASK_SET_BLOCKING_OF_NON_TEMPORARY_EVENTS to make a ped completely oblivious to all... |
| `SET_BLOCKING_OF_NON_TEMPORARY_EVENTS_FOR_AMBIENT_PEDS_THIS_FRAME` | `void SET_BLOCKING_OF_NON_TEMPORARY_EVENTS_FOR_AMBIENT_PEDS_THIS_FRAME(bool p0)` | void | - |
| `SET_CAN_ATTACK_FRIENDLY` | `void SET_CAN_ATTACK_FRIENDLY(int ped, bool toggle, bool p2)` | void | Setting ped to true allows the ped to shoot "friendlies".<br><br>p2 set to true when toggle is also true s... |
| `SET_COMBAT_FLOAT` | `void SET_COMBAT_FLOAT(int ped, int combatType, float p2)` | void | combatType can be between 0-14. See GET_COMBAT_FLOAT below for a list of possible parameters. |
| `SET_COP_PERCEPTION_OVERRIDES` | `void SET_COP_PERCEPTION_OVERRIDES(float seeingRange, float seeingRangePeripheral, float hearingRange, float visualFieldMinAzimuthAngle, float visualFieldMaxAzimuthAngle, float fieldOfGazeMaxAngle, float p6)` | void | - |
| `SET_CORPSE_RAGDOLL_FRICTION` | `void SET_CORPSE_RAGDOLL_FRICTION(int ped, float p1)` | void | - |
| `SET_CREATE_RANDOM_COPS` | `void SET_CREATE_RANDOM_COPS(bool toggle)` | void | - |
| `SET_CREATE_RANDOM_COPS_NOT_ON_SCENARIOS` | `void SET_CREATE_RANDOM_COPS_NOT_ON_SCENARIOS(bool toggle)` | void | - |
| `SET_CREATE_RANDOM_COPS_ON_SCENARIOS` | `void SET_CREATE_RANDOM_COPS_ON_SCENARIOS(bool toggle)` | void | - |
| `SET_DISABLE_HIGH_FALL_DEATH` | `void SET_DISABLE_HIGH_FALL_DEATH(int ped, bool toggle)` | void | - |
| `SET_DISABLE_PED_MAP_COLLISION` | `void SET_DISABLE_PED_MAP_COLLISION(int ped)` | void | - |
| `SET_DRIVER_ABILITY` | `void SET_DRIVER_ABILITY(int driver, float ability)` | void | The function specifically verifies the value is equal to, or less than 1.0f. If it is greater than 1... |
| `SET_DRIVER_AGGRESSIVENESS` | `void SET_DRIVER_AGGRESSIVENESS(int driver, float aggressiveness)` | void | range 0.0f - 1.0f |
| `SET_DRIVER_RACING_MODIFIER` | `void SET_DRIVER_RACING_MODIFIER(int driver, float modifier)` | void | Scripts use 0.2, 0.5 and 1.0. Value must be >= 0.0 && <= 1.0 |
| `SET_ENABLE_BOUND_ANKLES` | `void SET_ENABLE_BOUND_ANKLES(int ped, bool toggle)` | void | Used with SET_ENABLE_HANDCUFFS in decompiled scripts. From my observations, I have noticed that whil... |
| `SET_ENABLE_HANDCUFFS` | `void SET_ENABLE_HANDCUFFS(int ped, bool toggle)` | void | ped can not pull out a weapon when true |
| `SET_ENABLE_PED_ENVEFF_SCALE` | `void SET_ENABLE_PED_ENVEFF_SCALE(int ped, bool toggle)` | void | - |
| `SET_ENABLE_SCUBA` | `void SET_ENABLE_SCUBA(int ped, bool toggle)` | void | Enables diving motion when underwater. |
| `SET_FACIAL_CLIPSET` | `void SET_FACIAL_CLIPSET(int ped, string animDict)` | void | Clipsets:<br>facials@gen_female@base<br>facials@gen_male@base<br>facials@p_m_zero@base<br><br>Typically followed wi... |
| `SET_FACIAL_IDLE_ANIM_OVERRIDE` | `void SET_FACIAL_IDLE_ANIM_OVERRIDE(int ped, string animName, string animDict)` | void | Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-... |
| `SET_FORCE_FOOTSTEP_UPDATE` | `void SET_FORCE_FOOTSTEP_UPDATE(int ped, bool toggle)` | void | - |
| `SET_FORCE_STEP_TYPE` | `void SET_FORCE_STEP_TYPE(int ped, bool p1, int type, int p3)` | void | - |
| `SET_GROUP_FORMATION` | `void SET_GROUP_FORMATION(int groupId, int formationType)` | void | 0: Default<br>1: Circle Around Leader<br>2: Alternative Circle Around Leader<br>3: Line, with Leader at cente... |
| `SET_GROUP_FORMATION_SPACING` | `void SET_GROUP_FORMATION_SPACING(int groupId, float x, float y, float z)` | void | - |
| `SET_GROUP_SEPARATION_RANGE` | `void SET_GROUP_SEPARATION_RANGE(int groupHandle, float separationRange)` | void | Sets the range at which members will automatically leave the group. |
| `SET_HEAD_BLEND_EYE_COLOR` | `void SET_HEAD_BLEND_EYE_COLOR(int ped, int index)` | void | Used for freemode (online) characters.<br><br>For some reason, the scripts use a rounded float for the ind... |
| `SET_HEAD_BLEND_PALETTE_COLOR` | `void SET_HEAD_BLEND_PALETTE_COLOR(int ped, int r, int g, int b, int id)` | void | p4 seems to vary from 0 to 3.<br>Preview: https://gfycat.com/MaleRareAmazonparrot |
| `SET_HEALTH_SNACKS_CARRIED_BY_ALL_NEW_PEDS` | `void SET_HEALTH_SNACKS_CARRIED_BY_ALL_NEW_PEDS(float p0, object p1)` | void | Related to Peds dropping pickup_health_snack; p0 is a value between [0.0, 1.0] that corresponds to d... |
| `SET_IK_TARGET` | `void SET_IK_TARGET(int ped, int ikIndex, int entityLookAt, int boneLookAt, float offsetX, float offsetY, float offsetZ, object p7, int blendInDuration, int blendOutDuration)` | void | - |
| `SET_LADDER_CLIMB_INPUT_STATE` | `void SET_LADDER_CLIMB_INPUT_STATE(int ped, int p1)` | void | Only appears in lamar1 script. |
| `SET_MOVEMENT_MODE_OVERRIDE` | `void SET_MOVEMENT_MODE_OVERRIDE(int ped, string name)` | void | name: "MP_FEMALE_ACTION" found multiple times in the b617d scripts. |
| `SET_PED_ACCURACY` | `void SET_PED_ACCURACY(int ped, int accuracy)` | void | accuracy = 0-100, 100 being perfectly accurate |
| `SET_PED_ALERTNESS` | `void SET_PED_ALERTNESS(int ped, int value)` | void | value ranges from 0 to 3. |
| `SET_PED_ALLOWED_TO_DUCK` | `void SET_PED_ALLOWED_TO_DUCK(int ped, bool toggle)` | void | - |
| `SET_PED_ALLOW_HURT_COMBAT_FOR_ALL_MISSION_PEDS` | `void SET_PED_ALLOW_HURT_COMBAT_FOR_ALL_MISSION_PEDS(bool toggle)` | void | ntoggle was always false except in one instance (b678).<br><br>The one time this is set to true seems to d... |
| `SET_PED_ALLOW_MINOR_REACTIONS_AS_MISSION_PED` | `void SET_PED_ALLOW_MINOR_REACTIONS_AS_MISSION_PED(int ped, bool toggle)` | void | - |
| `SET_PED_ALLOW_VEHICLES_OVERRIDE` | `void SET_PED_ALLOW_VEHICLES_OVERRIDE(int ped, bool toggle)` | void | - |
| `SET_PED_ALTERNATE_MOVEMENT_ANIM` | `void SET_PED_ALTERNATE_MOVEMENT_ANIM(int ped, int stance, string animDictionary, string animationName, float p4, bool p5)` | void | stance:<br>0 = idle<br>1 = walk<br>2 = running<br><br>p5 = usually set to true<br><br>Full list of animation dictionaries... |
| `SET_PED_ALTERNATE_WALK_ANIM` | `void SET_PED_ALTERNATE_WALK_ANIM(int ped, string animDict, string animName, float p3, bool p4)` | void | Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-... |
| `SET_PED_ANGLED_DEFENSIVE_AREA` | `void SET_PED_ANGLED_DEFENSIVE_AREA(int ped, float p1, float p2, float p3, float p4, float p5, float p6, float p7, bool p8, bool p9)` | void | - |
| `SET_PED_AO_BLOB_RENDERING` | `void SET_PED_AO_BLOB_RENDERING(int ped, bool toggle)` | void | Enable/disable ped shadow (ambient occlusion). https://gfycat.com/thankfulesteemedgecko |
| `SET_PED_ARMOUR` | `void SET_PED_ARMOUR(int ped, int amount)` | void | Sets the armor of the specified ped.<br><br>ped: The Ped to set the armor of.<br>amount: A value between 0 an... |
| `SET_PED_AS_COP` | `void SET_PED_AS_COP(int ped, bool toggle)` | void | Turns the desired ped into a cop. If you use this on the player ped, you will become almost invisibl... |
| `SET_PED_AS_ENEMY` | `void SET_PED_AS_ENEMY(int ped, bool toggle)` | void | - |
| `SET_PED_AS_GROUP_LEADER` | `void SET_PED_AS_GROUP_LEADER(int ped, int groupId)` | void | - |
| `SET_PED_AS_GROUP_MEMBER` | `void SET_PED_AS_GROUP_MEMBER(int ped, int groupId)` | void | - |
| `SET_PED_BLEND_FROM_PARENTS` | `void SET_PED_BLEND_FROM_PARENTS(int ped, object p1, object p2, float p3, float p4)` | void | - |
| `SET_PED_BLOCKS_PATHING_WHEN_DEAD` | `void SET_PED_BLOCKS_PATHING_WHEN_DEAD(int ped, bool toggle)` | void | - |
| `SET_PED_BOUNDS_ORIENTATION` | `void SET_PED_BOUNDS_ORIENTATION(int ped, float p1, float p2, float x, float y, float z)` | void | - |
| `SET_PED_CAN_ARM_IK` | `void SET_PED_CAN_ARM_IK(int ped, bool toggle)` | void | - |
| `SET_PED_CAN_BE_DRAGGED_OUT` | `void SET_PED_CAN_BE_DRAGGED_OUT(int ped, bool toggle)` | void | - |
| `SET_PED_CAN_BE_KNOCKED_OFF_BIKE` | `void SET_PED_CAN_BE_KNOCKED_OFF_BIKE(object p0, object p1)` | void | This native does absolutely nothing, just a nullsub |
| `SET_PED_CAN_BE_KNOCKED_OFF_VEHICLE` | `void SET_PED_CAN_BE_KNOCKED_OFF_VEHICLE(int ped, int state)` | void | state: https://alloc8or.re/gta5/doc/enums/eKnockOffVehicle.txt |
| `SET_PED_CAN_BE_SHOT_IN_VEHICLE` | `void SET_PED_CAN_BE_SHOT_IN_VEHICLE(int ped, bool toggle)` | void | - |
| `SET_PED_CAN_BE_TARGETED_WHEN_INJURED` | `void SET_PED_CAN_BE_TARGETED_WHEN_INJURED(int ped, bool toggle)` | void | - |
| `SET_PED_CAN_BE_TARGETED_WITHOUT_LOS` | `void SET_PED_CAN_BE_TARGETED_WITHOUT_LOS(int ped, bool toggle)` | void | - |
| `SET_PED_CAN_BE_TARGETTED` | `void SET_PED_CAN_BE_TARGETTED(int ped, bool toggle)` | void | - |
| `SET_PED_CAN_BE_TARGETTED_BY_PLAYER` | `void SET_PED_CAN_BE_TARGETTED_BY_PLAYER(int ped, int player, bool toggle)` | void | - |
| `SET_PED_CAN_BE_TARGETTED_BY_TEAM` | `void SET_PED_CAN_BE_TARGETTED_BY_TEAM(int ped, int team, bool toggle)` | void | - |
| `SET_PED_CAN_BODY_RECOIL_IK` | `void SET_PED_CAN_BODY_RECOIL_IK(int ped, bool toggle)` | void | - |
| `SET_PED_CAN_COWER_IN_COVER` | `void SET_PED_CAN_COWER_IN_COVER(int ped, bool toggle)` | void | It simply makes the said ped to cower behind cover object(wall, desk, car)<br><br>Peds flee attributes mus... |
| `SET_PED_CAN_EVASIVE_DIVE` | `void SET_PED_CAN_EVASIVE_DIVE(int ped, bool toggle)` | void | - |
| `SET_PED_CAN_HEAD_IK` | `void SET_PED_CAN_HEAD_IK(int ped, bool toggle)` | void | - |
| `SET_PED_CAN_LEG_IK` | `void SET_PED_CAN_LEG_IK(int ped, bool toggle)` | void | - |
| `SET_PED_CAN_LOSE_PROPS_ON_DAMAGE` | `void SET_PED_CAN_LOSE_PROPS_ON_DAMAGE(int ped, bool toggle, int p2)` | void | - |
| `SET_PED_CAN_PEEK_IN_COVER` | `void SET_PED_CAN_PEEK_IN_COVER(int ped, bool toggle)` | void | - |
| `SET_PED_CAN_PLAY_AMBIENT_ANIMS` | `void SET_PED_CAN_PLAY_AMBIENT_ANIMS(int ped, bool toggle)` | void | - |
| `SET_PED_CAN_PLAY_AMBIENT_BASE_ANIMS` | `void SET_PED_CAN_PLAY_AMBIENT_BASE_ANIMS(int ped, bool toggle)` | void | - |
| `SET_PED_CAN_PLAY_GESTURE_ANIMS` | `void SET_PED_CAN_PLAY_GESTURE_ANIMS(int ped, bool toggle)` | void | - |
| `SET_PED_CAN_PLAY_IN_CAR_IDLES` | `void SET_PED_CAN_PLAY_IN_CAR_IDLES(int ped, bool toggle)` | void | Toggles config flag CPED_CONFIG_FLAG_CanPlayInCarIdles. |
| `SET_PED_CAN_PLAY_VISEME_ANIMS` | `void SET_PED_CAN_PLAY_VISEME_ANIMS(int ped, bool toggle, bool p2)` | void | p2 usually 0 |
| `SET_PED_CAN_RAGDOLL` | `void SET_PED_CAN_RAGDOLL(int ped, bool toggle)` | void | - |
| `SET_PED_CAN_RAGDOLL_FROM_PLAYER_IMPACT` | `void SET_PED_CAN_RAGDOLL_FROM_PLAYER_IMPACT(int ped, bool toggle)` | void | - |
| `SET_PED_CAN_SMASH_GLASS` | `void SET_PED_CAN_SMASH_GLASS(int ped, bool p1, bool p2)` | void | - |
| `SET_PED_CAN_SWITCH_WEAPON` | `void SET_PED_CAN_SWITCH_WEAPON(int ped, bool toggle)` | void | - |
| `SET_PED_CAN_TELEPORT_TO_GROUP_LEADER` | `void SET_PED_CAN_TELEPORT_TO_GROUP_LEADER(int pedHandle, int groupHandle, bool toggle)` | void | This only will teleport the ped to the group leader if the group leader teleports (sets coords).<br><br>On... |
| `SET_PED_CAN_TORSO_IK` | `void SET_PED_CAN_TORSO_IK(int ped, bool toggle)` | void | - |
| `SET_PED_CAN_TORSO_REACT_IK` | `void SET_PED_CAN_TORSO_REACT_IK(int ped, bool p1)` | void | - |
| `SET_PED_CAN_TORSO_VEHICLE_IK` | `void SET_PED_CAN_TORSO_VEHICLE_IK(int ped, bool p1)` | void | - |
| `SET_PED_CAN_USE_AUTO_CONVERSATION_LOOKAT` | `void SET_PED_CAN_USE_AUTO_CONVERSATION_LOOKAT(int ped, bool toggle)` | void | - |
| `SET_PED_CAPSULE` | `void SET_PED_CAPSULE(int ped, float value)` | void | Overrides the ped's collision capsule radius for the current tick.<br>Must be called every tick to be e... |
| `SET_PED_CLOTH_PACKAGE_INDEX` | `void SET_PED_CLOTH_PACKAGE_INDEX(object p0, object p1)` | void | - |
| `SET_PED_CLOTH_PIN_FRAMES` | `void SET_PED_CLOTH_PIN_FRAMES(object p0, object p1)` | void | - |
| `SET_PED_CLOTH_PRONE` | `void SET_PED_CLOTH_PRONE(object p0, bool p1)` | void | - |
| `SET_PED_COMBAT_ABILITY` | `void SET_PED_COMBAT_ABILITY(int ped, int abilityLevel)` | void | enum eCombatAbility // 0xE793438C<br>{<br>	CA_Poor,<br>	CA_Average,<br>	CA_Professional,<br>	CA_NumTypes<br>}; |
| `SET_PED_COMBAT_ATTRIBUTES` | `void SET_PED_COMBAT_ATTRIBUTES(int ped, int attributeId, bool enabled)` | void | enum eCombatAttributes // 0x0E8E7201<br>{<br>	BF_CanUseCover = 0,<br>	BF_CanUseVehicles = 1,<br>	BF_CanDoDriveby... |
| `SET_PED_COMBAT_MOVEMENT` | `void SET_PED_COMBAT_MOVEMENT(int ped, int combatMovement)` | void | enum eCombatMovement // 0x4F456B61<br>{<br>	CM_Stationary,<br>	CM_Defensive,<br>	CM_WillAdvance,<br>	CM_WillRetreat... |
| `SET_PED_COMBAT_RANGE` | `void SET_PED_COMBAT_RANGE(int ped, int combatRange)` | void | enum eCombatRange // 0xB69160F5<br>{<br>	CR_Near,<br>	CR_Medium,<br>	CR_Far,<br>	CR_VeryFar,<br>	CR_NumRanges<br>}; |
| `SET_PED_COMPONENT_VARIATION` | `void SET_PED_COMPONENT_VARIATION(int ped, int componentId, int drawableId, int textureId, int paletteId)` | void | paletteId: 0 to 3.<br><br>componentId:<br>enum ePedVarComp<br>{<br>	PV_COMP_INVALID = -1,<br>	PV_COMP_HEAD,<br>	PV_COMP_B... |
| `SET_PED_CONFIG_FLAG` | `void SET_PED_CONFIG_FLAG(int ped, int flagId, bool value)` | void | enum ePedConfigFlags<br>{<br>	_CPED_CONFIG_FLAG_0xC63DE95E = 1,<br>	CPED_CONFIG_FLAG_NoCriticalHits = 2,<br>	CPE... |
| `SET_PED_COORDS_KEEP_VEHICLE` | `void SET_PED_COORDS_KEEP_VEHICLE(int ped, float posX, float posY, float posZ)` | void | teleports ped to coords along with the vehicle ped is in |
| `SET_PED_COORDS_NO_GANG` | `void SET_PED_COORDS_NO_GANG(int ped, float posX, float posY, float posZ)` | void | - |
| `SET_PED_COWER_HASH` | `void SET_PED_COWER_HASH(int ped, string p1)` | void | p1: Only "CODE_HUMAN_STAND_COWER" found in the b617d scripts. |
| `SET_PED_DEFAULT_COMPONENT_VARIATION` | `void SET_PED_DEFAULT_COMPONENT_VARIATION(int ped)` | void | Sets Ped Default Clothes |
| `SET_PED_DEFENSIVE_AREA_ATTACHED_TO_PED` | `void SET_PED_DEFENSIVE_AREA_ATTACHED_TO_PED(int ped, int attachPed, float p2, float p3, float p4, float p5, float p6, float p7, float p8, bool p9, bool p10)` | void | - |
| `SET_PED_DEFENSIVE_AREA_DIRECTION` | `void SET_PED_DEFENSIVE_AREA_DIRECTION(int ped, float p1, float p2, float p3, bool p4)` | void | - |
| `SET_PED_DEFENSIVE_SPHERE_ATTACHED_TO_PED` | `void SET_PED_DEFENSIVE_SPHERE_ATTACHED_TO_PED(int ped, int target, float xOffset, float yOffset, float zOffset, float radius, bool p6)` | void | - |
| `SET_PED_DEFENSIVE_SPHERE_ATTACHED_TO_VEHICLE` | `void SET_PED_DEFENSIVE_SPHERE_ATTACHED_TO_VEHICLE(int ped, int target, float xOffset, float yOffset, float zOffset, float radius, bool p6)` | void | - |
| `SET_PED_DENSITY_MULTIPLIER_THIS_FRAME` | `void SET_PED_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier)` | void | - |
| `SET_PED_DESIRED_HEADING` | `void SET_PED_DESIRED_HEADING(int ped, float heading)` | void | - |
| `SET_PED_DIES_INSTANTLY_IN_WATER` | `void SET_PED_DIES_INSTANTLY_IN_WATER(int ped, bool toggle)` | void | - |
| `SET_PED_DIES_IN_SINKING_VEHICLE` | `void SET_PED_DIES_IN_SINKING_VEHICLE(int ped, bool toggle)` | void | - |
| `SET_PED_DIES_IN_VEHICLE` | `void SET_PED_DIES_IN_VEHICLE(int ped, bool toggle)` | void | - |
| `SET_PED_DIES_IN_WATER` | `void SET_PED_DIES_IN_WATER(int ped, bool toggle)` | void | - |
| `SET_PED_DIES_WHEN_INJURED` | `void SET_PED_DIES_WHEN_INJURED(int ped, bool toggle)` | void | - |
| `SET_PED_DRIVE_BY_CLIPSET_OVERRIDE` | `void SET_PED_DRIVE_BY_CLIPSET_OVERRIDE(int ped, string clipset)` | void | - |
| `SET_PED_DUCKING` | `void SET_PED_DUCKING(int ped, bool toggle)` | void | This is the SET_CHAR_DUCKING from GTA IV, that makes Peds duck. This function does nothing in GTA V.... |
| `SET_PED_EMISSIVE_SCALE` | `void SET_PED_EMISSIVE_SCALE(int ped, float intensity)` | void | intensity: 0.0f - 1.0f<br><br>This native sets the emissive intensity for the given ped. It is used for di... |
| `SET_PED_ENABLE_CREW_EMBLEM` | `void SET_PED_ENABLE_CREW_EMBLEM(int ped, bool toggle)` | void | - |
| `SET_PED_ENABLE_WEAPON_BLOCKING` | `void SET_PED_ENABLE_WEAPON_BLOCKING(int ped, bool toggle)` | void | - |
| `SET_PED_ENVEFF_COLOR_MODULATOR` | `void SET_PED_ENVEFF_COLOR_MODULATOR(int ped, int p1, int p2, int p3)` | void | Something related to the environmental effects natives.<br>In the "agency_heist3b" script, p1 - p3 are ... |
| `SET_PED_ENVEFF_CPV_ADD` | `void SET_PED_ENVEFF_CPV_ADD(int ped, float p1)` | void | In agency_heist3b.c4, its like this 90% of the time:<br><br>PED::SET_PED_ENVEFF_CPV_ADD(ped, 0.099);<br>PED::... |
| `SET_PED_ENVEFF_SCALE` | `void SET_PED_ENVEFF_SCALE(int ped, float value)` | void | Values look to be between 0.0 and 1.0<br>From decompiled scripts: 0.0, 0.6, 0.65, 0.8, 1.0<br><br>You are cor... |
| `SET_PED_FIRING_PATTERN` | `void SET_PED_FIRING_PATTERN(int ped, uint patternHash)` | void | FIRING_PATTERN_BURST_FIRE = 0xD6FF6D61 ( 1073727030 )<br>FIRING_PATTERN_BURST_FIRE_IN_COVER = 0x026321F... |
| `SET_PED_FLEE_ATTRIBUTES` | `void SET_PED_FLEE_ATTRIBUTES(int ped, int attributeFlags, bool enable)` | void | bit 1 (0x2) = use vehicle<br>bit 15 (0x8000) = force cower |
| `SET_PED_GENERATES_DEAD_BODY_EVENTS` | `void SET_PED_GENERATES_DEAD_BODY_EVENTS(int ped, bool toggle)` | void | - |
| `SET_PED_GESTURE_GROUP` | `void SET_PED_GESTURE_GROUP(int ped, string animGroupGesture)` | void | From the scripts:<br>PED::SET_PED_GESTURE_GROUP(PLAYER::PLAYER_PED_ID(),<br>"ANIM_GROUP_GESTURE_MISS_FRA0"... |
| `SET_PED_GET_OUT_UPSIDE_DOWN_VEHICLE` | `void SET_PED_GET_OUT_UPSIDE_DOWN_VEHICLE(int ped, bool toggle)` | void | - |
| `SET_PED_GRAVITY` | `void SET_PED_GRAVITY(int ped, bool toggle)` | void | enable or disable the gravity of a ped<br><br>Examples:<br>PED::SET_PED_GRAVITY(PLAYER::PLAYER_PED_ID(), 0x00... |
| `SET_PED_GROUP_MEMBER_PASSENGER_INDEX` | `void SET_PED_GROUP_MEMBER_PASSENGER_INDEX(int ped, int index)` | void | - |
| `SET_PED_HAIR_TINT` | `void SET_PED_HAIR_TINT(int ped, int colorID, int highlightColorID)` | void | - |
| `SET_PED_HEAD_BLEND_DATA` | `void SET_PED_HEAD_BLEND_DATA(int ped, int shapeFirstID, int shapeSecondID, int shapeThirdID, int skinFirstID, int skinSecondID, int skinThirdID, float shapeMix, float skinMix, float thirdMix, bool isParent)` | void | The "shape" parameters control the shape of the ped's face. The "skin" parameters control the skin t... |
| `SET_PED_HEAD_OVERLAY` | `void SET_PED_HEAD_OVERLAY(int ped, int overlayID, int index, float opacity)` | void | OverlayID ranges from 0 to 12, index from 0 to _GET_NUM_OVERLAY_VALUES(overlayID)-1, and opacity fro... |
| `SET_PED_HEAD_OVERLAY_TINT` | `void SET_PED_HEAD_OVERLAY_TINT(int ped, int overlayID, int colorType, int colorID, int secondColorID)` | void | <br><br>ColorType is 1 for eyebrows, beards, and chest hair; 2 for blush and lipstick; and 0 otherwise, th... |
| `SET_PED_HEALTH_PENDING_LAST_DAMAGE_EVENT_OVERRIDE_FLAG` | `void SET_PED_HEALTH_PENDING_LAST_DAMAGE_EVENT_OVERRIDE_FLAG(bool toggle)` | void | - |
| `SET_PED_HEARING_RANGE` | `void SET_PED_HEARING_RANGE(int ped, float value)` | void | - |
| `SET_PED_HEATSCALE_OVERRIDE` | `void SET_PED_HEATSCALE_OVERRIDE(int ped, float heatScale)` | void | - |
| `SET_PED_HELMET` | `void SET_PED_HELMET(int ped, bool canWearHelmet)` | void | - |
| `SET_PED_HELMET_FLAG` | `void SET_PED_HELMET_FLAG(int ped, int helmetFlag)` | void | - |
| `SET_PED_HELMET_PROP_INDEX` | `void SET_PED_HELMET_PROP_INDEX(int ped, int propIndex, bool p2)` | void | List of component/props ID<br>gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html |
| `SET_PED_HELMET_TEXTURE_INDEX` | `void SET_PED_HELMET_TEXTURE_INDEX(int ped, int textureIndex)` | void | - |
| `SET_PED_HELMET_VISOR_PROP_INDICES` | `void SET_PED_HELMET_VISOR_PROP_INDICES(int ped, bool p1, int p2, int p3)` | void | - |
| `SET_PED_HIGHLY_PERCEPTIVE` | `void SET_PED_HIGHLY_PERCEPTIVE(int ped, bool toggle)` | void | - |
| `SET_PED_ID_RANGE` | `void SET_PED_ID_RANGE(int ped, float value)` | void | - |
| `SET_PED_INCREASED_AVOIDANCE_RADIUS` | `void SET_PED_INCREASED_AVOIDANCE_RADIUS(int ped)` | void | - |
| `SET_PED_INJURED_ON_GROUND_BEHAVIOUR` | `void SET_PED_INJURED_ON_GROUND_BEHAVIOUR(int ped, float p1)` | void | - |
| `SET_PED_INTO_VEHICLE` | `void SET_PED_INTO_VEHICLE(int ped, int vehicle, int seatIndex)` | void | Ped: The ped to warp.<br>vehicle: The vehicle to warp the ped into.<br>Seat_Index: [-1 is driver seat, -2 ... |
| `SET_PED_IN_VEHICLE_CONTEXT` | `void SET_PED_IN_VEHICLE_CONTEXT(int ped, uint context)` | void | PED::SET_PED_IN_VEHICLE_CONTEXT(l_128, MISC::GET_HASH_KEY("MINI_PROSTITUTE_LOW_PASSENGER"));<br>PED::SE... |
| `SET_PED_IS_AVOIDED_BY_OTHERS` | `void SET_PED_IS_AVOIDED_BY_OTHERS(object p0, bool p1)` | void | - |
| `SET_PED_IS_IGNORED_BY_AUTO_OPEN_DOORS` | `void SET_PED_IS_IGNORED_BY_AUTO_OPEN_DOORS(int ped, bool p1)` | void | - |
| `SET_PED_KEEP_TASK` | `void SET_PED_KEEP_TASK(int ped, bool toggle)` | void | - |
| `SET_PED_LEG_IK_MODE` | `void SET_PED_LEG_IK_MODE(int ped, int mode)` | void | "IK" stands for "Inverse kinematics." I assume this has something to do with how the ped uses his le... |
| `SET_PED_LOD_MULTIPLIER` | `void SET_PED_LOD_MULTIPLIER(int ped, float multiplier)` | void | - |
| `SET_PED_MAX_HEALTH` | `void SET_PED_MAX_HEALTH(int ped, int value)` | void | Sets the maximum health of a ped. |
| `SET_PED_MAX_MOVE_BLEND_RATIO` | `void SET_PED_MAX_MOVE_BLEND_RATIO(int ped, float value)` | void | - |
| `SET_PED_MAX_TIME_IN_WATER` | `void SET_PED_MAX_TIME_IN_WATER(int ped, float value)` | void | - |
| `SET_PED_MAX_TIME_UNDERWATER` | `void SET_PED_MAX_TIME_UNDERWATER(int ped, float value)` | void | - |
| `SET_PED_MICRO_MORPH` | `void SET_PED_MICRO_MORPH(int ped, int index, float scale)` | void | Sets the various freemode face features, e.g. nose length, chin shape. Scale ranges from -1.0 to 1.0... |
| `SET_PED_MIN_GROUND_TIME_FOR_STUNGUN` | `void SET_PED_MIN_GROUND_TIME_FOR_STUNGUN(int ped, int ms)` | void | Ped will stay on the ground after being stunned for at lest ms time. (in milliseconds) |
| `SET_PED_MIN_MOVE_BLEND_RATIO` | `void SET_PED_MIN_MOVE_BLEND_RATIO(int ped, float value)` | void | - |
| `SET_PED_MODEL_IS_SUPPRESSED` | `void SET_PED_MODEL_IS_SUPPRESSED(uint modelHash, bool toggle)` | void | Full list of peds by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/peds.json |
| `SET_PED_MONEY` | `void SET_PED_MONEY(int ped, int amount)` | void | Maximum possible amount of money on MP is 2000. ~JX<br><br>-----------------------------------------------... |
| `SET_PED_MOTION_BLUR` | `void SET_PED_MOTION_BLUR(int ped, bool toggle)` | void | - |
| `SET_PED_MOTION_IN_COVER_CLIPSET_OVERRIDE` | `void SET_PED_MOTION_IN_COVER_CLIPSET_OVERRIDE(int ped, string p1)` | void | Found in the b617d scripts:<br>PED::SET_PED_MOTION_IN_COVER_CLIPSET_OVERRIDE(v_7, "trevor_heist_cover_2... |
| `SET_PED_MOVEMENT_CLIPSET` | `void SET_PED_MOVEMENT_CLIPSET(int ped, string clipSet, float transitionSpeed)` | void | transitionSpeed is the time in seconds it takes to transition from one movement clipset to another.	... |
| `SET_PED_MOVE_ANIMS_BLEND_OUT` | `void SET_PED_MOVE_ANIMS_BLEND_OUT(int ped)` | void | - |
| `SET_PED_MOVE_RATE_IN_WATER_OVERRIDE` | `void SET_PED_MOVE_RATE_IN_WATER_OVERRIDE(int ped, float p1)` | void | - |
| `SET_PED_MOVE_RATE_OVERRIDE` | `void SET_PED_MOVE_RATE_OVERRIDE(int ped, float value)` | void | Min: 0.00<br>Max: 10.00<br><br>Can be used in combo with fast run cheat.<br><br>When value is set to 10.00:<br>Sprinti... |
| `SET_PED_NAME_DEBUG` | `void SET_PED_NAME_DEBUG(int ped, string name)` | void | NOTE: Debugging functions are not present in the retail version of the game.<br><br>*untested but char *na... |
| `SET_PED_NEVER_LEAVES_GROUP` | `void SET_PED_NEVER_LEAVES_GROUP(int ped, bool toggle)` | void | - |
| `SET_PED_NON_CREATION_AREA` | `void SET_PED_NON_CREATION_AREA(float x1, float y1, float z1, float x2, float y2, float z2)` | void | The distance between these points, is the diagonal of a box (remember it's 3D). |
| `SET_PED_NO_TIME_DELAY_BEFORE_SHOT` | `void SET_PED_NO_TIME_DELAY_BEFORE_SHOT(object p0)` | void | - |
| `SET_PED_PANIC_EXIT_SCENARIO` | `bool SET_PED_PANIC_EXIT_SCENARIO(object p0, object p1, object p2, object p3)` | bool | - |
| `SET_PED_PARACHUTE_TINT_INDEX` | `void SET_PED_PARACHUTE_TINT_INDEX(int ped, int tintIndex)` | void | - |
| `SET_PED_PHONE_PALETTE_IDX` | `void SET_PED_PHONE_PALETTE_IDX(object p0, object p1)` | void | - |
| `SET_PED_PINNED_DOWN` | `bool SET_PED_PINNED_DOWN(int ped, bool pinned, int i)` | bool | i could be time. Only example in the decompiled scripts uses it as -1. |
| `SET_PED_PLAYS_HEAD_ON_HORN_ANIM_WHEN_DIES_IN_VEHICLE` | `void SET_PED_PLAYS_HEAD_ON_HORN_ANIM_WHEN_DIES_IN_VEHICLE(int ped, bool toggle)` | void | This native does absolutely nothing, just a nullsub |
| `SET_PED_PREFERRED_COVER_SET` | `void SET_PED_PREFERRED_COVER_SET(int ped, object itemSet)` | void | - |
| `SET_PED_PRELOAD_PROP_DATA` | `int SET_PED_PRELOAD_PROP_DATA(int ped, int componentId, int drawableId, int TextureId)` | int | List of component/props ID<br>gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html |
| `SET_PED_PRELOAD_VARIATION_DATA` | `int SET_PED_PRELOAD_VARIATION_DATA(int ped, int slot, int drawableId, int textureId)` | int | from extreme3.c4<br>PED::SET_PED_PRELOAD_VARIATION_DATA(PLAYER::PLAYER_PED_ID(), 8, PED::GET_PED_DRAWAB... |
| `SET_PED_PRIMARY_LOOKAT` | `void SET_PED_PRIMARY_LOOKAT(int ped, int lookAt)` | void | This is only called once in the scripts.<br><br>sub_1CD9(&l_49, 0, getElem(3, &l_34, 4), "MICHAEL", 0, 1);... |
| `SET_PED_PROP_INDEX` | `void SET_PED_PROP_INDEX(int ped, int componentId, int drawableId, int TextureId, bool attach, object p5)` | void | ComponentId can be set to various things based on what category you're wanting to set<br>enum PedPropsD... |
| `SET_PED_RAGDOLL_FORCE_FALL` | `void SET_PED_RAGDOLL_FORCE_FALL(int ped)` | void | - |
| `SET_PED_RAGDOLL_ON_COLLISION` | `void SET_PED_RAGDOLL_ON_COLLISION(int ped, bool toggle)` | void | Causes Ped to ragdoll on collision with any object (e.g Running into trashcan). If applied to player... |
| `SET_PED_RANDOM_COMPONENT_VARIATION` | `void SET_PED_RANDOM_COMPONENT_VARIATION(int ped, int p1)` | void | p1 is always 0 in R* scripts.<br><br>List of component/props ID<br>gtaxscripting.blogspot.com/2016/04/gta-v-p... |
| `SET_PED_RANDOM_PROPS` | `void SET_PED_RANDOM_PROPS(int ped)` | void | List of component/props ID<br>gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html |
| `SET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH` | `void SET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH(int ped, uint hash)` | void | - |
| `SET_PED_RELATIONSHIP_GROUP_HASH` | `void SET_PED_RELATIONSHIP_GROUP_HASH(int ped, uint hash)` | void | - |
| `SET_PED_RESERVE_PARACHUTE_TINT_INDEX` | `void SET_PED_RESERVE_PARACHUTE_TINT_INDEX(int ped, object p1)` | void | - |
| `SET_PED_RESET_FLAG` | `void SET_PED_RESET_FLAG(int ped, int flagId, bool doReset)` | void | PED::SET_PED_RESET_FLAG(PLAYER::PLAYER_PED_ID(), 240, 1);<br>Known values:<br>PRF_PreventGoingIntoStillInV... |
| `SET_PED_SCUBA_GEAR_VARIATION` | `void SET_PED_SCUBA_GEAR_VARIATION(int ped)` | void | This native sets a scuba mask for freemode models and an oxygen bottle for player_* models. It works... |
| `SET_PED_SEEING_RANGE` | `void SET_PED_SEEING_RANGE(int ped, float value)` | void | - |
| `SET_PED_SHOOTS_AT_COORD` | `void SET_PED_SHOOTS_AT_COORD(int ped, float x, float y, float z, bool toggle)` | void | - |
| `SET_PED_SHOOT_RATE` | `void SET_PED_SHOOT_RATE(int ped, int shootRate)` | void | shootRate 0-1000 |
| `SET_PED_SHOULD_IGNORE_SCENARIO_EXIT_COLLISION_CHECKS` | `void SET_PED_SHOULD_IGNORE_SCENARIO_EXIT_COLLISION_CHECKS(int ped, bool p1)` | void | - |
| `SET_PED_SHOULD_IGNORE_SCENARIO_NAV_CHECKS` | `void SET_PED_SHOULD_IGNORE_SCENARIO_NAV_CHECKS(object p0, bool p1)` | void | - |
| `SET_PED_SHOULD_PLAY_DIRECTED_NORMAL_SCENARIO_EXIT` | `bool SET_PED_SHOULD_PLAY_DIRECTED_NORMAL_SCENARIO_EXIT(object p0, object p1, object p2, object p3)` | bool | - |
| `SET_PED_SHOULD_PLAY_FLEE_SCENARIO_EXIT` | `bool SET_PED_SHOULD_PLAY_FLEE_SCENARIO_EXIT(int ped, object p1, object p2, object p3)` | bool | - |
| `SET_PED_SHOULD_PLAY_IMMEDIATE_SCENARIO_EXIT` | `void SET_PED_SHOULD_PLAY_IMMEDIATE_SCENARIO_EXIT(int ped)` | void | - |
| `SET_PED_SHOULD_PLAY_NORMAL_SCENARIO_EXIT` | `void SET_PED_SHOULD_PLAY_NORMAL_SCENARIO_EXIT(int ped)` | void | - |
| `SET_PED_SHOULD_PROBE_FOR_SCENARIO_EXITS_IN_ONE_FRAME` | `void SET_PED_SHOULD_PROBE_FOR_SCENARIO_EXITS_IN_ONE_FRAME(object p0, bool p1)` | void | - |
| `SET_PED_SPHERE_DEFENSIVE_AREA` | `void SET_PED_SPHERE_DEFENSIVE_AREA(int ped, float x, float y, float z, float radius, bool p5, bool p6)` | void | - |
| `SET_PED_STAY_IN_VEHICLE_WHEN_JACKED` | `void SET_PED_STAY_IN_VEHICLE_WHEN_JACKED(int ped, bool toggle)` | void | - |
| `SET_PED_STEALTH_MOVEMENT` | `void SET_PED_STEALTH_MOVEMENT(int ped, bool p1, string action)` | void | p1 is usually 0 in the scripts. action is either 0 or a pointer to "DEFAULT_ACTION". |
| `SET_PED_STEERS_AROUND_DEAD_BODIES` | `void SET_PED_STEERS_AROUND_DEAD_BODIES(int ped, bool toggle)` | void | - |
| `SET_PED_STEERS_AROUND_OBJECTS` | `void SET_PED_STEERS_AROUND_OBJECTS(int ped, bool toggle)` | void | - |
| `SET_PED_STEERS_AROUND_PEDS` | `void SET_PED_STEERS_AROUND_PEDS(int ped, bool toggle)` | void | - |
| `SET_PED_STEERS_AROUND_VEHICLES` | `void SET_PED_STEERS_AROUND_VEHICLES(int ped, bool toggle)` | void | - |
| `SET_PED_STEER_BIAS` | `void SET_PED_STEER_BIAS(int ped, float value)` | void | - |
| `SET_PED_STRAFE_CLIPSET` | `void SET_PED_STRAFE_CLIPSET(int ped, string clipSet)` | void | Full list of movement clipsets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/mast... |
| `SET_PED_SUFFERS_CRITICAL_HITS` | `void SET_PED_SUFFERS_CRITICAL_HITS(int ped, bool toggle)` | void | Ped no longer takes critical damage modifiers if set to FALSE.<br>Example: Headshotting a player no lon... |
| `SET_PED_SWEAT` | `void SET_PED_SWEAT(int ped, float sweat)` | void | Sweat is set to 100.0 or 0.0 in the decompiled scripts. |
| `SET_PED_TARGET_LOSS_RESPONSE` | `void SET_PED_TARGET_LOSS_RESPONSE(int ped, int responseType)` | void | enum eTargetLossResponseType<br>{<br>	TLR_ExitTask,<br>	TLR_NeverLoseTarget,<br>	TLR_SearchForTarget<br>}; |
| `SET_PED_TO_INFORM_RESPECTED_FRIENDS` | `void SET_PED_TO_INFORM_RESPECTED_FRIENDS(int ped, float radius, int maxFriends)` | void | - |
| `SET_PED_TO_LOAD_COVER` | `void SET_PED_TO_LOAD_COVER(int ped, bool toggle)` | void | - |
| `SET_PED_TO_RAGDOLL` | `bool SET_PED_TO_RAGDOLL(int ped, int time1, int time2, int ragdollType, bool p4, bool p5, bool p6)` | bool | p4/p5: Unused in TU27<br>Ragdoll Types:<br>**0**: CTaskNMRelax<br>**1**: CTaskNMScriptControl: Hardcoded not ... |
| `SET_PED_TO_RAGDOLL_WITH_FALL` | `bool SET_PED_TO_RAGDOLL_WITH_FALL(int ped, int time, int p2, int ragdollType, float x, float y, float z, float velocity, float p8, float p9, float p10, float p11, float p12, float p13)` | bool | Return variable is never used in R*'s scripts.<br><br>Not sure what p2 does. It seems like it would be a t... |
| `SET_PED_TREATED_AS_FRIENDLY` | `void SET_PED_TREATED_AS_FRIENDLY(object p0, object p1, object p2)` | void | - |
| `SET_PED_UPPER_BODY_DAMAGE_ONLY` | `void SET_PED_UPPER_BODY_DAMAGE_ONLY(int ped, bool toggle)` | void | - |
| `SET_PED_USING_ACTION_MODE` | `void SET_PED_USING_ACTION_MODE(int ped, bool p1, int p2, string action)` | void | p2 is usually -1 in the scripts. action is either 0 or "DEFAULT_ACTION". |
| `SET_PED_VEHICLE_FORCED_SEAT_USAGE` | `void SET_PED_VEHICLE_FORCED_SEAT_USAGE(int ped, int vehicle, int seatIndex, int flags, object p4)` | void | seatIndex must be <= 2 |
| `SET_PED_VISUAL_FIELD_CENTER_ANGLE` | `void SET_PED_VISUAL_FIELD_CENTER_ANGLE(int ped, float angle)` | void | - |
| `SET_PED_VISUAL_FIELD_MAX_ANGLE` | `void SET_PED_VISUAL_FIELD_MAX_ANGLE(int ped, float value)` | void | - |
| `SET_PED_VISUAL_FIELD_MAX_ELEVATION_ANGLE` | `void SET_PED_VISUAL_FIELD_MAX_ELEVATION_ANGLE(int ped, float angle)` | void | This native refers to the field of vision the ped has above them, starting at 0 degrees. 90f would l... |
| `SET_PED_VISUAL_FIELD_MIN_ANGLE` | `void SET_PED_VISUAL_FIELD_MIN_ANGLE(int ped, float value)` | void | - |
| `SET_PED_VISUAL_FIELD_MIN_ELEVATION_ANGLE` | `void SET_PED_VISUAL_FIELD_MIN_ELEVATION_ANGLE(int ped, float angle)` | void | This native refers to the field of vision the ped has below them, starting at 0 degrees. The angle v... |
| `SET_PED_VISUAL_FIELD_PERIPHERAL_RANGE` | `void SET_PED_VISUAL_FIELD_PERIPHERAL_RANGE(int ped, float range)` | void | - |
| `SET_PED_WEAPON_MOVEMENT_CLIPSET` | `void SET_PED_WEAPON_MOVEMENT_CLIPSET(int ped, string clipSet)` | void | - |
| `SET_PED_WETNESS` | `void SET_PED_WETNESS(int ped, float wetLevel)` | void | - |
| `SET_PED_WETNESS_ENABLED_THIS_FRAME` | `void SET_PED_WETNESS_ENABLED_THIS_FRAME(int ped)` | void | combined with PED::SET_PED_WETNESS_HEIGHT(), this native makes the ped drenched in water up to the h... |
| `SET_PED_WETNESS_HEIGHT` | `void SET_PED_WETNESS_HEIGHT(int ped, float height)` | void | It adds the wetness level to the player clothing/outfit. As if player just got out from water surfac... |
| `SET_PED_WILL_ONLY_ATTACK_WANTED_PLAYER` | `void SET_PED_WILL_ONLY_ATTACK_WANTED_PLAYER(object p0, object p1)` | void | - |
| `SET_POP_CONTROL_SPHERE_THIS_FRAME` | `void SET_POP_CONTROL_SPHERE_THIS_FRAME(float x, float y, float z, float min, float max)` | void | Min and max are usually 100.0 and 200.0 |
| `SET_RAGDOLL_BLOCKING_FLAGS` | `void SET_RAGDOLL_BLOCKING_FLAGS(int ped, int blockingFlag)` | void | Works for both player and peds,<br><br>enum eRagdollBlockingFlags<br>{<br> RBF_BULLET_IMPACT = 0,<br> RBF_VEHICLE_I... |
| `SET_RELATIONSHIP_BETWEEN_GROUPS` | `void SET_RELATIONSHIP_BETWEEN_GROUPS(int relationship, uint group1, uint group2)` | void | Sets the relationship between two groups. This should be called twice (once for each group).<br><br>Relati... |
| `SET_RELATIONSHIP_GROUP_AFFECTS_WANTED_LEVEL` | `void SET_RELATIONSHIP_GROUP_AFFECTS_WANTED_LEVEL(uint group, bool p1)` | void | - |
| `SET_SCENARIO_PEDS_SPAWN_IN_SPHERE_AREA` | `void SET_SCENARIO_PEDS_SPAWN_IN_SPHERE_AREA(float x, float y, float z, float range, int p4)` | void | - |
| `SET_SCENARIO_PEDS_TO_BE_RETURNED_BY_NEXT_COMMAND` | `void SET_SCENARIO_PEDS_TO_BE_RETURNED_BY_NEXT_COMMAND(bool value)` | void | Sets a value indicating whether scenario peds should be returned by the next call to a command that ... |
| `SET_SCENARIO_PED_DENSITY_MULTIPLIER_THIS_FRAME` | `void SET_SCENARIO_PED_DENSITY_MULTIPLIER_THIS_FRAME(float p0, float p1)` | void | - |
| `SET_SCRIPTED_ANIM_SEAT_OFFSET` | `void SET_SCRIPTED_ANIM_SEAT_OFFSET(int ped, float p1)` | void | - |
| `SET_SCRIPTED_CONVERSION_COORD_THIS_FRAME` | `void SET_SCRIPTED_CONVERSION_COORD_THIS_FRAME(float x, float y, float z)` | void | - |
| `SET_SYNCHRONIZED_SCENE_HOLD_LAST_FRAME` | `void SET_SYNCHRONIZED_SCENE_HOLD_LAST_FRAME(int sceneID, bool toggle)` | void | - |
| `SET_SYNCHRONIZED_SCENE_LOOPED` | `void SET_SYNCHRONIZED_SCENE_LOOPED(int sceneID, bool toggle)` | void | - |
| `SET_SYNCHRONIZED_SCENE_ORIGIN` | `void SET_SYNCHRONIZED_SCENE_ORIGIN(int sceneID, float x, float y, float z, float roll, float pitch, float yaw, bool p7)` | void | - |
| `SET_SYNCHRONIZED_SCENE_PHASE` | `void SET_SYNCHRONIZED_SCENE_PHASE(int sceneID, float phase)` | void | - |
| `SET_SYNCHRONIZED_SCENE_RATE` | `void SET_SYNCHRONIZED_SCENE_RATE(int sceneID, float rate)` | void | - |
| `SET_TREAT_AS_AMBIENT_PED_FOR_DRIVER_LOCKON` | `void SET_TREAT_AS_AMBIENT_PED_FOR_DRIVER_LOCKON(int ped, bool p1)` | void | - |
| `SET_USE_CAMERA_HEADING_FOR_DESIRED_DIRECTION_LOCK_ON_TEST` | `void SET_USE_CAMERA_HEADING_FOR_DESIRED_DIRECTION_LOCK_ON_TEST(int ped, bool toggle)` | void | - |
| `SPAWNPOINTS_CANCEL_SEARCH` | `void SPAWNPOINTS_CANCEL_SEARCH()` | void | - |
| `SPAWNPOINTS_GET_NUM_SEARCH_RESULTS` | `int SPAWNPOINTS_GET_NUM_SEARCH_RESULTS()` | int | - |
| `SPAWNPOINTS_GET_SEARCH_RESULT` | `void SPAWNPOINTS_GET_SEARCH_RESULT(int randomInt, ref float x, ref float y, ref float z)` | void | - |
| `SPAWNPOINTS_GET_SEARCH_RESULT_FLAGS` | `void SPAWNPOINTS_GET_SEARCH_RESULT_FLAGS(int p0, ref int p1)` | void | - |
| `SPAWNPOINTS_IS_SEARCH_ACTIVE` | `bool SPAWNPOINTS_IS_SEARCH_ACTIVE()` | bool | - |
| `SPAWNPOINTS_IS_SEARCH_COMPLETE` | `bool SPAWNPOINTS_IS_SEARCH_COMPLETE()` | bool | - |
| `SPAWNPOINTS_IS_SEARCH_FAILED` | `bool SPAWNPOINTS_IS_SEARCH_FAILED()` | bool | - |
| `SPAWNPOINTS_START_SEARCH` | `void SPAWNPOINTS_START_SEARCH(float p0, float p1, float p2, float p3, float p4, int interiorFlags, float scale, int duration)` | void | - |
| `SPAWNPOINTS_START_SEARCH_IN_ANGLED_AREA` | `void SPAWNPOINTS_START_SEARCH_IN_ANGLED_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float width, int interiorFlags, float scale, int duration)` | void | - |
| `SPECIAL_FUNCTION_DO_NOT_USE` | `void SPECIAL_FUNCTION_DO_NOT_USE(int ped, bool p1)` | void | p1 was always 1 (true).<br><br>Kicks the ped from the current vehicle and keeps the rendering-focus on thi... |
| `STOP_ANY_PED_MODEL_BEING_SUPPRESSED` | `void STOP_ANY_PED_MODEL_BEING_SUPPRESSED()` | void | - |
| `STOP_PED_WEAPON_FIRING_WHEN_DROPPED` | `void STOP_PED_WEAPON_FIRING_WHEN_DROPPED(int ped)` | void | - |
| `SUPPRESS_AMBIENT_PED_AGGRESSIVE_CLEANUP_THIS_FRAME` | `void SUPPRESS_AMBIENT_PED_AGGRESSIVE_CLEANUP_THIS_FRAME()` | void | - |
| `TAKE_OWNERSHIP_OF_SYNCHRONIZED_SCENE` | `void TAKE_OWNERSHIP_OF_SYNCHRONIZED_SCENE(int scene)` | void | - |
| `TELL_GROUP_PEDS_IN_AREA_TO_ATTACK` | `void TELL_GROUP_PEDS_IN_AREA_TO_ATTACK(int ped, object p1, float p2, uint hash, object p4, object p5)` | void | - |
| `TOGGLE_SCENARIO_PED_COWER_IN_PLACE` | `void TOGGLE_SCENARIO_PED_COWER_IN_PLACE(int ped, bool toggle)` | void | - |
| `TRIGGER_IDLE_ANIMATION_ON_PED` | `void TRIGGER_IDLE_ANIMATION_ON_PED(int ped)` | void | - |
| `TRIGGER_PED_SCENARIO_PANICEXITTOFLEE` | `bool TRIGGER_PED_SCENARIO_PANICEXITTOFLEE(object p0, object p1, object p2, object p3)` | bool | - |
| `UNREGISTER_PEDHEADSHOT` | `void UNREGISTER_PEDHEADSHOT(int id)` | void | gtaforums.com/topic/885580-ped-headshotmugshot-txd/ |
| `UPDATE_PED_HEAD_BLEND_DATA` | `void UPDATE_PED_HEAD_BLEND_DATA(int ped, float shapeMix, float skinMix, float thirdMix)` | void | See SET_PED_HEAD_BLEND_DATA(). |
| `WAS_PED_KILLED_BY_STEALTH` | `bool WAS_PED_KILLED_BY_STEALTH(int ped)` | bool | - |
| `WAS_PED_KILLED_BY_TAKEDOWN` | `bool WAS_PED_KILLED_BY_TAKEDOWN(int ped)` | bool | - |
| `WAS_PED_KNOCKED_OUT` | `bool WAS_PED_KNOCKED_OUT(int ped)` | bool | - |
| `WAS_PED_SKELETON_UPDATED` | `bool WAS_PED_SKELETON_UPDATED(int ped)` | bool | Despite this function's name, it simply returns whether the specified handle is a Ped. |
| `_HAS_PED_CLEAR_LOS_TO_ENTITY` | `bool _HAS_PED_CLEAR_LOS_TO_ENTITY(int ped, int entity, float x, float y, float z, int p5, bool p6, bool p7)` | bool | - |
| `_SET_BLOCK_AMBIENT_PEDS_FROM_DROPPING_WEAPONS_THIS_FRAME` | `void _SET_BLOCK_AMBIENT_PEDS_FROM_DROPPING_WEAPONS_THIS_FRAME()` | void | - |
| `_SET_PED_SURVIVES_BEING_OUT_OF_WATER` | `bool _SET_PED_SURVIVES_BEING_OUT_OF_WATER(int ped, bool toggle)` | bool | - |

---

## 详细说明

### ADD_ARMOUR_TO_PED

- **命名空间:** `PED`
- **Hash:** `0x5BA652A0CD14DF2F`
- **JHash:** `0xF686B26E`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_ARMOUR_TO_PED(int ped, int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Same as SET_PED_ARMOUR, but ADDS 'amount' to the armor the Ped already has.
```

---

### ADD_PED_DECORATION_FROM_HASHES

- **命名空间:** `PED`
- **Hash:** `0x5F5D1665E352A839`
- **JHash:** `0x70559AC7`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_PED_DECORATION_FROM_HASHES(int ped, uint collection, uint overlay)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `collection` | `Hash` | `uint` | - |
| `overlay` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Applies an Item from a PedDecorationCollection to a ped. These include tattoos and shirt decals.

collection - PedDecorationCollection filename hash
overlay - Item name hash

Example:
Entry inside "mpbeach_overlays.xml" -
<Item>
  <uvPos x="0.500000" y="0.500000" />
  <scale x="0.600000" y="0.500000" />
  <rotation value="0.000000" />
  <nameHash>FM_Hair_Fuzz</nameHash>
  <txdHash>mp_hair_fuzz</txdHash>
  <txtHash>mp_hair_fuzz</txtHash>
  <zone>ZONE_HEAD</zone>
  <type>TYPE_TATTOO</type>
  <faction>FM</faction>
  <garment>All</garment>
  <gender>GENDER_DONTCARE</gender>
  <award />
  <awardLevel />
</Item>

Code:
PED::ADD_PED_DECORATION_FROM_HASHES(PLAYER::PLAYER_PED_ID(), MISC::GET_HASH_KEY("mpbeach_overlays"), MISC::GET_HASH_KEY("fm_hair_fuzz"))

Full list of ped overlays / decorations by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pedOverlayCollections.json
```

---

### ADD_PED_DECORATION_FROM_HASHES_IN_CORONA

- **命名空间:** `PED`
- **Hash:** `0x5619BFA07CFD7833`
- **JHash:** `0x8CD3E487`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_PED_DECORATION_FROM_HASHES_IN_CORONA(int ped, uint collection, uint overlay)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `collection` | `Hash` | `uint` | - |
| `overlay` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of ped overlays / decorations by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pedOverlayCollections.json
```

---

### ADD_RELATIONSHIP_GROUP

- **命名空间:** `PED`
- **Hash:** `0xF372BC22FCB88606`
- **JHash:** `0x8B635546`
- **Build:** `323`

**C# 签名:**
```csharp
bool ADD_RELATIONSHIP_GROUP(string name, Hash* groupHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |
| `groupHash` | `Hash*` | `Hash*` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Can't select void. This function returns nothing. The hash of the created relationship group is output in the second parameter.
```

---

### ADD_SCENARIO_BLOCKING_AREA

- **命名空间:** `PED`
- **Hash:** `0x1B5C85C612E5256E`
- **JHash:** `0xA38C0234`
- **Build:** `323`

**C# 签名:**
```csharp
int ADD_SCENARIO_BLOCKING_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool p6, bool p7, bool p8, bool p9, object p10)
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
| `p7` | `BOOL` | `bool` | - |
| `p8` | `BOOL` | `bool` | - |
| `p9` | `BOOL` | `bool` | - |
| `p10` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### APPLY_DAMAGE_TO_PED

- **命名空间:** `PED`
- **Hash:** `0x697157CED63F18D4`
- **JHash:** `0x4DC27FCF`
- **Build:** `323`

**C# 签名:**
```csharp
void APPLY_DAMAGE_TO_PED(int ped, int damageAmount, bool p2, object p3, uint weaponType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `damageAmount` | `int` | `int` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |
| `weaponType` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
damages a ped with the given amount
```

---

### APPLY_PED_BLOOD

- **命名空间:** `PED`
- **Hash:** `0x83F7E01C7B769A26`
- **JHash:** `0x376CE3C0`
- **Build:** `323`

**C# 签名:**
```csharp
void APPLY_PED_BLOOD(int ped, int boneIndex, float xRot, float yRot, float zRot, string woundType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `boneIndex` | `int` | `int` | - |
| `xRot` | `float` | `float` | - |
| `yRot` | `float` | `float` | - |
| `zRot` | `float` | `float` | - |
| `woundType` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
woundTypes:
- soak_splat
- wound_sheet
- BulletSmall
- BulletLarge
- ShotgunSmall
- ShotgunSmallMonolithic
- ShotgunLarge
- ShotgunLargeMonolithic
- NonFatalHeadshot
- stab
- BasicSlash
- Scripted_Ped_Splash_Back
- BackSplash
```

---

### APPLY_PED_BLOOD_BY_ZONE

- **命名空间:** `PED`
- **Hash:** `0x3311E47B91EDCBBC`
- **JHash:** `0x8F3F3A9C`
- **Build:** `323`

**C# 签名:**
```csharp
void APPLY_PED_BLOOD_BY_ZONE(int ped, int p1, float p2, float p3, string p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### APPLY_PED_BLOOD_DAMAGE_BY_ZONE

- **命名空间:** `PED`
- **Hash:** `0x816F6981C60BF53B`
- **JHash:** `0x1E54DB12`
- **Build:** `323`

**C# 签名:**
```csharp
void APPLY_PED_BLOOD_DAMAGE_BY_ZONE(int ped, object p1, float p2, float p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### APPLY_PED_BLOOD_SPECIFIC

- **命名空间:** `PED`
- **Hash:** `0xEF0D582CBF2D9B0F`
- **JHash:** `0xFC13CE80`
- **Build:** `323`

**C# 签名:**
```csharp
void APPLY_PED_BLOOD_SPECIFIC(int ped, int p1, float p2, float p3, float p4, float p5, int p6, float p7, string p8)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `float` | `float` | - |
| `p5` | `float` | `float` | - |
| `p6` | `int` | `int` | - |
| `p7` | `float` | `float` | - |
| `p8` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### APPLY_PED_DAMAGE_DECAL

- **命名空间:** `PED`
- **Hash:** `0x397C38AA7B4A5F83`
- **JHash:** `0x8A13A41F`
- **Build:** `323`

**C# 签名:**
```csharp
void APPLY_PED_DAMAGE_DECAL(int ped, int damageZone, float xOffset, float yOffset, float heading, float scale, float alpha, int variation, bool fadeIn, string decalName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `damageZone` | `int` | `int` | - |
| `xOffset` | `float` | `float` | - |
| `yOffset` | `float` | `float` | - |
| `heading` | `float` | `float` | - |
| `scale` | `float` | `float` | - |
| `alpha` | `float` | `float` | - |
| `variation` | `int` | `int` | - |
| `fadeIn` | `BOOL` | `bool` | - |
| `decalName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
enum eDamageZone
{
	DZ_Torso = 0,
	DZ_Head,
	DZ_LeftArm,
	DZ_RightArm,
	DZ_LeftLeg,
	DZ_RightLeg,
};

Decal Names:
scar
blushing
cs_flush_anger
cs_flush_anger_face
bruise
bruise_large
herpes
ArmorBullet
basic_dirt_cloth
basic_dirt_skin
cs_trev1_dirt

APPLY_PED_DAMAGE_DECAL(ped, 1, 0.5f, 0.513f, 0f, 1f, unk, 0, 0, "blushing");
```

---

### APPLY_PED_DAMAGE_PACK

- **命名空间:** `PED`
- **Hash:** `0x46DF918788CB093F`
- **JHash:** `0x208D0CB8`
- **Build:** `323`

**C# 签名:**
```csharp
void APPLY_PED_DAMAGE_PACK(int ped, string damagePack, float damage, float mult)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `damagePack` | `const char*` | `string` | - |
| `damage` | `float` | `float` | - |
| `mult` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Damage Packs:

"SCR_TrevorTreeBang"
"HOSPITAL_0"
"HOSPITAL_1"
"HOSPITAL_2"
"HOSPITAL_3"
"HOSPITAL_4"
"HOSPITAL_5"
"HOSPITAL_6"
"HOSPITAL_7"
"HOSPITAL_8"
"HOSPITAL_9"
"SCR_Dumpster"
"BigHitByVehicle"
"SCR_Finale_Michael_Face"
"SCR_Franklin_finb"
"SCR_Finale_Michael"
"SCR_Franklin_finb2"
"Explosion_Med"
"SCR_Torture"
"SCR_TracySplash"
"Skin_Melee_0"

Additional damage packs:

gist.github.com/alexguirre/f3f47f75ddcf617f416f3c8a55ae2227
Full list of ped damage packs by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pedDamagePacks.json
```

---

### ATTACH_SYNCHRONIZED_SCENE_TO_ENTITY

- **命名空间:** `PED`
- **Hash:** `0x272E4723B56A3B96`
- **JHash:** `0xE9BA6189`
- **Build:** `323`

**C# 签名:**
```csharp
void ATTACH_SYNCHRONIZED_SCENE_TO_ENTITY(int sceneID, int entity, int boneIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `sceneID` | `int` | `int` | - |
| `entity` | `Entity` | `int` | - |
| `boneIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### BLOCK_PED_FROM_GENERATING_DEAD_BODY_EVENTS_WHEN_DEAD

- **命名空间:** `PED`
- **Hash:** `0xE43A13C9E4CCCBCF`
- **JHash:** `0xFF1F6AEB`
- **Build:** `323`

**C# 签名:**
```csharp
void BLOCK_PED_FROM_GENERATING_DEAD_BODY_EVENTS_WHEN_DEAD(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### CAN_CREATE_RANDOM_BIKE_RIDER

- **命名空间:** `PED`
- **Hash:** `0xEACEEDA81751915C`
- **JHash:** `0x7018BE31`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_CREATE_RANDOM_BIKE_RIDER()
```

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_CREATE_RANDOM_COPS

- **命名空间:** `PED`
- **Hash:** `0x5EE2CAFF7F17770D`
- **JHash:** `0xAA73DAD9`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_CREATE_RANDOM_COPS()
```

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_CREATE_RANDOM_DRIVER

- **命名空间:** `PED`
- **Hash:** `0xB8EB95E5B4E56978`
- **JHash:** `0x99861609`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_CREATE_RANDOM_DRIVER()
```

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_CREATE_RANDOM_PED

- **命名空间:** `PED`
- **Hash:** `0x3E8349C08E4B82E4`
- **JHash:** `0xF9ABE88F`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_CREATE_RANDOM_PED(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_KNOCK_PED_OFF_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0x51AC07A44D4F5B8A`
- **JHash:** `0xC9D098B3`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_KNOCK_PED_OFF_VEHICLE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_PED_IN_COMBAT_SEE_TARGET

- **命名空间:** `PED`
- **Hash:** `0xEAD42DE3610D0721`
- **JHash:** `0xCCD525E1`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_PED_IN_COMBAT_SEE_TARGET(int ped, int target)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `target` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_PED_RAGDOLL

- **命名空间:** `PED`
- **Hash:** `0x128F79EDCECE4FD5`
- **JHash:** `0xC0EFB7A3`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_PED_RAGDOLL(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Prevents the ped from going limp.

[Example: Can prevent peds from falling when standing on moving vehicles.]
```

---

### CAN_PED_SEE_HATED_PED

- **命名空间:** `PED`
- **Hash:** `0x6CD5A433374D4CFB`
- **JHash:** `0x74A0F291`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_PED_SEE_HATED_PED(int ped1, int ped2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped1` | `Ped` | `int` | - |
| `ped2` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_PED_SHUFFLE_TO_OR_FROM_EXTRA_SEAT

- **命名空间:** `PED`
- **Hash:** `0x2DFC81C9B9608549`
- **Build:** `944`

**C# 签名:**
```csharp
bool CAN_PED_SHUFFLE_TO_OR_FROM_EXTRA_SEAT(int ped, ref int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_PED_SHUFFLE_TO_OR_FROM_TURRET_SEAT

- **命名空间:** `PED`
- **Hash:** `0x9C6A6C19B6C0C496`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_PED_SHUFFLE_TO_OR_FROM_TURRET_SEAT(int ped, ref int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CLEAR_ALL_PED_PROPS

- **命名空间:** `PED`
- **Hash:** `0xCD8A7537A9B52F06`
- **JHash:** `0x81DF8B43`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_ALL_PED_PROPS(int ped, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
List of component/props ID
gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
```

---

### CLEAR_ALL_PED_VEHICLE_FORCED_SEAT_USAGE

- **命名空间:** `PED`
- **Hash:** `0xE6CA85E7259CE16B`
- **JHash:** `0xCC1D8F66`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_ALL_PED_VEHICLE_FORCED_SEAT_USAGE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_COVER_POINT_FOR_PED

- **命名空间:** `PED`
- **Hash:** `0x637822DC2AFEEBF8`
- **Build:** `1493`

**C# 签名:**
```csharp
void CLEAR_COVER_POINT_FOR_PED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_FACIAL_IDLE_ANIM_OVERRIDE

- **命名空间:** `PED`
- **Hash:** `0x726256CC1EEB182F`
- **JHash:** `0x5244F4E2`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_FACIAL_IDLE_ANIM_OVERRIDE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PED_ALTERNATE_MOVEMENT_ANIM

- **命名空间:** `PED`
- **Hash:** `0xD8D19675ED5FBDCE`
- **JHash:** `0x7A7F5BC3`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_ALTERNATE_MOVEMENT_ANIM(int ped, int stance, float p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `stance` | `int` | `int` | - |
| `p2` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PED_ALTERNATE_WALK_ANIM

- **命名空间:** `PED`
- **Hash:** `0x8844BBFCE30AA9E9`
- **JHash:** `0x5736FB23`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_ALTERNATE_WALK_ANIM(int ped, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PED_BLOOD_DAMAGE

- **命名空间:** `PED`
- **Hash:** `0x8FE22675A5A45817`
- **JHash:** `0xF7ADC960`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_BLOOD_DAMAGE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PED_BLOOD_DAMAGE_BY_ZONE

- **命名空间:** `PED`
- **Hash:** `0x56E3B78C5408D9F4`
- **JHash:** `0xF210BE69`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_BLOOD_DAMAGE_BY_ZONE(int ped, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Somehow related to changing ped's clothes.
```

---

### CLEAR_PED_DAMAGE_DECAL_BY_ZONE

- **命名空间:** `PED`
- **Hash:** `0x523C79AEEFCC4A2A`
- **JHash:** `0x70AA5B7D`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_DAMAGE_DECAL_BY_ZONE(int ped, int p1, string p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1: from 0 to 5 in the b617d scripts.
p2: "blushing" and "ALL" found in the b617d scripts.
```

---

### CLEAR_PED_DECORATIONS

- **命名空间:** `PED`
- **Hash:** `0x0E5173C163976E38`
- **JHash:** `0xD4496BF3`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_DECORATIONS(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PED_DECORATIONS_LEAVE_SCARS

- **命名空间:** `PED`
- **Hash:** `0xE3B27E70CEAB9F0C`
- **JHash:** `0xEFD58EB9`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_DECORATIONS_LEAVE_SCARS(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PED_DRIVE_BY_CLIPSET_OVERRIDE

- **命名空间:** `PED`
- **Hash:** `0x4AFE3690D7E0B5AC`
- **JHash:** `0xAEC9163B`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_DRIVE_BY_CLIPSET_OVERRIDE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PED_ENV_DIRT

- **命名空间:** `PED`
- **Hash:** `0x6585D955A68452A5`
- **JHash:** `0xA993915F`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_ENV_DIRT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PED_FALL_UPPER_BODY_CLIPSET_OVERRIDE

- **命名空间:** `PED`
- **Hash:** `0x80054D7FCC70EEC6`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_FALL_UPPER_BODY_CLIPSET_OVERRIDE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PED_LAST_DAMAGE_BONE

- **命名空间:** `PED`
- **Hash:** `0x8EF6B7AC68E2F01B`
- **JHash:** `0x56CB715E`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_LAST_DAMAGE_BONE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PED_MOTION_IN_COVER_CLIPSET_OVERRIDE

- **命名空间:** `PED`
- **Hash:** `0xC79196DCB36F6121`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_MOTION_IN_COVER_CLIPSET_OVERRIDE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PED_NON_CREATION_AREA

- **命名空间:** `PED`
- **Hash:** `0x2E05208086BA0651`
- **JHash:** `0x6F7043A3`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_NON_CREATION_AREA()
```

**返回值:** `void` (Native: `void`)

---

### CLEAR_PED_PARACHUTE_PACK_VARIATION

- **命名空间:** `PED`
- **Hash:** `0x1280804F7CFD2D6C`
- **JHash:** `0x7BCD8991`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_PARACHUTE_PACK_VARIATION(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PED_PROP

- **命名空间:** `PED`
- **Hash:** `0x0943E5B8E078E76E`
- **JHash:** `0x2D23D743`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_PROP(int ped, int propId, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `propId` | `int` | `int` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
List of component/props ID
gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
```

---

### CLEAR_PED_SCUBA_GEAR_VARIATION

- **命名空间:** `PED`
- **Hash:** `0xB50EB4CCB29704AC`
- **JHash:** `0x080275EE`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_SCUBA_GEAR_VARIATION(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Removes the scubagear (for mp male: component id: 8, drawableId: 123, textureId: any) from peds. Does not play the 'remove scuba gear' animation, but instantly removes it.
```

---

### CLEAR_PED_STORED_HAT_PROP

- **命名空间:** `PED`
- **Hash:** `0x687C0B594907D2E8`
- **JHash:** `0x24A1284E`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_STORED_HAT_PROP(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PED_WETNESS

- **命名空间:** `PED`
- **Hash:** `0x9C720776DAA43E7E`
- **JHash:** `0x629F15BD`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_WETNESS(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
It clears the wetness of the selected Ped/Player. Clothes have to be wet to notice the difference.
```

---

### CLEAR_RAGDOLL_BLOCKING_FLAGS

- **命名空间:** `PED`
- **Hash:** `0xD86D101FCFD00A4B`
- **JHash:** `0x77CBA290`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_RAGDOLL_BLOCKING_FLAGS(int ped, int blockingFlag)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `blockingFlag` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
See SET_RAGDOLL_BLOCKING_FLAGS for flags
```

---

### CLEAR_RELATIONSHIP_BETWEEN_GROUPS

- **命名空间:** `PED`
- **Hash:** `0x5E29243FB56FC6D4`
- **JHash:** `0x994B8C2D`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_RELATIONSHIP_BETWEEN_GROUPS(int relationship, uint group1, uint group2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `relationship` | `int` | `int` | - |
| `group1` | `Hash` | `uint` | - |
| `group2` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Clears the relationship between two groups. This should be called twice (once for each group).

Relationship types:
0 = Companion
1 = Respect
2 = Like
3 = Neutral
4 = Dislike
5 = Hate
255 = Pedestrians
(Credits: Inco)

Example:
PED::CLEAR_RELATIONSHIP_BETWEEN_GROUPS(2, l_1017, 0xA49E591C);
PED::CLEAR_RELATIONSHIP_BETWEEN_GROUPS(2, 0xA49E591C, l_1017);
```

---

### CLONE_PED

- **命名空间:** `PED`
- **Hash:** `0xEF29A16337FACADB`
- **JHash:** `0x8C8A8D6E`
- **Build:** `323`

**C# 签名:**
```csharp
int CLONE_PED(int ped, bool isNetwork, bool bScriptHostPed, bool copyHeadBlendFlag)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `isNetwork` | `BOOL` | `bool` | - |
| `bScriptHostPed` | `BOOL` | `bool` | - |
| `copyHeadBlendFlag` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `Ped`)

---

### CLONE_PED_ALT

- **命名空间:** `PED`
- **Hash:** `0x668FD40BCBA5DE48`
- **Build:** `463`

**C# 签名:**
```csharp
int CLONE_PED_ALT(int ped, bool isNetwork, bool bScriptHostPed, bool copyHeadBlendFlag, bool p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `isNetwork` | `BOOL` | `bool` | - |
| `bScriptHostPed` | `BOOL` | `bool` | - |
| `copyHeadBlendFlag` | `BOOL` | `bool` | - |
| `p4` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `Ped`)

---

### CLONE_PED_TO_TARGET

- **命名空间:** `PED`
- **Hash:** `0xE952D6431689AD9A`
- **JHash:** `0xFC70EEC7`
- **Build:** `323`

**C# 签名:**
```csharp
void CLONE_PED_TO_TARGET(int ped, int targetPed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `targetPed` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Copies ped's components and props to targetPed.
```

---

### CLONE_PED_TO_TARGET_ALT

- **命名空间:** `PED`
- **Hash:** `0x148B08C2D2ACB884`
- **Build:** `463`

**C# 签名:**
```csharp
void CLONE_PED_TO_TARGET_ALT(int ped, int targetPed, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `targetPed` | `Ped` | `int` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### COUNT_PEDS_IN_COMBAT_WITH_TARGET

- **命名空间:** `PED`
- **Hash:** `0x5407B7288D0478B7`
- **JHash:** `0xEF0B78E6`
- **Build:** `323`

**C# 签名:**
```csharp
int COUNT_PEDS_IN_COMBAT_WITH_TARGET(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### COUNT_PEDS_IN_COMBAT_WITH_TARGET_WITHIN_RADIUS

- **命名空间:** `PED`
- **Hash:** `0x336B3D200AB007CB`
- **JHash:** `0xFB18CB19`
- **Build:** `323`

**C# 签名:**
```csharp
int COUNT_PEDS_IN_COMBAT_WITH_TARGET_WITHIN_RADIUS(int ped, float x, float y, float z, float radius)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |

**返回值:** `int` (Native: `int`)

---

### CREATE_GROUP

- **命名空间:** `PED`
- **Hash:** `0x90370EBE0FEE1A3D`
- **JHash:** `0x8DC0368D`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_GROUP(int unused)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `unused` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Creates a new ped group.
Groups can contain up to 8 peds.

The parameter is unused.

Returns a handle to the created group, or 0 if a group couldn't be created.
```

---

### CREATE_NM_MESSAGE

- **命名空间:** `PED`
- **Hash:** `0x418EF2A1BCE56685`
- **JHash:** `0x1CFBFD4B`
- **Build:** `323`

**C# 签名:**
```csharp
void CREATE_NM_MESSAGE(bool startImmediately, int messageId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `startImmediately` | `BOOL` | `bool` | - |
| `messageId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Creates a new NaturalMotion message.

startImmediately: If set to true, the character will perform the message the moment it receives it by GIVE_PED_NM_MESSAGE. If false, the Ped will get the message but won't perform it yet. While it's a boolean value, if negative, the message will not be initialized.
messageId: The ID of the NaturalMotion message.

If a message already exists, this function does nothing. A message exists until the point it has been successfully dispatched by GIVE_PED_NM_MESSAGE.
```

---

### CREATE_PARACHUTE_BAG_OBJECT

- **命名空间:** `PED`
- **Hash:** `0x8C4F3BF23B6237DB`
- **JHash:** `0x19198A16`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_PARACHUTE_BAG_OBJECT(int ped, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `Object`)

---

### CREATE_PED

- **命名空间:** `PED`
- **Hash:** `0xD49F9B0955C367DE`
- **JHash:** `0x0389EF71`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_PED(int pedType, uint modelHash, float x, float y, float z, float heading, bool isNetwork, bool bScriptHostPed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pedType` | `int` | `int` | - |
| `modelHash` | `Hash` | `uint` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `heading` | `float` | `float` | - |
| `isNetwork` | `BOOL` | `bool` | - |
| `bScriptHostPed` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `Ped`)

**说明:**
```
https://alloc8or.re/gta5/doc/enums/ePedType.txt

Full list of peds by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/peds.json
```

---

### CREATE_PED_INSIDE_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0x7DD959874C1FD534`
- **JHash:** `0x3000F092`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_PED_INSIDE_VEHICLE(int vehicle, int pedType, uint modelHash, int seat, bool isNetwork, bool bScriptHostPed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `pedType` | `int` | `int` | - |
| `modelHash` | `Hash` | `uint` | - |
| `seat` | `int` | `int` | - |
| `isNetwork` | `BOOL` | `bool` | - |
| `bScriptHostPed` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `Ped`)

**说明:**
```
pedType: see CREATE_PED

Full list of peds by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/peds.json
```

---

### CREATE_RANDOM_PED

- **命名空间:** `PED`
- **Hash:** `0xB4AC7D0CF06BFE8F`
- **JHash:** `0x5A949543`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_RANDOM_PED(float posX, float posY, float posZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |

**返回值:** `int` (Native: `Ped`)

**说明:**
```
vb.net
Dim ped_handle As Integer
                    With Game.Player.Character
                        Dim pos As Vector3 = .Position + .ForwardVector * 3
                        ped_handle = Native.Function.Call(Of Integer)(Hash.CREATE_RANDOM_PED, pos.X, pos.Y, pos.Z)
                    End With

Creates a Ped at the specified location, returns the Ped Handle.  
Ped will not act until SET_PED_AS_NO_LONGER_NEEDED is called.
```

---

### CREATE_RANDOM_PED_AS_DRIVER

- **命名空间:** `PED`
- **Hash:** `0x9B62392B474F44A0`
- **JHash:** `0xB927CE9A`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_RANDOM_PED_AS_DRIVER(int vehicle, bool returnHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `returnHandle` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `Ped`)

---

### CREATE_SYNCHRONIZED_SCENE

- **命名空间:** `PED`
- **Hash:** `0x8C18E0F9080ADD73`
- **JHash:** `0xFFDDF8FA`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_SYNCHRONIZED_SCENE(float x, float y, float z, float roll, float pitch, float yaw, int p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `roll` | `float` | `float` | - |
| `pitch` | `float` | `float` | - |
| `yaw` | `float` | `float` | - |
| `p6` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
p6 always 2 (but it doesnt seem to matter...)

roll and pitch 0
yaw to Ped.rotation
```

---

### CREATE_SYNCHRONIZED_SCENE_AT_MAP_OBJECT

- **命名空间:** `PED`
- **Hash:** `0x62EC273D00187DCA`
- **JHash:** `0xF3876894`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_SYNCHRONIZED_SCENE_AT_MAP_OBJECT(float x, float y, float z, float radius, uint object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `object` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

---

### DELETE_PED

- **命名空间:** `PED`
- **Hash:** `0x9614299DCB53E54B`
- **JHash:** `0x13EFB9A0`
- **Build:** `323`

**C# 签名:**
```csharp
void DELETE_PED(Ped* ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped*` | `Ped*` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Deletes the specified ped, then sets the handle pointed to by the pointer to NULL.
```

---

### DETACH_SYNCHRONIZED_SCENE

- **命名空间:** `PED`
- **Hash:** `0x6D38F1F04CBB37EA`
- **JHash:** `0x52A1CAB2`
- **Build:** `323`

**C# 签名:**
```csharp
void DETACH_SYNCHRONIZED_SCENE(int sceneID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `sceneID` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DISABLE_HEAD_BLEND_PALETTE_COLOR

- **命名空间:** `PED`
- **Hash:** `0xA21C118553BBDF02`
- **JHash:** `0xC6F36292`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_HEAD_BLEND_PALETTE_COLOR(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DISABLE_PED_HEATSCALE_OVERRIDE

- **命名空间:** `PED`
- **Hash:** `0x600048C60D5C2C51`
- **JHash:** `0x0688DE64`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_PED_HEATSCALE_OVERRIDE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DISABLE_PED_INJURED_ON_GROUND_BEHAVIOUR

- **命名空间:** `PED`
- **Hash:** `0x733C87D4CE22BEA2`
- **JHash:** `0x43709044`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_PED_INJURED_ON_GROUND_BEHAVIOUR(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DOES_GROUP_EXIST

- **命名空间:** `PED`
- **Hash:** `0x7C6B0C22F9F40BBE`
- **JHash:** `0x935C978D`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_GROUP_EXIST(int groupId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `groupId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DOES_RELATIONSHIP_GROUP_EXIST

- **命名空间:** `PED`
- **Hash:** `0xCC6E3B6BB69501F1`
- **Build:** `505`

**C# 签名:**
```csharp
bool DOES_RELATIONSHIP_GROUP_EXIST(uint groupHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `groupHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DOES_SCENARIO_BLOCKING_AREA_EXISTS

- **命名空间:** `PED`
- **Hash:** `0x8A24B067D175A7BD`
- **Build:** `678`

**C# 签名:**
```csharp
bool DOES_SCENARIO_BLOCKING_AREA_EXISTS(float x1, float y1, float z1, float x2, float y2, float z2)
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

---

### DROP_AMBIENT_PROP

- **命名空间:** `PED`
- **Hash:** `0xAFF4710E2A0A6C12`
- **JHash:** `0x728D3D53`
- **Build:** `323`

**C# 签名:**
```csharp
void DROP_AMBIENT_PROP(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### ENABLE_MP_LIGHT

- **命名空间:** `PED`
- **Hash:** `0xEE2476B9EE4A094F`
- **Build:** `1493`

**C# 签名:**
```csharp
void ENABLE_MP_LIGHT(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### EXPLODE_PED_HEAD

- **命名空间:** `PED`
- **Hash:** `0x2D05CED3A38D0F3A`
- **JHash:** `0x05CC1380`
- **Build:** `323`

**C# 签名:**
```csharp
void EXPLODE_PED_HEAD(int ped, uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Forces the ped to fall back and kills it.

It doesn't really explode the ped's head but it kills the ped
```

---

### FINALIZE_HEAD_BLEND

- **命名空间:** `PED`
- **Hash:** `0x4668D80430D6C299`
- **JHash:** `0x894314A4`
- **Build:** `323`

**C# 签名:**
```csharp
void FINALIZE_HEAD_BLEND(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### FORCE_ALL_HEADING_VALUES_TO_ALIGN

- **命名空间:** `PED`
- **Hash:** `0xFF287323B0E2C69A`
- **JHash:** `0x290421BE`
- **Build:** `323`

**C# 签名:**
```csharp
void FORCE_ALL_HEADING_VALUES_TO_ALIGN(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### FORCE_INSTANT_LEG_IK_SETUP

- **命名空间:** `PED`
- **Hash:** `0xED3C76ADFA6D07C4`
- **JHash:** `0xFB4000DC`
- **Build:** `323`

**C# 签名:**
```csharp
void FORCE_INSTANT_LEG_IK_SETUP(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### FORCE_PED_AI_AND_ANIMATION_UPDATE

- **命名空间:** `PED`
- **Hash:** `0x2208438012482A1A`
- **JHash:** `0x187B9070`
- **Build:** `323`

**C# 签名:**
```csharp
void FORCE_PED_AI_AND_ANIMATION_UPDATE(int ped, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### FORCE_PED_MOTION_STATE

- **命名空间:** `PED`
- **Hash:** `0xF28965D04F570DCA`
- **JHash:** `0x164DDEFF`
- **Build:** `323`

**C# 签名:**
```csharp
bool FORCE_PED_MOTION_STATE(int ped, uint motionStateHash, bool p2, int p3, bool p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `motionStateHash` | `Hash` | `uint` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `int` | `int` | - |
| `p4` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Regarding p2, p3 and p4: Most common is 0, 0, 0); followed by 0, 1, 0); and 1, 1, 0); in R* scripts. p4 is very rarely something other than 0.

enum eMotionState // 0x92A659FE
{
	MotionState_None = 0xEE717723,
	MotionState_Idle = 0x9072A713,
	MotionState_Walk = 0xD827C3DB,
	MotionState_Run = 0xFFF7E7A4,
	MotionState_Sprint = 0xBD8817DB,
	MotionState_Crouch_Idle = 0x43FB099E,
	MotionState_Crouch_Walk = 0x08C31A98,
	MotionState_Crouch_Run = 0x3593CF09,
	MotionState_DoNothing = 0x0EC17E58,
	MotionState_AnimatedVelocity = 0x551AAC43,
	MotionState_InVehicle = 0x94D9D58D,
	MotionState_Aiming = 0x3F67C6AF,
	MotionState_Diving_Idle = 0x4848CDED,
	MotionState_Diving_Swim = 0x916E828C,
	MotionState_Swimming_TreadWater = 0xD1BF11C7,
	MotionState_Dead = 0x0DBB071C,
	MotionState_Stealth_Idle = 0x422D7A25,
	MotionState_Stealth_Walk = 0x042AB6A2,
	MotionState_Stealth_Run = 0xFB0B79E1,
	MotionState_Parachuting = 0xBAC0F10B,
	MotionState_ActionMode_Idle = 0xDA40A0DC,
	MotionState_ActionMode_Walk = 0xD2905EA7,
	MotionState_ActionMode_Run = 0x31BADE14,
	MotionState_Jetpack = 0x535E6A5E
};
```

---

### FORCE_PED_TO_OPEN_PARACHUTE

- **命名空间:** `PED`
- **Hash:** `0x16E42E800B472221`
- **JHash:** `0xA819680B`
- **Build:** `323`

**C# 签名:**
```csharp
void FORCE_PED_TO_OPEN_PARACHUTE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### FORCE_ZERO_MASS_IN_COLLISIONS

- **命名空间:** `PED`
- **Hash:** `0xD33DAA36272177C4`
- **JHash:** `0xA89A53F2`
- **Build:** `323`

**C# 签名:**
```csharp
void FORCE_ZERO_MASS_IN_COLLISIONS(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### GET_ANIM_INITIAL_OFFSET_POSITION

- **命名空间:** `PED`
- **Hash:** `0xBE22B26DD764C040`
- **JHash:** `0xC59D4268`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_ANIM_INITIAL_OFFSET_POSITION(string animDict, string animName, float x, float y, float z, float xRot, float yRot, float zRot, float p8, int p9)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `animDict` | `const char*` | `string` | - |
| `animName` | `const char*` | `string` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `xRot` | `float` | `float` | - |
| `yRot` | `float` | `float` | - |
| `zRot` | `float` | `float` | - |
| `p8` | `float` | `float` | - |
| `p9` | `int` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### GET_ANIM_INITIAL_OFFSET_ROTATION

- **命名空间:** `PED`
- **Hash:** `0x4B805E6046EE9E47`
- **JHash:** `0x5F7789E6`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_ANIM_INITIAL_OFFSET_ROTATION(string animDict, string animName, float x, float y, float z, float xRot, float yRot, float zRot, float p8, int p9)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `animDict` | `const char*` | `string` | - |
| `animName` | `const char*` | `string` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `xRot` | `float` | `float` | - |
| `yRot` | `float` | `float` | - |
| `zRot` | `float` | `float` | - |
| `p8` | `float` | `float` | - |
| `p9` | `int` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### GET_CAN_PED_BE_GRABBED_BY_SCRIPT

- **命名空间:** `PED`
- **Hash:** `0x03EA03AF85A85CB7`
- **JHash:** `0x18DD76A1`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_CAN_PED_BE_GRABBED_BY_SCRIPT(int ped, bool p1, bool p2, bool p3, bool p4, bool p5, bool p6, bool p7, object p8)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `BOOL` | `bool` | - |
| `p5` | `BOOL` | `bool` | - |
| `p6` | `BOOL` | `bool` | - |
| `p7` | `BOOL` | `bool` | - |
| `p8` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_CLOSEST_PED

- **命名空间:** `PED`
- **Hash:** `0xC33AB876A77F8164`
- **JHash:** `0x8F6C1F55`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_CLOSEST_PED(float x, float y, float z, float radius, bool p4, bool p5, Ped* outPed, bool p7, bool p8, int pedType)
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
| `outPed` | `Ped*` | `Ped*` | - |
| `p7` | `BOOL` | `bool` | - |
| `p8` | `BOOL` | `bool` | - |
| `pedType` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Gets the closest ped in a radius.

Ped Types:
Any ped = -1
Player = 1
Male = 4 
Female = 5 
Cop = 6
Human = 26
SWAT = 27 
Animal = 28
Army = 29

------------------
P4 P5 P7 P8
1  0  x  x  = return nearest walking Ped
1  x  0  x  = return nearest walking Ped
x  1  1  x  = return Ped you are using
0  0  x  x  = no effect
0  x  0  x  = no effect

x = can be 1 or 0. Does not have any obvious changes.

This function does not return ped who is:
1. Standing still
2. Driving
3. Fleeing
4. Attacking

This function only work if the ped is:
1. walking normally.
2. waiting to cross a road.

Note: PED::GET_PED_NEARBY_PEDS works for more peds.
```

---

### GET_COMBAT_FLOAT

- **命名空间:** `PED`
- **Hash:** `0x52DFF8A10508090A`
- **JHash:** `0x511D7EF8`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_COMBAT_FLOAT(int ped, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
p0: Ped Handle
p1: int i | 0 <= i <= 27

p1 probably refers to the attributes configured in combatbehavior.meta. There are 13. Example:

<BlindFireChance value="0.1"/>
<WeaponShootRateModifier value="1.0"/>
<TimeBetweenBurstsInCover value="1.25"/>
<BurstDurationInCover value="2.0"/>
<TimeBetweenPeeks value="10.0"/>
<WeaponAccuracy value="0.18"/>
<FightProficiency value="0.8"/>
<StrafeWhenMovingChance value="1.0"/>
<WalkWhenStrafingChance value="0.0"/>
<AttackWindowDistanceForCover value="55.0"/>
<TimeToInvalidateInjuredTarget value="9.0"/>
<TriggerChargeTime_Near value="4.0"/>
<TriggerChargeTime_Far value="10.0"/>

-------------Confirmed by editing combatbehavior.meta:
p1:
0=BlindFireChance
1=BurstDurationInCover
3=TimeBetweenBurstsInCover
4=TimeBetweenPeeks
5=StrafeWhenMovingChance
8=WalkWhenStrafingChance
11=AttackWindowDistanceForCover
12=TimeToInvalidateInjuredTarget
16=OptimalCoverDistance

```

---

### GET_DEAD_PED_PICKUP_COORDS

- **命名空间:** `PED`
- **Hash:** `0xCD5003B097200F36`
- **JHash:** `0x129F9DC1`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_DEAD_PED_PICKUP_COORDS(int ped, float p1, float p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |

**返回值:** `Vector3` (Native: `Vector3`)

---

### GET_DEFAULT_SECONDARY_TINT_FOR_BARBER

- **命名空间:** `PED`
- **Hash:** `0xAAA6A3698A69E048`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_DEFAULT_SECONDARY_TINT_FOR_BARBER(int colorID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `colorID` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_DEFAULT_SECONDARY_TINT_FOR_CREATOR

- **命名空间:** `PED`
- **Hash:** `0xEA9960D07DADCF10`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_DEFAULT_SECONDARY_TINT_FOR_CREATOR(int colorId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `colorId` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_FM_FEMALE_SHOP_PED_APPAREL_ITEM_INDEX

- **命名空间:** `PED`
- **Hash:** `0xF033419D1B81FAE8`
- **JHash:** `0x8FDDB5DB`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_FM_FEMALE_SHOP_PED_APPAREL_ITEM_INDEX(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_FM_MALE_SHOP_PED_APPAREL_ITEM_INDEX

- **命名空间:** `PED`
- **Hash:** `0x1E77FA7A62EE6C4C`
- **JHash:** `0x021F5B36`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_FM_MALE_SHOP_PED_APPAREL_ITEM_INDEX(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_GROUP_SIZE

- **命名空间:** `PED`
- **Hash:** `0x8DE69FE35CA09A45`
- **JHash:** `0xF7E1A691`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_GROUP_SIZE(int groupID, ref object p1, ref int sizeInMembers)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `groupID` | `int` | `int` | - |
| `p1` | `Any*` | `ref object` | - |
| `sizeInMembers` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 may be a BOOL representing whether or not the group even exists
```

---

### GET_HEAD_BLEND_EYE_COLOR

- **命名空间:** `PED`
- **Hash:** `0x76BBA2CEE66D47E9`
- **Build:** `1011`

**C# 签名:**
```csharp
int GET_HEAD_BLEND_EYE_COLOR(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
A getter for _SET_PED_EYE_COLOR. Returns -1 if fails to get.
```

---

### GET_JACK_TARGET

- **命名空间:** `PED`
- **Hash:** `0x5486A79D9FBD342D`
- **JHash:** `0x1D196361`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_JACK_TARGET(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `Ped`)

---

### GET_MELEE_TARGET_FOR_PED

- **命名空间:** `PED`
- **Hash:** `0x18A3E9EE1297FD39`
- **JHash:** `0xAFEC26A4`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_MELEE_TARGET_FOR_PED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `Ped`)

---

### GET_MOUNT

- **命名空间:** `PED`
- **Hash:** `0xE7E11B8DCBED1058`
- **JHash:** `0xDD31EC4E`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_MOUNT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `Ped`)

**说明:**
```

Function just returns 0
void __fastcall ped__get_mount(NativeContext *a1)
{
  NativeContext *v1; // rbx@1

  v1 = a1;
  GetAddressOfPedFromScriptHandle(a1->Args->Arg1);
  v1->Returns->Item1= 0;
}
```

---

### GET_MP_LIGHT_ENABLED

- **命名空间:** `PED`
- **Hash:** `0x88274C11CF0D866D`
- **Build:** `1493`

**C# 签名:**
```csharp
bool GET_MP_LIGHT_ENABLED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_MP_OUTFIT_DATA_FROM_METADATA

- **命名空间:** `PED`
- **Hash:** `0x9E30E91FB03A2CAF`
- **JHash:** `0x52559BB6`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_MP_OUTFIT_DATA_FROM_METADATA(ref object p0, ref object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_NUMBER_OF_PED_DRAWABLE_VARIATIONS

- **命名空间:** `PED`
- **Hash:** `0x27561561732A7842`
- **JHash:** `0x9754C27D`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUMBER_OF_PED_DRAWABLE_VARIATIONS(int ped, int componentId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `componentId` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
List of component/props ID
gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
```

---

### GET_NUMBER_OF_PED_PROP_DRAWABLE_VARIATIONS

- **命名空间:** `PED`
- **Hash:** `0x5FAF9754E789FB47`
- **JHash:** `0xC9780B95`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUMBER_OF_PED_PROP_DRAWABLE_VARIATIONS(int ped, int propId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `propId` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
List of component/props ID
gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
```

---

### GET_NUMBER_OF_PED_PROP_TEXTURE_VARIATIONS

- **命名空间:** `PED`
- **Hash:** `0xA6E7F1CEB523E171`
- **JHash:** `0x4892B882`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUMBER_OF_PED_PROP_TEXTURE_VARIATIONS(int ped, int propId, int drawableId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `propId` | `int` | `int` | - |
| `drawableId` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Need to check behavior when drawableId = -1

- Doofy.Ass
Why this function doesn't work and return nill value?
GET_NUMBER_OF_PED_PROP_TEXTURE_VARIATIONS(PLAYER.PLAYER_PED_ID(), 0, 5)

tick: scripts/addins/menu_execute.lua:51: attempt to call field 'GET_NUMBER_OF_PED_PROP_TEXTURE_VARIATIONS' (a nil value)


List of component/props ID
gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
```

---

### GET_NUMBER_OF_PED_TEXTURE_VARIATIONS

- **命名空间:** `PED`
- **Hash:** `0x8F7156A3142A6BAD`
- **JHash:** `0x83D9FBE7`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUMBER_OF_PED_TEXTURE_VARIATIONS(int ped, int componentId, int drawableId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `componentId` | `int` | `int` | - |
| `drawableId` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
List of component/props ID
gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
```

---

### GET_NUM_PED_HAIR_TINTS

- **命名空间:** `PED`
- **Hash:** `0xE5C0CF872C2AD150`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUM_PED_HAIR_TINTS()
```

**返回值:** `int` (Native: `int`)

---

### GET_NUM_PED_MAKEUP_TINTS

- **命名空间:** `PED`
- **Hash:** `0xD1F7CA1535D22818`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUM_PED_MAKEUP_TINTS()
```

**返回值:** `int` (Native: `int`)

---

### GET_PEDHEADSHOT_TXD_STRING

- **命名空间:** `PED`
- **Hash:** `0xDB4EACD4AD0A5D6B`
- **JHash:** `0x76D28E96`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_PEDHEADSHOT_TXD_STRING(int id)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `id` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
gtaforums.com/topic/885580-ped-headshotmugshot-txd/
```

---

### GET_PEDS_JACKER

- **命名空间:** `PED`
- **Hash:** `0x9B128DC36C1E04CF`
- **JHash:** `0xDE1DBB59`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PEDS_JACKER(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `Ped`)

---

### GET_PED_ACCURACY

- **命名空间:** `PED`
- **Hash:** `0x37F4AD56ECBC0CD6`
- **JHash:** `0x0A2A0AA0`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_ACCURACY(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_PED_ALERTNESS

- **命名空间:** `PED`
- **Hash:** `0xF6AA118530443FD2`
- **JHash:** `0xF83E4DAF`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_ALERTNESS(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns the ped's alertness (0-3).

Values : 

0 : Neutral
1 : Heard something (gun shot, hit, etc)
2 : Knows (the origin of the event)
3 : Fully alerted (is facing the event?)

If the Ped does not exist, returns -1.
```

---

### GET_PED_ARMOUR

- **命名空间:** `PED`
- **Hash:** `0x9483AF821605B1D8`
- **JHash:** `0x2CE311A7`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_ARMOUR(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_PED_AS_GROUP_LEADER

- **命名空间:** `PED`
- **Hash:** `0x5CCE68DBD5FE93EC`
- **JHash:** `0x52873C6A`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_AS_GROUP_LEADER(int groupID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `groupID` | `int` | `int` | - |

**返回值:** `int` (Native: `Ped`)

---

### GET_PED_AS_GROUP_MEMBER

- **命名空间:** `PED`
- **Hash:** `0x51455483CF23ED97`
- **JHash:** `0x9AA3CC8C`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_AS_GROUP_MEMBER(int groupID, int memberNumber)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `groupID` | `int` | `int` | - |
| `memberNumber` | `int` | `int` | - |

**返回值:** `int` (Native: `Ped`)

**说明:**
```
from fm_mission_controller.c4 (variable names changed for clarity):

int groupID = PLAYER::GET_PLAYER_GROUP(PLAYER::PLAYER_ID());
PED::GET_GROUP_SIZE(group, &unused, &groupSize);
if (groupSize >= 1) {
. . . . for (int memberNumber = 0; memberNumber < groupSize; memberNumber++) {
. . . . . . . . Ped ped1 = PED::GET_PED_AS_GROUP_MEMBER(groupID, memberNumber);
. . . . . . . . //and so on
```

---

### GET_PED_BONE_COORDS

- **命名空间:** `PED`
- **Hash:** `0x17C07FC640E86B4E`
- **JHash:** `0x4579CAB1`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_PED_BONE_COORDS(int ped, int boneId, float offsetX, float offsetY, float offsetZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `boneId` | `int` | `int` | - |
| `offsetX` | `float` | `float` | - |
| `offsetY` | `float` | `float` | - |
| `offsetZ` | `float` | `float` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
Gets the position of the specified bone of the specified ped.

ped: The ped to get the position of a bone from.
boneId: The ID of the bone to get the position from. This is NOT the index.
offsetX: The X-component of the offset to add to the position relative to the bone's rotation.
offsetY: The Y-component of the offset to add to the position relative to the bone's rotation.
offsetZ: The Z-component of the offset to add to the position relative to the bone's rotation.
```

---

### GET_PED_BONE_INDEX

- **命名空间:** `PED`
- **Hash:** `0x3F428D08BE5AAE31`
- **JHash:** `0x259C6BA2`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_BONE_INDEX(int ped, int boneId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `boneId` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
no bone= -1

boneIds:
        SKEL_ROOT = 0x0,
   SKEL_Pelvis = 0x2e28,
 SKEL_L_Thigh = 0xe39f,
    SKEL_L_Calf = 0xf9bb,
 SKEL_L_Foot = 0x3779,
 SKEL_L_Toe0 = 0x83c,
  IK_L_Foot = 0xfedd,
   PH_L_Foot = 0xe175,
   MH_L_Knee = 0xb3fe,
   SKEL_R_Thigh = 0xca72,
    SKEL_R_Calf = 0x9000,
 SKEL_R_Foot = 0xcc4d,
 SKEL_R_Toe0 = 0x512d,
 IK_R_Foot = 0x8aae,
   PH_R_Foot = 0x60e6,
   MH_R_Knee = 0x3fcf,
   RB_L_ThighRoll = 0x5c57,
  RB_R_ThighRoll = 0x192a,
  SKEL_Spine_Root = 0xe0fd,
 SKEL_Spine0 = 0x5c01,
 SKEL_Spine1 = 0x60f0,
 SKEL_Spine2 = 0x60f1,
 SKEL_Spine3 = 0x60f2,
 SKEL_L_Clavicle = 0xfcd9,
 SKEL_L_UpperArm = 0xb1c5,
 SKEL_L_Forearm = 0xeeeb,
  SKEL_L_Hand = 0x49d9,
 SKEL_L_Finger00 = 0x67f2,
 SKEL_L_Finger01 = 0xff9,
  SKEL_L_Finger02 = 0xffa,
  SKEL_L_Finger10 = 0x67f3,
 SKEL_L_Finger11 = 0x1049,
 SKEL_L_Finger12 = 0x104a,
 SKEL_L_Finger20 = 0x67f4,
 SKEL_L_Finger21 = 0x1059,
 SKEL_L_Finger22 = 0x105a,
 SKEL_L_Finger30 = 0x67f5,
 SKEL_L_Finger31 = 0x1029,
 SKEL_L_Finger32 = 0x102a,
 SKEL_L_Finger40 = 0x67f6,
 SKEL_L_Finger41 = 0x1039,
 SKEL_L_Finger42 = 0x103a,
 PH_L_Hand = 0xeb95,
   IK_L_Hand = 0x8cbd,
   RB_L_ForeArmRoll = 0xee4f,
    RB_L_ArmRoll = 0x1470,
    MH_L_Elbow = 0x58b7,
  SKEL_R_Clavicle = 0x29d2,
 SKEL_R_UpperArm = 0x9d4d,
 SKEL_R_Forearm = 0x6e5c,
  SKEL_R_Hand = 0xdead,
 SKEL_R_Finger00 = 0xe5f2,
 SKEL_R_Finger01 = 0xfa10,
 SKEL_R_Finger02 = 0xfa11,
 SKEL_R_Finger10 = 0xe5f3,
 SKEL_R_Finger11 = 0xfa60,
 SKEL_R_Finger12 = 0xfa61,
 SKEL_R_Finger20 = 0xe5f4,
 SKEL_R_Finger21 = 0xfa70,
 SKEL_R_Finger22 = 0xfa71,
 SKEL_R_Finger30 = 0xe5f5,
 SKEL_R_Finger31 = 0xfa40,
 SKEL_R_Finger32 = 0xfa41,
 SKEL_R_Finger40 = 0xe5f6,
 SKEL_R_Finger41 = 0xfa50,
 SKEL_R_Finger42 = 0xfa51,
 PH_R_Hand = 0x6f06,
   IK_R_Hand = 0x188e,
   RB_R_ForeArmRoll = 0xab22,
    RB_R_ArmRoll = 0x90ff,
    MH_R_Elbow = 0xbb0,
   SKEL_Neck_1 = 0x9995,
 SKEL_Head = 0x796e,
   IK_Head = 0x322c,
 FACIAL_facialRoot = 0xfe2c,
   FB_L_Brow_Out_000 = 0xe3db,
   FB_L_Lid_Upper_000 = 0xb2b6,
  FB_L_Eye_000 = 0x62ac,
    FB_L_CheekBone_000 = 0x542e,
  FB_L_Lip_Corner_000 = 0x74ac,
 FB_R_Lid_Upper_000 = 0xaa10,
  FB_R_Eye_000 = 0x6b52,
    FB_R_CheekBone_000 = 0x4b88,
  FB_R_Brow_Out_000 = 0x54c,
    FB_R_Lip_Corner_000 = 0x2ba6,
 FB_Brow_Centre_000 = 0x9149,
  FB_UpperLipRoot_000 = 0x4ed2,
 FB_UpperLip_000 = 0xf18f,
 FB_L_Lip_Top_000 = 0x4f37,
    FB_R_Lip_Top_000 = 0x4537,
    FB_Jaw_000 = 0xb4a0,
  FB_LowerLipRoot_000 = 0x4324,
 FB_LowerLip_000 = 0x508f,
 FB_L_Lip_Bot_000 = 0xb93b,
    FB_R_Lip_Bot_000 = 0xc33b,
    FB_Tongue_000 = 0xb987,
   RB_Neck_1 = 0x8b93,
   IK_Root = 0xdd1c
```

---

### GET_PED_CAUSE_OF_DEATH

- **命名空间:** `PED`
- **Hash:** `0x16FFE42AB2D2DC59`
- **JHash:** `0x63458C27`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_PED_CAUSE_OF_DEATH(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `uint` (Native: `Hash`)

**说明:**
```
Returns the hash of the weapon/model/object that killed the ped.
```

---

### GET_PED_COMBAT_MOVEMENT

- **命名空间:** `PED`
- **Hash:** `0xDEA92412FCAEB3F5`
- **JHash:** `0xF3E7730E`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_COMBAT_MOVEMENT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
See SET_PED_COMBAT_MOVEMENT
```

---

### GET_PED_COMBAT_RANGE

- **命名空间:** `PED`
- **Hash:** `0xF9D9F7F2DB8E2FA0`
- **JHash:** `0x9B9B7163`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_COMBAT_RANGE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
See SET_PED_COMBAT_RANGE
```

---

### GET_PED_CONFIG_FLAG

- **命名空间:** `PED`
- **Hash:** `0x7EE53118C892B513`
- **JHash:** `0xABE98267`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_PED_CONFIG_FLAG(int ped, int flagId, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `flagId` | `int` | `int` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
See SET_PED_CONFIG_FLAG
```

---

### GET_PED_CURRENT_MOVE_BLEND_RATIO

- **命名空间:** `PED`
- **Hash:** `0xF60165E1D2C5370B`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_PED_CURRENT_MOVE_BLEND_RATIO(int ped, ref float speedX, ref float speedY)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `speedX` | `float*` | `ref float` | - |
| `speedY` | `float*` | `ref float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_PED_DECORATIONS_STATE

- **命名空间:** `PED`
- **Hash:** `0x71EAB450D86954A1`
- **JHash:** `0x47187F7F`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_DECORATIONS_STATE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_PED_DECORATION_ZONE_FROM_HASHES

- **命名空间:** `PED`
- **Hash:** `0x9FD452BFBE7A7A8B`
- **JHash:** `0x3543019E`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_DECORATION_ZONE_FROM_HASHES(uint collection, uint overlay)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `collection` | `Hash` | `uint` | - |
| `overlay` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns the zoneID for the overlay if it is a member of collection.
enum ePedDecorationZone
{
	ZONE_TORSO = 0,
	ZONE_HEAD = 1,
	ZONE_LEFT_ARM = 2,
	ZONE_RIGHT_ARM = 3,
	ZONE_LEFT_LEG = 4,
	ZONE_RIGHT_LEG = 5,
	ZONE_MEDALS = 6,
	ZONE_INVALID = 7
};

Full list of ped overlays / decorations by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pedOverlayCollections.json
```

---

### GET_PED_DEFENSIVE_AREA_POSITION

- **命名空间:** `PED`
- **Hash:** `0x3C06B8786DD94CD1`
- **JHash:** `0xCB65198D`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_PED_DEFENSIVE_AREA_POSITION(int ped, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `Vector3` (Native: `Vector3`)

---

### GET_PED_DIES_IN_WATER

- **命名空间:** `PED`
- **Hash:** `0x65671A4FB8218930`
- **Build:** `2699`

**C# 签名:**
```csharp
bool GET_PED_DIES_IN_WATER(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_PED_DRAWABLE_VARIATION

- **命名空间:** `PED`
- **Hash:** `0x67F3780DD425D4FC`
- **JHash:** `0x29850FE2`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_DRAWABLE_VARIATION(int ped, int componentId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `componentId` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Ids
0 - Head
1 - Beard
2 - Hair
3 - Torso
4 - Legs
5 - Hands
6 - Foot
7 - ------
8 - Accessories 1
9 - Accessories 2
10- Decals
11 - Auxiliary parts for torso
```

---

### GET_PED_EMISSIVE_SCALE

- **命名空间:** `PED`
- **Hash:** `0x1461B28A06717D68`
- **Build:** `944`

**C# 签名:**
```csharp
float GET_PED_EMISSIVE_SCALE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Use 0x4E90D746056E273D to set the illuminated clothing glow intensity for a specific ped.
Returns a float between 0.0 and 1.0 representing the current illuminated clothing glow intensity.
```

---

### GET_PED_ENVEFF_SCALE

- **命名空间:** `PED`
- **Hash:** `0x9C14D30395A51A3C`
- **JHash:** `0xA3421E39`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_PED_ENVEFF_SCALE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_PED_EXTRACTED_DISPLACEMENT

- **命名空间:** `PED`
- **Hash:** `0xE0AF41401ADF87E3`
- **JHash:** `0x5231F901`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_PED_EXTRACTED_DISPLACEMENT(int ped, bool worldSpace)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `worldSpace` | `BOOL` | `bool` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
Gets the offset the specified ped has moved since the previous tick.

If worldSpace is false, the returned offset is relative to the ped. That is, if the ped has moved 1 meter right and 5 meters forward, it'll return 1,5,0.

If worldSpace is true, the returned offset is relative to the world. That is, if the ped has moved 1 meter on the X axis and 5 meters on the Y axis, it'll return 1,5,0.
```

---

### GET_PED_GROUP_INDEX

- **命名空间:** `PED`
- **Hash:** `0xF162E133B4E7A675`
- **JHash:** `0x134E0785`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_GROUP_INDEX(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns the group id of which the specified ped is a member of.
```

---

### GET_PED_HAIR_TINT_COLOR

- **命名空间:** `PED`
- **Hash:** `0x4852FC386E2E1BB5`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_PED_HAIR_TINT_COLOR(int hairColorIndex, ref int outR, ref int outG, ref int outB)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `hairColorIndex` | `int` | `int` | - |
| `outR` | `int*` | `ref int` | - |
| `outG` | `int*` | `ref int` | - |
| `outB` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Input: Haircolor index, value between 0 and 63 (inclusive).
Output: RGB values for the haircolor specified in the input.

This is used with the hair color swatches scaleform.
Use `GET_PED_MAKEUP_TINT_COLOR` to get the makeup colors.
```

---

### GET_PED_HEAD_BLEND_DATA

- **命名空间:** `PED`
- **Hash:** `0x2746BD9D88C5C5D0`
- **JHash:** `0x44E1680C`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_PED_HEAD_BLEND_DATA(int ped, ref object headBlendData)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `headBlendData` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
The pointer is to a padded struct that matches the arguments to SET_PED_HEAD_BLEND_DATA(...). There are 4 bytes of padding after each field.
pass this struct in the second parameter 
struct headBlendData
{
    int shapeFirst;
    int padding1;
    int shapeSecond;
    int padding2;
    int shapeThird;
    int padding3;
    int skinFirst;
    int padding4;
    int skinSecond;
    int padding5;
    int skinThird;
    int padding6;
    float shapeMix;
    int padding7;
    float skinMix;
    int padding8;
    float thirdMix;
    int padding9;
    bool isParent;
};
```

---

### GET_PED_HEAD_BLEND_FIRST_INDEX

- **命名空间:** `PED`
- **Hash:** `0x68D353AB88B97E0C`
- **JHash:** `0x211DEFEC`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_HEAD_BLEND_FIRST_INDEX(int type)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `type` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Type equals 0 for male non-dlc, 1 for female non-dlc, 2 for male dlc, and 3 for female dlc.

Used when calling SET_PED_HEAD_BLEND_DATA.
```

---

### GET_PED_HEAD_BLEND_NUM_HEADS

- **命名空间:** `PED`
- **Hash:** `0x5EF37013A6539C9D`
- **JHash:** `0x095D3BD8`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_HEAD_BLEND_NUM_HEADS(int type)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `type` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Type equals 0 for male non-dlc, 1 for female non-dlc, 2 for male dlc, and 3 for female dlc.
```

---

### GET_PED_HEAD_OVERLAY

- **命名空间:** `PED`
- **Hash:** `0xA60EF3B6461A4D43`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_HEAD_OVERLAY(int ped, int overlayID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `overlayID` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Likely a char, if that overlay is not set, e.i. "None" option, returns 255;

This might be the once removed native GET_PED_HEAD_OVERLAY.
```

---

### GET_PED_HEAD_OVERLAY_NUM

- **命名空间:** `PED`
- **Hash:** `0xCF1CE768BB43480E`
- **JHash:** `0xFF43C18D`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_HEAD_OVERLAY_NUM(int overlayID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `overlayID` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_PED_HELMET_STORED_HAT_PROP_INDEX

- **命名空间:** `PED`
- **Hash:** `0x451294E859ECC018`
- **JHash:** `0x8A3A3116`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_HELMET_STORED_HAT_PROP_INDEX(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_PED_HELMET_STORED_HAT_TEX_INDEX

- **命名空间:** `PED`
- **Hash:** `0x9D728C1E12BF5518`
- **JHash:** `0x74EB662D`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_HELMET_STORED_HAT_TEX_INDEX(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_PED_LAST_DAMAGE_BONE

- **命名空间:** `PED`
- **Hash:** `0xD75960F6BD9EA49C`
- **JHash:** `0xAB933841`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_PED_LAST_DAMAGE_BONE(int ped, ref int outBone)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `outBone` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_PED_MAKEUP_TINT_COLOR

- **命名空间:** `PED`
- **Hash:** `0x013E5CFC38CD5387`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_PED_MAKEUP_TINT_COLOR(int makeupColorIndex, ref int outR, ref int outG, ref int outB)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `makeupColorIndex` | `int` | `int` | - |
| `outR` | `int*` | `ref int` | - |
| `outG` | `int*` | `ref int` | - |
| `outB` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Input: Makeup color index, value between 0 and 63 (inclusive).
Output: RGB values for the makeup color specified in the input.

This is used with the makeup color swatches scaleform.
Use `GET_PED_HAIR_TINT_COLOR` to get the hair colors.
```

---

### GET_PED_MAX_HEALTH

- **命名空间:** `PED`
- **Hash:** `0x4700A416E8324EF3`
- **JHash:** `0xA45B6C8D`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_MAX_HEALTH(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_PED_MONEY

- **命名空间:** `PED`
- **Hash:** `0x3F69145BBA87BAE7`
- **JHash:** `0xEB3C4C7E`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_MONEY(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_PED_NEARBY_PEDS

- **命名空间:** `PED`
- **Hash:** `0x23F8F5FC7E8C4A6B`
- **JHash:** `0x4D3325F4`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_NEARBY_PEDS(int ped, ref object sizeAndPeds, int ignore)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `sizeAndPeds` | `Any*` | `ref object` | - |
| `ignore` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
sizeAndPeds - is a pointer to an array. The array is filled with peds found nearby the ped supplied to the first argument.
ignore - ped type to ignore

Return value is the number of peds found and added to the array passed.

-----------------------------------

To make this work in most menu bases at least in C++ do it like so,

 Formatted Example: https://pastebin.com/D8an9wwp

-----------------------------------

Example: gtaforums.com/topic/789788-function-args-to-pedget-ped-nearby-peds/?p=1067386687
```

---

### GET_PED_NEARBY_VEHICLES

- **命名空间:** `PED`
- **Hash:** `0xCFF869CBFA210D82`
- **JHash:** `0xCB716F68`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_NEARBY_VEHICLES(int ped, ref object sizeAndVehs)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `sizeAndVehs` | `Any*` | `ref object` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns size of array, passed into the second variable.

See below for usage information.

This function actually requires a struct, where the first value is the maximum number of elements to return.  Here is a sample of how I was able to get it to work correctly, without yet knowing the struct format.

//Setup the array
 const int numElements = 10;
   const int arrSize = numElements * 2 + 2;
  Any veh[arrSize];
 //0 index is the size of the array
    veh[0] = numElements;

   int count = PED::GET_PED_NEARBY_VEHICLES(PLAYER::PLAYER_PED_ID(), veh);

 if (veh != NULL)
  {
     //Simple loop to go through results
       for (int i = 0; i < count; i++)
        {
         int offsettedID = i * 2 + 2;
          //Make sure it exists
         if (veh[offsettedID] != NULL && ENTITY::DOES_ENTITY_EXIST(veh[offsettedID]))
          {
             //Do something
            }
     }
 }  
```

---

### GET_PED_PALETTE_VARIATION

- **命名空间:** `PED`
- **Hash:** `0xE3DD5F2A84B42281`
- **JHash:** `0xEF1BC082`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_PALETTE_VARIATION(int ped, int componentId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `componentId` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
List of component/props ID
gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
```

---

### GET_PED_PARACHUTE_LANDING_TYPE

- **命名空间:** `PED`
- **Hash:** `0x8B9F1FC6AE8166C0`
- **JHash:** `0x01F3B035`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_PARACHUTE_LANDING_TYPE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
-1: no landing
0: landing on both feet
1: stumbling
2: rolling
3: ragdoll
```

---

### GET_PED_PARACHUTE_STATE

- **命名空间:** `PED`
- **Hash:** `0x79CFD9827CC979B6`
- **JHash:** `0x7D4BC475`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_PARACHUTE_STATE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns:

-1: Normal
0: Wearing parachute on back
1: Parachute opening
2: Parachute open
3: Falling to doom (e.g. after exiting parachute)

Normal means no parachute?
```

---

### GET_PED_PARACHUTE_TINT_INDEX

- **命名空间:** `PED`
- **Hash:** `0xEAF5F7E5AE7C6C9D`
- **JHash:** `0xE9E7FAC5`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_PED_PARACHUTE_TINT_INDEX(int ped, ref int outTintIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `outTintIndex` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

---

### GET_PED_PROP_INDEX

- **命名空间:** `PED`
- **Hash:** `0x898CC20EA75BACD8`
- **JHash:** `0x746DDAC0`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_PROP_INDEX(int ped, int componentId, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `componentId` | `int` | `int` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
List of component/props ID
gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
```

---

### GET_PED_PROP_TEXTURE_INDEX

- **命名空间:** `PED`
- **Hash:** `0xE131A28626F81AB2`
- **JHash:** `0x922A6653`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_PROP_TEXTURE_INDEX(int ped, int componentId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `componentId` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
List of component/props ID
gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
```

---

### GET_PED_RAGDOLL_BONE_INDEX

- **命名空间:** `PED`
- **Hash:** `0x2057EF813397A772`
- **JHash:** `0x849F0716`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_RAGDOLL_BONE_INDEX(int ped, int bone)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `bone` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH

- **命名空间:** `PED`
- **Hash:** `0x42FDD0F017B1E38E`
- **JHash:** `0x714BD6E4`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `uint` (Native: `Hash`)

---

### GET_PED_RELATIONSHIP_GROUP_HASH

- **命名空间:** `PED`
- **Hash:** `0x7DBDD04862D95F04`
- **JHash:** `0x354F283C`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_PED_RELATIONSHIP_GROUP_HASH(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `uint` (Native: `Hash`)

---

### GET_PED_RESET_FLAG

- **命名空间:** `PED`
- **Hash:** `0xAF9E59B1B1FBF2A0`
- **JHash:** `0x2FC10D11`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_PED_RESET_FLAG(int ped, int flagId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `flagId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_PED_SOURCE_OF_DEATH

- **命名空间:** `PED`
- **Hash:** `0x93C8B64DEB84728C`
- **JHash:** `0x84ADF9EB`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_SOURCE_OF_DEATH(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `Entity`)

**说明:**
```
Returns the Entity (Ped, Vehicle, or ?Object?) that killed the 'ped'

Is best to check if the Ped is dead before asking for its killer.
```

---

### GET_PED_STEALTH_MOVEMENT

- **命名空间:** `PED`
- **Hash:** `0x7C2AC9CA66575FBF`
- **JHash:** `0x40321B83`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_PED_STEALTH_MOVEMENT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns whether the entity is in stealth mode
```

---

### GET_PED_TARGET_FROM_COMBAT_PED

- **命名空间:** `PED`
- **Hash:** `0x32C27A11307B01CC`
- **Build:** `2372`

**C# 签名:**
```csharp
int GET_PED_TARGET_FROM_COMBAT_PED(int ped, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `int` (Native: `Entity`)

---

### GET_PED_TEXTURE_VARIATION

- **命名空间:** `PED`
- **Hash:** `0x04A355E041E004E6`
- **JHash:** `0xC0A8590A`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_TEXTURE_VARIATION(int ped, int componentId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `componentId` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
List of component/props ID
gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
```

---

### GET_PED_TIME_OF_DEATH

- **命名空间:** `PED`
- **Hash:** `0x1E98817B311AE98A`
- **JHash:** `0xDF6D5D54`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_TIME_OF_DEATH(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_PED_TYPE

- **命名空间:** `PED`
- **Hash:** `0xFF059E1E4C01E63C`
- **JHash:** `0xB1460D43`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_TYPE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
https://alloc8or.re/gta5/doc/enums/ePedType.txt
```

---

### GET_PED_VISUAL_FIELD_CENTER_ANGLE

- **命名空间:** `PED`
- **Hash:** `0xEF2C71A32CAD5FBD`
- **Build:** `1493`

**C# 签名:**
```csharp
float GET_PED_VISUAL_FIELD_CENTER_ANGLE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_PLAYER_PED_IS_FOLLOWING

- **命名空间:** `PED`
- **Hash:** `0x6A3975DEA89F9A17`
- **JHash:** `0xDE7442EE`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PLAYER_PED_IS_FOLLOWING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `Player`)

---

### GET_POS_FROM_FIRED_EVENT

- **命名空间:** `PED`
- **Hash:** `0xBA656A3BB01BDEA3`
- **Build:** `2189`

**C# 签名:**
```csharp
bool GET_POS_FROM_FIRED_EVENT(int ped, int eventType, ref object outData)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `eventType` | `int` | `int` | - |
| `outData` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_RANDOM_PED_AT_COORD

- **命名空间:** `PED`
- **Hash:** `0x876046A8E3A4B71C`
- **JHash:** `0xDC8239EB`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_RANDOM_PED_AT_COORD(float x, float y, float z, float xRadius, float yRadius, float zRadius, int pedType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `xRadius` | `float` | `float` | - |
| `yRadius` | `float` | `float` | - |
| `zRadius` | `float` | `float` | - |
| `pedType` | `int` | `int` | - |

**返回值:** `int` (Native: `Ped`)

**说明:**
```
Gets a random ped in the x/y/zRadius near the x/y/z coordinates passed. 

Ped Types:
Any = -1
Player = 1
Male = 4 
Female = 5 
Cop = 6
Human = 26
SWAT = 27 
Animal = 28
Army = 29
```

---

### GET_RELATIONSHIP_BETWEEN_GROUPS

- **命名空间:** `PED`
- **Hash:** `0x9E6B70061662AE5C`
- **JHash:** `0x4E372FE2`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_RELATIONSHIP_BETWEEN_GROUPS(uint group1, uint group2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `group1` | `Hash` | `uint` | - |
| `group2` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Gets the relationship between two groups. This should be called twice (once for each group).

Relationship types:
0 = Companion
1 = Respect
2 = Like
3 = Neutral
4 = Dislike
5 = Hate
255 = Pedestrians

Example:
PED::GET_RELATIONSHIP_BETWEEN_GROUPS(l_1017, 0xA49E591C);
PED::GET_RELATIONSHIP_BETWEEN_GROUPS(0xA49E591C, l_1017);
```

---

### GET_RELATIONSHIP_BETWEEN_PEDS

- **命名空间:** `PED`
- **Hash:** `0xEBA5AD3A0EAF7121`
- **JHash:** `0xE254C39C`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_RELATIONSHIP_BETWEEN_PEDS(int ped1, int ped2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped1` | `Ped` | `int` | - |
| `ped2` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Gets the relationship between two peds. This should be called twice (once for each ped).

Relationship types:
0 = Companion
1 = Respect
2 = Like
3 = Neutral
4 = Dislike
5 = Hate
255 = Pedestrians
(Credits: Inco)

Example:
PED::GET_RELATIONSHIP_BETWEEN_PEDS(2, l_1017, 0xA49E591C);
PED::GET_RELATIONSHIP_BETWEEN_PEDS(2, 0xA49E591C, l_1017);
```

---

### GET_SEAT_PED_IS_TRYING_TO_ENTER

- **命名空间:** `PED`
- **Hash:** `0x6F4C85ACD641BCD2`
- **JHash:** `0xACF162E0`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_SEAT_PED_IS_TRYING_TO_ENTER(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_SYNCHRONIZED_SCENE_PHASE

- **命名空间:** `PED`
- **Hash:** `0xE4A310B1D7FA73CC`
- **JHash:** `0xB0B2C852`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_SYNCHRONIZED_SCENE_PHASE(int sceneID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `sceneID` | `int` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_SYNCHRONIZED_SCENE_RATE

- **命名空间:** `PED`
- **Hash:** `0xD80932D577274D40`
- **JHash:** `0x89365F0D`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_SYNCHRONIZED_SCENE_RATE(int sceneID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `sceneID` | `int` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_TIME_PED_DAMAGED_BY_WEAPON

- **命名空间:** `PED`
- **Hash:** `0x36B77BB84687C318`
- **JHash:** `0x0170C6E1`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_TIME_PED_DAMAGED_BY_WEAPON(int ped, uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

---

### GET_TINT_INDEX_FOR_LAST_GEN_HAIR_TEXTURE

- **命名空间:** `PED`
- **Hash:** `0xC56FBF2F228E1DAC`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_TINT_INDEX_FOR_LAST_GEN_HAIR_TEXTURE(uint modelHash, int drawableId, int textureId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |
| `drawableId` | `int` | `int` | - |
| `textureId` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_TRACKED_PED_PIXELCOUNT

- **命名空间:** `PED`
- **Hash:** `0x511F1A683387C7E2`
- **JHash:** `0x5B1B70AA`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_TRACKED_PED_PIXELCOUNT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_VEHICLE_PED_IS_ENTERING

- **命名空间:** `PED`
- **Hash:** `0xF92691AED837A5FC`
- **JHash:** `0x56E0C163`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_PED_IS_ENTERING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `Vehicle`)

---

### GET_VEHICLE_PED_IS_IN

- **命名空间:** `PED`
- **Hash:** `0x9A9112A0FE9A4713`
- **JHash:** `0xAFE92319`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_PED_IS_IN(int ped, bool includeEntering)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `includeEntering` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `Vehicle`)

**说明:**
```
Gets the vehicle the specified Ped is in. Returns 0 if the ped is/was not in a vehicle.
```

---

### GET_VEHICLE_PED_IS_TRYING_TO_ENTER

- **命名空间:** `PED`
- **Hash:** `0x814FA8BE5449445D`
- **JHash:** `0x99968B37`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_PED_IS_TRYING_TO_ENTER(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `Vehicle`)

---

### GET_VEHICLE_PED_IS_USING

- **命名空间:** `PED`
- **Hash:** `0x6094AD011A2EA87D`
- **JHash:** `0x6DE3AADA`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_PED_IS_USING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `Vehicle`)

**说明:**
```
Gets ID of vehicle player using. It means it can get ID at any interaction with vehicle. Enter\exit for example. And that means it is faster than GET_VEHICLE_PED_IS_IN but less safe.
```

---

### GIVE_PED_HELMET

- **命名空间:** `PED`
- **Hash:** `0x54C7C4A94367717E`
- **JHash:** `0x1862A461`
- **Build:** `323`

**C# 签名:**
```csharp
void GIVE_PED_HELMET(int ped, bool cannotRemove, int helmetFlag, int textureIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `cannotRemove` | `BOOL` | `bool` | - |
| `helmetFlag` | `int` | `int` | - |
| `textureIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
PoliceMotorcycleHelmet   1024    
RegularMotorcycleHelmet   4096    
FiremanHelmet 16384   
PilotHeadset  32768   
PilotHelmet   65536
--
p2 is generally 4096 or 16384 in the scripts. p1 varies between 1 and 0.
```

---

### GIVE_PED_NM_MESSAGE

- **命名空间:** `PED`
- **Hash:** `0xB158DFCCC56E5C5B`
- **JHash:** `0x737C3689`
- **Build:** `323`

**C# 签名:**
```csharp
void GIVE_PED_NM_MESSAGE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sends the message that was created by a call to CREATE_NM_MESSAGE to the specified Ped.

If a message hasn't been created already, this function does nothing.
If the Ped is not ragdolled with Euphoria enabled, this function does nothing.
The following call can be used to ragdoll the Ped with Euphoria enabled: SET_PED_TO_RAGDOLL(ped, 4000, 5000, 1, 1, 1, 0);

Call order:
SET_PED_TO_RAGDOLL
CREATE_NM_MESSAGE
GIVE_PED_NM_MESSAGE

Multiple messages can be chained. Eg. to make the ped stagger and swing his arms around, the following calls can be made:
SET_PED_TO_RAGDOLL(ped, 4000, 5000, 1, 1, 1, 0);
CREATE_NM_MESSAGE(true, 0); // stopAllBehaviours - Stop all other behaviours, in case the Ped is already doing some Euphoria stuff.
GIVE_PED_NM_MESSAGE(ped); // Dispatch message to Ped.
CREATE_NM_MESSAGE(true, 1151); // staggerFall - Attempt to walk while falling.
GIVE_PED_NM_MESSAGE(ped); // Dispatch message to Ped.
CREATE_NM_MESSAGE(true, 372); // armsWindmill - Swing arms around.
GIVE_PED_NM_MESSAGE(ped); // Dispatch message to Ped.
```

---

### HAS_ACTION_MODE_ASSET_LOADED

- **命名空间:** `PED`
- **Hash:** `0xE4B5F4BF2CB24E65`
- **JHash:** `0xF7EB2BF1`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_ACTION_MODE_ASSET_LOADED(string asset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `asset` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_PEDHEADSHOT_IMG_UPLOAD_FAILED

- **命名空间:** `PED`
- **Hash:** `0x876928DDDFCCC9CD`
- **JHash:** `0x05023F8F`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_PEDHEADSHOT_IMG_UPLOAD_FAILED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_PEDHEADSHOT_IMG_UPLOAD_SUCCEEDED

- **命名空间:** `PED`
- **Hash:** `0xE8A169E666CBC541`
- **JHash:** `0xAA39FD6C`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_PEDHEADSHOT_IMG_UPLOAD_SUCCEEDED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_PED_HEAD_BLEND_FINISHED

- **命名空间:** `PED`
- **Hash:** `0x654CD0A825161131`
- **JHash:** `0x2B1BD9C5`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_PED_HEAD_BLEND_FINISHED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_PED_PRELOAD_PROP_DATA_FINISHED

- **命名空间:** `PED`
- **Hash:** `0x784002A632822099`
- **JHash:** `0x3B0CA391`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_PED_PRELOAD_PROP_DATA_FINISHED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_PED_PRELOAD_VARIATION_DATA_FINISHED

- **命名空间:** `PED`
- **Hash:** `0x66680A92700F43DF`
- **JHash:** `0xC6517D52`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_PED_PRELOAD_VARIATION_DATA_FINISHED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_PED_RECEIVED_EVENT

- **命名空间:** `PED`
- **Hash:** `0x8507BCB710FA6DC0`
- **JHash:** `0xECD73DB0`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_PED_RECEIVED_EVENT(int ped, int eventId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `eventId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_STEALTH_MODE_ASSET_LOADED

- **命名空间:** `PED`
- **Hash:** `0xE977FC5B08AF3441`
- **JHash:** `0x39245667`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_STEALTH_MODE_ASSET_LOADED(string asset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `asset` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAVE_ALL_STREAMING_REQUESTS_COMPLETED

- **命名空间:** `PED`
- **Hash:** `0x7350823473013C02`
- **JHash:** `0xF9FB4B71`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAVE_ALL_STREAMING_REQUESTS_COMPLETED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HIDE_PED_BLOOD_DAMAGE_BY_ZONE

- **命名空间:** `PED`
- **Hash:** `0x62AB793144DE75DC`
- **JHash:** `0x0CB6C4ED`
- **Build:** `323`

**C# 签名:**
```csharp
void HIDE_PED_BLOOD_DAMAGE_BY_ZONE(int ped, object p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### INSTANTLY_FILL_PED_POPULATION

- **命名空间:** `PED`
- **Hash:** `0x4759CC730F947C81`
- **JHash:** `0x8C555ADD`
- **Build:** `323`

**C# 签名:**
```csharp
void INSTANTLY_FILL_PED_POPULATION()
```

**返回值:** `void` (Native: `void`)

---

### IS_ANY_HOSTILE_PED_NEAR_POINT

- **命名空间:** `PED`
- **Hash:** `0x68772DB2B2526F9F`
- **JHash:** `0x1A464167`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ANY_HOSTILE_PED_NEAR_POINT(int ped, float x, float y, float z, float radius)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ANY_PED_NEAR_POINT

- **命名空间:** `PED`
- **Hash:** `0x083961498679DC9F`
- **JHash:** `0xFBD9B050`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ANY_PED_NEAR_POINT(float x, float y, float z, float radius)
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

### IS_ANY_PED_SHOOTING_IN_AREA

- **命名空间:** `PED`
- **Hash:** `0xA0D3D71EA1086C55`
- **JHash:** `0x91833867`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ANY_PED_SHOOTING_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool p6, bool p7)
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
| `p7` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_CONVERSATION_PED_DEAD

- **命名空间:** `PED`
- **Hash:** `0xE0A0AEC214B1FABA`
- **JHash:** `0x1FA39EFE`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_CONVERSATION_PED_DEAD(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_COP_PED_IN_AREA_3D

- **命名空间:** `PED`
- **Hash:** `0x16EC4839969F9F5E`
- **JHash:** `0xB98DB96B`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_COP_PED_IN_AREA_3D(float x1, float y1, float z1, float x2, float y2, float z2)
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
xyz - relative to the world origin.
```

---

### IS_CURRENT_HEAD_PROP_A_HELMET

- **命名空间:** `PED`
- **Hash:** `0xF2385935BFFD4D92`
- **JHash:** `0xFFF149FE`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_CURRENT_HEAD_PROP_A_HELMET(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_MOBILE_PHONE_TO_PED_EAR

- **命名空间:** `PED`
- **Hash:** `0xA3F3564A5B3646C0`
- **JHash:** `0x97353375`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_MOBILE_PHONE_TO_PED_EAR(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PEDHEADSHOT_IMG_UPLOAD_AVAILABLE

- **命名空间:** `PED`
- **Hash:** `0xEBB376779A760AA8`
- **JHash:** `0x810158F8`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PEDHEADSHOT_IMG_UPLOAD_AVAILABLE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PEDHEADSHOT_READY

- **命名空间:** `PED`
- **Hash:** `0x7085228842B13A67`
- **JHash:** `0x761CD02E`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PEDHEADSHOT_READY(int id)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `id` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
gtaforums.com/topic/885580-ped-headshotmugshot-txd/
```

---

### IS_PEDHEADSHOT_VALID

- **命名空间:** `PED`
- **Hash:** `0xA0A9668F158129A2`
- **JHash:** `0x0B1080C4`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PEDHEADSHOT_VALID(int id)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `id` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
gtaforums.com/topic/885580-ped-headshotmugshot-txd/
```

---

### IS_PED_AIMING_FROM_COVER

- **命名空间:** `PED`
- **Hash:** `0x3998B1276A3300E5`
- **JHash:** `0xDEBAB2AF`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_AIMING_FROM_COVER(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_A_PLAYER

- **命名空间:** `PED`
- **Hash:** `0x12534C348C6CB68B`
- **JHash:** `0x404794CA`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_A_PLAYER(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if the given ped has a valid pointer to CPlayerInfo in its CPed class. That's all.
```

---

### IS_PED_BEING_JACKED

- **命名空间:** `PED`
- **Hash:** `0x9A497FE2DF198913`
- **JHash:** `0xD45D605C`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_BEING_JACKED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_BEING_STEALTH_KILLED

- **命名空间:** `PED`
- **Hash:** `0x863B23EFDE9C5DF2`
- **JHash:** `0xD044C8AF`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_BEING_STEALTH_KILLED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_BEING_STUNNED

- **命名空间:** `PED`
- **Hash:** `0x4FBACCE3B4138EE8`
- **JHash:** `0x0A66CE30`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_BEING_STUNNED(int ped, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p1 is always 0
```

---

### IS_PED_BLUSH_FACEPAINT_TINT_FOR_BARBER

- **命名空间:** `PED`
- **Hash:** `0x09E7ECA981D9B210`
- **Build:** `1290`

**C# 签名:**
```csharp
bool IS_PED_BLUSH_FACEPAINT_TINT_FOR_BARBER(int colorId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `colorId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_BLUSH_TINT_FOR_BARBER

- **命名空间:** `PED`
- **Hash:** `0x604E810189EE3A59`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_BLUSH_TINT_FOR_BARBER(int colorID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `colorID` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_BLUSH_TINT_FOR_CREATOR

- **命名空间:** `PED`
- **Hash:** `0xF41B5D290C99A3D6`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_BLUSH_TINT_FOR_CREATOR(int colorId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `colorId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_CLIMBING

- **命名空间:** `PED`
- **Hash:** `0x53E8CB4F48BFE623`
- **JHash:** `0xBCE03D35`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_CLIMBING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_COMPONENT_VARIATION_VALID

- **命名空间:** `PED`
- **Hash:** `0xE825F6B6CEA7671D`
- **JHash:** `0x952ABD9A`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_COMPONENT_VARIATION_VALID(int ped, int componentId, int drawableId, int textureId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `componentId` | `int` | `int` | - |
| `drawableId` | `int` | `int` | - |
| `textureId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Checks if the component variation is valid, this works great for randomizing components using loops.

List of component/props ID
gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html

Full list of ped components by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pedComponentVariations.json
```

---

### IS_PED_DEAD_OR_DYING

- **命名空间:** `PED`
- **Hash:** `0x3317DEDB88C95038`
- **JHash:** `0xCBDB7739`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_DEAD_OR_DYING(int ped, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Seems to consistently return true if the ped is dead.

p1 is always passed 1 in the scripts.

I suggest to remove "OR_DYING" part, because it does not detect dying phase.

That's what the devs call it, cry about it.

lol
```

---

### IS_PED_DEFENSIVE_AREA_ACTIVE

- **命名空间:** `PED`
- **Hash:** `0xBA63D9FE45412247`
- **JHash:** `0x6D88BCD3`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_DEFENSIVE_AREA_ACTIVE(int ped, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_DIVING

- **命名空间:** `PED`
- **Hash:** `0x5527B8246FEF9B11`
- **JHash:** `0x7BC5BF3C`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_DIVING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_DOING_A_BEAST_JUMP

- **命名空间:** `PED`
- **Hash:** `0x451D05012CCEC234`
- **Build:** `573`

**C# 签名:**
```csharp
bool IS_PED_DOING_A_BEAST_JUMP(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_DOING_DRIVEBY

- **命名空间:** `PED`
- **Hash:** `0xB2C086CC1BF8F2BF`
- **JHash:** `0xAC3CEB9C`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_DOING_DRIVEBY(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_DUCKING

- **命名空间:** `PED`
- **Hash:** `0xD125AE748725C6BC`
- **JHash:** `0x9199C77D`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_DUCKING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_EVASIVE_DIVING

- **命名空间:** `PED`
- **Hash:** `0x414641C26E105898`
- **JHash:** `0xD82829DC`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_EVASIVE_DIVING(int ped, Entity* evadingEntity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `evadingEntity` | `Entity*` | `Entity*` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Presumably returns the Entity that the Ped is currently diving out of the way of.

var num3;
    if (PED::IS_PED_EVASIVE_DIVING(A_0, &num3) != 0)
        if (ENTITY::IS_ENTITY_A_VEHICLE(num3) != 0)
```

---

### IS_PED_FACING_PED

- **命名空间:** `PED`
- **Hash:** `0xD71649DB0A545AA3`
- **JHash:** `0x0B775838`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_FACING_PED(int ped, int otherPed, float angle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `otherPed` | `Ped` | `int` | - |
| `angle` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
angle is ped's view cone
```

---

### IS_PED_FALLING

- **命名空间:** `PED`
- **Hash:** `0xFB92A102F1C4DFA3`
- **JHash:** `0xABF77334`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_FALLING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_FATALLY_INJURED

- **命名空间:** `PED`
- **Hash:** `0xD839450756ED5A80`
- **JHash:** `0xBADA0093`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_FATALLY_INJURED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Gets a value indicating whether this ped's health is below its fatally injured threshold. The default threshold is 100.
If the handle is invalid, the function returns true.
```

---

### IS_PED_FLEEING

- **命名空间:** `PED`
- **Hash:** `0xBBCCE00B381F8482`
- **JHash:** `0x85D813C6`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_FLEEING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_GESTURING

- **命名空间:** `PED`
- **Hash:** `0xC30BDAEE47256C13`
- **Build:** `1868`

**C# 签名:**
```csharp
bool IS_PED_GESTURING(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_GETTING_INTO_A_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0xBB062B2B5722478E`
- **JHash:** `0x90E805AC`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_GETTING_INTO_A_VEHICLE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_GOING_INTO_COVER

- **命名空间:** `PED`
- **Hash:** `0x9F65DBC537E59AD5`
- **JHash:** `0xA3589628`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_GOING_INTO_COVER(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_GROUP_MEMBER

- **命名空间:** `PED`
- **Hash:** `0x9BB01E3834671191`
- **JHash:** `0x876D5363`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_GROUP_MEMBER(int ped, int groupId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `groupId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_HAIR_TINT_FOR_BARBER

- **命名空间:** `PED`
- **Hash:** `0xE0D36E5D9E99CC21`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_HAIR_TINT_FOR_BARBER(int colorID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `colorID` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_HAIR_TINT_FOR_CREATOR

- **命名空间:** `PED`
- **Hash:** `0xED6D8E27A43B8CDE`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_HAIR_TINT_FOR_CREATOR(int colorId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `colorId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_HANGING_ON_TO_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0x1C86D8AEF8254B78`
- **JHash:** `0x9678D4FF`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_HANGING_ON_TO_VEHICLE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_HEADING_TOWARDS_POSITION

- **命名空间:** `PED`
- **Hash:** `0xFCF37A457CB96DC0`
- **JHash:** `0x45037B9B`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_HEADING_TOWARDS_POSITION(int ped, float x, float y, float z, float p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p4` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_HEADTRACKING_ENTITY

- **命名空间:** `PED`
- **Hash:** `0x813A0A7C9D2E831F`
- **JHash:** `0x233C9ACF`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_HEADTRACKING_ENTITY(int ped, int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_HEADTRACKING_PED

- **命名空间:** `PED`
- **Hash:** `0x5CD3CB88A7F8850D`
- **JHash:** `0x2A5DF721`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_HEADTRACKING_PED(int ped1, int ped2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped1` | `Ped` | `int` | - |
| `ped2` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_HELMET_VISOR_UP

- **命名空间:** `PED`
- **Hash:** `0xB9496CE47546DB2C`
- **Build:** `791`

**C# 签名:**
```csharp
bool IS_PED_HELMET_VISOR_UP(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_HUMAN

- **命名空间:** `PED`
- **Hash:** `0xB980061DA992779D`
- **JHash:** `0x194BB7B0`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_HUMAN(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true/false if the ped is/isn't humanoid.
```

---

### IS_PED_HURT

- **命名空间:** `PED`
- **Hash:** `0x5983BB449D7FDB12`
- **JHash:** `0x69DFA0AF`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_HURT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns whether the specified ped is hurt.
```

---

### IS_PED_INJURED

- **命名空间:** `PED`
- **Hash:** `0x84A2DD9AC37C35C1`
- **JHash:** `0x2530A087`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_INJURED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Gets a value indicating whether this ped's health is below its injured threshold.

The default threshold is 100.
```

---

### IS_PED_IN_ANY_BOAT

- **命名空间:** `PED`
- **Hash:** `0x2E0E1C2B4F6CB339`
- **JHash:** `0x1118A947`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_IN_ANY_BOAT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_IN_ANY_HELI

- **命名空间:** `PED`
- **Hash:** `0x298B91AE825E5705`
- **JHash:** `0x7AB5523B`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_IN_ANY_HELI(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_IN_ANY_PLANE

- **命名空间:** `PED`
- **Hash:** `0x5FFF4CFC74D8FB80`
- **JHash:** `0x51BBCE7E`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_IN_ANY_PLANE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_IN_ANY_POLICE_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0x0BD04E29640C9C12`
- **JHash:** `0x84FA790D`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_IN_ANY_POLICE_VEHICLE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_IN_ANY_SUB

- **命名空间:** `PED`
- **Hash:** `0xFBFC01CCFB35D99E`
- **JHash:** `0xE65F8059`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_IN_ANY_SUB(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_IN_ANY_TAXI

- **命名空间:** `PED`
- **Hash:** `0x6E575D6A898AB852`
- **JHash:** `0x16FD386C`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_IN_ANY_TAXI(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_IN_ANY_TRAIN

- **命名空间:** `PED`
- **Hash:** `0x6F972C1AB75A1ED0`
- **JHash:** `0x759EF63A`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_IN_ANY_TRAIN(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_IN_ANY_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0x997ABD671D25CA0B`
- **JHash:** `0x3B0171EE`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_IN_ANY_VEHICLE(int ped, bool atGetIn)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `atGetIn` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Gets a value indicating whether the specified ped is in any vehicle.

If 'atGetIn' is false, the function will not return true until the ped is sitting in the vehicle and is about to close the door. If it's true, the function returns true the moment the ped starts to get onto the seat (after opening the door). Eg. if false, and the ped is getting into a submersible, the function will not return true until the ped has descended down into the submersible and gotten into the seat, while if it's true, it'll return true the moment the hatch has been opened and the ped is about to descend into the submersible.
```

---

### IS_PED_IN_COMBAT

- **命名空间:** `PED`
- **Hash:** `0x4859F1FC66A6278E`
- **JHash:** `0xFE027CB5`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_IN_COMBAT(int ped, int target)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `target` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Checks to see if ped and target are in combat with eachother. Only goes one-way: if target is engaged in combat with ped but ped has not yet reacted, the function will return false until ped starts fighting back.

p1 is usually 0 in the scripts because it gets the ped id during the task sequence. For instance: PED::IS_PED_IN_COMBAT(l_42E[4/*14*/], PLAYER::PLAYER_PED_ID()) // armenian2.ct4: 43794
```

---

### IS_PED_IN_COVER

- **命名空间:** `PED`
- **Hash:** `0x60DFD0691A170B88`
- **JHash:** `0x972C5A8B`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_IN_COVER(int ped, bool exceptUseWeapon)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `exceptUseWeapon` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p1 is nearly always 0 in the scripts. 
```

---

### IS_PED_IN_COVER_FACING_LEFT

- **命名空间:** `PED`
- **Hash:** `0x845333B3150583AB`
- **JHash:** `0xB89DBB80`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_IN_COVER_FACING_LEFT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_IN_FLYING_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0x9134873537FA419C`
- **JHash:** `0xCA072485`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_IN_FLYING_VEHICLE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_IN_GROUP

- **命名空间:** `PED`
- **Hash:** `0x5891CAC5D4ACFF74`
- **JHash:** `0x836D9795`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_IN_GROUP(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_IN_HIGH_COVER

- **命名空间:** `PED`
- **Hash:** `0x6A03BF943D767C93`
- **JHash:** `0xDD5D08A7`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_IN_HIGH_COVER(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_IN_MELEE_COMBAT

- **命名空间:** `PED`
- **Hash:** `0x4E209B2C1EAD5159`
- **JHash:** `0xFD7814A5`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_IN_MELEE_COMBAT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Notes: The function only returns true while the ped is: 
A.) Swinging a random melee attack (including pistol-whipping)

B.) Reacting to being hit by a melee attack (including pistol-whipping)

C.) Is locked-on to an enemy (arms up, strafing/skipping in the default fighting-stance, ready to dodge+counter). 

You don't have to be holding the melee-targetting button to be in this stance; you stay in it by default for a few seconds after swinging at someone. If you do a sprinting punch, it returns true for the duration of the punch animation and then returns false again, even if you've punched and made-angry many peds
```

---

### IS_PED_IN_MODEL

- **命名空间:** `PED`
- **Hash:** `0x796D90EFB19AA332`
- **JHash:** `0xA6438D4B`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_IN_MODEL(int ped, uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_IN_PARACHUTE_FREE_FALL

- **命名空间:** `PED`
- **Hash:** `0x7DCE8BDA0F1C1200`
- **JHash:** `0xCD71F11B`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_IN_PARACHUTE_FREE_FALL(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_IN_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0xA3EE4A07279BB9DB`
- **JHash:** `0x7DA6BC83`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_IN_VEHICLE(int ped, int vehicle, bool atGetIn)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `atGetIn` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Gets a value indicating whether the specified ped is in the specified vehicle.

If 'atGetIn' is false, the function will not return true until the ped is sitting in the vehicle and is about to close the door. If it's true, the function returns true the moment the ped starts to get onto the seat (after opening the door). Eg. if false, and the ped is getting into a submersible, the function will not return true until the ped has descended down into the submersible and gotten into the seat, while if it's true, it'll return true the moment the hatch has been opened and the ped is about to descend into the submersible.
```

---

### IS_PED_JACKING

- **命名空间:** `PED`
- **Hash:** `0x4AE4FF911DFB61DA`
- **JHash:** `0x3B321816`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_JACKING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_JUMPING

- **命名空间:** `PED`
- **Hash:** `0xCEDABC5900A0BF97`
- **JHash:** `0x07E5BC0E`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_JUMPING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_JUMPING_OUT_OF_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0x433DDFFE2044B636`
- **JHash:** `0xB19215F6`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_JUMPING_OUT_OF_VEHICLE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_LANDING

- **命名空间:** `PED`
- **Hash:** `0x412F1364FA066CFB`
- **Build:** `573`

**C# 签名:**
```csharp
bool IS_PED_LANDING(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_LIPSTICK_TINT_FOR_BARBER

- **命名空间:** `PED`
- **Hash:** `0x0525A2C2562F3CD4`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_LIPSTICK_TINT_FOR_BARBER(int colorID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `colorID` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_LIPSTICK_TINT_FOR_CREATOR

- **命名空间:** `PED`
- **Hash:** `0x3E802F11FBE27674`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_LIPSTICK_TINT_FOR_CREATOR(int colorId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `colorId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_MALE

- **命名空间:** `PED`
- **Hash:** `0x6D9F5FAA7488BA46`
- **JHash:** `0x90950455`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_MALE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true/false if the ped is/isn't male.
```

---

### IS_PED_MODEL

- **命名空间:** `PED`
- **Hash:** `0xC9D55B1A358A5BF7`
- **JHash:** `0x5F1DDFCB`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_MODEL(int ped, uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_ON_ANY_BIKE

- **命名空间:** `PED`
- **Hash:** `0x94495889E22C6479`
- **JHash:** `0x4D885B2E`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_ON_ANY_BIKE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_ON_FOOT

- **命名空间:** `PED`
- **Hash:** `0x01FEE67DB37F59B2`
- **JHash:** `0xC60D0785`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_ON_FOOT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_ON_MOUNT

- **命名空间:** `PED`
- **Hash:** `0x460BC76A0E10655E`
- **JHash:** `0x43103006`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_ON_MOUNT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Same function call as PED::GET_MOUNT, aka just returns 0
```

---

### IS_PED_ON_SPECIFIC_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0xEC5F66E459AF3BB2`
- **JHash:** `0x63CB4603`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_ON_SPECIFIC_VEHICLE(int ped, int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_ON_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0x67722AEB798E5FAB`
- **JHash:** `0xA1AE7CC7`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_ON_VEHICLE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Gets a value indicating whether the specified ped is on top of any vehicle.

Return 1 when ped is on vehicle.
Return 0 when ped is not on a vehicle.

```

---

### IS_PED_OPENING_DOOR

- **命名空间:** `PED`
- **Hash:** `0x26AF0E8E30BD2A2C`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_OPENING_DOOR(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if the ped is currently opening a door (CTaskOpenDoor).
```

---

### IS_PED_PERFORMING_A_COUNTER_ATTACK

- **命名空间:** `PED`
- **Hash:** `0xEBD0EDBA5BE957CF`
- **JHash:** `0x9BE7C860`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_PERFORMING_A_COUNTER_ATTACK(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_PERFORMING_MELEE_ACTION

- **命名空间:** `PED`
- **Hash:** `0xDCCA191DF9980FD7`
- **JHash:** `0x139C0875`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_PERFORMING_MELEE_ACTION(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_PERFORMING_STEALTH_KILL

- **命名空间:** `PED`
- **Hash:** `0xFD4CCDBCC59941B7`
- **JHash:** `0x9ADD7B21`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_PERFORMING_STEALTH_KILL(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_PLANTING_BOMB

- **命名空间:** `PED`
- **Hash:** `0xC70B5FAE151982D8`
- **JHash:** `0x0EDAC574`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_PLANTING_BOMB(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_PRONE

- **命名空间:** `PED`
- **Hash:** `0xD6A86331A537A7B9`
- **JHash:** `0x02C2A6C3`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_PRONE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_RAGDOLL

- **命名空间:** `PED`
- **Hash:** `0x47E4E977581C5B55`
- **JHash:** `0xC833BBE1`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_RAGDOLL(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
If the ped handle passed through the parenthesis is in a ragdoll state this will return true.
```

---

### IS_PED_RELOADING

- **命名空间:** `PED`
- **Hash:** `0x24B100C68C645951`
- **JHash:** `0x961E1745`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_RELOADING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns whether the specified ped is reloading.
```

---

### IS_PED_RESPONDING_TO_EVENT

- **命名空间:** `PED`
- **Hash:** `0x625B774D75C87068`
- **JHash:** `0x7A877554`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_RESPONDING_TO_EVENT(int ped, object event)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `event` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_RUNNING_MELEE_TASK

- **命名空间:** `PED`
- **Hash:** `0xD1871251F3B5ACD7`
- **JHash:** `0xBD4236F6`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_RUNNING_MELEE_TASK(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_RUNNING_MOBILE_PHONE_TASK

- **命名空间:** `PED`
- **Hash:** `0x2AFE52F782F25775`
- **JHash:** `0xFB2AFED1`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_RUNNING_MOBILE_PHONE_TASK(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_RUNNING_RAGDOLL_TASK

- **命名空间:** `PED`
- **Hash:** `0xE3B6097CC25AA69E`
- **JHash:** `0x44A153F2`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_RUNNING_RAGDOLL_TASK(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_SHADER_READY

- **命名空间:** `PED`
- **Hash:** `0x81AA517FBBA05D39`
- **Build:** `944`

**C# 签名:**
```csharp
bool IS_PED_SHADER_READY(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_SHELTERED

- **命名空间:** `PED`
- **Hash:** `0xB8B52E498014F5B0`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_SHELTERED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_SHOOTING

- **命名空间:** `PED`
- **Hash:** `0x34616828CD07F1A1`
- **JHash:** `0xE7C3405E`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_SHOOTING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns whether the specified ped is shooting.
```

---

### IS_PED_SHOOTING_IN_AREA

- **命名空间:** `PED`
- **Hash:** `0x7E9DFE24AC1E58EF`
- **JHash:** `0x741BF04F`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_SHOOTING_IN_AREA(int ped, float x1, float y1, float z1, float x2, float y2, float z2, bool p7, bool p8)
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
| `p7` | `BOOL` | `bool` | - |
| `p8` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_SITTING_IN_ANY_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0x826AA586EDB9FEF8`
- **JHash:** `0x0EA9CA03`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_SITTING_IN_ANY_VEHICLE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Detect if ped is in any vehicle
[True/False]
```

---

### IS_PED_SITTING_IN_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0xA808AA1D79230FC2`
- **JHash:** `0xDDDE26FA`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_SITTING_IN_VEHICLE(int ped, int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Detect if ped is sitting in the specified vehicle
[True/False]
```

---

### IS_PED_STOPPED

- **命名空间:** `PED`
- **Hash:** `0x530944F6F4B8A214`
- **JHash:** `0xA0DC0B87`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_STOPPED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if the ped doesn't do any movement. If the ped is being pushed forwards by using APPLY_FORCE_TO_ENTITY for example, the function returns false.
```

---

### IS_PED_SWIMMING

- **命名空间:** `PED`
- **Hash:** `0x9DE327631295B4C2`
- **JHash:** `0x7AB43DB8`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_SWIMMING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_SWIMMING_UNDER_WATER

- **命名空间:** `PED`
- **Hash:** `0xC024869A53992F34`
- **JHash:** `0x0E8D524F`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_SWIMMING_UNDER_WATER(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_SWITCHING_WEAPON

- **命名空间:** `PED`
- **Hash:** `0x3795688A307E1EB6`
- **Build:** `505`

**C# 签名:**
```csharp
bool IS_PED_SWITCHING_WEAPON(int Ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `Ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_TAKING_OFF_HELMET

- **命名空间:** `PED`
- **Hash:** `0x14590DDBEDB1EC85`
- **JHash:** `0xA1008E0E`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_TAKING_OFF_HELMET(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_TRACKED

- **命名空间:** `PED`
- **Hash:** `0x4C5E1F087CD10BB7`
- **JHash:** `0x7EB613D9`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_TRACKED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_TRYING_TO_ENTER_A_LOCKED_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0x44D28D5DDFE5F68C`
- **JHash:** `0x46828B4E`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_TRYING_TO_ENTER_A_LOCKED_VEHICLE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_USING_ACTION_MODE

- **命名空间:** `PED`
- **Hash:** `0x00E73468D085F745`
- **JHash:** `0x5AE7EDA2`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_USING_ACTION_MODE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_USING_ANY_SCENARIO

- **命名空间:** `PED`
- **Hash:** `0x57AB4A3080F85143`
- **JHash:** `0x195EF5B7`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_USING_ANY_SCENARIO(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_USING_SCENARIO

- **命名空间:** `PED`
- **Hash:** `0x1BF094736DD62C2E`
- **JHash:** `0x0F65B0D4`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_USING_SCENARIO(int ped, string scenario)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `scenario` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of ped scenarios by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/scenariosCompact.json
```

---

### IS_PED_VAULTING

- **命名空间:** `PED`
- **Hash:** `0x117C70D1F5730B5E`
- **JHash:** `0xC3169BDA`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_VAULTING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_WEARING_HELMET

- **命名空间:** `PED`
- **Hash:** `0xF33BDFE19B309B19`
- **JHash:** `0x0D680D49`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_WEARING_HELMET(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if the ped passed through the parenthesis is wearing a helmet.
```

---

### IS_SCRIPTED_SCENARIO_PED_USING_CONDITIONAL_ANIM

- **命名空间:** `PED`
- **Hash:** `0x6EC47A344923E1ED`
- **JHash:** `0x3C30B447`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SCRIPTED_SCENARIO_PED_USING_CONDITIONAL_ANIM(int ped, string animDict, string anim)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `animDict` | `const char*` | `string` | - |
| `anim` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### IS_SYNCHRONIZED_SCENE_HOLD_LAST_FRAME

- **命名空间:** `PED`
- **Hash:** `0x7F2F4F13AC5257EF`
- **JHash:** `0x72CF2514`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SYNCHRONIZED_SCENE_HOLD_LAST_FRAME(int sceneID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `sceneID` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SYNCHRONIZED_SCENE_LOOPED

- **命名空间:** `PED`
- **Hash:** `0x62522002E0C391BA`
- **JHash:** `0x47D87A84`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SYNCHRONIZED_SCENE_LOOPED(int sceneID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `sceneID` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SYNCHRONIZED_SCENE_RUNNING

- **命名空间:** `PED`
- **Hash:** `0x25D39B935A038A26`
- **JHash:** `0x57A282F1`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SYNCHRONIZED_SCENE_RUNNING(int sceneId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `sceneId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if a synchronized scene is running
```

---

### IS_TARGET_PED_IN_PERCEPTION_AREA

- **命名空间:** `PED`
- **Hash:** `0x06087579E7AA85A9`
- **JHash:** `0xD0567D41`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_TARGET_PED_IN_PERCEPTION_AREA(int ped, int targetPed, float p2, float p3, float p4, float p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `targetPed` | `Ped` | `int` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `float` | `float` | - |
| `p5` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_TRACKED_PED_VISIBLE

- **命名空间:** `PED`
- **Hash:** `0x91C8E617F64188AC`
- **JHash:** `0x33248CC1`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_TRACKED_PED_VISIBLE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
returns whether or not a ped is visible within your FOV, not this check auto's to false after a certain distance.


Target needs to be tracked.. won't work otherwise.
```

---

### IS_USING_PED_SCUBA_GEAR_VARIATION

- **命名空间:** `PED`
- **Hash:** `0xFEC9A3B1820F3331`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_USING_PED_SCUBA_GEAR_VARIATION(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### KNOCK_OFF_PED_PROP

- **命名空间:** `PED`
- **Hash:** `0x6FD7816A36615F48`
- **JHash:** `0x08D8B180`
- **Build:** `323`

**C# 签名:**
```csharp
void KNOCK_OFF_PED_PROP(int ped, bool p1, bool p2, bool p3, bool p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
List of component/props ID
gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
```

---

### KNOCK_PED_OFF_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0x45BBCBA77C29A841`
- **JHash:** `0xACDD0674`
- **Build:** `323`

**C# 签名:**
```csharp
void KNOCK_PED_OFF_VEHICLE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### MARK_PED_DECORATIONS_AS_CLONED_FROM_LOCAL_PLAYER

- **命名空间:** `PED`
- **Hash:** `0x2B694AFCF64E6994`
- **Build:** `323`

**C# 签名:**
```csharp
void MARK_PED_DECORATIONS_AS_CLONED_FROM_LOCAL_PLAYER(int ped, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### PED_HAS_SEXINESS_FLAG_SET

- **命名空间:** `PED`
- **Hash:** `0x46B05BCAE43856B0`
- **JHash:** `0x79543043`
- **Build:** `323`

**C# 签名:**
```csharp
bool PED_HAS_SEXINESS_FLAG_SET(int ped, int sexinessFlag)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `sexinessFlag` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Checks if the specified sexiness flag is set

enum eSexinessFlags
{
 SF_JEER_AT_HOT_PED = 0,
 SF_HURRIEDFEMALES_SEXY = 1,
 SF_HOT_PERSON = 2,
 };
```

---

### PLAY_FACIAL_ANIM

- **命名空间:** `PED`
- **Hash:** `0xE1E65CA8AC9C00ED`
- **JHash:** `0x1F6CCDDE`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_FACIAL_ANIM(int ped, string animName, string animDict)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `animName` | `const char*` | `string` | - |
| `animDict` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### REGISTER_HATED_TARGETS_AROUND_PED

- **命名空间:** `PED`
- **Hash:** `0x9222F300BF8354FE`
- **JHash:** `0x7F87559E`
- **Build:** `323`

**C# 签名:**
```csharp
void REGISTER_HATED_TARGETS_AROUND_PED(int ped, float radius)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `radius` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Based on TASK_COMBAT_HATED_TARGETS_AROUND_PED, the parameters are likely similar (PedHandle, and area to attack in).
```

---

### REGISTER_PEDHEADSHOT

- **命名空间:** `PED`
- **Hash:** `0x4462658788425076`
- **JHash:** `0xFFE2667B`
- **Build:** `323`

**C# 签名:**
```csharp
int REGISTER_PEDHEADSHOT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
gtaforums.com/topic/885580-ped-headshotmugshot-txd/
```

---

### REGISTER_PEDHEADSHOT_HIRES

- **命名空间:** `PED`
- **Hash:** `0xBA8805A1108A2515`
- **Build:** `877`

**C# 签名:**
```csharp
int REGISTER_PEDHEADSHOT_HIRES(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### REGISTER_PEDHEADSHOT_TRANSPARENT

- **命名空间:** `PED`
- **Hash:** `0x953563CE563143AF`
- **JHash:** `0x4DD03628`
- **Build:** `323`

**C# 签名:**
```csharp
int REGISTER_PEDHEADSHOT_TRANSPARENT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Similar to REGISTER_PEDHEADSHOT but creates a transparent background instead of black. Example: https://i.imgur.com/iHz8ztn.png
```

---

### REGISTER_TARGET

- **命名空间:** `PED`
- **Hash:** `0x2F25D9AEFA34FBA2`
- **JHash:** `0x50A95442`
- **Build:** `323`

**C# 签名:**
```csharp
void REGISTER_TARGET(int ped, int target)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `target` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
PED::REGISTER_TARGET(l_216, PLAYER::PLAYER_PED_ID()); from re_prisonbreak.txt.

l_216 = RECSBRobber1
```

---

### RELEASE_PEDHEADSHOT_IMG_UPLOAD

- **命名空间:** `PED`
- **Hash:** `0x5D517B27CF6ECD04`
- **JHash:** `0x0DBB2FA7`
- **Build:** `323`

**C# 签名:**
```csharp
void RELEASE_PEDHEADSHOT_IMG_UPLOAD(int id)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `id` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RELEASE_PED_PRELOAD_PROP_DATA

- **命名空间:** `PED`
- **Hash:** `0xF79F9DEF0AADE61A`
- **JHash:** `0xFD103BA7`
- **Build:** `323`

**C# 签名:**
```csharp
void RELEASE_PED_PRELOAD_PROP_DATA(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RELEASE_PED_PRELOAD_VARIATION_DATA

- **命名空间:** `PED`
- **Hash:** `0x5AAB586FFEC0FD96`
- **JHash:** `0x6435F67F`
- **Build:** `323`

**C# 签名:**
```csharp
void RELEASE_PED_PRELOAD_VARIATION_DATA(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_ACTION_MODE_ASSET

- **命名空间:** `PED`
- **Hash:** `0x13E940F88470FA51`
- **JHash:** `0x3F480F92`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_ACTION_MODE_ASSET(string asset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `asset` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_GROUP

- **命名空间:** `PED`
- **Hash:** `0x8EB2F69076AF7053`
- **JHash:** `0x48D72B88`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_GROUP(int groupId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `groupId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_PED_DEFENSIVE_AREA

- **命名空间:** `PED`
- **Hash:** `0x74D4E028107450A9`
- **JHash:** `0x34AAAFA5`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_PED_DEFENSIVE_AREA(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Ped will no longer get angry when you stay near him.
```

---

### REMOVE_PED_ELEGANTLY

- **命名空间:** `PED`
- **Hash:** `0xAC6D445B994DF95E`
- **JHash:** `0x4FFB8C6C`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_PED_ELEGANTLY(Ped* ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped*` | `Ped*` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Judging purely from a quick disassembly, if the ped is in a vehicle, the ped will be deleted immediately. If not, it'll be marked as no longer needed. - very elegant..
```

---

### REMOVE_PED_FROM_GROUP

- **命名空间:** `PED`
- **Hash:** `0xED74007FFB146BC2`
- **JHash:** `0x82697713`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_PED_FROM_GROUP(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_PED_HELMET

- **命名空间:** `PED`
- **Hash:** `0xA7B2458D0AD6DED8`
- **JHash:** `0x2086B1F0`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_PED_HELMET(int ped, bool instantly)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `instantly` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_PED_PREFERRED_COVER_SET

- **命名空间:** `PED`
- **Hash:** `0xFDDB234CF74073D9`
- **JHash:** `0xA0134498`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_PED_PREFERRED_COVER_SET(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_RELATIONSHIP_GROUP

- **命名空间:** `PED`
- **Hash:** `0xB6BA2444AB393DA2`
- **JHash:** `0x4A1DC59A`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_RELATIONSHIP_GROUP(uint groupHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `groupHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_SCENARIO_BLOCKING_AREA

- **命名空间:** `PED`
- **Hash:** `0x31D16B74C6E29D66`
- **JHash:** `0x4483EF06`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_SCENARIO_BLOCKING_AREA(object p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_SCENARIO_BLOCKING_AREAS

- **命名空间:** `PED`
- **Hash:** `0xD37401D78A929A49`
- **JHash:** `0x4DDF845F`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_SCENARIO_BLOCKING_AREAS()
```

**返回值:** `void` (Native: `void`)

---

### REMOVE_STEALTH_MODE_ASSET

- **命名空间:** `PED`
- **Hash:** `0x9219857D21F0E842`
- **JHash:** `0x8C0B243A`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_STEALTH_MODE_ASSET(string asset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `asset` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### REQUEST_ACTION_MODE_ASSET

- **命名空间:** `PED`
- **Hash:** `0x290E2780BB7AA598`
- **JHash:** `0x572BA553`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_ACTION_MODE_ASSET(string asset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `asset` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### REQUEST_PEDHEADSHOT_IMG_UPLOAD

- **命名空间:** `PED`
- **Hash:** `0xF0DAEF2F545BEE25`
- **JHash:** `0x10F2C023`
- **Build:** `323`

**C# 签名:**
```csharp
bool REQUEST_PEDHEADSHOT_IMG_UPLOAD(int id)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `id` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### REQUEST_PED_RESTRICTED_VEHICLE_VISIBILITY_TRACKING

- **命名空间:** `PED`
- **Hash:** `0xCD018C591F94CB43`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_PED_RESTRICTED_VEHICLE_VISIBILITY_TRACKING(int ped, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### REQUEST_PED_USE_SMALL_BBOX_VISIBILITY_TRACKING

- **命名空间:** `PED`
- **Hash:** `0x75BA1CB3B7D40CAF`
- **JHash:** `0x9194DB71`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_PED_USE_SMALL_BBOX_VISIBILITY_TRACKING(int ped, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### REQUEST_PED_VEHICLE_VISIBILITY_TRACKING

- **命名空间:** `PED`
- **Hash:** `0x2BC338A7B21F4608`
- **JHash:** `0x31C31DAA`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_PED_VEHICLE_VISIBILITY_TRACKING(int ped, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### REQUEST_PED_VISIBILITY_TRACKING

- **命名空间:** `PED`
- **Hash:** `0x7D7A2E43E74E2EB8`
- **JHash:** `0x840D24D3`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_PED_VISIBILITY_TRACKING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REQUEST_RAGDOLL_BOUNDS_UPDATE

- **命名空间:** `PED`
- **Hash:** `0x1216E0BFA72CC703`
- **JHash:** `0x7BD26837`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_RAGDOLL_BOUNDS_UPDATE(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native does absolutely nothing, just a nullsub
```

---

### REQUEST_STEALTH_MODE_ASSET

- **命名空间:** `PED`
- **Hash:** `0x2A0A62FCDEE16D4F`
- **JHash:** `0x280A004A`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_STEALTH_MODE_ASSET(string asset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `asset` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### RESET_AI_MELEE_WEAPON_DAMAGE_MODIFIER

- **命名空间:** `PED`
- **Hash:** `0x46E56A7CD1D63C3F`
- **JHash:** `0x97886238`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_AI_MELEE_WEAPON_DAMAGE_MODIFIER()
```

**返回值:** `void` (Native: `void`)

---

### RESET_AI_WEAPON_DAMAGE_MODIFIER

- **命名空间:** `PED`
- **Hash:** `0xEA16670E7BA4743C`
- **JHash:** `0x6E965420`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_AI_WEAPON_DAMAGE_MODIFIER()
```

**返回值:** `void` (Native: `void`)

---

### RESET_FACIAL_IDLE_ANIM

- **命名空间:** `PED`
- **Hash:** `0x007FDE5A7897E426`
- **Build:** `2802`

**C# 签名:**
```csharp
void RESET_FACIAL_IDLE_ANIM(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESET_GROUP_FORMATION_DEFAULT_SPACING

- **命名空间:** `PED`
- **Hash:** `0x63DAB4CCB3273205`
- **JHash:** `0x267FCEAD`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_GROUP_FORMATION_DEFAULT_SPACING(int groupHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `groupHandle` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESET_PED_IN_VEHICLE_CONTEXT

- **命名空间:** `PED`
- **Hash:** `0x22EF8FF8778030EB`
- **JHash:** `0x3C94D88A`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_PED_IN_VEHICLE_CONTEXT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESET_PED_LAST_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0xBB8DE8CF6A8DD8BB`
- **JHash:** `0x5E3B5942`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_PED_LAST_VEHICLE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Resets the value for the last vehicle driven by the Ped.
```

---

### RESET_PED_MOVEMENT_CLIPSET

- **命名空间:** `PED`
- **Hash:** `0xAA74EC0CB0AAEA2C`
- **JHash:** `0xB83CEE93`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_PED_MOVEMENT_CLIPSET(int ped, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
If p1 is 0.0, I believe you are back to normal. 
If p1 is 1.0, it looks like you can only rotate the ped, not walk.

Using the following code to reset back to normal
PED::RESET_PED_MOVEMENT_CLIPSET(PLAYER::PLAYER_PED_ID(), 0.0);
```

---

### RESET_PED_RAGDOLL_TIMER

- **命名空间:** `PED`
- **Hash:** `0x9FA4664CF62E47E8`
- **JHash:** `0xF2865370`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_PED_RAGDOLL_TIMER(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESET_PED_STRAFE_CLIPSET

- **命名空间:** `PED`
- **Hash:** `0x20510814175EA477`
- **JHash:** `0xF1967A12`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_PED_STRAFE_CLIPSET(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESET_PED_VISIBLE_DAMAGE

- **命名空间:** `PED`
- **Hash:** `0x3AC1F7B898F30C05`
- **JHash:** `0xC4BC4841`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_PED_VISIBLE_DAMAGE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESET_PED_WEAPON_MOVEMENT_CLIPSET

- **命名空间:** `PED`
- **Hash:** `0x97B0DB5B4AA74E77`
- **JHash:** `0xC60C9ACD`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_PED_WEAPON_MOVEMENT_CLIPSET(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESURRECT_PED

- **命名空间:** `PED`
- **Hash:** `0x71BC8E838B9C6035`
- **JHash:** `0xA4B82097`
- **Build:** `323`

**C# 签名:**
```csharp
void RESURRECT_PED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This function will simply bring the dead person back to life.

Try not to use it alone, since using this function alone, will make peds fall through ground in hell(well for the most of the times).

Instead, before calling this function, you may want to declare the position, where your Resurrected ped to be spawn at.(For instance, Around 2 floats of Player's current position.) 

Also, disabling any assigned task immediately helped in the number of scenarios, where If you want peds to perform certain decided tasks.
```

---

### REVIVE_INJURED_PED

- **命名空间:** `PED`
- **Hash:** `0x8D8ACD8388CD99CE`
- **JHash:** `0x14D3E6E3`
- **Build:** `323`

**C# 签名:**
```csharp
void REVIVE_INJURED_PED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
It will revive/cure the injured ped. The condition is ped must not be dead.

Upon setting and converting the health int, found, if health falls below 5, the ped will lay on the ground in pain(Maximum default health is 100).

This function is well suited there.
```

---

### SET_AI_MELEE_WEAPON_DAMAGE_MODIFIER

- **命名空间:** `PED`
- **Hash:** `0x66460DEDDD417254`
- **JHash:** `0x0F9A401F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AI_MELEE_WEAPON_DAMAGE_MODIFIER(float modifier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modifier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_AI_WEAPON_DAMAGE_MODIFIER

- **命名空间:** `PED`
- **Hash:** `0x1B1E2A40A65B8521`
- **JHash:** `0x516E30EE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AI_WEAPON_DAMAGE_MODIFIER(float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ALLOW_LOCKON_TO_PED_IF_FRIENDLY

- **命名空间:** `PED`
- **Hash:** `0x061CB768363D6424`
- **JHash:** `0x7DA12905`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ALLOW_LOCKON_TO_PED_IF_FRIENDLY(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ALLOW_STUNT_JUMP_CAMERA

- **命名空间:** `PED`
- **Hash:** `0xFAB944D4D481ACCB`
- **Build:** `1734`

**C# 签名:**
```csharp
void SET_ALLOW_STUNT_JUMP_CAMERA(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_AMBIENT_LAW_PED_ACCURACY_MODIFIER

- **命名空间:** `PED`
- **Hash:** `0x87DDEB611B329A9C`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_AMBIENT_LAW_PED_ACCURACY_MODIFIER(float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_AMBIENT_PEDS_DROP_MONEY

- **命名空间:** `PED`
- **Hash:** `0x6B0E6172C9A4D902`
- **JHash:** `0x30B98369`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AMBIENT_PEDS_DROP_MONEY(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_BLOCKING_OF_NON_TEMPORARY_EVENTS

- **命名空间:** `PED`
- **Hash:** `0x9F8AA94D6D97DBF4`
- **JHash:** `0xDFE34E4A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_BLOCKING_OF_NON_TEMPORARY_EVENTS(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
works with TASK::TASK_SET_BLOCKING_OF_NON_TEMPORARY_EVENTS to make a ped completely oblivious to all events going on around him
```

---

### SET_BLOCKING_OF_NON_TEMPORARY_EVENTS_FOR_AMBIENT_PEDS_THIS_FRAME

- **命名空间:** `PED`
- **Hash:** `0x9911F4A24485F653`
- **JHash:** `0x02A080C8`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_BLOCKING_OF_NON_TEMPORARY_EVENTS_FOR_AMBIENT_PEDS_THIS_FRAME(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAN_ATTACK_FRIENDLY

- **命名空间:** `PED`
- **Hash:** `0xB3B1CB349FF9C75D`
- **JHash:** `0x47C60963`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAN_ATTACK_FRIENDLY(int ped, bool toggle, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Setting ped to true allows the ped to shoot "friendlies".

p2 set to true when toggle is also true seams to make peds permanently unable to aim at, even if you set p2 back to false.

p1 = false & p2 = false for unable to aim at.
p1 = true & p2 = false for able to aim at. 
```

---

### SET_COMBAT_FLOAT

- **命名空间:** `PED`
- **Hash:** `0xFF41B4B141ED981C`
- **JHash:** `0xD8B7637C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_COMBAT_FLOAT(int ped, int combatType, float p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `combatType` | `int` | `int` | - |
| `p2` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
combatType can be between 0-14. See GET_COMBAT_FLOAT below for a list of possible parameters.
```

---

### SET_COP_PERCEPTION_OVERRIDES

- **命名空间:** `PED`
- **Hash:** `0x2F074C904D85129E`
- **Build:** `393`

**C# 签名:**
```csharp
void SET_COP_PERCEPTION_OVERRIDES(float seeingRange, float seeingRangePeripheral, float hearingRange, float visualFieldMinAzimuthAngle, float visualFieldMaxAzimuthAngle, float fieldOfGazeMaxAngle, float p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `seeingRange` | `float` | `float` | - |
| `seeingRangePeripheral` | `float` | `float` | - |
| `hearingRange` | `float` | `float` | - |
| `visualFieldMinAzimuthAngle` | `float` | `float` | - |
| `visualFieldMaxAzimuthAngle` | `float` | `float` | - |
| `fieldOfGazeMaxAngle` | `float` | `float` | - |
| `p6` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CORPSE_RAGDOLL_FRICTION

- **命名空间:** `PED`
- **Hash:** `0x2735233A786B1BEF`
- **JHash:** `0x373CC405`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CORPSE_RAGDOLL_FRICTION(int ped, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CREATE_RANDOM_COPS

- **命名空间:** `PED`
- **Hash:** `0x102E68B2024D536D`
- **JHash:** `0x23441648`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CREATE_RANDOM_COPS(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CREATE_RANDOM_COPS_NOT_ON_SCENARIOS

- **命名空间:** `PED`
- **Hash:** `0x8A4986851C4EF6E7`
- **JHash:** `0x82E548CC`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CREATE_RANDOM_COPS_NOT_ON_SCENARIOS(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CREATE_RANDOM_COPS_ON_SCENARIOS

- **命名空间:** `PED`
- **Hash:** `0x444CB7D7DBE6973D`
- **JHash:** `0xEDC31475`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CREATE_RANDOM_COPS_ON_SCENARIOS(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DISABLE_HIGH_FALL_DEATH

- **命名空间:** `PED`
- **Hash:** `0x711794453CFD692B`
- **Build:** `463`

**C# 签名:**
```csharp
void SET_DISABLE_HIGH_FALL_DEATH(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DISABLE_PED_MAP_COLLISION

- **命名空间:** `PED`
- **Hash:** `0xDFE68C4B787E1BFB`
- **Build:** `1180`

**C# 签名:**
```csharp
void SET_DISABLE_PED_MAP_COLLISION(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DRIVER_ABILITY

- **命名空间:** `PED`
- **Hash:** `0xB195FFA8042FC5C3`
- **JHash:** `0xAAD4012C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DRIVER_ABILITY(int driver, float ability)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `driver` | `Ped` | `int` | - |
| `ability` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
The function specifically verifies the value is equal to, or less than 1.0f. If it is greater than 1.0f, the function does nothing at all.
```

---

### SET_DRIVER_AGGRESSIVENESS

- **命名空间:** `PED`
- **Hash:** `0xA731F608CA104E3C`
- **JHash:** `0x8B02A8FB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DRIVER_AGGRESSIVENESS(int driver, float aggressiveness)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `driver` | `Ped` | `int` | - |
| `aggressiveness` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
range 0.0f - 1.0f
```

---

### SET_DRIVER_RACING_MODIFIER

- **命名空间:** `PED`
- **Hash:** `0xDED5AF5A0EA4B297`
- **JHash:** `0x6D55B3B3`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DRIVER_RACING_MODIFIER(int driver, float modifier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `driver` | `Ped` | `int` | - |
| `modifier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Scripts use 0.2, 0.5 and 1.0. Value must be >= 0.0 && <= 1.0
```

---

### SET_ENABLE_BOUND_ANKLES

- **命名空间:** `PED`
- **Hash:** `0xC52E0F855C58FC2E`
- **JHash:** `0x9208D689`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENABLE_BOUND_ANKLES(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Used with SET_ENABLE_HANDCUFFS in decompiled scripts. From my observations, I have noticed that while being ragdolled you are not able to get up but you can still run. Your legs can also bend.
```

---

### SET_ENABLE_HANDCUFFS

- **命名空间:** `PED`
- **Hash:** `0xDF1AF8B5D56542FA`
- **JHash:** `0xAC9BBA23`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENABLE_HANDCUFFS(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
ped can not pull out a weapon when true
```

---

### SET_ENABLE_PED_ENVEFF_SCALE

- **命名空间:** `PED`
- **Hash:** `0xD2C5AA0C0E8D0F1E`
- **JHash:** `0xC70F4A84`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENABLE_PED_ENVEFF_SCALE(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENABLE_SCUBA

- **命名空间:** `PED`
- **Hash:** `0xF99F62004024D506`
- **JHash:** `0x7BF61471`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENABLE_SCUBA(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Enables diving motion when underwater.
```

---

### SET_FACIAL_CLIPSET

- **命名空间:** `PED`
- **Hash:** `0x5687C7F05B39E401`
- **Build:** `1493`

**C# 签名:**
```csharp
void SET_FACIAL_CLIPSET(int ped, string animDict)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `animDict` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Clipsets:
facials@gen_female@base
facials@gen_male@base
facials@p_m_zero@base

Typically followed with SET_FACIAL_IDLE_ANIM_OVERRIDE:
mood_drunk_1
mood_stressed_1
mood_happy_1
mood_talking_1

```

---

### SET_FACIAL_IDLE_ANIM_OVERRIDE

- **命名空间:** `PED`
- **Hash:** `0xFFC24B988B938B38`
- **JHash:** `0x9BA19C13`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FACIAL_IDLE_ANIM_OVERRIDE(int ped, string animName, string animDict)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `animName` | `const char*` | `string` | - |
| `animDict` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### SET_FORCE_FOOTSTEP_UPDATE

- **命名空间:** `PED`
- **Hash:** `0x129466ED55140F8D`
- **JHash:** `0x37DBC2AD`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FORCE_FOOTSTEP_UPDATE(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FORCE_STEP_TYPE

- **命名空间:** `PED`
- **Hash:** `0xCB968B53FC7F916D`
- **JHash:** `0xC0F1BC91`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FORCE_STEP_TYPE(int ped, bool p1, int type, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `type` | `int` | `int` | - |
| `p3` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GROUP_FORMATION

- **命名空间:** `PED`
- **Hash:** `0xCE2F5FC3AF7E8C1E`
- **JHash:** `0x08FAC739`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GROUP_FORMATION(int groupId, int formationType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `groupId` | `int` | `int` | - |
| `formationType` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
0: Default
1: Circle Around Leader
2: Alternative Circle Around Leader
3: Line, with Leader at center
```

---

### SET_GROUP_FORMATION_SPACING

- **命名空间:** `PED`
- **Hash:** `0x1D9D45004C28C916`
- **JHash:** `0xB1E086FF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GROUP_FORMATION_SPACING(int groupId, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `groupId` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GROUP_SEPARATION_RANGE

- **命名空间:** `PED`
- **Hash:** `0x4102C7858CFEE4E4`
- **JHash:** `0x7B820CD5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GROUP_SEPARATION_RANGE(int groupHandle, float separationRange)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `groupHandle` | `int` | `int` | - |
| `separationRange` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the range at which members will automatically leave the group.
```

---

### SET_HEAD_BLEND_EYE_COLOR

- **命名空间:** `PED`
- **Hash:** `0x50B56988B170AFDF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_HEAD_BLEND_EYE_COLOR(int ped, int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `index` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Used for freemode (online) characters.

For some reason, the scripts use a rounded float for the index.
Indexes:
1. black
2. very light blue/green
3. dark blue
4. brown
5. darker brown
6. light brown
7. blue
8. light blue
9. pink
10. yellow
11. purple
12. black
13. dark green
14. light brown
15. yellow/black pattern
16. light colored spiral pattern
17. shiny red
18. shiny half blue/half red
19. half black/half light blue
20. white/red perimter
21. green snake
22. red snake
23. dark blue snake
24. dark yellow
25. bright yellow
26. all black
28. red small pupil
29. devil blue/black
30. white small pupil
31. glossed over
```

---

### SET_HEAD_BLEND_PALETTE_COLOR

- **命名空间:** `PED`
- **Hash:** `0xCC9682B8951C5229`
- **JHash:** `0x57E5B3F9`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_HEAD_BLEND_PALETTE_COLOR(int ped, int r, int g, int b, int id)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `r` | `int` | `int` | - |
| `g` | `int` | `int` | - |
| `b` | `int` | `int` | - |
| `id` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p4 seems to vary from 0 to 3.
Preview: https://gfycat.com/MaleRareAmazonparrot
```

---

### SET_HEALTH_SNACKS_CARRIED_BY_ALL_NEW_PEDS

- **命名空间:** `PED`
- **Hash:** `0xFF4803BC019852D9`
- **JHash:** `0xD41C9AED`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_HEALTH_SNACKS_CARRIED_BY_ALL_NEW_PEDS(float p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Related to Peds dropping pickup_health_snack; p0 is a value between [0.0, 1.0] that corresponds to drop rate
```

---

### SET_IK_TARGET

- **命名空间:** `PED`
- **Hash:** `0xC32779C16FCEECD9`
- **JHash:** `0x6FE5218C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_IK_TARGET(int ped, int ikIndex, int entityLookAt, int boneLookAt, float offsetX, float offsetY, float offsetZ, object p7, int blendInDuration, int blendOutDuration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `ikIndex` | `int` | `int` | - |
| `entityLookAt` | `Entity` | `int` | - |
| `boneLookAt` | `int` | `int` | - |
| `offsetX` | `float` | `float` | - |
| `offsetY` | `float` | `float` | - |
| `offsetZ` | `float` | `float` | - |
| `p7` | `Any` | `object` | - |
| `blendInDuration` | `int` | `int` | - |
| `blendOutDuration` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_LADDER_CLIMB_INPUT_STATE

- **命名空间:** `PED`
- **Hash:** `0x1A330D297AAC6BC1`
- **JHash:** `0x77BB7CB8`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_LADDER_CLIMB_INPUT_STATE(int ped, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Only appears in lamar1 script.
```

---

### SET_MOVEMENT_MODE_OVERRIDE

- **命名空间:** `PED`
- **Hash:** `0x781DE8FA214E87D2`
- **JHash:** `0x83BAE814`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_MOVEMENT_MODE_OVERRIDE(int ped, string name)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `name` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
name: "MP_FEMALE_ACTION" found multiple times in the b617d scripts.
```

---

### SET_PED_ACCURACY

- **命名空间:** `PED`
- **Hash:** `0x7AEFB85C1D49DEB6`
- **JHash:** `0x6C17122E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_ACCURACY(int ped, int accuracy)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `accuracy` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
accuracy = 0-100, 100 being perfectly accurate
```

---

### SET_PED_ALERTNESS

- **命名空间:** `PED`
- **Hash:** `0xDBA71115ED9941A6`
- **JHash:** `0x2C32D9AE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_ALERTNESS(int ped, int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `value` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
value ranges from 0 to 3.
```

---

### SET_PED_ALLOWED_TO_DUCK

- **命名空间:** `PED`
- **Hash:** `0xDA1F1B7BE1A8766F`
- **JHash:** `0xC4D122F8`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_ALLOWED_TO_DUCK(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_ALLOW_HURT_COMBAT_FOR_ALL_MISSION_PEDS

- **命名空间:** `PED`
- **Hash:** `0xF2BEBCDFAFDAA19E`
- **JHash:** `0x6CD58238`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_ALLOW_HURT_COMBAT_FOR_ALL_MISSION_PEDS(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
ntoggle was always false except in one instance (b678).

The one time this is set to true seems to do with when you fail the mission.
```

---

### SET_PED_ALLOW_MINOR_REACTIONS_AS_MISSION_PED

- **命名空间:** `PED`
- **Hash:** `0x49E50BDB8BA4DAB2`
- **JHash:** `0x397F06E3`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_ALLOW_MINOR_REACTIONS_AS_MISSION_PED(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_ALLOW_VEHICLES_OVERRIDE

- **命名空间:** `PED`
- **Hash:** `0x3C028C636A414ED9`
- **JHash:** `0x58A80BD5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_ALLOW_VEHICLES_OVERRIDE(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_ALTERNATE_MOVEMENT_ANIM

- **命名空间:** `PED`
- **Hash:** `0x90A43CC281FFAB46`
- **JHash:** `0xBA84FD8C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_ALTERNATE_MOVEMENT_ANIM(int ped, int stance, string animDictionary, string animationName, float p4, bool p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `stance` | `int` | `int` | - |
| `animDictionary` | `const char*` | `string` | - |
| `animationName` | `const char*` | `string` | - |
| `p4` | `float` | `float` | - |
| `p5` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
stance:
0 = idle
1 = walk
2 = running

p5 = usually set to true

Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json

Full list of movement clipsets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/movementClipsetsCompact.json
```

---

### SET_PED_ALTERNATE_WALK_ANIM

- **命名空间:** `PED`
- **Hash:** `0x6C60394CB4F75E9A`
- **JHash:** `0x895E1D67`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_ALTERNATE_WALK_ANIM(int ped, string animDict, string animName, float p3, bool p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `animDict` | `const char*` | `string` | - |
| `animName` | `const char*` | `string` | - |
| `p3` | `float` | `float` | - |
| `p4` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json

Full list of movement clipsets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/movementClipsetsCompact.json
```

---

### SET_PED_ANGLED_DEFENSIVE_AREA

- **命名空间:** `PED`
- **Hash:** `0xC7F76DF27A5045A1`
- **JHash:** `0x3EFBDD9B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_ANGLED_DEFENSIVE_AREA(int ped, float p1, float p2, float p3, float p4, float p5, float p6, float p7, bool p8, bool p9)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `float` | `float` | - |
| `p5` | `float` | `float` | - |
| `p6` | `float` | `float` | - |
| `p7` | `float` | `float` | - |
| `p8` | `BOOL` | `bool` | - |
| `p9` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_AO_BLOB_RENDERING

- **命名空间:** `PED`
- **Hash:** `0x2B5AA717A181FB4C`
- **JHash:** `0x98E29ED0`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_AO_BLOB_RENDERING(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Enable/disable ped shadow (ambient occlusion). https://gfycat.com/thankfulesteemedgecko
```

---

### SET_PED_ARMOUR

- **命名空间:** `PED`
- **Hash:** `0xCEA04D83135264CC`
- **JHash:** `0x4E3A0CC4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_ARMOUR(int ped, int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the armor of the specified ped.

ped: The Ped to set the armor of.
amount: A value between 0 and 100 indicating the value to set the Ped's armor to.
```

---

### SET_PED_AS_COP

- **命名空间:** `PED`
- **Hash:** `0xBB03C38DD3FB7FFD`
- **JHash:** `0x84E7DE9F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_AS_COP(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Turns the desired ped into a cop. If you use this on the player ped, you will become almost invisible to cops dispatched for you. You will also report your own crimes, get a generic cop voice, get a cop-vision-cone on the radar, and you will be unable to shoot at other cops. SWAT and Army will still shoot at you. Toggling ped as "false" has no effect; you must change p0's ped model to disable the effect.
```

---

### SET_PED_AS_ENEMY

- **命名空间:** `PED`
- **Hash:** `0x02A0C9720B854BFA`
- **JHash:** `0xAE620A1B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_AS_ENEMY(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_AS_GROUP_LEADER

- **命名空间:** `PED`
- **Hash:** `0x2A7819605465FBCE`
- **JHash:** `0x7265BEA2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_AS_GROUP_LEADER(int ped, int groupId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `groupId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_AS_GROUP_MEMBER

- **命名空间:** `PED`
- **Hash:** `0x9F3480FE65DB31B5`
- **JHash:** `0x0EE13F92`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_AS_GROUP_MEMBER(int ped, int groupId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `groupId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_BLEND_FROM_PARENTS

- **命名空间:** `PED`
- **Hash:** `0x137BBD05230DB22D`
- **JHash:** `0x837BD370`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_BLEND_FROM_PARENTS(int ped, object p1, object p2, float p3, float p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `float` | `float` | - |
| `p4` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_BLOCKS_PATHING_WHEN_DEAD

- **命名空间:** `PED`
- **Hash:** `0x576594E8D64375E2`
- **JHash:** `0x1D87DDC1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_BLOCKS_PATHING_WHEN_DEAD(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_BOUNDS_ORIENTATION

- **命名空间:** `PED`
- **Hash:** `0x4F5F651ACCC9C4CF`
- **JHash:** `0xCFA20D68`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_BOUNDS_ORIENTATION(int ped, float p1, float p2, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_ARM_IK

- **命名空间:** `PED`
- **Hash:** `0x6C3B4D6D13B4C841`
- **JHash:** `0x343B4DE0`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_ARM_IK(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_BE_DRAGGED_OUT

- **命名空间:** `PED`
- **Hash:** `0xC1670E958EEE24E5`
- **JHash:** `0xAA7F1131`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_BE_DRAGGED_OUT(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_BE_KNOCKED_OFF_BIKE

- **命名空间:** `PED`
- **Hash:** `0xB282749D5E028163`
- **Build:** `877`

**C# 签名:**
```csharp
void SET_PED_CAN_BE_KNOCKED_OFF_BIKE(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native does absolutely nothing, just a nullsub
```

---

### SET_PED_CAN_BE_KNOCKED_OFF_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0x7A6535691B477C48`
- **JHash:** `0x8A251612`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_BE_KNOCKED_OFF_VEHICLE(int ped, int state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `state` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
state: https://alloc8or.re/gta5/doc/enums/eKnockOffVehicle.txt
```

---

### SET_PED_CAN_BE_SHOT_IN_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0xC7EF1BA83230BA07`
- **JHash:** `0x5DB7B3A9`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_BE_SHOT_IN_VEHICLE(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_BE_TARGETED_WHEN_INJURED

- **命名空间:** `PED`
- **Hash:** `0x638C03B0F9878F57`
- **JHash:** `0x6FD9A7CD`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_BE_TARGETED_WHEN_INJURED(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_BE_TARGETED_WITHOUT_LOS

- **命名空间:** `PED`
- **Hash:** `0x4328652AE5769C71`
- **JHash:** `0x7FDDC0A6`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_BE_TARGETED_WITHOUT_LOS(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_BE_TARGETTED

- **命名空间:** `PED`
- **Hash:** `0x63F58F7C80513AAD`
- **JHash:** `0x75C49F74`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_BE_TARGETTED(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_BE_TARGETTED_BY_PLAYER

- **命名空间:** `PED`
- **Hash:** `0x66B57B72E0836A76`
- **JHash:** `0xD050F490`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_BE_TARGETTED_BY_PLAYER(int ped, int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_BE_TARGETTED_BY_TEAM

- **命名空间:** `PED`
- **Hash:** `0xBF1CA77833E58F2C`
- **JHash:** `0xB103A8E1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_BE_TARGETTED_BY_TEAM(int ped, int team, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `team` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_BODY_RECOIL_IK

- **命名空间:** `PED`
- **Hash:** `0xE84EC1735FB39663`
- **Build:** `3717`

**C# 签名:**
```csharp
void SET_PED_CAN_BODY_RECOIL_IK(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_COWER_IN_COVER

- **命名空间:** `PED`
- **Hash:** `0xCB7553CDCEF4A735`
- **JHash:** `0x5194658B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_COWER_IN_COVER(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
It simply makes the said ped to cower behind cover object(wall, desk, car)

Peds flee attributes must be set to not to flee, first. Else, most of the peds, will just flee from gunshot sounds or any other panic situations.
```

---

### SET_PED_CAN_EVASIVE_DIVE

- **命名空间:** `PED`
- **Hash:** `0x6B7A646C242A7059`
- **JHash:** `0x542FEB4D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_EVASIVE_DIVE(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_HEAD_IK

- **命名空间:** `PED`
- **Hash:** `0xC11C18092C5530DC`
- **JHash:** `0xD3B04476`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_HEAD_IK(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_LEG_IK

- **命名空间:** `PED`
- **Hash:** `0x73518ECE2485412B`
- **JHash:** `0x9955BC6F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_LEG_IK(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_LOSE_PROPS_ON_DAMAGE

- **命名空间:** `PED`
- **Hash:** `0xE861D0B05C7662B8`
- **JHash:** `0x2F9550C2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_LOSE_PROPS_ON_DAMAGE(int ped, bool toggle, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |
| `p2` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_PEEK_IN_COVER

- **命名空间:** `PED`
- **Hash:** `0xC514825C507E3736`
- **JHash:** `0xC1DAE216`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_PEEK_IN_COVER(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_PLAY_AMBIENT_ANIMS

- **命名空间:** `PED`
- **Hash:** `0x6373D1349925A70E`
- **JHash:** `0xF8053081`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_PLAY_AMBIENT_ANIMS(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_PLAY_AMBIENT_BASE_ANIMS

- **命名空间:** `PED`
- **Hash:** `0x0EB0585D15254740`
- **JHash:** `0x5720A5DD`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_PLAY_AMBIENT_BASE_ANIMS(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_PLAY_GESTURE_ANIMS

- **命名空间:** `PED`
- **Hash:** `0xBAF20C5432058024`
- **JHash:** `0xE131E3B3`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_PLAY_GESTURE_ANIMS(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_PLAY_IN_CAR_IDLES

- **命名空间:** `PED`
- **Hash:** `0x820E9892A77E97CD`
- **Build:** `877`

**C# 签名:**
```csharp
void SET_PED_CAN_PLAY_IN_CAR_IDLES(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Toggles config flag CPED_CONFIG_FLAG_CanPlayInCarIdles.
```

---

### SET_PED_CAN_PLAY_VISEME_ANIMS

- **命名空间:** `PED`
- **Hash:** `0xF833DDBA3B104D43`
- **JHash:** `0xA2FDAF27`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_PLAY_VISEME_ANIMS(int ped, bool toggle, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p2 usually 0
```

---

### SET_PED_CAN_RAGDOLL

- **命名空间:** `PED`
- **Hash:** `0xB128377056A54E2A`
- **JHash:** `0xCF1384C4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_RAGDOLL(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_RAGDOLL_FROM_PLAYER_IMPACT

- **命名空间:** `PED`
- **Hash:** `0xDF993EE5E90ABA25`
- **JHash:** `0xE9BD733A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_RAGDOLL_FROM_PLAYER_IMPACT(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_SMASH_GLASS

- **命名空间:** `PED`
- **Hash:** `0x1CCE141467FF42A2`
- **JHash:** `0x149C60A8`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_SMASH_GLASS(int ped, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_SWITCH_WEAPON

- **命名空间:** `PED`
- **Hash:** `0xED7F7EFE9FABF340`
- **JHash:** `0xB5F8BA28`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_SWITCH_WEAPON(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_TELEPORT_TO_GROUP_LEADER

- **命名空间:** `PED`
- **Hash:** `0x2E2F4240B3F24647`
- **JHash:** `0xD0D8BDBC`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_TELEPORT_TO_GROUP_LEADER(int pedHandle, int groupHandle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pedHandle` | `Ped` | `int` | - |
| `groupHandle` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This only will teleport the ped to the group leader if the group leader teleports (sets coords).

Only works in singleplayer
```

---

### SET_PED_CAN_TORSO_IK

- **命名空间:** `PED`
- **Hash:** `0xF2B7106D37947CE0`
- **JHash:** `0x8E5D4EAB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_TORSO_IK(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_TORSO_REACT_IK

- **命名空间:** `PED`
- **Hash:** `0xF5846EDB26A98A24`
- **JHash:** `0x7B0040A8`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_TORSO_REACT_IK(int ped, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_TORSO_VEHICLE_IK

- **命名空间:** `PED`
- **Hash:** `0x6647C5F6F5792496`
- **JHash:** `0x0FDA62DE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_TORSO_VEHICLE_IK(int ped, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAN_USE_AUTO_CONVERSATION_LOOKAT

- **命名空间:** `PED`
- **Hash:** `0xEC4686EC06434678`
- **JHash:** `0x584C5178`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAN_USE_AUTO_CONVERSATION_LOOKAT(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CAPSULE

- **命名空间:** `PED`
- **Hash:** `0x364DF566EC833DE2`
- **JHash:** `0xB153E1B9`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CAPSULE(int ped, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Overrides the ped's collision capsule radius for the current tick.
Must be called every tick to be effective.

Setting this to 0.001 will allow warping through some objects.
```

---

### SET_PED_CLOTH_PACKAGE_INDEX

- **命名空间:** `PED`
- **Hash:** `0x82A3D6D9CC2CB8E3`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CLOTH_PACKAGE_INDEX(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CLOTH_PIN_FRAMES

- **命名空间:** `PED`
- **Hash:** `0x78C4E9961DB3EB5B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CLOTH_PIN_FRAMES(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CLOTH_PRONE

- **命名空间:** `PED`
- **Hash:** `0xA660FAF550EB37E5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CLOTH_PRONE(object p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_COMBAT_ABILITY

- **命名空间:** `PED`
- **Hash:** `0xC7622C0D36B2FDA8`
- **JHash:** `0x6C23D329`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_COMBAT_ABILITY(int ped, int abilityLevel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `abilityLevel` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
enum eCombatAbility // 0xE793438C
{
	CA_Poor,
	CA_Average,
	CA_Professional,
	CA_NumTypes
};
```

---

### SET_PED_COMBAT_ATTRIBUTES

- **命名空间:** `PED`
- **Hash:** `0x9F7794730795E019`
- **JHash:** `0x81D64248`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_COMBAT_ATTRIBUTES(int ped, int attributeId, bool enabled)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `attributeId` | `int` | `int` | - |
| `enabled` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
enum eCombatAttributes // 0x0E8E7201
{
	BF_CanUseCover = 0,
	BF_CanUseVehicles = 1,
	BF_CanDoDrivebys = 2,
	BF_CanLeaveVehicle = 3,
	BF_CanUseDynamicStrafeDecisions = 4,
	BF_AlwaysFight = 5,
	BF_0x66BB9FCC = 6,
	BF_0x6837DA41 = 7,
	BF_0xB4A13A5A = 8,
	BF_0xEE326AAD = 9,
	BF_0x7DF2CCFA = 10,
	BF_0x0036D422 = 11,
	BF_BlindFireWhenInCover = 12,
	BF_Aggressive = 13,
	BF_CanInvestigate = 14,
	BF_HasRadio = 15,
	BF_0x6BDE28D1 = 16,
	BF_AlwaysFlee = 17,
	BF_0x7852797D = 18,
	BF_0x33497B95 = 19,
	BF_CanTauntInVehicle = 20,
	BF_CanChaseTargetOnFoot = 21,
	BF_WillDragInjuredPedsToSafety = 22,
	BF_0xCD7168B8 = 23,
	BF_UseProximityFiringRate = 24,
	BF_0x48F914F8 = 25,
	BF_0x2EA543D0 = 26,
	BF_PerfectAccuracy = 27,
	BF_CanUseFrustratedAdvance = 28,
	BF_0x3D131AC1 = 29,
	BF_0x3AD95F27 = 30,
	BF_MaintainMinDistanceToTarget = 31,
	BF_0xEAD68AD2 = 32,
	BF_0xA206C2E0 = 33,
	BF_CanUsePeekingVariations = 34,
	BF_0xA5715184 = 35,
	BF_0xD5265533 = 36,
	BF_0x2B84C2BF = 37,
	BF_DisableBulletReactions = 38,
	BF_CanBust = 39,
	BF_0xAA525726 = 40,
	BF_CanCommandeerVehicles = 41,
	BF_CanFlank = 42,
	BF_SwitchToAdvanceIfCantFindCover = 43,
	BF_SwitchToDefensiveIfInCover = 44,
	BF_0xEB4786A0 = 45,
	BF_CanFightArmedPedsWhenNotArmed = 46,
	BF_0xA08E9402 = 47,
	BF_0x952EAD7D = 48,
	BF_UseEnemyAccuracyScaling = 49,
	BF_CanCharge = 50,
	BF_0xDA8C2BD3 = 51,
	BF_0x6562F017 = 52,
	BF_0xA2C3D53B = 53,
	BF_AlwaysEquipBestWeapon = 54,
	BF_CanSeeUnderwaterPeds = 55,
	BF_0xF619486B = 56,
	BF_0x61EB63A3 = 57,
	BF_DisableFleeFromCombat = 58,
	BF_0x8976D12B = 59,
	BF_CanThrowSmokeGrenade = 60,
	BF_NonMissionPedsFleeFromThisPedUnlessArmed = 61,
	BF_0x5452A10C = 62,
	BF_FleesFromInvincibleOpponents = 63,
	BF_DisableBlockFromPursueDuringVehicleChase = 64,
	BF_DisableSpinOutDuringVehicleChase = 65,
	BF_DisableCruiseInFrontDuringBlockDuringVehicleChase = 66,
	BF_0x0B404731 = 67,
	BF_DisableReactToBuddyShot = 68,
	BF_0x7FFD6AEB = 69,
	BF_0x51F4AEF8 = 70,
	BF_PermitChargeBeyondDefensiveArea = 71,
	BF_0x63E0A8E2 = 72,
	BF_0xDF974436 = 73,
	BF_0x556C080B = 74,
	BF_0xA4D50035 = 75,
	BF_SetDisableShoutTargetPositionOnCombatStart = 76,
	BF_DisableRespondedToThreatBroadcast = 77,
	BF_0xCBB01765 = 78,
	BF_0x4F862ED4 = 79,
	BF_0xEF9C7C40 = 80,
	BF_0xE51B494F = 81,
	BF_0x054D0199 = 82,
	BF_0xD36BCE94 = 83,
	BF_0xFB11F690 = 84,
	BF_0xD208A9AD = 85,
	BF_AllowDogFighting = 86,
	BF_0x07A6E531 = 87,
	BF_0x34F9317B = 88,
	BF_0x4240F5A9 = 89,
	BF_0xEE129DBD = 90,
	BF_0x053AEAD9 = 91
};
```

---

### SET_PED_COMBAT_MOVEMENT

- **命名空间:** `PED`
- **Hash:** `0x4D9CA1009AFBD057`
- **JHash:** `0x12E62F9E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_COMBAT_MOVEMENT(int ped, int combatMovement)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `combatMovement` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
enum eCombatMovement // 0x4F456B61
{
	CM_Stationary,
	CM_Defensive,
	CM_WillAdvance,
	CM_WillRetreat
};
```

---

### SET_PED_COMBAT_RANGE

- **命名空间:** `PED`
- **Hash:** `0x3C606747B23E497B`
- **JHash:** `0x8818A959`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_COMBAT_RANGE(int ped, int combatRange)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `combatRange` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
enum eCombatRange // 0xB69160F5
{
	CR_Near,
	CR_Medium,
	CR_Far,
	CR_VeryFar,
	CR_NumRanges
};
```

---

### SET_PED_COMPONENT_VARIATION

- **命名空间:** `PED`
- **Hash:** `0x262B14F48D29DE80`
- **JHash:** `0xD4F7B05C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_COMPONENT_VARIATION(int ped, int componentId, int drawableId, int textureId, int paletteId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `componentId` | `int` | `int` | - |
| `drawableId` | `int` | `int` | - |
| `textureId` | `int` | `int` | - |
| `paletteId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
paletteId: 0 to 3.

componentId:
enum ePedVarComp
{
	PV_COMP_INVALID = -1,
	PV_COMP_HEAD,
	PV_COMP_BERD,
	PV_COMP_HAIR,
	PV_COMP_UPPR,
	PV_COMP_LOWR,
	PV_COMP_HAND,
	PV_COMP_FEET,
	PV_COMP_TEEF,
	PV_COMP_ACCS,
	PV_COMP_TASK,
	PV_COMP_DECL,
	PV_COMP_JBIB,
	PV_COMP_MAX
};

Examples: https://gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html

Full list of ped components by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pedComponentVariations.json
```

---

### SET_PED_CONFIG_FLAG

- **命名空间:** `PED`
- **Hash:** `0x1913FE4CBF41C463`
- **JHash:** `0x9CFBE10D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CONFIG_FLAG(int ped, int flagId, bool value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `flagId` | `int` | `int` | - |
| `value` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
enum ePedConfigFlags
{
	_CPED_CONFIG_FLAG_0xC63DE95E = 1,
	CPED_CONFIG_FLAG_NoCriticalHits = 2,
	CPED_CONFIG_FLAG_DrownsInWater = 3,
	CPED_CONFIG_FLAG_DisableReticuleFixedLockon = 4,
	_CPED_CONFIG_FLAG_0x37D196F4 = 5,
	_CPED_CONFIG_FLAG_0xE2462399 = 6,
	CPED_CONFIG_FLAG_UpperBodyDamageAnimsOnly = 7,
	_CPED_CONFIG_FLAG_0xEDDEB838 = 8,
	_CPED_CONFIG_FLAG_0xB398B6FD = 9,
	_CPED_CONFIG_FLAG_0xF6664E68 = 10,
	_CPED_CONFIG_FLAG_0xA05E7CA3 = 11,
	_CPED_CONFIG_FLAG_0xCE394045 = 12,
	CPED_CONFIG_FLAG_NeverLeavesGroup = 13,
	_CPED_CONFIG_FLAG_0xCD8D1411 = 14,
	_CPED_CONFIG_FLAG_0xB031F1A9 = 15,
	_CPED_CONFIG_FLAG_0xFE65BEE3 = 16,
	CPED_CONFIG_FLAG_BlockNonTemporaryEvents = 17,
	_CPED_CONFIG_FLAG_0x380165BD = 18,
	_CPED_CONFIG_FLAG_0x07C045C7 = 19,
	_CPED_CONFIG_FLAG_0x583B5E2D = 20,
	_CPED_CONFIG_FLAG_0x475EDA58 = 21,
	_CPED_CONFIG_FLAG_0x8629D05B = 22,
	_CPED_CONFIG_FLAG_0x1522968B = 23,
	CPED_CONFIG_FLAG_IgnoreSeenMelee = 24,
	_CPED_CONFIG_FLAG_0x4CC09C4B = 25,
	_CPED_CONFIG_FLAG_0x034F3053 = 26,
	_CPED_CONFIG_FLAG_0xD91BA7CC = 27,
	_CPED_CONFIG_FLAG_0x5C8DC66E = 28,
	CPED_CONFIG_FLAG_GetOutUndriveableVehicle = 29,
	_CPED_CONFIG_FLAG_0x6580B9D2 = 30,
	_CPED_CONFIG_FLAG_0x0EF7A297 = 31,
	CPED_CONFIG_FLAG_WillFlyThruWindscreen = 32,
	CPED_CONFIG_FLAG_DieWhenRagdoll = 33,
	CPED_CONFIG_FLAG_HasHelmet = 34,
	CPED_CONFIG_FLAG_UseHelmet = 35,
	CPED_CONFIG_FLAG_DontTakeOffHelmet = 36,
	_CPED_CONFIG_FLAG_0xB130D17B = 37,
	_CPED_CONFIG_FLAG_0x5F071200 = 38,
	CPED_CONFIG_FLAG_DisableEvasiveDives = 39,
	_CPED_CONFIG_FLAG_0xC287AAFF = 40,
	_CPED_CONFIG_FLAG_0x203328CC = 41,
	CPED_CONFIG_FLAG_DontInfluenceWantedLevel = 42,
	CPED_CONFIG_FLAG_DisablePlayerLockon = 43,
	CPED_CONFIG_FLAG_DisableLockonToRandomPeds = 44,
	CPED_CONFIG_FLAG_AllowLockonToFriendlyPlayers = 45,
	_CPED_CONFIG_FLAG_0xDB115BFA = 46,
	CPED_CONFIG_FLAG_PedBeingDeleted = 47,
	CPED_CONFIG_FLAG_BlockWeaponSwitching = 48,
	_CPED_CONFIG_FLAG_0xF8E99565 = 49,
	_CPED_CONFIG_FLAG_0xDD17FEE6 = 50,
	_CPED_CONFIG_FLAG_0x7ED9B2C9 = 51,
	_CPED_CONFIG_FLAG_NoCollison = 52,
	_CPED_CONFIG_FLAG_0x5A6C1F6E = 53,
	_CPED_CONFIG_FLAG_0xD749FC41 = 54,
	_CPED_CONFIG_FLAG_0x357F63F3 = 55,
	_CPED_CONFIG_FLAG_0xC5E60961 = 56,
	_CPED_CONFIG_FLAG_0x29275C3E = 57,
	CPED_CONFIG_FLAG_IsFiring = 58,
	CPED_CONFIG_FLAG_WasFiring = 59,
	CPED_CONFIG_FLAG_IsStanding = 60,
	CPED_CONFIG_FLAG_WasStanding = 61,
	CPED_CONFIG_FLAG_InVehicle = 62,
	CPED_CONFIG_FLAG_OnMount = 63,
	CPED_CONFIG_FLAG_AttachedToVehicle = 64,
	CPED_CONFIG_FLAG_IsSwimming = 65,
	CPED_CONFIG_FLAG_WasSwimming = 66,
	CPED_CONFIG_FLAG_IsSkiing = 67,
	CPED_CONFIG_FLAG_IsSitting = 68,
	CPED_CONFIG_FLAG_KilledByStealth = 69,
	CPED_CONFIG_FLAG_KilledByTakedown = 70,
	CPED_CONFIG_FLAG_Knockedout = 71,
	_CPED_CONFIG_FLAG_0x3E3C4560 = 72,
	_CPED_CONFIG_FLAG_0x2994C7B7 = 73,
	_CPED_CONFIG_FLAG_0x6D59D275 = 74,
	CPED_CONFIG_FLAG_UsingCoverPoint = 75,
	CPED_CONFIG_FLAG_IsInTheAir = 76,
	_CPED_CONFIG_FLAG_0x2D493FB7 = 77,
	CPED_CONFIG_FLAG_IsAimingGun = 78,
	_CPED_CONFIG_FLAG_0x14D69875 = 79,
	_CPED_CONFIG_FLAG_0x40B05311 = 80,
	_CPED_CONFIG_FLAG_0x8B230BC5 = 81,
	_CPED_CONFIG_FLAG_0xC74E5842 = 82,
	_CPED_CONFIG_FLAG_0x9EA86147 = 83,
	_CPED_CONFIG_FLAG_0x674C746C = 84,
	_CPED_CONFIG_FLAG_0x3E56A8C2 = 85,
	_CPED_CONFIG_FLAG_0xC144A1EF = 86,
	_CPED_CONFIG_FLAG_0x0548512D = 87,
	_CPED_CONFIG_FLAG_0x31C93909 = 88,
	_CPED_CONFIG_FLAG_0xA0269315 = 89,
	_CPED_CONFIG_FLAG_0xD4D59D4D = 90,
	_CPED_CONFIG_FLAG_0x411D4420 = 91,
	_CPED_CONFIG_FLAG_0xDF4AEF0D = 92,
	CPED_CONFIG_FLAG_ForcePedLoadCover = 93,
	_CPED_CONFIG_FLAG_0x300E4CD3 = 94,
	_CPED_CONFIG_FLAG_0xF1C5BF04 = 95,
	_CPED_CONFIG_FLAG_0x89C2EF13 = 96,
	CPED_CONFIG_FLAG_VaultFromCover = 97,
	_CPED_CONFIG_FLAG_0x02A852C8 = 98,
	_CPED_CONFIG_FLAG_0x3D9407F1 = 99,
	_CPED_CONFIG_FLAG_IsDrunk = 100, // 0x319B4558
	CPED_CONFIG_FLAG_ForcedAim = 101,
	_CPED_CONFIG_FLAG_0xB942D71A = 102,
	_CPED_CONFIG_FLAG_0xD26C55A8 = 103,
	CPED_CONFIG_FLAG_OpenDoorArmIK = 104,
	CPED_CONFIG_FLAG_ForceReload = 105,
	CPED_CONFIG_FLAG_DontActivateRagdollFromVehicleImpact = 106,
	CPED_CONFIG_FLAG_DontActivateRagdollFromBulletImpact = 107,
	CPED_CONFIG_FLAG_DontActivateRagdollFromExplosions = 108,
	CPED_CONFIG_FLAG_DontActivateRagdollFromFire = 109,
	CPED_CONFIG_FLAG_DontActivateRagdollFromElectrocution = 110,
	_CPED_CONFIG_FLAG_0x83C0A4BF = 111,
	_CPED_CONFIG_FLAG_0x0E0FAF8C = 112,
	CPED_CONFIG_FLAG_KeepWeaponHolsteredUnlessFired = 113,
	_CPED_CONFIG_FLAG_0x43B80B79 = 114,
	_CPED_CONFIG_FLAG_0x0D2A9309 = 115,
	CPED_CONFIG_FLAG_GetOutBurningVehicle = 116,
	CPED_CONFIG_FLAG_BumpedByPlayer = 117,
	CPED_CONFIG_FLAG_RunFromFiresAndExplosions = 118,
	CPED_CONFIG_FLAG_TreatAsPlayerDuringTargeting = 119,
	CPED_CONFIG_FLAG_IsHandCuffed = 120,
	CPED_CONFIG_FLAG_IsAnkleCuffed = 121,
	CPED_CONFIG_FLAG_DisableMelee = 122,
	CPED_CONFIG_FLAG_DisableUnarmedDrivebys = 123,
	CPED_CONFIG_FLAG_JustGetsPulledOutWhenElectrocuted = 124,
	_CPED_CONFIG_FLAG_0x5FED6BFD = 125,
	CPED_CONFIG_FLAG_WillNotHotwireLawEnforcementVehicle = 126,
	CPED_CONFIG_FLAG_WillCommandeerRatherThanJack = 127,
	CPED_CONFIG_FLAG_CanBeAgitated = 128,
	CPED_CONFIG_FLAG_ForcePedToFaceLeftInCover = 129,
	CPED_CONFIG_FLAG_ForcePedToFaceRightInCover = 130,
	CPED_CONFIG_FLAG_BlockPedFromTurningInCover = 131,
	CPED_CONFIG_FLAG_KeepRelationshipGroupAfterCleanUp = 132,
	CPED_CONFIG_FLAG_ForcePedToBeDragged = 133,
	CPED_CONFIG_FLAG_PreventPedFromReactingToBeingJacked = 134,
	CPED_CONFIG_FLAG_IsScuba = 135,
	CPED_CONFIG_FLAG_WillArrestRatherThanJack = 136,
	CPED_CONFIG_FLAG_RemoveDeadExtraFarAway = 137,
	CPED_CONFIG_FLAG_RidingTrain = 138,
	CPED_CONFIG_FLAG_ArrestResult = 139,
	CPED_CONFIG_FLAG_CanAttackFriendly = 140,
	CPED_CONFIG_FLAG_WillJackAnyPlayer = 141,
	_CPED_CONFIG_FLAG_0x6901E731 = 142,
	_CPED_CONFIG_FLAG_0x9EC9BF6C = 143,
	CPED_CONFIG_FLAG_WillJackWantedPlayersRatherThanStealCar = 144,
	CPED_CONFIG_FLAG_ShootingAnimFlag = 145,
	CPED_CONFIG_FLAG_DisableLadderClimbing = 146,
	CPED_CONFIG_FLAG_StairsDetected = 147,
	CPED_CONFIG_FLAG_SlopeDetected = 148,
	_CPED_CONFIG_FLAG_0x1A15670B = 149,
	CPED_CONFIG_FLAG_CowerInsteadOfFlee = 150,
	CPED_CONFIG_FLAG_CanActivateRagdollWhenVehicleUpsideDown = 151,
	CPED_CONFIG_FLAG_AlwaysRespondToCriesForHelp = 152,
	CPED_CONFIG_FLAG_DisableBloodPoolCreation = 153,
	CPED_CONFIG_FLAG_ShouldFixIfNoCollision = 154,
	CPED_CONFIG_FLAG_CanPerformArrest = 155,
	CPED_CONFIG_FLAG_CanPerformUncuff = 156,
	CPED_CONFIG_FLAG_CanBeArrested = 157,
	_CPED_CONFIG_FLAG_0xF7960FF5 = 158,
	CPED_CONFIG_FLAG_PlayerPreferFrontSeatMP = 159,
	_CPED_CONFIG_FLAG_0x0C6C3099 = 160,
	_CPED_CONFIG_FLAG_0x645F927A = 161,
	_CPED_CONFIG_FLAG_0xA86549B9 = 162,
	_CPED_CONFIG_FLAG_0x8AAF337A = 163,
	_CPED_CONFIG_FLAG_0x13BAA6E7 = 164,
	_CPED_CONFIG_FLAG_0x5FB9D1F5 = 165,
	CPED_CONFIG_FLAG_IsInjured = 166,
	CPED_CONFIG_FLAG_DontEnterVehiclesInPlayersGroup = 167,
	_CPED_CONFIG_FLAG_0xD8072639 = 168,
	CPED_CONFIG_FLAG_PreventAllMeleeTaunts = 169,
	CPED_CONFIG_FLAG_ForceDirectEntry = 170,
	CPED_CONFIG_FLAG_AlwaysSeeApproachingVehicles = 171,
	CPED_CONFIG_FLAG_CanDiveAwayFromApproachingVehicles = 172,
	CPED_CONFIG_FLAG_AllowPlayerToInterruptVehicleEntryExit = 173,
	CPED_CONFIG_FLAG_OnlyAttackLawIfPlayerIsWanted = 174,
	_CPED_CONFIG_FLAG_0x90008BFA = 175,
	_CPED_CONFIG_FLAG_0x07C7A910 = 176,
	CPED_CONFIG_FLAG_PedsJackingMeDontGetIn = 177,
	_CPED_CONFIG_FLAG_0xCE4E8BE2 = 178,
	CPED_CONFIG_FLAG_PedIgnoresAnimInterruptEvents = 179,
	CPED_CONFIG_FLAG_IsInCustody = 180,
	CPED_CONFIG_FLAG_ForceStandardBumpReactionThresholds = 181,
	CPED_CONFIG_FLAG_LawWillOnlyAttackIfPlayerIsWanted = 182,
	CPED_CONFIG_FLAG_IsAgitated = 183,
	CPED_CONFIG_FLAG_PreventAutoShuffleToDriversSeat = 184,
	CPED_CONFIG_FLAG_UseKinematicModeWhenStationary = 185,
	CPED_CONFIG_FLAG_EnableWeaponBlocking = 186,
	CPED_CONFIG_FLAG_HasHurtStarted = 187,
	CPED_CONFIG_FLAG_DisableHurt = 188,
	CPED_CONFIG_FLAG_PlayerIsWeird = 189,
	_CPED_CONFIG_FLAG_0x32FC208B = 190,
	_CPED_CONFIG_FLAG_0x0C296E5A = 191,
	_CPED_CONFIG_FLAG_0xE63B73EC = 192,
	CPED_CONFIG_FLAG_DoNothingWhenOnFootByDefault = 193,
	CPED_CONFIG_FLAG_UsingScenario = 194,
	CPED_CONFIG_FLAG_VisibleOnScreen = 195,
	_CPED_CONFIG_FLAG_0xD88C58A1 = 196,
	_CPED_CONFIG_FLAG_0x5A3DCF43 = 197,
	_CPED_CONFIG_FLAG_0xEA02B420 = 198,
	CPED_CONFIG_FLAG_DontActivateRagdollOnVehicleCollisionWhenDead = 199,
	CPED_CONFIG_FLAG_HasBeenInArmedCombat = 200,
	_CPED_CONFIG_FLAG_0x5E6466F6 = 201,
	CPED_CONFIG_FLAG_Avoidance_Ignore_All = 202,
	CPED_CONFIG_FLAG_Avoidance_Ignored_by_All = 203,
	CPED_CONFIG_FLAG_Avoidance_Ignore_Group1 = 204,
	CPED_CONFIG_FLAG_Avoidance_Member_of_Group1 = 205,
	CPED_CONFIG_FLAG_ForcedToUseSpecificGroupSeatIndex = 206,
	_CPED_CONFIG_FLAG_0x415B26B9 = 207,
	CPED_CONFIG_FLAG_DisableExplosionReactions = 208,
	CPED_CONFIG_FLAG_DodgedPlayer = 209,
	CPED_CONFIG_FLAG_WaitingForPlayerControlInterrupt = 210,
	CPED_CONFIG_FLAG_ForcedToStayInCover = 211,
	CPED_CONFIG_FLAG_GeneratesSoundEvents = 212,
	CPED_CONFIG_FLAG_ListensToSoundEvents = 213,
	CPED_CONFIG_FLAG_AllowToBeTargetedInAVehicle = 214,
	CPED_CONFIG_FLAG_WaitForDirectEntryPointToBeFreeWhenExiting = 215,
	CPED_CONFIG_FLAG_OnlyRequireOnePressToExitVehicle = 216,
	CPED_CONFIG_FLAG_ForceExitToSkyDive = 217,
	_CPED_CONFIG_FLAG_0x3C7DF9DF = 218,
	_CPED_CONFIG_FLAG_0x848FFEF2 = 219,
	CPED_CONFIG_FLAG_DontEnterLeadersVehicle = 220,
	CPED_CONFIG_FLAG_DisableExitToSkyDive = 221,
	_CPED_CONFIG_FLAG_0x84F722FA = 222,
	_CPED_CONFIG_FLAG_Shrink = 223, // 0xD1B87B1F
	_CPED_CONFIG_FLAG_0x728AA918 = 224,
	CPED_CONFIG_FLAG_DisablePotentialToBeWalkedIntoResponse = 225,
	CPED_CONFIG_FLAG_DisablePedAvoidance = 226,
	CPED_CONFIG_FLAG_ForceRagdollUponDeath = 227,
	_CPED_CONFIG_FLAG_0x1EA7225F = 228,
	CPED_CONFIG_FLAG_DisablePanicInVehicle = 229,
	CPED_CONFIG_FLAG_AllowedToDetachTrailer = 230,
	_CPED_CONFIG_FLAG_0xFC3E572D = 231,
	_CPED_CONFIG_FLAG_0x08E9F9CF = 232,
	_CPED_CONFIG_FLAG_0x2D3BA52D = 233,
	_CPED_CONFIG_FLAG_0xFD2F53EA = 234,
	_CPED_CONFIG_FLAG_0x31A1B03B = 235,
	CPED_CONFIG_FLAG_IsHoldingProp = 236,
	CPED_CONFIG_FLAG_BlocksPathingWhenDead = 237,
	_CPED_CONFIG_FLAG_0xCE57C9A3 = 238,
	_CPED_CONFIG_FLAG_0x26149198 = 239,
	CPED_CONFIG_FLAG_ForceSkinCharacterCloth = 240,
	CPED_CONFIG_FLAG_LeaveEngineOnWhenExitingVehicles = 241,
	CPED_CONFIG_FLAG_PhoneDisableTextingAnimations = 242,
	CPED_CONFIG_FLAG_PhoneDisableTalkingAnimations = 243,
	CPED_CONFIG_FLAG_PhoneDisableCameraAnimations = 244,
	CPED_CONFIG_FLAG_DisableBlindFiringInShotReactions = 245,
	CPED_CONFIG_FLAG_AllowNearbyCoverUsage = 246,
	_CPED_CONFIG_FLAG_0x0C754ACA = 247,
	CPED_CONFIG_FLAG_CanPlayInCarIdles = 248,
	CPED_CONFIG_FLAG_CanAttackNonWantedPlayerAsLaw = 249,
	CPED_CONFIG_FLAG_WillTakeDamageWhenVehicleCrashes = 250,
	CPED_CONFIG_FLAG_AICanDrivePlayerAsRearPassenger = 251,
	CPED_CONFIG_FLAG_PlayerCanJackFriendlyPlayers = 252,
	CPED_CONFIG_FLAG_OnStairs = 253,
	_CPED_CONFIG_FLAG_0xE1A2F73F = 254,
	CPED_CONFIG_FLAG_AIDriverAllowFriendlyPassengerSeatEntry = 255,
	_CPED_CONFIG_FLAG_0xF1EB20A9 = 256,
	CPED_CONFIG_FLAG_AllowMissionPedToUseInjuredMovement = 257,
	_CPED_CONFIG_FLAG_0x329DCF1A = 258,
	_CPED_CONFIG_FLAG_0x8D90DD1B = 259,
	_CPED_CONFIG_FLAG_0xB8A292B7 = 260,
	CPED_CONFIG_FLAG_PreventUsingLowerPrioritySeats = 261,
	_CPED_CONFIG_FLAG_0x2AF558F0 = 262,
	_CPED_CONFIG_FLAG_0x82251455 = 263,
	_CPED_CONFIG_FLAG_0x30CF498B = 264,
	_CPED_CONFIG_FLAG_0xE1CD50AF = 265,
	_CPED_CONFIG_FLAG_0x72E4AE48 = 266,
	_CPED_CONFIG_FLAG_0xC2657EA1 = 267,
	CPED_CONFIG_FLAG_TeleportToLeaderVehicle = 268,
	CPED_CONFIG_FLAG_Avoidance_Ignore_WeirdPedBuffer = 269,
	CPED_CONFIG_FLAG_OnStairSlope = 270,
	_CPED_CONFIG_FLAG_0xA0897933 = 271,
	CPED_CONFIG_FLAG_DontBlipCop = 272,
	CPED_CONFIG_FLAG_ClimbedShiftedFence = 273,
	_CPED_CONFIG_FLAG_0xF7823618 = 274,
	CPED_CONFIG_FLAG_KillWhenTrapped = 275,
	CPED_CONFIG_FLAG_EdgeDetected = 276,
	_CPED_CONFIG_FLAG_0x92B67896 = 277,
	_CPED_CONFIG_FLAG_0xCAD677C9 = 278,
	CPED_CONFIG_FLAG_AvoidTearGas = 279,
	_CPED_CONFIG_FLAG_0x5276AC7B = 280,
	CPED_CONFIG_FLAG_DisableGoToWritheWhenInjured = 281,
	CPED_CONFIG_FLAG_OnlyUseForcedSeatWhenEnteringHeliInGroup = 282,
	_CPED_CONFIG_FLAG_0x9139724D = 283,
	_CPED_CONFIG_FLAG_0xA1457461 = 284,
	CPED_CONFIG_FLAG_DisableWeirdPedEvents = 285,
	CPED_CONFIG_FLAG_ShouldChargeNow = 286,
	CPED_CONFIG_FLAG_RagdollingOnBoat = 287,
	CPED_CONFIG_FLAG_HasBrandishedWeapon = 288,
	_CPED_CONFIG_FLAG_0x1B9EE8A1 = 289,
	_CPED_CONFIG_FLAG_0xF3F5758C = 290,
	_CPED_CONFIG_FLAG_0x2A9307F1 = 291,
	_CPED_CONFIG_FLAG_FreezePosition = 292, // 0x7403D216
	_CPED_CONFIG_FLAG_0xA06A3C6C = 293,
	CPED_CONFIG_FLAG_DisableShockingEvents = 294,
	_CPED_CONFIG_FLAG_0xF8DA25A5 = 295,
	CPED_CONFIG_FLAG_NeverReactToPedOnRoof = 296,
	_CPED_CONFIG_FLAG_0xB31F1187 = 297,
	_CPED_CONFIG_FLAG_0x84315402 = 298,
	CPED_CONFIG_FLAG_DisableShockingDrivingOnPavementEvents = 299,
	_CPED_CONFIG_FLAG_0xC7829B67 = 300,
	CPED_CONFIG_FLAG_DisablePedConstraints = 301,
	CPED_CONFIG_FLAG_ForceInitialPeekInCover = 302,
	_CPED_CONFIG_FLAG_0x2ADA871B = 303,
	_CPED_CONFIG_FLAG_0x47BC8A58 = 304,
	CPED_CONFIG_FLAG_DisableJumpingFromVehiclesAfterLeader = 305,
	_CPED_CONFIG_FLAG_0x4A133C50 = 306,
	_CPED_CONFIG_FLAG_0xC58099C3 = 307,
	_CPED_CONFIG_FLAG_0xF3D76D41 = 308,
	_CPED_CONFIG_FLAG_0xB0EEE9F2 = 309,
	CPED_CONFIG_FLAG_IsInCluster = 310,
	CPED_CONFIG_FLAG_ShoutToGroupOnPlayerMelee = 311,
	CPED_CONFIG_FLAG_IgnoredByAutoOpenDoors = 312,
	_CPED_CONFIG_FLAG_0xD4136C22 = 313,
	CPED_CONFIG_FLAG_ForceIgnoreMeleeActiveCombatant = 314,
	CPED_CONFIG_FLAG_CheckLoSForSoundEvents = 315,
	_CPED_CONFIG_FLAG_0xD5C98277 = 316,
	CPED_CONFIG_FLAG_CanSayFollowedByPlayerAudio = 317,
	CPED_CONFIG_FLAG_ActivateRagdollFromMinorPlayerContact = 318,
	_CPED_CONFIG_FLAG_0xD8BE1D54 = 319,
	CPED_CONFIG_FLAG_ForcePoseCharacterCloth = 320,
	CPED_CONFIG_FLAG_HasClothCollisionBounds = 321,
	CPED_CONFIG_FLAG_HasHighHeels = 322,
	_CPED_CONFIG_FLAG_0x86B01E54 = 323,
	CPED_CONFIG_FLAG_DontBehaveLikeLaw = 324,
	_CPED_CONFIG_FLAG_0xC03B736C = 325, // SpawnedAtScenario?
	CPED_CONFIG_FLAG_DisablePoliceInvestigatingBody = 326,
	CPED_CONFIG_FLAG_DisableWritheShootFromGround = 327,
	CPED_CONFIG_FLAG_LowerPriorityOfWarpSeats = 328,
	CPED_CONFIG_FLAG_DisableTalkTo = 329,
	CPED_CONFIG_FLAG_DontBlip = 330,
	CPED_CONFIG_FLAG_IsSwitchingWeapon = 331,
	CPED_CONFIG_FLAG_IgnoreLegIkRestrictions = 332,
	_CPED_CONFIG_FLAG_0x150468FD = 333,
	_CPED_CONFIG_FLAG_0x914EBD6B = 334,
	_CPED_CONFIG_FLAG_0x79AF3B6D = 335,
	_CPED_CONFIG_FLAG_0x75C7A632 = 336,
	_CPED_CONFIG_FLAG_0x52D530E2 = 337,
	_CPED_CONFIG_FLAG_0xDB2A90E0 = 338,
	CPED_CONFIG_FLAG_AllowTaskDoNothingTimeslicing = 339,
	_CPED_CONFIG_FLAG_0x12ADB567 = 340,
	_CPED_CONFIG_FLAG_0x105C8518 = 341,
	CPED_CONFIG_FLAG_NotAllowedToJackAnyPlayers = 342,
	_CPED_CONFIG_FLAG_0xED152C3E = 343,
	_CPED_CONFIG_FLAG_0xA0EFE6A8 = 344,
	CPED_CONFIG_FLAG_AlwaysLeaveTrainUponArrival = 345,
	_CPED_CONFIG_FLAG_0xCDDFE830 = 346,
	CPED_CONFIG_FLAG_OnlyWritheFromWeaponDamage = 347,
	CPED_CONFIG_FLAG_UseSloMoBloodVfx = 348,
	CPED_CONFIG_FLAG_EquipJetpack = 349,
	CPED_CONFIG_FLAG_PreventDraggedOutOfCarThreatResponse = 350,
	_CPED_CONFIG_FLAG_0xE13D1F7C = 351,
	_CPED_CONFIG_FLAG_0x40E25FB9 = 352,
	_CPED_CONFIG_FLAG_0x930629D9 = 353,
	_CPED_CONFIG_FLAG_0xECCF0C7F = 354,
	_CPED_CONFIG_FLAG_0xB6E9613B = 355,
	CPED_CONFIG_FLAG_ForceDeepSurfaceCheck = 356,
	CPED_CONFIG_FLAG_DisableDeepSurfaceAnims = 357,
	CPED_CONFIG_FLAG_DontBlipNotSynced = 358,
	CPED_CONFIG_FLAG_IsDuckingInVehicle = 359,
	CPED_CONFIG_FLAG_PreventAutoShuffleToTurretSeat = 360,
	CPED_CONFIG_FLAG_DisableEventInteriorStatusCheck = 361,
	CPED_CONFIG_FLAG_HasReserveParachute = 362,
	CPED_CONFIG_FLAG_UseReserveParachute = 363,
	CPED_CONFIG_FLAG_TreatDislikeAsHateWhenInCombat = 364,
	CPED_CONFIG_FLAG_OnlyUpdateTargetWantedIfSeen = 365,
	CPED_CONFIG_FLAG_AllowAutoShuffleToDriversSeat = 366,
	_CPED_CONFIG_FLAG_0xD7E07D37 = 367,
	_CPED_CONFIG_FLAG_0x03C4FD24 = 368,
	_CPED_CONFIG_FLAG_0x7675789A = 369,
	_CPED_CONFIG_FLAG_0xB7288A88 = 370,
	_CPED_CONFIG_FLAG_0xC06B6291 = 371,
	CPED_CONFIG_FLAG_PreventReactingToSilencedCloneBullets = 372,
	CPED_CONFIG_FLAG_DisableInjuredCryForHelpEvents = 373,
	CPED_CONFIG_FLAG_NeverLeaveTrain = 374,
	CPED_CONFIG_FLAG_DontDropJetpackOnDeath = 375,
	_CPED_CONFIG_FLAG_0x147F1FFB = 376,
	_CPED_CONFIG_FLAG_0x4376DD79 = 377,
	_CPED_CONFIG_FLAG_0xCD3DB518 = 378,
	_CPED_CONFIG_FLAG_0xFE4BA4B6 = 379,
	CPED_CONFIG_FLAG_DisableAutoEquipHelmetsInBikes = 380,
	_CPED_CONFIG_FLAG_0xBCD816CD = 381,
	_CPED_CONFIG_FLAG_0xCF02DD69 = 382,
	_CPED_CONFIG_FLAG_0xF73AFA2E = 383,
	_CPED_CONFIG_FLAG_0x80B9A9D0 = 384,
	_CPED_CONFIG_FLAG_0xF601F7EE = 385,
	_CPED_CONFIG_FLAG_0xA91350FC = 386,
	_CPED_CONFIG_FLAG_0x3AB23B96 = 387,
	CPED_CONFIG_FLAG_IsClimbingLadder = 388,
	CPED_CONFIG_FLAG_HasBareFeet = 389,
	CPED_CONFIG_FLAG_UNUSED_REPLACE_ME_2 = 390,
	CPED_CONFIG_FLAG_GoOnWithoutVehicleIfItIsUnableToGetBackToRoad = 391,
	CPED_CONFIG_FLAG_BlockDroppingHealthSnacksOnDeath = 392,
	_CPED_CONFIG_FLAG_0xC11D3E8F = 393,
	CPED_CONFIG_FLAG_ForceThreatResponseToNonFriendToFriendMeleeActions = 394,
	CPED_CONFIG_FLAG_DontRespondToRandomPedsDamage = 395,
	CPED_CONFIG_FLAG_AllowContinuousThreatResponseWantedLevelUpdates = 396,
	CPED_CONFIG_FLAG_KeepTargetLossResponseOnCleanup = 397,
	CPED_CONFIG_FLAG_PlayersDontDragMeOutOfCar = 398,
	CPED_CONFIG_FLAG_BroadcastRepondedToThreatWhenGoingToPointShooting = 399,
	CPED_CONFIG_FLAG_IgnorePedTypeForIsFriendlyWith = 400,
	CPED_CONFIG_FLAG_TreatNonFriendlyAsHateWhenInCombat = 401,
	CPED_CONFIG_FLAG_DontLeaveVehicleIfLeaderNotInVehicle = 402,
	_CPED_CONFIG_FLAG_0x5E5B9591 = 403,
	CPED_CONFIG_FLAG_AllowMeleeReactionIfMeleeProofIsOn = 404,
	_CPED_CONFIG_FLAG_0x77840177 = 405,
	_CPED_CONFIG_FLAG_0x1C7ACAC4 = 406,
	CPED_CONFIG_FLAG_UseNormalExplosionDamageWhenBlownUpInVehicle = 407,
	CPED_CONFIG_FLAG_DisableHomingMissileLockForVehiclePedInside = 408,
	CPED_CONFIG_FLAG_DisableTakeOffScubaGear = 409,
	CPED_CONFIG_FLAG_IgnoreMeleeFistWeaponDamageMult = 410,
	CPED_CONFIG_FLAG_LawPedsCanFleeFromNonWantedPlayer = 411,
	CPED_CONFIG_FLAG_ForceBlipSecurityPedsIfPlayerIsWanted = 412,
	CPED_CONFIG_FLAG_IsHolsteringWeapon = 413,
	CPED_CONFIG_FLAG_UseGoToPointForScenarioNavigation = 414,
	CPED_CONFIG_FLAG_DontClearLocalPassengersWantedLevel = 415,
	CPED_CONFIG_FLAG_BlockAutoSwapOnWeaponPickups = 416,
	CPED_CONFIG_FLAG_ThisPedIsATargetPriorityForAI = 417,
	CPED_CONFIG_FLAG_IsSwitchingHelmetVisor = 418,
	CPED_CONFIG_FLAG_ForceHelmetVisorSwitch = 419,
	_CPED_CONFIG_FLAG_0xCFF5F6DE = 420,
	CPED_CONFIG_FLAG_UseOverrideFootstepPtFx = 421,
	CPED_CONFIG_FLAG_DisableVehicleCombat = 422,
	_CPED_CONFIG_FLAG_0xFE401D26 = 423,
	CPED_CONFIG_FLAG_FallsLikeAircraft = 424,
	_CPED_CONFIG_FLAG_0x2B42AE82 = 425,
	CPED_CONFIG_FLAG_UseLockpickVehicleEntryAnimations = 426,
	CPED_CONFIG_FLAG_IgnoreInteriorCheckForSprinting = 427,
	CPED_CONFIG_FLAG_SwatHeliSpawnWithinLastSpottedLocation = 428,
	CPED_CONFIG_FLAG_DisableStartEngine = 429,
	CPED_CONFIG_FLAG_IgnoreBeingOnFire = 430,
	CPED_CONFIG_FLAG_DisableTurretOrRearSeatPreference = 431,
	CPED_CONFIG_FLAG_DisableWantedHelicopterSpawning = 432,
	CPED_CONFIG_FLAG_UseTargetPerceptionForCreatingAimedAtEvents = 433,
	CPED_CONFIG_FLAG_DisableHomingMissileLockon = 434,
	CPED_CONFIG_FLAG_ForceIgnoreMaxMeleeActiveSupportCombatants = 435,
	CPED_CONFIG_FLAG_StayInDefensiveAreaWhenInVehicle = 436,
	CPED_CONFIG_FLAG_DontShoutTargetPosition = 437,
	CPED_CONFIG_FLAG_DisableHelmetArmor = 438,
	_CPED_CONFIG_FLAG_0xCB7F3A1E = 439,
	_CPED_CONFIG_FLAG_0x50178878 = 440,
	CPED_CONFIG_FLAG_PreventVehExitDueToInvalidWeapon = 441,
	CPED_CONFIG_FLAG_IgnoreNetSessionFriendlyFireCheckForAllowDamage = 442,
	CPED_CONFIG_FLAG_DontLeaveCombatIfTargetPlayerIsAttackedByPolice = 443,
	CPED_CONFIG_FLAG_CheckLockedBeforeWarp = 444,
	CPED_CONFIG_FLAG_DontShuffleInVehicleToMakeRoom = 445,
	CPED_CONFIG_FLAG_GiveWeaponOnGetup = 446,
	CPED_CONFIG_FLAG_DontHitVehicleWithProjectiles = 447,
	CPED_CONFIG_FLAG_DisableForcedEntryForOpenVehiclesFromTryLockedDoor = 448,
	CPED_CONFIG_FLAG_FiresDummyRockets = 449,
	CPED_CONFIG_FLAG_PedIsArresting = 450,
	CPED_CONFIG_FLAG_IsDecoyPed = 451,
	CPED_CONFIG_FLAG_HasEstablishedDecoy = 452,
	CPED_CONFIG_FLAG_BlockDispatchedHelicoptersFromLanding = 453,
	CPED_CONFIG_FLAG_DontCryForHelpOnStun = 454,
	_CPED_CONFIG_FLAG_0xB68D3EAB = 455,
	CPED_CONFIG_FLAG_CanBeIncapacitated = 456,
	_CPED_CONFIG_FLAG_0x4BD5EBAD = 457,
	CPED_CONFIG_FLAG_DontChangeTargetFromMelee = 458,
};
```

---

### SET_PED_COORDS_KEEP_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0x9AFEFF481A85AB2E`
- **JHash:** `0xD66AE1D3`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_COORDS_KEEP_VEHICLE(int ped, float posX, float posY, float posZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
teleports ped to coords along with the vehicle ped is in
```

---

### SET_PED_COORDS_NO_GANG

- **命名空间:** `PED`
- **Hash:** `0x87052FE446E07247`
- **JHash:** `0x9561AD98`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_COORDS_NO_GANG(int ped, float posX, float posY, float posZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_COWER_HASH

- **命名空间:** `PED`
- **Hash:** `0xA549131166868ED3`
- **JHash:** `0x16F30DF4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_COWER_HASH(int ped, string p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1: Only "CODE_HUMAN_STAND_COWER" found in the b617d scripts.
```

---

### SET_PED_DEFAULT_COMPONENT_VARIATION

- **命名空间:** `PED`
- **Hash:** `0x45EEE61580806D63`
- **JHash:** `0xC866A984`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_DEFAULT_COMPONENT_VARIATION(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets Ped Default Clothes
```

---

### SET_PED_DEFENSIVE_AREA_ATTACHED_TO_PED

- **命名空间:** `PED`
- **Hash:** `0x4EF47FE21698A8B6`
- **JHash:** `0x74BDA7CE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_DEFENSIVE_AREA_ATTACHED_TO_PED(int ped, int attachPed, float p2, float p3, float p4, float p5, float p6, float p7, float p8, bool p9, bool p10)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `attachPed` | `Ped` | `int` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `float` | `float` | - |
| `p5` | `float` | `float` | - |
| `p6` | `float` | `float` | - |
| `p7` | `float` | `float` | - |
| `p8` | `float` | `float` | - |
| `p9` | `BOOL` | `bool` | - |
| `p10` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_DEFENSIVE_AREA_DIRECTION

- **命名空间:** `PED`
- **Hash:** `0x413C6C763A4AFFAD`
- **JHash:** `0xB66B0C9A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_DEFENSIVE_AREA_DIRECTION(int ped, float p1, float p2, float p3, bool p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_DEFENSIVE_SPHERE_ATTACHED_TO_PED

- **命名空间:** `PED`
- **Hash:** `0xF9B8F91AAD3B953E`
- **JHash:** `0x40638BDC`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_DEFENSIVE_SPHERE_ATTACHED_TO_PED(int ped, int target, float xOffset, float yOffset, float zOffset, float radius, bool p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `target` | `Ped` | `int` | - |
| `xOffset` | `float` | `float` | - |
| `yOffset` | `float` | `float` | - |
| `zOffset` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `p6` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_DEFENSIVE_SPHERE_ATTACHED_TO_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0xE4723DB6E736CCFF`
- **JHash:** `0x4763B2C6`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_DEFENSIVE_SPHERE_ATTACHED_TO_VEHICLE(int ped, int target, float xOffset, float yOffset, float zOffset, float radius, bool p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `target` | `Vehicle` | `int` | - |
| `xOffset` | `float` | `float` | - |
| `yOffset` | `float` | `float` | - |
| `zOffset` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `p6` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_DENSITY_MULTIPLIER_THIS_FRAME

- **命名空间:** `PED`
- **Hash:** `0x95E3D6257B166CF2`
- **JHash:** `0x039C82BB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_DESIRED_HEADING

- **命名空间:** `PED`
- **Hash:** `0xAA5A7ECE2AA8FE70`
- **JHash:** `0x961458F9`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_DESIRED_HEADING(int ped, float heading)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `heading` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_DIES_INSTANTLY_IN_WATER

- **命名空间:** `PED`
- **Hash:** `0xEEB64139BA29A7CF`
- **JHash:** `0xFE2554FC`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_DIES_INSTANTLY_IN_WATER(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_DIES_IN_SINKING_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0xD718A22995E2B4BC`
- **JHash:** `0x8D4D9ABB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_DIES_IN_SINKING_VEHICLE(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_DIES_IN_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0x2A30922C90C9B42C`
- **JHash:** `0x6FE1E440`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_DIES_IN_VEHICLE(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_DIES_IN_WATER

- **命名空间:** `PED`
- **Hash:** `0x56CEF0AC79073BDE`
- **JHash:** `0x604C872B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_DIES_IN_WATER(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_DIES_WHEN_INJURED

- **命名空间:** `PED`
- **Hash:** `0x5BA7919BED300023`
- **JHash:** `0xE94E24D4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_DIES_WHEN_INJURED(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_DRIVE_BY_CLIPSET_OVERRIDE

- **命名空间:** `PED`
- **Hash:** `0xED34AB6C5CB36520`
- **JHash:** `0xD4C73595`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_DRIVE_BY_CLIPSET_OVERRIDE(int ped, string clipset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `clipset` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_DUCKING

- **命名空间:** `PED`
- **Hash:** `0x030983CA930B692D`
- **JHash:** `0xB90353D7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_DUCKING(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This is the SET_CHAR_DUCKING from GTA IV, that makes Peds duck. This function does nothing in GTA V. It cannot set the ped as ducking in vehicles, and IS_PED_DUCKING will always return false.
```

---

### SET_PED_EMISSIVE_SCALE

- **命名空间:** `PED`
- **Hash:** `0x4E90D746056E273D`
- **Build:** `944`

**C# 签名:**
```csharp
void SET_PED_EMISSIVE_SCALE(int ped, float intensity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `intensity` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
intensity: 0.0f - 1.0f

This native sets the emissive intensity for the given ped. It is used for different 'glow' levels on illuminated clothing.
```

---

### SET_PED_ENABLE_CREW_EMBLEM

- **命名空间:** `PED`
- **Hash:** `0xE906EC930F5FE7C8`
- **Build:** `791`

**C# 签名:**
```csharp
void SET_PED_ENABLE_CREW_EMBLEM(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_ENABLE_WEAPON_BLOCKING

- **命名空间:** `PED`
- **Hash:** `0x97A790315D3831FD`
- **JHash:** `0x4CAD1A4A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_ENABLE_WEAPON_BLOCKING(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_ENVEFF_COLOR_MODULATOR

- **命名空间:** `PED`
- **Hash:** `0xD69411AA0CEBF9E9`
- **JHash:** `0x87A0C174`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_ENVEFF_COLOR_MODULATOR(int ped, int p1, int p2, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `int` | `int` | - |
| `p3` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Something related to the environmental effects natives.
In the "agency_heist3b" script, p1 - p3 are always under 100 - usually they are {87, 81, 68}. If SET_PED_ENVEFF_SCALE is set to 0.65 (instead of the usual 1.0), they use {74, 69, 60}
```

---

### SET_PED_ENVEFF_CPV_ADD

- **命名空间:** `PED`
- **Hash:** `0x110F526AB784111F`
- **JHash:** `0x3B882533`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_ENVEFF_CPV_ADD(int ped, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
In agency_heist3b.c4, its like this 90% of the time:

PED::SET_PED_ENVEFF_CPV_ADD(ped, 0.099);
PED::SET_PED_ENVEFF_SCALE(ped, 1.0);
PED::SET_PED_ENVEFF_CPV_ADD(ped, 87, 81, 68);
PED::SET_ENABLE_PED_ENVEFF_SCALE(ped, 1);

and its like this 10% of the time:

PED::SET_PED_ENVEFF_CPV_ADD(ped, 0.2);
PED::SET_PED_ENVEFF_SCALE(ped, 0.65);
PED::SET_PED_ENVEFF_COLOR_MODULATOR(ped, 74, 69, 60);
PED::SET_ENABLE_PED_ENVEFF_SCALE(ped, 1);
```

---

### SET_PED_ENVEFF_SCALE

- **命名空间:** `PED`
- **Hash:** `0xBF29516833893561`
- **JHash:** `0xFC1CFC27`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_ENVEFF_SCALE(int ped, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Values look to be between 0.0 and 1.0
From decompiled scripts: 0.0, 0.6, 0.65, 0.8, 1.0

You are correct, just looked in IDA it breaks from the function if it's less than 0.0f or greater than 1.0f.
```

---

### SET_PED_FIRING_PATTERN

- **命名空间:** `PED`
- **Hash:** `0x9AC577F5A12AD8A9`
- **JHash:** `0xB4629D66`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_FIRING_PATTERN(int ped, uint patternHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `patternHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
FIRING_PATTERN_BURST_FIRE = 0xD6FF6D61 ( 1073727030 )
FIRING_PATTERN_BURST_FIRE_IN_COVER = 0x026321F1 ( 40051185 )
FIRING_PATTERN_BURST_FIRE_DRIVEBY = 0xD31265F2 ( -753768974 )
FIRING_PATTERN_FROM_GROUND = 0x2264E5D6 ( 577037782 )
FIRING_PATTERN_DELAY_FIRE_BY_ONE_SEC = 0x7A845691 ( 2055493265 )
FIRING_PATTERN_FULL_AUTO = 0xC6EE6B4C ( -957453492 )
FIRING_PATTERN_SINGLE_SHOT = 0x5D60E4E0 ( 1566631136 )
FIRING_PATTERN_BURST_FIRE_PISTOL = 0xA018DB8A ( -1608983670 )
FIRING_PATTERN_BURST_FIRE_SMG = 0xD10DADEE ( 1863348768 )
FIRING_PATTERN_BURST_FIRE_RIFLE = 0x9C74B406 ( -1670073338 )
FIRING_PATTERN_BURST_FIRE_MG = 0xB573C5B4 ( -1250703948 )
FIRING_PATTERN_BURST_FIRE_PUMPSHOTGUN = 0x00BAC39B ( 12239771 )
FIRING_PATTERN_BURST_FIRE_HELI = 0x914E786F ( -1857128337 )
FIRING_PATTERN_BURST_FIRE_MICRO = 0x42EF03FD ( 1122960381 )
FIRING_PATTERN_SHORT_BURSTS = 0x1A92D7DF ( 445831135 )
FIRING_PATTERN_SLOW_FIRE_TANK = 0xE2CA3A71 ( -490063247 )

Firing pattern info: https://pastebin.com/Px036isB
```

---

### SET_PED_FLEE_ATTRIBUTES

- **命名空间:** `PED`
- **Hash:** `0x70A2D1137C8ED7C9`
- **JHash:** `0xA717A875`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_FLEE_ATTRIBUTES(int ped, int attributeFlags, bool enable)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `attributeFlags` | `int` | `int` | - |
| `enable` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
bit 1 (0x2) = use vehicle
bit 15 (0x8000) = force cower
```

---

### SET_PED_GENERATES_DEAD_BODY_EVENTS

- **命名空间:** `PED`
- **Hash:** `0x7FB17BA2E7DECA5B`
- **JHash:** `0xE9B97A2B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_GENERATES_DEAD_BODY_EVENTS(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_GESTURE_GROUP

- **命名空间:** `PED`
- **Hash:** `0xDDF803377F94AAA8`
- **JHash:** `0x170DA109`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_GESTURE_GROUP(int ped, string animGroupGesture)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `animGroupGesture` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
From the scripts:
PED::SET_PED_GESTURE_GROUP(PLAYER::PLAYER_PED_ID(),
"ANIM_GROUP_GESTURE_MISS_FRA0");
PED::SET_PED_GESTURE_GROUP(PLAYER::PLAYER_PED_ID(),
"ANIM_GROUP_GESTURE_MISS_DocksSetup1");
```

---

### SET_PED_GET_OUT_UPSIDE_DOWN_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0xBC0ED94165A48BC2`
- **JHash:** `0x89AD49FF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_GET_OUT_UPSIDE_DOWN_VEHICLE(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_GRAVITY

- **命名空间:** `PED`
- **Hash:** `0x9FF447B6B6AD960A`
- **JHash:** `0x3CA16652`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_GRAVITY(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
enable or disable the gravity of a ped

Examples:
PED::SET_PED_GRAVITY(PLAYER::PLAYER_PED_ID(), 0x00000001);
PED::SET_PED_GRAVITY(Local_289[iVar0 /*20*/], 0x00000001);
```

---

### SET_PED_GROUP_MEMBER_PASSENGER_INDEX

- **命名空间:** `PED`
- **Hash:** `0x0BDDB8D9EC6BCF3C`
- **JHash:** `0x2AB3670B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_GROUP_MEMBER_PASSENGER_INDEX(int ped, int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `index` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_HAIR_TINT

- **命名空间:** `PED`
- **Hash:** `0x4CFFC65454C93A49`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_HAIR_TINT(int ped, int colorID, int highlightColorID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `colorID` | `int` | `int` | - |
| `highlightColorID` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_HEAD_BLEND_DATA

- **命名空间:** `PED`
- **Hash:** `0x9414E18B9434C2FE`
- **JHash:** `0x60746B88`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_HEAD_BLEND_DATA(int ped, int shapeFirstID, int shapeSecondID, int shapeThirdID, int skinFirstID, int skinSecondID, int skinThirdID, float shapeMix, float skinMix, float thirdMix, bool isParent)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `shapeFirstID` | `int` | `int` | - |
| `shapeSecondID` | `int` | `int` | - |
| `shapeThirdID` | `int` | `int` | - |
| `skinFirstID` | `int` | `int` | - |
| `skinSecondID` | `int` | `int` | - |
| `skinThirdID` | `int` | `int` | - |
| `shapeMix` | `float` | `float` | - |
| `skinMix` | `float` | `float` | - |
| `thirdMix` | `float` | `float` | - |
| `isParent` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
The "shape" parameters control the shape of the ped's face. The "skin" parameters control the skin tone. ShapeMix and skinMix control how much the first and second IDs contribute,(typically mother and father.) ThirdMix overrides the others in favor of the third IDs. IsParent is set for "children" of the player character's grandparents during old-gen character creation. It has unknown effect otherwise.

The IDs start at zero and go Male Non-DLC, Female Non-DLC, Male DLC, and Female DLC.

!!!Can someone add working example for this???

try this:
       headBlendData headData;
       GET_PED_HEAD_BLEND_DATA(PLAYER_PED_ID(), &headData);

       SET_PED_HEAD_BLEND_DATA(PLAYER_PED_ID(), headData.shapeFirst, headData.shapeSecond, headData.shapeThird, headData.skinFirst, headData.skinSecond
          , headData.skinThird, headData.shapeMix, headData.skinMix, headData.skinThird, 0);


For more info please refer to this topic. 
gtaforums.com/topic/858970-all-gtao-face-ids-pedset-ped-head-blend-data-explained
```

---

### SET_PED_HEAD_OVERLAY

- **命名空间:** `PED`
- **Hash:** `0x48F44967FA05CC1E`
- **JHash:** `0xD28DBA90`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_HEAD_OVERLAY(int ped, int overlayID, int index, float opacity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `overlayID` | `int` | `int` | - |
| `index` | `int` | `int` | - |
| `opacity` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
OverlayID ranges from 0 to 12, index from 0 to _GET_NUM_OVERLAY_VALUES(overlayID)-1, and opacity from 0.0 to 1.0. 

overlayID       Part                  Index, to disable
0               Blemishes             0 - 23, 255
1               Facial Hair           0 - 28, 255
2               Eyebrows              0 - 33, 255
3               Ageing                0 - 14, 255
4               Makeup                0 - 74, 255
5               Blush                 0 - 6, 255
6               Complexion            0 - 11, 255
7               Sun Damage            0 - 10, 255
8               Lipstick              0 - 9, 255
9               Moles/Freckles        0 - 17, 255
10              Chest Hair            0 - 16, 255
11              Body Blemishes        0 - 11, 255
12              Add Body Blemishes    0 - 1, 255
```

---

### SET_PED_HEAD_OVERLAY_TINT

- **命名空间:** `PED`
- **Hash:** `0x497BF74A7B9CB952`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_HEAD_OVERLAY_TINT(int ped, int overlayID, int colorType, int colorID, int secondColorID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `overlayID` | `int` | `int` | - |
| `colorType` | `int` | `int` | - |
| `colorID` | `int` | `int` | - |
| `secondColorID` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```


ColorType is 1 for eyebrows, beards, and chest hair; 2 for blush and lipstick; and 0 otherwise, though not called in those cases.

Called after SET_PED_HEAD_OVERLAY().
```

---

### SET_PED_HEALTH_PENDING_LAST_DAMAGE_EVENT_OVERRIDE_FLAG

- **命名空间:** `PED`
- **Hash:** `0xB3352E018D6F89DF`
- **Build:** `2699`

**C# 签名:**
```csharp
void SET_PED_HEALTH_PENDING_LAST_DAMAGE_EVENT_OVERRIDE_FLAG(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_HEARING_RANGE

- **命名空间:** `PED`
- **Hash:** `0x33A8F7F7D5F7F33C`
- **JHash:** `0xB32087E0`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_HEARING_RANGE(int ped, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_HEATSCALE_OVERRIDE

- **命名空间:** `PED`
- **Hash:** `0xC1F6EBF9A3D55538`
- **JHash:** `0xEF9142DB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_HEATSCALE_OVERRIDE(int ped, float heatScale)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `heatScale` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_HELMET

- **命名空间:** `PED`
- **Hash:** `0x560A43136EB58105`
- **JHash:** `0xED366E53`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_HELMET(int ped, bool canWearHelmet)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `canWearHelmet` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_HELMET_FLAG

- **命名空间:** `PED`
- **Hash:** `0xC0E78D5C2CE3EB25`
- **JHash:** `0x12677780`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_HELMET_FLAG(int ped, int helmetFlag)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `helmetFlag` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_HELMET_PROP_INDEX

- **命名空间:** `PED`
- **Hash:** `0x26D83693ED99291C`
- **JHash:** `0xA316D13F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_HELMET_PROP_INDEX(int ped, int propIndex, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `propIndex` | `int` | `int` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
List of component/props ID
gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
```

---

### SET_PED_HELMET_TEXTURE_INDEX

- **命名空间:** `PED`
- **Hash:** `0xF1550C4BD22582E2`
- **JHash:** `0x5F6C3328`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_HELMET_TEXTURE_INDEX(int ped, int textureIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `textureIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_HELMET_VISOR_PROP_INDICES

- **命名空间:** `PED`
- **Hash:** `0x3F7325574E41B44D`
- **Build:** `791`

**C# 签名:**
```csharp
void SET_PED_HELMET_VISOR_PROP_INDICES(int ped, bool p1, int p2, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `int` | `int` | - |
| `p3` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_HIGHLY_PERCEPTIVE

- **命名空间:** `PED`
- **Hash:** `0x52D59AB61DDC05DD`
- **JHash:** `0x9A2180FF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_HIGHLY_PERCEPTIVE(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_ID_RANGE

- **命名空间:** `PED`
- **Hash:** `0xF107E836A70DCE05`
- **JHash:** `0xEF3B4ED9`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_ID_RANGE(int ped, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_INCREASED_AVOIDANCE_RADIUS

- **命名空间:** `PED`
- **Hash:** `0x570389D1C3DE3C6B`
- **JHash:** `0x59C52BE6`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_INCREASED_AVOIDANCE_RADIUS(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_INJURED_ON_GROUND_BEHAVIOUR

- **命名空间:** `PED`
- **Hash:** `0xEC4B4B3B9908052A`
- **JHash:** `0xF30658D2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_INJURED_ON_GROUND_BEHAVIOUR(int ped, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_INTO_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0xF75B0D629E1C063D`
- **JHash:** `0x07500C79`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_INTO_VEHICLE(int ped, int vehicle, int seatIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `seatIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Ped: The ped to warp.
vehicle: The vehicle to warp the ped into.
Seat_Index: [-1 is driver seat, -2 first free passenger seat]

Moreinfo of Seat Index
DriverSeat = -1
Passenger = 0
Left Rear = 1
RightRear = 2
```

---

### SET_PED_IN_VEHICLE_CONTEXT

- **命名空间:** `PED`
- **Hash:** `0x530071295899A8C6`
- **JHash:** `0x27F25C0E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_IN_VEHICLE_CONTEXT(int ped, uint context)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `context` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
PED::SET_PED_IN_VEHICLE_CONTEXT(l_128, MISC::GET_HASH_KEY("MINI_PROSTITUTE_LOW_PASSENGER"));
PED::SET_PED_IN_VEHICLE_CONTEXT(l_128, MISC::GET_HASH_KEY("MINI_PROSTITUTE_LOW_RESTRICTED_PASSENGER"));
PED::SET_PED_IN_VEHICLE_CONTEXT(l_3212, MISC::GET_HASH_KEY("MISS_FAMILY1_JIMMY_SIT"));
PED::SET_PED_IN_VEHICLE_CONTEXT(l_3212, MISC::GET_HASH_KEY("MISS_FAMILY1_JIMMY_SIT_REAR"));
PED::SET_PED_IN_VEHICLE_CONTEXT(l_95, MISC::GET_HASH_KEY("MISS_FAMILY2_JIMMY_BICYCLE"));
PED::SET_PED_IN_VEHICLE_CONTEXT(num3, MISC::GET_HASH_KEY("MISSFBI2_MICHAEL_DRIVEBY"));
PED::SET_PED_IN_VEHICLE_CONTEXT(PLAYER::PLAYER_PED_ID(), MISC::GET_HASH_KEY("MISS_ARMENIAN3_FRANKLIN_TENSE"));
PED::SET_PED_IN_VEHICLE_CONTEXT(PLAYER::PLAYER_PED_ID(), MISC::GET_HASH_KEY("MISSFBI5_TREVOR_DRIVING"));
```

---

### SET_PED_IS_AVOIDED_BY_OTHERS

- **命名空间:** `PED`
- **Hash:** `0xA9B61A329BFDCBEA`
- **JHash:** `0x2276DE0D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_IS_AVOIDED_BY_OTHERS(object p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_IS_IGNORED_BY_AUTO_OPEN_DOORS

- **命名空间:** `PED`
- **Hash:** `0x33A60D8BDD6E508C`
- **JHash:** `0xADB2511A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_IS_IGNORED_BY_AUTO_OPEN_DOORS(int ped, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_KEEP_TASK

- **命名空间:** `PED`
- **Hash:** `0x971D38760FBC02EF`
- **JHash:** `0xA7EC79CE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_KEEP_TASK(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_LEG_IK_MODE

- **命名空间:** `PED`
- **Hash:** `0xC396F5B86FF9FEBD`
- **JHash:** `0xFDDB042E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_LEG_IK_MODE(int ped, int mode)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `mode` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
"IK" stands for "Inverse kinematics." I assume this has something to do with how the ped uses his legs to balance. In the scripts, the second parameter is always an int with a value of 2, 0, or sometimes 1
```

---

### SET_PED_LOD_MULTIPLIER

- **命名空间:** `PED`
- **Hash:** `0xDC2C5C242AAC342B`
- **JHash:** `0x1D2B5C70`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_LOD_MULTIPLIER(int ped, float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_MAX_HEALTH

- **命名空间:** `PED`
- **Hash:** `0xF5F6378C4F3419D3`
- **JHash:** `0x5533F60B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_MAX_HEALTH(int ped, int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `value` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the maximum health of a ped.
```

---

### SET_PED_MAX_MOVE_BLEND_RATIO

- **命名空间:** `PED`
- **Hash:** `0x433083750C5E064A`
- **JHash:** `0xEAD0269A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_MAX_MOVE_BLEND_RATIO(int ped, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_MAX_TIME_IN_WATER

- **命名空间:** `PED`
- **Hash:** `0x43C851690662113D`
- **JHash:** `0xFE0A106B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_MAX_TIME_IN_WATER(int ped, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_MAX_TIME_UNDERWATER

- **命名空间:** `PED`
- **Hash:** `0x6BA428C528D9E522`
- **JHash:** `0x082EF240`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_MAX_TIME_UNDERWATER(int ped, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_MICRO_MORPH

- **命名空间:** `PED`
- **Hash:** `0x71A5C1DBA060049E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_MICRO_MORPH(int ped, int index, float scale)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `index` | `int` | `int` | - |
| `scale` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the various freemode face features, e.g. nose length, chin shape. Scale ranges from -1.0 to 1.0.



0 - Nose Width (Thin/Wide)

1 - Nose Peak (Up/Down)

2 - Nose Length (Long/Short)

3 - Nose Bone Curveness (Crooked/Curved)

4 - Nose Tip (Up/Down)

5 - Nose Bone Twist (Left/Right)

6 - Eyebrow (Up/Down)

7 - Eyebrow (In/Out)

8 - Cheek Bones (Up/Down)

9 - Cheek Sideways Bone Size (In/Out)

10 - Cheek Bones Width (Puffed/Gaunt)

11 - Eye Opening (Both) (Wide/Squinted)

12 - Lip Thickness (Both) (Fat/Thin)

13 - Jaw Bone Width (Narrow/Wide)

14 - Jaw Bone Shape (Round/Square)

15 - Chin Bone (Up/Down)

16 - Chin Bone Length (In/Out or Backward/Forward)

17 - Chin Bone Shape (Pointed/Square)

18 - Chin Hole (Chin Bum)

19 - Neck Thickness (Thin/Thick)
```

---

### SET_PED_MIN_GROUND_TIME_FOR_STUNGUN

- **命名空间:** `PED`
- **Hash:** `0xFA0675AB151073FA`
- **JHash:** `0x2F0D0973`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_MIN_GROUND_TIME_FOR_STUNGUN(int ped, int ms)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `ms` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Ped will stay on the ground after being stunned for at lest ms time. (in milliseconds)
```

---

### SET_PED_MIN_MOVE_BLEND_RATIO

- **命名空间:** `PED`
- **Hash:** `0x01A898D26E2333DD`
- **JHash:** `0x383EC364`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_MIN_MOVE_BLEND_RATIO(int ped, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_MODEL_IS_SUPPRESSED

- **命名空间:** `PED`
- **Hash:** `0xE163A4BCE4DE6F11`
- **JHash:** `0x7820CA43`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_MODEL_IS_SUPPRESSED(uint modelHash, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of peds by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/peds.json
```

---

### SET_PED_MONEY

- **命名空间:** `PED`
- **Hash:** `0xA9C8960E8684C1B5`
- **JHash:** `0x40D90BF2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_MONEY(int ped, int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Maximum possible amount of money on MP is 2000. ~JX

-----------------------------------------------------------------------------

Maximum amount that a ped can theoretically have is 65535 (0xFFFF) since the amount is stored as an unsigned short (uint16_t) value.
```

---

### SET_PED_MOTION_BLUR

- **命名空间:** `PED`
- **Hash:** `0x0A986918B102B448`
- **JHash:** `0xA211A128`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_MOTION_BLUR(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_MOTION_IN_COVER_CLIPSET_OVERRIDE

- **命名空间:** `PED`
- **Hash:** `0x9DBA107B4937F809`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_MOTION_IN_COVER_CLIPSET_OVERRIDE(int ped, string p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Found in the b617d scripts:
PED::SET_PED_MOTION_IN_COVER_CLIPSET_OVERRIDE(v_7, "trevor_heist_cover_2h");
```

---

### SET_PED_MOVEMENT_CLIPSET

- **命名空间:** `PED`
- **Hash:** `0xAF8A94EDE7712BEF`
- **JHash:** `0xA817CDEB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_MOVEMENT_CLIPSET(int ped, string clipSet, float transitionSpeed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `clipSet` | `const char*` | `string` | - |
| `transitionSpeed` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
transitionSpeed is the time in seconds it takes to transition from one movement clipset to another.	ransitionSpeed is usually 1.0f

List of movement clipsets:
Thanks to elsewhat for list.

 "ANIM_GROUP_MOVE_BALLISTIC"
 "ANIM_GROUP_MOVE_LEMAR_ALLEY"
 "clipset@move@trash_fast_turn"
 "FEMALE_FAST_RUNNER"
 "missfbi4prepp1_garbageman"
 "move_characters@franklin@fire"
 "move_characters@Jimmy@slow@"
 "move_characters@michael@fire"
 "move_f@flee@a"
 "move_f@scared"
 "move_f@sexy@a"
 "move_heist_lester"
 "move_injured_generic"
 "move_lester_CaneUp"
 "move_m@bag"
 "MOVE_M@BAIL_BOND_NOT_TAZERED"
 "MOVE_M@BAIL_BOND_TAZERED"
 "move_m@brave"
 "move_m@casual@d"
 "move_m@drunk@moderatedrunk"
 "MOVE_M@DRUNK@MODERATEDRUNK"
 "MOVE_M@DRUNK@MODERATEDRUNK_HEAD_UP"
 "MOVE_M@DRUNK@SLIGHTLYDRUNK"
 "MOVE_M@DRUNK@VERYDRUNK"
 "move_m@fire"
 "move_m@gangster@var_e"
 "move_m@gangster@var_f"
 "move_m@gangster@var_i"
 "move_m@JOG@"
 "MOVE_M@PRISON_GAURD"
 "MOVE_P_M_ONE"
 "MOVE_P_M_ONE_BRIEFCASE"
 "move_p_m_zero_janitor"
 "move_p_m_zero_slow"
 "move_ped_bucket"
 "move_ped_crouched"
 "move_ped_mop"
 "MOVE_M@FEMME@"
 "MOVE_F@FEMME@"
 "MOVE_M@GANGSTER@NG"
 "MOVE_F@GANGSTER@NG"
 "MOVE_M@POSH@"
 "MOVE_F@POSH@"
 "MOVE_M@TOUGH_GUY@"
 "MOVE_F@TOUGH_GUY@"

~ NotCrunchyTaco

Full list of movement clipsets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/movementClipsetsCompact.json
```

---

### SET_PED_MOVE_ANIMS_BLEND_OUT

- **命名空间:** `PED`
- **Hash:** `0x9E8C908F41584ECD`
- **JHash:** `0x20E01957`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_MOVE_ANIMS_BLEND_OUT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_MOVE_RATE_IN_WATER_OVERRIDE

- **命名空间:** `PED`
- **Hash:** `0x0B3E35AC043707D9`
- **Build:** `573`

**C# 签名:**
```csharp
void SET_PED_MOVE_RATE_IN_WATER_OVERRIDE(int ped, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_MOVE_RATE_OVERRIDE

- **命名空间:** `PED`
- **Hash:** `0x085BF80FA50A39D1`
- **JHash:** `0x900008C6`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_MOVE_RATE_OVERRIDE(int ped, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Min: 0.00
Max: 10.00

Can be used in combo with fast run cheat.

When value is set to 10.00:
Sprinting without fast run cheat: 66 m/s
Sprinting with fast run cheat: 77 m/s

Needs to be looped!

Note: According to IDA for the Xbox360 xex, when they check bgt they seem to have the min to 0.0f, but the max set to 1.15f not 10.0f.
```

---

### SET_PED_NAME_DEBUG

- **命名空间:** `PED`
- **Hash:** `0x98EFA132A4117BE1`
- **JHash:** `0x20D6273E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_NAME_DEBUG(int ped, string name)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `name` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
NOTE: Debugging functions are not present in the retail version of the game.

*untested but char *name could also be a hash for a localized string
```

---

### SET_PED_NEVER_LEAVES_GROUP

- **命名空间:** `PED`
- **Hash:** `0x3DBFC55D5C9BB447`
- **JHash:** `0x0E038813`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_NEVER_LEAVES_GROUP(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_NON_CREATION_AREA

- **命名空间:** `PED`
- **Hash:** `0xEE01041D559983EA`
- **JHash:** `0x7A97283F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_NON_CREATION_AREA(float x1, float y1, float z1, float x2, float y2, float z2)
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

**返回值:** `void` (Native: `void`)

**说明:**
```
The distance between these points, is the diagonal of a box (remember it's 3D).
```

---

### SET_PED_NO_TIME_DELAY_BEFORE_SHOT

- **命名空间:** `PED`
- **Hash:** `0xA52D5247A4227E14`
- **JHash:** `0xB52BA5F5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_NO_TIME_DELAY_BEFORE_SHOT(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_PANIC_EXIT_SCENARIO

- **命名空间:** `PED`
- **Hash:** `0xFE07FF6495D52E2A`
- **JHash:** `0x59DE73AC`
- **Build:** `323`

**C# 签名:**
```csharp
bool SET_PED_PANIC_EXIT_SCENARIO(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### SET_PED_PARACHUTE_TINT_INDEX

- **命名空间:** `PED`
- **Hash:** `0x333FC8DB079B7186`
- **JHash:** `0x5AEFEC3A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_PARACHUTE_TINT_INDEX(int ped, int tintIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `tintIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_PHONE_PALETTE_IDX

- **命名空间:** `PED`
- **Hash:** `0x83A169EABCDB10A2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_PHONE_PALETTE_IDX(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_PINNED_DOWN

- **命名空间:** `PED`
- **Hash:** `0xAAD6D1ACF08F4612`
- **JHash:** `0xCC78999D`
- **Build:** `323`

**C# 签名:**
```csharp
bool SET_PED_PINNED_DOWN(int ped, bool pinned, int i)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `pinned` | `BOOL` | `bool` | - |
| `i` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
i could be time. Only example in the decompiled scripts uses it as -1.
```

---

### SET_PED_PLAYS_HEAD_ON_HORN_ANIM_WHEN_DIES_IN_VEHICLE

- **命名空间:** `PED`
- **Hash:** `0x94D94BF1A75AED3D`
- **JHash:** `0x7C563CD2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_PLAYS_HEAD_ON_HORN_ANIM_WHEN_DIES_IN_VEHICLE(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native does absolutely nothing, just a nullsub
```

---

### SET_PED_PREFERRED_COVER_SET

- **命名空间:** `PED`
- **Hash:** `0x8421EB4DA7E391B9`
- **JHash:** `0xF3B7EFBF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_PREFERRED_COVER_SET(int ped, object itemSet)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `itemSet` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_PRELOAD_PROP_DATA

- **命名空间:** `PED`
- **Hash:** `0x2B16A3BFF1FBCE49`
- **JHash:** `0xC0E23671`
- **Build:** `323`

**C# 签名:**
```csharp
int SET_PED_PRELOAD_PROP_DATA(int ped, int componentId, int drawableId, int TextureId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `componentId` | `int` | `int` | - |
| `drawableId` | `int` | `int` | - |
| `TextureId` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
List of component/props ID
gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
```

---

### SET_PED_PRELOAD_VARIATION_DATA

- **命名空间:** `PED`
- **Hash:** `0x39D55A620FCB6A3A`
- **JHash:** `0x45F3BDFB`
- **Build:** `323`

**C# 签名:**
```csharp
int SET_PED_PRELOAD_VARIATION_DATA(int ped, int slot, int drawableId, int textureId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `slot` | `int` | `int` | - |
| `drawableId` | `int` | `int` | - |
| `textureId` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
from extreme3.c4
PED::SET_PED_PRELOAD_VARIATION_DATA(PLAYER::PLAYER_PED_ID(), 8, PED::GET_PED_DRAWABLE_VARIATION(PLAYER::PLAYER_PED_ID(), 8), PED::GET_PED_TEXTURE_VARIATION(PLAYER::PLAYER_PED_ID(), 8));

p1 is probably componentId
```

---

### SET_PED_PRIMARY_LOOKAT

- **命名空间:** `PED`
- **Hash:** `0xCD17B554996A8D9E`
- **JHash:** `0x6DEF6F1C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_PRIMARY_LOOKAT(int ped, int lookAt)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `lookAt` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This is only called once in the scripts.

sub_1CD9(&l_49, 0, getElem(3, &l_34, 4), "MICHAEL", 0, 1);
                    sub_1CA8("WORLD_HUMAN_SMOKING", 2);
                    PED::SET_PED_PRIMARY_LOOKAT(getElem(3, &l_34, 4), PLAYER::PLAYER_PED_ID());
```

---

### SET_PED_PROP_INDEX

- **命名空间:** `PED`
- **Hash:** `0x93376B65A266EB5F`
- **JHash:** `0x0829F2E2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_PROP_INDEX(int ped, int componentId, int drawableId, int TextureId, bool attach, object p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `componentId` | `int` | `int` | - |
| `drawableId` | `int` | `int` | - |
| `TextureId` | `int` | `int` | - |
| `attach` | `BOOL` | `bool` | - |
| `p5` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
ComponentId can be set to various things based on what category you're wanting to set
enum PedPropsData
{
    PED_PROP_HATS = 0,
    PED_PROP_GLASSES = 1,
 PED_PROP_EARS = 2,
    PED_PROP_WATCHES = 3,
};
Usage: SET_PED_PROP_INDEX(playerPed, PED_PROP_HATS, GET_NUMBER_OF_PED_PROP_DRAWABLE_VARIATIONS(playerPed, PED_PROP_HATS), GET_NUMBER_OF_PED_PROP_TEXTURE_VARIATIONS(playerPed, PED_PROP_HATS, 0), TRUE);

List of component/props ID
gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
```

---

### SET_PED_RAGDOLL_FORCE_FALL

- **命名空间:** `PED`
- **Hash:** `0x01F6594B923B9251`
- **JHash:** `0x20A5BDE0`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_RAGDOLL_FORCE_FALL(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_RAGDOLL_ON_COLLISION

- **命名空间:** `PED`
- **Hash:** `0xF0A4F1BBF4FA7497`
- **JHash:** `0x2654A0F4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_RAGDOLL_ON_COLLISION(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Causes Ped to ragdoll on collision with any object (e.g Running into trashcan). If applied to player you will sometimes trip on the sidewalk.
```

---

### SET_PED_RANDOM_COMPONENT_VARIATION

- **命名空间:** `PED`
- **Hash:** `0xC8A9481A01E63C28`
- **JHash:** `0x4111BA46`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_RANDOM_COMPONENT_VARIATION(int ped, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 is always 0 in R* scripts.

List of component/props ID
gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
```

---

### SET_PED_RANDOM_PROPS

- **命名空间:** `PED`
- **Hash:** `0xC44AA05345C992C6`
- **JHash:** `0xE3318E0E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_RANDOM_PROPS(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
List of component/props ID
gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
```

---

### SET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH

- **命名空间:** `PED`
- **Hash:** `0xADB3F206518799E8`
- **JHash:** `0x423B7BA2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH(int ped, uint hash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `hash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_RELATIONSHIP_GROUP_HASH

- **命名空间:** `PED`
- **Hash:** `0xC80A74AC829DDD92`
- **JHash:** `0x79F8C18C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_RELATIONSHIP_GROUP_HASH(int ped, uint hash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `hash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_RESERVE_PARACHUTE_TINT_INDEX

- **命名空间:** `PED`
- **Hash:** `0xE88DA0751C22A2AD`
- **JHash:** `0x177EFC79`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_RESERVE_PARACHUTE_TINT_INDEX(int ped, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_RESET_FLAG

- **命名空间:** `PED`
- **Hash:** `0xC1E8A365BF3B29F2`
- **JHash:** `0xCFF6FF66`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_RESET_FLAG(int ped, int flagId, bool doReset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `flagId` | `int` | `int` | - |
| `doReset` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
PED::SET_PED_RESET_FLAG(PLAYER::PLAYER_PED_ID(), 240, 1);
Known values:
PRF_PreventGoingIntoStillInVehicleState = 236 *(fanatic2.c)*
```

---

### SET_PED_SCUBA_GEAR_VARIATION

- **命名空间:** `PED`
- **Hash:** `0x36C6984C3ED0C911`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_SCUBA_GEAR_VARIATION(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native sets a scuba mask for freemode models and an oxygen bottle for player_* models. It works on freemode and player_* models.
```

---

### SET_PED_SEEING_RANGE

- **命名空间:** `PED`
- **Hash:** `0xF29CF591C4BF6CEE`
- **JHash:** `0x4BD72FE8`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_SEEING_RANGE(int ped, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_SHOOTS_AT_COORD

- **命名空间:** `PED`
- **Hash:** `0x96A05E4FB321B1BA`
- **JHash:** `0xFD64EAE5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_SHOOTS_AT_COORD(int ped, float x, float y, float z, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_SHOOT_RATE

- **命名空间:** `PED`
- **Hash:** `0x614DA022990752DC`
- **JHash:** `0xFB301746`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_SHOOT_RATE(int ped, int shootRate)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `shootRate` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
shootRate 0-1000
```

---

### SET_PED_SHOULD_IGNORE_SCENARIO_EXIT_COLLISION_CHECKS

- **命名空间:** `PED`
- **Hash:** `0x425AECF167663F48`
- **JHash:** `0x5BC276AE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_SHOULD_IGNORE_SCENARIO_EXIT_COLLISION_CHECKS(int ped, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_SHOULD_IGNORE_SCENARIO_NAV_CHECKS

- **命名空间:** `PED`
- **Hash:** `0x5B6010B3CBC29095`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_SHOULD_IGNORE_SCENARIO_NAV_CHECKS(object p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_SHOULD_PLAY_DIRECTED_NORMAL_SCENARIO_EXIT

- **命名空间:** `PED`
- **Hash:** `0xEC6935EBE0847B90`
- **Build:** `323`

**C# 签名:**
```csharp
bool SET_PED_SHOULD_PLAY_DIRECTED_NORMAL_SCENARIO_EXIT(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### SET_PED_SHOULD_PLAY_FLEE_SCENARIO_EXIT

- **命名空间:** `PED`
- **Hash:** `0xEEED8FAFEC331A70`
- **JHash:** `0x7B4C3E6F`
- **Build:** `323`

**C# 签名:**
```csharp
bool SET_PED_SHOULD_PLAY_FLEE_SCENARIO_EXIT(int ped, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### SET_PED_SHOULD_PLAY_IMMEDIATE_SCENARIO_EXIT

- **命名空间:** `PED`
- **Hash:** `0xF1C03A5352243A30`
- **JHash:** `0x4C684C81`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_SHOULD_PLAY_IMMEDIATE_SCENARIO_EXIT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_SHOULD_PLAY_NORMAL_SCENARIO_EXIT

- **命名空间:** `PED`
- **Hash:** `0xA3A9299C4F2ADB98`
- **JHash:** `0x033F43FA`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_SHOULD_PLAY_NORMAL_SCENARIO_EXIT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_SHOULD_PROBE_FOR_SCENARIO_EXITS_IN_ONE_FRAME

- **命名空间:** `PED`
- **Hash:** `0xCEDA60A74219D064`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_SHOULD_PROBE_FOR_SCENARIO_EXITS_IN_ONE_FRAME(object p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_SPHERE_DEFENSIVE_AREA

- **命名空间:** `PED`
- **Hash:** `0x9D3151A373974804`
- **JHash:** `0xBD96D8E8`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_SPHERE_DEFENSIVE_AREA(int ped, float x, float y, float z, float radius, bool p5, bool p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `p5` | `BOOL` | `bool` | - |
| `p6` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_STAY_IN_VEHICLE_WHEN_JACKED

- **命名空间:** `PED`
- **Hash:** `0xEDF4079F9D54C9A1`
- **JHash:** `0xB014A09C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_STAY_IN_VEHICLE_WHEN_JACKED(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_STEALTH_MOVEMENT

- **命名空间:** `PED`
- **Hash:** `0x88CBB5CEB96B7BD2`
- **JHash:** `0x67E28E1D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_STEALTH_MOVEMENT(int ped, bool p1, string action)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `action` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 is usually 0 in the scripts. action is either 0 or a pointer to "DEFAULT_ACTION".
```

---

### SET_PED_STEERS_AROUND_DEAD_BODIES

- **命名空间:** `PED`
- **Hash:** `0x2016C603D6B8987C`
- **JHash:** `0xA6F2C057`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_STEERS_AROUND_DEAD_BODIES(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_STEERS_AROUND_OBJECTS

- **命名空间:** `PED`
- **Hash:** `0x1509C089ADC208BF`
- **JHash:** `0x3BD9B0A6`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_STEERS_AROUND_OBJECTS(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_STEERS_AROUND_PEDS

- **命名空间:** `PED`
- **Hash:** `0x46F2193B3AD1D891`
- **JHash:** `0x797CAE4F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_STEERS_AROUND_PEDS(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_STEERS_AROUND_VEHICLES

- **命名空间:** `PED`
- **Hash:** `0xEB6FB9D48DDE23EC`
- **JHash:** `0x533C0651`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_STEERS_AROUND_VEHICLES(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_STEER_BIAS

- **命名空间:** `PED`
- **Hash:** `0x288DF530C92DAD6F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_STEER_BIAS(int ped, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_STRAFE_CLIPSET

- **命名空间:** `PED`
- **Hash:** `0x29A28F3F8CF6D854`
- **JHash:** `0x0BACF010`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_STRAFE_CLIPSET(int ped, string clipSet)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `clipSet` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of movement clipsets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/movementClipsetsCompact.json
```

---

### SET_PED_SUFFERS_CRITICAL_HITS

- **命名空间:** `PED`
- **Hash:** `0xEBD76F2359F190AC`
- **JHash:** `0x6F6FC7E6`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_SUFFERS_CRITICAL_HITS(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Ped no longer takes critical damage modifiers if set to FALSE.
Example: Headshotting a player no longer one shots them. Instead they will take the same damage as a torso shot.
```

---

### SET_PED_SWEAT

- **命名空间:** `PED`
- **Hash:** `0x27B0405F59637D1F`
- **JHash:** `0x76A1DB9F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_SWEAT(int ped, float sweat)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `sweat` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sweat is set to 100.0 or 0.0 in the decompiled scripts.
```

---

### SET_PED_TARGET_LOSS_RESPONSE

- **命名空间:** `PED`
- **Hash:** `0x0703B9079823DA4A`
- **JHash:** `0xCFA613FF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_TARGET_LOSS_RESPONSE(int ped, int responseType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `responseType` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
enum eTargetLossResponseType
{
	TLR_ExitTask,
	TLR_NeverLoseTarget,
	TLR_SearchForTarget
};
```

---

### SET_PED_TO_INFORM_RESPECTED_FRIENDS

- **命名空间:** `PED`
- **Hash:** `0x112942C6E708F70B`
- **JHash:** `0xD78AC46C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_TO_INFORM_RESPECTED_FRIENDS(int ped, float radius, int maxFriends)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `radius` | `float` | `float` | - |
| `maxFriends` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_TO_LOAD_COVER

- **命名空间:** `PED`
- **Hash:** `0x332B562EEDA62399`
- **JHash:** `0xCF94BA97`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_TO_LOAD_COVER(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_TO_RAGDOLL

- **命名空间:** `PED`
- **Hash:** `0xAE99FB955581844A`
- **JHash:** `0x83CB5052`
- **Build:** `323`

**C# 签名:**
```csharp
bool SET_PED_TO_RAGDOLL(int ped, int time1, int time2, int ragdollType, bool p4, bool p5, bool p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `time1` | `int` | `int` | - |
| `time2` | `int` | `int` | - |
| `ragdollType` | `int` | `int` | - |
| `p4` | `BOOL` | `bool` | - |
| `p5` | `BOOL` | `bool` | - |
| `p6` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p4/p5: Unused in TU27
Ragdoll Types:
**0**: CTaskNMRelax
**1**: CTaskNMScriptControl: Hardcoded not to work in networked environments.
**Else**: CTaskNMBalance
time1- Time(ms) Ped is in ragdoll mode; only applies to ragdoll types 0 and not 1.

time2- Unknown time, in milliseconds

ragdollType-
0 : Normal ragdoll
1 : Falls with stiff legs/body
2 : Narrow leg stumble(may not fall)
3 : Wide leg stumble(may not fall)

p4, p5, p6- No idea. In R*'s scripts they are usually either "true, true, false" or "false, false, false".




EDIT 3/11/16: unclear what 'mircoseconds' mean-- a microsecond is 1000x a ms, so time2 must be 1000x time1?  more testing needed.  -sob

Edit Mar 21, 2017: removed part about time2 being the microseconds version of time1. this just isn't correct. time2 is in milliseconds, and time1 and time2 don't seem to be connected in any way.
```

---

### SET_PED_TO_RAGDOLL_WITH_FALL

- **命名空间:** `PED`
- **Hash:** `0xD76632D99E4966C8`
- **JHash:** `0xFA12E286`
- **Build:** `323`

**C# 签名:**
```csharp
bool SET_PED_TO_RAGDOLL_WITH_FALL(int ped, int time, int p2, int ragdollType, float x, float y, float z, float velocity, float p8, float p9, float p10, float p11, float p12, float p13)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `time` | `int` | `int` | - |
| `p2` | `int` | `int` | - |
| `ragdollType` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `velocity` | `float` | `float` | - |
| `p8` | `float` | `float` | - |
| `p9` | `float` | `float` | - |
| `p10` | `float` | `float` | - |
| `p11` | `float` | `float` | - |
| `p12` | `float` | `float` | - |
| `p13` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Return variable is never used in R*'s scripts.

Not sure what p2 does. It seems like it would be a time judging by it's usage in R*'s scripts, but didn't seem to affect anything in my testings.

enum eRagdollType
{
 RD_MALE=0,
 RD_FEMALE = 1,
 RD_MALE_LARGE = 2,
 RD_CUSTOM = 3,
}

x, y, and z are coordinates, most likely to where the ped will fall.

p8 to p13 are always 0f in R*'s scripts.

(Simplified) Example of the usage of the function from R*'s scripts:
ped::set_ped_to_ragdoll_with_fall(ped, 1500, 2000, 1, -entity::get_entity_forward_vector(ped), 1f, 0f, 0f, 0f, 0f, 0f, 0f);

```

---

### SET_PED_TREATED_AS_FRIENDLY

- **命名空间:** `PED`
- **Hash:** `0x0F62619393661D6E`
- **Build:** `877`

**C# 签名:**
```csharp
void SET_PED_TREATED_AS_FRIENDLY(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_UPPER_BODY_DAMAGE_ONLY

- **命名空间:** `PED`
- **Hash:** `0xAFC976FD0580C7B3`
- **JHash:** `0x1572022A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_UPPER_BODY_DAMAGE_ONLY(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_USING_ACTION_MODE

- **命名空间:** `PED`
- **Hash:** `0xD75ACCF5E0FB5367`
- **JHash:** `0x8802F696`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_USING_ACTION_MODE(int ped, bool p1, int p2, string action)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `int` | `int` | - |
| `action` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p2 is usually -1 in the scripts. action is either 0 or "DEFAULT_ACTION".
```

---

### SET_PED_VEHICLE_FORCED_SEAT_USAGE

- **命名空间:** `PED`
- **Hash:** `0x952F06BEECD775CC`
- **JHash:** `0x79CA237B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_VEHICLE_FORCED_SEAT_USAGE(int ped, int vehicle, int seatIndex, int flags, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `seatIndex` | `int` | `int` | - |
| `flags` | `int` | `int` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
seatIndex must be <= 2
```

---

### SET_PED_VISUAL_FIELD_CENTER_ANGLE

- **命名空间:** `PED`
- **Hash:** `0x3B6405E8AB34A907`
- **JHash:** `0xE57202A1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_VISUAL_FIELD_CENTER_ANGLE(int ped, float angle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `angle` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_VISUAL_FIELD_MAX_ANGLE

- **命名空间:** `PED`
- **Hash:** `0x70793BDCA1E854D4`
- **JHash:** `0x0CEA0F9A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_VISUAL_FIELD_MAX_ANGLE(int ped, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_VISUAL_FIELD_MAX_ELEVATION_ANGLE

- **命名空间:** `PED`
- **Hash:** `0x78D0B67629D75856`
- **JHash:** `0x39D9102F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_VISUAL_FIELD_MAX_ELEVATION_ANGLE(int ped, float angle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `angle` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native refers to the field of vision the ped has above them, starting at 0 degrees. 90f would let the ped see enemies directly above of them.
```

---

### SET_PED_VISUAL_FIELD_MIN_ANGLE

- **命名空间:** `PED`
- **Hash:** `0x2DB492222FB21E26`
- **JHash:** `0x72E2E18B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_VISUAL_FIELD_MIN_ANGLE(int ped, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_VISUAL_FIELD_MIN_ELEVATION_ANGLE

- **命名空间:** `PED`
- **Hash:** `0x7A276EB2C224D70F`
- **JHash:** `0x5CC2F1B8`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_VISUAL_FIELD_MIN_ELEVATION_ANGLE(int ped, float angle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `angle` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native refers to the field of vision the ped has below them, starting at 0 degrees. The angle value should be negative.
-90f should let the ped see 90 degrees below them, for example.
```

---

### SET_PED_VISUAL_FIELD_PERIPHERAL_RANGE

- **命名空间:** `PED`
- **Hash:** `0x9C74B0BC831B753A`
- **JHash:** `0xFDF2F7C2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_VISUAL_FIELD_PERIPHERAL_RANGE(int ped, float range)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `range` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_WEAPON_MOVEMENT_CLIPSET

- **命名空间:** `PED`
- **Hash:** `0x2622E35B77D3ACA2`
- **JHash:** `0xF8BE54DC`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_WEAPON_MOVEMENT_CLIPSET(int ped, string clipSet)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `clipSet` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_WETNESS

- **命名空间:** `PED`
- **Hash:** `0xAC0BB4D87777CAE2`
- **Build:** `2802`

**C# 签名:**
```csharp
void SET_PED_WETNESS(int ped, float wetLevel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `wetLevel` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_WETNESS_ENABLED_THIS_FRAME

- **命名空间:** `PED`
- **Hash:** `0xB5485E4907B53019`
- **JHash:** `0xBDE749F7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_WETNESS_ENABLED_THIS_FRAME(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
combined with PED::SET_PED_WETNESS_HEIGHT(), this native makes the ped drenched in water up to the height specified in the other function
```

---

### SET_PED_WETNESS_HEIGHT

- **命名空间:** `PED`
- **Hash:** `0x44CB6447D2571AA0`
- **JHash:** `0x7B33289A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_WETNESS_HEIGHT(int ped, float height)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `height` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
It adds the wetness level to the player clothing/outfit. As if player just got out from water surface.


```

---

### SET_PED_WILL_ONLY_ATTACK_WANTED_PLAYER

- **命名空间:** `PED`
- **Hash:** `0x3E9679C1DFCF422C`
- **Build:** `877`

**C# 签名:**
```csharp
void SET_PED_WILL_ONLY_ATTACK_WANTED_PLAYER(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_POP_CONTROL_SPHERE_THIS_FRAME

- **命名空间:** `PED`
- **Hash:** `0xD8C3BE3EE94CAF2D`
- **JHash:** `0x4BBE5E2C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_POP_CONTROL_SPHERE_THIS_FRAME(float x, float y, float z, float min, float max)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `min` | `float` | `float` | - |
| `max` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Min and max are usually 100.0 and 200.0
```

---

### SET_RAGDOLL_BLOCKING_FLAGS

- **命名空间:** `PED`
- **Hash:** `0x26695EC767728D84`
- **JHash:** `0x9C8F830D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_RAGDOLL_BLOCKING_FLAGS(int ped, int blockingFlag)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `blockingFlag` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Works for both player and peds,

enum eRagdollBlockingFlags
{
 RBF_BULLET_IMPACT = 0,
 RBF_VEHICLE_IMPACT = 1,
 RBF_FIRE = 2,
 RBF_ELECTROCUTION = 3,
 RBF_PLAYER_IMPACT = 4,
 RBF_EXPLOSION = 5,0
 RBF_IMPACT_OBJECT = 6,
 RBF_MELEE = 7,
 RBF_RUBBER_BULLET = 8,
 RBF_FALLING = 9,
 RBF_WATER_JET = 10,
 RBF_DROWNING = 11,
 _0x9F52E2C4 = 12,
 RBF_PLAYER_BUMP = 13,
 RBF_PLAYER_RAGDOLL_BUMP = 14,
 RBF_PED_RAGDOLL_BUMP = 15,
 RBF_VEHICLE_GRAB = 16,
 RBF_SMOKE_GRENADE = 17,
};


```

---

### SET_RELATIONSHIP_BETWEEN_GROUPS

- **命名空间:** `PED`
- **Hash:** `0xBF25EB89375A37AD`
- **JHash:** `0xD4A215BA`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_RELATIONSHIP_BETWEEN_GROUPS(int relationship, uint group1, uint group2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `relationship` | `int` | `int` | - |
| `group1` | `Hash` | `uint` | - |
| `group2` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the relationship between two groups. This should be called twice (once for each group).

Relationship types:
0 = Companion
1 = Respect
2 = Like
3 = Neutral
4 = Dislike
5 = Hate
255 = Pedestrians

Example:
PED::SET_RELATIONSHIP_BETWEEN_GROUPS(2, l_1017, 0xA49E591C);
PED::SET_RELATIONSHIP_BETWEEN_GROUPS(2, 0xA49E591C, l_1017);
```

---

### SET_RELATIONSHIP_GROUP_AFFECTS_WANTED_LEVEL

- **命名空间:** `PED`
- **Hash:** `0x5615E0C5EB2BC6E2`
- **Build:** `877`

**C# 签名:**
```csharp
void SET_RELATIONSHIP_GROUP_AFFECTS_WANTED_LEVEL(uint group, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `group` | `Hash` | `uint` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SCENARIO_PEDS_SPAWN_IN_SPHERE_AREA

- **命名空间:** `PED`
- **Hash:** `0x28157D43CF600981`
- **JHash:** `0x80EAD297`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SCENARIO_PEDS_SPAWN_IN_SPHERE_AREA(float x, float y, float z, float range, int p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `range` | `float` | `float` | - |
| `p4` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SCENARIO_PEDS_TO_BE_RETURNED_BY_NEXT_COMMAND

- **命名空间:** `PED`
- **Hash:** `0x14F19A8782C8071E`
- **JHash:** `0x85615FD0`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SCENARIO_PEDS_TO_BE_RETURNED_BY_NEXT_COMMAND(bool value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets a value indicating whether scenario peds should be returned by the next call to a command that returns peds. Eg. GET_CLOSEST_PED.
```

---

### SET_SCENARIO_PED_DENSITY_MULTIPLIER_THIS_FRAME

- **命名空间:** `PED`
- **Hash:** `0x7A556143A1C03898`
- **JHash:** `0x2909ABF0`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SCENARIO_PED_DENSITY_MULTIPLIER_THIS_FRAME(float p0, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SCRIPTED_ANIM_SEAT_OFFSET

- **命名空间:** `PED`
- **Hash:** `0x5917BBA32D06C230`
- **JHash:** `0x7CEFFA45`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SCRIPTED_ANIM_SEAT_OFFSET(int ped, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SCRIPTED_CONVERSION_COORD_THIS_FRAME

- **命名空间:** `PED`
- **Hash:** `0x5086C7843552CF85`
- **JHash:** `0x25EA2AA5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SCRIPTED_CONVERSION_COORD_THIS_FRAME(float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SYNCHRONIZED_SCENE_HOLD_LAST_FRAME

- **命名空间:** `PED`
- **Hash:** `0x394B9CD12435C981`
- **JHash:** `0x2DE48DA1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SYNCHRONIZED_SCENE_HOLD_LAST_FRAME(int sceneID, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `sceneID` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SYNCHRONIZED_SCENE_LOOPED

- **命名空间:** `PED`
- **Hash:** `0xD9A897A4C6C2974F`
- **JHash:** `0x32ED9F82`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SYNCHRONIZED_SCENE_LOOPED(int sceneID, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `sceneID` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SYNCHRONIZED_SCENE_ORIGIN

- **命名空间:** `PED`
- **Hash:** `0x6ACF6B7225801CD7`
- **JHash:** `0x2EC2A0B2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SYNCHRONIZED_SCENE_ORIGIN(int sceneID, float x, float y, float z, float roll, float pitch, float yaw, bool p7)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `sceneID` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `roll` | `float` | `float` | - |
| `pitch` | `float` | `float` | - |
| `yaw` | `float` | `float` | - |
| `p7` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SYNCHRONIZED_SCENE_PHASE

- **命名空间:** `PED`
- **Hash:** `0x734292F4F0ABF6D0`
- **JHash:** `0xF5AB0D98`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SYNCHRONIZED_SCENE_PHASE(int sceneID, float phase)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `sceneID` | `int` | `int` | - |
| `phase` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SYNCHRONIZED_SCENE_RATE

- **命名空间:** `PED`
- **Hash:** `0xB6C49F8A5E295A5D`
- **JHash:** `0xF10112FD`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SYNCHRONIZED_SCENE_RATE(int sceneID, float rate)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `sceneID` | `int` | `int` | - |
| `rate` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TREAT_AS_AMBIENT_PED_FOR_DRIVER_LOCKON

- **命名空间:** `PED`
- **Hash:** `0x2F3C3D9F50681DE4`
- **JHash:** `0xCC9D7F1A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TREAT_AS_AMBIENT_PED_FOR_DRIVER_LOCKON(int ped, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_USE_CAMERA_HEADING_FOR_DESIRED_DIRECTION_LOCK_ON_TEST

- **命名空间:** `PED`
- **Hash:** `0xFD325494792302D7`
- **JHash:** `0x7F67671D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_USE_CAMERA_HEADING_FOR_DESIRED_DIRECTION_LOCK_ON_TEST(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SPAWNPOINTS_CANCEL_SEARCH

- **命名空间:** `PED`
- **Hash:** `0xFEE4A5459472A9F8`
- **JHash:** `0x492C9E46`
- **Build:** `323`

**C# 签名:**
```csharp
void SPAWNPOINTS_CANCEL_SEARCH()
```

**返回值:** `void` (Native: `void`)

---

### SPAWNPOINTS_GET_NUM_SEARCH_RESULTS

- **命名空间:** `PED`
- **Hash:** `0xA635C11B8C44AFC2`
- **JHash:** `0xF46B4DC8`
- **Build:** `323`

**C# 签名:**
```csharp
int SPAWNPOINTS_GET_NUM_SEARCH_RESULTS()
```

**返回值:** `int` (Native: `int`)

---

### SPAWNPOINTS_GET_SEARCH_RESULT

- **命名空间:** `PED`
- **Hash:** `0x280C7E3AC7F56E90`
- **JHash:** `0x36A4AC65`
- **Build:** `323`

**C# 签名:**
```csharp
void SPAWNPOINTS_GET_SEARCH_RESULT(int randomInt, ref float x, ref float y, ref float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `randomInt` | `int` | `int` | - |
| `x` | `float*` | `ref float` | - |
| `y` | `float*` | `ref float` | - |
| `z` | `float*` | `ref float` | - |

**返回值:** `void` (Native: `void`)

---

### SPAWNPOINTS_GET_SEARCH_RESULT_FLAGS

- **命名空间:** `PED`
- **Hash:** `0xB782F8238512BAD5`
- **JHash:** `0xBA699DDF`
- **Build:** `323`

**C# 签名:**
```csharp
void SPAWNPOINTS_GET_SEARCH_RESULT_FLAGS(int p0, ref int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

---

### SPAWNPOINTS_IS_SEARCH_ACTIVE

- **命名空间:** `PED`
- **Hash:** `0x3C67506996001F5E`
- **JHash:** `0x814A28F4`
- **Build:** `323`

**C# 签名:**
```csharp
bool SPAWNPOINTS_IS_SEARCH_ACTIVE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### SPAWNPOINTS_IS_SEARCH_COMPLETE

- **命名空间:** `PED`
- **Hash:** `0xA586FBEB32A53DBB`
- **JHash:** `0x0B60D2BA`
- **Build:** `323`

**C# 签名:**
```csharp
bool SPAWNPOINTS_IS_SEARCH_COMPLETE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### SPAWNPOINTS_IS_SEARCH_FAILED

- **命名空间:** `PED`
- **Hash:** `0xF445DE8DA80A1792`
- **JHash:** `0x6B83ABDF`
- **Build:** `323`

**C# 签名:**
```csharp
bool SPAWNPOINTS_IS_SEARCH_FAILED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### SPAWNPOINTS_START_SEARCH

- **命名空间:** `PED`
- **Hash:** `0x2DF9038C90AD5264`
- **JHash:** `0x909A1D76`
- **Build:** `323`

**C# 签名:**
```csharp
void SPAWNPOINTS_START_SEARCH(float p0, float p1, float p2, float p3, float p4, int interiorFlags, float scale, int duration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `float` | `float` | - |
| `interiorFlags` | `int` | `int` | - |
| `scale` | `float` | `float` | - |
| `duration` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SPAWNPOINTS_START_SEARCH_IN_ANGLED_AREA

- **命名空间:** `PED`
- **Hash:** `0xB2AFF10216DEFA2F`
- **JHash:** `0x4AAD0ECB`
- **Build:** `323`

**C# 签名:**
```csharp
void SPAWNPOINTS_START_SEARCH_IN_ANGLED_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float width, int interiorFlags, float scale, int duration)
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
| `interiorFlags` | `int` | `int` | - |
| `scale` | `float` | `float` | - |
| `duration` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SPECIAL_FUNCTION_DO_NOT_USE

- **命名空间:** `PED`
- **Hash:** `0xF9ACF4A08098EA25`
- **JHash:** `0x141CC936`
- **Build:** `323`

**C# 签名:**
```csharp
void SPECIAL_FUNCTION_DO_NOT_USE(int ped, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 was always 1 (true).

Kicks the ped from the current vehicle and keeps the rendering-focus on this ped (also disables its collision). If doing this for your player ped, you'll still be able to drive the vehicle.
```

---

### STOP_ANY_PED_MODEL_BEING_SUPPRESSED

- **命名空间:** `PED`
- **Hash:** `0xB47BD05FA66B40CF`
- **JHash:** `0x5AD7DC55`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_ANY_PED_MODEL_BEING_SUPPRESSED()
```

**返回值:** `void` (Native: `void`)

---

### STOP_PED_WEAPON_FIRING_WHEN_DROPPED

- **命名空间:** `PED`
- **Hash:** `0xC158D28142A34608`
- **JHash:** `0x4AC3421E`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_PED_WEAPON_FIRING_WHEN_DROPPED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SUPPRESS_AMBIENT_PED_AGGRESSIVE_CLEANUP_THIS_FRAME

- **命名空间:** `PED`
- **Hash:** `0x5A7F62FDA59759BD`
- **JHash:** `0xB48C0C04`
- **Build:** `323`

**C# 签名:**
```csharp
void SUPPRESS_AMBIENT_PED_AGGRESSIVE_CLEANUP_THIS_FRAME()
```

**返回值:** `void` (Native: `void`)

---

### TAKE_OWNERSHIP_OF_SYNCHRONIZED_SCENE

- **命名空间:** `PED`
- **Hash:** `0xCD9CC7E200A52A6F`
- **JHash:** `0xBF7F9035`
- **Build:** `323`

**C# 签名:**
```csharp
void TAKE_OWNERSHIP_OF_SYNCHRONIZED_SCENE(int scene)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scene` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TELL_GROUP_PEDS_IN_AREA_TO_ATTACK

- **命名空间:** `PED`
- **Hash:** `0xAD27D957598E49E9`
- **Build:** `1290`

**C# 签名:**
```csharp
void TELL_GROUP_PEDS_IN_AREA_TO_ATTACK(int ped, object p1, float p2, uint hash, object p4, object p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `float` | `float` | - |
| `hash` | `Hash` | `uint` | - |
| `p4` | `Any` | `object` | - |
| `p5` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### TOGGLE_SCENARIO_PED_COWER_IN_PLACE

- **命名空间:** `PED`
- **Hash:** `0x9A77DFD295E29B09`
- **JHash:** `0xC08FE5F6`
- **Build:** `323`

**C# 签名:**
```csharp
void TOGGLE_SCENARIO_PED_COWER_IN_PLACE(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### TRIGGER_IDLE_ANIMATION_ON_PED

- **命名空间:** `PED`
- **Hash:** `0xC2EE020F5FB4DB53`
- **JHash:** `0xB7CD0A49`
- **Build:** `323`

**C# 签名:**
```csharp
void TRIGGER_IDLE_ANIMATION_ON_PED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TRIGGER_PED_SCENARIO_PANICEXITTOFLEE

- **命名空间:** `PED`
- **Hash:** `0x25361A96E0F7E419`
- **JHash:** `0x58C0F6CF`
- **Build:** `323`

**C# 签名:**
```csharp
bool TRIGGER_PED_SCENARIO_PANICEXITTOFLEE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UNREGISTER_PEDHEADSHOT

- **命名空间:** `PED`
- **Hash:** `0x96B1361D9B24C2FF`
- **JHash:** `0x0879AE45`
- **Build:** `323`

**C# 签名:**
```csharp
void UNREGISTER_PEDHEADSHOT(int id)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `id` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
gtaforums.com/topic/885580-ped-headshotmugshot-txd/
```

---

### UPDATE_PED_HEAD_BLEND_DATA

- **命名空间:** `PED`
- **Hash:** `0x723538F61C647C5A`
- **JHash:** `0x5CB76219`
- **Build:** `323`

**C# 签名:**
```csharp
void UPDATE_PED_HEAD_BLEND_DATA(int ped, float shapeMix, float skinMix, float thirdMix)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `shapeMix` | `float` | `float` | - |
| `skinMix` | `float` | `float` | - |
| `thirdMix` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
See SET_PED_HEAD_BLEND_DATA().
```

---

### WAS_PED_KILLED_BY_STEALTH

- **命名空间:** `PED`
- **Hash:** `0xF9800AA1A771B000`
- **JHash:** `0x2EA4B54E`
- **Build:** `323`

**C# 签名:**
```csharp
bool WAS_PED_KILLED_BY_STEALTH(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### WAS_PED_KILLED_BY_TAKEDOWN

- **命名空间:** `PED`
- **Hash:** `0x7F08E26039C7347C`
- **JHash:** `0xBDD3CE69`
- **Build:** `323`

**C# 签名:**
```csharp
bool WAS_PED_KILLED_BY_TAKEDOWN(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### WAS_PED_KNOCKED_OUT

- **命名空间:** `PED`
- **Hash:** `0x61767F73EACEED21`
- **JHash:** `0x3993092B`
- **Build:** `323`

**C# 签名:**
```csharp
bool WAS_PED_KNOCKED_OUT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### WAS_PED_SKELETON_UPDATED

- **命名空间:** `PED`
- **Hash:** `0x11B499C1E0FF8559`
- **JHash:** `0xF7E2FBAD`
- **Build:** `323`

**C# 签名:**
```csharp
bool WAS_PED_SKELETON_UPDATED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Despite this function's name, it simply returns whether the specified handle is a Ped.
```

---

### _HAS_PED_CLEAR_LOS_TO_ENTITY

- **命名空间:** `PED`
- **Hash:** `0xA32ABFEB2A03B306`
- **Build:** `3095`

**C# 签名:**
```csharp
bool _HAS_PED_CLEAR_LOS_TO_ENTITY(int ped, int entity, float x, float y, float z, int p5, bool p6, bool p7)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `entity` | `Entity` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p5` | `int` | `int` | - |
| `p6` | `BOOL` | `bool` | - |
| `p7` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### _SET_BLOCK_AMBIENT_PEDS_FROM_DROPPING_WEAPONS_THIS_FRAME

- **命名空间:** `PED`
- **Hash:** `0xC73EFFC5E043A8BA`
- **Build:** `3258`

**C# 签名:**
```csharp
void _SET_BLOCK_AMBIENT_PEDS_FROM_DROPPING_WEAPONS_THIS_FRAME()
```

**返回值:** `void` (Native: `void`)

---

### _SET_PED_SURVIVES_BEING_OUT_OF_WATER

- **命名空间:** `PED`
- **Hash:** `0x100CD221F572F6E1`
- **Build:** `3407`

**C# 签名:**
```csharp
bool _SET_PED_SURVIVES_BEING_OUT_OF_WATER(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---
