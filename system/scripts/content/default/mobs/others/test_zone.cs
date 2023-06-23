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
		AddMonsterPopulation("test_zone", "population_boss_spector_f_1", 1);
		AddMonsterPopulation("test_zone", "population_boss_golem_2", 1);
		AddMonsterPopulation("test_zone", "population_boss_mirtis_3", 1);
		AddMonsterPopulation("test_zone", "population_barricade_butterfly_4", 1);
		AddMonsterPopulation("test_zone", "population_goblin_spear_5", 2);
		AddMonsterPopulation("test_zone", "population_bubbe_mage_normal_6", 2);
		AddMonsterPopulation("test_zone", "population_goblin_archer_7", 2);

		// Monster Spawners
		AddSpawner(MonsterId.Boss_Spector_F, "population_boss_spector_f_1", TimeSpan.FromMilliseconds(60000), "test_zone", Spot(137, -659, 20));
		AddSpawner(MonsterId.Boss_Spector_F, "population_boss_spector_f_1", TimeSpan.FromMilliseconds(60000), "test_zone", Spot(526, 564, 20));
		AddSpawner(MonsterId.Boss_Golem, "population_boss_golem_2", TimeSpan.FromMilliseconds(60000), "test_zone", Spot(-558, 556, 20));
		AddSpawner(MonsterId.Boss_Mirtis, "population_boss_mirtis_3", TimeSpan.FromMilliseconds(60000), "test_zone", Spot(-483, 171, 20));
		AddSpawner(MonsterId.Barricade_Butterfly, "population_barricade_butterfly_4", TimeSpan.FromMilliseconds(60000), "test_zone", Spot(-451, 52, 20));
		AddSpawner(MonsterId.Goblin_Spear, "population_goblin_spear_5", TimeSpan.FromMilliseconds(60000), "test_zone", Spot(-536.6853, -635.83356, 20));
		AddSpawner(MonsterId.Goblin_Spear, "population_goblin_spear_5", TimeSpan.FromMilliseconds(60000), "test_zone", Spot(-561.40826, -577.36896, 20));
		AddSpawner(MonsterId.Bubbe_Mage_Normal, "population_bubbe_mage_normal_6", TimeSpan.FromMilliseconds(60000), "test_zone", Spot(-601.8565, -609.64197, 20));
		AddSpawner(MonsterId.Bubbe_Mage_Normal, "population_bubbe_mage_normal_6", TimeSpan.FromMilliseconds(60000), "test_zone", Spot(-495.4882, -570.1708, 20));
		AddSpawner(MonsterId.Goblin_Archer, "population_goblin_archer_7", TimeSpan.FromMilliseconds(60000), "test_zone", Spot(-558.76245, -518.6483, 20));
		AddSpawner(MonsterId.Goblin_Archer, "population_goblin_archer_7", TimeSpan.FromMilliseconds(60000), "test_zone", Spot(-520.469, -590.9409, 20));

	}
}
