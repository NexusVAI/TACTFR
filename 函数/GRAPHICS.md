# GRAPHICS - Native 函数参考

> 命名空间: GRAPHICS, CUTSCENE

---

## 快速索引

| 函数名 | C# 签名 | 返回值 | 说明 |
|--------|---------|--------|------|
| `ABORT_VEHICLE_CREW_EMBLEM_REQUEST` | `bool ABORT_VEHICLE_CREW_EMBLEM_REQUEST(ref int p0)` | bool | - |
| `ADD_DECAL` | `int ADD_DECAL(int decalType, float posX, float posY, float posZ, float p4, float p5, float p6, float p7, float p8, float p9, float width, float height, float rCoef, float gCoef, float bCoef, float opacity, float timeout, bool p17, bool p18, bool p19)` | int | decal types:<br><br>public enum DecalTypes<br>{<br>    splatters_blood = 1010,<br>    splatters_blood_dir = 1015,<br> ... |
| `ADD_ENTITY_ICON` | `int ADD_ENTITY_ICON(int entity, string icon)` | int | Example:<br>GRAPHICS::ADD_ENTITY_ICON(a_0, "MP_Arrow");<br><br>I tried this and nothing happened... |
| `ADD_OIL_DECAL` | `int ADD_OIL_DECAL(float x, float y, float z, float groundLvl, float width, float transparency)` | int | - |
| `ADD_PETROL_DECAL` | `int ADD_PETROL_DECAL(float x, float y, float z, float groundLvl, float width, float transparency)` | int | - |
| `ADD_PETROL_TRAIL_DECAL_INFO` | `void ADD_PETROL_TRAIL_DECAL_INFO(float x, float y, float z, float p3)` | void | - |
| `ADD_TCMODIFIER_OVERRIDE` | `void ADD_TCMODIFIER_OVERRIDE(string modifierName1, string modifierName2)` | void | - |
| `ADD_VEHICLE_CREW_EMBLEM` | `bool ADD_VEHICLE_CREW_EMBLEM(int vehicle, int ped, int boneIndex, float x1, float x2, float x3, float y1, float y2, float y3, float z1, float z2, float z3, float scale, object p13, int alpha)` | bool | boneIndex is always chassis_dummy in the scripts. The x/y/z params are location relative to the chas... |
| `ADJUST_NEXT_POS_SIZE_AS_NORMALIZED_16_9` | `void ADJUST_NEXT_POS_SIZE_AS_NORMALIZED_16_9()` | void | - |
| `ANIMPOSTFX_GET_CURRENT_TIME` | `float ANIMPOSTFX_GET_CURRENT_TIME(string effectName)` | float | See ANIMPOSTFX_PLAY<br><br>Full list of animpostFX / screen effects by DurtyFree: https://github.com/Durty... |
| `ANIMPOSTFX_IS_RUNNING` | `bool ANIMPOSTFX_IS_RUNNING(string effectName)` | bool | Returns whether the specified effect is active.<br>See ANIMPOSTFX_PLAY<br><br>Full list of animpostFX / scree... |
| `ANIMPOSTFX_PLAY` | `void ANIMPOSTFX_PLAY(string effectName, int duration, bool looped)` | void | duration - is how long to play the effect for in milliseconds. If 0, it plays the default length<br>if ... |
| `ANIMPOSTFX_STOP` | `void ANIMPOSTFX_STOP(string effectName)` | void | See ANIMPOSTFX_PLAY<br><br>Full list of animpostFX / screen effects by DurtyFree: https://github.com/Durty... |
| `ANIMPOSTFX_STOP_ALL` | `void ANIMPOSTFX_STOP_ALL()` | void | Stops ALL currently playing effects. |
| `ANIMPOSTFX_STOP_AND_FLUSH_REQUESTS` | `void ANIMPOSTFX_STOP_AND_FLUSH_REQUESTS(string effectName)` | void | Stops the effect and sets a value (bool) in its data (+0x199) to false.<br>See ANIMPOSTFX_PLAY<br><br>Full li... |
| `ATTACH_TV_AUDIO_TO_ENTITY` | `void ATTACH_TV_AUDIO_TO_ENTITY(int entity)` | void | - |
| `BEGIN_CREATE_LOW_QUALITY_COPY_OF_PHOTO` | `bool BEGIN_CREATE_LOW_QUALITY_COPY_OF_PHOTO(object p0)` | bool | - |
| `BEGIN_CREATE_MISSION_CREATOR_PHOTO_PREVIEW` | `bool BEGIN_CREATE_MISSION_CREATOR_PHOTO_PREVIEW()` | bool | - |
| `BEGIN_SCALEFORM_MOVIE_METHOD` | `bool BEGIN_SCALEFORM_MOVIE_METHOD(int scaleform, string methodName)` | bool | Push a function from the Scaleform onto the stack<br> |
| `BEGIN_SCALEFORM_MOVIE_METHOD_ON_FRONTEND` | `bool BEGIN_SCALEFORM_MOVIE_METHOD_ON_FRONTEND(string methodName)` | bool | Starts frontend (pause menu) scaleform movie methods.<br>This can be used when you want to make custom ... |
| `BEGIN_SCALEFORM_MOVIE_METHOD_ON_FRONTEND_HEADER` | `bool BEGIN_SCALEFORM_MOVIE_METHOD_ON_FRONTEND_HEADER(string methodName)` | bool | Starts frontend (pause menu) scaleform movie methods for header options.<br>Use `BEGIN_SCALEFORM_MOVIE_... |
| `BEGIN_SCALEFORM_SCRIPT_HUD_MOVIE_METHOD` | `bool BEGIN_SCALEFORM_SCRIPT_HUD_MOVIE_METHOD(int hudComponent, string methodName)` | bool | Pushes a function from the Hud component Scaleform onto the stack. Same behavior as GRAPHICS::BEGIN_... |
| `BEGIN_TAKE_HIGH_QUALITY_PHOTO` | `bool BEGIN_TAKE_HIGH_QUALITY_PHOTO()` | bool | - |
| `BEGIN_TAKE_MISSION_CREATOR_PHOTO` | `bool BEGIN_TAKE_MISSION_CREATOR_PHOTO()` | bool | - |
| `BEGIN_TEXT_COMMAND_SCALEFORM_STRING` | `void BEGIN_TEXT_COMMAND_SCALEFORM_STRING(string componentType)` | void | Called prior to adding a text component to the UI. After doing so, GRAPHICS::END_TEXT_COMMAND_SCALEF... |
| `CALL_SCALEFORM_MOVIE_METHOD` | `void CALL_SCALEFORM_MOVIE_METHOD(int scaleform, string method)` | void | Calls the Scaleform function. |
| `CALL_SCALEFORM_MOVIE_METHOD_WITH_NUMBER` | `void CALL_SCALEFORM_MOVIE_METHOD_WITH_NUMBER(int scaleform, string methodName, float param1, float param2, float param3, float param4, float param5)` | void | Calls the Scaleform function and passes the parameters as floats.<br><br>The number of parameters passed t... |
| `CALL_SCALEFORM_MOVIE_METHOD_WITH_NUMBER_AND_STRING` | `void CALL_SCALEFORM_MOVIE_METHOD_WITH_NUMBER_AND_STRING(int scaleform, string methodName, float floatParam1, float floatParam2, float floatParam3, float floatParam4, float floatParam5, string stringParam1, string stringParam2, string stringParam3, string stringParam4, string stringParam5)` | void | Calls the Scaleform function and passes both float and string parameters (in their respective order)... |
| `CALL_SCALEFORM_MOVIE_METHOD_WITH_STRING` | `void CALL_SCALEFORM_MOVIE_METHOD_WITH_STRING(int scaleform, string methodName, string param1, string param2, string param3, string param4, string param5)` | void | Calls the Scaleform function and passes the parameters as strings.<br><br>The number of parameters passed ... |
| `CAN_REQUEST_ASSETS_FOR_CUTSCENE_ENTITY` | `bool CAN_REQUEST_ASSETS_FOR_CUTSCENE_ENTITY()` | bool | - |
| `CAN_SET_ENTER_STATE_FOR_REGISTERED_ENTITY` | `bool CAN_SET_ENTER_STATE_FOR_REGISTERED_ENTITY(string cutsceneEntName, uint modelHash)` | bool | modelHash (p1) was always 0 in R* scripts |
| `CAN_SET_EXIT_STATE_FOR_CAMERA` | `bool CAN_SET_EXIT_STATE_FOR_CAMERA(bool p0)` | bool | - |
| `CAN_SET_EXIT_STATE_FOR_REGISTERED_ENTITY` | `bool CAN_SET_EXIT_STATE_FOR_REGISTERED_ENTITY(string cutsceneEntName, uint modelHash)` | bool | - |
| `CAN_USE_MOBILE_PHONE_DURING_CUTSCENE` | `bool CAN_USE_MOBILE_PHONE_DURING_CUTSCENE()` | bool | - |
| `CASCADE_SHADOWS_CLEAR_SHADOW_SAMPLE_TYPE` | `void CASCADE_SHADOWS_CLEAR_SHADOW_SAMPLE_TYPE()` | void | - |
| `CASCADE_SHADOWS_ENABLE_ENTITY_TRACKER` | `void CASCADE_SHADOWS_ENABLE_ENTITY_TRACKER(bool toggle)` | void | When this is set to ON, shadows only draw as you get nearer.<br><br>When OFF, they draw from a further dis... |
| `CASCADE_SHADOWS_ENABLE_FREEZER` | `void CASCADE_SHADOWS_ENABLE_FREEZER(bool p0)` | void | - |
| `CASCADE_SHADOWS_INIT_SESSION` | `void CASCADE_SHADOWS_INIT_SESSION()` | void | - |
| `CASCADE_SHADOWS_SET_AIRCRAFT_MODE` | `void CASCADE_SHADOWS_SET_AIRCRAFT_MODE(bool p0)` | void | - |
| `CASCADE_SHADOWS_SET_BOUND_POSITION` | `void CASCADE_SHADOWS_SET_BOUND_POSITION(object p0)` | void | - |
| `CASCADE_SHADOWS_SET_CASCADE_BOUNDS` | `void CASCADE_SHADOWS_SET_CASCADE_BOUNDS(object p0, bool p1, float p2, float p3, float p4, float p5, bool p6, float p7)` | void | - |
| `CASCADE_SHADOWS_SET_CASCADE_BOUNDS_SCALE` | `void CASCADE_SHADOWS_SET_CASCADE_BOUNDS_SCALE(float p0)` | void | - |
| `CASCADE_SHADOWS_SET_DYNAMIC_DEPTH_MODE` | `void CASCADE_SHADOWS_SET_DYNAMIC_DEPTH_MODE(bool p0)` | void | - |
| `CASCADE_SHADOWS_SET_DYNAMIC_DEPTH_VALUE` | `void CASCADE_SHADOWS_SET_DYNAMIC_DEPTH_VALUE(float p0)` | void | - |
| `CASCADE_SHADOWS_SET_ENTITY_TRACKER_SCALE` | `void CASCADE_SHADOWS_SET_ENTITY_TRACKER_SCALE(float p0)` | void | - |
| `CASCADE_SHADOWS_SET_SCREEN_SIZE_CHECK_ENABLED` | `void CASCADE_SHADOWS_SET_SCREEN_SIZE_CHECK_ENABLED(bool p0)` | void | - |
| `CASCADE_SHADOWS_SET_SHADOW_SAMPLE_TYPE` | `void CASCADE_SHADOWS_SET_SHADOW_SAMPLE_TYPE(string type)` | void | Possible values:<br>"CSM_ST_POINT"<br>"CSM_ST_LINEAR"<br>"CSM_ST_TWOTAP"<br>"CSM_ST_BOX3x3"<br>"CSM_ST_BOX4x4"<br>"CSM... |
| `CASCADE_SHADOWS_SET_SPLIT_Z_EXP_WEIGHT` | `void CASCADE_SHADOWS_SET_SPLIT_Z_EXP_WEIGHT(float p0)` | void | - |
| `CLEAR_ALL_TCMODIFIER_OVERRIDES` | `void CLEAR_ALL_TCMODIFIER_OVERRIDES(string p0)` | void | - |
| `CLEAR_DRAW_ORIGIN` | `void CLEAR_DRAW_ORIGIN()` | void | Resets the screen's draw-origin which was changed by the function GRAPHICS::SET_DRAW_ORIGIN(...) bac... |
| `CLEAR_EXTRA_TCMODIFIER` | `void CLEAR_EXTRA_TCMODIFIER()` | void | Clears the secondary timecycle modifier usually set with _SET_EXTRA_TIMECYCLE_MODIFIER |
| `CLEAR_PARTICLE_FX_SHOOTOUT_BOAT` | `void CLEAR_PARTICLE_FX_SHOOTOUT_BOAT()` | void | - |
| `CLEAR_STATUS_OF_SORTED_LIST_OPERATION` | `void CLEAR_STATUS_OF_SORTED_LIST_OPERATION()` | void | - |
| `CLEAR_TIMECYCLE_MODIFIER` | `void CLEAR_TIMECYCLE_MODIFIER()` | void | - |
| `CLEAR_TV_CHANNEL_PLAYLIST` | `void CLEAR_TV_CHANNEL_PLAYLIST(int tvChannel)` | void | - |
| `CREATE_CHECKPOINT` | `int CREATE_CHECKPOINT(int type, float posX1, float posY1, float posZ1, float posX2, float posY2, float posZ2, float diameter, int red, int green, int blue, int alpha, int reserved)` | int | Creates a checkpoint. Returns the handle of the checkpoint.<br><br>20/03/17 : Attention, checkpoints are a... |
| `CREATE_TRACKED_POINT` | `int CREATE_TRACKED_POINT()` | int | Creates a tracked point, useful for checking the visibility of a 3D point on screen. |
| `DELETE_CHECKPOINT` | `void DELETE_CHECKPOINT(int checkpoint)` | void | - |
| `DESTROY_TRACKED_POINT` | `void DESTROY_TRACKED_POINT(int point)` | void | - |
| `DISABLE_COMPOSITE_SHOTGUN_DECALS` | `void DISABLE_COMPOSITE_SHOTGUN_DECALS(bool toggle)` | void | - |
| `DISABLE_DOWNWASH_PTFX` | `void DISABLE_DOWNWASH_PTFX(bool toggle)` | void | - |
| `DISABLE_HDTEX_THIS_FRAME` | `void DISABLE_HDTEX_THIS_FRAME()` | void | - |
| `DISABLE_IN_WATER_PTFX` | `void DISABLE_IN_WATER_PTFX(bool toggle)` | void | - |
| `DISABLE_MOON_CYCLE_OVERRIDE` | `void DISABLE_MOON_CYCLE_OVERRIDE()` | void | Resets the extra timecycle modifier strength normally set with 0x2C328AF17210F009 |
| `DISABLE_OCCLUSION_THIS_FRAME` | `void DISABLE_OCCLUSION_THIS_FRAME()` | void | - |
| `DISABLE_PROCOBJ_CREATION` | `void DISABLE_PROCOBJ_CREATION()` | void | - |
| `DISABLE_REGION_VFX` | `void DISABLE_REGION_VFX(object p0)` | void | - |
| `DISABLE_SCREENBLUR_FADE` | `void DISABLE_SCREENBLUR_FADE()` | void | - |
| `DISABLE_SCUFF_DECALS` | `void DISABLE_SCUFF_DECALS(bool toggle)` | void | - |
| `DISABLE_VEHICLE_DISTANTLIGHTS` | `void DISABLE_VEHICLE_DISTANTLIGHTS(bool toggle)` | void | - |
| `DOES_CUTSCENE_ENTITY_EXIST` | `bool DOES_CUTSCENE_ENTITY_EXIST(string cutsceneEntName, uint modelHash)` | bool | - |
| `DOES_CUTSCENE_HANDLE_EXIST` | `int DOES_CUTSCENE_HANDLE_EXIST(int cutsceneHandle)` | int | - |
| `DOES_LATEST_BRIEF_STRING_EXIST` | `bool DOES_LATEST_BRIEF_STRING_EXIST(int p0)` | bool | - |
| `DOES_PARTICLE_FX_LOOPED_EXIST` | `bool DOES_PARTICLE_FX_LOOPED_EXIST(int ptfxHandle)` | bool | - |
| `DOES_THIS_PHOTO_SLOT_CONTAIN_A_VALID_PHOTO` | `bool DOES_THIS_PHOTO_SLOT_CONTAIN_A_VALID_PHOTO(object p0)` | bool | This function is hard-coded to always return 0. |
| `DOES_VEHICLE_HAVE_CREW_EMBLEM` | `bool DOES_VEHICLE_HAVE_CREW_EMBLEM(int vehicle, int p1)` | bool | - |
| `DONT_RENDER_IN_GAME_UI` | `void DONT_RENDER_IN_GAME_UI(bool p0)` | void | - |
| `DRAW_BINK_MOVIE` | `void DRAW_BINK_MOVIE(int binkMovie, float p1, float p2, float p3, float p4, float p5, int r, int g, int b, int a)` | void | - |
| `DRAW_BOX` | `void DRAW_BOX(float x1, float y1, float z1, float x2, float y2, float z2, int red, int green, int blue, int alpha)` | void | x,y,z = start pos<br>x2,y2,z2 = end pos<br><br>Draw's a 3D Box between the two x,y,z coords.<br>--------------<br>K... |
| `DRAW_DEBUG_BOX` | `void DRAW_DEBUG_BOX(float x1, float y1, float z1, float x2, float y2, float z2, int r, int g, int b, int alpha)` | void | - |
| `DRAW_DEBUG_CROSS` | `void DRAW_DEBUG_CROSS(float x, float y, float z, float size, int red, int green, int blue, int alpha)` | void | NOTE: Debugging functions are not present in the retail version of the game. |
| `DRAW_DEBUG_LINE` | `void DRAW_DEBUG_LINE(float x1, float y1, float z1, float x2, float y2, float z2, int r, int g, int b, int alpha)` | void | - |
| `DRAW_DEBUG_LINE_WITH_TWO_COLOURS` | `void DRAW_DEBUG_LINE_WITH_TWO_COLOURS(float x1, float y1, float z1, float x2, float y2, float z2, int r1, int g1, int b1, int r2, int g2, int b2, int alpha1, int alpha2)` | void | NOTE: Debugging functions are not present in the retail version of the game. |
| `DRAW_DEBUG_SPHERE` | `void DRAW_DEBUG_SPHERE(float x, float y, float z, float radius, int red, int green, int blue, int alpha)` | void | NOTE: Debugging functions are not present in the retail version of the game. |
| `DRAW_DEBUG_TEXT` | `void DRAW_DEBUG_TEXT(string text, float x, float y, float z, int red, int green, int blue, int alpha)` | void | NOTE: Debugging functions are not present in the retail version of the game. |
| `DRAW_DEBUG_TEXT_2D` | `void DRAW_DEBUG_TEXT_2D(string text, float x, float y, float z, int red, int green, int blue, int alpha)` | void | NOTE: Debugging functions are not present in the retail version of the game. |
| `DRAW_LIGHT_WITH_RANGE` | `void DRAW_LIGHT_WITH_RANGE(float posX, float posY, float posZ, int colorR, int colorG, int colorB, float range, float intensity)` | void | - |
| `DRAW_LIGHT_WITH_RANGEEX` | `void DRAW_LIGHT_WITH_RANGEEX(float x, float y, float z, int r, int g, int b, float range, float intensity, float shadow)` | void | - |
| `DRAW_LINE` | `void DRAW_LINE(float x1, float y1, float z1, float x2, float y2, float z2, int red, int green, int blue, int alpha)` | void | Draws a depth-tested line from one point to another.<br>----------------<br>x1, y1, z1 : Coordinates for t... |
| `DRAW_LOW_QUALITY_PHOTO_TO_PHONE` | `void DRAW_LOW_QUALITY_PHOTO_TO_PHONE(bool p0, bool p1)` | void | - |
| `DRAW_MARKER` | `void DRAW_MARKER(int type, float posX, float posY, float posZ, float dirX, float dirY, float dirZ, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ, int red, int green, int blue, int alpha, bool bobUpAndDown, bool faceCamera, int p19, bool rotate, string textureDict, string textureName, bool drawOnEnts)` | void | enum MarkerTypes<br>{<br>    MarkerTypeUpsideDownCone = 0,<br> MarkerTypeVerticalCylinder = 1,<br>   MarkerTypeT... |
| `DRAW_MARKER_EX` | `void DRAW_MARKER_EX(int type, float posX, float posY, float posZ, float dirX, float dirY, float dirZ, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ, int red, int green, int blue, int alpha, bool bobUpAndDown, bool faceCamera, object p19, bool rotate, string textureDict, string textureName, bool drawOnEnts, bool p24, bool p25)` | void | - |
| `DRAW_MARKER_SPHERE` | `void DRAW_MARKER_SPHERE(float x, float y, float z, float radius, int red, int green, int blue, float alpha)` | void | Draws a 3D sphere, typically seen in the GTA:O freemode event "Penned In".<br>Example https://imgur.com... |
| `DRAW_POLY` | `void DRAW_POLY(float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, int red, int green, int blue, int alpha)` | void | x/y/z - Location of a vertex (in world coords), presumably.<br>----------------<br>x1, y1, z1     : Coordi... |
| `DRAW_RECT` | `void DRAW_RECT(float x, float y, float width, float height, int r, int g, int b, int a, bool p8)` | void | Draws a rectangle on the screen.<br><br>-x: The relative X point of the center of the rectangle. (0.0-1.0,... |
| `DRAW_SCALEFORM_MOVIE` | `void DRAW_SCALEFORM_MOVIE(int scaleformHandle, float x, float y, float width, float height, int red, int green, int blue, int alpha, int p9)` | void | - |
| `DRAW_SCALEFORM_MOVIE_3D` | `void DRAW_SCALEFORM_MOVIE_3D(int scaleform, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float p7, float p8, float p9, float scaleX, float scaleY, float scaleZ, int rotationOrder)` | void | - |
| `DRAW_SCALEFORM_MOVIE_3D_SOLID` | `void DRAW_SCALEFORM_MOVIE_3D_SOLID(int scaleform, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float p7, float p8, float p9, float scaleX, float scaleY, float scaleZ, int rotationOrder)` | void | - |
| `DRAW_SCALEFORM_MOVIE_FULLSCREEN` | `void DRAW_SCALEFORM_MOVIE_FULLSCREEN(int scaleform, int red, int green, int blue, int alpha, int p5)` | void | unk is not used so no need |
| `DRAW_SCALEFORM_MOVIE_FULLSCREEN_MASKED` | `void DRAW_SCALEFORM_MOVIE_FULLSCREEN_MASKED(int scaleform1, int scaleform2, int red, int green, int blue, int alpha)` | void | - |
| `DRAW_SHADOWED_SPOT_LIGHT` | `void DRAW_SHADOWED_SPOT_LIGHT(float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int colorR, int colorG, int colorB, float distance, float brightness, float roundness, float radius, float falloff, int shadowId)` | void | - |
| `DRAW_SPOT_LIGHT` | `void DRAW_SPOT_LIGHT(float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int colorR, int colorG, int colorB, float distance, float brightness, float hardness, float radius, float falloff)` | void | Parameters:<br>* pos - coordinate where the spotlight is located<br>* dir - the direction vector the spotl... |
| `DRAW_SPRITE` | `void DRAW_SPRITE(string textureDict, string textureName, float screenX, float screenY, float width, float height, float heading, int red, int green, int blue, int alpha, bool p11, object p12)` | void | Draws a 2D sprite on the screen.<br><br>Parameters:<br>textureDict - Name of texture dictionary to load textu... |
| `DRAW_SPRITE_ARX` | `void DRAW_SPRITE_ARX(string textureDict, string textureName, float x, float y, float width, float height, float p6, int red, int green, int blue, int alpha, object p11, object p12)` | void | Used in arcade games and Beam hack minigame in Doomsday Heist. I will most certainly dive into this ... |
| `DRAW_SPRITE_ARX_WITH_UV` | `void DRAW_SPRITE_ARX_WITH_UV(string textureDict, string textureName, float x, float y, float width, float height, float u1, float v1, float u2, float v2, float heading, int red, int green, int blue, int alpha, object p15)` | void | Similar to DRAW_SPRITE, but allows to specify the texture coordinates used to draw the sprite.<br><br>u1, ... |
| `DRAW_SPRITE_NAMED_RENDERTARGET` | `void DRAW_SPRITE_NAMED_RENDERTARGET(string textureDict, string textureName, float screenX, float screenY, float width, float height, float heading, int red, int green, int blue, int alpha, object p11)` | void | Similar to _DRAW_SPRITE, but seems to be some kind of "interactive" sprite, at least used by render ... |
| `DRAW_TEXTURED_POLY` | `void DRAW_TEXTURED_POLY(float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, int red, int green, int blue, int alpha, string textureDict, string textureName, float u1, float v1, float w1, float u2, float v2, float w2, float u3, float v3, float w3)` | void | Used for drawling Deadline trailing lights, see deadline.ytd<br><br>p15 through p23 are values that appear... |
| `DRAW_TEXTURED_POLY_WITH_THREE_COLOURS` | `void DRAW_TEXTURED_POLY_WITH_THREE_COLOURS(float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, float red1, float green1, float blue1, int alpha1, float red2, float green2, float blue2, int alpha2, float red3, float green3, float blue3, int alpha3, string textureDict, string textureName, float u1, float v1, float w1, float u2, float v2, float w2, float u3, float v3, float w3)` | void | Used for drawling Deadline trailing lights, see deadline.ytd<br><br>Each vertex has its own colour that is... |
| `DRAW_TV_CHANNEL` | `void DRAW_TV_CHANNEL(float xPos, float yPos, float xScale, float yScale, float rotation, int red, int green, int blue, int alpha)` | void | All calls to this native are preceded by calls to GRAPHICS::SET_SCRIPT_GFX_DRAW_ORDER and GRAPHICS::... |
| `ENABLE_ALIEN_BLOOD_VFX` | `void ENABLE_ALIEN_BLOOD_VFX(bool toggle)` | void | Creates a motion-blur sort of effect, this native does not seem to work, however by using the `START... |
| `ENABLE_CLOWN_BLOOD_VFX` | `void ENABLE_CLOWN_BLOOD_VFX(bool toggle)` | void | Creates cartoon effect when Michel smokes the weed |
| `ENABLE_MOON_CYCLE_OVERRIDE` | `void ENABLE_MOON_CYCLE_OVERRIDE(float strength)` | void | The same as SET_TIMECYCLE_MODIFIER_STRENGTH but for the secondary timecycle modifier. |
| `ENABLE_MOVIE_KEYFRAME_WAIT` | `void ENABLE_MOVIE_KEYFRAME_WAIT(bool toggle)` | void | - |
| `ENABLE_MOVIE_SUBTITLES` | `void ENABLE_MOVIE_SUBTITLES(bool toggle)` | void | - |
| `ENABLE_PROCOBJ_CREATION` | `void ENABLE_PROCOBJ_CREATION()` | void | - |
| `END_PETROL_TRAIL_DECALS` | `void END_PETROL_TRAIL_DECALS()` | void | - |
| `END_SCALEFORM_MOVIE_METHOD` | `void END_SCALEFORM_MOVIE_METHOD()` | void | Pops and calls the Scaleform function on the stack |
| `END_SCALEFORM_MOVIE_METHOD_RETURN_VALUE` | `int END_SCALEFORM_MOVIE_METHOD_RETURN_VALUE()` | int | - |
| `END_TEXT_COMMAND_SCALEFORM_STRING` | `void END_TEXT_COMMAND_SCALEFORM_STRING()` | void | - |
| `END_TEXT_COMMAND_UNPARSED_SCALEFORM_STRING` | `void END_TEXT_COMMAND_UNPARSED_SCALEFORM_STRING()` | void | Same as END_TEXT_COMMAND_SCALEFORM_STRING but does not perform HTML conversion for text tokens. |
| `FADE_DECALS_IN_RANGE` | `void FADE_DECALS_IN_RANGE(float x, float y, float z, float p3, float p4)` | void | Fades nearby decals within the range specified |
| `FADE_UP_PED_LIGHT` | `void FADE_UP_PED_LIGHT(float p0)` | void | - |
| `FORCE_EXPOSURE_READBACK` | `void FORCE_EXPOSURE_READBACK(bool toggle)` | void | - |
| `FORCE_PARTICLE_FX_IN_VEHICLE_INTERIOR` | `void FORCE_PARTICLE_FX_IN_VEHICLE_INTERIOR(object p0, object p1)` | void | - |
| `FORCE_POSTFX_BULLET_IMPACTS_AFTER_HUD` | `void FORCE_POSTFX_BULLET_IMPACTS_AFTER_HUD(bool p0)` | void | - |
| `FORCE_RENDER_IN_GAME_UI` | `void FORCE_RENDER_IN_GAME_UI(bool toggle)` | void | - |
| `FREE_MEMORY_FOR_HIGH_QUALITY_PHOTO` | `void FREE_MEMORY_FOR_HIGH_QUALITY_PHOTO()` | void | - |
| `FREE_MEMORY_FOR_LOW_QUALITY_PHOTO` | `void FREE_MEMORY_FOR_LOW_QUALITY_PHOTO()` | void | - |
| `FREE_MEMORY_FOR_MISSION_CREATOR_PHOTO` | `void FREE_MEMORY_FOR_MISSION_CREATOR_PHOTO()` | void | - |
| `FREE_MEMORY_FOR_MISSION_CREATOR_PHOTO_PREVIEW` | `void FREE_MEMORY_FOR_MISSION_CREATOR_PHOTO_PREVIEW()` | void | - |
| `GET_ACTUAL_SCREEN_RESOLUTION` | `void GET_ACTUAL_SCREEN_RESOLUTION(ref int x, ref int y)` | void | Returns current screen resolution. |
| `GET_ASPECT_RATIO` | `float GET_ASPECT_RATIO(bool b)` | float | - |
| `GET_BINK_MOVIE_TIME` | `float GET_BINK_MOVIE_TIME(int binkMovie)` | float | In percentage: 0.0 - 100.0 |
| `GET_CURRENT_NUMBER_OF_CLOUD_PHOTOS` | `int GET_CURRENT_NUMBER_OF_CLOUD_PHOTOS()` | int | - |
| `GET_CURRENT_TV_CLIP_NAMEHASH` | `uint GET_CURRENT_TV_CLIP_NAMEHASH()` | uint | - |
| `GET_CUTSCENE_CONCAT_SECTION_PLAYING` | `int GET_CUTSCENE_CONCAT_SECTION_PLAYING()` | int | - |
| `GET_CUTSCENE_END_TIME` | `int GET_CUTSCENE_END_TIME()` | int | - |
| `GET_CUTSCENE_PLAY_DURATION` | `int GET_CUTSCENE_PLAY_DURATION()` | int | - |
| `GET_CUTSCENE_PLAY_TIME` | `int GET_CUTSCENE_PLAY_TIME()` | int | - |
| `GET_CUTSCENE_SECTION_PLAYING` | `int GET_CUTSCENE_SECTION_PLAYING()` | int | - |
| `GET_CUTSCENE_TIME` | `int GET_CUTSCENE_TIME()` | int | - |
| `GET_CUTSCENE_TOTAL_DURATION` | `int GET_CUTSCENE_TOTAL_DURATION()` | int | - |
| `GET_CUT_FILE_CONCAT_COUNT` | `int GET_CUT_FILE_CONCAT_COUNT(string cutsceneName)` | int | Full list of cutscene names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/c... |
| `GET_CUT_FILE_OFFSET` | `Vector3 GET_CUT_FILE_OFFSET(string cutsceneName, int index)` | Vector3 | - |
| `GET_DECAL_WASH_LEVEL` | `float GET_DECAL_WASH_LEVEL(int decal)` | float | - |
| `GET_ENTITY_INDEX_OF_CUTSCENE_ENTITY` | `int GET_ENTITY_INDEX_OF_CUTSCENE_ENTITY(string cutsceneEntName, uint modelHash)` | int | - |
| `GET_ENTITY_INDEX_OF_REGISTERED_ENTITY` | `int GET_ENTITY_INDEX_OF_REGISTERED_ENTITY(string cutsceneEntName, uint modelHash)` | int | - |
| `GET_EXTRA_TCMODIFIER` | `int GET_EXTRA_TCMODIFIER()` | int | See GET_TIMECYCLE_MODIFIER_INDEX for use, works the same just for the secondary timecycle modifier.<br>... |
| `GET_IS_HIDEF` | `bool GET_IS_HIDEF()` | bool | false = Any resolution < 1280x720<br>true = Any resolution >= 1280x720 |
| `GET_IS_PETROL_DECAL_IN_RANGE` | `bool GET_IS_PETROL_DECAL_IN_RANGE(float xCoord, float yCoord, float zCoord, float radius)` | bool | - |
| `GET_IS_TIMECYCLE_TRANSITIONING_OUT` | `bool GET_IS_TIMECYCLE_TRANSITIONING_OUT()` | bool | - |
| `GET_IS_WIDESCREEN` | `bool GET_IS_WIDESCREEN()` | bool | Setting Aspect Ratio Manually in game will return:<br><br>false - for Narrow format Aspect Ratios (3:2, 4:... |
| `GET_LIGHT_OVERRIDE_MAX_INTENSITY_SCALE` | `float GET_LIGHT_OVERRIDE_MAX_INTENSITY_SCALE()` | float | - |
| `GET_LOAD_HIGH_QUALITY_PHOTO_STATUS` | `int GET_LOAD_HIGH_QUALITY_PHOTO_STATUS(int p0)` | int | Hardcoded to always return 2. |
| `GET_MAXIMUM_NUMBER_OF_CLOUD_PHOTOS` | `int GET_MAXIMUM_NUMBER_OF_CLOUD_PHOTOS()` | int | This function is hard-coded to always return 96. |
| `GET_MAXIMUM_NUMBER_OF_PHOTOS` | `int GET_MAXIMUM_NUMBER_OF_PHOTOS()` | int | This function is hard-coded to always return 0. |
| `GET_MOTIONBLUR_MAX_VEL_SCALER` | `float GET_MOTIONBLUR_MAX_VEL_SCALER()` | float | Getter for SET_MOTIONBLUR_MAX_VEL_SCALER |
| `GET_REQUESTINGNIGHTVISION` | `bool GET_REQUESTINGNIGHTVISION()` | bool | - |
| `GET_SAFE_ZONE_SIZE` | `float GET_SAFE_ZONE_SIZE()` | float | Gets the scale of safe zone. if the safe zone size scale is max, it will return 1.0. |
| `GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_BOOL` | `bool GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_BOOL(int methodReturn)` | bool | methodReturn: The return value of this native: END_SCALEFORM_MOVIE_METHOD_RETURN_VALUE |
| `GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_INT` | `int GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_INT(int methodReturn)` | int | methodReturn: The return value of this native: END_SCALEFORM_MOVIE_METHOD_RETURN_VALUE<br>Used to get a... |
| `GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_STRING` | `string GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_STRING(int methodReturn)` | string | methodReturn: The return value of this native: END_SCALEFORM_MOVIE_METHOD_RETURN_VALUE<br>Used to get a... |
| `GET_SCREENBLUR_FADE_CURRENT_TIME` | `float GET_SCREENBLUR_FADE_CURRENT_TIME()` | float | - |
| `GET_SCREEN_ASPECT_RATIO` | `float GET_SCREEN_ASPECT_RATIO()` | float | - |
| `GET_SCREEN_COORD_FROM_WORLD_COORD` | `bool GET_SCREEN_COORD_FROM_WORLD_COORD(float worldX, float worldY, float worldZ, ref float screenX, ref float screenY)` | bool | Convert a world coordinate into its relative screen coordinate.  (WorldToScreen)<br><br>Returns a boolean;... |
| `GET_SCREEN_RESOLUTION` | `void GET_SCREEN_RESOLUTION(ref int x, ref int y)` | void | int screenresx,screenresy;<br>GET_SCREEN_RESOLUTION(&screenresx,&screenresy); |
| `GET_SCRIPT_GFX_ALIGN_POSITION` | `void GET_SCRIPT_GFX_ALIGN_POSITION(float x, float y, ref float calculatedX, ref float calculatedY)` | void | Calculates the effective X/Y fractions when applying the values set by SET_SCRIPT_GFX_ALIGN and SET_... |
| `GET_STATUS_OF_CREATE_LOW_QUALITY_COPY_OF_PHOTO` | `int GET_STATUS_OF_CREATE_LOW_QUALITY_COPY_OF_PHOTO(int p0)` | int | - |
| `GET_STATUS_OF_CREATE_MISSION_CREATOR_PHOTO_PREVIEW` | `int GET_STATUS_OF_CREATE_MISSION_CREATOR_PHOTO_PREVIEW()` | int | - |
| `GET_STATUS_OF_LOAD_MISSION_CREATOR_PHOTO` | `int GET_STATUS_OF_LOAD_MISSION_CREATOR_PHOTO(ref object p0)` | int | - |
| `GET_STATUS_OF_SAVE_HIGH_QUALITY_PHOTO` | `int GET_STATUS_OF_SAVE_HIGH_QUALITY_PHOTO()` | int | - |
| `GET_STATUS_OF_SORTED_LIST_OPERATION` | `int GET_STATUS_OF_SORTED_LIST_OPERATION(object p0)` | int | 3 matches across 3 scripts. First 2 were 0, 3rd was 1. Possibly a bool.<br>appcamera, appmedia, and cel... |
| `GET_STATUS_OF_TAKE_HIGH_QUALITY_PHOTO` | `int GET_STATUS_OF_TAKE_HIGH_QUALITY_PHOTO()` | int | - |
| `GET_STATUS_OF_TAKE_MISSION_CREATOR_PHOTO` | `int GET_STATUS_OF_TAKE_MISSION_CREATOR_PHOTO()` | int | - |
| `GET_TEXTURE_RESOLUTION` | `Vector3 GET_TEXTURE_RESOLUTION(string textureDict, string textureName)` | Vector3 | Returns the texture resolution of the passed texture dict+name.<br><br>Note: Most texture resolutions are ... |
| `GET_TIMECYCLE_MODIFIER_INDEX` | `int GET_TIMECYCLE_MODIFIER_INDEX()` | int | Only use for this in the PC scripts is:<br><br>if (GRAPHICS::GET_TIMECYCLE_MODIFIER_INDEX() != -1) |
| `GET_TIMECYCLE_TRANSITION_MODIFIER_INDEX` | `int GET_TIMECYCLE_TRANSITION_MODIFIER_INDEX()` | int | - |
| `GET_TOGGLE_PAUSED_RENDERPHASES_STATUS` | `bool GET_TOGGLE_PAUSED_RENDERPHASES_STATUS()` | bool | - |
| `GET_TV_CHANNEL` | `int GET_TV_CHANNEL()` | int | - |
| `GET_TV_VOLUME` | `float GET_TV_VOLUME()` | float | - |
| `GET_USINGNIGHTVISION` | `bool GET_USINGNIGHTVISION()` | bool | - |
| `GET_USINGSEETHROUGH` | `bool GET_USINGSEETHROUGH()` | bool | - |
| `GET_VEHICLE_CREW_EMBLEM_REQUEST_STATE` | `int GET_VEHICLE_CREW_EMBLEM_REQUEST_STATE(int vehicle, int p1)` | int | - |
| `GOLF_TRAIL_GET_MAX_HEIGHT` | `float GOLF_TRAIL_GET_MAX_HEIGHT()` | float | - |
| `GOLF_TRAIL_GET_VISUAL_CONTROL_POINT` | `Vector3 GOLF_TRAIL_GET_VISUAL_CONTROL_POINT(int p0)` | Vector3 | - |
| `GOLF_TRAIL_SET_COLOUR` | `void GOLF_TRAIL_SET_COLOUR(int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11)` | void | - |
| `GOLF_TRAIL_SET_ENABLED` | `void GOLF_TRAIL_SET_ENABLED(bool toggle)` | void | - |
| `GOLF_TRAIL_SET_FACING` | `void GOLF_TRAIL_SET_FACING(bool p0)` | void | - |
| `GOLF_TRAIL_SET_FIXED_CONTROL_POINT` | `void GOLF_TRAIL_SET_FIXED_CONTROL_POINT(int type, float xPos, float yPos, float zPos, float p4, int red, int green, int blue, int alpha)` | void | 12 matches across 4 scripts. All 4 scripts were job creators.<br><br>type ranged from 0 - 2.<br>p4 was always... |
| `GOLF_TRAIL_SET_FIXED_CONTROL_POINT_ENABLE` | `void GOLF_TRAIL_SET_FIXED_CONTROL_POINT_ENABLE(bool p0)` | void | - |
| `GOLF_TRAIL_SET_PATH` | `void GOLF_TRAIL_SET_PATH(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, bool p8)` | void | p8 seems to always be false. |
| `GOLF_TRAIL_SET_RADIUS` | `void GOLF_TRAIL_SET_RADIUS(float p0, float p1, float p2)` | void | - |
| `GOLF_TRAIL_SET_SHADER_PARAMS` | `void GOLF_TRAIL_SET_SHADER_PARAMS(float p0, float p1, float p2, float p3, float p4)` | void | Only appeared in Golf & Golf_mp. Parameters were all ptrs |
| `GOLF_TRAIL_SET_TESSELLATION` | `void GOLF_TRAIL_SET_TESSELLATION(int p0, int p1)` | void | - |
| `GRAB_PAUSEMENU_OWNERSHIP` | `void GRAB_PAUSEMENU_OWNERSHIP()` | void | - |
| `GRASSBATCH_DISABLE_FLATTENING` | `void GRASSBATCH_DISABLE_FLATTENING()` | void | - |
| `GRASSBATCH_ENABLE_FLATTENING_EXT_IN_SPHERE` | `void GRASSBATCH_ENABLE_FLATTENING_EXT_IN_SPHERE(float x, float y, float z, object p3, float p4, float p5, float p6, float scale)` | void | - |
| `GRASSBATCH_ENABLE_FLATTENING_IN_SPHERE` | `void GRASSBATCH_ENABLE_FLATTENING_IN_SPHERE(float x, float y, float z, float radius, float p4, float p5, float p6)` | void | Wraps 0xAAE9BE70EC7C69AB with FLT_MAX as p7 |
| `HAS_CUTSCENE_CUT_THIS_FRAME` | `bool HAS_CUTSCENE_CUT_THIS_FRAME()` | bool | Possibly HAS_CUTSCENE_CUT_THIS_FRAME, needs more research. |
| `HAS_CUTSCENE_FINISHED` | `bool HAS_CUTSCENE_FINISHED()` | bool | - |
| `HAS_CUTSCENE_LOADED` | `bool HAS_CUTSCENE_LOADED()` | bool | - |
| `HAS_CUT_FILE_LOADED` | `bool HAS_CUT_FILE_LOADED(string cutsceneName)` | bool | Simply checks if the cutscene has loaded and doesn't check via CutSceneManager as opposed to HAS_[TH... |
| `HAS_SCALEFORM_CONTAINER_MOVIE_LOADED_INTO_PARENT` | `bool HAS_SCALEFORM_CONTAINER_MOVIE_LOADED_INTO_PARENT(int scaleformHandle)` | bool | - |
| `HAS_SCALEFORM_MOVIE_FILENAME_LOADED` | `bool HAS_SCALEFORM_MOVIE_FILENAME_LOADED(string scaleformName)` | bool | Only values used in the scripts are:<br><br>"heist_mp"<br>"heistmap_mp"<br>"instructional_buttons"<br>"heist_pre" |
| `HAS_SCALEFORM_MOVIE_LOADED` | `bool HAS_SCALEFORM_MOVIE_LOADED(int scaleformHandle)` | bool | - |
| `HAS_SCALEFORM_SCRIPT_HUD_MOVIE_LOADED` | `bool HAS_SCALEFORM_SCRIPT_HUD_MOVIE_LOADED(int hudComponent)` | bool | - |
| `HAS_STREAMED_TEXTURE_DICT_LOADED` | `bool HAS_STREAMED_TEXTURE_DICT_LOADED(string textureDict)` | bool | - |
| `HAS_THIS_CUTSCENE_LOADED` | `bool HAS_THIS_CUTSCENE_LOADED(string cutsceneName)` | bool | Full list of cutscene names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/c... |
| `IS_ACTIVE_SCALEFORM_MOVIE_DELETING` | `bool IS_ACTIVE_SCALEFORM_MOVIE_DELETING(int val)` | bool | val is 1-20 (0 will return false) |
| `IS_CUTSCENE_ACTIVE` | `bool IS_CUTSCENE_ACTIVE()` | bool | - |
| `IS_CUTSCENE_AUTHORIZED` | `bool IS_CUTSCENE_AUTHORIZED(string cutsceneName)` | bool | This function is hard-coded to always return 1. |
| `IS_CUTSCENE_PLAYBACK_FLAG_SET` | `bool IS_CUTSCENE_PLAYBACK_FLAG_SET(int flag)` | bool | - |
| `IS_CUTSCENE_PLAYING` | `bool IS_CUTSCENE_PLAYING()` | bool | - |
| `IS_DECAL_ALIVE` | `bool IS_DECAL_ALIVE(int decal)` | bool | - |
| `IS_MULTIHEAD_FADE_UP` | `bool IS_MULTIHEAD_FADE_UP()` | bool | - |
| `IS_PLAYLIST_ON_CHANNEL` | `bool IS_PLAYLIST_ON_CHANNEL(int tvChannel, object p1)` | bool | - |
| `IS_SCALEFORM_MOVIE_DELETING` | `bool IS_SCALEFORM_MOVIE_DELETING(int val)` | bool | val is 1-20. Return is related to INSTRUCTIONAL_BUTTONS, COLOUR_SWITCHER_02, etc? |
| `IS_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_READY` | `bool IS_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_READY(int methodReturn)` | bool | methodReturn: The return value of this native: END_SCALEFORM_MOVIE_METHOD_RETURN_VALUE<br>Returns true ... |
| `IS_SCREENBLUR_FADE_RUNNING` | `bool IS_SCREENBLUR_FADE_RUNNING()` | bool | Returns whether screen transition to blur/from blur is running. |
| `IS_TRACKED_POINT_VISIBLE` | `bool IS_TRACKED_POINT_VISIBLE(int point)` | bool | - |
| `IS_TVSHOW_CURRENTLY_PLAYING` | `bool IS_TVSHOW_CURRENTLY_PLAYING(uint videoCliphash)` | bool | - |
| `LOAD_HIGH_QUALITY_PHOTO` | `bool LOAD_HIGH_QUALITY_PHOTO(object p0)` | bool | This function is hard-coded to always return 0. |
| `LOAD_MISSION_CREATOR_PHOTO` | `bool LOAD_MISSION_CREATOR_PHOTO(ref object p0, object p1, object p2, object p3)` | bool | - |
| `LOAD_MOVIE_MESH_SET` | `int LOAD_MOVIE_MESH_SET(string movieMeshSetName)` | int | - |
| `MOVE_VEHICLE_DECALS` | `void MOVE_VEHICLE_DECALS(object p0, object p1)` | void | - |
| `NETWORK_SET_MOCAP_CUTSCENE_CAN_BE_SKIPPED` | `void NETWORK_SET_MOCAP_CUTSCENE_CAN_BE_SKIPPED(bool toggle)` | void | - |
| `OVERRIDE_INTERIOR_SMOKE_END` | `void OVERRIDE_INTERIOR_SMOKE_END()` | void | - |
| `OVERRIDE_INTERIOR_SMOKE_LEVEL` | `void OVERRIDE_INTERIOR_SMOKE_LEVEL(float level)` | void | - |
| `OVERRIDE_INTERIOR_SMOKE_NAME` | `void OVERRIDE_INTERIOR_SMOKE_NAME(string name)` | void | - |
| `OVERRIDE_NIGHTVISION_LIGHT_RANGE` | `void OVERRIDE_NIGHTVISION_LIGHT_RANGE(float p0)` | void | - |
| `OVERRIDE_PED_CREW_LOGO_TEXTURE` | `bool OVERRIDE_PED_CREW_LOGO_TEXTURE(int ped, string txd, string txn)` | bool | Overriding ped badge texture to a passed texture. It's synced between players (even custom textures!... |
| `PASS_KEYBOARD_INPUT_TO_SCALEFORM` | `bool PASS_KEYBOARD_INPUT_TO_SCALEFORM(int scaleformHandle)` | bool | - |
| `PATCH_DECAL_DIFFUSE_MAP` | `void PATCH_DECAL_DIFFUSE_MAP(int decalType, string textureDict, string textureName)` | void | - |
| `PHONEPHOTOEDITOR_IS_ACTIVE` | `bool PHONEPHOTOEDITOR_IS_ACTIVE()` | bool | - |
| `PHONEPHOTOEDITOR_SET_FRAME_TXD` | `bool PHONEPHOTOEDITOR_SET_FRAME_TXD(string textureDict, bool p1)` | bool | - |
| `PHONEPHOTOEDITOR_TOGGLE` | `bool PHONEPHOTOEDITOR_TOGGLE(bool p0)` | bool | - |
| `PLAY_BINK_MOVIE` | `void PLAY_BINK_MOVIE(int binkMovie)` | void | - |
| `POP_TIMECYCLE_MODIFIER` | `void POP_TIMECYCLE_MODIFIER()` | void | - |
| `PRESET_INTERIOR_AMBIENT_CACHE` | `void PRESET_INTERIOR_AMBIENT_CACHE(string timecycleModifierName)` | void | Only one match in the scripts:<br><br>GRAPHICS::PRESET_INTERIOR_AMBIENT_CACHE("int_carrier_hanger"); |
| `PROCGRASS_DISABLE_AMBSCALESCAN` | `void PROCGRASS_DISABLE_AMBSCALESCAN()` | void | - |
| `PROCGRASS_DISABLE_CULLSPHERE` | `void PROCGRASS_DISABLE_CULLSPHERE(int handle)` | void | - |
| `PROCGRASS_ENABLE_AMBSCALESCAN` | `void PROCGRASS_ENABLE_AMBSCALESCAN()` | void | - |
| `PROCGRASS_ENABLE_CULLSPHERE` | `void PROCGRASS_ENABLE_CULLSPHERE(int handle, float x, float y, float z, float scale)` | void | - |
| `PROCGRASS_IS_CULLSPHERE_ENABLED` | `bool PROCGRASS_IS_CULLSPHERE_ENABLED(int handle)` | bool | - |
| `PUSH_TIMECYCLE_MODIFIER` | `void PUSH_TIMECYCLE_MODIFIER()` | void | - |
| `QUERY_MOVIE_MESH_SET_STATE` | `int QUERY_MOVIE_MESH_SET_STATE(object p0)` | int | - |
| `QUEUE_OPERATION_TO_CREATE_SORTED_LIST_OF_PHOTOS` | `bool QUEUE_OPERATION_TO_CREATE_SORTED_LIST_OF_PHOTOS(object p0)` | bool | 2 matches across 2 scripts. Only showed in appcamera & appmedia. Both were 0. |
| `REGISTER_ENTITY_FOR_CUTSCENE` | `void REGISTER_ENTITY_FOR_CUTSCENE(int cutscenePed, string cutsceneEntName, int p2, uint modelHash, int p4)` | void | - |
| `REGISTER_NOIR_LENS_EFFECT` | `void REGISTER_NOIR_LENS_EFFECT()` | void | Used with 'NG_filmnoir_BW{01,02}' timecycles and the "NOIR_FILTER_SOUNDS" audioref. |
| `REGISTER_POSTFX_BULLET_IMPACT` | `void REGISTER_POSTFX_BULLET_IMPACT(float weaponWorldPosX, float weaponWorldPosY, float weaponWorldPosZ, float intensity)` | void | - |
| `RELEASE_BINK_MOVIE` | `void RELEASE_BINK_MOVIE(int binkMovie)` | void | - |
| `RELEASE_MOVIE_MESH_SET` | `void RELEASE_MOVIE_MESH_SET(int movieMeshSet)` | void | - |
| `REMOVE_CUTSCENE` | `void REMOVE_CUTSCENE()` | void | - |
| `REMOVE_CUT_FILE` | `void REMOVE_CUT_FILE(string cutsceneName)` | void | Simply unloads the cutscene and doesn't do extra stuff that REMOVE_CUTSCENE does.<br>Full list of cutsc... |
| `REMOVE_DECAL` | `void REMOVE_DECAL(int decal)` | void | - |
| `REMOVE_DECALS_FROM_OBJECT` | `void REMOVE_DECALS_FROM_OBJECT(int obj)` | void | - |
| `REMOVE_DECALS_FROM_OBJECT_FACING` | `void REMOVE_DECALS_FROM_OBJECT_FACING(int obj, float x, float y, float z)` | void | - |
| `REMOVE_DECALS_FROM_VEHICLE` | `void REMOVE_DECALS_FROM_VEHICLE(int vehicle)` | void | - |
| `REMOVE_DECALS_IN_RANGE` | `void REMOVE_DECALS_IN_RANGE(float x, float y, float z, float range)` | void | Removes all decals in range from a position, it includes the bullet holes, blood pools, petrol... |
| `REMOVE_GRASS_CULL_SPHERE` | `void REMOVE_GRASS_CULL_SPHERE(int handle)` | void | This native does absolutely nothing, just a nullsub |
| `REMOVE_PARTICLE_FX` | `void REMOVE_PARTICLE_FX(int ptfxHandle, bool p1)` | void | - |
| `REMOVE_PARTICLE_FX_FROM_ENTITY` | `void REMOVE_PARTICLE_FX_FROM_ENTITY(int entity)` | void | - |
| `REMOVE_PARTICLE_FX_IN_RANGE` | `void REMOVE_PARTICLE_FX_IN_RANGE(float X, float Y, float Z, float radius)` | void | - |
| `REMOVE_SCALEFORM_SCRIPT_HUD_MOVIE` | `void REMOVE_SCALEFORM_SCRIPT_HUD_MOVIE(int hudComponent)` | void | - |
| `REMOVE_VEHICLE_CREW_EMBLEM` | `void REMOVE_VEHICLE_CREW_EMBLEM(int vehicle, int p1)` | void | - |
| `RENDER_SHADOWED_LIGHTS_WITH_NO_SHADOWS` | `void RENDER_SHADOWED_LIGHTS_WITH_NO_SHADOWS(bool p0)` | void | - |
| `REQUEST_CUTSCENE` | `void REQUEST_CUTSCENE(string cutsceneName, int flags)` | void | flags: Usually 8<br>Full list of cutscene names by DurtyFree https://github.com/DurtyFree/gta-v-data-du... |
| `REQUEST_CUTSCENE_WITH_PLAYBACK_LIST` | `void REQUEST_CUTSCENE_WITH_PLAYBACK_LIST(string cutsceneName, int playbackFlags, int flags)` | void | flags: Usually 8<br><br>playbackFlags: Which scenes should be played.<br>Example: 0x105 (bit 0, 2 and 8 set) ... |
| `REQUEST_CUT_FILE` | `void REQUEST_CUT_FILE(string cutsceneName)` | void | Simply loads the cutscene and doesn't do extra stuff that REQUEST_CUTSCENE does.<br>Full list of cutsce... |
| `REQUEST_EARLY_LIGHT_CHECK` | `void REQUEST_EARLY_LIGHT_CHECK()` | void | - |
| `REQUEST_SCALEFORM_MOVIE` | `int REQUEST_SCALEFORM_MOVIE(string scaleformName)` | int | - |
| `REQUEST_SCALEFORM_MOVIE_INSTANCE` | `int REQUEST_SCALEFORM_MOVIE_INSTANCE(string scaleformName)` | int | - |
| `REQUEST_SCALEFORM_MOVIE_SKIP_RENDER_WHILE_PAUSED` | `int REQUEST_SCALEFORM_MOVIE_SKIP_RENDER_WHILE_PAUSED(string scaleformName)` | int | Similar to REQUEST_SCALEFORM_MOVIE, but seems to be some kind of "interactive" scaleform movie?<br><br>The... |
| `REQUEST_SCALEFORM_MOVIE_WITH_IGNORE_SUPER_WIDESCREEN` | `int REQUEST_SCALEFORM_MOVIE_WITH_IGNORE_SUPER_WIDESCREEN(string scaleformName)` | int | Another REQUEST_SCALEFORM_MOVIE equivalent. |
| `REQUEST_SCALEFORM_SCRIPT_HUD_MOVIE` | `void REQUEST_SCALEFORM_SCRIPT_HUD_MOVIE(int hudComponent)` | void | - |
| `REQUEST_STREAMED_TEXTURE_DICT` | `void REQUEST_STREAMED_TEXTURE_DICT(string textureDict, bool p1)` | void | This function can requests texture dictonaries from following RPFs:<br>scaleform_generic.rpf<br>scaleform_... |
| `RESET_ADAPTATION` | `void RESET_ADAPTATION(int p0)` | void | Sets an value related to timecycles. |
| `RESET_PARTICLE_FX_OVERRIDE` | `void RESET_PARTICLE_FX_OVERRIDE(string name)` | void | Resets the effect of SET_PARTICLE_FX_OVERRIDE<br><br>Full list of particle effect dictionaries and effects... |
| `RESET_PAUSED_RENDERPHASES` | `void RESET_PAUSED_RENDERPHASES()` | void | - |
| `RESET_SCRIPT_GFX_ALIGN` | `void RESET_SCRIPT_GFX_ALIGN()` | void | This function resets the alignment set using SET_SCRIPT_GFX_ALIGN and SET_SCRIPT_GFX_ALIGN_PARAMS to... |
| `SAVE_HIGH_QUALITY_PHOTO` | `bool SAVE_HIGH_QUALITY_PHOTO(int unused)` | bool | 1 match in 1 script. cellphone_controller.<br>p0 is -1 in scripts. |
| `SCALEFORM_MOVIE_METHOD_ADD_PARAM_BOOL` | `void SCALEFORM_MOVIE_METHOD_ADD_PARAM_BOOL(bool value)` | void | Pushes a boolean for the Scaleform function onto the stack. |
| `SCALEFORM_MOVIE_METHOD_ADD_PARAM_FLOAT` | `void SCALEFORM_MOVIE_METHOD_ADD_PARAM_FLOAT(float value)` | void | Pushes a float for the Scaleform function onto the stack. |
| `SCALEFORM_MOVIE_METHOD_ADD_PARAM_INT` | `void SCALEFORM_MOVIE_METHOD_ADD_PARAM_INT(int value)` | void | Pushes an integer for the Scaleform function onto the stack. |
| `SCALEFORM_MOVIE_METHOD_ADD_PARAM_LATEST_BRIEF_STRING` | `void SCALEFORM_MOVIE_METHOD_ADD_PARAM_LATEST_BRIEF_STRING(int value)` | void | - |
| `SCALEFORM_MOVIE_METHOD_ADD_PARAM_LITERAL_STRING` | `void SCALEFORM_MOVIE_METHOD_ADD_PARAM_LITERAL_STRING(string string)` | void | Same as SCALEFORM_MOVIE_METHOD_ADD_PARAM_TEXTURE_NAME_STRING<br>Both SCALEFORM_MOVIE_METHOD_ADD_PARAM_T... |
| `SCALEFORM_MOVIE_METHOD_ADD_PARAM_PLAYER_NAME_STRING` | `void SCALEFORM_MOVIE_METHOD_ADD_PARAM_PLAYER_NAME_STRING(string string)` | void | - |
| `SCALEFORM_MOVIE_METHOD_ADD_PARAM_TEXTURE_NAME_STRING` | `void SCALEFORM_MOVIE_METHOD_ADD_PARAM_TEXTURE_NAME_STRING(string string)` | void | - |
| `SEETHROUGH_GET_MAX_THICKNESS` | `float SEETHROUGH_GET_MAX_THICKNESS()` | float | - |
| `SEETHROUGH_RESET` | `void SEETHROUGH_RESET()` | void | - |
| `SEETHROUGH_SET_COLOR_NEAR` | `void SEETHROUGH_SET_COLOR_NEAR(int red, int green, int blue)` | void | - |
| `SEETHROUGH_SET_FADE_ENDDISTANCE` | `void SEETHROUGH_SET_FADE_ENDDISTANCE(float distance)` | void | - |
| `SEETHROUGH_SET_FADE_STARTDISTANCE` | `void SEETHROUGH_SET_FADE_STARTDISTANCE(float distance)` | void | - |
| `SEETHROUGH_SET_HEATSCALE` | `void SEETHROUGH_SET_HEATSCALE(int index, float heatScale)` | void | min: 0.0<br>max: 0.75 |
| `SEETHROUGH_SET_HIGHLIGHT_NOISE` | `void SEETHROUGH_SET_HIGHLIGHT_NOISE(float noise)` | void | - |
| `SEETHROUGH_SET_HILIGHT_INTENSITY` | `void SEETHROUGH_SET_HILIGHT_INTENSITY(float intensity)` | void | - |
| `SEETHROUGH_SET_MAX_THICKNESS` | `void SEETHROUGH_SET_MAX_THICKNESS(float thickness)` | void | 0.0 = you will not be able to see people behind the walls. 50.0 and more = you will see everyone thr... |
| `SEETHROUGH_SET_NOISE_MAX` | `void SEETHROUGH_SET_NOISE_MAX(float amount)` | void | - |
| `SEETHROUGH_SET_NOISE_MIN` | `void SEETHROUGH_SET_NOISE_MIN(float amount)` | void | - |
| `SET_ARENA_THEME_AND_VARIATION_FOR_TAKEN_PHOTO` | `void SET_ARENA_THEME_AND_VARIATION_FOR_TAKEN_PHOTO(object p0, int p1)` | void | - |
| `SET_ARTIFICIAL_LIGHTS_STATE` | `void SET_ARTIFICIAL_LIGHTS_STATE(bool state)` | void | Does not affect weapons, particles, fire/explosions, flashlights or the sun.<br>When set to true, all e... |
| `SET_ARTIFICIAL_VEHICLE_LIGHTS_STATE` | `void SET_ARTIFICIAL_VEHICLE_LIGHTS_STATE(bool toggle)` | void | If "blackout" is enabled, this native allows you to ignore "blackout" for vehicles. |
| `SET_BACKFACECULLING` | `void SET_BACKFACECULLING(bool toggle)` | void | - |
| `SET_BINK_MOVIE` | `int SET_BINK_MOVIE(string name)` | int | - |
| `SET_BINK_MOVIE_AUDIO_FRONTEND` | `void SET_BINK_MOVIE_AUDIO_FRONTEND(int binkMovie, bool p1)` | void | - |
| `SET_BINK_MOVIE_TIME` | `void SET_BINK_MOVIE_TIME(int binkMovie, float progress)` | void | In percentage: 0.0 - 100.0 |
| `SET_BINK_MOVIE_VOLUME` | `void SET_BINK_MOVIE_VOLUME(int binkMovie, float value)` | void | binkMovie: Is return value from _SET_BINK_MOVIE. Has something to do with bink volume? (audRequested... |
| `SET_BINK_SHOULD_SKIP` | `void SET_BINK_SHOULD_SKIP(int binkMovie, bool bShouldSkip)` | void | - |
| `SET_CAN_DISPLAY_MINIMAP_DURING_CUTSCENE_THIS_UPDATE` | `void SET_CAN_DISPLAY_MINIMAP_DURING_CUTSCENE_THIS_UPDATE()` | void | - |
| `SET_CAR_GENERATORS_CAN_UPDATE_DURING_CUTSCENE` | `void SET_CAR_GENERATORS_CAN_UPDATE_DURING_CUTSCENE(bool p0)` | void | - |
| `SET_CHECKPOINT_CLIPPLANE_WITH_POS_NORM` | `void SET_CHECKPOINT_CLIPPLANE_WITH_POS_NORM(int checkpoint, float posX, float posY, float posZ, float unkX, float unkY, float unkZ)` | void | This does not move an existing checkpoint... so wtf. |
| `SET_CHECKPOINT_CYLINDER_HEIGHT` | `void SET_CHECKPOINT_CYLINDER_HEIGHT(int checkpoint, float nearHeight, float farHeight, float radius)` | void | Sets the cylinder height of the checkpoint.<br><br>Parameters:<br>* nearHeight - The height of the checkpoint... |
| `SET_CHECKPOINT_DECAL_ROT_ALIGNED_TO_CAMERA_ROT` | `void SET_CHECKPOINT_DECAL_ROT_ALIGNED_TO_CAMERA_ROT(int checkpoint)` | void | Unknown. Called after creating a checkpoint (type: 51) in the creators. |
| `SET_CHECKPOINT_DIRECTION` | `void SET_CHECKPOINT_DIRECTION(int checkpoint, float posX, float posY, float posZ)` | void | - |
| `SET_CHECKPOINT_FORCE_DIRECTION` | `void SET_CHECKPOINT_FORCE_DIRECTION(int checkpoint)` | void | - |
| `SET_CHECKPOINT_FORCE_OLD_ARROW_POINTING` | `void SET_CHECKPOINT_FORCE_OLD_ARROW_POINTING(int checkpoint)` | void | - |
| `SET_CHECKPOINT_INSIDE_CYLINDER_HEIGHT_SCALE` | `void SET_CHECKPOINT_INSIDE_CYLINDER_HEIGHT_SCALE(int checkpoint, float scale)` | void | - |
| `SET_CHECKPOINT_INSIDE_CYLINDER_SCALE` | `void SET_CHECKPOINT_INSIDE_CYLINDER_SCALE(int checkpoint, float scale)` | void | - |
| `SET_CHECKPOINT_RGBA` | `void SET_CHECKPOINT_RGBA(int checkpoint, int red, int green, int blue, int alpha)` | void | Sets the checkpoint color. |
| `SET_CHECKPOINT_RGBA2` | `void SET_CHECKPOINT_RGBA2(int checkpoint, int red, int green, int blue, int alpha)` | void | Sets the checkpoint icon color. |
| `SET_CURRENT_PLAYER_TCMODIFIER` | `void SET_CURRENT_PLAYER_TCMODIFIER(string modifierName)` | void | - |
| `SET_CUTSCENE_CAN_BE_SKIPPED` | `void SET_CUTSCENE_CAN_BE_SKIPPED(bool p0)` | void | - |
| `SET_CUTSCENE_ENTITY_STREAMING_FLAGS` | `void SET_CUTSCENE_ENTITY_STREAMING_FLAGS(string cutsceneEntName, int p1, int p2)` | void | - |
| `SET_CUTSCENE_FADE_VALUES` | `void SET_CUTSCENE_FADE_VALUES(bool p0, bool p1, bool p2, bool p3)` | void | - |
| `SET_CUTSCENE_MULTIHEAD_FADE` | `void SET_CUTSCENE_MULTIHEAD_FADE(bool p0, bool p1, bool p2, bool p3)` | void | - |
| `SET_CUTSCENE_MULTIHEAD_FADE_MANUAL` | `void SET_CUTSCENE_MULTIHEAD_FADE_MANUAL(bool p0)` | void | - |
| `SET_CUTSCENE_ORIGIN` | `void SET_CUTSCENE_ORIGIN(float x, float y, float z, float p3, int p4)` | void | p3 could be heading. Needs more research. |
| `SET_CUTSCENE_ORIGIN_AND_ORIENTATION` | `void SET_CUTSCENE_ORIGIN_AND_ORIENTATION(float x1, float y1, float z1, float x2, float y2, float z2, int p6)` | void | - |
| `SET_CUTSCENE_PED_COMPONENT_VARIATION` | `void SET_CUTSCENE_PED_COMPONENT_VARIATION(string cutsceneEntName, int componentId, int drawableId, int textureId, uint modelHash)` | void | Full list of ped components by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/... |
| `SET_CUTSCENE_PED_COMPONENT_VARIATION_FROM_PED` | `void SET_CUTSCENE_PED_COMPONENT_VARIATION_FROM_PED(string cutsceneEntName, int ped, uint modelHash)` | void | - |
| `SET_CUTSCENE_PED_PROP_VARIATION` | `void SET_CUTSCENE_PED_PROP_VARIATION(string cutsceneEntName, int componentId, int drawableId, int textureId, uint modelHash)` | void | Thanks R*! ;)<br><br>if ((l_161 == 0) \|\| (l_161 == 2)) {<br>    sub_2ea27("Trying to set Jimmy prop variation... |
| `SET_CUTSCENE_TRIGGER_AREA` | `void SET_CUTSCENE_TRIGGER_AREA(float x1, float y1, float z1, float x2, float y2, float z2)` | void | Only used twice in R* scripts |
| `SET_DEBUG_LINES_AND_SPHERES_DRAWING_ACTIVE` | `void SET_DEBUG_LINES_AND_SPHERES_DRAWING_ACTIVE(bool enabled)` | void | NOTE: Debugging functions are not present in the retail version of the game. |
| `SET_DECAL_BULLET_IMPACT_RANGE_SCALE` | `void SET_DECAL_BULLET_IMPACT_RANGE_SCALE(float p0)` | void | - |
| `SET_DEPTHWRITING` | `void SET_DEPTHWRITING(bool toggle)` | void | - |
| `SET_DISABLE_DECAL_RENDERING_THIS_FRAME` | `void SET_DISABLE_DECAL_RENDERING_THIS_FRAME()` | void | - |
| `SET_DISABLE_PETROL_DECALS_IGNITING_THIS_FRAME` | `void SET_DISABLE_PETROL_DECALS_IGNITING_THIS_FRAME()` | void | - |
| `SET_DISABLE_PETROL_DECALS_RECYCLING_THIS_FRAME` | `void SET_DISABLE_PETROL_DECALS_RECYCLING_THIS_FRAME()` | void | - |
| `SET_DISTANCE_BLUR_STRENGTH_OVERRIDE` | `void SET_DISTANCE_BLUR_STRENGTH_OVERRIDE(float p0)` | void | - |
| `SET_DRAW_ORIGIN` | `void SET_DRAW_ORIGIN(float x, float y, float z, bool p3)` | void | Sets the on-screen drawing origin for draw-functions (which is normally x=0,y=0 in the upper left co... |
| `SET_ENTITY_ICON_COLOR` | `void SET_ENTITY_ICON_COLOR(int entity, int red, int green, int blue, int alpha)` | void | - |
| `SET_ENTITY_ICON_VISIBILITY` | `void SET_ENTITY_ICON_VISIBILITY(int entity, bool toggle)` | void | - |
| `SET_EXPOSURETWEAK` | `void SET_EXPOSURETWEAK(bool toggle)` | void | - |
| `SET_EXTRA_TCMODIFIER` | `void SET_EXTRA_TCMODIFIER(string modifierName)` | void | Full list of timecycle modifiers by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/ma... |
| `SET_FLASH` | `void SET_FLASH(float p0, float p1, float fadeIn, float duration, float fadeOut)` | void | Purpose of p0 and p1 unknown. |
| `SET_FORCE_MOTIONBLUR` | `void SET_FORCE_MOTIONBLUR(bool toggle)` | void | - |
| `SET_GRASS_CULL_SPHERE` | `int SET_GRASS_CULL_SPHERE(float p0, float p1, float p2, float p3)` | int | This function is hard-coded to always return 0. |
| `SET_HIDOF_OVERRIDE` | `void SET_HIDOF_OVERRIDE(bool p0, bool p1, float nearplaneOut, float nearplaneIn, float farplaneOut, float farplaneIn)` | void | - |
| `SET_LIGHT_OVERRIDE_MAX_INTENSITY_SCALE` | `void SET_LIGHT_OVERRIDE_MAX_INTENSITY_SCALE(object p0)` | void | - |
| `SET_LOCK_ADAPTIVE_DOF_DISTANCE` | `void SET_LOCK_ADAPTIVE_DOF_DISTANCE(bool p0)` | void | - |
| `SET_MOTIONBLUR_MAX_VEL_SCALER` | `void SET_MOTIONBLUR_MAX_VEL_SCALER(float p0)` | void | Setter for GET_MOTIONBLUR_MAX_VEL_SCALER |
| `SET_NEXT_PLAYER_TCMODIFIER` | `void SET_NEXT_PLAYER_TCMODIFIER(string modifierName)` | void | - |
| `SET_NIGHTVISION` | `void SET_NIGHTVISION(bool toggle)` | void | Enables Night Vision.<br><br>Example:<br>C#: Function.Call(Hash.SET_NIGHTVISION, true);<br>C++: GRAPHICS::SET_NI... |
| `SET_NOISEOVERIDE` | `void SET_NOISEOVERIDE(bool toggle)` | void | - |
| `SET_NOISINESSOVERIDE` | `void SET_NOISINESSOVERIDE(float value)` | void | - |
| `SET_ON_ISLAND_X_FOR_TAKEN_PHOTO` | `void SET_ON_ISLAND_X_FOR_TAKEN_PHOTO(object p0)` | void | - |
| `SET_PAD_CAN_SHAKE_DURING_CUTSCENE` | `void SET_PAD_CAN_SHAKE_DURING_CUTSCENE(bool toggle)` | void | Toggles a value (bool) for cutscenes. |
| `SET_PARTICLE_FX_BANG_SCRAPE_LODRANGE_SCALE` | `void SET_PARTICLE_FX_BANG_SCRAPE_LODRANGE_SCALE(float p0)` | void | - |
| `SET_PARTICLE_FX_BLOOD_SCALE` | `void SET_PARTICLE_FX_BLOOD_SCALE(object p0)` | void | - |
| `SET_PARTICLE_FX_BULLET_IMPACT_LODRANGE_SCALE` | `void SET_PARTICLE_FX_BULLET_IMPACT_LODRANGE_SCALE(float p0)` | void | - |
| `SET_PARTICLE_FX_BULLET_IMPACT_SCALE` | `void SET_PARTICLE_FX_BULLET_IMPACT_SCALE(float scale)` | void | - |
| `SET_PARTICLE_FX_BULLET_TRACE_NO_ANGLE_REJECT` | `void SET_PARTICLE_FX_BULLET_TRACE_NO_ANGLE_REJECT(bool p0)` | void | - |
| `SET_PARTICLE_FX_CAM_INSIDE_NONPLAYER_VEHICLE` | `void SET_PARTICLE_FX_CAM_INSIDE_NONPLAYER_VEHICLE(int vehicle, bool p1)` | void | - |
| `SET_PARTICLE_FX_CAM_INSIDE_VEHICLE` | `void SET_PARTICLE_FX_CAM_INSIDE_VEHICLE(bool p0)` | void | - |
| `SET_PARTICLE_FX_FOOT_LODRANGE_SCALE` | `void SET_PARTICLE_FX_FOOT_LODRANGE_SCALE(float p0)` | void | - |
| `SET_PARTICLE_FX_FOOT_OVERRIDE_NAME` | `void SET_PARTICLE_FX_FOOT_OVERRIDE_NAME(string p0)` | void | Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta... |
| `SET_PARTICLE_FX_FORCE_VEHICLE_INTERIOR` | `void SET_PARTICLE_FX_FORCE_VEHICLE_INTERIOR(bool toggle)` | void | Used only once in the scripts (taxi_clowncar) |
| `SET_PARTICLE_FX_LOOPED_ALPHA` | `void SET_PARTICLE_FX_LOOPED_ALPHA(int ptfxHandle, float alpha)` | void | - |
| `SET_PARTICLE_FX_LOOPED_COLOUR` | `void SET_PARTICLE_FX_LOOPED_COLOUR(int ptfxHandle, float r, float g, float b, bool p4)` | void | only works on some fx's<br><br>p4 = 0 |
| `SET_PARTICLE_FX_LOOPED_EVOLUTION` | `void SET_PARTICLE_FX_LOOPED_EVOLUTION(int ptfxHandle, string propertyName, float amount, bool noNetwork)` | void | - |
| `SET_PARTICLE_FX_LOOPED_FAR_CLIP_DIST` | `void SET_PARTICLE_FX_LOOPED_FAR_CLIP_DIST(int ptfxHandle, float range)` | void | - |
| `SET_PARTICLE_FX_LOOPED_OFFSETS` | `void SET_PARTICLE_FX_LOOPED_OFFSETS(int ptfxHandle, float x, float y, float z, float rotX, float rotY, float rotZ)` | void | - |
| `SET_PARTICLE_FX_LOOPED_SCALE` | `void SET_PARTICLE_FX_LOOPED_SCALE(int ptfxHandle, float scale)` | void | - |
| `SET_PARTICLE_FX_NON_LOOPED_ALPHA` | `void SET_PARTICLE_FX_NON_LOOPED_ALPHA(float alpha)` | void | Usage example for C#:<br><br>Function.Call(Hash.SET_PARTICLE_FX_NON_LOOPED_ALPHA, new InputArgument[] { 0.... |
| `SET_PARTICLE_FX_NON_LOOPED_COLOUR` | `void SET_PARTICLE_FX_NON_LOOPED_COLOUR(float r, float g, float b)` | void | only works on some fx's, not networked |
| `SET_PARTICLE_FX_NON_LOOPED_EMITTER_SIZE` | `void SET_PARTICLE_FX_NON_LOOPED_EMITTER_SIZE(float p0, float p1, float scale)` | void | - |
| `SET_PARTICLE_FX_NON_LOOPED_SCALE` | `void SET_PARTICLE_FX_NON_LOOPED_SCALE(float scale)` | void | - |
| `SET_PARTICLE_FX_OVERRIDE` | `void SET_PARTICLE_FX_OVERRIDE(string oldAsset, string newAsset)` | void | Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta... |
| `SET_PARTICLE_FX_SHOOTOUT_BOAT` | `void SET_PARTICLE_FX_SHOOTOUT_BOAT(object p0)` | void | - |
| `SET_PARTICLE_FX_SLIPSTREAM_LODRANGE_SCALE` | `void SET_PARTICLE_FX_SLIPSTREAM_LODRANGE_SCALE(float scale)` | void | - |
| `SET_PLAYER_TCMODIFIER_TRANSITION` | `void SET_PLAYER_TCMODIFIER_TRANSITION(float value)` | void | - |
| `SET_PTFX_FORCE_VEHICLE_INTERIOR_FLAG` | `void SET_PTFX_FORCE_VEHICLE_INTERIOR_FLAG(object p0)` | void | - |
| `SET_SCALEFORM_MOVIE_AS_NO_LONGER_NEEDED` | `void SET_SCALEFORM_MOVIE_AS_NO_LONGER_NEEDED(ref int scaleformHandle)` | void | - |
| `SET_SCALEFORM_MOVIE_TO_USE_LARGE_RT` | `void SET_SCALEFORM_MOVIE_TO_USE_LARGE_RT(int scaleformHandle, bool toggle)` | void | - |
| `SET_SCALEFORM_MOVIE_TO_USE_SUPER_LARGE_RT` | `void SET_SCALEFORM_MOVIE_TO_USE_SUPER_LARGE_RT(int scaleformHandle, bool toggle)` | void | This native is used in some casino scripts to fit the scaleform in the rendertarget. |
| `SET_SCALEFORM_MOVIE_TO_USE_SYSTEM_TIME` | `void SET_SCALEFORM_MOVIE_TO_USE_SYSTEM_TIME(int scaleform, bool toggle)` | void | - |
| `SET_SCRIPT_CAN_START_CUTSCENE` | `void SET_SCRIPT_CAN_START_CUTSCENE(int threadId)` | void | Sets the cutscene's owning thread ID. |
| `SET_SCRIPT_GFX_ALIGN` | `void SET_SCRIPT_GFX_ALIGN(int horizontalAlign, int verticalAlign)` | void | horizontalAlign: The horizontal alignment. This can be 67 ('C'), 76 ('L'), or 82 ('R').<br>verticalAlig... |
| `SET_SCRIPT_GFX_ALIGN_PARAMS` | `void SET_SCRIPT_GFX_ALIGN_PARAMS(float x, float y, float w, float h)` | void | Sets the draw offset/calculated size for SET_SCRIPT_GFX_ALIGN. If using any alignment other than lef... |
| `SET_SCRIPT_GFX_DRAW_BEHIND_PAUSEMENU` | `void SET_SCRIPT_GFX_DRAW_BEHIND_PAUSEMENU(bool toggle)` | void | Sets a flag defining whether or not script draw commands should continue being drawn behind the paus... |
| `SET_SCRIPT_GFX_DRAW_ORDER` | `void SET_SCRIPT_GFX_DRAW_ORDER(int drawOrder)` | void | Sets the draw order for script draw commands.<br><br>Examples from decompiled scripts:<br>GRAPHICS::SET_SCRIP... |
| `SET_SEETHROUGH` | `void SET_SEETHROUGH(bool toggle)` | void | Toggles Heatvision on/off. |
| `SET_SKIDMARK_RANGE_SCALE` | `void SET_SKIDMARK_RANGE_SCALE(float scale)` | void | - |
| `SET_STREAMED_TEXTURE_DICT_AS_NO_LONGER_NEEDED` | `void SET_STREAMED_TEXTURE_DICT_AS_NO_LONGER_NEEDED(string textureDict)` | void | - |
| `SET_TAKEN_PHOTO_IS_MUGSHOT` | `void SET_TAKEN_PHOTO_IS_MUGSHOT(bool toggle)` | void | - |
| `SET_TIMECYCLE_MODIFIER` | `void SET_TIMECYCLE_MODIFIER(string modifierName)` | void | Loads the specified timecycle modifier. Modifiers are defined separately in another file (e.g. "time... |
| `SET_TIMECYCLE_MODIFIER_STRENGTH` | `void SET_TIMECYCLE_MODIFIER_STRENGTH(float strength)` | void | - |
| `SET_TRACKED_POINT_INFO` | `void SET_TRACKED_POINT_INFO(int point, float x, float y, float z, float radius)` | void | - |
| `SET_TRANSITION_OUT_OF_TIMECYCLE_MODIFIER` | `void SET_TRANSITION_OUT_OF_TIMECYCLE_MODIFIER(float strength)` | void | - |
| `SET_TRANSITION_TIMECYCLE_MODIFIER` | `void SET_TRANSITION_TIMECYCLE_MODIFIER(string modifierName, float transition)` | void | Full list of timecycle modifiers by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/ma... |
| `SET_TV_AUDIO_FRONTEND` | `void SET_TV_AUDIO_FRONTEND(bool toggle)` | void | Probably changes tvs from being a 3d audio to being "global" audio |
| `SET_TV_CHANNEL` | `void SET_TV_CHANNEL(int channel)` | void | - |
| `SET_TV_CHANNEL_PLAYLIST` | `void SET_TV_CHANNEL_PLAYLIST(int tvChannel, string playlistName, bool restart)` | void | Loads specified video sequence into the TV Channel<br>TV_Channel ranges from 0-2<br>VideoSequence can be a... |
| `SET_TV_CHANNEL_PLAYLIST_AT_HOUR` | `void SET_TV_CHANNEL_PLAYLIST_AT_HOUR(int tvChannel, string playlistName, int hour)` | void | - |
| `SET_TV_PLAYER_WATCHING_THIS_FRAME` | `void SET_TV_PLAYER_WATCHING_THIS_FRAME(object p0)` | void | - |
| `SET_TV_VOLUME` | `void SET_TV_VOLUME(float volume)` | void | - |
| `SET_VEHICLE_MODEL_PLAYER_WILL_EXIT_SCENE` | `void SET_VEHICLE_MODEL_PLAYER_WILL_EXIT_SCENE(uint modelHash)` | void | Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicl... |
| `SET_WEATHER_PTFX_OVERRIDE_CURR_LEVEL` | `void SET_WEATHER_PTFX_OVERRIDE_CURR_LEVEL(float p0)` | void | - |
| `SET_WEATHER_PTFX_USE_OVERRIDE_SETTINGS` | `void SET_WEATHER_PTFX_USE_OVERRIDE_SETTINGS(bool p0)` | void | - |
| `START_CUTSCENE` | `void START_CUTSCENE(int flags)` | void | flags: Usually 0. |
| `START_CUTSCENE_AT_COORDS` | `void START_CUTSCENE_AT_COORDS(float x, float y, float z, int flags)` | void | flags: Usually 0. |
| `START_NETWORKED_PARTICLE_FX_LOOPED_ON_ENTITY` | `int START_NETWORKED_PARTICLE_FX_LOOPED_ON_ENTITY(string effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis, float r, float g, float b, float a)` | int | Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta... |
| `START_NETWORKED_PARTICLE_FX_LOOPED_ON_ENTITY_BONE` | `int START_NETWORKED_PARTICLE_FX_LOOPED_ON_ENTITY_BONE(string effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, bool xAxis, bool yAxis, bool zAxis, float r, float g, float b, float a)` | int | Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta... |
| `START_NETWORKED_PARTICLE_FX_NON_LOOPED_AT_COORD` | `bool START_NETWORKED_PARTICLE_FX_NON_LOOPED_AT_COORD(string effectName, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis, bool p11)` | bool | Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta... |
| `START_NETWORKED_PARTICLE_FX_NON_LOOPED_ON_ENTITY` | `bool START_NETWORKED_PARTICLE_FX_NON_LOOPED_ON_ENTITY(string effectName, int entity, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, float scale, bool axisX, bool axisY, bool axisZ)` | bool | Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta... |
| `START_NETWORKED_PARTICLE_FX_NON_LOOPED_ON_PED_BONE` | `bool START_NETWORKED_PARTICLE_FX_NON_LOOPED_ON_PED_BONE(string effectName, int ped, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, int boneIndex, float scale, bool axisX, bool axisY, bool axisZ)` | bool | Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta... |
| `START_PARTICLE_FX_LOOPED_AT_COORD` | `int START_PARTICLE_FX_LOOPED_AT_COORD(string effectName, float x, float y, float z, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis, bool p11)` | int | GRAPHICS::START_PARTICLE_FX_LOOPED_AT_COORD("scr_fbi_falling_debris", 93.7743f, -749.4572f, 70.86904... |
| `START_PARTICLE_FX_LOOPED_ON_ENTITY` | `int START_PARTICLE_FX_LOOPED_ON_ENTITY(string effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis)` | int | Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta... |
| `START_PARTICLE_FX_LOOPED_ON_ENTITY_BONE` | `int START_PARTICLE_FX_LOOPED_ON_ENTITY_BONE(string effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, bool xAxis, bool yAxis, bool zAxis)` | int | Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta... |
| `START_PARTICLE_FX_LOOPED_ON_PED_BONE` | `int START_PARTICLE_FX_LOOPED_ON_PED_BONE(string effectName, int ped, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, bool xAxis, bool yAxis, bool zAxis)` | int | Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta... |
| `START_PARTICLE_FX_NON_LOOPED_AT_COORD` | `bool START_PARTICLE_FX_NON_LOOPED_AT_COORD(string effectName, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis)` | bool | GRAPHICS::START_PARTICLE_FX_NON_LOOPED_AT_COORD("scr_paleto_roof_impact", -140.8576f, 6420.789f, 41.... |
| `START_PARTICLE_FX_NON_LOOPED_ON_ENTITY` | `bool START_PARTICLE_FX_NON_LOOPED_ON_ENTITY(string effectName, int entity, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, float scale, bool axisX, bool axisY, bool axisZ)` | bool | Starts a particle effect on an entity for example your player.<br><br>Full list of particle effect diction... |
| `START_PARTICLE_FX_NON_LOOPED_ON_ENTITY_BONE` | `bool START_PARTICLE_FX_NON_LOOPED_ON_ENTITY_BONE(string effectName, int entity, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, int boneIndex, float scale, bool axisX, bool axisY, bool axisZ)` | bool | Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta... |
| `START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE` | `bool START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE(string effectName, int ped, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, int boneIndex, float scale, bool axisX, bool axisY, bool axisZ)` | bool | GRAPHICS::START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE("scr_sh_bong_smoke", PLAYER::PLAYER_PED_ID(), -0.... |
| `START_PETROL_TRAIL_DECALS` | `void START_PETROL_TRAIL_DECALS(float p0)` | void | - |
| `STOP_BINK_MOVIE` | `void STOP_BINK_MOVIE(int binkMovie)` | void | - |
| `STOP_CUTSCENE` | `void STOP_CUTSCENE(bool p0)` | void | - |
| `STOP_CUTSCENE_IMMEDIATELY` | `void STOP_CUTSCENE_IMMEDIATELY()` | void | - |
| `STOP_PARTICLE_FX_LOOPED` | `void STOP_PARTICLE_FX_LOOPED(int ptfxHandle, bool p1)` | void | p1 is always 0 in the native scripts |
| `TERRAINGRID_ACTIVATE` | `void TERRAINGRID_ACTIVATE(bool toggle)` | void | This native enables/disables the gold putting grid display (https://i.imgur.com/TC6cku6.png).<br>This r... |
| `TERRAINGRID_SET_COLOURS` | `void TERRAINGRID_SET_COLOURS(int lowR, int lowG, int lowB, int lowAlpha, int r, int g, int b, int alpha, int highR, int highG, int highB, int highAlpha)` | void | This native is used along with these two natives: `TERRAINGRID_ACTIVATE` and `TERRAINGRID_SET_PARAMS... |
| `TERRAINGRID_SET_PARAMS` | `void TERRAINGRID_SET_PARAMS(float x, float y, float z, float forwardX, float forwardY, float forwardZ, float sizeX, float sizeY, float sizeZ, float gridScale, float glowIntensity, float normalHeight, float heightDiff)` | void | This native is used along with these two natives: `TERRAINGRID_ACTIVATE` and `TERRAINGRID_SET_COLOUR... |
| `TOGGLE_PAUSED_RENDERPHASES` | `void TOGGLE_PAUSED_RENDERPHASES(bool toggle)` | void | - |
| `TOGGLE_PLAYER_DAMAGE_OVERLAY` | `void TOGGLE_PLAYER_DAMAGE_OVERLAY(bool toggle)` | void | - |
| `TRIGGER_SCREENBLUR_FADE_IN` | `bool TRIGGER_SCREENBLUR_FADE_IN(float transitionTime)` | bool | time in ms to transition to fully blurred screen |
| `TRIGGER_SCREENBLUR_FADE_OUT` | `bool TRIGGER_SCREENBLUR_FADE_OUT(float transitionTime)` | bool | time in ms to transition from fully blurred to normal |
| `UI3DSCENE_ASSIGN_PED_TO_SLOT` | `bool UI3DSCENE_ASSIGN_PED_TO_SLOT(string presetName, int ped, int slot, float posX, float posY, float posZ)` | bool | It's called after UI3DSCENE_IS_AVAILABLE and UI3DSCENE_PUSH_PRESET<br><br>presetName was always "CELEBRATI... |
| `UI3DSCENE_CLEAR_PATCHED_DATA` | `void UI3DSCENE_CLEAR_PATCHED_DATA()` | void | - |
| `UI3DSCENE_IS_AVAILABLE` | `bool UI3DSCENE_IS_AVAILABLE()` | bool | - |
| `UI3DSCENE_MAKE_PUSHED_PRESET_PERSISTENT` | `void UI3DSCENE_MAKE_PUSHED_PRESET_PERSISTENT(bool toggle)` | void | - |
| `UI3DSCENE_PUSH_PRESET` | `bool UI3DSCENE_PUSH_PRESET(string presetName)` | bool | All presets can be found in common\data\ui\uiscenes.meta |
| `UNPATCH_DECAL_DIFFUSE_MAP` | `void UNPATCH_DECAL_DIFFUSE_MAP(int decalType)` | void | - |
| `UPDATE_LIGHTS_ON_ENTITY` | `void UPDATE_LIGHTS_ON_ENTITY(int entity)` | void | - |
| `USE_PARTICLE_FX_ASSET` | `void USE_PARTICLE_FX_ASSET(string name)` | void | From the b678d decompiled scripts:<br><br> GRAPHICS::USE_PARTICLE_FX_ASSET("FM_Mission_Controler");<br> GRAPH... |
| `USE_SNOW_FOOT_VFX_WHEN_UNSHELTERED` | `void USE_SNOW_FOOT_VFX_WHEN_UNSHELTERED(bool toggle)` | void | Forces footstep tracks on all surfaces. |
| `USE_SNOW_WHEEL_VFX_WHEN_UNSHELTERED` | `void USE_SNOW_WHEEL_VFX_WHEN_UNSHELTERED(bool toggle)` | void | Forces vehicle trails on all surfaces. |
| `WASH_DECALS_FROM_VEHICLE` | `void WASH_DECALS_FROM_VEHICLE(int vehicle, float p1)` | void | - |
| `WASH_DECALS_IN_RANGE` | `void WASH_DECALS_IN_RANGE(float x, float y, float z, float range, float p4)` | void | - |
| `WAS_CUTSCENE_SKIPPED` | `bool WAS_CUTSCENE_SKIPPED()` | bool | - |
| `WATER_REFLECTION_SET_SCRIPT_OBJECT_VISIBILITY` | `void WATER_REFLECTION_SET_SCRIPT_OBJECT_VISIBILITY(object p0)` | void | - |
| `_FORCE_ALLOW_SNOW_FOOT_VFX_ON_ICE` | `void _FORCE_ALLOW_SNOW_FOOT_VFX_ON_ICE(bool toggle)` | void | - |
| `_FORCE_GROUND_SNOW_PASS` | `void _FORCE_GROUND_SNOW_PASS(bool toggle)` | void | - |
| `_HAS_SCALEFORM_MOVIE_NAMED_LOADED` | `bool _HAS_SCALEFORM_MOVIE_NAMED_LOADED(ref int scaleformHandle, string scaleformName)` | bool | - |
| `_SET_PARTICLE_FX_LOOPED_CAMERA_BIAS` | `void _SET_PARTICLE_FX_LOOPED_CAMERA_BIAS(int ptfxHandle, float p1)` | void | - |
| `_SET_SCALEFORM_MOVIE_NAMED_AS_NO_LONGER_NEEDED` | `void _SET_SCALEFORM_MOVIE_NAMED_AS_NO_LONGER_NEEDED(int scaleformHandle, string scaleformName)` | void | - |
| `_SET_TV_CHANNEL_PLAYLIST_DIRTY` | `object _SET_TV_CHANNEL_PLAYLIST_DIRTY(int tvChannel, bool p1)` | object | Does not actually return anything. |
| `_START_VEHICLE_PARTICLE_FX_LOOPED` | `int _START_VEHICLE_PARTICLE_FX_LOOPED(int vehicle, string effectName, bool frontBack, bool leftRight, bool localOnly)` | int | Returns ptfxHandle<br>effectName: scr_sv_drag_burnout |

---

## 详细说明

### ABORT_VEHICLE_CREW_EMBLEM_REQUEST

- **命名空间:** `GRAPHICS`
- **Hash:** `0x82ACC484FFA3B05F`
- **Build:** `372`

**C# 签名:**
```csharp
bool ABORT_VEHICLE_CREW_EMBLEM_REQUEST(ref int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### ADD_DECAL

- **命名空间:** `GRAPHICS`
- **Hash:** `0xB302244A1839BDAD`
- **JHash:** `0xEAD0C412`
- **Build:** `323`

**C# 签名:**
```csharp
int ADD_DECAL(int decalType, float posX, float posY, float posZ, float p4, float p5, float p6, float p7, float p8, float p9, float width, float height, float rCoef, float gCoef, float bCoef, float opacity, float timeout, bool p17, bool p18, bool p19)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `decalType` | `int` | `int` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `p4` | `float` | `float` | - |
| `p5` | `float` | `float` | - |
| `p6` | `float` | `float` | - |
| `p7` | `float` | `float` | - |
| `p8` | `float` | `float` | - |
| `p9` | `float` | `float` | - |
| `width` | `float` | `float` | - |
| `height` | `float` | `float` | - |
| `rCoef` | `float` | `float` | - |
| `gCoef` | `float` | `float` | - |
| `bCoef` | `float` | `float` | - |
| `opacity` | `float` | `float` | - |
| `timeout` | `float` | `float` | - |
| `p17` | `BOOL` | `bool` | - |
| `p18` | `BOOL` | `bool` | - |
| `p19` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
decal types:

public enum DecalTypes
{
    splatters_blood = 1010,
    splatters_blood_dir = 1015,
    splatters_blood_mist = 1017,
    splatters_mud = 1020,
    splatters_paint = 1030,
    splatters_water = 1040,
    splatters_water_hydrant = 1050,
    splatters_blood2 = 1110,
    weapImpact_metal = 4010,
    weapImpact_concrete = 4020,
    weapImpact_mattress = 4030,
    weapImpact_mud = 4032,
    weapImpact_wood = 4050,
    weapImpact_sand = 4053,
    weapImpact_cardboard = 4040,
    weapImpact_melee_glass = 4100,
    weapImpact_glass_blood = 4102,
    weapImpact_glass_blood2 = 4104,
    weapImpact_shotgun_paper = 4200,
    weapImpact_shotgun_mattress,
    weapImpact_shotgun_metal,
    weapImpact_shotgun_wood,
    weapImpact_shotgun_dirt,
    weapImpact_shotgun_tvscreen,
    weapImpact_shotgun_tvscreen2,
    weapImpact_shotgun_tvscreen3,
    weapImpact_melee_concrete = 4310,
    weapImpact_melee_wood = 4312,
    weapImpact_melee_metal = 4314,
    burn1 = 4421,
    burn2,
    burn3,
    burn4,
    burn5,
    bang_concrete_bang = 5000,
    bang_concrete_bang2,
    bang_bullet_bang,
    bang_bullet_bang2 = 5004,
    bang_glass = 5031,
    bang_glass2,
    solidPool_water = 9000,
    solidPool_blood,
    solidPool_oil,
    solidPool_petrol,
    solidPool_mud,
    porousPool_water,
    porousPool_blood,
    porousPool_oil,
    porousPool_petrol,
    porousPool_mud,
    porousPool_water_ped_drip,
    liquidTrail_water = 9050
}
```

---

### ADD_ENTITY_ICON

- **命名空间:** `GRAPHICS`
- **Hash:** `0x9CD43EEE12BF4DD0`
- **JHash:** `0xF3027D21`
- **Build:** `323`

**C# 签名:**
```csharp
int ADD_ENTITY_ICON(int entity, string icon)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `icon` | `const char*` | `string` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Example:
GRAPHICS::ADD_ENTITY_ICON(a_0, "MP_Arrow");

I tried this and nothing happened...
```

---

### ADD_OIL_DECAL

- **命名空间:** `GRAPHICS`
- **Hash:** `0x126D7F89FE859A5E`
- **Build:** `2699`

**C# 签名:**
```csharp
int ADD_OIL_DECAL(float x, float y, float z, float groundLvl, float width, float transparency)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `groundLvl` | `float` | `float` | - |
| `width` | `float` | `float` | - |
| `transparency` | `float` | `float` | - |

**返回值:** `int` (Native: `int`)

---

### ADD_PETROL_DECAL

- **命名空间:** `GRAPHICS`
- **Hash:** `0x4F5212C7AD880DF8`
- **JHash:** `0x1259DF42`
- **Build:** `323`

**C# 签名:**
```csharp
int ADD_PETROL_DECAL(float x, float y, float z, float groundLvl, float width, float transparency)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `groundLvl` | `float` | `float` | - |
| `width` | `float` | `float` | - |
| `transparency` | `float` | `float` | - |

**返回值:** `int` (Native: `int`)

---

### ADD_PETROL_TRAIL_DECAL_INFO

- **命名空间:** `GRAPHICS`
- **Hash:** `0x967278682CB6967A`
- **JHash:** `0xBAEC6ADD`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_PETROL_TRAIL_DECAL_INFO(float x, float y, float z, float p3)
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

### ADD_TCMODIFIER_OVERRIDE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x1A8E2C8B9CF4549C`
- **JHash:** `0xE8F538B5`
- **Build:** `323`

**C# 签名:**
```csharp
void ADD_TCMODIFIER_OVERRIDE(string modifierName1, string modifierName2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modifierName1` | `const char*` | `string` | - |
| `modifierName2` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### ADD_VEHICLE_CREW_EMBLEM

- **命名空间:** `GRAPHICS`
- **Hash:** `0x428BDCB9DA58DA53`
- **JHash:** `0x12077738`
- **Build:** `323`

**C# 签名:**
```csharp
bool ADD_VEHICLE_CREW_EMBLEM(int vehicle, int ped, int boneIndex, float x1, float x2, float x3, float y1, float y2, float y3, float z1, float z2, float z3, float scale, object p13, int alpha)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `ped` | `Ped` | `int` | - |
| `boneIndex` | `int` | `int` | - |
| `x1` | `float` | `float` | - |
| `x2` | `float` | `float` | - |
| `x3` | `float` | `float` | - |
| `y1` | `float` | `float` | - |
| `y2` | `float` | `float` | - |
| `y3` | `float` | `float` | - |
| `z1` | `float` | `float` | - |
| `z2` | `float` | `float` | - |
| `z3` | `float` | `float` | - |
| `scale` | `float` | `float` | - |
| `p13` | `Any` | `object` | - |
| `alpha` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
boneIndex is always chassis_dummy in the scripts. The x/y/z params are location relative to the chassis bone.
```

---

### ADJUST_NEXT_POS_SIZE_AS_NORMALIZED_16_9

- **命名空间:** `GRAPHICS`
- **Hash:** `0xEFABC7722293DA7C`
- **Build:** `323`

**C# 签名:**
```csharp
void ADJUST_NEXT_POS_SIZE_AS_NORMALIZED_16_9()
```

**返回值:** `void` (Native: `void`)

---

### ANIMPOSTFX_GET_CURRENT_TIME

- **命名空间:** `GRAPHICS`
- **Hash:** `0xE35B38A27E8E7179`
- **Build:** `877`

**C# 签名:**
```csharp
float ANIMPOSTFX_GET_CURRENT_TIME(string effectName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `effectName` | `const char*` | `string` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
See ANIMPOSTFX_PLAY

Full list of animpostFX / screen effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animPostFxNamesCompact.json
```

---

### ANIMPOSTFX_IS_RUNNING

- **命名空间:** `GRAPHICS`
- **Hash:** `0x36AD3E690DA5ACEB`
- **JHash:** `0x089D5921`
- **Build:** `323`

**C# 签名:**
```csharp
bool ANIMPOSTFX_IS_RUNNING(string effectName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `effectName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns whether the specified effect is active.
See ANIMPOSTFX_PLAY

Full list of animpostFX / screen effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animPostFxNamesCompact.json
```

---

### ANIMPOSTFX_PLAY

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2206BF9A37B7F724`
- **JHash:** `0x1D980479`
- **Build:** `323`

**C# 签名:**
```csharp
void ANIMPOSTFX_PLAY(string effectName, int duration, bool looped)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `effectName` | `const char*` | `string` | - |
| `duration` | `int` | `int` | - |
| `looped` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
duration - is how long to play the effect for in milliseconds. If 0, it plays the default length
if loop is true, the effect won't stop until you call ANIMPOSTFX_STOP on it. (only loopable effects)

Full list of animpostFX / screen effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animPostFxNamesCompact.json
```

---

### ANIMPOSTFX_STOP

- **命名空间:** `GRAPHICS`
- **Hash:** `0x068E835A1D0DC0E3`
- **JHash:** `0x06BB5CDA`
- **Build:** `323`

**C# 签名:**
```csharp
void ANIMPOSTFX_STOP(string effectName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `effectName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
See ANIMPOSTFX_PLAY

Full list of animpostFX / screen effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animPostFxNamesCompact.json
```

---

### ANIMPOSTFX_STOP_ALL

- **命名空间:** `GRAPHICS`
- **Hash:** `0xB4EDDC19532BFB85`
- **JHash:** `0x4E6D875B`
- **Build:** `323`

**C# 签名:**
```csharp
void ANIMPOSTFX_STOP_ALL()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Stops ALL currently playing effects.
```

---

### ANIMPOSTFX_STOP_AND_FLUSH_REQUESTS

- **命名空间:** `GRAPHICS`
- **Hash:** `0xD2209BE128B5418C`
- **Build:** `323`

**C# 签名:**
```csharp
void ANIMPOSTFX_STOP_AND_FLUSH_REQUESTS(string effectName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `effectName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Stops the effect and sets a value (bool) in its data (+0x199) to false.
See ANIMPOSTFX_PLAY

Full list of animpostFX / screen effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animPostFxNamesCompact.json
```

---

### ATTACH_TV_AUDIO_TO_ENTITY

- **命名空间:** `GRAPHICS`
- **Hash:** `0x845BAD77CC770633`
- **JHash:** `0x784944DB`
- **Build:** `323`

**C# 签名:**
```csharp
void ATTACH_TV_AUDIO_TO_ENTITY(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### BEGIN_CREATE_LOW_QUALITY_COPY_OF_PHOTO

- **命名空间:** `GRAPHICS`
- **Hash:** `0x759650634F07B6B4`
- **JHash:** `0x25D569EB`
- **Build:** `323`

**C# 签名:**
```csharp
bool BEGIN_CREATE_LOW_QUALITY_COPY_OF_PHOTO(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### BEGIN_CREATE_MISSION_CREATOR_PHOTO_PREVIEW

- **命名空间:** `GRAPHICS`
- **Hash:** `0x7FA5D82B8F58EC06`
- **JHash:** `0x1F3CADB0`
- **Build:** `323`

**C# 签名:**
```csharp
bool BEGIN_CREATE_MISSION_CREATOR_PHOTO_PREVIEW()
```

**返回值:** `bool` (Native: `BOOL`)

---

### BEGIN_SCALEFORM_MOVIE_METHOD

- **命名空间:** `GRAPHICS`
- **Hash:** `0xF6E48914C7A8694E`
- **JHash:** `0x215ABBE8`
- **Build:** `323`

**C# 签名:**
```csharp
bool BEGIN_SCALEFORM_MOVIE_METHOD(int scaleform, string methodName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleform` | `int` | `int` | - |
| `methodName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Push a function from the Scaleform onto the stack

```

---

### BEGIN_SCALEFORM_MOVIE_METHOD_ON_FRONTEND

- **命名空间:** `GRAPHICS`
- **Hash:** `0xAB58C27C2E6123C6`
- **JHash:** `0xF6015178`
- **Build:** `323`

**C# 签名:**
```csharp
bool BEGIN_SCALEFORM_MOVIE_METHOD_ON_FRONTEND(string methodName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `methodName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Starts frontend (pause menu) scaleform movie methods.
This can be used when you want to make custom frontend menus, and customize things like images or text in the menus etc.
Use `BEGIN_SCALEFORM_MOVIE_METHOD_ON_FRONTEND_HEADER` for header scaleform functions.
```

---

### BEGIN_SCALEFORM_MOVIE_METHOD_ON_FRONTEND_HEADER

- **命名空间:** `GRAPHICS`
- **Hash:** `0xB9449845F73F5E9C`
- **JHash:** `0x5E219B67`
- **Build:** `323`

**C# 签名:**
```csharp
bool BEGIN_SCALEFORM_MOVIE_METHOD_ON_FRONTEND_HEADER(string methodName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `methodName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Starts frontend (pause menu) scaleform movie methods for header options.
Use `BEGIN_SCALEFORM_MOVIE_METHOD_ON_FRONTEND` to customize the content inside the frontend menus.
```

---

### BEGIN_SCALEFORM_SCRIPT_HUD_MOVIE_METHOD

- **命名空间:** `GRAPHICS`
- **Hash:** `0x98C494FD5BDFBFD5`
- **JHash:** `0x5D66CE1E`
- **Build:** `323`

**C# 签名:**
```csharp
bool BEGIN_SCALEFORM_SCRIPT_HUD_MOVIE_METHOD(int hudComponent, string methodName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `hudComponent` | `int` | `int` | - |
| `methodName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Pushes a function from the Hud component Scaleform onto the stack. Same behavior as GRAPHICS::BEGIN_SCALEFORM_MOVIE_METHOD, just a hud component id instead of a Scaleform.

Known components:
19 - MP_RANK_BAR
20 - HUD_DIRECTOR_MODE

This native requires more research - all information can be found inside of 'hud.gfx'. Using a decompiler, the different components are located under "scripts\__Packages\com\rockstargames\gtav\hud\hudComponents" and "scripts\__Packages\com\rockstargames\gtav\Multiplayer".
```

---

### BEGIN_TAKE_HIGH_QUALITY_PHOTO

- **命名空间:** `GRAPHICS`
- **Hash:** `0xA67C35C56EB1BD9D`
- **JHash:** `0x47B0C137`
- **Build:** `323`

**C# 签名:**
```csharp
bool BEGIN_TAKE_HIGH_QUALITY_PHOTO()
```

**返回值:** `bool` (Native: `BOOL`)

---

### BEGIN_TAKE_MISSION_CREATOR_PHOTO

- **命名空间:** `GRAPHICS`
- **Hash:** `0x1DD2139A9A20DCE8`
- **JHash:** `0xBA9AD458`
- **Build:** `323`

**C# 签名:**
```csharp
bool BEGIN_TAKE_MISSION_CREATOR_PHOTO()
```

**返回值:** `bool` (Native: `BOOL`)

---

### BEGIN_TEXT_COMMAND_SCALEFORM_STRING

- **命名空间:** `GRAPHICS`
- **Hash:** `0x80338406F3475E55`
- **JHash:** `0x3AC9CB55`
- **Build:** `323`

**C# 签名:**
```csharp
void BEGIN_TEXT_COMMAND_SCALEFORM_STRING(string componentType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `componentType` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Called prior to adding a text component to the UI. After doing so, GRAPHICS::END_TEXT_COMMAND_SCALEFORM_STRING is called.

Examples:
GRAPHICS::BEGIN_TEXT_COMMAND_SCALEFORM_STRING("NUMBER");
HUD::ADD_TEXT_COMPONENT_INTEGER(MISC::ABSI(a_1));
GRAPHICS::END_TEXT_COMMAND_SCALEFORM_STRING();

GRAPHICS::BEGIN_TEXT_COMMAND_SCALEFORM_STRING("STRING");
HUD::ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME(a_2);
GRAPHICS::END_TEXT_COMMAND_SCALEFORM_STRING();

GRAPHICS::BEGIN_TEXT_COMMAND_SCALEFORM_STRING("STRTNM2");
HUD::ADD_TEXT_COMPONENT_SUBSTRING_TEXT_LABEL_HASH_KEY(v_3);
HUD::ADD_TEXT_COMPONENT_SUBSTRING_TEXT_LABEL_HASH_KEY(v_4);
GRAPHICS::END_TEXT_COMMAND_SCALEFORM_STRING();

GRAPHICS::BEGIN_TEXT_COMMAND_SCALEFORM_STRING("STRTNM1");
HUD::ADD_TEXT_COMPONENT_SUBSTRING_TEXT_LABEL_HASH_KEY(v_3);
GRAPHICS::END_TEXT_COMMAND_SCALEFORM_STRING();
```

---

### CALL_SCALEFORM_MOVIE_METHOD

- **命名空间:** `GRAPHICS`
- **Hash:** `0xFBD96D87AC96D533`
- **JHash:** `0x7AB77B57`
- **Build:** `323`

**C# 签名:**
```csharp
void CALL_SCALEFORM_MOVIE_METHOD(int scaleform, string method)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleform` | `int` | `int` | - |
| `method` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Calls the Scaleform function.
```

---

### CALL_SCALEFORM_MOVIE_METHOD_WITH_NUMBER

- **命名空间:** `GRAPHICS`
- **Hash:** `0xD0837058AE2E4BEE`
- **JHash:** `0x557EDA1D`
- **Build:** `323`

**C# 签名:**
```csharp
void CALL_SCALEFORM_MOVIE_METHOD_WITH_NUMBER(int scaleform, string methodName, float param1, float param2, float param3, float param4, float param5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleform` | `int` | `int` | - |
| `methodName` | `const char*` | `string` | - |
| `param1` | `float` | `float` | - |
| `param2` | `float` | `float` | - |
| `param3` | `float` | `float` | - |
| `param4` | `float` | `float` | - |
| `param5` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Calls the Scaleform function and passes the parameters as floats.

The number of parameters passed to the function varies, so the end of the parameter list is represented by -1.0.
```

---

### CALL_SCALEFORM_MOVIE_METHOD_WITH_NUMBER_AND_STRING

- **命名空间:** `GRAPHICS`
- **Hash:** `0xEF662D8D57E290B1`
- **JHash:** `0x6EAF56DE`
- **Build:** `323`

**C# 签名:**
```csharp
void CALL_SCALEFORM_MOVIE_METHOD_WITH_NUMBER_AND_STRING(int scaleform, string methodName, float floatParam1, float floatParam2, float floatParam3, float floatParam4, float floatParam5, string stringParam1, string stringParam2, string stringParam3, string stringParam4, string stringParam5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleform` | `int` | `int` | - |
| `methodName` | `const char*` | `string` | - |
| `floatParam1` | `float` | `float` | - |
| `floatParam2` | `float` | `float` | - |
| `floatParam3` | `float` | `float` | - |
| `floatParam4` | `float` | `float` | - |
| `floatParam5` | `float` | `float` | - |
| `stringParam1` | `const char*` | `string` | - |
| `stringParam2` | `const char*` | `string` | - |
| `stringParam3` | `const char*` | `string` | - |
| `stringParam4` | `const char*` | `string` | - |
| `stringParam5` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Calls the Scaleform function and passes both float and string parameters (in their respective order).

The number of parameters passed to the function varies, so the end of the float parameters is represented by -1.0, and the end of the string parameters is represented by 0 (NULL).

NOTE: The order of parameters in the function prototype is important! All float parameters must come first, followed by the string parameters.

Examples:
// function MY_FUNCTION(floatParam1, floatParam2, stringParam)
GRAPHICS::CALL_SCALEFORM_MOVIE_METHOD_WITH_NUMBER_AND_STRING(scaleform, "MY_FUNCTION", 10.0, 20.0, -1.0, -1.0, -1.0, "String param", 0, 0, 0, 0);

// function MY_FUNCTION_2(floatParam, stringParam1, stringParam2)
GRAPHICS::CALL_SCALEFORM_MOVIE_METHOD_WITH_NUMBER_AND_STRING(scaleform, "MY_FUNCTION_2", 10.0, -1.0, -1.0, -1.0, -1.0, "String param #1", "String param #2", 0, 0, 0);
```

---

### CALL_SCALEFORM_MOVIE_METHOD_WITH_STRING

- **命名空间:** `GRAPHICS`
- **Hash:** `0x51BC1ED3CC44E8F7`
- **JHash:** `0x91A7FCEB`
- **Build:** `323`

**C# 签名:**
```csharp
void CALL_SCALEFORM_MOVIE_METHOD_WITH_STRING(int scaleform, string methodName, string param1, string param2, string param3, string param4, string param5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleform` | `int` | `int` | - |
| `methodName` | `const char*` | `string` | - |
| `param1` | `const char*` | `string` | - |
| `param2` | `const char*` | `string` | - |
| `param3` | `const char*` | `string` | - |
| `param4` | `const char*` | `string` | - |
| `param5` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Calls the Scaleform function and passes the parameters as strings.

The number of parameters passed to the function varies, so the end of the parameter list is represented by 0 (NULL).
```

---

### CAN_REQUEST_ASSETS_FOR_CUTSCENE_ENTITY

- **命名空间:** `CUTSCENE`
- **Hash:** `0xB56BBBCC2955D9CB`
- **JHash:** `0xDD8878E9`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_REQUEST_ASSETS_FOR_CUTSCENE_ENTITY()
```

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_SET_ENTER_STATE_FOR_REGISTERED_ENTITY

- **命名空间:** `CUTSCENE`
- **Hash:** `0x645D0B458D8E17B5`
- **JHash:** `0x55C30B26`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_SET_ENTER_STATE_FOR_REGISTERED_ENTITY(string cutsceneEntName, uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cutsceneEntName` | `const char*` | `string` | - |
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
modelHash (p1) was always 0 in R* scripts
```

---

### CAN_SET_EXIT_STATE_FOR_CAMERA

- **命名空间:** `CUTSCENE`
- **Hash:** `0xB2CBCD0930DFB420`
- **JHash:** `0xEDAE6C02`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_SET_EXIT_STATE_FOR_CAMERA(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_SET_EXIT_STATE_FOR_REGISTERED_ENTITY

- **命名空间:** `CUTSCENE`
- **Hash:** `0x4C6A6451C79E4662`
- **JHash:** `0x8FF5D3C4`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_SET_EXIT_STATE_FOR_REGISTERED_ENTITY(string cutsceneEntName, uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cutsceneEntName` | `const char*` | `string` | - |
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CAN_USE_MOBILE_PHONE_DURING_CUTSCENE

- **命名空间:** `CUTSCENE`
- **Hash:** `0x5EDEF0CF8C1DAB3C`
- **JHash:** `0xDBD88708`
- **Build:** `323`

**C# 签名:**
```csharp
bool CAN_USE_MOBILE_PHONE_DURING_CUTSCENE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### CASCADE_SHADOWS_CLEAR_SHADOW_SAMPLE_TYPE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x27CB772218215325`
- **Build:** `323`

**C# 签名:**
```csharp
void CASCADE_SHADOWS_CLEAR_SHADOW_SAMPLE_TYPE()
```

**返回值:** `void` (Native: `void`)

---

### CASCADE_SHADOWS_ENABLE_ENTITY_TRACKER

- **命名空间:** `GRAPHICS`
- **Hash:** `0x80ECBC0C856D3B0B`
- **JHash:** `0xFE903D0F`
- **Build:** `323`

**C# 签名:**
```csharp
void CASCADE_SHADOWS_ENABLE_ENTITY_TRACKER(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
When this is set to ON, shadows only draw as you get nearer.

When OFF, they draw from a further distance.
```

---

### CASCADE_SHADOWS_ENABLE_FREEZER

- **命名空间:** `GRAPHICS`
- **Hash:** `0x0AE73D8DF3A762B2`
- **JHash:** `0x342FA2B4`
- **Build:** `323`

**C# 签名:**
```csharp
void CASCADE_SHADOWS_ENABLE_FREEZER(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### CASCADE_SHADOWS_INIT_SESSION

- **命名空间:** `GRAPHICS`
- **Hash:** `0x03FC694AE06C5A20`
- **JHash:** `0x48F16186`
- **Build:** `323`

**C# 签名:**
```csharp
void CASCADE_SHADOWS_INIT_SESSION()
```

**返回值:** `void` (Native: `void`)

---

### CASCADE_SHADOWS_SET_AIRCRAFT_MODE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x6DDBF9DFFC4AC080`
- **JHash:** `0x9F470BE3`
- **Build:** `323`

**C# 签名:**
```csharp
void CASCADE_SHADOWS_SET_AIRCRAFT_MODE(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### CASCADE_SHADOWS_SET_BOUND_POSITION

- **命名空间:** `GRAPHICS`
- **Hash:** `0x259BA6D4E6F808F1`
- **Build:** `1011`

**C# 签名:**
```csharp
void CASCADE_SHADOWS_SET_BOUND_POSITION(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### CASCADE_SHADOWS_SET_CASCADE_BOUNDS

- **命名空间:** `GRAPHICS`
- **Hash:** `0xD2936CAB8B58FCBD`
- **JHash:** `0x84F05943`
- **Build:** `323`

**C# 签名:**
```csharp
void CASCADE_SHADOWS_SET_CASCADE_BOUNDS(object p0, bool p1, float p2, float p3, float p4, float p5, bool p6, float p7)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `float` | `float` | - |
| `p5` | `float` | `float` | - |
| `p6` | `BOOL` | `bool` | - |
| `p7` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### CASCADE_SHADOWS_SET_CASCADE_BOUNDS_SCALE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x5F0F3F56635809EF`
- **JHash:** `0x13D4ABC0`
- **Build:** `323`

**C# 签名:**
```csharp
void CASCADE_SHADOWS_SET_CASCADE_BOUNDS_SCALE(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### CASCADE_SHADOWS_SET_DYNAMIC_DEPTH_MODE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xD39D13C9FEBF0511`
- **JHash:** `0x4A124267`
- **Build:** `323`

**C# 签名:**
```csharp
void CASCADE_SHADOWS_SET_DYNAMIC_DEPTH_MODE(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### CASCADE_SHADOWS_SET_DYNAMIC_DEPTH_VALUE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x02AC28F3A01FA04A`
- **JHash:** `0xB19B2764`
- **Build:** `323`

**C# 签名:**
```csharp
void CASCADE_SHADOWS_SET_DYNAMIC_DEPTH_VALUE(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### CASCADE_SHADOWS_SET_ENTITY_TRACKER_SCALE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x5E9DAF5A20F15908`
- **JHash:** `0xD2157428`
- **Build:** `323`

**C# 签名:**
```csharp
void CASCADE_SHADOWS_SET_ENTITY_TRACKER_SCALE(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### CASCADE_SHADOWS_SET_SCREEN_SIZE_CHECK_ENABLED

- **命名空间:** `GRAPHICS`
- **Hash:** `0x25FC3E33A31AD0C9`
- **Build:** `323`

**C# 签名:**
```csharp
void CASCADE_SHADOWS_SET_SCREEN_SIZE_CHECK_ENABLED(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### CASCADE_SHADOWS_SET_SHADOW_SAMPLE_TYPE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xB11D94BC55F41932`
- **JHash:** `0xDE10BA1F`
- **Build:** `323`

**C# 签名:**
```csharp
void CASCADE_SHADOWS_SET_SHADOW_SAMPLE_TYPE(string type)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `type` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Possible values:
"CSM_ST_POINT"
"CSM_ST_LINEAR"
"CSM_ST_TWOTAP"
"CSM_ST_BOX3x3"
"CSM_ST_BOX4x4"
"CSM_ST_DITHER2_LINEAR"
"CSM_ST_CUBIC"
"CSM_ST_DITHER4"
"CSM_ST_DITHER16"
"CSM_ST_SOFT16"
"CSM_ST_DITHER16_RPDB"
"CSM_ST_POISSON16_RPDB_GNORM"
"CSM_ST_HIGHRES_BOX4x4"
"CSM_ST_CLOUDS_SIMPLE"
"CSM_ST_CLOUDS_LINEAR"
"CSM_ST_CLOUDS_TWOTAP"
"CSM_ST_CLOUDS_BOX3x3"
"CSM_ST_CLOUDS_BOX4x4"
"CSM_ST_CLOUDS_DITHER2_LINEAR"
"CSM_ST_CLOUDS_SOFT16"
"CSM_ST_CLOUDS_DITHER16_RPDB"
"CSM_ST_CLOUDS_POISSON16_RPDB_GNORM"
```

---

### CASCADE_SHADOWS_SET_SPLIT_Z_EXP_WEIGHT

- **命名空间:** `GRAPHICS`
- **Hash:** `0x36F6626459D91457`
- **JHash:** `0xC07C64C9`
- **Build:** `323`

**C# 签名:**
```csharp
void CASCADE_SHADOWS_SET_SPLIT_Z_EXP_WEIGHT(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_ALL_TCMODIFIER_OVERRIDES

- **命名空间:** `GRAPHICS`
- **Hash:** `0x15E33297C3E8DC60`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_ALL_TCMODIFIER_OVERRIDES(string p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### CLEAR_DRAW_ORIGIN

- **命名空间:** `GRAPHICS`
- **Hash:** `0xFF0B610F6BE0D7AF`
- **JHash:** `0xDD76B263`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_DRAW_ORIGIN()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Resets the screen's draw-origin which was changed by the function GRAPHICS::SET_DRAW_ORIGIN(...) back to x=0,y=0.

See GRAPHICS::SET_DRAW_ORIGIN(...) for further information.
```

---

### CLEAR_EXTRA_TCMODIFIER

- **命名空间:** `GRAPHICS`
- **Hash:** `0x92CCC17A7A2285DA`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_EXTRA_TCMODIFIER()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Clears the secondary timecycle modifier usually set with _SET_EXTRA_TIMECYCLE_MODIFIER
```

---

### CLEAR_PARTICLE_FX_SHOOTOUT_BOAT

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2A251AA48B2B46DB`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_PARTICLE_FX_SHOOTOUT_BOAT()
```

**返回值:** `void` (Native: `void`)

---

### CLEAR_STATUS_OF_SORTED_LIST_OPERATION

- **命名空间:** `GRAPHICS`
- **Hash:** `0x4AF92ACD3141D96C`
- **JHash:** `0xC9EF81ED`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_STATUS_OF_SORTED_LIST_OPERATION()
```

**返回值:** `void` (Native: `void`)

---

### CLEAR_TIMECYCLE_MODIFIER

- **命名空间:** `GRAPHICS`
- **Hash:** `0x0F07E7745A236711`
- **JHash:** `0x8D8DF8EE`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_TIMECYCLE_MODIFIER()
```

**返回值:** `void` (Native: `void`)

---

### CLEAR_TV_CHANNEL_PLAYLIST

- **命名空间:** `GRAPHICS`
- **Hash:** `0xBEB3D46BB7F043C0`
- **JHash:** `0xCBE7068F`
- **Build:** `323`

**C# 签名:**
```csharp
void CLEAR_TV_CHANNEL_PLAYLIST(int tvChannel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `tvChannel` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### CREATE_CHECKPOINT

- **命名空间:** `GRAPHICS`
- **Hash:** `0x0134F0835AB6BFCB`
- **JHash:** `0xF541B690`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_CHECKPOINT(int type, float posX1, float posY1, float posZ1, float posX2, float posY2, float posZ2, float diameter, int red, int green, int blue, int alpha, int reserved)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `type` | `int` | `int` | - |
| `posX1` | `float` | `float` | - |
| `posY1` | `float` | `float` | - |
| `posZ1` | `float` | `float` | - |
| `posX2` | `float` | `float` | - |
| `posY2` | `float` | `float` | - |
| `posZ2` | `float` | `float` | - |
| `diameter` | `float` | `float` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |
| `reserved` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Creates a checkpoint. Returns the handle of the checkpoint.

20/03/17 : Attention, checkpoints are already handled by the game itself, so you must not loop it like markers.

Parameters:
* type - The type of checkpoint to create. See below for a list of checkpoint types.
* pos1 - The position of the checkpoint.
* pos2 - The position of the next checkpoint to point to.
* radius - The radius of the checkpoint.
* color - The color of the checkpoint.
* reserved - Special parameter, see below for details. Usually set to 0 in the scripts.

Checkpoint types:
0-4---------Cylinder: 1 arrow, 2 arrow, 3 arrows, CycleArrow, Checker
5-9---------Cylinder: 1 arrow, 2 arrow, 3 arrows, CycleArrow, Checker
10-14-------Ring: 1 arrow, 2 arrow, 3 arrows, CycleArrow, Checker
15-19-------1 arrow, 2 arrow, 3 arrows, CycleArrow, Checker      
20-24-------Cylinder: 1 arrow, 2 arrow, 3 arrows, CycleArrow, Checker 
25-29-------Cylinder: 1 arrow, 2 arrow, 3 arrows, CycleArrow, Checker    
30-34-------Cylinder: 1 arrow, 2 arrow, 3 arrows, CycleArrow, Checker 
35-38-------Ring: Airplane Up, Left, Right, UpsideDown
39----------?
40----------Ring: just a ring
41----------?
42-44-------Cylinder w/ number (uses 'reserved' parameter)
45-47-------Cylinder no arrow or number

If using type 42-44, reserved sets number / number and shape to display

0-99------------Just numbers (0-99)
100-109-----------------Arrow (0-9)
110-119------------Two arrows (0-9)
120-129----------Three arrows (0-9)
130-139----------------Circle (0-9)
140-149------------CycleArrow (0-9)
150-159----------------Circle (0-9)
160-169----Circle  w/ pointer (0-9)
170-179-------Perforated ring (0-9)
180-189----------------Sphere (0-9)
```

---

### CREATE_TRACKED_POINT

- **命名空间:** `GRAPHICS`
- **Hash:** `0xE2C9439ED45DEA60`
- **JHash:** `0x3129C31A`
- **Build:** `323`

**C# 签名:**
```csharp
int CREATE_TRACKED_POINT()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Creates a tracked point, useful for checking the visibility of a 3D point on screen.
```

---

### DELETE_CHECKPOINT

- **命名空间:** `GRAPHICS`
- **Hash:** `0xF5ED37F54CD4D52E`
- **JHash:** `0xB66CF3CA`
- **Build:** `323`

**C# 签名:**
```csharp
void DELETE_CHECKPOINT(int checkpoint)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `checkpoint` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DESTROY_TRACKED_POINT

- **命名空间:** `GRAPHICS`
- **Hash:** `0xB25DC90BAD56CA42`
- **JHash:** `0x14AC675F`
- **Build:** `323`

**C# 签名:**
```csharp
void DESTROY_TRACKED_POINT(int point)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `point` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DISABLE_COMPOSITE_SHOTGUN_DECALS

- **命名空间:** `GRAPHICS`
- **Hash:** `0x0E4299C549F0D1F1`
- **JHash:** `0x9BABCBA4`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_COMPOSITE_SHOTGUN_DECALS(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### DISABLE_DOWNWASH_PTFX

- **命名空间:** `GRAPHICS`
- **Hash:** `0x5F6DF3D92271E8A1`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_DOWNWASH_PTFX(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### DISABLE_HDTEX_THIS_FRAME

- **命名空间:** `GRAPHICS`
- **Hash:** `0xC35A6D07C93802B2`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_HDTEX_THIS_FRAME()
```

**返回值:** `void` (Native: `void`)

---

### DISABLE_IN_WATER_PTFX

- **命名空间:** `GRAPHICS`
- **Hash:** `0xCFD16F0DB5A3535C`
- **Build:** `2060`

**C# 签名:**
```csharp
void DISABLE_IN_WATER_PTFX(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### DISABLE_MOON_CYCLE_OVERRIDE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2BF72AD5B41AA739`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_MOON_CYCLE_OVERRIDE()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Resets the extra timecycle modifier strength normally set with 0x2C328AF17210F009
```

---

### DISABLE_OCCLUSION_THIS_FRAME

- **命名空间:** `GRAPHICS`
- **Hash:** `0x3669F1B198DCAA4F`
- **JHash:** `0x0DCC0B8B`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_OCCLUSION_THIS_FRAME()
```

**返回值:** `void` (Native: `void`)

---

### DISABLE_PROCOBJ_CREATION

- **命名空间:** `GRAPHICS`
- **Hash:** `0x1612C45F9E3E0D44`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_PROCOBJ_CREATION()
```

**返回值:** `void` (Native: `void`)

---

### DISABLE_REGION_VFX

- **命名空间:** `GRAPHICS`
- **Hash:** `0xEFD97FF47B745B8D`
- **Build:** `791`

**C# 签名:**
```csharp
void DISABLE_REGION_VFX(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### DISABLE_SCREENBLUR_FADE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xDE81239437E8C5A8`
- **JHash:** `0xDB7AECDA`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_SCREENBLUR_FADE()
```

**返回值:** `void` (Native: `void`)

---

### DISABLE_SCUFF_DECALS

- **命名空间:** `GRAPHICS`
- **Hash:** `0x02369D5C8A51FDCF`
- **JHash:** `0xFDF6D8DA`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_SCUFF_DECALS(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### DISABLE_VEHICLE_DISTANTLIGHTS

- **命名空间:** `GRAPHICS`
- **Hash:** `0xC9F98AC1884E73A2`
- **JHash:** `0x7CFAE36F`
- **Build:** `323`

**C# 签名:**
```csharp
void DISABLE_VEHICLE_DISTANTLIGHTS(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### DOES_CUTSCENE_ENTITY_EXIST

- **命名空间:** `CUTSCENE`
- **Hash:** `0x499EF20C5DB25C59`
- **JHash:** `0x58E67409`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_CUTSCENE_ENTITY_EXIST(string cutsceneEntName, uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cutsceneEntName` | `const char*` | `string` | - |
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DOES_CUTSCENE_HANDLE_EXIST

- **命名空间:** `CUTSCENE`
- **Hash:** `0x4FCD976DA686580C`
- **Build:** `1290`

**C# 签名:**
```csharp
int DOES_CUTSCENE_HANDLE_EXIST(int cutsceneHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cutsceneHandle` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### DOES_LATEST_BRIEF_STRING_EXIST

- **命名空间:** `GRAPHICS`
- **Hash:** `0x5E657EF1099EDD65`
- **JHash:** `0x91A081A1`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_LATEST_BRIEF_STRING_EXIST(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DOES_PARTICLE_FX_LOOPED_EXIST

- **命名空间:** `GRAPHICS`
- **Hash:** `0x74AFEF0D2E1E409B`
- **JHash:** `0xCBF91D2A`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_PARTICLE_FX_LOOPED_EXIST(int ptfxHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ptfxHandle` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DOES_THIS_PHOTO_SLOT_CONTAIN_A_VALID_PHOTO

- **命名空间:** `GRAPHICS`
- **Hash:** `0xE791DF1F73ED2C8B`
- **JHash:** `0x9D84554C`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_THIS_PHOTO_SLOT_CONTAIN_A_VALID_PHOTO(object p0)
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

### DOES_VEHICLE_HAVE_CREW_EMBLEM

- **命名空间:** `GRAPHICS`
- **Hash:** `0x060D935D3981A275`
- **JHash:** `0x6D58F73B`
- **Build:** `323`

**C# 签名:**
```csharp
bool DOES_VEHICLE_HAVE_CREW_EMBLEM(int vehicle, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### DONT_RENDER_IN_GAME_UI

- **命名空间:** `GRAPHICS`
- **Hash:** `0x22A249A53034450A`
- **JHash:** `0x932FDB81`
- **Build:** `323`

**C# 签名:**
```csharp
void DONT_RENDER_IN_GAME_UI(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### DRAW_BINK_MOVIE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x7118E83EEB9F7238`
- **Build:** `1290`

**C# 签名:**
```csharp
void DRAW_BINK_MOVIE(int binkMovie, float p1, float p2, float p3, float p4, float p5, int r, int g, int b, int a)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `binkMovie` | `int` | `int` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `float` | `float` | - |
| `p5` | `float` | `float` | - |
| `r` | `int` | `int` | - |
| `g` | `int` | `int` | - |
| `b` | `int` | `int` | - |
| `a` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DRAW_BOX

- **命名空间:** `GRAPHICS`
- **Hash:** `0xD3A9971CADAC7252`
- **JHash:** `0xCD4D9DD5`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_BOX(float x1, float y1, float z1, float x2, float y2, float z2, int red, int green, int blue, int alpha)
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
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
x,y,z = start pos
x2,y2,z2 = end pos

Draw's a 3D Box between the two x,y,z coords.
--------------
Keep in mind that the edges of the box do only align to the worlds base-vectors. Therefore something like rotation cannot be applied. That means this function is pretty much useless, unless you want a static unicolor box somewhere.
I recommend using a predefined function to call this.
[VB.NET]
Public Sub DrawBox(a As Vector3, b As Vector3, col As Color)
    [Function].Call(Hash.DRAW_BOX,a.X, a.Y, a.Z,b.X, b.Y, b.Z,col.R, col.G, col.B, col.A)
End Sub

[C#]
public void DrawBox(Vector3 a, Vector3 b, Color col)
{
    Function.Call(Hash.DRAW_BOX,a.X, a.Y, a.Z,b.X, b.Y, b.Z,col.R, col.G, col.B, col.A);
}
```

---

### DRAW_DEBUG_BOX

- **命名空间:** `GRAPHICS`
- **Hash:** `0x083A2CA4F2E573BD`
- **JHash:** `0x8524A848`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_DEBUG_BOX(float x1, float y1, float z1, float x2, float y2, float z2, int r, int g, int b, int alpha)
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
| `r` | `int` | `int` | - |
| `g` | `int` | `int` | - |
| `b` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DRAW_DEBUG_CROSS

- **命名空间:** `GRAPHICS`
- **Hash:** `0x73B1189623049839`
- **JHash:** `0xB6DF3709`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_DEBUG_CROSS(float x, float y, float z, float size, int red, int green, int blue, int alpha)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `size` | `float` | `float` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
NOTE: Debugging functions are not present in the retail version of the game.
```

---

### DRAW_DEBUG_LINE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x7FDFADE676AA3CB0`
- **JHash:** `0xABF783AB`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_DEBUG_LINE(float x1, float y1, float z1, float x2, float y2, float z2, int r, int g, int b, int alpha)
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
| `r` | `int` | `int` | - |
| `g` | `int` | `int` | - |
| `b` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DRAW_DEBUG_LINE_WITH_TWO_COLOURS

- **命名空间:** `GRAPHICS`
- **Hash:** `0xD8B9A8AC5608FF94`
- **JHash:** `0xE8BFF632`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_DEBUG_LINE_WITH_TWO_COLOURS(float x1, float y1, float z1, float x2, float y2, float z2, int r1, int g1, int b1, int r2, int g2, int b2, int alpha1, int alpha2)
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
| `r1` | `int` | `int` | - |
| `g1` | `int` | `int` | - |
| `b1` | `int` | `int` | - |
| `r2` | `int` | `int` | - |
| `g2` | `int` | `int` | - |
| `b2` | `int` | `int` | - |
| `alpha1` | `int` | `int` | - |
| `alpha2` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
NOTE: Debugging functions are not present in the retail version of the game.
```

---

### DRAW_DEBUG_SPHERE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xAAD68E1AB39DA632`
- **JHash:** `0x304D0EEF`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_DEBUG_SPHERE(float x, float y, float z, float radius, int red, int green, int blue, int alpha)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
NOTE: Debugging functions are not present in the retail version of the game.
```

---

### DRAW_DEBUG_TEXT

- **命名空间:** `GRAPHICS`
- **Hash:** `0x3903E216620488E8`
- **JHash:** `0x269B006F`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_DEBUG_TEXT(string text, float x, float y, float z, int red, int green, int blue, int alpha)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `text` | `const char*` | `string` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
NOTE: Debugging functions are not present in the retail version of the game.
```

---

### DRAW_DEBUG_TEXT_2D

- **命名空间:** `GRAPHICS`
- **Hash:** `0xA3BB2E9555C05A8F`
- **JHash:** `0x528B973B`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_DEBUG_TEXT_2D(string text, float x, float y, float z, int red, int green, int blue, int alpha)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `text` | `const char*` | `string` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
NOTE: Debugging functions are not present in the retail version of the game.
```

---

### DRAW_LIGHT_WITH_RANGE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xF2A1B2771A01DBD4`
- **JHash:** `0x6A396E9A`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_LIGHT_WITH_RANGE(float posX, float posY, float posZ, int colorR, int colorG, int colorB, float range, float intensity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `colorR` | `int` | `int` | - |
| `colorG` | `int` | `int` | - |
| `colorB` | `int` | `int` | - |
| `range` | `float` | `float` | - |
| `intensity` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### DRAW_LIGHT_WITH_RANGEEX

- **命名空间:** `GRAPHICS`
- **Hash:** `0xF49E9A9716A04595`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_LIGHT_WITH_RANGEEX(float x, float y, float z, int r, int g, int b, float range, float intensity, float shadow)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `r` | `int` | `int` | - |
| `g` | `int` | `int` | - |
| `b` | `int` | `int` | - |
| `range` | `float` | `float` | - |
| `intensity` | `float` | `float` | - |
| `shadow` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### DRAW_LINE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x6B7256074AE34680`
- **JHash:** `0xB3426BCC`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_LINE(float x1, float y1, float z1, float x2, float y2, float z2, int red, int green, int blue, int alpha)
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
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Draws a depth-tested line from one point to another.
----------------
x1, y1, z1 : Coordinates for the first point
x2, y2, z2 : Coordinates for the second point
r, g, b, alpha : Color with RGBA-Values
I recommend using a predefined function to call this.
[VB.NET]
Public Sub DrawLine(from As Vector3, [to] As Vector3, col As Color)
    [Function].Call(Hash.DRAW_LINE, from.X, from.Y, from.Z, [to].X, [to].Y, [to].Z, col.R, col.G, col.B, col.A)
End Sub

[C#]
public void DrawLine(Vector3 from, Vector3 to, Color col)
{
    Function.Call(Hash.DRAW_LINE, from.X, from.Y, from.Z, to.X, to.Y, to.Z, col.R, col.G, col.B, col.A);
}
```

---

### DRAW_LOW_QUALITY_PHOTO_TO_PHONE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x1072F115DAB0717E`
- **JHash:** `0xE9F2B68F`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_LOW_QUALITY_PHOTO_TO_PHONE(bool p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### DRAW_MARKER

- **命名空间:** `GRAPHICS`
- **Hash:** `0x28477EC23D892089`
- **JHash:** `0x48D84A02`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_MARKER(int type, float posX, float posY, float posZ, float dirX, float dirY, float dirZ, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ, int red, int green, int blue, int alpha, bool bobUpAndDown, bool faceCamera, int p19, bool rotate, string textureDict, string textureName, bool drawOnEnts)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `type` | `int` | `int` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `dirX` | `float` | `float` | - |
| `dirY` | `float` | `float` | - |
| `dirZ` | `float` | `float` | - |
| `rotX` | `float` | `float` | - |
| `rotY` | `float` | `float` | - |
| `rotZ` | `float` | `float` | - |
| `scaleX` | `float` | `float` | - |
| `scaleY` | `float` | `float` | - |
| `scaleZ` | `float` | `float` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |
| `bobUpAndDown` | `BOOL` | `bool` | - |
| `faceCamera` | `BOOL` | `bool` | - |
| `p19` | `int` | `int` | - |
| `rotate` | `BOOL` | `bool` | - |
| `textureDict` | `const char*` | `string` | - |
| `textureName` | `const char*` | `string` | - |
| `drawOnEnts` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
enum MarkerTypes
{
    MarkerTypeUpsideDownCone = 0,
 MarkerTypeVerticalCylinder = 1,
   MarkerTypeThickChevronUp = 2,
 MarkerTypeThinChevronUp = 3,
  MarkerTypeCheckeredFlagRect = 4,
  MarkerTypeCheckeredFlagCircle = 5,
    MarkerTypeVerticleCircle = 6,
 MarkerTypePlaneModel = 7,
 MarkerTypeLostMCDark = 8,
 MarkerTypeLostMCLight = 9,
    MarkerTypeNumber0 = 10,
   MarkerTypeNumber1 = 11,
   MarkerTypeNumber2 = 12,
   MarkerTypeNumber3 = 13,
   MarkerTypeNumber4 = 14,
   MarkerTypeNumber5 = 15,
   MarkerTypeNumber6 = 16,
   MarkerTypeNumber7 = 17,
   MarkerTypeNumber8 = 18,
   MarkerTypeNumber9 = 19,
   MarkerTypeChevronUpx1 = 20,
   MarkerTypeChevronUpx2 = 21,
   MarkerTypeChevronUpx3 = 22,
   MarkerTypeHorizontalCircleFat = 23,
   MarkerTypeReplayIcon = 24,
    MarkerTypeHorizontalCircleSkinny = 25,
    MarkerTypeHorizontalCircleSkinny_Arrow = 26,
  MarkerTypeHorizontalSplitArrowCircle = 27,
    MarkerTypeDebugSphere = 28,
   MarkerTypeDallorSign = 29,
    MarkerTypeHorizontalBars = 30,
    MarkerTypeWolfHead = 31
};

dirX/Y/Z represent a heading on each axis in which the marker should face, alternatively you can rotate each axis independently with rotX/Y/Z (and set dirX/Y/Z all to 0).

faceCamera - Rotates only the y-axis (the heading) towards the camera

p19 - no effect, default value in script is 2

rotate - Rotates only on the y-axis (the heading)

textureDict - Name of texture dictionary to load texture from (e.g. "GolfPutting")

textureName - Name of texture inside dictionary to load (e.g. "PuttingMarker")

drawOnEnts - Draws the marker onto any entities that intersect it

basically what he said, except textureDict and textureName are totally not const char*, or if so, then they are always set to 0/NULL/nullptr in every script I checked, eg:

bj.c: graphics::draw_marker(6, vParam0, 0f, 0f, 1f, 0f, 0f, 0f, 4f, 4f, 4f, 240, 200, 80, iVar1, 0, 0, 2, 0, 0, 0, false);

his is what I used to draw an amber downward pointing chevron "V", has to be redrawn every frame.  The 180 is for 180 degrees rotation around the Y axis, the 50 is alpha, assuming max is 100, but it will accept 255.

GRAPHICS::DRAW_MARKER(2, v.x, v.y, v.z + 2, 0, 0, 0, 0, 180, 0, 2, 2, 2, 255, 128, 0, 50, 0, 1, 1, 0, 0, 0, 0);


```

---

### DRAW_MARKER_EX

- **命名空间:** `GRAPHICS`
- **Hash:** `0xE82728F0DE75D13A`
- **Build:** `573`

**C# 签名:**
```csharp
void DRAW_MARKER_EX(int type, float posX, float posY, float posZ, float dirX, float dirY, float dirZ, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ, int red, int green, int blue, int alpha, bool bobUpAndDown, bool faceCamera, object p19, bool rotate, string textureDict, string textureName, bool drawOnEnts, bool p24, bool p25)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `type` | `int` | `int` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `dirX` | `float` | `float` | - |
| `dirY` | `float` | `float` | - |
| `dirZ` | `float` | `float` | - |
| `rotX` | `float` | `float` | - |
| `rotY` | `float` | `float` | - |
| `rotZ` | `float` | `float` | - |
| `scaleX` | `float` | `float` | - |
| `scaleY` | `float` | `float` | - |
| `scaleZ` | `float` | `float` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |
| `bobUpAndDown` | `BOOL` | `bool` | - |
| `faceCamera` | `BOOL` | `bool` | - |
| `p19` | `Any` | `object` | - |
| `rotate` | `BOOL` | `bool` | - |
| `textureDict` | `const char*` | `string` | - |
| `textureName` | `const char*` | `string` | - |
| `drawOnEnts` | `BOOL` | `bool` | - |
| `p24` | `BOOL` | `bool` | - |
| `p25` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### DRAW_MARKER_SPHERE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x799017F9E3B10112`
- **Build:** `463`

**C# 签名:**
```csharp
void DRAW_MARKER_SPHERE(float x, float y, float z, float radius, int red, int green, int blue, float alpha)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Draws a 3D sphere, typically seen in the GTA:O freemode event "Penned In".
Example https://imgur.com/nCbtS4H

alpha - The alpha for the sphere. Goes from 0.0 to 1.0.
```

---

### DRAW_POLY

- **命名空间:** `GRAPHICS`
- **Hash:** `0xAC26716048436851`
- **JHash:** `0xABD19253`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_POLY(float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, int red, int green, int blue, int alpha)
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
| `x3` | `float` | `float` | - |
| `y3` | `float` | `float` | - |
| `z3` | `float` | `float` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
x/y/z - Location of a vertex (in world coords), presumably.
----------------
x1, y1, z1     : Coordinates for the first point
x2, y2, z2     : Coordinates for the second point
x3, y3, z3     : Coordinates for the third point
r, g, b, alpha : Color with RGBA-Values

Keep in mind that only one side of the drawn triangle is visible: It's the side, in which the vector-product of the vectors heads to: (b-a)x(c-a) Or (b-a)x(c-b).
But be aware: The function seems to work somehow differently. I have trouble having them drawn in rotated orientation. Try it yourself and if you somehow succeed, please edit this and post your solution.
I recommend using a predefined function to call this.
[VB.NET]
Public Sub DrawPoly(a As Vector3, b As Vector3, c As Vector3, col As Color)
    [Function].Call(Hash.DRAW_POLY, a.X, a.Y, a.Z, b.X, b.Y, b.Z, c.X, c.Y, c.Z, col.R, col.G, col.B, col.A)
End Sub

[C#]
public void DrawPoly(Vector3 a, Vector3 b, Vector3 c, Color col)
{
    Function.Call(Hash.DRAW_POLY, a.X, a.Y, a.Z, b.X, b.Y, b.Z, c.X, c.Y, c.Z, col.R, col.G, col.B, col.A);
}
BTW: Intersecting triangles are not supported: They overlap in the order they were called.
```

---

### DRAW_RECT

- **命名空间:** `GRAPHICS`
- **Hash:** `0x3A618A217E5154F0`
- **JHash:** `0xDD2BFC77`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_RECT(float x, float y, float width, float height, int r, int g, int b, int a, bool p8)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `width` | `float` | `float` | - |
| `height` | `float` | `float` | - |
| `r` | `int` | `int` | - |
| `g` | `int` | `int` | - |
| `b` | `int` | `int` | - |
| `a` | `int` | `int` | - |
| `p8` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Draws a rectangle on the screen.

-x: The relative X point of the center of the rectangle. (0.0-1.0, 0.0 is the left edge of the screen, 1.0 is the right edge of the screen)

-y: The relative Y point of the center of the rectangle. (0.0-1.0, 0.0 is the top edge of the screen, 1.0 is the bottom edge of the screen)

-width: The relative width of the rectangle. (0.0-1.0, 1.0 means the whole screen width)

-height: The relative height of the rectangle. (0.0-1.0, 1.0 means the whole screen height)

-R: Red part of the color. (0-255)

-G: Green part of the color. (0-255)

-B: Blue part of the color. (0-255)

-A: Alpha part of the color. (0-255, 0 means totally transparent, 255 means totally opaque)

The total number of rectangles to be drawn in one frame is apparently limited to 399.

```

---

### DRAW_SCALEFORM_MOVIE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x54972ADAF0294A93`
- **JHash:** `0x48DA6A58`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_SCALEFORM_MOVIE(int scaleformHandle, float x, float y, float width, float height, int red, int green, int blue, int alpha, int p9)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleformHandle` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `width` | `float` | `float` | - |
| `height` | `float` | `float` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |
| `p9` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DRAW_SCALEFORM_MOVIE_3D

- **命名空间:** `GRAPHICS`
- **Hash:** `0x87D51D72255D4E78`
- **JHash:** `0xC4F63A89`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_SCALEFORM_MOVIE_3D(int scaleform, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float p7, float p8, float p9, float scaleX, float scaleY, float scaleZ, int rotationOrder)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleform` | `int` | `int` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `rotX` | `float` | `float` | - |
| `rotY` | `float` | `float` | - |
| `rotZ` | `float` | `float` | - |
| `p7` | `float` | `float` | - |
| `p8` | `float` | `float` | - |
| `p9` | `float` | `float` | - |
| `scaleX` | `float` | `float` | - |
| `scaleY` | `float` | `float` | - |
| `scaleZ` | `float` | `float` | - |
| `rotationOrder` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DRAW_SCALEFORM_MOVIE_3D_SOLID

- **命名空间:** `GRAPHICS`
- **Hash:** `0x1CE592FDC749D6F5`
- **JHash:** `0x899933C8`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_SCALEFORM_MOVIE_3D_SOLID(int scaleform, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float p7, float p8, float p9, float scaleX, float scaleY, float scaleZ, int rotationOrder)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleform` | `int` | `int` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `rotX` | `float` | `float` | - |
| `rotY` | `float` | `float` | - |
| `rotZ` | `float` | `float` | - |
| `p7` | `float` | `float` | - |
| `p8` | `float` | `float` | - |
| `p9` | `float` | `float` | - |
| `scaleX` | `float` | `float` | - |
| `scaleY` | `float` | `float` | - |
| `scaleZ` | `float` | `float` | - |
| `rotationOrder` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DRAW_SCALEFORM_MOVIE_FULLSCREEN

- **命名空间:** `GRAPHICS`
- **Hash:** `0x0DF606929C105BE1`
- **JHash:** `0x7B48E696`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_SCALEFORM_MOVIE_FULLSCREEN(int scaleform, int red, int green, int blue, int alpha, int p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleform` | `int` | `int` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |
| `p5` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
unk is not used so no need
```

---

### DRAW_SCALEFORM_MOVIE_FULLSCREEN_MASKED

- **命名空间:** `GRAPHICS`
- **Hash:** `0xCF537FDE4FBD4CE5`
- **JHash:** `0x9C59FC06`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_SCALEFORM_MOVIE_FULLSCREEN_MASKED(int scaleform1, int scaleform2, int red, int green, int blue, int alpha)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleform1` | `int` | `int` | - |
| `scaleform2` | `int` | `int` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DRAW_SHADOWED_SPOT_LIGHT

- **命名空间:** `GRAPHICS`
- **Hash:** `0x5BCA583A583194DB`
- **JHash:** `0x32BF9598`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_SHADOWED_SPOT_LIGHT(float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int colorR, int colorG, int colorB, float distance, float brightness, float roundness, float radius, float falloff, int shadowId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `dirX` | `float` | `float` | - |
| `dirY` | `float` | `float` | - |
| `dirZ` | `float` | `float` | - |
| `colorR` | `int` | `int` | - |
| `colorG` | `int` | `int` | - |
| `colorB` | `int` | `int` | - |
| `distance` | `float` | `float` | - |
| `brightness` | `float` | `float` | - |
| `roundness` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `falloff` | `float` | `float` | - |
| `shadowId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### DRAW_SPOT_LIGHT

- **命名空间:** `GRAPHICS`
- **Hash:** `0xD0F64B265C8C8B33`
- **JHash:** `0xBDBC410C`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_SPOT_LIGHT(float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int colorR, int colorG, int colorB, float distance, float brightness, float hardness, float radius, float falloff)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `dirX` | `float` | `float` | - |
| `dirY` | `float` | `float` | - |
| `dirZ` | `float` | `float` | - |
| `colorR` | `int` | `int` | - |
| `colorG` | `int` | `int` | - |
| `colorB` | `int` | `int` | - |
| `distance` | `float` | `float` | - |
| `brightness` | `float` | `float` | - |
| `hardness` | `float` | `float` | - |
| `radius` | `float` | `float` | - |
| `falloff` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Parameters:
* pos - coordinate where the spotlight is located
* dir - the direction vector the spotlight should aim at from its current position
* r,g,b - color of the spotlight
* distance - the maximum distance the light can reach
* brightness - the brightness of the light
* roundness - "smoothness" of the circle edge
* radius - the radius size of the spotlight
* falloff - the falloff size of the light's edge (example: www.i.imgur.com/DemAWeO.jpg)

Example in C# (spotlight aims at the closest vehicle):
Vector3 myPos = Game.Player.Character.Position;
Vehicle nearest = World.GetClosestVehicle(myPos , 1000f);
Vector3 destinationCoords = nearest.Position;
Vector3 dirVector = destinationCoords - myPos;
dirVector.Normalize();
Function.Call(Hash.DRAW_SPOT_LIGHT, pos.X, pos.Y, pos.Z, dirVector.X, dirVector.Y, dirVector.Z, 255, 255, 255, 100.0f, 1f, 0.0f, 13.0f, 1f);
```

---

### DRAW_SPRITE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xE7FFAE5EBF23D890`
- **JHash:** `0x1FEC16B0`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_SPRITE(string textureDict, string textureName, float screenX, float screenY, float width, float height, float heading, int red, int green, int blue, int alpha, bool p11, object p12)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `textureDict` | `const char*` | `string` | - |
| `textureName` | `const char*` | `string` | - |
| `screenX` | `float` | `float` | - |
| `screenY` | `float` | `float` | - |
| `width` | `float` | `float` | - |
| `height` | `float` | `float` | - |
| `heading` | `float` | `float` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |
| `p11` | `BOOL` | `bool` | - |
| `p12` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Draws a 2D sprite on the screen.

Parameters:
textureDict - Name of texture dictionary to load texture from (e.g. "CommonMenu", "MPWeaponsCommon", etc.)

textureName - Name of texture to load from texture dictionary (e.g. "last_team_standing_icon", "tennis_icon", etc.)

screenX/Y - Screen offset (0.5 = center)
scaleX/Y - Texture scaling. Negative values can be used to flip the texture on that axis. (0.5 = half)

heading - Texture rotation in degrees (default = 0.0) positive is clockwise, measured in degrees

red,green,blue - Sprite color (default = 255/255/255)

alpha - opacity level
```

---

### DRAW_SPRITE_ARX

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2D3B147AFAD49DE0`
- **Build:** `1290`

**C# 签名:**
```csharp
void DRAW_SPRITE_ARX(string textureDict, string textureName, float x, float y, float width, float height, float p6, int red, int green, int blue, int alpha, object p11, object p12)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `textureDict` | `const char*` | `string` | - |
| `textureName` | `const char*` | `string` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `width` | `float` | `float` | - |
| `height` | `float` | `float` | - |
| `p6` | `float` | `float` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |
| `p11` | `Any` | `object` | - |
| `p12` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Used in arcade games and Beam hack minigame in Doomsday Heist. I will most certainly dive into this to try replicate arcade games.
x position must be between 0.0 and 1.0 (1.0 being the most right side of the screen)
y position must be between 0.0 and 1.0 (1.0 being the most bottom side of the screen)
width 0.0 - 1.0 is the reasonable amount generally
height 0.0 - 1.0 is the reasonable amount generally
p6 almost always 0.0
p11 seems to be unknown but almost always 0 int
```

---

### DRAW_SPRITE_ARX_WITH_UV

- **命名空间:** `GRAPHICS`
- **Hash:** `0x95812F9B26074726`
- **Build:** `1868`

**C# 签名:**
```csharp
void DRAW_SPRITE_ARX_WITH_UV(string textureDict, string textureName, float x, float y, float width, float height, float u1, float v1, float u2, float v2, float heading, int red, int green, int blue, int alpha, object p15)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `textureDict` | `const char*` | `string` | - |
| `textureName` | `const char*` | `string` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `width` | `float` | `float` | - |
| `height` | `float` | `float` | - |
| `u1` | `float` | `float` | - |
| `v1` | `float` | `float` | - |
| `u2` | `float` | `float` | - |
| `v2` | `float` | `float` | - |
| `heading` | `float` | `float` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |
| `p15` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Similar to DRAW_SPRITE, but allows to specify the texture coordinates used to draw the sprite.

u1, v1 - texture coordinates for the top-left corner
u2, v2 - texture coordinates for the bottom-right corner
```

---

### DRAW_SPRITE_NAMED_RENDERTARGET

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2BC54A8188768488`
- **Build:** `877`

**C# 签名:**
```csharp
void DRAW_SPRITE_NAMED_RENDERTARGET(string textureDict, string textureName, float screenX, float screenY, float width, float height, float heading, int red, int green, int blue, int alpha, object p11)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `textureDict` | `const char*` | `string` | - |
| `textureName` | `const char*` | `string` | - |
| `screenX` | `float` | `float` | - |
| `screenY` | `float` | `float` | - |
| `width` | `float` | `float` | - |
| `height` | `float` | `float` | - |
| `heading` | `float` | `float` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |
| `p11` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Similar to _DRAW_SPRITE, but seems to be some kind of "interactive" sprite, at least used by render targets.
These seem to be the only dicts ever requested by this native:

prop_screen_biker_laptop
Prop_Screen_GR_Disruption
Prop_Screen_TaleOfUs
prop_screen_nightclub
Prop_Screen_IE_Adhawk
prop_screen_sm_free_trade_shipping
prop_screen_hacker_truck
MPDesktop
Prop_Screen_Nightclub
And a few others

```

---

### DRAW_TEXTURED_POLY

- **命名空间:** `GRAPHICS`
- **Hash:** `0x29280002282F1928`
- **Build:** `877`

**C# 签名:**
```csharp
void DRAW_TEXTURED_POLY(float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, int red, int green, int blue, int alpha, string textureDict, string textureName, float u1, float v1, float w1, float u2, float v2, float w2, float u3, float v3, float w3)
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
| `x3` | `float` | `float` | - |
| `y3` | `float` | `float` | - |
| `z3` | `float` | `float` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |
| `textureDict` | `const char*` | `string` | - |
| `textureName` | `const char*` | `string` | - |
| `u1` | `float` | `float` | - |
| `v1` | `float` | `float` | - |
| `w1` | `float` | `float` | - |
| `u2` | `float` | `float` | - |
| `v2` | `float` | `float` | - |
| `w2` | `float` | `float` | - |
| `u3` | `float` | `float` | - |
| `v3` | `float` | `float` | - |
| `w3` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Used for drawling Deadline trailing lights, see deadline.ytd

p15 through p23 are values that appear to be related to illiumation, scaling, and rotation; more testing required.
For UVW mapping (u,v,w parameters), reference your favourite internet resource for more details.
```

---

### DRAW_TEXTURED_POLY_WITH_THREE_COLOURS

- **命名空间:** `GRAPHICS`
- **Hash:** `0x736D7AA1B750856B`
- **Build:** `877`

**C# 签名:**
```csharp
void DRAW_TEXTURED_POLY_WITH_THREE_COLOURS(float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, float red1, float green1, float blue1, int alpha1, float red2, float green2, float blue2, int alpha2, float red3, float green3, float blue3, int alpha3, string textureDict, string textureName, float u1, float v1, float w1, float u2, float v2, float w2, float u3, float v3, float w3)
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
| `x3` | `float` | `float` | - |
| `y3` | `float` | `float` | - |
| `z3` | `float` | `float` | - |
| `red1` | `float` | `float` | - |
| `green1` | `float` | `float` | - |
| `blue1` | `float` | `float` | - |
| `alpha1` | `int` | `int` | - |
| `red2` | `float` | `float` | - |
| `green2` | `float` | `float` | - |
| `blue2` | `float` | `float` | - |
| `alpha2` | `int` | `int` | - |
| `red3` | `float` | `float` | - |
| `green3` | `float` | `float` | - |
| `blue3` | `float` | `float` | - |
| `alpha3` | `int` | `int` | - |
| `textureDict` | `const char*` | `string` | - |
| `textureName` | `const char*` | `string` | - |
| `u1` | `float` | `float` | - |
| `v1` | `float` | `float` | - |
| `w1` | `float` | `float` | - |
| `u2` | `float` | `float` | - |
| `v2` | `float` | `float` | - |
| `w2` | `float` | `float` | - |
| `u3` | `float` | `float` | - |
| `v3` | `float` | `float` | - |
| `w3` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Used for drawling Deadline trailing lights, see deadline.ytd

Each vertex has its own colour that is blended/illuminated on the texture. Additionally, the R, G, and B components are floats that are int-casted internally.
For UVW mapping (u,v,w parameters), reference your favourite internet resource for more details.
```

---

### DRAW_TV_CHANNEL

- **命名空间:** `GRAPHICS`
- **Hash:** `0xFDDC2B4ED3C69DF0`
- **JHash:** `0x8129EF89`
- **Build:** `323`

**C# 签名:**
```csharp
void DRAW_TV_CHANNEL(float xPos, float yPos, float xScale, float yScale, float rotation, int red, int green, int blue, int alpha)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `xPos` | `float` | `float` | - |
| `yPos` | `float` | `float` | - |
| `xScale` | `float` | `float` | - |
| `yScale` | `float` | `float` | - |
| `rotation` | `float` | `float` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
All calls to this native are preceded by calls to GRAPHICS::SET_SCRIPT_GFX_DRAW_ORDER and GRAPHICS::SET_SCRIPT_GFX_DRAW_BEHIND_PAUSEMENU, respectively.

"act_cinema.ysc", line 1483:
HUD::SET_HUD_COMPONENT_POSITION(15, 0.0, -0.0375);
HUD::SET_TEXT_RENDER_ID(l_AE);
GRAPHICS::SET_SCRIPT_GFX_DRAW_ORDER(4);
GRAPHICS::SET_SCRIPT_GFX_DRAW_BEHIND_PAUSEMENU(1);
if (GRAPHICS::IS_TVSHOW_CURRENTLY_PLAYING(${movie_arthouse})) {
    GRAPHICS::DRAW_TV_CHANNEL(0.5, 0.5, 0.7375, 1.0, 0.0, 255, 255, 255, 255);
} else { 
    GRAPHICS::DRAW_TV_CHANNEL(0.5, 0.5, 1.0, 1.0, 0.0, 255, 255, 255, 255);
}

"am_mp_property_int.ysc", line 102545:
if (ENTITY::DOES_ENTITY_EXIST(a_2._f3)) {
    if (HUD::IS_NAMED_RENDERTARGET_LINKED(ENTITY::GET_ENTITY_MODEL(a_2._f3))) {
        HUD::SET_TEXT_RENDER_ID(a_2._f1);
        GRAPHICS::SET_SCRIPT_GFX_DRAW_ORDER(4);
        GRAPHICS::SET_SCRIPT_GFX_DRAW_BEHIND_PAUSEMENU(1);
        GRAPHICS::DRAW_TV_CHANNEL(0.5, 0.5, 1.0, 1.0, 0.0, 255, 255, 255, 255);
        if (GRAPHICS::GET_TV_CHANNEL() == -1) {
            sub_a8fa5(a_2, 1);
        } else { 
            sub_a8fa5(a_2, 1);
            GRAPHICS::ATTACH_TV_AUDIO_TO_ENTITY(a_2._f3);
        }
        HUD::SET_TEXT_RENDER_ID(HUD::GET_DEFAULT_SCRIPT_RENDERTARGET_RENDER_ID());
    }
}

```

---

### ENABLE_ALIEN_BLOOD_VFX

- **命名空间:** `GRAPHICS`
- **Hash:** `0x9DCE1F0F78260875`
- **JHash:** `0xCE8B8748`
- **Build:** `323`

**C# 签名:**
```csharp
void ENABLE_ALIEN_BLOOD_VFX(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Creates a motion-blur sort of effect, this native does not seem to work, however by using the `START_SCREEN_EFFECT` native with `DrugsMichaelAliensFight` as the effect parameter, you should be able to get the effect.
```

---

### ENABLE_CLOWN_BLOOD_VFX

- **命名空间:** `GRAPHICS`
- **Hash:** `0xD821490579791273`
- **JHash:** `0xC61C75E9`
- **Build:** `323`

**C# 签名:**
```csharp
void ENABLE_CLOWN_BLOOD_VFX(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Creates cartoon effect when Michel smokes the weed
```

---

### ENABLE_MOON_CYCLE_OVERRIDE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2C328AF17210F009`
- **Build:** `323`

**C# 签名:**
```csharp
void ENABLE_MOON_CYCLE_OVERRIDE(float strength)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `strength` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
The same as SET_TIMECYCLE_MODIFIER_STRENGTH but for the secondary timecycle modifier.
```

---

### ENABLE_MOVIE_KEYFRAME_WAIT

- **命名空间:** `GRAPHICS`
- **Hash:** `0x74C180030FDE4B69`
- **JHash:** `0x796DE696`
- **Build:** `323`

**C# 签名:**
```csharp
void ENABLE_MOVIE_KEYFRAME_WAIT(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### ENABLE_MOVIE_SUBTITLES

- **命名空间:** `GRAPHICS`
- **Hash:** `0x873FA65C778AD970`
- **JHash:** `0xC2DEBA3D`
- **Build:** `323`

**C# 签名:**
```csharp
void ENABLE_MOVIE_SUBTITLES(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### ENABLE_PROCOBJ_CREATION

- **命名空间:** `GRAPHICS`
- **Hash:** `0x5DEBD9C4DC995692`
- **Build:** `323`

**C# 签名:**
```csharp
void ENABLE_PROCOBJ_CREATION()
```

**返回值:** `void` (Native: `void`)

---

### END_PETROL_TRAIL_DECALS

- **命名空间:** `GRAPHICS`
- **Hash:** `0x0A123435A26C36CD`
- **JHash:** `0xCCCA6855`
- **Build:** `323`

**C# 签名:**
```csharp
void END_PETROL_TRAIL_DECALS()
```

**返回值:** `void` (Native: `void`)

---

### END_SCALEFORM_MOVIE_METHOD

- **命名空间:** `GRAPHICS`
- **Hash:** `0xC6796A8FFA375E53`
- **JHash:** `0x02DBF2D7`
- **Build:** `323`

**C# 签名:**
```csharp
void END_SCALEFORM_MOVIE_METHOD()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Pops and calls the Scaleform function on the stack
```

---

### END_SCALEFORM_MOVIE_METHOD_RETURN_VALUE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xC50AA39A577AF886`
- **JHash:** `0x2F38B526`
- **Build:** `323`

**C# 签名:**
```csharp
int END_SCALEFORM_MOVIE_METHOD_RETURN_VALUE()
```

**返回值:** `int` (Native: `int`)

---

### END_TEXT_COMMAND_SCALEFORM_STRING

- **命名空间:** `GRAPHICS`
- **Hash:** `0x362E2D3FE93A9959`
- **JHash:** `0x386CE0B8`
- **Build:** `323`

**C# 签名:**
```csharp
void END_TEXT_COMMAND_SCALEFORM_STRING()
```

**返回值:** `void` (Native: `void`)

---

### END_TEXT_COMMAND_UNPARSED_SCALEFORM_STRING

- **命名空间:** `GRAPHICS`
- **Hash:** `0xAE4E8157D9ECF087`
- **JHash:** `0x2E80DB52`
- **Build:** `323`

**C# 签名:**
```csharp
void END_TEXT_COMMAND_UNPARSED_SCALEFORM_STRING()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Same as END_TEXT_COMMAND_SCALEFORM_STRING but does not perform HTML conversion for text tokens.
```

---

### FADE_DECALS_IN_RANGE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xD77EDADB0420E6E0`
- **JHash:** `0xF81E884A`
- **Build:** `323`

**C# 签名:**
```csharp
void FADE_DECALS_IN_RANGE(float x, float y, float z, float p3, float p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Fades nearby decals within the range specified
```

---

### FADE_UP_PED_LIGHT

- **命名空间:** `GRAPHICS`
- **Hash:** `0xC9B18B4619F48F7B`
- **JHash:** `0x93628786`
- **Build:** `323`

**C# 签名:**
```csharp
void FADE_UP_PED_LIGHT(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### FORCE_EXPOSURE_READBACK

- **命名空间:** `GRAPHICS`
- **Hash:** `0x814AF7DCAACC597B`
- **Build:** `372`

**C# 签名:**
```csharp
void FORCE_EXPOSURE_READBACK(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### FORCE_PARTICLE_FX_IN_VEHICLE_INTERIOR

- **命名空间:** `GRAPHICS`
- **Hash:** `0xBA0127DA25FD54C9`
- **Build:** `372`

**C# 签名:**
```csharp
void FORCE_PARTICLE_FX_IN_VEHICLE_INTERIOR(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### FORCE_POSTFX_BULLET_IMPACTS_AFTER_HUD

- **命名空间:** `GRAPHICS`
- **Hash:** `0x9B079E5221D984D3`
- **Build:** `323`

**C# 签名:**
```csharp
void FORCE_POSTFX_BULLET_IMPACTS_AFTER_HUD(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### FORCE_RENDER_IN_GAME_UI

- **命名空间:** `GRAPHICS`
- **Hash:** `0xDC459CFA0CCE245B`
- **JHash:** `0x7E946E87`
- **Build:** `323`

**C# 签名:**
```csharp
void FORCE_RENDER_IN_GAME_UI(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### FREE_MEMORY_FOR_HIGH_QUALITY_PHOTO

- **命名空间:** `GRAPHICS`
- **Hash:** `0xD801CC02177FA3F1`
- **JHash:** `0x9CBA682A`
- **Build:** `323`

**C# 签名:**
```csharp
void FREE_MEMORY_FOR_HIGH_QUALITY_PHOTO()
```

**返回值:** `void` (Native: `void`)

---

### FREE_MEMORY_FOR_LOW_QUALITY_PHOTO

- **命名空间:** `GRAPHICS`
- **Hash:** `0x6A12D88881435DCA`
- **JHash:** `0x108F36CC`
- **Build:** `323`

**C# 签名:**
```csharp
void FREE_MEMORY_FOR_LOW_QUALITY_PHOTO()
```

**返回值:** `void` (Native: `void`)

---

### FREE_MEMORY_FOR_MISSION_CREATOR_PHOTO

- **命名空间:** `GRAPHICS`
- **Hash:** `0x0A46AF8A78DC5E0A`
- **JHash:** `0x9E553002`
- **Build:** `323`

**C# 签名:**
```csharp
void FREE_MEMORY_FOR_MISSION_CREATOR_PHOTO()
```

**返回值:** `void` (Native: `void`)

---

### FREE_MEMORY_FOR_MISSION_CREATOR_PHOTO_PREVIEW

- **命名空间:** `GRAPHICS`
- **Hash:** `0x346EF3ECAAAB149E`
- **JHash:** `0x88EAF398`
- **Build:** `323`

**C# 签名:**
```csharp
void FREE_MEMORY_FOR_MISSION_CREATOR_PHOTO_PREVIEW()
```

**返回值:** `void` (Native: `void`)

---

### GET_ACTUAL_SCREEN_RESOLUTION

- **命名空间:** `GRAPHICS`
- **Hash:** `0x873C9F3104101DD3`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_ACTUAL_SCREEN_RESOLUTION(ref int x, ref int y)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `int*` | `ref int` | - |
| `y` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Returns current screen resolution.
```

---

### GET_ASPECT_RATIO

- **命名空间:** `GRAPHICS`
- **Hash:** `0xF1307EF624A80D87`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_ASPECT_RATIO(bool b)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `b` | `BOOL` | `bool` | - |

**返回值:** `float` (Native: `float`)

---

### GET_BINK_MOVIE_TIME

- **命名空间:** `GRAPHICS`
- **Hash:** `0x8E17DDD6B9D5BF29`
- **Build:** `1734`

**C# 签名:**
```csharp
float GET_BINK_MOVIE_TIME(int binkMovie)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `binkMovie` | `int` | `int` | - |

**返回值:** `float` (Native: `float`)

**说明:**
```
In percentage: 0.0 - 100.0
```

---

### GET_CURRENT_NUMBER_OF_CLOUD_PHOTOS

- **命名空间:** `GRAPHICS`
- **Hash:** `0x473151EBC762C6DA`
- **JHash:** `0x21DBF0C9`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_CURRENT_NUMBER_OF_CLOUD_PHOTOS()
```

**返回值:** `int` (Native: `int`)

---

### GET_CURRENT_TV_CLIP_NAMEHASH

- **命名空间:** `GRAPHICS`
- **Hash:** `0x30432A0118736E00`
- **Build:** `1493`

**C# 签名:**
```csharp
uint GET_CURRENT_TV_CLIP_NAMEHASH()
```

**返回值:** `uint` (Native: `Hash`)

---

### GET_CUTSCENE_CONCAT_SECTION_PLAYING

- **命名空间:** `CUTSCENE`
- **Hash:** `0x583DF8E3D4AFBD98`
- **JHash:** `0x5AE68AE6`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_CUTSCENE_CONCAT_SECTION_PLAYING()
```

**返回值:** `int` (Native: `int`)

---

### GET_CUTSCENE_END_TIME

- **命名空间:** `CUTSCENE`
- **Hash:** `0x971D7B15BCDBEF99`
- **Build:** `1734`

**C# 签名:**
```csharp
int GET_CUTSCENE_END_TIME()
```

**返回值:** `int` (Native: `int`)

---

### GET_CUTSCENE_PLAY_DURATION

- **命名空间:** `CUTSCENE`
- **Hash:** `0x5D583F71C901F2A3`
- **Build:** `2802`

**C# 签名:**
```csharp
int GET_CUTSCENE_PLAY_DURATION()
```

**返回值:** `int` (Native: `int`)

---

### GET_CUTSCENE_PLAY_TIME

- **命名空间:** `CUTSCENE`
- **Hash:** `0x710286BC5EF4D6E1`
- **Build:** `3258`

**C# 签名:**
```csharp
int GET_CUTSCENE_PLAY_TIME()
```

**返回值:** `int` (Native: `int`)

---

### GET_CUTSCENE_SECTION_PLAYING

- **命名空间:** `CUTSCENE`
- **Hash:** `0x49010A6A396553D8`
- **JHash:** `0x1026F0D6`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_CUTSCENE_SECTION_PLAYING()
```

**返回值:** `int` (Native: `int`)

---

### GET_CUTSCENE_TIME

- **命名空间:** `CUTSCENE`
- **Hash:** `0xE625BEABBAFFDAB9`
- **JHash:** `0x53F5B5AB`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_CUTSCENE_TIME()
```

**返回值:** `int` (Native: `int`)

---

### GET_CUTSCENE_TOTAL_DURATION

- **命名空间:** `CUTSCENE`
- **Hash:** `0xEE53B14A19E480D4`
- **JHash:** `0x0824EBE8`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_CUTSCENE_TOTAL_DURATION()
```

**返回值:** `int` (Native: `int`)

---

### GET_CUT_FILE_CONCAT_COUNT

- **命名空间:** `CUTSCENE`
- **Hash:** `0x0ABC54DE641DC0FC`
- **JHash:** `0xFD8B1AC2`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_CUT_FILE_CONCAT_COUNT(string cutsceneName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cutsceneName` | `const char*` | `string` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Full list of cutscene names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/cutsceneNames.json
```

---

### GET_CUT_FILE_OFFSET

- **命名空间:** `CUTSCENE`
- **Hash:** `0x1FA904B60E492336`
- **Build:** `3570`

**C# 签名:**
```csharp
Vector3 GET_CUT_FILE_OFFSET(string cutsceneName, int index)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cutsceneName` | `const char*` | `string` | - |
| `index` | `int` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

---

### GET_DECAL_WASH_LEVEL

- **命名空间:** `GRAPHICS`
- **Hash:** `0x323F647679A09103`
- **JHash:** `0x054448EF`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_DECAL_WASH_LEVEL(int decal)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `decal` | `int` | `int` | - |

**返回值:** `float` (Native: `float`)

---

### GET_ENTITY_INDEX_OF_CUTSCENE_ENTITY

- **命名空间:** `CUTSCENE`
- **Hash:** `0x0A2E9FDB9A8C62F6`
- **JHash:** `0x1D09ABC7`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_ENTITY_INDEX_OF_CUTSCENE_ENTITY(string cutsceneEntName, uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cutsceneEntName` | `const char*` | `string` | - |
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `Entity`)

---

### GET_ENTITY_INDEX_OF_REGISTERED_ENTITY

- **命名空间:** `CUTSCENE`
- **Hash:** `0xC0741A26499654CD`
- **JHash:** `0x46D18755`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_ENTITY_INDEX_OF_REGISTERED_ENTITY(string cutsceneEntName, uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cutsceneEntName` | `const char*` | `string` | - |
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `Entity`)

---

### GET_EXTRA_TCMODIFIER

- **命名空间:** `GRAPHICS`
- **Hash:** `0xBB0527EC6341496D`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_EXTRA_TCMODIFIER()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
See GET_TIMECYCLE_MODIFIER_INDEX for use, works the same just for the secondary timecycle modifier.
Returns an integer representing the Timecycle modifier
```

---

### GET_IS_HIDEF

- **命名空间:** `GRAPHICS`
- **Hash:** `0x84ED31191CC5D2C9`
- **JHash:** `0x1C340359`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_IS_HIDEF()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
false = Any resolution < 1280x720
true = Any resolution >= 1280x720
```

---

### GET_IS_PETROL_DECAL_IN_RANGE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2F09F7976C512404`
- **JHash:** `0x242C6A04`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_IS_PETROL_DECAL_IN_RANGE(float xCoord, float yCoord, float zCoord, float radius)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `xCoord` | `float` | `float` | - |
| `yCoord` | `float` | `float` | - |
| `zCoord` | `float` | `float` | - |
| `radius` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_IS_TIMECYCLE_TRANSITIONING_OUT

- **命名空间:** `GRAPHICS`
- **Hash:** `0x98D18905BF723B99`
- **Build:** `1493`

**C# 签名:**
```csharp
bool GET_IS_TIMECYCLE_TRANSITIONING_OUT()
```

**返回值:** `bool` (Native: `BOOL`)

---

### GET_IS_WIDESCREEN

- **命名空间:** `GRAPHICS`
- **Hash:** `0x30CF4BDA4FCB1905`
- **JHash:** `0xEC717AEF`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_IS_WIDESCREEN()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Setting Aspect Ratio Manually in game will return:

false - for Narrow format Aspect Ratios (3:2, 4:3, 5:4, etc. )
true - for Wide format Aspect Ratios (5:3, 16:9, 16:10, etc. )

Setting Aspect Ratio to "Auto" in game will return "false" or "true" based on the actual set Resolution Ratio.
```

---

### GET_LIGHT_OVERRIDE_MAX_INTENSITY_SCALE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x393BD2275CEB7793`
- **Build:** `1103`

**C# 签名:**
```csharp
float GET_LIGHT_OVERRIDE_MAX_INTENSITY_SCALE()
```

**返回值:** `float` (Native: `float`)

---

### GET_LOAD_HIGH_QUALITY_PHOTO_STATUS

- **命名空间:** `GRAPHICS`
- **Hash:** `0x40AFB081F8ADD4EE`
- **JHash:** `0x762E5C5F`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_LOAD_HIGH_QUALITY_PHOTO_STATUS(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Hardcoded to always return 2.
```

---

### GET_MAXIMUM_NUMBER_OF_CLOUD_PHOTOS

- **命名空间:** `GRAPHICS`
- **Hash:** `0xDC54A7AF8B3A14EF`
- **JHash:** `0x239272BD`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_MAXIMUM_NUMBER_OF_CLOUD_PHOTOS()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
This function is hard-coded to always return 96.
```

---

### GET_MAXIMUM_NUMBER_OF_PHOTOS

- **命名空间:** `GRAPHICS`
- **Hash:** `0x34D23450F028B0BF`
- **JHash:** `0x727AA63F`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_MAXIMUM_NUMBER_OF_PHOTOS()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
This function is hard-coded to always return 0.
```

---

### GET_MOTIONBLUR_MAX_VEL_SCALER

- **命名空间:** `GRAPHICS`
- **Hash:** `0xE59343E9E96529E7`
- **JHash:** `0xD906A3A9`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_MOTIONBLUR_MAX_VEL_SCALER()
```

**返回值:** `float` (Native: `float`)

**说明:**
```
Getter for SET_MOTIONBLUR_MAX_VEL_SCALER
```

---

### GET_REQUESTINGNIGHTVISION

- **命名空间:** `GRAPHICS`
- **Hash:** `0x35FB78DC42B7BD21`
- **JHash:** `0xF3A6309E`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_REQUESTINGNIGHTVISION()
```

**返回值:** `bool` (Native: `BOOL`)

---

### GET_SAFE_ZONE_SIZE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xBAF107B6BB2C97F0`
- **JHash:** `0x3F0D1A6F`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_SAFE_ZONE_SIZE()
```

**返回值:** `float` (Native: `float`)

**说明:**
```
Gets the scale of safe zone. if the safe zone size scale is max, it will return 1.0.
```

---

### GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_BOOL

- **命名空间:** `GRAPHICS`
- **Hash:** `0xD80A80346A45D761`
- **Build:** `757`

**C# 签名:**
```csharp
bool GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_BOOL(int methodReturn)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `methodReturn` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
methodReturn: The return value of this native: END_SCALEFORM_MOVIE_METHOD_RETURN_VALUE
```

---

### GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_INT

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2DE7EFA66B906036`
- **JHash:** `0x2CFB0E6D`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_INT(int methodReturn)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `methodReturn` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
methodReturn: The return value of this native: END_SCALEFORM_MOVIE_METHOD_RETURN_VALUE
Used to get a return value from a scaleform function. Returns an int in the same way GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_STRING returns a string.
```

---

### GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_STRING

- **命名空间:** `GRAPHICS`
- **Hash:** `0xE1E258829A885245`
- **JHash:** `0x516862EB`
- **Build:** `323`

**C# 签名:**
```csharp
string GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_STRING(int methodReturn)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `methodReturn` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
methodReturn: The return value of this native: END_SCALEFORM_MOVIE_METHOD_RETURN_VALUE
Used to get a return value from a scaleform function. Returns a string in the same way GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_INT returns an int.
```

---

### GET_SCREENBLUR_FADE_CURRENT_TIME

- **命名空间:** `GRAPHICS`
- **Hash:** `0x5CCABFFCA31DDE33`
- **JHash:** `0xEA432A94`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_SCREENBLUR_FADE_CURRENT_TIME()
```

**返回值:** `float` (Native: `float`)

---

### GET_SCREEN_ASPECT_RATIO

- **命名空间:** `GRAPHICS`
- **Hash:** `0xB2EBE8CBC58B90E9`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_SCREEN_ASPECT_RATIO()
```

**返回值:** `float` (Native: `float`)

---

### GET_SCREEN_COORD_FROM_WORLD_COORD

- **命名空间:** `GRAPHICS`
- **Hash:** `0x34E82F05DF2974F5`
- **JHash:** `0x1F950E4B`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_SCREEN_COORD_FROM_WORLD_COORD(float worldX, float worldY, float worldZ, ref float screenX, ref float screenY)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `worldX` | `float` | `float` | - |
| `worldY` | `float` | `float` | - |
| `worldZ` | `float` | `float` | - |
| `screenX` | `float*` | `ref float` | - |
| `screenY` | `float*` | `ref float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Convert a world coordinate into its relative screen coordinate.  (WorldToScreen)

Returns a boolean; whether or not the operation was successful. It will return false if the coordinates given are not visible to the rendering camera.


For .NET users...

VB:
Public Shared Function World3DToScreen2d(pos as vector3) As Vector2

        Dim x2dp, y2dp As New Native.OutputArgument

        Native.Function.Call(Of Boolean)(Native.Hash.GET_SCREEN_COORD_FROM_WORLD_COORD , pos.x, pos.y, pos.z, x2dp, y2dp)
        Return New Vector2(x2dp.GetResult(Of Single), y2dp.GetResult(Of Single))
      
    End Function

C#:
Vector2 World3DToScreen2d(Vector3 pos)
    {
        var x2dp = new OutputArgument();
        var y2dp = new OutputArgument();

        Function.Call<bool>(Hash.GET_SCREEN_COORD_FROM_WORLD_COORD , pos.X, pos.Y, pos.Z, x2dp, y2dp);
        return new Vector2(x2dp.GetResult<float>(), y2dp.GetResult<float>());
    }
//USE VERY SMALL VALUES FOR THE SCALE OF RECTS/TEXT because it is dramatically larger on screen than in 3D, e.g '0.05' small.

Used to be called _WORLD3D_TO_SCREEN2D

I thought we lost you from the scene forever. It does seem however that calling SET_DRAW_ORIGIN then your natives, then ending it. Seems to work better for certain things such as keeping boxes around people for a predator missile e.g.
```

---

### GET_SCREEN_RESOLUTION

- **命名空间:** `GRAPHICS`
- **Hash:** `0x888D57E407E63624`
- **JHash:** `0x29F3572F`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_SCREEN_RESOLUTION(ref int x, ref int y)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `int*` | `ref int` | - |
| `y` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
int screenresx,screenresy;
GET_SCREEN_RESOLUTION(&screenresx,&screenresy);
```

---

### GET_SCRIPT_GFX_ALIGN_POSITION

- **命名空间:** `GRAPHICS`
- **Hash:** `0x6DD8F5AA635EB4B2`
- **Build:** `323`

**C# 签名:**
```csharp
void GET_SCRIPT_GFX_ALIGN_POSITION(float x, float y, ref float calculatedX, ref float calculatedY)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `calculatedX` | `float*` | `ref float` | - |
| `calculatedY` | `float*` | `ref float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Calculates the effective X/Y fractions when applying the values set by SET_SCRIPT_GFX_ALIGN and SET_SCRIPT_GFX_ALIGN_PARAMS
```

---

### GET_STATUS_OF_CREATE_LOW_QUALITY_COPY_OF_PHOTO

- **命名空间:** `GRAPHICS`
- **Hash:** `0xCB82A0BF0E3E3265`
- **JHash:** `0xCFCDC518`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_STATUS_OF_CREATE_LOW_QUALITY_COPY_OF_PHOTO(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_STATUS_OF_CREATE_MISSION_CREATOR_PHOTO_PREVIEW

- **命名空间:** `GRAPHICS`
- **Hash:** `0x5B0316762AFD4A64`
- **JHash:** `0xA9DC8558`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_STATUS_OF_CREATE_MISSION_CREATOR_PHOTO_PREVIEW()
```

**返回值:** `int` (Native: `int`)

---

### GET_STATUS_OF_LOAD_MISSION_CREATOR_PHOTO

- **命名空间:** `GRAPHICS`
- **Hash:** `0x1670F8D05056F257`
- **JHash:** `0x226B08EA`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_STATUS_OF_LOAD_MISSION_CREATOR_PHOTO(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `int` (Native: `int`)

---

### GET_STATUS_OF_SAVE_HIGH_QUALITY_PHOTO

- **命名空间:** `GRAPHICS`
- **Hash:** `0x0C0C4E81E1AC60A0`
- **JHash:** `0xEC5D0317`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_STATUS_OF_SAVE_HIGH_QUALITY_PHOTO()
```

**返回值:** `int` (Native: `int`)

---

### GET_STATUS_OF_SORTED_LIST_OPERATION

- **命名空间:** `GRAPHICS`
- **Hash:** `0xF5BED327CEA362B1`
- **JHash:** `0x596B900D`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_STATUS_OF_SORTED_LIST_OPERATION(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
3 matches across 3 scripts. First 2 were 0, 3rd was 1. Possibly a bool.
appcamera, appmedia, and cellphone_controller.
```

---

### GET_STATUS_OF_TAKE_HIGH_QUALITY_PHOTO

- **命名空间:** `GRAPHICS`
- **Hash:** `0x0D6CA79EEEBD8CA3`
- **JHash:** `0x65376C9B`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_STATUS_OF_TAKE_HIGH_QUALITY_PHOTO()
```

**返回值:** `int` (Native: `int`)

---

### GET_STATUS_OF_TAKE_MISSION_CREATOR_PHOTO

- **命名空间:** `GRAPHICS`
- **Hash:** `0x90A78ECAA4E78453`
- **JHash:** `0xADBBA287`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_STATUS_OF_TAKE_MISSION_CREATOR_PHOTO()
```

**返回值:** `int` (Native: `int`)

---

### GET_TEXTURE_RESOLUTION

- **命名空间:** `GRAPHICS`
- **Hash:** `0x35736EE65BD00C11`
- **JHash:** `0x096DAA4D`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GET_TEXTURE_RESOLUTION(string textureDict, string textureName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `textureDict` | `const char*` | `string` | - |
| `textureName` | `const char*` | `string` | - |

**返回值:** `Vector3` (Native: `Vector3`)

**说明:**
```
Returns the texture resolution of the passed texture dict+name.

Note: Most texture resolutions are doubled compared to the console version of the game.
```

---

### GET_TIMECYCLE_MODIFIER_INDEX

- **命名空间:** `GRAPHICS`
- **Hash:** `0xFDF3D97C674AFB66`
- **JHash:** `0x594FEEC4`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_TIMECYCLE_MODIFIER_INDEX()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Only use for this in the PC scripts is:

if (GRAPHICS::GET_TIMECYCLE_MODIFIER_INDEX() != -1)
```

---

### GET_TIMECYCLE_TRANSITION_MODIFIER_INDEX

- **命名空间:** `GRAPHICS`
- **Hash:** `0x459FD2C8D0AB78BC`
- **JHash:** `0x03C44E4B`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_TIMECYCLE_TRANSITION_MODIFIER_INDEX()
```

**返回值:** `int` (Native: `int`)

---

### GET_TOGGLE_PAUSED_RENDERPHASES_STATUS

- **命名空间:** `GRAPHICS`
- **Hash:** `0xEB3DAC2C86001E5E`
- **JHash:** `0xD4F5D07D`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_TOGGLE_PAUSED_RENDERPHASES_STATUS()
```

**返回值:** `bool` (Native: `BOOL`)

---

### GET_TV_CHANNEL

- **命名空间:** `GRAPHICS`
- **Hash:** `0xFC1E275A90D39995`
- **JHash:** `0x6B96145A`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_TV_CHANNEL()
```

**返回值:** `int` (Native: `int`)

---

### GET_TV_VOLUME

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2170813D3DD8661B`
- **JHash:** `0x39555CF0`
- **Build:** `323`

**C# 签名:**
```csharp
float GET_TV_VOLUME()
```

**返回值:** `float` (Native: `float`)

---

### GET_USINGNIGHTVISION

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2202A3F42C8E5F79`
- **JHash:** `0x62619061`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_USINGNIGHTVISION()
```

**返回值:** `bool` (Native: `BOOL`)

---

### GET_USINGSEETHROUGH

- **命名空间:** `GRAPHICS`
- **Hash:** `0x44B80ABAB9D80BD3`
- **JHash:** `0x1FE547F2`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_USINGSEETHROUGH()
```

**返回值:** `bool` (Native: `BOOL`)

---

### GET_VEHICLE_CREW_EMBLEM_REQUEST_STATE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xFE26117A5841B2FF`
- **JHash:** `0x4F4D76E8`
- **Build:** `323`

**C# 签名:**
```csharp
int GET_VEHICLE_CREW_EMBLEM_REQUEST_STATE(int vehicle, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GOLF_TRAIL_GET_MAX_HEIGHT

- **命名空间:** `GRAPHICS`
- **Hash:** `0xA4819F5E23E2FFAD`
- **JHash:** `0xA08B46AD`
- **Build:** `323`

**C# 签名:**
```csharp
float GOLF_TRAIL_GET_MAX_HEIGHT()
```

**返回值:** `float` (Native: `float`)

---

### GOLF_TRAIL_GET_VISUAL_CONTROL_POINT

- **命名空间:** `GRAPHICS`
- **Hash:** `0xA4664972A9B8F8BA`
- **JHash:** `0xECD470F0`
- **Build:** `323`

**C# 签名:**
```csharp
Vector3 GOLF_TRAIL_GET_VISUAL_CONTROL_POINT(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `Vector3` (Native: `Vector3`)

---

### GOLF_TRAIL_SET_COLOUR

- **命名空间:** `GRAPHICS`
- **Hash:** `0x12995F2E53FFA601`
- **JHash:** `0x804F444C`
- **Build:** `323`

**C# 签名:**
```csharp
void GOLF_TRAIL_SET_COLOUR(int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `int` | `int` | - |
| `p3` | `int` | `int` | - |
| `p4` | `int` | `int` | - |
| `p5` | `int` | `int` | - |
| `p6` | `int` | `int` | - |
| `p7` | `int` | `int` | - |
| `p8` | `int` | `int` | - |
| `p9` | `int` | `int` | - |
| `p10` | `int` | `int` | - |
| `p11` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### GOLF_TRAIL_SET_ENABLED

- **命名空间:** `GRAPHICS`
- **Hash:** `0xA51C4B86B71652AE`
- **JHash:** `0x5D3BFFC9`
- **Build:** `323`

**C# 签名:**
```csharp
void GOLF_TRAIL_SET_ENABLED(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### GOLF_TRAIL_SET_FACING

- **命名空间:** `GRAPHICS`
- **Hash:** `0x06F761EA47C1D3ED`
- **JHash:** `0x0D830DC7`
- **Build:** `323`

**C# 签名:**
```csharp
void GOLF_TRAIL_SET_FACING(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### GOLF_TRAIL_SET_FIXED_CONTROL_POINT

- **命名空间:** `GRAPHICS`
- **Hash:** `0xB1BB03742917A5D6`
- **JHash:** `0x3BB12B75`
- **Build:** `323`

**C# 签名:**
```csharp
void GOLF_TRAIL_SET_FIXED_CONTROL_POINT(int type, float xPos, float yPos, float zPos, float p4, int red, int green, int blue, int alpha)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `type` | `int` | `int` | - |
| `xPos` | `float` | `float` | - |
| `yPos` | `float` | `float` | - |
| `zPos` | `float` | `float` | - |
| `p4` | `float` | `float` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
12 matches across 4 scripts. All 4 scripts were job creators.

type ranged from 0 - 2.
p4 was always 0.2f. Likely scale.
assuming p5 - p8 is RGBA, the graphic is always yellow (255, 255, 0, 255).

Tested but noticed nothing.
```

---

### GOLF_TRAIL_SET_FIXED_CONTROL_POINT_ENABLE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xC0416B061F2B7E5E`
- **JHash:** `0x1A1A72EF`
- **Build:** `323`

**C# 签名:**
```csharp
void GOLF_TRAIL_SET_FIXED_CONTROL_POINT_ENABLE(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### GOLF_TRAIL_SET_PATH

- **命名空间:** `GRAPHICS`
- **Hash:** `0x312342E1A4874F3F`
- **JHash:** `0xD9653728`
- **Build:** `323`

**C# 签名:**
```csharp
void GOLF_TRAIL_SET_PATH(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, bool p8)
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
| `p8` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p8 seems to always be false.
```

---

### GOLF_TRAIL_SET_RADIUS

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2485D34E50A22E84`
- **JHash:** `0x72BA8A14`
- **Build:** `323`

**C# 签名:**
```csharp
void GOLF_TRAIL_SET_RADIUS(float p0, float p1, float p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### GOLF_TRAIL_SET_SHADER_PARAMS

- **命名空间:** `GRAPHICS`
- **Hash:** `0x9CFDD90B2B844BF7`
- **JHash:** `0x4EA70FB4`
- **Build:** `323`

**C# 签名:**
```csharp
void GOLF_TRAIL_SET_SHADER_PARAMS(float p0, float p1, float p2, float p3, float p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Only appeared in Golf & Golf_mp. Parameters were all ptrs
```

---

### GOLF_TRAIL_SET_TESSELLATION

- **命名空间:** `GRAPHICS`
- **Hash:** `0xDBAA5EC848BA2D46`
- **JHash:** `0xBB1A1294`
- **Build:** `323`

**C# 签名:**
```csharp
void GOLF_TRAIL_SET_TESSELLATION(int p0, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### GRAB_PAUSEMENU_OWNERSHIP

- **命名空间:** `GRAPHICS`
- **Hash:** `0x851CD923176EBA7C`
- **JHash:** `0xDCBA251B`
- **Build:** `323`

**C# 签名:**
```csharp
void GRAB_PAUSEMENU_OWNERSHIP()
```

**返回值:** `void` (Native: `void`)

---

### GRASSBATCH_DISABLE_FLATTENING

- **命名空间:** `GRAPHICS`
- **Hash:** `0x302C91AB2D477F7E`
- **Build:** `323`

**C# 签名:**
```csharp
void GRASSBATCH_DISABLE_FLATTENING()
```

**返回值:** `void` (Native: `void`)

---

### GRASSBATCH_ENABLE_FLATTENING_EXT_IN_SPHERE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xAAE9BE70EC7C69AB`
- **Build:** `1290`

**C# 签名:**
```csharp
void GRASSBATCH_ENABLE_FLATTENING_EXT_IN_SPHERE(float x, float y, float z, object p3, float p4, float p5, float p6, float scale)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `float` | `float` | - |
| `p5` | `float` | `float` | - |
| `p6` | `float` | `float` | - |
| `scale` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### GRASSBATCH_ENABLE_FLATTENING_IN_SPHERE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x6D955F6A9E0295B1`
- **Build:** `323`

**C# 签名:**
```csharp
void GRASSBATCH_ENABLE_FLATTENING_IN_SPHERE(float x, float y, float z, float radius, float p4, float p5, float p6)
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

**返回值:** `void` (Native: `void`)

**说明:**
```
Wraps 0xAAE9BE70EC7C69AB with FLT_MAX as p7
```

---

### HAS_CUTSCENE_CUT_THIS_FRAME

- **命名空间:** `CUTSCENE`
- **Hash:** `0x708BDD8CD795B043`
- **JHash:** `0x4315A7C5`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_CUTSCENE_CUT_THIS_FRAME()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Possibly HAS_CUTSCENE_CUT_THIS_FRAME, needs more research.
```

---

### HAS_CUTSCENE_FINISHED

- **命名空间:** `CUTSCENE`
- **Hash:** `0x7C0A893088881D57`
- **JHash:** `0x5DED14B4`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_CUTSCENE_FINISHED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_CUTSCENE_LOADED

- **命名空间:** `CUTSCENE`
- **Hash:** `0xC59F528E9AB9F339`
- **JHash:** `0xF9998582`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_CUTSCENE_LOADED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_CUT_FILE_LOADED

- **命名空间:** `CUTSCENE`
- **Hash:** `0xA1C996C2A744262E`
- **JHash:** `0x56D5B144`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_CUT_FILE_LOADED(string cutsceneName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cutsceneName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Simply checks if the cutscene has loaded and doesn't check via CutSceneManager as opposed to HAS_[THIS]_CUTSCENE_LOADED.
Full list of cutscene names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/cutsceneNames.json
```

---

### HAS_SCALEFORM_CONTAINER_MOVIE_LOADED_INTO_PARENT

- **命名空间:** `GRAPHICS`
- **Hash:** `0x8217150E1217EBFD`
- **JHash:** `0x1DFE8D8A`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_SCALEFORM_CONTAINER_MOVIE_LOADED_INTO_PARENT(int scaleformHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleformHandle` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_SCALEFORM_MOVIE_FILENAME_LOADED

- **命名空间:** `GRAPHICS`
- **Hash:** `0x0C1C5D756FB5F337`
- **JHash:** `0x494A9E50`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_SCALEFORM_MOVIE_FILENAME_LOADED(string scaleformName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleformName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Only values used in the scripts are:

"heist_mp"
"heistmap_mp"
"instructional_buttons"
"heist_pre"
```

---

### HAS_SCALEFORM_MOVIE_LOADED

- **命名空间:** `GRAPHICS`
- **Hash:** `0x85F01B8D5B90570E`
- **JHash:** `0xDDFB6448`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_SCALEFORM_MOVIE_LOADED(int scaleformHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleformHandle` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_SCALEFORM_SCRIPT_HUD_MOVIE_LOADED

- **命名空间:** `GRAPHICS`
- **Hash:** `0xDF6E5987D2B4D140`
- **JHash:** `0x79B43255`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_SCALEFORM_SCRIPT_HUD_MOVIE_LOADED(int hudComponent)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `hudComponent` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_STREAMED_TEXTURE_DICT_LOADED

- **命名空间:** `GRAPHICS`
- **Hash:** `0x0145F696AAAAD2E4`
- **JHash:** `0x3F436EEF`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_STREAMED_TEXTURE_DICT_LOADED(string textureDict)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `textureDict` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_THIS_CUTSCENE_LOADED

- **命名空间:** `CUTSCENE`
- **Hash:** `0x228D3D94F8A11C3C`
- **JHash:** `0x3C5619F2`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_THIS_CUTSCENE_LOADED(string cutsceneName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cutsceneName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of cutscene names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/cutsceneNames.json
```

---

### IS_ACTIVE_SCALEFORM_MOVIE_DELETING

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2FCB133CA50A49EB`
- **Build:** `1290`

**C# 签名:**
```csharp
bool IS_ACTIVE_SCALEFORM_MOVIE_DELETING(int val)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `val` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
val is 1-20 (0 will return false)
```

---

### IS_CUTSCENE_ACTIVE

- **命名空间:** `CUTSCENE`
- **Hash:** `0x991251AFC3981F84`
- **JHash:** `0xCCE2FE9D`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_CUTSCENE_ACTIVE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_CUTSCENE_AUTHORIZED

- **命名空间:** `CUTSCENE`
- **Hash:** `0x4CEBC1ED31E8925E`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_CUTSCENE_AUTHORIZED(string cutsceneName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cutsceneName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
This function is hard-coded to always return 1.
```

---

### IS_CUTSCENE_PLAYBACK_FLAG_SET

- **命名空间:** `CUTSCENE`
- **Hash:** `0x71B74D2AE19338D0`
- **JHash:** `0x7B93CDAA`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_CUTSCENE_PLAYBACK_FLAG_SET(int flag)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `flag` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_CUTSCENE_PLAYING

- **命名空间:** `CUTSCENE`
- **Hash:** `0xD3C2E180A40F031E`
- **JHash:** `0xA3A78392`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_CUTSCENE_PLAYING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_DECAL_ALIVE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xC694D74949CAFD0C`
- **JHash:** `0xCDD4A61A`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_DECAL_ALIVE(int decal)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `decal` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_MULTIHEAD_FADE_UP

- **命名空间:** `CUTSCENE`
- **Hash:** `0xA0FE76168A189DDB`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_MULTIHEAD_FADE_UP()
```

**返回值:** `bool` (Native: `BOOL`)

---

### IS_PLAYLIST_ON_CHANNEL

- **命名空间:** `GRAPHICS`
- **Hash:** `0x1F710BFF7DAE6261`
- **Build:** `1604`

**C# 签名:**
```csharp
bool IS_PLAYLIST_ON_CHANNEL(int tvChannel, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `tvChannel` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_SCALEFORM_MOVIE_DELETING

- **命名空间:** `GRAPHICS`
- **Hash:** `0x86255B1FC929E33E`
- **Build:** `1290`

**C# 签名:**
```csharp
bool IS_SCALEFORM_MOVIE_DELETING(int val)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `val` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
val is 1-20. Return is related to INSTRUCTIONAL_BUTTONS, COLOUR_SWITCHER_02, etc?
```

---

### IS_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_READY

- **命名空间:** `GRAPHICS`
- **Hash:** `0x768FF8961BA904D6`
- **JHash:** `0x5CD7C3C0`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_READY(int methodReturn)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `methodReturn` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
methodReturn: The return value of this native: END_SCALEFORM_MOVIE_METHOD_RETURN_VALUE
Returns true if the return value of a scaleform function is ready to be collected (using GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_STRING or GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_INT).
```

---

### IS_SCREENBLUR_FADE_RUNNING

- **命名空间:** `GRAPHICS`
- **Hash:** `0x7B226C785A52A0A9`
- **JHash:** `0x926B8734`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_SCREENBLUR_FADE_RUNNING()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns whether screen transition to blur/from blur is running.
```

---

### IS_TRACKED_POINT_VISIBLE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xC45CCDAAC9221CA8`
- **JHash:** `0x0BFC4F64`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_TRACKED_POINT_VISIBLE(int point)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `point` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### IS_TVSHOW_CURRENTLY_PLAYING

- **命名空间:** `GRAPHICS`
- **Hash:** `0x0AD973CA1E077B60`
- **JHash:** `0x4D1EB0FB`
- **Build:** `323`

**C# 签名:**
```csharp
bool IS_TVSHOW_CURRENTLY_PLAYING(uint videoCliphash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `videoCliphash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### LOAD_HIGH_QUALITY_PHOTO

- **命名空间:** `GRAPHICS`
- **Hash:** `0xEC72C258667BE5EA`
- **JHash:** `0x9C106AD9`
- **Build:** `323`

**C# 签名:**
```csharp
bool LOAD_HIGH_QUALITY_PHOTO(object p0)
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

### LOAD_MISSION_CREATOR_PHOTO

- **命名空间:** `GRAPHICS`
- **Hash:** `0x4862437A486F91B0`
- **JHash:** `0x56C1E488`
- **Build:** `323`

**C# 签名:**
```csharp
bool LOAD_MISSION_CREATOR_PHOTO(ref object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### LOAD_MOVIE_MESH_SET

- **命名空间:** `GRAPHICS`
- **Hash:** `0xB66064452270E8F1`
- **JHash:** `0x9627905C`
- **Build:** `323`

**C# 签名:**
```csharp
int LOAD_MOVIE_MESH_SET(string movieMeshSetName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `movieMeshSetName` | `const char*` | `string` | - |

**返回值:** `int` (Native: `int`)

---

### MOVE_VEHICLE_DECALS

- **命名空间:** `GRAPHICS`
- **Hash:** `0x84C8D7C2D30D3280`
- **JHash:** `0xCE9E6CF2`
- **Build:** `323`

**C# 签名:**
```csharp
void MOVE_VEHICLE_DECALS(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SET_MOCAP_CUTSCENE_CAN_BE_SKIPPED

- **命名空间:** `CUTSCENE`
- **Hash:** `0x2F137B508DE238F2`
- **JHash:** `0x8338DA1D`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SET_MOCAP_CUTSCENE_CAN_BE_SKIPPED(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### OVERRIDE_INTERIOR_SMOKE_END

- **命名空间:** `GRAPHICS`
- **Hash:** `0xEFB55E7C25D3B3BE`
- **JHash:** `0xE29EE145`
- **Build:** `323`

**C# 签名:**
```csharp
void OVERRIDE_INTERIOR_SMOKE_END()
```

**返回值:** `void` (Native: `void`)

---

### OVERRIDE_INTERIOR_SMOKE_LEVEL

- **命名空间:** `GRAPHICS`
- **Hash:** `0x1600FD8CF72EBC12`
- **JHash:** `0xD87CC710`
- **Build:** `323`

**C# 签名:**
```csharp
void OVERRIDE_INTERIOR_SMOKE_LEVEL(float level)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `level` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### OVERRIDE_INTERIOR_SMOKE_NAME

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2A2A52824DB96700`
- **JHash:** `0x0F486429`
- **Build:** `323`

**C# 签名:**
```csharp
void OVERRIDE_INTERIOR_SMOKE_NAME(string name)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### OVERRIDE_NIGHTVISION_LIGHT_RANGE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x43FA7CBE20DAB219`
- **Build:** `1290`

**C# 签名:**
```csharp
void OVERRIDE_NIGHTVISION_LIGHT_RANGE(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### OVERRIDE_PED_CREW_LOGO_TEXTURE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x95EB5E34F821BABE`
- **Build:** `877`

**C# 签名:**
```csharp
bool OVERRIDE_PED_CREW_LOGO_TEXTURE(int ped, string txd, string txn)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ped` | `Ped` | `int` | - |
| `txd` | `const char*` | `string` | - |
| `txn` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Overriding ped badge texture to a passed texture. It's synced between players (even custom textures!), don't forget to request used dict on *all* clients to make it sync properly. Can be removed by passing empty strings.
```

---

### PASS_KEYBOARD_INPUT_TO_SCALEFORM

- **命名空间:** `GRAPHICS`
- **Hash:** `0xD1C7CB175E012964`
- **JHash:** `0xE9183D3A`
- **Build:** `323`

**C# 签名:**
```csharp
bool PASS_KEYBOARD_INPUT_TO_SCALEFORM(int scaleformHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleformHandle` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### PATCH_DECAL_DIFFUSE_MAP

- **命名空间:** `GRAPHICS`
- **Hash:** `0x8A35C742130C6080`
- **JHash:** `0x335695CF`
- **Build:** `323`

**C# 签名:**
```csharp
void PATCH_DECAL_DIFFUSE_MAP(int decalType, string textureDict, string textureName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `decalType` | `int` | `int` | - |
| `textureDict` | `const char*` | `string` | - |
| `textureName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### PHONEPHOTOEDITOR_IS_ACTIVE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xBCEDB009461DA156`
- **JHash:** `0x5AB94128`
- **Build:** `323`

**C# 签名:**
```csharp
bool PHONEPHOTOEDITOR_IS_ACTIVE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### PHONEPHOTOEDITOR_SET_FRAME_TXD

- **命名空间:** `GRAPHICS`
- **Hash:** `0x27FEB5254759CDE3`
- **JHash:** `0xD63FCB3E`
- **Build:** `323`

**C# 签名:**
```csharp
bool PHONEPHOTOEDITOR_SET_FRAME_TXD(string textureDict, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `textureDict` | `const char*` | `string` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### PHONEPHOTOEDITOR_TOGGLE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x7AC24EAB6D74118D`
- **JHash:** `0xB2410EAB`
- **Build:** `323`

**C# 签名:**
```csharp
bool PHONEPHOTOEDITOR_TOGGLE(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### PLAY_BINK_MOVIE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x70D2CC8A542A973C`
- **Build:** `1290`

**C# 签名:**
```csharp
void PLAY_BINK_MOVIE(int binkMovie)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `binkMovie` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### POP_TIMECYCLE_MODIFIER

- **命名空间:** `GRAPHICS`
- **Hash:** `0x3C8938D7D872211E`
- **JHash:** `0x79D7D235`
- **Build:** `323`

**C# 签名:**
```csharp
void POP_TIMECYCLE_MODIFIER()
```

**返回值:** `void` (Native: `void`)

---

### PRESET_INTERIOR_AMBIENT_CACHE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xD7021272EB0A451E`
- **JHash:** `0x137E3E24`
- **Build:** `323`

**C# 签名:**
```csharp
void PRESET_INTERIOR_AMBIENT_CACHE(string timecycleModifierName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `timecycleModifierName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Only one match in the scripts:

GRAPHICS::PRESET_INTERIOR_AMBIENT_CACHE("int_carrier_hanger");
```

---

### PROCGRASS_DISABLE_AMBSCALESCAN

- **命名空间:** `GRAPHICS`
- **Hash:** `0x0218BA067D249DEA`
- **Build:** `323`

**C# 签名:**
```csharp
void PROCGRASS_DISABLE_AMBSCALESCAN()
```

**返回值:** `void` (Native: `void`)

---

### PROCGRASS_DISABLE_CULLSPHERE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x649C97D52332341A`
- **Build:** `323`

**C# 签名:**
```csharp
void PROCGRASS_DISABLE_CULLSPHERE(int handle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `handle` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PROCGRASS_ENABLE_AMBSCALESCAN

- **命名空间:** `GRAPHICS`
- **Hash:** `0x14FC5833464340A8`
- **Build:** `323`

**C# 签名:**
```csharp
void PROCGRASS_ENABLE_AMBSCALESCAN()
```

**返回值:** `void` (Native: `void`)

---

### PROCGRASS_ENABLE_CULLSPHERE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xAE51BC858F32BA66`
- **Build:** `323`

**C# 签名:**
```csharp
void PROCGRASS_ENABLE_CULLSPHERE(int handle, float x, float y, float z, float scale)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `handle` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `scale` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### PROCGRASS_IS_CULLSPHERE_ENABLED

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2C42340F916C5930`
- **Build:** `323`

**C# 签名:**
```csharp
bool PROCGRASS_IS_CULLSPHERE_ENABLED(int handle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `handle` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### PUSH_TIMECYCLE_MODIFIER

- **命名空间:** `GRAPHICS`
- **Hash:** `0x58F735290861E6B4`
- **JHash:** `0x7E082045`
- **Build:** `323`

**C# 签名:**
```csharp
void PUSH_TIMECYCLE_MODIFIER()
```

**返回值:** `void` (Native: `void`)

---

### QUERY_MOVIE_MESH_SET_STATE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x9B6E70C5CEEF4EEB`
- **JHash:** `0x9D5D9B38`
- **Build:** `323`

**C# 签名:**
```csharp
int QUERY_MOVIE_MESH_SET_STATE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### QUEUE_OPERATION_TO_CREATE_SORTED_LIST_OF_PHOTOS

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2A893980E96B659A`
- **JHash:** `0x199FABF0`
- **Build:** `323`

**C# 签名:**
```csharp
bool QUEUE_OPERATION_TO_CREATE_SORTED_LIST_OF_PHOTOS(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
2 matches across 2 scripts. Only showed in appcamera & appmedia. Both were 0.
```

---

### REGISTER_ENTITY_FOR_CUTSCENE

- **命名空间:** `CUTSCENE`
- **Hash:** `0xE40C1C56DF95C2E8`
- **JHash:** `0x7CBC3EC7`
- **Build:** `323`

**C# 签名:**
```csharp
void REGISTER_ENTITY_FOR_CUTSCENE(int cutscenePed, string cutsceneEntName, int p2, uint modelHash, int p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cutscenePed` | `Ped` | `int` | - |
| `cutsceneEntName` | `const char*` | `string` | - |
| `p2` | `int` | `int` | - |
| `modelHash` | `Hash` | `uint` | - |
| `p4` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REGISTER_NOIR_LENS_EFFECT

- **命名空间:** `GRAPHICS`
- **Hash:** `0xA44FF770DFBC5DAE`
- **Build:** `323`

**C# 签名:**
```csharp
void REGISTER_NOIR_LENS_EFFECT()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Used with 'NG_filmnoir_BW{01,02}' timecycles and the "NOIR_FILTER_SOUNDS" audioref.
```

---

### REGISTER_POSTFX_BULLET_IMPACT

- **命名空间:** `GRAPHICS`
- **Hash:** `0x170911F37F646F29`
- **Build:** `2802`

**C# 签名:**
```csharp
void REGISTER_POSTFX_BULLET_IMPACT(float weaponWorldPosX, float weaponWorldPosY, float weaponWorldPosZ, float intensity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponWorldPosX` | `float` | `float` | - |
| `weaponWorldPosY` | `float` | `float` | - |
| `weaponWorldPosZ` | `float` | `float` | - |
| `intensity` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### RELEASE_BINK_MOVIE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x04D950EEFA4EED8C`
- **Build:** `1290`

**C# 签名:**
```csharp
void RELEASE_BINK_MOVIE(int binkMovie)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `binkMovie` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RELEASE_MOVIE_MESH_SET

- **命名空间:** `GRAPHICS`
- **Hash:** `0xEB119AA014E89183`
- **JHash:** `0x4FA5501D`
- **Build:** `323`

**C# 签名:**
```csharp
void RELEASE_MOVIE_MESH_SET(int movieMeshSet)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `movieMeshSet` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_CUTSCENE

- **命名空间:** `CUTSCENE`
- **Hash:** `0x440AF51A3462B86F`
- **JHash:** `0x8052F533`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_CUTSCENE()
```

**返回值:** `void` (Native: `void`)

---

### REMOVE_CUT_FILE

- **命名空间:** `CUTSCENE`
- **Hash:** `0xD00D76A7DFC9D852`
- **JHash:** `0xB70D7C6D`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_CUT_FILE(string cutsceneName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cutsceneName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Simply unloads the cutscene and doesn't do extra stuff that REMOVE_CUTSCENE does.
Full list of cutscene names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/cutsceneNames.json
```

---

### REMOVE_DECAL

- **命名空间:** `GRAPHICS`
- **Hash:** `0xED3F346429CCD659`
- **JHash:** `0xA4363188`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_DECAL(int decal)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `decal` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_DECALS_FROM_OBJECT

- **命名空间:** `GRAPHICS`
- **Hash:** `0xCCF71CBDDF5B6CB9`
- **JHash:** `0x8B67DCA7`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_DECALS_FROM_OBJECT(int obj)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `obj` | `Object` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_DECALS_FROM_OBJECT_FACING

- **命名空间:** `GRAPHICS`
- **Hash:** `0xA6F6F70FDC6D144C`
- **JHash:** `0xF4999A55`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_DECALS_FROM_OBJECT_FACING(int obj, float x, float y, float z)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `obj` | `Object` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_DECALS_FROM_VEHICLE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xE91F1B65F2B48D57`
- **JHash:** `0x831D06CA`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_DECALS_FROM_VEHICLE(int vehicle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_DECALS_IN_RANGE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x5D6B2D4830A67C62`
- **JHash:** `0x06A619A0`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_DECALS_IN_RANGE(float x, float y, float z, float range)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `range` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Removes all decals in range from a position, it includes the bullet holes, blood pools, petrol...
```

---

### REMOVE_GRASS_CULL_SPHERE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x61F95E5BB3E0A8C6`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_GRASS_CULL_SPHERE(int handle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `handle` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native does absolutely nothing, just a nullsub
```

---

### REMOVE_PARTICLE_FX

- **命名空间:** `GRAPHICS`
- **Hash:** `0xC401503DFE8D53CF`
- **JHash:** `0x6BA48C7E`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_PARTICLE_FX(int ptfxHandle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ptfxHandle` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_PARTICLE_FX_FROM_ENTITY

- **命名空间:** `GRAPHICS`
- **Hash:** `0xB8FEAEEBCC127425`
- **JHash:** `0xCEDE52E9`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_PARTICLE_FX_FROM_ENTITY(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_PARTICLE_FX_IN_RANGE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xDD19FA1C6D657305`
- **JHash:** `0x7EB8F275`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_PARTICLE_FX_IN_RANGE(float X, float Y, float Z, float radius)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `X` | `float` | `float` | - |
| `Y` | `float` | `float` | - |
| `Z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_SCALEFORM_SCRIPT_HUD_MOVIE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xF44A5456AC3F4F97`
- **JHash:** `0x03D87600`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_SCALEFORM_SCRIPT_HUD_MOVIE(int hudComponent)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `hudComponent` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REMOVE_VEHICLE_CREW_EMBLEM

- **命名空间:** `GRAPHICS`
- **Hash:** `0xD2300034310557E4`
- **JHash:** `0x667046A8`
- **Build:** `323`

**C# 签名:**
```csharp
void REMOVE_VEHICLE_CREW_EMBLEM(int vehicle, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### RENDER_SHADOWED_LIGHTS_WITH_NO_SHADOWS

- **命名空间:** `GRAPHICS`
- **Hash:** `0x03300B57FCAC6DDB`
- **JHash:** `0x60F72371`
- **Build:** `323`

**C# 签名:**
```csharp
void RENDER_SHADOWED_LIGHTS_WITH_NO_SHADOWS(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### REQUEST_CUTSCENE

- **命名空间:** `CUTSCENE`
- **Hash:** `0x7A86743F475D9E09`
- **JHash:** `0xB5977853`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_CUTSCENE(string cutsceneName, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cutsceneName` | `const char*` | `string` | - |
| `flags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
flags: Usually 8
Full list of cutscene names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/cutsceneNames.json
```

---

### REQUEST_CUTSCENE_WITH_PLAYBACK_LIST

- **命名空间:** `CUTSCENE`
- **Hash:** `0xC23DE0E91C30B58C`
- **JHash:** `0xD98F656A`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_CUTSCENE_WITH_PLAYBACK_LIST(string cutsceneName, int playbackFlags, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cutsceneName` | `const char*` | `string` | - |
| `playbackFlags` | `int` | `int` | - |
| `flags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
flags: Usually 8

playbackFlags: Which scenes should be played.
Example: 0x105 (bit 0, 2 and 8 set) will enable scene 1, 3 and 9.
Full list of cutscene names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/cutsceneNames.json
```

---

### REQUEST_CUT_FILE

- **命名空间:** `CUTSCENE`
- **Hash:** `0x06A3524161C502BA`
- **JHash:** `0x0D732CD6`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_CUT_FILE(string cutsceneName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cutsceneName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Simply loads the cutscene and doesn't do extra stuff that REQUEST_CUTSCENE does.
Full list of cutscene names by DurtyFree https://github.com/DurtyFree/gta-v-data-dumps/blob/master/cutsceneNames.json
```

---

### REQUEST_EARLY_LIGHT_CHECK

- **命名空间:** `GRAPHICS`
- **Hash:** `0x98EDF76A7271E4F2`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_EARLY_LIGHT_CHECK()
```

**返回值:** `void` (Native: `void`)

---

### REQUEST_SCALEFORM_MOVIE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x11FE353CF9733E6F`
- **JHash:** `0xC67E3DCB`
- **Build:** `323`

**C# 签名:**
```csharp
int REQUEST_SCALEFORM_MOVIE(string scaleformName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleformName` | `const char*` | `string` | - |

**返回值:** `int` (Native: `int`)

---

### REQUEST_SCALEFORM_MOVIE_INSTANCE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xC514489CFB8AF806`
- **JHash:** `0x7CC8057D`
- **Build:** `323`

**C# 签名:**
```csharp
int REQUEST_SCALEFORM_MOVIE_INSTANCE(string scaleformName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleformName` | `const char*` | `string` | - |

**返回值:** `int` (Native: `int`)

---

### REQUEST_SCALEFORM_MOVIE_SKIP_RENDER_WHILE_PAUSED

- **命名空间:** `GRAPHICS`
- **Hash:** `0xBD06C611BB9048C2`
- **Build:** `323`

**C# 签名:**
```csharp
int REQUEST_SCALEFORM_MOVIE_SKIP_RENDER_WHILE_PAUSED(string scaleformName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleformName` | `const char*` | `string` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Similar to REQUEST_SCALEFORM_MOVIE, but seems to be some kind of "interactive" scaleform movie?

These seem to be the only scaleforms ever requested by this native:
"breaking_news"
"desktop_pc"
"ECG_MONITOR"
"Hacking_PC"
"TEETH_PULLING"

Note: Unless this hash is out-of-order, this native is next-gen only.

```

---

### REQUEST_SCALEFORM_MOVIE_WITH_IGNORE_SUPER_WIDESCREEN

- **命名空间:** `GRAPHICS`
- **Hash:** `0x65E7E78842E74CDB`
- **Build:** `372`

**C# 签名:**
```csharp
int REQUEST_SCALEFORM_MOVIE_WITH_IGNORE_SUPER_WIDESCREEN(string scaleformName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleformName` | `const char*` | `string` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Another REQUEST_SCALEFORM_MOVIE equivalent.
```

---

### REQUEST_SCALEFORM_SCRIPT_HUD_MOVIE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x9304881D6F6537EA`
- **JHash:** `0x7AF85862`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_SCALEFORM_SCRIPT_HUD_MOVIE(int hudComponent)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `hudComponent` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### REQUEST_STREAMED_TEXTURE_DICT

- **命名空间:** `GRAPHICS`
- **Hash:** `0xDFA2EF8E04127DD5`
- **JHash:** `0x4C9B035F`
- **Build:** `323`

**C# 签名:**
```csharp
void REQUEST_STREAMED_TEXTURE_DICT(string textureDict, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `textureDict` | `const char*` | `string` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This function can requests texture dictonaries from following RPFs:
scaleform_generic.rpf
scaleform_minigames.rpf
scaleform_minimap.rpf
scaleform_web.rpf

last param isnt a toggle
```

---

### RESET_ADAPTATION

- **命名空间:** `GRAPHICS`
- **Hash:** `0xE3E2C1B4C59DBC77`
- **JHash:** `0xD8CC7221`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_ADAPTATION(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets an value related to timecycles.
```

---

### RESET_PARTICLE_FX_OVERRIDE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x89C8553DD3274AAE`
- **JHash:** `0x9E8D8B72`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_PARTICLE_FX_OVERRIDE(string name)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Resets the effect of SET_PARTICLE_FX_OVERRIDE

Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
```

---

### RESET_PAUSED_RENDERPHASES

- **命名空间:** `GRAPHICS`
- **Hash:** `0xE1C8709406F2C41C`
- **JHash:** `0x0113EAE4`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_PAUSED_RENDERPHASES()
```

**返回值:** `void` (Native: `void`)

---

### RESET_SCRIPT_GFX_ALIGN

- **命名空间:** `GRAPHICS`
- **Hash:** `0xE3A3DB414A373DAB`
- **JHash:** `0x3FE33BD6`
- **Build:** `323`

**C# 签名:**
```csharp
void RESET_SCRIPT_GFX_ALIGN()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
This function resets the alignment set using SET_SCRIPT_GFX_ALIGN and SET_SCRIPT_GFX_ALIGN_PARAMS to the default values ('I', 'I'; 0, 0, 0, 0).
This should be used after having used the aforementioned functions in order to not affect any other scripts attempting to draw.
```

---

### SAVE_HIGH_QUALITY_PHOTO

- **命名空间:** `GRAPHICS`
- **Hash:** `0x3DEC726C25A11BAC`
- **JHash:** `0x3B15D33C`
- **Build:** `323`

**C# 签名:**
```csharp
bool SAVE_HIGH_QUALITY_PHOTO(int unused)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `unused` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
1 match in 1 script. cellphone_controller.
p0 is -1 in scripts.
```

---

### SCALEFORM_MOVIE_METHOD_ADD_PARAM_BOOL

- **命名空间:** `GRAPHICS`
- **Hash:** `0xC58424BA936EB458`
- **JHash:** `0x0D4AE8CB`
- **Build:** `323`

**C# 签名:**
```csharp
void SCALEFORM_MOVIE_METHOD_ADD_PARAM_BOOL(bool value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Pushes a boolean for the Scaleform function onto the stack.
```

---

### SCALEFORM_MOVIE_METHOD_ADD_PARAM_FLOAT

- **命名空间:** `GRAPHICS`
- **Hash:** `0xD69736AAE04DB51A`
- **JHash:** `0x9A01FFDA`
- **Build:** `323`

**C# 签名:**
```csharp
void SCALEFORM_MOVIE_METHOD_ADD_PARAM_FLOAT(float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Pushes a float for the Scaleform function onto the stack.
```

---

### SCALEFORM_MOVIE_METHOD_ADD_PARAM_INT

- **命名空间:** `GRAPHICS`
- **Hash:** `0xC3D0841A0CC546A6`
- **JHash:** `0x716777CB`
- **Build:** `323`

**C# 签名:**
```csharp
void SCALEFORM_MOVIE_METHOD_ADD_PARAM_INT(int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Pushes an integer for the Scaleform function onto the stack.
```

---

### SCALEFORM_MOVIE_METHOD_ADD_PARAM_LATEST_BRIEF_STRING

- **命名空间:** `GRAPHICS`
- **Hash:** `0xEC52C631A1831C03`
- **JHash:** `0x83A9811D`
- **Build:** `323`

**C# 签名:**
```csharp
void SCALEFORM_MOVIE_METHOD_ADD_PARAM_LATEST_BRIEF_STRING(int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SCALEFORM_MOVIE_METHOD_ADD_PARAM_LITERAL_STRING

- **命名空间:** `GRAPHICS`
- **Hash:** `0x77FE3402004CD1B0`
- **Build:** `573`

**C# 签名:**
```csharp
void SCALEFORM_MOVIE_METHOD_ADD_PARAM_LITERAL_STRING(string string)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `string` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Same as SCALEFORM_MOVIE_METHOD_ADD_PARAM_TEXTURE_NAME_STRING
Both SCALEFORM_MOVIE_METHOD_ADD_PARAM_TEXTURE_NAME_STRING / _SCALEFORM_MOVIE_METHOD_ADD_PARAM_TEXTURE_NAME_STRING_2 works, but _SCALEFORM_MOVIE_METHOD_ADD_PARAM_TEXTURE_NAME_STRING_2 is usually used for "name" (organisation, players..).
```

---

### SCALEFORM_MOVIE_METHOD_ADD_PARAM_PLAYER_NAME_STRING

- **命名空间:** `GRAPHICS`
- **Hash:** `0xE83A3E3557A56640`
- **JHash:** `0xCCBF0334`
- **Build:** `323`

**C# 签名:**
```csharp
void SCALEFORM_MOVIE_METHOD_ADD_PARAM_PLAYER_NAME_STRING(string string)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `string` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### SCALEFORM_MOVIE_METHOD_ADD_PARAM_TEXTURE_NAME_STRING

- **命名空间:** `GRAPHICS`
- **Hash:** `0xBA7148484BD90365`
- **JHash:** `0x4DAAD55B`
- **Build:** `323`

**C# 签名:**
```csharp
void SCALEFORM_MOVIE_METHOD_ADD_PARAM_TEXTURE_NAME_STRING(string string)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `string` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### SEETHROUGH_GET_MAX_THICKNESS

- **命名空间:** `GRAPHICS`
- **Hash:** `0x43DBAE39626CE83F`
- **Build:** `1290`

**C# 签名:**
```csharp
float SEETHROUGH_GET_MAX_THICKNESS()
```

**返回值:** `float` (Native: `float`)

---

### SEETHROUGH_RESET

- **命名空间:** `GRAPHICS`
- **Hash:** `0x70A64C0234EF522C`
- **JHash:** `0x310E9B67`
- **Build:** `323`

**C# 签名:**
```csharp
void SEETHROUGH_RESET()
```

**返回值:** `void` (Native: `void`)

---

### SEETHROUGH_SET_COLOR_NEAR

- **命名空间:** `GRAPHICS`
- **Hash:** `0x1086127B3A63505E`
- **JHash:** `0x5B2A67A8`
- **Build:** `573`

**C# 签名:**
```csharp
void SEETHROUGH_SET_COLOR_NEAR(int red, int green, int blue)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SEETHROUGH_SET_FADE_ENDDISTANCE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x9D75795B9DC6EBBF`
- **Build:** `573`

**C# 签名:**
```csharp
void SEETHROUGH_SET_FADE_ENDDISTANCE(float distance)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `distance` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SEETHROUGH_SET_FADE_STARTDISTANCE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xA78DE25577300BA1`
- **Build:** `573`

**C# 签名:**
```csharp
void SEETHROUGH_SET_FADE_STARTDISTANCE(float distance)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `distance` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SEETHROUGH_SET_HEATSCALE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xD7D0B00177485411`
- **JHash:** `0x654F0287`
- **Build:** `323`

**C# 签名:**
```csharp
void SEETHROUGH_SET_HEATSCALE(int index, float heatScale)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |
| `heatScale` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
min: 0.0
max: 0.75
```

---

### SEETHROUGH_SET_HIGHLIGHT_NOISE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x1636D7FC127B10D2`
- **Build:** `573`

**C# 签名:**
```csharp
void SEETHROUGH_SET_HIGHLIGHT_NOISE(float noise)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `noise` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SEETHROUGH_SET_HILIGHT_INTENSITY

- **命名空间:** `GRAPHICS`
- **Hash:** `0x19E50EB6E33E1D28`
- **Build:** `573`

**C# 签名:**
```csharp
void SEETHROUGH_SET_HILIGHT_INTENSITY(float intensity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `intensity` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SEETHROUGH_SET_MAX_THICKNESS

- **命名空间:** `GRAPHICS`
- **Hash:** `0x0C8FAC83902A62DF`
- **Build:** `573`

**C# 签名:**
```csharp
void SEETHROUGH_SET_MAX_THICKNESS(float thickness)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `thickness` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
0.0 = you will not be able to see people behind the walls. 50.0 and more = you will see everyone through the walls. More value is "better" view. See https://gfycat.com/FirmFlippantGourami
min: 1.0
max: 10000.0
```

---

### SEETHROUGH_SET_NOISE_MAX

- **命名空间:** `GRAPHICS`
- **Hash:** `0xFEBFBFDFB66039DE`
- **Build:** `573`

**C# 签名:**
```csharp
void SEETHROUGH_SET_NOISE_MAX(float amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SEETHROUGH_SET_NOISE_MIN

- **命名空间:** `GRAPHICS`
- **Hash:** `0xFF5992E1C9E65D05`
- **Build:** `573`

**C# 签名:**
```csharp
void SEETHROUGH_SET_NOISE_MIN(float amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ARENA_THEME_AND_VARIATION_FOR_TAKEN_PHOTO

- **命名空间:** `GRAPHICS`
- **Hash:** `0xF3F776ADA161E47D`
- **Build:** `1604`

**C# 签名:**
```csharp
void SET_ARENA_THEME_AND_VARIATION_FOR_TAKEN_PHOTO(object p0, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ARTIFICIAL_LIGHTS_STATE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x1268615ACE24D504`
- **JHash:** `0xAA2A0EAF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ARTIFICIAL_LIGHTS_STATE(bool state)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `state` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Does not affect weapons, particles, fire/explosions, flashlights or the sun.
When set to true, all emissive textures (including ped components that have light effects), street lights, building lights, vehicle lights, etc will all be turned off.

Used in Humane Labs Heist for EMP.

state: True turns off all artificial light sources in the map: buildings, street lights, car lights, etc. False turns them back on.
```

---

### SET_ARTIFICIAL_VEHICLE_LIGHTS_STATE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xE2B187C0939B3D32`
- **Build:** `2060`

**C# 签名:**
```csharp
void SET_ARTIFICIAL_VEHICLE_LIGHTS_STATE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
If "blackout" is enabled, this native allows you to ignore "blackout" for vehicles.
```

---

### SET_BACKFACECULLING

- **命名空间:** `GRAPHICS`
- **Hash:** `0x23BA6B0C2AD7B0D3`
- **JHash:** `0xC44C2F44`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_BACKFACECULLING(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_BINK_MOVIE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x338D9F609FD632DB`
- **Build:** `1290`

**C# 签名:**
```csharp
int SET_BINK_MOVIE(string name)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |

**返回值:** `int` (Native: `int`)

---

### SET_BINK_MOVIE_AUDIO_FRONTEND

- **命名空间:** `GRAPHICS`
- **Hash:** `0xF816F2933752322D`
- **Build:** `1868`

**C# 签名:**
```csharp
void SET_BINK_MOVIE_AUDIO_FRONTEND(int binkMovie, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `binkMovie` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_BINK_MOVIE_TIME

- **命名空间:** `GRAPHICS`
- **Hash:** `0x0CB6B3446855B57A`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_BINK_MOVIE_TIME(int binkMovie, float progress)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `binkMovie` | `int` | `int` | - |
| `progress` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
In percentage: 0.0 - 100.0
```

---

### SET_BINK_MOVIE_VOLUME

- **命名空间:** `GRAPHICS`
- **Hash:** `0xAFF33B1178172223`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_BINK_MOVIE_VOLUME(int binkMovie, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `binkMovie` | `int` | `int` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
binkMovie: Is return value from _SET_BINK_MOVIE. Has something to do with bink volume? (audRequestedSettings::SetVolumeCurveScale)
```

---

### SET_BINK_SHOULD_SKIP

- **命名空间:** `GRAPHICS`
- **Hash:** `0x6805D58CAA427B72`
- **Build:** `1290`

**C# 签名:**
```csharp
void SET_BINK_SHOULD_SKIP(int binkMovie, bool bShouldSkip)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `binkMovie` | `int` | `int` | - |
| `bShouldSkip` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CAN_DISPLAY_MINIMAP_DURING_CUTSCENE_THIS_UPDATE

- **命名空间:** `CUTSCENE`
- **Hash:** `0x2131046957F31B04`
- **JHash:** `0xB60CFBB9`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAN_DISPLAY_MINIMAP_DURING_CUTSCENE_THIS_UPDATE()
```

**返回值:** `void` (Native: `void`)

---

### SET_CAR_GENERATORS_CAN_UPDATE_DURING_CUTSCENE

- **命名空间:** `CUTSCENE`
- **Hash:** `0xE36A98D8AB3D3C66`
- **JHash:** `0x04377C10`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CAR_GENERATORS_CAN_UPDATE_DURING_CUTSCENE(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CHECKPOINT_CLIPPLANE_WITH_POS_NORM

- **命名空间:** `GRAPHICS`
- **Hash:** `0xF51D36185993515D`
- **JHash:** `0x20EABD0F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CHECKPOINT_CLIPPLANE_WITH_POS_NORM(int checkpoint, float posX, float posY, float posZ, float unkX, float unkY, float unkZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `checkpoint` | `int` | `int` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `unkX` | `float` | `float` | - |
| `unkY` | `float` | `float` | - |
| `unkZ` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This does not move an existing checkpoint... so wtf.
```

---

### SET_CHECKPOINT_CYLINDER_HEIGHT

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2707AAE9D9297D89`
- **JHash:** `0xFF0F9B22`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CHECKPOINT_CYLINDER_HEIGHT(int checkpoint, float nearHeight, float farHeight, float radius)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `checkpoint` | `int` | `int` | - |
| `nearHeight` | `float` | `float` | - |
| `farHeight` | `float` | `float` | - |
| `radius` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the cylinder height of the checkpoint.

Parameters:
* nearHeight - The height of the checkpoint when inside of the radius.
* farHeight - The height of the checkpoint when outside of the radius.
* radius - The radius of the checkpoint.
```

---

### SET_CHECKPOINT_DECAL_ROT_ALIGNED_TO_CAMERA_ROT

- **命名空间:** `GRAPHICS`
- **Hash:** `0x615D3925E87A3B26`
- **JHash:** `0x1E3A3126`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CHECKPOINT_DECAL_ROT_ALIGNED_TO_CAMERA_ROT(int checkpoint)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `checkpoint` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Unknown. Called after creating a checkpoint (type: 51) in the creators.
```

---

### SET_CHECKPOINT_DIRECTION

- **命名空间:** `GRAPHICS`
- **Hash:** `0x3C788E7F6438754D`
- **Build:** `1180`

**C# 签名:**
```csharp
void SET_CHECKPOINT_DIRECTION(int checkpoint, float posX, float posY, float posZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `checkpoint` | `int` | `int` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CHECKPOINT_FORCE_DIRECTION

- **命名空间:** `GRAPHICS`
- **Hash:** `0xDB1EA9411C8911EC`
- **Build:** `1180`

**C# 签名:**
```csharp
void SET_CHECKPOINT_FORCE_DIRECTION(int checkpoint)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `checkpoint` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CHECKPOINT_FORCE_OLD_ARROW_POINTING

- **命名空间:** `GRAPHICS`
- **Hash:** `0xFCF6788FC4860CD4`
- **Build:** `1734`

**C# 签名:**
```csharp
void SET_CHECKPOINT_FORCE_OLD_ARROW_POINTING(int checkpoint)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `checkpoint` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CHECKPOINT_INSIDE_CYLINDER_HEIGHT_SCALE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x4B5B4DA5D79F1943`
- **JHash:** `0x80151CCF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CHECKPOINT_INSIDE_CYLINDER_HEIGHT_SCALE(int checkpoint, float scale)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `checkpoint` | `int` | `int` | - |
| `scale` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CHECKPOINT_INSIDE_CYLINDER_SCALE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x44621483FF966526`
- **Build:** `877`

**C# 签名:**
```csharp
void SET_CHECKPOINT_INSIDE_CYLINDER_SCALE(int checkpoint, float scale)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `checkpoint` | `int` | `int` | - |
| `scale` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CHECKPOINT_RGBA

- **命名空间:** `GRAPHICS`
- **Hash:** `0x7167371E8AD747F7`
- **JHash:** `0xEF9C8CB3`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CHECKPOINT_RGBA(int checkpoint, int red, int green, int blue, int alpha)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `checkpoint` | `int` | `int` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the checkpoint color.
```

---

### SET_CHECKPOINT_RGBA2

- **命名空间:** `GRAPHICS`
- **Hash:** `0xB9EA40907C680580`
- **JHash:** `0xA5456DBB`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CHECKPOINT_RGBA2(int checkpoint, int red, int green, int blue, int alpha)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `checkpoint` | `int` | `int` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the checkpoint icon color.
```

---

### SET_CURRENT_PLAYER_TCMODIFIER

- **命名空间:** `GRAPHICS`
- **Hash:** `0xBBF327DED94E4DEB`
- **JHash:** `0x85BA15A4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CURRENT_PLAYER_TCMODIFIER(string modifierName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modifierName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CUTSCENE_CAN_BE_SKIPPED

- **命名空间:** `CUTSCENE`
- **Hash:** `0x41FAA8FB2ECE8720`
- **JHash:** `0x28D54A7F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CUTSCENE_CAN_BE_SKIPPED(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CUTSCENE_ENTITY_STREAMING_FLAGS

- **命名空间:** `CUTSCENE`
- **Hash:** `0x4C61C75BEE8184C2`
- **JHash:** `0x47DB08A9`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CUTSCENE_ENTITY_STREAMING_FLAGS(string cutsceneEntName, int p1, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cutsceneEntName` | `const char*` | `string` | - |
| `p1` | `int` | `int` | - |
| `p2` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CUTSCENE_FADE_VALUES

- **命名空间:** `CUTSCENE`
- **Hash:** `0x8093F23ABACCC7D4`
- **JHash:** `0xD19EF0DD`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CUTSCENE_FADE_VALUES(bool p0, bool p1, bool p2, bool p3)
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

### SET_CUTSCENE_MULTIHEAD_FADE

- **命名空间:** `CUTSCENE`
- **Hash:** `0x20746F7B1032A3C7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CUTSCENE_MULTIHEAD_FADE(bool p0, bool p1, bool p2, bool p3)
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

### SET_CUTSCENE_MULTIHEAD_FADE_MANUAL

- **命名空间:** `CUTSCENE`
- **Hash:** `0x06EE9048FD080382`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CUTSCENE_MULTIHEAD_FADE_MANUAL(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CUTSCENE_ORIGIN

- **命名空间:** `CUTSCENE`
- **Hash:** `0xB812B3FD1C01CF27`
- **JHash:** `0xB0AD7792`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CUTSCENE_ORIGIN(float x, float y, float z, float p3, int p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p3` | `float` | `float` | - |
| `p4` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p3 could be heading. Needs more research.
```

---

### SET_CUTSCENE_ORIGIN_AND_ORIENTATION

- **命名空间:** `CUTSCENE`
- **Hash:** `0x011883F41211432A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CUTSCENE_ORIGIN_AND_ORIENTATION(float x1, float y1, float z1, float x2, float y2, float z2, int p6)
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
| `p6` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CUTSCENE_PED_COMPONENT_VARIATION

- **命名空间:** `CUTSCENE`
- **Hash:** `0xBA01E7B6DEEFBBC9`
- **JHash:** `0x6AF994A1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CUTSCENE_PED_COMPONENT_VARIATION(string cutsceneEntName, int componentId, int drawableId, int textureId, uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cutsceneEntName` | `const char*` | `string` | - |
| `componentId` | `int` | `int` | - |
| `drawableId` | `int` | `int` | - |
| `textureId` | `int` | `int` | - |
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of ped components by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pedComponentVariations.json
```

---

### SET_CUTSCENE_PED_COMPONENT_VARIATION_FROM_PED

- **命名空间:** `CUTSCENE`
- **Hash:** `0x2A56C06EBEF2B0D9`
- **JHash:** `0x1E7DA95E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CUTSCENE_PED_COMPONENT_VARIATION_FROM_PED(string cutsceneEntName, int ped, uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cutsceneEntName` | `const char*` | `string` | - |
| `ped` | `Ped` | `int` | - |
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### SET_CUTSCENE_PED_PROP_VARIATION

- **命名空间:** `CUTSCENE`
- **Hash:** `0x0546524ADE2E9723`
- **JHash:** `0x22E9A9DE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CUTSCENE_PED_PROP_VARIATION(string cutsceneEntName, int componentId, int drawableId, int textureId, uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cutsceneEntName` | `const char*` | `string` | - |
| `componentId` | `int` | `int` | - |
| `drawableId` | `int` | `int` | - |
| `textureId` | `int` | `int` | - |
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Thanks R*! ;)

if ((l_161 == 0) || (l_161 == 2)) {
    sub_2ea27("Trying to set Jimmy prop variation");
    CUTSCENE::SET_CUTSCENE_PED_PROP_VARIATION("Jimmy_Boston", 1, 0, 0, 0);
}

Full list of ped components by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pedComponentVariations.json
```

---

### SET_CUTSCENE_TRIGGER_AREA

- **命名空间:** `CUTSCENE`
- **Hash:** `0x9896CE4721BE84BA`
- **JHash:** `0x9D76D9DE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_CUTSCENE_TRIGGER_AREA(float x1, float y1, float z1, float x2, float y2, float z2)
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
Only used twice in R* scripts
```

---

### SET_DEBUG_LINES_AND_SPHERES_DRAWING_ACTIVE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x175B6BFC15CDD0C5`
- **JHash:** `0x1418CA37`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DEBUG_LINES_AND_SPHERES_DRAWING_ACTIVE(bool enabled)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `enabled` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
NOTE: Debugging functions are not present in the retail version of the game.
```

---

### SET_DECAL_BULLET_IMPACT_RANGE_SCALE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x46D1A61A21F566FC`
- **JHash:** `0x2056A015`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DECAL_BULLET_IMPACT_RANGE_SCALE(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DEPTHWRITING

- **命名空间:** `GRAPHICS`
- **Hash:** `0xC5C8F970D4EDFF71`
- **Build:** `877`

**C# 签名:**
```csharp
void SET_DEPTHWRITING(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DISABLE_DECAL_RENDERING_THIS_FRAME

- **命名空间:** `GRAPHICS`
- **Hash:** `0x4B5CFC83122DF602`
- **JHash:** `0xA706E84D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DISABLE_DECAL_RENDERING_THIS_FRAME()
```

**返回值:** `void` (Native: `void`)

---

### SET_DISABLE_PETROL_DECALS_IGNITING_THIS_FRAME

- **命名空间:** `GRAPHICS`
- **Hash:** `0xD9454B5752C857DC`
- **JHash:** `0xEAB6417C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DISABLE_PETROL_DECALS_IGNITING_THIS_FRAME()
```

**返回值:** `void` (Native: `void`)

---

### SET_DISABLE_PETROL_DECALS_RECYCLING_THIS_FRAME

- **命名空间:** `GRAPHICS`
- **Hash:** `0x27CFB1B1E078CB2D`
- **JHash:** `0xC2703B88`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DISABLE_PETROL_DECALS_RECYCLING_THIS_FRAME()
```

**返回值:** `void` (Native: `void`)

---

### SET_DISTANCE_BLUR_STRENGTH_OVERRIDE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xE2892E7E55D7073A`
- **JHash:** `0x455F1084`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DISTANCE_BLUR_STRENGTH_OVERRIDE(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_DRAW_ORIGIN

- **命名空间:** `GRAPHICS`
- **Hash:** `0xAA0008F3BBB8F416`
- **JHash:** `0xE10198D5`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_DRAW_ORIGIN(float x, float y, float z, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the on-screen drawing origin for draw-functions (which is normally x=0,y=0 in the upper left corner of the screen) to a world coordinate.
From now on, the screen coordinate which displays the given world coordinate on the screen is seen as x=0,y=0.

Example in C#:
Vector3 boneCoord = somePed.GetBoneCoord(Bone.SKEL_Head);
Function.Call(Hash.SET_DRAW_ORIGIN, boneCoord.X, boneCoord.Y, boneCoord.Z, 0);
Function.Call(Hash.DRAW_SPRITE, "helicopterhud", "hud_corner", -0.01, -0.015, 0.013, 0.013, 0.0, 255, 0, 0, 200);
Function.Call(Hash.DRAW_SPRITE, "helicopterhud", "hud_corner", 0.01, -0.015, 0.013, 0.013, 90.0, 255, 0, 0, 200);
Function.Call(Hash.DRAW_SPRITE, "helicopterhud", "hud_corner", -0.01, 0.015, 0.013, 0.013, 270.0, 255, 0, 0, 200);
Function.Call(Hash.DRAW_SPRITE, "helicopterhud", "hud_corner", 0.01, 0.015, 0.013, 0.013, 180.0, 255, 0, 0, 200);
Function.Call(Hash.CLEAR_DRAW_ORIGIN);

Result: www11.pic-upload.de/19.06.15/bkqohvil2uao.jpg
If the pedestrian starts walking around now, the sprites are always around her head, no matter where the head is displayed on the screen.

This function also effects the drawing of texts and other UI-elements.
The effect can be reset by calling GRAPHICS::CLEAR_DRAW_ORIGIN().
```

---

### SET_ENTITY_ICON_COLOR

- **命名空间:** `GRAPHICS`
- **Hash:** `0x1D5F595CCAE2E238`
- **JHash:** `0x6EE1E946`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_ICON_COLOR(int entity, int red, int green, int blue, int alpha)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `red` | `int` | `int` | - |
| `green` | `int` | `int` | - |
| `blue` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ENTITY_ICON_VISIBILITY

- **命名空间:** `GRAPHICS`
- **Hash:** `0xE0E8BEECCA96BA31`
- **JHash:** `0xD1D2FD52`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_ENTITY_ICON_VISIBILITY(int entity, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_EXPOSURETWEAK

- **命名空间:** `GRAPHICS`
- **Hash:** `0xEF398BEEE4EF45F9`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_EXPOSURETWEAK(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_EXTRA_TCMODIFIER

- **命名空间:** `GRAPHICS`
- **Hash:** `0x5096FD9CCB49056D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_EXTRA_TCMODIFIER(string modifierName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modifierName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of timecycle modifiers by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/timecycleModifiers.json
```

---

### SET_FLASH

- **命名空间:** `GRAPHICS`
- **Hash:** `0x0AB84296FED9CFC6`
- **JHash:** `0x7E55A1EE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FLASH(float p0, float p1, float fadeIn, float duration, float fadeOut)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `float` | `float` | - |
| `fadeIn` | `float` | `float` | - |
| `duration` | `float` | `float` | - |
| `fadeOut` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Purpose of p0 and p1 unknown.
```

---

### SET_FORCE_MOTIONBLUR

- **命名空间:** `GRAPHICS`
- **Hash:** `0x6A51F78772175A51`
- **Build:** `1011`

**C# 签名:**
```csharp
void SET_FORCE_MOTIONBLUR(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_GRASS_CULL_SPHERE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xBE197EAA669238F4`
- **Build:** `323`

**C# 签名:**
```csharp
int SET_GRASS_CULL_SPHERE(float p0, float p1, float p2, float p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |
| `p3` | `float` | `float` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
This function is hard-coded to always return 0.
```

---

### SET_HIDOF_OVERRIDE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xBA3D65906822BED5`
- **JHash:** `0x513D444B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_HIDOF_OVERRIDE(bool p0, bool p1, float nearplaneOut, float nearplaneIn, float farplaneOut, float farplaneIn)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `p1` | `BOOL` | `bool` | - |
| `nearplaneOut` | `float` | `float` | - |
| `nearplaneIn` | `float` | `float` | - |
| `farplaneOut` | `float` | `float` | - |
| `farplaneIn` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_LIGHT_OVERRIDE_MAX_INTENSITY_SCALE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x9641588DAB93B4B5`
- **Build:** `877`

**C# 签名:**
```csharp
void SET_LIGHT_OVERRIDE_MAX_INTENSITY_SCALE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_LOCK_ADAPTIVE_DOF_DISTANCE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xB569F41F3E7E83A4`
- **Build:** `1103`

**C# 签名:**
```csharp
void SET_LOCK_ADAPTIVE_DOF_DISTANCE(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_MOTIONBLUR_MAX_VEL_SCALER

- **命名空间:** `GRAPHICS`
- **Hash:** `0xB3C641F3630BF6DA`
- **JHash:** `0xF6B837F0`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_MOTIONBLUR_MAX_VEL_SCALER(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Setter for GET_MOTIONBLUR_MAX_VEL_SCALER
```

---

### SET_NEXT_PLAYER_TCMODIFIER

- **命名空间:** `GRAPHICS`
- **Hash:** `0xBF59707B3E5ED531`
- **JHash:** `0x554BA16E`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_NEXT_PLAYER_TCMODIFIER(string modifierName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modifierName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### SET_NIGHTVISION

- **命名空间:** `GRAPHICS`
- **Hash:** `0x18F621F7A5B1F85D`
- **JHash:** `0xD1E5565F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_NIGHTVISION(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Enables Night Vision.

Example:
C#: Function.Call(Hash.SET_NIGHTVISION, true);
C++: GRAPHICS::SET_NIGHTVISION(true);

BOOL toggle:
true = turns night vision on for your player.
false = turns night vision off for your player.
```

---

### SET_NOISEOVERIDE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xE787BF1C5CF823C9`
- **JHash:** `0xD576F5DD`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_NOISEOVERIDE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_NOISINESSOVERIDE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xCB6A7C3BB17A0C67`
- **JHash:** `0x046B62D9`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_NOISINESSOVERIDE(float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_ON_ISLAND_X_FOR_TAKEN_PHOTO

- **命名空间:** `GRAPHICS`
- **Hash:** `0xADD6627C4D325458`
- **Build:** `2189`

**C# 签名:**
```csharp
void SET_ON_ISLAND_X_FOR_TAKEN_PHOTO(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PAD_CAN_SHAKE_DURING_CUTSCENE

- **命名空间:** `CUTSCENE`
- **Hash:** `0xC61B86C9F61EB404`
- **JHash:** `0x35721A08`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PAD_CAN_SHAKE_DURING_CUTSCENE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Toggles a value (bool) for cutscenes.
```

---

### SET_PARTICLE_FX_BANG_SCRAPE_LODRANGE_SCALE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x54E22EA2C1956A8D`
- **JHash:** `0x8BE3D47F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_BANG_SCRAPE_LODRANGE_SCALE(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PARTICLE_FX_BLOOD_SCALE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x908311265D42A820`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_BLOOD_SCALE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PARTICLE_FX_BULLET_IMPACT_LODRANGE_SCALE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xBB90E12CAC1DAB25`
- **JHash:** `0x3968E915`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_BULLET_IMPACT_LODRANGE_SCALE(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PARTICLE_FX_BULLET_IMPACT_SCALE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x27E32866E9A5C416`
- **JHash:** `0xC1AD5DDF`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_BULLET_IMPACT_SCALE(float scale)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scale` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PARTICLE_FX_BULLET_TRACE_NO_ANGLE_REJECT

- **命名空间:** `GRAPHICS`
- **Hash:** `0xCA4AE345A153D573`
- **JHash:** `0x64BA4648`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_BULLET_TRACE_NO_ANGLE_REJECT(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PARTICLE_FX_CAM_INSIDE_NONPLAYER_VEHICLE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xACEE6F360FC1F6B6`
- **JHash:** `0x6B125A02`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_CAM_INSIDE_NONPLAYER_VEHICLE(int vehicle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PARTICLE_FX_CAM_INSIDE_VEHICLE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xEEC4047028426510`
- **JHash:** `0x19EC0001`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_CAM_INSIDE_VEHICLE(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PARTICLE_FX_FOOT_LODRANGE_SCALE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x949F397A288B28B3`
- **JHash:** `0xE3880F5A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_FOOT_LODRANGE_SCALE(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PARTICLE_FX_FOOT_OVERRIDE_NAME

- **命名空间:** `GRAPHICS`
- **Hash:** `0xBA3D194057C79A7B`
- **Build:** `877`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_FOOT_OVERRIDE_NAME(string p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
```

---

### SET_PARTICLE_FX_FORCE_VEHICLE_INTERIOR

- **命名空间:** `GRAPHICS`
- **Hash:** `0x8CDE909A0370BB3A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_FORCE_VEHICLE_INTERIOR(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Used only once in the scripts (taxi_clowncar)
```

---

### SET_PARTICLE_FX_LOOPED_ALPHA

- **命名空间:** `GRAPHICS`
- **Hash:** `0x726845132380142E`
- **JHash:** `0x5ED49BE1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_LOOPED_ALPHA(int ptfxHandle, float alpha)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ptfxHandle` | `int` | `int` | - |
| `alpha` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PARTICLE_FX_LOOPED_COLOUR

- **命名空间:** `GRAPHICS`
- **Hash:** `0x7F8F65877F88783B`
- **JHash:** `0x5219D530`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_LOOPED_COLOUR(int ptfxHandle, float r, float g, float b, bool p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ptfxHandle` | `int` | `int` | - |
| `r` | `float` | `float` | - |
| `g` | `float` | `float` | - |
| `b` | `float` | `float` | - |
| `p4` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
only works on some fx's

p4 = 0
```

---

### SET_PARTICLE_FX_LOOPED_EVOLUTION

- **命名空间:** `GRAPHICS`
- **Hash:** `0x5F0C4B5B1C393BE2`
- **JHash:** `0x1CBC1373`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_LOOPED_EVOLUTION(int ptfxHandle, string propertyName, float amount, bool noNetwork)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ptfxHandle` | `int` | `int` | - |
| `propertyName` | `const char*` | `string` | - |
| `amount` | `float` | `float` | - |
| `noNetwork` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PARTICLE_FX_LOOPED_FAR_CLIP_DIST

- **命名空间:** `GRAPHICS`
- **Hash:** `0xDCB194B85EF7B541`
- **JHash:** `0x233DE879`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_LOOPED_FAR_CLIP_DIST(int ptfxHandle, float range)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ptfxHandle` | `int` | `int` | - |
| `range` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PARTICLE_FX_LOOPED_OFFSETS

- **命名空间:** `GRAPHICS`
- **Hash:** `0xF7DDEBEC43483C43`
- **JHash:** `0x641F7790`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_LOOPED_OFFSETS(int ptfxHandle, float x, float y, float z, float rotX, float rotY, float rotZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ptfxHandle` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `rotX` | `float` | `float` | - |
| `rotY` | `float` | `float` | - |
| `rotZ` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PARTICLE_FX_LOOPED_SCALE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xB44250AAA456492D`
- **JHash:** `0x099B8B49`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_LOOPED_SCALE(int ptfxHandle, float scale)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ptfxHandle` | `int` | `int` | - |
| `scale` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PARTICLE_FX_NON_LOOPED_ALPHA

- **命名空间:** `GRAPHICS`
- **Hash:** `0x77168D722C58B2FC`
- **JHash:** `0x497EAFF2`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_NON_LOOPED_ALPHA(float alpha)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `alpha` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Usage example for C#:

Function.Call(Hash.SET_PARTICLE_FX_NON_LOOPED_ALPHA, new InputArgument[] { 0.1f });

Note: the argument alpha ranges from 0.0f-1.0f !
```

---

### SET_PARTICLE_FX_NON_LOOPED_COLOUR

- **命名空间:** `GRAPHICS`
- **Hash:** `0x26143A59EF48B262`
- **JHash:** `0x7B689E20`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_NON_LOOPED_COLOUR(float r, float g, float b)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `r` | `float` | `float` | - |
| `g` | `float` | `float` | - |
| `b` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
only works on some fx's, not networked
```

---

### SET_PARTICLE_FX_NON_LOOPED_EMITTER_SIZE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x1E2E01C00837D26E`
- **Build:** `2699`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_NON_LOOPED_EMITTER_SIZE(float p0, float p1, float scale)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `float` | `float` | - |
| `scale` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PARTICLE_FX_NON_LOOPED_SCALE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xB7EF5850C39FABCA`
- **Build:** `2802`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_NON_LOOPED_SCALE(float scale)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scale` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PARTICLE_FX_OVERRIDE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xEA1E2D93F6F75ED9`
- **JHash:** `0xC92719A7`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_OVERRIDE(string oldAsset, string newAsset)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `oldAsset` | `const char*` | `string` | - |
| `newAsset` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
```

---

### SET_PARTICLE_FX_SHOOTOUT_BOAT

- **命名空间:** `GRAPHICS`
- **Hash:** `0x96EF97DAEB89BEF5`
- **JHash:** `0xD938DEE0`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_SHOOTOUT_BOAT(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PARTICLE_FX_SLIPSTREAM_LODRANGE_SCALE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2B40A97646381508`
- **Build:** `1011`

**C# 签名:**
```csharp
void SET_PARTICLE_FX_SLIPSTREAM_LODRANGE_SCALE(float scale)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scale` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PLAYER_TCMODIFIER_TRANSITION

- **命名空间:** `GRAPHICS`
- **Hash:** `0xBDEB86F4D5809204`
- **JHash:** `0x9559BB38`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PLAYER_TCMODIFIER_TRANSITION(float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PTFX_FORCE_VEHICLE_INTERIOR_FLAG

- **命名空间:** `GRAPHICS`
- **Hash:** `0xC6730E0D14E50703`
- **Build:** `2545`

**C# 签名:**
```csharp
void SET_PTFX_FORCE_VEHICLE_INTERIOR_FLAG(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SCALEFORM_MOVIE_AS_NO_LONGER_NEEDED

- **命名空间:** `GRAPHICS`
- **Hash:** `0x1D132D614DD86811`
- **JHash:** `0x5FED3BA1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SCALEFORM_MOVIE_AS_NO_LONGER_NEEDED(ref int scaleformHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleformHandle` | `int*` | `ref int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SCALEFORM_MOVIE_TO_USE_LARGE_RT

- **命名空间:** `GRAPHICS`
- **Hash:** `0x32F34FF7F617643B`
- **Build:** `573`

**C# 签名:**
```csharp
void SET_SCALEFORM_MOVIE_TO_USE_LARGE_RT(int scaleformHandle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleformHandle` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SCALEFORM_MOVIE_TO_USE_SUPER_LARGE_RT

- **命名空间:** `GRAPHICS`
- **Hash:** `0xE6A9F00D4240B519`
- **Build:** `877`

**C# 签名:**
```csharp
void SET_SCALEFORM_MOVIE_TO_USE_SUPER_LARGE_RT(int scaleformHandle, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleformHandle` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native is used in some casino scripts to fit the scaleform in the rendertarget.
```

---

### SET_SCALEFORM_MOVIE_TO_USE_SYSTEM_TIME

- **命名空间:** `GRAPHICS`
- **Hash:** `0x6D8EB211944DCE08`
- **JHash:** `0x18C9DE8D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SCALEFORM_MOVIE_TO_USE_SYSTEM_TIME(int scaleform, bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleform` | `int` | `int` | - |
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_SCRIPT_CAN_START_CUTSCENE

- **命名空间:** `CUTSCENE`
- **Hash:** `0x8D9DF6ECA8768583`
- **JHash:** `0x25A2CABC`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SCRIPT_CAN_START_CUTSCENE(int threadId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `threadId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the cutscene's owning thread ID.
```

---

### SET_SCRIPT_GFX_ALIGN

- **命名空间:** `GRAPHICS`
- **Hash:** `0xB8A850F20A067EB6`
- **JHash:** `0x228A2598`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SCRIPT_GFX_ALIGN(int horizontalAlign, int verticalAlign)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `horizontalAlign` | `int` | `int` | - |
| `verticalAlign` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
horizontalAlign: The horizontal alignment. This can be 67 ('C'), 76 ('L'), or 82 ('R').
verticalAlign: The vertical alignment. This can be 67 ('C'), 66 ('B'), or 84 ('T').

This function anchors script draws to a side of the safe zone. This needs to be called to make the interface independent of the player's safe zone configuration.

These values are equivalent to alignX and alignY in common:/data/ui/frontend.xml, which can be used as a baseline for default alignment.

Using any other value (including 0) will result in the safe zone not being taken into account for this draw. The canonical value for this is 'I' (73).

For example, you can use SET_SCRIPT_GFX_ALIGN(0, 84) to only scale on the Y axis (to the top), but not change the X axis.

To reset the value, use RESET_SCRIPT_GFX_ALIGN.
```

---

### SET_SCRIPT_GFX_ALIGN_PARAMS

- **命名空间:** `GRAPHICS`
- **Hash:** `0xF5A2C681787E579D`
- **JHash:** `0x76C641E4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SCRIPT_GFX_ALIGN_PARAMS(float x, float y, float w, float h)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `w` | `float` | `float` | - |
| `h` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the draw offset/calculated size for SET_SCRIPT_GFX_ALIGN. If using any alignment other than left/top, the game expects the width/height to be configured using this native in order to get a proper starting position for the draw command.
```

---

### SET_SCRIPT_GFX_DRAW_BEHIND_PAUSEMENU

- **命名空间:** `GRAPHICS`
- **Hash:** `0xC6372ECD45D73BCD`
- **JHash:** `0xF8FBCC25`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SCRIPT_GFX_DRAW_BEHIND_PAUSEMENU(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets a flag defining whether or not script draw commands should continue being drawn behind the pause menu. This is usually used for TV channels and other draw commands that are used with a world render target.
```

---

### SET_SCRIPT_GFX_DRAW_ORDER

- **命名空间:** `GRAPHICS`
- **Hash:** `0x61BB1D9B3A95D802`
- **JHash:** `0xADF81D24`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SCRIPT_GFX_DRAW_ORDER(int drawOrder)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `drawOrder` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets the draw order for script draw commands.

Examples from decompiled scripts:
GRAPHICS::SET_SCRIPT_GFX_DRAW_ORDER(7);
GRAPHICS::DRAW_RECT(0.5, 0.5, 3.0, 3.0, v_4, v_5, v_6, a_0._f172, 0);

GRAPHICS::SET_SCRIPT_GFX_DRAW_ORDER(1);
GRAPHICS::DRAW_RECT(0.5, 0.5, 1.5, 1.5, 0, 0, 0, 255, 0);
```

---

### SET_SEETHROUGH

- **命名空间:** `GRAPHICS`
- **Hash:** `0x7E08924259E08CE0`
- **JHash:** `0x74D4995C`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SEETHROUGH(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Toggles Heatvision on/off.
```

---

### SET_SKIDMARK_RANGE_SCALE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x5DBF05DB5926D089`
- **Build:** `1011`

**C# 签名:**
```csharp
void SET_SKIDMARK_RANGE_SCALE(float scale)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scale` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_STREAMED_TEXTURE_DICT_AS_NO_LONGER_NEEDED

- **命名空间:** `GRAPHICS`
- **Hash:** `0xBE2CACCF5A8AA805`
- **JHash:** `0xF07DDA38`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_STREAMED_TEXTURE_DICT_AS_NO_LONGER_NEEDED(string textureDict)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `textureDict` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TAKEN_PHOTO_IS_MUGSHOT

- **命名空间:** `GRAPHICS`
- **Hash:** `0x1BBC135A4D25EDDE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TAKEN_PHOTO_IS_MUGSHOT(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TIMECYCLE_MODIFIER

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2C933ABF17A1DF41`
- **JHash:** `0xA81F3638`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TIMECYCLE_MODIFIER(string modifierName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modifierName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Loads the specified timecycle modifier. Modifiers are defined separately in another file (e.g. "timecycle_mods_1.xml")

Parameters:
modifierName - The modifier to load (e.g. "V_FIB_IT3", "scanline_cam", etc.)

Full list of timecycle modifiers by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/timecycleModifiers.json
```

---

### SET_TIMECYCLE_MODIFIER_STRENGTH

- **命名空间:** `GRAPHICS`
- **Hash:** `0x82E7FFCD5B2326B3`
- **JHash:** `0x458F4F45`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TIMECYCLE_MODIFIER_STRENGTH(float strength)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `strength` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TRACKED_POINT_INFO

- **命名空间:** `GRAPHICS`
- **Hash:** `0x164ECBB3CF750CB0`
- **JHash:** `0x28689AA4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TRACKED_POINT_INFO(int point, float x, float y, float z, float radius)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `point` | `int` | `int` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `radius` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TRANSITION_OUT_OF_TIMECYCLE_MODIFIER

- **命名空间:** `GRAPHICS`
- **Hash:** `0x1CBA05AE7BD7EE05`
- **JHash:** `0x56345F6B`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TRANSITION_OUT_OF_TIMECYCLE_MODIFIER(float strength)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `strength` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TRANSITION_TIMECYCLE_MODIFIER

- **命名空间:** `GRAPHICS`
- **Hash:** `0x3BCF567485E1971C`
- **JHash:** `0xBB2BA72A`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TRANSITION_TIMECYCLE_MODIFIER(string modifierName, float transition)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modifierName` | `const char*` | `string` | - |
| `transition` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of timecycle modifiers by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/timecycleModifiers.json
```

---

### SET_TV_AUDIO_FRONTEND

- **命名空间:** `GRAPHICS`
- **Hash:** `0x113D2C5DC57E1774`
- **JHash:** `0x2E0DFA35`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TV_AUDIO_FRONTEND(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Probably changes tvs from being a 3d audio to being "global" audio
```

---

### SET_TV_CHANNEL

- **命名空间:** `GRAPHICS`
- **Hash:** `0xBAABBB23EB6E484E`
- **JHash:** `0x41A8A627`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TV_CHANNEL(int channel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `channel` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TV_CHANNEL_PLAYLIST

- **命名空间:** `GRAPHICS`
- **Hash:** `0xF7B38B8305F1FE8B`
- **JHash:** `0xB262DE67`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TV_CHANNEL_PLAYLIST(int tvChannel, string playlistName, bool restart)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `tvChannel` | `int` | `int` | - |
| `playlistName` | `const char*` | `string` | - |
| `restart` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Loads specified video sequence into the TV Channel
TV_Channel ranges from 0-2
VideoSequence can be any of the following:
"PL_STD_CNT" CNT Standard Channel
"PL_STD_WZL" Weazel Standard Channel
"PL_LO_CNT"
"PL_LO_WZL"
"PL_SP_WORKOUT"
"PL_SP_INV" - Jay Norris Assassination Mission Fail
"PL_SP_INV_EXP" - Jay Norris Assassination Mission Success
"PL_LO_RS" - Righteous Slaughter Ad
"PL_LO_RS_CUTSCENE" - Righteous Slaughter Cut-scene
"PL_SP_PLSH1_INTRO"
"PL_LES1_FAME_OR_SHAME"
"PL_STD_WZL_FOS_EP2"
"PL_MP_WEAZEL" - Weazel Logo on loop
"PL_MP_CCTV" - Generic CCTV loop

Restart:
0=video sequence continues as normal
1=sequence restarts from beginning every time that channel is selected


The above playlists work as intended, and are commonly used, but there are many more playlists, as seen in `tvplaylists.xml`. A pastebin below outlines all playlists, they will be surronded by the name tag I.E. (<Name>PL_STD_CNT</Name> = PL_STD_CNT).
https://pastebin.com/zUzGB6h7
```

---

### SET_TV_CHANNEL_PLAYLIST_AT_HOUR

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2201C576FACAEBE8`
- **JHash:** `0x78C4DCBE`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TV_CHANNEL_PLAYLIST_AT_HOUR(int tvChannel, string playlistName, int hour)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `tvChannel` | `int` | `int` | - |
| `playlistName` | `const char*` | `string` | - |
| `hour` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TV_PLAYER_WATCHING_THIS_FRAME

- **命名空间:** `GRAPHICS`
- **Hash:** `0xD1C55B110E4DF534`
- **JHash:** `0xD99EC000`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TV_PLAYER_WATCHING_THIS_FRAME(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_TV_VOLUME

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2982BF73F66E9DDC`
- **JHash:** `0xF3504F4D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_TV_VOLUME(float volume)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `volume` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_VEHICLE_MODEL_PLAYER_WILL_EXIT_SCENE

- **命名空间:** `CUTSCENE`
- **Hash:** `0x7F96F23FA9B73327`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_VEHICLE_MODEL_PLAYER_WILL_EXIT_SCENE(uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
```

---

### SET_WEATHER_PTFX_OVERRIDE_CURR_LEVEL

- **命名空间:** `GRAPHICS`
- **Hash:** `0xF78B803082D4386F`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_WEATHER_PTFX_OVERRIDE_CURR_LEVEL(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### SET_WEATHER_PTFX_USE_OVERRIDE_SETTINGS

- **命名空间:** `GRAPHICS`
- **Hash:** `0xA46B73FAA3460AE1`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_WEATHER_PTFX_USE_OVERRIDE_SETTINGS(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### START_CUTSCENE

- **命名空间:** `CUTSCENE`
- **Hash:** `0x186D5CB5E7B0FF7B`
- **JHash:** `0x210106F6`
- **Build:** `323`

**C# 签名:**
```csharp
void START_CUTSCENE(int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `flags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
flags: Usually 0.
```

---

### START_CUTSCENE_AT_COORDS

- **命名空间:** `CUTSCENE`
- **Hash:** `0x1C9ADDA3244A1FBF`
- **JHash:** `0x58BEA436`
- **Build:** `323`

**C# 签名:**
```csharp
void START_CUTSCENE_AT_COORDS(float x, float y, float z, int flags)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `flags` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
flags: Usually 0.
```

---

### START_NETWORKED_PARTICLE_FX_LOOPED_ON_ENTITY

- **命名空间:** `GRAPHICS`
- **Hash:** `0x6F60E89A7B64EE1D`
- **JHash:** `0x110752B2`
- **Build:** `323`

**C# 签名:**
```csharp
int START_NETWORKED_PARTICLE_FX_LOOPED_ON_ENTITY(string effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis, float r, float g, float b, float a)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `effectName` | `const char*` | `string` | - |
| `entity` | `Entity` | `int` | - |
| `xOffset` | `float` | `float` | - |
| `yOffset` | `float` | `float` | - |
| `zOffset` | `float` | `float` | - |
| `xRot` | `float` | `float` | - |
| `yRot` | `float` | `float` | - |
| `zRot` | `float` | `float` | - |
| `scale` | `float` | `float` | - |
| `xAxis` | `BOOL` | `bool` | - |
| `yAxis` | `BOOL` | `bool` | - |
| `zAxis` | `BOOL` | `bool` | - |
| `r` | `float` | `float` | - |
| `g` | `float` | `float` | - |
| `b` | `float` | `float` | - |
| `a` | `float` | `float` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
```

---

### START_NETWORKED_PARTICLE_FX_LOOPED_ON_ENTITY_BONE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xDDE23F30CC5A0F03`
- **JHash:** `0xF478EFCF`
- **Build:** `323`

**C# 签名:**
```csharp
int START_NETWORKED_PARTICLE_FX_LOOPED_ON_ENTITY_BONE(string effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, bool xAxis, bool yAxis, bool zAxis, float r, float g, float b, float a)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `effectName` | `const char*` | `string` | - |
| `entity` | `Entity` | `int` | - |
| `xOffset` | `float` | `float` | - |
| `yOffset` | `float` | `float` | - |
| `zOffset` | `float` | `float` | - |
| `xRot` | `float` | `float` | - |
| `yRot` | `float` | `float` | - |
| `zRot` | `float` | `float` | - |
| `boneIndex` | `int` | `int` | - |
| `scale` | `float` | `float` | - |
| `xAxis` | `BOOL` | `bool` | - |
| `yAxis` | `BOOL` | `bool` | - |
| `zAxis` | `BOOL` | `bool` | - |
| `r` | `float` | `float` | - |
| `g` | `float` | `float` | - |
| `b` | `float` | `float` | - |
| `a` | `float` | `float` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
```

---

### START_NETWORKED_PARTICLE_FX_NON_LOOPED_AT_COORD

- **命名空间:** `GRAPHICS`
- **Hash:** `0xF56B8137DF10135D`
- **JHash:** `0x633F8C48`
- **Build:** `323`

**C# 签名:**
```csharp
bool START_NETWORKED_PARTICLE_FX_NON_LOOPED_AT_COORD(string effectName, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis, bool p11)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `effectName` | `const char*` | `string` | - |
| `xPos` | `float` | `float` | - |
| `yPos` | `float` | `float` | - |
| `zPos` | `float` | `float` | - |
| `xRot` | `float` | `float` | - |
| `yRot` | `float` | `float` | - |
| `zRot` | `float` | `float` | - |
| `scale` | `float` | `float` | - |
| `xAxis` | `BOOL` | `bool` | - |
| `yAxis` | `BOOL` | `bool` | - |
| `zAxis` | `BOOL` | `bool` | - |
| `p11` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
```

---

### START_NETWORKED_PARTICLE_FX_NON_LOOPED_ON_ENTITY

- **命名空间:** `GRAPHICS`
- **Hash:** `0xC95EB1DB6E92113D`
- **JHash:** `0x469A2B4A`
- **Build:** `323`

**C# 签名:**
```csharp
bool START_NETWORKED_PARTICLE_FX_NON_LOOPED_ON_ENTITY(string effectName, int entity, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, float scale, bool axisX, bool axisY, bool axisZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `effectName` | `const char*` | `string` | - |
| `entity` | `Entity` | `int` | - |
| `offsetX` | `float` | `float` | - |
| `offsetY` | `float` | `float` | - |
| `offsetZ` | `float` | `float` | - |
| `rotX` | `float` | `float` | - |
| `rotY` | `float` | `float` | - |
| `rotZ` | `float` | `float` | - |
| `scale` | `float` | `float` | - |
| `axisX` | `BOOL` | `bool` | - |
| `axisY` | `BOOL` | `bool` | - |
| `axisZ` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
```

---

### START_NETWORKED_PARTICLE_FX_NON_LOOPED_ON_PED_BONE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xA41B6A43642AC2CF`
- **JHash:** `0x161780C1`
- **Build:** `323`

**C# 签名:**
```csharp
bool START_NETWORKED_PARTICLE_FX_NON_LOOPED_ON_PED_BONE(string effectName, int ped, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, int boneIndex, float scale, bool axisX, bool axisY, bool axisZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `effectName` | `const char*` | `string` | - |
| `ped` | `Ped` | `int` | - |
| `offsetX` | `float` | `float` | - |
| `offsetY` | `float` | `float` | - |
| `offsetZ` | `float` | `float` | - |
| `rotX` | `float` | `float` | - |
| `rotY` | `float` | `float` | - |
| `rotZ` | `float` | `float` | - |
| `boneIndex` | `int` | `int` | - |
| `scale` | `float` | `float` | - |
| `axisX` | `BOOL` | `bool` | - |
| `axisY` | `BOOL` | `bool` | - |
| `axisZ` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
```

---

### START_PARTICLE_FX_LOOPED_AT_COORD

- **命名空间:** `GRAPHICS`
- **Hash:** `0xE184F4F0DC5910E7`
- **JHash:** `0xD348E3E6`
- **Build:** `323`

**C# 签名:**
```csharp
int START_PARTICLE_FX_LOOPED_AT_COORD(string effectName, float x, float y, float z, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis, bool p11)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `effectName` | `const char*` | `string` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `xRot` | `float` | `float` | - |
| `yRot` | `float` | `float` | - |
| `zRot` | `float` | `float` | - |
| `scale` | `float` | `float` | - |
| `xAxis` | `BOOL` | `bool` | - |
| `yAxis` | `BOOL` | `bool` | - |
| `zAxis` | `BOOL` | `bool` | - |
| `p11` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
GRAPHICS::START_PARTICLE_FX_LOOPED_AT_COORD("scr_fbi_falling_debris", 93.7743f, -749.4572f, 70.86904f, 0f, 0f, 0f, 0x3F800000, 0, 0, 0, 0)


p11 seems to be always 0

Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
```

---

### START_PARTICLE_FX_LOOPED_ON_ENTITY

- **命名空间:** `GRAPHICS`
- **Hash:** `0x1AE42C1660FD6517`
- **JHash:** `0x0D06FF62`
- **Build:** `323`

**C# 签名:**
```csharp
int START_PARTICLE_FX_LOOPED_ON_ENTITY(string effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `effectName` | `const char*` | `string` | - |
| `entity` | `Entity` | `int` | - |
| `xOffset` | `float` | `float` | - |
| `yOffset` | `float` | `float` | - |
| `zOffset` | `float` | `float` | - |
| `xRot` | `float` | `float` | - |
| `yRot` | `float` | `float` | - |
| `zRot` | `float` | `float` | - |
| `scale` | `float` | `float` | - |
| `xAxis` | `BOOL` | `bool` | - |
| `yAxis` | `BOOL` | `bool` | - |
| `zAxis` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
```

---

### START_PARTICLE_FX_LOOPED_ON_ENTITY_BONE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xC6EB449E33977F0B`
- **JHash:** `0x23BF0F9B`
- **Build:** `323`

**C# 签名:**
```csharp
int START_PARTICLE_FX_LOOPED_ON_ENTITY_BONE(string effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, bool xAxis, bool yAxis, bool zAxis)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `effectName` | `const char*` | `string` | - |
| `entity` | `Entity` | `int` | - |
| `xOffset` | `float` | `float` | - |
| `yOffset` | `float` | `float` | - |
| `zOffset` | `float` | `float` | - |
| `xRot` | `float` | `float` | - |
| `yRot` | `float` | `float` | - |
| `zRot` | `float` | `float` | - |
| `boneIndex` | `int` | `int` | - |
| `scale` | `float` | `float` | - |
| `xAxis` | `BOOL` | `bool` | - |
| `yAxis` | `BOOL` | `bool` | - |
| `zAxis` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
```

---

### START_PARTICLE_FX_LOOPED_ON_PED_BONE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xF28DA9F38CD1787C`
- **JHash:** `0xF8FC196F`
- **Build:** `323`

**C# 签名:**
```csharp
int START_PARTICLE_FX_LOOPED_ON_PED_BONE(string effectName, int ped, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, bool xAxis, bool yAxis, bool zAxis)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `effectName` | `const char*` | `string` | - |
| `ped` | `Ped` | `int` | - |
| `xOffset` | `float` | `float` | - |
| `yOffset` | `float` | `float` | - |
| `zOffset` | `float` | `float` | - |
| `xRot` | `float` | `float` | - |
| `yRot` | `float` | `float` | - |
| `zRot` | `float` | `float` | - |
| `boneIndex` | `int` | `int` | - |
| `scale` | `float` | `float` | - |
| `xAxis` | `BOOL` | `bool` | - |
| `yAxis` | `BOOL` | `bool` | - |
| `zAxis` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
```

---

### START_PARTICLE_FX_NON_LOOPED_AT_COORD

- **命名空间:** `GRAPHICS`
- **Hash:** `0x25129531F77B9ED3`
- **JHash:** `0xDD79D679`
- **Build:** `323`

**C# 签名:**
```csharp
bool START_PARTICLE_FX_NON_LOOPED_AT_COORD(string effectName, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `effectName` | `const char*` | `string` | - |
| `xPos` | `float` | `float` | - |
| `yPos` | `float` | `float` | - |
| `zPos` | `float` | `float` | - |
| `xRot` | `float` | `float` | - |
| `yRot` | `float` | `float` | - |
| `zRot` | `float` | `float` | - |
| `scale` | `float` | `float` | - |
| `xAxis` | `BOOL` | `bool` | - |
| `yAxis` | `BOOL` | `bool` | - |
| `zAxis` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
GRAPHICS::START_PARTICLE_FX_NON_LOOPED_AT_COORD("scr_paleto_roof_impact", -140.8576f, 6420.789f, 41.1391f, 0f, 0f, 267.3957f, 0x3F800000, 0, 0, 0);

Axis - Invert Axis Flags

Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json


-------------------------------------------------------------------
C#

Function.Call<int>(Hash.START_PARTICLE_FX_NON_LOOPED_AT_COORD, = you are calling this function.

char *effectname = This is an in-game effect name, for e.g. "scr_fbi4_trucks_crash" is used to give the effects when truck crashes etc

float x, y, z pos = this one is Simple, you just have to declare, where do you want this effect to take place at, so declare the ordinates

float xrot, yrot, zrot = Again simple? just mention the value in case if you want the effect to rotate.

float scale = is declare the scale of the effect, this may vary as per the effects for e.g 1.0f

bool xaxis, yaxis, zaxis = To bool the axis values.

example:
Function.Call<int>(Hash.START_PARTICLE_FX_NON_LOOPED_AT_COORD, "scr_fbi4_trucks_crash", GTA.Game.Player.Character.Position.X, GTA.Game.Player.Character.Position.Y, GTA.Game.Player.Character.Position.Z + 4f, 0, 0, 0, 5.5f, 0, 0, 0);
```

---

### START_PARTICLE_FX_NON_LOOPED_ON_ENTITY

- **命名空间:** `GRAPHICS`
- **Hash:** `0x0D53A3B8DA0809D2`
- **JHash:** `0x9604DAD4`
- **Build:** `323`

**C# 签名:**
```csharp
bool START_PARTICLE_FX_NON_LOOPED_ON_ENTITY(string effectName, int entity, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, float scale, bool axisX, bool axisY, bool axisZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `effectName` | `const char*` | `string` | - |
| `entity` | `Entity` | `int` | - |
| `offsetX` | `float` | `float` | - |
| `offsetY` | `float` | `float` | - |
| `offsetZ` | `float` | `float` | - |
| `rotX` | `float` | `float` | - |
| `rotY` | `float` | `float` | - |
| `rotZ` | `float` | `float` | - |
| `scale` | `float` | `float` | - |
| `axisX` | `BOOL` | `bool` | - |
| `axisY` | `BOOL` | `bool` | - |
| `axisZ` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Starts a particle effect on an entity for example your player.

Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json

Example:
C#:
Function.Call(Hash.REQUEST_NAMED_PTFX_ASSET, "scr_rcbarry2");                     Function.Call(Hash.USE_PARTICLE_FX_ASSET, "scr_rcbarry2");                             Function.Call(Hash.START_PARTICLE_FX_NON_LOOPED_ON_ENTITY, "scr_clown_appears", Game.Player.Character, 0.0, 0.0, -0.5, 0.0, 0.0, 0.0, 1.0, false, false, false);

Internally this calls the same function as GRAPHICS::START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE
however it uses -1 for the specified bone index, so it should be possible to start a non looped fx on an entity bone using that native

-can confirm START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE does NOT work on vehicle bones.
```

---

### START_PARTICLE_FX_NON_LOOPED_ON_ENTITY_BONE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x02B1F2A72E0F5325`
- **Build:** `2189`

**C# 签名:**
```csharp
bool START_PARTICLE_FX_NON_LOOPED_ON_ENTITY_BONE(string effectName, int entity, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, int boneIndex, float scale, bool axisX, bool axisY, bool axisZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `effectName` | `const char*` | `string` | - |
| `entity` | `Entity` | `int` | - |
| `offsetX` | `float` | `float` | - |
| `offsetY` | `float` | `float` | - |
| `offsetZ` | `float` | `float` | - |
| `rotX` | `float` | `float` | - |
| `rotY` | `float` | `float` | - |
| `rotZ` | `float` | `float` | - |
| `boneIndex` | `int` | `int` | - |
| `scale` | `float` | `float` | - |
| `axisX` | `BOOL` | `bool` | - |
| `axisY` | `BOOL` | `bool` | - |
| `axisZ` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
```

---

### START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x0E7E72961BA18619`
- **JHash:** `0x53DAEF4E`
- **Build:** `323`

**C# 签名:**
```csharp
bool START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE(string effectName, int ped, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, int boneIndex, float scale, bool axisX, bool axisY, bool axisZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `effectName` | `const char*` | `string` | - |
| `ped` | `Ped` | `int` | - |
| `offsetX` | `float` | `float` | - |
| `offsetY` | `float` | `float` | - |
| `offsetZ` | `float` | `float` | - |
| `rotX` | `float` | `float` | - |
| `rotY` | `float` | `float` | - |
| `rotZ` | `float` | `float` | - |
| `boneIndex` | `int` | `int` | - |
| `scale` | `float` | `float` | - |
| `axisX` | `BOOL` | `bool` | - |
| `axisY` | `BOOL` | `bool` | - |
| `axisZ` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
GRAPHICS::START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE("scr_sh_bong_smoke", PLAYER::PLAYER_PED_ID(), -0.025f, 0.13f, 0f, 0f, 0f, 0f, 31086, 0x3F800000, 0, 0, 0);

Axis - Invert Axis Flags

Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
```

---

### START_PETROL_TRAIL_DECALS

- **命名空间:** `GRAPHICS`
- **Hash:** `0x99AC7F0D8B9C893D`
- **JHash:** `0xE3938B0B`
- **Build:** `323`

**C# 签名:**
```csharp
void START_PETROL_TRAIL_DECALS(float p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### STOP_BINK_MOVIE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x63606A61DE68898A`
- **Build:** `1290`

**C# 签名:**
```csharp
void STOP_BINK_MOVIE(int binkMovie)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `binkMovie` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### STOP_CUTSCENE

- **命名空间:** `CUTSCENE`
- **Hash:** `0xC7272775B4DC786E`
- **JHash:** `0x5EE84DC7`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_CUTSCENE(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### STOP_CUTSCENE_IMMEDIATELY

- **命名空间:** `CUTSCENE`
- **Hash:** `0xD220BDD222AC4A1E`
- **JHash:** `0xF528A2AD`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_CUTSCENE_IMMEDIATELY()
```

**返回值:** `void` (Native: `void`)

---

### STOP_PARTICLE_FX_LOOPED

- **命名空间:** `GRAPHICS`
- **Hash:** `0x8F75998877616996`
- **JHash:** `0xD245455B`
- **Build:** `323`

**C# 签名:**
```csharp
void STOP_PARTICLE_FX_LOOPED(int ptfxHandle, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ptfxHandle` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 is always 0 in the native scripts
```

---

### TERRAINGRID_ACTIVATE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xA356990E161C9E65`
- **JHash:** `0xA1CB6C94`
- **Build:** `323`

**C# 签名:**
```csharp
void TERRAINGRID_ACTIVATE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native enables/disables the gold putting grid display (https://i.imgur.com/TC6cku6.png).
This requires these two natives to be called as well to configure the grid: `TERRAINGRID_SET_PARAMS` and `TERRAINGRID_SET_COLOURS`.
```

---

### TERRAINGRID_SET_COLOURS

- **命名空间:** `GRAPHICS`
- **Hash:** `0x5CE62918F8D703C7`
- **JHash:** `0xDF552973`
- **Build:** `323`

**C# 签名:**
```csharp
void TERRAINGRID_SET_COLOURS(int lowR, int lowG, int lowB, int lowAlpha, int r, int g, int b, int alpha, int highR, int highG, int highB, int highAlpha)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `lowR` | `int` | `int` | - |
| `lowG` | `int` | `int` | - |
| `lowB` | `int` | `int` | - |
| `lowAlpha` | `int` | `int` | - |
| `r` | `int` | `int` | - |
| `g` | `int` | `int` | - |
| `b` | `int` | `int` | - |
| `alpha` | `int` | `int` | - |
| `highR` | `int` | `int` | - |
| `highG` | `int` | `int` | - |
| `highB` | `int` | `int` | - |
| `highAlpha` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native is used along with these two natives: `TERRAINGRID_ACTIVATE` and `TERRAINGRID_SET_PARAMS`.
This native sets the colors for the golf putting grid. the 'min...' values are for the lower areas that the grid covers, the 'max...' values are for the higher areas that the grid covers, all remaining values are for the 'normal' ground height.
All those natives combined they will output something like this: https://i.imgur.com/TC6cku6.png
```

---

### TERRAINGRID_SET_PARAMS

- **命名空间:** `GRAPHICS`
- **Hash:** `0x1C4FC5752BCD8E48`
- **JHash:** `0x3B637AA7`
- **Build:** `323`

**C# 签名:**
```csharp
void TERRAINGRID_SET_PARAMS(float x, float y, float z, float forwardX, float forwardY, float forwardZ, float sizeX, float sizeY, float sizeZ, float gridScale, float glowIntensity, float normalHeight, float heightDiff)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `forwardX` | `float` | `float` | - |
| `forwardY` | `float` | `float` | - |
| `forwardZ` | `float` | `float` | - |
| `sizeX` | `float` | `float` | - |
| `sizeY` | `float` | `float` | - |
| `sizeZ` | `float` | `float` | - |
| `gridScale` | `float` | `float` | - |
| `glowIntensity` | `float` | `float` | - |
| `normalHeight` | `float` | `float` | - |
| `heightDiff` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native is used along with these two natives: `TERRAINGRID_ACTIVATE` and `TERRAINGRID_SET_COLOURS`.
This native configures the location, size, rotation, normal height, and the difference ratio between min, normal and max.

All those natives combined they will output something like this: https://i.imgur.com/TC6cku6.png

This native renders a box at the given position, with a special shader that renders a grid on world geometry behind it. This box does not have backface culling.
The forward args here are a direction vector, something similar to what's returned by GET_ENTITY_FORWARD_VECTOR.
normalHeight and heightDiff are used for positioning the color gradient of the grid, colors specified via TERRAINGRID_SET_COLOURS.

Example with box superimposed on the image to demonstrate: https://i.imgur.com/wdqskxd.jpg
```

---

### TOGGLE_PAUSED_RENDERPHASES

- **命名空间:** `GRAPHICS`
- **Hash:** `0xDFC252D8A3E15AB7`
- **JHash:** `0x30ADE541`
- **Build:** `323`

**C# 签名:**
```csharp
void TOGGLE_PAUSED_RENDERPHASES(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### TOGGLE_PLAYER_DAMAGE_OVERLAY

- **命名空间:** `GRAPHICS`
- **Hash:** `0xE63D7C6EECECB66B`
- **JHash:** `0xD34A6CBA`
- **Build:** `323`

**C# 签名:**
```csharp
void TOGGLE_PLAYER_DAMAGE_OVERLAY(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### TRIGGER_SCREENBLUR_FADE_IN

- **命名空间:** `GRAPHICS`
- **Hash:** `0xA328A24AAA6B7FDC`
- **JHash:** `0x5604B890`
- **Build:** `323`

**C# 签名:**
```csharp
bool TRIGGER_SCREENBLUR_FADE_IN(float transitionTime)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `transitionTime` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
time in ms to transition to fully blurred screen
```

---

### TRIGGER_SCREENBLUR_FADE_OUT

- **命名空间:** `GRAPHICS`
- **Hash:** `0xEFACC8AEF94430D5`
- **JHash:** `0x46617502`
- **Build:** `323`

**C# 签名:**
```csharp
bool TRIGGER_SCREENBLUR_FADE_OUT(float transitionTime)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `transitionTime` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
time in ms to transition from fully blurred to normal
```

---

### UI3DSCENE_ASSIGN_PED_TO_SLOT

- **命名空间:** `GRAPHICS`
- **Hash:** `0x98C4FE6EC34154CA`
- **JHash:** `0x9A0E3BFE`
- **Build:** `323`

**C# 签名:**
```csharp
bool UI3DSCENE_ASSIGN_PED_TO_SLOT(string presetName, int ped, int slot, float posX, float posY, float posZ)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `presetName` | `const char*` | `string` | - |
| `ped` | `Ped` | `int` | - |
| `slot` | `int` | `int` | - |
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
It's called after UI3DSCENE_IS_AVAILABLE and UI3DSCENE_PUSH_PRESET

presetName was always "CELEBRATION_WINNER"
All presets can be found in common\data\ui\uiscenes.meta
```

---

### UI3DSCENE_CLEAR_PATCHED_DATA

- **命名空间:** `GRAPHICS`
- **Hash:** `0x7A42B2E236E71415`
- **JHash:** `0x431AA036`
- **Build:** `323`

**C# 签名:**
```csharp
void UI3DSCENE_CLEAR_PATCHED_DATA()
```

**返回值:** `void` (Native: `void`)

---

### UI3DSCENE_IS_AVAILABLE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xD3A10FC7FD8D98CD`
- **JHash:** `0xE40A0F1A`
- **Build:** `323`

**C# 签名:**
```csharp
bool UI3DSCENE_IS_AVAILABLE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### UI3DSCENE_MAKE_PUSHED_PRESET_PERSISTENT

- **命名空间:** `GRAPHICS`
- **Hash:** `0x108BE26959A9D9BB`
- **JHash:** `0x24A7A7F6`
- **Build:** `323`

**C# 签名:**
```csharp
void UI3DSCENE_MAKE_PUSHED_PRESET_PERSISTENT(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### UI3DSCENE_PUSH_PRESET

- **命名空间:** `GRAPHICS`
- **Hash:** `0xF1CEA8A4198D8E9A`
- **JHash:** `0x2E7D9B98`
- **Build:** `323`

**C# 签名:**
```csharp
bool UI3DSCENE_PUSH_PRESET(string presetName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `presetName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
All presets can be found in common\data\ui\uiscenes.meta
```

---

### UNPATCH_DECAL_DIFFUSE_MAP

- **命名空间:** `GRAPHICS`
- **Hash:** `0xB7ED70C49521A61D`
- **JHash:** `0x7B786555`
- **Build:** `323`

**C# 签名:**
```csharp
void UNPATCH_DECAL_DIFFUSE_MAP(int decalType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `decalType` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### UPDATE_LIGHTS_ON_ENTITY

- **命名空间:** `GRAPHICS`
- **Hash:** `0xDEADC0DEDEADC0DE`
- **JHash:** `0xC12AC47A`
- **Build:** `323`

**C# 签名:**
```csharp
void UPDATE_LIGHTS_ON_ENTITY(int entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `entity` | `Entity` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### USE_PARTICLE_FX_ASSET

- **命名空间:** `GRAPHICS`
- **Hash:** `0x6C38AF3693A69A91`
- **JHash:** `0x9C720B61`
- **Build:** `323`

**C# 签名:**
```csharp
void USE_PARTICLE_FX_ASSET(string name)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
From the b678d decompiled scripts:

 GRAPHICS::USE_PARTICLE_FX_ASSET("FM_Mission_Controler");
 GRAPHICS::USE_PARTICLE_FX_ASSET("scr_apartment_mp");
 GRAPHICS::USE_PARTICLE_FX_ASSET("scr_indep_fireworks");
 GRAPHICS::USE_PARTICLE_FX_ASSET("scr_mp_cig_plane");
 GRAPHICS::USE_PARTICLE_FX_ASSET("scr_mp_creator");
 GRAPHICS::USE_PARTICLE_FX_ASSET("scr_ornate_heist");
 GRAPHICS::USE_PARTICLE_FX_ASSET("scr_prison_break_heist_station");

Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
```

---

### USE_SNOW_FOOT_VFX_WHEN_UNSHELTERED

- **命名空间:** `GRAPHICS`
- **Hash:** `0xAEEDAD1420C65CC0`
- **JHash:** `0xC53576CA`
- **Build:** `323`

**C# 签名:**
```csharp
void USE_SNOW_FOOT_VFX_WHEN_UNSHELTERED(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Forces footstep tracks on all surfaces.
```

---

### USE_SNOW_WHEEL_VFX_WHEN_UNSHELTERED

- **命名空间:** `GRAPHICS`
- **Hash:** `0x4CC7F0FEA5283FE0`
- **JHash:** `0x7158B1EA`
- **Build:** `323`

**C# 签名:**
```csharp
void USE_SNOW_WHEEL_VFX_WHEN_UNSHELTERED(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Forces vehicle trails on all surfaces.
```

---

### WASH_DECALS_FROM_VEHICLE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x5B712761429DBC14`
- **JHash:** `0x2929F11A`
- **Build:** `323`

**C# 签名:**
```csharp
void WASH_DECALS_FROM_VEHICLE(int vehicle, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### WASH_DECALS_IN_RANGE

- **命名空间:** `GRAPHICS`
- **Hash:** `0x9C30613D50A6ADEF`
- **JHash:** `0xDEECBC57`
- **Build:** `323`

**C# 签名:**
```csharp
void WASH_DECALS_IN_RANGE(float x, float y, float z, float range, float p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `range` | `float` | `float` | - |
| `p4` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### WAS_CUTSCENE_SKIPPED

- **命名空间:** `CUTSCENE`
- **Hash:** `0x40C8656EDAEDD569`
- **JHash:** `0xC9B6949D`
- **Build:** `323`

**C# 签名:**
```csharp
bool WAS_CUTSCENE_SKIPPED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### WATER_REFLECTION_SET_SCRIPT_OBJECT_VISIBILITY

- **命名空间:** `GRAPHICS`
- **Hash:** `0xCA465D9CC0D231BA`
- **Build:** `1011`

**C# 签名:**
```csharp
void WATER_REFLECTION_SET_SCRIPT_OBJECT_VISIBILITY(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _FORCE_ALLOW_SNOW_FOOT_VFX_ON_ICE

- **命名空间:** `GRAPHICS`
- **Hash:** `0xA342A3763B3AFB6C`
- **Build:** `3095`

**C# 签名:**
```csharp
void _FORCE_ALLOW_SNOW_FOOT_VFX_ON_ICE(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### _FORCE_GROUND_SNOW_PASS

- **命名空间:** `GRAPHICS`
- **Hash:** `0x6E9EF3A33C8899F8`
- **Build:** `3095`

**C# 签名:**
```csharp
void _FORCE_GROUND_SNOW_PASS(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### _HAS_SCALEFORM_MOVIE_NAMED_LOADED

- **命名空间:** `GRAPHICS`
- **Hash:** `0x9743BCCF7CD6E1F6`
- **Build:** `3407`

**C# 签名:**
```csharp
bool _HAS_SCALEFORM_MOVIE_NAMED_LOADED(ref int scaleformHandle, string scaleformName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleformHandle` | `int*` | `ref int` | - |
| `scaleformName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### _SET_PARTICLE_FX_LOOPED_CAMERA_BIAS

- **命名空间:** `GRAPHICS`
- **Hash:** `0x4100BF0346A8D2C3`
- **Build:** `3095`

**C# 签名:**
```csharp
void _SET_PARTICLE_FX_LOOPED_CAMERA_BIAS(int ptfxHandle, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `ptfxHandle` | `int` | `int` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### _SET_SCALEFORM_MOVIE_NAMED_AS_NO_LONGER_NEEDED

- **命名空间:** `GRAPHICS`
- **Hash:** `0x2FDFB1B04C76E9C3`
- **Build:** `3407`

**C# 签名:**
```csharp
void _SET_SCALEFORM_MOVIE_NAMED_AS_NO_LONGER_NEEDED(int scaleformHandle, string scaleformName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleformHandle` | `int` | `int` | - |
| `scaleformName` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### _SET_TV_CHANNEL_PLAYLIST_DIRTY

- **命名空间:** `GRAPHICS`
- **Hash:** `0xEE831F15A8D0D94A`
- **Build:** `3095`

**C# 签名:**
```csharp
object _SET_TV_CHANNEL_PLAYLIST_DIRTY(int tvChannel, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `tvChannel` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `object` (Native: `Any`)

**说明:**
```
Does not actually return anything.
```

---

### _START_VEHICLE_PARTICLE_FX_LOOPED

- **命名空间:** `GRAPHICS`
- **Hash:** `0xDF269BE2909E181A`
- **Build:** `3095`

**C# 签名:**
```csharp
int _START_VEHICLE_PARTICLE_FX_LOOPED(int vehicle, string effectName, bool frontBack, bool leftRight, bool localOnly)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `vehicle` | `Vehicle` | `int` | - |
| `effectName` | `const char*` | `string` | - |
| `frontBack` | `BOOL` | `bool` | - |
| `leftRight` | `BOOL` | `bool` | - |
| `localOnly` | `BOOL` | `bool` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns ptfxHandle
effectName: scr_sv_drag_burnout
```

---
