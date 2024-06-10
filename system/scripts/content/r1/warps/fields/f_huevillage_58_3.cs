//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Cobalt Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_huevillage_58_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Cobalt Forest to Vieta Gorge
		AddWarp("HUEVILLAGE58_3_TO_HUEVILLAGE58_2", -5, From("f_huevillage_58_3", 418.0233, -1834.006), To("f_huevillage_58_2", 1467, 1086));

		// Cobalt Forest to Septyni Glen
		AddWarp("HUEVILLAGE58_3_TO_HUEVILLAGE58_4", 207, From("f_huevillage_58_3", -1129.885, -29.77028), To("f_huevillage_58_4", 1306, -996));

		// Cobalt Forest to Tenants' Farm
		AddWarp("HUEVILL_58_3_TO_FARM_47_1", 6, From("f_huevillage_58_3", -223.0459, -1545.6), To("f_farm_47_1", 190, 1313));
	}
}
