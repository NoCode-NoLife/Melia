//--- Melia Script ----------------------------------------------------------
// Item Transaction Scripts
//--- Description -----------------------------------------------------------
// Handles "Item TX" requests from the client.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Items;

public class ItemTxFunctionsScript : GeneralScript
{
	[ScriptableFunction]
	public ItemTxResult TX_SCR_USE_SKILL_RESET_JOB(Character character, Item item, int[] numArgs)
	{
		var jobId = (JobId)numArgs[0];

		if (!character.Jobs.TryGet(jobId, out var job))
			return ItemTxResult.Fail;

		// The popup says an item is required past level 550, but I
		// haven't seen the client send an item object id yet.
		//if (!character.Inventory.TryFindItem("Premium_SkillReset", out item))
		//{
		//	character.MsgBox(Localization.Get("You need a Skill Reset Potion."));
		//	return ItemTxResult.Okay;
		//}

		character.ResetSkills(jobId);

		return ItemTxResult.Okay;
	}

	[ScriptableFunction]
	public ItemTxResult TX_SCR_USE_SKILL_STAT_RESET(Character character, Item item, int[] numArgs)
	{
		character.ResetSkills();
		character.Inventory.Remove(item, 1, InventoryItemRemoveMsg.Destroyed);

		return ItemTxResult.Okay;
	}
}
