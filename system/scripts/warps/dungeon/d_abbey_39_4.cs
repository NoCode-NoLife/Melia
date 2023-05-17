//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Tyla Monastery
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_abbey_39_4WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Tyla Monastery to Laukyme Swamp
		AddWarp("ABBEY394_TO_THORN393", 1, From("d_abbey_39_4", 1445.681, -1638.636), To("d_thorn_39_3", -1892, 1235));
	}
}
