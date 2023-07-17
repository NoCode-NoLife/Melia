//--- Melia Script -----------------------------------------------------------
// f_katyn_45_2
//
//--- Description -----------------------------------------------------------
// Sets up the f_katyn_45_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn452MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_katyn_45_2.Id1", MonsterId.Ridimed_Blue, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_45_2.Id2", MonsterId.Puragi_Red, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_45_2.Id3", MonsterId.Pappus_Kepa_Purple, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_45_2.Id4", MonsterId.Rootcrystal_04, 34, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_katyn_45_2.Id5", MonsterId.Ridimed_Blue, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Ridimed_Blue Spawn Points
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-867.9901, 1213.606, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-299.0425, 1111.1566, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-29.942978, 540.45776, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-110.10825, 1422.5155, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-299.652, 1475.5847, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(29.414854, 593.7717, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-235.31201, 1348.5328, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-525.1365, 1220.3817, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-191.78828, 1228.5483, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-9.043458, 1656.5798, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(296.31015, 1623.0071, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(372.62115, 1831.7076, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-205.96213, 872.6742, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-158.77682, 672.4668, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-140.30887, 293.9821, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(326.17212, 521.08575, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(502.76154, 790.6333, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(806.1752, 622.7901, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(992.57544, 541.5852, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(974.29376, 272.78745, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(838.5007, -10.081598, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(163.44406, 100.37358, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(473.52554, 135.37428, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(385.8029, 187.07745, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(807.4054, 165.16014, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1222.8467, -233.85179, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(634.86633, -651.58496, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(460.83722, -724.2578, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(170.18112, -874.07916, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(70.720924, -967.5918, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-141.77841, -845.00934, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-167.89146, -560.1213, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-146.60258, -329.19446, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-165.78854, 88.30167, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(93.134056, -95.174904, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-743.9193, -867.8264, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-772.08936, -1019.5146, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-599.1639, -1034.4717, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-479.55685, -870.06757, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-260.18863, -752.45245, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-310.98773, -1109.9451, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-230.02594, -1347.3044, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(134.84428, -1703.2605, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(-107.449, -1619.8184, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(595.15704, -1781.9064, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(799.39417, -1725.0243, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(992.84814, -1532.6301, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1389.2279, -1489.3198, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1664.9089, -1470.3115, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1633.6278, -1658.521, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1800.201, -1384.553, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1628.0477, -1254.8198, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1562.9764, -1012.9379, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1330.8583, -810.52313, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1388.8257, -504.7335, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1215.9326, -509.32965, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1045.9271, -254.0968, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1575.8036, 645.4009, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1280.6517, 837.6291, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1284.8824, 1107.1157, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1596.3186, 1103.2982, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1890.5621, 939.5016, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1773.1536, 684.69196, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1846.9454, 457.97128, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(2077.691, 567.0775, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1813.0422, 862.41003, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1314.7462, 646.8455, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1145.5116, 1459.5996, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(965.0697, 1703.0938, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1105.7357, 952.6256, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1120.5232, 10.901314, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(272.96088, -213.51256, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(159.15001, 667.85004, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(355.02606, 892.20294, 30));
		AddSpawnPoint( "f_katyn_45_2.Id1", "f_katyn_45_2", Spot(1050.7391, 806.4981, 30));

		// Puragi_Red Spawn Points
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(-24.423704, 1645.1156, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(254.62485, 1672.5604, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(459.15894, 1922.4199, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(462.73932, 1572.879, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(450.27167, 1260.9027, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(525.4408, 829.0134, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(486.3634, 594.58826, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(718.55133, 747.1835, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(824.8176, 531.24054, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(1097.1672, 408.0352, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(1379.1587, 611.62524, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(1486.9388, 812.0138, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(1202.6597, 840.1102, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(1173.9042, 1035.392, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(1494.809, 1059.9427, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(1188.5751, 1358.1539, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(990.8615, 1693.1251, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(794.96375, 1709.3749, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(1702.5443, 1011.0367, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(1967.985, 1118.1914, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(1890.0807, 859.1772, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(1649.0773, 687.08887, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(1848.8744, 500.4914, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(1907.3138, 696.4514, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(2192.0774, 866.8575, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(2118.8289, 569.1046, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(1052.1635, 650.54486, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(388.55597, 822.2674, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(298.05774, 598.6993, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(-20.888596, 1463.5557, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(1020.6314, 882.4957, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(967.4105, 227.51912, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(1198.9382, 148.68173, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(963.402, -32.000626, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(1058.5183, -267.27243, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(1174.192, -99.0007, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(692.1151, 96.92542, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(412.55807, 122.691, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(742.02576, 596.51294, 30));
		AddSpawnPoint( "f_katyn_45_2.Id2", "f_katyn_45_2", Spot(1776.5728, 813.798, 30));

		// Pappus_Kepa_Purple Spawn Points
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-50.936115, -311.60318, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(284.1853, -98.91481, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(472.52188, -151.64067, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(742.2722, -519.9678, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(878.66095, -277.9927, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(461.01984, 126.57425, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(229.40952, 151.05211, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-190.92818, -489.02182, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-243.55824, -790.91425, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-513.30865, -998.9654, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-815.8599, -880.4621, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-781.7301, -1043.7797, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-559.69, -859.3168, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-194.32558, -1025.4176, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(2.7713928, -960.2593, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(357.892, -796.4841, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(532.8342, -731.23193, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(199.70753, -1052.7255, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-83.30905, -1599.3563, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(333.01416, -1753.0735, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-247.18677, -1436.7535, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(631.1827, -1769.5006, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(545.68427, -1480.0621, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(637.8789, -1341.4669, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(634.6442, -1580.9003, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(736.9859, -1465.505, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(823.0097, -1380.3778, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(927.5036, -1612.961, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(1071.7832, -1504.422, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(1334.7928, -1453.9523, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(1449.2952, -1005.4525, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(1712.6968, -1087.1779, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(1672.0035, -1233.7181, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(1623.7701, -1436.3563, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(1501.1257, -768.9132, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(1281.4283, -598.4191, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(1380.899, -432.70166, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(1178.9935, -463.75354, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(1286.7312, -135.50647, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(1031.705, -39.96031, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(928.8535, 76.2895, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(1026.4999, -109.53789, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(1145.1726, 258.8402, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(979.80774, 232.1188, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(1049.4396, 412.0837, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(163.51994, -145.67651, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-198.24875, -191.85828, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-185.94334, 107.77502, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-149.4403, 318.08905, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-245.17381, 253.38469, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-159.93771, 424.37726, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(134.0785, 173.69308, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(934.7754, -89.51797, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-37.851986, 599.8345, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-163.47665, 660.9799, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-180.26828, -350.9311, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-9.470337, -747.5855, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(210.19577, -877.80634, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-373.91562, -797.1475, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-264.4153, -1264.6633, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(-136.19762, 1249.851, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(1278.4796, -308.77643, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(1234.6769, -10.56624, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(1096.6976, -227.72034, 30));
		AddSpawnPoint( "f_katyn_45_2.Id3", "f_katyn_45_2", Spot(1184.9218, 88.87769, 30));

		// Rootcrystal_04 Spawn Points
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(-318.7787, 1246.304, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(-733.5523, 1267.9409, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(-392.82764, 1641.9556, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(-149.50214, 1629.2335, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(346.6945, 1715.2528, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(660.1228, 1694.3114, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(1086.2529, 1581.1935, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(1242.6116, 1043.4519, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(1178.8658, 757.2135, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(1817.1584, 744.6826, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(1563.8806, 719.392, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(2121.4778, 737.82196, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(952.4468, 629.36285, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(1068.0509, 197.11456, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(1233.5555, -42.662956, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(1109.7618, -364.36224, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(1369.771, -718.2338, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(1558.783, -1332.485, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(1028.4098, -1443.1738, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(256.95505, -1757.2014, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(558.00226, -1398.0082, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(-171.74678, -1534.1239, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(-93.042946, -956.87384, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(-629.97754, -934.78174, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(0.9613457, -575.89386, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(216.07748, -93.493355, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(-208.06102, 287.97614, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(580.7603, 88.60513, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(640.5566, 702.96643, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(-122.49181, 569.5895, 50));
		AddSpawnPoint( "f_katyn_45_2.Id4", "f_katyn_45_2", Spot(-216.66301, 772.5374, 50));

		// Ridimed_Blue Spawn Points
		AddSpawnPoint( "f_katyn_45_2.Id5", "f_katyn_45_2", Spot(253.42538, -114.05814, 9999));

	}
}
