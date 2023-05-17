//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Viltis Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_thorn_39_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Viltis Forest to Glade Hillroad
		AddWarp("THORN391_TO_THORN392", 156, From("d_thorn_39_1", -744.733, 1666.92), To("d_thorn_39_2", -46, -1758));

		// Viltis Forest to Sirdgela Forest
		AddWarp("THORN391_TO_THORN20", -18, From("d_thorn_39_1", 1206.221, -2884.05), To("d_thorn_20", -916.3317, 1656.262));
	}
}
