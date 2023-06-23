//--- Melia Script -----------------------------------------------------------
// d_cmine_02
//
//--- Description -----------------------------------------------------------
// Sets up the d_cmine_02 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class DCmine02MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_cmine_02", MonsterId.Yekubite, Properties("MHP", 7640, "MINPATK", 430, "MAXPATK", 465, "MINMATK", 430, "MAXMATK", 465, "DEF", 43, "MDEF", 43));
		AddPropertyOverrides("d_cmine_02", MonsterId.Shredded, Properties("MHP", 8104, "MINPATK", 451, "MAXPATK", 488, "MINMATK", 451, "MAXMATK", 488, "DEF", 45, "MDEF", 45));
		AddPropertyOverrides("d_cmine_02", MonsterId.Bubbe_Mage_Normal, Properties("MHP", 8581, "MINPATK", 473, "MAXPATK", 511, "MINMATK", 473, "MAXMATK", 511, "DEF", 47, "MDEF", 47));
		AddPropertyOverrides("d_cmine_02", MonsterId.Goblin_Archer, Properties("MHP", 9070, "MINPATK", 495, "MAXPATK", 535, "MINMATK", 495, "MAXMATK", 535, "DEF", 49, "MDEF", 49));

		// Monster Populations
		AddMonsterPopulation("d_cmine_02", "population_rootcrystal_01_1", 30);
		AddMonsterPopulation("d_cmine_02", "population_yekubite_2", 5);
		AddMonsterPopulation("d_cmine_02", "population_yekubite_3", 20);
		AddMonsterPopulation("d_cmine_02", "population_shredded_4", 20);
		AddMonsterPopulation("d_cmine_02", "population_bubbe_mage_normal_5", 10);
		AddMonsterPopulation("d_cmine_02", "population_goblin_archer_6", 25);

		// RootCrystal Spawners
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-2426, -778, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-1769, -31, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-1894, -86, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-1509, 155, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-1240, 98, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-1373, -185, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-1241, -414, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-1200, -701, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-1347, -879, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-694, -797, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-1035, -1055, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-958, -867, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-1457, 229, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-1504, 755, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-1585, 1116, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-1748, 997, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-1592.156, 748.30084, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-1703.2898, 762.3009, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-1375, 916, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-1015, 123, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-580, 341, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-272, 8, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-154, -275, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(69, -156, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-220, 774, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-139, 945, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-335, 981, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-772, 1174, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(-592, 854, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(650, 33, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(687, -258, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(685, -503, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(1097, -340, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(968, -765, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(1717, -567, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(1621, -728, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(1239, -1599, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(1963, -1420, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(2161, -1289, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(2060, -1508, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(491, 1406, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(477, 1107, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(997, 1124, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(984, 1242, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(947, 303, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(1503, 221, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(648, 631, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(1378, 444, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(1538, 661, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(1701, 833, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(2059, 1514, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(1743, 1516, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(1969, 1616, 10));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(60000), "d_cmine_02", Spot(1679, 1380, 10));

		// Monster Spawners
		AddSpawner(MonsterId.Yekubite, "population_yekubite_2", TimeSpan.FromMilliseconds(0), "d_cmine_02", Spot(-1094, -1105, 30));
		AddSpawner(MonsterId.Yekubite, "population_yekubite_2", TimeSpan.FromMilliseconds(0), "d_cmine_02", Spot(-1955.2716, -137.94691, 30));
		AddSpawner(MonsterId.Yekubite, "population_yekubite_2", TimeSpan.FromMilliseconds(0), "d_cmine_02", Spot(-1059.4575, 31.005747, 30));
		AddSpawner(MonsterId.Yekubite, "population_yekubite_2", TimeSpan.FromMilliseconds(0), "d_cmine_02", Spot(-235.22662, -109.93029, 30));
		AddSpawner(MonsterId.Yekubite, "population_yekubite_2", TimeSpan.FromMilliseconds(0), "d_cmine_02", Spot(-146.21356, 82.24771, 30));
		AddSpawner(MonsterId.Yekubite, "population_yekubite_2", TimeSpan.FromMilliseconds(0), "d_cmine_02", Spot(-1132, -736, 30));
		AddSpawner(MonsterId.Yekubite, "population_yekubite_2", TimeSpan.FromMilliseconds(0), "d_cmine_02", Spot(0.717926, -200.16324, 30));
		AddSpawner(MonsterId.Yekubite, "population_yekubite_2", TimeSpan.FromMilliseconds(0), "d_cmine_02", Spot(997.52124, 1113.1371, 30));
		AddSpawner(MonsterId.Yekubite, "population_yekubite_2", TimeSpan.FromMilliseconds(0), "d_cmine_02", Spot(992.4581, 1310.1578, 30));
		AddSpawner(MonsterId.Yekubite, "population_yekubite_2", TimeSpan.FromMilliseconds(0), "d_cmine_02", Spot(853.55896, 1005.8099, 30));
		AddSpawner(MonsterId.Yekubite, "population_yekubite_2", TimeSpan.FromMilliseconds(0), "d_cmine_02", Spot(659.13544, 1034.207, 30));
		AddSpawner(MonsterId.Yekubite, "population_yekubite_3", TimeSpan.FromMilliseconds(0), "d_cmine_02", Spot(-133, -27, 9999));
		AddSpawner(MonsterId.Shredded, "population_shredded_4", TimeSpan.FromMilliseconds(0), "d_cmine_02", Spot(-1494, 895, 9999));
		AddSpawner(MonsterId.Bubbe_Mage_Normal, "population_bubbe_mage_normal_5", TimeSpan.FromMilliseconds(0), "d_cmine_02", Spot(-101.75935, -336.14886, 9999));
		AddSpawner(MonsterId.Goblin_Archer, "population_goblin_archer_6", TimeSpan.FromMilliseconds(0), "d_cmine_02", Spot(-587.29663, 318.1269, 9999));

	}
}
