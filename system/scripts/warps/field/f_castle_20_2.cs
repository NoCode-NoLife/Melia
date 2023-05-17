//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Inner Wall District 9
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_castle_20_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Inner Wall District 9 to Inner Wall District 8
		AddWarp("CASTLE_20_2_CASTLE_20_3", 270, From("f_castle_20_2", -1733.001, 57.40167), To("f_castle_20_3", 1248, -353));

		// Inner Wall District 9 to Outer Wall District 9
		AddWarp("CASTLE_20_2_CASTLE_20_1", 0, From("f_castle_20_2", -94.34544, -1410.943), To("f_castle_20_1", -80, 1325));

		// Inner Wall District 9 to Inner Wall District 10
		AddWarp("CASTLE_20_2_CASTLE_94", 90, From("f_castle_20_2", 1766.217, -250.0743), To("f_castle_94", -688, -796));
	}
}
