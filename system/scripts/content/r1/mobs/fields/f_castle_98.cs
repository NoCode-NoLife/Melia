//--- Melia Script -----------------------------------------------------------
// f_castle_98
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Outer Wall District 15' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle98MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_castle_98.Id1", MonsterId.Kisylion, 60, 80, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_98.Id2", MonsterId.Ghosbebe, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_98.Id3", MonsterId.Scare_Crow_White, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_98.Id4", MonsterId.Rootcrystal_03, 23, 30, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Kisylion' GenType 1 Spawn Points
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(-158.36926, -866.29395, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(-20.784264, -775.6879, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(-61.101364, -1010.3864, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(409.92776, -814.0534, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(900.87286, -752.69714, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(948.73157, -917.753, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(740.09393, -867.0271, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1595.9701, -719.148, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1430.1068, -671.55164, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1511.9735, -555.57324, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2367.9456, -1181.8159, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2408.8342, -1039.5336, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2508.1748, -1131.2986, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1969.434, -695.37024, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1520.759, -635.1335, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1636.2296, -513.49347, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1503.3303, -295.3102, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1666.9672, -201.47807, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1607.0804, 182.23795, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1663.0454, 274.51453, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1897.2466, 199.68571, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2130.122, 365.5647, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2209.239, 214.89853, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2395.5469, 218.0157, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2344.2341, 457.52554, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2380.893, 1136.2272, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2244.0894, 1140.8683, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1272.1742, 969.0669, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1064.9806, 926.66266, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(363.50385, 941.8537, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(374.51138, 1099.6262, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(233.16736, 991.9922, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(345.47162, 1534.7374, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(877.359, 1074.5663, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(678.4784, 264.25134, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(693.28156, 96.36806, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1590.3827, 187.33818, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(796.7717, 344.34814, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1428.8616, 93.177414, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1716.5974, -421.3892, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1041.3413, -822.88245, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2336.1704, -816.8153, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1696.3661, 97.84488, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(1484.1924, 121.13302, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(892.46, 560.9811, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(285.58075, 838.5646, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2542.5867, 198.61963, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2507.5215, 1095.3256, 40));
		AddSpawnPoint("f_castle_98.Id1", "f_castle_98", Rectangle(2357.802, 1267.9211, 40));

		// 'Ghosbebe' GenType 2 Spawn Points
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2413.2239, 1050.2412, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2308.6592, 1051.4895, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2311.7878, 1197.5059, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2469.3594, 1204.9031, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2212.6296, 1233.4905, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1346.7739, 1031.9565, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1228.4814, 1093.9126, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1196.0127, 970.3069, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(992.38605, 1037.8424, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1016.668, 799.18933, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(474.60654, 1078.5521, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(419.75128, 970.42584, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(411.92737, 859.7167, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(257.4643, 909.1883, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(307.227, 1018.3898, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(318.8945, 1155.521, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(349.72784, 1450.2273, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1147.9569, 944.6518, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1487.3861, 1008.1033, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1405.7568, 1205.7921, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(980.8098, 680.417, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(845.4279, 474.21924, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(757.5819, 281.16077, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(726.701, 205.17026, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(620.8366, 206.3522, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(670.182, -1.7065163, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(781.16693, 90.37881, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1472.8835, 234.14102, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1463.9984, 226.45929, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1497.453, 208.85834, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1584.6404, 282.5848, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1596.9176, 91.658066, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1769.4435, 184.86131, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1770.2012, 139.93408, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1700.4949, 219.00266, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2051.2454, 243.53552, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2121.0315, 272.30023, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2201.57, 138.75627, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2310.597, 139.29768, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2309.3933, 330.4484, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2347.555, 393.8552, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2177.823, 460.2599, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2482.4949, 335.9939, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2464.6992, 152.75049, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2412.312, 108.35752, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2648.9119, 233.82039, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(2582.5667, 130.74922, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1674.7142, -6.228321, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1620.9783, -112.44579, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1742.0862, -167.97224, 20));
		AddSpawnPoint("f_castle_98.Id2", "f_castle_98", Rectangle(1584.7933, -188.20593, 20));

		// 'Scare_Crow_White' GenType 3 Spawn Points
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(2444.1455, -1154.4606, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(2352.5068, -1095.1512, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(2422.0063, -905.3508, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(2022.3407, -703.0613, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1844.2834, -698.88983, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1514.3291, -721.663, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1673.2354, -705.8771, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1480.8093, -488.6492, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1559.5356, -394.23486, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1720.4794, -292.67758, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1606.6638, -287.33423, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1720.0374, -605.6961, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1554.8185, -637.8683, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1079.0114, -758.3022, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1700.7468, -786.0858, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(836.0442, -913.43616, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(883.52814, -1006.914, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1022.8525, -985.27637, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1021.0865, -677.0531, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(753.3944, -700.05023, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(795.05225, -792.2335, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(544.1207, -775.2956, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(424.6468, -908.1746, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(307.30814, -832.31116, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(452.63742, -730.7334, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(-132.95435, -749.1519, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(-22.863052, -701.72784, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(-52.419823, -880.4731, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(-280.544, -887.9304, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(-171.80968, -1025.5908, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(947.4897, -839.4452, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1455.2341, -604.8637, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1616.4764, -650.26355, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1668.0414, 168.58682, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1831.2816, 211.38766, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(2316.072, 242.19633, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(2272.8862, 145.4161, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(754.9599, 145.97293, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(722.49915, 333.60892, 20));
		AddSpawnPoint("f_castle_98.Id3", "f_castle_98", Rectangle(1094.4877, -873.0399, 20));

		// 'Rootcrystal_03' GenType 5 Spawn Points
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(1566.3121, -1422.7963, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(1525.3167, -667.6964, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(1650.2388, -402.06076, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(1701.5636, -1.475914, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(1026.1562, -755.4979, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(624.37036, -827.64667, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(240.71707, -833.11176, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(-178.31442, -912.3106, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(-496.70758, -1024.0144, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(1967.4592, -697.2434, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(2476.6008, -1028.9402, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(2533.0112, -1486.9948, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(2121.1772, 218.07327, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(2354.3838, 425.36688, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(2545.85, 178.63538, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(2279.2817, 1127.6919, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(2526.4534, 1181.9016, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(1624.8336, 215.7932, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(1423.6978, 1037.0989, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(1002.2797, 993.92865, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(339.48865, 1002.0695, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(339.06668, 1515.9623, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(698.1265, 111.15102, 200));
		AddSpawnPoint("f_castle_98.Id4", "f_castle_98", Rectangle(847.54266, 479.4495, 200));
	}
}
