//--- Melia Script -----------------------------------------------------------
// Manahas Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_pilgrimroad_48'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad48MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_pilgrimroad_48.Id1", MonsterId.Rootcrystal_05, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("f_pilgrimroad_48.Id2", MonsterId.Sec_Lizardman, min: 23, max: 30);
		AddSpawner("f_pilgrimroad_48.Id3", MonsterId.Sec_Lizardman, min: 15, max: 20);
		AddSpawner("f_pilgrimroad_48.Id4", MonsterId.Sec_InfroBurk, min: 27, max: 35);
		AddSpawner("f_pilgrimroad_48.Id5", MonsterId.Sec_Operor, min: 19, max: 25);
		AddSpawner("f_pilgrimroad_48.Id6", MonsterId.Sec_Operor, min: 15, max: 20);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 3 Spawn Points
		AddSpawnPoint("f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Rectangle(-1144, -1733, 150));
		AddSpawnPoint("f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Rectangle(-663, -1411, 150));
		AddSpawnPoint("f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Rectangle(-1031, -601, 150));
		AddSpawnPoint("f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Rectangle(-1061, 77, 150));
		AddSpawnPoint("f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Rectangle(-74, -73, 150));
		AddSpawnPoint("f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Rectangle(-78, -952, 150));
		AddSpawnPoint("f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Rectangle(491, -1341, 150));
		AddSpawnPoint("f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Rectangle(200, 396, 150));
		AddSpawnPoint("f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Rectangle(1094, 103, 150));
		AddSpawnPoint("f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Rectangle(1707, 286, 150));
		AddSpawnPoint("f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Rectangle(1141, 1139, 150));
		AddSpawnPoint("f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Rectangle(342, 1141, 150));
		AddSpawnPoint("f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Rectangle(-376, 1302, 150));

		// 'Sec_Lizardman' GenType 21 Spawn Points
		AddSpawnPoint("f_pilgrimroad_48.Id2", "f_pilgrimroad_48", Rectangle(110, -1274, 200));
		AddSpawnPoint("f_pilgrimroad_48.Id2", "f_pilgrimroad_48", Rectangle(1034, 1040, 200));
		AddSpawnPoint("f_pilgrimroad_48.Id2", "f_pilgrimroad_48", Rectangle(312, 1044, 200));
		AddSpawnPoint("f_pilgrimroad_48.Id2", "f_pilgrimroad_48", Rectangle(447, -1027, 200));

		// 'Sec_Lizardman' GenType 22 Spawn Points
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-1064, -1196, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-1047, -1415, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-728, -1461, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-837, -1620, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-997, -1722, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-1119, -1584, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-1004, -1572, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-890, -1364, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-1110, -957, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-948, -21, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-810, 129, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-896, 244, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-660, 427, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-713, 326, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-813, 422, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-989, 497, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-681, 695, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-716, 538, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-1074, -1296, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-790, -1479, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-1044, -429, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-1057, -719, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-1268, -1634, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-1276, -1799, 30));
		AddSpawnPoint("f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Rectangle(-1190, -1654, 30));

		// 'Sec_InfroBurk' GenType 23 Spawn Points
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1454, -30, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1580, -60, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1506, 78, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1647, 54, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1551, 187, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1602, 386, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1657, 470, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1445, 474, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1509, 603, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1803, 156, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1452, 261, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1269, 28, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1244, 178, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1077, 178, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1033, 11, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(930, -62, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(884, 75, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1442, -117, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(835, 1000, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(925, 1147, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1009, 1025, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1157, 945, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1129, 808, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1242, 780, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1256, 1042, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1127, 1156, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1676, 222, 25));
		AddSpawnPoint("f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Rectangle(1759, 296, 25));

		// 'Sec_Operor' GenType 24 Spawn Points
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(45, 559, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(186, 494, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(118, 599, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(245, 679, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(288, 570, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(431, 533, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(494, 364, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(486, 248, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(519, 159, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(424, 281, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(470, 645, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(454, 803, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(231, 757, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(-9, 697, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(225, -1238, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(102, -1340, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(408, -1346, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(525, -1093, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(375, -979, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(-57, -1018, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(189, -973, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(463, -1244, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(591, -927, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(404, -825, 20));
		AddSpawnPoint("f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Rectangle(8, -865, 20));

		// 'Sec_Operor' GenType 25 Spawn Points
		AddSpawnPoint("f_pilgrimroad_48.Id6", "f_pilgrimroad_48", Rectangle(1075, 1019, 200));
		AddSpawnPoint("f_pilgrimroad_48.Id6", "f_pilgrimroad_48", Rectangle(-120, 1024, 200));
	}
}
