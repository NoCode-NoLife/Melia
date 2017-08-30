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
	/// 
	/// i11627 (2016-04-26)
	/// - Size change:
	///   - ZC_EXCHANGE_START: 71 -> 72
	/// 
	/// i11845 (2016-05-24)
	/// - New:
	///   - CZ_CHANGE_GUILD_NEUTRALITY
	///   - CZ_REQ_OPEN_INGAMESHOP_UI
	///   - CZ_REQ_BUY_INGAMESHOP_ITEM
	/// - Size changes:
	///   - CZ_DYNAMIC_CASTING_START: 24 -> 25
	///   - CZ_DYNAMIC_CASTING_END: 19 -> 20
	/// 
	/// i11961 (2016-06-07)
	/// - New:
	///   - CB_GEMSCOOL_PCINFO
	/// 
	/// i12809 (2016-07-29)
	/// - New:
	///   - CZ_FIXED_NOTICE_SHOW
	/// - Changes:
	///   - ZC_TREASUREMARK_LIST_MAP: 0xD0 -> 0xD3
	///   - CZ_REQ_OPEN_INGAMESHOP_UI: 0xE22 -> 0xE20
	///   - CZ_REQ_BUY_INGAMESHOP_ITEM: 0xE23 -> 0xE21
	///   - CZ_DUMMYPC_SKILL_POS: 0xE20 -> 0xE22
	///   - CZ_NGS: 0xE21 -> 0xE23
	///   - CZ_REQ_CancelGachaCube: 0xE2D -> 0xE2E
	///   - CZ_WAREHOUSE_TAKE_LIST: 0xE2E -> 0xE2F
	///   - CZ_PVP_COMMAND: 0xE2F -> 0xE2D
	/// - Size changes:
	///   - CB_LOGIN: 66 -> 202
	///   - CB_LOGIN_BY_PASSPORT: 1068 -> 1076
	///   - BC_LOGINOK: 121 -> 129
	///   - BC_COMMANDER_CREATE: 334 -> 342
	///   - CB_NGS: 10254 -> 0
	///   - CZ_CONNECT: 1200 -> 1208
	///   - ZC_ENTER_PC: 341 -> 353
	///   - ZC_ENTER_DUMMYPC: 308 -> 316
	///   - ZC_UPDATED_DUMMYPC: 266 -> 274
	///   - ZC_UPDATED_PCAPPEARANCE: 266 -> 274
	///   - CZ_S_OBJ_VALUE_C: 24 -> 26
	///   - ZC_PC_PROP_UPDATE: 9 -> 11
	///   - CZ_PARTY_INVITE_ACCEPT: 79 -> 87
	///   - CZ_PARTY_INVITE_CANCEL: 83 -> 91
	///   - CZ_PARTY_PROP_CHANGE: 145 -> 147
	/// 
	/// i133604 (2016-08-?)
	/// - Notes:
	///   - A few ops were removed in this update, which caused several
	///     others to change.
	/// - Removed:
	///   - CB_GEMSCOOL_PCINFO
	///   - CZ_CHANGE_GUILD_NEUTRALITY
	///   - CZ_REQ_OPEN_INGAMESHOP_UI
	///   - CZ_REQ_BUY_INGAMESHOP_ITEM
	///   - CZ_REPORT_AUTOBOT
	///   - CZ_PVP_COMMAND
	///   - CZ_FIXED_NOTICE_SHOW
	/// - Size changes:
	///   - CB_LOGIN: 202 -> 66
	///   - CB_LOGIN_BY_PASSPORT: 1076 -> 1068
	///   - BC_LOGINOK: 129 -> 121
	///   - BC_COMMANDER_CREATE: 342 -> 334
	///   - CB_NGS: 0 -> 10254
	///   - CZ_CONNECT: 1208 -> 1200
	///   - ZC_ENTER_PC: 353 -> 341
	///   - ZC_ENTER_DUMMYPC: 316 -> 308
	///   - ZC_UPDATED_DUMMYPC: 274 -> 266
	///   - ZC_UPDATED_PCAPPEARANCE: 274 -> 266
	///   - ZC_EXCHANGE_START: 72 -> 71
	///   - CZ_S_OBJ_VALUE_C: 26 -> 27
	///   - CZ_DYNAMIC_CASTING_START: 25 -> 24
	///   - CZ_DYNAMIC_CASTING_END: 20 -> 19
	///   - ZC_PC_PROP_UPDATE: 11 -> 9
	///   - CZ_PARTY_INVITE_ACCEPT: 87 -> 79
	///   - CZ_PARTY_INVITE_CANCEL: 91 -> 83
	///   - CZ_PARTY_PROP_CHANGE: 147 -> 145
	/// 
	/// i135297 (2016-09-?)
	/// - Notes:
	///   - A few ops were (re)moved or added, which caused several others
	///     to change.
	/// - New:
	///   - BC_COMMANDER_CREATE_SLOTID
	///   - CB_REQ_CHANNEL_TRAFFIC
	///   - CB_CHANGE_BARRACK_LAYER
	///   - CB_SELECT_BARRACK_LAYER
	///   - CB_GEMSCOOL_PCINFO
	///   - CS_REQUEST_ALL_SEASON_TOP_PVP_RANKING
	///   - CZ_CHANGE_GUILD_NEUTRALITY
	///   - CZ_REQ_OPEN_INGAMESHOP_UI
	///   - CZ_REQ_REMAIN_NEXONCASH
	///   - CZ_REQ_BUY_INGAMESHOP_ITEM
	///   - CZ_REQ_PICKUP_CASHITEM
	///   - CZ_REQ_REFUND_CASHITEM
	///   - CZ_REQ_GET_CAHS_INVEN_ITEMLIST
	///   - CZ_REPORT_AUTOBOT
	///   - CZ_RUN_GAMEEXIT_TIMER
	///   - CZ_FIXED_NOTICE_SHOW
	///   - CZ_REQUEST_CHANGE_NAME
	///   - ZC_HOLD_EXP_BOOK_TIME
	///   - CZ_HOLD_EXP_BOOK_TIME
	/// - Removed:
	///   - CZ_ACCEPT_GUILD_EVENT
	///   - CZ_ACCEPT_GUILD_EVENT_RAID
	/// - Size changes:
	///   - CB_LOGIN: 66 -> 206
	///   - CB_LOGIN_BY_PASSPORT: 1068 -> 1080
	///   - BC_LOGINOK: 121 -> 129
	///   - BC_COMMANDER_CREATE: 334 -> 342
	///   - CB_NGS: 10254 -> 0
	///   - CZ_CONNECT: 1200 -> 1208
	///   - ZC_ENTER_PC: 341 -> 353
	///   - ZC_ENTER_DUMMYPC: 308 -> 316
	///   - ZC_UPDATED_DUMMYPC: 266 -> 274
	///   - ZC_UPDATED_PCAPPEARANCE: 266 -> 274
	///   - CZ_RESURRECT: 11 -> 19
	///   - ZC_EXCHANGE_START: 71 -> 72
	///   - ZC_COOLDOWN_CHANGED: 22 -> 26
	///   - ZC_OVERHEAT_CHANGED: 26 -> 30
	///   - CZ_DYNAMIC_CASTING_START: 24 -> 25
	///   - CZ_DYNAMIC_CASTING_END: 19 -> 20
	///   - ZC_FLY_MATH: 22 -> 25
	///   - ZC_JOB_EXP_UP: 10 -> 18
	///   - ZC_JOB_PTS: 10 -> 18
	///   - CZ_PARTY_INVITE_ACCEPT: 79 -> 87
	///   - CZ_PARTY_INVITE_CANCEL: 83 -> 91
	///   - CZ_PARTY_INVITE_CANCEL: 83 -> 91
	/// </remarks>
	public static class Op
	{
		public const int CB_LOGIN = 0x03; // Size: 206
		public const int CB_LOGIN_BY_PASSPORT = 0x04; // Size: 1131
		public const int CB_LOGOUT = 0x05; // Size: 10
		public const int CB_START_BARRACK = 0x06; // Size: 11
		public const int CB_COMMANDER_CREATE = 0x07; // Size: 93
		public const int BC_COMMANDER_CREATE_SLOTID = 0x08; // Size: 7
		public const int CB_COMMANDER_DESTROY = 0x09; // Size: 18
		public const int CB_CHECK_CLIENT_INTEGRITY = 0x0A; // Size: 74
		public const int CB_CLIENT_INTEGRITY_FAIL = 0x0B; // Size: 1035
		public const int CB_START_GAME = 0x0C; // Size: 13
		public const int CB_BARRACKNAME_CHANGE = 0x0D; // Size: 74
		public const int CB_COMMANDER_MOVE = 0x0E; // Size: 31
		public const int CB_ECHO = 0x0F; // Size: 30
		public const int BC_LOGINOK = 0x10; // Size: 129
		public const int BC_LOGIN_PACKET_RECEIVED = 0x11; // Size: 6
		public const int BC_LOGOUTOK = 0x12; // Size: 6
		public const int BC_COMMANDER_LIST = 0x13; // Size: 0
		public const int BC_COMMANDER_CREATE = 0x14; // Size: 342
		public const int BC_COMMANDER_DESTROY = 0x15; // Size: 7
		public const int BC_START_GAMEOK = 0x16; // Size: 33
		public const int BC_SINGLE_INFO = 0x17; // Size: 325
		public const int BC_MESSAGE = 0x18; // Size: 0
		public const int BC_ECHO = 0x19; // Size: 26
		public const int BC_MYPAGE_MAP = 0x1A; // Size: 0
		public const int BC_BARRACKNAME_CHANGE = 0x1B; // Size: 75
		public const int CB_IES_MODIFY_INFO = 0x32; // Size: 0
		public const int BC_IES_MODIFY_INFO = 0x33; // Size: 0
		public const int BC_IES_MODIFY_LIST = 0x34; // Size: 0
		public const int CB_IES_REVISION_DELETE = 0x35; // Size: 0
		public const int BC_IES_REVISION_DELETE = 0x36; // Size: 0
		public const int CB_SCREENSHOT_HASH = 0x37; // Size: 42
		public const int CB_REQ_CHANNEL_TRAFFIC = 0x38; // Size: 14
		public const int CB_VISIT = 0x39; // Size: 74
		public const int CB_BUY_THEMA = 0x3A; // Size: 22
		public const int BC_ACCOUNT_PROP = 0x3B; // Size: 0
		public const int CB_CURRENT_BARRACK = 0x3C; // Size: 39
		public const int BC_NORMAL = 0x3D; // Size: 0
		public const int CB_POSE = 0x3E; // Size: 15
		public const int CB_PLACE_CMD = 0x3F; // Size: 46
		public const int CB_CHAT = 0x40; // Size: 0
		public const int BC_CHAT = 0x41; // Size: 0
		public const int CB_ECHO_NORMAL = 0x42; // Size: 0
		public const int CB_REQ_SLOT_PRICE = 0x43; // Size: 10
		public const int BC_REQ_SLOT_PRICE = 0x44; // Size: 10
		public const int CB_CHANGE_BARRACK_LAYER = 0x45; // Size: 22
		public const int CB_SELECT_BARRACK_LAYER = 0x46; // Size: 14
		public const int CB_JUMP = 0x47; // Size: 19
		public const int BC_JUMP = 0x48; // Size: 19
		public const int BC_SERVER_ENTRY = 0x49; // Size: 18
		public const int CB_PET_PC = 0x4A; // Size: 26
		public const int CB_PET_COMMAND = 0x4B; // Size: 27
		public const int CB_REQ_CHANGE_POSTBOX_STATE = 0x4C; // Size: 23
		public const int CB_REQ_GET_POSTBOX_ITEM = 0x4D; // Size: 1051
		public const int CB_REQ_POSTBOX_PAGE = 0x4E; // Size: 14
		public const int BC_WAIT_QUEUE_ORDER = 0x4F; // Size: 10
		public const int CB_CANCEL_SERVER_WAIT_QUEUE = 0x50; // Size: 10
		public const int CB_NGS = 0x51; // Size: 0
		public const int CB_GEMSCOOL_PCINFO = 0x52; // Size: 1290
		public const int CB_NOT_AUTHORIZED_ADDON_LIST = 0x53; // Size: 1039
		public const int ZC_TREASUREMARK_LIST_MAP = 0x0D7; // Size: 0
		public const int CS_LOGIN = 0x0B55; // Size: 64
		public const int SC_NORMAL = 0x0B56; // Size: 0
		public const int SC_FROM_INTEGRATE = 0x0B57; // Size: 0
		public const int CS_REGISTER_SNS_ID = 0x0B58; // Size: 16
		public const int CS_REQ_SNS_PC_INFO = 0x0B59; // Size: 0
		public const int CS_REQ_ADD_FRIEND = 0x0B5A; // Size: 70
		public const int CS_REQ_BLOCK_FRIEND = 0x0B5B; // Size: 70
		public const int CS_FRIEND_CMD = 0x0B5C; // Size: 24
		public const int CS_FRIEND_SET_ADDINFO = 0x0B5D; // Size: 160
		public const int CS_CHAT = 0x0B5E; // Size: 0
		public const int CS_GROUP_CHAT_INVITE = 0x0B5F; // Size: 110
		public const int CS_GROUP_CHAT_INVITE_BY_TAG = 0x0B60; // Size: 22
		public const int CS_ALLOW_GROUP_CHAT_TAG_INVITE = 0x0B61; // Size: 46
		public const int CS_REFRESH_GROUP_CHAT = 0x0B62; // Size: 6
		public const int CS_CREATE_GROUP_CHAT = 0x0B63; // Size: 6
		public const int CS_REQ_CHAT_HISTORY = 0x0B64; // Size: 22
		public const int CS_REQ_OUT_ROOM = 0x0B65; // Size: 14
		public const int CS_REQ_RELATED_PC_SESSION = 0x0B66; // Size: 16
		public const int CS_REDIS_SKILLPOINT = 0x0B67; // Size: 22
		public const int CS_PARTY_CLIENT_INFO_SEND = 0x0B68; // Size: 0
		public const int CS_NORMAL_GAME_START = 0x0B69; // Size: 6
		public const int CS_REQUEST_PVP_RANKING = 0x0B6A; // Size: 88
		public const int CS_REQUEST_ALL_SEASON_TOP_PVP_RANKING = 0x0B6B; // Size: 80
		public const int CS_INVITE_PARTY_PVP = 0x0B6C; // Size: 10
		public const int CS_ACCEPT_PARTY_PVP = 0x0B6D; // Size: 19
		public const int CS_LIKE_IT = 0x0B6E; // Size: 88
		public const int CS_UNLIKE_IT = 0x0B6F; // Size: 24
		public const int CS_LIKE_IT_CONFIRM = 0x0B70; // Size: 16
		public const int CS_ADD_RELATION_SCORE = 0x0B71; // Size: 88
		public const int CS_GET_LIKE_COUNT = 0x0B72; // Size: 16
		public const int CZ_CONNECT = 0x0BB9; // Size: 1208
		public const int ZC_CONNECT_OK = 0x0BBA; // Size: 0
		public const int ZC_MOVE_ZONE = 0x0BBB; // Size: 7
		public const int CZ_MOVE_ZONE_OK = 0x0BBC; // Size: 10
		public const int ZC_CONNECT_FAILED = 0x0BBD; // Size: 0
		public const int CZ_GAME_READY = 0x0BBE; // Size: 10
		public const int ZC_MOVE_ZONE_OK = 0x0BBF; // Size: 57
		public const int CZ_LOGOUT = 0x0BC0; // Size: 11
		public const int CZ_MOVE_BARRACK = 0x0BC1; // Size: 11
		public const int ZC_MOVE_BARRACK = 0x0BC2; // Size: 6
		public const int ZC_LOGOUT_OK = 0x0BC3; // Size: 6
		public const int ZC_MESSAGE = 0x0BC4; // Size: 0
		public const int ZC_RESET_VIEW = 0x0BC5; // Size: 6
		public const int ZC_START_GAME = 0x0BC6; // Size: 26
		public const int ZC_QUIET = 0x0BC7; // Size: 7
		public const int ZC_ENTER_PC = 0x0C1D; // Size: 353
		public const int ZC_ENTER_MONSTER = 0x0C1E; // Size: 0
		public const int ZC_ENTER_DUMMYPC = 0x0C1F; // Size: 316
		public const int ZC_UPDATED_DUMMYPC = 0x0C20; // Size: 274
		public const int ZC_ENTER_ITEM = 0x0C21; // Size: 103
		public const int ZC_LEAVE = 0x0C22; // Size: 12
		public const int ZC_MOVE_PATH = 0x0C23; // Size: 42
		public const int ZC_MOVE_POS = 0x0C24; // Size: 43
		public const int ZC_MOVE_BEZIER = 0x0C25; // Size: 75
		public const int ZC_MOVE_DIR = 0x0C26; // Size: 40
		public const int ZC_EXPECTED_STOPPOS = 0x0C27; // Size: 35
		public const int ZC_MSPD = 0x0C28; // Size: 14
		public const int ZC_MOVE_SPEED = 0x0C29; // Size: 19
		public const int ZC_MOVE_STOP = 0x0C2A; // Size: 23
		public const int ZC_REST_SIT = 0x0C2B; // Size: 12
		public const int ZC_JUMP = 0x0C2C; // Size: 19
		public const int ZC_JUMP_DIR = 0x0C2D; // Size: 34
		public const int ZC_ORDER_SKILL_JUMP = 0x0C2E; // Size: 10
		public const int ZC_SKILL_JUMP = 0x0C2F; // Size: 38
		public const int ZC_SET_POS = 0x0C30; // Size: 23
		public const int ZC_FILE_MOVE = 0x0C31; // Size: 46
		public const int CZ_LEAVE_TO_DUNGEON = 0x0C32; // Size: 10
		public const int ZC_UPDATED_PCAPPEARANCE = 0x0C33; // Size: 274
		public const int ZC_UPDATED_MONSTERAPPEARANCE = 0x0C34; // Size: 0
		public const int ZC_CHAT = 0x0C35; // Size: 0
		public const int ZC_CHAT_WITH_TEXTCODE = 0x0C36; // Size: 14
		public const int ZC_STANCE_CHANGE = 0x0C37; // Size: 14
		public const int ZC_ADD_HP = 0x0C38; // Size: 22
		public const int ZC_SKILL_CAST_CANCEL = 0x0C39; // Size: 10
		public const int ZC_SKILL_CAST = 0x0C3A; // Size: 38
		public const int ZC_SKILL_READY = 0x0C3B; // Size: 50
		public const int ZC_SKILL_DISABLE = 0x0C3C; // Size: 15
		public const int ZC_SKILL_USE_CANCEL = 0x0C3D; // Size: 10
		public const int ZC_SKILL_MELEE_TARGET = 0x0C3E; // Size: 0
		public const int ZC_SKILL_MELEE_GROUND = 0x0C3F; // Size: 0
		public const int ZC_SKILL_FORCE_TARGET = 0x0C40; // Size: 0
		public const int ZC_SKILL_FORCE_GROUND = 0x0C41; // Size: 0
		public const int ZC_SKILL_HIT_INFO = 0x0C42; // Size: 0
		public const int ZC_BUFF_LIST = 0x0C43; // Size: 0
		public const int ZC_BUFF_ADD = 0x0C44; // Size: 0
		public const int ZC_BUFF_UPDATE = 0x0C45; // Size: 0
		public const int ZC_BUFF_REMOVE = 0x0C46; // Size: 20
		public const int ZC_BUFF_CLEAR = 0x0C47; // Size: 11
		public const int CZ_BUFF_REMOVE = 0x0C48; // Size: 14
		public const int CZ_INTE_WARP = 0x0C49; // Size: 14
		public const int ZC_ROTATE = 0x0C4A; // Size: 20
		public const int ZC_ROTATE_RESERVED = 0x0C4B; // Size: 18
		public const int ZC_HEAD_ROTATE = 0x0C4C; // Size: 18
		public const int ZC_TARGET_ROTATE = 0x0C4D; // Size: 18
		public const int ZC_QUICK_ROTATE = 0x0C4E; // Size: 18
		public const int ZC_POSE = 0x0C4F; // Size: 34
		public const int ZC_DEAD = 0x0C50; // Size: 0
		public const int ZC_RESURRECT = 0x0C51; // Size: 18
		public const int ZC_CHANGE_RELATION = 0x0C52; // Size: 11
		public const int ZC_RESURRECT_DIALOG = 0x0C53; // Size: 7
		public const int ZC_HIT_INFO = 0x0C54; // Size: 64
		public const int ZC_HEAL_INFO = 0x0C55; // Size: 30
		public const int ZC_CAUTION_DAMAGE_INFO = 0x0C57; // Size: 15
		public const int ZC_CAUTION_DAMAGE_RELEASE = 0x0C58; // Size: 10
		public const int ZC_KNOCKBACK_INFO = 0x0C59; // Size: 70
		public const int ZC_KNOCKDOWN_INFO = 0x0C5A; // Size: 71
		public const int CZ_RESURRECT = 0x0C5B; // Size: 19
		public const int ZC_RESURRECT_SAVE_POINT_ACK = 0x0C5C; // Size: 7
		public const int ZC_RESURRECT_HERE_ACK = 0x0C5D; // Size: 7
		public const int CZ_CLICK_TRIGGER = 0x0C5E; // Size: 15
		public const int CZ_KEYBOARD_MOVE = 0x0C5F; // Size: 41
		public const int CZ_EXPECTED_STOP_POS = 0x0C60; // Size: 31
		public const int CZ_JUMP = 0x0C61; // Size: 11
		public const int CZ_DASHRUN = 0x0C62; // Size: 12
		public const int CZ_SKILL_JUMP_REQ = 0x0C63; // Size: 30
		public const int CZ_MOVE_PATH = 0x0C64; // Size: 27
		public const int CZ_MOVE_STOP = 0x0C65; // Size: 35
		public const int CZ_REST_SIT = 0x0C66; // Size: 10
		public const int CZ_REQ_CHAR_SLOT = 0x0C67; // Size: 11
		public const int CZ_ON_AIR = 0x0C68; // Size: 10
		public const int CZ_ON_GROUND = 0x0C69; // Size: 10
		public const int CZ_MOVEMENT_INFO = 0x0C6A; // Size: 23
		public const int CZ_SKILL_TARGET = 0x0C6B; // Size: 19
		public const int CZ_SKILL_TARGET_ANI = 0x0C6C; // Size: 23
		public const int CZ_SKILL_GROUND = 0x0C6D; // Size: 61
		public const int CZ_SKILL_SELF = 0x0C6E; // Size: 35
		public const int CZ_SKILL_CANCEL = 0x0C6F; // Size: 12
		public const int CZ_HOLD = 0x0C70; // Size: 11
		public const int CZ_ROTATE = 0x0C71; // Size: 18
		public const int CZ_HEAD_ROTATE = 0x0C72; // Size: 18
		public const int CZ_TARGET_ROTATE = 0x0C73; // Size: 18
		public const int CZ_POSE = 0x0C74; // Size: 34
		public const int CZ_CHAT = 0x0C75; // Size: 0
		public const int CZ_SELF_CHAT = 0x0C76; // Size: 0
		public const int CZ_CHAT_LOG = 0x0C77; // Size: 0
		public const int CZ_SHOUT = 0x0C78; // Size: 0
		public const int CZ_ITEM_DROP = 0x0C79; // Size: 22
		public const int CZ_ITEM_DELETE = 0x0C7A; // Size: 0
		public const int CZ_ITEM_USE = 0x0C7B; // Size: 22
		public const int CZ_ITEM_USE_TO_ITEM = 0x0C7C; // Size: 30
		public const int CZ_ITEM_USE_TO_GROUND = 0x0C7D; // Size: 30
		public const int CZ_ITEM_BUY = 0x0C7E; // Size: 0
		public const int CZ_ITEM_SELL = 0x0C7F; // Size: 0
		public const int CZ_ITEM_EQUIP = 0x0C80; // Size: 19
		public const int CZ_ITEM_UNEQUIP = 0x0C81; // Size: 11
		public const int CZ_REQ_DELETE_EXPIRED_ITEMS = 0x0C82; // Size: 18
		public const int ZC_CHECK_INVINDEX = 0x0C83; // Size: 30
		public const int CZ_PREMIUM_ENCHANTCHIP = 0x0C84; // Size: 26
		public const int CZ_PREMIUM_GACHACUBE = 0x0C85; // Size: 10
		public const int ZC_ITEM_INVENTORY_LIST = 0x0C86; // Size: 0
		public const int ZC_ITEM_INVENTORY_DIVISION_LIST = 0x0C87; // Size: 0
		public const int ZC_ITEM_INVENTORY_INDEX_LIST = 0x0C88; // Size: 0
		public const int ZC_ITEM_EQUIP_LIST = 0x0C89; // Size: 0
		public const int ZC_ITEM_ADD = 0x0C8A; // Size: 0
		public const int ZC_ITEM_REMOVE = 0x0C8B; // Size: 20
		public const int ZC_ITEM_USE = 0x0C8C; // Size: 14
		public const int ZC_ITEM_USE_TO_GROUND = 0x0C8D; // Size: 22
		public const int CZ_ITEM_ADD_WIKI = 0x0C8E; // Size: 18
		public const int ZC_QUICK_SLOT_LIST = 0x0C8F; // Size: 0
		public const int ZC_SKILL_LIST = 0x0C90; // Size: 0
		public const int ZC_SKILL_ADD = 0x0C91; // Size: 0
		public const int ZC_ABILITY_LIST = 0x0C92; // Size: 0
		public const int CZ_REQ_OPEN_ITEM_DUNGEON = 0x0C93; // Size: 19
		public const int CZ_ANSWER_OPEN_ITEM_DUNGEON = 0x0C94; // Size: 19
		public const int CZ_SEND_ITEM_PROP_TO_ALCHMIST = 0x0C95; // Size: 28
		public const int CZ_EXCUTE_ITEM_DUNGEON = 0x0C96; // Size: 34
		public const int ZC_RECIVE_ITEM_PROP_TO_TARGET = 0x0C97; // Size: 0
		public const int CZ_DISPEL_DEBUFF_TOGGLE = 0x0C98; // Size: 14
		public const int CZ_JUNGTAN_TOGGLE = 0x0C99; // Size: 24
		public const int ZC_EXP_UP = 0x0C9A; // Size: 14
		public const int ZC_EXP_UP_BY_MONSTER = 0x0C9B; // Size: 18
		public const int ZC_PC_LEVELUP = 0x0C9C; // Size: 14
		public const int ZC_PC_STAT_AVG = 0x0C9D; // Size: 30
		public const int ZC_MAX_EXP_CHANGED = 0x0C9E; // Size: 22
		public const int ZC_TEXT = 0x0C9F; // Size: 0
		public const int ZC_UPDATE_SP = 0x0CA0; // Size: 15
		public const int ZC_RESTORATION = 0x0CA1; // Size: 12
		public const int ZC_UPDATE_MHP = 0x0CA2; // Size: 14
		public const int CZ_DIALOG_ACK = 0x0CA3; // Size: 14
		public const int CZ_DIALOG_SELECT = 0x0CA4; // Size: 11
		public const int CZ_DIALOG_STRINGINPUT = 0x0CA5; // Size: 138
		public const int ZC_DIALOG_OK = 0x0CA6; // Size: 0
		public const int ZC_DIALOG_NEXT = 0x0CA7; // Size: 0
		public const int ZC_DIALOG_SELECT = 0x0CA8; // Size: 0
		public const int ZC_DIALOG_ITEM_SELECT = 0x0CA9; // Size: 0
		public const int ZC_DIALOG_CLOSE = 0x0CAA; // Size: 6
		public const int ZC_DIALOG_TRADE = 0x0CAB; // Size: 39
		public const int ZC_DIALOG_COMMON_TRADE = 0x0CAC; // Size: 39
		public const int ZC_DIALOG_NUMBERRANGE = 0x0CAD; // Size: 0
		public const int ZC_DIALOG_STRINGINPUT = 0x0CAE; // Size: 0
		public const int ZC_ADDON_MSG = 0x0CAF; // Size: 0
		public const int CZ_UI_EVENT = 0x0CB0; // Size: 0
		public const int ZC_PLAY_SOUND = 0x0CB1; // Size: 15
		public const int ZC_STOP_SOUND = 0x0CB2; // Size: 14
		public const int ZC_PLAY_MUSICQUEUE = 0x0CB3; // Size: 14
		public const int ZC_STOP_MUSICQUEUE = 0x0CB4; // Size: 14
		public const int ZC_PLAY_ANI = 0x0CB5; // Size: 24
		public const int ZC_CHANGE_ANI = 0x0CB6; // Size: 44
		public const int CZ_MOVE_CAMP = 0x0CB7; // Size: 18
		public const int CZ_CAMPINFO = 0x0CB8; // Size: 18
		public const int ZC_CAMPINFO = 0x0CB9; // Size: 18
		public const int ZC_FIX_ANIM = 0x0CBA; // Size: 14
		public const int CZ_TARGET_JOB_INFO = 0x0CBB; // Size: 18
		public const int ZC_TARGET_JOB_INFO = 0x0CBC; // Size: 14
		public const int ZC_MOVE_ANIM = 0x0CBD; // Size: 12
		public const int ZC_STD_ANIM = 0x0CBE; // Size: 11
		public const int ZC_PLAY_ALARMSOUND = 0x0CC0; // Size: 83
		public const int ZC_STOP_ALARMSOUND = 0x0CC1; // Size: 10
		public const int ZC_PLAY_EXP_TEXT = 0x0CC2; // Size: 14
		public const int ZC_PLAY_NAVI_EFFECT = 0x0CC3; // Size: 150
		public const int ZC_UPDATE_ALL_STATUS = 0x0CC4; // Size: 26
		public const int ZC_OBJECT_PROPERTY = 0x0CC5; // Size: 0
		public const int ZC_DUMP_PROPERTY = 0x0CC6; // Size: 0
		public const int ZC_SHOUT = 0x0CC7; // Size: 0
		public const int ZC_SHOUT_FAILED = 0x0CC8; // Size: 7
		public const int CZ_EXCHANGE_REQUEST = 0x0CC9; // Size: 14
		public const int ZC_EXCHANGE_REQUEST_ACK = 0x0CCA; // Size: 72
		public const int ZC_EXCHANGE_REQUEST_RECEIVED = 0x0CCB; // Size: 71
		public const int CZ_EXCHANGE_ACCEPT = 0x0CCC; // Size: 10
		public const int CZ_EXCHANGE_DECLINE = 0x0CCD; // Size: 10
		public const int ZC_EXCHANGE_DECLINE_ACK = 0x0CCE; // Size: 6
		public const int ZC_EXCHANGE_START = 0x0CCF; // Size: 72
		public const int CZ_EXCHANGE_OFFER = 0x0CD0; // Size: 30
		public const int ZC_EXCHANGE_OFFER_ACK = 0x0CD1; // Size: 0
		public const int CZ_EXCHANGE_AGREE = 0x0CD2; // Size: 10
		public const int ZC_EXCHANGE_AGREE_ACK = 0x0CD3; // Size: 7
		public const int CZ_EXCHANGE_FINALAGREE = 0x0CD4; // Size: 10
		public const int ZC_EXCHANGE_FINALAGREE_ACK = 0x0CD5; // Size: 7
		public const int CZ_EXCHANGE_CANCEL = 0x0CD6; // Size: 10
		public const int ZC_EXCHANGE_CANCEL_ACK = 0x0CD7; // Size: 6
		public const int ZC_EXCHANGE_SUCCESS = 0x0CD8; // Size: 6
		public const int ZC_COOLDOWN_LIST = 0x0CD9; // Size: 0
		public const int ZC_COOLDOWN_CHANGED = 0x0CDA; // Size: 27
		public const int ZC_OVERHEAT_CHANGED = 0x0CDB; // Size: 30
		public const int ZC_TEST_AGENT = 0x0CDC; // Size: 18
		public const int CZ_COMMON_SHOP_LIST = 0x0CDD; // Size: 10
		public const int ZC_COMMON_SHOP_LIST = 0x0CDE; // Size: 8
		public const int ZC_TIME_FACTOR = 0x0CDF; // Size: 10
		public const int ZC_PARTY_ENTER = 0x0CE0; // Size: 0
		public const int ZC_PARTY_OUT = 0x0CE1; // Size: 24
		public const int ZC_PARTY_DESTROY = 0x0CE2; // Size: 15
		public const int ZC_PARTY_INFO = 0x0CE3; // Size: 0
		public const int ZC_PARTY_LIST = 0x0CE4; // Size: 0
		public const int ZC_PARTY_CHAT = 0x0CE5; // Size: 0
		public const int ZC_PARTY_INST_INFO = 0x0CE6; // Size: 0
		public const int ZC_CHANGE_EQUIP_DURABILITY = 0x0CE7; // Size: 11
		public const int CZ_DIALOG_TX = 0x0CE8; // Size: 0
		public const int CZ_REQ_RECIPE = 0x0CE9; // Size: 0
		public const int ZC_CUSTOM_DIALOG = 0x0CEA; // Size: 75
		public const int ZC_SESSION_OBJECTS = 0x0CEB; // Size: 0
		public const int ZC_SESSION_OBJ_ADD = 0x0CEC; // Size: 0
		public const int ZC_SESSION_OBJ_REMOVE = 0x0CED; // Size: 10
		public const int ZC_SESSION_OBJ_TIME = 0x0CEE; // Size: 14
		public const int CZ_S_OBJ_VALUE_C = 0x0CEF; // Size: 26
		public const int CZ_REQ_NORMAL_TX = 0x0CF0; // Size: 45
		public const int ZC_COMMANDER_LOADER_INFO = 0x0CF1; // Size: 0
		public const int ZC_MOVE_SINGLE_ZONE = 0x0CF2; // Size: 18
		public const int ZC_BACKTO_ORIGINAL_SERVER = 0x0CF3; // Size: 8
		public const int CZ_BACKTO_ORIGINAL_SERVER = 0x0CF4; // Size: 12
		public const int CZ_REQ_NORMAL_TX_NUMARG = 0x0CF5; // Size: 0
		public const int ZC_WIKI_LIST = 0x0CF6; // Size: 0
		public const int ZC_WIKI_ADD = 0x0CF7; // Size: 22
		public const int CZ_WIKI_RECIPE_UPDATE = 0x0CF8; // Size: 10
		public const int ZC_UI_OPEN = 0x0CF9; // Size: 39
		public const int ZC_ENABLE_CONTROL = 0x0CFA; // Size: 75
		public const int ZC_CHANGE_CAMERA = 0x0CFB; // Size: 31
		public const int ZC_MONSTER_SDR_CHANGED = 0x0CFC; // Size: 11
		public const int ZC_MOVE_IGNORE_COLLISION = 0x0CFD; // Size: 30
		public const int ZC_CHANGE_CAMERA_ZOOM = 0x0CFE; // Size: 34
		public const int ZC_PLAY_SKILL_ANI = 0x0CFF; // Size: 82
		public const int ZC_PLAY_SKILL_CAST_ANI = 0x0D00; // Size: 30
		public const int CZ_REQ_ITEM_GET = 0x0D01; // Size: 14
		public const int ZC_ITEM_GET = 0x0D02; // Size: 18
		public const int CZ_GUARD = 0x0D03; // Size: 19
		public const int ZC_GUARD = 0x0D04; // Size: 19
		public const int ZC_STAMINA = 0x0D05; // Size: 10
		public const int ZC_ADD_STAMINA = 0x0D06; // Size: 10
		public const int ZC_GM_ORDER = 0x0D07; // Size: 10
		public const int ZC_MYPC_ENTER = 0x0D08; // Size: 18
		public const int ZC_LOCK_KEY = 0x0D09; // Size: 75
		public const int ZC_SAVE_INFO = 0x0D0A; // Size: 6
		public const int CZ_SAVE_INFO = 0x0D0B; // Size: 0
		public const int ZC_OPTION_LIST = 0x0D0C; // Size: 0
		public const int ZC_SKILLMAP_LIST = 0x0D0D; // Size: 0
		public const int CZ_GIVEITEM_TO_DUMMYPC = 0x0D0E; // Size: 22
		public const int CZ_FOOD_TABLE_TITLE = 0x0D0F; // Size: 79
		public const int CZ_USE_TP_AND_ENTER_INDUN = 0x0D10; // Size: 522
		public const int CZ_USE_RANKRESET_ITEM = 0x0D11; // Size: 18
		public const int ZC_SET_LAYER = 0x0D12; // Size: 10
		public const int ZC_CREATE_LAYERBOX = 0x0D13; // Size: 38
		public const int ZC_RESET_BOX = 0x0D14; // Size: 11
		public const int ZC_CREATE_SCROLLLOCKBOX = 0x0D15; // Size: 38
		public const int ZC_REMOVE_SCROLLLOCKBOX = 0x0D16; // Size: 10
		public const int CZ_DYNAMIC_CASTING_START = 0x0D17; // Size: 25
		public const int CZ_DYNAMIC_CASTING_END = 0x0D18; // Size: 20
		public const int CZ_SKILL_CANCEL_SCRIPT = 0x0D19; // Size: 10
		public const int ZC_LEAVE_TRIGGER = 0x0D1A; // Size: 6
		public const int ZC_BORN = 0x0D1B; // Size: 10
		public const int ZC_ACHIEVE_POINT_LIST = 0x0D1C; // Size: 0
		public const int ZC_ACHIEVE_POINT = 0x0D1D; // Size: 18
		public const int CZ_ACHIEVE_EQUIP = 0x0D1E; // Size: 14
		public const int ZC_ACHIEVE_EQUIP = 0x0D1F; // Size: 22
		public const int CZ_ACHIEVE_REWARD = 0x0D20; // Size: 14
		public const int CZ_CHANGE_CONFIG = 0x0D21; // Size: 18
		public const int CZ_CHANGE_CONFIG_STR = 0x0D22; // Size: 34
		public const int ZC_WORLD_MSG = 0x0D23; // Size: 43
		public const int ZC_ENABLE_SHOW_ITEM_GET = 0x0D24; // Size: 8
		public const int ZC_LOGIN_TIME = 0x0D25; // Size: 14
		public const int ZC_GIVE_EXP_TO_PC = 0x0D26; // Size: 42
		public const int ZC_LAYER_PC_LIST = 0x0D27; // Size: 0
		public const int ZC_LAYER_PC_SOBJ_PROP = 0x0D28; // Size: 0
		public const int CZ_CUSTOM_COMMAND = 0x0D29; // Size: 26
		public const int ZC_LAYER_INFO = 0x0D2A; // Size: 10
		public const int CZ_CHAT_MACRO = 0x0D2B; // Size: 146
		public const int ZC_CHAT_MACRO_LIST = 0x0D2C; // Size: 0
		public const int ZC_RULLET_LIST = 0x0D2D; // Size: 0
		public const int ZC_QUICKSLOT_REGISTER = 0x0D2E; // Size: 46
		public const int CZ_QUICKSLOT_LIST = 0x0D2F; // Size: 0
		public const int CZ_DOUBLE_ITEM_EQUIP = 0x0D30; // Size: 28
		public const int ZC_TRICK_PACKET = 0x0D31; // Size: 0
		public const int ZC_COOLDOWN_RATE = 0x0D32; // Size: 22
		public const int ZC_MAP_REVEAL_LIST = 0x0D33; // Size: 0
		public const int CZ_MAP_REVEAL_INFO = 0x0D34; // Size: 146
		public const int CZ_MAP_SEARCH_INFO = 0x0D35; // Size: 55
		public const int ZC_EXEC_CLIENT_SCP = 0x0D36; // Size: 0
		public const int ZC_SET_NPC_STATE = 0x0D37; // Size: 18
		public const int ZC_NPC_STATE_LIST = 0x0D38; // Size: 0
		public const int CZ_QUEST_NPC_STATE_CHECK = 0x0D39; // Size: 14
		public const int ZC_RANK_ACHIEVE_ADD = 0x0D3A; // Size: 14
		public const int CZ_GET_MAP_REVEAL_ACHIEVE = 0x0D3B; // Size: 10
		public const int CZ_IES_MODIFY_INFO = 0x0D3C; // Size: 0
		public const int ZC_IES_MODIFY_INFO = 0x0D3D; // Size: 0
		public const int ZC_IES_MODIFY_LIST = 0x0D3E; // Size: 0
		public const int CZ_IES_REVISION_DELETE = 0x0D3F; // Size: 0
		public const int ZC_IES_REVISION_DELETE = 0x0D40; // Size: 0
		public const int ZC_EQUIP_ITEM_REMOVE = 0x0D41; // Size: 18
		public const int ZC_SOLD_ITEM_LIST = 0x0D42; // Size: 0
		public const int ZC_SOLD_ITEM_DIVISION_LIST = 0x0D43; // Size: 0
		public const int CZ_SOLD_ITEM = 0x0D44; // Size: 19
		public const int CZ_WAREHOUSE_CMD = 0x0D45; // Size: 32
		public const int CZ_SWAP_ETC_INV_CHANGE_INDEX = 0x0D46; // Size: 35
		public const int CZ_SORT_INV = 0x0D47; // Size: 12
		public const int CZ_EXTEND_WAREHOUSE = 0x0D48; // Size: 11
		public const int CZ_CAST_CONTROL_SHOT = 0x0D49; // Size: 10
		public const int ZC_PC_PROP_UPDATE = 0x0D4A; // Size: 11
		public const int CZ_CLIENT_DAMAGE = 0x0D4B; // Size: 14
		public const int CZ_CLIENT_ATTACK = 0x0D4C; // Size: 15
		public const int ZC_SYSTEM_MSG = 0x0D4D; // Size: 0
		public const int ZC_FSM_MOVE = 0x0D4E; // Size: 0
		public const int CZ_QUEST_CHECK_SAVE = 0x0D4F; // Size: 50
		public const int CZ_SPRAY_REQ_INFO = 0x0D50; // Size: 14
		public const int CZ_SPRAY_DRAW_INFO = 0x0D51; // Size: 0
		public const int ZC_SPRAY_ID = 0x0D52; // Size: 18
		public const int ZC_SPRAY_DRAW_INFO = 0x0D53; // Size: 0
		public const int ZC_MONSTER_LIFETIME = 0x0D54; // Size: 14
		public const int ZC_SPRAY_LIKE_LIST = 0x0D55; // Size: 0
		public const int ZC_WIKI_COUNT_UPDATE = 0x0D56; // Size: 19
		public const int ZC_WIKI_INT_PROP_UPDATE = 0x0D57; // Size: 15
		public const int ZC_WIKI_BOOL_PROP_UPDATE = 0x0D58; // Size: 12
		public const int CZ_REQ_WIKI_RANK = 0x0D59; // Size: 15
		public const int ZC_WIKI_RANK_LIST = 0x0D5A; // Size: 0
		public const int ZC_SHARED_MSG = 0x0D5B; // Size: 10
		public const int CZ_REQ_WIKI_PROP_RANK = 0x0D5C; // Size: 16
		public const int CZ_GET_WIKI_REWARD = 0x0D5D; // Size: 11
		public const int CZ_REQ_TX_ITEM = 0x0D5E; // Size: 0
		public const int ZC_TEST_DBG = 0x0D5F; // Size: 0
		public const int ZC_MONSTER_DIST = 0x0D60; // Size: 0
		public const int ZC_RESET_SKILL_FORCEID = 0x0D61; // Size: 10
		public const int ZC_EMOTICON = 0x0D62; // Size: 18
		public const int ZC_SHOW_EMOTICON = 0x0D63; // Size: 18
		public const int ZC_TREASUREMARK_BY_MAP = 0x0D64; // Size: 0
		public const int ZC_SHOW_MAP = 0x0D65; // Size: 0
		public const int CZ_FLEE_OBSTACLE = 0x0D66; // Size: 26
		public const int ZC_HOLD_MOVE_PATH = 0x0D67; // Size: 11
		public const int ZC_ENTER_HOOK = 0x0D68; // Size: 10
		public const int ZC_LEAVE_HOOK = 0x0D69; // Size: 10
		public const int ZC_MONSTER_PROPERTY = 0x0D6A; // Size: 0
		public const int ZC_GROUND_EFFECT = 0x0D6B; // Size: 50
		public const int ZC_FLY = 0x0D6C; // Size: 18
		public const int ZC_FLY_OPTION = 0x0D6D; // Size: 14
		public const int ZC_FLY_MATH = 0x0D6E; // Size: 23
		public const int ZC_FLY_HEIGHT = 0x0D6F; // Size: 14
		public const int ZC_UPDATE_SHIELD = 0x0D70; // Size: 14
		public const int ZC_SHOW_MODEL = 0x0D71; // Size: 15
		public const int ZC_SKILL_RANGE_DBG = 0x0D72; // Size: 58
		public const int ZC_SKILL_RANGE_FAN = 0x0D73; // Size: 40
		public const int ZC_SKILL_RANGE_SQUARE = 0x0D74; // Size: 40
		public const int ZC_SKILL_RANGE_CIRCLE = 0x0D75; // Size: 28
		public const int ZC_SKILL_RANGE_DONUTS = 0x0D76; // Size: 32
		public const int ZC_TEAMID = 0x0D77; // Size: 11
		public const int ZC_PC = 0x0D78; // Size: 0
		public const int CZ_LOG = 0x0D79; // Size: 0
		public const int ZC_MOTIONBLUR = 0x0D7A; // Size: 11
		public const int ZC_PLAY_FORCE = 0x0D7B; // Size: 78
		public const int ZC_CAST_TARGET = 0x0D7C; // Size: 14
		public const int ZC_START_INFO = 0x0D7D; // Size: 0
		public const int ZC_JOB_EXP_UP = 0x0D7E; // Size: 18
		public const int ZC_JOB_PTS = 0x0D7F; // Size: 18
		public const int ZC_MON_STAMINA = 0x0D80; // Size: 22
		public const int CZ_CUSTOM_SCP = 0x0D81; // Size: 14
		public const int ZC_VIEW_FOCUS = 0x0D82; // Size: 24
		public const int ZC_HARDCODED_SKILL = 0x0D83; // Size: 26
		public const int CZ_HARDCODED_SKILL = 0x0D84; // Size: 34
		public const int ZC_FORCE_MOVE = 0x0D85; // Size: 30
		public const int ZC_HSKILL_CONTROL = 0x0D86; // Size: 22
		public const int ZC_CANCEL_DEADEVENT = 0x0D87; // Size: 10
		public const int ZC_ACTION_PKS = 0x0D88; // Size: 35
		public const int CZ_HARDCODED_ITEM = 0x0D89; // Size: 22
		public const int CZ_CANCEL_TRANSFORM_SKILL = 0x0D8A; // Size: 10
		public const int CZ_BRIQUET = 0x0D8B; // Size: 32
		public const int ZC_VIBRATE = 0x0D8C; // Size: 30
		public const int ZC_COUNTER_MOVE = 0x0D8D; // Size: 10
		public const int CZ_COUNTER_ATTACK = 0x0D8E; // Size: 14
		public const int CZ_CLIENT_DIRECT = 0x0D8F; // Size: 30
		public const int ZC_CLIENT_DIRECT = 0x0D90; // Size: 30
		public const int ZC_OWNER = 0x0D91; // Size: 14
		public const int ZC_GD_RANK = 0x0D92; // Size: 10
		public const int CZ_RUN_BGEVENT = 0x0D93; // Size: 74
		public const int ZC_ADD_SKILL_EFFECT = 0x0D94; // Size: 18
		public const int ZC_ITEM_DROPABLE = 0x0D95; // Size: 10
		public const int CZ_ITEM_DROP_TO_OBJECT = 0x0D96; // Size: 26
		public const int ZC_NORMAL = 0x0D97; // Size: 0
		public const int CZ_G_QUEST_CHECK = 0x0D98; // Size: 14
		public const int ZC_MOVE_PATH_MATH = 0x0D99; // Size: 30
		public const int CZ_MYPAGE_COMMENT_ADD = 0x0D9A; // Size: 278
		public const int CZ_MYPAGE_COMMENT_DELETE = 0x0D9B; // Size: 18
		public const int CZ_GUESTPAGE_COMMENT_ADD = 0x0D9C; // Size: 278
		public const int CZ_GET_TARGET_MYPAGE = 0x0D9D; // Size: 14
		public const int CZ_ON_MYPAGE_MODE = 0x0D9E; // Size: 14
		public const int CZ_RESET_SOCIAL_MODE = 0x0D9F; // Size: 10
		public const int CZ_GET_TARGET_GUESTPAGE = 0x0DA0; // Size: 14
		public const int CZ_ADD_SELLMODE_ITEM = 0x0DA1; // Size: 30
		public const int CZ_DELETE_SELLMODE_ITEM = 0x0DA2; // Size: 18
		public const int CZ_ON_SELLITEM_MODE = 0x0DA3; // Size: 14
		public const int ZC_MYPAGE_MAP = 0x0DA4; // Size: 0
		public const int ZC_GUESTPAGE_MAP = 0x0DA5; // Size: 0
		public const int ZC_ON_MYPAGE_MODE = 0x0DA6; // Size: 0
		public const int ZC_RESET_SOCIAL_MODE = 0x0DA7; // Size: 10
		public const int CZ_ON_ITEMBUY_MODE = 0x0DA8; // Size: 0
		public const int ZC_ON_BUYITEM_MODE = 0x0DA9; // Size: 0
		public const int ZC_SHOW_GROUND_ITEM_MARK = 0x0DAA; // Size: 30
		public const int ZC_HELP_LIST = 0x0DAB; // Size: 0
		public const int ZC_HELP_ADD = 0x0DAC; // Size: 11
		public const int CZ_CLIENT_HIT_LIST = 0x0DAD; // Size: 0
		public const int ZC_PC_ATKSTATE = 0x0DAE; // Size: 11
		public const int ZC_SEND_PREMIUM_STATE = 0x0DAF; // Size: 16
		public const int CZ_HELP_READ_TYPE = 0x0DB0; // Size: 18
		public const int CZ_MOVE_PATH_END = 0x0DB1; // Size: 10
		public const int ZC_COLL_DAMAGE = 0x0DB2; // Size: 11
		public const int CZ_KEYBOARD_BEAT = 0x0DB3; // Size: 10
		public const int CZ_MOVEHIT_SCP = 0x0DB4; // Size: 22
		public const int ZC_SYNC_START = 0x0DB5; // Size: 14
		public const int ZC_SYNC_END = 0x0DB6; // Size: 14
		public const int ZC_SYNC_EXEC = 0x0DB7; // Size: 10
		public const int ZC_SYNC_EXEC_BY_SKILL_TIME = 0x0DB8; // Size: 18
		public const int CZ_STOP_TIMEACTION = 0x0DB9; // Size: 11
		public const int CZ_REQ_DUMMYPC_INFO = 0x0DBA; // Size: 18
		public const int CZ_VISIT_BARRACK = 0x0DBB; // Size: 74
		public const int CZ_SPC_SKILL_POS = 0x0DBC; // Size: 22
		public const int CZ_CHANGE_HEAD = 0x0DBD; // Size: 74
		public const int CZ_CREATE_ARROW_CRAFT = 0x0DBE; // Size: 14
		public const int CZ_REQ_MINITEXT = 0x0DBF; // Size: 266
		public const int ZC_PC_MOVE_STOP = 0x0DC0; // Size: 35
		public const int CZ_STOP_ALLPC = 0x0DC1; // Size: 10
		public const int CZ_COMPLETE_PRELOAD = 0x0DC2; // Size: 14
		public const int CZ_MGAME_JOIN_CMD = 0x0DC3; // Size: 46
		public const int CZ_ADD_HELP = 0x0DC4; // Size: 14
		public const int ZC_ATTACH_TO_OBJ = 0x0DC5; // Size: 49
		public const int ZC_DETACH_FROM_OBJ = 0x0DC6; // Size: 14
		public const int ZC_RUN_FROM = 0x0DC7; // Size: 14
		public const int ZC_LOOKAT_OBJ = 0x0DC8; // Size: 14
		public const int CZ_SKILL_CELL_LIST = 0x0DC9; // Size: 0
		public const int CZ_SKILL_TOOL_GROUND_POS = 0x0DCA; // Size: 26
		public const int CZ_DIRECTION_PROCESS = 0x0DCB; // Size: 18
		public const int CZ_DIRECTION_MOVE_STATE = 0x0DCC; // Size: 0
		public const int ZC_TO_ALL_CLIENT = 0x0DCD; // Size: 0
		public const int ZC_TO_CLIENT = 0x0DCE; // Size: 0
		public const int CZ_REWARD_CMD = 0x0DCF; // Size: 14
		public const int CZ_PROPERTY_COMPARE = 0x0DD0; // Size: 16
		public const int ZC_PROPERTY_COMPARE = 0x0DD1; // Size: 0
		public const int ZC_PROPERTY_COMPARE_FOR_ACT = 0x0DD2; // Size: 0
		public const int ZC_FACTION = 0x0DD3; // Size: 14
		public const int ZC_SEND_CASH_VALUE = 0x0DD4; // Size: 0
		public const int ZC_BEGIN_KILL_LOG = 0x0DD5; // Size: 6
		public const int ZC_END_KILL_LOG = 0x0DD6; // Size: 6
		public const int ZC_CLEAR_KILL_LOG = 0x0DD7; // Size: 6
		public const int CZ_NPC_AUCTION_CMD = 0x0DD8; // Size: 30
		public const int ZC_DIRECTION_APC = 0x0DD9; // Size: 26
		public const int ZC_BGMODEL_ANIM_INFO = 0x0DDA; // Size: 15
		public const int ZC_ATTACH_BY_KNOCKBACK = 0x0DDB; // Size: 38
		public const int CZ_OBJECT_MOVE = 0x0DDC; // Size: 30
		public const int CZ_CONTROL_OBJECT_ROTATE = 0x0DDD; // Size: 22
		public const int CZ_SUMMON_COMMAND = 0x0DDE; // Size: 18
		public const int CZ_VEHICLE_RIDE = 0x0DDF; // Size: 15
		public const int CZ_REQ_WIKI_CATEGORY_RANK_PAGE_INFO = 0x0DE0; // Size: 78
		public const int CZ_REQ_ACHIEVE_RANK_PAGE_INFO = 0x0DE1; // Size: 78
		public const int CZ_REQ_MONSTER_RANK_INFO = 0x0DE2; // Size: 74
		public const int ZC_SPC_TRIGGER_EXEC = 0x0DE3; // Size: 30
		public const int CZ_REQ_MGAME_VIEW = 0x0DE4; // Size: 18
		public const int CZ_REQ_MGAME_CHAT = 0x0DE5; // Size: 0
		public const int CZ_TOURNAMENT_GIFT = 0x0DE6; // Size: 18
		public const int CZ_PARTY_INVITE_ACCEPT = 0x0DE7; // Size: 87
		public const int CZ_PARTY_INVITE_CANCEL = 0x0DE8; // Size: 91
		public const int CZ_PARTY_PROP_CHANGE = 0x0DE9; // Size: 147
		public const int CZ_REQ_MARKET_REGISTER = 0x0DEA; // Size: 40
		public const int CZ_REQ_MARKET_MINMAX_INFO = 0x0DEB; // Size: 18
		public const int CZ_REQ_MARKET_BUY = 0x0DEC; // Size: 0
		public const int CZ_REQ_MARKET_LIST = 0x0DED; // Size: 138
		public const int CZ_REQ_MY_SELL_LIST = 0x0DEE; // Size: 14
		public const int CZ_REQ_CABINET_LIST = 0x0DEF; // Size: 10
		public const int CZ_REQ_GET_CABINET_ITEM = 0x0DF0; // Size: 26
		public const int CZ_REQ_CANCEL_MARKET_ITEM = 0x0DF1; // Size: 18
		public const int CZ_INV_ITEM_LOCK = 0x0DF2; // Size: 19
		public const int CZ_OBJ_RECORD_POS = 0x0DF3; // Size: 0
		public const int CZ_FORMATION_CMD = 0x0DF4; // Size: 32
		public const int CZ_REGISTER_AUTOSELLER = 0x0DF5; // Size: 0
		public const int CZ_OPEN_AUTOSELLER = 0x0DF6; // Size: 66
		public const int CZ_BUY_AUTOSELLER_ITEMS = 0x0DF7; // Size: 0
		public const int CZ_SELL_MY_AUTOSELLER_ITEMS = 0x0DF8; // Size: 0
		public const int CZ_PUZZLE_CRAFT = 0x0DF9; // Size: 0
		public const int CZ_PET_EQUIP = 0x0DFA; // Size: 34
		public const int CZ_PET_AUTO_ATK = 0x0DFB; // Size: 11
		public const int ZC_PET_AUTO_ATK = 0x0DFC; // Size: 11
		public const int ZC_FOUND_PARTY_LIST = 0x0DFD; // Size: 0
		public const int ZC_NEAR_PARTY_LIST = 0x0DFE; // Size: 0
		public const int ZC_RECOMMEND_PARTY_INFO = 0x0DFF; // Size: 0
		public const int CZ_REQUEST_SOME_PARTY = 0x0E00; // Size: 90
		public const int CZ_REFRESH_MEMBERRECOMMEND_LIST = 0x0E01; // Size: 10
		public const int ZC_TO_SOMEWHERE_CLIENT = 0x0E02; // Size: 0
		public const int CZ_REVEAL_NPC_STATE = 0x0E03; // Size: 14
		public const int CZ_CHANGE_CHANNEL = 0x0E04; // Size: 12
		public const int CZ_REQ_CHANNEL_TRAFFICS = 0x0E05; // Size: 12
		public const int CZ_BUY_PROPERTYSHOP_ITEM = 0x0E06; // Size: 0
		public const int CZ_SKILL_USE_HEIGHT = 0x0E07; // Size: 14
		public const int CZ_ACCEPT_PARTY_QUEST = 0x0E08; // Size: 20
		public const int CZ_CHANGE_GUILD_NEUTRALITY = 0x0E09; // Size: 10
		public const int CZ_SAVE_GUILD_BOARD = 0x0E0A; // Size: 110
		public const int CZ_ACCEPT_PARTY_EVENT = 0x0E0B; // Size: 20
		public const int CZ_DELETE_PARTY_EVENT = 0x0E0C; // Size: 20
		public const int CZ_PING = 0x0E0D; // Size: 10
		public const int ZC_PING = 0x0E0E; // Size: 10
		public const int CZ_REQ_REMAIN_NEXONCASH = 0x0E0F; // Size: 10
		public const int CZ_REQ_OPEN_INGAMESHOP_UI = 0x0E10; // Size: 10
		public const int CZ_REQ_BUY_INGAMESHOP_ITEM = 0x0E11; // Size: 78
		public const int CZ_REQ_BUY_ALL_INGAMESHOP_ITEM = 0x0E12; // Size: 10
		public const int CZ_REQ_PICKUP_CASHITEM = 0x0E13; // Size: 37
		public const int CZ_REQ_REFUND_CASHITEM = 0x0E14; // Size: 33
		public const int ZC_XIGNCODE_BUFFER = 0x0E15; // Size: 524
		public const int CZ_XIGNCODE_BUFFER = 0x0E16; // Size: 524
		public const int CZ_SYSTEM_LOG_SAVE_TO_MONGODB = 0x0E17; // Size: 280
		public const int CZ_CHANGE_TITLE = 0x0E18; // Size: 74
		public const int CZ_PC_COMMENT_CHANGE = 0x0E19; // Size: 0
		public const int CZ_AUTTOSELLER_BUYER_CLOSE = 0x0E1A; // Size: 18
		public const int CZ_REQ_ITEM_LIST = 0x0E1B; // Size: 11
		public const int CZ_REQ_ACC_WARE_VIS_LOG = 0x0E1C; // Size: 10
		public const int CZ_HIT_MISSILE = 0x0E1D; // Size: 14
		public const int CZ_I_NEED_PARTY = 0x0E1E; // Size: 23
		public const int CZ_PARTY_JOIN_BY_LINK = 0x0E1F; // Size: 19
		public const int ZC_RECOMMEND_PARTYMEMBER_INFO = 0x0E20; // Size: 0
		public const int CZ_PVP_ZONE_CMD = 0x0E21; // Size: 26
		public const int CZ_PVP_CHAT = 0x0E22; // Size: 0
		public const int CZ_CARDBATTLE_CMD = 0x0E23; // Size: 26
		public const int CZ_REQ_UPDATE_CONTENTS_SESSION = 0x0E24; // Size: 10
		public const int CZ_REQ_FRIENDLY_FIGHT = 0x0E25; // Size: 15
		public const int CZ_HARDSKILL_POS_LIST = 0x0E26; // Size: 0
		public const int CZ_CART_POSITION = 0x0E27; // Size: 26
		public const int CZ_REQ_RIDE_CART = 0x0E28; // Size: 18
		public const int CZ_DUMMYPC_SKILL_POS = 0x0E29; // Size: 26
		public const int CZ_NGS = 0x0E2A; // Size: 0
		public const int CZ_PARTY_MEMBER_SKILL_USE = 0x0E2B; // Size: 0
		public const int CZ_PARTY_MEMBER_SKILL_ACCEPT = 0x0E2C; // Size: 22
		public const int CZ_SYSTEM_LOG_TO_SERVER = 0x0E2D; // Size: 1099
		public const int CZ_CHECK_PING = 0x0E2E; // Size: 10
		public const int CZ_CANCEL_INDUN_MATCHING = 0x0E2F; // Size: 10
		public const int CZ_CANCEL_INDUN_PARTY_MATCHING = 0x0E30; // Size: 10
		public const int CZ_REQ_GM_ORDER = 0x0E31; // Size: 202
		public const int CZ_REPORT_AUTOBOT = 0x0E32; // Size: 74
		public const int CZ_REPORT_PVP_ZOOM = 0x0E33; // Size: 10
		public const int CZ_PARTY_INVENTORY_LOAD = 0x0E34; // Size: 12
		public const int CZ_PARTY_SHARED_QUEST = 0x0E35; // Size: 278
		public const int CZ_REQ_MOVE_PARTYINV_TO_ACCOUNT = 0x0E36; // Size: 31
		public const int CZ_PVP_COMMAND = 0x0E37; // Size: 23
		public const int CZ_REQ_CancelGachaCube = 0x0E38; // Size: 10
		public const int CZ_WAREHOUSE_TAKE_LIST = 0x0E39; // Size: 0
		public const int CZ_SAVE_AUTO_MACRO = 0x0E3A; // Size: 0
		public const int CZ_REQUEST_LOAD_ITEM_BUY_LIMIT = 0x0E3B; // Size: 10
		public const int CZ_AUTO_STATE = 0x0E3C; // Size: 11
		public const int CZ_RUN_GAMEEXIT_TIMER = 0x0E3D; // Size: 42
		public const int CZ_FIXED_NOTICE_SHOW = 0x0E3E; // Size: 10
		public const int CZ_SAGE_SKILL_GO_FRIEND = 0x0E3F; // Size: 90
		public const int CZ_REQUEST_CHANGE_NAME = 0x0E40; // Size: 66
		public const int ZC_HOLD_EXP_BOOK_TIME = 0x0E41; // Size: 25
		public const int CZ_HOLD_EXP_BOOK_TIME = 0x0E42; // Size: 14
		public const int CZ_SCREENSHOT_HASH = 0x0E43; // Size: 43
		public const int CZ_REQ_MOVE_TO_INDUN = 0x0E44; // Size: 18
		public const int CZ_CLEAR_INDUN_REG = 0x0E45; // Size: 10
		public const int CZ_REQ_REGISTER_TO_INDUN = 0x0E46; // Size: 14
		public const int CZ_REQ_GUILD_MEMBER_AUTHORITY = 0x0E47; // Size: 23
		public const int CZ_TPSHOP_RTPP_FOR_TEST = 0x0E48; // Size: 10
		public const int CZ_REQ_FORGERY = 0x0E49; // Size: 30
		public const int CZ_REQ_BUILD_FOODTABLE = 0x0E4A; // Size: 79
		public const int CZ_REQ_UNDERSTAFF_ENTER_ALLOW = 0x0E4B; // Size: 10
		public const int CZ_REQ_UNDERSTAFF_ENTER_ALLOW_WITH_PARTY = 0x0E4C; // Size: 14
		public const int ZC_PLAY_PAIR_ANIMATION = 0x0E4D; // Size: 34
		public const int ZC_ATTACH_TO_SLOT = 0x0E4E; // Size: 22
		public const int CZ_REQ_FISHING = 0x0E4F; // Size: 23
		public const int CZ_REQ_GET_FISHING_ITEM = 0x0E50; // Size: 10
		public const int ZC_PLAY_ATTACH_MODEL_ANIM = 0x0E51; // Size: 22
		public const int ZC_FISHING_ITEM_LIST = 0x0E52; // Size: 0
		public const int CZ_REQ_FISHING_RANK = 0x0E53; // Size: 78
		public const int ZC_ENABLE_ROTATE = 0x0E54; // Size: 75
		public const int CZ_SYNC_POS = 0x0E55; // Size: 26
		public const int CZ_DISCONNECT_REASON_FOR_LOG = 0x0E56; // Size: 0
		public const int CZ_LOAD_COMPLETE = 0x0E57; // Size: 10
		public const int ZC_LOAD_COMPLETE = 0x0E58; // Size: 6

		private static readonly Dictionary<int, int> _sizes = new Dictionary<int, int>();
		private static readonly Dictionary<int, string> _names = new Dictionary<int, string>();

		static Op()
		{
			_sizes[Op.CB_LOGIN] = 206;
			_sizes[Op.CB_LOGIN_BY_PASSPORT] = 1131;
			_sizes[Op.CB_LOGOUT] = 10;
			_sizes[Op.CB_START_BARRACK] = 11;
			_sizes[Op.CB_COMMANDER_CREATE] = 93;
			_sizes[Op.BC_COMMANDER_CREATE_SLOTID] = 7;
			_sizes[Op.CB_COMMANDER_DESTROY] = 18;
			_sizes[Op.CB_CHECK_CLIENT_INTEGRITY] = 74;
			_sizes[Op.CB_CLIENT_INTEGRITY_FAIL] = 1035;
			_sizes[Op.CB_START_GAME] = 13;
			_sizes[Op.CB_BARRACKNAME_CHANGE] = 74;
			_sizes[Op.CB_COMMANDER_MOVE] = 31;
			_sizes[Op.CB_ECHO] = 30;
			_sizes[Op.BC_LOGINOK] = 129;
			_sizes[Op.BC_LOGIN_PACKET_RECEIVED] = 6;
			_sizes[Op.BC_LOGOUTOK] = 6;
			_sizes[Op.BC_COMMANDER_LIST] = 0;
			_sizes[Op.BC_COMMANDER_CREATE] = 342;
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
			_sizes[Op.CB_SCREENSHOT_HASH] = 42;
			_sizes[Op.CB_REQ_CHANNEL_TRAFFIC] = 14;
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
			_sizes[Op.CB_CHANGE_BARRACK_LAYER] = 22;
			_sizes[Op.CB_SELECT_BARRACK_LAYER] = 14;
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
			_sizes[Op.CB_NGS] = 0;
			_sizes[Op.CB_GEMSCOOL_PCINFO] = 1290;
			_sizes[Op.CB_NOT_AUTHORIZED_ADDON_LIST] = 1039;
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
			_sizes[Op.CS_GROUP_CHAT_INVITE] = 110;
			_sizes[Op.CS_GROUP_CHAT_INVITE_BY_TAG] = 22;
			_sizes[Op.CS_ALLOW_GROUP_CHAT_TAG_INVITE] = 46;
			_sizes[Op.CS_REFRESH_GROUP_CHAT] = 6;
			_sizes[Op.CS_CREATE_GROUP_CHAT] = 6;
			_sizes[Op.CS_REQ_CHAT_HISTORY] = 22;
			_sizes[Op.CS_REQ_OUT_ROOM] = 14;
			_sizes[Op.CS_REQ_RELATED_PC_SESSION] = 16;
			_sizes[Op.CS_REDIS_SKILLPOINT] = 22;
			_sizes[Op.CS_PARTY_CLIENT_INFO_SEND] = 0;
			_sizes[Op.CS_NORMAL_GAME_START] = 6;
			_sizes[Op.CS_REQUEST_PVP_RANKING] = 88;
			_sizes[Op.CS_REQUEST_ALL_SEASON_TOP_PVP_RANKING] = 80;
			_sizes[Op.CS_INVITE_PARTY_PVP] = 10;
			_sizes[Op.CS_ACCEPT_PARTY_PVP] = 19;
			_sizes[Op.CS_LIKE_IT] = 88;
			_sizes[Op.CS_UNLIKE_IT] = 24;
			_sizes[Op.CS_LIKE_IT_CONFIRM] = 16;
			_sizes[Op.CS_ADD_RELATION_SCORE] = 88;
			_sizes[Op.CS_GET_LIKE_COUNT] = 16;
			_sizes[Op.CZ_CONNECT] = 1208;
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
			_sizes[Op.ZC_ENTER_PC] = 353;
			_sizes[Op.ZC_ENTER_MONSTER] = 0;
			_sizes[Op.ZC_ENTER_DUMMYPC] = 316;
			_sizes[Op.ZC_UPDATED_DUMMYPC] = 274;
			_sizes[Op.ZC_ENTER_ITEM] = 103;
			_sizes[Op.ZC_LEAVE] = 12;
			_sizes[Op.ZC_MOVE_PATH] = 42;
			_sizes[Op.ZC_MOVE_POS] = 43;
			_sizes[Op.ZC_MOVE_BEZIER] = 75;
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
			_sizes[Op.ZC_UPDATED_PCAPPEARANCE] = 274;
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
			_sizes[Op.ZC_BUFF_REMOVE] = 20;
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
			_sizes[Op.CZ_RESURRECT] = 19;
			_sizes[Op.ZC_RESURRECT_SAVE_POINT_ACK] = 7;
			_sizes[Op.ZC_RESURRECT_HERE_ACK] = 7;
			_sizes[Op.CZ_CLICK_TRIGGER] = 15;
			_sizes[Op.CZ_KEYBOARD_MOVE] = 41;
			_sizes[Op.CZ_EXPECTED_STOP_POS] = 31;
			_sizes[Op.CZ_JUMP] = 11;
			_sizes[Op.CZ_DASHRUN] = 12;
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
			_sizes[Op.CZ_SELF_CHAT] = 0;
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
			_sizes[Op.CZ_REQ_DELETE_EXPIRED_ITEMS] = 18;
			_sizes[Op.ZC_CHECK_INVINDEX] = 30;
			_sizes[Op.CZ_PREMIUM_ENCHANTCHIP] = 26;
			_sizes[Op.CZ_PREMIUM_GACHACUBE] = 10;
			_sizes[Op.ZC_ITEM_INVENTORY_LIST] = 0;
			_sizes[Op.ZC_ITEM_INVENTORY_DIVISION_LIST] = 0;
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
			_sizes[Op.CZ_REQ_OPEN_ITEM_DUNGEON] = 19;
			_sizes[Op.CZ_ANSWER_OPEN_ITEM_DUNGEON] = 19;
			_sizes[Op.CZ_SEND_ITEM_PROP_TO_ALCHMIST] = 28;
			_sizes[Op.CZ_EXCUTE_ITEM_DUNGEON] = 34;
			_sizes[Op.ZC_RECIVE_ITEM_PROP_TO_TARGET] = 0;
			_sizes[Op.CZ_DISPEL_DEBUFF_TOGGLE] = 14;
			_sizes[Op.CZ_JUNGTAN_TOGGLE] = 24;
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
			_sizes[Op.ZC_EXCHANGE_START] = 72;
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
			_sizes[Op.ZC_COOLDOWN_CHANGED] = 27;
			_sizes[Op.ZC_OVERHEAT_CHANGED] = 30;
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
			_sizes[Op.CZ_S_OBJ_VALUE_C] = 26;
			_sizes[Op.CZ_REQ_NORMAL_TX] = 45;
			_sizes[Op.ZC_COMMANDER_LOADER_INFO] = 0;
			_sizes[Op.ZC_MOVE_SINGLE_ZONE] = 18;
			_sizes[Op.ZC_BACKTO_ORIGINAL_SERVER] = 8;
			_sizes[Op.CZ_BACKTO_ORIGINAL_SERVER] = 12;
			_sizes[Op.CZ_REQ_NORMAL_TX_NUMARG] = 0;
			_sizes[Op.ZC_WIKI_LIST] = 0;
			_sizes[Op.ZC_WIKI_ADD] = 22;
			_sizes[Op.CZ_WIKI_RECIPE_UPDATE] = 10;
			_sizes[Op.ZC_UI_OPEN] = 39;
			_sizes[Op.ZC_ENABLE_CONTROL] = 75;
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
			_sizes[Op.CZ_USE_RANKRESET_ITEM] = 18;
			_sizes[Op.ZC_SET_LAYER] = 10;
			_sizes[Op.ZC_CREATE_LAYERBOX] = 38;
			_sizes[Op.ZC_RESET_BOX] = 11;
			_sizes[Op.ZC_CREATE_SCROLLLOCKBOX] = 38;
			_sizes[Op.ZC_REMOVE_SCROLLLOCKBOX] = 10;
			_sizes[Op.CZ_DYNAMIC_CASTING_START] = 25;
			_sizes[Op.CZ_DYNAMIC_CASTING_END] = 20;
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
			_sizes[Op.ZC_SOLD_ITEM_DIVISION_LIST] = 0;
			_sizes[Op.CZ_SOLD_ITEM] = 19;
			_sizes[Op.CZ_WAREHOUSE_CMD] = 32;
			_sizes[Op.CZ_SWAP_ETC_INV_CHANGE_INDEX] = 35;
			_sizes[Op.CZ_SORT_INV] = 12;
			_sizes[Op.CZ_EXTEND_WAREHOUSE] = 11;
			_sizes[Op.CZ_CAST_CONTROL_SHOT] = 10;
			_sizes[Op.ZC_PC_PROP_UPDATE] = 11;
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
			_sizes[Op.ZC_FLY_OPTION] = 14;
			_sizes[Op.ZC_FLY_MATH] = 23;
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
			_sizes[Op.ZC_JOB_EXP_UP] = 18;
			_sizes[Op.ZC_JOB_PTS] = 18;
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
			_sizes[Op.CZ_BRIQUET] = 32;
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
			_sizes[Op.CZ_PARTY_INVITE_ACCEPT] = 87;
			_sizes[Op.CZ_PARTY_INVITE_CANCEL] = 91;
			_sizes[Op.CZ_PARTY_PROP_CHANGE] = 147;
			_sizes[Op.CZ_REQ_MARKET_REGISTER] = 40;
			_sizes[Op.CZ_REQ_MARKET_MINMAX_INFO] = 18;
			_sizes[Op.CZ_REQ_MARKET_BUY] = 0;
			_sizes[Op.CZ_REQ_MARKET_LIST] = 138;
			_sizes[Op.CZ_REQ_MY_SELL_LIST] = 14;
			_sizes[Op.CZ_REQ_CABINET_LIST] = 10;
			_sizes[Op.CZ_REQ_GET_CABINET_ITEM] = 26;
			_sizes[Op.CZ_REQ_CANCEL_MARKET_ITEM] = 18;
			_sizes[Op.CZ_INV_ITEM_LOCK] = 19;
			_sizes[Op.CZ_OBJ_RECORD_POS] = 0;
			_sizes[Op.CZ_FORMATION_CMD] = 32;
			_sizes[Op.CZ_REGISTER_AUTOSELLER] = 0;
			_sizes[Op.CZ_OPEN_AUTOSELLER] = 66;
			_sizes[Op.CZ_BUY_AUTOSELLER_ITEMS] = 0;
			_sizes[Op.CZ_SELL_MY_AUTOSELLER_ITEMS] = 0;
			_sizes[Op.CZ_PUZZLE_CRAFT] = 0;
			_sizes[Op.CZ_PET_EQUIP] = 34;
			_sizes[Op.CZ_PET_AUTO_ATK] = 11;
			_sizes[Op.ZC_PET_AUTO_ATK] = 11;
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
			_sizes[Op.CZ_CHANGE_GUILD_NEUTRALITY] = 10;
			_sizes[Op.CZ_SAVE_GUILD_BOARD] = 110;
			_sizes[Op.CZ_ACCEPT_PARTY_EVENT] = 20;
			_sizes[Op.CZ_DELETE_PARTY_EVENT] = 20;
			_sizes[Op.CZ_PING] = 10;
			_sizes[Op.ZC_PING] = 10;
			_sizes[Op.CZ_REQ_REMAIN_NEXONCASH] = 10;
			_sizes[Op.CZ_REQ_OPEN_INGAMESHOP_UI] = 10;
			_sizes[Op.CZ_REQ_BUY_INGAMESHOP_ITEM] = 78;
			_sizes[Op.CZ_REQ_BUY_ALL_INGAMESHOP_ITEM] = 10;
			_sizes[Op.CZ_REQ_PICKUP_CASHITEM] = 37;
			_sizes[Op.CZ_REQ_REFUND_CASHITEM] = 33;
			_sizes[Op.ZC_XIGNCODE_BUFFER] = 524;
			_sizes[Op.CZ_XIGNCODE_BUFFER] = 524;
			_sizes[Op.CZ_SYSTEM_LOG_SAVE_TO_MONGODB] = 280;
			_sizes[Op.CZ_CHANGE_TITLE] = 74;
			_sizes[Op.CZ_PC_COMMENT_CHANGE] = 0;
			_sizes[Op.CZ_AUTTOSELLER_BUYER_CLOSE] = 18;
			_sizes[Op.CZ_REQ_ITEM_LIST] = 11;
			_sizes[Op.CZ_REQ_ACC_WARE_VIS_LOG] = 10;
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
			_sizes[Op.CZ_CANCEL_INDUN_PARTY_MATCHING] = 10;
			_sizes[Op.CZ_REQ_GM_ORDER] = 202;
			_sizes[Op.CZ_REPORT_AUTOBOT] = 74;
			_sizes[Op.CZ_REPORT_PVP_ZOOM] = 10;
			_sizes[Op.CZ_PARTY_INVENTORY_LOAD] = 12;
			_sizes[Op.CZ_PARTY_SHARED_QUEST] = 278;
			_sizes[Op.CZ_REQ_MOVE_PARTYINV_TO_ACCOUNT] = 31;
			_sizes[Op.CZ_PVP_COMMAND] = 23;
			_sizes[Op.CZ_REQ_CancelGachaCube] = 10;
			_sizes[Op.CZ_WAREHOUSE_TAKE_LIST] = 0;
			_sizes[Op.CZ_SAVE_AUTO_MACRO] = 0;
			_sizes[Op.CZ_REQUEST_LOAD_ITEM_BUY_LIMIT] = 10;
			_sizes[Op.CZ_AUTO_STATE] = 11;
			_sizes[Op.CZ_RUN_GAMEEXIT_TIMER] = 42;
			_sizes[Op.CZ_FIXED_NOTICE_SHOW] = 10;
			_sizes[Op.CZ_SAGE_SKILL_GO_FRIEND] = 90;
			_sizes[Op.CZ_REQUEST_CHANGE_NAME] = 66;
			_sizes[Op.ZC_HOLD_EXP_BOOK_TIME] = 25;
			_sizes[Op.CZ_HOLD_EXP_BOOK_TIME] = 14;
			_sizes[Op.CZ_SCREENSHOT_HASH] = 43;
			_sizes[Op.CZ_REQ_MOVE_TO_INDUN] = 18;
			_sizes[Op.CZ_CLEAR_INDUN_REG] = 10;
			_sizes[Op.CZ_REQ_REGISTER_TO_INDUN] = 14;
			_sizes[Op.CZ_REQ_GUILD_MEMBER_AUTHORITY] = 23;
			_sizes[Op.CZ_TPSHOP_RTPP_FOR_TEST] = 10;
			_sizes[Op.CZ_REQ_FORGERY] = 30;
			_sizes[Op.CZ_REQ_BUILD_FOODTABLE] = 79;
			_sizes[Op.CZ_REQ_UNDERSTAFF_ENTER_ALLOW] = 10;
			_sizes[Op.CZ_REQ_UNDERSTAFF_ENTER_ALLOW_WITH_PARTY] = 14;
			_sizes[Op.ZC_PLAY_PAIR_ANIMATION] = 34;
			_sizes[Op.ZC_ATTACH_TO_SLOT] = 22;
			_sizes[Op.CZ_REQ_FISHING] = 23;
			_sizes[Op.CZ_REQ_GET_FISHING_ITEM] = 10;
			_sizes[Op.ZC_PLAY_ATTACH_MODEL_ANIM] = 22;
			_sizes[Op.ZC_FISHING_ITEM_LIST] = 0;
			_sizes[Op.CZ_REQ_FISHING_RANK] = 78;
			_sizes[Op.ZC_ENABLE_ROTATE] = 75;
			_sizes[Op.CZ_SYNC_POS] = 26;
			_sizes[Op.CZ_DISCONNECT_REASON_FOR_LOG] = 0;
			_sizes[Op.CZ_LOAD_COMPLETE] = 10;
			_sizes[Op.ZC_LOAD_COMPLETE] = 6;

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
