//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Istora Ruins
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_remains_37_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Istora Ruins to Namu Temple Ruins
		AddWarp("REMAINS37_3_REMAINS37_2", 1, From("f_remains_37_3", -544.7141, -1603.678), To("f_remains_37_2", -796, 1517));

		// Istora Ruins to Starry Town
		AddWarp("REMAINS37_3_NICO811", 165, From("f_remains_37_3", -702.9353, 764.9445), To("f_nicopolis_81_1", 1709, -1384));
	}
}
