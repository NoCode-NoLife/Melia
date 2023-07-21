//--- Melia Script -----------------------------------------------------------
// Outer Wall District 14 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_castle_96'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle96MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_castle_96", MonsterId.Gigglecat, Properties("MHP", 701867, "MINPATK", 9526, "MAXPATK", 11610, "MINMATK", 9526, "MAXMATK", 11610, "DEF", 192465, "MDEF", 192465));
		AddPropertyOverrides("f_castle_96", MonsterId.Ghoscat, Properties("MHP", 704041, "MINPATK", 9554, "MAXPATK", 11645, "MINMATK", 9554, "MAXMATK", 11645, "DEF", 194019, "MDEF", 194019));
		AddPropertyOverrides("f_castle_96", MonsterId.ArchGargoyle, Properties("MHP", 706264, "MINPATK", 9583, "MAXPATK", 11680, "MINMATK", 9583, "MAXMATK", 11680, "DEF", 195607, "MDEF", 195607));

		// Monster Spawners ---------------------------------

		AddSpawner("f_castle_96.Id1", MonsterId.Gigglecat, min: 68, max: 90);
		AddSpawner("f_castle_96.Id2", MonsterId.Ghoscat, min: 38, max: 50);
		AddSpawner("f_castle_96.Id3", MonsterId.ArchGargoyle, min: 15, max: 20);
		AddSpawner("f_castle_96.Id4", MonsterId.Ghoscat, min: 16, max: 21, respawn: TimeSpan.FromMilliseconds(40000));
		AddSpawner("f_castle_96.Id5", MonsterId.Rootcrystal_04, min: 23, max: 30, respawn: TimeSpan.FromMilliseconds(20000));

		// Monster Spawn Points -----------------------------

		// 'Gigglecat' GenType 1 Spawn Points
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-1349, 781, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-1307, 955, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-1461, 770, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-1465, 648, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-1222, 714, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-1250, 342, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-1260, 255, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-1215, 60, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-1172, -150, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-1411, -170, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-1470, -27, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-1134, 2, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-963, -39, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-897, -2, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-568, -49, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-531, -14, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-70, -116, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-414, 349, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-189, 433, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-164, 233, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(117, -101, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(268, -99, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(267, 318, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(145, 253, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(62, 608, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(181, 605, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(321, 438, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-1058, -663, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-1062, -794, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-1005, -961, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-885, -941, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-812, -821, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-747, -793, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-667, -762, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-658, -784, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-438, -8, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(61, -1550, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(1084, -95, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(126, -1407, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-103, -1404, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-158, -1270, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-114, -1610, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-136, -1693, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(0, -1702, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(76, -1455, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(115, -1608, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(104, 1111, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-130, 1139, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(-67, 1249, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(190, 916, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(377, 1001, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(356, 803, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(669, 1164, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(872, 1192, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(1276, 1116, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(1400, 943, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(1261, 883, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(1528, 1127, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(1511, 296, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(1335, 208, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(1070, 92, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(941, 371, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(832, 130, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(956, -21, 60));
		AddSpawnPoint("f_castle_96.Id1", "f_castle_96", Rectangle(560, -20, 60));

		// 'Ghoscat' GenType 2 Spawn Points
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-53, -1713, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(144, -1503, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(131, -1700, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-82, -1486, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-75, -1899, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-155, -1119, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-446, 102, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(860, 79, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(53, -40, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-541, -782, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(54, -312, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(18, -56, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(283, 175, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-70, 151, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-381, 142, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-357, -105, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(873, 286, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(1062, -27, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-139, 370, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(253, 542, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(60, 957, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-37, 1135, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(251, 965, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(545, 1167, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(1053, 1150, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(1327, 1006, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(1336, 1208, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(1463, 1271, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(1505, 971, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(1594, 268, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(1577, 42, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(1370, 78, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(1208, -145, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-929, -861, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-875, -748, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-1195, -746, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-1234, -968, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-1287, -872, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-1210, -10, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-1318, -128, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-1389, 56, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-1188, 566, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-1402, 463, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-1431, 703, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-1295, 688, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-1345, 857, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(-1169, 683, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(873, -27, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(62, 1266, 20));
		AddSpawnPoint("f_castle_96.Id2", "f_castle_96", Rectangle(763, 1154, 20));

		// 'ArchGargoyle' GenType 3 Spawn Points
		AddSpawnPoint("f_castle_96.Id3", "f_castle_96", Rectangle(-1201, -867, 40));
		AddSpawnPoint("f_castle_96.Id3", "f_castle_96", Rectangle(-136, 450, 40));
		AddSpawnPoint("f_castle_96.Id3", "f_castle_96", Rectangle(-1, -1571, 40));
		AddSpawnPoint("f_castle_96.Id3", "f_castle_96", Rectangle(-208, -13, 40));
		AddSpawnPoint("f_castle_96.Id3", "f_castle_96", Rectangle(203, 411, 40));
		AddSpawnPoint("f_castle_96.Id3", "f_castle_96", Rectangle(-1381, -31, 40));
		AddSpawnPoint("f_castle_96.Id3", "f_castle_96", Rectangle(-1314, 548, 40));
		AddSpawnPoint("f_castle_96.Id3", "f_castle_96", Rectangle(-63, 997, 40));
		AddSpawnPoint("f_castle_96.Id3", "f_castle_96", Rectangle(1396, 1124, 40));
		AddSpawnPoint("f_castle_96.Id3", "f_castle_96", Rectangle(944, 132, 40));
		AddSpawnPoint("f_castle_96.Id3", "f_castle_96", Rectangle(1429, 199, 40));
		AddSpawnPoint("f_castle_96.Id3", "f_castle_96", Rectangle(-918, -658, 40));
		AddSpawnPoint("f_castle_96.Id3", "f_castle_96", Rectangle(257, 1166, 40));
		AddSpawnPoint("f_castle_96.Id3", "f_castle_96", Rectangle(1053, 388, 40));
		AddSpawnPoint("f_castle_96.Id3", "f_castle_96", Rectangle(-1275, 857, 40));

		// 'Ghoscat' GenType 4 Spawn Points
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(-166, -143, 20));
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(-68, 4, 20));
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(-242, 146, 20));
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(-429, 239, 20));
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(-265, 336, 20));
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(42, 459, 20));
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(371, -167, 20));
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(370, 16, 20));
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(235, 67, 20));
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(69, -181, 20));
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(33, 56, 20));
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(-121, 70, 20));
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(69, -1660, 20));
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(-41, -1500, 20));
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(-978, -769, 20));
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(-131, -31, 20));
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(-26, -82, 20));
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(325, 336, 20));
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(170, -1634, 20));
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(298, 544, 20));
		AddSpawnPoint("f_castle_96.Id4", "f_castle_96", Rectangle(109, 501, 20));

		// 'Rootcrystal_04' GenType 7 Spawn Points
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(230, -1910, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(-98, -1785, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(130, -1649, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(-55, -1461, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(-12, -1078, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(-347, -780, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(159, -552, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(-236, -43, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(151, -81, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(243, 274, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(-205, 297, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(144, 646, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(52, 955, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(295, 1107, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(860, 1193, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(1497, 1212, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(1392, 982, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(1600, 252, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(1319, 123, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(1092, -117, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(857, 129, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(1061, 339, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(-709, -27, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(-1384, -106, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(-1210, -6, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(-1265, 383, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(-1421, 709, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(-1164, 799, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(-1199, -895, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(-909, -731, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(-611, -767, 200));
		AddSpawnPoint("f_castle_96.Id5", "f_castle_96", Rectangle(197, -838, 200));
	}
}
