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
			public const int SetBarrack = 0x04;
			public const int PostBoxState = 0x12;
			public const int TeamUI = 0x0B;
			public const int ZoneTraffic = 0x0C;
			public const int Run = 0x0F;
			public const int SetSessionKey = 0x14;
			public const int ClientIntegrityFailure = 0x18;
			public const int BarrackSlotCount = 0x19;
			public const int NGSCallback = 0x1A;
		}

		/// <summary>
		/// Sub opcodes to be used with the ZC_NORMAL packet.
		/// </summary>
		public static class Zone
		{
			public const int LevelUp = 0x11;
			public const int ClassLevelUp = 0x14;
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
			public const int UpdateSkillUI = 0x188;
		}
	}
}
