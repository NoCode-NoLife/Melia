//--- Melia Script -----------------------------------------------------------
// Outer Wall District 11 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_castle_93'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle93MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_castle_93", MonsterId.Spider, Properties("MHP", 693671, "MINPATK", 9421, "MAXPATK", 11481, "MINMATK", 9421, "MAXMATK", 11481, "DEF", 186607, "MDEF", 186607));
		AddPropertyOverrides("f_castle_93", MonsterId.Hooter, Properties("MHP", 695642, "MINPATK", 9446, "MAXPATK", 11512, "MINMATK", 9446, "MAXMATK", 11512, "DEF", 188016, "MDEF", 188016));
		AddPropertyOverrides("f_castle_93", MonsterId.Banterer, Properties("MHP", 697667, "MINPATK", 9472, "MAXPATK", 11544, "MINMATK", 9472, "MAXMATK", 11544, "DEF", 189463, "MDEF", 189463));
		AddPropertyOverrides("f_castle_93", MonsterId.Boss_Banshee_Q3, Properties("MHP", 3652652, "MINPATK", 23938, "MAXPATK", 29174, "MINMATK", 23938, "MAXMATK", 29174, "DEF", 481184, "MDEF", 481184));

		// Monster Spawners ---------------------------------

		AddSpawner("f_castle_93.Id1", MonsterId.Spider, min: 38, max: 50, tendency: TendencyType.Aggressive);
		AddSpawner("f_castle_93.Id2", MonsterId.Hooter, min: 75, max: 100, tendency: TendencyType.Aggressive);
		AddSpawner("f_castle_93.Id3", MonsterId.Banterer, min: 15, max: 20, tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Spider' GenType 1 Spawn Points
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-702, 423, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-745, 469, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-567, 598, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-235, 837, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-179, 817, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-21, 815, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1477, -361, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1590, -172, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1453, -126, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1360, -311, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1399, -504, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1140, -338, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1087, -509, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1097, -39, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1005, -273, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1076, -1123, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1108, -944, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1035, -765, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-799, -290, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-520, -299, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-34, -446, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-175, -375, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-73, -205, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-30, -1284, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-177, -1165, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(6, -1162, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-349, -1065, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-640, -1132, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-671, -970, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-778, -1147, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1038, 353, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1097, 539, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-386, 726, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1084, -1676, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1288, -1732, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1085, -1471, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1208, -1587, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1462, -1450, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1857, -1359, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1811, -1544, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1941, -1565, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1784, -1679, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1416, -1669, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1093, 768, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-1043, 647, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(59, -1204, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-87, -1105, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(22, -402, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(13, -182, 20));
		AddSpawnPoint("f_castle_93.Id1", "f_castle_93", Rectangle(-156, -275, 20));

		// 'Hooter' GenType 2 Spawn Points
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2167, -1626, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2178, -1514, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2143, -1768, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2048, -1806, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2026, -1579, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2101, -1446, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2005, -1316, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2128, -1340, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1775, -1785, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1885, -1680, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1706, -1594, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1748, -1379, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1572, -1469, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1564, -1557, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1561, -1801, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1350, -1788, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1089, -1797, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1203, -1823, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1222, -1623, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1067, -1559, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1237, -1339, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1375, -1361, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(77, -1287, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-100, -1246, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-239, -1084, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-62, -1161, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-610, -1059, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-751, -987, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1064, -1267, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1262, -212, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-25, -507, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-129, -499, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-72, -322, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-163, -205, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-278, -283, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-426, -286, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-876, -298, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1030, 293, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1126, 496, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1015, 598, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1885, -260, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1952, -471, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2078, -279, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2066, -489, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2196, -330, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2275, -519, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2318, -415, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2504, -385, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2484, -514, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2570, -524, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2580, -204, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2484, -108, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2155, -55, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1950, -187, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1962, -34, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1886, -33, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2246, -196, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2002, 80, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2322, -297, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2140, 128, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2340, 74, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2425, -291, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2499, 150, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2689, 104, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2775, -15, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2739, -168, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2515, -20, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2775, -467, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-2723, -397, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1044, 1023, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1099, 996, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1258, 746, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1198, 754, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1225, 1119, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1145, 1254, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1416, 1250, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1370, 1220, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1401, 976, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1503, 821, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1447, 793, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1722, 835, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1874, 838, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1865, 958, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1824, 918, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1649, 936, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1606, 914, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1665, 1180, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1612, 1153, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1685, 1280, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1729, 1219, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1859, 1246, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1761, 1154, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1854, 1314, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1804, 1082, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1510, 1263, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1123, -164, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-704, 370, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-808, 483, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1198, 1002, 20));
		AddSpawnPoint("f_castle_93.Id2", "f_castle_93", Rectangle(-1346, 946, 20));

		// 'Banterer' GenType 3 Spawn Points
		AddSpawnPoint("f_castle_93.Id3", "f_castle_93", Rectangle(-2168, -1571, 60));
		AddSpawnPoint("f_castle_93.Id3", "f_castle_93", Rectangle(-1983, -1711, 60));
		AddSpawnPoint("f_castle_93.Id3", "f_castle_93", Rectangle(-1944, -1418, 60));
		AddSpawnPoint("f_castle_93.Id3", "f_castle_93", Rectangle(-1494, -1697, 60));
		AddSpawnPoint("f_castle_93.Id3", "f_castle_93", Rectangle(-1260, -1471, 60));
		AddSpawnPoint("f_castle_93.Id3", "f_castle_93", Rectangle(-722, -1072, 60));
		AddSpawnPoint("f_castle_93.Id3", "f_castle_93", Rectangle(-1486, -228, 60));
		AddSpawnPoint("f_castle_93.Id3", "f_castle_93", Rectangle(-1214, -478, 60));
		AddSpawnPoint("f_castle_93.Id3", "f_castle_93", Rectangle(-2126, -426, 60));
		AddSpawnPoint("f_castle_93.Id3", "f_castle_93", Rectangle(-2400, -225, 60));
		AddSpawnPoint("f_castle_93.Id3", "f_castle_93", Rectangle(-2761, -284, 60));
		AddSpawnPoint("f_castle_93.Id3", "f_castle_93", Rectangle(-2232, 112, 60));
		AddSpawnPoint("f_castle_93.Id3", "f_castle_93", Rectangle(-1225, 841, 60));
		AddSpawnPoint("f_castle_93.Id3", "f_castle_93", Rectangle(-1052, 937, 60));
		AddSpawnPoint("f_castle_93.Id3", "f_castle_93", Rectangle(-1378, 1070, 60));
		AddSpawnPoint("f_castle_93.Id3", "f_castle_93", Rectangle(-1768, 1270, 60));
		AddSpawnPoint("f_castle_93.Id3", "f_castle_93", Rectangle(-1548, 1040, 60));
		AddSpawnPoint("f_castle_93.Id3", "f_castle_93", Rectangle(-781, 392, 60));
		AddSpawnPoint("f_castle_93.Id3", "f_castle_93", Rectangle(-1771, 929, 60));
		AddSpawnPoint("f_castle_93.Id3", "f_castle_93", Rectangle(-1054, 118, 60));
	}
}
