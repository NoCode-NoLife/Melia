//--- Melia Script -----------------------------------------------------------
// d_thorn_21
//
//--- Description -----------------------------------------------------------
// Sets up the d_thorn_21 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DThorn21MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_thorn_21", MonsterId.Matsum, Properties("MHP", 46946, "MINPATK", 1105, "MAXPATK", 1259, "MINMATK", 1105, "MAXMATK", 1259, "DEF", 197, "MDEF", 197));
		AddPropertyOverrides("d_thorn_21", MonsterId.Chafperor, Properties("MHP", 47839, "MINPATK", 1116, "MAXPATK", 1273, "MINMATK", 1116, "MAXMATK", 1273, "DEF", 198, "MDEF", 198));
		AddPropertyOverrides("d_thorn_21", MonsterId.Ammon, Properties("MHP", 48746, "MINPATK", 1128, "MAXPATK", 1288, "MINMATK", 1128, "MAXMATK", 1288, "DEF", 199, "MDEF", 199));

		// Monster Spawners --------------------------------

		AddSpawner("d_thorn_21.Id1", MonsterId.Matsum, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_21.Id2", MonsterId.Rootcrystal_01, 15, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_thorn_21.Id3", MonsterId.Matsum, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_21.Id4", MonsterId.Chafperor, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_21.Id5", MonsterId.Chafperor, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_21.Id6", MonsterId.Ammon, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_21.Id7", MonsterId.Matsum, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_21.Id8", MonsterId.Infroholder_Mage, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_21.Id9", MonsterId.Infroholder_Mage, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Matsum Spawn Points
		AddSpawnPoint( "d_thorn_21.Id1", "d_thorn_21", Spot(1757.1486, 27.663185, 9999));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(72.77144, -39.38771, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(921.461, 118.80305, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(1247.6375, 45.39395, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(769.1818, 81.62121, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(878.9601, 599.0032, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(895.135, 923.43164, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(1409.3766, 1102.6736, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(1476.2648, 1295.955, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(1746.7504, 1241.5304, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(1668.463, 1037.216, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(2281.0168, 1436.9515, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(2040.9397, 1364.8846, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(2360.8254, 1313.5062, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(2931.3462, 1213.8942, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(5141.0337, -203.81564, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(3295.3403, 1118.5864, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(3120.7666, 1211.7893, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(823, -562, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(888.14594, -1175.6289, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(1338.5209, -1039.67, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(920.25085, -208.70482, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(1120.339, -1272.1024, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(993.76965, -1468.4265, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(1595.4456, -1067.399, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(1827.5634, -1008.0117, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(2422.084, -1160.1775, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(2725.5146, -1130.3284, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(2608.5156, -1376.185, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(1807, 27, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(1934, -36, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(1934, -203, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(2599, 422, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(3309.1965, -276.24326, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(3467.7197, -479.16724, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(3726.8816, -439.6291, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(4407.8, -189.85252, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(4650.6157, -124.9798, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(4796.2583, -225.70631, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(5540.859, -228.55682, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(5879.357, -236.01855, 200));
		AddSpawnPoint( "d_thorn_21.Id2", "d_thorn_21", Spot(2827.6602, 337.4762, 200));

		// Matsum Spawn Points
		AddSpawnPoint( "d_thorn_21.Id3", "d_thorn_21", Spot(1380.6516, 1073.5006, 25));
		AddSpawnPoint( "d_thorn_21.Id3", "d_thorn_21", Spot(1428.4888, 1293.3055, 25));
		AddSpawnPoint( "d_thorn_21.Id3", "d_thorn_21", Spot(1648.1229, 1044.516, 25));
		AddSpawnPoint( "d_thorn_21.Id3", "d_thorn_21", Spot(1664.4006, 1320.9601, 25));
		AddSpawnPoint( "d_thorn_21.Id3", "d_thorn_21", Spot(913.66156, 857.8908, 25));
		AddSpawnPoint( "d_thorn_21.Id3", "d_thorn_21", Spot(965.24396, 1043.8346, 25));
		AddSpawnPoint( "d_thorn_21.Id3", "d_thorn_21", Spot(846.40826, 944.736, 25));
		AddSpawnPoint( "d_thorn_21.Id3", "d_thorn_21", Spot(1550.0206, 1228.7615, 25));
		AddSpawnPoint( "d_thorn_21.Id3", "d_thorn_21", Spot(1748.5543, 1194.1893, 25));
		AddSpawnPoint( "d_thorn_21.Id3", "d_thorn_21", Spot(1902.5503, 1404.2194, 25));
		AddSpawnPoint( "d_thorn_21.Id3", "d_thorn_21", Spot(1968.4153, 1305.985, 25));
		AddSpawnPoint( "d_thorn_21.Id3", "d_thorn_21", Spot(1346.2823, 1184.1682, 25));
		AddSpawnPoint( "d_thorn_21.Id3", "d_thorn_21", Spot(2468.3186, -1242.1716, 25));
		AddSpawnPoint( "d_thorn_21.Id3", "d_thorn_21", Spot(2526.0796, -1376.9376, 25));
		AddSpawnPoint( "d_thorn_21.Id3", "d_thorn_21", Spot(2734.7866, -1286.911, 25));
		AddSpawnPoint( "d_thorn_21.Id3", "d_thorn_21", Spot(2746.427, -1148.8962, 25));
		AddSpawnPoint( "d_thorn_21.Id3", "d_thorn_21", Spot(2519.6829, -1123.0706, 25));
		AddSpawnPoint( "d_thorn_21.Id3", "d_thorn_21", Spot(2599.4756, -1212.1168, 25));
		AddSpawnPoint( "d_thorn_21.Id3", "d_thorn_21", Spot(2664.9524, -1398.87, 25));
		AddSpawnPoint( "d_thorn_21.Id3", "d_thorn_21", Spot(2396.142, -1143.1467, 25));

		// Chafperor Spawn Points
		AddSpawnPoint( "d_thorn_21.Id4", "d_thorn_21", Spot(1685.2189, 1220.8176, 9999));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(1909.4109, 14.230663, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(1555.517, -1009.1306, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(1147.3901, -1086.0521, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(1778.0083, -1006.223, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(890.48376, -1300.6722, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(1128.9983, -1253.2965, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(2158.805, 1370.4137, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(2251.1528, 1470.3317, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(1648.2377, 1029.4897, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(1486.4159, 1304.442, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(1702.1409, -194.51215, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(973.1894, -1160.886, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(1684.9624, -1093.7141, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(1721.2502, 49.625923, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(1623.6982, -70.553566, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(1923.0854, -113.07788, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(1692.7091, 1144.575, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(1078.2408, -1364.932, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(1668.15, -972.8998, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(890.0332, -1136.7402, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(1865.9677, -222.07999, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(3016.4985, 1057.8936, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(3144.4678, 1306.7463, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(3214.1245, 1027.6534, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(2979.1333, 1276.1603, 30));
		AddSpawnPoint( "d_thorn_21.Id5", "d_thorn_21", Spot(3097.049, 1180.2433, 30));

		// Ammon Spawn Points
		AddSpawnPoint( "d_thorn_21.Id6", "d_thorn_21", Spot(794.4534, 83.33458, 9999));

		// Matsum Spawn Points
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(103.17443, 109.79167, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(-90.51573, -121.86644, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(766.4729, -27.532925, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(953.81085, 99.06822, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(828.80994, 437.3472, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2774.7322, -1340.2036, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2566.521, -1341.3607, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2490.2747, -1318.9038, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2622.6057, -1430.697, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2712.6262, -1228.8453, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2766.9707, -1099.8313, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2677.6453, -1082.3345, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2373.22, -1302.2332, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2473.8584, -1119.2971, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2484.9902, -1037.0999, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2397.5828, -1439.9061, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1106.5874, -1048.3683, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1125.6024, -1194.0186, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(946.04767, -1172.8285, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(831.6635, -1062.8419, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(812.55884, -1376.3706, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(816.3818, -1200.6565, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(908.858, -1278.2568, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(968.86505, -1336.092, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(971.34985, -1451.6816, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1071.8185, -1436.7179, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1209.1361, -1241.3499, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1046.0793, -1326.0721, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(569.8401, 88.04193, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(616.8621, 264.66592, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(860.94025, 177.38403, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(776.6738, 92.45004, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(106.48225, -47.39998, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(7.830559, 31.279793, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(-207.58302, -196.00928, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(-4.130513, -120.67903, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(301.3812, 12.229095, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(-25.546232, 112.29422, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(-242.33546, 135.5884, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(-183.25789, -8.363388, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1787.3306, -241.27525, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1708.3839, -38.403862, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1772.7825, -103.11785, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1898.7224, -137.14513, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1849.1858, -120.67808, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1843.4908, -48.401115, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1814.9706, 2.6988392, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1796.3383, 78.631744, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1759.2715, 90.27899, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1948.9448, 32.19836, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1962.2073, -32.196404, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1961.9204, -55.694817, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2001.6422, -97.818565, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2025.7136, -21.421326, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2022.3004, 39.97587, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(3624.1965, -491.06046, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(3469.434, -527.9612, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(3511.7393, -347.35312, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(3602.1646, -245.74953, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(3532.6836, -214.80788, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(3379.811, -295.17917, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(3391.5422, -382.56396, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(4341.3438, -214.97736, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(4279.3853, -313.97934, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(4512.073, -186.87526, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(4523.291, -103.96696, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(4624.8066, -262.08078, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(4702.1777, -113.6165, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(4808.039, -134.52686, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(4855.1997, -241.31198, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(4452.437, -299.6112, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(4396.9917, -267.52505, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(3244.3005, 1237.5461, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(3119.5005, 1275.8984, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(3282.2249, 1072.678, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(3019.8035, 1159.3918, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(3163.9038, 1145.3339, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(3092.313, 990.1165, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(3052.159, 1074.0188, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2957.3188, 990.82025, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2859.1738, 1247.4596, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2955.429, 1240.9232, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(3009.2593, 1321.675, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2299.879, 1289.1123, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2186.4226, 1446.6794, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2093.5134, 1330.6606, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2351.2793, 1415.6866, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2366.7026, 1349.2991, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2266.5154, 1394.5052, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(2215.2275, 1281.0889, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1834.9094, 1374.1731, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1850.7827, 1316.5138, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1958.8711, 1387.7063, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1725.2246, 1236.0681, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1712.4506, 1085.9448, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1586.989, 1004.7706, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1490.7069, 1074.781, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1583.4086, 1127.3523, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1552.4824, 1286.1095, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1363.556, 1248.1389, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1379.4314, 1313.927, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1712.5576, 1351.3513, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1623.6676, 1214.0859, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(1028.6097, 989.7597, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(907.30646, 1050.7302, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(801.2752, 925.7943, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(884.8189, 863.7394, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(908.2703, 764.0287, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(974.92633, 929.8327, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(840.418, 331.5488, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(879.4939, 458.1122, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(696.5368, 93.70234, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(718.7595, 207.55383, 20));
		AddSpawnPoint( "d_thorn_21.Id7", "d_thorn_21", Spot(660.91956, -34.779724, 20));

		// Infroholder_Mage Spawn Points
		AddSpawnPoint( "d_thorn_21.Id8", "d_thorn_21", Spot(815.1485, -1084.2322, 30));
		AddSpawnPoint( "d_thorn_21.Id8", "d_thorn_21", Spot(1091.9635, -1300.608, 30));
		AddSpawnPoint( "d_thorn_21.Id8", "d_thorn_21", Spot(1243.9862, -1065.2133, 30));
		AddSpawnPoint( "d_thorn_21.Id8", "d_thorn_21", Spot(1637.9567, -944.67773, 30));
		AddSpawnPoint( "d_thorn_21.Id8", "d_thorn_21", Spot(1815.6641, -1084.075, 30));
		AddSpawnPoint( "d_thorn_21.Id9", "d_thorn_21", Spot(3414.4111, -459.06192, 30));
		AddSpawnPoint( "d_thorn_21.Id9", "d_thorn_21", Spot(3673.469, -418.80933, 30));
		AddSpawnPoint( "d_thorn_21.Id9", "d_thorn_21", Spot(4456.3984, -76.69896, 30));
		AddSpawnPoint( "d_thorn_21.Id9", "d_thorn_21", Spot(4546.692, -218.86513, 30));
		AddSpawnPoint( "d_thorn_21.Id9", "d_thorn_21", Spot(4788.827, -198.43614, 30));
		AddSpawnPoint( "d_thorn_21.Id9", "d_thorn_21", Spot(4673.6704, -88.1009, 30));
		AddSpawnPoint( "d_thorn_21.Id9", "d_thorn_21", Spot(3541.261, -263.9928, 30));
		AddSpawnPoint( "d_thorn_21.Id9", "d_thorn_21", Spot(3381.5176, -287.4248, 30));
		AddSpawnPoint( "d_thorn_21.Id9", "d_thorn_21", Spot(1601.7301, 1254.8358, 30));
		AddSpawnPoint( "d_thorn_21.Id9", "d_thorn_21", Spot(1401.1201, 1058.0656, 30));
		AddSpawnPoint( "d_thorn_21.Id9", "d_thorn_21", Spot(1385.4783, 1353.6147, 30));

	}
}
