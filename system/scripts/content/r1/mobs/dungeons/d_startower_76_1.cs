//--- Melia Script -----------------------------------------------------------
// Natarh Watchtower Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_startower_76_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DStartower761MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_startower_76_1.Id1", MonsterId.ERD_Slime_Dark_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id2", MonsterId.ERD_Flask_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id3", MonsterId.ERD_Defender_Spider_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id4", MonsterId.ERD_Belegg, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id5", MonsterId.ERD_Tombsinker, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id6", MonsterId.ERD_Bavon, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id7", MonsterId.ERD_Bubbe_Mage_Ice, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id8", MonsterId.ERD_Bagworm, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id9", MonsterId.ERD_Hogma_Warrior, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id10", MonsterId.ERD_Hogma_Warrior, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id11", MonsterId.ERD_Zinutekas, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id12", MonsterId.Rootcrystal_02, 19, 25, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'ERD_Slime_Dark_Blue' GenType 2 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1204, 375, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1053, 422, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-978, 329, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1051, 269, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1171, 255, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1150, 116, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1074, 145, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-936, 136, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-932, 26, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1038, 20, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1145, -8, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1193, -33, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1161, -94, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1049, -99, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-949, -93, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1213, 61, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1204, 229, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1132, 418, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-975, 222, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-872, 507, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-463, 706, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-498, 841, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-396, 918, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-285, 900, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-287, 803, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-297, 717, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-215, 688, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-144, 699, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-183, 759, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-233, 844, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-167, 870, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-135, 963, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-82, 873, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-84, 722, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-392, 804, 40));

		// 'ERD_Flask_Blue' GenType 3 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1407, -543, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1371, -418, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1365, -297, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1226, -452, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1138, -619, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1047, -531, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1118, -414, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1187, -282, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1031, -242, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-893, -280, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-868, -405, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-699, -537, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-836, -525, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-683, -613, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-673, -475, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-685, -348, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-756, -441, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-963, -366, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-803, -245, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-726, -256, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-962, -450, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1234, -599, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1491, -454, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1513, -330, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1559, -559, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-923, -606, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-776, -606, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-763, -353, 40));

		// 'ERD_Defender_Spider_Blue' GenType 4 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1161, -1230, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1104, -1107, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-925, -1042, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-939, -1123, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1013, -1123, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-861, -1312, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1188, -1293, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1098, -1372, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1147, -1445, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-969, -1355, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-893, -1414, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1078, -1286, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1178, -1127, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-896, -1187, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1066, -1195, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-959, -979, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1113, -918, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1194, -742, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-993, -1423, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-956, -1250, 40));

		// 'ERD_Belegg' GenType 5 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(-193, 163, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(-74, 208, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(-142, 289, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(-103, 352, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(35, 415, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(29, 330, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(94, 229, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(116, 145, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(152, 138, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(179, 241, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(162, 370, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(-163, 412, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(24, 205, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(-47, 73, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(113, 434, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(-234, 232, 40));

		// 'ERD_Tombsinker' GenType 6 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(-138, -886, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(14, -930, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(111, -965, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(74, -1074, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(2, -1087, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(-164, -977, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(-154, -1039, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(-206, -1061, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(-92, -1157, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(-72, -1110, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(28, -1189, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(82, -1143, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(130, -1153, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(125, -1047, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(-22, -1014, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(95, -914, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(-85, -982, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(-75, -1045, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(42, -982, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(107, -831, 40));

		// 'ERD_Bavon' GenType 7 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(750, 496, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(845, 529, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(893, 456, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(965, 530, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(983, 604, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1005, 737, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(889, 719, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(762, 688, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(751, 565, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1045, 834, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1030, 448, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1547, -279, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1657, -256, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1617, -338, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1570, -387, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1564, -453, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1677, -453, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1770, -339, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1785, -438, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1834, -355, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1875, -447, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1958, -442, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1907, -379, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1901, -553, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(2070, -478, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1462, -357, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1367, -320, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(2213, -562, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1212, -319, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1287, -347, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(2432, -554, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(2567, -461, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(2748, -309, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(2817, -171, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(2664, -417, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(2343, -561, 40));

		// 'ERD_Bubbe_Mage_Ice' GenType 8 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(746, -654, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(928, -645, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(1007, -477, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(878, -543, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(774, -419, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(707, -526, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(804, -760, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(949, -733, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(904, -398, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(901, -463, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(771, -306, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(923, -310, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(964, -248, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(893, -227, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(780, -174, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(815, -44, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(955, -114, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(1004, -38, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(919, 29, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(729, 115, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(925, 130, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(1000, 120, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(844, -134, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(687, -107, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(694, -243, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(1024, -371, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(701, -766, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(995, -663, 40));

		// 'ERD_Bagworm' GenType 9 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id8", "d_startower_76_1", Rectangle(830, -491, 9999));

		// 'ERD_Hogma_Warrior' GenType 10 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(-226, -621, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(-259, -429, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(-317, -516, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(-119, -342, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(22, -533, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(61, -663, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(279, -476, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(80, -319, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(-140, -230, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(-310, -323, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(6, -377, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(-110, -575, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(383, -492, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(9, -207, 40));

		// 'ERD_Hogma_Warrior' GenType 11 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2140, -99, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2281, 45, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2408, -46, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2468, -263, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2316, -347, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2213, -270, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2102, -348, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2218, -427, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2537, -372, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2659, -211, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2698, -63, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2677, 104, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2532, 72, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2351, 185, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2014, -61, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2105, -216, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2132, 109, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2459, 60, 40));

		// 'ERD_Zinutekas' GenType 12 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2429, 788, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2458, 881, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2577, 919, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2513, 811, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2562, 743, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2452, 955, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2619, 954, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2661, 794, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2641, 694, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2463, 684, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2416, 604, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2449, 529, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2499, 464, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2588, 392, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2544, 349, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2585, 830, 40));

		// 'Rootcrystal_02' GenType 17 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(112, -532, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-1164, 367, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-1429, -478, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-875, -473, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-952, -1119, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-6, -1032, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(908, -431, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(903, -150, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(801, 565, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-93, 228, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-231, 841, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-1106, 787, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-1272, 795, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(1626, -220, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(2199, -249, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(2443, 18, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(2090, 59, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(2388, -431, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(2652, -416, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(2528, 415, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(2516, 887, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-202, -323, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-261, -626, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-1164, -123, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-977, 128, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-1021, -554, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-1136, -1338, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(576, -588, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(740, -314, 200));
	}
}
