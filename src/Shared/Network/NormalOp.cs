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
			public const int SkillProjectile = 0x06;
			public const int AttachEffect = 0x12;
			public const int ClearEffects = 0x13;
			public const int PlayEffect = 0x16;
			public const int MoveEffects = 0x17;
			public const int UpdateSkillEffect = 0x1F;
			public const int FadeOut = 0x38;
			public const int BarrackSlotCount = 0x3C;
			public const int AttackCancel = 0x41;
			public const int Skill_45 = 0x45;
			public const int AccountUpdate = 0x4C;
			public const int Skill_4E = 0x4E;
			public const int Skill = 0x57;
			public const int Skill_6 = 0x6;
			public const int Skill_4F = 0x4F;
			public const int Skill_50 = 0x50;
			public const int Skill_E3 = 0xE3;
			public const int Skill_58 = 0x58;
			public const int GroundEffect = 0x59;
			public const int Skill_5C = 0x5C;
			public const int Skill_6D = 0x6D;
			public const int Skill_7D = 0x7D;
			public const int Skill_88 = 0x88;
			public const int Skill_90 = 0x90;
			public const int Skill_99 = 0x99;
			public const int Skill_C8 = 0xC8;
			public const int Skill_40 = 0x40;
			public const int Skill_122 = 0x122;
			public const int Skill_17A = 0x17A;
			public const int ParticleEffect = 0x61;
			public const int Cutscene = 0x6B;
			public const int SetSkillSpeed = 0x77;
			public const int SetHitDelay = 0x78;
			public const int Unknown_A1 = 0xA1;
			public const int LeapJump = 0xC2;
			public const int Unknown_DA = 0xDA;
			public const int SkillParticleEffect = 0xE0;
			public const int PlayTextEffect = 0xE3;
			public const int Unknown_E4 = 0xE4;
			public const int Unknown_EF = 0xF0;
			public const int ChannelTraffic = 0x12D;
			public const int SetGreetingMessage = 0x136;
			public const int SetSessionKey = 0x14F;
			public const int ItemDrop = 0x152;
			public const int NGSCallback = 0x170;
			public const int HeadgearVisibilityUpdate = 0x17C;
			public const int UpdateSkillUI = 0x189;
			public const int AdventureBook = 0x197;
			public const int Unknown_19B = 0x19E;
			public const int WigVisibilityUpdate = 0x1AC;
			public const int Unknown_1B4 = 0x1B7;
			public const int SubWeaponVisibilityUpdate = 0x1C5;
		}
	}
}
