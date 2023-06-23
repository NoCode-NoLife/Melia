//--- Melia Script -----------------------------------------------------------
// d_underfortress_59_3
//
//--- Description -----------------------------------------------------------
// Sets up the d_underfortress_59_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class DUnderfortress593MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Populations
		AddMonsterPopulation("d_underfortress_59_3", "population_fortress_rock_1", 1);
		AddMonsterPopulation("d_underfortress_59_3", "population_fd_shredded_2", 20);
		AddMonsterPopulation("d_underfortress_59_3", "population_fd_deadbornscab_3", 15);
		AddMonsterPopulation("d_underfortress_59_3", "population_fd_hallowventor_4", 20);
		AddMonsterPopulation("d_underfortress_59_3", "population_fortress_rock_5", 1);
		AddMonsterPopulation("d_underfortress_59_3", "population_rootcrystal_03_6", 18);
		AddMonsterPopulation("d_underfortress_59_3", "population_fd_shredded_7", 15);
		AddMonsterPopulation("d_underfortress_59_3", "population_fd_deadbornscab_8", 15);

		// RootCrystal Spawners
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_6", TimeSpan.FromMilliseconds(30000), "d_underfortress_59_3", Spot(-1349.1547, -866.08075, 200));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_6", TimeSpan.FromMilliseconds(30000), "d_underfortress_59_3", Spot(-1020.7206, -650.3658, 200));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_6", TimeSpan.FromMilliseconds(30000), "d_underfortress_59_3", Spot(-215.36414, -610.7702, 200));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_6", TimeSpan.FromMilliseconds(30000), "d_underfortress_59_3", Spot(-6.751148, -1041.1162, 200));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_6", TimeSpan.FromMilliseconds(30000), "d_underfortress_59_3", Spot(1477.6927, -1002.9837, 200));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_6", TimeSpan.FromMilliseconds(30000), "d_underfortress_59_3", Spot(1531.7509, -554.3617, 200));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_6", TimeSpan.FromMilliseconds(30000), "d_underfortress_59_3", Spot(1420.1353, -61.336246, 200));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_6", TimeSpan.FromMilliseconds(30000), "d_underfortress_59_3", Spot(1512.0034, 125.81751, 200));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_6", TimeSpan.FromMilliseconds(30000), "d_underfortress_59_3", Spot(736.35803, -351.16153, 200));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_6", TimeSpan.FromMilliseconds(30000), "d_underfortress_59_3", Spot(63.71045, 305.676, 200));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_6", TimeSpan.FromMilliseconds(30000), "d_underfortress_59_3", Spot(-332.02817, 25.890633, 200));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_6", TimeSpan.FromMilliseconds(30000), "d_underfortress_59_3", Spot(-134.01285, 970.4161, 200));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_6", TimeSpan.FromMilliseconds(30000), "d_underfortress_59_3", Spot(-1034.6086, -11.037262, 200));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_6", TimeSpan.FromMilliseconds(30000), "d_underfortress_59_3", Spot(-1016.5374, 373.8307, 200));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_6", TimeSpan.FromMilliseconds(30000), "d_underfortress_59_3", Spot(-642.8622, 943.35767, 200));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_6", TimeSpan.FromMilliseconds(30000), "d_underfortress_59_3", Spot(1317.4465, 1037.2278, 200));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_6", TimeSpan.FromMilliseconds(30000), "d_underfortress_59_3", Spot(1534.8503, 964.11237, 200));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_6", TimeSpan.FromMilliseconds(30000), "d_underfortress_59_3", Spot(1536.4688, 752.429, 200));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_6", TimeSpan.FromMilliseconds(30000), "d_underfortress_59_3", Spot(588.6624, 921.6798, 200));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_6", TimeSpan.FromMilliseconds(30000), "d_underfortress_59_3", Spot(813.5409, 376.44098, 200));

		// Monster Spawners
		AddSpawner(MonsterId.Fortress_Rock, "population_fortress_rock_1", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-84.01357, 328.48138, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-1297.1304, -749.66504, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1064.4897, 989.7951, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1312.0505, 837.7858, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1350.8922, 1050.2938, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1547.4581, 867.05963, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1469.1338, 712.055, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1382.7777, 1218.4417, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1084.9926, 701.6267, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1377.6437, 464.2145, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(651.4915, 1048.1265, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(736.83856, 343.93124, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-184.69894, 955.67163, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(236.0812, -57.198616, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1503.9382, -675.4188, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1441.502, -452.73688, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1371.3253, 85.1087, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1596.942, 121.40234, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(660.0324, 269.74854, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(744.20605, 447.3524, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1437.7883, 235.74266, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1506.49, -77.9046, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1588.829, -871.2512, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1372.1969, -1042.077, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1592.1897, -1053.0581, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(692.33813, 426.98538, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(478.40204, -96.77397, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(553.01447, 976.5099, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(489.77274, 835.44495, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(22.714493, 1029.7335, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-187.09831, 841.12085, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_2", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-401.23602, 1095.4001, 20));
		AddSpawner(MonsterId.FD_Deadbornscab, "population_fd_deadbornscab_3", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-1297.7072, -645.3362, 40));
		AddSpawner(MonsterId.FD_Deadbornscab, "population_fd_deadbornscab_3", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(284.97943, -212.64194, 40));
		AddSpawner(MonsterId.FD_Deadbornscab, "population_fd_deadbornscab_3", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-180.81142, -1039.2612, 40));
		AddSpawner(MonsterId.FD_Deadbornscab, "population_fd_deadbornscab_3", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-391.5022, 189.69485, 40));
		AddSpawner(MonsterId.FD_Deadbornscab, "population_fd_deadbornscab_3", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-557.5852, 1002.2105, 40));
		AddSpawner(MonsterId.FD_Deadbornscab, "population_fd_deadbornscab_3", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-1441.6349, -113.82741, 40));
		AddSpawner(MonsterId.FD_Deadbornscab, "population_fd_deadbornscab_3", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(784.5651, 303.01578, 40));
		AddSpawner(MonsterId.FD_Deadbornscab, "population_fd_deadbornscab_3", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-35.822403, -464.85345, 40));
		AddSpawner(MonsterId.FD_Deadbornscab, "population_fd_deadbornscab_3", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-1103.9824, 190.98288, 40));
		AddSpawner(MonsterId.FD_Deadbornscab, "population_fd_deadbornscab_3", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-254.2187, 57.59557, 40));
		AddSpawner(MonsterId.FD_Deadbornscab, "population_fd_deadbornscab_3", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-415.3351, 39.445927, 40));
		AddSpawner(MonsterId.FD_Deadbornscab, "population_fd_deadbornscab_3", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-214.25255, 204.72539, 40));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-1340.7671, -684.4316, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-1107.4023, -615.44305, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-439.64417, -680.8398, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(85.1886, -405.6101, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(339.11963, -11.518936, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(80.60766, 387.71973, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-5.6152477, 901.90454, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-428.21555, 862.98944, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-961.5547, 351.5631, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-1271.7068, 246.48103, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-1456.9834, -66.832794, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(505.683, 916.0285, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1250.8043, 822.2294, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(212.19429, -282.56598, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-74.82438, -552.45435, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-102.17255, -1051.4161, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-1071.692, -151.57564, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-1489.0425, 622.5898, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-423.88684, 1017.0479, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(691.8337, 1039.5155, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1021.5642, 570.625, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1259.8354, 1038.438, 30));
		AddSpawner(MonsterId.FD_Hallowventor, "population_fd_hallowventor_4", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(1504.6891, 899.5016, 30));
		AddSpawner(MonsterId.Fortress_Rock, "population_fortress_rock_5", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-746.21655, 985.0103, 20));
		AddSpawner(MonsterId.FD_Shredded, "population_fd_shredded_7", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-175.48631, -563.23706, 9999));
		AddSpawner(MonsterId.FD_Deadbornscab, "population_fd_deadbornscab_8", TimeSpan.FromMilliseconds(0), "d_underfortress_59_3", Spot(-17.15628, -454.47775, 9999));

	}
}
