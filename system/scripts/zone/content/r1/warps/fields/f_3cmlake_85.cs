//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Barynwell 85 Waters
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_3cmlake_85WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Barynwell 85 Waters to Lanko 26 Waters
		AddWarp("F_3CMLAKE_85_TO_F_3CMLAKE_26_1", 0, From("f_3cmlake_85", 626.0503, -1200.827), To("f_3cmlake_26_1", 2237, 753));

		// Barynwell 85 Waters to Barynwell 86 Waters
		AddWarp("F_3CMLAKE_85_TO_F_3CMLAKE_86", 90, From("f_3cmlake_85", -2020.322, 219.9718), To("f_3cmlake_86", -175, -1580));
	}
}
