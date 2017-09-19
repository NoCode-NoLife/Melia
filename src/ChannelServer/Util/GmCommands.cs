// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Melia.Channel.Network;
using Melia.Channel.World;
using Melia.Shared.Const;
using Melia.Shared.Util;
using Melia.Shared.Util.Commands;
using Melia.Shared.World;

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
			Add("requpdateequip", "", this.HandleReqUpdateEquip);
			Add("buyabilpoint", "<amount>", this.HandleBuyAbilPoint);

			// Normal
			Add("where", "", this.HandleWhere);
			Add("name", "<new name>", this.HandleName);

			// GMs
			Add("jump", "<x> <y> <z>", this.HandleJump);
			Add("warp", "<map id> <x> <y> <z>", this.HandleWarp);
			Add("item", "<item id> [amount]", this.HandleItem);
			Add("spawn", "<monster id> [amount=1]", this.HandleSpawn);
			Add("madhatter", "", this.HandleGetAllHats);
			Add("levelup", "<levels>", this.HandleLevelUp);
			Add("speed", "<speed>", this.HandleSpeed);
			Add("iteminfo", "<name>", this.HandleItemInfo);
			Add("monsterinfo", "<name>", this.HandleMonsterInfo);
			Add("go", "<destination>", this.HandleGo);
			Add("goto", "<team name>", this.HandleGoTo);
			Add("recall", "<team name>", this.HandleRecall);
			Add("clearinv", "", this.HandleClearInventory);
			Add("addjob", "<job id> [circle]", this.HandleAddJob);
			Add("removejob", "<job id>", this.HandleRemoveJob);
			Add("skillpoints", "<job id> <modifier>", this.HandleSkillPoints);
			Add("statpoints", "<amount>", this.HandleStatPoints);

			// Dev
			Add("test", "", this.HandleTest);
			Add("reloadscripts", "", this.HandleReloadScripts);
			Add("reloadconf", "", this.HandleReloadConf);

			// Aliases
			AddAlias("iteminfo", "ii");
			AddAlias("monsterinfo", "mi");
			AddAlias("reloadscripts", "rs");
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
				character.ServerMessage("Command not found.");
				return true;
			}

			// Get target
			var target = character;
			if (isCharCommand)
			{
				if (args.Length < 2)
				{
					character.ServerMessage("Char commands require a target.");
					return true;
				}

				var targetName = args[1];
				target = ChannelServer.Instance.World.GetCharacterByTeamName(targetName);
				if (target == null)
				{
					character.ServerMessage("Target not found.");
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
				character.ServerMessage("This command has been disabled.");
				return true;
			}

			if ((!isCharCommand && conn.Account.Authority < auth.Auth) || (isCharCommand && conn.Account.Authority < auth.CharAuth))
			{
				character.ServerMessage("Your authority level is too low to use this command.");
				return true;
			}

			// Execute command
			var result = command.Func(conn, character, target, message, args);
			if (result == CommandResult.Fail)
			{
				character.ServerMessage("Failed to execute command.");
			}
			else if (result == CommandResult.InvalidArgument)
			{
				character.ServerMessage("Invalid argument, usage: {0}{1} {2}", ChannelServer.Instance.Conf.Commands.Prefix, commandName, command.Usage);
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
			character.ServerMessage("You are here: {0} ({1}), {2}", target.Map.Name, target.Map.Id, target.Position);

			return CommandResult.Okay;
		}

		private CommandResult HandleJump(ChannelConnection conn, Character character, Character target, string command, string[] args)
		{
			if (args.Length < 4)
				return CommandResult.InvalidArgument;

			if (!float.TryParse(args[1], NumberStyles.Float, CultureInfo.InvariantCulture, out var x) || !float.TryParse(args[2], NumberStyles.Float, CultureInfo.InvariantCulture, out var y) || !float.TryParse(args[3], NumberStyles.Float, CultureInfo.InvariantCulture, out var z))
				return CommandResult.InvalidArgument;

			target.Position = new Position(x, y, z);

			Send.ZC_SET_POS(target);

			return CommandResult.Okay;
		}

		private CommandResult HandleWarp(ChannelConnection conn, Character character, Character target, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			float x = 0, y = 0, z = 0;

			if (!int.TryParse(args[1], out var mapId))
			{
				var data = ChannelServer.Instance.Data.MapDb.Find(args[1]);
				if (data == null)
				{
					character.ServerMessage("Map not found.");
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
				character.ServerMessage("Map not found.");
			}

			return CommandResult.Okay;
		}

		private CommandResult HandleItem(ChannelConnection conn, Character character, Character target, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			var amount = 1;

			// Get and check id
			if (!int.TryParse(args[1], out var itemId))
				return CommandResult.InvalidArgument;

			if (!ChannelServer.Instance.Data.ItemDb.Exists(itemId))
			{
				character.ServerMessage("Item not found.");
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

			if (!int.TryParse(args[1], out var id))
				return CommandResult.InvalidArgument;

			var amount = 1;
			if (args.Length > 2 && !int.TryParse(args[2], out amount))
				return CommandResult.InvalidArgument;

			amount = Math2.Clamp(1, 100, amount);

			var monsterData = ChannelServer.Instance.Data.MonsterDb.Find(id);
			if (monsterData == null)
			{
				character.ServerMessage("Monster not found.");
				return CommandResult.Okay;
			}

			var rnd = new Random(Environment.TickCount);
			for (var i = 0; i < amount; ++i)
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
			for (var itemId = 628001; itemId <= 629503; ++itemId)
			{
				if (!ChannelServer.Instance.Data.ItemDb.Exists(itemId))
					continue;

				if (!character.Inventory.HasItem(itemId))
				{
					character.Inventory.Add(new Item(itemId), InventoryAddType.PickUp);
					added++;
				}
			}

			target.ServerMessage("Added {0} hats to inventory.", added);

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
				character.ServerMessage("Name already exists.");
				return CommandResult.Okay;
			}

			target.Name = newName;
			Send.ZC_PC(target, PcUpdateType.Name, newName);

			return CommandResult.Okay;
		}

		private CommandResult HandleReloadScripts(ChannelConnection conn, Character character, Character target, string command, string[] args)
		{
			character.ServerMessage("Reloading scripts...");

			ChannelServer.Instance.ScriptManager.Reload();

			character.ServerMessage("Done.");

			return CommandResult.Okay;
		}

		private CommandResult HandleReloadConf(ChannelConnection conn, Character character, Character target, string command, string[] args)
		{
			character.ServerMessage("Reloading configuration...");

			ChannelServer.Instance.Conf.LoadAll();

			character.ServerMessage("Done.");

			return CommandResult.Okay;
		}

		private CommandResult HandleLevelUp(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			if (!int.TryParse(args[1], out var levels) || levels < 1)
				return CommandResult.InvalidArgument;

			// Set exp to 0, ZC_MAX_EXP_CHANGED apparently doesn't update the
			// exp bar if the exp didn't change.
			target.Exp = 0;

			target.LevelUp(levels);

			return CommandResult.Okay;
		}

		private CommandResult HandleSpeed(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			if (!float.TryParse(args[1], out var speed))
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
				sender.ServerMessage("No items found for '{0}'.", search);
				return CommandResult.Okay;
			}

			var eItems = items.OrderBy(a => a.Name.LevenshteinDistance(search)).ThenBy(a => a.Id).GetEnumerator();
			var max = 20;
			for (var i = 0; eItems.MoveNext() && i < max; ++i)
			{
				var item = eItems.Current;
				sender.ServerMessage("{0}: {1}, Category: {2}", item.Id, item.Name, item.Category);
			}

			sender.ServerMessage("Results: {0} (Max. {1} shown)", items.Count, max);

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
				sender.ServerMessage("No monsters found for '{0}'.", search);
				return CommandResult.Okay;
			}

			var entries = monsters.OrderBy(a => a.Name.LevenshteinDistance(search)).ThenBy(a => a.Id).GetEnumerator();
			var max = 20;
			for (var i = 0; entries.MoveNext() && i < max; ++i)
			{
				var current = entries.Current;
				sender.ServerMessage("{0}: {1}", current.Id, current.Name);
			}

			sender.ServerMessage("Results: {0} (Max. {1} shown)", monsters.Count, max);

			return CommandResult.Okay;
		}

		private CommandResult HandleGo(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			if (args.Length < 2)
			{
				sender.ServerMessage("Destinations: klaipeda, orsha");
				return CommandResult.InvalidArgument;
			}

			if (args[1].StartsWith("klaip"))
				target.Warp("c_Klaipe", -75, 148, -24);
			else if (args[1].StartsWith("ors"))
				target.Warp("c_orsha", 271, 176, 292);
			else
				sender.ServerMessage("Unknown destination.");

			return CommandResult.Okay;
		}

		private CommandResult HandleGoTo(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			// TODO: Once we have support for more than one map server,
			//   we have to search for characters across all of them.

			var teamName = args[1];
			var character = ChannelServer.Instance.World.GetCharacterByTeamName(teamName);
			if (character == null)
			{
				sender.ServerMessage("Character not found.");
				return CommandResult.Okay;
			}

			var location = character.GetLocation();
			target.Warp(location);

			target.ServerMessage("You've been warped to {0}.", location);

			return CommandResult.Okay;
		}

		private CommandResult HandleRecall(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			// TODO: Once we have support for more than one map server,
			//   we have to search for characters across all of them.

			var teamName = args[1];
			var character = ChannelServer.Instance.World.GetCharacterByTeamName(teamName);
			if (character == null)
			{
				sender.ServerMessage("Character not found.");
				return CommandResult.Okay;
			}

			var location = target.GetLocation();
			character.Warp(location);

			character.ServerMessage("You've been warped to {0}.", location);

			return CommandResult.Okay;
		}

		private CommandResult HandleClearInventory(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			target.Inventory.Clear();

			sender.ServerMessage("Inventory cleared.");

			return CommandResult.Okay;
		}

		private CommandResult HandleReqUpdateEquip(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			// Command is sent when the inventory is opened, purpose unknown,
			// officials don't seem to send anything back.

			return CommandResult.Okay;
		}

		private CommandResult HandleBuyAbilPoint(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			// Since this command is sent via UI interactions, we'll not
			// use any automated command result messages, but we'll leave
			// debug messages for now, in case of unexpected values.

			if (args.Length < 0)
			{
				Log.Debug("HandleBuyAbilPoint: No amount given by user '{0}'.", conn.Account.Name);
				return CommandResult.Okay;
			}

			if (!int.TryParse(args[1], out var amount))
			{
				Log.Debug("HandleBuyAbilPoint: Invalid amount '{0}' by user '{1}'.", amount, conn.Account.Name);
				return CommandResult.Okay;
			}

			var cost = (amount * 1000);
			var silver = sender.Inventory.CountItem(ItemId.Silver);
			if (silver < cost)
			{
				Log.Debug("HandleBuyAbilPoint: User '{0}' didn't have enough money.", conn.Account.Name);
				return CommandResult.Okay;
			}

			sender.Inventory.Remove(ItemId.Silver, cost, InventoryItemRemoveMsg.Given);
			sender.ModifyAbilityPoints(amount);
			Send.ZC_ADDON_MSG(sender, "SUCCESS_BUY_ABILITY_POINTBLANK");

			return CommandResult.Okay;
		}

		private CommandResult HandleAddJob(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			if (!int.TryParse(args[1], out var iJobId))
				return CommandResult.InvalidArgument;

			if (!ChannelServer.Instance.Data.JobDb.Exists(iJobId))
			{
				sender.ServerMessage("Job data for '{0}' not found.", iJobId);
				return CommandResult.Okay;
			}

			var jobId = (JobId)iJobId;
			var circle = Circle.First;

			if (args.Length > 2)
			{
				if (!short.TryParse(args[2], out var iCircle) || iCircle < (short)Circle.First || !Enum.IsDefined(typeof(Circle), iCircle))
					return CommandResult.InvalidArgument;

				circle = (Circle)iCircle;
			}

			var job = target.Jobs.Get(jobId);
			if (job != null && job.Circle >= circle)
			{
				sender.ServerMessage("The job exists already, at an equal or higher circle.");
				return CommandResult.Okay;
			}

			if (job == null)
				target.Jobs.Add(new Job(jobId) { Circle = circle });
			else
				target.Jobs.ChangeCircle(jobId, circle);

			sender.ServerMessage("Job '{0}' was added at circle '{1}'.", jobId, (int)circle);

			return CommandResult.Okay;
		}

		private CommandResult HandleRemoveJob(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			if (!int.TryParse(args[1], out var iJobId))
				return CommandResult.InvalidArgument;

			var jobId = (JobId)iJobId;

			if (!target.Jobs.Remove(jobId))
			{
				sender.ServerMessage("The job doesn't exist.");
				return CommandResult.Okay;
			}

			sender.ServerMessage("Job '{0}' was removed. Login again to see the change.", jobId);

			return CommandResult.Okay;
		}

		private CommandResult HandleSkillPoints(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			if (args.Length < 3)
				return CommandResult.InvalidArgument;

			if (!int.TryParse(args[1], out var iJobId))
				return CommandResult.InvalidArgument;

			if (!int.TryParse(args[2], out var modifier))
				return CommandResult.InvalidArgument;

			var jobId = (JobId)iJobId;

			if (!target.Jobs.ModifySkillPoints(jobId, modifier))
			{
				sender.ServerMessage("The job doesn't exist.");
				return CommandResult.Okay;
			}

			sender.ServerMessage("Modified {0}'s skill points by {1:+0;-0;0}.", jobId, modifier);

			return CommandResult.Okay;
		}

		private CommandResult HandleStatPoints(ChannelConnection conn, Character sender, Character target, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			if (!int.TryParse(args[1], out var amount) || amount < 1)
				return CommandResult.InvalidArgument;

			// Modification for stat points is a little tricky, because ToS
			// has 3 stat points properties:
			// - Stat points gained by leveling
			// - Stat points gained in another way
			// - Used stat points
			// When increasing stats, "Used" is increased and the others are
			// left alone. I'll make this adding-only for now, until I feel
			// like untangling modifying them.

			target.AddStatPoints(amount);

			sender.ServerMessage("Added {0} stat points.", amount);

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
