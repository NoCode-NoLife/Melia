//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Roxona Reconstruction Agency West Building
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_firetower_61_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Roxona Reconstruction Agency West Building to Apsimesti Crossroads
		AddWarp("FIRETOWER611_TO_PILGRIMROAD52", 0, From("d_firetower_61_1", -300.3336, -2322.191), To("f_pilgrimroad_52", -1716, -27));

		// Roxona Reconstruction Agency West Building to Roxona Reconstruction Agency East Building
		AddWarp("FIRETOWER611_TO_FIRETOWER612", 180, From("d_firetower_61_1", -113.8056, 2144.53), To("d_firetower_61_2", -1895, -1614));
	}
}
