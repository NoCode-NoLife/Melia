//--- Melia Script -----------------------------------------------------------
// d_thorn_39_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Glade Hillroad' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DThorn392MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_thorn_39_2.Id1", MonsterId.Rootcrystal_01, 7, 9, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("d_thorn_39_2.Id2", MonsterId.Velwriggler_Mage_Green, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_39_2.Id3", MonsterId.Big_Cockatries_Green, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_39_2.Id4", MonsterId.Tombstone_Turtle, 45, 60, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_39_2.Id5", MonsterId.Velwriggler_Mage_Green, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 4 Spawn Points
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(-1795.1383, -915.0962, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(-908.43823, -107.42934, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(-342.48627, 739.9491, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(-748.20996, 1321.0493, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(-1305.4155, 1277.0988, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(-1944.5801, 1177.0836, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(324.12192, 1072.6029, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(1126.0254, 419.9986, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(1466.379, 251.21286, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(805.5703, -316.82773, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(-49.318832, -313.86237, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(-295.21387, -891.76465, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(264.19257, -1431.9795, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(696.6617, 662.83655, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(-1347.775, -354.7543, 50));

		// 'Velwriggler_Mage_Green' GenType 23 Spawn Points
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-1353.037, 1188.4236, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-1353.1477, 1369.8394, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-819.98596, 1354.5491, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-651.4919, 1331.319, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-631.3524, 795.20325, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-460.9524, 594.6968, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-547.24475, 368.61438, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-326.32883, 789.1942, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-1297.9623, -215.27031, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-1076.5984, -320.32443, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(170.48668, 622.39545, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(348.8613, 887.29517, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(648.44196, 907.4689, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(563.08765, 578.65326, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(1112.3981, 350.0089, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(1333.6049, 100.94335, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(1454.0829, 361.91232, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(176.32169, -1595.9098, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-338.91608, -409.7197, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(326.6014, -1585.1826, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(130.56285, -1442.2185, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-338.33588, -1053.6168, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-413.8646, -836.4739, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-230.57866, -212.16678, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-77.15918, -418.57642, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(208.24055, -1278.7377, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-256.89078, -544.85956, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-417.33438, -254.42174, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-1301.9767, -339.55756, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-624.81, 597.8437, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(197.27979, 851.05084, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(442.87534, 789.0681, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-403.11414, 1338.5413, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-1204.4938, 1339.041, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(459.12042, 533.73584, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(1356.3899, 229.11325, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(1159.2648, -30.80962, 30));

		// 'Big_Cockatries_Green' GenType 24 Spawn Points
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-1340.4984, 256.57346, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-1209.2246, -287.4636, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-218.63249, -417.3106, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-453.2033, 480.34302, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-413.4257, -285.3881, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-557.49884, 786.16394, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(787.09265, -301.15277, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(791.3056, -185.43405, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(430.5829, 756.83307, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(511.87283, 917.9362, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(246.20528, 914.5764, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-645.38074, 571.17865, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-570.59753, 1096.2654, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-951.87244, 1273.9481, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-733.09045, 1443.8967, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-441.62286, 1403.58, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-1187.1237, 1335.4987, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(1188.6897, 341.64954, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(1040.9556, -145.19856, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(1393.3674, 276.94104, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(1335.5585, 122.7896, 25));

		// 'Tombstone_Turtle' GenType 25 Spawn Points
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-55.254086, -527.813, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-190.89597, -276.79086, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-261.27856, -575.31433, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-426.958, -1075.5334, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-327.77823, -925.5234, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(94.77849, -1303.5183, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(338.86127, -1622.985, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-528.125, -938.1372, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-343.27777, -297.5564, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1311.7484, -336.19598, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-991.3674, -185.27943, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(670.3478, -319.9082, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(879.0442, -86.88507, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(855.75885, -301.1035, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(755.78534, -144.27266, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(1387.988, 172.65521, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(667.4667, -475.4689, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(333.9469, -1352.7218, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-221.18115, -422.42273, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1123.283, -291.54517, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-264.18097, -1103.7012, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(1055.0005, -138.82138, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(1267.0941, 14.220467, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(1028.9769, 385.3655, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(333.2122, 579.32166, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(599.80176, 760.6364, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(232.05865, 904.2548, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(237.34145, -1477.3995, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-2041.2036, -989.0323, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-2026.2002, -721.8758, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1658.7507, -718.86456, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1816.0717, -921.44556, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1753.6659, -1167.1803, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1594.3431, -935.68176, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(506.63278, -358.54324, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(636.6455, -147.73589, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(514.7057, 594.7658, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(481.95624, 977.8764, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(296.41092, 737.1546, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(1268.992, 210.0163, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(1155.9202, 477.96826, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1230.1663, -204.29788, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1817.8312, -804.1118, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1965.9016, -1184.4598, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-27.434357, -330.36707, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-2077.3132, -1223.8989, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1929.4155, -1261.0497, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-2026.1129, -1073.0352, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1827.0171, -1081.6539, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-2114.7373, -794.5385, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1734.2787, -766.2276, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1638.9779, -871.07745, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1918.1226, -804.6519, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1690.6069, -638.7157, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1630.9283, -494.72635, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(49.470974, -1670.4346, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(15.545402, -1530.3446, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(209.25706, -1369.8776, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(317.47363, -1260.9597, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(241.84116, -1722.9402, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-462.48254, -1155.4755, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-529.8934, -1067.3506, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-488.87128, -999.40094, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-304.80246, -837.28973, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-290.0276, -1167.095, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(1350.6377, 418.7348, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(1236.151, 428.47183, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(1406.2609, 488.9138, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(1098.003, 442.98636, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(873.6159, -211.46817, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(588.6844, -391.3473, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(646.8025, 633.72943, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(556.3408, 686.93634, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(290.6954, 1005.2715, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(380.7955, 1139.2861, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-417.2874, 690.6648, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-533.8213, 696.3017, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-727.17896, 766.62555, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-432.333, 366.72052, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-645.1956, 474.06775, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1280.4706, 200.92291, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1411.5146, 194.86835, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1459.3057, 316.0308, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1339.4783, 367.30243, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1242.5098, 315.83087, 30));

		// 'Velwriggler_Mage_Green' GenType 34 Spawn Points
		AddSpawnPoint("d_thorn_39_2.Id5", "d_thorn_39_2", Rectangle(-259.33298, -319.38046, 9999));
	}
}
