//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in EP17 Tevhrin Stalactite Cave Section 2
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep17_1_d_limestonecave_52_2WarpsScript : GeneralScript
{
	protected override void Load()
	{
		// EP17 Tevhrin Stalactite Cave Section 2 to EP17 Tevhrin Stalactite Cave Section 1
		AddWarp("EP17_1_LIMESTONECAVE_52_2_LIMESTONECAVE_52_1", -18, From("ep17_1_d_limestonecave_52_2", -1460.944, -1811.588), To("ep17_1_d_limestonecave_52_1", 582, 1942));

		// EP17 Tevhrin Stalactite Cave Section 2 to EP17 Tevhrin Stalactite Cave Section 3
		AddWarp("EP17_1_LIMESTONECAVE_52_2_LIMESTONECAVE_52_3", 90, From("ep17_1_d_limestonecave_52_2", 1287.455, -119.2307), To("ep17_1_d_limestonecave_52_3", -2538, -939));
	}
}
