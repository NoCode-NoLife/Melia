using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Agility Buff, which increases the target's movement speed.
	/// </summary>
	[BuffHandler(BuffId.Agility_Buff)]
	public class Agility_Buff : BuffHandler
	{
		private int speedBonus = 0;

		public override void OnStart(Buff buff)
		{
			var target = buff.Target as Character;

			// It is not applyed to characters without Shoes
			if (target != null && target.Inventory.GetEquip(EquipSlot.Shoes) != null)
			{
				// It is not applyed to characters without Gloves

				if (target != null && target.Inventory.GetEquip(EquipSlot.Gloves) != null)
				{
					if (buff.Data.Level == 1 || buff.Data.Level == 2)
					{
						speedBonus = 2;
					}
					else if (buff.Data.Level == 3 || buff.Data.Level == 4)
					{
						speedBonus = 3;
					}
					else if (buff.Data.Level == 5 || buff.Data.Level == 6)
					{
						speedBonus = 4;
					}
					else if (buff.Data.Level == 7 || buff.Data.Level == 8)
					{
						speedBonus = 5;
					} else {
						speedBonus = 6;
					}

					// TODO: Apply "Agility: Enchant" (passive adquire through attribute points)
					// TODO: Reduce the STAMINA consuption rate

					target.Properties.Modify(PropertyName.MSPD_BM, speedBonus);

					Send.ZC_MOVE_SPEED(target);
				}
			}				
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Target is Character character)
			{
				var target = buff.Target as Character;

				target.Properties.Modify(PropertyName.MSPD_BM, -speedBonus);

				Send.ZC_MOVE_SPEED(character);
			}				
		}
	}
}
