//--- Melia Script -----------------------------------------------------------
// d_abbey_22_5
//
//--- Description -----------------------------------------------------------
// Sets up the d_abbey_22_5 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DAbbey225MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("d_abbey_22_5.Id1", MonsterId.Rootcrystal_01, 21, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_5.Id2", MonsterId.Hohen_Orben_Black, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_5.Id3", MonsterId.Harugal_Black, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_5.Id4", MonsterId.Drooper, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_5.Id5", MonsterId.StonOrca_Red, 170, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_5.Id6", MonsterId.Hohen_Orben_Black, 6, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_5.Id7", MonsterId.Drooper, 2, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_5.Id8", MonsterId.Harugal_Black, 4, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_5.Id9", MonsterId.Harugal_Black, 3, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_5.Id10", MonsterId.Drooper, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(-371.6191, 794.0121, 10));
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(304.85278, 795.8134, 10));
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(1022.3701, 710.8158, 10));
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(1300.3693, 846.3564, 10));
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(1067.3878, 1363.7881, 10));
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(1783.7811, 796.95636, 10));
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(797.97894, -39.01883, 10));
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(1289.6746, -39.54998, 10));
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(809.02966, -900.1825, 10));
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(1266.9066, -957.0189, 10));
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(1.2872314, -73.25833, 10));
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(-836.69995, -28.894585, 10));
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(-1286.0653, -38.800636, 10));
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(-1888.4155, -228.5361, 10));
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(-1553.9855, -789.448, 10));
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(-1176.0934, -836.6072, 10));
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(-876.9559, -846.084, 10));
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(-1776.8933, 931.7338, 10));
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(-1164.0768, 884.5946, 10));
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(-1453.8021, 1738.3623, 10));
		AddSpawnPoint( "d_abbey_22_5.Id1", "d_abbey_22_5", Spot(-949.25, 1636.227, 10));

		// Hohen_Orben_Black Spawn Points
		AddSpawnPoint( "d_abbey_22_5.Id2", "d_abbey_22_5", Spot(-270.2342, 798.4317, 20));
		AddSpawnPoint( "d_abbey_22_5.Id2", "d_abbey_22_5", Spot(28.262337, 949.0999, 20));
		AddSpawnPoint( "d_abbey_22_5.Id2", "d_abbey_22_5", Spot(328.8051, 805.10614, 20));
		AddSpawnPoint( "d_abbey_22_5.Id2", "d_abbey_22_5", Spot(19.336151, 561.44055, 20));
		AddSpawnPoint( "d_abbey_22_5.Id2", "d_abbey_22_5", Spot(-1261.1683, 194.85535, 20));
		AddSpawnPoint( "d_abbey_22_5.Id2", "d_abbey_22_5", Spot(-1049.1423, 191.01016, 20));
		AddSpawnPoint( "d_abbey_22_5.Id2", "d_abbey_22_5", Spot(-860.6697, 190.46057, 20));
		AddSpawnPoint( "d_abbey_22_5.Id2", "d_abbey_22_5", Spot(1087.3999, 1159.9034, 20));
		AddSpawnPoint( "d_abbey_22_5.Id2", "d_abbey_22_5", Spot(981.27136, 1413.422, 20));
		AddSpawnPoint( "d_abbey_22_5.Id2", "d_abbey_22_5", Spot(1175.249, 1398.3538, 20));
		AddSpawnPoint( "d_abbey_22_5.Id2", "d_abbey_22_5", Spot(1804.3202, -81.489265, 20));
		AddSpawnPoint( "d_abbey_22_5.Id2", "d_abbey_22_5", Spot(984.6119, -117.72944, 20));
		AddSpawnPoint( "d_abbey_22_5.Id2", "d_abbey_22_5", Spot(1178.9539, -113.89948, 20));
		AddSpawnPoint( "d_abbey_22_5.Id2", "d_abbey_22_5", Spot(944.5316, -913.453, 20));
		AddSpawnPoint( "d_abbey_22_5.Id2", "d_abbey_22_5", Spot(1196.2947, -926.2232, 20));
		AddSpawnPoint( "d_abbey_22_5.Id2", "d_abbey_22_5", Spot(-1625.8632, -923.61084, 20));
		AddSpawnPoint( "d_abbey_22_5.Id2", "d_abbey_22_5", Spot(-1319.3182, -819.86725, 20));
		AddSpawnPoint( "d_abbey_22_5.Id2", "d_abbey_22_5", Spot(-837.8511, 790.09186, 20));
		AddSpawnPoint( "d_abbey_22_5.Id2", "d_abbey_22_5", Spot(1808.3375, 53.82218, 20));
		AddSpawnPoint( "d_abbey_22_5.Id2", "d_abbey_22_5", Spot(-1715.204, -328.62286, 20));

		// Harugal_Black Spawn Points
		AddSpawnPoint( "d_abbey_22_5.Id3", "d_abbey_22_5", Spot(-229.38043, 104.59671, 20));
		AddSpawnPoint( "d_abbey_22_5.Id3", "d_abbey_22_5", Spot(-162.71504, -184.95628, 20));
		AddSpawnPoint( "d_abbey_22_5.Id3", "d_abbey_22_5", Spot(254.09201, 106.81932, 20));
		AddSpawnPoint( "d_abbey_22_5.Id3", "d_abbey_22_5", Spot(259.48593, -152.18216, 20));
		AddSpawnPoint( "d_abbey_22_5.Id3", "d_abbey_22_5", Spot(-1261.7935, -268.4846, 20));
		AddSpawnPoint( "d_abbey_22_5.Id3", "d_abbey_22_5", Spot(-1047.7324, -270.6615, 20));
		AddSpawnPoint( "d_abbey_22_5.Id3", "d_abbey_22_5", Spot(-869.12244, -264.7155, 20));
		AddSpawnPoint( "d_abbey_22_5.Id3", "d_abbey_22_5", Spot(-955.3954, -964.5002, 20));
		AddSpawnPoint( "d_abbey_22_5.Id3", "d_abbey_22_5", Spot(-809.89636, -703.47705, 20));
		AddSpawnPoint( "d_abbey_22_5.Id3", "d_abbey_22_5", Spot(783.0479, -695.40326, 20));
		AddSpawnPoint( "d_abbey_22_5.Id3", "d_abbey_22_5", Spot(1347.892, -685.1245, 20));
		AddSpawnPoint( "d_abbey_22_5.Id3", "d_abbey_22_5", Spot(1340.2625, -1106.2773, 20));
		AddSpawnPoint( "d_abbey_22_5.Id3", "d_abbey_22_5", Spot(783.3131, -1090.5491, 20));
		AddSpawnPoint( "d_abbey_22_5.Id3", "d_abbey_22_5", Spot(986.6606, 144.6578, 20));
		AddSpawnPoint( "d_abbey_22_5.Id3", "d_abbey_22_5", Spot(1178.9534, 151.0079, 20));
		AddSpawnPoint( "d_abbey_22_5.Id3", "d_abbey_22_5", Spot(997.60175, 709.2055, 20));
		AddSpawnPoint( "d_abbey_22_5.Id3", "d_abbey_22_5", Spot(1210.6354, 714.4657, 20));
		AddSpawnPoint( "d_abbey_22_5.Id3", "d_abbey_22_5", Spot(1214.7955, 905.00854, 20));
		AddSpawnPoint( "d_abbey_22_5.Id3", "d_abbey_22_5", Spot(998.1293, 906.61304, 20));
		AddSpawnPoint( "d_abbey_22_5.Id3", "d_abbey_22_5", Spot(-1936.1243, -73.34359, 20));

		// Drooper Spawn Points
		AddSpawnPoint( "d_abbey_22_5.Id4", "d_abbey_22_5", Spot(-1738.0948, 767.04663, 20));
		AddSpawnPoint( "d_abbey_22_5.Id4", "d_abbey_22_5", Spot(-1735.9635, 1047.4761, 20));
		AddSpawnPoint( "d_abbey_22_5.Id4", "d_abbey_22_5", Spot(-1323.8926, 719.3413, 20));
		AddSpawnPoint( "d_abbey_22_5.Id4", "d_abbey_22_5", Spot(-1183.7607, 723.63416, 20));
		AddSpawnPoint( "d_abbey_22_5.Id4", "d_abbey_22_5", Spot(-1058.947, 721.01697, 20));
		AddSpawnPoint( "d_abbey_22_5.Id4", "d_abbey_22_5", Spot(-1446.825, 1571.7137, 20));
		AddSpawnPoint( "d_abbey_22_5.Id4", "d_abbey_22_5", Spot(-1466.5613, 1842.9835, 20));
		AddSpawnPoint( "d_abbey_22_5.Id4", "d_abbey_22_5", Spot(-992.63385, 1567.0167, 20));
		AddSpawnPoint( "d_abbey_22_5.Id4", "d_abbey_22_5", Spot(-946.93164, 1844.1962, 20));
		AddSpawnPoint( "d_abbey_22_5.Id4", "d_abbey_22_5", Spot(-1952.0281, -292.68997, 20));
		AddSpawnPoint( "d_abbey_22_5.Id4", "d_abbey_22_5", Spot(-1718.429, -44.612453, 20));
		AddSpawnPoint( "d_abbey_22_5.Id4", "d_abbey_22_5", Spot(-1947.878, -565.7595, 20));
		AddSpawnPoint( "d_abbey_22_5.Id4", "d_abbey_22_5", Spot(-1789.9725, -702.79333, 20));
		AddSpawnPoint( "d_abbey_22_5.Id4", "d_abbey_22_5", Spot(-578.8559, -17.603905, 20));
		AddSpawnPoint( "d_abbey_22_5.Id4", "d_abbey_22_5", Spot(597.5213, -23.83535, 20));
		AddSpawnPoint( "d_abbey_22_5.Id4", "d_abbey_22_5", Spot(1479.908, -6.2336063, 20));
		AddSpawnPoint( "d_abbey_22_5.Id4", "d_abbey_22_5", Spot(1074.3007, -434.02527, 20));
		AddSpawnPoint( "d_abbey_22_5.Id4", "d_abbey_22_5", Spot(-1224.2064, 1462.129, 20));
		AddSpawnPoint( "d_abbey_22_5.Id4", "d_abbey_22_5", Spot(-1223.6383, 1725.177, 20));
		AddSpawnPoint( "d_abbey_22_5.Id4", "d_abbey_22_5", Spot(1076.506, -691.5265, 20));

		// StonOrca_Red Spawn Points
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-334.70728, 965.11383, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-245.47008, 848.29626, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-338.44617, 774.13153, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-328.77386, 692.03253, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-287.07074, 564.9597, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-134.56357, 539.44696, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-126.8658, 713.65594, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(24.321587, 672.5598, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(150.07922, 589.36084, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(259.3532, 559.64655, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(379.88068, 588.93, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(406.89362, 733.93195, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(255.49597, 717.07227, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(209.3428, 870.24225, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(375.5672, 916.98663, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(170.09457, 999.13464, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(325.84985, 1129.8721, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-97.33811, 898.3127, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-165.49976, 1086.6062, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(625.15405, 796.161, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(823.0013, 787.5295, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1004.8503, 563.8799, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1150.4172, 893.6038, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1051.0178, 1065.1589, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1163.1332, 997.25745, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1227.2345, 601.6664, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1314.8123, 699.7356, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(903.14264, 719.0624, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1034.1295, 1089.0099, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1106.58, 1278.3116, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(994.45874, 1298.0891, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(915.04913, 1450.1287, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1069.6248, 1448.3931, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1150.622, 1531.2872, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1204.9951, 1468.7385, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1262.9436, 1318.396, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1205.3386, 1269.6145, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1474.8348, 779.91876, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1555.8365, 826.4726, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-580.7931, 819.8408, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-775.31714, 882.1657, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-884.1478, 840.56256, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-835.192, 1012.2984, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-980.20825, 848.66595, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1003.2341, 1056.1704, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-918.82666, 1031.4229, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1080.942, 1059.0233, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1208.4965, 1014.8462, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1194.1244, 1140.7513, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1326.4648, 914.04706, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1282.3197, 815.16394, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1051.4343, 931.391, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1109.1434, 775.0591, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1655.4111, 785.7635, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1605.7474, 893.57245, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1738.0016, 828.6059, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1699.664, 966.2752, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1623.3342, 1047.8749, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1866.5648, 1023.5768, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1870.5444, 844.1111, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1887.8931, 746.02277, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1180.9506, 1341.4537, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1343.508, 1446.8955, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1461.6025, 1442.8552, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1549.2983, 1553.5583, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1553.583, 1716.3656, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1639.8323, 1605.235, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1408.7432, 1655.233, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1311.9128, 1560.9105, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1253.3156, 1630.7198, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1347.218, 1720.4272, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1230.1311, 1843.2905, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1101.0123, 1560.3892, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1030.0718, 1458.4902, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-894.1075, 1439.819, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1062.8082, 1641.3333, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-861.2493, 1538.3174, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-837.73486, 1759.9468, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-956.80884, 1772.6868, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-896.84503, 1936.0131, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1096.6902, 1884.0793, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-110.10249, 103.8727, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(26.5471, 148.9015, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(72.16274, 24.347548, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(136.757, 133.03552, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(202.984, 25.044792, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(127.97363, -121.80046, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-94.28792, -101.22671, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-207.88818, 13.41588, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-268.32318, -105.9594, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-351.87473, 13.840694, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-130.96777, -272.104, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-8.078788, -260.6681, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(128.85727, -273.01297, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(311.03873, -192.13501, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(347.9706, 5.80735, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(22.48674, -198.6735, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(698.11926, 14.283813, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(914.2356, 39.403545, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(897.8958, -191.53856, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1005.4802, -7.7596054, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1118.4292, -168.36646, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1174.8794, 6.3905945, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1269.428, -141.0969, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1275.1498, 128.45168, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1058.8713, 108.69727, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1660.5812, -115.8903, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1710.1874, 155.0664, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1704.6747, -28.845173, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1932.7654, 90.866684, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1888.3816, -75.29706, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1790.2529, -179.34204, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1687.8513, -201.73482, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1587.7074, 12.729805, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(930.18884, -712.3374, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(830.39026, -867.2215, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(659.33386, -692.3972, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(637.9471, -900.8927, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(809.3647, -987.85645, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(638.9256, -1074.4193, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(935.0453, -1093.9678, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1035.2417, -896.123, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1079.7588, -1091.6637, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1214.3496, -1006.5786, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1293.5618, -1196.8617, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1440.0463, -1152.8448, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1473.9382, -977.40765, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1308.2743, -933.6748, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1504.274, -751.2722, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1220.251, -811.0686, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1447.2692, -683.38074, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1032.3796, -792.32477, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-893.8746, -130.94234, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-925.9658, 15.11916, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1031.5304, -155.12378, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1062.3517, -26.459946, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1186.2345, -155.80891, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1198.5647, -6.681674, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-941.8758, -56.56613, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1524.4346, 7.4491425, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1522.126, -66.93263, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1687.5496, -200.04585, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1839.8046, -144.95049, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1810.1039, -281.05997, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1802.5425, -47.581486, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-2002.0269, -222.11383, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1879.1437, -350.904, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1913.3359, -683.2556, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1821.7329, -645.3211, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-2025.1749, -499.40152, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1931.0658, -488.8884, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1669.5083, -752.09424, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1546.5487, -704.341, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1437.0624, -705.0963, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1646.6128, -842.9851, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1394.0004, -806.7637, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1302.4211, -922.8779, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1484.9681, -809.39655, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1339.1077, -704.01227, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1015.6993, -927.37885, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-1021.7631, -796.7796, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-969.88885, -865.77686, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-806.92267, -952.89594, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-759.1991, -778.7557, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(-974.2768, -701.0352, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1070.5923, -964.7627, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(1369.4376, -818.2256, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(773.288, -878.34735, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(995.19775, -1001.3798, 40));
		AddSpawnPoint( "d_abbey_22_5.Id5", "d_abbey_22_5", Spot(781.5117, -1084.5547, 40));

		// Hohen_Orben_Black Spawn Points
		AddSpawnPoint( "d_abbey_22_5.Id6", "d_abbey_22_5", Spot(269.82385, 774.5317, 20));
		AddSpawnPoint( "d_abbey_22_5.Id6", "d_abbey_22_5", Spot(-129.02771, 773.6379, 20));
		AddSpawnPoint( "d_abbey_22_5.Id6", "d_abbey_22_5", Spot(71.198456, 539.55817, 20));
		AddSpawnPoint( "d_abbey_22_5.Id6", "d_abbey_22_5", Spot(134.4043, 905.4446, 20));
		AddSpawnPoint( "d_abbey_22_5.Id6", "d_abbey_22_5", Spot(20.227058, 987.0317, 20));
		AddSpawnPoint( "d_abbey_22_5.Id6", "d_abbey_22_5", Spot(66.89255, 735.2431, 20));

		// Drooper Spawn Points
		AddSpawnPoint( "d_abbey_22_5.Id7", "d_abbey_22_5", Spot(-1218.0101, 1607.3472, 20));
		AddSpawnPoint( "d_abbey_22_5.Id7", "d_abbey_22_5", Spot(-1011.4857, 1767.3052, 20));

		// Harugal_Black Spawn Points
		AddSpawnPoint( "d_abbey_22_5.Id8", "d_abbey_22_5", Spot(957.30536, -922.3188, 20));
		AddSpawnPoint( "d_abbey_22_5.Id8", "d_abbey_22_5", Spot(1203.8931, -929.5523, 20));
		AddSpawnPoint( "d_abbey_22_5.Id8", "d_abbey_22_5", Spot(38.63601, -16.091587, 20));
		AddSpawnPoint( "d_abbey_22_5.Id8", "d_abbey_22_5", Spot(1220.7699, -14.102257, 20));
		AddSpawnPoint( "d_abbey_22_5.Id9", "d_abbey_22_5", Spot(1124.5322, -931.37024, 20));
		AddSpawnPoint( "d_abbey_22_5.Id9", "d_abbey_22_5", Spot(1064.7328, -40.408966, 20));
		AddSpawnPoint( "d_abbey_22_5.Id9", "d_abbey_22_5", Spot(121.53854, -95.499054, 20));

		// Drooper Spawn Points
		AddSpawnPoint( "d_abbey_22_5.Id10", "d_abbey_22_5", Spot(-1556.5364, -788.5261, 20));
		AddSpawnPoint( "d_abbey_22_5.Id10", "d_abbey_22_5", Spot(-1344.3749, -912.64496, 20));
		AddSpawnPoint( "d_abbey_22_5.Id10", "d_abbey_22_5", Spot(-1442.4722, -709.1158, 20));
		AddSpawnPoint( "d_abbey_22_5.Id10", "d_abbey_22_5", Spot(-1368.6194, -751.4134, 20));

	}
}
