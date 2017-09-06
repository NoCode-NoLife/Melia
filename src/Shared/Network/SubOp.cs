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
			public const int TeamUI = 0x0B;
			public const int ZoneTraffic = 0x0C;
			public const int Run = 0x0F;
		}

		/// <summary>
		/// Sub opcodes to be used with the ZC_NORMAL packet.
		/// </summary>
		public static class Zone
		{
			public const int LevelUp = 0x11;
			public const int ClassLevelUp = 0x14;
			public const int Unkown_1c = 0x1C;
			public const int AccountUpdate = 0x4C;
			public const int Skill = 0x57;
			public const int ParticleEffect = 0x61;
			public const int SetSklSpeed = 0x78;
			public const int SetHitDelay = 0x79;
			public const int SetSessionKey = 0x14E;
		}
	}
}
