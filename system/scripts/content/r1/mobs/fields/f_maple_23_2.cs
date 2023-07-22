//--- Melia Script -----------------------------------------------------------
// Pystis Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_maple_23_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FMaple232MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_maple_23_2", MonsterId.Leafnut_Yellow, Properties("MHP", 708532, "MINPATK", 9612, "MAXPATK", 11716, "MINMATK", 9612, "MAXMATK", 11716, "DEF", 197228, "MDEF", 197228));
		AddPropertyOverrides("f_maple_23_2", MonsterId.Grummer_Orange, Properties("MHP", 710847, "MINPATK", 9642, "MAXPATK", 11752, "MINMATK", 9642, "MAXMATK", 11752, "DEF", 198883, "MDEF", 198883));
		AddPropertyOverrides("f_maple_23_2", MonsterId.Colimen_Red, Properties("MHP", 713207, "MINPATK", 9672, "MAXPATK", 11790, "MINMATK", 9672, "MAXMATK", 11790, "DEF", 200569, "MDEF", 200569));
		AddPropertyOverrides("f_maple_23_2", MonsterId.Caro_Yellow, Properties("MHP", 715610, "MINPATK", 9703, "MAXPATK", 11828, "MINMATK", 9703, "MAXMATK", 11828, "DEF", 202287, "MDEF", 202287));

		// Monster Spawners ---------------------------------

		AddSpawner("f_maple_23_2.Id1", MonsterId.Rootcrystal_05, min: 10, max: 13, respawn: TimeSpan.FromMilliseconds(5000));
		AddSpawner("f_maple_23_2.Id2", MonsterId.Leafnut_Yellow, min: 19, max: 25);
		AddSpawner("f_maple_23_2.Id3", MonsterId.Grummer_Orange, min: 15, max: 20);
		AddSpawner("f_maple_23_2.Id4", MonsterId.Colimen_Red, min: 12, max: 15);
		AddSpawner("f_maple_23_2.Id5", MonsterId.Caro_Yellow, min: 30, max: 40);
		AddSpawner("f_maple_23_2.Id6", MonsterId.Caro_Yellow, min: 9, max: 12);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 5 Spawn Points
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(1315, -213, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(949, 126, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(337, 55, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(75, 288, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(-213, 77, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(-741, 60, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(-1207, 120, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(-998, 1464, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(130, 864, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(-66, 1485, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(324, 1462, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(861, 1611, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(1167, 1553, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(1166, 616, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(894, 563, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(-218, -510, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(526, -674, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(888, -569, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(1307, -1011, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(1566, -504, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(-775, -678, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(-1286, -707, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(-1216, -1283, 50));

		// 'Leafnut_Yellow' GenType 100 Spawn Points
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(826, 139, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(1025, 87, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(940, -173, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(1194, -250, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(1164, -72, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(1333, 25, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(1249, -110, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-4, -20, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(76, 444, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-265, 176, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(381, 135, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(186, -62, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-1158, 56, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-934, 7, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-844, -22, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-1024, 81, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-613, 68, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-795, 169, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(32, 257, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(195, 143, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-24, 130, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-27, 431, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(194, 255, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-211, -85, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(363, -111, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-1081, 175, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-1120, 314, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-1252, 83, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-973, 201, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(994, -50, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(617, 143, 50));

		// 'Grummer_Orange' GenType 103 Spawn Points
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(-1287, 1624, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(-1155, 1262, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(-929, 1263, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(-903, 1521, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(-1035, 1580, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(70, 807, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(332, 828, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(107, 719, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(138, 950, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(84, 1147, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(674, 1650, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(832, 1837, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(946, 1655, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(896, 1500, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1095, 1432, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1236, 1676, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1120, 1809, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(839, 2084, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(-1261, 1405, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(-1069, 1413, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1073, -1030, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1008, -837, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1193, -902, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1229, -1275, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1392, -952, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1251, -1078, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1416, -1290, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1499, -1117, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1563, -1231, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1372, -1144, 40));

		// 'Colimen_Red' GenType 106 Spawn Points
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(-1075, -591, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(-1249, -768, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(-880, -723, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(-1296, -528, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(-952, -450, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(-769, -581, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(194, -708, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(356, -590, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(520, -655, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(634, -526, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(695, -676, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(950, -465, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(910, -696, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(1310, -529, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(1386, -382, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(1534, -501, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(1543, -301, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(1670, -410, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(1098, -578, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(812, -572, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(724, -382, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(468, -520, 50));

		// 'Caro_Yellow' GenType 110 Spawn Points
		AddSpawnPoint("f_maple_23_2.Id5", "f_maple_23_2", Rectangle(380, -625, 9999));

		// 'Caro_Yellow' GenType 111 Spawn Points
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-1222, -1003, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-1365, -727, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-975, -601, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-1012, -435, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-1240, -1258, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-1083, -1253, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-1255, -1110, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-1105, -1095, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-793, -591, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(437, -594, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(774, -544, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(657, -680, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(627, -544, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(1095, -932, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(1295, -1105, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(1385, -1042, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(1205, -48, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(932, 97, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(885, -143, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(1098, -59, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(222, 936, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(239, 813, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(227, 712, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(346, 729, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-933, 1541, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-1253, 1524, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-1148, 1334, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-996, 1397, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(734, 1905, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(977, 1894, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(1080, 1636, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(911, 1732, 40));
	}
}
