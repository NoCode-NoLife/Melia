//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Emmet Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_whitetrees_23_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Emmet Forest to Kule Peak
		AddWarp("WHITETREES23_1_TO_KATYN18", 98, From("f_whitetrees_23_1", 1652.851, 1333.773), To("f_katyn_18", -1274, -2145));

		// Emmet Forest to Pystis Forest
		AddWarp("WHITETREES23_1_TO_MAPLE23_2", -52, From("f_whitetrees_23_1", -1023.053, -1223.455), To("f_maple_23_2", 1444, 267));

		// Emmet Forest to Nobreer Forest
		AddWarp("WHITETREES23_1_TO_WHITETREES21_2", 188, From("f_whitetrees_23_1", 360.9346, 1674.504), To("f_whitetrees_21_2", -1130, -1436));

		// Emmet Forest to Tekel Shelter
		AddWarp("WHITETREES23_1_TO_WHITETREES22_2", 255, From("f_whitetrees_23_1", -1711.827, -136.1689), To("f_whitetrees_22_2", 1607, -979));
	}
}
