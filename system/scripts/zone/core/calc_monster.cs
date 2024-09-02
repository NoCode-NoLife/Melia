﻿//--- Melia Script ----------------------------------------------------------
// Monster Property Calculation Functions
//--- Description -----------------------------------------------------------
// Functions that primarily calculate properties of monsters.
//---------------------------------------------------------------------------

using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Components;
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
		var baseValue = monster.Data.Hp;
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.MHP, out var overrideValue))
			baseValue = overrideValue;

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
		var baseValue = monster.Data.Sp;
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.MSP, out var overrideValue))
			baseValue = overrideValue;

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
		var properties = monster.Properties;

		var baseValue = monster.Data.PhysicalAttackMin;
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.MINPATK, out var overrideValue))
			baseValue = overrideValue;

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
		var properties = monster.Properties;

		var baseValue = monster.Data.PhysicalAttackMax;
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.MAXPATK, out var overrideValue))
			baseValue = overrideValue;

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
		var properties = monster.Properties;

		var baseValue = monster.Data.MagicalAttackMin;
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.MINMATK, out var overrideValue))
			baseValue = overrideValue;

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
		var properties = monster.Properties;

		var baseValue = monster.Data.MagicalAttackMax;
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.MAXMATK, out var overrideValue))
			baseValue = overrideValue;

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
		var properties = monster.Properties;

		var baseValue = monster.Data.PhysicalDefense;
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.DEF, out var overrideValue))
			baseValue = overrideValue;

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
		var properties = monster.Properties;

		var baseValue = monster.Data.MagicalDefense;
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.MDEF, out var overrideValue))
			baseValue = overrideValue;

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
		if (monster.IsLocked(LockType.Movement))
			return 0;

		// Unlike most monster properties, MSPD actually has a fix buff
		// value that overrides the speed, but for constistency we'll
		// also check for an override property.
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.MSPD, out var overrideValue))
			return overrideValue;

		// It's currently not possible to set a fix value of 0 via the buff property,
		// because 0 is the default value, indicating that the property is not set.
		var fixMspd = monster.Properties.GetFloat(PropertyName.FIXMSPD_BM);
		if (fixMspd != 0)
			return fixMspd;

		var moveSpeedType = monster.Components.Get<MovementComponent>()?.MoveSpeedType ?? MoveSpeedType.Walk;
		var propertyName = moveSpeedType == MoveSpeedType.Walk ? PropertyName.WlkMSPD : PropertyName.RunMSPD;
		var baseValue = monster.Properties.GetFloat(propertyName);

		var byBuff = monster.Properties.GetFloat(PropertyName.MSPD_BM);

		var value = (int)Math.Max(0, baseValue + byBuff);

		return value;
	}

	/// <summary>
	/// Returns the monster's dodge rate.
	/// </summary>
	/// <param name="monster"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_MON_DR(Mob monster)
	{
		var properties = monster.Properties;

		var baseValue = monster.Data.DodgeRate;
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.DR, out var overrideValue))
			baseValue = overrideValue;

		var byBuffs = properties.GetFloat(PropertyName.DR_BM);

		return baseValue + byBuffs;
	}

	/// <summary>
	/// Returns the monster's dodge rate.
	/// </summary>
	/// <param name="monster"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_MON_HR(Mob monster)
	{
		var properties = monster.Properties;

		var baseValue = monster.Data.HitRate;
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.HR, out var overrideValue))
			baseValue = overrideValue;

		var byBuffs = properties.GetFloat(PropertyName.HR_BM);

		return baseValue + byBuffs;
	}

	/// <summary>
	/// Returns the monster's AoE Attack Ratio.
	/// </summary>
	/// <param name="monster"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_MON_SR(Mob monster)
	{
		int baseValue;
		switch (monster.Data.Size)
		{
			case SizeType.S: baseValue = 8; break;
			case SizeType.M: baseValue = 16; break;
			case SizeType.L: baseValue = 24; break;
			default: baseValue = 50; break;
		}

		var byBuffs = monster.Properties.GetFloat(PropertyName.SDR_BM);

		var value = baseValue + byBuffs;

		return (int)Math.Max(1, value);
	}

	/// <summary>
	/// Returns the monster's AoE Defense Ratio.
	/// </summary>
	/// <param name="monster"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_MON_SDR(Mob monster)
	{
		int baseValue;
		switch (monster.Data.Size)
		{
			case SizeType.S: baseValue = 1; break;
			case SizeType.M: baseValue = 2; break;
			case SizeType.L: baseValue = 3; break;
			default: baseValue = 5; break;
		}

		var byBuffs = monster.Properties.GetFloat(PropertyName.SDR_BM);

		var value = baseValue + byBuffs;

		return (int)Math.Max(1, value);
	}

	/// <summary>
	/// Returns the monster's Critical Hit Rate.
	/// </summary>
	/// <param name="monster"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_MON_CRTHR(Mob monster)
	{
		var baseValue = monster.Data.CritHitRate;
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.CRTHR, out var overrideValue))
			baseValue = overrideValue;

		var value = baseValue;

		var byBuffs = 0f;
		byBuffs += monster.Properties.GetFloat(PropertyName.CRTHR_BM, 0);

		var byRateBuffs = 0f;
		byRateBuffs += monster.Properties.GetFloat(PropertyName.CRTHR_RATE_BM);
		byRateBuffs = value * byRateBuffs;

		value = value + byBuffs + byRateBuffs;

		return (int)value;
	}

	/// <summary>
	/// Returns the monster's Critical Dodge Rate (Critical resistance).
	/// </summary>
	/// <param name="monster"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_MON_CRTDR(Mob monster)
	{
		var baseValue = monster.Data.CritDodgeRate;
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.CRTDR, out var overrideValue))
			baseValue = overrideValue;

		var value = baseValue;

		var byBuffs = 0f;
		byBuffs += monster.Properties.GetFloat(PropertyName.CRTDR_BM, 0);

		var byRateBuffs = 0f;
		byRateBuffs += monster.Properties.GetFloat(PropertyName.CRTDR_RATE_BM);
		byRateBuffs = value * byRateBuffs;

		value = value + byBuffs + byRateBuffs;

		var decRatio = monster.Properties.GetFloat(PropertyName.CRTDR_RATE_MUL_BM, 1);

		if (decRatio < 0.5f)
			decRatio = 0.5f;

		value *= decRatio;

		return (int)value;
	}

	/// <summary>
	/// Returns the monster's Critical Attack.
	/// </summary>
	/// <param name="monster"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_MON_CRTATK(Mob monster)
	{
		var baseValue = monster.Data.CritAttack;
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.CRTATK, out var overrideValue))
			baseValue = overrideValue;

		var byBuffs = monster.Properties.GetFloat(PropertyName.CRTATK_BM, 0);

		var value = baseValue + byBuffs;

		return (int)value;
	}

	/// <summary>
	/// Returns the monster's block rate.
	/// </summary>
	/// <param name="monster"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_MON_BLK(Mob monster)
	{
		var properties = monster.Properties;

		var baseValue = monster.Data.BlockRate;
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.BLK, out var overrideValue))
			baseValue = overrideValue;

		var byBuffs = properties.GetFloat(PropertyName.BLK_BM);

		var value = baseValue + byBuffs;

		return (int)value;
	}

	/// <summary>
	/// Returns the monster's block break (penetration).
	/// </summary>
	/// <param name="monster"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_MON_BLK_BREAK(Mob monster)
	{
		var properties = monster.Properties;

		var baseValue = monster.Data.BlockBreakRate;
		if (monster.Properties.Overrides.TryGetFloat(PropertyName.BLK_BREAK, out var overrideValue))
			baseValue = overrideValue;

		var byBuffs = properties.GetFloat(PropertyName.BLK_BREAK_BM);

		var value = baseValue + byBuffs;

		return (int)value;
	}
}
