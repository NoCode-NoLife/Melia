//--- Melia Script -----------------------------------------------------------
// f_rokas_28
//
//--- Description -----------------------------------------------------------
// Sets up the f_rokas_28 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRokas28MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_rokas_28.Id1", MonsterId.Rootcrystal_05, 10, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_rokas_28.Id2", MonsterId.Hogma_Archer, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_28.Id3", MonsterId.Hogma_Archer, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_28.Id4", MonsterId.Templeslave_Mage, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_28.Id5", MonsterId.Lauzinute, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_28.Id6", MonsterId.Hogma_Archer, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "f_rokas_28.Id1", "f_rokas_28", Spot(-715.7043, -768.0276, 30));
		AddSpawnPoint( "f_rokas_28.Id1", "f_rokas_28", Spot(-289, 101, 30));
		AddSpawnPoint( "f_rokas_28.Id1", "f_rokas_28", Spot(1201, 708, 30));
		AddSpawnPoint( "f_rokas_28.Id1", "f_rokas_28", Spot(-834.311, 170.9294, 30));
		AddSpawnPoint( "f_rokas_28.Id1", "f_rokas_28", Spot(-71.71851, -1273.26, 30));
		AddSpawnPoint( "f_rokas_28.Id1", "f_rokas_28", Spot(-218.5902, -1535.49, 30));
		AddSpawnPoint( "f_rokas_28.Id1", "f_rokas_28", Spot(-1289.47, -390.1099, 30));
		AddSpawnPoint( "f_rokas_28.Id1", "f_rokas_28", Spot(-1857.804, -593.3281, 30));
		AddSpawnPoint( "f_rokas_28.Id1", "f_rokas_28", Spot(377.6326, 805.9212, 30));
		AddSpawnPoint( "f_rokas_28.Id1", "f_rokas_28", Spot(1192.514, 1050.771, 30));
		AddSpawnPoint( "f_rokas_28.Id1", "f_rokas_28", Spot(1251.39, 2108.475, 30));
		AddSpawnPoint( "f_rokas_28.Id1", "f_rokas_28", Spot(1638.431, 1597.004, 30));
		AddSpawnPoint( "f_rokas_28.Id1", "f_rokas_28", Spot(177.4644, -337.2842, 30));
		AddSpawnPoint( "f_rokas_28.Id1", "f_rokas_28", Spot(849.9878, -481.844, 30));

		// Hogma_Archer Spawn Points
		AddSpawnPoint( "f_rokas_28.Id2", "f_rokas_28", Spot(-1390.595, -639.562, 30));
		AddSpawnPoint( "f_rokas_28.Id2", "f_rokas_28", Spot(-730.2368, 155.7172, 30));
		AddSpawnPoint( "f_rokas_28.Id2", "f_rokas_28", Spot(-1626.332, -674.4744, 30));
		AddSpawnPoint( "f_rokas_28.Id2", "f_rokas_28", Spot(-1504.984, -353.6636, 30));
		AddSpawnPoint( "f_rokas_28.Id2", "f_rokas_28", Spot(-1770.858, -486.2764, 30));
		AddSpawnPoint( "f_rokas_28.Id2", "f_rokas_28", Spot(-375.9528, -162.803, 30));
		AddSpawnPoint( "f_rokas_28.Id2", "f_rokas_28", Spot(-536.6, 121.7163, 30));
		AddSpawnPoint( "f_rokas_28.Id2", "f_rokas_28", Spot(-297.4551, 34.19238, 30));
		AddSpawnPoint( "f_rokas_28.Id2", "f_rokas_28", Spot(-171.9237, -1650.813, 30));
		AddSpawnPoint( "f_rokas_28.Id2", "f_rokas_28", Spot(-53.34143, -1464.623, 30));
		AddSpawnPoint( "f_rokas_28.Id2", "f_rokas_28", Spot(-161.0173, -1320.369, 30));
		AddSpawnPoint( "f_rokas_28.Id2", "f_rokas_28", Spot(-166.5841, -1114.365, 30));
		AddSpawnPoint( "f_rokas_28.Id2", "f_rokas_28", Spot(-97.04053, -1253.949, 30));
		AddSpawnPoint( "f_rokas_28.Id3", "f_rokas_28", Spot(887.0691, 566.1692, 9999));

		// Templeslave_Mage Spawn Points
		AddSpawnPoint( "f_rokas_28.Id4", "f_rokas_28", Spot(612.5715, 405.2242, 30));
		AddSpawnPoint( "f_rokas_28.Id4", "f_rokas_28", Spot(1256.381, 769.5988, 30));
		AddSpawnPoint( "f_rokas_28.Id4", "f_rokas_28", Spot(1178.975, 1029.169, 30));
		AddSpawnPoint( "f_rokas_28.Id4", "f_rokas_28", Spot(1612.856, 1629.419, 30));
		AddSpawnPoint( "f_rokas_28.Id4", "f_rokas_28", Spot(1142.397, 1777.344, 30));
		AddSpawnPoint( "f_rokas_28.Id4", "f_rokas_28", Spot(1420.956, 1375.685, 30));

		// Lauzinute Spawn Points
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(318.88348, 743.7719, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(588.3618, 384.9227, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-572.30566, -1817.7167, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-697.7606, -1702.6039, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-367.7512, -1671.7529, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-208.62833, -1471.7516, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-205.09654, -1660.888, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-173.60426, -1750.8845, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-256.57355, -1356.0472, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-292.45694, -1770.3604, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-506.4889, -1506.7029, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-62.29834, -1519.4719, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-69.46266, -1366.8027, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-200.12552, -1131.7627, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-117.54835, -1163.556, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-319.13596, -1030.7988, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-403.73642, -1161.3325, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-347.36624, -1275.969, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-564.9107, -1639.0438, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-322.1524, -1548.4287, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-667.24274, -1899.5094, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-422.84964, -1835.7177, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-706.7777, -699.02325, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-648.00806, -826.6669, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-759.7623, -831.1353, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-685.2116, -796.4137, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-599.794, -793.5543, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-632.74506, -633.4897, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-532.6572, -682.015, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-588.6002, -635.248, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-1835.4475, -582.4825, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-1775.3513, -699.5684, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-1611.6149, -726.85, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-1639.521, -617.44214, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-1572.6772, -449.63428, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-1530.8613, -399.24127, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-1436.4403, -467.4906, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-1480.4773, -561.43463, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-1463.9108, -666.0541, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-1346.7715, -662.2062, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-1262.507, -598.36755, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-1311.7849, -467.564, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-1466.7928, -311.32004, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-1406.7946, -258.6594, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-1228.4991, -398.82425, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-1219.729, -512.7845, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-1337.9707, -367.4074, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-777.22363, -97.83855, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-828.70386, -11.124466, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-847.1035, 93.093735, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-659.3115, 305.59375, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-567.5818, 269.07452, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-646.29114, 173.28111, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-523.0221, 175.80081, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-530.65533, 58.29512, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-660.6796, -49.42153, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-597.594, -98.01874, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-334.14996, -248.56383, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-331.0474, -193.23384, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-430.90964, -252.73186, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-499.78058, -198.60924, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-258.81635, 97.12202, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-310.519, 0.7547605, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-307.62537, 207.66487, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(-300.9886, 179.10014, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(481.28665, 800.7652, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(532.7811, 803.91064, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(527.20984, 681.78107, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(412.52542, 691.9318, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(266.52362, 654.43896, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(238.87411, 530.8611, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(508.48206, 465.1556, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(549.31396, 431.47977, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(610.37976, 437.78586, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(604.61273, 580.27167, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(729.66797, 695.429, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(704.19464, 583.61017, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(698.031, 457.5073, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(926.8609, 504.0302, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(998.4245, 536.3886, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1302.2164, 725.34753, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1379.1555, 717.7927, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1289.686, 981.5421, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1113.0717, 902.8408, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1132.5437, 965.0082, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1150.7622, 1168.6636, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1467.5045, 920.7386, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1459.5187, 1093.7844, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1161.4048, 757.67474, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1311.9967, 1268.3796, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1412.5819, 1343.3744, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1632.0438, 1572.2161, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1561.8132, 1624.2258, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1565.6967, 1672.89, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1633.2292, 1711.4542, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1686.1182, 1639.5125, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1287.3735, 1709.3032, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1137.123, 1724.1431, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1243.4983, 1886.7463, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1095.3596, 2020.5385, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1378.092, 1956.3237, 40));
		AddSpawnPoint( "f_rokas_28.Id5", "f_rokas_28", Spot(1426.6129, 1823.813, 40));

		// Hogma_Archer Spawn Points
		AddSpawnPoint( "f_rokas_28.Id6", "f_rokas_28", Spot(573.0684, 357.1957, 20));
		AddSpawnPoint( "f_rokas_28.Id6", "f_rokas_28", Spot(655.4182, 565.7961, 20));
		AddSpawnPoint( "f_rokas_28.Id6", "f_rokas_28", Spot(456.2104, 454.5238, 20));
		AddSpawnPoint( "f_rokas_28.Id6", "f_rokas_28", Spot(1187.968, 858.5265, 20));
		AddSpawnPoint( "f_rokas_28.Id6", "f_rokas_28", Spot(1339.314, 917.2767, 20));

	}
}
