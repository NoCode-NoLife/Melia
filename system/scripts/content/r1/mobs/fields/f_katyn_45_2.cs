//--- Melia Script -----------------------------------------------------------
// Grynas Training Camp Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_katyn_45_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn452MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_katyn_45_2.Id1", MonsterId.Ridimed_Blue, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_45_2.Id2", MonsterId.Puragi_Red, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_45_2.Id3", MonsterId.Pappus_Kepa_Purple, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_45_2.Id4", MonsterId.Rootcrystal_04, 26, 34, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_katyn_45_2.Id5", MonsterId.Ridimed_Blue, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Ridimed_Blue' GenType 3 Spawn Points
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-867, 1213, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-299, 1111, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-29, 540, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-110, 1422, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-299, 1475, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(29, 593, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-235, 1348, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-525, 1220, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-191, 1228, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-9, 1656, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(296, 1623, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(372, 1831, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-205, 872, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-158, 672, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-140, 293, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(326, 521, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(502, 790, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(806, 622, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(992, 541, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(974, 272, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(838, -10, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(163, 100, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(473, 135, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(385, 187, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(807, 165, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1222, -233, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(634, -651, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(460, -724, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(170, -874, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(70, -967, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-141, -845, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-167, -560, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-146, -329, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-165, 88, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(93, -95, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-743, -867, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-772, -1019, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-599, -1034, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-479, -870, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-260, -752, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-310, -1109, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-230, -1347, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(134, -1703, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(-107, -1619, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(595, -1781, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(799, -1725, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(992, -1532, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1389, -1489, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1664, -1470, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1633, -1658, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1800, -1384, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1628, -1254, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1562, -1012, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1330, -810, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1388, -504, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1215, -509, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1045, -254, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1575, 645, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1280, 837, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1284, 1107, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1596, 1103, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1890, 939, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1773, 684, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1846, 457, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(2077, 567, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1813, 862, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1314, 646, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1145, 1459, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(965, 1703, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1105, 952, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1120, 10, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(272, -213, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(159, 667, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(355, 892, 30));
		AddSpawnPoint("f_katyn_45_2.Id1", "f_katyn_45_2", Rectangle(1050, 806, 30));

		// 'Puragi_Red' GenType 4 Spawn Points
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(-24, 1645, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(254, 1672, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(459, 1922, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(462, 1572, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(450, 1260, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(525, 829, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(486, 594, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(718, 747, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(824, 531, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1097, 408, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1379, 611, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1486, 812, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1202, 840, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1173, 1035, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1494, 1059, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1188, 1358, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(990, 1693, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(794, 1709, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1702, 1011, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1967, 1118, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1890, 859, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1649, 687, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1848, 500, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1907, 696, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(2192, 866, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(2118, 569, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1052, 650, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(388, 822, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(298, 598, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(-20, 1463, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1020, 882, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(967, 227, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1198, 148, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(963, -32, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1058, -267, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1174, -99, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(692, 96, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(412, 122, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(742, 596, 30));
		AddSpawnPoint("f_katyn_45_2.Id2", "f_katyn_45_2", Rectangle(1776, 813, 30));

		// 'Pappus_Kepa_Purple' GenType 5 Spawn Points
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-50, -311, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(284, -98, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(472, -151, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(742, -519, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(878, -277, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(461, 126, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(229, 151, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-190, -489, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-243, -790, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-513, -998, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-815, -880, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-781, -1043, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-559, -859, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-194, -1025, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(2, -960, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(357, -796, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(532, -731, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(199, -1052, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-83, -1599, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(333, -1753, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-247, -1436, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(631, -1769, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(545, -1480, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(637, -1341, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(634, -1580, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(736, -1465, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(823, -1380, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(927, -1612, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1071, -1504, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1334, -1453, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1449, -1005, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1712, -1087, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1672, -1233, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1623, -1436, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1501, -768, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1281, -598, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1380, -432, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1178, -463, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1286, -135, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1031, -39, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(928, 76, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1026, -109, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1145, 258, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(979, 232, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1049, 412, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(163, -145, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-198, -191, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-185, 107, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-149, 318, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-245, 253, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-159, 424, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(134, 173, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(934, -89, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-37, 599, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-163, 660, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-180, -350, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-9, -747, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(210, -877, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-373, -797, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-264, -1264, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(-136, 1249, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1278, -308, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1234, -10, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1096, -227, 30));
		AddSpawnPoint("f_katyn_45_2.Id3", "f_katyn_45_2", Rectangle(1184, 88, 30));

		// 'Rootcrystal_04' GenType 9 Spawn Points
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(-318, 1246, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(-733, 1267, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(-392, 1641, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(-149, 1629, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(346, 1715, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(660, 1694, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1086, 1581, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1242, 1043, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1178, 757, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1817, 744, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1563, 719, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(2121, 737, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(952, 629, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1068, 197, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1233, -42, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1109, -364, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1369, -718, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1558, -1332, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(1028, -1443, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(256, -1757, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(558, -1398, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(-171, -1534, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(-93, -956, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(-629, -934, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(0, -575, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(216, -93, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(-208, 287, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(580, 88, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(640, 702, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(-122, 569, 50));
		AddSpawnPoint("f_katyn_45_2.Id4", "f_katyn_45_2", Rectangle(-216, 772, 50));

		// 'Ridimed_Blue' GenType 13 Spawn Points
		AddSpawnPoint("f_katyn_45_2.Id5", "f_katyn_45_2", Rectangle(253, -114, 9999));
	}
}
