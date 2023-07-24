//--- Melia Script -----------------------------------------------------------
// Grand Yard Mesa Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_tableland_71'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FTableland71MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_tableland_71.Id1", MonsterId.Hohen_Ritter_Purple, min: 23, max: 30, respawn: TimeSpan.FromMilliseconds(25000));
		AddSpawner("f_tableland_71.Id2", MonsterId.Cronewt_Bow_Blue, min: 8, max: 10, respawn: TimeSpan.FromMilliseconds(25000));
		AddSpawner("f_tableland_71.Id3", MonsterId.Hohen_Barkle_Blue, min: 8, max: 10, respawn: TimeSpan.FromMilliseconds(25000));
		AddSpawner("f_tableland_71.Id4", MonsterId.Tiny_Blue, min: 8, max: 10, respawn: TimeSpan.FromMilliseconds(25000));
		AddSpawner("f_tableland_71.Id5", MonsterId.Rootcrystal_03, min: 27, max: 35, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("f_tableland_71.Id6", MonsterId.Hohen_Ritter_Purple, amount: 3, respawn: TimeSpan.FromMilliseconds(25000));
		AddSpawner("f_tableland_71.Id7", MonsterId.Hohen_Barkle_Blue, amount: 2, respawn: TimeSpan.FromMilliseconds(25000));
		AddSpawner("f_tableland_71.Id8", MonsterId.Tiny_Blue, amount: 1, respawn: TimeSpan.FromMilliseconds(25000));
		AddSpawner("f_tableland_71.Id9", MonsterId.Cronewt_Bow_Blue, amount: 1, respawn: TimeSpan.FromMilliseconds(25000));
		AddSpawner("f_tableland_71.Id10", MonsterId.Tiny_Blue, min: 75, max: 100, respawn: TimeSpan.FromMilliseconds(25000));
		AddSpawner("f_tableland_71.Id11", MonsterId.Cronewt_Bow_Blue, min: 3, max: 4, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("f_tableland_71.Id12", MonsterId.Hohen_Ritter_Purple, min: 8, max: 10, respawn: TimeSpan.FromMilliseconds(30000));

		// Monster Spawn Points -----------------------------

		// 'Hohen_Ritter_Purple' GenType 1 Spawn Points
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(486, -193, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(543, 34, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(271, -169, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(-858, -160, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(-649, -100, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(-787, 67, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(-465, 124, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(-238, -557, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(29, -579, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(-121, -684, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(-252, -366, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(-1219, 25, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(-1407, -138, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(-1540, 83, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(-1401, 85, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(-291, 752, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(-236, -70, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(-199, 288, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(-332, 586, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(-264, 488, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(-640, 1057, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(-858, 1305, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(232, 482, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(296, 738, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(504, 334, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(801, 451, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(1145, 634, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(1289, 680, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(1344, 484, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(1328, 82, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(1227, -56, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(1345, -171, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(1427, -5, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(1076, 459, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(713, -121, 25));
		AddSpawnPoint("f_tableland_71.Id1", "f_tableland_71", Rectangle(482, -390, 25));

		// 'Cronewt_Bow_Blue' GenType 2 Spawn Points
		AddSpawnPoint("f_tableland_71.Id2", "f_tableland_71", Rectangle(-1469, 5, 25));
		AddSpawnPoint("f_tableland_71.Id2", "f_tableland_71", Rectangle(-331, 1044, 25));
		AddSpawnPoint("f_tableland_71.Id2", "f_tableland_71", Rectangle(-774, 1228, 25));
		AddSpawnPoint("f_tableland_71.Id2", "f_tableland_71", Rectangle(30, 783, 25));
		AddSpawnPoint("f_tableland_71.Id2", "f_tableland_71", Rectangle(-442, 661, 25));
		AddSpawnPoint("f_tableland_71.Id2", "f_tableland_71", Rectangle(-373, 531, 25));
		AddSpawnPoint("f_tableland_71.Id2", "f_tableland_71", Rectangle(-265, 365, 25));
		AddSpawnPoint("f_tableland_71.Id2", "f_tableland_71", Rectangle(-501, 871, 25));
		AddSpawnPoint("f_tableland_71.Id2", "f_tableland_71", Rectangle(49, 621, 25));
		AddSpawnPoint("f_tableland_71.Id2", "f_tableland_71", Rectangle(166, 439, 25));
		AddSpawnPoint("f_tableland_71.Id2", "f_tableland_71", Rectangle(356, 534, 25));
		AddSpawnPoint("f_tableland_71.Id2", "f_tableland_71", Rectangle(418, 858, 25));
		AddSpawnPoint("f_tableland_71.Id2", "f_tableland_71", Rectangle(354, 221, 25));
		AddSpawnPoint("f_tableland_71.Id2", "f_tableland_71", Rectangle(715, 499, 25));
		AddSpawnPoint("f_tableland_71.Id2", "f_tableland_71", Rectangle(663, 300, 25));
		AddSpawnPoint("f_tableland_71.Id2", "f_tableland_71", Rectangle(716, 114, 25));
		AddSpawnPoint("f_tableland_71.Id2", "f_tableland_71", Rectangle(353, -29, 25));
		AddSpawnPoint("f_tableland_71.Id2", "f_tableland_71", Rectangle(320, -328, 25));
		AddSpawnPoint("f_tableland_71.Id2", "f_tableland_71", Rectangle(455, -375, 25));
		AddSpawnPoint("f_tableland_71.Id2", "f_tableland_71", Rectangle(680, -312, 25));

		// 'Hohen_Barkle_Blue' GenType 3 Spawn Points
		AddSpawnPoint("f_tableland_71.Id3", "f_tableland_71", Rectangle(-748, -169, 25));
		AddSpawnPoint("f_tableland_71.Id3", "f_tableland_71", Rectangle(-782, 6, 25));
		AddSpawnPoint("f_tableland_71.Id3", "f_tableland_71", Rectangle(-1301, -28, 25));
		AddSpawnPoint("f_tableland_71.Id3", "f_tableland_71", Rectangle(-1604, 0, 25));
		AddSpawnPoint("f_tableland_71.Id3", "f_tableland_71", Rectangle(-1479, -82, 25));
		AddSpawnPoint("f_tableland_71.Id3", "f_tableland_71", Rectangle(-990, 63, 25));
		AddSpawnPoint("f_tableland_71.Id3", "f_tableland_71", Rectangle(-786, 169, 25));
		AddSpawnPoint("f_tableland_71.Id3", "f_tableland_71", Rectangle(-651, -138, 25));
		AddSpawnPoint("f_tableland_71.Id3", "f_tableland_71", Rectangle(-466, -97, 25));
		AddSpawnPoint("f_tableland_71.Id3", "f_tableland_71", Rectangle(-344, 140, 25));
		AddSpawnPoint("f_tableland_71.Id3", "f_tableland_71", Rectangle(-516, 157, 25));
		AddSpawnPoint("f_tableland_71.Id3", "f_tableland_71", Rectangle(-392, 22, 25));
		AddSpawnPoint("f_tableland_71.Id3", "f_tableland_71", Rectangle(-928, -205, 25));
		AddSpawnPoint("f_tableland_71.Id3", "f_tableland_71", Rectangle(-979, -644, 25));
		AddSpawnPoint("f_tableland_71.Id3", "f_tableland_71", Rectangle(-987, -861, 25));
		AddSpawnPoint("f_tableland_71.Id3", "f_tableland_71", Rectangle(-839, -938, 25));
		AddSpawnPoint("f_tableland_71.Id3", "f_tableland_71", Rectangle(-810, -705, 25));
		AddSpawnPoint("f_tableland_71.Id3", "f_tableland_71", Rectangle(-914, -805, 25));
		AddSpawnPoint("f_tableland_71.Id3", "f_tableland_71", Rectangle(-739, -862, 25));
		AddSpawnPoint("f_tableland_71.Id3", "f_tableland_71", Rectangle(-877, -444, 25));

		// 'Tiny_Blue' GenType 4 Spawn Points
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(-886, -769, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(-920, -941, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(-1287, -94, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(-1316, 94, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(-627, -46, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(-208, 1037, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(-256, -281, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(291, -135, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(664, -307, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(1183, -88, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(1331, -137, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(1343, 113, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(1306, -8, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(1401, 217, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(1447, 485, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(1244, 490, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(1040, 384, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(1073, 585, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(1355, 766, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(1268, 647, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(851, 412, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(667, 502, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(661, 244, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(365, 682, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(531, 425, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(391, 273, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(250, 483, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(257, 746, 25));
		AddSpawnPoint("f_tableland_71.Id4", "f_tableland_71", Rectangle(1460, 777, 25));

		// 'Rootcrystal_03' GenType 9 Spawn Points
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-269, -1156, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-663, -888, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-991, -919, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-1012, -679, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-944, -256, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-876, 116, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-407, -116, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-420, 201, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-285, -440, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-55, -630, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-309, 542, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-475, 884, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-538, 672, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-121, 920, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(149, 711, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(221, 464, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(403, 213, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(728, 128, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(555, -49, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(303, -170, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(537, -416, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(589, 465, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(961, 391, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(1182, 503, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(1382, 692, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(1285, -96, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(1703, 619, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(1802, 460, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-666, 1117, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-825, 704, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-1148, 677, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-1020, 566, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-1542, -43, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-1243, 123, 40));
		AddSpawnPoint("f_tableland_71.Id5", "f_tableland_71", Rectangle(-1257, -177, 40));

		// 'Hohen_Ritter_Purple' GenType 37 Spawn Points
		AddSpawnPoint("f_tableland_71.Id6", "f_tableland_71", Rectangle(-657, 842, 40));
		AddSpawnPoint("f_tableland_71.Id6", "f_tableland_71", Rectangle(-370, 763, 40));
		AddSpawnPoint("f_tableland_71.Id6", "f_tableland_71", Rectangle(-317, 939, 40));

		// 'Hohen_Barkle_Blue' GenType 38 Spawn Points
		AddSpawnPoint("f_tableland_71.Id7", "f_tableland_71", Rectangle(-387, 845, 40));
		AddSpawnPoint("f_tableland_71.Id7", "f_tableland_71", Rectangle(-465, 737, 40));

		// 'Tiny_Blue' GenType 39 Spawn Points
		AddSpawnPoint("f_tableland_71.Id8", "f_tableland_71", Rectangle(-498, 964, 40));

		// 'Cronewt_Bow_Blue' GenType 40 Spawn Points
		AddSpawnPoint("f_tableland_71.Id9", "f_tableland_71", Rectangle(-455, 826, 40));

		// 'Tiny_Blue' GenType 41 Spawn Points
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1240, -155, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1248, 43, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1411, -71, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1167, 462, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1371, 456, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1361, 663, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1173, 680, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-980, -733, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-1054, -982, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-986, -1018, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-983, -947, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-1043, -865, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-1053, -706, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-908, -868, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-814, -864, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-801, -991, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-744, -930, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-774, -792, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-828, -755, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-885, -699, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-826, -634, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-920, -623, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-1615, 79, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-1543, 16, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-1477, 119, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-1403, 10, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-1409, -68, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-1335, -132, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-1265, -178, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-1214, -105, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-1138, -43, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-1303, 40, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-1480, -147, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-1558, -57, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-1669, -13, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-1557, 150, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-1389, 160, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-1078, 22, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-931, 43, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-877, 130, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-859, 40, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-827, -40, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-750, -73, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-800, -133, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-941, -270, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-869, -227, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-776, -249, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-688, -218, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-685, -797, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-671, -881, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-180, -552, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-193, -643, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-87, -605, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-20, -667, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(54, -635, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(0, -506, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-12, -750, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-182, -724, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-264, -665, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-237, -478, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-282, -421, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-330, -354, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-266, -201, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-308, -499, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-391, -448, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-338, -617, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-371, -542, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-492, -36, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-410, -75, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-465, 31, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-515, 64, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-578, 140, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-556, 224, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-464, 232, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-412, 170, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-402, 90, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-516, 303, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-171, 227, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-239, 438, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-304, 455, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-294, 640, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-346, 691, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-401, 603, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-253, 539, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-546, 731, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-579, 811, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-760, 849, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-691, 774, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-630, 705, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-708, 707, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-829, 1253, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-733, 1185, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-670, 1156, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-690, 1097, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-607, 1101, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-564, 1038, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-584, 950, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-405, 922, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(-386, 998, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(316, -241, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(395, -269, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(475, -300, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(562, -355, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(588, -431, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(584, -279, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(543, -194, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(414, -177, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(387, -101, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(457, -107, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(331, -162, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(560, -106, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(616, -204, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(696, -245, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(754, -195, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(636, -130, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(716, -58, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(635, -48, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(555, -28, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(467, -22, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(491, 58, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(601, 23, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(683, 8, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(651, 75, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(568, 115, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(660, 161, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(742, 186, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(580, 203, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(508, 241, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(506, 155, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(595, 363, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(384, 353, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(588, 490, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(491, 495, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(406, 592, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(299, 581, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(304, 428, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(235, 279, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(319, 295, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(192, 235, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(184, 171, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1159, -167, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1286, -221, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1328, -62, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1399, 57, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1411, 144, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1307, 582, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1420, 595, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1228, 574, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1131, 564, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1122, 403, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1011, 478, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(982, 390, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1002, 310, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(914, 457, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(912, 347, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1519, 601, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1278, 757, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1376, 538, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1290, 433, 40));
		AddSpawnPoint("f_tableland_71.Id10", "f_tableland_71", Rectangle(1259, 345, 40));

		// 'Cronewt_Bow_Blue' GenType 42 Spawn Points
		AddSpawnPoint("f_tableland_71.Id11", "f_tableland_71", Rectangle(227, 381, 40));
		AddSpawnPoint("f_tableland_71.Id11", "f_tableland_71", Rectangle(452, 402, 40));
		AddSpawnPoint("f_tableland_71.Id11", "f_tableland_71", Rectangle(421, 747, 40));
		AddSpawnPoint("f_tableland_71.Id11", "f_tableland_71", Rectangle(168, 727, 40));

		// 'Hohen_Ritter_Purple' GenType 43 Spawn Points
		AddSpawnPoint("f_tableland_71.Id12", "f_tableland_71", Rectangle(406, 698, 40));
		AddSpawnPoint("f_tableland_71.Id12", "f_tableland_71", Rectangle(164, 306, 40));
		AddSpawnPoint("f_tableland_71.Id12", "f_tableland_71", Rectangle(280, 220, 40));
		AddSpawnPoint("f_tableland_71.Id12", "f_tableland_71", Rectangle(588, 278, 40));
		AddSpawnPoint("f_tableland_71.Id12", "f_tableland_71", Rectangle(223, 666, 40));
		AddSpawnPoint("f_tableland_71.Id12", "f_tableland_71", Rectangle(681, 481, 40));
		AddSpawnPoint("f_tableland_71.Id12", "f_tableland_71", Rectangle(351, 506, 40));
		AddSpawnPoint("f_tableland_71.Id12", "f_tableland_71", Rectangle(432, 278, 40));
		AddSpawnPoint("f_tableland_71.Id12", "f_tableland_71", Rectangle(140, 519, 40));
		AddSpawnPoint("f_tableland_71.Id12", "f_tableland_71", Rectangle(603, 638, 40));
	}
}
