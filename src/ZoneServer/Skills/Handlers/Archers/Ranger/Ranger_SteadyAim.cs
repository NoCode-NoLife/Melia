using Melia.Shared.Game.Const;
using Melia.Zone.Scripting.ScriptableEvents;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;

namespace Melia.Zone.Skills.Handlers.Archers.Ranger
{
	/// <summary>
	/// Handler for the Ranger skill Full Throttle.
	/// </summary>
	/// <remarks>
	/// This skill repurposes the skill id of an earlier skill
	/// called Steady Aim, though the effect is completely different.
	/// </remarks>
	[SkillHandler(SkillId.Ranger_SteadyAim)]
	public class Ranger_SteadyAim : ISkillHandler
	{
		/// <summary>
		/// Applies the skill's effect during combat calculations.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="attackerSkill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		[CombatCalcModifier(CombatCalcPhase.BeforeCalc, SkillId.Ranger_SteadyAim)]
		public void OnCombatBeforeCalc(ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			// Ranger47 completely changes the bonus
			if (!attacker.IsAbilityActive(AbilityId.Ranger47))
				return;

			if (!attacker.TryGetSkill(SkillId.Ranger_SteadyAim, out var skill))
				return;

			var inventory = attacker.Components.Get<InventoryComponent>();
			var weapon = inventory?.GetItem(EquipSlot.RightHand);

			if (weapon == null)
				return;

			var multiplierBonus = 0.18f + skill.Level * 0.03f + 0.65f;

			switch (weapon.Data.EquipType1)
			{
				case EquipType.THBow: modifier.HitRateMultiplier += multiplierBonus; break;
				case EquipType.Bow: modifier.BlockPenetrationMultiplier += multiplierBonus; break;
			}
		}

		/// <summary>
		/// Applies the skill's effect during combat calculations.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="attackerSkill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		[CombatCalcModifier(CombatCalcPhase.AfterBonuses, SkillId.Ranger_SteadyAim)]
		public void OnCombatAfterBonuses(ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			// Ranger47 completely changes the bonus
			if (attacker.IsAbilityActive(AbilityId.Ranger47))
				return;

			if (!attacker.TryGetSkill(SkillId.Ranger_SteadyAim, out var skill))
				return;

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
