//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Barynwell 86 Waters
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_3cmlake_86WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Barynwell 86 Waters to Barynwell 85 Waters
		AddWarp("F_3CMLAKE_86_TO_F_3CMLAKE_85", 16, From("f_3cmlake_86", -145.4085, -1696.083), To("f_3cmlake_85", -2064, 144));

		// Barynwell 86 Waters to Barynwell 87 Waters
		AddWarp("F_3CMLAKE_86_TO_F_3CMLAKE_87", 145, From("f_3cmlake_86", 1725.697, 964.7784), To("f_3cmlake_87", -340, -1636));
	}
}
