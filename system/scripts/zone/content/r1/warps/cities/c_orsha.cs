//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Orsha
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class c_orshaWarpsScript : GeneralScript
{
	public override void Load()
	{
		// Orsha to Lemprasa Pond
		AddWarp("WARP_ORSHA_TO_EP13_F_SIAULIAI_1", 258, From("c_orsha", -1422.59, 368.31), To("ep13_f_siauliai_1", 1960, 281));
	}
}
