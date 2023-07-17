//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Roxona Reconstruction Agency East Building
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_firetower_61_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Roxona Reconstruction Agency East Building to Roxona Reconstruction Agency West Building
		AddWarp("FIRETOWER612_TO_FIRETOWER611", 0, From("d_firetower_61_2", -1891.504, -1702.749), To("d_firetower_61_1", -106, 2032));
	}
}
