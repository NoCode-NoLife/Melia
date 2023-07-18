//--- Melia Script -----------------------------------------------------------
// d_startower_91
//
//--- Description -----------------------------------------------------------
// Sets up the d_startower_91 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DStartower91MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_startower_91", MonsterId.Nastudeu, Properties("MHP", 646289, "MINPATK", 8812, "MAXPATK", 10732, "MINMATK", 8812, "MAXMATK", 10732, "DEF", 155530, "MDEF", 155530));
		AddPropertyOverrides("d_startower_91", MonsterId.Punter, Properties("MHP", 648344, "MINPATK", 8838, "MAXPATK", 10764, "MINMATK", 8838, "MAXMATK", 10764, "DEF", 156760, "MDEF", 156760));
		AddPropertyOverrides("d_startower_91", MonsterId.Waglog, Properties("MHP", 650426, "MINPATK", 8865, "MAXPATK", 10797, "MINMATK", 8865, "MAXMATK", 10797, "DEF", 158007, "MDEF", 158007));
		AddPropertyOverrides("d_startower_91", MonsterId.Glovegolem, Properties("MHP", 652535, "MINPATK", 8892, "MAXPATK", 10831, "MINMATK", 8892, "MAXMATK", 10831, "DEF", 159270, "MDEF", 159270));

		// Monster Spawners --------------------------------

		AddSpawner("d_startower_91.Id1", MonsterId.Nastudeu, 55, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_91.Id2", MonsterId.Punter, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_91.Id3", MonsterId.Waglog, 57, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_91.Id4", MonsterId.Glovegolem, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_91.Id5", MonsterId.Waglog, 5, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_startower_91.Id6", MonsterId.Glovegolem, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_startower_91.Id7", MonsterId.Rootcrystal_03, 33, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Nastudeu Spawn Points
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(2107.8105, -1184.709, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(1985.6421, -934.4559, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(1818.5665, -1162.195, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(1539.3047, -1286.0189, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(1286.9354, -1322.4254, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(1418.5483, -1614.0338, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(1475.2806, -1768.7816, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(1265.7856, -2211.4553, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(1252.9191, -1986.1117, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(1106.9698, -1768.9797, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(1067.835, -1999.7896, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(1187.7902, -2322.4207, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(1512.3893, -2121.933, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(1324.4318, -827.2569, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(1121.7024, -364.0421, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(1213.1403, 5.021858, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(1483.5588, -37.857037, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(1255.425, -476.64587, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(1329.9915, -33.72471, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(1590.1014, -356.69083, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(989.4233, -958.3565, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(607.2515, -1009.056, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(343.79816, -1117.8596, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(794.0076, -456.1509, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(835.2647, -118.86707, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(174.7956, -697.742, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(-40.669453, -582.43463, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(127.39052, -104.99068, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(507.73114, -295.84073, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(248.76794, -653.793, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(224.97952, -334.6161, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(47.51089, -501.70688, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(-29.537247, -226.62332, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(46.608242, -1022.5829, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(-447.14346, -994.67566, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(-377.0572, -1154.0826, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(26.155909, -1547.0715, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(166.90317, -1504.9822, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(470.1265, -1794.8754, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(6.763251, -1856.3278, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(382.16727, -2047.8844, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(235.49887, -1774.9677, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(247.47412, -1989.0713, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(47.19085, -2174.226, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(-532.34283, -972.26514, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(-1221.5605, -981.5538, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(-1576.4546, -989.42316, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(-1379.3458, -745.8165, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(-769.2727, -709.89484, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(-528.0611, -312.8418, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(-862.73206, -227.36691, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(-1113.9183, -366.2293, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(-729.01105, -477.0549, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(-1088.2001, -578.031, 25));
		AddSpawnPoint( "d_startower_91.Id1", "d_startower_91", Spot(-909.8321, -1034.982, 25));

		// Punter Spawn Points
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(1168.1426, -2264.8145, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(1058.6216, -1714.0752, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(1294.4065, -2124.7922, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(1421.7533, -1949.0399, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(1347.6711, -1097.4945, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(1266.5292, -150.74124, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(1438.6824, -497.17957, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(1618.1699, -250.52466, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(1113.532, 16.707047, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(867.6232, -975.75507, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(201.59879, -1935.0303, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(1.1056824, -2096.252, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(497.8189, -1819.0986, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(359.4242, -1437.8832, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(331.86835, -2156.5151, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(-863.4135, -735.7028, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(-757.5923, -528.4135, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(-1052.9305, -265.6996, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(-906.353, -342.3253, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(-486.1381, -436.31793, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(-1347.2684, -991.4369, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(824.3067, -702.1858, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(814.86676, -268.52997, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(287.11713, -982.3907, 25));
		AddSpawnPoint( "d_startower_91.Id2", "d_startower_91", Spot(-661.0288, -1054.6893, 25));

		// Waglog Spawn Points
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(911.12335, 1766.3903, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(1059.4729, 1690.385, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(933.9836, 1372.5479, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(696.06006, 1155.7106, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(774.08167, 920.3815, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(848.22455, 758.00604, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(1054.1747, 886.528, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(1100.2523, 1188.8651, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(1244.1995, 907.3044, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(601.13196, 915.1827, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-199.05798, 885.4436, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-90.19628, 610.4223, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(203.61212, 853.33636, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(150.4194, 1089.425, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-89.8996, 1102.0491, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-331.9007, 1162.6538, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(298.08463, 1216.8846, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(389.5481, 486.15723, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(62.89038, 322.6515, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-238.59145, 435.4144, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-562.1096, 445.29245, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-838.22253, 623.2283, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-1048.1549, 323.28564, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-1353.9463, 472.03894, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-1629.4518, 454.57333, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-793.532, 903.5706, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-879.551, 1152.5773, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-591.0969, 1385.7806, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-874.9042, 1466.2797, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-612.86084, 1636.345, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-997.51154, 1499.2384, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-1198.2759, 1630.9641, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-946.53076, 1628.4799, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-1001.5081, 1862.4657, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-821.654, 1944.4578, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-1014.1575, 1993.2692, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-573.9377, 1892.6884, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-1341.3293, 1697.8387, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-1437.8926, 1889.8441, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-1475.7963, 1620.8024, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-1767.842, 1598.4081, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-2087.0227, 1533.4121, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-1924.9479, 1709.764, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-2221.5022, 1617.6089, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-1956.2662, 1850.8262, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-2118.7832, 1979.6045, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-1813.5514, 1979.1505, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-1645.428, 2138.3726, 25));
		AddSpawnPoint( "d_startower_91.Id3", "d_startower_91", Spot(-1859.3131, 2260.365, 25));

		// Glovegolem Spawn Points
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(864.81464, 818.71405, 25));
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(722.3285, 1064.8016, 25));
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(1040.0433, 1200.221, 25));
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(925.7142, 1418.035, 25));
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(1029.3281, 1824.8734, 25));
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(-58.62558, 408.8305, 25));
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(-52.72337, 941.7648, 25));
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(-317.11414, 1057.009, 25));
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(-100.05687, 1204.1323, 25));
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(136.6337, 1043.7823, 25));
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(331.736, 982.2118, 25));
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(-846.00916, 1309.5347, 25));
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(-636.57904, 1616.3425, 25));
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(-1009.7142, 1536.4556, 25));
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(-996.4378, 1860.1067, 25));
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(-706.4304, 1854.3379, 25));
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(-1085.5713, 450.82913, 25));
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(-1922.7756, 1959.6018, 25));
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(-1654.4937, 2095.8691, 25));
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(-2041.555, 1615.8192, 25));
		AddSpawnPoint( "d_startower_91.Id4", "d_startower_91", Spot(-2123.2412, 2084.1282, 25));

		// Waglog Spawn Points
		AddSpawnPoint( "d_startower_91.Id5", "d_startower_91", Spot(-1567.4152, 817.3164, 40));
		AddSpawnPoint( "d_startower_91.Id5", "d_startower_91", Spot(-1641.0258, 988.98737, 40));
		AddSpawnPoint( "d_startower_91.Id5", "d_startower_91", Spot(-1755.7793, 1020.323, 40));
		AddSpawnPoint( "d_startower_91.Id5", "d_startower_91", Spot(-1554.4207, 1084.609, 40));
		AddSpawnPoint( "d_startower_91.Id5", "d_startower_91", Spot(-1410.0815, 1356.6547, 40));
		AddSpawnPoint( "d_startower_91.Id5", "d_startower_91", Spot(-1394.7712, 1090.4315, 40));
		AddSpawnPoint( "d_startower_91.Id5", "d_startower_91", Spot(-1390.6674, 941.1044, 40));
		AddSpawnPoint( "d_startower_91.Id5", "d_startower_91", Spot(-1213.1118, 985.7028, 40));
		AddSpawnPoint( "d_startower_91.Id5", "d_startower_91", Spot(-1186.2603, 1279.6046, 40));
		AddSpawnPoint( "d_startower_91.Id5", "d_startower_91", Spot(-1464.551, 769.9472, 40));

		// Glovegolem Spawn Points
		AddSpawnPoint( "d_startower_91.Id6", "d_startower_91", Spot(-1745.2764, 1011.5887, 40));
		AddSpawnPoint( "d_startower_91.Id6", "d_startower_91", Spot(-1645.2778, 1289.8508, 40));
		AddSpawnPoint( "d_startower_91.Id6", "d_startower_91", Spot(-1277.1454, 1120.3921, 40));

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(2475.3984, -1859.3011, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(2007.1982, -911.43915, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(1660.5524, -1379.4004, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(1399.6143, -2198.105, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(1129.7761, -1737.4377, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(1362.682, -940.6535, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(1486.6589, -424.59534, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(1193.5841, -20.15938, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(756.4627, -1027.6107, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(365.55893, -1575.8326, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(70.16239, -2068.0964, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(314.56635, -593.44543, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(51.109615, -164.25148, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(74.64343, -1007.8937, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(-593.1646, -1007.6212, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(-1229.4485, -982.496, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(-806.9142, -461.53345, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(807.46313, -280.87296, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(884.90393, 707.1742, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(934.68317, 1316.8872, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(974.2429, 1832.7374, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(240.40648, 456.27927, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(-27.951546, 844.7732, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(122.43027, 1179.897, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(-513.99994, 465.79272, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(-1239.4668, 453.8331, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(-1431.8452, 861.2927, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(-1653.9901, 1214.8223, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(-842.94977, 968.93884, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(-635.41656, 1618.5712, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(-1079.9144, 1909.473, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(-1491.0731, 1605.4066, 200));
		AddSpawnPoint( "d_startower_91.Id7", "d_startower_91", Spot(-1790.5123, 1980.1984, 200));

	}
}
