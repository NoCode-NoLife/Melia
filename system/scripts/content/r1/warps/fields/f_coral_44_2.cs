//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Iotheo Coast
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_coral_44_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Iotheo Coast to Zeteor Coast
		AddWarp("CORAL_44_2_TO_CORAL_44_1", 184, From("f_coral_44_2", 313.2602, 2100.904), To("f_coral_44_1", 578, -1295));

		// Iotheo Coast to Epherotao Coast
		AddWarp("CORAL_44_2_TO_CORAL_44_3", 15, From("f_coral_44_2", -793.0478, -990.9656), To("f_coral_44_3", -1024, 867));
	}
}
