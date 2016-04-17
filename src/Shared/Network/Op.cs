// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System.Collections.Generic;
using System.Reflection;

namespace Melia.Shared.Network
{
	/// <summary>
	/// Packet op code enum
	/// </summary>
	/// <remarks>
	/// History:
	/// i10622 (2015-10-22, iCBT2 pre-launch)
	/// - New:
	///   - BC_LOGIN_PACKET_RECEIVED
	///   - CZ_INV_ITEM_LOCK
	///   - ZC_NEAR_PARTY_LIST
	///   - CZ_SYSTEM_LOG_SAVE_TO_MONGODB
	///   - CZ_REQ_UPDATE_CONTENTS_SESSION
	///   - CZ_REQ_FRIENDLY_FIGHT
	///   - CZ_CART_POSITION
	///   - CZ_REQ_RIDE_CART
	/// - Removed:
	///   - CZ_SORT_INV_CHANGE_INDEX
	///   - CS_PC_INTERACTION
	///   - CS_PC_INTERACTION_HISTORY
	/// - Renamed:
	///   - CZ_SORT_ETC_INV_CHANGE_INDEX to CZ_SORT_INV
	/// - Size changes:
	///   - CB_BUY_THEMA: 18 -> 22
	///   - ZC_ENTER_PC: 370 -> 400
	///   - CZ_SKILL_GROUND: 57 -> 61
	///   - CZ_REQ_NORMAL_TX: 29 -> 45
	///   - CZ_SORT_ETC_INV_CHANGE_INDEX (CZ_SORT_INV): 11 -> 12
	/// 
	/// i10671 (2015-10-26, iCBT2 launch)
	/// - Notes
	///   - 8 new byte in COMMANDER, before hair
	/// - Size changes:
	///   - CB_LOGIN: 65 -> 66
	///   - BC_COMMANDER_CREATE: 318 -> 326
	///   - BC_SINGLE_INFO: 309 -> 317
	///   - ZC_ENTER_PC: 400 -> 408
	///   - ZC_ENTER_DUMMYPC: 292 -> 300
	///   - ZC_UPDATED_DUMMYPC: 250 -> 258
	///   - ZC_UPDATED_PCAPPEARANCE: 250 -> 258
	/// 
	/// i10725 (2015-11-03)
	/// - New:
	///   - CB_CHECK_CLIENT_INTEGRITY
	///   - CZ_DUMMYPC_SKILL_POS
	/// - Size changes:
	///   - BC_LOGINOK: 117 -> 121
	/// 
	/// i10842 (2015-11-17)
	/// - Notes:
	///   - A few ops were moved in this update, which caused almost all of
	///     of them to change.
	/// - Renamed:
	///   - CS_REQ_MARKET_LIST -> CZ_REQ_MARKET_LIST
	///   - CS_REQ_MY_SELL_LIST -> CZ_REQ_MY_SELL_LIST
	/// - Size changes:
	///   - CS_REQ_MARKET_LIST (CZ_REQ_MARKET_LIST): 158 -> 162
	///   - CS_REQ_MY_SELL_LIST (CZ_REQ_MY_SELL_LIST): 10 -> 14
	/// 
	/// i11025 (2016-02-26, pre-OBT)
	/// - New:
	///   - CB_CLIENT_INTEGRITY_FAIL
	///   - CB_REQ_SLOT_PRICE
	///   - BC_REQ_SLOT_PRICE
	///   - CB_NGS
	///   - CZ_REQ_CHAR_SLOT
	///   - CZ_REQ_OPEN_ITEM_DUNGEON
	///   - CZ_ANSWER_OPEN_ITEM_DUNGEON
	///   - CZ_SEND_ITEM_PROP_TO_ALCHMIST
	///   - CZ_EXCUTE_ITEM_DUNGEON
	///   - ZC_RECIVE_ITEM_PROP_TO_TARGET
	///   - CZ_TARGET_JOB_INFO
	///   - ZC_TARGET_JOB_INFO
	///   - CZ_PLAY_HISTORY
	///   - CZ_HISTORY_ROLL_BACK
	///   - CZ_USE_TP_AND_ENTER_INDUN
	///   - CZ_ACHIEVE_REWARD
	///   - CZ_EXTEND_WAREHOUSE
	///   - ZC_UPDATE_MSHIELD
	///   - ZC_SEND_PREMIUM_STATE
	///   - ZC_SEND_CASH_VALUE
	///   - CZ_REQ_MARKET_MINMAX_INFO
	///   - CZ_ACCEPT_GUILD_EVENT
	///   - CZ_ACCEPT_GUILD_EVENT_RAID
	///   - CZ_HARDSKILL_POS_LIST
	///   - CZ_NGS
	///   - CZ_PARTY_MEMBER_SKILL_USE
	///   - CZ_PARTY_MEMBER_SKILL_ACCEPT
	///   - CZ_SYSTEM_LOG_TO_SERVER
	///   - CZ_CHECK_PING
	///   - CZ_CANCEL_INDUN_MATCHING
	/// - Renamed:
	///   - CB_DELETE_PET -> CB_PET_COMMAND
	/// - Size changes:
	///   - CB_LOGIN_BY_PASSPORT: 1052 -> 1068
	///   - CB_COMMANDER_CREATE: 92 -> 96
	///   - BC_COMMANDER_CREATE: 326 -> 334
	///   - BC_SINGLE_INFO: 317 -> 325
	///   - CB_DELETE_PET (CB_PET_COMMAND): 18 -> 27
	///   - CS_LIKE_IT: 80 -> 88
	///   - CS_UNLIKE_IT: 16 -> 24
	///   - CZ_CONNECT: 1164 -> 1200
	///   - ZC_ENTER_PC: 408 -> 341
	///   - ZC_ENTER_DUMMYPC: 300 -> 308
	///   - ZC_UPDATED_DUMMYPC: 258 -> 266
	///   - ZC_MOVE_POS: 42 -> 43
	///   - ZC_UPDATED_PCAPPEARANCE: 258 -> 266
	///   - ZC_BUFF_REMOVE: 17 -> 19
	///   - ZC_HIT_INFO: 60 -> 64
	///   - ZC_HIT_INFO: 60 -> 64
	///   - CZ_DYNAMIC_CASTING_START: 23 -> 24
	///   - CZ_ACHIEVE_EQUIP: 18 -> 14
	///   - ZC_UPDATE_SHIELD: 12 -> 14
	///   - CZ_CHANGE_HEAD: 14 -> 74
	///   - CZ_PROPERTY_COMPARE: 15 -> 16
	///   - ZC_DIRECTION_APC: 22 -> 26
	///   - CZ_REQ_MARKET_REGISTER: 27 -> 40
	/// 
	/// i11037 (2016-03-0X, pre-OBT)
	/// - New:
	///   - CB_REQ_POSTBOX_PAGE
	///   - CZ_PREMIUM_ENCHANTCHIP
	///   - CZ_PREMIUM_GACHACUBE
	///   - CZ_ITEM_ADD_WIKI
	///   - CZ_REQ_GM_ORDER
	///   - CZ_PARTY_INVENTORY_LOAD
	///   - CZ_REQ_MOVE_PARTYINV_TO_ACCOUNT
	///   - CZ_REQ_CancelGachaCube
	///   - CZ_WAREHOUSE_TAKE_LIST
	/// - Removed:
	///   - CZ_PLAY_HISTORY
	///   - CZ_HISTORY_ROLL_BACK
	/// - Size changes:
	///   - CB_REQ_CHANGE_POSTBOX_STATE: 22 -> 23
	///   - CB_REQ_GET_POSTBOX_ITEM: 30 -> 1051 wth...
	///   - CS_REQUEST_PVP_RANKING: 83 -> 88
	///   - ZC_MAX_EXP_CHANGED: 18 -> 22
	///   - CZ_WAREHOUSE_CMD: 31 -> 32
	///   - CZ_EXTEND_WAREHOUSE: 10 -> 11
	///   - ZC_SEND_PREMIUM_STATE: 12 -> 16
	///   - ZC_SYNC_START: 10 -> 14
	///   - CZ_PVP_ZONE_CMD: 22 -> 26
	/// 
	/// i11257 (2016-03-25, pre-OBT)
	/// - New:
	///   - ZC_PROPERTY_COMPARE_FOR_ACT
	/// - Renamed:
	///   - CS_PVP_COMMAND -> CZ_PVP_COMMAND
	/// - Size changes:
	///   - CZ_PVP_COMMAND (CS_PVP_COMMAND): 18 -> 22
	///   - ZC_MOVE_SPEED: 18 -> 19
	///   - ZC_REST_SIT: 11 -> 12
	///   - CZ_SKILL_CANCEL: 11 -> 12
	/// 
	/// i11457 (2016-04-12)
	/// - New:
	///   - CZ_REPORT_AUTOBOT
	/// </remarks>
	public static class Op
	{
		public const int CB_LOGIN = 0x03; // Size: 66
		public const int CB_LOGIN_BY_PASSPORT = 0x04; // Size: 1068
		public const int CB_LOGOUT = 0x05; // Size: 10
		public const int CB_START_BARRACK = 0x06; // Size: 11
		public const int CB_COMMANDER_CREATE = 0x07; // Size: 96
		public const int CB_COMMANDER_DESTROY = 0x08; // Size: 11
		public const int CB_CHECK_CLIENT_INTEGRITY = 0x09; // Size: 74
		public const int CB_CLIENT_INTEGRITY_FAIL = 0x0A; // Size: 1035
		public const int CB_START_GAME = 0x0B; // Size: 13
		public const int CB_BARRACKNAME_CHANGE = 0x0C; // Size: 74
		public const int CB_COMMANDER_MOVE = 0x0D; // Size: 31
		public const int CB_ECHO = 0x0E; // Size: 30
		public const int BC_LOGINOK = 0x0F; // Size: 121
		public const int BC_LOGIN_PACKET_RECEIVED = 0x10; // Size: 6
		public const int BC_LOGOUTOK = 0x11; // Size: 6
		public const int BC_COMMANDER_LIST = 0x12; // Size: 0
		public const int BC_COMMANDER_CREATE = 0x13; // Size: 334
		public const int BC_COMMANDER_DESTROY = 0x14; // Size: 7
		public const int BC_START_GAMEOK = 0x15; // Size: 33
		public const int BC_SINGLE_INFO = 0x16; // Size: 325
		public const int BC_MESSAGE = 0x17; // Size: 0
		public const int BC_ECHO = 0x18; // Size: 26
		public const int BC_MYPAGE_MAP = 0x19; // Size: 0
		public const int BC_BARRACKNAME_CHANGE = 0x1A; // Size: 75
		public const int CB_IES_MODIFY_INFO = 0x46; // Size: 0
		public const int BC_IES_MODIFY_INFO = 0x47; // Size: 0
		public const int BC_IES_MODIFY_LIST = 0x48; // Size: 0
		public const int CB_IES_REVISION_DELETE = 0x49; // Size: 0
		public const int BC_IES_REVISION_DELETE = 0x4A; // Size: 0
		public const int CB_VISIT = 0x4B; // Size: 74
		public const int CB_BUY_THEMA = 0x4C; // Size: 22
		public const int BC_ACCOUNT_PROP = 0x4D; // Size: 0
		public const int CB_CURRENT_BARRACK = 0x4E; // Size: 39
		public const int BC_NORMAL = 0x4F; // Size: 0
		public const int CB_POSE = 0x50; // Size: 15
		public const int CB_PLACE_CMD = 0x51; // Size: 46
		public const int CB_CHAT = 0x52; // Size: 0
		public const int BC_CHAT = 0x53; // Size: 0
		public const int CB_ECHO_NORMAL = 0x54; // Size: 0
		public const int CB_REQ_SLOT_PRICE = 0x55; // Size: 10
		public const int BC_REQ_SLOT_PRICE = 0x56; // Size: 10
		public const int CB_JUMP = 0x57; // Size: 19
		public const int BC_JUMP = 0x58; // Size: 19
		public const int BC_SERVER_ENTRY = 0x59; // Size: 18
		public const int CB_PET_PC = 0x5A; // Size: 26
		public const int CB_PET_COMMAND = 0x5B; // Size: 27
		public const int CB_REQ_CHANGE_POSTBOX_STATE = 0x5C; // Size: 23
		public const int CB_REQ_GET_POSTBOX_ITEM = 0x5D; // Size: 1051
		public const int CB_REQ_POSTBOX_PAGE = 0x5E; // Size: 14
		public const int BC_WAIT_QUEUE_ORDER = 0x5F; // Size: 10
		public const int CB_CANCEL_SERVER_WAIT_QUEUE = 0x60; // Size: 10
		public const int CB_NGS = 0x61; // Size: 10254
		public const int ZC_TREASUREMARK_LIST_MAP = 0xD0; // Size: 0
		public const int CS_LOGIN = 0xB55; // Size: 64
		public const int SC_NORMAL = 0xB56; // Size: 0
		public const int SC_FROM_INTEGRATE = 0xB57; // Size: 0
		public const int CS_REGISTER_SNS_ID = 0xB58; // Size: 16
		public const int CS_REQ_SNS_PC_INFO = 0xB59; // Size: 0
		public const int CS_REQ_ADD_FRIEND = 0xB5A; // Size: 70
		public const int CS_REQ_BLOCK_FRIEND = 0xB5B; // Size: 70
		public const int CS_FRIEND_CMD = 0xB5C; // Size: 24
		public const int CS_FRIEND_SET_ADDINFO = 0xB5D; // Size: 160
		public const int CS_CHAT = 0xB5E; // Size: 0
		public const int CS_CREATE_GROUP_CHAT = 0xB5F; // Size: 6
		public const int CS_GROUP_CHAT_INVITE = 0xB60; // Size: 78
		public const int CS_REFRESH_GROUP_CHAT = 0xB61; // Size: 6
		public const int CS_CHAT_HISTORY = 0xB62; // Size: 22
		public const int CS_CHAT_READ = 0xB63; // Size: 30
		public const int CS_REMOVE_GROUP_MEMBER = 0xB64; // Size: 14
		public const int CS_REQ_RELATED_PC_SESSION = 0xB65; // Size: 16
		public const int CS_REDIS_SKILLPOINT = 0xB66; // Size: 22
		public const int CS_PARTY_CLIENT_INFO_SEND = 0xB67; // Size: 0
		public const int CS_NORMAL_GAME_START = 0xB68; // Size: 6
		public const int CS_REQUEST_PVP_RANKING = 0xB69; // Size: 88
		public const int CS_INVITE_PARTY_PVP = 0xB6A; // Size: 10
		public const int CS_ACCEPT_PARTY_PVP = 0xB6B; // Size: 19
		public const int CS_LIKE_IT = 0xB6C; // Size: 88
		public const int CS_UNLIKE_IT = 0xB6D; // Size: 24
		public const int CS_LIKE_IT_CONFIRM = 0xB6E; // Size: 16
		public const int CS_ADD_RELATION_SCORE = 0xB6F; // Size: 88
		public const int CS_GET_LIKE_COUNT = 0xB70; // Size: 16
		public const int CZ_CONNECT = 0xBB9; // Size: 1200
		public const int ZC_CONNECT_OK = 0xBBA; // Size: 0
		public const int ZC_MOVE_ZONE = 0xBBB; // Size: 7
		public const int CZ_MOVE_ZONE_OK = 0xBBC; // Size: 10
		public const int ZC_CONNECT_FAILED = 0xBBD; // Size: 0
		public const int CZ_GAME_READY = 0xBBE; // Size: 10
		public const int ZC_MOVE_ZONE_OK = 0xBBF; // Size: 57
		public const int CZ_LOGOUT = 0xBC0; // Size: 11
		public const int CZ_MOVE_BARRACK = 0xBC1; // Size: 11
		public const int ZC_MOVE_BARRACK = 0xBC2; // Size: 6
		public const int ZC_LOGOUT_OK = 0xBC3; // Size: 6
		public const int ZC_MESSAGE = 0xBC4; // Size: 0
		public const int ZC_RESET_VIEW = 0xBC5; // Size: 6
		public const int ZC_START_GAME = 0xBC6; // Size: 26
		public const int ZC_QUIET = 0xBC7; // Size: 7
		public const int ZC_ENTER_PC = 0xC1D; // Size: 341
		public const int ZC_ENTER_MONSTER = 0xC1E; // Size: 0
		public const int ZC_ENTER_DUMMYPC = 0xC1F; // Size: 308
		public const int ZC_UPDATED_DUMMYPC = 0xC20; // Size: 266
		public const int ZC_ENTER_ITEM = 0xC21; // Size: 103
		public const int ZC_LEAVE = 0xC22; // Size: 12
		public const int ZC_MOVE_PATH = 0xC23; // Size: 42
		public const int ZC_MOVE_POS = 0xC24; // Size: 43
		public const int ZC_MOVE_DIR = 0xC25; // Size: 40
		public const int ZC_EXPECTED_STOPPOS = 0xC26; // Size: 35
		public const int ZC_MSPD = 0xC27; // Size: 14
		public const int ZC_MOVE_SPEED = 0xC28; // Size: 19
		public const int ZC_MOVE_STOP = 0xC29; // Size: 23
		public const int ZC_REST_SIT = 0xC2A; // Size: 12
		public const int ZC_JUMP = 0xC2B; // Size: 19
		public const int ZC_JUMP_DIR = 0xC2C; // Size: 34
		public const int ZC_ORDER_SKILL_JUMP = 0xC2D; // Size: 10
		public const int ZC_SKILL_JUMP = 0xC2E; // Size: 38
		public const int ZC_SET_POS = 0xC2F; // Size: 23
		public const int ZC_FILE_MOVE = 0xC30; // Size: 46
		public const int CZ_LEAVE_TO_DUNGEON = 0xC31; // Size: 10
		public const int ZC_UPDATED_PCAPPEARANCE = 0xC32; // Size: 266
		public const int ZC_UPDATED_MONSTERAPPEARANCE = 0xC33; // Size: 0
		public const int ZC_CHAT = 0xC34; // Size: 0
		public const int ZC_CHAT_WITH_TEXTCODE = 0xC35; // Size: 14
		public const int ZC_STANCE_CHANGE = 0xC36; // Size: 14
		public const int ZC_ADD_HP = 0xC37; // Size: 22
		public const int ZC_SKILL_CAST_CANCEL = 0xC38; // Size: 10
		public const int ZC_SKILL_CAST = 0xC39; // Size: 38
		public const int ZC_SKILL_READY = 0xC3A; // Size: 50
		public const int ZC_SKILL_DISABLE = 0xC3B; // Size: 15
		public const int ZC_SKILL_USE_CANCEL = 0xC3C; // Size: 10
		public const int ZC_SKILL_MELEE_TARGET = 0xC3D; // Size: 0
		public const int ZC_SKILL_MELEE_GROUND = 0xC3E; // Size: 0
		public const int ZC_SKILL_FORCE_TARGET = 0xC3F; // Size: 0
		public const int ZC_SKILL_FORCE_GROUND = 0xC40; // Size: 0
		public const int ZC_SKILL_HIT_INFO = 0xC41; // Size: 0
		public const int ZC_BUFF_LIST = 0xC42; // Size: 0
		public const int ZC_BUFF_ADD = 0xC43; // Size: 0
		public const int ZC_BUFF_UPDATE = 0xC44; // Size: 0
		public const int ZC_BUFF_REMOVE = 0xC45; // Size: 19
		public const int ZC_BUFF_CLEAR = 0xC46; // Size: 11
		public const int CZ_BUFF_REMOVE = 0xC47; // Size: 14
		public const int CZ_INTE_WARP = 0xC48; // Size: 14
		public const int ZC_ROTATE = 0xC49; // Size: 20
		public const int ZC_ROTATE_RESERVED = 0xC4A; // Size: 18
		public const int ZC_HEAD_ROTATE = 0xC4B; // Size: 18
		public const int ZC_TARGET_ROTATE = 0xC4C; // Size: 18
		public const int ZC_QUICK_ROTATE = 0xC4D; // Size: 18
		public const int ZC_POSE = 0xC4E; // Size: 34
		public const int ZC_DEAD = 0xC4F; // Size: 0
		public const int ZC_RESURRECT = 0xC50; // Size: 18
		public const int ZC_CHANGE_RELATION = 0xC51; // Size: 11
		public const int ZC_RESURRECT_DIALOG = 0xC52; // Size: 7
		public const int ZC_HIT_INFO = 0xC53; // Size: 64
		public const int ZC_HEAL_INFO = 0xC54; // Size: 30
		public const int ZC_CAUTION_DAMAGE_INFO = 0xC56; // Size: 15
		public const int ZC_CAUTION_DAMAGE_RELEASE = 0xC57; // Size: 10
		public const int ZC_KNOCKBACK_INFO = 0xC58; // Size: 70
		public const int ZC_KNOCKDOWN_INFO = 0xC59; // Size: 71
		public const int CZ_RESURRECT = 0xC5A; // Size: 11
		public const int ZC_RESURRECT_SAVE_POINT_ACK = 0xC5B; // Size: 7
		public const int ZC_RESURRECT_HERE_ACK = 0xC5C; // Size: 7
		public const int CZ_CLICK_TRIGGER = 0xC5D; // Size: 15
		public const int CZ_KEYBOARD_MOVE = 0xC5E; // Size: 41
		public const int CZ_EXPECTED_STOP_POS = 0xC5F; // Size: 31
		public const int CZ_JUMP = 0xC60; // Size: 11
		public const int CZ_DASHRUN = 0xC61; // Size: 11
		public const int CZ_SKILL_JUMP_REQ = 0xC62; // Size: 30
		public const int CZ_MOVE_PATH = 0xC63; // Size: 27
		public const int CZ_MOVE_STOP = 0xC64; // Size: 35
		public const int CZ_REST_SIT = 0xC65; // Size: 10
		public const int CZ_REQ_CHAR_SLOT = 0xC66; // Size: 11
		public const int CZ_ON_AIR = 0xC67; // Size: 10
		public const int CZ_ON_GROUND = 0xC68; // Size: 10
		public const int CZ_MOVEMENT_INFO = 0xC69; // Size: 23
		public const int CZ_SKILL_TARGET = 0xC6A; // Size: 19
		public const int CZ_SKILL_TARGET_ANI = 0xC6B; // Size: 23
		public const int CZ_SKILL_GROUND = 0xC6C; // Size: 61
		public const int CZ_SKILL_SELF = 0xC6D; // Size: 35
		public const int CZ_SKILL_CANCEL = 0xC6E; // Size: 12
		public const int CZ_HOLD = 0xC6F; // Size: 11
		public const int CZ_ROTATE = 0xC70; // Size: 18
		public const int CZ_HEAD_ROTATE = 0xC71; // Size: 18
		public const int CZ_TARGET_ROTATE = 0xC72; // Size: 18
		public const int CZ_POSE = 0xC73; // Size: 34
		public const int CZ_CHAT = 0xC74; // Size: 0
		public const int CZ_CHAT_LOG = 0xC75; // Size: 0
		public const int CZ_SHOUT = 0xC76; // Size: 0
		public const int CZ_ITEM_DROP = 0xC77; // Size: 22
		public const int CZ_ITEM_DELETE = 0xC78; // Size: 0
		public const int CZ_ITEM_USE = 0xC79; // Size: 22
		public const int CZ_ITEM_USE_TO_ITEM = 0xC7A; // Size: 30
		public const int CZ_ITEM_USE_TO_GROUND = 0xC7B; // Size: 30
		public const int CZ_ITEM_BUY = 0xC7C; // Size: 0
		public const int CZ_ITEM_SELL = 0xC7D; // Size: 0
		public const int CZ_ITEM_EQUIP = 0xC7E; // Size: 19
		public const int CZ_ITEM_UNEQUIP = 0xC7F; // Size: 11
		public const int ZC_CHECK_INVINDEX = 0xC80; // Size: 30
		public const int CZ_PREMIUM_ENCHANTCHIP = 0xC81; // Size: 26
		public const int CZ_PREMIUM_GACHACUBE = 0xC82; // Size: 10
		public const int ZC_ITEM_INVENTORY_LIST = 0xC83; // Size: 0
		public const int ZC_ITEM_INVENTORY_INDEX_LIST = 0xC84; // Size: 0
		public const int ZC_ITEM_EQUIP_LIST = 0xC85; // Size: 0
		public const int ZC_ITEM_ADD = 0xC86; // Size: 0
		public const int ZC_ITEM_REMOVE = 0xC87; // Size: 20
		public const int ZC_ITEM_USE = 0xC88; // Size: 14
		public const int ZC_ITEM_USE_TO_GROUND = 0xC89; // Size: 22
		public const int CZ_ITEM_ADD_WIKI = 0xC8A; // Size: 18
		public const int ZC_QUICK_SLOT_LIST = 0xC8B; // Size: 0
		public const int ZC_SKILL_LIST = 0xC8C; // Size: 0
		public const int ZC_SKILL_ADD = 0xC8D; // Size: 0
		public const int ZC_ABILITY_LIST = 0xC8E; // Size: 0
		public const int CZ_ACTIVE_ABILITY = 0xC8F; // Size: 15
		public const int ZC_ACTIVE_ABILITY = 0xC90; // Size: 11
		public const int CZ_REQ_OPEN_ITEM_DUNGEON = 0xC91; // Size: 19
		public const int CZ_ANSWER_OPEN_ITEM_DUNGEON = 0xC92; // Size: 19
		public const int CZ_SEND_ITEM_PROP_TO_ALCHMIST = 0xC93; // Size: 28
		public const int CZ_EXCUTE_ITEM_DUNGEON = 0xC94; // Size: 34
		public const int ZC_RECIVE_ITEM_PROP_TO_TARGET = 0xC95; // Size: 0
		public const int CZ_DISPEL_DEBUFF_TOGGLE = 0xC96; // Size: 14
		public const int CZ_JUNGTAN_TOGGLE = 0xC97; // Size: 16
		public const int ZC_EXP_UP = 0xC98; // Size: 14
		public const int ZC_EXP_UP_BY_MONSTER = 0xC99; // Size: 18
		public const int ZC_PC_LEVELUP = 0xC9A; // Size: 14
		public const int ZC_PC_STAT_AVG = 0xC9B; // Size: 30
		public const int ZC_MAX_EXP_CHANGED = 0xC9C; // Size: 22
		public const int ZC_TEXT = 0xC9D; // Size: 0
		public const int ZC_UPDATE_SP = 0xC9E; // Size: 15
		public const int ZC_RESTORATION = 0xC9F; // Size: 12
		public const int ZC_UPDATE_MHP = 0xCA0; // Size: 14
		public const int CZ_DIALOG_ACK = 0xCA1; // Size: 14
		public const int CZ_DIALOG_SELECT = 0xCA2; // Size: 11
		public const int CZ_DIALOG_STRINGINPUT = 0xCA3; // Size: 138
		public const int ZC_DIALOG_OK = 0xCA5; // Size: 0
		public const int ZC_DIALOG_NEXT = 0xCA6; // Size: 0
		public const int ZC_DIALOG_SELECT = 0xCA7; // Size: 0
		public const int ZC_DIALOG_ITEM_SELECT = 0xCA8; // Size: 0
		public const int ZC_DIALOG_CLOSE = 0xCA9; // Size: 6
		public const int ZC_DIALOG_TRADE = 0xCAA; // Size: 39
		public const int ZC_DIALOG_COMMON_TRADE = 0xCAB; // Size: 39
		public const int ZC_DIALOG_NUMBERRANGE = 0xCAC; // Size: 0
		public const int ZC_DIALOG_STRINGINPUT = 0xCAD; // Size: 0
		public const int ZC_ADDON_MSG = 0xCAE; // Size: 0
		public const int CZ_UI_EVENT = 0xCAF; // Size: 0
		public const int ZC_PLAY_SOUND = 0xCB0; // Size: 15
		public const int ZC_STOP_SOUND = 0xCB1; // Size: 14
		public const int ZC_PLAY_MUSICQUEUE = 0xCB2; // Size: 14
		public const int ZC_STOP_MUSICQUEUE = 0xCB3; // Size: 14
		public const int ZC_PLAY_ANI = 0xCB4; // Size: 24
		public const int ZC_CHANGE_ANI = 0xCB5; // Size: 44
		public const int CZ_MOVE_CAMP = 0xCB6; // Size: 18
		public const int CZ_CAMPINFO = 0xCB7; // Size: 18
		public const int ZC_CAMPINFO = 0xCB8; // Size: 18
		public const int ZC_FIX_ANIM = 0xCB9; // Size: 14
		public const int CZ_TARGET_JOB_INFO = 0xCBA; // Size: 18
		public const int ZC_TARGET_JOB_INFO = 0xCBB; // Size: 14
		public const int ZC_MOVE_ANIM = 0xCBC; // Size: 12
		public const int ZC_STD_ANIM = 0xCBD; // Size: 11
		public const int ZC_PLAY_ALARMSOUND = 0xCBF; // Size: 83
		public const int ZC_STOP_ALARMSOUND = 0xCC0; // Size: 10
		public const int ZC_PLAY_EXP_TEXT = 0xCC1; // Size: 14
		public const int ZC_PLAY_NAVI_EFFECT = 0xCC2; // Size: 150
		public const int ZC_UPDATE_ALL_STATUS = 0xCC3; // Size: 26
		public const int ZC_OBJECT_PROPERTY = 0xCC4; // Size: 0
		public const int ZC_DUMP_PROPERTY = 0xCC5; // Size: 0
		public const int ZC_SHOUT = 0xCC6; // Size: 0
		public const int ZC_SHOUT_FAILED = 0xCC7; // Size: 7
		public const int CZ_EXCHANGE_REQUEST = 0xCC8; // Size: 14
		public const int ZC_EXCHANGE_REQUEST_ACK = 0xCC9; // Size: 72
		public const int ZC_EXCHANGE_REQUEST_RECEIVED = 0xCCA; // Size: 71
		public const int CZ_EXCHANGE_ACCEPT = 0xCCB; // Size: 10
		public const int CZ_EXCHANGE_DECLINE = 0xCCC; // Size: 10
		public const int ZC_EXCHANGE_DECLINE_ACK = 0xCCD; // Size: 6
		public const int ZC_EXCHANGE_START = 0xCCE; // Size: 71
		public const int CZ_EXCHANGE_OFFER = 0xCCF; // Size: 30
		public const int ZC_EXCHANGE_OFFER_ACK = 0xCD0; // Size: 0
		public const int CZ_EXCHANGE_AGREE = 0xCD1; // Size: 10
		public const int ZC_EXCHANGE_AGREE_ACK = 0xCD2; // Size: 7
		public const int CZ_EXCHANGE_FINALAGREE = 0xCD3; // Size: 10
		public const int ZC_EXCHANGE_FINALAGREE_ACK = 0xCD4; // Size: 7
		public const int CZ_EXCHANGE_CANCEL = 0xCD5; // Size: 10
		public const int ZC_EXCHANGE_CANCEL_ACK = 0xCD6; // Size: 6
		public const int ZC_EXCHANGE_SUCCESS = 0xCD7; // Size: 6
		public const int ZC_COOLDOWN_LIST = 0xCD8; // Size: 0
		public const int ZC_COOLDOWN_CHANGED = 0xCD9; // Size: 22
		public const int ZC_OVERHEAT_CHANGED = 0xCDA; // Size: 26
		public const int ZC_TEST_AGENT = 0xCDB; // Size: 18
		public const int CZ_COMMON_SHOP_LIST = 0xCDC; // Size: 10
		public const int ZC_COMMON_SHOP_LIST = 0xCDD; // Size: 8
		public const int ZC_TIME_FACTOR = 0xCDE; // Size: 10
		public const int ZC_PARTY_ENTER = 0xCDF; // Size: 0
		public const int ZC_PARTY_OUT = 0xCE0; // Size: 24
		public const int ZC_PARTY_DESTROY = 0xCE1; // Size: 15
		public const int ZC_PARTY_INFO = 0xCE2; // Size: 0
		public const int ZC_PARTY_LIST = 0xCE3; // Size: 0
		public const int ZC_PARTY_CHAT = 0xCE4; // Size: 0
		public const int ZC_PARTY_INST_INFO = 0xCE5; // Size: 0
		public const int ZC_CHANGE_EQUIP_DURABILITY = 0xCE6; // Size: 11
		public const int CZ_DIALOG_TX = 0xCE7; // Size: 0
		public const int CZ_REQ_RECIPE = 0xCE8; // Size: 0
		public const int ZC_CUSTOM_DIALOG = 0xCE9; // Size: 75
		public const int ZC_SESSION_OBJECTS = 0xCEA; // Size: 0
		public const int ZC_SESSION_OBJ_ADD = 0xCEB; // Size: 0
		public const int ZC_SESSION_OBJ_REMOVE = 0xCEC; // Size: 10
		public const int ZC_SESSION_OBJ_TIME = 0xCED; // Size: 14
		public const int CZ_S_OBJ_VALUE_C = 0xCEE; // Size: 24
		public const int CZ_REQ_NORMAL_TX = 0xCEF; // Size: 45
		public const int ZC_COMMANDER_LOADER_INFO = 0xCF0; // Size: 0
		public const int ZC_MOVE_SINGLE_ZONE = 0xCF1; // Size: 18
		public const int ZC_BACKTO_ORIGINAL_SERVER = 0xCF2; // Size: 8
		public const int CZ_BACKTO_ORIGINAL_SERVER = 0xCF3; // Size: 12
		public const int CZ_REQ_NORMAL_TX_NUMARG = 0xCF4; // Size: 0
		public const int ZC_WIKI_LIST = 0xCF5; // Size: 0
		public const int ZC_WIKI_ADD = 0xCF6; // Size: 22
		public const int CZ_WIKI_GET = 0xCF7; // Size: 14
		public const int CZ_WIKI_RECIPE_UPDATE = 0xCF8; // Size: 10
		public const int ZC_UI_OPEN = 0xCF9; // Size: 39
		public const int ZC_ENABLE_CONTROL = 0xCFA; // Size: 11
		public const int ZC_CHANGE_CAMERA = 0xCFB; // Size: 31
		public const int ZC_MONSTER_SDR_CHANGED = 0xCFC; // Size: 11
		public const int ZC_MOVE_IGNORE_COLLISION = 0xCFD; // Size: 30
		public const int ZC_CHANGE_CAMERA_ZOOM = 0xCFE; // Size: 34
		public const int ZC_PLAY_SKILL_ANI = 0xCFF; // Size: 82
		public const int ZC_PLAY_SKILL_CAST_ANI = 0xD00; // Size: 30
		public const int CZ_REQ_ITEM_GET = 0xD01; // Size: 14
		public const int ZC_ITEM_GET = 0xD02; // Size: 18
		public const int CZ_GUARD = 0xD03; // Size: 19
		public const int ZC_GUARD = 0xD04; // Size: 19
		public const int ZC_STAMINA = 0xD05; // Size: 10
		public const int ZC_ADD_STAMINA = 0xD06; // Size: 10
		public const int ZC_GM_ORDER = 0xD07; // Size: 10
		public const int ZC_MYPC_ENTER = 0xD08; // Size: 18
		public const int ZC_LOCK_KEY = 0xD09; // Size: 75
		public const int ZC_SAVE_INFO = 0xD0A; // Size: 6
		public const int CZ_SAVE_INFO = 0xD0B; // Size: 0
		public const int ZC_OPTION_LIST = 0xD0C; // Size: 0
		public const int ZC_SKILLMAP_LIST = 0xD0D; // Size: 0
		public const int CZ_GIVEITEM_TO_DUMMYPC = 0xD0E; // Size: 22
		public const int CZ_FOOD_TABLE_TITLE = 0xD0F; // Size: 79
		public const int CZ_USE_TP_AND_ENTER_INDUN = 0xD10; // Size: 522
		public const int ZC_SET_LAYER = 0xD11; // Size: 10
		public const int ZC_CREATE_LAYERBOX = 0xD12; // Size: 38
		public const int ZC_RESET_BOX = 0xD13; // Size: 11
		public const int ZC_CREATE_SCROLLLOCKBOX = 0xD14; // Size: 38
		public const int ZC_REMOVE_SCROLLLOCKBOX = 0xD15; // Size: 10
		public const int CZ_DYNAMIC_CASTING_START = 0xD16; // Size: 24
		public const int CZ_DYNAMIC_CASTING_END = 0xD17; // Size: 19
		public const int CZ_SKILL_CANCEL_SCRIPT = 0xD18; // Size: 10
		public const int ZC_LEAVE_TRIGGER = 0xD19; // Size: 6
		public const int ZC_BORN = 0xD1A; // Size: 10
		public const int ZC_ACHIEVE_POINT_LIST = 0xD1B; // Size: 0
		public const int ZC_ACHIEVE_POINT = 0xD1C; // Size: 18
		public const int CZ_ACHIEVE_EQUIP = 0xD1D; // Size: 14
		public const int ZC_ACHIEVE_EQUIP = 0xD1E; // Size: 22
		public const int CZ_ACHIEVE_REWARD = 0xD1F; // Size: 14
		public const int CZ_CHANGE_CONFIG = 0xD20; // Size: 18
		public const int CZ_CHANGE_CONFIG_STR = 0xD21; // Size: 34
		public const int ZC_WORLD_MSG = 0xD22; // Size: 43
		public const int ZC_ENABLE_SHOW_ITEM_GET = 0xD23; // Size: 8
		public const int ZC_LOGIN_TIME = 0xD24; // Size: 14
		public const int ZC_GIVE_EXP_TO_PC = 0xD25; // Size: 42
		public const int ZC_LAYER_PC_LIST = 0xD26; // Size: 0
		public const int ZC_LAYER_PC_SOBJ_PROP = 0xD27; // Size: 0
		public const int CZ_CUSTOM_COMMAND = 0xD28; // Size: 26
		public const int ZC_LAYER_INFO = 0xD29; // Size: 10
		public const int CZ_CHAT_MACRO = 0xD2A; // Size: 146
		public const int ZC_CHAT_MACRO_LIST = 0xD2B; // Size: 0
		public const int ZC_RULLET_LIST = 0xD2C; // Size: 0
		public const int ZC_QUICKSLOT_REGISTER = 0xD2D; // Size: 46
		public const int CZ_QUICKSLOT_LIST = 0xD2E; // Size: 0
		public const int CZ_DOUBLE_ITEM_EQUIP = 0xD2F; // Size: 28
		public const int ZC_TRICK_PACKET = 0xD30; // Size: 0
		public const int ZC_COOLDOWN_RATE = 0xD31; // Size: 22
		public const int ZC_MAP_REVEAL_LIST = 0xD32; // Size: 0
		public const int CZ_MAP_REVEAL_INFO = 0xD33; // Size: 146
		public const int CZ_MAP_SEARCH_INFO = 0xD34; // Size: 55
		public const int ZC_UI_INFO_LIST = 0xD35; // Size: 0
		public const int ZC_EXEC_CLIENT_SCP = 0xD36; // Size: 0
		public const int ZC_SET_NPC_STATE = 0xD37; // Size: 18
		public const int ZC_NPC_STATE_LIST = 0xD38; // Size: 0
		public const int CZ_QUEST_NPC_STATE_CHECK = 0xD39; // Size: 14
		public const int ZC_RANK_ACHIEVE_ADD = 0xD3A; // Size: 14
		public const int CZ_GET_MAP_REVEAL_ACHIEVE = 0xD3B; // Size: 10
		public const int CZ_IES_MODIFY_INFO = 0xD3C; // Size: 0
		public const int ZC_IES_MODIFY_INFO = 0xD3D; // Size: 0
		public const int ZC_IES_MODIFY_LIST = 0xD3E; // Size: 0
		public const int CZ_IES_REVISION_DELETE = 0xD3F; // Size: 0
		public const int ZC_IES_REVISION_DELETE = 0xD40; // Size: 0
		public const int ZC_EQUIP_ITEM_REMOVE = 0xD41; // Size: 18
		public const int ZC_SOLD_ITEM_LIST = 0xD42; // Size: 0
		public const int CZ_SOLD_ITEM = 0xD43; // Size: 19
		public const int CZ_WAREHOUSE_CMD = 0xD44; // Size: 32
		public const int CZ_SWAP_ETC_INV_CHANGE_INDEX = 0xD45; // Size: 35
		public const int CZ_SORT_INV = 0xD46; // Size: 12
		public const int CZ_EXTEND_WAREHOUSE = 0xD47; // Size: 11
		public const int CZ_CAST_CONTROL_SHOT = 0xD48; // Size: 10
		public const int ZC_PC_PROP_UPDATE = 0xD49; // Size: 9
		public const int CZ_CLIENT_DAMAGE = 0xD4A; // Size: 14
		public const int CZ_CLIENT_ATTACK = 0xD4B; // Size: 15
		public const int ZC_SYSTEM_MSG = 0xD4C; // Size: 0
		public const int ZC_FSM_MOVE = 0xD4D; // Size: 0
		public const int CZ_QUEST_CHECK_SAVE = 0xD4E; // Size: 50
		public const int CZ_SPRAY_REQ_INFO = 0xD4F; // Size: 14
		public const int CZ_SPRAY_DRAW_INFO = 0xD50; // Size: 0
		public const int ZC_SPRAY_ID = 0xD51; // Size: 18
		public const int ZC_SPRAY_DRAW_INFO = 0xD52; // Size: 0
		public const int ZC_MONSTER_LIFETIME = 0xD53; // Size: 14
		public const int ZC_SPRAY_LIKE_LIST = 0xD54; // Size: 0
		public const int ZC_WIKI_COUNT_UPDATE = 0xD55; // Size: 19
		public const int ZC_WIKI_INT_PROP_UPDATE = 0xD56; // Size: 15
		public const int ZC_WIKI_BOOL_PROP_UPDATE = 0xD57; // Size: 12
		public const int CZ_REQ_WIKI_RANK = 0xD58; // Size: 15
		public const int ZC_WIKI_RANK_LIST = 0xD59; // Size: 0
		public const int ZC_SHARED_MSG = 0xD5A; // Size: 10
		public const int CZ_REQ_WIKI_PROP_RANK = 0xD5B; // Size: 16
		public const int CZ_GET_WIKI_REWARD = 0xD5C; // Size: 11
		public const int CZ_REQ_TX_ITEM = 0xD5D; // Size: 0
		public const int ZC_TEST_DBG = 0xD5E; // Size: 0
		public const int ZC_MONSTER_DIST = 0xD5F; // Size: 0
		public const int ZC_RESET_SKILL_FORCEID = 0xD60; // Size: 10
		public const int ZC_EMOTICON = 0xD61; // Size: 18
		public const int ZC_SHOW_EMOTICON = 0xD62; // Size: 18
		public const int ZC_TREASUREMARK_BY_MAP = 0xD63; // Size: 0
		public const int ZC_SHOW_MAP = 0xD64; // Size: 0
		public const int CZ_FLEE_OBSTACLE = 0xD65; // Size: 26
		public const int ZC_HOLD_MOVE_PATH = 0xD66; // Size: 11
		public const int ZC_ENTER_HOOK = 0xD67; // Size: 10
		public const int ZC_LEAVE_HOOK = 0xD68; // Size: 10
		public const int ZC_MONSTER_PROPERTY = 0xD69; // Size: 0
		public const int ZC_GROUND_EFFECT = 0xD6A; // Size: 50
		public const int ZC_FLY = 0xD6B; // Size: 18
		public const int ZC_FLY_MATH = 0xD6C; // Size: 22
		public const int ZC_FLY_HEIGHT = 0xD6D; // Size: 14
		public const int ZC_UPDATE_SHIELD = 0xD6E; // Size: 14
		public const int ZC_SHOW_MODEL = 0xD6F; // Size: 15
		public const int ZC_SKILL_RANGE_DBG = 0xD70; // Size: 58
		public const int ZC_SKILL_RANGE_FAN = 0xD71; // Size: 40
		public const int ZC_SKILL_RANGE_SQUARE = 0xD72; // Size: 40
		public const int ZC_SKILL_RANGE_CIRCLE = 0xD73; // Size: 28
		public const int ZC_SKILL_RANGE_DONUTS = 0xD74; // Size: 32
		public const int ZC_TEAMID = 0xD75; // Size: 11
		public const int ZC_PC = 0xD76; // Size: 0
		public const int CZ_LOG = 0xD77; // Size: 0
		public const int ZC_MOTIONBLUR = 0xD78; // Size: 11
		public const int ZC_PLAY_FORCE = 0xD79; // Size: 78
		public const int ZC_CAST_TARGET = 0xD7A; // Size: 14
		public const int ZC_START_INFO = 0xD7B; // Size: 0
		public const int ZC_JOB_EXP_UP = 0xD7C; // Size: 10
		public const int ZC_JOB_PTS = 0xD7D; // Size: 10
		public const int ZC_MON_STAMINA = 0xD7E; // Size: 22
		public const int CZ_CUSTOM_SCP = 0xD7F; // Size: 14
		public const int ZC_VIEW_FOCUS = 0xD80; // Size: 24
		public const int ZC_HARDCODED_SKILL = 0xD81; // Size: 26
		public const int CZ_HARDCODED_SKILL = 0xD82; // Size: 34
		public const int ZC_FORCE_MOVE = 0xD83; // Size: 30
		public const int ZC_HSKILL_CONTROL = 0xD84; // Size: 22
		public const int ZC_CANCEL_DEADEVENT = 0xD85; // Size: 10
		public const int ZC_ACTION_PKS = 0xD86; // Size: 35
		public const int CZ_HARDCODED_ITEM = 0xD87; // Size: 22
		public const int CZ_CANCEL_TRANSFORM_SKILL = 0xD88; // Size: 10
		public const int CZ_BRIQUET = 0xD89; // Size: 30
		public const int ZC_VIBRATE = 0xD8A; // Size: 30
		public const int ZC_COUNTER_MOVE = 0xD8B; // Size: 10
		public const int CZ_COUNTER_ATTACK = 0xD8C; // Size: 14
		public const int CZ_CLIENT_DIRECT = 0xD8D; // Size: 30
		public const int ZC_CLIENT_DIRECT = 0xD8E; // Size: 30
		public const int ZC_OWNER = 0xD8F; // Size: 14
		public const int ZC_GD_RANK = 0xD90; // Size: 10
		public const int CZ_RUN_BGEVENT = 0xD91; // Size: 74
		public const int ZC_ADD_SKILL_EFFECT = 0xD92; // Size: 18
		public const int ZC_ITEM_DROPABLE = 0xD93; // Size: 10
		public const int CZ_ITEM_DROP_TO_OBJECT = 0xD94; // Size: 26
		public const int ZC_NORMAL = 0xD95; // Size: 0
		public const int CZ_G_QUEST_CHECK = 0xD96; // Size: 14
		public const int ZC_MOVE_PATH_MATH = 0xD97; // Size: 30
		public const int CZ_MYPAGE_COMMENT_ADD = 0xD98; // Size: 278
		public const int CZ_MYPAGE_COMMENT_DELETE = 0xD99; // Size: 18
		public const int CZ_GUESTPAGE_COMMENT_ADD = 0xD9A; // Size: 278
		public const int CZ_GET_TARGET_MYPAGE = 0xD9B; // Size: 14
		public const int CZ_ON_MYPAGE_MODE = 0xD9C; // Size: 14
		public const int CZ_RESET_SOCIAL_MODE = 0xD9D; // Size: 10
		public const int CZ_GET_TARGET_GUESTPAGE = 0xD9E; // Size: 14
		public const int CZ_ADD_SELLMODE_ITEM = 0xD9F; // Size: 30
		public const int CZ_DELETE_SELLMODE_ITEM = 0xDA0; // Size: 18
		public const int CZ_ON_SELLITEM_MODE = 0xDA1; // Size: 14
		public const int ZC_MYPAGE_MAP = 0xDA2; // Size: 0
		public const int ZC_GUESTPAGE_MAP = 0xDA3; // Size: 0
		public const int ZC_ON_MYPAGE_MODE = 0xDA4; // Size: 0
		public const int ZC_RESET_SOCIAL_MODE = 0xDA5; // Size: 10
		public const int CZ_ON_ITEMBUY_MODE = 0xDA6; // Size: 0
		public const int ZC_ON_BUYITEM_MODE = 0xDA7; // Size: 0
		public const int ZC_SHOW_GROUND_ITEM_MARK = 0xDA8; // Size: 30
		public const int ZC_HELP_LIST = 0xDA9; // Size: 0
		public const int ZC_HELP_ADD = 0xDAA; // Size: 11
		public const int CZ_CLIENT_HIT_LIST = 0xDAB; // Size: 0
		public const int ZC_PC_ATKSTATE = 0xDAC; // Size: 11
		public const int ZC_SEND_PREMIUM_STATE = 0xDAD; // Size: 16
		public const int CZ_HELP_READ_TYPE = 0xDAE; // Size: 18
		public const int CZ_MOVE_PATH_END = 0xDAF; // Size: 10
		public const int ZC_COLL_DAMAGE = 0xDB0; // Size: 11
		public const int CZ_KEYBOARD_BEAT = 0xDB1; // Size: 10
		public const int CZ_MOVEHIT_SCP = 0xDB2; // Size: 22
		public const int ZC_SYNC_START = 0xDB3; // Size: 14
		public const int ZC_SYNC_END = 0xDB4; // Size: 14
		public const int ZC_SYNC_EXEC = 0xDB5; // Size: 10
		public const int ZC_SYNC_EXEC_BY_SKILL_TIME = 0xDB6; // Size: 18
		public const int CZ_STOP_TIMEACTION = 0xDB7; // Size: 11
		public const int CZ_REQ_DUMMYPC_INFO = 0xDB8; // Size: 18
		public const int CZ_VISIT_BARRACK = 0xDB9; // Size: 74
		public const int CZ_SPC_SKILL_POS = 0xDBA; // Size: 22
		public const int CZ_REQ_CHANGEJOB = 0xDBB; // Size: 14
		public const int CZ_CHANGE_HEAD = 0xDBC; // Size: 74
		public const int CZ_CREATE_ARROW_CRAFT = 0xDBD; // Size: 14
		public const int CZ_REQ_MINITEXT = 0xDBE; // Size: 266
		public const int ZC_PC_MOVE_STOP = 0xDBF; // Size: 35
		public const int CZ_STOP_ALLPC = 0xDC0; // Size: 10
		public const int CZ_COMPLETE_PRELOAD = 0xDC1; // Size: 14
		public const int CZ_MGAME_JOIN_CMD = 0xDC2; // Size: 46
		public const int CZ_ADD_HELP = 0xDC3; // Size: 14
		public const int ZC_ATTACH_TO_OBJ = 0xDC4; // Size: 49
		public const int ZC_DETACH_FROM_OBJ = 0xDC5; // Size: 14
		public const int ZC_RUN_FROM = 0xDC6; // Size: 14
		public const int ZC_LOOKAT_OBJ = 0xDC7; // Size: 14
		public const int CZ_SKILL_CELL_LIST = 0xDC8; // Size: 0
		public const int CZ_SKILL_TOOL_GROUND_POS = 0xDC9; // Size: 26
		public const int CZ_DIRECTION_PROCESS = 0xDCA; // Size: 18
		public const int CZ_DIRECTION_MOVE_STATE = 0xDCB; // Size: 0
		public const int ZC_TO_ALL_CLIENT = 0xDCC; // Size: 0
		public const int ZC_TO_CLIENT = 0xDCD; // Size: 0
		public const int CZ_REWARD_CMD = 0xDCE; // Size: 14
		public const int CZ_PROPERTY_COMPARE = 0xDCF; // Size: 16
		public const int ZC_PROPERTY_COMPARE = 0xDD0; // Size: 0
		public const int ZC_PROPERTY_COMPARE_FOR_ACT = 0xDD1; // Size: 0
		public const int ZC_FACTION = 0xDD2; // Size: 14
		public const int ZC_SEND_CASH_VALUE = 0xDD3; // Size: 0
		public const int ZC_BEGIN_KILL_LOG = 0xDD4; // Size: 6
		public const int ZC_END_KILL_LOG = 0xDD5; // Size: 6
		public const int ZC_CLEAR_KILL_LOG = 0xDD6; // Size: 6
		public const int CZ_NPC_AUCTION_CMD = 0xDD7; // Size: 30
		public const int ZC_DIRECTION_APC = 0xDD8; // Size: 26
		public const int ZC_BGMODEL_ANIM_INFO = 0xDD9; // Size: 15
		public const int ZC_ATTACH_BY_KNOCKBACK = 0xDDA; // Size: 38
		public const int CZ_OBJECT_MOVE = 0xDDB; // Size: 30
		public const int CZ_CONTROL_OBJECT_ROTATE = 0xDDC; // Size: 22
		public const int CZ_SUMMON_COMMAND = 0xDDD; // Size: 18
		public const int CZ_VEHICLE_RIDE = 0xDDE; // Size: 15
		public const int CZ_REQ_WIKI_CATEGORY_RANK_PAGE_INFO = 0xDDF; // Size: 78
		public const int CZ_REQ_ACHIEVE_RANK_PAGE_INFO = 0xDE0; // Size: 78
		public const int CZ_REQ_MONSTER_RANK_INFO = 0xDE1; // Size: 74
		public const int ZC_SPC_TRIGGER_EXEC = 0xDE2; // Size: 30
		public const int CZ_REQ_MGAME_VIEW = 0xDE3; // Size: 18
		public const int CZ_REQ_MGAME_CHAT = 0xDE4; // Size: 0
		public const int CZ_TOURNAMENT_GIFT = 0xDE5; // Size: 18
		public const int CZ_PARTY_INVITE_ACCEPT = 0xDE6; // Size: 79
		public const int CZ_PARTY_INVITE_CANCEL = 0xDE7; // Size: 83
		public const int CZ_PARTY_PROP_CHANGE = 0xDE8; // Size: 145
		public const int CZ_REQ_MARKET_REGISTER = 0xDE9; // Size: 40
		public const int CZ_REQ_MARKET_MINMAX_INFO = 0xDEA; // Size: 18
		public const int CZ_REQ_MARKET_BUY = 0xDEB; // Size: 0
		public const int CZ_REQ_MARKET_LIST = 0xDEC; // Size: 162
		public const int CZ_REQ_MY_SELL_LIST = 0xDED; // Size: 14
		public const int CZ_REQ_CABINET_LIST = 0xDEE; // Size: 10
		public const int CZ_REQ_GET_CABINET_ITEM = 0xDEF; // Size: 26
		public const int CZ_REQ_CANCEL_MARKET_ITEM = 0xDF0; // Size: 18
		public const int CZ_INV_ITEM_LOCK = 0xDF1; // Size: 19
		public const int CZ_OBJ_RECORD_POS = 0xDF2; // Size: 0
		public const int CZ_FORMATION_CMD = 0xDF3; // Size: 32
		public const int CZ_REGISTER_AUTOSELLER = 0xDF4; // Size: 0
		public const int CZ_OPEN_AUTOSELLER = 0xDF5; // Size: 34
		public const int CZ_BUY_AUTOSELLER_ITEMS = 0xDF6; // Size: 0
		public const int CZ_SELL_MY_AUTOSELLER_ITEMS = 0xDF7; // Size: 0
		public const int CZ_PUZZLE_CRAFT = 0xDF8; // Size: 0
		public const int CZ_PET_EQUIP = 0xDF9; // Size: 30
		public const int ZC_FOUND_PARTY_LIST = 0xDFA; // Size: 0
		public const int ZC_NEAR_PARTY_LIST = 0xDFB; // Size: 0
		public const int ZC_RECOMMEND_PARTY_INFO = 0xDFC; // Size: 0
		public const int CZ_REQUEST_SOME_PARTY = 0xDFD; // Size: 90
		public const int CZ_REFRESH_MEMBERRECOMMEND_LIST = 0xDFE; // Size: 10
		public const int ZC_TO_SOMEWHERE_CLIENT = 0xDFF; // Size: 0
		public const int CZ_REVEAL_NPC_STATE = 0xE00; // Size: 14
		public const int CZ_CHANGE_CHANNEL = 0xE01; // Size: 12
		public const int CZ_REQ_CHANNEL_TRAFFICS = 0xE02; // Size: 12
		public const int CZ_BUY_PROPERTYSHOP_ITEM = 0xE03; // Size: 0
		public const int CZ_SKILL_USE_HEIGHT = 0xE04; // Size: 14
		public const int CZ_ACCEPT_PARTY_QUEST = 0xE05; // Size: 20
		public const int CZ_ACCEPT_GUILD_EVENT = 0xE06; // Size: 20
		public const int CZ_ACCEPT_GUILD_EVENT_RAID = 0xE07; // Size: 20
		public const int CZ_ACCEPT_PARTY_EVENT = 0xE08; // Size: 20
		public const int CZ_DELETE_PARTY_EVENT = 0xE09; // Size: 20
		public const int CZ_PING = 0xE0A; // Size: 10
		public const int ZC_PING = 0xE0B; // Size: 10
		public const int ZC_XIGNCODE_BUFFER = 0xE0C; // Size: 524
		public const int CZ_XIGNCODE_BUFFER = 0xE0D; // Size: 524
		public const int CZ_SYSTEM_LOG_SAVE_TO_MONGODB = 0xE0E; // Size: 280
		public const int CZ_CHANGE_TITLE = 0xE0F; // Size: 74
		public const int CZ_PC_COMMENT_CHANGE = 0xE10; // Size: 0
		public const int CZ_AUTTOSELLER_BUYER_CLOSE = 0xE11; // Size: 18
		public const int CZ_REQ_ITEM_LIST = 0xE12; // Size: 11
		public const int CZ_HIT_MISSILE = 0xE13; // Size: 14
		public const int CZ_I_NEED_PARTY = 0xE14; // Size: 23
		public const int CZ_PARTY_JOIN_BY_LINK = 0xE15; // Size: 19
		public const int ZC_RECOMMEND_PARTYMEMBER_INFO = 0xE16; // Size: 0
		public const int CZ_PVP_ZONE_CMD = 0xE17; // Size: 26
		public const int CZ_PVP_CHAT = 0xE18; // Size: 0
		public const int CZ_CARDBATTLE_CMD = 0xE19; // Size: 26
		public const int CZ_REQ_UPDATE_CONTENTS_SESSION = 0xE1A; // Size: 10
		public const int CZ_REQ_FRIENDLY_FIGHT = 0xE1B; // Size: 15
		public const int CZ_HARDSKILL_POS_LIST = 0xE1C; // Size: 0
		public const int CZ_CART_POSITION = 0xE1D; // Size: 26
		public const int CZ_REQ_RIDE_CART = 0xE1E; // Size: 18
		public const int CZ_DUMMYPC_SKILL_POS = 0xE1F; // Size: 26
		public const int CZ_NGS = 0xE20; // Size: 0
		public const int CZ_PARTY_MEMBER_SKILL_USE = 0xE21; // Size: 0
		public const int CZ_PARTY_MEMBER_SKILL_ACCEPT = 0xE22; // Size: 22
		public const int CZ_SYSTEM_LOG_TO_SERVER = 0xE23; // Size: 1099
		public const int CZ_CHECK_PING = 0xE24; // Size: 10
		public const int CZ_CANCEL_INDUN_MATCHING = 0xE25; // Size: 10
		public const int CZ_REQ_GM_ORDER = 0xE26; // Size: 202
		public const int CZ_REPORT_AUTOBOT = 0xE27; // Size: 74
		public const int CZ_PARTY_INVENTORY_LOAD = 0xE28; // Size: 11
		public const int CZ_REQ_MOVE_PARTYINV_TO_ACCOUNT = 0xE29; // Size: 31
		public const int CZ_REQ_CancelGachaCube = 0xE2A; // Size: 10
		public const int CZ_WAREHOUSE_TAKE_LIST = 0xE2B; // Size: 0
		public const int CZ_PVP_COMMAND = 0xE2C; // Size: 22

		private static readonly Dictionary<int, int> _sizes = new Dictionary<int, int>();
		private static readonly Dictionary<int, string> _names = new Dictionary<int, string>();

		static Op()
		{
			_sizes[Op.CB_LOGIN] = 66;
			_sizes[Op.CB_LOGIN_BY_PASSPORT] = 1068;
			_sizes[Op.CB_LOGOUT] = 10;
			_sizes[Op.CB_START_BARRACK] = 11;
			_sizes[Op.CB_COMMANDER_CREATE] = 96;
			_sizes[Op.CB_COMMANDER_DESTROY] = 11;
			_sizes[Op.CB_CHECK_CLIENT_INTEGRITY] = 74;
			_sizes[Op.CB_CLIENT_INTEGRITY_FAIL] = 1035;
			_sizes[Op.CB_START_GAME] = 13;
			_sizes[Op.CB_BARRACKNAME_CHANGE] = 74;
			_sizes[Op.CB_COMMANDER_MOVE] = 31;
			_sizes[Op.CB_ECHO] = 30;
			_sizes[Op.BC_LOGINOK] = 121;
			_sizes[Op.BC_LOGIN_PACKET_RECEIVED] = 6;
			_sizes[Op.BC_LOGOUTOK] = 6;
			_sizes[Op.BC_COMMANDER_LIST] = 0;
			_sizes[Op.BC_COMMANDER_CREATE] = 334;
			_sizes[Op.BC_COMMANDER_DESTROY] = 7;
			_sizes[Op.BC_START_GAMEOK] = 33;
			_sizes[Op.BC_SINGLE_INFO] = 325;
			_sizes[Op.BC_MESSAGE] = 0;
			_sizes[Op.BC_ECHO] = 26;
			_sizes[Op.BC_MYPAGE_MAP] = 0;
			_sizes[Op.BC_BARRACKNAME_CHANGE] = 75;
			_sizes[Op.CB_IES_MODIFY_INFO] = 0;
			_sizes[Op.BC_IES_MODIFY_INFO] = 0;
			_sizes[Op.BC_IES_MODIFY_LIST] = 0;
			_sizes[Op.CB_IES_REVISION_DELETE] = 0;
			_sizes[Op.BC_IES_REVISION_DELETE] = 0;
			_sizes[Op.CB_VISIT] = 74;
			_sizes[Op.CB_BUY_THEMA] = 22;
			_sizes[Op.BC_ACCOUNT_PROP] = 0;
			_sizes[Op.CB_CURRENT_BARRACK] = 39;
			_sizes[Op.BC_NORMAL] = 0;
			_sizes[Op.CB_POSE] = 15;
			_sizes[Op.CB_PLACE_CMD] = 46;
			_sizes[Op.CB_CHAT] = 0;
			_sizes[Op.BC_CHAT] = 0;
			_sizes[Op.CB_ECHO_NORMAL] = 0;
			_sizes[Op.CB_REQ_SLOT_PRICE] = 10;
			_sizes[Op.BC_REQ_SLOT_PRICE] = 10;
			_sizes[Op.CB_JUMP] = 19;
			_sizes[Op.BC_JUMP] = 19;
			_sizes[Op.BC_SERVER_ENTRY] = 18;
			_sizes[Op.CB_PET_PC] = 26;
			_sizes[Op.CB_PET_COMMAND] = 27;
			_sizes[Op.CB_REQ_CHANGE_POSTBOX_STATE] = 23;
			_sizes[Op.CB_REQ_GET_POSTBOX_ITEM] = 1051;
			_sizes[Op.CB_REQ_POSTBOX_PAGE] = 14;
			_sizes[Op.BC_WAIT_QUEUE_ORDER] = 10;
			_sizes[Op.CB_CANCEL_SERVER_WAIT_QUEUE] = 10;
			_sizes[Op.CB_NGS] = 10254;
			_sizes[Op.ZC_TREASUREMARK_LIST_MAP] = 0;
			_sizes[Op.CS_LOGIN] = 64;
			_sizes[Op.SC_NORMAL] = 0;
			_sizes[Op.SC_FROM_INTEGRATE] = 0;
			_sizes[Op.CS_REGISTER_SNS_ID] = 16;
			_sizes[Op.CS_REQ_SNS_PC_INFO] = 0;
			_sizes[Op.CS_REQ_ADD_FRIEND] = 70;
			_sizes[Op.CS_REQ_BLOCK_FRIEND] = 70;
			_sizes[Op.CS_FRIEND_CMD] = 24;
			_sizes[Op.CS_FRIEND_SET_ADDINFO] = 160;
			_sizes[Op.CS_CHAT] = 0;
			_sizes[Op.CS_CREATE_GROUP_CHAT] = 6;
			_sizes[Op.CS_GROUP_CHAT_INVITE] = 78;
			_sizes[Op.CS_REFRESH_GROUP_CHAT] = 6;
			_sizes[Op.CS_CHAT_HISTORY] = 22;
			_sizes[Op.CS_CHAT_READ] = 30;
			_sizes[Op.CS_REMOVE_GROUP_MEMBER] = 14;
			_sizes[Op.CS_REQ_RELATED_PC_SESSION] = 16;
			_sizes[Op.CS_REDIS_SKILLPOINT] = 22;
			_sizes[Op.CS_PARTY_CLIENT_INFO_SEND] = 0;
			_sizes[Op.CS_NORMAL_GAME_START] = 6;
			_sizes[Op.CS_REQUEST_PVP_RANKING] = 88;
			_sizes[Op.CS_INVITE_PARTY_PVP] = 10;
			_sizes[Op.CS_ACCEPT_PARTY_PVP] = 19;
			_sizes[Op.CS_LIKE_IT] = 88;
			_sizes[Op.CS_UNLIKE_IT] = 24;
			_sizes[Op.CS_LIKE_IT_CONFIRM] = 16;
			_sizes[Op.CS_ADD_RELATION_SCORE] = 88;
			_sizes[Op.CS_GET_LIKE_COUNT] = 16;
			_sizes[Op.CZ_CONNECT] = 1200;
			_sizes[Op.ZC_CONNECT_OK] = 0;
			_sizes[Op.ZC_MOVE_ZONE] = 7;
			_sizes[Op.CZ_MOVE_ZONE_OK] = 10;
			_sizes[Op.ZC_CONNECT_FAILED] = 0;
			_sizes[Op.CZ_GAME_READY] = 10;
			_sizes[Op.ZC_MOVE_ZONE_OK] = 57;
			_sizes[Op.CZ_LOGOUT] = 11;
			_sizes[Op.CZ_MOVE_BARRACK] = 11;
			_sizes[Op.ZC_MOVE_BARRACK] = 6;
			_sizes[Op.ZC_LOGOUT_OK] = 6;
			_sizes[Op.ZC_MESSAGE] = 0;
			_sizes[Op.ZC_RESET_VIEW] = 6;
			_sizes[Op.ZC_START_GAME] = 26;
			_sizes[Op.ZC_QUIET] = 7;
			_sizes[Op.ZC_ENTER_PC] = 341;
			_sizes[Op.ZC_ENTER_MONSTER] = 0;
			_sizes[Op.ZC_ENTER_DUMMYPC] = 308;
			_sizes[Op.ZC_UPDATED_DUMMYPC] = 266;
			_sizes[Op.ZC_ENTER_ITEM] = 103;
			_sizes[Op.ZC_LEAVE] = 12;
			_sizes[Op.ZC_MOVE_PATH] = 42;
			_sizes[Op.ZC_MOVE_POS] = 43;
			_sizes[Op.ZC_MOVE_DIR] = 40;
			_sizes[Op.ZC_EXPECTED_STOPPOS] = 35;
			_sizes[Op.ZC_MSPD] = 14;
			_sizes[Op.ZC_MOVE_SPEED] = 19;
			_sizes[Op.ZC_MOVE_STOP] = 23;
			_sizes[Op.ZC_REST_SIT] = 12;
			_sizes[Op.ZC_JUMP] = 19;
			_sizes[Op.ZC_JUMP_DIR] = 34;
			_sizes[Op.ZC_ORDER_SKILL_JUMP] = 10;
			_sizes[Op.ZC_SKILL_JUMP] = 38;
			_sizes[Op.ZC_SET_POS] = 23;
			_sizes[Op.ZC_FILE_MOVE] = 46;
			_sizes[Op.CZ_LEAVE_TO_DUNGEON] = 10;
			_sizes[Op.ZC_UPDATED_PCAPPEARANCE] = 266;
			_sizes[Op.ZC_UPDATED_MONSTERAPPEARANCE] = 0;
			_sizes[Op.ZC_CHAT] = 0;
			_sizes[Op.ZC_CHAT_WITH_TEXTCODE] = 14;
			_sizes[Op.ZC_STANCE_CHANGE] = 14;
			_sizes[Op.ZC_ADD_HP] = 22;
			_sizes[Op.ZC_SKILL_CAST_CANCEL] = 10;
			_sizes[Op.ZC_SKILL_CAST] = 38;
			_sizes[Op.ZC_SKILL_READY] = 50;
			_sizes[Op.ZC_SKILL_DISABLE] = 15;
			_sizes[Op.ZC_SKILL_USE_CANCEL] = 10;
			_sizes[Op.ZC_SKILL_MELEE_TARGET] = 0;
			_sizes[Op.ZC_SKILL_MELEE_GROUND] = 0;
			_sizes[Op.ZC_SKILL_FORCE_TARGET] = 0;
			_sizes[Op.ZC_SKILL_FORCE_GROUND] = 0;
			_sizes[Op.ZC_SKILL_HIT_INFO] = 0;
			_sizes[Op.ZC_BUFF_LIST] = 0;
			_sizes[Op.ZC_BUFF_ADD] = 0;
			_sizes[Op.ZC_BUFF_UPDATE] = 0;
			_sizes[Op.ZC_BUFF_REMOVE] = 19;
			_sizes[Op.ZC_BUFF_CLEAR] = 11;
			_sizes[Op.CZ_BUFF_REMOVE] = 14;
			_sizes[Op.CZ_INTE_WARP] = 14;
			_sizes[Op.ZC_ROTATE] = 20;
			_sizes[Op.ZC_ROTATE_RESERVED] = 18;
			_sizes[Op.ZC_HEAD_ROTATE] = 18;
			_sizes[Op.ZC_TARGET_ROTATE] = 18;
			_sizes[Op.ZC_QUICK_ROTATE] = 18;
			_sizes[Op.ZC_POSE] = 34;
			_sizes[Op.ZC_DEAD] = 0;
			_sizes[Op.ZC_RESURRECT] = 18;
			_sizes[Op.ZC_CHANGE_RELATION] = 11;
			_sizes[Op.ZC_RESURRECT_DIALOG] = 7;
			_sizes[Op.ZC_HIT_INFO] = 64;
			_sizes[Op.ZC_HEAL_INFO] = 30;
			_sizes[Op.ZC_CAUTION_DAMAGE_INFO] = 15;
			_sizes[Op.ZC_CAUTION_DAMAGE_RELEASE] = 10;
			_sizes[Op.ZC_KNOCKBACK_INFO] = 70;
			_sizes[Op.ZC_KNOCKDOWN_INFO] = 71;
			_sizes[Op.CZ_RESURRECT] = 11;
			_sizes[Op.ZC_RESURRECT_SAVE_POINT_ACK] = 7;
			_sizes[Op.ZC_RESURRECT_HERE_ACK] = 7;
			_sizes[Op.CZ_CLICK_TRIGGER] = 15;
			_sizes[Op.CZ_KEYBOARD_MOVE] = 41;
			_sizes[Op.CZ_EXPECTED_STOP_POS] = 31;
			_sizes[Op.CZ_JUMP] = 11;
			_sizes[Op.CZ_DASHRUN] = 11;
			_sizes[Op.CZ_SKILL_JUMP_REQ] = 30;
			_sizes[Op.CZ_MOVE_PATH] = 27;
			_sizes[Op.CZ_MOVE_STOP] = 35;
			_sizes[Op.CZ_REST_SIT] = 10;
			_sizes[Op.CZ_REQ_CHAR_SLOT] = 11;
			_sizes[Op.CZ_ON_AIR] = 10;
			_sizes[Op.CZ_ON_GROUND] = 10;
			_sizes[Op.CZ_MOVEMENT_INFO] = 23;
			_sizes[Op.CZ_SKILL_TARGET] = 19;
			_sizes[Op.CZ_SKILL_TARGET_ANI] = 23;
			_sizes[Op.CZ_SKILL_GROUND] = 61;
			_sizes[Op.CZ_SKILL_SELF] = 35;
			_sizes[Op.CZ_SKILL_CANCEL] = 12;
			_sizes[Op.CZ_HOLD] = 11;
			_sizes[Op.CZ_ROTATE] = 18;
			_sizes[Op.CZ_HEAD_ROTATE] = 18;
			_sizes[Op.CZ_TARGET_ROTATE] = 18;
			_sizes[Op.CZ_POSE] = 34;
			_sizes[Op.CZ_CHAT] = 0;
			_sizes[Op.CZ_CHAT_LOG] = 0;
			_sizes[Op.CZ_SHOUT] = 0;
			_sizes[Op.CZ_ITEM_DROP] = 22;
			_sizes[Op.CZ_ITEM_DELETE] = 0;
			_sizes[Op.CZ_ITEM_USE] = 22;
			_sizes[Op.CZ_ITEM_USE_TO_ITEM] = 30;
			_sizes[Op.CZ_ITEM_USE_TO_GROUND] = 30;
			_sizes[Op.CZ_ITEM_BUY] = 0;
			_sizes[Op.CZ_ITEM_SELL] = 0;
			_sizes[Op.CZ_ITEM_EQUIP] = 19;
			_sizes[Op.CZ_ITEM_UNEQUIP] = 11;
			_sizes[Op.ZC_CHECK_INVINDEX] = 30;
			_sizes[Op.CZ_PREMIUM_ENCHANTCHIP] = 26;
			_sizes[Op.CZ_PREMIUM_GACHACUBE] = 10;
			_sizes[Op.ZC_ITEM_INVENTORY_LIST] = 0;
			_sizes[Op.ZC_ITEM_INVENTORY_INDEX_LIST] = 0;
			_sizes[Op.ZC_ITEM_EQUIP_LIST] = 0;
			_sizes[Op.ZC_ITEM_ADD] = 0;
			_sizes[Op.ZC_ITEM_REMOVE] = 20;
			_sizes[Op.ZC_ITEM_USE] = 14;
			_sizes[Op.ZC_ITEM_USE_TO_GROUND] = 22;
			_sizes[Op.CZ_ITEM_ADD_WIKI] = 18;
			_sizes[Op.ZC_QUICK_SLOT_LIST] = 0;
			_sizes[Op.ZC_SKILL_LIST] = 0;
			_sizes[Op.ZC_SKILL_ADD] = 0;
			_sizes[Op.ZC_ABILITY_LIST] = 0;
			_sizes[Op.CZ_ACTIVE_ABILITY] = 15;
			_sizes[Op.ZC_ACTIVE_ABILITY] = 11;
			_sizes[Op.CZ_REQ_OPEN_ITEM_DUNGEON] = 19;
			_sizes[Op.CZ_ANSWER_OPEN_ITEM_DUNGEON] = 19;
			_sizes[Op.CZ_SEND_ITEM_PROP_TO_ALCHMIST] = 28;
			_sizes[Op.CZ_EXCUTE_ITEM_DUNGEON] = 34;
			_sizes[Op.ZC_RECIVE_ITEM_PROP_TO_TARGET] = 0;
			_sizes[Op.CZ_DISPEL_DEBUFF_TOGGLE] = 14;
			_sizes[Op.CZ_JUNGTAN_TOGGLE] = 16;
			_sizes[Op.ZC_EXP_UP] = 14;
			_sizes[Op.ZC_EXP_UP_BY_MONSTER] = 18;
			_sizes[Op.ZC_PC_LEVELUP] = 14;
			_sizes[Op.ZC_PC_STAT_AVG] = 30;
			_sizes[Op.ZC_MAX_EXP_CHANGED] = 22;
			_sizes[Op.ZC_TEXT] = 0;
			_sizes[Op.ZC_UPDATE_SP] = 15;
			_sizes[Op.ZC_RESTORATION] = 12;
			_sizes[Op.ZC_UPDATE_MHP] = 14;
			_sizes[Op.CZ_DIALOG_ACK] = 14;
			_sizes[Op.CZ_DIALOG_SELECT] = 11;
			_sizes[Op.CZ_DIALOG_STRINGINPUT] = 138;
			_sizes[Op.ZC_DIALOG_OK] = 0;
			_sizes[Op.ZC_DIALOG_NEXT] = 0;
			_sizes[Op.ZC_DIALOG_SELECT] = 0;
			_sizes[Op.ZC_DIALOG_ITEM_SELECT] = 0;
			_sizes[Op.ZC_DIALOG_CLOSE] = 6;
			_sizes[Op.ZC_DIALOG_TRADE] = 39;
			_sizes[Op.ZC_DIALOG_COMMON_TRADE] = 39;
			_sizes[Op.ZC_DIALOG_NUMBERRANGE] = 0;
			_sizes[Op.ZC_DIALOG_STRINGINPUT] = 0;
			_sizes[Op.ZC_ADDON_MSG] = 0;
			_sizes[Op.CZ_UI_EVENT] = 0;
			_sizes[Op.ZC_PLAY_SOUND] = 15;
			_sizes[Op.ZC_STOP_SOUND] = 14;
			_sizes[Op.ZC_PLAY_MUSICQUEUE] = 14;
			_sizes[Op.ZC_STOP_MUSICQUEUE] = 14;
			_sizes[Op.ZC_PLAY_ANI] = 24;
			_sizes[Op.ZC_CHANGE_ANI] = 44;
			_sizes[Op.CZ_MOVE_CAMP] = 18;
			_sizes[Op.CZ_CAMPINFO] = 18;
			_sizes[Op.ZC_CAMPINFO] = 18;
			_sizes[Op.ZC_FIX_ANIM] = 14;
			_sizes[Op.CZ_TARGET_JOB_INFO] = 18;
			_sizes[Op.ZC_TARGET_JOB_INFO] = 14;
			_sizes[Op.ZC_MOVE_ANIM] = 12;
			_sizes[Op.ZC_STD_ANIM] = 11;
			_sizes[Op.ZC_PLAY_ALARMSOUND] = 83;
			_sizes[Op.ZC_STOP_ALARMSOUND] = 10;
			_sizes[Op.ZC_PLAY_EXP_TEXT] = 14;
			_sizes[Op.ZC_PLAY_NAVI_EFFECT] = 150;
			_sizes[Op.ZC_UPDATE_ALL_STATUS] = 26;
			_sizes[Op.ZC_OBJECT_PROPERTY] = 0;
			_sizes[Op.ZC_DUMP_PROPERTY] = 0;
			_sizes[Op.ZC_SHOUT] = 0;
			_sizes[Op.ZC_SHOUT_FAILED] = 7;
			_sizes[Op.CZ_EXCHANGE_REQUEST] = 14;
			_sizes[Op.ZC_EXCHANGE_REQUEST_ACK] = 72;
			_sizes[Op.ZC_EXCHANGE_REQUEST_RECEIVED] = 71;
			_sizes[Op.CZ_EXCHANGE_ACCEPT] = 10;
			_sizes[Op.CZ_EXCHANGE_DECLINE] = 10;
			_sizes[Op.ZC_EXCHANGE_DECLINE_ACK] = 6;
			_sizes[Op.ZC_EXCHANGE_START] = 71;
			_sizes[Op.CZ_EXCHANGE_OFFER] = 30;
			_sizes[Op.ZC_EXCHANGE_OFFER_ACK] = 0;
			_sizes[Op.CZ_EXCHANGE_AGREE] = 10;
			_sizes[Op.ZC_EXCHANGE_AGREE_ACK] = 7;
			_sizes[Op.CZ_EXCHANGE_FINALAGREE] = 10;
			_sizes[Op.ZC_EXCHANGE_FINALAGREE_ACK] = 7;
			_sizes[Op.CZ_EXCHANGE_CANCEL] = 10;
			_sizes[Op.ZC_EXCHANGE_CANCEL_ACK] = 6;
			_sizes[Op.ZC_EXCHANGE_SUCCESS] = 6;
			_sizes[Op.ZC_COOLDOWN_LIST] = 0;
			_sizes[Op.ZC_COOLDOWN_CHANGED] = 22;
			_sizes[Op.ZC_OVERHEAT_CHANGED] = 26;
			_sizes[Op.ZC_TEST_AGENT] = 18;
			_sizes[Op.CZ_COMMON_SHOP_LIST] = 10;
			_sizes[Op.ZC_COMMON_SHOP_LIST] = 8;
			_sizes[Op.ZC_TIME_FACTOR] = 10;
			_sizes[Op.ZC_PARTY_ENTER] = 0;
			_sizes[Op.ZC_PARTY_OUT] = 24;
			_sizes[Op.ZC_PARTY_DESTROY] = 15;
			_sizes[Op.ZC_PARTY_INFO] = 0;
			_sizes[Op.ZC_PARTY_LIST] = 0;
			_sizes[Op.ZC_PARTY_CHAT] = 0;
			_sizes[Op.ZC_PARTY_INST_INFO] = 0;
			_sizes[Op.ZC_CHANGE_EQUIP_DURABILITY] = 11;
			_sizes[Op.CZ_DIALOG_TX] = 0;
			_sizes[Op.CZ_REQ_RECIPE] = 0;
			_sizes[Op.ZC_CUSTOM_DIALOG] = 75;
			_sizes[Op.ZC_SESSION_OBJECTS] = 0;
			_sizes[Op.ZC_SESSION_OBJ_ADD] = 0;
			_sizes[Op.ZC_SESSION_OBJ_REMOVE] = 10;
			_sizes[Op.ZC_SESSION_OBJ_TIME] = 14;
			_sizes[Op.CZ_S_OBJ_VALUE_C] = 24;
			_sizes[Op.CZ_REQ_NORMAL_TX] = 45;
			_sizes[Op.ZC_COMMANDER_LOADER_INFO] = 0;
			_sizes[Op.ZC_MOVE_SINGLE_ZONE] = 18;
			_sizes[Op.ZC_BACKTO_ORIGINAL_SERVER] = 8;
			_sizes[Op.CZ_BACKTO_ORIGINAL_SERVER] = 12;
			_sizes[Op.CZ_REQ_NORMAL_TX_NUMARG] = 0;
			_sizes[Op.ZC_WIKI_LIST] = 0;
			_sizes[Op.ZC_WIKI_ADD] = 22;
			_sizes[Op.CZ_WIKI_GET] = 14;
			_sizes[Op.CZ_WIKI_RECIPE_UPDATE] = 10;
			_sizes[Op.ZC_UI_OPEN] = 39;
			_sizes[Op.ZC_ENABLE_CONTROL] = 11;
			_sizes[Op.ZC_CHANGE_CAMERA] = 31;
			_sizes[Op.ZC_MONSTER_SDR_CHANGED] = 11;
			_sizes[Op.ZC_MOVE_IGNORE_COLLISION] = 30;
			_sizes[Op.ZC_CHANGE_CAMERA_ZOOM] = 34;
			_sizes[Op.ZC_PLAY_SKILL_ANI] = 82;
			_sizes[Op.ZC_PLAY_SKILL_CAST_ANI] = 30;
			_sizes[Op.CZ_REQ_ITEM_GET] = 14;
			_sizes[Op.ZC_ITEM_GET] = 18;
			_sizes[Op.CZ_GUARD] = 19;
			_sizes[Op.ZC_GUARD] = 19;
			_sizes[Op.ZC_STAMINA] = 10;
			_sizes[Op.ZC_ADD_STAMINA] = 10;
			_sizes[Op.ZC_GM_ORDER] = 10;
			_sizes[Op.ZC_MYPC_ENTER] = 18;
			_sizes[Op.ZC_LOCK_KEY] = 75;
			_sizes[Op.ZC_SAVE_INFO] = 6;
			_sizes[Op.CZ_SAVE_INFO] = 0;
			_sizes[Op.ZC_OPTION_LIST] = 0;
			_sizes[Op.ZC_SKILLMAP_LIST] = 0;
			_sizes[Op.CZ_GIVEITEM_TO_DUMMYPC] = 22;
			_sizes[Op.CZ_FOOD_TABLE_TITLE] = 79;
			_sizes[Op.CZ_USE_TP_AND_ENTER_INDUN] = 522;
			_sizes[Op.ZC_SET_LAYER] = 10;
			_sizes[Op.ZC_CREATE_LAYERBOX] = 38;
			_sizes[Op.ZC_RESET_BOX] = 11;
			_sizes[Op.ZC_CREATE_SCROLLLOCKBOX] = 38;
			_sizes[Op.ZC_REMOVE_SCROLLLOCKBOX] = 10;
			_sizes[Op.CZ_DYNAMIC_CASTING_START] = 24;
			_sizes[Op.CZ_DYNAMIC_CASTING_END] = 19;
			_sizes[Op.CZ_SKILL_CANCEL_SCRIPT] = 10;
			_sizes[Op.ZC_LEAVE_TRIGGER] = 6;
			_sizes[Op.ZC_BORN] = 10;
			_sizes[Op.ZC_ACHIEVE_POINT_LIST] = 0;
			_sizes[Op.ZC_ACHIEVE_POINT] = 18;
			_sizes[Op.CZ_ACHIEVE_EQUIP] = 14;
			_sizes[Op.ZC_ACHIEVE_EQUIP] = 22;
			_sizes[Op.CZ_ACHIEVE_REWARD] = 14;
			_sizes[Op.CZ_CHANGE_CONFIG] = 18;
			_sizes[Op.CZ_CHANGE_CONFIG_STR] = 34;
			_sizes[Op.ZC_WORLD_MSG] = 43;
			_sizes[Op.ZC_ENABLE_SHOW_ITEM_GET] = 8;
			_sizes[Op.ZC_LOGIN_TIME] = 14;
			_sizes[Op.ZC_GIVE_EXP_TO_PC] = 42;
			_sizes[Op.ZC_LAYER_PC_LIST] = 0;
			_sizes[Op.ZC_LAYER_PC_SOBJ_PROP] = 0;
			_sizes[Op.CZ_CUSTOM_COMMAND] = 26;
			_sizes[Op.ZC_LAYER_INFO] = 10;
			_sizes[Op.CZ_CHAT_MACRO] = 146;
			_sizes[Op.ZC_CHAT_MACRO_LIST] = 0;
			_sizes[Op.ZC_RULLET_LIST] = 0;
			_sizes[Op.ZC_QUICKSLOT_REGISTER] = 46;
			_sizes[Op.CZ_QUICKSLOT_LIST] = 0;
			_sizes[Op.CZ_DOUBLE_ITEM_EQUIP] = 28;
			_sizes[Op.ZC_TRICK_PACKET] = 0;
			_sizes[Op.ZC_COOLDOWN_RATE] = 22;
			_sizes[Op.ZC_MAP_REVEAL_LIST] = 0;
			_sizes[Op.CZ_MAP_REVEAL_INFO] = 146;
			_sizes[Op.CZ_MAP_SEARCH_INFO] = 55;
			_sizes[Op.ZC_UI_INFO_LIST] = 0;
			_sizes[Op.ZC_EXEC_CLIENT_SCP] = 0;
			_sizes[Op.ZC_SET_NPC_STATE] = 18;
			_sizes[Op.ZC_NPC_STATE_LIST] = 0;
			_sizes[Op.CZ_QUEST_NPC_STATE_CHECK] = 14;
			_sizes[Op.ZC_RANK_ACHIEVE_ADD] = 14;
			_sizes[Op.CZ_GET_MAP_REVEAL_ACHIEVE] = 10;
			_sizes[Op.CZ_IES_MODIFY_INFO] = 0;
			_sizes[Op.ZC_IES_MODIFY_INFO] = 0;
			_sizes[Op.ZC_IES_MODIFY_LIST] = 0;
			_sizes[Op.CZ_IES_REVISION_DELETE] = 0;
			_sizes[Op.ZC_IES_REVISION_DELETE] = 0;
			_sizes[Op.ZC_EQUIP_ITEM_REMOVE] = 18;
			_sizes[Op.ZC_SOLD_ITEM_LIST] = 0;
			_sizes[Op.CZ_SOLD_ITEM] = 19;
			_sizes[Op.CZ_WAREHOUSE_CMD] = 32;
			_sizes[Op.CZ_SWAP_ETC_INV_CHANGE_INDEX] = 35;
			_sizes[Op.CZ_SORT_INV] = 12;
			_sizes[Op.CZ_EXTEND_WAREHOUSE] = 11;
			_sizes[Op.CZ_CAST_CONTROL_SHOT] = 10;
			_sizes[Op.ZC_PC_PROP_UPDATE] = 9;
			_sizes[Op.CZ_CLIENT_DAMAGE] = 14;
			_sizes[Op.CZ_CLIENT_ATTACK] = 15;
			_sizes[Op.ZC_SYSTEM_MSG] = 0;
			_sizes[Op.ZC_FSM_MOVE] = 0;
			_sizes[Op.CZ_QUEST_CHECK_SAVE] = 50;
			_sizes[Op.CZ_SPRAY_REQ_INFO] = 14;
			_sizes[Op.CZ_SPRAY_DRAW_INFO] = 0;
			_sizes[Op.ZC_SPRAY_ID] = 18;
			_sizes[Op.ZC_SPRAY_DRAW_INFO] = 0;
			_sizes[Op.ZC_MONSTER_LIFETIME] = 14;
			_sizes[Op.ZC_SPRAY_LIKE_LIST] = 0;
			_sizes[Op.ZC_WIKI_COUNT_UPDATE] = 19;
			_sizes[Op.ZC_WIKI_INT_PROP_UPDATE] = 15;
			_sizes[Op.ZC_WIKI_BOOL_PROP_UPDATE] = 12;
			_sizes[Op.CZ_REQ_WIKI_RANK] = 15;
			_sizes[Op.ZC_WIKI_RANK_LIST] = 0;
			_sizes[Op.ZC_SHARED_MSG] = 10;
			_sizes[Op.CZ_REQ_WIKI_PROP_RANK] = 16;
			_sizes[Op.CZ_GET_WIKI_REWARD] = 11;
			_sizes[Op.CZ_REQ_TX_ITEM] = 0;
			_sizes[Op.ZC_TEST_DBG] = 0;
			_sizes[Op.ZC_MONSTER_DIST] = 0;
			_sizes[Op.ZC_RESET_SKILL_FORCEID] = 10;
			_sizes[Op.ZC_EMOTICON] = 18;
			_sizes[Op.ZC_SHOW_EMOTICON] = 18;
			_sizes[Op.ZC_TREASUREMARK_BY_MAP] = 0;
			_sizes[Op.ZC_SHOW_MAP] = 0;
			_sizes[Op.CZ_FLEE_OBSTACLE] = 26;
			_sizes[Op.ZC_HOLD_MOVE_PATH] = 11;
			_sizes[Op.ZC_ENTER_HOOK] = 10;
			_sizes[Op.ZC_LEAVE_HOOK] = 10;
			_sizes[Op.ZC_MONSTER_PROPERTY] = 0;
			_sizes[Op.ZC_GROUND_EFFECT] = 50;
			_sizes[Op.ZC_FLY] = 18;
			_sizes[Op.ZC_FLY_MATH] = 22;
			_sizes[Op.ZC_FLY_HEIGHT] = 14;
			_sizes[Op.ZC_UPDATE_SHIELD] = 14;
			_sizes[Op.ZC_SHOW_MODEL] = 15;
			_sizes[Op.ZC_SKILL_RANGE_DBG] = 58;
			_sizes[Op.ZC_SKILL_RANGE_FAN] = 40;
			_sizes[Op.ZC_SKILL_RANGE_SQUARE] = 40;
			_sizes[Op.ZC_SKILL_RANGE_CIRCLE] = 28;
			_sizes[Op.ZC_SKILL_RANGE_DONUTS] = 32;
			_sizes[Op.ZC_TEAMID] = 11;
			_sizes[Op.ZC_PC] = 0;
			_sizes[Op.CZ_LOG] = 0;
			_sizes[Op.ZC_MOTIONBLUR] = 11;
			_sizes[Op.ZC_PLAY_FORCE] = 78;
			_sizes[Op.ZC_CAST_TARGET] = 14;
			_sizes[Op.ZC_START_INFO] = 0;
			_sizes[Op.ZC_JOB_EXP_UP] = 10;
			_sizes[Op.ZC_JOB_PTS] = 10;
			_sizes[Op.ZC_MON_STAMINA] = 22;
			_sizes[Op.CZ_CUSTOM_SCP] = 14;
			_sizes[Op.ZC_VIEW_FOCUS] = 24;
			_sizes[Op.ZC_HARDCODED_SKILL] = 26;
			_sizes[Op.CZ_HARDCODED_SKILL] = 34;
			_sizes[Op.ZC_FORCE_MOVE] = 30;
			_sizes[Op.ZC_HSKILL_CONTROL] = 22;
			_sizes[Op.ZC_CANCEL_DEADEVENT] = 10;
			_sizes[Op.ZC_ACTION_PKS] = 35;
			_sizes[Op.CZ_HARDCODED_ITEM] = 22;
			_sizes[Op.CZ_CANCEL_TRANSFORM_SKILL] = 10;
			_sizes[Op.CZ_BRIQUET] = 30;
			_sizes[Op.ZC_VIBRATE] = 30;
			_sizes[Op.ZC_COUNTER_MOVE] = 10;
			_sizes[Op.CZ_COUNTER_ATTACK] = 14;
			_sizes[Op.CZ_CLIENT_DIRECT] = 30;
			_sizes[Op.ZC_CLIENT_DIRECT] = 30;
			_sizes[Op.ZC_OWNER] = 14;
			_sizes[Op.ZC_GD_RANK] = 10;
			_sizes[Op.CZ_RUN_BGEVENT] = 74;
			_sizes[Op.ZC_ADD_SKILL_EFFECT] = 18;
			_sizes[Op.ZC_ITEM_DROPABLE] = 10;
			_sizes[Op.CZ_ITEM_DROP_TO_OBJECT] = 26;
			_sizes[Op.ZC_NORMAL] = 0;
			_sizes[Op.CZ_G_QUEST_CHECK] = 14;
			_sizes[Op.ZC_MOVE_PATH_MATH] = 30;
			_sizes[Op.CZ_MYPAGE_COMMENT_ADD] = 278;
			_sizes[Op.CZ_MYPAGE_COMMENT_DELETE] = 18;
			_sizes[Op.CZ_GUESTPAGE_COMMENT_ADD] = 278;
			_sizes[Op.CZ_GET_TARGET_MYPAGE] = 14;
			_sizes[Op.CZ_ON_MYPAGE_MODE] = 14;
			_sizes[Op.CZ_RESET_SOCIAL_MODE] = 10;
			_sizes[Op.CZ_GET_TARGET_GUESTPAGE] = 14;
			_sizes[Op.CZ_ADD_SELLMODE_ITEM] = 30;
			_sizes[Op.CZ_DELETE_SELLMODE_ITEM] = 18;
			_sizes[Op.CZ_ON_SELLITEM_MODE] = 14;
			_sizes[Op.ZC_MYPAGE_MAP] = 0;
			_sizes[Op.ZC_GUESTPAGE_MAP] = 0;
			_sizes[Op.ZC_ON_MYPAGE_MODE] = 0;
			_sizes[Op.ZC_RESET_SOCIAL_MODE] = 10;
			_sizes[Op.CZ_ON_ITEMBUY_MODE] = 0;
			_sizes[Op.ZC_ON_BUYITEM_MODE] = 0;
			_sizes[Op.ZC_SHOW_GROUND_ITEM_MARK] = 30;
			_sizes[Op.ZC_HELP_LIST] = 0;
			_sizes[Op.ZC_HELP_ADD] = 11;
			_sizes[Op.CZ_CLIENT_HIT_LIST] = 0;
			_sizes[Op.ZC_PC_ATKSTATE] = 11;
			_sizes[Op.ZC_SEND_PREMIUM_STATE] = 16;
			_sizes[Op.CZ_HELP_READ_TYPE] = 18;
			_sizes[Op.CZ_MOVE_PATH_END] = 10;
			_sizes[Op.ZC_COLL_DAMAGE] = 11;
			_sizes[Op.CZ_KEYBOARD_BEAT] = 10;
			_sizes[Op.CZ_MOVEHIT_SCP] = 22;
			_sizes[Op.ZC_SYNC_START] = 14;
			_sizes[Op.ZC_SYNC_END] = 14;
			_sizes[Op.ZC_SYNC_EXEC] = 10;
			_sizes[Op.ZC_SYNC_EXEC_BY_SKILL_TIME] = 18;
			_sizes[Op.CZ_STOP_TIMEACTION] = 11;
			_sizes[Op.CZ_REQ_DUMMYPC_INFO] = 18;
			_sizes[Op.CZ_VISIT_BARRACK] = 74;
			_sizes[Op.CZ_SPC_SKILL_POS] = 22;
			_sizes[Op.CZ_REQ_CHANGEJOB] = 14;
			_sizes[Op.CZ_CHANGE_HEAD] = 74;
			_sizes[Op.CZ_CREATE_ARROW_CRAFT] = 14;
			_sizes[Op.CZ_REQ_MINITEXT] = 266;
			_sizes[Op.ZC_PC_MOVE_STOP] = 35;
			_sizes[Op.CZ_STOP_ALLPC] = 10;
			_sizes[Op.CZ_COMPLETE_PRELOAD] = 14;
			_sizes[Op.CZ_MGAME_JOIN_CMD] = 46;
			_sizes[Op.CZ_ADD_HELP] = 14;
			_sizes[Op.ZC_ATTACH_TO_OBJ] = 49;
			_sizes[Op.ZC_DETACH_FROM_OBJ] = 14;
			_sizes[Op.ZC_RUN_FROM] = 14;
			_sizes[Op.ZC_LOOKAT_OBJ] = 14;
			_sizes[Op.CZ_SKILL_CELL_LIST] = 0;
			_sizes[Op.CZ_SKILL_TOOL_GROUND_POS] = 26;
			_sizes[Op.CZ_DIRECTION_PROCESS] = 18;
			_sizes[Op.CZ_DIRECTION_MOVE_STATE] = 0;
			_sizes[Op.ZC_TO_ALL_CLIENT] = 0;
			_sizes[Op.ZC_TO_CLIENT] = 0;
			_sizes[Op.CZ_REWARD_CMD] = 14;
			_sizes[Op.CZ_PROPERTY_COMPARE] = 16;
			_sizes[Op.ZC_PROPERTY_COMPARE] = 0;
			_sizes[Op.ZC_PROPERTY_COMPARE_FOR_ACT] = 0;
			_sizes[Op.ZC_FACTION] = 14;
			_sizes[Op.ZC_SEND_CASH_VALUE] = 0;
			_sizes[Op.ZC_BEGIN_KILL_LOG] = 6;
			_sizes[Op.ZC_END_KILL_LOG] = 6;
			_sizes[Op.ZC_CLEAR_KILL_LOG] = 6;
			_sizes[Op.CZ_NPC_AUCTION_CMD] = 30;
			_sizes[Op.ZC_DIRECTION_APC] = 26;
			_sizes[Op.ZC_BGMODEL_ANIM_INFO] = 15;
			_sizes[Op.ZC_ATTACH_BY_KNOCKBACK] = 38;
			_sizes[Op.CZ_OBJECT_MOVE] = 30;
			_sizes[Op.CZ_CONTROL_OBJECT_ROTATE] = 22;
			_sizes[Op.CZ_SUMMON_COMMAND] = 18;
			_sizes[Op.CZ_VEHICLE_RIDE] = 15;
			_sizes[Op.CZ_REQ_WIKI_CATEGORY_RANK_PAGE_INFO] = 78;
			_sizes[Op.CZ_REQ_ACHIEVE_RANK_PAGE_INFO] = 78;
			_sizes[Op.CZ_REQ_MONSTER_RANK_INFO] = 74;
			_sizes[Op.ZC_SPC_TRIGGER_EXEC] = 30;
			_sizes[Op.CZ_REQ_MGAME_VIEW] = 18;
			_sizes[Op.CZ_REQ_MGAME_CHAT] = 0;
			_sizes[Op.CZ_TOURNAMENT_GIFT] = 18;
			_sizes[Op.CZ_PARTY_INVITE_ACCEPT] = 79;
			_sizes[Op.CZ_PARTY_INVITE_CANCEL] = 83;
			_sizes[Op.CZ_PARTY_PROP_CHANGE] = 145;
			_sizes[Op.CZ_REQ_MARKET_REGISTER] = 40;
			_sizes[Op.CZ_REQ_MARKET_MINMAX_INFO] = 18;
			_sizes[Op.CZ_REQ_MARKET_BUY] = 0;
			_sizes[Op.CZ_REQ_MARKET_LIST] = 162;
			_sizes[Op.CZ_REQ_MY_SELL_LIST] = 14;
			_sizes[Op.CZ_REQ_CABINET_LIST] = 10;
			_sizes[Op.CZ_REQ_GET_CABINET_ITEM] = 26;
			_sizes[Op.CZ_REQ_CANCEL_MARKET_ITEM] = 18;
			_sizes[Op.CZ_INV_ITEM_LOCK] = 19;
			_sizes[Op.CZ_OBJ_RECORD_POS] = 0;
			_sizes[Op.CZ_FORMATION_CMD] = 32;
			_sizes[Op.CZ_REGISTER_AUTOSELLER] = 0;
			_sizes[Op.CZ_OPEN_AUTOSELLER] = 34;
			_sizes[Op.CZ_BUY_AUTOSELLER_ITEMS] = 0;
			_sizes[Op.CZ_SELL_MY_AUTOSELLER_ITEMS] = 0;
			_sizes[Op.CZ_PUZZLE_CRAFT] = 0;
			_sizes[Op.CZ_PET_EQUIP] = 30;
			_sizes[Op.ZC_FOUND_PARTY_LIST] = 0;
			_sizes[Op.ZC_NEAR_PARTY_LIST] = 0;
			_sizes[Op.ZC_RECOMMEND_PARTY_INFO] = 0;
			_sizes[Op.CZ_REQUEST_SOME_PARTY] = 90;
			_sizes[Op.CZ_REFRESH_MEMBERRECOMMEND_LIST] = 10;
			_sizes[Op.ZC_TO_SOMEWHERE_CLIENT] = 0;
			_sizes[Op.CZ_REVEAL_NPC_STATE] = 14;
			_sizes[Op.CZ_CHANGE_CHANNEL] = 12;
			_sizes[Op.CZ_REQ_CHANNEL_TRAFFICS] = 12;
			_sizes[Op.CZ_BUY_PROPERTYSHOP_ITEM] = 0;
			_sizes[Op.CZ_SKILL_USE_HEIGHT] = 14;
			_sizes[Op.CZ_ACCEPT_PARTY_QUEST] = 20;
			_sizes[Op.CZ_ACCEPT_GUILD_EVENT] = 20;
			_sizes[Op.CZ_ACCEPT_GUILD_EVENT_RAID] = 20;
			_sizes[Op.CZ_ACCEPT_PARTY_EVENT] = 20;
			_sizes[Op.CZ_DELETE_PARTY_EVENT] = 20;
			_sizes[Op.CZ_PING] = 10;
			_sizes[Op.ZC_PING] = 10;
			_sizes[Op.ZC_XIGNCODE_BUFFER] = 524;
			_sizes[Op.CZ_XIGNCODE_BUFFER] = 524;
			_sizes[Op.CZ_SYSTEM_LOG_SAVE_TO_MONGODB] = 280;
			_sizes[Op.CZ_CHANGE_TITLE] = 74;
			_sizes[Op.CZ_PC_COMMENT_CHANGE] = 0;
			_sizes[Op.CZ_AUTTOSELLER_BUYER_CLOSE] = 18;
			_sizes[Op.CZ_REQ_ITEM_LIST] = 11;
			_sizes[Op.CZ_HIT_MISSILE] = 14;
			_sizes[Op.CZ_I_NEED_PARTY] = 23;
			_sizes[Op.CZ_PARTY_JOIN_BY_LINK] = 19;
			_sizes[Op.ZC_RECOMMEND_PARTYMEMBER_INFO] = 0;
			_sizes[Op.CZ_PVP_ZONE_CMD] = 26;
			_sizes[Op.CZ_PVP_CHAT] = 0;
			_sizes[Op.CZ_CARDBATTLE_CMD] = 26;
			_sizes[Op.CZ_REQ_UPDATE_CONTENTS_SESSION] = 10;
			_sizes[Op.CZ_REQ_FRIENDLY_FIGHT] = 15;
			_sizes[Op.CZ_HARDSKILL_POS_LIST] = 0;
			_sizes[Op.CZ_CART_POSITION] = 26;
			_sizes[Op.CZ_REQ_RIDE_CART] = 18;
			_sizes[Op.CZ_DUMMYPC_SKILL_POS] = 26;
			_sizes[Op.CZ_NGS] = 0;
			_sizes[Op.CZ_PARTY_MEMBER_SKILL_USE] = 0;
			_sizes[Op.CZ_PARTY_MEMBER_SKILL_ACCEPT] = 22;
			_sizes[Op.CZ_SYSTEM_LOG_TO_SERVER] = 1099;
			_sizes[Op.CZ_CHECK_PING] = 10;
			_sizes[Op.CZ_CANCEL_INDUN_MATCHING] = 10;
			_sizes[Op.CZ_REQ_GM_ORDER] = 202;
			_sizes[Op.CZ_REPORT_AUTOBOT] = 74;
			_sizes[Op.CZ_PARTY_INVENTORY_LOAD] = 11;
			_sizes[Op.CZ_REQ_MOVE_PARTYINV_TO_ACCOUNT] = 31;
			_sizes[Op.CZ_REQ_CancelGachaCube] = 10;
			_sizes[Op.CZ_WAREHOUSE_TAKE_LIST] = 0;
			_sizes[Op.CZ_PVP_COMMAND] = 22;

			foreach (var field in typeof(Op).GetFields(BindingFlags.Public | BindingFlags.Static))
				_names[(int)field.GetValue(null)] = field.Name;
		}

		public static int GetSize(int op)
		{
			int size;
			if (!_sizes.TryGetValue(op, out size))
				return -1;
			return size;
		}

		public static string GetName(int op)
		{
			string name;
			if (!_names.TryGetValue(op, out name))
				return "?";
			return name;
		}
	}
}
