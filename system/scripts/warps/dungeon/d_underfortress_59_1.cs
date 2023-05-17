//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Royal Mausoleum Workers Lodge
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_underfortress_59_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Royal Mausoleum Workers Lodge to Tiltas Valley
		AddWarp("UNDERF591_TO_ROKAS28", 270, From("d_underfortress_59_1", -90.56654, -478.4176), To("f_rokas_28", 1338, 2240));

		// Royal Mausoleum Workers Lodge to Royal Mausoleum Constructors' Chapel
		AddWarp("UNDERF591_TO_UNDERF592", 180, From("d_underfortress_59_1", 626.9723, 481.9314), To("d_underfortress_59_2", 305, -338));
	}
}
