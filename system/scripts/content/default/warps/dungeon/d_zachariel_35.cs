//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Royal Mausoleum 4F
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_zachariel_35WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Royal Mausoleum 4F to Royal Mausoleum 3F
		AddWarp("ZACHARIEL35_1_ZACHARIEL34_1", 193, From("d_zachariel_35", 1631, -1277), To("d_zachariel_34", -2778, 151));

		// Royal Mausoleum 4F to Royal Mausoleum 5F
		AddWarp("ZACHARIEL35_ZACHARIEL36", 34, From("d_zachariel_35", -202, 692), To("d_zachariel_36", -2507, -5662));
	}
}
