//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Storage
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_prison_79WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Storage to Kalejimas Visiting Room
		AddWarp("PRISON79_PRISON78", 90, From("d_prison_79", 1582.994, -13.46036), To("d_prison_78", -1166, 2543));

		// Storage to Solitary Cells
		AddWarp("PRISON79_PRISON80", -89, From("d_prison_79", 802.4025, 2072.968), To("d_prison_80", 1318, -1770));
	}
}
