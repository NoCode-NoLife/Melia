//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Outer Wall District 15
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_castle_98WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Outer Wall District 15 to Outer Wall District 14
		AddWarp("F_CASTLE_98_TO_F_CASTLE_96", 4, From("f_castle_98", 1560.74, -1671.436), To("f_castle_96", 1631, 687));
	}
}
