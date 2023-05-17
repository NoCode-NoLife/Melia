//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Vienibe Shelter
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_castle_97WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Vienibe Shelter to Sajunga Road
		AddWarp("F_CASTLE_97_TO_D_CASTLE_19_1", 179, From("f_castle_97", -82.72789, 1942.764), To("d_castle_19_1", -8, 288));

		// Vienibe Shelter to Tvirtumas Fortress
		AddWarp("F_CASTLE_97_TO_F_CASTLE_99", 90, From("f_castle_97", 2121.722, 831.4098), To("f_castle_99", 1998, -1102));
	}
}
