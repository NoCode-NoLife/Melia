﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Melia.Shared.Data.Database;
using Melia.Shared.L10N;
using Melia.Shared.Network;
using Melia.Shared.Network.Inter.Messages;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Items;
using Yggdrasil.Extensions;
using Yggdrasil.Logging;
using Yggdrasil.Network.Communication;
using Yggdrasil.Util;
using Yggdrasil.Util.Commands;

namespace Melia.Zone.Commands
{
	/// <summary>
	/// The chat command manager, holding the commands and executing them.
	/// </summary>
	public partial class ChatCommands : CommandManager<ChatCommand, ChatCommandFunc>
	{
		/// <summary>
		/// Creates new manager and initializes it.
		/// </summary>
		public ChatCommands()
		{
			// The required authority levels for commands can be specified
			// in the configuration file "conf/commands.conf".

			// Client Commands
			this.Add("requpdateequip", "", "", this.HandleReqUpdateEquip);
			this.Add("buyabilpoint", "<amount>", "", this.HandleBuyAbilPoint);

			// Custom Client Commands
			this.Add("buyshop", "", "", this.HandleBuyShop);
			this.Add("updatemouse", "", "", this.HandleUpdateMouse);

			// Normal
			this.Add("where", "", "Displays current location.", this.HandleWhere);
			this.Add("name", "<new name>", "Changes character name.", this.HandleName);
			this.Add("time", "", "Displays the current server and game time.", this.HandleTime);
			this.Add("help", "[command]", "Displays available commands or information about a certain command.", this.HandleHelp);

			// VIP
			this.Add("autoloot", "", "Toggles autolooting.", this.HandleAutoloot);

			// GMs
			this.Add("jump", "<x> <y> <z>", "Teleports to given location on the same map.", this.HandleJump);
			this.Add("warp", "<map id> <x> <y> <z>", "Warps to another map.", this.HandleWarp);
			this.Add("item", "<item id> [amount]", "Spawns item.", this.HandleItem);
			this.Add("silver", "<modifier>", "Spawns silver.", this.HandleSilver);
			this.Add("spawn", "<monster id|class name> [amount=1] ['ai'=BasicMonster] ['tendency'=peaceful]", "Spawns monster.", this.HandleSpawn);
			this.Add("madhatter", "", "Spawns all headgears.", this.HandleGetAllHats);
			this.Add("levelup", "<levels>", "Increases character's level.", this.HandleLevelUp);
			this.Add("speed", "<speed>", "Modifies character's speed.", this.HandleSpeed);
			this.Add("iteminfo", "<name>", "Displays information about an item.", this.HandleItemInfo);
			this.Add("monsterinfo", "<name>", "Displays information about a monster.", this.HandleMonsterInfo);
			this.Add("whodrops", "<name>", "Finds monsters that drop a given item", this.HandleWhoDrops);
			this.Add("go", "<destination>", "Warps to certain pre-defined destinations.", this.HandleGo);
			this.Add("goto", "<team name>", "Warps to another character.", this.HandleGoTo);
			this.Add("recall", "<team name>", "Warps another character back.", this.HandleRecall);
			this.Add("recallmap", "[map id/name]", "Warps all characters on given map back.", this.HandleRecallMap);
			this.Add("recallall", "", "Warps all characters on the server back.", this.HandleRecallAll);
			this.Add("heal", "[hp] [sp] [stamina]", "Heals the character's HP, SP, and Stamina.", this.HandleHeal);
			this.Add("clearinv", "", "Removes all items from inventory.", this.HandleClearInventory);
			this.Add("addjob", "<job id> [circle]", "Adds a job to character.", this.HandleAddJob);
			this.Add("removejob", "<job id>", "Removes a job from character.", this.HandleRemoveJob);
			this.Add("skillpoints", "<job id> <modifier>", "Modifies character's skill points.", this.HandleSkillPoints);
			this.Add("statpoints", "<amount>", "Modifies character's stat points.", this.HandleStatPoints);
			this.Add("broadcast", "<message>", "Broadcasts text message to all players.", this.HandleBroadcast);
			this.Add("kick", "<team name>", "Kicks the player with the given team name if they're online.", this.HandleKick);

			// Dev
			this.Add("test", "", "", this.HandleTest);
			this.Add("reloadscripts", "", "Reloads all scripts.", this.HandleReloadScripts);
			this.Add("reloadconf", "", "Reloads configuration files.", this.HandleReloadConf);
			this.Add("reloaddata", "", "Reloads data.", this.HandleReloadData);
			this.Add("ai", "[ai name]", "Activates AI for character.", this.HandleAi);
			this.Add("updatedata", "", "Updates data.", this.HandleUpdateData);
			this.Add("updatedatacom", "", "Updates data.", this.HandleUpdateDataCom);
			this.Add("feature", "<feature name> <enabled>", "Toggles a feature.", this.HandleFeature);

			// Aliases
			this.AddAlias("iteminfo", "ii");
			this.AddAlias("monsterinfo", "mi");
			this.AddAlias("reloadscripts", "rs");
		}

		/// <summary>
		/// Test command, modify to quickly test something, but never
		/// commit the changes to it.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleTest(Character sender, Character target, string message, string command, Arguments args)
		{
			Log.Debug("test!!");

			return CommandResult.Okay;
		}

		/// <summary>
		/// Tells the sender where the target currently is.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleWhere(Character sender, Character target, string message, string command, Arguments args)
		{
			if (sender == target)
				sender.ServerMessage(Localization.Get("You are here: {0} ({1}), {2} (Direction: {3:0.#####}°)"), target.Map.ClassName, target.Map.Id, target.Position, target.Direction.DegreeAngle);
			else
				sender.ServerMessage(Localization.Get("{3} is here: {0} ({1}), {2} (Direction: {3:0.#####}°)"), target.Map.ClassName, target.Map.Id, target.Position, target.TeamName, target.Direction.DegreeAngle);

			return CommandResult.Okay;
		}

		/// <summary>
		/// Displays the current server and game time.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="commandName"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleTime(Character sender, Character target, string message, string commandName, Arguments args)
		{
			var now = GameTime.Now;

			target.ServerMessage(Localization.Get("Server Time: {0:yyyy-MM-dd HH:mm}"), now.DateTime);
			target.ServerMessage(Localization.Get("Game Time: {0:y-M-dd HH:mm}"), now);

			return CommandResult.Okay;
		}

		/// <summary>
		/// Displays a list of usable commands or details about one command.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="commandName"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleHelp(Character sender, Character target, string message, string commandName, Arguments args)
		{
			var targetAuthLevel = target.Connection.Account.Authority;

			// Display info about one command
			if (args.Count != 0)
			{
				var helpCommandName = args.Get(0);
				var command = this.GetCommand(helpCommandName);
				var levels = ZoneServer.Instance.Conf.Commands.GetLevelsOrDefault(command.Name);

				if (levels.Self > targetAuthLevel)
				{
					sender.ServerMessage(Localization.Get("Command not found or not available."));
					return CommandResult.Okay;
				}

				var aliases = _commands.Where(a => a.Value == command && a.Key != helpCommandName).Select(a => a.Key);

				sender.ServerMessage(Localization.Get("Name: {0}"), command.Name);
				if (aliases.Any())
					sender.ServerMessage(Localization.Get("Aliases: {0}"), string.Join(", ", aliases));
				sender.ServerMessage(Localization.Get("Description: {0}"), command.Description);
				sender.ServerMessage(Localization.Get("Arguments: {0}"), command.Usage);
			}
			// Display list of available commands
			else
			{
				var commandNames = new List<string>();

				foreach (var command in _commands.Values)
				{
					var levels = ZoneServer.Instance.Conf.Commands.GetLevelsOrDefault(command.Name);
					if (levels.Self > targetAuthLevel)
						continue;

					commandNames.Add(command.Name);
				}

				if (commandNames.Count == 0)
				{
					sender.ServerMessage(Localization.Get("No commands found."));
					return CommandResult.Okay;
				}

				var sb = new StringBuilder();

				sender.ServerMessage(Localization.Get("Available commands:"));
				foreach (var name in commandNames)
				{
					// Group command names in strings up to 100 characters,
					// as that's the maximum amount some clients will display
					// as one message.
					if (sb.Length + 2 + name.Length >= 100)
					{
						sender.ServerMessage(sb.ToString());
						sb.Clear();
					}

					if (sb.Length != 0)
						sb.Append(", ");

					sb.Append(name);
				}

				if (sb.Length != 0)
					sender.ServerMessage(sb.ToString());
			}

			return CommandResult.Okay;
		}

		/// <summary>
		/// Warps target to given position on their current map.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleJump(Character sender, Character target, string message, string command, Arguments args)
		{
			Position newPos;

			if (args.Count == 0)
			{
				if (!sender.Map.Ground.TryGetRandomPosition(out var rndPos))
				{
					sender.ServerMessage(Localization.Get("Jump to random position failed."));
					return CommandResult.Fail;
				}

				newPos = rndPos;
			}
			else if (args.Count < 3)
			{
				return CommandResult.InvalidArgument;
			}
			else
			{
				if (!float.TryParse(args.Get(0), NumberStyles.Float, CultureInfo.InvariantCulture, out var x) || !float.TryParse(args.Get(1), NumberStyles.Float, CultureInfo.InvariantCulture, out var y) || !float.TryParse(args.Get(2), NumberStyles.Float, CultureInfo.InvariantCulture, out var z))
					return CommandResult.InvalidArgument;

				newPos = new Position(x, y, z);
			}

			target.Position = newPos;
			Send.ZC_SET_POS(target);

			if (sender == target)
			{
				sender.ServerMessage(Localization.Get("You were warped to {0}."), target.Position);
			}
			else
			{
				target.ServerMessage(Localization.Get("You were warped to {0} by {1}."), target.Position, sender.TeamName);
				sender.ServerMessage(Localization.Get("Target was warped."));
			}

			return CommandResult.Okay;
		}

		/// <summary>
		/// Warps target to given location.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleWarp(Character sender, Character target, string message, string command, Arguments args)
		{
			if (args.Count == 0)
				return CommandResult.InvalidArgument;

			// Get map id
			if (!int.TryParse(args.Get(0), out var mapId))
			{
				var data = ZoneServer.Instance.Data.MapDb.Find(args.Get(0));
				if (data == null)
				{
					sender.ServerMessage(Localization.Get("Map not found."));
					return CommandResult.Okay;
				}

				mapId = data.Id;
			}

			// Get map
			if (!ZoneServer.Instance.World.TryGetMap(mapId, out var map))
			{
				sender.ServerMessage(Localization.Get("Map not found."));
				return CommandResult.Okay;
			}

			// Get target position
			Position targetPos;
			if (args.Count < 4)
			{
				if (!map.Ground.TryGetRandomPosition(out targetPos))
				{
					sender.ServerMessage(Localization.Get("Random position warp failed."));
					return CommandResult.Okay;
				}
			}
			else
			{
				if (!float.TryParse(args.Get(1), NumberStyles.Float, CultureInfo.InvariantCulture, out var x))
					return CommandResult.InvalidArgument;

				if (!float.TryParse(args.Get(2), NumberStyles.Float, CultureInfo.InvariantCulture, out var y))
					return CommandResult.InvalidArgument;

				if (!float.TryParse(args.Get(3), NumberStyles.Float, CultureInfo.InvariantCulture, out var z))
					return CommandResult.InvalidArgument;

				targetPos = new Position(x, y, z);
			}

			// Warp
			try
			{
				target.Warp(mapId, targetPos);

				if (sender == target)
				{
					sender.ServerMessage(Localization.Get("You were warped to {0}."), target.GetLocation());
				}
				else
				{
					target.ServerMessage(Localization.Get("You were warped to {0} by {1}."), target.GetLocation(), sender.TeamName);
					sender.ServerMessage(Localization.Get("Target was warped."));
				}
			}
			catch (ArgumentException)
			{
				sender.ServerMessage("Map not found.");
			}

			return CommandResult.Okay;
		}

		/// <summary>
		/// Spawns item in target's inventory.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleItem(Character sender, Character target, string message, string command, Arguments args)
		{
			if (args.IndexedCount == 0)
				return CommandResult.InvalidArgument;

			if (!int.TryParse(args.Get(0), out var itemId))
			{
				var itemName = args.Get(0);

				var classNameMatches = ZoneServer.Instance.Data.ItemDb.FindAll(a => a.ClassName.ToLower().Contains(itemName.ToLower()));
				if (classNameMatches.Length == 0)
				{
					sender.ServerMessage(Localization.Get("Item '{0}' not found."), itemName);
					return CommandResult.Okay;
				}

				var rankedMatches = classNameMatches.OrderBy(a => a.ClassName.GetLevenshteinDistance(itemName, false));
				itemId = rankedMatches.First().Id;
			}
			else if (!ZoneServer.Instance.Data.ItemDb.Contains(itemId))
			{
				sender.ServerMessage(Localization.Get("Item not found."));
				return CommandResult.Okay;
			}

			// Get amount
			var amount = 1;
			if (args.IndexedCount >= 2)
			{
				if (!int.TryParse(args.Get(1), out amount) || amount < 1)
					return CommandResult.InvalidArgument;
			}

			// Create and add item
			var item = new Item(itemId, amount);
			target.Inventory.Add(item, InventoryAddType.PickUp);

			sender.ServerMessage(Localization.Get("Item created."));
			if (sender != target)
				target.ServerMessage(Localization.Get("An item was added to your inventory by {0}."), sender.TeamName);

			return CommandResult.Okay;
		}

		/// <summary>
		/// Adds or removes silver from target's inventory.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleSilver(Character sender, Character target, string message, string command, Arguments args)
		{
			if (args.Count == 0)
				return CommandResult.InvalidArgument;

			if (!int.TryParse(args.Get(0), out var modifier) || modifier == 0)
				return CommandResult.InvalidArgument;

			// Create and add silver item
			if (modifier > 0)
			{
				var item = new Item(ItemId.Silver, modifier);
				target.Inventory.Add(item, InventoryAddType.PickUp);

				if (sender == target)
				{
					sender.ServerMessage(Localization.Get("{0:n0} silver were added to your inventory."), modifier);
				}
				else
				{
					sender.ServerMessage(Localization.Get("{0:n0} silver were added to target's inventory."), modifier);
					target.ServerMessage(Localization.Get("{0} added {1:n0} silver to your inventory."), sender.TeamName, modifier);
				}
			}
			// Remove silver items
			else
			{
				modifier = -modifier;

				target.Inventory.Remove(ItemId.Silver, modifier, InventoryItemRemoveMsg.Destroyed);

				if (sender == target)
				{
					sender.ServerMessage(Localization.Get("{0:n0} silver were removed from your inventory."), modifier);
				}
				else
				{
					sender.ServerMessage(Localization.Get("{0:n0} silver were removed from target's inventory."), modifier);
					target.ServerMessage(Localization.Get("{0} removed {1:n0} silver from your inventory."), sender.TeamName, modifier);
				}
			}

			return CommandResult.Okay;
		}

		/// <summary>
		/// Spawns monsters at target's location.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleSpawn(Character sender, Character target, string message, string command, Arguments args)
		{
			if (args.IndexedCount == 0)
				return CommandResult.InvalidArgument;

			MonsterData monsterData;
			if (int.TryParse(args.Get(0), out var id))
			{
				monsterData = ZoneServer.Instance.Data.MonsterDb.Find(id);
				if (monsterData == null)
				{
					sender.ServerMessage(Localization.Get("Monster not found by id."));
					return CommandResult.Okay;
				}
			}
			else
			{
				var searchName = args.Get(0).ToLower();

				var monstersData = ZoneServer.Instance.Data.MonsterDb.Entries.Values.Where(a => a.ClassName.ToLower().Contains(searchName)).ToList();
				if (monstersData.Count == 0)
				{
					sender.ServerMessage(Localization.Get("Monster not found by name."));
					return CommandResult.Okay;
				}

				// Sort candidates by how close their name is to the search
				// name, to find the one that's closest to it.
				var sorted = monstersData.OrderBy(a => a.ClassName.ToLower().GetLevenshteinDistance(searchName));
				monsterData = sorted.First();
			}

			var amount = 1;
			if (args.IndexedCount >= 2 && !int.TryParse(args.Get(1), out amount))
				return CommandResult.InvalidArgument;

			amount = Math2.Clamp(1, 100, amount);

			var aiName = "BasicMonster";
			if (args.TryGet("ai", out var aiNameArg))
			{
				if (aiNameArg.ToLower() == "none")
					aiName = null;
				else
					aiName = aiNameArg;
			}

			var tendency = TendencyType.Peaceful;
			if (args.TryGet("tendency", out var tendencyArg))
			{
				if (tendencyArg.ToLower() == "aggressive")
					tendency = TendencyType.Aggressive;
			}

			var rnd = new Random(Environment.TickCount);
			for (var i = 0; i < amount; ++i)
			{
				var monster = new Mob(monsterData.Id, MonsterType.Mob);

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
				monster.Tendency = tendency;
				monster.Components.Add(new MovementComponent(monster));

				if (args.TryGet("hp", out var hpStr))
				{
					if (!int.TryParse(hpStr, out var hp))
					{
						sender.ServerMessage(Localization.Get("Invalid HP amount."));
						return CommandResult.Okay;
					}

					monster.Properties.Overrides.SetFloat(PropertyName.MHP, hp);
					monster.Properties.Invalidate(PropertyName.MHP);
					monster.Properties.SetFloat(PropertyName.HP, hp);
				}

				if (!string.IsNullOrWhiteSpace(aiName))
					monster.Components.Add(new AiComponent(monster, aiName));

				target.Map.AddMonster(monster);
			}

			sender.ServerMessage(Localization.Get("Monsters were spawned."));
			if (sender != target)
				target.ServerMessage(Localization.Get("Monsters were spawned at your location by {0}."), sender.TeamName);

			return CommandResult.Okay;
		}

		/// <summary>
		/// Adds all available hats to target's inventory.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleGetAllHats(Character sender, Character target, string message, string command, Arguments args)
		{
			var addedCount = 0;
			for (var itemId = 628001; itemId <= 629503; ++itemId)
			{
				if (!ZoneServer.Instance.Data.ItemDb.Contains(itemId))
					continue;

				if (!sender.Inventory.HasItem(itemId))
				{
					sender.Inventory.Add(new Item(itemId), InventoryAddType.PickUp);
					addedCount++;
				}
			}

			if (sender == target)
			{
				sender.ServerMessage(Localization.Get("Added {0} hats to your inventory."), addedCount);
			}
			else
			{
				target.ServerMessage(Localization.Get("{1} added {0} hats to your inventory."), addedCount, sender.TeamName);
				sender.ServerMessage(Localization.Get("Added {0} hats to target's inventory."), addedCount);
			}

			return CommandResult.Okay;
		}

		/// <summary>
		/// Changes target's name (not team name).
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleName(Character sender, Character target, string message, string command, Arguments args)
		{
			if (args.Count == 0)
				return CommandResult.InvalidArgument;

			var newName = args.Get(0);
			if (newName == sender.Name)
				return CommandResult.Okay;

			// TODO: Can you rename any time, without cooldown?

			// TODO: Keep a list of all account characters after all?
			if (ZoneServer.Instance.Database.CharacterExists(target.Connection.Account.Id, newName))
			{
				sender.ServerMessage(Localization.Get("Name already exists."));
				return CommandResult.Okay;
			}

			target.Name = newName;
			Send.ZC_PC(target, PcUpdateType.Name, 0, 0, newName);

			sender.ServerMessage(Localization.Get("Name changed."), target.Position);
			if (sender != target)
				target.ServerMessage(Localization.Get("Your name was changed by {0}."), sender.TeamName);

			return CommandResult.Okay;
		}

		/// <summary>
		/// Reloads all scripts.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleReloadScripts(Character sender, Character target, string message, string command, Arguments args)
		{
			sender.ServerMessage(Localization.Get("Reloading scripts..."));

			ZoneServer.Instance.World.RemoveScriptedEntities();
			ZoneServer.Instance.ReloadScripts();

			sender.ServerMessage(Localization.Get("Done."));

			return CommandResult.Okay;
		}

		/// <summary>
		/// Reloads all conf files.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleReloadConf(Character sender, Character target, string message, string command, Arguments args)
		{
			sender.ServerMessage(Localization.Get("Reloading configuration..."));

			ZoneServer.Instance.Conf.Load();

			sender.ServerMessage(Localization.Get("Done."));

			return CommandResult.Okay;
		}

		/// <summary>
		/// Reloads all data files.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleReloadData(Character sender, Character target, string message, string command, Arguments args)
		{
			sender.ServerMessage(Localization.Get("Reloading data..."));

			ZoneServer.Instance.LoadData(ServerType.Zone);

			sender.ServerMessage(Localization.Get("Done."));

			return CommandResult.Okay;
		}

		/// <summary>
		/// Levels up target.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleLevelUp(Character sender, Character target, string message, string command, Arguments args)
		{
			var levels = 1;
			if (args.Count >= 1 && (!int.TryParse(args.Get(0), out levels) || levels < 1))
				return CommandResult.InvalidArgument;

			// Set exp to 0, ZC_MAX_EXP_CHANGED apparently doesn't update the
			// exp bar if the exp didn't change.
			target.Exp = 0;
			target.TotalExp = ZoneServer.Instance.Data.ExpDb.GetTotalExp(target.Level + levels);
			target.LevelUp(levels);

			if (sender == target)
			{
				sender.ServerMessage(Localization.Get("Your level was changed."));
			}
			else
			{
				target.ServerMessage(Localization.Get("Your level was changed by {0}."), sender.TeamName);
				sender.ServerMessage(Localization.Get("The target's level was changed."));
			}

			return CommandResult.Okay;
		}

		/// <summary>
		/// Changes target's speed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleSpeed(Character sender, Character target, string message, string command, Arguments args)
		{
			if (args.Count == 0)
				return CommandResult.InvalidArgument;

			if (!float.TryParse(args.Get(0), out var speed))
				return CommandResult.InvalidArgument;

			var currentSpeed = target.Properties.GetFloat(PropertyName.MSPD);
			var bonusSpeed = speed - currentSpeed;

			target.Properties.Modify("MSPD_Bonus", bonusSpeed);
			Send.ZC_MOVE_SPEED(target);

			if (sender == target)
			{
				sender.ServerMessage(Localization.Get("Your speed was changed."));
			}
			else
			{
				target.ServerMessage(Localization.Get("Your speed was changed by {0}."), sender.TeamName);
				sender.ServerMessage(Localization.Get("Target's speed was changed."));
			}

			return CommandResult.Okay;
		}

		/// <summary>
		/// Searches item database for given string.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleItemInfo(Character sender, Character target, string message, string command, Arguments args)
		{
			if (args.Count == 0)
				return CommandResult.InvalidArgument;

			var search = string.Join(" ", args.GetAll());
			var items = ZoneServer.Instance.Data.ItemDb.FindAll(search);

			if (items.Count == 0)
			{
				sender.ServerMessage(Localization.Get("No items found for '{0}'."), search);
				return CommandResult.Okay;
			}

			var maxItemCount = 20;

			sender.ServerMessage(Localization.Get("Results: {0} (Max. {1} shown)"), items.Count, maxItemCount);

			var matchingItems = items.OrderBy(a => a.Name.GetLevenshteinDistance(search)).ThenBy(a => a.Id);
			foreach (var item in matchingItems.Take(maxItemCount))
				sender.ServerMessage(Localization.Get("{0}: {1}, Category: {2}"), item.Id, item.Name, item.Category);

			return CommandResult.Okay;
		}

		/// <summary>
		/// Searches monster database for given string.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleMonsterInfo(Character sender, Character target, string message, string command, Arguments args)
		{
			var monsterRaces = new[] { "Unknown", "Insect", "Mutant", "Plant", "Demon", "Beast", "Item" };
			var monsterElements = new[] { "None", "Fire", "Ice", "Poison", "Earth", "Melee", "Psychokinesis", "Lightning", "Holy", "Dark" };
			var monsterArmors = new[] { "None", "Cloth", "Leather", "Iron", "Chain", "Ghost", "Shield", "Aries" };
			var monsterSizes = new[] { "None", "Hidden", "S", "M", "L", "XL", "XXL" };

			if (args.Count == 0)
				return CommandResult.InvalidArgument;

			var search = string.Join(" ", args.GetAll());

			var monsters = ZoneServer.Instance.Data.MonsterDb.FindAllPreferExact(search);
			if (monsters.Count == 0)
			{
				sender.ServerMessage(Localization.Get("No monsters found for '{0}'."), search);
				return CommandResult.Okay;
			}

			var maxMonsterCount = 20;

			sender.ServerMessage(Localization.Get("Results: {0} (Max. {1} shown)"), monsters.Count, maxMonsterCount);

			var monsterEntries = monsters.OrderBy(a => a.Name.GetLevenshteinDistance(search)).ThenBy(a => a.Id);
			foreach (var monsterData in monsterEntries.Take(maxMonsterCount))
			{
				var monsterEntry = new StringBuilder();

				monsterEntry.AppendFormat(Localization.Get("{{nl}}----- {0} ({1}, {2}) -----{{nl}}"), monsterData.Name, monsterData.Id, monsterData.ClassName);
				monsterEntry.AppendFormat(Localization.Get("{0} / {1} / {2} / {3}{{nl}}"), monsterRaces[(int)monsterData.Race], monsterElements[(int)monsterData.Attribute], monsterArmors[(int)monsterData.ArmorMaterial], monsterSizes[(int)monsterData.Size]);
				monsterEntry.AppendFormat(Localization.Get("HP: {0}  SP: {1}  EXP: {2}  CEXP: {3}{{nl}}"), monsterData.Hp, monsterData.Sp, (int)(monsterData.Exp * ZoneServer.Instance.Conf.World.ExpRate / 100f), (int)(monsterData.ClassExp * ZoneServer.Instance.Conf.World.ClassExpRate / 100f));
				monsterEntry.AppendFormat(Localization.Get("Atk: {0}~{1}  MAtk: {2}~{3}  Def: {4}  MDef: {5}{{nl}}"), monsterData.PhysicalAttackMin, monsterData.PhysicalAttackMax, monsterData.MagicalAttackMin, monsterData.MagicalAttackMax, monsterData.PhysicalDefense, monsterData.MagicalDefense);

				if (monsterData.Drops.Count != 0)
				{
					monsterEntry.Append(Localization.Get("Drops:"));

					foreach (var currentDrop in monsterData.Drops)
					{
						var itemData = ZoneServer.Instance.Data.ItemDb.Find(currentDrop.ItemId);
						if (itemData == null)
							continue;

						var dropChance = Math2.Clamp(0, 100, currentDrop.DropChance);
						var adjustedDropChance = Math2.Clamp(0, 100, Mob.GetAdjustedDropRate(currentDrop));
						var isMoney = (currentDrop.ItemId == ItemId.Silver || currentDrop.ItemId == ItemId.Gold);

						var minAmount = currentDrop.MinAmount;
						var maxAmount = currentDrop.MaxAmount;
						var hasAmount = (minAmount > 1 || maxAmount > 1);

						if (isMoney)
						{
							minAmount = Math.Max(1, (int)(minAmount * (ZoneServer.Instance.Conf.World.SilverDropAmount / 100f)));
							maxAmount = Math.Max(minAmount, (int)(maxAmount * (ZoneServer.Instance.Conf.World.SilverDropAmount / 100f)));
						}

						var displayAmount = isMoney || hasAmount;

						if (displayAmount)
						{
							if (minAmount == maxAmount)
								monsterEntry.AppendFormat(Localization.Get("{{nl}}- {0} {1} ({2:0.####}% -> {3:0.####}%)"), minAmount, itemData.Name, dropChance, adjustedDropChance);
							else
								monsterEntry.AppendFormat(Localization.Get("{{nl}}- {0}~{1} {2} ({3:0.####}% -> {4:0.####}%)"), minAmount, maxAmount, itemData.Name, dropChance, adjustedDropChance);
						}
						else
						{
							monsterEntry.AppendFormat(Localization.Get("{{nl}}- {0} ({1:0.####}% -> {2:0.####}%)"), itemData.Name, dropChance, adjustedDropChance);
						}
					}
				}
				else
				{
					monsterEntry.Append(Localization.Get("This monster has no drops."));
				}

				sender.ServerMessage(monsterEntry.ToString());
			}

			return CommandResult.Okay;
		}

		/// <summary>
		/// Searches monster database to find out who drops a given item
		/// and returns a list of the best sources of that item.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleWhoDrops(Character sender, Character target, string message, string command, Arguments args)
		{
			if (args.Count == 0)
				return CommandResult.InvalidArgument;

			var search = string.Join(" ", args.GetAll());

			var items = ZoneServer.Instance.Data.ItemDb.FindAllPreferExact(search);
			if (items.Count == 0)
			{
				sender.ServerMessage(Localization.Get("No items found for '{0}'."), search);
				return CommandResult.Okay;
			}

			var maxItemResultCount = 5;
			var maxDropperCount = 100;
			var maxDropResultCount = 10;

			sender.ServerMessage(Localization.Get("Results: {0} (Max. {1} shown)"), items.Count, maxItemResultCount);

			var itemEntries = items.OrderBy(a => a.Name.GetLevenshteinDistance(search)).ThenBy(a => a.Id);
			foreach (var currentItem in itemEntries.Take(maxItemResultCount))
			{
				var whoDropsEntry = new StringBuilder();

				whoDropsEntry.AppendFormat(Localization.Get("{{nl}}----- {0} -----{{nl}}"), currentItem.Name);

				MonsterData[] droppers;

				if (currentItem.Id == ItemId.Silver || (droppers = ZoneServer.Instance.Data.MonsterDb.FindAll(a => a.Drops.Any(b => b.ItemId == currentItem.Id))).Length > maxDropperCount)
				{
					whoDropsEntry.Append(Localization.Get("Too many enemies drop this."));
				}
				else if (droppers.Length == 0)
				{
					whoDropsEntry.Append(Localization.Get("This item is not dropped by any monsters"));
				}
				else
				{
					var bestDroppers = new List<KeyValuePair<MonsterData, float>>();

					foreach (var monsterData in droppers)
					{
						var dropDatas = monsterData.Drops.Where(a => a.ItemId == currentItem.Id);

						foreach (var dropData in dropDatas)
						{
							var dropChance = Math2.Clamp(0, 100, Mob.GetAdjustedDropRate(dropData));
							bestDroppers.Add(new KeyValuePair<MonsterData, float>(monsterData, dropChance));
						}
					}

					whoDropsEntry.AppendFormat(Localization.Get("Listing up to {0} best sources of this item:"), maxDropResultCount);

					var dropEntries = bestDroppers.OrderByDescending(a => a.Value).ThenBy(a => a.Key.Level);
					foreach (var dropDataKV in dropEntries.Take(maxDropResultCount))
					{
						var dropData = dropDataKV.Key;
						var dropChance = dropDataKV.Value;

						whoDropsEntry.AppendFormat(Localization.Get("{{nl}}{0} ({1}, {2}) - {3:0.####}%"), dropData.Name, dropData.Id, dropData.ClassName, dropChance);
					}
				}

				sender.ServerMessage(whoDropsEntry.ToString());
			}

			return CommandResult.Okay;
		}

		/// <summary>
		/// Warps target to a pre-defined location.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleGo(Character sender, Character target, string message, string command, Arguments args)
		{
			if (args.Count == 0)
			{
				sender.ServerMessage(Localization.Get("Destinations: {0}"), "klaipeda, orsha, start");
				return CommandResult.InvalidArgument;
			}

			if (args.Get(0).StartsWith("klaip")) target.Warp("c_Klaipe", new Position(-75, 148, -24));
			else if (args.Get(0).StartsWith("ors")) target.Warp("c_orsha", new Position(271, 176, 292));
			else if (args.Get(0).StartsWith("start")) target.Warp("f_siauliai_west", new Position(-628, 260, -1025));
			else
			{
				sender.ServerMessage(Localization.Get("Unknown destination."));
				return CommandResult.Okay;
			}

			if (sender == target)
			{
				sender.ServerMessage(Localization.Get("You were warped to {0}."), target.GetLocation());
			}
			else
			{
				target.ServerMessage(Localization.Get("You were warped to {0} by {1}."), target.GetLocation(), sender.TeamName);
				sender.ServerMessage(Localization.Get("Target was warped."));
			}

			return CommandResult.Okay;
		}

		/// <summary>
		/// Warps target to a specific character's location.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleGoTo(Character sender, Character target, string message, string command, Arguments args)
		{
			if (args.Count == 0)
				return CommandResult.InvalidArgument;

			// TODO: Once we have support for more than one map server,
			//   we have to search for characters across all of them.

			var teamName = args.Get(0);
			var character = ZoneServer.Instance.World.GetCharacterByTeamName(teamName);
			if (character == null)
			{
				sender.ServerMessage(Localization.Get("Character not found."));
				return CommandResult.Okay;
			}

			target.Warp(character.GetLocation());

			if (sender == target)
			{
				sender.ServerMessage(Localization.Get("You've been warped to {0}'s location."), teamName);
			}
			else
			{
				sender.ServerMessage(Localization.Get("Target was warped."));
				target.ServerMessage(Localization.Get("You've been warped to {0}'s location by {1}."), teamName, sender.TeamName);
			}

			return CommandResult.Okay;
		}

		/// <summary>
		/// Warps specific character to target.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleRecall(Character sender, Character target, string message, string command, Arguments args)
		{
			if (args.Count == 0)
				return CommandResult.InvalidArgument;

			// TODO: Once we have support for more than one map server,
			//   we have to search for characters across all of them.

			var teamName = args.Get(0);
			var character = ZoneServer.Instance.World.GetCharacterByTeamName(teamName);
			if (character == null)
			{
				sender.ServerMessage(Localization.Get("Character not found."));
				return CommandResult.Okay;
			}

			character.Warp(target.GetLocation());

			character.ServerMessage(Localization.Get("You've been warped to {0}'s location."), target.TeamName);
			sender.ServerMessage(Localization.Get("Character was warped."));
			if (sender != target)
				target.ServerMessage(Localization.Get("{0} was warped to your location by {1}."), character.TeamName, sender.TeamName);

			return CommandResult.Okay;
		}

		/// <summary>
		/// Warps all players on the map to target's location.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleRecallMap(Character sender, Character target, string message, string command, Arguments args)
		{
			if (args.Count > 2)
				return CommandResult.InvalidArgument;

			var map = target.Map;

			// TODO: Once we have support for channels and map servers,
			//   add warp from other servers and restrict recall to
			//   channel's max player count.
			if (args.Count >= 1)
			{
				// Search for map by name and id
				if (int.TryParse(args.Get(0), out var mapId))
					map = ZoneServer.Instance.World.GetMap(mapId);
				else
					map = ZoneServer.Instance.World.GetMap(args.Get(0));

				// Check map
				if (map == null)
				{
					sender.ServerMessage(Localization.Get("Unknown map."));
					return CommandResult.Okay;
				}
			}

			var characters = map.GetCharacters(a => a != target);

			// Check for characters
			if (!characters.Any())
			{
				sender.ServerMessage(Localization.Get("No players found."));
				return CommandResult.Okay;
			}

			RecallCharacters(sender, target, characters);

			return CommandResult.Okay;
		}

		/// <summary>
		/// Warps all players on the server to target's location.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleRecallAll(Character sender, Character target, string message, string command, Arguments args)
		{
			// TODO: Once we have support for channels and map servers,
			//   add warp from other servers and restrict recall to
			//   channel's max player count.

			// Check for characters
			var characters = ZoneServer.Instance.World.GetCharacters(a => a != target);
			if (!characters.Any())
			{
				sender.ServerMessage(Localization.Get("No players found."));
				return CommandResult.Okay;
			}

			RecallCharacters(sender, target, characters);

			return CommandResult.Okay;
		}

		/// <summary>
		/// Recalls characters to target's location and sends appropriate
		/// server messages.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="characters"></param>
		private static void RecallCharacters(Character sender, Character target, Character[] characters)
		{
			var location = target.GetLocation();
			foreach (var character in characters)
			{
				character.Warp(location);
				character.ServerMessage(Localization.Get("You've been warped to {0}'s location."), target.TeamName);
			}

			if (sender == target)
			{
				sender.ServerMessage(Localization.Get("You have called {0} characters to your location."), characters.Length);
			}
			else
			{
				sender.ServerMessage(Localization.Get("You have called {0} characters to target's location."), characters.Length);
				target.ServerMessage(Localization.Get("{1} called {0} characters to your location."), characters.Length, sender.TeamName);
			}
		}

		/// <summary>
		/// Heals the target hp and optionally sp.
		/// If no argument is given, heals fully.
		/// Can also heal negative values.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleHeal(Character sender, Character target, string message, string command, Arguments args)
		{
			if (args.Count > 3)
				return CommandResult.InvalidArgument;

			// TODO: Maybe refactor to take indexed arguments, named
			//   ones, or combinations, so you can, for example, heal
			//   stamina without specifying HP and SP like so:
			//   >heal sp:10

			// Fully heal HP and SP if no arguments are given
			if (args.Count == 0)
			{
				target.ModifyHp(target.MaxHp);
				target.ModifySp(target.MaxSp);

				sender.ServerMessage(Localization.Get("Healed HP and SP."));
				if (sender != target)
					target.ServerMessage(Localization.Get("Your HP and SP were healed by {0}."), sender.TeamName);
			}
			// Modify only HP if one argument is given
			else if (args.Count == 1)
			{
				if (!int.TryParse(args.Get(0), out var hpAmount))
					return CommandResult.InvalidArgument;

				target.ModifyHp(hpAmount);

				sender.ServerMessage(Localization.Get("Healed HP by {0} points."), hpAmount);
				if (sender != target)
					target.ServerMessage(Localization.Get("{0} healed your HP by {1} points."), sender.TeamName, hpAmount);
			}
			// Modify HP and SP if two arguments are given
			else if (args.Count == 2)
			{
				if (!int.TryParse(args.Get(0), out var hpAmount))
					return CommandResult.InvalidArgument;

				if (!int.TryParse(args.Get(1), out var spAmount))
					return CommandResult.InvalidArgument;

				target.ModifyHp(hpAmount);
				target.ModifySp(spAmount);

				sender.ServerMessage(Localization.Get("Healed HP by {0} and SP by {1} points."), hpAmount, spAmount);
				if (sender != target)
					target.ServerMessage(Localization.Get("{0} healed your HP by {1} and your SP by {2} points."), sender.TeamName, hpAmount, spAmount);
			}
			// Modify HP, SP, and Stamina if three arguments are given
			else if (args.Count >= 3)
			{
				if (!int.TryParse(args.Get(0), out var hpAmount))
					return CommandResult.InvalidArgument;

				if (!int.TryParse(args.Get(1), out var spAmount))
					return CommandResult.InvalidArgument;

				if (!int.TryParse(args.Get(2), out var staminaAmount))
					return CommandResult.InvalidArgument;

				// Adjust Stamina to match the game's display value, since
				// most users of this command wouldn't be aware of this
				// property's value being 1000 times larger than displayed.
				staminaAmount *= 1000;

				target.ModifyHp(hpAmount);
				target.ModifySp(spAmount);
				target.ModifyStamina(staminaAmount);

				sender.ServerMessage(Localization.Get("Healed HP by {0}, SP by {1}, and Stamina by {2} points."), hpAmount, spAmount, staminaAmount);
				if (sender != target)
					target.ServerMessage(Localization.Get("{0} healed your HP by {1}, SP by {2}, and Stamina by {3} points."), sender.TeamName, hpAmount, spAmount, staminaAmount);
			}

			return CommandResult.Okay;
		}

		/// <summary>
		/// Removes all items from target's inventory.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleClearInventory(Character sender, Character target, string message, string command, Arguments args)
		{
			target.Inventory.Clear();

			sender.ServerMessage(Localization.Get("Inventory cleared."));
			if (sender != target)
				target.ServerMessage(Localization.Get("Your inventory was cleared by {0}."), sender.TeamName);

			return CommandResult.Okay;
		}

		/// <summary>
		/// Adds job to target.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleAddJob(Character sender, Character target, string message, string command, Arguments args)
		{
			if (args.Count == 0)
				return CommandResult.InvalidArgument;

			if (!int.TryParse(args.Get(0), out var iJobId))
				return CommandResult.InvalidArgument;

			var jobId = (JobId)iJobId;
			if (!ZoneServer.Instance.Data.JobDb.Contains(jobId))
			{
				sender.ServerMessage(Localization.Get("Job data for '{0}' not found."), jobId);
				return CommandResult.Okay;
			}

			var circle = JobCircle.First;

			if (args.Count >= 2)
			{
				if (!int.TryParse(args.Get(1), out var iCircle) || iCircle < (int)JobCircle.First || !Enum.IsDefined(typeof(JobCircle), iCircle))
					return CommandResult.InvalidArgument;

				circle = (JobCircle)iCircle;
			}

			var job = target.Jobs.Get(jobId);
			if (job != null && job.Circle >= circle)
			{
				sender.ServerMessage(Localization.Get("The job exists already, at an equal or higher circle."));
				return CommandResult.Okay;
			}

			if (job == null)
			{
				Send.ZC_PC(target, PcUpdateType.Job, (int)jobId, (int)circle);
				target.JobId = jobId;
				target.Jobs.Add(new Job(target, jobId, circle));
			}
			else
				target.Jobs.ChangeCircle(jobId, circle);

			sender.ServerMessage(Localization.Get("Job '{0}' was added at circle '{1}'."), jobId, (int)circle);
			if (sender != target)
				target.ServerMessage(Localization.Get("Job '{0}' was added to your character at circle '{1}' by {2}."), jobId, (int)circle, sender.TeamName);

			return CommandResult.Okay;
		}

		/// <summary>
		/// Removes a given job from target.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleRemoveJob(Character sender, Character target, string message, string command, Arguments args)
		{
			if (args.Count == 0)
				return CommandResult.InvalidArgument;

			if (!int.TryParse(args.Get(0), out var iJobId))
				return CommandResult.InvalidArgument;

			var jobId = (JobId)iJobId;

			if (!target.Jobs.Remove(jobId))
			{
				sender.ServerMessage(Localization.Get("The job doesn't exist."));
				return CommandResult.Okay;
			}

			if (sender == target)
			{
				sender.ServerMessage(Localization.Get("Job '{0}' was removed. Login again to see the change."), jobId);
			}
			else
			{
				target.ServerMessage(Localization.Get("Job '{0}' was removed by {1}. Login again to see the change."), jobId, sender.TeamName);
				sender.ServerMessage(Localization.Get("Job '{0}' was removed from target."), jobId);
			}

			return CommandResult.Okay;
		}

		/// <summary>
		/// Modifies target's skill points for the given job.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleSkillPoints(Character sender, Character target, string message, string command, Arguments args)
		{
			if (args.Count < 2)
				return CommandResult.InvalidArgument;

			if (!int.TryParse(args.Get(0), out var iJobId))
				return CommandResult.InvalidArgument;

			if (!int.TryParse(args.Get(1), out var modifier))
				return CommandResult.InvalidArgument;

			var jobId = (JobId)iJobId;

			if (!target.Jobs.ModifySkillPoints(jobId, modifier))
			{
				sender.ServerMessage(Localization.Get("The job doesn't exist."));
				return CommandResult.Okay;
			}

			if (sender == target)
			{
				sender.ServerMessage(Localization.Get("Modified {0}'s skill points by {1:+0;-0;0}."), jobId, modifier);
			}
			else
			{
				sender.ServerMessage(Localization.Get("Modified target {0}'s skill points by {1:+0;-0;0}."), jobId, modifier);
				target.ServerMessage(Localization.Get("Your {0}'s skill points were modified by {1}."), jobId, sender.TeamName);
			}

			return CommandResult.Okay;
		}

		/// <summary>
		/// Adds stat points to target character.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleStatPoints(Character sender, Character target, string message, string command, Arguments args)
		{
			if (args.Count == 0)
				return CommandResult.InvalidArgument;

			if (!int.TryParse(args.Get(0), out var amount) || amount < 1)
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

			sender.ServerMessage(Localization.Get("Added {0} stat points."), amount);
			if (sender != target)
				sender.ServerMessage(Localization.Get("{1} added {0} stat points to your character."), amount, sender.TeamName);

			return CommandResult.Okay;
		}

		/// <summary>
		/// Toggles autoloot.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleAutoloot(Character sender, Character target, string message, string command, Arguments args)
		{
			var autoloot = sender.Variables.Temp.Get("Autoloot", 0);

			// If we got an argument, use it as the max drop chance of
			// items that are to be autolooted. Without an argument,
			// toggle autolooting completely on or off.
			if (args.Count >= 1)
			{
				if (!int.TryParse(args.Get(0), out autoloot))
					return CommandResult.InvalidArgument;

				autoloot = Math2.Clamp(0, 100, autoloot);
			}
			else if (autoloot == 0)
			{
				autoloot = 100;
			}
			else
			{
				autoloot = 0;
			}

			sender.Variables.Temp.Set("Autoloot", autoloot);

			if (autoloot == 100)
				target.ServerMessage(Localization.Get("Autoloot is now active."));
			else if (autoloot == 0)
				target.ServerMessage(Localization.Get("Autoloot is now inactive."));
			else
				target.ServerMessage(Localization.Get("Autoloot is now active for items up to a drop chance of {0}%."), autoloot);

			return CommandResult.Okay;
		}

		/// <summary>
		/// Toggles AI for target.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleAi(Character sender, Character target, string message, string command, Arguments args)
		{
			if (target.Components.Has<AiComponent>())
			{
				Send.ZC_NORMAL.Cutscene(target, false, false, false);

				target.Components.Remove<MovementComponent>();
				target.Components.Remove<AiComponent>();

				if (args.Count == 0)
				{
					sender.ServerMessage(Localization.Get("Disabled AI."));
					return CommandResult.Okay;
				}
			}
			else if (args.Count == 0)
			{
				sender.ServerMessage(Localization.Get("No AI active."));
				return CommandResult.Okay;
			}

			if (args.Count >= 1)
			{
				var aiName = args.Get(0);

				// Characters need to be in "cutscene mode" for the server
				// to move them, otherwise they'll just ignore the move
				// packets.
				Send.ZC_NORMAL.Cutscene(target, true, false, false);

				target.Components.Add(new MovementComponent(target));
				target.Components.Add(new AiComponent(target, aiName));

				sender.ServerMessage(Localization.Get("Enabled '{0}' AI."), aiName);
			}

			return CommandResult.Okay;
		}

		/// <summary>
		/// Initiates data update.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="commandName"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleUpdateData(Character sender, Character target, string message, string commandName, Arguments args)
		{
			// Instructs the client to iterate over all its items (including
			// auto-generated ones), retrieve their monster ids, and send
			// them back to the server using >updatedatacom.
			// The max length of chat messages appears to be ~4090 characters,
			// so we need to split the data into multiple messages.

			var prefix = ZoneServer.Instance.Conf.Commands.SelfPrefix[0];

			Send.ZC_EXEC_CLIENT_SCP(sender.Connection, @"
				local result = ''
				
				ui.Chat('" + prefix + @"updatedatacom init')

				local itemClassList, cnt  = GetClassList('Item');
				for i = 0, cnt - 1 do
					local itemClass = GetClassByIndexFromList(itemClassList, i)
					local itemMonsterId = geItemTable.GetItemMonster(itemClass.ClassID)
					local itemClassName = itemClass.ClassName
					
					result = result .. itemClass.ClassID .. '\t' .. itemMonsterId .. '\t' .. itemClass.ClassName .. '\n'

					if string.len(result) > 2000 then
						ui.Chat('" + prefix + @"updatedatacom add ' .. result)
						result = ''
					end
				end

				ui.Chat('" + prefix + @"updatedatacom fin')
			");

			return CommandResult.Okay;
		}

		/// <summary>
		/// Accepts data updates and writes them to file.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="commandName"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleUpdateDataCom(Character sender, Character target, string message, string commandName, Arguments args)
		{
			if (args.Count == 0)
				return CommandResult.InvalidArgument;

			var tmpFilePath = "user/tmp/updatedata/itemmonsters.txt";
			var outFilePath = "system/db/itemmonsters.txt";

			var tmpDirPath = Path.GetDirectoryName(tmpFilePath);
			if (!Directory.Exists(tmpDirPath))
				Directory.CreateDirectory(tmpDirPath);

			var outDirPath = Path.GetDirectoryName(outFilePath);
			if (!Directory.Exists(outDirPath))
				Directory.CreateDirectory(outDirPath);

			switch (args.Get(0))
			{
				// Clear file
				case "init":
				{
					File.WriteAllText(tmpFilePath, "");
					break;
				}
				// Add text to file
				case "add":
				{
					File.AppendAllText(tmpFilePath, message.Substring(message.IndexOf(" add") + " add".Length).Trim() + "\n");
					break;
				}
				// Generate final data
				case "fin":
				{
					var lines = File.ReadAllLines(tmpFilePath);

					var idTable = new Dictionary<int, int>();
					foreach (var line in lines)
					{
						var split = line.Split('\t');
						var itemId = int.Parse(split[0]);
						var itemMonsterId = int.Parse(split[1]);

						idTable[itemId] = itemMonsterId;
					}

					var sb = new StringBuilder();

					sb.AppendLine("// Melia");
					sb.AppendLine("// Database file");
					sb.AppendLine("//---------------------------------------------------------------------------");
					sb.AppendLine();
					sb.AppendLine("[");

					foreach (var entry in idTable.OrderBy(a => a.Key))
					{
						var itemId = entry.Key;
						var itemMonsterId = entry.Value;
						var className = "";
						var name = "";

						if (ZoneServer.Instance.Data.ItemDb.TryFind(itemId, out var data))
						{
							className = data.ClassName;
							name = data.Name;
						}

						sb.AppendFormat("{{ itemId: {0}, monsterId: {1}, className: \"{2}\", name: \"{3}\" }},", itemId, itemMonsterId, className, name);
						sb.AppendLine();
					}

					sb.AppendLine("]");

					File.WriteAllText(outFilePath, sb.ToString());
					break;
				}
			}

			return CommandResult.Okay;
		}

		/// <summary>
		/// Enables or disables features.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="commandName"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleFeature(Character sender, Character target, string message, string commandName, Arguments args)
		{
			if (args.Count != 2)
				return CommandResult.InvalidArgument;

			var featureName = args.Get(0);
			var enabled = args.Get(1) == "true";

			if (!ZoneServer.Instance.Data.FeatureDb.TryFind(featureName, out var feature))
			{
				sender.ServerMessage(Localization.Get("Feature '{0}' not found."), featureName);
				return CommandResult.Okay;
			}

			feature.Enable(enabled);

			if (enabled)
				sender.ServerMessage(Localization.Get("Enabled feature '{0}'."), featureName);
			else
				sender.ServerMessage(Localization.Get("Disabled feature '{0}'."), featureName);

			return CommandResult.Okay;
		}

		/// <summary>
		/// Broadcasts a message to all players.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="commandName"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleBroadcast(Character sender, Character target, string message, string commandName, Arguments args)
		{
			if (args.Count == 0)
				return CommandResult.InvalidArgument;

			var joinedArgs = string.Join(" ", args.GetAll());
			var text = string.Format("{0} : {1}", target.TeamName, string.Join(" ", args.GetAll()));

			var commMessage = new NoticeTextMessage(NoticeTextType.GoldRed, text);
			ZoneServer.Instance.Communicator.Send("Coordinator", commMessage.BroadcastTo("AllZones"));

			return CommandResult.Okay;
		}

		/// <summary>
		/// Kicks a player if they're online.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		/// <param name="message"></param>
		/// <param name="commandName"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleKick(Character sender, Character target, string message, string commandName, Arguments args)
		{
			if (args.Count == 0)
				return CommandResult.InvalidArgument;

			// Use the sender name as the origin so you can't fake someone
			// else kicking players.

			var targetName = args.Get(0);
			var originName = sender.TeamName;

			if (ZoneServer.Instance.Data.MapDb.TryFind(targetName, out _))
			{
				var commMessage = new KickMessage(KickTargetType.Map, targetName, originName);
				ZoneServer.Instance.Communicator.Send("Coordinator", commMessage.BroadcastTo("AllZones"));

				sender.ServerMessage(Localization.Get("Request for kicking players on map '{0}' sent."), targetName);
			}
			else
			{
				var commMessage = new KickMessage(KickTargetType.Player, targetName, originName);
				ZoneServer.Instance.Communicator.Send("Coordinator", commMessage.BroadcastTo("AllZones"));

				sender.ServerMessage(Localization.Get("Request for kicking player '{0}' sent."), targetName);
			}

			return CommandResult.Okay;
		}

		/// <summary>
		/// Official slash command, purpose unknown.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleReqUpdateEquip(Character sender, Character target, string message, string command, Arguments args)
		{
			// Command is sent when the inventory is opened, purpose unknown,
			// officials don't seem to send anything back.

			// Comment in the client's Lua files:
			//   내구도 회복 유료템 때문에 정확한 값을 지금 알아야 함.
			//   (Durability recovery Due to the paid system, you need to know the correct value now.)

			return CommandResult.Okay;
		}

		/// <summary>
		/// Official slash command, exchanges silver for ability points.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleBuyAbilPoint(Character sender, Character target, string message, string command, Arguments args)
		{
			if (args.Count < 0)
			{
				Log.Warning("HandleBuyAbilPoint: No amount given by user '{0}'.", sender.Connection.Account.Name);
				return CommandResult.Okay;
			}

			if (!int.TryParse(args.Get(0), out var amount))
			{
				Log.Warning("HandleBuyAbilPoint: Invalid amount '{0}' by user '{1}'.", amount, sender.Connection.Account.Name);
				return CommandResult.Okay;
			}

			var costPerPoint = ZoneServer.Instance.Conf.World.AbilityPointCost;
			var totalCost = (amount * costPerPoint);
			var silver = sender.Inventory.CountItem(ItemId.Silver);
			if (silver < totalCost)
			{
				Log.Warning("HandleBuyAbilPoint: User '{0}' didn't have enough money.", sender.Connection.Account.Name);
				return CommandResult.Okay;
			}

			sender.Inventory.Remove(ItemId.Silver, totalCost, InventoryItemRemoveMsg.Given);
			sender.ModifyAbilityPoints(amount);

			Send.ZC_ADDON_MSG(sender, AddonMessage.SUCCESS_BUY_ABILITY_POINT, 0, "BLANK");

			return CommandResult.Okay;
		}

		/// <summary>
		/// Opens buy-in shop creation window or creates shop based on
		/// arguments.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleBuyShop(Character sender, Character target, string message, string command, Arguments args)
		{
			if (args.Count == 0)
			{
				Send.ZC_EXEC_CLIENT_SCP(sender.Connection, "OPEN_PERSONAL_SHOP_REGISTER()");
				return CommandResult.Okay;
			}

			if (args.Count < 2)
			{
				Log.Debug("HandleBuyShop: Not enough arguments.");
				return CommandResult.Okay;
			}

			// Read arguments
			var title = args.Get(0);
			var items = new List<Tuple<int, int, int>>();

			for (var i = 2; i < args.Count; ++i)
			{
				var split = args.Get(i).Split(',');

				if (split.Length != 3 || !int.TryParse(split[0], out var id) || !int.TryParse(split[1], out var amount) || !int.TryParse(split[2], out var price))
				{
					Log.Debug("HandleBuyShop: Invalid argument '{0}'.", args.Get(i));
					return CommandResult.Okay;
				}

				items.Add(new Tuple<int, int, int>(id, amount, price));
			}

			// Create auto seller packet from arguments and have the
			// channel handle it as if the client had sent it.
			var packet = new Packet(Op.CZ_REGISTER_AUTOSELLER);
			packet.PutString(title, 64);
			packet.PutInt(items.Count);
			packet.PutInt(270065); // PersonalShop
			packet.PutInt(0);

			foreach (var item in items)
			{
				packet.PutInt(item.Item1);
				packet.PutInt(item.Item2);
				packet.PutInt(item.Item3);
				packet.PutEmptyBin(264);
			}

			ZoneServer.Instance.PacketHandler.Handle(sender.Connection, packet);

			return CommandResult.Okay;
		}

		/// <summary>
		/// Updates the character's mouse position variables.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleUpdateMouse(Character sender, Character target, string message, string command, Arguments args)
		{
			sender.Variables.Temp.SetFloat("MouseX", float.Parse(args.Get(0), CultureInfo.InvariantCulture));
			sender.Variables.Temp.SetFloat("MouseY", float.Parse(args.Get(1), CultureInfo.InvariantCulture));
			sender.Variables.Temp.SetFloat("ScreenWidth", float.Parse(args.Get(2), CultureInfo.InvariantCulture));
			sender.Variables.Temp.SetFloat("ScreenHeight", float.Parse(args.Get(3), CultureInfo.InvariantCulture));

			return CommandResult.Okay;
		}
	}
}
