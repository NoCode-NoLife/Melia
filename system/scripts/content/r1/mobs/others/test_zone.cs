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

		AddSpawner("test_zone.Id1", MonsterId.Boss_Spector_F, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("test_zone.Id2", MonsterId.Boss_Golem, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("test_zone.Id3", MonsterId.Boss_Mirtis, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("test_zone.Id4", MonsterId.Barricade_Butterfly, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("test_zone.Id5", MonsterId.Goblin_Spear, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("test_zone.Id6", MonsterId.Bubbe_Mage_Normal, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("test_zone.Id7", MonsterId.Goblin_Archer, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Boss_Spector_F Spawn Points
		AddSpawnPoint( "test_zone.Id1", "test_zone", Spot(137, -659, 20));
		AddSpawnPoint( "test_zone.Id1", "test_zone", Spot(526, 564, 20));

		// Boss_Golem Spawn Points
		AddSpawnPoint( "test_zone.Id2", "test_zone", Spot(-558, 556, 20));

		// Boss_Mirtis Spawn Points
		AddSpawnPoint( "test_zone.Id3", "test_zone", Spot(-483, 171, 20));

		// Barricade_Butterfly Spawn Points
		AddSpawnPoint( "test_zone.Id4", "test_zone", Spot(-451, 52, 20));

		// Goblin_Spear Spawn Points
		AddSpawnPoint( "test_zone.Id5", "test_zone", Spot(-536.6853, -635.83356, 20));
		AddSpawnPoint( "test_zone.Id5", "test_zone", Spot(-561.40826, -577.36896, 20));

		// Bubbe_Mage_Normal Spawn Points
		AddSpawnPoint( "test_zone.Id6", "test_zone", Spot(-601.8565, -609.64197, 20));
		AddSpawnPoint( "test_zone.Id6", "test_zone", Spot(-495.4882, -570.1708, 20));

		// Goblin_Archer Spawn Points
		AddSpawnPoint( "test_zone.Id7", "test_zone", Spot(-558.76245, -518.6483, 20));
		AddSpawnPoint( "test_zone.Id7", "test_zone", Spot(-520.469, -590.9409, 20));

	}
}
