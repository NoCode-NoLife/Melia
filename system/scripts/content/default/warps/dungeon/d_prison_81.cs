//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Workshop
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_prison_81WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Workshop to Solitary Cells
		AddWarp("PRISON81_PRISON80", 269, From("d_prison_81", -1688.655, -961.2255), To("d_prison_80", -1292, -1033));

		// Workshop to Investigation Room
		AddWarp("PRISON81_PRISON82", 270, From("d_prison_81", 499.2342, -739.9202), To("d_prison_82", -921, -114));
	}
}
