//--- Melia Script -----------------------------------------------------------
// Timerys Temple Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'id_catacomb_25_4'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class IdCatacomb254MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("id_catacomb_25_4.Id1", MonsterId.Pagclamper_Yellow, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("id_catacomb_25_4.Id2", MonsterId.PagDoper_Blue, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("id_catacomb_25_4.Id3", MonsterId.PagNurse_Green, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("id_catacomb_25_4.Id4", MonsterId.Pagshearer_Yellow, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("id_catacomb_25_4.Id5", MonsterId.Rootcrystal_02, min: 19, max: 25, respawn: TimeSpan.FromMilliseconds(30000), tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Pagclamper_Yellow' GenType 22 Spawn Points
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(1022, 955, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(842, 939, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(727, 935, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(590, 922, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(482, 971, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(500, 705, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(597, 732, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(563, 624, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(280, 674, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(287, 874, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(87, 886, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(118, 691, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-72, 697, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-118, 896, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(202, 800, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(17, 801, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-432, 723, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-336, 746, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-673, 728, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-835, 750, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-912, 678, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-668, 608, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-877, 437, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-790, 512, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-939, 838, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1220, 611, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1144, 552, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1858, 439, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1733, 467, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1596, 430, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1523, 509, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1689, 642, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1719, 813, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1534, 667, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1907, 658, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1932, 827, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1819, 726, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1475, 779, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(305, 134, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(233, 31, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(293, 368, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(120, 347, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-79, 447, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(161, -596, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(258, -429, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(130, -412, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-138, -263, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(274, -205, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-130, -509, 40));

		// 'PagDoper_Blue' GenType 24 Spawn Points
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(47, -878, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-92, -897, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(204, -853, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(258, -1080, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(75, -657, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(256, -619, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(274, -323, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(65, -546, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-23, -183, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(217, -128, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(233, 98, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-93, 93, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(160, 437, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(21, 458, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-321, 369, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(213, 345, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(54, 297, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(112, -245, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-29, -304, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-50, -573, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-135, 351, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(315, 465, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-370, 474, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-457, 400, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-799, 352, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-700, 384, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-916, 538, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-741, 773, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-526, 708, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-677, 494, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-799, 645, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(4, -692, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(878, -744, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-133, -1082, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(850, -549, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(985, -361, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(1033, -239, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(1078, -613, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(992, -749, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(822, -845, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(949, -623, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(981, -498, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(880, -339, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(714, -578, 40));

		// 'PagNurse_Green' GenType 25 Spawn Points
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-927, -512, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-846, -323, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-702, -182, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-834, -148, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-971, -32, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-848, 16, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-652, 131, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-686, -1, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-963, -270, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-550, -485, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-379, -676, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1198, 5, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1235, 98, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1399, 37, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1462, 99, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1789, 65, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1890, -46, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1668, -2, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1764, 223, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1776, -484, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1690, -272, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1793, -364, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1465, -401, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1555, -565, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1370, -412, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1204, -470, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1072, -427, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-843, -446, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-69, -996, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(124, -968, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(28, -1103, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-86, -647, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-34, -478, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(107, -82, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(191, -261, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(173, -482, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(141, -735, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-132, -389, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-122, -129, 40));

		// 'Pagshearer_Yellow' GenType 26 Spawn Points
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-1482, -497, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-1680, -578, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-1564, -291, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-1264, -399, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-981, -387, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-789, -254, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-961, -166, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-720, -381, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-643, -301, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-745, -82, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-770, 101, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-945, 139, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-1122, 113, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-1100, 30, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-712, -543, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-403, -563, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-239, -618, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-82, -776, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(282, -526, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(3, -379, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(233, -707, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(29, -982, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(137, -1074, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(248, -983, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(286, -855, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(92, -793, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(461, -635, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(581, -623, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(889, -206, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(1067, -374, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(1041, -540, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(748, -283, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(892, -457, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(756, -428, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(979, -849, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(1068, -818, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(754, -743, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-639, -90, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(59, -294, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(144, -324, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-21, 47, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(521, -552, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(1078, -708, 30));

		// 'Rootcrystal_02' GenType 27 Spawn Points
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(1292, 454, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(1234, 748, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(975, 941, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(595, 882, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(472, 685, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(118, 768, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-123, 785, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-590, 789, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-849, 729, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-815, 321, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-1217, 541, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-1457, 730, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-1656, 458, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-1912, 803, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-307, 410, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(22, 381, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(302, 62, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-120, -227, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(235, -521, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-85, -777, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(266, -1070, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-634, -504, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-783, -125, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-1394, 10, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-1536, -372, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-1869, 194, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(848, -826, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(1064, -493, 15));
	}
}
