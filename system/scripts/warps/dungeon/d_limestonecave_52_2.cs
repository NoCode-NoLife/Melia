//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Tevhrin Stalactite Cave Section 2
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_limestonecave_52_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Tevhrin Stalactite Cave Section 2 to Tevhrin Stalactite Cave Section 1
		AddWarp("LIMESTONECAVE_52_2_LIMESTONECAVE_52_1", -18, From("d_limestonecave_52_2", -1460.944, -1811.588), To("d_limestonecave_52_1", 582, 1942));

		// Tevhrin Stalactite Cave Section 2 to Tevhrin Stalactite Cave Section 3
		AddWarp("LIMESTONECAVE_52_2_LIMESTONECAVE_52_3", 90, From("d_limestonecave_52_2", 1287.455, -119.2307), To("d_limestonecave_52_3", -2538, -939));
	}
}
