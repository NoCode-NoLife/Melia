//--- Melia Script -----------------------------------------------------------
// d_abbey_22_4
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Narvas Temple' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DAbbey224MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_abbey_22_4.Id1", MonsterId.Rootcrystal_05, 14, 18, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_4.Id2", MonsterId.Hohen_Mage_Black, 72, 95, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_4.Id3", MonsterId.Nook, 18, 24, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_4.Id4", MonsterId.Boor, 20, 26, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_4.Id5", MonsterId.Mangosting, 26, 34, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_4.Id6", MonsterId.Half_Mangosting, 35, 46, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_4.Id7", MonsterId.Hohen_Mage_Black, 4, 5, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_4.Id8", MonsterId.Hohen_Mage_Black, 4, 5, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_4.Id9", MonsterId.Rootcrystal_01, 13, 17, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 43 Spawn Points
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(535.0267, 1267.9589, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(1518.588, 1284.9082, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-54.45205, 1281.2676, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-669.49817, 1252.2528, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-1475.5563, 1271.5205, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-27.649975, 666.7397, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(526.7927, 647.52216, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-658.3726, 667.5832, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-1484.193, 610.87305, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-244.48865, 137.16592, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(541.03375, 76.005165, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(819.81287, 45.655205, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-669.6834, 48.071926, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-1534.2117, 55.064034, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-1591.4009, -606.10925, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-665.9617, -500.87988, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-700.3515, -1085.2621, 20));
		AddSpawnPoint("d_abbey_22_4.Id1", "d_abbey_22_4", Rectangle(-176.61267, -1085.4731, 20));

		// 'Hohen_Mage_Black' GenType 50 Spawn Points
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(1471.3726, 1199.1569, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(1444.5936, 1330.8795, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(1271.5151, 1328.6455, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(1276.0623, 1162.579, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(1592.0219, 1175.8881, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(797.08386, 1325.0914, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(786.3282, 1226.2336, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(365.6346, 1346.6277, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(366.46375, 1209.4756, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(551.7984, 1327.8927, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(36.953693, 1348.5907, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(30.23312, 1229.3728, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-138.90366, 1222.5476, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-150.60976, 1350.5216, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-528.2828, 1179.8086, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-543.6679, 1399.656, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-683.6096, 1402.0605, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-688.6461, 1178.0645, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-807.7574, 1409.1886, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-834.08673, 1177.8286, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1119.8301, 1338.0636, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1125.2316, 1263.1421, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1324.1575, 1357.3871, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1328.965, 1220.8406, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1343.598, 1083.74, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1546.3569, 1376.4452, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1655.099, 1269.0193, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1540.1312, 1152.7598, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1443.2686, 1273.5272, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1530.2587, 1035.4052, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1742.2635, 1052.132, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1739.0833, 1225.5083, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1748.323, 1377.6769, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-47.181976, 1117.5175, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-53.377922, 906.59827, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(13.057842, 906.14984, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-721.7602, 560.0278, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-721.60693, 709.7169, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-554.2563, 534.3432, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-500.11426, 707.5981, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1287.3036, 616.0384, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1272.0077, 710.9369, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1405.5059, 455.40115, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1382.1862, 586.10284, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1558.5405, 716.638, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1564.5936, 594.35034, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(349.32678, 596.0118, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(356.3553, 708.8356, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(448.08972, 515.1614, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(474.86197, 794.7205, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-68.11615, 457.2457, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-64.43207, 294.6978, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-384.91873, 148.09436, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-566.20734, -39.073338, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-546.94916, 126.54872, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-775.1817, 147.81418, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-776.19745, -45.07048, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-796.0316, -358.8775, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-810.51086, -508.402, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-570.0848, -573.45, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-579.22516, -392.8914, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(193.21887, 177.079, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(482.51987, 175.93304, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(465.36008, -64.421455, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(682.8197, -63.709297, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(686.1903, 126.39429, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(854.1362, -114.39749, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(910.7638, 111.54321, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-763.961, -1182.2463, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-592.45483, -1123.1888, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-469.019, -890.02905, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-320.82275, -912.0765, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-517.01245, -1119.3627, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-462.50983, -1236.4956, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-303.43222, -1000.6979, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-436.50748, -1136.811, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-214.9078, -913.47876, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-22.188148, -1009.408, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-463.783, -1021.3395, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-359.56476, -1072.3594, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-738.8442, -587.2114, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-613.6647, -512.47876, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-24.51455, 793.30005, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-33.69419, 1016.9534, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-254.58937, 1318.5967, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-842.5344, 1278.2766, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(36.218502, 171.63065, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-40.833595, 346.92615, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-108.73986, 365.56552, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-705.951, -189.35793, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-933.80273, 119.78569, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-1031.9557, 139.8162, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-131.50276, 142.9512, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-670.53015, -718.0589, 40));
		AddSpawnPoint("d_abbey_22_4.Id2", "d_abbey_22_4", Rectangle(-772.2893, -334.82373, 40));

		// 'Nook' GenType 51 Spawn Points
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(1642.5906, 1093.4036, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(1562.2181, 1392.6995, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(1394.1401, 1117.4613, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(1361.6356, 1399.3267, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(1210.435, 1229.2833, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(945.8013, 1299.2344, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(675.1765, 1136.304, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(656.4148, 1423.6677, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(585.8318, 1210.3271, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(405.50446, 1108.7471, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(463.79742, 1430.2562, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(493.21545, 1205.1069, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(200.83394, 1267.7797, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(381.54575, 1446.2133, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(-338.87494, 1302.5098, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(-561.9789, 1259.808, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(-643.4987, 1326.8081, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(-755.84955, 1250.7515, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(-859.43805, 1320.1034, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(-1677.9504, 1140.1522, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(-1453.5809, 1098.7163, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(-1413.7778, 1345.0533, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(-1664.908, 1445.7506, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(-1714.2686, 1310.9574, 40));
		AddSpawnPoint("d_abbey_22_4.Id3", "d_abbey_22_4", Rectangle(263.13165, 646.1914, 40));

		// 'Boor' GenType 52 Spawn Points
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(577.12415, 522.14557, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(730.21375, 528.83887, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(739.58484, 747.6953, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(569.3264, 777.56573, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(39.747116, 717.3625, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-74.24013, 597.7888, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(140.68312, 645.0664, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-247.96277, 634.51605, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-854.44965, 483.70557, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-818.7815, 554.23486, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-623.57025, 497.3481, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-520.4761, 466.67017, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-491.2391, 641.3018, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-494.88043, 785.0663, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-586.26117, 764.94147, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-820.77734, 671.62427, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-601.4354, 623.0684, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-983.8731, 669.37115, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-1137.8197, 664.44806, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-1640.0562, 475.13776, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-1663.3213, 633.1249, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-1499.9027, 516.4459, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-1430.3787, 687.8498, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-1312.1206, 490.1129, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-1691.0848, 754.2686, 40));
		AddSpawnPoint("d_abbey_22_4.Id4", "d_abbey_22_4", Rectangle(-1716.1207, 519.7546, 40));

		// 'Mangosting' GenType 53 Spawn Points
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(385.5291, -98.12258, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(432.52664, 26.24649, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(548.1004, -127.7569, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(601.25543, -9.250776, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(757.8012, -120.17972, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(798.04047, -27.503693, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(933.67346, -108.14827, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(936.1928, 16.355204, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(805.6391, 105.49435, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(886.72473, 214.39922, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(781.67615, 207.86255, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(625.9509, 231.46083, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(565.0403, 107.05319, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(327.83655, 128.86829, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(388.9558, 187.57971, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(715.18445, 30.829506, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-108.02544, 143.90201, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(11.946102, 152.78647, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-860.7519, -55.30758, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-672.6419, 69.919815, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-665.50354, 205.01837, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-544.8245, 44.24629, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-677.8896, -79.883286, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-880.82874, 175.44356, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-820.5194, 48.824112, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-1133.1378, 156.21365, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-1006.3942, 149.99954, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-1334.6038, 156.53961, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-1491.6774, 126.24564, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-1393.3105, 46.592705, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-1362.1152, -109.05648, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-1513.5729, -158.24286, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-1627.7269, -179.38702, 40));
		AddSpawnPoint("d_abbey_22_4.Id5", "d_abbey_22_4", Rectangle(-1691.4813, 5.283989, 40));

		// 'Half_Mangosting' GenType 54 Spawn Points
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1627.1749, -85.10098, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1617.1238, 71.14558, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1500.3416, 27.617428, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1505.0823, -53.593636, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1435.8354, -44.53591, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1665.9766, -304.60776, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1607.4573, -386.02814, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1708.6979, -486.83032, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1596.0437, -498.93695, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1639.4407, -615.1372, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1664.4987, -676.36676, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1557.2849, -715.5385, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1511.5979, -629.4101, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1473.4315, -696.656, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1451.1002, -547.2486, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-1543.5723, -554.231, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-717.58154, -188.265, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-667.0915, -294.31082, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-663.2166, -406.97446, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-756.8645, -445.07388, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-711.40564, -531.57434, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-605.949, -479.76843, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-814.89935, -588.37573, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-661.2902, -620.9608, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-690.5812, -766.7192, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-822.24384, -917.8964, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-810.64716, -1019.2321, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-813.68976, -1116.1316, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-682.9318, -1202.3318, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-651.86163, -975.8175, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-659.0044, -1080.1956, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-524.5445, -1190.5212, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-544.3598, -1045.9196, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-447.56796, -1109.5125, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-535.10065, -947.04346, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-409.40488, -975.928, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-638.5644, -1181.5681, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-282.72812, -1054.142, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-258.5988, -934.03796, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-205.7822, -1041.6405, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-57.7895, -1147.894, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-38.79447, -1228.186, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-108.12495, -1082.6406, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(14.295465, -1122.5831, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-19.4739, -922.371, 40));
		AddSpawnPoint("d_abbey_22_4.Id6", "d_abbey_22_4", Rectangle(-138.05324, -958.5445, 40));

		// 'Hohen_Mage_Black' GenType 57 Spawn Points
		AddSpawnPoint("d_abbey_22_4.Id7", "d_abbey_22_4", Rectangle(1588.427, 1250.3243, 20));
		AddSpawnPoint("d_abbey_22_4.Id7", "d_abbey_22_4", Rectangle(1348.6666, 1444.4348, 20));
		AddSpawnPoint("d_abbey_22_4.Id7", "d_abbey_22_4", Rectangle(1407.9144, 1112.1896, 20));
		AddSpawnPoint("d_abbey_22_4.Id7", "d_abbey_22_4", Rectangle(404.00046, 1342.8484, 20));
		AddSpawnPoint("d_abbey_22_4.Id7", "d_abbey_22_4", Rectangle(777.3315, 1230.2335, 20));

		// 'Hohen_Mage_Black' GenType 58 Spawn Points
		AddSpawnPoint("d_abbey_22_4.Id8", "d_abbey_22_4", Rectangle(-729.8094, 29.392525, 20));
		AddSpawnPoint("d_abbey_22_4.Id8", "d_abbey_22_4", Rectangle(-708.8947, 130.63515, 20));
		AddSpawnPoint("d_abbey_22_4.Id8", "d_abbey_22_4", Rectangle(-594.63715, 45.933357, 20));
		AddSpawnPoint("d_abbey_22_4.Id8", "d_abbey_22_4", Rectangle(-500.15762, -107.74639, 20));
		AddSpawnPoint("d_abbey_22_4.Id8", "d_abbey_22_4", Rectangle(-829.9465, 215.73526, 20));

		// 'Rootcrystal_01' GenType 59 Spawn Points
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(1609.6146, 1235.8795, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(453.61325, 1322.242, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-62.793663, 1302.7233, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-679.08624, 1289.6829, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-1471.998, 1264.0393, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-1488.029, 611.9828, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-562.69824, 634.78485, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(603.58057, 540.82513, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(708.2116, -7.5499687, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-83.96749, 140.52649, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-714.8712, 74.15111, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-1571.6849, -22.161598, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-1550.4125, -591.5316, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-667.4661, -489.90802, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-585.4538, -1060.9655, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(-65.19306, -1126.8541, 40));
		AddSpawnPoint("d_abbey_22_4.Id9", "d_abbey_22_4", Rectangle(1245.4346, 1286.3956, 40));
	}
}
