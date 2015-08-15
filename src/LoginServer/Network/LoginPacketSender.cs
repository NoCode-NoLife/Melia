using Melia.Shared.Network.Helpers;
using Melia.Shared.Const;
using Melia.Shared.Network;
using Melia.Shared.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Login.Network
{
	public static class Send
	{
		public static void BC_LOGINOK(LoginConnection conn)
		{
			var packet = new Packet(Op.BC_LOGINOK);
			packet.PutShort(0);
			packet.PutLong(conn.SessionId);
			packet.PutString(conn.Account.Name, 17);
			packet.PutInt(0); // hotkey?
			packet.PutBin(new byte[80]);

			conn.Send(packet);
		}

		public static void BC_LOGOUTOK(LoginConnection conn)
		{
			var packet = new Packet(Op.BC_LOGOUTOK);

			LoginServer.Instance.Database.SaveAccount(conn.Account);

			conn.Send(packet);
		}

		public static void BC_COMMANDER_LIST(LoginConnection conn)
		{
			var characters = conn.Account.GetCharacters();

			var packet = new Packet(Op.BC_COMMANDER_LIST);
			packet.PutLong(conn.SessionId);
			packet.PutByte(0);
			packet.PutByte((byte)characters.Length);
			packet.PutString(conn.Account.TeamName, 64);

			packet.PutShort(0); // count v ?
			//packet.PutEmptyBin(0);

			foreach (var character in characters)
			{
				packet.AddCharacter(character);

				// Item descriptions, short->length
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);
				packet.PutShort(0);

				packet.PutShort(0);
			}

			conn.Send(packet);
		}

		public static void BC_COMMANDER_CREATE(LoginConnection conn, Character character)
		{
			var packet = new Packet(Op.BC_COMMANDER_CREATE);
			packet.AddCharacter(character);

			conn.Send(packet);
		}

		public static void BC_BARRACKNAME_CHANGE(LoginConnection conn, TeamNameChangeResult result)
		{
			var response = new Packet(Op.BC_BARRACKNAME_CHANGE);
			response.PutByte(result == TeamNameChangeResult.Okay);
			response.PutInt((int)result);
			response.PutString(conn.Account.TeamName, 64);

			conn.Send(response);
		}

		public static void BC_MESSAGE(LoginConnection conn, MsgType msgType)
		{
			var packet = new Packet(Op.BC_MESSAGE);
			packet.PutByte((byte)msgType);

			conn.Send(packet);
		}

		public static void BC_MESSAGE(LoginConnection conn, string msg)
		{
			var packet = new Packet(Op.BC_MESSAGE);
			packet.PutByte((byte)MsgType.Text);
			packet.PutEmptyBin(40);
			packet.PutString(msg);

			conn.Send(packet);
		}

		public static void BC_COMMANDER_DESTROY(LoginConnection conn, byte index)
		{
			var packet = new Packet(Op.BC_COMMANDER_DESTROY);
			packet.PutByte(index);

			conn.Send(packet);
		}
	}
}
