//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Astral Tower 21F
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_startower_92WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Astral Tower 21F to Astral Tower 20F
		AddWarp("D_STARTOWER_92_TO_D_STARTOWER_91", 0, From("d_startower_92", -102, 255), To("d_startower_91", -2207, 1625));
	}
}
