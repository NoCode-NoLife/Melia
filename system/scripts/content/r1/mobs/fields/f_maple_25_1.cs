//--- Melia Script -----------------------------------------------------------
// f_maple_25_1
//
//--- Description -----------------------------------------------------------
// Sets up the f_maple_25_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FMaple251MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_maple_25_1", MonsterId.Rodenarcorng, Properties("MHP", 527238, "MINPATK", 7281, "MAXPATK", 8850, "MINMATK", 7281, "MAXMATK", 8850, "DEF", 91407, "MDEF", 91407));
		AddPropertyOverrides("f_maple_25_1", MonsterId.Rodenag, Properties("MHP", 528664, "MINPATK", 7299, "MAXPATK", 8872, "MINMATK", 7299, "MAXMATK", 8872, "DEF", 92112, "MDEF", 92112));
		AddPropertyOverrides("f_maple_25_1", MonsterId.Rodetad, Properties("MHP", 530281, "MINPATK", 7320, "MAXPATK", 8898, "MINMATK", 7320, "MAXMATK", 8898, "DEF", 92912, "MDEF", 92912));

		// Monster Spawners --------------------------------

		AddSpawner("f_maple_25_1.Id1", MonsterId.Rodenarcorng, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_1.Id2", MonsterId.Rodenag, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_1.Id3", MonsterId.Rodetad, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_1.Id4", MonsterId.Rodenarcorng, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_1.Id5", MonsterId.Rootcrystal_05, 30, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rodenarcorng Spawn Points
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(203.08167, 705.0587, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(361.76843, 402.21814, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(267.38794, 282.0053, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(57.691643, 300.9602, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(127.58677, 149.87787, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(171.01271, 368.02975, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-67.70938, 370.02386, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-300.07562, 365.10938, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-410.9033, 294.73865, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-470.8285, 148.63026, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-500.53635, -13.312881, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-661.1071, 194.49825, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-847.37115, 152.09311, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-710.66943, 281.63986, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-425.17102, 758.714, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-275.4096, 823.49744, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-240.70561, 720.4817, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-61.521103, 843.25, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(60.508736, 904.8649, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(111.1764, 997.5037, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(134.11594, 733.5183, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(225.19788, 874.4639, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(310.2819, 773.5317, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(450.6137, 794.2572, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(556.2799, 685.39014, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(674.24744, 816.7458, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(793.0241, 751.56836, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(1143.492, 910.5577, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(1215.7908, 872.65247, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(1270.1707, 984.5393, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(1427.6959, 778.5882, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(1440.1125, 1029.7551, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(2046.4308, 1394.1283, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(1882.8958, 1551.2781, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(2024.1042, 1479.7948, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(2183.4634, 1461.2045, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(2046.9681, 1581.8823, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(1556.1414, 1682.9009, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(1456.2292, 1549.6879, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(1335.8062, 1645.2405, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(1160.11, 1574.2825, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(861.3021, 1540.4514, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(662.228, 1570.0925, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(531.3969, 1453.7058, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(264.84634, 1729.7965, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(142.63275, 1752.4082, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(26.990776, 1749.5609, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-424.40137, 1675.6804, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-575.18506, 1763.4186, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-554.05426, 1527.7516, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-676.42786, 1446.2882, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-836.1477, 1579.132, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-1261.0892, 1641.6709, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-1405.3055, 1531.0314, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-1511.5685, 1696.9546, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-1568.8013, 1593.1927, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-1494.4459, 1384.7637, 40));
		AddSpawnPoint( "f_maple_25_1.Id1", "f_maple_25_1", Spot(-1797.2491, 1565.9988, 40));

		// Rodenag Spawn Points
		AddSpawnPoint( "f_maple_25_1.Id2", "f_maple_25_1", Spot(1180.0082, 450.44296, 40));
		AddSpawnPoint( "f_maple_25_1.Id2", "f_maple_25_1", Spot(1452.0042, 927.8422, 40));
		AddSpawnPoint( "f_maple_25_1.Id2", "f_maple_25_1", Spot(1260.3695, 472.94205, 40));
		AddSpawnPoint( "f_maple_25_1.Id2", "f_maple_25_1", Spot(1350.3408, 855.0684, 40));
		AddSpawnPoint( "f_maple_25_1.Id2", "f_maple_25_1", Spot(1481.6075, 787.0123, 40));
		AddSpawnPoint( "f_maple_25_1.Id2", "f_maple_25_1", Spot(1534.8029, 959.8415, 40));
		AddSpawnPoint( "f_maple_25_1.Id2", "f_maple_25_1", Spot(1395.3021, 1013.377, 40));
		AddSpawnPoint( "f_maple_25_1.Id2", "f_maple_25_1", Spot(231.78911, 203.10802, 40));
		AddSpawnPoint( "f_maple_25_1.Id2", "f_maple_25_1", Spot(284.5898, 357.21918, 40));
		AddSpawnPoint( "f_maple_25_1.Id2", "f_maple_25_1", Spot(-20.083313, 395.0388, 40));
		AddSpawnPoint( "f_maple_25_1.Id2", "f_maple_25_1", Spot(854.9865, 477.03674, 40));
		AddSpawnPoint( "f_maple_25_1.Id2", "f_maple_25_1", Spot(1042.6783, 411.8749, 40));
		AddSpawnPoint( "f_maple_25_1.Id2", "f_maple_25_1", Spot(923.4487, 354.24908, 40));
		AddSpawnPoint( "f_maple_25_1.Id2", "f_maple_25_1", Spot(604.3553, 434.76334, 40));
		AddSpawnPoint( "f_maple_25_1.Id2", "f_maple_25_1", Spot(1224.3341, 334.52896, 40));
		AddSpawnPoint( "f_maple_25_1.Id2", "f_maple_25_1", Spot(56.256382, 334.54352, 40));
		AddSpawnPoint( "f_maple_25_1.Id2", "f_maple_25_1", Spot(24.487856, 134.63034, 40));
		AddSpawnPoint( "f_maple_25_1.Id2", "f_maple_25_1", Spot(1221.1719, 971.0043, 40));
		AddSpawnPoint( "f_maple_25_1.Id2", "f_maple_25_1", Spot(1332.0265, 1054.6057, 40));

		// Rodetad Spawn Points
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-1114.4785, 737.23444, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-995.07654, 643.3329, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-900.2859, 562.5825, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-949.06683, 928.21844, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-888.67206, 726.1145, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-1716.77, 1357.15, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-1831.17, 1522.29, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-1448.71, 1411.68, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-1628.46, 1501.63, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-1451.0156, 1570.3894, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-1649.04, 1614.31, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-1345.3127, 1693.3472, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-1541.6127, 1647.2177, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-1561.55, 1342.3, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-1698.74, 793.08, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-1743, 638.58, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-1731.01, 490.87, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-1871.2, 549.46, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-1884.48, 691.72, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-1826.02, 856.45, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-2047.93, 868.47, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-2172.07, 766.93, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-1807.73, 712.58, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-1574.6, 738.26, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-1457.2, 799.17, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-873.42865, 870.0072, 35));
		AddSpawnPoint( "f_maple_25_1.Id3", "f_maple_25_1", Spot(-729.14435, 799.81244, 35));

		// Rodenarcorng Spawn Points
		AddSpawnPoint( "f_maple_25_1.Id4", "f_maple_25_1", Spot(-859.6, 788.04, 9999));

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(1436.72, 842.59, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(1022.81, 834.72, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(669.09, 748.39, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(340.17, 818, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(-8.12, 847.88, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(-242.8, 760.79, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(-506.58, 828.89, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(-874.36, 712.15, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(-1010.99, 931.85, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(-1044.23, 693.72, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(-1793.78, 566.02, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(-1955.37, 801.8, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(-1750.63, 874.91, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(-1748.05, 1475.36, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(-1471.37, 1285.37, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(-1380.95, 1609.22, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(-849.38, 1639.08, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(-689.98, 1375.97, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(-498.74, 1589.4, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(-551.75, 1826.4, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(194.18, 1790.2, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(429.24, 1604.05, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(708.78, 1475.6, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(1220.77, 1616, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(1530.34, 1612.5, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(1938.65, 1498.88, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(2104.6, 1593.76, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(1321.04, 362.32, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(871.46, 398.39, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(304.07, 264.37, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(58.82, 387.37, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(-343.99, 326.39, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(-551.23, 19.34, 15));
		AddSpawnPoint( "f_maple_25_1.Id5", "f_maple_25_1", Spot(-813.76, 259.74, 15));

	}
}
