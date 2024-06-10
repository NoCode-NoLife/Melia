//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Investigation Room
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_prison_82WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Investigation Room to Workshop
		AddWarp("PRISON82_PRISON81", 179, From("d_prison_82", -930, -25), To("d_prison_81", 618, -739));
	}
}
