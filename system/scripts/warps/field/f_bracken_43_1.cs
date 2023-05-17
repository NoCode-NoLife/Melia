//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Arcus Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_bracken_43_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Arcus Forest to Phamer Forest
		AddWarp("BRACKEN43_1_BRACKEN43_2", 171, From("f_bracken_43_1", 915.8717, 1613.309), To("f_bracken_43_2", -466, -1204));

		// Arcus Forest to (Closed) Pelke Shrine Ruins
		AddWarp("BRACKEN43_1_3CMLAKE83", 259, From("f_bracken_43_1", -2486, -113.5091), To("f_3cmlake_83", 62, 863));
	}
}
