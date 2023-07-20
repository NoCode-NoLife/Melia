//--- Melia Script -----------------------------------------------------------
// Zeteor Coast Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_coral_44_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCoral441MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_coral_44_1.Id1", MonsterId.Gob, 57, 75, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_coral_44_1.Id2", MonsterId.VarleFloater, 35, 46, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_44_1.Id3", MonsterId.Afisher, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_coral_44_1.Id4", MonsterId.NimrahDamsel, 35, 46, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_44_1.Id5", MonsterId.Rootcrystal_03, 23, 30, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Gob' GenType 13 Spawn Points
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1175, 520, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1246, 324, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1148, 321, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1192, 209, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1056, 198, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1283, 113, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1119, 113, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1060, -86, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1017, -21, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1031, -174, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1122, -241, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1250, -267, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1523, -329, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1604, -443, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1648, -374, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1656, -232, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1683, -135, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1648, -40, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1628, 59, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1711, -620, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1681, -707, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-617, 157, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-574, 44, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-627, -60, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-534, -133, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-640, -337, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-482, -322, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-627, -466, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-494, -462, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-613, -639, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-643, -1064, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-706, -1183, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-872, -1203, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-944, -1311, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1503, -1323, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1571, -1242, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1591, -1154, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1474, -1229, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1572, -1067, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-89, -886, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-208, -740, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-176, -892, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-105, -728, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-47, -393, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-70, -553, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(77, -470, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1615, -536, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1790, -556, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1625, -299, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1109, 259, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1329, 275, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-776, -1385, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1531, -1184, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1269, -1268, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-655, 26, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-532, -35, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-542, 172, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-592, -261, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-546, -241, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-529, -393, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1286, 201, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1118, 174, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1001, 406, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-917, 299, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-791, 251, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1086, -150, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1552, -391, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1689, -500, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(-1734, -397, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(83, -819, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(135, -628, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(258, -772, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(328, -640, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(0, -743, 40));
		AddSpawnPoint("f_coral_44_1.Id1", "f_coral_44_1", Rectangle(259, -541, 40));

		// 'VarleFloater' GenType 14 Spawn Points
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(144, 563, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(84, 622, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(304, 622, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(353, 714, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(174, 687, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(240, 808, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(373, 1046, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(153, 1081, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(319, 1240, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(341, 1142, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(-138, 961, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(-317, 984, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(-158, 1109, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(454, 638, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(599, 531, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(763, 803, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(767, 1008, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(956, 1029, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(849, 1180, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(-127, -814, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(-135, -609, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(32, -449, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(110, -378, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(209, -472, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(22, -641, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(724, -183, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(754, -114, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(945, -2, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(981, 110, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(1036, -18, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(991, 223, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(1129, 313, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(1063, -150, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(-555, -1128, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(-528, -1232, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(-666, -1343, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(-886, -1379, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(-1251, -1358, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(-1166, -1248, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(-634, -876, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(-368, -970, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(17, -867, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(171, -917, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(1382, -1031, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(1562, -1125, 40));
		AddSpawnPoint("f_coral_44_1.Id2", "f_coral_44_1", Rectangle(1550, -946, 40));

		// 'Afisher' GenType 15 Spawn Points
		AddSpawnPoint("f_coral_44_1.Id3", "f_coral_44_1", Rectangle(1508, -1030, 40));
		AddSpawnPoint("f_coral_44_1.Id3", "f_coral_44_1", Rectangle(657, -1090, 40));
		AddSpawnPoint("f_coral_44_1.Id3", "f_coral_44_1", Rectangle(1286, 259, 40));
		AddSpawnPoint("f_coral_44_1.Id3", "f_coral_44_1", Rectangle(987, 48, 40));
		AddSpawnPoint("f_coral_44_1.Id3", "f_coral_44_1", Rectangle(26, -757, 40));
		AddSpawnPoint("f_coral_44_1.Id3", "f_coral_44_1", Rectangle(134, -600, 40));
		AddSpawnPoint("f_coral_44_1.Id3", "f_coral_44_1", Rectangle(259, 729, 40));
		AddSpawnPoint("f_coral_44_1.Id3", "f_coral_44_1", Rectangle(-209, 1011, 40));
		AddSpawnPoint("f_coral_44_1.Id3", "f_coral_44_1", Rectangle(271, 1044, 40));
		AddSpawnPoint("f_coral_44_1.Id3", "f_coral_44_1", Rectangle(897, 1079, 40));
		AddSpawnPoint("f_coral_44_1.Id3", "f_coral_44_1", Rectangle(-768, -1263, 40));

		// 'NimrahDamsel' GenType 16 Spawn Points
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(650, -987, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(551, -1096, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(553, -1213, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(670, -1180, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(777, -1093, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(1085, -974, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(1179, -993, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(1100, -561, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(1162, -495, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(972, -401, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(1029, -273, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(1194, -327, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(1081, -409, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(1441, -1068, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(1622, -1031, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(1223, -242, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(1303, 120, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(1405, 39, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(1425, 191, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(1330, 319, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(1510, 233, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(208, -813, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(139, -704, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(285, -718, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(348, -530, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(378, -636, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(105, 695, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(253, 659, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(-246, 937, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(-272, 1058, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(237, 1140, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(813, 1076, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(686, 1147, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(788, 1225, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(1441, 284, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(525, -414, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(618, -295, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(1518, -970, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(-97, 586, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(638, 650, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(978, 15, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(947, 272, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(647, -1090, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(931, 126, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(1236, -375, 40));
		AddSpawnPoint("f_coral_44_1.Id4", "f_coral_44_1", Rectangle(1241, 230, 40));

		// 'Rootcrystal_03' GenType 17 Spawn Points
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(-1438, 806, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(-1125, 497, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(-572, 222, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(-576, -93, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(-545, -429, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(-594, -685, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(-817, -1232, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(-583, -1193, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(-1318, -1299, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(-1597, -1212, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(-1715, -504, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(-1639, 55, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(-1617, -236, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(-1204, -254, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(-1144, 186, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(-201, -791, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(128, -458, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(688, -151, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(979, 90, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(69, 679, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(426, 694, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(-278, 1063, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(279, 1113, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(825, 1029, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(1335, 258, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(1483, 164, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(1175, -543, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(1094, -210, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(1385, -276, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(1657, -1090, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(1438, -1007, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(1203, -978, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(720, -1070, 50));
		AddSpawnPoint("f_coral_44_1.Id5", "f_coral_44_1", Rectangle(512, -1174, 50));
	}
}
