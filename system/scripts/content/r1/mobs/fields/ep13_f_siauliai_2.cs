//--- Melia Script -----------------------------------------------------------
// Woods of the Linked Bridges Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'ep13_f_siauliai_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep13FSiauliai2MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep13_f_siauliai_2", MonsterId.Darbas_Miner, Properties("MHP", 921285, "MINPATK", 12347, "MAXPATK", 15078, "MINMATK", 12347, "MAXMATK", 15078, "DEF", 386086, "MDEF", 386086));
		AddPropertyOverrides("ep13_f_siauliai_2", MonsterId.Darbas_Carrier, Properties("MHP", 924645, "MINPATK", 12391, "MAXPATK", 15131, "MINMATK", 12391, "MAXMATK", 15131, "DEF", 389894, "MDEF", 389894));
		AddPropertyOverrides("ep13_f_siauliai_2", MonsterId.Darbas_Loader, Properties("MHP", 928298, "MINPATK", 12438, "MAXPATK", 15189, "MINMATK", 12438, "MAXMATK", 15189, "DEF", 394035, "MDEF", 394035));
		AddPropertyOverrides("ep13_f_siauliai_2", MonsterId.Boss_Darbas_Smasher, Properties("MHP", 5089938, "MINPATK", 34467, "MAXPATK", 42092, "MINMATK", 34467, "MAXMATK", 42092, "DEF", 1099813, "MDEF", 1099813));

		// Monster Spawners ---------------------------------

		AddSpawner("ep13_f_siauliai_2.Id1", MonsterId.Rootcrystal_01, min: 17, max: 22, respawn: TimeSpan.FromMilliseconds(20000));
		AddSpawner("ep13_f_siauliai_2.Id2", MonsterId.Darbas_Miner, min: 30, max: 40, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_2.Id3", MonsterId.Darbas_Carrier, min: 68, max: 90, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_2.Id4", MonsterId.Darbas_Loader, min: 68, max: 90, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_2.Id5", MonsterId.Darbas_Miner, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_2.Id6", MonsterId.Darbas_Miner, amount: 2, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_2.Id7", MonsterId.Darbas_Miner, amount: 2, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_2.Id8", MonsterId.Darbas_Miner, amount: 2, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_2.Id9", MonsterId.Darbas_Miner, amount: 2, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("ep13_f_siauliai_2.Id10", MonsterId.Darbas_Miner, amount: 2, respawn: TimeSpan.FromMilliseconds(60000));

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 3 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(2794, -731, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(2365, -1216, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(1879, -704, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(1387, -1026, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(1042, -801, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(1405, 133, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(966, 353, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(1418, 825, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(965, 1159, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(568, 1491, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(107, 1595, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(-217, 2005, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(-427, 1521, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(-483, 424, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(-1001, 463, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(82, 184, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(-1034, -617, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(-1518, -570, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(-1369, -1057, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(-1972, -1009, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(-42, -1454, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(509, -964, 100));

		// 'Darbas_Miner' GenType 1034 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(2859, -664, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(1399, -810, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(1291, 193, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(1049, 267, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(629, 457, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(94, 137, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-509, 485, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-1027, 427, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-361, 1464, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(504, 1390, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(1497, 884, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(0, -1258, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-1707, -719, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-1467, -546, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-2288, -828, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(1066, -901, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(2123, -733, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(497, -1139, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(670, -1057, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-49, -828, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-1031, -485, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-72, 1646, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-1963, -936, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-39, -1866, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-1234, -776, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-1263, -1069, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(475, 1665, 20));

		// 'Darbas_Carrier' GenType 1035 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(2934, -730, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(2149, -856, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1315, -1054, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1542, -827, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1249, -866, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(846, -684, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1304, 316, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1495, -100, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1208, -23, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(991, 460, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(488, 402, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(761, 493, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-58, 168, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(142, 258, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-474, 351, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-418, 592, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-897, 478, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1177, 435, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-533, 1588, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-280, 1470, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-297, 2019, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-73, 1897, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(344, 1617, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(702, 1316, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1368, 907, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1639, 951, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(86, -1535, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-14, -1134, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-81, -1780, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-2250, -949, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-2109, -901, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1781, -827, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1755, -554, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1439, -673, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1421, -453, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1402, -1013, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-887, -715, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-761, -936, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(813, 1449, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(48, -1341, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(2455, -1321, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1303, -887, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-2157, -1195, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(3228, -718, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(3055, -820, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1999, -704, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(2365, -1191, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1379, 724, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(857, 1619, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-401, 850, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-994, -247, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1052, -630, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-2428, -1178, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1399, 499, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1906, 1000, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-278, 120, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-96, -1, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(2770, -875, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(2850, -777, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(2307, -699, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(2427, -677, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(2627, -720, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1290, -595, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1325, -434, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(376, -355, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(111, -136, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(609, -1222, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(354, -1077, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(545, -1020, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(715, -917, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-33, -960, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-552, -859, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-862, -856, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-989, -35, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(168, 1676, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1082, 875, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1389, 1022, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1680, 842, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1609, -546, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1990, -935, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1915, -1060, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-469, 1457, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1407, 69, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(2323, -1302, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1623, -718, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1533, -966, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-2430, -897, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(261, -921, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(35, -1594, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1446, -810, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(884, 1179, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(933, 937, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(599, 1333, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(604, 1495, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1047, -739, 20));

		// 'Darbas_Loader' GenType 1036 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(3202, -809, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(2161, -646, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(2232, -1328, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1433, -1125, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1171, -1012, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1202, -715, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(26, -1848, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-175, -831, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(355, -955, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(114, -1428, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-969, -794, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-760, -796, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1559, -447, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1344, -589, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1893, -663, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1621, -869, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-2414, -786, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-2184, -768, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1821, -1052, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1499, -1063, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-960, 119, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1180, -487, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(174, -253, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(670, 310, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(610, 635, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(908, 255, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1162, 292, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1378, -71, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1422, 310, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1506, 755, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1487, 1023, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(456, 1491, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(578, 1604, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(724, 1635, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(41, 1626, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-149, 2046, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-389, 1358, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-491, 1734, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-402, 1038, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-654, 499, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-319, 383, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-952, 303, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1121, 568, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-2270, -1263, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-344, -841, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(16, -815, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1205, 687, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(998, 984, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(229, 1591, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1684, -1069, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-2285, -1127, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1761, -711, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1436, -358, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1805, 972, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1225, 799, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-192, -4, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(961, 1250, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(169, 427, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(323, 243, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(2285, -1117, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(2465, -1207, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(2533, -1091, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(2249, -939, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(2225, -775, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(3029, -734, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(2755, -736, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(3326, -679, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1411, -939, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(723, -1228, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(618, -1125, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(734, -779, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(895, -813, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(618, -895, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-386, 1585, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1472, 176, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1229, 125, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1510, -726, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-363, 258, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1364, -1111, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1186, -1122, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1573, -743, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(501, 1313, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(887, 1473, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(927, 1627, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(777, 1273, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-168, 1919, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-300, 1943, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-402, 739, 20));

		// 'Darbas_Miner' GenType 1037 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_2.Id5", "ep13_f_siauliai_2", Rectangle(-1256, 487, 20));

		// 'Darbas_Miner' GenType 1038 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_2.Id6", "ep13_f_siauliai_2", Rectangle(-551, 1760, 20));

		// 'Darbas_Miner' GenType 1039 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_2.Id7", "ep13_f_siauliai_2", Rectangle(1625, 762, 20));

		// 'Darbas_Miner' GenType 1040 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_2.Id8", "ep13_f_siauliai_2", Rectangle(1120, 80, 20));

		// 'Darbas_Miner' GenType 1041 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_2.Id9", "ep13_f_siauliai_2", Rectangle(451, -1015, 20));

		// 'Darbas_Miner' GenType 1043 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_2.Id10", "ep13_f_siauliai_2", Rectangle(-1788, -365, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id10", "ep13_f_siauliai_2", Rectangle(-2087, -1066, 20));
	}
}
