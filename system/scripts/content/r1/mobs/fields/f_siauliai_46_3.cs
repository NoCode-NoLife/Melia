//--- Melia Script -----------------------------------------------------------
// Vilna Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_siauliai_46_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliai463MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_siauliai_46_3", MonsterId.Chupaluka, Properties("MHP", 234701, "MINPATK", 3519, "MAXPATK", 4226, "MINMATK", 3519, "MAXMATK", 4226, "DEF", 11164, "MDEF", 11164));
		AddPropertyOverrides("f_siauliai_46_3", MonsterId.Spion, Properties("MHP", 236299, "MINPATK", 3540, "MAXPATK", 4252, "MINMATK", 3540, "MAXMATK", 4252, "DEF", 11377, "MDEF", 11377));
		AddPropertyOverrides("f_siauliai_46_3", MonsterId.Siaulago, Properties("MHP", 237947, "MINPATK", 3561, "MAXPATK", 4278, "MINMATK", 3561, "MAXMATK", 4278, "DEF", 11597, "MDEF", 11597));
		AddPropertyOverrides("f_siauliai_46_3", MonsterId.Honeymeli, Properties("MHP", 239645, "MINPATK", 3583, "MAXPATK", 4305, "MINMATK", 3583, "MAXMATK", 4305, "DEF", 11824, "MDEF", 11824));
		AddPropertyOverrides("f_siauliai_46_3", MonsterId.Boss_Strongholder_Q3, Properties("MHP", 1231089, "MINPATK", 8653, "MAXPATK", 10397, "MINMATK", 8653, "MAXMATK", 10397, "DEF", 28937, "MDEF", 28937));

		// Monster Spawners ---------------------------------

		AddSpawner("f_siauliai_46_3.Id1", MonsterId.Chupaluka, 45, 60, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_3.Id2", MonsterId.Spion, 12, 15, TimeSpan.FromMilliseconds(200000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_3.Id3", MonsterId.Siaulago, 15, 20, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_3.Id4", MonsterId.Honeymeli, 3, 4, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_3.Id5", MonsterId.Rootcrystal_01, 11, 14, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_3.Id6", MonsterId.Spion, 15, 20, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_3.Id7", MonsterId.Siaulago, 8, 10, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_3.Id8", MonsterId.Honeymeli, 3, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_3.Id9", MonsterId.Chupaluka, 14, 18, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Chupaluka' GenType 4 Spawn Points
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1032, 1078, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-1475, 1025, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(941, 968, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1548, 862, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-436, 1519, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(670, 1476, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(374, 1076, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-308, 1640, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(192, 1138, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(46, 1007, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-396, 1000, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(914, 1626, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1166, 1548, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1763, 1690, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1835, 1731, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1848, 1602, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1750, 1611, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1626, 1508, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1564, 1589, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-970, 974, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-1164, 1288, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1654, 1739, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1677, 1665, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1568, 1667, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1341, 1795, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-1679, 1105, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1864, 1919, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1888, 1827, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1724, 1875, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1660, 1921, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1662, 1807, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1515, 1934, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1435, 1964, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-373, 1754, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-254, 1696, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1480, 1853, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1512, 1753, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1450, 1644, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1382, 1722, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-324, 1444, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1344, 1555, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-1499, 891, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-220, 1466, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1250, 1651, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1364, 1643, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1097, 1506, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1086, 1629, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1216, 1594, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(832, 1644, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(796, 1583, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(737, 1501, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-523, 1588, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(728, 1687, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-549, 1691, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-1591, 964, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(608, 1389, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(532, 1392, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(460, 1390, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(382, 1407, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(474, 1470, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(557, 1511, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(538, 1464, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-1459, 1226, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(429, 1535, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(431, 1625, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(498, 1674, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(565, 1705, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(634, 1725, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(685, 1739, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(638, 1672, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(653, 1628, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(547, 1614, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(450, 1588, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1666, 912, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-1079, 894, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-1270, 984, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1284, 822, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1506, 946, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1583, 1015, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1412, 1032, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-1220, 1166, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1189, 906, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1403, 848, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1154, 980, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1144, 803, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(958, 762, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-521, 964, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(984, 856, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1033, 1154, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1196, 1130, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1283, 1155, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1372, 924, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1307, 988, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1211, 1064, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-1110, 1145, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1085, 1028, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-1332, 1235, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(999, 1225, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-590, 1090, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-794, 1051, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-417, 1131, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-727, 917, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(932, 1060, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(877, 1166, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(840, 1056, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-588, 1258, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(886, 870, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(1089, 891, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(580, 1046, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(551, 919, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-1387, 1106, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(428, 859, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(334, 863, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-1549, 1121, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(439, 1177, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(332, 1186, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(293, 1042, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(274, 913, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(231, 1088, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-288, 1555, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-201, 1602, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-158, 1525, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(235, 814, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(148, 826, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(81, 916, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(117, 999, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(174, 977, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-1349, 996, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(94, 1148, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(32, 1097, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-64, 1052, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(-63, 992, 30));
		AddSpawnPoint("f_siauliai_46_3.Id1", "f_siauliai_46_3", Rectangle(36, 936, 30));

		// 'Spion' GenType 6 Spawn Points
		AddSpawnPoint("f_siauliai_46_3.Id2", "f_siauliai_46_3", Rectangle(-1123, 1030, 9999));

		// 'Siaulago' GenType 18 Spawn Points
		AddSpawnPoint("f_siauliai_46_3.Id3", "f_siauliai_46_3", Rectangle(-590, -230, 40));
		AddSpawnPoint("f_siauliai_46_3.Id3", "f_siauliai_46_3", Rectangle(-870, -301, 40));
		AddSpawnPoint("f_siauliai_46_3.Id3", "f_siauliai_46_3", Rectangle(-884, -628, 40));
		AddSpawnPoint("f_siauliai_46_3.Id3", "f_siauliai_46_3", Rectangle(-1825, -1412, 40));
		AddSpawnPoint("f_siauliai_46_3.Id3", "f_siauliai_46_3", Rectangle(-508, -662, 40));
		AddSpawnPoint("f_siauliai_46_3.Id3", "f_siauliai_46_3", Rectangle(-435, -403, 40));
		AddSpawnPoint("f_siauliai_46_3.Id3", "f_siauliai_46_3", Rectangle(-1656, -461, 40));
		AddSpawnPoint("f_siauliai_46_3.Id3", "f_siauliai_46_3", Rectangle(-1978, -1085, 40));
		AddSpawnPoint("f_siauliai_46_3.Id3", "f_siauliai_46_3", Rectangle(-1518, -1399, 40));
		AddSpawnPoint("f_siauliai_46_3.Id3", "f_siauliai_46_3", Rectangle(-1766, -643, 40));
		AddSpawnPoint("f_siauliai_46_3.Id3", "f_siauliai_46_3", Rectangle(-1718, -1320, 40));
		AddSpawnPoint("f_siauliai_46_3.Id3", "f_siauliai_46_3", Rectangle(-693, -461, 40));

		// 'Honeymeli' GenType 19 Spawn Points
		AddSpawnPoint("f_siauliai_46_3.Id4", "f_siauliai_46_3", Rectangle(-404, 1632, 1500));

		// 'Rootcrystal_01' GenType 20 Spawn Points
		AddSpawnPoint("f_siauliai_46_3.Id5", "f_siauliai_46_3", Rectangle(-1864, -1447, 200));
		AddSpawnPoint("f_siauliai_46_3.Id5", "f_siauliai_46_3", Rectangle(-1701, -629, 200));
		AddSpawnPoint("f_siauliai_46_3.Id5", "f_siauliai_46_3", Rectangle(-840, -612, 200));
		AddSpawnPoint("f_siauliai_46_3.Id5", "f_siauliai_46_3", Rectangle(-524, -192, 200));
		AddSpawnPoint("f_siauliai_46_3.Id5", "f_siauliai_46_3", Rectangle(-1224, 1062, 200));
		AddSpawnPoint("f_siauliai_46_3.Id5", "f_siauliai_46_3", Rectangle(-388, 1559, 200));
		AddSpawnPoint("f_siauliai_46_3.Id5", "f_siauliai_46_3", Rectangle(-576, 996, 200));
		AddSpawnPoint("f_siauliai_46_3.Id5", "f_siauliai_46_3", Rectangle(451, 1010, 200));
		AddSpawnPoint("f_siauliai_46_3.Id5", "f_siauliai_46_3", Rectangle(675, 1601, 200));
		AddSpawnPoint("f_siauliai_46_3.Id5", "f_siauliai_46_3", Rectangle(1479, 1763, 200));
		AddSpawnPoint("f_siauliai_46_3.Id5", "f_siauliai_46_3", Rectangle(1002, 953, 200));
		AddSpawnPoint("f_siauliai_46_3.Id5", "f_siauliai_46_3", Rectangle(2287, -207, 200));
		AddSpawnPoint("f_siauliai_46_3.Id5", "f_siauliai_46_3", Rectangle(3345, 1020, 200));
		AddSpawnPoint("f_siauliai_46_3.Id5", "f_siauliai_46_3", Rectangle(358, -911, 200));

		// 'Spion' GenType 22 Spawn Points
		AddSpawnPoint("f_siauliai_46_3.Id6", "f_siauliai_46_3", Rectangle(182, -882, 20));
		AddSpawnPoint("f_siauliai_46_3.Id6", "f_siauliai_46_3", Rectangle(391, -897, 20));
		AddSpawnPoint("f_siauliai_46_3.Id6", "f_siauliai_46_3", Rectangle(433, -772, 20));
		AddSpawnPoint("f_siauliai_46_3.Id6", "f_siauliai_46_3", Rectangle(425, -614, 20));
		AddSpawnPoint("f_siauliai_46_3.Id6", "f_siauliai_46_3", Rectangle(330, -978, 20));
		AddSpawnPoint("f_siauliai_46_3.Id6", "f_siauliai_46_3", Rectangle(520, -882, 20));

		// 'Siaulago' GenType 24 Spawn Points
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(83, -506, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(125, -612, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-77, -501, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(109, -886, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(419, -812, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(259, -978, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(493, -732, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(528, -665, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(413, -566, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(525, -869, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(428, -929, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(623, -845, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(575, -760, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(704, -734, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(761, -706, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(833, -562, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(700, -474, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(927, -633, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(822, -657, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(747, -554, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(695, -629, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(606, -506, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(597, -603, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(506, -576, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(539, -506, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(392, -684, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(330, -926, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(192, -897, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(145, -983, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(287, -807, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(155, -791, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(45, -593, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-11, -547, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(30, -442, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-62, -426, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-48, -327, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-164, -449, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-113, -556, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-129, -326, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-181, -289, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-185, -374, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-407, -346, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-402, -255, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-566, -108, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-560, -227, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-496, 1156, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-490, -455, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-359, -454, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-431, -693, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-375, -790, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-461, -809, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-308, -658, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-362, -557, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-473, -584, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-578, -804, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-578, -687, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-594, -448, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-573, -568, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-736, -753, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-819, -642, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-816, -521, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-690, -637, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-915, -338, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-789, -311, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-758, -223, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-683, -131, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-615, -46, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-660, 99, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-658, 1163, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-443, -57, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-393, -145, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-693, 1033, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-813, -420, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-704, -384, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-696, -504, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-903, -480, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-970, -593, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-950, -685, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-861, -782, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-662, -879, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-776, -857, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1478, -334, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1629, -329, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1536, -468, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1641, -559, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1546, -728, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1623, -700, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1744, -724, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1773, -473, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1726, -389, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1641, -454, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1707, -627, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1565, -634, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1785, -571, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1671, -790, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1886, -536, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1947, -611, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1971, -728, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1873, -777, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1771, -820, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1828, -650, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1860, -1127, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1939, -1163, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1897, -1261, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1801, -1168, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1810, -1275, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1876, -1389, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1785, -1398, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1927, -1482, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1828, -1503, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1719, -1593, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1693, -1386, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1616, -1370, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1548, -1318, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1465, -1346, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1356, -1331, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1381, -1409, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1570, -1452, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1659, -1509, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1489, -1421, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1642, -1268, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1749, -1500, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1842, -1585, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-1972, -1581, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-2068, -1456, 25));
		AddSpawnPoint("f_siauliai_46_3.Id7", "f_siauliai_46_3", Rectangle(-2045, -1345, 25));

		// 'Honeymeli' GenType 25 Spawn Points
		AddSpawnPoint("f_siauliai_46_3.Id8", "f_siauliai_46_3", Rectangle(-608, -747, 25));
		AddSpawnPoint("f_siauliai_46_3.Id8", "f_siauliai_46_3", Rectangle(-783, -765, 25));
		AddSpawnPoint("f_siauliai_46_3.Id8", "f_siauliai_46_3", Rectangle(-847, -334, 25));
		AddSpawnPoint("f_siauliai_46_3.Id8", "f_siauliai_46_3", Rectangle(-443, -281, 25));

		// 'Chupaluka' GenType 26 Spawn Points
		AddSpawnPoint("f_siauliai_46_3.Id9", "f_siauliai_46_3", Rectangle(1788, 1518, 25));
		AddSpawnPoint("f_siauliai_46_3.Id9", "f_siauliai_46_3", Rectangle(1790, 1810, 25));
		AddSpawnPoint("f_siauliai_46_3.Id9", "f_siauliai_46_3", Rectangle(1609, 1839, 25));
		AddSpawnPoint("f_siauliai_46_3.Id9", "f_siauliai_46_3", Rectangle(1397, 1860, 25));
		AddSpawnPoint("f_siauliai_46_3.Id9", "f_siauliai_46_3", Rectangle(1417, 1534, 25));
		AddSpawnPoint("f_siauliai_46_3.Id9", "f_siauliai_46_3", Rectangle(1700, 1497, 25));
		AddSpawnPoint("f_siauliai_46_3.Id9", "f_siauliai_46_3", Rectangle(1537, 1486, 25));
		AddSpawnPoint("f_siauliai_46_3.Id9", "f_siauliai_46_3", Rectangle(1628, 1627, 25));
		AddSpawnPoint("f_siauliai_46_3.Id9", "f_siauliai_46_3", Rectangle(1591, 1913, 25));
		AddSpawnPoint("f_siauliai_46_3.Id9", "f_siauliai_46_3", Rectangle(-133, 1645, 25));
	}
}
