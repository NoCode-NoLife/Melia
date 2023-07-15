//--- Melia Script -----------------------------------------------------------
// f_farm_49_2
//
//--- Description -----------------------------------------------------------
// Sets up the f_farm_49_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFarm492MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_farm_49_2", MonsterId.Stub_Tree_Orange, Properties("MHP", 220391, "MINPATK", 3335, "MAXPATK", 4000, "MINMATK", 3335, "MAXMATK", 4000, "DEF", 9252, "MDEF", 9252));
		AddPropertyOverrides("f_farm_49_2", MonsterId.Cyst, Properties("MHP", 221149, "MINPATK", 3345, "MAXPATK", 4012, "MINMATK", 3345, "MAXMATK", 4012, "DEF", 9353, "MDEF", 9353));
		AddPropertyOverrides("f_farm_49_2", MonsterId.Flying_Flog_Green, Properties("MHP", 222010, "MINPATK", 3356, "MAXPATK", 4026, "MINMATK", 3356, "MAXMATK", 4026, "DEF", 9468, "MDEF", 9468));
		AddPropertyOverrides("f_farm_49_2", MonsterId.Pendinmire_Paviesa, Properties("MHP", 222961, "MINPATK", 3368, "MAXPATK", 4041, "MINMATK", 3368, "MAXMATK", 4041, "DEF", 9595, "MDEF", 9595));

		// Monster Spawners --------------------------------

		AddSpawner("f_farm_49_2.Id1", MonsterId.Stub_Tree_Orange, 25, TimeSpan.FromMilliseconds(25000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_2.Id2", MonsterId.Cyst, 29, TimeSpan.FromMilliseconds(25000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_2.Id3", MonsterId.Flying_Flog_Green, 10, TimeSpan.FromMilliseconds(25000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_2.Id4", MonsterId.Flying_Flog_Green, 80, TimeSpan.FromMilliseconds(25000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_2.Id5", MonsterId.Rootcrystal_01, 12, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_farm_49_2.Id6", MonsterId.Pendinmire_Paviesa, 1, TimeSpan.FromMilliseconds(1800000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Stub_Tree_Orange Spawn Points
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(1601.9017, -1158.6715, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(1464.8071, -1332.678, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(1415.2478, -1472.8362, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(1638.459, -1444.0391, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(1299.0787, -1343.11, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(1437.9243, -1190.9713, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(1712.9202, -1322.7407, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(1599.0387, -1286.0673, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(379.50787, -568.5987, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(435.74255, -359.82343, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(583.52954, -447.0022, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(567.287, -563.1478, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(521.73364, -706.5162, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(799.86847, -588.8526, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(828.2856, -432.9655, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(475.14725, 278.35922, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(407.16797, 466.1028, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(558.9775, 392.47092, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(612.3912, 565.14215, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(654.3916, 260.08728, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(812.5538, 333.59247, 25));
		AddSpawnPoint( "f_farm_49_2.Id1", "f_farm_49_2", Spot(737.07574, 611.4351, 25));

		// Cyst Spawn Points
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(970.50397, 1103.7241, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(548.0716, 1095.4852, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(604.49115, 1253.7964, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(953.04834, 1316.7931, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(-1411.0692, -1611.0669, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(-1343.278, -1430.0144, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(-74.59166, -1294.1609, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(-191.07695, -1139.6472, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(-1108.8374, -1393.5991, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(-1202.7008, -1471.5422, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(-1289.0171, -1260.1511, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(-1299.9867, -1619.5612, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(-270.16965, -1352.5515, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(90.48133, -1239.0048, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(62.154274, -969.8292, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(-200.2678, -984.202, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(13.016514, -1096.731, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(748.63544, 1046.4244, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(607.96606, 1394.2592, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(806.81287, 1426.383, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(1606.9536, 1202.3221, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(1687.0358, 1406.9863, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(1806.4288, 1221.2274, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(1933.764, 1316.389, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(2043.7837, 1264.6617, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(2061.0054, 1385.1262, 30));
		AddSpawnPoint( "f_farm_49_2.Id2", "f_farm_49_2", Spot(-1541.758, -1416.1208, 30));

		// Flying_Flog_Green Spawn Points
		AddSpawnPoint( "f_farm_49_2.Id3", "f_farm_49_2", Spot(-529.9546, -375.0679, 25));
		AddSpawnPoint( "f_farm_49_2.Id3", "f_farm_49_2", Spot(-308.47894, -481.73438, 25));
		AddSpawnPoint( "f_farm_49_2.Id3", "f_farm_49_2", Spot(-128.2078, -388.49066, 25));
		AddSpawnPoint( "f_farm_49_2.Id3", "f_farm_49_2", Spot(11.133394, -216.4071, 25));
		AddSpawnPoint( "f_farm_49_2.Id3", "f_farm_49_2", Spot(-132.21802, -25.960854, 25));
		AddSpawnPoint( "f_farm_49_2.Id3", "f_farm_49_2", Spot(-418.87305, -108.67303, 25));
		AddSpawnPoint( "f_farm_49_2.Id3", "f_farm_49_2", Spot(-584.2181, -114.85463, 25));
		AddSpawnPoint( "f_farm_49_2.Id3", "f_farm_49_2", Spot(-318.34015, 77.46613, 25));
		AddSpawnPoint( "f_farm_49_2.Id3", "f_farm_49_2", Spot(1656.85, 1269.255, 25));
		AddSpawnPoint( "f_farm_49_2.Id3", "f_farm_49_2", Spot(504.81934, 1182.7598, 25));
		AddSpawnPoint( "f_farm_49_2.Id3", "f_farm_49_2", Spot(756.3933, 1070.036, 25));
		AddSpawnPoint( "f_farm_49_2.Id3", "f_farm_49_2", Spot(-1392.2229, -1479.5048, 25));
		AddSpawnPoint( "f_farm_49_2.Id3", "f_farm_49_2", Spot(-1331.6549, -1328.7943, 25));
		AddSpawnPoint( "f_farm_49_2.Id3", "f_farm_49_2", Spot(-1152.7522, -1529.3954, 25));
		AddSpawnPoint( "f_farm_49_2.Id3", "f_farm_49_2", Spot(-354.58875, -293.78476, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1245.9894, 674.81696, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1326.123, 801.0796, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1527.3768, 772.14655, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1983.4065, 642.1511, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-778.13696, 434.71808, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-973.03296, 395.12686, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(2095.091, 1280.6289, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1959.811, 1443.3071, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(2083.0212, 1411.5813, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1924.2705, 1181.9495, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1906.7004, 1338.7158, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1489.2595, 1277.5406, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1626.1011, 1147.2899, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1791.6848, 1244.8654, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1620.607, 1248.2748, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1758.4933, 1370.8119, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1139.4836, 1267.3954, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(715.04596, 1027.5836, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(923.86835, 1084.4054, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(988.65204, 988.6738, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(985.6458, 1199.5269, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(749.295, 905.2115, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(864.63324, 1234.3107, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(771.6276, 1170.3944, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(957.86975, 1363.3881, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(856.63495, 1452.7521, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(420.5037, 1329.304, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(577.09875, 1001.7579, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(640.12366, 1295.8733, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(556.7631, 1203.4661, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(405.1331, 1180.3987, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(697.1706, 1431.2352, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(794.23755, 1351.7709, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(684.37683, 573.9895, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(763.9852, 492.44006, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(454.31592, 387.1054, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(667.4347, 237.0841, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(865.42505, 299.57043, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(728.0966, 327.29294, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(365.19272, 272.99335, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(489.28967, 281.57895, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(558.2221, 197.53052, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(582.2781, 451.32703, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(451.2127, 512.031, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(824.4268, -482.9931, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(718.1276, -536.6397, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(609.8398, -424.07236, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(646.7897, -307.9689, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(567.28156, -516.86475, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(292.12463, -657.06635, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(263.4824, -449.08813, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(435.64194, -281.63004, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(553.13214, -233.23534, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(493.7591, -376.43115, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(554.6322, -600.01874, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(646.6018, -712.0575, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(435.1564, -598.83417, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(373.83267, -747.47986, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(390.83426, -465.53708, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1566.7894, -1584.275, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1728.427, -1334.3142, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1707.0215, -1431.8962, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1583.9109, -1500.4634, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1413.2836, -1575.7373, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1428.3353, -1500.2592, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1370.8402, -1402.1216, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1492.5741, -1409.2081, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1385.1456, -1289.5302, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1479.9949, -1313.289, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1611.0868, -1328.5184, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1663.6117, -1229.7422, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(1422.6478, -1172.2933, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(154.03627, -1085.7742, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(122.46591, -1263.3652, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-119.53861, -1279.33, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-11.693323, -973.1708, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-17.765203, -1086.2228, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-167.18677, -1028.5995, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-104.83397, -1189.2817, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-105.34644, -1118.3553, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-250.74817, -1309.2002, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-232.38457, -1166.969, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1.1168976, -1369.1877, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-4.59209, -1243.3617, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-291.2153, -1108.2062, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-98.31158, 75.331924, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-261.50305, 139.39821, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-373.72845, 19.962687, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-586.0067, -406.27606, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-521.8095, -75.14843, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-384.24408, -227.49942, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-426.52744, -494.864, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(32.738735, -356.6821, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(100.86718, -234.57976, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(15.704678, -147.14458, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-6.5877633, -279.01944, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-74.782936, -477.8345, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-207.32109, -415.81116, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-381.046, -346.12894, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-578.8957, -536.2144, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-384.1123, -599.3854, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-80.88996, -174.86208, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-135.90494, -89.36003, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-240.20515, 23.235659, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-260.09525, -144.85118, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-686.7578, -165.34044, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-545.081, -265.23676, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-694.72894, -319.0009, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-864.7755, 493.65723, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-847.3095, 597.8787, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-999.3961, 488.77042, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-840.3857, 330.31354, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1004.8837, -168.02332, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1073.0208, -280.65912, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1173.3152, -227.57507, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1111.4639, -115.30882, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1461.6608, -1457.6985, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1495.758, -1561.0922, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1240.2943, -1539.8137, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1355.6843, -1628.9675, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1217.1212, -1420.9795, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1072.8179, -1552.6455, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-914.9964, -1421.5101, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1038.0901, -1431.7312, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1381.0995, -1284.169, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1492.8154, -1341.3258, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1206.674, -1296.1123, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1323.3965, -1456.736, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1416.6769, 469.68777, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1937.1339, 420.83463, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1631.3367, 454.80966, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1741.501, 594.1293, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1539.0997, 645.2523, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1395.0819, 598.74725, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1490.6708, 848.4112, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1640.2893, 797.2925, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1863.55, 469.9508, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1755.1852, 388.40195, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1881.8934, 895.1969, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-1743.4731, 723.8756, 25));
		AddSpawnPoint( "f_farm_49_2.Id4", "f_farm_49_2", Spot(-2002.0741, 758.1764, 25));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_farm_49_2.Id5", "f_farm_49_2", Spot(1544.6664, -1310.1964, 50));
		AddSpawnPoint( "f_farm_49_2.Id5", "f_farm_49_2", Spot(507.71027, -705.59973, 50));
		AddSpawnPoint( "f_farm_49_2.Id5", "f_farm_49_2", Spot(624.4757, -409.77972, 50));
		AddSpawnPoint( "f_farm_49_2.Id5", "f_farm_49_2", Spot(695.381, 275.19745, 50));
		AddSpawnPoint( "f_farm_49_2.Id5", "f_farm_49_2", Spot(701.9565, 608.43506, 50));
		AddSpawnPoint( "f_farm_49_2.Id5", "f_farm_49_2", Spot(698.01, 1041.9678, 50));
		AddSpawnPoint( "f_farm_49_2.Id5", "f_farm_49_2", Spot(982.0241, 1313.9503, 50));
		AddSpawnPoint( "f_farm_49_2.Id5", "f_farm_49_2", Spot(1653.3821, 1168.672, 50));
		AddSpawnPoint( "f_farm_49_2.Id5", "f_farm_49_2", Spot(1921.088, 1313.2607, 50));
		AddSpawnPoint( "f_farm_49_2.Id5", "f_farm_49_2", Spot(-796.0566, 548.75275, 50));
		AddSpawnPoint( "f_farm_49_2.Id5", "f_farm_49_2", Spot(-1415.1885, 591.39154, 50));
		AddSpawnPoint( "f_farm_49_2.Id5", "f_farm_49_2", Spot(-1807.9445, 751.939, 50));
		AddSpawnPoint( "f_farm_49_2.Id5", "f_farm_49_2", Spot(-544.3664, -237.88419, 50));
		AddSpawnPoint( "f_farm_49_2.Id5", "f_farm_49_2", Spot(-139.22348, -228.2628, 50));
		AddSpawnPoint( "f_farm_49_2.Id5", "f_farm_49_2", Spot(-170.16751, -1059.1593, 50));
		AddSpawnPoint( "f_farm_49_2.Id5", "f_farm_49_2", Spot(-637.95306, -1230.0348, 50));
		AddSpawnPoint( "f_farm_49_2.Id5", "f_farm_49_2", Spot(-1141.593, -1423.3774, 50));
		AddSpawnPoint( "f_farm_49_2.Id5", "f_farm_49_2", Spot(-1456.3534, -1519.0441, 50));

		// Pendinmire_Paviesa Spawn Points
		AddSpawnPoint( "f_farm_49_2.Id6", "f_farm_49_2", Spot(1554.0251, -1325.4502, 250));

	}
}
