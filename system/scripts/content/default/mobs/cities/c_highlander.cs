//--- Melia Script -----------------------------------------------------------
// c_highlander
//
//--- Description -----------------------------------------------------------
// Sets up the c_highlander mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class CHighlanderMobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner(MonsterId.Wood_Carving_Fire, 1, "SpawnPointCollection1.c_highlander", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Wood_Carving_Poison, 1, "SpawnPointCollection2.c_highlander", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Wood_Carving_Lightning, 1, "SpawnPointCollection3.c_highlander", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Wood_Carving_Earth, 1, "SpawnPointCollection4.c_highlander", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Wood_Carving_Fire Spawn Points
		AddSpawnPoint("c_highlander", Spot(-32, -31, 10), "SpawnPointCollection1.c_highlander");

		// Wood_Carving_Poison Spawn Points
		AddSpawnPoint("c_highlander", Spot(28, -31, 10), "SpawnPointCollection2.c_highlander");

		// Wood_Carving_Lightning Spawn Points
		AddSpawnPoint("c_highlander", Spot(146, 92, 10), "SpawnPointCollection3.c_highlander");

		// Wood_Carving_Earth Spawn Points
		AddSpawnPoint("c_highlander", Spot(142, 28, 10), "SpawnPointCollection4.c_highlander");

	}
}
