//--- Melia Script -----------------------------------------------------------
// f_castle_101
//
//--- Description -----------------------------------------------------------
// Sets up the f_castle_101 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle101MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_castle_101", MonsterId.Bower_Guillotine, Properties("MHP", 827763, "MINPATK", 11145, "MAXPATK", 13600, "MINMATK", 11145, "MAXMATK", 13600, "DEF", 292656, "MDEF", 292656));
		AddPropertyOverrides("f_castle_101", MonsterId.Bower_Oblivion, Properties("MHP", 830831, "MINPATK", 11184, "MAXPATK", 13648, "MINMATK", 11184, "MAXMATK", 13648, "DEF", 295668, "MDEF", 295668));
		AddPropertyOverrides("f_castle_101", MonsterId.Bower_Interfere, Properties("MHP", 836441, "MINPATK", 11257, "MAXPATK", 13737, "MINMATK", 11257, "MAXMATK", 13737, "DEF", 301175, "MDEF", 301175));
		AddPropertyOverrides("f_castle_101", MonsterId.Bower_Obstructer, Properties("MHP", 843705, "MINPATK", 11350, "MAXPATK", 13852, "MINMATK", 11350, "MAXMATK", 13852, "DEF", 308306, "MDEF", 308306));

		// Monster Spawners --------------------------------

		AddSpawner("f_castle_101.Id1", MonsterId.Bower_Guillotine, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_101.Id2", MonsterId.Bower_Oblivion, 85, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_101.Id3", MonsterId.Bower_Interfere, 65, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_101.Id4", MonsterId.Bower_Obstructer, 50, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_101.Id5", MonsterId.Rootcrystal_01, 30, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Bower_Guillotine Spawn Points
		AddSpawnPoint( "f_castle_101.Id1", "f_castle_101", Spot(-1380.1002, -283.80923, 20));
		AddSpawnPoint( "f_castle_101.Id1", "f_castle_101", Spot(891.83167, -527.9453, 20));
		AddSpawnPoint( "f_castle_101.Id1", "f_castle_101", Spot(947.5481, -97.93442, 20));
		AddSpawnPoint( "f_castle_101.Id1", "f_castle_101", Spot(-575.0186, -472.19162, 20));
		AddSpawnPoint( "f_castle_101.Id1", "f_castle_101", Spot(-419.13745, -28.835037, 20));
		AddSpawnPoint( "f_castle_101.Id1", "f_castle_101", Spot(390.6173, 309.50128, 20));
		AddSpawnPoint( "f_castle_101.Id1", "f_castle_101", Spot(72.73604, 373.2989, 20));
		AddSpawnPoint( "f_castle_101.Id1", "f_castle_101", Spot(-177.14786, 381.24756, 20));
		AddSpawnPoint( "f_castle_101.Id1", "f_castle_101", Spot(-856.5251, 290.51053, 20));
		AddSpawnPoint( "f_castle_101.Id1", "f_castle_101", Spot(-86.23097, -488.5013, 20));
		AddSpawnPoint( "f_castle_101.Id1", "f_castle_101", Spot(129.76814, -145.40236, 20));
		AddSpawnPoint( "f_castle_101.Id1", "f_castle_101", Spot(228.78308, -589.68524, 20));
		AddSpawnPoint( "f_castle_101.Id1", "f_castle_101", Spot(-944.6874, -112.81125, 20));
		AddSpawnPoint( "f_castle_101.Id1", "f_castle_101", Spot(-1255.5686, -66.26461, 20));
		AddSpawnPoint( "f_castle_101.Id1", "f_castle_101", Spot(-1151.9305, -246.48398, 20));
		AddSpawnPoint( "f_castle_101.Id1", "f_castle_101", Spot(-545.92993, 235.02846, 20));
		AddSpawnPoint( "f_castle_101.Id1", "f_castle_101", Spot(607.21576, -400.86157, 20));
		AddSpawnPoint( "f_castle_101.Id1", "f_castle_101", Spot(363.9635, -363.20065, 20));

		// Bower_Oblivion Spawn Points
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-1123.139, -1531.873, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-1254.1868, -1465.4214, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-887.926, -1570.7755, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-810.7926, -1492.4459, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-559.84424, -1590.7437, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(294.02673, -1440.2163, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(830.319, -1588.1985, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(985.73047, -1443.6088, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(1593.2345, -1547.8042, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(1697.3044, -1385.5896, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(1818.65, -1568.0009, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(1683.7115, -1208.0574, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(1804.9819, -1080.4618, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(1783.385, -656.2662, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(1692.1864, -813.8287, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(1825.1339, -459.36, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(1723.2404, -525.385, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(1779.8556, -125.52686, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(1709.7394, 100.82401, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-1485.0165, -175.52266, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-1254.358, -270.2752, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-1430.8374, -380.55823, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-861.698, -79.33937, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-1350.0295, -57.888268, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-902.378, 390.2147, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-728.4744, 228.3747, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-19.61753, 452.89526, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(216.31233, 459.64252, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-124.11575, 260.80765, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(362.2659, 220.27422, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(619.28253, -161.83543, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(747.47455, -234.17424, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(797.3658, 12.241508, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(766.34467, -536.02527, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(1025.0735, -516.42596, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-138.51904, -612.9427, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-153.25716, -358.27908, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-13.3078, -180.5662, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(272.04718, -178.08693, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(338.02707, -946.84045, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(331.34912, -507.95728, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-298.5596, -73.77431, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-549.1152, -574.2454, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(848.71045, -395.3648, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(1093.0518, -59.96962, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(1455.1864, -1590.6682, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(1.5315704, -621.691, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-1032.1165, -264.259, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-1071.6631, 23.150513, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-1138.3489, -134.052, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-1256.5775, 194.55115, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(-912.0204, 227.1272, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(439.19568, -743.8356, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(241.24734, -707.5367, 35));
		AddSpawnPoint( "f_castle_101.Id2", "f_castle_101", Spot(122.54861, -485.3068, 35));

		// Bower_Interfere Spawn Points
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(-1214.9662, -1586.3881, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(-715.36145, -1577.9052, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(-925.49664, -1468.551, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(978.0057, -1588.9379, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(1502.7863, -1486.1366, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(1806.1195, -1222.5018, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(1817.4838, -802.5245, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(1816.2285, -15.926346, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(1821.5734, -347.7215, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(955.60754, -426.45462, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(1000.601, -15.943144, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(1201.0852, -119.40813, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(818.01935, -106.21394, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(377.8593, 394.93552, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(94.29369, 509.7389, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(-257.82782, 275.7993, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(-966.06366, 315.27084, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(-1375.8622, -170.67651, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(-1490.7173, -286.1217, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(-979.5956, -13.40202, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(-375.731, -145.41798, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(-643.56177, -363.77853, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(14.234985, -428.70493, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(90.85309, -296.05145, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(85.636444, -24.393847, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(-117.29921, -747.6571, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(810.9571, -637.53094, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(333.6452, -795.53174, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(128.75858, -678.104, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(-570.52136, 349.91528, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(-503.50974, -381.76215, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(1808.4142, -1424.4799, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(1219.308, -1522.2886, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(831.576, -1469.7834, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(-1299.6188, 47.84863, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(705.9884, -1572.5822, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(452.52353, -555.1835, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(644.9356, -528.76886, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(-635.45795, -149.4314, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(-1125.5312, 272.48398, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(-775.3606, 318.26346, 30));
		AddSpawnPoint( "f_castle_101.Id3", "f_castle_101", Spot(483.33734, -359.58673, 30));

		// Bower_Obstructer Spawn Points
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(-1296.4817, -353.45465, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(-923.2409, -203.01392, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(-815.2256, 423.7409, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(-60.8663, 320.99442, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(203.59633, 296.75723, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(512.3778, 290.3843, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(625.94116, -265.49167, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(1073.7126, -203.79366, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(725.5467, -432.8863, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(-434.8746, -508.2663, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(-471.09427, -86.97356, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(196.71124, -417.76678, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(354.0511, -661.34735, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(220.50809, -288.81906, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(697.5728, -87.17888, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(-633.12714, 263.95737, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(-403.86603, 297.58582, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(-488.9942, -200.39117, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(113.0816, 195.69412, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(-1035.5509, -151.40253, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(-1237.9738, -155.16136, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(-1188.6119, 13.929083, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(-1550.4553, -350.1173, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(-1596.0857, -138.1088, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(-685.22504, 357.9783, 30));
		AddSpawnPoint( "f_castle_101.Id4", "f_castle_101", Spot(537.6235, -489.89172, 30));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(293.48105, -1468.7367, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(-57.126537, -1542.101, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(-353.33798, -1545.38, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(-716.4608, -1515.3331, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(-1129.1115, -1539.6963, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(827.69403, -1526.8276, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(1237.733, -1531.7456, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(1641.6741, -1517.6975, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(1798.108, -1070.3312, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(1767.8243, -566.0096, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(1770.9183, -144.06491, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(758.4343, -350.20184, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(637.3164, -601.39014, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(90.38638, -695.0946, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(407.84344, -358.0198, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(107.1261, 82.39668, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(381.76663, 368.46198, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(685.676, 380.00714, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(-175.77289, 306.73627, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(-495.00372, -386.06293, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(-619.388, 292.45422, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(-1101.8197, 285.71457, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(-1294.5717, -56.23889, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(-1386.5865, -290.8253, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(-890.9678, -234.18524, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(-1064.9153, -872.08374, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(-655.38226, -961.42773, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(-238.61899, -765.23065, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(697.91644, -80.84832, 100));
		AddSpawnPoint( "f_castle_101.Id5", "f_castle_101", Spot(1003.2647, -616.369, 100));

	}
}
