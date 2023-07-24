//--- Melia Script -----------------------------------------------------------
// Khamadon Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_bracken_42_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FBracken422MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_bracken_42_2.Id1", MonsterId.Rootcrystal_03, min: 10, max: 13, respawn: TimeSpan.FromMilliseconds(5000), tendency: TendencyType.Peaceful);
		AddSpawner("f_bracken_42_2.Id2", MonsterId.Duckey_Red, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("f_bracken_42_2.Id3", MonsterId.Moglan_Blue, min: 6, max: 8, tendency: TendencyType.Aggressive);
		AddSpawner("f_bracken_42_2.Id4", MonsterId.Beetow_Blue, min: 23, max: 30, tendency: TendencyType.Peaceful);
		AddSpawner("f_bracken_42_2.Id5", MonsterId.Beetow_Blue, min: 12, max: 15, tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 2 Spawn Points
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(-1573, 129, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(-1250, 95, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(-981, -255, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(-453, -632, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(212, -891, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(495, -853, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(758, -1121, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(1243, -818, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(1408, -662, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(-314, 159, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(495, 222, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(426, -161, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(1025, -246, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(1334, 25, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(-88, 746, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(164, 861, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(705, 790, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(985, 1092, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(1341, 1493, 50));
		AddSpawnPoint("f_bracken_42_2.Id1", "f_bracken_42_2", Rectangle(1479, 1242, 50));

		// 'Duckey_Red' GenType 101 Spawn Points
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(248, -21, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(335, -160, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(284, 171, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(434, 10, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(598, -39, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(494, 215, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(970, -170, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(953, -282, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(1112, -202, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(1270, 26, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(1310, -173, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(1244, -199, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(468, 77, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(498, -99, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(1375, -95, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(1494, -35, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(1476, -170, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(1158, -90, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(-563, -784, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(-664, -607, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(-163, -807, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(1553, -732, 35));
		AddSpawnPoint("f_bracken_42_2.Id2", "f_bracken_42_2", Rectangle(1448, -909, 35));

		// 'Moglan_Blue' GenType 103 Spawn Points
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(654, 917, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(816, 869, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(883, 1127, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(925, 821, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(912, 935, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(1093, 1027, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(1336, 1417, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(1383, 1255, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(1655, 1348, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(1439, 1537, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(1567, 1671, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(1511, 1320, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(1561, 1461, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(1003, 1037, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(1026, 922, 50));
		AddSpawnPoint("f_bracken_42_2.Id3", "f_bracken_42_2", Rectangle(829, 1011, 50));

		// 'Beetow_Blue' GenType 104 Spawn Points
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-488, -848, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-354, -732, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-326, -850, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(245, -1050, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(383, -1020, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(618, -1043, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(678, -925, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1322, -728, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1378, -974, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1222, -903, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-902, -369, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-953, -607, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-190, -797, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1594, -864, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1628, -978, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1732, -849, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1751, -715, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1634, -721, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1387, -643, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1513, -783, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(755, -988, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(732, -1119, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(550, -1210, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(505, -1112, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(514, -957, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(300, -1129, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(191, -892, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(359, -875, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(303, -750, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(386, -743, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(506, -850, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-130, -781, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-269, -747, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-621, -847, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-564, -662, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-821, -806, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-692, -648, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-877, -657, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-799, -491, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-377, -520, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-627, -488, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(-425, -655, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(967, -238, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1324, -116, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1184, -199, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1042, -306, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1002, -85, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1076, -112, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1257, -12, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(427, -138, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(344, -70, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(277, 5, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(342, 150, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(560, -30, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(467, 29, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(623, 133, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1281, 81, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1426, -167, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1475, 29, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(916, 765, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(711, 696, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1098, 1030, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1063, 875, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(909, 886, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(620, 852, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(757, 807, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(746, 951, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(828, 1085, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(923, 1087, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1333, 1189, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1635, 1462, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1526, 1220, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1493, 1557, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1444, 1355, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1818, 1405, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1297, 1420, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1622, 1609, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1347, 1579, 30));
		AddSpawnPoint("f_bracken_42_2.Id4", "f_bracken_42_2", Rectangle(1510, 1710, 30));

		// 'Beetow_Blue' GenType 105 Spawn Points
		AddSpawnPoint("f_bracken_42_2.Id5", "f_bracken_42_2", Rectangle(296, 79, 9999));
	}
}
