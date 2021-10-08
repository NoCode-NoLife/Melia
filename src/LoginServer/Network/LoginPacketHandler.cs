using System.Linq;
using Melia.Login.Database;
using Melia.Login.World;
using Melia.Shared.Const;
using Melia.Shared.Network;
using Melia.Shared.Util;
using Melia.Shared.Util.Security;
using Melia.Shared.World;
using System.Collections.Generic;
using System;
using System.Text;
using System.Security.Cryptography;
using Melia.Shared.Network.Helpers;

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
		[PacketHandler(Op.CB_LOGIN)]
		public void CB_LOGIN(LoginConnection conn, Packet packet)
		{
			var accountName = packet.GetString(33);
			var bin1 = packet.GetBin(23);
			var password = packet.GetBinAsHex(16); // MD5? I'm disappointed, IMC =|
			var b1 = packet.GetByte();
			var b2 = packet.GetByte();
			var b3 = packet.GetByte();
			var ip = packet.GetInt();
			var bin2 = packet.GetBin(4368);

			Send.BC_LOGIN_PACKET_RECEIVED(conn);
			Send.BC_DISCONNECT_PACKET_LOG_COUNT(conn);

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
				conn.Close(100);
				return;
			}

			// Check password
			var account = Account.LoadFromDb(accountName);
			if (!BCrypt.CheckPassword(password, account.Password))
			{
				Send.BC_MESSAGE(conn, MsgType.UsernameOrPasswordIncorrect2);
				conn.Close(100);
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
		[PacketHandler(Op.CB_LOGIN_BY_PASSPORT)]
		public void CB_LOGIN_BY_PASSPORT(LoginConnection conn, Packet packet)
		{
			Send.BC_MESSAGE(conn, "Passport login not supported.");
			conn.Close(100);
		}

		/// <summary>
		/// Sent when clicking [Logout] on barrack screen.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
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
		[PacketHandler(Op.CB_START_BARRACK)]
		public void CB_START_BARRACK(LoginConnection conn, Packet packet)
		{
			var unkByte = packet.GetByte();

			Send.BC_SERVER_ENTRY(conn, "127.0.0.1", 9001, "127.0.0.1", 9002);
			Send.BC_NORMAL_SetBarrack(conn);
			Send.BC_COMMANDER_LIST(conn);
			Send.BC_NORMAL_CharacterInfo(conn);
			Send.BC_NORMAL_TeamUI(conn);
			Send.BC_NORMAL_ZoneTraffic(conn);
			//Send.BC_NORMAL_MESSAGE_MAIL(conn);
		}

		/// <summary>
		/// Send upon login, purpose unknown.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CB_CURRENT_BARRACK)]
		public void CB_CURRENT_BARRACK(LoginConnection conn, Packet packet)
		{
			var accountId = packet.GetLong();
			var index = packet.GetByte();
			var x = packet.GetFloat();
			var y = packet.GetFloat();
			var z = packet.GetFloat();
			var dx = packet.GetFloat();
			var dy = packet.GetFloat();

			//Send.BC_NORMAL_SetBarrack(conn);
		}

		/// <summary>
		/// Sent when saving Team Name in Lodge Settings on barrack screen.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CB_BARRACKNAME_CHANGE)]
		public void CB_BARRACKNAME_CHANGE(LoginConnection conn, Packet packet)
		{
			var name = packet.GetString(64);

			// Don't do anything if nothing's changed
			if (name == conn.Account.TeamName)
				return;

			// Check validity
			var valid = (name.Length >= 2 && name.Length <= 16 && !name.Any(a => char.IsWhiteSpace(a)));
			if (!valid)
			{
				Send.BC_BARRACKNAME_CHANGE(conn, TeamNameChangeResult.TeamChangeFailed, name);
				return;
			}

			// Check availability
			var exists = LoginServer.Instance.Database.TeamNameExists(name);
			if (exists)
			{
				Send.BC_BARRACKNAME_CHANGE(conn, TeamNameChangeResult.TeamNameAlreadyExist, name);
				return;
			}

			// Set team name
			conn.Account.TeamName = name;
			LoginServer.Instance.Database.UpdateTeamName(conn.Account.Id, name);

			Send.BC_BARRACKNAME_CHANGE(conn, TeamNameChangeResult.Okay, name);
			Send.BC_ACCOUNT_PROP(conn, conn.Account);
			Send.BC_NORMAL_Run(conn, BarrackMessage.THEMA_BUY_SUCCESS);
		}

		/// <summary>
		/// Sent when saving Team Name in Lodge Settings on barrack screen.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CB_BARRACKNAME_CHECK)]
		public void CB_BARRACKNAME_CHECK(LoginConnection conn, Packet packet)
		{
			// The "message" contains a client-function to call after the
			// response, which affects how the name can be changed from
			// the client. For example, when changing the name from the
			// barracks, the function used is different from the one in
			// the initial setting, and displays a dialog for the TP the
			// change is gong to cost. Just passing the message back to
			// the client shouldn't cause any issues, but we could sanity
			// chech them.

			var serverId = packet.GetShort();
			var name = packet.GetString(64);
			var message = packet.GetString(256);

			// Check validity
			var valid = (name.Length >= 2 && name.Length <= 16 && !name.Any(a => char.IsWhiteSpace(a)));
			if (!valid)
			{
				Send.BC_BARRACKNAME_CHECK_RESULT(conn, TeamNameChangeResult.TeamChangeFailed, name, message);
				return;
			}

			// Check availability
			var exists = LoginServer.Instance.Database.TeamNameExists(name);
			if (exists)
			{
				Send.BC_BARRACKNAME_CHECK_RESULT(conn, TeamNameChangeResult.TeamNameAlreadyExist, name, message);
				return;
			}

			Send.BC_BARRACKNAME_CHECK_RESULT(conn, TeamNameChangeResult.Okay, name, message);
		}

		/// <summary>
		/// Sent when clicking [Create Character] on char creation screen.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CB_COMMANDER_CREATE)]
		public void CB_COMMANDER_CREATE(LoginConnection conn, Packet packet)
		{
			var charPosition = packet.GetByte();
			var name = packet.GetString(65);
			var job = (JobId)packet.GetShort();
			var gender = (Gender)packet.GetByte();
			var barrackPos = packet.GetPosition();
			var lodge = packet.GetInt();
			var hair = packet.GetByte();
			var bin1 = packet.GetBin(12);

			// Check job
			if (job != JobId.Swordsman && job != JobId.Wizard && job != JobId.Archer && job != JobId.Cleric && job != JobId.Scout)
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

			// Create
			var character = new Character();
			character.Name = name;
			character.TeamName = conn.Account.TeamName;
			character.JobId = job;
			character.Gender = gender;
			character.Hair = hair;

			var startLocation = LoginServer.Instance.Conf.Login.StartLocation;
			character.MapId = startLocation.MapId;
			character.Position = new Position(startLocation.X, startLocation.Y, startLocation.Z);
			character.BarrackPosition = barrackPos;

			// XXX: Maybe we could get rid of this and the (sub-)stats in
			//   Character by passing the jobData to the database, for it
			//   get them itself? The creation is the only reason the stats
			//   exist in that class.
			//character.Hp = jobData.GetInitialHp();
			//character.Sp = jobData.GetInitialSp();
			//character.HpRateByJob = jobData.HpRate;
			//character.SpRateByJob = jobData.SpRate;
			//character.Stamina = character.StaminaByJob = jobData.Stamina;
			//character.StrByJob = jobData.Str;
			//character.ConByJob = jobData.Con;
			//character.IntByJob = jobData.Int;
			//character.SprByJob = jobData.Spr;
			//character.DexByJob = jobData.Dex;

			// Initialize with the default equipment set.
			var equipment = new Dictionary<EquipSlot, int>();
			foreach (var equip in jobData.DefaultEquip)
			{
				var itemData = LoginServer.Instance.Data.ItemDb.FindByClass(equip.Value);
				if (itemData == null)
				{
					Log.Error("CB_COMMANDER_CREATE : Unable to find item data with class name '{0}'.", equip.Value);
					Send.BC_MESSAGE(conn, MsgType.CannotCreateCharacter);
					return;
				}

				equipment[equip.Key] = itemData.Id;
			}

			character.SetEquipment(equipment);

			conn.Account.CreateCharacter(character);

			Send.BC_COMMANDER_CREATE_SLOTID(conn, character);
			Send.BC_COMMANDER_CREATE(conn, character);
		}

		/// <summary>
		/// Sent when deleting a character.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CB_COMMANDER_DESTROY)]
		public void CB_COMMANDER_DESTROY(LoginConnection conn, Packet packet)
		{
			var id = packet.GetLong();

			// Get character
			var character = conn.Account.GetCharacterById(id);
			if (character == null)
			{
				Log.Warning("CB_COMMANDER_DESTROY: User '{0}' tried to delete a character he doesn't have ({1}).", conn.Account.Name, id);
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

			Send.BC_COMMANDER_DESTROY(conn, character.Index);
			Send.BC_NORMAL_TeamUI(conn);
		}

		/// <summary>
		/// Sent after character moved somewhere on the barrack screen, updates position?
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CB_COMMANDER_MOVE)]
		public void CB_COMMANDER_MOVE(LoginConnection conn, Packet packet)
		{
			var index = packet.GetByte();
			var x = packet.GetFloat();
			var y = packet.GetFloat();
			var z = packet.GetFloat();
			var d1 = packet.GetFloat(); // ?
			var d2 = packet.GetFloat(); // ?

			// On a new character creation, this packet is sent with the index as this byte.
			if (index == 0xFF)
				return;

			// Get character
			var character = conn.Account.GetCharacterByIndex(index);
			if (character == null)
			{
				Log.Warning("CB_COMMANDER_MOVE: User '{0}' tried to move invalid character ({1}).", conn.Account.Name, index);
				return;
			}

			// TODO: Validate coordinates, so that a commander may not move
			//   to an invalid position.

			// Move
			character.BarrackPosition = new Position(x, y, z);
			Send.BC_NORMAL_SetPosition(conn, index, character.BarrackPosition);
		}

		/// <summary>
		/// Sent when clicking [Start Game], to connect to the selected channel.
		/// </summary>
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
				Log.Error("CB_START_GAME: Channel with id '{0}' not found.", channelId);
				return;
			}

			Send.BC_START_GAMEOK(conn, character, channelServer.Ip, channelServer.Port);
		}

		/// <summary>
		/// Sent when clicking [Purchase] on a barrack.
		/// </summary>
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
			if (!conn.Account.Charge(barrackData.Price))
			{
				Log.Warning("CB_BUY_THEMA: User '{0}' tried to buy barrack without having the necessary medals.");
				return;
			}

			conn.Account.SelectedBarrack = newMapId;

			Send.BC_ACCOUNT_PROP(conn, conn.Account);
			Send.BC_NORMAL_Run(conn, BarrackMessage.THEMA_BUY_SUCCESS);
		}

		/// <summary>
		/// Sent upon login. Asserts that the client IPF files are correct.
		/// </summary>
		/// <remarks>
		/// This must be configured in the login configuration file to be enabled.
		/// </remarks>
		[PacketHandler(Op.CB_CHECK_CLIENT_INTEGRITY)]
		public void CB_CHECK_CLIENT_INTEGRITY(LoginConnection conn, Packet packet)
		{
			var checksum = packet.GetString(64);

			if (!LoginServer.Instance.Conf.Login.VerifyIpf)
				return;

			var bytes = Encoding.UTF8.GetBytes(LoginServer.Instance.Conf.Login.IpfChecksum + conn.IntegritySeed);
			var md5 = MD5.Create();
			md5.TransformFinalBlock(bytes, 0, bytes.Length);

			var result = BitConverter.ToString(md5.Hash).Replace("-", "").ToLower();

			if (checksum.ToLower() != result)
			{
				Send.BC_MESSAGE(conn, MsgType.InvalidIpf);

				// Even though the integrity check fails, send these packets
				// as well. This is done because the client is in a hanging
				// state waiting for these packets. Without these, the invalid
				// IPF message will not be visible.
				Send.BC_COMMANDER_LIST(conn);
				Send.BC_NORMAL_ZoneTraffic(conn);
				Send.BC_NORMAL_TeamUI(conn);

				// Terminate any further requests from the client at this point.
				conn.IgnorePackets = true;
			}
		}

		/// <summary>
		/// Request from the client to send channel traffic information.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CB_REQ_CHANNEL_TRAFFIC)]
		public void CB_REQ_CHANNEL_TRAFFIC(LoginConnection conn, Packet packet)
		{
			Send.BC_NORMAL_ZoneTraffic(conn);
		}

		/// <summary>
		/// Sent when the user clicks the barrack number.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CB_SELECT_BARRACK_LAYER)]
		public void CB_SELECT_BARRACK_LAYER(LoginConnection conn, Packet packet)
		{
			var layer = packet.GetInt();

			// Only these three layers are valid currently.
			if (layer < 1 || layer > 3)
			{
				Log.Warning("CB_SELECT_BARRACK_LAYER: Invalid layer '{0}' received from '{1}'.", layer, conn.Account.Name);
				return;
			}

			conn.Account.SetSelectedBarrackLayer(layer);

			Send.BC_NORMAL_SetBarrack(conn);
			Send.BC_COMMANDER_LIST(conn);
			Send.BC_NORMAL_CharacterInfo(conn);
			Send.BC_NORMAL_TeamUI(conn);
		}

		/// <summary>
		/// Pets!
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CB_PET_PC)]
		public void CB_PET_PC(LoginConnection conn, Packet packet)
		{
			var petGuid = packet.GetLong();
			var characterId = packet.GetLong();
		}

		/// <summary>
		/// Commands associated with pets.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CB_PET_COMMAND)]
		public void CB_PET_COMMAND(LoginConnection conn, Packet packet)
		{
			var petGuid = packet.GetLong();
			var characterId = packet.GetLong();
			var command = packet.GetByte(); // 0 : revive request; 1 : delete pet request.
		}

		/// <summary>
		/// Request to update the state of a postbox message.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CB_REQ_CHANGE_POSTBOX_STATE)]
		public void CB_REQ_CHANGE_POSTBOX_STATE(LoginConnection conn, Packet packet)
		{
			var dbType = packet.GetByte();
			var messageId = packet.GetLong();
			var state = (PostBoxMessageState)packet.GetByte();

			// TODO: Implement use of changing state.
			Send.BC_MESSAGE(conn, "Updating mail isn't working yet.");
		}

		/// <summary>
		/// Request to get the next page of mail with a count.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		public void CB_REQ_POSTBOX_PAGE(LoginConnection conn, Packet packet)
		{
			var count = packet.GetInt();

			// TODO: Implement postbox message paging.
			Send.BC_MESSAGE(conn, "Fetching mail isn't working yet.");
		}

		/// <summary>
		/// Sent upon login. (Dummy handler)
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CB_NOT_AUTHORIZED_ADDON_LIST)]
		public void CB_NOT_AUTHORIZED_ADDON_LIST(LoginConnection conn, Packet packet)
		{
			// I assume it's some kind of anti-cheat? I doubt we'll care
			// about this any time soon. Btw, if it is an anti-cheat:
			// Good thinking, IMC. Let the client tell the server about
			// its files, what could go wrong.
		}

		/// <summary>
		/// Sent upon login, to inform the server about the selected language.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CB_SELECTED_LANGUAGE)]
		public void CB_SELECTED_LANGUAGE(LoginConnection conn, Packet packet)
		{
			var language = packet.GetShort();
		}

		/// <summary>
		/// ?
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CB_OS_INFO)]
		public void CB_OS_INFO(LoginConnection conn, Packet packet)
		{
		}

		/// <summary>
		/// ?
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CB_VISIT)]
		public void CB_VISIT(LoginConnection conn, Packet packet)
		{
			///3800090000000D09000000000000000000000000000000000FA473400100000030B066BC00000000D34788400100000030B066BC0000000030B066BC0000000000000000000000008952884001000000FEFFFFFFFFFF0100
		}

		/// <summary>
		/// ?
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CB_CHANGE_BARRACK_TARGET_LAYER)]
		public void CB_CHANGE_BARRACK_TARGET_LAYER(LoginConnection conn, Packet packet)
		{
			var characterId = packet.GetLong();
			var targetLayer = packet.GetInt();

			if (targetLayer < 1 || targetLayer > 3)
			{
				Log.Warning("CB_SELECT_BARRACK_LAYER: Invalid layer '{0}' received from '{1}'.", targetLayer, conn.Account.Name);
				return;
			}
			var character = conn.Account.GetCharacterById(characterId);

			if (character != null)
			{
				character.BarrackLayer = targetLayer;

				Send.BC_NORMAL_SetBarrack(conn);
				Send.BC_COMMANDER_LIST(conn);
				Send.BC_NORMAL_CharacterInfo(conn);
				Send.BC_NORMAL_TeamUI(conn);
				Send.BC_NORMAL_SetBarrackCharacter(conn, character);
				Send.BC_LAYER_CHANGE_SYSTEM_MESSAGE(conn, targetLayer);
			}
		}

		/// <summary>
		/// Sent when character has no items equipped and a delete is requested, check if the character has items registered in the market?
		/// </summary>
		/// <param name="conn"></param>
		[PacketHandler(Op.CB_CHECK_MARKET_REGISTERED)]
		public void CB_CHECK_MARKET_REGISTERED(LoginConnection conn, Packet packet)
		{
			var characterId = packet.GetLong();

			var character = conn.Account.GetCharacterById(characterId);

			if (character != null)
				Send.BC_RETURN_PC_MARKET_REGISTERED(conn, character.Id);
		}

		/// <summary>
		/// ? (Dummy)
		/// </summary>
		/// <remarks>
		/// The client sends this packet repeatedly until it gets an appropriate response.
		/// </remarks>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CZ_REQUEST_GUILD_INDEX)]
		public void CZ_REQUEST_GUILD_INDEX(LoginConnection conn, Packet packet)
		{
			var guildId = packet.GetLong(); // ?
		}

		/// <summary>
		/// Request to swap the slots of two characters. Sent when clicking
		/// the button to change a character's position in the barracks.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		[PacketHandler(Op.CB_CHARACTER_SWAP_SLOT)]
		public void CB_CHARACTER_SWAP_SLOT(LoginConnection conn, Packet packet)
		{
			var characterId1 = packet.GetLong();
			var characterId2 = packet.GetLong();

			var character1 = conn.Account.GetCharacterById(characterId1);
			var character2 = conn.Account.GetCharacterById(characterId2);

			if (character1 == null || character2 == null)
			{
				Send.BC_CHARACTER_SLOT_SWAP_FAIL(conn);
				return;
			}

			var tmpIndex = character1.Index;
			character1.Index = character2.Index;
			character2.Index = tmpIndex;

			Send.BC_CHARACTER_SLOT_SWAP_SUCCESS(conn);
			Send.BC_COMMANDER_LIST(conn);
		}
	}
}
