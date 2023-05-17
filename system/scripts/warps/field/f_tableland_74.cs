//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Steel Heights
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_tableland_74WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Steel Heights to Kadumel Cliff
		AddWarp("TABLELAND74_TABLELAND73", 0, From("f_tableland_74", -2359.357, -1628.717), To("f_tableland_73", 1435, 1491));

		// Steel Heights to Kalejimas Visiting Room
		AddWarp("TABLELAND74_PRISON78", 168, From("f_tableland_74", 2040.011, 2474.699), To("d_prison_78", 1045, -734));

		// Steel Heights to Inner Wall District 8
		AddWarp("TABLELAND74_CASTLE_20_3", 210, From("f_tableland_74", -2255.49, -90.51265), To("f_castle_20_3", 338, -767));
	}
}
