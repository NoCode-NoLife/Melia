//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Dvasia Peak
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_thorn_22WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Dvasia Peak to Saknis Plains
		AddWarp("THORN22_KATYN14", 0, From("d_thorn_22", -986, -2219), To("f_katyn_14", -3129, -1446));

		// Dvasia Peak to Sunset Flag Forest
		AddWarp("THORN22_THORN23", 156, From("d_thorn_22", 987, 1109), To("d_thorn_23", -2068, -2872));

		// Dvasia Peak to Dvasia Peak
		AddWarp("THORN22_1_THORN22_2", 183, From("d_thorn_22", -1020, -891), To("d_thorn_22", -1296, -163));

		// Dvasia Peak to Dvasia Peak
		AddWarp("THORN22_2_THORN22_1", 23, From("d_thorn_22", -1216.202, -386.6535), To("d_thorn_22", -987, -1142));

		// Dvasia Peak to Dvasia Peak
		AddWarp("THORN22_2_THORN22_3", 162, From("d_thorn_22", -1035, 664), To("d_thorn_22", -453, 903));

		// Dvasia Peak to Dvasia Peak
		AddWarp("THORN22_3_THORN22_2", -30, From("d_thorn_22", -689, 846), To("d_thorn_22", -1172, 452));

		// Dvasia Peak to Sirdgela Forest
		AddWarp("THORN22_THORN20", -85, From("d_thorn_22", -2299, -1493), To("d_thorn_20", 1371, -1502));
	}
}
