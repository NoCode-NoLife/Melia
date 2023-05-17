//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Elgos Monastery Main Building
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_abbey_35_4WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Elgos Monastery Main Building to Galeed Plateau
		AddWarp("ABBEY_35_4_TO_ROKAS_36_1", -85, From("d_abbey_35_4", -1715.557, -549.7579), To("f_rokas_36_1", 1675, 364));

		// Elgos Monastery Main Building to Elgos Monastery Annex
		AddWarp("ABBEY_35_4_ABBEY_35_3", 178, From("d_abbey_35_4", 16.46743, 1459.366), To("d_abbey_35_3", 3, -1489));

		// Elgos Monastery Main Building to Epherotao Coast
		AddWarp("ABBEY_35_4_TO_CORAL_44_3", 1, From("d_abbey_35_4", -519.9556, -683.3889), To("f_coral_44_3", 939, -933));
	}
}
