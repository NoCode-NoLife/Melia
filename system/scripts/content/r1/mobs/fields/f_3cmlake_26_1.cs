//--- Melia Script -----------------------------------------------------------
// Lanko 26 Waters Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_3cmlake_26_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class F3Cmlake261MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_3cmlake_26_1", MonsterId.KindronWielder, Properties("MHP", 601007, "MINPATK", 8229, "MAXPATK", 10016, "MINMATK", 8229, "MAXMATK", 10016, "DEF", 128412, "MDEF", 128412));
		AddPropertyOverrides("f_3cmlake_26_1", MonsterId.KindronLilter, Properties("MHP", 601985, "MINPATK", 8242, "MAXPATK", 10031, "MINMATK", 8242, "MAXMATK", 10031, "DEF", 128998, "MDEF", 128998));
		AddPropertyOverrides("f_3cmlake_26_1", MonsterId.Ravisher_Mage, Properties("MHP", 603019, "MINPATK", 8255, "MAXPATK", 10048, "MINMATK", 8255, "MAXMATK", 10048, "DEF", 129617, "MDEF", 129617));
		AddPropertyOverrides("f_3cmlake_26_1", MonsterId.Ravisher, Properties("MHP", 604106, "MINPATK", 8269, "MAXPATK", 10065, "MINMATK", 8269, "MAXMATK", 10065, "DEF", 130268, "MDEF", 130268));

		// Monster Spawners ---------------------------------

		AddSpawner("f_3cmlake_26_1.Id1", MonsterId.RootCrystal_A, 12, 16, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_26_1.Id2", MonsterId.KindronWielder, 51, 67, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_26_1.Id3", MonsterId.KindronLilter, 20, 26, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_26_1.Id4", MonsterId.Ravisher_Mage, 11, 14, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_26_1.Id5", MonsterId.Ravisher, 15, 19, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'RootCrystal_A' GenType 51 Spawn Points
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(-156, 1189, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(-734, 911, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(-1669, 1148, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(838, 712, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(1059, 1272, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(906, -895, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(1028, -1268, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(1616, -1199, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(539, -1186, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(142, -1701, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(81, -1357, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(139, -2088, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(-143, 853, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(1615, 602, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(-567, -1256, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(-874, -1271, 40));

		// 'KindronWielder' GenType 55 Spawn Points
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-961, 1012, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-1237, 862, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-908, 850, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-475, 919, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-1394, 929, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-1165, 1053, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-76, 1080, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-289, 826, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(40, 718, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(175, 1008, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(249, 830, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-304, 658, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(538, 825, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(709, 699, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(861, 561, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(971, 679, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(923, 836, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(1157, 788, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(911, 1036, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(992, -853, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(466, -1190, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(1354, -1213, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-733, -1273, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-775, -1086, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-812, -1438, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-990, -1271, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-350, -1231, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(104, -1594, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(348, -1902, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-81, -2015, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(205, -1885, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-598, -1333, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(270, -1372, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-77, -1291, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(941, -725, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-100, 549, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(111, -2005, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-1063, 803, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-1250, 981, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-690, 891, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(92, 834, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-240, 1093, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(149, 607, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(388, 842, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(742, 595, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(1014, 735, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(764, 857, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(628, -1160, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-570, -1178, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-597, -1435, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-938, -1103, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-49, -1453, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(298, -2176, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(143, -2229, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-112, -1844, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(279, -1760, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(56, -2076, 20));

		// 'KindronLilter' GenType 56 Spawn Points
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-1831, 821, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-1829, 1050, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-1593, 1054, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-1596, 817, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-239, 989, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-138, 702, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(43, 1033, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(260, 714, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(842, 1361, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(1065, 1358, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(950, 1637, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(1073, 597, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(1067, 878, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(672, 861, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-856, -1152, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-939, -1422, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-674, -1420, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-676, -1153, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(18, -2152, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(299, -2064, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(11, -1864, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-1113, 950, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(874, -1238, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(1126, -1243, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(1942, -1144, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(1742, -1213, 20));

		// 'Ravisher_Mage' GenType 57 Spawn Points
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(1092, -1334, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(1054, -1035, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(810, -1293, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(796, -1077, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(1183, -1275, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(1848, -1048, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(1931, -1228, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(1644, -1333, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(1635, -1057, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(1467, -1151, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(646, -1219, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(1779, -1153, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(2022, -1317, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(1237, -1038, 20));

		// 'Ravisher' GenType 58 Spawn Points
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(938, 1308, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(780, 1477, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(1089, 1463, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(1060, 1597, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(826, 1596, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(891, 1458, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(777, -1178, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(1185, -1150, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(874, -980, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(929, -1366, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(-1730, 1097, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(-1564, 928, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(-1733, 752, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(-1884, 938, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(-1677, 934, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(771, -1350, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(1047, -930, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(1017, 1483, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(-2018, 939, 20));
	}
}
