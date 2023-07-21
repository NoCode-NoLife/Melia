//--- Melia Script -----------------------------------------------------------
// Rinksmas Ruins Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_desolated_capital_53_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FDesolatedCapital531MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_desolated_capital_53_1", MonsterId.Orc_Double_Axe, Properties("MHP", 807799, "MINPATK", 10888, "MAXPATK", 13285, "MINMATK", 10888, "MAXMATK", 13285, "DEF", 275842, "MDEF", 275842));
		AddPropertyOverrides("f_desolated_capital_53_1", MonsterId.Orc_Shield, Properties("MHP", 810189, "MINPATK", 10919, "MAXPATK", 13322, "MINMATK", 10919, "MAXMATK", 13322, "DEF", 277855, "MDEF", 277855));
		AddPropertyOverrides("f_desolated_capital_53_1", MonsterId.Orc_Wand, Properties("MHP", 812610, "MINPATK", 10950, "MAXPATK", 13361, "MINMATK", 10950, "MAXMATK", 13361, "DEF", 279894, "MDEF", 279894));
		AddPropertyOverrides("f_desolated_capital_53_1", MonsterId.Orc_Leader, Properties("MHP", 815061, "MINPATK", 10982, "MAXPATK", 13399, "MINMATK", 10982, "MAXMATK", 13399, "DEF", 281959, "MDEF", 281959));
		AddPropertyOverrides("f_desolated_capital_53_1", MonsterId.Boss_WoodCenturion_Q1, Properties("MHP", 4365680, "MINPATK", 29076, "MAXPATK", 35478, "MINMATK", 29076, "MAXMATK", 35478, "DEF", 749889, "MDEF", 749889));

		// Monster Spawners ---------------------------------

		AddSpawner("f_desolated_capital_53_1.Id1", MonsterId.Orc_Double_Axe, 34, 45, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_desolated_capital_53_1.Id2", MonsterId.Orc_Shield, 34, 45, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_desolated_capital_53_1.Id3", MonsterId.Orc_Wand, 27, 35, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_desolated_capital_53_1.Id4", MonsterId.Orc_Leader, 6, 8, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_desolated_capital_53_1.Id5", MonsterId.Orc_Double_Axe, 8, 10, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_desolated_capital_53_1.Id6", MonsterId.Rootcrystal_01, 23, 30, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Orc_Double_Axe' GenType 1 Spawn Points
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(2013, 1561, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(1890, 1431, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(1854, 1581, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(2092, 1456, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(2606, 1904, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(2508, 1824, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(2641, 1704, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(2834, 1870, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(2734, 1813, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(883, 1280, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(1049, 1619, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(1305, 1507, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(1089, 1161, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(937, 1729, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(1469, 1786, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(2018, 1743, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(2139, 1684, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(2500, 1501, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(2438, 1275, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(2208, 1124, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(2565, 1340, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(3341, 1669, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(3112, 1536, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(3254, 1369, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(3361, 1366, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(3340, 1546, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(3247, 1775, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(952, 1201, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(2827, 3247, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(2648, 1995, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(2468, 1922, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(2655, 1808, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(3410, 1213, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(3268, 1463, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(3455, 1543, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(3249, 1695, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(3392, 1483, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(3189, 1582, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(3080, 1772, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(821, 1508, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(3150, 1654, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(2765, 1690, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(2938, 1776, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(3127, 1426, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(3125, 1331, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(1027, 1948, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(1661, 1668, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(3470, 1323, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(1615, 1749, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id1", "f_desolated_capital_53_1", Rectangle(2156, 2863, 30));

		// 'Orc_Shield' GenType 2 Spawn Points
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(887, 2549, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(1027, 2613, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(886, 2776, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(896, 2795, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(1167, 3202, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(1185, 3074, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(957, 3098, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(1019, 2050, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(825, 1945, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(979, 1865, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(1134, 1893, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(782, 1255, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(983, 1430, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(1026, 1291, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(797, 1392, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(973, 1114, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(1255, 1284, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(1190, 1400, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(1479, 1590, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(1241, 1812, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(691, 1153, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(884, 2951, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(1065, 1393, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(846, 2661, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(885, 1371, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(1887, 592, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(1781, 792, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(2092, 752, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(2155, 964, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(2057, 828, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(2477, 2432, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(2412, 2361, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(2207, 2316, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(2646, 2424, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(1960, 821, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(2034, 472, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(2584, 681, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(2757, 785, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(2985, 727, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(3069, 772, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(3005, 586, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(1170, 1248, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(2692, 713, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(2747, 527, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(1108, 1496, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(823, 1141, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(2091, 633, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(2306, 511, 30));
		AddSpawnPoint("f_desolated_capital_53_1.Id2", "f_desolated_capital_53_1", Rectangle(2476, 586, 30));

		// 'Orc_Wand' GenType 3 Spawn Points
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2368, 2765, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2238, 3000, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2539, 2431, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2618, 3398, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2559, 3166, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(3003, 3312, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2292, 2442, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2835, 3038, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2509, 3274, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2327, 2844, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(929, 1938, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2753, 1948, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(658, 1439, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2230, 2758, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(700, 1273, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(858, 2686, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2001, 1649, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(1995, 1486, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2585, 1503, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2270, 1191, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2097, 1098, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2076, 926, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(1877, 774, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2125, 1519, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(1981, 643, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(1807, 676, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2144, 530, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2577, 662, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2679, 813, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2969, 876, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(3055, 673, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2950, 498, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2811, 452, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2682, 609, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2837, 854, 35));
		AddSpawnPoint("f_desolated_capital_53_1.Id3", "f_desolated_capital_53_1", Rectangle(2921, 638, 35));

		// 'Orc_Leader' GenType 4 Spawn Points
		AddSpawnPoint("f_desolated_capital_53_1.Id4", "f_desolated_capital_53_1", Rectangle(1979, 543, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id4", "f_desolated_capital_53_1", Rectangle(2781, 606, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id4", "f_desolated_capital_53_1", Rectangle(2352, 1282, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id4", "f_desolated_capital_53_1", Rectangle(2071, 1566, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id4", "f_desolated_capital_53_1", Rectangle(1120, 1322, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id4", "f_desolated_capital_53_1", Rectangle(1119, 1997, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id4", "f_desolated_capital_53_1", Rectangle(2777, 3210, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id4", "f_desolated_capital_53_1", Rectangle(2325, 2953, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id4", "f_desolated_capital_53_1", Rectangle(2972, 3087, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id4", "f_desolated_capital_53_1", Rectangle(1156, 3129, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id4", "f_desolated_capital_53_1", Rectangle(946, 2656, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id4", "f_desolated_capital_53_1", Rectangle(2610, 1884, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id4", "f_desolated_capital_53_1", Rectangle(718, 1357, 100));

		// 'Orc_Double_Axe' GenType 5 Spawn Points
		AddSpawnPoint("f_desolated_capital_53_1.Id5", "f_desolated_capital_53_1", Rectangle(2236, 2909, 25));
		AddSpawnPoint("f_desolated_capital_53_1.Id5", "f_desolated_capital_53_1", Rectangle(2226, 3088, 25));
		AddSpawnPoint("f_desolated_capital_53_1.Id5", "f_desolated_capital_53_1", Rectangle(2142, 3078, 25));
		AddSpawnPoint("f_desolated_capital_53_1.Id5", "f_desolated_capital_53_1", Rectangle(887, 2046, 25));
		AddSpawnPoint("f_desolated_capital_53_1.Id5", "f_desolated_capital_53_1", Rectangle(2329, 2324, 25));
		AddSpawnPoint("f_desolated_capital_53_1.Id5", "f_desolated_capital_53_1", Rectangle(2618, 3278, 25));
		AddSpawnPoint("f_desolated_capital_53_1.Id5", "f_desolated_capital_53_1", Rectangle(2734, 3070, 25));
		AddSpawnPoint("f_desolated_capital_53_1.Id5", "f_desolated_capital_53_1", Rectangle(2872, 3136, 25));
		AddSpawnPoint("f_desolated_capital_53_1.Id5", "f_desolated_capital_53_1", Rectangle(3001, 3191, 25));
		AddSpawnPoint("f_desolated_capital_53_1.Id5", "f_desolated_capital_53_1", Rectangle(2958, 3388, 25));
		AddSpawnPoint("f_desolated_capital_53_1.Id5", "f_desolated_capital_53_1", Rectangle(2840, 3391, 25));
		AddSpawnPoint("f_desolated_capital_53_1.Id5", "f_desolated_capital_53_1", Rectangle(2767, 3445, 25));
		AddSpawnPoint("f_desolated_capital_53_1.Id5", "f_desolated_capital_53_1", Rectangle(2517, 3363, 25));
		AddSpawnPoint("f_desolated_capital_53_1.Id5", "f_desolated_capital_53_1", Rectangle(2673, 3177, 25));

		// 'Rootcrystal_01' GenType 10 Spawn Points
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2476, 2282, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(3406, 1235, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(3412, 1491, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(3128, 1468, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(3181, 1828, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(3230, 1630, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2945, 1824, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2689, 1751, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2433, 1912, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2673, 1955, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2631, 2430, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2284, 2393, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1968, 2348, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1760, 2140, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1506, 2078, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1371, 2555, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1719, 2488, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1769, 2739, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2156, 2935, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1938, 2889, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2250, 3132, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2308, 2784, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2354, 3022, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2636, 3081, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2867, 3075, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(3030, 3247, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2883, 3457, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2541, 3407, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2511, 3230, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1841, 2377, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1071, 2600, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(891, 2597, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(883, 2805, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(901, 3103, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1168, 3058, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1229, 3235, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1351, 2267, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1208, 2022, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(991, 2056, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(792, 1950, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1025, 1917, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1063, 1645, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1289, 1868, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1450, 1651, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1258, 1386, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1046, 1209, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(824, 1169, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(678, 1405, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(973, 1415, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1594, 1850, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1750, 1610, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1937, 1485, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2173, 1507, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1957, 1668, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2477, 1489, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2510, 1336, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2293, 1251, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2100, 1043, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2110, 748, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2017, 547, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1883, 773, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(1735, 994, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2275, 506, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2525, 642, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2625, 843, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2704, 640, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2877, 504, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2992, 654, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2944, 886, 100));
		AddSpawnPoint("f_desolated_capital_53_1.Id6", "f_desolated_capital_53_1", Rectangle(2776, 842, 100));
	}
}
