//--- Melia Script -----------------------------------------------------------
// Astral Tower 20F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_startower_91'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DStartower91MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_startower_91", MonsterId.Nastudeu, Properties("MHP", 646289, "MINPATK", 8812, "MAXPATK", 10732, "MINMATK", 8812, "MAXMATK", 10732, "DEF", 155530, "MDEF", 155530));
		AddPropertyOverrides("d_startower_91", MonsterId.Punter, Properties("MHP", 648344, "MINPATK", 8838, "MAXPATK", 10764, "MINMATK", 8838, "MAXMATK", 10764, "DEF", 156760, "MDEF", 156760));
		AddPropertyOverrides("d_startower_91", MonsterId.Waglog, Properties("MHP", 650426, "MINPATK", 8865, "MAXPATK", 10797, "MINMATK", 8865, "MAXMATK", 10797, "DEF", 158007, "MDEF", 158007));
		AddPropertyOverrides("d_startower_91", MonsterId.Glovegolem, Properties("MHP", 652535, "MINPATK", 8892, "MAXPATK", 10831, "MINMATK", 8892, "MAXMATK", 10831, "DEF", 159270, "MDEF", 159270));
		AddPropertyOverrides("d_startower_91", MonsterId.Boss_Templeshooter_Q3, Properties("MHP", 3417377, "MINPATK", 22477, "MAXPATK", 27378, "MINMATK", 22477, "MAXMATK", 27378, "DEF", 404582, "MDEF", 404582));
		AddPropertyOverrides("d_startower_91", MonsterId.Boss_Trampler_Q1, Properties("MHP", 3428660, "MINPATK", 22547, "MAXPATK", 27464, "MINMATK", 22547, "MAXMATK", 27464, "DEF", 407844, "MDEF", 407844));

		// Monster Spawners ---------------------------------

		AddSpawner("d_startower_91.Id1", MonsterId.Nastudeu, 42, 55, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_91.Id2", MonsterId.Punter, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_91.Id3", MonsterId.Waglog, 43, 57, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_91.Id4", MonsterId.Glovegolem, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_91.Id5", MonsterId.Waglog, 4, 5, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_startower_91.Id6", MonsterId.Glovegolem, 2, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_startower_91.Id7", MonsterId.Rootcrystal_03, 25, 33, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Nastudeu' GenType 31 Spawn Points
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(2107, -1184, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(1985, -934, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(1818, -1162, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(1539, -1286, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(1286, -1322, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(1418, -1614, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(1475, -1768, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(1265, -2211, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(1252, -1986, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(1106, -1768, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(1067, -1999, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(1187, -2322, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(1512, -2121, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(1324, -827, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(1121, -364, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(1213, 5, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(1483, -37, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(1255, -476, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(1329, -33, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(1590, -356, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(989, -958, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(607, -1009, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(343, -1117, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(794, -456, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(835, -118, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(174, -697, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(-40, -582, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(127, -104, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(507, -295, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(248, -653, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(224, -334, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(47, -501, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(-29, -226, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(46, -1022, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(-447, -994, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(-377, -1154, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(26, -1547, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(166, -1504, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(470, -1794, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(6, -1856, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(382, -2047, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(235, -1774, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(247, -1989, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(47, -2174, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(-532, -972, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(-1221, -981, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(-1576, -989, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(-1379, -745, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(-769, -709, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(-528, -312, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(-862, -227, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(-1113, -366, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(-729, -477, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(-1088, -578, 25));
		AddSpawnPoint("d_startower_91.Id1", "d_startower_91", Rectangle(-909, -1034, 25));

		// 'Punter' GenType 32 Spawn Points
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(1168, -2264, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(1058, -1714, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(1294, -2124, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(1421, -1949, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(1347, -1097, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(1266, -150, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(1438, -497, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(1618, -250, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(1113, 16, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(867, -975, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(201, -1935, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(1, -2096, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(497, -1819, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(359, -1437, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(331, -2156, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(-863, -735, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(-757, -528, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(-1052, -265, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(-906, -342, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(-486, -436, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(-1347, -991, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(824, -702, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(814, -268, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(287, -982, 25));
		AddSpawnPoint("d_startower_91.Id2", "d_startower_91", Rectangle(-661, -1054, 25));

		// 'Waglog' GenType 33 Spawn Points
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(911, 1766, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(1059, 1690, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(933, 1372, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(696, 1155, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(774, 920, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(848, 758, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(1054, 886, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(1100, 1188, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(1244, 907, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(601, 915, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-199, 885, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-90, 610, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(203, 853, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(150, 1089, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-89, 1102, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-331, 1162, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(298, 1216, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(389, 486, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(62, 322, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-238, 435, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-562, 445, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-838, 623, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-1048, 323, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-1353, 472, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-1629, 454, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-793, 903, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-879, 1152, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-591, 1385, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-874, 1466, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-612, 1636, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-997, 1499, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-1198, 1630, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-946, 1628, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-1001, 1862, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-821, 1944, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-1014, 1993, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-573, 1892, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-1341, 1697, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-1437, 1889, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-1475, 1620, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-1767, 1598, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-2087, 1533, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-1924, 1709, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-2221, 1617, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-1956, 1850, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-2118, 1979, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-1813, 1979, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-1645, 2138, 25));
		AddSpawnPoint("d_startower_91.Id3", "d_startower_91", Rectangle(-1859, 2260, 25));

		// 'Glovegolem' GenType 34 Spawn Points
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(864, 818, 25));
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(722, 1064, 25));
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(1040, 1200, 25));
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(925, 1418, 25));
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(1029, 1824, 25));
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(-58, 408, 25));
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(-52, 941, 25));
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(-317, 1057, 25));
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(-100, 1204, 25));
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(136, 1043, 25));
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(331, 982, 25));
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(-846, 1309, 25));
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(-636, 1616, 25));
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(-1009, 1536, 25));
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(-996, 1860, 25));
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(-706, 1854, 25));
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(-1085, 450, 25));
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(-1922, 1959, 25));
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(-1654, 2095, 25));
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(-2041, 1615, 25));
		AddSpawnPoint("d_startower_91.Id4", "d_startower_91", Rectangle(-2123, 2084, 25));

		// 'Waglog' GenType 47 Spawn Points
		AddSpawnPoint("d_startower_91.Id5", "d_startower_91", Rectangle(-1567, 817, 40));
		AddSpawnPoint("d_startower_91.Id5", "d_startower_91", Rectangle(-1641, 988, 40));
		AddSpawnPoint("d_startower_91.Id5", "d_startower_91", Rectangle(-1755, 1020, 40));
		AddSpawnPoint("d_startower_91.Id5", "d_startower_91", Rectangle(-1554, 1084, 40));
		AddSpawnPoint("d_startower_91.Id5", "d_startower_91", Rectangle(-1410, 1356, 40));
		AddSpawnPoint("d_startower_91.Id5", "d_startower_91", Rectangle(-1394, 1090, 40));
		AddSpawnPoint("d_startower_91.Id5", "d_startower_91", Rectangle(-1390, 941, 40));
		AddSpawnPoint("d_startower_91.Id5", "d_startower_91", Rectangle(-1213, 985, 40));
		AddSpawnPoint("d_startower_91.Id5", "d_startower_91", Rectangle(-1186, 1279, 40));
		AddSpawnPoint("d_startower_91.Id5", "d_startower_91", Rectangle(-1464, 769, 40));

		// 'Glovegolem' GenType 48 Spawn Points
		AddSpawnPoint("d_startower_91.Id6", "d_startower_91", Rectangle(-1745, 1011, 40));
		AddSpawnPoint("d_startower_91.Id6", "d_startower_91", Rectangle(-1645, 1289, 40));
		AddSpawnPoint("d_startower_91.Id6", "d_startower_91", Rectangle(-1277, 1120, 40));

		// 'Rootcrystal_03' GenType 49 Spawn Points
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(2475, -1859, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(2007, -911, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(1660, -1379, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(1399, -2198, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(1129, -1737, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(1362, -940, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(1486, -424, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(1193, -20, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(756, -1027, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(365, -1575, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(70, -2068, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(314, -593, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(51, -164, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(74, -1007, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(-593, -1007, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(-1229, -982, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(-806, -461, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(807, -280, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(884, 707, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(934, 1316, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(974, 1832, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(240, 456, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(-27, 844, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(122, 1179, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(-513, 465, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(-1239, 453, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(-1431, 861, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(-1653, 1214, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(-842, 968, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(-635, 1618, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(-1079, 1909, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(-1491, 1605, 200));
		AddSpawnPoint("d_startower_91.Id7", "d_startower_91", Rectangle(-1790, 1980, 200));
	}
}
