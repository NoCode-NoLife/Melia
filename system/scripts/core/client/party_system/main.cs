//--- Melia Script ----------------------------------------------------------
// Party System
//--- Description -----------------------------------------------------------
// Adds client-side support for our custom party system.
//---------------------------------------------------------------------------

using System;
using Melia.Shared.Scripting;
using Melia.Zone.Events;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Logging;
using Yggdrasil.Util;
using Yggdrasil.Util.Commands;
using static Melia.Zone.Scripting.Shortcuts;

public class PartySystemClientScript : ClientScript
{
	public override void Load()
	{
		LoadAllScripts();

		AddChatCommand("partymake", "<party_name>", "creates a party", 0, 99, HandleCreateParty);
	}

	[On("PlayerReady")]
	protected void OnPlayerReady(object sender, PlayerEventArgs e)
	{
		SendAllScripts(e.Character);
		e.Character.Quests.UpdateClient();
	}

	private CommandResult HandleCreateParty(Character sender, Character target, string message, string commandName, Arguments args)
	{
		var partyName = args.Get(0);

		Log.Debug("PartySystemClientScript: Requested to create the party '{0}' in message '{1}'.", partyName, message);

		var rnd = RandomProvider.Get();
		var randomNumber = rnd.Next(10000, 99999);
		partyName = partyName + randomNumber.ToString();

		if (!sender.Parties.PartyNameExists(partyName))
		{
			sender.Parties.CreateParty(partyName);
		}

		return CommandResult.Okay;
	}
}
