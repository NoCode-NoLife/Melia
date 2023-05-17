//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Passage of the Recluse
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class p_cathedral_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Passage of the Recluse to Stele Road
		AddWarp("PCATHEDRAL1_REMAINS37", 180, From("p_cathedral_1", 61, 363), To("f_remains_37", 491, -2497));

		// Passage of the Recluse to Sirdgela Forest
		AddWarp("PCATHEDRAL1_THORN20", 360, From("p_cathedral_1", -437, -1059), To("d_thorn_20", 2999, -929));
	}
}
