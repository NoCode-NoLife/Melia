//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Astral Tower 12F
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_startower_90WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Astral Tower 12F to Astral Tower 4F
		AddWarp("D_STARTOWER_90_TO_D_STARTOWER_89", 90, From("d_startower_90", 1875, -905), To("d_startower_89", 242, -519));

		// Astral Tower 12F to Astral Tower 20F
		AddWarp("D_STARTOWER_90_TO_D_STARTOWER_91", 180, From("d_startower_90", 817.5574, 2402.892), To("d_startower_91", 2479, -1872));
	}
}
