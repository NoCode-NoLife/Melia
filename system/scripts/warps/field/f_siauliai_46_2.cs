//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Uskis Arable Land
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_siauliai_46_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Uskis Arable Land to Spring Light Woods
		AddWarp("SIAULIAI46_2_SIAULIAI46_1", 90, From("f_siauliai_46_2", 1378, 4293), To("f_siauliai_46_1", -1804, -412));

		// Uskis Arable Land to Vilna Forest
		AddWarp("SIAULIAI46_2_SIAULIAI46_3", -80, From("f_siauliai_46_2", -2410.364, 3233.48), To("f_siauliai_46_3", 2238, 1470));

		// Uskis Arable Land to Dina Bee Farm
		AddWarp("SIAULIAI46_2_SIAULIAI46_4", 70, From("f_siauliai_46_2", -1148.54, 3224.894), To("f_siauliai_46_4", 1367, 330));

		// Uskis Arable Land to Laukyme Swamp
		AddWarp("SIAULIAI46_2_THORN39_3", 220, From("f_siauliai_46_2", 1197.621, 7571.161), To("d_thorn_39_3", 1317, -2163));
	}
}
