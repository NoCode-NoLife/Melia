//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Barynwell 27 Waters
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_3cmlake_27_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Barynwell 27 Waters to Barynwell 87 Waters
		AddWarp("F_3CMLAKE_27_1_TO_F_3CMLAKE_87", 4, From("f_3cmlake_27_1", -150.2736, -1473.051), To("f_3cmlake_87", 1973, -747));

		// Barynwell 27 Waters to Maven 31 Waters
		AddWarp("F_3CMLAKE_27_1_TO_F_3CMLAKE_27_2", 90, From("f_3cmlake_27_1", 2456.679, 290.1259), To("f_3cmlake_27_2", -1499, -296));
	}
}
