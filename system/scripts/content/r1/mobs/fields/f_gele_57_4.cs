//--- Melia Script -----------------------------------------------------------
// Tenet Garden Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_gele_57_4'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FGele574MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_gele_57_4", MonsterId.Boss_Chapparition, Properties("MHP", 78939, "MINPATK", 1384, "MAXPATK", 1512, "MINMATK", 1384, "MAXMATK", 1512, "DEF", 134, "MDEF", 134));
		AddPropertyOverrides("f_gele_57_4", MonsterId.Seedmia, Properties("MHP", 17428, "MINPATK", 725, "MAXPATK", 793, "MINMATK", 725, "MAXMATK", 793, "DEF", 70, "MDEF", 70));
		AddPropertyOverrides("f_gele_57_4", MonsterId.Npanto_Archer, Properties("MHP", 17778, "MINPATK", 730, "MAXPATK", 798, "MINMATK", 730, "MAXMATK", 798, "DEF", 71, "MDEF", 71));
		AddPropertyOverrides("f_gele_57_4", MonsterId.Mallardu, Properties("MHP", 18136, "MINPATK", 734, "MAXPATK", 804, "MINMATK", 734, "MAXMATK", 804, "DEF", 71, "MDEF", 71));
		AddPropertyOverrides("f_gele_57_4", MonsterId.Colifly_Bow, Properties("MHP", 18503, "MINPATK", 739, "MAXPATK", 810, "MINMATK", 739, "MAXMATK", 810, "DEF", 71, "MDEF", 71));
		AddPropertyOverrides("f_gele_57_4", MonsterId.Zombiegirl2_Brown, Properties("MHP", 18878, "MINPATK", 744, "MAXPATK", 816, "MINMATK", 744, "MAXMATK", 816, "DEF", 71, "MDEF", 71));
		AddPropertyOverrides("f_gele_57_4", MonsterId.Panto_Javelin_Elite, Properties("MHP", 19260, "MINPATK", 749, "MAXPATK", 822, "MINMATK", 749, "MAXMATK", 822, "DEF", 72, "MDEF", 72));

		// Monster Spawners ---------------------------------

		AddSpawner("f_gele_57_4.Id1", MonsterId.Seedmia, min: 19, max: 25, respawn: TimeSpan.FromMilliseconds(3000000));
		AddSpawner("f_gele_57_4.Id2", MonsterId.Npanto_Archer, min: 12, max: 15);
		AddSpawner("f_gele_57_4.Id3", MonsterId.Mallardu, min: 12, max: 15);
		AddSpawner("f_gele_57_4.Id4", MonsterId.Colifly_Bow, min: 12, max: 15);
		AddSpawner("f_gele_57_4.Id5", MonsterId.Zombiegirl2_Brown, min: 12, max: 15);
		AddSpawner("f_gele_57_4.Id6", MonsterId.Seedmia, min: 15, max: 20, respawn: TimeSpan.FromMilliseconds(15000));
		AddSpawner("f_gele_57_4.Id7", MonsterId.Seedmia, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(180000));
		AddSpawner("f_gele_57_4.Id8", MonsterId.Mallardu, min: 15, max: 20);
		AddSpawner("f_gele_57_4.Id9", MonsterId.Rootcrystal_01, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("f_gele_57_4.Id10", MonsterId.Npanto_Archer, min: 19, max: 25);
		AddSpawner("f_gele_57_4.Id11", MonsterId.Panto_Javelin_Elite, amount: 1, respawn: TimeSpan.FromMilliseconds(1200000));
		AddSpawner("f_gele_57_4.Id12", MonsterId.Mallardu, min: 15, max: 20, respawn: TimeSpan.FromMilliseconds(20000));
		AddSpawner("f_gele_57_4.Id13", MonsterId.Npanto_Archer, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(20000));
		AddSpawner("f_gele_57_4.Id14", MonsterId.Seedmia, min: 8, max: 10, respawn: TimeSpan.FromMilliseconds(180000));
		AddSpawner("f_gele_57_4.Id15", MonsterId.Seedmia, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(180000));

		// Monster Spawn Points -----------------------------

		// 'Seedmia' GenType 19 Spawn Points
		AddSpawnPoint("f_gele_57_4.Id1", "f_gele_57_4", Rectangle(-2149, -167, 20));
		AddSpawnPoint("f_gele_57_4.Id1", "f_gele_57_4", Rectangle(-2184, -116, 20));
		AddSpawnPoint("f_gele_57_4.Id1", "f_gele_57_4", Rectangle(-2191, -66, 20));
		AddSpawnPoint("f_gele_57_4.Id1", "f_gele_57_4", Rectangle(-2175, 4, 20));
		AddSpawnPoint("f_gele_57_4.Id1", "f_gele_57_4", Rectangle(-2198, -18, 20));
		AddSpawnPoint("f_gele_57_4.Id1", "f_gele_57_4", Rectangle(-2159, 48, 20));
		AddSpawnPoint("f_gele_57_4.Id1", "f_gele_57_4", Rectangle(-2078, -218, 20));
		AddSpawnPoint("f_gele_57_4.Id1", "f_gele_57_4", Rectangle(-448, 593, 20));
		AddSpawnPoint("f_gele_57_4.Id1", "f_gele_57_4", Rectangle(-394, 592, 20));
		AddSpawnPoint("f_gele_57_4.Id1", "f_gele_57_4", Rectangle(-336, 606, 20));
		AddSpawnPoint("f_gele_57_4.Id1", "f_gele_57_4", Rectangle(-383, 503, 20));
		AddSpawnPoint("f_gele_57_4.Id1", "f_gele_57_4", Rectangle(-340, 511, 20));
		AddSpawnPoint("f_gele_57_4.Id1", "f_gele_57_4", Rectangle(-274, 495, 20));
		AddSpawnPoint("f_gele_57_4.Id1", "f_gele_57_4", Rectangle(-209, 471, 20));
		AddSpawnPoint("f_gele_57_4.Id1", "f_gele_57_4", Rectangle(-265, 604, 20));
		AddSpawnPoint("f_gele_57_4.Id1", "f_gele_57_4", Rectangle(-207, 613, 20));

		// 'Npanto_Archer' GenType 21 Spawn Points
		AddSpawnPoint("f_gele_57_4.Id2", "f_gele_57_4", Rectangle(-814, 1242, 300));

		// 'Mallardu' GenType 25 Spawn Points
		AddSpawnPoint("f_gele_57_4.Id3", "f_gele_57_4", Rectangle(1417, -542, 20));
		AddSpawnPoint("f_gele_57_4.Id3", "f_gele_57_4", Rectangle(1570, -665, 20));
		AddSpawnPoint("f_gele_57_4.Id3", "f_gele_57_4", Rectangle(-231, -627, 20));
		AddSpawnPoint("f_gele_57_4.Id3", "f_gele_57_4", Rectangle(1667, -812, 20));
		AddSpawnPoint("f_gele_57_4.Id3", "f_gele_57_4", Rectangle(-162, -503, 20));
		AddSpawnPoint("f_gele_57_4.Id3", "f_gele_57_4", Rectangle(-24, -615, 20));
		AddSpawnPoint("f_gele_57_4.Id3", "f_gele_57_4", Rectangle(-175, -755, 20));
		AddSpawnPoint("f_gele_57_4.Id3", "f_gele_57_4", Rectangle(-64, -773, 20));
		AddSpawnPoint("f_gele_57_4.Id3", "f_gele_57_4", Rectangle(1291, -698, 20));
		AddSpawnPoint("f_gele_57_4.Id3", "f_gele_57_4", Rectangle(1444, -664, 20));
		AddSpawnPoint("f_gele_57_4.Id3", "f_gele_57_4", Rectangle(1336, -580, 20));
		AddSpawnPoint("f_gele_57_4.Id3", "f_gele_57_4", Rectangle(1448, -427, 20));
		AddSpawnPoint("f_gele_57_4.Id3", "f_gele_57_4", Rectangle(1296, -473, 20));
		AddSpawnPoint("f_gele_57_4.Id3", "f_gele_57_4", Rectangle(1253, -558, 20));

		// 'Colifly_Bow' GenType 26 Spawn Points
		AddSpawnPoint("f_gele_57_4.Id4", "f_gele_57_4", Rectangle(599, 1066, 20));
		AddSpawnPoint("f_gele_57_4.Id4", "f_gele_57_4", Rectangle(361, 767, 20));
		AddSpawnPoint("f_gele_57_4.Id4", "f_gele_57_4", Rectangle(658, 882, 20));
		AddSpawnPoint("f_gele_57_4.Id4", "f_gele_57_4", Rectangle(168, 649, 20));
		AddSpawnPoint("f_gele_57_4.Id4", "f_gele_57_4", Rectangle(195, 781, 20));
		AddSpawnPoint("f_gele_57_4.Id4", "f_gele_57_4", Rectangle(-63, 314, 20));
		AddSpawnPoint("f_gele_57_4.Id4", "f_gele_57_4", Rectangle(871, 1046, 20));
		AddSpawnPoint("f_gele_57_4.Id4", "f_gele_57_4", Rectangle(-22, 630, 20));
		AddSpawnPoint("f_gele_57_4.Id4", "f_gele_57_4", Rectangle(318, 615, 20));
		AddSpawnPoint("f_gele_57_4.Id4", "f_gele_57_4", Rectangle(767, 1173, 20));
		AddSpawnPoint("f_gele_57_4.Id4", "f_gele_57_4", Rectangle(733, 1028, 20));

		// 'Zombiegirl2_Brown' GenType 27 Spawn Points
		AddSpawnPoint("f_gele_57_4.Id5", "f_gele_57_4", Rectangle(341, 633, 30));
		AddSpawnPoint("f_gele_57_4.Id5", "f_gele_57_4", Rectangle(696, 1148, 30));
		AddSpawnPoint("f_gele_57_4.Id5", "f_gele_57_4", Rectangle(694, 862, 30));
		AddSpawnPoint("f_gele_57_4.Id5", "f_gele_57_4", Rectangle(524, 1046, 30));
		AddSpawnPoint("f_gele_57_4.Id5", "f_gele_57_4", Rectangle(883, 1002, 30));
		AddSpawnPoint("f_gele_57_4.Id5", "f_gele_57_4", Rectangle(709, 994, 30));
		AddSpawnPoint("f_gele_57_4.Id5", "f_gele_57_4", Rectangle(866, 1168, 30));
		AddSpawnPoint("f_gele_57_4.Id5", "f_gele_57_4", Rectangle(188, 812, 30));

		// 'Seedmia' GenType 28 Spawn Points
		AddSpawnPoint("f_gele_57_4.Id6", "f_gele_57_4", Rectangle(1401, -1251, 200));
		AddSpawnPoint("f_gele_57_4.Id6", "f_gele_57_4", Rectangle(2374, -769, 200));
		AddSpawnPoint("f_gele_57_4.Id6", "f_gele_57_4", Rectangle(2063, -914, 200));
		AddSpawnPoint("f_gele_57_4.Id6", "f_gele_57_4", Rectangle(1375, -545, 200));

		// 'Seedmia' GenType 31 Spawn Points
		AddSpawnPoint("f_gele_57_4.Id7", "f_gele_57_4", Rectangle(-979, 1304, 20));
		AddSpawnPoint("f_gele_57_4.Id7", "f_gele_57_4", Rectangle(-1020, 1137, 20));
		AddSpawnPoint("f_gele_57_4.Id7", "f_gele_57_4", Rectangle(-1020, 1200, 20));
		AddSpawnPoint("f_gele_57_4.Id7", "f_gele_57_4", Rectangle(-950, 1149, 20));
		AddSpawnPoint("f_gele_57_4.Id7", "f_gele_57_4", Rectangle(-967, 1188, 20));
		AddSpawnPoint("f_gele_57_4.Id7", "f_gele_57_4", Rectangle(-1016, 1270, 20));
		AddSpawnPoint("f_gele_57_4.Id7", "f_gele_57_4", Rectangle(-953, 1215, 20));
		AddSpawnPoint("f_gele_57_4.Id7", "f_gele_57_4", Rectangle(-961, 1265, 20));
		AddSpawnPoint("f_gele_57_4.Id7", "f_gele_57_4", Rectangle(-1012, 1324, 20));
		AddSpawnPoint("f_gele_57_4.Id7", "f_gele_57_4", Rectangle(-1037, 1389, 20));
		AddSpawnPoint("f_gele_57_4.Id7", "f_gele_57_4", Rectangle(-969, 1342, 20));
		AddSpawnPoint("f_gele_57_4.Id7", "f_gele_57_4", Rectangle(-997, 1382, 20));
		AddSpawnPoint("f_gele_57_4.Id7", "f_gele_57_4", Rectangle(-995, 1212, 20));
		AddSpawnPoint("f_gele_57_4.Id7", "f_gele_57_4", Rectangle(-990, 1147, 20));
		AddSpawnPoint("f_gele_57_4.Id7", "f_gele_57_4", Rectangle(-944, 1288, 20));

		// 'Mallardu' GenType 32 Spawn Points
		AddSpawnPoint("f_gele_57_4.Id8", "f_gele_57_4", Rectangle(-1899, 848, 40));
		AddSpawnPoint("f_gele_57_4.Id8", "f_gele_57_4", Rectangle(-2006, 97, 40));
		AddSpawnPoint("f_gele_57_4.Id8", "f_gele_57_4", Rectangle(-1222, -272, 40));
		AddSpawnPoint("f_gele_57_4.Id8", "f_gele_57_4", Rectangle(-1224, -74, 40));
		AddSpawnPoint("f_gele_57_4.Id8", "f_gele_57_4", Rectangle(-2096, -52, 40));
		AddSpawnPoint("f_gele_57_4.Id8", "f_gele_57_4", Rectangle(-1903, -95, 40));
		AddSpawnPoint("f_gele_57_4.Id8", "f_gele_57_4", Rectangle(-1988, -184, 40));
		AddSpawnPoint("f_gele_57_4.Id8", "f_gele_57_4", Rectangle(-1883, 61, 40));
		AddSpawnPoint("f_gele_57_4.Id8", "f_gele_57_4", Rectangle(-1629, -654, 40));
		AddSpawnPoint("f_gele_57_4.Id8", "f_gele_57_4", Rectangle(-1695, -884, 40));
		AddSpawnPoint("f_gele_57_4.Id8", "f_gele_57_4", Rectangle(-1510, -964, 40));
		AddSpawnPoint("f_gele_57_4.Id8", "f_gele_57_4", Rectangle(-1475, -743, 40));
		AddSpawnPoint("f_gele_57_4.Id8", "f_gele_57_4", Rectangle(-1338, -182, 40));
		AddSpawnPoint("f_gele_57_4.Id8", "f_gele_57_4", Rectangle(-1151, -180, 40));

		// 'Rootcrystal_01' GenType 33 Spawn Points
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(-903, 86, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(-983, 469, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(-845, 803, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(-840, 1128, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(-677, 1370, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(-900, 1552, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(-924, 2049, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(-1455, 123, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(-1786, 789, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(-1563, -34, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(-1989, -25, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(-1240, -177, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(-1565, -607, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(-1846, -812, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(-86, -751, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(-120, -561, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(257, -562, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(24, -122, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(-133, 559, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(212, 711, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(453, 957, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(849, 1123, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(1134, 1307, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(1399, 1843, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(693, -497, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(1377, -536, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(1420, -1395, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(1421, -1178, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(2125, -871, 10));
		AddSpawnPoint("f_gele_57_4.Id9", "f_gele_57_4", Rectangle(2452, -791, 10));

		// 'Npanto_Archer' GenType 43 Spawn Points
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-1256, -251, 25));
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-1244, -78, 25));
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-2102, 134, 25));
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-1685, -857, 25));
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-1705, -677, 25));
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-1676, -568, 25));
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-1512, -691, 25));
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-1499, -891, 25));
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-1572, -768, 25));
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-1331, -145, 25));
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-1162, -210, 25));
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-1940, -161, 25));
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-1955, 51, 25));
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-2134, -11, 25));
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-1960, -34, 25));
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-238, -657, 25));
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-151, -570, 25));
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-102, -703, 25));
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-149, -760, 25));
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-40, -794, 25));
		AddSpawnPoint("f_gele_57_4.Id10", "f_gele_57_4", Rectangle(-1, -667, 25));

		// 'Panto_Javelin_Elite' GenType 48 Spawn Points
		AddSpawnPoint("f_gele_57_4.Id11", "f_gele_57_4", Rectangle(-1998, -38, 300));
		AddSpawnPoint("f_gele_57_4.Id11", "f_gele_57_4", Rectangle(-1582, -848, 300));
		AddSpawnPoint("f_gele_57_4.Id11", "f_gele_57_4", Rectangle(1408, -1284, 300));

		// 'Mallardu' GenType 53 Spawn Points
		AddSpawnPoint("f_gele_57_4.Id12", "f_gele_57_4", Rectangle(-853, 844, 40));
		AddSpawnPoint("f_gele_57_4.Id12", "f_gele_57_4", Rectangle(-902, 1212, 40));
		AddSpawnPoint("f_gele_57_4.Id12", "f_gele_57_4", Rectangle(-667, 1188, 40));
		AddSpawnPoint("f_gele_57_4.Id12", "f_gele_57_4", Rectangle(-648, 1380, 40));
		AddSpawnPoint("f_gele_57_4.Id12", "f_gele_57_4", Rectangle(-870, 1455, 40));
		AddSpawnPoint("f_gele_57_4.Id12", "f_gele_57_4", Rectangle(-797, 1034, 40));
		AddSpawnPoint("f_gele_57_4.Id12", "f_gele_57_4", Rectangle(-995, 1107, 40));
		AddSpawnPoint("f_gele_57_4.Id12", "f_gele_57_4", Rectangle(-909, 1701, 40));
		AddSpawnPoint("f_gele_57_4.Id12", "f_gele_57_4", Rectangle(-1012, 1395, 40));
		AddSpawnPoint("f_gele_57_4.Id12", "f_gele_57_4", Rectangle(-596, 983, 40));
		AddSpawnPoint("f_gele_57_4.Id12", "f_gele_57_4", Rectangle(-1016, 925, 40));

		// 'Npanto_Archer' GenType 54 Spawn Points
		AddSpawnPoint("f_gele_57_4.Id13", "f_gele_57_4", Rectangle(-805, 1153, 50));
		AddSpawnPoint("f_gele_57_4.Id13", "f_gele_57_4", Rectangle(-935, 1013, 50));
		AddSpawnPoint("f_gele_57_4.Id13", "f_gele_57_4", Rectangle(-891, 1349, 50));
		AddSpawnPoint("f_gele_57_4.Id13", "f_gele_57_4", Rectangle(-882, 1685, 50));
		AddSpawnPoint("f_gele_57_4.Id13", "f_gele_57_4", Rectangle(-966, 1543, 50));
		AddSpawnPoint("f_gele_57_4.Id13", "f_gele_57_4", Rectangle(-638, 1243, 50));
		AddSpawnPoint("f_gele_57_4.Id13", "f_gele_57_4", Rectangle(-937, 1204, 50));
		AddSpawnPoint("f_gele_57_4.Id13", "f_gele_57_4", Rectangle(-764, 1481, 50));
		AddSpawnPoint("f_gele_57_4.Id13", "f_gele_57_4", Rectangle(-1034, 1354, 50));
		AddSpawnPoint("f_gele_57_4.Id13", "f_gele_57_4", Rectangle(-761, 946, 50));
		AddSpawnPoint("f_gele_57_4.Id13", "f_gele_57_4", Rectangle(-578, 1140, 50));
		AddSpawnPoint("f_gele_57_4.Id13", "f_gele_57_4", Rectangle(-650, 1389, 50));

		// 'Seedmia' GenType 55 Spawn Points
		AddSpawnPoint("f_gele_57_4.Id14", "f_gele_57_4", Rectangle(-545, 1146, 20));
		AddSpawnPoint("f_gele_57_4.Id14", "f_gele_57_4", Rectangle(-543, 1210, 20));
		AddSpawnPoint("f_gele_57_4.Id14", "f_gele_57_4", Rectangle(-551, 1277, 20));
		AddSpawnPoint("f_gele_57_4.Id14", "f_gele_57_4", Rectangle(-557, 1331, 20));
		AddSpawnPoint("f_gele_57_4.Id14", "f_gele_57_4", Rectangle(-600, 1289, 20));
		AddSpawnPoint("f_gele_57_4.Id14", "f_gele_57_4", Rectangle(-580, 1232, 20));
		AddSpawnPoint("f_gele_57_4.Id14", "f_gele_57_4", Rectangle(-576, 1163, 20));
		AddSpawnPoint("f_gele_57_4.Id14", "f_gele_57_4", Rectangle(-565, 1090, 20));
		AddSpawnPoint("f_gele_57_4.Id14", "f_gele_57_4", Rectangle(-609, 1118, 20));
		AddSpawnPoint("f_gele_57_4.Id14", "f_gele_57_4", Rectangle(-606, 1206, 20));
		AddSpawnPoint("f_gele_57_4.Id14", "f_gele_57_4", Rectangle(-590, 1062, 20));
		AddSpawnPoint("f_gele_57_4.Id14", "f_gele_57_4", Rectangle(-553, 1046, 20));
		AddSpawnPoint("f_gele_57_4.Id14", "f_gele_57_4", Rectangle(-595, 1348, 20));

		// 'Seedmia' GenType 57 Spawn Points
		AddSpawnPoint("f_gele_57_4.Id15", "f_gele_57_4", Rectangle(-107, -863, 10));
		AddSpawnPoint("f_gele_57_4.Id15", "f_gele_57_4", Rectangle(-200, -845, 10));
		AddSpawnPoint("f_gele_57_4.Id15", "f_gele_57_4", Rectangle(-243, -802, 10));
		AddSpawnPoint("f_gele_57_4.Id15", "f_gele_57_4", Rectangle(-129, -872, 10));
		AddSpawnPoint("f_gele_57_4.Id15", "f_gele_57_4", Rectangle(-272, -746, 10));
		AddSpawnPoint("f_gele_57_4.Id15", "f_gele_57_4", Rectangle(-316, -668, 10));
		AddSpawnPoint("f_gele_57_4.Id15", "f_gele_57_4", Rectangle(-317, -653, 10));
		AddSpawnPoint("f_gele_57_4.Id15", "f_gele_57_4", Rectangle(-289, -547, 10));
		AddSpawnPoint("f_gele_57_4.Id15", "f_gele_57_4", Rectangle(-228, -479, 10));
		AddSpawnPoint("f_gele_57_4.Id15", "f_gele_57_4", Rectangle(-267, -506, 10));
		AddSpawnPoint("f_gele_57_4.Id15", "f_gele_57_4", Rectangle(-127, -449, 10));
		AddSpawnPoint("f_gele_57_4.Id15", "f_gele_57_4", Rectangle(-70, -452, 10));
		AddSpawnPoint("f_gele_57_4.Id15", "f_gele_57_4", Rectangle(-112, -480, 10));
		AddSpawnPoint("f_gele_57_4.Id15", "f_gele_57_4", Rectangle(-160, -470, 10));
		AddSpawnPoint("f_gele_57_4.Id15", "f_gele_57_4", Rectangle(-295, -609, 10));
		AddSpawnPoint("f_gele_57_4.Id15", "f_gele_57_4", Rectangle(-287, -572, 10));
		AddSpawnPoint("f_gele_57_4.Id15", "f_gele_57_4", Rectangle(-282, -713, 10));
		AddSpawnPoint("f_gele_57_4.Id15", "f_gele_57_4", Rectangle(-276, -781, 10));
		AddSpawnPoint("f_gele_57_4.Id15", "f_gele_57_4", Rectangle(-235, -835, 10));
		AddSpawnPoint("f_gele_57_4.Id15", "f_gele_57_4", Rectangle(-164, -874, 10));
	}
}
