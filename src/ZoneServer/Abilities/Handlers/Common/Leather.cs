using Melia.Shared.Game.Const;
using Melia.Zone.Scripting.ScriptableEvents;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;

namespace Melia.Zone.Abilities.Handlers.Common
{
	/// <summary>
	/// Handler for the common ability "Leather Mastery: Dexterity"
	/// (Leather), which increases the crit chance and damage of certain
	/// attacks.
	/// </summary>
	[AbilityHandler(AbilityId.Leather)]
	public class Leather : IAbilityHandler
	{
		/// <summary>
		/// Called during combat calculations to apply the knock down
		/// effect.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="attackerSkill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		[CombatCalcModifier(CombatCalcPhase.BeforeCalc, AbilityId.Leather)]
		public void OnBeforeCalc(ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (attacker.IsAbilityActive(AbilityId.Leather) && attacker.Components.TryGet<InventoryComponent>(out var inventory))
			{
				var count = inventory.CountEquipMaterial(ArmorMaterialType.Leather);
				if (count >= 4)
				{
					// The ability description mentions a 20% crit chance
					// increase and a 10% increase of the max crit chance.
					// It's currently unknown what exactly this means, and
					// a 20% increase would be significant, so we'll assume
					// for now that it's referring to the CRTHR and CRTDR.
					// Changing the HR effectively increases the crit chance
					// and a lower DR increases the max chance you can reach.
					modifier.CritHitRateMultiplier += 0.20f;
					modifier.CritDodgeRateMultiplier -= 0.10f;

					var isPhysicalOrMagic = attackerSkill.Data.HitType == SkillHitType.Melee || attackerSkill.Data.HitType == SkillHitType.Magic;
					if (isPhysicalOrMagic)
						modifier.DamageMultiplier += 0.15f;
				}
			}
		}
	}
}
