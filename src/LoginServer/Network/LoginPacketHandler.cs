// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Login.Database;
using Melia.Login.World;
using Melia.Shared.Const;
using Melia.Shared.Database;
using Melia.Shared.Network;
using Melia.Shared.Util;
using Melia.Shared.Util.Security;
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
		/// ([03 00] [00 00 00 00] [0A 06 00 00]) 61 73 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 78 15 69 6E CB F1 C9 6E 68 94 B7 79 45 6D 33 0E 00 01 C0 A8 B2 14 52 93 3A 5C F0 16 79
		/// </example>
		[PacketHandler(Op.CB_LOGIN)]
		public void CB_LOGIN(LoginConnection conn, Packet packet)
		{
			var accountName = packet.GetString(33);
			var password = packet.GetBinAsHex(16); // MD5? I'm disappointed, IMC =|
			var unkByte1 = packet.GetByte();
			var unkByte2 = packet.GetByte();
			var unkByte3 = packet.GetByte(); // [i10671 (2015-10-26)] ?
			var ip = packet.GetInt();

			Send.BC_LOGIN_PACKET_RECEIVED(conn);

			// Create new account
			if (accountName.StartsWith("new__") || accountName.StartsWith("new//"))
			{
				accountName = accountName.Substring("new__".Length);
				if (!LoginServer.Instance.Database.AccountExists(accountName))
					LoginServer.Instance.Database.CreateAccount(accountName, password);
			}

			// Check account
			if (!LoginServer.Instance.Database.AccountExists(accountName))
			{
				Send.BC_MESSAGE(conn, MsgType.UsernameOrPasswordIncorrect1);
				conn.Close();
				return;
			}

			// Check password
			var account = Account.LoadFromDb(accountName);
			if (!BCrypt.CheckPassword(password, account.Password))
			{
				Send.BC_MESSAGE(conn, MsgType.UsernameOrPasswordIncorrect2);
				conn.Close();
				return;
			}

			// Logged in
			conn.Account = account;
			conn.LoggedIn = true;

			Log.Info("User '{0}' logged in.", conn.Account.Name);

			Send.BC_LOGINOK(conn);
		}

		/// <summary>
		/// Sent when clicking [Enter] on login screen if no login mask
		/// is used.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([03 00] [00 00 00 00] [0A 06 00 00]) (00*1016) 01 01 XX XX XX 02 01 00 10 01 XX XX XX 14 00 00 00 00
		/// </example>
		[PacketHandler(Op.CB_LOGIN_BY_PASSPORT)]
		public void CB_LOGIN_BY_PASSPORT(LoginConnection conn, Packet packet)
		{
			Send.BC_MESSAGE(conn, "Passport login not supported.");
			conn.Close();
		}

		/// <summary>
		/// Sent when clicking [Logout] on barrack screen.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([05 00] [04 00 00 00] [01 00 00 00]) 92 0B 79 73 19 ED
		/// </example>
		[PacketHandler(Op.CB_LOGOUT)]
		public void CB_LOGOUT(LoginConnection conn, Packet packet)
		{
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
		/// ([06 00] [01 00 00 00] [07 00 00 00]) 00 | 43 07 5D A9 B7
		/// </example>
		[PacketHandler(Op.CB_START_BARRACK)]
		public void CB_START_BARRACK(LoginConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte();

			Send.BC_SERVER_ENTRY(conn, "127.0.0.1", 9001, "127.0.0.1", 9002);
			Send.BC_COMMANDER_LIST(conn);
			Send.BC_NORMAL_ZoneTraffic(conn);
		}

		/// <summary>
		/// Send upon login, purpose unknown.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([4E 00] [02 00 00 00] [F1 00 00 00]) 02 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 | CB
		/// </example>
		[PacketHandler(Op.CB_CURRENT_BARRACK)]
		public void CB_CURRENT_BARRACK(LoginConnection conn, Packet packet)
		{
		}

		/// <summary>
		/// Sent when saving Team Name in Lodge Settings on barrack screen.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([0A 00] [03 00 00 00] [18 02 00 00]) 53 6F 6D 65 4E 61 6D 65 32 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 99 0C 9A C2 A8 6A
		/// </example>
		[PacketHandler(Op.CB_BARRACKNAME_CHANGE)]
		public void CB_BARRACKNAME_CHANGE(LoginConnection conn, Packet packet)
		{
			var name = packet.GetString(64);

			// Don't do anything if nothing's changed
			if (name == conn.Account.TeamName)
				return;

			// Check validity
			var valid = (name.Length >= 2 && name.Length <= 16 && !name.Any(a => Char.IsWhiteSpace(a)));
			if (!valid)
			{
				Send.BC_BARRACKNAME_CHANGE(conn, TeamNameChangeResult.TeamChangeFailed);
				return;
			}

			// Check availability
			var exists = LoginServer.Instance.Database.TeamNameExists(name);
			if (exists)
			{
				Send.BC_BARRACKNAME_CHANGE(conn, TeamNameChangeResult.TeamNameAlreadyExist);
				return;
			}

			// Set team name
			conn.Account.TeamName = name;
			LoginServer.Instance.Database.UpdateTeamName(conn.Account.Id, name);

			Send.BC_BARRACKNAME_CHANGE(conn, TeamNameChangeResult.Okay);
		}

		/// <summary>
		/// Sent when clicking [Create Character] on char creation screen.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([07 00] [03 00 00 00] [9F 04 00 00]) 01 5A 65 72 6F 6E 6F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 E9 03 01 00 00 98 41 C9 1F DE 41 00 00 E8 41 15 | 00 00 00 00
		/// </example>
		[PacketHandler(Op.CB_COMMANDER_CREATE)]
		public void CB_COMMANDER_CREATE(LoginConnection conn, Packet packet)
		{
			var charPosition = packet.GetByte();
			var name = packet.GetString(65);
			var job = (Job)packet.GetShort();
			var gender = (Gender)packet.GetByte();
			var bx = packet.GetFloat();
			var by = packet.GetFloat();
			var bz = packet.GetFloat();
			var hair = packet.GetByte();
			var startingCity = (StartingCity)packet.GetInt();

			// Check starting city
			if (!Enum.IsDefined(typeof(StartingCity), startingCity))
			{
				Log.Warning("CB_COMMANDER_CREATE: User '{0}' tried to create character in invalid starting city '{1}'.", conn.Account.Name, startingCity);
				Send.BC_MESSAGE(conn, MsgType.CreateCharFail);
				return;
			}

			// Check job
			if (job != Job.Swordsman && job != Job.Wizard && job != Job.Archer && job != Job.Cleric)
			{
				Log.Warning("CB_COMMANDER_CREATE: User '{0}' tried to create character with invalid job '{1}'.", conn.Account.Name, job);
				conn.Close();
				return;
			}

			// Check gender
			if (gender < Gender.Male || gender > Gender.Female)
			{
				Log.Warning("CB_COMMANDER_CREATE: User '{0}' tried to create character with invalid gender '{1}'.", conn.Account.Name, gender);
				conn.Close();
				return;
			}

			// Check name
			if (LoginServer.Instance.Database.CharacterExists(conn.Account.Id, name))
			{
				Send.BC_MESSAGE(conn, MsgType.NameAlreadyExists);
				return;
			}

			// Get job data
			var jobData = LoginServer.Instance.Data.JobDb.Find(job);
			if (jobData == null)
			{
				Log.Error("CB_COMMANDER_CREATE: Job '{0}' not found.", job);
				Send.BC_MESSAGE(conn, MsgType.CannotCreateCharacter);
				return;
			}

			// Get map data
			var mapData = LoginServer.Instance.Data.MapDb.Find(jobData.StartMap);
			if (mapData == null)
			{
				Log.Error("CB_COMMANDER_CREATE: Map '{0}' not found.", jobData.StartMap);
				Send.BC_MESSAGE(conn, MsgType.CannotCreateCharacter);
				return;
			}

			// Create
			var character = new Character();
			character.Name = name;
			character.Job = job;
			character.Gender = gender;
			character.Hair = hair;

			character.MapId = mapData.Id;
			character.Position = new Position(jobData.StartX, jobData.StartY, jobData.StartZ);
			character.BarrackPosition = new Position(bx, by, bz);

			character.Hp = character.MaxHp = 100;
			character.Sp = character.MaxSp = 50;
			character.Stamina = character.MaxStamina = 25000;
			character.Str = jobData.Str;
			character.Con = jobData.Con;
			character.Int = jobData.Int;
			character.Spr = jobData.Spr;
			character.Dex = jobData.Dex;

			conn.Account.CreateCharacter(character);

			Send.BC_COMMANDER_CREATE(conn, character);
		}

		/// <summary>
		/// Sent when deleting a character.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([08 00] [05 00 00 00] [0C 00 00 00]) 01 | 3A 72 F6 59 1A
		/// </example>
		[PacketHandler(Op.CB_COMMANDER_DESTROY)]
		public void CB_COMMANDER_DESTROY(LoginConnection conn, Packet packet)
		{
			var index = packet.GetByte();

			// Get character
			var character = conn.Account.GetCharacterByIndex(index);
			if (character == null)
			{
				Log.Warning("CB_COMMANDER_DESTROY: User '{0}' tried to delete a character he doesn't have ({1}).", conn.Account.Name, index);
				Send.BC_MESSAGE(conn, MsgType.CannotDeleteCharacter1);
				return;
			}

			// Delete
			if (!conn.Account.DeleteCharacter(character))
			{
				Log.Warning("CB_COMMANDER_DESTROY: Deleting '{0}' from account '{1}' failed.", character.Name, conn.Account.Name);
				Send.BC_MESSAGE(conn, MsgType.CannotDeleteCharacter1);
				return;
			}

			Send.BC_COMMANDER_DESTROY(conn, index);
		}

		/// <summary>
		/// Sent after character moved somewhere on the barrack screen, updates position?
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <example>
		/// ([0B 00] [06 00 00 00] [AD 04 00 00]) 02 C5 C4 F0 C1 BD 63 90 41 BF 6F A8 C1 00 00 00 00 00 00 00 00 | C1
		/// </example>
		[PacketHandler(Op.CB_COMMANDER_MOVE)]
		public void CB_COMMANDER_MOVE(LoginConnection conn, Packet packet)
		{
			var index = packet.GetByte();
			var x = packet.GetFloat();
			var y = packet.GetFloat();
			var z = packet.GetFloat();
			var d1 = packet.GetFloat();	// ?
			var d2 = packet.GetFloat();	// ?

			// Get character
			var character = conn.Account.GetCharacterByIndex(index);
			if (character == null)
			{
				Log.Warning("CB_COMMANDER_MOVE: User '{0}' tried to move invalid character ({1}).", conn.Account.Name, index);
				return;
			}

			// Move
			character.BarrackPosition = new Position(x, y, z);
		}

		/// <summary>
		/// Sent when clicking [Start Game], to connect to the selected channel.
		/// </summary>
		/// <example>
		/// ([09 00] [15 00 00 00] [1D 00 00 00]) 00 00 01 | 69 7D E4
		/// </example>
		[PacketHandler(Op.CB_START_GAME)]
		public void CB_START_GAME(LoginConnection conn, Packet packet)
		{
			var channel = packet.GetShort();
			var index = packet.GetByte();

			// Get character
			var character = conn.Account.GetCharacterByIndex(index);
			if (character == null)
			{
				Log.Warning("CB_START_GAME: User '{0}' tried log in with an invalid character ({1}).", conn.Account.Name, index);
				return;
			}

			// Get channel
			// TODO: Create a manager server that keeps track of the channels,
			//   their statuses, etc, broadcast that list to login and the
			//   channels, and use in places like this.
			var channelId = 1;
			var channelServer = LoginServer.Instance.Data.ServerDb.FindChannel(channelId);
			if (channelServer == null)
			{
				Log.Error("Channel with id '{0}' not found.", channelId);
				return;
			}

			Send.BC_START_GAMEOK(conn, character, channelServer.Ip, channelServer.Port);
		}

		/// <summary>
		/// Sent when clicking [Purchase] on a barrack.
		/// </summary>
		/// <example>
		/// ([4C 00] [15 00 00 00] [5E 00 00 00]) 00 00 00 00 0C 00 00 00 0B 00 00 00 | 0E 30
		/// </example>
		[PacketHandler(Op.CB_BUY_THEMA)]
		public void CB_BUY_THEMA(LoginConnection conn, Packet packet)
		{
			var unkInt = packet.GetInt();
			var newMapId = packet.GetInt();
			var oldMapId = packet.GetInt();

			// Get barrack
			var barrackData = LoginServer.Instance.Data.BarrackDb.Find(newMapId);
			if (barrackData == null)
				return;

			// Check medals
			if (conn.Account.Medals < barrackData.Price)
			{
				Log.Warning("CB_BUY_THEMA: User '{0}' tried to buy barrack without having the necessary coins.");
				return;
			}

			conn.Account.Medals -= barrackData.Price;
			conn.Account.SelectedBarrack = newMapId;

			Send.BC_ACCOUNT_PROP(conn, conn.Account);
			Send.BC_NORMAL_Run(conn, "THEMA_BUY_SUCCESS");
		}

		/// <summary>
		/// Sent upon login, contains checksum of client files?
		/// </summary>
		/// <example>
		/// 0000   09 00 01 00 00 00 12 04  00 00 39 64 34 39 61 35   ..........9d49a5
		/// 0010   33 36 34 38 32 63 33 33  38 39 33 31 66 31 32 62   36482c338931f12b
		/// 0020   36 30 38 65 33 31 37 61  30 65 00 00 00 00 00 00   608e317a0e......
		/// 0030   00 00 00 00 00 00 00 00  00 00 00 00 00 00 00 00   ................
		/// 0040   00 00 00 00 00 00 00 00  00 00 00 00 00 00 00 00   ................
		/// </example>
		[PacketHandler(Op.CB_CHECK_CLIENT_INTEGRITY)]
		public void CB_CHECK_CLIENT_INTEGRITY(LoginConnection conn, Packet packet)
		{
			var checksum = packet.GetString(64);

			// Ignore for now.
			// TODO: Add option for accepted checksums.
		}
	}
}
