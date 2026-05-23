using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Handler for the Disarm Shield Debuff,
	/// which unequips your shield and prevents
	/// equipping shields for its duration
	/// </summary>
	[BuffHandler(BuffId.Common_ShieldDesrption)]
	public class Common_ShieldDesrption : BuffHandler
	{
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var target = buff.Target;

			if (target.Components.TryGet<InventoryComponent>(out var inventory))
			{
				var lhItem = inventory.GetItem(EquipSlot.LeftHand);
				if (lhItem.Data.EquipType1 != EquipType.Shield)
					return;

				inventory.Unequip(EquipSlot.LeftHand);
			}

			// TODO: does this have any effect on monsters?
		}
	}
}
