//--- Melia Script -----------------------------------------------------------
// f_katyn_13_2
//
//--- Description -----------------------------------------------------------
// Sets up the f_katyn_13_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn132MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner(MonsterId.Swordmaster, 1, "SpawnPointCollection1.f_katyn_13_2", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Archermaster, 1, "SpawnPointCollection2.f_katyn_13_2", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Wizardmaster, 1, "SpawnPointCollection3.f_katyn_13_2", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Npc_Healer, 1, "SpawnPointCollection4.f_katyn_13_2", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Mushroom_Boy_Red, 40, "SpawnPointCollection5.f_katyn_13_2", TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Mushroom_Ent, 20, "SpawnPointCollection6.f_katyn_13_2", TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Mushroom_Boy_Red, 3, "SpawnPointCollection7.f_katyn_13_2", TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Mushroom_Boy_Red, 25, "SpawnPointCollection8.f_katyn_13_2", TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Swordmaster Spawn Points
		AddSpawnPoint("f_katyn_13_2", Spot(-403, -1878.91, 20), "SpawnPointCollection1.f_katyn_13_2");

		// Archermaster Spawn Points
		AddSpawnPoint("f_katyn_13_2", Spot(-313.73, -2113.53, 20), "SpawnPointCollection2.f_katyn_13_2");

		// Wizardmaster Spawn Points
		AddSpawnPoint("f_katyn_13_2", Spot(-312.74, -1747.03, 20), "SpawnPointCollection3.f_katyn_13_2");

		// Npc_Healer Spawn Points
		AddSpawnPoint("f_katyn_13_2", Spot(-192.13, -2135.66, 20), "SpawnPointCollection4.f_katyn_13_2");

		// Mushroom_Boy_Red Spawn Points
		AddSpawnPoint("f_katyn_13_2", Spot(-162.46576, -1998.9631, 9999), "SpawnPointCollection5.f_katyn_13_2");

		// Mushroom_Ent Spawn Points
		AddSpawnPoint("f_katyn_13_2", Spot(-1293.4271, 1492.9653, 9999), "SpawnPointCollection6.f_katyn_13_2");

		// Mushroom_Boy_Red Spawn Points
		AddSpawnPoint("f_katyn_13_2", Spot(-227.26, -1965.17, 300), "SpawnPointCollection7.f_katyn_13_2");
		AddSpawnPoint("f_katyn_13_2", Spot(-216.52788, -1713.0366, 30), "SpawnPointCollection8.f_katyn_13_2");
		AddSpawnPoint("f_katyn_13_2", Spot(-327.94702, -1848.8572, 30), "SpawnPointCollection8.f_katyn_13_2");
		AddSpawnPoint("f_katyn_13_2", Spot(-232.98715, -2046.5466, 30), "SpawnPointCollection8.f_katyn_13_2");
		AddSpawnPoint("f_katyn_13_2", Spot(-70.585236, -2023.15, 30), "SpawnPointCollection8.f_katyn_13_2");
		AddSpawnPoint("f_katyn_13_2", Spot(-110.33405, -1855.1942, 30), "SpawnPointCollection8.f_katyn_13_2");
		AddSpawnPoint("f_katyn_13_2", Spot(-19.71203, -1690.4005, 30), "SpawnPointCollection8.f_katyn_13_2");
		AddSpawnPoint("f_katyn_13_2", Spot(55.91324, -1930.4796, 30), "SpawnPointCollection8.f_katyn_13_2");
		AddSpawnPoint("f_katyn_13_2", Spot(-360.7234, -2090.9502, 30), "SpawnPointCollection8.f_katyn_13_2");
		AddSpawnPoint("f_katyn_13_2", Spot(-595.2442, -2054.4976, 30), "SpawnPointCollection8.f_katyn_13_2");
		AddSpawnPoint("f_katyn_13_2", Spot(-54.833138, -1476.0273, 30), "SpawnPointCollection8.f_katyn_13_2");
		AddSpawnPoint("f_katyn_13_2", Spot(-40.26753, -1268.6481, 30), "SpawnPointCollection8.f_katyn_13_2");

	}
}
