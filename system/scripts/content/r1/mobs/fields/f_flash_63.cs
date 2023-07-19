//--- Melia Script -----------------------------------------------------------
// f_flash_63
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Downtown' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFlash63MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_flash_63", MonsterId.Lemur, Properties("MHP", 274272, "MINPATK", 4028, "MAXPATK", 4852, "MINMATK", 4028, "MAXMATK", 4852, "DEF", 16536, "MDEF", 16536));
		AddPropertyOverrides("f_flash_63", MonsterId.Goblin2_Hammer, Properties("MHP", 275164, "MINPATK", 4040, "MAXPATK", 4866, "MINMATK", 4040, "MAXMATK", 4866, "DEF", 16701, "MDEF", 16701));
		AddPropertyOverrides("f_flash_63", MonsterId.Goblin2_Wand3, Properties("MHP", 276176, "MINPATK", 4053, "MAXPATK", 4882, "MINMATK", 4053, "MAXMATK", 4882, "DEF", 16889, "MDEF", 16889));

		// Monster Spawners ---------------------------------

		AddSpawner("f_flash_63.Id1", MonsterId.Lemur, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_63.Id2", MonsterId.Lemur, 53, 70, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_63.Id3", MonsterId.Goblin2_Hammer, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_63.Id4", MonsterId.Goblin2_Wand3, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_63.Id5", MonsterId.Rootcrystal_01, 12, 15, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_flash_63.Id6", MonsterId.Lemur, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_63.Id7", MonsterId.Goblin2_Wand3, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_63.Id8", MonsterId.Lemur, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Lemur' GenType 3 Spawn Points
		AddSpawnPoint("f_flash_63.Id1", "f_flash_63", Rectangle(489.24, 876.12, 9999));

		// 'Lemur' GenType 32 Spawn Points
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-539.99994, -178.2238, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1041.7402, -171.78726, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(31.651476, -2045.3188, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-509.94705, 438.4259, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(967.0841, -402.81955, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-485.6852, -611.04083, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(831.9436, -184.6398, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-88.79724, -2246.4143, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1009.2214, -1318.7565, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(946.1214, -1475.1427, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1049.2747, -1220.6154, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(15.940231, -2127.831, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(447.64658, -1561.1483, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(467.4865, -1432.671, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-298.97842, -719.7786, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-310.89807, -485.56537, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-484.925, -71.53743, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1175.7971, -232.68997, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1098.3068, -58.581936, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(802.1333, -368.91248, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(921.7647, 15.197153, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-169.85, -2277.4282, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-261.524, -2232.783, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-6.7765427, -2279.4587, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-42.784794, -2170.8115, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-420.25775, -2034.3032, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-343.04034, -2179.204, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1095.3212, -1360.9789, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1141.2612, -1235.6841, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(679.6807, -1251.7646, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1061.7417, -1450.3413, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-457.90048, -2081.4233, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-529.32477, -2195.2175, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-468.08582, -2256.7122, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-486.48877, -2118.9604, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-418.8742, -2214.1433, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-345.8445, -2262.1785, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-251.12024, -2193.1636, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-57.31661, -2348.603, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(143.15367, -1939.2374, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(93.28936, -1917.6993, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(419.61588, -1567.2953, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(336.90912, -1515.9178, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(363.9095, -1501.5585, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(385.80286, -1428.7067, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(617.9044, -1281.5493, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(703.1756, -1321.6565, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(708.795, -1244.909, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(796.4167, -1341.6881, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(881.5433, -1444.491, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(876.4069, -1264.5867, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(977.1894, -1360.3036, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(924.17615, -461.48703, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(854.36163, -290.66476, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(884.40063, -240.04715, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(952.8011, -183.05573, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1035.5175, -255.70581, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(940.86176, -333.51788, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1061.9576, -501.54147, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1102.3701, -282.968, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1156.4808, -138.97757, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(883.1057, -24.095188, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(917.64813, -38.552876, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-276.76242, -623.58167, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-352.08926, -545.5026, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-552.7266, -268.0387, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-526.659, 11.902479, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-593.9101, 2.911593, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-554.25555, -9.872629, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-498.22876, 149.86383, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-539.2799, 483.95737, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-585.5827, 530.7111, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-608.27844, 654.7518, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-562.6081, 860.7499, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-635.595, 969.2497, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-459.27332, 1004.3348, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-538.81274, 1067.8962, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-586.65356, 1165.4993, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-532.8273, 1246.8354, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-467.54593, 1247.5275, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(234.93039, 829.50916, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-233.29123, 710.5196, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-316.65707, 547.9644, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-218.27415, 664.7714, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-245.5818, 589.49457, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(318.80685, 812.42194, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(251.80336, 963.5268, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(439.89624, 813.337, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(469.72025, 991.9438, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(513.39996, 1086.1521, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(352.9338, 912.33514, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(561.02734, 853.43604, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(540.2356, 722.32184, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(624.6002, 726.86615, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(611.968, 657.32825, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(849.5063, 608.4514, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(890.22, 656.1456, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(572.4634, 1020.4419, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(658.4297, 1653.3518, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(587.6425, 1767.2343, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(515.25, 1834.2935, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(505.10626, 1899.332, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(656.8086, 1900.3165, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(805.8623, 1839.0282, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1302.8019, 2056.8806, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1255.5035, 1928.4142, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1473.6963, 2019.4915, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1580.8811, 2125.9907, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1676.2937, 2057.2441, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1708.012, 2141.3596, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1425.0638, 2113.008, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1328.6029, 2165.1946, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1223.7179, 2174.188, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1417.0006, 1937.3643, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1566.8749, 2003.9536, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1676.0138, 1877.7742, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1729.6726, 2267.7107, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1668.7633, 2300.965, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1445.7681, 2344.0706, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1554.3046, 2371.5955, 25));

		// 'Goblin2_Hammer' GenType 37 Spawn Points
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-290.9725, -675.70514, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-522.7066, -679.00214, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-568.3377, -77.59684, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-559.6903, 1009.8451, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-460.4649, 1160.577, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(348.74884, 875.924, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(545.1934, 925.6055, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(717.4333, 1876.1013, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(1139.0392, 1966.7292, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-599.369, 831.8984, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(646.66473, 1708.2739, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(541.33044, 794.1986, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(458.72583, 1134.1769, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(549.5424, 1856.6302, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(1296.4203, 1953.7288, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(1282.3215, 1832.9719, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(154.06955, 852.04205, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-599.6765, 581.5332, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-450.22028, 1087.2145, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-534.43384, 1133.6481, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-442.22015, 939.10175, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-470.08984, 933.5866, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-406.24133, -734.4319, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-388.54245, -603.467, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-311.28146, -567.85864, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-203.57593, -640.1503, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-202.35767, -691.93384, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-480.80322, -469.39075, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-486.64813, -337.83728, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-518.75214, -170.39337, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-560.50116, -173.55063, 25));

		// 'Goblin2_Wand3' GenType 38 Spawn Points
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(-474.0449, -683.0999, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(-488.59464, -214.81674, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(-486.15167, 1081.8752, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(-260.06137, 639.86646, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(463.2385, 925.4932, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(943.6769, -271.7169, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(1314.2468, 1931.4464, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(1569.9302, 2300.8835, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(1632.1918, 2002.1476, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(600.4927, 1896.2578, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(1087.1465, -170.64732, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(146.01686, 806.4124, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(475.59875, 1216.9703, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(-200.94716, -715.1606, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(-441.72644, 929.7856, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(-511.67575, 972.55585, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(-476.82513, 1312.6304, 35));

		// 'Rootcrystal_01' GenType 41 Spawn Points
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(-212.11647, -2227.538, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(64.513214, -2017.6744, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(421.98102, -1486.8846, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(600.354, -1283.2887, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1004.7719, -1345.6537, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1081.2684, -1165.2837, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1013.4868, -423.39752, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(900.21497, -205.38203, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1079.7842, -199.49496, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(916.68536, 164.50975, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1078.2761, 413.4331, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(544.69006, 774.3174, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(534.3563, 1050.7491, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(221.06985, 758.0732, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1599.9442, 904.5653, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1465.5945, 863.6398, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1261.788, 1453.3337, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1707.7273, 2026.0718, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1628.2842, 2273.5742, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1473.0894, 2107.5037, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1242.4498, 2012.829, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(755.34155, 1757.9473, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(544.2448, 1882.8628, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(-501.9646, 896.9979, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(-374.2892, 1219.8564, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(-564.1381, 579.32324, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(-510.2717, -62.548492, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(-478.81775, -344.6227, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(-483.18997, -637.7015, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(-246.01112, -689.1773, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(248.93217, -906.6414, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(420.95386, -644.8278, 100));

		// 'Lemur' GenType 45 Spawn Points
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-236.59071, -2330.7737, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-423.67865, -2128.746, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-333.57724, -2161.1123, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-67.201485, -2255.5728, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-5.035324, -2223.7673, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(33.5836, -1973.2456, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(91.649506, -2003.7115, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(82.038345, -2091.9219, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(40.484642, -2166.2207, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-128.05804, -2250.136, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-142.11398, -2311.6238, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(158.68643, -1900.0659, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(129.0697, -1876.368, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(46.855843, -1966.816, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-272.4075, -2292.3972, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-99.7807, -2249.944, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-7.8272667, -2172.389, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(11.9711, -2046.7247, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(18.154718, -2014.923, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(52.56495, -2065.5725, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-4.4497223, -2253.8552, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-34.234924, -2296.2087, 50));

		// 'Goblin2_Wand3' GenType 46 Spawn Points
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-381.1133, -659.76, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-528.51465, -710.72406, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-431.0238, -573.7814, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-290.86105, -541.7214, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-190.76727, -704.7862, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-289.55942, -720.57324, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-525.41565, -369.40338, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-446.05142, -176.5421, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-489.8168, 88.637566, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-548.4574, 64.272194, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-553.05817, -104.18533, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-581.5414, -225.2811, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-463.20972, -318.39127, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-56.417492, -725.65063, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-477.8303, -636.3327, 50));

		// 'Lemur' GenType 47 Spawn Points
		AddSpawnPoint("f_flash_63.Id8", "f_flash_63", Rectangle(1091.5917, -1150.2172, 50));
		AddSpawnPoint("f_flash_63.Id8", "f_flash_63", Rectangle(1100.1656, -1251.6965, 50));
		AddSpawnPoint("f_flash_63.Id8", "f_flash_63", Rectangle(1100.805, -1302.7289, 50));
		AddSpawnPoint("f_flash_63.Id8", "f_flash_63", Rectangle(1026.0001, -1418.959, 50));
		AddSpawnPoint("f_flash_63.Id8", "f_flash_63", Rectangle(915.4119, -1294.6608, 50));
		AddSpawnPoint("f_flash_63.Id8", "f_flash_63", Rectangle(935.56726, -1254.774, 50));
		AddSpawnPoint("f_flash_63.Id8", "f_flash_63", Rectangle(1025.6282, -1300.6495, 50));
		AddSpawnPoint("f_flash_63.Id8", "f_flash_63", Rectangle(923.45215, -1362.7345, 50));
		AddSpawnPoint("f_flash_63.Id8", "f_flash_63", Rectangle(1044.036, -1201.6143, 50));
		AddSpawnPoint("f_flash_63.Id8", "f_flash_63", Rectangle(1103.5378, -1363.8236, 50));
	}
}
