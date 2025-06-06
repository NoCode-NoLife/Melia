//--- Melia Script -----------------------------------------------------------
// Aqueduct Bridge Area Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_farm_47_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Game.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFarm472MobScript : GeneralScript
{
	protected override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_farm_47_2", MonsterId.Dandel_Orange, Properties("MHP", 178794, "MINPATK", 2800, "MAXPATK", 3343, "MINMATK", 2800, "MAXMATK", 3343, "DEF", 5400, "MDEF", 5400));
		AddPropertyOverrides("f_farm_47_2", MonsterId.Cronewt_Mage, Properties("MHP", 179869, "MINPATK", 2814, "MAXPATK", 3360, "MINMATK", 2814, "MAXMATK", 3360, "DEF", 5498, "MDEF", 5498));
		AddPropertyOverrides("f_farm_47_2", MonsterId.Kepari_Mage, Properties("MHP", 180982, "MINPATK", 2829, "MAXPATK", 3378, "MINMATK", 2829, "MAXMATK", 3378, "DEF", 5600, "MDEF", 5600));
		AddPropertyOverrides("f_farm_47_2", MonsterId.Ashrong, Properties("MHP", 182134, "MINPATK", 2843, "MAXPATK", 3396, "MINMATK", 2843, "MAXMATK", 3396, "DEF", 5705, "MDEF", 5705));

		// Monster Spawners ---------------------------------

		AddSpawner("f_farm_47_2.Id1", MonsterId.Dandel_Orange, min: 30, max: 40);
		AddSpawner("f_farm_47_2.Id2", MonsterId.Cronewt_Mage, min: 9, max: 12);
		AddSpawner("f_farm_47_2.Id3", MonsterId.Kepari_Mage, min: 14, max: 18);
		AddSpawner("f_farm_47_2.Id4", MonsterId.Dandel_Orange, min: 12, max: 15);
		AddSpawner("f_farm_47_2.Id5", MonsterId.Ashrong, min: 15, max: 20);
		AddSpawner("f_farm_47_2.Id6", MonsterId.Rootcrystal_01, min: 23, max: 30, respawn: Minutes(1));
		AddSpawner("f_farm_47_2.Id7", MonsterId.Ashrong, min: 60, max: 80);

		// Monster Spawn Points -----------------------------

		// 'Dandel_Orange' GenType 4 Spawn Points
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(-708, 1023, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(-432, 1196, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(-493, 960, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(-666, 1165, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(-615, 1724, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(-393, 1858, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(-327, 1662, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(357, 1938, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(460, 4, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(529, 287, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1463, 771, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(500, 530, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(328, -146, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(-733, 1606, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1515, 1707, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(154, 1608, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(70, 1659, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(66, 1768, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(176, 1744, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(346, 1602, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(511, 1742, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(408, 1772, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(314, 1732, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(414, 2003, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(476, 1928, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(157, 1851, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(154, 1908, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(277, 1912, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1279, 907, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1206, 1053, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1163, 1153, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1263, 1201, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1679, 1138, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1504, 964, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1609, 1039, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1491, 1086, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1479, 1261, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1557, 1256, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1502, 1330, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1626, 969, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1306, 1067, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1315, 1319, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1412, 986, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1410, 1178, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1304, 1574, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(953, 1807, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(957, 1715, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1194, 1892, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1103, 1839, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1295, 1850, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1116, 1647, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1213, 1579, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1340, 1641, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1206, 1776, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1396, 1566, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1569, 1644, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1380, 1942, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1486, 1904, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1398, 1849, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1438, 1758, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1264, 1696, 25));

		// 'Cronewt_Mage' GenType 37 Spawn Points
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(69, -1104, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(221, -552, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(97, -1565, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(136, -930, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(864, -1647, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(1123, -1727, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(910, -1324, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(1559, -1136, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(2117, -1247, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(2206, -1387, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(2240, -1119, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(2021, -1397, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(991, -1017, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(882, -1453, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(1514, -1526, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(1325, -1677, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(2004, -1158, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(8, -1957, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(142, -2060, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(227, -1795, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(35, -1740, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(756, -1082, 30));

		// 'Kepari_Mage' GenType 38 Spawn Points
		AddSpawnPoint("f_farm_47_2.Id3", "f_farm_47_2", Rectangle(302, -582, 9999));

		// 'Dandel_Orange' GenType 39 Spawn Points
		AddSpawnPoint("f_farm_47_2.Id4", "f_farm_47_2", Rectangle(134, 1026, 1500));

		// 'Ashrong' GenType 41 Spawn Points
		AddSpawnPoint("f_farm_47_2.Id5", "f_farm_47_2", Rectangle(844, -1315, 9999));

		// 'Rootcrystal_01' GenType 42 Spawn Points
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(1982, -1230, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(1734, -1396, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(1440, -1121, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(926, -1366, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(1242, -1682, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(2268, -1476, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(327, -1014, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(42, -1265, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(-477, -1130, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(-990, -1138, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(133, -1834, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(51, -516, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(460, 215, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(88, 446, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(229, -2, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(1135, 541, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(1215, 50, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(1514, 772, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(1415, 1142, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(1382, 1600, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(988, 1784, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(444, 1722, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(110, 1725, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(188, 1177, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(120, 887, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(-403, 969, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(-755, 1132, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(-613, 1665, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(-1137, 1088, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(-1528, 1019, 10));

		// 'Ashrong' GenType 56 Spawn Points
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(458, -472, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(132, -516, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2374, -1397, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2386, -1342, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2416, -1302, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2477, -1270, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2316, -1385, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2259, -1452, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2211, -1469, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2163, -1487, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2127, -1456, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2254, -1401, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2240, -1354, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2124, -1315, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2183, -1251, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2259, -1228, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2306, -1171, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2321, -1244, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2188, -1152, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2062, -1220, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1997, -1214, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2082, -1268, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2000, -1276, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1940, -1191, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1928, -1269, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1929, -1409, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1874, -1355, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1842, -1278, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1918, -1328, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1883, -1230, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1959, -1239, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1533, -1396, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1514, -1418, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1576, -1445, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1636, -1467, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1586, -1477, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1757, -1306, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1671, -1286, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1630, -1334, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1596, -1382, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1548, -1355, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1489, -1351, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1616, -1285, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1511, -1222, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1479, -1494, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1263, -1667, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1213, -1641, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1212, -1717, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1156, -1681, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1153, -1595, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1076, -1593, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1107, -1651, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1066, -1710, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1050, -1775, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1048, -1635, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(987, -1622, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1045, -1553, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(991, -1546, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(936, -1598, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(903, -1668, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(799, -1525, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(805, -1595, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(846, -1275, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(897, -1362, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(915, -1285, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(979, -1303, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(795, -1171, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(871, -1180, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(841, -1101, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(789, -1033, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(845, -994, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(902, -1116, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1050, -1096, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1131, -1137, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1164, -1071, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1102, -1077, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1140, -991, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1073, -1002, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1023, -962, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(242, -2009, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(88, -2072, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(43, -2086, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-19, -2074, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-15, -1996, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(40, -2026, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(268, -1928, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(297, -1871, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(223, -1876, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(289, -1806, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(271, -1751, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(235, -1716, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-67, -1812, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-46, -1751, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(6, -1789, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(89, -1812, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(72, -1758, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(58, -1680, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(133, -1740, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(96, -1473, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(77, -1435, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(185, -1392, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(275, -1373, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(321, -1400, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(379, -1311, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(313, -1318, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-12, -1272, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-35, -1194, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-40, -1099, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(25, -1057, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(14, -1140, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(43, -1216, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(114, -1149, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(220, -1015, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(257, -979, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(326, -1034, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(275, -1085, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(344, -1134, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(285, -1048, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(415, -1211, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(300, -1228, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(370, -1355, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-6, -438, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-10, -500, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(284, -623, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(249, -599, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(366, -617, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(440, -535, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(408, -528, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(403, -575, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(374, -474, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(435, -401, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(347, -384, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(285, -404, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(204, -430, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(439, -181, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(498, -122, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(558, -155, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(557, -67, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(610, -108, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(476, -79, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(388, -83, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(362, -87, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(560, 4, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(644, -21, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(728, 15, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(794, 138, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(780, 233, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(720, 317, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(672, 270, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(630, 174, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(697, 469, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(676, 526, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(592, 551, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(562, 403, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(613, 475, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(553, 443, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(618, 40, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(491, 328, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(216, -133, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(35, -100, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(190, 61, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(286, -43, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(94, -2, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-194, 368, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-182, 450, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-82, 482, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-36, 578, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(38, 497, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(110, 597, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(136, 491, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(288, 341, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(299, 255, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(331, 401, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(324, 520, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(444, 510, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(125, 1235, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(166, 1318, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(261, 1285, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(338, 1293, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(360, 1187, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(430, 1138, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(267, 772, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(239, 747, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(204, 919, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(190, 818, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(293, 901, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(3, 981, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(79, 925, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(173, 1011, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(83, 1045, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(379, 961, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(291, 1018, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(385, 1093, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(278, 1111, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(187, 1092, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(94, 1170, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(191, 1189, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(269, 1225, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-733, 955, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-821, 1009, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-658, 842, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-669, 786, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-761, 854, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-560, 823, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-657, 1179, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-600, 910, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-488, 901, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-337, 929, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-304, 983, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-476, 1120, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-468, 978, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-427, 1035, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-333, 1047, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-452, 1217, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-471, 1281, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-353, 1199, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-588, 1193, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-626, 1257, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-561, 988, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-735, 1192, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-763, 1130, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-536, 1072, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-644, 1018, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-635, 1100, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-752, 1059, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-424, 1609, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-786, 1612, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-749, 1687, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-687, 1604, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-615, 1544, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-561, 1582, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-635, 1687, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-662, 1773, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-759, 1795, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-701, 1873, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-553, 1926, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-546, 1821, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-476, 1856, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-522, 1714, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-420, 1733, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-510, 1631, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-314, 1672, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-305, 1766, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-256, 1832, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-354, 1912, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-196, 1680, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(47, 374, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(255, 435, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(207, 608, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(378, 270, 25));
	}
}
