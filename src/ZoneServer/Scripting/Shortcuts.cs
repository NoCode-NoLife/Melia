using System;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Configuration.Files;
using Melia.Shared.Game.Const;
using Melia.Shared.Scripting;
using Melia.Zone.Commands;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;
using Yggdrasil.Util;

namespace Melia.Zone.Scripting
{
	public static partial class Shortcuts
	{
		/// <summary>
		/// Returns a reference to the global variables container.
		/// </summary>
		public static VariablesContainer GlobalVariables => ZoneServer.Instance.World.GlobalVariables.Variables;

		/// <summary>
		/// Returns a random number between 0 and max - 1.
		/// </summary>
		/// <param name="max"></param>
		/// <returns></returns>
		public static int Random(int max)
		{
			return RandomProvider.Next(max);
		}

		/// <summary>
		/// Returns a random number between min and max - 1.
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static int Random(int min, int max)
		{
			return RandomProvider.Next(min, max);
		}

		/// <summary>
		/// Plays chest opening animations and makes the chest disappear.
		/// Returns after the animation played and the chest's contents
		/// can be distributed.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="npc"></param>
		/// <returns></returns>
		public static async Task OpenChest(Character character, Npc npc)
		{
			//if (character.Help.NotSeen(34))
			//	Send.ZC_HELP_ADD(character, 34, 1);

			// Play animations for character to kick open the chest
			Send.ZC_PLAY_ANI(character, AnimationName.KickBox);
			Send.ZC_PLAY_ANI(npc, AnimationName.Opened, true);

			// Wait a second, so the animations can play
			await Task.Delay(1000);

			// Make chest disappear
			Send.ZC_NORMAL.FadeOut(npc, TimeSpan.FromSeconds(4));
			npc.SetState(NpcState.Invisible);

			// Make chest reappear after a certain amount of time
			// TODO: Add timer component, to set up and associate timers
			//   and intervals with entities.
			_ = Task.Delay(TimeSpan.FromMinutes(1)).ContinueWith(_ => npc.SetState(NpcState.Normal));
		}

		/// <summary>
		/// Adds or overrides a command, making it available to players
		/// who have the given authority levels.
		/// </summary>
		/// <param name="command"></param>
		/// <param name="usage"></param>
		/// <param name="description"></param>
		/// <param name="auth"></param>
		/// <param name="targetAuth"></param>
		/// <param name="func"></param>
		public static void AddChatCommand(string command, string usage, string description, int auth, int targetAuth, ChatCommandFunc func)
		{
			ZoneServer.Instance.ChatCommands.Add(command, usage, description, func);
			ZoneServer.Instance.Conf.Commands.CommandLevels[command] = new CommandAuthLevels(auth, targetAuth);
		}

		/// <summary>
		/// Formats the given message name and arguments in a way that the
		/// client can recognize as a client message with arguments.
		/// </summary>
		/// <param name="messageName">Name of the client message.</param>
		/// <param name="args">Optional list of arguments as key/value pairs.</param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		/// <example>
		/// ScpArgMsg("KlaipedaCentralPlaza")
		/// ScpArgMsg("InputPriceBetween{MIN}{MAX}", "MIN", 1, "MAX", 10)
		/// </example>
		public static string ScpArgMsg(string messageName, params object[] args)
		{
			if (args != null && args.Length % 2 != 0)
				throw new ArgumentException("Expected an even amount of arguments for the key/value arguments.");

			var result = new StringBuilder();

			result.Append("!@#$" + messageName);

			if (args != null)
			{
				for (var i = 0; i < args.Length; i += 2)
				{
					var key = args[i];
					var value = args[i + 1];

					result.Append("$*$" + key);
					result.Append("$*$" + value);
				}
			}

			result.Append("#@!");

			return result.ToString();
		}

		/// <summary>
		/// Returns a time span of the given amount of hours.
		/// </summary>
		/// <param name="hours"></param>
		/// <returns></returns>
		public static TimeSpan Hours(double hours)
			=> TimeSpan.FromHours(hours);

		/// <summary>
		/// Returns a time span of the given amount of minutes.
		/// </summary>
		/// <param name="minutes"></param>
		/// <returns></returns>
		public static TimeSpan Minutes(double minutes)
			=> TimeSpan.FromMinutes(minutes);

		/// <summary>
		/// Returns a time span of the given amount of seconds.
		/// </summary>
		/// <param name="seconds"></param>
		/// <returns></returns>
		public static TimeSpan Seconds(double seconds)
			=> TimeSpan.FromSeconds(seconds);

		/// <summary>
		/// Returns a time span of the given amount of milliseconds.
		/// </summary>
		/// <param name="milliseconds"></param>
		/// <returns></returns>
		public static TimeSpan Milliseconds(double milliseconds)
			=> TimeSpan.FromMilliseconds(milliseconds);
	}
}
