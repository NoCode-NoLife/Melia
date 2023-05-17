//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Highlander Master's Training Hall
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class c_highlanderWarpsScript : GeneralScript
{
	public override void Load()
	{
		// Highlander Master's Training Hall to Klaipeda
		AddWarp("WS_HIGHLANDER_KLAPEDA", 270, From("c_highlander", -52, 192), To("c_Klaipe", 257, -134));
	}
}
