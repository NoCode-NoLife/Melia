//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Grynas Training Camp
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_katyn_45_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Grynas Training Camp to Grynas Hills
		AddWarp("KATYN45_2_KATYN45_3", 360, From("f_katyn_45_2", 1676, -2250), To("f_katyn_45_3", -73, -1650));

		// Grynas Training Camp to Grynas Trails
		AddWarp("KATYN45_2_KATYN45_1", 270, From("f_katyn_45_2", -1344, 1681), To("f_katyn_45_1", 1501, 619));
	}
}
