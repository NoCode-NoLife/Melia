//--- Melia Script ----------------------------------------------------------
// Custom Command Scripts
//--- Description -----------------------------------------------------------
// Handles "Custom Command" requests from the client.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Yggdrasil.Logging;

public class CustomCommandFunctionsScript : GeneralScript
{
	[ScriptableFunction]
	public CustomCommandResult SCR_LAST_INFOSET_OPEN(Character character, int numArg1, int numArg2, int numArg3)
	{
		// Example: SCR_LAST_INFOSET_OPEN(2, 0, 0)

		// Sent from "chase info", notifying us about the last
		// selected index, with 1 being "achieve" and 2 "quest".
		// Potentially related to adventure book? In any case,
		// we're going to ignore this for now, to get rid of
		// unhandled message upon login.

		return CustomCommandResult.Okay;
	}

	[ScriptableFunction]
	public CustomCommandResult SCR_GUILD_PROMOTE_NOTICE_COUNT(Character character, int numArg1, int numArg2, int numArg3)
	{
		// Example: SCR_GUILD_PROMOTE_NOTICE_COUNT(0, 0, 0)

		// Sent from "system menu" if player is not in a guild.
		// I can only assume that responding to it would make
		// some kind of "OMG! JOIN A GUILD!" message appear,
		// so we're going to promptly ignore this.

		return CustomCommandResult.Okay;
	}

	[ScriptableFunction]
	public CustomCommandResult SCR_HAT_VISIBLE_STATE(Character character, int numArg1, int numArg2, int numArg3)
	{
		var headgearIndex = numArg1;

		switch (headgearIndex)
		{
			case 0: character.VisibleEquip ^= VisibleEquip.Headgear1; break;
			case 1: character.VisibleEquip ^= VisibleEquip.Headgear2; break;
			case 2: character.VisibleEquip ^= VisibleEquip.Headgear3; break;
		}

		Send.ZC_UPDATED_PCAPPEARANCE(character);
		Send.ZC_NORMAL.HeadgearVisibilityUpdate(character);

		return CustomCommandResult.Okay;
	}

	[ScriptableFunction]
	public CustomCommandResult SCR_HAIR_WIG_VISIBLE_STATE(Character character, int numArg1, int numArg2, int numArg3)
	{
		character.VisibleEquip ^= VisibleEquip.Wig;

		Send.ZC_UPDATED_PCAPPEARANCE(character);
		Send.ZC_NORMAL.WigVisibilityUpdate(character);

		return CustomCommandResult.Okay;
	}

	[ScriptableFunction]
	public CustomCommandResult SCR_SUBWEAPON_VISIBLE_STATE(Character character, int numArg1, int numArg2, int numArg3)
	{
		character.VisibleEquip ^= VisibleEquip.SubWeapon;

		Send.ZC_UPDATED_PCAPPEARANCE(character);
		Send.ZC_NORMAL.SubWeaponVisibilityUpdate(character);

		return CustomCommandResult.Okay;
	}

	[ScriptableFunction]
	public CustomCommandResult SCR_CLICK_CHANGEJOB_BUTTON(Character character, int numArg1, int numArg2, int numArg3)
	{
		var jobId = (JobId)numArg1;
		var username = character.Connection.Account.Name;

		if (!ZoneServer.Instance.Data.JobDb.TryFind(jobId, out var jobData))
		{
			Log.Warning("CZ_CUSTOM_COMMAND: User '{0}' requested job change to missing job '{1}'.", username, jobId);
			return CustomCommandResult.Fail;
		}

		if (character.Job.Level < character.Job.MaxLevel)
		{
			Log.Warning("CZ_CUSTOM_COMMAND: User '{0}' requested job change before reaching their current job's max level of {1}.", username, character.Job.MaxLevel);
			return CustomCommandResult.Fail;
		}

		if (character.JobClass != jobData.JobClassId)
		{
			Log.Warning("CZ_CUSTOM_COMMAND: User '{0}' requested job change to job '{1}', a '{2}' job, while being a '{3}'.", username, jobId, jobData.JobClassId, character.JobClass);
			return CustomCommandResult.Fail;
		}

		if (character.Jobs.Has(jobId))
		{
			Log.Warning("CZ_CUSTOM_COMMAND: User '{0}' requested job change to job '{1}' despite already having it.", username, jobId);
			return CustomCommandResult.Fail;
		}

		if (character.Jobs.GetCurrentRank() >= 4)
		{
			Log.Warning("CZ_CUSTOM_COMMAND: User '{0}' requested job change at or above the max rank of 4.", username, jobId);
			return CustomCommandResult.Fail;
		}

		var newJob = new Job(character, jobId, skillPoints: 1);

		Send.ZC_PC(character, PcUpdateType.Job, (int)newJob.Id, newJob.Level);
		Send.ZC_NORMAL.PlayEffect(character, "F_pc_class_change");

		character.JobId = jobId;
		character.Jobs.Add(newJob);

		// Should the event happen regardless of how the job
		// change happened? Should this code be cleaned up to
		// use one simple function to accomplish all this? TBD.
		ZoneServer.Instance.ServerEvents.OnPlayerAdvancedJob(character);

		return CustomCommandResult.Okay;
	}

	// The JANSORI_COUNT custom command was once used to disable a certain
	// tooltip. When the player clicked on it, this command was sent and
	// and set a session object to remember not to show the tooltip again.
	// This command was removed at some point though. We'll leave this here
	// for reference for the time being.
	//[ScriptableFunction]
	//public CustomCommandResult JANSORI_COUNT(Character character, int numArg1, int numArg2, int numArg3)
	//{
	//	var classId = numArg1;
	//	var cmdArg = numArg2;

	//	// Disable "You can buy items" tooltip, sent after
	//	// opening a shop.
	//	if (classId == 5 && cmdArg == 1)
	//	{
	//		// The property is on the session object "Jansori".
	//		var jansori = character.SessionObjects.Get(SessionObjectId.Jansori);
	//		jansori.Properties.SetFloat(PropertyName.Shop_Able_Clicked, 1);

	//		Send.ZC_OBJECT_PROPERTY(character.Connection, jansori, PropertyName.Shop_Able_Clicked);
	//	}

	//	return CustomCommandResult.Okay;
	//}
}
