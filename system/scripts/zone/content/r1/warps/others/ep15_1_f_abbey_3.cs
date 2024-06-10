//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in The Confessional
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep15_1_f_abbey_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// The Confessional to Novaha Library
		AddWarp("WARP_EP15_1_FABBEY_3_TO_EP15_1_FABBEY_2", 5, From("ep15_1_f_abbey_3", 4.200291, -1409.785), To("ep15_1_f_abbey_2", -1508, 1726));
	}
}
