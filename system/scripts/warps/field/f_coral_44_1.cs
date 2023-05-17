//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Zeteor Coast
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_coral_44_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Zeteor Coast to Phamer Forest
		AddWarp("CORAL_44_1_TO_BRACKEN_43_2", 263, From("f_coral_44_1", -1728.212, 889.5302), To("f_bracken_43_2", 1421, 1248));

		// Zeteor Coast to Iotheo Coast
		AddWarp("CORAL_44_1_TO_CORAL_44_2", 42, From("f_coral_44_1", 644.8358, -1374.031), To("f_coral_44_2", 335, 2027));
	}
}
