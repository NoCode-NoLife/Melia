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

		AddSpawner("Spawner1.c_highlander", MonsterId.Wood_Carving_Fire, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("Spawner2.c_highlander", MonsterId.Wood_Carving_Poison, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("Spawner3.c_highlander", MonsterId.Wood_Carving_Lightning, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("Spawner4.c_highlander", MonsterId.Wood_Carving_Earth, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Wood_Carving_Fire Spawn Points
		AddSpawnPoint("c_highlander", Spot(-32, -31, 10), "Spawner1.c_highlander");

		// Wood_Carving_Poison Spawn Points
		AddSpawnPoint("c_highlander", Spot(28, -31, 10), "Spawner2.c_highlander");

		// Wood_Carving_Lightning Spawn Points
		AddSpawnPoint("c_highlander", Spot(146, 92, 10), "Spawner3.c_highlander");

		// Wood_Carving_Earth Spawn Points
		AddSpawnPoint("c_highlander", Spot(142, 28, 10), "Spawner4.c_highlander");

	}
}
