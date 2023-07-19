//--- Melia Script -----------------------------------------------------------
// f_tableland_74
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Steel Heights' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FTableland74MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_tableland_74", MonsterId.Tiny_Mage_Brown, Properties("MHP", 399676, "MINPATK", 5640, "MAXPATK", 6834, "MINMATK", 5640, "MAXMATK", 6834, "DEF", 44650, "MDEF", 44650));
		AddPropertyOverrides("f_tableland_74", MonsterId.Spion_Mage_White, Properties("MHP", 401474, "MINPATK", 5663, "MAXPATK", 6863, "MINMATK", 5663, "MAXMATK", 6863, "DEF", 45223, "MDEF", 45223));
		AddPropertyOverrides("f_tableland_74", MonsterId.Harugal_Blue, Properties("MHP", 403387, "MINPATK", 5688, "MAXPATK", 6893, "MINMATK", 5688, "MAXMATK", 6893, "DEF", 45833, "MDEF", 45833));
		AddPropertyOverrides("f_tableland_74", MonsterId.Kepari_Purple, Properties("MHP", 405411, "MINPATK", 5714, "MAXPATK", 6925, "MINMATK", 5714, "MAXMATK", 6925, "DEF", 46479, "MDEF", 46479));

		// Monster Spawners ---------------------------------

		AddSpawner("f_tableland_74.Id1", MonsterId.Tiny_Mage_Brown, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_74.Id2", MonsterId.Spion_Mage_White, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_74.Id3", MonsterId.Harugal_Blue, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_74.Id4", MonsterId.Kepari_Purple, 42, 55, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_74.Id5", MonsterId.Rootcrystal_01, 23, 30, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Tiny_Mage_Brown' GenType 1 Spawn Points
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-963.2619, -259.129, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-744.3784, -74.42854, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-620.28955, -231.5202, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-724.4442, -312.03854, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(75.74258, 909.6198, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-40.21886, -1161.6741, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(846.6111, -189.63097, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-20.76788, -1040.1508, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(188.30559, -1235.3704, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(226.20328, -961.1783, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(143.00972, -1078.2736, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-761.8915, -1087.0302, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-621.07196, -956.90283, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-562.679, -1116.082, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-753.4147, -931.0762, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1709.884, -439.89124, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1826.217, -277.85364, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1667.7843, -162.092, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1502.2695, -503.67844, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-2048.8057, -169.46161, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1431.2283, -246.20798, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1786.6035, -1067.9208, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1728.5745, -1202.7037, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1502.8096, -1101.6786, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1624.3245, -930.28564, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(366.85147, 814.94653, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(316.42892, 1179.5673, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(594.3646, 984.24274, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(395.19052, 1058.0442, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(213.54637, 543.2257, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(88.97161, 464.04727, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(59.91889, 615.05524, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(422.77988, 1301.6621, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(1193.4462, 385.80124, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(1281.357, 469.23227, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(1458.843, 520.6604, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(1484.3094, 278.98837, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(977.1504, -154.6328, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(1086.2184, -55.344013, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(1343.8698, 216.39357, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-739.80005, -1206.3047, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-860.2742, -123.42264, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(281.47626, 997.62744, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(486.0957, 817.1105, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(1068.6091, 355.78702, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(56.258846, -1206.0247, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-76.41117, -921.1771, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(127.0872, -1277.7726, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(33.411522, -1297.4678, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(321.6413, -1153.3042, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1638.7661, -821.7833, 25));
		AddSpawnPoint("f_tableland_74.Id1", "f_tableland_74", Rectangle(-1599.0687, -744.1921, 25));

		// 'Spion_Mage_White' GenType 2 Spawn Points
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1281.1221, 615.4854, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1475.2197, 741.5287, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1183.7948, 1282.7091, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1412.0221, 1308.862, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1300.6184, 1160.492, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1272.0276, 1393.6128, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1087.8198, 1190.4786, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1017.2004, 1863.7954, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(942.6376, 2041.3442, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1172.8429, 2237.8413, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1062.8528, 1994.7838, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(535.2645, 1538.179, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(655.1276, 1743.7948, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(520.32544, 964.681, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(132.67525, 1004.4646, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1026.9474, 416.9859, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1278.5359, 239.71175, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(1251.8314, -15.510446, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(991.68414, -190.67105, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(719.3827, -211.35286, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(762.606, 1804.9264, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(179.06598, -693.79083, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(323.14984, 1381.7762, 25));
		AddSpawnPoint("f_tableland_74.Id2", "f_tableland_74", Rectangle(-7.6395917, -930.9122, 25));

		// 'Harugal_Blue' GenType 3 Spawn Points
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(1300.4998, 374.66568, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(386.56863, 930.754, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(1287.4926, 1277.141, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(1059.0946, 2067.099, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(932.12537, 2175.1084, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(-638.93976, -1023.4303, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(153.09578, -1060.6348, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(-746.9222, -185.30345, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(-1741.4504, -340.05057, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(-1742.6171, -1085.1045, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(243.417, 1001.3898, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(601.63055, 1634.2823, 25));
		AddSpawnPoint("f_tableland_74.Id3", "f_tableland_74", Rectangle(1006.1827, -130.9543, 25));

		// 'Kepari_Purple' GenType 4 Spawn Points
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-726.97656, -218.3453, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-636.1138, -13.611803, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(10.880403, 833.8939, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(310.97852, -1138.191, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-889.4938, -969.2394, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1792.958, -465.686, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(190.95412, -811.1405, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-33.67, -1094.4867, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(239.37074, -1267.7141, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(161.58365, -1013.1069, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(196.45395, 902.834, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(423.32153, 1237.0071, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(172.99223, 980.2962, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(73.68509, 692.7283, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(597.47687, 1055.1173, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1260.7645, 324.2114, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1484.7167, 459.60858, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1375.1903, 423.7402, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1341.9865, 117.96824, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1089.4384, 361.5616, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1045.2866, -124.23119, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-855.7617, -189.55173, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-703.956, -1209.4531, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-831.4038, -1092.134, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-618.19, -947.04694, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-585.6761, -1122.292, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-306.724, -1102.7852, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(109.42684, 503.6433, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(464.68005, 907.85, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1674.3765, -368.43494, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1643.6578, -265.55743, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1506.8838, -230.97711, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1480.8856, -381.41745, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1527.5458, -513.3472, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1601.5996, -1088.0381, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1590.0277, -1183.7603, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1685.8582, -1012.0959, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1843.3713, -1174.6982, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1799.5005, -972.4831, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1577.7996, -334.24048, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1559.1554, -143.8702, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1450.7913, -158.51195, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1370.3502, -369.05225, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-1306.9987, -264.76566, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-517.9648, -991.2008, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-742.8647, -1001.8807, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-476.442, -1071.1274, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-531.079, -1207.2804, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(-559.9089, -881.343, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(270.8118, -1050.6143, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(102.29068, -939.97577, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(199.84158, -1132.0042, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(62.677357, -1130.5983, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(315.17844, -968.3142, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1447.9626, 1142.4869, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1489.3048, 1241.3463, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1468.5974, 1381.9548, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1201.5865, 1188.8942, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1075.4243, 1296.0643, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(490.326, 1098.269, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(528.7447, 1199.4382, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(673.1046, 1166.5607, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(295.563, 1101.8756, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(171.5966, 1109.4937, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(929.9053, 1884.3221, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(834.4418, 2035.4506, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1056.8822, 2169.4202, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1199.2439, 2124.8933, 30));
		AddSpawnPoint("f_tableland_74.Id4", "f_tableland_74", Rectangle(1232.9209, 1899.4594, 30));

		// 'Rootcrystal_01' GenType 9 Spawn Points
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(1911.3811, 2185.8684, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(1289.5011, 2155.013, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(880.19885, 1866.8152, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(542.4667, 1409.8844, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(555.6219, 962.4775, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(114.30354, 973.70105, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(1056.7446, 1271.7236, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(1406.7448, 1273.3625, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(1489.7529, 744.2943, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(1488.9365, 371.03372, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(1165.1212, 348.9749, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(1100.941, -107.4381, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(582.30054, -225.39232, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(304.5222, -140.08731, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-32.930573, -210.74873, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(220.31096, -459.79376, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(126.048, 319.52753, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(156.22928, -873.39844, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(313.02234, -1203.5939, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-56.670723, -1146.938, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-473.66147, -1036.9246, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-765.0363, -1054.3876, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-454.0471, -138.98152, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-878.45776, -180.42026, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-1375.8573, -280.82892, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-1812.8477, -253.55777, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-1626.7186, -514.9552, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-1579.9536, -1020.191, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-1862.8494, -1181.4393, 40));
		AddSpawnPoint("f_tableland_74.Id5", "f_tableland_74", Rectangle(-2260.7708, -1285.628, 40));
	}
}
