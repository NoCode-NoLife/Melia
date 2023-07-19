//--- Melia Script -----------------------------------------------------------
// d_underfortress_59_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Royal Mausoleum Workers Lodge' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DUnderfortress591MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_underfortress_59_1.Id1", MonsterId.FD_Woodgoblin_Black, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_1.Id2", MonsterId.FD_Bushspider_Purple, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_1.Id3", MonsterId.FD_Pappus_Kepa_Purple, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_1.Id4", MonsterId.FD_Boss_Templeshooter, 0, 0, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_1.Id5", MonsterId.Rootcrystal_03, 14, 18, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_underfortress_59_1.Id6", MonsterId.FD_Woodgoblin_Black, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_1.Id7", MonsterId.FD_Bushspider_Purple, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_1.Id8", MonsterId.FD_Pappus_Kepa_Purple, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_1.Id9", MonsterId.FD_Colimen, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'FD_Woodgoblin_Black' GenType 10 Spawn Points
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(988.45715, 155.46301, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(733.0494, -831.91077, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-1171.8464, -836.4131, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(452.29648, 2.8836288, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(18.6602, -856.49646, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-516.7282, -1504.3954, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(857.79486, 1070.1261, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-1051.2395, -1424.2325, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-540.618, -867.3955, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-440.443, 457.20364, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-590.89825, 995.8419, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-50.505966, 1010.8086, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-868.3473, 1373.4199, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(34.398056, -1371.544, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(594.41394, -946.38104, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(1129.2264, -712.36804, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(1215.3508, -1143.649, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-958.10583, -798.74457, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-1125.947, -1584.2133, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-580.9957, -1417.0562, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-425.00058, -814.77026, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(464.4739, 282.07074, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(628.3548, -89.47989, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(457.6617, -228.89728, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(972.2357, -173.8868, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(1109.0798, 467.25757, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(601.2381, 1399.089, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(799.8439, 1595.075, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(1207.7396, 1401.4279, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(855.7569, 1264.8799, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-232.2374, 997.743, 100));

		// 'FD_Bushspider_Purple' GenType 19 Spawn Points
		AddSpawnPoint("d_underfortress_59_1.Id2", "d_underfortress_59_1", Rectangle(218.74637, 51.536316, 9999));

		// 'FD_Pappus_Kepa_Purple' GenType 20 Spawn Points
		AddSpawnPoint("d_underfortress_59_1.Id3", "d_underfortress_59_1", Rectangle(197.7244, 98.622314, 9999));

		// 'FD_Boss_Templeshooter' GenType 23 Spawn Points
		AddSpawnPoint("d_underfortress_59_1.Id4", "d_underfortress_59_1", Rectangle(-230.68436, 1610.6172, 20));

		// 'Rootcrystal_03' GenType 26 Spawn Points
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(42.198647, -115.80607, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(74.62667, 239.94653, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-388.427, 349.7917, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-390.59552, 638.41473, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(31.744097, 673.6965, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(37.7116, 985.5323, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-405.2622, 1494.1748, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-117.84662, 1318.4181, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-316.07056, 1301.2439, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-940.3251, 955.2579, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-932.0161, 1427.5651, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(531.9403, -230.25748, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(535.35535, 120.98502, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(1003.681, -237.86908, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(991.5281, 28.638855, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(993.5591, 317.04245, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(971.3762, 1068.5115, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(751.2765, 1099.6637, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(732.70526, -815.5178, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(893.9614, -801.50195, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(1067.5625, -787.818, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(171.84476, -1336.0642, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(85.12388, -834.8209, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-534.54, -923.58044, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-947.19586, -793.641, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-942.4714, -1383.2666, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-565.4311, -1519.9792, 200));

		// 'FD_Woodgoblin_Black' GenType 28 Spawn Points
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(46.415787, 94.65032, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(74.50183, -167.74211, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(94.28736, -1375.4674, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(-50.78266, -88.49093, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(14.521301, 250.04776, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(612.2625, -800.3404, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(971.41296, -776.70624, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(35.475098, -972.71606, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(60.225784, -1475.8921, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(135.7473, 13.596987, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(32.847862, -498.68735, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(11.151955, 104.16716, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(32.595474, -316.48486, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(116.11794, -809.43066, 40));

		// 'FD_Bushspider_Purple' GenType 29 Spawn Points
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(22.97284, -249.78038, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(87.71345, 259.17252, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(-796.4134, 1115.4098, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(945.50305, -78.32761, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(970.8844, 233.6755, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(763.47656, -788.3652, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(553.23456, -1325.1724, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(766.66675, -1253.9541, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(1008.9461, -1499.4347, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(1242.2534, -1282.817, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(1018.2148, 667.2776, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(1070.0797, -147.66397, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(490.59607, -49.82338, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(1000.0366, -1223.9731, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(-251.07306, 1026.7289, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(1109.3455, 322.0086, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(-916.2521, 984.3722, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(-996.3397, 1459.4296, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(-502.57138, 470.59833, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(-929.55054, 1367.6613, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(325.31857, -2.0845947, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(456.3148, -238.752, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(1103.9684, -233.02121, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(574.1931, -837.0213, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(1020.624, -733.2173, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(758.0868, -1492.6392, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(550.7748, -1537.8333, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(1189.0222, -1520.0184, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(6.375931, -905.5434, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(79.253136, -711.3221, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(-7.299749, -419.39667, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(-555.7688, 1011.9901, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(-421.78857, 629.2296, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(-383.24582, 419.1468, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(28.733044, -1344.0519, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(40.385574, 1002.1087, 40));

		// 'FD_Pappus_Kepa_Purple' GenType 30 Spawn Points
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(-693.9343, 1028.6366, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(-344.0769, 948.861, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(839.63226, 1090.4895, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(-416.85974, 457.12363, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(21.768795, -823.4897, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(-410.40146, 653.85675, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(461.65637, 328.93637, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(131.6976, 246.93549, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(-39.01123, 196.03354, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(-46.646194, 999.0032, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(1162.4988, 1412.0348, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(489.62582, 1438.0577, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(848.1047, 1565.7649, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(993.7781, 224.22903, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(459.50232, -233.12631, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(536.80096, 56.495277, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(37.78618, -42.07218, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(37.02729, -206.3571, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(1074.9866, -218.3433, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(1034.6053, 58.265842, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(1084.5345, 426.29153, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(673.3497, 973.3119, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(-935.5663, 948.3077, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(-847.8917, 1390.9943, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(-1068.0406, 1399.6729, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(-185.41904, 1054.8134, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(853.64557, 1334.1427, 40));

		// 'FD_Colimen' GenType 36 Spawn Points
		AddSpawnPoint("d_underfortress_59_1.Id9", "d_underfortress_59_1", Rectangle(547.2227, 1.289257, 9999));
	}
}
