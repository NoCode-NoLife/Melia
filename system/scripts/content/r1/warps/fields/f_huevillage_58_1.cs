//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Veja Ravine
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_huevillage_58_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Veja Ravine to Nefritas Cliff
		AddWarp("HUEVILLAGE58_1_TO_GELE573", 79, From("f_huevillage_58_1", 1562.31, -1187.531), To("f_gele_57_3", -1307, -684));

		// Veja Ravine to Vieta Gorge
		AddWarp("HUEVILLAGE58_1_TO_HUEVILLAGE58_2", -51, From("f_huevillage_58_1", -719.62, -402.6), To("f_huevillage_58_2", 344, -1633));

		// Veja Ravine to Gytis Settlement Area
		AddWarp("HUEVILLAGE_58_1_SIAUL50_1", -22, From("f_huevillage_58_1", 222.0356, -1974.421), To("f_siauliai_50_1", 2246, 554));
	}
}
