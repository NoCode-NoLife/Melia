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
			Add("test", "", HandleTest);
			Add("where", "", HandleWhere);
			Add("jump", "<x> <y> <z>", HandleJump);
			Add("warp", "<map id> <x> <y> <z>", HandleWarp);
			Add("item", "<item id>", HandleItem);
			Add("spawn", "<monster id>", HandleSpawn);
			Add("madhatter", "", HandleGetAllHats);
			Add("name", "<new name>", HandleName);
			Add("job", "<job id>", HandleJob);
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
				Send.ZC_CHAT(character, "Failed to execute command.");
			}
			else if (result == CommandResult.InvalidArgument)
			{
				Send.ZC_CHAT(character, "Invalid argument, usage: {0}{1} {2}", '/', commandName, command.Usage);
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
			Send.ZC_CHAT(character, "You are here: {0} - {1}", character.MapId, character.Position);

			return CommandResult.Okay;
		}

		private CommandResult HandleJump(ChannelConnection conn, Character character, string command, string[] args)
		{
			if (args.Length < 4)
				return CommandResult.InvalidArgument;

			float x, y, z;
			if (!float.TryParse(args[1], NumberStyles.Float, CultureInfo.InvariantCulture, out x) || !float.TryParse(args[2], NumberStyles.Float, CultureInfo.InvariantCulture, out y) || !float.TryParse(args[3], NumberStyles.Float, CultureInfo.InvariantCulture, out z))
				return CommandResult.InvalidArgument;

			character.Position = new Position(x, y, z);

			Send.ZC_SET_POS(character);

			return CommandResult.Okay;
		}

		private CommandResult HandleWarp(ChannelConnection conn, Character character, string command, string[] args)
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

			character.Position = new Position(x, y, z);

			if (character.MapId == mapId)
			{
				Send.ZC_SET_POS(character);

				return CommandResult.Okay;
			}
			else
			{
				character.MapId = mapId;

				Send.ZC_MOVE_ZONE_OK(conn, "127.0.0.1", 2001, mapId);
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

			if (!ChannelServer.Instance.Data.ItemDb.Exists(itemId))
			{
				Send.ZC_CHAT(character, "Item not found.");
				return CommandResult.Okay;
			}

			var item = new Item(itemId);

			character.Inventory.Add(item, InventoryAddType.PickUp);

			return CommandResult.Okay;
		}

		private CommandResult HandleSpawn(ChannelConnection conn, Character character, string command, string[] args)
		{
			if (args.Length < 2)
				return CommandResult.InvalidArgument;

			int id;
			if (!int.TryParse(args[1], out id))
				return CommandResult.InvalidArgument;

			var monster = new Monster(id, NpcType.Monster);

			monster.Position = character.Position;
			monster.Direction = character.Direction;

			character.Map.AddMonster(monster);

			return CommandResult.Okay;
		}

		private CommandResult HandleGetAllHats(ChannelConnection conn, Character character, string command, string[] args)
		{
			var added = 0;
			for (int itemId = 628001; itemId <= 628099; ++itemId)
			{
				if (!ChannelServer.Instance.Data.ItemDb.Exists(itemId))
					continue;

				if (!character.Inventory.HasItem(itemId))
				{
					character.Inventory.Add(new Item(itemId), InventoryAddType.PickUp);
					added++;
				}
			}

			Send.ZC_CHAT(character, "Added {0} hats to inventory.", added);

			return CommandResult.Okay;
		}

		private CommandResult HandleName(ChannelConnection conn, Character character, string command, string[] args)
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

			character.Name = newName;
			Send.ZC_PC(character, PcUpdateType.Name, newName);

			return CommandResult.Okay;
		}

		private CommandResult HandleJob(ChannelConnection conn, Character character, string command, string[] args)
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

			character.Job = (Job)jobId;
			Send.ZC_PC(character, PcUpdateType.Job, (short)jobId);
			Send.ZC_UPDATED_PCAPPEARANCE(character);

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
