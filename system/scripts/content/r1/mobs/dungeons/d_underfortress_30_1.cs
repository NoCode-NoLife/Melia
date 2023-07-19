//--- Melia Script -----------------------------------------------------------
// d_underfortress_30_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Ruklys Hall of Fame' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DUnderfortress301MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_underfortress_30_1.Id1", MonsterId.Wendigo_Archer_Blue, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_30_1.Id2", MonsterId.Minos_Bow_Orange, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_30_1.Id3", MonsterId.Colifly_Yellow, 42, 55, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_30_1.Id4", MonsterId.Rootcrystal_05, 17, 22, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Wendigo_Archer_Blue' GenType 1 Spawn Points
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-1265.0535, -657.39453, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-1217.1979, -322.81287, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-1447.1404, -836.45776, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-1509.3386, -676.5148, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-689.963, -61.515926, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-669.2751, -200.43434, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-747.953, -695.9374, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-559.07104, -708.42175, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-565.80176, -833.18164, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-748.1499, -873.95044, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-606.8477, -376.7636, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-875.4103, -28.681335, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-789.0743, -158.79231, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-236.6897, 101.51701, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(40.88373, 60.83849, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-2.6451085, -247.71399, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(17.311214, -614.7838, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(40.97718, -888.41205, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(279.67746, -677.9159, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(278.7713, -861.5743, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(581.6228, -929.42523, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(580.3287, -724.879, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(835.3766, -55.911285, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(1050.6913, -130.9368, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(724.33496, -199.26088, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(667.145, -40.55538, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(291.36295, 44.82486, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-13.596558, 551.45746, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(18.615734, 840.29956, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-912.7351, 831.0305, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-1350.614, 750.68585, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-749.1377, 684.86835, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-578.2728, 850.13513, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-215.03671, 862.2553, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(23.217232, 1218.1428, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-38.181145, 1483.3687, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(600.9996, 543.95447, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(806.43805, 604.00385, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(818.81433, 475.47565, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(694.68335, 385.4655, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(1598.2032, 615.4883, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(1784.583, 769.69775, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(1467.4624, 898.5035, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(1550.2242, 1088.6671, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(1637.2897, 1360.982, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(1394.9591, 1164.0225, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(1164.5914, 1183.003, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(931.9737, 1115.3119, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(660.16815, 1088.5541, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(389.26086, 1153.2986, 30));

		// 'Minos_Bow_Orange' GenType 2 Spawn Points
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(727.50055, 522.42084, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(906.18414, 583.4907, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(773.4872, 621.4931, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(981.5267, 654.41205, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(1559.9106, 1032.5702, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(1596.1968, 779.4645, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(1097.7433, 559.0726, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(1114.2576, 1137.576, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(858.9962, 1139.7603, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(527.99567, 1154.2583, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-19.367434, 1314.8885, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-25.88035, 1071.2913, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-9.039078, 777.16345, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-481.93704, 885.57776, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-927.21436, 746.1383, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-1275.1102, 751.7114, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-983.1732, 905.683, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-570.95, 673.45575, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-103.97377, 812.24335, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(601.0648, 612.29834, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-151.06616, 373.83466, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(0.12469482, 112.37217, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-309.74597, 71.74271, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-643.989, -6.5881004, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(9.591274, 48.663734, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(383.44678, 32.347267, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(661.365, -4.2510986, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(778.1299, -181.85359, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(1086.0435, -80.857254, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(1037.0785, 32.44662, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(688.2351, 78.81265, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(700.47644, 154.98924, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(1453.0348, 978.7656, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(1581.1447, 1479.4403, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(142.55618, -725.95435, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(163.56516, -905.3709, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(485.26807, -834.4498, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-6.188751, -722.494, 30));

		// 'Colifly_Yellow' GenType 3 Spawn Points
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-1584.4222, -798.3264, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-1518.4288, -984.1222, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-1221.846, -917.2153, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-1209.2224, -650.5684, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-1292.2219, -276.38113, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-1271.2081, -48.247456, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-832.3379, 30.854385, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-751.90314, -182.21921, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-807.5262, -255.07292, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-659.8245, -648.1642, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-607.9109, -809.9745, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-359.5583, 81.09523, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-63.167175, 158.92255, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-26.166828, -58.584644, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(51.18468, -367.396, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(55.29055, -653.19385, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(51.415695, -835.5733, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(191.63046, -952.2942, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(453.90878, -749.88794, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(301.57132, -690.30597, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(58.791496, -1013.5975, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(598.29285, -856.5766, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(410.64276, 60.50015, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(728.93695, 23.046759, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(889.77625, -8.097481, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(999.85223, -205.7292, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1188.5826, -39.852036, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1229.8608, 44.017605, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1004.2153, 9.493973, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(721.5048, 331.2024, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1059.8765, 593.85876, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(542.36584, 533.61896, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(638.2689, 629.0707, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-50.16646, 560.01556, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(8.148819, 881.22003, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-74.02995, 450.61362, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-139.12732, 225.64075, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-338.54623, 879.8843, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-646.4953, 794.1781, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-1126.1295, 822.1197, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-1384.446, 698.91187, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-746.1037, 671.60425, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-722.11414, 805.61346, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-8.764017, 1194.4744, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-53.813232, 1624.9534, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-73.10249, 1605.7386, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-73.10249, 1605.7386, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-28.258402, 1428.4706, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(78.57794, 872.04926, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1561.0817, 669.38403, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1542.2461, 927.92017, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1587.0093, 1155.275, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1383.4109, 1091.3306, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1481.4807, 839.05945, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1352.3463, 613.4604, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1134.3214, 1176.1567, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(844.22614, 1104.7145, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(575.0287, 1117.5546, 30));

		// 'Rootcrystal_05' GenType 9 Spawn Points
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(642.43134, -981.1806, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-97.5233, -767.6684, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-30.173084, 28.98573, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(672.89795, -54.856674, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(1202.1051, -108.07741, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(1409.9753, 149.7952, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(547.38074, 557.159, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(862.9667, 642.65326, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(1506.1616, 700.37317, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(1545.6266, 1539.4371, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(1364.7869, 1016.1249, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(833.74133, 1058.1014, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(458.26892, 1096.2823, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-128.95718, 1589.563, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-30.052616, 801.3648, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-686.0013, -160.51958, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-606.01855, -748.23535, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-1348.8134, -948.8217, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-1117.5127, -22.447216, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-1533.5099, -398.739, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-628.75366, 775.4118, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-1296.1993, 792.5563, 10));
	}
}
