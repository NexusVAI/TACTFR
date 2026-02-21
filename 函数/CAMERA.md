# CAMERA - Native 函数参考

> 命名空间: CAM

---

## 快速索引

| 函数名 | C# 签名 | 返回值 | 说明 |
|--------|---------|--------|------|
| `ADD_CAM_SPLINE_NODE` | `void ADD_CAM_SPLINE_NODE(int camera, float x, float y, float z, float xRot, float yRot, float zRot, int length, int smoothingStyle, int rotationOrder)` | void | I filled p1-p6 (the floats) as they are as other natives with 6 floats in a row are similar and I se... |
| `ADD_CAM_SPLINE_NODE_USING_CAMERA` | `void ADD_CAM_SPLINE_NODE_USING_CAMERA(int cam, int cam2, int length, int p3)` | void | p0 is the spline camera to which the node is being added.<br>p1 is the camera used to create the node.<br>... |
| `ADD_CAM_SPLINE_NODE_USING_CAMERA_FRAME` | `void ADD_CAM_SPLINE_NODE_USING_CAMERA_FRAME(int cam, int cam2, int length, int p3)` | void | p0 is the spline camera to which the node is being added.<br>p1 is the camera used to create the node.<br>... |
| `ADD_CAM_SPLINE_NODE_USING_GAMEPLAY_FRAME` | `void ADD_CAM_SPLINE_NODE_USING_GAMEPLAY_FRAME(int cam, int length, int p2)` | void | p2 is always 2 in scripts. It might be smoothing style or rotation order. |
| `ALLOW_MOTION_BLUR_DECAY` | `void ALLOW_MOTION_BLUR_DECAY(object p0, bool p1)` | void | - |
| `ANIMATED_SHAKE_CAM` | `void ANIMATED_SHAKE_CAM(int cam, string p1, string p2, string p3, float amplitude)` | void | Example from michael2 script.<br><br>CAM::ANIMATED_SHAKE_CAM(l_5069, "shake_cam_all@", "light", "", 1f); |
| `ANIMATED_SHAKE_SCRIPT_GLOBAL` | `void ANIMATED_SHAKE_SCRIPT_GLOBAL(string p0, string p1, string p2, float p3)` | void | CAM::ANIMATED_SHAKE_SCRIPT_GLOBAL("SHAKE_CAM_medium", "medium", "", 0.5f);<br><br>Full list of cam shake t... |
| `ARE_WIDESCREEN_BORDERS_ACTIVE` | `bool ARE_WIDESCREEN_BORDERS_ACTIVE()` | bool | - |
| `ATTACH_CAM_TO_ENTITY` | `void ATTACH_CAM_TO_ENTITY(int cam, int entity, float xOffset, float yOffset, float zOffset, bool isRelative)` | void | Last param determines if its relative to the Entity |
| `ATTACH_CAM_TO_PED_BONE` | `void ATTACH_CAM_TO_PED_BONE(int cam, int ped, int boneIndex, float x, float y, float z, bool heading)` | void | - |
| `ATTACH_CAM_TO_VEHICLE_BONE` | `void ATTACH_CAM_TO_VEHICLE_BONE(int cam, int vehicle, int boneIndex, bool relativeRotation, float rotX, float rotY, float rotZ, float offsetX, float offsetY, float offsetZ, bool fixedDirection)` | void | This native works with vehicles only. Bone indexes are usually given by this native GET_ENTITY_BONE_... |
| `BLOCK_FIRST_PERSON_ORIENTATION_RESET_THIS_UPDATE` | `void BLOCK_FIRST_PERSON_ORIENTATION_RESET_THIS_UPDATE()` | void | - |
| `BYPASS_CAMERA_COLLISION_BUOYANCY_TEST_THIS_UPDATE` | `void BYPASS_CAMERA_COLLISION_BUOYANCY_TEST_THIS_UPDATE()` | void | - |
| `BYPASS_CUTSCENE_CAM_RENDERING_THIS_UPDATE` | `void BYPASS_CUTSCENE_CAM_RENDERING_THIS_UPDATE()` | void | - |
| `CAMERA_PREVENT_COLLISION_SETTINGS_FOR_TRIPLEHEAD_IN_INTERIORS_THIS_UPDATE` | `void CAMERA_PREVENT_COLLISION_SETTINGS_FOR_TRIPLEHEAD_IN_INTERIORS_THIS_UPDATE()` | void | - |
| `CREATE_CAM` | `int CREATE_CAM(string camName, bool p1)` | int | "DEFAULT_SCRIPTED_CAMERA"<br>"DEFAULT_ANIMATED_CAMERA"<br>"DEFAULT_SPLINE_CAMERA"<br>"DEFAULT_SCRIPTED_FLY_CA... |
| `CREATE_CAMERA` | `int CREATE_CAMERA(uint camHash, bool p1)` | int | - |
| `CREATE_CAMERA_WITH_PARAMS` | `int CREATE_CAMERA_WITH_PARAMS(uint camHash, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fov, bool p8, object p9)` | int | p9 uses 2 by default |
| `CREATE_CAM_WITH_PARAMS` | `int CREATE_CAM_WITH_PARAMS(string camName, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fov, bool p8, int p9)` | int | camName is always set to "DEFAULT_SCRIPTED_CAMERA" in Rockstar's scripts.<br>------------<br>Camera names ... |
| `CREATE_CINEMATIC_SHOT` | `void CREATE_CINEMATIC_SHOT(uint p0, int time, bool p2, int entity)` | void | hash is always JOAAT("CAMERA_MAN_SHOT") in decompiled scripts |
| `DESTROY_ALL_CAMS` | `void DESTROY_ALL_CAMS(bool bScriptHostCam)` | void | BOOL param indicates whether the cam should be destroyed if it belongs to the calling script. |
| `DESTROY_CAM` | `void DESTROY_CAM(int cam, bool bScriptHostCam)` | void | BOOL param indicates whether the cam should be destroyed if it belongs to the calling script. |
| `DETACH_CAM` | `void DETACH_CAM(int cam)` | void | - |
| `DISABLE_AIM_CAM_THIS_UPDATE` | `void DISABLE_AIM_CAM_THIS_UPDATE()` | void | - |
| `DISABLE_CAM_COLLISION_FOR_OBJECT` | `void DISABLE_CAM_COLLISION_FOR_OBJECT(int entity)` | void | - |
| `DISABLE_CINEMATIC_BONNET_CAMERA_THIS_UPDATE` | `void DISABLE_CINEMATIC_BONNET_CAMERA_THIS_UPDATE()` | void | - |
| `DISABLE_CINEMATIC_SLOW_MO_THIS_UPDATE` | `bool DISABLE_CINEMATIC_SLOW_MO_THIS_UPDATE()` | bool | - |
| `DISABLE_CINEMATIC_VEHICLE_IDLE_MODE_THIS_UPDATE` | `void DISABLE_CINEMATIC_VEHICLE_IDLE_MODE_THIS_UPDATE()` | void | - |
| `DISABLE_FIRST_PERSON_CAMERA_WATER_CLIPPING_TEST_THIS_UPDATE` | `void DISABLE_FIRST_PERSON_CAMERA_WATER_CLIPPING_TEST_THIS_UPDATE()` | void | Sets some flag on cinematic camera |
| `DISABLE_FIRST_PERSON_FLASH_EFFECT_THIS_UPDATE` | `void DISABLE_FIRST_PERSON_FLASH_EFFECT_THIS_UPDATE()` | void | - |
| `DISABLE_GAMEPLAY_CAM_ALTITUDE_FOV_SCALING_THIS_UPDATE` | `void DISABLE_GAMEPLAY_CAM_ALTITUDE_FOV_SCALING_THIS_UPDATE()` | void | Shows the crosshair even if it wouldn't show normally. Only works for one frame, so make sure to cal... |
| `DISABLE_NEAR_CLIP_SCAN_THIS_UPDATE` | `void DISABLE_NEAR_CLIP_SCAN_THIS_UPDATE()` | void | - |
| `DISABLE_ON_FOOT_FIRST_PERSON_VIEW_THIS_UPDATE` | `void DISABLE_ON_FOOT_FIRST_PERSON_VIEW_THIS_UPDATE()` | void | Disables first person camera for the current frame.<br><br>Found in decompiled scripts:<br>GRAPHICS::DRAW_DEB... |
| `DOES_CAM_EXIST` | `bool DOES_CAM_EXIST(int cam)` | bool | Returns whether or not the passed camera handle exists. |
| `DO_SCREEN_FADE_IN` | `void DO_SCREEN_FADE_IN(int duration)` | void | Fades the screen in.<br><br>duration: The time the fade should take, in milliseconds. |
| `DO_SCREEN_FADE_OUT` | `void DO_SCREEN_FADE_OUT(int duration)` | void | Fades the screen out.<br><br>duration: The time the fade should take, in milliseconds. |
| `FORCE_BONNET_CAMERA_RELATIVE_HEADING_AND_PITCH` | `void FORCE_BONNET_CAMERA_RELATIVE_HEADING_AND_PITCH(float p0, float p1)` | void | - |
| `FORCE_CAMERA_RELATIVE_HEADING_AND_PITCH` | `void FORCE_CAMERA_RELATIVE_HEADING_AND_PITCH(float roll, float pitch, float yaw)` | void | - |
| `FORCE_CAM_FAR_CLIP` | `void FORCE_CAM_FAR_CLIP(int cam, float p1)` | void | - |
| `FORCE_CINEMATIC_RENDERING_THIS_UPDATE` | `void FORCE_CINEMATIC_RENDERING_THIS_UPDATE(bool toggle)` | void | - |
| `FORCE_TIGHTSPACE_CUSTOM_FRAMING_THIS_UPDATE` | `void FORCE_TIGHTSPACE_CUSTOM_FRAMING_THIS_UPDATE()` | void | - |
| `FORCE_VEHICLE_CAM_STUNT_SETTINGS_THIS_UPDATE` | `void FORCE_VEHICLE_CAM_STUNT_SETTINGS_THIS_UPDATE()` | void | - |
| `GET_CAM_ACTIVE_VIEW_MODE_CONTEXT` | `int GET_CAM_ACTIVE_VIEW_MODE_CONTEXT()` | int | enum Context<br>{<br>	ON_FOOT,<br>	IN_VEHICLE,<br>	ON_BIKE,<br>	IN_BOAT,<br>	IN_AIRCRAFT,<br>	IN_SUBMARINE,<br>	IN_HELI,<br>	IN... |
| `GET_CAM_ANIM_CURRENT_PHASE` | `float GET_CAM_ANIM_CURRENT_PHASE(int cam)` | float | - |
| `GET_CAM_COORD` | `Vector3 GET_CAM_COORD(int cam)` | Vector3 | - |
| `GET_CAM_DOF_STRENGTH` | `float GET_CAM_DOF_STRENGTH(int cam)` | float | - |
| `GET_CAM_FAR_CLIP` | `float GET_CAM_FAR_CLIP(int cam)` | float | - |
| `GET_CAM_FAR_DOF` | `float GET_CAM_FAR_DOF(int cam)` | float | - |
| `GET_CAM_FOV` | `float GET_CAM_FOV(int cam)` | float | - |
| `GET_CAM_NEAR_CLIP` | `float GET_CAM_NEAR_CLIP(int cam)` | float | - |
| `GET_CAM_NEAR_DOF` | `float GET_CAM_NEAR_DOF(int cam)` | float | - |
| `GET_CAM_ROT` | `Vector3 GET_CAM_ROT(int cam, int rotationOrder)` | Vector3 | The last parameter, as in other "ROT" methods, is usually 2. |
| `GET_CAM_SPLINE_NODE_INDEX` | `int GET_CAM_SPLINE_NODE_INDEX(int cam)` | int | - |
| `GET_CAM_SPLINE_NODE_PHASE` | `float GET_CAM_SPLINE_NODE_PHASE(int cam)` | float | I'm pretty sure the parameter is the camera as usual, but I am not certain so I'm going to leave it ... |
| `GET_CAM_SPLINE_PHASE` | `float GET_CAM_SPLINE_PHASE(int cam)` | float | Can use this with SET_CAM_SPLINE_PHASE to set the float it this native returns.<br><br>(returns 1.0f when ... |
| `GET_CAM_VIEW_MODE_FOR_CONTEXT` | `int GET_CAM_VIEW_MODE_FOR_CONTEXT(int context)` | int | context: see _GET_CAM_ACTIVE_VIEW_MODE_CONTEXT |
| `GET_DEBUG_CAM` | `int GET_DEBUG_CAM()` | int | - |
| `GET_FINAL_RENDERED_CAM_COORD` | `Vector3 GET_FINAL_RENDERED_CAM_COORD()` | Vector3 | - |
| `GET_FINAL_RENDERED_CAM_FAR_CLIP` | `float GET_FINAL_RENDERED_CAM_FAR_CLIP()` | float | - |
| `GET_FINAL_RENDERED_CAM_FAR_DOF` | `float GET_FINAL_RENDERED_CAM_FAR_DOF()` | float | - |
| `GET_FINAL_RENDERED_CAM_FOV` | `float GET_FINAL_RENDERED_CAM_FOV()` | float | Gets some camera fov |
| `GET_FINAL_RENDERED_CAM_MOTION_BLUR_STRENGTH` | `float GET_FINAL_RENDERED_CAM_MOTION_BLUR_STRENGTH()` | float | - |
| `GET_FINAL_RENDERED_CAM_NEAR_CLIP` | `float GET_FINAL_RENDERED_CAM_NEAR_CLIP()` | float | - |
| `GET_FINAL_RENDERED_CAM_NEAR_DOF` | `float GET_FINAL_RENDERED_CAM_NEAR_DOF()` | float | - |
| `GET_FINAL_RENDERED_CAM_ROT` | `Vector3 GET_FINAL_RENDERED_CAM_ROT(int rotationOrder)` | Vector3 | p0 seems to consistently be 2 across scripts<br><br>Function is called faily often by CAM::CREATE_CAM_WITH... |
| `GET_FINAL_RENDERED_REMOTE_PLAYER_CAM_FOV` | `float GET_FINAL_RENDERED_REMOTE_PLAYER_CAM_FOV(int player)` | float | - |
| `GET_FINAL_RENDERED_REMOTE_PLAYER_CAM_ROT` | `Vector3 GET_FINAL_RENDERED_REMOTE_PLAYER_CAM_ROT(int player, int rotationOrder)` | Vector3 | - |
| `GET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR` | `float GET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR()` | float | - |
| `GET_FOCUS_PED_ON_SCREEN` | `int GET_FOCUS_PED_ON_SCREEN(float p0, int p1, float p2, float p3, float p4, float p5, float p6, int p7, int p8)` | int | - |
| `GET_FOLLOW_PED_CAM_VIEW_MODE` | `int GET_FOLLOW_PED_CAM_VIEW_MODE()` | int | See viewmode enum in CAM.GET_FOLLOW_VEHICLE_CAM_VIEW_MODE for return value |
| `GET_FOLLOW_PED_CAM_ZOOM_LEVEL` | `int GET_FOLLOW_PED_CAM_ZOOM_LEVEL()` | int | - |
| `GET_FOLLOW_VEHICLE_CAM_VIEW_MODE` | `int GET_FOLLOW_VEHICLE_CAM_VIEW_MODE()` | int | Returns the type of camera:<br><br>enum _viewmode //0xA11D7CA8<br>{<br>	THIRD_PERSON_NEAR = 0,<br>	THIRD_PERSON_MED... |
| `GET_FOLLOW_VEHICLE_CAM_ZOOM_LEVEL` | `int GET_FOLLOW_VEHICLE_CAM_ZOOM_LEVEL()` | int | - |
| `GET_GAMEPLAY_CAM_COORD` | `Vector3 GET_GAMEPLAY_CAM_COORD()` | Vector3 | - |
| `GET_GAMEPLAY_CAM_FOV` | `float GET_GAMEPLAY_CAM_FOV()` | float | - |
| `GET_GAMEPLAY_CAM_RELATIVE_HEADING` | `float GET_GAMEPLAY_CAM_RELATIVE_HEADING()` | float | - |
| `GET_GAMEPLAY_CAM_RELATIVE_PITCH` | `float GET_GAMEPLAY_CAM_RELATIVE_PITCH()` | float | - |
| `GET_GAMEPLAY_CAM_ROT` | `Vector3 GET_GAMEPLAY_CAM_ROT(int rotationOrder)` | Vector3 | p0 dosen't seem to change much, I tried it with 0, 1, 2:<br>0-Pitch(X): -70.000092<br>0-Roll(Y): -0.000001... |
| `GET_RENDERING_CAM` | `int GET_RENDERING_CAM()` | int | - |
| `HARD_ATTACH_CAM_TO_ENTITY` | `void HARD_ATTACH_CAM_TO_ENTITY(int cam, int entity, float xRot, float yRot, float zRot, float xOffset, float yOffset, float zOffset, bool isRelative)` | void | Example from am_mp_drone script: <br><br>CAM::HARD_ATTACH_CAM_TO_ENTITY(Local_190.f_169, NETWORK::NET_TO_O... |
| `HARD_ATTACH_CAM_TO_PED_BONE` | `void HARD_ATTACH_CAM_TO_PED_BONE(int cam, int ped, int boneIndex, float p3, float p4, float p5, float p6, float p7, float p8, bool p9)` | void | - |
| `IGNORE_MENU_PREFERENCE_FOR_BONNET_CAMERA_THIS_UPDATE` | `void IGNORE_MENU_PREFERENCE_FOR_BONNET_CAMERA_THIS_UPDATE()` | void | - |
| `INVALIDATE_CINEMATIC_VEHICLE_IDLE_MODE` | `void INVALIDATE_CINEMATIC_VEHICLE_IDLE_MODE()` | void | Resets the vehicle idle camera timer. Calling this in a loop will disable the idle camera. |
| `INVALIDATE_IDLE_CAM` | `void INVALIDATE_IDLE_CAM()` | void | Resets the idle camera timer. Calling that in a loop once every few seconds is enough to disable the... |
| `IS_AIM_CAM_ACTIVE` | `bool IS_AIM_CAM_ACTIVE()` | bool | - |
| `IS_AIM_CAM_ACTIVE_IN_ACCURATE_MODE` | `bool IS_AIM_CAM_ACTIVE_IN_ACCURATE_MODE()` | bool | - |
| `IS_ALLOWED_INDEPENDENT_CAMERA_MODES` | `bool IS_ALLOWED_INDEPENDENT_CAMERA_MODES()` | bool | - |
| `IS_BONNET_CINEMATIC_CAM_RENDERING` | `bool IS_BONNET_CINEMATIC_CAM_RENDERING()` | bool | - |
| `IS_CAM_ACTIVE` | `bool IS_CAM_ACTIVE(int cam)` | bool | Returns whether or not the passed camera handle is active. |
| `IS_CAM_INTERPOLATING` | `bool IS_CAM_INTERPOLATING(int cam)` | bool | - |
| `IS_CAM_PLAYING_ANIM` | `bool IS_CAM_PLAYING_ANIM(int cam, string animName, string animDictionary)` | bool | - |
| `IS_CAM_RENDERING` | `bool IS_CAM_RENDERING(int cam)` | bool | - |
| `IS_CAM_SHAKING` | `bool IS_CAM_SHAKING(int cam)` | bool | - |
| `IS_CAM_SPLINE_PAUSED` | `bool IS_CAM_SPLINE_PAUSED(int cam)` | bool | - |
| `IS_CINEMATIC_CAM_INPUT_ACTIVE` | `bool IS_CINEMATIC_CAM_INPUT_ACTIVE()` | bool | Tests some cinematic camera flags |
| `IS_CINEMATIC_CAM_RENDERING` | `bool IS_CINEMATIC_CAM_RENDERING()` | bool | - |
| `IS_CINEMATIC_CAM_SHAKING` | `bool IS_CINEMATIC_CAM_SHAKING()` | bool | - |
| `IS_CINEMATIC_FIRST_PERSON_VEHICLE_INTERIOR_CAM_RENDERING` | `bool IS_CINEMATIC_FIRST_PERSON_VEHICLE_INTERIOR_CAM_RENDERING()` | bool | - |
| `IS_CINEMATIC_IDLE_CAM_RENDERING` | `bool IS_CINEMATIC_IDLE_CAM_RENDERING()` | bool | - |
| `IS_CINEMATIC_SHOT_ACTIVE` | `bool IS_CINEMATIC_SHOT_ACTIVE(uint p0)` | bool | Hash is always JOAAT("CAMERA_MAN_SHOT") in decompiled scripts |
| `IS_CODE_GAMEPLAY_HINT_ACTIVE` | `bool IS_CODE_GAMEPLAY_HINT_ACTIVE()` | bool | - |
| `IS_FIRST_PERSON_AIM_CAM_ACTIVE` | `bool IS_FIRST_PERSON_AIM_CAM_ACTIVE()` | bool | - |
| `IS_FOLLOW_PED_CAM_ACTIVE` | `bool IS_FOLLOW_PED_CAM_ACTIVE()` | bool | - |
| `IS_FOLLOW_VEHICLE_CAM_ACTIVE` | `bool IS_FOLLOW_VEHICLE_CAM_ACTIVE()` | bool | - |
| `IS_GAMEPLAY_CAM_LOOKING_BEHIND` | `bool IS_GAMEPLAY_CAM_LOOKING_BEHIND()` | bool | - |
| `IS_GAMEPLAY_CAM_RENDERING` | `bool IS_GAMEPLAY_CAM_RENDERING()` | bool | Examples when this function will return 0 are:<br>- During busted screen.<br>- When player is coming out f... |
| `IS_GAMEPLAY_CAM_SHAKING` | `bool IS_GAMEPLAY_CAM_SHAKING()` | bool | - |
| `IS_GAMEPLAY_HINT_ACTIVE` | `bool IS_GAMEPLAY_HINT_ACTIVE()` | bool | - |
| `IS_INTERPOLATING_FROM_SCRIPT_CAMS` | `bool IS_INTERPOLATING_FROM_SCRIPT_CAMS()` | bool | - |
| `IS_INTERPOLATING_TO_SCRIPT_CAMS` | `bool IS_INTERPOLATING_TO_SCRIPT_CAMS()` | bool | - |
| `IS_IN_VEHICLE_MOBILE_PHONE_CAMERA_RENDERING` | `bool IS_IN_VEHICLE_MOBILE_PHONE_CAMERA_RENDERING()` | bool | - |
| `IS_SCREEN_FADED_IN` | `bool IS_SCREEN_FADED_IN()` | bool | - |
| `IS_SCREEN_FADED_OUT` | `bool IS_SCREEN_FADED_OUT()` | bool | - |
| `IS_SCREEN_FADING_IN` | `bool IS_SCREEN_FADING_IN()` | bool | - |
| `IS_SCREEN_FADING_OUT` | `bool IS_SCREEN_FADING_OUT()` | bool | - |
| `IS_SCRIPT_GLOBAL_SHAKING` | `bool IS_SCRIPT_GLOBAL_SHAKING()` | bool | In drunk_controller.c4, sub_309<br>if (CAM::IS_SCRIPT_GLOBAL_SHAKING()) {<br>    CAM::STOP_SCRIPT_GLOBAL_S... |
| `IS_SPHERE_VISIBLE` | `bool IS_SPHERE_VISIBLE(float x, float y, float z, float radius)` | bool | - |
| `OVERRIDE_CAM_SPLINE_MOTION_BLUR` | `void OVERRIDE_CAM_SPLINE_MOTION_BLUR(int cam, int p1, float p2, float p3)` | void | Max value for p1 is 15. |
| `OVERRIDE_CAM_SPLINE_VELOCITY` | `void OVERRIDE_CAM_SPLINE_VELOCITY(int cam, int p1, float p2, float p3)` | void | - |
| `PLAY_CAM_ANIM` | `bool PLAY_CAM_ANIM(int cam, string animName, string animDictionary, float x, float y, float z, float xRot, float yRot, float zRot, bool p9, int p10)` | bool | Atleast one time in a script for the zRot Rockstar uses GET_ENTITY_HEADING to help fill the paramete... |
| `PLAY_SYNCHRONIZED_CAM_ANIM` | `bool PLAY_SYNCHRONIZED_CAM_ANIM(object p0, object p1, string animName, string animDictionary)` | bool | Examples:<br><br>CAM::PLAY_SYNCHRONIZED_CAM_ANIM(l_2734, NETWORK::NETWORK_GET_LOCAL_SCENE_FROM_NETWORK_ID(... |
| `POINT_CAM_AT_COORD` | `void POINT_CAM_AT_COORD(int cam, float x, float y, float z)` | void | - |
| `POINT_CAM_AT_ENTITY` | `void POINT_CAM_AT_ENTITY(int cam, int entity, float p2, float p3, float p4, bool p5)` | void | p5 always seems to be 1 i.e TRUE |
| `POINT_CAM_AT_PED_BONE` | `void POINT_CAM_AT_PED_BONE(int cam, int ped, int boneIndex, float x, float y, float z, bool p6)` | void | Parameters p0-p5 seems correct. The bool p6 is unknown, but through every X360 script it's always 1.... |
| `RENDER_SCRIPT_CAMS` | `void RENDER_SCRIPT_CAMS(bool render, bool ease, int easeTime, bool p3, bool p4, object p5)` | void | ease - smooth transition between the camera's positions<br>easeTime - Time in milliseconds for the tran... |
| `REPLAY_GET_MAX_DISTANCE_ALLOWED_FROM_PLAYER` | `float REPLAY_GET_MAX_DISTANCE_ALLOWED_FROM_PLAYER()` | float | - |
| `RESET_GAMEPLAY_CAM_FULL_ATTACH_PARENT_TRANSFORM_TIMER` | `void RESET_GAMEPLAY_CAM_FULL_ATTACH_PARENT_TRANSFORM_TIMER()` | void | - |
| `SET_ALLOW_CUSTOM_VEHICLE_DRIVE_BY_CAM_THIS_UPDATE` | `void SET_ALLOW_CUSTOM_VEHICLE_DRIVE_BY_CAM_THIS_UPDATE(bool p0)` | void | - |
| `SET_CAM_ACTIVE` | `void SET_CAM_ACTIVE(int cam, bool active)` | void | Set camera as active/inactive. |
| `SET_CAM_ACTIVE_WITH_INTERP` | `void SET_CAM_ACTIVE_WITH_INTERP(int camTo, int camFrom, int duration, int easeLocation, int easeRotation)` | void | Previous declaration void SET_CAM_ACTIVE_WITH_INTERP(Cam camTo, Cam camFrom, int duration, BOOL ease... |
| `SET_CAM_AFFECTS_AIMING` | `void SET_CAM_AFFECTS_AIMING(int cam, bool toggle)` | void | Allows you to aim and shoot at the direction the camera is facing. |
| `SET_CAM_ANIM_CURRENT_PHASE` | `void SET_CAM_ANIM_CURRENT_PHASE(int cam, float phase)` | void | - |
| `SET_CAM_CONTROLS_MINI_MAP_HEADING` | `void SET_CAM_CONTROLS_MINI_MAP_HEADING(int cam, bool toggle)` | void | Rotates the radar to match the camera's Z rotation |
| `SET_CAM_COORD` | `void SET_CAM_COORD(int cam, float posX, float posY, float posZ)` | void | Sets the position of the cam. |
| `SET_CAM_DEATH_FAIL_EFFECT_STATE` | `void SET_CAM_DEATH_FAIL_EFFECT_STATE(int p0)` | void | if p0 is 0, effect is cancelled<br><br>if p0 is 1, effect zooms in, gradually tilts cam clockwise apx 30 d... |
| `SET_CAM_DEBUG_NAME` | `void SET_CAM_DEBUG_NAME(int camera, string name)` | void | NOTE: Debugging functions are not present in the retail version of the game. |
| `SET_CAM_DOF_FNUMBER_OF_LENS` | `void SET_CAM_DOF_FNUMBER_OF_LENS(int camera, float p1)` | void | This native has its name defined inside its codE<br> |
| `SET_CAM_DOF_FOCAL_LENGTH_MULTIPLIER` | `void SET_CAM_DOF_FOCAL_LENGTH_MULTIPLIER(int camera, float multiplier)` | void | Native name labeled within its code |
| `SET_CAM_DOF_FOCUS_DISTANCE_BIAS` | `void SET_CAM_DOF_FOCUS_DISTANCE_BIAS(int camera, float p1)` | void | This native has a name defined inside its code |
| `SET_CAM_DOF_MAX_NEAR_IN_FOCUS_DISTANCE` | `void SET_CAM_DOF_MAX_NEAR_IN_FOCUS_DISTANCE(int camera, float p1)` | void | This native has a name defined inside its code |
| `SET_CAM_DOF_MAX_NEAR_IN_FOCUS_DISTANCE_BLEND_LEVEL` | `void SET_CAM_DOF_MAX_NEAR_IN_FOCUS_DISTANCE_BLEND_LEVEL(int camera, float p1)` | void | This native has a name defined inside its code |
| `SET_CAM_DOF_OVERRIDDEN_FOCUS_DISTANCE` | `void SET_CAM_DOF_OVERRIDDEN_FOCUS_DISTANCE(int camera, float p1)` | void | - |
| `SET_CAM_DOF_OVERRIDDEN_FOCUS_DISTANCE_BLEND_LEVEL` | `void SET_CAM_DOF_OVERRIDDEN_FOCUS_DISTANCE_BLEND_LEVEL(object p0, float p1)` | void | - |
| `SET_CAM_DOF_PLANES` | `void SET_CAM_DOF_PLANES(int cam, float p1, float p2, float p3, float p4)` | void | - |
| `SET_CAM_DOF_SHOULD_KEEP_LOOK_AT_TARGET_IN_FOCUS` | `void SET_CAM_DOF_SHOULD_KEEP_LOOK_AT_TARGET_IN_FOCUS(int camera, bool state)` | void | This native has a name defined inside its code |
| `SET_CAM_DOF_STRENGTH` | `void SET_CAM_DOF_STRENGTH(int cam, float dofStrength)` | void | - |
| `SET_CAM_FAR_CLIP` | `void SET_CAM_FAR_CLIP(int cam, float farClip)` | void | - |
| `SET_CAM_FAR_DOF` | `void SET_CAM_FAR_DOF(int cam, float farDOF)` | void | - |
| `SET_CAM_FOV` | `void SET_CAM_FOV(int cam, float fieldOfView)` | void | Sets the field of view of the cam.<br>---------------------------------------------<br>Min: 1.0f<br>Max: 130.... |
| `SET_CAM_INHERIT_ROLL_VEHICLE` | `void SET_CAM_INHERIT_ROLL_VEHICLE(int cam, bool p1)` | void | The native seems to only be called once.<br><br>The native is used as so,<br>CAM::SET_CAM_INHERIT_ROLL_VEHICL... |
| `SET_CAM_IS_INSIDE_VEHICLE` | `void SET_CAM_IS_INSIDE_VEHICLE(int cam, bool toggle)` | void | When set to true shadows appear more smooth but less detailed.<br>Set to false by default. |
| `SET_CAM_MOTION_BLUR_STRENGTH` | `void SET_CAM_MOTION_BLUR_STRENGTH(int cam, float strength)` | void | - |
| `SET_CAM_NEAR_CLIP` | `void SET_CAM_NEAR_CLIP(int cam, float nearClip)` | void | - |
| `SET_CAM_NEAR_DOF` | `void SET_CAM_NEAR_DOF(int cam, float nearDOF)` | void | - |
| `SET_CAM_PARAMS` | `void SET_CAM_PARAMS(int cam, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fieldOfView, object p8, int p9, int p10, int p11)` | void | - |
| `SET_CAM_ROT` | `void SET_CAM_ROT(int cam, float rotX, float rotY, float rotZ, int rotationOrder)` | void | Sets the rotation of the cam.<br>Last parameter unknown.<br><br>Last parameter seems to always be set to 2. |
| `SET_CAM_SHAKE_AMPLITUDE` | `void SET_CAM_SHAKE_AMPLITUDE(int cam, float amplitude)` | void | - |
| `SET_CAM_SPLINE_DURATION` | `void SET_CAM_SPLINE_DURATION(int cam, int timeDuration)` | void | I named p1 as timeDuration as it is obvious. I'm assuming tho it is ran in ms(Milliseconds) as usual... |
| `SET_CAM_SPLINE_NODE_EASE` | `void SET_CAM_SPLINE_NODE_EASE(int cam, int easingFunction, int p2, float p3)` | void | - |
| `SET_CAM_SPLINE_NODE_EXTRA_FLAGS` | `void SET_CAM_SPLINE_NODE_EXTRA_FLAGS(int cam, int p1, int flags)` | void | - |
| `SET_CAM_SPLINE_NODE_VELOCITY_SCALE` | `void SET_CAM_SPLINE_NODE_VELOCITY_SCALE(int cam, int p1, float scale)` | void | - |
| `SET_CAM_SPLINE_PHASE` | `void SET_CAM_SPLINE_PHASE(int cam, float p1)` | void | - |
| `SET_CAM_SPLINE_SMOOTHING_STYLE` | `void SET_CAM_SPLINE_SMOOTHING_STYLE(int cam, int smoothingStyle)` | void | - |
| `SET_CAM_USE_SHALLOW_DOF_MODE` | `void SET_CAM_USE_SHALLOW_DOF_MODE(int cam, bool toggle)` | void | - |
| `SET_CAM_VIEW_MODE_FOR_CONTEXT` | `void SET_CAM_VIEW_MODE_FOR_CONTEXT(int context, int viewMode)` | void | context: see _GET_CAM_ACTIVE_VIEW_MODE_CONTEXT, viewmode: see CAM.GET_FOLLOW_VEHICLE_CAM_VIEW_MODE |
| `SET_CINEMATIC_BUTTON_ACTIVE` | `void SET_CINEMATIC_BUTTON_ACTIVE(bool p0)` | void | - |
| `SET_CINEMATIC_CAM_SHAKE_AMPLITUDE` | `void SET_CINEMATIC_CAM_SHAKE_AMPLITUDE(float p0)` | void | - |
| `SET_CINEMATIC_MODE_ACTIVE` | `void SET_CINEMATIC_MODE_ACTIVE(bool toggle)` | void | Toggles the vehicle cinematic cam; requires the player ped to be in a vehicle to work. |
| `SET_CINEMATIC_NEWS_CHANNEL_ACTIVE_THIS_UPDATE` | `void SET_CINEMATIC_NEWS_CHANNEL_ACTIVE_THIS_UPDATE()` | void | - |
| `SET_CUTSCENE_CAM_FAR_CLIP_THIS_UPDATE` | `void SET_CUTSCENE_CAM_FAR_CLIP_THIS_UPDATE(float p0)` | void | Hardcoded to only work in multiplayer. |
| `SET_FIRST_PERSON_AIM_CAM_NEAR_CLIP_THIS_UPDATE` | `void SET_FIRST_PERSON_AIM_CAM_NEAR_CLIP_THIS_UPDATE(float p0)` | void | - |
| `SET_FIRST_PERSON_AIM_CAM_RELATIVE_HEADING_LIMITS_THIS_UPDATE` | `void SET_FIRST_PERSON_AIM_CAM_RELATIVE_HEADING_LIMITS_THIS_UPDATE(float p0, float p1)` | void | - |
| `SET_FIRST_PERSON_AIM_CAM_RELATIVE_PITCH_LIMITS_THIS_UPDATE` | `void SET_FIRST_PERSON_AIM_CAM_RELATIVE_PITCH_LIMITS_THIS_UPDATE(float p0, float p1)` | void | - |
| `SET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR` | `void SET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR(float zoomFactor)` | void | - |
| `SET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR_LIMITS_THIS_UPDATE` | `void SET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR_LIMITS_THIS_UPDATE(float p0, float p1)` | void | - |
| `SET_FIRST_PERSON_FLASH_EFFECT_TYPE` | `void SET_FIRST_PERSON_FLASH_EFFECT_TYPE(object p0)` | void | - |
| `SET_FIRST_PERSON_FLASH_EFFECT_VEHICLE_MODEL_HASH` | `void SET_FIRST_PERSON_FLASH_EFFECT_VEHICLE_MODEL_HASH(uint vehicleModel)` | void | - |
| `SET_FIRST_PERSON_FLASH_EFFECT_VEHICLE_MODEL_NAME` | `void SET_FIRST_PERSON_FLASH_EFFECT_VEHICLE_MODEL_NAME(string vehicleName)` | void | From b617 scripts:<br><br>CAM::SET_FIRST_PERSON_FLASH_EFFECT_VEHICLE_MODEL_NAME("DINGHY");<br>CAM::SET_FIRST_... |
| `SET_FIRST_PERSON_SHOOTER_CAMERA_HEADING` | `void SET_FIRST_PERSON_SHOOTER_CAMERA_HEADING(float yaw)` | void | Does nothing |
| `SET_FIRST_PERSON_SHOOTER_CAMERA_PITCH` | `void SET_FIRST_PERSON_SHOOTER_CAMERA_PITCH(float pitch)` | void | - |
| `SET_FLY_CAM_COORD_AND_CONSTRAIN` | `void SET_FLY_CAM_COORD_AND_CONSTRAIN(int cam, float x, float y, float z)` | void | - |
| `SET_FLY_CAM_HORIZONTAL_RESPONSE` | `void SET_FLY_CAM_HORIZONTAL_RESPONSE(int cam, float p1, float p2, float p3)` | void | - |
| `SET_FLY_CAM_MAX_HEIGHT` | `void SET_FLY_CAM_MAX_HEIGHT(int cam, float height)` | void | - |
| `SET_FLY_CAM_VERTICAL_CONTROLS_THIS_UPDATE` | `void SET_FLY_CAM_VERTICAL_CONTROLS_THIS_UPDATE(int cam)` | void | - |
| `SET_FLY_CAM_VERTICAL_RESPONSE` | `void SET_FLY_CAM_VERTICAL_RESPONSE(int cam, float p1, float p2, float p3)` | void | - |
| `SET_FOLLOW_CAM_IGNORE_ATTACH_PARENT_MOVEMENT_THIS_UPDATE` | `void SET_FOLLOW_CAM_IGNORE_ATTACH_PARENT_MOVEMENT_THIS_UPDATE()` | void | - |
| `SET_FOLLOW_PED_CAM_LADDER_ALIGN_THIS_UPDATE` | `void SET_FOLLOW_PED_CAM_LADDER_ALIGN_THIS_UPDATE()` | void | - |
| `SET_FOLLOW_PED_CAM_THIS_UPDATE` | `bool SET_FOLLOW_PED_CAM_THIS_UPDATE(string camName, int p1)` | bool | From the scripts:<br><br>CAM::SET_FOLLOW_PED_CAM_THIS_UPDATE("FOLLOW_PED_ATTACHED_TO_ROPE_CAMERA", 0);<br>CAM... |
| `SET_FOLLOW_PED_CAM_VIEW_MODE` | `void SET_FOLLOW_PED_CAM_VIEW_MODE(int viewMode)` | void | Sets the type of Player camera:<br><br>0 - Third Person Close<br>1 - Third Person Mid<br>2 - Third Person Far<br>4 ... |
| `SET_FOLLOW_VEHICLE_CAM_HIGH_ANGLE_MODE_EVERY_UPDATE` | `void SET_FOLLOW_VEHICLE_CAM_HIGH_ANGLE_MODE_EVERY_UPDATE(bool p0, bool p1)` | void | - |
| `SET_FOLLOW_VEHICLE_CAM_HIGH_ANGLE_MODE_THIS_UPDATE` | `void SET_FOLLOW_VEHICLE_CAM_HIGH_ANGLE_MODE_THIS_UPDATE(bool p0)` | void | - |
| `SET_FOLLOW_VEHICLE_CAM_SEAT_THIS_UPDATE` | `void SET_FOLLOW_VEHICLE_CAM_SEAT_THIS_UPDATE(int seatIndex)` | void | - |
| `SET_FOLLOW_VEHICLE_CAM_VIEW_MODE` | `void SET_FOLLOW_VEHICLE_CAM_VIEW_MODE(int viewMode)` | void | Sets the type of Player camera in vehicles:<br>viewmode: see CAM.GET_FOLLOW_VEHICLE_CAM_VIEW_MODE |
| `SET_FOLLOW_VEHICLE_CAM_ZOOM_LEVEL` | `void SET_FOLLOW_VEHICLE_CAM_ZOOM_LEVEL(int zoomLevel)` | void | - |
| `SET_GAMEPLAY_CAM_ALTITUDE_FOV_SCALING_STATE` | `void SET_GAMEPLAY_CAM_ALTITUDE_FOV_SCALING_STATE(bool p0)` | void | - |
| `SET_GAMEPLAY_CAM_ENTITY_TO_LIMIT_FOCUS_OVER_BOUNDING_SPHERE_THIS_UPDATE` | `void SET_GAMEPLAY_CAM_ENTITY_TO_LIMIT_FOCUS_OVER_BOUNDING_SPHERE_THIS_UPDATE(int entity)` | void | - |
| `SET_GAMEPLAY_CAM_FOLLOW_PED_THIS_UPDATE` | `void SET_GAMEPLAY_CAM_FOLLOW_PED_THIS_UPDATE(int ped)` | void | Forces gameplay cam to specified ped as if you were the ped or spectating it |
| `SET_GAMEPLAY_CAM_IGNORE_ENTITY_COLLISION_THIS_UPDATE` | `void SET_GAMEPLAY_CAM_IGNORE_ENTITY_COLLISION_THIS_UPDATE(int entity)` | void | - |
| `SET_GAMEPLAY_CAM_MAX_MOTION_BLUR_STRENGTH_THIS_UPDATE` | `void SET_GAMEPLAY_CAM_MAX_MOTION_BLUR_STRENGTH_THIS_UPDATE(float p0)` | void | some camera effect that is (also) used in the drunk-cheat, and turned off (by setting it to 0.0) alo... |
| `SET_GAMEPLAY_CAM_MOTION_BLUR_SCALING_THIS_UPDATE` | `void SET_GAMEPLAY_CAM_MOTION_BLUR_SCALING_THIS_UPDATE(float p0)` | void | some camera effect that is used in the drunk-cheat, and turned off (by setting it to 0.0) along with... |
| `SET_GAMEPLAY_CAM_RELATIVE_HEADING` | `void SET_GAMEPLAY_CAM_RELATIVE_HEADING(float heading)` | void | Sets the camera position relative to heading in float from -360 to +360.<br><br>Heading is alwyas 0 in aim... |
| `SET_GAMEPLAY_CAM_RELATIVE_PITCH` | `void SET_GAMEPLAY_CAM_RELATIVE_PITCH(float angle, float scalingFactor)` | void | This native sets the camera's pitch (rotation on the x-axis). |
| `SET_GAMEPLAY_CAM_SHAKE_AMPLITUDE` | `void SET_GAMEPLAY_CAM_SHAKE_AMPLITUDE(float amplitude)` | void | Sets the amplitude for the gameplay (i.e. 3rd or 1st) camera to shake. Used in script "drunk_control... |
| `SET_GAMEPLAY_COORD_HINT` | `void SET_GAMEPLAY_COORD_HINT(float x, float y, float z, int duration, int blendOutDuration, int blendInDuration, int p6)` | void | - |
| `SET_GAMEPLAY_ENTITY_HINT` | `void SET_GAMEPLAY_ENTITY_HINT(int entity, float xOffset, float yOffset, float zOffset, bool p4, int time, int easeInTime, int easeOutTime, int p8)` | void | p8 could be some sort of flag. Scripts use:<br>-244429742<br>0<br>1726668277<br>1844968929 |
| `SET_GAMEPLAY_HINT_BASE_ORBIT_PITCH_OFFSET` | `void SET_GAMEPLAY_HINT_BASE_ORBIT_PITCH_OFFSET(float value)` | void | - |
| `SET_GAMEPLAY_HINT_CAMERA_BLEND_TO_FOLLOW_PED_MEDIUM_VIEW_MODE` | `void SET_GAMEPLAY_HINT_CAMERA_BLEND_TO_FOLLOW_PED_MEDIUM_VIEW_MODE(bool toggle)` | void | - |
| `SET_GAMEPLAY_HINT_CAMERA_RELATIVE_SIDE_OFFSET` | `void SET_GAMEPLAY_HINT_CAMERA_RELATIVE_SIDE_OFFSET(float xOffset)` | void | - |
| `SET_GAMEPLAY_HINT_CAMERA_RELATIVE_VERTICAL_OFFSET` | `void SET_GAMEPLAY_HINT_CAMERA_RELATIVE_VERTICAL_OFFSET(float yOffset)` | void | - |
| `SET_GAMEPLAY_HINT_FOLLOW_DISTANCE_SCALAR` | `void SET_GAMEPLAY_HINT_FOLLOW_DISTANCE_SCALAR(float value)` | void | - |
| `SET_GAMEPLAY_HINT_FOV` | `void SET_GAMEPLAY_HINT_FOV(float FOV)` | void | - |
| `SET_GAMEPLAY_OBJECT_HINT` | `void SET_GAMEPLAY_OBJECT_HINT(int object, float xOffset, float yOffset, float zOffset, bool p4, int time, int easeInTime, int easeOutTime)` | void | - |
| `SET_GAMEPLAY_PED_HINT` | `void SET_GAMEPLAY_PED_HINT(int ped, float x1, float y1, float z1, bool p4, int duration, int blendOutDuration, int blendInDuration)` | void | - |
| `SET_GAMEPLAY_VEHICLE_HINT` | `void SET_GAMEPLAY_VEHICLE_HINT(int vehicle, float offsetX, float offsetY, float offsetZ, bool p4, int time, int easeInTime, int easeOutTime)` | void | Focuses the camera on the specified vehicle. |
| `SET_IN_VEHICLE_CAM_STATE_THIS_UPDATE` | `void SET_IN_VEHICLE_CAM_STATE_THIS_UPDATE(int p0, int p1)` | void | Forces gameplay cam to specified vehicle as if you were in it |
| `SET_SCRIPTED_CAMERA_IS_FIRST_PERSON_THIS_FRAME` | `void SET_SCRIPTED_CAMERA_IS_FIRST_PERSON_THIS_FRAME(bool p0)` | void | - |
| `SET_TABLE_GAMES_CAMERA_THIS_UPDATE` | `bool SET_TABLE_GAMES_CAMERA_THIS_UPDATE(uint hash)` | bool | - |
| `SET_THIRD_PERSON_AIM_CAM_NEAR_CLIP_THIS_UPDATE` | `void SET_THIRD_PERSON_AIM_CAM_NEAR_CLIP_THIS_UPDATE(float p0)` | void | - |
| `SET_THIRD_PERSON_CAM_ORBIT_DISTANCE_LIMITS_THIS_UPDATE` | `void SET_THIRD_PERSON_CAM_ORBIT_DISTANCE_LIMITS_THIS_UPDATE(float p0, float distance)` | void | Seems to animate the gameplay camera zoom.<br><br>Eg. SET_THIRD_PERSON_CAM_ORBIT_DISTANCE_LIMITS_THIS_UPDA... |
| `SET_THIRD_PERSON_CAM_RELATIVE_HEADING_LIMITS_THIS_UPDATE` | `void SET_THIRD_PERSON_CAM_RELATIVE_HEADING_LIMITS_THIS_UPDATE(float minimum, float maximum)` | void | minimum: Degrees between -180f and 180f.<br>maximum: Degrees between -180f and 180f.<br><br>Clamps the gamepl... |
| `SET_THIRD_PERSON_CAM_RELATIVE_PITCH_LIMITS_THIS_UPDATE` | `void SET_THIRD_PERSON_CAM_RELATIVE_PITCH_LIMITS_THIS_UPDATE(float minimum, float maximum)` | void | minimum: Degrees between -90f and 90f.<br>maximum: Degrees between -90f and 90f.<br><br>Clamps the gameplay c... |
| `SET_USE_HI_DOF` | `void SET_USE_HI_DOF()` | void | - |
| `SET_USE_HI_DOF_ON_SYNCED_SCENE_THIS_UPDATE` | `void SET_USE_HI_DOF_ON_SYNCED_SCENE_THIS_UPDATE()` | void | Only used in R* Script fm_mission_controller_2020 |
| `SET_WIDESCREEN_BORDERS` | `void SET_WIDESCREEN_BORDERS(bool p0, int p1)` | void | - |
| `SHAKE_CAM` | `void SHAKE_CAM(int cam, string type, float amplitude)` | void | Possible shake types (updated b617d):<br><br>DEATH_FAIL_IN_EFFECT_SHAKE<br>DRUNK_SHAKE<br>FAMILY5_DRUG_TRIP_SHAK... |
| `SHAKE_CINEMATIC_CAM` | `void SHAKE_CINEMATIC_CAM(string shakeType, float amount)` | void | p0 argument found in the b617d scripts: "DRUNK_SHAKE"<br><br>Full list of cam shake types by DurtyFree: ht... |
| `SHAKE_GAMEPLAY_CAM` | `void SHAKE_GAMEPLAY_CAM(string shakeName, float intensity)` | void | Possible shake types (updated b617d):<br><br>DEATH_FAIL_IN_EFFECT_SHAKE<br>DRUNK_SHAKE<br>FAMILY5_DRUG_TRIP_SHAK... |
| `SHAKE_SCRIPT_GLOBAL` | `void SHAKE_SCRIPT_GLOBAL(string p0, float p1)` | void | CAM::SHAKE_SCRIPT_GLOBAL("HAND_SHAKE", 0.2);<br><br>Full list of cam shake types by DurtyFree: https://git... |
| `STOP_CAM_POINTING` | `void STOP_CAM_POINTING(int cam)` | void | - |
| `STOP_CAM_SHAKING` | `void STOP_CAM_SHAKING(int cam, bool p1)` | void | - |
| `STOP_CINEMATIC_CAM_SHAKING` | `void STOP_CINEMATIC_CAM_SHAKING(bool p0)` | void | - |
| `STOP_CINEMATIC_SHOT` | `void STOP_CINEMATIC_SHOT(uint p0)` | void | Only used once in carsteal3 with p0 set to -1096069633 (CAMERA_MAN_SHOT) |
| `STOP_CODE_GAMEPLAY_HINT` | `void STOP_CODE_GAMEPLAY_HINT(bool p0)` | void | - |
| `STOP_CUTSCENE_CAM_SHAKING` | `void STOP_CUTSCENE_CAM_SHAKING(object p0)` | void | - |
| `STOP_GAMEPLAY_CAM_SHAKING` | `void STOP_GAMEPLAY_CAM_SHAKING(bool p0)` | void | - |
| `STOP_GAMEPLAY_HINT` | `void STOP_GAMEPLAY_HINT(bool p0)` | void | - |
| `STOP_GAMEPLAY_HINT_BEING_CANCELLED_THIS_UPDATE` | `void STOP_GAMEPLAY_HINT_BEING_CANCELLED_THIS_UPDATE(bool p0)` | void | This native does absolutely nothing, just a nullsub |
| `STOP_RENDERING_SCRIPT_CAMS_USING_CATCH_UP` | `void STOP_RENDERING_SCRIPT_CAMS_USING_CATCH_UP(bool render, float p1, int p2, object p3)` | void | This native makes the gameplay camera zoom into first person/third person with a special effect. |
| `STOP_SCRIPT_GLOBAL_SHAKING` | `void STOP_SCRIPT_GLOBAL_SHAKING(bool p0)` | void | In drunk_controller.c4, sub_309<br>if (CAM::IS_SCRIPT_GLOBAL_SHAKING()) {<br>    CAM::STOP_SCRIPT_GLOBAL_S... |
| `TRIGGER_VEHICLE_PART_BROKEN_CAMERA_SHAKE` | `void TRIGGER_VEHICLE_PART_BROKEN_CAMERA_SHAKE(int vehicle, int p1, float p2)` | void | p1: 0..16 |
| `USE_DEDICATED_STUNT_CAMERA_THIS_UPDATE` | `void USE_DEDICATED_STUNT_CAMERA_THIS_UPDATE(string camName)` | void | Sets gameplay camera to hash |
| `USE_SCRIPT_CAM_FOR_AMBIENT_POPULATION_ORIGIN_THIS_FRAME` | `void USE_SCRIPT_CAM_FOR_AMBIENT_POPULATION_ORIGIN_THIS_FRAME(bool p0, bool p1)` | void | - |
| `USE_VEHICLE_CAM_STUNT_SETTINGS_THIS_UPDATE` | `void USE_VEHICLE_CAM_STUNT_SETTINGS_THIS_UPDATE()` | void | - |
| `WAS_FLY_CAM_CONSTRAINED_ON_PREVIOUS_UDPATE` | `bool WAS_FLY_CAM_CONSTRAINED_ON_PREVIOUS_UDPATE(int cam)` | bool | - |
| `_ACTIVATE_CAM_WITH_INTERP_AND_FOV_CURVE` | `void _ACTIVATE_CAM_WITH_INTERP_AND_FOV_CURVE(int camTo, int camFrom, int duration, int easeLocation, int easeRotation, int easeFov)` | void | - |
| `_GET_THIRD_PERSON_CAM_MAX_ORBIT_DISTANCE_SPRING` | `float _GET_THIRD_PERSON_CAM_MAX_ORBIT_DISTANCE_SPRING()` | float | - |
| `_GET_THIRD_PERSON_CAM_MIN_ORBIT_DISTANCE_SPRING` | `float _GET_THIRD_PERSON_CAM_MIN_ORBIT_DISTANCE_SPRING()` | float | - |
| `_INTERPOLATE_CAM_WITH_PARAMS` | `void _INTERPOLATE_CAM_WITH_PARAMS(int camera, float camPosX, float camPosY, float camPosZ, float camRotX, float camRotY, float camRotZ, float fov, int duration, int posCurveType, int rotCurveType, int rotOrder, int fovCurveType)` | void | - |

---

## 详细说明

### ADD_CAM_SPLINE_NODE

- **命名空间:** `CAM`
- **Hash:** `0x8609C75EC438FB3B`
- **JHash:** `0xAD3C7EAA`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_CAM_SPLINE_NODE(int camera, float x, float y, float z, float xRot, float yRot, float zRot, int length, int smoothingStyle, int rotationOrder)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `camera` | `Cam` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `xRot` | `float` | `float` | - |
| `yRot` | `float` | `float` | - |
| `zRot` | `float` | `float` | - |
| `length` | `int` | `int` | - |
| `smoothingStyle` | `int` | `int` | - |
| `rotationOrder` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
I filled p1-p6 (the floats) as they are as other natives with 6 floats in a row are similar and I see no other method. So if a test from anyone proves them wrong please correct.

p7 (length) determines the length of the spline, affects camera path and duration of transition between previous node and this one

p8 big values ~100 will slow down the camera movement before reaching this node

p9 != 0 seems to override the rotation/pitch (bool?)
```

---

### ADD_CAM_SPLINE_NODE_USING_CAMERA

- **命名空间:** `CAM`
- **Hash:** `0x0FB82563989CF4FB`
- **JHash:** `0xBA6C085B`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_CAM_SPLINE_NODE_USING_CAMERA(int cam, int cam2, int length, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `cam2` | `Cam` | `int` | - |
| `length` | `int` | `int` | - |
| `p3` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p0 is the spline camera to which the node is being added.
p1 is the camera used to create the node.
p3 is always 3 in scripts. It might be smoothing style or rotation order.
```

---

### ADD_CAM_SPLINE_NODE_USING_CAMERA_FRAME

- **命名空间:** `CAM`
- **Hash:** `0x0A9F2A468B328E74`
- **JHash:** `0x30510511`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_CAM_SPLINE_NODE_USING_CAMERA_FRAME(int cam, int cam2, int length, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `cam2` | `Cam` | `int` | - |
| `length` | `int` | `int` | - |
| `p3` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p0 is the spline camera to which the node is being added.
p1 is the camera used to create the node.
p3 is always 3 in scripts. It might be smoothing style or rotation order.
```

---

### ADD_CAM_SPLINE_NODE_USING_GAMEPLAY_FRAME

- **命名空间:** `CAM`
- **Hash:** `0x609278246A29CA34`
- **JHash:** `0xB4737F03`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_CAM_SPLINE_NODE_USING_GAMEPLAY_FRAME(int cam, int length, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `length` | `int` | `int` | - |
| `p2` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p2 is always 2 in scripts. It might be smoothing style or rotation order.
```

---

### ALLOW_MOTION_BLUR_DECAY

- **命名空间:** `CAM`
- **Hash:** `0x271017B9BA825366`
- **JHash:** `0x43220969`
- **Build:** `323`

**C# 签名:**
```csharp
void ALLOW_MOTION_BLUR_DECAY(object p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### ANIMATED_SHAKE_CAM

- **命名空间:** `CAM`
- **Hash:** `0xA2746EEAE3E577CD`
- **JHash:** `0xE1168767`
- **Build:** `323`

**C# 签名:**
```csharp
void ANIMATED_SHAKE_CAM(int cam, string p1, string p2, string p3, float amplitude)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `p1` | `const char*` | `string` | - |
| `p2` | `const char*` | `string` | - |
| `p3` | `const char*` | `string` | - |
| `amplitude` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Example from michael2 script.

CAM::ANIMATED_SHAKE_CAM(l_5069, "shake_cam_all@", "light", "", 1f);
```

---

### ANIMATED_SHAKE_SCRIPT_GLOBAL

- **命名空间:** `CAM`
- **Hash:** `0xC2EAE3FB8CDBED31`
- **JHash:** `0xCB75BD9C`
- **Build:** `323`

**C# 签名:**
```csharp
void ANIMATED_SHAKE_SCRIPT_GLOBAL(string p0, string p1, string p2, float p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `const char*` | `string` | - |
| `p1` | `const char*` | `string` | - |
| `p2` | `const char*` | `string` | - |
| `p3` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
CAM::ANIMATED_SHAKE_SCRIPT_GLOBAL("SHAKE_CAM_medium", "medium", "", 0.5f);

Full list of cam shake types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/camShakeTypesCompact.json
```

---

### ARE_WIDESCREEN_BORDERS_ACTIVE

- **命名空间:** `CAM`
- **Hash:** `0x4879E4FE39074CDF`
- **Build:** `372`

**C# 签名:**
```csharp
bool ARE_WIDESCREEN_BORDERS_ACTIVE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### ATTACH_CAM_TO_ENTITY

- **命名空间:** `CAM`
- **Hash:** `0xFEDB7D269E8C60E3`
- **JHash:** `0xAD7C45F6`
- **Build:** `323`

**C# 签名:**
```csharp
void ATTACH_CAM_TO_ENTITY(int cam, int entity, float xOffset, float yOffset, float zOffset, bool isRelative)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `entity` | `Entity` | `int` | - |
| `xOffset` | `float` | `float` | - |
| `yOffset` | `float` | `float` | - |
| `zOffset` | `float` | `float` | - |
| `isRelative` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Last param determines if its relative to the Entity
```

---

### ATTACH_CAM_TO_PED_BONE

- **命名空间:** `CAM`
- **Hash:** `0x61A3DBA14AB7F411`
- **JHash:** `0x506BB35C`
- **Build:** `323`

**C# 签名:**
```csharp
void ATTACH_CAM_TO_PED_BONE(int cam, int ped, int boneIndex, float x, float y, float z, bool heading)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `ped` | `Ped` | `int` | - |
| `boneIndex` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `heading` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### ATTACH_CAM_TO_VEHICLE_BONE

- **命名空间:** `CAM`
- **Hash:** `0x8DB3F12A02CAEF72`
- **Build:** `1290`

**C# 签名:**
```csharp
void ATTACH_CAM_TO_VEHICLE_BONE(int cam, int vehicle, int boneIndex, bool relativeRotation, float rotX, float rotY, float rotZ, float offsetX, float offsetY, float offsetZ, bool fixedDirection)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `vehicle` | `Vehicle` | `int` | - |
| `boneIndex` | `int` | `int` | - |
| `relativeRotation` | `BOOL` | `bool` | - |
| `rotX` | `float` | `float` | - |
| `rotY` | `float` | `float` | - |
| `rotZ` | `float` | `float` | - |
| `offsetX` | `float` | `float` | - |
| `offsetY` | `float` | `float` | - |
| `offsetZ` | `float` | `float` | - |
| `fixedDirection` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native works with vehicles only. Bone indexes are usually given by this native GET_ENTITY_BONE_INDEX_BY_NAME.
```

---

### BLOCK_FIRST_PERSON_ORIENTATION_RESET_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x9F97DA93681F87EA`
- **Build:** `1734`

**C# 签名:**
```csharp
void BLOCK_FIRST_PERSON_ORIENTATION_RESET_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

---

### BYPASS_CAMERA_COLLISION_BUOYANCY_TEST_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0xA7092AFE81944852`
- **Build:** `2189`

**C# 签名:**
```csharp
void BYPASS_CAMERA_COLLISION_BUOYANCY_TEST_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

---

### BYPASS_CUTSCENE_CAM_RENDERING_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0xDB629FFD9285FA06`
- **Build:** `323`

**C# 签名:**
```csharp
void BYPASS_CUTSCENE_CAM_RENDERING_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

---

### CAMERA_PREVENT_COLLISION_SETTINGS_FOR_TRIPLEHEAD_IN_INTERIORS_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x62374889A4D59F72`
- **Build:** `877`

**C# 签名:**
```csharp
void CAMERA_PREVENT_COLLISION_SETTINGS_FOR_TRIPLEHEAD_IN_INTERIORS_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

---

### CREATE_CAM

- **命名空间:** `CAM`
- **Hash:** `0xC3981DCE61D9E13F`
- **JHash:** `0xE9BF2A7D`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_CAM(string camName, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `camName` | `const char*` | `string` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `Cam`)

**说明:**
```
"DEFAULT_SCRIPTED_CAMERA"
"DEFAULT_ANIMATED_CAMERA"
"DEFAULT_SPLINE_CAMERA"
"DEFAULT_SCRIPTED_FLY_CAMERA"
"TIMED_SPLINE_CAMERA"
```

---

### CREATE_CAMERA

- **命名空间:** `CAM`
- **Hash:** `0x5E3CF89C6BCCA67D`
- **JHash:** `0x5D6739AE`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_CAMERA(uint camHash, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `camHash` | `Hash` | `uint` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `Cam`)

---

### CREATE_CAMERA_WITH_PARAMS

- **命名空间:** `CAM`
- **Hash:** `0x6ABFA3E16460F22D`
- **JHash:** `0x0688BE9A`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_CAMERA_WITH_PARAMS(uint camHash, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fov, bool p8, object p9)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `camHash` | `Hash` | `uint` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `rotX` | `float` | `float` | - |
| `rotY` | `float` | `float` | - |
| `rotZ` | `float` | `float` | - |
| `fov` | `float` | `float` | - |
| `p8` | `BOOL` | `bool` | - |
| `p9` | `Any` | `object` | - |

**返回值:** `int` (Native: `Cam`)

**说明:**
```
p9 uses 2 by default
```

---

### CREATE_CAM_WITH_PARAMS

- **命名空间:** `CAM`
- **Hash:** `0xB51194800B257161`
- **JHash:** `0x23B02F15`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_CAM_WITH_PARAMS(string camName, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fov, bool p8, int p9)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `camName` | `const char*` | `string` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `rotX` | `float` | `float` | - |
| `rotY` | `float` | `float` | - |
| `rotZ` | `float` | `float` | - |
| `fov` | `float` | `float` | - |
| `p8` | `BOOL` | `bool` | - |
| `p9` | `int` | `int` | - |

**返回值:** `int` (Native: `Cam`)

**说明:**
```
camName is always set to "DEFAULT_SCRIPTED_CAMERA" in Rockstar's scripts.
------------
Camera names found in the b617d scripts:
"DEFAULT_ANIMATED_CAMERA"
"DEFAULT_SCRIPTED_CAMERA"
"DEFAULT_SCRIPTED_FLY_CAMERA"
"DEFAULT_SPLINE_CAMERA"
------------
Side Note: It seems p8 is basically to represent what would be the bool p1 within CREATE_CAM native. As well as the p9 since it's always 2 in scripts seems to represent what would be the last param within SET_CAM_ROT native which normally would be 2.
```

---

### CREATE_CINEMATIC_SHOT

- **命名空间:** `CAM`
- **Hash:** `0x741B0129D4560F31`
- **JHash:** `0xAC494E35`
- **Build:** `323`

**C# 签名:**
```csharp
void CREATE_CINEMATIC_SHOT(uint p0, int time, bool p2, int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Hash` | `uint` | - |
| `time` | `int` | `int` | - |
| `p2` | `BOOL` | `bool` | - |
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
hash is always JOAAT("CAMERA_MAN_SHOT") in decompiled scripts
```

---

### DESTROY_ALL_CAMS

- **命名空间:** `CAM`
- **Hash:** `0x8E5FB15663F79120`
- **JHash:** `0x10C151CE`
- **Build:** `323`

**C# 签名:**
```csharp
void DESTROY_ALL_CAMS(bool bScriptHostCam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `bScriptHostCam` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
BOOL param indicates whether the cam should be destroyed if it belongs to the calling script.
```

---

### DESTROY_CAM

- **命名空间:** `CAM`
- **Hash:** `0x865908C81A2C22E9`
- **JHash:** `0xC39302BD`
- **Build:** `323`

**C# 签名:**
```csharp
void DESTROY_CAM(int cam, bool bScriptHostCam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `bScriptHostCam` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
BOOL param indicates whether the cam should be destroyed if it belongs to the calling script.
```

---

### DETACH_CAM

- **命名空间:** `CAM`
- **Hash:** `0xA2FABBE87F4BAD82`
- **JHash:** `0xF4FBF14A`
- **Build:** `323`

**C# 签名:**
```csharp
void DETACH_CAM(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DISABLE_AIM_CAM_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x1A31FE0049E542F6`
- **JHash:** `0x1BAA7182`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_AIM_CAM_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

---

### DISABLE_CAM_COLLISION_FOR_OBJECT

- **命名空间:** `CAM`
- **Hash:** `0x49482F9FCD825AAA`
- **JHash:** `0xC4736ED3`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_CAM_COLLISION_FOR_OBJECT(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DISABLE_CINEMATIC_BONNET_CAMERA_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0xADFF1B2A555F5FBA`
- **JHash:** `0x5AC6DAC9`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_CINEMATIC_BONNET_CAMERA_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

---

### DISABLE_CINEMATIC_SLOW_MO_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x17FCA7199A530203`
- **Build:** `323`

**C# 签名:**
```csharp
bool DISABLE_CINEMATIC_SLOW_MO_THIS_UPDATE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### DISABLE_CINEMATIC_VEHICLE_IDLE_MODE_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x62ECFCFDEE7885D6`
- **JHash:** `0x837F8581`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_CINEMATIC_VEHICLE_IDLE_MODE_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

---

### DISABLE_FIRST_PERSON_CAMERA_WATER_CLIPPING_TEST_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0xB1381B97F70C7B30`
- **Build:** `1180`

**C# 签名:**
```csharp
void DISABLE_FIRST_PERSON_CAMERA_WATER_CLIPPING_TEST_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets some flag on cinematic camera
```

---

### DISABLE_FIRST_PERSON_FLASH_EFFECT_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x59424BD75174C9B1`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_FIRST_PERSON_FLASH_EFFECT_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

---

### DISABLE_GAMEPLAY_CAM_ALTITUDE_FOV_SCALING_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0xEA7F0AD7E9BA676F`
- **JHash:** `0xA61FF9AC`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_GAMEPLAY_CAM_ALTITUDE_FOV_SCALING_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Shows the crosshair even if it wouldn't show normally. Only works for one frame, so make sure to call it repeatedly.
```

---

### DISABLE_NEAR_CLIP_SCAN_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x5A43C76F7FC7BA5F`
- **JHash:** `0xE206C450`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_NEAR_CLIP_SCAN_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

---

### DISABLE_ON_FOOT_FIRST_PERSON_VIEW_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0xDE2EF5DA284CC8DF`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_ON_FOOT_FIRST_PERSON_VIEW_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Disables first person camera for the current frame.

Found in decompiled scripts:
GRAPHICS::DRAW_DEBUG_TEXT_2D("Disabling First Person Cam", 0.5, 0.8, 0.0, 0, 0, 255, 255);
CAM::DISABLE_ON_FOOT_FIRST_PERSON_VIEW_THIS_UPDATE();
```

---

### DOES_CAM_EXIST

- **命名空间:** `CAM`
- **Hash:** `0xA7A932170592B50E`
- **JHash:** `0x1EF89DC0`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_CAM_EXIST(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns whether or not the passed camera handle exists.
```

---

### DO_SCREEN_FADE_IN

- **命名空间:** `CAM`
- **Hash:** `0xD4E8E24955024033`
- **JHash:** `0x66C1BDEE`
- **Build:** `323`

**C# 签名:**
```csharp
void DO_SCREEN_FADE_IN(int duration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `duration` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Fades the screen in.

duration: The time the fade should take, in milliseconds.
```

---

### DO_SCREEN_FADE_OUT

- **命名空间:** `CAM`
- **Hash:** `0x891B5B39AC6302AF`
- **JHash:** `0x89D01805`
- **Build:** `323`

**C# 签名:**
```csharp
void DO_SCREEN_FADE_OUT(int duration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `duration` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Fades the screen out.

duration: The time the fade should take, in milliseconds.
```

---

### FORCE_BONNET_CAMERA_RELATIVE_HEADING_AND_PITCH

- **命名空间:** `CAM`
- **Hash:** `0x28B022A17B068A3A`
- **Build:** `1734`

**C# 签名:**
```csharp
void FORCE_BONNET_CAMERA_RELATIVE_HEADING_AND_PITCH(float p0, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### FORCE_CAMERA_RELATIVE_HEADING_AND_PITCH

- **命名空间:** `CAM`
- **Hash:** `0x48608C3464F58AB4`
- **Build:** `505`

**C# 签名:**
```csharp
void FORCE_CAMERA_RELATIVE_HEADING_AND_PITCH(float roll, float pitch, float yaw)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `roll` | `float` | `float` | - |
| `pitch` | `float` | `float` | - |
| `yaw` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### FORCE_CAM_FAR_CLIP

- **命名空间:** `CAM`
- **Hash:** `0xAABD62873FFB1A33`
- **Build:** `2189`

**C# 签名:**
```csharp
void FORCE_CAM_FAR_CLIP(int cam, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### FORCE_CINEMATIC_RENDERING_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0xA41BCD7213805AAC`
- **JHash:** `0xFBB85E02`
- **Build:** `323`

**C# 签名:**
```csharp
void FORCE_CINEMATIC_RENDERING_THIS_UPDATE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### FORCE_TIGHTSPACE_CUSTOM_FRAMING_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x380B4968D1E09E55`
- **Build:** `1290`

**C# 签名:**
```csharp
void FORCE_TIGHTSPACE_CUSTOM_FRAMING_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

---

### FORCE_VEHICLE_CAM_STUNT_SETTINGS_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x0AA27680A0BD43FA`
- **Build:** `1103`

**C# 签名:**
```csharp
void FORCE_VEHICLE_CAM_STUNT_SETTINGS_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

---

### GET_CAM_ACTIVE_VIEW_MODE_CONTEXT

- **命名空间:** `CAM`
- **Hash:** `0x19CAFA3C87F7C2FF`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_CAM_ACTIVE_VIEW_MODE_CONTEXT()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
enum Context
{
	ON_FOOT,
	IN_VEHICLE,
	ON_BIKE,
	IN_BOAT,
	IN_AIRCRAFT,
	IN_SUBMARINE,
	IN_HELI,
	IN_TURRET
};
```

---

### GET_CAM_ANIM_CURRENT_PHASE

- **命名空间:** `CAM`
- **Hash:** `0xA10B2DB49E92A6B0`
- **JHash:** `0x345F72D0`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_CAM_ANIM_CURRENT_PHASE(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_CAM_COORD

- **命名空间:** `CAM`
- **Hash:** `0xBAC038F7459AE5AE`
- **JHash:** `0x7C40F09C`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_CAM_COORD(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

---

### GET_CAM_DOF_STRENGTH

- **命名空间:** `CAM`
- **Hash:** `0x06D153C0B99B6128`
- **Build:** `2699`

**C# 签名:**
```csharp
float GET_CAM_DOF_STRENGTH(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_CAM_FAR_CLIP

- **命名空间:** `CAM`
- **Hash:** `0xB60A9CFEB21CA6AA`
- **JHash:** `0x09F119B8`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_CAM_FAR_CLIP(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_CAM_FAR_DOF

- **命名空间:** `CAM`
- **Hash:** `0x255F8DAFD540D397`
- **JHash:** `0x98C5CCE9`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_CAM_FAR_DOF(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_CAM_FOV

- **命名空间:** `CAM`
- **Hash:** `0xC3330A45CCCDB26A`
- **JHash:** `0xD6E9FCF5`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_CAM_FOV(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_CAM_NEAR_CLIP

- **命名空间:** `CAM`
- **Hash:** `0xC520A34DAFBF24B1`
- **JHash:** `0xCFCD35EE`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_CAM_NEAR_CLIP(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_CAM_NEAR_DOF

- **命名空间:** `CAM`
- **Hash:** `0xC2612D223D915A1C`
- **Build:** `2699`

**C# 签名:**
```csharp
float GET_CAM_NEAR_DOF(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_CAM_ROT

- **命名空间:** `CAM`
- **Hash:** `0x7D304C1C955E3E12`
- **JHash:** `0xDAC84C9F`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_CAM_ROT(int cam, int rotationOrder)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `rotationOrder` | `int` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
The last parameter, as in other "ROT" methods, is usually 2.
```

---

### GET_CAM_SPLINE_NODE_INDEX

- **命名空间:** `CAM`
- **Hash:** `0xB22B17DF858716A6`
- **JHash:** `0xF8AEB6BD`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_CAM_SPLINE_NODE_INDEX(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_CAM_SPLINE_NODE_PHASE

- **命名空间:** `CAM`
- **Hash:** `0xD9D0E694C8282C96`
- **JHash:** `0x7B9522F6`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_CAM_SPLINE_NODE_PHASE(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
I'm pretty sure the parameter is the camera as usual, but I am not certain so I'm going to leave it as is.
```

---

### GET_CAM_SPLINE_PHASE

- **命名空间:** `CAM`
- **Hash:** `0xB5349E36C546509A`
- **JHash:** `0x39784DD9`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_CAM_SPLINE_PHASE(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
Can use this with SET_CAM_SPLINE_PHASE to set the float it this native returns.

(returns 1.0f when no nodes has been added, reached end of non existing spline)
```

---

### GET_CAM_VIEW_MODE_FOR_CONTEXT

- **命名空间:** `CAM`
- **Hash:** `0xEE778F8C7E1142E2`
- **JHash:** `0xF3B148A6`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_CAM_VIEW_MODE_FOR_CONTEXT(int context)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `context` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
context: see _GET_CAM_ACTIVE_VIEW_MODE_CONTEXT
```

---

### GET_DEBUG_CAM

- **命名空间:** `CAM`
- **Hash:** `0x77C3CEC46BE286F6`
- **Build:** `2372`

**C# 签名:**
```csharp
int GET_DEBUG_CAM()
```

**返回值:** `int` (Native: `Cam`)

---

### GET_FINAL_RENDERED_CAM_COORD

- **命名空间:** `CAM`
- **Hash:** `0xA200EB1EE790F448`
- **JHash:** `0x9C84BDA0`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_FINAL_RENDERED_CAM_COORD()
```

**返回值:** `Vector3` (Native: `Vector3`)

---

### GET_FINAL_RENDERED_CAM_FAR_CLIP

- **命名空间:** `CAM`
- **Hash:** `0xDFC8CBC606FDB0FC`
- **JHash:** `0x46CB3A49`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_FINAL_RENDERED_CAM_FAR_CLIP()
```

**返回值:** `float` (Native: `float`)

---

### GET_FINAL_RENDERED_CAM_FAR_DOF

- **命名空间:** `CAM`
- **Hash:** `0x9780F32BCAF72431`
- **JHash:** `0xF24777CA`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_FINAL_RENDERED_CAM_FAR_DOF()
```

**返回值:** `float` (Native: `float`)

---

### GET_FINAL_RENDERED_CAM_FOV

- **命名空间:** `CAM`
- **Hash:** `0x80EC114669DAEFF4`
- **JHash:** `0x721B763B`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_FINAL_RENDERED_CAM_FOV()
```

**返回值:** `float` (Native: `float`)

**说明:**
```
Gets some camera fov
```

---

### GET_FINAL_RENDERED_CAM_MOTION_BLUR_STRENGTH

- **命名空间:** `CAM`
- **Hash:** `0x162F9D995753DC19`
- **JHash:** `0x38992E83`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_FINAL_RENDERED_CAM_MOTION_BLUR_STRENGTH()
```

**返回值:** `float` (Native: `float`)

---

### GET_FINAL_RENDERED_CAM_NEAR_CLIP

- **命名空间:** `CAM`
- **Hash:** `0xD0082607100D7193`
- **JHash:** `0x457AE195`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_FINAL_RENDERED_CAM_NEAR_CLIP()
```

**返回值:** `float` (Native: `float`)

---

### GET_FINAL_RENDERED_CAM_NEAR_DOF

- **命名空间:** `CAM`
- **Hash:** `0xA03502FC581F7D9B`
- **JHash:** `0x19297A7A`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_FINAL_RENDERED_CAM_NEAR_DOF()
```

**返回值:** `float` (Native: `float`)

---

### GET_FINAL_RENDERED_CAM_ROT

- **命名空间:** `CAM`
- **Hash:** `0x5B4E4C817FCC2DFB`
- **JHash:** `0x1FFBEFC5`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_FINAL_RENDERED_CAM_ROT(int rotationOrder)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `rotationOrder` | `int` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
p0 seems to consistently be 2 across scripts

Function is called faily often by CAM::CREATE_CAM_WITH_PARAMS
```

---

### GET_FINAL_RENDERED_REMOTE_PLAYER_CAM_FOV

- **命名空间:** `CAM`
- **Hash:** `0x5F35F6732C3FBBA0`
- **JHash:** `0x23E3F106`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_FINAL_RENDERED_REMOTE_PLAYER_CAM_FOV(int player)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_FINAL_RENDERED_REMOTE_PLAYER_CAM_ROT

- **命名空间:** `CAM`
- **Hash:** `0x26903D9CD1175F2C`
- **JHash:** `0xACADF916`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_FINAL_RENDERED_REMOTE_PLAYER_CAM_ROT(int player, int rotationOrder)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `rotationOrder` | `int` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

---

### GET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR

- **命名空间:** `CAM`
- **Hash:** `0x7EC52CC40597D170`
- **JHash:** `0x33951005`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR()
```

**返回值:** `float` (Native: `float`)

---

### GET_FOCUS_PED_ON_SCREEN

- **命名空间:** `CAM`
- **Hash:** `0x89215EC747DF244A`
- **JHash:** `0xFD99BE2B`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_FOCUS_PED_ON_SCREEN(float p0, int p1, float p2, float p3, float p4, float p5, float p6, int p7, int p8)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `int` | `int` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `float` | `float` | - |
| `p5` | `float` | `float` | - |
| `p6` | `float` | `float` | - |
| `p7` | `int` | `int` | - |
| `p8` | `int` | `int` | - |

**返回值:** `int` (Native: `Ped`)

---

### GET_FOLLOW_PED_CAM_VIEW_MODE

- **命名空间:** `CAM`
- **Hash:** `0x8D4D46230B2C353A`
- **JHash:** `0xA65FF946`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_FOLLOW_PED_CAM_VIEW_MODE()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
See viewmode enum in CAM.GET_FOLLOW_VEHICLE_CAM_VIEW_MODE for return value
```

---

### GET_FOLLOW_PED_CAM_ZOOM_LEVEL

- **命名空间:** `CAM`
- **Hash:** `0x33E6C8EFD0CD93E9`
- **JHash:** `0x57583DF1`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_FOLLOW_PED_CAM_ZOOM_LEVEL()
```

**返回值:** `int` (Native: `int`)

---

### GET_FOLLOW_VEHICLE_CAM_VIEW_MODE

- **命名空间:** `CAM`
- **Hash:** `0xA4FF579AC0E3AAAE`
- **JHash:** `0xA4B4DB03`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_FOLLOW_VEHICLE_CAM_VIEW_MODE()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns the type of camera:

enum _viewmode //0xA11D7CA8
{
	THIRD_PERSON_NEAR = 0,
	THIRD_PERSON_MEDIUM = 1,
	THIRD_PERSON_FAR = 2,
	CINEMATIC = 3,
	FIRST_PERSON = 4
};
```

---

### GET_FOLLOW_VEHICLE_CAM_ZOOM_LEVEL

- **命名空间:** `CAM`
- **Hash:** `0xEE82280AB767B690`
- **JHash:** `0x8CD67DE3`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_FOLLOW_VEHICLE_CAM_ZOOM_LEVEL()
```

**返回值:** `int` (Native: `int`)

---

### GET_GAMEPLAY_CAM_COORD

- **命名空间:** `CAM`
- **Hash:** `0x14D6F5678D8F1B37`
- **JHash:** `0x9388CF79`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_GAMEPLAY_CAM_COORD()
```

**返回值:** `Vector3` (Native: `Vector3`)

---

### GET_GAMEPLAY_CAM_FOV

- **命名空间:** `CAM`
- **Hash:** `0x65019750A0324133`
- **JHash:** `0x4D6B3BFA`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_GAMEPLAY_CAM_FOV()
```

**返回值:** `float` (Native: `float`)

---

### GET_GAMEPLAY_CAM_RELATIVE_HEADING

- **命名空间:** `CAM`
- **Hash:** `0x743607648ADD4587`
- **JHash:** `0xCAF839C2`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_GAMEPLAY_CAM_RELATIVE_HEADING()
```

**返回值:** `float` (Native: `float`)

---

### GET_GAMEPLAY_CAM_RELATIVE_PITCH

- **命名空间:** `CAM`
- **Hash:** `0x3A6867B4845BEDA2`
- **JHash:** `0xFC5A4946`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_GAMEPLAY_CAM_RELATIVE_PITCH()
```

**返回值:** `float` (Native: `float`)

---

### GET_GAMEPLAY_CAM_ROT

- **命名空间:** `CAM`
- **Hash:** `0x837765A25378F0BB`
- **JHash:** `0x13A010B5`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_GAMEPLAY_CAM_ROT(int rotationOrder)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `rotationOrder` | `int` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
p0 dosen't seem to change much, I tried it with 0, 1, 2:
0-Pitch(X): -70.000092
0-Roll(Y): -0.000001
0-Yaw(Z): -43.886459
1-Pitch(X): -70.000092
1-Roll(Y): -0.000001
1-Yaw(Z): -43.886463
2-Pitch(X): -70.000092
2-Roll(Y): -0.000002
2-Yaw(Z): -43.886467
```

---

### GET_RENDERING_CAM

- **命名空间:** `CAM`
- **Hash:** `0x5234F9F10919EABA`
- **JHash:** `0x0FCF4DF1`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_RENDERING_CAM()
```

**返回值:** `int` (Native: `Cam`)

---

### HARD_ATTACH_CAM_TO_ENTITY

- **命名空间:** `CAM`
- **Hash:** `0x202A5ED9CE01D6E7`
- **Build:** `2189`

**C# 签名:**
```csharp
void HARD_ATTACH_CAM_TO_ENTITY(int cam, int entity, float xRot, float yRot, float zRot, float xOffset, float yOffset, float zOffset, bool isRelative)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `entity` | `Entity` | `int` | - |
| `xRot` | `float` | `float` | - |
| `yRot` | `float` | `float` | - |
| `zRot` | `float` | `float` | - |
| `xOffset` | `float` | `float` | - |
| `yOffset` | `float` | `float` | - |
| `zOffset` | `float` | `float` | - |
| `isRelative` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Example from am_mp_drone script: 

CAM::HARD_ATTACH_CAM_TO_ENTITY(Local_190.f_169, NETWORK::NET_TO_OBJ(Local_190.f_159), 0f, 0f, 180f, Var0, 1);
```

---

### HARD_ATTACH_CAM_TO_PED_BONE

- **命名空间:** `CAM`
- **Hash:** `0x149916F50C34A40D`
- **Build:** `1180`

**C# 签名:**
```csharp
void HARD_ATTACH_CAM_TO_PED_BONE(int cam, int ped, int boneIndex, float p3, float p4, float p5, float p6, float p7, float p8, bool p9)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `ped` | `Ped` | `int` | - |
| `boneIndex` | `int` | `int` | - |
| `p3` | `float` | `float` | - |
| `p4` | `float` | `float` | - |
| `p5` | `float` | `float` | - |
| `p6` | `float` | `float` | - |
| `p7` | `float` | `float` | - |
| `p8` | `float` | `float` | - |
| `p9` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### IGNORE_MENU_PREFERENCE_FOR_BONNET_CAMERA_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x7B8A361C1813FBEF`
- **Build:** `573`

**C# 签名:**
```csharp
void IGNORE_MENU_PREFERENCE_FOR_BONNET_CAMERA_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

---

### INVALIDATE_CINEMATIC_VEHICLE_IDLE_MODE

- **命名空间:** `CAM`
- **Hash:** `0x9E4CFFF989258472`
- **JHash:** `0x65DDE8AF`
- **Build:** `323`

**C# 签名:**
```csharp
void INVALIDATE_CINEMATIC_VEHICLE_IDLE_MODE()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Resets the vehicle idle camera timer. Calling this in a loop will disable the idle camera.
```

---

### INVALIDATE_IDLE_CAM

- **命名空间:** `CAM`
- **Hash:** `0xF4F2C0D4EE209E20`
- **JHash:** `0xD75CDD75`
- **Build:** `323`

**C# 签名:**
```csharp
void INVALIDATE_IDLE_CAM()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Resets the idle camera timer. Calling that in a loop once every few seconds is enough to disable the idle cinematic camera.
```

---

### IS_AIM_CAM_ACTIVE

- **命名空间:** `CAM`
- **Hash:** `0x68EDDA28A5976D07`
- **JHash:** `0xC24B4F6F`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_AIM_CAM_ACTIVE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_AIM_CAM_ACTIVE_IN_ACCURATE_MODE

- **命名空间:** `CAM`
- **Hash:** `0x74BD83EA840F6BC9`
- **JHash:** `0x8F320DE4`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_AIM_CAM_ACTIVE_IN_ACCURATE_MODE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_ALLOWED_INDEPENDENT_CAMERA_MODES

- **命名空间:** `CAM`
- **Hash:** `0xEAF0FA793D05C592`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_ALLOWED_INDEPENDENT_CAMERA_MODES()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_BONNET_CINEMATIC_CAM_RENDERING

- **命名空间:** `CAM`
- **Hash:** `0xD7360051C885628B`
- **JHash:** `0x1DD55F13`
- **Build:** `372`

**C# 签名:**
```csharp
bool IS_BONNET_CINEMATIC_CAM_RENDERING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_CAM_ACTIVE

- **命名空间:** `CAM`
- **Hash:** `0xDFB2B516207D3534`
- **JHash:** `0x4B58F177`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_CAM_ACTIVE(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns whether or not the passed camera handle is active.
```

---

### IS_CAM_INTERPOLATING

- **命名空间:** `CAM`
- **Hash:** `0x036F97C908C2B52C`
- **JHash:** `0x7159CB5D`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_CAM_INTERPOLATING(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_CAM_PLAYING_ANIM

- **命名空间:** `CAM`
- **Hash:** `0xC90621D8A0CEECF2`
- **JHash:** `0xB998CB49`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_CAM_PLAYING_ANIM(int cam, string animName, string animDictionary)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `animName` | `const char*` | `string` | - |
| `animDictionary` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_CAM_RENDERING

- **命名空间:** `CAM`
- **Hash:** `0x02EC0AF5C5A49B7A`
- **JHash:** `0x6EC6B5B2`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_CAM_RENDERING(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_CAM_SHAKING

- **命名空间:** `CAM`
- **Hash:** `0x6B24BFE83A2BE47B`
- **JHash:** `0x0961FD9B`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_CAM_SHAKING(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_CAM_SPLINE_PAUSED

- **命名空间:** `CAM`
- **Hash:** `0x0290F35C0AD97864`
- **JHash:** `0x60B34FF5`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_CAM_SPLINE_PAUSED(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_CINEMATIC_CAM_INPUT_ACTIVE

- **命名空间:** `CAM`
- **Hash:** `0xF5F1E89A970B7796`
- **JHash:** `0x1A900C84`
- **Build:** `1493`

**C# 签名:**
```csharp
bool IS_CINEMATIC_CAM_INPUT_ACTIVE()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Tests some cinematic camera flags
```

---

### IS_CINEMATIC_CAM_RENDERING

- **命名空间:** `CAM`
- **Hash:** `0xB15162CB5826E9E8`
- **JHash:** `0x80471AD9`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_CINEMATIC_CAM_RENDERING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_CINEMATIC_CAM_SHAKING

- **命名空间:** `CAM`
- **Hash:** `0xBBC08F6B4CB8FF0A`
- **JHash:** `0x8376D939`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_CINEMATIC_CAM_SHAKING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_CINEMATIC_FIRST_PERSON_VEHICLE_INTERIOR_CAM_RENDERING

- **命名空间:** `CAM`
- **Hash:** `0x4F32C0D5A90A9B40`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_CINEMATIC_FIRST_PERSON_VEHICLE_INTERIOR_CAM_RENDERING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_CINEMATIC_IDLE_CAM_RENDERING

- **命名空间:** `CAM`
- **Hash:** `0xCA9D2AA3E326D720`
- **JHash:** `0x96A07066`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_CINEMATIC_IDLE_CAM_RENDERING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_CINEMATIC_SHOT_ACTIVE

- **命名空间:** `CAM`
- **Hash:** `0xCC9F3371A7C28BC9`
- **JHash:** `0xA4049042`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_CINEMATIC_SHOT_ACTIVE(uint p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Hash is always JOAAT("CAMERA_MAN_SHOT") in decompiled scripts
```

---

### IS_CODE_GAMEPLAY_HINT_ACTIVE

- **命名空间:** `CAM`
- **Hash:** `0xBF72910D0F26F025`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_CODE_GAMEPLAY_HINT_ACTIVE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_FIRST_PERSON_AIM_CAM_ACTIVE

- **命名空间:** `CAM`
- **Hash:** `0x5E346D934122613F`
- **JHash:** `0xD6280468`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_FIRST_PERSON_AIM_CAM_ACTIVE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_FOLLOW_PED_CAM_ACTIVE

- **命名空间:** `CAM`
- **Hash:** `0xC6D3D26810C8E0F9`
- **JHash:** `0x9F9E856C`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_FOLLOW_PED_CAM_ACTIVE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_FOLLOW_VEHICLE_CAM_ACTIVE

- **命名空间:** `CAM`
- **Hash:** `0xCBBDE6D335D6D496`
- **JHash:** `0x8DD49B77`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_FOLLOW_VEHICLE_CAM_ACTIVE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_GAMEPLAY_CAM_LOOKING_BEHIND

- **命名空间:** `CAM`
- **Hash:** `0x70FDA869F3317EA9`
- **JHash:** `0x33C83F17`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_GAMEPLAY_CAM_LOOKING_BEHIND()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_GAMEPLAY_CAM_RENDERING

- **命名空间:** `CAM`
- **Hash:** `0x39B5D1B10383F0C8`
- **JHash:** `0x0EF276DA`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_GAMEPLAY_CAM_RENDERING()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Examples when this function will return 0 are:
- During busted screen.
- When player is coming out from a hospital.
- When player is coming out from a police station.
- When player is buying gun from AmmuNation.
```

---

### IS_GAMEPLAY_CAM_SHAKING

- **命名空间:** `CAM`
- **Hash:** `0x016C090630DF1F89`
- **JHash:** `0x3457D681`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_GAMEPLAY_CAM_SHAKING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_GAMEPLAY_HINT_ACTIVE

- **命名空间:** `CAM`
- **Hash:** `0xE520FF1AD2785B40`
- **JHash:** `0xAD8DA205`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_GAMEPLAY_HINT_ACTIVE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_INTERPOLATING_FROM_SCRIPT_CAMS

- **命名空间:** `CAM`
- **Hash:** `0x3044240D2E0FA842`
- **JHash:** `0xC0B00C20`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_INTERPOLATING_FROM_SCRIPT_CAMS()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_INTERPOLATING_TO_SCRIPT_CAMS

- **命名空间:** `CAM`
- **Hash:** `0x705A276EBFF3133D`
- **JHash:** `0x60C23785`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_INTERPOLATING_TO_SCRIPT_CAMS()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_IN_VEHICLE_MOBILE_PHONE_CAMERA_RENDERING

- **命名空间:** `CAM`
- **Hash:** `0x1F2300CB7FA7B7F6`
- **JHash:** `0x6739AD55`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_IN_VEHICLE_MOBILE_PHONE_CAMERA_RENDERING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SCREEN_FADED_IN

- **命名空间:** `CAM`
- **Hash:** `0x5A859503B0C08678`
- **JHash:** `0x4F37276D`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SCREEN_FADED_IN()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SCREEN_FADED_OUT

- **命名空间:** `CAM`
- **Hash:** `0xB16FCE9DDC7BA182`
- **JHash:** `0x9CAA05FA`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SCREEN_FADED_OUT()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SCREEN_FADING_IN

- **命名空间:** `CAM`
- **Hash:** `0x5C544BC6C57AC575`
- **JHash:** `0xC7C82800`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SCREEN_FADING_IN()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SCREEN_FADING_OUT

- **命名空间:** `CAM`
- **Hash:** `0x797AC7CB535BA28F`
- **JHash:** `0x79275A57`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SCREEN_FADING_OUT()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SCRIPT_GLOBAL_SHAKING

- **命名空间:** `CAM`
- **Hash:** `0xC912AF078AF19212`
- **JHash:** `0x6AEFE6A5`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SCRIPT_GLOBAL_SHAKING()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
In drunk_controller.c4, sub_309
if (CAM::IS_SCRIPT_GLOBAL_SHAKING()) {
    CAM::STOP_SCRIPT_GLOBAL_SHAKING(0);
}
```

---

### IS_SPHERE_VISIBLE

- **命名空间:** `CAM`
- **Hash:** `0xE33D59DA70B58FDF`
- **JHash:** `0xDD1329E2`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SPHERE_VISIBLE(float x, float y, float z, float radius)
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

### OVERRIDE_CAM_SPLINE_MOTION_BLUR

- **命名空间:** `CAM`
- **Hash:** `0x7DCF7C708D292D55`
- **JHash:** `0x633179E6`
- **Build:** `323`

**C# 签名:**
```csharp
void OVERRIDE_CAM_SPLINE_MOTION_BLUR(int cam, int p1, float p2, float p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Max value for p1 is 15.
```

---

### OVERRIDE_CAM_SPLINE_VELOCITY

- **命名空间:** `CAM`
- **Hash:** `0x40B62FA033EB0346`
- **JHash:** `0x326A17E2`
- **Build:** `323`

**C# 签名:**
```csharp
void OVERRIDE_CAM_SPLINE_VELOCITY(int cam, int p1, float p2, float p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### PLAY_CAM_ANIM

- **命名空间:** `CAM`
- **Hash:** `0x9A2D0FB2E7852392`
- **JHash:** `0xBCEFB87E`
- **Build:** `323`

**C# 签名:**
```csharp
bool PLAY_CAM_ANIM(int cam, string animName, string animDictionary, float x, float y, float z, float xRot, float yRot, float zRot, bool p9, int p10)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `animName` | `const char*` | `string` | - |
| `animDictionary` | `const char*` | `string` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `xRot` | `float` | `float` | - |
| `yRot` | `float` | `float` | - |
| `zRot` | `float` | `float` | - |
| `p9` | `BOOL` | `bool` | - |
| `p10` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Atleast one time in a script for the zRot Rockstar uses GET_ENTITY_HEADING to help fill the parameter.

p9 is unknown at this time.
p10 throughout all the X360 Scripts is always 2.

Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
```

---

### PLAY_SYNCHRONIZED_CAM_ANIM

- **命名空间:** `CAM`
- **Hash:** `0xE32EFE9AB4A9AA0C`
- **JHash:** `0x9458459E`
- **Build:** `323`

**C# 签名:**
```csharp
bool PLAY_SYNCHRONIZED_CAM_ANIM(object p0, object p1, string animName, string animDictionary)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `animName` | `const char*` | `string` | - |
| `animDictionary` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Examples:

CAM::PLAY_SYNCHRONIZED_CAM_ANIM(l_2734, NETWORK::NETWORK_GET_LOCAL_SCENE_FROM_NETWORK_ID(l_2739), "PLAYER_EXIT_L_CAM", "mp_doorbell");

CAM::PLAY_SYNCHRONIZED_CAM_ANIM(l_F0D[7/*1*/], l_F4D[15/*1*/], "ah3b_attackheli_cam2", "missheistfbi3b_helicrash");
```

---

### POINT_CAM_AT_COORD

- **命名空间:** `CAM`
- **Hash:** `0xF75497BB865F0803`
- **JHash:** `0x914BC21A`
- **Build:** `323`

**C# 签名:**
```csharp
void POINT_CAM_AT_COORD(int cam, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### POINT_CAM_AT_ENTITY

- **命名空间:** `CAM`
- **Hash:** `0x5640BFF86B16E8DC`
- **JHash:** `0x7597A0F7`
- **Build:** `323`

**C# 签名:**
```csharp
void POINT_CAM_AT_ENTITY(int cam, int entity, float p2, float p3, float p4, bool p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `entity` | `Entity` | `int` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `float` | `float` | - |
| `p5` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p5 always seems to be 1 i.e TRUE
```

---

### POINT_CAM_AT_PED_BONE

- **命名空间:** `CAM`
- **Hash:** `0x68B2B5F33BA63C41`
- **JHash:** `0x09F47049`
- **Build:** `323`

**C# 签名:**
```csharp
void POINT_CAM_AT_PED_BONE(int cam, int ped, int boneIndex, float x, float y, float z, bool p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `ped` | `Ped` | `int` | - |
| `boneIndex` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p6` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Parameters p0-p5 seems correct. The bool p6 is unknown, but through every X360 script it's always 1. Please correct p0-p5 if any prove to be wrong. 
```

---

### RENDER_SCRIPT_CAMS

- **命名空间:** `CAM`
- **Hash:** `0x07E5B515DB0636FC`
- **JHash:** `0x74337969`
- **Build:** `323`

**C# 签名:**
```csharp
void RENDER_SCRIPT_CAMS(bool render, bool ease, int easeTime, bool p3, bool p4, object p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `render` | `BOOL` | `bool` | - |
| `ease` | `BOOL` | `bool` | - |
| `easeTime` | `int` | `int` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `BOOL` | `bool` | - |
| `p5` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
ease - smooth transition between the camera's positions
easeTime - Time in milliseconds for the transition to happen

If you have created a script (rendering) camera, and want to go back to the 
character (gameplay) camera, call this native with render set to 0.
Setting ease to 1 will smooth the transition.
```

---

### REPLAY_GET_MAX_DISTANCE_ALLOWED_FROM_PLAYER

- **命名空间:** `CAM`
- **Hash:** `0x8BFCEB5EA1B161B6`
- **Build:** `323`

**C# 签名:**
```csharp
float REPLAY_GET_MAX_DISTANCE_ALLOWED_FROM_PLAYER()
```

**返回值:** `float` (Native: `float`)

---

### RESET_GAMEPLAY_CAM_FULL_ATTACH_PARENT_TRANSFORM_TIMER

- **命名空间:** `CAM`
- **Hash:** `0x7295C203DD659DFE`
- **Build:** `2699`

**C# 签名:**
```csharp
void RESET_GAMEPLAY_CAM_FULL_ATTACH_PARENT_TRANSFORM_TIMER()
```

**返回值:** `void` (Native: `void`)

---

### SET_ALLOW_CUSTOM_VEHICLE_DRIVE_BY_CAM_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x4008EDF7D6E48175`
- **JHash:** `0xD1EEBC45`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ALLOW_CUSTOM_VEHICLE_DRIVE_BY_CAM_THIS_UPDATE(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAM_ACTIVE

- **命名空间:** `CAM`
- **Hash:** `0x026FB97D0A425F84`
- **JHash:** `0x064659C2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_ACTIVE(int cam, bool active)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `active` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Set camera as active/inactive.
```

---

### SET_CAM_ACTIVE_WITH_INTERP

- **命名空间:** `CAM`
- **Hash:** `0x9FBDA379383A52A4`
- **JHash:** `0x7983E7F0`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_ACTIVE_WITH_INTERP(int camTo, int camFrom, int duration, int easeLocation, int easeRotation)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `camTo` | `Cam` | `int` | - |
| `camFrom` | `Cam` | `int` | - |
| `duration` | `int` | `int` | - |
| `easeLocation` | `int` | `int` | - |
| `easeRotation` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Previous declaration void SET_CAM_ACTIVE_WITH_INTERP(Cam camTo, Cam camFrom, int duration, BOOL easeLocation, BOOL easeRotation) is completely wrong. The last two params are integers not BOOLs...

```

---

### SET_CAM_AFFECTS_AIMING

- **命名空间:** `CAM`
- **Hash:** `0x8C1DC7770C51DC8D`
- **JHash:** `0x0C74F9AF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_AFFECTS_AIMING(int cam, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Allows you to aim and shoot at the direction the camera is facing.
```

---

### SET_CAM_ANIM_CURRENT_PHASE

- **命名空间:** `CAM`
- **Hash:** `0x4145A4C44FF3B5A6`
- **JHash:** `0x3CB1D17F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_ANIM_CURRENT_PHASE(int cam, float phase)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `phase` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAM_CONTROLS_MINI_MAP_HEADING

- **命名空间:** `CAM`
- **Hash:** `0x661B5C8654ADD825`
- **JHash:** `0xE1A0B2F1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_CONTROLS_MINI_MAP_HEADING(int cam, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Rotates the radar to match the camera's Z rotation
```

---

### SET_CAM_COORD

- **命名空间:** `CAM`
- **Hash:** `0x4D41783FB745E42E`
- **JHash:** `0x7A8053AF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_COORD(int cam, float posX, float posY, float posZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the position of the cam.
```

---

### SET_CAM_DEATH_FAIL_EFFECT_STATE

- **命名空间:** `CAM`
- **Hash:** `0x80C8B1846639BB19`
- **JHash:** `0xB06CCD38`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_DEATH_FAIL_EFFECT_STATE(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
if p0 is 0, effect is cancelled

if p0 is 1, effect zooms in, gradually tilts cam clockwise apx 30 degrees, wobbles slowly. Motion blur is active until cancelled.

if p0 is 2, effect immediately tilts cam clockwise apx 30 degrees, begins to wobble slowly, then gradually tilts cam back to normal. The wobbling will continue until the effect is cancelled.
```

---

### SET_CAM_DEBUG_NAME

- **命名空间:** `CAM`
- **Hash:** `0x1B93E0107865DD40`
- **JHash:** `0x9B00DF3F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_DEBUG_NAME(int camera, string name)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `camera` | `Cam` | `int` | - |
| `name` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
NOTE: Debugging functions are not present in the retail version of the game.
```

---

### SET_CAM_DOF_FNUMBER_OF_LENS

- **命名空间:** `CAM`
- **Hash:** `0x7DD234D6F3914C5B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_DOF_FNUMBER_OF_LENS(int camera, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `camera` | `Cam` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native has its name defined inside its codE

```

---

### SET_CAM_DOF_FOCAL_LENGTH_MULTIPLIER

- **命名空间:** `CAM`
- **Hash:** `0x47B595D60664CFFA`
- **Build:** `1011`

**C# 签名:**
```csharp
void SET_CAM_DOF_FOCAL_LENGTH_MULTIPLIER(int camera, float multiplier)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `camera` | `Cam` | `int` | - |
| `multiplier` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Native name labeled within its code
```

---

### SET_CAM_DOF_FOCUS_DISTANCE_BIAS

- **命名空间:** `CAM`
- **Hash:** `0xC669EEA5D031B7DE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_DOF_FOCUS_DISTANCE_BIAS(int camera, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `camera` | `Cam` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native has a name defined inside its code
```

---

### SET_CAM_DOF_MAX_NEAR_IN_FOCUS_DISTANCE

- **命名空间:** `CAM`
- **Hash:** `0xC3654A441402562D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_DOF_MAX_NEAR_IN_FOCUS_DISTANCE(int camera, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `camera` | `Cam` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native has a name defined inside its code
```

---

### SET_CAM_DOF_MAX_NEAR_IN_FOCUS_DISTANCE_BLEND_LEVEL

- **命名空间:** `CAM`
- **Hash:** `0x2C654B4943BDDF7C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_DOF_MAX_NEAR_IN_FOCUS_DISTANCE_BLEND_LEVEL(int camera, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `camera` | `Cam` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native has a name defined inside its code
```

---

### SET_CAM_DOF_OVERRIDDEN_FOCUS_DISTANCE

- **命名空间:** `CAM`
- **Hash:** `0xF55E4046F6F831DC`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_DOF_OVERRIDDEN_FOCUS_DISTANCE(int camera, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `camera` | `Cam` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAM_DOF_OVERRIDDEN_FOCUS_DISTANCE_BLEND_LEVEL

- **命名空间:** `CAM`
- **Hash:** `0xE111A7C0D200CBC5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_DOF_OVERRIDDEN_FOCUS_DISTANCE_BLEND_LEVEL(object p0, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAM_DOF_PLANES

- **命名空间:** `CAM`
- **Hash:** `0x3CF48F6F96E749DC`
- **JHash:** `0xAD6C2B8F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_DOF_PLANES(int cam, float p1, float p2, float p3, float p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAM_DOF_SHOULD_KEEP_LOOK_AT_TARGET_IN_FOCUS

- **命名空间:** `CAM`
- **Hash:** `0x7CF3AF51DCFE4108`
- **Build:** `2944`

**C# 签名:**
```csharp
void SET_CAM_DOF_SHOULD_KEEP_LOOK_AT_TARGET_IN_FOCUS(int camera, bool state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `camera` | `Cam` | `int` | - |
| `state` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native has a name defined inside its code
```

---

### SET_CAM_DOF_STRENGTH

- **命名空间:** `CAM`
- **Hash:** `0x5EE29B4D7D5DF897`
- **JHash:** `0x3CC4EB3F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_DOF_STRENGTH(int cam, float dofStrength)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `dofStrength` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAM_FAR_CLIP

- **命名空间:** `CAM`
- **Hash:** `0xAE306F2A904BF86E`
- **JHash:** `0x0D23E381`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_FAR_CLIP(int cam, float farClip)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `farClip` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAM_FAR_DOF

- **命名空间:** `CAM`
- **Hash:** `0xEDD91296CD01AEE0`
- **JHash:** `0x58515E8E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_FAR_DOF(int cam, float farDOF)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `farDOF` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAM_FOV

- **命名空间:** `CAM`
- **Hash:** `0xB13C14F66A00D047`
- **JHash:** `0xD3D5D74F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_FOV(int cam, float fieldOfView)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `fieldOfView` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the field of view of the cam.
---------------------------------------------
Min: 1.0f
Max: 130.0f
```

---

### SET_CAM_INHERIT_ROLL_VEHICLE

- **命名空间:** `CAM`
- **Hash:** `0x45F1DE9C34B93AE6`
- **JHash:** `0xE4BD5342`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_INHERIT_ROLL_VEHICLE(int cam, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
The native seems to only be called once.

The native is used as so,
CAM::SET_CAM_INHERIT_ROLL_VEHICLE(l_544, getElem(2, &l_525, 4));
In the exile1 script.
```

---

### SET_CAM_IS_INSIDE_VEHICLE

- **命名空间:** `CAM`
- **Hash:** `0xA2767257A320FC82`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_IS_INSIDE_VEHICLE(int cam, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
When set to true shadows appear more smooth but less detailed.
Set to false by default.
```

---

### SET_CAM_MOTION_BLUR_STRENGTH

- **命名空间:** `CAM`
- **Hash:** `0x6F0F77FBA9A8F2E6`
- **JHash:** `0xFD6E0D67`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_MOTION_BLUR_STRENGTH(int cam, float strength)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `strength` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAM_NEAR_CLIP

- **命名空间:** `CAM`
- **Hash:** `0xC7848EFCCC545182`
- **JHash:** `0x46DB13B1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_NEAR_CLIP(int cam, float nearClip)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `nearClip` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAM_NEAR_DOF

- **命名空间:** `CAM`
- **Hash:** `0x3FA4BF0A7AB7DE2C`
- **JHash:** `0xF28254DF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_NEAR_DOF(int cam, float nearDOF)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `nearDOF` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAM_PARAMS

- **命名空间:** `CAM`
- **Hash:** `0xBFD8727AEA3CCEBA`
- **JHash:** `0x2167CEBF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_PARAMS(int cam, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fieldOfView, object p8, int p9, int p10, int p11)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `rotX` | `float` | `float` | - |
| `rotY` | `float` | `float` | - |
| `rotZ` | `float` | `float` | - |
| `fieldOfView` | `float` | `float` | - |
| `p8` | `Any` | `object` | - |
| `p9` | `int` | `int` | - |
| `p10` | `int` | `int` | - |
| `p11` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAM_ROT

- **命名空间:** `CAM`
- **Hash:** `0x85973643155D0B07`
- **JHash:** `0xEE38B3C1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_ROT(int cam, float rotX, float rotY, float rotZ, int rotationOrder)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `rotX` | `float` | `float` | - |
| `rotY` | `float` | `float` | - |
| `rotZ` | `float` | `float` | - |
| `rotationOrder` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the rotation of the cam.
Last parameter unknown.

Last parameter seems to always be set to 2.
```

---

### SET_CAM_SHAKE_AMPLITUDE

- **命名空间:** `CAM`
- **Hash:** `0xD93DB43B82BC0D00`
- **JHash:** `0x60FF6382`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_SHAKE_AMPLITUDE(int cam, float amplitude)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `amplitude` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAM_SPLINE_DURATION

- **命名空间:** `CAM`
- **Hash:** `0x1381539FEE034CDA`
- **JHash:** `0x3E91FC8A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_SPLINE_DURATION(int cam, int timeDuration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `timeDuration` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
I named p1 as timeDuration as it is obvious. I'm assuming tho it is ran in ms(Milliseconds) as usual.
```

---

### SET_CAM_SPLINE_NODE_EASE

- **命名空间:** `CAM`
- **Hash:** `0x83B8201ED82A9A2D`
- **JHash:** `0x21D275DA`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_SPLINE_NODE_EASE(int cam, int easingFunction, int p2, float p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `easingFunction` | `int` | `int` | - |
| `p2` | `int` | `int` | - |
| `p3` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAM_SPLINE_NODE_EXTRA_FLAGS

- **命名空间:** `CAM`
- **Hash:** `0x7BF1A54AE67AC070`
- **JHash:** `0xC90B2DDC`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_SPLINE_NODE_EXTRA_FLAGS(int cam, int p1, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `p1` | `int` | `int` | - |
| `flags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAM_SPLINE_NODE_VELOCITY_SCALE

- **命名空间:** `CAM`
- **Hash:** `0xA6385DEB180F319F`
- **JHash:** `0xA3BD9E94`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_SPLINE_NODE_VELOCITY_SCALE(int cam, int p1, float scale)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `p1` | `int` | `int` | - |
| `scale` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAM_SPLINE_PHASE

- **命名空间:** `CAM`
- **Hash:** `0x242B5874F0A4E052`
- **JHash:** `0xF0AED233`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_SPLINE_PHASE(int cam, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAM_SPLINE_SMOOTHING_STYLE

- **命名空间:** `CAM`
- **Hash:** `0xD1B0F412F109EA5D`
- **JHash:** `0x15E141CE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_SPLINE_SMOOTHING_STYLE(int cam, int smoothingStyle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `smoothingStyle` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAM_USE_SHALLOW_DOF_MODE

- **命名空间:** `CAM`
- **Hash:** `0x16A96863A17552BB`
- **JHash:** `0x8306C256`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_USE_SHALLOW_DOF_MODE(int cam, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAM_VIEW_MODE_FOR_CONTEXT

- **命名空间:** `CAM`
- **Hash:** `0x2A2173E46DAECD12`
- **JHash:** `0x1DEBCB45`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAM_VIEW_MODE_FOR_CONTEXT(int context, int viewMode)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `context` | `int` | `int` | - |
| `viewMode` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
context: see _GET_CAM_ACTIVE_VIEW_MODE_CONTEXT, viewmode: see CAM.GET_FOLLOW_VEHICLE_CAM_VIEW_MODE
```

---

### SET_CINEMATIC_BUTTON_ACTIVE

- **命名空间:** `CAM`
- **Hash:** `0x51669F7D1FB53D9F`
- **JHash:** `0x3FBC5D00`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CINEMATIC_BUTTON_ACTIVE(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CINEMATIC_CAM_SHAKE_AMPLITUDE

- **命名空间:** `CAM`
- **Hash:** `0xC724C701C30B2FE7`
- **JHash:** `0x67510C4B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CINEMATIC_CAM_SHAKE_AMPLITUDE(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CINEMATIC_MODE_ACTIVE

- **命名空间:** `CAM`
- **Hash:** `0xDCF0754AC3D6FD4E`
- **JHash:** `0x2009E747`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CINEMATIC_MODE_ACTIVE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Toggles the vehicle cinematic cam; requires the player ped to be in a vehicle to work.
```

---

### SET_CINEMATIC_NEWS_CHANNEL_ACTIVE_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0xDC9DA9E8789F5246`
- **JHash:** `0x4938C82F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CINEMATIC_NEWS_CHANNEL_ACTIVE_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

---

### SET_CUTSCENE_CAM_FAR_CLIP_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x12DED8CA53D47EA5`
- **JHash:** `0x067BA6F5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CUTSCENE_CAM_FAR_CLIP_THIS_UPDATE(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Hardcoded to only work in multiplayer.
```

---

### SET_FIRST_PERSON_AIM_CAM_NEAR_CLIP_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x0AF7B437918103B3`
- **JHash:** `0x0E21069D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FIRST_PERSON_AIM_CAM_NEAR_CLIP_THIS_UPDATE(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FIRST_PERSON_AIM_CAM_RELATIVE_HEADING_LIMITS_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x2F7F2B26DD3F18EE`
- **JHash:** `0x2F29F0D5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FIRST_PERSON_AIM_CAM_RELATIVE_HEADING_LIMITS_THIS_UPDATE(float p0, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FIRST_PERSON_AIM_CAM_RELATIVE_PITCH_LIMITS_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0xBCFC632DB7673BF0`
- **JHash:** `0x76DAC96C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FIRST_PERSON_AIM_CAM_RELATIVE_PITCH_LIMITS_THIS_UPDATE(float p0, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR

- **命名空间:** `CAM`
- **Hash:** `0x70894BD0915C5BCA`
- **JHash:** `0x9F4AF763`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR(float zoomFactor)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `zoomFactor` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR_LIMITS_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0xCED08CBE8EBB97C7`
- **JHash:** `0x68BA0730`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR_LIMITS_THIS_UPDATE(float p0, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FIRST_PERSON_FLASH_EFFECT_TYPE

- **命名空间:** `CAM`
- **Hash:** `0x5C41E6BABC9E2112`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FIRST_PERSON_FLASH_EFFECT_TYPE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FIRST_PERSON_FLASH_EFFECT_VEHICLE_MODEL_HASH

- **命名空间:** `CAM`
- **Hash:** `0x11FA5D3479C7DD47`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FIRST_PERSON_FLASH_EFFECT_VEHICLE_MODEL_HASH(uint vehicleModel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicleModel` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FIRST_PERSON_FLASH_EFFECT_VEHICLE_MODEL_NAME

- **命名空间:** `CAM`
- **Hash:** `0x21E253A7F8DA5DFB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FIRST_PERSON_FLASH_EFFECT_VEHICLE_MODEL_NAME(string vehicleName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicleName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
From b617 scripts:

CAM::SET_FIRST_PERSON_FLASH_EFFECT_VEHICLE_MODEL_NAME("DINGHY");
CAM::SET_FIRST_PERSON_FLASH_EFFECT_VEHICLE_MODEL_NAME("ISSI2");
CAM::SET_FIRST_PERSON_FLASH_EFFECT_VEHICLE_MODEL_NAME("SPEEDO");
```

---

### SET_FIRST_PERSON_SHOOTER_CAMERA_HEADING

- **命名空间:** `CAM`
- **Hash:** `0x103991D4A307D472`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FIRST_PERSON_SHOOTER_CAMERA_HEADING(float yaw)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `yaw` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Does nothing
```

---

### SET_FIRST_PERSON_SHOOTER_CAMERA_PITCH

- **命名空间:** `CAM`
- **Hash:** `0x759E13EBC1C15C5A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FIRST_PERSON_SHOOTER_CAMERA_PITCH(float pitch)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `pitch` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FLY_CAM_COORD_AND_CONSTRAIN

- **命名空间:** `CAM`
- **Hash:** `0xC91C6C55199308CA`
- **JHash:** `0x60B345DE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FLY_CAM_COORD_AND_CONSTRAIN(int cam, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FLY_CAM_HORIZONTAL_RESPONSE

- **命名空间:** `CAM`
- **Hash:** `0x503F5920162365B2`
- **JHash:** `0x56F9ED27`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FLY_CAM_HORIZONTAL_RESPONSE(int cam, float p1, float p2, float p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FLY_CAM_MAX_HEIGHT

- **命名空间:** `CAM`
- **Hash:** `0xF9D02130ECDD1D77`
- **JHash:** `0x71570DBA`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FLY_CAM_MAX_HEIGHT(int cam, float height)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `height` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FLY_CAM_VERTICAL_CONTROLS_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0xC8B5C4A79CC18B94`
- **JHash:** `0x44473EFC`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FLY_CAM_VERTICAL_CONTROLS_THIS_UPDATE(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FLY_CAM_VERTICAL_RESPONSE

- **命名空间:** `CAM`
- **Hash:** `0xE827B9382CFB41BA`
- **Build:** `791`

**C# 签名:**
```csharp
void SET_FLY_CAM_VERTICAL_RESPONSE(int cam, float p1, float p2, float p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FOLLOW_CAM_IGNORE_ATTACH_PARENT_MOVEMENT_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0xDD79DF9F4D26E1C9`
- **JHash:** `0x6B0E9D57`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FOLLOW_CAM_IGNORE_ATTACH_PARENT_MOVEMENT_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

---

### SET_FOLLOW_PED_CAM_LADDER_ALIGN_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0xC8391C309684595A`
- **JHash:** `0x1F9DE6E4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FOLLOW_PED_CAM_LADDER_ALIGN_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

---

### SET_FOLLOW_PED_CAM_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x44A113DD6FFC48D1`
- **JHash:** `0x1425F6AC`
- **Build:** `323`

**C# 签名:**
```csharp
bool SET_FOLLOW_PED_CAM_THIS_UPDATE(string camName, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `camName` | `const char*` | `string` | - |
| `p1` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
From the scripts:

CAM::SET_FOLLOW_PED_CAM_THIS_UPDATE("FOLLOW_PED_ATTACHED_TO_ROPE_CAMERA", 0);
CAM::SET_FOLLOW_PED_CAM_THIS_UPDATE("FOLLOW_PED_ON_EXILE1_LADDER_CAMERA", 1500);
CAM::SET_FOLLOW_PED_CAM_THIS_UPDATE("FOLLOW_PED_SKY_DIVING_CAMERA", 0);
CAM::SET_FOLLOW_PED_CAM_THIS_UPDATE("FOLLOW_PED_SKY_DIVING_CAMERA", 3000);
CAM::SET_FOLLOW_PED_CAM_THIS_UPDATE("FOLLOW_PED_SKY_DIVING_FAMILY5_CAMERA", 0);
CAM::SET_FOLLOW_PED_CAM_THIS_UPDATE("FOLLOW_PED_SKY_DIVING_CAMERA", 0);
```

---

### SET_FOLLOW_PED_CAM_VIEW_MODE

- **命名空间:** `CAM`
- **Hash:** `0x5A4F9EDF1673F704`
- **JHash:** `0x495DBE8D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FOLLOW_PED_CAM_VIEW_MODE(int viewMode)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `viewMode` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the type of Player camera:

0 - Third Person Close
1 - Third Person Mid
2 - Third Person Far
4 - First Person
```

---

### SET_FOLLOW_VEHICLE_CAM_HIGH_ANGLE_MODE_EVERY_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x9DFE13ECDC1EC196`
- **JHash:** `0x92302899`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FOLLOW_VEHICLE_CAM_HIGH_ANGLE_MODE_EVERY_UPDATE(bool p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FOLLOW_VEHICLE_CAM_HIGH_ANGLE_MODE_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x91EF6EE6419E5B97`
- **JHash:** `0x9DB5D391`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FOLLOW_VEHICLE_CAM_HIGH_ANGLE_MODE_THIS_UPDATE(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FOLLOW_VEHICLE_CAM_SEAT_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x5C90CAB09951A12F`
- **Build:** `1365`

**C# 签名:**
```csharp
void SET_FOLLOW_VEHICLE_CAM_SEAT_THIS_UPDATE(int seatIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `seatIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FOLLOW_VEHICLE_CAM_VIEW_MODE

- **命名空间:** `CAM`
- **Hash:** `0xAC253D7842768F48`
- **JHash:** `0xC4FBBBD3`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FOLLOW_VEHICLE_CAM_VIEW_MODE(int viewMode)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `viewMode` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the type of Player camera in vehicles:
viewmode: see CAM.GET_FOLLOW_VEHICLE_CAM_VIEW_MODE
```

---

### SET_FOLLOW_VEHICLE_CAM_ZOOM_LEVEL

- **命名空间:** `CAM`
- **Hash:** `0x19464CB6E4078C8A`
- **JHash:** `0x8F55EBBE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FOLLOW_VEHICLE_CAM_ZOOM_LEVEL(int zoomLevel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `zoomLevel` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GAMEPLAY_CAM_ALTITUDE_FOV_SCALING_STATE

- **命名空间:** `CAM`
- **Hash:** `0xDB90C6CCA48940F1`
- **JHash:** `0x20BFF6E5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GAMEPLAY_CAM_ALTITUDE_FOV_SCALING_STATE(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GAMEPLAY_CAM_ENTITY_TO_LIMIT_FOCUS_OVER_BOUNDING_SPHERE_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0xFD3151CD37EA2245`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GAMEPLAY_CAM_ENTITY_TO_LIMIT_FOCUS_OVER_BOUNDING_SPHERE_THIS_UPDATE(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GAMEPLAY_CAM_FOLLOW_PED_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x8BBACBF51DA047A8`
- **JHash:** `0x7D3007A2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GAMEPLAY_CAM_FOLLOW_PED_THIS_UPDATE(int ped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Forces gameplay cam to specified ped as if you were the ped or spectating it
```

---

### SET_GAMEPLAY_CAM_IGNORE_ENTITY_COLLISION_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x2AED6301F67007D5`
- **JHash:** `0x2701A9AD`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GAMEPLAY_CAM_IGNORE_ENTITY_COLLISION_THIS_UPDATE(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GAMEPLAY_CAM_MAX_MOTION_BLUR_STRENGTH_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x0225778816FDC28C`
- **JHash:** `0x1126E37C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GAMEPLAY_CAM_MAX_MOTION_BLUR_STRENGTH_THIS_UPDATE(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
some camera effect that is (also) used in the drunk-cheat, and turned off (by setting it to 0.0) along with the shaking effects once the drunk cheat is disabled.
```

---

### SET_GAMEPLAY_CAM_MOTION_BLUR_SCALING_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x487A82C650EB7799`
- **JHash:** `0xA6E73135`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GAMEPLAY_CAM_MOTION_BLUR_SCALING_THIS_UPDATE(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
some camera effect that is used in the drunk-cheat, and turned off (by setting it to 0.0) along with the shaking effects once the drunk cheat is disabled.
```

---

### SET_GAMEPLAY_CAM_RELATIVE_HEADING

- **命名空间:** `CAM`
- **Hash:** `0xB4EC2312F4E5B1F1`
- **JHash:** `0x20C6217C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GAMEPLAY_CAM_RELATIVE_HEADING(float heading)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `heading` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the camera position relative to heading in float from -360 to +360.

Heading is alwyas 0 in aiming camera.
```

---

### SET_GAMEPLAY_CAM_RELATIVE_PITCH

- **命名空间:** `CAM`
- **Hash:** `0x6D0858B8EDFD2B7D`
- **JHash:** `0x6381B963`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GAMEPLAY_CAM_RELATIVE_PITCH(float angle, float scalingFactor)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `angle` | `float` | `float` | - |
| `scalingFactor` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native sets the camera's pitch (rotation on the x-axis).
```

---

### SET_GAMEPLAY_CAM_SHAKE_AMPLITUDE

- **命名空间:** `CAM`
- **Hash:** `0xA87E00932DB4D85D`
- **JHash:** `0x9219D44A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GAMEPLAY_CAM_SHAKE_AMPLITUDE(float amplitude)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amplitude` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the amplitude for the gameplay (i.e. 3rd or 1st) camera to shake. Used in script "drunk_controller.ysc.c4" to simulate making the player drunk.
```

---

### SET_GAMEPLAY_COORD_HINT

- **命名空间:** `CAM`
- **Hash:** `0xD51ADCD2D8BC0FB3`
- **JHash:** `0xF27483C9`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GAMEPLAY_COORD_HINT(float x, float y, float z, int duration, int blendOutDuration, int blendInDuration, int p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `duration` | `int` | `int` | - |
| `blendOutDuration` | `int` | `int` | - |
| `blendInDuration` | `int` | `int` | - |
| `p6` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GAMEPLAY_ENTITY_HINT

- **命名空间:** `CAM`
- **Hash:** `0x189E955A8313E298`
- **JHash:** `0x66C32306`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GAMEPLAY_ENTITY_HINT(int entity, float xOffset, float yOffset, float zOffset, bool p4, int time, int easeInTime, int easeOutTime, int p8)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `xOffset` | `float` | `float` | - |
| `yOffset` | `float` | `float` | - |
| `zOffset` | `float` | `float` | - |
| `p4` | `BOOL` | `bool` | - |
| `time` | `int` | `int` | - |
| `easeInTime` | `int` | `int` | - |
| `easeOutTime` | `int` | `int` | - |
| `p8` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p8 could be some sort of flag. Scripts use:
-244429742
0
1726668277
1844968929
```

---

### SET_GAMEPLAY_HINT_BASE_ORBIT_PITCH_OFFSET

- **命名空间:** `CAM`
- **Hash:** `0xD1F8363DFAD03848`
- **JHash:** `0x79472AE3`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GAMEPLAY_HINT_BASE_ORBIT_PITCH_OFFSET(float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GAMEPLAY_HINT_CAMERA_BLEND_TO_FOLLOW_PED_MEDIUM_VIEW_MODE

- **命名空间:** `CAM`
- **Hash:** `0xE3433EADAAF7EE40`
- **JHash:** `0x2F0CE859`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GAMEPLAY_HINT_CAMERA_BLEND_TO_FOLLOW_PED_MEDIUM_VIEW_MODE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GAMEPLAY_HINT_CAMERA_RELATIVE_SIDE_OFFSET

- **命名空间:** `CAM`
- **Hash:** `0x5D7B620DAE436138`
- **JHash:** `0xFC7464A0`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GAMEPLAY_HINT_CAMERA_RELATIVE_SIDE_OFFSET(float xOffset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `xOffset` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GAMEPLAY_HINT_CAMERA_RELATIVE_VERTICAL_OFFSET

- **命名空间:** `CAM`
- **Hash:** `0xC92717EF615B6704`
- **JHash:** `0x3554AA0E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GAMEPLAY_HINT_CAMERA_RELATIVE_VERTICAL_OFFSET(float yOffset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `yOffset` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GAMEPLAY_HINT_FOLLOW_DISTANCE_SCALAR

- **命名空间:** `CAM`
- **Hash:** `0xF8BDBF3D573049A1`
- **JHash:** `0x72E8CD3A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GAMEPLAY_HINT_FOLLOW_DISTANCE_SCALAR(float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GAMEPLAY_HINT_FOV

- **命名空间:** `CAM`
- **Hash:** `0x513403FB9C56211F`
- **JHash:** `0x96FD173B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GAMEPLAY_HINT_FOV(float FOV)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `FOV` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GAMEPLAY_OBJECT_HINT

- **命名空间:** `CAM`
- **Hash:** `0x83E87508A2CA2AC6`
- **JHash:** `0x2ED5E2F8`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GAMEPLAY_OBJECT_HINT(int object, float xOffset, float yOffset, float zOffset, bool p4, int time, int easeInTime, int easeOutTime)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `object` | `Object` | `int` | - |
| `xOffset` | `float` | `float` | - |
| `yOffset` | `float` | `float` | - |
| `zOffset` | `float` | `float` | - |
| `p4` | `BOOL` | `bool` | - |
| `time` | `int` | `int` | - |
| `easeInTime` | `int` | `int` | - |
| `easeOutTime` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GAMEPLAY_PED_HINT

- **命名空间:** `CAM`
- **Hash:** `0x2B486269ACD548D3`
- **JHash:** `0x7C27343E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GAMEPLAY_PED_HINT(int ped, float x1, float y1, float z1, bool p4, int duration, int blendOutDuration, int blendInDuration)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `x1` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `p4` | `BOOL` | `bool` | - |
| `duration` | `int` | `int` | - |
| `blendOutDuration` | `int` | `int` | - |
| `blendInDuration` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GAMEPLAY_VEHICLE_HINT

- **命名空间:** `CAM`
- **Hash:** `0xA2297E18F3E71C2E`
- **JHash:** `0x2C9A11D8`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_GAMEPLAY_VEHICLE_HINT(int vehicle, float offsetX, float offsetY, float offsetZ, bool p4, int time, int easeInTime, int easeOutTime)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `offsetX` | `float` | `float` | - |
| `offsetY` | `float` | `float` | - |
| `offsetZ` | `float` | `float` | - |
| `p4` | `BOOL` | `bool` | - |
| `time` | `int` | `int` | - |
| `easeInTime` | `int` | `int` | - |
| `easeOutTime` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Focuses the camera on the specified vehicle.
```

---

### SET_IN_VEHICLE_CAM_STATE_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0xE9EA16D6E54CDCA4`
- **JHash:** `0x4B22C5CB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_IN_VEHICLE_CAM_STATE_THIS_UPDATE(int p0, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Vehicle` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Forces gameplay cam to specified vehicle as if you were in it
```

---

### SET_SCRIPTED_CAMERA_IS_FIRST_PERSON_THIS_FRAME

- **命名空间:** `CAM`
- **Hash:** `0x469F2ECDEC046337`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SCRIPTED_CAMERA_IS_FIRST_PERSON_THIS_FRAME(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TABLE_GAMES_CAMERA_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x79C0E43EB9B944E2`
- **Build:** `1734`

**C# 签名:**
```csharp
bool SET_TABLE_GAMES_CAMERA_THIS_UPDATE(uint hash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `hash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### SET_THIRD_PERSON_AIM_CAM_NEAR_CLIP_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x42156508606DE65E`
- **JHash:** `0x71E9C63E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_THIRD_PERSON_AIM_CAM_NEAR_CLIP_THIS_UPDATE(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_THIRD_PERSON_CAM_ORBIT_DISTANCE_LIMITS_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0xDF2E1F7742402E81`
- **JHash:** `0x77340650`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_THIRD_PERSON_CAM_ORBIT_DISTANCE_LIMITS_THIS_UPDATE(float p0, float distance)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `distance` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Seems to animate the gameplay camera zoom.

Eg. SET_THIRD_PERSON_CAM_ORBIT_DISTANCE_LIMITS_THIS_UPDATE(1f, 1000f);
will animate the camera zooming in from 1000 meters away.

Game scripts use it like this:

// Setting this to 1 prevents V key from changing zoom
PLAYER::SET_PLAYER_FORCED_ZOOM(PLAYER::PLAYER_ID(), 1);

// These restrict how far you can move cam up/down left/right
CAM::SET_THIRD_PERSON_CAM_RELATIVE_HEADING_LIMITS_THIS_UPDATE(-20f, 50f);
CAM::SET_THIRD_PERSON_CAM_RELATIVE_PITCH_LIMITS_THIS_UPDATE(-60f, 0f);

CAM::SET_THIRD_PERSON_CAM_ORBIT_DISTANCE_LIMITS_THIS_UPDATE(1f, 1f);
```

---

### SET_THIRD_PERSON_CAM_RELATIVE_HEADING_LIMITS_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x8F993D26E0CA5E8E`
- **JHash:** `0x749909AC`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_THIRD_PERSON_CAM_RELATIVE_HEADING_LIMITS_THIS_UPDATE(float minimum, float maximum)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `minimum` | `float` | `float` | - |
| `maximum` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
minimum: Degrees between -180f and 180f.
maximum: Degrees between -180f and 180f.

Clamps the gameplay camera's current yaw.

Eg. SET_THIRD_PERSON_CAM_RELATIVE_HEADING_LIMITS_THIS_UPDATE(0.0f, 0.0f) will set the horizontal angle directly behind the player.
```

---

### SET_THIRD_PERSON_CAM_RELATIVE_PITCH_LIMITS_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0xA516C198B7DCA1E1`
- **JHash:** `0xFA3A16E7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_THIRD_PERSON_CAM_RELATIVE_PITCH_LIMITS_THIS_UPDATE(float minimum, float maximum)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `minimum` | `float` | `float` | - |
| `maximum` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
minimum: Degrees between -90f and 90f.
maximum: Degrees between -90f and 90f.

Clamps the gameplay camera's current pitch.

Eg. SET_THIRD_PERSON_CAM_RELATIVE_PITCH_LIMITS_THIS_UPDATE(0.0f, 0.0f) will set the vertical angle directly behind the player.
```

---

### SET_USE_HI_DOF

- **命名空间:** `CAM`
- **Hash:** `0xA13B0222F3D94A94`
- **JHash:** `0x8BBF2950`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_USE_HI_DOF()
```

**返回值:** `void` (Native: `void`)

---

### SET_USE_HI_DOF_ON_SYNCED_SCENE_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x731A880555DA3647`
- **Build:** `2699`

**C# 签名:**
```csharp
void SET_USE_HI_DOF_ON_SYNCED_SCENE_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Only used in R* Script fm_mission_controller_2020
```

---

### SET_WIDESCREEN_BORDERS

- **命名空间:** `CAM`
- **Hash:** `0xDCD4EA924F42D01A`
- **JHash:** `0x1A75DC9A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_WIDESCREEN_BORDERS(bool p0, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SHAKE_CAM

- **命名空间:** `CAM`
- **Hash:** `0x6A25241C340D3822`
- **JHash:** `0x1D4211B0`
- **Build:** `323`

**C# 签名:**
```csharp
void SHAKE_CAM(int cam, string type, float amplitude)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `type` | `const char*` | `string` | - |
| `amplitude` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Possible shake types (updated b617d):

DEATH_FAIL_IN_EFFECT_SHAKE
DRUNK_SHAKE
FAMILY5_DRUG_TRIP_SHAKE
HAND_SHAKE
JOLT_SHAKE
LARGE_EXPLOSION_SHAKE
MEDIUM_EXPLOSION_SHAKE
SMALL_EXPLOSION_SHAKE
ROAD_VIBRATION_SHAKE
SKY_DIVING_SHAKE
VIBRATE_SHAKE

Full list of cam shake types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/camShakeTypesCompact.json
```

---

### SHAKE_CINEMATIC_CAM

- **命名空间:** `CAM`
- **Hash:** `0xDCE214D9ED58F3CF`
- **JHash:** `0x61815F31`
- **Build:** `323`

**C# 签名:**
```csharp
void SHAKE_CINEMATIC_CAM(string shakeType, float amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `shakeType` | `const char*` | `string` | - |
| `amount` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p0 argument found in the b617d scripts: "DRUNK_SHAKE"

Full list of cam shake types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/camShakeTypesCompact.json
```

---

### SHAKE_GAMEPLAY_CAM

- **命名空间:** `CAM`
- **Hash:** `0xFD55E49555E017CF`
- **JHash:** `0xF2EFE660`
- **Build:** `323`

**C# 签名:**
```csharp
void SHAKE_GAMEPLAY_CAM(string shakeName, float intensity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `shakeName` | `const char*` | `string` | - |
| `intensity` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Possible shake types (updated b617d):

DEATH_FAIL_IN_EFFECT_SHAKE
DRUNK_SHAKE
FAMILY5_DRUG_TRIP_SHAKE
HAND_SHAKE
JOLT_SHAKE
LARGE_EXPLOSION_SHAKE
MEDIUM_EXPLOSION_SHAKE
SMALL_EXPLOSION_SHAKE
ROAD_VIBRATION_SHAKE
SKY_DIVING_SHAKE
VIBRATE_SHAKE

Full list of cam shake types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/camShakeTypesCompact.json
```

---

### SHAKE_SCRIPT_GLOBAL

- **命名空间:** `CAM`
- **Hash:** `0xF4C8CF9E353AFECA`
- **JHash:** `0x2B0F05CD`
- **Build:** `323`

**C# 签名:**
```csharp
void SHAKE_SCRIPT_GLOBAL(string p0, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `const char*` | `string` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
CAM::SHAKE_SCRIPT_GLOBAL("HAND_SHAKE", 0.2);

Full list of cam shake types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/camShakeTypesCompact.json
```

---

### STOP_CAM_POINTING

- **命名空间:** `CAM`
- **Hash:** `0xF33AB75780BA57DE`
- **JHash:** `0x5435F6A5`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_CAM_POINTING(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### STOP_CAM_SHAKING

- **命名空间:** `CAM`
- **Hash:** `0xBDECF64367884AC3`
- **JHash:** `0x40D0EB87`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_CAM_SHAKING(int cam, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### STOP_CINEMATIC_CAM_SHAKING

- **命名空间:** `CAM`
- **Hash:** `0x2238E588E588A6D7`
- **JHash:** `0x71C12904`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_CINEMATIC_CAM_SHAKING(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### STOP_CINEMATIC_SHOT

- **命名空间:** `CAM`
- **Hash:** `0x7660C6E75D3A078E`
- **JHash:** `0xD78358C5`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_CINEMATIC_SHOT(uint p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Only used once in carsteal3 with p0 set to -1096069633 (CAMERA_MAN_SHOT)
```

---

### STOP_CODE_GAMEPLAY_HINT

- **命名空间:** `CAM`
- **Hash:** `0x247ACBC4ABBC9D1C`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_CODE_GAMEPLAY_HINT(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### STOP_CUTSCENE_CAM_SHAKING

- **命名空间:** `CAM`
- **Hash:** `0x324C5AA411DA7737`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_CUTSCENE_CAM_SHAKING(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### STOP_GAMEPLAY_CAM_SHAKING

- **命名空间:** `CAM`
- **Hash:** `0x0EF93E9F3D08C178`
- **JHash:** `0xFD569E4E`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_GAMEPLAY_CAM_SHAKING(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### STOP_GAMEPLAY_HINT

- **命名空间:** `CAM`
- **Hash:** `0xF46C581C61718916`
- **JHash:** `0x1BC28B7B`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_GAMEPLAY_HINT(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### STOP_GAMEPLAY_HINT_BEING_CANCELLED_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0xCCD078C2665D2973`
- **JHash:** `0xCAFEE798`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_GAMEPLAY_HINT_BEING_CANCELLED_THIS_UPDATE(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native does absolutely nothing, just a nullsub
```

---

### STOP_RENDERING_SCRIPT_CAMS_USING_CATCH_UP

- **命名空间:** `CAM`
- **Hash:** `0xC819F3CBB62BF692`
- **JHash:** `0xD3C08183`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_RENDERING_SCRIPT_CAMS_USING_CATCH_UP(bool render, float p1, int p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `render` | `BOOL` | `bool` | - |
| `p1` | `float` | `float` | - |
| `p2` | `int` | `int` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native makes the gameplay camera zoom into first person/third person with a special effect.
```

---

### STOP_SCRIPT_GLOBAL_SHAKING

- **命名空间:** `CAM`
- **Hash:** `0x1C9D7949FA533490`
- **JHash:** `0x26FCFB96`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_SCRIPT_GLOBAL_SHAKING(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
In drunk_controller.c4, sub_309
if (CAM::IS_SCRIPT_GLOBAL_SHAKING()) {
    CAM::STOP_SCRIPT_GLOBAL_SHAKING(0);
}
```

---

### TRIGGER_VEHICLE_PART_BROKEN_CAMERA_SHAKE

- **命名空间:** `CAM`
- **Hash:** `0x5D96CFB59DA076A0`
- **Build:** `2060`

**C# 签名:**
```csharp
void TRIGGER_VEHICLE_PART_BROKEN_CAMERA_SHAKE(int vehicle, int p1, float p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1: 0..16
```

---

### USE_DEDICATED_STUNT_CAMERA_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x425A920FDB9A0DDA`
- **Build:** `1180`

**C# 签名:**
```csharp
void USE_DEDICATED_STUNT_CAMERA_THIS_UPDATE(string camName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `camName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets gameplay camera to hash
```

---

### USE_SCRIPT_CAM_FOR_AMBIENT_POPULATION_ORIGIN_THIS_FRAME

- **命名空间:** `CAM`
- **Hash:** `0x271401846BD26E92`
- **JHash:** `0x8DC53629`
- **Build:** `323`

**C# 签名:**
```csharp
void USE_SCRIPT_CAM_FOR_AMBIENT_POPULATION_ORIGIN_THIS_FRAME(bool p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### USE_VEHICLE_CAM_STUNT_SETTINGS_THIS_UPDATE

- **命名空间:** `CAM`
- **Hash:** `0x6493CF69859B116A`
- **Build:** `791`

**C# 签名:**
```csharp
void USE_VEHICLE_CAM_STUNT_SETTINGS_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

---

### WAS_FLY_CAM_CONSTRAINED_ON_PREVIOUS_UDPATE

- **命名空间:** `CAM`
- **Hash:** `0x5C48A1D6E3B33179`
- **JHash:** `0xDA931D65`
- **Build:** `323`

**C# 签名:**
```csharp
bool WAS_FLY_CAM_CONSTRAINED_ON_PREVIOUS_UDPATE(int cam)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cam` | `Cam` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### _ACTIVATE_CAM_WITH_INTERP_AND_FOV_CURVE

- **命名空间:** `CAM`
- **Hash:** `0x34CFC4C2A38E83E3`
- **Build:** `3258`

**C# 签名:**
```csharp
void _ACTIVATE_CAM_WITH_INTERP_AND_FOV_CURVE(int camTo, int camFrom, int duration, int easeLocation, int easeRotation, int easeFov)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `camTo` | `Cam` | `int` | - |
| `camFrom` | `Cam` | `int` | - |
| `duration` | `int` | `int` | - |
| `easeLocation` | `int` | `int` | - |
| `easeRotation` | `int` | `int` | - |
| `easeFov` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### _GET_THIRD_PERSON_CAM_MAX_ORBIT_DISTANCE_SPRING

- **命名空间:** `CAM`
- **Hash:** `0xD4592A16D36673ED`
- **Build:** `3095`

**C# 签名:**
```csharp
float _GET_THIRD_PERSON_CAM_MAX_ORBIT_DISTANCE_SPRING()
```

**返回值:** `float` (Native: `float`)

---

### _GET_THIRD_PERSON_CAM_MIN_ORBIT_DISTANCE_SPRING

- **命名空间:** `CAM`
- **Hash:** `0xBC456FB703431785`
- **Build:** `3095`

**C# 签名:**
```csharp
float _GET_THIRD_PERSON_CAM_MIN_ORBIT_DISTANCE_SPRING()
```

**返回值:** `float` (Native: `float`)

---

### _INTERPOLATE_CAM_WITH_PARAMS

- **命名空间:** `CAM`
- **Hash:** `0xDDA77EE33C005AAF`
- **Build:** `3258`

**C# 签名:**
```csharp
void _INTERPOLATE_CAM_WITH_PARAMS(int camera, float camPosX, float camPosY, float camPosZ, float camRotX, float camRotY, float camRotZ, float fov, int duration, int posCurveType, int rotCurveType, int rotOrder, int fovCurveType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `camera` | `Cam` | `int` | - |
| `camPosX` | `float` | `float` | - |
| `camPosY` | `float` | `float` | - |
| `camPosZ` | `float` | `float` | - |
| `camRotX` | `float` | `float` | - |
| `camRotY` | `float` | `float` | - |
| `camRotZ` | `float` | `float` | - |
| `fov` | `float` | `float` | - |
| `duration` | `int` | `int` | - |
| `posCurveType` | `int` | `int` | - |
| `rotCurveType` | `int` | `int` | - |
| `rotOrder` | `int` | `int` | - |
| `fovCurveType` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---
