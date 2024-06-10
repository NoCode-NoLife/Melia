//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Delmore Waiting Area
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep14_2_d_castle_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Delmore Waiting Area to Hidden Passage
		AddWarp("WARP_EP14_2_D_CASTLE_1_TO_EP14_2_D_CASTLE_2", -86, From("ep14_2_d_castle_1", -1007.142, 3302.728), To("ep14_2_d_castle_2", 308, -653));

		// Delmore Waiting Area to Delmore Garden
		AddWarp("WARP_EP14_2_D_CASTLE_1_TO_EP14_1_F_CASTLE_5", -11, From("ep14_2_d_castle_1", 1591.621, -495.3015), To("ep14_1_f_castle_5", -2344, -28));
	}
}
