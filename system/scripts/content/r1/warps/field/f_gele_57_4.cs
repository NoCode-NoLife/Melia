//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Tenet Garden
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_gele_57_4WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Tenet Garden to Nefritas Cliff
		AddWarp("GELE574_TO_GELE573", 6, From("f_gele_57_4", -841, -155), To("f_gele_57_3", 199, 1086));

		// Tenet Garden to Tenet Church 1F
		AddWarp("GELE574_TO_CHAPEL576", 183, From("f_gele_57_4", 1296.24, 2145.48), To("d_chapel_57_6", -1638, 448));

		// Tenet Garden to Entrance of Kateen Forest
		AddWarp("GELE574_KATYN_7", 180, From("f_gele_57_4", -912.23, 2474.32), To("f_katyn_7", 708, -4356));

		// Tenet Garden to Guards Graveyard
		AddWarp("GELE_57_4_TO_CATACOMB_01", 180, From("f_gele_57_4", -442.254, 2141.916), To("id_catacomb_01", -241, -3428));
	}
}
