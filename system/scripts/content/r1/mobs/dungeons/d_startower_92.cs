//--- Melia Script -----------------------------------------------------------
// Astral Tower 21F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_startower_92'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DStartower92MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_startower_92", MonsterId.Pipi, Properties("MHP", 659019, "MINPATK", 8975, "MAXPATK", 10933, "MINMATK", 8975, "MAXMATK", 10933, "DEF", 163153, "MDEF", 163153));
		AddPropertyOverrides("d_startower_92", MonsterId.Piang, Properties("MHP", 661232, "MINPATK", 9004, "MAXPATK", 10968, "MINMATK", 9004, "MAXMATK", 10968, "DEF", 164478, "MDEF", 164478));
		AddPropertyOverrides("d_startower_92", MonsterId.Vespera, Properties("MHP", 663470, "MINPATK", 9033, "MAXPATK", 11003, "MINMATK", 9033, "MAXMATK", 11003, "DEF", 165819, "MDEF", 165819));
		AddPropertyOverrides("d_startower_92", MonsterId.Vesperia, Properties("MHP", 665733, "MINPATK", 9062, "MAXPATK", 11039, "MINMATK", 9062, "MAXMATK", 11039, "DEF", 167174, "MDEF", 167174));
		AddPropertyOverrides("d_startower_92", MonsterId.Boss_Kubas_Q1, Properties("MHP", 3487072, "MINPATK", 22910, "MAXPATK", 27910, "MINMATK", 22910, "MAXMATK", 27910, "DEF", 424731, "MDEF", 424731));
		AddPropertyOverrides("d_startower_92", MonsterId.Boss_Ignas_Q1, Properties("MHP", 5711246, "MINPATK", 30282, "MAXPATK", 36892, "MINMATK", 30282, "MAXMATK", 36892, "DEF", 564164, "MDEF", 564164));

		// Monster Spawners ---------------------------------

		AddSpawner("d_startower_92.Id1", MonsterId.Pipi, 45, 60, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_92.Id2", MonsterId.Piang, 42, 55, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_92.Id3", MonsterId.Vespera, 22, 29, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_92.Id4", MonsterId.Vesperia, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_92.Id5", MonsterId.Rootcrystal_02, 17, 22, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Pipi' GenType 20 Spawn Points
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-138, 600, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-208, 811, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-623, 1492, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-456, 1421, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-476, 1295, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-235, 1153, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(94, 1283, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(103, 1599, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(68, 1465, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(464, 1149, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(555, 1290, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(705, 1496, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(690, 1738, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(952, 1312, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(704, 1127, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(882, 985, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(1141, 650, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(1367, 967, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(1575, 896, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(1530, 584, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(1655, 985, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(1753, 652, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(1124, 224, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(1222, 7, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(1154, -171, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(1827, 258, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(1553, -102, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(1760, -179, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(1101, -468, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(1506, -599, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(1427, -890, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(1776, -654, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(1716, -999, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(881, -1266, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(772, -1160, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(906, -931, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(618, -820, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(531, -1109, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(332, -1062, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-32, -1043, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(317, -854, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(317, -616, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(68, -768, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(490, -799, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(386, -546, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-51, -462, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-220, -727, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-200, -626, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-212, -1242, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-429, -1371, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-551, -1676, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-93, -1573, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-104, -1765, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-1229, -581, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-1058, -461, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-1441, -969, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-1584, -1308, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-1627, -914, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-1527, -466, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-1334, -270, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-1460, 229, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-1415, 398, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-1232, 415, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-1522, 750, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-1195, 664, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-1176, 871, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-974, 1186, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-1082, 1297, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-1215, 1635, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-1301, 1384, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-1503, 1270, 40));
		AddSpawnPoint("d_startower_92.Id1", "d_startower_92", Rectangle(-1290, 1173, 40));

		// 'Piang' GenType 21 Spawn Points
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-113, 690, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-189, 929, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-304, 1125, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-542, 1413, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-67, 1215, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-33, 1473, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(191, 1529, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(268, 1036, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(503, 1227, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(537, 1382, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(751, 1385, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(650, 1595, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(454, 1545, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(776, 1578, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(908, 1352, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(705, 1196, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(959, 1036, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(990, 816, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(1067, 480, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(1151, 320, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(1318, 695, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(1443, 903, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(1634, 594, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(1604, 772, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(1192, 70, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(1399, 41, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(1650, 236, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(1667, 20, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(1708, -108, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(1168, -367, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(1279, -718, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(1645, -679, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(896, -1097, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(813, -985, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(1094, -1020, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(369, -1166, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(624, -904, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(164, -603, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(159, -831, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(390, -708, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-113, -937, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-402, -1193, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-309, -1790, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-213, -1394, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-115, -442, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-1132, -659, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-1151, -501, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-1709, -1380, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-1521, -1211, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-1626, -1026, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-1477, -704, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-1533, -189, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-1409, -6, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-1503, 131, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-1339, 722, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-1198, 931, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-1371, 477, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-1037, 1559, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-1415, 1134, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-1281, 1523, 25));
		AddSpawnPoint("d_startower_92.Id2", "d_startower_92", Rectangle(-1083, 1188, 25));

		// 'Vespera' GenType 22 Spawn Points
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(1590, -700, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(1702, -874, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(1500, -875, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(1077, -825, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(1032, -1198, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(1003, -987, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(739, -1018, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(419, -931, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(201, -915, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(17, -708, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(86, -1053, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(-132, -851, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(-209, -1049, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(-334, -1305, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(-568, -1444, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(-432, -1801, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(-272, -1638, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(-201, -1766, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(-502, -1608, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(-101, -631, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(-98, -316, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(-1103, -581, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(1760, 137, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(1540, 161, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(1619, -987, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(1166, -567, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(496, -1004, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(-368, -1483, 25));
		AddSpawnPoint("d_startower_92.Id3", "d_startower_92", Rectangle(227, -572, 25));

		// 'Vesperia' GenType 23 Spawn Points
		AddSpawnPoint("d_startower_92.Id4", "d_startower_92", Rectangle(-1664, -1325, 25));
		AddSpawnPoint("d_startower_92.Id4", "d_startower_92", Rectangle(-1537, -1089, 25));
		AddSpawnPoint("d_startower_92.Id4", "d_startower_92", Rectangle(-1580, -764, 25));
		AddSpawnPoint("d_startower_92.Id4", "d_startower_92", Rectangle(-1366, -554, 25));
		AddSpawnPoint("d_startower_92.Id4", "d_startower_92", Rectangle(-1341, -135, 25));
		AddSpawnPoint("d_startower_92.Id4", "d_startower_92", Rectangle(-1522, -380, 25));
		AddSpawnPoint("d_startower_92.Id4", "d_startower_92", Rectangle(-1372, 115, 25));
		AddSpawnPoint("d_startower_92.Id4", "d_startower_92", Rectangle(-1565, -27, 25));
		AddSpawnPoint("d_startower_92.Id4", "d_startower_92", Rectangle(-1542, 600, 25));
		AddSpawnPoint("d_startower_92.Id4", "d_startower_92", Rectangle(-1296, 656, 25));
		AddSpawnPoint("d_startower_92.Id4", "d_startower_92", Rectangle(-1346, 1071, 25));
		AddSpawnPoint("d_startower_92.Id4", "d_startower_92", Rectangle(-1025, 1076, 25));
		AddSpawnPoint("d_startower_92.Id4", "d_startower_92", Rectangle(-1121, 1396, 25));
		AddSpawnPoint("d_startower_92.Id4", "d_startower_92", Rectangle(-1410, 1515, 25));
		AddSpawnPoint("d_startower_92.Id4", "d_startower_92", Rectangle(-998, 1507, 25));

		// 'Rootcrystal_02' GenType 28 Spawn Points
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(-102, 580, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(-1616, -1194, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(314, 1062, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(20, 1298, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(-82, -425, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(-319, 1172, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(668, 1496, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(-1132, 987, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(1004, 873, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(-1374, 490, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(-1469, -195, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(-349, -1628, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(-1125, -564, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(1704, 44, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(-245, -1063, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(1567, 763, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(929, -1109, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(1584, -786, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(284, -761, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(-1253, 1295, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(1141, -481, 200));
		AddSpawnPoint("d_startower_92.Id5", "d_startower_92", Rectangle(1167, 163, 200));
	}
}
