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
		AddMonsterPopulation("c_highlander", "population_wood_carving_fire_1", 1);
		AddMonsterPopulation("c_highlander", "population_wood_carving_poison_2", 1);
		AddMonsterPopulation("c_highlander", "population_wood_carving_lightning_3", 1);
		AddMonsterPopulation("c_highlander", "population_wood_carving_earth_4", 1);

		// Monster Spawners
		AddSpawner(MonsterId.Wood_Carving_Fire, "population_wood_carving_fire_1", TimeSpan.FromMilliseconds(60000), "c_highlander", Spot(-32, -31, 10));
		AddSpawner(MonsterId.Wood_Carving_Poison, "population_wood_carving_poison_2", TimeSpan.FromMilliseconds(60000), "c_highlander", Spot(28, -31, 10));
		AddSpawner(MonsterId.Wood_Carving_Lightning, "population_wood_carving_lightning_3", TimeSpan.FromMilliseconds(60000), "c_highlander", Spot(146, 92, 10));
		AddSpawner(MonsterId.Wood_Carving_Earth, "population_wood_carving_earth_4", TimeSpan.FromMilliseconds(60000), "c_highlander", Spot(142, 28, 10));

	}
}
