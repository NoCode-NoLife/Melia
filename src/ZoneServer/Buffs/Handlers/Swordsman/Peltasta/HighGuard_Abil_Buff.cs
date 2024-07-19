using Melia.Shared.Game.Const;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Peltasta
{
	/// <summary>
	/// Contains code related to the High Guard ability buff.
	/// </summary>
	/// <remarks>
	/// HighGuard_Abil_Buff is a buff that is started or stopped from the skill
	/// High Guard under certain conditions. It provides a bonus to the physical
	/// attack of some attacks made by the caster. We don't need a buff handler
	/// for it, but this class provides an accessible way to get the bonus.
	/// </remarks>
	public static class HighGuard_Abil_Buff
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
			if (!caster.TryGetBuff(BuffId.HighGuard_Abil_Buff, out var buff))
				return 0;

			if (caster is not Character character)
				return 0;

			var lhItem = character.Inventory.GetItem(EquipSlot.LeftHand);
			if (lhItem.Data.EquipType1 != EquipType.Shield)
				return 0;

			var abilityLevel = buff.NumArg1;
			var shieldDef = lhItem.Data.Def;

			var bonusPatk = abilityLevel * BonusPerLevel * shieldDef;

			return bonusPatk;
		}
	}
}
