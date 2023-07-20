//--- Melia Script -----------------------------------------------------------
// Fedimian Suburbs Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_remains_40'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRemains40MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_remains_40", MonsterId.Hallowventor, Properties("MHP", 87369, "MINPATK", 1624, "MAXPATK", 1898, "MINMATK", 1624, "MAXMATK", 1898, "DEF", 767, "MDEF", 767));
		AddPropertyOverrides("f_remains_40", MonsterId.Cockatries, Properties("MHP", 88029, "MINPATK", 1633, "MAXPATK", 1909, "MINMATK", 1633, "MAXMATK", 1909, "DEF", 789, "MDEF", 789));
		AddPropertyOverrides("f_remains_40", MonsterId.Big_Cockatries, Properties("MHP", 88758, "MINPATK", 1642, "MAXPATK", 1920, "MINMATK", 1642, "MAXMATK", 1920, "DEF", 812, "MDEF", 812));

		// Monster Spawners ---------------------------------

		AddSpawner("f_remains_40.Id1", MonsterId.Hallowventor, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_40.Id2", MonsterId.Cockatries, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_40.Id3", MonsterId.Big_Cockatries, 3, 4, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_40.Id4", MonsterId.Cockatries, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_40.Id5", MonsterId.Hallowventor, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_40.Id6", MonsterId.Cockatries, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_40.Id7", MonsterId.Hallowventor, 12, 16, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_40.Id8", MonsterId.Rootcrystal_01, 18, 23, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_remains_40.Id9", MonsterId.Big_Cockatries, 1, 1, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Hallowventor' GenType 9 Spawn Points
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1399, 746, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1846, 1320, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1133, 479, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(970, 837, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1425, 996, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1676, 617, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1791, 455, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(2017, 610, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1738, 860, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1821, 679, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1948, 1122, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1713, 1053, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1715, 1138, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1258, 1309, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1591, 1577, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1935, 1533, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(2199, 1305, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1802, 1538, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1490, 538, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1202, 761, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(-1681, -822, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(-1616, -686, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(-1405, -584, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(-1442, -798, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(-1459, -873, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(-1435, -1005, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(-1198, -926, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(-1255, -1098, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(-1110, -1114, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(-1065, -965, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(-946, -961, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(-1178, -1032, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(-1385, -512, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(-1497, -638, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1308, 492, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(956, 635, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1215, 1052, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1524, 815, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1665, 422, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1913, 902, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1619, 1241, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(1518, 1389, 25));
		AddSpawnPoint("f_remains_40.Id1", "f_remains_40", Rectangle(2032, 1237, 25));

		// 'Cockatries' GenType 13 Spawn Points
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-2087, -2050, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-653, -465, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(743, -176, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-2153, -1936, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-1955, -1976, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-2001, -2136, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-1961, -2310, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-1968, -2523, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-1318, -546, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-695, -285, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-605, -579, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-617, -153, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-576, 58, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(589, -152, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(400, -149, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(703, -361, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(895, -461, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(812, -61, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(809, -306, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-1818, -1903, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-1766, -1816, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-1663, -1860, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-1534, -1731, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-1497, -1805, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-1362, -1686, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-1077, -591, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-783, -527, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-730, -145, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-616, -13, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(-733, -371, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(525, -219, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(672, -56, 25));
		AddSpawnPoint("f_remains_40.Id2", "f_remains_40", Rectangle(664, -207, 25));

		// 'Big_Cockatries' GenType 14 Spawn Points
		AddSpawnPoint("f_remains_40.Id3", "f_remains_40", Rectangle(1330, 951, 9999));

		// 'Cockatries' GenType 305 Spawn Points
		AddSpawnPoint("f_remains_40.Id4", "f_remains_40", Rectangle(-817, -1216, 9999));

		// 'Hallowventor' GenType 410 Spawn Points
		AddSpawnPoint("f_remains_40.Id5", "f_remains_40", Rectangle(12, -162, 9999));

		// 'Cockatries' GenType 414 Spawn Points
		AddSpawnPoint("f_remains_40.Id6", "f_remains_40", Rectangle(-1974, -3561, 30));
		AddSpawnPoint("f_remains_40.Id6", "f_remains_40", Rectangle(-1819, -3472, 30));
		AddSpawnPoint("f_remains_40.Id6", "f_remains_40", Rectangle(-1787, -3655, 30));
		AddSpawnPoint("f_remains_40.Id6", "f_remains_40", Rectangle(-1611, -3602, 30));
		AddSpawnPoint("f_remains_40.Id6", "f_remains_40", Rectangle(-1691, -3465, 30));
		AddSpawnPoint("f_remains_40.Id6", "f_remains_40", Rectangle(-1542, -3431, 30));
		AddSpawnPoint("f_remains_40.Id6", "f_remains_40", Rectangle(-1762, -3241, 30));
		AddSpawnPoint("f_remains_40.Id6", "f_remains_40", Rectangle(-1753, -2878, 30));
		AddSpawnPoint("f_remains_40.Id6", "f_remains_40", Rectangle(-1704, -3044, 30));
		AddSpawnPoint("f_remains_40.Id6", "f_remains_40", Rectangle(-1881, -2745, 30));
		AddSpawnPoint("f_remains_40.Id6", "f_remains_40", Rectangle(-1887, -2566, 30));
		AddSpawnPoint("f_remains_40.Id6", "f_remains_40", Rectangle(-2024, -2641, 30));
		AddSpawnPoint("f_remains_40.Id6", "f_remains_40", Rectangle(-2111, -3485, 30));
		AddSpawnPoint("f_remains_40.Id6", "f_remains_40", Rectangle(-1610, -3277, 30));

		// 'Hallowventor' GenType 415 Spawn Points
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(-2035, -3768, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(-1998, -3945, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(-1800, -3782, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(-1776, -3926, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(-1780, -4099, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(-1625, -4070, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(-1644, -3815, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(-1950, -3538, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(-1723, -3543, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(-1647, -3682, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(-291, -422, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(-304, -220, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(-224, -327, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(-173, -144, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(-157, -36, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(26, -142, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(-52, -227, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(-125, -310, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(-113, -473, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(29, -445, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(66, -269, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(57, -27, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(-34, 104, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(84, 139, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(192, -107, 30));
		AddSpawnPoint("f_remains_40.Id7", "f_remains_40", Rectangle(-445, -241, 30));

		// 'Rootcrystal_01' GenType 416 Spawn Points
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-1371, -1724, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-1726, -1856, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-2305, -1681, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-1998, -2228, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-1920, -2588, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-1825, -2918, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-1684, -3273, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-1894, -3649, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-1907, -4002, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-1625, -3657, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-814, -1246, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-1026, -911, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-1203, -1084, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-1489, -893, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-1735, -540, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-1413, -618, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-1006, -600, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-664, -375, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-285, -378, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-135, -38, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-11, -368, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(101, 121, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-82, -774, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(-52, -1092, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(33, -1532, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(562, -163, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(828, -374, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(799, -95, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(1056, 579, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(1050, 860, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(1338, 1076, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(1581, 623, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(1756, 591, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(1755, 1022, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(1730, 1365, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(2109, 1402, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(1952, 1896, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(1955, 2265, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(1942, 3171, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(1766, 2951, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(1983, 2781, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(2348, 3567, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(2578, 3621, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(2649, 3429, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(3043, 3219, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(2899, 3181, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(3200, 2914, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(3322, 2550, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(3370, 2692, 100));
		AddSpawnPoint("f_remains_40.Id8", "f_remains_40", Rectangle(3544, 2603, 100));

		// 'Big_Cockatries' GenType 432 Spawn Points
		AddSpawnPoint("f_remains_40.Id9", "f_remains_40", Rectangle(1533, 3160, 30));
		AddSpawnPoint("f_remains_40.Id9", "f_remains_40", Rectangle(1763, 3097, 30));
		AddSpawnPoint("f_remains_40.Id9", "f_remains_40", Rectangle(1822, 2862, 30));
		AddSpawnPoint("f_remains_40.Id9", "f_remains_40", Rectangle(1906, 2947, 30));
		AddSpawnPoint("f_remains_40.Id9", "f_remains_40", Rectangle(2013, 2994, 30));
		AddSpawnPoint("f_remains_40.Id9", "f_remains_40", Rectangle(1925, 2784, 30));
		AddSpawnPoint("f_remains_40.Id9", "f_remains_40", Rectangle(1903, 2674, 30));
		AddSpawnPoint("f_remains_40.Id9", "f_remains_40", Rectangle(1944, 2057, 30));
		AddSpawnPoint("f_remains_40.Id9", "f_remains_40", Rectangle(2264, 3733, 30));
		AddSpawnPoint("f_remains_40.Id9", "f_remains_40", Rectangle(2452, 3686, 30));
		AddSpawnPoint("f_remains_40.Id9", "f_remains_40", Rectangle(2368, 3517, 30));
		AddSpawnPoint("f_remains_40.Id9", "f_remains_40", Rectangle(2574, 3399, 30));
		AddSpawnPoint("f_remains_40.Id9", "f_remains_40", Rectangle(2746, 3504, 30));
		AddSpawnPoint("f_remains_40.Id9", "f_remains_40", Rectangle(2948, 3183, 30));
	}
}
