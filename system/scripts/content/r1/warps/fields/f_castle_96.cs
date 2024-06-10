//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Outer Wall District 14
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_castle_96WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Outer Wall District 14 to Outer Wall District 13
		AddWarp("F_CASTLE_96_TO_F_CASTLE_95", -88, From("f_castle_96", 327.2041, -1690.587), To("f_castle_95", 146, 1338));

		// Outer Wall District 14 to Outer Wall District 15
		AddWarp("F_CASTLE_96_TO_F_CASTLE_98", 180, From("f_castle_96", 1648.178, 795.5422), To("f_castle_98", 1571, -1575));
	}
}
