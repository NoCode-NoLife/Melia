//--- Melia Script -----------------------------------------------------------
// d_velniasprison_54_1
//
//--- Description -----------------------------------------------------------
// Sets up the d_velniasprison_54_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class DVelniasprison541MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Populations
		AddMonsterPopulation("d_velniasprison_54_1", "population_fd_yognome_1", 35);
		AddMonsterPopulation("d_velniasprison_54_1", "population_fd_long_arm_2", 23);
		AddMonsterPopulation("d_velniasprison_54_1", "population_fd_firent_yellow_3", 1);
		AddMonsterPopulation("d_velniasprison_54_1", "population_treasure_goblin_4", 0);
		AddMonsterPopulation("d_velniasprison_54_1", "population_rootcrystal_04_5", 15);
		AddMonsterPopulation("d_velniasprison_54_1", "population_fd_infrogalas_bow_6", 20);
		AddMonsterPopulation("d_velniasprison_54_1", "population_fd_yognome_7", 20);

		// RootCrystal Spawners
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(60000), "d_velniasprison_54_1", Spot(-170.41786, 19.547928, 10));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(60000), "d_velniasprison_54_1", Spot(258.24307, 93.21041, 10));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(60000), "d_velniasprison_54_1", Spot(-7.4845753, 445.65512, 10));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(60000), "d_velniasprison_54_1", Spot(441.64288, 764.59985, 10));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(60000), "d_velniasprison_54_1", Spot(-266.74362, 891.3008, 10));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(60000), "d_velniasprison_54_1", Spot(-986.93994, 828.04, 10));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(60000), "d_velniasprison_54_1", Spot(-1059.4888, 234.21434, 10));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(60000), "d_velniasprison_54_1", Spot(-1395.4532, -45.958687, 10));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(60000), "d_velniasprison_54_1", Spot(-1297.8217, -784.77734, 10));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(60000), "d_velniasprison_54_1", Spot(-1004.7156, -588.94604, 10));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(60000), "d_velniasprison_54_1", Spot(-467.21982, -498.21396, 10));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(60000), "d_velniasprison_54_1", Spot(833.3135, -501.8186, 10));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(60000), "d_velniasprison_54_1", Spot(779.1224, 57.26957, 10));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(60000), "d_velniasprison_54_1", Spot(1267.4897, 156.44907, 10));
		AddSpawner(MonsterId.Rootcrystal_04, "population_rootcrystal_04_5", TimeSpan.FromMilliseconds(60000), "d_velniasprison_54_1", Spot(979.73425, 627.0676, 10));

		// Monster Spawners
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_1", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(9.248821, -11.835621, 9999));
		AddSpawner(MonsterId.FD_Long_Arm, "population_fd_long_arm_2", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1137.6249, -693.8376, 25));
		AddSpawner(MonsterId.FD_Long_Arm, "population_fd_long_arm_2", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1372.2626, -806.58435, 25));
		AddSpawner(MonsterId.FD_Long_Arm, "population_fd_long_arm_2", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1264.819, -566.6502, 25));
		AddSpawner(MonsterId.FD_Long_Arm, "population_fd_long_arm_2", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1001.8707, -798.14343, 25));
		AddSpawner(MonsterId.FD_Long_Arm, "population_fd_long_arm_2", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-971.7458, -579.6299, 25));
		AddSpawner(MonsterId.FD_Long_Arm, "population_fd_long_arm_2", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-133.55797, 709.1034, 25));
		AddSpawner(MonsterId.FD_Long_Arm, "population_fd_long_arm_2", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-302.0043, 842.6755, 25));
		AddSpawner(MonsterId.FD_Long_Arm, "population_fd_long_arm_2", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(463.7983, 828.3593, 25));
		AddSpawner(MonsterId.FD_Long_Arm, "population_fd_long_arm_2", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(872.7762, 39.478195, 25));
		AddSpawner(MonsterId.FD_Long_Arm, "population_fd_long_arm_2", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(915.62494, 253.87227, 25));
		AddSpawner(MonsterId.FD_Long_Arm, "population_fd_long_arm_2", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(1100.5916, -9.715155, 25));
		AddSpawner(MonsterId.FD_Long_Arm, "population_fd_long_arm_2", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(1239.9385, 231.82744, 25));
		AddSpawner(MonsterId.FD_Long_Arm, "population_fd_long_arm_2", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(292.373, 740.62036, 25));
		AddSpawner(MonsterId.FD_Long_Arm, "population_fd_long_arm_2", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-396.93817, 685.27167, 25));
		AddSpawner(MonsterId.FD_Long_Arm, "population_fd_long_arm_2", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(1072.2236, 166.91063, 25));
		AddSpawner(MonsterId.FD_Firent_Yellow, "population_fd_firent_yellow_3", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(932.30347, 94.19976, 100));
		AddSpawner(MonsterId.Treasure_Goblin, "population_treasure_goblin_4", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1028.7721, 304.53156, 20));
		AddSpawner(MonsterId.Treasure_Goblin, "population_treasure_goblin_4", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-913.9122, 858.90564, 20));
		AddSpawner(MonsterId.Treasure_Goblin, "population_treasure_goblin_4", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-149.49362, 768.46423, 20));
		AddSpawner(MonsterId.Treasure_Goblin, "population_treasure_goblin_4", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(1119.2732, 103.15617, 20));
		AddSpawner(MonsterId.Treasure_Goblin, "population_treasure_goblin_4", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(92.734184, 50.609787, 20));
		AddSpawner(MonsterId.Treasure_Goblin, "population_treasure_goblin_4", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1196.7982, -739.2802, 20));
		AddSpawner(MonsterId.FD_Infrogalas_Bow, "population_fd_infrogalas_bow_6", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(182.12701, -87.12333, 35));
		AddSpawner(MonsterId.FD_Infrogalas_Bow, "population_fd_infrogalas_bow_6", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(102.05772, 192.40996, 35));
		AddSpawner(MonsterId.FD_Infrogalas_Bow, "population_fd_infrogalas_bow_6", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-224.22858, 234.95244, 35));
		AddSpawner(MonsterId.FD_Infrogalas_Bow, "population_fd_infrogalas_bow_6", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-39.24786, 410.4346, 35));
		AddSpawner(MonsterId.FD_Infrogalas_Bow, "population_fd_infrogalas_bow_6", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-399.1001, 799.83655, 35));
		AddSpawner(MonsterId.FD_Infrogalas_Bow, "population_fd_infrogalas_bow_6", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-192.24069, 835.2691, 35));
		AddSpawner(MonsterId.FD_Infrogalas_Bow, "population_fd_infrogalas_bow_6", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(839.77136, -559.0459, 35));
		AddSpawner(MonsterId.FD_Infrogalas_Bow, "population_fd_infrogalas_bow_6", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(374.05243, 207.43678, 35));
		AddSpawner(MonsterId.FD_Infrogalas_Bow, "population_fd_infrogalas_bow_6", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1093.2949, -580.3272, 35));
		AddSpawner(MonsterId.FD_Infrogalas_Bow, "population_fd_infrogalas_bow_6", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1084.7949, 862.50854, 35));
		AddSpawner(MonsterId.FD_Infrogalas_Bow, "population_fd_infrogalas_bow_6", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-945.9262, 949.0055, 35));
		AddSpawner(MonsterId.FD_Infrogalas_Bow, "population_fd_infrogalas_bow_6", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1193.8787, -855.74396, 35));
		AddSpawner(MonsterId.FD_Infrogalas_Bow, "population_fd_infrogalas_bow_6", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1035.0659, 269.32343, 35));
		AddSpawner(MonsterId.FD_Infrogalas_Bow, "population_fd_infrogalas_bow_6", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-55.48613, -397.7105, 35));
		AddSpawner(MonsterId.FD_Infrogalas_Bow, "population_fd_infrogalas_bow_6", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(966.6663, 191.17017, 35));
		AddSpawner(MonsterId.FD_Infrogalas_Bow, "population_fd_infrogalas_bow_6", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(789.4263, -549.4807, 35));
		AddSpawner(MonsterId.FD_Infrogalas_Bow, "population_fd_infrogalas_bow_6", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(950.05804, -10.45192, 35));
		AddSpawner(MonsterId.FD_Infrogalas_Bow, "population_fd_infrogalas_bow_6", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-201.91447, 16.607489, 35));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-591.74097, -547.1952, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-466.77084, -479.87738, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-476.38364, -556.9702, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(829.1923, -608.61035, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(817.7796, -530.32764, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(841.9343, -467.38446, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(29.925982, 27.552189, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-292.52243, 287.9556, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(80.359695, 321.24698, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(379.35666, 183.2175, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1365.8701, -177.53683, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1396.0887, -101.6291, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1241.0667, -69.35966, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1326.9047, -671.1837, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1086.4121, -820.82227, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1151.7217, -613.08215, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1012.0925, 901.8627, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1114.4243, 953.9806, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1183.6467, 822.2934, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-252.63615, 737.7336, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-121.36774, 837.0146, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-371.96725, 905.5397, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(345.84283, 794.20197, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(444.46088, 678.9735, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(341.78513, 698.48724, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(977.29083, 256.99225, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(1158.1249, -52.45826, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(845.6094, 34.495922, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(1022.7618, 104.84167, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1180.9557, 202.65273, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1017.4752, 190.20494, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-1111.9473, 307.36957, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-193.58435, 175.32166, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-359.56204, -46.51871, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(-159.17162, -49.68956, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(152.63197, -77.99835, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(205.90977, 287.86267, 25));
		AddSpawner(MonsterId.FD_Yognome, "population_fd_yognome_7", TimeSpan.FromMilliseconds(0), "d_velniasprison_54_1", Spot(205.72893, 86.28242, 25));

	}
}
