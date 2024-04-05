//--- Melia Script ----------------------------------------------------------
// Kepa Kill Quests
//--- Description -----------------------------------------------------------
// Automatically received test quests for killing Kepas.
//---------------------------------------------------------------------------

using System.Threading.Tasks;
using Melia.Zone.Scripting;
using Melia.Zone.Scripting.Dialogues;
using Melia.Zone.World.Quests;
using Melia.Zone.World.Quests.Objectives;
using Melia.Zone.World.Quests.Prerequisites;
using Melia.Zone.World.Quests.Rewards;

public class KillOnions1TestQuestScript : QuestScript
{
	protected override void Load()
	{
		SetId(1000001);
		SetName("Onions Must Die");
		SetDescription("Slice, dice, and make these onion-shaped bastards cry for a change!");

		for (var i = 1; i <= 2; ++i)
		{
			var amount = i * 5;
			AddObjective("kill" + i, "Kill " + amount + " Kepas", new KillObjective(amount, MonsterId.Onion));
		}

		SetReceive(QuestReceiveType.Auto);
		AddPrerequisite(new LevelPrerequisite(2));

		AddReward(new ItemReward(ItemId.Card_Onion_The_Great));
		AddReward(new ItemReward(ItemId.OnionPiece_Red, 20));
		AddReward(new SilverReward(1000));
		AddReward(new ExpReward(1000, 500));
	}
}

public class KillOnions2TestQuestScript : QuestScript
{
	protected override void Load()
	{
		SetId(1000002);
		SetName("Size Doesn't Matter");
		SetDescription("And now for the big one. Put that giant onion back into the ground from whence it came.");

		AddObjective("kill", "Kill a Large Kepa", new KillObjective(1, MonsterId.Onion_Big));
		AddObjective("talk", "Talk to Ronesa", new ManualObjective());

		SetReceive(QuestReceiveType.Auto);
		AddPrerequisite(new CompletedPrerequisite(1000001));

		AddReward(new SilverReward(10000));
		AddReward(new ExpReward(2000, 1000));

		AddDialogHook("Ronesa", "BeforeDialog", RonesaDialog);
	}

	private async Task<HookResult> RonesaDialog(Dialog dialog)
	{
		var character = dialog.Player;

		if (!character.Quests.IsActive(this.QuestId, "talk"))
			return HookResult.Skip;

		await dialog.Msg("Welcome, how can I help you today?");
		await dialog.Msg("Oh, you received my quest? Thank you very much for helping out with these pests.{nl}It was about time someone did something about them. Here's your reward.");

		character.Quests.Complete(this.QuestId);

		return HookResult.Break;
	}
}
