//--- Melia Script ----------------------------------------------------------
// Character Calculation Script
//--- Description -----------------------------------------------------------
// Functions that calculate character-related values, such as properties.
//---------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Tos.Const;
using Melia.Zone;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Yggdrasil.Util;

public class CharacterCalculationsScript : GeneralScript
{
	/// <summary>
	/// Returns character's total strength.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_STR")]
	public float SCR_Get_Character_STR(Character character)
	{
		var properties = character.Properties;

		var byJob = properties.GetFloat(PropertyName.STR_JOB);
		var byStat = properties.GetFloat(PropertyName.STR_STAT);
		var byBonus = properties.GetFloat(PropertyName.STR_Bonus);
		var byAdd = properties.GetFloat(PropertyName.STR_ADD);
		var byTemp = 0; // properties.GetFloat(PropertyName.STR_TEMP);

		var rewardProperty = 0; // GET_REWARD_PROPERTY(self, statString);

		var result = byJob + byStat + byBonus + byAdd + byTemp + rewardProperty;
		return (float)Math.Floor(Math.Max(1, result));
	}

	/// <summary>
	/// Returns character's total constitution.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_CON")]
	public float SCR_Get_Character_CON(Character character)
	{
		var properties = character.Properties;

		var byJob = properties.GetFloat(PropertyName.CON_JOB);
		var byStat = properties.GetFloat(PropertyName.CON_STAT);
		var byBonus = properties.GetFloat(PropertyName.CON_Bonus);
		var byAdd = properties.GetFloat(PropertyName.CON_ADD);
		var byTemp = 0; // properties.GetFloat(PropertyName.CON_TEMP);

		var rewardProperty = 0; // GET_REWARD_PROPERTY(self, statString);

		var result = byJob + byStat + byBonus + byAdd + byTemp + rewardProperty;
		return (float)Math.Floor(Math.Max(1, result));
	}

	/// <summary>
	/// Returns character's total intelligence.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_INT")]
	public float SCR_Get_Character_INT(Character character)
	{
		var properties = character.Properties;

		var byJob = properties.GetFloat(PropertyName.INT_JOB);
		var byStat = properties.GetFloat(PropertyName.INT_STAT);
		var byBonus = properties.GetFloat(PropertyName.INT_Bonus);
		var byAdd = properties.GetFloat(PropertyName.INT_ADD);
		var byTemp = 0; // properties.GetFloat(PropertyName.INT_TEMP);

		var rewardProperty = 0; // GET_REWARD_PROPERTY(self, statString);

		var result = byJob + byStat + byBonus + byAdd + byTemp + rewardProperty;
		return (float)Math.Floor(Math.Max(1, result));
	}

	/// <summary>
	/// Returns character's total spirit.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_MNA")]
	public float SCR_Get_Character_MNA(Character character)
	{
		var properties = character.Properties;

		var byJob = properties.GetFloat(PropertyName.MNA_JOB);
		var byStat = properties.GetFloat(PropertyName.MNA_STAT);
		var byBonus = properties.GetFloat(PropertyName.MNA_Bonus);
		var byAdd = properties.GetFloat(PropertyName.MNA_ADD);
		var byTemp = 0; // properties.GetFloat(PropertyName.MNA_TEMP);

		var rewardProperty = 0; // GET_REWARD_PROPERTY(self, statString);

		var result = byJob + byStat + byBonus + byAdd + byTemp + rewardProperty;
		return (float)Math.Floor(Math.Max(1, result));
	}

	/// <summary>
	/// Returns character's total dexterity.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_DEX")]
	public float SCR_Get_Character_DEX(Character character)
	{
		var properties = character.Properties;

		var byJob = properties.GetFloat(PropertyName.DEX_JOB);
		var byStat = properties.GetFloat(PropertyName.DEX_STAT);
		var byBonus = properties.GetFloat(PropertyName.DEX_Bonus);
		var byAdd = properties.GetFloat(PropertyName.DEX_ADD);
		var byTemp = 0; // properties.GetFloat(PropertyName.DEX_TEMP);

		var rewardProperty = 0; // GET_REWARD_PROPERTY(self, statString);

		var result = byJob + byStat + byBonus + byAdd + byTemp + rewardProperty;
		return (float)Math.Floor(Math.Max(1, result));
	}

	/// <summary>
	/// Returns character's STR bonus from items and buffs.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_STR_ADD")]
	public float SCR_Get_Character_STR_ADD(Character character)
	{
		var properties = character.Properties;

		var byItem = character.Inventory.GetEquipProperties(PropertyName.STR);
		var byBuffs = properties.GetFloat(PropertyName.STR_BM);
		var byItemBuff = properties.GetFloat(PropertyName.STR_ITEM_BM);

		var value = byItem + byBuffs + byItemBuff;

		return value;
	}

	/// <summary>
	/// Returns character's CON bonus from items and buffs.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_CON_ADD")]
	public float SCR_Get_Character_CON_ADD(Character character)
	{
		var properties = character.Properties;

		var byItem = character.Inventory.GetEquipProperties(PropertyName.CON);
		var byBuffs = properties.GetFloat(PropertyName.CON_BM);
		var byItemBuff = properties.GetFloat(PropertyName.CON_ITEM_BM);

		var value = byItem + byBuffs + byItemBuff;

		return value;
	}

	/// <summary>
	/// Returns character's INT bonus from items and buffs.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_INT_ADD")]
	public float SCR_Get_Character_INT_ADD(Character character)
	{
		var properties = character.Properties;

		var byItem = character.Inventory.GetEquipProperties(PropertyName.INT);
		var byBuffs = properties.GetFloat(PropertyName.INT_BM);
		var byItemBuff = properties.GetFloat(PropertyName.INT_ITEM_BM);

		var value = byItem + byBuffs + byItemBuff;

		return value;
	}

	/// <summary>
	/// Returns character's MNA (SPR) bonus from items and buffs.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_MNA_ADD")]
	public float SCR_Get_Character_MNA_ADD(Character character)
	{
		var properties = character.Properties;

		var byItem = character.Inventory.GetEquipProperties(PropertyName.MNA);
		var byBuffs = properties.GetFloat(PropertyName.MNA_BM);
		var byItemBuff = properties.GetFloat(PropertyName.MNA_ITEM_BM);

		var value = byItem + byBuffs + byItemBuff;

		return value;
	}

	/// <summary>
	/// Returns character's DEX bonus from items and buffs.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_DEX_ADD")]
	public float SCR_Get_Character_DEX_ADD(Character character)
	{
		var properties = character.Properties;

		var byItem = character.Inventory.GetEquipProperties(PropertyName.DEX);
		var byBuffs = properties.GetFloat(PropertyName.DEX_BM);
		var byItemBuff = properties.GetFloat(PropertyName.DEX_ITEM_BM);

		var value = byItem + byBuffs + byItemBuff;

		return value;
	}

	/// <summary>
	/// Returns character's STR bonus from their jobs.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_STR_JOB")]
	public float SCR_Get_Character_STR_JOB(Character character)
	{
		var properties = character.Properties;
		var jobs = character.Jobs.GetList();

		var baseValue = character.Job?.Data.Str ?? 1;

		var level = properties.GetFloat(PropertyName.Lv);
		var totalRatio = GetJobStatRatioSum(character, jobs, PropertyName.STR);
		var byJobs = (float)Math.Floor((level - 1) * (totalRatio / jobs.Length / 100f));

		var value = baseValue + byJobs;

		return value;
	}

	/// <summary>
	/// Returns character's CON bonus from their jobs.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_CON_JOB")]
	public float SCR_Get_Character_CON_JOB(Character character)
	{
		var properties = character.Properties;
		var jobs = character.Jobs.GetList();

		var baseValue = character.Job?.Data.Con ?? 1;

		var level = properties.GetFloat(PropertyName.Lv);
		var totalRatio = GetJobStatRatioSum(character, jobs, PropertyName.CON);
		var byJobs = (float)Math.Floor((level - 1) * (totalRatio / jobs.Length / 100f));

		var value = baseValue + byJobs;

		return value;
	}

	/// <summary>
	/// Returns character's INT bonus from their jobs.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_INT_JOB")]
	public float SCR_Get_Character_INT_JOB(Character character)
	{
		var properties = character.Properties;
		var jobs = character.Jobs.GetList();

		var baseValue = character.Job?.Data.Int ?? 1;

		var level = properties.GetFloat(PropertyName.Lv);
		var totalRatio = GetJobStatRatioSum(character, jobs, PropertyName.INT);
		var byJobs = (float)Math.Floor((level - 1) * (totalRatio / jobs.Length / 100f));

		var value = baseValue + byJobs;

		return value;
	}

	/// <summary>
	/// Returns character's MNA bonus from their jobs.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_MNA_JOB")]
	public float SCR_Get_Character_MNA_JOB(Character character)
	{
		var properties = character.Properties;
		var jobs = character.Jobs.GetList();

		var baseValue = character.Job?.Data.Spr ?? 1;

		var level = properties.GetFloat(PropertyName.Lv);
		var totalRatio = GetJobStatRatioSum(character, jobs, PropertyName.MNA);
		var byJobs = (float)Math.Floor((level - 1) * (totalRatio / jobs.Length / 100f));

		var value = baseValue + byJobs;

		return value;
	}

	/// <summary>
	/// Returns character's DEX bonus from their jobs.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_DEX_JOB")]
	public float SCR_Get_Character_DEX_JOB(Character character)
	{
		var properties = character.Properties;
		var jobs = character.Jobs.GetList();

		var baseValue = character.Job?.Data.Dex ?? 1;

		var level = properties.GetFloat(PropertyName.Lv);
		var totalRatio = GetJobStatRatioSum(character, jobs, PropertyName.DEX);
		var byJobs = (float)Math.Floor((level - 1) * (totalRatio / jobs.Length / 100f));

		var value = baseValue + byJobs;

		return value;
	}

	/// <summary>
	/// Returns the total ratio for the given stat from all of the
	/// character's jobs.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="propertyName"></param>
	/// <returns></returns>
	private static float GetJobStatRatioSum(Character character, IEnumerable<Job> jobs, string propertyName)
	{
		// Prior to Re:Build (?) there was no distinction between stat and
		// stat ratio. Each job had a value assigned to each stat and that
		// was used as the ratio. The old ratio later became the default
		// stat value for the job and a new ratio was added to compensate
		// for the loss of free stat point assignment. We'll implement
		// the classic system by simply choosing the default stat values
		// as the ratio.

		if (!Feature.IsEnabled("IncreasedStatRatio"))
		{
			switch (propertyName)
			{
				case PropertyName.STR: return jobs.Sum(a => a.Data.Str);
				case PropertyName.CON: return jobs.Sum(a => a.Data.Con);
				case PropertyName.INT: return jobs.Sum(a => a.Data.Int);
				case PropertyName.MNA: return jobs.Sum(a => a.Data.Spr);
				case PropertyName.DEX: return jobs.Sum(a => a.Data.Dex);
			}
		}
		else
		{
			switch (propertyName)
			{
				case PropertyName.STR: return jobs.Sum(a => a.Data.StrRatio);
				case PropertyName.CON: return jobs.Sum(a => a.Data.ConRatio);
				case PropertyName.INT: return jobs.Sum(a => a.Data.IntRatio);
				case PropertyName.MNA: return jobs.Sum(a => a.Data.SprRatio);
				case PropertyName.DEX: return jobs.Sum(a => a.Data.DexRatio);
			}
		}

		throw new ArgumentException($"Unsupported property '{propertyName}'.");
	}

	/// <summary>
	/// Returns the character's maximum HP.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_MHP")]
	public float SCR_Get_Character_MHP(Character character)
	{
		var properties = character.Properties;

		var level = properties.GetFloat(PropertyName.Lv, 1);
		var stat = properties.GetFloat(PropertyName.CON, 1);

		var rateByJob = character.Job?.Data.HpRate ?? 1;
		var byJob = Math.Floor(400 * rateByJob);

		var byLevel = Math.Floor(byJob + ((level - 1) * 80 * rateByJob));
		var byStat = Math.Floor(((stat * 0.003f) + (Math.Floor(stat / 10.0f) * 0.01f)) * byLevel);
		var byItem = character.Inventory.GetEquipProperties(PropertyName.MHP);
		var byItemRatio = (byLevel + byStat) * (character.Inventory.GetEquipProperties(PropertyName.MHPRatio) / 100f);
		var byBonus = properties.GetFloat(PropertyName.MHP_Bonus);

		var value = byLevel + byStat + byItem + byItemRatio + byBonus;

		var byBuffs = properties.GetFloat(PropertyName.MHP_BM);
		var byBuffRate = Math.Floor(value * properties.GetFloat(PropertyName.MHP_RATE_BM));

		value += byBuffs + byBuffRate;

		return (int)Math.Max(1, value);
	}

	/// <summary>
	/// Returns the character's maximum SP.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_MSP")]
	public float SCR_Get_Character_MSP(Character character)
	{
		var properties = character.Properties;

		var level = properties.GetFloat(PropertyName.Lv, 1);
		var stat = properties.GetFloat(PropertyName.MNA, 1);

		var rateByJob = character.Job?.Data.SpRate ?? 1;
		var byJob = Math.Floor(200 * rateByJob);

		var byLevel = Math.Floor(byJob + ((level - 1) * 18 * rateByJob));
		var byStat = Math.Floor(((stat * 0.005f) + (Math.Floor(stat / 10.0f) * 0.015f)) * byLevel);
		var byItem = character.Inventory.GetEquipProperties("MSP");
		var byBonus = properties.GetFloat(PropertyName.MSP_Bonus);

		var value = byLevel + byStat + byItem + byBonus;

		var byBuffs = properties.GetFloat(PropertyName.MSP_BM);
		var byBuffRate = Math.Floor(value * properties.GetFloat(PropertyName.MSP_RATE_BM));

		value += byBuffs + byBuffRate;

		return (int)Math.Max(0, value);
	}

	/// <summary>
	/// Returns the character's maximum stamina.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_MaxSta")]
	public float SCR_Get_Character_MaxSta(Character character)
	{
		var properties = character.Properties;

		var baseValue = 25;
		var stat = properties.GetFloat(PropertyName.CON, 1);

		var byStat = Math.Floor(stat / 20f);
		var byItem = character.Inventory.GetEquipProperties(PropertyName.MSTA);
		var byBonus = properties.GetFloat(PropertyName.MAXSTA_Bonus, 0);
		var byBuff = properties.GetFloat(PropertyName.MaxSta_BM, 0);
		//var byReward = GetReward(PropertyName.MSTA);

		var value = baseValue + byStat + byItem + byBonus + byBuff;

		return (int)(value * 1000);
	}

	/// <summary>
	/// Returns the amount of stamina used when starting to run.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_Sta_RunStart")]
	public float SCR_Get_Character_Sta_RunStart(Character character)
	{
		return 0;
	}

	/// <summary>
	/// Returns the amount of stamina used while moving.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_Sta_Run")]
	public float SCR_Get_Character_Sta_Run(Character character)
	{
		var properties = character.Properties;

		// Running costs 50 stamina per second by default
		var baseValue = 50f;

		// If the FreeRunning feature is enabled, running costs nothing
		if (Feature.IsEnabled("FreeRunning"))
			baseValue = 0;

		// If DashRun is active, the stamina usage is increased. This does
		// not apply if character is in a city and FreeDashingInCities is
		// enabled.
		var isDashRun = properties.GetFloat("DashRun", 0);
		if (isDashRun > 0 && (!Feature.IsEnabled("FreeDashingInCities") || character.Map.Data.Type != MapType.City))
		{
			var dashAmount = 500f;
			if (isDashRun == 2)
				dashAmount *= 0.9f;

			baseValue += dashAmount;
		}

		var value = 250f * baseValue / 100f;

		return (int)value;
	}

	/// <summary>
	/// Returns the amount of stamina recovered per second.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_Sta_Recover")]
	public float SCR_Get_Character_Sta_Recover(Character character)
	{
		var properties = character.Properties;

		//if (buffCursed?)
		//	return 0;

		var baseValue = 400;

		var byBuff = properties.GetFloat(PropertyName.REST_BM, 0) + properties.GetFloat(PropertyName.RSta_BM, 0);
		var value = baseValue + byBuff;

		if (character.Buffs.Has(BuffId.SitRest))
			value *= 2;

		return (int)value;
	}

	/// <summary>
	/// Returns the amount of time between stamina recovery ticks?
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_Sta_R_Delay")]
	public float SCR_Get_Character_Sta_R_Delay(Character character)
	{
		return 1000;
	}

	/// <summary>
	/// Returns the amount of stamina necessary to run.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_Sta_Runable")]
	public float SCR_Get_Character_Sta_Runable(Character character)
	{
		return 250;
	}

	/// <summary>
	/// Returns the amount of stamina used when jumping.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_Sta_Jump")]
	public float SCR_Get_Character_Sta_Jump(Character character)
	{
		if (Feature.IsEnabled("FreeJumping"))
			return 0;

		return 1000;
	}

	/// <summary>
	/// Returns the amount of stamina for ...?
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_Sta_Step")]
	public float SCR_Get_Character_Sta_Step(Character character)
	{
		return 2500;
	}

	/// <summary>
	/// Returns amount of HP recovered per tick.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_RHP")]
	public float SCR_Get_Character_RHP(Character character)
	{
		var properties = character.Properties;

		var mhp = properties.GetFloat(PropertyName.MHP, 1);
		var jobHpRate = character.Job?.Data.RHpRate ?? 1;

		var byDefault = Math.Floor(mhp / 100f * jobHpRate);
		var byItems = character.Inventory.GetEquipProperties("RHP");
		var byBuffs = properties.GetFloat(PropertyName.RHP_BM);

		var value = (byDefault + byItems + byBuffs);
		return (float)Math.Max(0, value);
	}

	/// <summary>
	/// Returns HP recovery time.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_RHPTIME")]
	public float SCR_Get_Character_RHPTIME(Character character)
	{
		var properties = character.Properties;

		// The recovery time is presumably the number of milliseconds
		// between regen ticks, with the default being 20 seconds,
		// which is reduced by items, buffs, sitting, etc.

		var defaultTime = 20000;

		// Item.RHPTIME doesn't exist?
		var byItems = 0; ; // TimeSpan.FromMilliseconds(character.Inventory.GetEquipProperties("RHPTIME"));
		var byBuffs = properties.GetFloat(PropertyName.RHPTIME_BM);

		var value = defaultTime - byItems - byBuffs;

		if (character.IsSitting)
			value /= 2;

		return (int)Math.Max(1000, value);
	}

	/// <summary>
	/// Returns amount of SP to recover per tick.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_RSP")]
	public float SCR_Get_Character_RSP(Character character)
	{
		var properties = character.Properties;

		var mhp = properties.GetFloat(PropertyName.MSP, 1);
		var jobSpRate = character.Job?.Data.RSpRate ?? 1;

		var byDefault = Math.Floor(mhp * 0.03f * jobSpRate);
		var byItems = character.Inventory.GetEquipProperties("RSP");
		var byBuffs = properties.GetFloat(PropertyName.RSP_BM);

		var value = (byDefault + byItems + byBuffs);
		return (float)Math.Max(0, value);
	}

	/// <summary>
	/// Returns SP recovery time.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_RSPTIME")]
	public float SCR_Get_Character_RSPTIME(Character character)
	{
		var properties = character.Properties;

		var baseValue = 20000;

		var byItems = 0; ; // TimeSpan.FromMilliseconds(character.Inventory.GetEquipProperties("RSPTIME"));
		var byBuffs = properties.GetFloat(PropertyName.RSPTIME_BM);

		var value = baseValue - byItems - byBuffs;

		if (character.IsSitting)
			value /= 2;

		return (int)Math.Max(1000, value);
	}

	/// <summary>
	/// Returns maximum weight the character can carry.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_MaxWeight")]
	public float SCR_Get_Character_MaxWeight(Character character)
	{
		var properties = character.Properties;

		var value = 5000f;

		if (Feature.IsEnabled("IncreasedMaxWeight"))
			value = 8000f;

		if (Feature.IsEnabled("StaticInventoryWeight"))
		{
			var con = properties.GetFloat(PropertyName.CON);
			var str = properties.GetFloat(PropertyName.STR);

			var byStats = (con * 5) + (str * 5);
			value += byStats;
		}

		var byBuffs = properties.GetFloat(PropertyName.MaxWeight_BM);
		var byBonus = properties.GetFloat(PropertyName.MaxWeight_Bonus);
		value += byBuffs + byBonus;

		return value;
	}

	/// <summary>
	/// Returns combined weight of all items the character is currently carrying.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_NowWeight")]
	public float SCR_Get_Character_NowWeight(Character character)
	{
		return character.Inventory.GetNowWeight();
	}

	/// <summary>
	/// Returns the amount stat points available to the player.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_StatPoint")]
	public float SCR_Get_Character_StatPoint(Character character)
	{
		var properties = character.Properties;

		var byLevel = 0;
		if (!Feature.IsEnabled("NoStatByLevel"))
			byLevel = (int)properties.GetFloat(PropertyName.StatByLevel);

		var byBonus = (int)properties.GetFloat(PropertyName.StatByBonus);
		var usedStat = (int)properties.GetFloat(PropertyName.UsedStat);

		return (byLevel + byBonus - usedStat);
	}

	/// <summary>
	/// Returns minimum physical ATK.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_MINPATK")]
	public float SCR_Get_Character_MINPATK(Character character)
	{
		var SCR_Get_Character_MAXPATK = ScriptableFunctions.Character.Get("SCR_Get_Character_MAXPATK");

		var properties = character.Properties;

		var level = properties.GetFloat(PropertyName.Lv, 1);
		var stat = properties.GetFloat(PropertyName.STR, 1);

		var baseValue = 20;
		var byLevel = level;

		var byStat = (stat * 2f) + ((float)Math.Floor(stat / 10f) * (byLevel * 0.05f));

		var byItem = 0f;
		byItem += character.Inventory.GetEquipProperties(PropertyName.MINATK);
		byItem += character.Inventory.GetEquipProperties(PropertyName.PATK);
		byItem += character.Inventory.GetEquipProperties(PropertyName.ADD_MINATK);

		var value = (baseValue + byLevel + byStat + byItem);

		var byBuffs = 0f;
		byBuffs += properties.GetFloat(PropertyName.PATK_BM);
		byBuffs += properties.GetFloat(PropertyName.MINPATK_BM);
		byBuffs += properties.GetFloat(PropertyName.PATK_MAIN_BM);
		byBuffs += properties.GetFloat(PropertyName.MINPATK_MAIN_BM);

		var byRateBuffs = 0f;
		byRateBuffs += properties.GetFloat(PropertyName.PATK_RATE_BM);
		byRateBuffs += properties.GetFloat(PropertyName.MINPATK_RATE_BM);
		byRateBuffs += properties.GetFloat(PropertyName.PATK_MAIN_RATE_BM);
		byRateBuffs += properties.GetFloat(PropertyName.MINPATK_MAIN_RATE_BM);
		byRateBuffs = (value * byRateBuffs);

		value += byBuffs + byRateBuffs;

		var max = SCR_Get_Character_MAXPATK(character);
		return (float)Math2.Clamp(1, max, value);
	}

	/// <summary>
	/// Returns maximum physical ATK.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_MAXPATK")]
	public float SCR_Get_Character_MAXPATK(Character character)
	{
		var properties = character.Properties;

		var level = properties.GetFloat(PropertyName.Lv, 1);
		var stat = properties.GetFloat(PropertyName.STR, 1);

		var baseValue = 20;
		var byLevel = level;

		var byStat = (stat * 2f) + ((float)Math.Floor(stat / 10f) * (byLevel * 0.05f));

		var byItem = 0f;
		byItem += character.Inventory.GetEquipProperties(PropertyName.MAXATK);
		byItem += character.Inventory.GetEquipProperties(PropertyName.PATK);
		byItem += character.Inventory.GetEquipProperties(PropertyName.ADD_MAXATK);

		var value = (baseValue + byLevel + byStat + byItem);

		var byBuffs = 0f;
		byBuffs += properties.GetFloat(PropertyName.PATK_BM);
		byBuffs += properties.GetFloat(PropertyName.MAXPATK_BM);
		byBuffs += properties.GetFloat(PropertyName.PATK_MAIN_BM);
		byBuffs += properties.GetFloat(PropertyName.MAXPATK_MAIN_BM);

		var byRateBuffs = 0f;
		byRateBuffs += properties.GetFloat(PropertyName.PATK_RATE_BM);
		byRateBuffs += properties.GetFloat(PropertyName.MAXPATK_RATE_BM);
		byRateBuffs += properties.GetFloat(PropertyName.PATK_MAIN_RATE_BM);
		byRateBuffs += properties.GetFloat(PropertyName.MAXPATK_MAIN_RATE_BM);
		byRateBuffs = (value * byRateBuffs);

		value += byBuffs + byRateBuffs;

		return (float)Math.Max(1, value);
	}

	/// <summary>
	/// Returns minimum physical ATK (for sub-weapon?).
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_MINPATK_SUB")]
	public float SCR_Get_Character_MINPATK_SUB(Character character)
	{
		var SCR_Get_Character_MAXPATK_SUB = ScriptableFunctions.Character.Get("SCR_Get_Character_MAXPATK_SUB");

		var properties = character.Properties;

		var baseValue = 20;
		var level = properties.GetFloat(PropertyName.Lv);
		var stat = properties.GetFloat(PropertyName.STR);

		var byLevel = level / 2f;
		var byStat = (stat * 2f) + ((float)Math.Floor(stat / 10f) * 5f);
		var byItem = 0; // TODO: "MINATK" "PATK" "ADD_MINATK"

		var value = baseValue + byLevel + byStat + byItem;

		// Reducation for shields and stuff?
		//value -= leftHand.MinAtk;
		//if(hasBuff("Warrior_RH_VisibleObject"))
		//	value -= rightHand.MinAtk

		// Buffs: "PATK_BM", "MINPATK_SUB_BM"
		var byBuffs = 0;

		// Rate buffs: "PATK_RATE_BM", "MINPATK_SUB_RATE_BM"
		//if(hasBuff("Guardian"))
		//	rate -= SkillLevel
		var rate = 0;
		var byRateBuffs = (float)Math.Floor(value * rate);

		value += byBuffs + byRateBuffs;

		var maxPatk_sub = SCR_Get_Character_MAXPATK_SUB(character);
		if (value > maxPatk_sub)
			return maxPatk_sub;

		return (int)value;
	}

	/// <summary>
	/// Returns maximum physical ATK (for sub-weapon?).
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_MAXPATK_SUB")]
	public float SCR_Get_Character_MAXPATK_SUB(Character character)
	{
		var properties = character.Properties;

		var baseValue = 20;
		var level = properties.GetFloat(PropertyName.Lv);
		var stat = properties.GetFloat(PropertyName.STR);

		var byLevel = level / 2f;
		var byStat = (stat * 2f) + ((float)Math.Floor(stat / 10f) * 5f);
		var byItem = 0; // TODO: "MAXATK" "PATK" "ADD_MAXATK"

		var value = baseValue + byLevel + byStat + byItem;

		// Reducation for shields and stuff?
		//value -= leftHand.MaxAtk;
		//if(hasBuff("Warrior_RH_VisibleObject"))
		//	value -= rightHand.MaxAtk;

		// Buffs: "PATK_BM", "MAXPATK_SUB_BM"
		var byBuffs = 0;

		// Rate buffs: "PATK_RATE_BM", "MAXPATK_SUB_RATE_BM"
		//if(hasBuff("Guardian"))
		//	rate -= SkillLevel
		var rate = 0;
		var byRateBuffs = (float)Math.Floor(value * rate);

		value += byBuffs + byRateBuffs;

		return (int)value;
	}

	/// <summary>
	/// Returns minimum magic ATK.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_MINMATK")]
	public float SCR_Get_Character_MINMATK(Character character)
	{
		var SCR_Get_Character_MAXMATK = ScriptableFunctions.Character.Get("SCR_Get_Character_MAXMATK");

		var properties = character.Properties;

		var level = properties.GetFloat(PropertyName.Lv, 1);
		var stat = properties.GetFloat(PropertyName.INT, 1);

		var baseValue = 20;
		var byLevel = level;

		var byStat = (stat * 2f) + ((float)Math.Floor(stat / 10f) * (byLevel * 0.05f));

		var byItem = 0f;
		byItem += character.Inventory.GetEquipProperties(PropertyName.MATK);
		byItem += character.Inventory.GetEquipProperties(PropertyName.ADD_MATK);
		byItem += character.Inventory.GetEquipProperties(PropertyName.ADD_MINATK);

		var value = (baseValue + byLevel + byStat + byItem);

		var byBuffs = 0f;
		byBuffs += properties.GetFloat(PropertyName.MATK_BM);
		byBuffs += properties.GetFloat(PropertyName.MINMATK_BM);

		var byRateBuffs = 0f;
		byRateBuffs += properties.GetFloat(PropertyName.MATK_RATE_BM);
		byRateBuffs += properties.GetFloat(PropertyName.MINMATK_RATE_BM);
		byRateBuffs = (value * byRateBuffs);

		value += byBuffs + byRateBuffs;

		var max = SCR_Get_Character_MAXMATK(character);
		return (float)Math2.Clamp(1, max, value);
	}

	/// <summary>
	/// Returns maximum magic ATK.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_MAXMATK")]
	public float SCR_Get_Character_MAXMATK(Character character)
	{
		var properties = character.Properties;

		var level = properties.GetFloat(PropertyName.Lv, 1);
		var stat = properties.GetFloat(PropertyName.INT, 1);

		var baseValue = 20;
		var byLevel = level;

		var byStat = (stat * 2f) + ((float)Math.Floor(stat / 10f) * (byLevel * 0.05f));

		var byItem = 0f;
		byItem += character.Inventory.GetEquipProperties(PropertyName.MATK);
		byItem += character.Inventory.GetEquipProperties(PropertyName.ADD_MATK);
		byItem += character.Inventory.GetEquipProperties(PropertyName.ADD_MAXATK);

		var value = (baseValue + byLevel + byStat + byItem);

		var byBuffs = 0f;
		byBuffs += properties.GetFloat(PropertyName.MATK_BM);
		byBuffs += properties.GetFloat(PropertyName.MAXMATK_BM);

		var byRateBuffs = 0f;
		byRateBuffs += properties.GetFloat(PropertyName.MATK_RATE_BM);
		byRateBuffs += properties.GetFloat(PropertyName.MAXMATK_RATE_BM);
		byRateBuffs = (value * byRateBuffs);

		value += byBuffs + byRateBuffs;

		return (float)Math.Max(1, value);
	}

	/// <summary>
	/// Returns Physical Defense.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_DEF")]
	public float SCR_Get_Character_DEF(Character character)
	{
		var properties = character.Properties;

		var baseValue = 20;
		var level = properties.GetFloat(PropertyName.Lv);

		var byLevel = level;
		var byItem = character.Inventory.GetEquipProperties(PropertyName.DEF);

		var value = baseValue + byLevel + byItem;

		var byBuffs = properties.GetFloat(PropertyName.DEF_BM);

		var rate = properties.GetFloat(PropertyName.DEF_RATE_BM);
		var byRateBuffs = (float)Math.Floor(value * rate);

		value += byBuffs + byRateBuffs;

		return (int)value;
	}

	/// <summary>
	/// Returns Magic Defense.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_MDEF")]
	public float SCR_Get_Character_MDEF(Character character)
	{
		var properties = character.Properties;

		var baseValue = 20;
		var level = properties.GetFloat(PropertyName.Lv);

		var byLevel = level;
		var byItem = character.Inventory.GetEquipProperties(PropertyName.MDEF);

		var value = baseValue + byLevel + byItem;

		var byBuffs = properties.GetFloat(PropertyName.MDEF_BM);

		var rate = properties.GetFloat(PropertyName.MDEF_RATE_BM);
		var byRateBuffs = (float)Math.Floor(value * rate);

		value += byBuffs + byRateBuffs;

		return (int)value;
	}

	/// <summary>
	/// Returns critical attack.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_CRTATK")]
	public float SCR_Get_Character_CRTATK(Character character)
	{
		var properties = character.Properties;

		var stat = properties.GetFloat(PropertyName.DEX);

		var byStat = (stat * 4f) + ((float)Math.Floor(stat / 10f) * 10f);
		var byItem = 0; // TODO

		var value = byStat + byItem;

		// Buffs: "CRTATK_BM"
		var byBuffs = 0;

		// Rate buffs: Does Tos have something like CritATK +x%?
		var rate = 0;
		var byRateBuffs = (float)Math.Floor(value * rate);

		value += byBuffs + byRateBuffs;

		return (int)value;
	}

	/// <summary>
	/// Returns critical hit rate (crit chance).
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_CRTHR")]
	public float SCR_Get_Character_CRTHR(Character character)
	{
		var properties = character.Properties;

		var level = properties.GetFloat(PropertyName.Lv);

		var byLevel = level / 2f;
		var byItem = 0; // TODO

		var value = byLevel + byItem;

		var byBuffs = character.Properties.GetFloat(PropertyName.CRTHR_BM);

		var rate = character.Properties.GetFloat(PropertyName.CRTHR_RATE_BM);
		var byRateBuffs = (float)Math.Floor(value * rate);

		value += byBuffs + byRateBuffs;

		return (int)value;
	}

	/// <summary>
	/// Returns critical dodge rate.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_CRTDR")]
	public float SCR_Get_Character_CRTDR(Character character)
	{
		var properties = character.Properties;

		var level = properties.GetFloat(PropertyName.Lv);

		var byLevel = level / 2f;
		var byItem = 0; // TODO

		var value = byLevel + byItem;

		var byBuffs = character.Properties.GetFloat(PropertyName.CRTDR_BM);

		var rate = character.Properties.GetFloat(PropertyName.CRTDR_RATE_BM);
		var byRateBuffs = (float)Math.Floor(value * rate);

		value += byBuffs + byRateBuffs;

		return (int)value;
	}

	/// <summary>
	/// Returns hit rate.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_HR")]
	public float SCR_Get_Character_HR(Character character)
	{
		var properties = character.Properties;

		var level = properties.GetFloat(PropertyName.Lv);
		var stat = properties.GetFloat(PropertyName.STR);

		var byLevel = level / 4f;
		var byStat = (stat / 2f) + ((float)Math.Floor(stat / 15f) * 3f);
		var byItem = 0; // HR, ADD_HR

		var value = byLevel + byStat + byItem;

		var byBuffs = character.Properties.GetFloat(PropertyName.HR_BM);

		var rate = character.Properties.GetFloat(PropertyName.HR_RATE_BM);
		var byRateBuffs = (float)Math.Floor(value * rate);

		value += byBuffs + byRateBuffs;

		return (int)value;
	}

	/// <summary>
	/// Returns dodge rate.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_DR")]
	public float SCR_Get_Character_DR(Character character)
	{
		var properties = character.Properties;

		var level = properties.GetFloat(PropertyName.Lv);
		var stat = properties.GetFloat(PropertyName.DEX);

		var byLevel = level / 4f;
		var byStat = (stat / 2f) + ((float)Math.Floor(stat / 15f) * 3f);
		var byItem = 0; // TODO

		var value = byLevel + byStat + byItem;

		var byBuffs = character.Properties.GetFloat(PropertyName.DR_BM);

		var rate = character.Properties.GetFloat(PropertyName.DR_RATE_BM);
		var byRateBuffs = (float)Math.Floor(value * rate);

		value += byBuffs + byRateBuffs;

		return (int)value;
	}

	/// <summary>
	/// Returns block.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_BLK")]
	public float SCR_Get_Character_BLK(Character character)
	{
		var properties = character.Properties;

		// TODO: Update it after equipment change.
		// Shield/Dagger = Right hand.
		if (character.Inventory.GetItem(EquipSlot.LeftHand).Data.EquipType1 != EquipType.Shield)
			return 0;

		var Level = properties.GetFloat(PropertyName.Lv);
		var stat = properties.GetFloat(PropertyName.CON);

		var byLevel = Level / 4f;
		var byStat = (stat / 2f) + ((float)Math.Floor(stat / 15f) * 3f);
		var byItem = 0f; // TODO

		var value = byLevel + byStat + byItem;

		var byBuffs = character.Properties.GetFloat(PropertyName.BLK_BM);

		var rate = character.Properties.GetFloat(PropertyName.BLK_RATE_BM);
		var byRateBuffs = (float)Math.Floor(value * rate);

		value += byBuffs + byRateBuffs;

		return (int)value;
	}

	/// <summary>
	/// Returns block break (penetration).
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_BLK_BREAK")]
	public float SCR_Get_Character_BLK_BREAK(Character character)
	{
		var properties = character.Properties;

		var level = properties.GetFloat(PropertyName.Lv);
		var stat = properties.GetFloat(PropertyName.DEX);

		var byLevel = level / 4f;
		var byStat = (stat / 2f) + ((float)Math.Floor(stat / 15f) * 3f);
		var byItem = 0; // TODO

		var value = byLevel + byStat + byItem;

		var byBuffs = character.Properties.GetFloat(PropertyName.BLK_BREAK_BM);

		var rate = character.Properties.GetFloat(PropertyName.BLK_BREAK_RATE_BM);
		var byRateBuffs = (float)Math.Floor(value * rate);

		value += byBuffs + byRateBuffs;

		return (int)value;
	}

	/// <summary>
	/// Returns the character's AoE Attack Ratio?
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_SR")]
	public float SCR_Get_Character_SR(Character character)
	{
		var properties = character.Properties;

		var baseValue = 3;

		if (character.Jobs.Has(JobId.Swordsman, JobCircle.First))
			baseValue = 4;
		else if (character.Jobs.Has(JobId.Archer, JobCircle.First))
			baseValue = 0;

		var byItem = character.Inventory.GetEquipProperties(PropertyName.SR);
		var byBuffs = character.Properties.GetFloat(PropertyName.SR_BM);

		var value = baseValue + byItem + byBuffs;

		return (int)value;
	}

	/// <summary>
	/// Returns character's AoE Defense Ratio.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_SDR")]
	public float SCR_Get_Character_SDR(Character character)
	{
		if (character.Properties.TryGetFloat(PropertyName.FixedMinSDR_BM, out var fixedSDR))
		{
			if (fixedSDR != 0)
				return 1;
		}

		var baseValue = 1;
		var byItem = character.Inventory.GetEquipProperties(PropertyName.SDR);
		var byBuffs = character.Properties.GetFloat(PropertyName.SDR_BM);

		var value = baseValue + byItem + byBuffs;

		return (int)Math.Max(1, value);
	}

	/// <summary>
	/// Returns character's movement speed.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_MSPD")]
	public float SCR_Get_Character_MSPD(Character character)
	{
		var properties = character.Properties;

		var fixMspd = properties.GetFloat(PropertyName.FIXMSPD_BM);
		if (fixMspd != 0)
			return fixMspd;

		var baseValue = 30;
		var byBuff = properties.GetFloat(PropertyName.MSPD_BM);
		var byBonus = properties.GetFloat(PropertyName.MSPD_Bonus);

		return (baseValue + byBuff + byBonus);
	}

	/// <summary>
	/// Returns character's current jump power, which dictates how
	/// high they can jump.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_JumpPower")]
	public float SCR_Get_Character_JumpPower(Character character)
	{
		return 350;
	}

	/// <summary>
	/// Returns character's current casting speed.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_CastingSpeed")]
	public float SCR_Get_Character_CastingSpeed(Character character)
	{
		var properties = character.Properties;

		var baseStat = 100;
		var byBuff = properties.GetFloat(PropertyName.CastingSpeed_BM);

		var result = baseStat + byBuff;
		return (float)Math.Floor(Math2.Clamp(10, 200, result));
	}

	/// <summary>
	/// Returns 1 if the character is able to shoot while moving.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_MovingShotable")]
	public float SCR_Get_Character_MovingShotable(Character character)
	{
		return character.JobClass == JobClass.Archer ? 1 : 0;
	}

	/// <summary>
	/// Returns movement speed for while shooting.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_Character_MovingShot")]
	public float SCR_Get_Character_MovingShot(Character character)
	{
		var canMoveWhileShooting = character.Properties.GetFloat(PropertyName.MovingShotable) == 1;
		if (!canMoveWhileShooting)
			return 0;

		var byJob = (character.JobClass == JobClass.Archer ? 0.8f : 0);
		var byBuff = character.Properties.GetFloat(PropertyName.MovingShot_BM);

		var value = byJob + byBuff;

		return Math.Min(5, value);
	}

	/// <summary>
	/// Returns character's skill range, which adds potentially to the
	/// skill's splash range.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_SkillRange")]
	public float SCR_Get_SkillRange(Character character)
	{
		var byItem = character.Inventory.GetEquipProperties(PropertyName.SkillRange);
		var byBuff = character.Properties.GetFloat(PropertyName.SkillRange_BM);

		var value = byItem + byBuff;
		return value;
	}
}
