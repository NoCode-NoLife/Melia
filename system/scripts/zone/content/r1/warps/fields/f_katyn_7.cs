//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Entrance of Kateen Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_katyn_7WarpsScript : GeneralScript
{
	protected override void Load()
	{
		// Entrance of Kateen Forest to Tenet Garden
		AddWarp("KATYN7_GELE574", 0, From("f_katyn_7", 663, -4459), To("f_gele_57_4", -909, 2390));

		// Entrance of Kateen Forest to Owl Burial Ground
		AddWarp("KATYN7_KATYN7_2", 180, From("f_katyn_7", -864, 3894), To("f_katyn_7_2", 299, -4327));

		// Entrance of Kateen Forest to EP17 Karolis Springs
		AddWarp("EP17_2_KATYN_7_KATYN_10", 90, From("f_katyn_7", 1650, -3427), To("ep17_2_f_katyn_10", 4550, -1490));
	}
}
