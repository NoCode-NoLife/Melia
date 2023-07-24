//--- Melia Script -----------------------------------------------------------
// East Siauliai Woods Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_siauliai_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliai2MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_siauliai_2", MonsterId.Goblin_Spear_Q1, Properties("MHP", 1577, "MINPATK", 154, "MAXPATK", 166, "MINMATK", 154, "MAXMATK", 166, "DEF", 14, "MDEF", 14));
		AddPropertyOverrides("f_siauliai_2", MonsterId.Chupacabra_Blue, Properties("MHP", 1786, "MINPATK", 164, "MAXPATK", 176, "MINMATK", 164, "MAXMATK", 176, "DEF", 15, "MDEF", 15));
		AddPropertyOverrides("f_siauliai_2", MonsterId.Popolion_Blue, Properties("MHP", 2013, "MINPATK", 174, "MAXPATK", 187, "MINMATK", 174, "MAXMATK", 187, "DEF", 16, "MDEF", 16));
		AddPropertyOverrides("f_siauliai_2", MonsterId.Pokubu, Properties("MHP", 2256, "MINPATK", 185, "MAXPATK", 199, "MINMATK", 185, "MAXMATK", 199, "DEF", 18, "MDEF", 18));
		AddPropertyOverrides("f_siauliai_2", MonsterId.Weaver, Properties("MHP", 2515, "MINPATK", 197, "MAXPATK", 212, "MINMATK", 197, "MAXMATK", 212, "DEF", 19, "MDEF", 19));
		AddPropertyOverrides("f_siauliai_2", MonsterId.Boss_Goblin_Warrior, Properties("MHP", 12551, "MINPATK", 377, "MAXPATK", 406, "MINMATK", 377, "MAXMATK", 406, "DEF", 36, "MDEF", 36));

		// Monster Spawners ---------------------------------

		AddSpawner("f_siauliai_2.Id1", MonsterId.Pokubu, min: 6, max: 8);
		AddSpawner("f_siauliai_2.Id2", MonsterId.Chupacabra_Blue, min: 15, max: 20);
		AddSpawner("f_siauliai_2.Id3", MonsterId.Rootcrystal_01, min: 13, max: 17, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("f_siauliai_2.Id4", MonsterId.Weaver, min: 15, max: 20);
		AddSpawner("f_siauliai_2.Id5", MonsterId.Popolion_Blue, min: 45, max: 60);
		AddSpawner("f_siauliai_2.Id6", MonsterId.Popolion_Blue, min: 8, max: 10);
		AddSpawner("f_siauliai_2.Id7", MonsterId.Chupacabra_Blue, min: 5, max: 6);
		AddSpawner("f_siauliai_2.Id8", MonsterId.Chupacabra_Blue, min: 23, max: 30);
		AddSpawner("f_siauliai_2.Id9", MonsterId.Popolion_Blue, min: 23, max: 30);
		AddSpawner("f_siauliai_2.Id10", MonsterId.Popolion_Blue, min: 8, max: 10);

		// Monster Spawn Points -----------------------------

		// 'Pokubu' GenType 9 Spawn Points
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(2074, 129, 30));
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(1976, 171, 30));
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(2171, 90, 30));
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(2135, 336, 30));
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(2017, 276, 30));
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(2130, -95, 30));
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(1885, 288, 30));
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(2037, -30, 30));
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(1818, 184, 30));
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(2038, 381, 30));
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(2095, 23, 30));

		// 'Chupacabra_Blue' GenType 11 Spawn Points
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-1415, -371, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-965, 31, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-1100, 111, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-231, 85, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-170, -154, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-262, 422, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-539, -29, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-1002, 586, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(171, 1082, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(296, 1122, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(560, 690, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(429, -680, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(165, -547, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(260, -658, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(388, -271, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(163, -282, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(421, -420, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-919, 931, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-460, 1113, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-291, 907, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-254, 1148, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-860, 568, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-993, 776, 30));

		// 'Rootcrystal_01' GenType 12 Spawn Points
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-1110, 26, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-825, 63, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-873, 284, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-907, 927, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-1002, 842, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-899, 691, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-1832, 736, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-1891, 1003, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-2162, 894, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-2298, 1140, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-284, 824, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(514, 318, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(445, 1075, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(275, 1086, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-90, -284, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-154, 77, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-96, -821, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(231, -569, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(2030, -428, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(2054, 150, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(1720, 1033, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(2206, 1118, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-1932, -988, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-660, -762, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-967, -809, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-1456, -395, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-1180, -278, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-1225, 138, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-950, 78, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-1081, 238, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-1029, 350, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-1005, 616, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-1184, 905, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-1449, 808, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-1519, 618, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-1698, 786, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-1779, 614, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-2230, 846, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-2342, 1074, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-2147, 1227, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-2123, 1365, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-2173, 1607, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-2439, 1592, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-679, 229, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-488, -35, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-316, 185, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-177, -332, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-50, 41, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-87, 217, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-249, 322, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-276, 528, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-434, 683, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-771, 1137, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-650, 1155, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-672, 1023, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-323, 1184, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-413, 998, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-232, 959, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(37, 1257, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(32, 1078, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-1323, -236, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(566, 871, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(586, 751, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(646, 542, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(543, 496, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(936, 269, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(678, 104, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(693, -41, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(371, -311, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(351, -399, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(154, -392, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(423, -656, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(636, -611, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(635, -830, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(480, -963, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(843, -798, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(772, -954, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(1305, 565, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(1390, 837, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(1873, 1044, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(1999, 1144, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(1537, 200, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(1706, 208, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(2022, 319, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(2046, -1, 100));

		// 'Weaver' GenType 14 Spawn Points
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(181, -673, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(-37, -764, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(-137, -871, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(268, -524, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(143, -573, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(-203, -636, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(-131, -378, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(618, -921, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(654, -833, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(854, -798, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(831, -882, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1446, 952, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1939, 174, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1847, 294, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(2030, 369, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1596, 222, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1518, 205, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1657, 95, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1554, 130, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1732, 150, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1376, 761, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1273, 586, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1343, 525, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1296, 685, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1299, 797, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1466, 847, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1508, 896, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(712, -895, 40));

		// 'Popolion_Blue' GenType 10006 Spawn Points
		AddSpawnPoint("f_siauliai_2.Id5", "f_siauliai_2", Rectangle(-1927, 1041, 9999));

		// 'Popolion_Blue' GenType 10011 Spawn Points
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-2368, 1278, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1840, 742, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-2149, 831, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1765, 595, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1985, 1064, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1892, 955, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-2227, 1089, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-994, 498, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-843, 559, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-915, 744, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1990, -1187, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1971, -1430, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1887, -1060, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1947, -1337, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1985, -1047, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-796, -1168, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-987, -1443, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-835, -843, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1046, -1249, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1122, -1559, 30));

		// 'Chupacabra_Blue' GenType 10020 Spawn Points
		AddSpawnPoint("f_siauliai_2.Id7", "f_siauliai_2", Rectangle(258, -563, 250));

		// 'Chupacabra_Blue' GenType 10026 Spawn Points
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-2010, -971, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1917, -961, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1992, -1328, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1821, -1165, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-429, 587, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1813, -1480, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1881, -1546, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1625, -1464, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1311, -1471, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1263, -1573, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1159, -1391, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1063, -1490, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-913, -1266, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1005, -1164, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-959, -1426, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-755, -969, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-880, -865, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-713, 1020, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-602, 600, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1921, -1180, 50));

		// 'Popolion_Blue' GenType 10027 Spawn Points
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1971, -1078, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1982, -1326, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1837, -1238, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1839, -1439, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1958, -1474, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1601, -1459, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1339, -1495, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1202, -1398, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1029, -1521, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-877, -1165, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1040, -1230, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-886, -1345, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-835, -899, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-943, -956, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-959, -1256, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1108, -1581, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-690, -1000, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1941, -1188, 40));

		// 'Popolion_Blue' GenType 10036 Spawn Points
		AddSpawnPoint("f_siauliai_2.Id10", "f_siauliai_2", Rectangle(-391, 1104, 300));
		AddSpawnPoint("f_siauliai_2.Id10", "f_siauliai_2", Rectangle(-772, 1040, 300));
	}
}
