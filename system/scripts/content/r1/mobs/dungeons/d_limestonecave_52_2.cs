//--- Melia Script -----------------------------------------------------------
// d_limestonecave_52_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Tevhrin Stalactite Cave Section 2' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DLimestonecave522MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_limestonecave_52_2", MonsterId.Tala_Combat, Properties("MHP", 476396, "MINPATK", 6627, "MAXPATK", 8047, "MINMATK", 6627, "MAXMATK", 8047, "DEF", 70760, "MDEF", 70760));
		AddPropertyOverrides("d_limestonecave_52_2", MonsterId.Flamme_Priest_Green, Properties("MHP", 478427, "MINPATK", 6653, "MAXPATK", 8079, "MINMATK", 6653, "MAXMATK", 8079, "DEF", 71575, "MDEF", 71575));
		AddPropertyOverrides("d_limestonecave_52_2", MonsterId.Warleader_Tala, Properties("MHP", 480522, "MINPATK", 6680, "MAXPATK", 8112, "MINMATK", 6680, "MAXMATK", 8112, "DEF", 72416, "MDEF", 72416));

		// Monster Spawners ---------------------------------

		AddSpawner("d_limestonecave_52_2.Id1", MonsterId.Tala_Combat, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_2.Id2", MonsterId.Flamme_Priest_Green, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_2.Id3", MonsterId.Warleader_Tala, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_2.Id4", MonsterId.Rootcrystal_04, 19, 25, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Tala_Combat' GenType 20 Spawn Points
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-1200.419, -1655.1318, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-1300.3632, -1590.205, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-1159.3414, -1574.035, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-1256.8105, -1462.9601, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-1321.8776, -1701.1389, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-937.3344, -1091.8389, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-779.6519, -1213.4822, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-670.18994, -1151.5248, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-902.08374, -962.64105, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-752.8562, -1005.8297, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-683.53955, -925.4029, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-1026.9674, -1004.5437, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-1300.4388, -514.33655, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-1524.299, -295.7937, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-1115.9999, -375.55435, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-1301.56, -208.73201, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-1411.1113, -327.5682, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-1701.151, 28.967035, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-1651.2123, 186.519, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-1627.0798, 323.593, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-2086.1895, 245.00896, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-1839.6539, 522.0805, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-1158.2932, 355.1117, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-957.3767, 95.49454, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-842.9002, 364.32828, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-1075.7867, 484.33707, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-1007.1814, 183.21448, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-868.6101, 515.8624, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-971.30927, 585.23035, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-424.60782, -8.454521, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-515.4284, 100.63692, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-446.27014, 216.56534, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-308.32306, -6.592534, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-202.67372, 145.48624, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-340.5731, 285.61066, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-431.802, 433.06543, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(45.921288, 587.87024, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(94.53386, 689.2735, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(68.44958, 779.6399, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-114.7981, 816.16516, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-178.59204, 584.22473, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-222.70134, 672.6028, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-100.24702, 748.56146, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-532.4718, 1365.5504, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-377.53387, 1229.8573, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-580.6477, 1120.1028, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-515.3998, 1458.6537, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-447.71054, 1489.5431, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-253.74219, 1329.217, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(-483.7222, 1097.1652, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(329.7434, 1319.551, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(551.97205, 1326.5918, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(565.1674, 1191.9598, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(415.1388, 1116.7787, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(435.08063, 1445.7113, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(343.0915, 1511.2859, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(144.2048, 1216.5409, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(551.73804, 1624.3644, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(142.32883, 1380.0367, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(32.186546, 1269.1361, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(659.0854, 651.385, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(794.7293, 574.2567, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(786.3224, 474.7469, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(739.708, 391.07648, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(592.70526, 586.3705, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(715.1328, 549.75653, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(709.4197, -41.82214, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(790.407, -125.70907, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(907.87683, -199.45546, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(979.8229, -147.57996, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(998.95703, -58.666092, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(945.7392, 56.750572, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(807.5548, 105.05573, 40));
		AddSpawnPoint("d_limestonecave_52_2.Id1", "d_limestonecave_52_2", Rectangle(902.4254, 116.06276, 40));

		// 'Flamme_Priest_Green' GenType 21 Spawn Points
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(-1087.272, 351.1146, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(-917.4017, 533.0663, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(-951.8249, 170.275, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(-456.14746, -14.002934, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(-385.22153, 184.84181, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(-282.7669, 59.036743, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(616.5524, 458.13754, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(706.04926, 717.1131, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(715.76807, 569.50793, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(739.8138, 413.52646, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(637.9144, 342.54987, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(861.5449, 447.75977, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(590.6511, 593.73346, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(775.7355, -207.48566, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(912.589, -74.89252, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(1043.5385, 29.560917, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(721.5718, 33.307056, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(493.62378, 1277.9246, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(402.85397, 1236.438, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(643.48224, 1354.8247, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(-110.62082, 633.38904, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(67.71462, 720.9291, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(-1077.8215, 478.09607, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id2", "d_limestonecave_52_2", Rectangle(-931.3419, 328.2818, 30));

		// 'Warleader_Tala' GenType 22 Spawn Points
		AddSpawnPoint("d_limestonecave_52_2.Id3", "d_limestonecave_52_2", Rectangle(-958.59674, 303.57617, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id3", "d_limestonecave_52_2", Rectangle(-27.240276, 640.3259, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id3", "d_limestonecave_52_2", Rectangle(-463.4771, 1280.554, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id3", "d_limestonecave_52_2", Rectangle(-352.75076, 1150.6122, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id3", "d_limestonecave_52_2", Rectangle(-292.76062, 1384.6115, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id3", "d_limestonecave_52_2", Rectangle(293.1604, 1216.3313, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id3", "d_limestonecave_52_2", Rectangle(344.75598, 1393.4777, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id3", "d_limestonecave_52_2", Rectangle(712.12, 520.5477, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id3", "d_limestonecave_52_2", Rectangle(857.48444, -117.99765, 30));
		AddSpawnPoint("d_limestonecave_52_2.Id3", "d_limestonecave_52_2", Rectangle(914.428, 83.67087, 30));

		// 'Rootcrystal_04' GenType 23 Spawn Points
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(-1267.82, -1649.89, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(-1408.87, -1387.79, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(-685.95, -1261.3, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(-700.7, -864.52, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(-1047.83, -869.07, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(-1367.87, -528.94, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(-1547.66, -186.55, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(-1856.79, 302.5, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(-1599.52, 231.99, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(-1185.49, 270.49, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(-905.42, 222.48, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(-906.79, 481.79, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(-536.78, 146.19, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(-335.03, -28.93, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(-239.92, 216.19, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(-118.34, 574.33, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(-34.2, 835.19, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(118.46, 610.77, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(200.57, 1176.09, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(75.72, 1307.59, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(315.89, 1284.87, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(485.29, 1213.44, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(570.07, 1431.49, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(734.73, 648.03, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(740.67, 309.41, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(984.63, -18.51, 15));
		AddSpawnPoint("d_limestonecave_52_2.Id4", "d_limestonecave_52_2", Rectangle(831.19, -209.22, 15));
	}
}
