//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in City Wall District 8
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_castle_20_4WarpsScript : GeneralScript
{
	public override void Load()
	{
		// City Wall District 8 to Inner Wall District 8
		AddWarp("CASTLE_20_4_CASTLE_20_3", 0, From("f_castle_20_4", 56.53034, -1306.578), To("f_castle_20_3", -240, 1176));

		// City Wall District 8 to Taniel I Commemorative Orb
		AddWarp("CASTLE_20_4_DCAPITAL_103", 270, From("f_castle_20_4", -1641.155, 389.1683), To("f_dcapital_103", 1681, -540));

		// City Wall District 8 to Jeromel Park
		AddWarp("CASTLE_20_4_DCAPITAL_20_5", 180, From("f_castle_20_4", -347.1639, 1269.787), To("f_dcapital_20_5", -1191, -805));

		// City Wall District 8 to Vienibe Shelter
		AddWarp("CASTLE_20_4_CASTLE_97", 135, From("f_castle_20_4", 1506.563, 1321.612), To("f_castle_97", 0, 0));
	}
}
