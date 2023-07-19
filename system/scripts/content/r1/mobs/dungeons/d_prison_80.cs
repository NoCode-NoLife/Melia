//--- Melia Script -----------------------------------------------------------
// d_prison_80
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Solitary Cells' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DPrison80MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_prison_80", MonsterId.Defender_Spider_Blue, Properties("MHP", 424995, "MINPATK", 5966, "MAXPATK", 7234, "MINMATK", 5966, "MAXMATK", 7234, "DEF", 52724, "MDEF", 52724));
		AddPropertyOverrides("d_prison_80", MonsterId.Socket_Mage_Red, Properties("MHP", 427818, "MINPATK", 6002, "MAXPATK", 7279, "MINMATK", 6002, "MAXMATK", 7279, "DEF", 53624, "MDEF", 53624));
		AddPropertyOverrides("d_prison_80", MonsterId.NightMaiden_Bow_Red, Properties("MHP", 430718, "MINPATK", 6039, "MAXPATK", 7325, "MINMATK", 6039, "MAXMATK", 7325, "DEF", 54549, "MDEF", 54549));
		AddPropertyOverrides("d_prison_80", MonsterId.Boss_Grinender_Q1, Properties("MHP", 2211819, "MINPATK", 14586, "MAXPATK", 17692, "MINMATK", 14586, "MAXMATK", 17692, "DEF", 133191, "MDEF", 133191));

		// Monster Spawners ---------------------------------

		AddSpawner("d_prison_80.Id1", MonsterId.Defender_Spider_Blue, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_80.Id2", MonsterId.Socket_Mage_Red, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_80.Id3", MonsterId.NightMaiden_Bow_Red, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_80.Id4", MonsterId.Rootcrystal_05, 9, 12, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_prison_80.Id5", MonsterId.Defender_Spider_Blue, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_80.Id6", MonsterId.Socket_Mage_Red, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_80.Id7", MonsterId.NightMaiden_Bow_Red, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Defender_Spider_Blue' GenType 1 Spawn Points
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(392.07397, -319.26932, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(216.81668, -214.58405, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(570.59106, -791.5913, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(559.31537, -911.2391, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(645.8641, -731.95624, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(788.2546, -733.7263, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(130.07915, -412.0998, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(327.58072, -209.91156, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(493.963, -1049.5221, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(243.10262, -1109.0609, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(1020.1736, -1849.2192, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(780.5602, -387.92554, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(788.3304, -1258.2806, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(793.02405, -1511.8987, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-746.7397, -348.32834, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-627.0202, -471.6324, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-656.38007, -251.58951, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-905.0652, -464.39288, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-973.07495, -270.7863, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-1249.8047, -364.02548, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-1162.4877, -222.9032, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-1087.6787, -48.37701, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-982.06445, 45.12162, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-1007.0068, 368.90448, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-1102.8293, 218.54373, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-875.25055, 191.32109, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-107.3782, -1.0619507, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(1086.1586, 574.92676, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(29.096312, 60.671753, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(889.97723, 297.3771, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(226.9671, 174.80675, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(981.68225, 300.6094, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(147.07515, 352.6882, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(336.62805, 277.81543, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(1178.6304, 33.06243, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-316.9678, 991.2976, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-172.99477, 1130.342, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-39.285583, 861.17084, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(438.20193, 300.13586, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(230.35246, 312.9597, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(1227.2749, 593.19324, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(1408.3901, 68.80566, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(1007.4465, 60.53201, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(800.3582, -499.9471, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(860.3364, -351.54382, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(495.09543, -295.4315, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(248.9885, -321.9834, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(94.66823, -259.97186, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(167.38858, -45.276222, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(819.27734, -1393.0679, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(775.1912, -1668.1581, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(825.1975, -1858.6578, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-1263.6677, -739.68604, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-1278.1437, -509.64258, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-455.63928, -176.2968, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-503.39963, -304.23645, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-902.11694, -116.12881, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-108.69481, 83.992905, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-36.051353, 49.197487, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-670.9404, 186.35573, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-794.07855, 378.5423, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-319.29327, 1256.6792, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(11.090485, 1246.6255, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(1315.9183, 586.02844, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(222.16364, 57.827454, 25));

		// 'Socket_Mage_Red' GenType 2 Spawn Points
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-40.83702, -641.80884, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(118.17838, -72.17118, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-165.76839, -763.9124, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(243.50763, -383.352, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-254.08223, -965.3682, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-136.32202, -988.6883, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(117.951, -422.36865, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-270.84116, -829.1619, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(218.4449, -113.9992, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(55.592525, -902.9088, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(1021.6125, -843.4152, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-255.46437, -1058.0303, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(839.0405, -790.81024, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(586.6113, -727.55444, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-291.14087, -690.67377, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-44.378765, -757.7049, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(117.2125, -298.89706, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(294.27066, -39.694244, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(36.24742, -215.43614, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(269.42548, -240.02435, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(399.04178, -240.55615, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(800.30115, -328.9503, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(799.1919, -558.31104, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(758.37866, -771.2265, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-114.62636, -1090.5035, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(68.01526, -727.93896, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(24.288414, -1079.5336, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(352.49323, -326.3697, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-179.95135, -649.0302, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-30.564455, -997.23987, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(175.63191, -214.23747, 25));

		// 'NightMaiden_Bow_Red' GenType 3 Spawn Points
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(1027.1884, 64.49453, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(1055.934, 479.7444, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(1379.58, 476.71878, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(1139.2902, 357.5053, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(1049.4376, 193.89029, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(1403.5128, 37.041607, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(745.8472, 295.70996, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(655.58563, 275.2011, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(221.8782, 404.37894, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(712.2471, 373.72827, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(169.02667, 239.33461, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(172.82841, 128.5617, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(88.05162, 179.30498, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(20.233646, 1116.7184, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-43.0238, -50.815823, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-257.8625, 1121.0676, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-129.57426, 1285.9955, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-52.37356, 951.93933, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-218.06166, 932.9331, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-903.6832, 248.7067, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-173.918, -59.633877, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-696.5252, 115.19294, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-667.30524, 394.95212, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-1100.7324, 257.98352, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-179.68497, 36.448914, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-973.4541, 352.07227, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-1206.781, 370.31732, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-1216.8337, 139.27728, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-1183.5995, -27.583817, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-943.3585, 21.960152, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(106.01112, 82.91363, 25));

		// 'Rootcrystal_05' GenType 6 Spawn Points
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(400.1267, 313.3656, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(925.43274, -1843.7831, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(801.08673, -1521.149, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(791.511, -1251.2739, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(699.17633, -998.71423, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(522.664, -1097.0083, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(-686.386, -453.52414, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(-12.895847, -1078.9581, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(-259.7787, -732.6454, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(-1174.6753, -239.63133, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(157.31642, -377.39032, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(684.60254, 310.11853, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(1186.0953, 138.62161, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(1173.5009, 477.8568, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(-45.76524, 107.30096, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(164.85416, 294.19278, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(-625.19653, 271.8391, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(-784.71124, 352.4047, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(-1038.5715, -957.59515, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(-26.483799, 1093.5981, 100));

		// 'Defender_Spider_Blue' GenType 32 Spawn Points
		AddSpawnPoint("d_prison_80.Id5", "d_prison_80", Rectangle(1210.5709, 338.85504, 25));
		AddSpawnPoint("d_prison_80.Id5", "d_prison_80", Rectangle(1062.3296, 525.6416, 25));
		AddSpawnPoint("d_prison_80.Id5", "d_prison_80", Rectangle(1043.6469, 349.10352, 25));
		AddSpawnPoint("d_prison_80.Id5", "d_prison_80", Rectangle(914.4909, 290.6782, 25));
		AddSpawnPoint("d_prison_80.Id5", "d_prison_80", Rectangle(1038.6478, 182.07872, 25));
		AddSpawnPoint("d_prison_80.Id5", "d_prison_80", Rectangle(1311.1183, 465.10437, 25));
		AddSpawnPoint("d_prison_80.Id5", "d_prison_80", Rectangle(1387.165, 271.83545, 25));
		AddSpawnPoint("d_prison_80.Id5", "d_prison_80", Rectangle(1366.8978, 112.5424, 25));
		AddSpawnPoint("d_prison_80.Id5", "d_prison_80", Rectangle(1111.8647, 6.487335, 25));
		AddSpawnPoint("d_prison_80.Id5", "d_prison_80", Rectangle(1239.0011, 600.1136, 25));

		// 'Socket_Mage_Red' GenType 33 Spawn Points
		AddSpawnPoint("d_prison_80.Id6", "d_prison_80", Rectangle(-128.16396, -975.63116, 20));
		AddSpawnPoint("d_prison_80.Id6", "d_prison_80", Rectangle(-218.87036, -839.89264, 20));
		AddSpawnPoint("d_prison_80.Id6", "d_prison_80", Rectangle(-66.80504, -701.3258, 20));
		AddSpawnPoint("d_prison_80.Id6", "d_prison_80", Rectangle(17.011934, -875.7912, 20));
		AddSpawnPoint("d_prison_80.Id6", "d_prison_80", Rectangle(-78.50471, -872.0089, 20));
		AddSpawnPoint("d_prison_80.Id6", "d_prison_80", Rectangle(-1.7175577, -1067.9379, 20));
		AddSpawnPoint("d_prison_80.Id6", "d_prison_80", Rectangle(59.46382, -693.3776, 20));
		AddSpawnPoint("d_prison_80.Id6", "d_prison_80", Rectangle(-271.14056, -1028.1764, 20));

		// 'NightMaiden_Bow_Red' GenType 34 Spawn Points
		AddSpawnPoint("d_prison_80.Id7", "d_prison_80", Rectangle(1061.7323, 301.45462, 25));
		AddSpawnPoint("d_prison_80.Id7", "d_prison_80", Rectangle(1214.064, 345.11188, 25));
		AddSpawnPoint("d_prison_80.Id7", "d_prison_80", Rectangle(1191.0543, 506.99792, 25));
		AddSpawnPoint("d_prison_80.Id7", "d_prison_80", Rectangle(1073.9784, 540.2798, 25));
		AddSpawnPoint("d_prison_80.Id7", "d_prison_80", Rectangle(1306.9287, 605.0773, 25));
		AddSpawnPoint("d_prison_80.Id7", "d_prison_80", Rectangle(1285.8326, 511.36444, 25));
		AddSpawnPoint("d_prison_80.Id7", "d_prison_80", Rectangle(1365.4232, 371.35727, 25));
		AddSpawnPoint("d_prison_80.Id7", "d_prison_80", Rectangle(1363.0271, 220.7774, 25));
		AddSpawnPoint("d_prison_80.Id7", "d_prison_80", Rectangle(1332.7003, 35.948513, 25));
		AddSpawnPoint("d_prison_80.Id7", "d_prison_80", Rectangle(1036.9009, 41.96644, 25));
	}
}
