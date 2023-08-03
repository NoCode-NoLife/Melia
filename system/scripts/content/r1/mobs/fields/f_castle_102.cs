//--- Melia Script -----------------------------------------------------------
// Skalda Outskirts Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_castle_102'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle102MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_castle_102", MonsterId.Castle_Goblin_Archer, Properties("MHP", 796325, "MINPATK", 10741, "MAXPATK", 13103, "MINMATK", 10741, "MAXMATK", 13103, "DEF", 266180, "MDEF", 266180));
		AddPropertyOverrides("f_castle_102", MonsterId.Wolf, Properties("MHP", 798555, "MINPATK", 10770, "MAXPATK", 13138, "MINMATK", 10770, "MAXMATK", 13138, "DEF", 268057, "MDEF", 268057));
		AddPropertyOverrides("f_castle_102", MonsterId.Wolf_Leader, Properties("MHP", 800818, "MINPATK", 10799, "MAXPATK", 13174, "MINMATK", 10799, "MAXMATK", 13174, "DEF", 269963, "MDEF", 269963));
		AddPropertyOverrides("f_castle_102", MonsterId.Neckko, Properties("MHP", 803113, "MINPATK", 10828, "MAXPATK", 13210, "MINMATK", 10828, "MAXMATK", 13210, "DEF", 271896, "MDEF", 271896));
		AddPropertyOverrides("f_castle_102", MonsterId.Goblin_Sword_Rider, Properties("MHP", 805440, "MINPATK", 10858, "MAXPATK", 13247, "MINMATK", 10858, "MAXMATK", 13247, "DEF", 273856, "MDEF", 273856));

		// Monster Spawners ---------------------------------

		AddSpawner("f_castle_102.Id1", MonsterId.Castle_Goblin_Archer, min: 45, max: 60, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("f_castle_102.Id2", MonsterId.Wolf, min: 38, max: 50, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("f_castle_102.Id3", MonsterId.Wolf_Leader, min: 6, max: 8, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("f_castle_102.Id4", MonsterId.Neckko, min: 23, max: 30, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("f_castle_102.Id5", MonsterId.Goblin_Sword_Rider, min: 30, max: 40, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("f_castle_102.Id6", MonsterId.Rootcrystal_02, min: 23, max: 30, respawn: TimeSpan.FromMilliseconds(20000));

		// Monster Spawn Points -----------------------------

		// 'Castle_Goblin_Archer' GenType 1 Spawn Points
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-2116, -973, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-2105, -711, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-2436, -899, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-386, -717, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-182, -239, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-116, -451, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-227, -634, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-418, -925, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-461, -1175, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-1065, -396, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-888, -210, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-937, 93, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-409, 232, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-1705, 184, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-3004, 351, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-498, 181, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-599, 77, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-254, 234, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-217, 136, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-363, 152, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-1475, 115, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-1611, 197, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-1738, 103, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-1737, 282, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-2201, 315, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-2173, 132, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-1996, 383, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-2012, 156, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-2488, 332, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-2805, 96, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-3007, 232, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-2645, 180, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-2890, 269, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-2791, 379, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-2625, 336, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-1903, 311, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-1073, 44, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-1032, -111, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-798, -35, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-1064, -528, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-954, -753, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-1106, -938, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-620, -632, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-1159, -1064, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-1292, -734, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-1551, -706, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-1823, -958, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-2514, -689, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-2555, -790, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-827, -1428, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-694, -1555, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-557, -1394, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-276, -1387, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-460, -1289, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-807, -525, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-690, -1427, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-2025, -1401, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-2136, -1436, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-2124, -1221, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-2002, -1093, 35));
		AddSpawnPoint("f_castle_102.Id1", "f_castle_102", Rectangle(-1894, -1416, 35));

		// 'Wolf' GenType 2 Spawn Points
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-1265, 119, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-121, 292, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-2254, 199, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-2080, 430, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-39, 212, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-587, 259, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-703, 41, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-273, 71, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-1516, 192, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-1859, 389, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-1839, 193, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-1985, 318, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-2173, 235, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-1992, 90, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-2749, 179, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-3018, 231, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-2910, 398, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-2794, 441, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-2787, 297, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-2539, 246, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-2381, 267, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-2108, 360, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-1937, 225, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-850, 41, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-1121, 152, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-1130, -57, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-1104, -613, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-806, -676, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-1052, -257, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-906, -390, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-1216, -716, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-1517, -718, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-1628, -857, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-1707, -951, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-2196, -876, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-2365, -753, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-2290, -689, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-1845, -647, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-1991, -785, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-476, -628, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-346, -338, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-227, -528, 25));
		AddSpawnPoint("f_castle_102.Id2", "f_castle_102", Rectangle(-405, -511, 25));

		// 'Wolf_Leader' GenType 3 Spawn Points
		AddSpawnPoint("f_castle_102.Id3", "f_castle_102", Rectangle(-941, -623, 25));
		AddSpawnPoint("f_castle_102.Id3", "f_castle_102", Rectangle(-2193, -817, 25));
		AddSpawnPoint("f_castle_102.Id3", "f_castle_102", Rectangle(-1855, -852, 25));
		AddSpawnPoint("f_castle_102.Id3", "f_castle_102", Rectangle(-2692, 252, 25));
		AddSpawnPoint("f_castle_102.Id3", "f_castle_102", Rectangle(-2063, 248, 25));
		AddSpawnPoint("f_castle_102.Id3", "f_castle_102", Rectangle(-1363, 121, 25));
		AddSpawnPoint("f_castle_102.Id3", "f_castle_102", Rectangle(-1841, 86, 25));
		AddSpawnPoint("f_castle_102.Id3", "f_castle_102", Rectangle(-925, -48, 25));
		AddSpawnPoint("f_castle_102.Id3", "f_castle_102", Rectangle(-254, -405, 25));
		AddSpawnPoint("f_castle_102.Id3", "f_castle_102", Rectangle(-516, -551, 25));

		// 'Neckko' GenType 4 Spawn Points
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-2016, -884, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-1966, -1481, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-1801, -1613, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-506, -699, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-2153, -934, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-1723, -936, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-1921, -674, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-886, -698, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-1660, -740, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-760, -1433, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-864, -1487, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-670, -1605, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-448, -1440, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-328, -1616, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-238, -1579, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-222, -1433, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-752, -668, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-455, -1303, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-1125, -937, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-779, -1547, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-2023, -1638, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-2159, -772, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-2143, -1336, 25));
		AddSpawnPoint("f_castle_102.Id4", "f_castle_102", Rectangle(-1257, -893, 25));

		// 'Goblin_Sword_Rider' GenType 5 Spawn Points
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-326, -479, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-339, -593, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-402, -403, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-264, -311, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-143, -384, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-167, -537, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-902, -546, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-1047, -671, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-801, -751, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-918, -306, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-1007, -444, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-1123, -465, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-946, -175, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-822, -68, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-1047, 167, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-1149, 81, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-1412, -713, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-1549, -821, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-1654, -745, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-1792, -781, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-1990, -644, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-1998, -924, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-2265, -915, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-2438, -807, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-2418, -685, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-2196, -636, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-2222, -755, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-2039, -811, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-1731, -883, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-1096, -820, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-1052, -332, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-948, 28, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-875, -1579, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-539, -1458, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-451, -1054, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-484, -1262, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-318, -1476, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-485, -1554, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-2122, -1579, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-118, -299, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-931, -473, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-329, -1541, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-1738, -687, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-2337, -984, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-1993, -1561, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-2047, -1486, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-2150, -1280, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-2070, -1089, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-1910, -1542, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-1840, -1496, 30));
		AddSpawnPoint("f_castle_102.Id5", "f_castle_102", Rectangle(-1921, -1611, 30));

		// 'Rootcrystal_02' GenType 8 Spawn Points
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1005, -17, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1030, 412, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1047, 191, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1288, 556, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-858, 632, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-262, -1450, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-373, -1587, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-528, -1447, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-650, -1588, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-847, -1440, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1180, -1448, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1314, -1599, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1595, -1547, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1838, -1574, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-2058, -1574, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-2034, -1407, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1903, -1433, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1488, -1423, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1321, -1430, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1134, -1598, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1207, -1250, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1218, -854, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1023, -852, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-815, -845, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-650, -663, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-926, -583, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-973, -280, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-555, -559, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-293, -629, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-310, -352, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-103, -391, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-136, -542, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-449, -1032, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-453, -1273, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-415, -818, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1577, -744, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1732, -944, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1784, -764, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-2010, -969, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-2085, -759, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-2270, -994, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-2324, -714, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-2560, -832, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-2330, -853, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-2903, 160, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-2913, 382, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-2727, 303, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-2668, 121, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-2511, 242, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-2325, 287, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-2186, 187, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-2033, 391, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1992, 130, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1835, 389, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1785, 215, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1517, 137, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1266, 104, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-1122, 688, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-748, -12, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-560, 165, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-388, 136, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(-177, 182, 100));
		AddSpawnPoint("f_castle_102.Id6", "f_castle_102", Rectangle(12, 319, 100));
	}
}
