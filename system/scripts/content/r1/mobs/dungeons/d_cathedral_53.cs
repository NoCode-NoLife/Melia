//--- Melia Script -----------------------------------------------------------
// Main Building Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_cathedral_53'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCathedral53MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_cathedral_53", MonsterId.Loftlem_Blue, Properties("MHP", 143158, "MINPATK", 2342, "MAXPATK", 2780, "MINMATK", 2342, "MAXMATK", 2780, "DEF", 3039, "MDEF", 3039));
		AddPropertyOverrides("d_cathedral_53", MonsterId.Anchor_Mage, Properties("MHP", 144780, "MINPATK", 2363, "MAXPATK", 2806, "MINMATK", 2363, "MAXMATK", 2806, "DEF", 3132, "MDEF", 3132));
		AddPropertyOverrides("d_cathedral_53", MonsterId.Colifly, Properties("MHP", 146448, "MINPATK", 2384, "MAXPATK", 2832, "MINMATK", 2384, "MAXMATK", 2832, "DEF", 3229, "MDEF", 3229));

		// Monster Spawners ---------------------------------

		AddSpawner("d_cathedral_53.Id1", MonsterId.Loftlem_Blue, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_53.Id2", MonsterId.Rootcrystal_03, min: 19, max: 25, respawn: TimeSpan.FromMilliseconds(5000), tendency: TendencyType.Peaceful);
		AddSpawner("d_cathedral_53.Id3", MonsterId.Loftlem_Blue, min: 8, max: 10, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_53.Id4", MonsterId.Anchor_Mage, min: 6, max: 7, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_53.Id5", MonsterId.Colifly, min: 34, max: 45, tendency: TendencyType.Peaceful);
		AddSpawner("d_cathedral_53.Id6", MonsterId.Loftlem_Blue, min: 5, max: 6, tendency: TendencyType.Peaceful);
		AddSpawner("d_cathedral_53.Id7", MonsterId.Anchor_Mage, min: 15, max: 20, tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Loftlem_Blue' GenType 3 Spawn Points
		AddSpawnPoint("d_cathedral_53.Id1", "d_cathedral_53", Rectangle(359, 67, 9999));

		// 'Rootcrystal_03' GenType 24 Spawn Points
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(-8, -868, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(-121, -626, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(-358, -334, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(-583, -126, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(-883, -307, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(-928, 178, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(-1055, -41, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(-1383, -72, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(-1426, -260, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(-1441, 226, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(-1736, 37, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(-1738, -322, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(-1983, 66, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(-320, 345, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(82, 120, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(360, 55, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(16, 699, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(309, 820, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(710, 273, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(853, -34, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(1067, 264, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(895, -360, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(925, -804, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(936, -1063, 10));
		AddSpawnPoint("d_cathedral_53.Id2", "d_cathedral_53", Rectangle(867, -1290, 10));

		// 'Loftlem_Blue' GenType 48 Spawn Points
		AddSpawnPoint("d_cathedral_53.Id3", "d_cathedral_53", Rectangle(-12, 332, 30));
		AddSpawnPoint("d_cathedral_53.Id3", "d_cathedral_53", Rectangle(-31, 49, 30));
		AddSpawnPoint("d_cathedral_53.Id3", "d_cathedral_53", Rectangle(-338, 479, 30));
		AddSpawnPoint("d_cathedral_53.Id3", "d_cathedral_53", Rectangle(-270, 729, 30));
		AddSpawnPoint("d_cathedral_53.Id3", "d_cathedral_53", Rectangle(18, 824, 30));
		AddSpawnPoint("d_cathedral_53.Id3", "d_cathedral_53", Rectangle(342, 663, 30));
		AddSpawnPoint("d_cathedral_53.Id3", "d_cathedral_53", Rectangle(328, 345, 30));
		AddSpawnPoint("d_cathedral_53.Id3", "d_cathedral_53", Rectangle(-164, 1014, 30));

		// 'Anchor_Mage' GenType 53 Spawn Points
		AddSpawnPoint("d_cathedral_53.Id4", "d_cathedral_53", Rectangle(-1938, -26, 30));
		AddSpawnPoint("d_cathedral_53.Id4", "d_cathedral_53", Rectangle(-1566, -251, 30));
		AddSpawnPoint("d_cathedral_53.Id4", "d_cathedral_53", Rectangle(-1624, -88, 30));
		AddSpawnPoint("d_cathedral_53.Id4", "d_cathedral_53", Rectangle(-1514, 197, 30));
		AddSpawnPoint("d_cathedral_53.Id4", "d_cathedral_53", Rectangle(-842, 22, 30));
		AddSpawnPoint("d_cathedral_53.Id4", "d_cathedral_53", Rectangle(-1244, -119, 30));
		AddSpawnPoint("d_cathedral_53.Id4", "d_cathedral_53", Rectangle(-963, -310, 30));
		AddSpawnPoint("d_cathedral_53.Id4", "d_cathedral_53", Rectangle(-687, 206, 30));
		AddSpawnPoint("d_cathedral_53.Id4", "d_cathedral_53", Rectangle(-1954, -335, 30));
		AddSpawnPoint("d_cathedral_53.Id4", "d_cathedral_53", Rectangle(-1802, 204, 30));

		// 'Colifly' GenType 55 Spawn Points
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(1035, -336, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(766, -280, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(641, 108, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(978, 122, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(834, 42, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(1063, -118, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(919, -483, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-2071, -164, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-2083, 42, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-2034, 187, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1668, -250, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1584, -2, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1387, 11, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1348, -91, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1576, -340, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1265, -276, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1189, -273, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-836, -301, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-558, -292, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-624, 9, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-781, -68, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-901, -49, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1076, -11, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-990, 16, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-551, 194, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-877, 197, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1090, 217, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1338, 209, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1434, 212, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1601, 186, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1750, 170, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-676, -96, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-586, -76, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1003, -78, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1252, 9, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1317, -15, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1426, -90, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1119, -114, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1391, -342, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1467, 20, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1740, 31, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1803, -88, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1890, -198, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1453, 177, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1312, 166, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-1209, 164, 30));
		AddSpawnPoint("d_cathedral_53.Id5", "d_cathedral_53", Rectangle(-984, 226, 30));

		// 'Loftlem_Blue' GenType 56 Spawn Points
		AddSpawnPoint("d_cathedral_53.Id6", "d_cathedral_53", Rectangle(964, -713, 25));
		AddSpawnPoint("d_cathedral_53.Id6", "d_cathedral_53", Rectangle(927, -1062, 25));
		AddSpawnPoint("d_cathedral_53.Id6", "d_cathedral_53", Rectangle(950, -895, 25));
		AddSpawnPoint("d_cathedral_53.Id6", "d_cathedral_53", Rectangle(902, -542, 25));

		// 'Anchor_Mage' GenType 59 Spawn Points
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-1432, -304, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-1081, -289, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-1173, 12, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-2191, -44, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-1664, 214, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-1378, 260, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-1724, -369, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-683, -305, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-731, 7, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(974, -1041, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(991, -1094, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(925, -1174, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(852, -1136, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(946, -929, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(994, -897, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(903, -870, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(888, -912, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(1011, -721, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(971, -677, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(923, -707, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(962, -752, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(955, -530, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(916, -595, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(879, -513, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(934, -440, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(893, -462, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(870, -569, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(897, -328, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(1042, -279, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(977, -253, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(887, -235, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(727, -337, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(824, -290, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(719, -254, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(674, -323, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(1037, -135, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(1028, 36, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(810, -114, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(924, -143, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(826, -31, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(898, 20, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(837, 130, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(768, -24, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(651, 55, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(691, 127, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(733, 58, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(623, 134, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(943, 126, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(961, 67, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(978, 151, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(934, 88, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(333, 284, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(375, 333, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(336, 395, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(288, 314, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(379, -74, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(215, 73, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(59, 78, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-22, 137, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-9, 234, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(151, 7, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(279, 0, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(231, -86, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(87, 487, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(52, 577, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-95, 491, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-18, 439, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(373, 598, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(431, 690, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(300, 720, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(258, 677, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(104, 793, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(76, 889, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(120, 669, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(4, 712, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-102, 945, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(45, 1020, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-31, 1030, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-262, 1009, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-222, 725, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-260, 766, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-313, 733, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-269, 674, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-261, 339, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-247, 508, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-288, 559, 30));
		AddSpawnPoint("d_cathedral_53.Id7", "d_cathedral_53", Rectangle(-374, 340, 30));
	}
}
