//--- Melia Script -----------------------------------------------------------
// f_remains_38
//
//--- Description -----------------------------------------------------------
// Sets up the f_remains_38 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRemains38MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_remains_38.Id1", MonsterId.Lizardman, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_38.Id2", MonsterId.InfroBurk, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_38.Id3", MonsterId.Lizardman, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_38.Id4", MonsterId.InfroBurk, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_38.Id5", MonsterId.Long_Arm, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_38.Id6", MonsterId.Lizardman, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_38.Id7", MonsterId.Rootcrystal_01, 18, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_remains_38.Id8", MonsterId.Stub_Tree_Mage, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_38.Id9", MonsterId.Long_Arm, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Lizardman Spawn Points
		AddSpawnPoint( "f_remains_38.Id1", "f_remains_38", Spot(-955.5981, -54.674503, 9999));

		// InfroBurk Spawn Points
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(1084.11, -841.62, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(1069.46, -1042.34, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(1186.4849, -848.1382, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(1327.9454, -742.05615, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(1473.8298, -762.02563, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(1558.4606, -603.60754, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(1084.64, -1165.15, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(1403.916, -634.7575, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(1496.7896, -877.1128, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(1441.1584, -489.32526, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(1293.1753, -1011.2032, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(954.1464, -922.2721, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(1197.83, -1043.12, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(1286.96, -1143.5, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(1454.437, -1039.8757, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(1402.7262, -889.3767, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(1016.1375, -972.28015, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(921.5338, -1022.3523, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(873.69, -943.7735, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(872.4491, -814.2546, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(967.83636, -717.1536, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(1038.8965, -737.875, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(1044.4647, -801.11597, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(1035.414, -884.9436, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(1137.3862, -988.455, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(990.08026, -1108.3102, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(886.573, -1103.7675, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(808.4515, -1025.5347, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(791.2817, -930.68054, 25));
		AddSpawnPoint( "f_remains_38.Id2", "f_remains_38", Spot(816.515, -801.00916, 25));

		// Lizardman Spawn Points
		AddSpawnPoint( "f_remains_38.Id3", "f_remains_38", Spot(-716.7803, 571.04126, 30));
		AddSpawnPoint( "f_remains_38.Id3", "f_remains_38", Spot(-351.8301, 340.55014, 30));
		AddSpawnPoint( "f_remains_38.Id3", "f_remains_38", Spot(-958.89075, -534.3682, 30));
		AddSpawnPoint( "f_remains_38.Id3", "f_remains_38", Spot(-820.9118, -409.0933, 30));
		AddSpawnPoint( "f_remains_38.Id3", "f_remains_38", Spot(-918.1801, 377.65527, 30));
		AddSpawnPoint( "f_remains_38.Id3", "f_remains_38", Spot(-1028.819, -117.04179, 30));
		AddSpawnPoint( "f_remains_38.Id3", "f_remains_38", Spot(-1069.5264, -327.73264, 30));
		AddSpawnPoint( "f_remains_38.Id3", "f_remains_38", Spot(-1007.0124, 282.56, 30));
		AddSpawnPoint( "f_remains_38.Id3", "f_remains_38", Spot(-622.05426, 753.4641, 30));
		AddSpawnPoint( "f_remains_38.Id3", "f_remains_38", Spot(-419.2925, 187.82823, 30));
		AddSpawnPoint( "f_remains_38.Id3", "f_remains_38", Spot(-876.9404, 62.01392, 30));
		AddSpawnPoint( "f_remains_38.Id3", "f_remains_38", Spot(-1183.563, -34.21416, 30));
		AddSpawnPoint( "f_remains_38.Id3", "f_remains_38", Spot(-607.14545, 284.39737, 30));

		// InfroBurk Spawn Points
		AddSpawnPoint( "f_remains_38.Id4", "f_remains_38", Spot(-2034.9103, 708.69324, 20));
		AddSpawnPoint( "f_remains_38.Id4", "f_remains_38", Spot(-1846.4429, 503.84436, 20));
		AddSpawnPoint( "f_remains_38.Id4", "f_remains_38", Spot(-1875.2778, 720.1697, 20));
		AddSpawnPoint( "f_remains_38.Id4", "f_remains_38", Spot(-1688.2273, 599.73694, 20));
		AddSpawnPoint( "f_remains_38.Id4", "f_remains_38", Spot(-1684.5856, 501.83163, 20));
		AddSpawnPoint( "f_remains_38.Id4", "f_remains_38", Spot(-1862.8389, 623.18756, 20));
		AddSpawnPoint( "f_remains_38.Id4", "f_remains_38", Spot(-2000.8523, 856.5484, 20));
		AddSpawnPoint( "f_remains_38.Id4", "f_remains_38", Spot(-2011.8723, 570.5366, 20));
		AddSpawnPoint( "f_remains_38.Id4", "f_remains_38", Spot(-1743.0413, 706.083, 20));

		// Long_Arm Spawn Points
		AddSpawnPoint( "f_remains_38.Id5", "f_remains_38", Spot(-143.1651, -961.5667, 20));
		AddSpawnPoint( "f_remains_38.Id5", "f_remains_38", Spot(563.41626, -726.9153, 20));
		AddSpawnPoint( "f_remains_38.Id5", "f_remains_38", Spot(407.03918, -1061.5221, 20));
		AddSpawnPoint( "f_remains_38.Id5", "f_remains_38", Spot(-185.74628, -1114.9108, 20));
		AddSpawnPoint( "f_remains_38.Id5", "f_remains_38", Spot(399.76514, -835.81805, 20));
		AddSpawnPoint( "f_remains_38.Id5", "f_remains_38", Spot(233.01715, -810.4377, 20));
		AddSpawnPoint( "f_remains_38.Id5", "f_remains_38", Spot(262.2921, -1323.5759, 20));
		AddSpawnPoint( "f_remains_38.Id5", "f_remains_38", Spot(-924.5832, -1183.1906, 20));
		AddSpawnPoint( "f_remains_38.Id5", "f_remains_38", Spot(-1210.1812, -1129.952, 20));
		AddSpawnPoint( "f_remains_38.Id5", "f_remains_38", Spot(-1192.0596, -971.5997, 20));
		AddSpawnPoint( "f_remains_38.Id5", "f_remains_38", Spot(-1544.2308, -889.0148, 20));
		AddSpawnPoint( "f_remains_38.Id5", "f_remains_38", Spot(-1737.602, -782.7472, 20));
		AddSpawnPoint( "f_remains_38.Id5", "f_remains_38", Spot(-714.50903, -1003.3597, 20));

		// Lizardman Spawn Points
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(1557.552, 1006.7827, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(1172.9401, 957.92786, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(1255.7744, 645.76807, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(1579.8124, 411.54443, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(1465.6041, 529.8493, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-1133.5105, -192.79997, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-1070.0739, -192.69376, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-1006.9891, -242.1231, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-968.47723, -327.09552, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-994.1625, -390.54755, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-1043.5048, -420.14893, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-1076.614, -471.52377, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-768.84265, -509.907, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-701.487, -446.9812, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-762.4897, -413.51837, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-996.1069, -102.50433, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-927.1208, 16.54607, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-867.09686, 4.784193, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-872.76746, -33.983215, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-1017.3799, 212.98991, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-1043.1791, 318.2962, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-1038.6846, 369.7912, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-982.2401, 390.20578, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-973.40533, 326.55545, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-893.3121, 303.62695, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-830.74475, 407.06967, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-856.4647, 475.99274, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-939.51587, 473.8853, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-1023.282, 513.07117, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-862.23016, 312.1048, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-710.9765, 377.41074, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-670.8639, 449.84534, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-702.2906, 533.93085, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-636.39655, 611.8157, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-577.2265, 570.49664, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-569.90436, 505.7014, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-621.5729, 402.18085, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-639.77136, 328.62592, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-645.2372, 239.03975, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-580.8939, 197.34486, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-400.892, 324.4164, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-342.41855, 370.6794, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-280.07983, 266.8516, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-356.12308, 210.95502, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-364.23294, 150.14365, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-234.52914, 323.80545, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-280.6095, 332.65433, 25));
		AddSpawnPoint( "f_remains_38.Id6", "f_remains_38", Spot(-300.61353, 374.85385, 25));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(-1298.3033, -1125.679, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(-1454.1824, -1766.5542, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(-1812.566, -1565.0402, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(-779.55414, -1108.8359, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(-883.178, -605.8395, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(-1020.5569, -247.09256, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(-987.6138, 74.01392, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(-905.1103, 370.57205, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(-1849.2457, 641.02185, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(-1276.7385, 565.8949, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(-655.7267, 651.744, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(-324.7003, 1060.5682, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(138.97017, 1147.502, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(214.05473, 556.2968, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(120.16185, 248.18295, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(-270.67557, 356.60266, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(-15.609112, -957.91693, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(219.47823, -1143.5028, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(376.64374, -1172.0837, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(687.80927, -997.7252, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(1347.0917, -1039.6237, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(1384.4619, -591.4669, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(1074.7346, -1056.0198, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(1555.5964, -228.25638, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(1477.0402, 505.68994, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(1178.4327, 848.0527, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(1539.2307, 892.59015, 100));
		AddSpawnPoint( "f_remains_38.Id7", "f_remains_38", Spot(1420.2638, 1384.9795, 100));

		// Stub_Tree_Mage Spawn Points
		AddSpawnPoint( "f_remains_38.Id8", "f_remains_38", Spot(-117.3943, -1006.5897, 40));
		AddSpawnPoint( "f_remains_38.Id8", "f_remains_38", Spot(170.28275, -1240.3127, 40));
		AddSpawnPoint( "f_remains_38.Id8", "f_remains_38", Spot(-1107.5441, -252.97676, 40));
		AddSpawnPoint( "f_remains_38.Id8", "f_remains_38", Spot(-955.6885, 162.4294, 40));
		AddSpawnPoint( "f_remains_38.Id8", "f_remains_38", Spot(-135.10942, 317.41068, 40));
		AddSpawnPoint( "f_remains_38.Id8", "f_remains_38", Spot(-761.5656, 421.7378, 40));
		AddSpawnPoint( "f_remains_38.Id8", "f_remains_38", Spot(-834.4515, -359.99637, 40));
		AddSpawnPoint( "f_remains_38.Id8", "f_remains_38", Spot(1193.5912, 765.3096, 40));
		AddSpawnPoint( "f_remains_38.Id8", "f_remains_38", Spot(1559.4156, 928.1894, 40));
		AddSpawnPoint( "f_remains_38.Id8", "f_remains_38", Spot(1405.1981, 721.6473, 40));
		AddSpawnPoint( "f_remains_38.Id8", "f_remains_38", Spot(1135.4102, -1109.9382, 40));
		AddSpawnPoint( "f_remains_38.Id8", "f_remains_38", Spot(1401.3143, -839.4663, 40));
		AddSpawnPoint( "f_remains_38.Id8", "f_remains_38", Spot(1132.3766, -858.8676, 40));

		// Long_Arm Spawn Points
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-69.861465, -1042.108, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(12.168552, -1134.1294, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1360.6105, -1758.9578, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1353.0642, -1981.824, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1241.9839, -2054.174, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1252.8004, -1862.3934, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1470.6035, -1902.9072, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(1284.0883, 570.7555, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(1353.2639, 778.2401, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(1485.2255, 834.0568, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(1427.9264, 635.5626, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(1464.727, 379.96075, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(1593.1512, 387.85748, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(1570.2795, 616.0141, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1584.5428, -2008.5817, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1668.7245, -1794.5775, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1640.5809, -1661.5627, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1500.8179, -1609.7789, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1389.3539, -2174.1167, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1184.9541, -1830.519, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1408.0754, -1251.609, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1337.1176, -1232.671, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1258.638, -1204.9475, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1097.3036, -971.5228, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1359.8632, -1141.211, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1300.6813, -913.3106, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1203.7931, -1000.7315, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1188.3337, -1113.2875, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1391.7129, -968.04767, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1804.0599, -754.35925, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1707.415, -800.5906, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1745.4418, -848.12726, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-753.5458, -1128.632, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-1033.194, -1207.225, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-992.80457, -1071.1072, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-860.5133, -1003.0693, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-901.8314, -1162.1455, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-743.3266, -1012.6909, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-691.8264, -1233.3754, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-599.31354, -1132.3845, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-587.78973, -1051.278, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-180.06956, -917.9956, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(-101.29356, -686.21075, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(6.872116, -776.961, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(34.522697, -926.1244, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(340.8874, -1270.6655, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(229.75215, -1210.8549, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(267.9214, -1107.5188, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(67.515656, -654.276, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(306.9415, -932.15, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(185.31816, -992.0311, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(366.703, -792.4674, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(470.91574, -961.99524, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(494.55676, -775.4815, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(567.7194, -855.82404, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(1464.957, 987.995, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(1389.2411, 1125.515, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(1207.6622, 1014.553, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(1132.9802, 862.40125, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(1113.1176, 550.89185, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(1085.4214, 706.6153, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(1385.5065, 651.82385, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(1270.2717, 413.01025, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(1593.5409, 883.78345, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(1644.4348, 1028.8376, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(178.30876, 430.22308, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(39.97631, 398.08716, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(160.98477, 267.2938, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(32.685463, 135.53667, 20));
		AddSpawnPoint( "f_remains_38.Id9", "f_remains_38", Spot(252.88448, 195.37247, 20));

	}
}
