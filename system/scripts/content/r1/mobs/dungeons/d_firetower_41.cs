//--- Melia Script -----------------------------------------------------------
// Mage Tower 1F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_firetower_41'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFiretower41MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_firetower_41", MonsterId.Fire_Dragon, Properties("MHP", 89552, "MINPATK", 1652, "MAXPATK", 1933, "MINMATK", 1652, "MAXMATK", 1933, "DEF", 838, "MDEF", 838));
		AddPropertyOverrides("d_firetower_41", MonsterId.Flight_Hope, Properties("MHP", 90404, "MINPATK", 1663, "MAXPATK", 1946, "MINMATK", 1663, "MAXMATK", 1946, "DEF", 866, "MDEF", 866));
		AddPropertyOverrides("d_firetower_41", MonsterId.Rubblem, Properties("MHP", 91311, "MINPATK", 1675, "MAXPATK", 1961, "MINMATK", 1675, "MAXMATK", 1961, "DEF", 895, "MDEF", 895));
		AddPropertyOverrides("d_firetower_41", MonsterId.Armory, Properties("MHP", 92270, "MINPATK", 1687, "MAXPATK", 1976, "MINMATK", 1687, "MAXMATK", 1976, "DEF", 927, "MDEF", 927));
		AddPropertyOverrides("d_firetower_41", MonsterId.Rudasjack, Properties("MHP", 93278, "MINPATK", 1700, "MAXPATK", 1992, "MINMATK", 1700, "MAXMATK", 1992, "DEF", 960, "MDEF", 960));
		AddPropertyOverrides("d_firetower_41", MonsterId.Boss_Salamander_Q1, Properties("MHP", 469782, "MINPATK", 3908, "MAXPATK", 4579, "MINMATK", 3908, "MAXMATK", 4579, "DEF", 2266, "MDEF", 2266));

		// Monster Spawners ---------------------------------

		AddSpawner("d_firetower_41.Id1", MonsterId.Fire_Dragon, min: 8, max: 10, tendency: TendencyType.Aggressive);
		AddSpawner("d_firetower_41.Id2", MonsterId.Flight_Hope, min: 8, max: 10, tendency: TendencyType.Aggressive);
		AddSpawner("d_firetower_41.Id3", MonsterId.Rootcrystal_01, min: 7, max: 9, respawn: TimeSpan.FromMilliseconds(30000), tendency: TendencyType.Peaceful);
		AddSpawner("d_firetower_41.Id4", MonsterId.Fire_Dragon, min: 8, max: 10, tendency: TendencyType.Aggressive);
		AddSpawner("d_firetower_41.Id5", MonsterId.Flight_Hope, min: 5, max: 6, tendency: TendencyType.Aggressive);
		AddSpawner("d_firetower_41.Id6", MonsterId.Rubblem, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("d_firetower_41.Id7", MonsterId.Armory, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_firetower_41.Id8", MonsterId.Rubblem, min: 8, max: 10, tendency: TendencyType.Aggressive);
		AddSpawner("d_firetower_41.Id9", MonsterId.Flight_Hope, min: 8, max: 10, tendency: TendencyType.Aggressive);
		AddSpawner("d_firetower_41.Id10", MonsterId.Rudasjack, min: 9, max: 12, tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Fire_Dragon' GenType 1 Spawn Points
		AddSpawnPoint("d_firetower_41.Id1", "d_firetower_41", Rectangle(-1290, -1862, 9999));

		// 'Flight_Hope' GenType 2 Spawn Points
		AddSpawnPoint("d_firetower_41.Id2", "d_firetower_41", Rectangle(905, -980, 9999));

		// 'Rootcrystal_01' GenType 3 Spawn Points
		AddSpawnPoint("d_firetower_41.Id3", "d_firetower_41", Rectangle(-2496, -1827, 100));
		AddSpawnPoint("d_firetower_41.Id3", "d_firetower_41", Rectangle(-1634, -1610, 100));
		AddSpawnPoint("d_firetower_41.Id3", "d_firetower_41", Rectangle(-1, -1849, 100));
		AddSpawnPoint("d_firetower_41.Id3", "d_firetower_41", Rectangle(707, -1003, 100));
		AddSpawnPoint("d_firetower_41.Id3", "d_firetower_41", Rectangle(1409, -1197, 100));
		AddSpawnPoint("d_firetower_41.Id3", "d_firetower_41", Rectangle(1418, -2253, 100));
		AddSpawnPoint("d_firetower_41.Id3", "d_firetower_41", Rectangle(1460, -1853, 100));
		AddSpawnPoint("d_firetower_41.Id3", "d_firetower_41", Rectangle(2074, -1848, 100));
		AddSpawnPoint("d_firetower_41.Id3", "d_firetower_41", Rectangle(2163, -2286, 100));

		// 'Fire_Dragon' GenType 111 Spawn Points
		AddSpawnPoint("d_firetower_41.Id4", "d_firetower_41", Rectangle(-1595, -1527, 25));
		AddSpawnPoint("d_firetower_41.Id4", "d_firetower_41", Rectangle(1059, -1002, 25));
		AddSpawnPoint("d_firetower_41.Id4", "d_firetower_41", Rectangle(-1965, -1432, 25));
		AddSpawnPoint("d_firetower_41.Id4", "d_firetower_41", Rectangle(-1755, -1412, 25));
		AddSpawnPoint("d_firetower_41.Id4", "d_firetower_41", Rectangle(-1538, -1384, 25));
		AddSpawnPoint("d_firetower_41.Id4", "d_firetower_41", Rectangle(-1630, -1268, 25));
		AddSpawnPoint("d_firetower_41.Id4", "d_firetower_41", Rectangle(-1650, -1851, 25));
		AddSpawnPoint("d_firetower_41.Id4", "d_firetower_41", Rectangle(420, -1131, 25));
		AddSpawnPoint("d_firetower_41.Id4", "d_firetower_41", Rectangle(532, -1209, 25));
		AddSpawnPoint("d_firetower_41.Id4", "d_firetower_41", Rectangle(584, -1038, 25));
		AddSpawnPoint("d_firetower_41.Id4", "d_firetower_41", Rectangle(693, -974, 25));
		AddSpawnPoint("d_firetower_41.Id4", "d_firetower_41", Rectangle(430, -940, 25));
		AddSpawnPoint("d_firetower_41.Id4", "d_firetower_41", Rectangle(1380, -1169, 25));
		AddSpawnPoint("d_firetower_41.Id4", "d_firetower_41", Rectangle(1449, -866, 25));
		AddSpawnPoint("d_firetower_41.Id4", "d_firetower_41", Rectangle(1331, -968, 25));
		AddSpawnPoint("d_firetower_41.Id4", "d_firetower_41", Rectangle(1467, -1027, 25));

		// 'Flight_Hope' GenType 114 Spawn Points
		AddSpawnPoint("d_firetower_41.Id5", "d_firetower_41", Rectangle(505, -1357, 20));
		AddSpawnPoint("d_firetower_41.Id5", "d_firetower_41", Rectangle(1086, -1024, 20));
		AddSpawnPoint("d_firetower_41.Id5", "d_firetower_41", Rectangle(887, -1018, 20));
		AddSpawnPoint("d_firetower_41.Id5", "d_firetower_41", Rectangle(378, -1069, 20));
		AddSpawnPoint("d_firetower_41.Id5", "d_firetower_41", Rectangle(508, -1176, 20));
		AddSpawnPoint("d_firetower_41.Id5", "d_firetower_41", Rectangle(660, -1059, 20));
		AddSpawnPoint("d_firetower_41.Id5", "d_firetower_41", Rectangle(427, -893, 20));
		AddSpawnPoint("d_firetower_41.Id5", "d_firetower_41", Rectangle(605, -867, 20));
		AddSpawnPoint("d_firetower_41.Id5", "d_firetower_41", Rectangle(1203, -1063, 20));
		AddSpawnPoint("d_firetower_41.Id5", "d_firetower_41", Rectangle(1400, -1212, 20));
		AddSpawnPoint("d_firetower_41.Id5", "d_firetower_41", Rectangle(1569, -1049, 20));
		AddSpawnPoint("d_firetower_41.Id5", "d_firetower_41", Rectangle(1420, -837, 20));
		AddSpawnPoint("d_firetower_41.Id5", "d_firetower_41", Rectangle(1290, -894, 20));
		AddSpawnPoint("d_firetower_41.Id5", "d_firetower_41", Rectangle(1428, -1075, 20));

		// 'Rubblem' GenType 117 Spawn Points
		AddSpawnPoint("d_firetower_41.Id6", "d_firetower_41", Rectangle(-1967, -1849, 9999));

		// 'Armory' GenType 118 Spawn Points
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(-621, -1883, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(-1710, -1877, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(-1195, -1826, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(-780, -1844, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(-620, -1690, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(-506, -1835, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(-545, -1976, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(1200, -1892, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(775, -1845, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(964, -1848, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(1344, -1865, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(1684, -1789, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(1683, -1915, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(-8, -1857, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(1491, -2375, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(1983, -2249, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(2300, -2222, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(2325, -2425, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(2512, -2305, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(2337, -2122, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(1321, -2271, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(-2211, -1949, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(-2409, -1845, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(-2019, -1849, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(-754, -1989, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(-585, -2114, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(-390, -1965, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(-410, -1736, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(1658, -2212, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(1858, -2278, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(2145, -2277, 25));
		AddSpawnPoint("d_firetower_41.Id7", "d_firetower_41", Rectangle(1446, -2134, 25));

		// 'Rubblem' GenType 119 Spawn Points
		AddSpawnPoint("d_firetower_41.Id8", "d_firetower_41", Rectangle(1498, -2409, 25));
		AddSpawnPoint("d_firetower_41.Id8", "d_firetower_41", Rectangle(1356, -2396, 25));
		AddSpawnPoint("d_firetower_41.Id8", "d_firetower_41", Rectangle(1411, -2256, 25));
		AddSpawnPoint("d_firetower_41.Id8", "d_firetower_41", Rectangle(2383, -2126, 25));
		AddSpawnPoint("d_firetower_41.Id8", "d_firetower_41", Rectangle(1531, -2175, 25));
		AddSpawnPoint("d_firetower_41.Id8", "d_firetower_41", Rectangle(2438, -2407, 25));
		AddSpawnPoint("d_firetower_41.Id8", "d_firetower_41", Rectangle(1600, -2266, 25));
		AddSpawnPoint("d_firetower_41.Id8", "d_firetower_41", Rectangle(2185, -2181, 25));
		AddSpawnPoint("d_firetower_41.Id8", "d_firetower_41", Rectangle(1456, -1950, 25));
		AddSpawnPoint("d_firetower_41.Id8", "d_firetower_41", Rectangle(2265, -2442, 25));
		AddSpawnPoint("d_firetower_41.Id8", "d_firetower_41", Rectangle(2212, -2313, 25));

		// 'Flight_Hope' GenType 121 Spawn Points
		AddSpawnPoint("d_firetower_41.Id9", "d_firetower_41", Rectangle(-1451, -1445, 25));
		AddSpawnPoint("d_firetower_41.Id9", "d_firetower_41", Rectangle(-1488, -1251, 25));
		AddSpawnPoint("d_firetower_41.Id9", "d_firetower_41", Rectangle(-1907, -1405, 25));
		AddSpawnPoint("d_firetower_41.Id9", "d_firetower_41", Rectangle(-1668, -1252, 25));
		AddSpawnPoint("d_firetower_41.Id9", "d_firetower_41", Rectangle(-1757, -1554, 25));
		AddSpawnPoint("d_firetower_41.Id9", "d_firetower_41", Rectangle(-1795, -1806, 25));
		AddSpawnPoint("d_firetower_41.Id9", "d_firetower_41", Rectangle(-1542, -1607, 25));
		AddSpawnPoint("d_firetower_41.Id9", "d_firetower_41", Rectangle(-1600, -1909, 25));
		AddSpawnPoint("d_firetower_41.Id9", "d_firetower_41", Rectangle(-1281, -1882, 25));
		AddSpawnPoint("d_firetower_41.Id9", "d_firetower_41", Rectangle(-1446, -1800, 25));
		AddSpawnPoint("d_firetower_41.Id9", "d_firetower_41", Rectangle(-1933, -1872, 25));
		AddSpawnPoint("d_firetower_41.Id9", "d_firetower_41", Rectangle(-2191, -1860, 25));
		AddSpawnPoint("d_firetower_41.Id9", "d_firetower_41", Rectangle(-2175, -2001, 25));
		AddSpawnPoint("d_firetower_41.Id9", "d_firetower_41", Rectangle(-2520, -1851, 25));

		// 'Rudasjack' GenType 124 Spawn Points
		AddSpawnPoint("d_firetower_41.Id10", "d_firetower_41", Rectangle(-516, -1860, 9999));
	}
}
