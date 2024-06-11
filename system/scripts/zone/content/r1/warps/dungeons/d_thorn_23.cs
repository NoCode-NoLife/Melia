//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Sunset Flag Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_thorn_23WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Sunset Flag Forest to Dvasia Peak
		AddWarp("THORN23_THORN22", 252, From("d_thorn_23", -2159, -2969), To("d_thorn_22", 952, 1015));

		// Sunset Flag Forest to Gateway of the Great King
		AddWarp("THORN23_ROKAS24", 163, From("d_thorn_23", 2420, 2163), To("f_rokas_24", 886, -2885));

		// Sunset Flag Forest to Sunset Flag Forest
		AddWarp("THORN23_1_THORN23_2", 215, From("d_thorn_23", -1528, -1792), To("d_thorn_23", -1655, -1542));

		// Sunset Flag Forest to Sunset Flag Forest
		AddWarp("THORN23_2_THORN23_1", 25, From("d_thorn_23", -1631, -1637), To("d_thorn_23", -1458, -1875));

		// Sunset Flag Forest to Sunset Flag Forest
		AddWarp("THORN23_2_THORN23_3", 144, From("d_thorn_23", 2295, 937), To("d_thorn_23", 2670, 1029));

		// Sunset Flag Forest to Sunset Flag Forest
		AddWarp("THORN23_3_THORN23_2", -83, From("d_thorn_23", 2581, 1036), To("d_thorn_23", 2206, 868));

		// Sunset Flag Forest to Kvailas Forest
		AddWarp("THORN23_THORN21", 180, From("d_thorn_23", -588, 899), To("d_thorn_21", 988, -1485));
	}
}
