//--- Melia Script -----------------------------------------------------------
// f_dcapital_106
//
//--- Description -----------------------------------------------------------
// Sets up the f_dcapital_106 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FDcapital106MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_dcapital_106", MonsterId.Wajak_Walker, Properties("MHP", 753453, "MINPATK", 10190, "MAXPATK", 12426, "MINMATK", 10190, "MAXMATK", 12426, "DEF", 230073, "MDEF", 230073));
		AddPropertyOverrides("f_dcapital_106", MonsterId.Horong_Walker, Properties("MHP", 754576, "MINPATK", 10204, "MAXPATK", 12444, "MINMATK", 10204, "MAXMATK", 12444, "DEF", 231019, "MDEF", 231019));
		AddPropertyOverrides("f_dcapital_106", MonsterId.Bishop_Hart, Properties("MHP", 755763, "MINPATK", 10219, "MAXPATK", 12462, "MINMATK", 10219, "MAXMATK", 12462, "DEF", 232018, "MDEF", 232018));
		AddPropertyOverrides("f_dcapital_106", MonsterId.Bishop_Point, Properties("MHP", 757011, "MINPATK", 10235, "MAXPATK", 12482, "MINMATK", 10235, "MAXMATK", 12482, "DEF", 233070, "MDEF", 233070));

		// Monster Spawners --------------------------------

		AddSpawner("f_dcapital_106.Id1", MonsterId.Rootcrystal_01, 35, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_dcapital_106.Id2", MonsterId.Wajak_Walker, 31, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_106.Id3", MonsterId.Horong_Walker, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_106.Id4", MonsterId.Bishop_Hart, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_106.Id5", MonsterId.Bishop_Point, 36, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_106.Id6", MonsterId.Bishop_Point, 4, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(1981.3625, 319.81763, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(2000.8971, 498.419, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(2079.1345, 38.901222, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(1526.2701, 596.42377, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(1299.503, 660.9947, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(896.9584, 640.0746, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(429.94843, 476.58728, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(664.6426, 825.1225, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(734.81226, 1139.1599, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(1025.5913, 1111.8628, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(247.72665, 698.91797, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(-224.31396, 863.63135, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(-459.46844, 783.57947, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(-360.65106, 317.18335, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(40.75462, 378.10495, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(-295.18362, 25.533396, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(-405.05548, -305.43903, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(-580.6323, -53.548325, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(-924.4196, -63.852478, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(-1375.9587, -83.57066, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(-1178.6484, -351.3827, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(-1548.3414, -352.43753, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(-1187.0486, -196.22318, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(-1481.1915, 1000.881, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(-1482.1344, 1266.1173, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(-1139.9388, 1042.9253, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(-772.3514, 1421.1039, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(-437.3568, 1205.089, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(231.01997, 1216.7516, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(121.5108, 1394.2065, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(305.41327, 1483.3142, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(430.13373, 1281.7485, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(636.1374, 1479.4414, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(766.3333, 1618.6227, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(749.77747, 1865.7495, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(892.1005, 962.3356, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(1326.5653, 1262.9803, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(1677.2672, 1243.1771, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(1722.4939, 1377.8765, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(1949.8152, 1242.7128, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(2102.725, 1395.5901, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(1957.1493, 1449.8081, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(703.4448, 545.7679, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(1737.0265, 334.74817, 100));
		AddSpawnPoint( "f_dcapital_106.Id1", "f_dcapital_106", Spot(2198.5557, 256.11456, 100));

		// Wajak_Walker Spawn Points
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-1438.0544, -56.17761, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-1515.865, -399.91333, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-944.6968, -70.22319, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-380.24426, -46.216442, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-423.6311, 344.18604, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-478.06052, -367.37738, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(20.213814, 395.1095, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-254.38974, 676.9789, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-517.8943, 722.8612, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-340.14746, 954.26965, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-508.28345, 1061.1473, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-577.265, 1271.4739, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-793.70197, 1497.9839, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-1008.3039, 1340.2859, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-1062.6836, 1092.3112, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-1184.2295, 898.65845, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-1275.6686, 1181.7897, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-1594.8988, 1023.6812, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-89.363144, 879.78326, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-655.2747, -37.23448, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-633.4586, 145.6344, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-104.3816, 28.445366, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-1239.0311, -315.5246, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(134.62143, 611.01416, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(156.26843, 894.09863, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(555.56134, 396.01956, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(529.09973, 847.58887, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(242.02832, 504.67044, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-812.18634, -161.5372, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(87.8664, 521.4795, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(157.05893, 1029.8198, 25));
		AddSpawnPoint( "f_dcapital_106.Id2", "f_dcapital_106", Spot(-241.50504, 159.72824, 25));

		// Horong_Walker Spawn Points
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-1336.4388, -167.63313, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-1035.0582, -208.70273, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-649.70105, -204.89119, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-285.5655, -235.5584, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-469.75403, 126.34563, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-166.89447, 295.26752, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-453.26947, 541.03723, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-329.28168, 861.31586, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-585.57996, 995.9881, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-361.73462, 1211.4028, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-761.37213, 1355.4633, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-1135.9933, 1279.4539, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-1468.1423, 881.9835, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-1507.3036, 1237.5286, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-1319.5195, 1010.707, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-1056.9749, 1011.5781, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-555.09955, 771.91925, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-170.2895, 999.91534, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(139.65704, 752.8801, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(13.080698, 944.8927, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(357.04605, 428.2333, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-209.48376, -61.587463, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-1473.9984, 1086.7545, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(343.5283, 661.885, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(391.03998, 903.69324, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-387.1059, 701.8201, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-476.42145, -187.68965, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-1171.4978, -78.182335, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-892.22437, 1421.998, 25));
		AddSpawnPoint( "f_dcapital_106.Id3", "f_dcapital_106", Spot(-1569.2936, -255.00262, 25));

		// Bishop_Hart Spawn Points
		AddSpawnPoint( "f_dcapital_106.Id4", "f_dcapital_106", Spot(2129.7517, 1434.4717, 25));
		AddSpawnPoint( "f_dcapital_106.Id4", "f_dcapital_106", Spot(1742.3617, 1171.1973, 25));
		AddSpawnPoint( "f_dcapital_106.Id4", "f_dcapital_106", Spot(1308.8973, 1237.157, 25));
		AddSpawnPoint( "f_dcapital_106.Id4", "f_dcapital_106", Spot(1314.1365, 666.22784, 25));
		AddSpawnPoint( "f_dcapital_106.Id4", "f_dcapital_106", Spot(1550.4592, 750.32086, 25));
		AddSpawnPoint( "f_dcapital_106.Id4", "f_dcapital_106", Spot(1974.4607, 333.89755, 25));
		AddSpawnPoint( "f_dcapital_106.Id4", "f_dcapital_106", Spot(2049.6304, 57.967354, 25));
		AddSpawnPoint( "f_dcapital_106.Id4", "f_dcapital_106", Spot(997.33795, 583.44775, 25));
		AddSpawnPoint( "f_dcapital_106.Id4", "f_dcapital_106", Spot(940.945, 1100.0085, 25));
		AddSpawnPoint( "f_dcapital_106.Id4", "f_dcapital_106", Spot(383.16498, 496.5327, 25));
		AddSpawnPoint( "f_dcapital_106.Id4", "f_dcapital_106", Spot(464.31467, 942.69507, 25));
		AddSpawnPoint( "f_dcapital_106.Id4", "f_dcapital_106", Spot(124.06618, 1532.9818, 25));
		AddSpawnPoint( "f_dcapital_106.Id4", "f_dcapital_106", Spot(631.6825, 1688.2207, 25));
		AddSpawnPoint( "f_dcapital_106.Id4", "f_dcapital_106", Spot(766.07745, 1467.8021, 25));
		AddSpawnPoint( "f_dcapital_106.Id4", "f_dcapital_106", Spot(375.53467, 1118.2108, 25));

		// Bishop_Point Spawn Points
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(643.9344, 862.66595, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(792.476, 547.5366, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(805.32715, 989.8706, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(682.8296, 1197.2854, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(1015.0156, 988.4554, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(1241.0231, 804.07697, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(1256.0792, 593.85834, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(1472.418, 757.9041, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(1772.8473, 797.6745, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(1648.8531, 441.6209, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(1968.0149, 408.98508, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(1931.1417, 178.02005, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(2161.8203, 170.98204, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(2134.886, 452.35495, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(2007.6487, 1493.9906, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(1909.8538, 1232.2178, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(1660.657, 1352.3508, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(1586.2521, 1112.2867, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(1464.6218, 1175.0615, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(1224.583, 1133.1199, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(609.14496, 1392.268, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(761.50226, 1674.7439, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(708.5084, 1907.3048, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(852.45056, 1748.131, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(413.90814, 1589.7897, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(81.85283, 1351.4479, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(247.47653, 1345.4458, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(254.97623, 1155.0797, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(316.59088, 1534.5084, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(452.92865, 566.3581, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(290.89148, 814.9885, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(795.4229, 700.2987, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(156.63245, 1433.307, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(1754.8733, 1278.1416, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(1854.5712, 437.19937, 25));
		AddSpawnPoint( "f_dcapital_106.Id5", "f_dcapital_106", Spot(1463.0989, 439.2968, 25));
		AddSpawnPoint( "f_dcapital_106.Id6", "f_dcapital_106", Spot(-379.9055, 334.49707, 25));
		AddSpawnPoint( "f_dcapital_106.Id6", "f_dcapital_106", Spot(-399.60873, -259.19556, 25));
		AddSpawnPoint( "f_dcapital_106.Id6", "f_dcapital_106", Spot(-125.30502, 29.019188, 25));
		AddSpawnPoint( "f_dcapital_106.Id6", "f_dcapital_106", Spot(-488.44266, 34.5053, 25));

	}
}
