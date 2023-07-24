//--- Melia Script -----------------------------------------------------------
// Test Zone Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'test_zone'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class TestZoneMobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("test_zone.Id1", MonsterId.Boss_Golem, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("test_zone.Id2", MonsterId.Boss_Mirtis, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("test_zone.Id3", MonsterId.Barricade_Butterfly, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("test_zone.Id4", MonsterId.Boss_Spector_F, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("test_zone.Id5", MonsterId.Goblin_Spear, amount: 2, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("test_zone.Id6", MonsterId.Bubbe_Mage_Normal, amount: 2, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("test_zone.Id7", MonsterId.Goblin_Archer, amount: 2, respawn: TimeSpan.FromMilliseconds(60000));

		// Monster Spawn Points -----------------------------

		// 'Boss_Golem' GenType 9 Spawn Points
		AddSpawnPoint("test_zone.Id1", "test_zone", Rectangle(-558, 556, 20));

		// 'Boss_Mirtis' GenType 10 Spawn Points
		AddSpawnPoint("test_zone.Id2", "test_zone", Rectangle(-483, 171, 20));

		// 'Barricade_Butterfly' GenType 13 Spawn Points
		AddSpawnPoint("test_zone.Id3", "test_zone", Rectangle(-451, 52, 20));

		// 'Boss_Spector_F' GenType 16 Spawn Points
		AddSpawnPoint("test_zone.Id4", "test_zone", Rectangle(137, -659, 20));
		AddSpawnPoint("test_zone.Id4", "test_zone", Rectangle(526, 564, 20));

		// 'Goblin_Spear' GenType 109 Spawn Points
		AddSpawnPoint("test_zone.Id5", "test_zone", Rectangle(-536, -635, 20));
		AddSpawnPoint("test_zone.Id5", "test_zone", Rectangle(-561, -577, 20));

		// 'Bubbe_Mage_Normal' GenType 110 Spawn Points
		AddSpawnPoint("test_zone.Id6", "test_zone", Rectangle(-601, -609, 20));
		AddSpawnPoint("test_zone.Id6", "test_zone", Rectangle(-495, -570, 20));

		// 'Goblin_Archer' GenType 111 Spawn Points
		AddSpawnPoint("test_zone.Id7", "test_zone", Rectangle(-558, -518, 20));
		AddSpawnPoint("test_zone.Id7", "test_zone", Rectangle(-520, -590, 20));
	}
}
