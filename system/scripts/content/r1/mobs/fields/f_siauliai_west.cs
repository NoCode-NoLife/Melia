//--- Melia Script -----------------------------------------------------------
// West Siauliai Woods Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_siauliai_west'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliaiWestMobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_siauliai_west", MonsterId.Leaf_Diving, Properties("MHP", 632, "MINPATK", 111, "MAXPATK", 119, "MINMATK", 111, "MAXMATK", 119, "DEF", 10, "MDEF", 10));
		AddPropertyOverrides("f_siauliai_west", MonsterId.Onion, Properties("MHP", 660, "MINPATK", 112, "MAXPATK", 120, "MINMATK", 112, "MAXMATK", 120, "DEF", 10, "MDEF", 10));
		AddPropertyOverrides("f_siauliai_west", MonsterId.Hanaming, Properties("MHP", 722, "MINPATK", 115, "MAXPATK", 123, "MINMATK", 115, "MAXMATK", 123, "DEF", 10, "MDEF", 10));
		AddPropertyOverrides("f_siauliai_west", MonsterId.Bokchoy, Properties("MHP", 810, "MINPATK", 119, "MAXPATK", 128, "MINMATK", 119, "MAXMATK", 128, "DEF", 11, "MDEF", 11));
		AddPropertyOverrides("f_siauliai_west", MonsterId.InfroRocktor, Properties("MHP", 923, "MINPATK", 124, "MAXPATK", 133, "MINMATK", 124, "MAXMATK", 133, "DEF", 11, "MDEF", 11));
		AddPropertyOverrides("f_siauliai_west", MonsterId.Mushcarfung_Summon, Properties("MHP", 1057, "MINPATK", 130, "MAXPATK", 140, "MINMATK", 130, "MAXMATK", 140, "DEF", 12, "MDEF", 12));
		AddPropertyOverrides("f_siauliai_west", MonsterId.Boss_Mushcaria, Properties("MHP", 5451, "MINPATK", 247, "MAXPATK", 266, "MINMATK", 247, "MAXMATK", 266, "DEF", 23, "MDEF", 23));
		AddPropertyOverrides("f_siauliai_west", MonsterId.Onion_Big, Properties("MHP", 1385, "MINPATK", 145, "MAXPATK", 156, "MINMATK", 145, "MAXMATK", 156, "DEF", 14, "MDEF", 14));

		// Monster Spawners ---------------------------------

		AddSpawner("f_siauliai_west.Id1", MonsterId.Leaf_Diving, min: 15, max: 20);
		AddSpawner("f_siauliai_west.Id2", MonsterId.Onion, min: 27, max: 35);
		AddSpawner("f_siauliai_west.Id3", MonsterId.Hanaming, min: 19, max: 25);
		AddSpawner("f_siauliai_west.Id4", MonsterId.Bokchoy, min: 15, max: 20);
		AddSpawner("f_siauliai_west.Id5", MonsterId.InfroRocktor, min: 15, max: 20);
		AddSpawner("f_siauliai_west.Id6", MonsterId.Rootcrystal_01, min: 9, max: 12, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("f_siauliai_west.Id7", MonsterId.Leaf_Diving, min: 12, max: 15);
		AddSpawner("f_siauliai_west.Id8", MonsterId.Onion, min: 12, max: 15);
		AddSpawner("f_siauliai_west.Id9", MonsterId.Hanaming, min: 15, max: 20);

		// Monster Spawn Points -----------------------------

		// 'Leaf_Diving' GenType 13 Spawn Points
		AddSpawnPoint("f_siauliai_west.Id1", "f_siauliai_west", Rectangle(-1603, -634, 80));
		AddSpawnPoint("f_siauliai_west.Id1", "f_siauliai_west", Rectangle(-1714, -793, 80));
		AddSpawnPoint("f_siauliai_west.Id1", "f_siauliai_west", Rectangle(-1803, -929, 80));
		AddSpawnPoint("f_siauliai_west.Id1", "f_siauliai_west", Rectangle(-1026, 188, 80));
		AddSpawnPoint("f_siauliai_west.Id1", "f_siauliai_west", Rectangle(-1722, -1102, 80));

		// 'Onion' GenType 15 Spawn Points
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-1545, -1109, 80));
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-1942, -1147, 80));
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-1719, -765, 80));
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-1977, -439, 80));
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-1893, 58, 80));
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-1681, -1208, 80));
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-2062, -1299, 80));
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-1846, -994, 80));
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-1934, -120, 80));
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-1832, 282, 80));
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-1812, -419, 80));

		// 'Hanaming' GenType 16 Spawn Points
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(-110, 489, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(-225, 11, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(-282, 396, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(-238, 158, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(95, 707, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(175, 317, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(273, 234, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(-56, -3, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(-95, 668, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(-204, 294, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(-114, 90, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(-120, 204, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(26, 541, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(146, 568, 40));

		// 'Bokchoy' GenType 17 Spawn Points
		AddSpawnPoint("f_siauliai_west.Id4", "f_siauliai_west", Rectangle(1259, 529, 100));
		AddSpawnPoint("f_siauliai_west.Id4", "f_siauliai_west", Rectangle(791, 531, 100));
		AddSpawnPoint("f_siauliai_west.Id4", "f_siauliai_west", Rectangle(664, 225, 100));
		AddSpawnPoint("f_siauliai_west.Id4", "f_siauliai_west", Rectangle(819, 269, 100));
		AddSpawnPoint("f_siauliai_west.Id4", "f_siauliai_west", Rectangle(591, -1, 100));
		AddSpawnPoint("f_siauliai_west.Id4", "f_siauliai_west", Rectangle(1384, 586, 100));
		AddSpawnPoint("f_siauliai_west.Id4", "f_siauliai_west", Rectangle(1079, 581, 100));

		// 'InfroRocktor' GenType 18 Spawn Points
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(401, -664, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(721, -1189, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(303, -1000, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(535, -1103, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(532, -832, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(722, -979, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(349, -805, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(700, -761, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(445, -978, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(415, -1181, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(853, -867, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(275, -673, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(563, -693, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(651, -894, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(636, -1056, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(622, -1180, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(416, -1042, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(132, -963, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(567, -924, 30));

		// 'Rootcrystal_01' GenType 30 Spawn Points
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-2094, -397, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1903, -134, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-978, 291, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-902, 378, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-776, 696, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-280, 310, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-741, 1117, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-423, 1518, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-527, 406, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-571, 85, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-377, 51, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-193, -6, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-193, 415, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-8, 529, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(324, 248, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(99, 622, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1059, -517, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-2035, -977, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-2062, -1019, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-2002, -1318, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1698, -639, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1557, -1179, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1388, -1092, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1239, -765, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1437, -837, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(851, -120, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(639, -55, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(624, 128, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(922, 553, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1085, 620, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1356, 632, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1372, 419, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1506, 428, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1695, 276, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1465, -342, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1222, -496, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1289, -472, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1139, -745, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(958, -746, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(174, -960, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(377, -996, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(488, -1158, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(750, -1131, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1018, -943, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1205, -1040, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1434, -1049, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1876, -1031, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1960, -1265, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1622, -684, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1694, -791, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1331, -135, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1677, -399, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1850, -2, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1959, 95, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1823, 246, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1827, -435, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-463, -17, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-686, 592, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-665, 753, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-575, 1189, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-630, 1297, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-121, 51, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-172, 172, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-18, 648, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(193, 591, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(130, 285, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(725, -798, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(474, -725, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(565, -921, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(899, -830, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1471, -675, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1230, -778, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1057, -829, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(766, -260, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(742, 141, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(734, 327, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(776, 579, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1557, 258, 200));

		// 'Leaf_Diving' GenType 201 Spawn Points
		AddSpawnPoint("f_siauliai_west.Id7", "f_siauliai_west", Rectangle(-1781, -1018, 450));

		// 'Onion' GenType 2022 Spawn Points
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1177, -1054, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1001, -836, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1189, -723, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1319, -955, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1424, -1090, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1452, -730, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1565, -997, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1425, -848, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1251, -542, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(848, -889, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1220, -888, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(968, -746, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1040, -970, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1584, -726, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1304, -774, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1366, -355, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1268, -388, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1491, -378, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(740, -779, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(602, -958, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(621, -1044, 20));

		// 'Hanaming' GenType 2023 Spawn Points
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1236, -920, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1085, -937, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(789, -897, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(645, -1092, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(426, -1013, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1240, -638, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(941, -831, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(375, -761, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1350, -830, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1320, -907, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1358, -996, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1421, -1078, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1507, -1025, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1462, -914, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1458, -781, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1464, -694, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(592, -804, 20));
	}
}
