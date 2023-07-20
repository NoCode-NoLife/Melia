//--- Melia Script -----------------------------------------------------------
// Royal Mausoleum Workers Lodge Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_underfortress_59_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DUnderfortress591MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_underfortress_59_1.Id1", MonsterId.FD_Woodgoblin_Black, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_1.Id2", MonsterId.FD_Bushspider_Purple, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_1.Id3", MonsterId.FD_Pappus_Kepa_Purple, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_1.Id4", MonsterId.FD_Boss_Templeshooter, 0, 0, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_1.Id5", MonsterId.Rootcrystal_03, 14, 18, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_underfortress_59_1.Id6", MonsterId.FD_Woodgoblin_Black, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_1.Id7", MonsterId.FD_Bushspider_Purple, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_1.Id8", MonsterId.FD_Pappus_Kepa_Purple, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_1.Id9", MonsterId.FD_Colimen, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'FD_Woodgoblin_Black' GenType 10 Spawn Points
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(988, 155, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(733, -831, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-1171, -836, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(452, 2, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(18, -856, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-516, -1504, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(857, 1070, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-1051, -1424, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-540, -867, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-440, 457, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-590, 995, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-50, 1010, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-868, 1373, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(34, -1371, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(594, -946, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(1129, -712, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(1215, -1143, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-958, -798, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-1125, -1584, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-580, -1417, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-425, -814, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(464, 282, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(628, -89, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(457, -228, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(972, -173, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(1109, 467, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(601, 1399, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(799, 1595, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(1207, 1401, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(855, 1264, 100));
		AddSpawnPoint("d_underfortress_59_1.Id1", "d_underfortress_59_1", Rectangle(-232, 997, 100));

		// 'FD_Bushspider_Purple' GenType 19 Spawn Points
		AddSpawnPoint("d_underfortress_59_1.Id2", "d_underfortress_59_1", Rectangle(218, 51, 9999));

		// 'FD_Pappus_Kepa_Purple' GenType 20 Spawn Points
		AddSpawnPoint("d_underfortress_59_1.Id3", "d_underfortress_59_1", Rectangle(197, 98, 9999));

		// 'FD_Boss_Templeshooter' GenType 23 Spawn Points
		AddSpawnPoint("d_underfortress_59_1.Id4", "d_underfortress_59_1", Rectangle(-230, 1610, 20));

		// 'Rootcrystal_03' GenType 26 Spawn Points
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(42, -115, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(74, 239, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-388, 349, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-390, 638, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(31, 673, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(37, 985, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-405, 1494, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-117, 1318, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-316, 1301, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-940, 955, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-932, 1427, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(531, -230, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(535, 120, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(1003, -237, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(991, 28, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(993, 317, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(971, 1068, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(751, 1099, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(732, -815, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(893, -801, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(1067, -787, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(171, -1336, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(85, -834, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-534, -923, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-947, -793, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-942, -1383, 200));
		AddSpawnPoint("d_underfortress_59_1.Id5", "d_underfortress_59_1", Rectangle(-565, -1519, 200));

		// 'FD_Woodgoblin_Black' GenType 28 Spawn Points
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(46, 94, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(74, -167, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(94, -1375, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(-50, -88, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(14, 250, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(612, -800, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(971, -776, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(35, -972, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(60, -1475, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(135, 13, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(32, -498, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(11, 104, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(32, -316, 40));
		AddSpawnPoint("d_underfortress_59_1.Id6", "d_underfortress_59_1", Rectangle(116, -809, 40));

		// 'FD_Bushspider_Purple' GenType 29 Spawn Points
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(22, -249, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(87, 259, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(-796, 1115, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(945, -78, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(970, 233, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(763, -788, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(553, -1325, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(766, -1253, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(1008, -1499, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(1242, -1282, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(1018, 667, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(1070, -147, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(490, -49, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(1000, -1223, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(-251, 1026, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(1109, 322, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(-916, 984, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(-996, 1459, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(-502, 470, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(-929, 1367, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(325, -2, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(456, -238, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(1103, -233, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(574, -837, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(1020, -733, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(758, -1492, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(550, -1537, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(1189, -1520, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(6, -905, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(79, -711, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(-7, -419, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(-555, 1011, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(-421, 629, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(-383, 419, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(28, -1344, 40));
		AddSpawnPoint("d_underfortress_59_1.Id7", "d_underfortress_59_1", Rectangle(40, 1002, 40));

		// 'FD_Pappus_Kepa_Purple' GenType 30 Spawn Points
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(-693, 1028, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(-344, 948, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(839, 1090, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(-416, 457, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(21, -823, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(-410, 653, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(461, 328, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(131, 246, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(-39, 196, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(-46, 999, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(1162, 1412, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(489, 1438, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(848, 1565, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(993, 224, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(459, -233, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(536, 56, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(37, -42, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(37, -206, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(1074, -218, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(1034, 58, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(1084, 426, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(673, 973, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(-935, 948, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(-847, 1390, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(-1068, 1399, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(-185, 1054, 40));
		AddSpawnPoint("d_underfortress_59_1.Id8", "d_underfortress_59_1", Rectangle(853, 1334, 40));

		// 'FD_Colimen' GenType 36 Spawn Points
		AddSpawnPoint("d_underfortress_59_1.Id9", "d_underfortress_59_1", Rectangle(547, 1, 9999));
	}
}
