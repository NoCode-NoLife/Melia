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
		/// [B9 0B] [00 00 00 00] [E4 66 00 00] 23 04 00 00 02 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 66 6F 6F 62 61 72 00 00 CC 0C 50 01 CC 0C 23 74 ...
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
			var character = conn.SelectedCharacter;

			//packet = new Packet(Op.ZC_CONNECT_OK);
			//packet.PutEmptyBin(500);
			//conn.Send(packet);

			//packet = new Packet(Op.ZC_CONNECT_FAILED);
			//packet.PutString("test",12);
			//conn.Send(packet);
			//conn.Kill();

			packet = new Packet(Op.ZC_CONNECT_OK);
			packet.PutByte(0);
			packet.PutInt(0);
			packet.PutByte(0);
			packet.PutEmptyBin(10);

			packet.PutShort(0); // count v ?
			//packet.PutEmptyBin(0);

			packet.PutInt(100); // not 0!
			packet.PutInt(0);

			// CommanderInfo (237)
			{
				packet.PutString(character.Name, 65);
				packet.PutString("", 64);
				packet.PutEmptyBin(7);
				packet.PutLong(0);
				packet.PutShort(character.Stance);
				packet.PutShort(0);
				packet.PutShort((short)character.Job);
				packet.PutByte((byte)character.Gender);
				packet.PutByte(0);
				packet.PutInt(character.Level);

				// Items
				// Defaults are literally empty items, NoHat, NoWeapon, etc.
				packet.PutInt(0x00000002); // Hat
				packet.PutInt(0x00000002); // Hat
				packet.PutInt(0x00000004); // Outer
				packet.PutInt(0x00000008); // Shirt
				packet.PutInt(0x00000006); // Gloves
				packet.PutInt(0x00000007); // Boots
				packet.PutInt(0x00002710); // Helmet
				packet.PutInt(0x00002AF8); // Armband
				packet.PutInt(0x0098967C); // Weapon
				packet.PutInt(0x0098967C); // Weapon
				packet.PutInt(0x00000004); // Outer
				packet.PutInt(0x00000009); // Ring
				packet.PutInt(0x00000009); // Ring
				packet.PutInt(0x00000004); // Outer
				packet.PutInt(0x00000009); // Ring
				packet.PutInt(0x00000009); // Ring
				packet.PutInt(0x00000009); // Ring
				packet.PutInt(0x00000009); // Ring
				packet.PutInt(0x00000009); // Ring
				packet.PutInt(0x0000000A); // Neck

				packet.PutByte(character.Hair);
			}

			//packet.PutEmptyBin(27);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);

			packet.PutLong(character.Id);

			//packet.PutEmptyBin(32);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0); // 
			packet.PutByte(0); // if set to something a movement and move stop
			packet.PutByte(0); // packet are sent on loading stuck, no other
			packet.PutByte(0); // reaction to other bytes being anything but 0
			packet.PutByte(0); // 
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);

			packet.PutByte(0);
			packet.PutEmptyBin(3);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);

			conn.Send(packet);
		}

		/// <summary>
		/// Sent mid-loading, after pc's enter world.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [FE 0B] [01 00 00 00] [08 01 00 00] | F3 C0 A9 C2 72 F2
		/// </example>
		[PacketHandler(Op.CZ_GAME_READY)]
		public void CZ_GAME_READY(ChannelConnection conn, Packet packet)
		{
			var characters = conn.Account.GetCharacters();

			//float float6;
			//float floatA;
			//float floatE;
			//_QWORD qword12;
			packet = new Packet(Op.ZC_START_GAME); // Size: 26 (20)
			packet.PutFloat(1);
			packet.PutFloat(2);
			packet.PutFloat(3);
			packet.PutLong(DateTime.Now.ToFileTime());
			conn.Send(packet);

			// Triggers CZ_MOVE_ZONE_OK response from client, doesn't unstuck.
			//packet = new Packet(Op.ZC_MOVE_ZONE);
			//packet.PutByte(0);
			//conn.Send(packet);

			//packet = new Packet(Op.ZC_ENTER_PC); // Size: 370 (364)
			//packet.AddCharacter(conn.SelectedCharacter);
			//conn.Send(packet);
		}

		/// <summary>
		/// Sent as response to ZC_MOVE_ZONE with a 0 byte.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [BC 0B] [03 00 00 00] [C4 00 00 00] | FC 11 D0 A5 72 F2
		/// </example>
		[PacketHandler(Op.CZ_MOVE_ZONE_OK)]
		public void CZ_MOVE_ZONE_OK(ChannelConnection conn, Packet packet)
		{
			// _BYTE gap0[6];
			// _DWORD dword6;
			// _DWORD dwordA;
			// _DWORD dwordE;
			// _DWORD dword12;
			// float float16;
			// float float1A;
			// _BYTE gap1E[26];
			// _BYTE byte38;
			// Makes the client connect to the given zone server
			//packet = new Packet(Op.ZC_MOVE_ZONE_OK); // Size: 57 (51)
			//packet.PutInt(0);
			//packet.PutInt(0x0100007F); // 127.0.0.1
			//packet.PutInt(2001); // Port
			//packet.PutInt(2088);
			//packet.PutFloat(0);
			//packet.PutFloat(0);
			//packet.PutByte(0);
			//packet.PutByte(0);
			//conn.Send(packet);
		}

		/// <summary>
		/// Sent at the end of the loading screen.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [59 0C] [02 00 00 00] [65 00 00 00] 02 00 00 00 00 00 00 00 | E7 B1 5E C8 25 CB	
		/// </example>
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
