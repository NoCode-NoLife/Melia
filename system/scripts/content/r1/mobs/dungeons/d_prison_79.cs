//--- Melia Script -----------------------------------------------------------
// Storage Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_prison_79'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DPrison79MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_prison_79", MonsterId.Nuo_Purple, Properties("MHP", 416997, "MINPATK", 5863, "MAXPATK", 7108, "MINMATK", 5863, "MAXMATK", 7108, "DEF", 50173, "MDEF", 50173));
		AddPropertyOverrides("d_prison_79", MonsterId.Socket_Bow_Red, Properties("MHP", 419582, "MINPATK", 5896, "MAXPATK", 7149, "MINMATK", 5896, "MAXMATK", 7149, "DEF", 50997, "MDEF", 50997));
		AddPropertyOverrides("d_prison_79", MonsterId.TerraNymph_Mage_Blue, Properties("MHP", 422248, "MINPATK", 5931, "MAXPATK", 7191, "MINMATK", 5931, "MAXMATK", 7191, "DEF", 51848, "MDEF", 51848));

		// Monster Spawners ---------------------------------

		AddSpawner("d_prison_79.Id1", MonsterId.Nuo_Purple, min: 38, max: 50, tendency: TendencyType.Aggressive);
		AddSpawner("d_prison_79.Id2", MonsterId.Socket_Bow_Red, min: 19, max: 25, tendency: TendencyType.Aggressive);
		AddSpawner("d_prison_79.Id3", MonsterId.TerraNymph_Mage_Blue, min: 19, max: 25, tendency: TendencyType.Aggressive);
		AddSpawner("d_prison_79.Id4", MonsterId.Rootcrystal_05, min: 15, max: 20, respawn: TimeSpan.FromMilliseconds(60000), tendency: TendencyType.Peaceful);
		AddSpawner("d_prison_79.Id5", MonsterId.Socket_Bow_Red, min: 34, max: 45, tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Nuo_Purple' GenType 1 Spawn Points
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(30, 982, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(159, -1046, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-181, -246, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-123, 59, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-431, -1065, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-215, -166, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-207, 164, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(73, -639, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-92, -230, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-567, -1067, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-944, -1040, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(437, -1026, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(841, -1054, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(1063, -885, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(805, -931, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(975, -1450, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(1021, -1996, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(1434, -1936, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(1791, -2071, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(1863, -1715, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(2063, -1893, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(2325, -1801, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(2252, -1688, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(2096, -2104, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(2456, -1730, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(2068, -1680, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-671, -1245, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-762, -944, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-801, -1541, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-966, -1949, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-1532, -2006, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-1694, -2091, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-1737, -2282, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-1993, -2251, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-2103, -1931, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-1888, -1960, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-2133, -1694, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-1853, -1633, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-1696, -1541, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(25, -755, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(63, 607, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(588, -24, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(810, -20, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(706, -24, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(915, -20, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-1698, 2339, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-365, 992, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-1869, 2350, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-1913, 2244, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-1467, 2048, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-1437, 1863, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-935, 1962, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-747, 1875, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-723, 1525, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-716, 1244, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-132, -87, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(125, 1062, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(79, 754, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(457, 1044, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(736, 1086, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(880, 1470, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(885, 1534, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(1672, 2257, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(1759, 2175, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(1449, 2153, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(1701, 2119, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(1693, 2407, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(1842, 2513, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(2067, 2478, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(1998, 2315, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(2188, 2093, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(2390, 2185, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(2378, 2458, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-117, 168, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-204, 7, 25));
		AddSpawnPoint("d_prison_79.Id1", "d_prison_79", Rectangle(-118, -1040, 25));

		// 'Socket_Bow_Red' GenType 2 Spawn Points
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(-1850, -2188, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(-1952, -1671, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(-1679, -1618, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(-1852, -1891, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(-1300, -1951, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(-923, -1904, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(-876, -1564, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(-849, -1197, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(-1028, -1081, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(-274, -282, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(-1024, -967, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(858, -1090, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(944, -897, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(1074, -1186, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(927, -1388, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(1035, -1596, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(1110, -1936, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(1476, -1983, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(1903, -2054, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(1917, -1812, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(2201, -1679, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(-157, 153, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(-202, 224, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(-189, 89, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(-231, -159, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(1824, -2043, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(1787, -1842, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(754, -1055, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(-1662, -1994, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(-1672, -2254, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(-1957, -2301, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(-2134, -1853, 25));
		AddSpawnPoint("d_prison_79.Id2", "d_prison_79", Rectangle(-1990, -2012, 25));

		// 'TerraNymph_Mage_Blue' GenType 3 Spawn Points
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(-276, -14, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(-1228, 1957, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(-264, 261, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(-1494, 1782, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(-1326, 1946, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(-1502, 2346, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(-89, -305, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(-1512, 1952, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(-1564, 2254, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(-1770, 2235, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(-1126, 1957, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(-862, 1937, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(-719, 1975, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(-695, 1584, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(-682, 1339, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(-677, 1133, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(-217, -272, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(899, 1185, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(932, 1407, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(1672, 2182, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(952, 1518, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(871, 1596, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(1477, 2111, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(1818, 2129, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(1664, 2044, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(1389, 2046, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(1421, 2225, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(1758, 2036, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(1713, 2348, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(1799, 2228, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(1819, 2397, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(2025, 2527, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(2166, 2484, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(2005, 2323, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(2087, 2039, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(2321, 2058, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(2363, 2280, 25));
		AddSpawnPoint("d_prison_79.Id3", "d_prison_79", Rectangle(2344, 2469, 25));

		// 'Rootcrystal_05' GenType 6 Spawn Points
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(2102, 2322, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(2268, 2029, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(1707, 2080, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(1349, 2129, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(845, 1422, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(748, 1007, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(50, 1014, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(210, 124, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(-66, 92, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(-105, -212, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(1393, -148, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(69, -743, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(1004, -1006, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(986, -1219, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(1720, -1973, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(2287, -1682, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(2227, -2139, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(-763, -1163, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(-921, -920, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(-821, -1946, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(-1668, -2208, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(-1890, -2248, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(-1959, -1951, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(-2035, -1627, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(-1745, -1649, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(-637, 1035, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(-670, 1914, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(-1271, 1943, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(-1491, 1671, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(-1873, 1651, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(-1946, 1858, 100));
		AddSpawnPoint("d_prison_79.Id4", "d_prison_79", Rectangle(-1879, 2294, 100));

		// 'Socket_Bow_Red' GenType 11 Spawn Points
		AddSpawnPoint("d_prison_79.Id5", "d_prison_79", Rectangle(45, 938, 9999));
	}
}
