//--- Melia Script -----------------------------------------------------------
// f_whitetrees_22_1
//
//--- Description -----------------------------------------------------------
// Sets up the f_whitetrees_22_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FWhitetrees221MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_whitetrees_22_1.Id1", MonsterId.Umblet, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_whitetrees_22_1.Id2", MonsterId.Umbra_Mage, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_whitetrees_22_1.Id3", MonsterId.Umbra_Warrior, 16, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_whitetrees_22_1.Id4", MonsterId.Atti, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_1.Id5", MonsterId.Richring, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_1.Id6", MonsterId.Beetow_White, 50, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_whitetrees_22_1.Id7", MonsterId.Rootcrystal_01, 18, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Umblet Spawn Points
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(92.58835, -1174.3264, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(250.57358, -1066.0288, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(206.14636, -870.5615, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(194.63083, -1257.3953, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(364.43585, -948.88983, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-756.5695, -862.5242, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-590.7917, -848.81775, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-591.02686, -714.27246, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-496.49512, -641.8104, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-615.5693, -575.1327, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-1129.1461, -69.358475, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-1013.0732, -41.037773, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-950.60547, 67.27862, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-1033.051, 155.0265, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-1082.4191, 21.13934, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-724.6213, 356.80637, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-628.9668, 331.562, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-610.24927, 227.64403, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-490.5059, 512.36224, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-381.97342, 437.49567, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(850.7694, 1057.5425, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(754.2657, 993.2617, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(720.6189, 855.35095, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(888.5861, 743.61615, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(953.88324, 911.26074, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(1153.5842, 726.31177, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(1310.9924, 764.49097, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(1334.7463, 891.7238, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(1149.3733, 610.41943, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(1269.5381, 553.3161, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-1029.0088, 784.0696, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-937.3548, 862.4126, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-1023.5745, 963.36523, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-959.86615, 1078.888, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-1162.8652, 1053.0193, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-1416.3768, 751.94293, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-1314.6476, 810.27844, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-1302.9392, 895.913, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-1373.377, 965.47205, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-1516.8871, 897.5647, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(441.61472, -1752.6265, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(540.6842, -1750.4979, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(638.5012, -1782.7341, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(375.371, -1565.3821, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(488.45798, -1508.0675, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-680.33923, -751.1456, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-773.95514, -795.21564, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-406.11157, 280.58823, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-1078.4419, 89.68855, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-1164.7701, 5.848091, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(-1121.1293, 892.4311, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(863.71704, 854.6999, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(1078.8278, 1058.0128, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(1217.6329, 909.4553, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Spot(1051.977, 640.55725, 40));

		// Umbra_Mage Spawn Points
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(405.31357, -1820.4929, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(499.4796, -1813.248, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(584.222, -1853.7704, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(258.75922, -1651.3956, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(285.6374, -1754.1531, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(55.670944, -1285.2892, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(182.79034, -1173.6189, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(263.0395, -960.19684, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(283.5212, -807.00665, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(105.19591, -1055.1394, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-510.1729, -520.3471, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-711.4981, -746.51953, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-1020.8547, -623.49225, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-871.01904, -477.99286, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-771.0329, -461.39096, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-1036.8914, 93.074394, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-1177.8069, -1.4577007, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-1136.4949, 195.48494, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-1249.5349, -12.178665, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-1198.1743, -98.6782, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-510.40067, 230.19418, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-340.20273, 288.43417, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-592.94055, 523.2717, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-717.7508, 465.45306, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-454.10245, 335.11032, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(712.708, 771.528, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(819.1355, 934.595, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(817.1283, 834.5469, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(982.55383, 1072.1862, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(1122.1703, 1074.6428, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(1269.1206, 667.7729, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(1401.238, 622.8274, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(1472.8201, 794.28827, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(1277.1257, 1016.5652, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(1020.9496, 578.92487, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-1542.6632, 784.327, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-1470.6909, 1016.1173, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-1610.211, 971.6742, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-1703.7189, 910.18304, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-1470.5452, 680.9516, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-1048.5005, 692.1076, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-933.8131, 754.9794, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-1085.1664, 1078.1357, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-1249.2982, 1042.78, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Spot(-1168.5878, 663.76917, 40));

		// Umbra_Warrior Spawn Points
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(758.48126, -1691.8607, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(628.6246, -1687.6084, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(460.97913, -1647.3523, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(359.93127, -1677.9171, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(597.04297, -1575.039, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(-66.89849, -1224.1882, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(6.0052047, -1104.0903, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(161.58322, -959.57623, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(88.76277, -844.828, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(73.68486, -728.3169, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(-909.01263, -740.33545, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(-888.5516, -618.6671, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(-743.97815, -524.0599, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(-807.46906, -679.03766, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(-705.28156, -629.7012, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(775.0408, 677.0048, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(1065.44, 979.2428, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(1194.0455, 957.1854, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(1024.8451, 821.2953, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(1021.3084, 675.1238, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(902.8612, 609.3544, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(1175.1392, 842.74866, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(-1204.1791, 146.78253, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(-1204.066, 61.127373, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(-625.72534, 445.7902, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(-517.3735, 398.38788, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(-1319.8533, 682.4321, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(-1130.2589, 768.9688, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(-1228.5498, 765.2725, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(-1202.2593, 876.96423, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(-1147.7346, 971.1263, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(133.28366, 1287.2888, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(203.33833, 1197.849, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(296.2982, 1371.5463, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(540.0843, 1323.5137, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(405.7878, 1450.7083, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(416.73615, 1597.488, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(551.4003, 1566.4062, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(642.4714, 1438.1843, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Spot(358.041, 1226.1997, 40));

		// Atti Spawn Points
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(1512.0918, -679.4252, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(1488.168, -787.56665, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(1642.9514, -710.4825, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(1006.3525, -998.23773, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(1158.2593, -900.7734, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(1034.1316, -770.36676, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(849.959, -836.5269, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(879.2123, -962.15564, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(910.1515, -717.68726, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(1266.7991, -835.62384, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(689.4084, -264.90244, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(773.73267, -100.89743, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(833.70325, -333.26093, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(-158.263, -1113.9989, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(-73.88489, -1069.4468, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(-111.86127, -974.46747, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(-2.3839064, -953.99005, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(-53.42275, -823.0762, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(1939.042, -483.63516, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(2013.8081, -383.86713, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(2056.1614, -577.8717, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(2211.3943, -589.18604, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(2046.9843, -471.53067, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(752.3184, -899.8748, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(703.38324, -834.36945, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(1123.3778, -984.0118, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(833.85657, -618.27496, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(1019.2446, -889.63434, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(-234.69499, -1023.6103, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(168.85504, -773.368, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(676.8401, -89.05741, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(948.04895, -289.89746, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(1635.1187, -801.2696, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(1522.5537, -879.15344, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(2161.4077, -391.3447, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(1166.959, -833.76874, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(805.5696, -779.864, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(607.9242, -871.9646, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(284.8574, -882.53894, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(161.6232, -859.8686, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(-192.34512, -938.3565, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(947.78815, -167.24623, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Spot(787.14, 0.039510727, 40));

		// Richring Spawn Points
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(803.3277, -16.577831, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(894.4603, -13.108078, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(846.3523, -109.05502, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(946.5196, -83.62416, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(832.3497, -206.17982, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(977.7318, -170.06277, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(1029.5737, -244.46252, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(627.7323, -201.58246, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(448.91876, -243.06345, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(333.35464, -275.96857, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(176.10483, -348.09433, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(122.98672, -265.15414, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(57.397438, -194.37054, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(-41.18982, -238.22823, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(-102.70972, -306.5582, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(-16.526009, -358.523, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(44.497807, -308.6934, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(94.81789, -369.65552, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(15.427748, -433.2106, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(-376.35995, -420.18225, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(-247.7611, -337.7866, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(-803.6427, -582.383, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(-976.7762, -542.8827, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(368.35748, 241.00758, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(202.23709, 260.29935, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(208.39824, 146.98523, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(321.13, 106.83117, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(418.87762, 342.02185, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(152.04118, 354.425, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(70.71942, 399.8562, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(158.21677, 508.49506, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(257.18253, 549.3755, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(345.82358, 492.11118, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(-728.89374, -509.7821, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(-577.40247, -530.03973, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(157.47406, -228.96066, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(732.01624, -62.009167, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(729.90515, -301.6494, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(313.68164, 350.16357, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(442.1401, 256.93954, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(327.101, 441.2986, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(-862.86755, -646.6256, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Spot(-984.31647, -645.54865, 40));

		// Beetow_White Spawn Points
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(2154.401, -305.33435, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(2193.2217, -392.4614, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(2335.9775, -478.34937, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(2296.3484, -289.8188, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(2377.4558, -379.3597, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(262.12982, 316.0849, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(228.16183, 413.63794, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(308.61032, 407.19135, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(430.00726, 445.91714, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(-611.18195, 1281.7788, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(-602.81964, 1184.597, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(-525.3137, 1341.4956, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(-434.69672, 1433.612, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(-450.8522, 1300.82, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(-522.2119, 1220.8329, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(-473.22858, 1135.8383, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(-334.64386, 1137.3223, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(-396.31827, 1214.4387, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(-295.86584, 1265.8022, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(-376.3119, 1343.5698, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(218.99048, 1325.6903, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(261.7546, 1254.5, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(348.7232, 1326.837, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(459.22314, 1269.7241, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(329.9454, 1493.9597, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(507.64774, 1441.4548, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(491.1603, 1656.1532, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(628.92975, 1531.7178, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(765.00946, -785.03955, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(926.6017, -800.22363, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(1077.751, -852.1316, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(860.43604, -1133.4236, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(806.3522, -1228.4446, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(681.7225, -1341.1611, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(556.9841, -875.65656, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(408.09015, 63.983723, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(-174.2886, 434.83997, 40));
		AddSpawnPoint( "f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Spot(1736.1654, -594.21045, 40));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Spot(261.83908, -1104.8813, 10));
		AddSpawnPoint( "f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Spot(482.04504, -1751.5677, 10));
		AddSpawnPoint( "f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Spot(1036.6305, -891.4196, 10));
		AddSpawnPoint( "f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Spot(-148.729, -952.5821, 10));
		AddSpawnPoint( "f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Spot(-778.7704, -709.3184, 10));
		AddSpawnPoint( "f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Spot(827.79224, -219.47096, 10));
		AddSpawnPoint( "f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Spot(1606.4185, -730.91095, 10));
		AddSpawnPoint( "f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Spot(2181.6968, -396.5505, 10));
		AddSpawnPoint( "f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Spot(114.34489, -303.52484, 10));
		AddSpawnPoint( "f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Spot(222.94662, 319.9997, 10));
		AddSpawnPoint( "f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Spot(-491.97147, 398.63773, 10));
		AddSpawnPoint( "f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Spot(-1118.7635, 7.957242, 10));
		AddSpawnPoint( "f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Spot(1280.9894, 721.6697, 10));
		AddSpawnPoint( "f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Spot(976.03577, 728.3214, 10));
		AddSpawnPoint( "f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Spot(927.6657, 1078.1407, 10));
		AddSpawnPoint( "f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Spot(362.13968, 1368.7798, 10));
		AddSpawnPoint( "f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Spot(-412.38123, 1217.5302, 10));
		AddSpawnPoint( "f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Spot(-1258.9247, 862.60254, 10));

	}
}
