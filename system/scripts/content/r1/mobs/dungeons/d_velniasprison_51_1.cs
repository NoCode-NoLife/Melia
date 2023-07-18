//--- Melia Script -----------------------------------------------------------
// d_velniasprison_51_1
//
//--- Description -----------------------------------------------------------
// Sets up the d_velniasprison_51_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DVelniasprison511MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_velniasprison_51_1", MonsterId.Yognome_Yellow, Properties("MHP", 183322, "MINPATK", 2859, "MAXPATK", 3415, "MINMATK", 2859, "MAXMATK", 3415, "DEF", 5813, "MDEF", 5813));
		AddPropertyOverrides("d_velniasprison_51_1", MonsterId.Gazing_Golem_Yellow, Properties("MHP", 184546, "MINPATK", 2874, "MAXPATK", 3434, "MINMATK", 2874, "MAXMATK", 3434, "DEF", 5925, "MDEF", 5925));
		AddPropertyOverrides("d_velniasprison_51_1", MonsterId.Moya_Yellow, Properties("MHP", 185804, "MINPATK", 2891, "MAXPATK", 3454, "MINMATK", 2891, "MAXMATK", 3454, "DEF", 6039, "MDEF", 6039));
		AddPropertyOverrides("d_velniasprison_51_1", MonsterId.Egnome_Yellow, Properties("MHP", 187095, "MINPATK", 2907, "MAXPATK", 3474, "MINMATK", 2907, "MAXMATK", 3474, "DEF", 6157, "MDEF", 6157));

		// Monster Spawners --------------------------------

		AddSpawner("d_velniasprison_51_1.Id1", MonsterId.Yognome_Yellow, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_1.Id2", MonsterId.Gazing_Golem_Yellow, 7, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_1.Id3", MonsterId.Moya_Yellow, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_1.Id4", MonsterId.Egnome_Yellow, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_1.Id5", MonsterId.Moya_Yellow, 16, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_1.Id6", MonsterId.Yognome_Yellow, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_1.Id7", MonsterId.Rootcrystal_05, 18, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Yognome_Yellow Spawn Points
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(1701.7448, -377.0424, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(1945.7637, -437.27277, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(1776.788, -577.205, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(1600.363, -523.42365, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(1560.9215, -407.84357, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(1908.3007, 448.90466, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(1827.7059, -440.94107, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(1896.5947, 308.367, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(1760.3585, 285.23907, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(1626.7916, 319.80844, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(1569.6082, 402.47232, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(1749.6571, 468.93323, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(1763.1366, -294.93152, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(1685.5658, -92.757744, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(1777.0183, -11.799431, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(2037.9979, -48.154358, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(1284.1561, 8.058031, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(1543.651, -4.842378, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(2164.257, -16.956638, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(1730.4695, 391.09256, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(-1868.2201, 427.4152, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(-1586.4576, 433.68857, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(-1725.8246, 212.77007, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(-1676.1031, 14.866398, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(-1461.6105, 15.285368, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(-1145.7625, 1.6464729, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(-1164.9641, -101.35853, 40));
		AddSpawnPoint( "d_velniasprison_51_1.Id1", "d_velniasprison_51_1", Spot(-1935.8981, 23.65707, 40));

		// Gazing_Golem_Yellow Spawn Points
		AddSpawnPoint( "d_velniasprison_51_1.Id2", "d_velniasprison_51_1", Spot(-1802.7946, 442.8377, 50));
		AddSpawnPoint( "d_velniasprison_51_1.Id2", "d_velniasprison_51_1", Spot(-1775.1881, -436.14145, 50));
		AddSpawnPoint( "d_velniasprison_51_1.Id2", "d_velniasprison_51_1", Spot(-1770.5746, 12.371676, 50));
		AddSpawnPoint( "d_velniasprison_51_1.Id2", "d_velniasprison_51_1", Spot(1744.0105, 408.97357, 50));
		AddSpawnPoint( "d_velniasprison_51_1.Id2", "d_velniasprison_51_1", Spot(1773.7507, -52.03391, 50));
		AddSpawnPoint( "d_velniasprison_51_1.Id2", "d_velniasprison_51_1", Spot(1705.0018, -434.24026, 50));
		AddSpawnPoint( "d_velniasprison_51_1.Id2", "d_velniasprison_51_1", Spot(1544.3887, 385.23932, 50));
		AddSpawnPoint( "d_velniasprison_51_1.Id2", "d_velniasprison_51_1", Spot(1887.7853, -508.76245, 50));
		AddSpawnPoint( "d_velniasprison_51_1.Id2", "d_velniasprison_51_1", Spot(-1576.1005, -426.18692, 50));
		AddSpawnPoint( "d_velniasprison_51_1.Id2", "d_velniasprison_51_1", Spot(-1580.3453, 400.30716, 50));

		// Moya_Yellow Spawn Points
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(-598.93225, 1384.341, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(-580.0733, 1552.3154, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(-448.32822, 1623.6472, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(-295.03302, 1430.433, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(-445.49417, 1358.5503, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(-361.13458, 1470.2119, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(369.08884, 1491.7993, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(509.70914, 1570.695, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(476.90704, 1393.2, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(394.3703, 1308.2734, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(540.26294, 1232.4639, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(696.58777, 1403.4808, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(648.9843, 1476.4359, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(608.0735, 1340.5154, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(-1770.3672, 395.72037, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(-1589.2987, 429.99033, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(-1614.0604, 269.2932, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(-1765.9825, 87.848885, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(-2107.8015, -4.4672203, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(-1534.4103, 38.35737, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(-1201.3805, -64.86263, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(-1079.6838, -136.14339, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(-1110.608, 16.235497, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(-1604.4403, -401.16275, 35));
		AddSpawnPoint( "d_velniasprison_51_1.Id3", "d_velniasprison_51_1", Spot(-1643.2562, -289.95697, 35));

		// Egnome_Yellow Spawn Points
		AddSpawnPoint( "d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Spot(-541.3967, 1723.3485, 60));
		AddSpawnPoint( "d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Spot(56.118843, 1471.103, 60));
		AddSpawnPoint( "d_velniasprison_51_1.Id4", "d_velniasprison_51_1", Spot(497.70258, 1494.4855, 60));

		// Moya_Yellow Spawn Points
		AddSpawnPoint( "d_velniasprison_51_1.Id5", "d_velniasprison_51_1", Spot(-4.866062, 83.46671, 300));
		AddSpawnPoint( "d_velniasprison_51_1.Id5", "d_velniasprison_51_1", Spot(-1718.748, 306.9408, 300));

		// Yognome_Yellow Spawn Points
		AddSpawnPoint( "d_velniasprison_51_1.Id6", "d_velniasprison_51_1", Spot(-1688.4752, -436.31946, 300));
		AddSpawnPoint( "d_velniasprison_51_1.Id6", "d_velniasprison_51_1", Spot(-47.189278, -39.884556, 300));

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Spot(29.795837, 67.570145, 200));
		AddSpawnPoint( "d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Spot(1768.4839, -382.1721, 200));
		AddSpawnPoint( "d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Spot(1693.8134, 354.51297, 200));
		AddSpawnPoint( "d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Spot(1759.2898, -34.166065, 200));
		AddSpawnPoint( "d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Spot(1204.8588, -19.696255, 200));
		AddSpawnPoint( "d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Spot(-383.97403, 1474.0082, 200));
		AddSpawnPoint( "d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Spot(94.3875, 1430.9568, 200));
		AddSpawnPoint( "d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Spot(517.1989, 1438.6243, 200));
		AddSpawnPoint( "d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Spot(-1695.3517, 322.60907, 200));
		AddSpawnPoint( "d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Spot(-1708.1449, 50.354446, 200));
		AddSpawnPoint( "d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Spot(-1674.7292, -392.46597, 200));
		AddSpawnPoint( "d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Spot(-1199.8107, 11.930338, 200));
		AddSpawnPoint( "d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Spot(-425.46008, -1433.7068, 200));
		AddSpawnPoint( "d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Spot(22.376247, -1549.8425, 200));
		AddSpawnPoint( "d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Spot(479.9316, -1508.8855, 200));
		AddSpawnPoint( "d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Spot(23.117315, -366.4404, 200));
		AddSpawnPoint( "d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Spot(16.164812, 387.29105, 200));
		AddSpawnPoint( "d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Spot(-363.50415, 28.802858, 200));
		AddSpawnPoint( "d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Spot(493.801, -25.428442, 200));
		AddSpawnPoint( "d_velniasprison_51_1.Id7", "d_velniasprison_51_1", Spot(32.851547, 1069.359, 200));

	}
}
