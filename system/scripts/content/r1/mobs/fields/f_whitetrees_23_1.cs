//--- Melia Script -----------------------------------------------------------
// Emmet Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_whitetrees_23_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FWhitetrees231MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_whitetrees_23_1", MonsterId.Kucarry_Somy, Properties("MHP", 545736, "MINPATK", 7519, "MAXPATK", 9142, "MINMATK", 7519, "MAXMATK", 9142, "DEF", 100554, "MDEF", 100554));
		AddPropertyOverrides("f_whitetrees_23_1", MonsterId.Kucarry_Tot, Properties("MHP", 548433, "MINPATK", 7553, "MAXPATK", 9185, "MINMATK", 7553, "MAXMATK", 9185, "DEF", 101887, "MDEF", 101887));
		AddPropertyOverrides("f_whitetrees_23_1", MonsterId.Kucarry_Lioni, Properties("MHP", 551235, "MINPATK", 7589, "MAXPATK", 9229, "MINMATK", 7589, "MAXMATK", 9229, "DEF", 103273, "MDEF", 103273));

		// Monster Spawners ---------------------------------

		AddSpawner("f_whitetrees_23_1.Id1", MonsterId.Rootcrystal_03, min: 11, max: 14, respawn: TimeSpan.FromMilliseconds(5000));
		AddSpawner("f_whitetrees_23_1.Id2", MonsterId.Kucarry_Somy, min: 12, max: 15);
		AddSpawner("f_whitetrees_23_1.Id3", MonsterId.Kucarry_Somy, min: 12, max: 15);
		AddSpawner("f_whitetrees_23_1.Id4", MonsterId.Kucarry_Tot, min: 12, max: 15);
		AddSpawner("f_whitetrees_23_1.Id5", MonsterId.Kucarry_Lioni, min: 6, max: 8);
		AddSpawner("f_whitetrees_23_1.Id6", MonsterId.Kucarry_Lioni, min: 12, max: 15);
		AddSpawner("f_whitetrees_23_1.Id7", MonsterId.Kucarry_Somy, min: 6, max: 8);
		AddSpawner("f_whitetrees_23_1.Id8", MonsterId.Kucarry_Tot, min: 23, max: 30);
		AddSpawner("f_whitetrees_23_1.Id9", MonsterId.Kucarry_Lioni, min: 10, max: 13);
		AddSpawner("f_whitetrees_23_1.Id10", MonsterId.Kucarry_Somy, min: 9, max: 12);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 5 Spawn Points
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(1474, 1235, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(1045, 1323, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(604, 1230, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(237, 1431, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-629, 1159, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-881, 1134, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(393, 764, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(423, 336, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-52, 409, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(977, 505, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(1411, 432, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-688, 240, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-902, 491, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-1252, 494, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-1030, -58, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-1175, -454, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-1514, -187, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-292, -1342, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-625, -1081, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(34, -1065, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(690, -1073, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(462, -553, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(1938, -652, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(1475, -677, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(1087, -290, 50));

		// 'Kucarry_Somy' GenType 100 Spawn Points
		AddSpawnPoint("f_whitetrees_23_1.Id2", "f_whitetrees_23_1", Rectangle(-760, -1152, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id2", "f_whitetrees_23_1", Rectangle(-547, -1349, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id2", "f_whitetrees_23_1", Rectangle(-575, -978, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id2", "f_whitetrees_23_1", Rectangle(-310, -1188, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id2", "f_whitetrees_23_1", Rectangle(-190, -1284, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id2", "f_whitetrees_23_1", Rectangle(-151, -1113, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id2", "f_whitetrees_23_1", Rectangle(-5, -1183, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id2", "f_whitetrees_23_1", Rectangle(69, -991, 40));

		// 'Kucarry_Somy' GenType 101 Spawn Points
		AddSpawnPoint("f_whitetrees_23_1.Id3", "f_whitetrees_23_1", Rectangle(1000, 506, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id3", "f_whitetrees_23_1", Rectangle(1042, 370, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id3", "f_whitetrees_23_1", Rectangle(1176, 285, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id3", "f_whitetrees_23_1", Rectangle(1270, 436, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id3", "f_whitetrees_23_1", Rectangle(1358, 308, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id3", "f_whitetrees_23_1", Rectangle(1503, 340, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id3", "f_whitetrees_23_1", Rectangle(1143, 530, 40));

		// 'Kucarry_Tot' GenType 102 Spawn Points
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-1413, -165, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-1365, -477, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-1238, -496, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-1525, -307, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-1064, -440, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-1204, 40, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-992, -143, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-1017, -345, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-845, -258, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-752, 62, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-751, 290, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-667, 650, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-342, 262, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-147, 368, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-91, 731, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-87, 453, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(155, 278, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(159, 568, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(316, 438, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(433, 629, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(378, 823, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(780, 435, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(500, 323, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(92, 931, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-225, 588, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-621, 198, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-455, 239, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-644, 486, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-628, 355, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-1337, -316, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-1131, -323, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-1145, -158, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(60, 573, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(252, 733, 40));

		// 'Kucarry_Lioni' GenType 105 Spawn Points
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(589, 1273, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(354, 1562, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(1305, 1249, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(77, 1403, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(404, 1169, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(273, 1276, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(1101, 1279, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(370, 1440, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(1161, 1122, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(1105, 1484, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(894, 1331, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(1436, 1389, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(1471, 1216, 40));

		// 'Kucarry_Lioni' GenType 106 Spawn Points
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-1306, 390, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-1164, 336, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-1213, 525, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-1009, 313, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-1024, 429, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-926, 336, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-904, 459, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-1084, 642, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-947, 587, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-954, 1432, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-987, 1346, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-853, 1280, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-898, 1146, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-782, 1120, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-660, 1296, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-643, 1188, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-532, 1409, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-557, 1260, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-376, 1263, 40));

		// 'Kucarry_Somy' GenType 107 Spawn Points
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(-1262, 385, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(-1143, 435, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(-1037, 617, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(-913, 512, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(-1002, 466, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(-1122, 282, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(-905, 332, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(349, 1469, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(1161, 1456, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(249, 1222, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(1136, 1263, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(421, 1196, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(828, 1304, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(142, 1437, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(598, 1220, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(46, 968, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(368, 1591, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(1041, 1137, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(1417, 1211, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(1330, 1388, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(1056, 1411, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(442, 1295, 40));

		// 'Kucarry_Tot' GenType 108 Spawn Points
		AddSpawnPoint("f_whitetrees_23_1.Id8", "f_whitetrees_23_1", Rectangle(294, -423, 9999));

		// 'Kucarry_Lioni' GenType 109 Spawn Points
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(-299, -1200, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(-218, -1065, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(22, -987, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(-43, -1191, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(138, -1285, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(-671, -1054, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(-577, -1326, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(-409, -895, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(7, -819, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(274, -613, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(488, -320, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(489, -622, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(429, -535, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(123, -587, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(444, -472, 40));

		// 'Kucarry_Somy' GenType 110 Spawn Points
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(981, -532, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(900, -347, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(1431, -718, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(1612, -482, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(1819, -680, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(885, -477, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(1668, -823, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(1275, -798, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(1080, -244, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(1687, -586, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(1584, -627, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(1010, -381, 40));
	}
}
