// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System.Runtime.InteropServices;

namespace Melia.Shared.Const.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
	public struct BC_START_GAMEOK
	{
		//public short Op;
		//public int Checksum;
		public int field_0; //?
		public int serverIP;
		public int port;
		public int zoneID; //?
		public char channel; //?
		public long ID; //?
		public bool bConnect;
		public byte b3;
	}
}
