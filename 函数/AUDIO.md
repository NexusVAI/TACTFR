# AUDIO - Native 函数参考

> 命名空间: AUDIO

---

## 快速索引

| 函数名 | C# 签名 | 返回值 | 说明 |
|--------|---------|--------|------|
| `ACTIVATE_AUDIO_SLOWMO_MODE` | `void ACTIVATE_AUDIO_SLOWMO_MODE(string mode)` | void | mode can be any of these: <br>SLOWMO_T1_TRAILER_SMASH<br>SLOWMO_T1_RAYFIRE_EXPLOSION<br>SLOWMO_PROLOGUE_VAULT... |
| `ADD_ENTITY_TO_AUDIO_MIX_GROUP` | `void ADD_ENTITY_TO_AUDIO_MIX_GROUP(int entity, string groupName, float p2)` | void | All found occurrences in b678d:<br>https://pastebin.com/ceu67jz8 |
| `ADD_LINE_TO_CONVERSATION` | `void ADD_LINE_TO_CONVERSATION(int index, string p1, string p2, int p3, int p4, bool p5, bool p6, bool p7, bool p8, int p9, bool p10, bool p11, bool p12)` | void | NOTE: ones that are -1, 0 - 35 are determined by a function where it gets a TextLabel from a global ... |
| `ADD_PED_TO_CONVERSATION` | `void ADD_PED_TO_CONVERSATION(int index, int ped, string p2)` | void | 4 calls in the b617d scripts. The only one with p0 and p2 in clear text:<br><br>AUDIO::ADD_PED_TO_CONVERSA... |
| `AUDIO_IS_MUSIC_PLAYING` | `bool AUDIO_IS_MUSIC_PLAYING()` | bool | - |
| `AUDIO_IS_SCRIPTED_MUSIC_PLAYING` | `bool AUDIO_IS_SCRIPTED_MUSIC_PLAYING()` | bool | This is an alias of AUDIO_IS_MUSIC_PLAYING. |
| `BLIP_SIREN` | `void BLIP_SIREN(int vehicle)` | void | Plays the siren sound of a vehicle which is otherwise activated when fastly double-pressing the horn... |
| `BLOCK_ALL_SPEECH_FROM_PED` | `void BLOCK_ALL_SPEECH_FROM_PED(int ped, bool p1, bool p2)` | void | - |
| `BLOCK_DEATH_JINGLE` | `void BLOCK_DEATH_JINGLE(bool toggle)` | void | - |
| `BLOCK_SPEECH_CONTEXT_GROUP` | `void BLOCK_SPEECH_CONTEXT_GROUP(string p0, int p1)` | void | - |
| `CANCEL_ALL_POLICE_REPORTS` | `void CANCEL_ALL_POLICE_REPORTS()` | void | - |
| `CANCEL_MUSIC_EVENT` | `bool CANCEL_MUSIC_EVENT(string eventName)` | bool | All music event names found in the b617d scripts: https://pastebin.com/GnYt0R3P<br>Full list of music e... |
| `CAN_VEHICLE_RECEIVE_CB_RADIO` | `bool CAN_VEHICLE_RECEIVE_CB_RADIO(int vehicle)` | bool | - |
| `CLEAR_ALL_BROKEN_GLASS` | `void CLEAR_ALL_BROKEN_GLASS()` | void | - |
| `CLEAR_AMBIENT_ZONE_LIST_STATE` | `void CLEAR_AMBIENT_ZONE_LIST_STATE(string ambientZone, bool p1)` | void | - |
| `CLEAR_AMBIENT_ZONE_STATE` | `void CLEAR_AMBIENT_ZONE_STATE(string zoneName, bool p1)` | void | This function also has a p2, unknown. Signature AUDIO::CLEAR_AMBIENT_ZONE_STATE(const char* zoneName... |
| `CLEAR_CUSTOM_RADIO_TRACK_LIST` | `void CLEAR_CUSTOM_RADIO_TRACK_LIST(string radioStation)` | void | 3 calls in the b617d scripts, removed duplicate.<br><br>AUDIO::CLEAR_CUSTOM_RADIO_TRACK_LIST("RADIO_16_SIL... |
| `CREATE_NEW_SCRIPTED_CONVERSATION` | `void CREATE_NEW_SCRIPTED_CONVERSATION()` | void | - |
| `DEACTIVATE_AUDIO_SLOWMO_MODE` | `void DEACTIVATE_AUDIO_SLOWMO_MODE(string mode)` | void | see ACTIVATE_AUDIO_SLOWMO_MODE for modes |
| `DISABLE_PED_PAIN_AUDIO` | `void DISABLE_PED_PAIN_AUDIO(int ped, bool toggle)` | void | - |
| `DISTANT_COP_CAR_SIRENS` | `void DISTANT_COP_CAR_SIRENS(bool value)` | void | If value is set to true, and ambient siren sound will be played.<br>Appears to enable/disable an audio ... |
| `DOES_CONTEXT_EXIST_FOR_THIS_PED` | `bool DOES_CONTEXT_EXIST_FOR_THIS_PED(int ped, string speechName, bool p2)` | bool | Checks if the ped can play the speech or has the speech file, p2 is usually false. |
| `DOES_PLAYER_VEH_HAVE_RADIO` | `bool DOES_PLAYER_VEH_HAVE_RADIO()` | bool | - |
| `ENABLE_STALL_WARNING_SOUNDS` | `void ENABLE_STALL_WARNING_SOUNDS(int vehicle, bool toggle)` | void | Works for planes only. |
| `ENABLE_STUNT_JUMP_AUDIO` | `void ENABLE_STUNT_JUMP_AUDIO()` | void | - |
| `ENABLE_VEHICLE_EXHAUST_POPS` | `void ENABLE_VEHICLE_EXHAUST_POPS(int vehicle, bool toggle)` | void | - |
| `ENABLE_VEHICLE_FANBELT_DAMAGE` | `void ENABLE_VEHICLE_FANBELT_DAMAGE(int vehicle, bool toggle)` | void | - |
| `FIND_RADIO_STATION_INDEX` | `int FIND_RADIO_STATION_INDEX(uint stationNameHash)` | int | - |
| `FORCE_MUSIC_TRACK_LIST` | `void FORCE_MUSIC_TRACK_LIST(string radioStation, string trackListName, int milliseconds)` | void | Changes start time of a tracklist (milliseconds)<br>R* uses a random int: MISC::GET_RANDOM_INT_IN_RANGE... |
| `FORCE_PED_PANIC_WALLA` | `void FORCE_PED_PANIC_WALLA()` | void | - |
| `FORCE_USE_AUDIO_GAME_OBJECT` | `void FORCE_USE_AUDIO_GAME_OBJECT(int vehicle, string audioName)` | void | This native sets the audio of the specified vehicle to the audioName (p1).<br><br>Use the audioNameHash fo... |
| `FREEZE_MICROPHONE` | `void FREEZE_MICROPHONE()` | void | - |
| `FREEZE_RADIO_STATION` | `void FREEZE_RADIO_STATION(string radioStation)` | void | - |
| `GET_AMBIENT_VOICE_NAME_HASH` | `uint GET_AMBIENT_VOICE_NAME_HASH(int ped)` | uint | - |
| `GET_AUDIBLE_MUSIC_TRACK_TEXT_ID` | `int GET_AUDIBLE_MUSIC_TRACK_TEXT_ID()` | int | - |
| `GET_CURRENT_SCRIPTED_CONVERSATION_LINE` | `int GET_CURRENT_SCRIPTED_CONVERSATION_LINE()` | int | - |
| `GET_CURRENT_TRACK_PLAY_TIME` | `int GET_CURRENT_TRACK_PLAY_TIME(string radioStationName)` | int | - |
| `GET_CURRENT_TRACK_SOUND_NAME` | `uint GET_CURRENT_TRACK_SOUND_NAME(string radioStationName)` | uint | - |
| `GET_CURRENT_TV_SHOW_PLAY_TIME` | `int GET_CURRENT_TV_SHOW_PLAY_TIME()` | int | - |
| `GET_IS_PRELOADED_CONVERSATION_READY` | `bool GET_IS_PRELOADED_CONVERSATION_READY()` | bool | - |
| `GET_MUSIC_PLAYTIME` | `int GET_MUSIC_PLAYTIME()` | int | - |
| `GET_MUSIC_VOL_SLIDER` | `int GET_MUSIC_VOL_SLIDER()` | int | - |
| `GET_NETWORK_ID_FROM_SOUND_ID` | `int GET_NETWORK_ID_FROM_SOUND_ID(int soundId)` | int | Could this be used alongside either, <br>SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES or _SET_NETWORK_ID_SYNC_... |
| `GET_NEXT_AUDIBLE_BEAT` | `bool GET_NEXT_AUDIBLE_BEAT(ref float out1, ref float out2, ref int out3)` | bool | - |
| `GET_NUM_UNLOCKED_RADIO_STATIONS` | `int GET_NUM_UNLOCKED_RADIO_STATIONS()` | int | - |
| `GET_PLAYER_RADIO_STATION_GENRE` | `int GET_PLAYER_RADIO_STATION_GENRE()` | int | - |
| `GET_PLAYER_RADIO_STATION_INDEX` | `int GET_PLAYER_RADIO_STATION_INDEX()` | int | Returns 255 (radio off index) if the function fails. |
| `GET_PLAYER_RADIO_STATION_NAME` | `string GET_PLAYER_RADIO_STATION_NAME()` | string | Returns active radio station name |
| `GET_RADIO_STATION_NAME` | `string GET_RADIO_STATION_NAME(int radioStation)` | string | Converts radio station index to string. Use HUD::GET_FILENAME_FOR_AUDIO_CONVERSATION to get the user... |
| `GET_SOUND_ID` | `int GET_SOUND_ID()` | int | - |
| `GET_SOUND_ID_FROM_NETWORK_ID` | `int GET_SOUND_ID_FROM_NETWORK_ID(int netId)` | int | - |
| `GET_STREAM_PLAY_TIME` | `int GET_STREAM_PLAY_TIME()` | int | - |
| `GET_VARIATION_CHOSEN_FOR_SCRIPTED_LINE` | `int GET_VARIATION_CHOSEN_FOR_SCRIPTED_LINE(ref object p0)` | int | - |
| `GET_VEHICLE_DEFAULT_HORN` | `uint GET_VEHICLE_DEFAULT_HORN(int vehicle)` | uint | Returns hash of default vehicle horn<br><br>Hash is stored in audVehicleAudioEntity |
| `GET_VEHICLE_DEFAULT_HORN_IGNORE_MODS` | `uint GET_VEHICLE_DEFAULT_HORN_IGNORE_MODS(int vehicle)` | uint | - |
| `GET_VEHICLE_HORN_SOUND_INDEX` | `int GET_VEHICLE_HORN_SOUND_INDEX(int vehicle)` | int | - |
| `HAS_LOADED_MP_DATA_SET` | `bool HAS_LOADED_MP_DATA_SET()` | bool | - |
| `HAS_LOADED_SP_DATA_SET` | `bool HAS_LOADED_SP_DATA_SET()` | bool | - |
| `HAS_SOUND_FINISHED` | `bool HAS_SOUND_FINISHED(int soundId)` | bool | - |
| `HINT_AMBIENT_AUDIO_BANK` | `bool HINT_AMBIENT_AUDIO_BANK(string audioBank, bool p1, object p2)` | bool | p2 is always -1 |
| `HINT_MISSION_AUDIO_BANK` | `bool HINT_MISSION_AUDIO_BANK(string audioBank, bool p1, object p2)` | bool | p2 is always -1 |
| `HINT_SCRIPT_AUDIO_BANK` | `bool HINT_SCRIPT_AUDIO_BANK(string audioBank, bool p1, object p2)` | bool | p2 is always -1 |
| `INIT_SYNCH_SCENE_AUDIO_WITH_ENTITY` | `void INIT_SYNCH_SCENE_AUDIO_WITH_ENTITY(string audioEvent, int entity)` | void | - |
| `INIT_SYNCH_SCENE_AUDIO_WITH_POSITION` | `void INIT_SYNCH_SCENE_AUDIO_WITH_POSITION(string audioEvent, float x, float y, float z)` | void | - |
| `INTERRUPT_CONVERSATION` | `void INTERRUPT_CONVERSATION(int ped, string voiceline, string speaker)` | void | Example from carsteal3.c: AUDIO::INTERRUPT_CONVERSATION(PLAYER::PLAYER_PED_ID(), "CST4_CFAA", "FRANK... |
| `INTERRUPT_CONVERSATION_AND_PAUSE` | `void INTERRUPT_CONVERSATION_AND_PAUSE(int ped, string p1, string speaker)` | void | One call found in the b617d scripts:<br><br>AUDIO::INTERRUPT_CONVERSATION_AND_PAUSE(NETWORK::NET_TO_PED(l_... |
| `IS_ALARM_PLAYING` | `bool IS_ALARM_PLAYING(string alarmName)` | bool | Example:<br><br>bool playing = AUDIO::IS_ALARM_PLAYING("PORT_OF_LS_HEIST_FORT_ZANCUDO_ALARMS");<br>Full list ... |
| `IS_AMBIENT_SPEECH_DISABLED` | `bool IS_AMBIENT_SPEECH_DISABLED(int ped)` | bool | Common in the scripts:<br>AUDIO::IS_AMBIENT_SPEECH_DISABLED(PLAYER::PLAYER_PED_ID()); |
| `IS_AMBIENT_SPEECH_PLAYING` | `bool IS_AMBIENT_SPEECH_PLAYING(int ped)` | bool | - |
| `IS_AMBIENT_ZONE_ENABLED` | `bool IS_AMBIENT_ZONE_ENABLED(string ambientZone)` | bool | Full list of ambient zones by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/a... |
| `IS_ANIMAL_VOCALIZATION_PLAYING` | `bool IS_ANIMAL_VOCALIZATION_PLAYING(int pedHandle)` | bool | - |
| `IS_ANY_POSITIONAL_SPEECH_PLAYING` | `bool IS_ANY_POSITIONAL_SPEECH_PLAYING()` | bool | - |
| `IS_ANY_SPEECH_PLAYING` | `bool IS_ANY_SPEECH_PLAYING(int ped)` | bool | - |
| `IS_AUDIO_SCENE_ACTIVE` | `bool IS_AUDIO_SCENE_ACTIVE(string scene)` | bool | Full list of audio scene names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/maste... |
| `IS_GAME_IN_CONTROL_OF_MUSIC` | `bool IS_GAME_IN_CONTROL_OF_MUSIC()` | bool | Hardcoded to return 1 |
| `IS_HORN_ACTIVE` | `bool IS_HORN_ACTIVE(int vehicle)` | bool | Checks whether the horn of a vehicle is currently played. |
| `IS_MISSION_COMPLETE_PLAYING` | `bool IS_MISSION_COMPLETE_PLAYING()` | bool | - |
| `IS_MISSION_COMPLETE_READY_FOR_UI` | `bool IS_MISSION_COMPLETE_READY_FOR_UI()` | bool | - |
| `IS_MISSION_NEWS_STORY_UNLOCKED` | `bool IS_MISSION_NEWS_STORY_UNLOCKED(int newsStory)` | bool | - |
| `IS_MOBILE_INTERFERENCE_ACTIVE` | `bool IS_MOBILE_INTERFERENCE_ACTIVE()` | bool | - |
| `IS_MOBILE_PHONE_CALL_ONGOING` | `bool IS_MOBILE_PHONE_CALL_ONGOING()` | bool | - |
| `IS_MOBILE_PHONE_RADIO_ACTIVE` | `bool IS_MOBILE_PHONE_RADIO_ACTIVE()` | bool | - |
| `IS_MUSIC_ONESHOT_PLAYING` | `bool IS_MUSIC_ONESHOT_PLAYING()` | bool | - |
| `IS_PED_IN_CURRENT_CONVERSATION` | `bool IS_PED_IN_CURRENT_CONVERSATION(int ped)` | bool | - |
| `IS_PED_RINGTONE_PLAYING` | `bool IS_PED_RINGTONE_PLAYING(int ped)` | bool | - |
| `IS_PLAYER_VEH_RADIO_ENABLE` | `bool IS_PLAYER_VEH_RADIO_ENABLE()` | bool | - |
| `IS_RADIO_FADED_OUT` | `bool IS_RADIO_FADED_OUT()` | bool | - |
| `IS_RADIO_RETUNING` | `bool IS_RADIO_RETUNING()` | bool | - |
| `IS_RADIO_STATION_FAVOURITED` | `bool IS_RADIO_STATION_FAVOURITED(string radioStation)` | bool | - |
| `IS_SCRIPTED_CONVERSATION_LOADED` | `bool IS_SCRIPTED_CONVERSATION_LOADED()` | bool | - |
| `IS_SCRIPTED_CONVERSATION_ONGOING` | `bool IS_SCRIPTED_CONVERSATION_ONGOING()` | bool | - |
| `IS_SCRIPTED_SPEECH_PLAYING` | `bool IS_SCRIPTED_SPEECH_PLAYING(int p0)` | bool | - |
| `IS_STREAM_PLAYING` | `bool IS_STREAM_PLAYING()` | bool | - |
| `IS_VEHICLE_AUDIBLY_DAMAGED` | `bool IS_VEHICLE_AUDIBLY_DAMAGED(int vehicle)` | bool | - |
| `IS_VEHICLE_RADIO_ON` | `bool IS_VEHICLE_RADIO_ON(int vehicle)` | bool | - |
| `LINK_STATIC_EMITTER_TO_ENTITY` | `void LINK_STATIC_EMITTER_TO_ENTITY(string emitterName, int entity)` | void | Full list of static emitters by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master... |
| `LOAD_STREAM` | `bool LOAD_STREAM(string streamName, string soundSet)` | bool | Example:<br>AUDIO::LOAD_STREAM("CAR_STEAL_1_PASSBY", "CAR_STEAL_1_SOUNDSET");<br><br>All found occurrences in... |
| `LOAD_STREAM_WITH_START_OFFSET` | `bool LOAD_STREAM_WITH_START_OFFSET(string streamName, int startOffset, string soundSet)` | bool | Example:<br>AUDIO::LOAD_STREAM_WITH_START_OFFSET("STASH_TOXIN_STREAM", 2400, "FBI_05_SOUNDS");<br><br>Only ca... |
| `LOCK_RADIO_STATION` | `void LOCK_RADIO_STATION(string radioStationName, bool toggle)` | void | Disables the radio station (hides it from the radio wheel). |
| `LOCK_RADIO_STATION_TRACK_LIST` | `void LOCK_RADIO_STATION_TRACK_LIST(string radioStation, string trackListName)` | void | - |
| `OVERRIDE_MICROPHONE_SETTINGS` | `void OVERRIDE_MICROPHONE_SETTINGS(uint hash, bool toggle)` | void | Sets audio flag "OverrideMicrophoneSettings" |
| `OVERRIDE_PLAYER_GROUND_MATERIAL` | `void OVERRIDE_PLAYER_GROUND_MATERIAL(uint hash, bool toggle)` | void | Sets audio flag "OverridePlayerGroundMaterial" |
| `OVERRIDE_TREVOR_RAGE` | `void OVERRIDE_TREVOR_RAGE(string voiceEffect)` | void | This native enables the audio flag "TrevorRageIsOverridden" and sets the voice effect to `voiceEffec... |
| `OVERRIDE_UNDERWATER_STREAM` | `void OVERRIDE_UNDERWATER_STREAM(string p0, bool p1)` | void | - |
| `OVERRIDE_VEH_HORN` | `void OVERRIDE_VEH_HORN(int vehicle, bool override, int hornHash)` | void | Overrides the vehicle's horn hash.<br>When changing this hash on a vehicle, it will not return the 'ove... |
| `PAUSE_SCRIPTED_CONVERSATION` | `void PAUSE_SCRIPTED_CONVERSATION(bool p0)` | void | - |
| `PLAY_AMBIENT_SPEECH_FROM_POSITION_NATIVE` | `void PLAY_AMBIENT_SPEECH_FROM_POSITION_NATIVE(string speechName, string voiceName, float x, float y, float z, string speechParam)` | void | Full list of speeches and voices names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/b... |
| `PLAY_ANIMAL_VOCALIZATION` | `void PLAY_ANIMAL_VOCALIZATION(int pedHandle, int p1, string speechName)` | void | Plays sounds from a ped with chop model. For example it used to play bark or sniff sounds. p1 is alw... |
| `PLAY_DEFERRED_SOUND_FRONTEND` | `void PLAY_DEFERRED_SOUND_FRONTEND(string soundName, string soundsetName)` | void | Only call found in the b617d scripts:<br><br>AUDIO::PLAY_DEFERRED_SOUND_FRONTEND("BACK", "HUD_FREEMODE_SOU... |
| `PLAY_END_CREDITS_MUSIC` | `void PLAY_END_CREDITS_MUSIC(bool play)` | void | - |
| `PLAY_MISSION_COMPLETE_AUDIO` | `void PLAY_MISSION_COMPLETE_AUDIO(string audioName)` | void | Called 38 times in the scripts. There are 5 different audioNames used.<br> One unknown removed below.<br><br>... |
| `PLAY_PAIN` | `void PLAY_PAIN(int ped, int painID, int p1, object p3)` | void | Needs another parameter [int p2]. The signature is PED::PLAY_PAIN(Ped ped, int painID, int p1, int p... |
| `PLAY_PED_AMBIENT_SPEECH_AND_CLONE_NATIVE` | `void PLAY_PED_AMBIENT_SPEECH_AND_CLONE_NATIVE(int ped, string speechName, string speechParam, object p3)` | void | Plays ambient speech. See also _0x5C57B85D.<br><br>See PLAY_PED_AMBIENT_SPEECH_NATIVE for parameter specif... |
| `PLAY_PED_AMBIENT_SPEECH_NATIVE` | `void PLAY_PED_AMBIENT_SPEECH_NATIVE(int ped, string speechName, string speechParam, object p3)` | void | Plays ambient speech. See also _0x444180DB.<br><br>ped: The ped to play the ambient speech.<br>speechName: Na... |
| `PLAY_PED_AMBIENT_SPEECH_WITH_VOICE_NATIVE` | `void PLAY_PED_AMBIENT_SPEECH_WITH_VOICE_NATIVE(int ped, string speechName, string voiceName, string speechParam, bool p4)` | void | This is the same as PLAY_PED_AMBIENT_SPEECH_NATIVE and PLAY_PED_AMBIENT_SPEECH_AND_CLONE_NATIVE but ... |
| `PLAY_PED_AUDIO_EVENT_ANIM` | `void PLAY_PED_AUDIO_EVENT_ANIM(int pedHandle, string audioEvent)` | void | - |
| `PLAY_PED_RINGTONE` | `void PLAY_PED_RINGTONE(string ringtoneName, int ped, bool p2)` | void | All found occurrences in b617d, sorted alphabetically and identical lines removed: https://pastebin.... |
| `PLAY_POLICE_REPORT` | `int PLAY_POLICE_REPORT(string name, float p1)` | int | Plays the given police radio message.<br><br>All found occurrences in b617d, sorted alphabetically and ide... |
| `PLAY_SOUND` | `void PLAY_SOUND(int soundId, string audioName, string audioRef, bool p3, object p4, bool p5)` | void | All found occurrences in b617d, sorted alphabetically and identical lines removed: https://pastebin.... |
| `PLAY_SOUND_FROM_COORD` | `void PLAY_SOUND_FROM_COORD(int soundId, string audioName, float x, float y, float z, string audioRef, bool isNetwork, int range, bool p8)` | void | All found occurrences in b617d, sorted alphabetically and identical lines removed: https://pastebin.... |
| `PLAY_SOUND_FROM_ENTITY` | `void PLAY_SOUND_FROM_ENTITY(int soundId, string audioName, int entity, string audioRef, bool isNetwork, object p5)` | void | All found occurrences in b617d, sorted alphabetically and identical lines removed: https://pastebin.... |
| `PLAY_SOUND_FROM_ENTITY_HASH` | `void PLAY_SOUND_FROM_ENTITY_HASH(int soundId, uint model, int entity, uint soundSetHash, object p4, object p5)` | void | Only used with "formation_flying_blips_soundset" and "biker_formation_blips_soundset".<br>p1 is always ... |
| `PLAY_SOUND_FRONTEND` | `void PLAY_SOUND_FRONTEND(int soundId, string audioName, string audioRef, bool p3)` | void | List: https://pastebin.com/DCeRiaLJ<br><br>All occurrences as of Cayo Perico Heist DLC (b2189), sorted alp... |
| `PLAY_STREAM_FROM_OBJECT` | `void PLAY_STREAM_FROM_OBJECT(int object)` | void | Used with AUDIO::LOAD_STREAM<br><br>Example from finale_heist2b.c4:<br>TASK::TASK_SYNCHRONIZED_SCENE(l_4C8[2/... |
| `PLAY_STREAM_FROM_PED` | `void PLAY_STREAM_FROM_PED(int ped)` | void | - |
| `PLAY_STREAM_FROM_POSITION` | `void PLAY_STREAM_FROM_POSITION(float x, float y, float z)` | void | - |
| `PLAY_STREAM_FROM_VEHICLE` | `void PLAY_STREAM_FROM_VEHICLE(int vehicle)` | void | - |
| `PLAY_STREAM_FRONTEND` | `void PLAY_STREAM_FRONTEND()` | void | - |
| `PLAY_SYNCHRONIZED_AUDIO_EVENT` | `bool PLAY_SYNCHRONIZED_AUDIO_EVENT(int sceneID)` | bool | - |
| `PLAY_VEHICLE_DOOR_CLOSE_SOUND` | `void PLAY_VEHICLE_DOOR_CLOSE_SOUND(int vehicle, int doorId)` | void | doorId: see SET_VEHICLE_DOOR_SHUT |
| `PLAY_VEHICLE_DOOR_OPEN_SOUND` | `void PLAY_VEHICLE_DOOR_OPEN_SOUND(int vehicle, int doorId)` | void | doorId: see SET_VEHICLE_DOOR_SHUT |
| `PRELOAD_SCRIPT_CONVERSATION` | `void PRELOAD_SCRIPT_CONVERSATION(bool p0, bool p1, bool p2, bool p3)` | void | - |
| `PRELOAD_SCRIPT_PHONE_CONVERSATION` | `void PRELOAD_SCRIPT_PHONE_CONVERSATION(bool p0, bool p1)` | void | - |
| `PRELOAD_VEHICLE_AUDIO_BANK` | `void PRELOAD_VEHICLE_AUDIO_BANK(uint vehicleModel)` | void | - |
| `PREPARE_ALARM` | `bool PREPARE_ALARM(string alarmName)` | bool | Example:<br><br>bool prepareAlarm = AUDIO::PREPARE_ALARM("PORT_OF_LS_HEIST_FORT_ZANCUDO_ALARMS");<br>Full lis... |
| `PREPARE_MUSIC_EVENT` | `bool PREPARE_MUSIC_EVENT(string eventName)` | bool | All music event names found in the b617d scripts: https://pastebin.com/GnYt0R3P<br>Full list of music e... |
| `PREPARE_SYNCHRONIZED_AUDIO_EVENT` | `bool PREPARE_SYNCHRONIZED_AUDIO_EVENT(string audioEvent, object p1)` | bool | p1 is always 0 in the scripts |
| `PREPARE_SYNCHRONIZED_AUDIO_EVENT_FOR_SCENE` | `bool PREPARE_SYNCHRONIZED_AUDIO_EVENT_FOR_SCENE(int sceneID, string audioEvent)` | bool | - |
| `RECORD_BROKEN_GLASS` | `void RECORD_BROKEN_GLASS(float x, float y, float z, float radius)` | void | - |
| `REFRESH_CLOSEST_OCEAN_SHORELINE` | `void REFRESH_CLOSEST_OCEAN_SHORELINE()` | void | - |
| `REGISTER_SCRIPT_WITH_AUDIO` | `void REGISTER_SCRIPT_WITH_AUDIO(int p0)` | void | This native does absolutely nothing, just a nullsub |
| `RELEASE_AMBIENT_AUDIO_BANK` | `void RELEASE_AMBIENT_AUDIO_BANK()` | void | - |
| `RELEASE_MISSION_AUDIO_BANK` | `void RELEASE_MISSION_AUDIO_BANK()` | void | - |
| `RELEASE_NAMED_SCRIPT_AUDIO_BANK` | `void RELEASE_NAMED_SCRIPT_AUDIO_BANK(string audioBank)` | void | Full list of script audio bank names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob... |
| `RELEASE_SCRIPT_AUDIO_BANK` | `void RELEASE_SCRIPT_AUDIO_BANK()` | void | - |
| `RELEASE_SOUND_ID` | `void RELEASE_SOUND_ID(int soundId)` | void | - |
| `RELEASE_WEAPON_AUDIO` | `void RELEASE_WEAPON_AUDIO()` | void | - |
| `REMOVE_ENTITY_FROM_AUDIO_MIX_GROUP` | `void REMOVE_ENTITY_FROM_AUDIO_MIX_GROUP(int entity, float p1)` | void | - |
| `REMOVE_INDIVIDUAL_PORTAL_SETTINGS_OVERRIDE` | `void REMOVE_INDIVIDUAL_PORTAL_SETTINGS_OVERRIDE(uint interiorNameHash, int roomIndex, int doorIndex)` | void | - |
| `REMOVE_PORTAL_SETTINGS_OVERRIDE` | `void REMOVE_PORTAL_SETTINGS_OVERRIDE(string p0)` | void |  Found in the b617d scripts, duplicates removed: <br><br> AUDIO::REMOVE_PORTAL_SETTINGS_OVERRIDE("V_CARSHO... |
| `REQUEST_AMBIENT_AUDIO_BANK` | `bool REQUEST_AMBIENT_AUDIO_BANK(string audioBank, bool p1, object p2)` | bool | All occurrences and usages found in b617d, sorted alphabetically and identical lines removed: https:... |
| `REQUEST_MISSION_AUDIO_BANK` | `bool REQUEST_MISSION_AUDIO_BANK(string audioBank, bool p1, object p2)` | bool | All occurrences and usages found in b617d: https://pastebin.com/NzZZ2Tmm<br>Full list of mission audio ... |
| `REQUEST_SCRIPT_AUDIO_BANK` | `bool REQUEST_SCRIPT_AUDIO_BANK(string audioBank, bool p1, object p2)` | bool | All occurrences and usages found in b617d, sorted alphabetically and identical lines removed: https:... |
| `REQUEST_TENNIS_BANKS` | `void REQUEST_TENNIS_BANKS(int ped)` | void | - |
| `RESET_PED_AUDIO_FLAGS` | `void RESET_PED_AUDIO_FLAGS(int ped)` | void | - |
| `RESET_TREVOR_RAGE` | `void RESET_TREVOR_RAGE()` | void | - |
| `RESET_VEHICLE_STARTUP_REV_SOUND` | `void RESET_VEHICLE_STARTUP_REV_SOUND(int vehicle)` | void | - |
| `RESTART_SCRIPTED_CONVERSATION` | `void RESTART_SCRIPTED_CONVERSATION()` | void | - |
| `SCRIPT_OVERRIDES_WIND_ELEVATION` | `void SCRIPT_OVERRIDES_WIND_ELEVATION(bool p0, object p1)` | void | - |
| `SET_AGGRESSIVE_HORNS` | `void SET_AGGRESSIVE_HORNS(bool toggle)` | void | Makes pedestrians sound their horn longer, faster and more agressive when they use their horn. |
| `SET_AMBIENT_VOICE_NAME` | `void SET_AMBIENT_VOICE_NAME(int ped, string name)` | void | Audio List<br>gtaforums.com/topic/795622-audio-for-mods/<br><br>All found occurrences in b617d, sorted alphab... |
| `SET_AMBIENT_VOICE_NAME_HASH` | `void SET_AMBIENT_VOICE_NAME_HASH(int ped, uint hash)` | void | - |
| `SET_AMBIENT_ZONE_LIST_STATE` | `void SET_AMBIENT_ZONE_LIST_STATE(string ambientZone, bool p1, bool p2)` | void | - |
| `SET_AMBIENT_ZONE_LIST_STATE_PERSISTENT` | `void SET_AMBIENT_ZONE_LIST_STATE_PERSISTENT(string ambientZone, bool p1, bool p2)` | void | Full list of ambient zones by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/a... |
| `SET_AMBIENT_ZONE_STATE` | `void SET_AMBIENT_ZONE_STATE(string zoneName, bool p1, bool p2)` | void | Full list of ambient zones by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/a... |
| `SET_AMBIENT_ZONE_STATE_PERSISTENT` | `void SET_AMBIENT_ZONE_STATE_PERSISTENT(string ambientZone, bool p1, bool p2)` | void | Full list of ambient zones by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/a... |
| `SET_ANIMAL_MOOD` | `void SET_ANIMAL_MOOD(int animal, int mood)` | void | mood can be 0 or 1 (it's not a boolean value!). Effects audio of the animal. |
| `SET_AUDIO_FLAG` | `void SET_AUDIO_FLAG(string flagName, bool toggle)` | void | Possible flag names:<br>"ActivateSwitchWheelAudio"<br>"AllowAmbientSpeechInSlowMo"<br>"AllowCutsceneOverScree... |
| `SET_AUDIO_SCENE_VARIABLE` | `void SET_AUDIO_SCENE_VARIABLE(string scene, string variable, float value)` | void | Full list of audio scene names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/maste... |
| `SET_AUDIO_SCRIPT_CLEANUP_TIME` | `void SET_AUDIO_SCRIPT_CLEANUP_TIME(int time)` | void | - |
| `SET_AUDIO_SPECIAL_EFFECT_MODE` | `void SET_AUDIO_SPECIAL_EFFECT_MODE(int mode)` | void | Needs to be called every frame.<br>Audio mode to apply this frame: https://alloc8or.re/gta5/doc/enums/a... |
| `SET_AUDIO_VEHICLE_PRIORITY` | `void SET_AUDIO_VEHICLE_PRIORITY(int vehicle, object p1)` | void | - |
| `SET_CONVERSATION_AUDIO_CONTROLLED_BY_ANIM` | `void SET_CONVERSATION_AUDIO_CONTROLLED_BY_ANIM(bool p0)` | void | - |
| `SET_CONVERSATION_AUDIO_PLACEHOLDER` | `void SET_CONVERSATION_AUDIO_PLACEHOLDER(bool p0)` | void | - |
| `SET_CUSTOM_RADIO_TRACK_LIST` | `void SET_CUSTOM_RADIO_TRACK_LIST(string radioStation, string trackListName, bool p2)` | void | Examples:<br><br>AUDIO::SET_CUSTOM_RADIO_TRACK_LIST("RADIO_01_CLASS_ROCK", "END_CREDITS_KILL_MICHAEL", 1);... |
| `SET_CUTSCENE_AUDIO_OVERRIDE` | `void SET_CUTSCENE_AUDIO_OVERRIDE(string name)` | void | All occurrences found in b617d, sorted alphabetically and identical lines removed: <br><br>AUDIO::SET_CUTS... |
| `SET_EMITTER_RADIO_STATION` | `void SET_EMITTER_RADIO_STATION(string emitterName, string radioStation, object p2)` | void | Full list of static emitters by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master... |
| `SET_ENTITY_FOR_NULL_CONV_PED` | `void SET_ENTITY_FOR_NULL_CONV_PED(int p0, int entity)` | void | - |
| `SET_FRONTEND_RADIO_ACTIVE` | `void SET_FRONTEND_RADIO_ACTIVE(bool active)` | void | - |
| `SET_GLOBAL_RADIO_SIGNAL_LEVEL` | `void SET_GLOBAL_RADIO_SIGNAL_LEVEL(object p0)` | void | - |
| `SET_GPS_ACTIVE` | `void SET_GPS_ACTIVE(bool active)` | void | - |
| `SET_HORN_ENABLED` | `void SET_HORN_ENABLED(int vehicle, bool toggle)` | void | - |
| `SET_HORN_PERMANENTLY_ON` | `void SET_HORN_PERMANENTLY_ON(int vehicle)` | void | - |
| `SET_HORN_PERMANENTLY_ON_TIME` | `void SET_HORN_PERMANENTLY_ON_TIME(int vehicle, float time)` | void | - |
| `SET_INDIVIDUAL_PORTAL_SETTINGS_OVERRIDE` | `void SET_INDIVIDUAL_PORTAL_SETTINGS_OVERRIDE(uint interiorNameHash, int roomIndex, int doorIndex, string newPortalSettingsName)` | void | - |
| `SET_INITIAL_PLAYER_STATION` | `void SET_INITIAL_PLAYER_STATION(string radioStation)` | void | - |
| `SET_MICROPHONE_POSITION` | `void SET_MICROPHONE_POSITION(bool toggle, float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3)` | void | This native controls where the game plays audio from. By default the microphone is positioned on the... |
| `SET_MOBILE_PHONE_RADIO_STATE` | `void SET_MOBILE_PHONE_RADIO_STATE(bool state)` | void | - |
| `SET_MOBILE_RADIO_ENABLED_DURING_GAMEPLAY` | `void SET_MOBILE_RADIO_ENABLED_DURING_GAMEPLAY(bool toggle)` | void | - |
| `SET_NEXT_RADIO_TRACK` | `void SET_NEXT_RADIO_TRACK(string radioName, string radioTrack, string p2, string p3)` | void | - |
| `SET_NO_DUCKING_FOR_CONVERSATION` | `void SET_NO_DUCKING_FOR_CONVERSATION(bool p0)` | void | - |
| `SET_PED_CLOTH_EVENTS_ENABLED` | `void SET_PED_CLOTH_EVENTS_ENABLED(int ped, bool toggle)` | void | Enables/disables ped's "quiet" footstep sound. |
| `SET_PED_FOOTSTEPS_EVENTS_ENABLED` | `void SET_PED_FOOTSTEPS_EVENTS_ENABLED(int ped, bool toggle)` | void | Enables/disables ped's "loud" footstep sound. |
| `SET_PED_GENDER` | `void SET_PED_GENDER(int ped, bool p1)` | void | BOOL p1: 0 = Female; 1 = Male |
| `SET_PED_INTERIOR_WALLA_DENSITY` | `void SET_PED_INTERIOR_WALLA_DENSITY(float p0, float p1)` | void | - |
| `SET_PED_IS_DRUNK` | `void SET_PED_IS_DRUNK(int ped, bool toggle)` | void | Sets the ped drunk sounds.  Only works with PLAYER_PED_ID<br><br>=========================================... |
| `SET_PED_RACE_AND_VOICE_GROUP` | `void SET_PED_RACE_AND_VOICE_GROUP(int ped, int p1, uint voiceGroup)` | void | - |
| `SET_PED_VOICE_FULL` | `void SET_PED_VOICE_FULL(int ped)` | void | Assigns some ambient voice to the ped. |
| `SET_PED_VOICE_GROUP` | `void SET_PED_VOICE_GROUP(int ped, uint voiceGroupHash)` | void | From the scripts:<br><br>AUDIO::SET_PED_VOICE_GROUP(PLAYER::PLAYER_PED_ID(), MISC::GET_HASH_KEY("PAIGE_PVG... |
| `SET_PED_VOICE_GROUP_FROM_RACE_TO_PVG` | `void SET_PED_VOICE_GROUP_FROM_RACE_TO_PVG(int ped, uint voiceGroupHash)` | void | Dat151RelType == 29 |
| `SET_PED_WALLA_DENSITY` | `void SET_PED_WALLA_DENSITY(float p0, float p1)` | void | - |
| `SET_PLAYER_ANGRY` | `void SET_PLAYER_ANGRY(int ped, bool toggle)` | void | - |
| `SET_PLAYER_VEHICLE_ALARM_AUDIO_ACTIVE` | `void SET_PLAYER_VEHICLE_ALARM_AUDIO_ACTIVE(int vehicle, bool toggle)` | void | - |
| `SET_PORTAL_SETTINGS_OVERRIDE` | `void SET_PORTAL_SETTINGS_OVERRIDE(string p0, string p1)` | void | Found in the b617d scripts, duplicates removed:  <br><br>AUDIO::SET_PORTAL_SETTINGS_OVERRIDE("V_CARSHOWROO... |
| `SET_POSITIONED_PLAYER_VEHICLE_RADIO_EMITTER_ENABLED` | `void SET_POSITIONED_PLAYER_VEHICLE_RADIO_EMITTER_ENABLED(object p0)` | void | - |
| `SET_POSITION_FOR_NULL_CONV_PED` | `void SET_POSITION_FOR_NULL_CONV_PED(object p0, float p1, float p2, float p3)` | void | - |
| `SET_RADIO_AUTO_UNFREEZE` | `void SET_RADIO_AUTO_UNFREEZE(bool toggle)` | void | - |
| `SET_RADIO_FRONTEND_FADE_TIME` | `void SET_RADIO_FRONTEND_FADE_TIME(float fadeTime)` | void | - |
| `SET_RADIO_POSITION_AUDIO_MUTE` | `void SET_RADIO_POSITION_AUDIO_MUTE(bool p0)` | void | Does nothing (it's a nullsub). |
| `SET_RADIO_RETUNE_DOWN` | `void SET_RADIO_RETUNE_DOWN()` | void | Tune Backwards... |
| `SET_RADIO_RETUNE_UP` | `void SET_RADIO_RETUNE_UP()` | void | Tune Forward... |
| `SET_RADIO_STATION_AS_FAVOURITE` | `void SET_RADIO_STATION_AS_FAVOURITE(string radioStation, bool toggle)` | void | Doesn't have an effect in Story Mode. |
| `SET_RADIO_STATION_MUSIC_ONLY` | `void SET_RADIO_STATION_MUSIC_ONLY(string radioStation, bool toggle)` | void | 6 calls in the b617d scripts, removed identical lines:<br><br>AUDIO::SET_RADIO_STATION_MUSIC_ONLY("RADIO_0... |
| `SET_RADIO_TO_STATION_INDEX` | `void SET_RADIO_TO_STATION_INDEX(int radioStation)` | void | Sets radio station by index. |
| `SET_RADIO_TO_STATION_NAME` | `void SET_RADIO_TO_STATION_NAME(string stationName)` | void | List of radio stations that are in the wheel, in clockwise order, as of LS Tuners DLC: https://git.i... |
| `SET_RADIO_TRACK` | `void SET_RADIO_TRACK(string radioStation, string radioTrack)` | void | Only found this one in the decompiled scripts:<br><br>AUDIO::SET_RADIO_TRACK("RADIO_03_HIPHOP_NEW", "ARM1_... |
| `SET_RADIO_TRACK_WITH_START_OFFSET` | `void SET_RADIO_TRACK_WITH_START_OFFSET(string radioStationName, string mixName, int p2)` | void | - |
| `SET_SCRIPT_UPDATE_DOOR_AUDIO` | `void SET_SCRIPT_UPDATE_DOOR_AUDIO(uint doorHash, bool toggle)` | void | - |
| `SET_SIREN_BYPASS_MP_DRIVER_CHECK` | `void SET_SIREN_BYPASS_MP_DRIVER_CHECK(int vehicle, bool toggle)` | void | - |
| `SET_SIREN_CAN_BE_CONTROLLED_BY_AUDIO` | `void SET_SIREN_CAN_BE_CONTROLLED_BY_AUDIO(int vehicle, bool p1)` | void | - |
| `SET_SIREN_WITH_NO_DRIVER` | `void SET_SIREN_WITH_NO_DRIVER(int vehicle, bool toggle)` | void | - |
| `SET_SKIP_MINIGUN_SPIN_UP_AUDIO` | `void SET_SKIP_MINIGUN_SPIN_UP_AUDIO(bool p0)` | void | - |
| `SET_STATIC_EMITTER_ENABLED` | `void SET_STATIC_EMITTER_ENABLED(string emitterName, bool toggle)` | void | Example:<br>AUDIO::SET_STATIC_EMITTER_ENABLED((Any*)"LOS_SANTOS_VANILLA_UNICORN_01_STAGE", false);    A... |
| `SET_USER_RADIO_CONTROL_ENABLED` | `void SET_USER_RADIO_CONTROL_ENABLED(bool toggle)` | void | - |
| `SET_VARIABLE_ON_SOUND` | `void SET_VARIABLE_ON_SOUND(int soundId, string variable, float p2)` | void | - |
| `SET_VARIABLE_ON_STREAM` | `void SET_VARIABLE_ON_STREAM(string variable, float p1)` | void | From the scripts, p0:<br><br>"ArmWrestlingIntensity",<br>"INOUT",<br>"Monkey_Stream",<br>"ZoomLevel" |
| `SET_VARIABLE_ON_SYNCH_SCENE_AUDIO` | `void SET_VARIABLE_ON_SYNCH_SCENE_AUDIO(string variableName, float value)` | void | - |
| `SET_VARIABLE_ON_UNDER_WATER_STREAM` | `void SET_VARIABLE_ON_UNDER_WATER_STREAM(string variableName, float value)` | void | AUDIO::SET_VARIABLE_ON_UNDER_WATER_STREAM("inTunnel", 1.0);<br>AUDIO::SET_VARIABLE_ON_UNDER_WATER_STREA... |
| `SET_VEHICLE_AUDIO_BODY_DAMAGE_FACTOR` | `void SET_VEHICLE_AUDIO_BODY_DAMAGE_FACTOR(int vehicle, float intensity)` | void | intensity: 0.0f - 1.0f, only used once with 1.0f in R* Scripts (nigel2)<br>Makes an engine rattling noi... |
| `SET_VEHICLE_AUDIO_ENGINE_DAMAGE_FACTOR` | `void SET_VEHICLE_AUDIO_ENGINE_DAMAGE_FACTOR(int vehicle, float damageFactor)` | void | - |
| `SET_VEHICLE_BOOST_ACTIVE` | `void SET_VEHICLE_BOOST_ACTIVE(int vehicle, bool toggle)` | void | SET_VEHICLE_BOOST_ACTIVE(vehicle, 1, 0);<br>SET_VEHICLE_BOOST_ACTIVE(vehicle, 0, 0); <br><br>Will give a boos... |
| `SET_VEHICLE_CONVERSATIONS_PERSIST` | `void SET_VEHICLE_CONVERSATIONS_PERSIST(bool p0, bool p1)` | void | - |
| `SET_VEHICLE_CONVERSATIONS_PERSIST_NEW` | `void SET_VEHICLE_CONVERSATIONS_PERSIST_NEW(bool p0, bool p1, bool p2)` | void | - |
| `SET_VEHICLE_FORCE_REVERSE_WARNING` | `void SET_VEHICLE_FORCE_REVERSE_WARNING(object p0, object p1)` | void | - |
| `SET_VEHICLE_HORN_SOUND_INDEX` | `void SET_VEHICLE_HORN_SOUND_INDEX(int vehicle, int value)` | void | - |
| `SET_VEHICLE_MISSILE_WARNING_ENABLED` | `void SET_VEHICLE_MISSILE_WARNING_ENABLED(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_RADIO_ENABLED` | `void SET_VEHICLE_RADIO_ENABLED(int vehicle, bool toggle)` | void | can't seem to enable radio on cop cars etc |
| `SET_VEHICLE_RADIO_LOUD` | `void SET_VEHICLE_RADIO_LOUD(int vehicle, bool toggle)` | void | - |
| `SET_VEHICLE_STARTUP_REV_SOUND` | `void SET_VEHICLE_STARTUP_REV_SOUND(int vehicle, string p1, string p2)` | void | - |
| `SET_VEH_FORCED_RADIO_THIS_FRAME` | `void SET_VEH_FORCED_RADIO_THIS_FRAME(int vehicle)` | void | - |
| `SET_VEH_HAS_NORMAL_RADIO` | `void SET_VEH_HAS_NORMAL_RADIO(int vehicle)` | void | - |
| `SET_VEH_RADIO_STATION` | `void SET_VEH_RADIO_STATION(int vehicle, string radioStation)` | void | List of radio stations that are in the wheel, in clockwise order, as of LS Tuners DLC: https://git.i... |
| `SKIP_RADIO_FORWARD` | `void SKIP_RADIO_FORWARD()` | void | - |
| `SKIP_TO_NEXT_SCRIPTED_CONVERSATION_LINE` | `void SKIP_TO_NEXT_SCRIPTED_CONVERSATION_LINE()` | void | - |
| `START_ALARM` | `void START_ALARM(string alarmName, bool p2)` | void | Example:<br><br>This will start the alarm at Fort Zancudo.<br><br>AUDIO::START_ALARM("PORT_OF_LS_HEIST_FORT_ZANC... |
| `START_AUDIO_SCENE` | `bool START_AUDIO_SCENE(string scene)` | bool | Used to prepare a scene where the surrounding sound is muted or a bit changed. This does not play an... |
| `START_PRELOADED_CONVERSATION` | `void START_PRELOADED_CONVERSATION()` | void | - |
| `START_SCRIPT_CONVERSATION` | `void START_SCRIPT_CONVERSATION(bool p0, bool p1, bool p2, bool p3)` | void | - |
| `START_SCRIPT_PHONE_CONVERSATION` | `void START_SCRIPT_PHONE_CONVERSATION(bool p0, bool p1)` | void | - |
| `STOP_ALARM` | `void STOP_ALARM(string alarmName, bool toggle)` | void | Example:<br><br>This will stop the alarm at Fort Zancudo.<br><br>AUDIO::STOP_ALARM("PORT_OF_LS_HEIST_FORT_ZANCUD... |
| `STOP_ALL_ALARMS` | `void STOP_ALL_ALARMS(bool stop)` | void | - |
| `STOP_AUDIO_SCENE` | `void STOP_AUDIO_SCENE(string scene)` | void | Full list of audio scene names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/maste... |
| `STOP_AUDIO_SCENES` | `void STOP_AUDIO_SCENES()` | void | - |
| `STOP_CURRENT_PLAYING_AMBIENT_SPEECH` | `void STOP_CURRENT_PLAYING_AMBIENT_SPEECH(int ped)` | void | - |
| `STOP_CURRENT_PLAYING_SPEECH` | `void STOP_CURRENT_PLAYING_SPEECH(int ped)` | void | - |
| `STOP_CUTSCENE_AUDIO` | `void STOP_CUTSCENE_AUDIO()` | void | - |
| `STOP_PED_RINGTONE` | `void STOP_PED_RINGTONE(int ped)` | void | - |
| `STOP_PED_SPEAKING` | `void STOP_PED_SPEAKING(int ped, bool shaking)` | void | - |
| `STOP_PED_SPEAKING_SYNCED` | `void STOP_PED_SPEAKING_SYNCED(int ped, bool p1)` | void | - |
| `STOP_SCRIPTED_CONVERSATION` | `int STOP_SCRIPTED_CONVERSATION(bool p0)` | int | - |
| `STOP_SMOKE_GRENADE_EXPLOSION_SOUNDS` | `void STOP_SMOKE_GRENADE_EXPLOSION_SOUNDS()` | void | - |
| `STOP_SOUND` | `void STOP_SOUND(int soundId)` | void | - |
| `STOP_STREAM` | `void STOP_STREAM()` | void | - |
| `STOP_SYNCHRONIZED_AUDIO_EVENT` | `bool STOP_SYNCHRONIZED_AUDIO_EVENT(int sceneID)` | bool | - |
| `TRIGGER_MUSIC_EVENT` | `bool TRIGGER_MUSIC_EVENT(string eventName)` | bool | List of all usable event names found in b617d used with this native. Sorted alphabetically and ident... |
| `TRIGGER_SIREN_AUDIO` | `void TRIGGER_SIREN_AUDIO(int vehicle)` | void | - |
| `UNBLOCK_SPEECH_CONTEXT_GROUP` | `void UNBLOCK_SPEECH_CONTEXT_GROUP(string p0)` | void | - |
| `UNFREEZE_RADIO_STATION` | `void UNFREEZE_RADIO_STATION(string radioStation)` | void | - |
| `UNHINT_AMBIENT_AUDIO_BANK` | `void UNHINT_AMBIENT_AUDIO_BANK()` | void | - |
| `UNHINT_NAMED_SCRIPT_AUDIO_BANK` | `void UNHINT_NAMED_SCRIPT_AUDIO_BANK(string audioBank)` | void | - |
| `UNHINT_SCRIPT_AUDIO_BANK` | `void UNHINT_SCRIPT_AUDIO_BANK()` | void | - |
| `UNLOCK_MISSION_NEWS_STORY` | `void UNLOCK_MISSION_NEWS_STORY(int newsStory)` | void | "news" that play on the radio after you've done something in story mode(?) |
| `UNLOCK_RADIO_STATION_TRACK_LIST` | `void UNLOCK_RADIO_STATION_TRACK_LIST(string radioStation, string trackListName)` | void | AUDIO::UNLOCK_RADIO_STATION_TRACK_LIST("RADIO_16_SILVERLAKE", "MIRRORPARK_LOCKED"); |
| `UNREGISTER_SCRIPT_WITH_AUDIO` | `void UNREGISTER_SCRIPT_WITH_AUDIO()` | void | This native does absolutely nothing, just a nullsub |
| `UNREQUEST_TENNIS_BANKS` | `void UNREQUEST_TENNIS_BANKS()` | void | - |
| `UPDATE_SOUND_COORD` | `void UPDATE_SOUND_COORD(int soundId, float x, float y, float z)` | void | - |
| `UPDATE_UNLOCKABLE_DJ_RADIO_TRACKS` | `void UPDATE_UNLOCKABLE_DJ_RADIO_TRACKS(bool enableMixes)` | void | Just a nullsub (i.e. does absolutely nothing) since build 1604. |
| `USE_FOOTSTEP_SCRIPT_SWEETENERS` | `void USE_FOOTSTEP_SCRIPT_SWEETENERS(int ped, bool p1, uint hash)` | void | - |
| `USE_SIREN_AS_HORN` | `void USE_SIREN_AS_HORN(int vehicle, bool toggle)` | void | - |
| `_ENABLE_DRAG_RACE_STATIONARY_WARNING_SOUNDS` | `void _ENABLE_DRAG_RACE_STATIONARY_WARNING_SOUNDS(int vehicle, bool enable)` | void | - |
| `_FORCE_VEHICLE_ENGINE_SYNTH` | `void _FORCE_VEHICLE_ENGINE_SYNTH(int vehicle, bool force)` | void | Called together with SET_VEHICLE_TYRES_CAN_BURST |

---

## 详细说明

### ACTIVATE_AUDIO_SLOWMO_MODE

- **命名空间:** `AUDIO`
- **Hash:** `0xD01005D2BA2EB778`
- **JHash:** `0x59A3A17D`
- **Build:** `323`

**C# 签名:**
```csharp
void ACTIVATE_AUDIO_SLOWMO_MODE(string mode)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `mode` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
mode can be any of these: 
SLOWMO_T1_TRAILER_SMASH
SLOWMO_T1_RAYFIRE_EXPLOSION
SLOWMO_PROLOGUE_VAULT
NIGEL_02_SLOWMO_SETTING
JSH_EXIT_TUNNEL_SLOWMO
SLOWMO_BIG_SCORE_JUMP
SLOWMO_FIB4_TRUCK_SMASH
SLOWMO_EXTREME_04
SLOW_MO_METH_HOUSE_RAYFIRE
BARRY_02_SLOWMO
BARRY_01_SLOWMO
```

---

### ADD_ENTITY_TO_AUDIO_MIX_GROUP

- **命名空间:** `AUDIO`
- **Hash:** `0x153973AB99FE8980`
- **JHash:** `0x2BC93264`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_ENTITY_TO_AUDIO_MIX_GROUP(int entity, string groupName, float p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `groupName` | `const char*` | `string` | - |
| `p2` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
All found occurrences in b678d:
https://pastebin.com/ceu67jz8
```

---

### ADD_LINE_TO_CONVERSATION

- **命名空间:** `AUDIO`
- **Hash:** `0xC5EF963405593646`
- **JHash:** `0x96CD0513`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_LINE_TO_CONVERSATION(int index, string p1, string p2, int p3, int p4, bool p5, bool p6, bool p7, bool p8, int p9, bool p10, bool p11, bool p12)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |
| `p1` | `const char*` | `string` | - |
| `p2` | `const char*` | `string` | - |
| `p3` | `int` | `int` | - |
| `p4` | `int` | `int` | - |
| `p5` | `BOOL` | `bool` | - |
| `p6` | `BOOL` | `bool` | - |
| `p7` | `BOOL` | `bool` | - |
| `p8` | `BOOL` | `bool` | - |
| `p9` | `int` | `int` | - |
| `p10` | `BOOL` | `bool` | - |
| `p11` | `BOOL` | `bool` | - |
| `p12` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
NOTE: ones that are -1, 0 - 35 are determined by a function where it gets a TextLabel from a global then runs,
GET_CHARACTER_FROM_AUDIO_CONVERSATION_FILENAME and depending on what the result is it goes in check order of 0 - 9 then A - Z then z (lowercase). So it will then return 0 - 35 or -1 if it's 'z'. The func to handle that ^^ is func_67 in dialog_handler.c atleast in TU27 Xbox360 scripts.

p0 is -1, 0 - 35
p1 is a char or string (whatever you wanna call it)
p2 is Global 10597 + i * 6. 'i' is a while(i < 70) loop
p3 is again -1, 0 - 35 
p4 is again -1, 0 - 35 
p5 is either 0 or 1 (bool ?)
p6 is either 0 or 1 (The func to determine this is bool)
p7 is either 0 or 1 (The func to determine this is bool)
p8 is either 0 or 1 (The func to determine this is bool)
p9 is 0 - 3 (Determined by func_60 in dialogue_handler.c)
p10 is either 0 or 1 (The func to determine this is bool)
p11 is either 0 or 1 (The func to determine this is bool)
p12 is unknown as in TU27 X360 scripts it only goes to p11.
```

---

### ADD_PED_TO_CONVERSATION

- **命名空间:** `AUDIO`
- **Hash:** `0x95D9F4BC443956E7`
- **JHash:** `0xF8D5EB86`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_PED_TO_CONVERSATION(int index, int ped, string p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |
| `ped` | `Ped` | `int` | - |
| `p2` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
4 calls in the b617d scripts. The only one with p0 and p2 in clear text:

AUDIO::ADD_PED_TO_CONVERSATION(5, l_AF, "DINAPOLI");

=================================================
One of the 2 calls in dialogue_handler.c p0 is in a while-loop, and so is determined to also possibly be 0 - 15.
```

---

### AUDIO_IS_MUSIC_PLAYING

- **命名空间:** `AUDIO`
- **Hash:** `0x845FFC3A4FEEFA3E`
- **Build:** `323`

**C# 签名:**
```csharp
bool AUDIO_IS_MUSIC_PLAYING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### AUDIO_IS_SCRIPTED_MUSIC_PLAYING

- **命名空间:** `AUDIO`
- **Hash:** `0x2DD39BF3E2F9C47F`
- **Build:** `463`

**C# 签名:**
```csharp
bool AUDIO_IS_SCRIPTED_MUSIC_PLAYING()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
This is an alias of AUDIO_IS_MUSIC_PLAYING.
```

---

### BLIP_SIREN

- **命名空间:** `AUDIO`
- **Hash:** `0x1B9025BDA76822B6`
- **JHash:** `0xC0EB6924`
- **Build:** `323`

**C# 签名:**
```csharp
void BLIP_SIREN(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Plays the siren sound of a vehicle which is otherwise activated when fastly double-pressing the horn key.
Only works on vehicles with a police siren.
```

---

### BLOCK_ALL_SPEECH_FROM_PED

- **命名空间:** `AUDIO`
- **Hash:** `0xF8AD2EED7C47E8FE`
- **Build:** `1734`

**C# 签名:**
```csharp
void BLOCK_ALL_SPEECH_FROM_PED(int ped, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### BLOCK_DEATH_JINGLE

- **命名空间:** `AUDIO`
- **Hash:** `0xF154B8D1775B2DEC`
- **JHash:** `0xD2858D8A`
- **Build:** `323`

**C# 签名:**
```csharp
void BLOCK_DEATH_JINGLE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### BLOCK_SPEECH_CONTEXT_GROUP

- **命名空间:** `AUDIO`
- **Hash:** `0xA8A7D434AFB4B97B`
- **Build:** `1493`

**C# 签名:**
```csharp
void BLOCK_SPEECH_CONTEXT_GROUP(string p0, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `const char*` | `string` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CANCEL_ALL_POLICE_REPORTS

- **命名空间:** `AUDIO`
- **Hash:** `0xB4F90FAF7670B16F`
- **Build:** `323`

**C# 签名:**
```csharp
void CANCEL_ALL_POLICE_REPORTS()
```

**返回值:** `void` (Native: `void`)

---

### CANCEL_MUSIC_EVENT

- **命名空间:** `AUDIO`
- **Hash:** `0x5B17A90291133DA5`
- **JHash:** `0x89FF942D`
- **Build:** `323`

**C# 签名:**
```csharp
bool CANCEL_MUSIC_EVENT(string eventName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `eventName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
All music event names found in the b617d scripts: https://pastebin.com/GnYt0R3P
Full list of music event names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/musicEventNames.json
```

---

### CAN_VEHICLE_RECEIVE_CB_RADIO

- **命名空间:** `AUDIO`
- **Hash:** `0x032A116663A4D5AC`
- **JHash:** `0xCBA99F4A`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_VEHICLE_RECEIVE_CB_RADIO(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CLEAR_ALL_BROKEN_GLASS

- **命名空间:** `AUDIO`
- **Hash:** `0xB32209EFFDC04913`
- **JHash:** `0xE6B033BF`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_ALL_BROKEN_GLASS()
```

**返回值:** `void` (Native: `void`)

---

### CLEAR_AMBIENT_ZONE_LIST_STATE

- **命名空间:** `AUDIO`
- **Hash:** `0x120C48C614909FA4`
- **JHash:** `0x38B9B8D4`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_AMBIENT_ZONE_LIST_STATE(string ambientZone, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ambientZone` | `const char*` | `string` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_AMBIENT_ZONE_STATE

- **命名空间:** `AUDIO`
- **Hash:** `0x218DD44AAAC964FF`
- **JHash:** `0xCDFF3C82`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_AMBIENT_ZONE_STATE(string zoneName, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `zoneName` | `const char*` | `string` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This function also has a p2, unknown. Signature AUDIO::CLEAR_AMBIENT_ZONE_STATE(const char* zoneName, bool p1, Any p2);

Still needs more research.

Full list of ambient zones by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/ambientZones.json
```

---

### CLEAR_CUSTOM_RADIO_TRACK_LIST

- **命名空间:** `AUDIO`
- **Hash:** `0x1654F24A88A8E3FE`
- **JHash:** `0x1D766976`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_CUSTOM_RADIO_TRACK_LIST(string radioStation)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `radioStation` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
3 calls in the b617d scripts, removed duplicate.

AUDIO::CLEAR_CUSTOM_RADIO_TRACK_LIST("RADIO_16_SILVERLAKE");
AUDIO::CLEAR_CUSTOM_RADIO_TRACK_LIST("RADIO_01_CLASS_ROCK");
```

---

### CREATE_NEW_SCRIPTED_CONVERSATION

- **命名空间:** `AUDIO`
- **Hash:** `0xD2C91A0B572AAE56`
- **JHash:** `0xB2BC25F8`
- **Build:** `323`

**C# 签名:**
```csharp
void CREATE_NEW_SCRIPTED_CONVERSATION()
```

**返回值:** `void` (Native: `void`)

---

### DEACTIVATE_AUDIO_SLOWMO_MODE

- **命名空间:** `AUDIO`
- **Hash:** `0xDDC635D5B3262C56`
- **JHash:** `0x0E387BFE`
- **Build:** `323`

**C# 签名:**
```csharp
void DEACTIVATE_AUDIO_SLOWMO_MODE(string mode)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `mode` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
see ACTIVATE_AUDIO_SLOWMO_MODE for modes
```

---

### DISABLE_PED_PAIN_AUDIO

- **命名空间:** `AUDIO`
- **Hash:** `0xA9A41C1E940FB0E8`
- **JHash:** `0x3B8E2D5F`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_PED_PAIN_AUDIO(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### DISTANT_COP_CAR_SIRENS

- **命名空间:** `AUDIO`
- **Hash:** `0x552369F549563AD5`
- **JHash:** `0x13EB5861`
- **Build:** `323`

**C# 签名:**
```csharp
void DISTANT_COP_CAR_SIRENS(bool value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
If value is set to true, and ambient siren sound will be played.
Appears to enable/disable an audio flag.
```

---

### DOES_CONTEXT_EXIST_FOR_THIS_PED

- **命名空间:** `AUDIO`
- **Hash:** `0x49B99BF3FDA89A7A`
- **JHash:** `0x8BD5F11E`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_CONTEXT_EXIST_FOR_THIS_PED(int ped, string speechName, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `speechName` | `const char*` | `string` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Checks if the ped can play the speech or has the speech file, p2 is usually false.
```

---

### DOES_PLAYER_VEH_HAVE_RADIO

- **命名空间:** `AUDIO`
- **Hash:** `0x109697E2FFBAC8A1`
- **JHash:** `0x46B0C696`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_PLAYER_VEH_HAVE_RADIO()
```

**返回值:** `bool` (Native: `BOOL`)

---

### ENABLE_STALL_WARNING_SOUNDS

- **命名空间:** `AUDIO`
- **Hash:** `0xC15907D667F7CFB2`
- **JHash:** `0x563B635D`
- **Build:** `323`

**C# 签名:**
```csharp
void ENABLE_STALL_WARNING_SOUNDS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Works for planes only.
```

---

### ENABLE_STUNT_JUMP_AUDIO

- **命名空间:** `AUDIO`
- **Hash:** `0xB81CF134AEB56FFB`
- **Build:** `791`

**C# 签名:**
```csharp
void ENABLE_STUNT_JUMP_AUDIO()
```

**返回值:** `void` (Native: `void`)

---

### ENABLE_VEHICLE_EXHAUST_POPS

- **命名空间:** `AUDIO`
- **Hash:** `0x2BE4BC731D039D5A`
- **JHash:** `0x2A60A90E`
- **Build:** `323`

**C# 签名:**
```csharp
void ENABLE_VEHICLE_EXHAUST_POPS(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### ENABLE_VEHICLE_FANBELT_DAMAGE

- **命名空间:** `AUDIO`
- **Hash:** `0x1C073274E065C6D2`
- **JHash:** `0x9365E042`
- **Build:** `323`

**C# 签名:**
```csharp
void ENABLE_VEHICLE_FANBELT_DAMAGE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### FIND_RADIO_STATION_INDEX

- **命名空间:** `AUDIO`
- **Hash:** `0x8D67489793FF428B`
- **JHash:** `0xECA1512F`
- **Build:** `323`

**C# 签名:**
```csharp
int FIND_RADIO_STATION_INDEX(uint stationNameHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `stationNameHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

---

### FORCE_MUSIC_TRACK_LIST

- **命名空间:** `AUDIO`
- **Hash:** `0x4E0AF9114608257C`
- **Build:** `2372`

**C# 签名:**
```csharp
void FORCE_MUSIC_TRACK_LIST(string radioStation, string trackListName, int milliseconds)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `radioStation` | `const char*` | `string` | - |
| `trackListName` | `const char*` | `string` | - |
| `milliseconds` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Changes start time of a tracklist (milliseconds)
R* uses a random int: MISC::GET_RANDOM_INT_IN_RANGE(0, 13) * 60000)
```

---

### FORCE_PED_PANIC_WALLA

- **命名空间:** `AUDIO`
- **Hash:** `0x062D5EAD4DA2FA6A`
- **JHash:** `0xD87AF337`
- **Build:** `323`

**C# 签名:**
```csharp
void FORCE_PED_PANIC_WALLA()
```

**返回值:** `void` (Native: `void`)

---

### FORCE_USE_AUDIO_GAME_OBJECT

- **命名空间:** `AUDIO`
- **Hash:** `0x4F0C413926060B38`
- **JHash:** `0x33B0B007`
- **Build:** `323`

**C# 签名:**
```csharp
void FORCE_USE_AUDIO_GAME_OBJECT(int vehicle, string audioName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `audioName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native sets the audio of the specified vehicle to the audioName (p1).

Use the audioNameHash found in vehicles.meta

Example:
_SET_VEHICLE_AUDIO(veh, "ADDER");
The selected vehicle will now have the audio of the Adder.
```

---

### FREEZE_MICROPHONE

- **命名空间:** `AUDIO`
- **Hash:** `0xD57AAAE0E2214D11`
- **JHash:** `0x2B9D91E8`
- **Build:** `323`

**C# 签名:**
```csharp
void FREEZE_MICROPHONE()
```

**返回值:** `void` (Native: `void`)

---

### FREEZE_RADIO_STATION

- **命名空间:** `AUDIO`
- **Hash:** `0x344F393B027E38C3`
- **JHash:** `0x286BF543`
- **Build:** `323`

**C# 签名:**
```csharp
void FREEZE_RADIO_STATION(string radioStation)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `radioStation` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### GET_AMBIENT_VOICE_NAME_HASH

- **命名空间:** `AUDIO`
- **Hash:** `0x5E203DA2BA15D436`
- **Build:** `463`

**C# 签名:**
```csharp
uint GET_AMBIENT_VOICE_NAME_HASH(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `uint` (Native: `Hash`)

---

### GET_AUDIBLE_MUSIC_TRACK_TEXT_ID

- **命名空间:** `AUDIO`
- **Hash:** `0x50B196FC9ED6545B`
- **JHash:** `0xA2B88CA7`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_AUDIBLE_MUSIC_TRACK_TEXT_ID()
```

**返回值:** `int` (Native: `int`)

---

### GET_CURRENT_SCRIPTED_CONVERSATION_LINE

- **命名空间:** `AUDIO`
- **Hash:** `0x480357EE890C295A`
- **JHash:** `0x9620E41F`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_CURRENT_SCRIPTED_CONVERSATION_LINE()
```

**返回值:** `int` (Native: `int`)

---

### GET_CURRENT_TRACK_PLAY_TIME

- **命名空间:** `AUDIO`
- **Hash:** `0x3E65CDE5215832C1`
- **Build:** `1493`

**C# 签名:**
```csharp
int GET_CURRENT_TRACK_PLAY_TIME(string radioStationName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `radioStationName` | `const char*` | `string` | - |

**返回值:** `int` (Native: `int`)

---

### GET_CURRENT_TRACK_SOUND_NAME

- **命名空间:** `AUDIO`
- **Hash:** `0x34D66BC058019CE0`
- **Build:** `1493`

**C# 签名:**
```csharp
uint GET_CURRENT_TRACK_SOUND_NAME(string radioStationName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `radioStationName` | `const char*` | `string` | - |

**返回值:** `uint` (Native: `Hash`)

---

### GET_CURRENT_TV_SHOW_PLAY_TIME

- **命名空间:** `AUDIO`
- **Hash:** `0xDD3AA743AB7D4D75`
- **Build:** `3095`

**C# 签名:**
```csharp
int GET_CURRENT_TV_SHOW_PLAY_TIME()
```

**返回值:** `int` (Native: `int`)

---

### GET_IS_PRELOADED_CONVERSATION_READY

- **命名空间:** `AUDIO`
- **Hash:** `0xE73364DB90778FFA`
- **JHash:** `0x336F3D35`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_IS_PRELOADED_CONVERSATION_READY()
```

**返回值:** `bool` (Native: `BOOL`)

---

### GET_MUSIC_PLAYTIME

- **命名空间:** `AUDIO`
- **Hash:** `0xE7A0D23DC414507B`
- **JHash:** `0xD633C809`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_MUSIC_PLAYTIME()
```

**返回值:** `int` (Native: `int`)

---

### GET_MUSIC_VOL_SLIDER

- **命名空间:** `AUDIO`
- **Hash:** `0x3A48AB4445D499BE`
- **JHash:** `0x93A44A1F`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_MUSIC_VOL_SLIDER()
```

**返回值:** `int` (Native: `int`)

---

### GET_NETWORK_ID_FROM_SOUND_ID

- **命名空间:** `AUDIO`
- **Hash:** `0x2DE3F0A134FFBC0D`
- **JHash:** `0x2576F610`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NETWORK_ID_FROM_SOUND_ID(int soundId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `soundId` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Could this be used alongside either, 
SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES or _SET_NETWORK_ID_SYNC_TO_PLAYER to make it so other players can hear the sound while online? It'd be a bit troll-fun to be able to play the Zancudo UFO creepy sounds globally.
```

---

### GET_NEXT_AUDIBLE_BEAT

- **命名空间:** `AUDIO`
- **Hash:** `0xC64A06D939F826F5`
- **Build:** `1493`

**C# 签名:**
```csharp
bool GET_NEXT_AUDIBLE_BEAT(ref float out1, ref float out2, ref int out3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `out1` | `float*` | `ref float` | - |
| `out2` | `float*` | `ref float` | - |
| `out3` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_NUM_UNLOCKED_RADIO_STATIONS

- **命名空间:** `AUDIO`
- **Hash:** `0xF1620ECB50E01DE7`
- **JHash:** `0xCC91FCF5`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_NUM_UNLOCKED_RADIO_STATIONS()
```

**返回值:** `int` (Native: `int`)

---

### GET_PLAYER_RADIO_STATION_GENRE

- **命名空间:** `AUDIO`
- **Hash:** `0xA571991A7FE6CCEB`
- **JHash:** `0x872CF0EA`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PLAYER_RADIO_STATION_GENRE()
```

**返回值:** `int` (Native: `int`)

---

### GET_PLAYER_RADIO_STATION_INDEX

- **命名空间:** `AUDIO`
- **Hash:** `0xE8AF77C4C06ADC93`
- **JHash:** `0x1C4946AC`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_PLAYER_RADIO_STATION_INDEX()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns 255 (radio off index) if the function fails.
```

---

### GET_PLAYER_RADIO_STATION_NAME

- **命名空间:** `AUDIO`
- **Hash:** `0xF6D733C32076AD03`
- **JHash:** `0xD909C107`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_PLAYER_RADIO_STATION_NAME()
```

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Returns active radio station name
```

---

### GET_RADIO_STATION_NAME

- **命名空间:** `AUDIO`
- **Hash:** `0xB28ECA15046CA8B9`
- **JHash:** `0x3DF493BC`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_RADIO_STATION_NAME(int radioStation)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `radioStation` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Converts radio station index to string. Use HUD::GET_FILENAME_FOR_AUDIO_CONVERSATION to get the user-readable text.
```

---

### GET_SOUND_ID

- **命名空间:** `AUDIO`
- **Hash:** `0x430386FE9BF80B45`
- **JHash:** `0x6AE0AD56`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_SOUND_ID()
```

**返回值:** `int` (Native: `int`)

---

### GET_SOUND_ID_FROM_NETWORK_ID

- **命名空间:** `AUDIO`
- **Hash:** `0x75262FD12D0A1C84`
- **JHash:** `0xD064D4DC`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_SOUND_ID_FROM_NETWORK_ID(int netId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `netId` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_STREAM_PLAY_TIME

- **命名空间:** `AUDIO`
- **Hash:** `0x4E72BBDBCA58A3DB`
- **JHash:** `0xB4F0AD56`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_STREAM_PLAY_TIME()
```

**返回值:** `int` (Native: `int`)

---

### GET_VARIATION_CHOSEN_FOR_SCRIPTED_LINE

- **命名空间:** `AUDIO`
- **Hash:** `0xAA19F5572C38B564`
- **JHash:** `0xB58B8FF3`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VARIATION_CHOSEN_FOR_SCRIPTED_LINE(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `int` (Native: `int`)

---

### GET_VEHICLE_DEFAULT_HORN

- **命名空间:** `AUDIO`
- **Hash:** `0x02165D55000219AC`
- **JHash:** `0xE84ABC19`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_VEHICLE_DEFAULT_HORN(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `uint` (Native: `Hash`)

**说明:**
```
Returns hash of default vehicle horn

Hash is stored in audVehicleAudioEntity
```

---

### GET_VEHICLE_DEFAULT_HORN_IGNORE_MODS

- **命名空间:** `AUDIO`
- **Hash:** `0xACB5DCCA1EC76840`
- **JHash:** `0xFD4B5B3B`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_VEHICLE_DEFAULT_HORN_IGNORE_MODS(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `uint` (Native: `Hash`)

---

### GET_VEHICLE_HORN_SOUND_INDEX

- **命名空间:** `AUDIO`
- **Hash:** `0xD53F3A29BCE2580E`
- **Build:** `1365`

**C# 签名:**
```csharp
int GET_VEHICLE_HORN_SOUND_INDEX(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### HAS_LOADED_MP_DATA_SET

- **命名空间:** `AUDIO`
- **Hash:** `0x544810ED9DB6BBE6`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_LOADED_MP_DATA_SET()
```

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_LOADED_SP_DATA_SET

- **命名空间:** `AUDIO`
- **Hash:** `0x5B50ABB1FE3746F4`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_LOADED_SP_DATA_SET()
```

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_SOUND_FINISHED

- **命名空间:** `AUDIO`
- **Hash:** `0xFCBDCE714A7C88E5`
- **JHash:** `0xE85AEC2E`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_SOUND_FINISHED(int soundId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `soundId` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HINT_AMBIENT_AUDIO_BANK

- **命名空间:** `AUDIO`
- **Hash:** `0x8F8C0E370AE62F5C`
- **JHash:** `0xF1850DDC`
- **Build:** `323`

**C# 签名:**
```csharp
bool HINT_AMBIENT_AUDIO_BANK(string audioBank, bool p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `audioBank` | `const char*` | `string` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p2 is always -1
```

---

### HINT_MISSION_AUDIO_BANK

- **命名空间:** `AUDIO`
- **Hash:** `0x40763EA7B9B783E7`
- **Build:** `573`

**C# 签名:**
```csharp
bool HINT_MISSION_AUDIO_BANK(string audioBank, bool p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `audioBank` | `const char*` | `string` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p2 is always -1
```

---

### HINT_SCRIPT_AUDIO_BANK

- **命名空间:** `AUDIO`
- **Hash:** `0xFB380A29641EC31A`
- **JHash:** `0x41FA0E51`
- **Build:** `323`

**C# 签名:**
```csharp
bool HINT_SCRIPT_AUDIO_BANK(string audioBank, bool p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `audioBank` | `const char*` | `string` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p2 is always -1
```

---

### INIT_SYNCH_SCENE_AUDIO_WITH_ENTITY

- **命名空间:** `AUDIO`
- **Hash:** `0x950A154B8DAB6185`
- **JHash:** `0xA17F9AB0`
- **Build:** `323`

**C# 签名:**
```csharp
void INIT_SYNCH_SCENE_AUDIO_WITH_ENTITY(string audioEvent, int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `audioEvent` | `const char*` | `string` | - |
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### INIT_SYNCH_SCENE_AUDIO_WITH_POSITION

- **命名空间:** `AUDIO`
- **Hash:** `0xC8EDE9BDBCCBA6D4`
- **JHash:** `0x55A21772`
- **Build:** `323`

**C# 签名:**
```csharp
void INIT_SYNCH_SCENE_AUDIO_WITH_POSITION(string audioEvent, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `audioEvent` | `const char*` | `string` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### INTERRUPT_CONVERSATION

- **命名空间:** `AUDIO`
- **Hash:** `0xA018A12E5C5C2FA6`
- **JHash:** `0xF3A67AF3`
- **Build:** `323`

**C# 签名:**
```csharp
void INTERRUPT_CONVERSATION(int ped, string voiceline, string speaker)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `voiceline` | `const char*` | `string` | - |
| `speaker` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Example from carsteal3.c: AUDIO::INTERRUPT_CONVERSATION(PLAYER::PLAYER_PED_ID(), "CST4_CFAA", "FRANKLIN");
Voicelines can be found in GTAV\x64\audio\sfx in files starting with "SS_" which seems to mean scripted speech.
```

---

### INTERRUPT_CONVERSATION_AND_PAUSE

- **命名空间:** `AUDIO`
- **Hash:** `0x8A694D7A68F8DC38`
- **JHash:** `0xDD4A3F1F`
- **Build:** `323`

**C# 签名:**
```csharp
void INTERRUPT_CONVERSATION_AND_PAUSE(int ped, string p1, string speaker)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `const char*` | `string` | - |
| `speaker` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
One call found in the b617d scripts:

AUDIO::INTERRUPT_CONVERSATION_AND_PAUSE(NETWORK::NET_TO_PED(l_3989._f26F[0/*1*/]), "CONV_INTERRUPT_QUIT_IT", "LESTER");
```

---

### IS_ALARM_PLAYING

- **命名空间:** `AUDIO`
- **Hash:** `0x226435CB96CCFC8C`
- **JHash:** `0x9D8E1D23`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ALARM_PLAYING(string alarmName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `alarmName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Example:

bool playing = AUDIO::IS_ALARM_PLAYING("PORT_OF_LS_HEIST_FORT_ZANCUDO_ALARMS");
Full list of alarm names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/alarmSounds.json
```

---

### IS_AMBIENT_SPEECH_DISABLED

- **命名空间:** `AUDIO`
- **Hash:** `0x932C2D096A2C3FFF`
- **JHash:** `0x109D1F89`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_AMBIENT_SPEECH_DISABLED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Common in the scripts:
AUDIO::IS_AMBIENT_SPEECH_DISABLED(PLAYER::PLAYER_PED_ID());
```

---

### IS_AMBIENT_SPEECH_PLAYING

- **命名空间:** `AUDIO`
- **Hash:** `0x9072C8B49907BFAD`
- **JHash:** `0x1972E8AA`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_AMBIENT_SPEECH_PLAYING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_AMBIENT_ZONE_ENABLED

- **命名空间:** `AUDIO`
- **Hash:** `0x01E2817A479A7F9B`
- **JHash:** `0xBFABD872`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_AMBIENT_ZONE_ENABLED(string ambientZone)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ambientZone` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of ambient zones by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/ambientZones.json
```

---

### IS_ANIMAL_VOCALIZATION_PLAYING

- **命名空间:** `AUDIO`
- **Hash:** `0xC265DF9FB44A9FBD`
- **JHash:** `0x0CBAF2EF`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ANIMAL_VOCALIZATION_PLAYING(int pedHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pedHandle` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ANY_POSITIONAL_SPEECH_PLAYING

- **命名空间:** `AUDIO`
- **Hash:** `0x30CA2EF91D15ADF8`
- **Build:** `2189`

**C# 签名:**
```csharp
bool IS_ANY_POSITIONAL_SPEECH_PLAYING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ANY_SPEECH_PLAYING

- **命名空间:** `AUDIO`
- **Hash:** `0x729072355FA39EC9`
- **JHash:** `0x2B74A6D6`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ANY_SPEECH_PLAYING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_AUDIO_SCENE_ACTIVE

- **命名空间:** `AUDIO`
- **Hash:** `0xB65B60556E2A9225`
- **JHash:** `0xACBED05C`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_AUDIO_SCENE_ACTIVE(string scene)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scene` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of audio scene names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/audioSceneNames.json
```

---

### IS_GAME_IN_CONTROL_OF_MUSIC

- **命名空间:** `AUDIO`
- **Hash:** `0x6D28DC1671E334FD`
- **JHash:** `0x7643170D`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_GAME_IN_CONTROL_OF_MUSIC()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Hardcoded to return 1
```

---

### IS_HORN_ACTIVE

- **命名空间:** `AUDIO`
- **Hash:** `0x9D6BFC12B05C6121`
- **JHash:** `0x20E2BDD0`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_HORN_ACTIVE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Checks whether the horn of a vehicle is currently played.
```

---

### IS_MISSION_COMPLETE_PLAYING

- **命名空间:** `AUDIO`
- **Hash:** `0x19A30C23F5827F8A`
- **JHash:** `0x939982A1`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_MISSION_COMPLETE_PLAYING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_MISSION_COMPLETE_READY_FOR_UI

- **命名空间:** `AUDIO`
- **Hash:** `0x6F259F82D873B8B8`
- **JHash:** `0xCBE09AEC`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_MISSION_COMPLETE_READY_FOR_UI()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_MISSION_NEWS_STORY_UNLOCKED

- **命名空间:** `AUDIO`
- **Hash:** `0x66E49BF55B4B1874`
- **JHash:** `0x27305D37`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_MISSION_NEWS_STORY_UNLOCKED(int newsStory)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `newsStory` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_MOBILE_INTERFERENCE_ACTIVE

- **命名空间:** `AUDIO`
- **Hash:** `0xC8B1B2425604CDD0`
- **JHash:** `0x16FB88B5`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_MOBILE_INTERFERENCE_ACTIVE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_MOBILE_PHONE_CALL_ONGOING

- **命名空间:** `AUDIO`
- **Hash:** `0x7497D2CE2C30D24C`
- **JHash:** `0x4ED1400A`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_MOBILE_PHONE_CALL_ONGOING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_MOBILE_PHONE_RADIO_ACTIVE

- **命名空间:** `AUDIO`
- **Hash:** `0xB35CE999E8EF317E`
- **JHash:** `0x6E502A5B`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_MOBILE_PHONE_RADIO_ACTIVE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_MUSIC_ONESHOT_PLAYING

- **命名空间:** `AUDIO`
- **Hash:** `0xA097AB275061FB21`
- **JHash:** `0x2705C4D5`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_MUSIC_ONESHOT_PLAYING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_IN_CURRENT_CONVERSATION

- **命名空间:** `AUDIO`
- **Hash:** `0x049E937F18F4020C`
- **JHash:** `0x7B2F0743`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_IN_CURRENT_CONVERSATION(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PED_RINGTONE_PLAYING

- **命名空间:** `AUDIO`
- **Hash:** `0x1E8E5E20937E3137`
- **JHash:** `0xFE576EE4`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PED_RINGTONE_PLAYING(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PLAYER_VEH_RADIO_ENABLE

- **命名空间:** `AUDIO`
- **Hash:** `0x5F43D83FD6738741`
- **JHash:** `0x2A3E5E8B`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_PLAYER_VEH_RADIO_ENABLE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_RADIO_FADED_OUT

- **命名空间:** `AUDIO`
- **Hash:** `0x0626A247D2405330`
- **JHash:** `0x815CAE99`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_RADIO_FADED_OUT()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_RADIO_RETUNING

- **命名空间:** `AUDIO`
- **Hash:** `0xA151A7394A214E65`
- **JHash:** `0xCF29097B`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_RADIO_RETUNING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_RADIO_STATION_FAVOURITED

- **命名空间:** `AUDIO`
- **Hash:** `0x2B1784DB08AFEA79`
- **Build:** `2699`

**C# 签名:**
```csharp
bool IS_RADIO_STATION_FAVOURITED(string radioStation)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `radioStation` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SCRIPTED_CONVERSATION_LOADED

- **命名空间:** `AUDIO`
- **Hash:** `0xDF0D54BE7A776737`
- **JHash:** `0xE1870EA9`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SCRIPTED_CONVERSATION_LOADED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SCRIPTED_CONVERSATION_ONGOING

- **命名空间:** `AUDIO`
- **Hash:** `0x16754C556D2EDE3D`
- **JHash:** `0xCB8FD96F`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SCRIPTED_CONVERSATION_ONGOING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SCRIPTED_SPEECH_PLAYING

- **命名空间:** `AUDIO`
- **Hash:** `0xCC9AA18DCC7084F4`
- **JHash:** `0x2C653904`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SCRIPTED_SPEECH_PLAYING(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Ped` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_STREAM_PLAYING

- **命名空间:** `AUDIO`
- **Hash:** `0xD11FA52EB849D978`
- **JHash:** `0xF1F51A14`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_STREAM_PLAYING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_VEHICLE_AUDIBLY_DAMAGED

- **命名空间:** `AUDIO`
- **Hash:** `0x5DB8010EE71FDEF2`
- **JHash:** `0x6E660D3F`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_VEHICLE_AUDIBLY_DAMAGED(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_VEHICLE_RADIO_ON

- **命名空间:** `AUDIO`
- **Hash:** `0x0BE4BE946463F917`
- **Build:** `505`

**C# 签名:**
```csharp
bool IS_VEHICLE_RADIO_ON(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### LINK_STATIC_EMITTER_TO_ENTITY

- **命名空间:** `AUDIO`
- **Hash:** `0x651D3228960D08AF`
- **Build:** `505`

**C# 签名:**
```csharp
void LINK_STATIC_EMITTER_TO_ENTITY(string emitterName, int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `emitterName` | `const char*` | `string` | - |
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of static emitters by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/staticEmitters.json
```

---

### LOAD_STREAM

- **命名空间:** `AUDIO`
- **Hash:** `0x1F1F957154EC51DF`
- **JHash:** `0x0D89599D`
- **Build:** `323`

**C# 签名:**
```csharp
bool LOAD_STREAM(string streamName, string soundSet)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `streamName` | `const char*` | `string` | - |
| `soundSet` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Example:
AUDIO::LOAD_STREAM("CAR_STEAL_1_PASSBY", "CAR_STEAL_1_SOUNDSET");

All found occurrences in the b678d decompiled scripts: https://pastebin.com/3rma6w5w

Stream names often ends with "_MASTER", "_SMALL" or "_STREAM". Also "_IN", "_OUT" and numbers.   

soundSet is often set to 0 in the scripts. These are common to end the soundSets: "_SOUNDS", "_SOUNDSET" and numbers.

Full list of audio / sound names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/soundNames.json
```

---

### LOAD_STREAM_WITH_START_OFFSET

- **命名空间:** `AUDIO`
- **Hash:** `0x59C16B79F53B3712`
- **JHash:** `0xE5B5745C`
- **Build:** `323`

**C# 签名:**
```csharp
bool LOAD_STREAM_WITH_START_OFFSET(string streamName, int startOffset, string soundSet)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `streamName` | `const char*` | `string` | - |
| `startOffset` | `int` | `int` | - |
| `soundSet` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Example:
AUDIO::LOAD_STREAM_WITH_START_OFFSET("STASH_TOXIN_STREAM", 2400, "FBI_05_SOUNDS");

Only called a few times in the scripts.

Full list of audio / sound names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/soundNames.json
```

---

### LOCK_RADIO_STATION

- **命名空间:** `AUDIO`
- **Hash:** `0x477D9DB48F889591`
- **Build:** `1493`

**C# 签名:**
```csharp
void LOCK_RADIO_STATION(string radioStationName, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `radioStationName` | `const char*` | `string` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Disables the radio station (hides it from the radio wheel).
```

---

### LOCK_RADIO_STATION_TRACK_LIST

- **命名空间:** `AUDIO`
- **Hash:** `0xFF5E5EA2DCEEACF3`
- **Build:** `2372`

**C# 签名:**
```csharp
void LOCK_RADIO_STATION_TRACK_LIST(string radioStation, string trackListName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `radioStation` | `const char*` | `string` | - |
| `trackListName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### OVERRIDE_MICROPHONE_SETTINGS

- **命名空间:** `AUDIO`
- **Hash:** `0x75773E11BA459E90`
- **Build:** `323`

**C# 签名:**
```csharp
void OVERRIDE_MICROPHONE_SETTINGS(uint hash, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `hash` | `Hash` | `uint` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets audio flag "OverrideMicrophoneSettings"
```

---

### OVERRIDE_PLAYER_GROUND_MATERIAL

- **命名空间:** `AUDIO`
- **Hash:** `0xD2CC78CD3D0B50F9`
- **JHash:** `0xC307D531`
- **Build:** `323`

**C# 签名:**
```csharp
void OVERRIDE_PLAYER_GROUND_MATERIAL(uint hash, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `hash` | `Hash` | `uint` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets audio flag "OverridePlayerGroundMaterial"
```

---

### OVERRIDE_TREVOR_RAGE

- **命名空间:** `AUDIO`
- **Hash:** `0x13AD665062541A7E`
- **JHash:** `0x05B9B5CF`
- **Build:** `323`

**C# 签名:**
```csharp
void OVERRIDE_TREVOR_RAGE(string voiceEffect)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `voiceEffect` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native enables the audio flag "TrevorRageIsOverridden" and sets the voice effect to `voiceEffect`
```

---

### OVERRIDE_UNDERWATER_STREAM

- **命名空间:** `AUDIO`
- **Hash:** `0xF2A9CDABCEA04BD6`
- **JHash:** `0x9A083B7E`
- **Build:** `323`

**C# 签名:**
```csharp
void OVERRIDE_UNDERWATER_STREAM(string p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `const char*` | `string` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### OVERRIDE_VEH_HORN

- **命名空间:** `AUDIO`
- **Hash:** `0x3CDC1E622CCE0356`
- **JHash:** `0x2ACAB783`
- **Build:** `323`

**C# 签名:**
```csharp
void OVERRIDE_VEH_HORN(int vehicle, bool override, int hornHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `override` | `BOOL` | `bool` | - |
| `hornHash` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Overrides the vehicle's horn hash.
When changing this hash on a vehicle, it will not return the 'overwritten' hash. It will still always return the default horn hash (same as GET_VEHICLE_DEFAULT_HORN)

vehicle - the vehicle whose horn should be overwritten
```

---

### PAUSE_SCRIPTED_CONVERSATION

- **命名空间:** `AUDIO`
- **Hash:** `0x8530AD776CD72B12`
- **JHash:** `0xE2C9C6F8`
- **Build:** `323`

**C# 签名:**
```csharp
void PAUSE_SCRIPTED_CONVERSATION(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### PLAY_AMBIENT_SPEECH_FROM_POSITION_NATIVE

- **命名空间:** `AUDIO`
- **Hash:** `0xED640017ED337E45`
- **JHash:** `0xA1A1402E`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_AMBIENT_SPEECH_FROM_POSITION_NATIVE(string speechName, string voiceName, float x, float y, float z, string speechParam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `speechName` | `const char*` | `string` | - |
| `voiceName` | `const char*` | `string` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `speechParam` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of speeches and voices names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/speeches.json
```

---

### PLAY_ANIMAL_VOCALIZATION

- **命名空间:** `AUDIO`
- **Hash:** `0xEE066C7006C49C0A`
- **JHash:** `0x498849F3`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_ANIMAL_VOCALIZATION(int pedHandle, int p1, string speechName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pedHandle` | `Ped` | `int` | - |
| `p1` | `int` | `int` | - |
| `speechName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Plays sounds from a ped with chop model. For example it used to play bark or sniff sounds. p1 is always 3 or 4294967295 in decompiled scripts. By a quick disassembling I can assume that this arg is unused.
This native is works only when you call it on the ped with right model (ac_chop only ?)
Speech Name can be: CHOP_SNIFF_SEQ CHOP_WHINE CHOP_LICKS_MOUTH CHOP_PANT bark GROWL SNARL BARK_SEQ
```

---

### PLAY_DEFERRED_SOUND_FRONTEND

- **命名空间:** `AUDIO`
- **Hash:** `0xCADA5A0D0702381E`
- **JHash:** `0xC70E6CFA`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_DEFERRED_SOUND_FRONTEND(string soundName, string soundsetName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `soundName` | `const char*` | `string` | - |
| `soundsetName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Only call found in the b617d scripts:

AUDIO::PLAY_DEFERRED_SOUND_FRONTEND("BACK", "HUD_FREEMODE_SOUNDSET");

Full list of audio / sound names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/soundNames.json
```

---

### PLAY_END_CREDITS_MUSIC

- **命名空间:** `AUDIO`
- **Hash:** `0xCD536C4D33DCC900`
- **JHash:** `0x8E88B3CC`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_END_CREDITS_MUSIC(bool play)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `play` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### PLAY_MISSION_COMPLETE_AUDIO

- **命名空间:** `AUDIO`
- **Hash:** `0xB138AAB8A70D3C69`
- **JHash:** `0x3033EA1D`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_MISSION_COMPLETE_AUDIO(string audioName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `audioName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Called 38 times in the scripts. There are 5 different audioNames used.
 One unknown removed below.

AUDIO::PLAY_MISSION_COMPLETE_AUDIO("DEAD");
AUDIO::PLAY_MISSION_COMPLETE_AUDIO("FRANKLIN_BIG_01");
AUDIO::PLAY_MISSION_COMPLETE_AUDIO("GENERIC_FAILED");
AUDIO::PLAY_MISSION_COMPLETE_AUDIO("TREVOR_SMALL_01");
```

---

### PLAY_PAIN

- **命名空间:** `AUDIO`
- **Hash:** `0xBC9AE166038A5CEC`
- **JHash:** `0x874BD6CB`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_PAIN(int ped, int painID, int p1, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `painID` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Needs another parameter [int p2]. The signature is PED::PLAY_PAIN(Ped ped, int painID, int p1, int p2);

Last 2 parameters always seem to be 0.

EX: Function.Call(Hash.PLAY_PAIN, TestPed, 6, 0, 0);

Known Pain IDs
________________________

1 - Doesn't seem to do anything. Does NOT crash the game like previously said. (Latest patch)
6 - Scream (Short)
7 - Scared Scream (Kinda Long)
8 - On Fire

```

---

### PLAY_PED_AMBIENT_SPEECH_AND_CLONE_NATIVE

- **命名空间:** `AUDIO`
- **Hash:** `0xC6941B4A3A8FBBB9`
- **JHash:** `0x444180DB`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_PED_AMBIENT_SPEECH_AND_CLONE_NATIVE(int ped, string speechName, string speechParam, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `speechName` | `const char*` | `string` | - |
| `speechParam` | `const char*` | `string` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Plays ambient speech. See also _0x5C57B85D.

See PLAY_PED_AMBIENT_SPEECH_NATIVE for parameter specifications.

Full list of speeches and voices names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/speeches.json
```

---

### PLAY_PED_AMBIENT_SPEECH_NATIVE

- **命名空间:** `AUDIO`
- **Hash:** `0x8E04FEDD28D42462`
- **JHash:** `0x5C57B85D`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_PED_AMBIENT_SPEECH_NATIVE(int ped, string speechName, string speechParam, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `speechName` | `const char*` | `string` | - |
| `speechParam` | `const char*` | `string` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Plays ambient speech. See also _0x444180DB.

ped: The ped to play the ambient speech.
speechName: Name of the speech to play, eg. "GENERIC_HI".
speechParam: Can be one of the following:
SPEECH_PARAMS_STANDARD
SPEECH_PARAMS_ALLOW_REPEAT
SPEECH_PARAMS_BEAT
SPEECH_PARAMS_FORCE
SPEECH_PARAMS_FORCE_FRONTEND
SPEECH_PARAMS_FORCE_NO_REPEAT_FRONTEND
SPEECH_PARAMS_FORCE_NORMAL
SPEECH_PARAMS_FORCE_NORMAL_CLEAR
SPEECH_PARAMS_FORCE_NORMAL_CRITICAL
SPEECH_PARAMS_FORCE_SHOUTED
SPEECH_PARAMS_FORCE_SHOUTED_CLEAR
SPEECH_PARAMS_FORCE_SHOUTED_CRITICAL
SPEECH_PARAMS_FORCE_PRELOAD_ONLY
SPEECH_PARAMS_MEGAPHONE
SPEECH_PARAMS_HELI
SPEECH_PARAMS_FORCE_MEGAPHONE
SPEECH_PARAMS_FORCE_HELI
SPEECH_PARAMS_INTERRUPT
SPEECH_PARAMS_INTERRUPT_SHOUTED
SPEECH_PARAMS_INTERRUPT_SHOUTED_CLEAR
SPEECH_PARAMS_INTERRUPT_SHOUTED_CRITICAL
SPEECH_PARAMS_INTERRUPT_NO_FORCE
SPEECH_PARAMS_INTERRUPT_FRONTEND
SPEECH_PARAMS_INTERRUPT_NO_FORCE_FRONTEND
SPEECH_PARAMS_ADD_BLIP
SPEECH_PARAMS_ADD_BLIP_ALLOW_REPEAT
SPEECH_PARAMS_ADD_BLIP_FORCE
SPEECH_PARAMS_ADD_BLIP_SHOUTED
SPEECH_PARAMS_ADD_BLIP_SHOUTED_FORCE
SPEECH_PARAMS_ADD_BLIP_INTERRUPT
SPEECH_PARAMS_ADD_BLIP_INTERRUPT_FORCE
SPEECH_PARAMS_FORCE_PRELOAD_ONLY_SHOUTED
SPEECH_PARAMS_FORCE_PRELOAD_ONLY_SHOUTED_CLEAR
SPEECH_PARAMS_FORCE_PRELOAD_ONLY_SHOUTED_CRITICAL
SPEECH_PARAMS_SHOUTED
SPEECH_PARAMS_SHOUTED_CLEAR
SPEECH_PARAMS_SHOUTED_CRITICAL

Note: A list of Name and Parameters can be found here https://pastebin.com/1GZS5dCL

Full list of speeches and voices names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/speeches.json
```

---

### PLAY_PED_AMBIENT_SPEECH_WITH_VOICE_NATIVE

- **命名空间:** `AUDIO`
- **Hash:** `0x3523634255FC3318`
- **JHash:** `0x8386AE28`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_PED_AMBIENT_SPEECH_WITH_VOICE_NATIVE(int ped, string speechName, string voiceName, string speechParam, bool p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `speechName` | `const char*` | `string` | - |
| `voiceName` | `const char*` | `string` | - |
| `speechParam` | `const char*` | `string` | - |
| `p4` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This is the same as PLAY_PED_AMBIENT_SPEECH_NATIVE and PLAY_PED_AMBIENT_SPEECH_AND_CLONE_NATIVE but it will allow you to play a speech file from a specific voice file. It works on players and all peds, even animals.

EX (C#):
GTA.Native.Function.Call(Hash.PLAY_PED_AMBIENT_SPEECH_WITH_VOICE_NATIVE, Game.Player.Character, "GENERIC_INSULT_HIGH", "s_m_y_sheriff_01_white_full_01", "SPEECH_PARAMS_FORCE_SHOUTED", 0);

The first param is the ped you want to play it on, the second is the speech name, the third is the voice name, the fourth is the speech param, and the last param is usually always 0.

Full list of speeches and voices names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/speeches.json
```

---

### PLAY_PED_AUDIO_EVENT_ANIM

- **命名空间:** `AUDIO`
- **Hash:** `0xAD2191A6E3543189`
- **Build:** `3717`

**C# 签名:**
```csharp
void PLAY_PED_AUDIO_EVENT_ANIM(int pedHandle, string audioEvent)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pedHandle` | `Ped` | `int` | - |
| `audioEvent` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### PLAY_PED_RINGTONE

- **命名空间:** `AUDIO`
- **Hash:** `0xF9E56683CA8E11A5`
- **JHash:** `0x1D530E47`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_PED_RINGTONE(string ringtoneName, int ped, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ringtoneName` | `const char*` | `string` | - |
| `ped` | `Ped` | `int` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
All found occurrences in b617d, sorted alphabetically and identical lines removed: https://pastebin.com/RFb4GTny

AUDIO::PLAY_PED_RINGTONE("Remote_Ring", PLAYER::PLAYER_PED_ID(), 1);
AUDIO::PLAY_PED_RINGTONE("Dial_and_Remote_Ring", PLAYER::PLAYER_PED_ID(), 1);

```

---

### PLAY_POLICE_REPORT

- **命名空间:** `AUDIO`
- **Hash:** `0xDFEBD56D9BD1EB16`
- **JHash:** `0x3F277B62`
- **Build:** `323`

**C# 签名:**
```csharp
int PLAY_POLICE_REPORT(string name, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |
| `p1` | `float` | `float` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Plays the given police radio message.

All found occurrences in b617d, sorted alphabetically and identical lines removed: https://pastebin.com/GBnsQ5hr
Full list of police report names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/policeReportNames.json
```

---

### PLAY_SOUND

- **命名空间:** `AUDIO`
- **Hash:** `0x7FF4944CC209192D`
- **JHash:** `0xB6E1917F`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_SOUND(int soundId, string audioName, string audioRef, bool p3, object p4, bool p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `soundId` | `int` | `int` | - |
| `audioName` | `const char*` | `string` | - |
| `audioRef` | `const char*` | `string` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `Any` | `object` | - |
| `p5` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
All found occurrences in b617d, sorted alphabetically and identical lines removed: https://pastebin.com/A8Ny8AHZ

Full list of audio / sound names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/soundNames.json
```

---

### PLAY_SOUND_FROM_COORD

- **命名空间:** `AUDIO`
- **Hash:** `0x8D8686B622B88120`
- **JHash:** `0xCAD3E2D5`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_SOUND_FROM_COORD(int soundId, string audioName, float x, float y, float z, string audioRef, bool isNetwork, int range, bool p8)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `soundId` | `int` | `int` | - |
| `audioName` | `const char*` | `string` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `audioRef` | `const char*` | `string` | - |
| `isNetwork` | `BOOL` | `bool` | - |
| `range` | `int` | `int` | - |
| `p8` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
All found occurrences in b617d, sorted alphabetically and identical lines removed: https://pastebin.com/eeFc5DiW

gtaforums.com/topic/795622-audio-for-mods

Full list of audio / sound names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/soundNames.json
```

---

### PLAY_SOUND_FROM_ENTITY

- **命名空间:** `AUDIO`
- **Hash:** `0xE65F427EB70AB1ED`
- **JHash:** `0x95AE00F8`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_SOUND_FROM_ENTITY(int soundId, string audioName, int entity, string audioRef, bool isNetwork, object p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `soundId` | `int` | `int` | - |
| `audioName` | `const char*` | `string` | - |
| `entity` | `Entity` | `int` | - |
| `audioRef` | `const char*` | `string` | - |
| `isNetwork` | `BOOL` | `bool` | - |
| `p5` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
All found occurrences in b617d, sorted alphabetically and identical lines removed: https://pastebin.com/f2A7vTj0 
No changes made in b678d.

gtaforums.com/topic/795622-audio-for-mods

Full list of audio / sound names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/soundNames.json
```

---

### PLAY_SOUND_FROM_ENTITY_HASH

- **命名空间:** `AUDIO`
- **Hash:** `0x5B9853296731E88D`
- **Build:** `877`

**C# 签名:**
```csharp
void PLAY_SOUND_FROM_ENTITY_HASH(int soundId, uint model, int entity, uint soundSetHash, object p4, object p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `soundId` | `int` | `int` | - |
| `model` | `Hash` | `uint` | - |
| `entity` | `Entity` | `int` | - |
| `soundSetHash` | `Hash` | `uint` | - |
| `p4` | `Any` | `object` | - |
| `p5` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Only used with "formation_flying_blips_soundset" and "biker_formation_blips_soundset".
p1 is always the model of p2
```

---

### PLAY_SOUND_FRONTEND

- **命名空间:** `AUDIO`
- **Hash:** `0x67C540AA08E4A6F5`
- **JHash:** `0x2E458F74`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_SOUND_FRONTEND(int soundId, string audioName, string audioRef, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `soundId` | `int` | `int` | - |
| `audioName` | `const char*` | `string` | - |
| `audioRef` | `const char*` | `string` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
List: https://pastebin.com/DCeRiaLJ

All occurrences as of Cayo Perico Heist DLC (b2189), sorted alphabetically and identical lines removed: https://git.io/JtLxM

Full list of audio / sound names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/soundNames.json
```

---

### PLAY_STREAM_FROM_OBJECT

- **命名空间:** `AUDIO`
- **Hash:** `0xEBAA9B64D76356FD`
- **JHash:** `0xC5266BF7`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_STREAM_FROM_OBJECT(int object)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Used with AUDIO::LOAD_STREAM

Example from finale_heist2b.c4:
TASK::TASK_SYNCHRONIZED_SCENE(l_4C8[2/*14*/], l_4C8[2/*14*/]._f7, l_30A, "push_out_vault_l", 4.0, -1.5, 5, 713, 4.0, 0);
                    PED::SET_SYNCHRONIZED_SCENE_PHASE(l_4C8[2/*14*/]._f7, 0.0);
                    PED::FORCE_PED_AI_AND_ANIMATION_UPDATE(l_4C8[2/*14*/], 0, 0);
                    PED::SET_PED_COMBAT_ATTRIBUTES(l_4C8[2/*14*/], 38, 1);
                    PED::SET_BLOCKING_OF_NON_TEMPORARY_EVENTS(l_4C8[2/*14*/], 1);
                    if (AUDIO::LOAD_STREAM("Gold_Cart_Push_Anim_01", "BIG_SCORE_3B_SOUNDS")) {
                        AUDIO::PLAY_STREAM_FROM_OBJECT(l_36F[0/*1*/]);
                    }
```

---

### PLAY_STREAM_FROM_PED

- **命名空间:** `AUDIO`
- **Hash:** `0x89049DD63C08B5D1`
- **JHash:** `0xA1D7FABE`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_STREAM_FROM_PED(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PLAY_STREAM_FROM_POSITION

- **命名空间:** `AUDIO`
- **Hash:** `0x21442F412E8DE56B`
- **JHash:** `0x6FE5D865`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_STREAM_FROM_POSITION(float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### PLAY_STREAM_FROM_VEHICLE

- **命名空间:** `AUDIO`
- **Hash:** `0xB70374A758007DFA`
- **JHash:** `0xF8E4BDA2`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_STREAM_FROM_VEHICLE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PLAY_STREAM_FRONTEND

- **命名空间:** `AUDIO`
- **Hash:** `0x58FCE43488F9F5F4`
- **JHash:** `0x2C2A16BC`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_STREAM_FRONTEND()
```

**返回值:** `void` (Native: `void`)

---

### PLAY_SYNCHRONIZED_AUDIO_EVENT

- **命名空间:** `AUDIO`
- **Hash:** `0x8B2FD4560E55DD2D`
- **JHash:** `0x507F3241`
- **Build:** `323`

**C# 签名:**
```csharp
bool PLAY_SYNCHRONIZED_AUDIO_EVENT(int sceneID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `sceneID` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### PLAY_VEHICLE_DOOR_CLOSE_SOUND

- **命名空间:** `AUDIO`
- **Hash:** `0x62A456AA4769EF34`
- **JHash:** `0xBA2CF407`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_VEHICLE_DOOR_CLOSE_SOUND(int vehicle, int doorId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `doorId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
doorId: see SET_VEHICLE_DOOR_SHUT
```

---

### PLAY_VEHICLE_DOOR_OPEN_SOUND

- **命名空间:** `AUDIO`
- **Hash:** `0x3A539D52857EA82D`
- **JHash:** `0x84930330`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAY_VEHICLE_DOOR_OPEN_SOUND(int vehicle, int doorId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `doorId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
doorId: see SET_VEHICLE_DOOR_SHUT
```

---

### PRELOAD_SCRIPT_CONVERSATION

- **命名空间:** `AUDIO`
- **Hash:** `0x3B3CAD6166916D87`
- **JHash:** `0xDDF5C579`
- **Build:** `323`

**C# 签名:**
```csharp
void PRELOAD_SCRIPT_CONVERSATION(bool p0, bool p1, bool p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### PRELOAD_SCRIPT_PHONE_CONVERSATION

- **命名空间:** `AUDIO`
- **Hash:** `0x6004BCB0E226AAEA`
- **JHash:** `0x9ACB213A`
- **Build:** `323`

**C# 签名:**
```csharp
void PRELOAD_SCRIPT_PHONE_CONVERSATION(bool p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### PRELOAD_VEHICLE_AUDIO_BANK

- **命名空间:** `AUDIO`
- **Hash:** `0xCA4CEA6AE0000A7E`
- **Build:** `1180`

**C# 签名:**
```csharp
void PRELOAD_VEHICLE_AUDIO_BANK(uint vehicleModel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicleModel` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### PREPARE_ALARM

- **命名空间:** `AUDIO`
- **Hash:** `0x9D74AE343DB65533`
- **JHash:** `0x084932E8`
- **Build:** `323`

**C# 签名:**
```csharp
bool PREPARE_ALARM(string alarmName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `alarmName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Example:

bool prepareAlarm = AUDIO::PREPARE_ALARM("PORT_OF_LS_HEIST_FORT_ZANCUDO_ALARMS");
Full list of alarm names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/alarmSounds.json
```

---

### PREPARE_MUSIC_EVENT

- **命名空间:** `AUDIO`
- **Hash:** `0x1E5185B72EF5158A`
- **JHash:** `0x534A5C1C`
- **Build:** `323`

**C# 签名:**
```csharp
bool PREPARE_MUSIC_EVENT(string eventName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `eventName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
All music event names found in the b617d scripts: https://pastebin.com/GnYt0R3P
Full list of music event names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/musicEventNames.json
```

---

### PREPARE_SYNCHRONIZED_AUDIO_EVENT

- **命名空间:** `AUDIO`
- **Hash:** `0xC7ABCACA4985A766`
- **JHash:** `0xE1D91FD0`
- **Build:** `323`

**C# 签名:**
```csharp
bool PREPARE_SYNCHRONIZED_AUDIO_EVENT(string audioEvent, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `audioEvent` | `const char*` | `string` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p1 is always 0 in the scripts
```

---

### PREPARE_SYNCHRONIZED_AUDIO_EVENT_FOR_SCENE

- **命名空间:** `AUDIO`
- **Hash:** `0x029FE7CD1B7E2E75`
- **JHash:** `0x7652DD49`
- **Build:** `323`

**C# 签名:**
```csharp
bool PREPARE_SYNCHRONIZED_AUDIO_EVENT_FOR_SCENE(int sceneID, string audioEvent)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `sceneID` | `int` | `int` | - |
| `audioEvent` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### RECORD_BROKEN_GLASS

- **命名空间:** `AUDIO`
- **Hash:** `0xFBE20329593DEC9D`
- **JHash:** `0x53FC3FEC`
- **Build:** `323`

**C# 签名:**
```csharp
void RECORD_BROKEN_GLASS(float x, float y, float z, float radius)
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

### REFRESH_CLOSEST_OCEAN_SHORELINE

- **命名空间:** `AUDIO`
- **Hash:** `0x5D2BFAAB8D956E0E`
- **Build:** `573`

**C# 签名:**
```csharp
void REFRESH_CLOSEST_OCEAN_SHORELINE()
```

**返回值:** `void` (Native: `void`)

---

### REGISTER_SCRIPT_WITH_AUDIO

- **命名空间:** `AUDIO`
- **Hash:** `0xC6ED9D5092438D91`
- **JHash:** `0xA6203643`
- **Build:** `323`

**C# 签名:**
```csharp
void REGISTER_SCRIPT_WITH_AUDIO(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native does absolutely nothing, just a nullsub
```

---

### RELEASE_AMBIENT_AUDIO_BANK

- **命名空间:** `AUDIO`
- **Hash:** `0x65475A218FFAA93D`
- **JHash:** `0x8C938784`
- **Build:** `323`

**C# 签名:**
```csharp
void RELEASE_AMBIENT_AUDIO_BANK()
```

**返回值:** `void` (Native: `void`)

---

### RELEASE_MISSION_AUDIO_BANK

- **命名空间:** `AUDIO`
- **Hash:** `0x0EC92A1BF0857187`
- **JHash:** `0x8E8824C7`
- **Build:** `323`

**C# 签名:**
```csharp
void RELEASE_MISSION_AUDIO_BANK()
```

**返回值:** `void` (Native: `void`)

---

### RELEASE_NAMED_SCRIPT_AUDIO_BANK

- **命名空间:** `AUDIO`
- **Hash:** `0x77ED170667F50170`
- **JHash:** `0x16707ABC`
- **Build:** `323`

**C# 签名:**
```csharp
void RELEASE_NAMED_SCRIPT_AUDIO_BANK(string audioBank)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `audioBank` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of script audio bank names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/scriptAudioBankNames.json
```

---

### RELEASE_SCRIPT_AUDIO_BANK

- **命名空间:** `AUDIO`
- **Hash:** `0x7A2D8AD0A9EB9C3F`
- **JHash:** `0x22F865E5`
- **Build:** `323`

**C# 签名:**
```csharp
void RELEASE_SCRIPT_AUDIO_BANK()
```

**返回值:** `void` (Native: `void`)

---

### RELEASE_SOUND_ID

- **命名空间:** `AUDIO`
- **Hash:** `0x353FC880830B88FA`
- **JHash:** `0x9C080899`
- **Build:** `323`

**C# 签名:**
```csharp
void RELEASE_SOUND_ID(int soundId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `soundId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RELEASE_WEAPON_AUDIO

- **命名空间:** `AUDIO`
- **Hash:** `0xCE4AC0439F607045`
- **JHash:** `0x6096504C`
- **Build:** `323`

**C# 签名:**
```csharp
void RELEASE_WEAPON_AUDIO()
```

**返回值:** `void` (Native: `void`)

---

### REMOVE_ENTITY_FROM_AUDIO_MIX_GROUP

- **命名空间:** `AUDIO`
- **Hash:** `0x18EB48CFC41F2EA0`
- **JHash:** `0x308ED0EC`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_ENTITY_FROM_AUDIO_MIX_GROUP(int entity, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_INDIVIDUAL_PORTAL_SETTINGS_OVERRIDE

- **命名空间:** `AUDIO`
- **Hash:** `0x8EF105736194F80C`
- **Build:** `3570`

**C# 签名:**
```csharp
void REMOVE_INDIVIDUAL_PORTAL_SETTINGS_OVERRIDE(uint interiorNameHash, int roomIndex, int doorIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `interiorNameHash` | `Hash` | `uint` | - |
| `roomIndex` | `int` | `int` | - |
| `doorIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_PORTAL_SETTINGS_OVERRIDE

- **命名空间:** `AUDIO`
- **Hash:** `0xB4BBFD9CD8B3922B`
- **JHash:** `0xD24B4D0C`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_PORTAL_SETTINGS_OVERRIDE(string p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
 Found in the b617d scripts, duplicates removed: 

 AUDIO::REMOVE_PORTAL_SETTINGS_OVERRIDE("V_CARSHOWROOM_PS_WINDOW_UNBROKEN");
 AUDIO::REMOVE_PORTAL_SETTINGS_OVERRIDE("V_CIA_PS_WINDOW_UNBROKEN");
 AUDIO::REMOVE_PORTAL_SETTINGS_OVERRIDE("V_DLC_HEIST_APARTMENT_DOOR_CLOSED");
 AUDIO::REMOVE_PORTAL_SETTINGS_OVERRIDE("V_FINALEBANK_PS_VAULT_INTACT");
 AUDIO::REMOVE_PORTAL_SETTINGS_OVERRIDE("V_MICHAEL_PS_BATHROOM_WITH_WINDOW");
```

---

### REQUEST_AMBIENT_AUDIO_BANK

- **命名空间:** `AUDIO`
- **Hash:** `0xFE02FFBED8CA9D99`
- **JHash:** `0x23C88BC7`
- **Build:** `323`

**C# 签名:**
```csharp
bool REQUEST_AMBIENT_AUDIO_BANK(string audioBank, bool p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `audioBank` | `const char*` | `string` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
All occurrences and usages found in b617d, sorted alphabetically and identical lines removed: https://pastebin.com/XZ1tmGEz
Full list of ambient audio bank names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/ambientAudioBankNames.json
p2 is always -1
```

---

### REQUEST_MISSION_AUDIO_BANK

- **命名空间:** `AUDIO`
- **Hash:** `0x7345BDD95E62E0F2`
- **JHash:** `0x916E37CA`
- **Build:** `323`

**C# 签名:**
```csharp
bool REQUEST_MISSION_AUDIO_BANK(string audioBank, bool p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `audioBank` | `const char*` | `string` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
All occurrences and usages found in b617d: https://pastebin.com/NzZZ2Tmm
Full list of mission audio bank names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/missionAudioBankNames.json
p2 is always -1
```

---

### REQUEST_SCRIPT_AUDIO_BANK

- **命名空间:** `AUDIO`
- **Hash:** `0x2F844A8B08D76685`
- **JHash:** `0x21322887`
- **Build:** `323`

**C# 签名:**
```csharp
bool REQUEST_SCRIPT_AUDIO_BANK(string audioBank, bool p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `audioBank` | `const char*` | `string` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
All occurrences and usages found in b617d, sorted alphabetically and identical lines removed: https://pastebin.com/AkmDAVn6
Full list of script audio bank names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/scriptAudioBankNames.json
p2 is always -1
```

---

### REQUEST_TENNIS_BANKS

- **命名空间:** `AUDIO`
- **Hash:** `0x4ADA3F19BE4A6047`
- **JHash:** `0x13777A0B`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_TENNIS_BANKS(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESET_PED_AUDIO_FLAGS

- **命名空间:** `AUDIO`
- **Hash:** `0xF54BB7B61036F335`
- **JHash:** `0xDF720C86`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_PED_AUDIO_FLAGS(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESET_TREVOR_RAGE

- **命名空间:** `AUDIO`
- **Hash:** `0xE78503B10C4314E0`
- **JHash:** `0xE80CF0D4`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_TREVOR_RAGE()
```

**返回值:** `void` (Native: `void`)

---

### RESET_VEHICLE_STARTUP_REV_SOUND

- **命名空间:** `AUDIO`
- **Hash:** `0xD2DCCD8E16E20997`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_VEHICLE_STARTUP_REV_SOUND(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RESTART_SCRIPTED_CONVERSATION

- **命名空间:** `AUDIO`
- **Hash:** `0x9AEB285D1818C9AC`
- **JHash:** `0x6CB24B56`
- **Build:** `323`

**C# 签名:**
```csharp
void RESTART_SCRIPTED_CONVERSATION()
```

**返回值:** `void` (Native: `void`)

---

### SCRIPT_OVERRIDES_WIND_ELEVATION

- **命名空间:** `AUDIO`
- **Hash:** `0x70B8EC8FC108A634`
- **JHash:** `0x95050CAD`
- **Build:** `323`

**C# 签名:**
```csharp
void SCRIPT_OVERRIDES_WIND_ELEVATION(bool p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_AGGRESSIVE_HORNS

- **命名空间:** `AUDIO`
- **Hash:** `0x395BF71085D1B1D9`
- **JHash:** `0x01D6EABE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AGGRESSIVE_HORNS(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Makes pedestrians sound their horn longer, faster and more agressive when they use their horn.
```

---

### SET_AMBIENT_VOICE_NAME

- **命名空间:** `AUDIO`
- **Hash:** `0x6C8065A3B780185B`
- **JHash:** `0xBD2EA1A1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AMBIENT_VOICE_NAME(int ped, string name)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `name` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Audio List
gtaforums.com/topic/795622-audio-for-mods/

All found occurrences in b617d, sorted alphabetically and identical lines removed: https://pastebin.com/FTeAj4yZ
```

---

### SET_AMBIENT_VOICE_NAME_HASH

- **命名空间:** `AUDIO`
- **Hash:** `0x9A53DED9921DE990`
- **Build:** `463`

**C# 签名:**
```csharp
void SET_AMBIENT_VOICE_NAME_HASH(int ped, uint hash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `hash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### SET_AMBIENT_ZONE_LIST_STATE

- **命名空间:** `AUDIO`
- **Hash:** `0x9748FA4DE50CCE3E`
- **JHash:** `0xBF80B412`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AMBIENT_ZONE_LIST_STATE(string ambientZone, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ambientZone` | `const char*` | `string` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_AMBIENT_ZONE_LIST_STATE_PERSISTENT

- **命名空间:** `AUDIO`
- **Hash:** `0xF3638DAE8C4045E1`
- **JHash:** `0x5F5A2605`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AMBIENT_ZONE_LIST_STATE_PERSISTENT(string ambientZone, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ambientZone` | `const char*` | `string` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of ambient zones by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/ambientZones.json
```

---

### SET_AMBIENT_ZONE_STATE

- **命名空间:** `AUDIO`
- **Hash:** `0xBDA07E5950085E46`
- **JHash:** `0x2849CAC9`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AMBIENT_ZONE_STATE(string zoneName, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `zoneName` | `const char*` | `string` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of ambient zones by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/ambientZones.json
```

---

### SET_AMBIENT_ZONE_STATE_PERSISTENT

- **命名空间:** `AUDIO`
- **Hash:** `0x1D6650420CEC9D3B`
- **JHash:** `0xC1FFB672`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AMBIENT_ZONE_STATE_PERSISTENT(string ambientZone, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ambientZone` | `const char*` | `string` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of ambient zones by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/ambientZones.json
```

---

### SET_ANIMAL_MOOD

- **命名空间:** `AUDIO`
- **Hash:** `0xCC97B29285B1DC3B`
- **JHash:** `0x3EA7C6CB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ANIMAL_MOOD(int animal, int mood)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `animal` | `Ped` | `int` | - |
| `mood` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
mood can be 0 or 1 (it's not a boolean value!). Effects audio of the animal.
```

---

### SET_AUDIO_FLAG

- **命名空间:** `AUDIO`
- **Hash:** `0xB9EFD5C25018725A`
- **JHash:** `0x1C09C9E0`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AUDIO_FLAG(string flagName, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `flagName` | `const char*` | `string` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Possible flag names:
"ActivateSwitchWheelAudio"
"AllowAmbientSpeechInSlowMo"
"AllowCutsceneOverScreenFade"
"AllowForceRadioAfterRetune"
"AllowPainAndAmbientSpeechToPlayDuringCutscene"
"AllowPlayerAIOnMission"
"AllowPoliceScannerWhenPlayerHasNoControl"
"AllowRadioDuringSwitch"
"AllowRadioOverScreenFade"
"AllowScoreAndRadio"
"AllowScriptedSpeechInSlowMo"
"AvoidMissionCompleteDelay"
"DisableAbortConversationForDeathAndInjury"
"DisableAbortConversationForRagdoll"
"DisableBarks"
"DisableFlightMusic"
"DisableReplayScriptStreamRecording"
"EnableHeadsetBeep"
"ForceConversationInterrupt"
"ForceSeamlessRadioSwitch"
"ForceSniperAudio"
"FrontendRadioDisabled"
"HoldMissionCompleteWhenPrepared"
"IsDirectorModeActive"
"IsPlayerOnMissionForSpeech"
"ListenerReverbDisabled"
"LoadMPData"
"MobileRadioInGame"
"OnlyAllowScriptTriggerPoliceScanner"
"PlayMenuMusic"
"PoliceScannerDisabled"
"ScriptedConvListenerMaySpeak"
"SpeechDucksScore"
"SuppressPlayerScubaBreathing"
"WantedMusicDisabled"
"WantedMusicOnMission"

-------------------------------
No added flag names between b393d and b573d, including b573d.

#######################################################################

"IsDirectorModeActive" is an audio flag which will allow you to play speech infinitely without any pauses like in Director Mode.

-----------------------------------------------------------------------

All flag IDs and hashes:

ID: 00 | Hash: 0x0FED7A7F
ID: 01 | Hash: 0x20A7858F
ID: 02 | Hash: 0xA11C2259
ID: 03 | Hash: 0x08DE4700
ID: 04 | Hash: 0x989F652F
ID: 05 | Hash: 0x3C9E76BA
ID: 06 | Hash: 0xA805FEB0
ID: 07 | Hash: 0x4B94EA26
ID: 08 | Hash: 0x803ACD34
ID: 09 | Hash: 0x7C741226
ID: 10 | Hash: 0x31DB9EBD
ID: 11 | Hash: 0xDF386F18
ID: 12 | Hash: 0x669CED42
ID: 13 | Hash: 0x51F22743
ID: 14 | Hash: 0x2052B35C
ID: 15 | Hash: 0x071472DC
ID: 16 | Hash: 0xF9928BCC
ID: 17 | Hash: 0x7ADBDD48
ID: 18 | Hash: 0xA959BA1A
ID: 19 | Hash: 0xBBE89B60
ID: 20 | Hash: 0x87A08871
ID: 21 | Hash: 0xED1057CE
ID: 22 | Hash: 0x1584AD7A
ID: 23 | Hash: 0x8582CFCB
ID: 24 | Hash: 0x7E5E2FB0
ID: 25 | Hash: 0xAE4F72DB
ID: 26 | Hash: 0x5D16D1FA
ID: 27 | Hash: 0x06B2F4B8
ID: 28 | Hash: 0x5D4CDC96
ID: 29 | Hash: 0x8B5A48BA
ID: 30 | Hash: 0x98FBD539
ID: 31 | Hash: 0xD8CB0473
ID: 32 | Hash: 0x5CBB4874
ID: 33 | Hash: 0x2E9F93A9
ID: 34 | Hash: 0xD93BEA86
ID: 35 | Hash: 0x92109B7D
ID: 36 | Hash: 0xB7EC9E4D
ID: 37 | Hash: 0xCABDBB1D
ID: 38 | Hash: 0xB3FD4A52
ID: 39 | Hash: 0x370D94E5
ID: 40 | Hash: 0xA0F7938F
ID: 41 | Hash: 0xCBE1CE81
ID: 42 | Hash: 0xC27F1271
ID: 43 | Hash: 0x9E3258EB
ID: 44 | Hash: 0x551CDA5B
ID: 45 | Hash: 0xCB6D663C
ID: 46 | Hash: 0x7DACE87F
ID: 47 | Hash: 0xF9DE416F
ID: 48 | Hash: 0x882E6E9E
ID: 49 | Hash: 0x16B447E7
ID: 50 | Hash: 0xBD867739
ID: 51 | Hash: 0xA3A58604
ID: 52 | Hash: 0x7E046BBC
ID: 53 | Hash: 0xD95FDB98
ID: 54 | Hash: 0x5842C0ED
ID: 55 | Hash: 0x285FECC6
ID: 56 | Hash: 0x9351AC43
ID: 57 | Hash: 0x50032E75
ID: 58 | Hash: 0xAE6D0D59
ID: 59 | Hash: 0xD6351785
ID: 60 | Hash: 0xD25D71BC
ID: 61 | Hash: 0x1F7F6423
ID: 62 | Hash: 0xE24C3AA6
ID: 63 | Hash: 0xBFFDD2B7
```

---

### SET_AUDIO_SCENE_VARIABLE

- **命名空间:** `AUDIO`
- **Hash:** `0xEF21A9EF089A2668`
- **JHash:** `0x19BB3CE8`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AUDIO_SCENE_VARIABLE(string scene, string variable, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scene` | `const char*` | `string` | - |
| `variable` | `const char*` | `string` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of audio scene names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/audioSceneNames.json
```

---

### SET_AUDIO_SCRIPT_CLEANUP_TIME

- **命名空间:** `AUDIO`
- **Hash:** `0xA5F377B175A699C5`
- **JHash:** `0xE812925D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AUDIO_SCRIPT_CLEANUP_TIME(int time)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `time` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_AUDIO_SPECIAL_EFFECT_MODE

- **命名空间:** `AUDIO`
- **Hash:** `0x12561FCBB62D5B9C`
- **JHash:** `0x62B43677`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AUDIO_SPECIAL_EFFECT_MODE(int mode)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `mode` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Needs to be called every frame.
Audio mode to apply this frame: https://alloc8or.re/gta5/doc/enums/audSpecialEffectMode.txt
```

---

### SET_AUDIO_VEHICLE_PRIORITY

- **命名空间:** `AUDIO`
- **Hash:** `0xE5564483E407F914`
- **JHash:** `0x271A9766`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_AUDIO_VEHICLE_PRIORITY(int vehicle, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CONVERSATION_AUDIO_CONTROLLED_BY_ANIM

- **命名空间:** `AUDIO`
- **Hash:** `0x0B568201DD99F0EB`
- **JHash:** `0x1193ED6E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CONVERSATION_AUDIO_CONTROLLED_BY_ANIM(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CONVERSATION_AUDIO_PLACEHOLDER

- **命名空间:** `AUDIO`
- **Hash:** `0x61631F5DF50D1C34`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CONVERSATION_AUDIO_PLACEHOLDER(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CUSTOM_RADIO_TRACK_LIST

- **命名空间:** `AUDIO`
- **Hash:** `0x4E404A9361F75BB2`
- **JHash:** `0x128C3873`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CUSTOM_RADIO_TRACK_LIST(string radioStation, string trackListName, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `radioStation` | `const char*` | `string` | - |
| `trackListName` | `const char*` | `string` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Examples:

AUDIO::SET_CUSTOM_RADIO_TRACK_LIST("RADIO_01_CLASS_ROCK", "END_CREDITS_KILL_MICHAEL", 1);
AUDIO::SET_CUSTOM_RADIO_TRACK_LIST("RADIO_01_CLASS_ROCK", "END_CREDITS_KILL_MICHAEL", 1);
AUDIO::SET_CUSTOM_RADIO_TRACK_LIST("RADIO_01_CLASS_ROCK", "END_CREDITS_KILL_TREVOR", 1);
AUDIO::SET_CUSTOM_RADIO_TRACK_LIST("RADIO_01_CLASS_ROCK", "END_CREDITS_SAVE_MICHAEL_TREVOR", 1);
AUDIO::SET_CUSTOM_RADIO_TRACK_LIST("RADIO_01_CLASS_ROCK", "OFF_ROAD_RADIO_ROCK_LIST", 1);
AUDIO::SET_CUSTOM_RADIO_TRACK_LIST("RADIO_06_COUNTRY", "MAGDEMO2_RADIO_DINGHY", 1);
AUDIO::SET_CUSTOM_RADIO_TRACK_LIST("RADIO_16_SILVERLAKE", "SEA_RACE_RADIO_PLAYLIST", 1);
AUDIO::SET_CUSTOM_RADIO_TRACK_LIST("RADIO_01_CLASS_ROCK", "OFF_ROAD_RADIO_ROCK_LIST", 1);
```

---

### SET_CUTSCENE_AUDIO_OVERRIDE

- **命名空间:** `AUDIO`
- **Hash:** `0x3B4BF5F0859204D9`
- **JHash:** `0xCE1332B7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CUTSCENE_AUDIO_OVERRIDE(string name)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
All occurrences found in b617d, sorted alphabetically and identical lines removed: 

AUDIO::SET_CUTSCENE_AUDIO_OVERRIDE("_AK");
AUDIO::SET_CUTSCENE_AUDIO_OVERRIDE("_CUSTOM");
AUDIO::SET_CUTSCENE_AUDIO_OVERRIDE("_TOOTHLESS");
Full list of cutscene names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/cutsceneNames.json
```

---

### SET_EMITTER_RADIO_STATION

- **命名空间:** `AUDIO`
- **Hash:** `0xACF57305B12AF907`
- **JHash:** `0x87431585`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_EMITTER_RADIO_STATION(string emitterName, string radioStation, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `emitterName` | `const char*` | `string` | - |
| `radioStation` | `const char*` | `string` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of static emitters by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/staticEmitters.json
```

---

### SET_ENTITY_FOR_NULL_CONV_PED

- **命名空间:** `AUDIO`
- **Hash:** `0x892B6AB8F33606F5`
- **JHash:** `0x88203DDA`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_FOR_NULL_CONV_PED(int p0, int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FRONTEND_RADIO_ACTIVE

- **命名空间:** `AUDIO`
- **Hash:** `0xF7F26C6E9CC9EBB8`
- **JHash:** `0xB1172075`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FRONTEND_RADIO_ACTIVE(bool active)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `active` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GLOBAL_RADIO_SIGNAL_LEVEL

- **命名空间:** `AUDIO`
- **Hash:** `0x159B7318403A1CD8`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_GLOBAL_RADIO_SIGNAL_LEVEL(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GPS_ACTIVE

- **命名空间:** `AUDIO`
- **Hash:** `0x3BD3F52BA9B1E4E8`
- **JHash:** `0x0FC3379A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GPS_ACTIVE(bool active)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `active` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_HORN_ENABLED

- **命名空间:** `AUDIO`
- **Hash:** `0x76D683C108594D0E`
- **JHash:** `0x6EB92D05`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_HORN_ENABLED(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_HORN_PERMANENTLY_ON

- **命名空间:** `AUDIO`
- **Hash:** `0x9C11908013EA4715`
- **JHash:** `0xDE8BA3CD`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_HORN_PERMANENTLY_ON(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_HORN_PERMANENTLY_ON_TIME

- **命名空间:** `AUDIO`
- **Hash:** `0x9D3AF56E94C9AE98`
- **JHash:** `0x2F0A16D1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_HORN_PERMANENTLY_ON_TIME(int vehicle, float time)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `time` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_INDIVIDUAL_PORTAL_SETTINGS_OVERRIDE

- **命名空间:** `AUDIO`
- **Hash:** `0xC9D623C5A3D8FD5D`
- **Build:** `3570`

**C# 签名:**
```csharp
void SET_INDIVIDUAL_PORTAL_SETTINGS_OVERRIDE(uint interiorNameHash, int roomIndex, int doorIndex, string newPortalSettingsName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `interiorNameHash` | `Hash` | `uint` | - |
| `roomIndex` | `int` | `int` | - |
| `doorIndex` | `int` | `int` | - |
| `newPortalSettingsName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### SET_INITIAL_PLAYER_STATION

- **命名空间:** `AUDIO`
- **Hash:** `0x88795F13FACDA88D`
- **JHash:** `0x9B069233`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_INITIAL_PLAYER_STATION(string radioStation)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `radioStation` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### SET_MICROPHONE_POSITION

- **命名空间:** `AUDIO`
- **Hash:** `0xB6AE90EDDE95C762`
- **JHash:** `0xAD7BB191`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_MICROPHONE_POSITION(bool toggle, float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `y2` | `float` | `float` | - |
| `z2` | `float` | `float` | - |
| `x3` | `float` | `float` | - |
| `y3` | `float` | `float` | - |
| `z3` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native controls where the game plays audio from. By default the microphone is positioned on the player.
When p0 is true the game will play audio from the 3 positions inputted.
It is recommended to set all 3 positions to the same value as mixing different positions doesn't seem to work well.
The scripts mostly use it with only one position such as in fbi3.c: 
AUDIO::SET_MICROPHONE_POSITION(true, ENTITY::GET_ENTITY_COORDS(iLocal_3091, true), ENTITY::GET_ENTITY_COORDS(iLocal_3091, true), ENTITY::GET_ENTITY_COORDS(iLocal_3091, true));
```

---

### SET_MOBILE_PHONE_RADIO_STATE

- **命名空间:** `AUDIO`
- **Hash:** `0xBF286C554784F3DF`
- **JHash:** `0xE1E0ED34`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_MOBILE_PHONE_RADIO_STATE(bool state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `state` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_MOBILE_RADIO_ENABLED_DURING_GAMEPLAY

- **命名空间:** `AUDIO`
- **Hash:** `0x1098355A16064BB3`
- **JHash:** `0x990085F0`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_MOBILE_RADIO_ENABLED_DURING_GAMEPLAY(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_NEXT_RADIO_TRACK

- **命名空间:** `AUDIO`
- **Hash:** `0x55ECF4D13D9903B0`
- **Build:** `1868`

**C# 签名:**
```csharp
void SET_NEXT_RADIO_TRACK(string radioName, string radioTrack, string p2, string p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `radioName` | `const char*` | `string` | - |
| `radioTrack` | `const char*` | `string` | - |
| `p2` | `const char*` | `string` | - |
| `p3` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### SET_NO_DUCKING_FOR_CONVERSATION

- **命名空间:** `AUDIO`
- **Hash:** `0xB542DE8C3D1CB210`
- **JHash:** `0x789D8C6C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_NO_DUCKING_FOR_CONVERSATION(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_CLOTH_EVENTS_ENABLED

- **命名空间:** `AUDIO`
- **Hash:** `0x29DA3CA8D8B2692D`
- **Build:** `1493`

**C# 签名:**
```csharp
void SET_PED_CLOTH_EVENTS_ENABLED(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Enables/disables ped's "quiet" footstep sound.
```

---

### SET_PED_FOOTSTEPS_EVENTS_ENABLED

- **命名空间:** `AUDIO`
- **Hash:** `0x0653B735BFBDFE87`
- **Build:** `1493`

**C# 签名:**
```csharp
void SET_PED_FOOTSTEPS_EVENTS_ENABLED(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Enables/disables ped's "loud" footstep sound.
```

---

### SET_PED_GENDER

- **命名空间:** `AUDIO`
- **Hash:** `0xA5342D390CDA41D6`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_GENDER(int ped, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
BOOL p1: 0 = Female; 1 = Male
```

---

### SET_PED_INTERIOR_WALLA_DENSITY

- **命名空间:** `AUDIO`
- **Hash:** `0x8BF907833BE275DE`
- **JHash:** `0x2CD26D69`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_INTERIOR_WALLA_DENSITY(float p0, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_IS_DRUNK

- **命名空间:** `AUDIO`
- **Hash:** `0x95D2D383D5396B8A`
- **JHash:** `0xD2EA77A3`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_IS_DRUNK(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the ped drunk sounds.  Only works with PLAYER_PED_ID

====================================================

As mentioned above, this only sets the drunk sound to ped/player.

To give the Ped a drunk effect with drunk walking animation try using SET_PED_MOVEMENT_CLIPSET

Below is an example

if (!Function.Call<bool>(Hash.HAS_ANIM_SET_LOADED, "move_m@drunk@verydrunk"))
                {
                    Function.Call(Hash.REQUEST_ANIM_SET, "move_m@drunk@verydrunk");
                }
                Function.Call(Hash.SET_PED_MOVEMENT_CLIPSET, Ped.Handle, "move_m@drunk@verydrunk", 0x3E800000);



And to stop the effect use
RESET_PED_MOVEMENT_CLIPSET
```

---

### SET_PED_RACE_AND_VOICE_GROUP

- **命名空间:** `AUDIO`
- **Hash:** `0x1B7ABE26CBCBF8C7`
- **Build:** `372`

**C# 签名:**
```csharp
void SET_PED_RACE_AND_VOICE_GROUP(int ped, int p1, uint voiceGroup)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `int` | `int` | - |
| `voiceGroup` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PED_VOICE_FULL

- **命名空间:** `AUDIO`
- **Hash:** `0x40CF0D12D142A9E8`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_VOICE_FULL(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Assigns some ambient voice to the ped.
```

---

### SET_PED_VOICE_GROUP

- **命名空间:** `AUDIO`
- **Hash:** `0x7CDC8C3B89F661B3`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_VOICE_GROUP(int ped, uint voiceGroupHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `voiceGroupHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
From the scripts:

AUDIO::SET_PED_VOICE_GROUP(PLAYER::PLAYER_PED_ID(), MISC::GET_HASH_KEY("PAIGE_PVG"));
AUDIO::SET_PED_VOICE_GROUP(PLAYER::PLAYER_PED_ID(), MISC::GET_HASH_KEY("TALINA_PVG"));
AUDIO::SET_PED_VOICE_GROUP(PLAYER::PLAYER_PED_ID(), MISC::GET_HASH_KEY("FEMALE_LOST_BLACK_PVG"));
AUDIO::SET_PED_VOICE_GROUP(PLAYER::PLAYER_PED_ID(), MISC::GET_HASH_KEY("FEMALE_LOST_WHITE_PVG"));
```

---

### SET_PED_VOICE_GROUP_FROM_RACE_TO_PVG

- **命名空间:** `AUDIO`
- **Hash:** `0x0BABC1345ABBFB16`
- **Build:** `2699`

**C# 签名:**
```csharp
void SET_PED_VOICE_GROUP_FROM_RACE_TO_PVG(int ped, uint voiceGroupHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `voiceGroupHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Dat151RelType == 29
```

---

### SET_PED_WALLA_DENSITY

- **命名空间:** `AUDIO`
- **Hash:** `0x149AEE66F0CB3A99`
- **JHash:** `0xE64F97A0`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PED_WALLA_DENSITY(float p0, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_ANGRY

- **命名空间:** `AUDIO`
- **Hash:** `0xEA241BB04110F091`
- **JHash:** `0x782CA58D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_ANGRY(int ped, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_VEHICLE_ALARM_AUDIO_ACTIVE

- **命名空间:** `AUDIO`
- **Hash:** `0x6FDDAD856E36988A`
- **JHash:** `0x934BE749`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_VEHICLE_ALARM_AUDIO_ACTIVE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PORTAL_SETTINGS_OVERRIDE

- **命名空间:** `AUDIO`
- **Hash:** `0x044DBAD7A7FA2BE5`
- **JHash:** `0x8AD670EC`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PORTAL_SETTINGS_OVERRIDE(string p0, string p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `const char*` | `string` | - |
| `p1` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Found in the b617d scripts, duplicates removed:  

AUDIO::SET_PORTAL_SETTINGS_OVERRIDE("V_CARSHOWROOM_PS_WINDOW_UNBROKEN", "V_CARSHOWROOM_PS_WINDOW_BROKEN");

 AUDIO::SET_PORTAL_SETTINGS_OVERRIDE("V_CIA_PS_WINDOW_UNBROKEN", "V_CIA_PS_WINDOW_BROKEN");

 AUDIO::SET_PORTAL_SETTINGS_OVERRIDE("V_DLC_HEIST_APARTMENT_DOOR_CLOSED", "V_DLC_HEIST_APARTMENT_DOOR_OPEN");

 AUDIO::SET_PORTAL_SETTINGS_OVERRIDE("V_FINALEBANK_PS_VAULT_INTACT", "V_FINALEBANK_PS_VAULT_BLOWN");

 AUDIO::SET_PORTAL_SETTINGS_OVERRIDE("V_MICHAEL_PS_BATHROOM_WITH_WINDOW", "V_MICHAEL_PS_BATHROOM_WITHOUT_WINDOW");
```

---

### SET_POSITIONED_PLAYER_VEHICLE_RADIO_EMITTER_ENABLED

- **命名空间:** `AUDIO`
- **Hash:** `0xDA07819E452FFE8F`
- **Build:** `505`

**C# 签名:**
```csharp
void SET_POSITIONED_PLAYER_VEHICLE_RADIO_EMITTER_ENABLED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_POSITION_FOR_NULL_CONV_PED

- **命名空间:** `AUDIO`
- **Hash:** `0x33E3C6C6F2F0B506`
- **JHash:** `0x73C6F979`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_POSITION_FOR_NULL_CONV_PED(object p0, float p1, float p2, float p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_RADIO_AUTO_UNFREEZE

- **命名空间:** `AUDIO`
- **Hash:** `0xC1AA9F53CE982990`
- **JHash:** `0xA40196BF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_RADIO_AUTO_UNFREEZE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_RADIO_FRONTEND_FADE_TIME

- **命名空间:** `AUDIO`
- **Hash:** `0x2C96CDB04FCA358E`
- **JHash:** `0xC8B514E2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_RADIO_FRONTEND_FADE_TIME(float fadeTime)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `fadeTime` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_RADIO_POSITION_AUDIO_MUTE

- **命名空间:** `AUDIO`
- **Hash:** `0x02E93C796ABD3A97`
- **JHash:** `0x3C395AEE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_RADIO_POSITION_AUDIO_MUTE(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Does nothing (it's a nullsub).
```

---

### SET_RADIO_RETUNE_DOWN

- **命名空间:** `AUDIO`
- **Hash:** `0xDD6BCF9E94425DF9`
- **JHash:** `0xD70ECC80`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_RADIO_RETUNE_DOWN()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Tune Backwards...
```

---

### SET_RADIO_RETUNE_UP

- **命名空间:** `AUDIO`
- **Hash:** `0xFF266D1D0EB1195D`
- **JHash:** `0x53DB6994`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_RADIO_RETUNE_UP()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Tune Forward...
```

---

### SET_RADIO_STATION_AS_FAVOURITE

- **命名空间:** `AUDIO`
- **Hash:** `0x4CAFEBFA21EC188D`
- **Build:** `2372`

**C# 签名:**
```csharp
void SET_RADIO_STATION_AS_FAVOURITE(string radioStation, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `radioStation` | `const char*` | `string` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Doesn't have an effect in Story Mode.
```

---

### SET_RADIO_STATION_MUSIC_ONLY

- **命名空间:** `AUDIO`
- **Hash:** `0x774BD811F656A122`
- **JHash:** `0xB1FF7137`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_RADIO_STATION_MUSIC_ONLY(string radioStation, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `radioStation` | `const char*` | `string` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
6 calls in the b617d scripts, removed identical lines:

AUDIO::SET_RADIO_STATION_MUSIC_ONLY("RADIO_01_CLASS_ROCK", 1);
AUDIO::SET_RADIO_STATION_MUSIC_ONLY(AUDIO::GET_RADIO_STATION_NAME(10), 0);
AUDIO::SET_RADIO_STATION_MUSIC_ONLY(AUDIO::GET_RADIO_STATION_NAME(10), 1);
```

---

### SET_RADIO_TO_STATION_INDEX

- **命名空间:** `AUDIO`
- **Hash:** `0xA619B168B8A8570F`
- **JHash:** `0x1D82766D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_RADIO_TO_STATION_INDEX(int radioStation)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `radioStation` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets radio station by index.
```

---

### SET_RADIO_TO_STATION_NAME

- **命名空间:** `AUDIO`
- **Hash:** `0xC69EDA28699D5107`
- **JHash:** `0x7B36E35E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_RADIO_TO_STATION_NAME(string stationName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `stationName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
List of radio stations that are in the wheel, in clockwise order, as of LS Tuners DLC: https://git.io/J8a3k
An older list including hidden radio stations: https://pastebin.com/Kj9t38KF
```

---

### SET_RADIO_TRACK

- **命名空间:** `AUDIO`
- **Hash:** `0xB39786F201FEE30B`
- **JHash:** `0x76E96212`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_RADIO_TRACK(string radioStation, string radioTrack)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `radioStation` | `const char*` | `string` | - |
| `radioTrack` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Only found this one in the decompiled scripts:

AUDIO::SET_RADIO_TRACK("RADIO_03_HIPHOP_NEW", "ARM1_RADIO_STARTS");

```

---

### SET_RADIO_TRACK_WITH_START_OFFSET

- **命名空间:** `AUDIO`
- **Hash:** `0x2CB0075110BE1E56`
- **Build:** `1493`

**C# 签名:**
```csharp
void SET_RADIO_TRACK_WITH_START_OFFSET(string radioStationName, string mixName, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `radioStationName` | `const char*` | `string` | - |
| `mixName` | `const char*` | `string` | - |
| `p2` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SCRIPT_UPDATE_DOOR_AUDIO

- **命名空间:** `AUDIO`
- **Hash:** `0x06C0023BED16DD6B`
- **JHash:** `0xE61110A2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SCRIPT_UPDATE_DOOR_AUDIO(uint doorHash, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `doorHash` | `Hash` | `uint` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SIREN_BYPASS_MP_DRIVER_CHECK

- **命名空间:** `AUDIO`
- **Hash:** `0xF584CF8529B51434`
- **Build:** `2372`

**C# 签名:**
```csharp
void SET_SIREN_BYPASS_MP_DRIVER_CHECK(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SIREN_CAN_BE_CONTROLLED_BY_AUDIO

- **命名空间:** `AUDIO`
- **Hash:** `0x43FA0DFC5DF87815`
- **JHash:** `0x7BED1872`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SIREN_CAN_BE_CONTROLLED_BY_AUDIO(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SIREN_WITH_NO_DRIVER

- **命名空间:** `AUDIO`
- **Hash:** `0x1FEF0683B96EBCF2`
- **JHash:** `0x77182D58`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SIREN_WITH_NO_DRIVER(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SKIP_MINIGUN_SPIN_UP_AUDIO

- **命名空间:** `AUDIO`
- **Hash:** `0xBEF34B1D9624D5DD`
- **JHash:** `0xE0047BFD`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SKIP_MINIGUN_SPIN_UP_AUDIO(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_STATIC_EMITTER_ENABLED

- **命名空间:** `AUDIO`
- **Hash:** `0x399D2D3B33F1B8EB`
- **JHash:** `0x91F72E92`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_STATIC_EMITTER_ENABLED(string emitterName, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `emitterName` | `const char*` | `string` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Example:
AUDIO::SET_STATIC_EMITTER_ENABLED((Any*)"LOS_SANTOS_VANILLA_UNICORN_01_STAGE", false);    AUDIO::SET_STATIC_EMITTER_ENABLED((Any*)"LOS_SANTOS_VANILLA_UNICORN_02_MAIN_ROOM", false);    AUDIO::SET_STATIC_EMITTER_ENABLED((Any*)"LOS_SANTOS_VANILLA_UNICORN_03_BACK_ROOM", false);

This turns off surrounding sounds not connected directly to peds.

Full list of static emitters by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/staticEmitters.json
```

---

### SET_USER_RADIO_CONTROL_ENABLED

- **命名空间:** `AUDIO`
- **Hash:** `0x19F21E63AE6EAE4E`
- **JHash:** `0x52E054CE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_USER_RADIO_CONTROL_ENABLED(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VARIABLE_ON_SOUND

- **命名空间:** `AUDIO`
- **Hash:** `0xAD6B3148A78AE9B6`
- **JHash:** `0x606EE5FA`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VARIABLE_ON_SOUND(int soundId, string variable, float p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `soundId` | `int` | `int` | - |
| `variable` | `const char*` | `string` | - |
| `p2` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VARIABLE_ON_STREAM

- **命名空间:** `AUDIO`
- **Hash:** `0x2F9D3834AEB9EF79`
- **JHash:** `0xF67BB44C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VARIABLE_ON_STREAM(string variable, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `variable` | `const char*` | `string` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
From the scripts, p0:

"ArmWrestlingIntensity",
"INOUT",
"Monkey_Stream",
"ZoomLevel"
```

---

### SET_VARIABLE_ON_SYNCH_SCENE_AUDIO

- **命名空间:** `AUDIO`
- **Hash:** `0xBCC29F935ED07688`
- **JHash:** `0xD63CF33A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VARIABLE_ON_SYNCH_SCENE_AUDIO(string variableName, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `variableName` | `const char*` | `string` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VARIABLE_ON_UNDER_WATER_STREAM

- **命名空间:** `AUDIO`
- **Hash:** `0x733ADF241531E5C2`
- **JHash:** `0x62D026BE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VARIABLE_ON_UNDER_WATER_STREAM(string variableName, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `variableName` | `const char*` | `string` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
AUDIO::SET_VARIABLE_ON_UNDER_WATER_STREAM("inTunnel", 1.0);
AUDIO::SET_VARIABLE_ON_UNDER_WATER_STREAM("inTunnel", 0.0);
```

---

### SET_VEHICLE_AUDIO_BODY_DAMAGE_FACTOR

- **命名空间:** `AUDIO`
- **Hash:** `0x01BB4D577D38BD9E`
- **JHash:** `0xE81FAC68`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_AUDIO_BODY_DAMAGE_FACTOR(int vehicle, float intensity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `intensity` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
intensity: 0.0f - 1.0f, only used once with 1.0f in R* Scripts (nigel2)
Makes an engine rattling noise when you decelerate, you need to be going faster to hear lower values
```

---

### SET_VEHICLE_AUDIO_ENGINE_DAMAGE_FACTOR

- **命名空间:** `AUDIO`
- **Hash:** `0x59E7B488451F4D3A`
- **JHash:** `0x23BE6432`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_AUDIO_ENGINE_DAMAGE_FACTOR(int vehicle, float damageFactor)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `damageFactor` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_BOOST_ACTIVE

- **命名空间:** `AUDIO`
- **Hash:** `0x4A04DE7CAB2739A1`
- **JHash:** `0x072F15F2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_BOOST_ACTIVE(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
SET_VEHICLE_BOOST_ACTIVE(vehicle, 1, 0);
SET_VEHICLE_BOOST_ACTIVE(vehicle, 0, 0); 

Will give a boost-soundeffect.
```

---

### SET_VEHICLE_CONVERSATIONS_PERSIST

- **命名空间:** `AUDIO`
- **Hash:** `0x58BB377BEC7CD5F4`
- **JHash:** `0x8CE63FA1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_CONVERSATIONS_PERSIST(bool p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_CONVERSATIONS_PERSIST_NEW

- **命名空间:** `AUDIO`
- **Hash:** `0x9BD7BD55E4533183`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_VEHICLE_CONVERSATIONS_PERSIST_NEW(bool p0, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_FORCE_REVERSE_WARNING

- **命名空间:** `AUDIO`
- **Hash:** `0x97FFB4ADEED08066`
- **Build:** `2372`

**C# 签名:**
```csharp
void SET_VEHICLE_FORCE_REVERSE_WARNING(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_HORN_SOUND_INDEX

- **命名空间:** `AUDIO`
- **Hash:** `0x0350E7E17BA767D0`
- **Build:** `1365`

**C# 签名:**
```csharp
void SET_VEHICLE_HORN_SOUND_INDEX(int vehicle, int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `value` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_MISSILE_WARNING_ENABLED

- **命名空间:** `AUDIO`
- **Hash:** `0xF3365489E0DD50F9`
- **JHash:** `0x8AFC488D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_MISSILE_WARNING_ENABLED(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_RADIO_ENABLED

- **命名空间:** `AUDIO`
- **Hash:** `0x3B988190C0AA6C0B`
- **JHash:** `0x6F812CAB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_RADIO_ENABLED(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
can't seem to enable radio on cop cars etc
```

---

### SET_VEHICLE_RADIO_LOUD

- **命名空间:** `AUDIO`
- **Hash:** `0xBB6F1CAEC68B0BCE`
- **JHash:** `0x8D9EDD99`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_RADIO_LOUD(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_STARTUP_REV_SOUND

- **命名空间:** `AUDIO`
- **Hash:** `0xF1F8157B8C3F171C`
- **JHash:** `0x1C0C5E4C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_STARTUP_REV_SOUND(int vehicle, string p1, string p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `const char*` | `string` | - |
| `p2` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEH_FORCED_RADIO_THIS_FRAME

- **命名空间:** `AUDIO`
- **Hash:** `0xC1805D05E6D4FE10`
- **JHash:** `0x7ABB89D2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEH_FORCED_RADIO_THIS_FRAME(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEH_HAS_NORMAL_RADIO

- **命名空间:** `AUDIO`
- **Hash:** `0x3E45765F3FBB582F`
- **Build:** `2372`

**C# 签名:**
```csharp
void SET_VEH_HAS_NORMAL_RADIO(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEH_RADIO_STATION

- **命名空间:** `AUDIO`
- **Hash:** `0x1B9C0099CB942AC6`
- **JHash:** `0xE391F55F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEH_RADIO_STATION(int vehicle, string radioStation)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `radioStation` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
List of radio stations that are in the wheel, in clockwise order, as of LS Tuners DLC: https://git.io/J8a3k
An older list including hidden radio stations: https://pastebin.com/Kj9t38KF
```

---

### SKIP_RADIO_FORWARD

- **命名空间:** `AUDIO`
- **Hash:** `0x6DDBBDD98E2E9C25`
- **JHash:** `0x10D36630`
- **Build:** `323`

**C# 签名:**
```csharp
void SKIP_RADIO_FORWARD()
```

**返回值:** `void` (Native: `void`)

---

### SKIP_TO_NEXT_SCRIPTED_CONVERSATION_LINE

- **命名空间:** `AUDIO`
- **Hash:** `0x9663FE6B7A61EB00`
- **JHash:** `0x85C98304`
- **Build:** `323`

**C# 签名:**
```csharp
void SKIP_TO_NEXT_SCRIPTED_CONVERSATION_LINE()
```

**返回值:** `void` (Native: `void`)

---

### START_ALARM

- **命名空间:** `AUDIO`
- **Hash:** `0x0355EF116C4C97B2`
- **JHash:** `0x703F524B`
- **Build:** `323`

**C# 签名:**
```csharp
void START_ALARM(string alarmName, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `alarmName` | `const char*` | `string` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Example:

This will start the alarm at Fort Zancudo.

AUDIO::START_ALARM("PORT_OF_LS_HEIST_FORT_ZANCUDO_ALARMS", 1);

First parameter (char) is the name of the alarm.
Second parameter (bool) is unknown, it does not seem to make a difference if this one is 0 or 1.

----------

It DOES make a difference but it has to do with the duration or something I dunno yet

----------

 Found in the b617d scripts:

 AUDIO::START_ALARM("AGENCY_HEIST_FIB_TOWER_ALARMS", 0);
 AUDIO::START_ALARM("AGENCY_HEIST_FIB_TOWER_ALARMS_UPPER", 1);
 AUDIO::START_ALARM("AGENCY_HEIST_FIB_TOWER_ALARMS_UPPER_B", 0);
 AUDIO::START_ALARM("BIG_SCORE_HEIST_VAULT_ALARMS", a_0);
 AUDIO::START_ALARM("FBI_01_MORGUE_ALARMS", 1);
 AUDIO::START_ALARM("FIB_05_BIOTECH_LAB_ALARMS", 0);
 AUDIO::START_ALARM("JEWEL_STORE_HEIST_ALARMS", 0);
 AUDIO::START_ALARM("PALETO_BAY_SCORE_ALARM", 1);
 AUDIO::START_ALARM("PALETO_BAY_SCORE_CHICKEN_FACTORY_ALARM", 0);
 AUDIO::START_ALARM("PORT_OF_LS_HEIST_FORT_ZANCUDO_ALARMS", 1);
 AUDIO::START_ALARM("PORT_OF_LS_HEIST_SHIP_ALARMS", 0);
 AUDIO::START_ALARM("PRISON_ALARMS", 0);
 AUDIO::START_ALARM("PROLOGUE_VAULT_ALARMS", 0);
Full list of alarm names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/alarmSounds.json
```

---

### START_AUDIO_SCENE

- **命名空间:** `AUDIO`
- **Hash:** `0x013A80FC08F6E4F2`
- **JHash:** `0xE48D757B`
- **Build:** `323`

**C# 签名:**
```csharp
bool START_AUDIO_SCENE(string scene)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scene` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Used to prepare a scene where the surrounding sound is muted or a bit changed. This does not play any sound.

List of all usable scene names found in b617d. Sorted alphabetically and identical names removed: https://pastebin.com/MtM9N9CC
Full list of audio scene names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/audioSceneNames.json
```

---

### START_PRELOADED_CONVERSATION

- **命名空间:** `AUDIO`
- **Hash:** `0x23641AFE870AF385`
- **JHash:** `0xA170261B`
- **Build:** `323`

**C# 签名:**
```csharp
void START_PRELOADED_CONVERSATION()
```

**返回值:** `void` (Native: `void`)

---

### START_SCRIPT_CONVERSATION

- **命名空间:** `AUDIO`
- **Hash:** `0x6B17C62C9635D2DC`
- **JHash:** `0xE5DE7D9D`
- **Build:** `323`

**C# 签名:**
```csharp
void START_SCRIPT_CONVERSATION(bool p0, bool p1, bool p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### START_SCRIPT_PHONE_CONVERSATION

- **命名空间:** `AUDIO`
- **Hash:** `0x252E5F915EABB675`
- **JHash:** `0x38E42D07`
- **Build:** `323`

**C# 签名:**
```csharp
void START_SCRIPT_PHONE_CONVERSATION(bool p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### STOP_ALARM

- **命名空间:** `AUDIO`
- **Hash:** `0xA1CADDCD98415A41`
- **JHash:** `0xF987BE8C`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_ALARM(string alarmName, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `alarmName` | `const char*` | `string` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Example:

This will stop the alarm at Fort Zancudo.

AUDIO::STOP_ALARM("PORT_OF_LS_HEIST_FORT_ZANCUDO_ALARMS", 1);

First parameter (char) is the name of the alarm.
Second parameter (bool) has to be true (1) to have any effect.
Full list of alarm names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/alarmSounds.json
```

---

### STOP_ALL_ALARMS

- **命名空间:** `AUDIO`
- **Hash:** `0x2F794A877ADD4C92`
- **JHash:** `0xC3CB9DC6`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_ALL_ALARMS(bool stop)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `stop` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### STOP_AUDIO_SCENE

- **命名空间:** `AUDIO`
- **Hash:** `0xDFE8422B3B94E688`
- **JHash:** `0xA08D8C58`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_AUDIO_SCENE(string scene)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scene` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of audio scene names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/audioSceneNames.json
```

---

### STOP_AUDIO_SCENES

- **命名空间:** `AUDIO`
- **Hash:** `0xBAC7FC81A75EC1A1`
- **JHash:** `0xF6C7342A`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_AUDIO_SCENES()
```

**返回值:** `void` (Native: `void`)

---

### STOP_CURRENT_PLAYING_AMBIENT_SPEECH

- **命名空间:** `AUDIO`
- **Hash:** `0xB8BEC0CA6F0EDB0F`
- **JHash:** `0xBB8E64BF`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_CURRENT_PLAYING_AMBIENT_SPEECH(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### STOP_CURRENT_PLAYING_SPEECH

- **命名空间:** `AUDIO`
- **Hash:** `0x7A73D05A607734C7`
- **JHash:** `0x5B7463F4`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_CURRENT_PLAYING_SPEECH(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### STOP_CUTSCENE_AUDIO

- **命名空间:** `AUDIO`
- **Hash:** `0x806058BBDC136E06`
- **JHash:** `0x55461BE6`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_CUTSCENE_AUDIO()
```

**返回值:** `void` (Native: `void`)

---

### STOP_PED_RINGTONE

- **命名空间:** `AUDIO`
- **Hash:** `0x6C5AE23EFA885092`
- **JHash:** `0xFEEA107C`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_PED_RINGTONE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### STOP_PED_SPEAKING

- **命名空间:** `AUDIO`
- **Hash:** `0x9D64D7405520E3D3`
- **JHash:** `0xFF92B49D`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_PED_SPEAKING(int ped, bool shaking)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `shaking` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### STOP_PED_SPEAKING_SYNCED

- **命名空间:** `AUDIO`
- **Hash:** `0xAB6781A5F3101470`
- **Build:** `1868`

**C# 签名:**
```csharp
void STOP_PED_SPEAKING_SYNCED(int ped, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### STOP_SCRIPTED_CONVERSATION

- **命名空间:** `AUDIO`
- **Hash:** `0xD79DEEFB53455EBA`
- **JHash:** `0xAB77DA7D`
- **Build:** `323`

**C# 签名:**
```csharp
int STOP_SCRIPTED_CONVERSATION(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `int`)

---

### STOP_SMOKE_GRENADE_EXPLOSION_SOUNDS

- **命名空间:** `AUDIO`
- **Hash:** `0xE4E6DD5566D28C82`
- **JHash:** `0x7262B5BA`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_SMOKE_GRENADE_EXPLOSION_SOUNDS()
```

**返回值:** `void` (Native: `void`)

---

### STOP_SOUND

- **命名空间:** `AUDIO`
- **Hash:** `0xA3B0C41BA5CC0BB5`
- **JHash:** `0xCD7F4030`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_SOUND(int soundId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `soundId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### STOP_STREAM

- **命名空间:** `AUDIO`
- **Hash:** `0xA4718A1419D18151`
- **JHash:** `0xD1E364DE`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_STREAM()
```

**返回值:** `void` (Native: `void`)

---

### STOP_SYNCHRONIZED_AUDIO_EVENT

- **命名空间:** `AUDIO`
- **Hash:** `0x92D6A88E64A94430`
- **JHash:** `0xADEED2B4`
- **Build:** `323`

**C# 签名:**
```csharp
bool STOP_SYNCHRONIZED_AUDIO_EVENT(int sceneID)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `sceneID` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### TRIGGER_MUSIC_EVENT

- **命名空间:** `AUDIO`
- **Hash:** `0x706D57B0F50DA710`
- **JHash:** `0xB6094948`
- **Build:** `323`

**C# 签名:**
```csharp
bool TRIGGER_MUSIC_EVENT(string eventName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `eventName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
List of all usable event names found in b617d used with this native. Sorted alphabetically and identical names removed: https://pastebin.com/RzDFmB1W

All music event names found in the b617d scripts: https://pastebin.com/GnYt0R3P
Full list of music event names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/musicEventNames.json
```

---

### TRIGGER_SIREN_AUDIO

- **命名空间:** `AUDIO`
- **Hash:** `0x66C3FB05206041BA`
- **Build:** `1290`

**C# 签名:**
```csharp
void TRIGGER_SIREN_AUDIO(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### UNBLOCK_SPEECH_CONTEXT_GROUP

- **命名空间:** `AUDIO`
- **Hash:** `0x2ACABED337622DF2`
- **Build:** `1493`

**C# 签名:**
```csharp
void UNBLOCK_SPEECH_CONTEXT_GROUP(string p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### UNFREEZE_RADIO_STATION

- **命名空间:** `AUDIO`
- **Hash:** `0xFC00454CF60B91DD`
- **JHash:** `0x4D46202C`
- **Build:** `323`

**C# 签名:**
```csharp
void UNFREEZE_RADIO_STATION(string radioStation)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `radioStation` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### UNHINT_AMBIENT_AUDIO_BANK

- **命名空间:** `AUDIO`
- **Hash:** `0x19AF7ED9B9D23058`
- **JHash:** `0xA58BBF4F`
- **Build:** `323`

**C# 签名:**
```csharp
void UNHINT_AMBIENT_AUDIO_BANK()
```

**返回值:** `void` (Native: `void`)

---

### UNHINT_NAMED_SCRIPT_AUDIO_BANK

- **命名空间:** `AUDIO`
- **Hash:** `0x11579D940949C49E`
- **Build:** `678`

**C# 签名:**
```csharp
void UNHINT_NAMED_SCRIPT_AUDIO_BANK(string audioBank)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `audioBank` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### UNHINT_SCRIPT_AUDIO_BANK

- **命名空间:** `AUDIO`
- **Hash:** `0x9AC92EED5E4793AB`
- **JHash:** `0xE67446E9`
- **Build:** `323`

**C# 签名:**
```csharp
void UNHINT_SCRIPT_AUDIO_BANK()
```

**返回值:** `void` (Native: `void`)

---

### UNLOCK_MISSION_NEWS_STORY

- **命名空间:** `AUDIO`
- **Hash:** `0xB165AB7C248B2DC1`
- **JHash:** `0xCCD9ABE4`
- **Build:** `323`

**C# 签名:**
```csharp
void UNLOCK_MISSION_NEWS_STORY(int newsStory)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `newsStory` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
"news" that play on the radio after you've done something in story mode(?)
```

---

### UNLOCK_RADIO_STATION_TRACK_LIST

- **命名空间:** `AUDIO`
- **Hash:** `0x031ACB6ABA18C729`
- **JHash:** `0xBE998184`
- **Build:** `323`

**C# 签名:**
```csharp
void UNLOCK_RADIO_STATION_TRACK_LIST(string radioStation, string trackListName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `radioStation` | `const char*` | `string` | - |
| `trackListName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
AUDIO::UNLOCK_RADIO_STATION_TRACK_LIST("RADIO_16_SILVERLAKE", "MIRRORPARK_LOCKED");
```

---

### UNREGISTER_SCRIPT_WITH_AUDIO

- **命名空间:** `AUDIO`
- **Hash:** `0xA8638BE228D4751A`
- **JHash:** `0x66728EFE`
- **Build:** `323`

**C# 签名:**
```csharp
void UNREGISTER_SCRIPT_WITH_AUDIO()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
This native does absolutely nothing, just a nullsub
```

---

### UNREQUEST_TENNIS_BANKS

- **命名空间:** `AUDIO`
- **Hash:** `0x0150B6FF25A9E2E5`
- **JHash:** `0x1134F68B`
- **Build:** `323`

**C# 签名:**
```csharp
void UNREQUEST_TENNIS_BANKS()
```

**返回值:** `void` (Native: `void`)

---

### UPDATE_SOUND_COORD

- **命名空间:** `AUDIO`
- **Hash:** `0x7EC3C679D0E7E46B`
- **Build:** `678`

**C# 签名:**
```csharp
void UPDATE_SOUND_COORD(int soundId, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `soundId` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### UPDATE_UNLOCKABLE_DJ_RADIO_TRACKS

- **命名空间:** `AUDIO`
- **Hash:** `0x47AED84213A47510`
- **Build:** `1493`

**C# 签名:**
```csharp
void UPDATE_UNLOCKABLE_DJ_RADIO_TRACKS(bool enableMixes)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `enableMixes` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Just a nullsub (i.e. does absolutely nothing) since build 1604.
```

---

### USE_FOOTSTEP_SCRIPT_SWEETENERS

- **命名空间:** `AUDIO`
- **Hash:** `0xBF4DC1784BE94DFA`
- **JHash:** `0xD99E275B`
- **Build:** `323`

**C# 签名:**
```csharp
void USE_FOOTSTEP_SCRIPT_SWEETENERS(int ped, bool p1, uint hash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `hash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### USE_SIREN_AS_HORN

- **命名空间:** `AUDIO`
- **Hash:** `0xFA932DE350266EF8`
- **JHash:** `0xC6BC16F3`
- **Build:** `323`

**C# 签名:**
```csharp
void USE_SIREN_AS_HORN(int vehicle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### _ENABLE_DRAG_RACE_STATIONARY_WARNING_SOUNDS

- **命名空间:** `AUDIO`
- **Hash:** `0xBEFB80290414FD4F`
- **Build:** `3095`

**C# 签名:**
```csharp
void _ENABLE_DRAG_RACE_STATIONARY_WARNING_SOUNDS(int vehicle, bool enable)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `enable` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### _FORCE_VEHICLE_ENGINE_SYNTH

- **命名空间:** `AUDIO`
- **Hash:** `0xEB7D0E1FCC8FE17A`
- **Build:** `3258`

**C# 签名:**
```csharp
void _FORCE_VEHICLE_ENGINE_SYNTH(int vehicle, bool force)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `force` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Called together with SET_VEHICLE_TYRES_CAN_BURST
```

---
