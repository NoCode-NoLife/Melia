using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Peltasta
{
	/// <summary>
	/// Handle for the Hard Shield Buff, which increases defense
	/// based on the defense power of the equipped shield
	/// </summary>
	[BuffHandler(BuffId.HardShield_Buff)]
	public class HardShield_Buff : BuffHandler
	{
		private const float DefMultiplierPerLevel = 0.2f;

		public override void OnStart(Buff buff)
		{
			var target = buff.Target;

			var defBonus = GetDefBonus(buff);

			AddPropertyModifier(buff, target, PropertyName.DEF_BM, defBonus);
		}

		public override void OnEnd(Buff buff)
		{
			var target = buff.Target;

			RemovePropertyModifier(buff, target, PropertyName.DEF_BM);
		}

		private float GetDefBonus(Buff buff)
		{
			var caster = buff.Caster;

			var shieldDef = 0f;
			if (caster is Character character) 
			{
				var lhItem = character.Inventory.GetItem(EquipSlot.LeftHand);
				if (lhItem.Data.EquipType1 == EquipType.Shield)
					shieldDef = lhItem.Data.Def;
			}
			
			return shieldDef * DefMultiplierPerLevel * buff.NumArg1;
		}
	}
}
