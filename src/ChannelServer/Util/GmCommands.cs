// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.Network;
using Melia.Channel.World;
using Melia.Shared.Const;
using Melia.Shared.Data;
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
			// in the configuration file "commands.conf".

			// Official
			Add("requpdateequip", "", HandleReqUpdateEquip);

			// Normal
			Add("where", "", HandleWhere);
			Add("name", "<new name>", HandleName);

			// GMs
			Add("jump", "<x> <y> <z>", HandleJump);
			Add("warp", "<map id> <x> <y> <z>", HandleWarp);
			Add("item", "<item id> [amount]", HandleItem);
			Add("spawn", "<monster id> [amount=1]", HandleSpawn);
			Add("madhatter", "", HandleGetAllHats);
			Add("job", "<job id>", HandleJob);
			Add("levelup", "<levels>", HandleLevelUp);
			Add("speed", "<speed>", HandleSpeed);
			Add("iteminfo", "<name>", HandleItemInfo);
			Add("monsterinfo", "<name>", HandleMonsterInfo);
			Add("go", "<destination>", HandleGo);
			Add("clearinv", "", HandleClearInventory);

			// Dev
			Add("test", "", HandleTest);
			Add("reloadscripts", "", HandleReloadScripts);
			Add("reloadconf", "", HandleReloadConf);

			// Aliases
			AddAlias("iteminfo", "ii");
			AddAlias("monsterinfo", "mi");
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
			if (args.Length == 0 || (!args[0].StartsWith("/") && !args[0].StartsWith(ChannelServer.Instance.Conf.Commands.Prefix) && !args[0].StartsWith(ChannelServer.Instance.Conf.Commands.Prefix2)))
				return false;

			// Get command name
			var isCharCommand = args[0].StartsWith(ChannelServer.Instance.Conf.Commands.Prefix2);
			var commandName = args[0].TrimStart('/', ChannelServer.Instance.Conf.Commands.Prefix[0]);

			// Get command
			var command = this.GetCommand(commandName);
			if (command == null)
			{
				this.SystemMessage(character, "Command not found.");
				return true;
			}

			// Get target
			var target = character;
			if (isCharCommand)
			{
				if (args.Length < 2)
				{
					this.SystemMessage(character, "Char commands require a target.");
					return true;
				}

				var targetName = args[1];
				target = ChannelServer.Instance.World.GetCharacterByTeamName(targetName);
				if (target == null)
				{
					this.SystemMessage(character, "Target not found.");
					return true;
				}

				// Remove target name from arguments
				var larg = new List<string>(args);
				larg.RemoveAt(1);
				args = larg.ToArray();
			}

			// Check authority, commands with auth < 0 are disabled.
			var auth = ChannelServer.Instance.Conf.Commands.GetAuth(commandName);
			if ((!isCharCommand && auth.Auth < 0) || (isCharCommand && auth.CharAuth < 0))
			{
				this.SystemMessage(character, "This command has been disabled.");
				return true;
			}

			if ((!isCharCommand && conn.Account.Authority < auth.Auth) || (isCharCommand && conn.Account.Authority < auth.CharAuth))
			{
				this.SystemMessage(character, "Your authority level is too low to use this command.");
				return true;
			}

			// Execute command
			var result = command.Func(conn, character, target, message, args);
			if (result == CommandResult.Fail)
			{
				this.SystemMessage(character, "Failed to execute command.");
			}
			else if (result == CommandResult.InvalidArgument)
			{
				this.SystemMessage(character, "Invalid argument, usage: {0}{1} {2}", ChannelServer.Instance.Conf.Commands.Prefix, commandName, command.Usage);
			}

			return true;
		}

		/// <summary>
		/// Sends system message to character.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="format"></param>
		/// <param name="args"></param>
		private void SystemMessage(Character character, string format, params object[] args)
		{
			// Since there doesn't seem to be a custom system message packet,
			// we'll misuse chat for now.
			Send.ZC_CHAT(character.Connection, character, string.Format(format, args));
		}

		//-------------------------------------------------------------------

		private CommandResult HandleTest(ChannelConnection conn, Character character, Character target, string command, string[] args)
		{
			Log.Debug("test!!");

			return CommandResult.Okay;
		}

		private CommandResult HandleWhere(ChannelConnection conn, Character character, Character target, string command, string[] args)
		{
			this.SystemMessage(character, "You are here: {0} ({1}), {2}", target.Map.Name, target.Map.Id, target.Position);

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
					this.SystemMessage(character, "Map not found.");
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
				this.SystemMessage(character, "Map not found.");
			}

			return CommandResult.Okay;
		}

		private CommandResult HandleItem(ChannelConnection conn, Character character, Character target, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			int itemId;
			int amount = 1;

			// Get and check id
			if (!int.TryParse(args[1], out itemId))
				return CommandResult.InvalidArgument;

			if (!ChannelServer.Instance.Data.ItemDb.Exists(itemId))
			{
				this.SystemMessage(character, "Item not found.");
				return CommandResult.Okay;
			}

			// Get amount
			if (args.Length > 2)
			{
				if (!int.TryParse(args[2], out amount))
					return CommandResult.InvalidArgument;
			}

			// Create and add item
			var item = new Item(itemId, amount);
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

			var amount = 1;
			if (args.Length > 2 && !int.TryParse(args[2], out amount))
				return CommandResult.InvalidArgument;

			amount = Math2.Clamp(1, 100, amount);

			var monsterData = ChannelServer.Instance.Data.MonsterDb.Find(id);
			if (monsterData == null)
			{
				this.SystemMessage(character, "Monster not found.");
				return CommandResult.Okay;
			}

			var rnd = new Random(Environment.TickCount);
			for (int i = 0; i < amount; ++i)
			{
				var monster = new Monster(id, NpcType.Monster);

				Position pos;
				Direction dir;
				if (amount == 1)
				{
					pos = target.Position;
					dir = target.Direction;
				}
				else
				{
					pos = target.Position.GetRandomInRange2D(amount * 4, rnd);
					dir = new Direction(rnd.Next(0, 360));
				}

				monster.Position = pos;
				monster.Direction = dir;

				target.Map.AddMonster(monster);
			}

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

			this.SystemMessage(target, "Added {0} hats to inventory.", added);

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
				this.SystemMessage(character, "Name already exists.");
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
				this.SystemMessage(character, "Unknown job.");
				return CommandResult.Okay;
			}

			target.Job = (Job)jobId;
			Send.ZC_PC(target, PcUpdateType.Job, (short)jobId);
			Send.ZC_UPDATED_PCAPPEARANCE(target);

			return CommandResult.Okay;
		}

		private CommandResult HandleReloadScripts(ChannelConnection conn, Character character, Character target, string command, string[] args)
		{
			this.SystemMessage(character, "Reloading scripts...");

			ChannelServer.Instance.ScriptManager.Reload();

			this.SystemMessage(character, "Done.");

			return CommandResult.Okay;
		}

		private CommandResult HandleReloadConf(ChannelConnection conn, Character character, Character target, string command, string[] args)
		{
			this.SystemMessage(character, "Reloading configuration...");

			ChannelServer.Instance.Conf.LoadAll();

			this.SystemMessage(character, "Done.");

			return CommandResult.Okay;
		}

		private CommandResult HandleLevelUp(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			int levels;
			if (!int.TryParse(args[1], out levels) || levels < 1 || levels > 10)
				return CommandResult.InvalidArgument;

			// Set exp to 0, ZC_MAX_EXP_CHANGED apparently doesn't update the
			// exp bar if the exp didn't change.
			target.Exp = 0;

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
				this.SystemMessage(sender, "No items found for '{0}'.", search);
				return CommandResult.Okay;
			}

			var eItems = items.OrderBy(a => a.Name.LevenshteinDistance(search)).ThenBy(a => a.Id).GetEnumerator();
			var max = 20;
			for (int i = 0; eItems.MoveNext() && i < max; ++i)
			{
				var item = eItems.Current;
				this.SystemMessage(sender, "{0}: {1}, Category: {2}", item.Id, item.Name, item.Category);
			}

			this.SystemMessage(sender, "Results: {0} (Max. {1} shown)", items.Count, max);

			return CommandResult.Okay;
		}

		private CommandResult HandleMonsterInfo(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			var search = command.Substring(command.IndexOf(" ")).Trim();
			var monsters = ChannelServer.Instance.Data.MonsterDb.FindAll(search);
			if (monsters.Count == 0)
			{
				this.SystemMessage(sender, "No monsters found for '{0}'.", search);
				return CommandResult.Okay;
			}

			var entries = monsters.OrderBy(a => a.Name.LevenshteinDistance(search)).ThenBy(a => a.Id).GetEnumerator();
			var max = 20;
			for (int i = 0; entries.MoveNext() && i < max; ++i)
			{
				var current = entries.Current;
				this.SystemMessage(sender, "{0}: {1}", current.Id, current.Name);
			}

			this.SystemMessage(sender, "Results: {0} (Max. {1} shown)", monsters.Count, max);

			return CommandResult.Okay;
		}

		private CommandResult HandleGo(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			if (args.Length < 2)
			{
				this.SystemMessage(sender, "Destinations: klaipeda, orsha");
				return CommandResult.InvalidArgument;
			}

			if (args[1].StartsWith("klaip"))
				target.Warp("c_Klaipe", -75, 148, -24);
			else if (args[1].StartsWith("ors"))
				target.Warp("c_orsha", 271, 176, 292);
			else
				this.SystemMessage(sender, "Unknown destination.");

			return CommandResult.Okay;
		}

		private CommandResult HandleClearInventory(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			target.Inventory.Clear();

			this.SystemMessage(sender, "Inventory cleared.");

			return CommandResult.Okay;
		}

		private CommandResult HandleReqUpdateEquip(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			// Command is sent when the inventory is opened, purpose unknown,
			// officials don't seem to send anything back.

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
