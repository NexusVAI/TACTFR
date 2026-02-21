# STATS - Native 函数参考

> 命名空间: STATS, MONEY

---

## 快速索引

| 函数名 | C# 签名 | 返回值 | 说明 |
|--------|---------|--------|------|
| `CAN_PAY_AMOUNT_TO_BOSS` | `bool CAN_PAY_AMOUNT_TO_BOSS(int p0, int p1, int amount, ref int p3)` | bool | - |
| `CHANGE_GOON_LOOKING_FOR_WORK` | `void CHANGE_GOON_LOOKING_FOR_WORK(object p0)` | void | - |
| `CHANGE_UNIFORM` | `void CHANGE_UNIFORM(object p0, object p1, object p2)` | void | - |
| `DEPOSIT_VC` | `bool DEPOSIT_VC(int amount)` | bool | Does nothing and always returns false. |
| `END_BEING_BOSS` | `void END_BEING_BOSS(object p0, object p1, object p2)` | void | - |
| `END_BEING_GOON` | `void END_BEING_GOON(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `FORCE_CLOUD_MP_STATS_DOWNLOAD_AND_OVERWRITE_LOCAL_SAVE` | `void FORCE_CLOUD_MP_STATS_DOWNLOAD_AND_OVERWRITE_LOCAL_SAVE()` | void | - |
| `GET_BOSS_GOON_UUID` | `void GET_BOSS_GOON_UUID(int characterSlot, object p1, object p2)` | void | - |
| `GET_PACKED_INT_STAT_KEY` | `uint GET_PACKED_INT_STAT_KEY(int index, bool spStat, bool charStat, int character)` | uint | - |
| `GET_PACKED_NG_INT_STAT_KEY` | `uint GET_PACKED_NG_INT_STAT_KEY(int index, bool spStat, bool charStat, int character, string section)` | uint | Needs more research. Gets the stat name of a masked int?<br><br>section - values used in the decompiled sc... |
| `GET_PACKED_STAT_BOOL_CODE` | `bool GET_PACKED_STAT_BOOL_CODE(int index, int characterSlot)` | bool | - |
| `GET_PACKED_STAT_INT_CODE` | `int GET_PACKED_STAT_INT_CODE(int index, int characterSlot)` | int | - |
| `GET_PACKED_TU_INT_STAT_KEY` | `uint GET_PACKED_TU_INT_STAT_KEY(int index, bool spStat, bool charStat, int character)` | uint | - |
| `GET_PLAYER_HAS_DRIVEN_ALL_VEHICLES` | `bool GET_PLAYER_HAS_DRIVEN_ALL_VEHICLES()` | bool | - |
| `HAS_VC_WITHDRAWAL_COMPLETED` | `bool HAS_VC_WITHDRAWAL_COMPLETED(object p0)` | bool | This function is hard-coded to always return 1. |
| `HIRED_LIMO` | `void HIRED_LIMO(object p0, object p1)` | void | - |
| `LEADERBOARDS2_READ_BY_HANDLE` | `bool LEADERBOARDS2_READ_BY_HANDLE(ref object p0, ref object p1)` | bool | - |
| `LEADERBOARDS2_READ_BY_PLAFORM` | `bool LEADERBOARDS2_READ_BY_PLAFORM(ref object p0, string gamerHandleCsv, string platformName)` | bool | - |
| `LEADERBOARDS2_READ_BY_RADIUS` | `bool LEADERBOARDS2_READ_BY_RADIUS(ref object p0, object p1, ref object p2)` | bool | - |
| `LEADERBOARDS2_READ_BY_RANK` | `bool LEADERBOARDS2_READ_BY_RANK(ref object p0, object p1, object p2)` | bool | - |
| `LEADERBOARDS2_READ_BY_SCORE_FLOAT` | `bool LEADERBOARDS2_READ_BY_SCORE_FLOAT(ref object p0, float p1, object p2)` | bool | - |
| `LEADERBOARDS2_READ_BY_SCORE_INT` | `bool LEADERBOARDS2_READ_BY_SCORE_INT(ref object p0, object p1, object p2)` | bool | - |
| `LEADERBOARDS2_READ_FRIENDS_BY_ROW` | `bool LEADERBOARDS2_READ_FRIENDS_BY_ROW(ref object p0, ref object p1, object p2, bool p3, object p4, object p5)` | bool | - |
| `LEADERBOARDS2_READ_GET_ROW_DATA_END` | `void LEADERBOARDS2_READ_GET_ROW_DATA_END()` | void | - |
| `LEADERBOARDS2_READ_GET_ROW_DATA_FLOAT` | `float LEADERBOARDS2_READ_GET_ROW_DATA_FLOAT(object p0, object p1)` | float | - |
| `LEADERBOARDS2_READ_GET_ROW_DATA_INFO` | `bool LEADERBOARDS2_READ_GET_ROW_DATA_INFO(object p0, ref object p1)` | bool | - |
| `LEADERBOARDS2_READ_GET_ROW_DATA_INT` | `int LEADERBOARDS2_READ_GET_ROW_DATA_INT(object p0, object p1)` | int | - |
| `LEADERBOARDS2_READ_GET_ROW_DATA_START` | `bool LEADERBOARDS2_READ_GET_ROW_DATA_START(ref object p0)` | bool | - |
| `LEADERBOARDS2_READ_RANK_PREDICTION` | `bool LEADERBOARDS2_READ_RANK_PREDICTION(ref object p0, ref object p1, ref object p2)` | bool | - |
| `LEADERBOARDS2_WRITE_DATA` | `bool LEADERBOARDS2_WRITE_DATA(ref object p0)` | bool | - |
| `LEADERBOARDS2_WRITE_DATA_FOR_EVENT_TYPE` | `bool LEADERBOARDS2_WRITE_DATA_FOR_EVENT_TYPE(ref object p0, ref object p1)` | bool | - |
| `LEADERBOARDS_CACHE_DATA_ROW` | `bool LEADERBOARDS_CACHE_DATA_ROW(ref object p0)` | bool | - |
| `LEADERBOARDS_CLEAR_CACHE_DATA` | `void LEADERBOARDS_CLEAR_CACHE_DATA()` | void | - |
| `LEADERBOARDS_CLEAR_CACHE_DATA_ID` | `void LEADERBOARDS_CLEAR_CACHE_DATA_ID(object p0)` | void | - |
| `LEADERBOARDS_GET_CACHE_DATA_ROW` | `bool LEADERBOARDS_GET_CACHE_DATA_ROW(object p0, object p1, ref object p2)` | bool | - |
| `LEADERBOARDS_GET_CACHE_EXISTS` | `bool LEADERBOARDS_GET_CACHE_EXISTS(object p0)` | bool | - |
| `LEADERBOARDS_GET_CACHE_NUMBER_OF_ROWS` | `int LEADERBOARDS_GET_CACHE_NUMBER_OF_ROWS(object p0)` | int | - |
| `LEADERBOARDS_GET_CACHE_TIME` | `int LEADERBOARDS_GET_CACHE_TIME(object p0)` | int | - |
| `LEADERBOARDS_GET_COLUMN_ID` | `int LEADERBOARDS_GET_COLUMN_ID(int p0, int p1, int p2)` | int | - |
| `LEADERBOARDS_GET_COLUMN_TYPE` | `int LEADERBOARDS_GET_COLUMN_TYPE(int p0, object p1, object p2)` | int | - |
| `LEADERBOARDS_GET_NUMBER_OF_COLUMNS` | `int LEADERBOARDS_GET_NUMBER_OF_COLUMNS(int p0, object p1)` | int | - |
| `LEADERBOARDS_READ_ANY_PENDING` | `bool LEADERBOARDS_READ_ANY_PENDING()` | bool | - |
| `LEADERBOARDS_READ_CLEAR` | `int LEADERBOARDS_READ_CLEAR(object p0, object p1, object p2)` | int | - |
| `LEADERBOARDS_READ_CLEAR_ALL` | `int LEADERBOARDS_READ_CLEAR_ALL()` | int | - |
| `LEADERBOARDS_READ_PENDING` | `bool LEADERBOARDS_READ_PENDING(object p0, object p1, object p2)` | bool | - |
| `LEADERBOARDS_READ_SUCCESSFUL` | `bool LEADERBOARDS_READ_SUCCESSFUL(object p0, object p1, object p2)` | bool | - |
| `LEADERBOARDS_WRITE_ADD_COLUMN` | `void LEADERBOARDS_WRITE_ADD_COLUMN(object p0, object p1, float p2)` | void | - |
| `LEADERBOARDS_WRITE_ADD_COLUMN_LONG` | `void LEADERBOARDS_WRITE_ADD_COLUMN_LONG(object p0, object p1, object p2)` | void | - |
| `NETWORK_BUY_AIRSTRIKE` | `void NETWORK_BUY_AIRSTRIKE(int cost, bool p1, bool p2, object p3)` | void | p1 = 0 (always)<br>p2 = 1 (always) |
| `NETWORK_BUY_BACKUP_GANG` | `void NETWORK_BUY_BACKUP_GANG(int p0, int p1, bool p2, bool p3, int npcProvider)` | void | - |
| `NETWORK_BUY_BOUNTY` | `void NETWORK_BUY_BOUNTY(int amount, int victim, bool p2, bool p3, object p4)` | void | p1 is just an assumption. p2 was false and p3 was true. |
| `NETWORK_BUY_CONTRABAND_MISSION` | `void NETWORK_BUY_CONTRABAND_MISSION(int p0, int p1, uint p2, bool p3, bool p4)` | void | - |
| `NETWORK_BUY_FAIRGROUND_RIDE` | `void NETWORK_BUY_FAIRGROUND_RIDE(int amount, object p1, bool p2, bool p3, object p4)` | void | The first parameter is the amount spent which is store in a global when this native is called. The g... |
| `NETWORK_BUY_HEALTHCARE` | `void NETWORK_BUY_HEALTHCARE(int cost, bool p1, bool p2)` | void | - |
| `NETWORK_BUY_HELI_STRIKE` | `void NETWORK_BUY_HELI_STRIKE(int cost, bool p1, bool p2, object p3)` | void | p1 = 0 (always)<br>p2 = 1 (always) |
| `NETWORK_BUY_ITEM` | `void NETWORK_BUY_ITEM(int amount, uint item, object p2, object p3, bool p4, string item_name, object p6, object p7, object p8, bool p9)` | void | - |
| `NETWORK_BUY_PROPERTY` | `void NETWORK_BUY_PROPERTY(int cost, uint propertyName, bool p2, bool p3)` | void | - |
| `NETWORK_BUY_SMOKES` | `void NETWORK_BUY_SMOKES(int p0, bool p1, bool p2)` | void | - |
| `NETWORK_CAN_BET` | `bool NETWORK_CAN_BET(int amount)` | bool | - |
| `NETWORK_CAN_RECEIVE_PLAYER_CASH` | `bool NETWORK_CAN_RECEIVE_PLAYER_CASH(object p0, object p1, object p2, object p3)` | bool | - |
| `NETWORK_CAN_SHARE_JOB_CASH` | `bool NETWORK_CAN_SHARE_JOB_CASH()` | bool | - |
| `NETWORK_CAN_SPEND_MONEY` | `bool NETWORK_CAN_SPEND_MONEY(object p0, bool p1, bool p2, bool p3, object p4, object p5)` | bool | - |
| `NETWORK_CAN_SPEND_MONEY2` | `bool NETWORK_CAN_SPEND_MONEY2(object p0, bool p1, bool p2, bool p3, ref object p4, object p5, object p6)` | bool | - |
| `NETWORK_CASINO_BUY_CHIPS` | `bool NETWORK_CASINO_BUY_CHIPS(int p0, int p1)` | bool | - |
| `NETWORK_CASINO_CAN_BET` | `bool NETWORK_CASINO_CAN_BET(uint hash)` | bool | GTAO_CASINO_HOUSE<br>GTAO_CASINO_INSIDETRACK<br>GTAO_CASINO_LUCKYWHEEL<br>GTAO_CASINO_BLACKJACK<br>GTAO_CASINO_R... |
| `NETWORK_CASINO_CAN_BET_AMOUNT` | `bool NETWORK_CASINO_CAN_BET_AMOUNT(object p0)` | bool | - |
| `NETWORK_CASINO_CAN_BET_PVC` | `bool NETWORK_CASINO_CAN_BET_PVC()` | bool | - |
| `NETWORK_CASINO_CAN_BUY_CHIPS_PVC` | `bool NETWORK_CASINO_CAN_BUY_CHIPS_PVC()` | bool | - |
| `NETWORK_CASINO_SELL_CHIPS` | `bool NETWORK_CASINO_SELL_CHIPS(int p0, int p1)` | bool | - |
| `NETWORK_CLEAR_CHARACTER_WALLET` | `void NETWORK_CLEAR_CHARACTER_WALLET(int characterSlot)` | void | - |
| `NETWORK_DEDUCT_CASH` | `void NETWORK_DEDUCT_CASH(int amount, string p1, string p2, bool p3, bool p4, bool p5)` | void | - |
| `NETWORK_DEFER_CASH_TRANSACTIONS_UNTIL_SHOP_SAVE` | `void NETWORK_DEFER_CASH_TRANSACTIONS_UNTIL_SHOP_SAVE()` | void | Does nothing (it's a nullsub). |
| `NETWORK_DELETE_CHARACTER` | `void NETWORK_DELETE_CHARACTER(int characterSlot, bool p1, bool p2)` | void | Note the 2nd parameters are always 1, 0. I have a feeling it deals with your money, wallet, bank. So... |
| `NETWORK_EARN_AGENCY` | `void NETWORK_EARN_AGENCY(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_EARN_AGENCY_CONTRACT` | `void NETWORK_EARN_AGENCY_CONTRACT(object p0, object p1)` | void | - |
| `NETWORK_EARN_AGENCY_PHONE` | `void NETWORK_EARN_AGENCY_PHONE(object p0, object p1, object p2)` | void | - |
| `NETWORK_EARN_AGENCY_SAFE` | `void NETWORK_EARN_AGENCY_SAFE(object p0, object p1)` | void | - |
| `NETWORK_EARN_ARCADE` | `void NETWORK_EARN_ARCADE(object p0, object p1, object p2, object p3, object p4, object p5)` | void | - |
| `NETWORK_EARN_ARENA_CAREER_PROGRESSION` | `void NETWORK_EARN_ARENA_CAREER_PROGRESSION(int amount, object p1)` | void | - |
| `NETWORK_EARN_ARENA_SKILL_LEVEL_PROGRESSION` | `void NETWORK_EARN_ARENA_SKILL_LEVEL_PROGRESSION(int amount, object p1)` | void | - |
| `NETWORK_EARN_ARENA_WAR` | `void NETWORK_EARN_ARENA_WAR(int amount, object p1, object p2, object p3)` | void | - |
| `NETWORK_EARN_ARENA_WAR_ASSASSINATE_TARGET` | `void NETWORK_EARN_ARENA_WAR_ASSASSINATE_TARGET(int amount)` | void | - |
| `NETWORK_EARN_ARENA_WAR_EVENT_CARGO` | `void NETWORK_EARN_ARENA_WAR_EVENT_CARGO(int amount)` | void | - |
| `NETWORK_EARN_ASSASSINATE_TARGET_KILLED` | `void NETWORK_EARN_ASSASSINATE_TARGET_KILLED(int amount)` | void | - |
| `NETWORK_EARN_AUTOSHOP_BUSINESS` | `void NETWORK_EARN_AUTOSHOP_BUSINESS(object p0, object p1, object p2)` | void | - |
| `NETWORK_EARN_AUTOSHOP_INCOME` | `void NETWORK_EARN_AUTOSHOP_INCOME(object p0, int p1)` | void | - |
| `NETWORK_EARN_AWARD_CONTRACT` | `void NETWORK_EARN_AWARD_CONTRACT(object p0, object p1)` | void | - |
| `NETWORK_EARN_AWARD_FIXER_MISSION` | `void NETWORK_EARN_AWARD_FIXER_MISSION(object p0, object p1)` | void | - |
| `NETWORK_EARN_AWARD_PHONE` | `void NETWORK_EARN_AWARD_PHONE(object p0, object p1)` | void | - |
| `NETWORK_EARN_AWARD_SHORT_TRIP` | `void NETWORK_EARN_AWARD_SHORT_TRIP(object p0, object p1)` | void | - |
| `NETWORK_EARN_BB_EVENT_BONUS` | `void NETWORK_EARN_BB_EVENT_BONUS(int amount)` | void | - |
| `NETWORK_EARN_BEACH_PARTY_LOST_FOUND` | `void NETWORK_EARN_BEACH_PARTY_LOST_FOUND(object p0, object p1, object p2)` | void | - |
| `NETWORK_EARN_BIKER` | `void NETWORK_EARN_BIKER(object p0)` | void | - |
| `NETWORK_EARN_BIKER_SHOP` | `void NETWORK_EARN_BIKER_SHOP(object p0, object p1)` | void | - |
| `NETWORK_EARN_BOSS` | `void NETWORK_EARN_BOSS(object p0, object p1, object p2)` | void | - |
| `NETWORK_EARN_BOUNTY_HUNTER_REWARD` | `void NETWORK_EARN_BOUNTY_HUNTER_REWARD(object p0)` | void | - |
| `NETWORK_EARN_CARCLUB_MEMBERSHIP` | `void NETWORK_EARN_CARCLUB_MEMBERSHIP(object p0)` | void | - |
| `NETWORK_EARN_CASINO_AWARD` | `void NETWORK_EARN_CASINO_AWARD(int amount, uint hash)` | void | - |
| `NETWORK_EARN_CASINO_COLLECTABLE_COMPLETED_COLLECTION` | `void NETWORK_EARN_CASINO_COLLECTABLE_COMPLETED_COLLECTION(int amount)` | void | - |
| `NETWORK_EARN_CASINO_HEIST` | `void NETWORK_EARN_CASINO_HEIST(object p0, object p1, object p2, object p3, object p4, object p5, object p6)` | void | - |
| `NETWORK_EARN_CASINO_HEIST_AWARDS` | `void NETWORK_EARN_CASINO_HEIST_AWARDS(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `NETWORK_EARN_CASINO_MISSION_PARTICIPATION` | `void NETWORK_EARN_CASINO_MISSION_PARTICIPATION(int amount)` | void | - |
| `NETWORK_EARN_CASINO_MISSION_REWARD` | `void NETWORK_EARN_CASINO_MISSION_REWARD(int amount)` | void | - |
| `NETWORK_EARN_CASINO_STORY_MISSION_REWARD` | `void NETWORK_EARN_CASINO_STORY_MISSION_REWARD(int amount)` | void | - |
| `NETWORK_EARN_CASINO_TIME_TRIAL_WIN` | `void NETWORK_EARN_CASINO_TIME_TRIAL_WIN(int amount)` | void | - |
| `NETWORK_EARN_CHALLENGE` | `void NETWORK_EARN_CHALLENGE(int amount, object p1, object p2)` | void | - |
| `NETWORK_EARN_COLLECTABLES` | `void NETWORK_EARN_COLLECTABLES(object p0, object p1, object p2)` | void | - |
| `NETWORK_EARN_COLLECTABLES_ACTION_FIGURES` | `void NETWORK_EARN_COLLECTABLES_ACTION_FIGURES(int amount)` | void | - |
| `NETWORK_EARN_COLLECTABLE_COMPLETED_COLLECTION` | `void NETWORK_EARN_COLLECTABLE_COMPLETED_COLLECTION(int amount, object p1)` | void | - |
| `NETWORK_EARN_COLLECTABLE_ITEM` | `void NETWORK_EARN_COLLECTABLE_ITEM(int amount, object p1)` | void | - |
| `NETWORK_EARN_DAILY_OBJECTIVE_EVENT` | `void NETWORK_EARN_DAILY_OBJECTIVE_EVENT(int amount)` | void | - |
| `NETWORK_EARN_DAILY_VEHICLE` | `void NETWORK_EARN_DAILY_VEHICLE(object p0, object p1)` | void | - |
| `NETWORK_EARN_DAILY_VEHICLE_BONUS` | `void NETWORK_EARN_DAILY_VEHICLE_BONUS(object p0)` | void | - |
| `NETWORK_EARN_DAR_CHALLENGE` | `void NETWORK_EARN_DAR_CHALLENGE(int amount, object p1)` | void | - |
| `NETWORK_EARN_DISPATCH_CALL` | `void NETWORK_EARN_DISPATCH_CALL(int amount, object p1)` | void | - |
| `NETWORK_EARN_DOOMSDAY_FINALE_BONUS` | `void NETWORK_EARN_DOOMSDAY_FINALE_BONUS(int amount, uint vehicleHash)` | void | - |
| `NETWORK_EARN_FIRST_TIME_BONUS` | `void NETWORK_EARN_FIRST_TIME_BONUS(object p0, object p1, object p2)` | void | - |
| `NETWORK_EARN_FIXER_AGENCY_SHORT_TRIP` | `void NETWORK_EARN_FIXER_AGENCY_SHORT_TRIP(object p0, object p1)` | void | - |
| `NETWORK_EARN_FIXER_FINALE` | `void NETWORK_EARN_FIXER_FINALE(object p0, object p1)` | void | - |
| `NETWORK_EARN_FIXER_PREP` | `void NETWORK_EARN_FIXER_PREP(object p0, object p1)` | void | - |
| `NETWORK_EARN_FIXER_RIVAL_DELIVERY` | `void NETWORK_EARN_FIXER_RIVAL_DELIVERY(object p0, object p1)` | void | - |
| `NETWORK_EARN_FMBB_WAGE_BONUS` | `void NETWORK_EARN_FMBB_WAGE_BONUS(object p0)` | void | - |
| `NETWORK_EARN_FROM_AI_TARGET_KILL` | `void NETWORK_EARN_FROM_AI_TARGET_KILL(object p0, object p1)` | void | DSPORT |
| `NETWORK_EARN_FROM_AMBIENT_JOB` | `void NETWORK_EARN_FROM_AMBIENT_JOB(int p0, string p1, ref object p2)` | void | Example for p1: "AM_DISTRACT_COPS" |
| `NETWORK_EARN_FROM_BEND_JOB` | `void NETWORK_EARN_FROM_BEND_JOB(int amount, string heistHash)` | void | - |
| `NETWORK_EARN_FROM_BETTING` | `void NETWORK_EARN_FROM_BETTING(int amount, string p1)` | void | - |
| `NETWORK_EARN_FROM_BOUNTY` | `void NETWORK_EARN_FROM_BOUNTY(int amount, ref object gamerHandle, ref object p2, object p3)` | void | - |
| `NETWORK_EARN_FROM_BUSINESS_BATTLE` | `void NETWORK_EARN_FROM_BUSINESS_BATTLE(object p0)` | void | - |
| `NETWORK_EARN_FROM_BUSINESS_HUB_SELL` | `void NETWORK_EARN_FROM_BUSINESS_HUB_SELL(object p0, object p1, object p2)` | void | - |
| `NETWORK_EARN_FROM_BUSINESS_PRODUCT` | `void NETWORK_EARN_FROM_BUSINESS_PRODUCT(int amount, object p1, object p2, object p3)` | void | - |
| `NETWORK_EARN_FROM_CASHING_OUT` | `void NETWORK_EARN_FROM_CASHING_OUT(int amount)` | void | - |
| `NETWORK_EARN_FROM_CHALLENGE_WIN` | `void NETWORK_EARN_FROM_CHALLENGE_WIN(object p0, ref object p1, bool p2)` | void | - |
| `NETWORK_EARN_FROM_CLUB_MANAGEMENT_PARTICIPATION` | `void NETWORK_EARN_FROM_CLUB_MANAGEMENT_PARTICIPATION(object p0, int p1)` | void | - |
| `NETWORK_EARN_FROM_CONTRABAND` | `void NETWORK_EARN_FROM_CONTRABAND(int amount, object p1)` | void | - |
| `NETWORK_EARN_FROM_CRATE_DROP` | `void NETWORK_EARN_FROM_CRATE_DROP(int amount)` | void | - |
| `NETWORK_EARN_FROM_CRIMINAL_MASTERMIND` | `void NETWORK_EARN_FROM_CRIMINAL_MASTERMIND(object p0, object p1, object p2)` | void | - |
| `NETWORK_EARN_FROM_DAILY_OBJECTIVES` | `void NETWORK_EARN_FROM_DAILY_OBJECTIVES(int amount, string type, int characterSlot)` | void | type either Monthly,Weekly,Daily |
| `NETWORK_EARN_FROM_DESTROYING_CONTRABAND` | `void NETWORK_EARN_FROM_DESTROYING_CONTRABAND(object p0, object p1, object p2)` | void | - |
| `NETWORK_EARN_FROM_FMBB_BOSS_WORK` | `void NETWORK_EARN_FROM_FMBB_BOSS_WORK(object p0)` | void | - |
| `NETWORK_EARN_FROM_FMBB_PHONECALL_MISSION` | `void NETWORK_EARN_FROM_FMBB_PHONECALL_MISSION(object p0)` | void | - |
| `NETWORK_EARN_FROM_GANGATTACK_PICKUP` | `void NETWORK_EARN_FROM_GANGATTACK_PICKUP(int amount)` | void | - |
| `NETWORK_EARN_FROM_HANGAR_TRADE` | `void NETWORK_EARN_FROM_HANGAR_TRADE(object p0, object p1)` | void | - |
| `NETWORK_EARN_FROM_HOLDUPS` | `void NETWORK_EARN_FROM_HOLDUPS(int amount)` | void | - |
| `NETWORK_EARN_FROM_IMPORT_EXPORT` | `void NETWORK_EARN_FROM_IMPORT_EXPORT(int amount, uint modelHash)` | void | - |
| `NETWORK_EARN_FROM_ISLAND_HEIST_DJ_MISSION` | `void NETWORK_EARN_FROM_ISLAND_HEIST_DJ_MISSION(object p0, object p1)` | void | - |
| `NETWORK_EARN_FROM_JOB` | `void NETWORK_EARN_FROM_JOB(int amount, string p1)` | void | - |
| `NETWORK_EARN_FROM_JOBX2` | `void NETWORK_EARN_FROM_JOBX2(int amount, string p1)` | void | - |
| `NETWORK_EARN_FROM_JOB_BONUS` | `void NETWORK_EARN_FROM_JOB_BONUS(object p0, ref object p1, ref object p2)` | void | - |
| `NETWORK_EARN_FROM_NOT_BADSPORT` | `void NETWORK_EARN_FROM_NOT_BADSPORT(int amount)` | void | - |
| `NETWORK_EARN_FROM_PERSONAL_VEHICLE` | `void NETWORK_EARN_FROM_PERSONAL_VEHICLE(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8)` | void | - |
| `NETWORK_EARN_FROM_PICKUP` | `void NETWORK_EARN_FROM_PICKUP(int amount)` | void | - |
| `NETWORK_EARN_FROM_PREMIUM_JOB` | `void NETWORK_EARN_FROM_PREMIUM_JOB(int amount, string p1)` | void | - |
| `NETWORK_EARN_FROM_PROPERTY` | `void NETWORK_EARN_FROM_PROPERTY(int amount, uint propertyName)` | void | - |
| `NETWORK_EARN_FROM_ROB_ARMORED_CARS` | `void NETWORK_EARN_FROM_ROB_ARMORED_CARS(int amount)` | void | For the money bags that drop a max of $40,000. Often called 40k bags.<br><br>Most likely NETWORK_EARN_FROM... |
| `NETWORK_EARN_FROM_SELL_BUNKER` | `void NETWORK_EARN_FROM_SELL_BUNKER(int amount, uint bunkerHash)` | void | - |
| `NETWORK_EARN_FROM_SMUGGLER_WORK` | `void NETWORK_EARN_FROM_SMUGGLER_WORK(object p0, object p1, object p2, object p3, object p4, object p5)` | void | - |
| `NETWORK_EARN_FROM_VEHICLE` | `void NETWORK_EARN_FROM_VEHICLE(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7)` | void | - |
| `NETWORK_EARN_FROM_VEHICLE_EXPORT` | `void NETWORK_EARN_FROM_VEHICLE_EXPORT(int amount, object p1, object p2)` | void | - |
| `NETWORK_EARN_FROM_WAREHOUSE` | `void NETWORK_EARN_FROM_WAREHOUSE(int amount, int id)` | void | - |
| `NETWORK_EARN_GANGOPS_AWARD` | `void NETWORK_EARN_GANGOPS_AWARD(int amount, string p1, object p2)` | void | - |
| `NETWORK_EARN_GANGOPS_ELITE` | `void NETWORK_EARN_GANGOPS_ELITE(int amount, string p1, int actIndex)` | void | - |
| `NETWORK_EARN_GANGOPS_FINALE` | `void NETWORK_EARN_GANGOPS_FINALE(int amount, string p1)` | void | - |
| `NETWORK_EARN_GANGOPS_PREP_PARTICIPATION` | `void NETWORK_EARN_GANGOPS_PREP_PARTICIPATION(int amount)` | void | - |
| `NETWORK_EARN_GANGOPS_SETUP` | `void NETWORK_EARN_GANGOPS_SETUP(int amount, string p1)` | void | - |
| `NETWORK_EARN_GANGOPS_WAGES` | `void NETWORK_EARN_GANGOPS_WAGES(int amount, int p1)` | void | - |
| `NETWORK_EARN_GANGOPS_WAGES_BONUS` | `void NETWORK_EARN_GANGOPS_WAGES_BONUS(int amount, int p1)` | void | - |
| `NETWORK_EARN_GOON` | `void NETWORK_EARN_GOON(object p0, object p1, object p2)` | void | - |
| `NETWORK_EARN_HACKER_TRUCK` | `void NETWORK_EARN_HACKER_TRUCK(object p0, int amount, object p2, object p3)` | void | - |
| `NETWORK_EARN_HEIST_AWARD` | `void NETWORK_EARN_HEIST_AWARD(object p0, object p1, object p2)` | void | - |
| `NETWORK_EARN_ISLAND_HEIST` | `void NETWORK_EARN_ISLAND_HEIST(int amount1, object p1, object p2, object p3, int amount2, int p5)` | void | - |
| `NETWORK_EARN_NIGHTCLUB` | `void NETWORK_EARN_NIGHTCLUB(object p0, object p1)` | void | - |
| `NETWORK_EARN_NIGHTCLUB_AND_WAREHOUSE` | `void NETWORK_EARN_NIGHTCLUB_AND_WAREHOUSE(object p0, object p1, object p2, object p3, object p4, object p5, object p6)` | void | - |
| `NETWORK_EARN_NIGHTCLUB_DANCING` | `void NETWORK_EARN_NIGHTCLUB_DANCING(object p0)` | void | - |
| `NETWORK_EARN_PURCHASE_CLUB_HOUSE` | `void NETWORK_EARN_PURCHASE_CLUB_HOUSE(object p0, object p1)` | void | - |
| `NETWORK_EARN_RC_TIME_TRIAL` | `void NETWORK_EARN_RC_TIME_TRIAL(int amount)` | void | - |
| `NETWORK_EARN_RDR_BONUS` | `void NETWORK_EARN_RDR_BONUS(int amount, object p1)` | void | - |
| `NETWORK_EARN_SELL_BASE` | `void NETWORK_EARN_SELL_BASE(int amount, uint baseNameHash)` | void | - |
| `NETWORK_EARN_SELL_PRIZE_VEHICLE` | `void NETWORK_EARN_SELL_PRIZE_VEHICLE(int amount, object p1, object p2)` | void | - |
| `NETWORK_EARN_SIGHTSEEING_REWARD` | `void NETWORK_EARN_SIGHTSEEING_REWARD(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_EARN_SMUGGLER_AGENCY` | `void NETWORK_EARN_SMUGGLER_AGENCY(int amount, object p1, object p2, object p3)` | void | - |
| `NETWORK_EARN_SPIN_THE_WHEEL_CASH` | `void NETWORK_EARN_SPIN_THE_WHEEL_CASH(int amount)` | void | - |
| `NETWORK_EARN_TARGET_REFUND` | `void NETWORK_EARN_TARGET_REFUND(int amount, int p1)` | void | - |
| `NETWORK_EARN_TUNER_AWARD` | `void NETWORK_EARN_TUNER_AWARD(object p0, object p1, object p2)` | void | - |
| `NETWORK_EARN_TUNER_ROBBERY` | `void NETWORK_EARN_TUNER_ROBBERY(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `NETWORK_EARN_UPGRADE_AGENCY` | `void NETWORK_EARN_UPGRADE_AGENCY(object p0, object p1)` | void | - |
| `NETWORK_EARN_UPGRADE_ARCADE` | `void NETWORK_EARN_UPGRADE_ARCADE(object p0, object p1, object p2)` | void | - |
| `NETWORK_EARN_UPGRADE_AUTOSHOP` | `void NETWORK_EARN_UPGRADE_AUTOSHOP(object p0, object p1)` | void | - |
| `NETWORK_EARN_WAGE_PAYMENT` | `void NETWORK_EARN_WAGE_PAYMENT(int amount, object p1)` | void | - |
| `NETWORK_EARN_WAGE_PAYMENT_BONUS` | `void NETWORK_EARN_WAGE_PAYMENT_BONUS(int amount)` | void | - |
| `NETWORK_EARN_YATCH_MISSION` | `void NETWORK_EARN_YATCH_MISSION(int amount, object p1)` | void | - |
| `NETWORK_ECONOMY_HAS_FIXED_CRAZY_NUMBERS` | `bool NETWORK_ECONOMY_HAS_FIXED_CRAZY_NUMBERS()` | bool | - |
| `NETWORK_GET_CAN_SPEND_FROM_BANK` | `bool NETWORK_GET_CAN_SPEND_FROM_BANK(int amount)` | bool | Returns true if bank balance >= amount. |
| `NETWORK_GET_CAN_SPEND_FROM_BANK_AND_WALLET` | `bool NETWORK_GET_CAN_SPEND_FROM_BANK_AND_WALLET(int amount, int characterSlot)` | bool | Returns true if bank balance + wallet balance >= amount. |
| `NETWORK_GET_CAN_SPEND_FROM_WALLET` | `bool NETWORK_GET_CAN_SPEND_FROM_WALLET(int amount, int characterSlot)` | bool | Returns true if wallet balance >= amount. |
| `NETWORK_GET_CAN_TRANSFER_CASH` | `bool NETWORK_GET_CAN_TRANSFER_CASH(int amount)` | bool | Returns false if amount > wallet balance or daily transfer limit has been hit. |
| `NETWORK_GET_EVC_BALANCE` | `int NETWORK_GET_EVC_BALANCE()` | int | - |
| `NETWORK_GET_PLAYER_IS_HIGH_EARNER` | `bool NETWORK_GET_PLAYER_IS_HIGH_EARNER()` | bool | - |
| `NETWORK_GET_PVC_BALANCE` | `int NETWORK_GET_PVC_BALANCE()` | int | - |
| `NETWORK_GET_PVC_TRANSFER_BALANCE` | `int NETWORK_GET_PVC_TRANSFER_BALANCE()` | int | Retturns the same value as NETWORK_GET_REMAINING_TRANSFER_BALANCE. |
| `NETWORK_GET_REMAINING_TRANSFER_BALANCE` | `int NETWORK_GET_REMAINING_TRANSFER_BALANCE()` | int | Returns the same value as NETWORK_GET_PVC_TRANSFER_BALANCE. |
| `NETWORK_GET_STRING_BANK_BALANCE` | `string NETWORK_GET_STRING_BANK_BALANCE()` | string | - |
| `NETWORK_GET_STRING_BANK_WALLET_BALANCE` | `string NETWORK_GET_STRING_BANK_WALLET_BALANCE(int character)` | string | - |
| `NETWORK_GET_STRING_WALLET_BALANCE` | `string NETWORK_GET_STRING_WALLET_BALANCE(int characterSlot)` | string | - |
| `NETWORK_GET_VC_BALANCE` | `int NETWORK_GET_VC_BALANCE()` | int | - |
| `NETWORK_GET_VC_BANK_BALANCE` | `int NETWORK_GET_VC_BANK_BALANCE()` | int | - |
| `NETWORK_GET_VC_WALLET_BALANCE` | `int NETWORK_GET_VC_WALLET_BALANCE(int characterSlot)` | int | - |
| `NETWORK_GIVE_PLAYER_JOBSHARE_CASH` | `void NETWORK_GIVE_PLAYER_JOBSHARE_CASH(int amount, ref object gamerHandle)` | void | - |
| `NETWORK_INITIALIZE_CASH` | `void NETWORK_INITIALIZE_CASH(int wallet, int bank)` | void | - |
| `NETWORK_MANUAL_DELETE_CHARACTER` | `void NETWORK_MANUAL_DELETE_CHARACTER(int characterSlot)` | void | - |
| `NETWORK_MONEY_CAN_BET` | `bool NETWORK_MONEY_CAN_BET(int amount, bool p1, bool p2)` | bool | - |
| `NETWORK_PAY_EMPLOYEE_WAGE` | `void NETWORK_PAY_EMPLOYEE_WAGE(object p0, bool p1, bool p2)` | void | - |
| `NETWORK_PAY_MATCH_ENTRY_FEE` | `void NETWORK_PAY_MATCH_ENTRY_FEE(int amount, string matchId, bool p2, bool p3)` | void | - |
| `NETWORK_RECEIVE_PLAYER_JOBSHARE_CASH` | `void NETWORK_RECEIVE_PLAYER_JOBSHARE_CASH(int value, ref object gamerHandle)` | void | - |
| `NETWORK_REFUND_CASH` | `void NETWORK_REFUND_CASH(int index, string context, string reason, bool p3)` | void | index<br>-------<br>See function sub_1005 in am_boat_taxi.ysc<br><br>context<br>----------<br>"BACKUP_VAGOS"<br>"BACKUP_L... |
| `NETWORK_SERVICE_EARN_GANGOPS_RIVAL_DELIVERY` | `void NETWORK_SERVICE_EARN_GANGOPS_RIVAL_DELIVERY(int earnedMoney)` | void | - |
| `NETWORK_SPEND_AGENCY` | `void NETWORK_SPEND_AGENCY(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `NETWORK_SPEND_APARTMENT_UTILITIES` | `void NETWORK_SPEND_APARTMENT_UTILITIES(int amount, bool p1, bool p2, ref object data)` | void | - |
| `NETWORK_SPEND_ARCADE` | `void NETWORK_SPEND_ARCADE(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `NETWORK_SPEND_ARCADE_MGMT` | `void NETWORK_SPEND_ARCADE_MGMT(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `NETWORK_SPEND_ARENA_PREMIUM` | `void NETWORK_SPEND_ARENA_PREMIUM(int amount, bool p1, bool p2)` | void | - |
| `NETWORK_SPEND_ARENA_SPECTATOR_BOX` | `void NETWORK_SPEND_ARENA_SPECTATOR_BOX(int amount, int type, bool p2, bool p3)` | void | type either, 1 for cam spectate, 2 for drone |
| `NETWORK_SPEND_AUTOSHOP_MODIFY` | `void NETWORK_SPEND_AUTOSHOP_MODIFY(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `NETWORK_SPEND_BEACH_PARTY` | `void NETWORK_SPEND_BEACH_PARTY(object p0)` | void | - |
| `NETWORK_SPEND_BIKE_SHOP` | `void NETWORK_SPEND_BIKE_SHOP(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_BOSS` | `void NETWORK_SPEND_BOSS(object p0, object p1, object p2)` | void | - |
| `NETWORK_SPEND_BOUNTY_HUNTER_MISSION` | `void NETWORK_SPEND_BOUNTY_HUNTER_MISSION(int amount, bool p1, bool p2)` | void | - |
| `NETWORK_SPEND_BUSINESS_PROPERTY_FEES` | `void NETWORK_SPEND_BUSINESS_PROPERTY_FEES(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_BUY_AGENCY` | `void NETWORK_SPEND_BUY_AGENCY(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_BUY_ARCADE` | `void NETWORK_SPEND_BUY_ARCADE(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_BUY_ARENA` | `void NETWORK_SPEND_BUY_ARENA(int amount, bool p1, bool p2, string p3)` | void | - |
| `NETWORK_SPEND_BUY_AUTOSHOP` | `void NETWORK_SPEND_BUY_AUTOSHOP(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_BUY_CASINO` | `void NETWORK_SPEND_BUY_CASINO(int amount, bool p1, bool p2, ref object data)` | void | - |
| `NETWORK_SPEND_BUY_SUB` | `void NETWORK_SPEND_BUY_SUB(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_CAR_CLUB_BAR` | `void NETWORK_SPEND_CAR_CLUB_BAR(object p0, bool p1, bool p2, object p3)` | void | - |
| `NETWORK_SPEND_CAR_CLUB_MEMBERSHIP` | `void NETWORK_SPEND_CAR_CLUB_MEMBERSHIP(int amount1, object p1, object p2, int amount2, object p4)` | void | - |
| `NETWORK_SPEND_CAR_CLUB_TAKEOVER` | `void NETWORK_SPEND_CAR_CLUB_TAKEOVER(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_CASINO_CLUB` | `void NETWORK_SPEND_CASINO_CLUB(int amount1, object p1, bool p2, object p3, int p4, int p5, int p6, int amount2, object p8)` | void | - |
| `NETWORK_SPEND_CASINO_GENERIC` | `void NETWORK_SPEND_CASINO_GENERIC(int amount, object p1, object p2, object p3, object p4)` | void | - |
| `NETWORK_SPEND_CASINO_HEIST` | `void NETWORK_SPEND_CASINO_HEIST(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9, object p10)` | void | - |
| `NETWORK_SPEND_CASINO_HEIST_SKIP_MISSION` | `void NETWORK_SPEND_CASINO_HEIST_SKIP_MISSION(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_CASINO_MEMBERSHIP` | `void NETWORK_SPEND_CASINO_MEMBERSHIP(int amount, bool p1, bool p2, int p3)` | void | - |
| `NETWORK_SPEND_COMP_SUV` | `void NETWORK_SPEND_COMP_SUV(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_EARNED_FROM_BANK_AND_WALLETS` | `int NETWORK_SPEND_EARNED_FROM_BANK_AND_WALLETS(int amount)` | int | Hardcoded to return 0. |
| `NETWORK_SPEND_GANGOPS_CANNON` | `void NETWORK_SPEND_GANGOPS_CANNON(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_GANGOPS_REPAIR_COST` | `void NETWORK_SPEND_GANGOPS_REPAIR_COST(object p0, object p1, object p2)` | void | - |
| `NETWORK_SPEND_GANGOPS_SKIP_MISSION` | `void NETWORK_SPEND_GANGOPS_SKIP_MISSION(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_GANGOPS_START_STRAND` | `void NETWORK_SPEND_GANGOPS_START_STRAND(int type, int amount, bool p2, bool p3)` | void | - |
| `NETWORK_SPEND_GANGOPS_TRIP_SKIP` | `void NETWORK_SPEND_GANGOPS_TRIP_SKIP(int amount, bool p1, bool p2)` | void | - |
| `NETWORK_SPEND_GOON` | `void NETWORK_SPEND_GOON(int p0, int p1, int amount)` | void | - |
| `NETWORK_SPEND_GUNRUNNING` | `void NETWORK_SPEND_GUNRUNNING(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_HIDDEN` | `void NETWORK_SPEND_HIDDEN(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_INTERACTION_MENU_ABILITY` | `void NETWORK_SPEND_INTERACTION_MENU_ABILITY(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_ISLAND_HEIST` | `void NETWORK_SPEND_ISLAND_HEIST(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_MAKE_IT_RAIN` | `void NETWORK_SPEND_MAKE_IT_RAIN(int amount, bool p1, bool p2)` | void | - |
| `NETWORK_SPEND_NIGHTCLUB_AND_WAREHOUSE` | `void NETWORK_SPEND_NIGHTCLUB_AND_WAREHOUSE(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_NIGHTCLUB_BAR_DRINK` | `void NETWORK_SPEND_NIGHTCLUB_BAR_DRINK(int amount, object p1, bool p2, bool p3)` | void | - |
| `NETWORK_SPEND_PLAY_ARCADE` | `void NETWORK_SPEND_PLAY_ARCADE(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `NETWORK_SPEND_SET_COMMON_FIELDS` | `void NETWORK_SPEND_SET_COMMON_FIELDS(object p0, object p1, object p2, bool p3)` | void | - |
| `NETWORK_SPEND_SET_DISCOUNT` | `void NETWORK_SPEND_SET_DISCOUNT(bool p0)` | void | - |
| `NETWORK_SPEND_SOURCE_BIKE` | `void NETWORK_SPEND_SOURCE_BIKE(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_SPIN_THE_WHEEL_PAYMENT` | `void NETWORK_SPEND_SPIN_THE_WHEEL_PAYMENT(int amount, object p1, bool p2)` | void | - |
| `NETWORK_SPEND_SUBMARINE` | `void NETWORK_SPEND_SUBMARINE(object p0, object p1, object p2, object p3, object p4, object p5)` | void | - |
| `NETWORK_SPEND_SUPPLY` | `void NETWORK_SPEND_SUPPLY(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_SUV_FST_TRVL` | `void NETWORK_SPEND_SUV_FST_TRVL(int p0, bool p1, bool p2, object p3)` | void | - |
| `NETWORK_SPEND_UPGRADE_AGENCY` | `void NETWORK_SPEND_UPGRADE_AGENCY(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_UPGRADE_ARCADE` | `void NETWORK_SPEND_UPGRADE_ARCADE(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_UPGRADE_ARENA` | `void NETWORK_SPEND_UPGRADE_ARENA(int amount, bool p1, bool p2, string p3)` | void | - |
| `NETWORK_SPEND_UPGRADE_AUTOSHOP` | `void NETWORK_SPEND_UPGRADE_AUTOSHOP(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_UPGRADE_CASINO` | `void NETWORK_SPEND_UPGRADE_CASINO(int amount, bool p1, bool p2, ref object data)` | void | - |
| `NETWORK_SPEND_UPGRADE_SUB` | `void NETWORK_SPEND_UPGRADE_SUB(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPEND_VEHICLE_REQUESTED` | `void NETWORK_SPEND_VEHICLE_REQUESTED(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `NETWORK_SPENT_AMMO_DROP` | `void NETWORK_SPENT_AMMO_DROP(object p0, bool p1, bool p2, object p3)` | void | - |
| `NETWORK_SPENT_ARENA_JOIN_SPECTATOR` | `void NETWORK_SPENT_ARENA_JOIN_SPECTATOR(int amount, object p1, bool p2, bool p3)` | void | - |
| `NETWORK_SPENT_ARREST_BAIL` | `void NETWORK_SPENT_ARREST_BAIL(object p0, bool p1, bool p2)` | void | - |
| `NETWORK_SPENT_BALLISTIC_EQUIPMENT` | `void NETWORK_SPENT_BALLISTIC_EQUIPMENT(int amount, bool p1, bool p2)` | void | - |
| `NETWORK_SPENT_BANK_INTEREST` | `void NETWORK_SPENT_BANK_INTEREST(int p0, bool p1, bool p2)` | void | - |
| `NETWORK_SPENT_BETTING` | `void NETWORK_SPENT_BETTING(int amount, int p1, string matchId, bool p3, bool p4)` | void | - |
| `NETWORK_SPENT_BOAT_PICKUP` | `void NETWORK_SPENT_BOAT_PICKUP(object p0, bool p1, bool p2, object p3)` | void | - |
| `NETWORK_SPENT_BOSS_GOON` | `bool NETWORK_SPENT_BOSS_GOON(int amount, bool p1, bool p2)` | bool | - |
| `NETWORK_SPENT_BOUNTY` | `void NETWORK_SPENT_BOUNTY(object p0, bool p1, bool p2)` | void | - |
| `NETWORK_SPENT_BULL_SHARK` | `void NETWORK_SPENT_BULL_SHARK(object p0, bool p1, bool p2, object p3)` | void | - |
| `NETWORK_SPENT_BUY_BASE` | `void NETWORK_SPENT_BUY_BASE(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_BUY_BUNKER` | `void NETWORK_SPENT_BUY_BUNKER(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_BUY_OFFTHERADAR` | `void NETWORK_SPENT_BUY_OFFTHERADAR(object p0, bool p1, bool p2, object p3)` | void | - |
| `NETWORK_SPENT_BUY_PASSIVE_MODE` | `void NETWORK_SPENT_BUY_PASSIVE_MODE(object p0, bool p1, bool p2, object p3)` | void | - |
| `NETWORK_SPENT_BUY_REVEAL_PLAYERS` | `void NETWORK_SPENT_BUY_REVEAL_PLAYERS(object p0, bool p1, bool p2, object p3)` | void | - |
| `NETWORK_SPENT_BUY_TILTROTOR` | `void NETWORK_SPENT_BUY_TILTROTOR(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_BUY_TRUCK` | `void NETWORK_SPENT_BUY_TRUCK(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_BUY_WANTEDLEVEL` | `void NETWORK_SPENT_BUY_WANTEDLEVEL(object p0, ref object p1, bool p2, bool p3, object p4)` | void | - |
| `NETWORK_SPENT_CALL_PLAYER` | `void NETWORK_SPENT_CALL_PLAYER(object p0, ref object p1, bool p2, bool p3)` | void | - |
| `NETWORK_SPENT_CARGO_SOURCING` | `void NETWORK_SPENT_CARGO_SOURCING(object p0, object p1, object p2, object p3, object p4, object p5, object p6)` | void | - |
| `NETWORK_SPENT_CARWASH` | `void NETWORK_SPENT_CARWASH(object p0, object p1, object p2, bool p3, bool p4)` | void | - |
| `NETWORK_SPENT_CASH_DROP` | `void NETWORK_SPENT_CASH_DROP(int amount, bool p1, bool p2)` | void | - |
| `NETWORK_SPENT_CHANGE_APPEARANCE` | `void NETWORK_SPENT_CHANGE_APPEARANCE(object p0, object p1, object p2)` | void | - |
| `NETWORK_SPENT_CINEMA` | `void NETWORK_SPENT_CINEMA(object p0, object p1, bool p2, bool p3)` | void | - |
| `NETWORK_SPENT_EMPLOY_ASSASSINS` | `void NETWORK_SPENT_EMPLOY_ASSASSINS(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_FROM_ROCKSTAR` | `void NETWORK_SPENT_FROM_ROCKSTAR(int p0, bool p1, bool p2)` | void | - |
| `NETWORK_SPENT_HANGAR_STAFF_CHARGES` | `void NETWORK_SPENT_HANGAR_STAFF_CHARGES(int amount, bool p1, bool p2)` | void | - |
| `NETWORK_SPENT_HANGAR_UTILITY_CHARGES` | `void NETWORK_SPENT_HANGAR_UTILITY_CHARGES(int amount, bool p1, bool p2)` | void | - |
| `NETWORK_SPENT_HELI_PICKUP` | `void NETWORK_SPENT_HELI_PICKUP(object p0, bool p1, bool p2, object p3)` | void | - |
| `NETWORK_SPENT_HIRE_MERCENARY` | `void NETWORK_SPENT_HIRE_MERCENARY(object p0, bool p1, bool p2, object p3)` | void | - |
| `NETWORK_SPENT_HIRE_MUGGER` | `void NETWORK_SPENT_HIRE_MUGGER(object p0, bool p1, bool p2, object p3)` | void | Only used once in a script (am_contact_requests)<br>p1 = 0<br>p2 = 1 |
| `NETWORK_SPENT_HOLDUPS` | `void NETWORK_SPENT_HOLDUPS(object p0, bool p1, bool p2)` | void | - |
| `NETWORK_SPENT_IMPORT_EXPORT_REPAIR` | `void NETWORK_SPENT_IMPORT_EXPORT_REPAIR(object p0, object p1, object p2)` | void | - |
| `NETWORK_SPENT_IN_STRIPCLUB` | `void NETWORK_SPENT_IN_STRIPCLUB(object p0, bool p1, object p2, bool p3)` | void | - |
| `NETWORK_SPENT_JOB_SKIP` | `void NETWORK_SPENT_JOB_SKIP(int amount, string matchId, bool p2, bool p3)` | void | - |
| `NETWORK_SPENT_JUKEBOX` | `void NETWORK_SPENT_JUKEBOX(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_MC_ABILITY` | `void NETWORK_SPENT_MC_ABILITY(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `NETWORK_SPENT_MOVE_SUBMARINE` | `void NETWORK_SPENT_MOVE_SUBMARINE(object p0, object p1, object p2)` | void | - |
| `NETWORK_SPENT_MOVE_YACHT` | `void NETWORK_SPENT_MOVE_YACHT(int amount, bool p1, bool p2)` | void | - |
| `NETWORK_SPENT_NIGHTCLUB_ENTRY_FEE` | `void NETWORK_SPENT_NIGHTCLUB_ENTRY_FEE(int player, int amount, object p1, bool p2, bool p3)` | void | - |
| `NETWORK_SPENT_NO_COPS` | `void NETWORK_SPENT_NO_COPS(object p0, bool p1, bool p2, object p3)` | void | - |
| `NETWORK_SPENT_ORDER_BODYGUARD_VEHICLE` | `void NETWORK_SPENT_ORDER_BODYGUARD_VEHICLE(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_ORDER_WAREHOUSE_VEHICLE` | `void NETWORK_SPENT_ORDER_WAREHOUSE_VEHICLE(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_PAY_BUSINESS_SUPPLIES` | `void NETWORK_SPENT_PAY_BUSINESS_SUPPLIES(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_PAY_VEHICLE_INSURANCE_PREMIUM` | `void NETWORK_SPENT_PAY_VEHICLE_INSURANCE_PREMIUM(int amount, uint vehicleModel, ref object gamerHandle, bool notBankrupt, bool hasTheMoney)` | void | According to how I understood this in the freemode script alone,<br>The first parameter is determined b... |
| `NETWORK_SPENT_PA_HELI_PICKUP` | `void NETWORK_SPENT_PA_HELI_PICKUP(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_PA_SERVICE_DANCER` | `void NETWORK_SPENT_PA_SERVICE_DANCER(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_PA_SERVICE_HELI` | `void NETWORK_SPENT_PA_SERVICE_HELI(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_PA_SERVICE_IMPOUND` | `void NETWORK_SPENT_PA_SERVICE_IMPOUND(object p0, object p1, object p2)` | void | - |
| `NETWORK_SPENT_PA_SERVICE_SNACK` | `void NETWORK_SPENT_PA_SERVICE_SNACK(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_PA_SERVICE_VEHICLE` | `void NETWORK_SPENT_PA_SERVICE_VEHICLE(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_PLAYER_HEALTHCARE` | `void NETWORK_SPENT_PLAYER_HEALTHCARE(int p0, int p1, bool p2, bool p3)` | void | - |
| `NETWORK_SPENT_PROSTITUTES` | `void NETWORK_SPENT_PROSTITUTES(object p0, bool p1, bool p2)` | void | - |
| `NETWORK_SPENT_PURCHASE_BUSINESS_PROPERTY` | `void NETWORK_SPENT_PURCHASE_BUSINESS_PROPERTY(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_PURCHASE_CLUB_HOUSE` | `void NETWORK_SPENT_PURCHASE_CLUB_HOUSE(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_PURCHASE_HACKER_TRUCK` | `void NETWORK_SPENT_PURCHASE_HACKER_TRUCK(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_PURCHASE_HANGAR` | `void NETWORK_SPENT_PURCHASE_HANGAR(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_PURCHASE_IMPEXP_WAREHOUSE_PROPERTY` | `void NETWORK_SPENT_PURCHASE_IMPEXP_WAREHOUSE_PROPERTY(int amount, ref object data, bool p2, bool p3)` | void | - |
| `NETWORK_SPENT_PURCHASE_NIGHTCLUB_AND_WAREHOUSE` | `void NETWORK_SPENT_PURCHASE_NIGHTCLUB_AND_WAREHOUSE(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_PURCHASE_OFFICE_GARAGE` | `void NETWORK_SPENT_PURCHASE_OFFICE_GARAGE(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_PURCHASE_OFFICE_PROPERTY` | `void NETWORK_SPENT_PURCHASE_OFFICE_PROPERTY(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `NETWORK_SPENT_PURCHASE_WAREHOUSE_PROPERTY` | `void NETWORK_SPENT_PURCHASE_WAREHOUSE_PROPERTY(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_RDR_HATCHET_BONUS` | `void NETWORK_SPENT_RDR_HATCHET_BONUS(int amount, bool p1, bool p2)` | void | - |
| `NETWORK_SPENT_REHIRE_DJ` | `void NETWORK_SPENT_REHIRE_DJ(int amount, object p1, bool p2, bool p3)` | void | - |
| `NETWORK_SPENT_RENAME_ORGANIZATION` | `void NETWORK_SPENT_RENAME_ORGANIZATION(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_REQUEST_HEIST` | `void NETWORK_SPENT_REQUEST_HEIST(object p0, bool p1, bool p2, object p3)` | void | - |
| `NETWORK_SPENT_REQUEST_JOB` | `void NETWORK_SPENT_REQUEST_JOB(object p0, bool p1, bool p2, object p3)` | void | - |
| `NETWORK_SPENT_ROBBED_BY_MUGGER` | `void NETWORK_SPENT_ROBBED_BY_MUGGER(int amount, bool p1, bool p2, object p3)` | void | - |
| `NETWORK_SPENT_TAXI` | `void NETWORK_SPENT_TAXI(int amount, bool p1, bool p2, object p3, object p4)` | void | - |
| `NETWORK_SPENT_TELESCOPE` | `void NETWORK_SPENT_TELESCOPE(object p0, bool p1, bool p2)` | void | - |
| `NETWORK_SPENT_TRADE_BUSINESS_PROPERTY` | `void NETWORK_SPENT_TRADE_BUSINESS_PROPERTY(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_TRADE_IMPEXP_WAREHOUSE_PROPERTY` | `void NETWORK_SPENT_TRADE_IMPEXP_WAREHOUSE_PROPERTY(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_UPGRADE_BASE` | `void NETWORK_SPENT_UPGRADE_BASE(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_UPGRADE_BUSINESS_PROPERTY` | `void NETWORK_SPENT_UPGRADE_BUSINESS_PROPERTY(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_UPGRADE_CLUB_HOUSE` | `void NETWORK_SPENT_UPGRADE_CLUB_HOUSE(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_UPGRADE_HACKER_TRUCK` | `void NETWORK_SPENT_UPGRADE_HACKER_TRUCK(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_UPGRADE_HANGAR` | `void NETWORK_SPENT_UPGRADE_HANGAR(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_UPGRADE_IMPEXP_WAREHOUSE_PROPERTY` | `void NETWORK_SPENT_UPGRADE_IMPEXP_WAREHOUSE_PROPERTY(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_UPGRADE_NIGHTCLUB_AND_WAREHOUSE` | `void NETWORK_SPENT_UPGRADE_NIGHTCLUB_AND_WAREHOUSE(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_UPGRADE_OFFICE_GARAGE` | `void NETWORK_SPENT_UPGRADE_OFFICE_GARAGE(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_UPGRADE_OFFICE_PROPERTY` | `void NETWORK_SPENT_UPGRADE_OFFICE_PROPERTY(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `NETWORK_SPENT_UPGRADE_TILTROTOR` | `void NETWORK_SPENT_UPGRADE_TILTROTOR(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_UPGRADE_TRUCK` | `void NETWORK_SPENT_UPGRADE_TRUCK(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_UPGRADE_WAREHOUSE_PROPERTY` | `void NETWORK_SPENT_UPGRADE_WAREHOUSE_PROPERTY(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_UPRADE_BUNKER` | `void NETWORK_SPENT_UPRADE_BUNKER(object p0, object p1, object p2, object p3)` | void | - |
| `NETWORK_SPENT_VEHICLE_EXPORT_MODS` | `void NETWORK_SPENT_VEHICLE_EXPORT_MODS(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9)` | void | - |
| `NETWORK_SPENT_WAGER` | `void NETWORK_SPENT_WAGER(object p0, object p1, int amount)` | void | - |
| `NETWORK_YOHAN_SOURCE_GOODS` | `void NETWORK_YOHAN_SOURCE_GOODS(object p0, object p1, object p2, object p3)` | void | - |
| `ORDER_BOSS_VEHICLE` | `void ORDER_BOSS_VEHICLE(object p0, object p1, uint vehicleHash)` | void | - |
| `PACKED_STAT_GET_INT_STAT_INDEX` | `int PACKED_STAT_GET_INT_STAT_INDEX(int p0)` | int | Needs more research. Possibly used to calculate the "mask" when calling "STAT_SET_MASKED_INT"? |
| `PLAYSTATS_ABANDONED_MC` | `void PLAYSTATS_ABANDONED_MC(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `PLAYSTATS_ACQUIRED_HIDDEN_PACKAGE` | `void PLAYSTATS_ACQUIRED_HIDDEN_PACKAGE(object p0)` | void | - |
| `PLAYSTATS_ACTIVITY_DONE` | `void PLAYSTATS_ACTIVITY_DONE(int p0, int activityId, object p2)` | void | - |
| `PLAYSTATS_APPEND_DIRECTOR_METRIC` | `void PLAYSTATS_APPEND_DIRECTOR_METRIC(ref object p0)` | void | - |
| `PLAYSTATS_ARCADE_CABINET` | `void PLAYSTATS_ARCADE_CABINET(object p0)` | void | - |
| `PLAYSTATS_ARCADE_GAME` | `void PLAYSTATS_ARCADE_GAME(object p0, object p1, object p2, object p3, object p4, object p5, object p6)` | void | - |
| `PLAYSTATS_ARCADE_LOVE_MATCH` | `void PLAYSTATS_ARCADE_LOVE_MATCH(object p0, object p1)` | void | - |
| `PLAYSTATS_ARENA_WARS_ENDED` | `void PLAYSTATS_ARENA_WARS_ENDED(ref object data)` | void | - |
| `PLAYSTATS_ARENA_WARS_SPECTATOR` | `void PLAYSTATS_ARENA_WARS_SPECTATOR(int p0, int p1, int p2, int p3, int p4)` | void | - |
| `PLAYSTATS_AWARD_BAD_SPORT` | `void PLAYSTATS_AWARD_BAD_SPORT(int id)` | void | - |
| `PLAYSTATS_AWARD_NAV` | `void PLAYSTATS_AWARD_NAV(object p0, object p1, object p2, object p3)` | void | - |
| `PLAYSTATS_AWARD_XP` | `void PLAYSTATS_AWARD_XP(int amount, uint type, uint category)` | void | - |
| `PLAYSTATS_BACKGROUND_SCRIPT_ACTION` | `void PLAYSTATS_BACKGROUND_SCRIPT_ACTION(string action, int value)` | void | - |
| `PLAYSTATS_BAN_ALERT` | `void PLAYSTATS_BAN_ALERT(int p0)` | void | - |
| `PLAYSTATS_BC_CAR_JACKING` | `void PLAYSTATS_BC_CAR_JACKING(object p0)` | void | - |
| `PLAYSTATS_BC_CASHING` | `void PLAYSTATS_BC_CASHING(object p0)` | void | - |
| `PLAYSTATS_BC_FINDERS_KEEPERS` | `void PLAYSTATS_BC_FINDERS_KEEPERS(object p0)` | void | - |
| `PLAYSTATS_BC_MOST_WANTED` | `void PLAYSTATS_BC_MOST_WANTED(object p0)` | void | - |
| `PLAYSTATS_BC_POINT_TO_POINT` | `void PLAYSTATS_BC_POINT_TO_POINT(object p0)` | void | - |
| `PLAYSTATS_BC_PROTECTION_RACKET` | `void PLAYSTATS_BC_PROTECTION_RACKET(object p0)` | void | - |
| `PLAYSTATS_BC_SALVAGE` | `void PLAYSTATS_BC_SALVAGE(object p0)` | void | - |
| `PLAYSTATS_BC_SMASH_AND_GRAB` | `void PLAYSTATS_BC_SMASH_AND_GRAB(object p0)` | void | - |
| `PLAYSTATS_BUSINESS_BATTLE_ENDED` | `void PLAYSTATS_BUSINESS_BATTLE_ENDED(object p0)` | void | - |
| `PLAYSTATS_BUY_CONTRABAND_MISSION` | `void PLAYSTATS_BUY_CONTRABAND_MISSION(ref object data)` | void | - |
| `PLAYSTATS_BW_AIR_FREIGHT` | `void PLAYSTATS_BW_AIR_FREIGHT(object p0)` | void | - |
| `PLAYSTATS_BW_ASSAULT` | `void PLAYSTATS_BW_ASSAULT(object p0)` | void | - |
| `PLAYSTATS_BW_BELLY_OF_THE_BEAST` | `void PLAYSTATS_BW_BELLY_OF_THE_BEAST(object p0)` | void | - |
| `PLAYSTATS_BW_BOSSONBOSSDEATHMATCH` | `void PLAYSTATS_BW_BOSSONBOSSDEATHMATCH(object p0)` | void | - |
| `PLAYSTATS_BW_FRAGILE_GOODS` | `void PLAYSTATS_BW_FRAGILE_GOODS(object p0)` | void | - |
| `PLAYSTATS_BW_HEAD_HUNTER` | `void PLAYSTATS_BW_HEAD_HUNTER(object p0)` | void | - |
| `PLAYSTATS_BW_HUNT_THE_BOSS` | `void PLAYSTATS_BW_HUNT_THE_BOSS(object p0)` | void | - |
| `PLAYSTATS_BW_SIGHTSEER` | `void PLAYSTATS_BW_SIGHTSEER(object p0)` | void | - |
| `PLAYSTATS_BW_YATCHATTACK` | `void PLAYSTATS_BW_YATCHATTACK(object p0)` | void | - |
| `PLAYSTATS_CARCLUB_CHALLENGE` | `void PLAYSTATS_CARCLUB_CHALLENGE(object p0, object p1, object p2, object p3)` | void | - |
| `PLAYSTATS_CARCLUB_POINTS` | `void PLAYSTATS_CARCLUB_POINTS(object p0)` | void | - |
| `PLAYSTATS_CARCLUB_PRIZE` | `void PLAYSTATS_CARCLUB_PRIZE(int p0, uint vehicleModel)` | void | - |
| `PLAYSTATS_CASINO_BLACKJACK` | `void PLAYSTATS_CASINO_BLACKJACK(object p0)` | void | - |
| `PLAYSTATS_CASINO_BLACKJACK_LIGHT` | `void PLAYSTATS_CASINO_BLACKJACK_LIGHT(object p0)` | void | - |
| `PLAYSTATS_CASINO_CHIP` | `void PLAYSTATS_CASINO_CHIP(object p0)` | void | - |
| `PLAYSTATS_CASINO_INSIDE_TRACK` | `void PLAYSTATS_CASINO_INSIDE_TRACK(object p0)` | void | - |
| `PLAYSTATS_CASINO_INSIDE_TRACK_LIGHT` | `void PLAYSTATS_CASINO_INSIDE_TRACK_LIGHT(object p0)` | void | - |
| `PLAYSTATS_CASINO_LUCKY_SEVEN` | `void PLAYSTATS_CASINO_LUCKY_SEVEN(object p0)` | void | - |
| `PLAYSTATS_CASINO_ROULETTE` | `void PLAYSTATS_CASINO_ROULETTE(object p0)` | void | - |
| `PLAYSTATS_CASINO_ROULETTE_LIGHT` | `void PLAYSTATS_CASINO_ROULETTE_LIGHT(object p0)` | void | - |
| `PLAYSTATS_CASINO_SLOT_MACHINE` | `void PLAYSTATS_CASINO_SLOT_MACHINE(object p0)` | void | - |
| `PLAYSTATS_CASINO_SLOT_MACHINE_LIGHT` | `void PLAYSTATS_CASINO_SLOT_MACHINE_LIGHT(object p0)` | void | - |
| `PLAYSTATS_CASINO_STORY_MISSION_ENDED` | `void PLAYSTATS_CASINO_STORY_MISSION_ENDED(object p0, object p1)` | void | - |
| `PLAYSTATS_CASINO_THREE_CARD_POKER` | `void PLAYSTATS_CASINO_THREE_CARD_POKER(object p0)` | void | - |
| `PLAYSTATS_CASINO_THREE_CARD_POKER_LIGHT` | `void PLAYSTATS_CASINO_THREE_CARD_POKER_LIGHT(object p0)` | void | - |
| `PLAYSTATS_CHANGE_MC_OUTFIT` | `void PLAYSTATS_CHANGE_MC_OUTFIT(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `PLAYSTATS_CHANGE_MC_ROLE` | `void PLAYSTATS_CHANGE_MC_ROLE(object p0, object p1, object p2, object p3, int role, int p5, object p6)` | void | - |
| `PLAYSTATS_CHEAT_APPLIED` | `void PLAYSTATS_CHEAT_APPLIED(string cheat)` | void | - |
| `PLAYSTATS_CLOTH_CHANGE` | `void PLAYSTATS_CLOTH_CHANGE(int p0, object p1, object p2, object p3, object p4)` | void | - |
| `PLAYSTATS_COLLECTIBLE_PICKED_UP` | `void PLAYSTATS_COLLECTIBLE_PICKED_UP(int p0, uint objectHash, object p2, object p3, int moneyAmount, int rpAmount, int chipsAmount, object p7, int p8, object p9, object p10)` | void | - |
| `PLAYSTATS_COPY_RANK_INTO_NEW_SLOT` | `void PLAYSTATS_COPY_RANK_INTO_NEW_SLOT(object p0, object p1, object p2, object p3, object p4, object p5, object p6)` | void | - |
| `PLAYSTATS_CRATE_CREATED` | `void PLAYSTATS_CRATE_CREATED(float p0, float p1, float p2)` | void | - |
| `PLAYSTATS_CRATE_DROP_MISSION_DONE` | `void PLAYSTATS_CRATE_DROP_MISSION_DONE(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7)` | void | - |
| `PLAYSTATS_CREATE_MATCH_HISTORY_ID_2` | `bool PLAYSTATS_CREATE_MATCH_HISTORY_ID_2(ref int playerAccountId, ref int posixTime)` | bool | - |
| `PLAYSTATS_DAR_CHECKPOINT` | `void PLAYSTATS_DAR_CHECKPOINT(ref object data)` | void | - |
| `PLAYSTATS_DEFEND_CONTRABAND_MISSION` | `void PLAYSTATS_DEFEND_CONTRABAND_MISSION(ref object data)` | void | - |
| `PLAYSTATS_DJ_MISSION_ENDED` | `void PLAYSTATS_DJ_MISSION_ENDED(object p0)` | void | - |
| `PLAYSTATS_DJ_USAGE` | `void PLAYSTATS_DJ_USAGE(object p0, object p1)` | void | - |
| `PLAYSTATS_DRONE_USAGE` | `void PLAYSTATS_DRONE_USAGE(int p0, int p1, int p2)` | void | - |
| `PLAYSTATS_DUPE_DETECTED` | `void PLAYSTATS_DUPE_DETECTED(ref object data)` | void | - |
| `PLAYSTATS_EARNED_MC_POINTS` | `void PLAYSTATS_EARNED_MC_POINTS(object p0, object p1, object p2, object p3, object p4, object p5)` | void | - |
| `PLAYSTATS_ENTER_SESSION_PACK` | `void PLAYSTATS_ENTER_SESSION_PACK(ref object data)` | void | - |
| `PLAYSTATS_EXTRA_EVENT` | `void PLAYSTATS_EXTRA_EVENT(object p0)` | void | - |
| `PLAYSTATS_FAST_TRVL` | `void PLAYSTATS_FAST_TRVL(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9, object p10)` | void | - |
| `PLAYSTATS_FM_EVENT_ATOB` | `void PLAYSTATS_FM_EVENT_ATOB(object p0)` | void | - |
| `PLAYSTATS_FM_EVENT_CHALLENGES` | `void PLAYSTATS_FM_EVENT_CHALLENGES(object p0)` | void | - |
| `PLAYSTATS_FM_EVENT_CHECKPOINTCOLLECTION` | `void PLAYSTATS_FM_EVENT_CHECKPOINTCOLLECTION(object p0)` | void | - |
| `PLAYSTATS_FM_EVENT_COMPETITIVEURBANWARFARE` | `void PLAYSTATS_FM_EVENT_COMPETITIVEURBANWARFARE(object p0)` | void | - |
| `PLAYSTATS_FM_EVENT_CRIMINALDAMAGE` | `void PLAYSTATS_FM_EVENT_CRIMINALDAMAGE(object p0)` | void | - |
| `PLAYSTATS_FM_EVENT_DEADDROP` | `void PLAYSTATS_FM_EVENT_DEADDROP(object p0)` | void | - |
| `PLAYSTATS_FM_EVENT_HOTPROPERTY` | `void PLAYSTATS_FM_EVENT_HOTPROPERTY(object p0)` | void | - |
| `PLAYSTATS_FM_EVENT_HUNTBEAST` | `void PLAYSTATS_FM_EVENT_HUNTBEAST(object p0)` | void | - |
| `PLAYSTATS_FM_EVENT_KINGOFTHECASTLE` | `void PLAYSTATS_FM_EVENT_KINGOFTHECASTLE(object p0)` | void | - |
| `PLAYSTATS_FM_EVENT_PASSTHEPARCEL` | `void PLAYSTATS_FM_EVENT_PASSTHEPARCEL(object p0)` | void | - |
| `PLAYSTATS_FM_EVENT_PENNEDIN` | `void PLAYSTATS_FM_EVENT_PENNEDIN(object p0)` | void | - |
| `PLAYSTATS_FM_EVENT_URBANWARFARE` | `void PLAYSTATS_FM_EVENT_URBANWARFARE(object p0)` | void | - |
| `PLAYSTATS_FM_EVENT_VEHICLETARGET` | `void PLAYSTATS_FM_EVENT_VEHICLETARGET(object p0)` | void | - |
| `PLAYSTATS_FM_HEIST_PREP_ENDED` | `void PLAYSTATS_FM_HEIST_PREP_ENDED(ref object data)` | void | - |
| `PLAYSTATS_FM_MISSION_END` | `void PLAYSTATS_FM_MISSION_END(object p0, object p1, object p2, object p3)` | void | - |
| `PLAYSTATS_FREEMODE_CASINO_MISSION_ENDED` | `void PLAYSTATS_FREEMODE_CASINO_MISSION_ENDED(ref object data)` | void | - |
| `PLAYSTATS_FRIEND_ACTIVITY` | `void PLAYSTATS_FRIEND_ACTIVITY(int p0, bool p1)` | void | - |
| `PLAYSTATS_GUNRUNNING_MISSION_ENDED` | `void PLAYSTATS_GUNRUNNING_MISSION_ENDED(ref object data)` | void | - |
| `PLAYSTATS_GUNRUNNING_RND` | `void PLAYSTATS_GUNRUNNING_RND(object p0)` | void | - |
| `PLAYSTATS_HEIST3_DRONE` | `void PLAYSTATS_HEIST3_DRONE(object p0)` | void | - |
| `PLAYSTATS_HEIST3_FINALE` | `void PLAYSTATS_HEIST3_FINALE(object p0)` | void | - |
| `PLAYSTATS_HEIST3_HACK` | `void PLAYSTATS_HEIST3_HACK(object p0, object p1, object p2, object p3, object p4, object p5)` | void | - |
| `PLAYSTATS_HEIST3_PREP` | `void PLAYSTATS_HEIST3_PREP(object p0)` | void | - |
| `PLAYSTATS_HEIST4_FINALE` | `void PLAYSTATS_HEIST4_FINALE(object p0)` | void | - |
| `PLAYSTATS_HEIST4_HACK` | `void PLAYSTATS_HEIST4_HACK(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `PLAYSTATS_HEIST4_PREP` | `void PLAYSTATS_HEIST4_PREP(object p0)` | void | - |
| `PLAYSTATS_HEIST_SAVE_CHEAT` | `void PLAYSTATS_HEIST_SAVE_CHEAT(uint hash, int p1)` | void | - |
| `PLAYSTATS_HIT_CONTRABAND_DESTROY_LIMIT` | `void PLAYSTATS_HIT_CONTRABAND_DESTROY_LIMIT(object p0)` | void | - |
| `PLAYSTATS_HOLD_UP_MISSION_DONE` | `void PLAYSTATS_HOLD_UP_MISSION_DONE(object p0, object p1, object p2, object p3)` | void | - |
| `PLAYSTATS_HUB_ENTRY` | `void PLAYSTATS_HUB_ENTRY(object p0)` | void | - |
| `PLAYSTATS_HUB_EXIT` | `void PLAYSTATS_HUB_EXIT(object p0)` | void | - |
| `PLAYSTATS_IDLE_KICK` | `void PLAYSTATS_IDLE_KICK(int msStoodIdle)` | void | - |
| `PLAYSTATS_IMPEXP_MISSION_ENDED` | `void PLAYSTATS_IMPEXP_MISSION_ENDED(object p0)` | void | - |
| `PLAYSTATS_IMPORT_EXPORT_MISSION_DONE` | `void PLAYSTATS_IMPORT_EXPORT_MISSION_DONE(object p0, object p1, object p2, object p3)` | void | - |
| `PLAYSTATS_INSTANCED_HEIST_ENDED` | `void PLAYSTATS_INSTANCED_HEIST_ENDED(ref object data, object p1, object p2, object p3)` | void | - |
| `PLAYSTATS_INST_MISSION_END` | `void PLAYSTATS_INST_MISSION_END(object p0)` | void | - |
| `PLAYSTATS_INVENTORY` | `void PLAYSTATS_INVENTORY(object p0)` | void | - |
| `PLAYSTATS_JOB_ACTIVITY_END` | `void PLAYSTATS_JOB_ACTIVITY_END(ref object p0, ref object p1, ref object p2, ref object p3)` | void | - |
| `PLAYSTATS_JOB_BEND` | `void PLAYSTATS_JOB_BEND(ref object p0, ref object p1, ref object p2, ref object p3)` | void | - |
| `PLAYSTATS_JOB_LTS_END` | `void PLAYSTATS_JOB_LTS_END(ref object p0, ref object p1, ref object p2, ref object p3)` | void | - |
| `PLAYSTATS_JOB_LTS_ROUND_END` | `void PLAYSTATS_JOB_LTS_ROUND_END(ref object p0, ref object p1, ref object p2, ref object p3)` | void | - |
| `PLAYSTATS_LEAVE_JOB_CHAIN` | `void PLAYSTATS_LEAVE_JOB_CHAIN(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `PLAYSTATS_MASTER_CONTROL` | `void PLAYSTATS_MASTER_CONTROL(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `PLAYSTATS_MATCH_STARTED` | `void PLAYSTATS_MATCH_STARTED(object p0, object p1, object p2)` | void | - |
| `PLAYSTATS_MC_CLUBHOUSE_ACTIVITY` | `void PLAYSTATS_MC_CLUBHOUSE_ACTIVITY(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7)` | void | - |
| `PLAYSTATS_MC_FORMATION_ENDS` | `void PLAYSTATS_MC_FORMATION_ENDS(object p0, object p1, object p2, object p3, object p4, object p5, object p6)` | void | - |
| `PLAYSTATS_MC_KILLED_RIVAL_MC_MEMBER` | `void PLAYSTATS_MC_KILLED_RIVAL_MC_MEMBER(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `PLAYSTATS_MC_REQUEST_BIKE` | `void PLAYSTATS_MC_REQUEST_BIKE(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `PLAYSTATS_MINIGAME_USAGE` | `void PLAYSTATS_MINIGAME_USAGE(object p0, object p1, object p2)` | void | - |
| `PLAYSTATS_MISSION_CHECKPOINT` | `void PLAYSTATS_MISSION_CHECKPOINT(string p0, object p1, object p2, object p3)` | void | - |
| `PLAYSTATS_MISSION_ENDED` | `void PLAYSTATS_MISSION_ENDED(object p0)` | void | - |
| `PLAYSTATS_MISSION_OVER` | `void PLAYSTATS_MISSION_OVER(string p0, object p1, object p2, bool p3, bool p4, bool p5)` | void | - |
| `PLAYSTATS_MISSION_STARTED` | `void PLAYSTATS_MISSION_STARTED(string p0, object p1, object p2, bool p3)` | void | - |
| `PLAYSTATS_MISSION_VOTE` | `void PLAYSTATS_MISSION_VOTE(object p0)` | void | - |
| `PLAYSTATS_NIGHTCLUB_MISSION_ENDED` | `void PLAYSTATS_NIGHTCLUB_MISSION_ENDED(object p0)` | void | - |
| `PLAYSTATS_NJVS_VOTE` | `void PLAYSTATS_NJVS_VOTE(object p0)` | void | - |
| `PLAYSTATS_NPC_INVITE` | `void PLAYSTATS_NPC_INVITE(string p0)` | void | - |
| `PLAYSTATS_NPC_PHONE` | `void PLAYSTATS_NPC_PHONE(ref object p0)` | void | - |
| `PLAYSTATS_ODDJOB_DONE` | `void PLAYSTATS_ODDJOB_DONE(int totalTimeMs, int p1, bool p2)` | void | This native does absolutely nothing, just a nullsub |
| `PLAYSTATS_PEGASUS_AS_PERSONAL_AIRCRAFT` | `void PLAYSTATS_PEGASUS_AS_PERSONAL_AIRCRAFT(uint modelHash)` | void | - |
| `PLAYSTATS_PIMENU_HIDE_OPTIONS` | `void PLAYSTATS_PIMENU_HIDE_OPTIONS(ref object data)` | void | - |
| `PLAYSTATS_PROP_CHANGE` | `void PLAYSTATS_PROP_CHANGE(int p0, int p1, int p2, int p3)` | void | - |
| `PLAYSTATS_QUICKFIX_TOOL` | `void PLAYSTATS_QUICKFIX_TOOL(int element, string item)` | void | - |
| `PLAYSTATS_QUIT_MODE` | `void PLAYSTATS_QUIT_MODE(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `PLAYSTATS_RACE_CHECKPOINT` | `void PLAYSTATS_RACE_CHECKPOINT(int p0, object p1, int p2, int p3, object p4)` | void | - |
| `PLAYSTATS_RACE_TO_POINT_MISSION_DONE` | `void PLAYSTATS_RACE_TO_POINT_MISSION_DONE(int p0, object p1, object p2, object p3)` | void | - |
| `PLAYSTATS_RANDOM_MISSION_DONE` | `void PLAYSTATS_RANDOM_MISSION_DONE(string name, object p1, object p2, object p3)` | void | - |
| `PLAYSTATS_RANK_UP` | `void PLAYSTATS_RANK_UP(int rank)` | void | - |
| `PLAYSTATS_RECOVER_CONTRABAND_MISSION` | `void PLAYSTATS_RECOVER_CONTRABAND_MISSION(ref object data)` | void | - |
| `PLAYSTATS_RIVAL_BEHAVIOR` | `void PLAYSTATS_RIVAL_BEHAVIOR(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9)` | void | - |
| `PLAYSTATS_ROBBERY_FINALE` | `void PLAYSTATS_ROBBERY_FINALE(object p0)` | void | - |
| `PLAYSTATS_ROBBERY_PREP` | `void PLAYSTATS_ROBBERY_PREP(object p0)` | void | - |
| `PLAYSTATS_ROS_BET` | `void PLAYSTATS_ROS_BET(int amount, int act, int player, float cm)` | void | - |
| `PLAYSTATS_SELL_CONTRABAND_MISSION` | `void PLAYSTATS_SELL_CONTRABAND_MISSION(ref object data)` | void | - |
| `PLAYSTATS_SET_JOIN_TYPE` | `void PLAYSTATS_SET_JOIN_TYPE(int joinType)` | void | - |
| `PLAYSTATS_SHOP_ITEM` | `void PLAYSTATS_SHOP_ITEM(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `PLAYSTATS_SMUGGLER_MISSION_ENDED` | `void PLAYSTATS_SMUGGLER_MISSION_ENDED(ref object data)` | void | - |
| `PLAYSTATS_SPENT_PI_CUSTOM_LOADOUT` | `void PLAYSTATS_SPENT_PI_CUSTOM_LOADOUT(int amount)` | void | - |
| `PLAYSTATS_SPIN_WHEEL` | `void PLAYSTATS_SPIN_WHEEL(int p0, int p1, int p2, int p3)` | void | - |
| `PLAYSTATS_STARTED_SESSION_IN_OFFLINEMODE` | `void PLAYSTATS_STARTED_SESSION_IN_OFFLINEMODE()` | void | - |
| `PLAYSTATS_START_TRACKING_STUNTS` | `void PLAYSTATS_START_TRACKING_STUNTS()` | void | Allows CEventNetworkStuntPerformed to be triggered. |
| `PLAYSTATS_STONE_HATCHET_ENDED` | `void PLAYSTATS_STONE_HATCHET_ENDED(ref object data)` | void | - |
| `PLAYSTATS_STOP_TRACKING_STUNTS` | `void PLAYSTATS_STOP_TRACKING_STUNTS()` | void | Disallows CEventNetworkStuntPerformed to be triggered. |
| `PLAYSTATS_SUB_WEAP` | `void PLAYSTATS_SUB_WEAP(object p0, object p1, object p2, object p3)` | void | - |
| `PLAYSTATS_SWITCH_MC_EMBLEM` | `void PLAYSTATS_SWITCH_MC_EMBLEM(object p0, object p1, object p2, object p3, object p4)` | void | - |
| `PLAYSTATS_SWITCH_PASSIVE_MODE` | `void PLAYSTATS_SWITCH_PASSIVE_MODE(bool p0, int p1, int p2, int p3)` | void | - |
| `PLAYSTATS_VEH_DEL` | `void PLAYSTATS_VEH_DEL(int bossId1, int bossId2, int bossType, int vehicleID, int reason)` | void | - |
| `PLAYSTATS_WAREHOUSE_MISSION_ENDED` | `void PLAYSTATS_WAREHOUSE_MISSION_ENDED(object p0)` | void | - |
| `PLAYSTATS_WEAPON_MODE_CHANGE` | `void PLAYSTATS_WEAPON_MODE_CHANGE(uint weaponHash, uint componentHashTo, uint componentHashFrom)` | void | This is a typo made by R*. It's supposed to be called PLAYSTATS_WEAPON_MOD_CHANGE. |
| `PLAYSTATS_WEBSITE_VISITED` | `void PLAYSTATS_WEBSITE_VISITED(uint scaleformHash, int p1)` | void | - |
| `PRESENCE_EVENT_UPDATESTAT_FLOAT` | `void PRESENCE_EVENT_UPDATESTAT_FLOAT(uint statHash, float value, int p2)` | void | - |
| `PRESENCE_EVENT_UPDATESTAT_INT` | `void PRESENCE_EVENT_UPDATESTAT_INT(uint statHash, int value, int p2)` | void | - |
| `PRESENCE_EVENT_UPDATESTAT_INT_WITH_STRING` | `void PRESENCE_EVENT_UPDATESTAT_INT_WITH_STRING(uint statHash, int value, int p2, string string)` | void | - |
| `PROCESS_CASH_GIFT` | `string PROCESS_CASH_GIFT(ref int p0, ref int p1, string p2)` | string | This isn't a hash collision. |
| `SEND_METRIC_GHOSTING_TO_PLAYER` | `void SEND_METRIC_GHOSTING_TO_PLAYER(object p0)` | void | - |
| `SEND_METRIC_PUNISH_BODYGUARD` | `void SEND_METRIC_PUNISH_BODYGUARD(object p0)` | void | - |
| `SEND_METRIC_VIP_POACH` | `void SEND_METRIC_VIP_POACH(object p0, object p1, object p2)` | void | - |
| `SET_FREEMODE_PROLOGUE_DONE` | `void SET_FREEMODE_PROLOGUE_DONE(object p0, int characterSlot)` | void | - |
| `SET_FREEMODE_STRAND_PROGRESSION_STATUS` | `void SET_FREEMODE_STRAND_PROGRESSION_STATUS(int profileSetting, int settingValue)` | void | Sets profile setting 940 and 941 |
| `SET_HAS_POSTED_ALL_VEHICLES_DRIVEN` | `void SET_HAS_POSTED_ALL_VEHICLES_DRIVEN()` | void | - |
| `SET_HAS_SPECIALEDITION_CONTENT` | `void SET_HAS_SPECIALEDITION_CONTENT(int value)` | void | Sets profile setting 866 |
| `SET_JOB_ACTIVITY_ID_STARTED` | `void SET_JOB_ACTIVITY_ID_STARTED(object p0, int characterSlot)` | void | - |
| `SET_PACKED_STAT_BOOL_CODE` | `void SET_PACKED_STAT_BOOL_CODE(int index, bool value, int characterSlot)` | void | - |
| `SET_PACKED_STAT_INT_CODE` | `void SET_PACKED_STAT_INT_CODE(int index, int value, int characterSlot)` | void | - |
| `SET_PROFILE_SETTING_CREATOR_CTF_DONE` | `void SET_PROFILE_SETTING_CREATOR_CTF_DONE(int value)` | void | Sets profile setting 935 |
| `SET_PROFILE_SETTING_CREATOR_DM_DONE` | `void SET_PROFILE_SETTING_CREATOR_DM_DONE(int value)` | void | Sets profile setting 934 |
| `SET_PROFILE_SETTING_CREATOR_RACES_DONE` | `void SET_PROFILE_SETTING_CREATOR_RACES_DONE(int value)` | void | Sets profile setting 933 |
| `SET_PROFILE_SETTING_PROLOGUE_COMPLETE` | `void SET_PROFILE_SETTING_PROLOGUE_COMPLETE()` | void | - |
| `SET_PROFILE_SETTING_SP_CHOP_MISSION_COMPLETE` | `void SET_PROFILE_SETTING_SP_CHOP_MISSION_COMPLETE()` | void | Sets profile setting 939 |
| `SET_SAVE_MIGRATION_TRANSACTION_ID_WARNING` | `void SET_SAVE_MIGRATION_TRANSACTION_ID_WARNING(int transactionId)` | void | Sets profile setting 501 |
| `START_BEING_BOSS` | `void START_BEING_BOSS(object p0, object p1, object p2)` | void | - |
| `START_BEING_GOON` | `void START_BEING_GOON(object p0, object p1, object p2)` | void | - |
| `STATS_COMPLETED_CHARACTER_CREATION` | `void STATS_COMPLETED_CHARACTER_CREATION(object p0)` | void | This native does absolutely nothing, just a nullsub |
| `STAT_CLEAR_DIRTY_READ_DETECTED` | `void STAT_CLEAR_DIRTY_READ_DETECTED()` | void | - |
| `STAT_CLEAR_PENDING_SAVES` | `void STAT_CLEAR_PENDING_SAVES(object p0)` | void | - |
| `STAT_CLEAR_SLOT_FOR_RELOAD` | `bool STAT_CLEAR_SLOT_FOR_RELOAD(int statSlot)` | bool | Example:<br><br>for (v_2 = 0; v_2 <= 4; v_2 += 1) {<br>    STATS::STAT_CLEAR_SLOT_FOR_RELOAD(v_2);<br>} |
| `STAT_CLOUD_SLOT_LOAD_FAILED` | `bool STAT_CLOUD_SLOT_LOAD_FAILED(int p0)` | bool | - |
| `STAT_CLOUD_SLOT_LOAD_FAILED_CODE` | `int STAT_CLOUD_SLOT_LOAD_FAILED_CODE(object p0)` | int | - |
| `STAT_CLOUD_SLOT_SAVE_FAILED` | `bool STAT_CLOUD_SLOT_SAVE_FAILED(object p0)` | bool | - |
| `STAT_COMMUNITY_GET_HISTORY` | `bool STAT_COMMUNITY_GET_HISTORY(uint statName, int p1, ref float outValue)` | bool | - |
| `STAT_COMMUNITY_START_SYNCH` | `bool STAT_COMMUNITY_START_SYNCH()` | bool | - |
| `STAT_COMMUNITY_SYNCH_IS_PENDING` | `bool STAT_COMMUNITY_SYNCH_IS_PENDING()` | bool | - |
| `STAT_DELETE_SLOT` | `bool STAT_DELETE_SLOT(int p0)` | bool | p0 is characterSlot? seems range from 0 to 2 |
| `STAT_DISABLE_STATS_TRACKING` | `void STAT_DISABLE_STATS_TRACKING()` | void | Prevents updates to CStatsMgr (e.g., STAT_SET_* natives) |
| `STAT_ENABLE_STATS_TRACKING` | `void STAT_ENABLE_STATS_TRACKING()` | void | - |
| `STAT_GET_BLOCK_SAVES` | `bool STAT_GET_BLOCK_SAVES()` | bool | - |
| `STAT_GET_BOOL` | `bool STAT_GET_BOOL(uint statHash, ref bool outValue, object p2)` | bool | - |
| `STAT_GET_CANCEL_SAVE_MIGRATION_STATUS` | `int STAT_GET_CANCEL_SAVE_MIGRATION_STATUS()` | int | - |
| `STAT_GET_CHALLENGE_FLYING_DIST` | `float STAT_GET_CHALLENGE_FLYING_DIST()` | float | Fly low to the ground for the longest distance |
| `STAT_GET_CURRENT_DRIVE_NOCRASH_DISTANCE` | `float STAT_GET_CURRENT_DRIVE_NOCRASH_DISTANCE()` | float | Drive the furthest distance in a land vehicle without crashing |
| `STAT_GET_CURRENT_DRIVING_REVERSE_DISTANCE` | `float STAT_GET_CURRENT_DRIVING_REVERSE_DISTANCE()` | float | Reverse the longest distance without crashing |
| `STAT_GET_CURRENT_FRONT_WHEEL_DISTANCE` | `float STAT_GET_CURRENT_FRONT_WHEEL_DISTANCE()` | float | Perform the longest stoppie on a motorcycle |
| `STAT_GET_CURRENT_JUMP_DISTANCE` | `float STAT_GET_CURRENT_JUMP_DISTANCE()` | float | Perform the longest jump in a land vehicle |
| `STAT_GET_CURRENT_NEAR_MISS_NOCRASH_PRECISE` | `int STAT_GET_CURRENT_NEAR_MISS_NOCRASH_PRECISE()` | int | Perform the most near misses with other vehicles in a land vehicle without crashing |
| `STAT_GET_CURRENT_REAR_WHEEL_DISTANCE` | `float STAT_GET_CURRENT_REAR_WHEEL_DISTANCE()` | float | Perform the longest wheelie on a motorcycle |
| `STAT_GET_CURRENT_SKYDIVING_DISTANCE` | `float STAT_GET_CURRENT_SKYDIVING_DISTANCE()` | float | Fall the longest distance with a parachute before opening it |
| `STAT_GET_CURRENT_SPEED` | `float STAT_GET_CURRENT_SPEED()` | float | Achieve the highest speed in a land vehicle |
| `STAT_GET_DATE` | `bool STAT_GET_DATE(uint statHash, ref object outValue, int numFields, object p3)` | bool | p3 is probably characterSlot or BOOL save, always -1 |
| `STAT_GET_FLOAT` | `bool STAT_GET_FLOAT(uint statHash, ref float outValue, object p2)` | bool | - |
| `STAT_GET_FLYING_ALTITUDE` | `bool STAT_GET_FLYING_ALTITUDE(ref float outValue)` | bool | - |
| `STAT_GET_INT` | `bool STAT_GET_INT(uint statHash, ref int outValue, int p2)` | bool | p2 appears to always be -1<br> |
| `STAT_GET_LICENSE_PLATE` | `string STAT_GET_LICENSE_PLATE(uint statName)` | string | - |
| `STAT_GET_LOAD_SAFE_TO_PROGRESS_TO_MP_FROM_SP` | `bool STAT_GET_LOAD_SAFE_TO_PROGRESS_TO_MP_FROM_SP()` | bool | - |
| `STAT_GET_MASKED_INT` | `bool STAT_GET_MASKED_INT(uint statHash, ref int outValue, int p2, int p3, object p4)` | bool | p4 is probably characterSlot or BOOL save |
| `STAT_GET_NUMBER_OF_DAYS` | `int STAT_GET_NUMBER_OF_DAYS(uint statName)` | int | - |
| `STAT_GET_NUMBER_OF_HOURS` | `int STAT_GET_NUMBER_OF_HOURS(uint statName)` | int | - |
| `STAT_GET_NUMBER_OF_MINUTES` | `int STAT_GET_NUMBER_OF_MINUTES(uint statName)` | int | - |
| `STAT_GET_NUMBER_OF_SECONDS` | `int STAT_GET_NUMBER_OF_SECONDS(uint statName)` | int | - |
| `STAT_GET_POS` | `bool STAT_GET_POS(uint statName, ref float outX, ref float outY, ref float outZ, object p4)` | bool | p3 is probably characterSlot or BOOL save, always -1 |
| `STAT_GET_RECORDED_VALUE` | `bool STAT_GET_RECORDED_VALUE(ref float value)` | bool | - |
| `STAT_GET_SAVE_MIGRATION_CONSUME_CONTENT_STATUS` | `int STAT_GET_SAVE_MIGRATION_CONSUME_CONTENT_STATUS(ref int p0)` | int | - |
| `STAT_GET_SAVE_MIGRATION_STATUS` | `int STAT_GET_SAVE_MIGRATION_STATUS(ref object data)` | int | - |
| `STAT_GET_STRING` | `string STAT_GET_STRING(uint statHash, int p1)` | string | p1 is always -1 in the script files |
| `STAT_GET_USER_ID` | `string STAT_GET_USER_ID(uint statHash)` | string | Returns the rockstar ID (user id) value of a given stat. Returns "STAT_UNKNOWN" if the statHash is i... |
| `STAT_GET_VEHICLE_BAIL_DISTANCE` | `float STAT_GET_VEHICLE_BAIL_DISTANCE()` | float | Travel the furthest distance when bailing from a vehicle |
| `STAT_INCREMENT` | `void STAT_INCREMENT(uint statName, float value)` | void | - |
| `STAT_IS_PLAYER_VEHICLE_ABOVE_OCEAN` | `bool STAT_IS_PLAYER_VEHICLE_ABOVE_OCEAN()` | bool | Or non-flyable area |
| `STAT_IS_RECORDING_STAT` | `bool STAT_IS_RECORDING_STAT()` | bool | - |
| `STAT_IS_STATS_TRACKING_ENABLED` | `bool STAT_IS_STATS_TRACKING_ENABLED()` | bool | - |
| `STAT_LOAD` | `bool STAT_LOAD(int statSlot)` | bool | - |
| `STAT_LOAD_DIRTY_READ_DETECTED` | `bool STAT_LOAD_DIRTY_READ_DETECTED()` | bool | - |
| `STAT_LOAD_PENDING` | `bool STAT_LOAD_PENDING(int statSlot)` | bool | - |
| `STAT_LOCAL_RESET_ALL_ONLINE_CHARACTER_STATS` | `void STAT_LOCAL_RESET_ALL_ONLINE_CHARACTER_STATS(int p0)` | void | p0 seems to range from 0 to 7 |
| `STAT_MIGRATE_CHECK_ALREADY_DONE` | `bool STAT_MIGRATE_CHECK_ALREADY_DONE()` | bool | - |
| `STAT_MIGRATE_CHECK_GET_IS_PLATFORM_AVAILABLE` | `int STAT_MIGRATE_CHECK_GET_IS_PLATFORM_AVAILABLE(int p0)` | int | - |
| `STAT_MIGRATE_CHECK_GET_PLATFORM_STATUS` | `int STAT_MIGRATE_CHECK_GET_PLATFORM_STATUS(int p0, ref object p1)` | int | - |
| `STAT_MIGRATE_CHECK_START` | `bool STAT_MIGRATE_CHECK_START()` | bool | - |
| `STAT_MIGRATE_CLEAR_FOR_RESTART` | `void STAT_MIGRATE_CLEAR_FOR_RESTART()` | void | - |
| `STAT_MIGRATE_SAVEGAME_GET_STATUS` | `int STAT_MIGRATE_SAVEGAME_GET_STATUS()` | int | - |
| `STAT_MIGRATE_SAVEGAME_START` | `bool STAT_MIGRATE_SAVEGAME_START(string platformName)` | bool | platformName must be one of the following: ps3, xbox360, ps4, xboxone |
| `STAT_NETWORK_INCREMENT_ON_SUICIDE` | `void STAT_NETWORK_INCREMENT_ON_SUICIDE(object p0, float p1)` | void | - |
| `STAT_RESET_ALL_ONLINE_CHARACTER_STATS` | `void STAT_RESET_ALL_ONLINE_CHARACTER_STATS(int p0)` | void | p0 seems to range from 0 to 7 |
| `STAT_ROLLBACK_SAVE_MIGRATION` | `bool STAT_ROLLBACK_SAVE_MIGRATION()` | bool | This function is hard-coded to always return 1. |
| `STAT_SAVE` | `bool STAT_SAVE(int p0, bool p1, int p2, bool p3)` | bool | - |
| `STAT_SAVE_MIGRATION_CANCEL_PENDING_OPERATION` | `bool STAT_SAVE_MIGRATION_CANCEL_PENDING_OPERATION()` | bool | - |
| `STAT_SAVE_MIGRATION_CONSUME_CONTENT` | `bool STAT_SAVE_MIGRATION_CONSUME_CONTENT(uint contentId, string srcPlatform, string srcGamerHandle)` | bool | - |
| `STAT_SAVE_PENDING` | `bool STAT_SAVE_PENDING()` | bool | - |
| `STAT_SAVE_PENDING_OR_REQUESTED` | `bool STAT_SAVE_PENDING_OR_REQUESTED()` | bool | - |
| `STAT_SET_BLOCK_SAVES` | `void STAT_SET_BLOCK_SAVES(bool toggle)` | void | - |
| `STAT_SET_BOOL` | `bool STAT_SET_BOOL(uint statName, bool value, bool save)` | bool | Example:<br> STATS::STAT_SET_BOOL(MISC::GET_HASH_KEY("MPPLY_MELEECHLENGECOMPLETED"), trur, true); |
| `STAT_SET_CHEAT_IS_ACTIVE` | `void STAT_SET_CHEAT_IS_ACTIVE()` | void | - |
| `STAT_SET_CURRENT_POSIX_TIME` | `bool STAT_SET_CURRENT_POSIX_TIME(uint statName, bool p1)` | bool | p1 always true. |
| `STAT_SET_DATE` | `bool STAT_SET_DATE(uint statName, ref object value, int numFields, bool save)` | bool | 'value' is a structure to a structure, 'numFields' is how many fields there are in said structure (u... |
| `STAT_SET_FLOAT` | `bool STAT_SET_FLOAT(uint statName, float value, bool save)` | bool | Example:<br> STATS::STAT_SET_FLOAT(MISC::GET_HASH_KEY("MP0_WEAPON_ACCURACY"), 66.6f, true); |
| `STAT_SET_GXT_LABEL` | `bool STAT_SET_GXT_LABEL(uint statName, string value, bool save)` | bool | The following values have been found in the decompiled scripts:<br>"RC_ABI1"<br>"RC_ABI2"<br>"RC_BA1"<br>"RC_BA2... |
| `STAT_SET_INT` | `bool STAT_SET_INT(uint statName, int value, bool save)` | bool | Example:<br> STATS::STAT_SET_INT(MISC::GET_HASH_KEY("MPPLY_KILLS_PLAYERS"), 1337, true); |
| `STAT_SET_LICENSE_PLATE` | `bool STAT_SET_LICENSE_PLATE(uint statName, string str)` | bool | - |
| `STAT_SET_MASKED_INT` | `bool STAT_SET_MASKED_INT(uint statName, int p1, int p2, int p3, bool save)` | bool | - |
| `STAT_SET_OPEN_SAVETYPE_IN_JOB` | `void STAT_SET_OPEN_SAVETYPE_IN_JOB(int p0)` | void | - |
| `STAT_SET_POS` | `bool STAT_SET_POS(uint statName, float x, float y, float z, bool save)` | bool | - |
| `STAT_SET_PROFILE_SETTING_VALUE` | `void STAT_SET_PROFILE_SETTING_VALUE(int profileSetting, int value)` | void | Does not take effect immediately, unfortunately.<br><br>profileSetting seems to only be 936, 937 and 938 i... |
| `STAT_SET_STRING` | `bool STAT_SET_STRING(uint statName, string value, bool save)` | bool | - |
| `STAT_SET_USER_ID` | `bool STAT_SET_USER_ID(uint statName, string value, bool save)` | bool | - |
| `STAT_SLOT_IS_LOADED` | `bool STAT_SLOT_IS_LOADED(int statSlot)` | bool | - |
| `STAT_START_RECORD_STAT` | `bool STAT_START_RECORD_STAT(int statType, int valueType)` | bool | enum StatTrackingType<br>{<br>	LongestWheelie = 1,<br>	LongestStoppie = 2,<br>	NoCrashes = 3,<br>	HighestSpeed = 4,... |
| `STAT_STOP_RECORD_STAT` | `bool STAT_STOP_RECORD_STAT()` | bool | - |
| `WAS_VC_WITHDRAWAL_SUCCESSFUL` | `bool WAS_VC_WITHDRAWAL_SUCCESSFUL(object p0)` | bool | This function is hard-coded to always return 1. |
| `WITHDRAW_VC` | `int WITHDRAW_VC(int amount)` | int | Does nothing and always returns 0. |
| `_GET_STAT_HASH_FOR_CHARACTER_STAT` | `uint _GET_STAT_HASH_FOR_CHARACTER_STAT(int dataType, int statIndex, int charSlot)` | uint | Returns stat hash based on dataType, statIndex/statId and characterSlot. Related to CStatsMpCharacte... |
| `_NETWORK_CLEAR_TRANSACTION_TELEMETRY_NONCE` | `void _NETWORK_CLEAR_TRANSACTION_TELEMETRY_NONCE()` | void | - |
| `_NETWORK_EARN_AVENGER` | `void _NETWORK_EARN_AVENGER(int amount, int p1)` | void | Used for SERVICE_EARN_AVENGER_OPERATIONS & SERVICE_EARN_AVENGER_OPS_BONUS |
| `_NETWORK_EARN_AWARD_ACID_LAB` | `void _NETWORK_EARN_AWARD_ACID_LAB(object p0, object p1)` | void | - |
| `_NETWORK_EARN_AWARD_DAILY_STASH` | `void _NETWORK_EARN_AWARD_DAILY_STASH(object p0, object p1)` | void | - |
| `_NETWORK_EARN_AWARD_DEAD_DROP` | `void _NETWORK_EARN_AWARD_DEAD_DROP(object p0, object p1)` | void | - |
| `_NETWORK_EARN_AWARD_JUGGALO_MISSION` | `void _NETWORK_EARN_AWARD_JUGGALO_MISSION(object p0, object p1)` | void | - |
| `_NETWORK_EARN_AWARD_RANDOM_EVENT` | `void _NETWORK_EARN_AWARD_RANDOM_EVENT(object p0, object p1)` | void | - |
| `_NETWORK_EARN_AWARD_TAXI` | `void _NETWORK_EARN_AWARD_TAXI(object p0, object p1)` | void | - |
| `_NETWORK_EARN_BONUS_OBJECTIVE` | `void _NETWORK_EARN_BONUS_OBJECTIVE(int amount, object p1, object p2)` | void | - |
| `_NETWORK_EARN_DAILY_STASH_HOUSE_COMPLETED` | `void _NETWORK_EARN_DAILY_STASH_HOUSE_COMPLETED(object p0, object p1)` | void | - |
| `_NETWORK_EARN_DAILY_STASH_HOUSE_PARTICIPATION` | `void _NETWORK_EARN_DAILY_STASH_HOUSE_PARTICIPATION(object p0, object p1)` | void | - |
| `_NETWORK_EARN_FOOLIGAN_JOB` | `void _NETWORK_EARN_FOOLIGAN_JOB(object p0, object p1)` | void | JUGGALO_PHONE_MISSION... |
| `_NETWORK_EARN_FOOLIGAN_JOB_PARTICIPATION` | `void _NETWORK_EARN_FOOLIGAN_JOB_PARTICIPATION(object p0, object p1)` | void | JUGGALO_PHONE_MISSION_PARTICIPATION... |
| `_NETWORK_EARN_GENERIC` | `void _NETWORK_EARN_GENERIC(int amount, uint earn, string p2, string p3, ref object data)` | void | _NETWORK_EARN_G* |
| `_NETWORK_EARN_JUGGALO_STORY_MISSION` | `void _NETWORK_EARN_JUGGALO_STORY_MISSION(object p0, object p1)` | void | - |
| `_NETWORK_EARN_JUGGALO_STORY_MISSION_PARTICIPATION` | `void _NETWORK_EARN_JUGGALO_STORY_MISSION_PARTICIPATION(object p0, object p1)` | void | - |
| `_NETWORK_EARN_PROGRESS_HUB` | `void _NETWORK_EARN_PROGRESS_HUB(object p0, object p1)` | void | - |
| `_NETWORK_EARN_SELL_ACID` | `void _NETWORK_EARN_SELL_ACID(object p0, object p1)` | void | - |
| `_NETWORK_EARN_SELL_PARTICIPATION_ACID_LAB` | `void _NETWORK_EARN_SELL_PARTICIPATION_ACID_LAB(object p0, object p1)` | void | - |
| `_NETWORK_EARN_SETUP_PARTICIPATION_ACID_LAB` | `void _NETWORK_EARN_SETUP_PARTICIPATION_ACID_LAB(object p0, object p1)` | void | - |
| `_NETWORK_EARN_SMUGGLER_OPS` | `void _NETWORK_EARN_SMUGGLER_OPS(object p0, object p1, object p2)` | void | - |
| `_NETWORK_EARN_SOURCE_PARTICIPATION_ACID_LAB` | `void _NETWORK_EARN_SOURCE_PARTICIPATION_ACID_LAB(object p0, object p1)` | void | - |
| `_NETWORK_EARN_STREET_DEALER` | `void _NETWORK_EARN_STREET_DEALER(object p0, object p1)` | void | - |
| `_NETWORK_EARN_TAXI_JOB` | `void _NETWORK_EARN_TAXI_JOB(object p0, object p1)` | void | - |
| `_NETWORK_SPEND_BUY_ACID_LAB` | `void _NETWORK_SPEND_BUY_ACID_LAB(object p0, object p1, object p2, object p3)` | void | - |
| `_NETWORK_SPEND_BUY_MFGARAGE` | `void _NETWORK_SPEND_BUY_MFGARAGE(object p0, object p1, object p2, object p3)` | void | - |
| `_NETWORK_SPEND_BUY_SUPPLIES` | `void _NETWORK_SPEND_BUY_SUPPLIES(int p0, bool p1, bool p2, int p3)` | void | - |
| `_NETWORK_SPEND_RENAME_ACID_LAB` | `void _NETWORK_SPEND_RENAME_ACID_LAB(object p0, object p1, object p2, object p3)` | void | - |
| `_NETWORK_SPEND_RENAME_ACID_PRODUCT` | `void _NETWORK_SPEND_RENAME_ACID_PRODUCT(object p0, object p1, object p2, object p3)` | void | - |
| `_NETWORK_SPEND_UPGRADE_ACID_LAB_ARMOR` | `void _NETWORK_SPEND_UPGRADE_ACID_LAB_ARMOR(int p0, bool p1, bool p2, int p3)` | void | - |
| `_NETWORK_SPEND_UPGRADE_ACID_LAB_EQUIPMENT` | `void _NETWORK_SPEND_UPGRADE_ACID_LAB_EQUIPMENT(object p0, object p1, object p2, object p3)` | void | - |
| `_NETWORK_SPEND_UPGRADE_ACID_LAB_MINES` | `void _NETWORK_SPEND_UPGRADE_ACID_LAB_MINES(int p0, bool p1, bool p2, int p3)` | void | - |
| `_NETWORK_SPEND_UPGRADE_ACID_LAB_SCOOP` | `void _NETWORK_SPEND_UPGRADE_ACID_LAB_SCOOP(int p0, bool p1, bool p2, int p3)` | void | - |
| `_NETWORK_SPEND_UPGRADE_MFGARAGE` | `void _NETWORK_SPEND_UPGRADE_MFGARAGE(object p0, object p1, object p2, object p3)` | void | - |
| `_NETWORK_SPENT_AIR_FREIGHT` | `void _NETWORK_SPENT_AIR_FREIGHT(int hangarCargoSourcingPrice, bool fromBank, bool fromBankAndWallet, int cost, int warehouseId, int warehouseSlot, object p6)` | void | - |
| `_NETWORK_SPENT_GENERIC` | `void _NETWORK_SPENT_GENERIC(int price, bool p1, bool p2, uint stat, uint spent, string p5, string p6, ref object data)` | void | - |
| `_NETWORK_SPENT_MISSILE_JAMMER` | `void _NETWORK_SPENT_MISSILE_JAMMER(int amount, bool fromBank, bool fromBankAndWallet, uint p3)` | void | Hash p3 = MISSILE_JAMMER |
| `_NETWORK_SPENT_SKIP_CARGO_SOURCE_SETUP` | `void _NETWORK_SPENT_SKIP_CARGO_SOURCE_SETUP(int amount, bool fromBank, bool fromBankAndWallet, int cost)` | void | - |
| `_NETWORK_SPENT_STEALTH_MODULE` | `void _NETWORK_SPENT_STEALTH_MODULE(int amount, bool fromBank, bool fromBankAndWallet, uint p3)` | void | Hash p3 = STEALTH_MODULE |
| `_PLAYSTATS_ACID_MISSION_END` | `void _PLAYSTATS_ACID_MISSION_END(object p0)` | void | - |
| `_PLAYSTATS_ACID_RND` | `void _PLAYSTATS_ACID_RND(object p0)` | void | - |
| `_PLAYSTATS_ALERT` | `void _PLAYSTATS_ALERT(ref object data)` | void | - |
| `_PLAYSTATS_ATTRITION_STAGE_END` | `void _PLAYSTATS_ATTRITION_STAGE_END(object p0)` | void | - |
| `_PLAYSTATS_CREATOR_END` | `void _PLAYSTATS_CREATOR_END(ref object p0)` | void | - |
| `_PLAYSTATS_DEATH_INFO` | `void _PLAYSTATS_DEATH_INFO(int victimPed, int killerPed, int mentalState, bool revengeKill, int victimKvK, int killerKvK)` | void | - |
| `_PLAYSTATS_FLOW_HIGH` | `void _PLAYSTATS_FLOW_HIGH(float posX, float posY, float posZ, string action, bool p4, int p5)` | void | - |
| `_PLAYSTATS_FLOW_LOW` | `void _PLAYSTATS_FLOW_LOW(float posX, float posY, float posZ, string action, bool p4, int p5)` | void | - |
| `_PLAYSTATS_FLOW_MEDIUM` | `void _PLAYSTATS_FLOW_MEDIUM(float posX, float posY, float posZ, string action, bool p4, int p5)` | void | - |
| `_PLAYSTATS_IDLE` | `void _PLAYSTATS_IDLE(object p0, object p1, object p2)` | void | - |
| `_PLAYSTATS_INIT_MULTIPLAYER` | `void _PLAYSTATS_INIT_MULTIPLAYER(object p0, object p1, object p2)` | void | - |
| `_PLAYSTATS_LOBBY_EXIT` | `void _PLAYSTATS_LOBBY_EXIT(ref object p0)` | void | - |
| `_PLAYSTATS_LOBBY_STARTED` | `void _PLAYSTATS_LOBBY_STARTED(ref object p0)` | void | - |
| `_PLAYSTATS_NAMED_USER_CONTENT` | `void _PLAYSTATS_NAMED_USER_CONTENT(bool isBoss, int bossType, int bossId1, int bossId2, int textType, string textString, int textSource)` | void | Known text types: NAME_YACHT, NAME_ORG_OFFICE |
| `_PLAYSTATS_PIMENU_NAV` | `void _PLAYSTATS_PIMENU_NAV(ref object data)` | void | - |
| `_PLAYSTATS_PLAYER_STYLE` | `void _PLAYSTATS_PLAYER_STYLE(object p0)` | void | - |
| `_PLAYSTATS_RANDOM_EVENT` | `void _PLAYSTATS_RANDOM_EVENT(object p0)` | void | - |
| `_PLAYSTATS_RECOVER_VEHICLE` | `void _PLAYSTATS_RECOVER_VEHICLE(ref object data)` | void | - |
| `_PLAYSTATS_SCRIPT_EVENT_FPOM` | `void _PLAYSTATS_SCRIPT_EVENT_FPOM(ref object data)` | void | - |
| `_PLAYSTATS_SHOPMENU_NAV` | `void _PLAYSTATS_SHOPMENU_NAV(object p0, object p1, object p2, object p3)` | void | - |
| `_PLAYSTATS_SHOWROOM_NAV` | `void _PLAYSTATS_SHOWROOM_NAV(object p0, object p1, uint entity)` | void | - |
| `_PLAYSTATS_SHOWROOM_OVERVIEW` | `void _PLAYSTATS_SHOWROOM_OVERVIEW(ref object data)` | void | Data struct contains various tunables related to test drives at Simeons Showroom or Luxury Showcase. |

---

## 详细说明

### CAN_PAY_AMOUNT_TO_BOSS

- **命名空间:** `MONEY`
- **Hash:** `0x9777734DAD16992F`
- **Build:** `573`

**C# 签名:**
```csharp
bool CAN_PAY_AMOUNT_TO_BOSS(int p0, int p1, int amount, ref int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `amount` | `int` | `int` | - |
| `p3` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### CHANGE_GOON_LOOKING_FOR_WORK

- **命名空间:** `STATS`
- **Hash:** `0x44919CC079BB60BF`
- **Build:** `573`

**C# 签名:**
```csharp
void CHANGE_GOON_LOOKING_FOR_WORK(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### CHANGE_UNIFORM

- **命名空间:** `STATS`
- **Hash:** `0xD1C9B92BDD3F151D`
- **Build:** `573`

**C# 签名:**
```csharp
void CHANGE_UNIFORM(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### DEPOSIT_VC

- **命名空间:** `MONEY`
- **Hash:** `0xE260E0BB9CD995AC`
- **JHash:** `0x8F266745`
- **Build:** `323`

**C# 签名:**
```csharp
bool DEPOSIT_VC(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Does nothing and always returns false.
```

---

### END_BEING_BOSS

- **命名空间:** `STATS`
- **Hash:** `0xA3C53804BDB68ED2`
- **Build:** `573`

**C# 签名:**
```csharp
void END_BEING_BOSS(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### END_BEING_GOON

- **命名空间:** `STATS`
- **Hash:** `0x6BCCF9948492FD85`
- **Build:** `573`

**C# 签名:**
```csharp
void END_BEING_GOON(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### FORCE_CLOUD_MP_STATS_DOWNLOAD_AND_OVERWRITE_LOCAL_SAVE

- **命名空间:** `STATS`
- **Hash:** `0x6F361B8889A792A3`
- **JHash:** `0x3B4EF322`
- **Build:** `323`

**C# 签名:**
```csharp
void FORCE_CLOUD_MP_STATS_DOWNLOAD_AND_OVERWRITE_LOCAL_SAVE()
```

**返回值:** `void` (Native: `void`)

---

### GET_BOSS_GOON_UUID

- **命名空间:** `STATS`
- **Hash:** `0x6BC0ACD0673ACEBE`
- **Build:** `573`

**C# 签名:**
```csharp
void GET_BOSS_GOON_UUID(int characterSlot, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `characterSlot` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### GET_PACKED_INT_STAT_KEY

- **命名空间:** `STATS`
- **Hash:** `0x61E111E323419E07`
- **JHash:** `0x1F938864`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_PACKED_INT_STAT_KEY(int index, bool spStat, bool charStat, int character)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |
| `spStat` | `BOOL` | `bool` | - |
| `charStat` | `BOOL` | `bool` | - |
| `character` | `int` | `int` | - |

**返回值:** `uint` (Native: `Hash`)

---

### GET_PACKED_NG_INT_STAT_KEY

- **命名空间:** `STATS`
- **Hash:** `0x2B4CDCA6F07FF3DA`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_PACKED_NG_INT_STAT_KEY(int index, bool spStat, bool charStat, int character, string section)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |
| `spStat` | `BOOL` | `bool` | - |
| `charStat` | `BOOL` | `bool` | - |
| `character` | `int` | `int` | - |
| `section` | `const char*` | `string` | - |

**返回值:** `uint` (Native: `Hash`)

**说明:**
```
Needs more research. Gets the stat name of a masked int?

section - values used in the decompiled scripts:
"_NGPSTAT_INT"
"_MP_NGPSTAT_INT"
"_MP_LRPSTAT_INT"
"_MP_APAPSTAT_INT"
"_MP_LR2PSTAT_INT"
"_MP_BIKEPSTAT_INT"
"_MP_IMPEXPPSTAT_INT"
"_MP_GUNRPSTAT_INT"
"_NGDLCPSTAT_INT"
"_MP_NGDLCPSTAT_INT"
"_DLCSMUGCHARPSTAT_INT"
"_GANGOPSPSTAT_INT"
"_BUSINESSBATPSTAT_INT"
"_ARENAWARSPSTAT_INT"
"_CASINOPSTAT_INT"
"_CASINOHSTPSTAT_INT"
```

---

### GET_PACKED_STAT_BOOL_CODE

- **命名空间:** `STATS`
- **Hash:** `0xDA7EBFC49AE3F1B0`
- **Build:** `2545`

**C# 签名:**
```csharp
bool GET_PACKED_STAT_BOOL_CODE(int index, int characterSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |
| `characterSlot` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### GET_PACKED_STAT_INT_CODE

- **命名空间:** `STATS`
- **Hash:** `0x0BC900A6FE73770C`
- **Build:** `2545`

**C# 签名:**
```csharp
int GET_PACKED_STAT_INT_CODE(int index, int characterSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |
| `characterSlot` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### GET_PACKED_TU_INT_STAT_KEY

- **命名空间:** `STATS`
- **Hash:** `0xD16C2AD6B8E32854`
- **JHash:** `0xFB93C5A2`
- **Build:** `323`

**C# 签名:**
```csharp
uint GET_PACKED_TU_INT_STAT_KEY(int index, bool spStat, bool charStat, int character)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |
| `spStat` | `BOOL` | `bool` | - |
| `charStat` | `BOOL` | `bool` | - |
| `character` | `int` | `int` | - |

**返回值:** `uint` (Native: `Hash`)

---

### GET_PLAYER_HAS_DRIVEN_ALL_VEHICLES

- **命名空间:** `STATS`
- **Hash:** `0x5EAD2BF6484852E4`
- **JHash:** `0x23D70C39`
- **Build:** `323`

**C# 签名:**
```csharp
bool GET_PLAYER_HAS_DRIVEN_ALL_VEHICLES()
```

**返回值:** `bool` (Native: `BOOL`)

---

### HAS_VC_WITHDRAWAL_COMPLETED

- **命名空间:** `MONEY`
- **Hash:** `0xE154B48B68EF72BC`
- **JHash:** `0x531E4892`
- **Build:** `323`

**C# 签名:**
```csharp
bool HAS_VC_WITHDRAWAL_COMPLETED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
This function is hard-coded to always return 1.
```

---

### HIRED_LIMO

- **命名空间:** `STATS`
- **Hash:** `0x792271AB35C356A4`
- **Build:** `573`

**C# 签名:**
```csharp
void HIRED_LIMO(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### LEADERBOARDS2_READ_BY_HANDLE

- **命名空间:** `STATS`
- **Hash:** `0xC30713A383BFBF0E`
- **JHash:** `0x6B553408`
- **Build:** `323`

**C# 签名:**
```csharp
bool LEADERBOARDS2_READ_BY_HANDLE(ref object p0, ref object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### LEADERBOARDS2_READ_BY_PLAFORM

- **命名空间:** `STATS`
- **Hash:** `0xF1AE5DCDBFCA2721`
- **Build:** `323`

**C# 签名:**
```csharp
bool LEADERBOARDS2_READ_BY_PLAFORM(ref object p0, string gamerHandleCsv, string platformName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `gamerHandleCsv` | `const char*` | `string` | - |
| `platformName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### LEADERBOARDS2_READ_BY_RADIUS

- **命名空间:** `STATS`
- **Hash:** `0x5CE587FB5A42C8C4`
- **JHash:** `0xC5B7E685`
- **Build:** `323`

**C# 签名:**
```csharp
bool LEADERBOARDS2_READ_BY_RADIUS(ref object p0, object p1, ref object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### LEADERBOARDS2_READ_BY_RANK

- **命名空间:** `STATS`
- **Hash:** `0xBA2C7DB0C129449A`
- **JHash:** `0x1B03F59F`
- **Build:** `323`

**C# 签名:**
```csharp
bool LEADERBOARDS2_READ_BY_RANK(ref object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### LEADERBOARDS2_READ_BY_SCORE_FLOAT

- **命名空间:** `STATS`
- **Hash:** `0xE662C8B759D08F3C`
- **JHash:** `0xC678B29F`
- **Build:** `323`

**C# 签名:**
```csharp
bool LEADERBOARDS2_READ_BY_SCORE_FLOAT(ref object p0, float p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `float` | `float` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### LEADERBOARDS2_READ_BY_SCORE_INT

- **命名空间:** `STATS`
- **Hash:** `0x7EEC7E4F6984A16A`
- **JHash:** `0xAC020C18`
- **Build:** `323`

**C# 签名:**
```csharp
bool LEADERBOARDS2_READ_BY_SCORE_INT(ref object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### LEADERBOARDS2_READ_FRIENDS_BY_ROW

- **命名空间:** `STATS`
- **Hash:** `0x918B101666F9CB83`
- **JHash:** `0xBD91B136`
- **Build:** `323`

**C# 签名:**
```csharp
bool LEADERBOARDS2_READ_FRIENDS_BY_ROW(ref object p0, ref object p1, object p2, bool p3, object p4, object p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any*` | `ref object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `Any` | `object` | - |
| `p5` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### LEADERBOARDS2_READ_GET_ROW_DATA_END

- **命名空间:** `STATS`
- **Hash:** `0x71B008056E5692D6`
- **JHash:** `0xF2DB6A82`
- **Build:** `323`

**C# 签名:**
```csharp
void LEADERBOARDS2_READ_GET_ROW_DATA_END()
```

**返回值:** `void` (Native: `void`)

---

### LEADERBOARDS2_READ_GET_ROW_DATA_FLOAT

- **命名空间:** `STATS`
- **Hash:** `0x38491439B6BA7F7D`
- **JHash:** `0x509A286F`
- **Build:** `323`

**C# 签名:**
```csharp
float LEADERBOARDS2_READ_GET_ROW_DATA_FLOAT(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `float` (Native: `float`)

---

### LEADERBOARDS2_READ_GET_ROW_DATA_INFO

- **命名空间:** `STATS`
- **Hash:** `0x34770B9CE0E03B91`
- **JHash:** `0x766A74FE`
- **Build:** `323`

**C# 签名:**
```csharp
bool LEADERBOARDS2_READ_GET_ROW_DATA_INFO(object p0, ref object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### LEADERBOARDS2_READ_GET_ROW_DATA_INT

- **命名空间:** `STATS`
- **Hash:** `0x88578F6EC36B4A3A`
- **JHash:** `0x6B90E730`
- **Build:** `323`

**C# 签名:**
```csharp
int LEADERBOARDS2_READ_GET_ROW_DATA_INT(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### LEADERBOARDS2_READ_GET_ROW_DATA_START

- **命名空间:** `STATS`
- **Hash:** `0xA0F93D5465B3094D`
- **JHash:** `0xC977D6E2`
- **Build:** `323`

**C# 签名:**
```csharp
bool LEADERBOARDS2_READ_GET_ROW_DATA_START(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### LEADERBOARDS2_READ_RANK_PREDICTION

- **命名空间:** `STATS`
- **Hash:** `0xC38DC1E90D22547C`
- **JHash:** `0x9BEC3401`
- **Build:** `323`

**C# 签名:**
```csharp
bool LEADERBOARDS2_READ_RANK_PREDICTION(ref object p0, ref object p1, ref object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any*` | `ref object` | - |
| `p2` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### LEADERBOARDS2_WRITE_DATA

- **命名空间:** `STATS`
- **Hash:** `0xAE2206545888AE49`
- **JHash:** `0x5F9DF634`
- **Build:** `323`

**C# 签名:**
```csharp
bool LEADERBOARDS2_WRITE_DATA(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### LEADERBOARDS2_WRITE_DATA_FOR_EVENT_TYPE

- **命名空间:** `STATS`
- **Hash:** `0xC980E62E33DF1D5C`
- **JHash:** `0x62C19A3D`
- **Build:** `323`

**C# 签名:**
```csharp
bool LEADERBOARDS2_WRITE_DATA_FOR_EVENT_TYPE(ref object p0, ref object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### LEADERBOARDS_CACHE_DATA_ROW

- **命名空间:** `STATS`
- **Hash:** `0xB9BB18E2C40142ED`
- **JHash:** `0x44F7D82B`
- **Build:** `323`

**C# 签名:**
```csharp
bool LEADERBOARDS_CACHE_DATA_ROW(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### LEADERBOARDS_CLEAR_CACHE_DATA

- **命名空间:** `STATS`
- **Hash:** `0xD4B02A6B476E1FDC`
- **JHash:** `0x87F498C1`
- **Build:** `323`

**C# 签名:**
```csharp
void LEADERBOARDS_CLEAR_CACHE_DATA()
```

**返回值:** `void` (Native: `void`)

---

### LEADERBOARDS_CLEAR_CACHE_DATA_ID

- **命名空间:** `STATS`
- **Hash:** `0x8EC74CEB042E7CFF`
- **JHash:** `0x88AE9667`
- **Build:** `323`

**C# 签名:**
```csharp
void LEADERBOARDS_CLEAR_CACHE_DATA_ID(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### LEADERBOARDS_GET_CACHE_DATA_ROW

- **命名空间:** `STATS`
- **Hash:** `0x9120E8DBA3D69273`
- **JHash:** `0xA11289EC`
- **Build:** `323`

**C# 签名:**
```csharp
bool LEADERBOARDS_GET_CACHE_DATA_ROW(object p0, object p1, ref object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any*` | `ref object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### LEADERBOARDS_GET_CACHE_EXISTS

- **命名空间:** `STATS`
- **Hash:** `0x9C51349BE6CDFE2C`
- **JHash:** `0xFC8A71F3`
- **Build:** `323`

**C# 签名:**
```csharp
bool LEADERBOARDS_GET_CACHE_EXISTS(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### LEADERBOARDS_GET_CACHE_NUMBER_OF_ROWS

- **命名空间:** `STATS`
- **Hash:** `0x58A651CD201D89AD`
- **JHash:** `0xCE7CB520`
- **Build:** `323`

**C# 签名:**
```csharp
int LEADERBOARDS_GET_CACHE_NUMBER_OF_ROWS(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### LEADERBOARDS_GET_CACHE_TIME

- **命名空间:** `STATS`
- **Hash:** `0xF04C1C27DA35F6C8`
- **JHash:** `0xEDF02302`
- **Build:** `323`

**C# 签名:**
```csharp
int LEADERBOARDS_GET_CACHE_TIME(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### LEADERBOARDS_GET_COLUMN_ID

- **命名空间:** `STATS`
- **Hash:** `0xC4B5467A1886EA7E`
- **JHash:** `0x3821A334`
- **Build:** `323`

**C# 签名:**
```csharp
int LEADERBOARDS_GET_COLUMN_ID(int p0, int p1, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### LEADERBOARDS_GET_COLUMN_TYPE

- **命名空间:** `STATS`
- **Hash:** `0xBF4FEF46DB7894D3`
- **JHash:** `0x6F2820F4`
- **Build:** `323`

**C# 签名:**
```csharp
int LEADERBOARDS_GET_COLUMN_TYPE(int p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### LEADERBOARDS_GET_NUMBER_OF_COLUMNS

- **命名空间:** `STATS`
- **Hash:** `0x117B45156D7EFF2E`
- **JHash:** `0x0A56EE34`
- **Build:** `323`

**C# 签名:**
```csharp
int LEADERBOARDS_GET_NUMBER_OF_COLUMNS(int p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### LEADERBOARDS_READ_ANY_PENDING

- **命名空间:** `STATS`
- **Hash:** `0xA31FD15197B192BD`
- **JHash:** `0x1789437B`
- **Build:** `323`

**C# 签名:**
```csharp
bool LEADERBOARDS_READ_ANY_PENDING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### LEADERBOARDS_READ_CLEAR

- **命名空间:** `STATS`
- **Hash:** `0x7CCE5C737A665701`
- **JHash:** `0x7090012F`
- **Build:** `323`

**C# 签名:**
```csharp
int LEADERBOARDS_READ_CLEAR(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### LEADERBOARDS_READ_CLEAR_ALL

- **命名空间:** `STATS`
- **Hash:** `0xA34CB6E6F0DF4A0B`
- **JHash:** `0x233E058A`
- **Build:** `323`

**C# 签名:**
```csharp
int LEADERBOARDS_READ_CLEAR_ALL()
```

**返回值:** `int` (Native: `int`)

---

### LEADERBOARDS_READ_PENDING

- **命名空间:** `STATS`
- **Hash:** `0xAC392C8483342AC2`
- **JHash:** `0xEEB8BF5C`
- **Build:** `323`

**C# 签名:**
```csharp
bool LEADERBOARDS_READ_PENDING(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### LEADERBOARDS_READ_SUCCESSFUL

- **命名空间:** `STATS`
- **Hash:** `0x2FB19228983E832C`
- **JHash:** `0x3AC5B2F1`
- **Build:** `323`

**C# 签名:**
```csharp
bool LEADERBOARDS_READ_SUCCESSFUL(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### LEADERBOARDS_WRITE_ADD_COLUMN

- **命名空间:** `STATS`
- **Hash:** `0x0BCA1D2C47B0D269`
- **JHash:** `0x7524E27B`
- **Build:** `323`

**C# 签名:**
```csharp
void LEADERBOARDS_WRITE_ADD_COLUMN(object p0, object p1, float p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### LEADERBOARDS_WRITE_ADD_COLUMN_LONG

- **命名空间:** `STATS`
- **Hash:** `0x2E65248609523599`
- **JHash:** `0x1C5CCC3A`
- **Build:** `323`

**C# 签名:**
```csharp
void LEADERBOARDS_WRITE_ADD_COLUMN_LONG(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_BUY_AIRSTRIKE

- **命名空间:** `MONEY`
- **Hash:** `0x763B4BD305338F19`
- **JHash:** `0x40470683`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_BUY_AIRSTRIKE(int cost, bool p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cost` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 = 0 (always)
p2 = 1 (always)
```

---

### NETWORK_BUY_BACKUP_GANG

- **命名空间:** `MONEY`
- **Hash:** `0xA3EDDAA42411D3B9`
- **JHash:** `0x2AD2EC51`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_BUY_BACKUP_GANG(int p0, int p1, bool p2, bool p3, int npcProvider)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |
| `npcProvider` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_BUY_BOUNTY

- **命名空间:** `MONEY`
- **Hash:** `0x7B718E197453F2D9`
- **JHash:** `0xCB89CBE0`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_BUY_BOUNTY(int amount, int victim, bool p2, bool p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `victim` | `Player` | `int` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 is just an assumption. p2 was false and p3 was true.
```

---

### NETWORK_BUY_CONTRABAND_MISSION

- **命名空间:** `MONEY`
- **Hash:** `0x30FD873ECE50E9F6`
- **Build:** `757`

**C# 签名:**
```csharp
void NETWORK_BUY_CONTRABAND_MISSION(int p0, int p1, uint p2, bool p3, bool p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `Hash` | `uint` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_BUY_FAIRGROUND_RIDE

- **命名空间:** `MONEY`
- **Hash:** `0x8A7B3952DD64D2B5`
- **JHash:** `0xD9622D64`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_BUY_FAIRGROUND_RIDE(int amount, object p1, bool p2, bool p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
The first parameter is the amount spent which is store in a global when this native is called. The global returns 10. Which is the price for both rides.

The last 3 parameters are, 
2,0,1 in the am_ferriswheel.c
1,0,1 in the am_rollercoaster.c

```

---

### NETWORK_BUY_HEALTHCARE

- **命名空间:** `MONEY`
- **Hash:** `0xD9B067E55253E3DD`
- **JHash:** `0x832150E5`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_BUY_HEALTHCARE(int cost, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cost` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_BUY_HELI_STRIKE

- **命名空间:** `MONEY`
- **Hash:** `0x81AA4610E3FD3A69`
- **JHash:** `0x047547D4`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_BUY_HELI_STRIKE(int cost, bool p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cost` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p1 = 0 (always)
p2 = 1 (always)
```

---

### NETWORK_BUY_ITEM

- **命名空间:** `MONEY`
- **Hash:** `0xF0077C797F66A355`
- **JHash:** `0xA07B6368`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_BUY_ITEM(int amount, uint item, object p2, object p3, bool p4, string item_name, object p6, object p7, object p8, bool p9)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `item` | `Hash` | `uint` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `BOOL` | `bool` | - |
| `item_name` | `const char*` | `string` | - |
| `p6` | `Any` | `object` | - |
| `p7` | `Any` | `object` | - |
| `p8` | `Any` | `object` | - |
| `p9` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_BUY_PROPERTY

- **命名空间:** `MONEY`
- **Hash:** `0x650A08A280870AF6`
- **JHash:** `0x7D479AAB`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_BUY_PROPERTY(int cost, uint propertyName, bool p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cost` | `int` | `int` | - |
| `propertyName` | `Hash` | `uint` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_BUY_SMOKES

- **命名空间:** `MONEY`
- **Hash:** `0x75AF80E61248EEBD`
- **JHash:** `0xC0AB03EB`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_BUY_SMOKES(int p0, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_CAN_BET

- **命名空间:** `MONEY`
- **Hash:** `0x3A54E33660DED67F`
- **JHash:** `0xE3802533`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CAN_BET(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CAN_RECEIVE_PLAYER_CASH

- **命名空间:** `MONEY`
- **Hash:** `0x5D17BE59D2123284`
- **JHash:** `0x41F5F10E`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CAN_RECEIVE_PLAYER_CASH(object p0, object p1, object p2, object p3)
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

### NETWORK_CAN_SHARE_JOB_CASH

- **命名空间:** `MONEY`
- **Hash:** `0x1C2473301B1C66BA`
- **JHash:** `0xA27B9FE8`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CAN_SHARE_JOB_CASH()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CAN_SPEND_MONEY

- **命名空间:** `MONEY`
- **Hash:** `0xAB3CAA6B422164DA`
- **JHash:** `0x5AA379D9`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CAN_SPEND_MONEY(object p0, bool p1, bool p2, bool p3, object p4, object p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `Any` | `object` | - |
| `p5` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CAN_SPEND_MONEY2

- **命名空间:** `MONEY`
- **Hash:** `0x7303E27CC6532080`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_CAN_SPEND_MONEY2(object p0, bool p1, bool p2, bool p3, ref object p4, object p5, object p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `Any*` | `ref object` | - |
| `p5` | `Any` | `object` | - |
| `p6` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CASINO_BUY_CHIPS

- **命名空间:** `MONEY`
- **Hash:** `0x3BD101471C7F9EEC`
- **Build:** `1734`

**C# 签名:**
```csharp
bool NETWORK_CASINO_BUY_CHIPS(int p0, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CASINO_CAN_BET

- **命名空间:** `MONEY`
- **Hash:** `0x158C16F5E4CF41F8`
- **Build:** `1734`

**C# 签名:**
```csharp
bool NETWORK_CASINO_CAN_BET(uint hash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `hash` | `Hash` | `uint` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
GTAO_CASINO_HOUSE
GTAO_CASINO_INSIDETRACK
GTAO_CASINO_LUCKYWHEEL
GTAO_CASINO_BLACKJACK
GTAO_CASINO_ROULETTE
GTAO_CASINO_SLOTS
GTAO_CASINO_PURCHASE_CHIPS

NETWORK_C*
```

---

### NETWORK_CASINO_CAN_BET_AMOUNT

- **命名空间:** `MONEY`
- **Hash:** `0xF62F6D9528358FE4`
- **Build:** `1734`

**C# 签名:**
```csharp
bool NETWORK_CASINO_CAN_BET_AMOUNT(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CASINO_CAN_BET_PVC

- **命名空间:** `MONEY`
- **Hash:** `0x394DCDB9E836B7A9`
- **Build:** `1734`

**C# 签名:**
```csharp
bool NETWORK_CASINO_CAN_BET_PVC()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CASINO_CAN_BUY_CHIPS_PVC

- **命名空间:** `MONEY`
- **Hash:** `0x8968D4D8C6C40C11`
- **Build:** `1734`

**C# 签名:**
```csharp
bool NETWORK_CASINO_CAN_BUY_CHIPS_PVC()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CASINO_SELL_CHIPS

- **命名空间:** `MONEY`
- **Hash:** `0xED44897CB336F480`
- **Build:** `1734`

**C# 签名:**
```csharp
bool NETWORK_CASINO_SELL_CHIPS(int p0, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_CLEAR_CHARACTER_WALLET

- **命名空间:** `MONEY`
- **Hash:** `0xA921DED15FDF28F5`
- **JHash:** `0x19F0C471`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_CLEAR_CHARACTER_WALLET(int characterSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `characterSlot` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_DEDUCT_CASH

- **命名空间:** `MONEY`
- **Hash:** `0x18B7AE224B087E26`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_DEDUCT_CASH(int amount, string p1, string p2, bool p3, bool p4, bool p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `const char*` | `string` | - |
| `p2` | `const char*` | `string` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `BOOL` | `bool` | - |
| `p5` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_DEFER_CASH_TRANSACTIONS_UNTIL_SHOP_SAVE

- **命名空间:** `MONEY`
- **Hash:** `0xCD0F5B5D932AE473`
- **JHash:** `0xC4CD928D`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_DEFER_CASH_TRANSACTIONS_UNTIL_SHOP_SAVE()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Does nothing (it's a nullsub).
```

---

### NETWORK_DELETE_CHARACTER

- **命名空间:** `MONEY`
- **Hash:** `0x05A50AF38947EB8D`
- **JHash:** `0xA9F7E9C3`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_DELETE_CHARACTER(int characterSlot, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `characterSlot` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Note the 2nd parameters are always 1, 0. I have a feeling it deals with your money, wallet, bank. So when you delete the character it of course wipes the wallet cash at that time. So if that was the case, it would be eg, NETWORK_DELETE_CHARACTER(characterIndex, deleteWalletCash, deleteBankCash);
```

---

### NETWORK_EARN_AGENCY

- **命名空间:** `MONEY`
- **Hash:** `0x0CB1BE0633C024A8`
- **Build:** `573`

**C# 签名:**
```csharp
void NETWORK_EARN_AGENCY(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_AGENCY_CONTRACT

- **命名空间:** `MONEY`
- **Hash:** `0x38482AD49CB905C7`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_EARN_AGENCY_CONTRACT(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_AGENCY_PHONE

- **命名空间:** `MONEY`
- **Hash:** `0xE29F3D5FA63B1B82`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_EARN_AGENCY_PHONE(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_AGENCY_SAFE

- **命名空间:** `MONEY`
- **Hash:** `0x663B4B9D11742A12`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_EARN_AGENCY_SAFE(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_ARCADE

- **命名空间:** `MONEY`
- **Hash:** `0xD29334ED1A256DBF`
- **Build:** `1868`

**C# 签名:**
```csharp
void NETWORK_EARN_ARCADE(object p0, object p1, object p2, object p3, object p4, object p5)
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

### NETWORK_EARN_ARENA_CAREER_PROGRESSION

- **命名空间:** `MONEY`
- **Hash:** `0x0F99F70C61F14619`
- **Build:** `1604`

**C# 签名:**
```csharp
void NETWORK_EARN_ARENA_CAREER_PROGRESSION(int amount, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_ARENA_SKILL_LEVEL_PROGRESSION

- **命名空间:** `MONEY`
- **Hash:** `0xE08256F972C7BB2C`
- **Build:** `1604`

**C# 签名:**
```csharp
void NETWORK_EARN_ARENA_SKILL_LEVEL_PROGRESSION(int amount, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_ARENA_WAR

- **命名空间:** `MONEY`
- **Hash:** `0x631F1CB8FB4130AA`
- **Build:** `1604`

**C# 签名:**
```csharp
void NETWORK_EARN_ARENA_WAR(int amount, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_ARENA_WAR_ASSASSINATE_TARGET

- **命名空间:** `MONEY`
- **Hash:** `0x5E7AE8AABE8B7C0D`
- **Build:** `1604`

**C# 签名:**
```csharp
void NETWORK_EARN_ARENA_WAR_ASSASSINATE_TARGET(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_ARENA_WAR_EVENT_CARGO

- **命名空间:** `MONEY`
- **Hash:** `0xA82959062361B259`
- **Build:** `1604`

**C# 签名:**
```csharp
void NETWORK_EARN_ARENA_WAR_EVENT_CARGO(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_ASSASSINATE_TARGET_KILLED

- **命名空间:** `MONEY`
- **Hash:** `0xFA700D8A9905F78A`
- **Build:** `1604`

**C# 签名:**
```csharp
void NETWORK_EARN_ASSASSINATE_TARGET_KILLED(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_AUTOSHOP_BUSINESS

- **命名空间:** `MONEY`
- **Hash:** `0x36A7FD5A7194B03E`
- **Build:** `2372`

**C# 签名:**
```csharp
void NETWORK_EARN_AUTOSHOP_BUSINESS(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_AUTOSHOP_INCOME

- **命名空间:** `MONEY`
- **Hash:** `0xC66D1CF99ED7FE25`
- **Build:** `2372`

**C# 签名:**
```csharp
void NETWORK_EARN_AUTOSHOP_INCOME(object p0, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_AWARD_CONTRACT

- **命名空间:** `MONEY`
- **Hash:** `0x146D4EB6D22A403F`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_EARN_AWARD_CONTRACT(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_AWARD_FIXER_MISSION

- **命名空间:** `MONEY`
- **Hash:** `0x88D6C327D6C57C45`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_EARN_AWARD_FIXER_MISSION(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_AWARD_PHONE

- **命名空间:** `MONEY`
- **Hash:** `0x7397A115030F1BE3`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_EARN_AWARD_PHONE(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_AWARD_SHORT_TRIP

- **命名空间:** `MONEY`
- **Hash:** `0x5B4DBDED84D6A420`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_EARN_AWARD_SHORT_TRIP(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_BB_EVENT_BONUS

- **命名空间:** `MONEY`
- **Hash:** `0xFDD8D2440DAF1590`
- **Build:** `1604`

**C# 签名:**
```csharp
void NETWORK_EARN_BB_EVENT_BONUS(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_BEACH_PARTY_LOST_FOUND

- **命名空间:** `MONEY`
- **Hash:** `0xA51338E0DCCD4065`
- **Build:** `2189`

**C# 签名:**
```csharp
void NETWORK_EARN_BEACH_PARTY_LOST_FOUND(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_BIKER

- **命名空间:** `MONEY`
- **Hash:** `0x71BEC32FA466E105`
- **Build:** `2699`

**C# 签名:**
```csharp
void NETWORK_EARN_BIKER(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_BIKER_SHOP

- **命名空间:** `MONEY`
- **Hash:** `0x2C5809EB9DF57257`
- **Build:** `2699`

**C# 签名:**
```csharp
void NETWORK_EARN_BIKER_SHOP(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_BOSS

- **命名空间:** `MONEY`
- **Hash:** `0x08B0CA7A6AB3AC32`
- **Build:** `573`

**C# 签名:**
```csharp
void NETWORK_EARN_BOSS(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_BOUNTY_HUNTER_REWARD

- **命名空间:** `MONEY`
- **Hash:** `0xF6B170F9A02E9E87`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_EARN_BOUNTY_HUNTER_REWARD(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_CARCLUB_MEMBERSHIP

- **命名空间:** `MONEY`
- **Hash:** `0xBC6227792A188E2E`
- **Build:** `2372`

**C# 签名:**
```csharp
void NETWORK_EARN_CARCLUB_MEMBERSHIP(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_CASINO_AWARD

- **命名空间:** `MONEY`
- **Hash:** `0x973A9781A34F8DEB`
- **Build:** `1734`

**C# 签名:**
```csharp
void NETWORK_EARN_CASINO_AWARD(int amount, uint hash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `hash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_CASINO_COLLECTABLE_COMPLETED_COLLECTION

- **命名空间:** `MONEY`
- **Hash:** `0x83AD64F53F4E9483`
- **Build:** `1734`

**C# 签名:**
```csharp
void NETWORK_EARN_CASINO_COLLECTABLE_COMPLETED_COLLECTION(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_CASINO_HEIST

- **命名空间:** `MONEY`
- **Hash:** `0x72E7C7B9615FA3C3`
- **Build:** `1868`

**C# 签名:**
```csharp
void NETWORK_EARN_CASINO_HEIST(object p0, object p1, object p2, object p3, object p4, object p5, object p6)
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

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_CASINO_HEIST_AWARDS

- **命名空间:** `MONEY`
- **Hash:** `0x3EC7471E6909798A`
- **Build:** `1868`

**C# 签名:**
```csharp
void NETWORK_EARN_CASINO_HEIST_AWARDS(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_CASINO_MISSION_PARTICIPATION

- **命名空间:** `MONEY`
- **Hash:** `0x09E8F18641BE2575`
- **Build:** `1734`

**C# 签名:**
```csharp
void NETWORK_EARN_CASINO_MISSION_PARTICIPATION(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_CASINO_MISSION_REWARD

- **命名空间:** `MONEY`
- **Hash:** `0x566FD402B25787DE`
- **Build:** `1734`

**C# 签名:**
```csharp
void NETWORK_EARN_CASINO_MISSION_REWARD(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_CASINO_STORY_MISSION_REWARD

- **命名空间:** `MONEY`
- **Hash:** `0xAC95ED552157E092`
- **Build:** `1734`

**C# 签名:**
```csharp
void NETWORK_EARN_CASINO_STORY_MISSION_REWARD(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_CASINO_TIME_TRIAL_WIN

- **命名空间:** `MONEY`
- **Hash:** `0x0819DB99FD2FBBD8`
- **Build:** `1734`

**C# 签名:**
```csharp
void NETWORK_EARN_CASINO_TIME_TRIAL_WIN(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_CHALLENGE

- **命名空间:** `MONEY`
- **Hash:** `0x0DD362F14F18942A`
- **Build:** `1868`

**C# 签名:**
```csharp
void NETWORK_EARN_CHALLENGE(int amount, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_COLLECTABLES

- **命名空间:** `MONEY`
- **Hash:** `0xA95CFB4E02390842`
- **Build:** `1868`

**C# 签名:**
```csharp
void NETWORK_EARN_COLLECTABLES(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_COLLECTABLES_ACTION_FIGURES

- **命名空间:** `MONEY`
- **Hash:** `0x5517F90043466049`
- **Build:** `1734`

**C# 签名:**
```csharp
void NETWORK_EARN_COLLECTABLES_ACTION_FIGURES(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_COLLECTABLE_COMPLETED_COLLECTION

- **命名空间:** `MONEY`
- **Hash:** `0x5C9B198AF5A54FA6`
- **Build:** `2060`

**C# 签名:**
```csharp
void NETWORK_EARN_COLLECTABLE_COMPLETED_COLLECTION(int amount, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_COLLECTABLE_ITEM

- **命名空间:** `MONEY`
- **Hash:** `0x84FF63BD4966F33D`
- **Build:** `1734`

**C# 签名:**
```csharp
void NETWORK_EARN_COLLECTABLE_ITEM(int amount, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_DAILY_OBJECTIVE_EVENT

- **命名空间:** `MONEY`
- **Hash:** `0x5128DF14A5BB86FC`
- **Build:** `1734`

**C# 签名:**
```csharp
void NETWORK_EARN_DAILY_OBJECTIVE_EVENT(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_DAILY_VEHICLE

- **命名空间:** `MONEY`
- **Hash:** `0x533073E8A596008C`
- **Build:** `2372`

**C# 签名:**
```csharp
void NETWORK_EARN_DAILY_VEHICLE(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_DAILY_VEHICLE_BONUS

- **命名空间:** `MONEY`
- **Hash:** `0xFE65AFE7308E32B2`
- **Build:** `2372`

**C# 签名:**
```csharp
void NETWORK_EARN_DAILY_VEHICLE_BONUS(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_DAR_CHALLENGE

- **命名空间:** `MONEY`
- **Hash:** `0xCAC672087B4A24AB`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_EARN_DAR_CHALLENGE(int amount, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_DISPATCH_CALL

- **命名空间:** `MONEY`
- **Hash:** `0xE2E244AB823B4483`
- **Build:** `2060`

**C# 签名:**
```csharp
void NETWORK_EARN_DISPATCH_CALL(int amount, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_DOOMSDAY_FINALE_BONUS

- **命名空间:** `MONEY`
- **Hash:** `0x128A747F4A230952`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_EARN_DOOMSDAY_FINALE_BONUS(int amount, uint vehicleHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `vehicleHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FIRST_TIME_BONUS

- **命名空间:** `MONEY`
- **Hash:** `0x11B0A20C493F7E36`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_EARN_FIRST_TIME_BONUS(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FIXER_AGENCY_SHORT_TRIP

- **命名空间:** `MONEY`
- **Hash:** `0xF4A8E57460BF2037`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_EARN_FIXER_AGENCY_SHORT_TRIP(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FIXER_FINALE

- **命名空间:** `MONEY`
- **Hash:** `0xBA154373C5FE51E8`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_EARN_FIXER_FINALE(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FIXER_PREP

- **命名空间:** `MONEY`
- **Hash:** `0x6283E5DE4C4460C6`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_EARN_FIXER_PREP(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FIXER_RIVAL_DELIVERY

- **命名空间:** `MONEY`
- **Hash:** `0x235D41210B3A1A5E`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_EARN_FIXER_RIVAL_DELIVERY(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FMBB_WAGE_BONUS

- **命名空间:** `MONEY`
- **Hash:** `0xFFFBA1B1F7C0B6F4`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_EARN_FMBB_WAGE_BONUS(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_AI_TARGET_KILL

- **命名空间:** `MONEY`
- **Hash:** `0x515B4A22E4D3C6D7`
- **JHash:** `0x866004A8`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_AI_TARGET_KILL(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
DSPORT
```

---

### NETWORK_EARN_FROM_AMBIENT_JOB

- **命名空间:** `MONEY`
- **Hash:** `0xFB6DB092FBAE29E6`
- **JHash:** `0xA14CC95D`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_AMBIENT_JOB(int p0, string p1, ref object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `const char*` | `string` | - |
| `p2` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Example for p1: "AM_DISTRACT_COPS"
```

---

### NETWORK_EARN_FROM_BEND_JOB

- **命名空间:** `MONEY`
- **Hash:** `0x61326EE6DF15B0CA`
- **JHash:** `0xBB293400`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_BEND_JOB(int amount, string heistHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `heistHash` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_BETTING

- **命名空间:** `MONEY`
- **Hash:** `0x827A5BA1A44ACA6D`
- **JHash:** `0xA0F7F07C`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_BETTING(int amount, string p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_BOUNTY

- **命名空间:** `MONEY`
- **Hash:** `0x131BB5DA15453ACF`
- **JHash:** `0x127F2DAE`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_BOUNTY(int amount, ref object gamerHandle, ref object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `gamerHandle` | `Any*` | `ref object` | - |
| `p2` | `Any*` | `ref object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_BUSINESS_BATTLE

- **命名空间:** `MONEY`
- **Hash:** `0x42FCE14F50F27291`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_BUSINESS_BATTLE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_BUSINESS_HUB_SELL

- **命名空间:** `MONEY`
- **Hash:** `0x0B39CF0D53F1C883`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_BUSINESS_HUB_SELL(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_BUSINESS_PRODUCT

- **命名空间:** `MONEY`
- **Hash:** `0x8586789730B10CAF`
- **Build:** `877`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_BUSINESS_PRODUCT(int amount, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_CASHING_OUT

- **命名空间:** `MONEY`
- **Hash:** `0x718FBBF67414FA36`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_CASHING_OUT(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_CHALLENGE_WIN

- **命名空间:** `MONEY`
- **Hash:** `0x2B171E6B2F64D8DF`
- **JHash:** `0x2BEFB6C4`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_CHALLENGE_WIN(object p0, ref object p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any*` | `ref object` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_CLUB_MANAGEMENT_PARTICIPATION

- **命名空间:** `MONEY`
- **Hash:** `0xA75EAC69F59E96E7`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_CLUB_MANAGEMENT_PARTICIPATION(object p0, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_CONTRABAND

- **命名空间:** `MONEY`
- **Hash:** `0xECA658CE2A4E5A72`
- **Build:** `757`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_CONTRABAND(int amount, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_CRATE_DROP

- **命名空间:** `MONEY`
- **Hash:** `0xB1CC1B9EC3007A2A`
- **JHash:** `0xEAF04923`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_CRATE_DROP(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_CRIMINAL_MASTERMIND

- **命名空间:** `MONEY`
- **Hash:** `0xFA009A62990671D4`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_CRIMINAL_MASTERMIND(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_DAILY_OBJECTIVES

- **命名空间:** `MONEY`
- **Hash:** `0x6EA318C91C1A8786`
- **JHash:** `0xAB6BD72F`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_DAILY_OBJECTIVES(int amount, string type, int characterSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `type` | `const char*` | `string` | - |
| `characterSlot` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
type either Monthly,Weekly,Daily
```

---

### NETWORK_EARN_FROM_DESTROYING_CONTRABAND

- **命名空间:** `MONEY`
- **Hash:** `0x84C0116D012E8FC2`
- **Build:** `757`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_DESTROYING_CONTRABAND(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_FMBB_BOSS_WORK

- **命名空间:** `MONEY`
- **Hash:** `0x1FDA0AA679C9919B`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_FMBB_BOSS_WORK(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_FMBB_PHONECALL_MISSION

- **命名空间:** `MONEY`
- **Hash:** `0xC5156361F26E2212`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_FMBB_PHONECALL_MISSION(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_GANGATTACK_PICKUP

- **命名空间:** `MONEY`
- **Hash:** `0xA03D4ACE0A3284CE`
- **JHash:** `0x33C20BC4`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_GANGATTACK_PICKUP(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_HANGAR_TRADE

- **命名空间:** `MONEY`
- **Hash:** `0x31BA138F6304FB9F`
- **Build:** `1180`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_HANGAR_TRADE(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_HOLDUPS

- **命名空间:** `MONEY`
- **Hash:** `0x45B8154E077D9E4D`
- **JHash:** `0xE6B90E9C`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_HOLDUPS(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_IMPORT_EXPORT

- **命名空间:** `MONEY`
- **Hash:** `0xF92A014A634442D6`
- **JHash:** `0xF11FC458`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_IMPORT_EXPORT(int amount, uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_ISLAND_HEIST_DJ_MISSION

- **命名空间:** `MONEY`
- **Hash:** `0xE2BB399D90942091`
- **Build:** `2189`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_ISLAND_HEIST_DJ_MISSION(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_JOB

- **命名空间:** `MONEY`
- **Hash:** `0xB2CC4836834E8A98`
- **JHash:** `0x0B6997FC`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_JOB(int amount, string p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_JOBX2

- **命名空间:** `MONEY`
- **Hash:** `0xDEBBF584665411D0`
- **Build:** `1734`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_JOBX2(int amount, string p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_JOB_BONUS

- **命名空间:** `MONEY`
- **Hash:** `0x6816FB4416760775`
- **JHash:** `0xBEE23713`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_JOB_BONUS(object p0, ref object p1, ref object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any*` | `ref object` | - |
| `p2` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_NOT_BADSPORT

- **命名空间:** `MONEY`
- **Hash:** `0x4337511FA8221D36`
- **JHash:** `0xCC068380`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_NOT_BADSPORT(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_PERSONAL_VEHICLE

- **命名空间:** `MONEY`
- **Hash:** `0x3F4D00167E41E0AD`
- **JHash:** `0x96B8BEE8`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_PERSONAL_VEHICLE(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8)
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

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_PICKUP

- **命名空间:** `MONEY`
- **Hash:** `0xED1517D3AF17C698`
- **JHash:** `0x70A0ED62`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_PICKUP(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_PREMIUM_JOB

- **命名空间:** `MONEY`
- **Hash:** `0xC8407624CEF2354B`
- **Build:** `791`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_PREMIUM_JOB(int amount, string p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_PROPERTY

- **命名空间:** `MONEY`
- **Hash:** `0x849648349D77F5C5`
- **JHash:** `0x9BE4F7E1`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_PROPERTY(int amount, uint propertyName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `propertyName` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_ROB_ARMORED_CARS

- **命名空间:** `MONEY`
- **Hash:** `0xF514621E8EA463D0`
- **JHash:** `0x30B3EC0A`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_ROB_ARMORED_CARS(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
For the money bags that drop a max of $40,000. Often called 40k bags.

Most likely NETWORK_EARN_FROM_ROB***
```

---

### NETWORK_EARN_FROM_SELL_BUNKER

- **命名空间:** `MONEY`
- **Hash:** `0x9251B6ABF2D0A5B4`
- **Build:** `1103`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_SELL_BUNKER(int amount, uint bunkerHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `bunkerHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_SMUGGLER_WORK

- **命名空间:** `MONEY`
- **Hash:** `0x6B7E4FB50D5F3D65`
- **Build:** `1180`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_SMUGGLER_WORK(object p0, object p1, object p2, object p3, object p4, object p5)
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

### NETWORK_EARN_FROM_VEHICLE

- **命名空间:** `MONEY`
- **Hash:** `0xB539BD8A4C1EECF8`
- **JHash:** `0xF803589D`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_VEHICLE(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7)
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

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_VEHICLE_EXPORT

- **命名空间:** `MONEY`
- **Hash:** `0xEDEAD9A91EC768B3`
- **Build:** `944`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_VEHICLE_EXPORT(int amount, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_FROM_WAREHOUSE

- **命名空间:** `MONEY`
- **Hash:** `0x3E4ADAFF1830F146`
- **Build:** `757`

**C# 签名:**
```csharp
void NETWORK_EARN_FROM_WAREHOUSE(int amount, int id)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `id` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_GANGOPS_AWARD

- **命名空间:** `MONEY`
- **Hash:** `0xA9A31475F530DFDA`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_EARN_GANGOPS_AWARD(int amount, string p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `const char*` | `string` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_GANGOPS_ELITE

- **命名空间:** `MONEY`
- **Hash:** `0x2597A0D4A4FC2C77`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_EARN_GANGOPS_ELITE(int amount, string p1, int actIndex)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `const char*` | `string` | - |
| `actIndex` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_GANGOPS_FINALE

- **命名空间:** `MONEY`
- **Hash:** `0x1C121FC9545E0D52`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_EARN_GANGOPS_FINALE(int amount, string p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_GANGOPS_PREP_PARTICIPATION

- **命名空间:** `MONEY`
- **Hash:** `0xED26584F6BDCBBFD`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_EARN_GANGOPS_PREP_PARTICIPATION(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_GANGOPS_SETUP

- **命名空间:** `MONEY`
- **Hash:** `0xA9160796D47A2CF8`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_EARN_GANGOPS_SETUP(int amount, string p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_GANGOPS_WAGES

- **命名空间:** `MONEY`
- **Hash:** `0x2DCB19ABAB0380A8`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_EARN_GANGOPS_WAGES(int amount, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_GANGOPS_WAGES_BONUS

- **命名空间:** `MONEY`
- **Hash:** `0x15BB2A5C757EB91F`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_EARN_GANGOPS_WAGES_BONUS(int amount, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_GOON

- **命名空间:** `MONEY`
- **Hash:** `0xCDA1C62BE2777802`
- **Build:** `573`

**C# 签名:**
```csharp
void NETWORK_EARN_GOON(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_HACKER_TRUCK

- **命名空间:** `MONEY`
- **Hash:** `0xE8815FE993896AD3`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_EARN_HACKER_TRUCK(object p0, int amount, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `amount` | `int` | `int` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_HEIST_AWARD

- **命名空间:** `MONEY`
- **Hash:** `0x9D4FDBB035229669`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_EARN_HEIST_AWARD(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_ISLAND_HEIST

- **命名空间:** `MONEY`
- **Hash:** `0xD21D111C46BA9F15`
- **Build:** `2189`

**C# 签名:**
```csharp
void NETWORK_EARN_ISLAND_HEIST(int amount1, object p1, object p2, object p3, int amount2, int p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount1` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `amount2` | `int` | `int` | - |
| `p5` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_NIGHTCLUB

- **命名空间:** `MONEY`
- **Hash:** `0xE0F82D68C7039158`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_EARN_NIGHTCLUB(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_NIGHTCLUB_AND_WAREHOUSE

- **命名空间:** `MONEY`
- **Hash:** `0xC6E74CF8C884C880`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_EARN_NIGHTCLUB_AND_WAREHOUSE(object p0, object p1, object p2, object p3, object p4, object p5, object p6)
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

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_NIGHTCLUB_DANCING

- **命名空间:** `MONEY`
- **Hash:** `0xB4DEAE67F35E2ACD`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_EARN_NIGHTCLUB_DANCING(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_PURCHASE_CLUB_HOUSE

- **命名空间:** `MONEY`
- **Hash:** `0x55A1E095DB052FA5`
- **Build:** `877`

**C# 签名:**
```csharp
void NETWORK_EARN_PURCHASE_CLUB_HOUSE(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_RC_TIME_TRIAL

- **命名空间:** `MONEY`
- **Hash:** `0xDFF49EE984E7AAE8`
- **Build:** `1734`

**C# 签名:**
```csharp
void NETWORK_EARN_RC_TIME_TRIAL(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_RDR_BONUS

- **命名空间:** `MONEY`
- **Hash:** `0x7A5349B773584675`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_EARN_RDR_BONUS(int amount, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_SELL_BASE

- **命名空间:** `MONEY`
- **Hash:** `0x0E1E2FF3F4EC11AA`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_EARN_SELL_BASE(int amount, uint baseNameHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `baseNameHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_SELL_PRIZE_VEHICLE

- **命名空间:** `MONEY`
- **Hash:** `0x8BCB27A057DF7B7F`
- **Build:** `1734`

**C# 签名:**
```csharp
void NETWORK_EARN_SELL_PRIZE_VEHICLE(int amount, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_SIGHTSEEING_REWARD

- **命名空间:** `MONEY`
- **Hash:** `0x45087AE480B233AC`
- **Build:** `2699`

**C# 签名:**
```csharp
void NETWORK_EARN_SIGHTSEEING_REWARD(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_SMUGGLER_AGENCY

- **命名空间:** `MONEY`
- **Hash:** `0xDEE612F2D71B0308`
- **Build:** `1180`

**C# 签名:**
```csharp
void NETWORK_EARN_SMUGGLER_AGENCY(int amount, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_SPIN_THE_WHEEL_CASH

- **命名空间:** `MONEY`
- **Hash:** `0x676C48776CACBB5A`
- **Build:** `1604`

**C# 签名:**
```csharp
void NETWORK_EARN_SPIN_THE_WHEEL_CASH(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_TARGET_REFUND

- **命名空间:** `MONEY`
- **Hash:** `0x5B669CF2299A271F`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_EARN_TARGET_REFUND(int amount, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_TUNER_AWARD

- **命名空间:** `MONEY`
- **Hash:** `0xB846F547D3792DF6`
- **Build:** `2372`

**C# 签名:**
```csharp
void NETWORK_EARN_TUNER_AWARD(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_TUNER_ROBBERY

- **命名空间:** `MONEY`
- **Hash:** `0xBCB266247193AC61`
- **Build:** `2372`

**C# 签名:**
```csharp
void NETWORK_EARN_TUNER_ROBBERY(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_UPGRADE_AGENCY

- **命名空间:** `MONEY`
- **Hash:** `0xD07C7C3F1995108C`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_EARN_UPGRADE_AGENCY(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_UPGRADE_ARCADE

- **命名空间:** `MONEY`
- **Hash:** `0x4C3B75694F7E0D9C`
- **Build:** `1868`

**C# 签名:**
```csharp
void NETWORK_EARN_UPGRADE_ARCADE(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_UPGRADE_AUTOSHOP

- **命名空间:** `MONEY`
- **Hash:** `0xC10322A8D3E061EE`
- **Build:** `2372`

**C# 签名:**
```csharp
void NETWORK_EARN_UPGRADE_AUTOSHOP(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_WAGE_PAYMENT

- **命名空间:** `MONEY`
- **Hash:** `0x35F8DA0E8A31EF1B`
- **Build:** `1180`

**C# 签名:**
```csharp
void NETWORK_EARN_WAGE_PAYMENT(int amount, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_WAGE_PAYMENT_BONUS

- **命名空间:** `MONEY`
- **Hash:** `0x005ACA7100BD101D`
- **Build:** `1180`

**C# 签名:**
```csharp
void NETWORK_EARN_WAGE_PAYMENT_BONUS(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_EARN_YATCH_MISSION

- **命名空间:** `MONEY`
- **Hash:** `0xDE68E30D89F97132`
- **Build:** `2060`

**C# 签名:**
```csharp
void NETWORK_EARN_YATCH_MISSION(int amount, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_ECONOMY_HAS_FIXED_CRAZY_NUMBERS

- **命名空间:** `MONEY`
- **Hash:** `0x7C4FCCD2E4DEB394`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_ECONOMY_HAS_FIXED_CRAZY_NUMBERS()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_CAN_SPEND_FROM_BANK

- **命名空间:** `MONEY`
- **Hash:** `0xA31FD6A0865B6D14`
- **JHash:** `0xABED6020`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_CAN_SPEND_FROM_BANK(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if bank balance >= amount.
```

---

### NETWORK_GET_CAN_SPEND_FROM_BANK_AND_WALLET

- **命名空间:** `MONEY`
- **Hash:** `0xDC18531D7019A535`
- **JHash:** `0xCA23FD25`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_CAN_SPEND_FROM_BANK_AND_WALLET(int amount, int characterSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `characterSlot` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if bank balance + wallet balance >= amount.
```

---

### NETWORK_GET_CAN_SPEND_FROM_WALLET

- **命名空间:** `MONEY`
- **Hash:** `0xED5AB8860415BABA`
- **JHash:** `0x0EA2188C`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_CAN_SPEND_FROM_WALLET(int amount, int characterSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `characterSlot` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns true if wallet balance >= amount.
```

---

### NETWORK_GET_CAN_TRANSFER_CASH

- **命名空间:** `MONEY`
- **Hash:** `0x08E8EEADFD0DC4A0`
- **JHash:** `0x03461981`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_CAN_TRANSFER_CASH(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Returns false if amount > wallet balance or daily transfer limit has been hit.
```

---

### NETWORK_GET_EVC_BALANCE

- **命名空间:** `MONEY`
- **Hash:** `0x5D1E75F91C07DEE5`
- **JHash:** `0xF1EDB7F4`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_EVC_BALANCE()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_PLAYER_IS_HIGH_EARNER

- **命名空间:** `MONEY`
- **Hash:** `0xFB2456B2040A6A67`
- **JHash:** `0x63F093A6`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_GET_PLAYER_IS_HIGH_EARNER()
```

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_GET_PVC_BALANCE

- **命名空间:** `MONEY`
- **Hash:** `0x4F54F3B6C202FB4E`
- **JHash:** `0x56485B56`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_PVC_BALANCE()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_PVC_TRANSFER_BALANCE

- **命名空间:** `MONEY`
- **Hash:** `0x13A8DE2FD77D04F3`
- **JHash:** `0xC670C814`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_PVC_TRANSFER_BALANCE()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Retturns the same value as NETWORK_GET_REMAINING_TRANSFER_BALANCE.
```

---

### NETWORK_GET_REMAINING_TRANSFER_BALANCE

- **命名空间:** `MONEY`
- **Hash:** `0xEA560AC9EEB1E19B`
- **JHash:** `0xA9021211`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_REMAINING_TRANSFER_BALANCE()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Returns the same value as NETWORK_GET_PVC_TRANSFER_BALANCE.
```

---

### NETWORK_GET_STRING_BANK_BALANCE

- **命名空间:** `MONEY`
- **Hash:** `0xA6FA3979BED01B81`
- **JHash:** `0xAA7EA3BD`
- **Build:** `323`

**C# 签名:**
```csharp
string NETWORK_GET_STRING_BANK_BALANCE()
```

**返回值:** `string` (Native: `const char*`)

---

### NETWORK_GET_STRING_BANK_WALLET_BALANCE

- **命名空间:** `MONEY`
- **Hash:** `0x700AF71AE615E6DD`
- **JHash:** `0x7D4FD28C`
- **Build:** `323`

**C# 签名:**
```csharp
string NETWORK_GET_STRING_BANK_WALLET_BALANCE(int character)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `character` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

---

### NETWORK_GET_STRING_WALLET_BALANCE

- **命名空间:** `MONEY`
- **Hash:** `0xF9B10B529DCFB33B`
- **JHash:** `0xC1A11435`
- **Build:** `323`

**C# 签名:**
```csharp
string NETWORK_GET_STRING_WALLET_BALANCE(int characterSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `characterSlot` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

---

### NETWORK_GET_VC_BALANCE

- **命名空间:** `MONEY`
- **Hash:** `0x5CBAD97E059E1B94`
- **JHash:** `0xADF8F882`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_VC_BALANCE()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_VC_BANK_BALANCE

- **命名空间:** `MONEY`
- **Hash:** `0x76EF28DA05EA395A`
- **JHash:** `0x16184FB5`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_VC_BANK_BALANCE()
```

**返回值:** `int` (Native: `int`)

---

### NETWORK_GET_VC_WALLET_BALANCE

- **命名空间:** `MONEY`
- **Hash:** `0xA40F9C2623F6A8B5`
- **JHash:** `0x4F5B781C`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_GET_VC_WALLET_BALANCE(int characterSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `characterSlot` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### NETWORK_GIVE_PLAYER_JOBSHARE_CASH

- **命名空间:** `MONEY`
- **Hash:** `0xFB18DF9CB95E0105`
- **JHash:** `0xC6047FDB`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_GIVE_PLAYER_JOBSHARE_CASH(int amount, ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_INITIALIZE_CASH

- **命名空间:** `MONEY`
- **Hash:** `0x3DA5ECD1A56CBA6D`
- **JHash:** `0x66DA9935`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_INITIALIZE_CASH(int wallet, int bank)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `wallet` | `int` | `int` | - |
| `bank` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_MANUAL_DELETE_CHARACTER

- **命名空间:** `MONEY`
- **Hash:** `0x821418C727FCACD7`
- **Build:** `791`

**C# 签名:**
```csharp
void NETWORK_MANUAL_DELETE_CHARACTER(int characterSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `characterSlot` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_MONEY_CAN_BET

- **命名空间:** `MONEY`
- **Hash:** `0x81404F3DC124FE5B`
- **JHash:** `0x8474E6F0`
- **Build:** `323`

**C# 签名:**
```csharp
bool NETWORK_MONEY_CAN_BET(int amount, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_PAY_EMPLOYEE_WAGE

- **命名空间:** `MONEY`
- **Hash:** `0x5FD5ED82CBBE9989`
- **JHash:** `0xBE70849B`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_PAY_EMPLOYEE_WAGE(object p0, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_PAY_MATCH_ENTRY_FEE

- **命名空间:** `MONEY`
- **Hash:** `0x9346E14F2AF74D46`
- **JHash:** `0x224A3488`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_PAY_MATCH_ENTRY_FEE(int amount, string matchId, bool p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `matchId` | `const char*` | `string` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_RECEIVE_PLAYER_JOBSHARE_CASH

- **命名空间:** `MONEY`
- **Hash:** `0x56A3B51944C50598`
- **JHash:** `0x4ED71C1A`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_RECEIVE_PLAYER_JOBSHARE_CASH(int value, ref object gamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `int` | `int` | - |
| `gamerHandle` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_REFUND_CASH

- **命名空间:** `MONEY`
- **Hash:** `0xF9C812CD7C46E817`
- **JHash:** `0x07C92F21`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_REFUND_CASH(int index, string context, string reason, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |
| `context` | `const char*` | `string` | - |
| `reason` | `const char*` | `string` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
index
-------
See function sub_1005 in am_boat_taxi.ysc

context
----------
"BACKUP_VAGOS"
"BACKUP_LOST"
"BACKUP_FAMILIES"
"HIRE_MUGGER"
"HIRE_MERCENARY"
"BUY_CARDROPOFF"
"HELI_PICKUP"
"BOAT_PICKUP"
"CLEAR_WANTED"
"HEAD_2_HEAD"
"CHALLENGE"
"SHARE_LAST_JOB"
"DEFAULT"

reason
---------
"NOTREACHTARGET"
"TARGET_ESCAPE"
"DELIVERY_FAIL"
"NOT_USED"
"TEAM_QUIT"
"SERVER_ERROR"
"RECEIVE_LJ_L"
"CHALLENGE_PLAYER_LEFT"
"DEFAULT"

unk
-----
Unknown bool value


```

---

### NETWORK_SERVICE_EARN_GANGOPS_RIVAL_DELIVERY

- **命名空间:** `MONEY`
- **Hash:** `0x1B882107C23A9022`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_SERVICE_EARN_GANGOPS_RIVAL_DELIVERY(int earnedMoney)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `earnedMoney` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_AGENCY

- **命名空间:** `MONEY`
- **Hash:** `0x1B2120405080125C`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_SPEND_AGENCY(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_APARTMENT_UTILITIES

- **命名空间:** `MONEY`
- **Hash:** `0x1254B5B3925EFD3D`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_SPEND_APARTMENT_UTILITIES(int amount, bool p1, bool p2, ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_ARCADE

- **命名空间:** `MONEY`
- **Hash:** `0x43AA7FAC4E6D6687`
- **Build:** `1868`

**C# 签名:**
```csharp
void NETWORK_SPEND_ARCADE(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_ARCADE_MGMT

- **命名空间:** `MONEY`
- **Hash:** `0xB5B58E24868CB09E`
- **Build:** `1868`

**C# 签名:**
```csharp
void NETWORK_SPEND_ARCADE_MGMT(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_ARENA_PREMIUM

- **命名空间:** `MONEY`
- **Hash:** `0x619496D837EFD920`
- **Build:** `1604`

**C# 签名:**
```csharp
void NETWORK_SPEND_ARENA_PREMIUM(int amount, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_ARENA_SPECTATOR_BOX

- **命名空间:** `MONEY`
- **Hash:** `0x7049BF858601DC0F`
- **Build:** `1604`

**C# 签名:**
```csharp
void NETWORK_SPEND_ARENA_SPECTATOR_BOX(int amount, int type, bool p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `type` | `int` | `int` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
type either, 1 for cam spectate, 2 for drone
```

---

### NETWORK_SPEND_AUTOSHOP_MODIFY

- **命名空间:** `MONEY`
- **Hash:** `0x9BEA350D7C48061B`
- **Build:** `2372`

**C# 签名:**
```csharp
void NETWORK_SPEND_AUTOSHOP_MODIFY(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_BEACH_PARTY

- **命名空间:** `MONEY`
- **Hash:** `0x54ABA22FA6371249`
- **Build:** `2189`

**C# 签名:**
```csharp
void NETWORK_SPEND_BEACH_PARTY(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_BIKE_SHOP

- **命名空间:** `MONEY`
- **Hash:** `0x923AEA8E78F8DF0B`
- **Build:** `2699`

**C# 签名:**
```csharp
void NETWORK_SPEND_BIKE_SHOP(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_BOSS

- **命名空间:** `MONEY`
- **Hash:** `0xDBC966A01C02BCA7`
- **Build:** `573`

**C# 签名:**
```csharp
void NETWORK_SPEND_BOSS(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_BOUNTY_HUNTER_MISSION

- **命名空间:** `MONEY`
- **Hash:** `0x1BEA0CD93470BB1F`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_SPEND_BOUNTY_HUNTER_MISSION(int amount, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_BUSINESS_PROPERTY_FEES

- **命名空间:** `MONEY`
- **Hash:** `0x92D1CFDA1227FF1C`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_SPEND_BUSINESS_PROPERTY_FEES(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_BUY_AGENCY

- **命名空间:** `MONEY`
- **Hash:** `0xEA8CD3C9B3C35884`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_SPEND_BUY_AGENCY(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_BUY_ARCADE

- **命名空间:** `MONEY`
- **Hash:** `0x870289A558348378`
- **Build:** `1868`

**C# 签名:**
```csharp
void NETWORK_SPEND_BUY_ARCADE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_BUY_ARENA

- **命名空间:** `MONEY`
- **Hash:** `0x40D5DA9550B7CB46`
- **Build:** `1604`

**C# 签名:**
```csharp
void NETWORK_SPEND_BUY_ARENA(int amount, bool p1, bool p2, string p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_BUY_AUTOSHOP

- **命名空间:** `MONEY`
- **Hash:** `0xEEB7E5D1FEB20869`
- **Build:** `2372`

**C# 签名:**
```csharp
void NETWORK_SPEND_BUY_AUTOSHOP(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_BUY_CASINO

- **命名空间:** `MONEY`
- **Hash:** `0x34A6FC4D06C4DA0F`
- **Build:** `1734`

**C# 签名:**
```csharp
void NETWORK_SPEND_BUY_CASINO(int amount, bool p1, bool p2, ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_BUY_SUB

- **命名空间:** `MONEY`
- **Hash:** `0x90CD7C6871FBF1B4`
- **Build:** `2189`

**C# 签名:**
```csharp
void NETWORK_SPEND_BUY_SUB(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_CAR_CLUB_BAR

- **命名空间:** `MONEY`
- **Hash:** `0x925227803A0EAA1B`
- **Build:** `2372`

**C# 签名:**
```csharp
void NETWORK_SPEND_CAR_CLUB_BAR(object p0, bool p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_CAR_CLUB_MEMBERSHIP

- **命名空间:** `MONEY`
- **Hash:** `0x1464E17207CD36E2`
- **Build:** `2372`

**C# 签名:**
```csharp
void NETWORK_SPEND_CAR_CLUB_MEMBERSHIP(int amount1, object p1, object p2, int amount2, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount1` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `amount2` | `int` | `int` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_CAR_CLUB_TAKEOVER

- **命名空间:** `MONEY`
- **Hash:** `0xD1E46824E6FB92B5`
- **Build:** `2372`

**C# 签名:**
```csharp
void NETWORK_SPEND_CAR_CLUB_TAKEOVER(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_CASINO_CLUB

- **命名空间:** `MONEY`
- **Hash:** `0xC991C255AA6D90B2`
- **Build:** `2189`

**C# 签名:**
```csharp
void NETWORK_SPEND_CASINO_CLUB(int amount1, object p1, bool p2, object p3, int p4, int p5, int p6, int amount2, object p8)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount1` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `int` | `int` | - |
| `p5` | `int` | `int` | - |
| `p6` | `int` | `int` | - |
| `amount2` | `int` | `int` | - |
| `p8` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_CASINO_GENERIC

- **命名空间:** `MONEY`
- **Hash:** `0x88BF9B612B84D3C3`
- **Build:** `1734`

**C# 签名:**
```csharp
void NETWORK_SPEND_CASINO_GENERIC(int amount, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_CASINO_HEIST

- **命名空间:** `MONEY`
- **Hash:** `0xD30E8392F407C328`
- **Build:** `1868`

**C# 签名:**
```csharp
void NETWORK_SPEND_CASINO_HEIST(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9, object p10)
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
| `p10` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_CASINO_HEIST_SKIP_MISSION

- **命名空间:** `MONEY`
- **Hash:** `0x487009DD91D93429`
- **Build:** `1868`

**C# 签名:**
```csharp
void NETWORK_SPEND_CASINO_HEIST_SKIP_MISSION(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_CASINO_MEMBERSHIP

- **命名空间:** `MONEY`
- **Hash:** `0xFBBE0570EDF39D46`
- **Build:** `1734`

**C# 签名:**
```csharp
void NETWORK_SPEND_CASINO_MEMBERSHIP(int amount, bool p1, bool p2, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_COMP_SUV

- **命名空间:** `MONEY`
- **Hash:** `0xD86581F9E7CDA383`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_SPEND_COMP_SUV(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_EARNED_FROM_BANK_AND_WALLETS

- **命名空间:** `MONEY`
- **Hash:** `0x9B5016A6433A68C5`
- **JHash:** `0xBD64F1B7`
- **Build:** `323`

**C# 签名:**
```csharp
int NETWORK_SPEND_EARNED_FROM_BANK_AND_WALLETS(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Hardcoded to return 0.
```

---

### NETWORK_SPEND_GANGOPS_CANNON

- **命名空间:** `MONEY`
- **Hash:** `0x771ADB0E7635B7BF`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_SPEND_GANGOPS_CANNON(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_GANGOPS_REPAIR_COST

- **命名空间:** `MONEY`
- **Hash:** `0x2A7CEC72C3443BCC`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_SPEND_GANGOPS_REPAIR_COST(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_GANGOPS_SKIP_MISSION

- **命名空间:** `MONEY`
- **Hash:** `0xDA947AE8880D5C18`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_SPEND_GANGOPS_SKIP_MISSION(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_GANGOPS_START_STRAND

- **命名空间:** `MONEY`
- **Hash:** `0xA19EC0786E326E06`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_SPEND_GANGOPS_START_STRAND(int type, int amount, bool p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `type` | `int` | `int` | - |
| `amount` | `int` | `int` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_GANGOPS_TRIP_SKIP

- **命名空间:** `MONEY`
- **Hash:** `0x5ECE6FD7B4EC8D6A`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_SPEND_GANGOPS_TRIP_SKIP(int amount, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_GOON

- **命名空间:** `MONEY`
- **Hash:** `0x08A1B82B91900682`
- **Build:** `573`

**C# 签名:**
```csharp
void NETWORK_SPEND_GOON(int p0, int p1, int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_GUNRUNNING

- **命名空间:** `MONEY`
- **Hash:** `0x2CEB0E0BC2A77C05`
- **Build:** `2699`

**C# 签名:**
```csharp
void NETWORK_SPEND_GUNRUNNING(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_HIDDEN

- **命名空间:** `MONEY`
- **Hash:** `0xBF8793B91EA094A7`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_SPEND_HIDDEN(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_INTERACTION_MENU_ABILITY

- **命名空间:** `MONEY`
- **Hash:** `0x93AA4165CB67E925`
- **Build:** `2372`

**C# 签名:**
```csharp
void NETWORK_SPEND_INTERACTION_MENU_ABILITY(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_ISLAND_HEIST

- **命名空间:** `MONEY`
- **Hash:** `0xE86689E5F82DE429`
- **Build:** `2189`

**C# 签名:**
```csharp
void NETWORK_SPEND_ISLAND_HEIST(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_MAKE_IT_RAIN

- **命名空间:** `MONEY`
- **Hash:** `0xE5F5A060439C2F5D`
- **Build:** `1604`

**C# 签名:**
```csharp
void NETWORK_SPEND_MAKE_IT_RAIN(int amount, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_NIGHTCLUB_AND_WAREHOUSE

- **命名空间:** `MONEY`
- **Hash:** `0x65482BFD0923C8A1`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_SPEND_NIGHTCLUB_AND_WAREHOUSE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_NIGHTCLUB_BAR_DRINK

- **命名空间:** `MONEY`
- **Hash:** `0xDD21B016E4289465`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_SPEND_NIGHTCLUB_BAR_DRINK(int amount, object p1, bool p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_PLAY_ARCADE

- **命名空间:** `MONEY`
- **Hash:** `0xEAD3D81F2C3A1458`
- **Build:** `1868`

**C# 签名:**
```csharp
void NETWORK_SPEND_PLAY_ARCADE(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_SET_COMMON_FIELDS

- **命名空间:** `MONEY`
- **Hash:** `0xB9F7A469460E7A4A`
- **Build:** `2372`

**C# 签名:**
```csharp
void NETWORK_SPEND_SET_COMMON_FIELDS(object p0, object p1, object p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_SET_DISCOUNT

- **命名空间:** `MONEY`
- **Hash:** `0x7E2F4E8F44CAF4E0`
- **Build:** `2699`

**C# 签名:**
```csharp
void NETWORK_SPEND_SET_DISCOUNT(bool p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_SOURCE_BIKE

- **命名空间:** `MONEY`
- **Hash:** `0xD9DF467CBE4398C8`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_SPEND_SOURCE_BIKE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_SPIN_THE_WHEEL_PAYMENT

- **命名空间:** `MONEY`
- **Hash:** `0x9A5BD1D0000B339C`
- **Build:** `1604`

**C# 签名:**
```csharp
void NETWORK_SPEND_SPIN_THE_WHEEL_PAYMENT(int amount, object p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_SUBMARINE

- **命名空间:** `MONEY`
- **Hash:** `0x6C8BC1488527AAAB`
- **Build:** `2189`

**C# 签名:**
```csharp
void NETWORK_SPEND_SUBMARINE(object p0, object p1, object p2, object p3, object p4, object p5)
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

### NETWORK_SPEND_SUPPLY

- **命名空间:** `MONEY`
- **Hash:** `0xEBD482B82ACB8BAD`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_SPEND_SUPPLY(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_SUV_FST_TRVL

- **命名空间:** `MONEY`
- **Hash:** `0x61A2DF64ED2D396E`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_SPEND_SUV_FST_TRVL(int p0, bool p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_UPGRADE_AGENCY

- **命名空间:** `MONEY`
- **Hash:** `0x6CCA64840589A3B6`
- **Build:** `2545`

**C# 签名:**
```csharp
void NETWORK_SPEND_UPGRADE_AGENCY(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_UPGRADE_ARCADE

- **命名空间:** `MONEY`
- **Hash:** `0x5574637681911FDA`
- **Build:** `1868`

**C# 签名:**
```csharp
void NETWORK_SPEND_UPGRADE_ARCADE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_UPGRADE_ARENA

- **命名空间:** `MONEY`
- **Hash:** `0x037ABB06825D7AB1`
- **Build:** `1604`

**C# 签名:**
```csharp
void NETWORK_SPEND_UPGRADE_ARENA(int amount, bool p1, bool p2, string p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_UPGRADE_AUTOSHOP

- **命名空间:** `MONEY`
- **Hash:** `0xDD829AA198FDC46C`
- **Build:** `2372`

**C# 签名:**
```csharp
void NETWORK_SPEND_UPGRADE_AUTOSHOP(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_UPGRADE_CASINO

- **命名空间:** `MONEY`
- **Hash:** `0x4740D62BC1B4EBEA`
- **Build:** `1734`

**C# 签名:**
```csharp
void NETWORK_SPEND_UPGRADE_CASINO(int amount, bool p1, bool p2, ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_UPGRADE_SUB

- **命名空间:** `MONEY`
- **Hash:** `0x89049A84065CE68E`
- **Build:** `2189`

**C# 签名:**
```csharp
void NETWORK_SPEND_UPGRADE_SUB(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPEND_VEHICLE_REQUESTED

- **命名空间:** `MONEY`
- **Hash:** `0x02D24A35A9CC3503`
- **Build:** `2699`

**C# 签名:**
```csharp
void NETWORK_SPEND_VEHICLE_REQUESTED(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_AMMO_DROP

- **命名空间:** `MONEY`
- **Hash:** `0xB162DC95C0A3317B`
- **JHash:** `0x4B643076`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_AMMO_DROP(object p0, bool p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_ARENA_JOIN_SPECTATOR

- **命名空间:** `MONEY`
- **Hash:** `0x14EAEA58F93B55AF`
- **Build:** `1604`

**C# 签名:**
```csharp
void NETWORK_SPENT_ARENA_JOIN_SPECTATOR(int amount, object p1, bool p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_ARREST_BAIL

- **命名空间:** `MONEY`
- **Hash:** `0x812F5488B1B2A299`
- **JHash:** `0x5AEE2FC1`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_ARREST_BAIL(object p0, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_BALLISTIC_EQUIPMENT

- **命名空间:** `MONEY`
- **Hash:** `0x5D97630A8A0EF123`
- **Build:** `1103`

**C# 签名:**
```csharp
void NETWORK_SPENT_BALLISTIC_EQUIPMENT(int amount, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_BANK_INTEREST

- **命名空间:** `MONEY`
- **Hash:** `0xCA230C9682556CF1`
- **JHash:** `0xF02E92D7`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_BANK_INTEREST(int p0, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_BETTING

- **命名空间:** `MONEY`
- **Hash:** `0x1C436FD11FFA692F`
- **JHash:** `0xF8A07513`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_BETTING(int amount, int p1, string matchId, bool p3, bool p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `matchId` | `const char*` | `string` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_BOAT_PICKUP

- **命名空间:** `MONEY`
- **Hash:** `0x524EE43A37232C00`
- **JHash:** `0xB241CABD`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_BOAT_PICKUP(object p0, bool p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_BOSS_GOON

- **命名空间:** `MONEY`
- **Hash:** `0xFFBE02CD385356BD`
- **Build:** `573`

**C# 签名:**
```csharp
bool NETWORK_SPENT_BOSS_GOON(int amount, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### NETWORK_SPENT_BOUNTY

- **命名空间:** `MONEY`
- **Hash:** `0x29B260B84947DFCC`
- **JHash:** `0x3401FC96`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_BOUNTY(object p0, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_BULL_SHARK

- **命名空间:** `MONEY`
- **Hash:** `0xA6DD8458CE24012C`
- **JHash:** `0xDE7D398C`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_BULL_SHARK(object p0, bool p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_BUY_BASE

- **命名空间:** `MONEY`
- **Hash:** `0x4EA3F425C7744D21`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_SPENT_BUY_BASE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_BUY_BUNKER

- **命名空间:** `MONEY`
- **Hash:** `0x12D148D26538D0F9`
- **Build:** `1103`

**C# 签名:**
```csharp
void NETWORK_SPENT_BUY_BUNKER(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_BUY_OFFTHERADAR

- **命名空间:** `MONEY`
- **Hash:** `0xA628A745E2275C5D`
- **JHash:** `0x20DDCF2F`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_BUY_OFFTHERADAR(object p0, bool p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_BUY_PASSIVE_MODE

- **命名空间:** `MONEY`
- **Hash:** `0x6D3A430D1A809179`
- **JHash:** `0x7E97C92C`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_BUY_PASSIVE_MODE(object p0, bool p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_BUY_REVEAL_PLAYERS

- **命名空间:** `MONEY`
- **Hash:** `0x6E176F1B18BC0637`
- **JHash:** `0x2F7836E2`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_BUY_REVEAL_PLAYERS(object p0, bool p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_BUY_TILTROTOR

- **命名空间:** `MONEY`
- **Hash:** `0x0CCE73BC7A11E885`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_SPENT_BUY_TILTROTOR(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_BUY_TRUCK

- **命名空间:** `MONEY`
- **Hash:** `0xAC272C0AE01B4BD8`
- **Build:** `1103`

**C# 签名:**
```csharp
void NETWORK_SPENT_BUY_TRUCK(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_BUY_WANTEDLEVEL

- **命名空间:** `MONEY`
- **Hash:** `0xE1B13771A843C4F6`
- **JHash:** `0xE7CB4F95`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_BUY_WANTEDLEVEL(object p0, ref object p1, bool p2, bool p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any*` | `ref object` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_CALL_PLAYER

- **命名空间:** `MONEY`
- **Hash:** `0xACDE7185B374177C`
- **JHash:** `0x1A89B5FC`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_CALL_PLAYER(object p0, ref object p1, bool p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any*` | `ref object` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_CARGO_SOURCING

- **命名空间:** `MONEY`
- **Hash:** `0x948705F6F9C50824`
- **Build:** `2699`

**C# 签名:**
```csharp
void NETWORK_SPENT_CARGO_SOURCING(object p0, object p1, object p2, object p3, object p4, object p5, object p6)
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

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_CARWASH

- **命名空间:** `MONEY`
- **Hash:** `0xEC03C719DB2F4306`
- **JHash:** `0x8283E028`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_CARWASH(object p0, object p1, object p2, bool p3, bool p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_CASH_DROP

- **命名空间:** `MONEY`
- **Hash:** `0x289016EC778D60E0`
- **JHash:** `0x87BD1D11`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_CASH_DROP(int amount, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_CHANGE_APPEARANCE

- **命名空间:** `MONEY`
- **Hash:** `0x5F456788B05FAEAC`
- **Build:** `944`

**C# 签名:**
```csharp
void NETWORK_SPENT_CHANGE_APPEARANCE(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_CINEMA

- **命名空间:** `MONEY`
- **Hash:** `0x6B38ECB05A63A685`
- **JHash:** `0x1100CAF5`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_CINEMA(object p0, object p1, bool p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_EMPLOY_ASSASSINS

- **命名空间:** `MONEY`
- **Hash:** `0x5BBBD92186E1F1C5`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_SPENT_EMPLOY_ASSASSINS(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_FROM_ROCKSTAR

- **命名空间:** `MONEY`
- **Hash:** `0x6A445B64ED7ABEB5`
- **JHash:** `0x54198922`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_FROM_ROCKSTAR(int p0, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_HANGAR_STAFF_CHARGES

- **命名空间:** `MONEY`
- **Hash:** `0xB1F1346FD57685D7`
- **Build:** `1180`

**C# 签名:**
```csharp
void NETWORK_SPENT_HANGAR_STAFF_CHARGES(int amount, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_HANGAR_UTILITY_CHARGES

- **命名空间:** `MONEY`
- **Hash:** `0xB18AC2ECBB15CB6A`
- **Build:** `1180`

**C# 签名:**
```csharp
void NETWORK_SPENT_HANGAR_UTILITY_CHARGES(int amount, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_HELI_PICKUP

- **命名空间:** `MONEY`
- **Hash:** `0x7BF1D73DB2ECA492`
- **JHash:** `0x27EEBCAB`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_HELI_PICKUP(object p0, bool p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_HIRE_MERCENARY

- **命名空间:** `MONEY`
- **Hash:** `0xE7B80E2BF9D80BD6`
- **JHash:** `0x99CF02C4`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_HIRE_MERCENARY(object p0, bool p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_HIRE_MUGGER

- **命名空间:** `MONEY`
- **Hash:** `0xE404BFB981665BF0`
- **JHash:** `0xE792C4A5`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_HIRE_MUGGER(object p0, bool p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Only used once in a script (am_contact_requests)
p1 = 0
p2 = 1
```

---

### NETWORK_SPENT_HOLDUPS

- **命名空间:** `MONEY`
- **Hash:** `0xD9B86B9872039763`
- **JHash:** `0x1B3803B1`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_HOLDUPS(object p0, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_IMPORT_EXPORT_REPAIR

- **命名空间:** `MONEY`
- **Hash:** `0xC1952F3773BA18FE`
- **Build:** `944`

**C# 签名:**
```csharp
void NETWORK_SPENT_IMPORT_EXPORT_REPAIR(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_IN_STRIPCLUB

- **命名空间:** `MONEY`
- **Hash:** `0xEE99784E4467689C`
- **JHash:** `0x8957038E`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_IN_STRIPCLUB(object p0, bool p1, object p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_JOB_SKIP

- **命名空间:** `MONEY`
- **Hash:** `0x28F174A67B8D0C2F`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_JOB_SKIP(int amount, string matchId, bool p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `matchId` | `const char*` | `string` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_JUKEBOX

- **命名空间:** `MONEY`
- **Hash:** `0x5BCDE0F640C773D2`
- **Build:** `877`

**C# 签名:**
```csharp
void NETWORK_SPENT_JUKEBOX(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_MC_ABILITY

- **命名空间:** `MONEY`
- **Hash:** `0xD7CCCBA28C4ECAF0`
- **Build:** `877`

**C# 签名:**
```csharp
void NETWORK_SPENT_MC_ABILITY(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_MOVE_SUBMARINE

- **命名空间:** `MONEY`
- **Hash:** `0xCD4D66B43B1DD28D`
- **Build:** `2189`

**C# 签名:**
```csharp
void NETWORK_SPENT_MOVE_SUBMARINE(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_MOVE_YACHT

- **命名空间:** `MONEY`
- **Hash:** `0xE7DF4E0545DFB56E`
- **Build:** `573`

**C# 签名:**
```csharp
void NETWORK_SPENT_MOVE_YACHT(int amount, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_NIGHTCLUB_ENTRY_FEE

- **命名空间:** `MONEY`
- **Hash:** `0x876056684281655D`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_SPENT_NIGHTCLUB_ENTRY_FEE(int player, int amount, object p1, bool p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `player` | `Player` | `int` | - |
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_NO_COPS

- **命名空间:** `MONEY`
- **Hash:** `0xD5BB406F4E04019F`
- **JHash:** `0x2E51C61C`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_NO_COPS(object p0, bool p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_ORDER_BODYGUARD_VEHICLE

- **命名空间:** `MONEY`
- **Hash:** `0xE8B0B270B6E7C76E`
- **Build:** `757`

**C# 签名:**
```csharp
void NETWORK_SPENT_ORDER_BODYGUARD_VEHICLE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_ORDER_WAREHOUSE_VEHICLE

- **命名空间:** `MONEY`
- **Hash:** `0x05F04155A226FBBF`
- **Build:** `757`

**C# 签名:**
```csharp
void NETWORK_SPENT_ORDER_WAREHOUSE_VEHICLE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_PAY_BUSINESS_SUPPLIES

- **命名空间:** `MONEY`
- **Hash:** `0x0035BB914316F1E3`
- **Build:** `877`

**C# 签名:**
```csharp
void NETWORK_SPENT_PAY_BUSINESS_SUPPLIES(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_PAY_VEHICLE_INSURANCE_PREMIUM

- **命名空间:** `MONEY`
- **Hash:** `0x9FF28D88C766E3E8`
- **JHash:** `0x4E665BB2`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_PAY_VEHICLE_INSURANCE_PREMIUM(int amount, uint vehicleModel, ref object gamerHandle, bool notBankrupt, bool hasTheMoney)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `vehicleModel` | `Hash` | `uint` | - |
| `gamerHandle` | `Any*` | `ref object` | - |
| `notBankrupt` | `BOOL` | `bool` | - |
| `hasTheMoney` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
According to how I understood this in the freemode script alone,
The first parameter is determined by a function named, func_5749 within the freemode script which has a list of all the vehicles and a set price to return which some vehicles deals with globals as well. So the first parameter is basically the set in stone insurance cost it's gonna charge you for that specific vehicle model.

The second parameter whoever put it was right, they call GET_ENTITY_MODEL with the vehicle as the paremeter.

The third parameter is the network handle as they call their little struct<13> func or atleast how the script decompiled it to look which in lamens terms just returns the network handle of the previous owner based on DECOR_GET_INT(vehicle, "Previous_Owner").

The fourth parameter is a bool that returns true/false depending on if your bank balance is greater then 0.

The fifth and last parameter is a bool that returns true/false depending on if you have the money for the car based on the cost returned by func_5749. In the freemode script eg,
bool hasTheMoney = MONEY::_GET_BANK_BALANCE() < carCost.
```

---

### NETWORK_SPENT_PA_HELI_PICKUP

- **命名空间:** `MONEY`
- **Hash:** `0x0FE8E1FCD2B86B33`
- **Build:** `757`

**C# 签名:**
```csharp
void NETWORK_SPENT_PA_HELI_PICKUP(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_PA_SERVICE_DANCER

- **命名空间:** `MONEY`
- **Hash:** `0xB49ECA122467D05F`
- **Build:** `757`

**C# 签名:**
```csharp
void NETWORK_SPENT_PA_SERVICE_DANCER(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_PA_SERVICE_HELI

- **命名空间:** `MONEY`
- **Hash:** `0x112209CE0290C03A`
- **Build:** `757`

**C# 签名:**
```csharp
void NETWORK_SPENT_PA_SERVICE_HELI(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_PA_SERVICE_IMPOUND

- **命名空间:** `MONEY`
- **Hash:** `0xE23ADC6FCB1F29AE`
- **Build:** `757`

**C# 签名:**
```csharp
void NETWORK_SPENT_PA_SERVICE_IMPOUND(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_PA_SERVICE_SNACK

- **命名空间:** `MONEY`
- **Hash:** `0x0D30EB83668E63C5`
- **Build:** `757`

**C# 签名:**
```csharp
void NETWORK_SPENT_PA_SERVICE_SNACK(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_PA_SERVICE_VEHICLE

- **命名空间:** `MONEY`
- **Hash:** `0xED5FD7AF10F5E262`
- **Build:** `757`

**C# 签名:**
```csharp
void NETWORK_SPENT_PA_SERVICE_VEHICLE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_PLAYER_HEALTHCARE

- **命名空间:** `MONEY`
- **Hash:** `0x7C99101F7FCE2EE5`
- **JHash:** `0x3D96A21C`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_PLAYER_HEALTHCARE(int p0, int p1, bool p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_PROSTITUTES

- **命名空间:** `MONEY`
- **Hash:** `0xB21B89501CFAC79E`
- **JHash:** `0x78436D07`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_PROSTITUTES(object p0, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_PURCHASE_BUSINESS_PROPERTY

- **命名空间:** `MONEY`
- **Hash:** `0x6FD97159FE3C971A`
- **Build:** `877`

**C# 签名:**
```csharp
void NETWORK_SPENT_PURCHASE_BUSINESS_PROPERTY(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_PURCHASE_CLUB_HOUSE

- **命名空间:** `MONEY`
- **Hash:** `0x998E18CEB44487FC`
- **Build:** `877`

**C# 签名:**
```csharp
void NETWORK_SPENT_PURCHASE_CLUB_HOUSE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_PURCHASE_HACKER_TRUCK

- **命名空间:** `MONEY`
- **Hash:** `0x2A93C46AAB1EACC9`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_SPENT_PURCHASE_HACKER_TRUCK(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_PURCHASE_HANGAR

- **命名空间:** `MONEY`
- **Hash:** `0xCCB339CC970452DA`
- **Build:** `1180`

**C# 签名:**
```csharp
void NETWORK_SPENT_PURCHASE_HANGAR(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_PURCHASE_IMPEXP_WAREHOUSE_PROPERTY

- **命名空间:** `MONEY`
- **Hash:** `0x33981D6804E62F49`
- **Build:** `944`

**C# 签名:**
```csharp
void NETWORK_SPENT_PURCHASE_IMPEXP_WAREHOUSE_PROPERTY(int amount, ref object data, bool p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `data` | `Any*` | `ref object` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_PURCHASE_NIGHTCLUB_AND_WAREHOUSE

- **命名空间:** `MONEY`
- **Hash:** `0xED76D195E6E3BF7F`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_SPENT_PURCHASE_NIGHTCLUB_AND_WAREHOUSE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_PURCHASE_OFFICE_GARAGE

- **命名空间:** `MONEY`
- **Hash:** `0xB4C2EC463672474E`
- **Build:** `944`

**C# 签名:**
```csharp
void NETWORK_SPENT_PURCHASE_OFFICE_GARAGE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_PURCHASE_OFFICE_PROPERTY

- **命名空间:** `MONEY`
- **Hash:** `0x69EF772B192614C1`
- **Build:** `757`

**C# 签名:**
```csharp
void NETWORK_SPENT_PURCHASE_OFFICE_PROPERTY(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_PURCHASE_WAREHOUSE_PROPERTY

- **命名空间:** `MONEY`
- **Hash:** `0xBD0EFB25CCA8F97A`
- **Build:** `757`

**C# 签名:**
```csharp
void NETWORK_SPENT_PURCHASE_WAREHOUSE_PROPERTY(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_RDR_HATCHET_BONUS

- **命名空间:** `MONEY`
- **Hash:** `0xE284D46FFDB82E36`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_SPENT_RDR_HATCHET_BONUS(int amount, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_REHIRE_DJ

- **命名空间:** `MONEY`
- **Hash:** `0xF6C8A544E4CF14FC`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_SPENT_REHIRE_DJ(int amount, object p1, bool p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_RENAME_ORGANIZATION

- **命名空间:** `MONEY`
- **Hash:** `0xFC4EE00A7B3BFB76`
- **Build:** `573`

**C# 签名:**
```csharp
void NETWORK_SPENT_RENAME_ORGANIZATION(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_REQUEST_HEIST

- **命名空间:** `MONEY`
- **Hash:** `0x9D26502BB97BFE62`
- **JHash:** `0xF4287778`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_REQUEST_HEIST(object p0, bool p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_REQUEST_JOB

- **命名空间:** `MONEY`
- **Hash:** `0x8204DA7934DF3155`
- **JHash:** `0xD57A5125`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_REQUEST_JOB(object p0, bool p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_ROBBED_BY_MUGGER

- **命名空间:** `MONEY`
- **Hash:** `0x995A65F15F581359`
- **JHash:** `0xE6AAA0D5`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_ROBBED_BY_MUGGER(int amount, bool p1, bool p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_TAXI

- **命名空间:** `MONEY`
- **Hash:** `0x17C3A7D31EAE39F9`
- **JHash:** `0x1F3DB3E3`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_TAXI(int amount, bool p1, bool p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_TELESCOPE

- **命名空间:** `MONEY`
- **Hash:** `0x7FE61782AD94CC09`
- **JHash:** `0xAE7FF044`
- **Build:** `323`

**C# 签名:**
```csharp
void NETWORK_SPENT_TELESCOPE(object p0, bool p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_TRADE_BUSINESS_PROPERTY

- **命名空间:** `MONEY`
- **Hash:** `0xA51B086B0B2C0F7A`
- **Build:** `877`

**C# 签名:**
```csharp
void NETWORK_SPENT_TRADE_BUSINESS_PROPERTY(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_TRADE_IMPEXP_WAREHOUSE_PROPERTY

- **命名空间:** `MONEY`
- **Hash:** `0x2FAB6614CE22E196`
- **Build:** `944`

**C# 签名:**
```csharp
void NETWORK_SPENT_TRADE_IMPEXP_WAREHOUSE_PROPERTY(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_UPGRADE_BASE

- **命名空间:** `MONEY`
- **Hash:** `0x3DD3F33A5D55EA6F`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_SPENT_UPGRADE_BASE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_UPGRADE_BUSINESS_PROPERTY

- **命名空间:** `MONEY`
- **Hash:** `0x675D19C6067CAE08`
- **Build:** `877`

**C# 签名:**
```csharp
void NETWORK_SPENT_UPGRADE_BUSINESS_PROPERTY(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_UPGRADE_CLUB_HOUSE

- **命名空间:** `MONEY`
- **Hash:** `0xFA07759E6FDDD7CF`
- **Build:** `877`

**C# 签名:**
```csharp
void NETWORK_SPENT_UPGRADE_CLUB_HOUSE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_UPGRADE_HACKER_TRUCK

- **命名空间:** `MONEY`
- **Hash:** `0x226C284C830D0CA8`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_SPENT_UPGRADE_HACKER_TRUCK(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_UPGRADE_HANGAR

- **命名空间:** `MONEY`
- **Hash:** `0x615EB504B0788DAF`
- **Build:** `1180`

**C# 签名:**
```csharp
void NETWORK_SPENT_UPGRADE_HANGAR(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_UPGRADE_IMPEXP_WAREHOUSE_PROPERTY

- **命名空间:** `MONEY`
- **Hash:** `0x4128464231E3CA0B`
- **Build:** `944`

**C# 签名:**
```csharp
void NETWORK_SPENT_UPGRADE_IMPEXP_WAREHOUSE_PROPERTY(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_UPGRADE_NIGHTCLUB_AND_WAREHOUSE

- **命名空间:** `MONEY`
- **Hash:** `0x1DC9B749E7AE282B`
- **Build:** `1493`

**C# 签名:**
```csharp
void NETWORK_SPENT_UPGRADE_NIGHTCLUB_AND_WAREHOUSE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_UPGRADE_OFFICE_GARAGE

- **命名空间:** `MONEY`
- **Hash:** `0x2AFC2D19B50797F2`
- **Build:** `944`

**C# 签名:**
```csharp
void NETWORK_SPENT_UPGRADE_OFFICE_GARAGE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_UPGRADE_OFFICE_PROPERTY

- **命名空间:** `MONEY`
- **Hash:** `0x8E243837643D9583`
- **Build:** `757`

**C# 签名:**
```csharp
void NETWORK_SPENT_UPGRADE_OFFICE_PROPERTY(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_UPGRADE_TILTROTOR

- **命名空间:** `MONEY`
- **Hash:** `0x165E135D6DFA2907`
- **Build:** `1290`

**C# 签名:**
```csharp
void NETWORK_SPENT_UPGRADE_TILTROTOR(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_UPGRADE_TRUCK

- **命名空间:** `MONEY`
- **Hash:** `0x365E877C61D6988B`
- **Build:** `1103`

**C# 签名:**
```csharp
void NETWORK_SPENT_UPGRADE_TRUCK(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_UPGRADE_WAREHOUSE_PROPERTY

- **命名空间:** `MONEY`
- **Hash:** `0xA95F667A755725DA`
- **Build:** `757`

**C# 签名:**
```csharp
void NETWORK_SPENT_UPGRADE_WAREHOUSE_PROPERTY(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_UPRADE_BUNKER

- **命名空间:** `MONEY`
- **Hash:** `0x0C82D21A77C22D49`
- **Build:** `1103`

**C# 签名:**
```csharp
void NETWORK_SPENT_UPRADE_BUNKER(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_SPENT_VEHICLE_EXPORT_MODS

- **命名空间:** `MONEY`
- **Hash:** `0xA75CCF58A60A5FD1`
- **Build:** `944`

**C# 签名:**
```csharp
void NETWORK_SPENT_VEHICLE_EXPORT_MODS(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9)
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

### NETWORK_SPENT_WAGER

- **命名空间:** `MONEY`
- **Hash:** `0xD99DB210089617FE`
- **Build:** `573`

**C# 签名:**
```csharp
void NETWORK_SPENT_WAGER(object p0, object p1, int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### NETWORK_YOHAN_SOURCE_GOODS

- **命名空间:** `MONEY`
- **Hash:** `0x59498BC8B1C8B15C`
- **Build:** `2699`

**C# 签名:**
```csharp
void NETWORK_YOHAN_SOURCE_GOODS(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### ORDER_BOSS_VEHICLE

- **命名空间:** `STATS`
- **Hash:** `0xCEA553E35C2246E1`
- **Build:** `573`

**C# 签名:**
```csharp
void ORDER_BOSS_VEHICLE(object p0, object p1, uint vehicleHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `vehicleHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### PACKED_STAT_GET_INT_STAT_INDEX

- **命名空间:** `STATS`
- **Hash:** `0x94F12ABF9C79E339`
- **JHash:** `0xCA160BCC`
- **Build:** `323`

**C# 签名:**
```csharp
int PACKED_STAT_GET_INT_STAT_INDEX(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Needs more research. Possibly used to calculate the "mask" when calling "STAT_SET_MASKED_INT"?
```

---

### PLAYSTATS_ABANDONED_MC

- **命名空间:** `STATS`
- **Hash:** `0xD558BEC0BBA7E8D2`
- **Build:** `877`

**C# 签名:**
```csharp
void PLAYSTATS_ABANDONED_MC(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_ACQUIRED_HIDDEN_PACKAGE

- **命名空间:** `STATS`
- **Hash:** `0x79AB33F0FBFAC40C`
- **JHash:** `0x8D5C7B37`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_ACQUIRED_HIDDEN_PACKAGE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_ACTIVITY_DONE

- **命名空间:** `STATS`
- **Hash:** `0xA071E0ED98F91286`
- **JHash:** `0x1A66945F`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_ACTIVITY_DONE(int p0, int activityId, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `activityId` | `int` | `int` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_APPEND_DIRECTOR_METRIC

- **命名空间:** `STATS`
- **Hash:** `0x46326E13DA4E0546`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_APPEND_DIRECTOR_METRIC(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_ARCADE_CABINET

- **命名空间:** `STATS`
- **Hash:** `0xF9096193DF1F99D4`
- **Build:** `1868`

**C# 签名:**
```csharp
void PLAYSTATS_ARCADE_CABINET(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_ARCADE_GAME

- **命名空间:** `STATS`
- **Hash:** `0x533A7D1EA58DF958`
- **Build:** `1734`

**C# 签名:**
```csharp
void PLAYSTATS_ARCADE_GAME(object p0, object p1, object p2, object p3, object p4, object p5, object p6)
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

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_ARCADE_LOVE_MATCH

- **命名空间:** `STATS`
- **Hash:** `0x4FCDBD3F0A813C25`
- **Build:** `1868`

**C# 签名:**
```csharp
void PLAYSTATS_ARCADE_LOVE_MATCH(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_ARENA_WARS_ENDED

- **命名空间:** `STATS`
- **Hash:** `0xB479D9F0D48A1BC5`
- **Build:** `1604`

**C# 签名:**
```csharp
void PLAYSTATS_ARENA_WARS_ENDED(ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_ARENA_WARS_SPECTATOR

- **命名空间:** `STATS`
- **Hash:** `0x6F4F599753F8200A`
- **Build:** `1604`

**C# 签名:**
```csharp
void PLAYSTATS_ARENA_WARS_SPECTATOR(int p0, int p1, int p2, int p3, int p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `int` | `int` | - |
| `p3` | `int` | `int` | - |
| `p4` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_AWARD_BAD_SPORT

- **命名空间:** `STATS`
- **Hash:** `0x47B32F5611E6E483`
- **Build:** `463`

**C# 签名:**
```csharp
void PLAYSTATS_AWARD_BAD_SPORT(int id)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `id` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_AWARD_NAV

- **命名空间:** `STATS`
- **Hash:** `0x70F52471E758EBAE`
- **Build:** `2545`

**C# 签名:**
```csharp
void PLAYSTATS_AWARD_NAV(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_AWARD_XP

- **命名空间:** `STATS`
- **Hash:** `0x46F917F6B4128FE4`
- **JHash:** `0x8770017B`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_AWARD_XP(int amount, uint type, uint category)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `type` | `Hash` | `uint` | - |
| `category` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BACKGROUND_SCRIPT_ACTION

- **命名空间:** `STATS`
- **Hash:** `0x5009DFD741329729`
- **JHash:** `0x61ECC465`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_BACKGROUND_SCRIPT_ACTION(string action, int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `action` | `const char*` | `string` | - |
| `value` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BAN_ALERT

- **命名空间:** `STATS`
- **Hash:** `0x516FC96EB88EEFE5`
- **Build:** `1011`

**C# 签名:**
```csharp
void PLAYSTATS_BAN_ALERT(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BC_CAR_JACKING

- **命名空间:** `STATS`
- **Hash:** `0x7B18DA61F6BAE9D5`
- **Build:** `573`

**C# 签名:**
```csharp
void PLAYSTATS_BC_CAR_JACKING(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BC_CASHING

- **命名空间:** `STATS`
- **Hash:** `0x53CAE13E9B426993`
- **Build:** `757`

**C# 签名:**
```csharp
void PLAYSTATS_BC_CASHING(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BC_FINDERS_KEEPERS

- **命名空间:** `STATS`
- **Hash:** `0xE3261D791EB44ACB`
- **Build:** `573`

**C# 签名:**
```csharp
void PLAYSTATS_BC_FINDERS_KEEPERS(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BC_MOST_WANTED

- **命名空间:** `STATS`
- **Hash:** `0x930F504203F561C9`
- **Build:** `573`

**C# 签名:**
```csharp
void PLAYSTATS_BC_MOST_WANTED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BC_POINT_TO_POINT

- **命名空间:** `STATS`
- **Hash:** `0x73001E34F85137F8`
- **Build:** `573`

**C# 签名:**
```csharp
void PLAYSTATS_BC_POINT_TO_POINT(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BC_PROTECTION_RACKET

- **命名空间:** `STATS`
- **Hash:** `0x14EDA9EE27BD1626`
- **Build:** `573`

**C# 签名:**
```csharp
void PLAYSTATS_BC_PROTECTION_RACKET(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BC_SALVAGE

- **命名空间:** `STATS`
- **Hash:** `0x7D36291161859389`
- **Build:** `757`

**C# 签名:**
```csharp
void PLAYSTATS_BC_SALVAGE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BC_SMASH_AND_GRAB

- **命名空间:** `STATS`
- **Hash:** `0x06EAF70AE066441E`
- **Build:** `573`

**C# 签名:**
```csharp
void PLAYSTATS_BC_SMASH_AND_GRAB(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BUSINESS_BATTLE_ENDED

- **命名空间:** `STATS`
- **Hash:** `0x316DB59CD14C1774`
- **Build:** `1493`

**C# 签名:**
```csharp
void PLAYSTATS_BUSINESS_BATTLE_ENDED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BUY_CONTRABAND_MISSION

- **命名空间:** `STATS`
- **Hash:** `0xD6781E42755531F7`
- **Build:** `757`

**C# 签名:**
```csharp
void PLAYSTATS_BUY_CONTRABAND_MISSION(ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BW_AIR_FREIGHT

- **命名空间:** `STATS`
- **Hash:** `0xF06A6F41CB445443`
- **Build:** `757`

**C# 签名:**
```csharp
void PLAYSTATS_BW_AIR_FREIGHT(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BW_ASSAULT

- **命名空间:** `STATS`
- **Hash:** `0x678F86D8FC040BDB`
- **Build:** `573`

**C# 签名:**
```csharp
void PLAYSTATS_BW_ASSAULT(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BW_BELLY_OF_THE_BEAST

- **命名空间:** `STATS`
- **Hash:** `0xA6F54BB2FFCA35EA`
- **Build:** `573`

**C# 签名:**
```csharp
void PLAYSTATS_BW_BELLY_OF_THE_BEAST(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BW_BOSSONBOSSDEATHMATCH

- **命名空间:** `STATS`
- **Hash:** `0x8D8ADB562F09A245`
- **Build:** `573`

**C# 签名:**
```csharp
void PLAYSTATS_BW_BOSSONBOSSDEATHMATCH(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BW_FRAGILE_GOODS

- **命名空间:** `STATS`
- **Hash:** `0x282B6739644F4347`
- **Build:** `757`

**C# 签名:**
```csharp
void PLAYSTATS_BW_FRAGILE_GOODS(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BW_HEAD_HUNTER

- **命名空间:** `STATS`
- **Hash:** `0x5FF2C33B13A02A11`
- **Build:** `757`

**C# 签名:**
```csharp
void PLAYSTATS_BW_HEAD_HUNTER(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BW_HUNT_THE_BOSS

- **命名空间:** `STATS`
- **Hash:** `0x88087EE1F28024AE`
- **Build:** `573`

**C# 签名:**
```csharp
void PLAYSTATS_BW_HUNT_THE_BOSS(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BW_SIGHTSEER

- **命名空间:** `STATS`
- **Hash:** `0xFCC228E07217FCAC`
- **Build:** `573`

**C# 签名:**
```csharp
void PLAYSTATS_BW_SIGHTSEER(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_BW_YATCHATTACK

- **命名空间:** `STATS`
- **Hash:** `0xD1A1EE3B4FA8E760`
- **Build:** `573`

**C# 签名:**
```csharp
void PLAYSTATS_BW_YATCHATTACK(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CARCLUB_CHALLENGE

- **命名空间:** `STATS`
- **Hash:** `0x1187CB58D7F3BED7`
- **Build:** `2372`

**C# 签名:**
```csharp
void PLAYSTATS_CARCLUB_CHALLENGE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CARCLUB_POINTS

- **命名空间:** `STATS`
- **Hash:** `0xFF14D6FEEC507BBE`
- **Build:** `2372`

**C# 签名:**
```csharp
void PLAYSTATS_CARCLUB_POINTS(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CARCLUB_PRIZE

- **命名空间:** `STATS`
- **Hash:** `0x69C922B677621428`
- **Build:** `2372`

**C# 签名:**
```csharp
void PLAYSTATS_CARCLUB_PRIZE(int p0, uint vehicleModel)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `vehicleModel` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CASINO_BLACKJACK

- **命名空间:** `STATS`
- **Hash:** `0x3EAE97309727E7AD`
- **Build:** `1734`

**C# 签名:**
```csharp
void PLAYSTATS_CASINO_BLACKJACK(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CASINO_BLACKJACK_LIGHT

- **命名空间:** `STATS`
- **Hash:** `0xD5451C7BF151EB6F`
- **Build:** `1734`

**C# 签名:**
```csharp
void PLAYSTATS_CASINO_BLACKJACK_LIGHT(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CASINO_CHIP

- **命名空间:** `STATS`
- **Hash:** `0x0999F3F090EC5012`
- **Build:** `1734`

**C# 签名:**
```csharp
void PLAYSTATS_CASINO_CHIP(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CASINO_INSIDE_TRACK

- **命名空间:** `STATS`
- **Hash:** `0x049F059625058A86`
- **Build:** `1734`

**C# 签名:**
```csharp
void PLAYSTATS_CASINO_INSIDE_TRACK(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CASINO_INSIDE_TRACK_LIGHT

- **命名空间:** `STATS`
- **Hash:** `0x23A3CBCD50D54E47`
- **Build:** `1734`

**C# 签名:**
```csharp
void PLAYSTATS_CASINO_INSIDE_TRACK_LIGHT(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CASINO_LUCKY_SEVEN

- **命名空间:** `STATS`
- **Hash:** `0x0C432C1435F5E4FA`
- **Build:** `1734`

**C# 签名:**
```csharp
void PLAYSTATS_CASINO_LUCKY_SEVEN(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CASINO_ROULETTE

- **命名空间:** `STATS`
- **Hash:** `0x95101C443A84E7F1`
- **Build:** `1734`

**C# 签名:**
```csharp
void PLAYSTATS_CASINO_ROULETTE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CASINO_ROULETTE_LIGHT

- **命名空间:** `STATS`
- **Hash:** `0x6572ABA3DE1197FC`
- **Build:** `1734`

**C# 签名:**
```csharp
void PLAYSTATS_CASINO_ROULETTE_LIGHT(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CASINO_SLOT_MACHINE

- **命名空间:** `STATS`
- **Hash:** `0xEF5EC67D392B830A`
- **Build:** `1734`

**C# 签名:**
```csharp
void PLAYSTATS_CASINO_SLOT_MACHINE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CASINO_SLOT_MACHINE_LIGHT

- **命名空间:** `STATS`
- **Hash:** `0xE60054A0FAE8227F`
- **Build:** `1734`

**C# 签名:**
```csharp
void PLAYSTATS_CASINO_SLOT_MACHINE_LIGHT(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CASINO_STORY_MISSION_ENDED

- **命名空间:** `STATS`
- **Hash:** `0xFCCCAC2BD3C1F180`
- **Build:** `1734`

**C# 签名:**
```csharp
void PLAYSTATS_CASINO_STORY_MISSION_ENDED(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CASINO_THREE_CARD_POKER

- **命名空间:** `STATS`
- **Hash:** `0xF740FB339D471C35`
- **Build:** `1734`

**C# 签名:**
```csharp
void PLAYSTATS_CASINO_THREE_CARD_POKER(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CASINO_THREE_CARD_POKER_LIGHT

- **命名空间:** `STATS`
- **Hash:** `0xC9001364B4388F22`
- **Build:** `1734`

**C# 签名:**
```csharp
void PLAYSTATS_CASINO_THREE_CARD_POKER_LIGHT(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CHANGE_MC_OUTFIT

- **命名空间:** `STATS`
- **Hash:** `0x28ECB8AC2F607DB2`
- **Build:** `877`

**C# 签名:**
```csharp
void PLAYSTATS_CHANGE_MC_OUTFIT(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CHANGE_MC_ROLE

- **命名空间:** `STATS`
- **Hash:** `0x0B565B0AAE56A0E8`
- **Build:** `877`

**C# 签名:**
```csharp
void PLAYSTATS_CHANGE_MC_ROLE(object p0, object p1, object p2, object p3, int role, int p5, object p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `role` | `int` | `int` | - |
| `p5` | `int` | `int` | - |
| `p6` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CHEAT_APPLIED

- **命名空间:** `STATS`
- **Hash:** `0x6058665D72302D3F`
- **JHash:** `0x345166F3`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_CHEAT_APPLIED(string cheat)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `cheat` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CLOTH_CHANGE

- **命名空间:** `STATS`
- **Hash:** `0x34B973047A2268B9`
- **JHash:** `0x3AFF9E58`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_CLOTH_CHANGE(int p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Ped` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_COLLECTIBLE_PICKED_UP

- **命名空间:** `STATS`
- **Hash:** `0xCD0A8A9338681CF2`
- **Build:** `1734`

**C# 签名:**
```csharp
void PLAYSTATS_COLLECTIBLE_PICKED_UP(int p0, uint objectHash, object p2, object p3, int moneyAmount, int rpAmount, int chipsAmount, object p7, int p8, object p9, object p10)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `objectHash` | `Hash` | `uint` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `moneyAmount` | `int` | `int` | - |
| `rpAmount` | `int` | `int` | - |
| `chipsAmount` | `int` | `int` | - |
| `p7` | `Any` | `object` | - |
| `p8` | `int` | `int` | - |
| `p9` | `Any` | `object` | - |
| `p10` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_COPY_RANK_INTO_NEW_SLOT

- **命名空间:** `STATS`
- **Hash:** `0xB7257BA2550EA10A`
- **Build:** `877`

**C# 签名:**
```csharp
void PLAYSTATS_COPY_RANK_INTO_NEW_SLOT(object p0, object p1, object p2, object p3, object p4, object p5, object p6)
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

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CRATE_CREATED

- **命名空间:** `STATS`
- **Hash:** `0xAFC7E5E075A96F46`
- **JHash:** `0xD003E648`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_CRATE_CREATED(float p0, float p1, float p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `float` | `float` | - |
| `p1` | `float` | `float` | - |
| `p2` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CRATE_DROP_MISSION_DONE

- **命名空间:** `STATS`
- **Hash:** `0x1CAE5D2E3F9A07F0`
- **JHash:** `0x6602CED6`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_CRATE_DROP_MISSION_DONE(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7)
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

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_CREATE_MATCH_HISTORY_ID_2

- **命名空间:** `STATS`
- **Hash:** `0x6DEE77AFF8C21BD1`
- **JHash:** `0x489E27E7`
- **Build:** `323`

**C# 签名:**
```csharp
bool PLAYSTATS_CREATE_MATCH_HISTORY_ID_2(ref int playerAccountId, ref int posixTime)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `playerAccountId` | `int*` | `ref int` | - |
| `posixTime` | `int*` | `ref int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### PLAYSTATS_DAR_CHECKPOINT

- **命名空间:** `STATS`
- **Hash:** `0x0BC254FF3A911501`
- **Build:** `1290`

**C# 签名:**
```csharp
void PLAYSTATS_DAR_CHECKPOINT(ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_DEFEND_CONTRABAND_MISSION

- **命名空间:** `STATS`
- **Hash:** `0x2605663BD4F23B5D`
- **Build:** `757`

**C# 签名:**
```csharp
void PLAYSTATS_DEFEND_CONTRABAND_MISSION(ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_DJ_MISSION_ENDED

- **命名空间:** `STATS`
- **Hash:** `0xD6CA58B3B53A0F22`
- **Build:** `2189`

**C# 签名:**
```csharp
void PLAYSTATS_DJ_MISSION_ENDED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_DJ_USAGE

- **命名空间:** `STATS`
- **Hash:** `0xB26F670685631727`
- **Build:** `1493`

**C# 签名:**
```csharp
void PLAYSTATS_DJ_USAGE(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_DRONE_USAGE

- **命名空间:** `STATS`
- **Hash:** `0x66C7BB2416ED3FCE`
- **Build:** `1493`

**C# 签名:**
```csharp
void PLAYSTATS_DRONE_USAGE(int p0, int p1, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_DUPE_DETECTED

- **命名空间:** `STATS`
- **Hash:** `0x848B66100EE33B05`
- **Build:** `1011`

**C# 签名:**
```csharp
void PLAYSTATS_DUPE_DETECTED(ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_EARNED_MC_POINTS

- **命名空间:** `STATS`
- **Hash:** `0x501478855A6074CE`
- **Build:** `877`

**C# 签名:**
```csharp
void PLAYSTATS_EARNED_MC_POINTS(object p0, object p1, object p2, object p3, object p4, object p5)
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

### PLAYSTATS_ENTER_SESSION_PACK

- **命名空间:** `STATS`
- **Hash:** `0x878FF156D36E9956`
- **Build:** `1290`

**C# 签名:**
```csharp
void PLAYSTATS_ENTER_SESSION_PACK(ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_EXTRA_EVENT

- **命名空间:** `STATS`
- **Hash:** `0xFA5B74BAB8A7EF99`
- **Build:** `2372`

**C# 签名:**
```csharp
void PLAYSTATS_EXTRA_EVENT(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_FAST_TRVL

- **命名空间:** `STATS`
- **Hash:** `0x4DC416F246A41FC8`
- **Build:** `2189`

**C# 签名:**
```csharp
void PLAYSTATS_FAST_TRVL(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9, object p10)
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
| `p10` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_FM_EVENT_ATOB

- **命名空间:** `STATS`
- **Hash:** `0xBAA2F0490E146BE8`
- **Build:** `463`

**C# 签名:**
```csharp
void PLAYSTATS_FM_EVENT_ATOB(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_FM_EVENT_CHALLENGES

- **命名空间:** `STATS`
- **Hash:** `0x6A60E43998228229`
- **Build:** `463`

**C# 签名:**
```csharp
void PLAYSTATS_FM_EVENT_CHALLENGES(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_FM_EVENT_CHECKPOINTCOLLECTION

- **命名空间:** `STATS`
- **Hash:** `0x3DE3AA516FB126A4`
- **Build:** `463`

**C# 签名:**
```csharp
void PLAYSTATS_FM_EVENT_CHECKPOINTCOLLECTION(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_FM_EVENT_COMPETITIVEURBANWARFARE

- **命名空间:** `STATS`
- **Hash:** `0x6551B1F7F6CD46EA`
- **Build:** `463`

**C# 签名:**
```csharp
void PLAYSTATS_FM_EVENT_COMPETITIVEURBANWARFARE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_FM_EVENT_CRIMINALDAMAGE

- **命名空间:** `STATS`
- **Hash:** `0xEDBF6C9B0D2C65C8`
- **Build:** `463`

**C# 签名:**
```csharp
void PLAYSTATS_FM_EVENT_CRIMINALDAMAGE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_FM_EVENT_DEADDROP

- **命名空间:** `STATS`
- **Hash:** `0x0A9C7F36E5D7B683`
- **Build:** `463`

**C# 签名:**
```csharp
void PLAYSTATS_FM_EVENT_DEADDROP(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_FM_EVENT_HOTPROPERTY

- **命名空间:** `STATS`
- **Hash:** `0x84DFC579C2FC214C`
- **Build:** `463`

**C# 签名:**
```csharp
void PLAYSTATS_FM_EVENT_HOTPROPERTY(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_FM_EVENT_HUNTBEAST

- **命名空间:** `STATS`
- **Hash:** `0x2CD90358F67D0AA8`
- **Build:** `463`

**C# 签名:**
```csharp
void PLAYSTATS_FM_EVENT_HUNTBEAST(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_FM_EVENT_KINGOFTHECASTLE

- **命名空间:** `STATS`
- **Hash:** `0x164C5FF663790845`
- **Build:** `463`

**C# 签名:**
```csharp
void PLAYSTATS_FM_EVENT_KINGOFTHECASTLE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_FM_EVENT_PASSTHEPARCEL

- **命名空间:** `STATS`
- **Hash:** `0x419615486BBF1956`
- **Build:** `463`

**C# 签名:**
```csharp
void PLAYSTATS_FM_EVENT_PASSTHEPARCEL(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_FM_EVENT_PENNEDIN

- **命名空间:** `STATS`
- **Hash:** `0x1A7CE7CD3E653485`
- **Build:** `463`

**C# 签名:**
```csharp
void PLAYSTATS_FM_EVENT_PENNEDIN(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_FM_EVENT_URBANWARFARE

- **命名空间:** `STATS`
- **Hash:** `0x8C9D11605E59D955`
- **Build:** `463`

**C# 签名:**
```csharp
void PLAYSTATS_FM_EVENT_URBANWARFARE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_FM_EVENT_VEHICLETARGET

- **命名空间:** `STATS`
- **Hash:** `0xBFAFDB5FAAA5C5AB`
- **Build:** `463`

**C# 签名:**
```csharp
void PLAYSTATS_FM_EVENT_VEHICLETARGET(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_FM_HEIST_PREP_ENDED

- **命名空间:** `STATS`
- **Hash:** `0xD8AFB345A9C5CCBB`
- **Build:** `1290`

**C# 签名:**
```csharp
void PLAYSTATS_FM_HEIST_PREP_ENDED(ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_FM_MISSION_END

- **命名空间:** `STATS`
- **Hash:** `0x46A70777BE6CEAB9`
- **Build:** `2545`

**C# 签名:**
```csharp
void PLAYSTATS_FM_MISSION_END(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_FREEMODE_CASINO_MISSION_ENDED

- **命名空间:** `STATS`
- **Hash:** `0x1A0D4A6C336B7BC5`
- **Build:** `1734`

**C# 签名:**
```csharp
void PLAYSTATS_FREEMODE_CASINO_MISSION_ENDED(ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_FRIEND_ACTIVITY

- **命名空间:** `STATS`
- **Hash:** `0x0F71DE29AB2258F1`
- **JHash:** `0xD1FA1BDB`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_FRIEND_ACTIVITY(int p0, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_GUNRUNNING_MISSION_ENDED

- **命名空间:** `STATS`
- **Hash:** `0x0EACDF8487D5155A`
- **Build:** `1103`

**C# 签名:**
```csharp
void PLAYSTATS_GUNRUNNING_MISSION_ENDED(ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_GUNRUNNING_RND

- **命名空间:** `STATS`
- **Hash:** `0xDAF80797FC534BEC`
- **Build:** `1103`

**C# 签名:**
```csharp
void PLAYSTATS_GUNRUNNING_RND(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_HEIST3_DRONE

- **命名空间:** `STATS`
- **Hash:** `0xDFBD93BF2943E29B`
- **Build:** `1868`

**C# 签名:**
```csharp
void PLAYSTATS_HEIST3_DRONE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_HEIST3_FINALE

- **命名空间:** `STATS`
- **Hash:** `0x2E0259BABC27A327`
- **Build:** `1868`

**C# 签名:**
```csharp
void PLAYSTATS_HEIST3_FINALE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_HEIST3_HACK

- **命名空间:** `STATS`
- **Hash:** `0x92FC0EEDFAC04A14`
- **Build:** `1868`

**C# 签名:**
```csharp
void PLAYSTATS_HEIST3_HACK(object p0, object p1, object p2, object p3, object p4, object p5)
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

### PLAYSTATS_HEIST3_PREP

- **命名空间:** `STATS`
- **Hash:** `0x53C31853EC9531FF`
- **Build:** `1868`

**C# 签名:**
```csharp
void PLAYSTATS_HEIST3_PREP(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_HEIST4_FINALE

- **命名空间:** `STATS`
- **Hash:** `0xC1E963C58664B556`
- **Build:** `2189`

**C# 签名:**
```csharp
void PLAYSTATS_HEIST4_FINALE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_HEIST4_HACK

- **命名空间:** `STATS`
- **Hash:** `0x2FA3173480008493`
- **Build:** `2189`

**C# 签名:**
```csharp
void PLAYSTATS_HEIST4_HACK(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_HEIST4_PREP

- **命名空间:** `STATS`
- **Hash:** `0xDFCDB14317A9B361`
- **Build:** `2189`

**C# 签名:**
```csharp
void PLAYSTATS_HEIST4_PREP(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_HEIST_SAVE_CHEAT

- **命名空间:** `STATS`
- **Hash:** `0xF4FF020A08BC8863`
- **JHash:** `0xB731DF54`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_HEIST_SAVE_CHEAT(uint hash, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `hash` | `Hash` | `uint` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_HIT_CONTRABAND_DESTROY_LIMIT

- **命名空间:** `STATS`
- **Hash:** `0x60EEDC12AF66E846`
- **Build:** `757`

**C# 签名:**
```csharp
void PLAYSTATS_HIT_CONTRABAND_DESTROY_LIMIT(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_HOLD_UP_MISSION_DONE

- **命名空间:** `STATS`
- **Hash:** `0xCB00196B31C39EB1`
- **JHash:** `0x759E0EC9`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_HOLD_UP_MISSION_DONE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_HUB_ENTRY

- **命名空间:** `STATS`
- **Hash:** `0x2818FF6638CB09DE`
- **Build:** `2189`

**C# 签名:**
```csharp
void PLAYSTATS_HUB_ENTRY(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_HUB_EXIT

- **命名空间:** `STATS`
- **Hash:** `0x5A46ACE5C4661132`
- **Build:** `2545`

**C# 签名:**
```csharp
void PLAYSTATS_HUB_EXIT(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_IDLE_KICK

- **命名空间:** `STATS`
- **Hash:** `0x5DA3A8DE8CB6226F`
- **JHash:** `0x9E2B9522`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_IDLE_KICK(int msStoodIdle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `msStoodIdle` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_IMPEXP_MISSION_ENDED

- **命名空间:** `STATS`
- **Hash:** `0x7D8BA05688AD64C7`
- **Build:** `944`

**C# 签名:**
```csharp
void PLAYSTATS_IMPEXP_MISSION_ENDED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_IMPORT_EXPORT_MISSION_DONE

- **命名空间:** `STATS`
- **Hash:** `0x2B69F5074C894811`
- **JHash:** `0x62073DF7`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_IMPORT_EXPORT_MISSION_DONE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_INSTANCED_HEIST_ENDED

- **命名空间:** `STATS`
- **Hash:** `0x1E1497D0D2108115`
- **Build:** `1290`

**C# 签名:**
```csharp
void PLAYSTATS_INSTANCED_HEIST_ENDED(ref object data, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_INST_MISSION_END

- **命名空间:** `STATS`
- **Hash:** `0xFEA3F7E83C0610FA`
- **Build:** `2545`

**C# 签名:**
```csharp
void PLAYSTATS_INST_MISSION_END(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_INVENTORY

- **命名空间:** `STATS`
- **Hash:** `0x887DAD63CF5B7908`
- **Build:** `2699`

**C# 签名:**
```csharp
void PLAYSTATS_INVENTORY(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_JOB_ACTIVITY_END

- **命名空间:** `STATS`
- **Hash:** `0xF8C54A461C3E11DC`
- **JHash:** `0x04181752`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_JOB_ACTIVITY_END(ref object p0, ref object p1, ref object p2, ref object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any*` | `ref object` | - |
| `p2` | `Any*` | `ref object` | - |
| `p3` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_JOB_BEND

- **命名空间:** `STATS`
- **Hash:** `0xF5BB8DAC426A52C0`
- **JHash:** `0x40520E70`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_JOB_BEND(ref object p0, ref object p1, ref object p2, ref object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any*` | `ref object` | - |
| `p2` | `Any*` | `ref object` | - |
| `p3` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_JOB_LTS_END

- **命名空间:** `STATS`
- **Hash:** `0xA736CF7FB7C5BFF4`
- **JHash:** `0x31002201`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_JOB_LTS_END(ref object p0, ref object p1, ref object p2, ref object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any*` | `ref object` | - |
| `p2` | `Any*` | `ref object` | - |
| `p3` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_JOB_LTS_ROUND_END

- **命名空间:** `STATS`
- **Hash:** `0x14E0B2D1AD1044E0`
- **JHash:** `0xDDD1F1F3`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_JOB_LTS_ROUND_END(ref object p0, ref object p1, ref object p2, ref object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |
| `p1` | `Any*` | `ref object` | - |
| `p2` | `Any*` | `ref object` | - |
| `p3` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_LEAVE_JOB_CHAIN

- **命名空间:** `STATS`
- **Hash:** `0xC5BE134EC7BA96A0`
- **JHash:** `0xC960E161`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_LEAVE_JOB_CHAIN(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_MASTER_CONTROL

- **命名空间:** `STATS`
- **Hash:** `0x810B5FCC52EC7FF0`
- **Build:** `1868`

**C# 签名:**
```csharp
void PLAYSTATS_MASTER_CONTROL(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_MATCH_STARTED

- **命名空间:** `STATS`
- **Hash:** `0xBC80E22DED931E3D`
- **JHash:** `0x2BDE85C1`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_MATCH_STARTED(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_MC_CLUBHOUSE_ACTIVITY

- **命名空间:** `STATS`
- **Hash:** `0x8989CBD7B4E82534`
- **Build:** `877`

**C# 签名:**
```csharp
void PLAYSTATS_MC_CLUBHOUSE_ACTIVITY(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7)
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

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_MC_FORMATION_ENDS

- **命名空间:** `STATS`
- **Hash:** `0x03C2EEBB04B3FB72`
- **Build:** `877`

**C# 签名:**
```csharp
void PLAYSTATS_MC_FORMATION_ENDS(object p0, object p1, object p2, object p3, object p4, object p5, object p6)
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

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_MC_KILLED_RIVAL_MC_MEMBER

- **命名空间:** `STATS`
- **Hash:** `0xF534D94DFA2EAD26`
- **Build:** `877`

**C# 签名:**
```csharp
void PLAYSTATS_MC_KILLED_RIVAL_MC_MEMBER(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_MC_REQUEST_BIKE

- **命名空间:** `STATS`
- **Hash:** `0xCC25A4553DFBF9EA`
- **Build:** `877`

**C# 签名:**
```csharp
void PLAYSTATS_MC_REQUEST_BIKE(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_MINIGAME_USAGE

- **命名空间:** `STATS`
- **Hash:** `0xC14BD9F5337219B2`
- **Build:** `1493`

**C# 签名:**
```csharp
void PLAYSTATS_MINIGAME_USAGE(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_MISSION_CHECKPOINT

- **命名空间:** `STATS`
- **Hash:** `0xC900596A63978C1D`
- **JHash:** `0xCDC52280`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_MISSION_CHECKPOINT(string p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `const char*` | `string` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_MISSION_ENDED

- **命名空间:** `STATS`
- **Hash:** `0xBF371CD2B64212FD`
- **Build:** `877`

**C# 签名:**
```csharp
void PLAYSTATS_MISSION_ENDED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_MISSION_OVER

- **命名空间:** `STATS`
- **Hash:** `0x7C4BB33A8CED7324`
- **JHash:** `0x5B90B5FF`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_MISSION_OVER(string p0, object p1, object p2, bool p3, bool p4, bool p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `const char*` | `string` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `BOOL` | `bool` | - |
| `p4` | `BOOL` | `bool` | - |
| `p5` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_MISSION_STARTED

- **命名空间:** `STATS`
- **Hash:** `0xC19A2925C34D2231`
- **JHash:** `0x3AAB699C`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_MISSION_STARTED(string p0, object p1, object p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `const char*` | `string` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_MISSION_VOTE

- **命名空间:** `STATS`
- **Hash:** `0xC03FAB2C2F92289B`
- **Build:** `1868`

**C# 签名:**
```csharp
void PLAYSTATS_MISSION_VOTE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_NIGHTCLUB_MISSION_ENDED

- **命名空间:** `STATS`
- **Hash:** `0x830C3A44EB3F2CF9`
- **Build:** `1493`

**C# 签名:**
```csharp
void PLAYSTATS_NIGHTCLUB_MISSION_ENDED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_NJVS_VOTE

- **命名空间:** `STATS`
- **Hash:** `0x5CDAED54B34B0ED0`
- **Build:** `1868`

**C# 签名:**
```csharp
void PLAYSTATS_NJVS_VOTE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_NPC_INVITE

- **命名空间:** `STATS`
- **Hash:** `0x93054C88E6AA7C44`
- **JHash:** `0x598C06F3`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_NPC_INVITE(string p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_NPC_PHONE

- **命名空间:** `STATS`
- **Hash:** `0x0077F15613D36993`
- **Build:** `1868`

**C# 签名:**
```csharp
void PLAYSTATS_NPC_PHONE(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_ODDJOB_DONE

- **命名空间:** `STATS`
- **Hash:** `0x69DEA3E9DB727B4C`
- **JHash:** `0xFE14A8EA`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_ODDJOB_DONE(int totalTimeMs, int p1, bool p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `totalTimeMs` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native does absolutely nothing, just a nullsub
```

---

### PLAYSTATS_PEGASUS_AS_PERSONAL_AIRCRAFT

- **命名空间:** `STATS`
- **Hash:** `0x9572BD4DD6B72122`
- **Build:** `1180`

**C# 签名:**
```csharp
void PLAYSTATS_PEGASUS_AS_PERSONAL_AIRCRAFT(uint modelHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `modelHash` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_PIMENU_HIDE_OPTIONS

- **命名空间:** `STATS`
- **Hash:** `0x203B381133817079`
- **Build:** `393`

**C# 签名:**
```csharp
void PLAYSTATS_PIMENU_HIDE_OPTIONS(ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_PROP_CHANGE

- **命名空间:** `STATS`
- **Hash:** `0xBA739D6D5A05D6E7`
- **JHash:** `0x25740A1D`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_PROP_CHANGE(int p0, int p1, int p2, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Ped` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `int` | `int` | - |
| `p3` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_QUICKFIX_TOOL

- **命名空间:** `STATS`
- **Hash:** `0x90D0622866E80445`
- **JHash:** `0x66FEB701`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_QUICKFIX_TOOL(int element, string item)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `element` | `int` | `int` | - |
| `item` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_QUIT_MODE

- **命名空间:** `STATS`
- **Hash:** `0x5BF29846C6527C54`
- **Build:** `1868`

**C# 签名:**
```csharp
void PLAYSTATS_QUIT_MODE(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_RACE_CHECKPOINT

- **命名空间:** `STATS`
- **Hash:** `0x9C375C315099DDE4`
- **JHash:** `0x580D5508`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_RACE_CHECKPOINT(int p0, object p1, int p2, int p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Vehicle` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `int` | `int` | - |
| `p3` | `int` | `int` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_RACE_TO_POINT_MISSION_DONE

- **命名空间:** `STATS`
- **Hash:** `0xADDD1C754E2E2914`
- **JHash:** `0x06CE3692`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_RACE_TO_POINT_MISSION_DONE(int p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_RANDOM_MISSION_DONE

- **命名空间:** `STATS`
- **Hash:** `0x71862B1D855F32E1`
- **JHash:** `0xAC2C7C63`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_RANDOM_MISSION_DONE(string name, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `name` | `const char*` | `string` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_RANK_UP

- **命名空间:** `STATS`
- **Hash:** `0xC7F2DE41D102BFB4`
- **JHash:** `0x56AFB9F5`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_RANK_UP(int rank)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `rank` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_RECOVER_CONTRABAND_MISSION

- **命名空间:** `STATS`
- **Hash:** `0x04D90BA8207ADA2D`
- **Build:** `757`

**C# 签名:**
```csharp
void PLAYSTATS_RECOVER_CONTRABAND_MISSION(ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_RIVAL_BEHAVIOR

- **命名空间:** `STATS`
- **Hash:** `0x27AA1C973CACFE63`
- **Build:** `944`

**C# 签名:**
```csharp
void PLAYSTATS_RIVAL_BEHAVIOR(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9)
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

### PLAYSTATS_ROBBERY_FINALE

- **命名空间:** `STATS`
- **Hash:** `0xBBA55BE9AAAABF44`
- **Build:** `2372`

**C# 签名:**
```csharp
void PLAYSTATS_ROBBERY_FINALE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_ROBBERY_PREP

- **命名空间:** `STATS`
- **Hash:** `0x1A67DFBF1F5C3835`
- **Build:** `2372`

**C# 签名:**
```csharp
void PLAYSTATS_ROBBERY_PREP(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_ROS_BET

- **命名空间:** `STATS`
- **Hash:** `0x121FB4DDDC2D5291`
- **JHash:** `0x413539BC`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_ROS_BET(int amount, int act, int player, float cm)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `act` | `int` | `int` | - |
| `player` | `Player` | `int` | - |
| `cm` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_SELL_CONTRABAND_MISSION

- **命名空间:** `STATS`
- **Hash:** `0xC729991A9065376E`
- **Build:** `757`

**C# 签名:**
```csharp
void PLAYSTATS_SELL_CONTRABAND_MISSION(ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_SET_JOIN_TYPE

- **命名空间:** `STATS`
- **Hash:** `0xD1032E482629049E`
- **JHash:** `0x1AC97138`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_SET_JOIN_TYPE(int joinType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `joinType` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_SHOP_ITEM

- **命名空间:** `STATS`
- **Hash:** `0x176852ACAAC173D1`
- **JHash:** `0xA4746384`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_SHOP_ITEM(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_SMUGGLER_MISSION_ENDED

- **命名空间:** `STATS`
- **Hash:** `0x320C35147D5B5DDD`
- **Build:** `1180`

**C# 签名:**
```csharp
void PLAYSTATS_SMUGGLER_MISSION_ENDED(ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_SPENT_PI_CUSTOM_LOADOUT

- **命名空间:** `STATS`
- **Hash:** `0xBE509B0A3693DE8B`
- **Build:** `757`

**C# 签名:**
```csharp
void PLAYSTATS_SPENT_PI_CUSTOM_LOADOUT(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_SPIN_WHEEL

- **命名空间:** `STATS`
- **Hash:** `0x6731DE84A38BFAD0`
- **Build:** `1604`

**C# 签名:**
```csharp
void PLAYSTATS_SPIN_WHEEL(int p0, int p1, int p2, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `int` | `int` | - |
| `p2` | `int` | `int` | - |
| `p3` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_STARTED_SESSION_IN_OFFLINEMODE

- **命名空间:** `STATS`
- **Hash:** `0x098760C7461724CD`
- **JHash:** `0x896CDF8D`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_STARTED_SESSION_IN_OFFLINEMODE()
```

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_START_TRACKING_STUNTS

- **命名空间:** `STATS`
- **Hash:** `0x928DBFB892638EF3`
- **Build:** `791`

**C# 签名:**
```csharp
void PLAYSTATS_START_TRACKING_STUNTS()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Allows CEventNetworkStuntPerformed to be triggered.
```

---

### PLAYSTATS_STONE_HATCHET_ENDED

- **命名空间:** `STATS`
- **Hash:** `0x35E39E5570358630`
- **Build:** `1493`

**C# 签名:**
```csharp
void PLAYSTATS_STONE_HATCHET_ENDED(ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_STOP_TRACKING_STUNTS

- **命名空间:** `STATS`
- **Hash:** `0x8A800DACCC0DA55D`
- **Build:** `791`

**C# 签名:**
```csharp
void PLAYSTATS_STOP_TRACKING_STUNTS()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Disallows CEventNetworkStuntPerformed to be triggered.
```

---

### PLAYSTATS_SUB_WEAP

- **命名空间:** `STATS`
- **Hash:** `0xD4367D310F079DB0`
- **Build:** `2189`

**C# 签名:**
```csharp
void PLAYSTATS_SUB_WEAP(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_SWITCH_MC_EMBLEM

- **命名空间:** `STATS`
- **Hash:** `0x0A50D2604E05CB94`
- **Build:** `877`

**C# 签名:**
```csharp
void PLAYSTATS_SWITCH_MC_EMBLEM(object p0, object p1, object p2, object p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_SWITCH_PASSIVE_MODE

- **命名空间:** `STATS`
- **Hash:** `0x35EEC6C2BC821A71`
- **Build:** `1734`

**C# 签名:**
```csharp
void PLAYSTATS_SWITCH_PASSIVE_MODE(bool p0, int p1, int p2, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `BOOL` | `bool` | - |
| `p1` | `int` | `int` | - |
| `p2` | `int` | `int` | - |
| `p3` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_VEH_DEL

- **命名空间:** `STATS`
- **Hash:** `0x10A691F5756416D0`
- **Build:** `2944`

**C# 签名:**
```csharp
void PLAYSTATS_VEH_DEL(int bossId1, int bossId2, int bossType, int vehicleID, int reason)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `bossId1` | `int` | `int` | - |
| `bossId2` | `int` | `int` | - |
| `bossType` | `int` | `int` | - |
| `vehicleID` | `int` | `int` | - |
| `reason` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_WAREHOUSE_MISSION_ENDED

- **命名空间:** `STATS`
- **Hash:** `0x2D7A9B577E72385E`
- **Build:** `1493`

**C# 签名:**
```csharp
void PLAYSTATS_WAREHOUSE_MISSION_ENDED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### PLAYSTATS_WEAPON_MODE_CHANGE

- **命名空间:** `STATS`
- **Hash:** `0xE95C8A1875A02CA4`
- **JHash:** `0x79716890`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_WEAPON_MODE_CHANGE(uint weaponHash, uint componentHashTo, uint componentHashFrom)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `weaponHash` | `Hash` | `uint` | - |
| `componentHashTo` | `Hash` | `uint` | - |
| `componentHashFrom` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This is a typo made by R*. It's supposed to be called PLAYSTATS_WEAPON_MOD_CHANGE.
```

---

### PLAYSTATS_WEBSITE_VISITED

- **命名空间:** `STATS`
- **Hash:** `0xDDF24D535060F811`
- **JHash:** `0x37D152BB`
- **Build:** `323`

**C# 签名:**
```csharp
void PLAYSTATS_WEBSITE_VISITED(uint scaleformHash, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `scaleformHash` | `Hash` | `uint` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PRESENCE_EVENT_UPDATESTAT_FLOAT

- **命名空间:** `STATS`
- **Hash:** `0x30A6614C1F7799B8`
- **JHash:** `0x3E69E7C3`
- **Build:** `323`

**C# 签名:**
```csharp
void PRESENCE_EVENT_UPDATESTAT_FLOAT(uint statHash, float value, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statHash` | `Hash` | `uint` | - |
| `value` | `float` | `float` | - |
| `p2` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PRESENCE_EVENT_UPDATESTAT_INT

- **命名空间:** `STATS`
- **Hash:** `0x11FF1C80276097ED`
- **JHash:** `0x4AC39C6C`
- **Build:** `323`

**C# 签名:**
```csharp
void PRESENCE_EVENT_UPDATESTAT_INT(uint statHash, int value, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statHash` | `Hash` | `uint` | - |
| `value` | `int` | `int` | - |
| `p2` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### PRESENCE_EVENT_UPDATESTAT_INT_WITH_STRING

- **命名空间:** `STATS`
- **Hash:** `0x6483C25849031C4F`
- **JHash:** `0x2FFD2FA5`
- **Build:** `323`

**C# 签名:**
```csharp
void PRESENCE_EVENT_UPDATESTAT_INT_WITH_STRING(uint statHash, int value, int p2, string string)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statHash` | `Hash` | `uint` | - |
| `value` | `int` | `int` | - |
| `p2` | `int` | `int` | - |
| `string` | `const char*` | `string` | - |

**返回值:** `void` (Native: `void`)

---

### PROCESS_CASH_GIFT

- **命名空间:** `MONEY`
- **Hash:** `0x20194D48EAEC9A41`
- **JHash:** `0xC5D8B1E9`
- **Build:** `323`

**C# 签名:**
```csharp
string PROCESS_CASH_GIFT(ref int p0, ref int p1, string p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int*` | `ref int` | - |
| `p1` | `int*` | `ref int` | - |
| `p2` | `const char*` | `string` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
This isn't a hash collision.
```

---

### SEND_METRIC_GHOSTING_TO_PLAYER

- **命名空间:** `STATS`
- **Hash:** `0x7033EEFD9B28088E`
- **Build:** `678`

**C# 签名:**
```csharp
void SEND_METRIC_GHOSTING_TO_PLAYER(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SEND_METRIC_PUNISH_BODYGUARD

- **命名空间:** `STATS`
- **Hash:** `0x015B03EE1C43E6EC`
- **Build:** `757`

**C# 签名:**
```csharp
void SEND_METRIC_PUNISH_BODYGUARD(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SEND_METRIC_VIP_POACH

- **命名空间:** `STATS`
- **Hash:** `0xAA525DFF66BB82F5`
- **Build:** `757`

**C# 签名:**
```csharp
void SEND_METRIC_VIP_POACH(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FREEMODE_PROLOGUE_DONE

- **命名空间:** `STATS`
- **Hash:** `0x0D01D20616FC73FB`
- **JHash:** `0x2180AE13`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_FREEMODE_PROLOGUE_DONE(object p0, int characterSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `characterSlot` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_FREEMODE_STRAND_PROGRESSION_STATUS

- **命名空间:** `STATS`
- **Hash:** `0x79D310A861697CC9`
- **Build:** `2699`

**C# 签名:**
```csharp
void SET_FREEMODE_STRAND_PROGRESSION_STATUS(int profileSetting, int settingValue)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `profileSetting` | `int` | `int` | - |
| `settingValue` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets profile setting 940 and 941
```

---

### SET_HAS_POSTED_ALL_VEHICLES_DRIVEN

- **命名空间:** `STATS`
- **Hash:** `0xC141B8917E0017EC`
- **JHash:** `0x0AD43306`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_HAS_POSTED_ALL_VEHICLES_DRIVEN()
```

**返回值:** `void` (Native: `void`)

---

### SET_HAS_SPECIALEDITION_CONTENT

- **命名空间:** `STATS`
- **Hash:** `0xDAC073C7901F9E15`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_HAS_SPECIALEDITION_CONTENT(int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets profile setting 866
```

---

### SET_JOB_ACTIVITY_ID_STARTED

- **命名空间:** `STATS`
- **Hash:** `0x723C1CE13FBFDB67`
- **JHash:** `0x4C39CF10`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_JOB_ACTIVITY_ID_STARTED(object p0, int characterSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `characterSlot` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PACKED_STAT_BOOL_CODE

- **命名空间:** `STATS`
- **Hash:** `0xDB8A58AEAA67CD07`
- **Build:** `2545`

**C# 签名:**
```csharp
void SET_PACKED_STAT_BOOL_CODE(int index, bool value, int characterSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |
| `value` | `BOOL` | `bool` | - |
| `characterSlot` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PACKED_STAT_INT_CODE

- **命名空间:** `STATS`
- **Hash:** `0x1581503AE529CD2E`
- **Build:** `2545`

**C# 签名:**
```csharp
void SET_PACKED_STAT_INT_CODE(int index, int value, int characterSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `index` | `int` | `int` | - |
| `value` | `int` | `int` | - |
| `characterSlot` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### SET_PROFILE_SETTING_CREATOR_CTF_DONE

- **命名空间:** `STATS`
- **Hash:** `0x55384438FC55AD8E`
- **JHash:** `0xF03895A4`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PROFILE_SETTING_CREATOR_CTF_DONE(int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets profile setting 935
```

---

### SET_PROFILE_SETTING_CREATOR_DM_DONE

- **命名空间:** `STATS`
- **Hash:** `0x38BAAA5DD4C9D19F`
- **JHash:** `0x726FAE66`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PROFILE_SETTING_CREATOR_DM_DONE(int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets profile setting 934
```

---

### SET_PROFILE_SETTING_CREATOR_RACES_DONE

- **命名空间:** `STATS`
- **Hash:** `0xF1A1803D3476F215`
- **JHash:** `0xA3DAC790`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PROFILE_SETTING_CREATOR_RACES_DONE(int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets profile setting 933
```

---

### SET_PROFILE_SETTING_PROLOGUE_COMPLETE

- **命名空间:** `STATS`
- **Hash:** `0xB475F27C6A994D65`
- **JHash:** `0xC7DE5C30`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_PROFILE_SETTING_PROLOGUE_COMPLETE()
```

**返回值:** `void` (Native: `void`)

---

### SET_PROFILE_SETTING_SP_CHOP_MISSION_COMPLETE

- **命名空间:** `STATS`
- **Hash:** `0xC67E2DA1CBE759E2`
- **Build:** `1734`

**C# 签名:**
```csharp
void SET_PROFILE_SETTING_SP_CHOP_MISSION_COMPLETE()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets profile setting 939
```

---

### SET_SAVE_MIGRATION_TRANSACTION_ID_WARNING

- **命名空间:** `STATS`
- **Hash:** `0xF6792800AC95350D`
- **Build:** `323`

**C# 签名:**
```csharp
void SET_SAVE_MIGRATION_TRANSACTION_ID_WARNING(int transactionId)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `transactionId` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Sets profile setting 501
```

---

### START_BEING_BOSS

- **命名空间:** `STATS`
- **Hash:** `0x3EBEAC6C3F81F6BD`
- **Build:** `573`

**C# 签名:**
```csharp
void START_BEING_BOSS(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### START_BEING_GOON

- **命名空间:** `STATS`
- **Hash:** `0x96E6D5150DBF1C09`
- **Build:** `573`

**C# 签名:**
```csharp
void START_BEING_GOON(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### STATS_COMPLETED_CHARACTER_CREATION

- **命名空间:** `STATS`
- **Hash:** `0xC01D2470F22CDE5A`
- **Build:** `2372`

**C# 签名:**
```csharp
void STATS_COMPLETED_CHARACTER_CREATION(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
This native does absolutely nothing, just a nullsub
```

---

### STAT_CLEAR_DIRTY_READ_DETECTED

- **命名空间:** `STATS`
- **Hash:** `0x9B4BD21D69B1E609`
- **Build:** `323`

**C# 签名:**
```csharp
void STAT_CLEAR_DIRTY_READ_DETECTED()
```

**返回值:** `void` (Native: `void`)

---

### STAT_CLEAR_PENDING_SAVES

- **命名空间:** `STATS`
- **Hash:** `0xA8733668D1047B51`
- **JHash:** `0x395D18B1`
- **Build:** `323`

**C# 签名:**
```csharp
void STAT_CLEAR_PENDING_SAVES(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### STAT_CLEAR_SLOT_FOR_RELOAD

- **命名空间:** `STATS`
- **Hash:** `0xEB0A72181D4AA4AD`
- **JHash:** `0x84BDD475`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_CLEAR_SLOT_FOR_RELOAD(int statSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statSlot` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Example:

for (v_2 = 0; v_2 <= 4; v_2 += 1) {
    STATS::STAT_CLEAR_SLOT_FOR_RELOAD(v_2);
}
```

---

### STAT_CLOUD_SLOT_LOAD_FAILED

- **命名空间:** `STATS`
- **Hash:** `0x7F2C4CDF2E82DF4C`
- **JHash:** `0x0BF0F4B2`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_CLOUD_SLOT_LOAD_FAILED(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_CLOUD_SLOT_LOAD_FAILED_CODE

- **命名空间:** `STATS`
- **Hash:** `0xE496A53BA5F50A56`
- **JHash:** `0xCE6B62B5`
- **Build:** `323`

**C# 签名:**
```csharp
int STAT_CLOUD_SLOT_LOAD_FAILED_CODE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `int` (Native: `int`)

---

### STAT_CLOUD_SLOT_SAVE_FAILED

- **命名空间:** `STATS`
- **Hash:** `0x7E6946F68A38B74F`
- **JHash:** `0x22804C20`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_CLOUD_SLOT_SAVE_FAILED(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_COMMUNITY_GET_HISTORY

- **命名空间:** `STATS`
- **Hash:** `0xBED9F5693F34ED17`
- **JHash:** `0xC4110917`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_COMMUNITY_GET_HISTORY(uint statName, int p1, ref float outValue)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statName` | `Hash` | `uint` | - |
| `p1` | `int` | `int` | - |
| `outValue` | `float*` | `ref float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_COMMUNITY_START_SYNCH

- **命名空间:** `STATS`
- **Hash:** `0x5A556B229A169402`
- **JHash:** `0x46F21343`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_COMMUNITY_START_SYNCH()
```

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_COMMUNITY_SYNCH_IS_PENDING

- **命名空间:** `STATS`
- **Hash:** `0xB1D2BB1E1631F5B1`
- **JHash:** `0x02F283CE`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_COMMUNITY_SYNCH_IS_PENDING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_DELETE_SLOT

- **命名空间:** `STATS`
- **Hash:** `0x49A49BED12794D70`
- **JHash:** `0x2F171B94`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_DELETE_SLOT(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p0 is characterSlot? seems range from 0 to 2
```

---

### STAT_DISABLE_STATS_TRACKING

- **命名空间:** `STATS`
- **Hash:** `0x629526ABA383BCAA`
- **Build:** `323`

**C# 签名:**
```csharp
void STAT_DISABLE_STATS_TRACKING()
```

**返回值:** `void` (Native: `void`)

**说明:**
```
Prevents updates to CStatsMgr (e.g., STAT_SET_* natives)
```

---

### STAT_ENABLE_STATS_TRACKING

- **命名空间:** `STATS`
- **Hash:** `0x98E2BC1CA26287C3`
- **Build:** `323`

**C# 签名:**
```csharp
void STAT_ENABLE_STATS_TRACKING()
```

**返回值:** `void` (Native: `void`)

---

### STAT_GET_BLOCK_SAVES

- **命名空间:** `STATS`
- **Hash:** `0x6A7F19756F1A9016`
- **Build:** `2060`

**C# 签名:**
```csharp
bool STAT_GET_BLOCK_SAVES()
```

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_GET_BOOL

- **命名空间:** `STATS`
- **Hash:** `0x11B5E6D2AE73F48E`
- **JHash:** `0x28A3DD2B`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_GET_BOOL(uint statHash, ref bool outValue, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statHash` | `Hash` | `uint` | - |
| `outValue` | `BOOL*` | `ref bool` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_GET_CANCEL_SAVE_MIGRATION_STATUS

- **命名空间:** `STATS`
- **Hash:** `0x567384DFA67029E6`
- **Build:** `323`

**C# 签名:**
```csharp
int STAT_GET_CANCEL_SAVE_MIGRATION_STATUS()
```

**返回值:** `int` (Native: `int`)

---

### STAT_GET_CHALLENGE_FLYING_DIST

- **命名空间:** `STATS`
- **Hash:** `0x6E0A5253375C4584`
- **Build:** `463`

**C# 签名:**
```csharp
float STAT_GET_CHALLENGE_FLYING_DIST()
```

**返回值:** `float` (Native: `float`)

**说明:**
```
Fly low to the ground for the longest distance
```

---

### STAT_GET_CURRENT_DRIVE_NOCRASH_DISTANCE

- **命名空间:** `STATS`
- **Hash:** `0xBA9749CC94C1FD85`
- **Build:** `463`

**C# 签名:**
```csharp
float STAT_GET_CURRENT_DRIVE_NOCRASH_DISTANCE()
```

**返回值:** `float` (Native: `float`)

**说明:**
```
Drive the furthest distance in a land vehicle without crashing
```

---

### STAT_GET_CURRENT_DRIVING_REVERSE_DISTANCE

- **命名空间:** `STATS`
- **Hash:** `0x32CAC93C9DE73D32`
- **Build:** `463`

**C# 签名:**
```csharp
float STAT_GET_CURRENT_DRIVING_REVERSE_DISTANCE()
```

**返回值:** `float` (Native: `float`)

**说明:**
```
Reverse the longest distance without crashing
```

---

### STAT_GET_CURRENT_FRONT_WHEEL_DISTANCE

- **命名空间:** `STATS`
- **Hash:** `0x84A810B375E69C0E`
- **Build:** `463`

**C# 签名:**
```csharp
float STAT_GET_CURRENT_FRONT_WHEEL_DISTANCE()
```

**返回值:** `float` (Native: `float`)

**说明:**
```
Perform the longest stoppie on a motorcycle
```

---

### STAT_GET_CURRENT_JUMP_DISTANCE

- **命名空间:** `STATS`
- **Hash:** `0x9EC8858184CD253A`
- **Build:** `463`

**C# 签名:**
```csharp
float STAT_GET_CURRENT_JUMP_DISTANCE()
```

**返回值:** `float` (Native: `float`)

**说明:**
```
Perform the longest jump in a land vehicle
```

---

### STAT_GET_CURRENT_NEAR_MISS_NOCRASH_PRECISE

- **命名空间:** `STATS`
- **Hash:** `0xE8853FBCE7D8D0D6`
- **Build:** `463`

**C# 签名:**
```csharp
int STAT_GET_CURRENT_NEAR_MISS_NOCRASH_PRECISE()
```

**返回值:** `int` (Native: `int`)

**说明:**
```
Perform the most near misses with other vehicles in a land vehicle without crashing
```

---

### STAT_GET_CURRENT_REAR_WHEEL_DISTANCE

- **命名空间:** `STATS`
- **Hash:** `0xA943FD1722E11EFD`
- **Build:** `463`

**C# 签名:**
```csharp
float STAT_GET_CURRENT_REAR_WHEEL_DISTANCE()
```

**返回值:** `float` (Native: `float`)

**说明:**
```
Perform the longest wheelie on a motorcycle
```

---

### STAT_GET_CURRENT_SKYDIVING_DISTANCE

- **命名空间:** `STATS`
- **Hash:** `0xAFF47709F1D5DCCE`
- **Build:** `463`

**C# 签名:**
```csharp
float STAT_GET_CURRENT_SKYDIVING_DISTANCE()
```

**返回值:** `float` (Native: `float`)

**说明:**
```
Fall the longest distance with a parachute before opening it
```

---

### STAT_GET_CURRENT_SPEED

- **命名空间:** `STATS`
- **Hash:** `0x55A8BECAF28A4EB7`
- **Build:** `463`

**C# 签名:**
```csharp
float STAT_GET_CURRENT_SPEED()
```

**返回值:** `float` (Native: `float`)

**说明:**
```
Achieve the highest speed in a land vehicle
```

---

### STAT_GET_DATE

- **命名空间:** `STATS`
- **Hash:** `0x8B0FACEFC36C824B`
- **JHash:** `0xD762D16C`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_GET_DATE(uint statHash, ref object outValue, int numFields, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statHash` | `Hash` | `uint` | - |
| `outValue` | `Any*` | `ref object` | - |
| `numFields` | `int` | `int` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p3 is probably characterSlot or BOOL save, always -1
```

---

### STAT_GET_FLOAT

- **命名空间:** `STATS`
- **Hash:** `0xD7AE6C9C9C6AC54C`
- **JHash:** `0xFCBDA612`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_GET_FLOAT(uint statHash, ref float outValue, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statHash` | `Hash` | `uint` | - |
| `outValue` | `float*` | `ref float` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_GET_FLYING_ALTITUDE

- **命名空间:** `STATS`
- **Hash:** `0x1A8EA222F9C67DBB`
- **Build:** `463`

**C# 签名:**
```csharp
bool STAT_GET_FLYING_ALTITUDE(ref float outValue)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `outValue` | `float*` | `ref float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_GET_INT

- **命名空间:** `STATS`
- **Hash:** `0x767FBC2AC802EF3D`
- **JHash:** `0x1C6FE43E`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_GET_INT(uint statHash, ref int outValue, int p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statHash` | `Hash` | `uint` | - |
| `outValue` | `int*` | `ref int` | - |
| `p2` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p2 appears to always be -1

```

---

### STAT_GET_LICENSE_PLATE

- **命名空间:** `STATS`
- **Hash:** `0x5473D4195058B2E4`
- **JHash:** `0x1544B29F`
- **Build:** `323`

**C# 签名:**
```csharp
string STAT_GET_LICENSE_PLATE(uint statName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statName` | `Hash` | `uint` | - |

**返回值:** `string` (Native: `const char*`)

---

### STAT_GET_LOAD_SAFE_TO_PROGRESS_TO_MP_FROM_SP

- **命名空间:** `STATS`
- **Hash:** `0xC0E0D686DDFC6EAE`
- **JHash:** `0x099FCC86`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_GET_LOAD_SAFE_TO_PROGRESS_TO_MP_FROM_SP()
```

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_GET_MASKED_INT

- **命名空间:** `STATS`
- **Hash:** `0x655185A06D9EEAAB`
- **JHash:** `0xE9D9B70F`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_GET_MASKED_INT(uint statHash, ref int outValue, int p2, int p3, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statHash` | `Hash` | `uint` | - |
| `outValue` | `int*` | `ref int` | - |
| `p2` | `int` | `int` | - |
| `p3` | `int` | `int` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p4 is probably characterSlot or BOOL save
```

---

### STAT_GET_NUMBER_OF_DAYS

- **命名空间:** `STATS`
- **Hash:** `0xE0E854F5280FB769`
- **JHash:** `0xFD66A429`
- **Build:** `323`

**C# 签名:**
```csharp
int STAT_GET_NUMBER_OF_DAYS(uint statName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statName` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

---

### STAT_GET_NUMBER_OF_HOURS

- **命名空间:** `STATS`
- **Hash:** `0xF2D4B2FE415AAFC3`
- **JHash:** `0x9B431236`
- **Build:** `323`

**C# 签名:**
```csharp
int STAT_GET_NUMBER_OF_HOURS(uint statName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statName` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

---

### STAT_GET_NUMBER_OF_MINUTES

- **命名空间:** `STATS`
- **Hash:** `0x7583B4BE4C5A41B5`
- **JHash:** `0x347B4436`
- **Build:** `323`

**C# 签名:**
```csharp
int STAT_GET_NUMBER_OF_MINUTES(uint statName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statName` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

---

### STAT_GET_NUMBER_OF_SECONDS

- **命名空间:** `STATS`
- **Hash:** `0x2CE056FF3723F00B`
- **JHash:** `0x2C1D6C31`
- **Build:** `323`

**C# 签名:**
```csharp
int STAT_GET_NUMBER_OF_SECONDS(uint statName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statName` | `Hash` | `uint` | - |

**返回值:** `int` (Native: `int`)

---

### STAT_GET_POS

- **命名空间:** `STATS`
- **Hash:** `0x350F82CCB186AA1B`
- **JHash:** `0xC846ECCE`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_GET_POS(uint statName, ref float outX, ref float outY, ref float outZ, object p4)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statName` | `Hash` | `uint` | - |
| `outX` | `float*` | `ref float` | - |
| `outY` | `float*` | `ref float` | - |
| `outZ` | `float*` | `ref float` | - |
| `p4` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p3 is probably characterSlot or BOOL save, always -1
```

---

### STAT_GET_RECORDED_VALUE

- **命名空间:** `STATS`
- **Hash:** `0xF11F01D98113536A`
- **Build:** `463`

**C# 签名:**
```csharp
bool STAT_GET_RECORDED_VALUE(ref float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `value` | `float*` | `ref float` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_GET_SAVE_MIGRATION_CONSUME_CONTENT_STATUS

- **命名空间:** `STATS`
- **Hash:** `0xCE5AA445ABA8DEE0`
- **Build:** `323`

**C# 签名:**
```csharp
int STAT_GET_SAVE_MIGRATION_CONSUME_CONTENT_STATUS(ref int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int*` | `ref int` | - |

**返回值:** `int` (Native: `int`)

---

### STAT_GET_SAVE_MIGRATION_STATUS

- **命名空间:** `STATS`
- **Hash:** `0x886913BBEACA68C1`
- **JHash:** `0xE3F0D62D`
- **Build:** `323`

**C# 签名:**
```csharp
int STAT_GET_SAVE_MIGRATION_STATUS(ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |

**返回值:** `int` (Native: `int`)

---

### STAT_GET_STRING

- **命名空间:** `STATS`
- **Hash:** `0xE50384ACC2C3DB74`
- **JHash:** `0x10CE4BDE`
- **Build:** `323`

**C# 签名:**
```csharp
string STAT_GET_STRING(uint statHash, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statHash` | `Hash` | `uint` | - |
| `p1` | `int` | `int` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
p1 is always -1 in the script files
```

---

### STAT_GET_USER_ID

- **命名空间:** `STATS`
- **Hash:** `0x2365C388E393BBE2`
- **JHash:** `0xE2E8B6BA`
- **Build:** `323`

**C# 签名:**
```csharp
string STAT_GET_USER_ID(uint statHash)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statHash` | `Hash` | `uint` | - |

**返回值:** `string` (Native: `const char*`)

**说明:**
```
Returns the rockstar ID (user id) value of a given stat. Returns "STAT_UNKNOWN" if the statHash is invalid or the stat has no userId
```

---

### STAT_GET_VEHICLE_BAIL_DISTANCE

- **命名空间:** `STATS`
- **Hash:** `0x0B8B7F74BF061C6D`
- **Build:** `463`

**C# 签名:**
```csharp
float STAT_GET_VEHICLE_BAIL_DISTANCE()
```

**返回值:** `float` (Native: `float`)

**说明:**
```
Travel the furthest distance when bailing from a vehicle
```

---

### STAT_INCREMENT

- **命名空间:** `STATS`
- **Hash:** `0x9B5A68C6489E9909`
- **JHash:** `0xDFC5F71E`
- **Build:** `323`

**C# 签名:**
```csharp
void STAT_INCREMENT(uint statName, float value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statName` | `Hash` | `uint` | - |
| `value` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### STAT_IS_PLAYER_VEHICLE_ABOVE_OCEAN

- **命名空间:** `STATS`
- **Hash:** `0xF9F2922717B819EC`
- **Build:** `505`

**C# 签名:**
```csharp
bool STAT_IS_PLAYER_VEHICLE_ABOVE_OCEAN()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Or non-flyable area
```

---

### STAT_IS_RECORDING_STAT

- **命名空间:** `STATS`
- **Hash:** `0x8B9CDBD6C566C38C`
- **Build:** `944`

**C# 签名:**
```csharp
bool STAT_IS_RECORDING_STAT()
```

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_IS_STATS_TRACKING_ENABLED

- **命名空间:** `STATS`
- **Hash:** `0xBE3DB208333D9844`
- **Build:** `463`

**C# 签名:**
```csharp
bool STAT_IS_STATS_TRACKING_ENABLED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_LOAD

- **命名空间:** `STATS`
- **Hash:** `0xA651443F437B1CE6`
- **JHash:** `0x9E5629F4`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_LOAD(int statSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statSlot` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_LOAD_DIRTY_READ_DETECTED

- **命名空间:** `STATS`
- **Hash:** `0xECB41AC6AB754401`
- **JHash:** `0xED7000C8`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_LOAD_DIRTY_READ_DETECTED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_LOAD_PENDING

- **命名空间:** `STATS`
- **Hash:** `0xA1750FFAFA181661`
- **JHash:** `0x4E9AC983`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_LOAD_PENDING(int statSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statSlot` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_LOCAL_RESET_ALL_ONLINE_CHARACTER_STATS

- **命名空间:** `STATS`
- **Hash:** `0xA78B8FA58200DA56`
- **JHash:** `0xE3247582`
- **Build:** `323`

**C# 签名:**
```csharp
void STAT_LOCAL_RESET_ALL_ONLINE_CHARACTER_STATS(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p0 seems to range from 0 to 7
```

---

### STAT_MIGRATE_CHECK_ALREADY_DONE

- **命名空间:** `STATS`
- **Hash:** `0x4C89FE2BDEB3F169`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_MIGRATE_CHECK_ALREADY_DONE()
```

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_MIGRATE_CHECK_GET_IS_PLATFORM_AVAILABLE

- **命名空间:** `STATS`
- **Hash:** `0x5BD5F255321C4AAF`
- **Build:** `323`

**C# 签名:**
```csharp
int STAT_MIGRATE_CHECK_GET_IS_PLATFORM_AVAILABLE(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

---

### STAT_MIGRATE_CHECK_GET_PLATFORM_STATUS

- **命名空间:** `STATS`
- **Hash:** `0xDEAAF77EB3687E97`
- **Build:** `323`

**C# 签名:**
```csharp
int STAT_MIGRATE_CHECK_GET_PLATFORM_STATUS(int p0, ref object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `Any*` | `ref object` | - |

**返回值:** `int` (Native: `int`)

---

### STAT_MIGRATE_CHECK_START

- **命名空间:** `STATS`
- **Hash:** `0xC6E0E2616A7576BB`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_MIGRATE_CHECK_START()
```

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_MIGRATE_CLEAR_FOR_RESTART

- **命名空间:** `STATS`
- **Hash:** `0xC847B43F369AC0B5`
- **Build:** `323`

**C# 签名:**
```csharp
void STAT_MIGRATE_CLEAR_FOR_RESTART()
```

**返回值:** `void` (Native: `void`)

---

### STAT_MIGRATE_SAVEGAME_GET_STATUS

- **命名空间:** `STATS`
- **Hash:** `0x9A62EC95AE10E011`
- **Build:** `323`

**C# 签名:**
```csharp
int STAT_MIGRATE_SAVEGAME_GET_STATUS()
```

**返回值:** `int` (Native: `int`)

---

### STAT_MIGRATE_SAVEGAME_START

- **命名空间:** `STATS`
- **Hash:** `0xA5C80D8E768A9E66`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_MIGRATE_SAVEGAME_START(string platformName)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `platformName` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
platformName must be one of the following: ps3, xbox360, ps4, xboxone
```

---

### STAT_NETWORK_INCREMENT_ON_SUICIDE

- **命名空间:** `STATS`
- **Hash:** `0x428EAF89E24F6C36`
- **JHash:** `0xEE292B91`
- **Build:** `323`

**C# 签名:**
```csharp
void STAT_NETWORK_INCREMENT_ON_SUICIDE(object p0, float p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `float` | `float` | - |

**返回值:** `void` (Native: `void`)

---

### STAT_RESET_ALL_ONLINE_CHARACTER_STATS

- **命名空间:** `STATS`
- **Hash:** `0x26D7399B9587FE89`
- **JHash:** `0x343B27E2`
- **Build:** `323`

**C# 签名:**
```csharp
void STAT_RESET_ALL_ONLINE_CHARACTER_STATS(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
p0 seems to range from 0 to 7
```

---

### STAT_ROLLBACK_SAVE_MIGRATION

- **命名空间:** `STATS`
- **Hash:** `0xB3DA2606774A8E2D`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_ROLLBACK_SAVE_MIGRATION()
```

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
This function is hard-coded to always return 1.
```

---

### STAT_SAVE

- **命名空间:** `STATS`
- **Hash:** `0xE07BCA305B82D2FD`
- **JHash:** `0xE10A7CA4`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_SAVE(int p0, bool p1, int p2, bool p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `int` | `int` | - |
| `p3` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_SAVE_MIGRATION_CANCEL_PENDING_OPERATION

- **命名空间:** `STATS`
- **Hash:** `0x4FEF53183C3C6414`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_SAVE_MIGRATION_CANCEL_PENDING_OPERATION()
```

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_SAVE_MIGRATION_CONSUME_CONTENT

- **命名空间:** `STATS`
- **Hash:** `0x3270F67EED31FBC1`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_SAVE_MIGRATION_CONSUME_CONTENT(uint contentId, string srcPlatform, string srcGamerHandle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `contentId` | `Hash` | `uint` | - |
| `srcPlatform` | `const char*` | `string` | - |
| `srcGamerHandle` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_SAVE_PENDING

- **命名空间:** `STATS`
- **Hash:** `0x7D3A583856F2C5AC`
- **JHash:** `0xC3FD3822`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_SAVE_PENDING()
```

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_SAVE_PENDING_OR_REQUESTED

- **命名空间:** `STATS`
- **Hash:** `0xBBB6AD006F1BBEA3`
- **JHash:** `0xA3407CA3`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_SAVE_PENDING_OR_REQUESTED()
```

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_SET_BLOCK_SAVES

- **命名空间:** `STATS`
- **Hash:** `0xF434A10BA01C37D0`
- **JHash:** `0xCE7A2411`
- **Build:** `323`

**C# 签名:**
```csharp
void STAT_SET_BLOCK_SAVES(bool toggle)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `toggle` | `BOOL` | `bool` | - |

**返回值:** `void` (Native: `void`)

---

### STAT_SET_BOOL

- **命名空间:** `STATS`
- **Hash:** `0x4B33C4243DE0C432`
- **JHash:** `0x55D79DFB`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_SET_BOOL(uint statName, bool value, bool save)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statName` | `Hash` | `uint` | - |
| `value` | `BOOL` | `bool` | - |
| `save` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Example:
 STATS::STAT_SET_BOOL(MISC::GET_HASH_KEY("MPPLY_MELEECHLENGECOMPLETED"), trur, true);
```

---

### STAT_SET_CHEAT_IS_ACTIVE

- **命名空间:** `STATS`
- **Hash:** `0x047CBED6F6F8B63C`
- **JHash:** `0xA063CABD`
- **Build:** `323`

**C# 签名:**
```csharp
void STAT_SET_CHEAT_IS_ACTIVE()
```

**返回值:** `void` (Native: `void`)

---

### STAT_SET_CURRENT_POSIX_TIME

- **命名空间:** `STATS`
- **Hash:** `0xC2F84B7F9C4D0C61`
- **JHash:** `0xA286F015`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_SET_CURRENT_POSIX_TIME(uint statName, bool p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statName` | `Hash` | `uint` | - |
| `p1` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
p1 always true.
```

---

### STAT_SET_DATE

- **命名空间:** `STATS`
- **Hash:** `0x2C29BFB64F4FCBE4`
- **JHash:** `0x36BE807B`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_SET_DATE(uint statName, ref object value, int numFields, bool save)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statName` | `Hash` | `uint` | - |
| `value` | `Any*` | `ref object` | - |
| `numFields` | `int` | `int` | - |
| `save` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
'value' is a structure to a structure, 'numFields' is how many fields there are in said structure (usually 7).

The structure looks like this:

int year
int month
int day
int hour
int minute
int second
int millisecond

The decompiled scripts use TIME::GET_POSIX_TIME to fill this structure.
```

---

### STAT_SET_FLOAT

- **命名空间:** `STATS`
- **Hash:** `0x4851997F37FE9B3C`
- **JHash:** `0x6CEA96F2`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_SET_FLOAT(uint statName, float value, bool save)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statName` | `Hash` | `uint` | - |
| `value` | `float` | `float` | - |
| `save` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Example:
 STATS::STAT_SET_FLOAT(MISC::GET_HASH_KEY("MP0_WEAPON_ACCURACY"), 66.6f, true);
```

---

### STAT_SET_GXT_LABEL

- **命名空间:** `STATS`
- **Hash:** `0x17695002FD8B2AE0`
- **JHash:** `0xC1224AA7`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_SET_GXT_LABEL(uint statName, string value, bool save)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statName` | `Hash` | `uint` | - |
| `value` | `const char*` | `string` | - |
| `save` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
The following values have been found in the decompiled scripts:
"RC_ABI1"
"RC_ABI2"
"RC_BA1"
"RC_BA2"
"RC_BA3"
"RC_BA3A"
"RC_BA3C"
"RC_BA4"
"RC_DRE1"
"RC_EPS1"
"RC_EPS2"
"RC_EPS3"
"RC_EPS4"
"RC_EPS5"
"RC_EPS6"
"RC_EPS7"
"RC_EPS8"
"RC_EXT1"
"RC_EXT2"
"RC_EXT3"
"RC_EXT4"
"RC_FAN1"
"RC_FAN2"
"RC_FAN3"
"RC_HAO1"
"RC_HUN1"
"RC_HUN2"
"RC_JOS1"
"RC_JOS2"
"RC_JOS3"
"RC_JOS4"
"RC_MAU1"
"RC_MIN1"
"RC_MIN2"
"RC_MIN3"
"RC_MRS1"
"RC_MRS2"
"RC_NI1"
"RC_NI1A"
"RC_NI1B"
"RC_NI1C"
"RC_NI1D"
"RC_NI2"
"RC_NI3"
"RC_OME1"
"RC_OME2"
"RC_PA1"
"RC_PA2"
"RC_PA3"
"RC_PA3A"
"RC_PA3B"
"RC_PA4"
"RC_RAM1"
"RC_RAM2"
"RC_RAM3"
"RC_RAM4"
"RC_RAM5"
"RC_SAS1"
"RC_TON1"
"RC_TON2"
"RC_TON3"
"RC_TON4"
"RC_TON5"
```

---

### STAT_SET_INT

- **命名空间:** `STATS`
- **Hash:** `0xB3271D7AB655B441`
- **JHash:** `0xC9CC1C5C`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_SET_INT(uint statName, int value, bool save)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statName` | `Hash` | `uint` | - |
| `value` | `int` | `int` | - |
| `save` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
Example:
 STATS::STAT_SET_INT(MISC::GET_HASH_KEY("MPPLY_KILLS_PLAYERS"), 1337, true);
```

---

### STAT_SET_LICENSE_PLATE

- **命名空间:** `STATS`
- **Hash:** `0x69FF13266D7296DA`
- **JHash:** `0x3507D253`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_SET_LICENSE_PLATE(uint statName, string str)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statName` | `Hash` | `uint` | - |
| `str` | `const char*` | `string` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_SET_MASKED_INT

- **命名空间:** `STATS`
- **Hash:** `0x7BBB1B54583ED410`
- **JHash:** `0x2CBAA739`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_SET_MASKED_INT(uint statName, int p1, int p2, int p3, bool save)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statName` | `Hash` | `uint` | - |
| `p1` | `int` | `int` | - |
| `p2` | `int` | `int` | - |
| `p3` | `int` | `int` | - |
| `save` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_SET_OPEN_SAVETYPE_IN_JOB

- **命名空间:** `STATS`
- **Hash:** `0x5688585E6D563CD8`
- **JHash:** `0xC62406A6`
- **Build:** `323`

**C# 签名:**
```csharp
void STAT_SET_OPEN_SAVETYPE_IN_JOB(int p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### STAT_SET_POS

- **命名空间:** `STATS`
- **Hash:** `0xDB283FDE680FE72E`
- **JHash:** `0x1192C9A3`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_SET_POS(uint statName, float x, float y, float z, bool save)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statName` | `Hash` | `uint` | - |
| `x` | `float` | `float` | - |
| `y` | `float` | `float` | - |
| `z` | `float` | `float` | - |
| `save` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_SET_PROFILE_SETTING_VALUE

- **命名空间:** `STATS`
- **Hash:** `0x68F01422BE1D838F`
- **JHash:** `0x24DD4929`
- **Build:** `323`

**C# 签名:**
```csharp
void STAT_SET_PROFILE_SETTING_VALUE(int profileSetting, int value)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `profileSetting` | `int` | `int` | - |
| `value` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Does not take effect immediately, unfortunately.

profileSetting seems to only be 936, 937 and 938 in scripts
```

---

### STAT_SET_STRING

- **命名空间:** `STATS`
- **Hash:** `0xA87B2335D12531D7`
- **JHash:** `0xB1EF2E21`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_SET_STRING(uint statName, string value, bool save)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statName` | `Hash` | `uint` | - |
| `value` | `const char*` | `string` | - |
| `save` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_SET_USER_ID

- **命名空间:** `STATS`
- **Hash:** `0x8CDDF1E452BABE11`
- **JHash:** `0xDBE78ED7`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_SET_USER_ID(uint statName, string value, bool save)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statName` | `Hash` | `uint` | - |
| `value` | `const char*` | `string` | - |
| `save` | `BOOL` | `bool` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_SLOT_IS_LOADED

- **命名空间:** `STATS`
- **Hash:** `0x0D0A9F0E7BD91E3C`
- **JHash:** `0x7A299C13`
- **Build:** `323`

**C# 签名:**
```csharp
bool STAT_SLOT_IS_LOADED(int statSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statSlot` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

---

### STAT_START_RECORD_STAT

- **命名空间:** `STATS`
- **Hash:** `0x33D72899E24C3365`
- **Build:** `463`

**C# 签名:**
```csharp
bool STAT_START_RECORD_STAT(int statType, int valueType)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `statType` | `int` | `int` | - |
| `valueType` | `int` | `int` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
enum StatTrackingType
{
	LongestWheelie = 1,
	LongestStoppie = 2,
	NoCrashes = 3,
	HighestSpeed = 4,
	_MostFlips = 5,
	_LongestSpin = 6,
	_HighestJumpReached = 7,
	LongestJump = 8,
	_NearMissesNoCrash = 9,
	LongestFallSurvived = 10,
	LowestParachute = 11,
	ReverseDriving = 12,
	LongestFreefall = 13,
	VehiclesStolen = 14,
	_SomeCFireEventCount = 15,
	_Unk16 = 16,
	_LowFlyingTime = 17,
	LowFlying = 18,
	_InvertedFlyingTime = 19,
	InvertedFlying = 20,
	_PlaneSpinCount = 21,
	MeleeKills = 22, // Players
	_LongestSniperKill = 23,
	SniperSkills = 24, // Players
	DrivebyKills = 25, // Players
	HeadshotKills = 26, // Players
	LongestBail = 27,
	_TotalRammedByCar = 28,
	NearMissesPrecise = 29,
	_FreefallTime = 30,
	Unk31 = 31,
}

enum StatTrackingValueType
{
	Total,
	Max,
	Min
}
```

---

### STAT_STOP_RECORD_STAT

- **命名空间:** `STATS`
- **Hash:** `0xA761D4AC6115623D`
- **Build:** `463`

**C# 签名:**
```csharp
bool STAT_STOP_RECORD_STAT()
```

**返回值:** `bool` (Native: `BOOL`)

---

### WAS_VC_WITHDRAWAL_SUCCESSFUL

- **命名空间:** `MONEY`
- **Hash:** `0x6FCF8DDEA146C45B`
- **JHash:** `0xB96C7ABE`
- **Build:** `323`

**C# 签名:**
```csharp
bool WAS_VC_WITHDRAWAL_SUCCESSFUL(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `bool` (Native: `BOOL`)

**说明:**
```
This function is hard-coded to always return 1.
```

---

### WITHDRAW_VC

- **命名空间:** `MONEY`
- **Hash:** `0xF70EFA14FE091429`
- **JHash:** `0x8B755993`
- **Build:** `323`

**C# 签名:**
```csharp
int WITHDRAW_VC(int amount)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |

**返回值:** `int` (Native: `int`)

**说明:**
```
Does nothing and always returns 0.
```

---

### _GET_STAT_HASH_FOR_CHARACTER_STAT

- **命名空间:** `STATS`
- **Hash:** `0xD69CE161FE614531`
- **Build:** `2944`

**C# 签名:**
```csharp
uint _GET_STAT_HASH_FOR_CHARACTER_STAT(int dataType, int statIndex, int charSlot)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `dataType` | `int` | `int` | - |
| `statIndex` | `int` | `int` | - |
| `charSlot` | `int` | `int` | - |

**返回值:** `uint` (Native: `Hash`)

**说明:**
```
Returns stat hash based on dataType, statIndex/statId and characterSlot. Related to CStatsMpCharacterMappingData
```

---

### _NETWORK_CLEAR_TRANSACTION_TELEMETRY_NONCE

- **命名空间:** `MONEY`
- **Hash:** `0xE03B9F95556E48E9`
- **Build:** `3095`

**C# 签名:**
```csharp
void _NETWORK_CLEAR_TRANSACTION_TELEMETRY_NONCE()
```

**返回值:** `void` (Native: `void`)

---

### _NETWORK_EARN_AVENGER

- **命名空间:** `MONEY`
- **Hash:** `0x55F006B9D4A46C1D`
- **Build:** `2944`

**C# 签名:**
```csharp
void _NETWORK_EARN_AVENGER(int amount, int p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Used for SERVICE_EARN_AVENGER_OPERATIONS & SERVICE_EARN_AVENGER_OPS_BONUS
```

---

### _NETWORK_EARN_AWARD_ACID_LAB

- **命名空间:** `MONEY`
- **Hash:** `0xD1A8165767AD2D23`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_EARN_AWARD_ACID_LAB(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_EARN_AWARD_DAILY_STASH

- **命名空间:** `MONEY`
- **Hash:** `0xC30650FA74A19D02`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_EARN_AWARD_DAILY_STASH(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_EARN_AWARD_DEAD_DROP

- **命名空间:** `MONEY`
- **Hash:** `0xD01EBAEA1F905EF6`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_EARN_AWARD_DEAD_DROP(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_EARN_AWARD_JUGGALO_MISSION

- **命名空间:** `MONEY`
- **Hash:** `0xDDF047577F1A02A7`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_EARN_AWARD_JUGGALO_MISSION(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_EARN_AWARD_RANDOM_EVENT

- **命名空间:** `MONEY`
- **Hash:** `0xBEAFBB1B98B7EF55`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_EARN_AWARD_RANDOM_EVENT(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_EARN_AWARD_TAXI

- **命名空间:** `MONEY`
- **Hash:** `0xA914768AD35CD3A5`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_EARN_AWARD_TAXI(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_EARN_BONUS_OBJECTIVE

- **命名空间:** `MONEY`
- **Hash:** `0xDCEF983C24191997`
- **Build:** `2944`

**C# 签名:**
```csharp
void _NETWORK_EARN_BONUS_OBJECTIVE(int amount, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_EARN_DAILY_STASH_HOUSE_COMPLETED

- **命名空间:** `MONEY`
- **Hash:** `0xCABC9874AFA70D6D`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_EARN_DAILY_STASH_HOUSE_COMPLETED(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_EARN_DAILY_STASH_HOUSE_PARTICIPATION

- **命名空间:** `MONEY`
- **Hash:** `0x9C0C6BD0F94CE391`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_EARN_DAILY_STASH_HOUSE_PARTICIPATION(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_EARN_FOOLIGAN_JOB

- **命名空间:** `MONEY`
- **Hash:** `0xCE4452AE85F5E252`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_EARN_FOOLIGAN_JOB(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
JUGGALO_PHONE_MISSION...
```

---

### _NETWORK_EARN_FOOLIGAN_JOB_PARTICIPATION

- **命名空间:** `MONEY`
- **Hash:** `0xC376B92D0E060970`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_EARN_FOOLIGAN_JOB_PARTICIPATION(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
JUGGALO_PHONE_MISSION_PARTICIPATION...
```

---

### _NETWORK_EARN_GENERIC

- **命名空间:** `MONEY`
- **Hash:** `0xBF7B5BB7ED890380`
- **Build:** `3095`

**C# 签名:**
```csharp
void _NETWORK_EARN_GENERIC(int amount, uint earn, string p2, string p3, ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `earn` | `Hash` | `uint` | - |
| `p2` | `const char*` | `string` | - |
| `p3` | `const char*` | `string` | - |
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
_NETWORK_EARN_G*
```

---

### _NETWORK_EARN_JUGGALO_STORY_MISSION

- **命名空间:** `MONEY`
- **Hash:** `0xE01D10BA8CD53621`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_EARN_JUGGALO_STORY_MISSION(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_EARN_JUGGALO_STORY_MISSION_PARTICIPATION

- **命名空间:** `MONEY`
- **Hash:** `0x40FF6CCCC476185C`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_EARN_JUGGALO_STORY_MISSION_PARTICIPATION(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_EARN_PROGRESS_HUB

- **命名空间:** `MONEY`
- **Hash:** `0xF8332B06F0EECC9C`
- **Build:** `2944`

**C# 签名:**
```csharp
void _NETWORK_EARN_PROGRESS_HUB(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_EARN_SELL_ACID

- **命名空间:** `MONEY`
- **Hash:** `0x79B656937DF6DF5D`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_EARN_SELL_ACID(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_EARN_SELL_PARTICIPATION_ACID_LAB

- **命名空间:** `MONEY`
- **Hash:** `0xCA3EF9B09A8D76B4`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_EARN_SELL_PARTICIPATION_ACID_LAB(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_EARN_SETUP_PARTICIPATION_ACID_LAB

- **命名空间:** `MONEY`
- **Hash:** `0xE3942D59E8A7F70D`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_EARN_SETUP_PARTICIPATION_ACID_LAB(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_EARN_SMUGGLER_OPS

- **命名空间:** `MONEY`
- **Hash:** `0xDEA273D5F8A9661A`
- **Build:** `2944`

**C# 签名:**
```csharp
void _NETWORK_EARN_SMUGGLER_OPS(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_EARN_SOURCE_PARTICIPATION_ACID_LAB

- **命名空间:** `MONEY`
- **Hash:** `0x136F11B5DF1B304D`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_EARN_SOURCE_PARTICIPATION_ACID_LAB(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_EARN_STREET_DEALER

- **命名空间:** `MONEY`
- **Hash:** `0xA81017EE1324FDFE`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_EARN_STREET_DEALER(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_EARN_TAXI_JOB

- **命名空间:** `MONEY`
- **Hash:** `0x991E1588FAD9019D`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_EARN_TAXI_JOB(object p0, object p1)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_SPEND_BUY_ACID_LAB

- **命名空间:** `MONEY`
- **Hash:** `0xF1E26A7924327152`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_SPEND_BUY_ACID_LAB(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_SPEND_BUY_MFGARAGE

- **命名空间:** `MONEY`
- **Hash:** `0xA2ED36DCF0FCA413`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_SPEND_BUY_MFGARAGE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_SPEND_BUY_SUPPLIES

- **命名空间:** `MONEY`
- **Hash:** `0xB48185C0CA67B16B`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_SPEND_BUY_SUPPLIES(int p0, bool p1, bool p2, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_SPEND_RENAME_ACID_LAB

- **命名空间:** `MONEY`
- **Hash:** `0x842B1C5AF61ACDE9`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_SPEND_RENAME_ACID_LAB(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_SPEND_RENAME_ACID_PRODUCT

- **命名空间:** `MONEY`
- **Hash:** `0x446798F7495DD7D8`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_SPEND_RENAME_ACID_PRODUCT(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_SPEND_UPGRADE_ACID_LAB_ARMOR

- **命名空间:** `MONEY`
- **Hash:** `0xA7D541C9ACD63133`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_SPEND_UPGRADE_ACID_LAB_ARMOR(int p0, bool p1, bool p2, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_SPEND_UPGRADE_ACID_LAB_EQUIPMENT

- **命名空间:** `MONEY`
- **Hash:** `0x110EE9D486C23126`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_SPEND_UPGRADE_ACID_LAB_EQUIPMENT(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_SPEND_UPGRADE_ACID_LAB_MINES

- **命名空间:** `MONEY`
- **Hash:** `0x4B99AB08C92C54E4`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_SPEND_UPGRADE_ACID_LAB_MINES(int p0, bool p1, bool p2, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_SPEND_UPGRADE_ACID_LAB_SCOOP

- **命名空间:** `MONEY`
- **Hash:** `0x2940558E05BCC2EC`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_SPEND_UPGRADE_ACID_LAB_SCOOP(int p0, bool p1, bool p2, int p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `p3` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_SPEND_UPGRADE_MFGARAGE

- **命名空间:** `MONEY`
- **Hash:** `0xCF8F346DDDC66643`
- **Build:** `2802`

**C# 签名:**
```csharp
void _NETWORK_SPEND_UPGRADE_MFGARAGE(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_SPENT_AIR_FREIGHT

- **命名空间:** `MONEY`
- **Hash:** `0x8C7E8D6F96C9E948`
- **Build:** `2944`

**C# 签名:**
```csharp
void _NETWORK_SPENT_AIR_FREIGHT(int hangarCargoSourcingPrice, bool fromBank, bool fromBankAndWallet, int cost, int warehouseId, int warehouseSlot, object p6)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `hangarCargoSourcingPrice` | `int` | `int` | - |
| `fromBank` | `BOOL` | `bool` | - |
| `fromBankAndWallet` | `BOOL` | `bool` | - |
| `cost` | `int` | `int` | - |
| `warehouseId` | `int` | `int` | - |
| `warehouseSlot` | `int` | `int` | - |
| `p6` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_SPENT_GENERIC

- **命名空间:** `MONEY`
- **Hash:** `0x2803B027479FB640`
- **Build:** `3095`

**C# 签名:**
```csharp
void _NETWORK_SPENT_GENERIC(int price, bool p1, bool p2, uint stat, uint spent, string p5, string p6, ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `price` | `int` | `int` | - |
| `p1` | `BOOL` | `bool` | - |
| `p2` | `BOOL` | `bool` | - |
| `stat` | `Hash` | `uint` | - |
| `spent` | `Hash` | `uint` | - |
| `p5` | `const char*` | `string` | - |
| `p6` | `const char*` | `string` | - |
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_SPENT_MISSILE_JAMMER

- **命名空间:** `MONEY`
- **Hash:** `0xD687100F616163F4`
- **Build:** `2944`

**C# 签名:**
```csharp
void _NETWORK_SPENT_MISSILE_JAMMER(int amount, bool fromBank, bool fromBankAndWallet, uint p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `fromBank` | `BOOL` | `bool` | - |
| `fromBankAndWallet` | `BOOL` | `bool` | - |
| `p3` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Hash p3 = MISSILE_JAMMER
```

---

### _NETWORK_SPENT_SKIP_CARGO_SOURCE_SETUP

- **命名空间:** `MONEY`
- **Hash:** `0xED1B407BADA42CEC`
- **Build:** `2944`

**C# 签名:**
```csharp
void _NETWORK_SPENT_SKIP_CARGO_SOURCE_SETUP(int amount, bool fromBank, bool fromBankAndWallet, int cost)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `fromBank` | `BOOL` | `bool` | - |
| `fromBankAndWallet` | `BOOL` | `bool` | - |
| `cost` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### _NETWORK_SPENT_STEALTH_MODULE

- **命名空间:** `MONEY`
- **Hash:** `0x95CE79A6939C537A`
- **Build:** `2944`

**C# 签名:**
```csharp
void _NETWORK_SPENT_STEALTH_MODULE(int amount, bool fromBank, bool fromBankAndWallet, uint p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `amount` | `int` | `int` | - |
| `fromBank` | `BOOL` | `bool` | - |
| `fromBankAndWallet` | `BOOL` | `bool` | - |
| `p3` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Hash p3 = STEALTH_MODULE
```

---

### _PLAYSTATS_ACID_MISSION_END

- **命名空间:** `STATS`
- **Hash:** `0x8A23D1324F6B2BAC`
- **Build:** `2802`

**C# 签名:**
```csharp
void _PLAYSTATS_ACID_MISSION_END(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _PLAYSTATS_ACID_RND

- **命名空间:** `STATS`
- **Hash:** `0xCEACCF0550FDC5BA`
- **Build:** `2802`

**C# 签名:**
```csharp
void _PLAYSTATS_ACID_RND(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _PLAYSTATS_ALERT

- **命名空间:** `STATS`
- **Hash:** `0x5649CA22AF74E019`
- **Build:** `3095`

**C# 签名:**
```csharp
void _PLAYSTATS_ALERT(ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### _PLAYSTATS_ATTRITION_STAGE_END

- **命名空间:** `STATS`
- **Hash:** `0xBD642335A732F1A8`
- **Build:** `2944`

**C# 签名:**
```csharp
void _PLAYSTATS_ATTRITION_STAGE_END(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _PLAYSTATS_CREATOR_END

- **命名空间:** `STATS`
- **Hash:** `0x72289B8C78B02962`
- **Build:** `3717`

**C# 签名:**
```csharp
void _PLAYSTATS_CREATOR_END(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### _PLAYSTATS_DEATH_INFO

- **命名空间:** `STATS`
- **Hash:** `0x01D8B04D02F1217F`
- **Build:** `3570`

**C# 签名:**
```csharp
void _PLAYSTATS_DEATH_INFO(int victimPed, int killerPed, int mentalState, bool revengeKill, int victimKvK, int killerKvK)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `victimPed` | `Ped` | `int` | - |
| `killerPed` | `Ped` | `int` | - |
| `mentalState` | `int` | `int` | - |
| `revengeKill` | `BOOL` | `bool` | - |
| `victimKvK` | `int` | `int` | - |
| `killerKvK` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### _PLAYSTATS_FLOW_HIGH

- **命名空间:** `STATS`
- **Hash:** `0xCFB0E9C3456319EA`
- **Build:** `3258`

**C# 签名:**
```csharp
void _PLAYSTATS_FLOW_HIGH(float posX, float posY, float posZ, string action, bool p4, int p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `action` | `const char*` | `string` | - |
| `p4` | `BOOL` | `bool` | - |
| `p5` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### _PLAYSTATS_FLOW_LOW

- **命名空间:** `STATS`
- **Hash:** `0xE6A27CDA42887F93`
- **Build:** `2944`

**C# 签名:**
```csharp
void _PLAYSTATS_FLOW_LOW(float posX, float posY, float posZ, string action, bool p4, int p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `action` | `const char*` | `string` | - |
| `p4` | `BOOL` | `bool` | - |
| `p5` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### _PLAYSTATS_FLOW_MEDIUM

- **命名空间:** `STATS`
- **Hash:** `0xC4493521BAA12CCE`
- **Build:** `3095`

**C# 签名:**
```csharp
void _PLAYSTATS_FLOW_MEDIUM(float posX, float posY, float posZ, string action, bool p4, int p5)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `posX` | `float` | `float` | - |
| `posY` | `float` | `float` | - |
| `posZ` | `float` | `float` | - |
| `action` | `const char*` | `string` | - |
| `p4` | `BOOL` | `bool` | - |
| `p5` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

---

### _PLAYSTATS_IDLE

- **命名空间:** `STATS`
- **Hash:** `0xEC9553A178E8F1D1`
- **Build:** `2802`

**C# 签名:**
```csharp
void _PLAYSTATS_IDLE(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _PLAYSTATS_INIT_MULTIPLAYER

- **命名空间:** `STATS`
- **Hash:** `0x7E5EED10B11CEDBA`
- **Build:** `3407`

**C# 签名:**
```csharp
void _PLAYSTATS_INIT_MULTIPLAYER(object p0, object p1, object p2)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _PLAYSTATS_LOBBY_EXIT

- **命名空间:** `STATS`
- **Hash:** `0x4649D80CE1A35BA1`
- **Build:** `3717`

**C# 签名:**
```csharp
void _PLAYSTATS_LOBBY_EXIT(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### _PLAYSTATS_LOBBY_STARTED

- **命名空间:** `STATS`
- **Hash:** `0xDC00BB9C27347A8F`
- **Build:** `3717`

**C# 签名:**
```csharp
void _PLAYSTATS_LOBBY_STARTED(ref object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### _PLAYSTATS_NAMED_USER_CONTENT

- **命名空间:** `STATS`
- **Hash:** `0xAA434D7D0A89A95C`
- **Build:** `3258`

**C# 签名:**
```csharp
void _PLAYSTATS_NAMED_USER_CONTENT(bool isBoss, int bossType, int bossId1, int bossId2, int textType, string textString, int textSource)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `isBoss` | `BOOL` | `bool` | - |
| `bossType` | `int` | `int` | - |
| `bossId1` | `int` | `int` | - |
| `bossId2` | `int` | `int` | - |
| `textType` | `int` | `int` | - |
| `textString` | `const char*` | `string` | - |
| `textSource` | `int` | `int` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Known text types: NAME_YACHT, NAME_ORG_OFFICE
```

---

### _PLAYSTATS_PIMENU_NAV

- **命名空间:** `STATS`
- **Hash:** `0xE6D323A5E9EFFB76`
- **Build:** `3258`

**C# 签名:**
```csharp
void _PLAYSTATS_PIMENU_NAV(ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### _PLAYSTATS_PLAYER_STYLE

- **命名空间:** `STATS`
- **Hash:** `0x48FAC5DC7AC6EA99`
- **Build:** `2802`

**C# 签名:**
```csharp
void _PLAYSTATS_PLAYER_STYLE(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _PLAYSTATS_RANDOM_EVENT

- **命名空间:** `STATS`
- **Hash:** `0x7EA06F970F999394`
- **Build:** `2944`

**C# 签名:**
```csharp
void _PLAYSTATS_RANDOM_EVENT(object p0)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _PLAYSTATS_RECOVER_VEHICLE

- **命名空间:** `STATS`
- **Hash:** `0xBEB0D930B3CCE4D5`
- **Build:** `3258`

**C# 签名:**
```csharp
void _PLAYSTATS_RECOVER_VEHICLE(ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### _PLAYSTATS_SCRIPT_EVENT_FPOM

- **命名空间:** `STATS`
- **Hash:** `0x574A7808450E141C`
- **Build:** `3570`

**C# 签名:**
```csharp
void _PLAYSTATS_SCRIPT_EVENT_FPOM(ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

---

### _PLAYSTATS_SHOPMENU_NAV

- **命名空间:** `STATS`
- **Hash:** `0xF96E9EA876D9DC92`
- **Build:** `2802`

**C# 签名:**
```csharp
void _PLAYSTATS_SHOPMENU_NAV(object p0, object p1, object p2, object p3)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `p2` | `Any` | `object` | - |
| `p3` | `Any` | `object` | - |

**返回值:** `void` (Native: `void`)

---

### _PLAYSTATS_SHOWROOM_NAV

- **命名空间:** `STATS`
- **Hash:** `0x961D4157B9B428DB`
- **Build:** `2944`

**C# 签名:**
```csharp
void _PLAYSTATS_SHOWROOM_NAV(object p0, object p1, uint entity)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `p0` | `Any` | `object` | - |
| `p1` | `Any` | `object` | - |
| `entity` | `Hash` | `uint` | - |

**返回值:** `void` (Native: `void`)

---

### _PLAYSTATS_SHOWROOM_OVERVIEW

- **命名空间:** `STATS`
- **Hash:** `0x151D6C04C9E2742F`
- **Build:** `2944`

**C# 签名:**
```csharp
void _PLAYSTATS_SHOWROOM_OVERVIEW(ref object data)
```

**参数列表:**

| 参数名 | Native 类型 | C# 类型 | 说明 |
|--------|------------|---------|------|
| `data` | `Any*` | `ref object` | - |

**返回值:** `void` (Native: `void`)

**说明:**
```
Data struct contains various tunables related to test drives at Simeons Showroom or Luxury Showcase.
```

---
