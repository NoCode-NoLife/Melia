//--- Melia Script -----------------------------------------------------------
// Glade Hillroad Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_thorn_39_2'.
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
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(-1795, -915, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(-908, -107, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(-342, 739, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(-748, 1321, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(-1305, 1277, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(-1944, 1177, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(324, 1072, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(1126, 419, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(1466, 251, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(805, -316, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(-49, -313, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(-295, -891, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(264, -1431, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(696, 662, 50));
		AddSpawnPoint("d_thorn_39_2.Id1", "d_thorn_39_2", Rectangle(-1347, -354, 50));

		// 'Velwriggler_Mage_Green' GenType 23 Spawn Points
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-1353, 1188, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-1353, 1369, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-819, 1354, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-651, 1331, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-631, 795, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-460, 594, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-547, 368, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-326, 789, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-1297, -215, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-1076, -320, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(170, 622, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(348, 887, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(648, 907, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(563, 578, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(1112, 350, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(1333, 100, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(1454, 361, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(176, -1595, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-338, -409, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(326, -1585, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(130, -1442, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-338, -1053, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-413, -836, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-230, -212, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-77, -418, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(208, -1278, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-256, -544, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-417, -254, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-1301, -339, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-624, 597, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(197, 851, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(442, 789, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-403, 1338, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(-1204, 1339, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(459, 533, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(1356, 229, 30));
		AddSpawnPoint("d_thorn_39_2.Id2", "d_thorn_39_2", Rectangle(1159, -30, 30));

		// 'Big_Cockatries_Green' GenType 24 Spawn Points
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-1340, 256, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-1209, -287, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-218, -417, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-453, 480, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-413, -285, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-557, 786, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(787, -301, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(791, -185, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(430, 756, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(511, 917, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(246, 914, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-645, 571, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-570, 1096, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-951, 1273, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-733, 1443, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-441, 1403, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(-1187, 1335, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(1188, 341, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(1040, -145, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(1393, 276, 25));
		AddSpawnPoint("d_thorn_39_2.Id3", "d_thorn_39_2", Rectangle(1335, 122, 25));

		// 'Tombstone_Turtle' GenType 25 Spawn Points
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-55, -527, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-190, -276, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-261, -575, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-426, -1075, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-327, -925, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(94, -1303, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(338, -1622, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-528, -938, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-343, -297, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1311, -336, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-991, -185, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(670, -319, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(879, -86, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(855, -301, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(755, -144, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(1387, 172, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(667, -475, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(333, -1352, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-221, -422, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1123, -291, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-264, -1103, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(1055, -138, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(1267, 14, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(1028, 385, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(333, 579, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(599, 760, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(232, 904, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(237, -1477, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-2041, -989, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-2026, -721, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1658, -718, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1816, -921, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1753, -1167, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1594, -935, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(506, -358, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(636, -147, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(514, 594, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(481, 977, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(296, 737, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(1268, 210, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(1155, 477, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1230, -204, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1817, -804, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1965, -1184, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-27, -330, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-2077, -1223, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1929, -1261, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-2026, -1073, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1827, -1081, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-2114, -794, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1734, -766, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1638, -871, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1918, -804, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1690, -638, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1630, -494, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(49, -1670, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(15, -1530, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(209, -1369, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(317, -1260, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(241, -1722, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-462, -1155, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-529, -1067, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-488, -999, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-304, -837, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-290, -1167, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(1350, 418, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(1236, 428, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(1406, 488, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(1098, 442, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(873, -211, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(588, -391, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(646, 633, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(556, 686, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(290, 1005, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(380, 1139, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-417, 690, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-533, 696, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-727, 766, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-432, 366, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-645, 474, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1280, 200, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1411, 194, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1459, 316, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1339, 367, 30));
		AddSpawnPoint("d_thorn_39_2.Id4", "d_thorn_39_2", Rectangle(-1242, 315, 30));

		// 'Velwriggler_Mage_Green' GenType 34 Spawn Points
		AddSpawnPoint("d_thorn_39_2.Id5", "d_thorn_39_2", Rectangle(-259, -319, 9999));
	}
}
