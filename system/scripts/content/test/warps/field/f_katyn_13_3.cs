//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Arrow Path
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_katyn_13_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Arrow Path to (Closed) Letas Stream
		AddWarp("KATYN13_3_KATYN12", 90, From("f_katyn_13_3", 2393, 294), To("f_katyn_12", -1527, 2245));

		// Arrow Path to Ramstis Ridge
		AddWarp("KATYN13_3_ROKAS25", 270, From("f_katyn_13_3", -1921, -350), To("f_rokas_25", -925, 232));
	}
}
