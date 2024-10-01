using Melia.Shared.Game.Const;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Skills.Handlers.Archers.Ranger
{
	/// <summary>
	/// Handler for the Ranger skill Full Throttle
	/// </summary>
	/// <remarks>
	/// This skill repurposes the skill id of an earlier skill
	/// called Steady Aim, though the effect is completely different.
	/// </remarks>
	[SkillHandler(SkillId.Ranger_SteadyAim)]
	public class Ranger_SteadyAim : ISkillHandler, ISkillCombatAttackBeforeCalcHandler, ISkillCombatAttackAfterBonusesHandler
	{
		/// <summary>
		/// Applies the skill's effect during combat calculations.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="attackerSkill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnAttackBeforeCalc(Skill skill, ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			// Ranger47 completely changes the bonus
			if (attacker.IsAbilityActive(AbilityId.Ranger47) && attacker is Character character)
			{
				var weapon = character.Inventory.GetItem(EquipSlot.RightHand);
				var multiplierBonus = 0.18f + skill.Level * 0.03f + 0.65f;
				if (weapon != null && (weapon.Data.EquipType1 == EquipType.THBow))
				{
					modifier.HitRateMultiplier += multiplierBonus;
				}
				else if (weapon != null && (weapon.Data.EquipType1 == EquipType.Bow))
				{
					modifier.BlockPenetrationMultiplier += multiplierBonus;
				}
			}
		}


		/// <summary>
		/// Applies the skill's effect during combat calculations.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="attackerSkill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnAttackAfterBonuses(Skill skill, ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			// Ranger47 completely changes the bonus
			if (!attacker.IsAbilityActive(AbilityId.Ranger47)) 
			{
				var isCrit = skillHitResult.Result == HitResultType.Crit;
				var isRangerAttackSkill = attackerSkill.Id >= SkillId.Ranger_Barrage && attackerSkill.Id <= SkillId.Ranger_BlazingArrow;

				if (isCrit && isRangerAttackSkill)
				{
					var multiplierBonus = 0.18f + skill.Level * 0.03f;
					modifier.FinalDamageMultiplier += multiplierBonus;
				}
			}
		}
	}
}
