//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in EP17 Tevhrin Stalactite Cave Section 5
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep17_1_d_limestonecave_52_5WarpsScript : GeneralScript
{
	protected override void Load()
	{
		// EP17 Tevhrin Stalactite Cave Section 5 to EP17 Tevhrin Stalactite Cave Section 4
		AddWarp("EP17_1_LIMESTONECAVE_52_5_LIMESTONECAVE_52_4", -13, From("ep17_1_d_limestonecave_52_5", -1585.6, -1700.053), To("ep17_1_d_limestonecave_52_4", -1462, 780));
	}
}
