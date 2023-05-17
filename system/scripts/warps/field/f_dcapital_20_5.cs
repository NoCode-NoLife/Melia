//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Jeromel Park
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_dcapital_20_5WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Jeromel Park to City Wall District 8
		AddWarp("DCAPITAL_20_5_TO_CASTLE_20_4", -87, From("f_dcapital_20_5", -1309.768, -805.1779), To("f_castle_20_4", -337, 1173));

		// Jeromel Park to Jonael Commemorative Orb
		AddWarp("DCAPITAL_20_5_TO_DCAPITAL_20_6", 90, From("f_dcapital_20_5", 1415.3, -711.64), To("f_dcapital_20_6", -456, -500));
	}
}
