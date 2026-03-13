using Melia.Shared.Game.Const;
using Melia.Zone.Scripting.ScriptableEvents;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;

namespace Melia.Zone.Abilities.Handlers.Common
{
	/// <summary>
	/// Handler for the common ability "Cloth Mastery: Magic" (Cloth),
	/// which reduces magic damage taken.
	/// </summary>
	[AbilityHandler(AbilityId.Cloth)]
	public class Cloth : IAbilityHandler
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
		[CombatCalcModifier(CombatCalcPhase.BeforeCalc, AbilityId.Cloth)]
		public void OnBeforeCalc(ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (target.IsAbilityActive(AbilityId.Cloth) && target.Components.TryGet<InventoryComponent>(out var inventory))
			{
				var count = inventory.CountEquipMaterial(ArmorMaterialType.Cloth);

				if (count >= 4 && attackerSkill.Data.HitType == SkillHitType.Magic)
					modifier.DamageMultiplier -= 0.20f;
			}
		}
	}
}
