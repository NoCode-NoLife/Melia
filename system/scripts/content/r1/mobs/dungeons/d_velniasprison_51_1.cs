//--- Melia Script -----------------------------------------------------------
// Demon Prison District 1 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_velniasprison_51_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DVelniasprison511MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_velniasprison_51_1", MonsterId.Yognome_Yellow, Properties("MHP", 183322, "MINPATK", 2859, "MAXPATK", 3415, "MINMATK", 2859, "MAXMATK", 3415, "DEF", 5813, "MDEF", 5813));
		AddPropertyOverrides("d_velniasprison_51_1", MonsterId.Gazing_Golem_Yellow, Properties("MHP", 184546, "MINPATK", 2874, "MAXPATK", 3434, "MINMATK", 2874, "MAXMATK", 3434, "DEF", 5925, "MDEF", 5925));
		AddPropertyOverrides("d_velniasprison_51_1", MonsterId.Moya_Yellow, Properties("MHP", 185804, "MINPATK", 2891, "MAXPATK", 3454, "MINMATK", 2891, "MAXMATK", 3454, "DEF", 6039, "MDEF", 6039));
		AddPropertyOverrides("d_velniasprison_51_1", MonsterId.Egnome_Yellow, Properties("MHP", 187095, "MINPATK", 2907, "MAXPATK", 3474, "MINMATK", 2907, "MAXMATK", 3474, "DEF", 6157, "MDEF", 6157));
		AddPropertyOverrides("d_velniasprison_51_1", MonsterId.Boss_Blud, Properties("MHP", 960939, "MINPATK", 7018, "MAXPATK", 8389, "MINMATK", 7018, "MAXMATK", 8389, "DEF", 15066, "MDEF", 15066));

		// Monster Spawners ---------------------------------

		AddSpawner("d_velniasprison_51_1.Id1", MonsterId.Yognome_Yellow, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_1.Id2", MonsterId.Egnome_Yellow, min: 6, max: 8, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_1.Id3", MonsterId.Gazing_Golem_Yellow, min: 6, max: 7, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_1.Id4", MonsterId.Moya_Yellow, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_1.Id5", MonsterId.Moya_Yellow, min: 12, max: 16, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_1.Id6", MonsterId.Yognome_Yellow, min: 8, max: 10, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_1.Id7", MonsterId.Rootcrystal_05, min: 14, max: 18, respawn: TimeSpan.FromMilliseconds(30000), tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Yognome_Yellow' GenType 14 Spawn Points
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(1701, -377, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(1945, -437, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(1776, -577, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(1600, -523, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(1560, -407, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(1908, 448, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(1827, -440, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(1896, 308, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(1760, 285, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(1626, 319, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(1569, 402, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(1749, 468, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(1763, -294, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(1685, -92, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(1777, -11, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(2037, -48, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(1284, 8, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(1543, -4, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(2164, -16, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(1730, 391, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(-1868, 427, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(-1586, 433, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(-1725, 212, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(-1676, 14, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(-1461, 15, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(-1145, 1, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(-1164, -101, 40));
		AddSpawnPoint("d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Rectangle(-1935, 23, 40));

		// 'Egnome_Yellow' GenType 15 Spawn Points
		AddSpawnPoint("d_velniasprison_51_1.Id2", "d_velniasprison_51_1", Rectangle(-541, 1723, 60));
		AddSpawnPoint("d_velniasprison_51_1.Id2", "d_velniasprison_51_1", Rectangle(56, 1471, 60));
		AddSpawnPoint("d_velniasprison_51_1.Id2", "d_velniasprison_51_1", Rectangle(497, 1494, 60));

		// 'Gazing_Golem_Yellow' GenType 16 Spawn Points
		AddSpawnPoint("d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Rectangle(-1802, 442, 50));
		AddSpawnPoint("d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Rectangle(-1775, -436, 50));
		AddSpawnPoint("d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Rectangle(-1770, 12, 50));
		AddSpawnPoint("d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Rectangle(1744, 408, 50));
		AddSpawnPoint("d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Rectangle(1773, -52, 50));
		AddSpawnPoint("d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Rectangle(1705, -434, 50));
		AddSpawnPoint("d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Rectangle(1544, 385, 50));
		AddSpawnPoint("d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Rectangle(1887, -508, 50));
		AddSpawnPoint("d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Rectangle(-1576, -426, 50));
		AddSpawnPoint("d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Rectangle(-1580, 400, 50));

		// 'Moya_Yellow' GenType 17 Spawn Points
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(-598, 1384, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(-580, 1552, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(-448, 1623, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(-295, 1430, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(-445, 1358, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(-361, 1470, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(369, 1491, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(509, 1570, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(476, 1393, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(394, 1308, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(540, 1232, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(696, 1403, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(648, 1476, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(608, 1340, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(-1770, 395, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(-1589, 429, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(-1614, 269, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(-1765, 87, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(-2107, -4, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(-1534, 38, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(-1201, -64, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(-1079, -136, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(-1110, 16, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(-1604, -401, 35));
		AddSpawnPoint("d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Rectangle(-1643, -289, 35));

		// 'Moya_Yellow' GenType 19 Spawn Points
		AddSpawnPoint("d_velniasprison_51_1.Id5", "d_velniasprison_51_1", Rectangle(-4, 83, 300));
		AddSpawnPoint("d_velniasprison_51_1.Id5", "d_velniasprison_51_1", Rectangle(-1718, 306, 300));

		// 'Yognome_Yellow' GenType 20 Spawn Points
		AddSpawnPoint("d_velniasprison_51_1.Id6", "d_velniasprison_51_1", Rectangle(-1688, -436, 300));
		AddSpawnPoint("d_velniasprison_51_1.Id6", "d_velniasprison_51_1", Rectangle(-47, -39, 300));

		// 'Rootcrystal_05' GenType 27 Spawn Points
		AddSpawnPoint("d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Rectangle(29, 67, 200));
		AddSpawnPoint("d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Rectangle(1768, -382, 200));
		AddSpawnPoint("d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Rectangle(1693, 354, 200));
		AddSpawnPoint("d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Rectangle(1759, -34, 200));
		AddSpawnPoint("d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Rectangle(1204, -19, 200));
		AddSpawnPoint("d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Rectangle(-383, 1474, 200));
		AddSpawnPoint("d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Rectangle(94, 1430, 200));
		AddSpawnPoint("d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Rectangle(517, 1438, 200));
		AddSpawnPoint("d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Rectangle(-1695, 322, 200));
		AddSpawnPoint("d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Rectangle(-1708, 50, 200));
		AddSpawnPoint("d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Rectangle(-1674, -392, 200));
		AddSpawnPoint("d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Rectangle(-1199, 11, 200));
		AddSpawnPoint("d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Rectangle(-425, -1433, 200));
		AddSpawnPoint("d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Rectangle(22, -1549, 200));
		AddSpawnPoint("d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Rectangle(479, -1508, 200));
		AddSpawnPoint("d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Rectangle(23, -366, 200));
		AddSpawnPoint("d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Rectangle(16, 387, 200));
		AddSpawnPoint("d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Rectangle(-363, 28, 200));
		AddSpawnPoint("d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Rectangle(493, -25, 200));
		AddSpawnPoint("d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Rectangle(32, 1069, 200));
	}
}
