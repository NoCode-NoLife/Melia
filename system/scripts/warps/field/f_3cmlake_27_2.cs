//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Maven 31 Waters
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_3cmlake_27_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Maven 31 Waters to Barynwell 27 Waters
		AddWarp("F_3CMLAKE_27_2_TO_F_3CMLAKE_27_1", 270, From("f_3cmlake_27_2", -1570.947, -295.8118), To("f_3cmlake_27_1", 2343, 311));

		// Maven 31 Waters to Maven 32 Waters
		AddWarp("F_3CMLAKE_27_2_TO_F_3CMLAKE_27_3", 90, From("f_3cmlake_27_2", 2541.386, -385.2286), To("f_3cmlake_27_3", 18, -1483));

		// Maven 31 Waters to Outer Wall District 13
		AddWarp("F_3CMLAKE_27_2_TO_F_CASTLE_95", 180, From("f_3cmlake_27_2", 305.8193, 574.869), To("f_castle_95", 1814, -1811));
	}
}
