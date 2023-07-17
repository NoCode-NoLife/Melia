//--- Melia Script -----------------------------------------------------------
// f_whitetrees_22_3
//
//--- Description -----------------------------------------------------------
// Sets up the f_whitetrees_22_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FWhitetrees223MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_whitetrees_22_3.Id1", MonsterId.Rootcrystal_01, 14, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_3.Id2", MonsterId.Yakmambo, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_3.Id3", MonsterId.Yakmab, 48, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_3.Id4", MonsterId.Bush_Beetle, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_3.Id5", MonsterId.Hohen_Gulak_Black, 11, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_whitetrees_22_3.Id6", MonsterId.Hohen_Mane_Black, 47, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_whitetrees_22_3.Id7", MonsterId.Blossom_Beetle, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Spot(20.749918, 1199.3914, 10));
		AddSpawnPoint( "f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Spot(753.2058, 947.0173, 10));
		AddSpawnPoint( "f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Spot(1477.2913, 891.08453, 10));
		AddSpawnPoint( "f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Spot(-292.46243, 468.54974, 10));
		AddSpawnPoint( "f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Spot(106.67482, 25.357937, 10));
		AddSpawnPoint( "f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Spot(-280.96512, -614.64996, 10));
		AddSpawnPoint( "f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Spot(-668.80206, -1152.1997, 10));
		AddSpawnPoint( "f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Spot(195.88144, -1170.4176, 10));
		AddSpawnPoint( "f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Spot(-1483.9889, -1222.3351, 10));
		AddSpawnPoint( "f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Spot(-1097.6467, -1277.8464, 10));
		AddSpawnPoint( "f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Spot(-1442.4158, -548.1888, 10));
		AddSpawnPoint( "f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Spot(-1444.7217, 227.16733, 10));
		AddSpawnPoint( "f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Spot(-1042.5052, 270.23026, 10));
		AddSpawnPoint( "f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Spot(256.91068, 454.6698, 10));

		// Yakmambo Spawn Points
		AddSpawnPoint( "f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Spot(1388.7623, 1110.5626, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Spot(1404.53, 818.0128, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Spot(1598.1239, 965.2717, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Spot(720.99445, 909.3825, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Spot(830.4164, 929.0515, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Spot(1220.6681, -1054.5981, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Spot(1286.5989, -878.7857, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Spot(1589.775, -982.7964, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Spot(1518.9095, -1748.4006, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Spot(1745.8397, -1725.5375, 40));

		// Yakmab Spawn Points
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1379.1276, 897.5156, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1329.5625, 800.30725, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1465.4696, 760.2917, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1518.7012, 906.0611, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1573.3789, 1054.8011, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1646.2123, 891.6341, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1376.2588, 1005.7515, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1307.7228, 1106.6492, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1456.8376, 1129.9565, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1266.6705, 988.92926, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1269.521, 885.9131, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1673.3945, 1064.1362, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(595.73944, 861.1042, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(657.2947, 979.70276, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(736.1486, 829.4195, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(783.7224, 995.77905, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(880.45996, 1039.4675, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(937.3656, 926.59906, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(865.494, 844.9126, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(489.15152, 966.9987, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(400.11972, 1021.0394, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(346.2709, 1090.5455, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1041.0078, -1062.1892, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1133.5787, -1141.11, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1111.0721, -974.4638, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1244.7814, -1172.8551, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1170.9087, -889.0607, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1214.6252, -764.64044, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1372.7297, -812.9959, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1504.557, -842.9518, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1605.442, -878.91907, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1423.6339, -1086.7264, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1333.3152, -993.11725, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1367.5905, -1162.401, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1564.8201, -1138.0734, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1508.7927, -1005.1036, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1658.0347, -1052.0399, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1702.5374, -934.9957, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1444.2982, -1808.5092, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1557.2357, -1902.242, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1604.4219, -1803.8181, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1741.8403, -1814.8242, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1832.2985, -1708.1781, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1671.7186, -1626.8129, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1602.1014, -1704.7378, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1497.6147, -1628.6896, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1567.7875, -1573.1621, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Spot(1785.7388, -1612.508, 40));

		// Bush_Beetle Spawn Points
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(15.601731, 1331.2946, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-106.92764, 1326.202, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-44.875523, 1080.3295, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(70.0022, 1156.0088, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(107.90482, 1249.6357, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-257.48697, 989.42377, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-375.82007, 560.50867, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-304.1209, 668.44806, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-387.30386, 466.12015, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-127.28457, 606.7529, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(15.138565, 481.5219, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-153.69496, 238.28099, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-386.79135, 205.99823, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-221.47559, 65.08659, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(33.853558, 241.44797, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-17.260689, -16.458239, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(324.16162, 170.31807, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(179.55392, 200.95355, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(152.81796, 462.24963, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(355.87784, 624.45215, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-108.90592, 337.4997, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-499.25717, -844.9217, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-549.6644, -942.67163, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-1468.2773, 102.11591, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-1364.7966, -0.020872116, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-1190.4974, 46.576275, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-975.17664, 19.022886, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-446.10065, -778.52057, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-918.5576, 124.31927, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-1002.9675, 135.59625, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-1262.1434, 170.21884, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-1400.2247, 205.11293, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-92.65021, 551.3297, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-422.30313, 290.97107, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-98.83033, 696.6719, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-89.5816, 1198.7169, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(288.57977, 540.2261, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-158.98929, -74.57745, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(329.96405, 8.411839, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Spot(-373.73022, -624.7095, 40));

		// Hohen_Gulak_Black Spawn Points
		AddSpawnPoint( "f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Spot(-272.5602, 312.91217, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Spot(100.37302, 356.3888, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Spot(33.626453, 71.334404, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Spot(-95.699814, 489.60657, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Spot(72.34686, -1236.59, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Spot(-1146.1917, -1310.2905, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Spot(-1619.8027, -664.6923, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Spot(-1415.4176, -359.78168, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Spot(-1326.0269, 180.50577, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Spot(-1018.5502, 178.71313, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Spot(-1198.7192, 391.66235, 40));

		// Hohen_Mane_Black Spawn Points
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-373.09317, 349.67078, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-191.65488, 437.74368, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-262.27734, 205.23169, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-63.46472, 63.299034, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(11.961386, 157.7642, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(108.16144, -54.813286, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(115.24683, 252.25964, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(194.78578, 366.56744, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-15.551955, 397.56567, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-323.77045, 100.97583, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-386.14264, -617.3101, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-303.3341, -531.49646, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-210.0613, -535.26605, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-299.5063, -695.8892, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-167.48073, -625.8374, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-116.84435, -727.922, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(109.70295, -1149.0637, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(170.78828, -1089.7115, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(238.18816, -1037.7748, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(143.67734, -1278.3179, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(235.61035, -1293.873, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(438.32062, -1184.9061, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-997.34595, -1284.1661, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1090.6102, -1196.701, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1339.5966, -1370.0082, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1440.7356, -1379.3489, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1354.5232, -1276.0448, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1539.1907, -1123.0226, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1459.7202, -1080.5289, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1576.4277, -1249.5961, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1538.5991, -1359.6412, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1482.5426, -683.73145, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1539.6797, -608.71686, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1615.6604, -558.4985, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1522.5845, -468.03754, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1423.4545, -430.09564, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1350.809, -514.6151, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1307.1519, -375.24557, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1398.7427, 117.25552, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1297.65, 96.372375, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1223.0956, 168.6662, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1104.0492, 147.38918, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1022.1671, 86.24185, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-915.96094, 167.47, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1297.9291, 372.37866, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1214.7762, 275.581, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Spot(-1109.7772, 352.41428, 40));

		// Blossom_Beetle Spawn Points
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-289.9301, -326.54507, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-340.28607, -219.71645, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-297.9039, -94.53604, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(24.121656, -829.81415, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(111.21577, -865.55615, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-469.33453, -779.0243, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-767.92004, -1036.5958, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-825.32684, -1215.9294, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-719.295, -1231.4673, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-562.94275, -1210.0873, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-1295.0442, 455.4249, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-1214.4055, 470.32355, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-1031.1788, 464.64856, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-924.94977, 453.51758, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-980.4653, 340.64346, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-1310.6512, 263.75238, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-1261.6034, -480.20447, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-482.4196, -1041.9904, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-494.4011, -894.70984, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-277.37747, -443.4483, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-224.93727, 44.49239, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-1377.5726, -455.34995, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-1020.2164, 206.15762, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-1143.2373, 84.24402, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-1301.1573, 108.77775, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-1406.02, 227.16614, 40));
		AddSpawnPoint( "f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Spot(-200.59264, -687.30524, 40));

	}
}
