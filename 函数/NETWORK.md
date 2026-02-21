# NETWORK - Native 函数参考

> 命名空间: NETWORK, NETSHOPPING, LOBBY

---

## 快速索引

| 函数名 | C# 签名 | 返回值 | 说明 |
|--------|---------|--------|------|
| `ACTIVATE_DAMAGE_TRACKER_ON_NETWORK_ID` | `void ACTIVATE_DAMAGE_TRACKER_ON_NETWORK_ID(int netID, bool toggle)` | void | - |
| `ACTIVATE_DAMAGE_TRACKER_ON_PLAYER` | `void ACTIVATE_DAMAGE_TRACKER_ON_PLAYER(int player, bool toggle)` | void | - |
| `ARE_CUTSCENE_ENTITIES_NETWORKED` | `bool ARE_CUTSCENE_ENTITIES_NETWORKED()` | bool | Getter for SET_NETWORK_CUTSCENE_ENTITIES. |
| `BAD_SPORT_PLAYER_LEFT_DETECTED` | `bool BAD_SPORT_PLAYER_LEFT_DETECTED(ref object gamerHandle, int event, int amountReceived)` | bool | - |
| `CAN_REGISTER_MISSION_DOORS` | `bool CAN_REGISTER_MISSION_DOORS(object p0)` | bool | - |
| `CAN_REGISTER_MISSION_ENTITIES` | `bool CAN_REGISTER_MISSION_ENTITIES(int ped_amt, int vehicle_amt, int object_amt, int pickup_amt)` | bool | - |
| `CAN_REGISTER_MISSION_OBJECTS` | `bool CAN_REGISTER_MISSION_OBJECTS(int amount)` | bool | - |
| `CAN_REGISTER_MISSION_PEDS` | `bool CAN_REGISTER_MISSION_PEDS(int amount)` | bool | - |
| `CAN_REGISTER_MISSION_PICKUPS` | `bool CAN_REGISTER_MISSION_PICKUPS(int amount)` | bool | - |
| `CAN_REGISTER_MISSION_VEHICLES` | `bool CAN_REGISTER_MISSION_VEHICLES(int amount)` | bool | - |
| `CLEAR_SERVICE_EVENT_ARGUMENTS` | `void CLEAR_SERVICE_EVENT_ARGUMENTS()` | void | This native does absolutely nothing, just a nullsub |
| `CLOUD_CHECK_AVAILABILITY` | `void CLOUD_CHECK_AVAILABILITY()` | void | Downloads prod.cloud.rockstargames.com/titles/gta5/[platform]/check.json |
| `CLOUD_DELETE_MEMBER_FILE` | `int CLOUD_DELETE_MEMBER_FILE(string p0)` | int | - |
| `CLOUD_DID_REQUEST_SUCCEED` | `bool CLOUD_DID_REQUEST_SUCCEED(int requestId)` | bool | - |
| `CLOUD_GET_AVAILABILITY_CHECK_RESULT` | `bool CLOUD_GET_AVAILABILITY_CHECK_RESULT()` | bool | - |
| `CLOUD_HAS_REQUEST_COMPLETED` | `bool CLOUD_HAS_REQUEST_COMPLETED(int requestId)` | bool | - |
| `CLOUD_IS_CHECKING_AVAILABILITY` | `bool CLOUD_IS_CHECKING_AVAILABILITY()` | bool | - |
| `CONVERT_POSIX_TIME` | `void CONVERT_POSIX_TIME(int posixTime, ref object timeStructure)` | void | Takes the specified time and writes it to the structure specified in the second argument.<br><br>struct da... |
| `DELAY_MP_STORE_OPEN` | `void DELAY_MP_STORE_OPEN()` | void | - |
| `FACEBOOK_CAN_POST_TO_FACEBOOK` | `bool FACEBOOK_CAN_POST_TO_FACEBOOK()` | bool | - |
| `FACEBOOK_DID_POST_SUCCEED` | `bool FACEBOOK_DID_POST_SUCCEED()` | bool | - |
| `FACEBOOK_HAS_POST_COMPLETED` | `bool FACEBOOK_HAS_POST_COMPLETED()` | bool | - |
| `FACEBOOK_POST_COMPLETED_HEIST` | `bool FACEBOOK_POST_COMPLETED_HEIST(string heistName, int cashEarned, int xpEarned)` | bool | - |
| `FACEBOOK_POST_COMPLETED_MILESTONE` | `bool FACEBOOK_POST_COMPLETED_MILESTONE(int milestoneId)` | bool | - |
| `FACEBOOK_POST_CREATE_CHARACTER` | `bool FACEBOOK_POST_CREATE_CHARACTER()` | bool | - |
| `FADE_OUT_LOCAL_PLAYER` | `void FADE_OUT_LOCAL_PLAYER(bool p0)` | void | Hardcoded to not work in SP. |
| `FILLOUT_PM_PLAYER_LIST` | `bool FILLOUT_PM_PLAYER_LIST(ref object gamerHandle, object p1, object p2)` | bool | - |
| `FILLOUT_PM_PLAYER_LIST_WITH_NAMES` | `bool FILLOUT_PM_PLAYER_LIST_WITH_NAMES(ref object p0, ref object p1, object p2, object p3)` | bool | - |
| `GET_CLOUD_TIME_AS_INT` | `int GET_CLOUD_TIME_AS_INT()` | int | Returns POSIX timestamp, an int representing the cloud time. |
| `GET_CLOUD_TIME_AS_STRING` | `string GET_CLOUD_TIME_AS_STRING()` | string | Same as GET_CLOUD_TIME_AS_INT but returns the value as a hex string (%I64X). |
| `GET_COMMERCE_ITEM_CAT` | `string GET_COMMERCE_ITEM_CAT(int index, int index2)` | string | index2 is unused |
| `GET_COMMERCE_ITEM_ID` | `string GET_COMMERCE_ITEM_ID(int index)` | string | - |
| `GET_COMMERCE_ITEM_NAME` | `string GET_COMMERCE_ITEM_NAME(int index)` | string | - |
| `GET_COMMERCE_ITEM_NUM_CATS` | `int GET_COMMERCE_ITEM_NUM_CATS(int index)` | int | - |
| `GET_COMMERCE_ITEM_TEXTURENAME` | `string GET_COMMERCE_ITEM_TEXTURENAME(int index)` | string | - |
| `GET_COMMERCE_PRODUCT_PRICE` | `string GET_COMMERCE_PRODUCT_PRICE(int index)` | string | - |
| `GET_CONTENT_TO_LOAD_TYPE` | `int GET_CONTENT_TO_LOAD_TYPE()` | int | This function is hard-coded to always return 0. |
| `GET_IS_LAUNCH_FROM_LIVE_AREA` | `bool GET_IS_LAUNCH_FROM_LIVE_AREA()` | bool | This function is hard-coded to always return 0. |
| `GET_IS_LIVE_AREA_LAUNCH_WITH_CONTENT` | `bool GET_IS_LIVE_AREA_LAUNCH_WITH_CONTENT()` | bool | This function is hard-coded to always return 0. |
| `GET_MAX_NUM_NETWORK_OBJECTS` | `int GET_MAX_NUM_NETWORK_OBJECTS()` | int | - |
| `GET_MAX_NUM_NETWORK_PEDS` | `int GET_MAX_NUM_NETWORK_PEDS()` | int | - |
| `GET_MAX_NUM_NETWORK_PICKUPS` | `int GET_MAX_NUM_NETWORK_PICKUPS()` | int | - |
| `GET_MAX_NUM_NETWORK_VEHICLES` | `int GET_MAX_NUM_NETWORK_VEHICLES()` | int | - |
| `GET_NETWORK_TIME` | `int GET_NETWORK_TIME()` | int | - |
| `GET_NETWORK_TIME_ACCURATE` | `int GET_NETWORK_TIME_ACCURATE()` | int | Returns the same value as GET_NETWORK_TIME in freemode, but as opposed to `GET_NETWORK_TIME` it alwa... |
| `GET_NUM_COMMERCE_ITEMS` | `int GET_NUM_COMMERCE_ITEMS()` | int | - |
| `GET_NUM_CREATED_MISSION_OBJECTS` | `int GET_NUM_CREATED_MISSION_OBJECTS(bool p0)` | int | - |
| `GET_NUM_CREATED_MISSION_PEDS` | `int GET_NUM_CREATED_MISSION_PEDS(bool p0)` | int | - |
| `GET_NUM_CREATED_MISSION_VEHICLES` | `int GET_NUM_CREATED_MISSION_VEHICLES(bool p0)` | int | - |
| `GET_NUM_RESERVED_MISSION_OBJECTS` | `int GET_NUM_RESERVED_MISSION_OBJECTS(bool p0, object p1)` | int | p0 appears to be for MP |
| `GET_NUM_RESERVED_MISSION_PEDS` | `int GET_NUM_RESERVED_MISSION_PEDS(bool p0, object p1)` | int | p0 appears to be for MP |
| `GET_NUM_RESERVED_MISSION_VEHICLES` | `int GET_NUM_RESERVED_MISSION_VEHICLES(bool p0, object p1)` | int | p0 appears to be for MP |
| `GET_ONLINE_VERSION` | `string GET_ONLINE_VERSION()` | string | Online version is defined here: update\update.rpf\common\data\version.txt<br><br>Example:<br><br>[ONLINE_VERSION... |
| `GET_RESERVED_MISSION_ENTITIES_IN_AREA` | `void GET_RESERVED_MISSION_ENTITIES_IN_AREA(float x, float y, float z, object p3, ref object out1, ref object out2, ref object out3)` | void | - |
| `GET_STATUS_OF_TEXTURE_DOWNLOAD` | `int GET_STATUS_OF_TEXTURE_DOWNLOAD(int p0)` | int | 0 = succeeded<br>1 = pending<br>2 = failed |
| `GET_TIME_AS_STRING` | `string GET_TIME_AS_STRING(int time)` | string | - |
| `GET_TIME_DIFFERENCE` | `int GET_TIME_DIFFERENCE(int timeA, int timeB)` | int | Subtracts the second argument from the first. |
| `GET_TIME_OFFSET` | `int GET_TIME_OFFSET(int timeA, int timeB)` | int | Adds the first argument to the second. |
| `GET_USER_PREMIUM_ACCESS` | `int GET_USER_PREMIUM_ACCESS()` | int | Checks some commerce stuff |
| `GET_USER_STARTER_ACCESS` | `int GET_USER_STARTER_ACCESS()` | int | Checks some commerce stuff |
| `HAS_NETWORK_TIME_STARTED` | `bool HAS_NETWORK_TIME_STARTED()` | bool | - |
| `IS_COMMERCE_DATA_FETCH_IN_PROGRESS` | `bool IS_COMMERCE_DATA_FETCH_IN_PROGRESS()` | bool | - |
| `IS_COMMERCE_DATA_VALID` | `bool IS_COMMERCE_DATA_VALID()` | bool | - |
| `IS_COMMERCE_STORE_OPEN` | `bool IS_COMMERCE_STORE_OPEN()` | bool | - |
| `IS_DAMAGE_TRACKER_ACTIVE_ON_NETWORK_ID` | `bool IS_DAMAGE_TRACKER_ACTIVE_ON_NETWORK_ID(int netID)` | bool | - |
| `IS_DAMAGE_TRACKER_ACTIVE_ON_PLAYER` | `bool IS_DAMAGE_TRACKER_ACTIVE_ON_PLAYER(int player)` | bool | - |
| `IS_ENTITY_A_GHOST` | `bool IS_ENTITY_A_GHOST(int entity)` | bool | - |
| `IS_ENTITY_IN_GHOST_COLLISION` | `bool IS_ENTITY_IN_GHOST_COLLISION(int entity)` | bool | - |
| `IS_NETWORK_ID_OWNED_BY_PARTICIPANT` | `bool IS_NETWORK_ID_OWNED_BY_PARTICIPANT(int netId)` | bool | - |
| `IS_NETWORK_VEHICLE_RUNNING_RESPOT_TIMER` | `bool IS_NETWORK_VEHICLE_RUNNING_RESPOT_TIMER(int networkID)` | bool | - |
| `IS_OBJECT_REASSIGNMENT_IN_PROGRESS` | `bool IS_OBJECT_REASSIGNMENT_IN_PROGRESS()` | bool | - |
| `IS_PLAYER_IN_CUTSCENE` | `bool IS_PLAYER_IN_CUTSCENE(int player)` | bool | - |
| `IS_SPHERE_VISIBLE_TO_ANOTHER_MACHINE` | `bool IS_SPHERE_VISIBLE_TO_ANOTHER_MACHINE(float p0, float p1, float p2, float p3)` | bool | - |
| `IS_SPHERE_VISIBLE_TO_PLAYER` | `bool IS_SPHERE_VISIBLE_TO_PLAYER(object p0, float p1, float p2, float p3, float p4)` | bool | - |
| `IS_STORE_AVAILABLE_TO_USER` | `bool IS_STORE_AVAILABLE_TO_USER()` | bool | - |
| `IS_TIME_EQUAL_TO` | `bool IS_TIME_EQUAL_TO(int timeA, int timeB)` | bool | Returns true if the two times are equal; otherwise returns false. |
| `IS_TIME_LESS_THAN` | `bool IS_TIME_LESS_THAN(int timeA, int timeB)` | bool | Subtracts the second argument from the first, then returns whether the result is negative. |
| `IS_TIME_MORE_THAN` | `bool IS_TIME_MORE_THAN(int timeA, int timeB)` | bool | Subtracts the first argument from the second, then returns whether the result is negative. |
| `IS_USER_OLD_ENOUGH_TO_ACCESS_STORE` | `bool IS_USER_OLD_ENOUGH_TO_ACCESS_STORE()` | bool | - |
| `LOBBY_AUTO_MULTIPLAYER_EVENT` | `bool LOBBY_AUTO_MULTIPLAYER_EVENT()` | bool | - |
| `LOBBY_AUTO_MULTIPLAYER_FREEMODE` | `bool LOBBY_AUTO_MULTIPLAYER_FREEMODE()` | bool | - |
| `LOBBY_AUTO_MULTIPLAYER_MENU` | `bool LOBBY_AUTO_MULTIPLAYER_MENU()` | bool | This function is hard-coded to always return 0. |
| `LOBBY_AUTO_MULTIPLAYER_RANDOM_JOB` | `bool LOBBY_AUTO_MULTIPLAYER_RANDOM_JOB()` | bool | - |
| `LOBBY_SET_AUTO_MP_RANDOM_JOB` | `void LOBBY_SET_AUTO_MP_RANDOM_JOB(bool toggle)` | void | - |
| `LOBBY_SET_AUTO_MULTIPLAYER` | `void LOBBY_SET_AUTO_MULTIPLAYER(bool toggle)` | void | - |
| `LOBBY_SET_AUTO_MULTIPLAYER_EVENT` | `void LOBBY_SET_AUTO_MULTIPLAYER_EVENT(bool toggle)` | void | - |
| `NETWORK_ACCEPT_PRESENCE_INVITE` | `bool NETWORK_ACCEPT_PRESENCE_INVITE(int p0)` | bool | - |
| `NETWORK_ACCESS_TUNABLE_BOOL` | `bool NETWORK_ACCESS_TUNABLE_BOOL(string tunableContext, string tunableName)` | bool | - |
| `NETWORK_ACCESS_TUNABLE_BOOL_HASH` | `bool NETWORK_ACCESS_TUNABLE_BOOL_HASH(uint tunableContext, uint tunableName)` | bool | - |
| `NETWORK_ACCESS_TUNABLE_BOOL_MODIFICATION_DETECTION_REGISTRATION_HASH` | `bool NETWORK_ACCESS_TUNABLE_BOOL_MODIFICATION_DETECTION_REGISTRATION_HASH(uint contextHash, uint nameHash, ref bool value)` | bool | - |
| `NETWORK_ACCESS_TUNABLE_FLOAT` | `bool NETWORK_ACCESS_TUNABLE_FLOAT(string tunableContext, string tunableName, ref float value)` | bool | - |
| `NETWORK_ACCESS_TUNABLE_FLOAT_HASH` | `bool NETWORK_ACCESS_TUNABLE_FLOAT_HASH(uint tunableContext, uint tunableName, ref float value)` | bool | - |
| `NETWORK_ACCESS_TUNABLE_FLOAT_MODIFICATION_DETECTION_REGISTRATION_HASH` | `bool NETWORK_ACCESS_TUNABLE_FLOAT_MODIFICATION_DETECTION_REGISTRATION_HASH(uint contextHash, uint nameHash, ref float value)` | bool | - |
| `NETWORK_ACCESS_TUNABLE_INT` | `bool NETWORK_ACCESS_TUNABLE_INT(string tunableContext, string tunableName, ref int value)` | bool | - |
| `NETWORK_ACCESS_TUNABLE_INT_HASH` | `bool NETWORK_ACCESS_TUNABLE_INT_HASH(uint tunableContext, uint tunableName, ref int value)` | bool | - |
| `NETWORK_ACCESS_TUNABLE_INT_MODIFICATION_DETECTION_REGISTRATION_HASH` | `bool NETWORK_ACCESS_TUNABLE_INT_MODIFICATION_DETECTION_REGISTRATION_HASH(uint contextHash, uint nameHash, ref int value)` | bool | - |
| `NETWORK_ACCESS_TUNABLE_MODIFICATION_DETECTION_CLEAR` | `bool NETWORK_ACCESS_TUNABLE_MODIFICATION_DETECTION_CLEAR()` | bool | - |
| `NETWORK_ACTION_FOLLOW_INVITE` | `bool NETWORK_ACTION_FOLLOW_INVITE()` | bool | - |
| `NETWORK_ADD_CLIENT_ENTITY_ANGLED_AREA` | `int NETWORK_ADD_CLIENT_ENTITY_ANGLED_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float radius)` | int | - |
| `NETWORK_ADD_CLIENT_ENTITY_AREA` | `int NETWORK_ADD_CLIENT_ENTITY_AREA(float x1, float y1, float z1, float x2, float y2, float z2)` | int | - |
| `NETWORK_ADD_ENTITY_ANGLED_AREA` | `int NETWORK_ADD_ENTITY_ANGLED_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float width)` | int | To remove, see: NETWORK_REMOVE_ENTITY_AREA<br>See IS_POINT_IN_ANGLED_AREA for the definition of an angl... |
| `NETWORK_ADD_ENTITY_AREA` | `int NETWORK_ADD_ENTITY_AREA(float x1, float y1, float z1, float x2, float y2, float z2)` | int | - |
| `NETWORK_ADD_ENTITY_TO_SYNCHRONISED_SCENE` | `void NETWORK_ADD_ENTITY_TO_SYNCHRONISED_SCENE(int entity, int netScene, string animDict, string animName, float speed, float speedMulitiplier, int flag)` | void | - |
| `NETWORK_ADD_FOLLOWERS` | `void NETWORK_ADD_FOLLOWERS(ref int p0, int p1)` | void | .. |
| `NETWORK_ADD_FRIEND` | `bool NETWORK_ADD_FRIEND(ref object gamerHandle, string message)` | bool | - |
| `NETWORK_ADD_INVALID_OBJECT_MODEL` | `void NETWORK_ADD_INVALID_OBJECT_MODEL(uint modelHash, object p1)` | void | - |
| `NETWORK_ADD_MAP_ENTITY_TO_SYNCHRONISED_SCENE` | `void NETWORK_ADD_MAP_ENTITY_TO_SYNCHRONISED_SCENE(int netScene, uint modelHash, float x, float y, float z, float p5, string p6, float p7, float p8, int flags)` | void | Similar structure as NETWORK_ADD_ENTITY_TO_SYNCHRONISED_SCENE but it includes this time a hash.<br>In c... |
| `NETWORK_ADD_PED_TO_SYNCHRONISED_SCENE` | `void NETWORK_ADD_PED_TO_SYNCHRONISED_SCENE(int ped, int netScene, string animDict, string animnName, float speed, float speedMultiplier, int duration, int flag, float playbackRate, object p9)` | void | - |
| `NETWORK_ADD_PED_TO_SYNCHRONISED_SCENE_WITH_IK` | `void NETWORK_ADD_PED_TO_SYNCHRONISED_SCENE_WITH_IK(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9)` | void | - |
| `NETWORK_ADD_SYNCHRONISED_SCENE_CAMERA` | `void NETWORK_ADD_SYNCHRONISED_SCENE_CAMERA(int netScene, string animDict, string animName)` | void | - |
| `NETWORK_ALLOW_CLONING_WHILE_IN_TUTORIAL` | `void NETWORK_ALLOW_CLONING_WHILE_IN_TUTORIAL(object p0, object p1)` | void | - |
| `NETWORK_ALLOW_GANG_TO_JOIN_TUTORIAL_SESSION` | `void NETWORK_ALLOW_GANG_TO_JOIN_TUTORIAL_SESSION(int teamId, int instanceId)` | void | teamId must be < 3, instanceId must be < 64 |
| `NETWORK_ALLOW_INVITE_PROCESS_IN_PLAYER_SWITCH` | `void NETWORK_ALLOW_INVITE_PROCESS_IN_PLAYER_SWITCH(bool p0)` | void | - |
| `NETWORK_ALLOW_REMOTE_ATTACHMENT_MODIFICATION` | `void NETWORK_ALLOW_REMOTE_ATTACHMENT_MODIFICATION(int entity, bool toggle)` | void | - |
| `NETWORK_ALLOW_REMOTE_SYNCED_SCENE_LOCAL_PLAYER_REQUESTS` | `void NETWORK_ALLOW_REMOTE_SYNCED_SCENE_LOCAL_PLAYER_REQUESTS(object p0)` | void | - |
| `NETWORK_AM_I_BLOCKED_BY_GAMER` | `bool NETWORK_AM_I_BLOCKED_BY_GAMER(ref object gamerHandle)` | bool | - |
| `NETWORK_AM_I_BLOCKED_BY_PLAYER` | `bool NETWORK_AM_I_BLOCKED_BY_PLAYER(int player)` | bool | - |
| `NETWORK_AM_I_MUTED_BY_GAMER` | `bool NETWORK_AM_I_MUTED_BY_GAMER(ref object gamerHandle)` | bool | - |
| `NETWORK_AM_I_MUTED_BY_PLAYER` | `bool NETWORK_AM_I_MUTED_BY_PLAYER(int player)` | bool | - |
| `NETWORK_APPLY_CACHED_PLAYER_HEAD_BLEND_DATA` | `bool NETWORK_APPLY_CACHED_PLAYER_HEAD_BLEND_DATA(int ped, int player)` | bool | - |
| `NETWORK_APPLY_PED_SCAR_DATA` | `void NETWORK_APPLY_PED_SCAR_DATA(int ped, int p1)` | void | - |
| `NETWORK_APPLY_TRANSITION_PARAMETER` | `void NETWORK_APPLY_TRANSITION_PARAMETER(int p0, int p1)` | void | - |
| `NETWORK_APPLY_TRANSITION_PARAMETER_STRING` | `void NETWORK_APPLY_TRANSITION_PARAMETER_STRING(int p0, string string, bool p2)` | void | - |
| `NETWORK_APPLY_VOICE_PROXIMITY_OVERRIDE` | `void NETWORK_APPLY_VOICE_PROXIMITY_OVERRIDE(float x, float y, float z)` | void | - |
| `NETWORK_ARE_HANDLES_THE_SAME` | `bool NETWORK_ARE_HANDLES_THE_SAME(ref object gamerHandle1, ref object gamerHandle2)` | bool | - |
| `NETWORK_ARE_PLAYERS_IN_SAME_TUTORIAL_SESSION` | `bool NETWORK_ARE_PLAYERS_IN_SAME_TUTORIAL_SESSION(int player, int index)` | bool | - |
| `NETWORK_ARE_SOCIAL_CLUB_POLICIES_CURRENT` | `bool NETWORK_ARE_SOCIAL_CLUB_POLICIES_CURRENT()` | bool | - |
| `NETWORK_ARE_TRANSITION_DETAILS_VALID` | `bool NETWORK_ARE_TRANSITION_DETAILS_VALID(object p0)` | bool | - |
| `NETWORK_ATTACH_SYNCHRONISED_SCENE_TO_ENTITY` | `void NETWORK_ATTACH_SYNCHRONISED_SCENE_TO_ENTITY(int netScene, int entity, int bone)` | void | - |
| `NETWORK_BAIL` | `void NETWORK_BAIL(int p0, int p1, int p2)` | void | - |
| `NETWORK_BAIL_TRANSITION` | `void NETWORK_BAIL_TRANSITION(int p0, int p1, int p2)` | void | - |
| `NETWORK_BLOCK_INVITES` | `void NETWORK_BLOCK_INVITES(bool toggle)` | void | - |
| `NETWORK_BLOCK_JOIN_QUEUE_INVITES` | `void NETWORK_BLOCK_JOIN_QUEUE_INVITES(bool toggle)` | void | - |
| `NETWORK_BLOCK_PROXY_MIGRATION_BETWEEN_TUTORIAL_SESSIONS` | `void NETWORK_BLOCK_PROXY_MIGRATION_BETWEEN_TUTORIAL_SESSIONS(object p0)` | void | - |
| `NETWORK_CACHE_LOCAL_PLAYER_HEAD_BLEND_DATA` | `void NETWORK_CACHE_LOCAL_PLAYER_HEAD_BLEND_DATA()` | void | - |
| `NETWORK_CANCEL_RESPAWN_SEARCH` | `void NETWORK_CANCEL_RESPAWN_SEARCH()` | void | - |
| `NETWORK_CANCEL_TRANSITION_MATCHMAKING` | `void NETWORK_CANCEL_TRANSITION_MATCHMAKING()` | void | - |
| `NETWORK_CAN_ACCESS_MULTIPLAYER` | `bool NETWORK_CAN_ACCESS_MULTIPLAYER(ref int loadingState)` | bool | 11 - Need to download tunables.<br>12 - Need to download background script.<br><br>Returns 1 if the multiplay... |
| `NETWORK_CAN_BAIL` | `bool NETWORK_CAN_BAIL()` | bool | - |
| `NETWORK_CAN_COMMUNICATE_WITH_GAMER` | `bool NETWORK_CAN_COMMUNICATE_WITH_GAMER(ref object gamerHandle)` | bool | - |
| `NETWORK_CAN_ENTER_MULTIPLAYER` | `bool NETWORK_CAN_ENTER_MULTIPLAYER()` | bool | - |
| `NETWORK_CAN_GAMER_PLAY_MULTIPLAYER_WITH_ME` | `bool NETWORK_CAN_GAMER_PLAY_MULTIPLAYER_WITH_ME(ref object gamerHandle)` | bool | - |
| `NETWORK_CAN_PLAY_MULTIPLAYER_WITH_GAMER` | `bool NETWORK_CAN_PLAY_MULTIPLAYER_WITH_GAMER(ref object gamerHandle)` | bool | - |
| `NETWORK_CAN_QUEUE_FOR_PREVIOUS_SESSION_JOIN` | `bool NETWORK_CAN_QUEUE_FOR_PREVIOUS_SESSION_JOIN()` | bool | - |
| `NETWORK_CAN_RECEIVE_LOCAL_INVITE` | `bool NETWORK_CAN_RECEIVE_LOCAL_INVITE(ref object gamerHandle)` | bool | - |
| `NETWORK_CAN_SEND_LOCAL_INVITE` | `bool NETWORK_CAN_SEND_LOCAL_INVITE(ref object gamerHandle)` | bool | - |
| `NETWORK_CAN_SESSION_END` | `bool NETWORK_CAN_SESSION_END()` | bool | - |
| `NETWORK_CAN_SET_WAYPOINT` | `bool NETWORK_CAN_SET_WAYPOINT()` | bool | - |
| `NETWORK_CAN_TEXT_CHAT_WITH_GAMER` | `bool NETWORK_CAN_TEXT_CHAT_WITH_GAMER(ref object gamerHandle)` | bool | - |
| `NETWORK_CAN_VIEW_GAMER_USER_CONTENT` | `bool NETWORK_CAN_VIEW_GAMER_USER_CONTENT(ref object gamerHandle)` | bool | - |
| `NETWORK_CHANGE_TRANSITION_SLOTS` | `void NETWORK_CHANGE_TRANSITION_SLOTS(object p0, bool p1)` | void | - |
| `NETWORK_CHECK_CAN_ACCESS_AND_ALERT` | `bool NETWORK_CHECK_CAN_ACCESS_AND_ALERT()` | bool | - |
| `NETWORK_CHECK_COMMUNICATION_PRIVILEGES` | `bool NETWORK_CHECK_COMMUNICATION_PRIVILEGES(int p0, int p1, bool p2)` | bool | - |
| `NETWORK_CHECK_DATA_MANAGER_FOR_HANDLE` | `bool NETWORK_CHECK_DATA_MANAGER_FOR_HANDLE(object p0, ref object gamerHandle)` | bool | - |
| `NETWORK_CHECK_DATA_MANAGER_SUCCEEDED_FOR_HANDLE` | `bool NETWORK_CHECK_DATA_MANAGER_SUCCEEDED_FOR_HANDLE(int p0, ref object gamerHandle)` | bool | - |
| `NETWORK_CHECK_ONLINE_PRIVILEGES` | `bool NETWORK_CHECK_ONLINE_PRIVILEGES(object p0, bool p1)` | bool | - |
| `NETWORK_CHECK_PRIVILEGES` | `bool NETWORK_CHECK_PRIVILEGES(object p0, object p1, object p2)` | bool | - |
| `NETWORK_CHECK_ROS_LINK_WENTDOWN_NOT_NET` | `bool NETWORK_CHECK_ROS_LINK_WENTDOWN_NOT_NET()` | bool | Returns true if profile setting 901 is set to true and sets it to false. |
| `NETWORK_CHECK_TEXT_COMMUNICATION_PRIVILEGES` | `bool NETWORK_CHECK_TEXT_COMMUNICATION_PRIVILEGES(object p0, object p1, object p2)` | bool | - |
| `NETWORK_CHECK_USER_CONTENT_PRIVILEGES` | `bool NETWORK_CHECK_USER_CONTENT_PRIVILEGES(int p0, int p1, bool p2)` | bool | - |
| `NETWORK_CLAN_ANY_DOWNLOAD_MEMBERSHIP_PENDING` | `bool NETWORK_CLAN_ANY_DOWNLOAD_MEMBERSHIP_PENDING()` | bool | - |
| `NETWORK_CLAN_CREWINFO_GET_CREWRANKTITLE` | `bool NETWORK_CLAN_CREWINFO_GET_CREWRANKTITLE(int p0, string p1)` | bool | - |
| `NETWORK_CLAN_CREWINFO_GET_STRING_VALUE` | `bool NETWORK_CLAN_CREWINFO_GET_STRING_VALUE(string animDict, string animName)` | bool | Only documented...<br><br>Full list of animation dictionaries and anims by DurtyFree: https://github.com/D... |
| `NETWORK_CLAN_DOWNLOAD_MEMBERSHIP` | `bool NETWORK_CLAN_DOWNLOAD_MEMBERSHIP(ref object gamerHandle)` | bool | - |
| `NETWORK_CLAN_DOWNLOAD_MEMBERSHIP_PENDING` | `bool NETWORK_CLAN_DOWNLOAD_MEMBERSHIP_PENDING(ref object p0)` | bool | - |
| `NETWORK_CLAN_GET_EMBLEM_TXD_NAME` | `bool NETWORK_CLAN_GET_EMBLEM_TXD_NAME(ref object netHandle, string txdName)` | bool | - |
| `NETWORK_CLAN_GET_LOCAL_MEMBERSHIPS_COUNT` | `int NETWORK_CLAN_GET_LOCAL_MEMBERSHIPS_COUNT()` | int | - |
| `NETWORK_CLAN_GET_MEMBERSHIP` | `bool NETWORK_CLAN_GET_MEMBERSHIP(ref int p0, ref object clanMembership, int p2)` | bool | - |
| `NETWORK_CLAN_GET_MEMBERSHIP_COUNT` | `int NETWORK_CLAN_GET_MEMBERSHIP_COUNT(ref int p0)` | int | - |
| `NETWORK_CLAN_GET_MEMBERSHIP_DESC` | `bool NETWORK_CLAN_GET_MEMBERSHIP_DESC(ref object memberDesc, int p1)` | bool | - |
| `NETWORK_CLAN_GET_MEMBERSHIP_VALID` | `bool NETWORK_CLAN_GET_MEMBERSHIP_VALID(ref int p0, object p1)` | bool | - |
| `NETWORK_CLAN_GET_UI_FORMATTED_TAG` | `void NETWORK_CLAN_GET_UI_FORMATTED_TAG(ref object clanDesc, int bufferSize, string formattedTag)` | void | bufferSize is 35 in the scripts. |
| `NETWORK_CLAN_HAS_CREWINFO_METADATA_BEEN_RECEIVED` | `bool NETWORK_CLAN_HAS_CREWINFO_METADATA_BEEN_RECEIVED()` | bool | - |
| `NETWORK_CLAN_IS_EMBLEM_READY` | `bool NETWORK_CLAN_IS_EMBLEM_READY(object p0, ref object p1)` | bool | - |
| `NETWORK_CLAN_IS_ROCKSTAR_CLAN` | `bool NETWORK_CLAN_IS_ROCKSTAR_CLAN(ref object clanDesc, int bufferSize)` | bool | bufferSize is 35 in the scripts. |
| `NETWORK_CLAN_JOIN` | `bool NETWORK_CLAN_JOIN(int clanDesc)` | bool | - |
| `NETWORK_CLAN_PLAYER_GET_DESC` | `bool NETWORK_CLAN_PLAYER_GET_DESC(ref object clanDesc, int bufferSize, ref object gamerHandle)` | bool | bufferSize is 35 in the scripts.<br><br>bufferSize is the elementCount of p0(desc), sizeof(p0) == 280 == p... |
| `NETWORK_CLAN_PLAYER_IS_ACTIVE` | `bool NETWORK_CLAN_PLAYER_IS_ACTIVE(ref object gamerHandle)` | bool | - |
| `NETWORK_CLAN_RELEASE_EMBLEM` | `void NETWORK_CLAN_RELEASE_EMBLEM(object p0)` | void | - |
| `NETWORK_CLAN_REMOTE_MEMBERSHIPS_ARE_IN_CACHE` | `bool NETWORK_CLAN_REMOTE_MEMBERSHIPS_ARE_IN_CACHE(ref int p0)` | bool | - |
| `NETWORK_CLAN_REQUEST_EMBLEM` | `bool NETWORK_CLAN_REQUEST_EMBLEM(object p0)` | bool | - |
| `NETWORK_CLAN_SERVICE_IS_VALID` | `bool NETWORK_CLAN_SERVICE_IS_VALID()` | bool | - |
| `NETWORK_CLEAR_CLOCK_TIME_OVERRIDE` | `void NETWORK_CLEAR_CLOCK_TIME_OVERRIDE()` | void | - |
| `NETWORK_CLEAR_FOLLOWERS` | `void NETWORK_CLEAR_FOLLOWERS()` | void | - |
| `NETWORK_CLEAR_FOLLOW_INVITE` | `bool NETWORK_CLEAR_FOLLOW_INVITE()` | bool | - |
| `NETWORK_CLEAR_FOUND_GAMERS` | `void NETWORK_CLEAR_FOUND_GAMERS()` | void | - |
| `NETWORK_CLEAR_GET_GAMER_STATUS` | `void NETWORK_CLEAR_GET_GAMER_STATUS()` | void | - |
| `NETWORK_CLEAR_GROUP_ACTIVITY` | `void NETWORK_CLEAR_GROUP_ACTIVITY()` | void | - |
| `NETWORK_CLEAR_INVALID_OBJECT_MODELS` | `void NETWORK_CLEAR_INVALID_OBJECT_MODELS()` | void | - |
| `NETWORK_CLEAR_OFFLINE_INVITE_PENDING` | `void NETWORK_CLEAR_OFFLINE_INVITE_PENDING()` | void | - |
| `NETWORK_CLEAR_QUEUED_JOIN_REQUEST` | `void NETWORK_CLEAR_QUEUED_JOIN_REQUEST()` | void | - |
| `NETWORK_CLEAR_TRANSITION_CREATOR_HANDLE` | `void NETWORK_CLEAR_TRANSITION_CREATOR_HANDLE()` | void | - |
| `NETWORK_CLEAR_VOICE_CHANNEL` | `void NETWORK_CLEAR_VOICE_CHANNEL()` | void | - |
| `NETWORK_CLEAR_VOICE_PROXIMITY_OVERRIDE` | `void NETWORK_CLEAR_VOICE_PROXIMITY_OVERRIDE()` | void | - |
| `NETWORK_CLOSE_TRANSITION_MATCHMAKING` | `void NETWORK_CLOSE_TRANSITION_MATCHMAKING()` | void | - |
| `NETWORK_CONCEAL_ENTITY` | `void NETWORK_CONCEAL_ENTITY(int entity, bool toggle)` | void | - |
| `NETWORK_CONCEAL_PLAYER` | `void NETWORK_CONCEAL_PLAYER(int player, bool toggle, bool p2)` | void | - |
| `NETWORK_CREATE_SYNCHRONISED_SCENE` | `int NETWORK_CREATE_SYNCHRONISED_SCENE(float x, float y, float z, float xRot, float yRot, float zRot, int rotationOrder, bool useOcclusionPortal, bool looped, float p9, float animTime, float p11)` | int | - |
| `NETWORK_DID_FIND_GAMERS_SUCCEED` | `bool NETWORK_DID_FIND_GAMERS_SUCCEED()` | bool | - |
| `NETWORK_DID_GET_GAMER_STATUS_SUCCEED` | `bool NETWORK_DID_GET_GAMER_STATUS_SUCCEED()` | bool | - |
| `NETWORK_DISABLE_INVINCIBLE_FLASHING` | `void NETWORK_DISABLE_INVINCIBLE_FLASHING(int player, bool toggle)` | void | - |
| `NETWORK_DISABLE_LEAVE_REMOTE_PED_BEHIND` | `void NETWORK_DISABLE_LEAVE_REMOTE_PED_BEHIND(bool toggle)` | void | - |
| `NETWORK_DISABLE_PROXIMITY_MIGRATION` | `void NETWORK_DISABLE_PROXIMITY_MIGRATION(int netID)` | void | - |
| `NETWORK_DISABLE_REALTIME_MULTIPLAYER` | `void NETWORK_DISABLE_REALTIME_MULTIPLAYER()` | void | - |
| `NETWORK_DISABLE_VOICE_BANDWIDTH_RESTRICTION` | `void NETWORK_DISABLE_VOICE_BANDWIDTH_RESTRICTION(int player)` | void | - |
| `NETWORK_DISPLAYNAMES_FROM_HANDLES_START` | `int NETWORK_DISPLAYNAMES_FROM_HANDLES_START(ref object p0, object p1)` | int | Hardcoded to return -1. |
| `NETWORK_DOES_ENTITY_EXIST_WITH_NETWORK_ID` | `bool NETWORK_DOES_ENTITY_EXIST_WITH_NETWORK_ID(int netId)` | bool | - |
| `NETWORK_DOES_NETWORK_ID_EXIST` | `bool NETWORK_DOES_NETWORK_ID_EXIST(int netId)` | bool | - |
| `NETWORK_DOES_TUNABLE_EXIST` | `bool NETWORK_DOES_TUNABLE_EXIST(string tunableContext, string tunableName)` | bool | - |
| `NETWORK_DOES_TUNABLE_EXIST_HASH` | `bool NETWORK_DOES_TUNABLE_EXIST_HASH(uint tunableContext, uint tunableName)` | bool | - |
| `NETWORK_DO_TRANSITION_QUICKMATCH` | `bool NETWORK_DO_TRANSITION_QUICKMATCH(object p0, object p1, object p2, object p3, object p4, object p5)` | bool | - |
| `NETWORK_DO_TRANSITION_QUICKMATCH_ASYNC` | `bool NETWORK_DO_TRANSITION_QUICKMATCH_ASYNC(object p0, object p1, object p2, object p3, object p4, object p5)` | bool | - |
| `NETWORK_DO_TRANSITION_QUICKMATCH_WITH_GROUP` | `bool NETWORK_DO_TRANSITION_QUICKMATCH_WITH_GROUP(object p0, object p1, object p2, object p3, ref object p4, object p5, object p6, object p7)` | bool | - |
| `NETWORK_DO_TRANSITION_TO_FREEMODE` | `bool NETWORK_DO_TRANSITION_TO_FREEMODE(ref object p0, object p1, bool p2, int players, bool p4)` | bool | p2 is true 3/4 of the occurrences I found.<br>'players' is the number of players for a session. On PS3/... |
| `NETWORK_DO_TRANSITION_TO_GAME` | `bool NETWORK_DO_TRANSITION_TO_GAME(bool p0, int maxPlayers)` | bool | - |
| `NETWORK_DO_TRANSITION_TO_NEW_FREEMODE` | `bool NETWORK_DO_TRANSITION_TO_NEW_FREEMODE(ref object p0, object p1, int players, bool p3, bool p4, bool p5)` | bool | - |
| `NETWORK_DO_TRANSITION_TO_NEW_GAME` | `bool NETWORK_DO_TRANSITION_TO_NEW_GAME(bool p0, int maxPlayers, bool p2)` | bool | - |
| `NETWORK_DUMP_NET_IF_CONFIG` | `void NETWORK_DUMP_NET_IF_CONFIG()` | void | Does nothing (it's a nullsub). |
| `NETWORK_ENABLE_EXTRA_VEHICLE_ORIENTATION_BLEND_CHECKS` | `void NETWORK_ENABLE_EXTRA_VEHICLE_ORIENTATION_BLEND_CHECKS(int netId, bool toggle)` | void | - |
| `NETWORK_ENABLE_VOICE_BANDWIDTH_RESTRICTION` | `void NETWORK_ENABLE_VOICE_BANDWIDTH_RESTRICTION(int player)` | void | - |
| `NETWORK_END_TUTORIAL_SESSION` | `void NETWORK_END_TUTORIAL_SESSION()` | void | - |
| `NETWORK_ENTITY_AREA_DOES_EXIST` | `bool NETWORK_ENTITY_AREA_DOES_EXIST(int areaHandle)` | bool | - |
| `NETWORK_ENTITY_AREA_HAVE_ALL_REPLIED` | `bool NETWORK_ENTITY_AREA_HAVE_ALL_REPLIED(int areaHandle)` | bool | - |
| `NETWORK_ENTITY_AREA_IS_OCCUPIED` | `bool NETWORK_ENTITY_AREA_IS_OCCUPIED(int areaHandle)` | bool | - |
| `NETWORK_ENTITY_GET_OBJECT_ID` | `int NETWORK_ENTITY_GET_OBJECT_ID(int entity)` | int | - |
| `NETWORK_ENTITY_USE_HIGH_PRECISION_ROTATION` | `void NETWORK_ENTITY_USE_HIGH_PRECISION_ROTATION(int netId, bool toggle)` | void | - |
| `NETWORK_EXPLODE_HELI` | `void NETWORK_EXPLODE_HELI(int vehicle, bool isAudible, bool isInvisible, int netId)` | void | - |
| `NETWORK_EXPLODE_VEHICLE` | `bool NETWORK_EXPLODE_VEHICLE(int vehicle, bool isAudible, bool isInvisible, int netId)` | bool | In the console script dumps, this is only referenced once. <br>NETWORK::NETWORK_EXPLODE_VEHICLE(vehicle... |
| `NETWORK_FADE_IN_ENTITY` | `void NETWORK_FADE_IN_ENTITY(int entity, bool state, object p2)` | void | state - 0 does 5 fades<br>state - 1 does 6 fades<br><br>p3: setting to 1 made vehicle fade in slower, probabl... |
| `NETWORK_FADE_OUT_ENTITY` | `void NETWORK_FADE_OUT_ENTITY(int entity, bool normal, bool slow)` | void | normal - transition like when your coming out of LSC<br>slow - transition like when you walk into a mis... |
| `NETWORK_FIND_GAMERS_IN_CREW` | `bool NETWORK_FIND_GAMERS_IN_CREW(int crewId)` | bool | - |
| `NETWORK_FIND_LARGEST_BUNCH_OF_PLAYERS` | `bool NETWORK_FIND_LARGEST_BUNCH_OF_PLAYERS(int p0, object p1)` | bool | p0 is always 0. p1 is pointing to a global. |
| `NETWORK_FIND_MATCHED_GAMERS` | `bool NETWORK_FIND_MATCHED_GAMERS(int attribute, float fallbackLimit, float lowerLimit, float upperLimit)` | bool | Uses attributes to find players with similar stats. Upper/Lower limit must be above zero or the fall... |
| `NETWORK_FINISH_BROADCASTING_DATA` | `void NETWORK_FINISH_BROADCASTING_DATA()` | void | - |
| `NETWORK_FORCE_LOCAL_PLAYER_SCAR_SYNC` | `void NETWORK_FORCE_LOCAL_PLAYER_SCAR_SYNC()` | void | NETWORK_F[I-O] |
| `NETWORK_FORCE_LOCAL_USE_OF_SYNCED_SCENE_CAMERA` | `void NETWORK_FORCE_LOCAL_USE_OF_SYNCED_SCENE_CAMERA(int netScene)` | void | - |
| `NETWORK_GAMERTAG_FROM_HANDLE_PENDING` | `bool NETWORK_GAMERTAG_FROM_HANDLE_PENDING()` | bool | - |
| `NETWORK_GAMERTAG_FROM_HANDLE_START` | `bool NETWORK_GAMERTAG_FROM_HANDLE_START(ref object gamerHandle)` | bool | - |
| `NETWORK_GAMERTAG_FROM_HANDLE_SUCCEEDED` | `bool NETWORK_GAMERTAG_FROM_HANDLE_SUCCEEDED()` | bool | - |
| `NETWORK_GAMER_HAS_HEADSET` | `bool NETWORK_GAMER_HAS_HEADSET(ref object gamerHandle)` | bool | - |
| `NETWORK_GET_ACTIVITY_PLAYER_NUM` | `int NETWORK_GET_ACTIVITY_PLAYER_NUM(bool p0)` | int | - |
| `NETWORK_GET_AGE_GROUP` | `int NETWORK_GET_AGE_GROUP()` | int | - |
| `NETWORK_GET_ASSISTED_DAMAGE_OF_ENTITY` | `bool NETWORK_GET_ASSISTED_DAMAGE_OF_ENTITY(int player, int entity, ref int p2)` | bool | - |
| `NETWORK_GET_ASSISTED_KILL_OF_ENTITY` | `bool NETWORK_GET_ASSISTED_KILL_OF_ENTITY(int player, int entity, ref int p2)` | bool | NETWORK_GET_ASSISTED_DAMAGE_OF_ENTITY that ensures the entity is dead (IS_ENTITY_DEAD) |
| `NETWORK_GET_AVERAGE_LATENCY` | `float NETWORK_GET_AVERAGE_LATENCY(int player)` | float | - |
| `NETWORK_GET_AVERAGE_PACKET_LOSS` | `float NETWORK_GET_AVERAGE_PACKET_LOSS(int player)` | float | - |
| `NETWORK_GET_AVERAGE_PING` | `float NETWORK_GET_AVERAGE_PING(int player)` | float | Same as NETWORK_GET_AVERAGE_LATENCY |
| `NETWORK_GET_BONE_ID_OF_FATAL_HIT` | `int NETWORK_GET_BONE_ID_OF_FATAL_HIT()` | int | - |
| `NETWORK_GET_CONTENT_MODIFIER_LIST_ID` | `int NETWORK_GET_CONTENT_MODIFIER_LIST_ID(uint contentHash)` | int | Return the content modifier id (the tunables context if you want) of a specific content.<br><br>It takes t... |
| `NETWORK_GET_CURRENTLY_SELECTED_GAMER_HANDLE_FROM_INVITE_MENU` | `bool NETWORK_GET_CURRENTLY_SELECTED_GAMER_HANDLE_FROM_INVITE_MENU(ref object p0)` | bool | - |
| `NETWORK_GET_DESTROYER_OF_ENTITY` | `int NETWORK_GET_DESTROYER_OF_ENTITY(int entity, Hash* weaponHash)` | int | - |
| `NETWORK_GET_DESTROYER_OF_NETWORK_ID` | `int NETWORK_GET_DESTROYER_OF_NETWORK_ID(int netId, Hash* weaponHash)` | int | - |
| `NETWORK_GET_DISPLAYNAMES_FROM_HANDLES` | `int NETWORK_GET_DISPLAYNAMES_FROM_HANDLES(object p0, object p1, object p2)` | int | This function is hard-coded to always return 0. |
| `NETWORK_GET_ENTITY_FROM_NETWORK_ID` | `int NETWORK_GET_ENTITY_FROM_NETWORK_ID(int netId)` | int | - |
| `NETWORK_GET_ENTITY_FROM_OBJECT_ID` | `int NETWORK_GET_ENTITY_FROM_OBJECT_ID(object p0)` | int | I've had this return the player's ped handle sometimes, but also other random entities.<br>Whatever p0 ... |
| `NETWORK_GET_ENTITY_IS_LOCAL` | `bool NETWORK_GET_ENTITY_IS_LOCAL(int entity)` | bool | - |
| `NETWORK_GET_ENTITY_IS_NETWORKED` | `bool NETWORK_GET_ENTITY_IS_NETWORKED(int entity)` | bool | - |
| `NETWORK_GET_ENTITY_KILLER_OF_PLAYER` | `int NETWORK_GET_ENTITY_KILLER_OF_PLAYER(int player, Hash* weaponHash)` | int | - |
| `NETWORK_GET_FOUND_GAMER` | `bool NETWORK_GET_FOUND_GAMER(ref object p0, object p1)` | bool | - |
| `NETWORK_GET_FRIEND_COUNT` | `int NETWORK_GET_FRIEND_COUNT()` | int | - |
| `NETWORK_GET_FRIEND_DISPLAY_NAME` | `string NETWORK_GET_FRIEND_DISPLAY_NAME(int friendIndex)` | string | - |
| `NETWORK_GET_FRIEND_NAME` | `string NETWORK_GET_FRIEND_NAME(int friendIndex)` | string | - |
| `NETWORK_GET_GAMERTAG_FROM_HANDLE` | `string NETWORK_GET_GAMERTAG_FROM_HANDLE(ref object gamerHandle)` | string | - |
| `NETWORK_GET_GAMER_STATUS_FROM_QUEUE` | `bool NETWORK_GET_GAMER_STATUS_FROM_QUEUE()` | bool | - |
| `NETWORK_GET_GAMER_STATUS_RESULT` | `bool NETWORK_GET_GAMER_STATUS_RESULT(ref object p0, object p1)` | bool | - |
| `NETWORK_GET_GAME_MODE` | `int NETWORK_GET_GAME_MODE()` | int | - |
| `NETWORK_GET_GLOBAL_MULTIPLAYER_CLOCK` | `void NETWORK_GET_GLOBAL_MULTIPLAYER_CLOCK(ref int hours, ref int minutes, ref int seconds)` | void | - |
| `NETWORK_GET_HIGHEST_RELIABLE_RESEND_COUNT` | `int NETWORK_GET_HIGHEST_RELIABLE_RESEND_COUNT(int player)` | int | - |
| `NETWORK_GET_HOST_OF_SCRIPT` | `int NETWORK_GET_HOST_OF_SCRIPT(string scriptName, int instance_id, int position_hash)` | int | scriptName examples:<br>"freemode", "AM_CR_SecurityVan", ...<br><br>Most of the time, these values are used:<br>... |
| `NETWORK_GET_HOST_OF_THIS_SCRIPT` | `int NETWORK_GET_HOST_OF_THIS_SCRIPT()` | int | - |
| `NETWORK_GET_HOST_OF_THREAD` | `int NETWORK_GET_HOST_OF_THREAD(int threadId)` | int | - |
| `NETWORK_GET_HOST_PLAYER_INDEX` | `int NETWORK_GET_HOST_PLAYER_INDEX()` | int | - |
| `NETWORK_GET_INSTANCE_ID_OF_THIS_SCRIPT` | `int NETWORK_GET_INSTANCE_ID_OF_THIS_SCRIPT()` | int | - |
| `NETWORK_GET_INVITE_REPLY_STATUS` | `int NETWORK_GET_INVITE_REPLY_STATUS(object p0)` | int | - |
| `NETWORK_GET_KILLER_OF_PLAYER` | `int NETWORK_GET_KILLER_OF_PLAYER(int player, Hash* weaponHash)` | int | - |
| `NETWORK_GET_LAST_ENTITY_POS_RECEIVED_OVER_NETWORK` | `Vector3 NETWORK_GET_LAST_ENTITY_POS_RECEIVED_OVER_NETWORK(int entity)` | Vector3 | - |
| `NETWORK_GET_LAST_PLAYER_POS_RECEIVED_OVER_NETWORK` | `Vector3 NETWORK_GET_LAST_PLAYER_POS_RECEIVED_OVER_NETWORK(int player)` | Vector3 | Returns the coordinates of another player.<br>Does not work if you enter your own player id as p0 (will... |
| `NETWORK_GET_LAST_VEL_RECEIVED_OVER_NETWORK` | `Vector3 NETWORK_GET_LAST_VEL_RECEIVED_OVER_NETWORK(int entity)` | Vector3 | Used by NetBlender |
| `NETWORK_GET_LOCAL_HANDLE` | `void NETWORK_GET_LOCAL_HANDLE(ref object gamerHandle, int gamerHandleSize)` | void | - |
| `NETWORK_GET_LOCAL_SCENE_FROM_NETWORK_ID` | `int NETWORK_GET_LOCAL_SCENE_FROM_NETWORK_ID(int netId)` | int | - |
| `NETWORK_GET_MAX_FRIENDS` | `int NETWORK_GET_MAX_FRIENDS()` | int | - |
| `NETWORK_GET_MAX_NUM_PARTICIPANTS` | `int NETWORK_GET_MAX_NUM_PARTICIPANTS()` | int | - |
| `NETWORK_GET_MUTE_COUNT_FOR_PLAYER` | `void NETWORK_GET_MUTE_COUNT_FOR_PLAYER(int p0, ref float p1, ref float p2)` | void | NETWORK_GET_M[A-U] |
| `NETWORK_GET_NETWORK_ID_FROM_ENTITY` | `int NETWORK_GET_NETWORK_ID_FROM_ENTITY(int entity)` | int | - |
| `NETWORK_GET_NET_STATISTICS_INFO` | `void NETWORK_GET_NET_STATISTICS_INFO(ref object p0)` | void | Does nothing (it's a nullsub). |
| `NETWORK_GET_NP_UNAVAILABLE_REASON` | `int NETWORK_GET_NP_UNAVAILABLE_REASON()` | int | Hardcoded to return zero.<br><br>==== PS4 specific info ====<br><br>Returns some sort of unavailable reason:<br>-1 ... |
| `NETWORK_GET_NUMBER_BODY_TRACKER_HITS` | `int NETWORK_GET_NUMBER_BODY_TRACKER_HITS()` | int | - |
| `NETWORK_GET_NUM_CONNECTED_PLAYERS` | `int NETWORK_GET_NUM_CONNECTED_PLAYERS()` | int | Returns the amount of players connected in the current session. Only works when connected to a sessi... |
| `NETWORK_GET_NUM_FOUND_GAMERS` | `int NETWORK_GET_NUM_FOUND_GAMERS()` | int | - |
| `NETWORK_GET_NUM_PARTICIPANTS` | `int NETWORK_GET_NUM_PARTICIPANTS()` | int | - |
| `NETWORK_GET_NUM_PRESENCE_INVITES` | `int NETWORK_GET_NUM_PRESENCE_INVITES()` | int | - |
| `NETWORK_GET_NUM_SCRIPT_PARTICIPANTS` | `int NETWORK_GET_NUM_SCRIPT_PARTICIPANTS(string scriptName, int instance_id, int position_hash)` | int | - |
| `NETWORK_GET_NUM_TRANSITION_NON_ASYNC_GAMERS` | `int NETWORK_GET_NUM_TRANSITION_NON_ASYNC_GAMERS()` | int | - |
| `NETWORK_GET_NUM_UNACKED_RELIABLES` | `int NETWORK_GET_NUM_UNACKED_RELIABLES(int player)` | int | - |
| `NETWORK_GET_PARTICIPANT_INDEX` | `int NETWORK_GET_PARTICIPANT_INDEX(int index)` | int | - |
| `NETWORK_GET_PLATFORM_PARTY_MEMBERS` | `int NETWORK_GET_PLATFORM_PARTY_MEMBERS(ref object data, int dataSize)` | int | - |
| `NETWORK_GET_PLATFORM_PARTY_MEMBER_COUNT` | `int NETWORK_GET_PLATFORM_PARTY_MEMBER_COUNT()` | int | - |
| `NETWORK_GET_PLAYER_ACCOUNT_ID` | `int NETWORK_GET_PLAYER_ACCOUNT_ID(int player)` | int | - |
| `NETWORK_GET_PLAYER_FROM_GAMER_HANDLE` | `int NETWORK_GET_PLAYER_FROM_GAMER_HANDLE(ref object gamerHandle)` | int | - |
| `NETWORK_GET_PLAYER_INDEX` | `int NETWORK_GET_PLAYER_INDEX(int player)` | int | - |
| `NETWORK_GET_PLAYER_INDEX_FROM_PED` | `int NETWORK_GET_PLAYER_INDEX_FROM_PED(int ped)` | int | Returns the Player associated to a given Ped when in an online session. |
| `NETWORK_GET_PLAYER_LOUDNESS` | `float NETWORK_GET_PLAYER_LOUDNESS(int player)` | float | - |
| `NETWORK_GET_PLAYER_OWNS_WAYPOINT` | `bool NETWORK_GET_PLAYER_OWNS_WAYPOINT(int player)` | bool | - |
| `NETWORK_GET_PLAYER_TUTORIAL_SESSION_INSTANCE` | `int NETWORK_GET_PLAYER_TUTORIAL_SESSION_INSTANCE(int player)` | int | - |
| `NETWORK_GET_POSITION_HASH_OF_THIS_SCRIPT` | `uint NETWORK_GET_POSITION_HASH_OF_THIS_SCRIPT()` | uint | - |
| `NETWORK_GET_PREDICTED_VELOCITY` | `Vector3 NETWORK_GET_PREDICTED_VELOCITY(int entity, float maxSpeedToPredict)` | Vector3 | - |
| `NETWORK_GET_PRESENCE_INVITE_CONTENT_ID` | `string NETWORK_GET_PRESENCE_INVITE_CONTENT_ID(int p0)` | string | - |
| `NETWORK_GET_PRESENCE_INVITE_FROM_ADMIN` | `bool NETWORK_GET_PRESENCE_INVITE_FROM_ADMIN(int p0)` | bool | - |
| `NETWORK_GET_PRESENCE_INVITE_HANDLE` | `bool NETWORK_GET_PRESENCE_INVITE_HANDLE(object p0, ref object p1)` | bool | - |
| `NETWORK_GET_PRESENCE_INVITE_ID` | `int NETWORK_GET_PRESENCE_INVITE_ID(int p0)` | int | - |
| `NETWORK_GET_PRESENCE_INVITE_INDEX_BY_ID` | `int NETWORK_GET_PRESENCE_INVITE_INDEX_BY_ID(int p0)` | int | - |
| `NETWORK_GET_PRESENCE_INVITE_INVITER` | `string NETWORK_GET_PRESENCE_INVITE_INVITER(int p0)` | string | - |
| `NETWORK_GET_PRESENCE_INVITE_IS_TOURNAMENT` | `bool NETWORK_GET_PRESENCE_INVITE_IS_TOURNAMENT(object p0)` | bool | - |
| `NETWORK_GET_PRESENCE_INVITE_PLAYLIST_CURRENT` | `int NETWORK_GET_PRESENCE_INVITE_PLAYLIST_CURRENT(int p0)` | int | - |
| `NETWORK_GET_PRESENCE_INVITE_PLAYLIST_LENGTH` | `int NETWORK_GET_PRESENCE_INVITE_PLAYLIST_LENGTH(int p0)` | int | - |
| `NETWORK_GET_PRESENCE_INVITE_SESSION_ID` | `int NETWORK_GET_PRESENCE_INVITE_SESSION_ID(object p0)` | int | - |
| `NETWORK_GET_PRIMARY_CLAN_DATA_CANCEL` | `void NETWORK_GET_PRIMARY_CLAN_DATA_CANCEL()` | void | - |
| `NETWORK_GET_PRIMARY_CLAN_DATA_CLEAR` | `bool NETWORK_GET_PRIMARY_CLAN_DATA_CLEAR()` | bool | - |
| `NETWORK_GET_PRIMARY_CLAN_DATA_NEW` | `bool NETWORK_GET_PRIMARY_CLAN_DATA_NEW(ref object p0, ref object p1)` | bool | - |
| `NETWORK_GET_PRIMARY_CLAN_DATA_PENDING` | `bool NETWORK_GET_PRIMARY_CLAN_DATA_PENDING()` | bool | - |
| `NETWORK_GET_PRIMARY_CLAN_DATA_START` | `bool NETWORK_GET_PRIMARY_CLAN_DATA_START(ref object p0, object p1)` | bool | - |
| `NETWORK_GET_PRIMARY_CLAN_DATA_SUCCESS` | `bool NETWORK_GET_PRIMARY_CLAN_DATA_SUCCESS()` | bool | - |
| `NETWORK_GET_RANDOM_INT` | `int NETWORK_GET_RANDOM_INT()` | int | - |
| `NETWORK_GET_RANDOM_INT_RANGED` | `int NETWORK_GET_RANDOM_INT_RANGED(int rangeStart, int rangeEnd)` | int | Same as GET_RANDOM_INT_IN_RANGE |
| `NETWORK_GET_RESPAWN_RESULT` | `void NETWORK_GET_RESPAWN_RESULT(int randomInt, ref Vector3 coordinates, ref float heading)` | void | Based on scripts such as in freemode.c how they call their vars vVar and fVar the 2nd and 3rd param ... |
| `NETWORK_GET_RESPAWN_RESULT_FLAGS` | `int NETWORK_GET_RESPAWN_RESULT_FLAGS(int p0)` | int | - |
| `NETWORK_GET_SCRIPT_STATUS` | `int NETWORK_GET_SCRIPT_STATUS()` | int | - |
| `NETWORK_GET_SIGNALLING_INFO` | `void NETWORK_GET_SIGNALLING_INFO(ref object p0)` | void | Does nothing (it's a nullsub). |
| `NETWORK_GET_TALKER_PROXIMITY` | `float NETWORK_GET_TALKER_PROXIMITY()` | float | - |
| `NETWORK_GET_THIS_SCRIPT_IS_NETWORK_SCRIPT` | `bool NETWORK_GET_THIS_SCRIPT_IS_NETWORK_SCRIPT()` | bool | - |
| `NETWORK_GET_TIMEOUT_TIME` | `int NETWORK_GET_TIMEOUT_TIME()` | int | - |
| `NETWORK_GET_TOTAL_NUM_PLAYERS` | `int NETWORK_GET_TOTAL_NUM_PLAYERS()` | int | - |
| `NETWORK_GET_TRANSITION_HOST` | `bool NETWORK_GET_TRANSITION_HOST(ref object gamerHandle)` | bool | - |
| `NETWORK_GET_TRANSITION_MEMBERS` | `int NETWORK_GET_TRANSITION_MEMBERS(ref object data, int dataCount)` | int | Returns count. |
| `NETWORK_GET_TUNABLE_CLOUD_CRC` | `int NETWORK_GET_TUNABLE_CLOUD_CRC()` | int | Actually returns the version (TUNABLE_VERSION) |
| `NETWORK_GET_UNRELIABLE_RESEND_COUNT` | `int NETWORK_GET_UNRELIABLE_RESEND_COUNT(int player)` | int | - |
| `NETWORK_HANDLE_FROM_FRIEND` | `void NETWORK_HANDLE_FROM_FRIEND(int friendIndex, ref object gamerHandle, int gamerHandleSize)` | void | - |
| `NETWORK_HANDLE_FROM_MEMBER_ID` | `void NETWORK_HANDLE_FROM_MEMBER_ID(string memberId, ref object gamerHandle, int gamerHandleSize)` | void | - |
| `NETWORK_HANDLE_FROM_PLAYER` | `void NETWORK_HANDLE_FROM_PLAYER(int player, ref object gamerHandle, int gamerHandleSize)` | void | - |
| `NETWORK_HANDLE_FROM_USER_ID` | `void NETWORK_HANDLE_FROM_USER_ID(string userId, ref object gamerHandle, int gamerHandleSize)` | void | - |
| `NETWORK_HASH_FROM_GAMER_HANDLE` | `uint NETWORK_HASH_FROM_GAMER_HANDLE(ref object gamerHandle)` | uint | - |
| `NETWORK_HASH_FROM_PLAYER_HANDLE` | `uint NETWORK_HASH_FROM_PLAYER_HANDLE(int player)` | uint | - |
| `NETWORK_HAS_AGE_RESTRICTIONS` | `bool NETWORK_HAS_AGE_RESTRICTIONS()` | bool | - |
| `NETWORK_HAS_AUTOMUTE_OVERRIDE` | `bool NETWORK_HAS_AUTOMUTE_OVERRIDE()` | bool | - |
| `NETWORK_HAS_BONE_BEEN_HIT_BY_KILLER` | `bool NETWORK_HAS_BONE_BEEN_HIT_BY_KILLER(int boneIndex)` | bool | - |
| `NETWORK_HAS_CACHED_PLAYER_HEAD_BLEND_DATA` | `bool NETWORK_HAS_CACHED_PLAYER_HEAD_BLEND_DATA(int player)` | bool | - |
| `NETWORK_HAS_CONFIRMED_INVITE` | `bool NETWORK_HAS_CONFIRMED_INVITE()` | bool | - |
| `NETWORK_HAS_CONTROL_OF_DOOR` | `bool NETWORK_HAS_CONTROL_OF_DOOR(uint doorHash)` | bool | - |
| `NETWORK_HAS_CONTROL_OF_ENTITY` | `bool NETWORK_HAS_CONTROL_OF_ENTITY(int entity)` | bool | - |
| `NETWORK_HAS_CONTROL_OF_NETWORK_ID` | `bool NETWORK_HAS_CONTROL_OF_NETWORK_ID(int netId)` | bool | - |
| `NETWORK_HAS_CONTROL_OF_PICKUP` | `bool NETWORK_HAS_CONTROL_OF_PICKUP(int pickup)` | bool | - |
| `NETWORK_HAS_ENTITY_BEEN_REGISTERED_WITH_THIS_THREAD` | `bool NETWORK_HAS_ENTITY_BEEN_REGISTERED_WITH_THIS_THREAD(int entity)` | bool | - |
| `NETWORK_HAS_FOLLOW_INVITE` | `bool NETWORK_HAS_FOLLOW_INVITE()` | bool | - |
| `NETWORK_HAS_HEADSET` | `bool NETWORK_HAS_HEADSET()` | bool | - |
| `NETWORK_HAS_INVITED_GAMER` | `bool NETWORK_HAS_INVITED_GAMER(ref object p0)` | bool | - |
| `NETWORK_HAS_INVITED_GAMER_TO_TRANSITION` | `bool NETWORK_HAS_INVITED_GAMER_TO_TRANSITION(ref object p0)` | bool | - |
| `NETWORK_HAS_MADE_INVITE_DECISION` | `bool NETWORK_HAS_MADE_INVITE_DECISION(ref object gamerHandle)` | bool | - |
| `NETWORK_HAS_PENDING_INVITE` | `bool NETWORK_HAS_PENDING_INVITE()` | bool | - |
| `NETWORK_HAS_PLAYER_STARTED_TRANSITION` | `bool NETWORK_HAS_PLAYER_STARTED_TRANSITION(int player)` | bool | - |
| `NETWORK_HAS_RECEIVED_HOST_BROADCAST_DATA` | `bool NETWORK_HAS_RECEIVED_HOST_BROADCAST_DATA()` | bool | - |
| `NETWORK_HAS_ROS_PRIVILEGE` | `bool NETWORK_HAS_ROS_PRIVILEGE(int index)` | bool | index is always 18 in scripts |
| `NETWORK_HAS_ROS_PRIVILEGE_END_DATE` | `bool NETWORK_HAS_ROS_PRIVILEGE_END_DATE(int privilege, ref int banType, ref object timeData)` | bool | - |
| `NETWORK_HAS_ROS_PRIVILEGE_PLAYED_LAST_GEN` | `bool NETWORK_HAS_ROS_PRIVILEGE_PLAYED_LAST_GEN()` | bool | - |
| `NETWORK_HAS_ROS_PRIVILEGE_SPECIAL_EDITION_CONTENT` | `bool NETWORK_HAS_ROS_PRIVILEGE_SPECIAL_EDITION_CONTENT()` | bool | - |
| `NETWORK_HAS_SC_MEMBERSHIP` | `bool NETWORK_HAS_SC_MEMBERSHIP()` | bool | - |
| `NETWORK_HAS_SOCIAL_CLUB_ACCOUNT` | `bool NETWORK_HAS_SOCIAL_CLUB_ACCOUNT()` | bool | - |
| `NETWORK_HAS_SOCIAL_NETWORKING_SHARING_PRIV` | `bool NETWORK_HAS_SOCIAL_NETWORKING_SHARING_PRIV()` | bool | - |
| `NETWORK_HAS_TRANSITION_INVITE_BEEN_ACKED` | `bool NETWORK_HAS_TRANSITION_INVITE_BEEN_ACKED(ref object p0)` | bool | - |
| `NETWORK_HAS_VALID_ROS_CREDENTIALS` | `bool NETWORK_HAS_VALID_ROS_CREDENTIALS()` | bool | Returns whether the signed-in user has valid Rockstar Online Services (ROS) credentials. |
| `NETWORK_HAS_VIEW_GAMER_USER_CONTENT_RESULT` | `bool NETWORK_HAS_VIEW_GAMER_USER_CONTENT_RESULT(ref object gamerHandle)` | bool | - |
| `NETWORK_HAVE_COMMUNICATION_PRIVILEGES` | `bool NETWORK_HAVE_COMMUNICATION_PRIVILEGES(int p0, int player)` | bool | - |
| `NETWORK_HAVE_ONLINE_PRIVILEGES` | `bool NETWORK_HAVE_ONLINE_PRIVILEGES()` | bool | - |
| `NETWORK_HAVE_PLATFORM_SUBSCRIPTION` | `bool NETWORK_HAVE_PLATFORM_SUBSCRIPTION()` | bool | - |
| `NETWORK_HAVE_ROS_BANNED_PRIV` | `bool NETWORK_HAVE_ROS_BANNED_PRIV()` | bool | - |
| `NETWORK_HAVE_ROS_CREATE_TICKET_PRIV` | `bool NETWORK_HAVE_ROS_CREATE_TICKET_PRIV()` | bool | - |
| `NETWORK_HAVE_ROS_LEADERBOARD_WRITE_PRIV` | `bool NETWORK_HAVE_ROS_LEADERBOARD_WRITE_PRIV()` | bool | - |
| `NETWORK_HAVE_ROS_MULTIPLAYER_PRIV` | `bool NETWORK_HAVE_ROS_MULTIPLAYER_PRIV()` | bool | - |
| `NETWORK_HAVE_ROS_SOCIAL_CLUB_PRIV` | `bool NETWORK_HAVE_ROS_SOCIAL_CLUB_PRIV()` | bool | - |
| `NETWORK_HAVE_SCS_PRIVATE_MSG_PRIV` | `bool NETWORK_HAVE_SCS_PRIVATE_MSG_PRIV()` | bool | - |
| `NETWORK_HAVE_USER_CONTENT_PRIVILEGES` | `bool NETWORK_HAVE_USER_CONTENT_PRIVILEGES(int p0)` | bool | - |
| `NETWORK_HIDE_PROJECTILE_IN_CUTSCENE` | `void NETWORK_HIDE_PROJECTILE_IN_CUTSCENE()` | void | - |
| `NETWORK_HOST_TRANSITION` | `bool NETWORK_HOST_TRANSITION(int p0, int p1, int p2, int p3, object p4, bool p5, bool p6, int p7, object p8, int p9)` | bool | p0: Unknown int<br>p1: Unknown int<br>p2: Unknown int<br>p3: Unknown int<br>p4: Unknown always 0 in decompiled s... |
| `NETWORK_IGNORE_REMOTE_WAYPOINTS` | `void NETWORK_IGNORE_REMOTE_WAYPOINTS()` | void | - |
| `NETWORK_INVITE_GAMERS` | `bool NETWORK_INVITE_GAMERS(ref object p0, object p1, ref object p2, object p3)` | bool | - |
| `NETWORK_INVITE_GAMERS_TO_TRANSITION` | `bool NETWORK_INVITE_GAMERS_TO_TRANSITION(ref object p0, object p1)` | bool | - |
| `NETWORK_IS_ACTIVITY_SESSION` | `bool NETWORK_IS_ACTIVITY_SESSION()` | bool | - |
| `NETWORK_IS_ACTIVITY_SPECTATOR` | `bool NETWORK_IS_ACTIVITY_SPECTATOR()` | bool | - |
| `NETWORK_IS_ACTIVITY_SPECTATOR_FROM_HANDLE` | `bool NETWORK_IS_ACTIVITY_SPECTATOR_FROM_HANDLE(ref object gamerHandle)` | bool | - |
| `NETWORK_IS_ADDING_FRIEND` | `bool NETWORK_IS_ADDING_FRIEND()` | bool | - |
| `NETWORK_IS_ANY_PLAYER_NEAR` | `bool NETWORK_IS_ANY_PLAYER_NEAR(object p0, object p1, object p2, object p3, object p4, object p5, object p6)` | bool | - |
| `NETWORK_IS_CABLE_CONNECTED` | `bool NETWORK_IS_CABLE_CONNECTED()` | bool | - |
| `NETWORK_IS_CHATTING_IN_PLATFORM_PARTY` | `bool NETWORK_IS_CHATTING_IN_PLATFORM_PARTY(ref object gamerHandle)` | bool | This would be nice to see if someone is in party chat, but 2 sad notes.<br>1) It only becomes true if s... |
| `NETWORK_IS_CLOCK_TIME_OVERRIDDEN` | `bool NETWORK_IS_CLOCK_TIME_OVERRIDDEN()` | bool | - |
| `NETWORK_IS_CLOUD_AVAILABLE` | `bool NETWORK_IS_CLOUD_AVAILABLE()` | bool | - |
| `NETWORK_IS_CLOUD_BACKGROUND_SCRIPT_REQUEST_PENDING` | `bool NETWORK_IS_CLOUD_BACKGROUND_SCRIPT_REQUEST_PENDING()` | bool | - |
| `NETWORK_IS_CONNECTED_VIA_RELAY` | `bool NETWORK_IS_CONNECTED_VIA_RELAY(int player)` | bool | - |
| `NETWORK_IS_CONNETED_TO_NP_PRESENCE` | `bool NETWORK_IS_CONNETED_TO_NP_PRESENCE()` | bool | This function is hard-coded to always return 1. |
| `NETWORK_IS_DOOR_NETWORKED` | `bool NETWORK_IS_DOOR_NETWORKED(uint doorHash)` | bool | - |
| `NETWORK_IS_ENTITY_CONCEALED` | `bool NETWORK_IS_ENTITY_CONCEALED(int entity)` | bool | Note: This only works for vehicles, which appears to be a bug (since the setter _does_ work for ever... |
| `NETWORK_IS_ENTITY_FADING` | `bool NETWORK_IS_ENTITY_FADING(int entity)` | bool | - |
| `NETWORK_IS_FINDING_GAMERS` | `bool NETWORK_IS_FINDING_GAMERS()` | bool | - |
| `NETWORK_IS_FRIEND` | `bool NETWORK_IS_FRIEND(ref object gamerHandle)` | bool | - |
| `NETWORK_IS_FRIEND_HANDLE_ONLINE` | `bool NETWORK_IS_FRIEND_HANDLE_ONLINE(ref object gamerHandle)` | bool | - |
| `NETWORK_IS_FRIEND_INDEX_ONLINE` | `bool NETWORK_IS_FRIEND_INDEX_ONLINE(int friendIndex)` | bool | - |
| `NETWORK_IS_FRIEND_IN_MULTIPLAYER` | `bool NETWORK_IS_FRIEND_IN_MULTIPLAYER(string friendName)` | bool | - |
| `NETWORK_IS_FRIEND_IN_SAME_TITLE` | `bool NETWORK_IS_FRIEND_IN_SAME_TITLE(string friendName)` | bool | In scripts R* calls 'NETWORK_GET_FRIEND_NAME' in this param. |
| `NETWORK_IS_FRIEND_ONLINE` | `bool NETWORK_IS_FRIEND_ONLINE(string name)` | bool | - |
| `NETWORK_IS_GAMER_BLOCKED_BY_ME` | `bool NETWORK_IS_GAMER_BLOCKED_BY_ME(ref object gamerHandle)` | bool | - |
| `NETWORK_IS_GAMER_IN_MY_SESSION` | `bool NETWORK_IS_GAMER_IN_MY_SESSION(ref object gamerHandle)` | bool | - |
| `NETWORK_IS_GAMER_MUTED_BY_ME` | `bool NETWORK_IS_GAMER_MUTED_BY_ME(ref object gamerHandle)` | bool | - |
| `NETWORK_IS_GAMER_TALKING` | `bool NETWORK_IS_GAMER_TALKING(ref object gamerHandle)` | bool | - |
| `NETWORK_IS_GAME_IN_PROGRESS` | `bool NETWORK_IS_GAME_IN_PROGRESS()` | bool | - |
| `NETWORK_IS_GETTING_GAMER_STATUS` | `bool NETWORK_IS_GETTING_GAMER_STATUS()` | bool | - |
| `NETWORK_IS_HANDLE_VALID` | `bool NETWORK_IS_HANDLE_VALID(ref object gamerHandle, int gamerHandleSize)` | bool | - |
| `NETWORK_IS_HOST` | `bool NETWORK_IS_HOST()` | bool | If you are host, returns true else returns false. |
| `NETWORK_IS_HOST_OF_THIS_SCRIPT` | `bool NETWORK_IS_HOST_OF_THIS_SCRIPT()` | bool | - |
| `NETWORK_IS_INACTIVE_PROFILE` | `bool NETWORK_IS_INACTIVE_PROFILE(ref object p0)` | bool | - |
| `NETWORK_IS_IN_MP_CUTSCENE` | `bool NETWORK_IS_IN_MP_CUTSCENE()` | bool | - |
| `NETWORK_IS_IN_PLATFORM_PARTY` | `bool NETWORK_IS_IN_PLATFORM_PARTY()` | bool | Hardcoded to return false. |
| `NETWORK_IS_IN_PLATFORM_PARTY_CHAT` | `bool NETWORK_IS_IN_PLATFORM_PARTY_CHAT()` | bool | Hardcoded to return false. |
| `NETWORK_IS_IN_SESSION` | `bool NETWORK_IS_IN_SESSION()` | bool | - |
| `NETWORK_IS_IN_SPECTATOR_MODE` | `bool NETWORK_IS_IN_SPECTATOR_MODE()` | bool | - |
| `NETWORK_IS_IN_TRANSITION` | `bool NETWORK_IS_IN_TRANSITION()` | bool | - |
| `NETWORK_IS_IN_TUTORIAL_SESSION` | `bool NETWORK_IS_IN_TUTORIAL_SESSION()` | bool | - |
| `NETWORK_IS_LOCAL_PLAYER_INVINCIBLE` | `bool NETWORK_IS_LOCAL_PLAYER_INVINCIBLE()` | bool | - |
| `NETWORK_IS_LOGGED_IN_TO_PSN` | `bool NETWORK_IS_LOGGED_IN_TO_PSN()` | bool | This function is hard-coded to always return 0. |
| `NETWORK_IS_MULTIPLAYER_DISABLED` | `bool NETWORK_IS_MULTIPLAYER_DISABLED()` | bool | - |
| `NETWORK_IS_NETWORK_ID_REMOTELY_CONTROLLED` | `bool NETWORK_IS_NETWORK_ID_REMOTELY_CONTROLLED(int netId)` | bool | Returns true if the specified network id is controlled by someone else. |
| `NETWORK_IS_NP_AVAILABLE` | `bool NETWORK_IS_NP_AVAILABLE()` | bool | This function is hard-coded to always return 1. |
| `NETWORK_IS_NP_PENDING` | `bool NETWORK_IS_NP_PENDING()` | bool | This function is hard-coded to always return 1. |
| `NETWORK_IS_OFFLINE_INVITE_PENDING` | `bool NETWORK_IS_OFFLINE_INVITE_PENDING()` | bool | - |
| `NETWORK_IS_PARTICIPANT_ACTIVE` | `bool NETWORK_IS_PARTICIPANT_ACTIVE(int p0)` | bool | - |
| `NETWORK_IS_PENDING_FRIEND` | `bool NETWORK_IS_PENDING_FRIEND(object p0)` | bool | This function is hard-coded to always return 0. |
| `NETWORK_IS_PLATFORM_SUBSCRIPTION_CHECK_PENDING` | `bool NETWORK_IS_PLATFORM_SUBSCRIPTION_CHECK_PENDING()` | bool | - |
| `NETWORK_IS_PLAYER_ACTIVE` | `bool NETWORK_IS_PLAYER_ACTIVE(int player)` | bool | - |
| `NETWORK_IS_PLAYER_A_PARTICIPANT` | `bool NETWORK_IS_PLAYER_A_PARTICIPANT(int player)` | bool | - |
| `NETWORK_IS_PLAYER_A_PARTICIPANT_ON_SCRIPT` | `bool NETWORK_IS_PLAYER_A_PARTICIPANT_ON_SCRIPT(int player, string script, int instance_id)` | bool | - |
| `NETWORK_IS_PLAYER_BLOCKED_BY_ME` | `bool NETWORK_IS_PLAYER_BLOCKED_BY_ME(int player)` | bool | - |
| `NETWORK_IS_PLAYER_CONCEALED` | `bool NETWORK_IS_PLAYER_CONCEALED(int player)` | bool | - |
| `NETWORK_IS_PLAYER_CONNECTED` | `bool NETWORK_IS_PLAYER_CONNECTED(int player)` | bool | - |
| `NETWORK_IS_PLAYER_FADING` | `bool NETWORK_IS_PLAYER_FADING(int player)` | bool | - |
| `NETWORK_IS_PLAYER_IN_MP_CUTSCENE` | `bool NETWORK_IS_PLAYER_IN_MP_CUTSCENE(int player)` | bool | - |
| `NETWORK_IS_PLAYER_MUTED_BY_ME` | `bool NETWORK_IS_PLAYER_MUTED_BY_ME(int player)` | bool | - |
| `NETWORK_IS_PLAYER_ON_BLOCKLIST` | `bool NETWORK_IS_PLAYER_ON_BLOCKLIST(ref object gamerHandle)` | bool | - |
| `NETWORK_IS_PLAYER_TALKING` | `bool NETWORK_IS_PLAYER_TALKING(int player)` | bool | returns true if someone is screaming or talking in a microphone |
| `NETWORK_IS_PRIVILEGE_CHECK_IN_PROGRESS` | `bool NETWORK_IS_PRIVILEGE_CHECK_IN_PROGRESS()` | bool | Hardcoded to return false. |
| `NETWORK_IS_PUSH_TO_TALK_ACTIVE` | `bool NETWORK_IS_PUSH_TO_TALK_ACTIVE()` | bool | - |
| `NETWORK_IS_QUEUING_FOR_SESSION_JOIN` | `bool NETWORK_IS_QUEUING_FOR_SESSION_JOIN()` | bool | - |
| `NETWORK_IS_REFRESHING_ROS_CREDENTIALS` | `bool NETWORK_IS_REFRESHING_ROS_CREDENTIALS()` | bool | - |
| `NETWORK_IS_SCRIPT_ACTIVE` | `bool NETWORK_IS_SCRIPT_ACTIVE(string scriptName, int instance_id, bool p2, int position_hash)` | bool | - |
| `NETWORK_IS_SCRIPT_ACTIVE_BY_HASH` | `bool NETWORK_IS_SCRIPT_ACTIVE_BY_HASH(uint scriptHash, int p1, bool p2, int p3)` | bool | - |
| `NETWORK_IS_SESSION_ACTIVE` | `bool NETWORK_IS_SESSION_ACTIVE()` | bool | - |
| `NETWORK_IS_SESSION_BUSY` | `bool NETWORK_IS_SESSION_BUSY()` | bool | - |
| `NETWORK_IS_SESSION_STARTED` | `bool NETWORK_IS_SESSION_STARTED()` | bool | This checks if player is playing on gta online or not.<br>Please add an if and block your mod if this i... |
| `NETWORK_IS_SHOWING_SYSTEM_UI_OR_RECENTLY_REQUESTED_UPSELL` | `bool NETWORK_IS_SHOWING_SYSTEM_UI_OR_RECENTLY_REQUESTED_UPSELL()` | bool | - |
| `NETWORK_IS_SIGNED_IN` | `bool NETWORK_IS_SIGNED_IN()` | bool | Returns whether the player is signed into Social Club. |
| `NETWORK_IS_SIGNED_ONLINE` | `bool NETWORK_IS_SIGNED_ONLINE()` | bool | Returns whether the game is not in offline mode.<br><br>seemed not to work for some ppl |
| `NETWORK_IS_THREAD_A_NETWORK_SCRIPT` | `bool NETWORK_IS_THREAD_A_NETWORK_SCRIPT(int threadId)` | bool | - |
| `NETWORK_IS_TITLE_UPDATE_REQUIRED` | `bool NETWORK_IS_TITLE_UPDATE_REQUIRED()` | bool | This function is hard-coded to always return 0. |
| `NETWORK_IS_TRANSITION_BUSY` | `bool NETWORK_IS_TRANSITION_BUSY()` | bool | - |
| `NETWORK_IS_TRANSITION_CLOSED_CREW` | `bool NETWORK_IS_TRANSITION_CLOSED_CREW()` | bool | - |
| `NETWORK_IS_TRANSITION_CLOSED_FRIENDS` | `bool NETWORK_IS_TRANSITION_CLOSED_FRIENDS()` | bool | - |
| `NETWORK_IS_TRANSITION_HOST` | `bool NETWORK_IS_TRANSITION_HOST()` | bool | - |
| `NETWORK_IS_TRANSITION_HOST_FROM_HANDLE` | `bool NETWORK_IS_TRANSITION_HOST_FROM_HANDLE(ref object gamerHandle)` | bool | - |
| `NETWORK_IS_TRANSITION_LEAVE_POSTPONED` | `bool NETWORK_IS_TRANSITION_LEAVE_POSTPONED()` | bool | - |
| `NETWORK_IS_TRANSITION_MATCHMAKING` | `bool NETWORK_IS_TRANSITION_MATCHMAKING()` | bool | - |
| `NETWORK_IS_TRANSITION_OPEN_TO_MATCHMAKING` | `bool NETWORK_IS_TRANSITION_OPEN_TO_MATCHMAKING()` | bool | - |
| `NETWORK_IS_TRANSITION_PRIVATE` | `bool NETWORK_IS_TRANSITION_PRIVATE()` | bool | - |
| `NETWORK_IS_TRANSITION_SOLO` | `bool NETWORK_IS_TRANSITION_SOLO()` | bool | - |
| `NETWORK_IS_TRANSITION_STARTED` | `bool NETWORK_IS_TRANSITION_STARTED()` | bool | - |
| `NETWORK_IS_TRANSITION_TO_GAME` | `bool NETWORK_IS_TRANSITION_TO_GAME()` | bool | - |
| `NETWORK_IS_TRANSITION_VISIBILITY_LOCKED` | `bool NETWORK_IS_TRANSITION_VISIBILITY_LOCKED()` | bool | - |
| `NETWORK_IS_TUNABLE_CLOUD_REQUEST_PENDING` | `bool NETWORK_IS_TUNABLE_CLOUD_REQUEST_PENDING()` | bool | - |
| `NETWORK_IS_TUTORIAL_SESSION_CHANGE_PENDING` | `bool NETWORK_IS_TUTORIAL_SESSION_CHANGE_PENDING()` | bool | - |
| `NETWORK_IS_USING_ONLINE_PROMOTION` | `bool NETWORK_IS_USING_ONLINE_PROMOTION()` | bool | - |
| `NETWORK_JOIN_GROUP_ACTIVITY` | `bool NETWORK_JOIN_GROUP_ACTIVITY()` | bool | - |
| `NETWORK_JOIN_PREVIOUSLY_FAILED_SESSION` | `bool NETWORK_JOIN_PREVIOUSLY_FAILED_SESSION()` | bool | - |
| `NETWORK_JOIN_PREVIOUSLY_FAILED_TRANSITION` | `bool NETWORK_JOIN_PREVIOUSLY_FAILED_TRANSITION()` | bool | - |
| `NETWORK_JOIN_TRANSITION` | `bool NETWORK_JOIN_TRANSITION(int player)` | bool | int handle[76];<br>          NETWORK_HANDLE_FROM_FRIEND(iSelectedPlayer, &handle[0], 13);<br>          Pla... |
| `NETWORK_KEEP_ENTITY_COLLISION_DISABLED_AFTER_ANIM_SCENE` | `void NETWORK_KEEP_ENTITY_COLLISION_DISABLED_AFTER_ANIM_SCENE(object p0, object p1)` | void | - |
| `NETWORK_LAUNCH_TRANSITION` | `bool NETWORK_LAUNCH_TRANSITION()` | bool | - |
| `NETWORK_LEAVE_PED_BEHIND_BEFORE_CUTSCENE` | `void NETWORK_LEAVE_PED_BEHIND_BEFORE_CUTSCENE(int player, bool p1)` | void | - |
| `NETWORK_LEAVE_PED_BEHIND_BEFORE_WARP` | `void NETWORK_LEAVE_PED_BEHIND_BEFORE_WARP(int player, float x, float y, float z, bool p4, bool p5)` | void | p4 and p5 are always 0 in scripts |
| `NETWORK_LEAVE_TRANSITION` | `bool NETWORK_LEAVE_TRANSITION()` | bool | - |
| `NETWORK_MARK_AS_PREFERRED_ACTIVITY` | `void NETWORK_MARK_AS_PREFERRED_ACTIVITY(bool p0)` | void | - |
| `NETWORK_MARK_AS_WAITING_ASYNC` | `void NETWORK_MARK_AS_WAITING_ASYNC(bool p0)` | void | - |
| `NETWORK_MARK_TRANSITION_GAMER_AS_FULLY_JOINED` | `bool NETWORK_MARK_TRANSITION_GAMER_AS_FULLY_JOINED(ref object p0)` | bool | - |
| `NETWORK_MEMBER_ID_FROM_GAMER_HANDLE` | `string NETWORK_MEMBER_ID_FROM_GAMER_HANDLE(ref object gamerHandle)` | string | - |
| `NETWORK_NEED_TO_START_NEW_GAME_BUT_BLOCKED` | `bool NETWORK_NEED_TO_START_NEW_GAME_BUT_BLOCKED()` | bool | - |
| `NETWORK_ON_RETURN_TO_SINGLE_PLAYER` | `void NETWORK_ON_RETURN_TO_SINGLE_PLAYER()` | void | - |
| `NETWORK_OPEN_TRANSITION_MATCHMAKING` | `void NETWORK_OPEN_TRANSITION_MATCHMAKING()` | void | - |
| `NETWORK_OVERRIDE_CHAT_RESTRICTIONS` | `void NETWORK_OVERRIDE_CHAT_RESTRICTIONS(int player, bool toggle)` | void | Could possibly bypass being muted or automatically muted |
| `NETWORK_OVERRIDE_CLOCK_RATE` | `void NETWORK_OVERRIDE_CLOCK_RATE(int ms)` | void | - |
| `NETWORK_OVERRIDE_CLOCK_TIME` | `void NETWORK_OVERRIDE_CLOCK_TIME(int hours, int minutes, int seconds)` | void | Works in Singleplayer too.<br>Passing wrong data (e.g. hours above 23) will cause the game to crash. |
| `NETWORK_OVERRIDE_COORDS_AND_HEADING` | `void NETWORK_OVERRIDE_COORDS_AND_HEADING(int entity, float x, float y, float z, float heading)` | void | - |
| `NETWORK_OVERRIDE_RECEIVE_RESTRICTIONS` | `void NETWORK_OVERRIDE_RECEIVE_RESTRICTIONS(int player, bool toggle)` | void | R* uses this to hear all player when spectating. <br>It allows you to hear other online players when th... |
| `NETWORK_OVERRIDE_RECEIVE_RESTRICTIONS_ALL` | `void NETWORK_OVERRIDE_RECEIVE_RESTRICTIONS_ALL(bool toggle)` | void | p0 is always false in scripts. |
| `NETWORK_OVERRIDE_SEND_RESTRICTIONS` | `void NETWORK_OVERRIDE_SEND_RESTRICTIONS(int player, bool toggle)` | void | This is used alongside the native,<br>'NETWORK_OVERRIDE_RECEIVE_RESTRICTIONS'. Read its description for... |
| `NETWORK_OVERRIDE_SEND_RESTRICTIONS_ALL` | `void NETWORK_OVERRIDE_SEND_RESTRICTIONS_ALL(bool toggle)` | void | - |
| `NETWORK_OVERRIDE_TEAM_RESTRICTIONS` | `void NETWORK_OVERRIDE_TEAM_RESTRICTIONS(int team, bool toggle)` | void | - |
| `NETWORK_OVERRIDE_TRANSITION_CHAT` | `void NETWORK_OVERRIDE_TRANSITION_CHAT(bool p0)` | void | - |
| `NETWORK_PATCH_POST_CUTSCENE_HS4F_TUN_ENT` | `void NETWORK_PATCH_POST_CUTSCENE_HS4F_TUN_ENT(int ped)` | void | - |
| `NETWORK_PERMISSIONS_HAS_GAMER_RECORD` | `bool NETWORK_PERMISSIONS_HAS_GAMER_RECORD(ref object gamerHandle)` | bool | - |
| `NETWORK_PLAYER_GET_CHEATER_REASON` | `int NETWORK_PLAYER_GET_CHEATER_REASON()` | int | - |
| `NETWORK_PLAYER_GET_NAME` | `string NETWORK_PLAYER_GET_NAME(int player)` | string | Returns the name of a given player. Returns "**Invalid**" if rlGamerInfo of the given player cannot ... |
| `NETWORK_PLAYER_GET_USERID` | `string NETWORK_PLAYER_GET_USERID(int player, ref int userID)` | string | Returns a string of the player's Rockstar Id. <br>Takes a 24 char buffer. Returns the buffer or "**Inva... |
| `NETWORK_PLAYER_HAS_HEADSET` | `bool NETWORK_PLAYER_HAS_HEADSET(int player)` | bool | - |
| `NETWORK_PLAYER_INDEX_IS_CHEATER` | `bool NETWORK_PLAYER_INDEX_IS_CHEATER(int player)` | bool | - |
| `NETWORK_PLAYER_IS_BADSPORT` | `bool NETWORK_PLAYER_IS_BADSPORT()` | bool | - |
| `NETWORK_PLAYER_IS_CHEATER` | `bool NETWORK_PLAYER_IS_CHEATER()` | bool | - |
| `NETWORK_PLAYER_IS_ROCKSTAR_DEV` | `bool NETWORK_PLAYER_IS_ROCKSTAR_DEV(int player)` | bool | Checks if a specific value (BYTE) in CNetGamePlayer is nonzero.<br>Returns always false in Singleplayer... |
| `NETWORK_PREVENT_SCRIPT_HOST_MIGRATION` | `void NETWORK_PREVENT_SCRIPT_HOST_MIGRATION()` | void | - |
| `NETWORK_QUERY_RESPAWN_RESULTS` | `int NETWORK_QUERY_RESPAWN_RESULTS(ref object p0)` | int | - |
| `NETWORK_QUEUE_GAMER_FOR_STATUS` | `bool NETWORK_QUEUE_GAMER_FOR_STATUS(ref object p0)` | bool | - |
| `NETWORK_QUIT_MP_TO_DESKTOP` | `void NETWORK_QUIT_MP_TO_DESKTOP()` | void | - |
| `NETWORK_REGISTER_ENTITY_AS_NETWORKED` | `void NETWORK_REGISTER_ENTITY_AS_NETWORKED(int entity)` | void | - |
| `NETWORK_REGISTER_HIGH_FREQUENCY_HOST_BROADCAST_VARIABLES` | `void NETWORK_REGISTER_HIGH_FREQUENCY_HOST_BROADCAST_VARIABLES(object p0, object p1, object p2)` | void | - |
| `NETWORK_REGISTER_HIGH_FREQUENCY_PLAYER_BROADCAST_VARIABLES` | `void NETWORK_REGISTER_HIGH_FREQUENCY_PLAYER_BROADCAST_VARIABLES(object p0, object p1, object p2)` | void | - |
| `NETWORK_REGISTER_HOST_BROADCAST_VARIABLES` | `void NETWORK_REGISTER_HOST_BROADCAST_VARIABLES(ref int vars, int numVars, string debugName)` | void | - |
| `NETWORK_REGISTER_PLAYER_BROADCAST_VARIABLES` | `void NETWORK_REGISTER_PLAYER_BROADCAST_VARIABLES(ref int vars, int numVars, string debugName)` | void | - |
| `NETWORK_REMAIN_IN_GAME_CHAT` | `void NETWORK_REMAIN_IN_GAME_CHAT(bool p0)` | void | - |
| `NETWORK_REMOVE_ALL_QUEUED_JOIN_REQUESTS` | `void NETWORK_REMOVE_ALL_QUEUED_JOIN_REQUESTS()` | void | - |
| `NETWORK_REMOVE_ALL_TRANSITION_INVITE` | `void NETWORK_REMOVE_ALL_TRANSITION_INVITE()` | void | - |
| `NETWORK_REMOVE_AND_CANCEL_ALL_INVITES` | `void NETWORK_REMOVE_AND_CANCEL_ALL_INVITES()` | void | - |
| `NETWORK_REMOVE_AND_CANCEL_ALL_TRANSITION_INVITES` | `void NETWORK_REMOVE_AND_CANCEL_ALL_TRANSITION_INVITES()` | void | - |
| `NETWORK_REMOVE_ENTITY_AREA` | `bool NETWORK_REMOVE_ENTITY_AREA(int areaHandle)` | bool | - |
| `NETWORK_REMOVE_INVALID_OBJECT_MODEL` | `void NETWORK_REMOVE_INVALID_OBJECT_MODEL(uint modelHash)` | void | - |
| `NETWORK_REMOVE_PRESENCE_INVITE` | `bool NETWORK_REMOVE_PRESENCE_INVITE(int p0)` | bool | - |
| `NETWORK_REMOVE_TRANSITION_INVITE` | `void NETWORK_REMOVE_TRANSITION_INVITE(ref object p0)` | void | - |
| `NETWORK_REPORT_CODE_TAMPER` | `void NETWORK_REPORT_CODE_TAMPER()` | void | - |
| `NETWORK_REQUEST_CLOUD_BACKGROUND_SCRIPTS` | `bool NETWORK_REQUEST_CLOUD_BACKGROUND_SCRIPTS()` | bool | - |
| `NETWORK_REQUEST_CLOUD_TUNABLES` | `void NETWORK_REQUEST_CLOUD_TUNABLES()` | void | - |
| `NETWORK_REQUEST_CONTROL_OF_DOOR` | `bool NETWORK_REQUEST_CONTROL_OF_DOOR(int doorID)` | bool | - |
| `NETWORK_REQUEST_CONTROL_OF_ENTITY` | `bool NETWORK_REQUEST_CONTROL_OF_ENTITY(int entity)` | bool | - |
| `NETWORK_REQUEST_CONTROL_OF_NETWORK_ID` | `bool NETWORK_REQUEST_CONTROL_OF_NETWORK_ID(int netId)` | bool | - |
| `NETWORK_REQUEST_INVITE_CONFIRMED_EVENT` | `bool NETWORK_REQUEST_INVITE_CONFIRMED_EVENT()` | bool | Triggers a CEventNetworkInviteConfirmed event |
| `NETWORK_REQUEST_TO_BE_HOST_OF_THIS_SCRIPT` | `void NETWORK_REQUEST_TO_BE_HOST_OF_THIS_SCRIPT()` | void | - |
| `NETWORK_RESET_BODY_TRACKER` | `void NETWORK_RESET_BODY_TRACKER()` | void | - |
| `NETWORK_RESOLVE_PRIVILEGE_USER_CONTENT` | `bool NETWORK_RESOLVE_PRIVILEGE_USER_CONTENT()` | bool | Hardcoded to return true. |
| `NETWORK_RESURRECT_LOCAL_PLAYER` | `void NETWORK_RESURRECT_LOCAL_PLAYER(float x, float y, float z, float heading, bool p4, bool changetime, bool p6, int p7, int p8)` | void | - |
| `NETWORK_RETAIN_ACTIVITY_GROUP` | `void NETWORK_RETAIN_ACTIVITY_GROUP()` | void | - |
| `NETWORK_SEED_RANDOM_NUMBER_GENERATOR` | `void NETWORK_SEED_RANDOM_NUMBER_GENERATOR(int seed)` | void | - |
| `NETWORK_SEND_IMPORTANT_TRANSITION_INVITE_VIA_PRESENCE` | `bool NETWORK_SEND_IMPORTANT_TRANSITION_INVITE_VIA_PRESENCE(ref object gamerHandle, string p1, int dataCount, int p3)` | bool | Contains the string "NETWORK_SEND_PRESENCE_TRANSITION_INVITE" but so does 0xC116FF9B4D488291; seems ... |
| `NETWORK_SEND_INVITE_VIA_PRESENCE` | `bool NETWORK_SEND_INVITE_VIA_PRESENCE(ref object gamerHandle, string p1, int dataCount, int p3)` | bool | - |
| `NETWORK_SEND_QUEUED_JOIN_REQUEST` | `void NETWORK_SEND_QUEUED_JOIN_REQUEST()` | void | - |
| `NETWORK_SEND_TEXT_MESSAGE` | `bool NETWORK_SEND_TEXT_MESSAGE(string message, ref object gamerHandle)` | bool | Message is limited to 64 characters. |
| `NETWORK_SEND_TRANSITION_GAMER_INSTRUCTION` | `bool NETWORK_SEND_TRANSITION_GAMER_INSTRUCTION(ref object gamerHandle, string p1, int p2, int p3, bool p4)` | bool | - |
| `NETWORK_SEND_TRANSITION_INVITE_VIA_PRESENCE` | `bool NETWORK_SEND_TRANSITION_INVITE_VIA_PRESENCE(ref object gamerHandle, string p1, int dataCount, int p3)` | bool | - |
| `NETWORK_SESSION_ADD_ACTIVE_MATCHMAKING_GROUP` | `void NETWORK_SESSION_ADD_ACTIVE_MATCHMAKING_GROUP(int groupId)` | void | groupId range: [0, 4] |
| `NETWORK_SESSION_BLOCK_JOIN_REQUESTS` | `void NETWORK_SESSION_BLOCK_JOIN_REQUESTS(bool toggle)` | void | - |
| `NETWORK_SESSION_CANCEL_INVITE` | `void NETWORK_SESSION_CANCEL_INVITE()` | void | - |
| `NETWORK_SESSION_CHANGE_SLOTS` | `void NETWORK_SESSION_CHANGE_SLOTS(int slots, bool p1)` | void | num player slots allowed in session, seems to work? 32 max |
| `NETWORK_SESSION_DO_ACTIVITY_QUICKMATCH` | `bool NETWORK_SESSION_DO_ACTIVITY_QUICKMATCH(object p0, object p1, object p2, object p3, object p4)` | bool | - |
| `NETWORK_SESSION_DO_CREW_MATCHMAKING` | `bool NETWORK_SESSION_DO_CREW_MATCHMAKING(int crewId, int p1, int p2, int maxPlayers)` | bool | p4 seems to be unused in 1.60/build 2628 |
| `NETWORK_SESSION_DO_FREEROAM_QUICKMATCH` | `bool NETWORK_SESSION_DO_FREEROAM_QUICKMATCH(object p0, object p1, object p2)` | bool | - |
| `NETWORK_SESSION_DO_FRIEND_MATCHMAKING` | `bool NETWORK_SESSION_DO_FRIEND_MATCHMAKING(int p0, int p1, int p2)` | bool | - |
| `NETWORK_SESSION_FORCE_CANCEL_INVITE` | `void NETWORK_SESSION_FORCE_CANCEL_INVITE()` | void | - |
| `NETWORK_SESSION_GET_HOST_AIM_PREFERENCE` | `int NETWORK_SESSION_GET_HOST_AIM_PREFERENCE()` | int | - |
| `NETWORK_SESSION_GET_INVITER` | `void NETWORK_SESSION_GET_INVITER(ref object gamerHandle)` | void | - |
| `NETWORK_SESSION_GET_KICK_VOTE` | `bool NETWORK_SESSION_GET_KICK_VOTE(int player)` | bool | - |
| `NETWORK_SESSION_GET_MATCHMAKING_GROUP_FREE` | `int NETWORK_SESSION_GET_MATCHMAKING_GROUP_FREE(int p0)` | int | - |
| `NETWORK_SESSION_GET_PRIVATE_SLOTS` | `int NETWORK_SESSION_GET_PRIVATE_SLOTS()` | int | - |
| `NETWORK_SESSION_GET_UNIQUE_CREW_LIMIT` | `int NETWORK_SESSION_GET_UNIQUE_CREW_LIMIT()` | int | - |
| `NETWORK_SESSION_HOST` | `bool NETWORK_SESSION_HOST(int p0, int maxPlayers, bool p2)` | bool | Does nothing in online but in offline it will cause the screen to fade to black. Nothing happens pas... |
| `NETWORK_SESSION_HOST_CLOSED` | `bool NETWORK_SESSION_HOST_CLOSED(int p0, int maxPlayers)` | bool | - |
| `NETWORK_SESSION_HOST_FRIENDS_ONLY` | `bool NETWORK_SESSION_HOST_FRIENDS_ONLY(int p0, int maxPlayers)` | bool | Does nothing in online but in offline it will cause the screen to fade to black. Nothing happens pas... |
| `NETWORK_SESSION_HOST_SINGLE_PLAYER` | `void NETWORK_SESSION_HOST_SINGLE_PLAYER(int p0)` | void | Loads up the map that is loaded when beeing in mission creator<br>Player gets placed in a mix between o... |
| `NETWORK_SESSION_IS_AWAITING_INVITE_RESPONSE` | `bool NETWORK_SESSION_IS_AWAITING_INVITE_RESPONSE()` | bool | Seems to be true while "Getting GTA Online session details" shows up. |
| `NETWORK_SESSION_IS_CLOSED_CREW` | `bool NETWORK_SESSION_IS_CLOSED_CREW()` | bool | - |
| `NETWORK_SESSION_IS_CLOSED_FRIENDS` | `bool NETWORK_SESSION_IS_CLOSED_FRIENDS()` | bool | - |
| `NETWORK_SESSION_IS_DISPLAYING_INVITE_CONFIRMATION` | `bool NETWORK_SESSION_IS_DISPLAYING_INVITE_CONFIRMATION()` | bool | - |
| `NETWORK_SESSION_IS_IN_VOICE_SESSION` | `bool NETWORK_SESSION_IS_IN_VOICE_SESSION()` | bool | - |
| `NETWORK_SESSION_IS_PRIVATE` | `bool NETWORK_SESSION_IS_PRIVATE()` | bool | - |
| `NETWORK_SESSION_IS_SOLO` | `bool NETWORK_SESSION_IS_SOLO()` | bool | - |
| `NETWORK_SESSION_IS_VISIBLE` | `bool NETWORK_SESSION_IS_VISIBLE()` | bool | - |
| `NETWORK_SESSION_IS_VOICE_SESSION_ACTIVE` | `bool NETWORK_SESSION_IS_VOICE_SESSION_ACTIVE()` | bool | - |
| `NETWORK_SESSION_IS_VOICE_SESSION_BUSY` | `bool NETWORK_SESSION_IS_VOICE_SESSION_BUSY()` | bool | - |
| `NETWORK_SESSION_JOIN_INVITE` | `void NETWORK_SESSION_JOIN_INVITE()` | void | - |
| `NETWORK_SESSION_KICK_PLAYER` | `void NETWORK_SESSION_KICK_PLAYER(int player)` | void | Only works as host. |
| `NETWORK_SESSION_LEAVE` | `bool NETWORK_SESSION_LEAVE(object p0)` | bool | - |
| `NETWORK_SESSION_LEAVE_SINGLE_PLAYER` | `void NETWORK_SESSION_LEAVE_SINGLE_PLAYER()` | void | - |
| `NETWORK_SESSION_MARK_VISIBLE` | `void NETWORK_SESSION_MARK_VISIBLE(bool toggle)` | void | - |
| `NETWORK_SESSION_RESERVE_SLOTS_TRANSITION` | `bool NETWORK_SESSION_RESERVE_SLOTS_TRANSITION(object p0, object p1, object p2)` | bool | - |
| `NETWORK_SESSION_SET_CREW_LIMIT_MAX_MEMBERS_TRANSITION` | `void NETWORK_SESSION_SET_CREW_LIMIT_MAX_MEMBERS_TRANSITION(object p0)` | void | - |
| `NETWORK_SESSION_SET_GAMEMODE` | `void NETWORK_SESSION_SET_GAMEMODE(object p0)` | void | - |
| `NETWORK_SESSION_SET_MATCHMAKING_GROUP` | `void NETWORK_SESSION_SET_MATCHMAKING_GROUP(int matchmakingGroup)` | void | - |
| `NETWORK_SESSION_SET_MATCHMAKING_GROUP_MAX` | `void NETWORK_SESSION_SET_MATCHMAKING_GROUP_MAX(int playerType, int playerCount)` | void | playerType is an unsigned int from 0 to 4<br>0 = regular joiner<br>4 = spectator |
| `NETWORK_SESSION_SET_MATCHMAKING_MENTAL_STATE` | `void NETWORK_SESSION_SET_MATCHMAKING_MENTAL_STATE(int p0)` | void | p0 in the decompiled scripts is always the stat mesh_texblend * 0.07 to int |
| `NETWORK_SESSION_SET_MATCHMAKING_PROPERTY_ID` | `void NETWORK_SESSION_SET_MATCHMAKING_PROPERTY_ID(bool p0)` | void | - |
| `NETWORK_SESSION_SET_NUM_BOSSES` | `void NETWORK_SESSION_SET_NUM_BOSSES(int num)` | void | - |
| `NETWORK_SESSION_SET_SCRIPT_VALIDATE_JOIN` | `void NETWORK_SESSION_SET_SCRIPT_VALIDATE_JOIN()` | void | - |
| `NETWORK_SESSION_SET_UNIQUE_CREW_LIMIT` | `void NETWORK_SESSION_SET_UNIQUE_CREW_LIMIT(object p0)` | void | - |
| `NETWORK_SESSION_SET_UNIQUE_CREW_LIMIT_TRANSITION` | `void NETWORK_SESSION_SET_UNIQUE_CREW_LIMIT_TRANSITION(object p0)` | void | - |
| `NETWORK_SESSION_SET_UNIQUE_CREW_ONLY_CREWS_TRANSITION` | `void NETWORK_SESSION_SET_UNIQUE_CREW_ONLY_CREWS_TRANSITION(bool p0)` | void | - |
| `NETWORK_SESSION_VALIDATE_JOIN` | `void NETWORK_SESSION_VALIDATE_JOIN(bool p0)` | void | - |
| `NETWORK_SESSION_VOICE_CONNECT_TO_PLAYER` | `void NETWORK_SESSION_VOICE_CONNECT_TO_PLAYER(ref object gamerHandle)` | void | - |
| `NETWORK_SESSION_VOICE_HOST` | `bool NETWORK_SESSION_VOICE_HOST()` | bool | - |
| `NETWORK_SESSION_VOICE_LEAVE` | `bool NETWORK_SESSION_VOICE_LEAVE()` | bool | - |
| `NETWORK_SESSION_VOICE_RESPOND_TO_REQUEST` | `void NETWORK_SESSION_VOICE_RESPOND_TO_REQUEST(bool p0, int p1)` | void | - |
| `NETWORK_SESSION_VOICE_SET_TIMEOUT` | `void NETWORK_SESSION_VOICE_SET_TIMEOUT(int timeout)` | void | - |
| `NETWORK_SESSION_WAS_INVITED` | `bool NETWORK_SESSION_WAS_INVITED()` | bool | - |
| `NETWORK_SET_ACTIVITY_PLAYER_MAX` | `void NETWORK_SET_ACTIVITY_PLAYER_MAX(object p0)` | void | - |
| `NETWORK_SET_ACTIVITY_SPECTATOR` | `void NETWORK_SET_ACTIVITY_SPECTATOR(bool toggle)` | void | - |
| `NETWORK_SET_ACTIVITY_SPECTATOR_MAX` | `void NETWORK_SET_ACTIVITY_SPECTATOR_MAX(int maxSpectators)` | void | - |
| `NETWORK_SET_ANTAGONISTIC_TO_PLAYER` | `void NETWORK_SET_ANTAGONISTIC_TO_PLAYER(bool toggle, int player)` | void | - |
| `NETWORK_SET_ATTRIBUTE_DAMAGE_TO_PLAYER` | `bool NETWORK_SET_ATTRIBUTE_DAMAGE_TO_PLAYER(int ped, int player)` | bool | - |
| `NETWORK_SET_CAN_RECEIVE_RS_INVITES` | `void NETWORK_SET_CAN_RECEIVE_RS_INVITES(bool p0)` | void | - |
| `NETWORK_SET_CURRENTLY_SELECTED_GAMER_HANDLE_FROM_INVITE_MENU` | `bool NETWORK_SET_CURRENTLY_SELECTED_GAMER_HANDLE_FROM_INVITE_MENU(ref object p0)` | bool | - |
| `NETWORK_SET_CURRENT_CHAT_OPTION` | `void NETWORK_SET_CURRENT_CHAT_OPTION(int newChatOption)` | void | - |
| `NETWORK_SET_CURRENT_DATA_MANAGER_HANDLE` | `bool NETWORK_SET_CURRENT_DATA_MANAGER_HANDLE(ref object p0)` | bool | - |
| `NETWORK_SET_CURRENT_PUBLIC_CONTENT_ID` | `void NETWORK_SET_CURRENT_PUBLIC_CONTENT_ID(string missionId)` | void | - |
| `NETWORK_SET_CURRENT_SPAWN_LOCATION_OPTION` | `void NETWORK_SET_CURRENT_SPAWN_LOCATION_OPTION(uint mpSettingSpawn)` | void | mpSettingSpawn:<br><br>enum eMpSettingSpawn<br>{<br>	MP_SETTING_SPAWN_NULL,<br>	MP_SETTING_SPAWN_PROPERTY,<br>	MP_SETT... |
| `NETWORK_SET_CUSTOM_ARENA_BALL_PARAMS` | `void NETWORK_SET_CUSTOM_ARENA_BALL_PARAMS(int netId)` | void | - |
| `NETWORK_SET_DO_NOT_LAUNCH_FROM_JOIN_AS_MIGRATED_HOST` | `void NETWORK_SET_DO_NOT_LAUNCH_FROM_JOIN_AS_MIGRATED_HOST(bool toggle)` | void | Appears to set whether a transition should be started when the session is migrating. |
| `NETWORK_SET_ENTITY_CAN_BLEND` | `void NETWORK_SET_ENTITY_CAN_BLEND(int entity, bool toggle)` | void | - |
| `NETWORK_SET_ENTITY_ONLY_EXISTS_FOR_PARTICIPANTS` | `void NETWORK_SET_ENTITY_ONLY_EXISTS_FOR_PARTICIPANTS(int entity, bool toggle)` | void | if set to true other network players can't see it<br>if set to false other network player can see it<br>==... |
| `NETWORK_SET_FRIENDLY_FIRE_OPTION` | `void NETWORK_SET_FRIENDLY_FIRE_OPTION(bool toggle)` | void | - |
| `NETWORK_SET_GAMER_INVITED_TO_TRANSITION` | `void NETWORK_SET_GAMER_INVITED_TO_TRANSITION(ref object gamerHandle)` | void | - |
| `NETWORK_SET_IGNORE_SPECTATOR_CHAT_LIMITS_SAME_TEAM` | `void NETWORK_SET_IGNORE_SPECTATOR_CHAT_LIMITS_SAME_TEAM(bool toggle)` | void | - |
| `NETWORK_SET_INVITE_FAILED_MESSAGE_FOR_INVITE_MENU` | `void NETWORK_SET_INVITE_FAILED_MESSAGE_FOR_INVITE_MENU(ref object p0, ref object p1)` | void | - |
| `NETWORK_SET_INVITE_ON_CALL_FOR_INVITE_MENU` | `void NETWORK_SET_INVITE_ON_CALL_FOR_INVITE_MENU(ref object p0)` | void | - |
| `NETWORK_SET_IN_FREE_CAM_MODE` | `void NETWORK_SET_IN_FREE_CAM_MODE(bool toggle)` | void | - |
| `NETWORK_SET_IN_MP_CUTSCENE` | `void NETWORK_SET_IN_MP_CUTSCENE(bool p0, bool p1)` | void | - |
| `NETWORK_SET_IN_PROGRESS_FINISH_TIME` | `void NETWORK_SET_IN_PROGRESS_FINISH_TIME(object p0)` | void | - |
| `NETWORK_SET_IN_SPECTATOR_MODE` | `void NETWORK_SET_IN_SPECTATOR_MODE(bool toggle, int playerPed)` | void | - |
| `NETWORK_SET_IN_SPECTATOR_MODE_EXTENDED` | `void NETWORK_SET_IN_SPECTATOR_MODE_EXTENDED(bool toggle, int playerPed, bool p2)` | void | - |
| `NETWORK_SET_LOCAL_PLAYER_INVINCIBLE_TIME` | `void NETWORK_SET_LOCAL_PLAYER_INVINCIBLE_TIME(int time)` | void | - |
| `NETWORK_SET_LOCAL_PLAYER_SYNC_LOOK_AT` | `void NETWORK_SET_LOCAL_PLAYER_SYNC_LOOK_AT(bool toggle)` | void | - |
| `NETWORK_SET_LOOK_AT_TALKERS` | `void NETWORK_SET_LOOK_AT_TALKERS(bool p0)` | void | - |
| `NETWORK_SET_MINIMUM_RANK_FOR_MISSION` | `void NETWORK_SET_MINIMUM_RANK_FOR_MISSION(bool p0)` | void | - |
| `NETWORK_SET_MISSION_FINISHED` | `void NETWORK_SET_MISSION_FINISHED()` | void | - |
| `NETWORK_SET_NO_LONGER_NEEDED` | `void NETWORK_SET_NO_LONGER_NEEDED(int entity, bool toggle)` | void | - |
| `NETWORK_SET_NO_SPECTATOR_CHAT` | `void NETWORK_SET_NO_SPECTATOR_CHAT(bool toggle)` | void | - |
| `NETWORK_SET_OBJECT_CAN_BLEND_WHEN_FIXED` | `void NETWORK_SET_OBJECT_CAN_BLEND_WHEN_FIXED(int object, bool toggle)` | void | - |
| `NETWORK_SET_OBJECT_SCOPE_DISTANCE` | `void NETWORK_SET_OBJECT_SCOPE_DISTANCE(int object, float range)` | void | - |
| `NETWORK_SET_OVERRIDE_SPECTATOR_MODE` | `void NETWORK_SET_OVERRIDE_SPECTATOR_MODE(bool toggle)` | void | - |
| `NETWORK_SET_OVERRIDE_TUTORIAL_SESSION_CHAT` | `void NETWORK_SET_OVERRIDE_TUTORIAL_SESSION_CHAT(bool toggle)` | void | - |
| `NETWORK_SET_PLAYER_IS_PASSIVE` | `void NETWORK_SET_PLAYER_IS_PASSIVE(bool toggle)` | void | - |
| `NETWORK_SET_PLAYER_MENTAL_STATE` | `void NETWORK_SET_PLAYER_MENTAL_STATE(int p0)` | void | p0 in the decompiled scripts is always the stat mesh_texblend * 0.07 to int |
| `NETWORK_SET_PRESENCE_SESSION_INVITES_BLOCKED` | `void NETWORK_SET_PRESENCE_SESSION_INVITES_BLOCKED(bool toggle)` | void | Does nothing. It's just a nullsub. |
| `NETWORK_SET_PRIVILEGE_CHECK_RESULT_NOT_NEEDED` | `void NETWORK_SET_PRIVILEGE_CHECK_RESULT_NOT_NEEDED()` | void | - |
| `NETWORK_SET_PROXIMITY_AFFECTS_TEAM` | `void NETWORK_SET_PROXIMITY_AFFECTS_TEAM(bool toggle)` | void | - |
| `NETWORK_SET_RICH_PRESENCE` | `void NETWORK_SET_RICH_PRESENCE(int p0, int p1, object p2, object p3)` | void | This native does absolutely nothing, just a nullsub |
| `NETWORK_SET_RICH_PRESENCE_STRING` | `void NETWORK_SET_RICH_PRESENCE_STRING(int p0, string textLabel)` | void | This native does absolutely nothing, just a nullsub |
| `NETWORK_SET_SAME_TEAM_AS_LOCAL_PLAYER` | `bool NETWORK_SET_SAME_TEAM_AS_LOCAL_PLAYER(object p0, object p1)` | bool | - |
| `NETWORK_SET_SCRIPT_AUTOMUTED` | `bool NETWORK_SET_SCRIPT_AUTOMUTED(object p0)` | bool | - |
| `NETWORK_SET_SCRIPT_CONTROLLING_TEAMS` | `void NETWORK_SET_SCRIPT_CONTROLLING_TEAMS(object p0)` | void | - |
| `NETWORK_SET_SCRIPT_READY_FOR_EVENTS` | `void NETWORK_SET_SCRIPT_READY_FOR_EVENTS(bool toggle)` | void | - |
| `NETWORK_SET_SPECTATOR_TO_NON_SPECTATOR_TEXT_CHAT` | `void NETWORK_SET_SPECTATOR_TO_NON_SPECTATOR_TEXT_CHAT(bool toggle)` | void | - |
| `NETWORK_SET_TALKER_PROXIMITY` | `void NETWORK_SET_TALKER_PROXIMITY(float value)` | void | - |
| `NETWORK_SET_TASK_CUTSCENE_INSCOPE_MULTIPLER` | `void NETWORK_SET_TASK_CUTSCENE_INSCOPE_MULTIPLER(float multiplier)` | void | A value between 1.0 and 5.0 |
| `NETWORK_SET_TEAM_ONLY_CHAT` | `void NETWORK_SET_TEAM_ONLY_CHAT(bool toggle)` | void | - |
| `NETWORK_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT` | `void NETWORK_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT(int maxNumMissionParticipants, bool p1, int instanceId)` | void | - |
| `NETWORK_SET_TRANSITION_ACTIVITY_ID` | `void NETWORK_SET_TRANSITION_ACTIVITY_ID(object p0)` | void | - |
| `NETWORK_SET_TRANSITION_CREATOR_HANDLE` | `void NETWORK_SET_TRANSITION_CREATOR_HANDLE(ref object p0)` | void | - |
| `NETWORK_SET_TRANSITION_VISIBILITY_LOCK` | `void NETWORK_SET_TRANSITION_VISIBILITY_LOCK(bool p0, bool p1)` | void | - |
| `NETWORK_SET_VEHICLE_DRIVEN_IN_TEST_DRIVE` | `void NETWORK_SET_VEHICLE_DRIVEN_IN_TEST_DRIVE(bool toggle)` | void | Used by MetricVEHICLE_DIST_DRIVEN |
| `NETWORK_SET_VEHICLE_DRIVEN_LOCATION` | `void NETWORK_SET_VEHICLE_DRIVEN_LOCATION(uint location)` | void | Sets 'loc' variable used in MetricVEHICLE_DIST_DRIVEN |
| `NETWORK_SET_VOICE_ACTIVE` | `void NETWORK_SET_VOICE_ACTIVE(bool toggle)` | void | - |
| `NETWORK_SET_VOICE_CHANNEL` | `void NETWORK_SET_VOICE_CHANNEL(int channel)` | void | - |
| `NETWORK_SHOULD_SHOW_PROMOTION_ALERT_SCREEN` | `bool NETWORK_SHOULD_SHOW_PROMOTION_ALERT_SCREEN()` | bool | - |
| `NETWORK_SHOULD_SHOW_STRICT_NAT_WARNING` | `bool NETWORK_SHOULD_SHOW_STRICT_NAT_WARNING()` | bool | Returns true if the NAT type is Strict (3) and a certain number of connections have failed. |
| `NETWORK_SHOW_ACCOUNT_UPGRADE_UI` | `void NETWORK_SHOW_ACCOUNT_UPGRADE_UI()` | void | - |
| `NETWORK_SHOW_CHAT_RESTRICTION_MSC` | `void NETWORK_SHOW_CHAT_RESTRICTION_MSC(int player)` | void | Does nothing (it's a nullsub). |
| `NETWORK_SHOW_PROFILE_UI` | `void NETWORK_SHOW_PROFILE_UI(ref object gamerHandle)` | void | - |
| `NETWORK_SHOW_PSN_UGC_RESTRICTION` | `void NETWORK_SHOW_PSN_UGC_RESTRICTION()` | void | This native does absolutely nothing, just a nullsub |
| `NETWORK_SKIP_RADIO_RESET_NEXT_CLOSE` | `void NETWORK_SKIP_RADIO_RESET_NEXT_CLOSE()` | void | - |
| `NETWORK_SKIP_RADIO_RESET_NEXT_OPEN` | `void NETWORK_SKIP_RADIO_RESET_NEXT_OPEN()` | void | - |
| `NETWORK_SKIP_RADIO_WARNING` | `bool NETWORK_SKIP_RADIO_WARNING()` | bool | Returns true if dinput8.dll is present in the game directory.<br>You will get following error message i... |
| `NETWORK_START_RESPAWN_SEARCH_FOR_PLAYER` | `bool NETWORK_START_RESPAWN_SEARCH_FOR_PLAYER(int player, float x, float y, float z, float radius, float p5, float p6, float p7, int flags)` | bool | One of the first things it does is get the players ped.<br>Then it calls a function that is used in som... |
| `NETWORK_START_RESPAWN_SEARCH_IN_ANGLED_AREA_FOR_PLAYER` | `bool NETWORK_START_RESPAWN_SEARCH_IN_ANGLED_AREA_FOR_PLAYER(int player, float x1, float y1, float z1, float x2, float y2, float z2, float width, float p8, float p9, float p10, int flags)` | bool | p8, p9, p10 is another coordinate, or zero, often related to `GET_BLIP_COORDS in the decompiled scri... |
| `NETWORK_START_SOLO_TUTORIAL_SESSION` | `void NETWORK_START_SOLO_TUTORIAL_SESSION()` | void | - |
| `NETWORK_START_SYNCHRONISED_SCENE` | `void NETWORK_START_SYNCHRONISED_SCENE(int netScene)` | void | - |
| `NETWORK_START_USER_CONTENT_PERMISSIONS_CHECK` | `int NETWORK_START_USER_CONTENT_PERMISSIONS_CHECK(ref object netHandle)` | int | Always returns -1. Seems to be XB1 specific. |
| `NETWORK_STOP_SYNCHRONISED_SCENE` | `void NETWORK_STOP_SYNCHRONISED_SCENE(int netScene)` | void | - |
| `NETWORK_STORE_INVITE_THROUGH_RESTART` | `void NETWORK_STORE_INVITE_THROUGH_RESTART()` | void | - |
| `NETWORK_SUPPRESS_INVITE` | `void NETWORK_SUPPRESS_INVITE(bool toggle)` | void | - |
| `NETWORK_SYNC_CLOCK_TIME_OVERRIDE` | `void NETWORK_SYNC_CLOCK_TIME_OVERRIDE()` | void | Does nothing in final builds. |
| `NETWORK_TEXT_CHAT_IS_TYPING` | `bool NETWORK_TEXT_CHAT_IS_TYPING()` | bool | Same as _IS_TEXT_CHAT_ACTIVE, except it does not check if the text chat HUD component is initialized... |
| `NETWORK_TRANSITION_ADD_STAGE` | `bool NETWORK_TRANSITION_ADD_STAGE(uint hash, int p1, int p2, int state, int p4)` | bool | - |
| `NETWORK_TRANSITION_BLOCK_JOIN_REQUESTS` | `void NETWORK_TRANSITION_BLOCK_JOIN_REQUESTS(bool p0)` | void | - |
| `NETWORK_TRANSITION_FINISH` | `bool NETWORK_TRANSITION_FINISH(object p0, object p1, object p2)` | bool | - |
| `NETWORK_TRANSITION_SET_ACTIVITY_ISLAND` | `void NETWORK_TRANSITION_SET_ACTIVITY_ISLAND(object p0)` | void | - |
| `NETWORK_TRANSITION_SET_CONTENT_CREATOR` | `void NETWORK_TRANSITION_SET_CONTENT_CREATOR(object p0)` | void | - |
| `NETWORK_TRANSITION_SET_IN_PROGRESS` | `void NETWORK_TRANSITION_SET_IN_PROGRESS(object p0)` | void | - |
| `NETWORK_TRANSITION_START` | `bool NETWORK_TRANSITION_START(int p0, object p1, object p2, object p3)` | bool | - |
| `NETWORK_TRIGGER_DAMAGE_EVENT_FOR_ZERO_DAMAGE` | `void NETWORK_TRIGGER_DAMAGE_EVENT_FOR_ZERO_DAMAGE(int entity, bool toggle)` | void | Allows vehicle wheels to be destructible even when the vehicle entity is invincible. |
| `NETWORK_TRIGGER_DAMAGE_EVENT_FOR_ZERO_WEAPON_HASH` | `void NETWORK_TRIGGER_DAMAGE_EVENT_FOR_ZERO_WEAPON_HASH(int entity, bool toggle)` | void | - |
| `NETWORK_TRY_ACCESS_TUNABLE_BOOL_HASH` | `bool NETWORK_TRY_ACCESS_TUNABLE_BOOL_HASH(uint tunableContext, uint tunableName, bool defaultValue)` | bool | Returns defaultValue if the tunable doesn't exist. |
| `NETWORK_TRY_TO_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT` | `bool NETWORK_TRY_TO_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT(object p0, bool p1, object p2)` | bool | - |
| `NETWORK_UGC_NAV` | `void NETWORK_UGC_NAV(object p0, object p1)` | void | - |
| `NETWORK_UNREGISTER_NETWORKED_ENTITY` | `void NETWORK_UNREGISTER_NETWORKED_ENTITY(int entity)` | void | - |
| `NETWORK_USE_HIGH_PRECISION_BLENDING` | `void NETWORK_USE_HIGH_PRECISION_BLENDING(int netID, bool toggle)` | void | - |
| `NETWORK_USE_LOGARITHMIC_BLENDING_THIS_FRAME` | `void NETWORK_USE_LOGARITHMIC_BLENDING_THIS_FRAME(int entity)` | void | - |
| `NETWORK_WAITING_POP_CLEAR_TUTORIAL_SESSION` | `bool NETWORK_WAITING_POP_CLEAR_TUTORIAL_SESSION()` | bool | - |
| `NETWORK_WAS_GAME_SUSPENDED` | `bool NETWORK_WAS_GAME_SUSPENDED()` | bool | - |
| `NET_GAMESERVER_BASKET_ADD_ITEM` | `bool NET_GAMESERVER_BASKET_ADD_ITEM(ref object itemData, int quantity)` | bool | - |
| `NET_GAMESERVER_BASKET_APPLY_SERVER_DATA` | `bool NET_GAMESERVER_BASKET_APPLY_SERVER_DATA(object p0, ref object p1)` | bool | - |
| `NET_GAMESERVER_BASKET_END` | `bool NET_GAMESERVER_BASKET_END()` | bool | - |
| `NET_GAMESERVER_BASKET_IS_ACTIVE` | `bool NET_GAMESERVER_BASKET_IS_ACTIVE()` | bool | - |
| `NET_GAMESERVER_BASKET_IS_FULL` | `bool NET_GAMESERVER_BASKET_IS_FULL()` | bool | - |
| `NET_GAMESERVER_BASKET_START` | `bool NET_GAMESERVER_BASKET_START(ref int transactionId, uint categoryHash, uint actionHash, int flags)` | bool | - |
| `NET_GAMESERVER_BEGIN_SERVICE` | `bool NET_GAMESERVER_BEGIN_SERVICE(ref int transactionId, uint categoryHash, uint itemHash, uint actionTypeHash, int value, int flags)` | bool | - |
| `NET_GAMESERVER_CATALOG_IS_VALID` | `bool NET_GAMESERVER_CATALOG_IS_VALID()` | bool | - |
| `NET_GAMESERVER_CATALOG_ITEM_IS_VALID` | `bool NET_GAMESERVER_CATALOG_ITEM_IS_VALID(string name)` | bool | - |
| `NET_GAMESERVER_CATALOG_ITEM_KEY_IS_VALID` | `bool NET_GAMESERVER_CATALOG_ITEM_KEY_IS_VALID(uint hash)` | bool | - |
| `NET_GAMESERVER_CHECKOUT_PENDING` | `bool NET_GAMESERVER_CHECKOUT_PENDING(int transactionId)` | bool | - |
| `NET_GAMESERVER_CHECKOUT_START` | `bool NET_GAMESERVER_CHECKOUT_START(int transactionId)` | bool | - |
| `NET_GAMESERVER_CLEAR_SESSION` | `bool NET_GAMESERVER_CLEAR_SESSION(int p0)` | bool | - |
| `NET_GAMESERVER_DELETE_CHARACTER` | `bool NET_GAMESERVER_DELETE_CHARACTER(int slot, bool transfer, uint reason)` | bool | - |
| `NET_GAMESERVER_DELETE_CHARACTER_GET_STATUS` | `int NET_GAMESERVER_DELETE_CHARACTER_GET_STATUS()` | int | - |
| `NET_GAMESERVER_DELETE_SET_TELEMETRY_NONCE_SEED` | `bool NET_GAMESERVER_DELETE_SET_TELEMETRY_NONCE_SEED()` | bool | - |
| `NET_GAMESERVER_END_SERVICE` | `bool NET_GAMESERVER_END_SERVICE(int transactionId)` | bool | - |
| `NET_GAMESERVER_GET_CATALOG_CLOUD_CRC` | `uint NET_GAMESERVER_GET_CATALOG_CLOUD_CRC()` | uint | - |
| `NET_GAMESERVER_GET_PRICE` | `int NET_GAMESERVER_GET_PRICE(uint itemHash, uint categoryHash, bool p2)` | int | bool is always true in game scripts |
| `NET_GAMESERVER_GET_SESSION_STATE_AND_STATUS` | `bool NET_GAMESERVER_GET_SESSION_STATE_AND_STATUS(ref int p0, ref bool p1)` | bool | - |
| `NET_GAMESERVER_INIT_SESSION` | `bool NET_GAMESERVER_INIT_SESSION()` | bool | - |
| `NET_GAMESERVER_IS_CATALOG_CURRENT` | `bool NET_GAMESERVER_IS_CATALOG_CURRENT()` | bool | - |
| `NET_GAMESERVER_IS_SESSION_REFRESH_PENDING` | `bool NET_GAMESERVER_IS_SESSION_REFRESH_PENDING()` | bool | - |
| `NET_GAMESERVER_IS_SESSION_VALID` | `bool NET_GAMESERVER_IS_SESSION_VALID(int charSlot)` | bool | - |
| `NET_GAMESERVER_REFRESH_SERVER_CATALOG` | `bool NET_GAMESERVER_REFRESH_SERVER_CATALOG()` | bool | - |
| `NET_GAMESERVER_RETRIEVE_CATALOG_REFRESH_STATUS` | `bool NET_GAMESERVER_RETRIEVE_CATALOG_REFRESH_STATUS(ref int state)` | bool | - |
| `NET_GAMESERVER_RETRIEVE_INIT_SESSION_STATUS` | `bool NET_GAMESERVER_RETRIEVE_INIT_SESSION_STATUS(ref int p0)` | bool | - |
| `NET_GAMESERVER_RETRIEVE_SESSION_ERROR_CODE` | `bool NET_GAMESERVER_RETRIEVE_SESSION_ERROR_CODE(ref int p0)` | bool | - |
| `NET_GAMESERVER_RETRIEVE_START_SESSION_STATUS` | `bool NET_GAMESERVER_RETRIEVE_START_SESSION_STATUS(ref int p0)` | bool | - |
| `NET_GAMESERVER_SESSION_APPLY_RECEIVED_DATA` | `bool NET_GAMESERVER_SESSION_APPLY_RECEIVED_DATA(int charSlot)` | bool | - |
| `NET_GAMESERVER_SET_TELEMETRY_NONCE_SEED` | `bool NET_GAMESERVER_SET_TELEMETRY_NONCE_SEED(int p0)` | bool | - |
| `NET_GAMESERVER_START_SESSION` | `bool NET_GAMESERVER_START_SESSION(int charSlot)` | bool | - |
| `NET_GAMESERVER_START_SESSION_PENDING` | `bool NET_GAMESERVER_START_SESSION_PENDING()` | bool | - |
| `NET_GAMESERVER_START_SESSION_RESTART` | `bool NET_GAMESERVER_START_SESSION_RESTART(bool inventory, bool playerbalance)` | bool | Note: only one of the arguments can be set to true at a time |
| `NET_GAMESERVER_TRANSACTION_IN_PROGRESS` | `bool NET_GAMESERVER_TRANSACTION_IN_PROGRESS()` | bool | - |
| `NET_GAMESERVER_TRANSFER_BANK_TO_WALLET` | `bool NET_GAMESERVER_TRANSFER_BANK_TO_WALLET(int charSlot, int amount)` | bool | - |
| `NET_GAMESERVER_TRANSFER_BANK_TO_WALLET_GET_STATUS` | `int NET_GAMESERVER_TRANSFER_BANK_TO_WALLET_GET_STATUS()` | int | Same as 0x350AA5EBC03D3BD2 |
| `NET_GAMESERVER_TRANSFER_CASH_SET_TELEMETRY_NONCE_SEED` | `bool NET_GAMESERVER_TRANSFER_CASH_SET_TELEMETRY_NONCE_SEED()` | bool | Used to be NETWORK_SHOP_CASH_TRANSFER_SET_TELEMETRY_NONCE_SEED |
| `NET_GAMESERVER_TRANSFER_WALLET_TO_BANK` | `bool NET_GAMESERVER_TRANSFER_WALLET_TO_BANK(int charSlot, int amount)` | bool | - |
| `NET_GAMESERVER_TRANSFER_WALLET_TO_BANK_GET_STATUS` | `int NET_GAMESERVER_TRANSFER_WALLET_TO_BANK_GET_STATUS()` | int | Same as 0x23789E777D14CE44 |
| `NET_GAMESERVER_USE_SERVER_TRANSACTIONS` | `bool NET_GAMESERVER_USE_SERVER_TRANSACTIONS()` | bool | - |
| `NET_TO_ENT` | `int NET_TO_ENT(int netHandle)` | int | gets the entity id of a network id |
| `NET_TO_OBJ` | `int NET_TO_OBJ(int netHandle)` | int | gets the object id of a network id |
| `NET_TO_PED` | `int NET_TO_PED(int netHandle)` | int | gets the ped id of a network id |
| `NET_TO_VEH` | `int NET_TO_VEH(int netHandle)` | int | - |
| `OBJ_TO_NET` | `int OBJ_TO_NET(int object)` | int | Lets objects spawn online simply do it like this:<br><br>int createdObject = OBJ_TO_NET(CREATE_OBJECT_NO_O... |
| `OPEN_COMMERCE_STORE` | `void OPEN_COMMERCE_STORE(string p0, string p1, int p2)` | void | - |
| `PARTICIPANT_ID` | `int PARTICIPANT_ID()` | int | Return the local Participant ID |
| `PARTICIPANT_ID_TO_INT` | `int PARTICIPANT_ID_TO_INT()` | int | Return the local Participant ID.<br><br>This native is exactly the same as 'PARTICIPANT_ID' native. |
| `PED_TO_NET` | `int PED_TO_NET(int ped)` | int | gets the network id of a ped |
| `REFRESH_PLAYER_LIST_STATS` | `bool REFRESH_PLAYER_LIST_STATS(int p0)` | bool | - |
| `RELEASE_ALL_COMMERCE_ITEM_IMAGES` | `void RELEASE_ALL_COMMERCE_ITEM_IMAGES()` | void | - |
| `REMOTE_CHEATER_PLAYER_DETECTED` | `bool REMOTE_CHEATER_PLAYER_DETECTED(int player, int a, int b)` | bool | - |
| `REMOVE_ALL_STICKY_BOMBS_FROM_ENTITY` | `void REMOVE_ALL_STICKY_BOMBS_FROM_ENTITY(int entity, int ped)` | void | entity must be a valid entity; ped can be NULL |
| `REQUEST_COMMERCE_ITEM_IMAGE` | `bool REQUEST_COMMERCE_ITEM_IMAGE(int index)` | bool | - |
| `RESERVE_LOCAL_NETWORK_MISSION_OBJECTS` | `void RESERVE_LOCAL_NETWORK_MISSION_OBJECTS(int amount)` | void | - |
| `RESERVE_LOCAL_NETWORK_MISSION_PEDS` | `void RESERVE_LOCAL_NETWORK_MISSION_PEDS(int amount)` | void | - |
| `RESERVE_LOCAL_NETWORK_MISSION_VEHICLES` | `void RESERVE_LOCAL_NETWORK_MISSION_VEHICLES(int amount)` | void | - |
| `RESERVE_NETWORK_MISSION_OBJECTS` | `void RESERVE_NETWORK_MISSION_OBJECTS(int amount)` | void | - |
| `RESERVE_NETWORK_MISSION_PEDS` | `void RESERVE_NETWORK_MISSION_PEDS(int amount)` | void | - |
| `RESERVE_NETWORK_MISSION_VEHICLES` | `void RESERVE_NETWORK_MISSION_VEHICLES(int amount)` | void | - |
| `RESET_GHOST_ALPHA` | `void RESET_GHOST_ALPHA()` | void | Resets the entity ghost alpha to the default value (128) |
| `RESET_STORE_NETWORK_GAME_TRACKING` | `void RESET_STORE_NETWORK_GAME_TRACKING()` | void | - |
| `SET_ENTITY_GHOSTED_FOR_GHOST_PLAYERS` | `void SET_ENTITY_GHOSTED_FOR_GHOST_PLAYERS(int entity, bool toggle)` | void | - |
| `SET_ENTITY_LOCALLY_INVISIBLE` | `void SET_ENTITY_LOCALLY_INVISIBLE(int entity)` | void | Makes the provided entity visible for yourself for the current frame. |
| `SET_ENTITY_LOCALLY_VISIBLE` | `void SET_ENTITY_LOCALLY_VISIBLE(int entity)` | void | - |
| `SET_ENTITY_VISIBLE_IN_CUTSCENE` | `void SET_ENTITY_VISIBLE_IN_CUTSCENE(object p0, bool p1, bool p2)` | void | - |
| `SET_GHOST_ALPHA` | `void SET_GHOST_ALPHA(int alpha)` | void | Must be a value between 1 and 254 |
| `SET_INVERT_GHOSTING` | `void SET_INVERT_GHOSTING(bool p0)` | void | - |
| `SET_LAST_VIEWED_SHOP_ITEM` | `void SET_LAST_VIEWED_SHOP_ITEM(uint p0, int p1, uint p2)` | void | - |
| `SET_LOCAL_PLAYER_AS_GHOST` | `void SET_LOCAL_PLAYER_AS_GHOST(bool toggle, bool p1)` | void | - |
| `SET_LOCAL_PLAYER_INVISIBLE_LOCALLY` | `void SET_LOCAL_PLAYER_INVISIBLE_LOCALLY(bool bIncludePlayersVehicle)` | void | - |
| `SET_LOCAL_PLAYER_VISIBLE_IN_CUTSCENE` | `void SET_LOCAL_PLAYER_VISIBLE_IN_CUTSCENE(bool p0, bool p1)` | void | - |
| `SET_LOCAL_PLAYER_VISIBLE_LOCALLY` | `void SET_LOCAL_PLAYER_VISIBLE_LOCALLY(bool bIncludePlayersVehicle)` | void | - |
| `SET_NETWORK_CUTSCENE_ENTITIES` | `void SET_NETWORK_CUTSCENE_ENTITIES(bool toggle)` | void | - |
| `SET_NETWORK_ENABLE_HIGH_SPEED_EDGE_FALL_DETECTION` | `void SET_NETWORK_ENABLE_HIGH_SPEED_EDGE_FALL_DETECTION(int vehicle, bool toggle)` | void | Enables a periodic ShapeTest within the NetBlender and invokes rage::netBlenderLinInterp::GoStraight... |
| `SET_NETWORK_ID_ALWAYS_EXISTS_FOR_PLAYER` | `void SET_NETWORK_ID_ALWAYS_EXISTS_FOR_PLAYER(int netId, int player, bool toggle)` | void | - |
| `SET_NETWORK_ID_CAN_BE_REASSIGNED` | `void SET_NETWORK_ID_CAN_BE_REASSIGNED(int netId, bool toggle)` | void | "No Reassign" in CPhysicalScriptGameStateDataNode |
| `SET_NETWORK_ID_CAN_MIGRATE` | `void SET_NETWORK_ID_CAN_MIGRATE(int netId, bool toggle)` | void | Whether or not another player is allowed to take control of the entity |
| `SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES` | `void SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES(int netId, bool toggle)` | void | - |
| `SET_NETWORK_ID_PASS_CONTROL_IN_TUTORIAL` | `void SET_NETWORK_ID_PASS_CONTROL_IN_TUTORIAL(int netId, bool state)` | void | - |
| `SET_NETWORK_ID_VISIBLE_IN_CUTSCENE` | `void SET_NETWORK_ID_VISIBLE_IN_CUTSCENE(int netId, bool p1, bool p2)` | void | - |
| `SET_NETWORK_ID_VISIBLE_IN_CUTSCENE_HACK` | `void SET_NETWORK_ID_VISIBLE_IN_CUTSCENE_HACK(int netId, bool p1, bool p2)` | void | - |
| `SET_NETWORK_ID_VISIBLE_IN_CUTSCENE_REMAIN_HACK` | `void SET_NETWORK_ID_VISIBLE_IN_CUTSCENE_REMAIN_HACK(object p0, object p1, object p2)` | void | - |
| `SET_NETWORK_VEHICLE_AS_GHOST` | `void SET_NETWORK_VEHICLE_AS_GHOST(int vehicle, bool toggle)` | void | - |
| `SET_NETWORK_VEHICLE_MAX_POSITION_DELTA_MULTIPLIER` | `void SET_NETWORK_VEHICLE_MAX_POSITION_DELTA_MULTIPLIER(int vehicle, float multiplier)` | void | rage::netBlenderLinInterp::GetPositionMaxForUpdateLevel |
| `SET_NETWORK_VEHICLE_RESPOT_TIMER` | `void SET_NETWORK_VEHICLE_RESPOT_TIMER(int netId, int time, object p2, object p3)` | void | - |
| `SET_NON_PARTICIPANTS_OF_THIS_SCRIPT_AS_GHOSTS` | `void SET_NON_PARTICIPANTS_OF_THIS_SCRIPT_AS_GHOSTS(bool p0)` | void | - |
| `SET_PLAYER_INVISIBLE_LOCALLY` | `void SET_PLAYER_INVISIBLE_LOCALLY(int player, bool bIncludePlayersVehicle)` | void | - |
| `SET_PLAYER_VISIBLE_LOCALLY` | `void SET_PLAYER_VISIBLE_LOCALLY(int player, bool bIncludePlayersVehicle)` | void | - |
| `SET_REMOTE_PLAYER_AS_GHOST` | `void SET_REMOTE_PLAYER_AS_GHOST(int player, bool p1)` | void | Enables ghosting between specific players |
| `SET_REMOTE_PLAYER_VISIBLE_IN_CUTSCENE` | `void SET_REMOTE_PLAYER_VISIBLE_IN_CUTSCENE(int player, bool locallyVisible)` | void | - |
| `SET_STORE_ENABLED` | `void SET_STORE_ENABLED(bool toggle)` | void | Access to the store for shark cards etc... |
| `SHUTDOWN_AND_LAUNCH_SINGLE_PLAYER_GAME` | `void SHUTDOWN_AND_LAUNCH_SINGLE_PLAYER_GAME()` | void | Starts a new singleplayer game (at the prologue). |
| `SHUTDOWN_AND_LOAD_MOST_RECENT_SAVE` | `bool SHUTDOWN_AND_LOAD_MOST_RECENT_SAVE()` | bool | In singleplayer this will re-load your game.<br><br>In FiveM / GTA:Online this disconnects you from the se... |
| `SHUTDOWN_SESSION_CLEARS_AUTO_MULTIPLAYER` | `void SHUTDOWN_SESSION_CLEARS_AUTO_MULTIPLAYER(bool toggle)` | void | - |
| `TEXTURE_DOWNLOAD_GET_NAME` | `string TEXTURE_DOWNLOAD_GET_NAME(int p0)` | string | - |
| `TEXTURE_DOWNLOAD_HAS_FAILED` | `bool TEXTURE_DOWNLOAD_HAS_FAILED(int p0)` | bool | - |
| `TEXTURE_DOWNLOAD_RELEASE` | `void TEXTURE_DOWNLOAD_RELEASE(int p0)` | void | - |
| `TEXTURE_DOWNLOAD_REQUEST` | `int TEXTURE_DOWNLOAD_REQUEST(ref object gamerHandle, string filePath, string name, bool p3)` | int | - |
| `TITLE_TEXTURE_DOWNLOAD_REQUEST` | `int TITLE_TEXTURE_DOWNLOAD_REQUEST(string filePath, string name, bool p2)` | int | - |
| `TRIGGER_COMMERCE_DATA_FETCH` | `void TRIGGER_COMMERCE_DATA_FETCH(object p0)` | void | Does nothing (it's a nullsub). |
| `UGC_CANCEL_QUERY` | `void UGC_CANCEL_QUERY()` | void | - |
| `UGC_CLEAR_CREATE_RESULT` | `void UGC_CLEAR_CREATE_RESULT()` | void | - |
| `UGC_CLEAR_MODIFY_RESULT` | `void UGC_CLEAR_MODIFY_RESULT()` | void | - |
| `UGC_CLEAR_OFFLINE_QUERY` | `void UGC_CLEAR_OFFLINE_QUERY()` | void | - |
| `UGC_CLEAR_QUERY_RESULTS` | `void UGC_CLEAR_QUERY_RESULTS()` | void | - |
| `UGC_COPY_CONTENT` | `bool UGC_COPY_CONTENT(ref object p0, ref object p1)` | bool | - |
| `UGC_DID_CREATE_SUCCEED` | `bool UGC_DID_CREATE_SUCCEED()` | bool | - |
| `UGC_DID_DESCRIPTION_REQUEST_SUCCEED` | `bool UGC_DID_DESCRIPTION_REQUEST_SUCCEED(object p0)` | bool | - |
| `UGC_DID_GET_SUCCEED` | `bool UGC_DID_GET_SUCCEED()` | bool | - |
| `UGC_DID_MODIFY_SUCCEED` | `bool UGC_DID_MODIFY_SUCCEED()` | bool | - |
| `UGC_DID_QUERY_CREATORS_SUCCEED` | `bool UGC_DID_QUERY_CREATORS_SUCCEED()` | bool | - |
| `UGC_GET_BOOKMARKED_CONTENT` | `bool UGC_GET_BOOKMARKED_CONTENT(object p0, object p1, string p2, ref object p3)` | bool | - |
| `UGC_GET_CACHED_DESCRIPTION` | `string UGC_GET_CACHED_DESCRIPTION(object p0, object p1)` | string | - |
| `UGC_GET_CONTENT_CATEGORY` | `int UGC_GET_CONTENT_CATEGORY(int p0)` | int | - |
| `UGC_GET_CONTENT_CREATED_BY_LOCAL_PLAYER` | `bool UGC_GET_CONTENT_CREATED_BY_LOCAL_PLAYER(object p0)` | bool | - |
| `UGC_GET_CONTENT_CREATOR_GAMER_HANDLE` | `bool UGC_GET_CONTENT_CREATOR_GAMER_HANDLE(int p0, ref object p1)` | bool | - |
| `UGC_GET_CONTENT_DESCRIPTION` | `string UGC_GET_CONTENT_DESCRIPTION(int index)` | string | - |
| `UGC_GET_CONTENT_DESCRIPTION_HASH` | `int UGC_GET_CONTENT_DESCRIPTION_HASH(object p0)` | int | - |
| `UGC_GET_CONTENT_FILE_VERSION` | `int UGC_GET_CONTENT_FILE_VERSION(object p0, object p1)` | int | - |
| `UGC_GET_CONTENT_HASH` | `uint UGC_GET_CONTENT_HASH()` | uint | - |
| `UGC_GET_CONTENT_HAS_HI_RES_PHOTO` | `bool UGC_GET_CONTENT_HAS_HI_RES_PHOTO(int p0)` | bool | - |
| `UGC_GET_CONTENT_HAS_LO_RES_PHOTO` | `bool UGC_GET_CONTENT_HAS_LO_RES_PHOTO(int p0)` | bool | - |
| `UGC_GET_CONTENT_HAS_PLAYER_BOOKMARKED` | `bool UGC_GET_CONTENT_HAS_PLAYER_BOOKMARKED(object p0)` | bool | - |
| `UGC_GET_CONTENT_HAS_PLAYER_RECORD` | `bool UGC_GET_CONTENT_HAS_PLAYER_RECORD(object p0)` | bool | - |
| `UGC_GET_CONTENT_ID` | `string UGC_GET_CONTENT_ID(int p0)` | string | Return the mission id of a job. |
| `UGC_GET_CONTENT_IS_PUBLISHED` | `bool UGC_GET_CONTENT_IS_PUBLISHED(object p0)` | bool | - |
| `UGC_GET_CONTENT_IS_USING_SC_NICKNAME` | `bool UGC_GET_CONTENT_IS_USING_SC_NICKNAME(object p0)` | bool | - |
| `UGC_GET_CONTENT_IS_VERIFIED` | `bool UGC_GET_CONTENT_IS_VERIFIED(object p0)` | bool | - |
| `UGC_GET_CONTENT_LANGUAGE` | `int UGC_GET_CONTENT_LANGUAGE(object p0)` | int | - |
| `UGC_GET_CONTENT_NAME` | `string UGC_GET_CONTENT_NAME(object p0)` | string | - |
| `UGC_GET_CONTENT_NUM` | `int UGC_GET_CONTENT_NUM()` | int | - |
| `UGC_GET_CONTENT_PATH` | `string UGC_GET_CONTENT_PATH(int p0, int p1)` | string | - |
| `UGC_GET_CONTENT_RATING` | `float UGC_GET_CONTENT_RATING(object p0, object p1)` | float | - |
| `UGC_GET_CONTENT_RATING_COUNT` | `int UGC_GET_CONTENT_RATING_COUNT(object p0, object p1)` | int | - |
| `UGC_GET_CONTENT_RATING_NEGATIVE_COUNT` | `int UGC_GET_CONTENT_RATING_NEGATIVE_COUNT(object p0, object p1)` | int | - |
| `UGC_GET_CONTENT_RATING_POSITIVE_COUNT` | `int UGC_GET_CONTENT_RATING_POSITIVE_COUNT(object p0, object p1)` | int | - |
| `UGC_GET_CONTENT_TOTAL` | `int UGC_GET_CONTENT_TOTAL()` | int | - |
| `UGC_GET_CONTENT_UPDATED_DATE` | `void UGC_GET_CONTENT_UPDATED_DATE(object p0, ref object p1)` | void | - |
| `UGC_GET_CONTENT_USER_ID` | `string UGC_GET_CONTENT_USER_ID(int p0)` | string | - |
| `UGC_GET_CONTENT_USER_NAME` | `string UGC_GET_CONTENT_USER_NAME(object p0)` | string | - |
| `UGC_GET_CREATE_CONTENT_ID` | `string UGC_GET_CREATE_CONTENT_ID()` | string | - |
| `UGC_GET_CREATE_RESULT` | `int UGC_GET_CREATE_RESULT()` | int | - |
| `UGC_GET_CREATORS_BY_USER_ID` | `bool UGC_GET_CREATORS_BY_USER_ID(ref object p0, ref object p1)` | bool | - |
| `UGC_GET_CREATOR_NUM` | `int UGC_GET_CREATOR_NUM()` | int | - |
| `UGC_GET_CREW_CONTENT` | `bool UGC_GET_CREW_CONTENT(object p0, object p1, object p2, string p3, ref object p4)` | bool | - |
| `UGC_GET_FRIEND_CONTENT` | `bool UGC_GET_FRIEND_CONTENT(object p0, object p1, string p2, ref object p3)` | bool | - |
| `UGC_GET_GET_BY_CATEGORY` | `bool UGC_GET_GET_BY_CATEGORY(object p0, object p1, object p2, string p3, ref object p4)` | bool | - |
| `UGC_GET_GET_BY_CONTENT_ID` | `bool UGC_GET_GET_BY_CONTENT_ID(string contentId, string contentTypeName)` | bool | - |
| `UGC_GET_GET_BY_CONTENT_IDS` | `bool UGC_GET_GET_BY_CONTENT_IDS(ref object data, int dataCount, string contentTypeName)` | bool | - |
| `UGC_GET_MODIFY_RESULT` | `int UGC_GET_MODIFY_RESULT()` | int | - |
| `UGC_GET_MOST_RECENTLY_CREATED_CONTENT` | `bool UGC_GET_MOST_RECENTLY_CREATED_CONTENT(object p0, object p1, ref object p2, ref object p3)` | bool | - |
| `UGC_GET_MOST_RECENTLY_PLAYED_CONTENT` | `bool UGC_GET_MOST_RECENTLY_PLAYED_CONTENT(object p0, object p1, ref object p2, ref object p3)` | bool | - |
| `UGC_GET_MY_CONTENT` | `bool UGC_GET_MY_CONTENT(object p0, object p1, string p2, ref object p3)` | bool | - |
| `UGC_GET_QUERY_RESULT` | `int UGC_GET_QUERY_RESULT()` | int | - |
| `UGC_GET_ROOT_CONTENT_ID` | `string UGC_GET_ROOT_CONTENT_ID(int p0)` | string | Return the root content id of a job. |
| `UGC_GET_TOP_RATED_CONTENT` | `bool UGC_GET_TOP_RATED_CONTENT(object p0, object p1, ref object p2, ref object p3)` | bool | - |
| `UGC_HAS_CREATE_FINISHED` | `bool UGC_HAS_CREATE_FINISHED()` | bool | - |
| `UGC_HAS_DESCRIPTION_REQUEST_FINISHED` | `bool UGC_HAS_DESCRIPTION_REQUEST_FINISHED(object p0)` | bool | - |
| `UGC_HAS_GET_FINISHED` | `bool UGC_HAS_GET_FINISHED()` | bool | - |
| `UGC_HAS_MODIFY_FINISHED` | `bool UGC_HAS_MODIFY_FINISHED()` | bool | - |
| `UGC_HAS_PERMISSION_TO_WRITE` | `bool UGC_HAS_PERMISSION_TO_WRITE()` | bool | - |
| `UGC_HAS_QUERY_CREATORS_FINISHED` | `bool UGC_HAS_QUERY_CREATORS_FINISHED()` | bool | - |
| `UGC_IS_CREATING` | `bool UGC_IS_CREATING()` | bool | - |
| `UGC_IS_DESCRIPTION_REQUEST_IN_PROGRESS` | `bool UGC_IS_DESCRIPTION_REQUEST_IN_PROGRESS(object p0)` | bool | - |
| `UGC_IS_GETTING` | `bool UGC_IS_GETTING()` | bool | - |
| `UGC_IS_LANGUAGE_SUPPORTED` | `bool UGC_IS_LANGUAGE_SUPPORTED(object p0)` | bool | - |
| `UGC_IS_MODIFYING` | `bool UGC_IS_MODIFYING()` | bool | - |
| `UGC_LOAD_OFFLINE_QUERY` | `bool UGC_LOAD_OFFLINE_QUERY(object p0)` | bool | - |
| `UGC_PUBLISH` | `bool UGC_PUBLISH(string contentId, string baseContentId, string contentTypeName)` | bool | - |
| `UGC_QUERY_BY_CATEGORY` | `bool UGC_QUERY_BY_CATEGORY(object p0, object p1, object p2, string p3, object p4, bool p5)` | bool | - |
| `UGC_QUERY_BY_CONTENT_ID` | `bool UGC_QUERY_BY_CONTENT_ID(string contentId, bool latestVersion, string contentTypeName)` | bool | - |
| `UGC_QUERY_BY_CONTENT_IDS` | `bool UGC_QUERY_BY_CONTENT_IDS(ref object data, int count, bool latestVersion, string contentTypeName)` | bool | - |
| `UGC_QUERY_MOST_RECENTLY_CREATED_CONTENT` | `bool UGC_QUERY_MOST_RECENTLY_CREATED_CONTENT(int offset, int count, string contentTypeName, int p3)` | bool | - |
| `UGC_QUERY_MY_CONTENT` | `bool UGC_QUERY_MY_CONTENT(object p0, object p1, ref object p2, object p3, object p4, object p5)` | bool | - |
| `UGC_RELEASE_ALL_CACHED_DESCRIPTIONS` | `void UGC_RELEASE_ALL_CACHED_DESCRIPTIONS()` | void | - |
| `UGC_RELEASE_CACHED_DESCRIPTION` | `bool UGC_RELEASE_CACHED_DESCRIPTION(object p0)` | bool | - |
| `UGC_REQUEST_CACHED_DESCRIPTION` | `int UGC_REQUEST_CACHED_DESCRIPTION(int p0)` | int | - |
| `UGC_REQUEST_CONTENT_DATA_FROM_INDEX` | `int UGC_REQUEST_CONTENT_DATA_FROM_INDEX(int p0, int p1)` | int | - |
| `UGC_REQUEST_CONTENT_DATA_FROM_PARAMS` | `int UGC_REQUEST_CONTENT_DATA_FROM_PARAMS(string contentTypeName, string contentId, int p2, int p3, int p4)` | int | - |
| `UGC_SET_BOOKMARKED` | `bool UGC_SET_BOOKMARKED(string contentId, bool bookmarked, string contentTypeName)` | bool | - |
| `UGC_SET_DELETED` | `bool UGC_SET_DELETED(ref object p0, bool p1, string p2)` | bool | - |
| `UGC_SET_QUERY_DATA_FROM_OFFLINE` | `void UGC_SET_QUERY_DATA_FROM_OFFLINE(bool p0)` | void | - |
| `UGC_SET_USING_OFFLINE_CONTENT` | `void UGC_SET_USING_OFFLINE_CONTENT(bool p0)` | void | - |
| `UGC_TEXTURE_DOWNLOAD_REQUEST` | `int UGC_TEXTURE_DOWNLOAD_REQUEST(string p0, int p1, int p2, int p3, string p4, bool p5)` | int | - |
| `UGC_WAS_QUERY_FORCE_CANCELLED` | `bool UGC_WAS_QUERY_FORCE_CANCELLED()` | bool | - |
| `USE_PLAYER_COLOUR_INSTEAD_OF_TEAM_COLOUR` | `void USE_PLAYER_COLOUR_INSTEAD_OF_TEAM_COLOUR(bool toggle)` | void | - |
| `VEH_TO_NET` | `int VEH_TO_NET(int vehicle)` | int | calls from vehicle to net.<br> |
| `_NETWORK_CAN_TEXT_FROM_GAMER_BE_VIEWED` | `bool _NETWORK_CAN_TEXT_FROM_GAMER_BE_VIEWED(ref object gamerHandle)` | bool | NETWORK_CAN_* |
| `_NETWORK_CLEAR_CLOCK_SYNC_TIME_OVERRIDE` | `void _NETWORK_CLEAR_CLOCK_SYNC_TIME_OVERRIDE(bool startGlobalTransition, int transitionTime)` | void | - |
| `_NETWORK_CLEAR_TUNABLES_REGISTRATION_CONTEXTS` | `void _NETWORK_CLEAR_TUNABLES_REGISTRATION_CONTEXTS()` | void | Clears tunable contexts that were set up using _NETWORK_SET_TUNABLES_REGISTRATION_CONTEXTS |
| `_NETWORK_CONFIRM_GAME_RESTART` | `void _NETWORK_CONFIRM_GAME_RESTART()` | void | If the restart reason is 4 (BE_RESTART_EF_DISABLED_WITH_BE), will cause the game to exit with exit c... |
| `_NETWORK_DOES_COMMUNICATION_GROUP_HAVE_PERMISSION` | `bool _NETWORK_DOES_COMMUNICATION_GROUP_HAVE_PERMISSION(int communicationType)` | bool | communicationType: 0 = VOICE; 1 = TEXT_CHAT; 2 = TEXT_MESSAGE; 3 = EMAIL; 4 = USER_CONTENT; 5 = USER... |
| `_NETWORK_DOES_COMMUNICATION_GROUP_HAVE_SETTINGS_ENABLED` | `bool _NETWORK_DOES_COMMUNICATION_GROUP_HAVE_SETTINGS_ENABLED(int communicationType)` | bool | - |
| `_NETWORK_GET_ACCESS_CODE_LABEL_BODY` | `string _NETWORK_GET_ACCESS_CODE_LABEL_BODY(int accessCode)` | string | - |
| `_NETWORK_GET_ACCESS_CODE_LABEL_HEADING` | `string _NETWORK_GET_ACCESS_CODE_LABEL_HEADING(int accessCode)` | string | - |
| `_NETWORK_GET_BATTLEYE_ERROR_MESSAGE_LABEL` | `string _NETWORK_GET_BATTLEYE_ERROR_MESSAGE_LABEL(int errorCode)` | string | 0x20211000 = HUD_BE_ERROR_FAILED_UNKNOWN<br>0x20212000 = HUD_BE_ERROR_FAILED_CLIENT_INIT<br>0x20213000 = H... |
| `_NETWORK_GET_BROADCAST_DATA_HOST_UPDATE_SIZE` | `int _NETWORK_GET_BROADCAST_DATA_HOST_UPDATE_SIZE(uint scriptNameHash, int instance, uint positionHash, int handlerNum)` | int | - |
| `_NETWORK_GET_BROADCAST_DATA_PLAYER_UPDATE_SIZE` | `int _NETWORK_GET_BROADCAST_DATA_PLAYER_UPDATE_SIZE(uint scriptNameHash, int instance, uint positionHash, int handlerNum)` | int | - |
| `_NETWORK_GET_COMMUNICATION_GROUP_DEFAULT_FLAGS` | `int _NETWORK_GET_COMMUNICATION_GROUP_DEFAULT_FLAGS(int communicationType)` | int | - |
| `_NETWORK_GET_COMMUNICATION_GROUP_FLAGS` | `int _NETWORK_GET_COMMUNICATION_GROUP_FLAGS(int communicationType)` | int | Returns communicationGroupFlag<br>communicationType: see 0xDBDF80673BBA3D65<br><br>enum eCommunicationGroupFl... |
| `_NETWORK_GET_COMMUNICATION_GROUP_VALUE` | `int _NETWORK_GET_COMMUNICATION_GROUP_VALUE(int communicationType)` | int | - |
| `_NETWORK_GET_DUMP_OF_ASSET_VERIFIER` | `void _NETWORK_GET_DUMP_OF_ASSET_VERIFIER(ref object p0)` | void | - |
| `_NETWORK_GET_GAME_RESTART_REASON` | `int _NETWORK_GET_GAME_RESTART_REASON()` | int | enum eNetworkGameRestartReason<br>{<br>	BE_RESTART_SERVICE_NOT_RUNNING = 1, 	// BattlEye service not runni... |
| `_NETWORK_GET_GAME_RESTART_REASON_MESSAGE_LABEL` | `string _NETWORK_GET_GAME_RESTART_REASON_MESSAGE_LABEL()` | string | Returns the restart reason as a string, see _NETWORK_GET_GAME_RESTART_REASON. Returns a null pointer... |
| `_NETWORK_GET_HOST_BROADCAST_DATA_SIZE_UNSYNCED` | `int _NETWORK_GET_HOST_BROADCAST_DATA_SIZE_UNSYNCED(uint scriptNameHash, int instance, uint positionHash, int handlerNum)` | int | - |
| `_NETWORK_GET_PLAYER_BROADCAST_DATA_SIZE_UNSYNCED` | `int _NETWORK_GET_PLAYER_BROADCAST_DATA_SIZE_UNSYNCED(uint scriptNameHash, int instance, uint positionHash, int handlerNum)` | int | - |
| `_NETWORK_GET_RANDOM_FLOAT_RANGED` | `float _NETWORK_GET_RANDOM_FLOAT_RANGED(float rangeStart, float rangeEnd)` | float | - |
| `_NETWORK_GET_TUNABLES_REGISTRATION_BOOL` | `bool _NETWORK_GET_TUNABLES_REGISTRATION_BOOL(uint tunableName, bool defaultValue)` | bool | Checks if the given tunable exists and returns its value. Otherwise returns defaultValue.<br>Possible t... |
| `_NETWORK_GET_TUNABLES_REGISTRATION_FLOAT` | `float _NETWORK_GET_TUNABLES_REGISTRATION_FLOAT(uint tunableName, float defaultValue)` | float | Checks if the given tunable exists and returns its value. Otherwise returns defaultValue.<br>Possible t... |
| `_NETWORK_GET_TUNABLES_REGISTRATION_INT` | `int _NETWORK_GET_TUNABLES_REGISTRATION_INT(uint tunableName, int defaultValue)` | int | Checks if the given tunable exists and returns its value. Otherwise returns defaultValue.<br>Possible t... |
| `_NETWORK_HAS_PLAYER_PASSED_CHECK_TYPE` | `bool _NETWORK_HAS_PLAYER_PASSED_CHECK_TYPE(int checkType, ref object gamerHandle)` | bool | _NETWORK_HAS_P*<br>checkType 3 is similar as using 0x9F633448E4C73207 |
| `_NETWORK_HAS_ROS_PRIVILEGE_MP_TEXT_COMMUNICATION` | `bool _NETWORK_HAS_ROS_PRIVILEGE_MP_TEXT_COMMUNICATION()` | bool | Checks for privilege 29 |
| `_NETWORK_HAS_ROS_PRIVILEGE_MP_VOICE_COMMUNICATION` | `bool _NETWORK_HAS_ROS_PRIVILEGE_MP_VOICE_COMMUNICATION()` | bool | Checks for privilege 30 |
| `_NETWORK_HAS_ROS_PRIVILEGE_REPORTING` | `bool _NETWORK_HAS_ROS_PRIVILEGE_REPORTING()` | bool | Checks for privilege 31 |
| `_NETWORK_HAVE_PLATFORM_COMMUNICATION_PRIVILEGES` | `bool _NETWORK_HAVE_PLATFORM_COMMUNICATION_PRIVILEGES()` | bool | Appears to be PlayStation-specific. Always returns true on other platforms if signed in with the pri... |
| `_NETWORK_HIDE_ENTITY_IN_TUTORIAL_SESSION` | `void _NETWORK_HIDE_ENTITY_IN_TUTORIAL_SESSION(int netHandle, bool hide)` | void | - |
| `_NETWORK_INVITE_CLEAR_JOIN_FAIL_REASON` | `void _NETWORK_INVITE_CLEAR_JOIN_FAIL_REASON()` | void | Clears the failed invite join alert reason |
| `_NETWORK_INVITE_GET_JOIN_FAIL_REASON` | `string _NETWORK_INVITE_GET_JOIN_FAIL_REASON()` | string | Retrieves the failed invite join alert reason |
| `_NETWORK_IS_AMERICAS_VERSION` | `bool _NETWORK_IS_AMERICAS_VERSION()` | bool | Hardcoded to return 0. |
| `_NETWORK_IS_SPECIAL_TUTORIAL_SESSION` | `bool _NETWORK_IS_SPECIAL_TUTORIAL_SESSION()` | bool | - |
| `_NETWORK_LOAD_GAMER_DISPLAY_NAME` | `string _NETWORK_LOAD_GAMER_DISPLAY_NAME(ref object gamerHandle)` | string | Returns the name from given friend gamer handle. |
| `_NETWORK_MULTIPLAYER_CROSSPLAY_NOT_ALLOWED` | `bool _NETWORK_MULTIPLAYER_CROSSPLAY_NOT_ALLOWED()` | bool | For the XboxPC version this returns true if XPRIVILEGE_MULTIPLAYER_SESSIONS is granted but XPRIVILEG... |
| `_NETWORK_SESSION_LEAVE_INCLUDING_REASON` | `bool _NETWORK_SESSION_LEAVE_INCLUDING_REASON(int leaveFlags, int leaveReason)` | bool | - |
| `_NETWORK_SET_COMMUNICATION_GROUP_FLAGS` | `void _NETWORK_SET_COMMUNICATION_GROUP_FLAGS(int communicationType, int communicationGroupFlag)` | void | communicationType: see 0xDBDF80673BBA3D65<br>communicationGroupFlag: see 0x40DF02F371F40883 |
| `_NETWORK_SET_IGNORE_VEHICLE_RAMMED_BY_NON_VEHICLE` | `void _NETWORK_SET_IGNORE_VEHICLE_RAMMED_BY_NON_VEHICLE(bool toggle)` | void | - |
| `_NETWORK_SET_TUNABLES_REGISTRATION_CONTEXTS` | `void _NETWORK_SET_TUNABLES_REGISTRATION_CONTEXTS(ref object tunableContextData)` | void | Sets up tunable contexts for _NETWORK_GET_TUNABLES_REGISTRATION_{BOOL\|INT\|FLOAT} |
| `_NETWORK_SET_TUTORIAL_SPECIAL_SESSION` | `void _NETWORK_SET_TUTORIAL_SPECIAL_SESSION(bool toggle)` | void | - |
| `_NETWORK_TRIGGER_DAMAGE_EVENT_FOR_ZERO_PED_DAMAGE` | `void _NETWORK_TRIGGER_DAMAGE_EVENT_FOR_ZERO_PED_DAMAGE(int entity, bool trigger)` | void | - |
| `_SET_FREEMODE_REPORT_DATA` | `void _SET_FREEMODE_REPORT_DATA(ref object gamerHandle, ref object reportData)` | void | reportData includes mc, ceo, yacht and licenceplate names |

---

## 详细说明

### ACTIVATE_DAMAGE_TRACKER_ON_NETWORK_ID

- **命名空间:** `NETWORK`
- **Hash:** `0xD45B1FFCCD52FF19`
- **JHash:** `0x95D07BA5`
- **Build:** `323`

**C# 签名:**
```csharp
void ACTIVATE_DAMAGE_TRACKER_ON_NETWORK_ID(int netID, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netID` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### ACTIVATE_DAMAGE_TRACKER_ON_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0xBEC0816FF5ACBCDA`
- **Build:** `757`

**C# 签名:**
```csharp
void ACTIVATE_DAMAGE_TRACKER_ON_PLAYER(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### ARE_CUTSCENE_ENTITIES_NETWORKED

- **命名空间:** `NETWORK`
- **Hash:** `0x66D6A5E9C511214A`
- **Build:** `2699`

**C# 签名:**
```csharp
bool ARE_CUTSCENE_ENTITIES_NETWORKED()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Getter for SET_NETWORK_CUTSCENE_ENTITIES.
```

---

### BAD_SPORT_PLAYER_LEFT_DETECTED

- **命名空间:** `NETWORK`
- **Hash:** `0xEC5E3AF5289DCA81`
- **JHash:** `0x4C2C6B6A`
- **Build:** `323`

**C# 签名:**
```csharp
bool BAD_SPORT_PLAYER_LEFT_DETECTED(ref object gamerHandle, int event, int amountReceived)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |
| `event` | `int` | `int` | - |
| `amountReceived` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_REGISTER_MISSION_DOORS

- **命名空间:** `NETWORK`
- **Hash:** `0xE16AA70CE9BEEDC3`
- **Build:** `877`

**C# 签名:**
```csharp
bool CAN_REGISTER_MISSION_DOORS(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_REGISTER_MISSION_ENTITIES

- **命名空间:** `NETWORK`
- **Hash:** `0x69778E7564BADE6D`
- **JHash:** `0x83794008`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_REGISTER_MISSION_ENTITIES(int ped_amt, int vehicle_amt, int object_amt, int pickup_amt)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped_amt` | `int` | `int` | - |
| `vehicle_amt` | `int` | `int` | - |
| `object_amt` | `int` | `int` | - |
| `pickup_amt` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_REGISTER_MISSION_OBJECTS

- **命名空间:** `NETWORK`
- **Hash:** `0x800DD4721A8B008B`
- **JHash:** `0x7F85DFDE`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_REGISTER_MISSION_OBJECTS(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_REGISTER_MISSION_PEDS

- **命名空间:** `NETWORK`
- **Hash:** `0xBCBF4FEF9FA5D781`
- **JHash:** `0xCCAA5CE9`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_REGISTER_MISSION_PEDS(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_REGISTER_MISSION_PICKUPS

- **命名空间:** `NETWORK`
- **Hash:** `0x0A49D1CB6E34AF72`
- **Build:** `757`

**C# 签名:**
```csharp
bool CAN_REGISTER_MISSION_PICKUPS(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_REGISTER_MISSION_VEHICLES

- **命名空间:** `NETWORK`
- **Hash:** `0x7277F1F2E085EE74`
- **JHash:** `0x818B6830`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_REGISTER_MISSION_VEHICLES(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CLEAR_SERVICE_EVENT_ARGUMENTS

- **命名空间:** `NETWORK`
- **Hash:** `0x966DD84FB6A46017`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_SERVICE_EVENT_ARGUMENTS()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
This native does absolutely nothing, just a nullsub
```

---

### CLOUD_CHECK_AVAILABILITY

- **命名空间:** `NETWORK`
- **Hash:** `0x4F18196C8D38768D`
- **JHash:** `0xC38E9DB0`
- **Build:** `323`

**C# 签名:**
```csharp
void CLOUD_CHECK_AVAILABILITY()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Downloads prod.cloud.rockstargames.com/titles/gta5/[platform]/check.json
```

---

### CLOUD_DELETE_MEMBER_FILE

- **命名空间:** `NETWORK`
- **Hash:** `0xC64DED7EF0D2FE37`
- **JHash:** `0x2B7B57B3`
- **Build:** `323`

**C# 签名:**
```csharp
int CLOUD_DELETE_MEMBER_FILE(string p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `const char*` | `string` | - |

**返回值:** `int` (Native: `int`)

---

### CLOUD_DID_REQUEST_SUCCEED

- **命名空间:** `NETWORK`
- **Hash:** `0x3A3D5568AF297CD5`
- **JHash:** `0x9B9AFFF1`
- **Build:** `323`

**C# 签名:**
```csharp
bool CLOUD_DID_REQUEST_SUCCEED(int requestId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `requestId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CLOUD_GET_AVAILABILITY_CHECK_RESULT

- **命名空间:** `NETWORK`
- **Hash:** `0x0B0CC10720653F3B`
- **JHash:** `0x9262744C`
- **Build:** `323`

**C# 签名:**
```csharp
bool CLOUD_GET_AVAILABILITY_CHECK_RESULT()
```

**返回值:** `bool` (Native: `BOOL`)

---

### CLOUD_HAS_REQUEST_COMPLETED

- **命名空间:** `NETWORK`
- **Hash:** `0x4C61B39930D045DA`
- **JHash:** `0xBAF52DD8`
- **Build:** `323`

**C# 签名:**
```csharp
bool CLOUD_HAS_REQUEST_COMPLETED(int requestId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `requestId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CLOUD_IS_CHECKING_AVAILABILITY

- **命名空间:** `NETWORK`
- **Hash:** `0xC7ABAC5DE675EE3B`
- **JHash:** `0x32A4EB22`
- **Build:** `323`

**C# 签名:**
```csharp
bool CLOUD_IS_CHECKING_AVAILABILITY()
```

**返回值:** `bool` (Native: `BOOL`)

---

### CONVERT_POSIX_TIME

- **命名空间:** `NETWORK`
- **Hash:** `0xAC97AF97FA68E5D5`
- **JHash:** `0xBB7CCE49`
- **Build:** `323`

**C# 签名:**
```csharp
void CONVERT_POSIX_TIME(int posixTime, ref object timeStructure)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `posixTime` | `int` | `int` | - |
| `timeStructure` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Takes the specified time and writes it to the structure specified in the second argument.

struct date_time
{
    int year;
    int PADDING1;
    int month;
    int PADDING2;
    int day;
    int PADDING3;
    int hour;
    int PADDING4;
    int minute;
    int PADDING5;
    int second;
    int PADDING6;
};
```

---

### DELAY_MP_STORE_OPEN

- **命名空间:** `NETWORK`
- **Hash:** `0x265635150FB0D82E`
- **JHash:** `0xA7FA70AE`
- **Build:** `323`

**C# 签名:**
```csharp
void DELAY_MP_STORE_OPEN()
```

**返回值:** `void` (Native: `void`)

---

### FACEBOOK_CAN_POST_TO_FACEBOOK

- **命名空间:** `NETWORK`
- **Hash:** `0x43865688AE10F0D7`
- **JHash:** `0x429AEAB3`
- **Build:** `323`

**C# 签名:**
```csharp
bool FACEBOOK_CAN_POST_TO_FACEBOOK()
```

**返回值:** `bool` (Native: `BOOL`)

---

### FACEBOOK_DID_POST_SUCCEED

- **命名空间:** `NETWORK`
- **Hash:** `0xA75E2B6733DA5142`
- **JHash:** `0x11E8B5CD`
- **Build:** `323`

**C# 签名:**
```csharp
bool FACEBOOK_DID_POST_SUCCEED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### FACEBOOK_HAS_POST_COMPLETED

- **命名空间:** `NETWORK`
- **Hash:** `0x62B9FEC9A11F10EF`
- **JHash:** `0x37A28C26`
- **Build:** `323`

**C# 签名:**
```csharp
bool FACEBOOK_HAS_POST_COMPLETED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### FACEBOOK_POST_COMPLETED_HEIST

- **命名空间:** `NETWORK`
- **Hash:** `0x098AB65B9ED9A9EC`
- **JHash:** `0x30B51753`
- **Build:** `323`

**C# 签名:**
```csharp
bool FACEBOOK_POST_COMPLETED_HEIST(string heistName, int cashEarned, int xpEarned)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `heistName` | `const char*` | `string` | - |
| `cashEarned` | `int` | `int` | - |
| `xpEarned` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### FACEBOOK_POST_COMPLETED_MILESTONE

- **命名空间:** `NETWORK`
- **Hash:** `0x0AE1F1653B554AB9`
- **JHash:** `0x2D947814`
- **Build:** `323`

**C# 签名:**
```csharp
bool FACEBOOK_POST_COMPLETED_MILESTONE(int milestoneId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `milestoneId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### FACEBOOK_POST_CREATE_CHARACTER

- **命名空间:** `NETWORK`
- **Hash:** `0xDC48473142545431`
- **JHash:** `0x02DAD93F`
- **Build:** `323`

**C# 签名:**
```csharp
bool FACEBOOK_POST_CREATE_CHARACTER()
```

**返回值:** `bool` (Native: `BOOL`)

---

### FADE_OUT_LOCAL_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0x416DBD4CD6ED8DD2`
- **JHash:** `0x8FA7CEBD`
- **Build:** `323`

**C# 签名:**
```csharp
void FADE_OUT_LOCAL_PLAYER(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Hardcoded to not work in SP.
```

---

### FILLOUT_PM_PLAYER_LIST

- **命名空间:** `NETWORK`
- **Hash:** `0xCBBD7C4991B64809`
- **JHash:** `0xCE40F423`
- **Build:** `323`

**C# 签名:**
```csharp
bool FILLOUT_PM_PLAYER_LIST(ref object gamerHandle, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### FILLOUT_PM_PLAYER_LIST_WITH_NAMES

- **命名空间:** `NETWORK`
- **Hash:** `0x716B6DB9D1886106`
- **JHash:** `0xB8DF604E`
- **Build:** `323`

**C# 签名:**
```csharp
bool FILLOUT_PM_PLAYER_LIST_WITH_NAMES(ref object p0, ref object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any*` | `ref object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_CLOUD_TIME_AS_INT

- **命名空间:** `NETWORK`
- **Hash:** `0x9A73240B49945C76`
- **JHash:** `0xF2FDF2E0`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_CLOUD_TIME_AS_INT()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns POSIX timestamp, an int representing the cloud time.
```

---

### GET_CLOUD_TIME_AS_STRING

- **命名空间:** `NETWORK`
- **Hash:** `0xF12E6CD06C73D69E`
- **Build:** `1103`

**C# 签名:**
```csharp
string GET_CLOUD_TIME_AS_STRING()
```

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Same as GET_CLOUD_TIME_AS_INT but returns the value as a hex string (%I64X).
```

---

### GET_COMMERCE_ITEM_CAT

- **命名空间:** `NETWORK`
- **Hash:** `0x6F44CBF56D79FAC0`
- **JHash:** `0x16E53875`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_COMMERCE_ITEM_CAT(int index, int index2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |
| `index2` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
index2 is unused
```

---

### GET_COMMERCE_ITEM_ID

- **命名空间:** `NETWORK`
- **Hash:** `0x662635855957C411`
- **JHash:** `0x4ACF110C`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_COMMERCE_ITEM_ID(int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

---

### GET_COMMERCE_ITEM_NAME

- **命名空间:** `NETWORK`
- **Hash:** `0xB4271092CA7EDF48`
- **JHash:** `0x1AA3A0D5`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_COMMERCE_ITEM_NAME(int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

---

### GET_COMMERCE_ITEM_NUM_CATS

- **命名空间:** `NETWORK`
- **Hash:** `0x2A7776C709904AB0`
- **JHash:** `0x1CF89DA5`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_COMMERCE_ITEM_NUM_CATS(int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_COMMERCE_ITEM_TEXTURENAME

- **命名空间:** `NETWORK`
- **Hash:** `0x722F5D28B61C5EA8`
- **JHash:** `0x44A58B0A`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_COMMERCE_ITEM_TEXTURENAME(int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

---

### GET_COMMERCE_PRODUCT_PRICE

- **命名空间:** `NETWORK`
- **Hash:** `0xCA94551B50B4932C`
- **JHash:** `0x37877757`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_COMMERCE_PRODUCT_PRICE(int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

---

### GET_CONTENT_TO_LOAD_TYPE

- **命名空间:** `NETWORK`
- **Hash:** `0x8B0C2964BA471961`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_CONTENT_TO_LOAD_TYPE()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
This function is hard-coded to always return 0.
```

---

### GET_IS_LAUNCH_FROM_LIVE_AREA

- **命名空间:** `NETWORK`
- **Hash:** `0x88B588B41FF7868E`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_IS_LAUNCH_FROM_LIVE_AREA()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
This function is hard-coded to always return 0.
```

---

### GET_IS_LIVE_AREA_LAUNCH_WITH_CONTENT

- **命名空间:** `NETWORK`
- **Hash:** `0x67FC09BC554A75E5`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_IS_LIVE_AREA_LAUNCH_WITH_CONTENT()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
This function is hard-coded to always return 0.
```

---

### GET_MAX_NUM_NETWORK_OBJECTS

- **命名空间:** `NETWORK`
- **Hash:** `0xC7BE335216B5EC7C`
- **JHash:** `0x8687E285`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_MAX_NUM_NETWORK_OBJECTS()
```

**返回值:** `int` (Native: `int`)

---

### GET_MAX_NUM_NETWORK_PEDS

- **命名空间:** `NETWORK`
- **Hash:** `0x0C1F7D49C39D2289`
- **JHash:** `0x744AC008`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_MAX_NUM_NETWORK_PEDS()
```

**返回值:** `int` (Native: `int`)

---

### GET_MAX_NUM_NETWORK_PICKUPS

- **命名空间:** `NETWORK`
- **Hash:** `0xA72835064DD63E4C`
- **JHash:** `0x6A036061`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_MAX_NUM_NETWORK_PICKUPS()
```

**返回值:** `int` (Native: `int`)

---

### GET_MAX_NUM_NETWORK_VEHICLES

- **命名空间:** `NETWORK`
- **Hash:** `0x0AFCE529F69B21FF`
- **JHash:** `0xC3A12135`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_MAX_NUM_NETWORK_VEHICLES()
```

**返回值:** `int` (Native: `int`)

---

### GET_NETWORK_TIME

- **命名空间:** `NETWORK`
- **Hash:** `0x7A5487FE9FAA6B48`
- **JHash:** `0x998103C2`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NETWORK_TIME()
```

**返回值:** `int` (Native: `int`)

---

### GET_NETWORK_TIME_ACCURATE

- **命名空间:** `NETWORK`
- **Hash:** `0x89023FBBF9200E9F`
- **JHash:** `0x98AA48E5`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NETWORK_TIME_ACCURATE()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns the same value as GET_NETWORK_TIME in freemode, but as opposed to `GET_NETWORK_TIME` it always gets the most recent time, instead of once per tick.
Could be used for benchmarking since it can return times in ticks.
```

---

### GET_NUM_COMMERCE_ITEMS

- **命名空间:** `NETWORK`
- **Hash:** `0xF2EAC213D5EA0623`
- **JHash:** `0x965EA007`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUM_COMMERCE_ITEMS()
```

**返回值:** `int` (Native: `int`)

---

### GET_NUM_CREATED_MISSION_OBJECTS

- **命名空间:** `NETWORK`
- **Hash:** `0x12B6281B6C6706C0`
- **JHash:** `0x603FA104`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUM_CREATED_MISSION_OBJECTS(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `int`)

---

### GET_NUM_CREATED_MISSION_PEDS

- **命名空间:** `NETWORK`
- **Hash:** `0xCB215C4B56A7FAE7`
- **JHash:** `0xD8FEC4F8`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUM_CREATED_MISSION_PEDS(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `int`)

---

### GET_NUM_CREATED_MISSION_VEHICLES

- **命名空间:** `NETWORK`
- **Hash:** `0x0CD9AB83489430EA`
- **JHash:** `0x20527695`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUM_CREATED_MISSION_VEHICLES(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `int`)

---

### GET_NUM_RESERVED_MISSION_OBJECTS

- **命名空间:** `NETWORK`
- **Hash:** `0xAA81B5F10BC43AC2`
- **JHash:** `0x16A80CD6`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUM_RESERVED_MISSION_OBJECTS(bool p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
p0 appears to be for MP
```

---

### GET_NUM_RESERVED_MISSION_PEDS

- **命名空间:** `NETWORK`
- **Hash:** `0x1F13D5AE5CB17E17`
- **JHash:** `0x6C25975C`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUM_RESERVED_MISSION_PEDS(bool p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
p0 appears to be for MP
```

---

### GET_NUM_RESERVED_MISSION_VEHICLES

- **命名空间:** `NETWORK`
- **Hash:** `0xCF3A965906452031`
- **JHash:** `0xA9A308F3`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUM_RESERVED_MISSION_VEHICLES(bool p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
p0 appears to be for MP
```

---

### GET_ONLINE_VERSION

- **命名空间:** `NETWORK`
- **Hash:** `0xFCA9373EF340AC0A`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_ONLINE_VERSION()
```

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Online version is defined here: update\update.rpf\common\data\version.txt

Example:

[ONLINE_VERSION_NUMBER]
1.33

_GET_ONLINE_VERSION() will return "1.33"
```

---

### GET_RESERVED_MISSION_ENTITIES_IN_AREA

- **命名空间:** `NETWORK`
- **Hash:** `0xE42D626EEC94E5D9`
- **Build:** `1290`

**C# 签名:**
```csharp
void GET_RESERVED_MISSION_ENTITIES_IN_AREA(float x, float y, float z, object p3, ref object out1, ref object out2, ref object out3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p3` | `Any` | `object` | - |
| `out1` | `Any*` | `ref object` | - |
| `out2` | `Any*` | `ref object` | - |
| `out3` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### GET_STATUS_OF_TEXTURE_DOWNLOAD

- **命名空间:** `NETWORK`
- **Hash:** `0x8BD6C6DEA20E82C6`
- **JHash:** `0x03225BA3`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_STATUS_OF_TEXTURE_DOWNLOAD(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
0 = succeeded
1 = pending
2 = failed
```

---

### GET_TIME_AS_STRING

- **命名空间:** `NETWORK`
- **Hash:** `0x9E23B1777A927DAD`
- **JHash:** `0x8218944E`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_TIME_AS_STRING(int time)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `time` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

---

### GET_TIME_DIFFERENCE

- **命名空间:** `NETWORK`
- **Hash:** `0xA2C6FC031D46FFF0`
- **JHash:** `0x5666A837`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_TIME_DIFFERENCE(int timeA, int timeB)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `timeA` | `int` | `int` | - |
| `timeB` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Subtracts the second argument from the first.
```

---

### GET_TIME_OFFSET

- **命名空间:** `NETWORK`
- **Hash:** `0x017008CCDAD48503`
- **JHash:** `0x2E079AE6`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_TIME_OFFSET(int timeA, int timeB)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `timeA` | `int` | `int` | - |
| `timeB` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Adds the first argument to the second.
```

---

### GET_USER_PREMIUM_ACCESS

- **命名空间:** `NETWORK`
- **Hash:** `0x754615490A029508`
- **Build:** `1290`

**C# 签名:**
```csharp
int GET_USER_PREMIUM_ACCESS()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Checks some commerce stuff
```

---

### GET_USER_STARTER_ACCESS

- **命名空间:** `NETWORK`
- **Hash:** `0x155467ACA0F55705`
- **Build:** `1290`

**C# 签名:**
```csharp
int GET_USER_STARTER_ACCESS()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Checks some commerce stuff
```

---

### HAS_NETWORK_TIME_STARTED

- **命名空间:** `NETWORK`
- **Hash:** `0x46718ACEEDEAFC84`
- **JHash:** `0x4538C4A2`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_NETWORK_TIME_STARTED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_COMMERCE_DATA_FETCH_IN_PROGRESS

- **命名空间:** `NETWORK`
- **Hash:** `0x1D4DC17C38FEAFF0`
- **JHash:** `0xED4A272F`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_COMMERCE_DATA_FETCH_IN_PROGRESS()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_COMMERCE_DATA_VALID

- **命名空间:** `NETWORK`
- **Hash:** `0xEA14EEF5B7CD2C30`
- **JHash:** `0xEEFC8A55`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_COMMERCE_DATA_VALID()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_COMMERCE_STORE_OPEN

- **命名空间:** `NETWORK`
- **Hash:** `0x2EAC52B4019E2782`
- **JHash:** `0x25E2DBA9`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_COMMERCE_STORE_OPEN()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_DAMAGE_TRACKER_ACTIVE_ON_NETWORK_ID

- **命名空间:** `NETWORK`
- **Hash:** `0x6E192E33AD436366`
- **JHash:** `0x597063BA`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_DAMAGE_TRACKER_ACTIVE_ON_NETWORK_ID(int netID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netID` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_DAMAGE_TRACKER_ACTIVE_ON_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0xB2092A1EAA7FD45F`
- **Build:** `757`

**C# 签名:**
```csharp
bool IS_DAMAGE_TRACKER_ACTIVE_ON_PLAYER(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_A_GHOST

- **命名空间:** `NETWORK`
- **Hash:** `0x21D04D7BC538C146`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ENTITY_A_GHOST(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ENTITY_IN_GHOST_COLLISION

- **命名空间:** `NETWORK`
- **Hash:** `0x7EF7649B64D7FF10`
- **Build:** `944`

**C# 签名:**
```csharp
bool IS_ENTITY_IN_GHOST_COLLISION(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_NETWORK_ID_OWNED_BY_PARTICIPANT

- **命名空间:** `NETWORK`
- **Hash:** `0xA1607996431332DF`
- **JHash:** `0xEA5176C0`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_NETWORK_ID_OWNED_BY_PARTICIPANT(int netId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_NETWORK_VEHICLE_RUNNING_RESPOT_TIMER

- **命名空间:** `NETWORK`
- **Hash:** `0xDD7CEF5B3A4DA8A6`
- **Build:** `2802`

**C# 签名:**
```csharp
bool IS_NETWORK_VEHICLE_RUNNING_RESPOT_TIMER(int networkID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `networkID` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_OBJECT_REASSIGNMENT_IN_PROGRESS

- **命名空间:** `NETWORK`
- **Hash:** `0x28123C8B056CC8AA`
- **Build:** `3274`

**C# 签名:**
```csharp
bool IS_OBJECT_REASSIGNMENT_IN_PROGRESS()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PLAYER_IN_CUTSCENE

- **命名空间:** `NETWORK`
- **Hash:** `0xE73092F4157CD126`
- **JHash:** `0xE0A619BD`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_IN_CUTSCENE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SPHERE_VISIBLE_TO_ANOTHER_MACHINE

- **命名空间:** `NETWORK`
- **Hash:** `0xD82CF8E64C8729D8`
- **JHash:** `0x23C5274E`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SPHERE_VISIBLE_TO_ANOTHER_MACHINE(float p0, float p1, float p2, float p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SPHERE_VISIBLE_TO_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0xDC3A310219E5DA62`
- **JHash:** `0xE9FCFB32`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SPHERE_VISIBLE_TO_PLAYER(object p0, float p1, float p2, float p3, float p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_STORE_AVAILABLE_TO_USER

- **命名空间:** `NETWORK`
- **Hash:** `0x883D79C4071E18B3`
- **JHash:** `0xD32FA11F`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_STORE_AVAILABLE_TO_USER()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_TIME_EQUAL_TO

- **命名空间:** `NETWORK`
- **Hash:** `0xF5BC95857BD6D512`
- **JHash:** `0x8B4D1C06`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_TIME_EQUAL_TO(int timeA, int timeB)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `timeA` | `int` | `int` | - |
| `timeB` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if the two times are equal; otherwise returns false.
```

---

### IS_TIME_LESS_THAN

- **命名空间:** `NETWORK`
- **Hash:** `0xCB2CF5148012C8D0`
- **JHash:** `0x50EF8FC6`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_TIME_LESS_THAN(int timeA, int timeB)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `timeA` | `int` | `int` | - |
| `timeB` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Subtracts the second argument from the first, then returns whether the result is negative.
```

---

### IS_TIME_MORE_THAN

- **命名空间:** `NETWORK`
- **Hash:** `0xDE350F8651E4346C`
- **JHash:** `0xBBB6DF61`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_TIME_MORE_THAN(int timeA, int timeB)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `timeA` | `int` | `int` | - |
| `timeB` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Subtracts the first argument from the second, then returns whether the result is negative.
```

---

### IS_USER_OLD_ENOUGH_TO_ACCESS_STORE

- **命名空间:** `NETWORK`
- **Hash:** `0x59328EB08C5CEB2B`
- **JHash:** `0x70F6D3AD`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_USER_OLD_ENOUGH_TO_ACCESS_STORE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### LOBBY_AUTO_MULTIPLAYER_EVENT

- **命名空间:** `LOBBY`
- **Hash:** `0x8AA464D4E0F6ACCD`
- **JHash:** `0x94BCAC7C`
- **Build:** `323`

**C# 签名:**
```csharp
bool LOBBY_AUTO_MULTIPLAYER_EVENT()
```

**返回值:** `bool` (Native: `BOOL`)

---

### LOBBY_AUTO_MULTIPLAYER_FREEMODE

- **命名空间:** `LOBBY`
- **Hash:** `0xEF7D17BC6C85264C`
- **JHash:** `0xD87F3A9E`
- **Build:** `323`

**C# 签名:**
```csharp
bool LOBBY_AUTO_MULTIPLAYER_FREEMODE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### LOBBY_AUTO_MULTIPLAYER_MENU

- **命名空间:** `LOBBY`
- **Hash:** `0xF2CA003F167E21D2`
- **JHash:** `0x106C8317`
- **Build:** `323`

**C# 签名:**
```csharp
bool LOBBY_AUTO_MULTIPLAYER_MENU()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
This function is hard-coded to always return 0.
```

---

### LOBBY_AUTO_MULTIPLAYER_RANDOM_JOB

- **命名空间:** `LOBBY`
- **Hash:** `0xC6DC823253FBB366`
- **JHash:** `0x734CFEDA`
- **Build:** `323`

**C# 签名:**
```csharp
bool LOBBY_AUTO_MULTIPLAYER_RANDOM_JOB()
```

**返回值:** `bool` (Native: `BOOL`)

---

### LOBBY_SET_AUTO_MP_RANDOM_JOB

- **命名空间:** `LOBBY`
- **Hash:** `0xC7E7181C09F33B69`
- **JHash:** `0x8C227332`
- **Build:** `323`

**C# 签名:**
```csharp
void LOBBY_SET_AUTO_MP_RANDOM_JOB(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### LOBBY_SET_AUTO_MULTIPLAYER

- **命名空间:** `LOBBY`
- **Hash:** `0xB0C56BD3D808D863`
- **JHash:** `0xC0B971EA`
- **Build:** `323`

**C# 签名:**
```csharp
void LOBBY_SET_AUTO_MULTIPLAYER(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### LOBBY_SET_AUTO_MULTIPLAYER_EVENT

- **命名空间:** `LOBBY`
- **Hash:** `0xFC309E94546FCDB5`
- **JHash:** `0x7D90EEE5`
- **Build:** `323`

**C# 签名:**
```csharp
void LOBBY_SET_AUTO_MULTIPLAYER_EVENT(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_ACCEPT_PRESENCE_INVITE

- **命名空间:** `NETWORK`
- **Hash:** `0xFA91550DF9318B22`
- **JHash:** `0xE5DA4CED`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_ACCEPT_PRESENCE_INVITE(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ACCESS_TUNABLE_BOOL

- **命名空间:** `NETWORK`
- **Hash:** `0xAA6A47A573ABB75A`
- **JHash:** `0x8A04E1FE`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_ACCESS_TUNABLE_BOOL(string tunableContext, string tunableName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `tunableContext` | `const char*` | `string` | - |
| `tunableName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ACCESS_TUNABLE_BOOL_HASH

- **命名空间:** `NETWORK`
- **Hash:** `0xEA16B69D93D71A45`
- **JHash:** `0x18867C61`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_ACCESS_TUNABLE_BOOL_HASH(uint tunableContext, uint tunableName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `tunableContext` | `Hash` | `uint` | - |
| `tunableName` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ACCESS_TUNABLE_BOOL_MODIFICATION_DETECTION_REGISTRATION_HASH

- **命名空间:** `NETWORK`
- **Hash:** `0x697F508861875B42`
- **Build:** `393`

**C# 签名:**
```csharp
bool NETWORK_ACCESS_TUNABLE_BOOL_MODIFICATION_DETECTION_REGISTRATION_HASH(uint contextHash, uint nameHash, ref bool value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `contextHash` | `Hash` | `uint` | - |
| `nameHash` | `Hash` | `uint` | - |
| `value` | `BOOL*` | `ref bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ACCESS_TUNABLE_FLOAT

- **命名空间:** `NETWORK`
- **Hash:** `0xE5608CA7BC163A5F`
- **JHash:** `0x41E8912A`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_ACCESS_TUNABLE_FLOAT(string tunableContext, string tunableName, ref float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `tunableContext` | `const char*` | `string` | - |
| `tunableName` | `const char*` | `string` | - |
| `value` | `float*` | `ref float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ACCESS_TUNABLE_FLOAT_HASH

- **命名空间:** `NETWORK`
- **Hash:** `0x972BC203BBC4C4D5`
- **JHash:** `0x3972551F`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_ACCESS_TUNABLE_FLOAT_HASH(uint tunableContext, uint tunableName, ref float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `tunableContext` | `Hash` | `uint` | - |
| `tunableName` | `Hash` | `uint` | - |
| `value` | `float*` | `ref float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ACCESS_TUNABLE_FLOAT_MODIFICATION_DETECTION_REGISTRATION_HASH

- **命名空间:** `NETWORK`
- **Hash:** `0x1950DAE9848A4739`
- **Build:** `393`

**C# 签名:**
```csharp
bool NETWORK_ACCESS_TUNABLE_FLOAT_MODIFICATION_DETECTION_REGISTRATION_HASH(uint contextHash, uint nameHash, ref float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `contextHash` | `Hash` | `uint` | - |
| `nameHash` | `Hash` | `uint` | - |
| `value` | `float*` | `ref float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ACCESS_TUNABLE_INT

- **命名空间:** `NETWORK`
- **Hash:** `0x8BE1146DFD5D4468`
- **JHash:** `0xE4B3726A`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_ACCESS_TUNABLE_INT(string tunableContext, string tunableName, ref int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `tunableContext` | `const char*` | `string` | - |
| `tunableName` | `const char*` | `string` | - |
| `value` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ACCESS_TUNABLE_INT_HASH

- **命名空间:** `NETWORK`
- **Hash:** `0x40FCE03E50E8DBE8`
- **JHash:** `0xB2E83B75`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_ACCESS_TUNABLE_INT_HASH(uint tunableContext, uint tunableName, ref int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `tunableContext` | `Hash` | `uint` | - |
| `tunableName` | `Hash` | `uint` | - |
| `value` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ACCESS_TUNABLE_INT_MODIFICATION_DETECTION_REGISTRATION_HASH

- **命名空间:** `NETWORK`
- **Hash:** `0x3A8B55FDA4C8DDEF`
- **Build:** `393`

**C# 签名:**
```csharp
bool NETWORK_ACCESS_TUNABLE_INT_MODIFICATION_DETECTION_REGISTRATION_HASH(uint contextHash, uint nameHash, ref int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `contextHash` | `Hash` | `uint` | - |
| `nameHash` | `Hash` | `uint` | - |
| `value` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ACCESS_TUNABLE_MODIFICATION_DETECTION_CLEAR

- **命名空间:** `NETWORK`
- **Hash:** `0xFAFC23AEE23868DB`
- **Build:** `393`

**C# 签名:**
```csharp
bool NETWORK_ACCESS_TUNABLE_MODIFICATION_DETECTION_CLEAR()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ACTION_FOLLOW_INVITE

- **命名空间:** `NETWORK`
- **Hash:** `0xC88156EBB786F8D5`
- **JHash:** `0xAB969F00`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_ACTION_FOLLOW_INVITE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ADD_CLIENT_ENTITY_ANGLED_AREA

- **命名空间:** `NETWORK`
- **Hash:** `0x2B1C623823DB0D9D`
- **Build:** `1103`

**C# 签名:**
```csharp
int NETWORK_ADD_CLIENT_ENTITY_ANGLED_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float radius)
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
| `radius` | `float` | `float` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_ADD_CLIENT_ENTITY_AREA

- **命名空间:** `NETWORK`
- **Hash:** `0x25B99872D588A101`
- **JHash:** `0x4C2C2B12`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_ADD_CLIENT_ENTITY_AREA(float x1, float y1, float z1, float x2, float y2, float z2)
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

### NETWORK_ADD_ENTITY_ANGLED_AREA

- **命名空间:** `NETWORK`
- **Hash:** `0x376C6375BA60293A`
- **JHash:** `0xCD69BEA1`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_ADD_ENTITY_ANGLED_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float width)
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

**返回值:** `int` (Native: `int`)

**说明:**
```
To remove, see: NETWORK_REMOVE_ENTITY_AREA
See IS_POINT_IN_ANGLED_AREA for the definition of an angled area.
```

---

### NETWORK_ADD_ENTITY_AREA

- **命名空间:** `NETWORK`
- **Hash:** `0x494C8FB299290269`
- **JHash:** `0x51030E5B`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_ADD_ENTITY_AREA(float x1, float y1, float z1, float x2, float y2, float z2)
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

### NETWORK_ADD_ENTITY_TO_SYNCHRONISED_SCENE

- **命名空间:** `NETWORK`
- **Hash:** `0xF2404D68CBC855FA`
- **JHash:** `0x10DD636C`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_ADD_ENTITY_TO_SYNCHRONISED_SCENE(int entity, int netScene, string animDict, string animName, float speed, float speedMulitiplier, int flag)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `netScene` | `int` | `int` | - |
| `animDict` | `const char*` | `string` | - |
| `animName` | `const char*` | `string` | - |
| `speed` | `float` | `float` | - |
| `speedMulitiplier` | `float` | `float` | - |
| `flag` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_ADD_FOLLOWERS

- **命名空间:** `NETWORK`
- **Hash:** `0x236406F60CF216D6`
- **JHash:** `0x0EC62629`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_ADD_FOLLOWERS(ref int p0, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int*` | `ref int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
..
```

---

### NETWORK_ADD_FRIEND

- **命名空间:** `NETWORK`
- **Hash:** `0x8E02D73914064223`
- **JHash:** `0x20E5B3EE`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_ADD_FRIEND(ref object gamerHandle, string message)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |
| `message` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ADD_INVALID_OBJECT_MODEL

- **命名空间:** `NETWORK`
- **Hash:** `0x7F562DBC212E81F9`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_ADD_INVALID_OBJECT_MODEL(uint modelHash, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_ADD_MAP_ENTITY_TO_SYNCHRONISED_SCENE

- **命名空间:** `NETWORK`
- **Hash:** `0x45F35C0EDC33B03B`
- **Build:** `1734`

**C# 签名:**
```csharp
void NETWORK_ADD_MAP_ENTITY_TO_SYNCHRONISED_SCENE(int netScene, uint modelHash, float x, float y, float z, float p5, string p6, float p7, float p8, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netScene` | `int` | `int` | - |
| `modelHash` | `Hash` | `uint` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p5` | `float` | `float` | - |
| `p6` | `const char*` | `string` | - |
| `p7` | `float` | `float` | - |
| `p8` | `float` | `float` | - |
| `flags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Similar structure as NETWORK_ADD_ENTITY_TO_SYNCHRONISED_SCENE but it includes this time a hash.
In casino_slots it is used one time in a synced scene involving a ped and the slot machine?
```

---

### NETWORK_ADD_PED_TO_SYNCHRONISED_SCENE

- **命名空间:** `NETWORK`
- **Hash:** `0x742A637471BCECD9`
- **JHash:** `0xB386713E`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_ADD_PED_TO_SYNCHRONISED_SCENE(int ped, int netScene, string animDict, string animnName, float speed, float speedMultiplier, int duration, int flag, float playbackRate, object p9)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `netScene` | `int` | `int` | - |
| `animDict` | `const char*` | `string` | - |
| `animnName` | `const char*` | `string` | - |
| `speed` | `float` | `float` | - |
| `speedMultiplier` | `float` | `float` | - |
| `duration` | `int` | `int` | - |
| `flag` | `int` | `int` | - |
| `playbackRate` | `float` | `float` | - |
| `p9` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_ADD_PED_TO_SYNCHRONISED_SCENE_WITH_IK

- **命名空间:** `NETWORK`
- **Hash:** `0xA5EAFE473E45C442`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_ADD_PED_TO_SYNCHRONISED_SCENE_WITH_IK(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9)
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
| `p7` | `Any` | `object` | - |
| `p8` | `Any` | `object` | - |
| `p9` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_ADD_SYNCHRONISED_SCENE_CAMERA

- **命名空间:** `NETWORK`
- **Hash:** `0xCF8BD3B0BD6D42D7`
- **JHash:** `0xBFFE8B5C`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_ADD_SYNCHRONISED_SCENE_CAMERA(int netScene, string animDict, string animName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netScene` | `int` | `int` | - |
| `animDict` | `const char*` | `string` | - |
| `animName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_ALLOW_CLONING_WHILE_IN_TUTORIAL

- **命名空间:** `NETWORK`
- **Hash:** `0x0F1A4B45B7693B95`
- **Build:** `2189`

**C# 签名:**
```csharp
void NETWORK_ALLOW_CLONING_WHILE_IN_TUTORIAL(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_ALLOW_GANG_TO_JOIN_TUTORIAL_SESSION

- **命名空间:** `NETWORK`
- **Hash:** `0xFB680D403909DC70`
- **JHash:** `0xFFB2ADA1`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_ALLOW_GANG_TO_JOIN_TUTORIAL_SESSION(int teamId, int instanceId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `teamId` | `int` | `int` | - |
| `instanceId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
teamId must be < 3, instanceId must be < 64
```

---

### NETWORK_ALLOW_INVITE_PROCESS_IN_PLAYER_SWITCH

- **命名空间:** `NETWORK`
- **Hash:** `0x6B07B9CE4D390375`
- **JHash:** `0x0FCE995D`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_ALLOW_INVITE_PROCESS_IN_PLAYER_SWITCH(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_ALLOW_REMOTE_ATTACHMENT_MODIFICATION

- **命名空间:** `NETWORK`
- **Hash:** `0x267C78C60E806B9A`
- **JHash:** `0xBB2D33D3`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_ALLOW_REMOTE_ATTACHMENT_MODIFICATION(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_ALLOW_REMOTE_SYNCED_SCENE_LOCAL_PLAYER_REQUESTS

- **命名空间:** `NETWORK`
- **Hash:** `0x144DA052257AE7D8`
- **Build:** `1103`

**C# 签名:**
```csharp
void NETWORK_ALLOW_REMOTE_SYNCED_SCENE_LOCAL_PLAYER_REQUESTS(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_AM_I_BLOCKED_BY_GAMER

- **命名空间:** `NETWORK`
- **Hash:** `0x15337C7C268A27B2`
- **JHash:** `0xD19B312C`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_AM_I_BLOCKED_BY_GAMER(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_AM_I_BLOCKED_BY_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0x87F395D957D4353D`
- **JHash:** `0x953EF45E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_AM_I_BLOCKED_BY_PLAYER(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_AM_I_MUTED_BY_GAMER

- **命名空间:** `NETWORK`
- **Hash:** `0xDF02A2C93F1F26DA`
- **JHash:** `0x7685B333`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_AM_I_MUTED_BY_GAMER(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_AM_I_MUTED_BY_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0x9D6981DFC91A8604`
- **JHash:** `0xE128F2B0`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_AM_I_MUTED_BY_PLAYER(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_APPLY_CACHED_PLAYER_HEAD_BLEND_DATA

- **命名空间:** `NETWORK`
- **Hash:** `0x99B72C7ABDE5C910`
- **JHash:** `0x99F58A07`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_APPLY_CACHED_PLAYER_HEAD_BLEND_DATA(int ped, int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_APPLY_PED_SCAR_DATA

- **命名空间:** `NETWORK`
- **Hash:** `0xE66C690248F11150`
- **JHash:** `0x4818ACD0`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_APPLY_PED_SCAR_DATA(int ped, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_APPLY_TRANSITION_PARAMETER

- **命名空间:** `NETWORK`
- **Hash:** `0x521638ADA1BA0D18`
- **JHash:** `0xCEE79711`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_APPLY_TRANSITION_PARAMETER(int p0, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_APPLY_TRANSITION_PARAMETER_STRING

- **命名空间:** `NETWORK`
- **Hash:** `0xEBEFC2E77084F599`
- **JHash:** `0xE0C28DB5`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_APPLY_TRANSITION_PARAMETER_STRING(int p0, string string, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `string` | `const char*` | `string` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_APPLY_VOICE_PROXIMITY_OVERRIDE

- **命名空间:** `NETWORK`
- **Hash:** `0xDBD2056652689917`
- **JHash:** `0xF1E84832`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_APPLY_VOICE_PROXIMITY_OVERRIDE(float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_ARE_HANDLES_THE_SAME

- **命名空间:** `NETWORK`
- **Hash:** `0x57DBA049E110F217`
- **JHash:** `0x45975AE3`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_ARE_HANDLES_THE_SAME(ref object gamerHandle1, ref object gamerHandle2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle1` | `Any*` | `ref object` | - |
| `gamerHandle2` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ARE_PLAYERS_IN_SAME_TUTORIAL_SESSION

- **命名空间:** `NETWORK`
- **Hash:** `0x9DE986FC9A87C474`
- **JHash:** `0xE66A0B40`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_ARE_PLAYERS_IN_SAME_TUTORIAL_SESSION(int player, int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `index` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ARE_SOCIAL_CLUB_POLICIES_CURRENT

- **命名空间:** `NETWORK`
- **Hash:** `0xBA9775570DB788CF`
- **JHash:** `0x358D1D77`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_ARE_SOCIAL_CLUB_POLICIES_CURRENT()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ARE_TRANSITION_DETAILS_VALID

- **命名空间:** `NETWORK`
- **Hash:** `0x2615AA2A695930C1`
- **JHash:** `0xCDEBCCE7`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_ARE_TRANSITION_DETAILS_VALID(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ATTACH_SYNCHRONISED_SCENE_TO_ENTITY

- **命名空间:** `NETWORK`
- **Hash:** `0x478DCBD2A98B705A`
- **JHash:** `0x3FE5B222`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_ATTACH_SYNCHRONISED_SCENE_TO_ENTITY(int netScene, int entity, int bone)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netScene` | `int` | `int` | - |
| `entity` | `Entity` | `int` | - |
| `bone` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_BAIL

- **命名空间:** `NETWORK`
- **Hash:** `0x95914459A87EBA28`
- **JHash:** `0x87D79A04`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_BAIL(int p0, int p1, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_BAIL_TRANSITION

- **命名空间:** `NETWORK`
- **Hash:** `0xEAA572036990CD1B`
- **JHash:** `0xB59D74CA`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_BAIL_TRANSITION(int p0, int p1, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_BLOCK_INVITES

- **命名空间:** `NETWORK`
- **Hash:** `0x34F9E9049454A7A0`
- **JHash:** `0xD156FD1A`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_BLOCK_INVITES(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_BLOCK_JOIN_QUEUE_INVITES

- **命名空间:** `NETWORK`
- **Hash:** `0xCFEB8AF24FC1D0BB`
- **JHash:** `0x8AB4890B`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_BLOCK_JOIN_QUEUE_INVITES(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_BLOCK_PROXY_MIGRATION_BETWEEN_TUTORIAL_SESSIONS

- **命名空间:** `NETWORK`
- **Hash:** `0xFEA7A352DDB34D52`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_BLOCK_PROXY_MIGRATION_BETWEEN_TUTORIAL_SESSIONS(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_CACHE_LOCAL_PLAYER_HEAD_BLEND_DATA

- **命名空间:** `NETWORK`
- **Hash:** `0xBD0BE0BFC927EAC1`
- **JHash:** `0x94AB35A9`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_CACHE_LOCAL_PLAYER_HEAD_BLEND_DATA()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_CANCEL_RESPAWN_SEARCH

- **命名空间:** `NETWORK`
- **Hash:** `0xFB8F2A6F3DF08CBE`
- **JHash:** `0x44BFB619`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_CANCEL_RESPAWN_SEARCH()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_CANCEL_TRANSITION_MATCHMAKING

- **命名空间:** `NETWORK`
- **Hash:** `0x023782EFC70585EE`
- **Build:** `2699`

**C# 签名:**
```csharp
void NETWORK_CANCEL_TRANSITION_MATCHMAKING()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_CAN_ACCESS_MULTIPLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0xAF50DA1A3F8B1BA4`
- **JHash:** `0xA520B982`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CAN_ACCESS_MULTIPLAYER(ref int loadingState)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `loadingState` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
11 - Need to download tunables.
12 - Need to download background script.

Returns 1 if the multiplayer is loaded, otherwhise 0.
```

---

### NETWORK_CAN_BAIL

- **命名空间:** `NETWORK`
- **Hash:** `0x580CE4438479CC61`
- **JHash:** `0x60E1FEDF`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CAN_BAIL()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CAN_COMMUNICATE_WITH_GAMER

- **命名空间:** `NETWORK`
- **Hash:** `0x8F5D1AD832AEB06C`
- **JHash:** `0xD05EB7F6`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CAN_COMMUNICATE_WITH_GAMER(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CAN_ENTER_MULTIPLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0x7E782A910C362C25`
- **JHash:** `0x4A23B9C9`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CAN_ENTER_MULTIPLAYER()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CAN_GAMER_PLAY_MULTIPLAYER_WITH_ME

- **命名空间:** `NETWORK`
- **Hash:** `0x135F9B7B7ADD2185`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CAN_GAMER_PLAY_MULTIPLAYER_WITH_ME(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CAN_PLAY_MULTIPLAYER_WITH_GAMER

- **命名空间:** `NETWORK`
- **Hash:** `0x07DD29D5E22763F1`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CAN_PLAY_MULTIPLAYER_WITH_GAMER(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CAN_QUEUE_FOR_PREVIOUS_SESSION_JOIN

- **命名空间:** `NETWORK`
- **Hash:** `0x2BF66D2E7414F686`
- **JHash:** `0x9156EFC0`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CAN_QUEUE_FOR_PREVIOUS_SESSION_JOIN()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CAN_RECEIVE_LOCAL_INVITE

- **命名空间:** `NETWORK`
- **Hash:** `0x421E34C55F125964`
- **Build:** `2612`

**C# 签名:**
```csharp
bool NETWORK_CAN_RECEIVE_LOCAL_INVITE(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CAN_SEND_LOCAL_INVITE

- **命名空间:** `NETWORK`
- **Hash:** `0x021ABCBD98EC4320`
- **Build:** `2612`

**C# 签名:**
```csharp
bool NETWORK_CAN_SEND_LOCAL_INVITE(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CAN_SESSION_END

- **命名空间:** `NETWORK`
- **Hash:** `0x4EEBC3694E49C572`
- **JHash:** `0xE1FCCDBA`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CAN_SESSION_END()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CAN_SET_WAYPOINT

- **命名空间:** `NETWORK`
- **Hash:** `0xC927EC229934AF60`
- **JHash:** `0x009E68F3`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CAN_SET_WAYPOINT()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CAN_TEXT_CHAT_WITH_GAMER

- **命名空间:** `NETWORK`
- **Hash:** `0xA150A4F065806B1F`
- **Build:** `944`

**C# 签名:**
```csharp
bool NETWORK_CAN_TEXT_CHAT_WITH_GAMER(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CAN_VIEW_GAMER_USER_CONTENT

- **命名空间:** `NETWORK`
- **Hash:** `0xB57A49545BA53CE7`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CAN_VIEW_GAMER_USER_CONTENT(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CHANGE_TRANSITION_SLOTS

- **命名空间:** `NETWORK`
- **Hash:** `0xEEEDA5E6D7080987`
- **JHash:** `0x1E5F6AEF`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_CHANGE_TRANSITION_SLOTS(object p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_CHECK_CAN_ACCESS_AND_ALERT

- **命名空间:** `NETWORK`
- **Hash:** `0x6FA9825D0B5A721B`
- **Build:** `3570`

**C# 签名:**
```csharp
bool NETWORK_CHECK_CAN_ACCESS_AND_ALERT()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CHECK_COMMUNICATION_PRIVILEGES

- **命名空间:** `NETWORK`
- **Hash:** `0x83F28CE49FBBFFBA`
- **JHash:** `0xA79E5B05`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CHECK_COMMUNICATION_PRIVILEGES(int p0, int p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CHECK_DATA_MANAGER_FOR_HANDLE

- **命名空间:** `NETWORK`
- **Hash:** `0x4AD490AE1536933B`
- **Build:** `372`

**C# 签名:**
```csharp
bool NETWORK_CHECK_DATA_MANAGER_FOR_HANDLE(object p0, ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CHECK_DATA_MANAGER_SUCCEEDED_FOR_HANDLE

- **命名空间:** `NETWORK`
- **Hash:** `0x44B37CDCAE765AAE`
- **JHash:** `0x13301529`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CHECK_DATA_MANAGER_SUCCEEDED_FOR_HANDLE(int p0, ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CHECK_ONLINE_PRIVILEGES

- **命名空间:** `NETWORK`
- **Hash:** `0x78321BEA235FD8CD`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CHECK_ONLINE_PRIVILEGES(object p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CHECK_PRIVILEGES

- **命名空间:** `NETWORK`
- **Hash:** `0x0CF6CC51AA18F0F8`
- **Build:** `1180`

**C# 签名:**
```csharp
bool NETWORK_CHECK_PRIVILEGES(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CHECK_ROS_LINK_WENTDOWN_NOT_NET

- **命名空间:** `NETWORK`
- **Hash:** `0x60EDD13EB3AC1FF3`
- **JHash:** `0x4DEBC227`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CHECK_ROS_LINK_WENTDOWN_NOT_NET()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if profile setting 901 is set to true and sets it to false.
```

---

### NETWORK_CHECK_TEXT_COMMUNICATION_PRIVILEGES

- **命名空间:** `NETWORK`
- **Hash:** `0x07EAB372C8841D99`
- **Build:** `1011`

**C# 签名:**
```csharp
bool NETWORK_CHECK_TEXT_COMMUNICATION_PRIVILEGES(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CHECK_USER_CONTENT_PRIVILEGES

- **命名空间:** `NETWORK`
- **Hash:** `0x595F028698072DD9`
- **JHash:** `0xBB54AA3D`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CHECK_USER_CONTENT_PRIVILEGES(int p0, int p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CLAN_ANY_DOWNLOAD_MEMBERSHIP_PENDING

- **命名空间:** `NETWORK`
- **Hash:** `0xB3F64A6A91432477`
- **JHash:** `0x83ED8E08`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CLAN_ANY_DOWNLOAD_MEMBERSHIP_PENDING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CLAN_CREWINFO_GET_CREWRANKTITLE

- **命名空间:** `NETWORK`
- **Hash:** `0x2B51EDBEFC301339`
- **JHash:** `0x8E952B12`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CLAN_CREWINFO_GET_CREWRANKTITLE(int p0, string p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CLAN_CREWINFO_GET_STRING_VALUE

- **命名空间:** `NETWORK`
- **Hash:** `0x729E3401F0430686`
- **JHash:** `0xBDA90BAC`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CLAN_CREWINFO_GET_STRING_VALUE(string animDict, string animName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `animDict` | `const char*` | `string` | - |
| `animName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Only documented...

Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### NETWORK_CLAN_DOWNLOAD_MEMBERSHIP

- **命名空间:** `NETWORK`
- **Hash:** `0xA989044E70010ABE`
- **JHash:** `0x8E8CB520`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CLAN_DOWNLOAD_MEMBERSHIP(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CLAN_DOWNLOAD_MEMBERSHIP_PENDING

- **命名空间:** `NETWORK`
- **Hash:** `0x5B9E023DC6EBEDC0`
- **JHash:** `0x1FDB590F`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CLAN_DOWNLOAD_MEMBERSHIP_PENDING(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CLAN_GET_EMBLEM_TXD_NAME

- **命名空间:** `NETWORK`
- **Hash:** `0x5835D9CD92E83184`
- **JHash:** `0xBA672146`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CLAN_GET_EMBLEM_TXD_NAME(ref object netHandle, string txdName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netHandle` | `Any*` | `ref object` | - |
| `txdName` | `char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CLAN_GET_LOCAL_MEMBERSHIPS_COUNT

- **命名空间:** `NETWORK`
- **Hash:** `0x1F471B79ACC90BEF`
- **JHash:** `0x807B3450`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_CLAN_GET_LOCAL_MEMBERSHIPS_COUNT()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_CLAN_GET_MEMBERSHIP

- **命名空间:** `NETWORK`
- **Hash:** `0xC8BC2011F67B3411`
- **JHash:** `0xCDC4A590`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CLAN_GET_MEMBERSHIP(ref int p0, ref object clanMembership, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int*` | `ref int` | - |
| `clanMembership` | `Any*` | `ref object` | - |
| `p2` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CLAN_GET_MEMBERSHIP_COUNT

- **命名空间:** `NETWORK`
- **Hash:** `0xAAB11F6C4ADBC2C1`
- **JHash:** `0x25924010`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_CLAN_GET_MEMBERSHIP_COUNT(ref int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int*` | `ref int` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_CLAN_GET_MEMBERSHIP_DESC

- **命名空间:** `NETWORK`
- **Hash:** `0x48DE78AF2C8885B8`
- **JHash:** `0x3369DD1F`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CLAN_GET_MEMBERSHIP_DESC(ref object memberDesc, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `memberDesc` | `Any*` | `ref object` | - |
| `p1` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CLAN_GET_MEMBERSHIP_VALID

- **命名空间:** `NETWORK`
- **Hash:** `0x48A59CF88D43DF0E`
- **JHash:** `0x48914F6A`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CLAN_GET_MEMBERSHIP_VALID(ref int p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int*` | `ref int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CLAN_GET_UI_FORMATTED_TAG

- **命名空间:** `NETWORK`
- **Hash:** `0xF45352426FF3A4F0`
- **JHash:** `0xF633805A`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_CLAN_GET_UI_FORMATTED_TAG(ref object clanDesc, int bufferSize, string formattedTag)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `clanDesc` | `Any*` | `ref object` | - |
| `bufferSize` | `int` | `int` | - |
| `formattedTag` | `char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
bufferSize is 35 in the scripts.
```

---

### NETWORK_CLAN_HAS_CREWINFO_METADATA_BEEN_RECEIVED

- **命名空间:** `NETWORK`
- **Hash:** `0xC32EA7A2F6CA7557`
- **JHash:** `0x966C90FD`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CLAN_HAS_CREWINFO_METADATA_BEEN_RECEIVED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CLAN_IS_EMBLEM_READY

- **命名空间:** `NETWORK`
- **Hash:** `0xA134777FF7F33331`
- **JHash:** `0x88B13CDC`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CLAN_IS_EMBLEM_READY(object p0, ref object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CLAN_IS_ROCKSTAR_CLAN

- **命名空间:** `NETWORK`
- **Hash:** `0x7543BB439F63792B`
- **JHash:** `0x54E79E9C`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CLAN_IS_ROCKSTAR_CLAN(ref object clanDesc, int bufferSize)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `clanDesc` | `Any*` | `ref object` | - |
| `bufferSize` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
bufferSize is 35 in the scripts.
```

---

### NETWORK_CLAN_JOIN

- **命名空间:** `NETWORK`
- **Hash:** `0x9FAAA4F4FC71F87F`
- **JHash:** `0x79C916C5`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CLAN_JOIN(int clanDesc)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `clanDesc` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CLAN_PLAYER_GET_DESC

- **命名空间:** `NETWORK`
- **Hash:** `0xEEE6EACBE8874FBA`
- **JHash:** `0x6EE4A282`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CLAN_PLAYER_GET_DESC(ref object clanDesc, int bufferSize, ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `clanDesc` | `Any*` | `ref object` | - |
| `bufferSize` | `int` | `int` | - |
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
bufferSize is 35 in the scripts.

bufferSize is the elementCount of p0(desc), sizeof(p0) == 280 == p1*8 == 35 * 8, p2(netHandle) is obtained from NETWORK::NETWORK_HANDLE_FROM_PLAYER.  And no, I can't explain why 35 * sizeof(int) == 280 and not 140, but I'll get back to you on that.

the answer is: because p0 an int64_t* / int64_t[35].  and FYI p2 is an int64_t[13]

https://pastebin.com/cSZniHak
```

---

### NETWORK_CLAN_PLAYER_IS_ACTIVE

- **命名空间:** `NETWORK`
- **Hash:** `0xB124B57F571D8F18`
- **JHash:** `0xAB8319A3`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CLAN_PLAYER_IS_ACTIVE(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CLAN_RELEASE_EMBLEM

- **命名空间:** `NETWORK`
- **Hash:** `0x113E6E3E50E286B0`
- **JHash:** `0xD6E3D5EA`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_CLAN_RELEASE_EMBLEM(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_CLAN_REMOTE_MEMBERSHIPS_ARE_IN_CACHE

- **命名空间:** `NETWORK`
- **Hash:** `0xBB6E6FEE99D866B2`
- **JHash:** `0x40202867`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CLAN_REMOTE_MEMBERSHIPS_ARE_IN_CACHE(ref int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CLAN_REQUEST_EMBLEM

- **命名空间:** `NETWORK`
- **Hash:** `0x13518FF1C6B28938`
- **JHash:** `0x7963FA4D`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CLAN_REQUEST_EMBLEM(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CLAN_SERVICE_IS_VALID

- **命名空间:** `NETWORK`
- **Hash:** `0x579CCED0265D4896`
- **JHash:** `0xF5F4BD95`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CLAN_SERVICE_IS_VALID()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CLEAR_CLOCK_TIME_OVERRIDE

- **命名空间:** `NETWORK`
- **Hash:** `0xD972DF67326F966E`
- **JHash:** `0xC4AEAF49`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_CLEAR_CLOCK_TIME_OVERRIDE()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_CLEAR_FOLLOWERS

- **命名空间:** `NETWORK`
- **Hash:** `0x058F43EC59A8631A`
- **JHash:** `0x5E557307`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_CLEAR_FOLLOWERS()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_CLEAR_FOLLOW_INVITE

- **命名空间:** `NETWORK`
- **Hash:** `0x439BFDE3CD0610F6`
- **JHash:** `0x3242F952`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CLEAR_FOLLOW_INVITE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CLEAR_FOUND_GAMERS

- **命名空间:** `NETWORK`
- **Hash:** `0x6D14CCEE1B40381A`
- **JHash:** `0x6AA9A154`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_CLEAR_FOUND_GAMERS()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_CLEAR_GET_GAMER_STATUS

- **命名空间:** `NETWORK`
- **Hash:** `0x86E0660E4F5C956D`
- **JHash:** `0x3F7EDBBD`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_CLEAR_GET_GAMER_STATUS()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_CLEAR_GROUP_ACTIVITY

- **命名空间:** `NETWORK`
- **Hash:** `0x1888694923EF4591`
- **JHash:** `0x157D44D3`
- **Build:** `393`

**C# 签名:**
```csharp
void NETWORK_CLEAR_GROUP_ACTIVITY()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_CLEAR_INVALID_OBJECT_MODELS

- **命名空间:** `NETWORK`
- **Hash:** `0x03B2F03A53D85E41`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_CLEAR_INVALID_OBJECT_MODELS()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_CLEAR_OFFLINE_INVITE_PENDING

- **命名空间:** `NETWORK`
- **Hash:** `0x140E6A44870A11CE`
- **JHash:** `0x50507BED`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_CLEAR_OFFLINE_INVITE_PENDING()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_CLEAR_QUEUED_JOIN_REQUEST

- **命名空间:** `NETWORK`
- **Hash:** `0x6CE50E47F5543D0C`
- **Build:** `573`

**C# 签名:**
```csharp
void NETWORK_CLEAR_QUEUED_JOIN_REQUEST()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_CLEAR_TRANSITION_CREATOR_HANDLE

- **命名空间:** `NETWORK`
- **Hash:** `0xFB3272229A82C759`
- **JHash:** `0x8BB336F7`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_CLEAR_TRANSITION_CREATOR_HANDLE()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_CLEAR_VOICE_CHANNEL

- **命名空间:** `NETWORK`
- **Hash:** `0xE036A705F989E049`
- **JHash:** `0x9ECF722A`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_CLEAR_VOICE_CHANNEL()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_CLEAR_VOICE_PROXIMITY_OVERRIDE

- **命名空间:** `NETWORK`
- **Hash:** `0xF03755696450470C`
- **JHash:** `0x7F9B9052`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_CLEAR_VOICE_PROXIMITY_OVERRIDE()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_CLOSE_TRANSITION_MATCHMAKING

- **命名空间:** `NETWORK`
- **Hash:** `0x43F4DBA69710E01E`
- **JHash:** `0x82D32D07`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_CLOSE_TRANSITION_MATCHMAKING()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_CONCEAL_ENTITY

- **命名空间:** `NETWORK`
- **Hash:** `0x1632BE0AC1E62876`
- **Build:** `877`

**C# 签名:**
```csharp
void NETWORK_CONCEAL_ENTITY(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_CONCEAL_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0xBBDF066252829606`
- **JHash:** `0x72052DB3`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_CONCEAL_PLAYER(int player, bool toggle, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_CREATE_SYNCHRONISED_SCENE

- **命名空间:** `NETWORK`
- **Hash:** `0x7CD6BC4C2BBDD526`
- **JHash:** `0xB06FE3FE`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_CREATE_SYNCHRONISED_SCENE(float x, float y, float z, float xRot, float yRot, float zRot, int rotationOrder, bool useOcclusionPortal, bool looped, float p9, float animTime, float p11)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `xRot` | `float` | `float` | - |
| `yRot` | `float` | `float` | - |
| `zRot` | `float` | `float` | - |
| `rotationOrder` | `int` | `int` | - |
| `useOcclusionPortal` | `BOOL` | `bool` | - |
| `looped` | `BOOL` | `bool` | - |
| `p9` | `float` | `float` | - |
| `animTime` | `float` | `float` | - |
| `p11` | `float` | `float` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_DID_FIND_GAMERS_SUCCEED

- **命名空间:** `NETWORK`
- **Hash:** `0xF9B83B77929D8863`
- **JHash:** `0xBEDC4503`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_DID_FIND_GAMERS_SUCCEED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_DID_GET_GAMER_STATUS_SUCCEED

- **命名空间:** `NETWORK`
- **Hash:** `0x5AE17C6B0134B7F1`
- **JHash:** `0xC871E745`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_DID_GET_GAMER_STATUS_SUCCEED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_DISABLE_INVINCIBLE_FLASHING

- **命名空间:** `NETWORK`
- **Hash:** `0x9DD368BF06983221`
- **JHash:** `0x8D27280E`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_DISABLE_INVINCIBLE_FLASHING(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_DISABLE_LEAVE_REMOTE_PED_BEHIND

- **命名空间:** `NETWORK`
- **Hash:** `0xC505036A35AFD01B`
- **JHash:** `0xA100CC97`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_DISABLE_LEAVE_REMOTE_PED_BEHIND(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_DISABLE_PROXIMITY_MIGRATION

- **命名空间:** `NETWORK`
- **Hash:** `0x407091CF6037118E`
- **JHash:** `0x9F82917F`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_DISABLE_PROXIMITY_MIGRATION(int netID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netID` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_DISABLE_REALTIME_MULTIPLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0x236905C700FDB54D`
- **Build:** `2612`

**C# 签名:**
```csharp
void NETWORK_DISABLE_REALTIME_MULTIPLAYER()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_DISABLE_VOICE_BANDWIDTH_RESTRICTION

- **命名空间:** `NETWORK`
- **Hash:** `0xCA575C391FEA25CC`
- **JHash:** `0xE797A4B6`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_DISABLE_VOICE_BANDWIDTH_RESTRICTION(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_DISPLAYNAMES_FROM_HANDLES_START

- **命名空间:** `NETWORK`
- **Hash:** `0xD66C9E72B3CC4982`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_DISPLAYNAMES_FROM_HANDLES_START(ref object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Hardcoded to return -1.
```

---

### NETWORK_DOES_ENTITY_EXIST_WITH_NETWORK_ID

- **命名空间:** `NETWORK`
- **Hash:** `0x18A47D074708FD68`
- **JHash:** `0x1E2E3177`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_DOES_ENTITY_EXIST_WITH_NETWORK_ID(int netId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_DOES_NETWORK_ID_EXIST

- **命名空间:** `NETWORK`
- **Hash:** `0x38CE16C96BD11344`
- **JHash:** `0xB8D2C99E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_DOES_NETWORK_ID_EXIST(int netId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_DOES_TUNABLE_EXIST

- **命名空间:** `NETWORK`
- **Hash:** `0x85E5F8B9B898B20A`
- **JHash:** `0x9FCE9C9A`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_DOES_TUNABLE_EXIST(string tunableContext, string tunableName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `tunableContext` | `const char*` | `string` | - |
| `tunableName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_DOES_TUNABLE_EXIST_HASH

- **命名空间:** `NETWORK`
- **Hash:** `0xE4E53E1419D81127`
- **JHash:** `0x25915CB9`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_DOES_TUNABLE_EXIST_HASH(uint tunableContext, uint tunableName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `tunableContext` | `Hash` | `uint` | - |
| `tunableName` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_DO_TRANSITION_QUICKMATCH

- **命名空间:** `NETWORK`
- **Hash:** `0x71FB0EBCD4915D56`
- **JHash:** `0x2FF65C0B`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_DO_TRANSITION_QUICKMATCH(object p0, object p1, object p2, object p3, object p4, object p5)
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

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_DO_TRANSITION_QUICKMATCH_ASYNC

- **命名空间:** `NETWORK`
- **Hash:** `0xA091A5E44F0072E5`
- **JHash:** `0x47D61C99`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_DO_TRANSITION_QUICKMATCH_ASYNC(object p0, object p1, object p2, object p3, object p4, object p5)
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

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_DO_TRANSITION_QUICKMATCH_WITH_GROUP

- **命名空间:** `NETWORK`
- **Hash:** `0x9C4AB58491FDC98A`
- **JHash:** `0x5CE60A11`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_DO_TRANSITION_QUICKMATCH_WITH_GROUP(object p0, object p1, object p2, object p3, ref object p4, object p5, object p6, object p7)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any*` | `ref object` | - |
| `p5` | `Any` | `object` | - |
| `p6` | `Any` | `object` | - |
| `p7` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_DO_TRANSITION_TO_FREEMODE

- **命名空间:** `NETWORK`
- **Hash:** `0x3AAD8B2FCA1E289F`
- **JHash:** `0xC7CB8ADF`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_DO_TRANSITION_TO_FREEMODE(ref object p0, object p1, bool p2, int players, bool p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `BOOL` | `bool` | - |
| `players` | `int` | `int` | - |
| `p4` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p2 is true 3/4 of the occurrences I found.
'players' is the number of players for a session. On PS3/360 it's always 18. On PC it's 32.
```

---

### NETWORK_DO_TRANSITION_TO_GAME

- **命名空间:** `NETWORK`
- **Hash:** `0x3E9BB38102A589B0`
- **JHash:** `0x1B2114D2`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_DO_TRANSITION_TO_GAME(bool p0, int maxPlayers)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `maxPlayers` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_DO_TRANSITION_TO_NEW_FREEMODE

- **命名空间:** `NETWORK`
- **Hash:** `0x9E80A5BA8109F974`
- **JHash:** `0xAD13375E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_DO_TRANSITION_TO_NEW_FREEMODE(ref object p0, object p1, int players, bool p3, bool p4, bool p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any` | `object` | - |
| `players` | `int` | `int` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `BOOL` | `bool` | - |
| `p5` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_DO_TRANSITION_TO_NEW_GAME

- **命名空间:** `NETWORK`
- **Hash:** `0x4665F51EFED00034`
- **JHash:** `0x58AFBE63`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_DO_TRANSITION_TO_NEW_GAME(bool p0, int maxPlayers, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `maxPlayers` | `int` | `int` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_DUMP_NET_IF_CONFIG

- **命名空间:** `NETWORK`
- **Hash:** `0xAEDF1BC1C133D6E3`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_DUMP_NET_IF_CONFIG()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Does nothing (it's a nullsub).
```

---

### NETWORK_ENABLE_EXTRA_VEHICLE_ORIENTATION_BLEND_CHECKS

- **命名空间:** `NETWORK`
- **Hash:** `0xE6717E652B8C8D8A`
- **Build:** `617`

**C# 签名:**
```csharp
void NETWORK_ENABLE_EXTRA_VEHICLE_ORIENTATION_BLEND_CHECKS(int netId, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_ENABLE_VOICE_BANDWIDTH_RESTRICTION

- **命名空间:** `NETWORK`
- **Hash:** `0x5E3AA4CA2B6FB0EE`
- **JHash:** `0x7BBEA8CF`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_ENABLE_VOICE_BANDWIDTH_RESTRICTION(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_END_TUTORIAL_SESSION

- **命名空间:** `NETWORK`
- **Hash:** `0xD0AFAFF5A51D72F7`
- **JHash:** `0xBA57E53E`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_END_TUTORIAL_SESSION()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_ENTITY_AREA_DOES_EXIST

- **命名空间:** `NETWORK`
- **Hash:** `0xE64A3CA08DFA37A9`
- **JHash:** `0x69956127`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_ENTITY_AREA_DOES_EXIST(int areaHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `areaHandle` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ENTITY_AREA_HAVE_ALL_REPLIED

- **命名空间:** `NETWORK`
- **Hash:** `0x4DF7CFFF471A7FB1`
- **JHash:** `0xCB1CD6D3`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_ENTITY_AREA_HAVE_ALL_REPLIED(int areaHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `areaHandle` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ENTITY_AREA_IS_OCCUPIED

- **命名空间:** `NETWORK`
- **Hash:** `0x4A2D4E8BF4265B0F`
- **JHash:** `0xC6D53AA0`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_ENTITY_AREA_IS_OCCUPIED(int areaHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `areaHandle` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ENTITY_GET_OBJECT_ID

- **命名空间:** `NETWORK`
- **Hash:** `0x815F18AD865F057F`
- **Build:** `463`

**C# 签名:**
```csharp
int NETWORK_ENTITY_GET_OBJECT_ID(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_ENTITY_USE_HIGH_PRECISION_ROTATION

- **命名空间:** `NETWORK`
- **Hash:** `0x95BAF97C82464629`
- **Build:** `1604`

**C# 签名:**
```csharp
void NETWORK_ENTITY_USE_HIGH_PRECISION_ROTATION(int netId, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EXPLODE_HELI

- **命名空间:** `NETWORK`
- **Hash:** `0x2A5E0621DD815A9A`
- **JHash:** `0x955B31BF`
- **Build:** `463`

**C# 签名:**
```csharp
void NETWORK_EXPLODE_HELI(int vehicle, bool isAudible, bool isInvisible, int netId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `isAudible` | `BOOL` | `bool` | - |
| `isInvisible` | `BOOL` | `bool` | - |
| `netId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EXPLODE_VEHICLE

- **命名空间:** `NETWORK`
- **Hash:** `0x301A42153C9AD707`
- **JHash:** `0x0E1B38AE`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_EXPLODE_VEHICLE(int vehicle, bool isAudible, bool isInvisible, int netId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `isAudible` | `BOOL` | `bool` | - |
| `isInvisible` | `BOOL` | `bool` | - |
| `netId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
In the console script dumps, this is only referenced once. 
NETWORK::NETWORK_EXPLODE_VEHICLE(vehicle, 1, 0, 0);

^^^^^ That must be PC script dumps? In X360 Script Dumps it is reference a few times with 2 differences in the parameters.
Which as you see below is 1, 0, 0 + 1, 1, 0 + 1, 0, and a *param?

am_plane_takedown.c 
network_explode_vehicle(net_to_veh(Local_40.imm_2), 1, 1, 0);

armenian2.c 
network_explode_vehicle(Local_80[6 <2>], 1, 0, 0);

fm_horde_controler.c
network_explode_vehicle(net_to_veh(*uParam0), 1, 0, *uParam0);

fm_mission_controller.c, has 6 hits so not going to list them.

Side note, setting the first parameter to 0 seems to mute sound or so?

Seems it's like ADD_EXPLOSION, etc. the first 2 params. The 3rd atm no need to worry since it always seems to be 0.

```

---

### NETWORK_FADE_IN_ENTITY

- **命名空间:** `NETWORK`
- **Hash:** `0x1F4ED342ACEFE62D`
- **JHash:** `0x9B9FCD02`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_FADE_IN_ENTITY(int entity, bool state, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `state` | `BOOL` | `bool` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
state - 0 does 5 fades
state - 1 does 6 fades

p3: setting to 1 made vehicle fade in slower, probably "slow" as per NETWORK_FADE_OUT_ENTITY
```

---

### NETWORK_FADE_OUT_ENTITY

- **命名空间:** `NETWORK`
- **Hash:** `0xDE564951F95E09ED`
- **JHash:** `0x47EDEE56`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_FADE_OUT_ENTITY(int entity, bool normal, bool slow)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `normal` | `BOOL` | `bool` | - |
| `slow` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
normal - transition like when your coming out of LSC
slow - transition like when you walk into a mission
 
```

---

### NETWORK_FIND_GAMERS_IN_CREW

- **命名空间:** `NETWORK`
- **Hash:** `0xE532D6811B3A4D2A`
- **JHash:** `0x7771AB83`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_FIND_GAMERS_IN_CREW(int crewId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `crewId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_FIND_LARGEST_BUNCH_OF_PLAYERS

- **命名空间:** `NETWORK`
- **Hash:** `0xFB1F9381E80FA13F`
- **JHash:** `0x0679CE71`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_FIND_LARGEST_BUNCH_OF_PLAYERS(int p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p0 is always 0. p1 is pointing to a global.
```

---

### NETWORK_FIND_MATCHED_GAMERS

- **命名空间:** `NETWORK`
- **Hash:** `0xF7B2CFDE5C9F700D`
- **JHash:** `0xA13045D4`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_FIND_MATCHED_GAMERS(int attribute, float fallbackLimit, float lowerLimit, float upperLimit)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `attribute` | `int` | `int` | - |
| `fallbackLimit` | `float` | `float` | - |
| `lowerLimit` | `float` | `float` | - |
| `upperLimit` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Uses attributes to find players with similar stats. Upper/Lower limit must be above zero or the fallback limit +/-0.1 is used.
There can be up to 15 attributes, they are as follows:

0 = Races
1 = Parachuting
2 = Horde
3 = Darts
4 = Arm Wrestling
5 = Tennis
6 = Golf
7 = Shooting Range
8 = Deathmatch
9 = MPPLY_MCMWIN/MPPLY_CRMISSION
```

---

### NETWORK_FINISH_BROADCASTING_DATA

- **命名空间:** `NETWORK`
- **Hash:** `0x64F62AFB081E260D`
- **JHash:** `0xA71A1D2A`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_FINISH_BROADCASTING_DATA()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_FORCE_LOCAL_PLAYER_SCAR_SYNC

- **命名空间:** `NETWORK`
- **Hash:** `0xB7C7F6AD6424304B`
- **JHash:** `0x371BBA08`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_FORCE_LOCAL_PLAYER_SCAR_SYNC()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
NETWORK_F[I-O]
```

---

### NETWORK_FORCE_LOCAL_USE_OF_SYNCED_SCENE_CAMERA

- **命名空间:** `NETWORK`
- **Hash:** `0xC9B43A33D09CADA7`
- **JHash:** `0xC3AA2EC7`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_FORCE_LOCAL_USE_OF_SYNCED_SCENE_CAMERA(int netScene)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netScene` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_GAMERTAG_FROM_HANDLE_PENDING

- **命名空间:** `NETWORK`
- **Hash:** `0xB071E27958EF4CF0`
- **JHash:** `0xF000828E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GAMERTAG_FROM_HANDLE_PENDING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GAMERTAG_FROM_HANDLE_START

- **命名空间:** `NETWORK`
- **Hash:** `0x9F0C0A981D73FA56`
- **JHash:** `0xEBA00C2A`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GAMERTAG_FROM_HANDLE_START(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GAMERTAG_FROM_HANDLE_SUCCEEDED

- **命名空间:** `NETWORK`
- **Hash:** `0xFD00798DBA7523DD`
- **JHash:** `0x89C2B5EA`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GAMERTAG_FROM_HANDLE_SUCCEEDED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GAMER_HAS_HEADSET

- **命名空间:** `NETWORK`
- **Hash:** `0xF2FD55CB574BCC55`
- **JHash:** `0xD036DA4A`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GAMER_HAS_HEADSET(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_ACTIVITY_PLAYER_NUM

- **命名空间:** `NETWORK`
- **Hash:** `0x73E2B500410DA5A2`
- **JHash:** `0x31F951FD`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_ACTIVITY_PLAYER_NUM(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_AGE_GROUP

- **命名空间:** `NETWORK`
- **Hash:** `0x9614B71F8ADB982B`
- **JHash:** `0xAB07CBBE`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_AGE_GROUP()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_ASSISTED_DAMAGE_OF_ENTITY

- **命名空间:** `NETWORK`
- **Hash:** `0x4CACA84440FA26F6`
- **JHash:** `0x28A45454`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_ASSISTED_DAMAGE_OF_ENTITY(int player, int entity, ref int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `entity` | `Entity` | `int` | - |
| `p2` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_ASSISTED_KILL_OF_ENTITY

- **命名空间:** `NETWORK`
- **Hash:** `0x83660B734994124D`
- **Build:** `463`

**C# 签名:**
```csharp
bool NETWORK_GET_ASSISTED_KILL_OF_ENTITY(int player, int entity, ref int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `entity` | `Entity` | `int` | - |
| `p2` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
NETWORK_GET_ASSISTED_DAMAGE_OF_ENTITY that ensures the entity is dead (IS_ENTITY_DEAD)
```

---

### NETWORK_GET_AVERAGE_LATENCY

- **命名空间:** `NETWORK`
- **Hash:** `0xD414BE129BB81B32`
- **Build:** `323`

**C# 签名:**
```csharp
float NETWORK_GET_AVERAGE_LATENCY(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### NETWORK_GET_AVERAGE_PACKET_LOSS

- **命名空间:** `NETWORK`
- **Hash:** `0x350C23949E43686C`
- **Build:** `323`

**C# 签名:**
```csharp
float NETWORK_GET_AVERAGE_PACKET_LOSS(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### NETWORK_GET_AVERAGE_PING

- **命名空间:** `NETWORK`
- **Hash:** `0x0E3A041ED6AC2B45`
- **Build:** `323`

**C# 签名:**
```csharp
float NETWORK_GET_AVERAGE_PING(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Same as NETWORK_GET_AVERAGE_LATENCY
```

---

### NETWORK_GET_BONE_ID_OF_FATAL_HIT

- **命名空间:** `NETWORK`
- **Hash:** `0x7DB53B37A2F211A0`
- **JHash:** `0x053BB329`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_BONE_ID_OF_FATAL_HIT()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_CONTENT_MODIFIER_LIST_ID

- **命名空间:** `NETWORK`
- **Hash:** `0x187382F8A3E0A6C3`
- **JHash:** `0xA78571CA`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_CONTENT_MODIFIER_LIST_ID(uint contentHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `contentHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Return the content modifier id (the tunables context if you want) of a specific content.

It takes the content hash (which is the mission id hash), and return the content modifier id, used as the tunables context.

The mission id can be found on the Social club, for example, 'socialclub.rockstargames.com/games/gtav/jobs/job/A8M6Bz8MLEC5xngvDCzGwA'

'A8M6Bz8MLEC5xngvDCzGwA' is the mission id, so the game hash this and use it as the parameter for this native.

```

---

### NETWORK_GET_CURRENTLY_SELECTED_GAMER_HANDLE_FROM_INVITE_MENU

- **命名空间:** `NETWORK`
- **Hash:** `0x74881E6BCAE2327C`
- **JHash:** `0x72BA00CE`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_CURRENTLY_SELECTED_GAMER_HANDLE_FROM_INVITE_MENU(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_DESTROYER_OF_ENTITY

- **命名空间:** `NETWORK`
- **Hash:** `0xC434133D9BA52777`
- **Build:** `463`

**C# 签名:**
```csharp
int NETWORK_GET_DESTROYER_OF_ENTITY(int entity, Hash* weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `weaponHash` | `Hash*` | `Hash*` | - |

**返回值:** `int` (Native: `Player`)

---

### NETWORK_GET_DESTROYER_OF_NETWORK_ID

- **命名空间:** `NETWORK`
- **Hash:** `0x7A1ADEEF01740A24`
- **JHash:** `0x4FCA6436`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_DESTROYER_OF_NETWORK_ID(int netId, Hash* weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |
| `weaponHash` | `Hash*` | `Hash*` | - |

**返回值:** `int` (Native: `Player`)

---

### NETWORK_GET_DISPLAYNAMES_FROM_HANDLES

- **命名空间:** `NETWORK`
- **Hash:** `0x58CC181719256197`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_DISPLAYNAMES_FROM_HANDLES(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
This function is hard-coded to always return 0.
```

---

### NETWORK_GET_ENTITY_FROM_NETWORK_ID

- **命名空间:** `NETWORK`
- **Hash:** `0xCE4E5D9B0A4FF560`
- **JHash:** `0x5B912C3F`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_ENTITY_FROM_NETWORK_ID(int netId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |

**返回值:** `int` (Native: `Entity`)

---

### NETWORK_GET_ENTITY_FROM_OBJECT_ID

- **命名空间:** `NETWORK`
- **Hash:** `0x37D5F739FD494675`
- **Build:** `505`

**C# 签名:**
```csharp
int NETWORK_GET_ENTITY_FROM_OBJECT_ID(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `int` (Native: `Entity`)

**说明:**
```
I've had this return the player's ped handle sometimes, but also other random entities.
Whatever p0 is, it's at least not synced to other players.
At least not all the time, some p0 values actually output the same entity, (different handle of course, but same entity).
But another p0 value may return an entity for player x, but not for player y (it'll just return -1 even if the entity exists on both clients).

Returns an entity handle or -1, value changes based on p0's value.
```

---

### NETWORK_GET_ENTITY_IS_LOCAL

- **命名空间:** `NETWORK`
- **Hash:** `0x0991549DE4D64762`
- **JHash:** `0x813353ED`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_ENTITY_IS_LOCAL(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_ENTITY_IS_NETWORKED

- **命名空间:** `NETWORK`
- **Hash:** `0xC7827959479DCC78`
- **JHash:** `0xD7F934F4`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_ENTITY_IS_NETWORKED(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_ENTITY_KILLER_OF_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0x42B2DAA6B596F5F8`
- **JHash:** `0xA7E7E04F`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_ENTITY_KILLER_OF_PLAYER(int player, Hash* weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `weaponHash` | `Hash*` | `Hash*` | - |

**返回值:** `int` (Native: `Entity`)

---

### NETWORK_GET_FOUND_GAMER

- **命名空间:** `NETWORK`
- **Hash:** `0x9DCFF2AFB68B3476`
- **JHash:** `0xA08C9141`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_FOUND_GAMER(ref object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_FRIEND_COUNT

- **命名空间:** `NETWORK`
- **Hash:** `0x203F1CFD823B27A4`
- **JHash:** `0xA396ACDE`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_FRIEND_COUNT()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_FRIEND_DISPLAY_NAME

- **命名空间:** `NETWORK`
- **Hash:** `0x4164F227D052E293`
- **Build:** `323`

**C# 签名:**
```csharp
string NETWORK_GET_FRIEND_DISPLAY_NAME(int friendIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `friendIndex` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

---

### NETWORK_GET_FRIEND_NAME

- **命名空间:** `NETWORK`
- **Hash:** `0xE11EBBB2A783FE8B`
- **JHash:** `0x97420B6D`
- **Build:** `323`

**C# 签名:**
```csharp
string NETWORK_GET_FRIEND_NAME(int friendIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `friendIndex` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

---

### NETWORK_GET_GAMERTAG_FROM_HANDLE

- **命名空间:** `NETWORK`
- **Hash:** `0x426141162EBE5CDB`
- **JHash:** `0xA18A1B26`
- **Build:** `323`

**C# 签名:**
```csharp
string NETWORK_GET_GAMERTAG_FROM_HANDLE(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `string` (Native: `const char*`)

---

### NETWORK_GET_GAMER_STATUS_FROM_QUEUE

- **命名空间:** `NETWORK`
- **Hash:** `0x2CC848A861D01493`
- **JHash:** `0xBEB98840`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_GAMER_STATUS_FROM_QUEUE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_GAMER_STATUS_RESULT

- **命名空间:** `NETWORK`
- **Hash:** `0x02A8BEC6FD9AF660`
- **JHash:** `0xB5ABC4B4`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_GAMER_STATUS_RESULT(ref object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_GAME_MODE

- **命名空间:** `NETWORK`
- **Hash:** `0x4C9034162368E206`
- **Build:** `2060`

**C# 签名:**
```csharp
int NETWORK_GET_GAME_MODE()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_GLOBAL_MULTIPLAYER_CLOCK

- **命名空间:** `NETWORK`
- **Hash:** `0x6D03BFBD643B2A02`
- **JHash:** `0x74E8C53E`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_GET_GLOBAL_MULTIPLAYER_CLOCK(ref int hours, ref int minutes, ref int seconds)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `hours` | `int*` | `ref int` | - |
| `minutes` | `int*` | `ref int` | - |
| `seconds` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_GET_HIGHEST_RELIABLE_RESEND_COUNT

- **命名空间:** `NETWORK`
- **Hash:** `0x52C1EADAF7B10302`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_HIGHEST_RELIABLE_RESEND_COUNT(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_HOST_OF_SCRIPT

- **命名空间:** `NETWORK`
- **Hash:** `0x1D6A14F1F9A736FC`
- **JHash:** `0x9C95D0BB`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_HOST_OF_SCRIPT(string scriptName, int instance_id, int position_hash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scriptName` | `const char*` | `string` | - |
| `instance_id` | `int` | `int` | - |
| `position_hash` | `int` | `int` | - |

**返回值:** `int` (Native: `Player`)

**说明:**
```
scriptName examples:
"freemode", "AM_CR_SecurityVan", ...

Most of the time, these values are used:
instance_id = -1
position_hash = 0
```

---

### NETWORK_GET_HOST_OF_THIS_SCRIPT

- **命名空间:** `NETWORK`
- **Hash:** `0xC7B4D79B01FA7A5C`
- **JHash:** `0x89EA7B54`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_HOST_OF_THIS_SCRIPT()
```

**返回值:** `int` (Native: `Player`)

---

### NETWORK_GET_HOST_OF_THREAD

- **命名空间:** `NETWORK`
- **Hash:** `0xD3DEBE2991FE8098`
- **Build:** `3717`

**C# 签名:**
```csharp
int NETWORK_GET_HOST_OF_THREAD(int threadId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `threadId` | `int` | `int` | - |

**返回值:** `int` (Native: `Player`)

---

### NETWORK_GET_HOST_PLAYER_INDEX

- **命名空间:** `NETWORK`
- **Hash:** `0x8251FB94DC4FDFC8`
- **Build:** `2612`

**C# 签名:**
```csharp
int NETWORK_GET_HOST_PLAYER_INDEX()
```

**返回值:** `int` (Native: `Player`)

---

### NETWORK_GET_INSTANCE_ID_OF_THIS_SCRIPT

- **命名空间:** `NETWORK`
- **Hash:** `0x638A3A81733086DB`
- **JHash:** `0xDB8B5D71`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_INSTANCE_ID_OF_THIS_SCRIPT()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_INVITE_REPLY_STATUS

- **命名空间:** `NETWORK`
- **Hash:** `0x3855FB5EB2C5E8B2`
- **Build:** `505`

**C# 签名:**
```csharp
int NETWORK_GET_INVITE_REPLY_STATUS(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_KILLER_OF_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0x2DA41ED6E1FCD7A5`
- **Build:** `463`

**C# 签名:**
```csharp
int NETWORK_GET_KILLER_OF_PLAYER(int player, Hash* weaponHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `weaponHash` | `Hash*` | `Hash*` | - |

**返回值:** `int` (Native: `Player`)

---

### NETWORK_GET_LAST_ENTITY_POS_RECEIVED_OVER_NETWORK

- **命名空间:** `NETWORK`
- **Hash:** `0x64D779659BC37B19`
- **Build:** `393`

**C# 签名:**
```csharp
Vector3 NETWORK_GET_LAST_ENTITY_POS_RECEIVED_OVER_NETWORK(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

---

### NETWORK_GET_LAST_PLAYER_POS_RECEIVED_OVER_NETWORK

- **命名空间:** `NETWORK`
- **Hash:** `0x125E6D638B8605D4`
- **Build:** `393`

**C# 签名:**
```csharp
Vector3 NETWORK_GET_LAST_PLAYER_POS_RECEIVED_OVER_NETWORK(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
Returns the coordinates of another player.
Does not work if you enter your own player id as p0 (will return `(0.0, 0.0, 0.0)` in that case).
```

---

### NETWORK_GET_LAST_VEL_RECEIVED_OVER_NETWORK

- **命名空间:** `NETWORK`
- **Hash:** `0x33DE49EDF4DDE77A`
- **Build:** `1103`

**C# 签名:**
```csharp
Vector3 NETWORK_GET_LAST_VEL_RECEIVED_OVER_NETWORK(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
Used by NetBlender
```

---

### NETWORK_GET_LOCAL_HANDLE

- **命名空间:** `NETWORK`
- **Hash:** `0xE86051786B66CD8E`
- **JHash:** `0x08023B16`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_GET_LOCAL_HANDLE(ref object gamerHandle, int gamerHandleSize)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |
| `gamerHandleSize` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_GET_LOCAL_SCENE_FROM_NETWORK_ID

- **命名空间:** `NETWORK`
- **Hash:** `0x02C40BF885C567B6`
- **JHash:** `0x16AED87B`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_LOCAL_SCENE_FROM_NETWORK_ID(int netId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_MAX_FRIENDS

- **命名空间:** `NETWORK`
- **Hash:** `0xAFEBB0D5D8F687D2`
- **JHash:** `0x048171BC`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_MAX_FRIENDS()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_MAX_NUM_PARTICIPANTS

- **命名空间:** `NETWORK`
- **Hash:** `0xA6C90FBC38E395EE`
- **JHash:** `0xCCD8C02D`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_MAX_NUM_PARTICIPANTS()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_MUTE_COUNT_FOR_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0xADB57E5B663CCA8B`
- **JHash:** `0x92268BB5`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_GET_MUTE_COUNT_FOR_PLAYER(int p0, ref float p1, ref float p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Player` | `int` | - |
| `p1` | `float*` | `ref float` | - |
| `p2` | `float*` | `ref float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
NETWORK_GET_M[A-U]
```

---

### NETWORK_GET_NETWORK_ID_FROM_ENTITY

- **命名空间:** `NETWORK`
- **Hash:** `0xA11700682F3AD45C`
- **JHash:** `0x9E35DAB6`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_NETWORK_ID_FROM_ENTITY(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_NET_STATISTICS_INFO

- **命名空间:** `NETWORK`
- **Hash:** `0x6FD992C4A1C1B986`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_GET_NET_STATISTICS_INFO(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Does nothing (it's a nullsub).
```

---

### NETWORK_GET_NP_UNAVAILABLE_REASON

- **命名空间:** `NETWORK`
- **Hash:** `0x74FB3E29E6D10FA9`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_NP_UNAVAILABLE_REASON()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Hardcoded to return zero.

==== PS4 specific info ====

Returns some sort of unavailable reason:
-1 = REASON_INVALID
 0 = REASON_OTHER
 1 = REASON_SYSTEM_UPDATE
 2 = REASON_GAME_UPDATE
 3 = REASON_SIGNED_OUT
 4 = REASON_AGE
 5 = REASON_CONNECTION

=================================
```

---

### NETWORK_GET_NUMBER_BODY_TRACKER_HITS

- **命名空间:** `NETWORK`
- **Hash:** `0xD38C4A6D047C019D`
- **JHash:** `0x17CBC608`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_NUMBER_BODY_TRACKER_HITS()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_NUM_CONNECTED_PLAYERS

- **命名空间:** `NETWORK`
- **Hash:** `0xA4A79DD2D9600654`
- **JHash:** `0xF7952E62`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_NUM_CONNECTED_PLAYERS()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns the amount of players connected in the current session. Only works when connected to a session/server.
```

---

### NETWORK_GET_NUM_FOUND_GAMERS

- **命名空间:** `NETWORK`
- **Hash:** `0xA1B043EE79A916FB`
- **JHash:** `0xF4B80C7E`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_NUM_FOUND_GAMERS()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_NUM_PARTICIPANTS

- **命名空间:** `NETWORK`
- **Hash:** `0x18D0456E86604654`
- **JHash:** `0x3E25A3C5`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_NUM_PARTICIPANTS()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_NUM_PRESENCE_INVITES

- **命名空间:** `NETWORK`
- **Hash:** `0xCEFA968912D0F78D`
- **JHash:** `0x3FDA00F3`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_NUM_PRESENCE_INVITES()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_NUM_SCRIPT_PARTICIPANTS

- **命名空间:** `NETWORK`
- **Hash:** `0x3658E8CD94FC121A`
- **JHash:** `0x8F7D9F46`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_NUM_SCRIPT_PARTICIPANTS(string scriptName, int instance_id, int position_hash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scriptName` | `const char*` | `string` | - |
| `instance_id` | `int` | `int` | - |
| `position_hash` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_NUM_TRANSITION_NON_ASYNC_GAMERS

- **命名空间:** `NETWORK`
- **Hash:** `0x617F49C2668E6155`
- **Build:** `757`

**C# 签名:**
```csharp
int NETWORK_GET_NUM_TRANSITION_NON_ASYNC_GAMERS()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_NUM_UNACKED_RELIABLES

- **命名空间:** `NETWORK`
- **Hash:** `0xFF8FCF9FFC458A1C`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_NUM_UNACKED_RELIABLES(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_PARTICIPANT_INDEX

- **命名空间:** `NETWORK`
- **Hash:** `0x1B84DF6AF2A46938`
- **JHash:** `0xC4D91094`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_PARTICIPANT_INDEX(int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_PLATFORM_PARTY_MEMBERS

- **命名空间:** `NETWORK`
- **Hash:** `0x120364DE2845DAF8`
- **JHash:** `0xF30E5814`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_PLATFORM_PARTY_MEMBERS(ref object data, int dataSize)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |
| `dataSize` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_PLATFORM_PARTY_MEMBER_COUNT

- **命名空间:** `NETWORK`
- **Hash:** `0x01ABCE5E7CBDA196`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_PLATFORM_PARTY_MEMBER_COUNT()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_PLAYER_ACCOUNT_ID

- **命名空间:** `NETWORK`
- **Hash:** `0xDB663CC9FF3407A9`
- **Build:** `1734`

**C# 签名:**
```csharp
int NETWORK_GET_PLAYER_ACCOUNT_ID(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_PLAYER_FROM_GAMER_HANDLE

- **命名空间:** `NETWORK`
- **Hash:** `0xCE5F689CF5A0A49D`
- **JHash:** `0x2E96EF1E`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_PLAYER_FROM_GAMER_HANDLE(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `int` (Native: `Player`)

---

### NETWORK_GET_PLAYER_INDEX

- **命名空间:** `NETWORK`
- **Hash:** `0x24FB80D107371267`
- **JHash:** `0xBE1C1506`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_PLAYER_INDEX(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `int` (Native: `Player`)

---

### NETWORK_GET_PLAYER_INDEX_FROM_PED

- **命名空间:** `NETWORK`
- **Hash:** `0x6C0E2E0125610278`
- **JHash:** `0x40DBF464`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_PLAYER_INDEX_FROM_PED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `Player`)

**说明:**
```
Returns the Player associated to a given Ped when in an online session.
```

---

### NETWORK_GET_PLAYER_LOUDNESS

- **命名空间:** `NETWORK`
- **Hash:** `0x21A1684A25C2867F`
- **JHash:** `0xF2F67014`
- **Build:** `323`

**C# 签名:**
```csharp
float NETWORK_GET_PLAYER_LOUDNESS(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### NETWORK_GET_PLAYER_OWNS_WAYPOINT

- **命名空间:** `NETWORK`
- **Hash:** `0x82377B65E943F72D`
- **JHash:** `0xB802B671`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_PLAYER_OWNS_WAYPOINT(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_PLAYER_TUTORIAL_SESSION_INSTANCE

- **命名空间:** `NETWORK`
- **Hash:** `0x3B39236746714134`
- **JHash:** `0x5E1020CC`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_PLAYER_TUTORIAL_SESSION_INSTANCE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_POSITION_HASH_OF_THIS_SCRIPT

- **命名空间:** `NETWORK`
- **Hash:** `0x257ED0FADF750BCF`
- **Build:** `2372`

**C# 签名:**
```csharp
uint NETWORK_GET_POSITION_HASH_OF_THIS_SCRIPT()
```

**返回值:** `uint` (Native: `Hash`)

---

### NETWORK_GET_PREDICTED_VELOCITY

- **命名空间:** `NETWORK`
- **Hash:** `0xAA5FAFCD2C5F5E47`
- **Build:** `1103`

**C# 签名:**
```csharp
Vector3 NETWORK_GET_PREDICTED_VELOCITY(int entity, float maxSpeedToPredict)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `maxSpeedToPredict` | `float` | `float` | - |

**返回值:** `Vector3` (Native: `Vector3`)

---

### NETWORK_GET_PRESENCE_INVITE_CONTENT_ID

- **命名空间:** `NETWORK`
- **Hash:** `0x24409FC4C55CB22D`
- **JHash:** `0xA4302183`
- **Build:** `323`

**C# 签名:**
```csharp
string NETWORK_GET_PRESENCE_INVITE_CONTENT_ID(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

---

### NETWORK_GET_PRESENCE_INVITE_FROM_ADMIN

- **命名空间:** `NETWORK`
- **Hash:** `0x3DBF2DF0AEB7D289`
- **JHash:** `0xF5E3401C`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_PRESENCE_INVITE_FROM_ADMIN(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_PRESENCE_INVITE_HANDLE

- **命名空间:** `NETWORK`
- **Hash:** `0x38D5B0FEBB086F75`
- **JHash:** `0xB2451429`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_PRESENCE_INVITE_HANDLE(object p0, ref object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_PRESENCE_INVITE_ID

- **命名空间:** `NETWORK`
- **Hash:** `0xDFF09646E12EC386`
- **JHash:** `0xD50DF46C`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_PRESENCE_INVITE_ID(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_PRESENCE_INVITE_INDEX_BY_ID

- **命名空间:** `NETWORK`
- **Hash:** `0x742B58F723233ED9`
- **JHash:** `0x5E832444`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_PRESENCE_INVITE_INDEX_BY_ID(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_PRESENCE_INVITE_INVITER

- **命名空间:** `NETWORK`
- **Hash:** `0x4962CC4AA2F345B7`
- **JHash:** `0x19EC65D9`
- **Build:** `323`

**C# 签名:**
```csharp
string NETWORK_GET_PRESENCE_INVITE_INVITER(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

---

### NETWORK_GET_PRESENCE_INVITE_IS_TOURNAMENT

- **命名空间:** `NETWORK`
- **Hash:** `0x8806CEBFABD3CE05`
- **JHash:** `0x7D593B4C`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_PRESENCE_INVITE_IS_TOURNAMENT(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_PRESENCE_INVITE_PLAYLIST_CURRENT

- **命名空间:** `NETWORK`
- **Hash:** `0x728C4CC7920CD102`
- **JHash:** `0x4677C656`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_PRESENCE_INVITE_PLAYLIST_CURRENT(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_PRESENCE_INVITE_PLAYLIST_LENGTH

- **命名空间:** `NETWORK`
- **Hash:** `0xD39B3FFF8FFDD5BF`
- **JHash:** `0x51B2D848`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_PRESENCE_INVITE_PLAYLIST_LENGTH(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_PRESENCE_INVITE_SESSION_ID

- **命名空间:** `NETWORK`
- **Hash:** `0x26E1CD96B0903D60`
- **JHash:** `0xC5E0C989`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_PRESENCE_INVITE_SESSION_ID(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_PRIMARY_CLAN_DATA_CANCEL

- **命名空间:** `NETWORK`
- **Hash:** `0x042E4B70B93E6054`
- **JHash:** `0x455DDF5C`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_GET_PRIMARY_CLAN_DATA_CANCEL()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_GET_PRIMARY_CLAN_DATA_CLEAR

- **命名空间:** `NETWORK`
- **Hash:** `0x9AA46BADAD0E27ED`
- **JHash:** `0xE22445DA`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_PRIMARY_CLAN_DATA_CLEAR()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_PRIMARY_CLAN_DATA_NEW

- **命名空间:** `NETWORK`
- **Hash:** `0xC080FF658B2E41DA`
- **JHash:** `0x9B8631EB`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_PRIMARY_CLAN_DATA_NEW(ref object p0, ref object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_PRIMARY_CLAN_DATA_PENDING

- **命名空间:** `NETWORK`
- **Hash:** `0xB5074DB804E28CE7`
- **JHash:** `0xA4EF02F3`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_PRIMARY_CLAN_DATA_PENDING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_PRIMARY_CLAN_DATA_START

- **命名空间:** `NETWORK`
- **Hash:** `0xCE86D8191B762107`
- **JHash:** `0x89DB0EC7`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_PRIMARY_CLAN_DATA_START(ref object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_PRIMARY_CLAN_DATA_SUCCESS

- **命名空间:** `NETWORK`
- **Hash:** `0x5B4F04F19376A0BA`
- **JHash:** `0x068A054E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_PRIMARY_CLAN_DATA_SUCCESS()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_RANDOM_INT

- **命名空间:** `NETWORK`
- **Hash:** `0x599E4FA1F87EB5FF`
- **JHash:** `0x208DD848`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_RANDOM_INT()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_RANDOM_INT_RANGED

- **命名空间:** `NETWORK`
- **Hash:** `0xE30CF56F1EFA5F43`
- **JHash:** `0xF9B6426D`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_RANDOM_INT_RANGED(int rangeStart, int rangeEnd)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `rangeStart` | `int` | `int` | - |
| `rangeEnd` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Same as GET_RANDOM_INT_IN_RANGE
```

---

### NETWORK_GET_RESPAWN_RESULT

- **命名空间:** `NETWORK`
- **Hash:** `0x371EA43692861CF1`
- **JHash:** `0xDDFE9FBC`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_GET_RESPAWN_RESULT(int randomInt, ref Vector3 coordinates, ref float heading)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `randomInt` | `int` | `int` | - |
| `coordinates` | `Vector3*` | `ref Vector3` | - |
| `heading` | `float*` | `ref float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Based on scripts such as in freemode.c how they call their vars vVar and fVar the 2nd and 3rd param it a Vector3 and Float, but the first is based on get_random_int_in_range..
```

---

### NETWORK_GET_RESPAWN_RESULT_FLAGS

- **命名空间:** `NETWORK`
- **Hash:** `0x6C34F1208B8923FD`
- **JHash:** `0x03287FD2`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_RESPAWN_RESULT_FLAGS(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_SCRIPT_STATUS

- **命名空间:** `NETWORK`
- **Hash:** `0x57D158647A6BFABF`
- **JHash:** `0x2BE9235A`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_SCRIPT_STATUS()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_SIGNALLING_INFO

- **命名空间:** `NETWORK`
- **Hash:** `0x2555CF7DA5473794`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_GET_SIGNALLING_INFO(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Does nothing (it's a nullsub).
```

---

### NETWORK_GET_TALKER_PROXIMITY

- **命名空间:** `NETWORK`
- **Hash:** `0x84F0F13120B4E098`
- **JHash:** `0x19991ADD`
- **Build:** `323`

**C# 签名:**
```csharp
float NETWORK_GET_TALKER_PROXIMITY()
```

**返回值:** `float` (Native: `float`)

---

### NETWORK_GET_THIS_SCRIPT_IS_NETWORK_SCRIPT

- **命名空间:** `NETWORK`
- **Hash:** `0x2910669969E9535E`
- **JHash:** `0xD9BF6549`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_THIS_SCRIPT_IS_NETWORK_SCRIPT()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_TIMEOUT_TIME

- **命名空间:** `NETWORK`
- **Hash:** `0x5ED0356A0CE3A34F`
- **JHash:** `0xE1F86C6A`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_TIMEOUT_TIME()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_TOTAL_NUM_PLAYERS

- **命名空间:** `NETWORK`
- **Hash:** `0xCF61D4B4702EE9EB`
- **JHash:** `0xF4F13B06`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_TOTAL_NUM_PLAYERS()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_TRANSITION_HOST

- **命名空间:** `NETWORK`
- **Hash:** `0x65042B9774C4435E`
- **JHash:** `0x73098D40`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_TRANSITION_HOST(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_TRANSITION_MEMBERS

- **命名空间:** `NETWORK`
- **Hash:** `0x73B000F7FBC55829`
- **JHash:** `0x31F19263`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_TRANSITION_MEMBERS(ref object data, int dataCount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |
| `dataCount` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns count.
```

---

### NETWORK_GET_TUNABLE_CLOUD_CRC

- **命名空间:** `NETWORK`
- **Hash:** `0x10BD227A753B0D84`
- **JHash:** `0x231CFD12`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_TUNABLE_CLOUD_CRC()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Actually returns the version (TUNABLE_VERSION)
```

---

### NETWORK_GET_UNRELIABLE_RESEND_COUNT

- **命名空间:** `NETWORK`
- **Hash:** `0x3765C3A3E8192E10`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_UNRELIABLE_RESEND_COUNT(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_HANDLE_FROM_FRIEND

- **命名空间:** `NETWORK`
- **Hash:** `0xD45CB817D7E177D2`
- **JHash:** `0x3B0BB3A3`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_HANDLE_FROM_FRIEND(int friendIndex, ref object gamerHandle, int gamerHandleSize)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `friendIndex` | `int` | `int` | - |
| `gamerHandle` | `Any*` | `ref object` | - |
| `gamerHandleSize` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_HANDLE_FROM_MEMBER_ID

- **命名空间:** `NETWORK`
- **Hash:** `0xA0FD21BED61E5C4C`
- **JHash:** `0x9BFC9FE2`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_HANDLE_FROM_MEMBER_ID(string memberId, ref object gamerHandle, int gamerHandleSize)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `memberId` | `const char*` | `string` | - |
| `gamerHandle` | `Any*` | `ref object` | - |
| `gamerHandleSize` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_HANDLE_FROM_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0x388EB2B86C73B6B3`
- **JHash:** `0xD3498917`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_HANDLE_FROM_PLAYER(int player, ref object gamerHandle, int gamerHandleSize)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `gamerHandle` | `Any*` | `ref object` | - |
| `gamerHandleSize` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_HANDLE_FROM_USER_ID

- **命名空间:** `NETWORK`
- **Hash:** `0xDCD51DD8F87AEC5C`
- **JHash:** `0x74C2C1B7`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_HANDLE_FROM_USER_ID(string userId, ref object gamerHandle, int gamerHandleSize)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `userId` | `const char*` | `string` | - |
| `gamerHandle` | `Any*` | `ref object` | - |
| `gamerHandleSize` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_HASH_FROM_GAMER_HANDLE

- **命名空间:** `NETWORK`
- **Hash:** `0x58575AC3CF2CA8EC`
- **JHash:** `0x5AC9F04D`
- **Build:** `323`

**C# 签名:**
```csharp
uint NETWORK_HASH_FROM_GAMER_HANDLE(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `uint` (Native: `Hash`)

---

### NETWORK_HASH_FROM_PLAYER_HANDLE

- **命名空间:** `NETWORK`
- **Hash:** `0xBC1D768F2F5D6C05`
- **JHash:** `0xF8D7AF3B`
- **Build:** `323`

**C# 签名:**
```csharp
uint NETWORK_HASH_FROM_PLAYER_HANDLE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `uint` (Native: `Hash`)

---

### NETWORK_HAS_AGE_RESTRICTIONS

- **命名空间:** `NETWORK`
- **Hash:** `0x1353F87E89946207`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_AGE_RESTRICTIONS()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_AUTOMUTE_OVERRIDE

- **命名空间:** `NETWORK`
- **Hash:** `0x26F07DD83A5F7F98`
- **JHash:** `0x9A176B6E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_AUTOMUTE_OVERRIDE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_BONE_BEEN_HIT_BY_KILLER

- **命名空间:** `NETWORK`
- **Hash:** `0x2E0BF682CC778D49`
- **JHash:** `0xBFAA349B`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_BONE_BEEN_HIT_BY_KILLER(int boneIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `boneIndex` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_CACHED_PLAYER_HEAD_BLEND_DATA

- **命名空间:** `NETWORK`
- **Hash:** `0x237D5336A9A54108`
- **JHash:** `0x7B2A0337`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_CACHED_PLAYER_HEAD_BLEND_DATA(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_CONFIRMED_INVITE

- **命名空间:** `NETWORK`
- **Hash:** `0xC42DD763159F3461`
- **JHash:** `0xFBBAC350`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_CONFIRMED_INVITE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_CONTROL_OF_DOOR

- **命名空间:** `NETWORK`
- **Hash:** `0xCB3C68ADB06195DF`
- **JHash:** `0x136326EC`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_CONTROL_OF_DOOR(uint doorHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `doorHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_CONTROL_OF_ENTITY

- **命名空间:** `NETWORK`
- **Hash:** `0x01BF60A500E28887`
- **JHash:** `0x005FD797`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_CONTROL_OF_ENTITY(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_CONTROL_OF_NETWORK_ID

- **命名空间:** `NETWORK`
- **Hash:** `0x4D36070FE0215186`
- **JHash:** `0x92E77D21`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_CONTROL_OF_NETWORK_ID(int netId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_CONTROL_OF_PICKUP

- **命名空间:** `NETWORK`
- **Hash:** `0x5BC9495F0B3B6FA6`
- **JHash:** `0xF7784FC8`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_CONTROL_OF_PICKUP(int pickup)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pickup` | `Pickup` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_ENTITY_BEEN_REGISTERED_WITH_THIS_THREAD

- **命名空间:** `NETWORK`
- **Hash:** `0xB07D3185E11657A5`
- **JHash:** `0xEDA68956`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_ENTITY_BEEN_REGISTERED_WITH_THIS_THREAD(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_FOLLOW_INVITE

- **命名空间:** `NETWORK`
- **Hash:** `0x76D9B976C4C09FDE`
- **JHash:** `0xE96CFE7D`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_FOLLOW_INVITE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_HEADSET

- **命名空间:** `NETWORK`
- **Hash:** `0xE870F9F1F7B4F1FA`
- **JHash:** `0xA7DC5657`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_HEADSET()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_INVITED_GAMER

- **命名空间:** `NETWORK`
- **Hash:** `0x4D86CD31E8976ECE`
- **JHash:** `0xEC651BC0`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_INVITED_GAMER(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_INVITED_GAMER_TO_TRANSITION

- **命名空间:** `NETWORK`
- **Hash:** `0x7284A47B3540E6CF`
- **JHash:** `0x4F41DF6B`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_INVITED_GAMER_TO_TRANSITION(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_MADE_INVITE_DECISION

- **命名空间:** `NETWORK`
- **Hash:** `0x71DC455F5CD1C2B1`
- **Build:** `505`

**C# 签名:**
```csharp
bool NETWORK_HAS_MADE_INVITE_DECISION(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_PENDING_INVITE

- **命名空间:** `NETWORK`
- **Hash:** `0xAC8C7B9B88C4A668`
- **JHash:** `0x0C207D6E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_PENDING_INVITE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_PLAYER_STARTED_TRANSITION

- **命名空间:** `NETWORK`
- **Hash:** `0x9AC9CCBFA8C29795`
- **JHash:** `0x4ABD1E59`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_PLAYER_STARTED_TRANSITION(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_RECEIVED_HOST_BROADCAST_DATA

- **命名空间:** `NETWORK`
- **Hash:** `0x5D10B3795F3FC886`
- **JHash:** `0x0B739F53`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_RECEIVED_HOST_BROADCAST_DATA()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_ROS_PRIVILEGE

- **命名空间:** `NETWORK`
- **Hash:** `0xA699957E60D80214`
- **JHash:** `0xFD261E30`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_ROS_PRIVILEGE(int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
index is always 18 in scripts
```

---

### NETWORK_HAS_ROS_PRIVILEGE_END_DATE

- **命名空间:** `NETWORK`
- **Hash:** `0xC22912B1D85F26B1`
- **JHash:** `0x8570DD34`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_ROS_PRIVILEGE_END_DATE(int privilege, ref int banType, ref object timeData)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `privilege` | `int` | `int` | - |
| `banType` | `int*` | `ref int` | - |
| `timeData` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_ROS_PRIVILEGE_PLAYED_LAST_GEN

- **命名空间:** `NETWORK`
- **Hash:** `0x593570C289A77688`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_ROS_PRIVILEGE_PLAYED_LAST_GEN()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_ROS_PRIVILEGE_SPECIAL_EDITION_CONTENT

- **命名空间:** `NETWORK`
- **Hash:** `0x91B87C55093DE351`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_ROS_PRIVILEGE_SPECIAL_EDITION_CONTENT()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_SC_MEMBERSHIP

- **命名空间:** `NETWORK`
- **Hash:** `0xAB286B2192A71E32`
- **Build:** `3717`

**C# 签名:**
```csharp
bool NETWORK_HAS_SC_MEMBERSHIP()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_SOCIAL_CLUB_ACCOUNT

- **命名空间:** `NETWORK`
- **Hash:** `0x67A5589628E0CFF6`
- **JHash:** `0x66EC713F`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_SOCIAL_CLUB_ACCOUNT()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_SOCIAL_NETWORKING_SHARING_PRIV

- **命名空间:** `NETWORK`
- **Hash:** `0x76BF03FADBF154F5`
- **JHash:** `0xEB864288`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_SOCIAL_NETWORKING_SHARING_PRIV()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_TRANSITION_INVITE_BEEN_ACKED

- **命名空间:** `NETWORK`
- **Hash:** `0x3F9990BF5F22759C`
- **JHash:** `0x00F26CDC`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_TRANSITION_INVITE_BEEN_ACKED(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAS_VALID_ROS_CREDENTIALS

- **命名空间:** `NETWORK`
- **Hash:** `0x85443FF4C328F53B`
- **JHash:** `0x3FB40673`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_VALID_ROS_CREDENTIALS()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns whether the signed-in user has valid Rockstar Online Services (ROS) credentials.
```

---

### NETWORK_HAS_VIEW_GAMER_USER_CONTENT_RESULT

- **命名空间:** `NETWORK`
- **Hash:** `0xCCA4318E1AB03F1F`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAS_VIEW_GAMER_USER_CONTENT_RESULT(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAVE_COMMUNICATION_PRIVILEGES

- **命名空间:** `NETWORK`
- **Hash:** `0xAEEF48CDF5B6CE7C`
- **JHash:** `0x2D817A5E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAVE_COMMUNICATION_PRIVILEGES(int p0, int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAVE_ONLINE_PRIVILEGES

- **命名空间:** `NETWORK`
- **Hash:** `0x25CB5A9F37BFD063`
- **JHash:** `0xEF63BFDF`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAVE_ONLINE_PRIVILEGES()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAVE_PLATFORM_SUBSCRIPTION

- **命名空间:** `NETWORK`
- **Hash:** `0x5EA784D197556507`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAVE_PLATFORM_SUBSCRIPTION()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAVE_ROS_BANNED_PRIV

- **命名空间:** `NETWORK`
- **Hash:** `0x8020A73847E0CA7D`
- **JHash:** `0xD3BBE42F`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAVE_ROS_BANNED_PRIV()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAVE_ROS_CREATE_TICKET_PRIV

- **命名空间:** `NETWORK`
- **Hash:** `0xA0AD7E2AF5349F61`
- **JHash:** `0xBDBB5948`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAVE_ROS_CREATE_TICKET_PRIV()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAVE_ROS_LEADERBOARD_WRITE_PRIV

- **命名空间:** `NETWORK`
- **Hash:** `0x422D396F80A96547`
- **JHash:** `0xC6EA802E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAVE_ROS_LEADERBOARD_WRITE_PRIV()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAVE_ROS_MULTIPLAYER_PRIV

- **命名空间:** `NETWORK`
- **Hash:** `0x5F91D5D0B36AA310`
- **JHash:** `0x97287D68`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAVE_ROS_MULTIPLAYER_PRIV()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAVE_ROS_SOCIAL_CLUB_PRIV

- **命名空间:** `NETWORK`
- **Hash:** `0x606E4D3E3CCCF3EB`
- **JHash:** `0x424C6E27`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAVE_ROS_SOCIAL_CLUB_PRIV()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAVE_SCS_PRIVATE_MSG_PRIV

- **命名空间:** `NETWORK`
- **Hash:** `0x66B59CFFD78467AF`
- **JHash:** `0x0CA1167F`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAVE_SCS_PRIVATE_MSG_PRIV()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HAVE_USER_CONTENT_PRIVILEGES

- **命名空间:** `NETWORK`
- **Hash:** `0x72D918C99BCACC54`
- **JHash:** `0x1F88819D`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HAVE_USER_CONTENT_PRIVILEGES(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_HIDE_PROJECTILE_IN_CUTSCENE

- **命名空间:** `NETWORK`
- **Hash:** `0xFAC18E7356BD3210`
- **Build:** `1180`

**C# 签名:**
```csharp
void NETWORK_HIDE_PROJECTILE_IN_CUTSCENE()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_HOST_TRANSITION

- **命名空间:** `NETWORK`
- **Hash:** `0xA60BB5CE242BB254`
- **JHash:** `0x146764FB`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_HOST_TRANSITION(int p0, int p1, int p2, int p3, object p4, bool p5, bool p6, int p7, object p8, int p9)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `int` | `int` | - |
| `p3` | `int` | `int` | - |
| `p4` | `Any` | `object` | - |
| `p5` | `BOOL` | `bool` | - |
| `p6` | `BOOL` | `bool` | - |
| `p7` | `int` | `int` | - |
| `p8` | `Any` | `object` | - |
| `p9` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p0: Unknown int
p1: Unknown int
p2: Unknown int
p3: Unknown int
p4: Unknown always 0 in decompiled scripts
p5: BOOL purpose unknown, both 0 and 1 are used in decompiled scripts.
p6: BOOL purpose unknown, both 0 and 1 are used in decompiled scripts.
p7: Unknown int, it's an int according to decompiled scripts, however the value is always 0 or 1.
p8: Unknown int, it's an int according to decompiled scripts, however the value is always 0 or 1.
p9: Unknown int, sometimes 0, but also 32768 or 16384 appear in decompiled scripst, maybe a flag of some sort?

From what I can tell it looks like it does the following:
Creates/hosts a new transition to another online session, using this in FiveM will result in other players being disconencted from the server/preventing them from joining. This is most likely because I entered the wrong session parameters since they're pretty much all unknown right now.
You also need to use `NetworkJoinTransition(Player player)` and `NetworkLaunchTransition()`.
```

---

### NETWORK_IGNORE_REMOTE_WAYPOINTS

- **命名空间:** `NETWORK`
- **Hash:** `0x4C2A9FDC22377075`
- **Build:** `372`

**C# 签名:**
```csharp
void NETWORK_IGNORE_REMOTE_WAYPOINTS()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_INVITE_GAMERS

- **命名空间:** `NETWORK`
- **Hash:** `0x9D80CD1D0E6327DE`
- **JHash:** `0x52FB8074`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_INVITE_GAMERS(ref object p0, object p1, ref object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any*` | `ref object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_INVITE_GAMERS_TO_TRANSITION

- **命名空间:** `NETWORK`
- **Hash:** `0x4A595C32F77DFF76`
- **JHash:** `0x5332E645`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_INVITE_GAMERS_TO_TRANSITION(ref object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_ACTIVITY_SESSION

- **命名空间:** `NETWORK`
- **Hash:** `0x05095437424397FA`
- **JHash:** `0x577DAA8A`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_ACTIVITY_SESSION()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_ACTIVITY_SPECTATOR

- **命名空间:** `NETWORK`
- **Hash:** `0x12103B9E0C9F92FB`
- **JHash:** `0xAF329720`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_ACTIVITY_SPECTATOR()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_ACTIVITY_SPECTATOR_FROM_HANDLE

- **命名空间:** `NETWORK`
- **Hash:** `0x2763BBAA72A7BCB9`
- **JHash:** `0x58F1DF7D`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_ACTIVITY_SPECTATOR_FROM_HANDLE(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_ADDING_FRIEND

- **命名空间:** `NETWORK`
- **Hash:** `0x6EA101606F6E4D81`
- **JHash:** `0xBB7EC8C4`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_ADDING_FRIEND()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_ANY_PLAYER_NEAR

- **命名空间:** `NETWORK`
- **Hash:** `0x2E4C123D1C8A710E`
- **Build:** `505`

**C# 签名:**
```csharp
bool NETWORK_IS_ANY_PLAYER_NEAR(object p0, object p1, object p2, object p3, object p4, object p5, object p6)
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

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_CABLE_CONNECTED

- **命名空间:** `NETWORK`
- **Hash:** `0xEFFB25453D8600F9`
- **JHash:** `0x5C065D55`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_CABLE_CONNECTED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_CHATTING_IN_PLATFORM_PARTY

- **命名空间:** `NETWORK`
- **Hash:** `0x8DE9945BCC9AEC52`
- **JHash:** `0x51367B34`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_CHATTING_IN_PLATFORM_PARTY(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
This would be nice to see if someone is in party chat, but 2 sad notes.
1) It only becomes true if said person is speaking in that party at the time.
2) It will never, become true unless you are in that party with said person.
```

---

### NETWORK_IS_CLOCK_TIME_OVERRIDDEN

- **命名空间:** `NETWORK`
- **Hash:** `0xD7C95D322FF57522`
- **JHash:** `0x2465296D`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_CLOCK_TIME_OVERRIDDEN()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_CLOUD_AVAILABLE

- **命名空间:** `NETWORK`
- **Hash:** `0x9A4CF4F48AD77302`
- **JHash:** `0xC7FF5AFC`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_CLOUD_AVAILABLE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_CLOUD_BACKGROUND_SCRIPT_REQUEST_PENDING

- **命名空间:** `NETWORK`
- **Hash:** `0x8132C0EB8B2B3293`
- **JHash:** `0x20AB933A`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_CLOUD_BACKGROUND_SCRIPT_REQUEST_PENDING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_CONNECTED_VIA_RELAY

- **命名空间:** `NETWORK`
- **Hash:** `0x16D3D49902F697BB`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_CONNECTED_VIA_RELAY(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_CONNETED_TO_NP_PRESENCE

- **命名空间:** `NETWORK`
- **Hash:** `0x7808619F31FF22DB`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_CONNETED_TO_NP_PRESENCE()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
This function is hard-coded to always return 1.
```

---

### NETWORK_IS_DOOR_NETWORKED

- **命名空间:** `NETWORK`
- **Hash:** `0xC01E93FAC20C3346`
- **JHash:** `0xD14D9C07`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_DOOR_NETWORKED(uint doorHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `doorHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_ENTITY_CONCEALED

- **命名空间:** `NETWORK`
- **Hash:** `0x71302EC70689052A`
- **Build:** `877`

**C# 签名:**
```csharp
bool NETWORK_IS_ENTITY_CONCEALED(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Note: This only works for vehicles, which appears to be a bug (since the setter _does_ work for every entity type and the name is 99% correct).
```

---

### NETWORK_IS_ENTITY_FADING

- **命名空间:** `NETWORK`
- **Hash:** `0x422F32CC7E56ABAD`
- **JHash:** `0xB5087ACF`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_ENTITY_FADING(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_FINDING_GAMERS

- **命名空间:** `NETWORK`
- **Hash:** `0xDDDF64C91BFCF0AA`
- **JHash:** `0xA6DAA79F`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_FINDING_GAMERS()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_FRIEND

- **命名空间:** `NETWORK`
- **Hash:** `0x1A24A179F9B31654`
- **JHash:** `0x2DA4C282`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_FRIEND(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_FRIEND_HANDLE_ONLINE

- **命名空间:** `NETWORK`
- **Hash:** `0x87EB7A3FFCB314DB`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_FRIEND_HANDLE_ONLINE(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_FRIEND_INDEX_ONLINE

- **命名空间:** `NETWORK`
- **Hash:** `0xBAD8F2A42B844821`
- **JHash:** `0x94AE7172`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_FRIEND_INDEX_ONLINE(int friendIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `friendIndex` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_FRIEND_IN_MULTIPLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0x57005C18827F3A28`
- **JHash:** `0x400BDDD9`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_FRIEND_IN_MULTIPLAYER(string friendName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `friendName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_FRIEND_IN_SAME_TITLE

- **命名空间:** `NETWORK`
- **Hash:** `0x2EA9A3BEDF3F17B8`
- **JHash:** `0xC54365C2`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_FRIEND_IN_SAME_TITLE(string friendName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `friendName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
In scripts R* calls 'NETWORK_GET_FRIEND_NAME' in this param.
```

---

### NETWORK_IS_FRIEND_ONLINE

- **命名空间:** `NETWORK`
- **Hash:** `0x425A44533437B64D`
- **JHash:** `0xE0A42430`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_FRIEND_ONLINE(string name)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_GAMER_BLOCKED_BY_ME

- **命名空间:** `NETWORK`
- **Hash:** `0xE944C4F5AF1B5883`
- **JHash:** `0x3FDCC8D7`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_GAMER_BLOCKED_BY_ME(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_GAMER_IN_MY_SESSION

- **命名空间:** `NETWORK`
- **Hash:** `0x0F10B05DDF8D16E9`
- **JHash:** `0x59127716`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_GAMER_IN_MY_SESSION(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_GAMER_MUTED_BY_ME

- **命名空间:** `NETWORK`
- **Hash:** `0xCE60DE011B6C7978`
- **JHash:** `0x001B4046`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_GAMER_MUTED_BY_ME(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_GAMER_TALKING

- **命名空间:** `NETWORK`
- **Hash:** `0x71C33B22606CD88A`
- **JHash:** `0x99B58DBC`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_GAMER_TALKING(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_GAME_IN_PROGRESS

- **命名空间:** `NETWORK`
- **Hash:** `0x10FAB35428CCC9D7`
- **JHash:** `0x09B88E3E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_GAME_IN_PROGRESS()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_GETTING_GAMER_STATUS

- **命名空间:** `NETWORK`
- **Hash:** `0x94A8394D150B013A`
- **JHash:** `0x08029970`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_GETTING_GAMER_STATUS()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_HANDLE_VALID

- **命名空间:** `NETWORK`
- **Hash:** `0x6F79B93B0A8E4133`
- **JHash:** `0xF0996C6E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_HANDLE_VALID(ref object gamerHandle, int gamerHandleSize)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |
| `gamerHandleSize` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_HOST

- **命名空间:** `NETWORK`
- **Hash:** `0x8DB296B814EDDA07`
- **JHash:** `0xE46AC10F`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_HOST()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
If you are host, returns true else returns false.
```

---

### NETWORK_IS_HOST_OF_THIS_SCRIPT

- **命名空间:** `NETWORK`
- **Hash:** `0x83CD99A1E6061AB5`
- **JHash:** `0x6970BA94`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_HOST_OF_THIS_SCRIPT()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_INACTIVE_PROFILE

- **命名空间:** `NETWORK`
- **Hash:** `0x7E58745504313A2E`
- **JHash:** `0x95481343`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_INACTIVE_PROFILE(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_IN_MP_CUTSCENE

- **命名空间:** `NETWORK`
- **Hash:** `0x6CC27C9FA2040220`
- **JHash:** `0x4BB33316`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_IN_MP_CUTSCENE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_IN_PLATFORM_PARTY

- **命名空间:** `NETWORK`
- **Hash:** `0x2FC5650B0271CB57`
- **JHash:** `0xA812B6CB`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_IN_PLATFORM_PARTY()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Hardcoded to return false.
```

---

### NETWORK_IS_IN_PLATFORM_PARTY_CHAT

- **命名空间:** `NETWORK`
- **Hash:** `0xFD8B834A8BA05048`
- **JHash:** `0xC6609191`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_IN_PLATFORM_PARTY_CHAT()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Hardcoded to return false.
```

---

### NETWORK_IS_IN_SESSION

- **命名空间:** `NETWORK`
- **Hash:** `0xCA97246103B63917`
- **JHash:** `0x4BC4105E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_IN_SESSION()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_IN_SPECTATOR_MODE

- **命名空间:** `NETWORK`
- **Hash:** `0x048746E388762E11`
- **JHash:** `0x3EAD9DB8`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_IN_SPECTATOR_MODE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_IN_TRANSITION

- **命名空间:** `NETWORK`
- **Hash:** `0x68049AEFF83D8F0A`
- **JHash:** `0xC3CDB626`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_IN_TRANSITION()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_IN_TUTORIAL_SESSION

- **命名空间:** `NETWORK`
- **Hash:** `0xADA24309FE08DACF`
- **JHash:** `0x34DD7B28`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_IN_TUTORIAL_SESSION()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_LOCAL_PLAYER_INVINCIBLE

- **命名空间:** `NETWORK`
- **Hash:** `0x8A8694B48715B000`
- **JHash:** `0x8DE13B36`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_LOCAL_PLAYER_INVINCIBLE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_LOGGED_IN_TO_PSN

- **命名空间:** `NETWORK`
- **Hash:** `0xA0FA4EC6A05DA44E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_LOGGED_IN_TO_PSN()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
This function is hard-coded to always return 0.
```

---

### NETWORK_IS_MULTIPLAYER_DISABLED

- **命名空间:** `NETWORK`
- **Hash:** `0x9747292807126EDA`
- **JHash:** `0x05518C0F`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_MULTIPLAYER_DISABLED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_NETWORK_ID_REMOTELY_CONTROLLED

- **命名空间:** `NETWORK`
- **Hash:** `0x7242F8B741CE1086`
- **Build:** `678`

**C# 签名:**
```csharp
bool NETWORK_IS_NETWORK_ID_REMOTELY_CONTROLLED(int netId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if the specified network id is controlled by someone else.
```

---

### NETWORK_IS_NP_AVAILABLE

- **命名空间:** `NETWORK`
- **Hash:** `0xBD545D44CCE70597`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_NP_AVAILABLE()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
This function is hard-coded to always return 1.
```

---

### NETWORK_IS_NP_PENDING

- **命名空间:** `NETWORK`
- **Hash:** `0xEBCAB9E5048434F4`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_NP_PENDING()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
This function is hard-coded to always return 1.
```

---

### NETWORK_IS_OFFLINE_INVITE_PENDING

- **命名空间:** `NETWORK`
- **Hash:** `0x74698374C45701D2`
- **JHash:** `0x70ED476A`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_OFFLINE_INVITE_PENDING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_PARTICIPANT_ACTIVE

- **命名空间:** `NETWORK`
- **Hash:** `0x6FF8FF40B6357D45`
- **JHash:** `0x4E2C348B`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_PARTICIPANT_ACTIVE(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_PENDING_FRIEND

- **命名空间:** `NETWORK`
- **Hash:** `0x0BE73DA6984A6E33`
- **JHash:** `0x5C85FF81`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_PENDING_FRIEND(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
This function is hard-coded to always return 0.
```

---

### NETWORK_IS_PLATFORM_SUBSCRIPTION_CHECK_PENDING

- **命名空间:** `NETWORK`
- **Hash:** `0xA8ACB6459542A8C8`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_PLATFORM_SUBSCRIPTION_CHECK_PENDING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_PLAYER_ACTIVE

- **命名空间:** `NETWORK`
- **Hash:** `0xB8DFD30D6973E135`
- **JHash:** `0x43657B17`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_PLAYER_ACTIVE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_PLAYER_A_PARTICIPANT

- **命名空间:** `NETWORK`
- **Hash:** `0x3CA58F6CB7CBD784`
- **JHash:** `0xB08B6992`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_PLAYER_A_PARTICIPANT(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_PLAYER_A_PARTICIPANT_ON_SCRIPT

- **命名空间:** `NETWORK`
- **Hash:** `0x1AD5B71586B94820`
- **JHash:** `0xCEA55F4C`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_PLAYER_A_PARTICIPANT_ON_SCRIPT(int player, string script, int instance_id)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `script` | `const char*` | `string` | - |
| `instance_id` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_PLAYER_BLOCKED_BY_ME

- **命名空间:** `NETWORK`
- **Hash:** `0x57AF1F8E27483721`
- **JHash:** `0xAE4F4560`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_PLAYER_BLOCKED_BY_ME(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_PLAYER_CONCEALED

- **命名空间:** `NETWORK`
- **Hash:** `0x919B3C98ED8292F9`
- **JHash:** `0xB0313590`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_PLAYER_CONCEALED(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_PLAYER_CONNECTED

- **命名空间:** `NETWORK`
- **Hash:** `0x93DC1BE4E1ABE9D1`
- **JHash:** `0x168EE2C2`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_PLAYER_CONNECTED(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_PLAYER_FADING

- **命名空间:** `NETWORK`
- **Hash:** `0x631DC5DFF4B110E3`
- **JHash:** `0x065C597B`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_PLAYER_FADING(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_PLAYER_IN_MP_CUTSCENE

- **命名空间:** `NETWORK`
- **Hash:** `0x63F9EE203C3619F2`
- **JHash:** `0x56F961E4`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_PLAYER_IN_MP_CUTSCENE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_PLAYER_MUTED_BY_ME

- **命名空间:** `NETWORK`
- **Hash:** `0x8C71288AE68EDE39`
- **JHash:** `0x7A21050E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_PLAYER_MUTED_BY_ME(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_PLAYER_ON_BLOCKLIST

- **命名空间:** `NETWORK`
- **Hash:** `0xAD4326FCA30D62F8`
- **Build:** `2802`

**C# 签名:**
```csharp
bool NETWORK_IS_PLAYER_ON_BLOCKLIST(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_PLAYER_TALKING

- **命名空间:** `NETWORK`
- **Hash:** `0x031E11F3D447647E`
- **JHash:** `0xDA9FD9DB`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_PLAYER_TALKING(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
returns true if someone is screaming or talking in a microphone
```

---

### NETWORK_IS_PRIVILEGE_CHECK_IN_PROGRESS

- **命名空间:** `NETWORK`
- **Hash:** `0x64E5C4CC82847B73`
- **Build:** `1734`

**C# 签名:**
```csharp
bool NETWORK_IS_PRIVILEGE_CHECK_IN_PROGRESS()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Hardcoded to return false.
```

---

### NETWORK_IS_PUSH_TO_TALK_ACTIVE

- **命名空间:** `NETWORK`
- **Hash:** `0xC0D2AF00BCC234CA`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_PUSH_TO_TALK_ACTIVE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_QUEUING_FOR_SESSION_JOIN

- **命名空间:** `NETWORK`
- **Hash:** `0x14922ED3E38761F0`
- **JHash:** `0x8FA6EE0E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_QUEUING_FOR_SESSION_JOIN()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_REFRESHING_ROS_CREDENTIALS

- **命名空间:** `NETWORK`
- **Hash:** `0x8D11E61A4ABF49CC`
- **JHash:** `0xBDC8F63E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_REFRESHING_ROS_CREDENTIALS()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_SCRIPT_ACTIVE

- **命名空间:** `NETWORK`
- **Hash:** `0x9D40DF90FAD26098`
- **JHash:** `0x4A65250C`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_SCRIPT_ACTIVE(string scriptName, int instance_id, bool p2, int position_hash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scriptName` | `const char*` | `string` | - |
| `instance_id` | `int` | `int` | - |
| `p2` | `BOOL` | `bool` | - |
| `position_hash` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_SCRIPT_ACTIVE_BY_HASH

- **命名空间:** `NETWORK`
- **Hash:** `0xDA7DE67F5FE5EE13`
- **Build:** `2245`

**C# 签名:**
```csharp
bool NETWORK_IS_SCRIPT_ACTIVE_BY_HASH(uint scriptHash, int p1, bool p2, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scriptHash` | `Hash` | `uint` | - |
| `p1` | `int` | `int` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_SESSION_ACTIVE

- **命名空间:** `NETWORK`
- **Hash:** `0xD83C2B94E7508980`
- **JHash:** `0x715CB8C4`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_SESSION_ACTIVE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_SESSION_BUSY

- **命名空间:** `NETWORK`
- **Hash:** `0xF4435D66A8E2905E`
- **JHash:** `0x8592152D`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_SESSION_BUSY()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_SESSION_STARTED

- **命名空间:** `NETWORK`
- **Hash:** `0x9DE624D2FC4B603F`
- **JHash:** `0x9D854A37`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_SESSION_STARTED()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
This checks if player is playing on gta online or not.
Please add an if and block your mod if this is "true".
```

---

### NETWORK_IS_SHOWING_SYSTEM_UI_OR_RECENTLY_REQUESTED_UPSELL

- **命名空间:** `NETWORK`
- **Hash:** `0x7788DFE15016A182`
- **Build:** `2612`

**C# 签名:**
```csharp
bool NETWORK_IS_SHOWING_SYSTEM_UI_OR_RECENTLY_REQUESTED_UPSELL()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_SIGNED_IN

- **命名空间:** `NETWORK`
- **Hash:** `0x054354A99211EB96`
- **JHash:** `0xADD0B40F`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_SIGNED_IN()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns whether the player is signed into Social Club.
```

---

### NETWORK_IS_SIGNED_ONLINE

- **命名空间:** `NETWORK`
- **Hash:** `0x1077788E268557C2`
- **JHash:** `0x6E5BDCE2`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_SIGNED_ONLINE()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns whether the game is not in offline mode.

seemed not to work for some ppl
```

---

### NETWORK_IS_THREAD_A_NETWORK_SCRIPT

- **命名空间:** `NETWORK`
- **Hash:** `0x560B423D73015E77`
- **Build:** `1604`

**C# 签名:**
```csharp
bool NETWORK_IS_THREAD_A_NETWORK_SCRIPT(int threadId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `threadId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_TITLE_UPDATE_REQUIRED

- **命名空间:** `NETWORK`
- **Hash:** `0x6FB7BB3607D27FA2`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_TITLE_UPDATE_REQUIRED()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
This function is hard-coded to always return 0.
```

---

### NETWORK_IS_TRANSITION_BUSY

- **命名空间:** `NETWORK`
- **Hash:** `0x520F3282A53D26B7`
- **JHash:** `0xA357A2C6`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_TRANSITION_BUSY()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_TRANSITION_CLOSED_CREW

- **命名空间:** `NETWORK`
- **Hash:** `0x0DBD5D7E3C5BEC3B`
- **JHash:** `0xB97A966B`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_TRANSITION_CLOSED_CREW()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_TRANSITION_CLOSED_FRIENDS

- **命名空间:** `NETWORK`
- **Hash:** `0x6512765E3BE78C50`
- **JHash:** `0x95FFACF8`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_TRANSITION_CLOSED_FRIENDS()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_TRANSITION_HOST

- **命名空间:** `NETWORK`
- **Hash:** `0x0B824797C9BF2159`
- **JHash:** `0x0C0900BC`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_TRANSITION_HOST()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_TRANSITION_HOST_FROM_HANDLE

- **命名空间:** `NETWORK`
- **Hash:** `0x6B5C83BA3EFE6A10`
- **JHash:** `0x0E2854C4`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_TRANSITION_HOST_FROM_HANDLE(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_TRANSITION_LEAVE_POSTPONED

- **命名空间:** `NETWORK`
- **Hash:** `0xC571D0E77D8BBC29`
- **JHash:** `0x4F4BB300`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_TRANSITION_LEAVE_POSTPONED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_TRANSITION_MATCHMAKING

- **命名空间:** `NETWORK`
- **Hash:** `0x292564C735375EDF`
- **JHash:** `0x8262C70E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_TRANSITION_MATCHMAKING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_TRANSITION_OPEN_TO_MATCHMAKING

- **命名空间:** `NETWORK`
- **Hash:** `0x37A4494483B9F5C9`
- **JHash:** `0xC901AA9F`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_TRANSITION_OPEN_TO_MATCHMAKING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_TRANSITION_PRIVATE

- **命名空间:** `NETWORK`
- **Hash:** `0x5A6AA44FF8E931E6`
- **JHash:** `0x104DDE8D`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_TRANSITION_PRIVATE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_TRANSITION_SOLO

- **命名空间:** `NETWORK`
- **Hash:** `0x5DC577201723960A`
- **JHash:** `0x063DC4A5`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_TRANSITION_SOLO()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_TRANSITION_STARTED

- **命名空间:** `NETWORK`
- **Hash:** `0x53FA83401D9C07FE`
- **JHash:** `0x7917E111`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_TRANSITION_STARTED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_TRANSITION_TO_GAME

- **命名空间:** `NETWORK`
- **Hash:** `0x9D7696D8F4FA6CB7`
- **JHash:** `0x17146B2B`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_TRANSITION_TO_GAME()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_TRANSITION_VISIBILITY_LOCKED

- **命名空间:** `NETWORK`
- **Hash:** `0xD0A484CB2F829FBE`
- **JHash:** `0xF637166E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_TRANSITION_VISIBILITY_LOCKED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_TUNABLE_CLOUD_REQUEST_PENDING

- **命名空间:** `NETWORK`
- **Hash:** `0x0467C11ED88B7D28`
- **JHash:** `0x47978D7F`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_TUNABLE_CLOUD_REQUEST_PENDING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_TUTORIAL_SESSION_CHANGE_PENDING

- **命名空间:** `NETWORK`
- **Hash:** `0x35F0B98A8387274D`
- **JHash:** `0xA003C40B`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_IS_TUTORIAL_SESSION_CHANGE_PENDING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_IS_USING_ONLINE_PROMOTION

- **命名空间:** `NETWORK`
- **Hash:** `0x906CA41A4B74ECA4`
- **Build:** `1493`

**C# 签名:**
```csharp
bool NETWORK_IS_USING_ONLINE_PROMOTION()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_JOIN_GROUP_ACTIVITY

- **命名空间:** `NETWORK`
- **Hash:** `0xA06509A691D12BE4`
- **JHash:** `0x0D7E5CF9`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_JOIN_GROUP_ACTIVITY()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_JOIN_PREVIOUSLY_FAILED_SESSION

- **命名空间:** `NETWORK`
- **Hash:** `0x59DF79317F85A7E0`
- **JHash:** `0x6CDAA7D2`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_JOIN_PREVIOUSLY_FAILED_SESSION()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_JOIN_PREVIOUSLY_FAILED_TRANSITION

- **命名空间:** `NETWORK`
- **Hash:** `0xFFE1E5B792D92B34`
- **JHash:** `0xBF21818E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_JOIN_PREVIOUSLY_FAILED_TRANSITION()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_JOIN_TRANSITION

- **命名空间:** `NETWORK`
- **Hash:** `0x9D060B08CD63321A`
- **JHash:** `0xB054EC4B`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_JOIN_TRANSITION(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
int handle[76];
          NETWORK_HANDLE_FROM_FRIEND(iSelectedPlayer, &handle[0], 13);
          Player uVar2 = NETWORK_GET_PLAYER_FROM_GAMER_HANDLE(&handle[0]);
          NETWORK_JOIN_TRANSITION(uVar2);
nothing doin.
```

---

### NETWORK_KEEP_ENTITY_COLLISION_DISABLED_AFTER_ANIM_SCENE

- **命名空间:** `NETWORK`
- **Hash:** `0x17C9E241111A674D`
- **Build:** `2060`

**C# 签名:**
```csharp
void NETWORK_KEEP_ENTITY_COLLISION_DISABLED_AFTER_ANIM_SCENE(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_LAUNCH_TRANSITION

- **命名空间:** `NETWORK`
- **Hash:** `0x2DCF46CB1A4F0884`
- **JHash:** `0xE3570BA2`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_LAUNCH_TRANSITION()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_LEAVE_PED_BEHIND_BEFORE_CUTSCENE

- **命名空间:** `NETWORK`
- **Hash:** `0xBF22E0F32968E967`
- **JHash:** `0x22E03AD0`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_LEAVE_PED_BEHIND_BEFORE_CUTSCENE(int player, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_LEAVE_PED_BEHIND_BEFORE_WARP

- **命名空间:** `NETWORK`
- **Hash:** `0x9769F811D1785B03`
- **JHash:** `0xBE6A30C3`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_LEAVE_PED_BEHIND_BEFORE_WARP(int player, float x, float y, float z, bool p4, bool p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p4` | `BOOL` | `bool` | - |
| `p5` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p4 and p5 are always 0 in scripts
```

---

### NETWORK_LEAVE_TRANSITION

- **命名空间:** `NETWORK`
- **Hash:** `0xD23A1A815D21DB19`
- **JHash:** `0x3A3599B7`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_LEAVE_TRANSITION()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_MARK_AS_PREFERRED_ACTIVITY

- **命名空间:** `NETWORK`
- **Hash:** `0x261E97AD7BCF3D40`
- **JHash:** `0x7EF353E1`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_MARK_AS_PREFERRED_ACTIVITY(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_MARK_AS_WAITING_ASYNC

- **命名空间:** `NETWORK`
- **Hash:** `0x39917E1B4CB0F911`
- **JHash:** `0xF60986FC`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_MARK_AS_WAITING_ASYNC(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_MARK_TRANSITION_GAMER_AS_FULLY_JOINED

- **命名空间:** `NETWORK`
- **Hash:** `0x5728BB6D63E3FF1D`
- **JHash:** `0x03383F57`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_MARK_TRANSITION_GAMER_AS_FULLY_JOINED(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_MEMBER_ID_FROM_GAMER_HANDLE

- **命名空间:** `NETWORK`
- **Hash:** `0xC82630132081BB6F`
- **JHash:** `0x62EF0A63`
- **Build:** `323`

**C# 签名:**
```csharp
string NETWORK_MEMBER_ID_FROM_GAMER_HANDLE(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `string` (Native: `const char*`)

---

### NETWORK_NEED_TO_START_NEW_GAME_BUT_BLOCKED

- **命名空间:** `NETWORK`
- **Hash:** `0x53C10C8BD774F2C9`
- **Build:** `1011`

**C# 签名:**
```csharp
bool NETWORK_NEED_TO_START_NEW_GAME_BUT_BLOCKED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_ON_RETURN_TO_SINGLE_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0x283B6062A2C01E9B`
- **JHash:** `0x96E28FE2`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_ON_RETURN_TO_SINGLE_PLAYER()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_OPEN_TRANSITION_MATCHMAKING

- **命名空间:** `NETWORK`
- **Hash:** `0x2B3A8F7CA3A38FDE`
- **JHash:** `0xC71E607B`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_OPEN_TRANSITION_MATCHMAKING()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_OVERRIDE_CHAT_RESTRICTIONS

- **命名空间:** `NETWORK`
- **Hash:** `0x3039AE5AD2C9C0C4`
- **JHash:** `0x74EE2D8B`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_OVERRIDE_CHAT_RESTRICTIONS(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Could possibly bypass being muted or automatically muted
```

---

### NETWORK_OVERRIDE_CLOCK_RATE

- **命名空间:** `NETWORK`
- **Hash:** `0x42BF1D2E723B6D7E`
- **Build:** `2189`

**C# 签名:**
```csharp
void NETWORK_OVERRIDE_CLOCK_RATE(int ms)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ms` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_OVERRIDE_CLOCK_TIME

- **命名空间:** `NETWORK`
- **Hash:** `0xE679E3E06E363892`
- **JHash:** `0xC077BCD6`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_OVERRIDE_CLOCK_TIME(int hours, int minutes, int seconds)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `hours` | `int` | `int` | - |
| `minutes` | `int` | `int` | - |
| `seconds` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Works in Singleplayer too.
Passing wrong data (e.g. hours above 23) will cause the game to crash.
```

---

### NETWORK_OVERRIDE_COORDS_AND_HEADING

- **命名空间:** `NETWORK`
- **Hash:** `0xA7E30DE9272B6D49`
- **JHash:** `0x644141C5`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_OVERRIDE_COORDS_AND_HEADING(int entity, float x, float y, float z, float heading)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `heading` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_OVERRIDE_RECEIVE_RESTRICTIONS

- **命名空间:** `NETWORK`
- **Hash:** `0xDDF73E2B1FEC5AB4`
- **JHash:** `0x95F1C60D`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_OVERRIDE_RECEIVE_RESTRICTIONS(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
R* uses this to hear all player when spectating. 
It allows you to hear other online players when their chat is on none, crew and or friends
```

---

### NETWORK_OVERRIDE_RECEIVE_RESTRICTIONS_ALL

- **命名空间:** `NETWORK`
- **Hash:** `0x0FF2862B61A58AF9`
- **JHash:** `0x1BCD3DDF`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_OVERRIDE_RECEIVE_RESTRICTIONS_ALL(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p0 is always false in scripts.
```

---

### NETWORK_OVERRIDE_SEND_RESTRICTIONS

- **命名空间:** `NETWORK`
- **Hash:** `0x97DD4C5944CC2E6A`
- **JHash:** `0x6C344AE3`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_OVERRIDE_SEND_RESTRICTIONS(int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This is used alongside the native,
'NETWORK_OVERRIDE_RECEIVE_RESTRICTIONS'. Read its description for more info.
```

---

### NETWORK_OVERRIDE_SEND_RESTRICTIONS_ALL

- **命名空间:** `NETWORK`
- **Hash:** `0x57B192B4D4AD23D5`
- **JHash:** `0x2F98B405`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_OVERRIDE_SEND_RESTRICTIONS_ALL(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_OVERRIDE_TEAM_RESTRICTIONS

- **命名空间:** `NETWORK`
- **Hash:** `0x6F697A66CE78674E`
- **JHash:** `0xC8CC9E75`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_OVERRIDE_TEAM_RESTRICTIONS(int team, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `team` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_OVERRIDE_TRANSITION_CHAT

- **命名空间:** `NETWORK`
- **Hash:** `0xAF66059A131AA269`
- **JHash:** `0xCAB21090`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_OVERRIDE_TRANSITION_CHAT(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_PATCH_POST_CUTSCENE_HS4F_TUN_ENT

- **命名空间:** `NETWORK`
- **Hash:** `0xF0BC9BCD24A511D5`
- **Build:** `2372`

**C# 签名:**
```csharp
void NETWORK_PATCH_POST_CUTSCENE_HS4F_TUN_ENT(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_PERMISSIONS_HAS_GAMER_RECORD

- **命名空间:** `NETWORK`
- **Hash:** `0x559EBF901A8C68E0`
- **Build:** `2699`

**C# 签名:**
```csharp
bool NETWORK_PERMISSIONS_HAS_GAMER_RECORD(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_PLAYER_GET_CHEATER_REASON

- **命名空间:** `NETWORK`
- **Hash:** `0x172F75B6EE2233BA`
- **JHash:** `0x1720ABA6`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_PLAYER_GET_CHEATER_REASON()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_PLAYER_GET_NAME

- **命名空间:** `NETWORK`
- **Hash:** `0x7718D2E2060837D2`
- **JHash:** `0xCE48F260`
- **Build:** `323`

**C# 签名:**
```csharp
string NETWORK_PLAYER_GET_NAME(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Returns the name of a given player. Returns "**Invalid**" if rlGamerInfo of the given player cannot be retrieved or the player doesn't exist.
```

---

### NETWORK_PLAYER_GET_USERID

- **命名空间:** `NETWORK`
- **Hash:** `0x4927FC39CD0869A0`
- **JHash:** `0x4EC0D983`
- **Build:** `323`

**C# 签名:**
```csharp
string NETWORK_PLAYER_GET_USERID(int player, ref int userID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `userID` | `int*` | `ref int` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Returns a string of the player's Rockstar Id. 
Takes a 24 char buffer. Returns the buffer or "**Invalid**" if rlGamerInfo of the given player cannot be retrieved or the player doesn't exist.
```

---

### NETWORK_PLAYER_HAS_HEADSET

- **命名空间:** `NETWORK`
- **Hash:** `0x3FB99A8B08D18FD6`
- **JHash:** `0x451FB6B6`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_PLAYER_HAS_HEADSET(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_PLAYER_INDEX_IS_CHEATER

- **命名空间:** `NETWORK`
- **Hash:** `0x565E430DB3B05BEC`
- **JHash:** `0xD265B049`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_PLAYER_INDEX_IS_CHEATER(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_PLAYER_IS_BADSPORT

- **命名空间:** `NETWORK`
- **Hash:** `0x19D8DA0E5A68045A`
- **JHash:** `0xA19708E3`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_PLAYER_IS_BADSPORT()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_PLAYER_IS_CHEATER

- **命名空间:** `NETWORK`
- **Hash:** `0x655B91F1495A9090`
- **JHash:** `0xA51DC214`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_PLAYER_IS_CHEATER()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_PLAYER_IS_ROCKSTAR_DEV

- **命名空间:** `NETWORK`
- **Hash:** `0x544ABDDA3B409B6D`
- **JHash:** `0xF6659045`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_PLAYER_IS_ROCKSTAR_DEV(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Checks if a specific value (BYTE) in CNetGamePlayer is nonzero.
Returns always false in Singleplayer.

No longer used for dev checks since first mods were released on PS3 & 360.
R* now checks with the IS_DLC_PRESENT native for the dlc hash 2532323046,
if that is present it will unlock dev stuff.
```

---

### NETWORK_PREVENT_SCRIPT_HOST_MIGRATION

- **命名空间:** `NETWORK`
- **Hash:** `0x2302C0264EA58D31`
- **JHash:** `0x8DCFE77D`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_PREVENT_SCRIPT_HOST_MIGRATION()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_QUERY_RESPAWN_RESULTS

- **命名空间:** `NETWORK`
- **Hash:** `0x3C891A251567DFCE`
- **JHash:** `0x90700C7D`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_QUERY_RESPAWN_RESULTS(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_QUEUE_GAMER_FOR_STATUS

- **命名空间:** `NETWORK`
- **Hash:** `0x85A0EF54A500882C`
- **JHash:** `0x42BD0780`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_QUEUE_GAMER_FOR_STATUS(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_QUIT_MP_TO_DESKTOP

- **命名空间:** `NETWORK`
- **Hash:** `0x45A83257ED02D9BC`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_QUIT_MP_TO_DESKTOP()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_REGISTER_ENTITY_AS_NETWORKED

- **命名空间:** `NETWORK`
- **Hash:** `0x06FAACD625D80CAA`
- **JHash:** `0x31A630A4`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_REGISTER_ENTITY_AS_NETWORKED(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_REGISTER_HIGH_FREQUENCY_HOST_BROADCAST_VARIABLES

- **命名空间:** `NETWORK`
- **Hash:** `0xEA8C0DDB10E2822A`
- **Build:** `1868`

**C# 签名:**
```csharp
void NETWORK_REGISTER_HIGH_FREQUENCY_HOST_BROADCAST_VARIABLES(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_REGISTER_HIGH_FREQUENCY_PLAYER_BROADCAST_VARIABLES

- **命名空间:** `NETWORK`
- **Hash:** `0xD6D7478CA62B8D41`
- **Build:** `1868`

**C# 签名:**
```csharp
void NETWORK_REGISTER_HIGH_FREQUENCY_PLAYER_BROADCAST_VARIABLES(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_REGISTER_HOST_BROADCAST_VARIABLES

- **命名空间:** `NETWORK`
- **Hash:** `0x3E9B2F01C50DF595`
- **JHash:** `0xDAF3B0AE`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_REGISTER_HOST_BROADCAST_VARIABLES(ref int vars, int numVars, string debugName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vars` | `int*` | `ref int` | - |
| `numVars` | `int` | `int` | - |
| `debugName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_REGISTER_PLAYER_BROADCAST_VARIABLES

- **命名空间:** `NETWORK`
- **Hash:** `0x3364AA97340CA215`
- **JHash:** `0xBE3D32B4`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_REGISTER_PLAYER_BROADCAST_VARIABLES(ref int vars, int numVars, string debugName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vars` | `int*` | `ref int` | - |
| `numVars` | `int` | `int` | - |
| `debugName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_REMAIN_IN_GAME_CHAT

- **命名空间:** `NETWORK`
- **Hash:** `0xCFEB46DCD7D8D5EB`
- **JHash:** `0x1A3EA6CD`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_REMAIN_IN_GAME_CHAT(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_REMOVE_ALL_QUEUED_JOIN_REQUESTS

- **命名空间:** `NETWORK`
- **Hash:** `0x25D990F8E0E3F13C`
- **JHash:** `0x4FD83F5B`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_REMOVE_ALL_QUEUED_JOIN_REQUESTS()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_REMOVE_ALL_TRANSITION_INVITE

- **命名空间:** `NETWORK`
- **Hash:** `0x726E0375C7A26368`
- **JHash:** `0xF7134E73`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_REMOVE_ALL_TRANSITION_INVITE()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_REMOVE_AND_CANCEL_ALL_INVITES

- **命名空间:** `NETWORK`
- **Hash:** `0xEBF8284D8CADEB53`
- **JHash:** `0x9773F36A`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_REMOVE_AND_CANCEL_ALL_INVITES()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_REMOVE_AND_CANCEL_ALL_TRANSITION_INVITES

- **命名空间:** `NETWORK`
- **Hash:** `0xF083835B70BA9BFE`
- **JHash:** `0xC47352E7`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_REMOVE_AND_CANCEL_ALL_TRANSITION_INVITES()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_REMOVE_ENTITY_AREA

- **命名空间:** `NETWORK`
- **Hash:** `0x93CF869BAA0C4874`
- **JHash:** `0xEAB97F25`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_REMOVE_ENTITY_AREA(int areaHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `areaHandle` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_REMOVE_INVALID_OBJECT_MODEL

- **命名空间:** `NETWORK`
- **Hash:** `0x791EDB5803B2F468`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_REMOVE_INVALID_OBJECT_MODEL(uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_REMOVE_PRESENCE_INVITE

- **命名空间:** `NETWORK`
- **Hash:** `0xF0210268DB0974B1`
- **JHash:** `0x93C665FA`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_REMOVE_PRESENCE_INVITE(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_REMOVE_TRANSITION_INVITE

- **命名空间:** `NETWORK`
- **Hash:** `0x7524B431B2E6F7EE`
- **JHash:** `0xFDE84CB7`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_REMOVE_TRANSITION_INVITE(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_REPORT_CODE_TAMPER

- **命名空间:** `NETWORK`
- **Hash:** `0x5626D9D6810730D5`
- **Build:** `350`

**C# 签名:**
```csharp
void NETWORK_REPORT_CODE_TAMPER()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_REQUEST_CLOUD_BACKGROUND_SCRIPTS

- **命名空间:** `NETWORK`
- **Hash:** `0x924426BFFD82E915`
- **JHash:** `0x98EFB921`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_REQUEST_CLOUD_BACKGROUND_SCRIPTS()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_REQUEST_CLOUD_TUNABLES

- **命名空间:** `NETWORK`
- **Hash:** `0x42FB3B532D526E6C`
- **JHash:** `0xD760CAD5`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_REQUEST_CLOUD_TUNABLES()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_REQUEST_CONTROL_OF_DOOR

- **命名空间:** `NETWORK`
- **Hash:** `0x870DDFD5A4A796E4`
- **JHash:** `0xF60DAAF6`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_REQUEST_CONTROL_OF_DOOR(int doorID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `doorID` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_REQUEST_CONTROL_OF_ENTITY

- **命名空间:** `NETWORK`
- **Hash:** `0xB69317BF5E782347`
- **JHash:** `0xA05FEBD7`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_REQUEST_CONTROL_OF_ENTITY(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_REQUEST_CONTROL_OF_NETWORK_ID

- **命名空间:** `NETWORK`
- **Hash:** `0xA670B3662FAFFBD0`
- **JHash:** `0x9262A60A`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_REQUEST_CONTROL_OF_NETWORK_ID(int netId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_REQUEST_INVITE_CONFIRMED_EVENT

- **命名空间:** `NETWORK`
- **Hash:** `0x62A0296C1BB1CEB3`
- **JHash:** `0x0907A6BF`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_REQUEST_INVITE_CONFIRMED_EVENT()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Triggers a CEventNetworkInviteConfirmed event
```

---

### NETWORK_REQUEST_TO_BE_HOST_OF_THIS_SCRIPT

- **命名空间:** `NETWORK`
- **Hash:** `0x741A3D8380319A81`
- **JHash:** `0x331D9A27`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_REQUEST_TO_BE_HOST_OF_THIS_SCRIPT()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_RESET_BODY_TRACKER

- **命名空间:** `NETWORK`
- **Hash:** `0x72433699B4E6DD64`
- **JHash:** `0x3914463F`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_RESET_BODY_TRACKER()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_RESOLVE_PRIVILEGE_USER_CONTENT

- **命名空间:** `NETWORK`
- **Hash:** `0xDE9225854F37BF72`
- **Build:** `2612`

**C# 签名:**
```csharp
bool NETWORK_RESOLVE_PRIVILEGE_USER_CONTENT()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Hardcoded to return true.
```

---

### NETWORK_RESURRECT_LOCAL_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0xEA23C49EAA83ACFB`
- **JHash:** `0xF1F9D4B4`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_RESURRECT_LOCAL_PLAYER(float x, float y, float z, float heading, bool p4, bool changetime, bool p6, int p7, int p8)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `heading` | `float` | `float` | - |
| `p4` | `BOOL` | `bool` | - |
| `changetime` | `BOOL` | `bool` | - |
| `p6` | `BOOL` | `bool` | - |
| `p7` | `int` | `int` | - |
| `p8` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_RETAIN_ACTIVITY_GROUP

- **命名空间:** `NETWORK`
- **Hash:** `0xB13E88E655E5A3BC`
- **JHash:** `0x36A5F2DA`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_RETAIN_ACTIVITY_GROUP()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_SEED_RANDOM_NUMBER_GENERATOR

- **命名空间:** `NETWORK`
- **Hash:** `0xF1B84178F8674195`
- **JHash:** `0x41702C8A`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SEED_RANDOM_NUMBER_GENERATOR(int seed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `seed` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SEND_IMPORTANT_TRANSITION_INVITE_VIA_PRESENCE

- **命名空间:** `NETWORK`
- **Hash:** `0x1171A97A3D3981B6`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SEND_IMPORTANT_TRANSITION_INVITE_VIA_PRESENCE(ref object gamerHandle, string p1, int dataCount, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |
| `p1` | `const char*` | `string` | - |
| `dataCount` | `int` | `int` | - |
| `p3` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Contains the string "NETWORK_SEND_PRESENCE_TRANSITION_INVITE" but so does 0xC116FF9B4D488291; seems to fit alphabetically here, tho.
```

---

### NETWORK_SEND_INVITE_VIA_PRESENCE

- **命名空间:** `NETWORK`
- **Hash:** `0xC3C7A6AFDB244624`
- **JHash:** `0x8B99B72B`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SEND_INVITE_VIA_PRESENCE(ref object gamerHandle, string p1, int dataCount, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |
| `p1` | `const char*` | `string` | - |
| `dataCount` | `int` | `int` | - |
| `p3` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SEND_QUEUED_JOIN_REQUEST

- **命名空间:** `NETWORK`
- **Hash:** `0xFA2888E3833C8E96`
- **JHash:** `0x7F70C15A`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SEND_QUEUED_JOIN_REQUEST()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_SEND_TEXT_MESSAGE

- **命名空间:** `NETWORK`
- **Hash:** `0x3A214F2EC889B100`
- **JHash:** `0xAFFEA720`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SEND_TEXT_MESSAGE(string message, ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `message` | `const char*` | `string` | - |
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Message is limited to 64 characters.
```

---

### NETWORK_SEND_TRANSITION_GAMER_INSTRUCTION

- **命名空间:** `NETWORK`
- **Hash:** `0x31D1D2B858D25E6B`
- **JHash:** `0x468B0884`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SEND_TRANSITION_GAMER_INSTRUCTION(ref object gamerHandle, string p1, int p2, int p3, bool p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |
| `p1` | `const char*` | `string` | - |
| `p2` | `int` | `int` | - |
| `p3` | `int` | `int` | - |
| `p4` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SEND_TRANSITION_INVITE_VIA_PRESENCE

- **命名空间:** `NETWORK`
- **Hash:** `0xC116FF9B4D488291`
- **JHash:** `0x877C0E1C`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SEND_TRANSITION_INVITE_VIA_PRESENCE(ref object gamerHandle, string p1, int dataCount, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |
| `p1` | `const char*` | `string` | - |
| `dataCount` | `int` | `int` | - |
| `p3` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SESSION_ADD_ACTIVE_MATCHMAKING_GROUP

- **命名空间:** `NETWORK`
- **Hash:** `0xCAE55F48D3D7875C`
- **JHash:** `0x5BE529F7`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_ADD_ACTIVE_MATCHMAKING_GROUP(int groupId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `groupId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
groupId range: [0, 4]
```

---

### NETWORK_SESSION_BLOCK_JOIN_REQUESTS

- **命名空间:** `NETWORK`
- **Hash:** `0xA73667484D7037C3`
- **JHash:** `0xE6EEF8AF`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_BLOCK_JOIN_REQUESTS(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SESSION_CANCEL_INVITE

- **命名空间:** `NETWORK`
- **Hash:** `0x2FBF47B1B36D36F9`
- **JHash:** `0x20317535`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_CANCEL_INVITE()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_SESSION_CHANGE_SLOTS

- **命名空间:** `NETWORK`
- **Hash:** `0xB4AB419E0D86ACAE`
- **JHash:** `0x6BB93227`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_CHANGE_SLOTS(int slots, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `slots` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
num player slots allowed in session, seems to work? 32 max
```

---

### NETWORK_SESSION_DO_ACTIVITY_QUICKMATCH

- **命名空间:** `NETWORK`
- **Hash:** `0xBE3E347A87ACEB82`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_DO_ACTIVITY_QUICKMATCH(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SESSION_DO_CREW_MATCHMAKING

- **命名空间:** `NETWORK`
- **Hash:** `0x94BC51E9449D917F`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_DO_CREW_MATCHMAKING(int crewId, int p1, int p2, int maxPlayers)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `crewId` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `int` | `int` | - |
| `maxPlayers` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p4 seems to be unused in 1.60/build 2628
```

---

### NETWORK_SESSION_DO_FREEROAM_QUICKMATCH

- **命名空间:** `NETWORK`
- **Hash:** `0x330ED4D05491934F`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_DO_FREEROAM_QUICKMATCH(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SESSION_DO_FRIEND_MATCHMAKING

- **命名空间:** `NETWORK`
- **Hash:** `0x2CFC76E0D087C994`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_DO_FRIEND_MATCHMAKING(int p0, int p1, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SESSION_FORCE_CANCEL_INVITE

- **命名空间:** `NETWORK`
- **Hash:** `0xA29177F7703B5644`
- **JHash:** `0x3FD49D3B`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_FORCE_CANCEL_INVITE()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_SESSION_GET_HOST_AIM_PREFERENCE

- **命名空间:** `NETWORK`
- **Hash:** `0xDFFA5BE8381C3314`
- **Build:** `463`

**C# 签名:**
```csharp
int NETWORK_SESSION_GET_HOST_AIM_PREFERENCE()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_SESSION_GET_INVITER

- **命名空间:** `NETWORK`
- **Hash:** `0xE57397B4A3429DD0`
- **JHash:** `0xE9C6B3FD`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_GET_INVITER(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SESSION_GET_KICK_VOTE

- **命名空间:** `NETWORK`
- **Hash:** `0xD6D09A6F32F49EF1`
- **JHash:** `0x8A559D26`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_GET_KICK_VOTE(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SESSION_GET_MATCHMAKING_GROUP_FREE

- **命名空间:** `NETWORK`
- **Hash:** `0x56CE820830EF040B`
- **JHash:** `0x36EAD960`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_SESSION_GET_MATCHMAKING_GROUP_FREE(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_SESSION_GET_PRIVATE_SLOTS

- **命名空间:** `NETWORK`
- **Hash:** `0x53AFD64C6758F2F9`
- **JHash:** `0xE642F2FD`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_SESSION_GET_PRIVATE_SLOTS()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_SESSION_GET_UNIQUE_CREW_LIMIT

- **命名空间:** `NETWORK`
- **Hash:** `0xCDC936BF35EDCB73`
- **Build:** `3095`

**C# 签名:**
```csharp
int NETWORK_SESSION_GET_UNIQUE_CREW_LIMIT()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_SESSION_HOST

- **命名空间:** `NETWORK`
- **Hash:** `0x6F3D4ED9BEE4E61D`
- **JHash:** `0x6716460F`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_HOST(int p0, int maxPlayers, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `maxPlayers` | `int` | `int` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Does nothing in online but in offline it will cause the screen to fade to black. Nothing happens past then, the screen will sit at black until you restart GTA. Other stuff must be needed to actually host a session.
```

---

### NETWORK_SESSION_HOST_CLOSED

- **命名空间:** `NETWORK`
- **Hash:** `0xED34C0C02C098BB7`
- **JHash:** `0x8AC9EA19`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_HOST_CLOSED(int p0, int maxPlayers)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `maxPlayers` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SESSION_HOST_FRIENDS_ONLY

- **命名空间:** `NETWORK`
- **Hash:** `0xB9CFD27A5D578D83`
- **JHash:** `0x26864403`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_HOST_FRIENDS_ONLY(int p0, int maxPlayers)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `maxPlayers` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Does nothing in online but in offline it will cause the screen to fade to black. Nothing happens past then, the screen will sit at black until you restart GTA. Other stuff must be needed to actually host a session.
```

---

### NETWORK_SESSION_HOST_SINGLE_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0xC74C33FCA52856D5`
- **JHash:** `0xF3B1CA85`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_HOST_SINGLE_PLAYER(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Loads up the map that is loaded when beeing in mission creator
Player gets placed in a mix between online/offline mode
p0 is always 2 in R* scripts.

Appears to be patched in gtav b757 (game gets terminated) alonside with most other network natives to prevent online modding ~ghost30812
```

---

### NETWORK_SESSION_IS_AWAITING_INVITE_RESPONSE

- **命名空间:** `NETWORK`
- **Hash:** `0xD313DE83394AF134`
- **JHash:** `0x3EA9D44C`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_IS_AWAITING_INVITE_RESPONSE()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Seems to be true while "Getting GTA Online session details" shows up.
```

---

### NETWORK_SESSION_IS_CLOSED_CREW

- **命名空间:** `NETWORK`
- **Hash:** `0x74732C6CA90DA2B4`
- **JHash:** `0xA95299B9`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_IS_CLOSED_CREW()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SESSION_IS_CLOSED_FRIENDS

- **命名空间:** `NETWORK`
- **Hash:** `0xFBCFA2EA2E206890`
- **JHash:** `0x56E75FE4`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_IS_CLOSED_FRIENDS()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SESSION_IS_DISPLAYING_INVITE_CONFIRMATION

- **命名空间:** `NETWORK`
- **Hash:** `0xBDB6F89C729CF388`
- **JHash:** `0x9374523F`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_IS_DISPLAYING_INVITE_CONFIRMATION()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SESSION_IS_IN_VOICE_SESSION

- **命名空间:** `NETWORK`
- **Hash:** `0x855BC38818F6F684`
- **JHash:** `0x60AA4AA1`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_IS_IN_VOICE_SESSION()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SESSION_IS_PRIVATE

- **命名空间:** `NETWORK`
- **Hash:** `0xCEF70AA5B3F89BA1`
- **JHash:** `0xDB67785D`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_IS_PRIVATE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SESSION_IS_SOLO

- **命名空间:** `NETWORK`
- **Hash:** `0xF3929C2379B60CCE`
- **JHash:** `0x3D2C1916`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_IS_SOLO()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SESSION_IS_VISIBLE

- **命名空间:** `NETWORK`
- **Hash:** `0xBA416D68C631496A`
- **JHash:** `0x4977AC28`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_IS_VISIBLE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SESSION_IS_VOICE_SESSION_ACTIVE

- **命名空间:** `NETWORK`
- **Hash:** `0xB5D3453C98456528`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_IS_VOICE_SESSION_ACTIVE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SESSION_IS_VOICE_SESSION_BUSY

- **命名空间:** `NETWORK`
- **Hash:** `0xEF0912DDF7C4CB4B`
- **JHash:** `0x132CA01E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_IS_VOICE_SESSION_BUSY()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SESSION_JOIN_INVITE

- **命名空间:** `NETWORK`
- **Hash:** `0xC6F8AB8A4189CF3A`
- **JHash:** `0x3D6360B5`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_JOIN_INVITE()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_SESSION_KICK_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0xFA8904DC5F304220`
- **JHash:** `0x1E20138A`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_KICK_PLAYER(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Only works as host.
```

---

### NETWORK_SESSION_LEAVE

- **命名空间:** `NETWORK`
- **Hash:** `0xB9351A07A0D458B1`
- **Build:** `2060`

**C# 签名:**
```csharp
bool NETWORK_SESSION_LEAVE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SESSION_LEAVE_SINGLE_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0x3442775428FD2DAA`
- **JHash:** `0xC692F86A`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_LEAVE_SINGLE_PLAYER()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_SESSION_MARK_VISIBLE

- **命名空间:** `NETWORK`
- **Hash:** `0x271CC6AB59EBF9A5`
- **JHash:** `0x7017257D`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_MARK_VISIBLE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SESSION_RESERVE_SLOTS_TRANSITION

- **命名空间:** `NETWORK`
- **Hash:** `0x041C7F2A6C9894E6`
- **Build:** `463`

**C# 签名:**
```csharp
bool NETWORK_SESSION_RESERVE_SLOTS_TRANSITION(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SESSION_SET_CREW_LIMIT_MAX_MEMBERS_TRANSITION

- **命名空间:** `NETWORK`
- **Hash:** `0x702BC4D605522539`
- **JHash:** `0x913FD7D6`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_SET_CREW_LIMIT_MAX_MEMBERS_TRANSITION(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SESSION_SET_GAMEMODE

- **命名空间:** `NETWORK`
- **Hash:** `0x600F8CB31C7AAB6E`
- **JHash:** `0x959E43A3`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_SET_GAMEMODE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SESSION_SET_MATCHMAKING_GROUP

- **命名空间:** `NETWORK`
- **Hash:** `0x49EC8030F5015F8B`
- **JHash:** `0x3C3E2AB6`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_SET_MATCHMAKING_GROUP(int matchmakingGroup)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `matchmakingGroup` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SESSION_SET_MATCHMAKING_GROUP_MAX

- **命名空间:** `NETWORK`
- **Hash:** `0x8B6A4DD0AF9CE215`
- **JHash:** `0x5F29A7E0`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_SET_MATCHMAKING_GROUP_MAX(int playerType, int playerCount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `playerType` | `int` | `int` | - |
| `playerCount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
playerType is an unsigned int from 0 to 4
0 = regular joiner
4 = spectator
```

---

### NETWORK_SESSION_SET_MATCHMAKING_MENTAL_STATE

- **命名空间:** `NETWORK`
- **Hash:** `0xF1EEA2DDA9FFA69D`
- **JHash:** `0x6CC062FC`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_SET_MATCHMAKING_MENTAL_STATE(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p0 in the decompiled scripts is always the stat mesh_texblend * 0.07 to int
```

---

### NETWORK_SESSION_SET_MATCHMAKING_PROPERTY_ID

- **命名空间:** `NETWORK`
- **Hash:** `0x3F52E880AAF6C8CA`
- **JHash:** `0xB3D9A67F`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_SET_MATCHMAKING_PROPERTY_ID(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SESSION_SET_NUM_BOSSES

- **命名空间:** `NETWORK`
- **Hash:** `0x59D421683D31835A`
- **Build:** `573`

**C# 签名:**
```csharp
void NETWORK_SESSION_SET_NUM_BOSSES(int num)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `num` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SESSION_SET_SCRIPT_VALIDATE_JOIN

- **命名空间:** `NETWORK`
- **Hash:** `0x1153FA02A659051C`
- **JHash:** `0x57F9BC83`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_SET_SCRIPT_VALIDATE_JOIN()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_SESSION_SET_UNIQUE_CREW_LIMIT

- **命名空间:** `NETWORK`
- **Hash:** `0xF49ABC20D8552257`
- **JHash:** `0x454C7B67`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_SET_UNIQUE_CREW_LIMIT(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SESSION_SET_UNIQUE_CREW_LIMIT_TRANSITION

- **命名空间:** `NETWORK`
- **Hash:** `0x4811BBAC21C5FCD5`
- **JHash:** `0xE5961511`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_SET_UNIQUE_CREW_LIMIT_TRANSITION(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SESSION_SET_UNIQUE_CREW_ONLY_CREWS_TRANSITION

- **命名空间:** `NETWORK`
- **Hash:** `0x5539C3EBF104A53A`
- **JHash:** `0xAE396263`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_SET_UNIQUE_CREW_ONLY_CREWS_TRANSITION(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SESSION_VALIDATE_JOIN

- **命名空间:** `NETWORK`
- **Hash:** `0xC19F6C8E7865A6FF`
- **JHash:** `0xF3768F90`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_VALIDATE_JOIN(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SESSION_VOICE_CONNECT_TO_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0xABD5E88B8A2D3DB2`
- **JHash:** `0x9DFD89E6`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_VOICE_CONNECT_TO_PLAYER(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SESSION_VOICE_HOST

- **命名空间:** `NETWORK`
- **Hash:** `0x9C1556705F864230`
- **JHash:** `0x345C2980`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_VOICE_HOST()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SESSION_VOICE_LEAVE

- **命名空间:** `NETWORK`
- **Hash:** `0x6793E42BE02B575D`
- **JHash:** `0xE566C7DA`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_VOICE_LEAVE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SESSION_VOICE_RESPOND_TO_REQUEST

- **命名空间:** `NETWORK`
- **Hash:** `0x7F8413B7FC2AA6B9`
- **JHash:** `0x075321B5`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_VOICE_RESPOND_TO_REQUEST(bool p0, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SESSION_VOICE_SET_TIMEOUT

- **命名空间:** `NETWORK`
- **Hash:** `0x5B8ED3DB018927B1`
- **JHash:** `0x6EFC2FD0`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SESSION_VOICE_SET_TIMEOUT(int timeout)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `timeout` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SESSION_WAS_INVITED

- **命名空间:** `NETWORK`
- **Hash:** `0x23DFB504655D0CE4`
- **JHash:** `0x6A0BEA60`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SESSION_WAS_INVITED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SET_ACTIVITY_PLAYER_MAX

- **命名空间:** `NETWORK`
- **Hash:** `0x0E4F77F7B9D74D84`
- **JHash:** `0x04CB2AB4`
- **Build:** `573`

**C# 签名:**
```csharp
void NETWORK_SET_ACTIVITY_PLAYER_MAX(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_ACTIVITY_SPECTATOR

- **命名空间:** `NETWORK`
- **Hash:** `0x75138790B4359A74`
- **JHash:** `0xFC9AD060`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_ACTIVITY_SPECTATOR(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_ACTIVITY_SPECTATOR_MAX

- **命名空间:** `NETWORK`
- **Hash:** `0x9D277B76D1D12222`
- **JHash:** `0x74E0BC0A`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_ACTIVITY_SPECTATOR_MAX(int maxSpectators)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `maxSpectators` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_ANTAGONISTIC_TO_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0x5C707A667DF8B9FA`
- **JHash:** `0x64235620`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_ANTAGONISTIC_TO_PLAYER(bool toggle, int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_ATTRIBUTE_DAMAGE_TO_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0x0EDE326D47CD0F3E`
- **JHash:** `0xBEB7281A`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SET_ATTRIBUTE_DAMAGE_TO_PLAYER(int ped, int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `player` | `Player` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SET_CAN_RECEIVE_RS_INVITES

- **命名空间:** `NETWORK`
- **Hash:** `0x68980414688F7F9D`
- **Build:** `2612`

**C# 签名:**
```csharp
void NETWORK_SET_CAN_RECEIVE_RS_INVITES(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_CURRENTLY_SELECTED_GAMER_HANDLE_FROM_INVITE_MENU

- **命名空间:** `NETWORK`
- **Hash:** `0x7206F674F2A3B1BB`
- **JHash:** `0xFD95899E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SET_CURRENTLY_SELECTED_GAMER_HANDLE_FROM_INVITE_MENU(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SET_CURRENT_CHAT_OPTION

- **命名空间:** `NETWORK`
- **Hash:** `0x3DAD00265FBF356B`
- **Build:** `2802`

**C# 签名:**
```csharp
void NETWORK_SET_CURRENT_CHAT_OPTION(int newChatOption)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `newChatOption` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_CURRENT_DATA_MANAGER_HANDLE

- **命名空间:** `NETWORK`
- **Hash:** `0x796A87B3B68D1F3D`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SET_CURRENT_DATA_MANAGER_HANDLE(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SET_CURRENT_PUBLIC_CONTENT_ID

- **命名空间:** `NETWORK`
- **Hash:** `0x2C863ACDCD12B3DB`
- **Build:** `2699`

**C# 签名:**
```csharp
void NETWORK_SET_CURRENT_PUBLIC_CONTENT_ID(string missionId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `missionId` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_CURRENT_SPAWN_LOCATION_OPTION

- **命名空间:** `NETWORK`
- **Hash:** `0xAA6D5451DC3448B6`
- **Build:** `2699`

**C# 签名:**
```csharp
void NETWORK_SET_CURRENT_SPAWN_LOCATION_OPTION(uint mpSettingSpawn)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `mpSettingSpawn` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
mpSettingSpawn:

enum eMpSettingSpawn
{
	MP_SETTING_SPAWN_NULL,
	MP_SETTING_SPAWN_PROPERTY,
	MP_SETTING_SPAWN_LAST_POSITION,
	MP_SETTING_SPAWN_GARAGE,
	MP_SETTING_SPAWN_RANDOM,
	MP_SETTING_SPAWN_PRIVATE_YACHT,
	MP_SETTING_SPAWN_OFFICE,
	MP_SETTING_SPAWN_CLUBHOUSE,
	MP_SETTING_SPAWN_IE_WAREHOUSE,
	MP_SETTING_SPAWN_BUNKER,
	MP_SETTING_SPAWN_HANGAR,
	MP_SETTING_SPAWN_DEFUNCT_BASE,
	MP_SETTING_SPAWN_NIGHTCLUB,
	MP_SETTING_SPAWN_ARENA_GARAGE,
	MP_SETTING_SPAWN_CASINO_APARTMENT,
	MP_SETTING_SPAWN_ARCADE,
	MP_SETTING_SPAWN_SUBMARINE,
	MP_SETTING_SPAWN_CAR_MEET,
	MP_SETTING_SPAWN_AUTO_SHOP,
	MP_SETTING_SPAWN_FIXER_HQ,
	MP_SETTING_SPAWN_MAX,
};
```

---

### NETWORK_SET_CUSTOM_ARENA_BALL_PARAMS

- **命名空间:** `NETWORK`
- **Hash:** `0xA6FCECCF4721D679`
- **Build:** `1604`

**C# 签名:**
```csharp
void NETWORK_SET_CUSTOM_ARENA_BALL_PARAMS(int netId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_DO_NOT_LAUNCH_FROM_JOIN_AS_MIGRATED_HOST

- **命名空间:** `NETWORK`
- **Hash:** `0xA2E9C1AB8A92E8CD`
- **JHash:** `0x8D014B23`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_DO_NOT_LAUNCH_FROM_JOIN_AS_MIGRATED_HOST(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Appears to set whether a transition should be started when the session is migrating.
```

---

### NETWORK_SET_ENTITY_CAN_BLEND

- **命名空间:** `NETWORK`
- **Hash:** `0xD830567D88A1E873`
- **JHash:** `0xDE8C0DB8`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_ENTITY_CAN_BLEND(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_ENTITY_ONLY_EXISTS_FOR_PARTICIPANTS

- **命名空间:** `NETWORK`
- **Hash:** `0xF1CA12B18AEF5298`
- **JHash:** `0x09CBC4B0`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_ENTITY_ONLY_EXISTS_FOR_PARTICIPANTS(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
if set to true other network players can't see it
if set to false other network player can see it
=========================================
^^ I attempted this by grabbing an object with GET_ENTITY_PLAYER_IS_FREE_AIMING_AT and setting this naive no matter the toggle he could still see it.

pc or last gen?

^^ last-gen
```

---

### NETWORK_SET_FRIENDLY_FIRE_OPTION

- **命名空间:** `NETWORK`
- **Hash:** `0xF808475FA571D823`
- **JHash:** `0x6BAF95FA`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_FRIENDLY_FIRE_OPTION(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_GAMER_INVITED_TO_TRANSITION

- **命名空间:** `NETWORK`
- **Hash:** `0xCA2C8073411ECDB6`
- **JHash:** `0x17F1C69D`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_GAMER_INVITED_TO_TRANSITION(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_IGNORE_SPECTATOR_CHAT_LIMITS_SAME_TEAM

- **命名空间:** `NETWORK`
- **Hash:** `0x6A5D89D7769A40D8`
- **JHash:** `0x4FFEFE43`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_IGNORE_SPECTATOR_CHAT_LIMITS_SAME_TEAM(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_INVITE_FAILED_MESSAGE_FOR_INVITE_MENU

- **命名空间:** `NETWORK`
- **Hash:** `0x0D77A82DC2D0DA59`
- **JHash:** `0x0808D4CC`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_INVITE_FAILED_MESSAGE_FOR_INVITE_MENU(ref object p0, ref object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_INVITE_ON_CALL_FOR_INVITE_MENU

- **命名空间:** `NETWORK`
- **Hash:** `0x66F010A4B031A331`
- **JHash:** `0x11378777`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_INVITE_ON_CALL_FOR_INVITE_MENU(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_IN_FREE_CAM_MODE

- **命名空间:** `NETWORK`
- **Hash:** `0xFC18DB55AE19E046`
- **JHash:** `0xA7E36020`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_IN_FREE_CAM_MODE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_IN_MP_CUTSCENE

- **命名空间:** `NETWORK`
- **Hash:** `0x9CA5DE655269FEC4`
- **JHash:** `0x8434CB43`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_IN_MP_CUTSCENE(bool p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_IN_PROGRESS_FINISH_TIME

- **命名空间:** `NETWORK`
- **Hash:** `0x2CE9D95E4051AECD`
- **Build:** `678`

**C# 签名:**
```csharp
void NETWORK_SET_IN_PROGRESS_FINISH_TIME(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_IN_SPECTATOR_MODE

- **命名空间:** `NETWORK`
- **Hash:** `0x423DE3854BB50894`
- **JHash:** `0x5C4C8458`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_IN_SPECTATOR_MODE(bool toggle, int playerPed)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |
| `playerPed` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_IN_SPECTATOR_MODE_EXTENDED

- **命名空间:** `NETWORK`
- **Hash:** `0x419594E137637120`
- **JHash:** `0x54058F5F`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_IN_SPECTATOR_MODE_EXTENDED(bool toggle, int playerPed, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |
| `playerPed` | `Ped` | `int` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_LOCAL_PLAYER_INVINCIBLE_TIME

- **命名空间:** `NETWORK`
- **Hash:** `0x2D95C7E2D7E07307`
- **JHash:** `0xFEA9B85C`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_LOCAL_PLAYER_INVINCIBLE_TIME(int time)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `time` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_LOCAL_PLAYER_SYNC_LOOK_AT

- **命名空间:** `NETWORK`
- **Hash:** `0x524FF0AEFF9C3973`
- **JHash:** `0xB72F086D`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_LOCAL_PLAYER_SYNC_LOOK_AT(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_LOOK_AT_TALKERS

- **命名空间:** `NETWORK`
- **Hash:** `0x7D395EA61622E116`
- **JHash:** `0x5C05B7E1`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_LOOK_AT_TALKERS(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_MINIMUM_RANK_FOR_MISSION

- **命名空间:** `NETWORK`
- **Hash:** `0x94538037EE44F5CF`
- **JHash:** `0x6B97075B`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_MINIMUM_RANK_FOR_MISSION(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_MISSION_FINISHED

- **命名空间:** `NETWORK`
- **Hash:** `0x3B3D11CD9FFCDFC9`
- **JHash:** `0x3083FAD7`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_MISSION_FINISHED()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_NO_LONGER_NEEDED

- **命名空间:** `NETWORK`
- **Hash:** `0x3FC795691834481D`
- **Build:** `1868`

**C# 签名:**
```csharp
void NETWORK_SET_NO_LONGER_NEEDED(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_NO_SPECTATOR_CHAT

- **命名空间:** `NETWORK`
- **Hash:** `0xF46A1E03E8755980`
- **JHash:** `0xD33AFF79`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_NO_SPECTATOR_CHAT(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_OBJECT_CAN_BLEND_WHEN_FIXED

- **命名空间:** `NETWORK`
- **Hash:** `0x0379DAF89BA09AA5`
- **Build:** `944`

**C# 签名:**
```csharp
void NETWORK_SET_OBJECT_CAN_BLEND_WHEN_FIXED(int object, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_OBJECT_SCOPE_DISTANCE

- **命名空间:** `NETWORK`
- **Hash:** `0xBA7F0B77D80A4EB7`
- **Build:** `372`

**C# 签名:**
```csharp
void NETWORK_SET_OBJECT_SCOPE_DISTANCE(int object, float range)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `range` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_OVERRIDE_SPECTATOR_MODE

- **命名空间:** `NETWORK`
- **Hash:** `0x70DA3BF8DACD3210`
- **JHash:** `0xA0FD42D3`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_OVERRIDE_SPECTATOR_MODE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_OVERRIDE_TUTORIAL_SESSION_CHAT

- **命名空间:** `NETWORK`
- **Hash:** `0x3C5C1E2C2FF814B1`
- **JHash:** `0xC9DDA85B`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_OVERRIDE_TUTORIAL_SESSION_CHAT(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_PLAYER_IS_PASSIVE

- **命名空间:** `NETWORK`
- **Hash:** `0x1B857666604B1A74`
- **JHash:** `0x76A9FEB6`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_PLAYER_IS_PASSIVE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_PLAYER_MENTAL_STATE

- **命名空间:** `NETWORK`
- **Hash:** `0x367EF5E2F439B4C6`
- **JHash:** `0x53C9563C`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_PLAYER_MENTAL_STATE(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p0 in the decompiled scripts is always the stat mesh_texblend * 0.07 to int
```

---

### NETWORK_SET_PRESENCE_SESSION_INVITES_BLOCKED

- **命名空间:** `NETWORK`
- **Hash:** `0x4A9FDE3A5A6D0437`
- **JHash:** `0x18F03AFD`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_PRESENCE_SESSION_INVITES_BLOCKED(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Does nothing. It's just a nullsub.
```

---

### NETWORK_SET_PRIVILEGE_CHECK_RESULT_NOT_NEEDED

- **命名空间:** `NETWORK`
- **Hash:** `0x1F7BC3539F9E0224`
- **Build:** `1180`

**C# 签名:**
```csharp
void NETWORK_SET_PRIVILEGE_CHECK_RESULT_NOT_NEEDED()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_PROXIMITY_AFFECTS_TEAM

- **命名空间:** `NETWORK`
- **Hash:** `0x9D7AFCBF21C51712`
- **JHash:** `0xE5219410`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_PROXIMITY_AFFECTS_TEAM(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_RICH_PRESENCE

- **命名空间:** `NETWORK`
- **Hash:** `0x1DCCACDCFC569362`
- **JHash:** `0x932A6CED`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_RICH_PRESENCE(int p0, int p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native does absolutely nothing, just a nullsub
```

---

### NETWORK_SET_RICH_PRESENCE_STRING

- **命名空间:** `NETWORK`
- **Hash:** `0x3E200C2BCF4164EB`
- **JHash:** `0x017E6777`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_RICH_PRESENCE_STRING(int p0, string textLabel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `textLabel` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native does absolutely nothing, just a nullsub
```

---

### NETWORK_SET_SAME_TEAM_AS_LOCAL_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0x4348BFDA56023A2F`
- **Build:** `573`

**C# 签名:**
```csharp
bool NETWORK_SET_SAME_TEAM_AS_LOCAL_PLAYER(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SET_SCRIPT_AUTOMUTED

- **命名空间:** `NETWORK`
- **Hash:** `0xB309EBEA797E001F`
- **JHash:** `0x5C0AB2A9`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_SET_SCRIPT_AUTOMUTED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SET_SCRIPT_CONTROLLING_TEAMS

- **命名空间:** `NETWORK`
- **Hash:** `0x265559DA40B3F327`
- **Build:** `573`

**C# 签名:**
```csharp
void NETWORK_SET_SCRIPT_CONTROLLING_TEAMS(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_SCRIPT_READY_FOR_EVENTS

- **命名空间:** `NETWORK`
- **Hash:** `0x7AC752103856FB20`
- **JHash:** `0xA639DCA2`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_SCRIPT_READY_FOR_EVENTS(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_SPECTATOR_TO_NON_SPECTATOR_TEXT_CHAT

- **命名空间:** `NETWORK`
- **Hash:** `0x8EF52ACAECC51D9C`
- **Build:** `1734`

**C# 签名:**
```csharp
void NETWORK_SET_SPECTATOR_TO_NON_SPECTATOR_TEXT_CHAT(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_TALKER_PROXIMITY

- **命名空间:** `NETWORK`
- **Hash:** `0xCBF12D65F95AD686`
- **JHash:** `0x67555C66`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_TALKER_PROXIMITY(float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_TASK_CUTSCENE_INSCOPE_MULTIPLER

- **命名空间:** `NETWORK`
- **Hash:** `0xC6FCEE21C6FCEE21`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_SET_TASK_CUTSCENE_INSCOPE_MULTIPLER(float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
A value between 1.0 and 5.0
```

---

### NETWORK_SET_TEAM_ONLY_CHAT

- **命名空间:** `NETWORK`
- **Hash:** `0xD5B4883AC32F24C3`
- **JHash:** `0x3813019A`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_TEAM_ONLY_CHAT(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT

- **命名空间:** `NETWORK`
- **Hash:** `0x1CA59E306ECB80A5`
- **JHash:** `0x470810ED`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT(int maxNumMissionParticipants, bool p1, int instanceId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `maxNumMissionParticipants` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `instanceId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_TRANSITION_ACTIVITY_ID

- **命名空间:** `NETWORK`
- **Hash:** `0x30DE938B516F0AD2`
- **JHash:** `0xCCA9C022`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_TRANSITION_ACTIVITY_ID(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_TRANSITION_CREATOR_HANDLE

- **命名空间:** `NETWORK`
- **Hash:** `0xEF26739BCD9907D5`
- **JHash:** `0x1DD01FE7`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_TRANSITION_CREATOR_HANDLE(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_TRANSITION_VISIBILITY_LOCK

- **命名空间:** `NETWORK`
- **Hash:** `0x0C978FDA19692C2C`
- **JHash:** `0x4AF0ADF5`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_TRANSITION_VISIBILITY_LOCK(bool p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_VEHICLE_DRIVEN_IN_TEST_DRIVE

- **命名空间:** `NETWORK`
- **Hash:** `0x8C70252FC40F320B`
- **Build:** `2699`

**C# 签名:**
```csharp
void NETWORK_SET_VEHICLE_DRIVEN_IN_TEST_DRIVE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Used by MetricVEHICLE_DIST_DRIVEN
```

---

### NETWORK_SET_VEHICLE_DRIVEN_LOCATION

- **命名空间:** `NETWORK`
- **Hash:** `0xA0CE91E47531D3BB`
- **Build:** `2944`

**C# 签名:**
```csharp
void NETWORK_SET_VEHICLE_DRIVEN_LOCATION(uint location)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `location` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets 'loc' variable used in MetricVEHICLE_DIST_DRIVEN
```

---

### NETWORK_SET_VOICE_ACTIVE

- **命名空间:** `NETWORK`
- **Hash:** `0xBABEC9E69A91C57B`
- **JHash:** `0x8011247F`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_VOICE_ACTIVE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_VOICE_CHANNEL

- **命名空间:** `NETWORK`
- **Hash:** `0xEF6212C2EFEF1A23`
- **JHash:** `0x3974879F`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_VOICE_CHANNEL(int channel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `channel` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SHOULD_SHOW_PROMOTION_ALERT_SCREEN

- **命名空间:** `NETWORK`
- **Hash:** `0x023ACAB2DC9DC4A4`
- **Build:** `1493`

**C# 签名:**
```csharp
bool NETWORK_SHOULD_SHOW_PROMOTION_ALERT_SCREEN()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SHOULD_SHOW_STRICT_NAT_WARNING

- **命名空间:** `NETWORK`
- **Hash:** `0x82A2B386716608F1`
- **Build:** `393`

**C# 签名:**
```csharp
bool NETWORK_SHOULD_SHOW_STRICT_NAT_WARNING()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if the NAT type is Strict (3) and a certain number of connections have failed.
```

---

### NETWORK_SHOW_ACCOUNT_UPGRADE_UI

- **命名空间:** `NETWORK`
- **Hash:** `0x83FE8D7229593017`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SHOW_ACCOUNT_UPGRADE_UI()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_SHOW_CHAT_RESTRICTION_MSC

- **命名空间:** `NETWORK`
- **Hash:** `0x6BFF5F84102DF80A`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SHOW_CHAT_RESTRICTION_MSC(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Does nothing (it's a nullsub).
```

---

### NETWORK_SHOW_PROFILE_UI

- **命名空间:** `NETWORK`
- **Hash:** `0x859ED1CEA343FCA8`
- **JHash:** `0xF00A20B0`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SHOW_PROFILE_UI(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SHOW_PSN_UGC_RESTRICTION

- **命名空间:** `NETWORK`
- **Hash:** `0x5C497525F803486B`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SHOW_PSN_UGC_RESTRICTION()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
This native does absolutely nothing, just a nullsub
```

---

### NETWORK_SKIP_RADIO_RESET_NEXT_CLOSE

- **命名空间:** `NETWORK`
- **Hash:** `0x9465E683B12D3F6B`
- **JHash:** `0x273C6180`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SKIP_RADIO_RESET_NEXT_CLOSE()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_SKIP_RADIO_RESET_NEXT_OPEN

- **命名空间:** `NETWORK`
- **Hash:** `0xCA59CCAE5D01E4CE`
- **Build:** `1734`

**C# 签名:**
```csharp
void NETWORK_SKIP_RADIO_RESET_NEXT_OPEN()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_SKIP_RADIO_WARNING

- **命名空间:** `NETWORK`
- **Hash:** `0x659CF2EF7F550C4F`
- **Build:** `1011`

**C# 签名:**
```csharp
bool NETWORK_SKIP_RADIO_WARNING()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if dinput8.dll is present in the game directory.
You will get following error message if that is true: "You are attempting to access GTA Online servers with an altered version of the game."
```

---

### NETWORK_START_RESPAWN_SEARCH_FOR_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0x5A6FFA2433E2F14C`
- **JHash:** `0xC62E77B3`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_START_RESPAWN_SEARCH_FOR_PLAYER(int player, float x, float y, float z, float radius, float p5, float p6, float p7, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `p5` | `float` | `float` | - |
| `p6` | `float` | `float` | - |
| `p7` | `float` | `float` | - |
| `flags` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
One of the first things it does is get the players ped.
Then it calls a function that is used in some tasks and ped based functions.
p5, p6, p7 is another coordinate (or zero), often related to `GET_BLIP_COORDS, in the decompiled scripts.
```

---

### NETWORK_START_RESPAWN_SEARCH_IN_ANGLED_AREA_FOR_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0x4BA92A18502BCA61`
- **JHash:** `0x74D6B13C`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_START_RESPAWN_SEARCH_IN_ANGLED_AREA_FOR_PLAYER(int player, float x1, float y1, float z1, float x2, float y2, float z2, float width, float p8, float p9, float p10, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |
| `z2` | `float` | `float` | - |
| `width` | `float` | `float` | - |
| `p8` | `float` | `float` | - |
| `p9` | `float` | `float` | - |
| `p10` | `float` | `float` | - |
| `flags` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p8, p9, p10 is another coordinate, or zero, often related to `GET_BLIP_COORDS in the decompiled scripts.
```

---

### NETWORK_START_SOLO_TUTORIAL_SESSION

- **命名空间:** `NETWORK`
- **Hash:** `0x17E0198B3882C2CB`
- **JHash:** `0x408A9436`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_START_SOLO_TUTORIAL_SESSION()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_START_SYNCHRONISED_SCENE

- **命名空间:** `NETWORK`
- **Hash:** `0x9A1B3FCDB36C8697`
- **JHash:** `0xA9DFDC40`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_START_SYNCHRONISED_SCENE(int netScene)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netScene` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_START_USER_CONTENT_PERMISSIONS_CHECK

- **命名空间:** `NETWORK`
- **Hash:** `0xDEB2B99A1AF1A2A6`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_START_USER_CONTENT_PERMISSIONS_CHECK(ref object netHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netHandle` | `Any*` | `ref object` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Always returns -1. Seems to be XB1 specific.
```

---

### NETWORK_STOP_SYNCHRONISED_SCENE

- **命名空间:** `NETWORK`
- **Hash:** `0xC254481A4574CB2F`
- **JHash:** `0x97B1CDF6`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_STOP_SYNCHRONISED_SCENE(int netScene)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netScene` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_STORE_INVITE_THROUGH_RESTART

- **命名空间:** `NETWORK`
- **Hash:** `0xF814FEC6A19FD6E0`
- **JHash:** `0x32B7A076`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_STORE_INVITE_THROUGH_RESTART()
```

**返回值:** `void` (Native: `void`)

---

### NETWORK_SUPPRESS_INVITE

- **命名空间:** `NETWORK`
- **Hash:** `0xA0682D67EF1FBA3D`
- **JHash:** `0x323DC78C`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SUPPRESS_INVITE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SYNC_CLOCK_TIME_OVERRIDE

- **命名空间:** `NETWORK`
- **Hash:** `0xCBD02360C5E16871`
- **Build:** `3570`

**C# 签名:**
```csharp
void NETWORK_SYNC_CLOCK_TIME_OVERRIDE()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Does nothing in final builds.
```

---

### NETWORK_TEXT_CHAT_IS_TYPING

- **命名空间:** `NETWORK`
- **Hash:** `0x5FCF4D7069B09026`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_TEXT_CHAT_IS_TYPING()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Same as _IS_TEXT_CHAT_ACTIVE, except it does not check if the text chat HUD component is initialized, and therefore may crash.
```

---

### NETWORK_TRANSITION_ADD_STAGE

- **命名空间:** `NETWORK`
- **Hash:** `0xC3BFED92026A2AAD`
- **Build:** `617`

**C# 签名:**
```csharp
bool NETWORK_TRANSITION_ADD_STAGE(uint hash, int p1, int p2, int state, int p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `hash` | `Hash` | `uint` | - |
| `p1` | `int` | `int` | - |
| `p2` | `int` | `int` | - |
| `state` | `int` | `int` | - |
| `p4` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_TRANSITION_BLOCK_JOIN_REQUESTS

- **命名空间:** `NETWORK`
- **Hash:** `0x973D76AA760A6CB6`
- **JHash:** `0x0532DDD2`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_TRANSITION_BLOCK_JOIN_REQUESTS(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_TRANSITION_FINISH

- **命名空间:** `NETWORK`
- **Hash:** `0x04918A41BC9B8157`
- **Build:** `617`

**C# 签名:**
```csharp
bool NETWORK_TRANSITION_FINISH(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_TRANSITION_SET_ACTIVITY_ISLAND

- **命名空间:** `NETWORK`
- **Hash:** `0xF6F4383B7C92F11A`
- **Build:** `573`

**C# 签名:**
```csharp
void NETWORK_TRANSITION_SET_ACTIVITY_ISLAND(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_TRANSITION_SET_CONTENT_CREATOR

- **命名空间:** `NETWORK`
- **Hash:** `0x1F8E00FB18239600`
- **Build:** `573`

**C# 签名:**
```csharp
void NETWORK_TRANSITION_SET_CONTENT_CREATOR(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_TRANSITION_SET_IN_PROGRESS

- **命名空间:** `NETWORK`
- **Hash:** `0x1398582B7F72B3ED`
- **Build:** `505`

**C# 签名:**
```csharp
void NETWORK_TRANSITION_SET_IN_PROGRESS(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_TRANSITION_START

- **命名空间:** `NETWORK`
- **Hash:** `0x8B4FFC790CA131EF`
- **Build:** `617`

**C# 签名:**
```csharp
bool NETWORK_TRANSITION_START(int p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_TRIGGER_DAMAGE_EVENT_FOR_ZERO_DAMAGE

- **命名空间:** `NETWORK`
- **Hash:** `0x890E2C5ABED7236D`
- **Build:** `1365`

**C# 签名:**
```csharp
void NETWORK_TRIGGER_DAMAGE_EVENT_FOR_ZERO_DAMAGE(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Allows vehicle wheels to be destructible even when the vehicle entity is invincible.
```

---

### NETWORK_TRIGGER_DAMAGE_EVENT_FOR_ZERO_WEAPON_HASH

- **命名空间:** `NETWORK`
- **Hash:** `0x38B7C51AB1EDC7D8`
- **Build:** `1734`

**C# 签名:**
```csharp
void NETWORK_TRIGGER_DAMAGE_EVENT_FOR_ZERO_WEAPON_HASH(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_TRY_ACCESS_TUNABLE_BOOL_HASH

- **命名空间:** `NETWORK`
- **Hash:** `0xC7420099936CE286`
- **JHash:** `0x8AFE3D90`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_TRY_ACCESS_TUNABLE_BOOL_HASH(uint tunableContext, uint tunableName, bool defaultValue)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `tunableContext` | `Hash` | `uint` | - |
| `tunableName` | `Hash` | `uint` | - |
| `defaultValue` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns defaultValue if the tunable doesn't exist.
```

---

### NETWORK_TRY_TO_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT

- **命名空间:** `NETWORK`
- **Hash:** `0xD1110739EEADB592`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_TRY_TO_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT(object p0, bool p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_UGC_NAV

- **命名空间:** `NETWORK`
- **Hash:** `0xC1447451DDB512F0`
- **Build:** `2372`

**C# 签名:**
```csharp
void NETWORK_UGC_NAV(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_UNREGISTER_NETWORKED_ENTITY

- **命名空间:** `NETWORK`
- **Hash:** `0x7368E683BB9038D6`
- **JHash:** `0x5C645F64`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_UNREGISTER_NETWORKED_ENTITY(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_USE_HIGH_PRECISION_BLENDING

- **命名空间:** `NETWORK`
- **Hash:** `0x2B1813ABA29016C5`
- **JHash:** `0x155465EE`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_USE_HIGH_PRECISION_BLENDING(int netID, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netID` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_USE_LOGARITHMIC_BLENDING_THIS_FRAME

- **命名空间:** `NETWORK`
- **Hash:** `0xCD71A4ECAB22709E`
- **JHash:** `0xBC54371B`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_USE_LOGARITHMIC_BLENDING_THIS_FRAME(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_WAITING_POP_CLEAR_TUTORIAL_SESSION

- **命名空间:** `NETWORK`
- **Hash:** `0xB37E4E6A2388CA7B`
- **JHash:** `0x755A2B3E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_WAITING_POP_CLEAR_TUTORIAL_SESSION()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_WAS_GAME_SUSPENDED

- **命名空间:** `NETWORK`
- **Hash:** `0x4237E822315D8BA9`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_WAS_GAME_SUSPENDED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_BASKET_ADD_ITEM

- **命名空间:** `NETSHOPPING`
- **Hash:** `0xF30980718C8ED876`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_BASKET_ADD_ITEM(ref object itemData, int quantity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `itemData` | `Any*` | `ref object` | - |
| `quantity` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_BASKET_APPLY_SERVER_DATA

- **命名空间:** `NETSHOPPING`
- **Hash:** `0xE1A0450ED46A7812`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_BASKET_APPLY_SERVER_DATA(object p0, ref object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_BASKET_END

- **命名空间:** `NETSHOPPING`
- **Hash:** `0xFA336E7F40C0A0D0`
- **Build:** `372`

**C# 签名:**
```csharp
bool NET_GAMESERVER_BASKET_END()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_BASKET_IS_ACTIVE

- **命名空间:** `NETSHOPPING`
- **Hash:** `0xA65568121DF2EA26`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_BASKET_IS_ACTIVE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_BASKET_IS_FULL

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x27F76CC6C55AD30E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_BASKET_IS_FULL()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_BASKET_START

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x279F08B1A4B29B7E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_BASKET_START(ref int transactionId, uint categoryHash, uint actionHash, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `transactionId` | `int*` | `ref int` | - |
| `categoryHash` | `Hash` | `uint` | - |
| `actionHash` | `Hash` | `uint` | - |
| `flags` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_BEGIN_SERVICE

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x3C5FD37B5499582E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_BEGIN_SERVICE(ref int transactionId, uint categoryHash, uint itemHash, uint actionTypeHash, int value, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `transactionId` | `int*` | `ref int` | - |
| `categoryHash` | `Hash` | `uint` | - |
| `itemHash` | `Hash` | `uint` | - |
| `actionTypeHash` | `Hash` | `uint` | - |
| `value` | `int` | `int` | - |
| `flags` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_CATALOG_IS_VALID

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x3C4487461E9B0DCB`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_CATALOG_IS_VALID()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_CATALOG_ITEM_IS_VALID

- **命名空间:** `NETSHOPPING`
- **Hash:** `0xBD4D7EAF8A30F637`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_CATALOG_ITEM_IS_VALID(string name)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_CATALOG_ITEM_KEY_IS_VALID

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x247F0F73A182EA0B`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_CATALOG_ITEM_KEY_IS_VALID(uint hash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `hash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_CHECKOUT_PENDING

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x4B64CD6D18474126`
- **Build:** `3570`

**C# 签名:**
```csharp
bool NET_GAMESERVER_CHECKOUT_PENDING(int transactionId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `transactionId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_CHECKOUT_START

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x39BE7CEA8D9CC8E6`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_CHECKOUT_START(int transactionId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `transactionId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_CLEAR_SESSION

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x74A0FD0688F1EE45`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_CLEAR_SESSION(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_DELETE_CHARACTER

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x51F1A8E48C3D2F6D`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_DELETE_CHARACTER(int slot, bool transfer, uint reason)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `slot` | `int` | `int` | - |
| `transfer` | `BOOL` | `bool` | - |
| `reason` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_DELETE_CHARACTER_GET_STATUS

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x0A6D923DFFC9BD89`
- **Build:** `323`

**C# 签名:**
```csharp
int NET_GAMESERVER_DELETE_CHARACTER_GET_STATUS()
```

**返回值:** `int` (Native: `int`)

---

### NET_GAMESERVER_DELETE_SET_TELEMETRY_NONCE_SEED

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x112CEF1615A1139F`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_DELETE_SET_TELEMETRY_NONCE_SEED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_END_SERVICE

- **命名空间:** `NETSHOPPING`
- **Hash:** `0xE2A99A9B524BEFFF`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_END_SERVICE(int transactionId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `transactionId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_GET_CATALOG_CLOUD_CRC

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x85F6C9ABA1DE2BCF`
- **Build:** `323`

**C# 签名:**
```csharp
uint NET_GAMESERVER_GET_CATALOG_CLOUD_CRC()
```

**返回值:** `uint` (Native: `Hash`)

---

### NET_GAMESERVER_GET_PRICE

- **命名空间:** `NETSHOPPING`
- **Hash:** `0xC27009422FCCA88D`
- **Build:** `323`

**C# 签名:**
```csharp
int NET_GAMESERVER_GET_PRICE(uint itemHash, uint categoryHash, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `itemHash` | `Hash` | `uint` | - |
| `categoryHash` | `Hash` | `uint` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
bool is always true in game scripts
```

---

### NET_GAMESERVER_GET_SESSION_STATE_AND_STATUS

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x897433D292B44130`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_GET_SESSION_STATE_AND_STATUS(ref int p0, ref bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int*` | `ref int` | - |
| `p1` | `BOOL*` | `ref bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_INIT_SESSION

- **命名空间:** `NETSHOPPING`
- **Hash:** `0xE3E5A7C64CA2C6ED`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_INIT_SESSION()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_IS_CATALOG_CURRENT

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x2B949A1E6AEC8F6A`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_IS_CATALOG_CURRENT()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_IS_SESSION_REFRESH_PENDING

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x810E8431C0614BF9`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_IS_SESSION_REFRESH_PENDING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_IS_SESSION_VALID

- **命名空间:** `NETSHOPPING`
- **Hash:** `0xB24F0944DA203D9E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_IS_SESSION_VALID(int charSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `charSlot` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_REFRESH_SERVER_CATALOG

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x357B152EF96C30B6`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_REFRESH_SERVER_CATALOG()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_RETRIEVE_CATALOG_REFRESH_STATUS

- **命名空间:** `NETSHOPPING`
- **Hash:** `0xCF38DAFBB49EDE5E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_RETRIEVE_CATALOG_REFRESH_STATUS(ref int state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `state` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_RETRIEVE_INIT_SESSION_STATUS

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x0395CB47B022E62C`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_RETRIEVE_INIT_SESSION_STATUS(ref int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_RETRIEVE_SESSION_ERROR_CODE

- **命名空间:** `NETSHOPPING`
- **Hash:** `0xC13C38E47EA5DF31`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_RETRIEVE_SESSION_ERROR_CODE(ref int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_RETRIEVE_START_SESSION_STATUS

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x170910093218C8B9`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_RETRIEVE_START_SESSION_STATUS(ref int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_SESSION_APPLY_RECEIVED_DATA

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x2F41D51BA3BCD1F1`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_SESSION_APPLY_RECEIVED_DATA(int charSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `charSlot` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_SET_TELEMETRY_NONCE_SEED

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x9507D4271988E1AE`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_SET_TELEMETRY_NONCE_SEED(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_START_SESSION

- **命名空间:** `NETSHOPPING`
- **Hash:** `0xA135AC892A58FC07`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_START_SESSION(int charSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `charSlot` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_START_SESSION_PENDING

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x72EB7BA9B69BF6AB`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_START_SESSION_PENDING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_START_SESSION_RESTART

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x35A1B3E1D1315CFA`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_START_SESSION_RESTART(bool inventory, bool playerbalance)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `inventory` | `BOOL` | `bool` | - |
| `playerbalance` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Note: only one of the arguments can be set to true at a time
```

---

### NET_GAMESERVER_TRANSACTION_IN_PROGRESS

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x613F125BA3BD2EB9`
- **Build:** `372`

**C# 签名:**
```csharp
bool NET_GAMESERVER_TRANSACTION_IN_PROGRESS()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_TRANSFER_BANK_TO_WALLET

- **命名空间:** `NETSHOPPING`
- **Hash:** `0xD47A2C1BA117471D`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_TRANSFER_BANK_TO_WALLET(int charSlot, int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `charSlot` | `int` | `int` | - |
| `amount` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_TRANSFER_BANK_TO_WALLET_GET_STATUS

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x23789E777D14CE44`
- **Build:** `323`

**C# 签名:**
```csharp
int NET_GAMESERVER_TRANSFER_BANK_TO_WALLET_GET_STATUS()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Same as 0x350AA5EBC03D3BD2
```

---

### NET_GAMESERVER_TRANSFER_CASH_SET_TELEMETRY_NONCE_SEED

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x498C1E05CE5F7877`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_TRANSFER_CASH_SET_TELEMETRY_NONCE_SEED()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Used to be NETWORK_SHOP_CASH_TRANSFER_SET_TELEMETRY_NONCE_SEED
```

---

### NET_GAMESERVER_TRANSFER_WALLET_TO_BANK

- **命名空间:** `NETSHOPPING`
- **Hash:** `0xC2F7FE5309181C7D`
- **Build:** `323`

**C# 签名:**
```csharp
bool NET_GAMESERVER_TRANSFER_WALLET_TO_BANK(int charSlot, int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `charSlot` | `int` | `int` | - |
| `amount` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NET_GAMESERVER_TRANSFER_WALLET_TO_BANK_GET_STATUS

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x350AA5EBC03D3BD2`
- **Build:** `323`

**C# 签名:**
```csharp
int NET_GAMESERVER_TRANSFER_WALLET_TO_BANK_GET_STATUS()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Same as 0x23789E777D14CE44
```

---

### NET_GAMESERVER_USE_SERVER_TRANSACTIONS

- **命名空间:** `NETSHOPPING`
- **Hash:** `0x7D2708796355B20B`
- **Build:** `1290`

**C# 签名:**
```csharp
bool NET_GAMESERVER_USE_SERVER_TRANSACTIONS()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NET_TO_ENT

- **命名空间:** `NETWORK`
- **Hash:** `0xBFFEAB45A9A9094A`
- **JHash:** `0x5E149683`
- **Build:** `323`

**C# 签名:**
```csharp
int NET_TO_ENT(int netHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netHandle` | `int` | `int` | - |

**返回值:** `int` (Native: `Entity`)

**说明:**
```
gets the entity id of a network id
```

---

### NET_TO_OBJ

- **命名空间:** `NETWORK`
- **Hash:** `0xD8515F5FEA14CB3F`
- **JHash:** `0x27AA14D8`
- **Build:** `323`

**C# 签名:**
```csharp
int NET_TO_OBJ(int netHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netHandle` | `int` | `int` | - |

**返回值:** `int` (Native: `Object`)

**说明:**
```
gets the object id of a network id
```

---

### NET_TO_PED

- **命名空间:** `NETWORK`
- **Hash:** `0xBDCD95FC216A8B3E`
- **JHash:** `0x87717DD4`
- **Build:** `323`

**C# 签名:**
```csharp
int NET_TO_PED(int netHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netHandle` | `int` | `int` | - |

**返回值:** `int` (Native: `Ped`)

**说明:**
```
gets the ped id of a network id
```

---

### NET_TO_VEH

- **命名空间:** `NETWORK`
- **Hash:** `0x367B936610BA360C`
- **JHash:** `0x7E02FAEA`
- **Build:** `323`

**C# 签名:**
```csharp
int NET_TO_VEH(int netHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netHandle` | `int` | `int` | - |

**返回值:** `int` (Native: `Vehicle`)

---

### OBJ_TO_NET

- **命名空间:** `NETWORK`
- **Hash:** `0x99BFDC94A603E541`
- **JHash:** `0x1E05F29F`
- **Build:** `323`

**C# 签名:**
```csharp
int OBJ_TO_NET(int object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Lets objects spawn online simply do it like this:

int createdObject = OBJ_TO_NET(CREATE_OBJECT_NO_OFFSET(oball, pCoords.x, pCoords.y, pCoords.z, 1, 0, 0));
```

---

### OPEN_COMMERCE_STORE

- **命名空间:** `NETWORK`
- **Hash:** `0x58C21165F6545892`
- **JHash:** `0x365C50EE`
- **Build:** `323`

**C# 签名:**
```csharp
void OPEN_COMMERCE_STORE(string p0, string p1, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `const char*` | `string` | - |
| `p1` | `const char*` | `string` | - |
| `p2` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PARTICIPANT_ID

- **命名空间:** `NETWORK`
- **Hash:** `0x90986E8876CE0A83`
- **JHash:** `0x9C35A221`
- **Build:** `323`

**C# 签名:**
```csharp
int PARTICIPANT_ID()
```

**返回值:** `int` (Native: `Player`)

**说明:**
```
Return the local Participant ID
```

---

### PARTICIPANT_ID_TO_INT

- **命名空间:** `NETWORK`
- **Hash:** `0x57A3BDDAD8E5AA0A`
- **JHash:** `0x907498B0`
- **Build:** `323`

**C# 签名:**
```csharp
int PARTICIPANT_ID_TO_INT()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Return the local Participant ID.

This native is exactly the same as 'PARTICIPANT_ID' native.
```

---

### PED_TO_NET

- **命名空间:** `NETWORK`
- **Hash:** `0x0EDEC3C276198689`
- **JHash:** `0x86A0B759`
- **Build:** `323`

**C# 签名:**
```csharp
int PED_TO_NET(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
gets the network id of a ped
```

---

### REFRESH_PLAYER_LIST_STATS

- **命名空间:** `NETWORK`
- **Hash:** `0xE26CCFF8094D8C74`
- **JHash:** `0xF49C1533`
- **Build:** `323`

**C# 签名:**
```csharp
bool REFRESH_PLAYER_LIST_STATS(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### RELEASE_ALL_COMMERCE_ITEM_IMAGES

- **命名空间:** `NETWORK`
- **Hash:** `0x72D0706CD6CCDB58`
- **JHash:** `0xCA7A0A49`
- **Build:** `323`

**C# 签名:**
```csharp
void RELEASE_ALL_COMMERCE_ITEM_IMAGES()
```

**返回值:** `void` (Native: `void`)

---

### REMOTE_CHEATER_PLAYER_DETECTED

- **命名空间:** `NETWORK`
- **Hash:** `0x472841A026D26D8B`
- **Build:** `1103`

**C# 签名:**
```csharp
bool REMOTE_CHEATER_PLAYER_DETECTED(int player, int a, int b)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `a` | `int` | `int` | - |
| `b` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### REMOVE_ALL_STICKY_BOMBS_FROM_ENTITY

- **命名空间:** `NETWORK`
- **Hash:** `0x715135F4B82AC90D`
- **JHash:** `0xCEAE5AFC`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_ALL_STICKY_BOMBS_FROM_ENTITY(int entity, int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
entity must be a valid entity; ped can be NULL
```

---

### REQUEST_COMMERCE_ITEM_IMAGE

- **命名空间:** `NETWORK`
- **Hash:** `0xA2F952104FC6DD4B`
- **JHash:** `0x1FDC75DC`
- **Build:** `323`

**C# 签名:**
```csharp
bool REQUEST_COMMERCE_ITEM_IMAGE(int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### RESERVE_LOCAL_NETWORK_MISSION_OBJECTS

- **命名空间:** `NETWORK`
- **Hash:** `0x797F9C5E661D920E`
- **Build:** `1290`

**C# 签名:**
```csharp
void RESERVE_LOCAL_NETWORK_MISSION_OBJECTS(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESERVE_LOCAL_NETWORK_MISSION_PEDS

- **命名空间:** `NETWORK`
- **Hash:** `0x2C8DF5D129595281`
- **Build:** `1493`

**C# 签名:**
```csharp
void RESERVE_LOCAL_NETWORK_MISSION_PEDS(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESERVE_LOCAL_NETWORK_MISSION_VEHICLES

- **命名空间:** `NETWORK`
- **Hash:** `0x42613035157E4208`
- **Build:** `1103`

**C# 签名:**
```csharp
void RESERVE_LOCAL_NETWORK_MISSION_VEHICLES(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESERVE_NETWORK_MISSION_OBJECTS

- **命名空间:** `NETWORK`
- **Hash:** `0x4E5C93BD0C32FBF8`
- **JHash:** `0x391DF4F3`
- **Build:** `323`

**C# 签名:**
```csharp
void RESERVE_NETWORK_MISSION_OBJECTS(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESERVE_NETWORK_MISSION_PEDS

- **命名空间:** `NETWORK`
- **Hash:** `0xB60FEBA45333D36F`
- **JHash:** `0x54998C37`
- **Build:** `323`

**C# 签名:**
```csharp
void RESERVE_NETWORK_MISSION_PEDS(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESERVE_NETWORK_MISSION_VEHICLES

- **命名空间:** `NETWORK`
- **Hash:** `0x76B02E21ED27A469`
- **JHash:** `0x5062875E`
- **Build:** `323`

**C# 签名:**
```csharp
void RESERVE_NETWORK_MISSION_VEHICLES(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESET_GHOST_ALPHA

- **命名空间:** `NETWORK`
- **Hash:** `0x17330EBF2F2124A8`
- **Build:** `791`

**C# 签名:**
```csharp
void RESET_GHOST_ALPHA()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Resets the entity ghost alpha to the default value (128)
```

---

### RESET_STORE_NETWORK_GAME_TRACKING

- **命名空间:** `NETWORK`
- **Hash:** `0x444C4525ECE0A4B9`
- **JHash:** `0xCC7DCE24`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_STORE_NETWORK_GAME_TRACKING()
```

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_GHOSTED_FOR_GHOST_PLAYERS

- **命名空间:** `NETWORK`
- **Hash:** `0x4BA166079D658ED4`
- **Build:** `944`

**C# 签名:**
```csharp
void SET_ENTITY_GHOSTED_FOR_GHOST_PLAYERS(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_LOCALLY_INVISIBLE

- **命名空间:** `NETWORK`
- **Hash:** `0xE135A9FF3F5D05D8`
- **JHash:** `0x51ADCC5F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_LOCALLY_INVISIBLE(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Makes the provided entity visible for yourself for the current frame.
```

---

### SET_ENTITY_LOCALLY_VISIBLE

- **命名空间:** `NETWORK`
- **Hash:** `0x241E289B5C059EDC`
- **JHash:** `0x235A57B3`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_LOCALLY_VISIBLE(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_VISIBLE_IN_CUTSCENE

- **命名空间:** `NETWORK`
- **Hash:** `0xE0031D3C8F36AB82`
- **JHash:** `0xDBFB067B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_VISIBLE_IN_CUTSCENE(object p0, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GHOST_ALPHA

- **命名空间:** `NETWORK`
- **Hash:** `0x658500AE6D723A7E`
- **Build:** `791`

**C# 签名:**
```csharp
void SET_GHOST_ALPHA(int alpha)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `alpha` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Must be a value between 1 and 254
```

---

### SET_INVERT_GHOSTING

- **命名空间:** `NETWORK`
- **Hash:** `0xD7B6C73CAD419BCF`
- **Build:** `944`

**C# 签名:**
```csharp
void SET_INVERT_GHOSTING(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_LAST_VIEWED_SHOP_ITEM

- **命名空间:** `NETWORK`
- **Hash:** `0xFAE628F1E9ADB239`
- **JHash:** `0xD59A822B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_LAST_VIEWED_SHOP_ITEM(uint p0, int p1, uint p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Hash` | `uint` | - |
| `p1` | `int` | `int` | - |
| `p2` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### SET_LOCAL_PLAYER_AS_GHOST

- **命名空间:** `NETWORK`
- **Hash:** `0x5FFE9B4144F9712F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_LOCAL_PLAYER_AS_GHOST(bool toggle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_LOCAL_PLAYER_INVISIBLE_LOCALLY

- **命名空间:** `NETWORK`
- **Hash:** `0xE5F773C1A1D9D168`
- **JHash:** `0x764F6222`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_LOCAL_PLAYER_INVISIBLE_LOCALLY(bool bIncludePlayersVehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `bIncludePlayersVehicle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_LOCAL_PLAYER_VISIBLE_IN_CUTSCENE

- **命名空间:** `NETWORK`
- **Hash:** `0xD1065D68947E7B6E`
- **JHash:** `0x59F3479B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_LOCAL_PLAYER_VISIBLE_IN_CUTSCENE(bool p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_LOCAL_PLAYER_VISIBLE_LOCALLY

- **命名空间:** `NETWORK`
- **Hash:** `0x7619364C82D3BF14`
- **JHash:** `0x324B56DB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_LOCAL_PLAYER_VISIBLE_LOCALLY(bool bIncludePlayersVehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `bIncludePlayersVehicle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_NETWORK_CUTSCENE_ENTITIES

- **命名空间:** `NETWORK`
- **Hash:** `0xAAA553E7DD28A457`
- **JHash:** `0xFD0F7EDD`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_NETWORK_CUTSCENE_ENTITIES(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_NETWORK_ENABLE_HIGH_SPEED_EDGE_FALL_DETECTION

- **命名空间:** `NETWORK`
- **Hash:** `0x838DA0936A24ED4D`
- **Build:** `944`

**C# 签名:**
```csharp
void SET_NETWORK_ENABLE_HIGH_SPEED_EDGE_FALL_DETECTION(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Enables a periodic ShapeTest within the NetBlender and invokes rage::netBlenderLinInterp::GoStraightToTarget (or some functional wrapper).
```

---

### SET_NETWORK_ID_ALWAYS_EXISTS_FOR_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0xA8A024587329F36A`
- **JHash:** `0x4D15FDB1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_NETWORK_ID_ALWAYS_EXISTS_FOR_PLAYER(int netId, int player, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |
| `player` | `Player` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_NETWORK_ID_CAN_BE_REASSIGNED

- **命名空间:** `NETWORK`
- **Hash:** `0x9D724B400A7E8FFC`
- **Build:** `2189`

**C# 签名:**
```csharp
void SET_NETWORK_ID_CAN_BE_REASSIGNED(int netId, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
"No Reassign" in CPhysicalScriptGameStateDataNode
```

---

### SET_NETWORK_ID_CAN_MIGRATE

- **命名空间:** `NETWORK`
- **Hash:** `0x299EEB23175895FC`
- **JHash:** `0x47C8E5FF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_NETWORK_ID_CAN_MIGRATE(int netId, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Whether or not another player is allowed to take control of the entity
```

---

### SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES

- **命名空间:** `NETWORK`
- **Hash:** `0xE05E81A888FA63C8`
- **JHash:** `0x68D486B2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES(int netId, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_NETWORK_ID_PASS_CONTROL_IN_TUTORIAL

- **命名空间:** `NETWORK`
- **Hash:** `0x3FA36981311FA4FF`
- **JHash:** `0x00AE4E17`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_NETWORK_ID_PASS_CONTROL_IN_TUTORIAL(int netId, bool state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |
| `state` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_NETWORK_ID_VISIBLE_IN_CUTSCENE

- **命名空间:** `NETWORK`
- **Hash:** `0xA6928482543022B4`
- **JHash:** `0x199E75EF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_NETWORK_ID_VISIBLE_IN_CUTSCENE(int netId, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_NETWORK_ID_VISIBLE_IN_CUTSCENE_HACK

- **命名空间:** `NETWORK`
- **Hash:** `0x32EBD154CB6B8B99`
- **Build:** `505`

**C# 签名:**
```csharp
void SET_NETWORK_ID_VISIBLE_IN_CUTSCENE_HACK(int netId, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_NETWORK_ID_VISIBLE_IN_CUTSCENE_REMAIN_HACK

- **命名空间:** `NETWORK`
- **Hash:** `0x76B3F29D3F967692`
- **Build:** `2189`

**C# 签名:**
```csharp
void SET_NETWORK_ID_VISIBLE_IN_CUTSCENE_REMAIN_HACK(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_NETWORK_VEHICLE_AS_GHOST

- **命名空间:** `NETWORK`
- **Hash:** `0x6274C4712850841E`
- **JHash:** `0xEA235081`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_NETWORK_VEHICLE_AS_GHOST(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_NETWORK_VEHICLE_MAX_POSITION_DELTA_MULTIPLIER

- **命名空间:** `NETWORK`
- **Hash:** `0xA2A707979FE754DC`
- **Build:** `877`

**C# 签名:**
```csharp
void SET_NETWORK_VEHICLE_MAX_POSITION_DELTA_MULTIPLIER(int vehicle, float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
rage::netBlenderLinInterp::GetPositionMaxForUpdateLevel
```

---

### SET_NETWORK_VEHICLE_RESPOT_TIMER

- **命名空间:** `NETWORK`
- **Hash:** `0xEC51713AB6EC36E8`
- **JHash:** `0x2C30912D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_NETWORK_VEHICLE_RESPOT_TIMER(int netId, int time, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |
| `time` | `int` | `int` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_NON_PARTICIPANTS_OF_THIS_SCRIPT_AS_GHOSTS

- **命名空间:** `NETWORK`
- **Hash:** `0x13F1FCB111B820B0`
- **Build:** `877`

**C# 签名:**
```csharp
void SET_NON_PARTICIPANTS_OF_THIS_SCRIPT_AS_GHOSTS(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_INVISIBLE_LOCALLY

- **命名空间:** `NETWORK`
- **Hash:** `0x12B37D54667DB0B8`
- **JHash:** `0x18227209`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_INVISIBLE_LOCALLY(int player, bool bIncludePlayersVehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `bIncludePlayersVehicle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_VISIBLE_LOCALLY

- **命名空间:** `NETWORK`
- **Hash:** `0xFAA10F1FAFB11AF2`
- **JHash:** `0xBA2BB4B4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_VISIBLE_LOCALLY(int player, bool bIncludePlayersVehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `bIncludePlayersVehicle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_REMOTE_PLAYER_AS_GHOST

- **命名空间:** `NETWORK`
- **Hash:** `0xA7C511FA1C5BDA38`
- **Build:** `463`

**C# 签名:**
```csharp
void SET_REMOTE_PLAYER_AS_GHOST(int player, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Enables ghosting between specific players
```

---

### SET_REMOTE_PLAYER_VISIBLE_IN_CUTSCENE

- **命名空间:** `NETWORK`
- **Hash:** `0x96320E6549DAE7B4`
- **Build:** `2802`

**C# 签名:**
```csharp
void SET_REMOTE_PLAYER_VISIBLE_IN_CUTSCENE(int player, bool locallyVisible)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `locallyVisible` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_STORE_ENABLED

- **命名空间:** `NETWORK`
- **Hash:** `0x9641A9FF718E9C5E`
- **JHash:** `0xC1F6443B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_STORE_ENABLED(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Access to the store for shark cards etc...
```

---

### SHUTDOWN_AND_LAUNCH_SINGLE_PLAYER_GAME

- **命名空间:** `NETWORK`
- **Hash:** `0x593850C16A36B692`
- **JHash:** `0x92B7351C`
- **Build:** `323`

**C# 签名:**
```csharp
void SHUTDOWN_AND_LAUNCH_SINGLE_PLAYER_GAME()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Starts a new singleplayer game (at the prologue).
```

---

### SHUTDOWN_AND_LOAD_MOST_RECENT_SAVE

- **命名空间:** `NETWORK`
- **Hash:** `0x9ECA15ADFE141431`
- **Build:** `505`

**C# 签名:**
```csharp
bool SHUTDOWN_AND_LOAD_MOST_RECENT_SAVE()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
In singleplayer this will re-load your game.

In FiveM / GTA:Online this disconnects you from the session, and starts loading single player, however you still remain connected to the server (only if you're the host, if you're not then you also (most likely) get disconnected from the server) and other players will not be able to join until you exit the game.

You might need to DoScreenFadeIn and ShutdownLoadingScreen otherwise you probably won't end up loading into SP at all.

Somewhat related note: opening the pause menu after loading into this 'singleplayer' mode crashes the game.
```

---

### SHUTDOWN_SESSION_CLEARS_AUTO_MULTIPLAYER

- **命名空间:** `LOBBY`
- **Hash:** `0xFA1E0E893D915215`
- **JHash:** `0x5C350D78`
- **Build:** `323`

**C# 签名:**
```csharp
void SHUTDOWN_SESSION_CLEARS_AUTO_MULTIPLAYER(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### TEXTURE_DOWNLOAD_GET_NAME

- **命名空间:** `NETWORK`
- **Hash:** `0x3448505B6E35262D`
- **JHash:** `0xA40EF65A`
- **Build:** `323`

**C# 签名:**
```csharp
string TEXTURE_DOWNLOAD_GET_NAME(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

---

### TEXTURE_DOWNLOAD_HAS_FAILED

- **命名空间:** `NETWORK`
- **Hash:** `0x5776ED562C134687`
- **JHash:** `0xE4547765`
- **Build:** `323`

**C# 签名:**
```csharp
bool TEXTURE_DOWNLOAD_HAS_FAILED(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### TEXTURE_DOWNLOAD_RELEASE

- **命名空间:** `NETWORK`
- **Hash:** `0x487EB90B98E9FB19`
- **JHash:** `0xEE8D9E70`
- **Build:** `323`

**C# 签名:**
```csharp
void TEXTURE_DOWNLOAD_RELEASE(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### TEXTURE_DOWNLOAD_REQUEST

- **命名空间:** `NETWORK`
- **Hash:** `0x16160DA74A8E74A2`
- **JHash:** `0xAD546CC3`
- **Build:** `323`

**C# 签名:**
```csharp
int TEXTURE_DOWNLOAD_REQUEST(ref object gamerHandle, string filePath, string name, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |
| `filePath` | `const char*` | `string` | - |
| `name` | `const char*` | `string` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `int`)

---

### TITLE_TEXTURE_DOWNLOAD_REQUEST

- **命名空间:** `NETWORK`
- **Hash:** `0x0B203B4AFDE53A4F`
- **JHash:** `0x1856D008`
- **Build:** `323`

**C# 签名:**
```csharp
int TITLE_TEXTURE_DOWNLOAD_REQUEST(string filePath, string name, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `filePath` | `const char*` | `string` | - |
| `name` | `const char*` | `string` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `int`)

---

### TRIGGER_COMMERCE_DATA_FETCH

- **命名空间:** `NETWORK`
- **Hash:** `0xB606E6CC59664972`
- **JHash:** `0x866D1B67`
- **Build:** `323`

**C# 签名:**
```csharp
void TRIGGER_COMMERCE_DATA_FETCH(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Does nothing (it's a nullsub).
```

---

### UGC_CANCEL_QUERY

- **命名空间:** `NETWORK`
- **Hash:** `0xE9B99B6853181409`
- **JHash:** `0x021D5A94`
- **Build:** `323`

**C# 签名:**
```csharp
void UGC_CANCEL_QUERY()
```

**返回值:** `void` (Native: `void`)

---

### UGC_CLEAR_CREATE_RESULT

- **命名空间:** `NETWORK`
- **Hash:** `0x17440AA15D1D3739`
- **JHash:** `0x133FF2D5`
- **Build:** `323`

**C# 签名:**
```csharp
void UGC_CLEAR_CREATE_RESULT()
```

**返回值:** `void` (Native: `void`)

---

### UGC_CLEAR_MODIFY_RESULT

- **命名空间:** `NETWORK`
- **Hash:** `0xA1E5E0204A6FCC70`
- **JHash:** `0x405ECA16`
- **Build:** `323`

**C# 签名:**
```csharp
void UGC_CLEAR_MODIFY_RESULT()
```

**返回值:** `void` (Native: `void`)

---

### UGC_CLEAR_OFFLINE_QUERY

- **命名空间:** `NETWORK`
- **Hash:** `0x61A885D3F7CFEE9A`
- **JHash:** `0xE13C1F7F`
- **Build:** `323`

**C# 签名:**
```csharp
void UGC_CLEAR_OFFLINE_QUERY()
```

**返回值:** `void` (Native: `void`)

---

### UGC_CLEAR_QUERY_RESULTS

- **命名空间:** `NETWORK`
- **Hash:** `0xBA96394A0EECFA65`
- **JHash:** `0x0D35DD93`
- **Build:** `323`

**C# 签名:**
```csharp
void UGC_CLEAR_QUERY_RESULTS()
```

**返回值:** `void` (Native: `void`)

---

### UGC_COPY_CONTENT

- **命名空间:** `NETWORK`
- **Hash:** `0x152D90E4C1B4738A`
- **JHash:** `0x08243B79`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_COPY_CONTENT(ref object p0, ref object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_DID_CREATE_SUCCEED

- **命名空间:** `NETWORK`
- **Hash:** `0x24E4E51FC16305F9`
- **JHash:** `0x742075FE`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_DID_CREATE_SUCCEED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_DID_DESCRIPTION_REQUEST_SUCCEED

- **命名空间:** `NETWORK`
- **Hash:** `0x162C23CA83ED0A62`
- **JHash:** `0xB3BBD241`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_DID_DESCRIPTION_REQUEST_SUCCEED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_DID_GET_SUCCEED

- **命名空间:** `NETWORK`
- **Hash:** `0x941E5306BCD7C2C7`
- **JHash:** `0x3970B0DA`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_DID_GET_SUCCEED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_DID_MODIFY_SUCCEED

- **命名空间:** `NETWORK`
- **Hash:** `0x793FF272D5B365F4`
- **JHash:** `0xF0211AC1`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_DID_MODIFY_SUCCEED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_DID_QUERY_CREATORS_SUCCEED

- **命名空间:** `NETWORK`
- **Hash:** `0x4D02279C83BE69FE`
- **JHash:** `0xA7F3F82B`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_DID_QUERY_CREATORS_SUCCEED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_GET_BOOKMARKED_CONTENT

- **命名空间:** `NETWORK`
- **Hash:** `0xD5A4B59980401588`
- **JHash:** `0x4609D596`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_GET_BOOKMARKED_CONTENT(object p0, object p1, string p2, ref object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `const char*` | `string` | - |
| `p3` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_GET_CACHED_DESCRIPTION

- **命名空间:** `NETWORK`
- **Hash:** `0x40F7E66472DF3E5C`
- **JHash:** `0x70A2845C`
- **Build:** `323`

**C# 签名:**
```csharp
string UGC_GET_CACHED_DESCRIPTION(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `string` (Native: `const char*`)

---

### UGC_GET_CONTENT_CATEGORY

- **命名空间:** `NETWORK`
- **Hash:** `0xA7BAB11E7C9C6C5A`
- **JHash:** `0x5E8A7559`
- **Build:** `323`

**C# 签名:**
```csharp
int UGC_GET_CONTENT_CATEGORY(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### UGC_GET_CONTENT_CREATED_BY_LOCAL_PLAYER

- **命名空间:** `NETWORK`
- **Hash:** `0x8C8D2739BA44AF0F`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_GET_CONTENT_CREATED_BY_LOCAL_PLAYER(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_GET_CONTENT_CREATOR_GAMER_HANDLE

- **命名空间:** `NETWORK`
- **Hash:** `0x584770794D758C18`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_GET_CONTENT_CREATOR_GAMER_HANDLE(int p0, ref object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_GET_CONTENT_DESCRIPTION

- **命名空间:** `NETWORK`
- **Hash:** `0x4A56710BAB5C4DB4`
- **Build:** `3407`

**C# 签名:**
```csharp
string UGC_GET_CONTENT_DESCRIPTION(int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

---

### UGC_GET_CONTENT_DESCRIPTION_HASH

- **命名空间:** `NETWORK`
- **Hash:** `0x7CF0448787B23758`
- **JHash:** `0x91534C6E`
- **Build:** `323`

**C# 签名:**
```csharp
int UGC_GET_CONTENT_DESCRIPTION_HASH(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### UGC_GET_CONTENT_FILE_VERSION

- **命名空间:** `NETWORK`
- **Hash:** `0x37025B27D9B658B1`
- **JHash:** `0xFF7D44E6`
- **Build:** `323`

**C# 签名:**
```csharp
int UGC_GET_CONTENT_FILE_VERSION(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### UGC_GET_CONTENT_HASH

- **命名空间:** `NETWORK`
- **Hash:** `0x3A17A27D75C74887`
- **JHash:** `0x8E1D8F78`
- **Build:** `323`

**C# 签名:**
```csharp
uint UGC_GET_CONTENT_HASH()
```

**返回值:** `uint` (Native: `Hash`)

---

### UGC_GET_CONTENT_HAS_HI_RES_PHOTO

- **命名空间:** `NETWORK`
- **Hash:** `0x7FCC39C46C3C03BD`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_GET_CONTENT_HAS_HI_RES_PHOTO(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_GET_CONTENT_HAS_LO_RES_PHOTO

- **命名空间:** `NETWORK`
- **Hash:** `0x1D610EB0FEA716D9`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_GET_CONTENT_HAS_LO_RES_PHOTO(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_GET_CONTENT_HAS_PLAYER_BOOKMARKED

- **命名空间:** `NETWORK`
- **Hash:** `0x993CBE59D350D225`
- **JHash:** `0x0DEB3F5A`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_GET_CONTENT_HAS_PLAYER_BOOKMARKED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_GET_CONTENT_HAS_PLAYER_RECORD

- **命名空间:** `NETWORK`
- **Hash:** `0x70EA8DA57840F9BE`
- **JHash:** `0x11DC0F27`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_GET_CONTENT_HAS_PLAYER_RECORD(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_GET_CONTENT_ID

- **命名空间:** `NETWORK`
- **Hash:** `0x55AA95F481D694D2`
- **JHash:** `0x331AEABF`
- **Build:** `323`

**C# 签名:**
```csharp
string UGC_GET_CONTENT_ID(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Return the mission id of a job.
```

---

### UGC_GET_CONTENT_IS_PUBLISHED

- **命名空间:** `NETWORK`
- **Hash:** `0x3054F114121C21EA`
- **JHash:** `0xA850DDE1`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_GET_CONTENT_IS_PUBLISHED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_GET_CONTENT_IS_USING_SC_NICKNAME

- **命名空间:** `NETWORK`
- **Hash:** `0xAEAB987727C5A8A4`
- **JHash:** `0x9FEEAA9C`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_GET_CONTENT_IS_USING_SC_NICKNAME(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_GET_CONTENT_IS_VERIFIED

- **命名空间:** `NETWORK`
- **Hash:** `0xA9240A96C74CCA13`
- **JHash:** `0x8F6754AE`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_GET_CONTENT_IS_VERIFIED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_GET_CONTENT_LANGUAGE

- **命名空间:** `NETWORK`
- **Hash:** `0x32DD916F3F7C9672`
- **JHash:** `0xA2C5BD9D`
- **Build:** `323`

**C# 签名:**
```csharp
int UGC_GET_CONTENT_LANGUAGE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### UGC_GET_CONTENT_NAME

- **命名空间:** `NETWORK`
- **Hash:** `0xBF09786A7FCAB582`
- **JHash:** `0xA5A0C695`
- **Build:** `323`

**C# 签名:**
```csharp
string UGC_GET_CONTENT_NAME(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `string` (Native: `const char*`)

---

### UGC_GET_CONTENT_NUM

- **命名空间:** `NETWORK`
- **Hash:** `0xE0A6138401BCB837`
- **JHash:** `0x2DE69817`
- **Build:** `323`

**C# 签名:**
```csharp
int UGC_GET_CONTENT_NUM()
```

**返回值:** `int` (Native: `int`)

---

### UGC_GET_CONTENT_PATH

- **命名空间:** `NETWORK`
- **Hash:** `0xBAF6BABF9E7CCC13`
- **JHash:** `0x744A9EA5`
- **Build:** `323`

**C# 签名:**
```csharp
string UGC_GET_CONTENT_PATH(int p0, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

---

### UGC_GET_CONTENT_RATING

- **命名空间:** `NETWORK`
- **Hash:** `0x1ACCFBA3D8DAB2EE`
- **JHash:** `0x1E34953F`
- **Build:** `323`

**C# 签名:**
```csharp
float UGC_GET_CONTENT_RATING(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `float` (Native: `float`)

---

### UGC_GET_CONTENT_RATING_COUNT

- **命名空间:** `NETWORK`
- **Hash:** `0x759299C5BB31D2A9`
- **JHash:** `0x771FE190`
- **Build:** `323`

**C# 签名:**
```csharp
int UGC_GET_CONTENT_RATING_COUNT(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### UGC_GET_CONTENT_RATING_NEGATIVE_COUNT

- **命名空间:** `NETWORK`
- **Hash:** `0x4E548C0D7AE39FF9`
- **JHash:** `0x41A0FB02`
- **Build:** `323`

**C# 签名:**
```csharp
int UGC_GET_CONTENT_RATING_NEGATIVE_COUNT(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### UGC_GET_CONTENT_RATING_POSITIVE_COUNT

- **命名空间:** `NETWORK`
- **Hash:** `0x87E5C46C187FE0AE`
- **JHash:** `0x3276D9D3`
- **Build:** `323`

**C# 签名:**
```csharp
int UGC_GET_CONTENT_RATING_POSITIVE_COUNT(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### UGC_GET_CONTENT_TOTAL

- **命名空间:** `NETWORK`
- **Hash:** `0x769951E2455E2EB5`
- **JHash:** `0x81BD8D3B`
- **Build:** `323`

**C# 签名:**
```csharp
int UGC_GET_CONTENT_TOTAL()
```

**返回值:** `int` (Native: `int`)

---

### UGC_GET_CONTENT_UPDATED_DATE

- **命名空间:** `NETWORK`
- **Hash:** `0xCFD115B373C0DF63`
- **JHash:** `0xA19A238D`
- **Build:** `323`

**C# 签名:**
```csharp
void UGC_GET_CONTENT_UPDATED_DATE(object p0, ref object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### UGC_GET_CONTENT_USER_ID

- **命名空间:** `NETWORK`
- **Hash:** `0xCD67AD041A394C9C`
- **JHash:** `0x8F3137E6`
- **Build:** `323`

**C# 签名:**
```csharp
string UGC_GET_CONTENT_USER_ID(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

---

### UGC_GET_CONTENT_USER_NAME

- **命名空间:** `NETWORK`
- **Hash:** `0x703F12425ECA8BF5`
- **JHash:** `0xB9137BA7`
- **Build:** `323`

**C# 签名:**
```csharp
string UGC_GET_CONTENT_USER_NAME(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `string` (Native: `const char*`)

---

### UGC_GET_CREATE_CONTENT_ID

- **命名空间:** `NETWORK`
- **Hash:** `0xC55A0B40FFB1ED23`
- **JHash:** `0x82146BE9`
- **Build:** `323`

**C# 签名:**
```csharp
string UGC_GET_CREATE_CONTENT_ID()
```

**返回值:** `string` (Native: `const char*`)

---

### UGC_GET_CREATE_RESULT

- **命名空间:** `NETWORK`
- **Hash:** `0xFBC5E768C7A77A6A`
- **JHash:** `0xCE569932`
- **Build:** `323`

**C# 签名:**
```csharp
int UGC_GET_CREATE_RESULT()
```

**返回值:** `int` (Native: `int`)

---

### UGC_GET_CREATORS_BY_USER_ID

- **命名空间:** `NETWORK`
- **Hash:** `0xB746D20B17F2A229`
- **JHash:** `0x9567392B`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_GET_CREATORS_BY_USER_ID(ref object p0, ref object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_GET_CREATOR_NUM

- **命名空间:** `NETWORK`
- **Hash:** `0x597F8DBA9B206FC7`
- **JHash:** `0x410C61D1`
- **Build:** `323`

**C# 签名:**
```csharp
int UGC_GET_CREATOR_NUM()
```

**返回值:** `int` (Native: `int`)

---

### UGC_GET_CREW_CONTENT

- **命名空间:** `NETWORK`
- **Hash:** `0x9F6E2821885CAEE2`
- **JHash:** `0xA6D8B798`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_GET_CREW_CONTENT(object p0, object p1, object p2, string p3, ref object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `const char*` | `string` | - |
| `p4` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_GET_FRIEND_CONTENT

- **命名空间:** `NETWORK`
- **Hash:** `0xF9E1CCAE8BA4C281`
- **JHash:** `0x9EFBD5D1`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_GET_FRIEND_CONTENT(object p0, object p1, string p2, ref object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `const char*` | `string` | - |
| `p3` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_GET_GET_BY_CATEGORY

- **命名空间:** `NETWORK`
- **Hash:** `0x678BB03C1A3BD51E`
- **JHash:** `0x67E74842`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_GET_GET_BY_CATEGORY(object p0, object p1, object p2, string p3, ref object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `const char*` | `string` | - |
| `p4` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_GET_GET_BY_CONTENT_ID

- **命名空间:** `NETWORK`
- **Hash:** `0x815E5E3073DA1D67`
- **JHash:** `0xE123C7AC`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_GET_GET_BY_CONTENT_ID(string contentId, string contentTypeName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `contentId` | `const char*` | `string` | - |
| `contentTypeName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_GET_GET_BY_CONTENT_IDS

- **命名空间:** `NETWORK`
- **Hash:** `0xB8322EEB38BE7C26`
- **JHash:** `0x22C33603`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_GET_GET_BY_CONTENT_IDS(ref object data, int dataCount, string contentTypeName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |
| `dataCount` | `int` | `int` | - |
| `contentTypeName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_GET_MODIFY_RESULT

- **命名空间:** `NETWORK`
- **Hash:** `0x5A0A3D1A186A5508`
- **JHash:** `0x1F0DD8AF`
- **Build:** `323`

**C# 签名:**
```csharp
int UGC_GET_MODIFY_RESULT()
```

**返回值:** `int` (Native: `int`)

---

### UGC_GET_MOST_RECENTLY_CREATED_CONTENT

- **命名空间:** `NETWORK`
- **Hash:** `0xA7862BC5ED1DFD7E`
- **JHash:** `0x37F5BD93`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_GET_MOST_RECENTLY_CREATED_CONTENT(object p0, object p1, ref object p2, ref object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any*` | `ref object` | - |
| `p3` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_GET_MOST_RECENTLY_PLAYED_CONTENT

- **命名空间:** `NETWORK`
- **Hash:** `0x97A770BEEF227E2B`
- **JHash:** `0x1CFB3F51`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_GET_MOST_RECENTLY_PLAYED_CONTENT(object p0, object p1, ref object p2, ref object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any*` | `ref object` | - |
| `p3` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_GET_MY_CONTENT

- **命名空间:** `NETWORK`
- **Hash:** `0x3195F8DD0D531052`
- **JHash:** `0x4C2C0D1F`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_GET_MY_CONTENT(object p0, object p1, string p2, ref object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `const char*` | `string` | - |
| `p3` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_GET_QUERY_RESULT

- **命名空间:** `NETWORK`
- **Hash:** `0xEDF7F927136C224B`
- **JHash:** `0xCC2356E3`
- **Build:** `323`

**C# 签名:**
```csharp
int UGC_GET_QUERY_RESULT()
```

**返回值:** `int` (Native: `int`)

---

### UGC_GET_ROOT_CONTENT_ID

- **命名空间:** `NETWORK`
- **Hash:** `0xC0173D6BFF4E0348`
- **JHash:** `0x0E5E8E5C`
- **Build:** `323`

**C# 签名:**
```csharp
string UGC_GET_ROOT_CONTENT_ID(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Return the root content id of a job.
```

---

### UGC_GET_TOP_RATED_CONTENT

- **命名空间:** `NETWORK`
- **Hash:** `0x5324A0E3E4CE3570`
- **JHash:** `0x87D1E6BD`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_GET_TOP_RATED_CONTENT(object p0, object p1, ref object p2, ref object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any*` | `ref object` | - |
| `p3` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_HAS_CREATE_FINISHED

- **命名空间:** `NETWORK`
- **Hash:** `0x5E24341A7F92A74B`
- **JHash:** `0xE69E8D0D`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_HAS_CREATE_FINISHED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_HAS_DESCRIPTION_REQUEST_FINISHED

- **命名空间:** `NETWORK`
- **Hash:** `0xEBFA8D50ADDC54C4`
- **JHash:** `0xF50BC67A`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_HAS_DESCRIPTION_REQUEST_FINISHED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_HAS_GET_FINISHED

- **命名空间:** `NETWORK`
- **Hash:** `0x02ADA21EA2F6918F`
- **JHash:** `0x50296140`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_HAS_GET_FINISHED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_HAS_MODIFY_FINISHED

- **命名空间:** `NETWORK`
- **Hash:** `0x299EF3C576773506`
- **JHash:** `0x611E0BE2`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_HAS_MODIFY_FINISHED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_HAS_PERMISSION_TO_WRITE

- **命名空间:** `NETWORK`
- **Hash:** `0xC33E7CBC06EC1A8D`
- **Build:** `3095`

**C# 签名:**
```csharp
bool UGC_HAS_PERMISSION_TO_WRITE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_HAS_QUERY_CREATORS_FINISHED

- **命名空间:** `NETWORK`
- **Hash:** `0x63B406D7884BFA95`
- **JHash:** `0xF79FFF3C`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_HAS_QUERY_CREATORS_FINISHED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_IS_CREATING

- **命名空间:** `NETWORK`
- **Hash:** `0x9FEDF86898F100E9`
- **JHash:** `0x798D6C27`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_IS_CREATING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_IS_DESCRIPTION_REQUEST_IN_PROGRESS

- **命名空间:** `NETWORK`
- **Hash:** `0x2D5DC831176D0114`
- **JHash:** `0xA69AE16C`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_IS_DESCRIPTION_REQUEST_IN_PROGRESS(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_IS_GETTING

- **命名空间:** `NETWORK`
- **Hash:** `0xD53ACDBEF24A46E8`
- **JHash:** `0x4908A514`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_IS_GETTING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_IS_LANGUAGE_SUPPORTED

- **命名空间:** `NETWORK`
- **Hash:** `0xF53E48461B71EECB`
- **JHash:** `0xB4668B23`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_IS_LANGUAGE_SUPPORTED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_IS_MODIFYING

- **命名空间:** `NETWORK`
- **Hash:** `0x45E816772E93A9DB`
- **JHash:** `0x8E664EFD`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_IS_MODIFYING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_LOAD_OFFLINE_QUERY

- **命名空间:** `NETWORK`
- **Hash:** `0x5CAE833B0EE0C500`
- **JHash:** `0x0D4F845D`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_LOAD_OFFLINE_QUERY(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_PUBLISH

- **命名空间:** `NETWORK`
- **Hash:** `0x1DE0F5F50D723CAA`
- **JHash:** `0xAD334B40`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_PUBLISH(string contentId, string baseContentId, string contentTypeName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `contentId` | `const char*` | `string` | - |
| `baseContentId` | `const char*` | `string` | - |
| `contentTypeName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_QUERY_BY_CATEGORY

- **命名空间:** `NETWORK`
- **Hash:** `0x692D58DF40657E8C`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_QUERY_BY_CATEGORY(object p0, object p1, object p2, string p3, object p4, bool p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `const char*` | `string` | - |
| `p4` | `Any` | `object` | - |
| `p5` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_QUERY_BY_CONTENT_ID

- **命名空间:** `NETWORK`
- **Hash:** `0x158EC424F35EC469`
- **JHash:** `0xDED82A6E`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_QUERY_BY_CONTENT_ID(string contentId, bool latestVersion, string contentTypeName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `contentId` | `const char*` | `string` | - |
| `latestVersion` | `BOOL` | `bool` | - |
| `contentTypeName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_QUERY_BY_CONTENT_IDS

- **命名空间:** `NETWORK`
- **Hash:** `0xC7397A83F7A2A462`
- **JHash:** `0x47B3C35E`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_QUERY_BY_CONTENT_IDS(ref object data, int count, bool latestVersion, string contentTypeName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |
| `count` | `int` | `int` | - |
| `latestVersion` | `BOOL` | `bool` | - |
| `contentTypeName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_QUERY_MOST_RECENTLY_CREATED_CONTENT

- **命名空间:** `NETWORK`
- **Hash:** `0x6D4CB481FAC835E8`
- **JHash:** `0x40CF0783`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_QUERY_MOST_RECENTLY_CREATED_CONTENT(int offset, int count, string contentTypeName, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `offset` | `int` | `int` | - |
| `count` | `int` | `int` | - |
| `contentTypeName` | `const char*` | `string` | - |
| `p3` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_QUERY_MY_CONTENT

- **命名空间:** `NETWORK`
- **Hash:** `0x9BF438815F5D96EA`
- **JHash:** `0xCBA7242F`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_QUERY_MY_CONTENT(object p0, object p1, ref object p2, object p3, object p4, object p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any*` | `ref object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |
| `p5` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_RELEASE_ALL_CACHED_DESCRIPTIONS

- **命名空间:** `NETWORK`
- **Hash:** `0x68103E2247887242`
- **JHash:** `0x0095DB71`
- **Build:** `323`

**C# 签名:**
```csharp
void UGC_RELEASE_ALL_CACHED_DESCRIPTIONS()
```

**返回值:** `void` (Native: `void`)

---

### UGC_RELEASE_CACHED_DESCRIPTION

- **命名空间:** `NETWORK`
- **Hash:** `0x5A34CD9C3C5BEC44`
- **JHash:** `0x346B506C`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_RELEASE_CACHED_DESCRIPTION(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_REQUEST_CACHED_DESCRIPTION

- **命名空间:** `NETWORK`
- **Hash:** `0x5E0165278F6339EE`
- **JHash:** `0x1C4F9FDB`
- **Build:** `323`

**C# 签名:**
```csharp
int UGC_REQUEST_CACHED_DESCRIPTION(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### UGC_REQUEST_CONTENT_DATA_FROM_INDEX

- **命名空间:** `NETWORK`
- **Hash:** `0x171DF6A0C07FB3DC`
- **JHash:** `0x84315226`
- **Build:** `323`

**C# 签名:**
```csharp
int UGC_REQUEST_CONTENT_DATA_FROM_INDEX(int p0, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### UGC_REQUEST_CONTENT_DATA_FROM_PARAMS

- **命名空间:** `NETWORK`
- **Hash:** `0x7FD2990AF016795E`
- **JHash:** `0x38FC2EEB`
- **Build:** `323`

**C# 签名:**
```csharp
int UGC_REQUEST_CONTENT_DATA_FROM_PARAMS(string contentTypeName, string contentId, int p2, int p3, int p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `contentTypeName` | `const char*` | `string` | - |
| `contentId` | `const char*` | `string` | - |
| `p2` | `int` | `int` | - |
| `p3` | `int` | `int` | - |
| `p4` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### UGC_SET_BOOKMARKED

- **命名空间:** `NETWORK`
- **Hash:** `0x274A1519DFC1094F`
- **JHash:** `0x980D45D7`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_SET_BOOKMARKED(string contentId, bool bookmarked, string contentTypeName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `contentId` | `const char*` | `string` | - |
| `bookmarked` | `BOOL` | `bool` | - |
| `contentTypeName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_SET_DELETED

- **命名空间:** `NETWORK`
- **Hash:** `0xD05D1A6C74DA3498`
- **JHash:** `0x48CCC328`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_SET_DELETED(ref object p0, bool p1, string p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### UGC_SET_QUERY_DATA_FROM_OFFLINE

- **命名空间:** `NETWORK`
- **Hash:** `0xF98DDE0A8ED09323`
- **JHash:** `0x213C6D36`
- **Build:** `323`

**C# 签名:**
```csharp
void UGC_SET_QUERY_DATA_FROM_OFFLINE(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### UGC_SET_USING_OFFLINE_CONTENT

- **命名空间:** `NETWORK`
- **Hash:** `0xFD75DABC0957BF33`
- **JHash:** `0x511E6F50`
- **Build:** `323`

**C# 签名:**
```csharp
void UGC_SET_USING_OFFLINE_CONTENT(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### UGC_TEXTURE_DOWNLOAD_REQUEST

- **命名空间:** `NETWORK`
- **Hash:** `0x308F96458B7087CC`
- **JHash:** `0x68C9AF69`
- **Build:** `323`

**C# 签名:**
```csharp
int UGC_TEXTURE_DOWNLOAD_REQUEST(string p0, int p1, int p2, int p3, string p4, bool p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `const char*` | `string` | - |
| `p1` | `int` | `int` | - |
| `p2` | `int` | `int` | - |
| `p3` | `int` | `int` | - |
| `p4` | `const char*` | `string` | - |
| `p5` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `int`)

---

### UGC_WAS_QUERY_FORCE_CANCELLED

- **命名空间:** `NETWORK`
- **Hash:** `0xC87E740D9F3872CC`
- **JHash:** `0xC1487110`
- **Build:** `323`

**C# 签名:**
```csharp
bool UGC_WAS_QUERY_FORCE_CANCELLED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### USE_PLAYER_COLOUR_INSTEAD_OF_TEAM_COLOUR

- **命名空间:** `NETWORK`
- **Hash:** `0x77758139EC9B66C7`
- **JHash:** `0x4DD46DAE`
- **Build:** `323`

**C# 签名:**
```csharp
void USE_PLAYER_COLOUR_INSTEAD_OF_TEAM_COLOUR(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### VEH_TO_NET

- **命名空间:** `NETWORK`
- **Hash:** `0xB4C94523F023419C`
- **JHash:** `0xF17634EB`
- **Build:** `323`

**C# 签名:**
```csharp
int VEH_TO_NET(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
calls from vehicle to net.

```

---

### _NETWORK_CAN_TEXT_FROM_GAMER_BE_VIEWED

- **命名空间:** `NETWORK`
- **Hash:** `0x9F633448E4C73207`
- **Build:** `3258`

**C# 签名:**
```csharp
bool _NETWORK_CAN_TEXT_FROM_GAMER_BE_VIEWED(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
NETWORK_CAN_*
```

---

### _NETWORK_CLEAR_CLOCK_SYNC_TIME_OVERRIDE

- **命名空间:** `NETWORK`
- **Hash:** `0x0C1BF187985B15C8`
- **Build:** `3717`

**C# 签名:**
```csharp
void _NETWORK_CLEAR_CLOCK_SYNC_TIME_OVERRIDE(bool startGlobalTransition, int transitionTime)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `startGlobalTransition` | `BOOL` | `bool` | - |
| `transitionTime` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_CLEAR_TUNABLES_REGISTRATION_CONTEXTS

- **命名空间:** `NETWORK`
- **Hash:** `0x0C87C83C8950432B`
- **Build:** `3258`

**C# 签名:**
```csharp
void _NETWORK_CLEAR_TUNABLES_REGISTRATION_CONTEXTS()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Clears tunable contexts that were set up using _NETWORK_SET_TUNABLES_REGISTRATION_CONTEXTS
```

---

### _NETWORK_CONFIRM_GAME_RESTART

- **命名空间:** `NETWORK`
- **Hash:** `0x0A141818CA2311AD`
- **Build:** `3323`

**C# 签名:**
```csharp
void _NETWORK_CONFIRM_GAME_RESTART()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
If the restart reason is 4 (BE_RESTART_EF_DISABLED_WITH_BE), will cause the game to exit with exit code 622011. Otherwise exits with code 622010. Has no effect when a restart hasn't been requested (reason == 0 or reason > 6).

Note that this 'confirmation' itself does not restart the game, a call to QUIT_GAME or similar is required afterwards.
```

---

### _NETWORK_DOES_COMMUNICATION_GROUP_HAVE_PERMISSION

- **命名空间:** `NETWORK`
- **Hash:** `0xDBDF80673BBA3D65`
- **Build:** `3095`

**C# 签名:**
```csharp
bool _NETWORK_DOES_COMMUNICATION_GROUP_HAVE_PERMISSION(int communicationType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `communicationType` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
communicationType: 0 = VOICE; 1 = TEXT_CHAT; 2 = TEXT_MESSAGE; 3 = EMAIL; 4 = USER_CONTENT; 5 = USER_TEXT
```

---

### _NETWORK_DOES_COMMUNICATION_GROUP_HAVE_SETTINGS_ENABLED

- **命名空间:** `NETWORK`
- **Hash:** `0x20C12650830A64EC`
- **Build:** `3570`

**C# 签名:**
```csharp
bool _NETWORK_DOES_COMMUNICATION_GROUP_HAVE_SETTINGS_ENABLED(int communicationType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `communicationType` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### _NETWORK_GET_ACCESS_CODE_LABEL_BODY

- **命名空间:** `NETWORK`
- **Hash:** `0x214CA1730793EBA8`
- **Build:** `3570`

**C# 签名:**
```csharp
string _NETWORK_GET_ACCESS_CODE_LABEL_BODY(int accessCode)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `accessCode` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

---

### _NETWORK_GET_ACCESS_CODE_LABEL_HEADING

- **命名空间:** `NETWORK`
- **Hash:** `0x967E6FB554E1B6DE`
- **Build:** `3570`

**C# 签名:**
```csharp
string _NETWORK_GET_ACCESS_CODE_LABEL_HEADING(int accessCode)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `accessCode` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

---

### _NETWORK_GET_BATTLEYE_ERROR_MESSAGE_LABEL

- **命名空间:** `NETWORK`
- **Hash:** `0xCBA50F371E45B90D`
- **Build:** `3323`

**C# 签名:**
```csharp
string _NETWORK_GET_BATTLEYE_ERROR_MESSAGE_LABEL(int errorCode)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `errorCode` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
0x20211000 = HUD_BE_ERROR_FAILED_UNKNOWN
0x20212000 = HUD_BE_ERROR_FAILED_CLIENT_INIT
0x20213000 = HUD_BE_ERROR_FAILED_SERVER_INIT
0x20214000 = HUD_BE_ERROR_FAILED_AUTH_ATTEMPTS
0x20215000 = HUD_BE_ERROR_UNTRUSTED_HOST
0x20216000 = HUD_BE_ERROR_KICKED
0x20217000 = HUD_BE_ERROR_BANNED
0x50140000 = HUD_BE_BLOCK_BANNED

Note: an invalid error code returns a null pointer!
```

---

### _NETWORK_GET_BROADCAST_DATA_HOST_UPDATE_SIZE

- **命名空间:** `NETWORK`
- **Hash:** `0xE448693B3EA3B92C`
- **Build:** `3586`

**C# 签名:**
```csharp
int _NETWORK_GET_BROADCAST_DATA_HOST_UPDATE_SIZE(uint scriptNameHash, int instance, uint positionHash, int handlerNum)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scriptNameHash` | `Hash` | `uint` | - |
| `instance` | `int` | `int` | - |
| `positionHash` | `Hash` | `uint` | - |
| `handlerNum` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### _NETWORK_GET_BROADCAST_DATA_PLAYER_UPDATE_SIZE

- **命名空间:** `NETWORK`
- **Hash:** `0xAC3F722321800755`
- **Build:** `3586`

**C# 签名:**
```csharp
int _NETWORK_GET_BROADCAST_DATA_PLAYER_UPDATE_SIZE(uint scriptNameHash, int instance, uint positionHash, int handlerNum)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scriptNameHash` | `Hash` | `uint` | - |
| `instance` | `int` | `int` | - |
| `positionHash` | `Hash` | `uint` | - |
| `handlerNum` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### _NETWORK_GET_COMMUNICATION_GROUP_DEFAULT_FLAGS

- **命名空间:** `NETWORK`
- **Hash:** `0x97F35B898D2D067F`
- **Build:** `3570`

**C# 签名:**
```csharp
int _NETWORK_GET_COMMUNICATION_GROUP_DEFAULT_FLAGS(int communicationType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `communicationType` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### _NETWORK_GET_COMMUNICATION_GROUP_FLAGS

- **命名空间:** `NETWORK`
- **Hash:** `0x40DF02F371F40883`
- **Build:** `3095`

**C# 签名:**
```csharp
int _NETWORK_GET_COMMUNICATION_GROUP_FLAGS(int communicationType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `communicationType` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns communicationGroupFlag
communicationType: see 0xDBDF80673BBA3D65

enum eCommunicationGroupFlag
{
	COMMUNICATION_GROUP_LOCAL_PLAYER = 1 << 0,
	COMMUNICATION_GROUP_FRIENDS = 1 << 1,
	COMMUNICATION_GROUP_SMALL_CREW = 1 << 2,
	COMMUNICATION_GROUP_LARGE_CREW = 1 << 3,
	COMMUNICATION_GROUP_RECENT_PLAYER = 1 << 4,
	COMMUNICATION_GROUP_SAME_SESSION = 1 << 5,
	COMMUNICATION_GROUP_SAME_TEAM = 1 << 6,
	COMMUNICATION_GROUP_INVALID = 1 << 7,
};
```

---

### _NETWORK_GET_COMMUNICATION_GROUP_VALUE

- **命名空间:** `NETWORK`
- **Hash:** `0xBF66ACD9AE81A99F`
- **Build:** `3570`

**C# 签名:**
```csharp
int _NETWORK_GET_COMMUNICATION_GROUP_VALUE(int communicationType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `communicationType` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### _NETWORK_GET_DUMP_OF_ASSET_VERIFIER

- **命名空间:** `NETWORK`
- **Hash:** `0x69D05E1EAD74B9DD`
- **Build:** `3717`

**C# 签名:**
```csharp
void _NETWORK_GET_DUMP_OF_ASSET_VERIFIER(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_GET_GAME_RESTART_REASON

- **命名空间:** `NETWORK`
- **Hash:** `0x7F7E8401F81CB65B`
- **Build:** `3323`

**C# 签名:**
```csharp
int _NETWORK_GET_GAME_RESTART_REASON()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
enum eNetworkGameRestartReason
{
	BE_RESTART_SERVICE_NOT_RUNNING = 1, 	// BattlEye service not running
	BE_RESTART_SERVICE_NEEDS_UPDATE, 		// BattlEye service needs an update
	BE_RESTART_UNKNOWN_REASON,				// Unknown BattlEye reason
	BE_RESTART_EF_DISABLED_WITH_BE,			// BattlEye Enforcement Flag is disabled, but BattlEye is active
	BE_RESTART_EF_ENABLED_NO_BE,			// BattlEye Enforcement Flag is enabled, but BattlEye is not active
	BE_RESTART_BE_MODULES_FAILED_TO_LOAD,	// BattlEye modules failed to load
	NUM_NETWORK_GAME_RESTART_REASONS
};
```

---

### _NETWORK_GET_GAME_RESTART_REASON_MESSAGE_LABEL

- **命名空间:** `NETWORK`
- **Hash:** `0x47B11D51FC50A259`
- **Build:** `3323`

**C# 签名:**
```csharp
string _NETWORK_GET_GAME_RESTART_REASON_MESSAGE_LABEL()
```

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Returns the restart reason as a string, see _NETWORK_GET_GAME_RESTART_REASON. Returns a null pointer when a restart hasn't been requested (reason == 0 or reason > 6).
```

---

### _NETWORK_GET_HOST_BROADCAST_DATA_SIZE_UNSYNCED

- **命名空间:** `NETWORK`
- **Hash:** `0x72C8588ABE22C972`
- **Build:** `3586`

**C# 签名:**
```csharp
int _NETWORK_GET_HOST_BROADCAST_DATA_SIZE_UNSYNCED(uint scriptNameHash, int instance, uint positionHash, int handlerNum)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scriptNameHash` | `Hash` | `uint` | - |
| `instance` | `int` | `int` | - |
| `positionHash` | `Hash` | `uint` | - |
| `handlerNum` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### _NETWORK_GET_PLAYER_BROADCAST_DATA_SIZE_UNSYNCED

- **命名空间:** `NETWORK`
- **Hash:** `0xB99CD664FD4720A1`
- **Build:** `3586`

**C# 签名:**
```csharp
int _NETWORK_GET_PLAYER_BROADCAST_DATA_SIZE_UNSYNCED(uint scriptNameHash, int instance, uint positionHash, int handlerNum)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scriptNameHash` | `Hash` | `uint` | - |
| `instance` | `int` | `int` | - |
| `positionHash` | `Hash` | `uint` | - |
| `handlerNum` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### _NETWORK_GET_RANDOM_FLOAT_RANGED

- **命名空间:** `NETWORK`
- **Hash:** `0x04BD27B5ACB67067`
- **Build:** `2802`

**C# 签名:**
```csharp
float _NETWORK_GET_RANDOM_FLOAT_RANGED(float rangeStart, float rangeEnd)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `rangeStart` | `float` | `float` | - |
| `rangeEnd` | `float` | `float` | - |

**返回值:** `float` (Native: `float`)

---

### _NETWORK_GET_TUNABLES_REGISTRATION_BOOL

- **命名空间:** `NETWORK`
- **Hash:** `0xB327CF1B8C2C0EA3`
- **Build:** `3258`

**C# 签名:**
```csharp
bool _NETWORK_GET_TUNABLES_REGISTRATION_BOOL(uint tunableName, bool defaultValue)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `tunableName` | `Hash` | `uint` | - |
| `defaultValue` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Checks if the given tunable exists and returns its value. Otherwise returns defaultValue.
Possible tunable contexts must first be set up using _NETWORK_SET_TUNABLES_REGISTRATION_CONTEXTS.
```

---

### _NETWORK_GET_TUNABLES_REGISTRATION_FLOAT

- **命名空间:** `NETWORK`
- **Hash:** `0x367E5E33E7F0DD1A`
- **Build:** `3258`

**C# 签名:**
```csharp
float _NETWORK_GET_TUNABLES_REGISTRATION_FLOAT(uint tunableName, float defaultValue)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `tunableName` | `Hash` | `uint` | - |
| `defaultValue` | `float` | `float` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Checks if the given tunable exists and returns its value. Otherwise returns defaultValue.
Possible tunable contexts must first be set up using _NETWORK_SET_TUNABLES_REGISTRATION_CONTEXTS.
```

---

### _NETWORK_GET_TUNABLES_REGISTRATION_INT

- **命名空间:** `NETWORK`
- **Hash:** `0x0D94071E55F4C9CE`
- **Build:** `3258`

**C# 签名:**
```csharp
int _NETWORK_GET_TUNABLES_REGISTRATION_INT(uint tunableName, int defaultValue)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `tunableName` | `Hash` | `uint` | - |
| `defaultValue` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Checks if the given tunable exists and returns its value. Otherwise returns defaultValue.
Possible tunable contexts must first be set up using _NETWORK_SET_TUNABLES_REGISTRATION_CONTEXTS.
```

---

### _NETWORK_HAS_PLAYER_PASSED_CHECK_TYPE

- **命名空间:** `NETWORK`
- **Hash:** `0x62E29CDA11F9C230`
- **Build:** `3258`

**C# 签名:**
```csharp
bool _NETWORK_HAS_PLAYER_PASSED_CHECK_TYPE(int checkType, ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `checkType` | `int` | `int` | - |
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
_NETWORK_HAS_P*
checkType 3 is similar as using 0x9F633448E4C73207
```

---

### _NETWORK_HAS_ROS_PRIVILEGE_MP_TEXT_COMMUNICATION

- **命名空间:** `NETWORK`
- **Hash:** `0xD9719341663C385F`
- **Build:** `3095`

**C# 签名:**
```csharp
bool _NETWORK_HAS_ROS_PRIVILEGE_MP_TEXT_COMMUNICATION()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Checks for privilege 29
```

---

### _NETWORK_HAS_ROS_PRIVILEGE_MP_VOICE_COMMUNICATION

- **命名空间:** `NETWORK`
- **Hash:** `0x8956A309BE90057C`
- **Build:** `3095`

**C# 签名:**
```csharp
bool _NETWORK_HAS_ROS_PRIVILEGE_MP_VOICE_COMMUNICATION()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Checks for privilege 30
```

---

### _NETWORK_HAS_ROS_PRIVILEGE_REPORTING

- **命名空间:** `NETWORK`
- **Hash:** `0x9BA54B3CFB82ADDD`
- **Build:** `3258`

**C# 签名:**
```csharp
bool _NETWORK_HAS_ROS_PRIVILEGE_REPORTING()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Checks for privilege 31
```

---

### _NETWORK_HAVE_PLATFORM_COMMUNICATION_PRIVILEGES

- **命名空间:** `NETWORK`
- **Hash:** `0xE1E02509169C124E`
- **Build:** `3095`

**C# 签名:**
```csharp
bool _NETWORK_HAVE_PLATFORM_COMMUNICATION_PRIVILEGES()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Appears to be PlayStation-specific. Always returns true on other platforms if signed in with the primary user profile
```

---

### _NETWORK_HIDE_ENTITY_IN_TUTORIAL_SESSION

- **命名空间:** `NETWORK`
- **Hash:** `0xCFE359CCCFE359CC`
- **Build:** `3258`

**C# 签名:**
```csharp
void _NETWORK_HIDE_ENTITY_IN_TUTORIAL_SESSION(int netHandle, bool hide)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netHandle` | `int` | `int` | - |
| `hide` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_INVITE_CLEAR_JOIN_FAIL_REASON

- **命名空间:** `NETWORK`
- **Hash:** `0x8EF5F5811A940F82`
- **Build:** `3179`

**C# 签名:**
```csharp
void _NETWORK_INVITE_CLEAR_JOIN_FAIL_REASON()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Clears the failed invite join alert reason
```

---

### _NETWORK_INVITE_GET_JOIN_FAIL_REASON

- **命名空间:** `NETWORK`
- **Hash:** `0x7B335F84501145BB`
- **Build:** `3179`

**C# 签名:**
```csharp
string _NETWORK_INVITE_GET_JOIN_FAIL_REASON()
```

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Retrieves the failed invite join alert reason
```

---

### _NETWORK_IS_AMERICAS_VERSION

- **命名空间:** `NETWORK`
- **Hash:** `0x0292BD7F3766CEBC`
- **Build:** `3095`

**C# 签名:**
```csharp
bool _NETWORK_IS_AMERICAS_VERSION()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Hardcoded to return 0.
```

---

### _NETWORK_IS_SPECIAL_TUTORIAL_SESSION

- **命名空间:** `NETWORK`
- **Hash:** `0x4666CD7431DE98E2`
- **Build:** `3717`

**C# 签名:**
```csharp
bool _NETWORK_IS_SPECIAL_TUTORIAL_SESSION()
```

**返回值:** `bool` (Native: `BOOL`)

---

### _NETWORK_LOAD_GAMER_DISPLAY_NAME

- **命名空间:** `NETWORK`
- **Hash:** `0x338ECE3637937BC2`
- **Build:** `3258`

**C# 签名:**
```csharp
string _NETWORK_LOAD_GAMER_DISPLAY_NAME(ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Returns the name from given friend gamer handle.
```

---

### _NETWORK_MULTIPLAYER_CROSSPLAY_NOT_ALLOWED

- **命名空间:** `NETWORK`
- **Hash:** `0xA6BC0D9BCF9662FA`
- **Build:** `3504`

**C# 签名:**
```csharp
bool _NETWORK_MULTIPLAYER_CROSSPLAY_NOT_ALLOWED()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
For the XboxPC version this returns true if XPRIVILEGE_MULTIPLAYER_SESSIONS is granted but XPRIVILEGE_CROSS_PLAY is NOT granted.
For more information, see https://learn.microsoft.com/en-us/gaming/gdk/_content/gc/live/features/identity/privileges/concepts/live-user-privileges-client#privilege-ids-to-check

Always returns false for non-XboxPC versions.
```

---

### _NETWORK_SESSION_LEAVE_INCLUDING_REASON

- **命名空间:** `NETWORK`
- **Hash:** `0xE0128328CF1FD9F4`
- **Build:** `3095`

**C# 签名:**
```csharp
bool _NETWORK_SESSION_LEAVE_INCLUDING_REASON(int leaveFlags, int leaveReason)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `leaveFlags` | `int` | `int` | - |
| `leaveReason` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### _NETWORK_SET_COMMUNICATION_GROUP_FLAGS

- **命名空间:** `NETWORK`
- **Hash:** `0xE549F846DE7D32D5`
- **Build:** `3095`

**C# 签名:**
```csharp
void _NETWORK_SET_COMMUNICATION_GROUP_FLAGS(int communicationType, int communicationGroupFlag)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `communicationType` | `int` | `int` | - |
| `communicationGroupFlag` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
communicationType: see 0xDBDF80673BBA3D65
communicationGroupFlag: see 0x40DF02F371F40883
```

---

### _NETWORK_SET_IGNORE_VEHICLE_RAMMED_BY_NON_VEHICLE

- **命名空间:** `NETWORK`
- **Hash:** `0x67F7C81C1395672A`
- **Build:** `3717`

**C# 签名:**
```csharp
void _NETWORK_SET_IGNORE_VEHICLE_RAMMED_BY_NON_VEHICLE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_SET_TUNABLES_REGISTRATION_CONTEXTS

- **命名空间:** `NETWORK`
- **Hash:** `0x014A73449675121D`
- **Build:** `3258`

**C# 签名:**
```csharp
void _NETWORK_SET_TUNABLES_REGISTRATION_CONTEXTS(ref object tunableContextData)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `tunableContextData` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets up tunable contexts for _NETWORK_GET_TUNABLES_REGISTRATION_{BOOL|INT|FLOAT}
```

---

### _NETWORK_SET_TUTORIAL_SPECIAL_SESSION

- **命名空间:** `NETWORK`
- **Hash:** `0x35AEB4AC7C73C6E1`
- **Build:** `3717`

**C# 签名:**
```csharp
void _NETWORK_SET_TUTORIAL_SPECIAL_SESSION(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_TRIGGER_DAMAGE_EVENT_FOR_ZERO_PED_DAMAGE

- **命名空间:** `NETWORK`
- **Hash:** `0xE9D0244ACBEE1BC4`
- **Build:** `3258`

**C# 签名:**
```csharp
void _NETWORK_TRIGGER_DAMAGE_EVENT_FOR_ZERO_PED_DAMAGE(int entity, bool trigger)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `trigger` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### _SET_FREEMODE_REPORT_DATA

- **命名空间:** `NETWORK`
- **Hash:** `0x527803286A8B6C81`
- **Build:** `3258`

**C# 签名:**
```csharp
void _SET_FREEMODE_REPORT_DATA(ref object gamerHandle, ref object reportData)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `gamerHandle` | `Any*` | `ref object` | - |
| `reportData` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
reportData includes mc, ceo, yacht and licenceplate names
```

---
