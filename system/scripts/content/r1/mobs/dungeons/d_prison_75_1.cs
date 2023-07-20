//--- Melia Script -----------------------------------------------------------
// Narcon Prison Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_prison_75_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DPrison751MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_prison_75_1.Id1", MonsterId.ERD_Stoulet_Bow, 10, 13, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id2", MonsterId.ERD_Escape_Wendigo, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id3", MonsterId.ERD_Stoulet, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id4", MonsterId.ERD_Colifly_Black, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id5", MonsterId.ERD_Socket, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id6", MonsterId.ERD_Chromadog, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id7", MonsterId.ERD_Socket_Bow, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id8", MonsterId.ERD_Stoulet_Mage, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id9", MonsterId.ERD_InfroRocktor_Red, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id10", MonsterId.ERD_New_Desmodus_Black, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id11", MonsterId.ERD_Zigri, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id12", MonsterId.ERD_Hook, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id13", MonsterId.Rootcrystal_01, 19, 25, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'ERD_Stoulet_Bow' GenType 1 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1447, -103, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1375, 96, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1175, -69, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1189, -100, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1408, 18, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1583, -126, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1320, -248, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1057, 177, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1531, 220, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1207, 283, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1268, -98, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1112, -255, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1050, -53, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-904, -64, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-702, 130, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-628, -63, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-504, 90, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-466, -56, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-483, -145, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-672, -160, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-752, 109, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-465, 178, 30));

		// 'ERD_Escape_Wendigo' GenType 2 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id2", "d_prison_75_1", Rectangle(-480, -87, 9999));

		// 'ERD_Stoulet' GenType 3 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-50, -799, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-208, -871, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-139, -1012, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-110, -1082, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(128, -906, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-20, -966, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(119, -823, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-158, 657, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-113, 856, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-113, 856, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-179, 738, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-11, 717, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-17, 565, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(23, 854, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-175, 564, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-336, 672, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-508, 708, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-587, 676, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(36, 399, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-7, 268, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(49, 81, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-30, 0, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(28, -116, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(34, -411, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-5, -286, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(63, -314, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-12, -498, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(6, -602, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(72, -713, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-117, -735, 30));

		// 'ERD_Colifly_Black' GenType 4 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id4", "d_prison_75_1", Rectangle(-145, -1323, 9999));

		// 'ERD_Socket' GenType 5 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(13, -1431, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-70, -1327, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-337, -1452, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(13, -1589, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-153, -1443, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(41, -1300, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-611, -1528, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-779, -1539, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-849, -1192, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-515, -1238, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-474, -1149, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-552, -1312, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-692, -1362, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-856, -1296, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-575, -1176, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-677, -1228, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-308, -1589, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-337, -1323, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-710, -1147, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-877, -1451, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-896, -1566, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-460, -1307, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-635, -1553, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-229, -1447, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-182, -1297, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-15, -1544, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(115, -1414, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(140, -1548, 30));

		// 'ERD_Chromadog' GenType 6 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1387, -622, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1587, -699, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1757, -629, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1706, -714, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1746, -545, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1563, -599, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1405, -480, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1343, -697, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1225, -714, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1188, -548, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1198, -450, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1259, -404, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1390, -387, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1496, -405, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1593, -525, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1698, -524, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1768, -442, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1665, -624, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(-808, 1334, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1489, -739, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1285, -565, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1425, -783, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1632, -757, 30));

		// 'ERD_Socket_Bow' GenType 7 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1459, -21, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1496, 90, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1548, -162, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1689, -159, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1812, 210, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1771, -58, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(2019, 211, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1913, -1, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(2018, -171, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1675, 84, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1324, 160, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1280, -156, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1294, 22, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1634, 253, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1472, 225, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(2024, 32, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(938, 11, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(747, -39, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(597, -33, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(614, 103, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(746, 58, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(661, 218, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(776, 202, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(883, -26, 40));

		// 'ERD_Stoulet_Mage' GenType 8 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1406, -119, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1524, -2, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1409, 132, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1690, 171, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1707, 27, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1803, -133, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1928, -189, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1943, -23, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(2006, 162, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(595, -66, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(547, 36, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(731, -15, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(627, 178, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(688, 267, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(766, 97, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(905, 47, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(729, -148, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(583, -216, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(666, -235, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(730, -252, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(537, 84, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(594, 286, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(857, -52, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(657, 408, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(707, 482, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(599, 579, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(620, 700, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(807, 648, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(777, 806, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(647, 787, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(621, 890, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(750, 712, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1092, -7, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1266, 128, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1261, 0, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1255, -129, 30));

		// 'ERD_InfroRocktor_Red' GenType 9 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-620, 1161, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-679, 1315, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-744, 1287, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1022, 1326, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-757, 1210, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-709, 1082, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-508, 1144, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-508, 1144, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-396, 1231, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-815, 1322, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-929, 1301, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1202, 1251, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1342, 1181, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1413, 1261, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1283, 1395, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1126, 1420, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1158, 1333, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1305, 1294, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1100, 1130, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1239, 1140, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1432, 1387, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1175, 1392, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-576, 1355, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-401, 1333, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-488, 1259, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-557, 1045, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-504, 1376, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-432, 1417, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-768, 1073, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-563, 1248, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1411, 1097, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1125, 1206, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1137, -233, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1038, 57, 40));

		// 'ERD_New_Desmodus_Black' GenType 10 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1551, -215, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1629, -56, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1510, 210, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1269, 144, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1322, -174, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1289, 43, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1187, 194, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1071, -6, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1135, -228, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1048, -126, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1061, 164, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1372, -55, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1248, 415, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1115, 562, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1247, 543, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1212, 840, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1159, 925, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1358, 1094, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1229, 722, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-967, 707, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-853, 733, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-694, 677, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-608, 742, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-517, 691, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-486, 620, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-599, 643, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-899, 601, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1060, 680, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-741, 648, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1207, 628, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1165, 491, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1130, 696, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-842, 674, 40));

		// 'ERD_Zigri' GenType 11 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(677, -1590, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(760, -1339, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(874, -1321, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(987, -1424, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(907, -1514, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(887, -1647, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(1000, -1642, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(1132, -1585, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(799, -1715, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(662, -771, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(764, -1551, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(843, -1423, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(1033, -1297, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(657, -1491, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(793, -1477, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(893, -1596, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(663, -1694, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(1068, -1704, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(943, -1260, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(675, -1204, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(719, -1129, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(701, -1031, 40));

		// 'ERD_Hook' GenType 12 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(657, -1175, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(734, -1169, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(685, -1069, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(734, -967, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(593, -968, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(442, -1020, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(265, -966, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(361, -942, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(261, -896, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(537, -883, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(737, -849, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(671, -774, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(706, -708, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(663, -639, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(741, -503, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(701, -417, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(700, -252, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(671, -200, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(595, -231, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(676, -485, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(706, -932, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(459, -906, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(529, -978, 40));

		// 'Rootcrystal_01' GenType 14 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(-1019, 707, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(-1315, -29, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(-1217, 1316, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(-474, 1320, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(4, 705, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(68, 107, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(24, -541, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(-54, -915, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(-654, -1174, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(-88, -1439, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(894, -1524, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(666, -725, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(698, 55, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(678, 765, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(1459, -9, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(1786, 260, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(1533, -656, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(1289, -681, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(-521, -112, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(-1185, 594, 200));
	}
}
