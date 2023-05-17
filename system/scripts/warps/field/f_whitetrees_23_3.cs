//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Syla Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_whitetrees_23_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Syla Forest to Pystis Forest
		AddWarp("WHITETREES23_3_TO_MAPLE23_2", 60, From("f_whitetrees_23_3", 374.4368, -1220.554), To("f_maple_23_2", -1321, 291));

		// Syla Forest to Central Parias Forest
		AddWarp("WHITETREES23_3_TO_MAPLE24_1", -70, From("f_whitetrees_23_3", -1896.812, -482.626), To("f_maple_24_1", -1450, 653));

		// Syla Forest to Mishekan Forest
		AddWarp("WHITETREES23_3_TO_WHITETREES56_1", 171, From("f_whitetrees_23_3", -552.1576, 1559.02), To("f_whitetrees_56_1", 1427, -607));
	}
}
