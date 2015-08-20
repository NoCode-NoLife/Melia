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
			Add("item", "<item id>", HandleItem);
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
				Send.ZC_SYSTEM_MSG(character, "Failed to execute command.");
			}
			else if (result == CommandResult.InvalidArgument)
			{
				Send.ZC_SYSTEM_MSG(character, "Invalid argument, usage: {0}{1} {2}", '/', commandName, command.Usage);
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
			Send.ZC_SYSTEM_MSG(character, "You are here: {0} - {1}, {2}, {3}", character.ZoneId, character.X.ToString(CultureInfo.InvariantCulture), character.Y.ToString(CultureInfo.InvariantCulture), character.Z.ToString(CultureInfo.InvariantCulture));

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

			Send.ZC_SET_POS(character);

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
				Send.ZC_SET_POS(character);

				return CommandResult.Okay;
			}
			else
			{
				character.ZoneId = zoneId;

				Send.ZC_MOVE_ZONE_OK(conn, "127.0.0.1", 2001, zoneId);
			}
			return CommandResult.Okay;
		}

		private CommandResult HandleItem(ChannelConnection conn, Character character, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			int itemId;
			if (!int.TryParse(args[1], out itemId))
				return CommandResult.InvalidArgument;

			var item = new Item(itemId);

			character.Inventory.Add(item);

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
