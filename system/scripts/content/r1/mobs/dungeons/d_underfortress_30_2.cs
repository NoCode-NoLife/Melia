//--- Melia Script -----------------------------------------------------------
// Extension Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_underfortress_30_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DUnderfortress302MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_underfortress_30_2.Id1", MonsterId.Saltisdaughter_Green, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_30_2.Id2", MonsterId.Colifly_Mage_Black, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_30_2.Id3", MonsterId.Colifly_Bow_Black, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_30_2.Id4", MonsterId.Rootcrystal_05, 11, 14, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Saltisdaughter_Green' GenType 1 Spawn Points
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-852, -95, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-843, 47, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-777, -38, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-794, 203, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-880, 355, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-793, 518, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-901, 744, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-1270, 420, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-1388, 313, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-1534, 389, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-1636, 336, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-1594, -4, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-1521, -93, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-1397, 5, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-1306, -75, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-1685, 759, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-1559, 689, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-1469, 764, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-1341, 691, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-1039, 1360, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-1056, 1607, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-867, 1406, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-824, 1325, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-881, 1563, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-361, 1330, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-322, 1544, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-220, 1392, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-162, 1574, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(62, 1378, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-75, 1306, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(386, 1356, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(496, 1581, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(500, 1451, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(626, 1326, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(633, 1557, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(927, 886, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(801, 918, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(893, 742, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(947, 420, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(827, 385, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(918, 209, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(955, 99, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(888, -114, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(919, -260, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(1030, -104, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(426, 909, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(426, 720, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(243, 717, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-67, 705, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-174, 842, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-317, 637, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-170, 637, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-137, 459, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-281, 394, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-271, 220, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-148, 140, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-320, 15, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-415, -92, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-165, -192, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(12, -17, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(254, -18, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(406, -201, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(442, -405, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(415, 46, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(363, 267, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(489, 349, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(409, 528, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-506, -676, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-289, -630, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-214, -689, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-173, -467, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-208, -271, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(77, -696, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(364, -579, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(492, -745, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(630, -567, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(701, -695, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(838, -575, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(901, -700, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(999, -570, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(1049, -687, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-848, 889, 30));
		AddSpawnPoint("d_underfortress_30_2.Id1", "d_underfortress_30_2", Rectangle(-472, 1418, 30));

		// 'Colifly_Mage_Black' GenType 2 Spawn Points
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-1659, 726, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-1434, 803, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-1490, 690, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-1373, 660, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-1315, 776, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-1626, -66, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-1580, -7, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-1433, -76, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-1394, -4, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-1268, -58, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(455, 1421, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(574, 1548, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(579, 1415, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(502, 1293, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(697, 1351, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-116, 1525, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-294, 1360, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-238, 1510, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-436, 1517, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-353, 1342, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(52, 1388, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-53, 1283, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-297, 868, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-363, 632, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-122, 734, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-133, 531, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-237, 321, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-398, 124, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-293, -112, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-233, 72, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-59, 137, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-63, -119, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-207, 457, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-413, 466, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(-172, -183, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(914, 832, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(829, 905, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(988, 937, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(971, 840, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(908, 455, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(887, 315, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(922, 260, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(977, -32, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(921, -130, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(836, -103, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(841, -235, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(959, -273, 30));
		AddSpawnPoint("d_underfortress_30_2.Id2", "d_underfortress_30_2", Rectangle(1004, -94, 30));

		// 'Colifly_Bow_Black' GenType 3 Spawn Points
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-855, -131, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-720, -79, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-889, 12, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-792, 189, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-893, 309, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-769, 505, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-893, 640, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-841, 863, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-1295, 411, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-1307, 283, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-1416, 370, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-1503, 313, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-1548, 397, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-1658, 347, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-1702, 421, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-1733, 305, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(357, -143, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(490, -114, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(362, -41, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(449, 10, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(349, 142, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(443, 185, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(363, 316, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(475, 340, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(365, 490, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(486, 513, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(444, 507, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(416, 637, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(338, 694, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(372, 779, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(420, 891, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(507, 843, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(478, 688, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-1070, 1346, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-1106, 1532, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-990, 1635, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-942, 1498, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-805, 1271, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-748, 1510, 30));
		AddSpawnPoint("d_underfortress_30_2.Id3", "d_underfortress_30_2", Rectangle(-609, 1419, 30));

		// 'Rootcrystal_05' GenType 15 Spawn Points
		AddSpawnPoint("d_underfortress_30_2.Id4", "d_underfortress_30_2", Rectangle(464, -88, 10));
		AddSpawnPoint("d_underfortress_30_2.Id4", "d_underfortress_30_2", Rectangle(928, -682, 10));
		AddSpawnPoint("d_underfortress_30_2.Id4", "d_underfortress_30_2", Rectangle(444, 821, 10));
		AddSpawnPoint("d_underfortress_30_2.Id4", "d_underfortress_30_2", Rectangle(-252, -649, 10));
		AddSpawnPoint("d_underfortress_30_2.Id4", "d_underfortress_30_2", Rectangle(-1249, -692, 10));
		AddSpawnPoint("d_underfortress_30_2.Id4", "d_underfortress_30_2", Rectangle(-144, 139, 10));
		AddSpawnPoint("d_underfortress_30_2.Id4", "d_underfortress_30_2", Rectangle(-759, 777, 10));
		AddSpawnPoint("d_underfortress_30_2.Id4", "d_underfortress_30_2", Rectangle(-824, -88, 10));
		AddSpawnPoint("d_underfortress_30_2.Id4", "d_underfortress_30_2", Rectangle(932, -160, 10));
		AddSpawnPoint("d_underfortress_30_2.Id4", "d_underfortress_30_2", Rectangle(943, 879, 10));
		AddSpawnPoint("d_underfortress_30_2.Id4", "d_underfortress_30_2", Rectangle(612, 1425, 10));
		AddSpawnPoint("d_underfortress_30_2.Id4", "d_underfortress_30_2", Rectangle(-253, 1403, 10));
		AddSpawnPoint("d_underfortress_30_2.Id4", "d_underfortress_30_2", Rectangle(-1496, 379, 10));
		AddSpawnPoint("d_underfortress_30_2.Id4", "d_underfortress_30_2", Rectangle(-278, 821, 10));
	}
}
