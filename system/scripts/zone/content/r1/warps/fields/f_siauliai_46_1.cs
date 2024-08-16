//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Spring Light Woods
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_siauliai_46_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Spring Light Woods to Gate Route
		AddWarp("SIAULIAI46_1_THORN19", 70, From("f_siauliai_46_1", -624, -1920), To("d_thorn_19", 274, 3055));

		// Spring Light Woods to Uskis Arable Land
		AddWarp("SIAULIAI46_1_SIAULIAI46_2", 270, From("f_siauliai_46_1", -1872, -427), To("f_siauliai_46_2", 1279, 4301));

		// Spring Light Woods to Glade Hillroad
		AddWarp("SIAULIAI46_1_THORN39_2", 200, From("f_siauliai_46_1", 585.5263, 1320.263), To("d_thorn_39_2", -2028, -1509));
	}
}
