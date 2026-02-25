using System.Text.RegularExpressions;

namespace Melia.Shared.Network
{
	public static class NormalOp
	{
		/// <summary>
		/// Sub-opcodes used with BC_NORMAL.
		/// </summary>
		public static class Barrack
		{
			public const int SetBarrackCharacter = 0x00;
			public const int SetPosition = 0x02;
			public const int SetBarrack = 0x05;
			public const int TeamUI = 0x0C;
			public const int ZoneTraffic = 0x0D;
			public const int StartGameFailed = 0x0F;
			public const int Run = 0x10;
			public const int Mailbox = 0x11;
			public const int MailboxState = 0x13;
			public const int MailUpdate = 0x14;
			public const int SetSessionKey = 0x15;
			public const int ClientIntegrityFailure = 0x18;
			public const int BarrackSlotCount = 0x19;
			public const int NGSCallback = 0x1A;
			public const int ThemaSuccess = 0x1B;
			public const int CharacterInfo = 0x1C;
		}

		/// <summary>
		/// Sub-opcodes used with ZC_NORMAL.
		/// </summary>
		public static class Zone
		{
			public const int TimeActionStart = 0x00;
			public const int TimeActionEnd = 0x01;
			public const int SkillProjectile = 0x06;
			public const int SkillItemToss = 0x09;
			public const int AttachEffect = 0x12;
			public const int ClearEffects = 0x13;
			public const int PlayEffect = 0x16;
			public const int PlayForceEffect = 0x17;
			public const int UpdateSkillEffect = 0x1F;
			public const int UpdateModelColor = 0x20;
			public const int FadeOut = 0x38;
			public const int BarrackSlotCount = 0x3C;
			public const int AttackCancel = 0x41;
			public const int Skill_42 = 0x42;
			public const int Skill_43 = 0x43;
			public const int Skill_45 = 0x45;
			public const int AccountProperties = 0x4D;
			public const int UnkDynamicCastStart = 0x4F;
			public const int UnkDynamicCastEnd = 0x50;
			public const int PadUpdate = 0x59;
			public const int PadSetMonsterAltitude = 0x5C;
			public const int ParticleEffect = 0x61;
			public const int PadMoveTo = 0x64;
			public const int Cutscene = 0x6B;
			public const int SetSkillSpeed = 0x77;
			public const int SetHitDelay = 0x78;
			public const int SkillCancelCancel = 0x7D;
			public const int SpinObject = 0x8A;
			public const int OpenBook = 0x9E;
			public const int Unknown_A1 = 0xA1;
			public const int LeapJump = 0xC2;
			public const int Unknown_DA = 0xDA;
			public const int ItemCollectionList = 0xDD;
			public const int UnlockCollection = 0xDF;
			public const int UpdateCollection = 0xE0;
			public const int PlayTextEffect = 0xE3;
			public const int Unknown_E4 = 0xE7;
			public const int Unknown_EF = 0xF2;
			public const int EnableUseSkillWhileOutOfBody = 0x10B;
			public const int EndOutOfBodyBuff = 0x10C;
			public const int ChannelTraffic = 0x12D;
			public const int SetGreetingMessage = 0x136;
			public const int Unk13E = 0x13E;
			public const int SetSessionKey = 0x14F;
			public const int ItemDrop = 0x152;
			public const int NGSCallback = 0x170;
			public const int HeadgearVisibilityUpdate = 0x17C;
			public const int UpdateSkillUI = 0x189;
			public const int AdventureBook = 0x197;
			public const int Unknown_19B = 0x19E;
			public const int PadSetModel = 0x1AB;
			public const int WigVisibilityUpdate = 0x1AC;
			public const int Unknown_1B4 = 0x1B7;
			public const int ActorRotate = 0x1BF;
			public const int SubWeaponVisibilityUpdate = 0x1C5;
		}

		/// <summary>
		/// Sub-opcodes used with SC_NORMAL.
		/// </summary>
		public static class Social
		{
			// Chat Server
			public const int LoginSuccess = 0x00;
			public const int Unknown_01 = 0x01;
			public const int Unknown_02 = 0x02;
			public const int AddMessage = 0x03;
			public const int MessageList = 0x04;
			public const int CreateRoom = 0x05;
			public const int Shout = 0x06;
			public const int SystemMessage = 0x07;
			public const int FriendInfo = 0x08;
			public const int FriendResponse = 0x09;
			public const int PartyMemberUpdate = 0x0C;
			public const int PartyInfo = 0x0D;
			public const int FriendRequested = 0x10;
			public const int FriendBlocked = 0x11;
			public const int Unknown_19 = 0x19;

			// Relation Server
			public const int RelationCount = 0x7D00;
			public const int RelatedSessions = 0x7D01;
			public const int RelationCountUpdate = 0x7D02;
			public const int RelationHistory = 0x7D03;
			public const int LikeNotify = 0x7D04;
			public const int LikeSuccess = 0x7D05;
			public const int UnlikeSuccess = 0x7D07;
			public const int LikeConfirm = 0x7D08;
			public const int LikedList = 0x7D09;
			public const int LikedMeList = 0x7D0A;
			public const int LikeCount = 0x7D0B;
			public const int LikeFailed = 0x7D0D;
		}

		/// <summary>
		/// Sub-opcodes used with SC_FROM_INTEGRATE.
		/// </summary>
		/// <remarks>
		/// The exact purpose of the integrate packets is currently only partially
		/// known, but they appear to be mostly related to inter-server processes,
		/// such as instanced dungeons, match-making, and PVP.
		/// </remarks>
		public static class Integrate
		{
			// These ops weren't actively maintained and might be outdated.

			public const int Unknown_01 = 0x01;
			public const int SpectateMatchInfo = 0x0E;
			public const int Unknown_14 = 0x14;
			public const int Unknown_19 = 0x19;
			public const int PvpRanking = 0x1C;
			public const int Unknown_1D = 0x1D;
		}
	}
}
