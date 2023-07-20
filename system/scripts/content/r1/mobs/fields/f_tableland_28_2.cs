//--- Melia Script -----------------------------------------------------------
// Stogas Plateau Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_tableland_28_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FTableland282MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_tableland_28_2.Id1", MonsterId.Rootcrystal_03, 9, 11, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_tableland_28_2.Id2", MonsterId.Siaulav_Blue, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_28_2.Id3", MonsterId.Siaulav_Mage_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_28_2.Id4", MonsterId.Siaulav_Bow_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_28_2.Id5", MonsterId.Lapasape_Blue, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 3 Spawn Points
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(1392, 1220, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(933, 1032, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(422, 1060, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(-25, 1486, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(-358, 1528, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(294, 678, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(230, 300, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(-87, 490, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(-957, -502, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(-1467, -544, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(-1253, 119, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(-869, 325, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(-1128, 586, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(-1374, 1230, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(-1050, 1272, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(984, -470, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(1332, -405, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(1739, -31, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(92, -1378, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(173, -1863, 50));

		// 'Siaulav_Blue' GenType 30 Spawn Points
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1218, 1151, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-110, 1527, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-269, 1468, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-376, 1662, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(96, 653, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-83, 410, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1373, -405, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1412, -268, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1192, -317, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-921, -473, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1035, -752, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1065, -552, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1251, -627, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1354, -747, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1220, -495, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1512, -514, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1507, -652, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1422, 282, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1303, 724, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1361, 576, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1391, 456, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1226, 562, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1122, 724, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-784, 492, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-928, 614, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-961, 334, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1080, 512, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1151, 348, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1186, 184, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-933, 159, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-803, 284, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-666, 493, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-658, 307, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1012, 49, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1338, 136, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1262, 1404, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1460, 1079, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1292, 1264, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1386, 1343, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1420, 1209, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1202, 1110, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1129, 1271, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-177, 541, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(92, 499, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-39, 580, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(123, 286, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(236, 352, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(289, 568, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(227, 759, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-378, 1347, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-493, 1540, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-495, 1663, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-394, 1743, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-302, 1765, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-201, 1766, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-165, 1456, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-211, 1284, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-52, 1376, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-158, 1577, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-22, 1575, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-203, 1411, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-56, 1428, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(481, 1056, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(582, 1145, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(341, 1163, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(287, 1021, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1303, 984, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(983, 1105, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1419, 1264, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1109, 1020, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1353, 1128, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1148, 1304, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1010, -443, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1140, -563, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1064, -365, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1322, -447, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1213, -382, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1270, -551, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1323, -627, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1580, -111, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1603, 21, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1753, 82, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1726, -31, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1854, -52, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1665, -175, 30));

		// 'Siaulav_Mage_Blue' GenType 35 Spawn Points
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-265, 1590, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-128, 1308, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(1138, -414, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(906, -411, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(1176, -623, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-74, -1530, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(274, -1431, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(174, -1852, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-117, -1685, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(226, -1633, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-1260, -391, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-1467, -569, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-1194, -685, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-1158, 267, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-1484, -310, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-956, 277, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-1254, 681, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-443, 1455, 30));

		// 'Siaulav_Bow_Blue' GenType 40 Spawn Points
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-845, 541, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-938, 392, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-1326, 475, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-1344, 220, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-1374, 1129, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-1422, 1305, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-1222, 1229, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-1054, -476, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(164, -1489, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(62, -1830, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(1045, -402, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(1353, -337, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-758, -538, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-551, -692, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(351, 677, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(27, 536, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-244, 1597, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(108, 1275, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(1082, 1030, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(1669, 63, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(1237, -616, 30));

		// 'Lapasape_Blue' GenType 43 Spawn Points
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(407, 969, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(95, 437, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1225, -539, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(38, -1354, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(34, -1799, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(892, -512, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(1294, -418, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(1717, -34, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1276, 1289, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-223, 1540, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(183, 1237, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(259, -1797, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(18, -1980, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-135, -1697, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(97, -1497, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(309, -1627, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(993, -394, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(1147, -358, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(1100, -560, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(1268, -527, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(357, 420, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(22, 566, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(454, 1124, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(306, 1141, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-221, 1366, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-406, 1403, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-357, 1627, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-56, 1603, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1027, 1309, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1188, 1407, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1371, 1347, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1373, 1158, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1112, 1142, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1233, 635, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-964, 627, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-842, 236, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1249, 180, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1412, -316, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1534, -521, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1453, -682, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1204, -744, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-946, -502, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1039, 383, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(1601, -19, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(1686, -129, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(1770, 70, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(235, 293, 30));
	}
}
