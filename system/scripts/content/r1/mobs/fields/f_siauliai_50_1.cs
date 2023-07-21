//--- Melia Script -----------------------------------------------------------
// Gytis Settlement Area Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_siauliai_50_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliai501MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_siauliai_50_1", MonsterId.Chupaluka_Pink, Properties("MHP", 169654, "MINPATK", 2683, "MAXPATK", 3199, "MINMATK", 2683, "MAXMATK", 3199, "DEF", 4567, "MDEF", 4567));
		AddPropertyOverrides("f_siauliai_50_1", MonsterId.Sakmoli_Orange, Properties("MHP", 169849, "MINPATK", 2686, "MAXPATK", 3202, "MINMATK", 2686, "MAXMATK", 3202, "DEF", 4585, "MDEF", 4585));
		AddPropertyOverrides("f_siauliai_50_1", MonsterId.Ridimed_Purple, Properties("MHP", 170206, "MINPATK", 2690, "MAXPATK", 3208, "MINMATK", 2690, "MAXMATK", 3208, "DEF", 4617, "MDEF", 4617));
		AddPropertyOverrides("f_siauliai_50_1", MonsterId.Repusbunny_Bow, Properties("MHP", 170667, "MINPATK", 2696, "MAXPATK", 3215, "MINMATK", 2696, "MAXMATK", 3215, "DEF", 4659, "MDEF", 4659));

		// Monster Spawners ---------------------------------

		AddSpawner("f_siauliai_50_1.Id1", MonsterId.Chupaluka_Pink, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_siauliai_50_1.Id2", MonsterId.Sakmoli_Orange, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_50_1.Id3", MonsterId.Chupaluka_Pink, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_50_1.Id4", MonsterId.Ridimed_Purple, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_50_1.Id5", MonsterId.Sakmoli_Orange, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_50_1.Id6", MonsterId.Ridimed_Purple, 49, 65, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_50_1.Id7", MonsterId.RootCrystal_A, 11, 14, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_50_1.Id8", MonsterId.Repusbunny_Bow, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_50_1.Id9", MonsterId.Ridimed_Purple, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_50_1.Id10", MonsterId.Sakmoli_Orange, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Chupaluka_Pink' GenType 13 Spawn Points
		AddSpawnPoint("f_siauliai_50_1.Id1", "f_siauliai_50_1", Rectangle(-889, -1503, 30));
		AddSpawnPoint("f_siauliai_50_1.Id1", "f_siauliai_50_1", Rectangle(-54, -1000, 30));
		AddSpawnPoint("f_siauliai_50_1.Id1", "f_siauliai_50_1", Rectangle(-559, -1461, 30));
		AddSpawnPoint("f_siauliai_50_1.Id1", "f_siauliai_50_1", Rectangle(-210, -1456, 30));
		AddSpawnPoint("f_siauliai_50_1.Id1", "f_siauliai_50_1", Rectangle(62, -1861, 30));
		AddSpawnPoint("f_siauliai_50_1.Id1", "f_siauliai_50_1", Rectangle(532, -1493, 30));
		AddSpawnPoint("f_siauliai_50_1.Id1", "f_siauliai_50_1", Rectangle(417, -1621, 30));
		AddSpawnPoint("f_siauliai_50_1.Id1", "f_siauliai_50_1", Rectangle(196, -1282, 30));
		AddSpawnPoint("f_siauliai_50_1.Id1", "f_siauliai_50_1", Rectangle(-5, -1295, 30));
		AddSpawnPoint("f_siauliai_50_1.Id1", "f_siauliai_50_1", Rectangle(379, -1219, 30));
		AddSpawnPoint("f_siauliai_50_1.Id1", "f_siauliai_50_1", Rectangle(61, -1475, 30));
		AddSpawnPoint("f_siauliai_50_1.Id1", "f_siauliai_50_1", Rectangle(-234, -1658, 30));

		// 'Sakmoli_Orange' GenType 14 Spawn Points
		AddSpawnPoint("f_siauliai_50_1.Id2", "f_siauliai_50_1", Rectangle(53, 468, 3000));

		// 'Chupaluka_Pink' GenType 42 Spawn Points
		AddSpawnPoint("f_siauliai_50_1.Id3", "f_siauliai_50_1", Rectangle(1421, -365, 30));
		AddSpawnPoint("f_siauliai_50_1.Id3", "f_siauliai_50_1", Rectangle(1398, -609, 30));
		AddSpawnPoint("f_siauliai_50_1.Id3", "f_siauliai_50_1", Rectangle(1302, -494, 30));
		AddSpawnPoint("f_siauliai_50_1.Id3", "f_siauliai_50_1", Rectangle(1242, -318, 30));
		AddSpawnPoint("f_siauliai_50_1.Id3", "f_siauliai_50_1", Rectangle(1329, -157, 30));
		AddSpawnPoint("f_siauliai_50_1.Id3", "f_siauliai_50_1", Rectangle(1595, -545, 30));
		AddSpawnPoint("f_siauliai_50_1.Id3", "f_siauliai_50_1", Rectangle(1604, -382, 30));
		AddSpawnPoint("f_siauliai_50_1.Id3", "f_siauliai_50_1", Rectangle(1723, -452, 30));
		AddSpawnPoint("f_siauliai_50_1.Id3", "f_siauliai_50_1", Rectangle(1780, -341, 30));

		// 'Ridimed_Purple' GenType 66 Spawn Points
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(1887, 448, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(1624, 519, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(1799, 557, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(1921, 703, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(2026, 566, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(1432, 631, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(1398, 411, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(1423, 529, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(2096, 680, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(1914, 556, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(2166, 438, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(2240, 472, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(2202, 533, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(2130, 515, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(2112, 595, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(1529, 441, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(1529, 534, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(1532, 651, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(1634, 604, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(1324, 480, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(1527, -469, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(1492, -552, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(1355, -281, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(1173, -218, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(1635, -471, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(77, -1703, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(-23, -1463, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(131, -1321, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(131, -1206, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(-203, -1352, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(-797, -1444, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(-885, -1400, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(-963, -1432, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(-978, -1518, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(-829, -1569, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(112, 252, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(-36, 466, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(-146, 607, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(122, 649, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(146, 798, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(336, 670, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(399, 389, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(201, 633, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(-10, 642, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(-50, 723, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(-104, 1316, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(-281, 1300, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(-284, 1385, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(-201, 1409, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(-311, 1473, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(-125, 1463, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(-84, 1395, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(-38, 1462, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(-76, 1541, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(11, 1301, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(103, 1349, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(123, 1429, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(199, 1448, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(380, 1469, 30));
		AddSpawnPoint("f_siauliai_50_1.Id4", "f_siauliai_50_1", Rectangle(246, 1535, 30));

		// 'Sakmoli_Orange' GenType 74 Spawn Points
		AddSpawnPoint("f_siauliai_50_1.Id5", "f_siauliai_50_1", Rectangle(143, -1456, 230));
		AddSpawnPoint("f_siauliai_50_1.Id5", "f_siauliai_50_1", Rectangle(-82, 530, 230));

		// 'Ridimed_Purple' GenType 75 Spawn Points
		AddSpawnPoint("f_siauliai_50_1.Id6", "f_siauliai_50_1", Rectangle(68, -1402, 30));
		AddSpawnPoint("f_siauliai_50_1.Id6", "f_siauliai_50_1", Rectangle(-47, 354, 30));
		AddSpawnPoint("f_siauliai_50_1.Id6", "f_siauliai_50_1", Rectangle(161, -1674, 30));
		AddSpawnPoint("f_siauliai_50_1.Id6", "f_siauliai_50_1", Rectangle(483, -1322, 30));
		AddSpawnPoint("f_siauliai_50_1.Id6", "f_siauliai_50_1", Rectangle(160, -1109, 30));
		AddSpawnPoint("f_siauliai_50_1.Id6", "f_siauliai_50_1", Rectangle(-172, -1247, 30));
		AddSpawnPoint("f_siauliai_50_1.Id6", "f_siauliai_50_1", Rectangle(-267, -1488, 30));
		AddSpawnPoint("f_siauliai_50_1.Id6", "f_siauliai_50_1", Rectangle(287, -1336, 30));
		AddSpawnPoint("f_siauliai_50_1.Id6", "f_siauliai_50_1", Rectangle(-467, 560, 30));
		AddSpawnPoint("f_siauliai_50_1.Id6", "f_siauliai_50_1", Rectangle(-220, 551, 30));
		AddSpawnPoint("f_siauliai_50_1.Id6", "f_siauliai_50_1", Rectangle(240, 357, 30));
		AddSpawnPoint("f_siauliai_50_1.Id6", "f_siauliai_50_1", Rectangle(-30, 833, 30));
		AddSpawnPoint("f_siauliai_50_1.Id6", "f_siauliai_50_1", Rectangle(-324, 268, 30));
		AddSpawnPoint("f_siauliai_50_1.Id6", "f_siauliai_50_1", Rectangle(132, 561, 30));
		AddSpawnPoint("f_siauliai_50_1.Id6", "f_siauliai_50_1", Rectangle(-5, -1757, 30));

		// 'RootCrystal_A' GenType 83 Spawn Points
		AddSpawnPoint("f_siauliai_50_1.Id7", "f_siauliai_50_1", Rectangle(1700, 541, 20));
		AddSpawnPoint("f_siauliai_50_1.Id7", "f_siauliai_50_1", Rectangle(1378, -398, 20));
		AddSpawnPoint("f_siauliai_50_1.Id7", "f_siauliai_50_1", Rectangle(1783, -391, 20));
		AddSpawnPoint("f_siauliai_50_1.Id7", "f_siauliai_50_1", Rectangle(375, 503, 20));
		AddSpawnPoint("f_siauliai_50_1.Id7", "f_siauliai_50_1", Rectangle(-189, 528, 20));
		AddSpawnPoint("f_siauliai_50_1.Id7", "f_siauliai_50_1", Rectangle(-184, 858, 20));
		AddSpawnPoint("f_siauliai_50_1.Id7", "f_siauliai_50_1", Rectangle(-520, 380, 20));
		AddSpawnPoint("f_siauliai_50_1.Id7", "f_siauliai_50_1", Rectangle(-31, 116, 20));
		AddSpawnPoint("f_siauliai_50_1.Id7", "f_siauliai_50_1", Rectangle(-118, -752, 20));
		AddSpawnPoint("f_siauliai_50_1.Id7", "f_siauliai_50_1", Rectangle(119, -1182, 20));
		AddSpawnPoint("f_siauliai_50_1.Id7", "f_siauliai_50_1", Rectangle(91, -1754, 20));
		AddSpawnPoint("f_siauliai_50_1.Id7", "f_siauliai_50_1", Rectangle(768, -1474, 20));
		AddSpawnPoint("f_siauliai_50_1.Id7", "f_siauliai_50_1", Rectangle(-450, -1454, 20));
		AddSpawnPoint("f_siauliai_50_1.Id7", "f_siauliai_50_1", Rectangle(-937, -1541, 20));

		// 'Repusbunny_Bow' GenType 87 Spawn Points
		AddSpawnPoint("f_siauliai_50_1.Id8", "f_siauliai_50_1", Rectangle(1262, -185, 30));
		AddSpawnPoint("f_siauliai_50_1.Id8", "f_siauliai_50_1", Rectangle(1416, -472, 30));
		AddSpawnPoint("f_siauliai_50_1.Id8", "f_siauliai_50_1", Rectangle(1730, -390, 30));
		AddSpawnPoint("f_siauliai_50_1.Id8", "f_siauliai_50_1", Rectangle(1253, -397, 30));
		AddSpawnPoint("f_siauliai_50_1.Id8", "f_siauliai_50_1", Rectangle(1557, -369, 30));
		AddSpawnPoint("f_siauliai_50_1.Id8", "f_siauliai_50_1", Rectangle(-363, 1374, 30));
		AddSpawnPoint("f_siauliai_50_1.Id8", "f_siauliai_50_1", Rectangle(-208, 1501, 30));
		AddSpawnPoint("f_siauliai_50_1.Id8", "f_siauliai_50_1", Rectangle(-191, 1307, 30));
		AddSpawnPoint("f_siauliai_50_1.Id8", "f_siauliai_50_1", Rectangle(47, 1417, 30));

		// 'Ridimed_Purple' GenType 92 Spawn Points
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(-1058, 1569, 50));
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(-881, 1615, 50));
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(-822, 1524, 50));
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(-875, 1437, 50));
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(-923, 1370, 50));
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(-944, 1333, 50));
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(-1033, 1449, 50));
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(-1007, 1556, 50));
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(-910, 1509, 50));
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(-677, 1406, 50));
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(-559, 1419, 50));
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(961, 1511, 50));
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(1042, 1435, 50));
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(1032, 1382, 50));
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(1017, 1282, 50));
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(876, 1283, 50));
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(800, 1362, 50));
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(866, 1433, 50));
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(950, 1367, 50));
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(1027, 1337, 50));
		AddSpawnPoint("f_siauliai_50_1.Id9", "f_siauliai_50_1", Rectangle(1108, 1284, 50));

		// 'Sakmoli_Orange' GenType 93 Spawn Points
		AddSpawnPoint("f_siauliai_50_1.Id10", "f_siauliai_50_1", Rectangle(879, 1519, 50));
		AddSpawnPoint("f_siauliai_50_1.Id10", "f_siauliai_50_1", Rectangle(988, 1406, 50));
		AddSpawnPoint("f_siauliai_50_1.Id10", "f_siauliai_50_1", Rectangle(905, 1319, 50));
		AddSpawnPoint("f_siauliai_50_1.Id10", "f_siauliai_50_1", Rectangle(967, 1265, 50));
		AddSpawnPoint("f_siauliai_50_1.Id10", "f_siauliai_50_1", Rectangle(1107, 1345, 50));
		AddSpawnPoint("f_siauliai_50_1.Id10", "f_siauliai_50_1", Rectangle(647, 1437, 50));
		AddSpawnPoint("f_siauliai_50_1.Id10", "f_siauliai_50_1", Rectangle(454, 1505, 50));
		AddSpawnPoint("f_siauliai_50_1.Id10", "f_siauliai_50_1", Rectangle(289, 1473, 50));
		AddSpawnPoint("f_siauliai_50_1.Id10", "f_siauliai_50_1", Rectangle(-1010, 1600, 50));
		AddSpawnPoint("f_siauliai_50_1.Id10", "f_siauliai_50_1", Rectangle(-971, 1445, 50));
		AddSpawnPoint("f_siauliai_50_1.Id10", "f_siauliai_50_1", Rectangle(-982, 1293, 50));
		AddSpawnPoint("f_siauliai_50_1.Id10", "f_siauliai_50_1", Rectangle(-826, 1440, 50));
	}
}
