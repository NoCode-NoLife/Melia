//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Baron Allerno
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_siauliai_47_4WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Baron Allerno to Myrkiti Farm
		AddWarp("SIAUL47_4_TO_FARM_47_3", -84, From("f_siauliai_47_4", -2167.146, -153.8053), To("f_farm_47_3", 945, 65));

		// Baron Allerno to Gytis Settlement Area
		AddWarp("SIAUL47_4_TO_SIAUL50_1", -5, From("f_siauliai_47_4", 2445.227, -1354.79), To("f_siauliai_50_1", -826, 1651));

		// Baron Allerno to Tenants' Farm
		AddWarp("SIAUL47_4_TO_FARM_47_1", 185, From("f_siauliai_47_4", 653.1481, 1595.561), To("f_farm_47_1", 1501, -1273));
	}
}
