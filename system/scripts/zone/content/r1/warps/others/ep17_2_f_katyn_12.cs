//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in EP17 Letas Stream
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep17_2_f_katyn_12WarpsScript : GeneralScript
{
	protected override void Load()
	{
		// EP17 Letas Stream to EP17 Karolis Springs
		AddWarp("EP17_2_KATYN_12_KATYN_10", 0, From("ep17_2_f_katyn_12", 91.85896, -1597.516), To("ep17_2_f_katyn_10", -2072, 507));

		// EP17 Letas Stream to EP17 Saknis Plains
		AddWarp("EP17_2_KATYN_12_KATYN_14", 115, From("ep17_2_f_katyn_12", 2241.357, 1140.637), To("ep17_2_f_katyn_14", 3391, -991));
	}
}
