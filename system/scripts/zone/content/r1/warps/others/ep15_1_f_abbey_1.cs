//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Novaha Institute
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep15_1_f_abbey_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Novaha Institute to Woods of the Linked Bridges
		AddWarp("WARP_EP15_1_FABBEY_1_TO_EP13_F_SIAULIAI_2", 90, From("ep15_1_f_abbey_1", 1465.371, 217.9448), To("ep13_f_siauliai_2", 2048, 1031));

		// Novaha Institute to Novaha Library
		AddWarp("WARP_EP15_1_FABBEY_1_TO_EP15_1_FABBEY_2", 178, From("ep15_1_f_abbey_1", -797.8904, 1607.169), To("ep15_1_f_abbey_2", 1087, -157));
	}
}
