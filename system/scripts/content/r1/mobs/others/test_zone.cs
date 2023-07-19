//--- Melia Script -----------------------------------------------------------
// test_zone
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Test Zone' map.
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

		AddSpawner("test_zone.Id1", MonsterId.Boss_Golem, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("test_zone.Id2", MonsterId.Boss_Mirtis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("test_zone.Id3", MonsterId.Barricade_Butterfly, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("test_zone.Id4", MonsterId.Boss_Spector_F, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("test_zone.Id5", MonsterId.Goblin_Spear, 2, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("test_zone.Id6", MonsterId.Bubbe_Mage_Normal, 2, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("test_zone.Id7", MonsterId.Goblin_Archer, 2, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

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
		AddSpawnPoint("test_zone.Id5", "test_zone", Rectangle(-536.6853, -635.83356, 20));
		AddSpawnPoint("test_zone.Id5", "test_zone", Rectangle(-561.40826, -577.36896, 20));

		// 'Bubbe_Mage_Normal' GenType 110 Spawn Points
		AddSpawnPoint("test_zone.Id6", "test_zone", Rectangle(-601.8565, -609.64197, 20));
		AddSpawnPoint("test_zone.Id6", "test_zone", Rectangle(-495.4882, -570.1708, 20));

		// 'Goblin_Archer' GenType 111 Spawn Points
		AddSpawnPoint("test_zone.Id7", "test_zone", Rectangle(-558.76245, -518.6483, 20));
		AddSpawnPoint("test_zone.Id7", "test_zone", Rectangle(-520.469, -590.9409, 20));
	}
}
