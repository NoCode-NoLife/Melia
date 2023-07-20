//--- Melia Script -----------------------------------------------------------
// Alemeth Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_orchard_34_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FOrchard341MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_orchard_34_1.Id1", MonsterId.Eldigo_Green, 45, 60, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_orchard_34_1.Id2", MonsterId.Eldigo_Green, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_orchard_34_1.Id3", MonsterId.Truffle_Red, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_orchard_34_1.Id4", MonsterId.Corpse_Flower_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_orchard_34_1.Id5", MonsterId.Rootcrystal_01, 9, 12, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Eldigo_Green' GenType 8 Spawn Points
		AddSpawnPoint("f_orchard_34_1.Id1", "f_orchard_34_1", Rectangle(-133, -699, 9999));

		// 'Eldigo_Green' GenType 9 Spawn Points
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(167, -1347, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(266, -1239, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(84, -1281, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(376, -1140, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(552, -972, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(824, -885, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(732, -983, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(680, -844, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(-1376, -1530, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(-1312, -1385, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(-1378, -1132, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(-1164, -1530, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(-1066, -1342, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(-1262, -1604, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(-1189, -1321, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(-319, -1025, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(-256, -1185, 30));
		AddSpawnPoint("f_orchard_34_1.Id2", "f_orchard_34_1", Rectangle(-1487, -1263, 30));

		// 'Truffle_Red' GenType 10 Spawn Points
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1510, 358, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1446, 474, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1187, 220, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-909, 346, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-656, 587, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1179, 1003, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1224, 821, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1072, 850, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-720, 658, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-541, 800, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-271, 1296, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-430, 1387, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-223, 321, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-374, 370, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-424, 502, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-231, 474, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1253, -56, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1055, 82, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1550, 482, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1391, 323, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1496, -662, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1360, -435, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1413, -608, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1247, -587, 30));
		AddSpawnPoint("f_orchard_34_1.Id3", "f_orchard_34_1", Rectangle(-1314, -329, 30));

		// 'Corpse_Flower_Green' GenType 11 Spawn Points
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-1236, -1650, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-1458, -1398, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-994, -1176, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-1118, -1610, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-1228, -1263, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-1393, -961, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-1414, -519, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-1298, -415, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-1300, -197, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-1233, -185, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-933, 327, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-831, 484, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-718, 392, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(226, -144, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(712, 297, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(372, -254, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(552, 33, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(459, 70, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(572, 250, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(681, 20, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(411, -166, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(785, 419, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(175, -223, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(255, -429, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-8, -516, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(47, -669, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-340, -912, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-182, -992, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-334, -1142, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-862, -1725, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-1370, -1556, 30));
		AddSpawnPoint("f_orchard_34_1.Id4", "f_orchard_34_1", Rectangle(-194, -1289, 30));

		// 'Rootcrystal_01' GenType 12 Spawn Points
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(892, -898, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(639, -965, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(358, -1299, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(166, -1419, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-184, -1246, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-237, -992, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-23, -714, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(267, -243, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(353, -10, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(709, 150, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(795, 315, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(185, 264, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-639, -1473, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-373, 419, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-959, -1688, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-755, -1318, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-1281, -1558, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-1386, -1284, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-1366, -669, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-1370, -485, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-1256, -125, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-1121, 196, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-774, 513, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-643, 693, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-291, 1075, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-386, 1237, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-1512, 288, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-1382, 421, 100));
		AddSpawnPoint("f_orchard_34_1.Id5", "f_orchard_34_1", Rectangle(-1211, 879, 100));
	}
}
