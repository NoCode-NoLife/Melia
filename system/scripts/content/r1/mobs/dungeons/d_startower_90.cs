//--- Melia Script -----------------------------------------------------------
// d_startower_90
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Astral Tower 12F' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DStartower90MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_startower_90", MonsterId.Nasleia, Properties("MHP", 632701, "MINPATK", 8637, "MAXPATK", 10517, "MINMATK", 8637, "MAXMATK", 10517, "DEF", 147392, "MDEF", 147392));
		AddPropertyOverrides("d_startower_90", MonsterId.Madlens, Properties("MHP", 634554, "MINPATK", 8661, "MAXPATK", 10546, "MINMATK", 8661, "MAXMATK", 10546, "DEF", 148502, "MDEF", 148502));
		AddPropertyOverrides("d_startower_90", MonsterId.Grob, Properties("MHP", 636437, "MINPATK", 8685, "MAXPATK", 10576, "MINMATK", 8685, "MAXMATK", 10576, "DEF", 149630, "MDEF", 149630));
		AddPropertyOverrides("d_startower_90", MonsterId.Hafter, Properties("MHP", 638350, "MINPATK", 8710, "MAXPATK", 10606, "MINMATK", 8710, "MAXMATK", 10606, "DEF", 150775, "MDEF", 150775));
		AddPropertyOverrides("d_startower_90", MonsterId.Boss_Riteris_Blue_Q1, Properties("MHP", 3342325, "MINPATK", 22011, "MAXPATK", 26805, "MINMATK", 22011, "MAXMATK", 26805, "DEF", 382885, "MDEF", 382885));
		AddPropertyOverrides("d_startower_90", MonsterId.Boss_Devilglove_Q3, Properties("MHP", 3352612, "MINPATK", 22075, "MAXPATK", 26884, "MINMATK", 22075, "MAXMATK", 26884, "DEF", 385859, "MDEF", 385859));
		AddPropertyOverrides("d_startower_90", MonsterId.Boss_Rambandgad_Q2, Properties("MHP", 3363048, "MINPATK", 22140, "MAXPATK", 26964, "MINMATK", 22140, "MAXMATK", 26964, "DEF", 388876, "MDEF", 388876));

		// Monster Spawners ---------------------------------

		AddSpawner("d_startower_90.Id1", MonsterId.Nasleia, 20, 26, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_90.Id2", MonsterId.Madlens, 24, 31, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_90.Id3", MonsterId.Grob, 26, 34, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_90.Id4", MonsterId.Hafter, 40, 53, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_90.Id5", MonsterId.Nasleia, 0, 0, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_90.Id6", MonsterId.Madlens, 0, 0, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_90.Id7", MonsterId.Grob, 0, 0, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_90.Id8", MonsterId.Rootcrystal_03, 19, 25, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Nasleia' GenType 34 Spawn Points
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(931.2914, -876.6967, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(651.1022, -1458.7872, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(920.3369, -1537.196, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(786.34625, -1193.3053, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(350.02716, -904.8275, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(595.8201, -957.0133, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(166.00833, -1576.2468, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(336.7464, -1308.1063, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-42.7743, -1002.6662, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-383.68713, -866.77106, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-878.11066, -877.4, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-567.8992, -962.7763, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-844.5861, -1421.6726, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-606.3257, -1642.565, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-573.9383, -1287.0577, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-746.55084, -1503.6683, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(215.34227, -617.8423, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-5.8697224, -384.1935, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(125.08023, 247.97809, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-223.44876, 169.19977, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(90.066124, -165.74625, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-668.90314, 116.86803, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(906.8275, 59.663666, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(357.99878, 247.96326, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(242.42877, -1441.7697, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(157.90564, -992.76904, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(1419.2617, 896.9006, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(1863.7656, 1016.1979, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(1624.9363, 668.54065, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(1550.5452, 1299.8099, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(2005.7665, 1342.3658, 25));

		// 'Madlens' GenType 35 Spawn Points
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(95.648415, -492.4425, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(288.36368, 2.627449, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(809.6619, 229.86899, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(1059.6069, -40.7117, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-76.14326, 166.63303, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-1034.4209, 322.30942, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-1030.7943, 99.27818, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-1359.127, 192.81485, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(405.48767, 101.94923, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(200.73065, 744.29694, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-41.099007, 500.90866, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-24.217323, 734.064, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(61.695084, 1129.6416, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-606.83344, 623.4377, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-747.0768, 855.54346, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-901.38934, 644.22906, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-1542.4363, 728.2649, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-1265.8779, 914.5887, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-1394.2223, 675.5263, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-1506.3033, 545.05347, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-1001.3473, 794.5418, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(644.34186, 1208.5673, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-469.24716, 1300.6454, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-1072.2172, 1306.7085, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(1086.7811, 139.53163, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(232.27428, 356.74777, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-77.346664, 1302.1099, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(91.61758, 1485.0906, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-792.6318, 1709.3253, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-688.2925, 1223.6062, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(1439.2594, 753.52856, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(1632.274, 938.62195, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(1953.9749, 810.3621, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(1698.223, 1186.2157, 25));

		// 'Grob' GenType 36 Spawn Points
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-854.8348, 270.7011, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-236.19928, 275.6219, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(186.17264, 90.688805, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(566.2239, 273.98544, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(846.18726, 44.36953, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(87.60647, 759.1513, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(307.09482, 1873.0776, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(62.568558, 2058.2388, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-54.777336, 1817.0001, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(158.7823, 1964.4846, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(59.038223, 1606.9518, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-438.276, 1867.5186, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-487.1875, 2180.6611, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-640.7671, 2040.1696, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-607.33344, 1695.582, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-283.1492, 1810.5841, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-874.79004, 1767.5334, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-616.0435, 1361.939, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-1573.708, 1273.668, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-1175.9489, 1238.6226, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-902.70776, 1227.7107, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-967.31616, 934.9215, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-743.06195, 543.4885, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-1568.3376, 903.98773, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-1260.7739, 706.97473, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(793.8757, 1142.37, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(402.63052, 1224.7036, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(722.73315, 1385.6335, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(843.3976, 1523.6572, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(1080.4822, 1209.8164, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(1632.8867, 1108.1935, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(1997.814, 1162.0316, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(1784.9033, 820.2722, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(1983.6407, 648.89105, 25));

		// 'Hafter' GenType 37 Spawn Points
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-583.3338, 872.50507, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(1320.5563, -1301.0116, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(1391.815, -1484.7162, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(1489.3156, -1292.962, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(1585.2537, -898.7151, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(1141.7897, -943.8941, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(745.46576, -897.54785, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(902.461, -1327.3666, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(672.21594, -1296.1979, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(763.0864, -1536.4569, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(386.65744, -1510.96, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(133.02222, -1358.5991, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(260.1493, -1079.413, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-18.73925, -922.445, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-260.92273, -959.7614, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-718.40076, -871.22644, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-796.7637, -1240.8602, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-844.1235, -1587.9272, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-619.59045, -1411.9698, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(45.456295, -614.85034, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(167.79367, -405.97595, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-208.6389, -3.5000916, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-93.8226, 338.8679, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(0.8648224, 89.10996, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(1310.6205, -1460.2737, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(565.33405, 107.27151, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(970.27435, 291.58624, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(824.4891, -101.05798, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-1243.0415, 93.343506, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-768.02795, 209.11362, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-940.6443, 12.355745, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(62.44719, 888.9968, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(61.28244, 576.9142, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-719.6601, 712.80774, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-888.1773, 867.835, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-1307.5199, 571.9075, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-1422.1847, 850.0105, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-1383.0228, 1261.3533, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-790.6398, 1271.8871, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-742.77423, 1563.765, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-612.32745, 1874.2266, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-393.13083, 2075.2852, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-435.73004, 1669.9841, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-300.14612, 1213.8805, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(195.48788, 1291.894, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(91.0075, 1890.2484, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(298.18393, 2006.3954, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(662.74634, 1086.8766, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(863.82965, 1271.26, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(1348.7544, 1289.0308, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(1437.0554, 1074.1562, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(1780.1481, 733.9209, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(1834.5266, 1253.1051, 25));

		// 'Nasleia' GenType 38 Spawn Points
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(-626.0983, -1349.5688, 75));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(-734.19617, -916.358, 75));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(-69.22901, -967.3974, 75));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(182.60461, -1441.0947, 75));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(935.5952, -1333.9697, 75));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(465.47577, -947.40436, 75));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(70.24859, -255.30238, 75));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(122.93343, 136.16943, 75));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(917.36365, 117.14102, 75));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(-634.2615, 107.03944, 75));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(1616.2976, 931.4969, 75));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(1768.6151, 1267.6047, 75));

		// 'Madlens' GenType 39 Spawn Points
		AddSpawnPoint("d_startower_90.Id6", "d_startower_90", Rectangle(1507.0696, 976.5182, 75));
		AddSpawnPoint("d_startower_90.Id6", "d_startower_90", Rectangle(1923.7633, 1015.0859, 75));
		AddSpawnPoint("d_startower_90.Id6", "d_startower_90", Rectangle(-763.5967, 731.1439, 75));
		AddSpawnPoint("d_startower_90.Id6", "d_startower_90", Rectangle(-1437.738, 768.7678, 75));
		AddSpawnPoint("d_startower_90.Id6", "d_startower_90", Rectangle(157.58795, 1234.2938, 75));
		AddSpawnPoint("d_startower_90.Id6", "d_startower_90", Rectangle(243.30116, 234.24103, 75));
		AddSpawnPoint("d_startower_90.Id6", "d_startower_90", Rectangle(-1217.4446, 167.51651, 75));
		AddSpawnPoint("d_startower_90.Id6", "d_startower_90", Rectangle(82.618195, 627.0179, 75));

		// 'Grob' GenType 40 Spawn Points
		AddSpawnPoint("d_startower_90.Id7", "d_startower_90", Rectangle(32.0952, 1900.787, 75));
		AddSpawnPoint("d_startower_90.Id7", "d_startower_90", Rectangle(-103.94927, 1273.0712, 75));
		AddSpawnPoint("d_startower_90.Id7", "d_startower_90", Rectangle(-427.1026, 1708.9882, 75));
		AddSpawnPoint("d_startower_90.Id7", "d_startower_90", Rectangle(-770.93207, 1617.8124, 75));
		AddSpawnPoint("d_startower_90.Id7", "d_startower_90", Rectangle(-518.18494, 1944.7181, 75));
		AddSpawnPoint("d_startower_90.Id7", "d_startower_90", Rectangle(706.21625, 1148.9624, 75));
		AddSpawnPoint("d_startower_90.Id7", "d_startower_90", Rectangle(-1341.2776, 1317.3745, 75));
		AddSpawnPoint("d_startower_90.Id7", "d_startower_90", Rectangle(-832.8376, 1300.0011, 75));

		// 'Rootcrystal_03' GenType 41 Spawn Points
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(1419.9579, -1385.918, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(775.5283, -1424.4226, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(315.31882, -1465.2493, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(-711.3185, -1460.2201, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(-460.3069, -918.14355, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(-1042.5885, -921.06085, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(129.99948, -891.6485, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(1065.2472, -915.2266, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(107.11249, -180.32092, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(100.45615, 375.67096, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(748.5699, 162.12674, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(-615.0983, 182.97122, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(-1141.7615, 154.07231, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(-1410.7335, 707.3693, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(-1577.7598, 1260.5533, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(-966.89044, 1275.9562, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(-770.7743, 799.19495, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(-249.56448, 1304.4039, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(-633.546, 1737.4335, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(-308.00867, 2050.0693, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(231.58656, 1999.0776, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(403.952, 1263.017, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(903.27655, 1179.0608, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(1429.7585, 867.8592, 200));
		AddSpawnPoint("d_startower_90.Id8", "d_startower_90", Rectangle(1803.4664, 1132.3893, 200));
	}
}
