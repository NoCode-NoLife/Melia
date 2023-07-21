//--- Melia Script -----------------------------------------------------------
// Novaha Institute Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'ep15_1_f_abbey_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep151FAbbey1MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep15_1_f_abbey_1", MonsterId.Ep15_1_Goblin_Chaser, Properties("MHP", 48750000, "MINPATK", 120000, "MAXPATK", 120000, "MINMATK", 120000, "MAXMATK", 120000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep15_1_f_abbey_1", MonsterId.Ep15_1_Goblin_Rider, Properties("MHP", 48750000, "MINPATK", 120000, "MAXPATK", 120000, "MINMATK", 120000, "MAXMATK", 120000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep15_1_f_abbey_1", MonsterId.Ep15_1_Pokubu_Ferocious, Properties("MHP", 48750000, "MINPATK", 120000, "MAXPATK", 120000, "MINMATK", 120000, "MAXMATK", 120000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep15_1_f_abbey_1", MonsterId.Ep15_1_Boss_Bubas, Properties("MHP", 146250000, "MINPATK", 120000, "MAXPATK", 120000, "MINMATK", 120000, "MAXMATK", 120000, "DEF", 3000000, "MDEF", 3000000));

		// Monster Spawners ---------------------------------

		AddSpawner("ep15_1_f_abbey_1.Id1", MonsterId.Ep15_1_Pokubu_Ferocious, min: 60, max: 80, respawn: TimeSpan.FromMilliseconds(10000));
		AddSpawner("ep15_1_f_abbey_1.Id2", MonsterId.Ep15_1_Goblin_Chaser, min: 60, max: 80, respawn: TimeSpan.FromMilliseconds(10000));
		AddSpawner("ep15_1_f_abbey_1.Id3", MonsterId.Ep15_1_Goblin_Rider, min: 60, max: 80, respawn: TimeSpan.FromMilliseconds(10000));

		// Monster Spawn Points -----------------------------

		// 'Ep15_1_Pokubu_Ferocious' GenType 10 Spawn Points
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1522, -752, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1474, -948, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1436, -1215, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1554, -1086, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1529, -1240, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1583, -1427, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1013, -1372, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1153, -1402, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1295, -1432, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1591, -793, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1608, -624, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1436, -578, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1462, -336, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1298, -1089, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-865, -1301, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-610, -1341, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-405, -1351, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(19, -1381, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-80, -1546, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1518, -131, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-952, -1236, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-399, -1434, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-171, -1320, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-277, -1139, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-253, -996, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1516, -307, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1530, -222, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1459, -455, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1400, -687, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1371, -789, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1586, -883, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1438, -1098, 60));

		// 'Ep15_1_Goblin_Chaser' GenType 12 Spawn Points
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(694, 42, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(576, 98, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(159, 253, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(380, 260, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(138, -100, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(728, -560, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(714, -761, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(796, -449, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-199, -798, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-188, -555, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-773, -175, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-829, 104, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-755, 206, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-1012, 222, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-825, -589, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-148, -1368, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-14, -1402, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-867, 1271, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-671, 1187, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-142, 61, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-282, 276, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-346, 119, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(445, -548, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(182, -521, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-207, 1235, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-49, 1136, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(88, 1241, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(920, -92, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(1154, -93, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(1229, 55, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(1240, 326, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(1115, 458, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(708, 540, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(910, 556, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(800, -789, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(573, -681, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(623, -503, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(732, -260, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(773, -84, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(188, 69, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-125, -166, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-282, -355, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-414, 0, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-356, -616, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-311, -536, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-369, -367, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-91, -415, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(1044, 403, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(1104, 8, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(1008, -15, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(866, 59, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(1042, 228, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(1013, 119, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(683, -408, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(804, -637, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(41, -572, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-163, -646, 60));

		// 'Ep15_1_Goblin_Rider' GenType 13 Spawn Points
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-777, -171, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-754, 263, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-1178, 293, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-819, 882, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-904, 1151, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-1095, 1232, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-47, 1264, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-767, 1294, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-918, 1394, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-951, -373, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-645, -418, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-181, -392, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-769, 112, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-217, -839, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-83, -585, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-17, -145, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-70, -393, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-823, -642, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-642, -657, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-358, -390, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-644, 84, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-805, 419, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-820, 996, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-559, 1247, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-412, -171, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-251, -110, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-209, 39, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-331, 17, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-94, 153, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-161, 225, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-611, -210, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-945, -140, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-815, -421, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-985, -577, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-920, 153, 60));
	}
}
