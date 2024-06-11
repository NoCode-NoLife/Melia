//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Lanko 22 Waters
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_3cmlake_26_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Lanko 22 Waters to Lanko 26 Waters
		AddWarp("F_3CMLAKE_26_2_TO_F_3CMLAKE_26_1", 180, From("f_3cmlake_26_2", 632.5809, 1907.616), To("f_3cmlake_26_1", 145, -2345));
	}
}
