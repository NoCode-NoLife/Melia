//--- Melia Script -----------------------------------------------------------
// d_prison_80
//
//--- Description -----------------------------------------------------------
// Sets up the d_prison_80 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DPrison80MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_prison_80", MonsterId.Defender_Spider_Blue, Properties("MHP", 424995, "MINPATK", 5966, "MAXPATK", 7234, "MINMATK", 5966, "MAXMATK", 7234, "DEF", 52724, "MDEF", 52724));
		AddPropertyOverrides("d_prison_80", MonsterId.Socket_Mage_Red, Properties("MHP", 427818, "MINPATK", 6002, "MAXPATK", 7279, "MINMATK", 6002, "MAXMATK", 7279, "DEF", 53624, "MDEF", 53624));
		AddPropertyOverrides("d_prison_80", MonsterId.NightMaiden_Bow_Red, Properties("MHP", 430718, "MINPATK", 6039, "MAXPATK", 7325, "MINMATK", 6039, "MAXMATK", 7325, "DEF", 54549, "MDEF", 54549));

		// Monster Spawners --------------------------------

		AddSpawner("d_prison_80.Id1", MonsterId.Defender_Spider_Blue, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_80.Id2", MonsterId.Socket_Mage_Red, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_80.Id3", MonsterId.NightMaiden_Bow_Red, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_80.Id4", MonsterId.Rootcrystal_05, 12, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_prison_80.Id5", MonsterId.Socket_Mage_Red, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_80.Id6", MonsterId.NightMaiden_Bow_Red, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_80.Id7", MonsterId.Defender_Spider_Blue, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// Defender_Spider_Blue Spawn Points
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(392.07397, -319.26932, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(216.81668, -214.58405, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(570.59106, -791.5913, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(559.31537, -911.2391, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(645.8641, -731.95624, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(788.2546, -733.7263, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(130.07915, -412.0998, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(327.58072, -209.91156, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(493.963, -1049.5221, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(243.10262, -1109.0609, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(1020.1736, -1849.2192, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(780.5602, -387.92554, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(788.3304, -1258.2806, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(793.02405, -1511.8987, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-746.7397, -348.32834, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-627.0202, -471.6324, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-656.38007, -251.58951, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-905.0652, -464.39288, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-973.07495, -270.7863, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-1249.8047, -364.02548, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-1162.4877, -222.9032, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-1087.6787, -48.37701, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-982.06445, 45.12162, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-1007.0068, 368.90448, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-1102.8293, 218.54373, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-875.25055, 191.32109, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-107.3782, -1.0619507, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(1086.1586, 574.92676, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(29.096312, 60.671753, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(889.97723, 297.3771, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(226.9671, 174.80675, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(981.68225, 300.6094, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(147.07515, 352.6882, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(336.62805, 277.81543, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(1178.6304, 33.06243, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-316.9678, 991.2976, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-172.99477, 1130.342, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-39.285583, 861.17084, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(438.20193, 300.13586, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(230.35246, 312.9597, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(1227.2749, 593.19324, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(1408.3901, 68.80566, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(1007.4465, 60.53201, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(800.3582, -499.9471, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(860.3364, -351.54382, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(495.09543, -295.4315, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(248.9885, -321.9834, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(94.66823, -259.97186, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(167.38858, -45.276222, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(819.27734, -1393.0679, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(775.1912, -1668.1581, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(825.1975, -1858.6578, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-1263.6677, -739.68604, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-1278.1437, -509.64258, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-455.63928, -176.2968, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-503.39963, -304.23645, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-902.11694, -116.12881, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-108.69481, 83.992905, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-36.051353, 49.197487, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-670.9404, 186.35573, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-794.07855, 378.5423, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(-319.29327, 1256.6792, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(11.090485, 1246.6255, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(1315.9183, 586.02844, 25));
		AddSpawnPoint( "d_prison_80.Id1", "d_prison_80", Spot(222.16364, 57.827454, 25));

		// Socket_Mage_Red Spawn Points
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(-40.83702, -641.80884, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(118.17838, -72.17118, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(-165.76839, -763.9124, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(243.50763, -383.352, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(-254.08223, -965.3682, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(-136.32202, -988.6883, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(117.951, -422.36865, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(-270.84116, -829.1619, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(218.4449, -113.9992, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(55.592525, -902.9088, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(1021.6125, -843.4152, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(-255.46437, -1058.0303, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(839.0405, -790.81024, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(586.6113, -727.55444, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(-291.14087, -690.67377, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(-44.378765, -757.7049, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(117.2125, -298.89706, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(294.27066, -39.694244, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(36.24742, -215.43614, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(269.42548, -240.02435, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(399.04178, -240.55615, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(800.30115, -328.9503, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(799.1919, -558.31104, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(758.37866, -771.2265, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(-114.62636, -1090.5035, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(68.01526, -727.93896, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(24.288414, -1079.5336, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(352.49323, -326.3697, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(-179.95135, -649.0302, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(-30.564455, -997.23987, 25));
		AddSpawnPoint( "d_prison_80.Id2", "d_prison_80", Spot(175.63191, -214.23747, 25));

		// NightMaiden_Bow_Red Spawn Points
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(1027.1884, 64.49453, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(1055.934, 479.7444, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(1379.58, 476.71878, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(1139.2902, 357.5053, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(1049.4376, 193.89029, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(1403.5128, 37.041607, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(745.8472, 295.70996, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(655.58563, 275.2011, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(221.8782, 404.37894, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(712.2471, 373.72827, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(169.02667, 239.33461, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(172.82841, 128.5617, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(88.05162, 179.30498, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(20.233646, 1116.7184, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(-43.0238, -50.815823, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(-257.8625, 1121.0676, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(-129.57426, 1285.9955, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(-52.37356, 951.93933, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(-218.06166, 932.9331, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(-903.6832, 248.7067, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(-173.918, -59.633877, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(-696.5252, 115.19294, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(-667.30524, 394.95212, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(-1100.7324, 257.98352, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(-179.68497, 36.448914, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(-973.4541, 352.07227, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(-1206.781, 370.31732, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(-1216.8337, 139.27728, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(-1183.5995, -27.583817, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(-943.3585, 21.960152, 25));
		AddSpawnPoint( "d_prison_80.Id3", "d_prison_80", Spot(106.01112, 82.91363, 25));

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "d_prison_80.Id4", "d_prison_80", Spot(400.1267, 313.3656, 100));
		AddSpawnPoint( "d_prison_80.Id4", "d_prison_80", Spot(925.43274, -1843.7831, 100));
		AddSpawnPoint( "d_prison_80.Id4", "d_prison_80", Spot(801.08673, -1521.149, 100));
		AddSpawnPoint( "d_prison_80.Id4", "d_prison_80", Spot(791.511, -1251.2739, 100));
		AddSpawnPoint( "d_prison_80.Id4", "d_prison_80", Spot(699.17633, -998.71423, 100));
		AddSpawnPoint( "d_prison_80.Id4", "d_prison_80", Spot(522.664, -1097.0083, 100));
		AddSpawnPoint( "d_prison_80.Id4", "d_prison_80", Spot(-686.386, -453.52414, 100));
		AddSpawnPoint( "d_prison_80.Id4", "d_prison_80", Spot(-12.895847, -1078.9581, 100));
		AddSpawnPoint( "d_prison_80.Id4", "d_prison_80", Spot(-259.7787, -732.6454, 100));
		AddSpawnPoint( "d_prison_80.Id4", "d_prison_80", Spot(-1174.6753, -239.63133, 100));
		AddSpawnPoint( "d_prison_80.Id4", "d_prison_80", Spot(157.31642, -377.39032, 100));
		AddSpawnPoint( "d_prison_80.Id4", "d_prison_80", Spot(684.60254, 310.11853, 100));
		AddSpawnPoint( "d_prison_80.Id4", "d_prison_80", Spot(1186.0953, 138.62161, 100));
		AddSpawnPoint( "d_prison_80.Id4", "d_prison_80", Spot(1173.5009, 477.8568, 100));
		AddSpawnPoint( "d_prison_80.Id4", "d_prison_80", Spot(-45.76524, 107.30096, 100));
		AddSpawnPoint( "d_prison_80.Id4", "d_prison_80", Spot(164.85416, 294.19278, 100));
		AddSpawnPoint( "d_prison_80.Id4", "d_prison_80", Spot(-625.19653, 271.8391, 100));
		AddSpawnPoint( "d_prison_80.Id4", "d_prison_80", Spot(-784.71124, 352.4047, 100));
		AddSpawnPoint( "d_prison_80.Id4", "d_prison_80", Spot(-1038.5715, -957.59515, 100));
		AddSpawnPoint( "d_prison_80.Id4", "d_prison_80", Spot(-26.483799, 1093.5981, 100));

		// Socket_Mage_Red Spawn Points
		AddSpawnPoint( "d_prison_80.Id5", "d_prison_80", Spot(-128.16396, -975.63116, 20));
		AddSpawnPoint( "d_prison_80.Id5", "d_prison_80", Spot(-218.87036, -839.89264, 20));
		AddSpawnPoint( "d_prison_80.Id5", "d_prison_80", Spot(-66.80504, -701.3258, 20));
		AddSpawnPoint( "d_prison_80.Id5", "d_prison_80", Spot(17.011934, -875.7912, 20));
		AddSpawnPoint( "d_prison_80.Id5", "d_prison_80", Spot(-78.50471, -872.0089, 20));
		AddSpawnPoint( "d_prison_80.Id5", "d_prison_80", Spot(-1.7175577, -1067.9379, 20));
		AddSpawnPoint( "d_prison_80.Id5", "d_prison_80", Spot(59.46382, -693.3776, 20));
		AddSpawnPoint( "d_prison_80.Id5", "d_prison_80", Spot(-271.14056, -1028.1764, 20));

		// NightMaiden_Bow_Red Spawn Points
		AddSpawnPoint( "d_prison_80.Id6", "d_prison_80", Spot(1061.7323, 301.45462, 25));
		AddSpawnPoint( "d_prison_80.Id6", "d_prison_80", Spot(1214.064, 345.11188, 25));
		AddSpawnPoint( "d_prison_80.Id6", "d_prison_80", Spot(1191.0543, 506.99792, 25));
		AddSpawnPoint( "d_prison_80.Id6", "d_prison_80", Spot(1073.9784, 540.2798, 25));
		AddSpawnPoint( "d_prison_80.Id6", "d_prison_80", Spot(1306.9287, 605.0773, 25));
		AddSpawnPoint( "d_prison_80.Id6", "d_prison_80", Spot(1285.8326, 511.36444, 25));
		AddSpawnPoint( "d_prison_80.Id6", "d_prison_80", Spot(1365.4232, 371.35727, 25));
		AddSpawnPoint( "d_prison_80.Id6", "d_prison_80", Spot(1363.0271, 220.7774, 25));
		AddSpawnPoint( "d_prison_80.Id6", "d_prison_80", Spot(1332.7003, 35.948513, 25));
		AddSpawnPoint( "d_prison_80.Id6", "d_prison_80", Spot(1036.9009, 41.96644, 25));

		// Defender_Spider_Blue Spawn Points
		AddSpawnPoint( "d_prison_80.Id7", "d_prison_80", Spot(1210.5709, 338.85504, 25));
		AddSpawnPoint( "d_prison_80.Id7", "d_prison_80", Spot(1062.3296, 525.6416, 25));
		AddSpawnPoint( "d_prison_80.Id7", "d_prison_80", Spot(1043.6469, 349.10352, 25));
		AddSpawnPoint( "d_prison_80.Id7", "d_prison_80", Spot(914.4909, 290.6782, 25));
		AddSpawnPoint( "d_prison_80.Id7", "d_prison_80", Spot(1038.6478, 182.07872, 25));
		AddSpawnPoint( "d_prison_80.Id7", "d_prison_80", Spot(1311.1183, 465.10437, 25));
		AddSpawnPoint( "d_prison_80.Id7", "d_prison_80", Spot(1387.165, 271.83545, 25));
		AddSpawnPoint( "d_prison_80.Id7", "d_prison_80", Spot(1366.8978, 112.5424, 25));
		AddSpawnPoint( "d_prison_80.Id7", "d_prison_80", Spot(1111.8647, 6.487335, 25));
		AddSpawnPoint( "d_prison_80.Id7", "d_prison_80", Spot(1239.0011, 600.1136, 25));

	}
}
