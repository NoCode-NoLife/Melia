using System.Runtime.InteropServices;

namespace Melia.Shared.Const.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
	public struct CB_LOGIN
	{
		//public short Op;
		//public int Index;
		//public int Checksum;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public string AccountName;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public string Password;
		public byte UnkByte1;
		public byte UnkByte2;
		public int Ip;
	}
}
