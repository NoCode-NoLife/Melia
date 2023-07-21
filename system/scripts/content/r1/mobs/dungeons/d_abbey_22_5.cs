//--- Melia Script -----------------------------------------------------------
// Narvas Temple Annex Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_abbey_22_5'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DAbbey225MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_abbey_22_5.Id1", MonsterId.Rootcrystal_01, 16, 21, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_5.Id2", MonsterId.Hohen_Orben_Black, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_5.Id3", MonsterId.Harugal_Black, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_5.Id4", MonsterId.Drooper, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_5.Id5", MonsterId.StonOrca_Red, 128, 170, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_5.Id6", MonsterId.Hohen_Orben_Black, 5, 6, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_5.Id7", MonsterId.Drooper, 2, 2, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_5.Id8", MonsterId.Harugal_Black, 3, 4, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_5.Id9", MonsterId.Harugal_Black, 3, 3, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("d_abbey_22_5.Id10", MonsterId.Drooper, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 28 Spawn Points
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(-371, 794, 10));
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(304, 795, 10));
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(1022, 710, 10));
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(1300, 846, 10));
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(1067, 1363, 10));
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(1783, 796, 10));
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(797, -39, 10));
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(1289, -39, 10));
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(809, -900, 10));
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(1266, -957, 10));
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(1, -73, 10));
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(-836, -28, 10));
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(-1286, -38, 10));
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(-1888, -228, 10));
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(-1553, -789, 10));
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(-1176, -836, 10));
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(-876, -846, 10));
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(-1776, 931, 10));
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(-1164, 884, 10));
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(-1453, 1738, 10));
		AddSpawnPoint("d_abbey_22_5.Id1", "d_abbey_22_5", Rectangle(-949, 1636, 10));

		// 'Hohen_Orben_Black' GenType 29 Spawn Points
		AddSpawnPoint("d_abbey_22_5.Id2", "d_abbey_22_5", Rectangle(-270, 798, 20));
		AddSpawnPoint("d_abbey_22_5.Id2", "d_abbey_22_5", Rectangle(28, 949, 20));
		AddSpawnPoint("d_abbey_22_5.Id2", "d_abbey_22_5", Rectangle(328, 805, 20));
		AddSpawnPoint("d_abbey_22_5.Id2", "d_abbey_22_5", Rectangle(19, 561, 20));
		AddSpawnPoint("d_abbey_22_5.Id2", "d_abbey_22_5", Rectangle(-1261, 194, 20));
		AddSpawnPoint("d_abbey_22_5.Id2", "d_abbey_22_5", Rectangle(-1049, 191, 20));
		AddSpawnPoint("d_abbey_22_5.Id2", "d_abbey_22_5", Rectangle(-860, 190, 20));
		AddSpawnPoint("d_abbey_22_5.Id2", "d_abbey_22_5", Rectangle(1087, 1159, 20));
		AddSpawnPoint("d_abbey_22_5.Id2", "d_abbey_22_5", Rectangle(981, 1413, 20));
		AddSpawnPoint("d_abbey_22_5.Id2", "d_abbey_22_5", Rectangle(1175, 1398, 20));
		AddSpawnPoint("d_abbey_22_5.Id2", "d_abbey_22_5", Rectangle(1804, -81, 20));
		AddSpawnPoint("d_abbey_22_5.Id2", "d_abbey_22_5", Rectangle(984, -117, 20));
		AddSpawnPoint("d_abbey_22_5.Id2", "d_abbey_22_5", Rectangle(1178, -113, 20));
		AddSpawnPoint("d_abbey_22_5.Id2", "d_abbey_22_5", Rectangle(944, -913, 20));
		AddSpawnPoint("d_abbey_22_5.Id2", "d_abbey_22_5", Rectangle(1196, -926, 20));
		AddSpawnPoint("d_abbey_22_5.Id2", "d_abbey_22_5", Rectangle(-1625, -923, 20));
		AddSpawnPoint("d_abbey_22_5.Id2", "d_abbey_22_5", Rectangle(-1319, -819, 20));
		AddSpawnPoint("d_abbey_22_5.Id2", "d_abbey_22_5", Rectangle(-837, 790, 20));
		AddSpawnPoint("d_abbey_22_5.Id2", "d_abbey_22_5", Rectangle(1808, 53, 20));
		AddSpawnPoint("d_abbey_22_5.Id2", "d_abbey_22_5", Rectangle(-1715, -328, 20));

		// 'Harugal_Black' GenType 30 Spawn Points
		AddSpawnPoint("d_abbey_22_5.Id3", "d_abbey_22_5", Rectangle(-229, 104, 20));
		AddSpawnPoint("d_abbey_22_5.Id3", "d_abbey_22_5", Rectangle(-162, -184, 20));
		AddSpawnPoint("d_abbey_22_5.Id3", "d_abbey_22_5", Rectangle(254, 106, 20));
		AddSpawnPoint("d_abbey_22_5.Id3", "d_abbey_22_5", Rectangle(259, -152, 20));
		AddSpawnPoint("d_abbey_22_5.Id3", "d_abbey_22_5", Rectangle(-1261, -268, 20));
		AddSpawnPoint("d_abbey_22_5.Id3", "d_abbey_22_5", Rectangle(-1047, -270, 20));
		AddSpawnPoint("d_abbey_22_5.Id3", "d_abbey_22_5", Rectangle(-869, -264, 20));
		AddSpawnPoint("d_abbey_22_5.Id3", "d_abbey_22_5", Rectangle(-955, -964, 20));
		AddSpawnPoint("d_abbey_22_5.Id3", "d_abbey_22_5", Rectangle(-809, -703, 20));
		AddSpawnPoint("d_abbey_22_5.Id3", "d_abbey_22_5", Rectangle(783, -695, 20));
		AddSpawnPoint("d_abbey_22_5.Id3", "d_abbey_22_5", Rectangle(1347, -685, 20));
		AddSpawnPoint("d_abbey_22_5.Id3", "d_abbey_22_5", Rectangle(1340, -1106, 20));
		AddSpawnPoint("d_abbey_22_5.Id3", "d_abbey_22_5", Rectangle(783, -1090, 20));
		AddSpawnPoint("d_abbey_22_5.Id3", "d_abbey_22_5", Rectangle(986, 144, 20));
		AddSpawnPoint("d_abbey_22_5.Id3", "d_abbey_22_5", Rectangle(1178, 151, 20));
		AddSpawnPoint("d_abbey_22_5.Id3", "d_abbey_22_5", Rectangle(997, 709, 20));
		AddSpawnPoint("d_abbey_22_5.Id3", "d_abbey_22_5", Rectangle(1210, 714, 20));
		AddSpawnPoint("d_abbey_22_5.Id3", "d_abbey_22_5", Rectangle(1214, 905, 20));
		AddSpawnPoint("d_abbey_22_5.Id3", "d_abbey_22_5", Rectangle(998, 906, 20));
		AddSpawnPoint("d_abbey_22_5.Id3", "d_abbey_22_5", Rectangle(-1936, -73, 20));

		// 'Drooper' GenType 31 Spawn Points
		AddSpawnPoint("d_abbey_22_5.Id4", "d_abbey_22_5", Rectangle(-1738, 767, 20));
		AddSpawnPoint("d_abbey_22_5.Id4", "d_abbey_22_5", Rectangle(-1735, 1047, 20));
		AddSpawnPoint("d_abbey_22_5.Id4", "d_abbey_22_5", Rectangle(-1323, 719, 20));
		AddSpawnPoint("d_abbey_22_5.Id4", "d_abbey_22_5", Rectangle(-1183, 723, 20));
		AddSpawnPoint("d_abbey_22_5.Id4", "d_abbey_22_5", Rectangle(-1058, 721, 20));
		AddSpawnPoint("d_abbey_22_5.Id4", "d_abbey_22_5", Rectangle(-1446, 1571, 20));
		AddSpawnPoint("d_abbey_22_5.Id4", "d_abbey_22_5", Rectangle(-1466, 1842, 20));
		AddSpawnPoint("d_abbey_22_5.Id4", "d_abbey_22_5", Rectangle(-992, 1567, 20));
		AddSpawnPoint("d_abbey_22_5.Id4", "d_abbey_22_5", Rectangle(-946, 1844, 20));
		AddSpawnPoint("d_abbey_22_5.Id4", "d_abbey_22_5", Rectangle(-1952, -292, 20));
		AddSpawnPoint("d_abbey_22_5.Id4", "d_abbey_22_5", Rectangle(-1718, -44, 20));
		AddSpawnPoint("d_abbey_22_5.Id4", "d_abbey_22_5", Rectangle(-1947, -565, 20));
		AddSpawnPoint("d_abbey_22_5.Id4", "d_abbey_22_5", Rectangle(-1789, -702, 20));
		AddSpawnPoint("d_abbey_22_5.Id4", "d_abbey_22_5", Rectangle(-578, -17, 20));
		AddSpawnPoint("d_abbey_22_5.Id4", "d_abbey_22_5", Rectangle(597, -23, 20));
		AddSpawnPoint("d_abbey_22_5.Id4", "d_abbey_22_5", Rectangle(1479, -6, 20));
		AddSpawnPoint("d_abbey_22_5.Id4", "d_abbey_22_5", Rectangle(1074, -434, 20));
		AddSpawnPoint("d_abbey_22_5.Id4", "d_abbey_22_5", Rectangle(-1224, 1462, 20));
		AddSpawnPoint("d_abbey_22_5.Id4", "d_abbey_22_5", Rectangle(-1223, 1725, 20));
		AddSpawnPoint("d_abbey_22_5.Id4", "d_abbey_22_5", Rectangle(1076, -691, 20));

		// 'StonOrca_Red' GenType 32 Spawn Points
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-334, 965, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-245, 848, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-338, 774, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-328, 692, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-287, 564, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-134, 539, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-126, 713, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(24, 672, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(150, 589, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(259, 559, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(379, 588, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(406, 733, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(255, 717, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(209, 870, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(375, 916, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(170, 999, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(325, 1129, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-97, 898, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-165, 1086, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(625, 796, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(823, 787, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1004, 563, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1150, 893, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1051, 1065, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1163, 997, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1227, 601, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1314, 699, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(903, 719, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1034, 1089, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1106, 1278, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(994, 1298, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(915, 1450, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1069, 1448, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1150, 1531, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1204, 1468, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1262, 1318, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1205, 1269, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1474, 779, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1555, 826, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-580, 819, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-775, 882, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-884, 840, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-835, 1012, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-980, 848, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1003, 1056, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-918, 1031, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1080, 1059, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1208, 1014, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1194, 1140, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1326, 914, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1282, 815, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1051, 931, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1109, 775, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1655, 785, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1605, 893, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1738, 828, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1699, 966, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1623, 1047, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1866, 1023, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1870, 844, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1887, 746, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1180, 1341, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1343, 1446, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1461, 1442, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1549, 1553, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1553, 1716, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1639, 1605, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1408, 1655, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1311, 1560, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1253, 1630, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1347, 1720, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1230, 1843, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1101, 1560, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1030, 1458, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-894, 1439, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1062, 1641, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-861, 1538, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-837, 1759, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-956, 1772, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-896, 1936, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1096, 1884, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-110, 103, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(26, 148, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(72, 24, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(136, 133, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(202, 25, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(127, -121, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-94, -101, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-207, 13, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-268, -105, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-351, 13, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-130, -272, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-8, -260, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(128, -273, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(311, -192, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(347, 5, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(22, -198, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(698, 14, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(914, 39, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(897, -191, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1005, -7, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1118, -168, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1174, 6, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1269, -141, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1275, 128, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1058, 108, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1660, -115, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1710, 155, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1704, -28, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1932, 90, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1888, -75, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1790, -179, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1687, -201, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1587, 12, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(930, -712, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(830, -867, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(659, -692, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(637, -900, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(809, -987, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(638, -1074, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(935, -1093, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1035, -896, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1079, -1091, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1214, -1006, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1293, -1196, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1440, -1152, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1473, -977, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1308, -933, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1504, -751, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1220, -811, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1447, -683, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1032, -792, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-893, -130, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-925, 15, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1031, -155, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1062, -26, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1186, -155, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1198, -6, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-941, -56, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1524, 7, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1522, -66, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1687, -200, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1839, -144, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1810, -281, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1802, -47, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-2002, -222, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1879, -350, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1913, -683, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1821, -645, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-2025, -499, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1931, -488, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1669, -752, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1546, -704, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1437, -705, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1646, -842, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1394, -806, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1302, -922, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1484, -809, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1339, -704, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1015, -927, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-1021, -796, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-969, -865, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-806, -952, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-759, -778, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(-974, -701, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1070, -964, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(1369, -818, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(773, -878, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(995, -1001, 40));
		AddSpawnPoint("d_abbey_22_5.Id5", "d_abbey_22_5", Rectangle(781, -1084, 40));

		// 'Hohen_Orben_Black' GenType 34 Spawn Points
		AddSpawnPoint("d_abbey_22_5.Id6", "d_abbey_22_5", Rectangle(269, 774, 20));
		AddSpawnPoint("d_abbey_22_5.Id6", "d_abbey_22_5", Rectangle(-129, 773, 20));
		AddSpawnPoint("d_abbey_22_5.Id6", "d_abbey_22_5", Rectangle(71, 539, 20));
		AddSpawnPoint("d_abbey_22_5.Id6", "d_abbey_22_5", Rectangle(134, 905, 20));
		AddSpawnPoint("d_abbey_22_5.Id6", "d_abbey_22_5", Rectangle(20, 987, 20));
		AddSpawnPoint("d_abbey_22_5.Id6", "d_abbey_22_5", Rectangle(66, 735, 20));

		// 'Drooper' GenType 35 Spawn Points
		AddSpawnPoint("d_abbey_22_5.Id7", "d_abbey_22_5", Rectangle(-1218, 1607, 20));
		AddSpawnPoint("d_abbey_22_5.Id7", "d_abbey_22_5", Rectangle(-1011, 1767, 20));

		// 'Harugal_Black' GenType 36 Spawn Points
		AddSpawnPoint("d_abbey_22_5.Id8", "d_abbey_22_5", Rectangle(957, -922, 20));
		AddSpawnPoint("d_abbey_22_5.Id8", "d_abbey_22_5", Rectangle(1203, -929, 20));
		AddSpawnPoint("d_abbey_22_5.Id8", "d_abbey_22_5", Rectangle(38, -16, 20));
		AddSpawnPoint("d_abbey_22_5.Id8", "d_abbey_22_5", Rectangle(1220, -14, 20));

		// 'Harugal_Black' GenType 37 Spawn Points
		AddSpawnPoint("d_abbey_22_5.Id9", "d_abbey_22_5", Rectangle(1124, -931, 20));
		AddSpawnPoint("d_abbey_22_5.Id9", "d_abbey_22_5", Rectangle(1064, -40, 20));
		AddSpawnPoint("d_abbey_22_5.Id9", "d_abbey_22_5", Rectangle(121, -95, 20));

		// 'Drooper' GenType 38 Spawn Points
		AddSpawnPoint("d_abbey_22_5.Id10", "d_abbey_22_5", Rectangle(-1556, -788, 20));
		AddSpawnPoint("d_abbey_22_5.Id10", "d_abbey_22_5", Rectangle(-1344, -912, 20));
		AddSpawnPoint("d_abbey_22_5.Id10", "d_abbey_22_5", Rectangle(-1442, -709, 20));
		AddSpawnPoint("d_abbey_22_5.Id10", "d_abbey_22_5", Rectangle(-1368, -751, 20));
	}
}
