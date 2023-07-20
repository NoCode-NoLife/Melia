//--- Melia Script -----------------------------------------------------------
// Gele Plateau Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_gele_57_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FGele572MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_gele_57_2", MonsterId.Leafly, Properties("MHP", 13230, "MINPATK", 671, "MAXPATK", 727, "MINMATK", 671, "MAXMATK", 727, "DEF", 67, "MDEF", 67));
		AddPropertyOverrides("f_gele_57_2", MonsterId.Npanto_Hand, Properties("MHP", 13394, "MINPATK", 673, "MAXPATK", 729, "MINMATK", 673, "MAXMATK", 729, "DEF", 67, "MDEF", 67));
		AddPropertyOverrides("f_gele_57_2", MonsterId.Npanto_Sword, Properties("MHP", 13575, "MINPATK", 676, "MAXPATK", 732, "MINMATK", 676, "MAXMATK", 732, "DEF", 68, "MDEF", 68));
		AddPropertyOverrides("f_gele_57_2", MonsterId.Mally, Properties("MHP", 13772, "MINPATK", 678, "MAXPATK", 735, "MINMATK", 678, "MAXMATK", 735, "DEF", 68, "MDEF", 68));
		AddPropertyOverrides("f_gele_57_2", MonsterId.Npanto_Staff, Properties("MHP", 13984, "MINPATK", 681, "MAXPATK", 738, "MINMATK", 681, "MAXMATK", 738, "DEF", 68, "MDEF", 68));
		AddPropertyOverrides("f_gele_57_2", MonsterId.Mon_Goat_Totem_Q, Properties("MHP", 14210, "MINPATK", 684, "MAXPATK", 742, "MINMATK", 684, "MAXMATK", 742, "DEF", 68, "MDEF", 68));
		AddPropertyOverrides("f_gele_57_2", MonsterId.Spion_Bow, Properties("MHP", 14448, "MINPATK", 687, "MAXPATK", 746, "MINMATK", 687, "MAXMATK", 746, "DEF", 68, "MDEF", 68));

		// Monster Spawners ---------------------------------

		AddSpawner("f_gele_57_2.Id1", MonsterId.Leafly, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id2", MonsterId.Npanto_Hand, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id3", MonsterId.Npanto_Sword, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id4", MonsterId.Mally, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id5", MonsterId.Npanto_Staff, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id6", MonsterId.Npanto_Sword, 12, 15, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id7", MonsterId.Npanto_Hand, 3, 3, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id8", MonsterId.Rootcrystal_01, 10, 13, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id9", MonsterId.Mon_Goat_Totem_Q, 8, 10, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id10", MonsterId.Mally, 6, 7, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id11", MonsterId.Spion_Bow, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id12", MonsterId.Spion_Bow, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_2.Id13", MonsterId.Leafly, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Leafly' GenType 120 Spawn Points
		AddSpawnPoint("f_gele_57_2.Id1", "f_gele_57_2", Rectangle(525, -65, 9999));

		// 'Npanto_Hand' GenType 122 Spawn Points
		AddSpawnPoint("f_gele_57_2.Id2", "f_gele_57_2", Rectangle(1389, -588, 9999));

		// 'Npanto_Sword' GenType 126 Spawn Points
		AddSpawnPoint("f_gele_57_2.Id3", "f_gele_57_2", Rectangle(-1109, 131, 30));
		AddSpawnPoint("f_gele_57_2.Id3", "f_gele_57_2", Rectangle(-1382, 194, 30));
		AddSpawnPoint("f_gele_57_2.Id3", "f_gele_57_2", Rectangle(-1098, 383, 30));
		AddSpawnPoint("f_gele_57_2.Id3", "f_gele_57_2", Rectangle(-1193, 39, 30));
		AddSpawnPoint("f_gele_57_2.Id3", "f_gele_57_2", Rectangle(-1161, -200, 30));
		AddSpawnPoint("f_gele_57_2.Id3", "f_gele_57_2", Rectangle(-888, -433, 30));
		AddSpawnPoint("f_gele_57_2.Id3", "f_gele_57_2", Rectangle(-792, -9, 30));
		AddSpawnPoint("f_gele_57_2.Id3", "f_gele_57_2", Rectangle(-902, -148, 30));
		AddSpawnPoint("f_gele_57_2.Id3", "f_gele_57_2", Rectangle(-726, -185, 30));
		AddSpawnPoint("f_gele_57_2.Id3", "f_gele_57_2", Rectangle(-1098, -436, 30));

		// 'Mally' GenType 127 Spawn Points
		AddSpawnPoint("f_gele_57_2.Id4", "f_gele_57_2", Rectangle(-459, -438, 9999));

		// 'Npanto_Staff' GenType 130 Spawn Points
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-913, -462, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-1151, -398, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-782, -132, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-530, -373, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-1257, 64, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-1118, 524, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-1163, -248, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-1402, 265, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-942, -248, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-725, -249, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-1140, -511, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-1094, -373, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-1116, -247, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-1132, -73, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-1265, 408, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-1255, 450, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-1124, 329, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-1148, 197, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-1382, 213, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-1406, 143, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-846, -155, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-869, -257, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-851, -375, 20));
		AddSpawnPoint("f_gele_57_2.Id5", "f_gele_57_2", Rectangle(-756, -48, 20));

		// 'Npanto_Sword' GenType 134 Spawn Points
		AddSpawnPoint("f_gele_57_2.Id6", "f_gele_57_2", Rectangle(1343, -765, 25));
		AddSpawnPoint("f_gele_57_2.Id6", "f_gele_57_2", Rectangle(1342, -580, 25));
		AddSpawnPoint("f_gele_57_2.Id6", "f_gele_57_2", Rectangle(1233, -412, 25));
		AddSpawnPoint("f_gele_57_2.Id6", "f_gele_57_2", Rectangle(1067, -1070, 25));
		AddSpawnPoint("f_gele_57_2.Id6", "f_gele_57_2", Rectangle(725, -350, 25));
		AddSpawnPoint("f_gele_57_2.Id6", "f_gele_57_2", Rectangle(811, -208, 25));
		AddSpawnPoint("f_gele_57_2.Id6", "f_gele_57_2", Rectangle(905, -390, 25));
		AddSpawnPoint("f_gele_57_2.Id6", "f_gele_57_2", Rectangle(442, -234, 25));
		AddSpawnPoint("f_gele_57_2.Id6", "f_gele_57_2", Rectangle(486, 50, 25));
		AddSpawnPoint("f_gele_57_2.Id6", "f_gele_57_2", Rectangle(985, -991, 25));
		AddSpawnPoint("f_gele_57_2.Id6", "f_gele_57_2", Rectangle(1514, -338, 25));
		AddSpawnPoint("f_gele_57_2.Id6", "f_gele_57_2", Rectangle(1411, -469, 25));
		AddSpawnPoint("f_gele_57_2.Id6", "f_gele_57_2", Rectangle(1030, -797, 25));
		AddSpawnPoint("f_gele_57_2.Id6", "f_gele_57_2", Rectangle(1158, -595, 25));

		// 'Npanto_Hand' GenType 135 Spawn Points
		AddSpawnPoint("f_gele_57_2.Id7", "f_gele_57_2", Rectangle(441, 314, 40));
		AddSpawnPoint("f_gele_57_2.Id7", "f_gele_57_2", Rectangle(560, 622, 40));
		AddSpawnPoint("f_gele_57_2.Id7", "f_gele_57_2", Rectangle(1351, -744, 40));
		AddSpawnPoint("f_gele_57_2.Id7", "f_gele_57_2", Rectangle(1185, -561, 40));
		AddSpawnPoint("f_gele_57_2.Id7", "f_gele_57_2", Rectangle(408, -64, 40));

		// 'Rootcrystal_01' GenType 136 Spawn Points
		AddSpawnPoint("f_gele_57_2.Id8", "f_gele_57_2", Rectangle(-147, -848, 10));
		AddSpawnPoint("f_gele_57_2.Id8", "f_gele_57_2", Rectangle(172, -573, 10));
		AddSpawnPoint("f_gele_57_2.Id8", "f_gele_57_2", Rectangle(-515, -370, 10));
		AddSpawnPoint("f_gele_57_2.Id8", "f_gele_57_2", Rectangle(-809, -206, 10));
		AddSpawnPoint("f_gele_57_2.Id8", "f_gele_57_2", Rectangle(-1142, -245, 10));
		AddSpawnPoint("f_gele_57_2.Id8", "f_gele_57_2", Rectangle(-1163, 12, 10));
		AddSpawnPoint("f_gele_57_2.Id8", "f_gele_57_2", Rectangle(-1221, 324, 10));
		AddSpawnPoint("f_gele_57_2.Id8", "f_gele_57_2", Rectangle(557, -192, 10));
		AddSpawnPoint("f_gele_57_2.Id8", "f_gele_57_2", Rectangle(837, -315, 10));
		AddSpawnPoint("f_gele_57_2.Id8", "f_gele_57_2", Rectangle(1251, -503, 10));
		AddSpawnPoint("f_gele_57_2.Id8", "f_gele_57_2", Rectangle(1067, -725, 10));
		AddSpawnPoint("f_gele_57_2.Id8", "f_gele_57_2", Rectangle(1108, -702, 10));
		AddSpawnPoint("f_gele_57_2.Id8", "f_gele_57_2", Rectangle(461, 199, 10));
		AddSpawnPoint("f_gele_57_2.Id8", "f_gele_57_2", Rectangle(546, 649, 10));
		AddSpawnPoint("f_gele_57_2.Id8", "f_gele_57_2", Rectangle(835, 1074, 10));
		AddSpawnPoint("f_gele_57_2.Id8", "f_gele_57_2", Rectangle(943, 1007, 10));
		AddSpawnPoint("f_gele_57_2.Id8", "f_gele_57_2", Rectangle(862, 1566, 10));
		AddSpawnPoint("f_gele_57_2.Id8", "f_gele_57_2", Rectangle(115, 1261, 10));
		AddSpawnPoint("f_gele_57_2.Id8", "f_gele_57_2", Rectangle(-74, 1195, 10));

		// 'Mon_Goat_Totem_Q' GenType 140 Spawn Points
		AddSpawnPoint("f_gele_57_2.Id9", "f_gele_57_2", Rectangle(884, -984, 20));
		AddSpawnPoint("f_gele_57_2.Id9", "f_gele_57_2", Rectangle(978, -662, 20));
		AddSpawnPoint("f_gele_57_2.Id9", "f_gele_57_2", Rectangle(1118, -413, 20));
		AddSpawnPoint("f_gele_57_2.Id9", "f_gele_57_2", Rectangle(981, -157, 20));
		AddSpawnPoint("f_gele_57_2.Id9", "f_gele_57_2", Rectangle(773, -196, 20));
		AddSpawnPoint("f_gele_57_2.Id9", "f_gele_57_2", Rectangle(1223, -249, 20));
		AddSpawnPoint("f_gele_57_2.Id9", "f_gele_57_2", Rectangle(1421, -217, 20));
		AddSpawnPoint("f_gele_57_2.Id9", "f_gele_57_2", Rectangle(1450, -683, 20));
		AddSpawnPoint("f_gele_57_2.Id9", "f_gele_57_2", Rectangle(1247, -739, 20));
		AddSpawnPoint("f_gele_57_2.Id9", "f_gele_57_2", Rectangle(1573, -391, 20));
		AddSpawnPoint("f_gele_57_2.Id9", "f_gele_57_2", Rectangle(1508, -516, 20));
		AddSpawnPoint("f_gele_57_2.Id9", "f_gele_57_2", Rectangle(1229, -1142, 20));
		AddSpawnPoint("f_gele_57_2.Id9", "f_gele_57_2", Rectangle(979, -808, 20));
		AddSpawnPoint("f_gele_57_2.Id9", "f_gele_57_2", Rectangle(834, -400, 20));
		AddSpawnPoint("f_gele_57_2.Id9", "f_gele_57_2", Rectangle(1029, -283, 20));

		// 'Mally' GenType 141 Spawn Points
		AddSpawnPoint("f_gele_57_2.Id10", "f_gele_57_2", Rectangle(851, -278, 20));
		AddSpawnPoint("f_gele_57_2.Id10", "f_gele_57_2", Rectangle(440, 233, 20));
		AddSpawnPoint("f_gele_57_2.Id10", "f_gele_57_2", Rectangle(492, -265, 20));
		AddSpawnPoint("f_gele_57_2.Id10", "f_gele_57_2", Rectangle(592, 738, 20));
		AddSpawnPoint("f_gele_57_2.Id10", "f_gele_57_2", Rectangle(1351, -418, 20));
		AddSpawnPoint("f_gele_57_2.Id10", "f_gele_57_2", Rectangle(1030, -790, 20));
		AddSpawnPoint("f_gele_57_2.Id10", "f_gele_57_2", Rectangle(1338, -692, 20));
		AddSpawnPoint("f_gele_57_2.Id10", "f_gele_57_2", Rectangle(1182, -535, 20));
		AddSpawnPoint("f_gele_57_2.Id10", "f_gele_57_2", Rectangle(1554, -286, 20));
		AddSpawnPoint("f_gele_57_2.Id10", "f_gele_57_2", Rectangle(768, -101, 20));
		AddSpawnPoint("f_gele_57_2.Id10", "f_gele_57_2", Rectangle(690, -313, 20));
		AddSpawnPoint("f_gele_57_2.Id10", "f_gele_57_2", Rectangle(431, -13, 20));
		AddSpawnPoint("f_gele_57_2.Id10", "f_gele_57_2", Rectangle(519, 533, 20));
		AddSpawnPoint("f_gele_57_2.Id10", "f_gele_57_2", Rectangle(818, 1035, 20));
		AddSpawnPoint("f_gele_57_2.Id10", "f_gele_57_2", Rectangle(1050, 984, 20));
		AddSpawnPoint("f_gele_57_2.Id10", "f_gele_57_2", Rectangle(950, 1150, 20));
		AddSpawnPoint("f_gele_57_2.Id10", "f_gele_57_2", Rectangle(906, 905, 20));
		AddSpawnPoint("f_gele_57_2.Id10", "f_gele_57_2", Rectangle(834, 1154, 20));

		// 'Spion_Bow' GenType 149 Spawn Points
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(408, 397, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(810, 991, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(1051, 969, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(-1111, -264, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(-1316, 250, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(-1067, 176, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(-1120, -63, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(-823, -174, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(639, 743, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(925, 1231, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(1020, -712, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(1302, -426, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(1071, -541, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(1303, -630, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(1498, -405, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(842, -266, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(504, -284, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(467, -3, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(791, 1161, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(-1164, 479, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(-1287, 442, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(-1199, 38, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(-881, -378, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(-741, -74, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(-710, -254, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(-556, -448, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(-482, -357, 30));
		AddSpawnPoint("f_gele_57_2.Id11", "f_gele_57_2", Rectangle(-1237, -179, 30));

		// 'Spion_Bow' GenType 154 Spawn Points
		AddSpawnPoint("f_gele_57_2.Id12", "f_gele_57_2", Rectangle(927, 1325, 20));
		AddSpawnPoint("f_gele_57_2.Id12", "f_gele_57_2", Rectangle(767, 1464, 20));
		AddSpawnPoint("f_gele_57_2.Id12", "f_gele_57_2", Rectangle(796, 1645, 20));
		AddSpawnPoint("f_gele_57_2.Id12", "f_gele_57_2", Rectangle(907, 1847, 20));
		AddSpawnPoint("f_gele_57_2.Id12", "f_gele_57_2", Rectangle(1105, 1754, 20));
		AddSpawnPoint("f_gele_57_2.Id12", "f_gele_57_2", Rectangle(1213, 1601, 20));
		AddSpawnPoint("f_gele_57_2.Id12", "f_gele_57_2", Rectangle(1213, 1601, 20));
		AddSpawnPoint("f_gele_57_2.Id12", "f_gele_57_2", Rectangle(1144, 1401, 20));
		AddSpawnPoint("f_gele_57_2.Id12", "f_gele_57_2", Rectangle(1067, 1338, 20));
		AddSpawnPoint("f_gele_57_2.Id12", "f_gele_57_2", Rectangle(870, 1412, 20));
		AddSpawnPoint("f_gele_57_2.Id12", "f_gele_57_2", Rectangle(792, 1624, 20));
		AddSpawnPoint("f_gele_57_2.Id12", "f_gele_57_2", Rectangle(948, 1759, 20));
		AddSpawnPoint("f_gele_57_2.Id12", "f_gele_57_2", Rectangle(1048, 1757, 20));
		AddSpawnPoint("f_gele_57_2.Id12", "f_gele_57_2", Rectangle(816, 1801, 20));
		AddSpawnPoint("f_gele_57_2.Id12", "f_gele_57_2", Rectangle(770, 1522, 20));

		// 'Leafly' GenType 155 Spawn Points
		AddSpawnPoint("f_gele_57_2.Id13", "f_gele_57_2", Rectangle(-1412, 77, 20));
		AddSpawnPoint("f_gele_57_2.Id13", "f_gele_57_2", Rectangle(-1490, 181, 20));
		AddSpawnPoint("f_gele_57_2.Id13", "f_gele_57_2", Rectangle(-1437, 409, 20));
		AddSpawnPoint("f_gele_57_2.Id13", "f_gele_57_2", Rectangle(-1160, 541, 20));
		AddSpawnPoint("f_gele_57_2.Id13", "f_gele_57_2", Rectangle(-1021, 494, 20));
		AddSpawnPoint("f_gele_57_2.Id13", "f_gele_57_2", Rectangle(-965, 424, 20));
		AddSpawnPoint("f_gele_57_2.Id13", "f_gele_57_2", Rectangle(-998, 264, 20));
		AddSpawnPoint("f_gele_57_2.Id13", "f_gele_57_2", Rectangle(-1037, 163, 20));
		AddSpawnPoint("f_gele_57_2.Id13", "f_gele_57_2", Rectangle(-1007, 59, 20));
		AddSpawnPoint("f_gele_57_2.Id13", "f_gele_57_2", Rectangle(-1184, 39, 20));
		AddSpawnPoint("f_gele_57_2.Id13", "f_gele_57_2", Rectangle(-1254, 39, 20));
		AddSpawnPoint("f_gele_57_2.Id13", "f_gele_57_2", Rectangle(-1400, 237, 20));
		AddSpawnPoint("f_gele_57_2.Id13", "f_gele_57_2", Rectangle(-1342, 482, 20));
		AddSpawnPoint("f_gele_57_2.Id13", "f_gele_57_2", Rectangle(-1247, 542, 20));
		AddSpawnPoint("f_gele_57_2.Id13", "f_gele_57_2", Rectangle(-1108, 316, 20));
		AddSpawnPoint("f_gele_57_2.Id13", "f_gele_57_2", Rectangle(-1243, 142, 20));
	}
}
