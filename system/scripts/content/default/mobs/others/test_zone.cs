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

		// Monster Populations
		var BossSpectorF_1_1 = AddMonsterGenerator(MonsterId.Boss_Spector_F, "test_zone", 1);
		var BossGolem_2_1 = AddMonsterGenerator(MonsterId.Boss_Golem, "test_zone", 1);
		var BossMirtis_3_1 = AddMonsterGenerator(MonsterId.Boss_Mirtis, "test_zone", 1);
		var BarricadeButterfly_4_1 = AddMonsterGenerator(MonsterId.Barricade_Butterfly, "test_zone", 1);
		var GoblinSpear_5_2 = AddMonsterGenerator(MonsterId.Goblin_Spear, "test_zone", 2);
		var BubbeMageNormal_6_2 = AddMonsterGenerator(MonsterId.Bubbe_Mage_Normal, "test_zone", 2);
		var GoblinArcher_7_2 = AddMonsterGenerator(MonsterId.Goblin_Archer, "test_zone", 2);

		// Monster Spawners
		AddSpawnPoint(BossSpectorF_1_1, TimeSpan.FromMilliseconds(60000), "test_zone", Spot(137, -659, 20));
		AddSpawnPoint(BossSpectorF_1_1, TimeSpan.FromMilliseconds(60000), "test_zone", Spot(526, 564, 20));
		AddSpawnPoint(BossGolem_2_1, TimeSpan.FromMilliseconds(60000), "test_zone", Spot(-558, 556, 20));
		AddSpawnPoint(BossMirtis_3_1, TimeSpan.FromMilliseconds(60000), "test_zone", Spot(-483, 171, 20));
		AddSpawnPoint(BarricadeButterfly_4_1, TimeSpan.FromMilliseconds(60000), "test_zone", Spot(-451, 52, 20));
		AddSpawnPoint(GoblinSpear_5_2, TimeSpan.FromMilliseconds(60000), "test_zone", Spot(-536.6853, -635.83356, 20));
		AddSpawnPoint(GoblinSpear_5_2, TimeSpan.FromMilliseconds(60000), "test_zone", Spot(-561.40826, -577.36896, 20));
		AddSpawnPoint(BubbeMageNormal_6_2, TimeSpan.FromMilliseconds(60000), "test_zone", Spot(-601.8565, -609.64197, 20));
		AddSpawnPoint(BubbeMageNormal_6_2, TimeSpan.FromMilliseconds(60000), "test_zone", Spot(-495.4882, -570.1708, 20));
		AddSpawnPoint(GoblinArcher_7_2, TimeSpan.FromMilliseconds(60000), "test_zone", Spot(-558.76245, -518.6483, 20));
		AddSpawnPoint(GoblinArcher_7_2, TimeSpan.FromMilliseconds(60000), "test_zone", Spot(-520.469, -590.9409, 20));

	}
}
