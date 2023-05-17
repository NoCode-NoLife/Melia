//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Tevhrin Stalactite Cave Section 5
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_limestonecave_52_5WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Tevhrin Stalactite Cave Section 5 to Tevhrin Stalactite Cave Section 4
		AddWarp("LIMESTONECAVE_52_5_LIMESTONECAVE_52_4", -13, From("d_limestonecave_52_5", -1585.6, -1700.053), To("d_limestonecave_52_4", -1462, 780));
	}
}
