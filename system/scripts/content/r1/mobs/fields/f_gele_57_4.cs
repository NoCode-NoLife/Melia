//--- Melia Script -----------------------------------------------------------
// f_gele_57_4
//
//--- Description -----------------------------------------------------------
// Sets up the f_gele_57_4 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FGele574MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_gele_57_4", MonsterId.Seedmia, Properties("MHP", 17428, "MINPATK", 725, "MAXPATK", 793, "MINMATK", 725, "MAXMATK", 793, "DEF", 70, "MDEF", 70));
		AddPropertyOverrides("f_gele_57_4", MonsterId.Npanto_Archer, Properties("MHP", 17778, "MINPATK", 730, "MAXPATK", 798, "MINMATK", 730, "MAXMATK", 798, "DEF", 71, "MDEF", 71));
		AddPropertyOverrides("f_gele_57_4", MonsterId.Colifly_Bow, Properties("MHP", 18503, "MINPATK", 739, "MAXPATK", 810, "MINMATK", 739, "MAXMATK", 810, "DEF", 71, "MDEF", 71));
		AddPropertyOverrides("f_gele_57_4", MonsterId.Mallardu, Properties("MHP", 18136, "MINPATK", 734, "MAXPATK", 804, "MINMATK", 734, "MAXMATK", 804, "DEF", 71, "MDEF", 71));
		AddPropertyOverrides("f_gele_57_4", MonsterId.Zombiegirl2_Brown, Properties("MHP", 18878, "MINPATK", 744, "MAXPATK", 816, "MINMATK", 744, "MAXMATK", 816, "DEF", 71, "MDEF", 71));
		AddPropertyOverrides("f_gele_57_4", MonsterId.Panto_Javelin_Elite, Properties("MHP", 19260, "MINPATK", 749, "MAXPATK", 822, "MINMATK", 749, "MAXMATK", 822, "DEF", 72, "MDEF", 72));

		// Monster Spawners --------------------------------

		AddSpawner("f_gele_57_4.Id1", MonsterId.Seedmia, 25, TimeSpan.FromMilliseconds(3000000), TendencyType.Peaceful);
		AddSpawner("f_gele_57_4.Id2", MonsterId.Npanto_Archer, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_4.Id3", MonsterId.Colifly_Bow, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_4.Id4", MonsterId.Seedmia, 20, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("f_gele_57_4.Id5", MonsterId.Mallardu, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_4.Id6", MonsterId.Seedmia, 15, TimeSpan.FromMilliseconds(180000), TendencyType.Peaceful);
		AddSpawner("f_gele_57_4.Id7", MonsterId.Mallardu, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_4.Id8", MonsterId.Rootcrystal_01, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_gele_57_4.Id9", MonsterId.Npanto_Archer, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_4.Id10", MonsterId.Zombiegirl2_Brown, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_4.Id11", MonsterId.Panto_Javelin_Elite, 1, TimeSpan.FromMilliseconds(1200000), TendencyType.Peaceful);
		AddSpawner("f_gele_57_4.Id12", MonsterId.Mallardu, 20, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_gele_57_4.Id13", MonsterId.Npanto_Archer, 15, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_gele_57_4.Id14", MonsterId.Seedmia, 10, TimeSpan.FromMilliseconds(180000), TendencyType.Peaceful);
		AddSpawner("f_gele_57_4.Id15", MonsterId.Seedmia, 15, TimeSpan.FromMilliseconds(180000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Seedmia Spawn Points
		AddSpawnPoint( "f_gele_57_4.Id1", "f_gele_57_4", Spot(-2149.7107, -167.34892, 20));
		AddSpawnPoint( "f_gele_57_4.Id1", "f_gele_57_4", Spot(-2184.0547, -116.80962, 20));
		AddSpawnPoint( "f_gele_57_4.Id1", "f_gele_57_4", Spot(-2191.631, -66.960205, 20));
		AddSpawnPoint( "f_gele_57_4.Id1", "f_gele_57_4", Spot(-2175.7144, 4.098364, 20));
		AddSpawnPoint( "f_gele_57_4.Id1", "f_gele_57_4", Spot(-2198.1584, -18.3386, 20));
		AddSpawnPoint( "f_gele_57_4.Id1", "f_gele_57_4", Spot(-2159.8826, 48.080654, 20));
		AddSpawnPoint( "f_gele_57_4.Id1", "f_gele_57_4", Spot(-2078.3179, -218.25003, 20));
		AddSpawnPoint( "f_gele_57_4.Id1", "f_gele_57_4", Spot(-448.40125, 593.49365, 20));
		AddSpawnPoint( "f_gele_57_4.Id1", "f_gele_57_4", Spot(-394.16724, 592.4509, 20));
		AddSpawnPoint( "f_gele_57_4.Id1", "f_gele_57_4", Spot(-336.25232, 606.02826, 20));
		AddSpawnPoint( "f_gele_57_4.Id1", "f_gele_57_4", Spot(-383.67426, 503.2453, 20));
		AddSpawnPoint( "f_gele_57_4.Id1", "f_gele_57_4", Spot(-340.83313, 511.72742, 20));
		AddSpawnPoint( "f_gele_57_4.Id1", "f_gele_57_4", Spot(-274.41028, 495.5116, 20));
		AddSpawnPoint( "f_gele_57_4.Id1", "f_gele_57_4", Spot(-209.92915, 471.90887, 20));
		AddSpawnPoint( "f_gele_57_4.Id1", "f_gele_57_4", Spot(-265.0949, 604.48706, 20));
		AddSpawnPoint( "f_gele_57_4.Id1", "f_gele_57_4", Spot(-207.23741, 613.5277, 20));

		// Npanto_Archer Spawn Points
		AddSpawnPoint( "f_gele_57_4.Id2", "f_gele_57_4", Spot(-814.42615, 1242.8506, 300));

		// Colifly_Bow Spawn Points
		AddSpawnPoint( "f_gele_57_4.Id3", "f_gele_57_4", Spot(599.67804, 1066.1956, 20));
		AddSpawnPoint( "f_gele_57_4.Id3", "f_gele_57_4", Spot(361.83, 767.9234, 20));
		AddSpawnPoint( "f_gele_57_4.Id3", "f_gele_57_4", Spot(658.0442, 882.8423, 20));
		AddSpawnPoint( "f_gele_57_4.Id3", "f_gele_57_4", Spot(168.04506, 649.7443, 20));
		AddSpawnPoint( "f_gele_57_4.Id3", "f_gele_57_4", Spot(195.14532, 781.60016, 20));
		AddSpawnPoint( "f_gele_57_4.Id3", "f_gele_57_4", Spot(-63.59952, 314.12833, 20));
		AddSpawnPoint( "f_gele_57_4.Id3", "f_gele_57_4", Spot(871.2107, 1046.6807, 20));
		AddSpawnPoint( "f_gele_57_4.Id3", "f_gele_57_4", Spot(-22.636478, 630.0966, 20));
		AddSpawnPoint( "f_gele_57_4.Id3", "f_gele_57_4", Spot(318.23993, 615.1702, 20));
		AddSpawnPoint( "f_gele_57_4.Id3", "f_gele_57_4", Spot(767.10846, 1173.4017, 20));
		AddSpawnPoint( "f_gele_57_4.Id3", "f_gele_57_4", Spot(733.0132, 1028.3342, 20));

		// Seedmia Spawn Points
		AddSpawnPoint( "f_gele_57_4.Id4", "f_gele_57_4", Spot(1401.59, -1251.37, 200));
		AddSpawnPoint( "f_gele_57_4.Id4", "f_gele_57_4", Spot(2374.3196, -769.1446, 200));
		AddSpawnPoint( "f_gele_57_4.Id4", "f_gele_57_4", Spot(2063.3315, -914.9448, 200));
		AddSpawnPoint( "f_gele_57_4.Id4", "f_gele_57_4", Spot(1375.2999, -545.1735, 200));

		// Mallardu Spawn Points
		AddSpawnPoint( "f_gele_57_4.Id5", "f_gele_57_4", Spot(1417.81, -542.81, 20));
		AddSpawnPoint( "f_gele_57_4.Id5", "f_gele_57_4", Spot(1570.0771, -665.9665, 20));
		AddSpawnPoint( "f_gele_57_4.Id5", "f_gele_57_4", Spot(-231.39, -627.09, 20));
		AddSpawnPoint( "f_gele_57_4.Id5", "f_gele_57_4", Spot(1667.337, -812.06415, 20));
		AddSpawnPoint( "f_gele_57_4.Id5", "f_gele_57_4", Spot(-162.23225, -503.05002, 20));
		AddSpawnPoint( "f_gele_57_4.Id5", "f_gele_57_4", Spot(-24.189152, -615.60565, 20));
		AddSpawnPoint( "f_gele_57_4.Id5", "f_gele_57_4", Spot(-175.99771, -755.0983, 20));
		AddSpawnPoint( "f_gele_57_4.Id5", "f_gele_57_4", Spot(-64.27397, -773.9528, 20));
		AddSpawnPoint( "f_gele_57_4.Id5", "f_gele_57_4", Spot(1291.5248, -698.26886, 20));
		AddSpawnPoint( "f_gele_57_4.Id5", "f_gele_57_4", Spot(1444.6959, -664.2343, 20));
		AddSpawnPoint( "f_gele_57_4.Id5", "f_gele_57_4", Spot(1336.3839, -580.96106, 20));
		AddSpawnPoint( "f_gele_57_4.Id5", "f_gele_57_4", Spot(1448.121, -427.14093, 20));
		AddSpawnPoint( "f_gele_57_4.Id5", "f_gele_57_4", Spot(1296.3634, -473.06323, 20));
		AddSpawnPoint( "f_gele_57_4.Id5", "f_gele_57_4", Spot(1253.3883, -558.1092, 20));

		// Seedmia Spawn Points
		AddSpawnPoint( "f_gele_57_4.Id6", "f_gele_57_4", Spot(-979.2788, 1304.11, 20));
		AddSpawnPoint( "f_gele_57_4.Id6", "f_gele_57_4", Spot(-1020.9913, 1137.7603, 20));
		AddSpawnPoint( "f_gele_57_4.Id6", "f_gele_57_4", Spot(-1020.1035, 1200.1415, 20));
		AddSpawnPoint( "f_gele_57_4.Id6", "f_gele_57_4", Spot(-950.83887, 1149.6764, 20));
		AddSpawnPoint( "f_gele_57_4.Id6", "f_gele_57_4", Spot(-967.0895, 1188.633, 20));
		AddSpawnPoint( "f_gele_57_4.Id6", "f_gele_57_4", Spot(-1016.0881, 1270.5388, 20));
		AddSpawnPoint( "f_gele_57_4.Id6", "f_gele_57_4", Spot(-953.92664, 1215.5579, 20));
		AddSpawnPoint( "f_gele_57_4.Id6", "f_gele_57_4", Spot(-961.6929, 1265.5018, 20));
		AddSpawnPoint( "f_gele_57_4.Id6", "f_gele_57_4", Spot(-1012.8502, 1324.3541, 20));
		AddSpawnPoint( "f_gele_57_4.Id6", "f_gele_57_4", Spot(-1037.6555, 1389.7405, 20));
		AddSpawnPoint( "f_gele_57_4.Id6", "f_gele_57_4", Spot(-969.905, 1342.9575, 20));
		AddSpawnPoint( "f_gele_57_4.Id6", "f_gele_57_4", Spot(-997.7947, 1382.1348, 20));
		AddSpawnPoint( "f_gele_57_4.Id6", "f_gele_57_4", Spot(-995.1644, 1212.2961, 20));
		AddSpawnPoint( "f_gele_57_4.Id6", "f_gele_57_4", Spot(-990.98773, 1147.7347, 20));
		AddSpawnPoint( "f_gele_57_4.Id6", "f_gele_57_4", Spot(-944.5703, 1288.7908, 20));

		// Mallardu Spawn Points
		AddSpawnPoint( "f_gele_57_4.Id7", "f_gele_57_4", Spot(-1899.99, 848.3, 40));
		AddSpawnPoint( "f_gele_57_4.Id7", "f_gele_57_4", Spot(-2006.7164, 97.92605, 40));
		AddSpawnPoint( "f_gele_57_4.Id7", "f_gele_57_4", Spot(-1222.4044, -272.65314, 40));
		AddSpawnPoint( "f_gele_57_4.Id7", "f_gele_57_4", Spot(-1224.004, -74.57103, 40));
		AddSpawnPoint( "f_gele_57_4.Id7", "f_gele_57_4", Spot(-2096.315, -52.75189, 40));
		AddSpawnPoint( "f_gele_57_4.Id7", "f_gele_57_4", Spot(-1903.961, -95.16675, 40));
		AddSpawnPoint( "f_gele_57_4.Id7", "f_gele_57_4", Spot(-1988.4409, -184.65121, 40));
		AddSpawnPoint( "f_gele_57_4.Id7", "f_gele_57_4", Spot(-1883.0173, 61.37204, 40));
		AddSpawnPoint( "f_gele_57_4.Id7", "f_gele_57_4", Spot(-1629.6404, -654.9321, 40));
		AddSpawnPoint( "f_gele_57_4.Id7", "f_gele_57_4", Spot(-1695.5012, -884.5817, 40));
		AddSpawnPoint( "f_gele_57_4.Id7", "f_gele_57_4", Spot(-1510.354, -964.32275, 40));
		AddSpawnPoint( "f_gele_57_4.Id7", "f_gele_57_4", Spot(-1475.705, -743.88464, 40));
		AddSpawnPoint( "f_gele_57_4.Id7", "f_gele_57_4", Spot(-1338.1985, -182.38582, 40));
		AddSpawnPoint( "f_gele_57_4.Id7", "f_gele_57_4", Spot(-1151.9711, -180.1516, 40));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(-903.89, 86.39, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(-983.74, 469.27, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(-845.8, 803.12, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(-840.95, 1128.38, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(-677.93, 1370.45, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(-900.12, 1552.22, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(-924.52, 2049.14, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(-1455.41, 123.49, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(-1786.51, 789.9, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(-1563.94, -34.39, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(-1989.85, -25.12, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(-1240.39, -177.61, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(-1565.22, -607.65, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(-1846.8729, -812.57684, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(-86.44, -751.29, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(-120.02, -561.69, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(257.52, -562.52, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(24.23, -122.81, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(-133.25, 559.08, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(212.23, 711.41, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(453.8, 957.94, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(849.09, 1123.12, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(1134.27, 1307.76, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(1399.26, 1843.62, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(693.53, -497.31, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(1377.77, -536.74, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(1420.22, -1395.28, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(1421.46, -1178.96, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(2125.07, -871.72, 10));
		AddSpawnPoint( "f_gele_57_4.Id8", "f_gele_57_4", Spot(2452.05, -791.45, 10));

		// Npanto_Archer Spawn Points
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-1256.8724, -251.39552, 25));
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-1244.73, -78.22, 25));
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-2102.6082, 134.18251, 25));
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-1685.2692, -857.0097, 25));
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-1705.7623, -677.776, 25));
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-1676.7509, -568.60767, 25));
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-1512.8391, -691.39594, 25));
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-1499.828, -891.36694, 25));
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-1572.3633, -768.9999, 25));
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-1331.7043, -145.09161, 25));
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-1162.3074, -210.35362, 25));
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-1940.8796, -161.06339, 25));
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-1955.8661, 51.002693, 25));
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-2134.526, -11.538397, 25));
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-1960.7671, -34.005283, 25));
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-238.78691, -657.0027, 25));
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-151.22382, -570.7605, 25));
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-102.70366, -703.49396, 25));
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-149.34363, -760.15344, 25));
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-40.484608, -794.0308, 25));
		AddSpawnPoint( "f_gele_57_4.Id9", "f_gele_57_4", Spot(-1.0118275, -667.85315, 25));

		// Zombiegirl2_Brown Spawn Points
		AddSpawnPoint( "f_gele_57_4.Id10", "f_gele_57_4", Spot(341.90628, 633.9618, 30));
		AddSpawnPoint( "f_gele_57_4.Id10", "f_gele_57_4", Spot(696.89905, 1148.2458, 30));
		AddSpawnPoint( "f_gele_57_4.Id10", "f_gele_57_4", Spot(694.65326, 862.66144, 30));
		AddSpawnPoint( "f_gele_57_4.Id10", "f_gele_57_4", Spot(524.68085, 1046.483, 30));
		AddSpawnPoint( "f_gele_57_4.Id10", "f_gele_57_4", Spot(883.4739, 1002.8264, 30));
		AddSpawnPoint( "f_gele_57_4.Id10", "f_gele_57_4", Spot(709.43024, 994.7644, 30));
		AddSpawnPoint( "f_gele_57_4.Id10", "f_gele_57_4", Spot(866.0817, 1168.5773, 30));
		AddSpawnPoint( "f_gele_57_4.Id10", "f_gele_57_4", Spot(188.81258, 812.22345, 30));

		// Panto_Javelin_Elite Spawn Points
		AddSpawnPoint( "f_gele_57_4.Id11", "f_gele_57_4", Spot(-1998.1119, -38.803528, 300));
		AddSpawnPoint( "f_gele_57_4.Id11", "f_gele_57_4", Spot(-1582.0569, -848.88165, 300));
		AddSpawnPoint( "f_gele_57_4.Id11", "f_gele_57_4", Spot(1408.368, -1284.4641, 300));

		// Mallardu Spawn Points
		AddSpawnPoint( "f_gele_57_4.Id12", "f_gele_57_4", Spot(-853.6413, 844.8069, 40));
		AddSpawnPoint( "f_gele_57_4.Id12", "f_gele_57_4", Spot(-902.15137, 1212.4011, 40));
		AddSpawnPoint( "f_gele_57_4.Id12", "f_gele_57_4", Spot(-667.42816, 1188.8285, 40));
		AddSpawnPoint( "f_gele_57_4.Id12", "f_gele_57_4", Spot(-648.9466, 1380.0457, 40));
		AddSpawnPoint( "f_gele_57_4.Id12", "f_gele_57_4", Spot(-870.6642, 1455.9342, 40));
		AddSpawnPoint( "f_gele_57_4.Id12", "f_gele_57_4", Spot(-797.532, 1034.1923, 40));
		AddSpawnPoint( "f_gele_57_4.Id12", "f_gele_57_4", Spot(-995.48456, 1107.9181, 40));
		AddSpawnPoint( "f_gele_57_4.Id12", "f_gele_57_4", Spot(-909.4321, 1701.102, 40));
		AddSpawnPoint( "f_gele_57_4.Id12", "f_gele_57_4", Spot(-1012.9848, 1395.8169, 40));
		AddSpawnPoint( "f_gele_57_4.Id12", "f_gele_57_4", Spot(-596.72974, 983.86487, 40));
		AddSpawnPoint( "f_gele_57_4.Id12", "f_gele_57_4", Spot(-1016.1295, 925.1369, 40));

		// Npanto_Archer Spawn Points
		AddSpawnPoint( "f_gele_57_4.Id13", "f_gele_57_4", Spot(-805.51135, 1153.5054, 50));
		AddSpawnPoint( "f_gele_57_4.Id13", "f_gele_57_4", Spot(-935.362, 1013.4167, 50));
		AddSpawnPoint( "f_gele_57_4.Id13", "f_gele_57_4", Spot(-891.7799, 1349.0417, 50));
		AddSpawnPoint( "f_gele_57_4.Id13", "f_gele_57_4", Spot(-882.6653, 1685.8326, 50));
		AddSpawnPoint( "f_gele_57_4.Id13", "f_gele_57_4", Spot(-966.24475, 1543.888, 50));
		AddSpawnPoint( "f_gele_57_4.Id13", "f_gele_57_4", Spot(-638.91797, 1243.2523, 50));
		AddSpawnPoint( "f_gele_57_4.Id13", "f_gele_57_4", Spot(-937.2272, 1204.1864, 50));
		AddSpawnPoint( "f_gele_57_4.Id13", "f_gele_57_4", Spot(-764.609, 1481.9093, 50));
		AddSpawnPoint( "f_gele_57_4.Id13", "f_gele_57_4", Spot(-1034.9182, 1354.8268, 50));
		AddSpawnPoint( "f_gele_57_4.Id13", "f_gele_57_4", Spot(-761.4699, 946.70514, 50));
		AddSpawnPoint( "f_gele_57_4.Id13", "f_gele_57_4", Spot(-578.33606, 1140.4359, 50));
		AddSpawnPoint( "f_gele_57_4.Id13", "f_gele_57_4", Spot(-650.8302, 1389.9213, 50));

		// Seedmia Spawn Points
		AddSpawnPoint( "f_gele_57_4.Id14", "f_gele_57_4", Spot(-545.49786, 1146.0485, 20));
		AddSpawnPoint( "f_gele_57_4.Id14", "f_gele_57_4", Spot(-543.5035, 1210.1624, 20));
		AddSpawnPoint( "f_gele_57_4.Id14", "f_gele_57_4", Spot(-551.0879, 1277.7225, 20));
		AddSpawnPoint( "f_gele_57_4.Id14", "f_gele_57_4", Spot(-557.2534, 1331.7653, 20));
		AddSpawnPoint( "f_gele_57_4.Id14", "f_gele_57_4", Spot(-600.7697, 1289.1432, 20));
		AddSpawnPoint( "f_gele_57_4.Id14", "f_gele_57_4", Spot(-580.93085, 1232.684, 20));
		AddSpawnPoint( "f_gele_57_4.Id14", "f_gele_57_4", Spot(-576.58203, 1163.3739, 20));
		AddSpawnPoint( "f_gele_57_4.Id14", "f_gele_57_4", Spot(-565.8415, 1090.6128, 20));
		AddSpawnPoint( "f_gele_57_4.Id14", "f_gele_57_4", Spot(-609.11646, 1118.4176, 20));
		AddSpawnPoint( "f_gele_57_4.Id14", "f_gele_57_4", Spot(-606.4418, 1206.0181, 20));
		AddSpawnPoint( "f_gele_57_4.Id14", "f_gele_57_4", Spot(-590.88745, 1062.2887, 20));
		AddSpawnPoint( "f_gele_57_4.Id14", "f_gele_57_4", Spot(-553.7921, 1046.916, 20));
		AddSpawnPoint( "f_gele_57_4.Id14", "f_gele_57_4", Spot(-595.51086, 1348.6125, 20));
		AddSpawnPoint( "f_gele_57_4.Id15", "f_gele_57_4", Spot(-107.03226, -863.3138, 10));
		AddSpawnPoint( "f_gele_57_4.Id15", "f_gele_57_4", Spot(-200.94513, -845.0491, 10));
		AddSpawnPoint( "f_gele_57_4.Id15", "f_gele_57_4", Spot(-243.9668, -802.9168, 10));
		AddSpawnPoint( "f_gele_57_4.Id15", "f_gele_57_4", Spot(-129.91718, -872.76746, 10));
		AddSpawnPoint( "f_gele_57_4.Id15", "f_gele_57_4", Spot(-272.22617, -746.61163, 10));
		AddSpawnPoint( "f_gele_57_4.Id15", "f_gele_57_4", Spot(-316.5407, -668.928, 10));
		AddSpawnPoint( "f_gele_57_4.Id15", "f_gele_57_4", Spot(-317.815, -653.8227, 10));
		AddSpawnPoint( "f_gele_57_4.Id15", "f_gele_57_4", Spot(-289.23383, -547.6958, 10));
		AddSpawnPoint( "f_gele_57_4.Id15", "f_gele_57_4", Spot(-228.50943, -479.45645, 10));
		AddSpawnPoint( "f_gele_57_4.Id15", "f_gele_57_4", Spot(-267.93588, -506.29666, 10));
		AddSpawnPoint( "f_gele_57_4.Id15", "f_gele_57_4", Spot(-127.34953, -449.11285, 10));
		AddSpawnPoint( "f_gele_57_4.Id15", "f_gele_57_4", Spot(-70.117615, -452.34235, 10));
		AddSpawnPoint( "f_gele_57_4.Id15", "f_gele_57_4", Spot(-112.22105, -480.7436, 10));
		AddSpawnPoint( "f_gele_57_4.Id15", "f_gele_57_4", Spot(-160.50606, -470.3247, 10));
		AddSpawnPoint( "f_gele_57_4.Id15", "f_gele_57_4", Spot(-295.3439, -609.98584, 10));
		AddSpawnPoint( "f_gele_57_4.Id15", "f_gele_57_4", Spot(-287.1683, -572.7884, 10));
		AddSpawnPoint( "f_gele_57_4.Id15", "f_gele_57_4", Spot(-282.26898, -713.6152, 10));
		AddSpawnPoint( "f_gele_57_4.Id15", "f_gele_57_4", Spot(-276.5957, -781.216, 10));
		AddSpawnPoint( "f_gele_57_4.Id15", "f_gele_57_4", Spot(-235.78566, -835.19116, 10));
		AddSpawnPoint( "f_gele_57_4.Id15", "f_gele_57_4", Spot(-164.3016, -874.4988, 10));

	}
}
