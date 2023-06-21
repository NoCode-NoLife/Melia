//--- Melia Script ----------------------------------------------------------
// Ability Unlocked Check Functions
//--- Description -----------------------------------------------------------
// Scriptable functions that determine whether an ability is unlocked
// and can be learned.
//---------------------------------------------------------------------------

using Melia.Shared.Data.Database;
using Melia.Shared.Tos.Const;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;

public class AbilityUnlockedFunctionsScript : GeneralScript
{
	/// <summary>
	/// Unlock at given circle.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="jobClassName"></param>
	/// <param name="minCircle"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_ABIL_CIRCLE(Character character, string jobClassName, int minCircle, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(jobClassName);

		return ((int)circle >= minCircle);
	}

	/// <summary>
	/// Unlocks if skill is at least on the given level.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="skillClassName"></param>
	/// <param name="minLevel"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_ABIL_SKILL(Character character, string skillClassName, int minLevel, AbilityData data)
	{
		var skill = character.Skills.Get(skillClassName);

		return (skill != null && skill.Level >= minLevel);
	}

	/// <summary>
	/// Unlocks if character's level is high enough, based on given
	/// level and the ability tree data.
	/// </summary>
	/// <remarks>
	/// Not used on officials right now, included it just in case.
	/// </remarks>
	/// <param name="character"></param>
	/// <param name="skillClassName"></param>
	/// <param name="level"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_ABIL_LEVEL(Character character, string skillClassName, int level, AbilityData data)
	{
		var minLevel = level + data?.Level;

		return (character.Level >= minLevel);
	}

	/// <summary>
	/// Unlocks at given job rank.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="minRank"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_ABIL_RANK(Character character, string argStr, int minRank, AbilityData data)
	{
		var rank = character.Jobs.GetCurrentRank();

		return (rank >= minRank);
	}

	/// <summary>
	/// Unlocks if given skill is at least at the minLevel and character
	/// has the Priest job with circle 2 or above.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="skillClassName"></param>
	/// <param name="minLevel"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_PRIEST21(Character character, string skillClassName, int minLevel, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(JobId.Priest);
		var skill = character.Skills.Get(skillClassName);

		return (circle >= JobCircle.Second && skill != null && skill.Level >= minLevel);
	}

	/// <summary>
	/// Unlocks if the level of the skills BloodBath and BloodSucking are
	/// both above the minLevel.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="minLevel"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_FEATHERFOOT_BLOOD(Character character, string argStr, int minLevel, AbilityData data)
	{
		var bloodBath = character.Skills.Get("Featherfoot_BloodBath");
		var bloodSucking = character.Skills.Get("Featherfoot_BloodBath");

		return (bloodBath != null && bloodSucking != null && bloodBath.Level >= minLevel && bloodSucking.Level >= minLevel);
	}

	/// <summary>
	/// Unlocks if given skill is at least at level 1 and character
	/// has the Musketeer job with circle 2 or above.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="skillClassName"></param>
	/// <param name="argInt"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_MUSKETEER15(Character character, string skillClassName, int argInt, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(JobId.Musketeer);
		var skill = character.Skills.Get(skillClassName);

		return (circle >= JobCircle.Second && skill != null && skill.Level >= 1);
	}

	/// <summary>
	/// Unlocks if given skill is at least at level 10 and character
	/// has the Warlock1 job with circle 3 or above.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="argInt"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_ELEMENTALIST25(Character character, string argStr, int argInt, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(JobId.Elementalist);
		var skill = character.Skills.Get(SkillId.Elementalist_Meteor);

		return (circle >= JobCircle.Third && skill != null && skill.Level >= 10);
	}
}
