//--- Melia Script -----------------------------------------------------------
// Dvasia Peak Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_thorn_22'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DThorn22MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_thorn_22.Id1", MonsterId.Rootcrystal_01, 8, 10, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("d_thorn_22.Id2", MonsterId.Meleech, 15, 20, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("d_thorn_22.Id3", MonsterId.RavineLerva, 12, 15, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("d_thorn_22.Id4", MonsterId.Wood_Goblin, 23, 30, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("d_thorn_22.Id5", MonsterId.Meleech, 12, 15, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("d_thorn_22.Id6", MonsterId.RavineLerva, 11, 14, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("d_thorn_22.Id7", MonsterId.TreeGool, 10, 13, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("d_thorn_22.Id8", MonsterId.Wood_Goblin, 38, 50, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("d_thorn_22.Id9", MonsterId.RavineLerva, 4, 5, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 600 Spawn Points
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(-833, -1971, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(-789, -1422, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(-928, -1380, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(-1308, -2181, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(-1585, -1877, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(-2061, -1094, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(-2053, -825, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(-2033, -1166, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(100, -1307, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(99, -1405, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(457, -1481, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(1039, -1602, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(1249, -1560, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(926, -1197, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(923, -985, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(759, -881, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(14, -586, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(765, 559, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(731, 802, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(500, 540, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(-487, 929, 50));
		AddSpawnPoint("d_thorn_22.Id1", "d_thorn_22", Rectangle(-1344, -58, 50));

		// 'Meleech' GenType 818 Spawn Points
		AddSpawnPoint("d_thorn_22.Id2", "d_thorn_22", Rectangle(1003, -1516, 9999));

		// 'RavineLerva' GenType 819 Spawn Points
		AddSpawnPoint("d_thorn_22.Id3", "d_thorn_22", Rectangle(-1576, -1901, 9999));

		// 'Wood_Goblin' GenType 821 Spawn Points
		AddSpawnPoint("d_thorn_22.Id4", "d_thorn_22", Rectangle(-45, 507, 9999));

		// 'Meleech' GenType 822 Spawn Points
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(964, -1437, 30));
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(-933, -1169, 30));
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(-1281, -1465, 30));
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(-881, -1485, 30));
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(-414, -1353, 30));
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(-1080, -1023, 30));
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(-505, -1391, 30));
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(722, -1493, 30));
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(429, -1479, 30));
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(1237, -1630, 30));
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(1041, -1788, 30));
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(1263, -1305, 30));
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(1467, -1647, 30));
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(1483, -1443, 30));
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(1128, -1547, 30));
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(887, -1621, 30));
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(457, -1349, 30));
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(-930, -1414, 30));
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(-342, -1417, 30));
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(1286, -1437, 30));
		AddSpawnPoint("d_thorn_22.Id5", "d_thorn_22", Rectangle(1375, -1595, 30));

		// 'RavineLerva' GenType 823 Spawn Points
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(729, -1297, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(627, -1142, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(902, -832, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(780, -989, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(1015, -1041, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(907, -1207, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(628, -739, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(448, -871, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(362, -905, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(1324, -804, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(393, -1451, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(1292, -1627, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(932, -1524, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(1204, -1375, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(469, -1365, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(921, -708, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(697, -1146, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(1137, -1803, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(1103, -1762, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(1222, -1458, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(1452, -1660, 25));
		AddSpawnPoint("d_thorn_22.Id6", "d_thorn_22", Rectangle(1383, -1406, 25));

		// 'TreeGool' GenType 824 Spawn Points
		AddSpawnPoint("d_thorn_22.Id7", "d_thorn_22", Rectangle(1313, -1483, 20));
		AddSpawnPoint("d_thorn_22.Id7", "d_thorn_22", Rectangle(987, -1819, 20));
		AddSpawnPoint("d_thorn_22.Id7", "d_thorn_22", Rectangle(813, -1425, 20));
		AddSpawnPoint("d_thorn_22.Id7", "d_thorn_22", Rectangle(1304, -1373, 20));
		AddSpawnPoint("d_thorn_22.Id7", "d_thorn_22", Rectangle(1372, -1697, 20));
		AddSpawnPoint("d_thorn_22.Id7", "d_thorn_22", Rectangle(1212, -1686, 20));
		AddSpawnPoint("d_thorn_22.Id7", "d_thorn_22", Rectangle(999, -1737, 20));
		AddSpawnPoint("d_thorn_22.Id7", "d_thorn_22", Rectangle(1556, -1446, 20));
		AddSpawnPoint("d_thorn_22.Id7", "d_thorn_22", Rectangle(1141, -1412, 20));
		AddSpawnPoint("d_thorn_22.Id7", "d_thorn_22", Rectangle(1095, -1642, 20));
		AddSpawnPoint("d_thorn_22.Id7", "d_thorn_22", Rectangle(1284, -1231, 20));
		AddSpawnPoint("d_thorn_22.Id7", "d_thorn_22", Rectangle(1373, -1501, 20));
		AddSpawnPoint("d_thorn_22.Id7", "d_thorn_22", Rectangle(1047, -1396, 20));
		AddSpawnPoint("d_thorn_22.Id7", "d_thorn_22", Rectangle(1547, -1625, 20));

		// 'Wood_Goblin' GenType 827 Spawn Points
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1221, -1219, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1124, -1681, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1438, -1722, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1477, -1375, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1090, -1510, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1347, -1433, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(453, -1371, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(402, -1530, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(677, -1443, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1048, -1844, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1307, -308, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1412, -71, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1283, 334, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1334, 90, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1186, 104, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1275, 442, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(638, -1294, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(907, -1176, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(926, -1084, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(817, -1123, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1353, -1538, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-742, -1762, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-785, -1604, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-824, -1308, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-946, -1092, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-862, -1193, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-701, -1351, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-766, -1544, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-816, -1821, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-613, -1376, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-863, -1377, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1113, 509, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1150, 461, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1242, 595, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1141, 332, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1201, 301, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1220, 6, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1338, 3, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1219, -90, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1310, -111, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1298, -218, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1257, -261, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1227, -330, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1357, -175, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1271, -143, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1408, -118, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-18, 582, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(2, 680, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-69, 740, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-27, 710, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(6, 639, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1284, -798, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1285, -840, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1358, -814, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1322, -847, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1018, -661, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1002, -741, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(785, -810, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(795, -721, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(864, -769, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(875, -886, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(933, -888, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(718, -743, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(649, -845, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(566, -895, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(511, -848, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(891, -992, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(983, -975, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1004, -1112, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(995, -1174, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(809, -1299, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(679, -1209, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(770, -1199, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(649, -971, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(729, -902, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(799, -898, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(582, -1010, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(572, -1078, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(589, -1242, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1441, -1479, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1479, -1570, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1238, -1522, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1180, -1607, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(969, -1575, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1048, -1605, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1154, -1313, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1356, -1250, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1385, -1340, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1581, -1530, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1300, -1718, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1219, -1740, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1171, -1507, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(962, -1672, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(858, -1475, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(942, -1743, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(1027, -1672, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(752, -1404, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(719, -1447, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(615, -1419, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(470, -1433, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(467, -1534, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(343, -1507, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(399, -1370, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(510, -1448, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-399, -1447, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-419, -1394, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-484, -1450, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-569, -1427, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-477, -1354, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-696, -1449, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-779, -1380, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-796, -1482, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-974, -1468, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-920, -1335, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1014, -1157, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1013, -975, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-965, -998, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-957, -914, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1038, -888, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1070, -940, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1041, -1074, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-968, -1239, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-993, -1362, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-912, -1258, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-743, -1640, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-721, -1688, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-759, -1801, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1220, -1478, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1246, -1426, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1323, -1494, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1374, -1490, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1360, -1440, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1527, -1840, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1520, -1903, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1543, -1960, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1501, -1959, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1546, -1764, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1498, -1795, 30));
		AddSpawnPoint("d_thorn_22.Id8", "d_thorn_22", Rectangle(-1464, -1884, 30));

		// 'RavineLerva' GenType 830 Spawn Points
		AddSpawnPoint("d_thorn_22.Id9", "d_thorn_22", Rectangle(-1186, 412, 20));
		AddSpawnPoint("d_thorn_22.Id9", "d_thorn_22", Rectangle(-1248, 100, 20));
		AddSpawnPoint("d_thorn_22.Id9", "d_thorn_22", Rectangle(-1336, -77, 20));
		AddSpawnPoint("d_thorn_22.Id9", "d_thorn_22", Rectangle(-1151, 584, 20));
		AddSpawnPoint("d_thorn_22.Id9", "d_thorn_22", Rectangle(-1284, 252, 20));
		AddSpawnPoint("d_thorn_22.Id9", "d_thorn_22", Rectangle(-1386, 80, 20));
		AddSpawnPoint("d_thorn_22.Id9", "d_thorn_22", Rectangle(-1194, 210, 20));
		AddSpawnPoint("d_thorn_22.Id9", "d_thorn_22", Rectangle(-1272, 512, 20));
	}
}
