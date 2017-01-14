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
using Melia.Channel.World.SkillEffects;
using Melia.Channel.World.AI;

namespace Melia.Channel.World
{
	/// <summary>
	/// GM command manager.
	/// </summary>
	public class ChatManager : CommandManager<ChatCommand, ChatCommandFunc>
	{
		/// <summary>
		/// Creates new manager and initializes it.
		/// </summary>
		public ChatManager()
		{
			// Channels
			Add("", "", HandleNormalChannel);
			Add("p", "", HandlePartyChannel);
			Add("g", "", HandleGuildChannel);

			// Client commands

			// Party Commands
			Add("partymake", "", HandlePartyMake);
			Add("partyname", "", HandlePartyNameChange);
			Add("partyleader", "", HandlePartyTransferLeader);
			Add("partyout", "", HandlePartyOut);
			Add("partybann", "", HandlePartyBann);
			Add("partyDirectInvite", "", HandlePartyDirectInvite);

			// Test purposes
			Add("paccept", "", HandlePartyJoin);

		}

		/// <summary>
		/// Adds command.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="usage"></param>
		/// <param name="func"></param>
		public void Add(string name, string usage, ChatCommandFunc func)
		{
			this.Add(new ChatCommand(name, usage, "", func));
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

			Log.Debug("message {0}", message);

			var args = this.ParseLine(message);

			if (args.Length == 0)
				return false;

			// Get command name
			var commandName = "";
			if (args[0].StartsWith("/"))
				commandName = args[0].TrimStart('/');

			Log.Debug("commandName {0}", commandName);

			// Get command
			var command = this.GetCommand(commandName);
			if (command == null)
			{
				this.SystemMessage(character, "Command not found.");
				return true;
			}

			// Execute command
			var result = command.Func(conn, character, message, args);

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
			Send.ZC_CHAT(character.Connection, character, string.Format(format, args), 0);
		}

		//-------------------------------------------------------------------
		private CommandResult HandleNormalChannel(ChannelConnection conn, Character character, string command, string[] args)
		{
			var message = args[0];
			Log.Debug("Normal channel: {0}", message);

			/*
			Send.ZC_PARTY_INFO(character);
			Send.ZC_PARTY_LIST(character, 1);
			Send.ZC_NORMAL_PartyName_underCharacterName(character, "partyName", true);
			Send.ZC_NORMAL_Party2(character, true);
			Send.ZC_PARTY_ENTER(character);
			*/

			Send.ZC_CHAT(character, message, 0);

			return CommandResult.Okay;
		}
		private CommandResult HandlePartyChannel(ChannelConnection conn, Character character, string command, string[] args)
		{
			var message = args[1];

			Log.Debug("Party channel: {0}", message);

			return CommandResult.Okay;
		}

		private CommandResult HandleGuildChannel(ChannelConnection conn, Character character, string command, string[] args)
		{
			var message = args[1];
			Log.Debug("Guild channel: {0}", message);
			return CommandResult.Okay;
		}


		// Party Functions

		private CommandResult HandlePartyMake(ChannelConnection conn, Character character, string command, string[] args)
		{
			var partyName = args[1];
			Log.Debug("PartyName: {0}", partyName);

			if (character.Party != null)
			{
				SystemMessage(character, "You are already in party.");
				return CommandResult.Okay;
			}

			Group party = new Group(character, 0, partyName);

			return CommandResult.Okay;
		}

		private CommandResult HandlePartyJoin(ChannelConnection conn, Character character, string command, string[] args)
		{
			var targetTeamName = args[1];
			Log.Debug("Member (TeamName) joininig the group: {0}", targetTeamName);

			if (character.Party == null)
			{
				SystemMessage(character, "You are not in party");
				return CommandResult.Okay;
			}

			var target = ChannelServer.Instance.World.GetCharacterByTeamName(targetTeamName);

			if (target == null)
			{
				Log.Debug("Party target not exist {0}", targetTeamName);
				return CommandResult.Okay;
			}

			if (target.Party != null)
			{
				return CommandResult.Okay;
			}

			if (character.Party.IsFull())
			{
				SystemMessage(character, "The party is full.");
				return CommandResult.Okay;
			}

			character.Party.AddMember(target, false);

			return CommandResult.Okay;
		}

		private CommandResult HandlePartyNameChange(ChannelConnection conn, Character character, string command, string[] args)
		{
			var unk1 = args[1];
			var unk2 = args[2];
			var unk3 = args[3];
			var newPartyName = args[4];

			if (newPartyName != "" && character.Party != null && character.Party.IsLeader(character))
			{
				character.Party.ChangeName(newPartyName);
			}

			return CommandResult.Okay;
		}

		private CommandResult HandlePartyTransferLeader(ChannelConnection conn, Character character, string command, string[] args)
		{
			var targetTeamName = args[1];

			if (character.Party == null || !character.Party.IsLeader(character))
			{
				return CommandResult.Okay;
			}

			var target = ChannelServer.Instance.World.GetCharacterByTeamName(targetTeamName);

			if (target == null)
				return CommandResult.Okay;

			if (target.Party == null)
				return CommandResult.Okay;

			if (character.Party.Id != target.Party.Id)
				return CommandResult.Okay;

			// Make change
			character.Party.ChangeLeader(target);

			return CommandResult.Okay;
		}

		private CommandResult HandlePartyOut(ChannelConnection conn, Character character, string command, string[] args)
		{
			if (character.Party != null)
			{
				character.Party.RemoveMember(character);
			}

			return CommandResult.Okay;
		}

		private CommandResult HandlePartyBann(ChannelConnection conn, Character character, string command, string[] args)
		{
			var unk1 = args[1];
			var memberTeamName = args[2];
			if (character.Party != null && character.Party.IsLeader(character))
			{
				var target = ChannelServer.Instance.World.GetCharacterByTeamName(memberTeamName);

				character.Party.RemoveMember(target);
			}

			return CommandResult.Okay;
		}

		private CommandResult HandlePartyDirectInvite(ChannelConnection conn, Character character, string command, string[] args)
		{
			var charTeamName = args[1];
			if (character.Party != null && character.Party.IsLeader(character))
			{
				var target = ChannelServer.Instance.World.GetCharacterByTeamName(charTeamName);

				Send.ZC_NORMAL_PartyInvitation(target, character.Party);
			}

			return CommandResult.Okay;
		}

	}

	public class ChatCommand : Command<ChatCommandFunc>
	{
		public ChatCommand(string name, string usage, string description, ChatCommandFunc func)
			: base(name, usage, description, func)
		{
		}
	}

	public delegate CommandResult ChatCommandFunc(ChannelConnection conn, Character sender, string command, string[] args);
}
