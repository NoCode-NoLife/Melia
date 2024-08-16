//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Phamer Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_bracken_43_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Phamer Forest to Zeteor Coast
		AddWarp("BRACKEN432_CORAL441", 155, From("f_bracken_43_2", 1453.111, 1283.441), To("f_coral_44_1", -1645, 874));

		// Phamer Forest to Ziburynas Forest
		AddWarp("BRACKEN432_BRACKEN433", 106, From("f_bracken_43_2", 1499.943, -490.5141), To("f_bracken_43_3", 317, 1586));

		// Phamer Forest to Arcus Forest
		AddWarp("BRACKEN432_BRACKEN431", 2, From("f_bracken_43_2", -448.0723, -1270.588), To("f_bracken_43_1", 916, 1548));
	}
}
