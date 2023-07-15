//--- Melia Script -----------------------------------------------------------
// d_firetower_44
//
//--- Description -----------------------------------------------------------
// Sets up the d_firetower_44 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFiretower44MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_firetower_44", MonsterId.New_Desmodus_Black, Properties("MHP", 110104, "MINPATK", 1917, "MAXPATK", 2258, "MINMATK", 1917, "MAXMATK", 2258, "DEF", 1508, "MDEF", 1508));
		AddPropertyOverrides("d_firetower_44", MonsterId.Flask, Properties("MHP", 113215, "MINPATK", 1957, "MAXPATK", 2307, "MINMATK", 1957, "MAXMATK", 2307, "DEF", 1609, "MDEF", 1609));
		AddPropertyOverrides("d_firetower_44", MonsterId.Minivern, Properties("MHP", 114818, "MINPATK", 1977, "MAXPATK", 2332, "MINMATK", 1977, "MAXMATK", 2332, "DEF", 1661, "MDEF", 1661));
		AddPropertyOverrides("d_firetower_44", MonsterId.Wizards_Marmotte, Properties("MHP", 111644, "MINPATK", 1937, "MAXPATK", 2282, "MINMATK", 1937, "MAXMATK", 2282, "DEF", 1558, "MDEF", 1558));
		AddPropertyOverrides("d_firetower_44", MonsterId.Minivern_Elite, Properties("MHP", 116450, "MINPATK", 1998, "MAXPATK", 2358, "MINMATK", 1998, "MAXMATK", 2358, "DEF", 1714, "MDEF", 1714));

		// Monster Spawners --------------------------------

		AddSpawner("d_firetower_44.Id1", MonsterId.New_Desmodus_Black, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_44.Id2", MonsterId.Flask, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_44.Id3", MonsterId.Rootcrystal_01, 11, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_firetower_44.Id4", MonsterId.Minivern, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_44.Id5", MonsterId.Wizards_Marmotte, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_44.Id6", MonsterId.Minivern_Elite, 3, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// New_Desmodus_Black Spawn Points
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(-80.270546, -1357.3282, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(-740.61694, 522.4833, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(-639.23535, -0.74254227, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(1290.9515, 295.1505, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(827.56915, 549.3236, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(1829.4816, 653.1514, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(1378.0503, -861.0937, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(513.23456, -620.00775, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(-555.3379, -771.4126, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(-320.8813, -702.1581, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(-333.59827, -506.63617, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(-1061.8999, -106.7962, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(-623.10046, 91.37045, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(-1134.8198, -37.940903, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(-1335.4845, 411.57367, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(-291.50378, -1224.7979, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(-50.863663, -1260.2273, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(-345.96454, -1278.2368, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(624.56067, -911.1649, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(454.05087, -804.5113, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(627.21545, -521.09357, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(852.6145, -720.54236, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(1600.7067, -823.51715, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(1332.3031, -734.1119, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(1051.2202, 454.1625, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(1203.426, 442.7738, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(1502.1602, 382.3343, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(1653.729, 639.68054, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(1859.7416, 825.36334, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(669.84875, 26.078323, 25));
		AddSpawnPoint( "d_firetower_44.Id1", "d_firetower_44", Spot(1153.6079, -786.33984, 25));

		// Flask Spawn Points
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(-584.8921, -619.7245, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(-1119.4448, 3.8825665, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(675.9948, -247.63174, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(-455.1545, -805.34155, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(-1007.5729, -69.62358, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(995.27966, -774.0924, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(842.89575, 496.68088, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(795.1341, -6.561805, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(-312.48172, -661.90125, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(-724.42224, 506.49277, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(-33.789356, -1385.0216, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(-245.04794, -1233.7588, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(707.1555, -775.0618, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(758.8625, -659.8354, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(1593.0178, -723.72217, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(1509.1776, -908.9066, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(135.02362, -18.48236, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(-26.937408, 147.50145, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(109.60861, 240.31787, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(-33.95769, -1387.6443, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(552.7079, -817.14197, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(600.246, -1301.6401, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(504.29, -645.86505, 20));
		AddSpawnPoint( "d_firetower_44.Id2", "d_firetower_44", Spot(624.92285, -689.5083, 20));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "d_firetower_44.Id3", "d_firetower_44", Spot(-2322.5916, -83.42691, 100));
		AddSpawnPoint( "d_firetower_44.Id3", "d_firetower_44", Spot(-1583.9591, 394.2735, 100));
		AddSpawnPoint( "d_firetower_44.Id3", "d_firetower_44", Spot(-956.50854, 478.423, 100));
		AddSpawnPoint( "d_firetower_44.Id3", "d_firetower_44", Spot(-1053.1573, -47.495438, 100));
		AddSpawnPoint( "d_firetower_44.Id3", "d_firetower_44", Spot(-325.92365, -1118.4203, 100));
		AddSpawnPoint( "d_firetower_44.Id3", "d_firetower_44", Spot(86.65659, 11.391376, 100));
		AddSpawnPoint( "d_firetower_44.Id3", "d_firetower_44", Spot(1761.1705, 416.47308, 100));
		AddSpawnPoint( "d_firetower_44.Id3", "d_firetower_44", Spot(602.2511, -1589.0131, 100));
		AddSpawnPoint( "d_firetower_44.Id3", "d_firetower_44", Spot(923.3224, -780.1436, 100));
		AddSpawnPoint( "d_firetower_44.Id3", "d_firetower_44", Spot(714.6228, -302.16763, 100));
		AddSpawnPoint( "d_firetower_44.Id3", "d_firetower_44", Spot(1103.9695, 455.95255, 100));

		// Minivern Spawn Points
		AddSpawnPoint( "d_firetower_44.Id4", "d_firetower_44", Spot(-612.40607, 18.50241, 9999));

		// Wizards_Marmotte Spawn Points
		AddSpawnPoint( "d_firetower_44.Id5", "d_firetower_44", Spot(661.359, -777.1559, 20));
		AddSpawnPoint( "d_firetower_44.Id5", "d_firetower_44", Spot(-562.1613, -591.0337, 20));
		AddSpawnPoint( "d_firetower_44.Id5", "d_firetower_44", Spot(-752.811, 505.50385, 20));
		AddSpawnPoint( "d_firetower_44.Id5", "d_firetower_44", Spot(1723.8962, 806.4953, 20));
		AddSpawnPoint( "d_firetower_44.Id5", "d_firetower_44", Spot(1280.6647, 384.7801, 20));
		AddSpawnPoint( "d_firetower_44.Id5", "d_firetower_44", Spot(-84.47855, -1206.0468, 20));
		AddSpawnPoint( "d_firetower_44.Id5", "d_firetower_44", Spot(1449.3464, -783.808, 20));
		AddSpawnPoint( "d_firetower_44.Id5", "d_firetower_44", Spot(762.16235, 28.9733, 20));
		AddSpawnPoint( "d_firetower_44.Id5", "d_firetower_44", Spot(-527.8118, -842.93005, 20));
		AddSpawnPoint( "d_firetower_44.Id5", "d_firetower_44", Spot(614.51117, 90.50188, 20));
		AddSpawnPoint( "d_firetower_44.Id5", "d_firetower_44", Spot(513.2515, -790.9009, 20));
		AddSpawnPoint( "d_firetower_44.Id5", "d_firetower_44", Spot(-27.478878, -1453.3666, 20));
		AddSpawnPoint( "d_firetower_44.Id5", "d_firetower_44", Spot(-986.8605, -50.48951, 20));
		AddSpawnPoint( "d_firetower_44.Id5", "d_firetower_44", Spot(222.42271, 146.77684, 20));
		AddSpawnPoint( "d_firetower_44.Id5", "d_firetower_44", Spot(117.77236, 87.18732, 20));
		AddSpawnPoint( "d_firetower_44.Id5", "d_firetower_44", Spot(-707.87976, -793.8638, 20));
		AddSpawnPoint( "d_firetower_44.Id5", "d_firetower_44", Spot(666.57336, -562.15533, 20));
		AddSpawnPoint( "d_firetower_44.Id5", "d_firetower_44", Spot(1045.981, 437.58673, 20));
		AddSpawnPoint( "d_firetower_44.Id5", "d_firetower_44", Spot(728.5926, -870.36945, 20));
		AddSpawnPoint( "d_firetower_44.Id5", "d_firetower_44", Spot(-1235.1367, 399.58374, 20));

		// Minivern_Elite Spawn Points
		AddSpawnPoint( "d_firetower_44.Id6", "d_firetower_44", Spot(601.5617, -732.30676, 9999));

	}
}
