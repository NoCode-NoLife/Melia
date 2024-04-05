//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Hidden Passage
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep14_2_d_castle_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Hidden Passage to Delmore Waiting Area
		AddWarp("WARP_EP14_2_D_CASTLE_2_TO_EP14_2_D_CASTLE_1", -89, From("ep14_2_d_castle_2", 235.9232, -656.8378), To("ep14_2_d_castle_1", -923, 3287));
	}
}
