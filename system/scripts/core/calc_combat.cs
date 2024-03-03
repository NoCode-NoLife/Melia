//--- Melia Script ----------------------------------------------------------
// Combat Calculation Script
//--- Description -----------------------------------------------------------
// Functions that calculate combat-related values, such as damage.
//---------------------------------------------------------------------------

using System;
using Melia.Shared.Data.Database;
using Melia.Shared.Tos.Const;
using Melia.Zone;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Items;
using Yggdrasil.Extensions;
using Yggdrasil.Util;

public class CombatCalculationsScript : GeneralScript
{
	/// <summary>
	/// Returns a random attack value between the min and max values
	/// for the type that matches the given skill (PATK or MATK).
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_GetRandomAtk(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillHitResult skillHitResult)
	{
		var rnd = RandomProvider.Get();

		float min, max;

		if (skill.Data.ClassType <= SkillClassType.Missile)
		{
			min = attacker.Properties.GetFloat(PropertyName.MINPATK);
			max = attacker.Properties.GetFloat(PropertyName.MAXPATK);
		}
		else
		{
			min = attacker.Properties.GetFloat(PropertyName.MINMATK);
			max = attacker.Properties.GetFloat(PropertyName.MAXMATK);
		}

		return rnd.Between(min, max);
	}

	/// <summary>
	/// Calculates the damage for the given skill if used by the attacker
	/// on the target, factoring in attack and defense properties.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_CalculateDamage(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillHitResult skillHitResult)
	{
		var SCR_GetRandomAtk = ScriptableFunctions.Combat.Get("SCR_GetRandomAtk");
		var SCR_GetDodgeChance = ScriptableFunctions.Combat.Get("SCR_GetDodgeChance");
		var SCR_HitCountMultiplier = ScriptableFunctions.Combat.Get("SCR_HitCountMultiplier");
		var SCR_SizeTypeBonus = ScriptableFunctions.Combat.Get("SCR_SizeTypeBonus");
		var SCR_AttributeMultiplier = ScriptableFunctions.Combat.Get("SCR_AttributeMultiplier");
		var SCR_AttackTypeMultiplier = ScriptableFunctions.Combat.Get("SCR_AttackTypeMultiplier");
		var SCR_RaceMultiplier = ScriptableFunctions.Combat.Get("SCR_RaceMultiplier");

		var rnd = RandomProvider.Get();

		var dodgeChance = SCR_GetDodgeChance(attacker, target, skill, skillHitResult);
		if (rnd.Next(100) < dodgeChance)
		{
			skillHitResult.Result = HitResultType.Dodge;
			return 0;
		}

		var damage = SCR_GetRandomAtk(attacker, target, skill, skillHitResult);

		var skillFactor = skill.Properties.GetFloat(PropertyName.SkillFactor);
		var skillAtkAdd = skill.Properties.GetFloat(PropertyName.SkillAtkAdd);
		damage *= skillFactor / 100f;
		damage += skillAtkAdd;

		var crtHr = attacker.Properties.GetFloat(PropertyName.CRTHR);
		if (rnd.Next(1000) < crtHr)
		{
			var crtAtk = attacker.Properties.GetFloat(PropertyName.CRTATK);
			damage += crtAtk;

			skillHitResult.Result = HitResultType.Crit;
		}

		var defPropertyName = skill.Data.ClassType != SkillClassType.Magic ? PropertyName.DEF : PropertyName.MDEF;
		var def = target.Properties.GetFloat(defPropertyName);
		damage = Math.Max(1, damage - def);

		// Check damage (de)buffs
		// I'm not aware of a general purpose buff or debuff property for
		// modifying damage that we could utilize to handle buffs like
		// ReflectShield_Buff, so we'll have to check for it explicitly.
		// Though this is neither elegant nor efficient, and we won't be
		// able to easily customize it either. It should probably be a
		// scriptable function in itself... TODO.
		if (target.Components.Get<BuffComponent>().TryGet(BuffId.ReflectShield_Buff, out var buff))
		{
			var skillLevel = buff.NumArg1;
			var byBuffRate = (skillLevel * 3 / 100f);

			damage = Math.Max(1, damage - damage * byBuffRate);

			var maxSp = target.Properties.GetFloat(PropertyName.MSP);
			var spRate = 0.7f / 100f;
			target.TrySpendSp(maxSp * spRate);
		}

		var sizeBonusDamage = SCR_SizeTypeBonus(attacker, target, skill, skillHitResult);
		if (sizeBonusDamage != 0)
		{
			damage += sizeBonusDamage;
		}

		var attrMultiplier = SCR_AttributeMultiplier(attacker, target, skill, skillHitResult);
		if (attrMultiplier != 1)
		{
			damage *= attrMultiplier;
		}

		var atkTypeMultiplier = SCR_AttackTypeMultiplier(attacker, target, skill, skillHitResult);
		if (atkTypeMultiplier != 1)
		{
			damage *= atkTypeMultiplier;
		}

		var raceMultiplier = SCR_RaceMultiplier(attacker, target, skill, skillHitResult);
		if (raceMultiplier != 1)
		{
			damage *= raceMultiplier;
		}

		var hitCountMultiplier = SCR_HitCountMultiplier(attacker, target, skill, skillHitResult);
		if (hitCountMultiplier != 1)
		{
			damage *= hitCountMultiplier;
			skillHitResult.HitCount = (int)Math.Round(skillHitResult.HitCount * hitCountMultiplier);
		}

		return (int)damage;
	}

	/// <summary>
	/// Returns a multiplier for the hit count based on the skill used
	/// and the entity's states.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_HitCountMultiplier(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillHitResult skillHitResult)
	{
		// TODO: Should this perhaps rather happen in the skill handlers?

		var rnd = RandomProvider.Get();

		if ((skill.Id == SkillId.Common_DaggerAries || skill.Id == SkillId.Pistol_Attack) && attacker.Components.Get<BuffComponent>().Has(BuffId.DoubleAttack_Buff))
		{
			var rate = 40;

			if (rnd.Next(100) < rate)
				return 2;
		}
		else if (skill.Id == SkillId.Wizard_EarthQuake && target.Components.Get<BuffComponent>().Has(BuffId.Lethargy_Debuff))
		{
			return 2;
		}
		else if (skill.Id == SkillId.Wizard_EnergyBolt || skill.Id == SkillId.Archer_TwinArrows)
		{
			return 2;
		}

		return 1;
	}

	/// <summary>
	/// Returns a damage multiplier for the skill used on the target.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_SizeTypeBonus(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillHitResult skillHitResult)
	{
		if (skill.Data.ClassType == SkillClassType.Magic)
			return 0;

		if (!(attacker is Character character))
			return 0;

		var weapon = character.Inventory.GetEquip(EquipSlot.RightHand);

		var targetSize = SizeType.M;
		if (target is Mob mob)
			targetSize = mob.Data.Size;

		if (targetSize == SizeType.S) return weapon.Data.SmallSizeBonus;
		if (targetSize == SizeType.M) return weapon.Data.MediumSizeBonus;
		if (targetSize == SizeType.L) return weapon.Data.LargeSizeBonus;

		return 0;
	}

	/// <summary>
	/// Returns a damage multiplier for the skill used on the target.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_AttributeMultiplier(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillHitResult skillHitResult)
	{
		if (skill.Data.ClassType != SkillClassType.Magic)
			return 1;

		var attackerAttr = skill.Data.Attribute;
		var targetAttr = target.Attribute;

		if (!Feature.IsEnabled("AttributeBonusRevamp"))
		{
			if (attackerAttr == SkillAttribute.Fire)
			{
				if (targetAttr == AttributeType.Fire) return 0.75f;
				if (targetAttr == AttributeType.Earth) return 1.5f;
			}
			else if (attackerAttr == SkillAttribute.Ice)
			{
				if (targetAttr == AttributeType.Fire) return 1.5f;
				if (targetAttr == AttributeType.Ice) return 0.75f;
			}
			else if (attackerAttr == SkillAttribute.Lightning)
			{
				if (targetAttr == AttributeType.Ice) return 1.5f;
				if (targetAttr == AttributeType.Lightning) return 0.75f;
			}
			else if (attackerAttr == SkillAttribute.Earth)
			{
				if (targetAttr == AttributeType.Lightning) return 1.5f;
				if (targetAttr == AttributeType.Earth) return 0.75f;
			}
			else if (attackerAttr == SkillAttribute.Poison)
			{
				if (targetAttr == AttributeType.Fire) return 1.125f;
				if (targetAttr == AttributeType.Ice) return 1.125f;
				if (targetAttr == AttributeType.Lightning) return 1.125f;
				if (targetAttr == AttributeType.Earth) return 1.125f;
				if (targetAttr == AttributeType.Poison) return 0.75f;
			}
			else if (attackerAttr == SkillAttribute.Holy)
			{
				if (targetAttr == AttributeType.Holy) return 0.75f;
				if (targetAttr == AttributeType.Dark) return 1.5f;
			}
			else if (attackerAttr == SkillAttribute.Dark)
			{
				if (targetAttr == AttributeType.Holy) return 1.5f;
				if (targetAttr == AttributeType.Dark) return 0.75f;
			}
			else if (attackerAttr == SkillAttribute.Soul)
			{
				if (targetAttr == AttributeType.Holy) return 1.25f;
				if (targetAttr == AttributeType.Dark) return 1.25f;
				if (targetAttr == AttributeType.Soul) return 1.5f;
			}
		}
		else
		{
			if (attackerAttr == SkillAttribute.Fire)
			{
				if (targetAttr == AttributeType.Fire) return 0.5f;
				if (targetAttr == AttributeType.Earth) return 1.5f;
			}
			else if (attackerAttr == SkillAttribute.Ice)
			{
				if (targetAttr == AttributeType.Fire) return 1.5f;
				if (targetAttr == AttributeType.Ice) return 0.5f;
			}
			else if (attackerAttr == SkillAttribute.Lightning)
			{
				if (targetAttr == AttributeType.Ice) return 2f;
				if (targetAttr == AttributeType.Lightning) return 0.5f;
				if (targetAttr == AttributeType.Earth) return 0.5f;
			}
			else if (attackerAttr == SkillAttribute.Earth)
			{
				if (targetAttr == AttributeType.Lightning) return 1.5f;
				if (targetAttr == AttributeType.Earth) return 0.5f;
			}
			else if (attackerAttr == SkillAttribute.Poison)
			{
				if (targetAttr == AttributeType.Earth) return 1.5f;
				if (targetAttr == AttributeType.Poison) return 0.5f;
			}
			else if (attackerAttr == SkillAttribute.Holy)
			{
				if (targetAttr == AttributeType.Dark) return 2f;
			}
			else if (attackerAttr == SkillAttribute.Dark)
			{
				if (targetAttr == AttributeType.Holy) return 2f;
			}
		}

		return 1;
	}

	/// <summary>
	/// Returns a damage multiplier based on the skill's attack type
	/// and the target's armor.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_AttackTypeMultiplier(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillHitResult skillHitResult)
	{
		var attackType = skill.Data.AttackType;
		var targetArmor = target.ArmorMaterial;

		if (Feature.IsEnabled("AttackTypeBonusRevamp2"))
		{
			if (attackType == SkillAttackType.Slash)
			{
				if (targetArmor == ArmorMaterialType.Cloth) return 1.05f;
			}
			else if (attackType == SkillAttackType.Aries)
			{
				if (targetArmor == ArmorMaterialType.Leather) return 1.05f;
			}
			else if (attackType == SkillAttackType.Strike)
			{
				if (targetArmor == ArmorMaterialType.Iron) return 1.05f;
			}
			else if (attackType == SkillAttackType.Arrow)
			{
				if (targetArmor == ArmorMaterialType.Cloth) return 1.05f;
			}
			else if (attackType == SkillAttackType.Gun)
			{
				if (targetArmor == ArmorMaterialType.Leather) return 1.05f;
			}
			else if (attackType == SkillAttackType.Cannon)
			{
				if (targetArmor == ArmorMaterialType.Iron) return 1.05f;
			}
		}
		else if (Feature.IsEnabled("AttackTypeBonusRevamp1"))
		{
			if (attackType == SkillAttackType.Slash)
			{
				if (targetArmor == ArmorMaterialType.Cloth) return 1.5f;
				if (targetArmor == ArmorMaterialType.Iron) return 0.5f;
				if (targetArmor == ArmorMaterialType.Ghost) return 0.5f;
			}
			else if (attackType == SkillAttackType.Aries)
			{
				if (targetArmor == ArmorMaterialType.Cloth) return 0.5f;
				if (targetArmor == ArmorMaterialType.Leather) return 1.5f;
				if (targetArmor == ArmorMaterialType.Ghost) return 0.5f;
			}
			else if (attackType == SkillAttackType.Strike)
			{
				if (targetArmor == ArmorMaterialType.Leather) return 0.5f;
				if (targetArmor == ArmorMaterialType.Iron) return 1.5f;
				if (targetArmor == ArmorMaterialType.Ghost) return 0.5f;
			}
			else if (attackType == SkillAttackType.Magic)
			{
				if (targetArmor == ArmorMaterialType.Ghost) return 1.5f;
			}
		}
		else
		{
			if (attackType == SkillAttackType.Slash)
			{
				if (targetArmor == ArmorMaterialType.Cloth) return 1.25f;
			}
			else if (attackType == SkillAttackType.Aries)
			{
				if (targetArmor == ArmorMaterialType.Leather) return 1.25f;
			}
			else if (attackType == SkillAttackType.Strike)
			{
				if (targetArmor == ArmorMaterialType.Iron) return 1.25f;
			}
			else if (attackType == SkillAttackType.Magic)
			{
				if (targetArmor == ArmorMaterialType.Ghost) return 1.25f;
			}
			else if (attackType == SkillAttackType.Arrow)
			{
				if (targetArmor == ArmorMaterialType.Cloth) return 1.125f;
				if (targetArmor == ArmorMaterialType.Leather) return 1.125f;
			}
			else if (attackType == SkillAttackType.Gun)
			{
				if (targetArmor == ArmorMaterialType.Cloth) return 1.125f;
				if (targetArmor == ArmorMaterialType.Leather) return 1.125f;
			}
			else if (attackType == SkillAttackType.Cannon)
			{
				if (targetArmor == ArmorMaterialType.Iron) return 1.25f;
			}
		}

		return 1;
	}

	/// <summary>
	/// Returns a damage multiplier based on the given entity's races.
	/// </summary>
	/// <remarks>
	/// The default implementation of this function currently always
	/// returns 1.
	/// </remarks>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_RaceMultiplier(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillHitResult skillHitResult)
	{
		if (skill.Data.ClassType != SkillClassType.Magic)
			return 1;

		var attackerRace = attacker.Race;
		var targetRace = target.Race;

		// ...

		return 1;
	}

	/// <summary>
	/// Determines the result of the skill being used on the target,
	/// returning the damage that should be dealt and information
	/// about the hit, such as whether it was a crit.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public SkillHitResult SCR_SkillHit(ICombatEntity attacker, ICombatEntity target, Skill skill)
	{
		var SCR_CalculateDamage = ScriptableFunctions.Combat.Get("SCR_CalculateDamage");

		var result = new SkillHitResult();
		result.Damage = SCR_CalculateDamage(attacker, target, skill, result);

		// TODO: Find a better location to handle disabling buffs on attack?
		var buffComponent = attacker.Components.Get<BuffComponent>();
		if (buffComponent.Has(BuffId.Cloaking_Buff))
			buffComponent.Remove(BuffId.Cloaking_Buff);

		return result;
	}

	/// <summary>
	/// Returns the chance for the target to dodge a hit from the attacker.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_GetDodgeChance(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillHitResult skillHitResult)
	{
		if (skill.Data.AttackType == SkillAttackType.Magic)
			return 0;

		var dr = target.Properties.GetFloat(PropertyName.DR);
		var hr = attacker.Properties.GetFloat(PropertyName.HR);

		// Preliminary formula based on player tests, such as the following.
		// 
		// https://forum.treeofsavior.com/t/evasion-chance-in-tos/404534/11
		// https://github.com/vyne1/tos-mechanics/blob/master/ToS%20Mechanics.pdf
		// 
		// The first formula seemed to work on the surface, but gave rather
		// strange results the bigger the DR/HR values got. The second one
		// looked more promising, but seemed rather arbitrary. Our current
		// approach is now a combination of the two.

		var dodgeChance = Math2.Clamp(0, 80, Math.Pow(Math.Max(0, dr - hr), 0.65f));

		return (float)dodgeChance;
	}
}
