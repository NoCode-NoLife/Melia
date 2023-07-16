//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Lanko 26 Waters
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_3cmlake_26_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Lanko 26 Waters to Barynwell 85 Waters
		AddWarp("F_3CMLAKE_26_1_TO_F_3CMLAKE_85", 90, From("f_3cmlake_26_1", 2315.699, 752.7906), To("f_3cmlake_85", 625, -1126));

		// Lanko 26 Waters to Lanko 22 Waters
		AddWarp("F_3CMLAKE_26_1_TO_F_3CMLAKE_26_2", 0, From("f_3cmlake_26_1", 145.1153, -2415.436), To("f_3cmlake_26_2", 635, 1817));

		// Lanko 26 Waters to Outer Wall District 9
		AddWarp("F_3CMLAKE_26_1_TO_F_CASTLE_20_1", 180, From("f_3cmlake_26_1", -127.8488, 1983.716), To("f_castle_20_1", -879, -727));
	}
}
