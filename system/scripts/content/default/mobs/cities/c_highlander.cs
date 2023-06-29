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

		// Monster Spawners --------------------------------

		AddSpawner("Spawner1.c_highlander", MonsterId.Wood_Carving_Fire, 1, TimeSpan.FromMilliseconds(60000));
		AddSpawner("Spawner2.c_highlander", MonsterId.Wood_Carving_Poison, 1, TimeSpan.FromMilliseconds(60000));
		AddSpawner("Spawner3.c_highlander", MonsterId.Wood_Carving_Lightning, 1, TimeSpan.FromMilliseconds(60000));
		AddSpawner("Spawner4.c_highlander", MonsterId.Wood_Carving_Earth, 1, TimeSpan.FromMilliseconds(60000));

		// Monster Spawn Points -----------------------------

		// Wood_Carving_Fire Spawn Points
		AddSpawnPoint("Spawner1.c_highlander", "c_highlander", Spot(-32, -31, 10));

		// Wood_Carving_Poison Spawn Points
		AddSpawnPoint("Spawner2.c_highlander", "c_highlander", Spot(28, -31, 10));

		// Wood_Carving_Lightning Spawn Points
		AddSpawnPoint("Spawner3.c_highlander", "c_highlander", Spot(146, 92, 10));

		// Wood_Carving_Earth Spawn Points
		AddSpawnPoint("Spawner4.c_highlander", "c_highlander", Spot(142, 28, 10));

	}
}
