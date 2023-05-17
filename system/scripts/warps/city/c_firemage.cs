//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Pyromancer Master's Lab
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class c_firemageWarpsScript : GeneralScript
{
	public override void Load()
	{
		// Pyromancer Master's Lab to Klaipeda
		AddWarp("WS_FIREMAGE_KLAPEDA", 91, From("c_firemage", 253, 2), To("c_Klaipe", -52, -327));
	}
}
