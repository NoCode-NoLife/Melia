//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Septyni Glen
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_huevillage_58_4WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Septyni Glen to Cobalt Forest
		AddWarp("HUEVILLAGE58_4_TO_HUEVILLAGE58_3", -7, From("f_huevillage_58_4", 1292.37, -1060.92), To("f_huevillage_58_3", -1080, -97));

		// Septyni Glen to Gate Route
		AddWarp("HUEVILLAGE58_4_TO_THORN19", 175, From("f_huevillage_58_4", 993.48, 1273.34), To("d_thorn_19", -200, -3914));

		// Septyni Glen to Poslinkis Forest
		AddWarp("HUEVILLAGE58_4_KATYN13", 91, From("f_huevillage_58_4", 1470, 359), To("f_katyn_13", -992, -2376));

		// Septyni Glen to Dina Bee Farm
		AddWarp("HUEVILLAGE58_4_SIAULIAI46_4", 180, From("f_huevillage_58_4", 471, 982), To("f_siauliai_46_4", 318, -1000));
	}
}
