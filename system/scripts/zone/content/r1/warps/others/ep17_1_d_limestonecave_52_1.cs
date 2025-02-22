//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in EP17 Tevhrin Stalactite Cave Section 1
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep17_1_d_limestonecave_52_1WarpsScript : GeneralScript
{
	protected override void Load()
	{
		// EP17 Tevhrin Stalactite Cave Section 1 to Khonot Forest
		AddWarp("EP17_1_LIMESTONECAVE52_1_BRACKEN42_1", 90, From("ep17_1_d_limestonecave_52_1", 343.801, -1128.652), To("f_bracken_42_1", -1494, 237));

		// EP17 Tevhrin Stalactite Cave Section 1 to EP17 Tevhrin Stalactite Cave Section 2
		AddWarp("EP17_1_LIMESTONECAVE_52_1_LIMESTONECAVE_52_2", 227, From("ep17_1_d_limestonecave_52_1", 532.2103, 2104.772), To("ep17_1_d_limestonecave_52_2", -1387, -1726));
	}
}
