//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Delmore Citadel
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep14_1_f_castle_4WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Delmore Citadel to Delmore Outskirts
		AddWarp("WARP_EP14_1_F_CASTLE_4_TO_EP14_1_F_CASTLE_3", 5, From("ep14_1_f_castle_4", 1112.219, -2226.321), To("ep14_1_f_castle_3", 1143, 232));

		// Delmore Citadel to Delmore Garden
		AddWarp("WARP_EP14_1_F_CASTLE_4_TO_EP14_1_F_CASTLE_5", -83, From("ep14_1_f_castle_4", -1087.409, 2335.279), To("ep14_1_f_castle_5", 2070, 61));
	}
}
