//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Elgos Monastery Annex
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_abbey_35_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Elgos Monastery Annex to Nahash Forest
		AddWarp("ABBEY_35_3_SIAULIAI_35_1", 181, From("d_abbey_35_3", 20.79054, 1662.704), To("f_siauliai_35_1", -2, -1223));

		// Elgos Monastery Annex to Elgos Monastery Main Building
		AddWarp("ABBEY_35_3_ABBEY_35_4", 0, From("d_abbey_35_3", 11.03019, -1657.332), To("d_abbey_35_4", 25, 1375));
	}
}
