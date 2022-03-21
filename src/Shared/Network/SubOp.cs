namespace Melia.Shared.Network
{
	public static class SubOp
	{
		/// <summary>
		/// Sub opcodes to be used with the BC_NORMAL packet.
		/// </summary>
		public static class Barrack
		{
			public const int SetBarrackCharacter = 0x00;
			public const int SetPosition = 0x02;
			public const int SetBarrack = 0x05;
			public const int PostBoxState = 0x12;
			public const int TeamUI = 0x0C;
			public const int ZoneTraffic = 0x0D;
			public const int Run = 0x10;
			public const int Message = 0x11;
			public const int SetSessionKey = 0x14;
			public const int ClientIntegrityFailure = 0x18;
			public const int BarrackSlotCount = 0x19;
			public const int NGSCallback = 0x1A;
			public const int CharacterInfo = 0x1C;
		}

		/// <summary>
		/// Sub opcodes to be used with the ZC_NORMAL packet.
		/// </summary>
		public static class Zone
		{
			public const int LevelUp = 0x12;
			public const int ClassLevelUp = 0x15;
			public const int Unkown_1D = 0x1D;
			public const int FadeOut = 0x38;
			public const int BarrackSlotCount = 0x3C;
			public const int AccountUpdate = 0x4C;
			public const int Skill = 0x57;
			public const int ParticleEffect = 0x61;
			public const int SetSessionKey = 0x14F;
			public const int ItemDrop = 0x150;
			public const int NGSCallback = 0x16E;
			public const int HatVisibleState = 0x182;

			//
			public const int Unknown_06 = 0x06;
			public const int Skill_16 = 0x16;
			public const int AttackCancel = 0x41;
			public const int Skill_4E = 0x4E;
			public const int SetSkillSpeed = 0x77;
			public const int SetHitDelay = 0x78;
			public const int Unknown_A1 = 0xA1;
			public const int Unknown_DA = 0xDA;
			public const int SkillParticleEffect = 0xE0;
			public const int Unknown_E4 = 0xE4;
			public const int Unknown_EF = 0xF0;
			public const int Unknown_Map_12A = 0x12B;
			public const int SetGreetingMessage = 0x136;
			public const int UpdateSkillUI = 0x187;
			public const int AdventureBook = 0x195;
			public const int Unknown_19B = 0x19C;
			public const int Unknown_1B4 = 0x1B5;
		}
	}
}
