//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Tenants' Farm
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_farm_47_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Tenants' Farm to Baron Allerno
		AddWarp("FARM_47_1_TO_FARM_47_4", 24, From("f_farm_47_1", 1527.472, -1336.256), To("f_siauliai_47_4", 646, 1508));

		// Tenants' Farm to Aqueduct Bridge Area
		AddWarp("FARM_47_1_TO_FARM_47_2", 267, From("f_farm_47_1", -1546.429, -34.85143), To("f_farm_47_2", 1728, 1026));

		// Tenants' Farm to Cobalt Forest
		AddWarp("FARM_47_1_TO_HUEVILL_58_3", 178, From("f_farm_47_1", 235.616, 1471.119), To("f_huevillage_58_3", -219, -1392));
	}
}
