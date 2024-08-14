using Melia.Shared.Game.Const;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Peltasta.Abilities
{
	/// <summary>
	/// Contains code related to the "Peltasta: Shield Attack" ability,
	/// used by several Peltasta skills.
	/// </summary>
	public static class Peltasta38
	{
		private const float BonusPerLevel = 0.06f;

		/// <summary>
		/// Returns a physical attack bonus based on the High Guard ability.
		/// Returns 0 if no bonus applies.
		/// </summary>
		/// <param name="caster"></param>
		/// <returns></returns>
		public static float GetBonusPAtk(ICombatEntity caster)
		{
			if (!caster.TryGetActiveAbilityLevel(AbilityId.Peltasta38, out var abilityLevel))
				return 0;

			if (caster is not Character character)
				return 0;

			var lhItem = character.Inventory.GetItem(EquipSlot.LeftHand);
			if (lhItem.Data.EquipType1 != EquipType.Shield)
				return 0;

			var shieldDef = lhItem.Data.Def;
			var bonusPatk = abilityLevel * BonusPerLevel * shieldDef;

			return bonusPatk;
		}
	}
}
