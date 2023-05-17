//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Solitary Cells
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_prison_80WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Solitary Cells to Storage
		AddWarp("PRISON80_PRISON79", 144, From("d_prison_80", 1348.961, -1690.937), To("d_prison_79", 886, 2085));

		// Solitary Cells to Workshop
		AddWarp("PRISON80_PRISON81", 90, From("d_prison_80", -1256.333, -1134.59), To("d_prison_81", -1609, -965));
	}
}
