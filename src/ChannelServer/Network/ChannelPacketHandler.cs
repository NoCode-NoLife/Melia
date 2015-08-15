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
		/// Sent after connecting to channel.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [Debug] - Recv: [B9 0B] [00 00 00 00] [E4 66 00 00] 23 04 00 00 02 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 66 6F 6F 62 61 72 00 00 CC 0C 50 01 CC 0C 23 74 ...
		/// </example>
		[PacketHandler(Op.CZ_CONNECT)]
		public void CZ_LOGIN(ChannelConnection conn, Packet packet)
		{
			// struct cz_login
			// {
			//     struct header packet_head;
			//     short len; //? 1059
			//     short w1;
			//     int64 id;
			//     int d1;
			//     int d2;
			//     char str[33];
			//     int d3;
			//     short w2;
			//     byte b1;
			//     byte b2;
			//     byte b3;
			var len = packet.GetShort(); // ? 1059
			var unkShort1 = packet.GetShort();
			var sessionId = packet.GetLong();
			var unkInt1 = packet.GetInt();
			var unkInt2 = packet.GetInt();
			var accountName = packet.GetString(); // ?
			var unkByte1 = packet.GetByte();
			var unkShort2 = packet.GetShort(); // 3276
			// ...

			conn.Account = ChannelServer.Instance.Database.GetAccount(accountName);

			//packet = new Packet(Op.ZC_CONNECT_OK);
			//packet.PutEmptyBin(500);
			//conn.Send(packet);

			var characters = conn.Account.GetCharacters();

			packet = new Packet(Op.ZC_CONNECT_OK);
			packet.PutByte(1);
			packet.PutInt(0);
			packet.PutByte(0);
			packet.PutEmptyBin(10);

			packet.PutShort(0); // count v ?
			//packet.PutEmptyBin(0);

			packet.AddCharacter(characters[0]);

			conn.Send(packet);
		}
	}
}
