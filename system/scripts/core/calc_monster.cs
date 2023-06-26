﻿//--- Melia Script ----------------------------------------------------------
// Monster Property Calculation Functions
//--- Description -----------------------------------------------------------
// Functions that primarily calculate properties of monsters.
//---------------------------------------------------------------------------

using System;
using Melia.Shared.Tos.Const;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Monsters;

public class MonsterCalculationsFunctionsScript : GeneralScript
{
	/// <summary>
	/// Returns the monster's total max HP.
	/// </summary>
	/// <param name="monster"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_MON_MHP(Mob monster)
	{
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.MHP, out var fixValue))
			return fixValue;

		var baseValue = monster.Data.Hp;
		var byBuff = monster.Properties.GetFloat(PropertyName.MHP_BM);

		return baseValue + byBuff;
	}

	/// <summary>
	/// Returns the monster's total max SP.
	/// </summary>
	/// <param name="monster"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_MON_MSP(Mob monster)
	{
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.MSP, out var fixValue))
			return fixValue;

		var baseValue = monster.Data.Hp;
		var byBuff = monster.Properties.GetFloat(PropertyName.MSP_BM);

		return baseValue + byBuff;
	}

	/// <summary>
	/// Returns the monster's minimum physical attack.
	/// </summary>
	/// <param name="monster"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_MON_MINPATK(Mob monster)
	{
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.MINPATK, out var fixValue))
			return fixValue;

		var properties = monster.Properties;

		var baseValue = (float)monster.Data.PhysicalAttackMin;
		var value = baseValue;

		var byBuffs = 0f;
		byBuffs += properties.GetFloat(PropertyName.PATK_BM);
		byBuffs += properties.GetFloat(PropertyName.MINPATK_BM);

		var byRateBuffs = 0f;
		byRateBuffs += properties.GetFloat(PropertyName.PATK_RATE_BM);
		byRateBuffs += properties.GetFloat(PropertyName.MINPATK_RATE_BM);
		byRateBuffs = (value * byRateBuffs);

		value += byBuffs + byRateBuffs;

		return value;
	}

	/// <summary>
	/// Returns the monster's maximum physical attack.
	/// </summary>
	/// <param name="monster"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_MON_MAXPATK(Mob monster)
	{
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.MAXPATK, out var fixValue))
			return fixValue;

		var properties = monster.Properties;

		var baseValue = (float)monster.Data.PhysicalAttackMax;
		var value = baseValue;

		var byBuffs = 0f;
		byBuffs += properties.GetFloat(PropertyName.PATK_BM);
		byBuffs += properties.GetFloat(PropertyName.MAXPATK_BM);

		var byRateBuffs = 0f;
		byRateBuffs += properties.GetFloat(PropertyName.PATK_RATE_BM);
		byRateBuffs += properties.GetFloat(PropertyName.MAXPATK_RATE_BM);
		byRateBuffs = (value * byRateBuffs);

		value += byBuffs + byRateBuffs;

		return value;
	}

	/// <summary>
	/// Returns the monster's minimum magic attack.
	/// </summary>
	/// <param name="monster"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_MON_MINMATK(Mob monster)
	{
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.MINMATK, out var fixValue))
			return fixValue;

		var properties = monster.Properties;

		var baseValue = (float)monster.Data.MagicalAttackMin;
		var value = baseValue;

		var byBuffs = 0f;
		byBuffs += properties.GetFloat(PropertyName.MATK_BM);
		//byBuffs += properties.GetFloat(PropertyName.MINMATK_BM);

		var byRateBuffs = 0f;
		//byRateBuffs += properties.GetFloat(PropertyName.MATK_RATE_BM);
		//byRateBuffs += properties.GetFloat(PropertyName.MINMATK_RATE_BM);
		byRateBuffs = (value * byRateBuffs);

		value += byBuffs + byRateBuffs;

		return value;
	}

	/// <summary>
	/// Returns the monster's maximum magic attack.
	/// </summary>
	/// <param name="monster"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_MON_MAXMATK(Mob monster)
	{
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.MAXMATK, out var fixValue))
			return fixValue;

		var properties = monster.Properties;

		var baseValue = (float)monster.Data.MagicalAttackMax;
		var value = baseValue;

		var byBuffs = 0f;
		byBuffs += properties.GetFloat(PropertyName.MATK_BM);
		//byBuffs += properties.GetFloat(PropertyName.MAXMATK_BM);

		var byRateBuffs = 0f;
		//byRateBuffs += properties.GetFloat(PropertyName.MATK_RATE_BM);
		//byRateBuffs += properties.GetFloat(PropertyName.MAXMATK_RATE_BM);
		byRateBuffs = (value * byRateBuffs);

		value += byBuffs + byRateBuffs;

		return value;
	}

	/// <summary>
	/// Returns the monster's defense.
	/// </summary>
	/// <param name="monster"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_MON_DEF(Mob monster)
	{
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.DEF, out var fixValue))
			return fixValue;

		var properties = monster.Properties;

		var baseValue = (float)monster.Data.PhysicalDefense;
		var value = baseValue;

		var byBuffs = properties.GetFloat(PropertyName.DEF_BM);

		var byRateBuffs = 0f;
		//byRateBuffs += properties.GetFloat(PropertyName.DEF_RATE_BM);
		byRateBuffs = (value * byRateBuffs);

		value += byBuffs + byRateBuffs;

		return value;
	}

	/// <summary>
	/// Returns the monster's magic defense.
	/// </summary>
	/// <param name="monster"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_MON_MDEF(Mob monster)
	{
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.MDEF, out var fixValue))
			return fixValue;

		var properties = monster.Properties;

		var baseValue = (float)monster.Data.MagicalDefense;
		var value = baseValue;

		var byBuffs = properties.GetFloat(PropertyName.MDEF_BM);

		var byRateBuffs = 0f;
		//byRateBuffs += properties.GetFloat(PropertyName.MDEF_RATE_BM);
		byRateBuffs = (value * byRateBuffs);

		value += byBuffs + byRateBuffs;

		return value;
	}

	/// <summary>
	/// Returns the monster's movement speed.
	/// </summary>
	/// <param name="monster"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_MON_MSPD(Mob monster)
	{
		// Unlike most monster properties, MSPD actually has a fix buff
		// value that overrides the speed, but for constistency we'll
		// also check for an override property.
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.MSPD, out var fixValue))
			return fixValue;

		var fixMspd = monster.Properties.GetFloat(PropertyName.FIXMSPD_BM);
		if (fixMspd != 0)
			return fixMspd;

		var baseValue = monster.Properties.GetFloat(PropertyName.WlkMSPD);
		//if (running)
		//	baseValue = monster.Properties.GetFloat(PropertyName.RunMSPD);

		var byBuff = monster.Properties.GetFloat(PropertyName.MSPD_BM);

		var value = (int)Math.Max(0, baseValue + byBuff);

		return value;
	}
}
