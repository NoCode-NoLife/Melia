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
		public void CZ_CONNECT(ChannelConnection conn, Packet packet)
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
			var characterId = packet.GetLong();
			var accountName = packet.GetString(); // ?
			var unkByte1 = packet.GetByte();
			var unkShort2 = packet.GetShort(); // 3276
			var unkShort3 = packet.GetShort(); // 336
			var unkShort4 = packet.GetShort(); // 3276
			var unkShort5 = packet.GetShort(); // 8972
			// ...

			conn.Account = ChannelServer.Instance.Database.GetAccount(accountName);
			conn.SelectedCharacter = conn.Account.GetCharacterById(characterId);

			//packet = new Packet(Op.ZC_CONNECT_OK);
			//packet.PutEmptyBin(500);
			//conn.Send(packet);

			//packet = new Packet(Op.ZC_CONNECT_FAILED);
			//packet.PutString("test",12);
			//conn.Send(packet);
			//conn.Kill();

			//packet = new Packet(Op.ZC_START_GAME); // Size: 26 (20)
			//packet.PutBinFromHex("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 ");
			//conn.Send(packet);

			//packet = new Packet(Op.ZC_MOVE_ZONE);
			//packet.PutByte(1);
			//conn.Send(packet);

			packet = new Packet(Op.ZC_CONNECT_OK);
			packet.PutByte(0);
			packet.PutInt(0);
			packet.PutByte(0);
			packet.PutEmptyBin(10);

			packet.PutShort(0); // count v ?
			//packet.PutEmptyBin(0);

			packet.AddCharacter(conn.SelectedCharacter);

			conn.Send(packet);
		}

		// [FE 0B] [01 00 00 00] [08 01 00 00] | F3 C0 A9 C2 72 F2
		[PacketHandler(Op.CZ_GAME_READY)]
		public void CZ_GAME_READY(ChannelConnection conn, Packet packet)
		{
			var characters = conn.Account.GetCharacters();

			packet = new Packet(Op.ZC_START_GAME); // Size: 26 (20)
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			conn.Send(packet);

			//packet = new Packet(Op.ZC_ENTER_PC); // Size: 370 (364)
			//packet.AddCharacter(conn.SelectedCharacter);
			//conn.Send(packet);
		}

		// [59 0C] [02 00 00 00] [65 00 00 00] 02 00 00 00 00 00 00 00 | E7 B1 5E C8 25 CB	
		[PacketHandler(Op.CZ_CAMPINFO)]
		public void CZ_CAMPINFO(ChannelConnection conn, Packet packet)
		{
			var sessionId = packet.GetLong();

			packet = new Packet(Op.ZC_CAMPINFO); // Size: 18 (12)
			packet.PutEmptyBin(12);
			conn.Send(packet);
		}
	}
}
