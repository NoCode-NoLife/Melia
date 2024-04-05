//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Zachariel Crossroads
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_rokas_31WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Zachariel Crossroads to King's Plateau
		AddWarp("ROKAS31_ROKAS30", 139, From("f_rokas_31", 940, -998), To("f_rokas_30", -1669, -134));

		// Zachariel Crossroads to Royal Mausoleum 1F
		AddWarp("ROKAS31_ZACHARIEL32", 225, From("f_rokas_31", -1271, 715), To("d_zachariel_32", 32, -2294));

		// Zachariel Crossroads to Stele Road
		AddWarp("ROKAS31_REMAINS37", -49, From("f_rokas_31", 470, -1399), To("f_remains_37", -1322, -2902));
	}
}
