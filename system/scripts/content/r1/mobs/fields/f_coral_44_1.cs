//--- Melia Script -----------------------------------------------------------
// f_coral_44_1
//
//--- Description -----------------------------------------------------------
// Sets up the f_coral_44_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCoral441MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_coral_44_1.Id1", MonsterId.Gob, 75, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_coral_44_1.Id2", MonsterId.VarleFloater, 46, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_44_1.Id3", MonsterId.Afisher, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_coral_44_1.Id4", MonsterId.NimrahDamsel, 46, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_44_1.Id5", MonsterId.Rootcrystal_03, 30, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Gob Spawn Points
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1175.0621, 520.1353, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1246.2678, 324.04855, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1148.7605, 321.5956, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1192.1498, 209.85896, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1056.831, 198.23303, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1283.7186, 113.57986, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1119.1364, 113.24292, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1060.6196, -86.25144, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1017.391, -21.11936, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1031.113, -174.70209, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1122.3058, -241.36885, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1250.4996, -267.91095, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1523.998, -329.25983, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1604.0132, -443.9427, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1648.0215, -374.8037, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1656.5474, -232.94891, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1683.5402, -135.03299, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1648.5504, -40.55079, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1628.9365, 59.82672, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1711.5126, -620.92645, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1681.7028, -707.27594, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-617.29407, 157.31522, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-574.3182, 44.035812, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-627.49963, -60.883583, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-534.2578, -133.43758, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-640.9709, -337.06927, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-482.35876, -322.61438, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-627.7174, -466.7832, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-494.87683, -462.28302, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-613.6001, -639.4467, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-643.1036, -1064.7483, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-706.6166, -1183.096, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-872.1561, -1203.1708, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-944.1538, -1311.0894, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1503.8267, -1323.2568, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1571.9364, -1242.0142, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1591.0839, -1154.7965, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1474.639, -1229.0077, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1572.205, -1067.2914, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-89.2195, -886.1646, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-208.93741, -740.39703, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-176.39127, -892.32007, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-105.59029, -728.6787, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-47.71674, -393.68472, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-70.108055, -553.8872, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(77.42749, -470.9677, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1615.8485, -536.6916, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1790.3506, -556.1042, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1625.2118, -299.45496, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1109.5986, 259.24173, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1329.4541, 275.4038, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-776.61725, -1385.2743, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1531.353, -1184.0977, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1269.345, -1268.999, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-655.53314, 26.452019, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-532.1203, -35.66456, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-542.26, 172.92268, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-592.3602, -261.97723, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-546.36487, -241.7958, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-529.2844, -393.93207, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1286.5001, 201.01402, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1118.9691, 174.4443, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1001.5974, 406.64035, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-917.7007, 299.30313, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-791.0474, 251.10849, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1086.0101, -150.56215, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1552.5828, -391.3698, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1689.1744, -500.0812, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(-1734.2267, -397.9278, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(83.10978, -819.8222, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(135.78192, -628.3642, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(258.65002, -772.7502, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(328.5032, -640.77423, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(0.46775818, -743.3844, 40));
		AddSpawnPoint( "f_coral_44_1.Id1", "f_coral_44_1", Spot(259.4942, -541.6393, 40));

		// VarleFloater Spawn Points
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(144.6087, 563.70496, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(84.636086, 622.4416, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(304.27817, 622.79486, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(353.11493, 714.7184, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(174.97974, 687.84393, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(240.47668, 808.63654, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(373.58725, 1046.963, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(153.81264, 1081.8033, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(319.73758, 1240.3177, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(341.27954, 1142.8867, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(-138.2685, 961.65796, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(-317.14346, 984.47253, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(-158.97913, 1109.1907, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(454.67834, 638.9445, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(599.94073, 531.80225, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(763.24646, 803.1353, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(767.1588, 1008.3906, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(956.6499, 1029.452, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(849.45447, 1180.3176, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(-127.79388, -814.00696, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(-135.82019, -609.8464, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(32.14612, -449.70355, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(110.31693, -378.8572, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(209.08795, -472.36633, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(22.286316, -641.25055, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(724.384, -183.05687, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(754.16724, -114.89624, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(945.87683, -2.660839, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(981.4583, 110.28551, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(1036.1898, -18.084637, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(991.23114, 223.7532, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(1129.1205, 313.15344, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(1063.6361, -150.98645, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(-555.5052, -1128.0925, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(-528.75195, -1232.0214, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(-666.73785, -1343.539, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(-886.0933, -1379.8075, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(-1251.7832, -1358.5057, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(-1166.8947, -1248.4912, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(-634.151, -876.76117, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(-368.79422, -970.12976, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(17.432, -867.0048, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(171.06136, -917.4132, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(1382.9374, -1031.2019, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(1562.0448, -1125.6578, 40));
		AddSpawnPoint( "f_coral_44_1.Id2", "f_coral_44_1", Spot(1550.8862, -946.9097, 40));

		// Afisher Spawn Points
		AddSpawnPoint( "f_coral_44_1.Id3", "f_coral_44_1", Spot(1508.9355, -1030.8591, 40));
		AddSpawnPoint( "f_coral_44_1.Id3", "f_coral_44_1", Spot(657.99176, -1090.9067, 40));
		AddSpawnPoint( "f_coral_44_1.Id3", "f_coral_44_1", Spot(1286.6353, 259.37308, 40));
		AddSpawnPoint( "f_coral_44_1.Id3", "f_coral_44_1", Spot(987.8485, 48.607613, 40));
		AddSpawnPoint( "f_coral_44_1.Id3", "f_coral_44_1", Spot(26.13266, -757.24, 40));
		AddSpawnPoint( "f_coral_44_1.Id3", "f_coral_44_1", Spot(134.61383, -600.4687, 40));
		AddSpawnPoint( "f_coral_44_1.Id3", "f_coral_44_1", Spot(259.46307, 729.69257, 40));
		AddSpawnPoint( "f_coral_44_1.Id3", "f_coral_44_1", Spot(-209.59995, 1011.8497, 40));
		AddSpawnPoint( "f_coral_44_1.Id3", "f_coral_44_1", Spot(271.3142, 1044.336, 40));
		AddSpawnPoint( "f_coral_44_1.Id3", "f_coral_44_1", Spot(897.5148, 1079.3618, 40));
		AddSpawnPoint( "f_coral_44_1.Id3", "f_coral_44_1", Spot(-768.6213, -1263.2308, 40));

		// NimrahDamsel Spawn Points
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(650.7098, -987.08215, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(551.74396, -1096.1185, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(553.0487, -1213.4485, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(670.34204, -1180.9917, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(777.6439, -1093.0829, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(1085.7181, -974.0905, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(1179.5905, -993.6761, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(1100.1224, -561.8254, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(1162.9221, -495.21326, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(972.3066, -401.5345, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(1029.1312, -273.09225, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(1194.8883, -327.42892, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(1081.4053, -409.86993, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(1441.0913, -1068.4414, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(1622.0421, -1031.7821, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(1223.1462, -242.72629, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(1303.4845, 120.95248, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(1405.8469, 39.17899, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(1425.9763, 191.5056, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(1330.6976, 319.45456, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(1510.0867, 233.09044, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(208.9697, -813.1234, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(139.0136, -704.90576, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(285.20416, -718.95074, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(348.75256, -530.9041, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(378.4983, -636.5089, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(105.85491, 695.3287, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(253.51169, 659.7482, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(-246.38669, 937.54803, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(-272.91214, 1058.5967, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(237.0097, 1140.0873, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(813.5303, 1076.764, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(686.0015, 1147.7299, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(788.1193, 1225.6102, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(1441.1042, 284.1695, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(525.3339, -414.71475, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(618.18695, -295.89508, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(1518.362, -970.50336, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(-97.831505, 586.0769, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(638.16974, 650.9049, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(978.4739, 15.267481, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(947.7561, 272.73944, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(647.98553, -1090.1625, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(931.8668, 126.99696, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(1236.6711, -375.1025, 40));
		AddSpawnPoint( "f_coral_44_1.Id4", "f_coral_44_1", Spot(1241.0236, 230.87856, 40));

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(-1438.0696, 806.9137, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(-1125.207, 497.01572, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(-572.1008, 222.93474, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(-576.51544, -93.943756, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(-545.88904, -429.18903, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(-594.4728, -685.95776, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(-817.9983, -1232.5046, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(-583.61865, -1193.2401, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(-1318.6917, -1299.9963, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(-1597.5349, -1212.7472, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(-1715.527, -504.40027, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(-1639.2238, 55.953915, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(-1617.3242, -236.02289, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(-1204.1459, -254.04524, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(-1144.0323, 186.28568, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(-201.73134, -791.94775, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(128.05104, -458.51685, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(688.0041, -151.874, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(979.4233, 90.63673, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(69.85716, 679.00433, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(426.68857, 694.5398, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(-278.04987, 1063.7167, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(279.9798, 1113.7888, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(825.6839, 1029.1033, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(1335.5404, 258.56458, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(1483.5052, 164.33798, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(1175.2413, -543.60504, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(1094.5397, -210.71916, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(1385.442, -276.52585, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(1657.033, -1090.3734, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(1438.7579, -1007.5534, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(1203.5938, -978.5274, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(720.22687, -1070.6155, 50));
		AddSpawnPoint( "f_coral_44_1.Id5", "f_coral_44_1", Spot(512.6177, -1174.3823, 50));

	}
}
