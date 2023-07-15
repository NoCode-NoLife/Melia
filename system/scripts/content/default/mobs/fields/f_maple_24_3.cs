//--- Melia Script -----------------------------------------------------------
// f_maple_24_3
//
//--- Description -----------------------------------------------------------
// Sets up the f_maple_24_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FMaple243MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_maple_24_3", MonsterId.Gland_Red, Properties("MHP", 718057, "MINPATK", 9735, "MAXPATK", 11866, "MINMATK", 9735, "MAXMATK", 11866, "DEF", 204036, "MDEF", 204036));
		AddPropertyOverrides("f_maple_24_3", MonsterId.Pennamayo, Properties("MHP", 720547, "MINPATK", 9767, "MAXPATK", 11906, "MINMATK", 9767, "MAXMATK", 11906, "DEF", 205815, "MDEF", 205815));
		AddPropertyOverrides("f_maple_24_3", MonsterId.Blueberrin, Properties("MHP", 723078, "MINPATK", 9799, "MAXPATK", 11946, "MINMATK", 9799, "MAXMATK", 11946, "DEF", 207624, "MDEF", 207624));

		// Monster Spawners --------------------------------

		AddSpawner("f_maple_24_3.Id1", MonsterId.Gland_Red, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_24_3.Id2", MonsterId.Pennamayo, 81, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_24_3.Id3", MonsterId.Blueberrin, 58, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_24_3.Id4", MonsterId.Rootcrystal_01, 30, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Gland_Red Spawn Points
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-1448.388, -884.18646, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-1747.3766, -1146.6986, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-1546.2784, -1164.454, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-1782.0017, -964.66296, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-1648.9253, -1019.2715, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-1818.0865, -1096.8392, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-1601.6415, -1241.7086, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-1651.4612, -1123.258, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-1734.707, -1050.5212, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-1466.3259, -819.6757, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-1538.7421, -1025.3373, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-1473.6918, -1008.4993, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-1224.391, -596.46625, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-1115.4963, -539.862, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-1073.6542, -386.87186, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-1032.1854, -467.63916, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-873.1135, -484.54486, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-834.07733, -386.38828, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-723.0109, -313.39313, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-813.71985, -214.18636, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-808.7469, -81.456314, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-932.88214, 12.817339, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-925.8062, -92.287704, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-1024.3217, -64.1889, 20));
		AddSpawnPoint( "f_maple_24_3.Id1", "f_maple_24_3", Spot(-1063.3188, -193.23659, 20));

		// Pennamayo Spawn Points
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-887.09216, 1167.3235, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1363.0825, 546.03406, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1305.4327, 357.7419, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1422.5823, 493.90475, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1480.9382, 307.92242, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1459.2451, 236.74303, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1312.6857, 270.28683, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1524.798, 262.68832, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1079.9297, 1132.8955, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1176.0283, 1078.005, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1061.0237, 1058.7188, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1028.1453, 1261.709, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1149.9506, 1187.2676, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-990.77167, 1173.4211, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-553.3076, 698.95795, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-580.1145, 623.4847, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-498.4396, 679.8652, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-622.3556, 488.0756, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-612.048, 419.0239, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-331.42886, 584.7793, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-348.0046, 543.8519, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-451.51083, 260.03806, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-515.97473, 243.89864, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-307.23932, 507.8649, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(26.395233, 1160.7289, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-5.179668, 954.99274, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(136.08946, 946.21497, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(296.2909, 1050.0582, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(290.06567, 1107.4783, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(207.61322, 985.81573, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(133.5035, 1196.2954, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(73.94923, 1223.9102, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(104.37628, 1142.2723, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-8.304842, 1024.7626, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-951.5597, -282.24908, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-929.3753, -336.06903, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-819.8864, -326.07077, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-877.00446, -268.91882, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1345.4475, 432.0047, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1255.977, 390.24512, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1296.4916, 476.3861, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1139.9515, 1273.1636, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1403.5718, 331.85623, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-715.6666, -389.72433, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-408.36966, 970.6039, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-164.94518, 83.00698, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-297.80936, 312.35715, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-301.48138, 385.31863, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-480.93964, 504.05753, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-483.5147, 711.9955, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-527.5262, 826.95374, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-443.73154, 862.1248, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-416.00354, 619.8332, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(82.92285, -417.5746, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(86.41386, -582.39233, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(259.7945, -639.8873, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(110.64273, -476.421, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(228.21138, -436.69254, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(325.07523, -469.32703, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(13.749407, -796.1876, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(3.243082, -878.57745, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(264.18124, -897.8291, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(191.35883, -696.60785, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(308.1754, -810.6628, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(397.74548, -730.2059, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(504.8684, -680.1482, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(495.2325, -560.867, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(637.9772, -509.4446, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(639.6696, -423.9675, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1095.0133, 979.7568, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1077.5602, 906.2568, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1294.9175, 753.65295, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1339.719, 685.7065, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-1399.042, 597.7008, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(84.0093, 911.3795, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(225.64532, 1132.5842, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(211.49559, 1199.9049, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(0.6686554, 1102.6293, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-65.74496, 1195.3058, 20));
		AddSpawnPoint( "f_maple_24_3.Id2", "f_maple_24_3", Spot(-139.45322, 1196.5012, 20));

		// Blueberrin Spawn Points
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-732.06757, -1155.5945, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-781.45856, -1239.6, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-766.6846, -1310.6613, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-647.265, -1284.6102, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-606.7164, -1157.1067, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-691.16815, -1230.9928, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-539.6431, -1194.0685, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(7.9906044, -748.78595, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(14.713204, -869.13873, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(59.029785, -983.79895, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(571.91223, -1216.3997, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(181.14473, -921.9795, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(224.71135, -807.42163, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(419.16302, -733.8893, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(737.4229, -1340.5365, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(504.4703, -690.77277, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(515.4502, -578.63165, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(389.2523, -448.62036, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(598.1574, -438.66208, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(298.92847, -648.08344, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(165.4822, -608.19006, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(770.2216, -1241.6543, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(348.2838, -822.8757, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(289.26782, -452.23718, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(464.74884, -1371.7803, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(381.76, -1355.7562, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(495.7779, -1425.9484, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(638.0951, -1381.7073, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(649.37775, -1274.5759, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(581.78076, -1474.5796, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-492.30237, 473.67975, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-443.4405, 158.39902, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-474.25858, 548.4042, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-445.38077, 487.1568, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-278.67902, 359.43585, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-507.19778, 173.32773, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-279.40912, 303.60452, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(379.21823, -1285.5823, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(524.9676, -1219.1193, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(486.458, -1258.5623, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-513.45795, -1134.9386, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-654.825, -1093.5562, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-299.19672, -1203.1633, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-212.7372, -1171.365, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-401.57288, -1219.6841, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(94.00303, -791.7281, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(183.07393, -692.41907, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(120.97695, -436.00174, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(858.9301, -1147.7609, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(859.97925, -1044.269, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-832.7063, -1098.4698, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-877.00836, -1056.3954, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-872.0996, -1320.8783, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(-844.3408, -1285.3765, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(161.61497, -979.77344, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(234.87943, -939.5013, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(628.4597, -820.233, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(628.4597, -820.233, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(843.496, -776.0369, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(790.42145, -772.3019, 25));
		AddSpawnPoint( "f_maple_24_3.Id3", "f_maple_24_3", Spot(826.1892, -993.5117, 25));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(-948.6919, -421.94177, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(-740.7805, 177.04556, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(-922.68713, -84.065895, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(-636.65985, 413.98303, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(-1255.9003, 1192.0856, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(-891.26587, 1148.9955, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(507.00958, -1342.2648, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(-585.70636, 945.6006, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(-1162.0621, 790.532, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(-409.6069, 673.17676, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(-312.10065, 283.0781, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(-9.812755, -6.279622, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(82.96579, -359.25903, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(82.39885, -703.8153, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(-1.4463387, -1018.9263, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(422.28967, -767.6423, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(798.37604, -762.13367, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(500.46317, -465.66113, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(724.33, -277.45767, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(651.8151, 54.707104, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(886.88513, -1127.4209, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(679.4632, -1372.102, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(-425.78146, -1181.322, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(-764.29706, -1219.3938, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(-1292.2235, -611.2023, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(-1496.7421, -930.4775, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(-1787.9542, -1167.9633, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(-1410.2887, 540.8629, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(-1410.4662, 263.76648, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(-267.89655, 1123.6757, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(106.48398, 1214.8577, 200));
		AddSpawnPoint( "f_maple_24_3.Id4", "f_maple_24_3", Spot(188.002, 944.6344, 200));

	}
}
