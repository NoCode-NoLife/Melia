//--- Melia Script ----------------------------------------------------------
// Companion Calculation Script
//--- Description -----------------------------------------------------------
// Functions that calculate companion-related values, such as properties.
//---------------------------------------------------------------------------

using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Maps;

public class CompanionCalculationsScript : GeneralScript
{
	private const float PET_STAT_BY_OWNER_RATE = 0.5f;

	public float PET_STAT_BY_OWNER(Companion companion, string statName)
	{
		var value = 0f;
		var owner = companion.Owner;

		if (owner != null)
			value = owner.Properties.GetFloat(statName) * PET_STAT_BY_OWNER_RATE;

		return (float)Math.Floor(value);
	}

	/// <summary>
	/// Returns companion's total strength.
	/// </summary>
	/// <param name="companion"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_Companion_STR(Companion companion)
	{
		var baseValue = companion.Data.STR;
		var ownerValue = PET_STAT_BY_OWNER(companion, PropertyName.STR);

		var result = baseValue + ownerValue;

		return (float)Math.Floor(result);
	}

	/// <summary>
	/// Returns companion's total dexterity.
	/// </summary>
	/// <param name="companion"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_Companion_DEX(Companion companion)
	{
		var ownerProperties = companion.Owner.Properties;

		var baseValue = companion.Data.DEX;
		var ownerValue = ownerProperties.GetFloat(PropertyName.DEX) * PET_STAT_BY_OWNER_RATE;

		var result = baseValue + ownerValue;

		return (float)Math.Floor(result);
	}

	/// <summary>
	/// Returns companion's total constitution.
	/// </summary>
	/// <param name="companion"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_Companion_CON(Companion companion)
	{
		var ownerProperties = companion.Owner.Properties;

		var baseValue = companion.Data.CON;
		var ownerValue = ownerProperties.GetFloat(PropertyName.CON) * PET_STAT_BY_OWNER_RATE;

		var result = baseValue + ownerValue;

		return (float)Math.Floor(result);
	}

	/// <summary>
	/// Returns companion's total intelligence.
	/// </summary>
	/// <param name="companion"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_Companion_INT(Companion companion)
	{
		var ownerProperties = companion.Owner.Properties;

		var baseValue = companion.Data.INT;
		var ownerValue = ownerProperties.GetFloat(PropertyName.INT) * PET_STAT_BY_OWNER_RATE;

		var result = baseValue + ownerValue;

		return (float)Math.Floor(result);
	}

	/// <summary>
	/// Returns companion's total mana.
	/// </summary>
	/// <param name="companion"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_Companion_MNA(Companion companion)
	{
		var ownerProperties = companion.Owner.Properties;

		var baseValue = companion.Data.MNA;
		var ownerValue = ownerProperties.GetFloat(PropertyName.MNA) * PET_STAT_BY_OWNER_RATE;

		var result = baseValue + ownerValue;

		return (float)Math.Floor(result);
	}

	/// <summary>
	/// Returns companion's calculated defense.
	/// </summary>
	/// <param name="companion"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_Companion_DEF(Companion companion)
	{
		var properties = companion.Properties;
		var byLv = properties.GetFloat(PropertyName.Lv);
		var addLv = properties.GetFloat(PropertyName.Level);
		var byOwner = PET_STAT_BY_OWNER(companion, PropertyName.DEF);
		var value = (byLv + addLv) / 2f + byOwner + properties.GetFloat(PropertyName.Stat_DEF);

		var owner = companion.Owner;
		if (owner != null)
		{
			if (owner.IsAbilityActive(AbilityId.CompMastery4))
				value *= 1.25f;
			if (owner.IsAbilityActive(AbilityId.CompMastery5))
				value *= 0.75f;
		}

		return (float)Math.Floor(Math.Max(1, value));
	}

	/// <summary>
	/// Returns companion's calculated magic defense.
	/// </summary>
	/// <param name="companion"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_Companion_MDEF(Companion companion)
	{
		var properties = companion.Properties;
		var byLv = properties.GetFloat(PropertyName.Lv);
		var addLv = properties.GetFloat(PropertyName.Level);
		var byOwner = PET_STAT_BY_OWNER(companion, PropertyName.MDEF);
		var value = (byLv + addLv) / 2f + byOwner + properties.GetFloat(PropertyName.Stat_MDEF);

		var owner = companion.Owner;
		if (owner != null)
		{
			if (owner.IsAbilityActive(AbilityId.CompMastery4))
				value *= 1.25f;
			if (owner.IsAbilityActive(AbilityId.CompMastery5))
				value *= 0.75f;
		}

		return (float)Math.Floor(Math.Max(1, value));
	}

	/// <summary>
	/// Returns companion's calculated dodge rate.
	/// </summary>
	/// <param name="companion"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_Companion_DR(Companion companion)
	{
		var properties = companion.Properties;
		var byLv = properties.GetFloat(PropertyName.Lv);
		var addLv = properties.GetFloat(PropertyName.Level);
		var byOwner = PET_STAT_BY_OWNER(companion, PropertyName.DR);
		var value = byLv + addLv + byOwner + properties.GetFloat("DEX") + properties.GetFloat(PropertyName.Stat_DR);

		return (float)Math.Floor(value);
	}

	/// <summary>
	/// Returns companion's calculated hit rate.
	/// </summary>
	/// <param name="companion"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_Companion_HR(Companion companion)
	{
		var properties = companion.Properties;
		var byLv = properties.GetFloat(PropertyName.Lv);
		var addLv = properties.GetFloat(PropertyName.Level);
		var byOwner = PET_STAT_BY_OWNER(companion, PropertyName.HR);
		var value = byLv + addLv + byOwner + properties.GetFloat("DEX") + properties.GetFloat(PropertyName.Stat_DR) + properties.GetFloat(PropertyName.Stat_HR_BM);

		return (float)Math.Floor(value);
	}

	/// <summary>
	/// Returns the companion's maximum HP.
	/// </summary>
	/// <param name="companion"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_Companion_MHP(Companion companion)
	{
		var properties = companion.Properties;

		var level = properties.GetFloat(PropertyName.Lv, 1);
		var standardMHP = level * 10;
		var stat = properties.GetFloat(PropertyName.CON, 1);

		var byLevel = Math.Floor((standardMHP / 4) * level);
		var byStat = Math.Floor((byLevel * (stat * 0.0015)) + (byLevel * (Math.Floor(stat / 10) * 0.005)) + (27 * properties.GetFloat(PropertyName.Stat_MHP)));

		var value = byLevel + byStat;

		var owner = companion.Owner;
		if (owner != null)
		{
			if (owner.IsAbilityActive(AbilityId.CompMastery4))
				value *= 1.25f;
			if (owner.IsAbilityActive(AbilityId.CompMastery5))
				value *= 0.75f;
		}
		if (companion.IsBuffActive(BuffId.BeastMaster_Buff))
			value *= 1.25f;

		return (float)Math.Floor(Math.Max(1, value));
	}

	/// <summary>
	/// Returns the companion's attack.
	/// </summary>
	/// <param name="companion"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_Companion_ATK(Companion companion)
	{
		var properties = companion.Properties;

		var addLv = companion.Data.Level;
		var atk = properties.GetFloat(PropertyName.Lv) + companion.Data.STR + addLv + properties.GetFloat(PropertyName.Stat_ATK) + properties.GetFloat(PropertyName.Stat_ATK_BM);

		var average = PET_STAT_BY_OWNER(companion, PropertyName.MINPATK) + PET_STAT_BY_OWNER(companion, PropertyName.MAXPATK);
		if (average != 0)
			average /= 2;

		var value = atk + average;

		var owner = companion.Owner;
		if (owner != null)
		{
			if (owner.IsAbilityActive(AbilityId.CompMastery4))
				value *= 1.25f;
			if (owner.IsAbilityActive(AbilityId.CompMastery5))
				value *= 0.75f;
		}

		return (float)Math.Floor(Math.Max(1, value));
	}

	/// <summary>
	/// Returns the companion's minimum physical attack.
	/// </summary>
	/// <param name="companion"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_Companion_MINPATK(Companion companion)
	{
		var properties = companion.Properties;
		var byStat = companion.Data.PhysicalAttackMin;
		var byBuff = properties.GetFloat(PropertyName.PATK_BM);
		var value = byStat + byBuff;

		return (float)Math.Floor(value);
	}

	/// <summary>
	/// Returns the companion's maximum physical attack.
	/// </summary>
	/// <param name="companion"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_Companion_MAXPATK(Companion companion)
	{
		var properties = companion.Properties;
		var byStat = companion.Data.PhysicalAttackMax;
		var byBuff = properties.GetFloat(PropertyName.PATK_BM);
		var value = byStat + byBuff;

		return (float)Math.Floor(value);
	}

	/// <summary>
	/// Returns the companion's minimum magic attack.
	/// </summary>
	/// <param name="companion"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_Companion_MINMATK(Companion companion)
	{
		var properties = companion.Properties;
		var byStat = companion.Data.MagicalAttackMin;
		var byOwner = PET_STAT_BY_OWNER(companion, PropertyName.MINMATK);
		var byBuff = properties.GetFloat(PropertyName.PATK_BM);
		var value = byStat + byOwner + byBuff;

		var owner = companion.Owner;
		if (owner != null)
		{
			if (owner.IsAbilityActive(AbilityId.CompMastery4))
				value *= 1.25f;
			if (owner.IsAbilityActive(AbilityId.CompMastery5))
				value *= 0.75f;
		}

		return (float)Math.Floor(Math.Max(1, value));
	}

	/// <summary>
	/// Returns the companion's maximum magical attack.
	/// </summary>
	/// <param name="companion"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_Companion_MAXMATK(Companion companion)
	{
		var properties = companion.Properties;
		var byStat = companion.Data.MagicalAttackMax;
		var byOwner = PET_STAT_BY_OWNER(companion, PropertyName.MAXMATK);
		var byBuff = properties.GetFloat(PropertyName.PATK_BM);
		var value = byStat + byOwner + byBuff;

		var owner = companion.Owner;
		if (owner != null)
		{
			if (owner.IsAbilityActive(AbilityId.CompMastery4))
				value *= 1.25f;
			if (owner.IsAbilityActive(AbilityId.CompMastery5))
				value *= 0.75f;
		}

		return (float)Math.Floor(Math.Max(1, value));
	}

	/// <summary>
	/// Returns companion's mount defense.
	/// </summary>
	/// <param name="companion"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_Companion_MOUNTDEF(Companion companion)
	{
		return (float)Math.Floor(companion.Properties.CFloat("DEF") * 0.1);
	}

	/// <summary>
	/// Returns companion's mount dodge rate.
	/// </summary>
	/// <param name="companion"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_Companion_MOUNTDR(Companion companion)
	{
		return (float)Math.Floor(companion.Properties.CFloat("DR") * 0.08);
	}

	/// <summary>
	/// Returns companion's mount max hp.
	/// </summary>
	/// <param name="companion"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_Companion_MOUNTMHP(Companion companion)
	{
		return (float)Math.Floor(companion.Properties.CFloat("MHP") * 0.25);
	}

	/// <summary>
	/// Returns companion's total mana.
	/// </summary>
	/// <param name="companion"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_Companion_SDR(Companion companion)
	{
		return 1f;
	}
}
