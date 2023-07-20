//--- Melia Script -----------------------------------------------------------
// Rancid Labyrinth Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_catacomb_80_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCatacomb801MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_catacomb_80_1.Id1", MonsterId.ERD_Triffid, 14, 18, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_1.Id2", MonsterId.ERD_Goblin2_Hammer, 14, 18, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_1.Id3", MonsterId.ERD_Kowak, 14, 18, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_1.Id4", MonsterId.ERD_Kowak_Orange, 14, 18, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_1.Id5", MonsterId.ERD_Fisherman_Red, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_1.Id6", MonsterId.ERD_Panto_Rspear, 14, 18, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_1.Id7", MonsterId.ERD_Tree_Root_Mole_Pink, 14, 18, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_1.Id8", MonsterId.ERD_Melatanun, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_catacomb_80_1.Id9", MonsterId.ERD_Rudas_Loxodon, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_1.Id10", MonsterId.ERD_GoblinWarrior_Blue, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_1.Id11", MonsterId.Rootcrystal_05, 12, 15, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'ERD_Triffid' GenType 8 Spawn Points
		AddSpawnPoint("d_catacomb_80_1.Id1", "d_catacomb_80_1", Rectangle(-187, -1882, 60));
		AddSpawnPoint("d_catacomb_80_1.Id1", "d_catacomb_80_1", Rectangle(11, -1919, 60));
		AddSpawnPoint("d_catacomb_80_1.Id1", "d_catacomb_80_1", Rectangle(-237, -1584, 60));
		AddSpawnPoint("d_catacomb_80_1.Id1", "d_catacomb_80_1", Rectangle(190, -1489, 60));
		AddSpawnPoint("d_catacomb_80_1.Id1", "d_catacomb_80_1", Rectangle(-477, -1689, 60));
		AddSpawnPoint("d_catacomb_80_1.Id1", "d_catacomb_80_1", Rectangle(371, -1703, 60));

		// 'ERD_Goblin2_Hammer' GenType 9 Spawn Points
		AddSpawnPoint("d_catacomb_80_1.Id2", "d_catacomb_80_1", Rectangle(-1126, -1916, 80));
		AddSpawnPoint("d_catacomb_80_1.Id2", "d_catacomb_80_1", Rectangle(-1245, -1568, 80));
		AddSpawnPoint("d_catacomb_80_1.Id2", "d_catacomb_80_1", Rectangle(894, -1854, 80));
		AddSpawnPoint("d_catacomb_80_1.Id2", "d_catacomb_80_1", Rectangle(950, -1562, 80));
		AddSpawnPoint("d_catacomb_80_1.Id2", "d_catacomb_80_1", Rectangle(960, -917, 80));
		AddSpawnPoint("d_catacomb_80_1.Id2", "d_catacomb_80_1", Rectangle(1283, -780, 80));
		AddSpawnPoint("d_catacomb_80_1.Id2", "d_catacomb_80_1", Rectangle(-942, -776, 80));
		AddSpawnPoint("d_catacomb_80_1.Id2", "d_catacomb_80_1", Rectangle(-1261, -668, 80));

		// 'ERD_Kowak' GenType 10 Spawn Points
		AddSpawnPoint("d_catacomb_80_1.Id3", "d_catacomb_80_1", Rectangle(-94, -1783, 60));
		AddSpawnPoint("d_catacomb_80_1.Id3", "d_catacomb_80_1", Rectangle(-84, -1550, 60));
		AddSpawnPoint("d_catacomb_80_1.Id3", "d_catacomb_80_1", Rectangle(593, -1694, 60));
		AddSpawnPoint("d_catacomb_80_1.Id3", "d_catacomb_80_1", Rectangle(-686, -1679, 60));
		AddSpawnPoint("d_catacomb_80_1.Id3", "d_catacomb_80_1", Rectangle(-1005, -1640, 60));
		AddSpawnPoint("d_catacomb_80_1.Id3", "d_catacomb_80_1", Rectangle(-912, -1751, 60));
		AddSpawnPoint("d_catacomb_80_1.Id3", "d_catacomb_80_1", Rectangle(1157, -1655, 60));
		AddSpawnPoint("d_catacomb_80_1.Id3", "d_catacomb_80_1", Rectangle(1237, -1748, 60));
		AddSpawnPoint("d_catacomb_80_1.Id3", "d_catacomb_80_1", Rectangle(1060, -1899, 60));
		AddSpawnPoint("d_catacomb_80_1.Id3", "d_catacomb_80_1", Rectangle(-1271, -1785, 60));

		// 'ERD_Kowak_Orange' GenType 11 Spawn Points
		AddSpawnPoint("d_catacomb_80_1.Id4", "d_catacomb_80_1", Rectangle(-1216, 66, 60));
		AddSpawnPoint("d_catacomb_80_1.Id4", "d_catacomb_80_1", Rectangle(-1006, 229, 60));
		AddSpawnPoint("d_catacomb_80_1.Id4", "d_catacomb_80_1", Rectangle(-1239, 394, 60));
		AddSpawnPoint("d_catacomb_80_1.Id4", "d_catacomb_80_1", Rectangle(-983, 438, 60));
		AddSpawnPoint("d_catacomb_80_1.Id4", "d_catacomb_80_1", Rectangle(985, 73, 60));
		AddSpawnPoint("d_catacomb_80_1.Id4", "d_catacomb_80_1", Rectangle(1240, 164, 60));
		AddSpawnPoint("d_catacomb_80_1.Id4", "d_catacomb_80_1", Rectangle(1012, 322, 60));
		AddSpawnPoint("d_catacomb_80_1.Id4", "d_catacomb_80_1", Rectangle(1245, 418, 60));
		AddSpawnPoint("d_catacomb_80_1.Id4", "d_catacomb_80_1", Rectangle(-1185, 227, 60));
		AddSpawnPoint("d_catacomb_80_1.Id4", "d_catacomb_80_1", Rectangle(1144, 237, 60));

		// 'ERD_Fisherman_Red' GenType 12 Spawn Points
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(948, 627, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(1256, 610, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(944, 856, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(-1238, 581, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(-957, 629, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(-967, 879, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(1213, 845, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(-1116, 780, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(-914, 2041, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(821, 2060, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(205, -1438, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(-1095, 1084, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(-1085, 1469, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(-1329, 1629, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(-1042, 1808, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(-1081, 1672, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(-479, 2063, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(-271, 2243, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(-127, 2063, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(51, 2242, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(220, 2025, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(495, 2059, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(1076, 1824, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(913, 1654, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(1120, 1444, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(1246, 1646, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(962, 1465, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(1061, 1049, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(907, 386, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(1201, 280, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(1130, 493, 40));
		AddSpawnPoint("d_catacomb_80_1.Id5", "d_catacomb_80_1", Rectangle(1113, 678, 40));

		// 'ERD_Panto_Rspear' GenType 13 Spawn Points
		AddSpawnPoint("d_catacomb_80_1.Id6", "d_catacomb_80_1", Rectangle(-1264, 1410, 60));
		AddSpawnPoint("d_catacomb_80_1.Id6", "d_catacomb_80_1", Rectangle(-1011, 1358, 60));
		AddSpawnPoint("d_catacomb_80_1.Id6", "d_catacomb_80_1", Rectangle(-1281, 1686, 60));
		AddSpawnPoint("d_catacomb_80_1.Id6", "d_catacomb_80_1", Rectangle(-964, 1704, 60));
		AddSpawnPoint("d_catacomb_80_1.Id6", "d_catacomb_80_1", Rectangle(953, 1378, 60));
		AddSpawnPoint("d_catacomb_80_1.Id6", "d_catacomb_80_1", Rectangle(904, 1672, 60));
		AddSpawnPoint("d_catacomb_80_1.Id6", "d_catacomb_80_1", Rectangle(1194, 1415, 60));
		AddSpawnPoint("d_catacomb_80_1.Id6", "d_catacomb_80_1", Rectangle(1207, 1668, 60));
		AddSpawnPoint("d_catacomb_80_1.Id6", "d_catacomb_80_1", Rectangle(-383, 2060, 60));
		AddSpawnPoint("d_catacomb_80_1.Id6", "d_catacomb_80_1", Rectangle(230, 2084, 60));

		// 'ERD_Tree_Root_Mole_Pink' GenType 14 Spawn Points
		AddSpawnPoint("d_catacomb_80_1.Id7", "d_catacomb_80_1", Rectangle(-443, 2224, 60));
		AddSpawnPoint("d_catacomb_80_1.Id7", "d_catacomb_80_1", Rectangle(-202, 2210, 60));
		AddSpawnPoint("d_catacomb_80_1.Id7", "d_catacomb_80_1", Rectangle(-178, 1931, 60));
		AddSpawnPoint("d_catacomb_80_1.Id7", "d_catacomb_80_1", Rectangle(39, 2233, 60));
		AddSpawnPoint("d_catacomb_80_1.Id7", "d_catacomb_80_1", Rectangle(63, 1940, 60));
		AddSpawnPoint("d_catacomb_80_1.Id7", "d_catacomb_80_1", Rectangle(299, 1963, 60));

		// 'ERD_Melatanun' GenType 15 Spawn Points
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(1111, -767, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(985, -1706, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(-1132, -1754, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(-1158, -829, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(-972, 1549, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(828, 1526, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(-1265, -1918, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(-1277, -1535, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(-841, -1529, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(-904, -1896, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(-625, -1700, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(-173, -1737, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(-64, -1989, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(-248, -1502, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(20, -1411, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(80, -1741, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(399, -1643, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(662, -1775, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(854, -1473, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(1215, -1507, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(1254, -1847, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(935, -1972, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(1082, -1228, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(918, -834, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(1098, -494, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(1328, -781, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(1192, -1054, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(1073, -1173, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(-1273, -704, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(-1281, -1023, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(-1056, -1074, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(-817, -674, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(-1149, -450, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(-1124, 87, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(-1219, 232, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(-995, 458, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(-1228, 466, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(950, 168, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(1205, 74, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(1089, 275, 40));
		AddSpawnPoint("d_catacomb_80_1.Id8", "d_catacomb_80_1", Rectangle(1191, 452, 40));

		// 'ERD_Rudas_Loxodon' GenType 16 Spawn Points
		AddSpawnPoint("d_catacomb_80_1.Id9", "d_catacomb_80_1", Rectangle(1129, -552, 20));
		AddSpawnPoint("d_catacomb_80_1.Id9", "d_catacomb_80_1", Rectangle(-1128, -547, 20));
		AddSpawnPoint("d_catacomb_80_1.Id9", "d_catacomb_80_1", Rectangle(-1019, 69, 20));
		AddSpawnPoint("d_catacomb_80_1.Id9", "d_catacomb_80_1", Rectangle(1204, 4, 20));
		AddSpawnPoint("d_catacomb_80_1.Id9", "d_catacomb_80_1", Rectangle(-256, -1722, 20));
		AddSpawnPoint("d_catacomb_80_1.Id9", "d_catacomb_80_1", Rectangle(-962, -1703, 20));
		AddSpawnPoint("d_catacomb_80_1.Id9", "d_catacomb_80_1", Rectangle(933, -1710, 20));
		AddSpawnPoint("d_catacomb_80_1.Id9", "d_catacomb_80_1", Rectangle(-1134, 535, 20));
		AddSpawnPoint("d_catacomb_80_1.Id9", "d_catacomb_80_1", Rectangle(1105, 525, 20));

		// 'ERD_GoblinWarrior_Blue' GenType 17 Spawn Points
		AddSpawnPoint("d_catacomb_80_1.Id10", "d_catacomb_80_1", Rectangle(1265, 908, 20));
		AddSpawnPoint("d_catacomb_80_1.Id10", "d_catacomb_80_1", Rectangle(-1283, 895, 20));
		AddSpawnPoint("d_catacomb_80_1.Id10", "d_catacomb_80_1", Rectangle(-419, 1955, 20));
		AddSpawnPoint("d_catacomb_80_1.Id10", "d_catacomb_80_1", Rectangle(356, 2214, 20));
		AddSpawnPoint("d_catacomb_80_1.Id10", "d_catacomb_80_1", Rectangle(-45, 2101, 20));
		AddSpawnPoint("d_catacomb_80_1.Id10", "d_catacomb_80_1", Rectangle(1109, 340, 20));
		AddSpawnPoint("d_catacomb_80_1.Id10", "d_catacomb_80_1", Rectangle(1069, 1559, 20));
		AddSpawnPoint("d_catacomb_80_1.Id10", "d_catacomb_80_1", Rectangle(-1139, 1581, 20));
		AddSpawnPoint("d_catacomb_80_1.Id10", "d_catacomb_80_1", Rectangle(-1120, 300, 20));
		AddSpawnPoint("d_catacomb_80_1.Id10", "d_catacomb_80_1", Rectangle(124, -1693, 20));

		// 'Rootcrystal_05' GenType 18 Spawn Points
		AddSpawnPoint("d_catacomb_80_1.Id11", "d_catacomb_80_1", Rectangle(-130, -1717, 100));
		AddSpawnPoint("d_catacomb_80_1.Id11", "d_catacomb_80_1", Rectangle(-1187, -1681, 100));
		AddSpawnPoint("d_catacomb_80_1.Id11", "d_catacomb_80_1", Rectangle(-1135, -831, 100));
		AddSpawnPoint("d_catacomb_80_1.Id11", "d_catacomb_80_1", Rectangle(-1142, 80, 100));
		AddSpawnPoint("d_catacomb_80_1.Id11", "d_catacomb_80_1", Rectangle(-1081, 717, 100));
		AddSpawnPoint("d_catacomb_80_1.Id11", "d_catacomb_80_1", Rectangle(-1108, 1538, 100));
		AddSpawnPoint("d_catacomb_80_1.Id11", "d_catacomb_80_1", Rectangle(-337, 2115, 100));
		AddSpawnPoint("d_catacomb_80_1.Id11", "d_catacomb_80_1", Rectangle(184, 2097, 100));
		AddSpawnPoint("d_catacomb_80_1.Id11", "d_catacomb_80_1", Rectangle(947, 1620, 100));
		AddSpawnPoint("d_catacomb_80_1.Id11", "d_catacomb_80_1", Rectangle(999, 707, 100));
		AddSpawnPoint("d_catacomb_80_1.Id11", "d_catacomb_80_1", Rectangle(1144, 132, 100));
		AddSpawnPoint("d_catacomb_80_1.Id11", "d_catacomb_80_1", Rectangle(988, -721, 100));
		AddSpawnPoint("d_catacomb_80_1.Id11", "d_catacomb_80_1", Rectangle(1033, -1784, 100));
		AddSpawnPoint("d_catacomb_80_1.Id11", "d_catacomb_80_1", Rectangle(1248, 528, 100));
		AddSpawnPoint("d_catacomb_80_1.Id11", "d_catacomb_80_1", Rectangle(-1281, 585, 100));
		AddSpawnPoint("d_catacomb_80_1.Id11", "d_catacomb_80_1", Rectangle(-26, 1953, 100));
	}
}
