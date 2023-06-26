//--- Melia Script -----------------------------------------------------------
// c_highlander
//
//--- Description -----------------------------------------------------------
// Sets up the c_highlander mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class CHighlanderMobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Populations
		var WoodCarvingFire_1_1 = AddMonsterGenerator(MonsterId.Wood_Carving_Fire, "c_highlander", 1);
		var WoodCarvingPoison_2_1 = AddMonsterGenerator(MonsterId.Wood_Carving_Poison, "c_highlander", 1);
		var WoodCarvingLightning_3_1 = AddMonsterGenerator(MonsterId.Wood_Carving_Lightning, "c_highlander", 1);
		var WoodCarvingEarth_4_1 = AddMonsterGenerator(MonsterId.Wood_Carving_Earth, "c_highlander", 1);

		// Monster Spawners
		AddSpawnPoint(WoodCarvingFire_1_1, TimeSpan.FromMilliseconds(60000), "c_highlander", Spot(-32, -31, 10));
		AddSpawnPoint(WoodCarvingPoison_2_1, TimeSpan.FromMilliseconds(60000), "c_highlander", Spot(28, -31, 10));
		AddSpawnPoint(WoodCarvingLightning_3_1, TimeSpan.FromMilliseconds(60000), "c_highlander", Spot(146, 92, 10));
		AddSpawnPoint(WoodCarvingEarth_4_1, TimeSpan.FromMilliseconds(60000), "c_highlander", Spot(142, 28, 10));

	}
}
