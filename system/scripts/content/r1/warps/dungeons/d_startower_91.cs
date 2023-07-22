//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Astral Tower 20F
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_startower_91WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Astral Tower 20F to Astral Tower 12F
		AddWarp("D_STARTOWER_91_TO_D_STARTOWER_90", 0, From("d_startower_91", 2482, -1924), To("d_startower_90", 820, 2348));

		// Astral Tower 20F to Astral Tower 21F
		AddWarp("D_STARTOWER_91_TO_D_STARTOWER_92", 270, From("d_startower_91", -2268, 1625), To("d_startower_92", -109, 307));
	}
}
