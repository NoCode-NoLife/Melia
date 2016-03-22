// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.Network;
using Melia.Channel.World;
using Melia.Shared.Const;
using Melia.Shared.Network;
using Melia.Shared.Util;
using Melia.Shared.Util.Commands;
using Melia.Shared.World;
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
			// The required authority levels for commands can be specified
			// in the configuration  file "commands.conf".

			// Normal
			Add("where", "", HandleWhere);
			Add("name", "<new name>", HandleName);

			// GMs
			Add("jump", "<x> <y> <z>", HandleJump);
			Add("warp", "<map id> <x> <y> <z>", HandleWarp);
			Add("item", "<item id>", HandleItem);
			Add("spawn", "<monster id>", HandleSpawn);
			Add("madhatter", "", HandleGetAllHats);
			Add("job", "<job id>", HandleJob);
			Add("levelup", "<levels>", HandleLevelUp);
			Add("speed", "<speed>", HandleSpeed);
			Add("iteminfo", "<name>", HandleItemInfo);
			Add("go", "<destination>", HandleGo);

			// Dev
			Add("test", "", HandleTest);
			Add("reloadscripts", "", HandleReloadScripts);

			// Aliases
			AddAlias("iteminfo", "ii");
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
		/// Adds alias for command.
		/// </summary>
		/// <example>
		/// AddAlias("iteminfo", "ii"); // Allow iteminfo to be called with ii
		/// </example>
		/// <param name="commandName"></param>
		/// <param name="alias"></param>
		public void AddAlias(string commandName, string alias)
		{
			var command = this.GetCommand(commandName);
			if (command == null)
			{
				Log.Error("GmCommands.AddAlias: Command '{0}' not found.", commandName);
				return;
			}

			_commands[alias] = command;
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

			// Get command name
			var isCharCommand = args[0].StartsWith(ChannelServer.Instance.Conf.Commands.Prefix2);
			var commandName = args[0].TrimStart(ChannelServer.Instance.Conf.Commands.Prefix);

			// Get command
			var command = this.GetCommand(commandName);
			if (command == null)
				return false;

			// Get target
			var target = character;
			if (isCharCommand)
			{
				if (args.Length < 2)
				{
					Send.ZC_CHAT(character, "Char commands require a target.");
					return true;
				}

				var targetName = args[1];
				target = ChannelServer.Instance.World.GetCharacterByTeamName(targetName);
				if (target == null)
				{
					Send.ZC_CHAT(character, "Target not found.");
					return true;
				}

				// Remove target name from arguments
				var larg = new List<string>(args);
				larg.RemoveAt(1);
				args = larg.ToArray();
			}

			// Check authority, commands with auth < 0 are disabled.
			var auth = ChannelServer.Instance.Conf.Commands.GetAuth(args[0]);
			if ((!isCharCommand && auth.Auth < 0) || (isCharCommand && auth.CharAuth < 0))
			{
				Send.ZC_CHAT(character, "This command has been disabled.");
				return true;
			}

			if ((!isCharCommand && conn.Account.Authority < auth.Auth) || (isCharCommand && conn.Account.Authority < auth.CharAuth))
			{
				Send.ZC_CHAT(character, "Your authority level is too low to use this command.");
				return true;
			}

			// Execute command
			var result = command.Func(conn, character, target, message, args);
			if (result == CommandResult.Fail)
			{
				Send.ZC_CHAT(character, "Failed to execute command.");
			}
			else if (result == CommandResult.InvalidArgument)
			{
				Send.ZC_CHAT(character, "Invalid argument, usage: {0}{1} {2}", ChannelServer.Instance.Conf.Commands.Prefix, commandName, command.Usage);
			}

			return true;
		}

		//-------------------------------------------------------------------

		private CommandResult HandleTest(ChannelConnection conn, Character character, Character target, string command, string[] args)
		{
			Log.Debug("test!!");

			return CommandResult.Okay;
		}

		private CommandResult HandleWhere(ChannelConnection conn, Character character, Character target, string command, string[] args)
		{
			Send.ZC_CHAT(character, "You are here: {0} ({1}), {2}", target.Map.Name, target.Map.Id, target.Position);

			return CommandResult.Okay;
		}

		private CommandResult HandleJump(ChannelConnection conn, Character character, Character target, string command, string[] args)
		{
			if (args.Length < 4)
				return CommandResult.InvalidArgument;

			float x, y, z;
			if (!float.TryParse(args[1], NumberStyles.Float, CultureInfo.InvariantCulture, out x) || !float.TryParse(args[2], NumberStyles.Float, CultureInfo.InvariantCulture, out y) || !float.TryParse(args[3], NumberStyles.Float, CultureInfo.InvariantCulture, out z))
				return CommandResult.InvalidArgument;

			target.Position = new Position(x, y, z);

			Send.ZC_SET_POS(target);

			return CommandResult.Okay;
		}

		private CommandResult HandleWarp(ChannelConnection conn, Character character, Character target, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			int mapId;
			float x = 0, y = 0, z = 0;

			if (!int.TryParse(args[1], out mapId))
			{
				var data = ChannelServer.Instance.Data.MapDb.Find(args[1]);
				if (data == null)
				{
					Send.ZC_CHAT(character, "Map not found.");
					return CommandResult.Okay;
				}

				mapId = data.Id;
			}

			if (args.Length >= 5)
			{
				if (!float.TryParse(args[2], NumberStyles.Float, CultureInfo.InvariantCulture, out x) || !float.TryParse(args[3], NumberStyles.Float, CultureInfo.InvariantCulture, out y) || !float.TryParse(args[4], NumberStyles.Float, CultureInfo.InvariantCulture, out z))
					return CommandResult.InvalidArgument;
			}

			try
			{
				target.Warp(mapId, x, y, z);
			}
			catch (ArgumentException)
			{
				Send.ZC_CHAT(character, "Map not found.");
			}

			return CommandResult.Okay;
		}

		private CommandResult HandleItem(ChannelConnection conn, Character character, Character target, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			int itemId;
			if (!int.TryParse(args[1], out itemId))
				return CommandResult.InvalidArgument;

			if (!ChannelServer.Instance.Data.ItemDb.Exists(itemId))
			{
				Send.ZC_CHAT(character, "Item not found.");
				return CommandResult.Okay;
			}

			var item = new Item(itemId);

			target.Inventory.Add(item, InventoryAddType.PickUp);

			return CommandResult.Okay;
		}

		private CommandResult HandleSpawn(ChannelConnection conn, Character character, Character target, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			int id;
			if (!int.TryParse(args[1], out id))
				return CommandResult.InvalidArgument;

			var monster = new Monster(id, NpcType.Monster);

			monster.Position = target.Position;
			monster.Direction = target.Direction;

			target.Map.AddMonster(monster);

			return CommandResult.Okay;
		}

		private CommandResult HandleGetAllHats(ChannelConnection conn, Character character, Character target, string command, string[] args)
		{
			var added = 0;
			for (int itemId = 628001; itemId <= 629502; ++itemId)
			{
				if (!ChannelServer.Instance.Data.ItemDb.Exists(itemId))
					continue;

				if (!character.Inventory.HasItem(itemId))
				{
					character.Inventory.Add(new Item(itemId), InventoryAddType.PickUp);
					added++;
				}
			}

			Send.ZC_CHAT(target, "Added {0} hats to inventory.", added);

			return CommandResult.Okay;
		}

		private CommandResult HandleName(ChannelConnection conn, Character character, Character target, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			var newName = args[1];
			if (newName == character.Name)
				return CommandResult.Okay;

			// TODO: Can you rename any time, without cooldown?

			// TODO: Keep a list of all account characters after all?
			if (ChannelServer.Instance.Database.CharacterExists(conn.Account.Id, newName))
			{
				Send.ZC_CHAT(character, "Name already exists.");
				return CommandResult.Okay;
			}

			target.Name = newName;
			Send.ZC_PC(target, PcUpdateType.Name, newName);

			return CommandResult.Okay;
		}

		private CommandResult HandleJob(ChannelConnection conn, Character character, Character target, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			short jobId;
			if (!short.TryParse(args[1], out jobId))
				return CommandResult.InvalidArgument;

			if (!Enum.IsDefined(typeof(Job), jobId))
			{
				Send.ZC_CHAT(character, "Unknown job.");
				return CommandResult.Okay;
			}

			target.Job = (Job)jobId;
			Send.ZC_PC(target, PcUpdateType.Job, (short)jobId);
			Send.ZC_UPDATED_PCAPPEARANCE(target);

			return CommandResult.Okay;
		}

		private CommandResult HandleReloadScripts(ChannelConnection conn, Character character, Character target, string command, string[] args)
		{
			Send.ZC_CHAT(character, "Reloading scripts...");

			ChannelServer.Instance.ScriptManager.Reload();

			Send.ZC_CHAT(character, "Done.");

			return CommandResult.Okay;
		}

		private CommandResult HandleLevelUp(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			int levels;
			if (!int.TryParse(args[1], out levels) || levels < 1 || levels > 10)
				return CommandResult.InvalidArgument;

			for (int i = 0; i < levels; ++i)
				target.LevelUp();

			return CommandResult.Okay;
		}

		private CommandResult HandleSpeed(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			float speed;
			if (!float.TryParse(args[1], out speed))
				return CommandResult.InvalidArgument;

			target.Speed = speed;
			Send.ZC_MOVE_SPEED(target);

			return CommandResult.Okay;
		}

		private CommandResult HandleItemInfo(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			var search = command.Substring(command.IndexOf(" ")).Trim();
			var items = ChannelServer.Instance.Data.ItemDb.FindAll(search);
			if (items.Count == 0)
			{
				Send.ZC_CHAT(sender, "No items found for '{0}'.", search);
				return CommandResult.Okay;
			}

			var eItems = items.OrderBy(a => a.Name.LevenshteinDistance(search)).ThenBy(a => a.Id).GetEnumerator();
			var max = 20;
			for (int i = 0; eItems.MoveNext() && i < max; ++i)
			{
				var item = eItems.Current;
				Send.ZC_CHAT(sender, "{0}: {1}, Category: {2}", item.Id, item.Name, item.Category);
			}

			Send.ZC_CHAT(sender, "Results: {0} (Max. {1} shown)", items.Count, max);

			return CommandResult.Okay;
		}

		private CommandResult HandleGo(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			if (args.Length < 2)
			{
				Send.ZC_CHAT(sender, "Destinations: klaipeda, orsha");
				return CommandResult.InvalidArgument;
			}

			if (args[1].StartsWith("klaip"))
				target.Warp("c_Klaipe", -75, 148, -24);
			else if (args[1].StartsWith("ors"))
				target.Warp("c_orsha", 271, 176, 292);
			else
				Send.ZC_CHAT(sender, "Unknown destination.");

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

	public delegate CommandResult GmCommandFunc(ChannelConnection conn, Character sender, Character target, string command, string[] args);
}
