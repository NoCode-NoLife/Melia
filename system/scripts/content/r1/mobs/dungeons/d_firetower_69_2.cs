//--- Melia Script -----------------------------------------------------------
// Martuis Storage Room Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_firetower_69_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFiretower692MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_firetower_69_2.Id1", MonsterId.Glyquare_Red, 53, 70, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_2.Id2", MonsterId.Anchor_Purple, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_2.Id3", MonsterId.Prisonfighter_Green, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_2.Id4", MonsterId.Prisonfighter_Green, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_2.Id5", MonsterId.Glyquare_Red, 8, 10, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_firetower_69_2.Id6", MonsterId.Anchor_Purple, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_69_2.Id7", MonsterId.Rootcrystal_01, 12, 16, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Glyquare_Red' GenType 25 Spawn Points
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-41, 2, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-478, 394, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-433, 446, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-585, 484, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-516, 556, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-634, 562, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-587, 609, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1510, 1344, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1565, 1395, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1605, 1439, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1454, 1604, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1400, 1541, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1348, 1490, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2568, 1144, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2358, 1152, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2339, 1347, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2550, 1348, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1765, 1671, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1679, 1742, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1303, 2275, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1005, 2352, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1095, 2577, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1252, 2666, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-140, 1042, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(127, 1042, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(137, 1334, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-150, 1319, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-15, 1174, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(462, 473, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(470, 568, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(578, 455, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(584, 572, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(922, -24, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(1022, 82, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(1099, 152, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(1049, -163, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(1141, -70, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(1224, 13, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(442, -493, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(475, -444, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(454, -568, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(485, -604, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(540, -471, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(581, -506, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(595, -648, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(637, -601, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-149, -1066, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-57, -980, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(29, -888, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-18, -1202, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(65, -1125, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(134, -1053, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-324, -1060, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-72, -787, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-578, -586, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-575, -478, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-476, -581, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-470, -483, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1088, -149, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1333, -134, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1198, -25, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1045, 119, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1319, 127, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1332, -302, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1114, -297, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1239, -1083, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1195, -1124, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1057, -1268, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1032, -1304, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1022, -1062, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-965, -1123, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1307, -2203, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1218, -2184, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1048, -2325, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1456, -2436, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1220, -2493, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1105, -2216, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1148, -2384, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1290, -2414, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1351, -2574, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1166, -2594, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1373, -2290, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1772, -1513, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1716, -1459, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1473, -1819, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-1408, -1753, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2301, -1486, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2385, -1502, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2440, -1530, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2440, -1418, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2463, -1235, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2215, -1223, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2307, -1341, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2369, -1286, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2375, -1439, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2505, -1460, 20));
		AddSpawnPoint("d_firetower_69_2.Id1", "d_firetower_69_2", Rectangle(-2549, -1262, 20));

		// 'Anchor_Purple' GenType 26 Spawn Points
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-294, 13, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-20, 259, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-48, -252, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(115, -268, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(183, -116, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-92, 52, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-1280, -230, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-1356, -10, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-800, -210, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-1062, 8, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-1158, 100, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-1324, 112, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-1125, -103, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-931, -233, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-10, 1326, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(76, 1093, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(113, 894, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(205, 1242, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(140, 1395, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-103, 1266, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-177, 1170, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-172, 928, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(158, 1158, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(320, 311, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(501, 501, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(414, 624, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(665, 609, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(925, 55, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(906, -202, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1068, -40, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1169, -130, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1197, 79, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1279, 168, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1372, -6, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1107, -303, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(751, -82, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(729, -389, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(313, -746, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-147, -1141, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-179, -975, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(60, -838, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(110, -957, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(60, -705, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(237, -957, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(123, -1155, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-46, -1371, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(-316, -1184, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(137, 85, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(340, -374, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1228, 1171, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1479, 1340, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1495, 1482, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1639, 1639, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1303, 1388, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1458, 1795, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1340, 1975, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1157, 2045, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1267, 2399, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1896, 1383, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(2023, 1231, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(2156, 1135, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(2289, 1346, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(2463, 1408, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(2416, 1126, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(2365, 1271, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(2451, 1297, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1475, 2277, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1372, 2172, 40));
		AddSpawnPoint("d_firetower_69_2.Id2", "d_firetower_69_2", Rectangle(1746, 1478, 40));

		// 'Prisonfighter_Green' GenType 27 Spawn Points
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(526, -533, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-814, 215, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(545, 521, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-62, 1116, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-2518, 1091, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-2366, 1380, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-2549, 1241, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-2288, 1200, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-2327, 1078, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-2254, 951, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-2033, 1170, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1888, 1323, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1364, 1856, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1243, 2006, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1749, 1617, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1594, 1790, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1834, 1647, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1683, 1822, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1679, 1487, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1487, 1682, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1052, 2181, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1246, 2284, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1268, 2557, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1142, 2596, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1185, 2401, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1014, 2289, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-1394, 2481, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-544, -530, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-719, -358, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-399, -657, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-348, -408, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-673, 323, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-566, 494, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-363, 663, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-390, 278, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-381, 398, 40));
		AddSpawnPoint("d_firetower_69_2.Id3", "d_firetower_69_2", Rectangle(-102, 132, 40));

		// 'Prisonfighter_Green' GenType 28 Spawn Points
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1321, -2356, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1123, -2360, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1323, -2488, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1139, -2519, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-2206, -1403, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-2182, -1270, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-2545, -1378, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-2438, -1170, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-2253, -1318, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-2073, -1088, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1869, -1363, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1580, -1636, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1467, -1398, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1386, -1657, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1151, -1404, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1269, -1192, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1066, -1149, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1262, -1950, 40));
		AddSpawnPoint("d_firetower_69_2.Id4", "d_firetower_69_2", Rectangle(-1085, -2140, 40));

		// 'Glyquare_Red' GenType 29 Spawn Points
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1020, -1279, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1194, -1062, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1253, -1047, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1047, -1215, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1085, -1529, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1439, -1076, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1134, -1233, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1169, -1321, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1278, -1234, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1301, -1391, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1458, -1222, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1481, -1376, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1369, -1507, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1056, -1396, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1194, -1186, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1180, -1413, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1167, -1650, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1239, -1678, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1636, -1192, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1956, -1191, 20));
		AddSpawnPoint("d_firetower_69_2.Id5", "d_firetower_69_2", Rectangle(1791, -1149, 20));

		// 'Anchor_Purple' GenType 30 Spawn Points
		AddSpawnPoint("d_firetower_69_2.Id6", "d_firetower_69_2", Rectangle(23, -50, 9999));

		// 'Rootcrystal_01' GenType 31 Spawn Points
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(1244, -2372, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(1147, -1850, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(1362, -1106, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(2547, -1111, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(1265, -56, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(-18, -1285, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(-307, 315, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(226, -232, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(1151, 2138, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(2216, 1083, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(1423, 1380, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(-1122, 2111, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(-2124, 1093, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(-1985, -1226, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(-1165, -2052, 100));
		AddSpawnPoint("d_firetower_69_2.Id7", "d_firetower_69_2", Rectangle(-1173, -1249, 100));
	}
}
