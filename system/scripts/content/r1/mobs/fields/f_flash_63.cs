//--- Melia Script -----------------------------------------------------------
// Downtown Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_flash_63'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFlash63MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_flash_63", MonsterId.Lemur, Properties("MHP", 274272, "MINPATK", 4028, "MAXPATK", 4852, "MINMATK", 4028, "MAXMATK", 4852, "DEF", 16536, "MDEF", 16536));
		AddPropertyOverrides("f_flash_63", MonsterId.Goblin2_Hammer, Properties("MHP", 275164, "MINPATK", 4040, "MAXPATK", 4866, "MINMATK", 4040, "MAXMATK", 4866, "DEF", 16701, "MDEF", 16701));
		AddPropertyOverrides("f_flash_63", MonsterId.Goblin2_Wand3, Properties("MHP", 276176, "MINPATK", 4053, "MAXPATK", 4882, "MINMATK", 4053, "MAXMATK", 4882, "DEF", 16889, "MDEF", 16889));

		// Monster Spawners ---------------------------------

		AddSpawner("f_flash_63.Id1", MonsterId.Lemur, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_63.Id2", MonsterId.Lemur, 53, 70, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_63.Id3", MonsterId.Goblin2_Hammer, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_63.Id4", MonsterId.Goblin2_Wand3, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_63.Id5", MonsterId.Rootcrystal_01, 12, 15, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_flash_63.Id6", MonsterId.Lemur, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_63.Id7", MonsterId.Goblin2_Wand3, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_63.Id8", MonsterId.Lemur, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Lemur' GenType 3 Spawn Points
		AddSpawnPoint("f_flash_63.Id1", "f_flash_63", Rectangle(489, 876, 9999));

		// 'Lemur' GenType 32 Spawn Points
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-539, -178, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1041, -171, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(31, -2045, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-509, 438, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(967, -402, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-485, -611, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(831, -184, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-88, -2246, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1009, -1318, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(946, -1475, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1049, -1220, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(15, -2127, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(447, -1561, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(467, -1432, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-298, -719, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-310, -485, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-484, -71, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1175, -232, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1098, -58, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(802, -368, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(921, 15, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-169, -2277, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-261, -2232, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-6, -2279, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-42, -2170, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-420, -2034, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-343, -2179, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1095, -1360, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1141, -1235, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(679, -1251, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1061, -1450, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-457, -2081, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-529, -2195, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-468, -2256, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-486, -2118, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-418, -2214, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-345, -2262, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-251, -2193, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-57, -2348, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(143, -1939, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(93, -1917, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(419, -1567, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(336, -1515, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(363, -1501, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(385, -1428, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(617, -1281, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(703, -1321, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(708, -1244, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(796, -1341, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(881, -1444, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(876, -1264, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(977, -1360, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(924, -461, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(854, -290, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(884, -240, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(952, -183, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1035, -255, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(940, -333, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1061, -501, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1102, -282, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1156, -138, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(883, -24, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(917, -38, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-276, -623, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-352, -545, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-552, -268, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-526, 11, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-593, 2, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-554, -9, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-498, 149, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-539, 483, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-585, 530, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-608, 654, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-562, 860, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-635, 969, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-459, 1004, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-538, 1067, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-586, 1165, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-532, 1246, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-467, 1247, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(234, 829, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-233, 710, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-316, 547, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-218, 664, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(-245, 589, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(318, 812, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(251, 963, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(439, 813, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(469, 991, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(513, 1086, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(352, 912, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(561, 853, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(540, 722, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(624, 726, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(611, 657, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(849, 608, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(890, 656, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(572, 1020, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(658, 1653, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(587, 1767, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(515, 1834, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(505, 1899, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(656, 1900, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(805, 1839, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1302, 2056, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1255, 1928, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1473, 2019, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1580, 2125, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1676, 2057, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1708, 2141, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1425, 2113, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1328, 2165, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1223, 2174, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1417, 1937, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1566, 2003, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1676, 1877, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1729, 2267, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1668, 2300, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1445, 2344, 25));
		AddSpawnPoint("f_flash_63.Id2", "f_flash_63", Rectangle(1554, 2371, 25));

		// 'Goblin2_Hammer' GenType 37 Spawn Points
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-290, -675, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-522, -679, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-568, -77, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-559, 1009, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-460, 1160, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(348, 875, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(545, 925, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(717, 1876, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(1139, 1966, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-599, 831, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(646, 1708, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(541, 794, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(458, 1134, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(549, 1856, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(1296, 1953, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(1282, 1832, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(154, 852, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-599, 581, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-450, 1087, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-534, 1133, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-442, 939, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-470, 933, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-406, -734, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-388, -603, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-311, -567, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-203, -640, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-202, -691, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-480, -469, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-486, -337, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-518, -170, 25));
		AddSpawnPoint("f_flash_63.Id3", "f_flash_63", Rectangle(-560, -173, 25));

		// 'Goblin2_Wand3' GenType 38 Spawn Points
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(-474, -683, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(-488, -214, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(-486, 1081, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(-260, 639, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(463, 925, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(943, -271, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(1314, 1931, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(1569, 2300, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(1632, 2002, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(600, 1896, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(1087, -170, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(146, 806, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(475, 1216, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(-200, -715, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(-441, 929, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(-511, 972, 35));
		AddSpawnPoint("f_flash_63.Id4", "f_flash_63", Rectangle(-476, 1312, 35));

		// 'Rootcrystal_01' GenType 41 Spawn Points
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(-212, -2227, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(64, -2017, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(421, -1486, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(600, -1283, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1004, -1345, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1081, -1165, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1013, -423, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(900, -205, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1079, -199, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(916, 164, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1078, 413, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(544, 774, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(534, 1050, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(221, 758, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1599, 904, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1465, 863, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1261, 1453, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1707, 2026, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1628, 2273, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1473, 2107, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(1242, 2012, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(755, 1757, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(544, 1882, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(-501, 896, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(-374, 1219, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(-564, 579, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(-510, -62, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(-478, -344, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(-483, -637, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(-246, -689, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(248, -906, 100));
		AddSpawnPoint("f_flash_63.Id5", "f_flash_63", Rectangle(420, -644, 100));

		// 'Lemur' GenType 45 Spawn Points
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-236, -2330, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-423, -2128, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-333, -2161, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-67, -2255, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-5, -2223, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(33, -1973, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(91, -2003, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(82, -2091, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(40, -2166, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-128, -2250, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-142, -2311, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(158, -1900, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(129, -1876, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(46, -1966, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-272, -2292, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-99, -2249, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-7, -2172, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(11, -2046, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(18, -2014, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(52, -2065, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-4, -2253, 50));
		AddSpawnPoint("f_flash_63.Id6", "f_flash_63", Rectangle(-34, -2296, 50));

		// 'Goblin2_Wand3' GenType 46 Spawn Points
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-381, -659, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-528, -710, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-431, -573, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-290, -541, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-190, -704, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-289, -720, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-525, -369, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-446, -176, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-489, 88, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-548, 64, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-553, -104, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-581, -225, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-463, -318, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-56, -725, 50));
		AddSpawnPoint("f_flash_63.Id7", "f_flash_63", Rectangle(-477, -636, 50));

		// 'Lemur' GenType 47 Spawn Points
		AddSpawnPoint("f_flash_63.Id8", "f_flash_63", Rectangle(1091, -1150, 50));
		AddSpawnPoint("f_flash_63.Id8", "f_flash_63", Rectangle(1100, -1251, 50));
		AddSpawnPoint("f_flash_63.Id8", "f_flash_63", Rectangle(1100, -1302, 50));
		AddSpawnPoint("f_flash_63.Id8", "f_flash_63", Rectangle(1026, -1418, 50));
		AddSpawnPoint("f_flash_63.Id8", "f_flash_63", Rectangle(915, -1294, 50));
		AddSpawnPoint("f_flash_63.Id8", "f_flash_63", Rectangle(935, -1254, 50));
		AddSpawnPoint("f_flash_63.Id8", "f_flash_63", Rectangle(1025, -1300, 50));
		AddSpawnPoint("f_flash_63.Id8", "f_flash_63", Rectangle(923, -1362, 50));
		AddSpawnPoint("f_flash_63.Id8", "f_flash_63", Rectangle(1044, -1201, 50));
		AddSpawnPoint("f_flash_63.Id8", "f_flash_63", Rectangle(1103, -1363, 50));
	}
}
