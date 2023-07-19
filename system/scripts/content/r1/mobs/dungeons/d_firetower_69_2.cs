//--- Melia Script -----------------------------------------------------------
// d_firetower_69_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Martuis Storage Room' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFiretower692MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_firetower_69_2.Id1", MonsterId.Glyquare_Red, 53, 70, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_2.Id2", MonsterId.Anchor_Purple, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_2.Id3", MonsterId.Prisonfighter_Green, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_2.Id4", MonsterId.Prisonfighter_Green, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_2.Id5", MonsterId.Glyquare_Red, 8, 10, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_firetower_69_2.Id6", MonsterId.Anchor_Purple, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_2.Id7", MonsterId.Rootcrystal_01, 12, 16, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Glyquare_Red' GenType 25 Spawn Points
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-41.42, 2.39, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-478.36517, 394.16837, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-433.84, 446.18, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-585.98553, 484.1437, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-516.4374, 556.1338, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-634.17126, 562.6374, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-587.1494, 609.6568, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1510.3657, 1344.643, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1565.9327, 1395.7623, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1605.5132, 1439.1951, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1454.7177, 1604.3013, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1400.5168, 1541.497, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1348.4738, 1490.9913, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2568.1213, 1144.9312, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2358.1558, 1152.8469, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2339.9233, 1347.2281, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2550.0269, 1348.8162, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1765.552, 1671.7916, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1679.127, 1742.2352, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1303.8584, 2275.23, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1005.5992, 2352.4355, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1095.3907, 2577.0217, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1252.0344, 2666.484, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-140.71179, 1042.6854, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(127.95167, 1042.7084, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(137.50891, 1334.4722, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-150.94344, 1319.9899, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-15.797073, 1174.3665, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(462.85864, 473.61703, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(470.74158, 568.1527, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(578.14935, 455.24768, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(584.2715, 572.6028, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(922.4681, -24.481787, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(1022.4274, 82.48696, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(1099.9153, 152.98346, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(1049.7574, -163.9002, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(1141.9307, -70.35376, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(1224.4155, 13.504526, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(442.96362, -493.3639, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(475.04575, -444.9021, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(454.60452, -568.5055, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(485.58682, -604.53284, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(540.1072, -471.7621, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(581.6186, -506.16647, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(595.0267, -648.7922, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(637.2517, -601.67957, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-149.20871, -1066.5226, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-57.364723, -980.609, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(29.037415, -888.2367, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-18.64167, -1202.0992, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(65.089775, -1125.1707, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(134.24284, -1053.7339, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-324.98798, -1060.1462, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-72.53081, -787.5539, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-578.7561, -586.0894, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-575.9326, -478.92407, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-476.42807, -581.9675, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-470.8263, -483.69168, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1088.7214, -149.1335, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1333.4246, -134.40263, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1198.6909, -25.18503, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1045.0968, 119.02139, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1319.5625, 127.49013, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1332.7004, -302.23083, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1114.0615, -297.6399, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1239.5518, -1083.164, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1195.9341, -1124.1384, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1057.7522, -1268.7325, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1032.034, -1304.663, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1022.6273, -1062.2628, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-965.9961, -1123.3234, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1307.4346, -2203.2937, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1218.6198, -2184.7832, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1048.4005, -2325.317, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1456.5061, -2436.1968, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1220.059, -2493.4106, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1105.1475, -2216.3604, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1148.7532, -2384.3354, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1290.3832, -2414.064, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1351.599, -2574.9414, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1166.5958, -2594.652, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1373.5447, -2290.2073, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1772.3647, -1513.4678, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1716.6965, -1459.0144, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1473.3943, -1819.7004, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1408.5703, -1753.6746, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2301.4634, -1486.063, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2385.2188, -1502.6779, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2440.706, -1530.9349, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2440.0144, -1418.3228, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2463.8738, -1235.1196, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2215.1025, -1223.5538, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2307.5, -1341.7859, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2369.7039, -1286.7667, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2375.7673, -1439.5468, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2505.713, -1460.535, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2549.204, -1262.3412, 20));

		// 'Anchor_Purple' GenType 26 Spawn Points
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-294.7109, 13.258698, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-20.654472, 259.03693, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-48.148575, -252.72704, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(115.73242, -268.76773, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(183.65585, -116.8906, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-92.50328, 52.45716, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-1280.8552, -230.92685, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-1356.45, -10.606792, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-800.7636, -210.61592, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-1062.7568, 8.414218, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-1158.6965, 100.0468, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-1324.8768, 112.03342, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-1125.1165, -103.94704, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-931.99274, -233.32175, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-10.725826, 1326.1981, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(76.827385, 1093.0537, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(113.76717, 894.8084, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(205.40564, 1242.4744, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(140.57451, 1395.0063, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-103.08839, 1266.5923, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-177.98615, 1170.8579, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-172.54553, 928.3995, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(158.59996, 1158.1653, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(320.3531, 311.72824, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(501.39484, 501.21478, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(414.35358, 624.9398, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(665.3673, 609.11346, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(925.5889, 55.949257, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(906.84326, -202.35132, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1068.7869, -40.42498, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1169.6642, -130.66483, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1197.8223, 79.05923, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1279.791, 168.96059, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1372.2634, -6.040407, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1107.7361, -303.63458, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(751.6814, -82.056435, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(729.54474, -389.04324, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(313.5609, -746.97046, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-147.38455, -1141.3418, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-179.98657, -975.9831, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(60.193893, -838.7552, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(110.93369, -957.3785, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(60.257378, -705.2992, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(237.50684, -957.8454, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(123.85467, -1155.1597, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-46.15849, -1371.7513, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-316.56708, -1184.4331, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(137.94525, 85.046104, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(340.7496, -374.99194, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1228.769, 1171.4745, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1479.667, 1340.1748, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1495.0106, 1482.9896, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1639.33, 1639.74, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1303.5713, 1388.0715, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1458.3788, 1795.3805, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1340.3866, 1975.0923, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1157.21, 2045.77, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1267.2776, 2399.7, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1896.69, 1383.79, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(2023.22, 1231.07, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(2156.77, 1135.06, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(2289.45, 1346.03, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(2463.15, 1408.99, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(2416.2, 1126.95, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(2365.06, 1271.03, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(2451.51, 1297.9, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1475.3284, 2277.2913, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1372.7101, 2172.6187, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1746.439, 1478.1101, 40));

		// 'Prisonfighter_Green' GenType 27 Spawn Points
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(526.6099, -533.81604, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-814.8914, 215.64151, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(545.0816, 521.6457, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-62.262527, 1116.1318, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-2518.52, 1091.47, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-2366.58, 1380.43, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-2549.72, 1241.94, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-2288.13, 1200.21, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-2327.2, 1078.75, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-2254.74, 951.91, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-2033.29, 1170.35, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1888.86, 1323.86, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1364.63, 1856.46, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1243.9, 2006.94, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1749.66, 1617.34, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1594.8, 1790.24, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1834.22, 1647.28, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1683.59, 1822.67, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1679, 1487.52, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1487.2, 1682.33, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1052, 2181.57, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1246.08, 2284.94, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1268.23, 2557.48, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1142.18, 2596.61, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1185.24, 2401.11, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1014.71, 2289.42, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1394.02, 2481.84, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-544.37, -530.52, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-719.24, -358.25, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-399.08, -657.4, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-348.0629, -408.13068, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-673.6518, 323.46732, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-566.5193, 494.9686, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-363.465, 663.6763, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-390.77036, 278.66873, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-381.84314, 398.0027, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-102.89494, 132.6418, 40));

		// 'Prisonfighter_Green' GenType 28 Spawn Points
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1321.88, -2356.48, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1123.57, -2360.94, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1323.16, -2488.04, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1139.53, -2519.7, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-2206.04, -1403.3, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-2182.57, -1270.93, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-2545.46, -1378.66, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-2438.43, -1170.22, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-2253.57, -1318.09, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-2073.9, -1088.27, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1869.55, -1363.44, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1580.85, -1636.02, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1467.59, -1398.9, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1386.34, -1657.27, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1151.03, -1404.9, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1269.74, -1192.92, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1066.29, -1149.39, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1262.56, -1950.68, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1085.83, -2140.78, 40));

		// 'Glyquare_Red' GenType 29 Spawn Points
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1020.56, -1279.87, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1194.42, -1062.36, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1253.13, -1047.51, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1047.69, -1215.63, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1085.99, -1529.77, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1439.42, -1076.37, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1134.9071, -1233.7518, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1169.8014, -1321.259, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1278.6438, -1234.4159, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1301.91, -1391.64, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1458.9, -1222.47, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1481.19, -1376.73, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1369.88, -1507.4, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1056.4286, -1396.8997, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1194.4036, -1186.4287, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1180.8038, -1413.6033, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1167.9064, -1650.0587, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1239.1427, -1678.668, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1636.4553, -1192.8798, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1956.0732, -1191.9525, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1791.8934, -1149.1793, 20));

		// 'Anchor_Purple' GenType 30 Spawn Points
		AddSpawnPoint("d_firetower_69_2.Id6", "d_firetower_69_2", Rectangle(23.812996, -50.96791, 9999));

		// 'Rootcrystal_01' GenType 31 Spawn Points
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(1244, -2372.88, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(1147.17, -1850.48, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(1362.7596, -1106.7101, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(2547.33, -1111.58, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(1265.15, -56.79, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(-18.46, -1285.13, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(-307.92, 315.68, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(226.47, -232.39, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(1151.43, 2138.23, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(2216.53, 1083.52, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(1423.11, 1380.11, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(-1122.66, 2111.87, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(-2124.05, 1093.1, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(-1985.52, -1226.76, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(-1165.64, -2052.66, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(-1173.28, -1249.75, 100));
	}
}
