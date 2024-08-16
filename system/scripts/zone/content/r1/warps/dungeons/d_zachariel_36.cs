//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Royal Mausoleum 5F
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_zachariel_36WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Royal Mausoleum 5F to Royal Mausoleum 4F
		AddWarp("ZACHARIEL36_ZACHARIEL35", 0, From("d_zachariel_36", -2503.118, -5846.417), To("d_zachariel_35", -230, 731));
	}
}
