//--- Melia Script -----------------------------------------------------------
// test_zone
//
//--- Description -----------------------------------------------------------
// Sets up the test_zone mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class TestZoneMobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner(MonsterId.Boss_Spector_F, 1, "SpawnPointCollection1.test_zone", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Boss_Golem, 1, "SpawnPointCollection2.test_zone", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Boss_Mirtis, 1, "SpawnPointCollection3.test_zone", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Barricade_Butterfly, 1, "SpawnPointCollection4.test_zone", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Goblin_Spear, 2, "SpawnPointCollection5.test_zone", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Bubbe_Mage_Normal, 2, "SpawnPointCollection6.test_zone", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Goblin_Archer, 2, "SpawnPointCollection7.test_zone", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Boss_Spector_F Spawn Points
		AddSpawnPoint("test_zone", Spot(137, -659, 20), "SpawnPointCollection1.test_zone");
		AddSpawnPoint("test_zone", Spot(526, 564, 20), "SpawnPointCollection1.test_zone");

		// Boss_Golem Spawn Points
		AddSpawnPoint("test_zone", Spot(-558, 556, 20), "SpawnPointCollection2.test_zone");

		// Boss_Mirtis Spawn Points
		AddSpawnPoint("test_zone", Spot(-483, 171, 20), "SpawnPointCollection3.test_zone");

		// Barricade_Butterfly Spawn Points
		AddSpawnPoint("test_zone", Spot(-451, 52, 20), "SpawnPointCollection4.test_zone");

		// Goblin_Spear Spawn Points
		AddSpawnPoint("test_zone", Spot(-536.6853, -635.83356, 20), "SpawnPointCollection5.test_zone");
		AddSpawnPoint("test_zone", Spot(-561.40826, -577.36896, 20), "SpawnPointCollection5.test_zone");

		// Bubbe_Mage_Normal Spawn Points
		AddSpawnPoint("test_zone", Spot(-601.8565, -609.64197, 20), "SpawnPointCollection6.test_zone");
		AddSpawnPoint("test_zone", Spot(-495.4882, -570.1708, 20), "SpawnPointCollection6.test_zone");

		// Goblin_Archer Spawn Points
		AddSpawnPoint("test_zone", Spot(-558.76245, -518.6483, 20), "SpawnPointCollection7.test_zone");
		AddSpawnPoint("test_zone", Spot(-520.469, -590.9409, 20), "SpawnPointCollection7.test_zone");

	}
}
