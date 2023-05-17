//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Gytis Settlement Area
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_siauliai_50_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Gytis Settlement Area to Baron Allerno
		AddWarp("SIAUL50_1_TO_FARM_47_4", 157, From("f_siauliai_50_1", -794.7111, 1714.197), To("f_siauliai_47_4", 2449, -1222));

		// Gytis Settlement Area to Klaipeda
		AddWarp("SIAUL50_1_TO_KLAPEDA", 119, From("f_siauliai_50_1", 1638.162, -1425.22), To("c_Klaipe", 181, 816));

		// Gytis Settlement Area to Veja Ravine
		AddWarp("SIAUL50_1_TO_HUEVILLAGE_58_1", 90, From("f_siauliai_50_1", 2333.833, 536.9122), To("f_huevillage_58_1", 295, -1855));

		// Gytis Settlement Area to Vieta Gorge
		AddWarp("SIAUL50_1_TO_HUEVILLAGE_58_2", 170, From("f_siauliai_50_1", 905.0521, 1758.891), To("f_huevillage_58_2", -376, -1463));
	}
}
