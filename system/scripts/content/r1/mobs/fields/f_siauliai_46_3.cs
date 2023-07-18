//--- Melia Script -----------------------------------------------------------
// f_siauliai_46_3
//
//--- Description -----------------------------------------------------------
// Sets up the f_siauliai_46_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliai463MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_siauliai_46_3", MonsterId.Chupaluka, Properties("MHP", 234701, "MINPATK", 3519, "MAXPATK", 4226, "MINMATK", 3519, "MAXMATK", 4226, "DEF", 11164, "MDEF", 11164));
		AddPropertyOverrides("f_siauliai_46_3", MonsterId.Spion, Properties("MHP", 236299, "MINPATK", 3540, "MAXPATK", 4252, "MINMATK", 3540, "MAXMATK", 4252, "DEF", 11377, "MDEF", 11377));
		AddPropertyOverrides("f_siauliai_46_3", MonsterId.Siaulago, Properties("MHP", 237947, "MINPATK", 3561, "MAXPATK", 4278, "MINMATK", 3561, "MAXMATK", 4278, "DEF", 11597, "MDEF", 11597));
		AddPropertyOverrides("f_siauliai_46_3", MonsterId.Honeymeli, Properties("MHP", 239645, "MINPATK", 3583, "MAXPATK", 4305, "MINMATK", 3583, "MAXMATK", 4305, "DEF", 11824, "MDEF", 11824));

		// Monster Spawners --------------------------------

		AddSpawner("f_siauliai_46_3.Id1", MonsterId.Chupaluka, 60, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_3.Id2", MonsterId.Spion, 15, TimeSpan.FromMilliseconds(200000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_3.Id3", MonsterId.Siaulago, 20, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_3.Id4", MonsterId.Honeymeli, 4, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_3.Id5", MonsterId.Rootcrystal_01, 14, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_3.Id6", MonsterId.Spion, 20, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_3.Id7", MonsterId.Siaulago, 10, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_3.Id8", MonsterId.Honeymeli, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_3.Id9", MonsterId.Chupaluka, 18, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Chupaluka Spawn Points
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1032.0916, 1078.4543, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-1475.3431, 1025.044, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(941.07025, 968.58997, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1548.8151, 862.11755, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-436.06586, 1519.4662, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(670.4385, 1476.974, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(374.0423, 1076.0205, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-308.75604, 1640.3551, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(192.14935, 1138.5175, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(46.95866, 1007.3077, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-396.53787, 1000.8597, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(914.8243, 1626.5992, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1166.2632, 1548.1012, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1763.0787, 1690.8024, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1835.053, 1731.4135, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1848.3373, 1602.0455, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1750.2909, 1611.1498, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1626.6171, 1508.5107, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1564.5048, 1589.8634, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-970.48627, 974.87054, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-1164.0914, 1288.1377, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1654.8372, 1739.5474, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1677.1863, 1665.9094, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1568.6321, 1667.1653, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1341.9585, 1795.7349, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-1679.866, 1105.9604, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1864.8972, 1919.0977, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1888.4794, 1827.1344, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1724.1494, 1875.1863, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1660.9406, 1921.8354, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1662.1691, 1807.3925, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1515.7354, 1934.8213, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1435.8729, 1964.1614, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-373.30554, 1754.914, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-254.01045, 1696.0107, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1480.5175, 1853.6707, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1512.1655, 1753.212, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1450.16, 1644.6083, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1382.7888, 1722.1531, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-324.1784, 1444.0547, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1344.1836, 1555.5393, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-1499.8655, 891.2355, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-220.7257, 1466.4258, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1250.7068, 1651.116, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1364.601, 1643.6895, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1097.1815, 1506.0371, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1086.9193, 1629.8315, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1216.3429, 1594.4585, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(832.8574, 1644.7014, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(796.9987, 1583.4635, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(737.5519, 1501.3057, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-523.147, 1588.797, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(728.3907, 1687.7557, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-549.8598, 1691.7743, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-1591.6769, 964.65594, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(608.6784, 1389.1539, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(532.8129, 1392.6875, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(460.33682, 1390.7759, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(382.61038, 1407.0334, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(474.932, 1470.4054, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(557.5605, 1511.7385, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(538.86523, 1464.8843, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-1459.7253, 1226.5732, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(429.32297, 1535.4618, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(431.44525, 1625.3013, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(498.66483, 1674.1672, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(565.0362, 1705.1597, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(634.19257, 1725.6195, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(685.7097, 1739.7369, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(638.181, 1672.3921, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(653.6383, 1628.7957, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(547.1279, 1614.0901, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(450.5356, 1588.0706, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1666.6841, 912.8813, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-1079.9661, 894.2649, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-1270.5693, 984.40424, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1284.4197, 822.97504, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1506.4501, 946.9343, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1583.0225, 1015.7567, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1412.6313, 1032.5276, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-1220.728, 1166.6152, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1189.5325, 906.7952, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1403.8765, 848.70715, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1154.2968, 980.88153, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1144.2219, 803.4838, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(958.77155, 762.7241, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-521.4175, 964.69617, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(984.41876, 856.8987, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1033.0422, 1154.9264, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1196.9818, 1130.495, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1283.8417, 1155.2961, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1372.3702, 924.14453, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1307.5569, 988.8173, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1211.7184, 1064.0127, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-1110.1808, 1145.4342, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1085.5688, 1028.4653, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-1332.25, 1235.4276, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(999.6806, 1225.1956, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-590.568, 1090.3711, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-794.6435, 1051.4917, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-417.96036, 1131.3713, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-727.49774, 917.6827, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(932.4835, 1060.3772, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(877.7512, 1166.419, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(840.98895, 1056.8282, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-588.2391, 1258.2673, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(886.6652, 870.1241, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(1089.7856, 891.3454, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(580.3305, 1046.807, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(551.2809, 919.3412, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-1387.1431, 1106.393, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(428.76608, 859.7242, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(334.90817, 863.7437, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-1549.0936, 1121.5883, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(439.9689, 1177.5872, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(332.51385, 1186.7853, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(293.01343, 1042.5625, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(274.1914, 913.68994, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(231.34712, 1088.7096, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-288.9799, 1555.4943, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-201.76814, 1602.6829, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-158.67482, 1525.0043, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(235.37517, 814.05493, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(148.72719, 826.1604, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(81.38972, 916.55, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(117.21996, 999.92865, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(174.40402, 977.6122, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-1349.8416, 996.9467, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(94.771, 1148.9147, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(32.828186, 1097.2792, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-64.246414, 1052.7272, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(-63.823025, 992.0917, 30));
		AddSpawnPoint( "f_siauliai_46_3.Id1", "f_siauliai_46_3", Spot(36.899204, 936.7588, 30));

		// Spion Spawn Points
		AddSpawnPoint( "f_siauliai_46_3.Id2", "f_siauliai_46_3", Spot(-1123.9263, 1030.2539, 9999));

		// Siaulago Spawn Points
		AddSpawnPoint( "f_siauliai_46_3.Id3", "f_siauliai_46_3", Spot(-590.2243, -230.47626, 40));
		AddSpawnPoint( "f_siauliai_46_3.Id3", "f_siauliai_46_3", Spot(-870.1729, -301.3571, 40));
		AddSpawnPoint( "f_siauliai_46_3.Id3", "f_siauliai_46_3", Spot(-884.2322, -628.2513, 40));
		AddSpawnPoint( "f_siauliai_46_3.Id3", "f_siauliai_46_3", Spot(-1825.2335, -1412.5355, 40));
		AddSpawnPoint( "f_siauliai_46_3.Id3", "f_siauliai_46_3", Spot(-508.32495, -662.9791, 40));
		AddSpawnPoint( "f_siauliai_46_3.Id3", "f_siauliai_46_3", Spot(-435.4803, -403.00565, 40));
		AddSpawnPoint( "f_siauliai_46_3.Id3", "f_siauliai_46_3", Spot(-1656.562, -461.45587, 40));
		AddSpawnPoint( "f_siauliai_46_3.Id3", "f_siauliai_46_3", Spot(-1978.468, -1085.7632, 40));
		AddSpawnPoint( "f_siauliai_46_3.Id3", "f_siauliai_46_3", Spot(-1518.9231, -1399.2174, 40));
		AddSpawnPoint( "f_siauliai_46_3.Id3", "f_siauliai_46_3", Spot(-1766.6768, -643.5371, 40));
		AddSpawnPoint( "f_siauliai_46_3.Id3", "f_siauliai_46_3", Spot(-1718.368, -1320.6178, 40));
		AddSpawnPoint( "f_siauliai_46_3.Id3", "f_siauliai_46_3", Spot(-693.5684, -461.56735, 40));

		// Honeymeli Spawn Points
		AddSpawnPoint( "f_siauliai_46_3.Id4", "f_siauliai_46_3", Spot(-404.8013, 1632.3815, 1500));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_siauliai_46_3.Id5", "f_siauliai_46_3", Spot(-1864.2465, -1447.2103, 200));
		AddSpawnPoint( "f_siauliai_46_3.Id5", "f_siauliai_46_3", Spot(-1701.5447, -629.79016, 200));
		AddSpawnPoint( "f_siauliai_46_3.Id5", "f_siauliai_46_3", Spot(-840.5555, -612.2375, 200));
		AddSpawnPoint( "f_siauliai_46_3.Id5", "f_siauliai_46_3", Spot(-524.0944, -192.47665, 200));
		AddSpawnPoint( "f_siauliai_46_3.Id5", "f_siauliai_46_3", Spot(-1224.4937, 1062.3534, 200));
		AddSpawnPoint( "f_siauliai_46_3.Id5", "f_siauliai_46_3", Spot(-388.7921, 1559.0311, 200));
		AddSpawnPoint( "f_siauliai_46_3.Id5", "f_siauliai_46_3", Spot(-576.18164, 996.75464, 200));
		AddSpawnPoint( "f_siauliai_46_3.Id5", "f_siauliai_46_3", Spot(451.72418, 1010.1168, 200));
		AddSpawnPoint( "f_siauliai_46_3.Id5", "f_siauliai_46_3", Spot(675.9396, 1601.0403, 200));
		AddSpawnPoint( "f_siauliai_46_3.Id5", "f_siauliai_46_3", Spot(1479.883, 1763.4319, 200));
		AddSpawnPoint( "f_siauliai_46_3.Id5", "f_siauliai_46_3", Spot(1002.0593, 953.0031, 200));
		AddSpawnPoint( "f_siauliai_46_3.Id5", "f_siauliai_46_3", Spot(2287.3005, -207.69098, 200));
		AddSpawnPoint( "f_siauliai_46_3.Id5", "f_siauliai_46_3", Spot(3345.662, 1020.3773, 200));
		AddSpawnPoint( "f_siauliai_46_3.Id5", "f_siauliai_46_3", Spot(358.17004, -911.3858, 200));

		// Spion Spawn Points
		AddSpawnPoint( "f_siauliai_46_3.Id6", "f_siauliai_46_3", Spot(182.23999, -882.6352, 20));
		AddSpawnPoint( "f_siauliai_46_3.Id6", "f_siauliai_46_3", Spot(391.5454, -897.25586, 20));
		AddSpawnPoint( "f_siauliai_46_3.Id6", "f_siauliai_46_3", Spot(433.07312, -772.89734, 20));
		AddSpawnPoint( "f_siauliai_46_3.Id6", "f_siauliai_46_3", Spot(425.763, -614.1015, 20));
		AddSpawnPoint( "f_siauliai_46_3.Id6", "f_siauliai_46_3", Spot(330.46954, -978.13617, 20));
		AddSpawnPoint( "f_siauliai_46_3.Id6", "f_siauliai_46_3", Spot(520.0876, -882.89417, 20));

		// Siaulago Spawn Points
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(83.14174, -506.85355, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(125.61546, -612.4501, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-77.11155, -501.08453, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(109.43639, -886.91254, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(419.3664, -812.36414, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(259.1131, -978.1184, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(493.60394, -732.3126, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(528.427, -665.91064, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(413.24966, -566.5282, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(525.8457, -869.9407, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(428.06277, -929.17737, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(623.93616, -845.62476, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(575.26306, -760.7425, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(704.0212, -734.4747, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(761.7746, -706.8901, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(833.39557, -562.8818, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(700.6863, -474.4155, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(927.53174, -633.6955, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(822.36676, -657.41064, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(747.1927, -554.15546, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(695.69586, -629.35486, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(606.45105, -506.1513, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(597.07367, -603.8286, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(506.46573, -576.1647, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(539.64026, -506.8322, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(392.39346, -684.0835, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(330.27866, -926.3722, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(192.27536, -897.411, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(145.78278, -983.30615, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(287.83072, -807.56647, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(155.98953, -791.058, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(45.07346, -593.5631, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-11.024845, -547.1791, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(30.964598, -442.8598, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-62.39459, -426.19815, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-48.852554, -327.06448, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-164.88324, -449.1566, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-113.56437, -556.6781, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-129.57574, -326.16357, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-181.7139, -289.10922, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-185.22021, -374.2626, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-407.84625, -346.23163, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-402.59747, -255.21199, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-566.4401, -108.14135, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-560.5763, -227.35522, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-496.1743, 1156.9305, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-490.3541, -455.3976, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-359.7579, -454.72498, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-431.60516, -693.0472, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-375.95813, -790.1282, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-461.20718, -809.7284, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-308.2926, -658.2276, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-362.59454, -557.6909, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-473.81894, -584.37134, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-578.12836, -804.2014, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-578.19934, -687.12335, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-594.56, -448.2463, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-573.3769, -568.70233, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-736.84863, -753.8784, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-819.86664, -642.2989, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-816.0162, -521.78784, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-690.66656, -637.0898, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-915.2464, -338.28946, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-789.28687, -311.82193, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-758.6331, -223.535, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-683.4264, -131.56201, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-615.4052, -46.708366, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-660.3542, 99.33732, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-658.8695, 1163.6558, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-443.35654, -57.265297, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-393.9702, -145.61154, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-693.6248, 1033.1604, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-813.89325, -420.2226, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-704.34186, -384.97552, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-696.04645, -504.29974, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-903.2759, -480.6417, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-970.35474, -593.60657, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-950.2664, -685.70886, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-861.9438, -782.0843, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-662.8793, -879.0597, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-776.45685, -857.9756, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1478.5433, -334.7543, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1629.4675, -329.15036, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1536.3019, -468.54785, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1641.1488, -559.3047, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1546.0338, -728.95056, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1623.3585, -700.313, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1744.5159, -724.9119, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1773.914, -473.73154, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1726.8175, -389.76392, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1641.6932, -454.00232, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1707.1324, -627.6559, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1565.9518, -634.52747, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1785.4708, -571.2351, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1671.8859, -790.6203, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1886.8595, -536.8786, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1947.7433, -611.5492, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1971.2986, -728.73944, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1873.858, -777.06085, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1771.2627, -820.2057, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1828.2717, -650.61035, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1860.4781, -1127.1403, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1939.6465, -1163.2057, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1897.6716, -1261.6506, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1801.7969, -1168.6974, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1810.1383, -1275.3174, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1876.0094, -1389.9092, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1785.3035, -1398.3624, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1927.5048, -1482.6615, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1828.4329, -1503.5151, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1719.5938, -1593.5593, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1693.682, -1386.5878, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1616.1091, -1370.5122, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1548.6787, -1318.3712, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1465.0824, -1346.4979, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1356.4529, -1331.4576, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1381.5304, -1409.9058, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1570.0635, -1452.2418, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1659.0938, -1509.6829, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1489.3092, -1421.3469, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1642.7811, -1268.3104, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1749.9264, -1500.346, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1842.3225, -1585.6393, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-1972.5653, -1581.7737, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-2068.7546, -1456.1516, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id7", "f_siauliai_46_3", Spot(-2045.0074, -1345.6537, 25));

		// Honeymeli Spawn Points
		AddSpawnPoint( "f_siauliai_46_3.Id8", "f_siauliai_46_3", Spot(-608.9388, -747.4728, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id8", "f_siauliai_46_3", Spot(-783.8598, -765.5087, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id8", "f_siauliai_46_3", Spot(-847.48114, -334.60788, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id8", "f_siauliai_46_3", Spot(-443.25418, -281.00366, 25));

		// Chupaluka Spawn Points
		AddSpawnPoint( "f_siauliai_46_3.Id9", "f_siauliai_46_3", Spot(1788.3915, 1518.3242, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id9", "f_siauliai_46_3", Spot(1790.0297, 1810.5223, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id9", "f_siauliai_46_3", Spot(1609.7479, 1839.268, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id9", "f_siauliai_46_3", Spot(1397.3425, 1860.9535, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id9", "f_siauliai_46_3", Spot(1417.731, 1534.4716, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id9", "f_siauliai_46_3", Spot(1700.7242, 1497.5721, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id9", "f_siauliai_46_3", Spot(1537.104, 1486.023, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id9", "f_siauliai_46_3", Spot(1628.6798, 1627.8517, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id9", "f_siauliai_46_3", Spot(1591.8575, 1913.4758, 25));
		AddSpawnPoint( "f_siauliai_46_3.Id9", "f_siauliai_46_3", Spot(-133.20438, 1645.5996, 25));

	}
}
