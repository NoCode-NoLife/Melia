//--- Melia Script -----------------------------------------------------------
// f_tableland_74
//
//--- Description -----------------------------------------------------------
// Sets up the f_tableland_74 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FTableland74MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_tableland_74", MonsterId.Tiny_Mage_Brown, Properties("MHP", 399676, "MINPATK", 5640, "MAXPATK", 6834, "MINMATK", 5640, "MAXMATK", 6834, "DEF", 44650, "MDEF", 44650));
		AddPropertyOverrides("f_tableland_74", MonsterId.Spion_Mage_White, Properties("MHP", 401474, "MINPATK", 5663, "MAXPATK", 6863, "MINMATK", 5663, "MAXMATK", 6863, "DEF", 45223, "MDEF", 45223));
		AddPropertyOverrides("f_tableland_74", MonsterId.Harugal_Blue, Properties("MHP", 403387, "MINPATK", 5688, "MAXPATK", 6893, "MINMATK", 5688, "MAXMATK", 6893, "DEF", 45833, "MDEF", 45833));
		AddPropertyOverrides("f_tableland_74", MonsterId.Kepari_Purple, Properties("MHP", 405411, "MINPATK", 5714, "MAXPATK", 6925, "MINMATK", 5714, "MAXMATK", 6925, "DEF", 46479, "MDEF", 46479));

		// Monster Spawners --------------------------------

		AddSpawner("f_tableland_74.Id1", MonsterId.Tiny_Mage_Brown, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_74.Id2", MonsterId.Spion_Mage_White, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_74.Id3", MonsterId.Harugal_Blue, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_74.Id4", MonsterId.Kepari_Purple, 55, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_74.Id5", MonsterId.Rootcrystal_01, 30, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Tiny_Mage_Brown Spawn Points
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-963.2619, -259.129, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-744.3784, -74.42854, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-620.28955, -231.5202, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-724.4442, -312.03854, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(75.74258, 909.6198, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-40.21886, -1161.6741, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(846.6111, -189.63097, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-20.76788, -1040.1508, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(188.30559, -1235.3704, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(226.20328, -961.1783, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(143.00972, -1078.2736, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-761.8915, -1087.0302, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-621.07196, -956.90283, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-562.679, -1116.082, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-753.4147, -931.0762, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-1709.884, -439.89124, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-1826.217, -277.85364, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-1667.7843, -162.092, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-1502.2695, -503.67844, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-2048.8057, -169.46161, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-1431.2283, -246.20798, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-1786.6035, -1067.9208, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-1728.5745, -1202.7037, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-1502.8096, -1101.6786, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-1624.3245, -930.28564, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(366.85147, 814.94653, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(316.42892, 1179.5673, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(594.3646, 984.24274, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(395.19052, 1058.0442, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(213.54637, 543.2257, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(88.97161, 464.04727, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(59.91889, 615.05524, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(422.77988, 1301.6621, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(1193.4462, 385.80124, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(1281.357, 469.23227, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(1458.843, 520.6604, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(1484.3094, 278.98837, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(977.1504, -154.6328, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(1086.2184, -55.344013, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(1343.8698, 216.39357, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-739.80005, -1206.3047, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-860.2742, -123.42264, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(281.47626, 997.62744, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(486.0957, 817.1105, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(1068.6091, 355.78702, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(56.258846, -1206.0247, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-76.41117, -921.1771, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(127.0872, -1277.7726, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(33.411522, -1297.4678, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(321.6413, -1153.3042, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-1638.7661, -821.7833, 25));
		AddSpawnPoint( "f_tableland_74.Id1", "f_tableland_74", Spot(-1599.0687, -744.1921, 25));

		// Spion_Mage_White Spawn Points
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(1281.1221, 615.4854, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(1475.2197, 741.5287, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(1183.7948, 1282.7091, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(1412.0221, 1308.862, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(1300.6184, 1160.492, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(1272.0276, 1393.6128, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(1087.8198, 1190.4786, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(1017.2004, 1863.7954, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(942.6376, 2041.3442, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(1172.8429, 2237.8413, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(1062.8528, 1994.7838, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(535.2645, 1538.179, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(655.1276, 1743.7948, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(520.32544, 964.681, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(132.67525, 1004.4646, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(1026.9474, 416.9859, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(1278.5359, 239.71175, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(1251.8314, -15.510446, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(991.68414, -190.67105, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(719.3827, -211.35286, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(762.606, 1804.9264, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(179.06598, -693.79083, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(323.14984, 1381.7762, 25));
		AddSpawnPoint( "f_tableland_74.Id2", "f_tableland_74", Spot(-7.6395917, -930.9122, 25));

		// Harugal_Blue Spawn Points
		AddSpawnPoint( "f_tableland_74.Id3", "f_tableland_74", Spot(1300.4998, 374.66568, 25));
		AddSpawnPoint( "f_tableland_74.Id3", "f_tableland_74", Spot(386.56863, 930.754, 25));
		AddSpawnPoint( "f_tableland_74.Id3", "f_tableland_74", Spot(1287.4926, 1277.141, 25));
		AddSpawnPoint( "f_tableland_74.Id3", "f_tableland_74", Spot(1059.0946, 2067.099, 25));
		AddSpawnPoint( "f_tableland_74.Id3", "f_tableland_74", Spot(932.12537, 2175.1084, 25));
		AddSpawnPoint( "f_tableland_74.Id3", "f_tableland_74", Spot(-638.93976, -1023.4303, 25));
		AddSpawnPoint( "f_tableland_74.Id3", "f_tableland_74", Spot(153.09578, -1060.6348, 25));
		AddSpawnPoint( "f_tableland_74.Id3", "f_tableland_74", Spot(-746.9222, -185.30345, 25));
		AddSpawnPoint( "f_tableland_74.Id3", "f_tableland_74", Spot(-1741.4504, -340.05057, 25));
		AddSpawnPoint( "f_tableland_74.Id3", "f_tableland_74", Spot(-1742.6171, -1085.1045, 25));
		AddSpawnPoint( "f_tableland_74.Id3", "f_tableland_74", Spot(243.417, 1001.3898, 25));
		AddSpawnPoint( "f_tableland_74.Id3", "f_tableland_74", Spot(601.63055, 1634.2823, 25));
		AddSpawnPoint( "f_tableland_74.Id3", "f_tableland_74", Spot(1006.1827, -130.9543, 25));

		// Kepari_Purple Spawn Points
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-726.97656, -218.3453, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-636.1138, -13.611803, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(10.880403, 833.8939, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(310.97852, -1138.191, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-889.4938, -969.2394, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-1792.958, -465.686, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(190.95412, -811.1405, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-33.67, -1094.4867, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(239.37074, -1267.7141, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(161.58365, -1013.1069, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(196.45395, 902.834, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(423.32153, 1237.0071, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(172.99223, 980.2962, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(73.68509, 692.7283, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(597.47687, 1055.1173, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(1260.7645, 324.2114, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(1484.7167, 459.60858, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(1375.1903, 423.7402, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(1341.9865, 117.96824, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(1089.4384, 361.5616, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(1045.2866, -124.23119, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-855.7617, -189.55173, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-703.956, -1209.4531, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-831.4038, -1092.134, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-618.19, -947.04694, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-585.6761, -1122.292, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-306.724, -1102.7852, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(109.42684, 503.6433, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(464.68005, 907.85, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-1674.3765, -368.43494, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-1643.6578, -265.55743, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-1506.8838, -230.97711, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-1480.8856, -381.41745, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-1527.5458, -513.3472, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-1601.5996, -1088.0381, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-1590.0277, -1183.7603, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-1685.8582, -1012.0959, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-1843.3713, -1174.6982, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-1799.5005, -972.4831, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-1577.7996, -334.24048, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-1559.1554, -143.8702, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-1450.7913, -158.51195, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-1370.3502, -369.05225, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-1306.9987, -264.76566, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-517.9648, -991.2008, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-742.8647, -1001.8807, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-476.442, -1071.1274, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-531.079, -1207.2804, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(-559.9089, -881.343, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(270.8118, -1050.6143, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(102.29068, -939.97577, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(199.84158, -1132.0042, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(62.677357, -1130.5983, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(315.17844, -968.3142, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(1447.9626, 1142.4869, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(1489.3048, 1241.3463, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(1468.5974, 1381.9548, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(1201.5865, 1188.8942, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(1075.4243, 1296.0643, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(490.326, 1098.269, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(528.7447, 1199.4382, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(673.1046, 1166.5607, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(295.563, 1101.8756, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(171.5966, 1109.4937, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(929.9053, 1884.3221, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(834.4418, 2035.4506, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(1056.8822, 2169.4202, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(1199.2439, 2124.8933, 30));
		AddSpawnPoint( "f_tableland_74.Id4", "f_tableland_74", Spot(1232.9209, 1899.4594, 30));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(1911.3811, 2185.8684, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(1289.5011, 2155.013, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(880.19885, 1866.8152, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(542.4667, 1409.8844, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(555.6219, 962.4775, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(114.30354, 973.70105, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(1056.7446, 1271.7236, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(1406.7448, 1273.3625, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(1489.7529, 744.2943, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(1488.9365, 371.03372, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(1165.1212, 348.9749, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(1100.941, -107.4381, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(582.30054, -225.39232, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(304.5222, -140.08731, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(-32.930573, -210.74873, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(220.31096, -459.79376, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(126.048, 319.52753, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(156.22928, -873.39844, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(313.02234, -1203.5939, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(-56.670723, -1146.938, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(-473.66147, -1036.9246, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(-765.0363, -1054.3876, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(-454.0471, -138.98152, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(-878.45776, -180.42026, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(-1375.8573, -280.82892, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(-1812.8477, -253.55777, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(-1626.7186, -514.9552, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(-1579.9536, -1020.191, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(-1862.8494, -1181.4393, 40));
		AddSpawnPoint( "f_tableland_74.Id5", "f_tableland_74", Spot(-2260.7708, -1285.628, 40));

	}
}
