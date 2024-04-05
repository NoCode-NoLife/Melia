//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Nobreer Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_whitetrees_21_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Nobreer Forest to Emmet Forest
		AddWarp("WHITETREES_21_2_WHITETREES_23_1", -45, From("f_whitetrees_21_2", -1252.25, -1541.92), To("f_whitetrees_23_1", 414, 1544));

		// Nobreer Forest to Yudejan Forest
		AddWarp("WHITETREES_21_2_WHITETREES_21_1", 90, From("f_whitetrees_21_2", 1142.95, -1212.56), To("f_whitetrees_21_1", -1934, 992));

		// Nobreer Forest to Teresh Forest
		AddWarp("WHITETREES_21_2_WHITETREES_22_1", 225, From("f_whitetrees_21_2", -1370.229, 517.3204), To("f_whitetrees_22_1", 2550, -481));
	}
}
