//--- Melia Script -----------------------------------------------------------
// Residence of the Fallen Legwyn Family Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_startower_60_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DStartower601MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_startower_60_1.Id1", MonsterId.FD_Raffly_Blue, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("d_startower_60_1.Id2", MonsterId.FD_NightMaiden, min: 27, max: 35, tendency: TendencyType.Aggressive);
		AddSpawner("d_startower_60_1.Id3", MonsterId.FD_TerraNymph, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_startower_60_1.Id4", MonsterId.Rootcrystal_01, min: 11, max: 14, respawn: TimeSpan.FromMilliseconds(5000), tendency: TendencyType.Peaceful);
		AddSpawner("d_startower_60_1.Id5", MonsterId.FD_TerraNymph, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("d_startower_60_1.Id6", MonsterId.FD_Raffly_Blue, min: 30, max: 40, tendency: TendencyType.Aggressive);
		AddSpawner("d_startower_60_1.Id7", MonsterId.FD_TerraNymph_Bow, min: 19, max: 25, tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'FD_Raffly_Blue' GenType 1 Spawn Points
		AddSpawnPoint("d_startower_60_1.Id1", "d_startower_60_1", Rectangle(1533, -333, 200));
		AddSpawnPoint("d_startower_60_1.Id1", "d_startower_60_1", Rectangle(2024, -330, 200));
		AddSpawnPoint("d_startower_60_1.Id1", "d_startower_60_1", Rectangle(2015, 344, 200));
		AddSpawnPoint("d_startower_60_1.Id1", "d_startower_60_1", Rectangle(1495, 363, 200));
		AddSpawnPoint("d_startower_60_1.Id1", "d_startower_60_1", Rectangle(1462, -1215, 200));

		// 'FD_NightMaiden' GenType 2 Spawn Points
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1873, -1215, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1830, 634, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1887, -374, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-959, -281, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-2010, 636, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1692, 823, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1871, 406, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1941, 853, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-2058, -1066, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-2078, -1411, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-2026, -1254, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1840, -1419, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1722, -1055, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1673, -1294, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1158, -297, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1165, -26, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-657, -10, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-697, -471, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1240, -532, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1865, -14, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1863, -737, 70));

		// 'FD_TerraNymph' GenType 3 Spawn Points
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(-227, -1289, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(144, -327, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(1101, -1249, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(1625, -1456, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(1445, -1013, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(1701, -1111, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(509, -1271, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(157, -971, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(196, -1662, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(-72, -313, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(404, -292, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(141, -514, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(168, -111, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(137, -1150, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(-30, -1460, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(379, -1486, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(381, -1014, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(155, -1329, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(1335, -1242, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(1363, -1474, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(1571, -1261, 70));

		// 'Rootcrystal_01' GenType 4 Spawn Points
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(-1140, -1022, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(-2103, -1381, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(-1554, 426, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(234, 1131, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(22, 530, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(361, -191, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(-50, -1575, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(500, -1391, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(1636, -1402, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(1401, -129, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(2200, 156, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(1478, 964, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(1983, -2442, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(-660, -37, 100));

		// 'FD_TerraNymph' GenType 16 Spawn Points
		AddSpawnPoint("d_startower_60_1.Id5", "d_startower_60_1", Rectangle(1399, -2249, 200));
		AddSpawnPoint("d_startower_60_1.Id5", "d_startower_60_1", Rectangle(2045, -2219, 200));
		AddSpawnPoint("d_startower_60_1.Id5", "d_startower_60_1", Rectangle(1700, -2223, 200));

		// 'FD_Raffly_Blue' GenType 17 Spawn Points
		AddSpawnPoint("d_startower_60_1.Id6", "d_startower_60_1", Rectangle(243, -1278, 9999));

		// 'FD_TerraNymph_Bow' GenType 25 Spawn Points
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1122, -1198, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1852, 564, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1968, 448, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1846, 875, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-775, -1218, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-940, -948, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-893, -1464, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-2104, -1216, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1929, -1451, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1719, -1114, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1957, -1051, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1771, -1365, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1041, -377, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-736, -97, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1077, -198, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-800, -491, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1142, -1421, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-715, -1042, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1184, -528, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1238, 622, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1048, 666, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-964, 343, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-2041, 756, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1885, -24, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1903, -366, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1868, -762, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(2066, -1570, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(2097, -1254, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(2039, -882, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(1452, 271, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(2027, 411, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(1879, 271, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(1402, 451, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(1704, -283, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(1638, -479, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(1929, -244, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(1902, -484, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(1685, -2317, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(1777, -2111, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(1848, -2325, 40));
	}
}
