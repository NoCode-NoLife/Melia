//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Tenet Church 2F
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_chapel_57_7WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Tenet Church 2F to Tenet Church 1F
		AddWarp("CHAPEL577_CHAPEL576", 180, From("d_chapel_57_7", -683, -831), To("d_chapel_57_6", -1487, 299));
	}
}
