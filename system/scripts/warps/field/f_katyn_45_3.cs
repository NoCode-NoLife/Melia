//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Grynas Hills
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_katyn_45_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Grynas Hills to Grynas Training Camp
		AddWarp("KATYN45_3_KATYN45_2", 360, From("f_katyn_45_3", -79, -1799), To("f_katyn_45_2", 1685, -2123));
	}
}
