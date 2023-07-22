//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Narvas Temple Annex
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_abbey_22_5WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Narvas Temple Annex to Narvas Temple
		AddWarp("ABBEY22_5_ABBEY22_4", 176, From("d_abbey_22_5", 28.36045, 1276.747), To("d_abbey_22_4", -269, -1218));

		// Narvas Temple Annex to Mishekan Forest
		AddWarp("ABBEY22_5_WHITETREES56_1", -3, From("d_abbey_22_5", -1461.984, -1121.876), To("f_whitetrees_56_1", -1210, 321));
	}
}
