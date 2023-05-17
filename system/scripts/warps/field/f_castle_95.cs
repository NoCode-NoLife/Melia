//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Outer Wall District 13
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_castle_95WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Outer Wall District 13 to Inner Wall District 10
		AddWarp("F_CASTLE_95_TO_F_CASTLE_94", 270, From("f_castle_95", -1531.582, -603.2539), To("f_castle_94", -532, 3154));

		// Outer Wall District 13 to Outer Wall District 14
		AddWarp("F_CASTLE_95_TO_F_CASTLE_96", 180, From("f_castle_95", 128.9252, 1386.699), To("f_castle_96", 332, -1789));

		// Outer Wall District 13 to Maven 31 Waters
		AddWarp("F_CASTLE_95_TO_F_3CMLAKE_27_2", 70, From("f_castle_95", 1868.197, -1831.377), To("f_3cmlake_27_2", 304, 489));
	}
}
