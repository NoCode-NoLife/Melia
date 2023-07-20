//--- Melia Script -----------------------------------------------------------
// Tvirtumas Fortress Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_castle_99'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle99MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_castle_99", MonsterId.Nuo_Twinsword, Properties("MHP", 783671, "MINPATK", 10578, "MAXPATK", 12903, "MINMATK", 10578, "MAXMATK", 12903, "DEF", 255522, "MDEF", 255522));
		AddPropertyOverrides("f_castle_99", MonsterId.Living_Armor, Properties("MHP", 785691, "MINPATK", 10604, "MAXPATK", 12935, "MINMATK", 10604, "MAXMATK", 12935, "DEF", 257224, "MDEF", 257224));
		AddPropertyOverrides("f_castle_99", MonsterId.Nuka_Shield, Properties("MHP", 787748, "MINPATK", 10631, "MAXPATK", 12968, "MINMATK", 10631, "MAXMATK", 12968, "DEF", 258956, "MDEF", 258956));
		AddPropertyOverrides("f_castle_99", MonsterId.Aklaspetal_Sword, Properties("MHP", 789840, "MINPATK", 10657, "MAXPATK", 13001, "MINMATK", 10657, "MAXMATK", 13001, "DEF", 260718, "MDEF", 260718));
		AddPropertyOverrides("f_castle_99", MonsterId.Castle_Troll, Properties("MHP", 791967, "MINPATK", 10685, "MAXPATK", 13034, "MINMATK", 10685, "MAXMATK", 13034, "DEF", 262509, "MDEF", 262509));
		AddPropertyOverrides("f_castle_99", MonsterId.Boss_Jezebel_Q1, Properties("MHP", 4240651, "MINPATK", 28281, "MAXPATK", 34501, "MINMATK", 28281, "MAXMATK", 34501, "DEF", 697831, "MDEF", 697831));

		// Monster Spawners ---------------------------------

		AddSpawner("f_castle_99.Id1", MonsterId.Nuo_Twinsword, 38, 50, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_99.Id2", MonsterId.Living_Armor, 30, 40, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_99.Id3", MonsterId.Nuka_Shield, 42, 55, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_99.Id4", MonsterId.Aklaspetal_Sword, 34, 45, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_99.Id5", MonsterId.Castle_Troll, 12, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_99.Id6", MonsterId.Rootcrystal_02, 34, 45, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Nuo_Twinsword' GenType 1 Spawn Points
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1856, -318, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1559, -64, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1871, 45, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1608, 64, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1633, -317, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1761, -431, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1940, -535, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1906, -153, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1412, 233, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-689, -819, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-687, -1099, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-698, -964, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-465, -1101, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-482, -935, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-498, -816, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-567, -928, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-553, -616, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-523, -365, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-588, -395, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-532, -461, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-602, 535, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-547, 677, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-593, 768, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-436, 1033, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-622, 1206, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-663, 1033, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-566, 1067, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-885, 1084, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1223, 1097, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1571, 1293, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1573, 1011, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1594, 754, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1972, 951, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1701, 1198, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1678, 1026, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1881, 1127, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1750, 742, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1929, -1150, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1508, -1240, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1799, -1236, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1888, -605, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1587, -536, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1545, -899, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1884, -747, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1478, -1007, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1671, -1031, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1506, -742, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1658, 330, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1881, 577, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1621, 577, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-983, 1105, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-433, 1189, 35));
		AddSpawnPoint("f_castle_99.Id1", "f_castle_99", Rectangle(-1853, 265, 35));

		// 'Living_Armor' GenType 2 Spawn Points
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-1463, 46, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-1553, -198, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-582, -51, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-777, 45, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-561, 196, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-453, -2, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-329, 99, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-227, 166, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-64, 187, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-86, 59, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(74, 178, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(209, 60, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(227, 240, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-1105, 1054, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-932, 1125, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-662, 1060, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-529, 1202, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-435, 1042, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-510, 913, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-551, 751, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-612, 662, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-543, -507, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-540, -1101, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-559, -867, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-407, -876, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-600, -1022, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-1429, -915, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-1545, -1095, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-1717, -1130, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-1899, -1033, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-1869, -874, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-1698, -642, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-1656, -923, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-1726, 849, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-1741, 1185, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-1580, 1288, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-1409, 1056, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-1498, 920, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-1639, 981, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-1915, 885, 25));
		AddSpawnPoint("f_castle_99.Id2", "f_castle_99", Rectangle(-1642, 565, 25));

		// 'Nuka_Shield' GenType 3 Spawn Points
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(642, -69, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(587, 374, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1053, 137, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(524, 126, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(627, -643, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(455, -1032, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(795, -1098, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(695, -800, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1199, -936, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1633, -893, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1811, -805, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1769, -1101, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1995, -1102, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1836, -974, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1422, -963, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(743, -1010, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(913, -5, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(369, 1121, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(641, 1339, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(580, 1167, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(724, 1071, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(989, 1241, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1391, 155, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1702, 37, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1819, -184, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(2040, -33, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1837, 206, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1887, 399, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1860, 667, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1821, 955, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1725, 1261, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1876, 1286, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1783, 1076, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(2023, 868, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(2204, 1228, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(2059, 1098, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(2201, 1038, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(2089, 1167, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1904, -7, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(949, 157, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(619, 231, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(277, 224, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(604, -236, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(620, -405, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(518, -865, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(883, -946, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1768, -979, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(1893, -868, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(730, 1191, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(637, 839, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(581, 539, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(458, 325, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(24, 144, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(-354, 44, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(-547, 218, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(-182, 138, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(49, 260, 30));
		AddSpawnPoint("f_castle_99.Id3", "f_castle_99", Rectangle(369, 50, 30));

		// 'Aklaspetal_Sword' GenType 4 Spawn Points
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1702, 990, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(2114, 997, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1885, 839, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1953, 1026, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1830, 1166, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1962, 1199, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(2179, 894, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1890, 614, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1852, 252, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1758, 91, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1786, -79, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1867, -34, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1934, 88, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1264, 125, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1108, -17, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(949, 76, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1044, 274, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(728, 261, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(499, 213, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(381, 101, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(615, -167, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(886, -87, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(776, -29, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(842, 193, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(670, 103, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(686, -283, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(618, -490, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(606, -908, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(780, -754, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(759, -916, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(935, -942, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1044, -951, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(908, -1069, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1368, -994, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1471, -926, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1694, -992, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1794, -866, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1925, -857, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1868, -1100, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(2016, -1000, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1906, -939, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(1900, -1014, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(204, 148, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(558, 569, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(610, 643, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(602, 799, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(651, 909, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(540, 1078, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(495, 1221, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(811, 1114, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(854, 1242, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(911, 1111, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(358, 221, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(11, 265, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(-17, 119, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(-209, 41, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(-291, -70, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(-421, 187, 25));
		AddSpawnPoint("f_castle_99.Id4", "f_castle_99", Rectangle(-522, 116, 25));

		// 'Castle_Troll' GenType 5 Spawn Points
		AddSpawnPoint("f_castle_99.Id5", "f_castle_99", Rectangle(-665, 122, 100));
		AddSpawnPoint("f_castle_99.Id5", "f_castle_99", Rectangle(-605, -880, 100));
		AddSpawnPoint("f_castle_99.Id5", "f_castle_99", Rectangle(66, 139, 100));
		AddSpawnPoint("f_castle_99.Id5", "f_castle_99", Rectangle(701, 1224, 100));
		AddSpawnPoint("f_castle_99.Id5", "f_castle_99", Rectangle(605, 137, 100));
		AddSpawnPoint("f_castle_99.Id5", "f_castle_99", Rectangle(1088, 31, 100));
		AddSpawnPoint("f_castle_99.Id5", "f_castle_99", Rectangle(681, -849, 100));
		AddSpawnPoint("f_castle_99.Id5", "f_castle_99", Rectangle(1808, 144, 100));
		AddSpawnPoint("f_castle_99.Id5", "f_castle_99", Rectangle(1823, -953, 100));
		AddSpawnPoint("f_castle_99.Id5", "f_castle_99", Rectangle(1922, 1079, 100));
		AddSpawnPoint("f_castle_99.Id5", "f_castle_99", Rectangle(-1725, -873, 100));
		AddSpawnPoint("f_castle_99.Id5", "f_castle_99", Rectangle(-1747, -204, 100));
		AddSpawnPoint("f_castle_99.Id5", "f_castle_99", Rectangle(-1601, 952, 100));
		AddSpawnPoint("f_castle_99.Id5", "f_castle_99", Rectangle(-589, 1090, 100));
		AddSpawnPoint("f_castle_99.Id5", "f_castle_99", Rectangle(-1090, -943, 100));

		// 'Rootcrystal_02' GenType 42 Spawn Points
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(1844, -923, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(1515, -949, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(1184, -942, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(946, -1055, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(786, -880, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(560, -826, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(626, -510, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(672, -148, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(974, 57, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(730, 214, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(444, 87, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(239, 221, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-5, 112, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-319, 19, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-662, -35, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-557, -435, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-693, -838, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-493, -1042, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-1078, -945, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-1511, -1162, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-1477, -806, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-1888, -1109, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-1856, -779, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-1862, -296, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-1547, -309, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-1831, 73, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-1487, 70, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-1822, 487, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-1522, 386, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-1916, 866, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-1587, 791, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-1787, 1209, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-1534, 1131, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-1240, 1080, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-902, 1115, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-649, 1183, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-432, 1015, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-555, 704, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(-541, 338, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(571, 545, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(645, 877, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(416, 1189, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(782, 1168, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(1181, 112, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(1542, 147, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(1897, -4, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(1862, 377, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(1898, 725, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(1753, 1048, 200));
		AddSpawnPoint("f_castle_99.Id6", "f_castle_99", Rectangle(2082, 1161, 200));
	}
}
