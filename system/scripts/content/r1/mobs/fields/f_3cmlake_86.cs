//--- Melia Script -----------------------------------------------------------
// Barynwell 86 Waters Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_3cmlake_86'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class F3Cmlake86MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_3cmlake_86", MonsterId.Spinacho, Properties("MHP", 599233, "MINPATK", 8206, "MAXPATK", 9988, "MINMATK", 8206, "MAXMATK", 9988, "DEF", 127350, "MDEF", 127350));
		AddPropertyOverrides("f_3cmlake_86", MonsterId.Rubeta, Properties("MHP", 600088, "MINPATK", 8217, "MAXPATK", 10001, "MINMATK", 8217, "MAXMATK", 10001, "DEF", 127862, "MDEF", 127862));
		AddPropertyOverrides("f_3cmlake_86", MonsterId.Lilymaid, Properties("MHP", 601007, "MINPATK", 8229, "MAXPATK", 10016, "MINMATK", 8229, "MAXMATK", 10016, "DEF", 128412, "MDEF", 128412));
		AddPropertyOverrides("f_3cmlake_86", MonsterId.Little_Rubeta, Properties("MHP", 601985, "MINPATK", 8242, "MAXPATK", 10031, "MINMATK", 8242, "MAXMATK", 10031, "DEF", 128998, "MDEF", 128998));
		AddPropertyOverrides("f_3cmlake_86", MonsterId.Boss_Deadbone_Q3, Properties("MHP", 3147758, "MINPATK", 20803, "MAXPATK", 25321, "MINMATK", 20803, "MAXMATK", 25321, "DEF", 326635, "MDEF", 326635));

		// Monster Spawners ---------------------------------

		AddSpawner("f_3cmlake_86.Id1", MonsterId.Spinacho, 21, 28, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_86.Id2", MonsterId.Rubeta, 14, 18, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_86.Id3", MonsterId.Lilymaid, 16, 21, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_86.Id4", MonsterId.Nolimaid, 13, 17, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_86.Id5", MonsterId.Little_Rubeta, 39, 51, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_86.Id6", MonsterId.Rootcrystal_02, 1, 1, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Spinacho' GenType 64 Spawn Points
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(367, -664, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(360, -389, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(559, -108, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(806, -111, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(634, -344, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(620, -779, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(716, -1053, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(1103, -1068, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(1301, -960, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(1252, -546, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(1311, -207, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(1461, -687, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(1568, -1063, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(1765, -997, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(2164, -832, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(2200, -330, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(1949, -184, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(1725, -326, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(1760, -598, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(2319, -172, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(1488, -73, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(1336, 389, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(1593, 341, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(1462, 760, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(1733, 613, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(924, -109, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(2151, -562, 45));
		AddSpawnPoint("f_3cmlake_86.Id1", "f_3cmlake_86", Rectangle(352, -138, 45));

		// 'Rubeta' GenType 66 Spawn Points
		AddSpawnPoint("f_3cmlake_86.Id2", "f_3cmlake_86", Rectangle(-1161, -1022, 45));
		AddSpawnPoint("f_3cmlake_86.Id2", "f_3cmlake_86", Rectangle(-975, -824, 45));
		AddSpawnPoint("f_3cmlake_86.Id2", "f_3cmlake_86", Rectangle(-1372, -800, 45));
		AddSpawnPoint("f_3cmlake_86.Id2", "f_3cmlake_86", Rectangle(-1164, -537, 45));
		AddSpawnPoint("f_3cmlake_86.Id2", "f_3cmlake_86", Rectangle(-1311, 127, 45));
		AddSpawnPoint("f_3cmlake_86.Id2", "f_3cmlake_86", Rectangle(-918, 161, 45));
		AddSpawnPoint("f_3cmlake_86.Id2", "f_3cmlake_86", Rectangle(-706, 100, 45));
		AddSpawnPoint("f_3cmlake_86.Id2", "f_3cmlake_86", Rectangle(-1128, 558, 45));
		AddSpawnPoint("f_3cmlake_86.Id2", "f_3cmlake_86", Rectangle(-721, 342, 45));
		AddSpawnPoint("f_3cmlake_86.Id2", "f_3cmlake_86", Rectangle(-480, 581, 45));
		AddSpawnPoint("f_3cmlake_86.Id2", "f_3cmlake_86", Rectangle(-358, 259, 45));
		AddSpawnPoint("f_3cmlake_86.Id2", "f_3cmlake_86", Rectangle(-145, 415, 45));
		AddSpawnPoint("f_3cmlake_86.Id2", "f_3cmlake_86", Rectangle(-38, 622, 45));
		AddSpawnPoint("f_3cmlake_86.Id2", "f_3cmlake_86", Rectangle(-1502, 427, 45));
		AddSpawnPoint("f_3cmlake_86.Id2", "f_3cmlake_86", Rectangle(-1163, -348, 45));
		AddSpawnPoint("f_3cmlake_86.Id2", "f_3cmlake_86", Rectangle(-1098, 354, 45));
		AddSpawnPoint("f_3cmlake_86.Id2", "f_3cmlake_86", Rectangle(-1414, -164, 45));
		AddSpawnPoint("f_3cmlake_86.Id2", "f_3cmlake_86", Rectangle(-799, -733, 45));

		// 'Lilymaid' GenType 68 Spawn Points
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(-1313, 1287, 45));
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(-1263, 1085, 45));
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(-1146, 942, 45));
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(-921, 1045, 45));
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(-873, 1229, 45));
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(-1110, 1348, 45));
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(-544, 1163, 45));
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(-606, 869, 45));
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(-48, 1696, 45));
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(-286, 972, 45));
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(-33, 1237, 45));
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(213, 1215, 45));
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(639, 857, 45));
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(851, 845, 45));
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(858, 426, 45));
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(792, 119, 45));
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(587, 114, 45));
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(295, 381, 45));
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(295, 580, 45));
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(477, 619, 45));
		AddSpawnPoint("f_3cmlake_86.Id3", "f_3cmlake_86", Rectangle(750, 624, 45));

		// 'Nolimaid' GenType 70 Spawn Points
		AddSpawnPoint("f_3cmlake_86.Id4", "f_3cmlake_86", Rectangle(-1022, 971, 45));
		AddSpawnPoint("f_3cmlake_86.Id4", "f_3cmlake_86", Rectangle(-892, 1346, 45));
		AddSpawnPoint("f_3cmlake_86.Id4", "f_3cmlake_86", Rectangle(-1171, 1151, 45));
		AddSpawnPoint("f_3cmlake_86.Id4", "f_3cmlake_86", Rectangle(-1248, 1408, 45));
		AddSpawnPoint("f_3cmlake_86.Id4", "f_3cmlake_86", Rectangle(-629, 990, 45));
		AddSpawnPoint("f_3cmlake_86.Id4", "f_3cmlake_86", Rectangle(-159, 1169, 45));
		AddSpawnPoint("f_3cmlake_86.Id4", "f_3cmlake_86", Rectangle(243, 1049, 45));
		AddSpawnPoint("f_3cmlake_86.Id4", "f_3cmlake_86", Rectangle(-56, 1546, 45));
		AddSpawnPoint("f_3cmlake_86.Id4", "f_3cmlake_86", Rectangle(-22, 1775, 45));
		AddSpawnPoint("f_3cmlake_86.Id4", "f_3cmlake_86", Rectangle(732, 952, 45));
		AddSpawnPoint("f_3cmlake_86.Id4", "f_3cmlake_86", Rectangle(807, 271, 45));
		AddSpawnPoint("f_3cmlake_86.Id4", "f_3cmlake_86", Rectangle(434, 122, 45));
		AddSpawnPoint("f_3cmlake_86.Id4", "f_3cmlake_86", Rectangle(252, 202, 45));
		AddSpawnPoint("f_3cmlake_86.Id4", "f_3cmlake_86", Rectangle(221, 669, 45));
		AddSpawnPoint("f_3cmlake_86.Id4", "f_3cmlake_86", Rectangle(560, 728, 45));
		AddSpawnPoint("f_3cmlake_86.Id4", "f_3cmlake_86", Rectangle(925, 65, 45));
		AddSpawnPoint("f_3cmlake_86.Id4", "f_3cmlake_86", Rectangle(74, 1400, 45));

		// 'Little_Rubeta' GenType 72 Spawn Points
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(-1368, -889, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(-1295, -532, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(-1033, -505, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(-985, -730, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(-1022, -1016, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(-549, -711, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(-1128, -197, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(-1472, -39, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(-1574, 281, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(-1288, 543, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(-867, 464, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(-822, 265, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(-949, 71, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(-1214, 117, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(-627, 428, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(-351, 652, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(-439, 322, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(13, 586, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(-335, 478, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(390, -537, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(412, -814, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(760, -112, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(1197, -106, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(1245, -357, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(870, -261, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(642, -539, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(619, -948, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(865, -1001, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(1007, -1092, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(1196, -981, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(1217, -771, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(1439, -482, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(1385, -800, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(1919, -1064, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(1952, -834, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(2211, -451, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(1994, -57, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(2117, -231, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(1741, -440, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(1947, -570, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(2401, -56, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(1465, 19, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(1491, 297, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(1378, 540, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(1615, 783, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(1784, 463, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(478, -124, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(1695, -1093, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(-471, -600, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(914, -105, 45));
		AddSpawnPoint("f_3cmlake_86.Id5", "f_3cmlake_86", Rectangle(769, 138, 45));

		// 'Rootcrystal_02' GenType 77 Spawn Points
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(-208, -1282, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(-220, -939, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(-124, -472, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(-219, 34, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(-876, -704, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(-1322, -972, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(-1094, -514, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(-1105, -133, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(-1542, 341, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(-790, -23, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(-1040, 373, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(-1093, 887, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(-1279, 1255, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(-876, 1275, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(-252, 1082, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(-560, 869, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(-498, 462, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(-26, 605, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(486, 563, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(760, 218, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(401, 82, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(718, -366, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(765, -1094, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(853, -117, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(1249, -818, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(1295, -368, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(360, -366, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(1580, -995, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(1917, -783, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(2277, -575, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(1946, -134, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(1387, 109, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(1415, 638, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(1726, 554, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(823, 766, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(444, 1069, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(327, 1392, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(-128, 1720, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(734, 1497, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(1061, 1576, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(1050, 1904, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(1415, 1600, 200));
		AddSpawnPoint("f_3cmlake_86.Id6", "f_3cmlake_86", Rectangle(1271, 1237, 200));
	}
}
