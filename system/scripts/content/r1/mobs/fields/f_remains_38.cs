//--- Melia Script -----------------------------------------------------------
// Goddess' Ancient Garden Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_remains_38'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRemains38MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_remains_38.Id1", MonsterId.InfroBurk, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_38.Id2", MonsterId.Lizardman, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_38.Id3", MonsterId.Long_Arm, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_38.Id4", MonsterId.Lizardman, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_38.Id5", MonsterId.Lizardman, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_38.Id6", MonsterId.InfroBurk, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_38.Id7", MonsterId.Rootcrystal_01, 14, 18, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_remains_38.Id8", MonsterId.Stub_Tree_Mage, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_38.Id9", MonsterId.Long_Arm, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'InfroBurk' GenType 3 Spawn Points
		AddSpawnPoint("f_remains_38.Id1", "f_remains_38", Rectangle(-2034, 708, 20));
		AddSpawnPoint("f_remains_38.Id1", "f_remains_38", Rectangle(-1846, 503, 20));
		AddSpawnPoint("f_remains_38.Id1", "f_remains_38", Rectangle(-1875, 720, 20));
		AddSpawnPoint("f_remains_38.Id1", "f_remains_38", Rectangle(-1688, 599, 20));
		AddSpawnPoint("f_remains_38.Id1", "f_remains_38", Rectangle(-1684, 501, 20));
		AddSpawnPoint("f_remains_38.Id1", "f_remains_38", Rectangle(-1862, 623, 20));
		AddSpawnPoint("f_remains_38.Id1", "f_remains_38", Rectangle(-2000, 856, 20));
		AddSpawnPoint("f_remains_38.Id1", "f_remains_38", Rectangle(-2011, 570, 20));
		AddSpawnPoint("f_remains_38.Id1", "f_remains_38", Rectangle(-1743, 706, 20));

		// 'Lizardman' GenType 5 Spawn Points
		AddSpawnPoint("f_remains_38.Id2", "f_remains_38", Rectangle(-716, 571, 30));
		AddSpawnPoint("f_remains_38.Id2", "f_remains_38", Rectangle(-351, 340, 30));
		AddSpawnPoint("f_remains_38.Id2", "f_remains_38", Rectangle(-958, -534, 30));
		AddSpawnPoint("f_remains_38.Id2", "f_remains_38", Rectangle(-820, -409, 30));
		AddSpawnPoint("f_remains_38.Id2", "f_remains_38", Rectangle(-918, 377, 30));
		AddSpawnPoint("f_remains_38.Id2", "f_remains_38", Rectangle(-1028, -117, 30));
		AddSpawnPoint("f_remains_38.Id2", "f_remains_38", Rectangle(-1069, -327, 30));
		AddSpawnPoint("f_remains_38.Id2", "f_remains_38", Rectangle(-1007, 282, 30));
		AddSpawnPoint("f_remains_38.Id2", "f_remains_38", Rectangle(-622, 753, 30));
		AddSpawnPoint("f_remains_38.Id2", "f_remains_38", Rectangle(-419, 187, 30));
		AddSpawnPoint("f_remains_38.Id2", "f_remains_38", Rectangle(-876, 62, 30));
		AddSpawnPoint("f_remains_38.Id2", "f_remains_38", Rectangle(-1183, -34, 30));
		AddSpawnPoint("f_remains_38.Id2", "f_remains_38", Rectangle(-607, 284, 30));

		// 'Long_Arm' GenType 71 Spawn Points
		AddSpawnPoint("f_remains_38.Id3", "f_remains_38", Rectangle(-143, -961, 20));
		AddSpawnPoint("f_remains_38.Id3", "f_remains_38", Rectangle(563, -726, 20));
		AddSpawnPoint("f_remains_38.Id3", "f_remains_38", Rectangle(407, -1061, 20));
		AddSpawnPoint("f_remains_38.Id3", "f_remains_38", Rectangle(-185, -1114, 20));
		AddSpawnPoint("f_remains_38.Id3", "f_remains_38", Rectangle(399, -835, 20));
		AddSpawnPoint("f_remains_38.Id3", "f_remains_38", Rectangle(233, -810, 20));
		AddSpawnPoint("f_remains_38.Id3", "f_remains_38", Rectangle(262, -1323, 20));
		AddSpawnPoint("f_remains_38.Id3", "f_remains_38", Rectangle(-924, -1183, 20));
		AddSpawnPoint("f_remains_38.Id3", "f_remains_38", Rectangle(-1210, -1129, 20));
		AddSpawnPoint("f_remains_38.Id3", "f_remains_38", Rectangle(-1192, -971, 20));
		AddSpawnPoint("f_remains_38.Id3", "f_remains_38", Rectangle(-1544, -889, 20));
		AddSpawnPoint("f_remains_38.Id3", "f_remains_38", Rectangle(-1737, -782, 20));
		AddSpawnPoint("f_remains_38.Id3", "f_remains_38", Rectangle(-714, -1003, 20));

		// 'Lizardman' GenType 72 Spawn Points
		AddSpawnPoint("f_remains_38.Id4", "f_remains_38", Rectangle(-955, -54, 9999));

		// 'Lizardman' GenType 76 Spawn Points
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(1557, 1006, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(1172, 957, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(1255, 645, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(1579, 411, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(1465, 529, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-1133, -192, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-1070, -192, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-1006, -242, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-968, -327, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-994, -390, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-1043, -420, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-1076, -471, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-768, -509, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-701, -446, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-762, -413, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-996, -102, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-927, 16, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-867, 4, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-872, -33, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-1017, 212, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-1043, 318, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-1038, 369, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-982, 390, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-973, 326, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-893, 303, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-830, 407, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-856, 475, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-939, 473, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-1023, 513, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-862, 312, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-710, 377, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-670, 449, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-702, 533, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-636, 611, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-577, 570, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-569, 505, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-621, 402, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-639, 328, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-645, 239, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-580, 197, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-400, 324, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-342, 370, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-280, 266, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-356, 210, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-364, 150, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-234, 323, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-280, 332, 25));
		AddSpawnPoint("f_remains_38.Id5", "f_remains_38", Rectangle(-300, 374, 25));

		// 'InfroBurk' GenType 77 Spawn Points
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(1084, -841, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(1069, -1042, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(1186, -848, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(1327, -742, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(1473, -762, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(1558, -603, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(1084, -1165, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(1403, -634, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(1496, -877, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(1441, -489, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(1293, -1011, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(954, -922, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(1197, -1043, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(1286, -1143, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(1454, -1039, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(1402, -889, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(1016, -972, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(921, -1022, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(873, -943, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(872, -814, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(967, -717, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(1038, -737, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(1044, -801, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(1035, -884, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(1137, -988, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(990, -1108, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(886, -1103, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(808, -1025, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(791, -930, 25));
		AddSpawnPoint("f_remains_38.Id6", "f_remains_38", Rectangle(816, -801, 25));

		// 'Rootcrystal_01' GenType 84 Spawn Points
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(-1298, -1125, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(-1454, -1766, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(-1812, -1565, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(-779, -1108, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(-883, -605, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(-1020, -247, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(-987, 74, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(-905, 370, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(-1849, 641, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(-1276, 565, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(-655, 651, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(-324, 1060, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(138, 1147, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(214, 556, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(120, 248, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(-270, 356, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(-15, -957, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(219, -1143, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(376, -1172, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(687, -997, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(1347, -1039, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(1384, -591, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(1074, -1056, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(1555, -228, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(1477, 505, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(1178, 848, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(1539, 892, 100));
		AddSpawnPoint("f_remains_38.Id7", "f_remains_38", Rectangle(1420, 1384, 100));

		// 'Stub_Tree_Mage' GenType 85 Spawn Points
		AddSpawnPoint("f_remains_38.Id8", "f_remains_38", Rectangle(-117, -1006, 40));
		AddSpawnPoint("f_remains_38.Id8", "f_remains_38", Rectangle(170, -1240, 40));
		AddSpawnPoint("f_remains_38.Id8", "f_remains_38", Rectangle(-1107, -252, 40));
		AddSpawnPoint("f_remains_38.Id8", "f_remains_38", Rectangle(-955, 162, 40));
		AddSpawnPoint("f_remains_38.Id8", "f_remains_38", Rectangle(-135, 317, 40));
		AddSpawnPoint("f_remains_38.Id8", "f_remains_38", Rectangle(-761, 421, 40));
		AddSpawnPoint("f_remains_38.Id8", "f_remains_38", Rectangle(-834, -359, 40));
		AddSpawnPoint("f_remains_38.Id8", "f_remains_38", Rectangle(1193, 765, 40));
		AddSpawnPoint("f_remains_38.Id8", "f_remains_38", Rectangle(1559, 928, 40));
		AddSpawnPoint("f_remains_38.Id8", "f_remains_38", Rectangle(1405, 721, 40));
		AddSpawnPoint("f_remains_38.Id8", "f_remains_38", Rectangle(1135, -1109, 40));
		AddSpawnPoint("f_remains_38.Id8", "f_remains_38", Rectangle(1401, -839, 40));
		AddSpawnPoint("f_remains_38.Id8", "f_remains_38", Rectangle(1132, -858, 40));

		// 'Long_Arm' GenType 89 Spawn Points
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-69, -1042, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(12, -1134, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1360, -1758, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1353, -1981, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1241, -2054, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1252, -1862, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1470, -1902, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(1284, 570, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(1353, 778, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(1485, 834, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(1427, 635, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(1464, 379, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(1593, 387, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(1570, 616, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1584, -2008, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1668, -1794, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1640, -1661, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1500, -1609, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1389, -2174, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1184, -1830, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1408, -1251, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1337, -1232, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1258, -1204, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1097, -971, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1359, -1141, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1300, -913, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1203, -1000, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1188, -1113, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1391, -968, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1804, -754, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1707, -800, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1745, -848, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-753, -1128, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-1033, -1207, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-992, -1071, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-860, -1003, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-901, -1162, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-743, -1012, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-691, -1233, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-599, -1132, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-587, -1051, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-180, -917, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(-101, -686, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(6, -776, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(34, -926, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(340, -1270, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(229, -1210, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(267, -1107, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(67, -654, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(306, -932, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(185, -992, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(366, -792, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(470, -961, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(494, -775, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(567, -855, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(1464, 987, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(1389, 1125, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(1207, 1014, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(1132, 862, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(1113, 550, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(1085, 706, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(1385, 651, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(1270, 413, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(1593, 883, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(1644, 1028, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(178, 430, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(39, 398, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(160, 267, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(32, 135, 20));
		AddSpawnPoint("f_remains_38.Id9", "f_remains_38", Rectangle(252, 195, 20));
	}
}
