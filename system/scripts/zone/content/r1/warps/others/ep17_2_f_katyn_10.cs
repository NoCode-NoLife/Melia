//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in EP17 Karolis Springs
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep17_2_f_katyn_10WarpsScript : GeneralScript
{
	protected override void Load()
	{
		// EP17 Karolis Springs to Entrance of Kateen Forest
		AddWarp("EP17_2_KATYN_10_KATYN_7", 90, From("ep17_2_f_katyn_10", 4560.204, -1508.193), To("f_katyn_7", 1450, -3435));

		// EP17 Karolis Springs to EP17 Letas Stream
		AddWarp("EP17_2_KATYN_10_KATYN_12", 270, From("ep17_2_f_katyn_10", -2196.182, 467.24), To("ep17_2_f_katyn_12", 39, -1429));
	}
}
