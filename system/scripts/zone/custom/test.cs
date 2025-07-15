//--- Melia Script ----------------------------------------------------------
// Test Script
//--- Description -----------------------------------------------------------
// Exec's personal playground.
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class TestScript1 : GeneralScript
{
	protected override void Load()
	{
		AddNpc(20104, "[Accessory Merchant] Ronesa", "c_Klaipe", 269, -611, 90, async dialog =>
		{
			dialog.SetTitle("Ronesa");
			dialog.SetPortrait("Alfonso_Select_1");

			await dialog.Msg("Welcome.{nl}Only hard-to-find stuff here.");

			var selected = await dialog.Select("What can I do for you?", Option("Talk", "talk"), Option("Shop", "shop"));
			if (selected == "talk")
			{
				await dialog.Msg("I'm sorry, I'm not in the mood to talk right now.");
			}
			else if (selected == "shop")
			{
				await dialog.OpenShop("RonesaShop");
			}
		});

		CreateShop("RonesaShop", shop =>
		{
			shop.AddItem(ItemId.BRC01_111, amount: 1, price: 1);
			shop.AddItem(ItemId.BRC02_111, amount: 1, price: 1);
			shop.AddItem(ItemId.Drug_HP1, amount: 3, price: 1);
		});
	}
}
