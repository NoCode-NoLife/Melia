using Melia.Channel.Network;
using Melia.Channel.World;
using Melia.Shared.Network;
using Melia.Shared.Util;
using Melia.Shared.Util.Commands;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Channel.Util
{
	/// <summary>
	/// GM command manager.
	/// </summary>
	public class GmCommands : CommandManager<GmCommand, GmCommandFunc>
	{
		/// <summary>
		/// Creates new manager and initializes it.
		/// </summary>
		public GmCommands()
		{
			Add("test", "", HandleTest);
			Add("where", "", HandleWhere);
			Add("jump", "<x> <y> <z>", HandleJump);
			Add("warp", "<zone id> <x> <y> <z>", HandleWarp);
		}

		/// <summary>
		/// Adds command.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="usage"></param>
		/// <param name="func"></param>
		public void Add(string name, string usage, GmCommandFunc func)
		{
			this.Add(new GmCommand(name, usage, "", func));
		}

		/// <summary>
		/// Processes given message and executes command if applicable.
		/// Returns true if a command was executed.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="character"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		public bool Process(ChannelConnection conn, Character character, string message)
		{
			if (string.IsNullOrWhiteSpace(message))
				return false;

			message = message.Trim();

			var args = this.ParseLine(message);
			if (args.Length == 0 || !args[0].StartsWith("/"))
				return false;

			var commandName = args[0].TrimStart('/');
			var command = this.GetCommand(commandName);
			if (command == null)
				return false;

			var result = command.Func(conn, character, message, args);
			if (result == CommandResult.Fail)
			{
				//msg(conn, "Failed to execute command.");
			}
			else if (result == CommandResult.InvalidArgument)
			{
				//msg(conn, "Invalid argument, usage: " + string.Format("{0}{1} {2}", '/', commandName, command.Usage));
			}

			return true;
		}

		//-------------------------------------------------------------------

		private CommandResult HandleTest(ChannelConnection conn, Character character, string command, string[] args)
		{
			Log.Debug("test!!");

			return CommandResult.Okay;
		}

		private CommandResult HandleWhere(ChannelConnection conn, Character character, string command, string[] args)
		{
			var msg = string.Format("You are here: {0} - {1}, {2}, {3}", character.ZoneId, character.X.ToString(CultureInfo.InvariantCulture), character.Y.ToString(CultureInfo.InvariantCulture), character.Z.ToString(CultureInfo.InvariantCulture));

			var packet = new Packet(Op.ZC_CHAT);
			packet.PutInt(character.WorldId);
			packet.PutString("test team name", 64);
			packet.PutString("test name", 65);
			packet.PutByte(0);
			packet.PutShort((short)character.Job);
			packet.PutInt(0);
			packet.PutByte((byte)character.Gender);
			packet.PutByte((byte)character.Hair);
			packet.PutEmptyBin(2);
			packet.PutInt(0);
			packet.PutFloat(10);  // display time in seconds
			packet.PutString(msg);
			conn.Send(packet);

			return CommandResult.Okay;
		}

		private CommandResult HandleJump(ChannelConnection conn, Character character, string command, string[] args)
		{
			if (args.Length < 4)
				return CommandResult.InvalidArgument;

			float x, y, z;
			if (!float.TryParse(args[1], NumberStyles.Float, CultureInfo.InvariantCulture, out x) || !float.TryParse(args[2], NumberStyles.Float, CultureInfo.InvariantCulture, out y) || !float.TryParse(args[3], NumberStyles.Float, CultureInfo.InvariantCulture, out z))
				return CommandResult.InvalidArgument;

			character.X = x;
			character.Y = y;
			character.Z = z;

			var packet = new Packet(Op.ZC_SET_POS); // 22 (16)
			packet.PutInt(character.WorldId);
			packet.PutFloat(character.X);
			packet.PutFloat(character.Y);
			packet.PutFloat(character.Z);
			conn.Send(packet);

			return CommandResult.Okay;
		}

		private CommandResult HandleWarp(ChannelConnection conn, Character character, string command, string[] args)
		{
			if (args.Length < 5)
				return CommandResult.InvalidArgument;

			int zoneId;
			if (!int.TryParse(args[1], out zoneId))
				return CommandResult.InvalidArgument;

			float x, y, z;
			if (!float.TryParse(args[2], NumberStyles.Float, CultureInfo.InvariantCulture, out x) || !float.TryParse(args[3], NumberStyles.Float, CultureInfo.InvariantCulture, out y) || !float.TryParse(args[4], NumberStyles.Float, CultureInfo.InvariantCulture, out z))
				return CommandResult.InvalidArgument;

			character.X = x;
			character.Y = y;
			character.Z = z;

			if (character.ZoneId == zoneId)
			{
				var packet = new Packet(Op.ZC_SET_POS);
				packet.PutInt(character.WorldId);
				packet.PutFloat(character.X);
				packet.PutFloat(character.Y);
				packet.PutFloat(character.Z);
				conn.Send(packet);

				return CommandResult.Okay;
			}
			else
			{
				character.ZoneId = zoneId;

				var packet = new Packet(Op.ZC_MOVE_ZONE_OK); // Size: 57 (51)
				//_BYTE gap0[6];
				//_DWORD dword6;
				//_DWORD dwordA;
				//_DWORD dwordE;
				//_DWORD dword12;
				//float float16;
				//float float1A;
				//_BYTE gap1E[26];
				//_BYTE byte38;
				packet.PutInt(0);
				packet.PutInt(0x0100007F); // 127.0.0.1
				packet.PutInt(2001); // Port
				packet.PutInt(zoneId); // Zone id
				packet.PutFloat(38); // Camera X angle
				packet.PutFloat(45); // Camera Y angle
				packet.PutEmptyBin(26);
				packet.PutByte(0);
				conn.Send(packet);
			}
			return CommandResult.Okay;
		}
	}

	public class GmCommand : Command<GmCommandFunc>
	{
		public GmCommand(string name, string usage, string description, GmCommandFunc func)
			: base(name, usage, description, func)
		{
		}
	}

	public delegate CommandResult GmCommandFunc(ChannelConnection conn, Character character, string command, string[] args);
}
