//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Novaha Library
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep15_1_f_abbey_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Novaha Library to Novaha Institute
		AddWarp("WARP_EP15_1_FABBEY_2_TO_EP15_1_FABBEY_1", 90, From("ep15_1_f_abbey_2", 1137.038, -163.5099), To("ep15_1_f_abbey_1", -797, 1607));

		// Novaha Library to The Confessional
		AddWarp("WARP_EP15_1_FABBEY_2_TO_EP15_1_FABBEY_3", 184, From("ep15_1_f_abbey_2", -1508.286, 1726.041), To("ep15_1_f_abbey_3", -14, -1310));
	}
}
