//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Tevhrin Stalactite Cave Section 1
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_limestonecave_52_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Tevhrin Stalactite Cave Section 1 to Khonot Forest
		AddWarp("LIMESTONECAVE52_1_BRACKEN42_1", 90, From("d_limestonecave_52_1", 343.801, -1128.652), To("f_bracken_42_1", -1494, 237));

		// Tevhrin Stalactite Cave Section 1 to Tevhrin Stalactite Cave Section 2
		AddWarp("LIMESTONECAVE_52_1_LIMESTONECAVE_52_2", 227, From("d_limestonecave_52_1", 532.2103, 2104.772), To("d_limestonecave_52_2", -1387, -1726));
	}
}
