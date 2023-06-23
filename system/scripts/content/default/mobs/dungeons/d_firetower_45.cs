//--- Melia Script -----------------------------------------------------------
// d_firetower_45
//
//--- Description -----------------------------------------------------------
// Sets up the d_firetower_45 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class DFiretower45MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_firetower_45", MonsterId.Dimmer, Properties("MHP", 119801, "MINPATK", 2042, "MAXPATK", 2411, "MINMATK", 2042, "MAXMATK", 2411, "DEF", 1823, "MDEF", 1823));
		AddPropertyOverrides("d_firetower_45", MonsterId.Tower_Of_Firepuppet_Black, Properties("MHP", 121520, "MINPATK", 2064, "MAXPATK", 2438, "MINMATK", 2064, "MAXMATK", 2438, "DEF", 1879, "MDEF", 1879));
		AddPropertyOverrides("d_firetower_45", MonsterId.Fire_Dragon_Purple, Properties("MHP", 123267, "MINPATK", 2086, "MAXPATK", 2466, "MINMATK", 2086, "MAXMATK", 2466, "DEF", 1936, "MDEF", 1936));

		// Monster Populations
		AddMonsterPopulation("d_firetower_45", "population_dimmer_1", 15);
		AddMonsterPopulation("d_firetower_45", "population_tower_of_firepuppet_black_2", 30);
		AddMonsterPopulation("d_firetower_45", "population_fire_dragon_purple_3", 10);
		AddMonsterPopulation("d_firetower_45", "population_fire_dragon_purple_4", 10);
		AddMonsterPopulation("d_firetower_45", "population_dimmer_5", 7);
		AddMonsterPopulation("d_firetower_45", "population_tower_of_firepuppet_black_6", 7);
		AddMonsterPopulation("d_firetower_45", "population_rootcrystal_01_7", 12);
		AddMonsterPopulation("d_firetower_45", "population_fire_dragon_purple_8", 10);
		AddMonsterPopulation("d_firetower_45", "population_dimmer_9", 10);

		// RootCrystal Spawners
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_7", TimeSpan.FromMilliseconds(30000), "d_firetower_45", Spot(-1254.4221, -1707.8021, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_7", TimeSpan.FromMilliseconds(30000), "d_firetower_45", Spot(-1617.6847, -1272.0352, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_7", TimeSpan.FromMilliseconds(30000), "d_firetower_45", Spot(-854.49963, -1269.4781, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_7", TimeSpan.FromMilliseconds(30000), "d_firetower_45", Spot(-1251.8391, -754.6408, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_7", TimeSpan.FromMilliseconds(30000), "d_firetower_45", Spot(-576.49884, -645.8988, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_7", TimeSpan.FromMilliseconds(30000), "d_firetower_45", Spot(-1569.0043, -194.61217, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_7", TimeSpan.FromMilliseconds(30000), "d_firetower_45", Spot(45.183353, 120.14347, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_7", TimeSpan.FromMilliseconds(30000), "d_firetower_45", Spot(-96.45741, 1038.3564, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_7", TimeSpan.FromMilliseconds(30000), "d_firetower_45", Spot(483.8544, 641.06976, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_7", TimeSpan.FromMilliseconds(30000), "d_firetower_45", Spot(-28.27198, 1524.0739, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_7", TimeSpan.FromMilliseconds(30000), "d_firetower_45", Spot(773.9018, 1890.2533, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_7", TimeSpan.FromMilliseconds(30000), "d_firetower_45", Spot(985.46906, 1263.3536, 100));

		// Monster Spawners
		AddSpawner(MonsterId.Dimmer, "population_dimmer_1", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-98, 41, 9999));
		AddSpawner(MonsterId.Tower_Of_Firepuppet_Black, "population_tower_of_firepuppet_black_2", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-73, 100, 9999));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_3", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-1240.353, -701.412, 9999));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_4", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-1243.5511, -727.2233, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_4", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-957.8033, -1269.8102, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_4", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-825.5958, -56.322514, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_4", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-1201.6681, -1284.179, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_4", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-1276.3031, -1407.9575, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_4", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-1347.0034, -1263.3864, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_4", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-1259.1754, -1204.0795, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_4", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-800.1002, -1230.9626, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_4", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-661.994, -1332.8771, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_4", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-591.1185, -1162.85, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_4", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-1219.26, -900.71014, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_4", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-849.5071, -664.48834, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_4", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-1219.597, -607.55304, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_4", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-1070.7982, -623.50885, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_4", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-1224.9662, -455.15387, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_4", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-1226.217, -1028.6232, 25));
		AddSpawner(MonsterId.Dimmer, "population_dimmer_5", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-1228.9856, -266.35526, 100));
		AddSpawner(MonsterId.Dimmer, "population_dimmer_5", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-1232.9398, -1621.7438, 100));
		AddSpawner(MonsterId.Dimmer, "population_dimmer_5", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-576.1389, -689.03845, 100));
		AddSpawner(MonsterId.Tower_Of_Firepuppet_Black, "population_tower_of_firepuppet_black_6", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-927.15485, -78.26698, 200));
		AddSpawner(MonsterId.Tower_Of_Firepuppet_Black, "population_tower_of_firepuppet_black_6", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-1540.2998, -187.42065, 200));
		AddSpawner(MonsterId.Tower_Of_Firepuppet_Black, "population_tower_of_firepuppet_black_6", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-907.0995, -688.7751, 200));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_8", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-144.90025, 977.3362, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_8", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-112.81907, 1118.8971, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_8", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-10.799919, 1016.868, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_8", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(578.6682, 800.4728, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_8", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(592.8426, 966.4425, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_8", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(477.22803, 886.6905, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_8", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(704.6442, 861.03326, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_8", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(50.485153, 1414.5093, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_8", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(24.145182, 1553.5378, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_8", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-155.91039, 1531.6833, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_8", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(991.77856, 1233.0066, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_8", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(855.91595, 1318.8959, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_8", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(634.865, 1271.3945, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_8", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(408.35327, 1459.7797, 25));
		AddSpawner(MonsterId.Fire_Dragon_Purple, "population_fire_dragon_purple_8", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(702.97815, 1455.4922, 25));
		AddSpawner(MonsterId.Dimmer, "population_dimmer_9", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(996.5594, 1290.1284, 25));
		AddSpawner(MonsterId.Dimmer, "population_dimmer_9", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(59.667873, 1518.024, 25));
		AddSpawner(MonsterId.Dimmer, "population_dimmer_9", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-99.10565, 1037.8433, 25));
		AddSpawner(MonsterId.Dimmer, "population_dimmer_9", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(-219.07722, 1043.8896, 25));
		AddSpawner(MonsterId.Dimmer, "population_dimmer_9", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(960.7126, 815.4792, 25));
		AddSpawner(MonsterId.Dimmer, "population_dimmer_9", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(561.0684, 863.34924, 25));
		AddSpawner(MonsterId.Dimmer, "population_dimmer_9", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(726.9662, 1603.6603, 25));
		AddSpawner(MonsterId.Dimmer, "population_dimmer_9", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(779.35, 1866.5616, 25));
		AddSpawner(MonsterId.Dimmer, "population_dimmer_9", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(660.94476, 1364.1628, 25));
		AddSpawner(MonsterId.Dimmer, "population_dimmer_9", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(353.21655, 1408.167, 25));
		AddSpawner(MonsterId.Dimmer, "population_dimmer_9", TimeSpan.FromMilliseconds(0), "d_firetower_45", Spot(646.8984, 1169.5691, 25));

	}
}
