//--- Melia Script -----------------------------------------------------------
// f_katyn_13_3
//
//--- Description -----------------------------------------------------------
// Sets up the f_katyn_13_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn133MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Populations
		AddMonsterPopulation("f_katyn_13_3", "population_new_desmodus_1", 20);
		AddMonsterPopulation("f_katyn_13_3", "population_ellom_green_2", 10);
		AddMonsterPopulation("f_katyn_13_3", "population_infrorocktor_red_3", 15);
		AddMonsterPopulation("f_katyn_13_3", "population_infrorocktor_red_4", 20);
		AddMonsterPopulation("f_katyn_13_3", "population_new_desmodus_5", 20);

		// Monster Spawners
		AddSpawner(MonsterId.New_Desmodus, "population_new_desmodus_1", TimeSpan.FromMilliseconds(15000), "f_katyn_13_3", Spot(1755.9845, 283.45026, 9999));
		AddSpawner(MonsterId.Ellom_Green, "population_ellom_green_2", TimeSpan.FromMilliseconds(15000), "f_katyn_13_3", Spot(277.87488, 243.53528, 9999));
		AddSpawner(MonsterId.InfroRocktor_Red, "population_infrorocktor_red_3", TimeSpan.FromMilliseconds(15000), "f_katyn_13_3", Spot(-1401.751, 379.45532, 9999));
		AddSpawner(MonsterId.InfroRocktor_Red, "population_infrorocktor_red_4", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1301.7783, 298.5942, 30));
		AddSpawner(MonsterId.InfroRocktor_Red, "population_infrorocktor_red_4", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1579.7003, 246.58012, 30));
		AddSpawner(MonsterId.InfroRocktor_Red, "population_infrorocktor_red_4", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1724.1985, 121.16917, 30));
		AddSpawner(MonsterId.InfroRocktor_Red, "population_infrorocktor_red_4", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1741.9368, 576.2671, 30));
		AddSpawner(MonsterId.InfroRocktor_Red, "population_infrorocktor_red_4", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1917.9528, 385.7499, 30));
		AddSpawner(MonsterId.InfroRocktor_Red, "population_infrorocktor_red_4", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1744.9395, 262.5108, 30));
		AddSpawner(MonsterId.InfroRocktor_Red, "population_infrorocktor_red_4", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1635.6881, 499.0037, 30));
		AddSpawner(MonsterId.InfroRocktor_Red, "population_infrorocktor_red_4", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1874.808, 572.55164, 30));
		AddSpawner(MonsterId.InfroRocktor_Red, "population_infrorocktor_red_4", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1783.8633, 414.26562, 30));
		AddSpawner(MonsterId.New_Desmodus, "population_new_desmodus_5", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1518.3115, 283.14474, 30));
		AddSpawner(MonsterId.New_Desmodus, "population_new_desmodus_5", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1694.0133, 199.92749, 30));
		AddSpawner(MonsterId.New_Desmodus, "population_new_desmodus_5", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1644.1213, 397.5618, 30));
		AddSpawner(MonsterId.New_Desmodus, "population_new_desmodus_5", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1691.9999, 578.1614, 30));
		AddSpawner(MonsterId.New_Desmodus, "population_new_desmodus_5", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1826.4536, 478.1889, 30));
		AddSpawner(MonsterId.New_Desmodus, "population_new_desmodus_5", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1993.1733, 412.3926, 30));
		AddSpawner(MonsterId.New_Desmodus, "population_new_desmodus_5", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1783.1538, 119.99742, 30));
		AddSpawner(MonsterId.New_Desmodus, "population_new_desmodus_5", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1756.9548, 300.27124, 30));
		AddSpawner(MonsterId.New_Desmodus, "population_new_desmodus_5", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1918.4325, 308.71857, 30));
		AddSpawner(MonsterId.New_Desmodus, "population_new_desmodus_5", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1506.6051, 438.11392, 30));
		AddSpawner(MonsterId.New_Desmodus, "population_new_desmodus_5", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1168.9093, 320.50067, 30));
		AddSpawner(MonsterId.New_Desmodus, "population_new_desmodus_5", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1449.715, 145.5412, 30));
		AddSpawner(MonsterId.New_Desmodus, "population_new_desmodus_5", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1383.36, 255.07632, 30));
		AddSpawner(MonsterId.New_Desmodus, "population_new_desmodus_5", TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1621.4419, 117.26129, 30));

	}
}
