//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Lhadar Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_maple_25_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Lhadar Forest to Svalphinghas Forest
		AddWarp("MAPLE_25_3_TO_MAPLE_25_2", 90, From("f_maple_25_3", 1763.59, 639.89), To("f_maple_25_2", -1639, -400));

		// Lhadar Forest to Pystis Forest
		AddWarp("MAPLE_25_3_TO_MAPLE_23_2", 186, From("f_maple_25_3", -621.5583, 1423.318), To("f_maple_23_2", 1533, -1325));

		// Lhadar Forest to Northern Parias Forest
		AddWarp("MAPLE_25_3_TO_MAPLE_24_3", 90, From("f_maple_25_3", 1648.38, 112.11), To("f_maple_24_3", 903, 31));

		// Lhadar Forest to Timerys Temple
		AddWarp("MAPLE_25_3_TO_CATACOMB_25_4", 267, From("f_maple_25_3", -1900.977, 545.0889), To("id_catacomb_25_4", 1561, 586));
	}
}
