//--- Melia Script ----------------------------------------------------------
// Normal Transaction Scripts
//--- Description -----------------------------------------------------------
// Handles "Normal TX" requests from the client.
//---------------------------------------------------------------------------

using System.Linq;
using Melia.Shared.Tos.Const;
using Melia.Zone;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Logging;

public class NormalTxFunctionsScript : GeneralScript
{
	[ScriptableFunction("SCR_TX_PROPERTY_ACTIVE_TOGGLE")]
	public NormalTxResult SCR_TX_PROPERTY_ACTIVE_TOGGLE(Character character, string strArg)
	{
		var className = strArg;

		if (!character.Abilities.Toggle(className))
			Log.Warning("SCR_TX_PROPERTY_ACTIVE_TOGGLE: User '{0}' tried to toggle ability '{1}', which they either don't have or is passive.", character.Connection.Account.Name, className);

		return NormalTxResult.Okay;
	}

	[ScriptableFunction("GUIDE_QUEST_OPEN_UI")]
	public NormalTxResult GUIDE_QUEST_OPEN_UI(Character character, string strArg)
	{
		switch (strArg)
		{
			case "status":
			{
				// Sent when opening the character info. Presumably a
				// request to open the help panel or show a tooltip or
				// something.
				return NormalTxResult.Okay;
			}
			case "inventory":
			{
				// Sent when opening the inventory. Presumably a request
				// to open the help panel or show a tooltip or something.
				return NormalTxResult.Okay;
			}
		}

		return NormalTxResult.Fail;
	}

	[ScriptableFunction("SCR_TX_STAT_UP")]
	public NormalTxResult SCR_TX_STAT_UP(Character character, int[] numArgs)
	{
		// Check amount of parameters
		if (numArgs.Length != 5)
		{
			Log.Warning("SCR_TX_STAT_UP: User '{0}' sent an unexpected number of stat changes. Got {1}, expected 5.", character.Username, numArgs.Length);
			return NormalTxResult.Fail;
		}

		for (var i = 0; i < numArgs.Length; ++i)
		{
			var addPoints = numArgs[i];
			if (addPoints <= 0)
				continue;

			if (character.Properties.GetFloat(PropertyName.StatPoint) < addPoints)
			{
				Log.Warning("SCR_TX_STAT_UP: User '{0}' tried to spent more stat points than they have.", character.Username);
				break;
			}

			//characterProperties.UsedStat += stat;
			character.Properties.Modify("UsedStat", addPoints);

			switch (i)
			{
				case 0: character.Properties.Modify("STR_STAT", addPoints); break;
				case 1: character.Properties.Modify("CON_STAT", addPoints); break;
				case 2: character.Properties.Modify("INT_STAT", addPoints); break;
				case 3: character.Properties.Modify("MNA_STAT", addPoints); break;
				case 4: character.Properties.Modify("DEX_STAT", addPoints); break;
			}
		}

		Send.ZC_ADDON_MSG(character, AddonMessage.RESET_STAT_UP, 0, null);

		// Official doesn't update UsedStat with this packet,
		// but presumably the PROP_UPDATE below. Why send more
		// packets than necessary though?
		Send.ZC_OBJECT_PROPERTY(character,
			"STR", "STR_STAT", "CON", "CON_STAT", "INT",
			"INT_STAT", "MNA", "MNA_STAT", "DEX", "DEX_STAT",
			"UsedStat", "MINPATK", "MAXPATK", "MINMATK",
			"MAXMATK", "MINPATK_SUB", "MAXPATK_SUB", "CRTATK",
			"HR", "DR", "BLK_BREAK", "RHP", "RSP",
			"MHP", "MSP"
		);

		//Send.ZC_PC_PROP_UPDATE(character, ObjectProperty.PC.STR_STAT, 0);
		//Send.ZC_PC_PROP_UPDATE(character, ObjectProperty.PC.UsedStat, 0);

		return NormalTxResult.Okay;
	}

	[ScriptableFunction("SCR_TX_SKILL_UP")]
	public NormalTxResult SCR_TX_SKILL_UP(Character character, int[] numArgs)
	{
		var jobId = (JobId)numArgs[0];
		var amounts = numArgs.Skip(1).ToArray();

		// Check job
		var job = character.Jobs.Get(jobId);
		if (job == null)
		{
			Log.Warning("SCR_TX_SKILL_UP: User '{0}' tried to learn skills of a job they don't have.", character.Username);
			return NormalTxResult.Fail;
		}

		// Check skill data
		// The clients sends the number of points to add to every
		// skill, incl. the skills the player shouldn't be able to
		// put points into yet, so we need to use the job's MaxLevel
		// for getting all available skills.
		var skillTreeData = ZoneServer.Instance.Data.SkillTreeDb.FindSkills(job.Id, job.MaxLevel);
		if (amounts.Length != skillTreeData.Length)
		{
			Log.Warning("SCR_TX_SKILL_UP: User '{0}' sent an unexpected number of skill level changes. Got {1}, expected {2}.", character.Username, amounts.Length, skillTreeData.Length);
			return NormalTxResult.Fail;
		}

		// Iterate over the amounts and try to apply them to the skills
		for (var i = 0; i < amounts.Length; ++i)
		{
			var addLevels = amounts[i];
			if (addLevels <= 0)
				continue;

			// Check skill points
			if (job.SkillPoints < addLevels)
			{
				Log.Warning("SCR_TX_SKILL_UP: User '{0}' tried to use more skill points than they have.", character.Username);
				break;
			}

			var data = skillTreeData[i];
			var skillId = data.SkillId;

			// Check max level
			var maxLevel = character.Skills.GetMaxLevel(skillId);
			var currentLevel = character.Skills.GetLevel(skillId);
			var newLevel = (currentLevel + addLevels);

			if (newLevel > maxLevel)
			{
				// Don't warn about this, since the client doesn't
				// check the max level for skills with unlock levels.
				// The player can try, but nothing should happen.
				//Log.Warning("SCR_TX_SKILL_UP: User '{0}' tried to level '{1}' past the max level ({2} > {3}).", character.Username, skillId, newLevel, maxLevel);
				continue;
			}

			// Create skill or update its level
			var skill = character.Skills.Get(skillId);
			if (skill == null)
			{
				skill = new Skill(character, skillId, newLevel);
				character.Skills.Add(skill);
			}
			else
			{
				skill.Level = newLevel;
				Send.ZC_OBJECT_PROPERTY(character.Connection, skill);
			}

			job.SkillPoints -= addLevels;

			ZoneServer.Instance.ServerEvents.OnPlayerSkillLevelChanged(character, skill);
		}

		Send.ZC_ADDON_MSG(character, AddonMessage.RESET_SKL_UP, 0, null);
		Send.ZC_JOB_PTS(character, job);
		//Send.ZC_ADDITIONAL_SKILL_POINT(character, job);

		return NormalTxResult.Okay;
	}
}
