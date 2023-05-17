//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Astral Tower 4F
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_startower_89WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Astral Tower 4F to Astral Tower 1F
		AddWarp("D_STARTOWER_89_TO_D_STARTOWER_88", -70, From("d_startower_89", 1230, -1978), To("d_startower_88", 1193, 3276));

		// Astral Tower 4F to Astral Tower 12F
		AddWarp("D_STARTOWER_89_TO_D_STARTOWER_90", 270, From("d_startower_89", 188, -521), To("d_startower_90", 1814, -904));
	}
}
