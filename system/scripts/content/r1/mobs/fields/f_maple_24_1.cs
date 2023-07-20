//--- Melia Script -----------------------------------------------------------
// Central Parias Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_maple_24_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FMaple241MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_maple_24_1", MonsterId.Grievous_Wheel_Red, Properties("MHP", 730917, "MINPATK", 9900, "MAXPATK", 12070, "MINMATK", 9900, "MAXMATK", 12070, "DEF", 213226, "MDEF", 213226));
		AddPropertyOverrides("f_maple_24_1", MonsterId.Rudas_Elavine, Properties("MHP", 733610, "MINPATK", 9935, "MAXPATK", 12112, "MINMATK", 9935, "MAXMATK", 12112, "DEF", 215150, "MDEF", 215150));
		AddPropertyOverrides("f_maple_24_1", MonsterId.Delione, Properties("MHP", 736341, "MINPATK", 9970, "MAXPATK", 12155, "MINMATK", 9970, "MAXMATK", 12155, "DEF", 217102, "MDEF", 217102));
		AddPropertyOverrides("f_maple_24_1", MonsterId.Cloverin, Properties("MHP", 739110, "MINPATK", 10005, "MAXPATK", 12199, "MINMATK", 10005, "MAXMATK", 12199, "DEF", 219081, "MDEF", 219081));

		// Monster Spawners ---------------------------------

		AddSpawner("f_maple_24_1.Id1", MonsterId.Grievous_Wheel_Red, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_24_1.Id2", MonsterId.Rudas_Elavine, 60, 80, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_24_1.Id3", MonsterId.Delione, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_24_1.Id4", MonsterId.Cloverin, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_24_1.Id5", MonsterId.Rootcrystal_01, 19, 25, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_maple_24_1.Id6", MonsterId.Cloverin, 15, 20, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);
		AddSpawner("f_maple_24_1.Id7", MonsterId.Delione, 12, 15, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);
		AddSpawner("f_maple_24_1.Id8", MonsterId.Rudas_Elavine, 9, 12, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Grievous_Wheel_Red' GenType 1 Spawn Points
		AddSpawnPoint("f_maple_24_1.Id1", "f_maple_24_1", Rectangle(-1335, -569, 20));
		AddSpawnPoint("f_maple_24_1.Id1", "f_maple_24_1", Rectangle(-1290, -753, 20));
		AddSpawnPoint("f_maple_24_1.Id1", "f_maple_24_1", Rectangle(-1225, -655, 20));
		AddSpawnPoint("f_maple_24_1.Id1", "f_maple_24_1", Rectangle(-1093, -618, 20));
		AddSpawnPoint("f_maple_24_1.Id1", "f_maple_24_1", Rectangle(-1142, -776, 20));
		AddSpawnPoint("f_maple_24_1.Id1", "f_maple_24_1", Rectangle(-1126, -911, 20));
		AddSpawnPoint("f_maple_24_1.Id1", "f_maple_24_1", Rectangle(-1037, -867, 20));
		AddSpawnPoint("f_maple_24_1.Id1", "f_maple_24_1", Rectangle(-983, -942, 20));
		AddSpawnPoint("f_maple_24_1.Id1", "f_maple_24_1", Rectangle(-840, -892, 20));
		AddSpawnPoint("f_maple_24_1.Id1", "f_maple_24_1", Rectangle(-1097, -495, 20));
		AddSpawnPoint("f_maple_24_1.Id1", "f_maple_24_1", Rectangle(569, 1279, 20));
		AddSpawnPoint("f_maple_24_1.Id1", "f_maple_24_1", Rectangle(439, 1382, 20));
		AddSpawnPoint("f_maple_24_1.Id1", "f_maple_24_1", Rectangle(588, 1502, 20));
		AddSpawnPoint("f_maple_24_1.Id1", "f_maple_24_1", Rectangle(542, 1582, 20));
		AddSpawnPoint("f_maple_24_1.Id1", "f_maple_24_1", Rectangle(599, 1401, 20));
		AddSpawnPoint("f_maple_24_1.Id1", "f_maple_24_1", Rectangle(704, 1325, 20));
		AddSpawnPoint("f_maple_24_1.Id1", "f_maple_24_1", Rectangle(799, 1346, 20));
		AddSpawnPoint("f_maple_24_1.Id1", "f_maple_24_1", Rectangle(925, 1288, 20));
		AddSpawnPoint("f_maple_24_1.Id1", "f_maple_24_1", Rectangle(1030, 1256, 20));
		AddSpawnPoint("f_maple_24_1.Id1", "f_maple_24_1", Rectangle(1107, 1339, 20));

		// 'Rudas_Elavine' GenType 2 Spawn Points
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-1268, -605, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-1148, -721, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-1184, -907, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-900, -904, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-572, -859, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-489, -1037, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-1143, 797, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-1297, 680, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-172, -972, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-37, -859, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-1045, 599, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(129, -915, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(270, -917, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-770, 1269, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(470, -831, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-721, 1166, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(465, -949, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(594, -898, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(765, -916, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-445, 921, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1057, -838, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1128, -796, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1160, -523, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1149, -331, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1300, -483, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1457, -392, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1495, -180, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1729, -181, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1780, -229, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1355, -104, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1219, -91, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1130, -110, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-355, 783, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1238, 53, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1199, 170, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1205, 307, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1267, 420, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1160, 392, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1250, 303, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1271, 561, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1229, 698, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1208, 545, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1054, 517, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(996, 609, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1217, 823, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1271, 728, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1087, 790, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1220, 1052, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1150, 1210, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1338, 1275, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(1039, 1379, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(677, 1281, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(558, 1445, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(863, 1298, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(817, 684, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(722, 664, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(627, 773, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-139, 396, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-207, 581, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(255, 663, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(242, 538, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(137, 593, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(26, 464, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(135, 359, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(283, 285, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(376, 300, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-857, -173, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-1006, -8, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-773, -57, 20));
		AddSpawnPoint("f_maple_24_1.Id2", "f_maple_24_1", Rectangle(-702, 68, 20));

		// 'Delione' GenType 3 Spawn Points
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(970, -800, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(1115, -726, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(827, -860, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(561, -821, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(494, -696, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(367, -748, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(359, -855, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(439, -997, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-1, -1025, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(15, -909, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-91, -948, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-168, -849, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-275, -916, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-345, -894, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-301, -1017, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-497, -958, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-589, -908, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-934, -148, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-827, -78, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-689, -132, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-854, -251, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-988, -72, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-1032, 107, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-954, 184, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-838, 71, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-750, 22, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-921, 64, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-791, 193, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-1006, 342, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-966, 484, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-1067, 498, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-956, 624, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-1132, 693, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-1203, 661, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-1225, 865, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-1301, 865, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-1396, 735, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-1431, 672, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-1128, 862, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-1258, 760, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-643, 261, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-402, 383, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-296, 499, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-309, 388, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-156, 491, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-412, 675, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-233, 729, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-244, 848, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(-27, 909, 20));
		AddSpawnPoint("f_maple_24_1.Id3", "f_maple_24_1", Rectangle(12, 778, 20));

		// 'Cloverin' GenType 4 Spawn Points
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(-885, 1180, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(-865, 1279, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(-775, 1215, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(-770, 1121, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(1243, 750, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(1062, 695, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(-726, 1361, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(-702, 1418, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(-590, 1116, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(1025, 565, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(1184, 327, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(-371, 887, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(-444, 652, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(-291, 731, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(-204, 429, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(-48, 317, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(-115, 254, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(4, 256, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(106, 406, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(222, 326, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(267, 460, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(29, 709, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(49, 603, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(38, 884, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(-106, 908, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(-14, 1034, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(342, 693, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(149, 701, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(473, 729, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(1268, -417, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(1155, -397, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(1140, -210, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(1420, -129, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(1415, -196, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(1240, 453, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(1714, -142, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(1288, -36, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(1185, -24, 20));
		AddSpawnPoint("f_maple_24_1.Id4", "f_maple_24_1", Rectangle(1211, 893, 20));

		// 'Rootcrystal_01' GenType 9 Spawn Points
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(-974, 594, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(-1272, 801, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(-955, 242, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(-810, -49, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(-943, -375, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(-1130, -891, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(-730, -878, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(-336, -943, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(68, -940, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(485, -852, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(902, -858, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(1160, -571, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(1431, -290, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(1238, -56, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(1223, 356, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(1183, 723, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(1221, 1129, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(912, 1341, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(578, 1386, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(822, 601, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(419, 701, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(81, 442, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(-8, 821, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(-454, 965, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(-721, 1231, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(416, 232, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(567, -100, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(-297, 546, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(-533, 258, 200));
		AddSpawnPoint("f_maple_24_1.Id5", "f_maple_24_1", Rectangle(-1213, -586, 200));

		// 'Cloverin' GenType 26 Spawn Points
		AddSpawnPoint("f_maple_24_1.Id6", "f_maple_24_1", Rectangle(-548, -985, 20));
		AddSpawnPoint("f_maple_24_1.Id6", "f_maple_24_1", Rectangle(-525, -892, 20));
		AddSpawnPoint("f_maple_24_1.Id6", "f_maple_24_1", Rectangle(-509, -807, 20));
		AddSpawnPoint("f_maple_24_1.Id6", "f_maple_24_1", Rectangle(-436, -996, 20));
		AddSpawnPoint("f_maple_24_1.Id6", "f_maple_24_1", Rectangle(-432, -907, 20));
		AddSpawnPoint("f_maple_24_1.Id6", "f_maple_24_1", Rectangle(-446, -1076, 20));
		AddSpawnPoint("f_maple_24_1.Id6", "f_maple_24_1", Rectangle(-372, -1035, 20));
		AddSpawnPoint("f_maple_24_1.Id6", "f_maple_24_1", Rectangle(-341, -964, 20));
		AddSpawnPoint("f_maple_24_1.Id6", "f_maple_24_1", Rectangle(-317, -835, 20));
		AddSpawnPoint("f_maple_24_1.Id6", "f_maple_24_1", Rectangle(-290, -970, 20));
		AddSpawnPoint("f_maple_24_1.Id6", "f_maple_24_1", Rectangle(-215, -1000, 20));
		AddSpawnPoint("f_maple_24_1.Id6", "f_maple_24_1", Rectangle(-176, -901, 20));
		AddSpawnPoint("f_maple_24_1.Id6", "f_maple_24_1", Rectangle(-124, -1038, 20));
		AddSpawnPoint("f_maple_24_1.Id6", "f_maple_24_1", Rectangle(-92, -814, 20));
		AddSpawnPoint("f_maple_24_1.Id6", "f_maple_24_1", Rectangle(-96, -1002, 20));
		AddSpawnPoint("f_maple_24_1.Id6", "f_maple_24_1", Rectangle(-49, -917, 20));
		AddSpawnPoint("f_maple_24_1.Id6", "f_maple_24_1", Rectangle(-23, -1056, 20));
		AddSpawnPoint("f_maple_24_1.Id6", "f_maple_24_1", Rectangle(38, -974, 20));
		AddSpawnPoint("f_maple_24_1.Id6", "f_maple_24_1", Rectangle(65, -870, 20));
		AddSpawnPoint("f_maple_24_1.Id6", "f_maple_24_1", Rectangle(-108, -887, 20));

		// 'Delione' GenType 27 Spawn Points
		AddSpawnPoint("f_maple_24_1.Id7", "f_maple_24_1", Rectangle(204, -946, 20));
		AddSpawnPoint("f_maple_24_1.Id7", "f_maple_24_1", Rectangle(254, -875, 20));
		AddSpawnPoint("f_maple_24_1.Id7", "f_maple_24_1", Rectangle(276, -970, 20));
		AddSpawnPoint("f_maple_24_1.Id7", "f_maple_24_1", Rectangle(331, -1001, 20));
		AddSpawnPoint("f_maple_24_1.Id7", "f_maple_24_1", Rectangle(343, -919, 20));
		AddSpawnPoint("f_maple_24_1.Id7", "f_maple_24_1", Rectangle(405, -890, 20));
		AddSpawnPoint("f_maple_24_1.Id7", "f_maple_24_1", Rectangle(425, -802, 20));
		AddSpawnPoint("f_maple_24_1.Id7", "f_maple_24_1", Rectangle(411, -678, 20));
		AddSpawnPoint("f_maple_24_1.Id7", "f_maple_24_1", Rectangle(526, -740, 20));
		AddSpawnPoint("f_maple_24_1.Id7", "f_maple_24_1", Rectangle(509, -808, 20));
		AddSpawnPoint("f_maple_24_1.Id7", "f_maple_24_1", Rectangle(535, -951, 20));
		AddSpawnPoint("f_maple_24_1.Id7", "f_maple_24_1", Rectangle(558, -892, 20));
		AddSpawnPoint("f_maple_24_1.Id7", "f_maple_24_1", Rectangle(645, -922, 20));
		AddSpawnPoint("f_maple_24_1.Id7", "f_maple_24_1", Rectangle(628, -826, 20));
		AddSpawnPoint("f_maple_24_1.Id7", "f_maple_24_1", Rectangle(739, -856, 20));

		// 'Rudas_Elavine' GenType 28 Spawn Points
		AddSpawnPoint("f_maple_24_1.Id8", "f_maple_24_1", Rectangle(878, -890, 20));
		AddSpawnPoint("f_maple_24_1.Id8", "f_maple_24_1", Rectangle(886, -807, 20));
		AddSpawnPoint("f_maple_24_1.Id8", "f_maple_24_1", Rectangle(929, -850, 20));
		AddSpawnPoint("f_maple_24_1.Id8", "f_maple_24_1", Rectangle(988, -841, 20));
		AddSpawnPoint("f_maple_24_1.Id8", "f_maple_24_1", Rectangle(1028, -777, 20));
		AddSpawnPoint("f_maple_24_1.Id8", "f_maple_24_1", Rectangle(1087, -898, 20));
		AddSpawnPoint("f_maple_24_1.Id8", "f_maple_24_1", Rectangle(1136, -847, 20));
		AddSpawnPoint("f_maple_24_1.Id8", "f_maple_24_1", Rectangle(1092, -766, 20));
		AddSpawnPoint("f_maple_24_1.Id8", "f_maple_24_1", Rectangle(1096, -809, 20));
		AddSpawnPoint("f_maple_24_1.Id8", "f_maple_24_1", Rectangle(716, -884, 20));
		AddSpawnPoint("f_maple_24_1.Id8", "f_maple_24_1", Rectangle(424, -954, 20));
		AddSpawnPoint("f_maple_24_1.Id8", "f_maple_24_1", Rectangle(679, -853, 20));
	}
}
