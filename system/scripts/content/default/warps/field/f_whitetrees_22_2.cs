//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Tekel Shelter
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_whitetrees_22_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Tekel Shelter to Teresh Forest
		AddWarp("WHITETREES22_2_WHITETREES22_1", 105, From("f_whitetrees_22_2", 760.0185, 1583.006), To("f_whitetrees_22_1", -1768, 928));

		// Tekel Shelter to Emmet Forest
		AddWarp("WHITETREES22_2_WHITETREES23_1", 90, From("f_whitetrees_22_2", 1753.643, -992.6005), To("f_whitetrees_23_1", -1625, -146));

		// Tekel Shelter to Izoliacjia Plateau
		AddWarp("WHITETREES22_2_WHITETREES22_3", -4, From("f_whitetrees_22_2", -10.28275, -1766.347), To("f_whitetrees_22_3", -111, 1365));
	}
}
