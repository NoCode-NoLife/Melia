//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Outer Wall District 9
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_castle_20_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Outer Wall District 9 to Inner Wall District 9
		AddWarp("CASTLE_20_1_CASTLE_20_2", 180, From("f_castle_20_1", -66.72218, 1511.727), To("f_castle_20_2", -91, -1308));

		// Outer Wall District 9 to Outer Wall District 11
		AddWarp("CASTLE_20_1_CASTLE_93", 125, From("f_castle_20_1", 1188.236, 453.2768), To("f_castle_93", 613, -879));

		// Outer Wall District 9 to Lanko 26 Waters
		AddWarp("CASTLE_20_1_3CMLAKE_26_1", 0, From("f_castle_20_1", -879.1544, -780.2732), To("f_3cmlake_26_1", -117, 1796));
	}
}
