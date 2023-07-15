//--- Melia Script -----------------------------------------------------------
// f_desolated_capital_53_1
//
//--- Description -----------------------------------------------------------
// Sets up the f_desolated_capital_53_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FDesolatedCapital531MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_desolated_capital_53_1", MonsterId.Orc_Double_Axe, Properties("MHP", 807799, "MINPATK", 10888, "MAXPATK", 13285, "MINMATK", 10888, "MAXMATK", 13285, "DEF", 275842, "MDEF", 275842));
		AddPropertyOverrides("f_desolated_capital_53_1", MonsterId.Orc_Shield, Properties("MHP", 810189, "MINPATK", 10919, "MAXPATK", 13322, "MINMATK", 10919, "MAXMATK", 13322, "DEF", 277855, "MDEF", 277855));
		AddPropertyOverrides("f_desolated_capital_53_1", MonsterId.Orc_Wand, Properties("MHP", 812610, "MINPATK", 10950, "MAXPATK", 13361, "MINMATK", 10950, "MAXMATK", 13361, "DEF", 279894, "MDEF", 279894));
		AddPropertyOverrides("f_desolated_capital_53_1", MonsterId.Orc_Leader, Properties("MHP", 815061, "MINPATK", 10982, "MAXPATK", 13399, "MINMATK", 10982, "MAXMATK", 13399, "DEF", 281959, "MDEF", 281959));

		// Monster Spawners --------------------------------

		AddSpawner(MonsterId.Orc_Double_Axe, 45, "SpawnPointCollection1.f_desolated_capital_53_1", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Orc_Shield, 45, "SpawnPointCollection2.f_desolated_capital_53_1", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Orc_Wand, 35, "SpawnPointCollection3.f_desolated_capital_53_1", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Orc_Leader, 8, "SpawnPointCollection4.f_desolated_capital_53_1", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Orc_Double_Axe, 10, "SpawnPointCollection5.f_desolated_capital_53_1", TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Rootcrystal_01, 30, "SpawnPointCollection6.f_desolated_capital_53_1", TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Orc_Double_Axe Spawn Points
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2013.0969, 1561.8158, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1890.2863, 1431.8815, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1854.939, 1581.9618, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2092.8752, 1456.4655, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2606.3057, 1904.9359, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2508.6042, 1824.2368, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2641.4226, 1704.74, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2834.5679, 1870.7784, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2734.222, 1813.1177, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(883.0486, 1280.4231, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1049.1134, 1619.1913, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1305.4207, 1507.7242, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1089.8595, 1161.5315, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(937.41064, 1729.7, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1469.1289, 1786.6727, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2018.1553, 1743.4095, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2139.2932, 1684.8053, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2500.1726, 1501.6938, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2438.8525, 1275.3251, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2208.8682, 1124.6742, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2565.893, 1340.7966, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3341.2651, 1669.2058, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3112.5725, 1536.6686, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3254.4573, 1369.9438, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3361.705, 1366.844, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3340.0923, 1546.962, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3247.4587, 1775.3937, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(952.70795, 1201.0054, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2827.4443, 3247.5413, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2648.8206, 1995.8085, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2468.8567, 1922.973, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2655.3096, 1808.3405, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3410.753, 1213.404, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3268.9648, 1463.0249, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3455.8276, 1543.8573, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3249.3374, 1695.7357, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3392.7407, 1483.9185, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3189.2544, 1582.1396, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3080.2043, 1772.931, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(821.486, 1508.7306, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3150.9578, 1654.5247, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2765.1584, 1690.1805, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2938.4456, 1776.7035, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3127.973, 1426.2378, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3125.6526, 1331.754, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1027.0642, 1948.3666, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1661.2091, 1668.0355, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3470.865, 1323.3169, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1615.7141, 1749.4071, 30), "SpawnPointCollection1.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2156.188, 2863.4514, 30), "SpawnPointCollection1.f_desolated_capital_53_1");

		// Orc_Shield Spawn Points
		AddSpawnPoint("f_desolated_capital_53_1", Spot(887.3351, 2549.0679, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1027.0452, 2613.6274, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(886.67035, 2776.415, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(896.472, 2795.974, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1167.8945, 3202.0857, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1185.2825, 3074.4807, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(957.6197, 3098.3125, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1019.9845, 2050.3855, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(825.9416, 1945.1681, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(979.6374, 1865.2583, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1134.47, 1893.5638, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(782.985, 1255.3965, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(983.04114, 1430.5814, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1026.7502, 1291.9966, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(797.44574, 1392.0449, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(973.5508, 1114.8502, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1255.8634, 1284.6743, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1190.9305, 1400.8818, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1479.3685, 1590.6428, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1241.3826, 1812.7969, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(691.36786, 1153.0432, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(884.00494, 2951.4512, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1065.6923, 1393.0277, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(846.6474, 2661.922, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(885.24384, 1371.1848, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1887.3202, 592.90155, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1781.353, 792.2582, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2092.0217, 752.41016, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2155.7566, 964.81085, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2057.2744, 828.1524, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2477.3772, 2432.0781, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2412.6147, 2361.3704, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2207.8767, 2316.8064, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2646.9187, 2424.4543, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1960.1819, 821.5836, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2034.3257, 472.161, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2584.9631, 681.5992, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2757.1182, 785.8433, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2985.7356, 727.76495, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3069.6072, 772.5316, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3005.7686, 586.0091, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1170.4526, 1248.1438, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2692.7566, 713.87933, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2747.6196, 527.981, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1108.1461, 1496.1769, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(823.56335, 1141.298, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2091.0007, 633.9091, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2306.6948, 511.3699, 30), "SpawnPointCollection2.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2476.4155, 586.9546, 30), "SpawnPointCollection2.f_desolated_capital_53_1");

		// Orc_Wand Spawn Points
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2368.6812, 2765.4414, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2238.2847, 3000.461, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2539.788, 2431.4038, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2618.9775, 3398.0344, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2559.1887, 3166.7432, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3003.3132, 3312.858, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2292.541, 2442.401, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2835.7527, 3038.204, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2509.8965, 3274.5325, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2327.989, 2844.547, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(929.9424, 1938.6094, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2753.626, 1948.7843, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(658.0664, 1439.9817, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2230.8354, 2758.1487, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(700.8671, 1273.893, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(858.31616, 2686.0876, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2001.9711, 1649.2825, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1995.949, 1486.0665, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2585.5908, 1503.5065, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2270.8865, 1191.7528, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2097.1587, 1098.314, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2076.2205, 926.8033, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1877.2911, 774.3292, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2125.314, 1519.0958, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1981.2667, 643.17957, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1807.6284, 676.32904, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2144.6414, 530.9434, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2577.8606, 662.18146, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2679.7854, 813.7614, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2969.2253, 876.3543, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3055.873, 673.93225, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2950.5085, 498.64783, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2811.9045, 452.01865, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2682.8704, 609.82745, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2837.1926, 854.1093, 35), "SpawnPointCollection3.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2921.1423, 638.18066, 35), "SpawnPointCollection3.f_desolated_capital_53_1");

		// Orc_Leader Spawn Points
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1979.724, 543.1084, 100), "SpawnPointCollection4.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2781.6182, 606.8401, 100), "SpawnPointCollection4.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2352.93, 1282.8618, 100), "SpawnPointCollection4.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2071.701, 1566.7034, 100), "SpawnPointCollection4.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1120.4071, 1322.7576, 100), "SpawnPointCollection4.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1119.1859, 1997.622, 100), "SpawnPointCollection4.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2777.4604, 3210.6323, 100), "SpawnPointCollection4.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2325.9563, 2953.9983, 100), "SpawnPointCollection4.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2972.6309, 3087.555, 100), "SpawnPointCollection4.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1156.8726, 3129.8516, 100), "SpawnPointCollection4.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(946.3742, 2656.1177, 100), "SpawnPointCollection4.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2610.6882, 1884.0605, 100), "SpawnPointCollection4.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(718.0596, 1357.3379, 100), "SpawnPointCollection4.f_desolated_capital_53_1");

		// Orc_Double_Axe Spawn Points
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2236.2769, 2909.9084, 25), "SpawnPointCollection5.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2226.4548, 3088.4722, 25), "SpawnPointCollection5.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2142.4304, 3078.864, 25), "SpawnPointCollection5.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(887.7497, 2046.8917, 25), "SpawnPointCollection5.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2329.2412, 2324.4763, 25), "SpawnPointCollection5.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2618.271, 3278.5437, 25), "SpawnPointCollection5.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2734.6577, 3070.2527, 25), "SpawnPointCollection5.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2872.6064, 3136.4521, 25), "SpawnPointCollection5.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3001.9658, 3191.12, 25), "SpawnPointCollection5.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2958.0247, 3388.9058, 25), "SpawnPointCollection5.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2840.674, 3391.0703, 25), "SpawnPointCollection5.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2767.4143, 3445.322, 25), "SpawnPointCollection5.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2517.796, 3363.4756, 25), "SpawnPointCollection5.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2673.2507, 3177.0107, 25), "SpawnPointCollection5.f_desolated_capital_53_1");

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2476.185, 2282.6602, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3406.6436, 1235.2179, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3412.7134, 1491.1047, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3128.6306, 1468.9966, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3181.9568, 1828.3444, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3230.5735, 1630.3188, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2945.539, 1824.2726, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2689.7573, 1751.2654, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2433.815, 1912.2485, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2673.736, 1955.7522, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2631.017, 2430.6892, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2284.8098, 2393.6958, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1968.3212, 2348.5212, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1760.0054, 2140.9324, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1506.9315, 2078.5505, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1371.7568, 2555.8506, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1719.4563, 2488.9392, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1769.4377, 2739.8213, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2156.4739, 2935.5015, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1938.0444, 2889.8828, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2250.0254, 3132.7178, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2308.7861, 2784.19, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2354.6829, 3022.1501, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2636.023, 3081.817, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2867.3958, 3075.4023, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(3030.8872, 3247.832, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2883.5251, 3457.7642, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2541.069, 3407.2402, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2511.5757, 3230.7156, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1841.387, 2377.431, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1071.7561, 2600.9644, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(891.20087, 2597.1895, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(883.7714, 2805.5093, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(901.0854, 3103.6245, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1168.0619, 3058.3545, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1229.0593, 3235.63, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1351.9307, 2267.937, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1208.8032, 2022.6453, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(991.9233, 2056.059, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(792.9408, 1950.5638, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1025.0563, 1917.7778, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1063.451, 1645.2903, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1289.9988, 1868.0895, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1450.7205, 1651.4219, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1258.4966, 1386.546, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1046.2369, 1209.0487, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(824.0319, 1169.1794, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(678.4528, 1405.0485, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(973.3545, 1415.8236, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1594.5525, 1850.7393, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1750.8485, 1610.8499, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1937.5422, 1485.9447, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2173.5989, 1507.9794, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1957.0782, 1668.8003, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2477.836, 1489.2759, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2510.053, 1336.4467, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2293.9805, 1251.7339, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2100.0427, 1043.3997, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2110.6807, 748.38696, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2017.2366, 547.1924, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1883.124, 773.8962, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(1735.0198, 994.91565, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2275.519, 506.16257, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2525.812, 642.3577, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2625.0605, 843.4464, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2704.664, 640.27124, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2877.5544, 504.84235, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2992.436, 654.2704, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2944.8994, 886.67896, 100), "SpawnPointCollection6.f_desolated_capital_53_1");
		AddSpawnPoint("f_desolated_capital_53_1", Spot(2776.5894, 842.266, 100), "SpawnPointCollection6.f_desolated_capital_53_1");

	}
}
