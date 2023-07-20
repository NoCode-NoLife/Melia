//--- Melia Script -----------------------------------------------------------
// Cranto Coast Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_coral_32_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCoral321MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_coral_32_1.Id1", MonsterId.TerraNymph_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_32_1.Id2", MonsterId.Greentoshell, 53, 70, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_32_1.Id3", MonsterId.Lapasape_Mage_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_32_1.Id4", MonsterId.Rootcrystal_01, 9, 12, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_coral_32_1.Id5", MonsterId.Greentoshell, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'TerraNymph_Blue' GenType 2 Spawn Points
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(428, -832, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(957, -284, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(905, -473, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(891, -351, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(317, -741, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(645, -1139, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(771, -978, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(266, -959, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(841, -1133, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(204, -786, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(10, -65, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(451, -138, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(895, 773, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(1056, 1039, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(1207, 1182, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(1091, 663, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(-1, 169, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(-472, -235, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(-355, 272, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(-584, -44, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(-229, -229, 25));
		AddSpawnPoint("f_coral_32_1.Id1", "f_coral_32_1", Rectangle(1294, 863, 25));

		// 'Greentoshell' GenType 3 Spawn Points
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(434, -812, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(539, 142, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(76, 145, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(28, 366, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(-301, 616, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(-79, 805, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(-196, 611, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(-174, 726, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(504, 270, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(765, 485, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(551, -207, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(78, -89, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(-388, 497, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(-211, 114, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(366, -904, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(478, -476, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(485, -637, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(960, 793, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(1073, 1165, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(1281, 760, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(1410, 972, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(839, 591, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(1157, -309, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(908, -322, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(1108, -236, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(1424, -49, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(987, -371, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(802, -455, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(882, -246, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(-355, 6, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(-651, -157, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(-388, -336, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(328, -838, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(214, -679, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(1207, 862, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(729, -1085, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(854, -1030, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(1156, 1020, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(368, 183, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(390, -390, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(-47, -38, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(1262, 1064, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(168, -904, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(640, -1247, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(841, -383, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(846, 795, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(-278, 829, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(385, 344, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(-60, 634, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(149, -789, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(819, -875, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(773, -943, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(355, -723, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(817, -1144, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(640, -1060, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(372, 0, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(-275, -89, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(734, -1310, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(-582, -272, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(670, -25, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(885, -1282, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(1096, 654, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(715, 406, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(879, -1205, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(952, 998, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(991, -1172, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(760, 151, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(-222, -287, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(939, -1032, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(1144, -457, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(608, -1172, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(402, -232, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(503, -979, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(523, -907, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(218, -984, 25));
		AddSpawnPoint("f_coral_32_1.Id2", "f_coral_32_1", Rectangle(404, -903, 25));

		// 'Lapasape_Mage_Blue' GenType 4 Spawn Points
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(457, -984, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(809, -354, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(396, 267, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(1005, -462, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(1234, -394, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(1233, -243, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(1478, -15, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(1120, 849, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(1242, 1027, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(-27, 113, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(388, -276, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(534, -354, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(151, -865, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(759, -1043, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(796, -1224, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(75, 221, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(-101, -77, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(564, 94, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(653, 412, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(227, -678, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(674, -1250, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(-210, 746, 25));
		AddSpawnPoint("f_coral_32_1.Id3", "f_coral_32_1", Rectangle(741, -1128, 25));

		// 'Rootcrystal_01' GenType 12 Spawn Points
		AddSpawnPoint("f_coral_32_1.Id4", "f_coral_32_1", Rectangle(-277, 256, 150));
		AddSpawnPoint("f_coral_32_1.Id4", "f_coral_32_1", Rectangle(258, -866, 150));
		AddSpawnPoint("f_coral_32_1.Id4", "f_coral_32_1", Rectangle(1549, -36, 150));
		AddSpawnPoint("f_coral_32_1.Id4", "f_coral_32_1", Rectangle(891, -1069, 150));
		AddSpawnPoint("f_coral_32_1.Id4", "f_coral_32_1", Rectangle(404, -378, 150));
		AddSpawnPoint("f_coral_32_1.Id4", "f_coral_32_1", Rectangle(832, -338, 150));
		AddSpawnPoint("f_coral_32_1.Id4", "f_coral_32_1", Rectangle(635, 199, 150));
		AddSpawnPoint("f_coral_32_1.Id4", "f_coral_32_1", Rectangle(1301, 959, 150));
		AddSpawnPoint("f_coral_32_1.Id4", "f_coral_32_1", Rectangle(-55, 728, 150));
		AddSpawnPoint("f_coral_32_1.Id4", "f_coral_32_1", Rectangle(33, 308, 150));
		AddSpawnPoint("f_coral_32_1.Id4", "f_coral_32_1", Rectangle(-567, -264, 150));

		// 'Greentoshell' GenType 33 Spawn Points
		AddSpawnPoint("f_coral_32_1.Id5", "f_coral_32_1", Rectangle(-384, -17, 25));
		AddSpawnPoint("f_coral_32_1.Id5", "f_coral_32_1", Rectangle(-387, -183, 25));
		AddSpawnPoint("f_coral_32_1.Id5", "f_coral_32_1", Rectangle(-627, -180, 25));
	}
}
