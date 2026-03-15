using Melia.Shared.Game.Const;
using Melia.Zone.Scripting.ScriptableEvents;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;

namespace Melia.Zone.Abilities.Handlers.Swordsmen.Swordsman
{
	/// <summary>
	/// Handler for the Swordsman ability "Shield Mastery: Swordsman",
	/// increasing physical defense when equipped with a shield.
	/// </summary>
	[AbilityHandler(AbilityId.SwordMastery_DEForATK)]
	public class SwordMastery_DEForATK : IAbilityHandler
	{
		/// <summary>
		/// Increases physical defense when equipped with a shield.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		[CombatCalcModifier(CombatCalcPhase.BeforeCalc, AbilityId.SwordMastery_DEForATK)]
		public static void OnBeforeCalc(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (!target.IsAbilityActive(AbilityId.SwordMastery_DEForATK))
				return;

			if (!target.Components.TryGet<InventoryComponent>(out var inventory))
				return;

			var leftHand = inventory.GetEquip(EquipSlot.LeftHand);

			// Ability "Shield Mastery: Swordsman"
			// 10% of Weapon ATK is applied as the Physical Defense when
			// equipping [One-handed weapon] with [Shield]
			if (leftHand?.Data.EquipType1 == EquipType.Shield && skill.Data.HitType != SkillHitType.Magic)
			{
				var rightHand = inventory.GetEquip(EquipSlot.RightHand);
				var atk = rightHand?.Properties.GetFloat(PropertyName.MAXATK) ?? 0;

				modifier.DefenseBonus += atk * 0.10f;
			}
		}
	}
}
