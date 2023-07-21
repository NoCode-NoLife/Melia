//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Gele Plateau
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_gele_57_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Gele Plateau to Srautas Gorge
		AddWarp("GELE572_GELE571", 0, From("f_gele_57_2", 35, -1102), To("f_gele_57_1", 642, 1364));

		// Gele Plateau to Nefritas Cliff
		AddWarp("GELE572_GELE573", 180, From("f_gele_57_2", 100, 1532), To("f_gele_57_3", -508, -1507));

		// Gele Plateau to Grynas Trails
		AddWarp("GELE57_2_KATYN45_1", 123, From("f_gele_57_2", 1579.198, -335.6334), To("f_katyn_45_1", -2388, -554));
	}
}
