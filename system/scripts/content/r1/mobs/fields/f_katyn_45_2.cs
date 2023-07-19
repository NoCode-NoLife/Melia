//--- Melia Script -----------------------------------------------------------
// f_katyn_45_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Grynas Training Camp' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn452MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_katyn_45_2.Id1", MonsterId.Ridimed_Blue, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_45_2.Id2", MonsterId.Puragi_Red, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_45_2.Id3", MonsterId.Pappus_Kepa_Purple, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_45_2.Id4", MonsterId.Rootcrystal_04, 26, 34, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_katyn_45_2.Id5", MonsterId.Ridimed_Blue, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Ridimed_Blue' GenType 3 Spawn Points
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-867.9901, 1213.606, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-299.0425, 1111.1566, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-29.942978, 540.45776, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-110.10825, 1422.5155, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-299.652, 1475.5847, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(29.414854, 593.7717, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-235.31201, 1348.5328, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-525.1365, 1220.3817, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-191.78828, 1228.5483, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-9.043458, 1656.5798, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(296.31015, 1623.0071, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(372.62115, 1831.7076, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-205.96213, 872.6742, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-158.77682, 672.4668, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-140.30887, 293.9821, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(326.17212, 521.08575, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(502.76154, 790.6333, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(806.1752, 622.7901, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(992.57544, 541.5852, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(974.29376, 272.78745, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(838.5007, -10.081598, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(163.44406, 100.37358, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(473.52554, 135.37428, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(385.8029, 187.07745, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(807.4054, 165.16014, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1222.8467, -233.85179, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(634.86633, -651.58496, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(460.83722, -724.2578, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(170.18112, -874.07916, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(70.720924, -967.5918, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-141.77841, -845.00934, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-167.89146, -560.1213, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-146.60258, -329.19446, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-165.78854, 88.30167, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(93.134056, -95.174904, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-743.9193, -867.8264, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-772.08936, -1019.5146, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-599.1639, -1034.4717, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-479.55685, -870.06757, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-260.18863, -752.45245, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-310.98773, -1109.9451, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-230.02594, -1347.3044, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(134.84428, -1703.2605, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-107.449, -1619.8184, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(595.15704, -1781.9064, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(799.39417, -1725.0243, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(992.84814, -1532.6301, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1389.2279, -1489.3198, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1664.9089, -1470.3115, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1633.6278, -1658.521, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1800.201, -1384.553, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1628.0477, -1254.8198, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1562.9764, -1012.9379, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1330.8583, -810.52313, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1388.8257, -504.7335, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1215.9326, -509.32965, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1045.9271, -254.0968, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1575.8036, 645.4009, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1280.6517, 837.6291, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1284.8824, 1107.1157, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1596.3186, 1103.2982, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1890.5621, 939.5016, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1773.1536, 684.69196, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1846.9454, 457.97128, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(2077.691, 567.0775, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1813.0422, 862.41003, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1314.7462, 646.8455, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1145.5116, 1459.5996, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(965.0697, 1703.0938, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1105.7357, 952.6256, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1120.5232, 10.901314, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(272.96088, -213.51256, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(159.15001, 667.85004, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(355.02606, 892.20294, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1050.7391, 806.4981, 30));

		// 'Puragi_Red' GenType 4 Spawn Points
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(-24.423704, 1645.1156, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(254.62485, 1672.5604, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(459.15894, 1922.4199, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(462.73932, 1572.879, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(450.27167, 1260.9027, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(525.4408, 829.0134, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(486.3634, 594.58826, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(718.55133, 747.1835, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(824.8176, 531.24054, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1097.1672, 408.0352, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1379.1587, 611.62524, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1486.9388, 812.0138, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1202.6597, 840.1102, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1173.9042, 1035.392, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1494.809, 1059.9427, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1188.5751, 1358.1539, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(990.8615, 1693.1251, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(794.96375, 1709.3749, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1702.5443, 1011.0367, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1967.985, 1118.1914, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1890.0807, 859.1772, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1649.0773, 687.08887, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1848.8744, 500.4914, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1907.3138, 696.4514, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(2192.0774, 866.8575, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(2118.8289, 569.1046, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1052.1635, 650.54486, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(388.55597, 822.2674, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(298.05774, 598.6993, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(-20.888596, 1463.5557, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1020.6314, 882.4957, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(967.4105, 227.51912, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1198.9382, 148.68173, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(963.402, -32.000626, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1058.5183, -267.27243, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1174.192, -99.0007, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(692.1151, 96.92542, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(412.55807, 122.691, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(742.02576, 596.51294, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1776.5728, 813.798, 30));

		// 'Pappus_Kepa_Purple' GenType 5 Spawn Points
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-50.936115, -311.60318, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(284.1853, -98.91481, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(472.52188, -151.64067, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(742.2722, -519.9678, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(878.66095, -277.9927, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(461.01984, 126.57425, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(229.40952, 151.05211, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-190.92818, -489.02182, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-243.55824, -790.91425, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-513.30865, -998.9654, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-815.8599, -880.4621, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-781.7301, -1043.7797, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-559.69, -859.3168, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-194.32558, -1025.4176, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(2.7713928, -960.2593, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(357.892, -796.4841, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(532.8342, -731.23193, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(199.70753, -1052.7255, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-83.30905, -1599.3563, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(333.01416, -1753.0735, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-247.18677, -1436.7535, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(631.1827, -1769.5006, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(545.68427, -1480.0621, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(637.8789, -1341.4669, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(634.6442, -1580.9003, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(736.9859, -1465.505, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(823.0097, -1380.3778, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(927.5036, -1612.961, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1071.7832, -1504.422, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1334.7928, -1453.9523, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1449.2952, -1005.4525, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1712.6968, -1087.1779, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1672.0035, -1233.7181, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1623.7701, -1436.3563, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1501.1257, -768.9132, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1281.4283, -598.4191, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1380.899, -432.70166, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1178.9935, -463.75354, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1286.7312, -135.50647, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1031.705, -39.96031, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(928.8535, 76.2895, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1026.4999, -109.53789, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1145.1726, 258.8402, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(979.80774, 232.1188, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1049.4396, 412.0837, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(163.51994, -145.67651, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-198.24875, -191.85828, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-185.94334, 107.77502, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-149.4403, 318.08905, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-245.17381, 253.38469, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-159.93771, 424.37726, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(134.0785, 173.69308, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(934.7754, -89.51797, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-37.851986, 599.8345, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-163.47665, 660.9799, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-180.26828, -350.9311, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-9.470337, -747.5855, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(210.19577, -877.80634, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-373.91562, -797.1475, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-264.4153, -1264.6633, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-136.19762, 1249.851, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1278.4796, -308.77643, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1234.6769, -10.56624, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1096.6976, -227.72034, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1184.9218, 88.87769, 30));

		// 'Rootcrystal_04' GenType 9 Spawn Points
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(-318.7787, 1246.304, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(-733.5523, 1267.9409, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(-392.82764, 1641.9556, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(-149.50214, 1629.2335, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(346.6945, 1715.2528, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(660.1228, 1694.3114, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1086.2529, 1581.1935, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1242.6116, 1043.4519, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1178.8658, 757.2135, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1817.1584, 744.6826, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1563.8806, 719.392, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(2121.4778, 737.82196, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(952.4468, 629.36285, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1068.0509, 197.11456, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1233.5555, -42.662956, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1109.7618, -364.36224, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1369.771, -718.2338, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1558.783, -1332.485, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1028.4098, -1443.1738, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(256.95505, -1757.2014, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(558.00226, -1398.0082, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(-171.74678, -1534.1239, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(-93.042946, -956.87384, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(-629.97754, -934.78174, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(0.9613457, -575.89386, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(216.07748, -93.493355, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(-208.06102, 287.97614, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(580.7603, 88.60513, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(640.5566, 702.96643, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(-122.49181, 569.5895, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(-216.66301, 772.5374, 50));

		// 'Ridimed_Blue' GenType 13 Spawn Points
		AddSpawnPoint("f_katyn_45_2.Id5", "f_katyn_45_2", Rectangle(253.42538, -114.05814, 9999));
	}
}
