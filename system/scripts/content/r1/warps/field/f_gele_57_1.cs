//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Srautas Gorge
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_gele_57_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Srautas Gorge to Miners' Village
		AddWarp("GELE571_SIALLAIOUT", 270, From("f_gele_57_1", -1662, -1176), To("f_siauliai_out", 1733, -562));

		// Srautas Gorge to Gele Plateau
		AddWarp("GELE571_GELE572", 180, From("f_gele_57_1", 640, 1489), To("f_gele_57_2", 13, -983));
	}
}
