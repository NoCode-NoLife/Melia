using Melia.Shared.Game.Const;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;

namespace Melia.Zone.Abilities.Handlers.Swordsmen.Rodelero
{
	/// <summary>
	/// Contains code related to the "Rodelero: Shield Attack" ability,
	/// used by several Rodelero skills.
	/// </summary>
	public static class Rodelero31
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
			if (!caster.TryGetActiveAbilityLevel(AbilityId.Rodelero31, out var abilityLevel))
				return 0;

			if (!caster.Components.TryGet<InventoryComponent>(out var inv))
				return 0;

			var lhItem = inv.GetItem(EquipSlot.LeftHand);
			if (lhItem.Data.EquipType1 != EquipType.Shield)
				return 0;

			var shieldDef = lhItem.Data.Def;
			var bonusPatk = abilityLevel * BonusPerLevel * shieldDef;

			return bonusPatk;
		}
	}
}
