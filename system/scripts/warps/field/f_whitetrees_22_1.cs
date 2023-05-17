//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Teresh Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_whitetrees_22_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Teresh Forest to Nobreer Forest
		AddWarp("WHITETREES22_1_WHITETREES21_2", 59, From("f_whitetrees_22_1", 2661.078, -554.6171), To("f_whitetrees_21_2", -1303, 444));

		// Teresh Forest to Tekel Shelter
		AddWarp("WHITETREES22_1_WHITETREES22_2", 255, From("f_whitetrees_22_1", -1834.433, 932.4785), To("f_whitetrees_22_2", 706, 1562));
	}
}
