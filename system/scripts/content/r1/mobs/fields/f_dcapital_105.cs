//--- Melia Script -----------------------------------------------------------
// f_dcapital_105
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Baltinel Memorial' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FDcapital105MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_dcapital_105", MonsterId.Beetle_Green, Properties("MHP", 749696, "MINPATK", 10141, "MAXPATK", 12366, "MINMATK", 10141, "MAXMATK", 12366, "DEF", 226909, "MDEF", 226909));
		AddPropertyOverrides("f_dcapital_105", MonsterId.Bumble_Green, Properties("MHP", 750513, "MINPATK", 10152, "MAXPATK", 12379, "MINMATK", 10152, "MAXMATK", 12379, "DEF", 227597, "MDEF", 227597));
		AddPropertyOverrides("f_dcapital_105", MonsterId.Moltooth, Properties("MHP", 751416, "MINPATK", 10164, "MAXPATK", 12394, "MINMATK", 10164, "MAXMATK", 12394, "DEF", 228358, "MDEF", 228358));
		AddPropertyOverrides("f_dcapital_105", MonsterId.Bishopstar, Properties("MHP", 752398, "MINPATK", 10176, "MAXPATK", 12409, "MINMATK", 10176, "MAXMATK", 12409, "DEF", 229185, "MDEF", 229185));

		// Monster Spawners ---------------------------------

		AddSpawner("f_dcapital_105.Id1", MonsterId.Rootcrystal_01, 27, 35, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_dcapital_105.Id2", MonsterId.Beetle_Green, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_105.Id3", MonsterId.Bumble_Green, 20, 26, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_105.Id4", MonsterId.Moltooth, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_105.Id5", MonsterId.Bishopstar, 24, 32, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_105.Id6", MonsterId.Bishopstar, 6, 7, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_dcapital_105.Id7", MonsterId.Bishopstar, 3, 3, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 4 Spawn Points
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(1364.7244, -1042.2703, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(1467.0924, -804.9724, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(1311.4653, -628.2554, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(1115.4601, -921.337, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(925.657, -65.61135, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(1025.3849, -236.68579, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(696.08453, -404.3318, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(313.97357, -505.02164, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(340.36444, -715.85596, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(561.79205, -609.0024, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-260.26324, -377.27094, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-345.05328, -581.5687, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-160.98996, -624.96814, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-174.27403, -970.9875, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1067.0869, -1053.5607, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-851.4708, -1114.7913, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-644.7862, -915.6745, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1076.5795, -462.09164, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1069.5282, -152.12508, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-847.29175, -382.97903, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-627.6776, -28.417643, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1475.1556, 105.43114, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1183.6672, 109.00385, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-810.037, 242.37952, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-572.38086, 400.41937, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1110.8494, 603.29047, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1357.2823, 996.4164, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1050.8329, 792.1124, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1017.4431, 995.56775, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-799.1334, 875.2981, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1861.1235, 1447.2664, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1728.2751, 1733.4796, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1420.3429, 1551.7935, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-1346.6024, 1864.9508, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-755.1044, 1636.6511, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-296.3687, 1619.1589, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-49.378464, 1771.8821, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(182.51208, 1723.8265, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(189.08829, 1505.2241, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-36.92173, 1542.4712, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(52.505745, 1390.4559, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(54.203873, 1016.9909, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-271.5226, 818.4056, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(53.86393, 600.24286, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(593.03864, 807.7174, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(593.5384, 521.11847, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(384.99338, 253.31287, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(22.656826, 84.652405, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(-268.247, 222.86836, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(149.462, 214.86617, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(256.0373, 36.404785, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(701.0122, 346.95816, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(782.4289, 512.5162, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(967.5434, 283.3579, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(1097.5007, 510.75125, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(1276.2924, 478.71844, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(1312.6279, 304.92096, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(1146.5961, 328.9997, 100));
		AddSpawnPoint("f_dcapital_105.Id1", "f_dcapital_105", Rectangle(1255.4403, 132.99861, 100));

		// 'Beetle_Green' GenType 15 Spawn Points
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-1054.7207, -1021.7001, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-932.3376, -1134.4794, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-793.799, -953.6314, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-586.964, -959.9523, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-211.3019, -1005.8157, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-202.97778, -736.5131, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-389.1769, -708.3283, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-233.75931, -626.1816, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-206.03113, -289.7221, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(159.96109, -639.0173, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(371.88885, -403.65933, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(465.0904, -627.621, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(728.6021, -452.36765, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(917.44293, -488.16873, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(1069.6326, -564.2936, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(1059.2655, -103.62457, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(896.3339, -214.56775, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(1262.3468, -642.8427, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(1470.4663, -790.25635, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(1151.1896, -836.5021, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(1146.5737, -1169.9736, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(1374.0574, -1005.5231, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-583.37714, -449.8853, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-1194.9979, -328.5845, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-891.40186, -164.50189, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-990.8541, -532.366, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-607.2853, -21.636318, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(-992.6792, -401.28003, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(815.27637, 259.68097, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(735.824, 438.29825, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(1156.0282, 584.28864, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(1250.7537, 76.85229, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(642.19244, 530.5457, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(304.52768, 350.15158, 25));
		AddSpawnPoint("f_dcapital_105.Id2", "f_dcapital_105", Rectangle(263.94217, 123.3363, 25));

		// 'Bumble_Green' GenType 16 Spawn Points
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-408.58102, -829.3492, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-115.7151, -849.3208, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-336.30936, -594.1348, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-389.76782, -429.79828, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-223.22838, -462.13504, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(11.585388, -643.0793, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(650.4522, -448.73578, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(342.4092, -587.8058, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(416.4183, -752.09644, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(1061.7032, -266.2964, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(992.6058, 8.914917, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(1182.1724, -1015.5069, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(1440.915, -656.73285, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(1408.3698, -1172.4677, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(995.6888, -670.0615, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(1048.0582, 213.73541, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(1316.4376, 275.13593, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(944.5813, 584.51996, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(727.18915, 652.8194, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-1110.0463, -416.68478, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-1073.824, -130.35942, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-840.7592, -310.82407, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-739.41046, -576.865, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-1138.9642, -591.0668, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(-627.6924, -144.98871, 25));
		AddSpawnPoint("f_dcapital_105.Id3", "f_dcapital_105", Rectangle(656.78796, -633.46954, 25));

		// 'Moltooth' GenType 17 Spawn Points
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-108.11353, 16.509083, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-162.47194, 243.28314, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(89.0193, 178.72816, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(391.32828, 259.2533, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(65.26017, 521.5359, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-577.277, 403.54678, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-987.9974, 435.59268, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-754.52264, 266.14526, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1163.7625, 14.39357, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1511.2833, 94.03801, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1292.4436, 202.20654, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1247.1322, 606.1617, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1323.3018, 1044.5927, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1259.0154, 803.23096, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1091.6261, 1012.9446, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1222.8562, 1446.2981, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1904.9009, 1438.8656, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1507.7024, 1576.8262, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1645.284, 1708.612, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-1292.2943, 1817.3561, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-990.8959, 1622.0594, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-515.6454, 1593.9247, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-225.9017, 1910.3785, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(238.00882, 1558.585, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-120.67606, 1664.095, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(95.49975, 1417.9623, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(70.62116, 1025.0377, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-203.53708, 787.82495, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-394.14313, 833.22626, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-619.7203, 778.1107, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-890.17255, 850.9537, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(550.44196, 800.2344, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(49.251186, 692.9032, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-301.0065, 1544.3082, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(13.700832, 783.65393, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(69.001724, 900.16205, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(23.24939, 1184.1635, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(409.76382, 793.1878, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-951.21094, 1162.7437, 25));
		AddSpawnPoint("f_dcapital_105.Id4", "f_dcapital_105", Rectangle(-284.15994, 83.32267, 25));

		// 'Bishopstar' GenType 18 Spawn Points
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1356.642, 937.524, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1375.706, 1183.8143, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1123.5319, 1228.6344, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1154.4265, 956.7944, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1009.9363, 749.35187, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-776.72565, 413.94556, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1291.1484, 321.61884, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1305.7145, -21.52705, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1647.4883, 104.84419, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1323.7235, -226.01962, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(42.013, 1215.9923, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-57.21539, 1433.5785, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-275.86432, 1678.9194, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(58.96205, 1733.1364, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(6.215069, 1537.7385, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-858.82654, 1593.8644, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1748.6544, 1355.4427, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1883.0883, 1572.6022, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1649.3113, 1553.433, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1429.7314, 1710.1437, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-1382.8087, 1922.5234, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(29.019096, 393.50082, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(149.80385, 802.54205, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(525.81305, 481.95648, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-20.366165, 124.37363, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-238.96828, 322.42383, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-533.8769, 223.42657, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(197.2487, 321.38193, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(277.63068, 1.4339321, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-814.2584, 1587.9039, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-344.78854, 71.96748, 25));
		AddSpawnPoint("f_dcapital_105.Id5", "f_dcapital_105", Rectangle(-226.38046, -53.886032, 25));

		// 'Bishopstar' GenType 24 Spawn Points
		AddSpawnPoint("f_dcapital_105.Id6", "f_dcapital_105", Rectangle(846.25464, 378.90518, 25));
		AddSpawnPoint("f_dcapital_105.Id6", "f_dcapital_105", Rectangle(1015.662, 536.23206, 25));
		AddSpawnPoint("f_dcapital_105.Id6", "f_dcapital_105", Rectangle(969.24695, 193.36406, 25));
		AddSpawnPoint("f_dcapital_105.Id6", "f_dcapital_105", Rectangle(1258.7092, 328.04224, 25));
		AddSpawnPoint("f_dcapital_105.Id6", "f_dcapital_105", Rectangle(1046.0431, 348.02808, 25));
		AddSpawnPoint("f_dcapital_105.Id6", "f_dcapital_105", Rectangle(614.63934, 383.209, 25));
		AddSpawnPoint("f_dcapital_105.Id6", "f_dcapital_105", Rectangle(780.35504, 233.9735, 25));

		// 'Bishopstar' GenType 25 Spawn Points
		AddSpawnPoint("f_dcapital_105.Id7", "f_dcapital_105", Rectangle(1058.7882, -1144.8116, 25));
		AddSpawnPoint("f_dcapital_105.Id7", "f_dcapital_105", Rectangle(1501.6912, -964.92346, 25));
		AddSpawnPoint("f_dcapital_105.Id7", "f_dcapital_105", Rectangle(1259.5155, -989.37225, 25));
	}
}
