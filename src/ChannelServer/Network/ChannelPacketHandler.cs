using Melia.Shared.Const;
using Melia.Shared.Database;
using Melia.Shared.Network;
using Melia.Shared.Util;
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
		/// 
		///  struct header packet_head;
		///  short len; //? 1059
		///  short w1;
		///  int64 id;
		///  int d1;
		///  int d2;
		///  char str[33];
		///  int d3;
		///  short w2;
		///  byte b1;
		///  byte b2;
		///  byte b3;
		/// </example>
		[PacketHandler(Op.CZ_CONNECT)]
		public void CZ_CONNECT(ChannelConnection conn, Packet packet)
		{
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

			// TODO: Check session id or something.

			// Get account
			conn.Account = ChannelServer.Instance.Database.GetAccount(accountName);
			if (conn.Account == null)
			{
				Log.Warning("Stopped attempt to login with invalid account '{0}'. Closing connection.", accountName);
				conn.Close();
				return;
			}

			// Get character
			var character = ChannelServer.Instance.Database.GetCharacter(conn.Account.Id, characterId);
			if (character == null)
			{
				// Don't punish, could be used to auto-ban other people.
				Log.Warning("User '{0}' tried to use a non-existing character, '{1}'. Closing connection.", accountName, characterId);
				conn.Close();
				return;
			}

			conn.SelectedCharacter = character;
			conn.LoggedIn = true;

			// Response
			packet = new Packet(Op.ZC_CONNECT_OK);
			packet.PutByte(0);
			packet.PutInt(0);
			packet.PutByte(0);
			packet.PutEmptyBin(10);

			packet.PutShort(0); // count v ?
			//packet.PutEmptyBin(0);

			packet.PutInt(character.WorldId);
			packet.PutInt(0);

			// CommanderInfo (237)
			{
				packet.PutString(character.Name, 65);
				packet.PutString(character.TeamName, 64);
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

			packet.PutEmptyBin(3);
			packet.PutFloat(character.X);
			packet.PutFloat(character.Y);
			packet.PutFloat(character.Z);
			packet.PutInt(100);  // Exp
			packet.PutInt(1000); // MaxExp
			packet.PutInt(0);

			packet.PutLong(character.Id);

			//packet.PutEmptyBin(32);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutInt(500);   // Min HP
			packet.PutInt(1000);  // Max HP
			packet.PutShort(50);  // Min SP
			packet.PutShort(100); // Max SP
			packet.PutInt(10000); // STA
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
			var character = conn.SelectedCharacter;

			//float float6;
			//float floatA;
			//float floatE;
			//_QWORD qword12;
			packet = new Packet(Op.ZC_START_GAME); // Size: 26 (20)
			packet.PutFloat(1); // Affects the speed of everything happening in the client o.o
			packet.PutFloat(1);
			packet.PutFloat(1);
			packet.PutLong(DateTime.Now.Add(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now)).ToFileTime());
			conn.Send(packet);

			// Triggers CZ_MOVE_ZONE_OK response from client, doesn't unstuck.
			//packet = new Packet(Op.ZC_MOVE_ZONE);
			//packet.PutByte(0);
			//conn.Send(packet);

			packet = new Packet(Op.ZC_MYPC_ENTER); // Size: 18 (12)
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			conn.Send(packet);

			packet = new Packet(Op.ZC_QUICK_SLOT_LIST);
			packet.PutInt(0);
			//packet.PutByte(0);
			conn.Send(packet);

			packet = new Packet(Op.ZC_MOVE_SPEED); // Size: 18 (12)
			packet.PutInt(character.WorldId);
			packet.PutFloat(character.GetSpeed());
			packet.PutFloat(0); // ?
			conn.Send(packet);

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
			// Makes the client connect to the given zone server
			//packet = new Packet(Op.ZC_MOVE_ZONE_OK); // Size: 57 (51)
			//packet.PutInt(0);
			//packet.PutInt(0x0100007F); // 127.0.0.1
			//packet.PutInt(2001); // Port
			//packet.PutInt(2088);
			//packet.PutFloat(30); // Camera X angle
			//packet.PutFloat(0); // Camera Y angle
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

		/// <summary>
		/// Sent when chatting publically.
		/// </summary>
		/// <remarks>
		/// Sent together with CZ_CHAT_LOG.
		/// </remarks>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [1E 0C] [08 00 00 00] [98 01 00 00] 14 00 74 65 73 74 31 32 33 00 |? 32 B8 E6 39
		/// </example>
		[PacketHandler(Op.CZ_CHAT)]
		public void CZ_CHAT(ChannelConnection conn, Packet packet)
		{
			var len = packet.GetShort(); // length of dynamic packet without length from header
			var msg = packet.GetString();

			var character = conn.SelectedCharacter;

			Log.Debug("CZ_CHAT_LOG - {0}: {1}", character.Name, msg);

			if (!ChannelServer.Instance.GmCommands.Process(conn, character, msg))
			{
				packet = new Packet(Op.ZC_CHAT);
				// This makes the message appear for yourself, but the character
				// name and portrait in the chat log are missing.
				//packet.PutEmptyBin(152);
				packet.PutInt(character.WorldId);
				packet.PutInt(0);
				packet.PutEmptyBin(152 - 8);
				packet.PutString(msg);
				conn.Send(packet);

				//packet = new Packet(Op.ZC_SYSTEM_MSG);
				//packet.PutInt(0);
				//packet.PutByte(1); // 0 = client message, using the above as id?
				//packet.PutByte(0);
				//// ...
				//conn.Send(packet);
			}
		}

		/// <summary>
		/// Sent when chatting.
		/// </summary>
		/// <remarks>
		/// Sent together with CZ_CHAT.
		/// When whispering only this one is sent?
		/// </remarks>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [1F 0C] [09 00 00 00] [98 01 00 00] 14 00 74 65 73 74 31 32 33 00 |? 53 82 83 79
		/// </example>
		[PacketHandler(Op.CZ_CHAT_LOG)]
		public void CZ_CHAT_LOG(ChannelConnection conn, Packet packet)
		{
			var len = packet.GetShort();
			var msg = packet.GetString();

			Log.Debug("CZ_CHAT_LOG - Chat, {0}: {1}", conn.SelectedCharacter.Name, msg);
		}

		/// <summary>
		/// Sent when choosing Select Character.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [01 0C] [1F 00 00 00] [12 00 00 00] 00 | 63 D6 14 F1 60
		/// </example>
		[PacketHandler(Op.CZ_MOVE_BARRACK)]
		public void CZ_MOVE_BARRACK(ChannelConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte();

			packet = new Packet(Op.ZC_MOVE_BARRACK);
			conn.Send(packet);
		}

		/// <summary>
		/// Sent when choosing Logout.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [00 0C] [0A 00 00 00] [06 00 00 00] 00 | 63 D6 14 F1 60
		/// </example>
		[PacketHandler(Op.CZ_LOGOUT)]
		public void CZ_LOGOUT(ChannelConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte();

			packet = new Packet(Op.ZC_LOGOUT_OK);
			conn.Send(packet);
		}

		/// <summary>
		/// Sent when character jumps.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [0B 0C] [33 4A 00 00] [6E 00 00 00] 00 | 7B 0D 5C 04 70
		/// </example>
		[PacketHandler(Op.CZ_JUMP)]
		public void CZ_JUMP(ChannelConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte();

			var character = conn.SelectedCharacter;

			packet = new Packet(Op.ZC_JUMP);
			packet.PutInt(character.WorldId);
			packet.PutFloat(character.GetJumpStrength());
			packet.PutInt(character.GetJumpType());
			packet.PutByte(1);  // 1 or 0
			conn.Send(packet);
		}
	}
}
