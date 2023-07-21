//--- Melia Script -----------------------------------------------------------
// Feline Post Town Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_nicopolis_81_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FNicopolis812MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_nicopolis_81_2.Id1", MonsterId.Wiza_Moya, 37, 49, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_nicopolis_81_2.Id2", MonsterId.Mimorat_Pink, 25, 33, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_nicopolis_81_2.Id3", MonsterId.Mimorat_White, 30, 39, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_nicopolis_81_2.Id4", MonsterId.Vine_Walker, 11, 14, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_nicopolis_81_2.Id5", MonsterId.Rootcrystal_02, 15, 20, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Wiza_Moya' GenType 1 Spawn Points
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-1991, -983, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-1584, -805, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-1267, -1275, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-1838, -1914, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-1546, -2188, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-1303, -1697, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-754, -1360, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-575, -1692, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-375, -2682, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(205, -2096, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-363, -2225, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(274, -1505, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(1669, -1657, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(2146, -1487, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(1775, -796, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(1946, -1176, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(1482, -1327, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(1176, -1731, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(745, -1366, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(896, -911, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(862, 68, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(794, -288, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(1800, -1434, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-707, -915, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-708, -461, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-1029, -83, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-1053, 326, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-378, 271, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(37, 315, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(440, 613, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(397, 918, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-527, 1272, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(90, 1381, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(574, 1302, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-78, -2692, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-95, -2108, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(107, -2521, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-1790, -1028, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-1581, -956, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-860, -1442, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-673, -1764, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(514, 1121, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-16, 188, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(690, -1804, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(972, -1784, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(555, -1489, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(291, -2267, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-451, -2461, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-525, -2101, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(772, -1615, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(1047, -633, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(1156, -593, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(446, 122, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(338, 342, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-796, 29, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-660, 189, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-541, -1439, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Rectangle(-91, -2403, 25));

		// 'Mimorat_Pink' GenType 2 Spawn Points
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(1632, -1883, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(1980, -1600, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(1795, -1430, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(1614, -1189, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(1925, -939, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(2018, -710, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(973, -1787, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(570, -1755, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(716, -1558, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(573, -1115, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(1047, -650, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(981, -363, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(457, 13, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(167, 486, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(677, 494, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(338, 1154, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(438, 1451, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(-486, 1458, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(-226, 1326, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(449, 2035, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(766, 2595, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(669, 2117, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(1145, 2216, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(1568, 2034, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(1466, 2447, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(-1141, 64, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(-845, 190, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(-743, -146, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(-484, -768, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(-801, -648, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(326, 2339, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(951, -889, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(1242, -743, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(1249, -456, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(393, 243, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(501, 404, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(157, 1365, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(-586, 1240, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Rectangle(638, 2312, 25));

		// 'Mimorat_White' GenType 3 Spawn Points
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(201, -2665, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-58, -2417, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-54, -2154, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-484, -2518, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-128, -2773, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-807, -1633, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-247, -1451, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-1796, -2154, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-1311, -1956, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-2129, -991, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-1774, -799, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-1386, -1100, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-1105, -1562, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-617, -801, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-1151, 278, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-889, 51, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-486, 120, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(612, 334, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-145, 374, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(302, 1306, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(386, 1574, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-651, 1380, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(353, 2093, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(583, 2249, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(657, 2519, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(1353, 1963, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(1280, 2442, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(1461, 2187, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(285, 9, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(506, 1167, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(574, 2035, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(337, 255, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(128, 211, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(265, 483, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-783, -193, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-642, -606, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-573, -1432, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-579, -1648, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-799, -1386, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-673, -1512, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-222, -2504, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(179, -2259, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(-303, -2204, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Rectangle(123, -2570, 25));

		// 'Vine_Walker' GenType 4 Spawn Points
		AddSpawnPoint("f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Rectangle(327, 66, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Rectangle(571, 257, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Rectangle(-833, 225, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Rectangle(-918, -31, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Rectangle(909, -538, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Rectangle(1246, -680, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Rectangle(590, -1513, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Rectangle(798, -1180, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Rectangle(1713, -1445, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Rectangle(1755, -1173, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Rectangle(-623, -632, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Rectangle(-62, -2201, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Rectangle(84, -2565, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Rectangle(-824, -1629, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Rectangle(-581, -1408, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Rectangle(303, 476, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Rectangle(352, 1138, 25));
		AddSpawnPoint("f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Rectangle(-312, -2482, 25));

		// 'Rootcrystal_02' GenType 34 Spawn Points
		AddSpawnPoint("f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Rectangle(1720, -1653, 150));
		AddSpawnPoint("f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Rectangle(1951, -844, 150));
		AddSpawnPoint("f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Rectangle(764, -1729, 150));
		AddSpawnPoint("f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Rectangle(1014, -891, 150));
		AddSpawnPoint("f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Rectangle(1016, -473, 150));
		AddSpawnPoint("f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Rectangle(631, 282, 150));
		AddSpawnPoint("f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Rectangle(139, 252, 150));
		AddSpawnPoint("f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Rectangle(412, 1238, 150));
		AddSpawnPoint("f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Rectangle(-352, 1350, 150));
		AddSpawnPoint("f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Rectangle(605, 2212, 150));
		AddSpawnPoint("f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Rectangle(1482, 2146, 150));
		AddSpawnPoint("f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Rectangle(-405, -1457, 150));
		AddSpawnPoint("f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Rectangle(-890, -1556, 150));
		AddSpawnPoint("f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Rectangle(-651, -736, 150));
		AddSpawnPoint("f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Rectangle(-1065, 159, 150));
		AddSpawnPoint("f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Rectangle(-526, 61, 150));
		AddSpawnPoint("f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Rectangle(-1639, -2119, 150));
		AddSpawnPoint("f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Rectangle(-1559, -897, 150));
		AddSpawnPoint("f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Rectangle(-30, -2687, 150));
		AddSpawnPoint("f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Rectangle(-201, -2169, 150));
	}
}
