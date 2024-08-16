//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Inner Wall District 10
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_castle_94WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Inner Wall District 10 to Inner Wall District 9
		AddWarp("F_CASTLE_94_TO_F_CASTLE_20_2", 0, From("f_castle_94", -688.4324, -862.6098), To("f_castle_20_2", 1694, -260));

		// Inner Wall District 10 to Outer Wall District 11
		AddWarp("F_CASTLE_94_TO_F_CASTLE_93", 90, From("f_castle_94", 1475.366, 999.3951), To("f_castle_93", -2794, -219));

		// Inner Wall District 10 to Outer Wall District 13
		AddWarp("F_CASTLE_94_TO_F_CASTLE_95", 180, From("f_castle_94", -518.7258, 3216.284), To("f_castle_95", -1469, -598));
	}
}
