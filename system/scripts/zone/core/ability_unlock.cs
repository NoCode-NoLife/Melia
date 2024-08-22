//--- Melia Script ----------------------------------------------------------
// Ability Unlocked Check Functions
//--- Description -----------------------------------------------------------
// Scriptable functions that determine whether an ability is unlocked
// and can be learned.
//---------------------------------------------------------------------------

using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
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
	/// Unlocks if character base level is at least on the given min base level.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="skillClassName"></param>
	/// <param name="minBaseLevel"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_BASE_LEVEL(Character character, string skillClassName, int minBaseLevel, AbilityData data)
	{
		return character.Level >= minBaseLevel;
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
	/// <param name="argNum"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_MUSKETEER15(Character character, string skillClassName, int argNum, AbilityData data)
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
	/// <param name="argNum"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_ELEMENTALIST25(Character character, string argStr, int argNum, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(JobId.Elementalist);
		var skill = character.Skills.Get(SkillId.Elementalist_Meteor);

		return (circle >= JobCircle.Third && skill != null && skill.Level >= 10);
	}

	/// <summary>
	/// Unlocks if the character is at least Falconer Circle 3 and and has
	/// the skills Calling and BuildRoost.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="argNum"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_FALCONER20(Character character, string argStr, int argNum, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(JobId.Falconer);
		var skill1 = character.Skills.Get(SkillId.Falconer_Calling);
		var skill2 = character.Skills.Get(SkillId.Falconer_BuildRoost);

		return (circle >= JobCircle.Third && skill1 != null && skill2 != null);
	}

	/// <summary>
	/// Unlocks of the character is a Sorcerer Circle 3 and their Summoning
	/// skill is at least level 11.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="argNum"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_SORCERER16(Character character, string argStr, int argNum, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(JobId.Sorcerer);
		var skill = character.Skills.Get(SkillId.Sorcerer_Summoning);

		return (circle >= JobCircle.Third && skill?.Level >= 11);
	}

	/// <summary>
	/// Unlocks of the character is a Necromancer Circle 3 and their
	/// EnchantFire skill is at least level 6.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="argNum"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_NECROMANCER24(Character character, string argStr, int argNum, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(JobId.Necromancer);
		var skill = character.Skills.Get(SkillId.Pyromancer_EnchantFire);

		return (circle >= JobCircle.Third && skill?.Level >= 6);
	}

	/// <summary>
	/// Unlocks of the character is a Necromancer Circle 3 and their
	/// IceBolt skill is at least level 6.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="argNum"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_NECROMANCER25(Character character, string argStr, int argNum, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(JobId.Necromancer);
		var skill = character.Skills.Get(SkillId.Cryomancer_IceBolt);

		return (circle >= JobCircle.Third && skill?.Level >= 6);
	}
	/// <summary>
	/// Unlocks of the character is a Peltasta Circle 2 and their
	/// SwashBuckling skill is at least level 6.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="argNum"></param>
	/// <param name="data"></param>
	/// <returns></returns>

	[ScriptableFunction]
	public static bool UNLOCK_PELTASTA30(Character character, string argStr, int argNum, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(JobId.Peltasta);
		var skill = character.Skills.Get(SkillId.Peltasta_SwashBuckling);

		return (circle >= JobCircle.Second && skill?.Level >= 6);
	}

	/// <summary>
	/// Unlocks of the character is a Wizard Circle 2 and their
	/// Sleep skill is at least level 6.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="argNum"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_WIZARD25(Character character, string argStr, int argNum, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(JobId.Wizard);
		var skill = character.Skills.Get(SkillId.Wizard_Sleep);

		return (circle >= JobCircle.Second && skill?.Level >= 6);
	}

	/// <summary>
	/// Unlocks of the character is a Onmyoji Circle 2 and their
	/// WhiteTigerHowling skill is at least level 6.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="argNum"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_ONMYOJI8(Character character, string argStr, int argNum, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(JobId.Onmyoji);
		var skill = character.Skills.Get(SkillId.Onmyoji_WhiteTigerHowling);

		return (circle >= JobCircle.Second && skill?.Level >= 6);
	}

	/// <summary>
	/// Unlocks of the character is a Onmyoji Circle 2 and their
	/// FireFoxShikigami skill is at least level 6.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="argNum"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction("UNLOCK_ONMYOJI17")]
	[ScriptableFunction("UNLOCK_ONMYOJI18")]
	public static bool UNLOCK_ONMYOJI17_18(Character character, string argStr, int argNum, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(JobId.Onmyoji);
		var skill = character.Skills.Get(SkillId.Onmyoji_FireFoxShikigami);

		return (circle >= JobCircle.Second && skill?.Level >= 6);
	}

	/// <summary>
	/// Unlocks of the character is a Peltasta Circle 2 and their
	/// Guardian skill is at least level 6.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="argNum"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_PELTASTA33(Character character, string argStr, int argNum, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(JobId.Peltasta);
		var skill = character.Skills.Get(SkillId.Peltasta_Guardian);

		return (circle >= JobCircle.Second && skill?.Level >= 6);
	}

	/// <summary>
	/// Unlocks of the character is a Peltasta Circle 2 and their
	/// Guardian skill is at least level 11.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="argNum"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_PELTASTA34(Character character, string argStr, int argNum, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(JobId.Peltasta);
		var skill = character.Skills.Get(SkillId.Peltasta_Guardian);

		return (circle >= JobCircle.Second && skill?.Level >= 11);
	}

	/// <summary>
	/// Unlocks of the character is a Lancer Circle 3 and their
	/// Prevent skill is at least level 6.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="argNum"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_LANCER14(Character character, string argStr, int argNum, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(JobId.Lancer);
		var skill = character.Skills.Get(SkillId.Rancer_Prevent);

		return (circle >= JobCircle.Third && skill?.Level >= 6);
	}

	/// <summary>
	/// Unlocks of the character is a Lancer Circle 3 and their
	/// Chage skill is at least level 6.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="argNum"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_LANCER_RHONGOMIANT(Character character, string argStr, int argNum, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(JobId.Lancer);
		var skill = character.Skills.Get(SkillId.Rancer_Chage);

		return (circle >= JobCircle.Third && skill?.Level >= 6);
	}

	/// <summary>
	/// Unlocks of the character is a Hackapell Circle 3 and they
	/// have the CavalryCharge skill.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="argNum"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_HACKAPELL14(Character character, string argStr, int argNum, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(JobId.Hackapell);
		var skill = character.Skills.Get(SkillId.Hackapell_CavalryCharge);

		return (circle >= JobCircle.Third && skill != null);
	}

	/// <summary>
	/// Unlocks of the character is a Onmyoji Circle 3 and their
	/// WaterShikigami skill is at least level 11.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="argNum"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_ONMYOJI10(Character character, string argStr, int argNum, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(JobId.Onmyoji);
		var skill = character.Skills.Get(SkillId.Onmyoji_WaterShikigami);

		return (circle >= JobCircle.Third && skill?.Level >= 11);
	}

	/// <summary>
	/// Unlocks of the character is a Lancer Circle 3 and their
	/// SpillAttack skill is at least level 6.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="argNum"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_LANCER17(Character character, string argStr, int argNum, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(JobId.Lancer);
		var skill = character.Skills.Get(SkillId.Rancer_SpillAttack);

		return (circle >= JobCircle.Third && skill?.Level >= 6);
	}

	/// <summary>
	/// Unlocks if the character has the given min level and the given
	/// skill on at least level 15.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="skillClassName"></param>
	/// <param name="minLevel"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_TIGERHUNTER2(Character character, string skillClassName, int minLevel, AbilityData data)
	{
		var skill = character.Skills.Get(skillClassName);

		return (character.Level >= minLevel && skill?.Level >= 15);
	}

	/// <summary>
	/// Unlocks if the character is at least rank 10 and the given job
	/// has the min circle.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="jobClassName"></param>
	/// <param name="iMinCircle"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_ABIL_CIRCLE_AND_RANK(Character character, string jobClassName, int iMinCircle, AbilityData data)
	{
		var rank = character.Jobs.GetCurrentRank();
		var circle = character.Jobs.GetCircle(jobClassName);
		var minCircle = (JobCircle)iMinCircle;

		return (circle >= minCircle && rank >= 10);
	}

	/// <summary>
	/// Unlocks if the given ability is at least on the given level.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="abilityClassName"></param>
	/// <param name="minLevel"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_ABIL_OTHERABILITY(Character character, string abilityClassName, int minLevel, AbilityData data)
	{
		var ability = character.Abilities.Get(abilityClassName);

		return (ability?.Level >= minLevel);
	}

	/// <summary>
	/// Unlocks if the character's current job is at the given min level.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="jobClassName"></param>
	/// <param name="minLevel"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_ABIL_JOB_LEVEL(Character character, string jobClassName, int minLevel, AbilityData data)
	{
		var job = character.Jobs.Get(jobClassName);

		return (job?.Level >= minLevel);
	}

	/// <summary>
	/// Unlocks if the character is an Arbalester Circle 3 and their
	/// GuidedShot skill is at least level 5.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="minLevel"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_ARBALESTER21_LEVEL(Character character, string argStr, int minLevel, AbilityData data)
	{
		var circle = character.Jobs.GetCircle(JobId.Arbalester);
		var skill = character.Skills.Get(SkillId.Arbalester_GuidedShot);

		return (circle >= JobCircle.Third && skill?.Level >= 5);
	}

	/// <summary>
	/// Unlocks if the character is an Arbalester Circle 3, at least level
	/// 300, and their Targeted Arrow ability is at least level 5.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="minLevel"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_ARBALESTER19_LEVEL(Character character, string argStr, int minLevel, AbilityData data)
	{
		var job = character.Jobs.Get(JobId.Arbalester);
		var ability = character.Abilities.Get(AbilityId.Arbalester21);

		return (job?.Level >= minLevel && character.Level >= 300 && ability?.Level >= 5);
	}

	/// <summary>
	/// Unlocks if the character has the given skill and is at the
	/// given level or higher.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="skillClassName"></param>
	/// <param name="minLevel"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public static bool UNLOCK_LUCHADOR_SUBSKILL_COND(Character character, string skillClassName, int minLevel, AbilityData data)
	{
		var skill = character.Skills.Get(skillClassName);

		return (skill != null && character.Level >= minLevel);
	}
}
