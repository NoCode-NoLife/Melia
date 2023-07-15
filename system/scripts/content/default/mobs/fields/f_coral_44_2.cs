//--- Melia Script -----------------------------------------------------------
// f_coral_44_2
//
//--- Description -----------------------------------------------------------
// Sets up the f_coral_44_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCoral442MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_coral_44_2.Id1", MonsterId.VarleGunner, 55, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_44_2.Id2", MonsterId.VarleHench, 49, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_44_2.Id3", MonsterId.NimrahLancer, 43, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_coral_44_2.Id4", MonsterId.Nimrahsoldier, 28, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_coral_44_2.Id5", MonsterId.NimrahDuke, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_coral_44_2.Id6", MonsterId.Rootcrystal_03, 30, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// VarleGunner Spawn Points
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(169.9778, 1452.172, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(99.61313, 1210.8826, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(95.1254, 997.13586, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(23.502731, 1045.757, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(98.95418, 1086.6814, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(395.42926, 972.23236, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(472.36844, 1053.9375, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(460.91098, 1142.562, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(-81.71565, 689.98, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(66.07419, 586.7424, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(-215.83272, 610.08264, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(53.449287, 244.37436, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(124.71303, 279.26074, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(-465.53882, 359.5324, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(-529.7173, -53.82889, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(-344.45416, 113.51897, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(-843.00836, -32.17452, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(-734.7457, -120.92442, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(-573.5398, 203.07484, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(-755.5253, 198.99892, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(474.4357, 471.67795, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(665.31, 560.4972, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(547.6173, 245.0505, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(751.48267, 207.92218, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(1097.6729, 1702.2955, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(930.42554, 333.6422, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(1047.5637, 393.52066, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(799.3255, 789.9481, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(766.89624, 689.23267, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(1149.41, 1228.9963, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(986.93866, 652.45544, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(937.61993, 1217.6426, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(1009.0555, 791.23315, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(1669.5753, 327.91156, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(1545.9039, 456.60867, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(1465.6681, 489.36917, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(1406.2867, 277.838, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(1457.502, 223.43918, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(1525.4961, 208.9768, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(-1491.3864, -47.22471, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(-1404.6123, -20.272263, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(-304.10947, -685.1372, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(-261.47275, -480.80344, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(264.2177, -392.59143, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(264.1435, -477.32028, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(290.08167, -555.0268, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(106.19098, -231.1626, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(-114.19513, -272.56085, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(466.70648, -1153.9429, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(515.6098, -877.589, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(743.0768, -444.0236, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(1010.9616, -367.7369, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(1009.7129, -530.9989, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(1073.0048, -1236.0471, 20));
		AddSpawnPoint( "f_coral_44_2.Id1", "f_coral_44_2", Spot(1191.6144, -1241.3203, 20));

		// VarleHench Spawn Points
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(504.5272, 1603.6248, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(430.62222, 1511.5365, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(531.1692, 1506.8923, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(397.05096, 1424.2452, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(112.42183, 1306.043, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(137.21803, 1366.5182, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(274.63272, 1149.4934, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(232.67336, 1287.4513, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(359.19016, 1221.3778, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(338.5281, 1322.6682, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(523.52985, 1276.5352, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(246.1037, 1030.1176, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-31.5015, 594.2027, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(37.65364, 468.7385, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-194.18115, 503.16956, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-339.2004, 465.45782, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-315.61002, 325.89343, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-462.77704, 139.80011, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-461.528, 11.81271, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-620.68036, -86.52201, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-247.8175, 931.11914, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-132.73877, 982.68176, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-429.75613, 971.50793, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(1451.9111, 344.3767, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(1563.2847, 374.59064, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(1558.1663, 285.83118, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-690.07404, 9.064911, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-294.3697, 215.1239, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-172.58096, -386.8295, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-11.38652, -453.7935, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(61.358215, -381.44638, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-235.21823, -587.0253, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(195.40993, -443.89786, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(251.55013, -273.52637, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-477.667, 305.51282, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-72.77108, 348.8713, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(121.65063, 1156.2078, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(424.9017, 1062.4512, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-546.2182, 220.2768, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-678.25055, 104.34486, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(31.84627, -230.67078, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(23.873772, -576.858, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(203.13666, -563.35535, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(274.6299, 341.59494, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(498.92438, 367.7635, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-1001.3851, -34.00908, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-67.448074, -726.8941, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(85.876114, 1039.4313, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-179.78888, 1150.8883, 40));
		AddSpawnPoint( "f_coral_44_2.Id2", "f_coral_44_2", Spot(-158.40611, 416.91812, 40));

		// NimrahLancer Spawn Points
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(620.32306, 474.638, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(671.66614, 347.47028, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(830.59595, 454.97647, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(938.96564, 436.33047, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(961.7194, 527.1041, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(912.6938, 647.9989, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(926.3331, 747.8838, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(756.34937, 553.1386, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(905.93207, 1268.001, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(1061.771, 1405.9281, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(938.7874, 1360.1715, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(1065.8582, 1544.8732, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(956.5347, 1563.0642, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(1208.2332, 1539.5996, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(874.95416, 1542.5442, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(1178.6132, 1321.3079, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(72.14228, 383.84372, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(4.7882423, 312.5706, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-101.76832, 294.58337, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-183.30135, 404.57767, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-53.338337, 400.7985, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-183.67404, 207.02898, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-628.3522, 76.34194, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-751.7038, 69.88228, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-1012.4554, -42.432186, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-923.73267, 291.665, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-1373.1495, 304.99405, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-1228.9775, 350.716, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-1250.5049, 473.6043, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-1434.5219, 397.17267, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-1430.7219, -285.9553, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-1487.6604, -169.94553, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-1590.3792, -42.368088, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-1556.257, -271.27463, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-1381.0977, -135.67511, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-1262.0667, -133.07439, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-1254.4391, -47.878822, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-71.88855, 56.259094, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-52.05583, -111.69648, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-129.18904, -541.4679, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-176.952, -688.7957, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(180.302, -558.5554, 40));
		AddSpawnPoint( "f_coral_44_2.Id3", "f_coral_44_2", Spot(-23.831486, -340.3909, 40));

		// Nimrahsoldier Spawn Points
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(21.781624, -744.51044, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(38.444984, -584.55194, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(257.61514, -628.06714, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(-66.26322, -662.92456, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(522.75775, -1057.8179, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(560.3782, -954.80804, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(690.78973, -940.68036, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(662.12695, -1090.8438, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(1114.6257, -1140.074, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(1261.8376, -1303.9042, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(1347.4534, -1255.618, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(1273.2114, -1154.2217, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(1259.7637, -1061.4941, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(1193.2567, -1010.0843, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(1038.3136, -1076.7368, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(1031.1598, -878.3867, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(902.56506, -656.2187, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(975.8072, -441.12595, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(911.3206, -493.1218, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(880.16296, -388.0041, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(943.58655, -290.92676, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(826.4382, -236.46193, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(919.5381, -180.74919, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(-931.5304, -619.9232, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(-870.13385, -698.8732, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(-784.24194, -649.26056, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(155.6433, -764.1248, 40));
		AddSpawnPoint( "f_coral_44_2.Id4", "f_coral_44_2", Spot(625.8666, -1009.4104, 40));

		// NimrahDuke Spawn Points
		AddSpawnPoint( "f_coral_44_2.Id5", "f_coral_44_2", Spot(-696.1463, -616.7492, 40));
		AddSpawnPoint( "f_coral_44_2.Id5", "f_coral_44_2", Spot(-41.707764, -570.98755, 40));
		AddSpawnPoint( "f_coral_44_2.Id5", "f_coral_44_2", Spot(149.58249, -490.67743, 40));
		AddSpawnPoint( "f_coral_44_2.Id5", "f_coral_44_2", Spot(1079.4127, -975.6209, 40));
		AddSpawnPoint( "f_coral_44_2.Id5", "f_coral_44_2", Spot(790.9087, -361.70648, 40));
		AddSpawnPoint( "f_coral_44_2.Id5", "f_coral_44_2", Spot(-1606.0293, -145.85924, 40));
		AddSpawnPoint( "f_coral_44_2.Id5", "f_coral_44_2", Spot(-1321.9766, 385.99747, 40));
		AddSpawnPoint( "f_coral_44_2.Id5", "f_coral_44_2", Spot(-195.18874, 305.3124, 40));
		AddSpawnPoint( "f_coral_44_2.Id5", "f_coral_44_2", Spot(1086.286, 465.45578, 40));
		AddSpawnPoint( "f_coral_44_2.Id5", "f_coral_44_2", Spot(867.5333, 1417.4973, 40));

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(-774.0746, -638.7964, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(1116.9631, -1064.7745, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(884.09204, -501.0433, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(862.6964, -273.92908, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(655.08545, -1047.2396, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(424.16483, -913.49536, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(-185.09178, -653.9463, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(226.63731, -626.2187, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(-83.778595, -351.65955, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(221.41437, -330.16833, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(-743.6211, -513.00757, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(-946.9471, -751.1024, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(-1555.7465, -139.81964, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(-1274.129, -78.21413, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(-1447.7328, 300.6479, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(-1268.6278, 462.76044, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(-735.5592, 55.668488, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(-436.99487, 250.4857, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(-154.49533, 380.78928, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(-176.68015, 613.7498, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(60.398224, 427.2562, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(-486.87946, 1015.8176, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(-239.71901, 1078.7789, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(207.78444, 1090.3486, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(309.6203, 1440.4553, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(466.37915, 1155.777, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(1030.8582, 1451.5206, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(1134.8046, 1513.761, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(977.6467, 781.74524, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(896.2757, 501.40323, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(668.33344, 424.06375, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(1502.7192, 282.76816, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(1445.0688, 469.76987, 40));
		AddSpawnPoint( "f_coral_44_2.Id6", "f_coral_44_2", Spot(1627.7405, 413.13293, 40));

	}
}
