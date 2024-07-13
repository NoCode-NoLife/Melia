//--- Melia Script ----------------------------------------------------------
// West Siauliai Woods
//--- Description -----------------------------------------------------------
// NPCs found in and around West Siauliai Woods.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliaiWestNpcScript : GeneralScript
{
	public override void Load()
	{
		// Lv1 Treasure Chest
		//-------------------------------------------------------------------------

		AddNpc(147392, "Lv1 Treasure Chest", "f_siauliai_west", -580, -1417, 180.0, async dialog =>
		{
			await OpenChest(dialog.Player, dialog.Npc);
			dialog.Player.Inventory.Add(ItemId.BRC02_114, 1, InventoryAddType.PickUp);
		});

		// Collection Chest
		AddNpc(147393, "Collection Chest", "f_siauliai_west", 1334, -1109, 45.0, async dialog =>
		{
			await OpenChest(dialog.Player, dialog.Npc);
			dialog.Player.Inventory.Add(ItemId.COLLECT_118, 1, InventoryAddType.PickUp);
		});
	}
}
