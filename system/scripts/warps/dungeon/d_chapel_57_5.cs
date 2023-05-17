//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Tenet Church B1
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_chapel_57_5WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Tenet Church B1 to Tenet Garden
		AddWarp("CHAPEL575_GELE574", 180, From("d_chapel_57_5", -1258, 1163), To("f_gele_57_4", 1105, 1982));

		// Tenet Church B1 to Tenet Church 1F
		AddWarp("CHAPEL575_CHAPEL576", 180, From("d_chapel_57_5", 627, -565), To("d_chapel_57_6", 746, -251));
	}
}
