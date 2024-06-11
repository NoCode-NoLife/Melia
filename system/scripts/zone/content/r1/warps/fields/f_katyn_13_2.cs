//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Secret Room
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_katyn_13_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Secret Room to Tenet Garden
		AddWarp("KATYN_13_2_GELE574", 90, From("f_katyn_13_2", 522, -1938), To("f_gele_57_4", -930, 2378));

		// Secret Room to Dvasia Peak
		AddWarp("KATYN13_2_THORN22", 270, From("f_katyn_13_2", -2252, 1338), To("d_thorn_22", 1292, -816));

		// Secret Room to Septyni Glen
		AddWarp("KATYN13_2_HUEVILLAGE58_4", 270, From("f_katyn_13_2", -937, -2022), To("f_huevillage_58_4", 1359, 327));

		// Secret Room to (Closed) Letas Stream
		AddWarp("KATYN13_2_KATYN12", 180, From("f_katyn_13_2", -52, 2609), To("f_katyn_12", 80, -1494));
	}
}
