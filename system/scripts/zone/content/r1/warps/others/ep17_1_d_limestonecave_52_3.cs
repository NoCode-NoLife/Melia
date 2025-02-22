//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in EP17 Tevhrin Stalactite Cave Section 3
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep17_1_d_limestonecave_52_3WarpsScript : GeneralScript
{
	protected override void Load()
	{
		// EP17 Tevhrin Stalactite Cave Section 3 to EP17 Tevhrin Stalactite Cave Section 2
		AddWarp("EP17_1_LIMESTONECAVE_52_3_LIMESTONECAVE_52_2", -67, From("ep17_1_d_limestonecave_52_3", -2648.488, -965.5466), To("ep17_1_d_limestonecave_52_2", 1080, -120));

		// EP17 Tevhrin Stalactite Cave Section 3 to EP17 Tevhrin Stalactite Cave Section 4
		AddWarp("EP17_1_LIMESTONECAVE_52_3_LIMESTONECAVE_52_4", 172, From("ep17_1_d_limestonecave_52_3", 1366.117, 1183.95), To("ep17_1_d_limestonecave_52_4", 2095, -1933));
	}
}
