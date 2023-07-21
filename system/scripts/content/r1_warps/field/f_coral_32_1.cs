//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Cranto Coast
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_coral_32_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Cranto Coast to Igti Coast
		AddWarp("CORAL32_1_CORAL32_2", 218, From("f_coral_32_1", -346.6219, 910.3648), To("f_coral_32_2", 0, 0));

		// Cranto Coast to Barha Forest
		AddWarp("CORAL32_1_ORCHARD34_3", 8, From("f_coral_32_1", -152.8878, -1692.452), To("f_orchard_34_3", 1134, -933));
	}
}
