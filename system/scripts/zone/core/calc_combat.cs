//--- Melia Script ----------------------------------------------------------
// Combat Calculation Script
//--- Description -----------------------------------------------------------
// Functions that calculate combat-related values, such as damage.
//---------------------------------------------------------------------------

using System;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Zone;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
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
	/// <param name="modifier"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_GetRandomAtk(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
	{
		var rnd = RandomProvider.Get();

		float min, max;

		if (skill.Data.ClassType <= SkillClassType.Missile)
		{
			min = attacker.Properties.GetFloat(PropertyName.MINPATK) + modifier.BonusPAtk;
			max = attacker.Properties.GetFloat(PropertyName.MAXPATK) + modifier.BonusPAtk;
		}
		else
		{
			min = attacker.Properties.GetFloat(PropertyName.MINMATK) + modifier.BonusMAtk;
			max = attacker.Properties.GetFloat(PropertyName.MAXMATK) + modifier.BonusMAtk;
		}

		if (min > max)
			return max;

		return rnd.Between(min, max);
	}

	/// <summary>
	/// Calculates the damage for the given skill if used by the attacker
	/// on the target, factoring in attack and defense properties.
	/// </summary>
	/// <param name="attacker">The combatant attacking the target.</param>
	/// <param name="target">The combatant that's being attacked.</param>
	/// <param name="skill">The skill used for this attack hit.</param>
	/// <param name="skillHitResult">
	/// The result of the hit, which is modified directly to indicate
	/// how the attack turned out. After the call it will reflect the
	/// damage dealt, whether it was a crit, or the attacks was perhaps
	/// dodged, etc. None of this is automatically applied to the target.
	/// </param>
	/// <returns>Returns the resulting damage rounded down.</returns>
	[ScriptableFunction]
	public float SCR_CalculateDamage(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
	{
		var SCR_GetRandomAtk = ScriptableFunctions.Combat.Get("SCR_GetRandomAtk");
		var SCR_GetDodgeChance = ScriptableFunctions.Combat.Get("SCR_GetDodgeChance");
		var SCR_GetBlockChance = ScriptableFunctions.Combat.Get("SCR_GetBlockChance");
		var SCR_GetCritChance = ScriptableFunctions.Combat.Get("SCR_GetCritChance");
		var SCR_HitCountMultiplier = ScriptableFunctions.Combat.Get("SCR_HitCountMultiplier");
		var SCR_SizeTypeBonus = ScriptableFunctions.Combat.Get("SCR_SizeTypeBonus");
		var SCR_AttributeMultiplier = ScriptableFunctions.Combat.Get("SCR_AttributeMultiplier");
		var SCR_AttackTypeMultiplier = ScriptableFunctions.Combat.Get("SCR_AttackTypeMultiplier");
		var SCR_RaceMultiplier = ScriptableFunctions.Combat.Get("SCR_RaceMultiplier");
		var SCR_Combat_BeforeCalc = ScriptableFunctions.Combat.Get("SCR_Combat_BeforeCalc");
		var SCR_Combat_AfterCalc = ScriptableFunctions.Combat.Get("SCR_Combat_AfterCalc");
		var SCR_Combat_BeforeBonuses = ScriptableFunctions.Combat.Get("SCR_Combat_BeforeBonuses");
		var SCR_Combat_AfterBonuses = ScriptableFunctions.Combat.Get("SCR_Combat_AfterBonuses");

		var rnd = RandomProvider.Get();

		var dodgeChance = SCR_GetDodgeChance(attacker, target, skill, modifier, skillHitResult);
		if (rnd.Next(100) < dodgeChance)
		{
			skillHitResult.Result = HitResultType.Dodge;
			return 0;
		}

		SCR_Combat_BeforeCalc(attacker, target, skill, modifier, skillHitResult);

		// Get base damage, incl. basic bonuses
		skillHitResult.Damage = SCR_GetRandomAtk(attacker, target, skill, modifier, skillHitResult);

		var skillAtkAdd = skill.Properties.GetFloat(PropertyName.SkillAtkAdd);
		skillHitResult.Damage += skillAtkAdd;

		skillHitResult.Damage += modifier.BonusDamage;
		skillHitResult.Damage *= modifier.DamageMultiplier;

		// Apply defense to the base damage. This might've been done at different
		// points in some versions of the game, but for the latest version it's
		// important to do it before the skill factors are applied, as these may
		// raise the damage to such heights that the target's defense becomes
		// meaningless.
		var defPropertyName = skill.Data.ClassType != SkillClassType.Magic ? PropertyName.DEF : PropertyName.MDEF;
		var def = target.Properties.GetFloat(defPropertyName);
		def -= Math2.Clamp(0, def, def * modifier.DefensePenetrationRate);
		skillHitResult.Damage = Math.Max(1, skillHitResult.Damage - def);

		// Apply the skill factor, raising the damage based on the skill's
		// damage multiplier
		var skillFactor = skill.Properties.GetFloat(PropertyName.SkillFactor);
		skillHitResult.Damage *= skillFactor / 100f;

		// Block needs to be calculated before criticals happen,
		// but the damage must be reduced after defense reductions and modifiers
		var blockChance = SCR_GetBlockChance(attacker, target, skill, modifier, skillHitResult);
		if (rnd.Next(100) < blockChance)
		{
			skillHitResult.Result = HitResultType.Block;

			// Nullify damage on successful classic block
			if (!Feature.IsEnabled("NonNullifyBlocks"))
				return 0;
		}

		var crtChance = SCR_GetCritChance(attacker, target, skill, modifier, skillHitResult);
		if (rnd.Next(100) < crtChance && skillHitResult.Result != HitResultType.Block)
		{
			var crtAtk = attacker.Properties.GetFloat(PropertyName.CRTATK);
			skillHitResult.Damage += crtAtk;

			skillHitResult.Result = HitResultType.Crit;
		}

		SCR_Combat_BeforeBonuses(attacker, target, skill, modifier, skillHitResult);

		var sizeBonusDamage = SCR_SizeTypeBonus(attacker, target, skill, modifier, skillHitResult);
		if (sizeBonusDamage != 0)
		{
			skillHitResult.Damage += sizeBonusDamage;
		}

		var attrMultiplier = SCR_AttributeMultiplier(attacker, target, skill, modifier, skillHitResult);
		if (attrMultiplier != 1)
		{
			skillHitResult.Damage *= attrMultiplier;
		}

		var atkTypeMultiplier = SCR_AttackTypeMultiplier(attacker, target, skill, modifier, skillHitResult);
		if (atkTypeMultiplier != 1)
		{
			skillHitResult.Damage *= atkTypeMultiplier;
		}

		var raceMultiplier = SCR_RaceMultiplier(attacker, target, skill, modifier, skillHitResult);
		if (raceMultiplier != 1)
		{
			skillHitResult.Damage *= raceMultiplier;
		}

		var hitCountMultiplier = SCR_HitCountMultiplier(attacker, target, skill, modifier, skillHitResult);
		if (hitCountMultiplier != 1)
		{
			skillHitResult.Damage *= hitCountMultiplier;
			skillHitResult.HitCount = (int)Math.Round(skillHitResult.HitCount * hitCountMultiplier);
		}

		SCR_Combat_AfterBonuses(attacker, target, skill, modifier, skillHitResult);

		// Block damage reduction
		if (skillHitResult.Result == HitResultType.Block)
		{
			var blockMultiplier = 0.50f;

			if (target.IsBuffActive(BuffId.HighGuard_Abil_Buff))
				blockMultiplier += 0.20f;

			skillHitResult.Damage -= (skillHitResult.Damage * blockMultiplier);
		}

		// Critical damage bonus
		if (skillHitResult.Result == HitResultType.Crit)
			skillHitResult.Damage *= 1.5f;

		skillHitResult.Damage *= modifier.FinalDamageMultiplier;

		SCR_Combat_AfterCalc(attacker, target, skill, modifier, skillHitResult);

		// Let monster-specific functions override the damage calculation,
		// but do it after the basic calculations have been done, so we
		// can utilize them. For example, we can double or half damage
		// that way, or let crit animations happen, even if we might
		// reduce the damage to 1.
		if (target is Mob mob && ScriptableFunctions.Combat.TryGet("SCR_CalculateDamage_Monster_" + mob.Data.ClassName, out var mobCalcFunc))
			mobCalcFunc(attacker, target, skill, modifier, skillHitResult);

		return (int)skillHitResult.Damage;
	}

	/// <summary>
	/// Returns a multiplier for the hit count based on the skill used
	/// and the entity's states.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	///	<param name="modifier"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_HitCountMultiplier(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
	{
		// We originally used this method to "hardcode" hit counts for certain
		// skills and scenarios, but the decision what hit count to use was
		// since moved to the skill handlers. We'll keep this function around
		// for the moment though, if only to allow overriding it from scripts.

		return modifier.HitCount;
	}

	/// <summary>
	/// Returns a damage multiplier for the skill used on the target.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="modifier"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_SizeTypeBonus(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
	{
		if (skill.Data.ClassType == SkillClassType.Magic)
			return 0;

		if (attacker is not Character character)
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
	public float SCR_AttributeMultiplier(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
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
	/// <param name="modifier"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_AttackTypeMultiplier(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
	{
		var attackType = skill.Data.AttackType;
		var targetArmor = target.ArmorMaterial;

		// Use the right-hand weapon's attack type if a weapon is equipped.
		// This doesn't necessarily take into account off-hand attacks,
		// but it's currently unclear if/how those would be handled.
		if (attacker.Components.TryGet<InventoryComponent>(out var inventory))
		{
			var rhItem = inventory.GetEquip(EquipSlot.RightHand);
			if (rhItem is not DummyEquipItem)
				attackType = rhItem.Data.AttackType;
		}

		// Melee phisical attacks ignored when counter-attacking (Matador).
		if (target.IsBuffActive(BuffId.Muleta_Cast_Buff) && (attackType == SkillAttackType.Slash || attackType == SkillAttackType.Strike || attackType == SkillAttackType.Melee))
		{
			// Muleta: Counterattack Master
			if ((attacker.Race == RaceType.Widling || target.IsAbilityActive(AbilityId.Matador8)) && target is Character character)
			{
				character.StopBuff(BuffId.IS_Channeling_Buff);

				// [Arts] Muleta: Faena
				// Casts Faena instead of default attack when counter-attacking
				if (character.IsAbilityActive(AbilityId.Matador26))
					Send.ZC_NORMAL.ForceClientCastSkill(character, SkillId.Matador_Muleta, SkillId.Matador_Muleta_Faena);
				else
					Send.ZC_NORMAL.ForceClientCastSkill(character, SkillId.Matador_Muleta, SkillId.Muleta_Attack);

				// Muleta: Showtime
				if (character.IsAbilityActive(AbilityId.Matador16) && character.TryGetAbility(AbilityId.Matador16, out var ability))
				{
					var reductionInSeconds = ability.Level;
					var matadorSkillTreeDataList = ZoneServer.Instance.Data.SkillTreeDb.FindSkills(JobId.Matador);

					foreach (var charSkill in character.Skills.GetList())
					{
						if (charSkill.Id == SkillId.Matador_Muleta)
							continue;

						if (matadorSkillTreeDataList.Contains(charSkill.Id) && charSkill.IsOnCooldown)
							charSkill.ReduceCooldown(TimeSpan.FromSeconds(reductionInSeconds));
					}
				}				
			}

			return 0;
		}

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
	/// <param name="modifier"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_RaceMultiplier(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
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
	/// <param name="modifier"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public SkillHitResult SCR_SkillHit(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier)
	{
		var SCR_CalculateDamage = ScriptableFunctions.Combat.Get("SCR_CalculateDamage");

		var result = new SkillHitResult();
		result.Damage = SCR_CalculateDamage(attacker, target, skill, modifier, result);

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
	/// <param name="modifier"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_GetDodgeChance(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
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

	/// <summary>
	/// Returns the chance for the target to block a hit from the attacker.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_GetBlockChance(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
	{
		if (skill.Data.AttackType == SkillAttackType.Magic)
			return 0;

		if (modifier.Unblockable)
			return 0;

		if (modifier.ForcedBlock)
			return 100;

		var block = target.Properties.GetFloat(PropertyName.BLK);
		var blockBreak = attacker.Properties.GetFloat(PropertyName.BLK_BREAK);

		if (target.Components.Get<CombatComponent>()?.IsGuarding == true)
		{
			// The block amount added while actively guarding appears to have
			// changed over time, but some sources say it was a flat 550 block
			// bonus at some point at least. Pre-ReBuild sources on the other
			// hand speak of a bonus based on the character's level.
			if (Feature.IsEnabled("FlatGuardBonus"))
				block += 550;
			else
				block += target.Level * 5.5f;
		}

		// The block chance cap appears to have been as much in flux as the bonus,
		// which makes sense if blocks were once able to nullify damage entirely.
		// As such, we're going to assume a base cap of 60% for nullifying and
		// 90% for the newer blocking type that only lowers the damage. For PvP,
		// the non-nullify cap is apparently supposed to be 30%.
		var maxChance = 60;
		if (Feature.IsEnabled("IncreasedBlockRate"))
			maxChance = 90;

		// Based on: https://treeofsavior.com/page/news/view.php?n=951​
		var blockChance = Math2.Clamp(0, maxChance, Math.Pow(Math.Max(0, Math.Max(0, block - blockBreak)), 0.7f));

		return (float)blockChance;
	}

	/// <summary>
	/// Returns the chance for the target to take a critical hit from the attacker.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_GetCritChance(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
	{
		if (skill.Data.AttackType == SkillAttackType.Magic)
			return 0;

		if (modifier.ForcedCritical)
			return 100;

		var critDodgeRate = target.Properties.GetFloat(PropertyName.CRTDR);
		var critHitRate = attacker.Properties.GetFloat(PropertyName.CRTHR);

		// Based on: https://treeofsavior.com/page/news/view.php?n=951​
		var critChance = Math.Pow(Math.Max(0, Math.Max(0, critHitRate - critDodgeRate)), 0.6f);

		critChance = Math2.Clamp(modifier.MinCritChance, 100, critChance);

		return (float)critChance;
	}
}
