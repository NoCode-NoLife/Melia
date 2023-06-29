//--- Melia Script -----------------------------------------------------------
// test_zone
//
//--- Description -----------------------------------------------------------
// Sets up the test_zone mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class TestZoneMobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("Spawner1.test_zone", MonsterId.Boss_Spector_F, 1, TimeSpan.FromMilliseconds(60000));
		AddSpawner("Spawner2.test_zone", MonsterId.Boss_Golem, 1, TimeSpan.FromMilliseconds(60000));
		AddSpawner("Spawner3.test_zone", MonsterId.Boss_Mirtis, 1, TimeSpan.FromMilliseconds(60000));
		AddSpawner("Spawner4.test_zone", MonsterId.Barricade_Butterfly, 1, TimeSpan.FromMilliseconds(60000));
		AddSpawner("Spawner5.test_zone", MonsterId.Goblin_Spear, 2, TimeSpan.FromMilliseconds(60000));
		AddSpawner("Spawner6.test_zone", MonsterId.Bubbe_Mage_Normal, 2, TimeSpan.FromMilliseconds(60000));
		AddSpawner("Spawner7.test_zone", MonsterId.Goblin_Archer, 2, TimeSpan.FromMilliseconds(60000));

		// Monster Spawn Points -----------------------------

		// Boss_Spector_F Spawn Points
		AddSpawnPoint("Spawner1.test_zone", "test_zone", Spot(137, -659, 20));
		AddSpawnPoint("Spawner1.test_zone", "test_zone", Spot(526, 564, 20));

		// Boss_Golem Spawn Points
		AddSpawnPoint("Spawner2.test_zone", "test_zone", Spot(-558, 556, 20));

		// Boss_Mirtis Spawn Points
		AddSpawnPoint("Spawner3.test_zone", "test_zone", Spot(-483, 171, 20));

		// Barricade_Butterfly Spawn Points
		AddSpawnPoint("Spawner4.test_zone", "test_zone", Spot(-451, 52, 20));

		// Goblin_Spear Spawn Points
		AddSpawnPoint("Spawner5.test_zone", "test_zone", Spot(-536.6853, -635.83356, 20));
		AddSpawnPoint("Spawner5.test_zone", "test_zone", Spot(-561.40826, -577.36896, 20));

		// Bubbe_Mage_Normal Spawn Points
		AddSpawnPoint("Spawner6.test_zone", "test_zone", Spot(-601.8565, -609.64197, 20));
		AddSpawnPoint("Spawner6.test_zone", "test_zone", Spot(-495.4882, -570.1708, 20));

		// Goblin_Archer Spawn Points
		AddSpawnPoint("Spawner7.test_zone", "test_zone", Spot(-558.76245, -518.6483, 20));
		AddSpawnPoint("Spawner7.test_zone", "test_zone", Spot(-520.469, -590.9409, 20));

	}
}
