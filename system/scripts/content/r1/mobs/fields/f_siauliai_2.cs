//--- Melia Script -----------------------------------------------------------
// f_siauliai_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'East Siauliai Woods' map.
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

		AddSpawner("f_siauliai_2.Id1", MonsterId.Pokubu, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_2.Id2", MonsterId.Chupacabra_Blue, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_2.Id3", MonsterId.Rootcrystal_01, 13, 17, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_2.Id4", MonsterId.Weaver, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_2.Id5", MonsterId.Popolion_Blue, 45, 60, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_2.Id6", MonsterId.Popolion_Blue, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_2.Id7", MonsterId.Chupacabra_Blue, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_2.Id8", MonsterId.Chupacabra_Blue, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_2.Id9", MonsterId.Popolion_Blue, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_2.Id10", MonsterId.Popolion_Blue, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Pokubu' GenType 9 Spawn Points
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(2074.0327, 129.61322, 30));
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(1976.7208, 171.50061, 30));
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(2171, 90, 30));
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(2135, 336, 30));
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(2017.9362, 276.1759, 30));
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(2130, -95, 30));
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(1885, 288, 30));
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(1818.9464, 184.72943, 30));
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(2038.9165, 381.7809, 30));
		AddSpawnPoint("f_siauliai_2.Id1", "f_siauliai_2", Rectangle(2095.055, 23.893608, 30));

		// 'Chupacabra_Blue' GenType 11 Spawn Points
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-1415.4171, -371.55478, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-965.8191, 31.569534, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-1100.5059, 111.37015, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-231.61755, 85.811066, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-170, -154, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-262.82687, 422.1841, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-539.0047, -29.294334, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-1002.7767, 586.3515, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(171.14359, 1082.8328, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(296.45502, 1122.743, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(560, 690, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(429, -680, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(165, -547, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(260, -658, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(388, -271, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(163, -282, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(421, -420, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-919.7093, 931.91504, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-460, 1113, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-291, 907, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-254, 1148, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-860.30164, 568.4828, 30));
		AddSpawnPoint("f_siauliai_2.Id2", "f_siauliai_2", Rectangle(-993.1989, 776.5989, 30));

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
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(-1323.5741, -236.76746, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(566, 871, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(586, 751, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(646, 542, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(543, 496, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(936, 269, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(678, 104, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(693.9263, -41.317894, 100));
		AddSpawnPoint("f_siauliai_2.Id3", "f_siauliai_2", Rectangle(371.82144, -311.6812, 100));
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
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(181.55257, -673.93396, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(-37.895172, -764.7075, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(-137, -871, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(268.08817, -524.2529, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(143.56892, -573.7747, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(-203, -636, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(-131.708, -378.45108, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(618, -921, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(654, -833, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(854, -798, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(831, -882, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1446, 952, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1939, 174, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1847, 294, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(2030.6299, 369.79553, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1596.8788, 222.25282, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1518.1165, 205.74327, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1657.2533, 95.505554, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1554, 130, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1732, 150, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1376.0139, 761.81067, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1273.9951, 586.33527, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1343.0482, 525.35785, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1296.2782, 685.33264, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1299.6434, 797.14, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1466, 847, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(1508, 896, 40));
		AddSpawnPoint("f_siauliai_2.Id4", "f_siauliai_2", Rectangle(712, -895, 40));

		// 'Popolion_Blue' GenType 10006 Spawn Points
		AddSpawnPoint("f_siauliai_2.Id5", "f_siauliai_2", Rectangle(-1927.1439, 1041.3624, 9999));

		// 'Popolion_Blue' GenType 10011 Spawn Points
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-2368.3542, 1278.7267, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1840.894, 742.63513, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-2149.215, 831.1933, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1765, 595, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1985.55, 1064.5444, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1892, 955, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-2227.6328, 1089.1436, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-994.88434, 498.73575, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-843.18036, 559.9528, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-915.6565, 744.29175, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1990.8632, -1187.754, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1971.9531, -1430.1814, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1887.691, -1060.5604, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1947.2255, -1337.2001, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1985.9625, -1047.5697, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-796.8218, -1168.5641, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-987.0851, -1443.2349, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-835.3502, -843.40186, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1046.309, -1249.9479, 30));
		AddSpawnPoint("f_siauliai_2.Id6", "f_siauliai_2", Rectangle(-1122.596, -1559.5442, 30));

		// 'Chupacabra_Blue' GenType 10020 Spawn Points
		AddSpawnPoint("f_siauliai_2.Id7", "f_siauliai_2", Rectangle(258.80804, -563.19403, 250));

		// 'Chupacabra_Blue' GenType 10026 Spawn Points
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-2010.5305, -971.0856, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1917.9153, -961.36273, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1992.7848, -1328.6621, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1821.18, -1165.9307, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-429.78116, 587.1281, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1813.9086, -1480.6727, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1881.3862, -1546.1348, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1625.9272, -1464.0221, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1311.7227, -1471.2858, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1263.4482, -1573.5892, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1159.3401, -1391.4847, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1063.2109, -1490.6077, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-913.03, -1266.498, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1005.0578, -1164.5784, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-959.2174, -1426.8529, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-755.62164, -969.85876, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-880.12445, -865.8571, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-713.44916, 1020.9352, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-602.8175, 600.1465, 50));
		AddSpawnPoint("f_siauliai_2.Id8", "f_siauliai_2", Rectangle(-1921.7312, -1180.6476, 50));

		// 'Popolion_Blue' GenType 10027 Spawn Points
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1971.7739, -1078.5951, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1982.229, -1326.2974, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1837.6208, -1238.417, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1839.5162, -1439.9487, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1958.9437, -1474.009, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1601.8713, -1459.9364, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1339.1614, -1495.0128, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1202.0392, -1398.2892, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1029.8602, -1521.7524, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-877.6972, -1165.6431, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1040.0602, -1230.8342, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-886.7796, -1345.2092, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-835.0664, -899.12335, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-943.9983, -956.24524, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-959.87305, -1256.3824, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1108.8827, -1581.1145, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-690.60876, -1000.6702, 40));
		AddSpawnPoint("f_siauliai_2.Id9", "f_siauliai_2", Rectangle(-1941.5376, -1188.4371, 40));

		// 'Popolion_Blue' GenType 10036 Spawn Points
		AddSpawnPoint("f_siauliai_2.Id10", "f_siauliai_2", Rectangle(-391.65002, 1104.015, 300));
		AddSpawnPoint("f_siauliai_2.Id10", "f_siauliai_2", Rectangle(-772.93024, 1040.5347, 300));
	}
}
