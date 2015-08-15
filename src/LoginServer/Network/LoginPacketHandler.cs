using Melia.Shared.Const;
using Melia.Shared.Database;
using Melia.Shared.Network;
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

namespace Melia.Login.Network
{
	public class LoginPacketHandler : PacketHandler<LoginConnection>
	{
		public static readonly LoginPacketHandler Instance = new LoginPacketHandler();

		/// <summary>
		/// Sent when clicking [Enter] on login screen.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [03 00] [00 00 00 00] [0A 06 00 00] 61 73 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 78 15 69 6E CB F1 C9 6E 68 94 B7 79 45 6D 33 0E 00 01 C0 A8 B2 14 52 93 3A 5C F0 16 79
		/// </example>
		[PacketHandler(Op.CB_LOGIN)]
		public void CB_LOGIN(LoginConnection conn, Packet packet)
		{
			var username = packet.GetString(33);
			var password = packet.GetBinAsHex(16); // MD5? I'm disappointed, IMC =|
			var unkByte1 = packet.GetByte();
			var unkByte2 = packet.GetByte();
			var ip = packet.GetInt();

			// Create new account
			if (username.StartsWith("new__") || username.StartsWith("new//"))
			{
				username = username.Substring("new__".Length);
				if (!LoginServer.Instance.Database.AccountExists(username))
					LoginServer.Instance.Database.CreateAccount(username, password);
			}

			// Check username and password
			if (!LoginServer.Instance.Database.CheckAccount(username, password))
			{
				Send.BC_MESSAGE(conn, MsgType.UsernameOrPasswordIncorrect1);
				conn.Kill();
				return;
			}

			conn.Account = LoginServer.Instance.Database.GetAccount(username);

			Log.Info("User '{0}' logged in.", conn.Account.Name);

			Send.BC_LOGINOK(conn);
		}

		/// <summary>
		/// Sent when clicking [Enter] on login screen.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [03 00] [00 00 00 00] [0A 06 00 00] (00*1016) 01 01 XX XX XX 02 01 00 10 01 XX XX XX 14 00 00 00 00
		/// </example>
		[PacketHandler(Op.CB_LOGIN_BY_PASSPORT)]
		public void CB_LOGIN_BY_PASSPORT(LoginConnection conn, Packet packet)
		{
			Send.BC_MESSAGE(conn, "Passport login not supported.");
			conn.Kill();
		}

		/// <summary>
		/// Sent when clicking [Logout] on barrack screen.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [05 00] [04 00 00 00] [01 00 00 00] 92 0B 79 73 19 ED
		/// </example>
		[PacketHandler(Op.CB_LOGOUT)]
		public void CB_LOGOUT(LoginConnection conn, Packet packet)
		{
			if (conn.Account == null)
				return;

			Log.Info("User '{0}' is logging out.", conn.Account.Name);

			// Client closes connection without this as well, but it waits a
			// few seconds to do so.
			Send.BC_LOGOUTOK(conn);
		}

		/// <summary>
		/// Sent upon logging in.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [06 00] [01 00 00 00] [07 00 00 00] 00 43 07 5D A9 B7
		/// </example>
		[PacketHandler(Op.CB_START_BARRACK)]
		public void CB_START_BARRACK(LoginConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte();

			Send.BC_COMMANDER_LIST(conn);
		}

		/// <summary>
		/// Send upon login, purpose unknown.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [4E 00] [02 00 00 00] [F1 00 00 00] 02 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 CB
		/// </example>
		[PacketHandler(Op.CB_CURRENT_BARRACK)]
		public void CB_CURRENT_BARRACK(LoginConnection conn, Packet packet)
		{
			//_BYTE gap0[255];
			//_DWORD dwordFF;
			//_DWORD dword103;
			//_DWORD dword107;
			//char char10B;
			//_BYTE gap10C[40];
			//_BYTE byte134;
			//var res = new Packet(Op.BC_SINGLE_INFO);
			//for (int i = 0; i < 309-6; ++i)
			//	res.PutByte(5);
			//conn.Send(res);

			// _BYTE gap0[8];
			// _QWORD qword8;
			//var xx = new Packet(Op.BC_ACCOUNT_PROP);
			//xx.PutLong(1);
			//xx.PutShort(0);
			//conn.Send(xx);

			//var xx = new Packet(Op.BC_NORMAL);
			//xx.PutInt(0xB);
			//xx.PutBinFromHex("00 00 00 00 00 64 00 00 00 00 00 00 00 00");
			//conn.Send(xx);
		}

		/// <summary>
		/// Sent when saving Team Name in Lodge Settings on barrack screen.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [0A 00] [03 00 00 00] [18 02 00 00] 53 6F 6D 65 4E 61 6D 65 32 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 99 0C 9A C2 A8 6A
		/// </example>
		[PacketHandler(Op.CB_BARRACKNAME_CHANGE)]
		public void CB_BARRACKNAME_CHANGE(LoginConnection conn, Packet packet)
		{
			var name = packet.GetString(64);

			// TODO: Check validity

			conn.Account.TeamName = name;

			Send.BC_BARRACKNAME_CHANGE(conn, TeamNameChangeResult.Okay);
		}

		/// <summary>
		/// Sent when clicking [Create Character] on char creation screen.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [07 00] [03 00 00 00] [9F 04 00 00] 01 5A 65 72 6F 6E 6F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 E9 03 01 00 00 98 41 C9 1F DE 41 00 00 E8 41 15 00 00 00 00
		/// </example>
		[PacketHandler(Op.CB_COMMANDER_CREATE)]
		public void CB_COMMANDER_CREATE(LoginConnection conn, Packet packet)
		{
			var unkByte1 = packet.GetByte();
			var name = packet.GetString(65);
			var job = (Job)packet.GetShort();
			var gender = (Gender)packet.GetByte();
			var x = packet.GetFloat();
			var y = packet.GetFloat();
			var z = packet.GetFloat();
			var hair = packet.GetByte();
			var unkInt1 = packet.GetInt();

			// Check job
			if (job != Job.Swordsman && job != Job.Wizard && job != Job.Archer && job != Job.Cleric)
			{
				Log.Warning("User '{0}' tried to create character with invalid job '{1}'.", conn.Account.Name, job);
				conn.Kill();
				return;
			}

			// Check gender
			if (gender < Gender.Male || gender > Gender.Female)
			{
				Log.Warning("User '{0}' tried to create character with invalid gender '{1}'.", conn.Account.Name, gender);
				conn.Kill();
				return;
			}

			// Check name
			if (LoginServer.Instance.Database.CharacterExists(name))
			{
				Send.BC_MESSAGE(conn, MsgType.NameAlreadyExists);
				return;
			}

			// Debug
			Log.Debug("CB_COMMANDER_CREATE");
			Log.Debug("Name: {0}", name);
			Log.Debug("Job: {0}", job);
			Log.Debug("Gender: {0}", gender);
			Log.Debug("Hair style: {0}", hair);
			Log.Debug("X: {0}", x);
			Log.Debug("Y: {0}", y);
			Log.Debug("Z: {0}", z);

			// Create
			var character = new Character();
			character.Name = name;
			character.Job = job;
			character.Gender = gender;
			character.Hair = hair;
			character.X = x;
			character.Y = y;
			character.Z = z;

			LoginServer.Instance.Database.CreateCharacter(conn.Account.Id, character);
			conn.Account.AddCharacter(character);

			Send.BC_COMMANDER_CREATE(conn, character);
		}

		/// <summary>
		/// Sent for deleting a character.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [08 00] [05 00 00 00] [0C 00 00 00] 01 | 3A 72 F6 59 1A
		/// </example>
		[PacketHandler(Op.CB_COMMANDER_DESTROY)]
		public void CB_COMMANDER_DESTROY(LoginConnection conn, Packet packet)
		{
			var index = packet.GetByte();

			// Get character
			var character = conn.Account.GetCharacterByIndex(index);
			if (character == null)
			{
				Log.Warning("User '{0}' tried to delete a character he doesn't have ({1}).", conn.Account.Name, index);
				Send.BC_MESSAGE(conn, MsgType.CannotDeleteCharacter1);
				return;
			}

			// Debug
			Log.Debug("CB_COMMANDER_DESTROY: {0}", index);

			// Delete
			LoginServer.Instance.Database.DeleteCharacter(character.Id);
			conn.Account.RemoveCharacter(character);

			Send.BC_COMMANDER_DESTROY(conn, index);
		}

		/// <summary>
		/// Sent after character moved somewhere on the barrack screen, updates position?
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// [0B 00] [06 00 00 00] [AD 04 00 00] 02 C5 C4 F0 C1 BD 63 90 41 BF 6F A8 C1 00 00 00 00 00 00 00 00 | C1
		/// </example>
		[PacketHandler(Op.CB_COMMANDER_MOVE)]
		public void CB_COMMANDER_MOVE(LoginConnection conn, Packet packet)
		{
			var index = packet.GetByte();
			var x = packet.GetFloat();
			var y = packet.GetFloat();
			var z = packet.GetFloat();

			// Debug
			Log.Debug("CB_COMMANDER_MOVE");
			Log.Debug("X: {0}", x);
			Log.Debug("Y: {0}", y);
			Log.Debug("Z: {0}", z);

			// Get character
			var character = conn.Account.GetCharacterByIndex(index);
			if (character == null)
			{
				Log.Warning("User '{0}' tried to move invalid character ({1}).", conn.Account.Name, index);
				return;
			}

			// Move
			character.X = x;
			character.Y = y;
			character.Z = z;
		}

		// [09 00] [15 00 00 00] [1D 00 00 00] 00 00 01 | 69 7D E4
		[PacketHandler(Op.CB_START_GAME)]
		public void CB_START_GAME(LoginConnection conn, Packet packet)
		{
			var unkShort = packet.GetShort(); // channel?
			var index = packet.GetByte();

			// Debug
			Log.Debug("CB_START_GAME");
			Log.Debug("unkShort: {0}", unkShort);
			Log.Debug("index: {0}", index);

			packet = new Packet(Op.BC_START_GAMEOK);
			packet.PutInt(101); // Zone id?
			packet.PutInt(0x0100007F); // 127.0.0.1
			packet.PutInt(2001); // Port
			packet.PutInt(0);
			packet.PutByte(0);
			packet.PutLong(0);
			packet.PutByte(0); // connect? (goes back to login if 0, keeps trying to connect if address not reachable)
			packet.PutByte(0); // Used if ^ is !0
			conn.Send(packet);

			packet = new Packet(Op.BC_SERVER_ENTRY);
			packet.PutInt(0x0100007F);
			packet.PutInt(0x0100007F);
			packet.PutShort(2002);
			packet.PutShort(2003);
			conn.Send(packet);
		}
	}
}
