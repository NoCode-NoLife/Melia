//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Vieta Gorge
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_huevillage_58_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Vieta Gorge to Veja Ravine
		AddWarp("HUEVILLAGE58_2_TO_HUEVILLAGE58_1", 95, From("f_huevillage_58_2", 439.58, -1641.15), To("f_huevillage_58_1", -658, -346));

		// Vieta Gorge to Cobalt Forest
		AddWarp("HUEVILLAGE58_2_TO_HUEVILLAGE58_3", 173, From("f_huevillage_58_2", 1461.54, 1157.1), To("f_huevillage_58_3", 415, -1786));

		// Vieta Gorge to Gytis Settlement Area
		AddWarp("HUEVILLAGE_58_2_SIAUL50_1", -8, From("f_huevillage_58_2", -390.231, -1617.554), To("f_siauliai_50_1", 896, 1677));
	}
}
