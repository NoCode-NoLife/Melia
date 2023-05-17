//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Astral Tower 1F
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_startower_88WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Astral Tower 1F to Barynwell 87 Waters
		AddWarp("D_STARTOWER_88_TO_F_3CMLAKE_87", 180, From("d_startower_88", 2359, 1769), To("f_3cmlake_87", 46, 2274));

		// Astral Tower 1F to Astral Tower 4F
		AddWarp("D_STARTOWER_88_TO_D_STARTOWER_89", 170, From("d_startower_88", 1208, 3327), To("d_startower_89", 1286, -1940));
	}
}
