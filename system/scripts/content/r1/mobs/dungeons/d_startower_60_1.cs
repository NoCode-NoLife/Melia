//--- Melia Script -----------------------------------------------------------
// d_startower_60_1
//
//--- Description -----------------------------------------------------------
// Sets up the d_startower_60_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DStartower601MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("d_startower_60_1.Id1", MonsterId.FD_Raffly_Blue, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_60_1.Id2", MonsterId.FD_NightMaiden, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_60_1.Id3", MonsterId.FD_TerraNymph, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_60_1.Id4", MonsterId.Rootcrystal_01, 14, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("d_startower_60_1.Id5", MonsterId.FD_TerraNymph, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_60_1.Id6", MonsterId.FD_Raffly_Blue, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_60_1.Id7", MonsterId.FD_TerraNymph_Bow, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// FD_Raffly_Blue Spawn Points
		AddSpawnPoint( "d_startower_60_1.Id1", "d_startower_60_1", Spot(1533.5519, -333.35114, 200));
		AddSpawnPoint( "d_startower_60_1.Id1", "d_startower_60_1", Spot(2024.6632, -330.5523, 200));
		AddSpawnPoint( "d_startower_60_1.Id1", "d_startower_60_1", Spot(2015.9701, 344.34982, 200));
		AddSpawnPoint( "d_startower_60_1.Id1", "d_startower_60_1", Spot(1495.5914, 363.54562, 200));
		AddSpawnPoint( "d_startower_60_1.Id1", "d_startower_60_1", Spot(1462.6082, -1215.6637, 200));

		// FD_NightMaiden Spawn Points
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-1873.443, -1215.838, 70));
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-1830.1228, 634.776, 70));
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-1887.6718, -374.0196, 70));
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-959.07605, -281.5133, 70));
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-2010.5924, 636.63916, 70));
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-1692.1315, 823.5914, 70));
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-1871.0228, 406.94235, 70));
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-1941.3481, 853.6821, 70));
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-2058.347, -1066.6343, 70));
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-2078.9385, -1411.2488, 70));
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-2026.4886, -1254.5803, 70));
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-1840.8907, -1419.9338, 70));
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-1722.3204, -1055.9675, 70));
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-1673.4518, -1294.1387, 70));
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-1158.3276, -297.9623, 70));
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-1165.8145, -26.106133, 70));
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-657.8818, -10.379688, 70));
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-697.625, -471.6647, 70));
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-1240.8579, -532.5846, 70));
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-1865.0974, -14.496063, 70));
		AddSpawnPoint( "d_startower_60_1.Id2", "d_startower_60_1", Spot(-1863.132, -737.67975, 70));

		// FD_TerraNymph Spawn Points
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(-227.87978, -1289.0072, 70));
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(144.10188, -327.47403, 70));
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(1101.3422, -1249.525, 70));
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(1625.4054, -1456.2968, 70));
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(1445.6854, -1013.7725, 70));
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(1701.2771, -1111.9285, 70));
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(509.94037, -1271.5468, 70));
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(157.73293, -971.5396, 70));
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(196.44951, -1662.3966, 70));
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(-72.61998, -313.6423, 70));
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(404.19257, -292.5415, 70));
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(141.90054, -514.2021, 70));
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(168.30426, -111.60319, 70));
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(137.85516, -1150.1616, 70));
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(-30.4189, -1460.5146, 70));
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(379.66556, -1486.6122, 70));
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(381.52545, -1014.0502, 70));
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(155.38431, -1329.2645, 70));
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(1335.861, -1242.4921, 70));
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(1363.8477, -1474.7991, 70));
		AddSpawnPoint( "d_startower_60_1.Id3", "d_startower_60_1", Spot(1571.3337, -1261.7695, 70));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "d_startower_60_1.Id4", "d_startower_60_1", Spot(-1140.7477, -1022.9521, 100));
		AddSpawnPoint( "d_startower_60_1.Id4", "d_startower_60_1", Spot(-2103.9224, -1381.9102, 100));
		AddSpawnPoint( "d_startower_60_1.Id4", "d_startower_60_1", Spot(-1554.4441, 426.94974, 100));
		AddSpawnPoint( "d_startower_60_1.Id4", "d_startower_60_1", Spot(234.91176, 1131.1993, 100));
		AddSpawnPoint( "d_startower_60_1.Id4", "d_startower_60_1", Spot(22.792831, 530.7649, 100));
		AddSpawnPoint( "d_startower_60_1.Id4", "d_startower_60_1", Spot(361.87817, -191.39825, 100));
		AddSpawnPoint( "d_startower_60_1.Id4", "d_startower_60_1", Spot(-50.9329, -1575.6084, 100));
		AddSpawnPoint( "d_startower_60_1.Id4", "d_startower_60_1", Spot(500.09125, -1391.3099, 100));
		AddSpawnPoint( "d_startower_60_1.Id4", "d_startower_60_1", Spot(1636.7604, -1402.7097, 100));
		AddSpawnPoint( "d_startower_60_1.Id4", "d_startower_60_1", Spot(1401.9877, -129.72783, 100));
		AddSpawnPoint( "d_startower_60_1.Id4", "d_startower_60_1", Spot(2200.3997, 156.77704, 100));
		AddSpawnPoint( "d_startower_60_1.Id4", "d_startower_60_1", Spot(1478.6752, 964.8784, 100));
		AddSpawnPoint( "d_startower_60_1.Id4", "d_startower_60_1", Spot(1983.2263, -2442.0369, 100));
		AddSpawnPoint( "d_startower_60_1.Id4", "d_startower_60_1", Spot(-660.18634, -37.330734, 100));

		// FD_TerraNymph Spawn Points
		AddSpawnPoint( "d_startower_60_1.Id5", "d_startower_60_1", Spot(1399.8418, -2249.2693, 200));
		AddSpawnPoint( "d_startower_60_1.Id5", "d_startower_60_1", Spot(2045.2601, -2219.105, 200));
		AddSpawnPoint( "d_startower_60_1.Id5", "d_startower_60_1", Spot(1700.9769, -2223.98, 200));

		// FD_Raffly_Blue Spawn Points
		AddSpawnPoint( "d_startower_60_1.Id6", "d_startower_60_1", Spot(243.01598, -1278.825, 9999));

		// FD_TerraNymph_Bow Spawn Points
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-1122.8171, -1198.9102, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-1852.11, 564.36176, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-1968.3339, 448.9758, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-1846.4955, 875.6804, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-775.1229, -1218.1764, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-940.49023, -948.2371, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-893.2386, -1464.6725, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-2104.1384, -1216.4034, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-1929.2642, -1451.4922, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-1719.5414, -1114.9731, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-1957.3413, -1051.0288, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-1771.1073, -1365.3185, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-1041.8894, -377.83075, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-736.4074, -97.540085, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-1077.088, -198.39856, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-800.9783, -491.7996, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-1142.5206, -1421.5474, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-715.7404, -1042.7023, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-1184.4193, -528.54333, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-1238.2147, 622.5802, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-1048.5955, 666.6073, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-964.14606, 343.97934, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-2041.3049, 756.6155, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-1885.7238, -24.059586, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-1903.696, -366.94482, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(-1868.2933, -762.515, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(2066.4727, -1570.472, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(2097.0984, -1254.9363, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(2039.1995, -882.9327, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(1452.3368, 271.39893, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(2027.3647, 411.36844, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(1879.6228, 271.72116, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(1402.1338, 451.20746, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(1704.444, -283.1819, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(1638.9419, -479.17142, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(1929.9739, -244.68086, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(1902.261, -484.07773, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(1685.3516, -2317.0852, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(1777.0037, -2111.466, 40));
		AddSpawnPoint( "d_startower_60_1.Id7", "d_startower_60_1", Spot(1848.677, -2325.6606, 40));

	}
}
