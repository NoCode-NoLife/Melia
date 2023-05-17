//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Royal Mausoleum 2F
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_zachariel_33WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Royal Mausoleum 2F to Royal Mausoleum 1F
		AddWarp("ZACHARIEL33_ZACHARIEL32", 0, From("d_zachariel_33", -93, -2677), To("d_zachariel_32", 35, 2749));

		// Royal Mausoleum 2F to Royal Mausoleum 3F
		AddWarp("ZACHARIEL33_ZACHARIEL34", 239, From("d_zachariel_33", -372, 1880), To("d_zachariel_34", 3558, 124));

		// Royal Mausoleum 2F to Royal Mausoleum 2F
		AddWarp("WS_ZACHA2F_02_TO_01", 180, From("d_zachariel_33", -1532, -434), To("d_zachariel_33", -1553, 19));

		// Royal Mausoleum 2F to Royal Mausoleum 2F
		AddWarp("WS_ZACHA2F_03_TO_04", 135, From("d_zachariel_33", 515, 300), To("d_zachariel_33", 1126, 250));

		// Royal Mausoleum 2F to Royal Mausoleum 2F
		AddWarp("WS_ZACHA2F_04_TO_03", 268, From("d_zachariel_33", 989, 252), To("d_zachariel_33", 434, 252));
	}
}
