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
					modifier.BonusCritChance += 20;

					var isPhysicalOrMagic = attackerSkill.Data.HitType == SkillHitType.Melee || attackerSkill.Data.HitType == SkillHitType.Magic;
					if (isPhysicalOrMagic)
						modifier.DamageMultiplier += 0.15f;
				}
			}
		}
	}
}
