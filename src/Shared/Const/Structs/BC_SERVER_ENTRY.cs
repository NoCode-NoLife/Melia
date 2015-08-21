// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System.Runtime.InteropServices;

namespace Melia.Shared.Const.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
	public struct BC_SERVER_ENTRY
	{
		//DWORD IP1
		//DWORD IP2
		//WORD PORT1?
		//WORD PORT2?

		//public short Op;
		//public int Checksum;
		public int Ip1;
		public int Ip2;
		public ushort Port1;
		public ushort Port2;
	}
}
