//--- Melia Script -----------------------------------------------------------
// d_catacomb_80_1
//
//--- Description -----------------------------------------------------------
// Sets up the d_catacomb_80_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCatacomb801MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("d_catacomb_80_1.Id1", MonsterId.ERD_Triffid, 18, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_1.Id2", MonsterId.ERD_Goblin2_Hammer, 18, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_1.Id3", MonsterId.ERD_Kowak, 18, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_1.Id4", MonsterId.ERD_Kowak_Orange, 18, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_1.Id5", MonsterId.ERD_Fisherman_Red, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_1.Id6", MonsterId.ERD_Panto_Rspear, 18, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_1.Id7", MonsterId.ERD_Tree_Root_Mole_Pink, 18, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_1.Id8", MonsterId.ERD_Melatanun, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_catacomb_80_1.Id9", MonsterId.ERD_Rudas_Loxodon, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_1.Id10", MonsterId.ERD_GoblinWarrior_Blue, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_1.Id11", MonsterId.Rootcrystal_05, 15, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// ERD_Triffid Spawn Points
		AddSpawnPoint( "d_catacomb_80_1.Id1", "d_catacomb_80_1", Spot(-187.0198, -1882.7827, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id1", "d_catacomb_80_1", Spot(11.575697, -1919.5616, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id1", "d_catacomb_80_1", Spot(-237.38867, -1584.8663, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id1", "d_catacomb_80_1", Spot(190.5901, -1489.8892, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id1", "d_catacomb_80_1", Spot(-477.61505, -1689.4272, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id1", "d_catacomb_80_1", Spot(371.79727, -1703.8693, 60));

		// ERD_Goblin2_Hammer Spawn Points
		AddSpawnPoint( "d_catacomb_80_1.Id2", "d_catacomb_80_1", Spot(-1126.3373, -1916.2698, 80));
		AddSpawnPoint( "d_catacomb_80_1.Id2", "d_catacomb_80_1", Spot(-1245.6375, -1568.4523, 80));
		AddSpawnPoint( "d_catacomb_80_1.Id2", "d_catacomb_80_1", Spot(894.3417, -1854.4253, 80));
		AddSpawnPoint( "d_catacomb_80_1.Id2", "d_catacomb_80_1", Spot(950.3731, -1562.848, 80));
		AddSpawnPoint( "d_catacomb_80_1.Id2", "d_catacomb_80_1", Spot(960.5182, -917.4723, 80));
		AddSpawnPoint( "d_catacomb_80_1.Id2", "d_catacomb_80_1", Spot(1283.3223, -780.7878, 80));
		AddSpawnPoint( "d_catacomb_80_1.Id2", "d_catacomb_80_1", Spot(-942.3057, -776.86633, 80));
		AddSpawnPoint( "d_catacomb_80_1.Id2", "d_catacomb_80_1", Spot(-1261.6256, -668.14, 80));

		// ERD_Kowak Spawn Points
		AddSpawnPoint( "d_catacomb_80_1.Id3", "d_catacomb_80_1", Spot(-94.8819, -1783.4867, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id3", "d_catacomb_80_1", Spot(-84.64798, -1550.7478, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id3", "d_catacomb_80_1", Spot(593.5241, -1694.0677, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id3", "d_catacomb_80_1", Spot(-686.10376, -1679.1467, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id3", "d_catacomb_80_1", Spot(-1005.5528, -1640.4014, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id3", "d_catacomb_80_1", Spot(-912.7082, -1751.6083, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id3", "d_catacomb_80_1", Spot(1157.0046, -1655.5874, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id3", "d_catacomb_80_1", Spot(1237.5682, -1748.1171, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id3", "d_catacomb_80_1", Spot(1060.59, -1899.7659, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id3", "d_catacomb_80_1", Spot(-1271.3872, -1785.2834, 60));

		// ERD_Kowak_Orange Spawn Points
		AddSpawnPoint( "d_catacomb_80_1.Id4", "d_catacomb_80_1", Spot(-1216.1519, 66.715965, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id4", "d_catacomb_80_1", Spot(-1006.3295, 229.43555, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id4", "d_catacomb_80_1", Spot(-1239.9441, 394.98807, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id4", "d_catacomb_80_1", Spot(-983.7314, 438.53143, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id4", "d_catacomb_80_1", Spot(985.6787, 73.44318, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id4", "d_catacomb_80_1", Spot(1240.7433, 164.03304, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id4", "d_catacomb_80_1", Spot(1012.5186, 322.1389, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id4", "d_catacomb_80_1", Spot(1245.2485, 418.99384, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id4", "d_catacomb_80_1", Spot(-1185.1127, 227.32686, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id4", "d_catacomb_80_1", Spot(1144.7661, 237.43024, 60));

		// ERD_Fisherman_Red Spawn Points
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(948.1712, 627.4318, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(1256.1235, 610.13684, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(944.2497, 856.0981, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(-1238.7445, 581.23517, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(-957.24384, 629.94727, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(-967.0209, 879.99164, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(1213.5784, 845.0261, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(-1116.8336, 780.7431, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(-914.29877, 2041.5326, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(821.83826, 2060.0864, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(205.15524, -1438.5353, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(-1095.685, 1084.4241, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(-1085.8679, 1469.9232, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(-1329.2812, 1629.7546, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(-1042.1128, 1808.4631, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(-1081.1481, 1672.6135, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(-479.14032, 2063.5415, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(-271.1419, 2243.6753, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(-127.97183, 2063.3013, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(51.69181, 2242.9636, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(220.02737, 2025.0126, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(495.9502, 2059.1487, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(1076.8208, 1824.295, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(913.46313, 1654.4923, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(1120.8694, 1444.0222, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(1246.3843, 1646.4373, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(962.6003, 1465.2904, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(1061.8115, 1049.3174, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(907.05945, 386.67343, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(1201.2097, 280.71988, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(1130.7155, 493.2929, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id5", "d_catacomb_80_1", Spot(1113.8895, 678.192, 40));

		// ERD_Panto_Rspear Spawn Points
		AddSpawnPoint( "d_catacomb_80_1.Id6", "d_catacomb_80_1", Spot(-1264.1619, 1410.9258, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id6", "d_catacomb_80_1", Spot(-1011.5716, 1358.5648, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id6", "d_catacomb_80_1", Spot(-1281.8058, 1686.5, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id6", "d_catacomb_80_1", Spot(-964.57733, 1704.6991, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id6", "d_catacomb_80_1", Spot(953.26654, 1378.3392, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id6", "d_catacomb_80_1", Spot(904.40753, 1672.3523, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id6", "d_catacomb_80_1", Spot(1194.9275, 1415.0284, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id6", "d_catacomb_80_1", Spot(1207.6442, 1668.4817, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id6", "d_catacomb_80_1", Spot(-383.21484, 2060.4968, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id6", "d_catacomb_80_1", Spot(230.3141, 2084.8206, 60));

		// ERD_Tree_Root_Mole_Pink Spawn Points
		AddSpawnPoint( "d_catacomb_80_1.Id7", "d_catacomb_80_1", Spot(-443.7141, 2224.0078, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id7", "d_catacomb_80_1", Spot(-202.3165, 2210.1047, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id7", "d_catacomb_80_1", Spot(-178.88779, 1931.6882, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id7", "d_catacomb_80_1", Spot(39.333107, 2233.66, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id7", "d_catacomb_80_1", Spot(63.88253, 1940.1013, 60));
		AddSpawnPoint( "d_catacomb_80_1.Id7", "d_catacomb_80_1", Spot(299.82602, 1963.5686, 60));

		// ERD_Melatanun Spawn Points
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(1111.1693, -767.2151, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(985.90454, -1706.8828, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(-1132.554, -1754.4991, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(-1158.2156, -829.875, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(-972.42206, 1549.849, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(828.4057, 1526.4884, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(-1265.5204, -1918.4375, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(-1277.9766, -1535.2825, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(-841.8625, -1529.1737, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(-904.1349, -1896.4817, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(-625.76086, -1700.7607, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(-173.83838, -1737.4686, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(-64.71609, -1989.9585, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(-248.26329, -1502.3416, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(20.044567, -1411.9552, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(80.50792, -1741.8221, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(399.17282, -1643.238, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(662.9366, -1775.7278, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(854.2768, -1473.8745, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(1215.1681, -1507.5956, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(1254.6624, -1847.3478, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(935.3351, -1972.0707, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(1082.1815, -1228.3291, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(918.498, -834.3885, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(1098.049, -494.92746, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(1328.859, -781.219, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(1192.3235, -1054.0479, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(1073.4083, -1173.0938, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(-1273.1533, -704.40533, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(-1281.7279, -1023.1837, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(-1056.6448, -1074.8298, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(-817.47815, -674.71497, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(-1149.857, -450.12384, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(-1124.1158, 87.17241, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(-1219.7194, 232.1364, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(-995.13153, 458.0214, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(-1228.8812, 466.85434, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(950.84717, 168.6419, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(1205.176, 74.001305, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(1089.7622, 275.23633, 40));
		AddSpawnPoint( "d_catacomb_80_1.Id8", "d_catacomb_80_1", Spot(1191.4658, 452.62552, 40));

		// ERD_Rudas_Loxodon Spawn Points
		AddSpawnPoint( "d_catacomb_80_1.Id9", "d_catacomb_80_1", Spot(1129.9994, -552.9385, 20));
		AddSpawnPoint( "d_catacomb_80_1.Id9", "d_catacomb_80_1", Spot(-1128.9707, -547.29846, 20));
		AddSpawnPoint( "d_catacomb_80_1.Id9", "d_catacomb_80_1", Spot(-1019.8017, 69.08727, 20));
		AddSpawnPoint( "d_catacomb_80_1.Id9", "d_catacomb_80_1", Spot(1204.5576, 4.542097, 20));
		AddSpawnPoint( "d_catacomb_80_1.Id9", "d_catacomb_80_1", Spot(-256.5233, -1722.5839, 20));
		AddSpawnPoint( "d_catacomb_80_1.Id9", "d_catacomb_80_1", Spot(-962.1843, -1703.3108, 20));
		AddSpawnPoint( "d_catacomb_80_1.Id9", "d_catacomb_80_1", Spot(933.1693, -1710.9906, 20));
		AddSpawnPoint( "d_catacomb_80_1.Id9", "d_catacomb_80_1", Spot(-1134.5396, 535.86694, 20));
		AddSpawnPoint( "d_catacomb_80_1.Id9", "d_catacomb_80_1", Spot(1105.2263, 525.41864, 20));

		// ERD_GoblinWarrior_Blue Spawn Points
		AddSpawnPoint( "d_catacomb_80_1.Id10", "d_catacomb_80_1", Spot(1265.426, 908.84216, 20));
		AddSpawnPoint( "d_catacomb_80_1.Id10", "d_catacomb_80_1", Spot(-1283.1211, 895.19104, 20));
		AddSpawnPoint( "d_catacomb_80_1.Id10", "d_catacomb_80_1", Spot(-419.50043, 1955.2993, 20));
		AddSpawnPoint( "d_catacomb_80_1.Id10", "d_catacomb_80_1", Spot(356.50952, 2214.0398, 20));
		AddSpawnPoint( "d_catacomb_80_1.Id10", "d_catacomb_80_1", Spot(-45.314987, 2101.448, 20));
		AddSpawnPoint( "d_catacomb_80_1.Id10", "d_catacomb_80_1", Spot(1109.5786, 340.91382, 20));
		AddSpawnPoint( "d_catacomb_80_1.Id10", "d_catacomb_80_1", Spot(1069.8943, 1559.2505, 20));
		AddSpawnPoint( "d_catacomb_80_1.Id10", "d_catacomb_80_1", Spot(-1139.208, 1581.7975, 20));
		AddSpawnPoint( "d_catacomb_80_1.Id10", "d_catacomb_80_1", Spot(-1120.9558, 300.2152, 20));
		AddSpawnPoint( "d_catacomb_80_1.Id10", "d_catacomb_80_1", Spot(124.98549, -1693.9286, 20));

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "d_catacomb_80_1.Id11", "d_catacomb_80_1", Spot(-130.94025, -1717.6024, 100));
		AddSpawnPoint( "d_catacomb_80_1.Id11", "d_catacomb_80_1", Spot(-1187.8596, -1681.6638, 100));
		AddSpawnPoint( "d_catacomb_80_1.Id11", "d_catacomb_80_1", Spot(-1135.3828, -831.8327, 100));
		AddSpawnPoint( "d_catacomb_80_1.Id11", "d_catacomb_80_1", Spot(-1142.5118, 80.52611, 100));
		AddSpawnPoint( "d_catacomb_80_1.Id11", "d_catacomb_80_1", Spot(-1081.4667, 717.47, 100));
		AddSpawnPoint( "d_catacomb_80_1.Id11", "d_catacomb_80_1", Spot(-1108.7279, 1538.2421, 100));
		AddSpawnPoint( "d_catacomb_80_1.Id11", "d_catacomb_80_1", Spot(-337.93405, 2115.989, 100));
		AddSpawnPoint( "d_catacomb_80_1.Id11", "d_catacomb_80_1", Spot(184.3287, 2097.2537, 100));
		AddSpawnPoint( "d_catacomb_80_1.Id11", "d_catacomb_80_1", Spot(947.6374, 1620.0868, 100));
		AddSpawnPoint( "d_catacomb_80_1.Id11", "d_catacomb_80_1", Spot(999.77765, 707.7417, 100));
		AddSpawnPoint( "d_catacomb_80_1.Id11", "d_catacomb_80_1", Spot(1144.4954, 132.91977, 100));
		AddSpawnPoint( "d_catacomb_80_1.Id11", "d_catacomb_80_1", Spot(988.17084, -721.2762, 100));
		AddSpawnPoint( "d_catacomb_80_1.Id11", "d_catacomb_80_1", Spot(1033.7595, -1784.4402, 100));
		AddSpawnPoint( "d_catacomb_80_1.Id11", "d_catacomb_80_1", Spot(1248.2676, 528.618, 100));
		AddSpawnPoint( "d_catacomb_80_1.Id11", "d_catacomb_80_1", Spot(-1281.6324, 585.0867, 100));
		AddSpawnPoint( "d_catacomb_80_1.Id11", "d_catacomb_80_1", Spot(-26.994034, 1953.3058, 100));

	}
}
