//--- Melia Script -----------------------------------------------------------
// Pilgrim Path Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_pilgrimroad_47'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad47MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_pilgrimroad_47", MonsterId.Triffid, Properties("MHP", 127109, "MINPATK", 2136, "MAXPATK", 2527, "MINMATK", 2136, "MAXMATK", 2527, "DEF", 2113, "MDEF", 2113));
		AddPropertyOverrides("f_pilgrimroad_47", MonsterId.Rondo_Red, Properties("MHP", 127931, "MINPATK", 2146, "MAXPATK", 2540, "MINMATK", 2146, "MAXMATK", 2540, "DEF", 2161, "MDEF", 2161));
		AddPropertyOverrides("f_pilgrimroad_47", MonsterId.Rubabos_Red, Properties("MHP", 128840, "MINPATK", 2158, "MAXPATK", 2554, "MINMATK", 2158, "MAXMATK", 2554, "DEF", 2213, "MDEF", 2213));

		// Monster Spawners ---------------------------------

		AddSpawner("f_pilgrimroad_47.Id1", MonsterId.Triffid, min: 8, max: 10);
		AddSpawner("f_pilgrimroad_47.Id2", MonsterId.Rondo_Red, min: 23, max: 30);
		AddSpawner("f_pilgrimroad_47.Id3", MonsterId.Rubabos_Red, min: 3, max: 4);
		AddSpawner("f_pilgrimroad_47.Id4", MonsterId.Rondo_Red, min: 8, max: 10);
		AddSpawner("f_pilgrimroad_47.Id5", MonsterId.Rootcrystal_01, min: 4, max: 5, respawn: TimeSpan.FromMilliseconds(5000));
		AddSpawner("f_pilgrimroad_47.Id6", MonsterId.Spell_Crystal_Red, min: 9, max: 11);
		AddSpawner("f_pilgrimroad_47.Id7", MonsterId.Triffid, min: 60, max: 80);

		// Monster Spawn Points -----------------------------

		// 'Triffid' GenType 7 Spawn Points
		AddSpawnPoint("f_pilgrimroad_47.Id1", "f_pilgrimroad_47", Rectangle(-993, 797, 25));
		AddSpawnPoint("f_pilgrimroad_47.Id1", "f_pilgrimroad_47", Rectangle(-1335, 819, 25));
		AddSpawnPoint("f_pilgrimroad_47.Id1", "f_pilgrimroad_47", Rectangle(-1297, 1080, 25));
		AddSpawnPoint("f_pilgrimroad_47.Id1", "f_pilgrimroad_47", Rectangle(-1309, 1277, 25));
		AddSpawnPoint("f_pilgrimroad_47.Id1", "f_pilgrimroad_47", Rectangle(-906, 643, 25));
		AddSpawnPoint("f_pilgrimroad_47.Id1", "f_pilgrimroad_47", Rectangle(-663, 991, 25));
		AddSpawnPoint("f_pilgrimroad_47.Id1", "f_pilgrimroad_47", Rectangle(-803, 1261, 25));

		// 'Rondo_Red' GenType 8 Spawn Points
		AddSpawnPoint("f_pilgrimroad_47.Id2", "f_pilgrimroad_47", Rectangle(95, 54, 9999));

		// 'Rubabos_Red' GenType 9 Spawn Points
		AddSpawnPoint("f_pilgrimroad_47.Id3", "f_pilgrimroad_47", Rectangle(1569, 620, 9999));

		// 'Rondo_Red' GenType 11 Spawn Points
		AddSpawnPoint("f_pilgrimroad_47.Id4", "f_pilgrimroad_47", Rectangle(-929, -1038, 30));
		AddSpawnPoint("f_pilgrimroad_47.Id4", "f_pilgrimroad_47", Rectangle(-1136, -1135, 30));
		AddSpawnPoint("f_pilgrimroad_47.Id4", "f_pilgrimroad_47", Rectangle(-1184, -1333, 30));
		AddSpawnPoint("f_pilgrimroad_47.Id4", "f_pilgrimroad_47", Rectangle(-904, -1387, 30));
		AddSpawnPoint("f_pilgrimroad_47.Id4", "f_pilgrimroad_47", Rectangle(-880, -1209, 30));
		AddSpawnPoint("f_pilgrimroad_47.Id4", "f_pilgrimroad_47", Rectangle(-689, -1323, 30));
		AddSpawnPoint("f_pilgrimroad_47.Id4", "f_pilgrimroad_47", Rectangle(-704, -1103, 30));
		AddSpawnPoint("f_pilgrimroad_47.Id4", "f_pilgrimroad_47", Rectangle(-518, -1162, 30));
		AddSpawnPoint("f_pilgrimroad_47.Id4", "f_pilgrimroad_47", Rectangle(-793, -866, 30));
		AddSpawnPoint("f_pilgrimroad_47.Id4", "f_pilgrimroad_47", Rectangle(-1159, -857, 30));

		// 'Rootcrystal_01' GenType 20 Spawn Points
		AddSpawnPoint("f_pilgrimroad_47.Id5", "f_pilgrimroad_47", Rectangle(-923, -1081, 30));
		AddSpawnPoint("f_pilgrimroad_47.Id5", "f_pilgrimroad_47", Rectangle(-1025, 831, 30));
		AddSpawnPoint("f_pilgrimroad_47.Id5", "f_pilgrimroad_47", Rectangle(1179, -351, 30));
		AddSpawnPoint("f_pilgrimroad_47.Id5", "f_pilgrimroad_47", Rectangle(1055, 735, 30));

		// 'Spell_Crystal_Red' GenType 23 Spawn Points
		AddSpawnPoint("f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Rectangle(-81, -353, 100));
		AddSpawnPoint("f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Rectangle(150, -459, 100));
		AddSpawnPoint("f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Rectangle(392, -388, 100));
		AddSpawnPoint("f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Rectangle(142, -142, 100));
		AddSpawnPoint("f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Rectangle(40, 134, 100));
		AddSpawnPoint("f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Rectangle(526, -31, 100));
		AddSpawnPoint("f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Rectangle(-534, -1107, 100));
		AddSpawnPoint("f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Rectangle(-732, -1343, 100));
		AddSpawnPoint("f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Rectangle(-1085, -1330, 100));
		AddSpawnPoint("f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Rectangle(-1110, -955, 100));
		AddSpawnPoint("f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Rectangle(-913, -1482, 100));
		AddSpawnPoint("f_pilgrimroad_47.Id6", "f_pilgrimroad_47", Rectangle(-809, -1053, 100));

		// 'Triffid' GenType 33 Spawn Points
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1453, -523, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-2235, -1915, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-2267, -1681, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1718, -1852, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1596, -1641, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1681, -892, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1775, -835, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1571, -752, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1473, -746, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1368, -365, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1490, -373, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1577, -414, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(2004, -648, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1734, -538, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1556, -644, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1303, -642, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1666, -279, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1758, -333, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1836, -462, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1515, -889, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1764, -678, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1641, -524, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1525, -1023, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1385, -930, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1277, -817, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1102, -590, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1040, -725, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1003, -444, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1339, -422, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1608, 261, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1801, 358, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1269, 753, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1306, 549, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1534, 518, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1473, 341, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1100, 551, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1082, 739, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1718, 472, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1711, 643, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1673, 717, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1130, 880, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1392, 980, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1848, 1014, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1931, 761, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(1916, 571, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-102, -241, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(391, -168, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(278, -361, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(359, -384, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(427, -281, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(524, -86, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(448, 44, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(296, -10, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(189, 133, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(41, 111, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-14, -38, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-233, -467, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-58, -448, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-239, -186, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-241, -97, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(268, -275, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(173, -388, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-135, 104, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-532, -1217, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-609, -1284, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-819, -1422, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-749, -1111, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-808, -1215, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1064, -1228, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1232, -1179, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-948, -1000, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1031, -1425, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1123, -1384, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-970, -1114, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1312, -1077, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-872, -1270, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-755, -961, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-835, -1053, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-724, -1267, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-585, -1153, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-655, -1173, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-960, -1313, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-820, -854, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-856, -942, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1196, -947, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1168, -889, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1041, -905, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1054, -836, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-703, -1385, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-2099, -1960, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-2235, -2081, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-2340, -1870, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1990, -1766, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1906, -1911, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1985, -1955, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1724, -1749, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-2055, -1673, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-2017, -1460, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1949, -1504, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1899, -1609, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-2125, -1822, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1837, -1714, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1641, -1785, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1676, -1658, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1719, -1521, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-2182, -1558, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1310, 1222, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1103, 1351, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-954, 1251, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-833, 1231, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-817, 1107, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1236, 1197, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1138, 1074, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1301, 725, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1380, 792, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1402, 900, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1403, 1044, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-595, 868, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-833, 962, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-746, 1013, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-951, 688, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-867, 613, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-983, 599, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1089, 595, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1086, 874, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1129, 719, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-646, 770, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-734, 650, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-935, 835, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-1087, 1259, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-973, 1045, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-999, 964, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-985, 1142, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-851, 1367, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-744, 1327, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-673, 1252, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-674, 1100, 20));
		AddSpawnPoint("f_pilgrimroad_47.Id7", "f_pilgrimroad_47", Rectangle(-792, 835, 20));
	}
}
