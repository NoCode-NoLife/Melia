//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Saknis Plains
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_katyn_14WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Saknis Plains to Poslinkis Forest
		AddWarp("WS_KATYN14_TO_KATYN13", 93, From("f_katyn_14", 3516, -887), To("f_katyn_13", -2586, 1296));

		// Saknis Plains to Dvasia Peak
		AddWarp("KATYN14_THORN22", -79, From("f_katyn_14", -3213, -1446), To("d_thorn_22", -956, -2117));
	}
}
