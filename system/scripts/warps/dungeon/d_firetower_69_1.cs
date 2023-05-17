//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Zima Suecourt
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_firetower_69_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Zima Suecourt to Stele Road
		AddWarp("FIRETOWER691_TO_REMAINS37", -88, From("d_firetower_69_1", -2563.125, -266.458), To("f_remains_37", 1162, -2617));
	}
}
