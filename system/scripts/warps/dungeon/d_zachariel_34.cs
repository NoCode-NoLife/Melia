//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Royal Mausoleum 3F
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_zachariel_34WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Royal Mausoleum 3F to Royal Mausoleum 2F
		AddWarp("ZACHARIEL34_ZACHARIEL33", 191, From("d_zachariel_34", 3568, 208), To("d_zachariel_33", -275, 1823));

		// Royal Mausoleum 3F to Royal Mausoleum 4F
		AddWarp("ZACHARIEL34_3_ZACHARIEL35_3", -83, From("d_zachariel_34", -2943, 143), To("d_zachariel_35", 1610, -1376));
	}
}
