//--- Melia Script -----------------------------------------------------------
// Vera Coast Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_coral_35_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCoral352MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_coral_35_2.Id1", MonsterId.Jukotail, 34, 45, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_35_2.Id2", MonsterId.Siaulav_Orange, 34, 45, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_35_2.Id3", MonsterId.Siaulav_Bow_Orange, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_35_2.Id4", MonsterId.Rootcrystal_01, 12, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_coral_35_2.Id5", MonsterId.Jukotail, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_35_2.Id6", MonsterId.Siaulav_Orange, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_35_2.Id7", MonsterId.Siaulav_Bow_Orange, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_35_2.Id8", MonsterId.Jukotail, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Jukotail' GenType 1 Spawn Points
		AddSpawnPoint("f_coral_35_2.Id1", "f_coral_35_2", Rectangle(387, 464, 9999));
		AddSpawnPoint("f_coral_35_2.Id1", "f_coral_35_2", Rectangle(199, -190, 9999));

		// 'Siaulav_Orange' GenType 2 Spawn Points
		AddSpawnPoint("f_coral_35_2.Id2", "f_coral_35_2", Rectangle(881, 391, 9999));

		// 'Siaulav_Bow_Orange' GenType 3 Spawn Points
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(1667, 819, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(-493, 1841, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(875, 250, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(398, 2120, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(1781, 255, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(-349, 1213, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(-455, 1681, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(1214, 850, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(-289, 906, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(1418, 1231, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(1338, 1092, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(1562, 1251, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(322, 1963, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(262, 2159, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(-685, 911, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(1048, 424, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(1094, 584, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(708, 492, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(1847, 50, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(-615, 1798, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(1909, 473, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(-341, 2082, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(1911, 174, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(1795, 539, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(1301, 1203, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(860, 459, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(-421, -1001, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(-260, -875, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(-261, -967, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(-278, -1138, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(-79, -904, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(304, -174, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(299, -291, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(129, -315, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(-13, -637, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(77, -443, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(-472, -772, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(-640, -770, 30));
		AddSpawnPoint("f_coral_35_2.Id3", "f_coral_35_2", Rectangle(546, 2080, 30));

		// 'Rootcrystal_01' GenType 6 Spawn Points
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(-991, 1252, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(-634, 957, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(290, -69, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(241, -299, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(-178, -798, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(-315, -1017, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(-902, -606, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(-808, -418, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(-447, -168, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(-278, 2068, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(308, 2175, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(1807, 324, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(1858, 552, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(1511, 1268, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(1331, 1026, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(932, 245, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(1192, 823, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(705, 391, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(-670, -210, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(-87, 214, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(-374, 1201, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(-205, 778, 100));
		AddSpawnPoint("f_coral_35_2.Id4", "f_coral_35_2", Rectangle(-459, 1775, 100));

		// 'Jukotail' GenType 36 Spawn Points
		AddSpawnPoint("f_coral_35_2.Id5", "f_coral_35_2", Rectangle(-309, 1858, 35));
		AddSpawnPoint("f_coral_35_2.Id5", "f_coral_35_2", Rectangle(-642, 1922, 35));
		AddSpawnPoint("f_coral_35_2.Id5", "f_coral_35_2", Rectangle(-437, 1776, 35));
		AddSpawnPoint("f_coral_35_2.Id5", "f_coral_35_2", Rectangle(-285, 2082, 35));
		AddSpawnPoint("f_coral_35_2.Id5", "f_coral_35_2", Rectangle(-415, 1997, 35));
		AddSpawnPoint("f_coral_35_2.Id5", "f_coral_35_2", Rectangle(-714, -250, 35));
		AddSpawnPoint("f_coral_35_2.Id5", "f_coral_35_2", Rectangle(-853, -464, 35));
		AddSpawnPoint("f_coral_35_2.Id5", "f_coral_35_2", Rectangle(-413, -82, 35));
		AddSpawnPoint("f_coral_35_2.Id5", "f_coral_35_2", Rectangle(-397, 61, 35));
		AddSpawnPoint("f_coral_35_2.Id5", "f_coral_35_2", Rectangle(-575, -227, 35));
		AddSpawnPoint("f_coral_35_2.Id5", "f_coral_35_2", Rectangle(-940, -600, 35));
		AddSpawnPoint("f_coral_35_2.Id5", "f_coral_35_2", Rectangle(-949, -416, 35));
		AddSpawnPoint("f_coral_35_2.Id5", "f_coral_35_2", Rectangle(-820, -602, 35));

		// 'Siaulav_Orange' GenType 37 Spawn Points
		AddSpawnPoint("f_coral_35_2.Id6", "f_coral_35_2", Rectangle(-701, 1869, 35));
		AddSpawnPoint("f_coral_35_2.Id6", "f_coral_35_2", Rectangle(-500, 1763, 35));
		AddSpawnPoint("f_coral_35_2.Id6", "f_coral_35_2", Rectangle(-473, 1927, 35));
		AddSpawnPoint("f_coral_35_2.Id6", "f_coral_35_2", Rectangle(-309, 2009, 35));
		AddSpawnPoint("f_coral_35_2.Id6", "f_coral_35_2", Rectangle(-562, -98, 35));
		AddSpawnPoint("f_coral_35_2.Id6", "f_coral_35_2", Rectangle(-928, -624, 35));
		AddSpawnPoint("f_coral_35_2.Id6", "f_coral_35_2", Rectangle(-473, -225, 35));
		AddSpawnPoint("f_coral_35_2.Id6", "f_coral_35_2", Rectangle(-833, -481, 35));
		AddSpawnPoint("f_coral_35_2.Id6", "f_coral_35_2", Rectangle(-376, -23, 35));
		AddSpawnPoint("f_coral_35_2.Id6", "f_coral_35_2", Rectangle(-337, 1860, 35));
		AddSpawnPoint("f_coral_35_2.Id6", "f_coral_35_2", Rectangle(-225, 2152, 35));
		AddSpawnPoint("f_coral_35_2.Id6", "f_coral_35_2", Rectangle(-64, 2290, 35));

		// 'Siaulav_Bow_Orange' GenType 38 Spawn Points
		AddSpawnPoint("f_coral_35_2.Id7", "f_coral_35_2", Rectangle(-658, -225, 35));
		AddSpawnPoint("f_coral_35_2.Id7", "f_coral_35_2", Rectangle(-791, -446, 35));
		AddSpawnPoint("f_coral_35_2.Id7", "f_coral_35_2", Rectangle(-745, -113, 35));
		AddSpawnPoint("f_coral_35_2.Id7", "f_coral_35_2", Rectangle(-419, -90, 35));
		AddSpawnPoint("f_coral_35_2.Id7", "f_coral_35_2", Rectangle(-539, -141, 35));
		AddSpawnPoint("f_coral_35_2.Id7", "f_coral_35_2", Rectangle(-933, -553, 35));
		AddSpawnPoint("f_coral_35_2.Id7", "f_coral_35_2", Rectangle(-878, -698, 35));
		AddSpawnPoint("f_coral_35_2.Id7", "f_coral_35_2", Rectangle(-585, -786, 35));

		// 'Jukotail' GenType 39 Spawn Points
		AddSpawnPoint("f_coral_35_2.Id8", "f_coral_35_2", Rectangle(-784, 919, 30));
		AddSpawnPoint("f_coral_35_2.Id8", "f_coral_35_2", Rectangle(-581, 875, 30));
		AddSpawnPoint("f_coral_35_2.Id8", "f_coral_35_2", Rectangle(-689, 1237, 30));
		AddSpawnPoint("f_coral_35_2.Id8", "f_coral_35_2", Rectangle(-678, 1090, 30));
		AddSpawnPoint("f_coral_35_2.Id8", "f_coral_35_2", Rectangle(-502, 1003, 30));
		AddSpawnPoint("f_coral_35_2.Id8", "f_coral_35_2", Rectangle(-365, 808, 30));
		AddSpawnPoint("f_coral_35_2.Id8", "f_coral_35_2", Rectangle(-328, 1073, 30));
		AddSpawnPoint("f_coral_35_2.Id8", "f_coral_35_2", Rectangle(-289, 892, 30));
		AddSpawnPoint("f_coral_35_2.Id8", "f_coral_35_2", Rectangle(-175, 769, 30));
		AddSpawnPoint("f_coral_35_2.Id8", "f_coral_35_2", Rectangle(-142, 905, 30));
		AddSpawnPoint("f_coral_35_2.Id8", "f_coral_35_2", Rectangle(-391, 1316, 30));
		AddSpawnPoint("f_coral_35_2.Id8", "f_coral_35_2", Rectangle(-895, 1139, 30));
		AddSpawnPoint("f_coral_35_2.Id8", "f_coral_35_2", Rectangle(-284, 1427, 30));
		AddSpawnPoint("f_coral_35_2.Id8", "f_coral_35_2", Rectangle(-327, 1558, 30));
		AddSpawnPoint("f_coral_35_2.Id8", "f_coral_35_2", Rectangle(-445, 1667, 30));
	}
}
