//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Galeed Plateau
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_rokas_36_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Galeed Plateau to Elgos Monastery Main Building
		AddWarp("ROKAS_36_1_TO_ABBEY_35_4", 89, From("f_rokas_36_1", 1764.237, 360.9111), To("d_abbey_35_4", -1600, -555));

		// Galeed Plateau to Fasika Plateau
		AddWarp("ROKAS_36_1_TO_PILGRIM_36_2", 170, From("f_rokas_36_1", 55.53727, 1210.716), To("f_pilgrimroad_36_2", 1601, -573));
	}
}
