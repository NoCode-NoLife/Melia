//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Tevhrin Stalactite Cave Section 4
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_limestonecave_52_4WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Tevhrin Stalactite Cave Section 4 to Tevhrin Stalactite Cave Section 3
		AddWarp("LIMESTONECAVE_52_4_LIMESTONECAVE_52_3", 1, From("d_limestonecave_52_4", 2101.465, -2077.429), To("d_limestonecave_52_3", 1371, 1073));

		// Tevhrin Stalactite Cave Section 4 to Tevhrin Stalactite Cave Section 5
		AddWarp("LIMESTONECAVE_52_4_LIMESTONECAVE_52_5", 171, From("d_limestonecave_52_4", -1437.198, 841.9097), To("d_limestonecave_52_5", -1484, -1425));
	}
}
