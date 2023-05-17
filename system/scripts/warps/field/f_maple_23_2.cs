//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Pystis Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_maple_23_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Pystis Forest to Emmet Forest
		AddWarp("MAPLE23_2_TO_WHITETREES23_1", 144, From("f_maple_23_2", 1600.112, 369.1022), To("f_whitetrees_23_1", -964, -1204));

		// Pystis Forest to Lhadar Forest
		AddWarp("MAPLE23_2_TO_MAPLE25_3", 21, From("f_maple_23_2", 1564.166, -1382.529), To("f_maple_25_3", -624, 1314));

		// Pystis Forest to Syla Forest
		AddWarp("MAPLE23_2_TO_WHITETREES23_3", 258, From("f_maple_23_2", -1491.322, 450.3834), To("f_whitetrees_23_3", 326, -1215));

		// Pystis Forest to Northern Parias Forest
		AddWarp("MAPLE23_2_TO_MAPLE24_3", 89, From("f_maple_23_2", -901.704, -1639.13), To("f_maple_24_3", -1391, 1266));
	}
}
