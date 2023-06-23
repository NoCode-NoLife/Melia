//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Nefritas Cliff
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_gele_57_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Nefritas Cliff to Gele Plateau
		AddWarp("GELE573_TO_GELE572", 5, From("f_gele_57_3", -509.8248, -1593.792), To("f_gele_57_2", 72, 1456));

		// Nefritas Cliff to Tenet Garden
		AddWarp("GELE573_TO_GELE574", 180, From("f_gele_57_3", 199.4143, 1157.455), To("f_gele_57_4", -833, -48));

		// Nefritas Cliff to Veja Ravine
		AddWarp("GELE573_TO_HUE581", -54, From("f_gele_57_3", -1357.6, -739.9471), To("f_huevillage_58_1", 1467, -1161));

		// Nefritas Cliff to Thaumas Trail
		AddWarp("GELE57_3_PILGRIM41_1", 90, From("f_gele_57_3", 1494.618, -711.321), To("f_pilgrimroad_41_1", -1033, -1020));
	}
}
