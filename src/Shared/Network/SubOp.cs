// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

namespace Melia.Shared.Network
{
	public static class SubOp
	{
		/// <summary>
		/// Sub opcodes to be used with the BC_NORMAL packet.
		/// </summary>
		public static class Barrack
		{
			public const int SetPosition = 0x02;
			public const int SetBarrack = 0x05;
			public const int PostBoxState = 0x12;
			public const int TeamUI = 0x09;
			public const int ZoneTraffic = 0x0D;
			public const int Run = 0x0F;
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
			public const int BarrackSlotCount = 0x3C;
			public const int AccountUpdate = 0x4C;
			public const int Skill = 0x57;
			public const int ParticleEffect = 0x61;
			public const int SetSkillSpeed = 0x78;
			public const int SetHitDelay = 0x79;
			public const int SetSessionKey = 0x14E;
			public const int NGSCallback = 0x16D;
			public const int HatVisibleState = 0x181;

			//
			public const int UpdateSkillUI = 0x186;
			public const int AdventureBook = 0x194;
			public const int Unknown_1B4 = 0x1B4;
		}
	}
}
