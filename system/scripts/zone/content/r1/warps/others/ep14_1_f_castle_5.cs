//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Delmore Garden
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep14_1_f_castle_5WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Delmore Garden to Delmore Citadel
		AddWarp("WARP_EP14_1_F_CASTLE_5_TO_EP14_1_F_CASTLE_4", 90, From("ep14_1_f_castle_5", 2204.829, 62.27546), To("ep14_1_f_castle_4", -997, 2328));

		// Delmore Garden to Delmore Waiting Area
		AddWarp("WARP_EP14_1_F_CASTLE_5_TO_EP14_2_D_CASTLE_1", -82, From("ep14_1_f_castle_5", -2754.581, -23.21078), To("ep14_2_d_castle_1", 1575, -345));
	}
}
