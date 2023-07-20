//--- Melia Script -----------------------------------------------------------
// Barynwell 87 Waters Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_3cmlake_87'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class F3Cmlake87MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_3cmlake_87", MonsterId.Humming_Duke, Properties("MHP", 604106, "MINPATK", 8269, "MAXPATK", 10065, "MINMATK", 8269, "MAXMATK", 10065, "DEF", 130268, "MDEF", 130268));
		AddPropertyOverrides("f_3cmlake_87", MonsterId.Mutt, Properties("MHP", 605244, "MINPATK", 8284, "MAXPATK", 10083, "MINMATK", 8284, "MAXMATK", 10083, "DEF", 130950, "MDEF", 130950));
		AddPropertyOverrides("f_3cmlake_87", MonsterId.Beissen, Properties("MHP", 606430, "MINPATK", 8299, "MAXPATK", 10102, "MINMATK", 8299, "MAXMATK", 10102, "DEF", 131660, "MDEF", 131660));
		AddPropertyOverrides("f_3cmlake_87", MonsterId.KindronShooter, Properties("MHP", 607663, "MINPATK", 8315, "MAXPATK", 10121, "MINMATK", 8315, "MAXMATK", 10121, "DEF", 132398, "MDEF", 132398));
		AddPropertyOverrides("f_3cmlake_87", MonsterId.KindronBoor, Properties("MHP", 608940, "MINPATK", 8331, "MAXPATK", 10141, "MINMATK", 8331, "MAXMATK", 10141, "DEF", 133163, "MDEF", 133163));
		AddPropertyOverrides("f_3cmlake_87", MonsterId.Boss_Pbeta, Properties("MHP", 2185563, "MINPATK", 21037, "MAXPATK", 25609, "MINMATK", 21037, "MAXMATK", 25609, "DEF", 337565, "MDEF", 337565));

		// Monster Spawners ---------------------------------

		AddSpawner("f_3cmlake_87.Id1", MonsterId.Humming_Duke, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_87.Id2", MonsterId.Mutt, 13, 17, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_87.Id3", MonsterId.Beissen, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_87.Id4", MonsterId.KindronShooter, 18, 23, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_87.Id5", MonsterId.KindronBoor, 19, 25, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_87.Id6", MonsterId.Rootcrystal_02, 23, 30, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Humming_Duke' GenType 45 Spawn Points
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-305, -1136, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-221, -1291, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-62, -1215, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(140, -1264, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-147, -986, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(41, -1074, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-92, -809, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(196, -940, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(239, -1134, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(371, -1008, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(1092, -640, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(1098, -821, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(1313, -723, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(1295, -885, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(868, -636, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(485, 668, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(475, 588, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(609, 682, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-75, 1401, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-126, 1241, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(59, 1431, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(105, 1162, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-47, 1278, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-633, 491, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-983, 215, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-703, 254, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-742, -11, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-972, 20, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-170, 247, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-299, 516, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-172, 670, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-47, 909, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(42, 686, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(285, 502, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(166, 348, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(23, 234, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-109, 498, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(86, 452, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-426, 1115, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(637, -676, 45));

		// 'Mutt' GenType 47 Spawn Points
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-839, -73, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-835, 141, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-825, 367, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-55, 1053, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-242, 1300, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-34, 1513, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-39, 1226, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(301, 1178, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(1027, 1002, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(750, 1279, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(1055, 1286, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-617, 1172, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-1024, 1390, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-1108, 1134, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-1213, 786, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-773, 756, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-766, 976, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-1187, 969, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-1018, 859, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-151, 1859, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-110, 2190, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(100, 2122, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(97, 1882, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-25, 2036, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(251, 2393, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(503, 1417, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(782, 1080, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(933, 1306, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(926, 1162, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-59, 1323, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-881, 873, 45));

		// 'Beissen' GenType 49 Spawn Points
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(-266, 2303, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(-26, 1875, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(-1073, 1258, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(-63, 1405, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(30, 1178, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(-210, 1127, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(-1080, 734, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(-770, 861, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(349, 1367, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(815, 1019, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(927, 1225, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(13, 2239, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(-1001, 79, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(-750, 260, 45));

		// 'KindronShooter' GenType 51 Spawn Points
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(-1170, -979, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(-1010, -842, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(-843, -1160, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(-739, -939, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(-689, -527, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(1147, -889, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(1103, -675, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(1322, -805, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(662, -683, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(-90, -912, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(347, -998, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(-256, -1222, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(72, -1115, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(128, -1286, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(555, -344, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(703, -90, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(592, 200, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(836, 129, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(760, 451, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(-183, 311, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(137, 303, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(-184, 624, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(193, 604, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(-56, 60, 45));

		// 'KindronBoor' GenType 53 Spawn Points
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-33, -1295, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-110, -1063, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(151, -975, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(264, -1169, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-88, -741, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-935, -571, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-1018, -1089, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-1150, -851, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-758, -993, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-488, -412, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(805, -734, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(1361, -646, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(1185, -850, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(817, -3, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(606, 47, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(725, 245, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(656, 639, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-40, 238, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-240, 495, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(249, 423, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-11, 703, 45));

		// 'Rootcrystal_02' GenType 56 Spawn Points
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-139, -1713, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-151, -1282, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(168, -1087, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-124, -608, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-29, -162, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(451, -329, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(635, -719, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(1103, -710, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(1376, -884, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-450, -380, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-925, -529, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-1193, -904, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-914, -1143, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-12, 315, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-594, 478, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-930, 340, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-1069, 80, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-734, -50, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(26, 665, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(420, 682, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(664, 279, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(836, 23, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-21, 1066, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(91, 1423, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-240, 1342, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-574, 1122, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-741, 934, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-1086, 1322, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-1210, 828, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(308, 1334, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(823, 1356, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(961, 1084, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-75, 1809, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(59, 2108, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-781, -856, 200));
	}
}
