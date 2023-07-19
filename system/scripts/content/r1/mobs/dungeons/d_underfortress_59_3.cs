//--- Melia Script -----------------------------------------------------------
// d_underfortress_59_3
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Royal Mausoleum Storage' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DUnderfortress593MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_underfortress_59_3.Id1", MonsterId.Fortress_Rock, 1, 1, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_underfortress_59_3.Id2", MonsterId.FD_Shredded, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_3.Id3", MonsterId.FD_Deadbornscab, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_3.Id4", MonsterId.FD_Hallowventor, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_3.Id5", MonsterId.Fortress_Rock, 1, 1, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_underfortress_59_3.Id6", MonsterId.Rootcrystal_03, 14, 18, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_underfortress_59_3.Id7", MonsterId.FD_Shredded, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_3.Id8", MonsterId.FD_Deadbornscab, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Fortress_Rock' GenType 2 Spawn Points
		AddSpawnPoint("d_underfortress_59_3.Id1", "d_underfortress_59_3", Rectangle(-84.01357, 328.48138, 20));

		// 'FD_Shredded' GenType 16 Spawn Points
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(-1297.1304, -749.66504, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1064.4897, 989.7951, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1312.0505, 837.7858, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1350.8922, 1050.2938, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1547.4581, 867.05963, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1469.1338, 712.055, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1382.7777, 1218.4417, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1084.9926, 701.6267, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1377.6437, 464.2145, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(651.4915, 1048.1265, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(736.83856, 343.93124, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(-184.69894, 955.67163, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(236.0812, -57.198616, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1503.9382, -675.4188, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1441.502, -452.73688, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1371.3253, 85.1087, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1596.942, 121.40234, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(660.0324, 269.74854, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(744.20605, 447.3524, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1437.7883, 235.74266, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1506.49, -77.9046, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1588.829, -871.2512, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1372.1969, -1042.077, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(1592.1897, -1053.0581, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(692.33813, 426.98538, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(478.40204, -96.77397, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(553.01447, 976.5099, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(489.77274, 835.44495, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(22.714493, 1029.7335, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(-187.09831, 841.12085, 20));
		AddSpawnPoint("d_underfortress_59_3.Id2", "d_underfortress_59_3", Rectangle(-401.23602, 1095.4001, 20));

		// 'FD_Deadbornscab' GenType 17 Spawn Points
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(-1297.7072, -645.3362, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(284.97943, -212.64194, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(-180.81142, -1039.2612, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(-391.5022, 189.69485, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(-557.5852, 1002.2105, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(-1441.6349, -113.82741, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(784.5651, 303.01578, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(-35.822403, -464.85345, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(-1103.9824, 190.98288, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(-254.2187, 57.59557, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(-415.3351, 39.445927, 40));
		AddSpawnPoint("d_underfortress_59_3.Id3", "d_underfortress_59_3", Rectangle(-214.25255, 204.72539, 40));

		// 'FD_Hallowventor' GenType 18 Spawn Points
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-1340.7671, -684.4316, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-1107.4023, -615.44305, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-439.64417, -680.8398, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(85.1886, -405.6101, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(339.11963, -11.518936, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(80.60766, 387.71973, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-5.6152477, 901.90454, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-428.21555, 862.98944, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-961.5547, 351.5631, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-1271.7068, 246.48103, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-1456.9834, -66.832794, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(505.683, 916.0285, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(1250.8043, 822.2294, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(212.19429, -282.56598, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-74.82438, -552.45435, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-102.17255, -1051.4161, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-1071.692, -151.57564, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-1489.0425, 622.5898, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(-423.88684, 1017.0479, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(691.8337, 1039.5155, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(1021.5642, 570.625, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(1259.8354, 1038.438, 30));
		AddSpawnPoint("d_underfortress_59_3.Id4", "d_underfortress_59_3", Rectangle(1504.6891, 899.5016, 30));

		// 'Fortress_Rock' GenType 19 Spawn Points
		AddSpawnPoint("d_underfortress_59_3.Id5", "d_underfortress_59_3", Rectangle(-746.21655, 985.0103, 20));

		// 'Rootcrystal_03' GenType 21 Spawn Points
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(-1349.1547, -866.08075, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(-1020.7206, -650.3658, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(-215.36414, -610.7702, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(-6.751148, -1041.1162, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(1477.6927, -1002.9837, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(1531.7509, -554.3617, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(1420.1353, -61.336246, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(1512.0034, 125.81751, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(736.35803, -351.16153, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(63.71045, 305.676, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(-332.02817, 25.890633, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(-134.01285, 970.4161, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(-1034.6086, -11.037262, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(-1016.5374, 373.8307, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(-642.8622, 943.35767, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(1317.4465, 1037.2278, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(1534.8503, 964.11237, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(1536.4688, 752.429, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(588.6624, 921.6798, 200));
		AddSpawnPoint("d_underfortress_59_3.Id6", "d_underfortress_59_3", Rectangle(813.5409, 376.44098, 200));

		// 'FD_Shredded' GenType 25 Spawn Points
		AddSpawnPoint("d_underfortress_59_3.Id7", "d_underfortress_59_3", Rectangle(-175.48631, -563.23706, 9999));

		// 'FD_Deadbornscab' GenType 26 Spawn Points
		AddSpawnPoint("d_underfortress_59_3.Id8", "d_underfortress_59_3", Rectangle(-17.15628, -454.47775, 9999));
	}
}
