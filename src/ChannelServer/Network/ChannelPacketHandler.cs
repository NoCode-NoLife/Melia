using Melia.Shared.Const;
using Melia.Shared.Database;
using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
using Melia.Shared.Util;
using Melia.Shared.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Melia.Channel.Network
{
	public class ChannelPacketHandler : PacketHandler<ChannelConnection>
	{
		public static readonly ChannelPacketHandler Instance = new ChannelPacketHandler();

		/// <summary>
		/// Sent when clicking [Enter] on login screen.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [03 00] [00 00 00 00] [0A 06 00 00] 61 73 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 78 15 69 6E CB F1 C9 6E 68 94 B7 79 45 6D 33 0E 00 01 C0 A8 B2 14 52 93 3A 5C F0 16 79
		/// </example>
		//[PacketHandler(Op.CB_LOGIN)]
		//public void CB_LOGIN(LoginConnection conn, Packet packet)
		//{
		//	var username = packet.GetString(33);
		//	var password = packet.GetBinAsHex(16); // MD5? I'm disappointed, IMC =|
		//	var unkByte1 = packet.GetByte();
		//	var unkByte2 = packet.GetByte();
		//	var ip = packet.GetInt();

		//	// Create new account
		//	if (username.StartsWith("new__") || username.StartsWith("new//"))
		//	{
		//		username = username.Substring("new__".Length);
		//		if (!LoginServer.Instance.Database.AccountExists(username))
		//			LoginServer.Instance.Database.CreateAccount(username, password);
		//	}

		//	// Check username and password
		//	if (!LoginServer.Instance.Database.CheckAccount(username, password))
		//	{
		//		Send.BC_MESSAGE(conn, MsgType.UsernameOrPasswordIncorrect1);
		//		conn.Kill();
		//		return;
		//	}

		//	conn.Account = LoginServer.Instance.Database.GetAccount(username);

		//	Log.Info("User '{0}' logged in.", conn.Account.Name);

		//	Send.BC_LOGINOK(conn);
		//}
	}
}
