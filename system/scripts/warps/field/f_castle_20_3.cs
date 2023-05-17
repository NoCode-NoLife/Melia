//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Inner Wall District 8
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_castle_20_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Inner Wall District 8 to Steel Heights
		AddWarp("CASTLE_20_3_TABLELAND74", 0, From("f_castle_20_3", 329.6885, -882.7407), To("f_tableland_74", -2178, -162));

		// Inner Wall District 8 to Nheto Forest
		AddWarp("CASTLE_20_3_MAPLE_25_1", 270, From("f_castle_20_3", -1834.792, -519.5303), To("f_maple_25_1", 1478, 942));

		// Inner Wall District 8 to Taniel I Commemorative Orb
		AddWarp("CASTLE_20_3_DCAPITAL_103", 180, From("f_castle_20_3", -670.702, 1392.242), To("f_dcapital_103", 685, -1477));

		// Inner Wall District 8 to City Wall District 8
		AddWarp("CASTLE_20_3_CASTLE_20_4", 180, From("f_castle_20_3", -244.575, 1310.972), To("f_castle_20_4", 26, -1165));

		// Inner Wall District 8 to Inner Wall District 9
		AddWarp("CASTLE_20_3_CASTLE_20_2", 90, From("f_castle_20_3", 1334.023, -353.5454), To("f_castle_20_2", -1573, 50));
	}
}
