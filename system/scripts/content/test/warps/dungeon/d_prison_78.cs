//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Kalejimas Visiting Room
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_prison_78WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Kalejimas Visiting Room to Steel Heights
		AddWarp("PRISON78_TABLELAND74", 179, From("d_prison_78", 1046.767, -565.5245), To("f_tableland_74", 2001, 2357));

		// Kalejimas Visiting Room to Storage
		AddWarp("PRISON78_PRISON79", 225, From("d_prison_78", -1238.625, 2618.246), To("d_prison_79", 1472, -4));
	}
}
