//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Owl Burial Ground
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_katyn_7_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Owl Burial Ground to Entrance of Kateen Forest
		AddWarp("KATYN7_2_KATYN7", 225, From("f_katyn_7_2", 228, -4282), To("f_katyn_7", -875, 3772));

		// Owl Burial Ground to Poslinkis Forest
		AddWarp("KATYN7_2_KATYN13", 250, From("f_katyn_7_2", 267.451, 1751.844), To("f_katyn_13", -61, -2127));
	}
}
