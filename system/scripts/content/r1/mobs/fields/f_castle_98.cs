//--- Melia Script -----------------------------------------------------------
// Outer Wall District 15 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_castle_98'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle98MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_castle_98.Id1", MonsterId.Kisylion, 60, 80, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_98.Id2", MonsterId.Ghosbebe, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_98.Id3", MonsterId.Scare_Crow_White, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_98.Id4", MonsterId.Rootcrystal_03, 23, 30, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Kisylion' GenType 1 Spawn Points
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(-158, -866, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(-20, -775, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(-61, -1010, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(409, -814, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(900, -752, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(948, -917, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(740, -867, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1595, -719, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1430, -671, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1511, -555, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2367, -1181, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2408, -1039, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2508, -1131, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1969, -695, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1520, -635, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1636, -513, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1503, -295, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1666, -201, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1607, 182, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1663, 274, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1897, 199, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2130, 365, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2209, 214, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2395, 218, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2344, 457, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2380, 1136, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2244, 1140, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1272, 969, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1064, 926, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(363, 941, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(374, 1099, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(233, 991, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(345, 1534, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(877, 1074, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(678, 264, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(693, 96, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1590, 187, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(796, 344, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1428, 93, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1716, -421, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1041, -822, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2336, -816, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1696, 97, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1484, 121, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(892, 560, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(285, 838, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2542, 198, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2507, 1095, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2357, 1267, 40));

		// 'Ghosbebe' GenType 2 Spawn Points
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2413, 1050, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2308, 1051, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2311, 1197, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2469, 1204, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2212, 1233, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1346, 1031, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1228, 1093, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1196, 970, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(992, 1037, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1016, 799, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(474, 1078, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(419, 970, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(411, 859, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(257, 909, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(307, 1018, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(318, 1155, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(349, 1450, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1147, 944, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1487, 1008, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1405, 1205, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(980, 680, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(845, 474, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(757, 281, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(726, 205, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(620, 206, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(670, -1, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(781, 90, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1472, 234, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1463, 226, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1497, 208, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1584, 282, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1596, 91, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1769, 184, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1770, 139, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1700, 219, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2051, 243, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2121, 272, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2201, 138, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2310, 139, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2309, 330, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2347, 393, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2177, 460, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2482, 335, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2464, 152, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2412, 108, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2648, 233, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2582, 130, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1674, -6, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1620, -112, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1742, -167, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1584, -188, 20));

		// 'Scare_Crow_White' GenType 3 Spawn Points
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(2444, -1154, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(2352, -1095, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(2422, -905, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(2022, -703, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1844, -698, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1514, -721, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1673, -705, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1480, -488, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1559, -394, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1720, -292, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1606, -287, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1720, -605, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1554, -637, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1079, -758, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1700, -786, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(836, -913, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(883, -1006, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1022, -985, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1021, -677, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(753, -700, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(795, -792, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(544, -775, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(424, -908, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(307, -832, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(452, -730, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(-132, -749, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(-22, -701, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(-52, -880, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(-280, -887, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(-171, -1025, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(947, -839, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1455, -604, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1616, -650, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1668, 168, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1831, 211, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(2316, 242, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(2272, 145, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(754, 145, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(722, 333, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1094, -873, 20));

		// 'Rootcrystal_03' GenType 5 Spawn Points
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(1566, -1422, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(1525, -667, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(1650, -402, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(1701, -1, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(1026, -755, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(624, -827, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(240, -833, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(-178, -912, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(-496, -1024, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(1967, -697, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(2476, -1028, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(2533, -1486, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(2121, 218, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(2354, 425, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(2545, 178, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(2279, 1127, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(2526, 1181, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(1624, 215, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(1423, 1037, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(1002, 993, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(339, 1002, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(339, 1515, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(698, 111, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(847, 479, 200));
	}
}
