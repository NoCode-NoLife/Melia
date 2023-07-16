//--- Melia Script -----------------------------------------------------------
// f_rokas_26
//
//--- Description -----------------------------------------------------------
// Sets up the f_rokas_26 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRokas26MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_rokas_26.Id1", MonsterId.Wendigo, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_26.Id2", MonsterId.Dumaro, 65, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_26.Id3", MonsterId.Dumaro, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_26.Id4", MonsterId.Rootcrystal_05, 16, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_rokas_26.Id5", MonsterId.Wendigo_Bow, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_26.Id6", MonsterId.Wendigo_Mage, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Wendigo Spawn Points
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(885.44684, -1011.1439, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-602.03485, -670.05084, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-239.40051, -347.82538, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-477.1984, -1029.9153, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(36.234516, -129.37569, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(995.9269, -1240.4216, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-71.82941, 577.8479, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-521.051, 387.97812, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-650.89166, 352.0207, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-1244.3483, 237.44763, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-1197.8903, 423.72678, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-1063.5308, 245.49829, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-1256.589, 779.5284, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-1172.7709, 868.7961, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-1282.6053, 1304.0864, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-1087.9823, 1623.3945, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-1098.9915, 1370.3231, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-100.84099, 1630.9119, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(111.2018, 1699.9586, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(61.56063, 1548.9086, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(46.370415, 643.67194, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-56.070717, 681.13763, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-7.9569206, -378.19815, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-588.43274, -891.8916, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-395.37753, -474.0943, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-108.55399, -230.25327, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-26.708275, 499.43353, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-1356.0494, 157.68614, 20));
		AddSpawnPoint( "f_rokas_26.Id1", "f_rokas_26", Spot(-1373.2858, 300.38715, 20));

		// Dumaro Spawn Points
		AddSpawnPoint( "f_rokas_26.Id2", "f_rokas_26", Spot(1337.8589, -590.4032, 9999));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1197.4999, 1448.9558, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-205.8421, -415.18613, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-229.54425, -253.61684, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-108.83939, -148.26672, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-105.67222, -319.4214, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-21.830444, -433.69864, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(41.320255, -234.99779, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1458.2648, 1306.8916, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1294.9055, 1238.0127, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1361.9349, 1523.2556, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1084.5833, 1755.7837, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1192.3955, 1636.2192, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-985.2193, 1562.761, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1031.093, 1348.0253, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(1192.0784, -626.4754, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(1090.6912, -737.35986, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(977.03406, -954.96936, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(1047.478, -1062.7289, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(1129.5612, -1212.5414, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(1261.3109, -1925.6906, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(1110.3917, -2037.5054, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(1062.6943, -1956.9972, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(972.72986, -1824.9924, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(1093.9442, -1772.0585, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(1178.5371, -1873.5181, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(1300.2998, -1824.7081, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(1127.5591, -1665.1675, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(1071.5115, -1329.3356, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(903.5572, -1096.5273, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-540.0291, -956.71204, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-526.48456, -588.86346, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(3.6041489, -320.72885, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(106.97953, -135.02844, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(59.40118, -49.364433, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-30.63373, -183.81516, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-116.72597, -404.97696, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-292.68423, -376.5576, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(94.365776, -311.98566, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(21.971115, 581.24274, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(97.747795, 675.24866, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-166.00252, 488.83365, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-61.446682, 628.3474, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-609.4708, 483.27173, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-586.4082, 281.8654, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1044.2516, 334.5226, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1266.4526, 316.64148, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1285.5259, 438.667, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1431.6117, 232.66814, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1248.3507, 82.53102, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1331.9696, 233.53148, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1132.6084, 240.01888, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1013.053, 436.1864, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1194.4071, 478.82025, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1047.7012, 204.99799, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1058.6827, 1491.6139, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1078.9427, 1670.105, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1239.7148, 1548.2413, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1404.0167, 1399.2523, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1133.5356, 1272.9639, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-1201.8888, 1361.5219, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-25.839172, 1808.8214, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(191.75566, 1729.9703, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(-12.475771, 1636.7955, 20));
		AddSpawnPoint( "f_rokas_26.Id3", "f_rokas_26", Spot(142.95415, 1800.8658, 20));

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "f_rokas_26.Id4", "f_rokas_26", Spot(2000.7463, -26.288288, 30));
		AddSpawnPoint( "f_rokas_26.Id4", "f_rokas_26", Spot(1636.3046, -97.75717, 30));
		AddSpawnPoint( "f_rokas_26.Id4", "f_rokas_26", Spot(1198.0118, -556.29816, 30));
		AddSpawnPoint( "f_rokas_26.Id4", "f_rokas_26", Spot(1183.7797, -1271.0934, 30));
		AddSpawnPoint( "f_rokas_26.Id4", "f_rokas_26", Spot(821.7767, -962.6804, 30));
		AddSpawnPoint( "f_rokas_26.Id4", "f_rokas_26", Spot(1350.56, -1846.7954, 30));
		AddSpawnPoint( "f_rokas_26.Id4", "f_rokas_26", Spot(261.97568, -1448.668, 30));
		AddSpawnPoint( "f_rokas_26.Id4", "f_rokas_26", Spot(-362.9111, -1716.7972, 30));
		AddSpawnPoint( "f_rokas_26.Id4", "f_rokas_26", Spot(-630.7979, -774.29767, 30));
		AddSpawnPoint( "f_rokas_26.Id4", "f_rokas_26", Spot(76.56154, -331.28235, 30));
		AddSpawnPoint( "f_rokas_26.Id4", "f_rokas_26", Spot(167.04848, 527.91095, 30));
		AddSpawnPoint( "f_rokas_26.Id4", "f_rokas_26", Spot(-578.32153, 499.27573, 30));
		AddSpawnPoint( "f_rokas_26.Id4", "f_rokas_26", Spot(-1004.5174, 319.56396, 30));
		AddSpawnPoint( "f_rokas_26.Id4", "f_rokas_26", Spot(-1210.2035, 844.52563, 30));
		AddSpawnPoint( "f_rokas_26.Id4", "f_rokas_26", Spot(-1078.6528, 1765.6772, 30));
		AddSpawnPoint( "f_rokas_26.Id4", "f_rokas_26", Spot(10.730598, 1774.7498, 30));
		AddSpawnPoint( "f_rokas_26.Id4", "f_rokas_26", Spot(508.10657, -1930.2091, 30));

		// Wendigo_Bow Spawn Points
		AddSpawnPoint( "f_rokas_26.Id5", "f_rokas_26", Spot(874.0878, -1013.6498, 30));
		AddSpawnPoint( "f_rokas_26.Id5", "f_rokas_26", Spot(990.8694, -869.0076, 30));
		AddSpawnPoint( "f_rokas_26.Id5", "f_rokas_26", Spot(1004.7442, -1156.2197, 30));
		AddSpawnPoint( "f_rokas_26.Id5", "f_rokas_26", Spot(-1168.3997, 154.03091, 30));
		AddSpawnPoint( "f_rokas_26.Id5", "f_rokas_26", Spot(-1166.8207, 313.66412, 30));
		AddSpawnPoint( "f_rokas_26.Id5", "f_rokas_26", Spot(-1353.1243, 320.13065, 30));
		AddSpawnPoint( "f_rokas_26.Id5", "f_rokas_26", Spot(-1349.884, 1310.8397, 30));
		AddSpawnPoint( "f_rokas_26.Id5", "f_rokas_26", Spot(-1160.3293, 1624.3604, 30));
		AddSpawnPoint( "f_rokas_26.Id5", "f_rokas_26", Spot(-954.1534, 1440.7874, 30));
		AddSpawnPoint( "f_rokas_26.Id5", "f_rokas_26", Spot(-62.84725, 1537.3638, 30));
		AddSpawnPoint( "f_rokas_26.Id5", "f_rokas_26", Spot(72.24407, 1753.6157, 30));
		AddSpawnPoint( "f_rokas_26.Id5", "f_rokas_26", Spot(-1098.7213, 490.1299, 30));
		AddSpawnPoint( "f_rokas_26.Id5", "f_rokas_26", Spot(-1323.9583, 870.0114, 30));
		AddSpawnPoint( "f_rokas_26.Id5", "f_rokas_26", Spot(-1209.896, 884.62933, 30));
		AddSpawnPoint( "f_rokas_26.Id5", "f_rokas_26", Spot(-1136.6611, 1435.466, 30));
		AddSpawnPoint( "f_rokas_26.Id5", "f_rokas_26", Spot(-970.6995, 1731.4965, 30));
		AddSpawnPoint( "f_rokas_26.Id5", "f_rokas_26", Spot(-141.10034, 1700.2334, 30));
		AddSpawnPoint( "f_rokas_26.Id5", "f_rokas_26", Spot(163.18912, 1628.5494, 30));
		AddSpawnPoint( "f_rokas_26.Id5", "f_rokas_26", Spot(82.62037, 1509.5471, 30));

		// Wendigo_Mage Spawn Points
		AddSpawnPoint( "f_rokas_26.Id6", "f_rokas_26", Spot(894.41583, -994.5152, 30));
		AddSpawnPoint( "f_rokas_26.Id6", "f_rokas_26", Spot(-1342.2953, 131.50636, 30));
		AddSpawnPoint( "f_rokas_26.Id6", "f_rokas_26", Spot(-1094.0555, 475.49478, 30));
		AddSpawnPoint( "f_rokas_26.Id6", "f_rokas_26", Spot(-948.20294, 1600.0142, 30));
		AddSpawnPoint( "f_rokas_26.Id6", "f_rokas_26", Spot(-1276.1552, 1439.4823, 30));
		AddSpawnPoint( "f_rokas_26.Id6", "f_rokas_26", Spot(-36.302837, 1707.7029, 30));
		AddSpawnPoint( "f_rokas_26.Id6", "f_rokas_26", Spot(71.47558, 1597.553, 30));
		AddSpawnPoint( "f_rokas_26.Id6", "f_rokas_26", Spot(1001.2807, -1160.6936, 30));
		AddSpawnPoint( "f_rokas_26.Id6", "f_rokas_26", Spot(1008.9624, -835.9985, 30));
		AddSpawnPoint( "f_rokas_26.Id6", "f_rokas_26", Spot(988.56915, -1917.7876, 30));
		AddSpawnPoint( "f_rokas_26.Id6", "f_rokas_26", Spot(1235.7941, -2035.0109, 30));
		AddSpawnPoint( "f_rokas_26.Id6", "f_rokas_26", Spot(1203.6719, -1768.0676, 30));
		AddSpawnPoint( "f_rokas_26.Id6", "f_rokas_26", Spot(1092.4457, -1873.9415, 30));
		AddSpawnPoint( "f_rokas_26.Id6", "f_rokas_26", Spot(-70.56787, 1573.1927, 30));

	}
}
