//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Sanctuary
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_cathedral_56WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Sanctuary to Grand Corridor
		AddWarp("CATHEDRAL56_CATHEDRAL54", 94, From("d_cathedral_56", 2216.753, 471.9221), To("d_cathedral_54", 1050, 594));
	}
}
