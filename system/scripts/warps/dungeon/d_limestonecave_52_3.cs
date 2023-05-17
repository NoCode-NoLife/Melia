//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Tevhrin Stalactite Cave Section 3
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_limestonecave_52_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Tevhrin Stalactite Cave Section 3 to Tevhrin Stalactite Cave Section 2
		AddWarp("LIMESTONECAVE_52_3_LIMESTONECAVE_52_2", -67, From("d_limestonecave_52_3", -2648.488, -965.5466), To("d_limestonecave_52_2", 1080, -120));

		// Tevhrin Stalactite Cave Section 3 to Tevhrin Stalactite Cave Section 4
		AddWarp("LIMESTONECAVE_52_3_LIMESTONECAVE_52_4", 172, From("d_limestonecave_52_3", 1366.117, 1183.95), To("d_limestonecave_52_4", 2095, -1933));
	}
}
