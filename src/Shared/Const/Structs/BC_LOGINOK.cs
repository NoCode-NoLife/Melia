// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System.Runtime.InteropServices;

namespace Melia.Shared.Const.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
	public struct BC_LOGINOK
	{
		// _BYTE gap0[6];
		// _WORD word6;
		// _DWORD dword8;
		// _DWORD dwordC;
		// char char10;
		// _BYTE gap11[32];
		// _DWORD dword31;
		// char char35;

		//public short Op;
		//public int Checksum;
		public short UnkShort;
		public long SessionId;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public string UnkString1; // Account name or an str session key?
		public int UnkInt;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string UnkString2; // Sent to zone at the end of CZ_CONNECT
	}
}
