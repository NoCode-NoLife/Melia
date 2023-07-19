//--- Melia Script -----------------------------------------------------------
// d_thorn_39_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Viltis Forest' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DThorn391MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_thorn_39_1.Id1", MonsterId.Rootcrystal_01, 8, 10, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_thorn_39_1.Id2", MonsterId.Chafperor_Mage, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_39_1.Id3", MonsterId.Wood_Lwa, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_39_1.Id4", MonsterId.Infrogalas_Mage, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_39_1.Id5", MonsterId.Pandroceum, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 3 Spawn Points
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(-919.59546, 1251.7377, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(-1957.775, 1079.6902, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(-995.74915, 669.2161, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(-1147.3434, 131.52272, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(-604.1668, 147.52734, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(357.44452, 611.1228, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(1034.1262, 906.8114, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(63.817017, -968.9623, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(-374.56134, -1785.4072, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(-748.04095, -1923.1565, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(1060.2928, -129.41089, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(1585.2703, -376.45724, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(1337.0122, -1496.536, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(1070.6616, -2361.5889, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(1430.0377, 871.9104, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(242.88583, -425.69913, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(-45.14128, -1256.6731, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(1711.027, -1038.1085, 50));

		// 'Chafperor_Mage' GenType 16 Spawn Points
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(1290.7108, 1026.1157, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(1214.8043, 770.878, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(1500.7382, 789.442, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(353.60477, 635.54016, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(373.59833, 875.41113, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-785.3863, -1932.337, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-232.08443, -2012.5137, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-477.58435, -1832.9594, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-153.57968, -1038.0538, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(139.88664, -1104.653, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-457.77698, -2106.8818, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-63.603226, -1172.257, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(1078.4062, -195.40442, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(1254.9152, 87.063065, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(1167.3053, -474.2198, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(1358.2783, -263.99194, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(880.91675, -183.09802, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(1257.0548, -1468.5824, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(1469.7861, -1246.0256, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(1345.1908, -1305.4679, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-1161.3176, 143.7094, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-1041.4885, -3.052826, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-736.11505, 179.9114, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-962.08167, 489.17645, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-1324.8009, 402.68658, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-915.692, 261.8593, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-704.16943, 441.66586, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-1231.7734, -44.555016, 30));

		// 'Wood_Lwa' GenType 20 Spawn Points
		AddSpawnPoint("d_thorn_39_1.Id3", "d_thorn_39_1", Rectangle(163.87007, -616.18036, 9999));

		// 'Infrogalas_Mage' GenType 21 Spawn Points
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1287.469, -1366.9856, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1161.0731, -1577.7081, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1172.4769, 948.0648, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(-81.8699, -1149.0068, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1172.6696, -122.09647, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1268.9998, -452.4807, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1106.2927, -2452.5037, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(-593.9348, -1907.5165, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1047.9989, -349.2644, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(8.251385, -979.9013, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(71.82814, -1134.6711, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(-529.8498, -2073.4067, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(-820.20764, -2011.4313, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(-604.1131, -1791.6267, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1266.6182, 712.3192, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1344.2145, 1040.6027, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(993.1874, -2328.4592, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1179.7402, -2184.99, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1244.8021, -2540.64, 40));

		// 'Pandroceum' GenType 28 Spawn Points
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1564.995, 718.69836, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1470.881, 637.81946, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1581.1893, 786.6644, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1576.3357, 791.01196, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1197.8044, 1173.2517, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1246.9617, 1167.4867, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1305.0718, 1184.6686, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(524.14435, 669.1138, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(549.83997, 724.966, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(471.29724, 1012.3511, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(214.09956, 874.47516, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1531.8297, -288.40405, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1406.1854, -381.48718, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1184.0426, 170.44014, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1111.6931, 89.69676, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(813.19775, -98.25378, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1490.1012, -185.4792, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1473.5619, -368.94952, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(140.66599, -507.5156, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1.8576078, -789.75214, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(70.50017, -655.0528, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(275.08008, -570.2037, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(247.37714, -678.575, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(275.98593, -530.21936, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(298.73065, -419.53857, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(156.17902, -319.33252, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-1454.6602, 1368.9457, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-1222.1005, 1099.064, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-1313.5652, 1152.2235, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-1260.051, 1415.1732, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-1077.8623, 1418.2379, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-1321.8379, 1368.4642, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-1418.0453, 144.35867, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-1228.1602, 4.226967, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-1111.1304, 366.18918, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-1045.8759, 216.35512, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-970.87476, 367.78906, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-747.52875, 412.77686, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-691.7954, 540.87933, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-627.59827, 356.98297, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(230.32355, -728.5376, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(247.81342, -617.5177, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(155.25084, -459.6185, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(103.66837, -567.3558, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-859.4348, -1794.5956, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-892.8934, -1919.6862, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-402.82, -2056.6846, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-310.30002, -1947.0331, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-687.63513, -1683.2681, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-850.95715, -1877.965, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-378.97498, -1986.8942, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-512.25275, -2089.0415, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-283.99084, -2082.7803, 10));
	}
}
