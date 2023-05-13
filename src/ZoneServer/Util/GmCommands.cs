using System.Collections.Generic;
using Melia.Zone.Network;
using Melia.Zone.World;
using Melia.Zone.World.Entities;
using Melia.Shared.Util;
using Melia.Shared.Util.Commands;
using Melia.Shared.World;

namespace Melia.Zone.Util
{
	/// <summary>
	/// GM command manager.
	/// </summary>
	public partial class GmCommands : CommandManager<GmCommand, GmCommandFunc>
	{
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
		public bool Process(IZoneConnection conn, Character character, string message)
		{
			if (string.IsNullOrWhiteSpace(message))
				return false;

			message = message.Trim();

			var args = this.ParseLine(message);
			if (args.Length == 0 || (!args[0].StartsWith("/") && !args[0].StartsWith(ZoneServer.Instance.Conf.Commands.Prefix) && !args[0].StartsWith(ZoneServer.Instance.Conf.Commands.Prefix2)))
				return false;

			// Get command name
			var isCharCommand = args[0].StartsWith(ZoneServer.Instance.Conf.Commands.Prefix2);
			var commandName = args[0].TrimStart('/', ZoneServer.Instance.Conf.Commands.Prefix[0]);

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
				target = ZoneServer.Instance.World.GetCharacterByTeamName(targetName);
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
			var auth = ZoneServer.Instance.Conf.Commands.GetAuth(commandName);
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
				character.ServerMessage("Invalid argument, usage: {0}{1} {2}", ZoneServer.Instance.Conf.Commands.Prefix, commandName, command.Usage);
			}

			return true;
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
				character.ServerMessage("You've been warped to {0}'s location.", target.TeamName);
			}

			if (sender == target)
			{
				sender.ServerMessage("You have called {0} characters to your location.", characters.Length);
			}
			else
			{
				sender.ServerMessage("You have called {0} characters to target's location.", characters.Length);
				target.ServerMessage("{1} called {0} characters to your location.", characters.Length, sender.TeamName);
			}
		}
	}

	public class GmCommand : Command<GmCommandFunc>
	{
		public GmCommand(string name, string usage, string description, GmCommandFunc func)
			: base(name, usage, description, func)
		{
		}
	}

	public delegate CommandResult GmCommandFunc(IZoneConnection conn, Character sender, Character target, string command, string[] args);
}
