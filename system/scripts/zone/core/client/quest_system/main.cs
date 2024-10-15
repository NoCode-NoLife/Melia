//--- Melia Script ----------------------------------------------------------
// Quest System
//--- Description -----------------------------------------------------------
// Adds client-side support for our custom quest system.
//---------------------------------------------------------------------------

using System.Globalization;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Logging;
using Yggdrasil.Util.Commands;
using static Melia.Zone.Scripting.Shortcuts;

public class CustomQuestSystemClientScript : ClientScript
{
	protected override void Load()
	{
		this.LoadAllScripts();

		AddChatCommand("quest", "<complete|cancel>", "", 0, 99, HandleQuest);
	}

	protected override void Ready(Character character)
	{
		this.SendAllScripts(character);
		character.Quests.UpdateClient();
	}

	private CommandResult HandleQuest(Character sender, Character target, string message, string commandName, Arguments args)
	{
		if (args.Count < 2)
		{
			Log.Debug("CustomQuestSystemClientScript: Not enough arguments for quest command in message '{0}'.", message);
			return CommandResult.Okay;
		}

		var hexObjectId = args.Get(1).Replace("0x", "");

		if (!long.TryParse(hexObjectId, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var questObjectId))
		{
			Log.Debug("CustomQuestSystemClientScript: Failed to parse quest object id '{0}' in message '{1}'.", args.Get(1), message);
			return CommandResult.Okay;
		}

		if (!sender.Quests.TryGet(questObjectId, out var quest))
		{
			Log.Debug("CustomQuestSystemClientScript: User '{0}' tried to interact with a quest they don't have.", sender.Username);
			return CommandResult.Okay;
		}

		var action = args.Get(0).ToLowerInvariant();

		switch (action)
		{
			case "complete":
			{
				if (!quest.ObjectivesCompleted)
				{
					Log.Debug("CustomQuestSystemClientScript: User '{0}' tried to complete a quest they didn't complete yet.", sender.Username);
					return CommandResult.Okay;
				}

				sender.Quests.Complete(quest);
				break;
			}
			case "cancel":
			{
				if (!quest.Data.Cancelable)
				{
					Log.Debug("CustomQuestSystemClientScript: User '{0}' tried to cancel a quest that can't be canceled.", sender.Username);
					return CommandResult.Okay;
				}

				sender.Quests.Cancel(quest);
				break;
			}
			case "track":
			{
				if (args.Count < 3)
				{
					Log.Debug("CustomQuestSystemClientScript: Not enough arguments for 'track' action in message '{0}'.", message);
					return CommandResult.Okay;
				}

				var enabled = args.Get(2) == "true";

				quest.Tracked = enabled;
				break;
			}
			default:
			{
				Log.Debug("CustomQuestSystemClientScript: Unknown action '{0}' in message '{1}'.", action, message);
				break;
			}
		}

		return CommandResult.Okay;
	}
}
