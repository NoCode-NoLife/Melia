//--- Melia Script -----------------------------------------------------------
// Syla Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_whitetrees_23_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FWhitetrees233MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_whitetrees_23_3.Id1", MonsterId.Rootcrystal_03, 9, 12, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_3.Id2", MonsterId.Kucarry_Numani, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_3.Id3", MonsterId.Kucarry_Numani, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_3.Id4", MonsterId.Kucarry_Zabbi, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_3.Id5", MonsterId.Kucarry_Zeuni, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_3.Id6", MonsterId.Kucarry_Zabbi, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_3.Id7", MonsterId.Kucarry_Zeuni, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 4 Spawn Points
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(196, -1029, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(28, -1348, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(-524, -1280, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(-846, -1154, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(-46, -582, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(73, -142, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(429, -284, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(902, -381, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(1356, -435, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(138, 420, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(731, 436, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(1159, 543, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(135, 931, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(383, 1218, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(776, 1273, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(1159, 1166, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(-426, 312, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(-857, 444, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(-424, 1106, 50));
		AddSpawnPoint("f_whitetrees_23_3.Id1", "f_whitetrees_23_3", Rectangle(-1612, -395, 50));

		// 'Kucarry_Numani' GenType 100 Spawn Points
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-1796, -453, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-1638, -331, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-1589, -152, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-1715, -265, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-820, 336, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-662, 399, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-782, 617, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-554, 209, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-690, 222, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-616, 677, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-835, 483, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-607, 531, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-647, 1065, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-755, 1148, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-488, 1340, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-613, 1411, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-458, 1083, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-644, 1318, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-562, 1167, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-465, 1233, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-342, 1085, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-339, 1263, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-537, 344, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-670, 454, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-1691, -455, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id2", "f_whitetrees_23_3", Rectangle(-1514, -278, 40));

		// 'Kucarry_Numani' GenType 103 Spawn Points
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(161, 1222, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(411, 1177, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(466, 1040, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(301, 1122, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(336, 969, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(153, 1014, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(-102, 495, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(-62, 612, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(31, 677, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(85, 521, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(115, 407, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(190, 507, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(706, 642, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(882, 767, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(895, 635, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(804, 430, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(1032, 333, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(1101, 528, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id3", "f_whitetrees_23_3", Rectangle(991, 460, 40));

		// 'Kucarry_Zabbi' GenType 104 Spawn Points
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(1009, -430, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(1068, -327, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(1153, -138, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(1374, -267, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(1127, -529, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(1209, -401, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(1301, -505, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(1286, -171, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(1210, -306, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(873, -333, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(6, -616, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(-162, -388, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(107, -105, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(192, -272, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id4", "f_whitetrees_23_3", Rectangle(-13, -468, 40));

		// 'Kucarry_Zeuni' GenType 105 Spawn Points
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-732, -1319, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-660, -1243, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-858, -1081, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-810, -997, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-579, -1146, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-189, -1200, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(43, -1116, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(211, -1239, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-1, -1383, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(137, -988, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-34, -738, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-156, -468, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(227, -289, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(57, -502, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(352, -323, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-1795, -387, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-1607, -261, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(2, -612, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-194, -360, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(223, -427, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(74, -88, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(-4, -179, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(861, -291, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(1186, -283, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(1046, -203, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(1227, -481, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(1337, -277, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(29, -904, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(114, -1197, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(119, -1289, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id5", "f_whitetrees_23_3", Rectangle(86, -399, 40));

		// 'Kucarry_Zabbi' GenType 106 Spawn Points
		AddSpawnPoint("f_whitetrees_23_3.Id6", "f_whitetrees_23_3", Rectangle(124, -402, 9999));

		// 'Kucarry_Zeuni' GenType 107 Spawn Points
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(691, 1221, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(803, 1348, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(824, 1182, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(905, 1306, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(944, 1176, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(1131, 1301, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(873, 985, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(926, 782, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(802, 718, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(715, 483, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(888, 520, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(1013, 683, 40));
		AddSpawnPoint("f_whitetrees_23_3.Id7", "f_whitetrees_23_3", Rectangle(954, 348, 40));
	}
}
