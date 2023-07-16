//--- Melia Script -----------------------------------------------------------
// f_remains_40
//
//--- Description -----------------------------------------------------------
// Sets up the f_remains_40 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRemains40MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_remains_40", MonsterId.Big_Cockatries, Properties("MHP", 88758, "MINPATK", 1642, "MAXPATK", 1920, "MINMATK", 1642, "MAXMATK", 1920, "DEF", 812, "MDEF", 812));
		AddPropertyOverrides("f_remains_40", MonsterId.Cockatries, Properties("MHP", 88029, "MINPATK", 1633, "MAXPATK", 1909, "MINMATK", 1633, "MAXMATK", 1909, "DEF", 789, "MDEF", 789));
		AddPropertyOverrides("f_remains_40", MonsterId.Hallowventor, Properties("MHP", 87369, "MINPATK", 1624, "MAXPATK", 1898, "MINMATK", 1624, "MAXMATK", 1898, "DEF", 767, "MDEF", 767));

		// Monster Spawners --------------------------------

		AddSpawner("f_remains_40.Id1", MonsterId.Big_Cockatries, 4, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_40.Id2", MonsterId.Cockatries, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_40.Id3", MonsterId.Cockatries, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_40.Id4", MonsterId.Hallowventor, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_40.Id5", MonsterId.Hallowventor, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_40.Id6", MonsterId.Cockatries, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_40.Id7", MonsterId.Hallowventor, 16, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_40.Id8", MonsterId.Rootcrystal_01, 23, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_remains_40.Id9", MonsterId.Big_Cockatries, 1, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Big_Cockatries Spawn Points
		AddSpawnPoint( "f_remains_40.Id1", "f_remains_40", Spot(1330.0208, 951.3546, 9999));

		// Cockatries Spawn Points
		AddSpawnPoint( "f_remains_40.Id2", "f_remains_40", Spot(-817, -1216, 9999));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-2087.71, -2050.84, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-653.4018, -465.66766, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(743.5562, -176.02809, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-2153.7925, -1936.2517, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-1955.986, -1976.2568, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-2001.2211, -2136.506, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-1961.1086, -2310.6633, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-1968.5369, -2523.7334, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-1318.6434, -546.3363, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-695.02155, -285.2332, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-605.64, -579.8836, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-617.6808, -153.5167, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-576.84155, 58.443356, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(589.3121, -152.85117, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(400.10117, -149.98997, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(703.0059, -361.52142, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(895.3282, -461.1287, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(812.5447, -61.27752, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(809.84515, -306.21848, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-1818.3239, -1903.2778, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-1766.5875, -1816.2458, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-1663.847, -1860.1085, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-1534.8378, -1731.0715, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-1497.9014, -1805.2135, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-1362.6227, -1686.8762, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-1077.0024, -591.2832, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-783.3957, -527.3703, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-730.96857, -145.59343, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-616.90656, -13.487192, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(-733.1245, -371.93796, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(525.15015, -219.96658, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(672.45184, -56.537098, 25));
		AddSpawnPoint( "f_remains_40.Id3", "f_remains_40", Spot(664.80975, -207.07306, 25));

		// Hallowventor Spawn Points
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1399.71, 746.81, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1846.71, 1320.37, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1133.5233, 479.88507, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(970.6489, 837.2935, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1425.8557, 996.2712, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1676.8315, 617.71344, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1791.1456, 455.93323, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(2017.9967, 610.9912, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1738.9983, 860.1713, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1821.6855, 679.63104, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1948.0764, 1122.0615, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1713.6705, 1053.3718, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1715.0198, 1138.5237, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1258.1903, 1309.1653, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1591.5469, 1577.3972, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1935.1958, 1533.1732, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(2199.5269, 1305.2518, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1802.6022, 1538.1146, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1490.3611, 538.48517, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1202.7017, 761.9217, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(-1681.8461, -822.99207, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(-1616.614, -686.6024, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(-1405.943, -584.1658, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(-1442.2167, -798.7303, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(-1459.2235, -873.7049, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(-1435.9084, -1005.704, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(-1198.3328, -926.05255, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(-1255.2838, -1098.5903, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(-1110.0535, -1114.7804, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(-1065.6915, -965.25244, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(-946.9504, -961.2765, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(-1178.3214, -1032.2136, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(-1385.3514, -512.2852, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(-1497.153, -638.21576, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1308.96, 492.54584, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(956.9093, 635.7855, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1215.8042, 1052.2949, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1524.9565, 815.9131, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1665.4921, 422.39343, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1913.5312, 902.9942, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1619.0968, 1241.455, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(1518.5817, 1389.2363, 25));
		AddSpawnPoint( "f_remains_40.Id4", "f_remains_40", Spot(2032.2496, 1237.5508, 25));
		AddSpawnPoint( "f_remains_40.Id5", "f_remains_40", Spot(12.57, -162.17, 9999));

		// Cockatries Spawn Points
		AddSpawnPoint( "f_remains_40.Id6", "f_remains_40", Spot(-1974.6465, -3561.1406, 30));
		AddSpawnPoint( "f_remains_40.Id6", "f_remains_40", Spot(-1819.186, -3472.5781, 30));
		AddSpawnPoint( "f_remains_40.Id6", "f_remains_40", Spot(-1787.6814, -3655.598, 30));
		AddSpawnPoint( "f_remains_40.Id6", "f_remains_40", Spot(-1611.61, -3602.32, 30));
		AddSpawnPoint( "f_remains_40.Id6", "f_remains_40", Spot(-1691.3506, -3465.3062, 30));
		AddSpawnPoint( "f_remains_40.Id6", "f_remains_40", Spot(-1542.39, -3431.3, 30));
		AddSpawnPoint( "f_remains_40.Id6", "f_remains_40", Spot(-1762.3663, -3241.28, 30));
		AddSpawnPoint( "f_remains_40.Id6", "f_remains_40", Spot(-1753.5325, -2878.9075, 30));
		AddSpawnPoint( "f_remains_40.Id6", "f_remains_40", Spot(-1704.27, -3044.78, 30));
		AddSpawnPoint( "f_remains_40.Id6", "f_remains_40", Spot(-1881.0885, -2745.5974, 30));
		AddSpawnPoint( "f_remains_40.Id6", "f_remains_40", Spot(-1887.32, -2566.07, 30));
		AddSpawnPoint( "f_remains_40.Id6", "f_remains_40", Spot(-2024.72, -2641.58, 30));
		AddSpawnPoint( "f_remains_40.Id6", "f_remains_40", Spot(-2111.7117, -3485.372, 30));
		AddSpawnPoint( "f_remains_40.Id6", "f_remains_40", Spot(-1610.08, -3277.61, 30));

		// Hallowventor Spawn Points
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(-2035.41, -3768.74, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(-1998.69, -3945.44, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(-1800.83, -3782.27, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(-1776.21, -3926.15, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(-1780.88, -4099.75, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(-1625.94, -4070.26, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(-1644.6, -3815.81, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(-1950.11, -3538.35, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(-1723.23, -3543.76, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(-1647.97, -3682.13, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(-291.03613, -422.17313, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(-304.79523, -220.3271, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(-224.63971, -327.46463, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(-173.64801, -144.46182, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(-157.59439, -36.727585, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(26.215973, -142.49458, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(-52.104725, -227.97568, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(-125.07616, -310.7868, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(-113.00282, -473.757, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(29.331934, -445.841, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(66.54909, -269.79355, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(57.52424, -27.060843, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(-34.451145, 104.34879, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(84.27447, 139.83676, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(192.91864, -107.79709, 30));
		AddSpawnPoint( "f_remains_40.Id7", "f_remains_40", Spot(-445.47946, -241.85254, 30));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-1371.96, -1724.25, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-1726.74, -1856.72, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-2305.73, -1681.23, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-1998.62, -2228.26, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-1920.39, -2588.78, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-1825.94, -2918.86, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-1684.3, -3273.92, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-1894.56, -3649.59, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-1907.85, -4002.53, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-1625.35, -3657.88, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-814.94, -1246.68, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-1026.65, -911.78, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-1203.64, -1084.3, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-1489.9, -893.36, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-1735.89, -540.72, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-1413.67, -618.79, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-1006.73, -600.02, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-664.27, -375.6, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-285.41, -378.1, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-135, -38.64, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-11.74, -368.94, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(101.53, 121.52, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-82.17, -774.99, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(-52.23, -1092.86, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(33.4, -1532.82, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(562.11, -163.76, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(828.07, -374.53, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(799.82, -95.96, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(1056.3, 579.07, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(1050.16, 860.85, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(1338.7, 1076.12, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(1581.34, 623.95, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(1756.91, 591.07, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(1755.26, 1022.7, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(1730.21, 1365.76, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(2109.47, 1402.71, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(1952.73, 1896.26, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(1955.16, 2265.34, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(1942.32, 3171.89, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(1766.21, 2951.85, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(1983.17, 2781.08, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(2348.23, 3567.54, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(2578.95, 3621.92, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(2649.83, 3429.85, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(3043.87, 3219.07, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(2899.18, 3181.13, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(3200.16, 2914.65, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(3322.4, 2550.66, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(3370.61, 2692.33, 100));
		AddSpawnPoint( "f_remains_40.Id8", "f_remains_40", Spot(3544.31, 2603.05, 100));

		// Big_Cockatries Spawn Points
		AddSpawnPoint( "f_remains_40.Id9", "f_remains_40", Spot(1533, 3160, 30));
		AddSpawnPoint( "f_remains_40.Id9", "f_remains_40", Spot(1763, 3097, 30));
		AddSpawnPoint( "f_remains_40.Id9", "f_remains_40", Spot(1822, 2862, 30));
		AddSpawnPoint( "f_remains_40.Id9", "f_remains_40", Spot(1906, 2947, 30));
		AddSpawnPoint( "f_remains_40.Id9", "f_remains_40", Spot(2013, 2994, 30));
		AddSpawnPoint( "f_remains_40.Id9", "f_remains_40", Spot(1925, 2784, 30));
		AddSpawnPoint( "f_remains_40.Id9", "f_remains_40", Spot(1903, 2674, 30));
		AddSpawnPoint( "f_remains_40.Id9", "f_remains_40", Spot(1944, 2057, 30));
		AddSpawnPoint( "f_remains_40.Id9", "f_remains_40", Spot(2264, 3733, 30));
		AddSpawnPoint( "f_remains_40.Id9", "f_remains_40", Spot(2452, 3686, 30));
		AddSpawnPoint( "f_remains_40.Id9", "f_remains_40", Spot(2368, 3517, 30));
		AddSpawnPoint( "f_remains_40.Id9", "f_remains_40", Spot(2574, 3399, 30));
		AddSpawnPoint( "f_remains_40.Id9", "f_remains_40", Spot(2746, 3504, 30));
		AddSpawnPoint( "f_remains_40.Id9", "f_remains_40", Spot(2948, 3183, 30));

	}
}
