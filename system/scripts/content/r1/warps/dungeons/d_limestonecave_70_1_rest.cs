//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Sulivinas Lair
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_limestonecave_70_1_restWarpsScript : GeneralScript
{
	public override void Load()
	{
		// Sulivinas Lair to Vedas Plateau
		AddWarp("RVR_BK_REST_TO_TABLE111", -7, From("d_limestonecave_70_1_rest", 96.82263, -2115.716), To("f_tableland_11_1", -915, 420));
	}
}
