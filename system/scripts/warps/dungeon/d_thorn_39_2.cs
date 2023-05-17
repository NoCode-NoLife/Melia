//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Glade Hillroad
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_thorn_39_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Glade Hillroad to Spring Light Woods
		AddWarp("THORN392_TO_SIAULIAI461", 0, From("d_thorn_39_2", -2053.881, -1604.47), To("f_siauliai_46_1", 616.4485, 1258.294));

		// Glade Hillroad to Viltis Forest
		AddWarp("THORN392_TO_THORN391", -40, From("d_thorn_39_2", -75.92445, -1810.932), To("d_thorn_39_1", -789, 1608));

		// Glade Hillroad to Laukyme Swamp
		AddWarp("THORN392_TO_THORN393", 263, From("d_thorn_39_2", -2372.47, 1310.14), To("d_thorn_39_3", 3165, 103));
	}
}
