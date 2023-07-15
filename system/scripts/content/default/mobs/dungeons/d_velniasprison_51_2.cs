//--- Melia Script -----------------------------------------------------------
// d_velniasprison_51_2
//
//--- Description -----------------------------------------------------------
// Sets up the d_velniasprison_51_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DVelniasprison512MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_velniasprison_51_2", MonsterId.Defender_Spider, Properties("MHP", 189776, "MINPATK", 2942, "MAXPATK", 3517, "MINMATK", 2942, "MAXMATK", 3517, "DEF", 6401, "MDEF", 6401));
		AddPropertyOverrides("d_velniasprison_51_2", MonsterId.Nuka, Properties("MHP", 191163, "MINPATK", 2959, "MAXPATK", 3539, "MINMATK", 2959, "MAXMATK", 3539, "DEF", 6528, "MDEF", 6528));
		AddPropertyOverrides("d_velniasprison_51_2", MonsterId.Harugal, Properties("MHP", 192581, "MINPATK", 2978, "MAXPATK", 3561, "MINMATK", 2978, "MAXMATK", 3561, "DEF", 6657, "MDEF", 6657));
		AddPropertyOverrides("d_velniasprison_51_2", MonsterId.Elet, Properties("MHP", 194029, "MINPATK", 2996, "MAXPATK", 3584, "MINMATK", 2996, "MAXMATK", 3584, "DEF", 6789, "MDEF", 6789));

		// Monster Spawners --------------------------------

		AddSpawner("d_velniasprison_51_2.Id1", MonsterId.Defender_Spider, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_2.Id2", MonsterId.Nuka, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_2.Id3", MonsterId.Defender_Spider, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_2.Id4", MonsterId.Harugal, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_2.Id5", MonsterId.Rootcrystal_05, 18, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_velniasprison_51_2.Id6", MonsterId.Nuka, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_2.Id7", MonsterId.Elet, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// Defender_Spider Spawn Points
		AddSpawnPoint( "d_velniasprison_51_2.Id1", "d_velniasprison_51_2", Spot(-1517.2578, -147.41678, 150));
		AddSpawnPoint( "d_velniasprison_51_2.Id1", "d_velniasprison_51_2", Spot(-796.7133, 1020.4454, 150));

		// Nuka Spawn Points
		AddSpawnPoint( "d_velniasprison_51_2.Id2", "d_velniasprison_51_2", Spot(-1491.3463, 908.13, 200));
		AddSpawnPoint( "d_velniasprison_51_2.Id2", "d_velniasprison_51_2", Spot(-776.64, -235.51997, 200));

		// Defender_Spider Spawn Points
		AddSpawnPoint( "d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Spot(-1555.7273, 984.9888, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Spot(-776.32513, 964.68585, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Spot(-596.7037, 985.5314, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Spot(-933.0949, 1132.0486, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Spot(-754.4216, 421.24573, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Spot(-1371.2996, 380.41028, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Spot(1683.3671, -1444.2179, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Spot(1686.3563, -1703.522, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Spot(1337.7809, -1526.8472, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Spot(896.94495, -1582.2196, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Spot(743.69495, -1731.0402, 30));

		// Harugal Spawn Points
		AddSpawnPoint( "d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Spot(-1515.9467, 1210.2925, 100));
		AddSpawnPoint( "d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Spot(-1565.4038, -148.39145, 100));
		AddSpawnPoint( "d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Spot(-740.0637, -282.5994, 100));
		AddSpawnPoint( "d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Spot(-774.8517, 923.75946, 100));
		AddSpawnPoint( "d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Spot(-726.09216, 407.8715, 100));
		AddSpawnPoint( "d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Spot(-1551.7423, 406.85352, 100));
		AddSpawnPoint( "d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Spot(534.91516, -1475.7618, 100));
		AddSpawnPoint( "d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Spot(733.32904, -1729.7272, 100));
		AddSpawnPoint( "d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Spot(1498.8826, -1439.0999, 100));
		AddSpawnPoint( "d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Spot(1593.7744, -1694.5508, 100));
		AddSpawnPoint( "d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Spot(-1471.9419, 1088.5211, 100));
		AddSpawnPoint( "d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Spot(-1631.7762, 1044.5078, 100));
		AddSpawnPoint( "d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Spot(-1543.2443, 866.25806, 100));
		AddSpawnPoint( "d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Spot(-1429.952, 817.8611, 100));
		AddSpawnPoint( "d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Spot(-1704.2794, -60.117588, 100));
		AddSpawnPoint( "d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Spot(-1647.2191, -280.81284, 100));
		AddSpawnPoint( "d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Spot(-1450.0082, -163.14827, 100));
		AddSpawnPoint( "d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Spot(-1461.6193, 18.161314, 100));
		AddSpawnPoint( "d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Spot(-1532.9011, 724.5559, 100));

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Spot(-1498.4769, 929.05255, 200));
		AddSpawnPoint( "d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Spot(-1644.3247, -75.78589, 200));
		AddSpawnPoint( "d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Spot(-752.5351, 428.85812, 200));
		AddSpawnPoint( "d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Spot(-1540.2426, 425.38504, 200));
		AddSpawnPoint( "d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Spot(-745.9282, 911.60986, 200));
		AddSpawnPoint( "d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Spot(-708.451, -224.58575, 200));
		AddSpawnPoint( "d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Spot(1288.8779, 402.80035, 200));
		AddSpawnPoint( "d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Spot(1195.1626, 1618.8412, 200));
		AddSpawnPoint( "d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Spot(1656.3468, -1352.1024, 200));
		AddSpawnPoint( "d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Spot(1532.1694, -1650.4843, 200));
		AddSpawnPoint( "d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Spot(756.80225, -1615.3208, 200));

		// Nuka Spawn Points
		AddSpawnPoint( "d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Spot(-421.49496, 397.8806, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Spot(-805.4449, -387.37796, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Spot(-735.5212, -267.16705, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Spot(-593.1514, -284.01346, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Spot(-951.7225, -260.27066, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Spot(-1546.3917, 1017.3377, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Spot(-1512.2864, 21.911163, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Spot(-952.6666, 1029.9617, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Spot(-658.19977, 1057.1178, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Spot(-688.1462, -144.15942, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Spot(-1709.6115, -82.689, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Spot(-1609.3818, -328.67987, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Spot(-746.059, 864.6704, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Spot(-1574.9001, 854.99084, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Spot(-776.0079, 418.921, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Spot(-1591.8014, 429.917, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Spot(-1078.209, 433.10028, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Spot(-819.0254, -130.24094, 30));

		// Elet Spawn Points
		AddSpawnPoint( "d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Spot(-1519.7975, -141.95331, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Spot(-652.9177, -159.94432, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Spot(-711.3224, -445.24005, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Spot(-1410.5492, -5.024622, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Spot(-1459.9315, -324.93637, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Spot(-1650.4149, -201.56013, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Spot(-1629.7535, 6.9627295, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Spot(-1539.2941, 594.49976, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Spot(629.6681, -1728.9021, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Spot(671.4549, -1483.1122, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Spot(1068.3556, -1536.1779, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Spot(1568.8419, -1796.5476, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Spot(1655.9474, -1352.7814, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Spot(-887.4362, 910.33826, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Spot(-662.4496, 969.9564, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Spot(-908.34814, 1085.8877, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Spot(-782.97644, 1074.8644, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Spot(-849.28455, -104.57232, 30));
		AddSpawnPoint( "d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Spot(-964.95, -282.4911, 30));

	}
}
