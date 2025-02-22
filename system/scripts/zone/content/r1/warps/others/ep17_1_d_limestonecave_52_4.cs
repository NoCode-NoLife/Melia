//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in EP17 Tevhrin Stalactite Cave Section 4
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep17_1_d_limestonecave_52_4WarpsScript : GeneralScript
{
	protected override void Load()
	{
		// EP17 Tevhrin Stalactite Cave Section 4 to EP17 Tevhrin Stalactite Cave Section 3
		AddWarp("EP17_1_LIMESTONECAVE_52_4_LIMESTONECAVE_52_3", 1, From("ep17_1_d_limestonecave_52_4", 2101.465, -2077.429), To("ep17_1_d_limestonecave_52_3", 1371, 1073));

		// EP17 Tevhrin Stalactite Cave Section 4 to EP17 Tevhrin Stalactite Cave Section 5
		AddWarp("EP17_1_LIMESTONECAVE_52_4_LIMESTONECAVE_52_5", 171, From("ep17_1_d_limestonecave_52_4", -1437.198, 841.9097), To("ep17_1_d_limestonecave_52_5", -1484, -1425));
	}
}
