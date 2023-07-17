//--- Melia Script -----------------------------------------------------------
// f_huevillage_58_4
//
//--- Description -----------------------------------------------------------
// Sets up the f_huevillage_58_4 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FHuevillage584MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_huevillage_58_4", MonsterId.Beeteros, Properties("MHP", 33335, "MINPATK", 929, "MAXPATK", 1044, "MINMATK", 929, "MAXMATK", 1044, "DEF", 177, "MDEF", 177));
		AddPropertyOverrides("f_huevillage_58_4", MonsterId.Mentiwood, Properties("MHP", 33952, "MINPATK", 937, "MAXPATK", 1054, "MINMATK", 937, "MAXMATK", 1054, "DEF", 178, "MDEF", 178));
		AddPropertyOverrides("f_huevillage_58_4", MonsterId.Carcashu, Properties("MHP", 34589, "MINPATK", 946, "MAXPATK", 1064, "MINMATK", 946, "MAXMATK", 1064, "DEF", 178, "MDEF", 178));
		AddPropertyOverrides("f_huevillage_58_4", MonsterId.Tiny_Mage, Properties("MHP", 35243, "MINPATK", 954, "MAXPATK", 1075, "MINMATK", 954, "MAXMATK", 1075, "DEF", 179, "MDEF", 179));

		// Monster Spawners --------------------------------

		AddSpawner("f_huevillage_58_4.Id1", MonsterId.Beeteros, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_4.Id2", MonsterId.Mentiwood, 3, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_4.Id3", MonsterId.Rootcrystal_01, 11, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_4.Id4", MonsterId.Carcashu, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_4.Id5", MonsterId.Carcashu, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_4.Id6", MonsterId.Tiny_Mage, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_4.Id7", MonsterId.Tiny_Mage, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_4.Id8", MonsterId.Beeteros, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Beeteros Spawn Points
		AddSpawnPoint( "f_huevillage_58_4.Id1", "f_huevillage_58_4", Spot(70.66016, -748.64, 9999));

		// Mentiwood Spawn Points
		AddSpawnPoint( "f_huevillage_58_4.Id2", "f_huevillage_58_4", Spot(538.1299, -194.39, 9999));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_huevillage_58_4.Id3", "f_huevillage_58_4", Spot(-951.71, -482.53, 200));
		AddSpawnPoint( "f_huevillage_58_4.Id3", "f_huevillage_58_4", Spot(-310.3398, 300.22, 200));
		AddSpawnPoint( "f_huevillage_58_4.Id3", "f_huevillage_58_4", Spot(-217.02, -365.72, 200));
		AddSpawnPoint( "f_huevillage_58_4.Id3", "f_huevillage_58_4", Spot(205.96, -745.94, 200));
		AddSpawnPoint( "f_huevillage_58_4.Id3", "f_huevillage_58_4", Spot(330.5098, -194.94, 200));
		AddSpawnPoint( "f_huevillage_58_4.Id3", "f_huevillage_58_4", Spot(825.4199, -128.11, 200));
		AddSpawnPoint( "f_huevillage_58_4.Id3", "f_huevillage_58_4", Spot(1223.96, -479.45, 200));
		AddSpawnPoint( "f_huevillage_58_4.Id3", "f_huevillage_58_4", Spot(1385.94, 689.43, 200));
		AddSpawnPoint( "f_huevillage_58_4.Id3", "f_huevillage_58_4", Spot(915.7764, 825.4412, 200));
		AddSpawnPoint( "f_huevillage_58_4.Id3", "f_huevillage_58_4", Spot(254.8701, 680.27, 200));
		AddSpawnPoint( "f_huevillage_58_4.Id3", "f_huevillage_58_4", Spot(-793.3198, -945.04, 200));

		// Carcashu Spawn Points
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(-498.2344, 335.929, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(-886.1831, 230.3165, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(-255.90654, 245.81946, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(315.3911, 575.5746, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(482.9688, 726.1776, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(1254.933, 669.5435, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(607.5352, -381.7071, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(994.5674, 938.7015, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(1629.309, -38.91473, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(-722.6069, 315.6087, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(891.6665, -124.2378, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(906.1646, -401.3713, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(846.1069, 774.236, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(1307.854, 822.4095, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(375.7471, 861.5214, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(-673.7715, 454.1162, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(-560.6216, 575.731, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(-647.6182, 203.8764, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(-434.26382, -552.4656, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(-500.56607, -511.39062, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id4", "f_huevillage_58_4", Spot(33.59835, 214.54025, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-1074.544, -812.757, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-734.5767, -671.5833, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(1345.3359, 696.4551, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(1378.8658, 759.07983, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(1240.8519, 549.9227, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(1362.5782, 514.2891, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(1314.7555, 393.09674, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(1448.9991, 337.01172, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(1270.6273, 230.997, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(1365.2448, 111.63402, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(1275.6145, 27.033047, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(1188.8193, 30.005426, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(858.9419, 123.19749, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(977.6063, 162.48679, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(1560.7424, -171.52899, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(1504.8546, 190.59007, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(1416.4971, -19.46041, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(1221.6206, -175.58766, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(1157.7772, -201.56491, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(1148.1595, -333.89343, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(1201.5454, -375.19257, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(1291.778, -429.67084, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(1207.2712, -531.47437, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(1389.0493, -326.75458, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(901.1679, -322.1083, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(903.9131, -238.03996, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(895.12634, -183.47699, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(849.61475, -285.49927, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(822.03876, -132.67104, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(733.20856, -137.56804, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(729.9969, -375.90033, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(768.7777, -335.94598, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(578.5811, -333.30212, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(662.9487, -146.95255, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(699.1332, -78.261475, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(595.43036, -75.83484, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(529.1087, -133.50887, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(443.24103, 858.3708, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(521.11426, 766.0676, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(619.82104, 736.1191, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(584.19574, 655.31744, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(554.09814, 575.0045, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(462.8836, 552.3381, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(352.08746, 708.2183, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(260.98615, 604.8258, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(348.5043, 457.19775, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(204.27791, 475.5531, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(128.49377, 422.52826, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(181.76477, 244.9632, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(122.90495, 131.9965, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(97.31915, 202.4379, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(78.16541, 292.702, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-24.48048, 158.10077, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-65.80888, 366.67355, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-247.74985, 139.99478, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-402.8795, 170.56546, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-238.95651, 306.21472, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-399.1848, 355.6209, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-598.31354, 586.93207, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-536.8692, 551.55634, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-529.2776, 594.1533, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-711.5325, 471.2178, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-702.732, 367.40897, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-895.47705, 281.077, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-930.8628, 184.77434, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(129.86, -603.61383, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(11.677895, -949.1259, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(127.05459, -991.12036, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(179.9607, -946.89435, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(223.38036, -904.6151, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(119.76646, -921.0869, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-68.84341, -838.92676, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(204.1498, -747.828, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-41.590282, -653.71136, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-28.18346, -586.53375, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-4.396551, -541.50525, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-325.12186, -469.6883, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-502.9834, -561.90485, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-728.2169, -588.13007, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-679.78357, -787.41046, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-765.81335, -1063.2272, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-844.4267, -1063.7932, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-728.18915, -944.85156, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-640.59674, -897.82904, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-820.6619, -567.0757, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-949.78577, -408.0631, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-951.62866, -480.0193, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-1025.0413, -678.26733, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-1147.3085, -879.7647, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-984.4342, -949.7281, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-994.00714, -171.49774, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-1024.7294, -27.573294, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-1127.5303, -30.049416, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-1210.9148, -189.46857, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-1184.8698, -358.87454, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-1413.6433, -438.11404, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id5", "f_huevillage_58_4", Spot(-1200.7015, -450.3159, 25));

		// Tiny_Mage Spawn Points
		AddSpawnPoint( "f_huevillage_58_4.Id6", "f_huevillage_58_4", Spot(-961.8071, -594.86, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id6", "f_huevillage_58_4", Spot(-822.9517, -782.1458, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id6", "f_huevillage_58_4", Spot(-1026.696, -847.2418, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id6", "f_huevillage_58_4", Spot(-1219.799, -378.2926, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id6", "f_huevillage_58_4", Spot(-764.4102, -526.6771, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id6", "f_huevillage_58_4", Spot(-655.5005, -643.2505, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id6", "f_huevillage_58_4", Spot(-1074.023, -45.63127, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id6", "f_huevillage_58_4", Spot(-1396.708, -363.8886, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id6", "f_huevillage_58_4", Spot(-842.0063, -983.6351, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id6", "f_huevillage_58_4", Spot(-619.1997, -827.7149, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id6", "f_huevillage_58_4", Spot(-75.58547, 168.25076, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id7", "f_huevillage_58_4", Spot(807.4399, -65.60052, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id7", "f_huevillage_58_4", Spot(1329.229, 249.0205, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id7", "f_huevillage_58_4", Spot(1199.268, 647.1215, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id7", "f_huevillage_58_4", Spot(1015.546, 893.3326, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id7", "f_huevillage_58_4", Spot(486.3955, 624.7064, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id7", "f_huevillage_58_4", Spot(506.209, 820.6441, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id7", "f_huevillage_58_4", Spot(1270.279, -250.7423, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id7", "f_huevillage_58_4", Spot(1309.83, 787.3874, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id7", "f_huevillage_58_4", Spot(267.9224, 665.6131, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id7", "f_huevillage_58_4", Spot(-212.93094, 205.45773, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id7", "f_huevillage_58_4", Spot(170.64256, 390.47836, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id7", "f_huevillage_58_4", Spot(119.48222, 276.44168, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id7", "f_huevillage_58_4", Spot(-361.4988, -515.37616, 25));

		// Beeteros Spawn Points
		AddSpawnPoint( "f_huevillage_58_4.Id8", "f_huevillage_58_4", Spot(-560.05273, -565.51355, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id8", "f_huevillage_58_4", Spot(-144.82372, 354.6684, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id8", "f_huevillage_58_4", Spot(205.76624, 517.1957, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id8", "f_huevillage_58_4", Spot(-370.43536, -409.291, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id8", "f_huevillage_58_4", Spot(-48.584377, 294.39218, 25));
		AddSpawnPoint( "f_huevillage_58_4.Id8", "f_huevillage_58_4", Spot(158.642, 172.71928, 25));

	}
}
