//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Sirdgela Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_thorn_20WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Sirdgela Forest to Gate Route
		AddWarp("THORN20_THORN19", 260, From("d_thorn_20", -1549, -1884), To("d_thorn_19", 2038, -948));

		// Sirdgela Forest to Kvailas Forest
		AddWarp("THORN20_THORN21", 167, From("d_thorn_20", 2575, 1060), To("d_thorn_21", -286, -60));

		// Sirdgela Forest to Passage of the Recluse
		AddWarp("THORN20_PCATHEDRAL1", 180, From("d_thorn_20", 3049, -816), To("p_cathedral_1", -427, -963));

		// Sirdgela Forest to Dvasia Peak
		AddWarp("THORN20_THORN22", 270, From("d_thorn_20", 1241, -1506), To("d_thorn_22", -2141, -1434));

		// Sirdgela Forest to Viltis Forest
		AddWarp("THORN20_THORN39_1", 190, From("d_thorn_20", -911, 1739), To("d_thorn_39_1", 1214, -2794));
	}
}
