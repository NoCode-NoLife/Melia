//--- Melia Script -----------------------------------------------------------
// Kvailas Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_thorn_21'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DThorn21MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_thorn_21", MonsterId.Matsum, Properties("MHP", 46946, "MINPATK", 1105, "MAXPATK", 1259, "MINMATK", 1105, "MAXMATK", 1259, "DEF", 197, "MDEF", 197));
		AddPropertyOverrides("d_thorn_21", MonsterId.Chafperor, Properties("MHP", 47839, "MINPATK", 1116, "MAXPATK", 1273, "MINMATK", 1116, "MAXMATK", 1273, "DEF", 198, "MDEF", 198));
		AddPropertyOverrides("d_thorn_21", MonsterId.Ammon, Properties("MHP", 48746, "MINPATK", 1128, "MAXPATK", 1288, "MINMATK", 1128, "MAXMATK", 1288, "DEF", 199, "MDEF", 199));
		AddPropertyOverrides("d_thorn_21", MonsterId.Infroholder_Mage, Properties("MHP", 49664, "MINPATK", 1140, "MAXPATK", 1302, "MINMATK", 1140, "MAXMATK", 1302, "DEF", 201, "MDEF", 201));
		AddPropertyOverrides("d_thorn_21", MonsterId.Boss_Gaigalas, Properties("MHP", 239823, "MINPATK", 2349, "MAXPATK", 2687, "MINMATK", 2349, "MAXMATK", 2687, "DEF", 412, "MDEF", 412));
		AddPropertyOverrides("d_thorn_21", MonsterId.Boss_Molich, Properties("MHP", 244296, "MINPATK", 2374, "MAXPATK", 2717, "MINMATK", 2374, "MAXMATK", 2717, "DEF", 415, "MDEF", 415));
		AddPropertyOverrides("d_thorn_21", MonsterId.Boss_Bramble, Properties("MHP", 411561, "MINPATK", 3105, "MAXPATK", 3556, "MINMATK", 3105, "MAXMATK", 3556, "DEF", 541, "MDEF", 541));

		// Monster Spawners ---------------------------------

		AddSpawner("d_thorn_21.Id1", MonsterId.Rootcrystal_01, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("d_thorn_21.Id2", MonsterId.Matsum, min: 15, max: 20);
		AddSpawner("d_thorn_21.Id3", MonsterId.Matsum, min: 15, max: 20);
		AddSpawner("d_thorn_21.Id4", MonsterId.Chafperor, min: 19, max: 25);
		AddSpawner("d_thorn_21.Id5", MonsterId.Chafperor, min: 15, max: 20);
		AddSpawner("d_thorn_21.Id6", MonsterId.Ammon, min: 12, max: 15);
		AddSpawner("d_thorn_21.Id7", MonsterId.Matsum, min: 38, max: 50);
		AddSpawner("d_thorn_21.Id8", MonsterId.Infroholder_Mage, min: 6, max: 8);
		AddSpawner("d_thorn_21.Id9", MonsterId.Infroholder_Mage, min: 6, max: 7);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 20 Spawn Points
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(72, -39, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(921, 118, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(1247, 45, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(769, 81, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(878, 599, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(895, 923, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(1409, 1102, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(1476, 1295, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(1746, 1241, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(1668, 1037, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(2281, 1436, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(2040, 1364, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(2360, 1313, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(2931, 1213, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(5141, -203, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(3295, 1118, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(3120, 1211, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(823, -562, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(888, -1175, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(1338, -1039, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(920, -208, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(1120, -1272, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(993, -1468, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(1595, -1067, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(1827, -1008, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(2422, -1160, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(2725, -1130, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(2608, -1376, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(1807, 27, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(1934, -36, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(1934, -203, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(2599, 422, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(3309, -276, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(3467, -479, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(3726, -439, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(4407, -189, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(4650, -124, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(4796, -225, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(5540, -228, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(5879, -236, 200));
		AddSpawnPoint("d_thorn_21.Id1", "d_thorn_21", Rectangle(2827, 337, 200));

		// 'Matsum' GenType 36 Spawn Points
		AddSpawnPoint("d_thorn_21.Id2", "d_thorn_21", Rectangle(1757, 27, 9999));

		// 'Matsum' GenType 107 Spawn Points
		AddSpawnPoint("d_thorn_21.Id3", "d_thorn_21", Rectangle(1380, 1073, 25));
		AddSpawnPoint("d_thorn_21.Id3", "d_thorn_21", Rectangle(1428, 1293, 25));
		AddSpawnPoint("d_thorn_21.Id3", "d_thorn_21", Rectangle(1648, 1044, 25));
		AddSpawnPoint("d_thorn_21.Id3", "d_thorn_21", Rectangle(1664, 1320, 25));
		AddSpawnPoint("d_thorn_21.Id3", "d_thorn_21", Rectangle(913, 857, 25));
		AddSpawnPoint("d_thorn_21.Id3", "d_thorn_21", Rectangle(965, 1043, 25));
		AddSpawnPoint("d_thorn_21.Id3", "d_thorn_21", Rectangle(846, 944, 25));
		AddSpawnPoint("d_thorn_21.Id3", "d_thorn_21", Rectangle(1550, 1228, 25));
		AddSpawnPoint("d_thorn_21.Id3", "d_thorn_21", Rectangle(1748, 1194, 25));
		AddSpawnPoint("d_thorn_21.Id3", "d_thorn_21", Rectangle(1902, 1404, 25));
		AddSpawnPoint("d_thorn_21.Id3", "d_thorn_21", Rectangle(1968, 1305, 25));
		AddSpawnPoint("d_thorn_21.Id3", "d_thorn_21", Rectangle(1346, 1184, 25));
		AddSpawnPoint("d_thorn_21.Id3", "d_thorn_21", Rectangle(2468, -1242, 25));
		AddSpawnPoint("d_thorn_21.Id3", "d_thorn_21", Rectangle(2526, -1376, 25));
		AddSpawnPoint("d_thorn_21.Id3", "d_thorn_21", Rectangle(2734, -1286, 25));
		AddSpawnPoint("d_thorn_21.Id3", "d_thorn_21", Rectangle(2746, -1148, 25));
		AddSpawnPoint("d_thorn_21.Id3", "d_thorn_21", Rectangle(2519, -1123, 25));
		AddSpawnPoint("d_thorn_21.Id3", "d_thorn_21", Rectangle(2599, -1212, 25));
		AddSpawnPoint("d_thorn_21.Id3", "d_thorn_21", Rectangle(2664, -1398, 25));
		AddSpawnPoint("d_thorn_21.Id3", "d_thorn_21", Rectangle(2396, -1143, 25));

		// 'Chafperor' GenType 116 Spawn Points
		AddSpawnPoint("d_thorn_21.Id4", "d_thorn_21", Rectangle(1685, 1220, 9999));

		// 'Chafperor' GenType 122 Spawn Points
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(1909, 14, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(1555, -1009, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(1147, -1086, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(1778, -1006, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(890, -1300, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(1128, -1253, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(2158, 1370, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(2251, 1470, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(1648, 1029, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(1486, 1304, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(1702, -194, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(973, -1160, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(1684, -1093, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(1721, 49, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(1623, -70, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(1923, -113, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(1692, 1144, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(1078, -1364, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(1668, -972, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(890, -1136, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(1865, -222, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(3016, 1057, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(3144, 1306, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(3214, 1027, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(2979, 1276, 30));
		AddSpawnPoint("d_thorn_21.Id5", "d_thorn_21", Rectangle(3097, 1180, 30));

		// 'Ammon' GenType 124 Spawn Points
		AddSpawnPoint("d_thorn_21.Id6", "d_thorn_21", Rectangle(794, 83, 9999));

		// 'Matsum' GenType 135 Spawn Points
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(103, 109, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(-90, -121, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(766, -27, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(953, 99, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(828, 437, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2774, -1340, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2566, -1341, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2490, -1318, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2622, -1430, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2712, -1228, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2766, -1099, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2677, -1082, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2373, -1302, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2473, -1119, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2484, -1037, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2397, -1439, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1106, -1048, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1125, -1194, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(946, -1172, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(831, -1062, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(812, -1376, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(816, -1200, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(908, -1278, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(968, -1336, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(971, -1451, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1071, -1436, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1209, -1241, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1046, -1326, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(569, 88, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(616, 264, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(860, 177, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(776, 92, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(106, -47, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(7, 31, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(-207, -196, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(-4, -120, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(301, 12, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(-25, 112, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(-242, 135, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(-183, -8, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1787, -241, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1708, -38, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1772, -103, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1898, -137, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1849, -120, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1843, -48, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1814, 2, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1796, 78, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1759, 90, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1948, 32, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1962, -32, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1961, -55, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2001, -97, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2025, -21, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2022, 39, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(3624, -491, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(3469, -527, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(3511, -347, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(3602, -245, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(3532, -214, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(3379, -295, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(3391, -382, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(4341, -214, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(4279, -313, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(4512, -186, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(4523, -103, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(4624, -262, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(4702, -113, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(4808, -134, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(4855, -241, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(4452, -299, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(4396, -267, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(3244, 1237, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(3119, 1275, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(3282, 1072, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(3019, 1159, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(3163, 1145, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(3092, 990, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(3052, 1074, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2957, 990, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2859, 1247, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2955, 1240, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(3009, 1321, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2299, 1289, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2186, 1446, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2093, 1330, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2351, 1415, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2366, 1349, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2266, 1394, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(2215, 1281, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1834, 1374, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1850, 1316, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1958, 1387, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1725, 1236, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1712, 1085, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1586, 1004, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1490, 1074, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1583, 1127, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1552, 1286, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1363, 1248, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1379, 1313, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1712, 1351, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1623, 1214, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(1028, 989, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(907, 1050, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(801, 925, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(884, 863, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(908, 764, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(974, 929, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(840, 331, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(879, 458, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(696, 93, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(718, 207, 20));
		AddSpawnPoint("d_thorn_21.Id7", "d_thorn_21", Rectangle(660, -34, 20));

		// 'Infroholder_Mage' GenType 139 Spawn Points
		AddSpawnPoint("d_thorn_21.Id8", "d_thorn_21", Rectangle(815, -1084, 30));
		AddSpawnPoint("d_thorn_21.Id8", "d_thorn_21", Rectangle(1091, -1300, 30));
		AddSpawnPoint("d_thorn_21.Id8", "d_thorn_21", Rectangle(1243, -1065, 30));
		AddSpawnPoint("d_thorn_21.Id8", "d_thorn_21", Rectangle(1637, -944, 30));
		AddSpawnPoint("d_thorn_21.Id8", "d_thorn_21", Rectangle(1815, -1084, 30));

		// 'Infroholder_Mage' GenType 140 Spawn Points
		AddSpawnPoint("d_thorn_21.Id9", "d_thorn_21", Rectangle(3414, -459, 30));
		AddSpawnPoint("d_thorn_21.Id9", "d_thorn_21", Rectangle(3673, -418, 30));
		AddSpawnPoint("d_thorn_21.Id9", "d_thorn_21", Rectangle(4456, -76, 30));
		AddSpawnPoint("d_thorn_21.Id9", "d_thorn_21", Rectangle(4546, -218, 30));
		AddSpawnPoint("d_thorn_21.Id9", "d_thorn_21", Rectangle(4788, -198, 30));
		AddSpawnPoint("d_thorn_21.Id9", "d_thorn_21", Rectangle(4673, -88, 30));
		AddSpawnPoint("d_thorn_21.Id9", "d_thorn_21", Rectangle(3541, -263, 30));
		AddSpawnPoint("d_thorn_21.Id9", "d_thorn_21", Rectangle(3381, -287, 30));
		AddSpawnPoint("d_thorn_21.Id9", "d_thorn_21", Rectangle(1601, 1254, 30));
		AddSpawnPoint("d_thorn_21.Id9", "d_thorn_21", Rectangle(1401, 1058, 30));
		AddSpawnPoint("d_thorn_21.Id9", "d_thorn_21", Rectangle(1385, 1353, 30));
	}
}
