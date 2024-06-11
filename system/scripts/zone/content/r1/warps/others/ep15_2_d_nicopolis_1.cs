//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Secret Laboratory
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep15_2_d_nicopolis_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Secret Laboratory to Starry Town
		AddWarp("EP15_2_D_NICOPOLIS_1_NICO811", -89, From("ep15_2_d_nicopolis_1", -369.8695, -1179.084), To("f_nicopolis_81_1", 2223, -106));
	}
}
