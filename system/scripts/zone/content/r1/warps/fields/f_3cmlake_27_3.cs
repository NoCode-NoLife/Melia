//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Maven 32 Waters
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_3cmlake_27_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Maven 32 Waters to Maven 31 Waters
		AddWarp("F_3CMLAKE_27_3_TO_F_3CMLAKE_27_2", 2, From("f_3cmlake_27_3", 22.01014, -1574.822), To("f_3cmlake_27_2", 2429, -392));
	}
}
