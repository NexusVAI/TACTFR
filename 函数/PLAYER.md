# PLAYER - Native 函数参考

> 命名空间: PLAYER

---

## 快速索引

| 函数名 | C# 签名 | 返回值 | 说明 |
|--------|---------|--------|------|
| `ADD_PLAYER_TARGETABLE_ENTITY` | `void ADD_PLAYER_TARGETABLE_ENTITY(int player, int entity)` | void | - |
| `ALLOW_EVASION_HUD_IF_DISABLING_HIDDEN_EVASION_THIS_FRAME` | `void ALLOW_EVASION_HUD_IF_DISABLING_HIDDEN_EVASION_THIS_FRAME(int player, object p1)` | void | - |
| `ARE_PLAYER_FLASHING_STARS_ABOUT_TO_DROP` | `bool ARE_PLAYER_FLASHING_STARS_ABOUT_TO_DROP(int player)` | bool | - |
| `ARE_PLAYER_STARS_GREYED_OUT` | `bool ARE_PLAYER_STARS_GREYED_OUT(int player)` | bool | - |
| `ASSISTED_MOVEMENT_CLOSE_ROUTE` | `void ASSISTED_MOVEMENT_CLOSE_ROUTE()` | void | - |
| `ASSISTED_MOVEMENT_FLUSH_ROUTE` | `void ASSISTED_MOVEMENT_FLUSH_ROUTE()` | void | - |
| `CAN_PED_HEAR_PLAYER` | `bool CAN_PED_HEAR_PLAYER(int player, int ped)` | bool | - |
| `CAN_PLAYER_START_MISSION` | `bool CAN_PLAYER_START_MISSION(int player)` | bool | - |
| `CHANGE_PLAYER_PED` | `void CHANGE_PLAYER_PED(int player, int ped, bool p2, bool resetDamage)` | void | - |
| `CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED` | `void CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED(int player)` | void | - |
| `CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_PED` | `void CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_PED(int player)` | void | - |
| `CLEAR_PLAYER_PARACHUTE_MODEL_OVERRIDE` | `void CLEAR_PLAYER_PARACHUTE_MODEL_OVERRIDE(int player)` | void | - |
| `CLEAR_PLAYER_PARACHUTE_PACK_MODEL_OVERRIDE` | `void CLEAR_PLAYER_PARACHUTE_PACK_MODEL_OVERRIDE(int player)` | void | - |
| `CLEAR_PLAYER_PARACHUTE_VARIATION_OVERRIDE` | `void CLEAR_PLAYER_PARACHUTE_VARIATION_OVERRIDE(int player)` | void | - |
| `CLEAR_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE` | `void CLEAR_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE(int player)` | void | - |
| `CLEAR_PLAYER_WANTED_LEVEL` | `void CLEAR_PLAYER_WANTED_LEVEL(int player)` | void | This executes at the same as speed as PLAYER::SET_PLAYER_WANTED_LEVEL(player, 0, false);<br><br>PLAYER::GE... |
| `DISABLE_CAMERA_VIEW_MODE_CYCLE` | `void DISABLE_CAMERA_VIEW_MODE_CYCLE(int player)` | void | - |
| `DISABLE_PLAYER_FIRING` | `void DISABLE_PLAYER_FIRING(int player, bool toggle)` | void | Inhibits the player from using any method of combat including melee and firearms.<br><br>NOTE: Only disabl... |
| `DISABLE_PLAYER_HEALTH_RECHARGE` | `void DISABLE_PLAYER_HEALTH_RECHARGE(int player)` | void | Needs to be called every frame. |
| `DISABLE_PLAYER_THROW_GRENADE_WHILE_USING_GUN` | `void DISABLE_PLAYER_THROW_GRENADE_WHILE_USING_GUN()` | void | Used only once in R* scripts (freemode.ysc). |
| `DISABLE_PLAYER_VEHICLE_REWARDS` | `void DISABLE_PLAYER_VEHICLE_REWARDS(int player)` | void | - |
| `DISPLAY_SYSTEM_SIGNIN_UI` | `void DISPLAY_SYSTEM_SIGNIN_UI(bool p0)` | void | Purpose of the BOOL currently unknown.<br>Both, true and false, work |
| `ENABLE_SPECIAL_ABILITY` | `void ENABLE_SPECIAL_ABILITY(int player, bool toggle, object p2)` | void | - |
| `EXTEND_WORLD_BOUNDARY_FOR_PLAYER` | `void EXTEND_WORLD_BOUNDARY_FOR_PLAYER(float x, float y, float z)` | void | Appears only 3 times in the scripts, more specifically in michael1.ysc<br><br>-<br>This can be used to preven... |
| `FORCE_CLEANUP` | `void FORCE_CLEANUP(int cleanupFlags)` | void | used with 1,2,8,64,128 in the scripts |
| `FORCE_CLEANUP_FOR_ALL_THREADS_WITH_THIS_NAME` | `void FORCE_CLEANUP_FOR_ALL_THREADS_WITH_THIS_NAME(string name, int cleanupFlags)` | void | PLAYER::FORCE_CLEANUP_FOR_ALL_THREADS_WITH_THIS_NAME("pb_prostitute", 1); // Found in decompilation |
| `FORCE_CLEANUP_FOR_THREAD_WITH_THIS_ID` | `void FORCE_CLEANUP_FOR_THREAD_WITH_THIS_ID(int id, int cleanupFlags)` | void | - |
| `FORCE_START_HIDDEN_EVASION` | `void FORCE_START_HIDDEN_EVASION(int player)` | void | This has been found in use in the decompiled files. |
| `GET_ACHIEVEMENT_PROGRESS` | `int GET_ACHIEVEMENT_PROGRESS(int achievementId)` | int | For Steam.<br>Always returns 0 in retail version of the game. |
| `GET_ARE_CAMERA_CONTROLS_DISABLED` | `bool GET_ARE_CAMERA_CONTROLS_DISABLED()` | bool | Returns true when the player is not able to control the cam i.e. when running a benchmark test, swit... |
| `GET_CAUSE_OF_MOST_RECENT_FORCE_CLEANUP` | `int GET_CAUSE_OF_MOST_RECENT_FORCE_CLEANUP()` | int | - |
| `GET_ENTITY_PLAYER_IS_FREE_AIMING_AT` | `bool GET_ENTITY_PLAYER_IS_FREE_AIMING_AT(int player, Entity* entity)` | bool | Returns TRUE if it found an entity in your crosshair within range of your weapon. Assigns the handle... |
| `GET_IS_MOPPING_AREA_FREE_IN_FRONT_OF_PLAYER` | `bool GET_IS_MOPPING_AREA_FREE_IN_FRONT_OF_PLAYER(int player, float p1)` | bool | 2 occurrences in agency_heist3a. p1 was 0.7f then 0.4f. |
| `GET_IS_PLAYER_DRIVING_ON_HIGHWAY` | `bool GET_IS_PLAYER_DRIVING_ON_HIGHWAY(int player)` | bool | Appears once in "re_dealgonewrong" |
| `GET_IS_PLAYER_DRIVING_WRECKLESS` | `bool GET_IS_PLAYER_DRIVING_WRECKLESS(int player, int p1)` | bool | Only 1 occurrence. p1 was 2. |
| `GET_IS_USING_FPS_THIRD_PERSON_COVER` | `bool GET_IS_USING_FPS_THIRD_PERSON_COVER()` | bool | Returns profile setting 237. |
| `GET_IS_USING_HOOD_CAMERA` | `bool GET_IS_USING_HOOD_CAMERA()` | bool | Returns profile setting 243. |
| `GET_MAX_WANTED_LEVEL` | `int GET_MAX_WANTED_LEVEL()` | int | Gets the maximum wanted level the player can get.<br>Ranges from 0 to 5. |
| `GET_NUMBER_OF_PLAYERS` | `int GET_NUMBER_OF_PLAYERS()` | int | Gets the number of players in the current session.<br>If not multiplayer, always returns 1. |
| `GET_NUMBER_OF_PLAYERS_IN_TEAM` | `int GET_NUMBER_OF_PLAYERS_IN_TEAM(int team)` | int | - |
| `GET_PLAYERS_LAST_VEHICLE` | `int GET_PLAYERS_LAST_VEHICLE()` | int | Alternative: GET_VEHICLE_PED_IS_IN(PLAYER_PED_ID(), 1); |
| `GET_PLAYER_CURRENT_STEALTH_NOISE` | `float GET_PLAYER_CURRENT_STEALTH_NOISE(int player)` | float | - |
| `GET_PLAYER_DEBUG_INVINCIBLE` | `bool GET_PLAYER_DEBUG_INVINCIBLE(int player)` | bool | Always returns false. |
| `GET_PLAYER_FAKE_WANTED_LEVEL` | `int GET_PLAYER_FAKE_WANTED_LEVEL(int player)` | int | - |
| `GET_PLAYER_GROUP` | `int GET_PLAYER_GROUP(int player)` | int | Returns the group ID the player is member of. |
| `GET_PLAYER_HAS_RESERVE_PARACHUTE` | `bool GET_PLAYER_HAS_RESERVE_PARACHUTE(int player)` | bool | - |
| `GET_PLAYER_HEALTH_RECHARGE_MAX_PERCENT` | `float GET_PLAYER_HEALTH_RECHARGE_MAX_PERCENT(int player)` | float | - |
| `GET_PLAYER_INDEX` | `int GET_PLAYER_INDEX()` | int | Returns the same as PLAYER_ID and NETWORK_PLAYER_ID_TO_INT |
| `GET_PLAYER_INVINCIBLE` | `bool GET_PLAYER_INVINCIBLE(int player)` | bool | Returns the Player's Invincible status.<br><br>This function will always return false if 0x733A643B5B0C53C... |
| `GET_PLAYER_MAX_ARMOUR` | `int GET_PLAYER_MAX_ARMOUR(int player)` | int | - |
| `GET_PLAYER_NAME` | `string GET_PLAYER_NAME(int player)` | string | - |
| `GET_PLAYER_PARACHUTE_MODEL_OVERRIDE` | `uint GET_PLAYER_PARACHUTE_MODEL_OVERRIDE(int player)` | uint | - |
| `GET_PLAYER_PARACHUTE_PACK_TINT_INDEX` | `void GET_PLAYER_PARACHUTE_PACK_TINT_INDEX(int player, ref int tintIndex)` | void | - |
| `GET_PLAYER_PARACHUTE_SMOKE_TRAIL_COLOR` | `void GET_PLAYER_PARACHUTE_SMOKE_TRAIL_COLOR(int player, ref int r, ref int g, ref int b)` | void | - |
| `GET_PLAYER_PARACHUTE_TINT_INDEX` | `void GET_PLAYER_PARACHUTE_TINT_INDEX(int player, ref int tintIndex)` | void | Tints:<br>  None = -1,<br>    Rainbow = 0,<br>  Red = 1,<br>  SeasideStripes = 2,<br>   WidowMaker = 3,<br>   Patriot ... |
| `GET_PLAYER_PED` | `int GET_PLAYER_PED(int player)` | int | Gets the ped for a specified player index. |
| `GET_PLAYER_PED_SCRIPT_INDEX` | `int GET_PLAYER_PED_SCRIPT_INDEX(int player)` | int | Does the same like PLAYER::GET_PLAYER_PED |
| `GET_PLAYER_RECEIVED_BATTLE_EVENT_RECENTLY` | `bool GET_PLAYER_RECEIVED_BATTLE_EVENT_RECENTLY(int player, int p1, bool p2)` | bool | - |
| `GET_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE` | `uint GET_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE(int player)` | uint | - |
| `GET_PLAYER_RESERVE_PARACHUTE_TINT_INDEX` | `void GET_PLAYER_RESERVE_PARACHUTE_TINT_INDEX(int player, ref int index)` | void | Tints:<br>  None = -1,<br>    Rainbow = 0,<br>  Red = 1,<br>  SeasideStripes = 2,<br>   WidowMaker = 3,<br>   Patriot ... |
| `GET_PLAYER_RGB_COLOUR` | `void GET_PLAYER_RGB_COLOUR(int player, ref int r, ref int g, ref int b)` | void | - |
| `GET_PLAYER_SPRINT_STAMINA_REMAINING` | `float GET_PLAYER_SPRINT_STAMINA_REMAINING(int player)` | float | - |
| `GET_PLAYER_SPRINT_TIME_REMAINING` | `float GET_PLAYER_SPRINT_TIME_REMAINING(int player)` | float | - |
| `GET_PLAYER_TARGETING_MODE` | `int GET_PLAYER_TARGETING_MODE()` | int | - |
| `GET_PLAYER_TARGET_ENTITY` | `bool GET_PLAYER_TARGET_ENTITY(int player, Entity* entity)` | bool | Assigns the handle of locked-on melee target to *entity that you pass it.<br>Returns false if no entity... |
| `GET_PLAYER_TEAM` | `int GET_PLAYER_TEAM(int player)` | int | Gets the player's team.<br>Does nothing in singleplayer. |
| `GET_PLAYER_UNDERWATER_TIME_REMAINING` | `float GET_PLAYER_UNDERWATER_TIME_REMAINING(int player)` | float | - |
| `GET_PLAYER_WANTED_CENTRE_POSITION` | `Vector3 GET_PLAYER_WANTED_CENTRE_POSITION(int player)` | Vector3 | - |
| `GET_PLAYER_WANTED_LEVEL` | `int GET_PLAYER_WANTED_LEVEL(int player)` | int | - |
| `GET_TIME_SINCE_LAST_ARREST` | `int GET_TIME_SINCE_LAST_ARREST()` | int | Returns the time since the character was arrested in (ms) milliseconds.<br><br>example<br><br>var time = Functio... |
| `GET_TIME_SINCE_LAST_DEATH` | `int GET_TIME_SINCE_LAST_DEATH()` | int | Returns the time since the character died in (ms) milliseconds.<br><br>example<br><br>var time = Function.call<i... |
| `GET_TIME_SINCE_PLAYER_DROVE_AGAINST_TRAFFIC` | `int GET_TIME_SINCE_PLAYER_DROVE_AGAINST_TRAFFIC(int player)` | int | - |
| `GET_TIME_SINCE_PLAYER_DROVE_ON_PAVEMENT` | `int GET_TIME_SINCE_PLAYER_DROVE_ON_PAVEMENT(int player)` | int | - |
| `GET_TIME_SINCE_PLAYER_HIT_PED` | `int GET_TIME_SINCE_PLAYER_HIT_PED(int player)` | int | - |
| `GET_TIME_SINCE_PLAYER_HIT_VEHICLE` | `int GET_TIME_SINCE_PLAYER_HIT_VEHICLE(int player)` | int | - |
| `GET_WANTED_LEVEL_RADIUS` | `float GET_WANTED_LEVEL_RADIUS(int player)` | float | Remnant from GTA IV. Does nothing in GTA V. |
| `GET_WANTED_LEVEL_THRESHOLD` | `int GET_WANTED_LEVEL_THRESHOLD(int wantedLevel)` | int | Drft |
| `GET_WANTED_LEVEL_TIME_TO_ESCAPE` | `int GET_WANTED_LEVEL_TIME_TO_ESCAPE()` | int | - |
| `GIVE_ACHIEVEMENT_TO_PLAYER` | `bool GIVE_ACHIEVEMENT_TO_PLAYER(int achievementId)` | bool | 1 - Welcome to Los Santos<br>2 - A Friendship Resurrected<br>3 - A Fair Day's Pay<br>4 - The Moment of Truth<br>... |
| `GIVE_PLAYER_RAGDOLL_CONTROL` | `void GIVE_PLAYER_RAGDOLL_CONTROL(int player, bool toggle)` | void | - |
| `HAS_ACHIEVEMENT_BEEN_PASSED` | `bool HAS_ACHIEVEMENT_BEEN_PASSED(int achievementId)` | bool | See GIVE_ACHIEVEMENT_TO_PLAYER |
| `HAS_FORCE_CLEANUP_OCCURRED` | `bool HAS_FORCE_CLEANUP_OCCURRED(int cleanupFlags)` | bool | - |
| `HAS_PLAYER_BEEN_SPOTTED_IN_STOLEN_VEHICLE` | `bool HAS_PLAYER_BEEN_SPOTTED_IN_STOLEN_VEHICLE(int player)` | bool | - |
| `HAS_PLAYER_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED` | `bool HAS_PLAYER_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED(int player)` | bool | - |
| `HAS_PLAYER_DAMAGED_AT_LEAST_ONE_PED` | `bool HAS_PLAYER_DAMAGED_AT_LEAST_ONE_PED(int player)` | bool | - |
| `HAS_PLAYER_LEFT_THE_WORLD` | `bool HAS_PLAYER_LEFT_THE_WORLD(int player)` | bool | - |
| `INCREASE_PLAYER_JUMP_SUPPRESSION_RANGE` | `void INCREASE_PLAYER_JUMP_SUPPRESSION_RANGE(int player)` | void | - |
| `INT_TO_PARTICIPANTINDEX` | `int INT_TO_PARTICIPANTINDEX(int value)` | int | Simply returns whatever is passed to it (Regardless of whether the handle is valid or not).<br>--------... |
| `INT_TO_PLAYERINDEX` | `int INT_TO_PLAYERINDEX(int value)` | int | Simply returns whatever is passed to it (Regardless of whether the handle is valid or not). |
| `IS_PLAYER_BATTLE_AWARE` | `bool IS_PLAYER_BATTLE_AWARE(int player)` | bool | Returns true if an unk value is greater than 0.0f |
| `IS_PLAYER_BEING_ARRESTED` | `bool IS_PLAYER_BEING_ARRESTED(int player, bool atArresting)` | bool | Return true while player is being arrested / busted.<br><br>If atArresting is set to 1, this function will... |
| `IS_PLAYER_BLUETOOTH_ENABLE` | `bool IS_PLAYER_BLUETOOTH_ENABLE(int player)` | bool | - |
| `IS_PLAYER_CLIMBING` | `bool IS_PLAYER_CLIMBING(int player)` | bool | Returns TRUE if the player ('s ped) is climbing at the moment. |
| `IS_PLAYER_CONTROL_ON` | `bool IS_PLAYER_CONTROL_ON(int player)` | bool | Can the player control himself, used to disable controls for player for things like a cutscene.<br><br>---... |
| `IS_PLAYER_DEAD` | `bool IS_PLAYER_DEAD(int player)` | bool | - |
| `IS_PLAYER_FREE_AIMING` | `bool IS_PLAYER_FREE_AIMING(int player)` | bool | Gets a value indicating whether the specified player is currently aiming freely. |
| `IS_PLAYER_FREE_AIMING_AT_ENTITY` | `bool IS_PLAYER_FREE_AIMING_AT_ENTITY(int player, int entity)` | bool | Gets a value indicating whether the specified player is currently aiming freely at the specified ent... |
| `IS_PLAYER_FREE_FOR_AMBIENT_TASK` | `bool IS_PLAYER_FREE_FOR_AMBIENT_TASK(int player)` | bool | - |
| `IS_PLAYER_LOGGING_IN_NP` | `bool IS_PLAYER_LOGGING_IN_NP()` | bool | this function is hard-coded to always return 0. |
| `IS_PLAYER_ONLINE` | `bool IS_PLAYER_ONLINE()` | bool | Returns TRUE if the game is in online mode and FALSE if in offline mode.<br><br>This is an alias for NETWO... |
| `IS_PLAYER_PLAYING` | `bool IS_PLAYER_PLAYING(int player)` | bool | Checks whether the specified player has a Ped, the Ped is not dead, is not injured and is not arrest... |
| `IS_PLAYER_PRESSING_HORN` | `bool IS_PLAYER_PRESSING_HORN(int player)` | bool | - |
| `IS_PLAYER_READY_FOR_CUTSCENE` | `bool IS_PLAYER_READY_FOR_CUTSCENE(int player)` | bool | - |
| `IS_PLAYER_RIDING_TRAIN` | `bool IS_PLAYER_RIDING_TRAIN(int player)` | bool | Returns true if the player is riding a train. |
| `IS_PLAYER_SCRIPT_CONTROL_ON` | `bool IS_PLAYER_SCRIPT_CONTROL_ON(int player)` | bool | - |
| `IS_PLAYER_TARGETTING_ANYTHING` | `bool IS_PLAYER_TARGETTING_ANYTHING(int player)` | bool | - |
| `IS_PLAYER_TARGETTING_ENTITY` | `bool IS_PLAYER_TARGETTING_ENTITY(int player, int entity)` | bool | - |
| `IS_PLAYER_TELEPORT_ACTIVE` | `bool IS_PLAYER_TELEPORT_ACTIVE()` | bool | - |
| `IS_PLAYER_VEHICLE_WEAPON_TOGGLED_TO_NON_HOMING` | `bool IS_PLAYER_VEHICLE_WEAPON_TOGGLED_TO_NON_HOMING(object p0)` | bool | - |
| `IS_PLAYER_WANTED_LEVEL_GREATER` | `bool IS_PLAYER_WANTED_LEVEL_GREATER(int player, int wantedLevel)` | bool | - |
| `IS_REMOTE_PLAYER_IN_NON_CLONED_VEHICLE` | `bool IS_REMOTE_PLAYER_IN_NON_CLONED_VEHICLE(int player)` | bool | - |
| `IS_SPECIAL_ABILITY_ACTIVE` | `bool IS_SPECIAL_ABILITY_ACTIVE(int player, object p1)` | bool | - |
| `IS_SPECIAL_ABILITY_ENABLED` | `bool IS_SPECIAL_ABILITY_ENABLED(int player, object p1)` | bool | - |
| `IS_SPECIAL_ABILITY_METER_FULL` | `bool IS_SPECIAL_ABILITY_METER_FULL(int player, object p1)` | bool | - |
| `IS_SPECIAL_ABILITY_UNLOCKED` | `bool IS_SPECIAL_ABILITY_UNLOCKED(uint playerModel)` | bool | - |
| `IS_SYSTEM_UI_BEING_DISPLAYED` | `bool IS_SYSTEM_UI_BEING_DISPLAYED()` | bool | - |
| `IS_WANTED_AND_HAS_BEEN_SEEN_BY_COPS` | `bool IS_WANTED_AND_HAS_BEEN_SEEN_BY_COPS(int player)` | bool | - |
| `NETWORK_PLAYER_ID_TO_INT` | `int NETWORK_PLAYER_ID_TO_INT()` | int | Does exactly the same thing as PLAYER_ID() |
| `PLAYER_ATTACH_VIRTUAL_BOUND` | `void PLAYER_ATTACH_VIRTUAL_BOUND(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7)` | void | Only 1 match. ob_sofa_michael.<br><br>PLAYER::PLAYER_ATTACH_VIRTUAL_BOUND(-804.5928f, 173.1801f, 71.68436f... |
| `PLAYER_DETACH_VIRTUAL_BOUND` | `void PLAYER_DETACH_VIRTUAL_BOUND()` | void | 1.0.335.2, 1.0.350.1/2, 1.0.372.2, 1.0.393.2, 1.0.393.4, 1.0.463.1; |
| `PLAYER_ID` | `int PLAYER_ID()` | int | This returns YOUR 'identity' as a Player type.<br><br>Always returns 0 in story mode. |
| `PLAYER_PED_ID` | `int PLAYER_PED_ID()` | int | Returns current player ped |
| `REMOVE_PLAYER_HELMET` | `void REMOVE_PLAYER_HELMET(int player, bool p2)` | void | - |
| `REMOVE_PLAYER_TARGETABLE_ENTITY` | `void REMOVE_PLAYER_TARGETABLE_ENTITY(int player, int entity)` | void | - |
| `REMOVE_SCRIPT_FIRE_POSITION` | `void REMOVE_SCRIPT_FIRE_POSITION()` | void | Resets values set by SET_SCRIPT_FIRE_POSITION |
| `REPORT_CRIME` | `void REPORT_CRIME(int player, int crimeType, int wantedLvlThresh)` | void | PLAYER::REPORT_CRIME(PLAYER::PLAYER_ID(), 37, PLAYER::GET_WANTED_LEVEL_THRESHOLD(1));<br><br>From am_armyb... |
| `REPORT_POLICE_SPOTTED_PLAYER` | `void REPORT_POLICE_SPOTTED_PLAYER(int player)` | void | - |
| `RESET_LAW_RESPONSE_DELAY_OVERRIDE` | `void RESET_LAW_RESPONSE_DELAY_OVERRIDE()` | void | - |
| `RESET_PLAYER_ARREST_STATE` | `void RESET_PLAYER_ARREST_STATE(int player)` | void | - |
| `RESET_PLAYER_INPUT_GAIT` | `void RESET_PLAYER_INPUT_GAIT(int player)` | void | - |
| `RESET_PLAYER_STAMINA` | `void RESET_PLAYER_STAMINA(int player)` | void | - |
| `RESET_WANTED_LEVEL_DIFFICULTY` | `void RESET_WANTED_LEVEL_DIFFICULTY(int player)` | void | - |
| `RESET_WANTED_LEVEL_HIDDEN_ESCAPE_TIME` | `void RESET_WANTED_LEVEL_HIDDEN_ESCAPE_TIME(int player)` | void | - |
| `RESET_WORLD_BOUNDARY_FOR_PLAYER` | `void RESET_WORLD_BOUNDARY_FOR_PLAYER()` | void | - |
| `RESTORE_PLAYER_STAMINA` | `void RESTORE_PLAYER_STAMINA(int player, float p1)` | void | - |
| `SET_ACHIEVEMENT_PROGRESS` | `bool SET_ACHIEVEMENT_PROGRESS(int achievementId, int progress)` | bool | For Steam.<br>Does nothing and always returns false in the retail version of the game. |
| `SET_AIR_DRAG_MULTIPLIER_FOR_PLAYERS_VEHICLE` | `void SET_AIR_DRAG_MULTIPLIER_FOR_PLAYERS_VEHICLE(int player, float multiplier)` | void | This can be between 1.0f - 14.9f <br><br>You can change the max in IDA from 15.0. I say 15.0 as the functi... |
| `SET_ALL_NEUTRAL_RANDOM_PEDS_FLEE` | `void SET_ALL_NEUTRAL_RANDOM_PEDS_FLEE(int player, bool toggle)` | void | - |
| `SET_ALL_NEUTRAL_RANDOM_PEDS_FLEE_THIS_FRAME` | `void SET_ALL_NEUTRAL_RANDOM_PEDS_FLEE_THIS_FRAME(int player)` | void | - This is called after SET_ALL_RANDOM_PEDS_FLEE_THIS_FRAME<br> |
| `SET_ALL_RANDOM_PEDS_FLEE` | `void SET_ALL_RANDOM_PEDS_FLEE(int player, bool toggle)` | void | - |
| `SET_ALL_RANDOM_PEDS_FLEE_THIS_FRAME` | `void SET_ALL_RANDOM_PEDS_FLEE_THIS_FRAME(int player)` | void | - |
| `SET_APPLY_WAYPOINT_OF_PLAYER` | `void SET_APPLY_WAYPOINT_OF_PLAYER(int player, int hudColor)` | void | - |
| `SET_AUTO_GIVE_PARACHUTE_WHEN_ENTER_PLANE` | `void SET_AUTO_GIVE_PARACHUTE_WHEN_ENTER_PLANE(int player, bool toggle)` | void | - |
| `SET_AUTO_GIVE_SCUBA_GEAR_WHEN_EXIT_VEHICLE` | `void SET_AUTO_GIVE_SCUBA_GEAR_WHEN_EXIT_VEHICLE(int player, bool toggle)` | void | - |
| `SET_DISABLE_AMBIENT_MELEE_MOVE` | `void SET_DISABLE_AMBIENT_MELEE_MOVE(int player, bool toggle)` | void | - |
| `SET_DISPATCH_COPS_FOR_PLAYER` | `void SET_DISPATCH_COPS_FOR_PLAYER(int player, bool toggle)` | void | - |
| `SET_EVERYONE_IGNORE_PLAYER` | `void SET_EVERYONE_IGNORE_PLAYER(int player, bool toggle)` | void | - |
| `SET_IGNORE_LOW_PRIORITY_SHOCKING_EVENTS` | `void SET_IGNORE_LOW_PRIORITY_SHOCKING_EVENTS(int player, bool toggle)` | void | - |
| `SET_LAW_PEDS_CAN_ATTACK_NON_WANTED_PLAYER_THIS_FRAME` | `void SET_LAW_PEDS_CAN_ATTACK_NON_WANTED_PLAYER_THIS_FRAME(int player)` | void | - |
| `SET_LAW_RESPONSE_DELAY_OVERRIDE` | `void SET_LAW_RESPONSE_DELAY_OVERRIDE(float p0)` | void | PLAYER::SET_LAW_RESPONSE_DELAY_OVERRIDE(rPtr((&l_122) + 71)); // Found in decompilation<br><br>***<br><br>In "am... |
| `SET_MAX_WANTED_LEVEL` | `void SET_MAX_WANTED_LEVEL(int maxWantedLevel)` | void | - |
| `SET_PLAYER_BLUETOOTH_STATE` | `void SET_PLAYER_BLUETOOTH_STATE(int player, bool state)` | void | - |
| `SET_PLAYER_CAN_BE_HASSLED_BY_GANGS` | `void SET_PLAYER_CAN_BE_HASSLED_BY_GANGS(int player, bool toggle)` | void | Sets whether this player can be hassled by gangs. |
| `SET_PLAYER_CAN_COLLECT_DROPPED_MONEY` | `void SET_PLAYER_CAN_COLLECT_DROPPED_MONEY(int player, bool p1)` | void | - |
| `SET_PLAYER_CAN_DAMAGE_PLAYER` | `void SET_PLAYER_CAN_DAMAGE_PLAYER(int player1, int player2, bool toggle)` | void | - |
| `SET_PLAYER_CAN_DO_DRIVE_BY` | `void SET_PLAYER_CAN_DO_DRIVE_BY(int player, bool toggle)` | void | Set whether this player should be able to do drive-bys.<br><br>"A drive-by is when a ped is aiming/shootin... |
| `SET_PLAYER_CAN_LEAVE_PARACHUTE_SMOKE_TRAIL` | `void SET_PLAYER_CAN_LEAVE_PARACHUTE_SMOKE_TRAIL(int player, bool enabled)` | void | - |
| `SET_PLAYER_CAN_USE_COVER` | `void SET_PLAYER_CAN_USE_COVER(int player, bool toggle)` | void | Sets whether this player can take cover. |
| `SET_PLAYER_CLOTH_LOCK_COUNTER` | `void SET_PLAYER_CLOTH_LOCK_COUNTER(int value)` | void | 6 matches across 4 scripts. 5 occurrences were 240. The other was 255. |
| `SET_PLAYER_CLOTH_PACKAGE_INDEX` | `void SET_PLAYER_CLOTH_PACKAGE_INDEX(int index)` | void | Every occurrence was either 0 or 2. |
| `SET_PLAYER_CLOTH_PIN_FRAMES` | `void SET_PLAYER_CLOTH_PIN_FRAMES(int player, int p1)` | void | - |
| `SET_PLAYER_CONTROL` | `void SET_PLAYER_CONTROL(int player, bool bHasControl, int flags)` | void | Flags:<br>SPC_AMBIENT_SCRIPT = (1 << 1),<br>SPC_CLEAR_TASKS = (1 << 2),<br>SPC_REMOVE_FIRES = (1 << 3),<br>SPC_R... |
| `SET_PLAYER_EXPLOSIVE_DAMAGE_MODIFIER` | `void SET_PLAYER_EXPLOSIVE_DAMAGE_MODIFIER(int player, object p1)` | void | - |
| `SET_PLAYER_FALL_DISTANCE_TO_TRIGGER_RAGDOLL_OVERRIDE` | `void SET_PLAYER_FALL_DISTANCE_TO_TRIGGER_RAGDOLL_OVERRIDE(int player, float p1)` | void | - |
| `SET_PLAYER_FORCED_AIM` | `void SET_PLAYER_FORCED_AIM(int player, bool toggle)` | void | - |
| `SET_PLAYER_FORCED_ZOOM` | `void SET_PLAYER_FORCED_ZOOM(int player, bool toggle)` | void | - |
| `SET_PLAYER_FORCE_SKIP_AIM_INTRO` | `void SET_PLAYER_FORCE_SKIP_AIM_INTRO(int player, bool toggle)` | void | - |
| `SET_PLAYER_HAS_RESERVE_PARACHUTE` | `void SET_PLAYER_HAS_RESERVE_PARACHUTE(int player)` | void | - |
| `SET_PLAYER_HEALTH_RECHARGE_MAX_PERCENT` | `void SET_PLAYER_HEALTH_RECHARGE_MAX_PERCENT(int player, float limit)` | void | - |
| `SET_PLAYER_HEALTH_RECHARGE_MULTIPLIER` | `void SET_PLAYER_HEALTH_RECHARGE_MULTIPLIER(int player, float regenRate)` | void | `regenRate`: The recharge multiplier, a value between 0.0 and 1.0.<br>Use 1.0 to reset it back to norma... |
| `SET_PLAYER_HOMING_DISABLED_FOR_ALL_VEHICLE_WEAPONS` | `void SET_PLAYER_HOMING_DISABLED_FOR_ALL_VEHICLE_WEAPONS(object p0, object p1)` | void | - |
| `SET_PLAYER_INVINCIBLE` | `void SET_PLAYER_INVINCIBLE(int player, bool toggle)` | void | Simply sets you as invincible (Health will not deplete).<br><br>Use 0x733A643B5B0C53C1 instead if you want... |
| `SET_PLAYER_INVINCIBLE_BUT_HAS_REACTIONS` | `void SET_PLAYER_INVINCIBLE_BUT_HAS_REACTIONS(int player, bool toggle)` | void | - |
| `SET_PLAYER_LEAVE_PED_BEHIND` | `void SET_PLAYER_LEAVE_PED_BEHIND(int player, bool toggle)` | void | - |
| `SET_PLAYER_LOCKON` | `void SET_PLAYER_LOCKON(int player, bool toggle)` | void | Example from fm_mission_controler.ysc.c4:<br><br>PLAYER::SET_PLAYER_LOCKON(PLAYER::PLAYER_ID(), 1);<br><br>All o... |
| `SET_PLAYER_LOCKON_RANGE_OVERRIDE` | `void SET_PLAYER_LOCKON_RANGE_OVERRIDE(int player, float range)` | void | Affects the range of auto aim target. |
| `SET_PLAYER_MAX_ARMOUR` | `void SET_PLAYER_MAX_ARMOUR(int player, int value)` | void | Default is 100. Use player id and not ped id. For instance: PLAYER::SET_PLAYER_MAX_ARMOUR(PLAYER::PL... |
| `SET_PLAYER_MAX_EXPLOSIVE_DAMAGE` | `void SET_PLAYER_MAX_EXPLOSIVE_DAMAGE(int player, float p1)` | void | - |
| `SET_PLAYER_MAY_NOT_ENTER_ANY_VEHICLE` | `void SET_PLAYER_MAY_NOT_ENTER_ANY_VEHICLE(int player)` | void | - |
| `SET_PLAYER_MAY_ONLY_ENTER_THIS_VEHICLE` | `void SET_PLAYER_MAY_ONLY_ENTER_THIS_VEHICLE(int player, int vehicle)` | void | - |
| `SET_PLAYER_MELEE_WEAPON_DAMAGE_MODIFIER` | `void SET_PLAYER_MELEE_WEAPON_DAMAGE_MODIFIER(int player, float modifier, bool p2)` | void | modifier's min value is 0.1 |
| `SET_PLAYER_MELEE_WEAPON_DEFENSE_MODIFIER` | `void SET_PLAYER_MELEE_WEAPON_DEFENSE_MODIFIER(int player, float modifier)` | void | modifier's min value is 0.1 |
| `SET_PLAYER_MODEL` | `void SET_PLAYER_MODEL(int player, uint model)` | void | Set the model for a specific Player. Be aware that this will destroy the current Ped for the Player ... |
| `SET_PLAYER_NOISE_MULTIPLIER` | `void SET_PLAYER_NOISE_MULTIPLIER(int player, float multiplier)` | void | - |
| `SET_PLAYER_PARACHUTE_MODEL_OVERRIDE` | `void SET_PLAYER_PARACHUTE_MODEL_OVERRIDE(int player, uint model)` | void | - |
| `SET_PLAYER_PARACHUTE_PACK_MODEL_OVERRIDE` | `void SET_PLAYER_PARACHUTE_PACK_MODEL_OVERRIDE(int player, uint model)` | void | - |
| `SET_PLAYER_PARACHUTE_PACK_TINT_INDEX` | `void SET_PLAYER_PARACHUTE_PACK_TINT_INDEX(int player, int tintIndex)` | void | tints 0- 13<br>0 - unkown<br>1 - unkown<br>2 - unkown<br>3 - unkown<br>4 - unkown |
| `SET_PLAYER_PARACHUTE_SMOKE_TRAIL_COLOR` | `void SET_PLAYER_PARACHUTE_SMOKE_TRAIL_COLOR(int player, int r, int g, int b)` | void | - |
| `SET_PLAYER_PARACHUTE_TINT_INDEX` | `void SET_PLAYER_PARACHUTE_TINT_INDEX(int player, int tintIndex)` | void | Tints:<br>   None = -1,<br>    Rainbow = 0,<br>  Red = 1,<br>  SeasideStripes = 2,<br>   WidowMaker = 3,<br>   Patriot... |
| `SET_PLAYER_PARACHUTE_VARIATION_OVERRIDE` | `void SET_PLAYER_PARACHUTE_VARIATION_OVERRIDE(int player, int p1, object p2, object p3, bool p4)` | void | p1 was always 5.<br>p4 was always false. |
| `SET_PLAYER_PHONE_PALETTE_IDX` | `void SET_PLAYER_PHONE_PALETTE_IDX(int player, int idx)` | void | - |
| `SET_PLAYER_PREVIOUS_VARIATION_DATA` | `void SET_PLAYER_PREVIOUS_VARIATION_DATA(int player, int p1, int p2, object p3, object p4, object p5)` | void | - |
| `SET_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE` | `void SET_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE(int player, uint model)` | void | - |
| `SET_PLAYER_RESERVE_PARACHUTE_TINT_INDEX` | `void SET_PLAYER_RESERVE_PARACHUTE_TINT_INDEX(int player, int index)` | void | Tints:<br>   None = -1,<br>    Rainbow = 0,<br>  Red = 1,<br>  SeasideStripes = 2,<br>   WidowMaker = 3,<br>   Patriot... |
| `SET_PLAYER_SIMULATE_AIMING` | `void SET_PLAYER_SIMULATE_AIMING(int player, bool toggle)` | void | - |
| `SET_PLAYER_SNEAKING_NOISE_MULTIPLIER` | `void SET_PLAYER_SNEAKING_NOISE_MULTIPLIER(int player, float multiplier)` | void | Values around 1.0f to 2.0f used in game scripts. |
| `SET_PLAYER_SPECTATED_VEHICLE_RADIO_OVERRIDE` | `void SET_PLAYER_SPECTATED_VEHICLE_RADIO_OVERRIDE(bool p0)` | void | - |
| `SET_PLAYER_SPRINT` | `void SET_PLAYER_SPRINT(int player, bool toggle)` | void | - |
| `SET_PLAYER_STEALTH_PERCEPTION_MODIFIER` | `void SET_PLAYER_STEALTH_PERCEPTION_MODIFIER(int player, float value)` | void | - |
| `SET_PLAYER_TARGETING_MODE` | `void SET_PLAYER_TARGETING_MODE(int targetMode)` | void | Sets your targeting mode.<br>0 = Assisted Aim - Full<br>1 = Assisted Aim - Partial<br>2 = Free Aim - Assisted... |
| `SET_PLAYER_TARGET_LEVEL` | `void SET_PLAYER_TARGET_LEVEL(int targetLevel)` | void | - |
| `SET_PLAYER_TEAM` | `void SET_PLAYER_TEAM(int player, int team)` | void | Set player team on deathmatch and last team standing.. |
| `SET_PLAYER_UNDERWATER_BREATH_PERCENT_REMAINING` | `float SET_PLAYER_UNDERWATER_BREATH_PERCENT_REMAINING(int player, float time)` | float | - |
| `SET_PLAYER_VEHICLE_DAMAGE_MODIFIER` | `void SET_PLAYER_VEHICLE_DAMAGE_MODIFIER(int player, float modifier)` | void | modifier's min value is 0.1 |
| `SET_PLAYER_VEHICLE_DEFENSE_MODIFIER` | `void SET_PLAYER_VEHICLE_DEFENSE_MODIFIER(int player, float modifier)` | void | modifier's min value is 0.1 |
| `SET_PLAYER_VEHICLE_WEAPON_TO_NON_HOMING` | `void SET_PLAYER_VEHICLE_WEAPON_TO_NON_HOMING(object p0)` | void | Unsets playerPed+330 if the current weapon has certain flags. |
| `SET_PLAYER_WANTED_CENTRE_POSITION` | `void SET_PLAYER_WANTED_CENTRE_POSITION(int player, ref Vector3 position, bool p2, bool p3)` | void | # Predominant call signatures<br>PLAYER::SET_PLAYER_WANTED_CENTRE_POSITION(PLAYER::PLAYER_ID(), ENTITY:... |
| `SET_PLAYER_WANTED_LEVEL` | `void SET_PLAYER_WANTED_LEVEL(int player, int wantedLevel, bool disableNoMission)` | void | Call SET_PLAYER_WANTED_LEVEL_NOW for immediate effect<br><br>wantedLevel is an integer value representing ... |
| `SET_PLAYER_WANTED_LEVEL_NOW` | `void SET_PLAYER_WANTED_LEVEL_NOW(int player, bool p1)` | void | Forces any pending wanted level to be applied to the specified player immediately.<br><br>Call SET_PLAYER_... |
| `SET_PLAYER_WANTED_LEVEL_NO_DROP` | `void SET_PLAYER_WANTED_LEVEL_NO_DROP(int player, int wantedLevel, bool p2)` | void | p2 is always false in R* scripts |
| `SET_PLAYER_WEAPON_DAMAGE_MODIFIER` | `void SET_PLAYER_WEAPON_DAMAGE_MODIFIER(int player, float modifier)` | void | This modifies the damage value of your weapon. Whether it is a multiplier or base damage is unknown.... |
| `SET_PLAYER_WEAPON_DEFENSE_MODIFIER` | `void SET_PLAYER_WEAPON_DEFENSE_MODIFIER(int player, float modifier)` | void | modifier's min value is 0.1 |
| `SET_PLAYER_WEAPON_MINIGUN_DEFENSE_MODIFIER` | `void SET_PLAYER_WEAPON_MINIGUN_DEFENSE_MODIFIER(int player, float modifier)` | void | modifier's min value is 0.1 |
| `SET_PLAYER_WEAPON_TAKEDOWN_DEFENSE_MODIFIER` | `void SET_PLAYER_WEAPON_TAKEDOWN_DEFENSE_MODIFIER(int player, float p1)` | void | - |
| `SET_POLICE_IGNORE_PLAYER` | `void SET_POLICE_IGNORE_PLAYER(int player, bool toggle)` | void | The player will be ignored by the police if toggle is set to true |
| `SET_POLICE_RADAR_BLIPS` | `void SET_POLICE_RADAR_BLIPS(bool toggle)` | void | If toggle is set to false:<br> The police won't be shown on the (mini)map<br><br>If toggle is set to true:<br> T... |
| `SET_RUN_SPRINT_MULTIPLIER_FOR_PLAYER` | `void SET_RUN_SPRINT_MULTIPLIER_FOR_PLAYER(int player, float multiplier)` | void | Multiplier goes up to 1.49 any value above will be completely overruled by the game and the multipli... |
| `SET_SCRIPT_FIRE_POSITION` | `void SET_SCRIPT_FIRE_POSITION(float coordX, float coordY, float coordZ)` | void | - |
| `SET_SPECIAL_ABILITY_MP` | `void SET_SPECIAL_ABILITY_MP(int player, int p1, object p2)` | void | - |
| `SET_SPECIAL_ABILITY_MULTIPLIER` | `void SET_SPECIAL_ABILITY_MULTIPLIER(float multiplier)` | void | - |
| `SET_SWIM_MULTIPLIER_FOR_PLAYER` | `void SET_SWIM_MULTIPLIER_FOR_PLAYER(int player, float multiplier)` | void | Swim speed multiplier.<br>Multiplier goes up to 1.49<br><br>Just call it one time, it is not required to be c... |
| `SET_WANTED_LEVEL_DIFFICULTY` | `void SET_WANTED_LEVEL_DIFFICULTY(int player, float difficulty)` | void | Max value is 1.0 |
| `SET_WANTED_LEVEL_HIDDEN_ESCAPE_TIME` | `void SET_WANTED_LEVEL_HIDDEN_ESCAPE_TIME(int player, int wantedLevel, int lossTime)` | void | - |
| `SET_WANTED_LEVEL_MULTIPLIER` | `void SET_WANTED_LEVEL_MULTIPLIER(float multiplier)` | void | - |
| `SIMULATE_PLAYER_INPUT_GAIT` | `void SIMULATE_PLAYER_INPUT_GAIT(int player, float amount, int gaitType, float speed, bool p4, bool p5, object p6)` | void | This is to make the player walk without accepting input from INPUT.<br><br>gaitType is in increments of 10... |
| `SPECIAL_ABILITY_ACTIVATE` | `void SPECIAL_ABILITY_ACTIVATE(int player, int p1)` | void | p1 is always 0 in the scripts |
| `SPECIAL_ABILITY_CHARGE_ABSOLUTE` | `void SPECIAL_ABILITY_CHARGE_ABSOLUTE(int player, int p1, bool p2, object p3)` | void | p1 appears as 5, 10, 15, 25, or 30. p2 is always true. |
| `SPECIAL_ABILITY_CHARGE_CONTINUOUS` | `void SPECIAL_ABILITY_CHARGE_CONTINUOUS(int player, int p1, object p2)` | void | p1 appears to always be 1 (only comes up twice) |
| `SPECIAL_ABILITY_CHARGE_LARGE` | `void SPECIAL_ABILITY_CHARGE_LARGE(int player, bool p1, bool p2, object p3)` | void | 2 matches. p1 was always true. |
| `SPECIAL_ABILITY_CHARGE_MEDIUM` | `void SPECIAL_ABILITY_CHARGE_MEDIUM(int player, bool p1, bool p2, object p3)` | void | Only 1 match. Both p1 & p2 were true. |
| `SPECIAL_ABILITY_CHARGE_NORMALIZED` | `void SPECIAL_ABILITY_CHARGE_NORMALIZED(int player, float normalizedValue, bool p2, object p3)` | void | <br>normalizedValue is from 0.0 - 1.0<br>p2 is always 1 |
| `SPECIAL_ABILITY_CHARGE_ON_MISSION_FAILED` | `void SPECIAL_ABILITY_CHARGE_ON_MISSION_FAILED(int player, object p1)` | void | - |
| `SPECIAL_ABILITY_CHARGE_SMALL` | `void SPECIAL_ABILITY_CHARGE_SMALL(int player, bool p1, bool p2, object p3)` | void | Every occurrence of p1 & p2 were both true. |
| `SPECIAL_ABILITY_DEACTIVATE` | `void SPECIAL_ABILITY_DEACTIVATE(int player, object p1)` | void | - |
| `SPECIAL_ABILITY_DEACTIVATE_FAST` | `void SPECIAL_ABILITY_DEACTIVATE_FAST(int player, object p1)` | void | - |
| `SPECIAL_ABILITY_DEACTIVATE_MP` | `void SPECIAL_ABILITY_DEACTIVATE_MP(int player, int p1)` | void | p1 is always 0 in the scripts |
| `SPECIAL_ABILITY_DEPLETE_METER` | `void SPECIAL_ABILITY_DEPLETE_METER(int player, bool p1, object p2)` | void | p1 was always true. |
| `SPECIAL_ABILITY_FILL_METER` | `void SPECIAL_ABILITY_FILL_METER(int player, bool p1, object p2)` | void | Also known as _RECHARGE_SPECIAL_ABILITY |
| `SPECIAL_ABILITY_LOCK` | `void SPECIAL_ABILITY_LOCK(uint playerModel, object p1)` | void | - |
| `SPECIAL_ABILITY_RESET` | `void SPECIAL_ABILITY_RESET(int player, object p1)` | void | - |
| `SPECIAL_ABILITY_UNLOCK` | `void SPECIAL_ABILITY_UNLOCK(uint playerModel, object p1)` | void | - |
| `START_FIRING_AMNESTY` | `void START_FIRING_AMNESTY(int duration)` | void | - |
| `START_PLAYER_TELEPORT` | `void START_PLAYER_TELEPORT(int player, float x, float y, float z, float heading, bool p5, bool findCollisionLand, bool p7)` | void | `findCollisionLand`: This teleports the player to land when set to true and will not consider the Z ... |
| `STOP_PLAYER_TELEPORT` | `void STOP_PLAYER_TELEPORT()` | void | Disables the player's teleportation |
| `SUPPRESS_CRIME_THIS_FRAME` | `void SUPPRESS_CRIME_THIS_FRAME(int player, int crimeType)` | void | crimeType: see REPORT_CRIME |
| `SUPPRESS_LOSING_WANTED_LEVEL_IF_HIDDEN_THIS_FRAME` | `void SUPPRESS_LOSING_WANTED_LEVEL_IF_HIDDEN_THIS_FRAME(int player)` | void | This has been found in use in the decompiled files. |
| `SUPPRESS_WITNESSES_CALLING_POLICE_THIS_FRAME` | `void SUPPRESS_WITNESSES_CALLING_POLICE_THIS_FRAME(int player)` | void | - |
| `UPDATE_PLAYER_TELEPORT` | `bool UPDATE_PLAYER_TELEPORT(int player)` | bool | - |
| `UPDATE_SPECIAL_ABILITY_FROM_STAT` | `void UPDATE_SPECIAL_ABILITY_FROM_STAT(int player, object p1)` | void | - |
| `UPDATE_WANTED_POSITION_THIS_FRAME` | `void UPDATE_WANTED_POSITION_THIS_FRAME(int player)` | void | This native is used in both singleplayer and multiplayer scripts.<br><br>Always used like this in scripts<br>... |

---

## 详细说明

### ADD_PLAYER_TARGETABLE_ENTITY

- **命名空间:** `PLAYER`
- **Hash:** `0x9097EB6D4BB9A12A`
- **Build:** `1868`

**C# 签名:**
```csharp
void ADD_PLAYER_TARGETABLE_ENTITY(int player, int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### ALLOW_EVASION_HUD_IF_DISABLING_HIDDEN_EVASION_THIS_FRAME

- **命名空间:** `PLAYER`
- **Hash:** `0x2F41A3BAE005E5FA`
- **Build:** `372`

**C# 签名:**
```csharp
void ALLOW_EVASION_HUD_IF_DISABLING_HIDDEN_EVASION_THIS_FRAME(int player, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### ARE_PLAYER_FLASHING_STARS_ABOUT_TO_DROP

- **命名空间:** `PLAYER`
- **Hash:** `0xAFAF86043E5874E9`
- **JHash:** `0xE13A71C7`
- **Build:** `323`

**C# 签名:**
```csharp
bool ARE_PLAYER_FLASHING_STARS_ABOUT_TO_DROP(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### ARE_PLAYER_STARS_GREYED_OUT

- **命名空间:** `PLAYER`
- **Hash:** `0x0A6EB355EE14A2DB`
- **JHash:** `0x5E72AB72`
- **Build:** `323`

**C# 签名:**
```csharp
bool ARE_PLAYER_STARS_GREYED_OUT(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### ASSISTED_MOVEMENT_CLOSE_ROUTE

- **命名空间:** `PLAYER`
- **Hash:** `0xAEBF081FFC0A0E5E`
- **JHash:** `0xF23277F3`
- **Build:** `323`

**C# 签名:**
```csharp
void ASSISTED_MOVEMENT_CLOSE_ROUTE()
```

**返回值:** `void` (Native: `void`)

---

### ASSISTED_MOVEMENT_FLUSH_ROUTE

- **命名空间:** `PLAYER`
- **Hash:** `0x8621390F0CDCFE1F`
- **JHash:** `0xD04568B9`
- **Build:** `323`

**C# 签名:**
```csharp
void ASSISTED_MOVEMENT_FLUSH_ROUTE()
```

**返回值:** `void` (Native: `void`)

---

### CAN_PED_HEAR_PLAYER

- **命名空间:** `PLAYER`
- **Hash:** `0xF297383AA91DCA29`
- **JHash:** `0x1C70B2EB`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_PED_HEAR_PLAYER(int player, int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_PLAYER_START_MISSION

- **命名空间:** `PLAYER`
- **Hash:** `0xDE7465A27D403C06`
- **JHash:** `0x39E3CB3F`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_PLAYER_START_MISSION(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CHANGE_PLAYER_PED

- **命名空间:** `PLAYER`
- **Hash:** `0x048189FAC643DEEE`
- **JHash:** `0xBE515485`
- **Build:** `323`

**C# 签名:**
```csharp
void CHANGE_PLAYER_PED(int player, int ped, bool p2, bool resetDamage)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `ped` | `Ped` | `int` | - |
| `p2` | `BOOL` | `bool` | - |
| `resetDamage` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED

- **命名空间:** `PLAYER`
- **Hash:** `0x4AACB96203D11A31`
- **JHash:** `0x7E3BFBC5`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_PED

- **命名空间:** `PLAYER`
- **Hash:** `0xF0B67A4DE6AB5F98`
- **JHash:** `0x1D31CBBD`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_PED(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PLAYER_PARACHUTE_MODEL_OVERRIDE

- **命名空间:** `PLAYER`
- **Hash:** `0x8753997EB5F6EE3F`
- **JHash:** `0x6FF034BB`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PLAYER_PARACHUTE_MODEL_OVERRIDE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PLAYER_PARACHUTE_PACK_MODEL_OVERRIDE

- **命名空间:** `PLAYER`
- **Hash:** `0x10C54E4389C12B42`
- **JHash:** `0xBB62AAC5`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PLAYER_PARACHUTE_PACK_MODEL_OVERRIDE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PLAYER_PARACHUTE_VARIATION_OVERRIDE

- **命名空间:** `PLAYER`
- **Hash:** `0x0F4CC924CF8C7B21`
- **JHash:** `0xFD60F5AB`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PLAYER_PARACHUTE_VARIATION_OVERRIDE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE

- **命名空间:** `PLAYER`
- **Hash:** `0x290D248E25815AE8`
- **Build:** `2372`

**C# 签名:**
```csharp
void CLEAR_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_PLAYER_WANTED_LEVEL

- **命名空间:** `PLAYER`
- **Hash:** `0xB302540597885499`
- **JHash:** `0x54EA5BCC`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PLAYER_WANTED_LEVEL(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This executes at the same as speed as PLAYER::SET_PLAYER_WANTED_LEVEL(player, 0, false);

PLAYER::GET_PLAYER_WANTED_LEVEL(player); executes in less than half the time. Which means that it's worth first checking if the wanted level needs to be cleared before clearing. However, this is mostly about good code practice and can important in other situations. The difference in time in this example is negligible. 
```

---

### DISABLE_CAMERA_VIEW_MODE_CYCLE

- **命名空间:** `PLAYER`
- **Hash:** `0x5501B7A5CDB79D37`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_CAMERA_VIEW_MODE_CYCLE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DISABLE_PLAYER_FIRING

- **命名空间:** `PLAYER`
- **Hash:** `0x5E6CC07646BBEAB8`
- **JHash:** `0x30CB28CB`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_PLAYER_FIRING(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Inhibits the player from using any method of combat including melee and firearms.

NOTE: Only disables the firing for one frame
```

---

### DISABLE_PLAYER_HEALTH_RECHARGE

- **命名空间:** `PLAYER`
- **Hash:** `0xBCB06442F7E52666`
- **Build:** `2802`

**C# 签名:**
```csharp
void DISABLE_PLAYER_HEALTH_RECHARGE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Needs to be called every frame.
```

---

### DISABLE_PLAYER_THROW_GRENADE_WHILE_USING_GUN

- **命名空间:** `PLAYER`
- **Hash:** `0xB885852C39CC265D`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_PLAYER_THROW_GRENADE_WHILE_USING_GUN()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Used only once in R* scripts (freemode.ysc).
```

---

### DISABLE_PLAYER_VEHICLE_REWARDS

- **命名空间:** `PLAYER`
- **Hash:** `0xC142BE3BB9CE125F`
- **JHash:** `0x8C6E611D`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_PLAYER_VEHICLE_REWARDS(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DISPLAY_SYSTEM_SIGNIN_UI

- **命名空间:** `PLAYER`
- **Hash:** `0x94DD7888C10A979E`
- **JHash:** `0x4264CED2`
- **Build:** `323`

**C# 签名:**
```csharp
void DISPLAY_SYSTEM_SIGNIN_UI(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Purpose of the BOOL currently unknown.
Both, true and false, work
```

---

### ENABLE_SPECIAL_ABILITY

- **命名空间:** `PLAYER`
- **Hash:** `0x181EC197DAEFE121`
- **JHash:** `0xC86C1B4E`
- **Build:** `323`

**C# 签名:**
```csharp
void ENABLE_SPECIAL_ABILITY(int player, bool toggle, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### EXTEND_WORLD_BOUNDARY_FOR_PLAYER

- **命名空间:** `PLAYER`
- **Hash:** `0x5006D96C995A5827`
- **JHash:** `0x64DDB07D`
- **Build:** `323`

**C# 签名:**
```csharp
void EXTEND_WORLD_BOUNDARY_FOR_PLAYER(float x, float y, float z)
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
Appears only 3 times in the scripts, more specifically in michael1.ysc

-
This can be used to prevent dying if you are "out of the world"
```

---

### FORCE_CLEANUP

- **命名空间:** `PLAYER`
- **Hash:** `0xBC8983F38F78ED51`
- **JHash:** `0xFDAAEA2B`
- **Build:** `323`

**C# 签名:**
```csharp
void FORCE_CLEANUP(int cleanupFlags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cleanupFlags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
used with 1,2,8,64,128 in the scripts
```

---

### FORCE_CLEANUP_FOR_ALL_THREADS_WITH_THIS_NAME

- **命名空间:** `PLAYER`
- **Hash:** `0x4C68DDDDF0097317`
- **JHash:** `0x04256C73`
- **Build:** `323`

**C# 签名:**
```csharp
void FORCE_CLEANUP_FOR_ALL_THREADS_WITH_THIS_NAME(string name, int cleanupFlags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |
| `cleanupFlags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
PLAYER::FORCE_CLEANUP_FOR_ALL_THREADS_WITH_THIS_NAME("pb_prostitute", 1); // Found in decompilation
```

---

### FORCE_CLEANUP_FOR_THREAD_WITH_THIS_ID

- **命名空间:** `PLAYER`
- **Hash:** `0xF745B37630DF176B`
- **JHash:** `0x882D3EB3`
- **Build:** `323`

**C# 签名:**
```csharp
void FORCE_CLEANUP_FOR_THREAD_WITH_THIS_ID(int id, int cleanupFlags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `id` | `int` | `int` | - |
| `cleanupFlags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### FORCE_START_HIDDEN_EVASION

- **命名空间:** `PLAYER`
- **Hash:** `0xAD73CE5A09E42D12`
- **JHash:** `0x85725848`
- **Build:** `323`

**C# 签名:**
```csharp
void FORCE_START_HIDDEN_EVASION(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This has been found in use in the decompiled files.
```

---

### GET_ACHIEVEMENT_PROGRESS

- **命名空间:** `PLAYER`
- **Hash:** `0x1C186837D0619335`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_ACHIEVEMENT_PROGRESS(int achievementId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `achievementId` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
For Steam.
Always returns 0 in retail version of the game.
```

---

### GET_ARE_CAMERA_CONTROLS_DISABLED

- **命名空间:** `PLAYER`
- **Hash:** `0x7C814D2FB49F40C0`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_ARE_CAMERA_CONTROLS_DISABLED()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true when the player is not able to control the cam i.e. when running a benchmark test, switching the player or viewing a cutscene.

Note: I am not 100% sure if the native actually checks if the cam control is disabled but it seems promising.
```

---

### GET_CAUSE_OF_MOST_RECENT_FORCE_CLEANUP

- **命名空间:** `PLAYER`
- **Hash:** `0x9A41CF4674A12272`
- **JHash:** `0x39AA9FC8`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_CAUSE_OF_MOST_RECENT_FORCE_CLEANUP()
```

**返回值:** `int` (Native: `int`)

---

### GET_ENTITY_PLAYER_IS_FREE_AIMING_AT

- **命名空间:** `PLAYER`
- **Hash:** `0x2975C866E6713290`
- **JHash:** `0x8866D9D0`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_ENTITY_PLAYER_IS_FREE_AIMING_AT(int player, Entity* entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `entity` | `Entity*` | `Entity*` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns TRUE if it found an entity in your crosshair within range of your weapon. Assigns the handle of the target to the *entity that you pass it.
Returns false if no entity found.
```

---

### GET_IS_MOPPING_AREA_FREE_IN_FRONT_OF_PLAYER

- **命名空间:** `PLAYER`
- **Hash:** `0xDD2620B7B9D16FF1`
- **JHash:** `0x8CB53C9F`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_IS_MOPPING_AREA_FREE_IN_FRONT_OF_PLAYER(int player, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
2 occurrences in agency_heist3a. p1 was 0.7f then 0.4f.
```

---

### GET_IS_PLAYER_DRIVING_ON_HIGHWAY

- **命名空间:** `PLAYER`
- **Hash:** `0x5FC472C501CCADB3`
- **JHash:** `0x46E7E31D`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_IS_PLAYER_DRIVING_ON_HIGHWAY(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Appears once in "re_dealgonewrong"
```

---

### GET_IS_PLAYER_DRIVING_WRECKLESS

- **命名空间:** `PLAYER`
- **Hash:** `0xF10B44FD479D69F3`
- **JHash:** `0x1E359CC8`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_IS_PLAYER_DRIVING_WRECKLESS(int player, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Only 1 occurrence. p1 was 2.
```

---

### GET_IS_USING_FPS_THIRD_PERSON_COVER

- **命名空间:** `PLAYER`
- **Hash:** `0xB9CF1F793A9F1BF1`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_IS_USING_FPS_THIRD_PERSON_COVER()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns profile setting 237.
```

---

### GET_IS_USING_HOOD_CAMERA

- **命名空间:** `PLAYER`
- **Hash:** `0xCB645E85E97EA48B`
- **Build:** `372`

**C# 签名:**
```csharp
bool GET_IS_USING_HOOD_CAMERA()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns profile setting 243.
```

---

### GET_MAX_WANTED_LEVEL

- **命名空间:** `PLAYER`
- **Hash:** `0x462E0DB9B137DC5F`
- **JHash:** `0x457F1E44`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_MAX_WANTED_LEVEL()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Gets the maximum wanted level the player can get.
Ranges from 0 to 5.
```

---

### GET_NUMBER_OF_PLAYERS

- **命名空间:** `PLAYER`
- **Hash:** `0x407C7F91DDB46C16`
- **JHash:** `0x4C1B8867`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUMBER_OF_PLAYERS()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Gets the number of players in the current session.
If not multiplayer, always returns 1.
```

---

### GET_NUMBER_OF_PLAYERS_IN_TEAM

- **命名空间:** `PLAYER`
- **Hash:** `0x1FC200409F10E6F1`
- **Build:** `1180`

**C# 签名:**
```csharp
int GET_NUMBER_OF_PLAYERS_IN_TEAM(int team)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `team` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_PLAYERS_LAST_VEHICLE

- **命名空间:** `PLAYER`
- **Hash:** `0xB6997A7EB3F5C8C0`
- **JHash:** `0xE2757AC1`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PLAYERS_LAST_VEHICLE()
```

**返回值:** `int` (Native: `Vehicle`)

**说明:**
```
Alternative: GET_VEHICLE_PED_IS_IN(PLAYER_PED_ID(), 1);
```

---

### GET_PLAYER_CURRENT_STEALTH_NOISE

- **命名空间:** `PLAYER`
- **Hash:** `0x2F395D61F3A1F877`
- **JHash:** `0xC3B02362`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_PLAYER_CURRENT_STEALTH_NOISE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_PLAYER_DEBUG_INVINCIBLE

- **命名空间:** `PLAYER`
- **Hash:** `0xDCC07526B8EC45AF`
- **Build:** `1868`

**C# 签名:**
```csharp
bool GET_PLAYER_DEBUG_INVINCIBLE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Always returns false.
```

---

### GET_PLAYER_FAKE_WANTED_LEVEL

- **命名空间:** `PLAYER`
- **Hash:** `0x56105E599CAB0EFA`
- **JHash:** `0x0098D244`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PLAYER_FAKE_WANTED_LEVEL(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_PLAYER_GROUP

- **命名空间:** `PLAYER`
- **Hash:** `0x0D127585F77030AF`
- **JHash:** `0xA5EDCDE8`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PLAYER_GROUP(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns the group ID the player is member of.
```

---

### GET_PLAYER_HAS_RESERVE_PARACHUTE

- **命名空间:** `PLAYER`
- **Hash:** `0x5DDFE2FF727F3CA3`
- **JHash:** `0x30DA1DA1`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_PLAYER_HAS_RESERVE_PARACHUTE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_PLAYER_HEALTH_RECHARGE_MAX_PERCENT

- **命名空间:** `PLAYER`
- **Hash:** `0x8BC515BAE4AAF8FF`
- **Build:** `617`

**C# 签名:**
```csharp
float GET_PLAYER_HEALTH_RECHARGE_MAX_PERCENT(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_PLAYER_INDEX

- **命名空间:** `PLAYER`
- **Hash:** `0xA5EDC40EF369B48D`
- **JHash:** `0x309BBDC1`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PLAYER_INDEX()
```

**返回值:** `int` (Native: `Player`)

**说明:**
```
Returns the same as PLAYER_ID and NETWORK_PLAYER_ID_TO_INT
```

---

### GET_PLAYER_INVINCIBLE

- **命名空间:** `PLAYER`
- **Hash:** `0xB721981B2B939E07`
- **JHash:** `0x680C90EE`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_PLAYER_INVINCIBLE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns the Player's Invincible status.

This function will always return false if 0x733A643B5B0C53C1 is used to set the invincibility status. To always get the correct result, use this:

 bool IsPlayerInvincible(Player player)
    {
     auto addr = getScriptHandleBaseAddress(GET_PLAYER_PED(player)); 

        if (addr)
     {
         DWORD flag = *(DWORD *)(addr + 0x188);
            return ((flag & (1 << 8)) != 0) || ((flag & (1 << 9)) != 0);
      }

       return false;
 }


```

---

### GET_PLAYER_MAX_ARMOUR

- **命名空间:** `PLAYER`
- **Hash:** `0x92659B4CE1863CB3`
- **JHash:** `0x02A50657`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PLAYER_MAX_ARMOUR(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_PLAYER_NAME

- **命名空间:** `PLAYER`
- **Hash:** `0x6D0DE6A7B5DA71F8`
- **JHash:** `0x406B4B20`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_PLAYER_NAME(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `string` (Native: `const char*`)

---

### GET_PLAYER_PARACHUTE_MODEL_OVERRIDE

- **命名空间:** `PLAYER`
- **Hash:** `0xC219887CA3E65C41`
- **Build:** `2372`

**C# 签名:**
```csharp
uint GET_PLAYER_PARACHUTE_MODEL_OVERRIDE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `uint` (Native: `Hash`)

---

### GET_PLAYER_PARACHUTE_PACK_TINT_INDEX

- **命名空间:** `PLAYER`
- **Hash:** `0x6E9C742F340CE5A2`
- **JHash:** `0x4E418E13`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_PLAYER_PARACHUTE_PACK_TINT_INDEX(int player, ref int tintIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `tintIndex` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

---

### GET_PLAYER_PARACHUTE_SMOKE_TRAIL_COLOR

- **命名空间:** `PLAYER`
- **Hash:** `0xEF56DBABD3CD4887`
- **JHash:** `0xF66E5CDD`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_PLAYER_PARACHUTE_SMOKE_TRAIL_COLOR(int player, ref int r, ref int g, ref int b)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `r` | `int*` | `ref int` | - |
| `g` | `int*` | `ref int` | - |
| `b` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

---

### GET_PLAYER_PARACHUTE_TINT_INDEX

- **命名空间:** `PLAYER`
- **Hash:** `0x75D3F7A1B0D9B145`
- **JHash:** `0x432B0509`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_PLAYER_PARACHUTE_TINT_INDEX(int player, ref int tintIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `tintIndex` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Tints:
  None = -1,
    Rainbow = 0,
  Red = 1,
  SeasideStripes = 2,
   WidowMaker = 3,
   Patriot = 4,
  Blue = 5,
 Black = 6,
    Hornet = 7,
   AirFocce = 8,
 Desert = 9,
   Shadow = 10,
  HighAltitude = 11,
    Airbone = 12,
 Sunrise = 13,
```

---

### GET_PLAYER_PED

- **命名空间:** `PLAYER`
- **Hash:** `0x43A66C31C68491C0`
- **JHash:** `0x6E31E993`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PLAYER_PED(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `int` (Native: `Ped`)

**说明:**
```
Gets the ped for a specified player index.
```

---

### GET_PLAYER_PED_SCRIPT_INDEX

- **命名空间:** `PLAYER`
- **Hash:** `0x50FAC3A3E030A6E1`
- **JHash:** `0x6AC64990`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PLAYER_PED_SCRIPT_INDEX(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `int` (Native: `Ped`)

**说明:**
```
Does the same like PLAYER::GET_PLAYER_PED
```

---

### GET_PLAYER_RECEIVED_BATTLE_EVENT_RECENTLY

- **命名空间:** `PLAYER`
- **Hash:** `0xBC0753C9CA14B506`
- **JHash:** `0x9DF75B2A`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_PLAYER_RECEIVED_BATTLE_EVENT_RECENTLY(int player, int p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE

- **命名空间:** `PLAYER`
- **Hash:** `0x37FAAA68DCA9D08D`
- **Build:** `2372`

**C# 签名:**
```csharp
uint GET_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `uint` (Native: `Hash`)

---

### GET_PLAYER_RESERVE_PARACHUTE_TINT_INDEX

- **命名空间:** `PLAYER`
- **Hash:** `0xD5A016BC3C09CF40`
- **JHash:** `0x77B8EF01`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_PLAYER_RESERVE_PARACHUTE_TINT_INDEX(int player, ref int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `index` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Tints:
  None = -1,
    Rainbow = 0,
  Red = 1,
  SeasideStripes = 2,
   WidowMaker = 3,
   Patriot = 4,
  Blue = 5,
 Black = 6,
    Hornet = 7,
   AirFocce = 8,
 Desert = 9,
   Shadow = 10,
  HighAltitude = 11,
    Airbone = 12,
 Sunrise = 13,
```

---

### GET_PLAYER_RGB_COLOUR

- **命名空间:** `PLAYER`
- **Hash:** `0xE902EF951DCE178F`
- **JHash:** `0x6EF43BBB`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_PLAYER_RGB_COLOUR(int player, ref int r, ref int g, ref int b)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `r` | `int*` | `ref int` | - |
| `g` | `int*` | `ref int` | - |
| `b` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

---

### GET_PLAYER_SPRINT_STAMINA_REMAINING

- **命名空间:** `PLAYER`
- **Hash:** `0x3F9F16F8E65A7ED7`
- **JHash:** `0x47017C90`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_PLAYER_SPRINT_STAMINA_REMAINING(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_PLAYER_SPRINT_TIME_REMAINING

- **命名空间:** `PLAYER`
- **Hash:** `0x1885BC9B108B4C99`
- **JHash:** `0x40E80543`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_PLAYER_SPRINT_TIME_REMAINING(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_PLAYER_TARGETING_MODE

- **命名空间:** `PLAYER`
- **Hash:** `0x875BDD898B99C8CE`
- **Build:** `3570`

**C# 签名:**
```csharp
int GET_PLAYER_TARGETING_MODE()
```

**返回值:** `int` (Native: `int`)

---

### GET_PLAYER_TARGET_ENTITY

- **命名空间:** `PLAYER`
- **Hash:** `0x13EDE1A5DBF797C9`
- **JHash:** `0xF6AAA2D7`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_PLAYER_TARGET_ENTITY(int player, Entity* entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `entity` | `Entity*` | `Entity*` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Assigns the handle of locked-on melee target to *entity that you pass it.
Returns false if no entity found.
```

---

### GET_PLAYER_TEAM

- **命名空间:** `PLAYER`
- **Hash:** `0x37039302F4E0A008`
- **JHash:** `0x9873E404`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PLAYER_TEAM(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Gets the player's team.
Does nothing in singleplayer.
```

---

### GET_PLAYER_UNDERWATER_TIME_REMAINING

- **命名空间:** `PLAYER`
- **Hash:** `0xA1FCF8E6AF40B731`
- **JHash:** `0x1317125A`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_PLAYER_UNDERWATER_TIME_REMAINING(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_PLAYER_WANTED_CENTRE_POSITION

- **命名空间:** `PLAYER`
- **Hash:** `0x0C92BA89F1AF26F8`
- **JHash:** `0x821F2D2C`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_PLAYER_WANTED_CENTRE_POSITION(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

---

### GET_PLAYER_WANTED_LEVEL

- **命名空间:** `PLAYER`
- **Hash:** `0xE28E54788CE8F12D`
- **JHash:** `0xBDCDD163`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PLAYER_WANTED_LEVEL(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_TIME_SINCE_LAST_ARREST

- **命名空间:** `PLAYER`
- **Hash:** `0x5063F92F07C2A316`
- **JHash:** `0x62824EF4`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_TIME_SINCE_LAST_ARREST()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns the time since the character was arrested in (ms) milliseconds.

example

var time = Function.call<int>(Hash.GET_TIME_SINCE_LAST_ARREST();

UI.DrawSubtitle(time.ToString());

if player has not been arrested, the int returned will be -1.
```

---

### GET_TIME_SINCE_LAST_DEATH

- **命名空间:** `PLAYER`
- **Hash:** `0xC7034807558DDFCA`
- **JHash:** `0x24BC5AC0`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_TIME_SINCE_LAST_DEATH()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns the time since the character died in (ms) milliseconds.

example

var time = Function.call<int>(Hash.GET_TIME_SINCE_LAST_DEATH();

UI.DrawSubtitle(time.ToString());

if player has not died, the int returned will be -1.
```

---

### GET_TIME_SINCE_PLAYER_DROVE_AGAINST_TRAFFIC

- **命名空间:** `PLAYER`
- **Hash:** `0xDB89591E290D9182`
- **JHash:** `0x9F27D00E`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_TIME_SINCE_PLAYER_DROVE_AGAINST_TRAFFIC(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_TIME_SINCE_PLAYER_DROVE_ON_PAVEMENT

- **命名空间:** `PLAYER`
- **Hash:** `0xD559D2BE9E37853B`
- **JHash:** `0x8836E732`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_TIME_SINCE_PLAYER_DROVE_ON_PAVEMENT(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_TIME_SINCE_PLAYER_HIT_PED

- **命名空间:** `PLAYER`
- **Hash:** `0xE36A25322DC35F42`
- **JHash:** `0xB6209195`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_TIME_SINCE_PLAYER_HIT_PED(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_TIME_SINCE_PLAYER_HIT_VEHICLE

- **命名空间:** `PLAYER`
- **Hash:** `0x5D35ECF3A81A0EE0`
- **JHash:** `0x6E9B8B9E`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_TIME_SINCE_PLAYER_HIT_VEHICLE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_WANTED_LEVEL_RADIUS

- **命名空间:** `PLAYER`
- **Hash:** `0x085DEB493BE80812`
- **JHash:** `0x1CF7D7DA`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_WANTED_LEVEL_RADIUS(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Remnant from GTA IV. Does nothing in GTA V.
```

---

### GET_WANTED_LEVEL_THRESHOLD

- **命名空间:** `PLAYER`
- **Hash:** `0xFDD179EAF45B556C`
- **JHash:** `0xD9783F6B`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_WANTED_LEVEL_THRESHOLD(int wantedLevel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `wantedLevel` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Drft
```

---

### GET_WANTED_LEVEL_TIME_TO_ESCAPE

- **命名空间:** `PLAYER`
- **Hash:** `0xA72200F51875FEA4`
- **Build:** `2372`

**C# 签名:**
```csharp
int GET_WANTED_LEVEL_TIME_TO_ESCAPE()
```

**返回值:** `int` (Native: `int`)

---

### GIVE_ACHIEVEMENT_TO_PLAYER

- **命名空间:** `PLAYER`
- **Hash:** `0xBEC7076D64130195`
- **JHash:** `0x822BC992`
- **Build:** `323`

**C# 签名:**
```csharp
bool GIVE_ACHIEVEMENT_TO_PLAYER(int achievementId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `achievementId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
1 - Welcome to Los Santos
2 - A Friendship Resurrected
3 - A Fair Day's Pay
4 - The Moment of Truth
5 - To Live or Die in Los Santos
6 - Diamond Hard
7 - Subversive
8 - Blitzed
9 - Small Town, Big Job
10 - The Government Gimps
11 - The Big One!
12 - Solid Gold, Baby!
13 - Career Criminal
14 - San Andreas Sightseer
15 - All's Fare in Love and War
16 - TP Industries Arms Race
17 - Multi-Disciplined
18 - From Beyond the Stars
19 - A Mystery, Solved
20 - Waste Management
21 - Red Mist
22 - Show Off
23 - Kifflom!
24 - Three Man Army
25 - Out of Your Depth
26 - Altruist Acolyte
27 - A Lot of Cheddar
28 - Trading Pure Alpha
29 - Pimp My Sidearm
30 - Wanted: Alive Or Alive
31 - Los Santos Customs
32 - Close Shave
33 - Off the Plane
34 - Three-Bit Gangster
35 - Making Moves
36 - Above the Law
37 - Numero Uno
38 - The Midnight Club
39 - Unnatural Selection
40 - Backseat Driver
41 - Run Like The Wind
42 - Clean Sweep
43 - Decorated
44 - Stick Up Kid
45 - Enjoy Your Stay
46 - Crew Cut
47 - Full Refund
48 - Dialling Digits
49 - American Dream
50 - A New Perspective
51 - Be Prepared
52 - In the Name of Science
53 - Dead Presidents
54 - Parole Day
55 - Shot Caller
56 - Four Way
57 - Live a Little
58 - Can't Touch This
59 - Mastermind
60 - Vinewood Visionary
61 - Majestic
62 - Humans of Los Santos
63 - First Time Director
64 - Animal Lover
65 - Ensemble Piece
66 - Cult Movie
67 - Location Scout
68 - Method Actor
69 - Cryptozoologist
70 - Getting Started
71 - The Data Breaches
72 - The Bogdan Problem
73 - The Doomsday Scenario
74 - A World Worth Saving
75 - Orbital Obliteration
76 - Elitist
77 - Masterminds
```

---

### GIVE_PLAYER_RAGDOLL_CONTROL

- **命名空间:** `PLAYER`
- **Hash:** `0x3C49C870E66F0A28`
- **JHash:** `0xC7B4D7AC`
- **Build:** `323`

**C# 签名:**
```csharp
void GIVE_PLAYER_RAGDOLL_CONTROL(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### HAS_ACHIEVEMENT_BEEN_PASSED

- **命名空间:** `PLAYER`
- **Hash:** `0x867365E111A3B6EB`
- **JHash:** `0x136A5BE9`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_ACHIEVEMENT_BEEN_PASSED(int achievementId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `achievementId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
See GIVE_ACHIEVEMENT_TO_PLAYER
```

---

### HAS_FORCE_CLEANUP_OCCURRED

- **命名空间:** `PLAYER`
- **Hash:** `0xC968670BFACE42D9`
- **JHash:** `0x4B37333C`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_FORCE_CLEANUP_OCCURRED(int cleanupFlags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cleanupFlags` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_PLAYER_BEEN_SPOTTED_IN_STOLEN_VEHICLE

- **命名空间:** `PLAYER`
- **Hash:** `0xD705740BB0A1CF4C`
- **JHash:** `0x4A01B76A`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_PLAYER_BEEN_SPOTTED_IN_STOLEN_VEHICLE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_PLAYER_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED

- **命名空间:** `PLAYER`
- **Hash:** `0xE4B90F367BD81752`
- **JHash:** `0xA3707DFC`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_PLAYER_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_PLAYER_DAMAGED_AT_LEAST_ONE_PED

- **命名空间:** `PLAYER`
- **Hash:** `0x20CE80B0C2BF4ACC`
- **JHash:** `0x14F52453`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_PLAYER_DAMAGED_AT_LEAST_ONE_PED(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_PLAYER_LEFT_THE_WORLD

- **命名空间:** `PLAYER`
- **Hash:** `0xD55DDFB47991A294`
- **JHash:** `0xFEA40B6C`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_PLAYER_LEFT_THE_WORLD(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### INCREASE_PLAYER_JUMP_SUPPRESSION_RANGE

- **命名空间:** `PLAYER`
- **Hash:** `0x9EDD76E87D5D51BA`
- **JHash:** `0xE30A64DC`
- **Build:** `323`

**C# 签名:**
```csharp
void INCREASE_PLAYER_JUMP_SUPPRESSION_RANGE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### INT_TO_PARTICIPANTINDEX

- **命名空间:** `PLAYER`
- **Hash:** `0x9EC6603812C24710`
- **JHash:** `0x98F3B274`
- **Build:** `323`

**C# 签名:**
```csharp
int INT_TO_PARTICIPANTINDEX(int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Simply returns whatever is passed to it (Regardless of whether the handle is valid or not).
--------------------------------------------------------
if (NETWORK::NETWORK_IS_PARTICIPANT_ACTIVE(PLAYER::INT_TO_PARTICIPANTINDEX(i)))

```

---

### INT_TO_PLAYERINDEX

- **命名空间:** `PLAYER`
- **Hash:** `0x41BD2A6B006AF756`
- **JHash:** `0x98DD98F1`
- **Build:** `323`

**C# 签名:**
```csharp
int INT_TO_PLAYERINDEX(int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `int` | `int` | - |

**返回值:** `int` (Native: `Player`)

**说明:**
```
Simply returns whatever is passed to it (Regardless of whether the handle is valid or not).
```

---

### IS_PLAYER_BATTLE_AWARE

- **命名空间:** `PLAYER`
- **Hash:** `0x38D28DA81E4E9BF9`
- **JHash:** `0x013B4F72`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_BATTLE_AWARE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if an unk value is greater than 0.0f
```

---

### IS_PLAYER_BEING_ARRESTED

- **命名空间:** `PLAYER`
- **Hash:** `0x388A47C51ABDAC8E`
- **JHash:** `0x7F6A60D3`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_BEING_ARRESTED(int player, bool atArresting)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `atArresting` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Return true while player is being arrested / busted.

If atArresting is set to 1, this function will return 1 when player is being arrested (while player is putting his hand up, but still have control)

If atArresting is set to 0, this function will return 1 only when the busted screen is shown.
```

---

### IS_PLAYER_BLUETOOTH_ENABLE

- **命名空间:** `PLAYER`
- **Hash:** `0x65FAEE425DE637B0`
- **JHash:** `0xEA01BD4A`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_BLUETOOTH_ENABLE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PLAYER_CLIMBING

- **命名空间:** `PLAYER`
- **Hash:** `0x95E8F73DC65EFB9C`
- **JHash:** `0x4A9E9AE0`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_CLIMBING(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns TRUE if the player ('s ped) is climbing at the moment.
```

---

### IS_PLAYER_CONTROL_ON

- **命名空间:** `PLAYER`
- **Hash:** `0x49C32D60007AFA47`
- **JHash:** `0x618857F2`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_CONTROL_ON(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Can the player control himself, used to disable controls for player for things like a cutscene.

---

You can't disable controls with this, use SET_PLAYER_CONTROL(...) for this. 
```

---

### IS_PLAYER_DEAD

- **命名空间:** `PLAYER`
- **Hash:** `0x424D4687FA1E5652`
- **JHash:** `0x140CA5A8`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_DEAD(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PLAYER_FREE_AIMING

- **命名空间:** `PLAYER`
- **Hash:** `0x2E397FD2ECD37C87`
- **JHash:** `0x1DEC67B7`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_FREE_AIMING(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Gets a value indicating whether the specified player is currently aiming freely.
```

---

### IS_PLAYER_FREE_AIMING_AT_ENTITY

- **命名空间:** `PLAYER`
- **Hash:** `0x3C06B5C839B38F7B`
- **JHash:** `0x7D80EEAA`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_FREE_AIMING_AT_ENTITY(int player, int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Gets a value indicating whether the specified player is currently aiming freely at the specified entity.
```

---

### IS_PLAYER_FREE_FOR_AMBIENT_TASK

- **命名空间:** `PLAYER`
- **Hash:** `0xDCCFD3F106C36AB4`
- **JHash:** `0x85C7E232`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_FREE_FOR_AMBIENT_TASK(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PLAYER_LOGGING_IN_NP

- **命名空间:** `PLAYER`
- **Hash:** `0x74556E1420867ECA`
- **JHash:** `0x8F72FAD0`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_LOGGING_IN_NP()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
this function is hard-coded to always return 0.
```

---

### IS_PLAYER_ONLINE

- **命名空间:** `PLAYER`
- **Hash:** `0xF25D331DC2627BBC`
- **JHash:** `0x9FAB6729`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_ONLINE()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns TRUE if the game is in online mode and FALSE if in offline mode.

This is an alias for NETWORK_IS_SIGNED_ONLINE.
```

---

### IS_PLAYER_PLAYING

- **命名空间:** `PLAYER`
- **Hash:** `0x5E9564D8246B909A`
- **JHash:** `0xE15D777F`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_PLAYING(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Checks whether the specified player has a Ped, the Ped is not dead, is not injured and is not arrested.
```

---

### IS_PLAYER_PRESSING_HORN

- **命名空间:** `PLAYER`
- **Hash:** `0xFA1E2BF8B10598F9`
- **JHash:** `0xED1D1662`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_PRESSING_HORN(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PLAYER_READY_FOR_CUTSCENE

- **命名空间:** `PLAYER`
- **Hash:** `0x908CBECC2CAA3690`
- **JHash:** `0xBB77E9CD`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_READY_FOR_CUTSCENE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PLAYER_RIDING_TRAIN

- **命名空间:** `PLAYER`
- **Hash:** `0x4EC12697209F2196`
- **JHash:** `0x9765E71D`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_RIDING_TRAIN(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if the player is riding a train.
```

---

### IS_PLAYER_SCRIPT_CONTROL_ON

- **命名空间:** `PLAYER`
- **Hash:** `0x8A876A65283DD7D7`
- **JHash:** `0x61B00A84`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_SCRIPT_CONTROL_ON(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PLAYER_TARGETTING_ANYTHING

- **命名空间:** `PLAYER`
- **Hash:** `0x78CFE51896B6B8A4`
- **JHash:** `0x456DB50D`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_TARGETTING_ANYTHING(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PLAYER_TARGETTING_ENTITY

- **命名空间:** `PLAYER`
- **Hash:** `0x7912F7FC4F6264B6`
- **JHash:** `0xF3240B77`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_TARGETTING_ENTITY(int player, int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PLAYER_TELEPORT_ACTIVE

- **命名空间:** `PLAYER`
- **Hash:** `0x02B15662D7F8886F`
- **JHash:** `0x3A11D118`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_TELEPORT_ACTIVE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PLAYER_VEHICLE_WEAPON_TOGGLED_TO_NON_HOMING

- **命名空间:** `PLAYER`
- **Hash:** `0x6E4361FF3E8CD7CA`
- **Build:** `1011`

**C# 签名:**
```csharp
bool IS_PLAYER_VEHICLE_WEAPON_TOGGLED_TO_NON_HOMING(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PLAYER_WANTED_LEVEL_GREATER

- **命名空间:** `PLAYER`
- **Hash:** `0x238DB2A2C23EE9EF`
- **JHash:** `0x589A2661`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_WANTED_LEVEL_GREATER(int player, int wantedLevel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `wantedLevel` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_REMOTE_PLAYER_IN_NON_CLONED_VEHICLE

- **命名空间:** `PLAYER`
- **Hash:** `0x690A61A6D13583F6`
- **JHash:** `0x1D371529`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_REMOTE_PLAYER_IN_NON_CLONED_VEHICLE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SPECIAL_ABILITY_ACTIVE

- **命名空间:** `PLAYER`
- **Hash:** `0x3E5F7FC85D854E15`
- **JHash:** `0x1B17E334`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SPECIAL_ABILITY_ACTIVE(int player, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SPECIAL_ABILITY_ENABLED

- **命名空间:** `PLAYER`
- **Hash:** `0xB1D200FE26AEF3CB`
- **JHash:** `0xC01238CC`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SPECIAL_ABILITY_ENABLED(int player, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SPECIAL_ABILITY_METER_FULL

- **命名空间:** `PLAYER`
- **Hash:** `0x05A1FE504B7F2587`
- **JHash:** `0x2E19D7F6`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SPECIAL_ABILITY_METER_FULL(int player, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SPECIAL_ABILITY_UNLOCKED

- **命名空间:** `PLAYER`
- **Hash:** `0xC6017F6A6CDFA694`
- **JHash:** `0xC9C75E82`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SPECIAL_ABILITY_UNLOCKED(uint playerModel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `playerModel` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SYSTEM_UI_BEING_DISPLAYED

- **命名空间:** `PLAYER`
- **Hash:** `0x5D511E3867C87139`
- **JHash:** `0xE495B6DA`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SYSTEM_UI_BEING_DISPLAYED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_WANTED_AND_HAS_BEEN_SEEN_BY_COPS

- **命名空间:** `PLAYER`
- **Hash:** `0x7E07C78925D5FD96`
- **Build:** `372`

**C# 签名:**
```csharp
bool IS_WANTED_AND_HAS_BEEN_SEEN_BY_COPS(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_PLAYER_ID_TO_INT

- **命名空间:** `PLAYER`
- **Hash:** `0xEE68096F9F37341E`
- **JHash:** `0x8DD5B838`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_PLAYER_ID_TO_INT()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Does exactly the same thing as PLAYER_ID()
```

---

### PLAYER_ATTACH_VIRTUAL_BOUND

- **命名空间:** `PLAYER`
- **Hash:** `0xED51733DC73AED51`
- **JHash:** `0xECD12E60`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYER_ATTACH_VIRTUAL_BOUND(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7)
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

**返回值:** `void` (Native: `void`)

**说明:**
```
Only 1 match. ob_sofa_michael.

PLAYER::PLAYER_ATTACH_VIRTUAL_BOUND(-804.5928f, 173.1801f, 71.68436f, 0f, 0f, 0.590625f, 1f, 0.7f);1.0.335.2, 1.0.350.1/2, 1.0.372.2, 1.0.393.2, 1.0.393.4, 1.0.463.1;
```

---

### PLAYER_DETACH_VIRTUAL_BOUND

- **命名空间:** `PLAYER`
- **Hash:** `0x1DD5897E2FA6E7C9`
- **JHash:** `0x96100EA4`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYER_DETACH_VIRTUAL_BOUND()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
1.0.335.2, 1.0.350.1/2, 1.0.372.2, 1.0.393.2, 1.0.393.4, 1.0.463.1;
```

---

### PLAYER_ID

- **命名空间:** `PLAYER`
- **Hash:** `0x4F8644AF03D0E0D6`
- **JHash:** `0x8AEA886C`
- **Build:** `323`

**C# 签名:**
```csharp
int PLAYER_ID()
```

**返回值:** `int` (Native: `Player`)

**说明:**
```
This returns YOUR 'identity' as a Player type.

Always returns 0 in story mode.
```

---

### PLAYER_PED_ID

- **命名空间:** `PLAYER`
- **Hash:** `0xD80958FC74E988A6`
- **JHash:** `0xFA92E226`
- **Build:** `323`

**C# 签名:**
```csharp
int PLAYER_PED_ID()
```

**返回值:** `int` (Native: `Ped`)

**说明:**
```
Returns current player ped
```

---

### REMOVE_PLAYER_HELMET

- **命名空间:** `PLAYER`
- **Hash:** `0xF3AC26D3CC576528`
- **JHash:** `0x6255F3B4`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_PLAYER_HELMET(int player, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_PLAYER_TARGETABLE_ENTITY

- **命名空间:** `PLAYER`
- **Hash:** `0x9F260BFB59ADBCA3`
- **Build:** `1868`

**C# 签名:**
```csharp
void REMOVE_PLAYER_TARGETABLE_ENTITY(int player, int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_SCRIPT_FIRE_POSITION

- **命名空间:** `PLAYER`
- **Hash:** `0x7148E0F43D11F0D9`
- **Build:** `1604`

**C# 签名:**
```csharp
void REMOVE_SCRIPT_FIRE_POSITION()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Resets values set by SET_SCRIPT_FIRE_POSITION
```

---

### REPORT_CRIME

- **命名空间:** `PLAYER`
- **Hash:** `0xE9B09589827545E7`
- **JHash:** `0xD8EB3A44`
- **Build:** `323`

**C# 签名:**
```csharp
void REPORT_CRIME(int player, int crimeType, int wantedLvlThresh)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `crimeType` | `int` | `int` | - |
| `wantedLvlThresh` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
PLAYER::REPORT_CRIME(PLAYER::PLAYER_ID(), 37, PLAYER::GET_WANTED_LEVEL_THRESHOLD(1));

From am_armybase.ysc.c4:

PLAYER::REPORT_CRIME(PLAYER::PLAYER_ID(4), 36, PLAYER::GET_WANTED_LEVEL_THRESHOLD(4));

-----

This was taken from the GTAV.exe v1.334. The function is called sub_140592CE8. For a full decompilation of the function, see here: https://pastebin.com/09qSMsN7 

-----
crimeType:
1: Firearms possession
2: Person running a red light ("5-0-5")
3: Reckless driver
4: Speeding vehicle (a "5-10")
5: Traffic violation (a "5-0-5")
6: Motorcycle rider without a helmet
7: Vehicle theft (a "5-0-3")
8: Grand Theft Auto
9: ???
10: ???
11: Assault on a civilian (a "2-40")
12: Assault on an officer
13: Assault with a deadly weapon (a "2-45")
14: Officer shot (a "2-45")
15: Pedestrian struck by a vehicle
16: Officer struck by a vehicle
17: Helicopter down (an "AC"?)
18: Civilian on fire (a "2-40")
19: Officer set on fire (a "10-99")
20: Car on fire
21: Air unit down (an "AC"?)
22: An explosion (a "9-96")
23: A stabbing (a "2-45") (also something else I couldn't understand)
24: Officer stabbed (also something else I couldn't understand)
25: Attack on a vehicle ("MDV"?)
26: Damage to property
27: Suspect threatening officer with a firearm
28: Shots fired
29: ???
30: ???
31: ???
32: ???
33: ???
34: A "2-45"
35: ???
36: A "9-25"
37: ???
38: ???
39: ???
40: ???
41: ???
42: ???
43: Possible disturbance
44: Civilian in need of assistance
45: ???
46: ???
```

---

### REPORT_POLICE_SPOTTED_PLAYER

- **命名空间:** `PLAYER`
- **Hash:** `0xDC64D2C53493ED12`
- **JHash:** `0xD15C4B1C`
- **Build:** `323`

**C# 签名:**
```csharp
void REPORT_POLICE_SPOTTED_PLAYER(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESET_LAW_RESPONSE_DELAY_OVERRIDE

- **命名空间:** `PLAYER`
- **Hash:** `0x0032A6DBA562C518`
- **JHash:** `0x47CAB814`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_LAW_RESPONSE_DELAY_OVERRIDE()
```

**返回值:** `void` (Native: `void`)

---

### RESET_PLAYER_ARREST_STATE

- **命名空间:** `PLAYER`
- **Hash:** `0x2D03E13C460760D6`
- **JHash:** `0x453C7CAB`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_PLAYER_ARREST_STATE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESET_PLAYER_INPUT_GAIT

- **命名空间:** `PLAYER`
- **Hash:** `0x19531C47A2ABD691`
- **JHash:** `0x4A701EE1`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_PLAYER_INPUT_GAIT(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESET_PLAYER_STAMINA

- **命名空间:** `PLAYER`
- **Hash:** `0xA6F312FCCE9C1DFE`
- **JHash:** `0xC0445A9C`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_PLAYER_STAMINA(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESET_WANTED_LEVEL_DIFFICULTY

- **命名空间:** `PLAYER`
- **Hash:** `0xB9D0DD990DC141DD`
- **JHash:** `0xA64C378D`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_WANTED_LEVEL_DIFFICULTY(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESET_WANTED_LEVEL_HIDDEN_ESCAPE_TIME

- **命名空间:** `PLAYER`
- **Hash:** `0x823EC8E82BA45986`
- **Build:** `2060`

**C# 签名:**
```csharp
void RESET_WANTED_LEVEL_HIDDEN_ESCAPE_TIME(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESET_WORLD_BOUNDARY_FOR_PLAYER

- **命名空间:** `PLAYER`
- **Hash:** `0xDA1DF03D5A315F4E`
- **JHash:** `0xA97C2F6C`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_WORLD_BOUNDARY_FOR_PLAYER()
```

**返回值:** `void` (Native: `void`)

---

### RESTORE_PLAYER_STAMINA

- **命名空间:** `PLAYER`
- **Hash:** `0xA352C1B864CAFD33`
- **JHash:** `0x62A93608`
- **Build:** `323`

**C# 签名:**
```csharp
void RESTORE_PLAYER_STAMINA(int player, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ACHIEVEMENT_PROGRESS

- **命名空间:** `PLAYER`
- **Hash:** `0xC2AFFFDABBDC2C5C`
- **Build:** `323`

**C# 签名:**
```csharp
bool SET_ACHIEVEMENT_PROGRESS(int achievementId, int progress)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `achievementId` | `int` | `int` | - |
| `progress` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
For Steam.
Does nothing and always returns false in the retail version of the game.
```

---

### SET_AIR_DRAG_MULTIPLIER_FOR_PLAYERS_VEHICLE

- **命名空间:** `PLAYER`
- **Hash:** `0xCA7DC8329F0A1E9E`
- **JHash:** `0xF20F72E5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AIR_DRAG_MULTIPLIER_FOR_PLAYERS_VEHICLE(int player, float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This can be between 1.0f - 14.9f 

You can change the max in IDA from 15.0. I say 15.0 as the function blrs if what you input is greater than or equal to 15.0 hence why it's 14.9 max default.


```

---

### SET_ALL_NEUTRAL_RANDOM_PEDS_FLEE

- **命名空间:** `PLAYER`
- **Hash:** `0xDE45D1A1EF45EE61`
- **JHash:** `0x274631FE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ALL_NEUTRAL_RANDOM_PEDS_FLEE(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ALL_NEUTRAL_RANDOM_PEDS_FLEE_THIS_FRAME

- **命名空间:** `PLAYER`
- **Hash:** `0xC3376F42B1FACCC6`
- **JHash:** `0x02DF7AF4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ALL_NEUTRAL_RANDOM_PEDS_FLEE_THIS_FRAME(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
- This is called after SET_ALL_RANDOM_PEDS_FLEE_THIS_FRAME

```

---

### SET_ALL_RANDOM_PEDS_FLEE

- **命名空间:** `PLAYER`
- **Hash:** `0x056E0FE8534C2949`
- **JHash:** `0x49EAE968`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ALL_RANDOM_PEDS_FLEE(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ALL_RANDOM_PEDS_FLEE_THIS_FRAME

- **命名空间:** `PLAYER`
- **Hash:** `0x471D2FF42A94B4F2`
- **JHash:** `0xBF974891`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ALL_RANDOM_PEDS_FLEE_THIS_FRAME(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_APPLY_WAYPOINT_OF_PLAYER

- **命名空间:** `PLAYER`
- **Hash:** `0x2382AB11450AE7BA`
- **Build:** `877`

**C# 签名:**
```csharp
void SET_APPLY_WAYPOINT_OF_PLAYER(int player, int hudColor)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `hudColor` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_AUTO_GIVE_PARACHUTE_WHEN_ENTER_PLANE

- **命名空间:** `PLAYER`
- **Hash:** `0x9F343285A00B4BB6`
- **JHash:** `0xA97C2059`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AUTO_GIVE_PARACHUTE_WHEN_ENTER_PLANE(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_AUTO_GIVE_SCUBA_GEAR_WHEN_EXIT_VEHICLE

- **命名空间:** `PLAYER`
- **Hash:** `0xD2B315B6689D537D`
- **JHash:** `0xA25D767E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AUTO_GIVE_SCUBA_GEAR_WHEN_EXIT_VEHICLE(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DISABLE_AMBIENT_MELEE_MOVE

- **命名空间:** `PLAYER`
- **Hash:** `0x2E8AABFA40A84F8C`
- **JHash:** `0xCCD937E7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DISABLE_AMBIENT_MELEE_MOVE(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DISPATCH_COPS_FOR_PLAYER

- **命名空间:** `PLAYER`
- **Hash:** `0xDB172424876553F4`
- **JHash:** `0x48A18913`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DISPATCH_COPS_FOR_PLAYER(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_EVERYONE_IGNORE_PLAYER

- **命名空间:** `PLAYER`
- **Hash:** `0x8EEDA153AD141BA4`
- **JHash:** `0xC915285E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_EVERYONE_IGNORE_PLAYER(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_IGNORE_LOW_PRIORITY_SHOCKING_EVENTS

- **命名空间:** `PLAYER`
- **Hash:** `0x596976B02B6B5700`
- **JHash:** `0xA3D675ED`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_IGNORE_LOW_PRIORITY_SHOCKING_EVENTS(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_LAW_PEDS_CAN_ATTACK_NON_WANTED_PLAYER_THIS_FRAME

- **命名空间:** `PLAYER`
- **Hash:** `0xFAC75988A7D078D3`
- **Build:** `463`

**C# 签名:**
```csharp
void SET_LAW_PEDS_CAN_ATTACK_NON_WANTED_PLAYER_THIS_FRAME(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_LAW_RESPONSE_DELAY_OVERRIDE

- **命名空间:** `PLAYER`
- **Hash:** `0xB45EFF719D8427A6`
- **JHash:** `0xBF6993C7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_LAW_RESPONSE_DELAY_OVERRIDE(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
PLAYER::SET_LAW_RESPONSE_DELAY_OVERRIDE(rPtr((&l_122) + 71)); // Found in decompilation

***

In "am_hold_up.ysc" used once:

l_8d._f47 = MISC::GET_RANDOM_FLOAT_IN_RANGE(18.0, 28.0);
PLAYER::SET_LAW_RESPONSE_DELAY_OVERRIDE((l_8d._f47));
```

---

### SET_MAX_WANTED_LEVEL

- **命名空间:** `PLAYER`
- **Hash:** `0xAA5F02DB48D704B9`
- **JHash:** `0x665A06F5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_MAX_WANTED_LEVEL(int maxWantedLevel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `maxWantedLevel` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_BLUETOOTH_STATE

- **命名空间:** `PLAYER`
- **Hash:** `0x5DC40A8869C22141`
- **JHash:** `0x7A6B0EF8`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_BLUETOOTH_STATE(int player, bool state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `state` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_CAN_BE_HASSLED_BY_GANGS

- **命名空间:** `PLAYER`
- **Hash:** `0xD5E460AD7020A246`
- **JHash:** `0x71B305BB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_CAN_BE_HASSLED_BY_GANGS(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets whether this player can be hassled by gangs.
```

---

### SET_PLAYER_CAN_COLLECT_DROPPED_MONEY

- **命名空间:** `PLAYER`
- **Hash:** `0xCAC57395B151135F`
- **JHash:** `0x00563E0D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_CAN_COLLECT_DROPPED_MONEY(int player, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_CAN_DAMAGE_PLAYER

- **命名空间:** `PLAYER`
- **Hash:** `0x55FCC0C390620314`
- **Build:** `573`

**C# 签名:**
```csharp
void SET_PLAYER_CAN_DAMAGE_PLAYER(int player1, int player2, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player1` | `Player` | `int` | - |
| `player2` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_CAN_DO_DRIVE_BY

- **命名空间:** `PLAYER`
- **Hash:** `0x6E8834B52EC20C77`
- **JHash:** `0xF4D99685`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_CAN_DO_DRIVE_BY(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Set whether this player should be able to do drive-bys.

"A drive-by is when a ped is aiming/shooting from vehicle. This includes middle finger taunts. By setting this value to false I confirm the player is unable to do all that. Tested on tick."

```

---

### SET_PLAYER_CAN_LEAVE_PARACHUTE_SMOKE_TRAIL

- **命名空间:** `PLAYER`
- **Hash:** `0xF401B182DBA8AF53`
- **JHash:** `0x832DEB7A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_CAN_LEAVE_PARACHUTE_SMOKE_TRAIL(int player, bool enabled)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `enabled` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_CAN_USE_COVER

- **命名空间:** `PLAYER`
- **Hash:** `0xD465A8599DFF6814`
- **JHash:** `0x13CAFAFA`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_CAN_USE_COVER(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets whether this player can take cover.
```

---

### SET_PLAYER_CLOTH_LOCK_COUNTER

- **命名空间:** `PLAYER`
- **Hash:** `0x14D913B777DFF5DA`
- **JHash:** `0x8D9FD4D1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_CLOTH_LOCK_COUNTER(int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
6 matches across 4 scripts. 5 occurrences were 240. The other was 255.
```

---

### SET_PLAYER_CLOTH_PACKAGE_INDEX

- **命名空间:** `PLAYER`
- **Hash:** `0x9F7BBA2EA6372500`
- **JHash:** `0xB8209F16`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_CLOTH_PACKAGE_INDEX(int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Every occurrence was either 0 or 2.
```

---

### SET_PLAYER_CLOTH_PIN_FRAMES

- **命名空间:** `PLAYER`
- **Hash:** `0x749FADDF97DFE930`
- **JHash:** `0xF7A0F00F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_CLOTH_PIN_FRAMES(int player, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_CONTROL

- **命名空间:** `PLAYER`
- **Hash:** `0x8D32347D6D4C40A2`
- **JHash:** `0xD17AFCD8`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_CONTROL(int player, bool bHasControl, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `bHasControl` | `BOOL` | `bool` | - |
| `flags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Flags:
SPC_AMBIENT_SCRIPT = (1 << 1),
SPC_CLEAR_TASKS = (1 << 2),
SPC_REMOVE_FIRES = (1 << 3),
SPC_REMOVE_EXPLOSIONS = (1 << 4),
SPC_REMOVE_PROJECTILES = (1 << 5),
SPC_DEACTIVATE_GADGETS = (1 << 6),
SPC_REENABLE_CONTROL_ON_DEATH = (1 << 7),
SPC_LEAVE_CAMERA_CONTROL_ON = (1 << 8),
SPC_ALLOW_PLAYER_DAMAGE = (1 << 9),
SPC_DONT_STOP_OTHER_CARS_AROUND_PLAYER = (1 << 10),
SPC_PREVENT_EVERYBODY_BACKOFF = (1 << 11),
SPC_ALLOW_PAD_SHAKE = (1 << 12)

See: https://alloc8or.re/gta5/doc/enums/eSetPlayerControlFlag.txt
```

---

### SET_PLAYER_EXPLOSIVE_DAMAGE_MODIFIER

- **命名空间:** `PLAYER`
- **Hash:** `0xD821056B9ACF8052`
- **Build:** `1011`

**C# 签名:**
```csharp
void SET_PLAYER_EXPLOSIVE_DAMAGE_MODIFIER(int player, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_FALL_DISTANCE_TO_TRIGGER_RAGDOLL_OVERRIDE

- **命名空间:** `PLAYER`
- **Hash:** `0xEFD79FA81DFBA9CB`
- **Build:** `573`

**C# 签名:**
```csharp
void SET_PLAYER_FALL_DISTANCE_TO_TRIGGER_RAGDOLL_OVERRIDE(int player, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_FORCED_AIM

- **命名空间:** `PLAYER`
- **Hash:** `0x0FEE4F80AC44A726`
- **JHash:** `0x94E42E2E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_FORCED_AIM(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_FORCED_ZOOM

- **命名空间:** `PLAYER`
- **Hash:** `0x75E7D505F2B15902`
- **JHash:** `0xB0C576CB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_FORCED_ZOOM(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_FORCE_SKIP_AIM_INTRO

- **命名空间:** `PLAYER`
- **Hash:** `0x7651BC64AE59E128`
- **JHash:** `0x374F42F0`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_FORCE_SKIP_AIM_INTRO(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_HAS_RESERVE_PARACHUTE

- **命名空间:** `PLAYER`
- **Hash:** `0x7DDAB28D31FAC363`
- **JHash:** `0xA3E4798E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_HAS_RESERVE_PARACHUTE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_HEALTH_RECHARGE_MAX_PERCENT

- **命名空间:** `PLAYER`
- **Hash:** `0xC388A0F065F5BC34`
- **Build:** `573`

**C# 签名:**
```csharp
void SET_PLAYER_HEALTH_RECHARGE_MAX_PERCENT(int player, float limit)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `limit` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_HEALTH_RECHARGE_MULTIPLIER

- **命名空间:** `PLAYER`
- **Hash:** `0x5DB660B38DD98A31`
- **JHash:** `0x45514731`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_HEALTH_RECHARGE_MULTIPLIER(int player, float regenRate)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `regenRate` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
`regenRate`: The recharge multiplier, a value between 0.0 and 1.0.
Use 1.0 to reset it back to normal
```

---

### SET_PLAYER_HOMING_DISABLED_FOR_ALL_VEHICLE_WEAPONS

- **命名空间:** `PLAYER`
- **Hash:** `0xEE4EBDD2593BA844`
- **Build:** `1180`

**C# 签名:**
```csharp
void SET_PLAYER_HOMING_DISABLED_FOR_ALL_VEHICLE_WEAPONS(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_INVINCIBLE

- **命名空间:** `PLAYER`
- **Hash:** `0x239528EACDC3E7DE`
- **JHash:** `0xDFB9A2A2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_INVINCIBLE(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Simply sets you as invincible (Health will not deplete).

Use 0x733A643B5B0C53C1 instead if you want Ragdoll enabled, which is equal to:
*(DWORD *)(playerPedAddress + 0x188) |= (1 << 9);
```

---

### SET_PLAYER_INVINCIBLE_BUT_HAS_REACTIONS

- **命名空间:** `PLAYER`
- **Hash:** `0x6BC97F4F4BB3C04B`
- **Build:** `463`

**C# 签名:**
```csharp
void SET_PLAYER_INVINCIBLE_BUT_HAS_REACTIONS(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_LEAVE_PED_BEHIND

- **命名空间:** `PLAYER`
- **Hash:** `0xFF300C7649724A0B`
- **JHash:** `0xAD8383FA`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_LEAVE_PED_BEHIND(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_LOCKON

- **命名空间:** `PLAYER`
- **Hash:** `0x5C8B2F450EE4328E`
- **JHash:** `0x0B270E0F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_LOCKON(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Example from fm_mission_controler.ysc.c4:

PLAYER::SET_PLAYER_LOCKON(PLAYER::PLAYER_ID(), 1);

All other decompiled scripts using this seem to be using the player id as the first parameter, so I feel the need to confirm it as so.

No need to confirm it says PLAYER_ID() so it uses PLAYER_ID() lol.
```

---

### SET_PLAYER_LOCKON_RANGE_OVERRIDE

- **命名空间:** `PLAYER`
- **Hash:** `0x29961D490E5814FD`
- **JHash:** `0x74D42C03`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_LOCKON_RANGE_OVERRIDE(int player, float range)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `range` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Affects the range of auto aim target.
```

---

### SET_PLAYER_MAX_ARMOUR

- **命名空间:** `PLAYER`
- **Hash:** `0x77DFCCF5948B8C71`
- **JHash:** `0xC6C3C53B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_MAX_ARMOUR(int player, int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `value` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Default is 100. Use player id and not ped id. For instance: PLAYER::SET_PLAYER_MAX_ARMOUR(PLAYER::PLAYER_ID(), 100); // main_persistent.ct4
```

---

### SET_PLAYER_MAX_EXPLOSIVE_DAMAGE

- **命名空间:** `PLAYER`
- **Hash:** `0x8D768602ADEF2245`
- **Build:** `463`

**C# 签名:**
```csharp
void SET_PLAYER_MAX_EXPLOSIVE_DAMAGE(int player, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_MAY_NOT_ENTER_ANY_VEHICLE

- **命名空间:** `PLAYER`
- **Hash:** `0x1DE37BBF9E9CC14A`
- **JHash:** `0xAF7AFCC4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_MAY_NOT_ENTER_ANY_VEHICLE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_MAY_ONLY_ENTER_THIS_VEHICLE

- **命名空间:** `PLAYER`
- **Hash:** `0x8026FF78F208978A`
- **JHash:** `0xA454DD29`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_MAY_ONLY_ENTER_THIS_VEHICLE(int player, int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_MELEE_WEAPON_DAMAGE_MODIFIER

- **命名空间:** `PLAYER`
- **Hash:** `0x4A3DC7ECCC321032`
- **JHash:** `0x362E69AD`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_MELEE_WEAPON_DAMAGE_MODIFIER(int player, float modifier, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `modifier` | `float` | `float` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
modifier's min value is 0.1
```

---

### SET_PLAYER_MELEE_WEAPON_DEFENSE_MODIFIER

- **命名空间:** `PLAYER`
- **Hash:** `0xAE540335B4ABC4E2`
- **JHash:** `0x9F3D577F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_MELEE_WEAPON_DEFENSE_MODIFIER(int player, float modifier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `modifier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
modifier's min value is 0.1
```

---

### SET_PLAYER_MODEL

- **命名空间:** `PLAYER`
- **Hash:** `0x00A1CADD00108836`
- **JHash:** `0x774A4C54`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_MODEL(int player, uint model)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `model` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Set the model for a specific Player. Be aware that this will destroy the current Ped for the Player and create a new one, any reference to the old ped should be reset
Make sure to request the model first and wait until it has loaded.
```

---

### SET_PLAYER_NOISE_MULTIPLIER

- **命名空间:** `PLAYER`
- **Hash:** `0xDB89EF50FF25FCE9`
- **JHash:** `0x15786DD1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_NOISE_MULTIPLIER(int player, float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_PARACHUTE_MODEL_OVERRIDE

- **命名空间:** `PLAYER`
- **Hash:** `0x977DB4641F6FC3DB`
- **JHash:** `0x5D382498`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_PARACHUTE_MODEL_OVERRIDE(int player, uint model)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `model` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_PARACHUTE_PACK_MODEL_OVERRIDE

- **命名空间:** `PLAYER`
- **Hash:** `0xDC80A4C2F18A2B64`
- **JHash:** `0xA877FF5E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_PARACHUTE_PACK_MODEL_OVERRIDE(int player, uint model)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `model` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_PARACHUTE_PACK_TINT_INDEX

- **命名空间:** `PLAYER`
- **Hash:** `0x93B0FB27C9A04060`
- **JHash:** `0xD79D5D1B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_PARACHUTE_PACK_TINT_INDEX(int player, int tintIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `tintIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
tints 0- 13
0 - unkown
1 - unkown
2 - unkown
3 - unkown
4 - unkown
```

---

### SET_PLAYER_PARACHUTE_SMOKE_TRAIL_COLOR

- **命名空间:** `PLAYER`
- **Hash:** `0x8217FD371A4625CF`
- **JHash:** `0x14FE9264`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_PARACHUTE_SMOKE_TRAIL_COLOR(int player, int r, int g, int b)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `r` | `int` | `int` | - |
| `g` | `int` | `int` | - |
| `b` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_PARACHUTE_TINT_INDEX

- **命名空间:** `PLAYER`
- **Hash:** `0xA3D0E54541D9A5E5`
- **JHash:** `0x8EA12EDB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_PARACHUTE_TINT_INDEX(int player, int tintIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `tintIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Tints:
   None = -1,
    Rainbow = 0,
  Red = 1,
  SeasideStripes = 2,
   WidowMaker = 3,
   Patriot = 4,
  Blue = 5,
 Black = 6,
    Hornet = 7,
   AirFocce = 8,
 Desert = 9,
   Shadow = 10,
  HighAltitude = 11,
    Airbone = 12,
 Sunrise = 13,

```

---

### SET_PLAYER_PARACHUTE_VARIATION_OVERRIDE

- **命名空间:** `PLAYER`
- **Hash:** `0xD9284A8C0D48352C`
- **JHash:** `0x9254249D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_PARACHUTE_VARIATION_OVERRIDE(int player, int p1, object p2, object p3, bool p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 was always 5.
p4 was always false.
```

---

### SET_PLAYER_PHONE_PALETTE_IDX

- **命名空间:** `PLAYER`
- **Hash:** `0x11D5F725F0E780E0`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_PHONE_PALETTE_IDX(int player, int idx)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `idx` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_PREVIOUS_VARIATION_DATA

- **命名空间:** `PLAYER`
- **Hash:** `0x7BAE68775557AE0B`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_PLAYER_PREVIOUS_VARIATION_DATA(int player, int p1, int p2, object p3, object p4, object p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `int` | `int` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |
| `p5` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE

- **命名空间:** `PLAYER`
- **Hash:** `0x0764486AEDE748DB`
- **Build:** `2372`

**C# 签名:**
```csharp
void SET_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE(int player, uint model)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `model` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_RESERVE_PARACHUTE_TINT_INDEX

- **命名空间:** `PLAYER`
- **Hash:** `0xAF04C87F5DC1DF38`
- **JHash:** `0x70689638`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_RESERVE_PARACHUTE_TINT_INDEX(int player, int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `index` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Tints:
   None = -1,
    Rainbow = 0,
  Red = 1,
  SeasideStripes = 2,
   WidowMaker = 3,
   Patriot = 4,
  Blue = 5,
 Black = 6,
    Hornet = 7,
   AirFocce = 8,
 Desert = 9,
   Shadow = 10,
  HighAltitude = 11,
    Airbone = 12,
 Sunrise = 13,
```

---

### SET_PLAYER_SIMULATE_AIMING

- **命名空间:** `PLAYER`
- **Hash:** `0xC54C95DA968EC5B5`
- **JHash:** `0xF1E0CAFC`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_SIMULATE_AIMING(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_SNEAKING_NOISE_MULTIPLIER

- **命名空间:** `PLAYER`
- **Hash:** `0xB2C1A29588A9F47C`
- **JHash:** `0x8D2D89C4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_SNEAKING_NOISE_MULTIPLIER(int player, float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Values around 1.0f to 2.0f used in game scripts.
```

---

### SET_PLAYER_SPECTATED_VEHICLE_RADIO_OVERRIDE

- **命名空间:** `PLAYER`
- **Hash:** `0x2F7CEB6520288061`
- **JHash:** `0x2849D4B2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_SPECTATED_VEHICLE_RADIO_OVERRIDE(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_SPRINT

- **命名空间:** `PLAYER`
- **Hash:** `0xA01B8075D8B92DF4`
- **JHash:** `0x7DD7900C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_SPRINT(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_STEALTH_PERCEPTION_MODIFIER

- **命名空间:** `PLAYER`
- **Hash:** `0x4E9021C1FCDD507A`
- **JHash:** `0x3D26105F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_STEALTH_PERCEPTION_MODIFIER(int player, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_TARGETING_MODE

- **命名空间:** `PLAYER`
- **Hash:** `0xB1906895227793F3`
- **JHash:** `0x61CAE253`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_TARGETING_MODE(int targetMode)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `targetMode` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets your targeting mode.
0 = Assisted Aim - Full
1 = Assisted Aim - Partial
2 = Free Aim - Assisted
3 = Free Aim
```

---

### SET_PLAYER_TARGET_LEVEL

- **命名空间:** `PLAYER`
- **Hash:** `0x5702B917B99DB1CD`
- **JHash:** `0x772DA539`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_TARGET_LEVEL(int targetLevel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `targetLevel` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_TEAM

- **命名空间:** `PLAYER`
- **Hash:** `0x0299FA38396A4940`
- **JHash:** `0x725ADCF2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_TEAM(int player, int team)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `team` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Set player team on deathmatch and last team standing..
```

---

### SET_PLAYER_UNDERWATER_BREATH_PERCENT_REMAINING

- **命名空间:** `PLAYER`
- **Hash:** `0xA0D3E4F7AAFB7E78`
- **Build:** `757`

**C# 签名:**
```csharp
float SET_PLAYER_UNDERWATER_BREATH_PERCENT_REMAINING(int player, float time)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `time` | `float` | `float` | - |

**返回值:** `float` (Native: `float`)

---

### SET_PLAYER_VEHICLE_DAMAGE_MODIFIER

- **命名空间:** `PLAYER`
- **Hash:** `0xA50E117CDDF82F0C`
- **JHash:** `0x823ECA63`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_VEHICLE_DAMAGE_MODIFIER(int player, float modifier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `modifier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
modifier's min value is 0.1
```

---

### SET_PLAYER_VEHICLE_DEFENSE_MODIFIER

- **命名空间:** `PLAYER`
- **Hash:** `0x4C60E6EFDAFF2462`
- **JHash:** `0xA16626C7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_VEHICLE_DEFENSE_MODIFIER(int player, float modifier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `modifier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
modifier's min value is 0.1
```

---

### SET_PLAYER_VEHICLE_WEAPON_TO_NON_HOMING

- **命名空间:** `PLAYER`
- **Hash:** `0x237440E46D918649`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_PLAYER_VEHICLE_WEAPON_TO_NON_HOMING(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Unsets playerPed+330 if the current weapon has certain flags.
```

---

### SET_PLAYER_WANTED_CENTRE_POSITION

- **命名空间:** `PLAYER`
- **Hash:** `0x520E541A97A13354`
- **JHash:** `0xF261633A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_WANTED_CENTRE_POSITION(int player, ref Vector3 position, bool p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `position` | `Vector3*` | `ref Vector3` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
# Predominant call signatures
PLAYER::SET_PLAYER_WANTED_CENTRE_POSITION(PLAYER::PLAYER_ID(), ENTITY::GET_ENTITY_COORDS(PLAYER::PLAYER_PED_ID(), 1));

# Parameter value ranges
P0: PLAYER::PLAYER_ID()
P1: ENTITY::GET_ENTITY_COORDS(PLAYER::PLAYER_PED_ID(), 1)
P2: Not set by any call
```

---

### SET_PLAYER_WANTED_LEVEL

- **命名空间:** `PLAYER`
- **Hash:** `0x39FF19C64EF7DA5B`
- **JHash:** `0xB7A0914B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_WANTED_LEVEL(int player, int wantedLevel, bool disableNoMission)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `wantedLevel` | `int` | `int` | - |
| `disableNoMission` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Call SET_PLAYER_WANTED_LEVEL_NOW for immediate effect

wantedLevel is an integer value representing 0 to 5 stars even though the game supports the 6th wanted level but no police will appear since no definitions are present for it in the game files

disableNoMission-  Disables When Off Mission- appears to always be false

```

---

### SET_PLAYER_WANTED_LEVEL_NOW

- **命名空间:** `PLAYER`
- **Hash:** `0xE0A7D1E497FFCD6F`
- **JHash:** `0xAF3AFD83`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_WANTED_LEVEL_NOW(int player, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Forces any pending wanted level to be applied to the specified player immediately.

Call SET_PLAYER_WANTED_LEVEL with the desired wanted level, followed by SET_PLAYER_WANTED_LEVEL_NOW.

Second parameter is unknown (always false).
```

---

### SET_PLAYER_WANTED_LEVEL_NO_DROP

- **命名空间:** `PLAYER`
- **Hash:** `0x340E61DE7F471565`
- **JHash:** `0xED6F44F5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_WANTED_LEVEL_NO_DROP(int player, int wantedLevel, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `wantedLevel` | `int` | `int` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p2 is always false in R* scripts
```

---

### SET_PLAYER_WEAPON_DAMAGE_MODIFIER

- **命名空间:** `PLAYER`
- **Hash:** `0xCE07B9F7817AADA3`
- **JHash:** `0xB02C2F39`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_WEAPON_DAMAGE_MODIFIER(int player, float modifier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `modifier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This modifies the damage value of your weapon. Whether it is a multiplier or base damage is unknown. 

Based on tests, it is unlikely to be a multiplier.

modifier's min value is 0.1
```

---

### SET_PLAYER_WEAPON_DEFENSE_MODIFIER

- **命名空间:** `PLAYER`
- **Hash:** `0x2D83BC011CA14A3C`
- **JHash:** `0xAE446344`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_WEAPON_DEFENSE_MODIFIER(int player, float modifier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `modifier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
modifier's min value is 0.1
```

---

### SET_PLAYER_WEAPON_MINIGUN_DEFENSE_MODIFIER

- **命名空间:** `PLAYER`
- **Hash:** `0xBCFDE9EDE4CF27DC`
- **Build:** `944`

**C# 签名:**
```csharp
void SET_PLAYER_WEAPON_MINIGUN_DEFENSE_MODIFIER(int player, float modifier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `modifier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
modifier's min value is 0.1
```

---

### SET_PLAYER_WEAPON_TAKEDOWN_DEFENSE_MODIFIER

- **命名空间:** `PLAYER`
- **Hash:** `0x31E90B8873A4CD3B`
- **Build:** `617`

**C# 签名:**
```csharp
void SET_PLAYER_WEAPON_TAKEDOWN_DEFENSE_MODIFIER(int player, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_POLICE_IGNORE_PLAYER

- **命名空间:** `PLAYER`
- **Hash:** `0x32C62AA929C2DA6A`
- **JHash:** `0xE6DE71B7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_POLICE_IGNORE_PLAYER(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
The player will be ignored by the police if toggle is set to true
```

---

### SET_POLICE_RADAR_BLIPS

- **命名空间:** `PLAYER`
- **Hash:** `0x43286D561B72B8BF`
- **JHash:** `0x8E114B10`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_POLICE_RADAR_BLIPS(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
If toggle is set to false:
 The police won't be shown on the (mini)map

If toggle is set to true:
 The police will be shown on the (mini)map
```

---

### SET_RUN_SPRINT_MULTIPLIER_FOR_PLAYER

- **命名空间:** `PLAYER`
- **Hash:** `0x6DB47AA77FD94E09`
- **JHash:** `0x825423C2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_RUN_SPRINT_MULTIPLIER_FOR_PLAYER(int player, float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Multiplier goes up to 1.49 any value above will be completely overruled by the game and the multiplier will not take effect, this can be edited in memory however.

Just call it one time, it is not required to be called once every tick.

Note: At least the IDA method if you change the max float multiplier from 1.5 it will change it for both this and SWIM above. I say 1.5 as the function blrs if what you input is greater than or equal to 1.5 hence why it's 1.49 max default.
```

---

### SET_SCRIPT_FIRE_POSITION

- **命名空间:** `PLAYER`
- **Hash:** `0x70A382ADEC069DD3`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_SCRIPT_FIRE_POSITION(float coordX, float coordY, float coordZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `coordX` | `float` | `float` | - |
| `coordY` | `float` | `float` | - |
| `coordZ` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SPECIAL_ABILITY_MP

- **命名空间:** `PLAYER`
- **Hash:** `0xB214D570EAD7F81A`
- **Build:** `678`

**C# 签名:**
```csharp
void SET_SPECIAL_ABILITY_MP(int player, int p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SPECIAL_ABILITY_MULTIPLIER

- **命名空间:** `PLAYER`
- **Hash:** `0xA49C426ED0CA4AB7`
- **JHash:** `0xFF1BC556`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SPECIAL_ABILITY_MULTIPLIER(float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SWIM_MULTIPLIER_FOR_PLAYER

- **命名空间:** `PLAYER`
- **Hash:** `0xA91C6F0FF7D16A13`
- **JHash:** `0xB986FF47`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SWIM_MULTIPLIER_FOR_PLAYER(int player, float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Swim speed multiplier.
Multiplier goes up to 1.49

Just call it one time, it is not required to be called once every tick. - Note copied from below native.

Note: At least the IDA method if you change the max float multiplier from 1.5 it will change it for both this and RUN_SPRINT below. I say 1.5 as the function blrs if what you input is greater than or equal to 1.5 hence why it's 1.49 max default.
```

---

### SET_WANTED_LEVEL_DIFFICULTY

- **命名空间:** `PLAYER`
- **Hash:** `0x9B0BB33B04405E7A`
- **JHash:** `0xB552626C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_WANTED_LEVEL_DIFFICULTY(int player, float difficulty)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `difficulty` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Max value is 1.0
```

---

### SET_WANTED_LEVEL_HIDDEN_ESCAPE_TIME

- **命名空间:** `PLAYER`
- **Hash:** `0x49B856B1360C47C7`
- **Build:** `2060`

**C# 签名:**
```csharp
void SET_WANTED_LEVEL_HIDDEN_ESCAPE_TIME(int player, int wantedLevel, int lossTime)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `wantedLevel` | `int` | `int` | - |
| `lossTime` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_WANTED_LEVEL_MULTIPLIER

- **命名空间:** `PLAYER`
- **Hash:** `0x020E5F00CDA207BA`
- **JHash:** `0x1359292F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_WANTED_LEVEL_MULTIPLIER(float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SIMULATE_PLAYER_INPUT_GAIT

- **命名空间:** `PLAYER`
- **Hash:** `0x477D5D63E63ECA5D`
- **JHash:** `0x0D77CC34`
- **Build:** `323`

**C# 签名:**
```csharp
void SIMULATE_PLAYER_INPUT_GAIT(int player, float amount, int gaitType, float speed, bool p4, bool p5, object p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `amount` | `float` | `float` | - |
| `gaitType` | `int` | `int` | - |
| `speed` | `float` | `float` | - |
| `p4` | `BOOL` | `bool` | - |
| `p5` | `BOOL` | `bool` | - |
| `p6` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This is to make the player walk without accepting input from INPUT.

gaitType is in increments of 100s. 2000, 500, 300, 200, etc.

p4 is always 1 and p5 is always 0.

C# Example :

Function.Call(Hash.SIMULATE_PLAYER_INPUT_GAIT, Game.Player, 1.0f, 100, 1.0f, 1, 0); //Player will go forward for 100ms
```

---

### SPECIAL_ABILITY_ACTIVATE

- **命名空间:** `PLAYER`
- **Hash:** `0x821FDC827D6F4090`
- **Build:** `678`

**C# 签名:**
```csharp
void SPECIAL_ABILITY_ACTIVATE(int player, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 is always 0 in the scripts
```

---

### SPECIAL_ABILITY_CHARGE_ABSOLUTE

- **命名空间:** `PLAYER`
- **Hash:** `0xB7B0870EB531D08D`
- **JHash:** `0x72429998`
- **Build:** `323`

**C# 签名:**
```csharp
void SPECIAL_ABILITY_CHARGE_ABSOLUTE(int player, int p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 appears as 5, 10, 15, 25, or 30. p2 is always true.
```

---

### SPECIAL_ABILITY_CHARGE_CONTINUOUS

- **命名空间:** `PLAYER`
- **Hash:** `0xED481732DFF7E997`
- **JHash:** `0x5FEE98A2`
- **Build:** `323`

**C# 签名:**
```csharp
void SPECIAL_ABILITY_CHARGE_CONTINUOUS(int player, int p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `Ped` | `int` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 appears to always be 1 (only comes up twice)
```

---

### SPECIAL_ABILITY_CHARGE_LARGE

- **命名空间:** `PLAYER`
- **Hash:** `0xF733F45FA4497D93`
- **JHash:** `0xF440C04D`
- **Build:** `323`

**C# 签名:**
```csharp
void SPECIAL_ABILITY_CHARGE_LARGE(int player, bool p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
2 matches. p1 was always true.
```

---

### SPECIAL_ABILITY_CHARGE_MEDIUM

- **命名空间:** `PLAYER`
- **Hash:** `0xF113E3AA9BC54613`
- **JHash:** `0xAB55D8F3`
- **Build:** `323`

**C# 签名:**
```csharp
void SPECIAL_ABILITY_CHARGE_MEDIUM(int player, bool p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Only 1 match. Both p1 & p2 were true.
```

---

### SPECIAL_ABILITY_CHARGE_NORMALIZED

- **命名空间:** `PLAYER`
- **Hash:** `0xA0696A65F009EE18`
- **JHash:** `0x8C7E68C1`
- **Build:** `323`

**C# 签名:**
```csharp
void SPECIAL_ABILITY_CHARGE_NORMALIZED(int player, float normalizedValue, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `normalizedValue` | `float` | `float` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```

normalizedValue is from 0.0 - 1.0
p2 is always 1
```

---

### SPECIAL_ABILITY_CHARGE_ON_MISSION_FAILED

- **命名空间:** `PLAYER`
- **Hash:** `0xC9A763D8FE87436A`
- **JHash:** `0x4136829A`
- **Build:** `323`

**C# 签名:**
```csharp
void SPECIAL_ABILITY_CHARGE_ON_MISSION_FAILED(int player, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SPECIAL_ABILITY_CHARGE_SMALL

- **命名空间:** `PLAYER`
- **Hash:** `0x2E7B9B683481687D`
- **JHash:** `0x6F463F56`
- **Build:** `323`

**C# 签名:**
```csharp
void SPECIAL_ABILITY_CHARGE_SMALL(int player, bool p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Every occurrence of p1 & p2 were both true.
```

---

### SPECIAL_ABILITY_DEACTIVATE

- **命名空间:** `PLAYER`
- **Hash:** `0xD6A953C6D1492057`
- **JHash:** `0x80C2AB09`
- **Build:** `323`

**C# 签名:**
```csharp
void SPECIAL_ABILITY_DEACTIVATE(int player, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SPECIAL_ABILITY_DEACTIVATE_FAST

- **命名空间:** `PLAYER`
- **Hash:** `0x9CB5CE07A3968D5A`
- **JHash:** `0x0751908A`
- **Build:** `323`

**C# 签名:**
```csharp
void SPECIAL_ABILITY_DEACTIVATE_FAST(int player, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SPECIAL_ABILITY_DEACTIVATE_MP

- **命名空间:** `PLAYER`
- **Hash:** `0x17F7471EACA78290`
- **Build:** `678`

**C# 签名:**
```csharp
void SPECIAL_ABILITY_DEACTIVATE_MP(int player, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 is always 0 in the scripts
```

---

### SPECIAL_ABILITY_DEPLETE_METER

- **命名空间:** `PLAYER`
- **Hash:** `0x1D506DBBBC51E64B`
- **JHash:** `0x9F80F6DF`
- **Build:** `323`

**C# 签名:**
```csharp
void SPECIAL_ABILITY_DEPLETE_METER(int player, bool p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 was always true.
```

---

### SPECIAL_ABILITY_FILL_METER

- **命名空间:** `PLAYER`
- **Hash:** `0x3DACA8DDC6FD4980`
- **JHash:** `0xB71589DA`
- **Build:** `323`

**C# 签名:**
```csharp
void SPECIAL_ABILITY_FILL_METER(int player, bool p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Also known as _RECHARGE_SPECIAL_ABILITY
```

---

### SPECIAL_ABILITY_LOCK

- **命名空间:** `PLAYER`
- **Hash:** `0x6A09D0D590A47D13`
- **JHash:** `0x1B7BB388`
- **Build:** `323`

**C# 签名:**
```csharp
void SPECIAL_ABILITY_LOCK(uint playerModel, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `playerModel` | `Hash` | `uint` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SPECIAL_ABILITY_RESET

- **命名空间:** `PLAYER`
- **Hash:** `0x375F0E738F861A94`
- **JHash:** `0xA7D8BCD3`
- **Build:** `323`

**C# 签名:**
```csharp
void SPECIAL_ABILITY_RESET(int player, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SPECIAL_ABILITY_UNLOCK

- **命名空间:** `PLAYER`
- **Hash:** `0xF145F3BE2EFA9A3B`
- **JHash:** `0x1FDB2919`
- **Build:** `323`

**C# 签名:**
```csharp
void SPECIAL_ABILITY_UNLOCK(uint playerModel, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `playerModel` | `Hash` | `uint` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### START_FIRING_AMNESTY

- **命名空间:** `PLAYER`
- **Hash:** `0xBF9BD71691857E48`
- **JHash:** `0x5F8A22A6`
- **Build:** `323`

**C# 签名:**
```csharp
void START_FIRING_AMNESTY(int duration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `duration` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### START_PLAYER_TELEPORT

- **命名空间:** `PLAYER`
- **Hash:** `0xAD15F075A4DA0FDE`
- **JHash:** `0xC552E06C`
- **Build:** `323`

**C# 签名:**
```csharp
void START_PLAYER_TELEPORT(int player, float x, float y, float z, float heading, bool p5, bool findCollisionLand, bool p7)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `heading` | `float` | `float` | - |
| `p5` | `BOOL` | `bool` | - |
| `findCollisionLand` | `BOOL` | `bool` | - |
| `p7` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
`findCollisionLand`: This teleports the player to land when set to true and will not consider the Z coordinate parameter provided by you. It will automatically put the Z coordinate so that you don't fall from sky.
```

---

### STOP_PLAYER_TELEPORT

- **命名空间:** `PLAYER`
- **Hash:** `0xC449EDED9D73009C`
- **JHash:** `0x86AB8DBB`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_PLAYER_TELEPORT()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Disables the player's teleportation
```

---

### SUPPRESS_CRIME_THIS_FRAME

- **命名空间:** `PLAYER`
- **Hash:** `0x9A987297ED8BD838`
- **JHash:** `0x59B5C2A2`
- **Build:** `323`

**C# 签名:**
```csharp
void SUPPRESS_CRIME_THIS_FRAME(int player, int crimeType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `crimeType` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
crimeType: see REPORT_CRIME
```

---

### SUPPRESS_LOSING_WANTED_LEVEL_IF_HIDDEN_THIS_FRAME

- **命名空间:** `PLAYER`
- **Hash:** `0x4669B3ED80F24B4E`
- **JHash:** `0xB9FB142F`
- **Build:** `323`

**C# 签名:**
```csharp
void SUPPRESS_LOSING_WANTED_LEVEL_IF_HIDDEN_THIS_FRAME(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This has been found in use in the decompiled files.
```

---

### SUPPRESS_WITNESSES_CALLING_POLICE_THIS_FRAME

- **命名空间:** `PLAYER`
- **Hash:** `0x36F1B38855F2A8DF`
- **JHash:** `0x3A7E5FB6`
- **Build:** `323`

**C# 签名:**
```csharp
void SUPPRESS_WITNESSES_CALLING_POLICE_THIS_FRAME(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### UPDATE_PLAYER_TELEPORT

- **命名空间:** `PLAYER`
- **Hash:** `0xE23D5873C2394C61`
- **Build:** `323`

**C# 签名:**
```csharp
bool UPDATE_PLAYER_TELEPORT(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UPDATE_SPECIAL_ABILITY_FROM_STAT

- **命名空间:** `PLAYER`
- **Hash:** `0xFFEE8FA29AB9A18E`
- **JHash:** `0x5D0FE25B`
- **Build:** `323`

**C# 签名:**
```csharp
void UPDATE_SPECIAL_ABILITY_FROM_STAT(int player, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### UPDATE_WANTED_POSITION_THIS_FRAME

- **命名空间:** `PLAYER`
- **Hash:** `0xBC9490CA15AEA8FB`
- **JHash:** `0x6B34A160`
- **Build:** `323`

**C# 签名:**
```csharp
void UPDATE_WANTED_POSITION_THIS_FRAME(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native is used in both singleplayer and multiplayer scripts.

Always used like this in scripts
PLAYER::UPDATE_WANTED_POSITION_THIS_FRAME(PLAYER::PLAYER_ID());
```

---
