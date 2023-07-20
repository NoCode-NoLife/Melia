//--- Melia Script -----------------------------------------------------------
// Izoliacjia Plateau Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_whitetrees_22_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FWhitetrees223MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_whitetrees_22_3.Id1", MonsterId.Rootcrystal_01, 11, 14, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_3.Id2", MonsterId.Bush_Beetle, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_3.Id3", MonsterId.Blossom_Beetle, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_3.Id4", MonsterId.Yakmambo, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_3.Id5", MonsterId.Yakmab, 36, 48, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_3.Id6", MonsterId.Hohen_Gulak_Black, 9, 11, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_whitetrees_22_3.Id7", MonsterId.Hohen_Mane_Black, 36, 47, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 22 Spawn Points
		AddSpawnPoint("f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Rectangle(20, 1199, 10));
		AddSpawnPoint("f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Rectangle(753, 947, 10));
		AddSpawnPoint("f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Rectangle(1477, 891, 10));
		AddSpawnPoint("f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Rectangle(-292, 468, 10));
		AddSpawnPoint("f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Rectangle(106, 25, 10));
		AddSpawnPoint("f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Rectangle(-280, -614, 10));
		AddSpawnPoint("f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Rectangle(-668, -1152, 10));
		AddSpawnPoint("f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Rectangle(195, -1170, 10));
		AddSpawnPoint("f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Rectangle(-1483, -1222, 10));
		AddSpawnPoint("f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Rectangle(-1097, -1277, 10));
		AddSpawnPoint("f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Rectangle(-1442, -548, 10));
		AddSpawnPoint("f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Rectangle(-1444, 227, 10));
		AddSpawnPoint("f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Rectangle(-1042, 270, 10));
		AddSpawnPoint("f_whitetrees_22_3.Id1", "f_whitetrees_22_3", Rectangle(256, 454, 10));

		// 'Bush_Beetle' GenType 28 Spawn Points
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(15, 1331, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-106, 1326, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-44, 1080, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(70, 1156, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(107, 1249, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-257, 989, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-375, 560, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-304, 668, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-387, 466, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-127, 606, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(15, 481, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-153, 238, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-386, 205, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-221, 65, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(33, 241, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-17, -16, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(324, 170, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(179, 200, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(152, 462, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(355, 624, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-108, 337, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-499, -844, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-549, -942, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-1468, 102, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-1364, 0, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-1190, 46, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-975, 19, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-446, -778, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-918, 124, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-1002, 135, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-1262, 170, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-1400, 205, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-92, 551, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-422, 290, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-98, 696, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-89, 1198, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(288, 540, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-158, -74, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(329, 8, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id2", "f_whitetrees_22_3", Rectangle(-373, -624, 40));

		// 'Blossom_Beetle' GenType 29 Spawn Points
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-289, -326, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-340, -219, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-297, -94, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(24, -829, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(111, -865, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-469, -779, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-767, -1036, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-825, -1215, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-719, -1231, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-562, -1210, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-1295, 455, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-1214, 470, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-1031, 464, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-924, 453, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-980, 340, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-1310, 263, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-1261, -480, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-482, -1041, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-494, -894, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-277, -443, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-224, 44, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-1377, -455, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-1020, 206, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-1143, 84, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-1301, 108, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-1406, 227, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id3", "f_whitetrees_22_3", Rectangle(-200, -687, 40));

		// 'Yakmambo' GenType 30 Spawn Points
		AddSpawnPoint("f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Rectangle(1388, 1110, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Rectangle(1404, 818, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Rectangle(1598, 965, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Rectangle(720, 909, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Rectangle(830, 929, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Rectangle(1220, -1054, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Rectangle(1286, -878, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Rectangle(1589, -982, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Rectangle(1518, -1748, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id4", "f_whitetrees_22_3", Rectangle(1745, -1725, 40));

		// 'Yakmab' GenType 31 Spawn Points
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1379, 897, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1329, 800, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1465, 760, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1518, 906, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1573, 1054, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1646, 891, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1376, 1005, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1307, 1106, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1456, 1129, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1266, 988, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1269, 885, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1673, 1064, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(595, 861, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(657, 979, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(736, 829, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(783, 995, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(880, 1039, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(937, 926, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(865, 844, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(489, 966, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(400, 1021, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(346, 1090, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1041, -1062, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1133, -1141, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1111, -974, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1244, -1172, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1170, -889, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1214, -764, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1372, -812, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1504, -842, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1605, -878, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1423, -1086, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1333, -993, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1367, -1162, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1564, -1138, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1508, -1005, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1658, -1052, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1702, -934, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1444, -1808, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1557, -1902, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1604, -1803, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1741, -1814, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1832, -1708, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1671, -1626, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1602, -1704, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1497, -1628, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1567, -1573, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id5", "f_whitetrees_22_3", Rectangle(1785, -1612, 40));

		// 'Hohen_Gulak_Black' GenType 32 Spawn Points
		AddSpawnPoint("f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Rectangle(-272, 312, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Rectangle(100, 356, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Rectangle(33, 71, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Rectangle(-95, 489, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Rectangle(72, -1236, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Rectangle(-1146, -1310, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Rectangle(-1619, -664, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Rectangle(-1415, -359, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Rectangle(-1326, 180, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Rectangle(-1018, 178, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id6", "f_whitetrees_22_3", Rectangle(-1198, 391, 40));

		// 'Hohen_Mane_Black' GenType 33 Spawn Points
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-373, 349, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-191, 437, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-262, 205, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-63, 63, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(11, 157, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(108, -54, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(115, 252, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(194, 366, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-15, 397, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-323, 100, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-386, -617, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-303, -531, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-210, -535, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-299, -695, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-167, -625, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-116, -727, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(109, -1149, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(170, -1089, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(238, -1037, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(143, -1278, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(235, -1293, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(438, -1184, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-997, -1284, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1090, -1196, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1339, -1370, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1440, -1379, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1354, -1276, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1539, -1123, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1459, -1080, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1576, -1249, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1538, -1359, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1482, -683, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1539, -608, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1615, -558, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1522, -468, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1423, -430, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1350, -514, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1307, -375, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1398, 117, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1297, 96, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1223, 168, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1104, 147, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1022, 86, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-915, 167, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1297, 372, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1214, 275, 40));
		AddSpawnPoint("f_whitetrees_22_3.Id7", "f_whitetrees_22_3", Rectangle(-1109, 352, 40));
	}
}
