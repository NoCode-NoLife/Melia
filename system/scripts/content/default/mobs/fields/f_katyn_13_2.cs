//--- Melia Script -----------------------------------------------------------
// f_katyn_13_2
//
//--- Description -----------------------------------------------------------
// Sets up the f_katyn_13_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn132MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("Spawner1.f_katyn_13_2", MonsterId.Swordmaster, 1, TimeSpan.FromMilliseconds(60000));
		AddSpawner("Spawner2.f_katyn_13_2", MonsterId.Archermaster, 1, TimeSpan.FromMilliseconds(60000));
		AddSpawner("Spawner3.f_katyn_13_2", MonsterId.Wizardmaster, 1, TimeSpan.FromMilliseconds(60000));
		AddSpawner("Spawner4.f_katyn_13_2", MonsterId.Npc_Healer, 1, TimeSpan.FromMilliseconds(60000));
		AddSpawner("Spawner5.f_katyn_13_2", MonsterId.Mushroom_Boy_Red, 40, TimeSpan.FromMilliseconds(15000));
		AddSpawner("Spawner6.f_katyn_13_2", MonsterId.Mushroom_Ent, 20, TimeSpan.FromMilliseconds(15000));
		AddSpawner("Spawner7.f_katyn_13_2", MonsterId.Mushroom_Boy_Red, 3, TimeSpan.FromMilliseconds(20000));
		AddSpawner("Spawner8.f_katyn_13_2", MonsterId.Mushroom_Boy_Red, 25, TimeSpan.FromMilliseconds(5000));

		// Monster Spawn Points -----------------------------

		// Swordmaster Spawn Points
		AddSpawnPoint("Spawner1.f_katyn_13_2", "f_katyn_13_2", Spot(-403, -1878.91, 20));

		// Archermaster Spawn Points
		AddSpawnPoint("Spawner2.f_katyn_13_2", "f_katyn_13_2", Spot(-313.73, -2113.53, 20));

		// Wizardmaster Spawn Points
		AddSpawnPoint("Spawner3.f_katyn_13_2", "f_katyn_13_2", Spot(-312.74, -1747.03, 20));

		// Npc_Healer Spawn Points
		AddSpawnPoint("Spawner4.f_katyn_13_2", "f_katyn_13_2", Spot(-192.13, -2135.66, 20));

		// Mushroom_Boy_Red Spawn Points
		AddSpawnPoint("Spawner5.f_katyn_13_2", "f_katyn_13_2", Spot(-162.46576, -1998.9631, 9999));

		// Mushroom_Ent Spawn Points
		AddSpawnPoint("Spawner6.f_katyn_13_2", "f_katyn_13_2", Spot(-1293.4271, 1492.9653, 9999));

		// Mushroom_Boy_Red Spawn Points
		AddSpawnPoint("Spawner7.f_katyn_13_2", "f_katyn_13_2", Spot(-227.26, -1965.17, 300));
		AddSpawnPoint("Spawner8.f_katyn_13_2", "f_katyn_13_2", Spot(-216.52788, -1713.0366, 30));
		AddSpawnPoint("Spawner8.f_katyn_13_2", "f_katyn_13_2", Spot(-327.94702, -1848.8572, 30));
		AddSpawnPoint("Spawner8.f_katyn_13_2", "f_katyn_13_2", Spot(-232.98715, -2046.5466, 30));
		AddSpawnPoint("Spawner8.f_katyn_13_2", "f_katyn_13_2", Spot(-70.585236, -2023.15, 30));
		AddSpawnPoint("Spawner8.f_katyn_13_2", "f_katyn_13_2", Spot(-110.33405, -1855.1942, 30));
		AddSpawnPoint("Spawner8.f_katyn_13_2", "f_katyn_13_2", Spot(-19.71203, -1690.4005, 30));
		AddSpawnPoint("Spawner8.f_katyn_13_2", "f_katyn_13_2", Spot(55.91324, -1930.4796, 30));
		AddSpawnPoint("Spawner8.f_katyn_13_2", "f_katyn_13_2", Spot(-360.7234, -2090.9502, 30));
		AddSpawnPoint("Spawner8.f_katyn_13_2", "f_katyn_13_2", Spot(-595.2442, -2054.4976, 30));
		AddSpawnPoint("Spawner8.f_katyn_13_2", "f_katyn_13_2", Spot(-54.833138, -1476.0273, 30));
		AddSpawnPoint("Spawner8.f_katyn_13_2", "f_katyn_13_2", Spot(-40.26753, -1268.6481, 30));

	}
}
