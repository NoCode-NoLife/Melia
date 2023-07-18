//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Mission_test
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class mission_testWarpsScript : GeneralScript
{
	public override void Load()
	{
		// Mission_test to Royal Mausoleum 3F
		AddWarp("ZACHARIEL35_1_ZACHARIEL34_1", 90, From("mission_test", -796, 99), To("d_zachariel_34", -2778, 151));
	}
}
