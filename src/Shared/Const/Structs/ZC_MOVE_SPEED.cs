// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System.Runtime.InteropServices;

namespace Melia.Shared.Const.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
	public struct ZC_MOVE_SPEED
	{
		public int WorldCharacterId;
		public float RunningSpeed;
		public float UnkFloat;
	}
}
