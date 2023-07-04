//--- Melia Script ----------------------------------------------------------
// Party System
//--- Description -----------------------------------------------------------
// Adds client-side support for our custom party system.
//---------------------------------------------------------------------------

using System.Globalization;
using Melia.Shared.Scripting;
using Melia.Zone;
using Melia.Zone.Events;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Logging;
using Yggdrasil.Util.Commands;
using static Melia.Zone.Scripting.Shortcuts;

public class PartySystemClientScript : ClientScript
{
	public override void Load()
	{
		LoadAllScripts();

		AddChatCommand("partymake", "<party_name>", "creates a party", 0, 0, HandleCreateParty);
	}

	[On("PlayerReady")]
	protected void OnPlayerReady(object sender, PlayerEventArgs e)
	{
		SendAllScripts(e.Character);
		e.Character.Quests.UpdateClient();
	}

	private CommandResult HandleCreateParty(Character sender, Character target, string message, string commandName, Arguments args)
	{
		if (args.Count < 1)
		{
			return CommandResult.Okay;
		}

		var partyName = args.Get(0);

		// TODO: implement the rest
		//if (ZoneServer.Instance.Database.PartyNameExists(partyName))
		//{
		//	ZoneServer.Instance.Database.CreateParty(sender, partyName);
		//}

		Log.Debug("CustomQuestSystemClientScript: Unknown action '{0}' in message '{1}'.", partyName, message);
		return CommandResult.Okay;
	}
}
