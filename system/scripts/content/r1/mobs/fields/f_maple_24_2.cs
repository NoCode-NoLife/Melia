//--- Melia Script -----------------------------------------------------------
// Southern Parias Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_maple_24_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FMaple242MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_maple_24_2", MonsterId.Banterer_Red, Properties("MHP", 741917, "MINPATK", 10041, "MAXPATK", 12244, "MINMATK", 10041, "MAXMATK", 12244, "DEF", 221087, "MDEF", 221087));
		AddPropertyOverrides("f_maple_24_2", MonsterId.Fragolin, Properties("MHP", 744761, "MINPATK", 10078, "MAXPATK", 12288, "MINMATK", 10078, "MAXMATK", 12288, "DEF", 223120, "MDEF", 223120));
		AddPropertyOverrides("f_maple_24_2", MonsterId.Rafflet, Properties("MHP", 747642, "MINPATK", 10115, "MAXPATK", 12334, "MINMATK", 10115, "MAXMATK", 12334, "DEF", 225179, "MDEF", 225179));

		// Monster Spawners ---------------------------------

		AddSpawner("f_maple_24_2.Id1", MonsterId.Banterer_Red, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_24_2.Id2", MonsterId.Fragolin, 48, 63, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_24_2.Id3", MonsterId.Rafflet, 46, 61, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_24_2.Id4", MonsterId.Rootcrystal_01, 19, 25, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Banterer_Red' GenType 1 Spawn Points
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(-1311, -604, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(-1172, -455, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(-1033, -520, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(-1258, -683, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(-1128, -751, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(-1033, -385, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(-1098, -660, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(-488, 740, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(-605, 687, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(-1197, -599, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(-735, 580, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(-762, 744, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(-595, 798, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(-546, 547, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(-296, 516, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(852, 148, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(930, 1, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(1031, 50, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(893, 70, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(1247, -20, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(1279, -73, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(1389, 2, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(1282, 53, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(1356, -51, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(1358, -136, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(749, 160, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(833, 40, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(2, 338, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(-43, 374, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(-233, 349, 20));
		AddSpawnPoint("f_maple_24_2.Id1", "f_maple_24_2", Rectangle(-1105, -558, 20));

		// 'Fragolin' GenType 2 Spawn Points
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-454, -712, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-428, -543, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-660, -1218, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-617, -1148, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-700, -1099, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-558, -1103, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-687, -996, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-561, -1035, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-558, -920, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-530, -874, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-127, -558, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-120, -494, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-244, -325, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-297, -470, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-353, -366, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-6, -180, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-27, -30, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(39, -262, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(125, -120, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-701, 166, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-748, 99, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-710, 28, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-762, 180, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-630, 29, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-561, 17, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-546, 100, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-524, 210, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(43, -364, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(308, 272, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-785, 658, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-623, 706, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-663, 640, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-502, 618, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-636, 790, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-572, 617, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(270, 30, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(315, 138, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(352, 285, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(206, 252, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(431, 380, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(506, 263, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(125, 701, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(68, 733, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(206, 748, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(208, 819, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(283, 767, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(152, 907, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(109, 825, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(77, 902, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-319, 548, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-276, 473, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-113, 358, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-13, 349, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-875, -398, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-842, -366, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-639, -415, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-620, -385, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-376, 133, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-325, 135, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-159, 71, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(-132, 32, 20));
		AddSpawnPoint("f_maple_24_2.Id2", "f_maple_24_2", Rectangle(521, 117, 20));

		// 'Rafflet' GenType 3 Spawn Points
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(953, 660, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(935, 772, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(1033, 793, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(865, 685, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(794, 629, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(1123, 830, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(1182, 881, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(1107, 964, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(1200, 943, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(1043, 833, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(386, -1487, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(-68, -626, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(444, -1411, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(352, -1266, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(485, -1301, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(399, -1204, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(343, -1347, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(250, -1275, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(279, -1180, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(86, -913, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(174, -1113, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(100, -1022, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(43, -1076, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(282, -991, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(23, -794, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(-15, -725, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(165, -917, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(-108, -192, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(-101, -82, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(-91, -416, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(-227, -424, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(120, -253, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(333, -353, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(392, -470, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(551, -451, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(449, -382, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(756, -420, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(498, -291, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(503, -532, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(642, -561, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(673, -489, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(657, -367, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(1103, -597, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(1136, -639, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(1176, -597, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(1134, -536, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(1095, -702, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(1034, -756, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(1175, -688, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(1158, -762, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(1237, -712, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(1198, -797, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(1008, -586, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(-190, -241, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(174, -329, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(41, -73, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(119, 1, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(220, -158, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(233, -45, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(358, -16, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(405, 165, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(424, 262, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(516, 310, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(537, 202, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(549, 371, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(571, 262, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(369, 383, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(630, 367, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(808, 472, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(682, 512, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(624, 524, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(892, 415, 20));
		AddSpawnPoint("f_maple_24_2.Id3", "f_maple_24_2", Rectangle(1255, 900, 20));

		// 'Rootcrystal_01' GenType 5 Spawn Points
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(995, 778, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(716, 509, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(431, 233, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(379, 594, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(174, 791, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(843, 122, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(1268, -9, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(101, 310, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(-263, 449, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(-537, 668, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(-829, 630, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(-1137, 655, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(-628, 123, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(-225, 100, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(105, -104, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(-188, -393, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(-668, -413, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(-1015, -436, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(-1184, -659, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(385, -357, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(731, -444, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(1080, -616, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(-29, -693, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(160, -981, 200));
		AddSpawnPoint("f_maple_24_2.Id4", "f_maple_24_2", Rectangle(366, -1283, 200));
	}
}
