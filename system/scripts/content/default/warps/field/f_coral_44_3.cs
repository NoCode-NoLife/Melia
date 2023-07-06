//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Epherotao Coast
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_coral_44_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Epherotao Coast to Iotheo Coast
		AddWarp("CORAL_44_3_TO_CORAL_44_2", 187, From("f_coral_44_3", -1046.267, 953.9401), To("f_coral_44_2", -818, -840));

		// Epherotao Coast to Elgos Monastery Main Building
		AddWarp("CORAL_44_3_TO_ABBEY_35_4", 60, From("f_coral_44_3", 1041.258, -1037.291), To("d_abbey_35_4", -526, -547));
	}
}
