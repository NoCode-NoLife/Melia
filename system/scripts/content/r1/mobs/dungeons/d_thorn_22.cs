//--- Melia Script -----------------------------------------------------------
// d_thorn_22
//
//--- Description -----------------------------------------------------------
// Sets up the d_thorn_22 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DThorn22MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("d_thorn_22.Id1", MonsterId.Rootcrystal_01, 10, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("d_thorn_22.Id2", MonsterId.Meleech, 20, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("d_thorn_22.Id3", MonsterId.RavineLerva, 15, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("d_thorn_22.Id4", MonsterId.Wood_Goblin, 30, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("d_thorn_22.Id5", MonsterId.Meleech, 15, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("d_thorn_22.Id6", MonsterId.RavineLerva, 14, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("d_thorn_22.Id7", MonsterId.TreeGool, 13, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("d_thorn_22.Id8", MonsterId.Wood_Goblin, 50, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("d_thorn_22.Id9", MonsterId.RavineLerva, 5, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(-833, -1971, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(-789, -1422, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(-928, -1380, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(-1308, -2181, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(-1585, -1877, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(-2061.652, -1094.1667, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(-2053, -825, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(-2033, -1166, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(100, -1307, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(99, -1405, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(457, -1481, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(1039, -1602, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(1249, -1560, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(926, -1197, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(923, -985, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(759, -881, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(14, -586, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(765, 559, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(731, 802, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(500, 540, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(-487, 929, 50));
		AddSpawnPoint( "d_thorn_22.Id1", "d_thorn_22", Spot(-1344, -58, 50));

		// Meleech Spawn Points
		AddSpawnPoint( "d_thorn_22.Id2", "d_thorn_22", Spot(1003.3007, -1516.4232, 9999));

		// RavineLerva Spawn Points
		AddSpawnPoint( "d_thorn_22.Id3", "d_thorn_22", Spot(-1576.0308, -1901.2728, 9999));

		// Wood_Goblin Spawn Points
		AddSpawnPoint( "d_thorn_22.Id4", "d_thorn_22", Spot(-45.348274, 507.6017, 9999));

		// Meleech Spawn Points
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(964.7238, -1437.6052, 30));
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(-933.2091, -1169.2247, 30));
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(-1281.1732, -1465.4218, 30));
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(-881.67413, -1485.427, 30));
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(-414.69516, -1353.7441, 30));
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(-1080.305, -1023.0201, 30));
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(-505.8021, -1391.1068, 30));
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(722.1162, -1493.4347, 30));
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(429.96097, -1479.3424, 30));
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(1237.077, -1630.3357, 30));
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(1041.9565, -1788.392, 30));
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(1263.5474, -1305.3502, 30));
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(1467.5635, -1647.8047, 30));
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(1483.9598, -1443.3324, 30));
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(1128.6608, -1547.8969, 30));
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(887.59784, -1621.5717, 30));
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(457.75217, -1349.0834, 30));
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(-930.13464, -1414.7479, 30));
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(-342.02158, -1417.6183, 30));
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(1286.3622, -1437.6525, 30));
		AddSpawnPoint( "d_thorn_22.Id5", "d_thorn_22", Spot(1375.7626, -1595.6368, 30));

		// RavineLerva Spawn Points
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(729.77527, -1297.9612, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(627.7053, -1142.3613, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(902.00696, -832.6153, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(780.6792, -989.89856, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(1015.9613, -1041.3535, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(907.2678, -1207.5881, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(628.44055, -739.29297, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(448.58282, -871.417, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(362.70895, -905.15826, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(1324.2106, -804.1874, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(393.23535, -1451.1382, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(1292.0266, -1627.8436, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(932.6138, -1524.786, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(1204.6472, -1375.9426, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(469.25558, -1365.8303, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(921.0843, -708.8859, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(697.86017, -1146.8108, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(1137.6525, -1803.1631, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(1103.3588, -1762.7126, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(1222.1792, -1458.5371, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(1452.7572, -1660.3816, 25));
		AddSpawnPoint( "d_thorn_22.Id6", "d_thorn_22", Spot(1383.8702, -1406.4554, 25));

		// TreeGool Spawn Points
		AddSpawnPoint( "d_thorn_22.Id7", "d_thorn_22", Spot(1313.3105, -1483.1672, 20));
		AddSpawnPoint( "d_thorn_22.Id7", "d_thorn_22", Spot(987.5332, -1819.1403, 20));
		AddSpawnPoint( "d_thorn_22.Id7", "d_thorn_22", Spot(813.10834, -1425.0874, 20));
		AddSpawnPoint( "d_thorn_22.Id7", "d_thorn_22", Spot(1304.4359, -1373.9088, 20));
		AddSpawnPoint( "d_thorn_22.Id7", "d_thorn_22", Spot(1372.2944, -1697.937, 20));
		AddSpawnPoint( "d_thorn_22.Id7", "d_thorn_22", Spot(1212.6902, -1686.0198, 20));
		AddSpawnPoint( "d_thorn_22.Id7", "d_thorn_22", Spot(999.57196, -1737.1482, 20));
		AddSpawnPoint( "d_thorn_22.Id7", "d_thorn_22", Spot(1556.5469, -1446.6805, 20));
		AddSpawnPoint( "d_thorn_22.Id7", "d_thorn_22", Spot(1141.3446, -1412.5265, 20));
		AddSpawnPoint( "d_thorn_22.Id7", "d_thorn_22", Spot(1095.8757, -1642.4467, 20));
		AddSpawnPoint( "d_thorn_22.Id7", "d_thorn_22", Spot(1284.9684, -1231.7455, 20));
		AddSpawnPoint( "d_thorn_22.Id7", "d_thorn_22", Spot(1373.898, -1501.998, 20));
		AddSpawnPoint( "d_thorn_22.Id7", "d_thorn_22", Spot(1047.0925, -1396.493, 20));
		AddSpawnPoint( "d_thorn_22.Id7", "d_thorn_22", Spot(1547.0884, -1625.4811, 20));

		// Wood_Goblin Spawn Points
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1221.352, -1219.412, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1124.6565, -1681.1447, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1438.091, -1722.4395, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1477.2473, -1375.3038, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1090.0555, -1510.0154, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1347.6022, -1433.5918, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(453.69446, -1371.7434, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(402.6492, -1530.9071, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(677.95575, -1443.331, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1048.3998, -1844.4991, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1307.0946, -308.70792, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1412.9877, -71.87098, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1283.7893, 334.34488, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1334.9423, 90.01258, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1186.8492, 104.72384, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1275.8036, 442.72836, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(638.1635, -1294.5566, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(907.6575, -1176.2772, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(926.85254, -1084.6775, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(817.18475, -1123.1376, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1353.7607, -1538.9521, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-742.4349, -1762.2412, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-785.20593, -1604.578, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-824.3267, -1308.3156, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-946.8765, -1092.691, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-862.6441, -1193.0524, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-701.76776, -1351.1022, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-766.19824, -1544.9379, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-816.546, -1821.7137, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-613.9195, -1376.0074, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-863.239, -1377.6528, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1113.8953, 509.59625, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1150.1259, 461.9217, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1242.6554, 595.08514, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1141.6562, 332.37115, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1201.8228, 301.13727, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1220.1759, 6.2948475, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1338.9222, 3.3380194, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1219.222, -90.16721, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1310.546, -111.79058, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1298.806, -218.70016, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1257.4513, -261.98254, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1227.7445, -330.7798, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1357.0106, -175.95554, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1271.9885, -143.38191, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1408.7794, -118.94395, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-18.838581, 582.7655, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(2.8344164, 680.86743, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-69.98564, 740.10297, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-27.704435, 710.5176, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(6.4522533, 639.63745, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1284.809, -798.94775, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1285.5626, -840.5678, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1358.9578, -814.2179, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1322.4199, -847.6972, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1018.686, -661.7703, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1002.6251, -741.7723, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(785.7334, -810.11255, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(795.2422, -721.7744, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(864.2506, -769.8847, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(875.1182, -886.8792, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(933.8455, -888.43726, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(718.2523, -743.90814, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(649.3897, -845.3925, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(566.4426, -895.81995, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(511.79202, -848.90216, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(891.12335, -992.86536, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(983.6648, -975.7288, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1004.3704, -1112.1136, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(995.96173, -1174.9445, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(809.8472, -1299.5797, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(679.13214, -1209.8989, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(770.9643, -1199.368, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(649.5947, -971.69855, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(729.2489, -902.03955, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(799.558, -898.8892, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(582.05646, -1010.8187, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(572.7937, -1078.1361, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(589.28564, -1242.1161, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1441.2864, -1479.0415, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1479.3053, -1570.5558, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1238.7279, -1522.3795, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1180.3396, -1607.1367, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(969.35785, -1575.7576, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1048.4216, -1605.7513, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1154.6177, -1313.9247, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1356.6157, -1250.8748, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1385.0107, -1340.2686, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1581.14, -1530.035, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1300.3186, -1718.0547, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1219.9058, -1740.8544, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1171.6622, -1507.1698, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(962.0509, -1672.8474, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(858.5479, -1475.5797, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(942.6943, -1743.5767, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(1027.4126, -1672.6392, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(752.2199, -1404.0083, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(719.4015, -1447.0868, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(615.9796, -1419.3728, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(470.7358, -1433.0631, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(467.76312, -1534.1917, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(343.0576, -1507.2667, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(399.10355, -1370.5846, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(510.01556, -1448.2196, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-399.7532, -1447.4148, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-419.50702, -1394.1146, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-484.7735, -1450.0249, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-569.51746, -1427.976, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-477.4772, -1354.3782, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-696.73975, -1449.8976, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-779.7629, -1380.074, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-796.1549, -1482.2906, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-974.1208, -1468.3251, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-920.94794, -1335.0929, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1014.567, -1157.8646, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1013.7356, -975.69385, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-965.5199, -998.9199, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-957.1271, -914.40295, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1038.8644, -888.109, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1070.2277, -940.92334, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1041.4387, -1074.3723, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-968.87946, -1239.1278, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-993.04553, -1362.6204, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-912.74207, -1258.4713, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-743.8783, -1640.4355, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-721.66437, -1688.059, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-759.47394, -1801.7089, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1220.884, -1478.6724, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1246.932, -1426.2382, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1323.8275, -1494.5266, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1374.3937, -1490.9888, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1360.4324, -1440.975, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1527.8458, -1840.1165, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1520.3368, -1903.6691, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1543.5167, -1960.2992, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1501.621, -1959.6917, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1546.9865, -1764.5371, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1498.6174, -1795.047, 30));
		AddSpawnPoint( "d_thorn_22.Id8", "d_thorn_22", Spot(-1464.2734, -1884.1105, 30));

		// RavineLerva Spawn Points
		AddSpawnPoint( "d_thorn_22.Id9", "d_thorn_22", Spot(-1186.6451, 412.94577, 20));
		AddSpawnPoint( "d_thorn_22.Id9", "d_thorn_22", Spot(-1248.3623, 100.00177, 20));
		AddSpawnPoint( "d_thorn_22.Id9", "d_thorn_22", Spot(-1336.4031, -77.79267, 20));
		AddSpawnPoint( "d_thorn_22.Id9", "d_thorn_22", Spot(-1151.1849, 584.0143, 20));
		AddSpawnPoint( "d_thorn_22.Id9", "d_thorn_22", Spot(-1284.754, 252.59323, 20));
		AddSpawnPoint( "d_thorn_22.Id9", "d_thorn_22", Spot(-1386.4122, 80.40953, 20));
		AddSpawnPoint( "d_thorn_22.Id9", "d_thorn_22", Spot(-1194.2827, 210.67561, 20));
		AddSpawnPoint( "d_thorn_22.Id9", "d_thorn_22", Spot(-1272.6829, 512.17065, 20));

	}
}
