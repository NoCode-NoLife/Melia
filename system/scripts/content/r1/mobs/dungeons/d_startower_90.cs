//--- Melia Script -----------------------------------------------------------
// Astral Tower 12F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_startower_90'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DStartower90MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_startower_90", MonsterId.Nasleia, Properties("MHP", 632701, "MINPATK", 8637, "MAXPATK", 10517, "MINMATK", 8637, "MAXMATK", 10517, "DEF", 147392, "MDEF", 147392));
		AddPropertyOverrides("d_startower_90", MonsterId.Madlens, Properties("MHP", 634554, "MINPATK", 8661, "MAXPATK", 10546, "MINMATK", 8661, "MAXMATK", 10546, "DEF", 148502, "MDEF", 148502));
		AddPropertyOverrides("d_startower_90", MonsterId.Grob, Properties("MHP", 636437, "MINPATK", 8685, "MAXPATK", 10576, "MINMATK", 8685, "MAXMATK", 10576, "DEF", 149630, "MDEF", 149630));
		AddPropertyOverrides("d_startower_90", MonsterId.Hafter, Properties("MHP", 638350, "MINPATK", 8710, "MAXPATK", 10606, "MINMATK", 8710, "MAXMATK", 10606, "DEF", 150775, "MDEF", 150775));
		AddPropertyOverrides("d_startower_90", MonsterId.Boss_Riteris_Blue_Q1, Properties("MHP", 3342325, "MINPATK", 22011, "MAXPATK", 26805, "MINMATK", 22011, "MAXMATK", 26805, "DEF", 382885, "MDEF", 382885));
		AddPropertyOverrides("d_startower_90", MonsterId.Boss_Devilglove_Q3, Properties("MHP", 3352612, "MINPATK", 22075, "MAXPATK", 26884, "MINMATK", 22075, "MAXMATK", 26884, "DEF", 385859, "MDEF", 385859));
		AddPropertyOverrides("d_startower_90", MonsterId.Boss_Rambandgad_Q2, Properties("MHP", 3363048, "MINPATK", 22140, "MAXPATK", 26964, "MINMATK", 22140, "MAXMATK", 26964, "DEF", 388876, "MDEF", 388876));

		// Monster Spawners ---------------------------------

		AddSpawner("d_startower_90.Id1", MonsterId.Nasleia, min: 20, max: 26);
		AddSpawner("d_startower_90.Id2", MonsterId.Madlens, min: 24, max: 31);
		AddSpawner("d_startower_90.Id3", MonsterId.Grob, min: 26, max: 34);
		AddSpawner("d_startower_90.Id4", MonsterId.Hafter, min: 40, max: 53);
		AddSpawner("d_startower_90.Id5", MonsterId.Rootcrystal_03, min: 19, max: 25, respawn: TimeSpan.FromMilliseconds(10000));

		// Monster Spawn Points -----------------------------

		// 'Nasleia' GenType 34 Spawn Points
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(931, -876, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(651, -1458, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(920, -1537, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(786, -1193, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(350, -904, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(595, -957, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(166, -1576, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(336, -1308, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-42, -1002, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-383, -866, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-878, -877, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-567, -962, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-844, -1421, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-606, -1642, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-573, -1287, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-746, -1503, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(215, -617, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-5, -384, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(125, 247, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-223, 169, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(90, -165, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(-668, 116, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(906, 59, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(357, 247, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(242, -1441, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(157, -992, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(1419, 896, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(1863, 1016, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(1624, 668, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(1550, 1299, 25));
		AddSpawnPoint("d_startower_90.Id1", "d_startower_90", Rectangle(2005, 1342, 25));

		// 'Madlens' GenType 35 Spawn Points
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(95, -492, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(288, 2, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(809, 229, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(1059, -40, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-76, 166, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-1034, 322, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-1030, 99, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-1359, 192, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(405, 101, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(200, 744, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-41, 500, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-24, 734, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(61, 1129, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-606, 623, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-747, 855, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-901, 644, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-1542, 728, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-1265, 914, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-1394, 675, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-1506, 545, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-1001, 794, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(644, 1208, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-469, 1300, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-1072, 1306, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(1086, 139, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(232, 356, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-77, 1302, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(91, 1485, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-792, 1709, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(-688, 1223, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(1439, 753, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(1632, 938, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(1953, 810, 25));
		AddSpawnPoint("d_startower_90.Id2", "d_startower_90", Rectangle(1698, 1186, 25));

		// 'Grob' GenType 36 Spawn Points
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-854, 270, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-236, 275, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(186, 90, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(566, 273, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(846, 44, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(87, 759, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(307, 1873, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(62, 2058, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-54, 1817, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(158, 1964, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(59, 1606, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-438, 1867, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-487, 2180, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-640, 2040, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-607, 1695, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-283, 1810, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-874, 1767, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-616, 1361, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-1573, 1273, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-1175, 1238, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-902, 1227, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-967, 934, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-743, 543, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-1568, 903, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(-1260, 706, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(793, 1142, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(402, 1224, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(722, 1385, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(843, 1523, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(1080, 1209, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(1632, 1108, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(1997, 1162, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(1784, 820, 25));
		AddSpawnPoint("d_startower_90.Id3", "d_startower_90", Rectangle(1983, 648, 25));

		// 'Hafter' GenType 37 Spawn Points
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-583, 872, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(1320, -1301, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(1391, -1484, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(1489, -1292, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(1585, -898, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(1141, -943, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(745, -897, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(902, -1327, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(672, -1296, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(763, -1536, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(386, -1510, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(133, -1358, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(260, -1079, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-18, -922, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-260, -959, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-718, -871, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-796, -1240, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-844, -1587, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-619, -1411, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(45, -614, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(167, -405, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-208, -3, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-93, 338, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(0, 89, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(1310, -1460, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(565, 107, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(970, 291, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(824, -101, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-1243, 93, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-768, 209, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-940, 12, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(62, 888, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(61, 576, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-719, 712, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-888, 867, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-1307, 571, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-1422, 850, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-1383, 1261, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-790, 1271, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-742, 1563, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-612, 1874, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-393, 2075, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-435, 1669, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(-300, 1213, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(195, 1291, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(91, 1890, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(298, 2006, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(662, 1086, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(863, 1271, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(1348, 1289, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(1437, 1074, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(1780, 733, 25));
		AddSpawnPoint("d_startower_90.Id4", "d_startower_90", Rectangle(1834, 1253, 25));

		// 'Rootcrystal_03' GenType 41 Spawn Points
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(1419, -1385, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(775, -1424, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(315, -1465, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(-711, -1460, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(-460, -918, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(-1042, -921, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(129, -891, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(1065, -915, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(107, -180, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(100, 375, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(748, 162, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(-615, 182, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(-1141, 154, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(-1410, 707, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(-1577, 1260, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(-966, 1275, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(-770, 799, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(-249, 1304, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(-633, 1737, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(-308, 2050, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(231, 1999, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(403, 1263, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(903, 1179, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(1429, 867, 200));
		AddSpawnPoint("d_startower_90.Id5", "d_startower_90", Rectangle(1803, 1132, 200));
	}
}
