//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Narvas Temple
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_abbey_22_4WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Narvas Temple to Izoliacjia Plateau
		AddWarp("ABBEY22_4_WHITETREES22_3", 90, From("d_abbey_22_4", 1850.238, 1304.251), To("f_whitetrees_22_3", -1619, 285));

		// Narvas Temple to Narvas Temple Annex
		AddWarp("ABBEY22_4_ABBEY22_5", -2, From("d_abbey_22_4", -269.5528, -1317.224), To("d_abbey_22_5", 28, 1192));
	}
}
