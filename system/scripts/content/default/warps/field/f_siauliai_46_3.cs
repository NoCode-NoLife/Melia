//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Vilna Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_siauliai_46_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Vilna Forest to Uskis Arable Land
		AddWarp("SIAULIAI46_3_SIAULIAI46_2", 180, From("f_siauliai_46_3", 2224, 1573), To("f_siauliai_46_2", -2338, 3201));

		// Vilna Forest to Dina Bee Farm
		AddWarp("SIAULIAI46_3_SIAULIAI46_4", 91, From("f_siauliai_46_3", -1358, -1360), To("f_siauliai_46_4", -300, 862));
	}
}
