//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Royal Mausoleum 1F
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_zachariel_32WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Royal Mausoleum 1F to Zachariel Crossroads
		AddWarp("ZACHARIEL32_ROKAS31", 0, From("d_zachariel_32", 30, -2423), To("f_rokas_31", -1186, 638));

		// Royal Mausoleum 1F to Royal Mausoleum 2F
		AddWarp("ZACHARIEL32_ZACHARIEL33", 179, From("d_zachariel_32", 32, 2863), To("d_zachariel_33", -92, -2579));

		// Royal Mausoleum 1F to Ramstis Ridge
		AddWarp("ZACHARIEL32_ROKAS25", 262, From("d_zachariel_32", -1418, -2199), To("f_rokas_25", 2112, -344));

		// Royal Mausoleum 1F to Tiltas Valley
		AddWarp("ZACHARIEL32_ROKAS28", -86, From("d_zachariel_32", 1080, -2192), To("f_rokas_28", 1662, 1981));
	}
}
