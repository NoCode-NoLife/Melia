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

		// Monster Populations
		AddMonsterPopulation("f_katyn_13_2", "population_swordmaster_1", 1);
		AddMonsterPopulation("f_katyn_13_2", "population_archermaster_2", 1);
		AddMonsterPopulation("f_katyn_13_2", "population_wizardmaster_3", 1);
		AddMonsterPopulation("f_katyn_13_2", "population_npc_healer_4", 1);
		AddMonsterPopulation("f_katyn_13_2", "population_mushroom_boy_red_5", 40);
		AddMonsterPopulation("f_katyn_13_2", "population_mushroom_ent_6", 20);
		AddMonsterPopulation("f_katyn_13_2", "population_mushroom_boy_red_7", 3);
		AddMonsterPopulation("f_katyn_13_2", "population_mushroom_boy_red_8", 25);

		// Monster Spawners
		AddSpawner(MonsterId.Swordmaster, "population_swordmaster_1", TimeSpan.FromMilliseconds(60000), "f_katyn_13_2", Spot(-403, -1878.91, 20));
		AddSpawner(MonsterId.Archermaster, "population_archermaster_2", TimeSpan.FromMilliseconds(60000), "f_katyn_13_2", Spot(-313.73, -2113.53, 20));
		AddSpawner(MonsterId.Wizardmaster, "population_wizardmaster_3", TimeSpan.FromMilliseconds(60000), "f_katyn_13_2", Spot(-312.74, -1747.03, 20));
		AddSpawner(MonsterId.Npc_Healer, "population_npc_healer_4", TimeSpan.FromMilliseconds(60000), "f_katyn_13_2", Spot(-192.13, -2135.66, 20));
		AddSpawner(MonsterId.Mushroom_Boy_Red, "population_mushroom_boy_red_5", TimeSpan.FromMilliseconds(15000), "f_katyn_13_2", Spot(-162.46576, -1998.9631, 9999));
		AddSpawner(MonsterId.Mushroom_Ent, "population_mushroom_ent_6", TimeSpan.FromMilliseconds(15000), "f_katyn_13_2", Spot(-1293.4271, 1492.9653, 9999));
		AddSpawner(MonsterId.Mushroom_Boy_Red, "population_mushroom_boy_red_7", TimeSpan.FromMilliseconds(20000), "f_katyn_13_2", Spot(-227.26, -1965.17, 300));
		AddSpawner(MonsterId.Mushroom_Boy_Red, "population_mushroom_boy_red_8", TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(-216.52788, -1713.0366, 30));
		AddSpawner(MonsterId.Mushroom_Boy_Red, "population_mushroom_boy_red_8", TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(-327.94702, -1848.8572, 30));
		AddSpawner(MonsterId.Mushroom_Boy_Red, "population_mushroom_boy_red_8", TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(-232.98715, -2046.5466, 30));
		AddSpawner(MonsterId.Mushroom_Boy_Red, "population_mushroom_boy_red_8", TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(-70.585236, -2023.15, 30));
		AddSpawner(MonsterId.Mushroom_Boy_Red, "population_mushroom_boy_red_8", TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(-110.33405, -1855.1942, 30));
		AddSpawner(MonsterId.Mushroom_Boy_Red, "population_mushroom_boy_red_8", TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(-19.71203, -1690.4005, 30));
		AddSpawner(MonsterId.Mushroom_Boy_Red, "population_mushroom_boy_red_8", TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(55.91324, -1930.4796, 30));
		AddSpawner(MonsterId.Mushroom_Boy_Red, "population_mushroom_boy_red_8", TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(-360.7234, -2090.9502, 30));
		AddSpawner(MonsterId.Mushroom_Boy_Red, "population_mushroom_boy_red_8", TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(-595.2442, -2054.4976, 30));
		AddSpawner(MonsterId.Mushroom_Boy_Red, "population_mushroom_boy_red_8", TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(-54.833138, -1476.0273, 30));
		AddSpawner(MonsterId.Mushroom_Boy_Red, "population_mushroom_boy_red_8", TimeSpan.FromMilliseconds(5000), "f_katyn_13_2", Spot(-40.26753, -1268.6481, 30));

	}
}
