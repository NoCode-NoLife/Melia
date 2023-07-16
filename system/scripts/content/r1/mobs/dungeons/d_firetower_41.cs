//--- Melia Script -----------------------------------------------------------
// d_firetower_41
//
//--- Description -----------------------------------------------------------
// Sets up the d_firetower_41 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFiretower41MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_firetower_41", MonsterId.Fire_Dragon, Properties("MHP", 89552, "MINPATK", 1652, "MAXPATK", 1933, "MINMATK", 1652, "MAXMATK", 1933, "DEF", 838, "MDEF", 838));
		AddPropertyOverrides("d_firetower_41", MonsterId.Flight_Hope, Properties("MHP", 90404, "MINPATK", 1663, "MAXPATK", 1946, "MINMATK", 1663, "MAXMATK", 1946, "DEF", 866, "MDEF", 866));
		AddPropertyOverrides("d_firetower_41", MonsterId.Rubblem, Properties("MHP", 91311, "MINPATK", 1675, "MAXPATK", 1961, "MINMATK", 1675, "MAXMATK", 1961, "DEF", 895, "MDEF", 895));
		AddPropertyOverrides("d_firetower_41", MonsterId.Armory, Properties("MHP", 92270, "MINPATK", 1687, "MAXPATK", 1976, "MINMATK", 1687, "MAXMATK", 1976, "DEF", 927, "MDEF", 927));
		AddPropertyOverrides("d_firetower_41", MonsterId.Rudasjack, Properties("MHP", 93278, "MINPATK", 1700, "MAXPATK", 1992, "MINMATK", 1700, "MAXMATK", 1992, "DEF", 960, "MDEF", 960));

		// Monster Spawners --------------------------------

		AddSpawner("d_firetower_41.Id1", MonsterId.Fire_Dragon, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_41.Id2", MonsterId.Flight_Hope, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_41.Id3", MonsterId.Fire_Dragon, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_41.Id4", MonsterId.Flight_Hope, 6, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_41.Id5", MonsterId.Rubblem, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_41.Id6", MonsterId.Armory, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_41.Id7", MonsterId.Rubblem, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_41.Id8", MonsterId.Flight_Hope, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_41.Id9", MonsterId.Rootcrystal_01, 9, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_firetower_41.Id10", MonsterId.Rudasjack, 12, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// Fire_Dragon Spawn Points
		AddSpawnPoint( "d_firetower_41.Id1", "d_firetower_41", Spot(-1290.9723, -1862.3827, 9999));

		// Flight_Hope Spawn Points
		AddSpawnPoint( "d_firetower_41.Id2", "d_firetower_41", Spot(905.2752, -980.85516, 9999));

		// Fire_Dragon Spawn Points
		AddSpawnPoint( "d_firetower_41.Id3", "d_firetower_41", Spot(-1595.2817, -1527.8844, 25));
		AddSpawnPoint( "d_firetower_41.Id3", "d_firetower_41", Spot(1059.6914, -1002.4525, 25));
		AddSpawnPoint( "d_firetower_41.Id3", "d_firetower_41", Spot(-1965.0428, -1432.5525, 25));
		AddSpawnPoint( "d_firetower_41.Id3", "d_firetower_41", Spot(-1755.9384, -1412.7969, 25));
		AddSpawnPoint( "d_firetower_41.Id3", "d_firetower_41", Spot(-1538.9332, -1384.1055, 25));
		AddSpawnPoint( "d_firetower_41.Id3", "d_firetower_41", Spot(-1630.9734, -1268.5215, 25));
		AddSpawnPoint( "d_firetower_41.Id3", "d_firetower_41", Spot(-1650.5122, -1851.8206, 25));
		AddSpawnPoint( "d_firetower_41.Id3", "d_firetower_41", Spot(420.59332, -1131.9774, 25));
		AddSpawnPoint( "d_firetower_41.Id3", "d_firetower_41", Spot(532.87897, -1209.8788, 25));
		AddSpawnPoint( "d_firetower_41.Id3", "d_firetower_41", Spot(584.9759, -1038.1792, 25));
		AddSpawnPoint( "d_firetower_41.Id3", "d_firetower_41", Spot(693.2039, -974.8152, 25));
		AddSpawnPoint( "d_firetower_41.Id3", "d_firetower_41", Spot(430.76382, -940.3642, 25));
		AddSpawnPoint( "d_firetower_41.Id3", "d_firetower_41", Spot(1380.4, -1169.7961, 25));
		AddSpawnPoint( "d_firetower_41.Id3", "d_firetower_41", Spot(1449.3115, -866.6506, 25));
		AddSpawnPoint( "d_firetower_41.Id3", "d_firetower_41", Spot(1331.3098, -968.6447, 25));
		AddSpawnPoint( "d_firetower_41.Id3", "d_firetower_41", Spot(1467.5947, -1027.7948, 25));

		// Flight_Hope Spawn Points
		AddSpawnPoint( "d_firetower_41.Id4", "d_firetower_41", Spot(505.27875, -1357.3048, 20));
		AddSpawnPoint( "d_firetower_41.Id4", "d_firetower_41", Spot(1086.6288, -1024.44, 20));
		AddSpawnPoint( "d_firetower_41.Id4", "d_firetower_41", Spot(887.60925, -1018.8367, 20));
		AddSpawnPoint( "d_firetower_41.Id4", "d_firetower_41", Spot(378.40567, -1069.8031, 20));
		AddSpawnPoint( "d_firetower_41.Id4", "d_firetower_41", Spot(508.31396, -1176.1432, 20));
		AddSpawnPoint( "d_firetower_41.Id4", "d_firetower_41", Spot(660.08453, -1059.165, 20));
		AddSpawnPoint( "d_firetower_41.Id4", "d_firetower_41", Spot(427.88083, -893.4907, 20));
		AddSpawnPoint( "d_firetower_41.Id4", "d_firetower_41", Spot(605.1244, -867.0172, 20));
		AddSpawnPoint( "d_firetower_41.Id4", "d_firetower_41", Spot(1203.7632, -1063.7942, 20));
		AddSpawnPoint( "d_firetower_41.Id4", "d_firetower_41", Spot(1400.993, -1212.9633, 20));
		AddSpawnPoint( "d_firetower_41.Id4", "d_firetower_41", Spot(1569.8229, -1049.7406, 20));
		AddSpawnPoint( "d_firetower_41.Id4", "d_firetower_41", Spot(1420.7056, -837.40924, 20));
		AddSpawnPoint( "d_firetower_41.Id4", "d_firetower_41", Spot(1290.798, -894.76056, 20));
		AddSpawnPoint( "d_firetower_41.Id4", "d_firetower_41", Spot(1428.7903, -1075.3398, 20));

		// Rubblem Spawn Points
		AddSpawnPoint( "d_firetower_41.Id5", "d_firetower_41", Spot(-1967.1057, -1849.7668, 9999));

		// Armory Spawn Points
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(-621.4323, -1883.7267, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(-1710.5486, -1877.9375, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(-1195.3766, -1826.6595, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(-780.86597, -1844.0272, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(-620.65106, -1690.634, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(-506.90616, -1835.1304, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(-545.91187, -1976.454, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(1200.6326, -1892.1873, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(775.22546, -1845.9972, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(964.249, -1848.3663, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(1344.2993, -1865.0474, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(1684.9888, -1789.5095, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(1683.7206, -1915.9243, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(-8.096603, -1857.1602, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(1491.9652, -2375.8047, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(1983.5308, -2249.3157, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(2300.595, -2222.4495, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(2325.1914, -2425.7026, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(2512.4922, -2305.8743, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(2337.9155, -2122.0955, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(1321.255, -2271.6077, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(-2211.7092, -1949.9138, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(-2409.1594, -1845.9371, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(-2019.5408, -1849.2081, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(-754.74005, -1989.6204, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(-585.7188, -2114.121, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(-390.2935, -1965.2979, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(-410.22427, -1736.625, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(1658.5132, -2212.734, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(1858.9954, -2278.981, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(2145.087, -2277.878, 25));
		AddSpawnPoint( "d_firetower_41.Id6", "d_firetower_41", Spot(1446.3707, -2134.8804, 25));

		// Rubblem Spawn Points
		AddSpawnPoint( "d_firetower_41.Id7", "d_firetower_41", Spot(1498.838, -2409.6487, 25));
		AddSpawnPoint( "d_firetower_41.Id7", "d_firetower_41", Spot(1356.1011, -2396.4094, 25));
		AddSpawnPoint( "d_firetower_41.Id7", "d_firetower_41", Spot(1411.767, -2256.2488, 25));
		AddSpawnPoint( "d_firetower_41.Id7", "d_firetower_41", Spot(2383.7097, -2126.3398, 25));
		AddSpawnPoint( "d_firetower_41.Id7", "d_firetower_41", Spot(1531.3184, -2175.5312, 25));
		AddSpawnPoint( "d_firetower_41.Id7", "d_firetower_41", Spot(2438.8862, -2407.3987, 25));
		AddSpawnPoint( "d_firetower_41.Id7", "d_firetower_41", Spot(1600.7472, -2266.5225, 25));
		AddSpawnPoint( "d_firetower_41.Id7", "d_firetower_41", Spot(2185.712, -2181.304, 25));
		AddSpawnPoint( "d_firetower_41.Id7", "d_firetower_41", Spot(1456.9188, -1950.8787, 25));
		AddSpawnPoint( "d_firetower_41.Id7", "d_firetower_41", Spot(2265.6133, -2442.2234, 25));
		AddSpawnPoint( "d_firetower_41.Id7", "d_firetower_41", Spot(2212.3425, -2313.1172, 25));

		// Flight_Hope Spawn Points
		AddSpawnPoint( "d_firetower_41.Id8", "d_firetower_41", Spot(-1451.4221, -1445.1167, 25));
		AddSpawnPoint( "d_firetower_41.Id8", "d_firetower_41", Spot(-1488.4335, -1251.8748, 25));
		AddSpawnPoint( "d_firetower_41.Id8", "d_firetower_41", Spot(-1907.9414, -1405.8097, 25));
		AddSpawnPoint( "d_firetower_41.Id8", "d_firetower_41", Spot(-1668.8665, -1252.4711, 25));
		AddSpawnPoint( "d_firetower_41.Id8", "d_firetower_41", Spot(-1757.7589, -1554.3734, 25));
		AddSpawnPoint( "d_firetower_41.Id8", "d_firetower_41", Spot(-1795.9513, -1806.5643, 25));
		AddSpawnPoint( "d_firetower_41.Id8", "d_firetower_41", Spot(-1542.6754, -1607.473, 25));
		AddSpawnPoint( "d_firetower_41.Id8", "d_firetower_41", Spot(-1600.7621, -1909.2013, 25));
		AddSpawnPoint( "d_firetower_41.Id8", "d_firetower_41", Spot(-1281.9269, -1882.4108, 25));
		AddSpawnPoint( "d_firetower_41.Id8", "d_firetower_41", Spot(-1446.7373, -1800.067, 25));
		AddSpawnPoint( "d_firetower_41.Id8", "d_firetower_41", Spot(-1933.0242, -1872.7329, 25));
		AddSpawnPoint( "d_firetower_41.Id8", "d_firetower_41", Spot(-2191.8843, -1860.8625, 25));
		AddSpawnPoint( "d_firetower_41.Id8", "d_firetower_41", Spot(-2175.8218, -2001.1401, 25));
		AddSpawnPoint( "d_firetower_41.Id8", "d_firetower_41", Spot(-2520.1235, -1851.864, 25));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "d_firetower_41.Id9", "d_firetower_41", Spot(-2496.1519, -1827.8285, 100));
		AddSpawnPoint( "d_firetower_41.Id9", "d_firetower_41", Spot(-1634.4401, -1610.4192, 100));
		AddSpawnPoint( "d_firetower_41.Id9", "d_firetower_41", Spot(-1.7819061, -1849.0018, 100));
		AddSpawnPoint( "d_firetower_41.Id9", "d_firetower_41", Spot(707.8037, -1003.1862, 100));
		AddSpawnPoint( "d_firetower_41.Id9", "d_firetower_41", Spot(1409.3949, -1197.311, 100));
		AddSpawnPoint( "d_firetower_41.Id9", "d_firetower_41", Spot(1418.5626, -2253.582, 100));
		AddSpawnPoint( "d_firetower_41.Id9", "d_firetower_41", Spot(1460.2198, -1853.5906, 100));
		AddSpawnPoint( "d_firetower_41.Id9", "d_firetower_41", Spot(2074.4817, -1848.7046, 100));
		AddSpawnPoint( "d_firetower_41.Id9", "d_firetower_41", Spot(2163.447, -2286.3477, 100));

		// Rudasjack Spawn Points
		AddSpawnPoint( "d_firetower_41.Id10", "d_firetower_41", Spot(-516.7697, -1860.459, 9999));

	}
}
