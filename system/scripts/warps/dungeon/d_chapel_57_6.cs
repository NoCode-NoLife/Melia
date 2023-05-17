//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Tenet Church 1F
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_chapel_57_6WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Tenet Church 1F to Tenet Church B1
		AddWarp("CHAPEL576_CHAPEL575", 0, From("d_chapel_57_6", 744, -320), To("d_chapel_57_5", 633, -661));

		// Tenet Church 1F to Tenet Garden
		AddWarp("CHAPEL576_GELE574", 270, From("d_chapel_57_6", -1766.533, 422.5722), To("f_gele_57_4", 1284, 2047));
	}
}
