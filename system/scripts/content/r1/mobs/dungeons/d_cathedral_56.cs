//--- Melia Script -----------------------------------------------------------
// d_cathedral_56
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Sanctuary' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCathedral56MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_cathedral_56", MonsterId.Pawnd_Purple, Properties("MHP", 159308, "MINPATK", 2550, "MAXPATK", 3036, "MINMATK", 2550, "MAXMATK", 3036, "DEF", 3970, "MDEF", 3970));
		AddPropertyOverrides("d_cathedral_56", MonsterId.Pawndel_Blue, Properties("MHP", 161304, "MINPATK", 2576, "MAXPATK", 3067, "MINMATK", 2576, "MAXMATK", 3067, "DEF", 4085, "MDEF", 4085));
		AddPropertyOverrides("d_cathedral_56", MonsterId.NightMaiden_Bow, Properties("MHP", 163337, "MINPATK", 2602, "MAXPATK", 3099, "MINMATK", 2602, "MAXMATK", 3099, "DEF", 4203, "MDEF", 4203));
		AddPropertyOverrides("d_cathedral_56", MonsterId.Stoulet_Blue, Properties("MHP", 165407, "MINPATK", 2628, "MAXPATK", 3132, "MINMATK", 2628, "MAXMATK", 3132, "DEF", 4322, "MDEF", 4322));
		AddPropertyOverrides("d_cathedral_56", MonsterId.Boss_Naktis, Properties("MHP", 1398732, "MINPATK", 8365, "MAXPATK", 9970, "MINMATK", 8365, "MAXMATK", 9970, "DEF", 13997, "MDEF", 13997));

		// Monster Spawners ---------------------------------

		AddSpawner("d_cathedral_56.Id1", MonsterId.Pawnd_Purple, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_56.Id2", MonsterId.Pawndel_Blue, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_56.Id3", MonsterId.Rootcrystal_03, 19, 25, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_cathedral_56.Id4", MonsterId.Pawnd_Purple, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_56.Id5", MonsterId.NightMaiden_Bow, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Pawnd_Purple' GenType 2 Spawn Points
		AddSpawnPoint("d_cathedral_56.Id1", "d_cathedral_56", Rectangle(-965.3782, -50.65103, 25));
		AddSpawnPoint("d_cathedral_56.Id1", "d_cathedral_56", Rectangle(-1599.1981, -724.08057, 25));
		AddSpawnPoint("d_cathedral_56.Id1", "d_cathedral_56", Rectangle(-1111.9592, 96.021095, 25));
		AddSpawnPoint("d_cathedral_56.Id1", "d_cathedral_56", Rectangle(-925.1197, 143.0874, 25));
		AddSpawnPoint("d_cathedral_56.Id1", "d_cathedral_56", Rectangle(-624.19666, -46.105415, 25));
		AddSpawnPoint("d_cathedral_56.Id1", "d_cathedral_56", Rectangle(-1504.5875, 248.4039, 25));
		AddSpawnPoint("d_cathedral_56.Id1", "d_cathedral_56", Rectangle(-256.81122, -52.38856, 25));
		AddSpawnPoint("d_cathedral_56.Id1", "d_cathedral_56", Rectangle(-1062.1284, -307.39774, 25));
		AddSpawnPoint("d_cathedral_56.Id1", "d_cathedral_56", Rectangle(-1632.633, -257.3987, 25));
		AddSpawnPoint("d_cathedral_56.Id1", "d_cathedral_56", Rectangle(-1534.1034, -275.8602, 25));

		// 'Pawndel_Blue' GenType 4 Spawn Points
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-129.32819, -139.671, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1029.2218, -72.62822, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(670.61505, 212.62836, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(508.71515, 646.1905, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1124.5392, 893.8641, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1425.1588, 604.0895, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(768.79205, 927.8426, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(141.01968, -63.31266, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-432.06793, -96.31886, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-542.3518, -148.23547, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(341.37146, 192.47838, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2092.0327, -538.0447, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2055.5078, -495.46442, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2107.8555, -416.99323, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2153.9412, -483.43964, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2142.9058, -536.08466, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2066.7266, -431.5951, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1877.0519, -421.4358, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1831.0216, -373.48355, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1790.0436, -425.9107, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1733.3927, -480.15005, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1713.6711, -542.5935, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1619.8966, -552.8373, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1521.2053, -516.2512, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1473.7449, -549.6432, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1412.8394, -534.7283, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1430.9089, -440.06604, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1437.4141, -364.02594, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1491.4451, -465.89142, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1572.9115, -389.05322, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1581.0773, -479.3523, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1642.6093, -361.54782, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1636.8442, -432.68826, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1757.7997, -366.9718, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1848.9471, -537.0594, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1862.0085, -472.72845, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2156.1504, 137.44931, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2108.936, 128.8751, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2097.996, 79.86743, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2122.614, 208.95581, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2093.654, 254.89967, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1899.2402, 191.94403, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1950.7103, 301.91458, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1865.6445, 311.71005, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1825.8163, 406.2917, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1955.5356, 426.48676, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1969.6339, 102.67098, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1900.5006, 115.77451, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1984.0664, 154.2249, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1902.7377, 50.277683, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1994.556, 44.003155, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2043.3983, 438.1933, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1975.71, 504.46646, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1866.4078, 526.49176, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1804.1, 464.46036, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1760.0432, 520.5553, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1886.3809, 606.30615, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1987.0485, 623.8768, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2004.5165, 553.23816, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2070.4832, 601.197, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2106.1453, 513.0019, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2137.7842, 440.9878, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2102.3608, 357.92685, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2150.434, 299.334, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2046.3662, 377.0541, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2017.914, 295.36295, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1898.5458, 402.63492, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1903.2997, 479.35907, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2161.865, 572.81433, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1799.9323, 287.53305, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1719.9628, 364.0719, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1489.1323, 382.01224, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1514.2849, 420.0348, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1564.0181, 405.97675, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1586.1165, 370.03928, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1390.9637, 455.25974, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1437.4396, 500.12125, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1401.1174, 544.1042, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1353.3951, 504.5751, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1458.6359, 610.838, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1412.577, 652.2231, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1375.5194, 616.1666, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1446.3939, 567.08966, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1445.4674, 784.21533, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1415.9651, 828.2513, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1385.1484, 749.29846, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1366.4167, 816.78314, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1166.6434, 899.0932, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1130.5819, 946.4992, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1081.701, 912.6632, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1092.8385, 865.36316, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(873.97906, 898.1747, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(810.3355, 942.62573, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(733.48505, 950.1038, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(707.2688, 912.68896, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(756.8479, 886.2525, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(817.6092, 887.0566, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(509.67816, 610.4367, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(556.9825, 656.8928, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(523.3626, 690.4541, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(463.49982, 641.8168, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(754.5191, 173.02234, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(517.2803, 261.83075, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(407.64096, 253.6498, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(265.12872, 142.01773, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(188.82251, 86.62071, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(189.11017, 17.298864, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-31.555025, -99.23625, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(83.09609, -157.96043, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-195.68384, -64.51538, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(224.02266, -408.20068, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(171.52731, -315.81766, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-108.45528, -47.900414, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(175.86066, -213.14702, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-368.74658, -124.48295, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-289.82248, -126.51999, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-364.79816, -51.24309, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-478.62772, -140.3748, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-495.596, -55.48844, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-587.371, -93.8494, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-637.9554, -133.79434, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-753.19293, -125.42575, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-714.28296, -74.76591, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-972.06464, -280.77612, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-945.3357, -190.96803, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-885.1075, -149.61693, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1096.7622, -267.13803, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1088.6251, -178.68697, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1095.4844, -48.966747, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-998.43036, 35.42788, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1028.4679, 151.92085, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-881.70447, 113.79481, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-886.11255, 216.33348, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-972.07666, 246.17001, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1101.2585, 219.74164, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-898.5354, 39.134827, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1428.7416, -716.64575, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1439.1982, -548.69617, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1469.6035, -474.82794, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1582.1342, -547.60944, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1574.1779, -479.7833, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1427.6113, -378.36133, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1442.7878, -227.57878, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1609.7906, -342.24725, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1510.419, -609.8795, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1523.0219, -382.96182, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1547.0203, -159.39023, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1552.6832, -47.530167, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1493.7069, -92.64842, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1541.2462, 49.963478, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1627.6179, 123.92502, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1602.0505, 224.75107, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1467.258, 81.20823, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2038.7574, -721.2013, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2049.3494, -576.9668, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1968.9929, -630.1928, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2151.355, -551.98737, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1954.6052, -526.2853, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2103.9878, -421.3485, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1963.8125, -421.99033, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2102.8481, -310.25385, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2098.3064, -230.90631, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1973.183, -296.8223, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1964.2858, -175.8488, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2133.5122, -91.37794, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2057.535, -179.3127, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2310.2512, 379.58582, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2249.6492, 355.39774, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2200.602, 322.58652, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2183.672, 359.7583, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2141.1475, 393.8122, 30));

		// 'Rootcrystal_03' GenType 32 Spawn Points
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(1672.8251, -469.44266, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(2049.4333, -538.68146, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(1911.3092, -84.2361, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(1956.8209, 445.07428, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(1622.364, 386.74216, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(1425.7994, 632.63184, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(1243.999, 893.2882, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(746.8902, 906.985, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(496.09497, 671.17993, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(757.93445, 186.52509, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(215.3634, 89.088455, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-120.13855, -131.64441, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-434.65656, -111.44997, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-1027.2432, -43.383278, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-926.9304, -536.6809, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-468.10706, -635.51355, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-207.11134, -965.3469, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-1282.9047, -523.1897, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-1541.8685, -699.2166, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-1837.8938, -638.03143, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-2084.8445, -506.13025, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-2057.1313, -124.21282, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-1503.0747, -305.3978, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-1567.149, -77.22688, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-1571.0294, 171.70863, 10));

		// 'Pawnd_Purple' GenType 33 Spawn Points
		AddSpawnPoint("d_cathedral_56.Id4", "d_cathedral_56", Rectangle(1703.5851, -403.3806, 30));
		AddSpawnPoint("d_cathedral_56.Id4", "d_cathedral_56", Rectangle(1766.4717, 413.14133, 30));
		AddSpawnPoint("d_cathedral_56.Id4", "d_cathedral_56", Rectangle(-2035.0343, -484.33493, 30));
		AddSpawnPoint("d_cathedral_56.Id4", "d_cathedral_56", Rectangle(-2291.5676, 428.88315, 30));
		AddSpawnPoint("d_cathedral_56.Id4", "d_cathedral_56", Rectangle(-2136.1096, -742.4097, 30));
		AddSpawnPoint("d_cathedral_56.Id4", "d_cathedral_56", Rectangle(-2166.5989, -296.70325, 30));
		AddSpawnPoint("d_cathedral_56.Id4", "d_cathedral_56", Rectangle(-2011.6667, -97.854164, 30));
		AddSpawnPoint("d_cathedral_56.Id4", "d_cathedral_56", Rectangle(-2027.7714, -296.5003, 30));
		AddSpawnPoint("d_cathedral_56.Id4", "d_cathedral_56", Rectangle(-2176.255, 436.87195, 30));

		// 'NightMaiden_Bow' GenType 42 Spawn Points
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(1535.5422, 378.42862, 30));
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(1806.1968, -499.95013, 30));
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(1384.6675, 496.60144, 30));
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(1779.2593, 574.2892, 30));
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(1486.3583, -378.86273, 30));
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(1547.9655, -578.8122, 30));
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(1885.7688, -369.30438, 30));
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(1397.4955, 787.65216, 30));
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(820.31323, 912.0209, 30));
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(1874.2401, 248.55678, 30));
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(2138.2886, 95.751396, 30));
	}
}
