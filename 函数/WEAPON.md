# WEAPON - Native 函数参考

> 命名空间: WEAPON

---

## 快速索引

| 函数名 | C# 签名 | 返回值 | 说明 |
|--------|---------|--------|------|
| `ADD_AMMO_TO_PED` | `void ADD_AMMO_TO_PED(int ped, uint weaponHash, int ammo)` | void | Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons... |
| `ADD_PED_AMMO_BY_TYPE` | `void ADD_PED_AMMO_BY_TYPE(int ped, uint ammoTypeHash, int ammo)` | void | Ammo types: https://gist.github.com/root-cause/faf41f59f7a6d818b7db0b839bd147c1 |
| `CAN_USE_WEAPON_ON_PARACHUTE` | `bool CAN_USE_WEAPON_ON_PARACHUTE(uint weaponHash)` | bool | this returns if you can use the weapon while using a parachute<br>Full list of weapons by DurtyFree: ht... |
| `CLEAR_ENTITY_LAST_WEAPON_DAMAGE` | `void CLEAR_ENTITY_LAST_WEAPON_DAMAGE(int entity)` | void | - |
| `CLEAR_PED_LAST_WEAPON_DAMAGE` | `void CLEAR_PED_LAST_WEAPON_DAMAGE(int ped)` | void | Does NOT seem to work with HAS_PED_BEEN_DAMAGED_BY_WEAPON. Use CLEAR_ENTITY_LAST_WEAPON_DAMAGE and H... |
| `CREATE_AIR_DEFENCE_ANGLED_AREA` | `int CREATE_AIR_DEFENCE_ANGLED_AREA(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float radius, uint weaponHash)` | int | Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons... |
| `CREATE_AIR_DEFENCE_SPHERE` | `int CREATE_AIR_DEFENCE_SPHERE(float x, float y, float z, float radius, float p4, float p5, float p6, uint weaponHash)` | int | Both coordinates are from objects in the decompiled scripts. Native related to 0xECDC202B25E5CF48 p1... |
| `CREATE_WEAPON_OBJECT` | `int CREATE_WEAPON_OBJECT(uint weaponHash, int ammoCount, float x, float y, float z, bool showWorldModel, float scale, object p7, object p8, object p9)` | int | Now has 8 params. |
| `DOES_AIR_DEFENCE_SPHERE_EXIST` | `bool DOES_AIR_DEFENCE_SPHERE_EXIST(int zoneId)` | bool | - |
| `DOES_WEAPON_TAKE_WEAPON_COMPONENT` | `bool DOES_WEAPON_TAKE_WEAPON_COMPONENT(uint weaponHash, uint componentHash)` | bool | Full list of weapons & components by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/m... |
| `ENABLE_LASER_SIGHT_RENDERING` | `void ENABLE_LASER_SIGHT_RENDERING(bool toggle)` | void | Enables laser sight on any weapon.<br><br>It doesn't work. Neither on tick nor OnKeyDown |
| `EXPLODE_PROJECTILES` | `void EXPLODE_PROJECTILES(int ped, uint weaponHash, bool p2)` | void |              WEAPON::EXPLODE_PROJECTILES(PLAYER::PLAYER_PED_ID(), func_221(0x00000003), 0x00000001); |
| `FIRE_AIR_DEFENCE_SPHERE_WEAPON_AT_POSITION` | `void FIRE_AIR_DEFENCE_SPHERE_WEAPON_AT_POSITION(int zoneId, float x, float y, float z)` | void | - |
| `GET_AMMO_IN_CLIP` | `bool GET_AMMO_IN_CLIP(int ped, uint weaponHash, ref int ammo)` | bool | Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons... |
| `GET_AMMO_IN_PED_WEAPON` | `int GET_AMMO_IN_PED_WEAPON(int ped, uint weaponhash)` | int | WEAPON::GET_AMMO_IN_PED_WEAPON(PLAYER::PLAYER_PED_ID(), a_0)<br><br>From decompiled scripts<br>Returns total ... |
| `GET_BEST_PED_WEAPON` | `uint GET_BEST_PED_WEAPON(int ped, bool p1)` | uint | p1 is always 0 in the scripts. |
| `GET_CURRENT_PED_VEHICLE_WEAPON` | `bool GET_CURRENT_PED_VEHICLE_WEAPON(int ped, Hash* weaponHash)` | bool | Example in VB<br><br>    Public Shared Function GetVehicleCurrentWeapon(Ped As Ped) As Integer<br>        Dim... |
| `GET_CURRENT_PED_WEAPON` | `bool GET_CURRENT_PED_WEAPON(int ped, Hash* weaponHash, bool p2)` | bool | The return value seems to indicate returns true if the hash of the weapon object weapon equals the w... |
| `GET_CURRENT_PED_WEAPON_ENTITY_INDEX` | `int GET_CURRENT_PED_WEAPON_ENTITY_INDEX(int ped, object p1)` | int | - |
| `GET_IS_PED_GADGET_EQUIPPED` | `bool GET_IS_PED_GADGET_EQUIPPED(int ped, uint gadgetHash)` | bool | gadgetHash - was always 0xFBAB5776 ("GADGET_PARACHUTE"). |
| `GET_LOCKON_DISTANCE_OF_CURRENT_PED_WEAPON` | `float GET_LOCKON_DISTANCE_OF_CURRENT_PED_WEAPON(int ped)` | float | - |
| `GET_MAX_AMMO` | `bool GET_MAX_AMMO(int ped, uint weaponHash, ref int ammo)` | bool | Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons... |
| `GET_MAX_AMMO_BY_TYPE` | `bool GET_MAX_AMMO_BY_TYPE(int ped, uint ammoTypeHash, ref int ammo)` | bool | Returns the max ammo for an ammo type. Ammo types: https://gist.github.com/root-cause/faf41f59f7a6d8... |
| `GET_MAX_AMMO_IN_CLIP` | `int GET_MAX_AMMO_IN_CLIP(int ped, uint weaponHash, bool p2)` | int | p2 is mostly 1 in the scripts.<br>Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v... |
| `GET_MAX_RANGE_OF_CURRENT_PED_WEAPON` | `float GET_MAX_RANGE_OF_CURRENT_PED_WEAPON(int ped)` | float | - |
| `GET_PED_AMMO_BY_TYPE` | `int GET_PED_AMMO_BY_TYPE(int ped, uint ammoTypeHash)` | int | - |
| `GET_PED_AMMO_TYPE_FROM_WEAPON` | `uint GET_PED_AMMO_TYPE_FROM_WEAPON(int ped, uint weaponHash)` | uint | Returns the current ammo type of the specified ped's specified weapon.<br>MkII magazines will change th... |
| `GET_PED_LAST_WEAPON_IMPACT_COORD` | `bool GET_PED_LAST_WEAPON_IMPACT_COORD(int ped, ref Vector3 coords)` | bool | Pass ped. Pass address of Vector3.<br>The coord will be put into the Vector3.<br>The return will determine... |
| `GET_PED_ORIGINAL_AMMO_TYPE_FROM_WEAPON` | `uint GET_PED_ORIGINAL_AMMO_TYPE_FROM_WEAPON(int ped, uint weaponHash)` | uint | Returns the base/default ammo type of the specified ped's specified weapon.<br>Use GET_PED_AMMO_TYPE_FR... |
| `GET_PED_WEAPONTYPE_IN_SLOT` | `uint GET_PED_WEAPONTYPE_IN_SLOT(int ped, uint weaponSlot)` | uint | - |
| `GET_PED_WEAPON_CAMO_INDEX` | `int GET_PED_WEAPON_CAMO_INDEX(int ped, uint weaponHash)` | int | - |
| `GET_PED_WEAPON_COMPONENT_TINT_INDEX` | `int GET_PED_WEAPON_COMPONENT_TINT_INDEX(int ped, uint weaponHash, uint camoComponentHash)` | int | Returns -1 if camoComponentHash is invalid/not attached to the weapon.<br>Full list of weapons, compone... |
| `GET_PED_WEAPON_TINT_INDEX` | `int GET_PED_WEAPON_TINT_INDEX(int ped, uint weaponHash)` | int | Full list of weapons, components & tint indexes by DurtyFree: https://github.com/DurtyFree/gta-v-dat... |
| `GET_SELECTED_PED_WEAPON` | `uint GET_SELECTED_PED_WEAPON(int ped)` | uint | Returns the hash of the weapon. <br><br>            var num7 = WEAPON::GET_SELECTED_PED_WEAPON(num4);<br>    ... |
| `GET_WEAPONTYPE_GROUP` | `uint GET_WEAPONTYPE_GROUP(uint weaponHash)` | uint | - |
| `GET_WEAPONTYPE_MODEL` | `uint GET_WEAPONTYPE_MODEL(uint weaponHash)` | uint | Returns the model of any weapon.<br><br>Can also take an ammo hash?<br>sub_6663a(&l_115B, WEAPON::GET_WEAPONT... |
| `GET_WEAPONTYPE_SLOT` | `uint GET_WEAPONTYPE_SLOT(uint weaponHash)` | uint | - |
| `GET_WEAPON_CLIP_SIZE` | `int GET_WEAPON_CLIP_SIZE(uint weaponHash)` | int | // Returns the size of the default weapon component clip.<br><br>Use it like this:<br><br>char cClipSize[32];<br>Ha... |
| `GET_WEAPON_COMPONENT_HUD_STATS` | `bool GET_WEAPON_COMPONENT_HUD_STATS(uint componentHash, ref object outData)` | bool | - |
| `GET_WEAPON_COMPONENT_TYPE_MODEL` | `uint GET_WEAPON_COMPONENT_TYPE_MODEL(uint componentHash)` | uint | - |
| `GET_WEAPON_COMPONENT_VARIANT_EXTRA_COUNT` | `int GET_WEAPON_COMPONENT_VARIANT_EXTRA_COUNT(uint componentHash)` | int | Returns the amount of extra components the specified component has.<br>Returns -1 if the component isn'... |
| `GET_WEAPON_COMPONENT_VARIANT_EXTRA_MODEL` | `uint GET_WEAPON_COMPONENT_VARIANT_EXTRA_MODEL(uint componentHash, int extraComponentIndex)` | uint | Returns the model hash of the extra component at specified index. |
| `GET_WEAPON_DAMAGE` | `float GET_WEAPON_DAMAGE(uint weaponHash, uint componentHash)` | float | This native does not return damages of weapons from the melee and explosive group.<br>Full list of weap... |
| `GET_WEAPON_DAMAGE_TYPE` | `int GET_WEAPON_DAMAGE_TYPE(uint weaponHash)` | int | enum class eDamageType<br>{<br>	UNKNOWN = 0,<br>	NONE = 1,<br>	MELEE = 2,<br>	BULLET = 3,<br>	BULLET_RUBBER = 4,<br>	EXPL... |
| `GET_WEAPON_HUD_STATS` | `bool GET_WEAPON_HUD_STATS(uint weaponHash, ref object outData)` | bool | struct WeaponHudStatsData<br>{<br>    BYTE hudDamage; // 0x0000<br>    char _0x0001[0x7]; // 0x0001<br>    BYTE ... |
| `GET_WEAPON_OBJECT_COMPONENT_TINT_INDEX` | `int GET_WEAPON_OBJECT_COMPONENT_TINT_INDEX(int weaponObject, uint camoComponentHash)` | int | Returns -1 if camoComponentHash is invalid/not attached to the weapon object.<br>Full list of weapons, ... |
| `GET_WEAPON_OBJECT_FROM_PED` | `int GET_WEAPON_OBJECT_FROM_PED(int ped, bool p1)` | int | Drops the current weapon and returns the object<br><br>Unknown behavior when unarmed. |
| `GET_WEAPON_OBJECT_TINT_INDEX` | `int GET_WEAPON_OBJECT_TINT_INDEX(int weapon)` | int | - |
| `GET_WEAPON_TIME_BETWEEN_SHOTS` | `float GET_WEAPON_TIME_BETWEEN_SHOTS(uint weaponHash)` | float | Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons... |
| `GET_WEAPON_TINT_COUNT` | `int GET_WEAPON_TINT_COUNT(uint weaponHash)` | int | Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons... |
| `GIVE_DELAYED_WEAPON_TO_PED` | `void GIVE_DELAYED_WEAPON_TO_PED(int ped, uint weaponHash, int ammoCount, bool bForceInHand)` | void | Gives a weapon to PED with a delay, example:<br><br>WEAPON::GIVE_DELAYED_WEAPON_TO_PED(PED::PLAYER_PED_ID(... |
| `GIVE_LOADOUT_TO_PED` | `void GIVE_LOADOUT_TO_PED(int ped, uint loadoutHash)` | void | Gives the specified loadout to the specified ped. <br>Loadouts are defined in common.rpf\data\ai\loadou... |
| `GIVE_WEAPON_COMPONENT_TO_PED` | `void GIVE_WEAPON_COMPONENT_TO_PED(int ped, uint weaponHash, uint componentHash)` | void | Full list of weapons & components by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/m... |
| `GIVE_WEAPON_COMPONENT_TO_WEAPON_OBJECT` | `void GIVE_WEAPON_COMPONENT_TO_WEAPON_OBJECT(int weaponObject, uint componentHash)` | void | componentHash:<br>(use WEAPON::GET_WEAPON_COMPONENT_TYPE_MODEL() to get hash value)<br>${component_at_ar_f... |
| `GIVE_WEAPON_OBJECT_TO_PED` | `void GIVE_WEAPON_OBJECT_TO_PED(int weaponObject, int ped)` | void | - |
| `GIVE_WEAPON_TO_PED` | `void GIVE_WEAPON_TO_PED(int ped, uint weaponHash, int ammoCount, bool isHidden, bool bForceInHand)` | void | Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons... |
| `HAS_ENTITY_BEEN_DAMAGED_BY_WEAPON` | `bool HAS_ENTITY_BEEN_DAMAGED_BY_WEAPON(int entity, uint weaponHash, int weaponType)` | bool | It determines what weapons caused damage:<br><br>If you want to define only a specific weapon, second para... |
| `HAS_PED_BEEN_DAMAGED_BY_WEAPON` | `bool HAS_PED_BEEN_DAMAGED_BY_WEAPON(int ped, uint weaponHash, int weaponType)` | bool | It determines what weapons caused damage:<br><br>If you want to define only a specific weapon, second para... |
| `HAS_PED_GOT_WEAPON` | `bool HAS_PED_GOT_WEAPON(int ped, uint weaponHash, bool p2)` | bool | p2 should be FALSE, otherwise it seems to always return FALSE<br><br>Bool does not check if the weapon is ... |
| `HAS_PED_GOT_WEAPON_COMPONENT` | `bool HAS_PED_GOT_WEAPON_COMPONENT(int ped, uint weaponHash, uint componentHash)` | bool | Full list of weapons & components by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/m... |
| `HAS_VEHICLE_GOT_PROJECTILE_ATTACHED` | `bool HAS_VEHICLE_GOT_PROJECTILE_ATTACHED(int driver, int vehicle, uint weaponHash, object p3)` | bool | Fourth Parameter = unsure, almost always -1 |
| `HAS_WEAPON_ASSET_LOADED` | `bool HAS_WEAPON_ASSET_LOADED(uint weaponHash)` | bool | - |
| `HAS_WEAPON_GOT_WEAPON_COMPONENT` | `bool HAS_WEAPON_GOT_WEAPON_COMPONENT(int weapon, uint componentHash)` | bool | see DOES_WEAPON_TAKE_WEAPON_COMPONENT for full list of weapons & components |
| `HIDE_PED_WEAPON_FOR_SCRIPTED_CUTSCENE` | `void HIDE_PED_WEAPON_FOR_SCRIPTED_CUTSCENE(int ped, bool toggle)` | void | Hides the players weapon during a cutscene. |
| `IS_AIR_DEFENCE_SPHERE_IN_AREA` | `bool IS_AIR_DEFENCE_SPHERE_IN_AREA(float x, float y, float z, float radius, ref int outZoneId)` | bool | - |
| `IS_FLASH_LIGHT_ON` | `bool IS_FLASH_LIGHT_ON(int ped)` | bool | - |
| `IS_PED_ARMED` | `bool IS_PED_ARMED(int ped, int typeFlags)` | bool | Checks if the ped is currently equipped with a weapon matching a bit specified using a bitwise-or in... |
| `IS_PED_CURRENT_WEAPON_SILENCED` | `bool IS_PED_CURRENT_WEAPON_SILENCED(int ped)` | bool | This native returns a true or false value.<br><br>Ped ped = The ped whose weapon you want to check. |
| `IS_PED_WEAPON_COMPONENT_ACTIVE` | `bool IS_PED_WEAPON_COMPONENT_ACTIVE(int ped, uint weaponHash, uint componentHash)` | bool | Full list of weapons & components by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/m... |
| `IS_PED_WEAPON_READY_TO_SHOOT` | `bool IS_PED_WEAPON_READY_TO_SHOOT(int ped)` | bool | - |
| `IS_WEAPON_VALID` | `bool IS_WEAPON_VALID(uint weaponHash)` | bool | Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons... |
| `MAKE_PED_RELOAD` | `bool MAKE_PED_RELOAD(int ped)` | bool | Forces a ped to reload only if they are able to; if they have a full magazine, they will not reload. |
| `REFILL_AMMO_INSTANTLY` | `bool REFILL_AMMO_INSTANTLY(int ped)` | bool | - |
| `REMOVE_AIR_DEFENCE_SPHERE` | `bool REMOVE_AIR_DEFENCE_SPHERE(int zoneId)` | bool | - |
| `REMOVE_ALL_AIR_DEFENCE_SPHERES` | `void REMOVE_ALL_AIR_DEFENCE_SPHERES()` | void | - |
| `REMOVE_ALL_PED_WEAPONS` | `void REMOVE_ALL_PED_WEAPONS(int ped, bool p1)` | void | setting the last params to false it does that same so I would suggest its not a toggle |
| `REMOVE_ALL_PROJECTILES_OF_TYPE` | `void REMOVE_ALL_PROJECTILES_OF_TYPE(uint weaponHash, bool explode)` | void | If `explode` true, then removal is done through exploding the projectile. Basically the same as EXPL... |
| `REMOVE_WEAPON_ASSET` | `void REMOVE_WEAPON_ASSET(uint weaponHash)` | void | - |
| `REMOVE_WEAPON_COMPONENT_FROM_PED` | `void REMOVE_WEAPON_COMPONENT_FROM_PED(int ped, uint weaponHash, uint componentHash)` | void | Full list of weapons & components by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/m... |
| `REMOVE_WEAPON_COMPONENT_FROM_WEAPON_OBJECT` | `void REMOVE_WEAPON_COMPONENT_FROM_WEAPON_OBJECT(int object, uint componentHash)` | void | see DOES_WEAPON_TAKE_WEAPON_COMPONENT for full list of weapons & components |
| `REMOVE_WEAPON_FROM_PED` | `void REMOVE_WEAPON_FROM_PED(int ped, uint weaponHash)` | void | This native removes a specified weapon from your selected ped.<br><br>Example:<br>C#:<br>Function.Call(Hash.REMO... |
| `REQUEST_WEAPON_ASSET` | `void REQUEST_WEAPON_ASSET(uint weaponHash, int p1, int p2)` | void | Nearly every instance of p1 I found was 31. Nearly every instance of p2 I found was 0.<br><br>REQUEST_WEAP... |
| `REQUEST_WEAPON_HIGH_DETAIL_MODEL` | `void REQUEST_WEAPON_HIGH_DETAIL_MODEL(int weaponObject)` | void | - |
| `SET_AMMO_IN_CLIP` | `bool SET_AMMO_IN_CLIP(int ped, uint weaponHash, int ammo)` | bool | Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons... |
| `SET_CAN_PED_SELECT_ALL_WEAPONS` | `void SET_CAN_PED_SELECT_ALL_WEAPONS(int ped, bool toggle)` | void | Disable all weapons. Does the same as 0xB4771B9AAF4E68E4 except for all weapons. |
| `SET_CAN_PED_SELECT_INVENTORY_WEAPON` | `void SET_CAN_PED_SELECT_INVENTORY_WEAPON(int ped, uint weaponHash, bool toggle)` | void | Disables selecting the given weapon. Ped isn't forced to put the gun away. However you can't reselec... |
| `SET_CURRENT_PED_VEHICLE_WEAPON` | `bool SET_CURRENT_PED_VEHICLE_WEAPON(int ped, uint weaponHash)` | bool | Full list of weapons by DurtyFree (Search for VEHICLE_*): https://github.com/DurtyFree/gta-v-data-du... |
| `SET_CURRENT_PED_WEAPON` | `void SET_CURRENT_PED_WEAPON(int ped, uint weaponHash, bool bForceInHand)` | void | Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons... |
| `SET_EQIPPED_WEAPON_START_SPINNING_AT_FULL_SPEED` | `void SET_EQIPPED_WEAPON_START_SPINNING_AT_FULL_SPEED(int ped)` | void | - |
| `SET_FLASH_LIGHT_ACTIVE_HISTORY` | `void SET_FLASH_LIGHT_ACTIVE_HISTORY(int ped, bool toggle)` | void | Enables/disables flashlight on ped's weapon. |
| `SET_FLASH_LIGHT_FADE_DISTANCE` | `bool SET_FLASH_LIGHT_FADE_DISTANCE(float distance)` | bool | - |
| `SET_PED_AMMO` | `void SET_PED_AMMO(int ped, uint weaponHash, int ammo, bool p3)` | void | Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons... |
| `SET_PED_AMMO_BY_TYPE` | `void SET_PED_AMMO_BY_TYPE(int ped, uint ammoTypeHash, int ammo)` | void | Ammo types: https://gist.github.com/root-cause/faf41f59f7a6d818b7db0b839bd147c1 |
| `SET_PED_AMMO_TO_DROP` | `void SET_PED_AMMO_TO_DROP(int ped, int p1)` | void | - |
| `SET_PED_CHANCE_OF_FIRING_BLANKS` | `void SET_PED_CHANCE_OF_FIRING_BLANKS(int ped, float xBias, float yBias)` | void | - |
| `SET_PED_CURRENT_WEAPON_VISIBLE` | `void SET_PED_CURRENT_WEAPON_VISIBLE(int ped, bool visible, bool deselectWeapon, bool p3, bool p4)` | void | Has 5 parameters since latest patches. |
| `SET_PED_CYCLE_VEHICLE_WEAPONS_ONLY` | `void SET_PED_CYCLE_VEHICLE_WEAPONS_ONLY(int ped)` | void | - |
| `SET_PED_DROPS_INVENTORY_WEAPON` | `void SET_PED_DROPS_INVENTORY_WEAPON(int ped, uint weaponHash, float xOffset, float yOffset, float zOffset, int ammoCount)` | void | Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons... |
| `SET_PED_DROPS_WEAPON` | `void SET_PED_DROPS_WEAPON(int ped)` | void | - |
| `SET_PED_DROPS_WEAPONS_WHEN_DEAD` | `void SET_PED_DROPS_WEAPONS_WHEN_DEAD(int ped, bool toggle)` | void | - |
| `SET_PED_GADGET` | `void SET_PED_GADGET(int ped, uint gadgetHash, bool p2)` | void | p1/gadgetHash was always 0xFBAB5776 ("GADGET_PARACHUTE").<br>p2 is always true. |
| `SET_PED_INFINITE_AMMO` | `void SET_PED_INFINITE_AMMO(int ped, bool toggle, uint weaponHash)` | void | Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons... |
| `SET_PED_INFINITE_AMMO_CLIP` | `void SET_PED_INFINITE_AMMO_CLIP(int ped, bool toggle)` | void | - |
| `SET_PED_SHOOT_ORDNANCE_WEAPON` | `int SET_PED_SHOOT_ORDNANCE_WEAPON(int ped, float p1)` | int | Returns handle of the projectile. |
| `SET_PED_STUN_GUN_FINITE_AMMO` | `void SET_PED_STUN_GUN_FINITE_AMMO(object p0, object p1)` | void | - |
| `SET_PED_WEAPON_COMPONENT_TINT_INDEX` | `void SET_PED_WEAPON_COMPONENT_TINT_INDEX(int ped, uint weaponHash, uint camoComponentHash, int colorIndex)` | void | Colors:<br>0 = Gray<br>1 = Dark Gray<br>2 = Black<br>3 = White<br>4 = Blue<br>5 = Cyan<br>6 = Aqua<br>7 = Cool Blue<br>8 = Dark... |
| `SET_PED_WEAPON_TINT_INDEX` | `void SET_PED_WEAPON_TINT_INDEX(int ped, uint weaponHash, int tintIndex)` | void | tintIndex can be the following:<br><br>0 - Normal<br>1 - Green<br>2 - Gold<br>3 - Pink<br>4 - Army<br>5 - LSPD<br>6 - Orange... |
| `SET_PICKUP_AMMO_AMOUNT_SCALER` | `void SET_PICKUP_AMMO_AMOUNT_SCALER(float p0)` | void | - |
| `SET_PLAYER_TARGETTABLE_FOR_AIR_DEFENCE_SPHERE` | `void SET_PLAYER_TARGETTABLE_FOR_AIR_DEFENCE_SPHERE(int player, int zoneId, bool enable)` | void | - |
| `SET_WEAPON_ANIMATION_OVERRIDE` | `void SET_WEAPON_ANIMATION_OVERRIDE(int ped, uint animStyle)` | void | Changes the selected ped aiming animation style. <br>Note : You must use GET_HASH_KEY!<br><br>Strings to use ... |
| `SET_WEAPON_AOE_MODIFIER` | `void SET_WEAPON_AOE_MODIFIER(uint weaponHash, float multiplier)` | void | - |
| `SET_WEAPON_DAMAGE_MODIFIER` | `void SET_WEAPON_DAMAGE_MODIFIER(uint weaponHash, float damageMultiplier)` | void | Changes the weapon damage output by the given multiplier value. Must be run every frame.<br>Full list o... |
| `SET_WEAPON_EFFECT_DURATION_MODIFIER` | `void SET_WEAPON_EFFECT_DURATION_MODIFIER(uint p0, float p1)` | void | ex, WEAPON::SET_WEAPON_EFFECT_DURATION_MODIFIER(joaat("vehicle_weapon_mine_slick"), 1.0); |
| `SET_WEAPON_OBJECT_CAMO_INDEX` | `void SET_WEAPON_OBJECT_CAMO_INDEX(int weaponObject, int p1)` | void | - |
| `SET_WEAPON_OBJECT_COMPONENT_TINT_INDEX` | `void SET_WEAPON_OBJECT_COMPONENT_TINT_INDEX(int weaponObject, uint camoComponentHash, int colorIndex)` | void | Colors:<br>0 = Gray<br>1 = Dark Gray<br>2 = Black<br>3 = White<br>4 = Blue<br>5 = Cyan<br>6 = Aqua<br>7 = Cool Blue<br>8 = Dark... |
| `SET_WEAPON_OBJECT_TINT_INDEX` | `void SET_WEAPON_OBJECT_TINT_INDEX(int weapon, int tintIndex)` | void | Full list of weapons, components & tint indexes by DurtyFree: https://github.com/DurtyFree/gta-v-dat... |
| `_GET_AMMO_IN_VEHICLE_WEAPON_CLIP` | `bool _GET_AMMO_IN_VEHICLE_WEAPON_CLIP(int vehicle, int seat, ref int ammo)` | bool | - |
| `_GET_TIME_BEFORE_VEHICLE_WEAPON_RELOAD_FINISHES` | `int _GET_TIME_BEFORE_VEHICLE_WEAPON_RELOAD_FINISHES(int vehicle, int seat)` | int | - |
| `_GET_VEHICLE_WEAPON_RELOAD_TIME` | `float _GET_VEHICLE_WEAPON_RELOAD_TIME(int vehicle, int seat)` | float | - |
| `_HAS_WEAPON_RELOADING_IN_VEHICLE` | `bool _HAS_WEAPON_RELOADING_IN_VEHICLE(int vehicle, int seat)` | bool | - |
| `_SET_AMMO_IN_VEHICLE_WEAPON_CLIP` | `bool _SET_AMMO_IN_VEHICLE_WEAPON_CLIP(int vehicle, int seat, int ammo)` | bool | - |
| `_SET_WEAPON_PED_DAMAGE_MODIFIER` | `void _SET_WEAPON_PED_DAMAGE_MODIFIER(uint weapon, float damageModifier)` | void | - |
| `_TRIGGER_VEHICLE_WEAPON_RELOAD` | `bool _TRIGGER_VEHICLE_WEAPON_RELOAD(int vehicle, int seat, int ped)` | bool | - |

---

## 详细说明

### ADD_AMMO_TO_PED

- **命名空间:** `WEAPON`
- **Hash:** `0x78F0424C34306220`
- **JHash:** `0x7F0580C7`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_AMMO_TO_PED(int ped, uint weaponHash, int ammo)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `ammo` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### ADD_PED_AMMO_BY_TYPE

- **命名空间:** `WEAPON`
- **Hash:** `0x2472622CE1F2D45F`
- **Build:** `1103`

**C# 签名:**
```csharp
void ADD_PED_AMMO_BY_TYPE(int ped, uint ammoTypeHash, int ammo)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `ammoTypeHash` | `Hash` | `uint` | - |
| `ammo` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Ammo types: https://gist.github.com/root-cause/faf41f59f7a6d818b7db0b839bd147c1
```

---

### CAN_USE_WEAPON_ON_PARACHUTE

- **命名空间:** `WEAPON`
- **Hash:** `0xBC7BE5ABC0879F74`
- **JHash:** `0x135E7AD4`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_USE_WEAPON_ON_PARACHUTE(uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
this returns if you can use the weapon while using a parachute
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### CLEAR_ENTITY_LAST_WEAPON_DAMAGE

- **命名空间:** `WEAPON`
- **Hash:** `0xAC678E40BE7C74D2`
- **JHash:** `0xCEC2732B`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_ENTITY_LAST_WEAPON_DAMAGE(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PED_LAST_WEAPON_DAMAGE

- **命名空间:** `WEAPON`
- **Hash:** `0x0E98F88A24C5F4B8`
- **JHash:** `0x52C68832`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PED_LAST_WEAPON_DAMAGE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Does NOT seem to work with HAS_PED_BEEN_DAMAGED_BY_WEAPON. Use CLEAR_ENTITY_LAST_WEAPON_DAMAGE and HAS_ENTITY_BEEN_DAMAGED_BY_WEAPON instead.
```

---

### CREATE_AIR_DEFENCE_ANGLED_AREA

- **命名空间:** `WEAPON`
- **Hash:** `0x9DA58CDBF6BDBC08`
- **Build:** `1011`

**C# 签名:**
```csharp
int CREATE_AIR_DEFENCE_ANGLED_AREA(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float radius, uint weaponHash)
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
| `p7` | `float` | `float` | - |
| `p8` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### CREATE_AIR_DEFENCE_SPHERE

- **命名空间:** `WEAPON`
- **Hash:** `0x91EF34584710BE99`
- **Build:** `573`

**C# 签名:**
```csharp
int CREATE_AIR_DEFENCE_SPHERE(float x, float y, float z, float radius, float p4, float p5, float p6, uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `p4` | `float` | `float` | - |
| `p5` | `float` | `float` | - |
| `p6` | `float` | `float` | - |
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Both coordinates are from objects in the decompiled scripts. Native related to 0xECDC202B25E5CF48 p1 value. The only weapon hash used in the decompiled scripts is weapon_air_defence_gun. These two natives are used by the yacht script, decompiled scripts suggest it and the weapon hash used (valkyrie's rockets) are also used by yachts.
```

---

### CREATE_WEAPON_OBJECT

- **命名空间:** `WEAPON`
- **Hash:** `0x9541D3CF0D398F36`
- **JHash:** `0x62F5987F`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_WEAPON_OBJECT(uint weaponHash, int ammoCount, float x, float y, float z, bool showWorldModel, float scale, object p7, object p8, object p9)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |
| `ammoCount` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `showWorldModel` | `BOOL` | `bool` | - |
| `scale` | `float` | `float` | - |
| `p7` | `Any` | `object` | - |
| `p8` | `Any` | `object` | - |
| `p9` | `Any` | `object` | - |

**返回值:** `int` (Native: `Object`)

**说明:**
```
Now has 8 params.
```

---

### DOES_AIR_DEFENCE_SPHERE_EXIST

- **命名空间:** `WEAPON`
- **Hash:** `0xCD79A550999D7D4F`
- **Build:** `678`

**C# 签名:**
```csharp
bool DOES_AIR_DEFENCE_SPHERE_EXIST(int zoneId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `zoneId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DOES_WEAPON_TAKE_WEAPON_COMPONENT

- **命名空间:** `WEAPON`
- **Hash:** `0x5CEE3DF569CECAB0`
- **JHash:** `0xB1817BAA`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_WEAPON_TAKE_WEAPON_COMPONENT(uint weaponHash, uint componentHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |
| `componentHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of weapons & components by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### ENABLE_LASER_SIGHT_RENDERING

- **命名空间:** `WEAPON`
- **Hash:** `0xC8B46D7727D864AA`
- **JHash:** `0xE3438955`
- **Build:** `323`

**C# 签名:**
```csharp
void ENABLE_LASER_SIGHT_RENDERING(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Enables laser sight on any weapon.

It doesn't work. Neither on tick nor OnKeyDown
```

---

### EXPLODE_PROJECTILES

- **命名空间:** `WEAPON`
- **Hash:** `0xFC4BD125DE7611E4`
- **JHash:** `0x35A0B955`
- **Build:** `323`

**C# 签名:**
```csharp
void EXPLODE_PROJECTILES(int ped, uint weaponHash, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
             WEAPON::EXPLODE_PROJECTILES(PLAYER::PLAYER_PED_ID(), func_221(0x00000003), 0x00000001);
```

---

### FIRE_AIR_DEFENCE_SPHERE_WEAPON_AT_POSITION

- **命名空间:** `WEAPON`
- **Hash:** `0x44F1012B69313374`
- **Build:** `573`

**C# 签名:**
```csharp
void FIRE_AIR_DEFENCE_SPHERE_WEAPON_AT_POSITION(int zoneId, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `zoneId` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### GET_AMMO_IN_CLIP

- **命名空间:** `WEAPON`
- **Hash:** `0x2E1202248937775C`
- **JHash:** `0x73C100C3`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_AMMO_IN_CLIP(int ped, uint weaponHash, ref int ammo)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `ammo` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### GET_AMMO_IN_PED_WEAPON

- **命名空间:** `WEAPON`
- **Hash:** `0x015A522136D7F951`
- **JHash:** `0x0C755733`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_AMMO_IN_PED_WEAPON(int ped, uint weaponhash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponhash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
WEAPON::GET_AMMO_IN_PED_WEAPON(PLAYER::PLAYER_PED_ID(), a_0)

From decompiled scripts
Returns total ammo in weapon

GTALua Example :
natives.WEAPON.GET_AMMO_IN_PED_WEAPON(plyPed, WeaponHash)
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### GET_BEST_PED_WEAPON

- **命名空间:** `WEAPON`
- **Hash:** `0x8483E98E8B888AE2`
- **JHash:** `0xB998D444`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_BEST_PED_WEAPON(int ped, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `uint` (Native: `Hash`)

**说明:**
```
p1 is always 0 in the scripts.
```

---

### GET_CURRENT_PED_VEHICLE_WEAPON

- **命名空间:** `WEAPON`
- **Hash:** `0x1017582BCD3832DC`
- **JHash:** `0xF26C5D65`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_CURRENT_PED_VEHICLE_WEAPON(int ped, Hash* weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash*` | `Hash*` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Example in VB

    Public Shared Function GetVehicleCurrentWeapon(Ped As Ped) As Integer
        Dim arg As New OutputArgument()
        Native.Function.Call(Hash.GET_CURRENT_PED_VEHICLE_WEAPON, Ped, arg)
        Return arg.GetResult(Of Integer)()
    End Function

Usage:
If GetVehicleCurrentWeapon(Game.Player.Character) = -821520672 Then ...Do something
Note: -821520672 = VEHICLE_WEAPON_PLANE_ROCKET
```

---

### GET_CURRENT_PED_WEAPON

- **命名空间:** `WEAPON`
- **Hash:** `0x3A87E44BB9A01D54`
- **JHash:** `0xB0237302`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_CURRENT_PED_WEAPON(int ped, Hash* weaponHash, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash*` | `Hash*` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
The return value seems to indicate returns true if the hash of the weapon object weapon equals the weapon hash.
p2 seems to be 1 most of the time.





p2 is not implemented

disassembly said that?

```

---

### GET_CURRENT_PED_WEAPON_ENTITY_INDEX

- **命名空间:** `WEAPON`
- **Hash:** `0x3B390A939AF0B5FC`
- **JHash:** `0x5D73CD20`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_CURRENT_PED_WEAPON_ENTITY_INDEX(int ped, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `int` (Native: `Entity`)

---

### GET_IS_PED_GADGET_EQUIPPED

- **命名空间:** `WEAPON`
- **Hash:** `0xF731332072F5156C`
- **JHash:** `0x8DDD0B5B`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_IS_PED_GADGET_EQUIPPED(int ped, uint gadgetHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `gadgetHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
gadgetHash - was always 0xFBAB5776 ("GADGET_PARACHUTE").
```

---

### GET_LOCKON_DISTANCE_OF_CURRENT_PED_WEAPON

- **命名空间:** `WEAPON`
- **Hash:** `0x840F03E9041E2C9C`
- **JHash:** `0x3612110D`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_LOCKON_DISTANCE_OF_CURRENT_PED_WEAPON(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_MAX_AMMO

- **命名空间:** `WEAPON`
- **Hash:** `0xDC16122C7A20C933`
- **JHash:** `0x0B294796`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_MAX_AMMO(int ped, uint weaponHash, ref int ammo)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `ammo` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### GET_MAX_AMMO_BY_TYPE

- **命名空间:** `WEAPON`
- **Hash:** `0x585847C5E4E11709`
- **Build:** `1103`

**C# 签名:**
```csharp
bool GET_MAX_AMMO_BY_TYPE(int ped, uint ammoTypeHash, ref int ammo)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `ammoTypeHash` | `Hash` | `uint` | - |
| `ammo` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns the max ammo for an ammo type. Ammo types: https://gist.github.com/root-cause/faf41f59f7a6d818b7db0b839bd147c1
```

---

### GET_MAX_AMMO_IN_CLIP

- **命名空间:** `WEAPON`
- **Hash:** `0xA38DCFFCEA8962FA`
- **JHash:** `0x6961E2A4`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_MAX_AMMO_IN_CLIP(int ped, uint weaponHash, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
p2 is mostly 1 in the scripts.
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### GET_MAX_RANGE_OF_CURRENT_PED_WEAPON

- **命名空间:** `WEAPON`
- **Hash:** `0x814C9D19DFD69679`
- **JHash:** `0xB2B2BBAA`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_MAX_RANGE_OF_CURRENT_PED_WEAPON(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_PED_AMMO_BY_TYPE

- **命名空间:** `WEAPON`
- **Hash:** `0x39D22031557946C1`
- **JHash:** `0x54077C4D`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_AMMO_BY_TYPE(int ped, uint ammoTypeHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `ammoTypeHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

---

### GET_PED_AMMO_TYPE_FROM_WEAPON

- **命名空间:** `WEAPON`
- **Hash:** `0x7FEAD38B326B9F74`
- **JHash:** `0x09337863`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_PED_AMMO_TYPE_FROM_WEAPON(int ped, uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `uint` (Native: `Hash`)

**说明:**
```
Returns the current ammo type of the specified ped's specified weapon.
MkII magazines will change the return value, like Pistol MkII returning AMMO_PISTOL without any components and returning AMMO_PISTOL_TRACER after Tracer Rounds component is attached.
Use 0xF489B44DD5AF4BD9 if you always want AMMO_PISTOL.
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### GET_PED_LAST_WEAPON_IMPACT_COORD

- **命名空间:** `WEAPON`
- **Hash:** `0x6C4D0409BA1A2BC2`
- **JHash:** `0x9B266079`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_PED_LAST_WEAPON_IMPACT_COORD(int ped, ref Vector3 coords)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `coords` | `Vector3*` | `ref Vector3` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Pass ped. Pass address of Vector3.
The coord will be put into the Vector3.
The return will determine whether there was a coord found or not.
```

---

### GET_PED_ORIGINAL_AMMO_TYPE_FROM_WEAPON

- **命名空间:** `WEAPON`
- **Hash:** `0xF489B44DD5AF4BD9`
- **Build:** `1103`

**C# 签名:**
```csharp
uint GET_PED_ORIGINAL_AMMO_TYPE_FROM_WEAPON(int ped, uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `uint` (Native: `Hash`)

**说明:**
```
Returns the base/default ammo type of the specified ped's specified weapon.
Use GET_PED_AMMO_TYPE_FROM_WEAPON if you want current ammo type (like AMMO_MG_INCENDIARY/AMMO_MG_TRACER while using MkII magazines) and use this if you want base ammo type. (AMMO_MG)
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### GET_PED_WEAPONTYPE_IN_SLOT

- **命名空间:** `WEAPON`
- **Hash:** `0xEFFED78E9011134D`
- **JHash:** `0x9BC64E16`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_PED_WEAPONTYPE_IN_SLOT(int ped, uint weaponSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponSlot` | `Hash` | `uint` | - |

**返回值:** `uint` (Native: `Hash`)

---

### GET_PED_WEAPON_CAMO_INDEX

- **命名空间:** `WEAPON`
- **Hash:** `0xA2C9AC24B4061285`
- **Build:** `1103`

**C# 签名:**
```csharp
int GET_PED_WEAPON_CAMO_INDEX(int ped, uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

---

### GET_PED_WEAPON_COMPONENT_TINT_INDEX

- **命名空间:** `WEAPON`
- **Hash:** `0xF0A60040BE558F2D`
- **Build:** `1103`

**C# 签名:**
```csharp
int GET_PED_WEAPON_COMPONENT_TINT_INDEX(int ped, uint weaponHash, uint camoComponentHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `camoComponentHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns -1 if camoComponentHash is invalid/not attached to the weapon.
Full list of weapons, components, tint indexes & weapon liveries by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### GET_PED_WEAPON_TINT_INDEX

- **命名空间:** `WEAPON`
- **Hash:** `0x2B9EEDC07BD06B9F`
- **JHash:** `0x3F9C90A7`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PED_WEAPON_TINT_INDEX(int ped, uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Full list of weapons, components & tint indexes by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### GET_SELECTED_PED_WEAPON

- **命名空间:** `WEAPON`
- **Hash:** `0x0A6DB4965674D243`
- **JHash:** `0xD240123E`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_SELECTED_PED_WEAPON(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `uint` (Native: `Hash`)

**说明:**
```
Returns the hash of the weapon. 

            var num7 = WEAPON::GET_SELECTED_PED_WEAPON(num4);
            sub_27D3(num7);
            switch (num7)
            {
                case 0x24B17070:

Also see WEAPON::GET_CURRENT_PED_WEAPON. Difference?

-------------------------------------------------------------------------

The difference is that GET_SELECTED_PED_WEAPON simply returns the ped's current weapon hash but GET_CURRENT_PED_WEAPON also checks the weapon object and returns true if the hash of the weapon object equals the weapon hash
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### GET_WEAPONTYPE_GROUP

- **命名空间:** `WEAPON`
- **Hash:** `0xC3287EE3050FB74C`
- **JHash:** `0x5F2DE833`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_WEAPONTYPE_GROUP(uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `uint` (Native: `Hash`)

---

### GET_WEAPONTYPE_MODEL

- **命名空间:** `WEAPON`
- **Hash:** `0xF46CDC33180FDA94`
- **JHash:** `0x44E1C269`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_WEAPONTYPE_MODEL(uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `uint` (Native: `Hash`)

**说明:**
```
Returns the model of any weapon.

Can also take an ammo hash?
sub_6663a(&l_115B, WEAPON::GET_WEAPONTYPE_MODEL(${ammo_rpg}));
```

---

### GET_WEAPONTYPE_SLOT

- **命名空间:** `WEAPON`
- **Hash:** `0x4215460B9B8B7FA0`
- **JHash:** `0x2E3759AF`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_WEAPONTYPE_SLOT(uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `uint` (Native: `Hash`)

---

### GET_WEAPON_CLIP_SIZE

- **命名空间:** `WEAPON`
- **Hash:** `0x583BE370B1EC6EB4`
- **JHash:** `0x8D515E66`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_WEAPON_CLIP_SIZE(uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
// Returns the size of the default weapon component clip.

Use it like this:

char cClipSize[32];
Hash cur;
if (WEAPON::GET_CURRENT_PED_WEAPON(playerPed, &cur, 1))
{
    if (WEAPON::IS_WEAPON_VALID(cur))
    {
        int iClipSize = WEAPON::GET_WEAPON_CLIP_SIZE(cur);
        sprintf_s(cClipSize, "ClipSize: %.d", iClipSize);
        vDrawString(cClipSize, 0.5f, 0.5f);
    }
}
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### GET_WEAPON_COMPONENT_HUD_STATS

- **命名空间:** `WEAPON`
- **Hash:** `0xB3CAF387AE12E9F8`
- **JHash:** `0xBB5498F4`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_WEAPON_COMPONENT_HUD_STATS(uint componentHash, ref object outData)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `componentHash` | `Hash` | `uint` | - |
| `outData` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_WEAPON_COMPONENT_TYPE_MODEL

- **命名空间:** `WEAPON`
- **Hash:** `0x0DB57B41EC1DB083`
- **JHash:** `0x324FA47A`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_WEAPON_COMPONENT_TYPE_MODEL(uint componentHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `componentHash` | `Hash` | `uint` | - |

**返回值:** `uint` (Native: `Hash`)

---

### GET_WEAPON_COMPONENT_VARIANT_EXTRA_COUNT

- **命名空间:** `WEAPON`
- **Hash:** `0x6558AC7C17BFEF58`
- **Build:** `372`

**C# 签名:**
```csharp
int GET_WEAPON_COMPONENT_VARIANT_EXTRA_COUNT(uint componentHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `componentHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns the amount of extra components the specified component has.
Returns -1 if the component isn't of type CWeaponComponentVariantModel.
```

---

### GET_WEAPON_COMPONENT_VARIANT_EXTRA_MODEL

- **命名空间:** `WEAPON`
- **Hash:** `0x4D1CB8DC40208A17`
- **Build:** `372`

**C# 签名:**
```csharp
uint GET_WEAPON_COMPONENT_VARIANT_EXTRA_MODEL(uint componentHash, int extraComponentIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `componentHash` | `Hash` | `uint` | - |
| `extraComponentIndex` | `int` | `int` | - |

**返回值:** `uint` (Native: `Hash`)

**说明:**
```
Returns the model hash of the extra component at specified index.
```

---

### GET_WEAPON_DAMAGE

- **命名空间:** `WEAPON`
- **Hash:** `0x3133B907D8B32053`
- **JHash:** `0xE81649C0`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_WEAPON_DAMAGE(uint weaponHash, uint componentHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |
| `componentHash` | `Hash` | `uint` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
This native does not return damages of weapons from the melee and explosive group.
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### GET_WEAPON_DAMAGE_TYPE

- **命名空间:** `WEAPON`
- **Hash:** `0x3BE0BB12D25FB305`
- **JHash:** `0x013AFC13`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_WEAPON_DAMAGE_TYPE(uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
enum class eDamageType
{
	UNKNOWN = 0,
	NONE = 1,
	MELEE = 2,
	BULLET = 3,
	BULLET_RUBBER = 4,
	EXPLOSIVE = 5,
	FIRE = 6,
	COLLISION = 7,
	FALL = 8,
	DROWN = 9,
	ELECTRIC = 10,
	BARBED_WIRE = 11,
	FIRE_EXTINGUISHER = 12,
	SMOKE = 13,
	WATER_CANNON = 14,
	TRANQUILIZER = 15,
};

Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### GET_WEAPON_HUD_STATS

- **命名空间:** `WEAPON`
- **Hash:** `0xD92C739EE34C9EBA`
- **JHash:** `0xA9AD3D98`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_WEAPON_HUD_STATS(uint weaponHash, ref object outData)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |
| `outData` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
struct WeaponHudStatsData
{
    BYTE hudDamage; // 0x0000
    char _0x0001[0x7]; // 0x0001
    BYTE hudSpeed; // 0x0008
    char _0x0009[0x7]; // 0x0009
    BYTE hudCapacity; // 0x0010
    char _0x0011[0x7]; // 0x0011
    BYTE hudAccuracy; // 0x0018
    char _0x0019[0x7]; // 0x0019
    BYTE hudRange; // 0x0020
};

Usage:

WeaponHudStatsData data;
if (GET_WEAPON_HUD_STATS(weaponHash, (int *)&data))
{
    // BYTE damagePercentage = data.hudDamage and so on
}
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### GET_WEAPON_OBJECT_COMPONENT_TINT_INDEX

- **命名空间:** `WEAPON`
- **Hash:** `0xB3EA4FEABF41464B`
- **Build:** `1103`

**C# 签名:**
```csharp
int GET_WEAPON_OBJECT_COMPONENT_TINT_INDEX(int weaponObject, uint camoComponentHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponObject` | `Object` | `int` | - |
| `camoComponentHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns -1 if camoComponentHash is invalid/not attached to the weapon object.
Full list of weapons, components, tint indexes & weapon liveries by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### GET_WEAPON_OBJECT_FROM_PED

- **命名空间:** `WEAPON`
- **Hash:** `0xCAE1DC9A0E22A16D`
- **JHash:** `0xDF939A38`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_WEAPON_OBJECT_FROM_PED(int ped, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `Object`)

**说明:**
```
Drops the current weapon and returns the object

Unknown behavior when unarmed.
```

---

### GET_WEAPON_OBJECT_TINT_INDEX

- **命名空间:** `WEAPON`
- **Hash:** `0xCD183314F7CD2E57`
- **JHash:** `0xD91D9576`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_WEAPON_OBJECT_TINT_INDEX(int weapon)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weapon` | `Object` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_WEAPON_TIME_BETWEEN_SHOTS

- **命名空间:** `WEAPON`
- **Hash:** `0x065D2AACAD8CF7A4`
- **Build:** `1290`

**C# 签名:**
```csharp
float GET_WEAPON_TIME_BETWEEN_SHOTS(uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### GET_WEAPON_TINT_COUNT

- **命名空间:** `WEAPON`
- **Hash:** `0x5DCF6C5CAB2E9BF7`
- **JHash:** `0x99E4EAAB`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_WEAPON_TINT_COUNT(uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### GIVE_DELAYED_WEAPON_TO_PED

- **命名空间:** `WEAPON`
- **Hash:** `0xB282DC6EBD803C75`
- **JHash:** `0x5868D20D`
- **Build:** `323`

**C# 签名:**
```csharp
void GIVE_DELAYED_WEAPON_TO_PED(int ped, uint weaponHash, int ammoCount, bool bForceInHand)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `ammoCount` | `int` | `int` | - |
| `bForceInHand` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Gives a weapon to PED with a delay, example:

WEAPON::GIVE_DELAYED_WEAPON_TO_PED(PED::PLAYER_PED_ID(), MISC::GET_HASH_KEY("WEAPON_PISTOL"), 1000, false)
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### GIVE_LOADOUT_TO_PED

- **命名空间:** `WEAPON`
- **Hash:** `0x68F8BE6AF5CDF8A6`
- **Build:** `505`

**C# 签名:**
```csharp
void GIVE_LOADOUT_TO_PED(int ped, uint loadoutHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `loadoutHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Gives the specified loadout to the specified ped. 
Loadouts are defined in common.rpf\data\ai\loadouts.meta
```

---

### GIVE_WEAPON_COMPONENT_TO_PED

- **命名空间:** `WEAPON`
- **Hash:** `0xD966D51AA5B28BB9`
- **JHash:** `0x3E1E286D`
- **Build:** `323`

**C# 签名:**
```csharp
void GIVE_WEAPON_COMPONENT_TO_PED(int ped, uint weaponHash, uint componentHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `componentHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of weapons & components by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### GIVE_WEAPON_COMPONENT_TO_WEAPON_OBJECT

- **命名空间:** `WEAPON`
- **Hash:** `0x33E179436C0B31DB`
- **JHash:** `0xF7612A37`
- **Build:** `323`

**C# 签名:**
```csharp
void GIVE_WEAPON_COMPONENT_TO_WEAPON_OBJECT(int weaponObject, uint componentHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponObject` | `Object` | `int` | - |
| `componentHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
componentHash:
(use WEAPON::GET_WEAPON_COMPONENT_TYPE_MODEL() to get hash value)
${component_at_ar_flsh}, ${component_at_ar_supp}, ${component_at_pi_flsh}, ${component_at_scope_large}, ${component_at_ar_supp_02}
```

---

### GIVE_WEAPON_OBJECT_TO_PED

- **命名空间:** `WEAPON`
- **Hash:** `0xB1FA61371AF7C4B7`
- **JHash:** `0x639AF3EF`
- **Build:** `323`

**C# 签名:**
```csharp
void GIVE_WEAPON_OBJECT_TO_PED(int weaponObject, int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponObject` | `Object` | `int` | - |
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### GIVE_WEAPON_TO_PED

- **命名空间:** `WEAPON`
- **Hash:** `0xBF0FD6E56C964FCB`
- **JHash:** `0xC4D88A85`
- **Build:** `323`

**C# 签名:**
```csharp
void GIVE_WEAPON_TO_PED(int ped, uint weaponHash, int ammoCount, bool isHidden, bool bForceInHand)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `ammoCount` | `int` | `int` | - |
| `isHidden` | `BOOL` | `bool` | - |
| `bForceInHand` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### HAS_ENTITY_BEEN_DAMAGED_BY_WEAPON

- **命名空间:** `WEAPON`
- **Hash:** `0x131D401334815E94`
- **JHash:** `0x6DAABB39`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_ENTITY_BEEN_DAMAGED_BY_WEAPON(int entity, uint weaponHash, int weaponType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `weaponType` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
It determines what weapons caused damage:

If you want to define only a specific weapon, second parameter=weapon hash code, third parameter=0
If you want to define any melee weapon, second parameter=0, third parameter=1.
If you want to identify any weapon (firearms, melee, rockets, etc.), second parameter=0, third parameter=2.
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### HAS_PED_BEEN_DAMAGED_BY_WEAPON

- **命名空间:** `WEAPON`
- **Hash:** `0x2D343D2219CD027A`
- **JHash:** `0xCDFBBCC6`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_PED_BEEN_DAMAGED_BY_WEAPON(int ped, uint weaponHash, int weaponType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `weaponType` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
It determines what weapons caused damage:

If you want to define only a specific weapon, second parameter=weapon hash code, third parameter=0
If you want to define any melee weapon, second parameter=0, third parameter=1.
If you want to identify any weapon (firearms, melee, rockets, etc.), second parameter=0, third parameter=2.
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### HAS_PED_GOT_WEAPON

- **命名空间:** `WEAPON`
- **Hash:** `0x8DECB02F88F428BC`
- **JHash:** `0x43D2FA82`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_PED_GOT_WEAPON(int ped, uint weaponHash, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p2 should be FALSE, otherwise it seems to always return FALSE

Bool does not check if the weapon is current equipped, unfortunately.
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### HAS_PED_GOT_WEAPON_COMPONENT

- **命名空间:** `WEAPON`
- **Hash:** `0xC593212475FAE340`
- **JHash:** `0xDC0FC145`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_PED_GOT_WEAPON_COMPONENT(int ped, uint weaponHash, uint componentHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `componentHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of weapons & components by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### HAS_VEHICLE_GOT_PROJECTILE_ATTACHED

- **命名空间:** `WEAPON`
- **Hash:** `0x717C8481234E3B88`
- **JHash:** `0xA57E2E80`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_VEHICLE_GOT_PROJECTILE_ATTACHED(int driver, int vehicle, uint weaponHash, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `driver` | `Ped` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Fourth Parameter = unsure, almost always -1
```

---

### HAS_WEAPON_ASSET_LOADED

- **命名空间:** `WEAPON`
- **Hash:** `0x36E353271F0E90EE`
- **JHash:** `0x1891D5BB`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_WEAPON_ASSET_LOADED(uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_WEAPON_GOT_WEAPON_COMPONENT

- **命名空间:** `WEAPON`
- **Hash:** `0x76A18844E743BF91`
- **JHash:** `0x1D368510`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_WEAPON_GOT_WEAPON_COMPONENT(int weapon, uint componentHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weapon` | `Object` | `int` | - |
| `componentHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
see DOES_WEAPON_TAKE_WEAPON_COMPONENT for full list of weapons & components
```

---

### HIDE_PED_WEAPON_FOR_SCRIPTED_CUTSCENE

- **命名空间:** `WEAPON`
- **Hash:** `0x6F6981D2253C208F`
- **JHash:** `0x00CFD6E9`
- **Build:** `323`

**C# 签名:**
```csharp
void HIDE_PED_WEAPON_FOR_SCRIPTED_CUTSCENE(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Hides the players weapon during a cutscene.
```

---

### IS_AIR_DEFENCE_SPHERE_IN_AREA

- **命名空间:** `WEAPON`
- **Hash:** `0xDAB963831DBFD3F4`
- **Build:** `1103`

**C# 签名:**
```csharp
bool IS_AIR_DEFENCE_SPHERE_IN_AREA(float x, float y, float z, float radius, ref int outZoneId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `outZoneId` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_FLASH_LIGHT_ON

- **命名空间:** `WEAPON`
- **Hash:** `0x4B7620C47217126C`
- **JHash:** `0x76876154`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_FLASH_LIGHT_ON(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_ARMED

- **命名空间:** `WEAPON`
- **Hash:** `0x475768A975D5AD17`
- **JHash:** `0x0BFC892C`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_ARMED(int ped, int typeFlags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `typeFlags` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Checks if the ped is currently equipped with a weapon matching a bit specified using a bitwise-or in typeFlags.

Type flag bit values:
1 = Melee weapons
2 = Explosive weapons
4 = Any other weapons

Not specifying any bit will lead to the native *always* returning 'false', and for example specifying '4 | 2' will check for any weapon except fists and melee weapons.
7 returns true if you are equipped with any weapon except your fists.
6 returns true if you are equipped with any weapon except melee weapons.
5 returns true if you are equipped with any weapon except the Explosives weapon group.
4 returns true if you are equipped with any weapon except Explosives weapon group AND melee weapons.
3 returns true if you are equipped with either Explosives or Melee weapons (the exact opposite of 4).
2 returns true only if you are equipped with any weapon from the Explosives weapon group.
1 returns true only if you are equipped with any Melee weapon.
0 never returns true.

Note: When I say "Explosives weapon group", it does not include the Jerry can and Fire Extinguisher.
```

---

### IS_PED_CURRENT_WEAPON_SILENCED

- **命名空间:** `WEAPON`
- **Hash:** `0x65F0C5AE05943EC7`
- **JHash:** `0xBAF7BFBE`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_CURRENT_WEAPON_SILENCED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
This native returns a true or false value.

Ped ped = The ped whose weapon you want to check.
```

---

### IS_PED_WEAPON_COMPONENT_ACTIVE

- **命名空间:** `WEAPON`
- **Hash:** `0x0D78DE0572D3969E`
- **JHash:** `0x7565FB19`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_WEAPON_COMPONENT_ACTIVE(int ped, uint weaponHash, uint componentHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `componentHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of weapons & components by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### IS_PED_WEAPON_READY_TO_SHOOT

- **命名空间:** `WEAPON`
- **Hash:** `0xB80CA294F2F26749`
- **JHash:** `0x02A32CB0`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_WEAPON_READY_TO_SHOOT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_WEAPON_VALID

- **命名空间:** `WEAPON`
- **Hash:** `0x937C71165CF334B3`
- **JHash:** `0x38CA2954`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_WEAPON_VALID(uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### MAKE_PED_RELOAD

- **命名空间:** `WEAPON`
- **Hash:** `0x20AE33F3AC9C0033`
- **JHash:** `0x515292C2`
- **Build:** `323`

**C# 签名:**
```csharp
bool MAKE_PED_RELOAD(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Forces a ped to reload only if they are able to; if they have a full magazine, they will not reload.
```

---

### REFILL_AMMO_INSTANTLY

- **命名空间:** `WEAPON`
- **Hash:** `0x8C0D57EA686FAD87`
- **JHash:** `0x82EEAF0F`
- **Build:** `323`

**C# 签名:**
```csharp
bool REFILL_AMMO_INSTANTLY(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### REMOVE_AIR_DEFENCE_SPHERE

- **命名空间:** `WEAPON`
- **Hash:** `0x0ABF535877897560`
- **Build:** `573`

**C# 签名:**
```csharp
bool REMOVE_AIR_DEFENCE_SPHERE(int zoneId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `zoneId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### REMOVE_ALL_AIR_DEFENCE_SPHERES

- **命名空间:** `WEAPON`
- **Hash:** `0x1E45B34ADEBEE48E`
- **Build:** `573`

**C# 签名:**
```csharp
void REMOVE_ALL_AIR_DEFENCE_SPHERES()
```

**返回值:** `void` (Native: `void`)

---

### REMOVE_ALL_PED_WEAPONS

- **命名空间:** `WEAPON`
- **Hash:** `0xF25DF915FA38C5F3`
- **JHash:** `0xA44CE817`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_ALL_PED_WEAPONS(int ped, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
setting the last params to false it does that same so I would suggest its not a toggle
```

---

### REMOVE_ALL_PROJECTILES_OF_TYPE

- **命名空间:** `WEAPON`
- **Hash:** `0xFC52E0F37E446528`
- **JHash:** `0xA5F89919`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_ALL_PROJECTILES_OF_TYPE(uint weaponHash, bool explode)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |
| `explode` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
If `explode` true, then removal is done through exploding the projectile. Basically the same as EXPLODE_PROJECTILES but without defining the owner ped.
```

---

### REMOVE_WEAPON_ASSET

- **命名空间:** `WEAPON`
- **Hash:** `0xAA08EF13F341C8FC`
- **JHash:** `0x2C0DFE3C`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_WEAPON_ASSET(uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_WEAPON_COMPONENT_FROM_PED

- **命名空间:** `WEAPON`
- **Hash:** `0x1E8BE90C74FB4C09`
- **JHash:** `0x412AA00D`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_WEAPON_COMPONENT_FROM_PED(int ped, uint weaponHash, uint componentHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `componentHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of weapons & components by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### REMOVE_WEAPON_COMPONENT_FROM_WEAPON_OBJECT

- **命名空间:** `WEAPON`
- **Hash:** `0xF7D82B0D66777611`
- **JHash:** `0xA6E7ED3C`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_WEAPON_COMPONENT_FROM_WEAPON_OBJECT(int object, uint componentHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `componentHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
see DOES_WEAPON_TAKE_WEAPON_COMPONENT for full list of weapons & components
```

---

### REMOVE_WEAPON_FROM_PED

- **命名空间:** `WEAPON`
- **Hash:** `0x4899CB088EDF59B8`
- **JHash:** `0x9C37F220`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_WEAPON_FROM_PED(int ped, uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native removes a specified weapon from your selected ped.

Example:
C#:
Function.Call(Hash.REMOVE_WEAPON_FROM_PED, Game.Player.Character, 0x99B507EA);

C++:
WEAPON::REMOVE_WEAPON_FROM_PED(PLAYER::PLAYER_PED_ID(), 0x99B507EA);

The code above removes the knife from the player.
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### REQUEST_WEAPON_ASSET

- **命名空间:** `WEAPON`
- **Hash:** `0x5443438F033E29C3`
- **JHash:** `0x65D139A5`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_WEAPON_ASSET(uint weaponHash, int p1, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |
| `p1` | `int` | `int` | - |
| `p2` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Nearly every instance of p1 I found was 31. Nearly every instance of p2 I found was 0.

REQUEST_WEAPON_ASSET(iLocal_1888, 31, 26);
```

---

### REQUEST_WEAPON_HIGH_DETAIL_MODEL

- **命名空间:** `WEAPON`
- **Hash:** `0x48164DBB970AC3F0`
- **JHash:** `0xE3BD00F9`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_WEAPON_HIGH_DETAIL_MODEL(int weaponObject)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponObject` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_AMMO_IN_CLIP

- **命名空间:** `WEAPON`
- **Hash:** `0xDCD2A934D65CB497`
- **JHash:** `0xA54B0B10`
- **Build:** `323`

**C# 签名:**
```csharp
bool SET_AMMO_IN_CLIP(int ped, uint weaponHash, int ammo)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `ammo` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### SET_CAN_PED_SELECT_ALL_WEAPONS

- **命名空间:** `WEAPON`
- **Hash:** `0xEFF296097FF1E509`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_CAN_PED_SELECT_ALL_WEAPONS(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Disable all weapons. Does the same as 0xB4771B9AAF4E68E4 except for all weapons.
```

---

### SET_CAN_PED_SELECT_INVENTORY_WEAPON

- **命名空间:** `WEAPON`
- **Hash:** `0xB4771B9AAF4E68E4`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_CAN_PED_SELECT_INVENTORY_WEAPON(int ped, uint weaponHash, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Disables selecting the given weapon. Ped isn't forced to put the gun away. However you can't reselect the weapon if you holster then unholster. Weapon is also grayed out on the weapon wheel.
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### SET_CURRENT_PED_VEHICLE_WEAPON

- **命名空间:** `WEAPON`
- **Hash:** `0x75C55983C2C39DAA`
- **JHash:** `0x8E6F2AF1`
- **Build:** `323`

**C# 签名:**
```csharp
bool SET_CURRENT_PED_VEHICLE_WEAPON(int ped, uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of weapons by DurtyFree (Search for VEHICLE_*): https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### SET_CURRENT_PED_WEAPON

- **命名空间:** `WEAPON`
- **Hash:** `0xADF692B254977C0C`
- **JHash:** `0xB8278882`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CURRENT_PED_WEAPON(int ped, uint weaponHash, bool bForceInHand)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `bForceInHand` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### SET_EQIPPED_WEAPON_START_SPINNING_AT_FULL_SPEED

- **命名空间:** `WEAPON`
- **Hash:** `0xE4DCEC7FD5B739A5`
- **JHash:** `0x64646F1D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_EQIPPED_WEAPON_START_SPINNING_AT_FULL_SPEED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FLASH_LIGHT_ACTIVE_HISTORY

- **命名空间:** `WEAPON`
- **Hash:** `0x988DB6FE9B3AC000`
- **Build:** `2060`

**C# 签名:**
```csharp
void SET_FLASH_LIGHT_ACTIVE_HISTORY(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Enables/disables flashlight on ped's weapon.
```

---

### SET_FLASH_LIGHT_FADE_DISTANCE

- **命名空间:** `WEAPON`
- **Hash:** `0xCEA66DAD478CD39B`
- **JHash:** `0xB0127EA7`
- **Build:** `323`

**C# 签名:**
```csharp
bool SET_FLASH_LIGHT_FADE_DISTANCE(float distance)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `distance` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### SET_PED_AMMO

- **命名空间:** `WEAPON`
- **Hash:** `0x14E56BC5B5DB6A19`
- **JHash:** `0xBF90DF1A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_AMMO(int ped, uint weaponHash, int ammo, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `ammo` | `int` | `int` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### SET_PED_AMMO_BY_TYPE

- **命名空间:** `WEAPON`
- **Hash:** `0x5FD1E1F011E76D7E`
- **JHash:** `0x311C52BB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_AMMO_BY_TYPE(int ped, uint ammoTypeHash, int ammo)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `ammoTypeHash` | `Hash` | `uint` | - |
| `ammo` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Ammo types: https://gist.github.com/root-cause/faf41f59f7a6d818b7db0b839bd147c1
```

---

### SET_PED_AMMO_TO_DROP

- **命名空间:** `WEAPON`
- **Hash:** `0xA4EFEF9440A5B0EF`
- **JHash:** `0x2386A307`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_AMMO_TO_DROP(int ped, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CHANCE_OF_FIRING_BLANKS

- **命名空间:** `WEAPON`
- **Hash:** `0x8378627201D5497D`
- **JHash:** `0xB4F44C6E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CHANCE_OF_FIRING_BLANKS(int ped, float xBias, float yBias)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `xBias` | `float` | `float` | - |
| `yBias` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CURRENT_WEAPON_VISIBLE

- **命名空间:** `WEAPON`
- **Hash:** `0x0725A4CCFDED9A70`
- **JHash:** `0x00BECD77`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_CURRENT_WEAPON_VISIBLE(int ped, bool visible, bool deselectWeapon, bool p3, bool p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `visible` | `BOOL` | `bool` | - |
| `deselectWeapon` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Has 5 parameters since latest patches.
```

---

### SET_PED_CYCLE_VEHICLE_WEAPONS_ONLY

- **命名空间:** `WEAPON`
- **Hash:** `0x50276EF8172F5F12`
- **Build:** `1734`

**C# 签名:**
```csharp
void SET_PED_CYCLE_VEHICLE_WEAPONS_ONLY(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_DROPS_INVENTORY_WEAPON

- **命名空间:** `WEAPON`
- **Hash:** `0x208A1888007FC0E6`
- **JHash:** `0x81FFB874`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_DROPS_INVENTORY_WEAPON(int ped, uint weaponHash, float xOffset, float yOffset, float zOffset, int ammoCount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `xOffset` | `float` | `float` | - |
| `yOffset` | `float` | `float` | - |
| `zOffset` | `float` | `float` | - |
| `ammoCount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### SET_PED_DROPS_WEAPON

- **命名空间:** `WEAPON`
- **Hash:** `0x6B7513D9966FBEC0`
- **JHash:** `0x3D3329FA`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_DROPS_WEAPON(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_DROPS_WEAPONS_WHEN_DEAD

- **命名空间:** `WEAPON`
- **Hash:** `0x476AE72C1D19D1A8`
- **JHash:** `0x8A444056`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_DROPS_WEAPONS_WHEN_DEAD(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_GADGET

- **命名空间:** `WEAPON`
- **Hash:** `0xD0D7B1E680ED4A1A`
- **JHash:** `0x8A256D0A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_GADGET(int ped, uint gadgetHash, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `gadgetHash` | `Hash` | `uint` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1/gadgetHash was always 0xFBAB5776 ("GADGET_PARACHUTE").
p2 is always true.
```

---

### SET_PED_INFINITE_AMMO

- **命名空间:** `WEAPON`
- **Hash:** `0x3EDCB0505123623B`
- **JHash:** `0x9CB8D278`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_INFINITE_AMMO(int ped, bool toggle, uint weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |
| `weaponHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### SET_PED_INFINITE_AMMO_CLIP

- **命名空间:** `WEAPON`
- **Hash:** `0x183DADC6AA953186`
- **JHash:** `0x5A5E3B67`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_INFINITE_AMMO_CLIP(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_SHOOT_ORDNANCE_WEAPON

- **命名空间:** `WEAPON`
- **Hash:** `0xB4C8D77C80C0421E`
- **JHash:** `0xEC2E5304`
- **Build:** `323`

**C# 签名:**
```csharp
int SET_PED_SHOOT_ORDNANCE_WEAPON(int ped, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `int` (Native: `Object`)

**说明:**
```
Returns handle of the projectile.
```

---

### SET_PED_STUN_GUN_FINITE_AMMO

- **命名空间:** `WEAPON`
- **Hash:** `0x24C024BA8379A70A`
- **Build:** `1868`

**C# 签名:**
```csharp
void SET_PED_STUN_GUN_FINITE_AMMO(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_WEAPON_COMPONENT_TINT_INDEX

- **命名空间:** `WEAPON`
- **Hash:** `0x9FE5633880ECD8ED`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_PED_WEAPON_COMPONENT_TINT_INDEX(int ped, uint weaponHash, uint camoComponentHash, int colorIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `camoComponentHash` | `Hash` | `uint` | - |
| `colorIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Colors:
0 = Gray
1 = Dark Gray
2 = Black
3 = White
4 = Blue
5 = Cyan
6 = Aqua
7 = Cool Blue
8 = Dark Blue
9 = Royal Blue
10 = Plum
11 = Dark Purple
12 = Purple
13 = Red
14 = Wine Red
15 = Magenta
16 = Pink
17 = Salmon
18 = Hot Pink
19 = Rust Orange
20 = Brown
21 = Earth
22 = Orange
23 = Light Orange
24 = Dark Yellow
25 = Yellow
26 = Light Brown
27 = Lime Green
28 = Olive
29 = Moss
30 = Turquoise
31 = Dark Green
Full list of weapons, components, tint indexes & weapon liveries by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### SET_PED_WEAPON_TINT_INDEX

- **命名空间:** `WEAPON`
- **Hash:** `0x50969B9B89ED5738`
- **JHash:** `0xEB2A7B23`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_WEAPON_TINT_INDEX(int ped, uint weaponHash, int tintIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `weaponHash` | `Hash` | `uint` | - |
| `tintIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
tintIndex can be the following:

0 - Normal
1 - Green
2 - Gold
3 - Pink
4 - Army
5 - LSPD
6 - Orange
7 - Platinum
Full list of weapons, components & tint indexes by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### SET_PICKUP_AMMO_AMOUNT_SCALER

- **命名空间:** `WEAPON`
- **Hash:** `0xE620FD3512A04F18`
- **JHash:** `0xD6460EA2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PICKUP_AMMO_AMOUNT_SCALER(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_TARGETTABLE_FOR_AIR_DEFENCE_SPHERE

- **命名空间:** `WEAPON`
- **Hash:** `0xECDC202B25E5CF48`
- **Build:** `573`

**C# 签名:**
```csharp
void SET_PLAYER_TARGETTABLE_FOR_AIR_DEFENCE_SPHERE(int player, int zoneId, bool enable)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `zoneId` | `int` | `int` | - |
| `enable` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_WEAPON_ANIMATION_OVERRIDE

- **命名空间:** `WEAPON`
- **Hash:** `0x1055AC3A667F09D9`
- **JHash:** `0xA5DF7484`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_WEAPON_ANIMATION_OVERRIDE(int ped, uint animStyle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `animStyle` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Changes the selected ped aiming animation style. 
Note : You must use GET_HASH_KEY!

Strings to use with GET_HASH_KEY :

    "Ballistic",
    "Default",
  "Fat",
  "Female",
   "FirstPerson",
  "FirstPersonAiming",
    "FirstPersonFranklin",
  "FirstPersonFranklinAiming",
    "FirstPersonFranklinRNG",
   "FirstPersonFranklinScope",
 "FirstPersonMPFemale",
  "FirstPersonMichael",
   "FirstPersonMichaelAiming",
 "FirstPersonMichaelRNG",
    "FirstPersonMichaelScope",
  "FirstPersonRNG",
   "FirstPersonScope",
 "FirstPersonTrevor",
    "FirstPersonTrevorAiming",
  "FirstPersonTrevorRNG",
 "FirstPersonTrevorScope",
   "Franklin",
 "Gang",
 "Gang1H",
   "GangFemale",
   "Hillbilly",
    "MP_F_Freemode",
    "Michael",
  "SuperFat",
 "Trevor"
```

---

### SET_WEAPON_AOE_MODIFIER

- **命名空间:** `WEAPON`
- **Hash:** `0x4AE5AC8B852D642C`
- **Build:** `2372`

**C# 签名:**
```csharp
void SET_WEAPON_AOE_MODIFIER(uint weaponHash, float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_WEAPON_DAMAGE_MODIFIER

- **命名空间:** `WEAPON`
- **Hash:** `0x4757F00BC6323CFE`
- **Build:** `505`

**C# 签名:**
```csharp
void SET_WEAPON_DAMAGE_MODIFIER(uint weaponHash, float damageMultiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |
| `damageMultiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Changes the weapon damage output by the given multiplier value. Must be run every frame.
Full list of weapons by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### SET_WEAPON_EFFECT_DURATION_MODIFIER

- **命名空间:** `WEAPON`
- **Hash:** `0xE6D2CEDD370FF98E`
- **Build:** `2372`

**C# 签名:**
```csharp
void SET_WEAPON_EFFECT_DURATION_MODIFIER(uint p0, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Hash` | `uint` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
ex, WEAPON::SET_WEAPON_EFFECT_DURATION_MODIFIER(joaat("vehicle_weapon_mine_slick"), 1.0);
```

---

### SET_WEAPON_OBJECT_CAMO_INDEX

- **命名空间:** `WEAPON`
- **Hash:** `0x977CA98939E82E4B`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_WEAPON_OBJECT_CAMO_INDEX(int weaponObject, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponObject` | `Object` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_WEAPON_OBJECT_COMPONENT_TINT_INDEX

- **命名空间:** `WEAPON`
- **Hash:** `0x5DA825A85D0EA6E6`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_WEAPON_OBJECT_COMPONENT_TINT_INDEX(int weaponObject, uint camoComponentHash, int colorIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponObject` | `Object` | `int` | - |
| `camoComponentHash` | `Hash` | `uint` | - |
| `colorIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Colors:
0 = Gray
1 = Dark Gray
2 = Black
3 = White
4 = Blue
5 = Cyan
6 = Aqua
7 = Cool Blue
8 = Dark Blue
9 = Royal Blue
10 = Plum
11 = Dark Purple
12 = Purple
13 = Red
14 = Wine Red
15 = Magenta
16 = Pink
17 = Salmon
18 = Hot Pink
19 = Rust Orange
20 = Brown
21 = Earth
22 = Orange
23 = Light Orange
24 = Dark Yellow
25 = Yellow
26 = Light Brown
27 = Lime Green
28 = Olive
29 = Moss
30 = Turquoise
31 = Dark Green
Full list of weapons, components, tint indexes & weapon liveries by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### SET_WEAPON_OBJECT_TINT_INDEX

- **命名空间:** `WEAPON`
- **Hash:** `0xF827589017D4E4A9`
- **JHash:** `0x44ACC1DA`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_WEAPON_OBJECT_TINT_INDEX(int weapon, int tintIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weapon` | `Object` | `int` | - |
| `tintIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of weapons, components & tint indexes by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/weapons.json
```

---

### _GET_AMMO_IN_VEHICLE_WEAPON_CLIP

- **命名空间:** `WEAPON`
- **Hash:** `0x2857938C5D407AFA`
- **Build:** `3407`

**C# 签名:**
```csharp
bool _GET_AMMO_IN_VEHICLE_WEAPON_CLIP(int vehicle, int seat, ref int ammo)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `seat` | `int` | `int` | - |
| `ammo` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### _GET_TIME_BEFORE_VEHICLE_WEAPON_RELOAD_FINISHES

- **命名空间:** `WEAPON`
- **Hash:** `0xC8C6F4B1CDEB40EF`
- **Build:** `3407`

**C# 签名:**
```csharp
int _GET_TIME_BEFORE_VEHICLE_WEAPON_RELOAD_FINISHES(int vehicle, int seat)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `seat` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### _GET_VEHICLE_WEAPON_RELOAD_TIME

- **命名空间:** `WEAPON`
- **Hash:** `0xD0AD348FFD7A6868`
- **Build:** `3407`

**C# 签名:**
```csharp
float _GET_VEHICLE_WEAPON_RELOAD_TIME(int vehicle, int seat)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `seat` | `int` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### _HAS_WEAPON_RELOADING_IN_VEHICLE

- **命名空间:** `WEAPON`
- **Hash:** `0x8062F07153F4446F`
- **Build:** `3407`

**C# 签名:**
```csharp
bool _HAS_WEAPON_RELOADING_IN_VEHICLE(int vehicle, int seat)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `seat` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### _SET_AMMO_IN_VEHICLE_WEAPON_CLIP

- **命名空间:** `WEAPON`
- **Hash:** `0x873906720EE842C3`
- **Build:** `3407`

**C# 签名:**
```csharp
bool _SET_AMMO_IN_VEHICLE_WEAPON_CLIP(int vehicle, int seat, int ammo)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `seat` | `int` | `int` | - |
| `ammo` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### _SET_WEAPON_PED_DAMAGE_MODIFIER

- **命名空间:** `WEAPON`
- **Hash:** `0x1091922715B68DF0`
- **Build:** `3095`

**C# 签名:**
```csharp
void _SET_WEAPON_PED_DAMAGE_MODIFIER(uint weapon, float damageModifier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weapon` | `Hash` | `uint` | - |
| `damageModifier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### _TRIGGER_VEHICLE_WEAPON_RELOAD

- **命名空间:** `WEAPON`
- **Hash:** `0x5B1513F27F279A44`
- **Build:** `3407`

**C# 签名:**
```csharp
bool _TRIGGER_VEHICLE_WEAPON_RELOAD(int vehicle, int seat, int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `seat` | `int` | `int` | - |
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---
