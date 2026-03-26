using Melia.Shared.Game.Const;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Abilities.Handlers.Swordsmen.Peltasta
{
	/// <summary>
	/// Contains code related to the "Peltasta: Shield Attack" ability,
	/// used by several Peltasta skills.
	/// </summary>
	public static class Peltasta38
	{
		private const float BonusPerLevel = 0.06f;

		/// <summary>
		/// Returns a physical attack bonus based on the ability.
		/// Returns 0 if no bonus applies.
		/// </summary>
		/// <param name="caster"></param>
		/// <returns></returns>
		public static float GetBonusPAtk(ICombatEntity caster)
		{
			if (!caster.TryGetActiveAbilityLevel(AbilityId.Peltasta38, out var abilityLevel))
				return 0;

			if (!caster.TryGetItem(EquipSlot.LeftHand, out var lhItem))
				return 0;

			if (lhItem.Data.EquipType1 != EquipType.Shield)
				return 0;

			var shieldDef = lhItem.Properties.GetFloat(PropertyName.DEF);
			var bonusPatk = abilityLevel * BonusPerLevel * shieldDef;

			return bonusPatk;
		}
	}
}
