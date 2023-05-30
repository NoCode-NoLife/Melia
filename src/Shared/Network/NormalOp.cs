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
			public const int Run = 0x10;
			public const int Message = 0x11;
			public const int PostBoxState = 0x12;
			public const int SetSessionKey = 0x14;
			public const int ClientIntegrityFailure = 0x18;
			public const int BarrackSlotCount = 0x19;
			public const int NGSCallback = 0x1A;
			public const int UnkThema1 = 0x1B;
			public const int CharacterInfo = 0x1C;
		}

		/// <summary>
		/// Sub-opcodes used with ZC_NORMAL.
		/// </summary>
		public static class Zone
		{
			public const int Unknown_06 = 0x06;
			public const int LevelUp = 0x12;
			public const int ClassLevelUp = 0x15;
			public const int Skill_16 = 0x16;
			public const int Unkown_1D = 0x1F;
			public const int FadeOut = 0x38;
			public const int BarrackSlotCount = 0x3C;
			public const int AttackCancel = 0x41;
			public const int AccountUpdate = 0x4C;
			public const int Skill_4E = 0x4E;
			public const int Skill = 0x57;
			public const int ParticleEffect = 0x61;
			public const int Cutscene = 0x6B;
			public const int SetSkillSpeed = 0x77;
			public const int SetHitDelay = 0x78;
			public const int Unknown_A1 = 0xA1;
			public const int Unknown_DA = 0xDA;
			public const int SkillParticleEffect = 0xE0;
			public const int Unknown_E4 = 0xE4;
			public const int Unknown_EF = 0xF0;
			public const int ChannelTraffic = 0x12D;
			public const int SetGreetingMessage = 0x136;
			public const int SetSessionKey = 0x14F;
			public const int ItemDrop = 0x152;
			public const int NGSCallback = 0x170;
			public const int HatVisibleState = 0x184;
			public const int UpdateSkillUI = 0x189;
			public const int AdventureBook = 0x197;
			public const int Unknown_19B = 0x19E;
			public const int Unknown_1B4 = 0x1B7;
		}

		/// <summary>
		/// Sub-opcodes used with SC_NORMAL.
		/// </summary>
		public static class Social
		{
			public const int Unknown_00 = 0x00;
			public const int Unknown_02 = 0x02;
			public const int Chat = 0x03;
			public const int ChatRoomMessage = 0x04;
			public const int ChatLog = 0x05;
			public const int SystemMessage = 0x07;
			public const int FriendInfo = 0x08;
			public const int FriendResponse = 0x09;
			public const int Buff_0C = 0x0C;
			public const int PartyInfo = 0x0D;
			public const int FriendRequested = 0x10;
			public const int FriendBlocked = 0x11;
			public const int Unknown_19 = 0x19;
		}
	}
}
