//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Sentry Bailey
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_underfortress_65WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Sentry Bailey to Inner Enceinte District
		AddWarp("UNDERFORTRESS65_FLASH64", -22, From("d_underfortress_65", 585.64, -2290.492), To("f_flash_64", -29, 2247));

		// Sentry Bailey to Drill Ground of Confliction
		AddWarp("UNDERFORTRESS65_UNDERFORTRESS66", 215, From("d_underfortress_65", -437.928, 1978.133), To("d_underfortress_66", 1278, -212));

		// Sentry Bailey to Sventimas Exile
		AddWarp("UNDERFORTRESS65_TABLELAND72", 168, From("d_underfortress_65", -1661.972, 1215.049), To("f_tableland_72", 2066, 213));
	}
}
