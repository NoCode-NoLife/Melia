namespace Melia.Shared.Game.Const
{
	/// <summary>
	/// Used in BC_MESSAGE.
	/// </summary>
	public enum MsgType : byte
	{
		Text = 0,
		UsernameOrPasswordIncorrect1 = 1, // Username?
		UsernameOrPasswordIncorrect2 = 2, // Password?
		DoubleLogin = 3, // Disconnects gracefully
		WrongVerificationCode = 4,
		ServerVersionDoesNotMatch = 5,
		NameAlreadyExists = 6,
		CannotCreateCharacter = 7,
		CharacterNameTooShort = 8, // "The character name must be at least %s characters.
								   // 9
		CannotDeleteCharacter1 = 10,
		CreateCharFail = 11,
		CharacterNameTooLong = 12, // "The character name must be less than %s characters.
		CannotDeleteCharacter2 = 13,
		TeamDoesNotExist = 14,
		CharacterDoesNotExist = 15,
		CannotStartGame = 16,
		NewJobAdded = 17,
		// 18
		TeamMemberCapExceeded = 19,
		InsufficientCharacterPoints = 20,
		AccountBlocked1 = 21,
		AccountBlocked2 = 22,
		InventoryFull = 23,
		StartingMapNotAvailable = 24,
		UnableToDeletePartyLeader = 25,
		NotCBTUser = 26,
		RatedEsrbTeen = 27,
		InvalidIpf = 28, // Client IPF files are invalid.

		// ...
	}

	/// <summary>
	/// Constant strings that may be sent with the packet `ZC_ADDON_MSG`.
	/// </summary>
	public static class AddonMessage
	{
		/// <summary>
		/// Used for quitting the game, transitioning from the zone to the barrack, and possibly other reasons.
		/// </summary>
		public const string EXPIREDITEM_ALERT_OPEN = "EXPIREDITEM_ALERT_OPEN";

		public const string RESET_STAT_UP = "RESET_STAT_UP";
		public const string RESET_SKL_UP = "RESET_SKL_UP";
		public const string FAIL_SHOP_BUY = "FAIL_SHOP_BUY";

		public const string RESET_ABILITY_UP = "RESET_ABILITY_UP";
		public const string SUCCESS_BUY_ABILITY_POINT = "SUCCESS_BUY_ABILITY_POINT";
		public const string RESET_ABILITY_ACTIVE = "RESET_ABILITY_ACTIVE";

		/// <summary>
		/// Sent when successfully an ability is learned
		/// </summary>
		public const string SUCCESS_LEARN_ABILITY = "SUCCESS_LEARN_ABILITY";

		/// <summary>
		/// Used for ability point update
		/// </summary>
		public const string UPDATE_ABILITY_POINT = "UPDATE_ABILITY_POINT";

		/// <summary>
		/// Opens the event banner.
		/// </summary>
		public const string DO_OPEN_EVENTBANNER_UI = "DO_OPEN_EVENTBANNER_UI";
		public const string SET_CHAT_MACRO_DEFAULT = "SET_CHAT_MACRO_DEFAULT";
		public const string FISHING_SUCCESS_COUNT = "FISHING_SUCCESS_COUNT"; // Parameter: 0

		/// <summary>
		/// The UI for first time players showing how to move using the keyboard.
		/// </summary>
		public const string KEYBOARD_TUTORIAL = "KEYBOARD_TUTORIAL";
		public const string MINIMIZED_TUTORIALNOTE_EFFECT_CHECK = "MINIMIZED_TUTORIALNOTE_EFFECT_CHECK"; // Parameter: guide_1

		public const string ENABLE_PCBANG_SHOP = "ENABLE_PCBANG_SHOP";

		public const string PARTY_UPDATE = "PARTY_UPDATE";
		public const string UPDATE_GUILD_MILEAGE = "UPDATE_GUILD_MILEAGE";
		public const string UPDATE_ATTENDANCE_REWARD = "UPDATE_ATTENDANCE_REWARD";

		/// <summary>
		/// The UI for new entries in adventure book
		/// </summary>
		public const string ADVENTURE_BOOK_NEW = "ADVENTURE_BOOK_NEW"; // Parameter: @dicID_^*$ETC_20150317_000001$*^
		public const string SET_COIN_GET_GAUGE = "SET_COIN_GET_GAUGE";

		/// <summary>
		/// Opens the TP shop UI Help
		/// </summary>
		public const string TP_SHOP_UI_OPEN = "TP_SHOP_UI_OPEN";


		/// <summary>
		/// Sent when reading a new collection
		/// </summary>
		public const string UPDATE_READ_COLLECTION_COUNT = "UPDATE_READ_COLLECTION_COUNT";

		/// <summary>
		/// Item gaining exp
		/// </summary>
		public const string ITEM_EXP_START = "ITEM_EXP_START";

		/// <summary>
		/// Stop Item gaining exp
		/// </summary>
		public const string ITEM_EXP_STOP = "ITEM_EXP_STOP";

		/// <summary>
		/// Item gaining exp has ended.
		/// </summary>
		public const string ITEM_EXPUP_END = "ITEM_EXPUP_END";
	}

	public static class SystemMessage
	{
		public const int PERSONAL_HOUSE_LEVEL_10_REQUIRED = 815111;
	}

	/// <summary>
	/// Constant strings sent with `BC_NORMAL_Run`.
	/// </summary>
	public static class BarrackMessage
	{
		public const string THEMA_BUY_SUCCESS = "THEMA_BUY_SUCCESS";
	}
}
