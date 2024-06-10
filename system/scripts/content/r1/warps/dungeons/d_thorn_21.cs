//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Kvailas Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_thorn_21WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Kvailas Forest to Sirdgela Forest
		AddWarp("THORN21_THORN20", -82, From("d_thorn_21", -412, -37), To("d_thorn_20", 2601, 921));

		// Kvailas Forest to Sunset Flag Forest
		AddWarp("THORN21_THORN23", 360, From("d_thorn_21", 985, -1550), To("d_thorn_23", -584, 779));
	}
}
