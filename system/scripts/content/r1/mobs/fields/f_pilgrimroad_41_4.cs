//--- Melia Script -----------------------------------------------------------
// Sekta Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_pilgrimroad_41_4'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad414MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_pilgrimroad_41_4.Id1", MonsterId.Rootcrystal_05, min: 12, max: 16, respawn: TimeSpan.FromMilliseconds(5000));
		AddSpawner("f_pilgrimroad_41_4.Id2", MonsterId.Dumaro_Yellow, min: 9, max: 12);
		AddSpawner("f_pilgrimroad_41_4.Id3", MonsterId.Repusbunny_Purple, min: 60, max: 80);
		AddSpawner("f_pilgrimroad_41_4.Id4", MonsterId.Repusbunny_Bow_Purple, min: 9, max: 12);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 4 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(-112, 1084, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(-53, 846, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(477, 740, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(698, 799, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(773, 535, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(1086, 258, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(1371, 220, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(1322, -110, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(445, -200, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(297, -386, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(-166, -14, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(-924, -640, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(-171, -636, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(-263, -969, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(150, -1397, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(591, -1666, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(626, -1338, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(1184, -684, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(1458, -941, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(1855, -885, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(1870, -1153, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(1785, 10, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(2052, 84, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(-519, 24, 50));

		// 'Dumaro_Yellow' GenType 100 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1052, -779, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(2007, -1125, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1741, -906, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1724, -1020, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(2023, -944, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1904, -1166, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1523, -51, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(564, 560, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(752, 507, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(824, 697, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(778, 849, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(134, -355, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(302, -484, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(550, -440, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(650, -224, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(356, -349, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(428, -92, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(259, -75, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-77, 1, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-394, 159, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-473, -78, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-202, -114, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(89, -289, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-23, -501, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-247, -580, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(34, -752, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-505, -699, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(882, -55, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1352, -539, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1463, -790, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1294, -827, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1001, -651, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1337, -934, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1075, -960, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1221, -520, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1584, 75, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1134, -581, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1557, -921, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-1009, -826, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-989, -617, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-1203, -592, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-1023, -341, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-919, -798, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-902, -503, 25));

		// 'Repusbunny_Purple' GenType 101 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(401, -82, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-526, 127, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(167, -234, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-200, -892, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-381, -757, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1066, -620, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1375, -757, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1925, -1223, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1378, -577, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1386, -1005, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(743, -1684, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(629, -1758, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(544, -1712, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(358, -1685, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(827, -1552, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(879, -1483, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(812, -1397, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(749, -1549, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(686, -1495, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(509, -1588, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(714, -1309, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(532, -1482, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(499, -1376, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(151, -1505, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(253, -1430, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(363, -1508, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(485, -1247, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(348, -1325, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(131, -1235, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-385, -884, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-446, -982, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-253, -1070, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-392, -661, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(16, -945, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-242, -705, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-276, -554, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-151, -625, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-89, -734, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(4, -822, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-112, -1046, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-696, -656, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-872, -769, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-817, -619, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-997, -891, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-1134, -688, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-1070, -518, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-929, -661, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-736, -436, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-920, -505, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-937, -269, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-978, -391, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-564, -6, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-589, -124, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-284, -240, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-141, -111, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-440, -101, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-251, 13, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-367, 94, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-487, -232, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-468, 231, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-113, 61, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-300, 174, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(152, -426, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(616, -293, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(315, -542, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(338, -372, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(563, -441, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(523, -245, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(330, -225, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(279, -117, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(518, -59, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(559, -97, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1696, -990, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1845, -1340, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1811, -1215, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1960, -1113, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1797, -1070, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1903, -1031, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1843, -816, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1970, -887, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1249, -666, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1168, -747, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1228, -905, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1042, -930, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1062, -855, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1020, -725, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1176, -567, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(2151, -29, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1951, -73, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(2113, 107, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1929, 202, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1801, 112, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1767, -1, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(820, 614, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(682, 650, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(742, 764, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(543, 659, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(574, 776, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(697, 536, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(566, 907, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(515, 541, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(407, 736, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(36, 1153, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-78, 1153, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(66, 988, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-99, 1268, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-116, 988, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-162, 898, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-268, 783, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-310, 879, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-26, 780, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-239, 1050, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(105, 798, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(183, 764, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(189, 837, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(276, 818, 25));

		// 'Repusbunny_Bow_Purple' GenType 102 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(278, 746, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(563, 883, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(473, 745, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(507, 567, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(809, 662, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(814, 483, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(1818, 43, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(1918, 176, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(1962, 58, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(2097, 87, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(2078, -75, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(1809, -106, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(1955, -99, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(181, -1494, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(376, -1623, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(476, -1795, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(656, -1705, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(531, -1491, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(778, -1482, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(741, -1269, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(466, -1312, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(198, -1304, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(-505, 133, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(-244, 215, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(-145, -87, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(-568, -100, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(-1061, -693, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(-938, -347, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(-416, -99, 25));
	}
}
