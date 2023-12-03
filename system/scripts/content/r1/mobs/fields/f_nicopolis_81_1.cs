//--- Melia Script -----------------------------------------------------------
// Starry Town Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_nicopolis_81_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FNicopolis811MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_nicopolis_81_1.Id1", MonsterId.Cresent_Moya, min: 38, max: 50);
		AddSpawner("f_nicopolis_81_1.Id2", MonsterId.Mimorat_Purple, min: 24, max: 31);
		AddSpawner("f_nicopolis_81_1.Id3", MonsterId.Mimorat_Green, min: 24, max: 31);
		AddSpawner("f_nicopolis_81_1.Id4", MonsterId.Haunted_House, min: 6, max: 8);
		AddSpawner("f_nicopolis_81_1.Id5", MonsterId.Rootcrystal_02, min: 13, max: 17, respawn: TimeSpan.FromMilliseconds(30000));

		// Monster Spawn Points -----------------------------

		// 'Cresent_Moya' GenType 22 Spawn Points
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(-850, 194, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(-644, -111, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(-505, 61, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(-239, 228, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(-214, 539, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(118, 278, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(471, 512, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(488, 165, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(619, 337, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(913, 397, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(527, -102, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(-282, -1046, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(-209, -1386, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(-63, -1105, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(220, -789, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(371, -1047, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(552, -769, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(404, -395, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(757, -661, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1044, -1222, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1197, -976, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1460, -1064, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1550, -738, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1605, -257, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1881, 210, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1432, 174, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(762, 1122, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1013, 814, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(917, 1204, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(3073, 529, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1445, 689, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1652, 1122, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1563, 1400, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2004, 1095, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2505, 1287, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2957, 1145, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(3272, 874, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(3161, 586, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(3539, 443, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(3097, 190, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2880, -31, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2265, -152, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2634, -110, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1080, 1247, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2238, 1386, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1904, 1013, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2411, -1232, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2431, -1095, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2706, -1140, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2809, -940, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2914, -987, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2553, -1130, 25));

		// 'Mimorat_Purple' GenType 23 Spawn Points
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(-1575, 583, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(-1575, 173, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(-1454, 347, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(-866, 360, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(-688, 68, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(-427, 324, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(-490, -61, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(-68, 412, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(164, 618, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(816, 422, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(362, 424, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(597, 95, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(681, -335, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(499, -662, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(1219, 498, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(1769, 395, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(2355, 1260, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(3116, 1030, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(1955, 733, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(867, 868, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(926, 1075, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(2044, 1358, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(2801, 1264, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(3036, 430, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(2973, 149, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(3016, 804, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(3438, 541, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(1326, 1328, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(2599, -158, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(1546, 102, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(1725, -136, 25));

		// 'Mimorat_Green' GenType 24 Spawn Points
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(958, -1036, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1238, -1229, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(977, -774, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(2104, -1243, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(2365, -1179, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(2577, -1169, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(373, -849, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(486, -934, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(644, -1066, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(612, -475, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(156, -1067, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(-330, -1334, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(-229, -1179, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(-91, -1008, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(-11, -1310, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1328, -824, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1528, -533, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1748, -391, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1564, -68, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1750, 233, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1144, 370, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1431, 570, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1565, 420, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1733, 549, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1987, 479, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1315, 1466, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(812, 992, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1849, 1214, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1505, 743, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1773, 865, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(2048, 669, 25));

		// 'Haunted_House' GenType 25 Spawn Points
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(733, 460, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(1431, 346, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(1702, 606, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(1720, 1422, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(3247, 780, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(3173, 279, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(1860, 562, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(1176, 1369, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(500, 36, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(3648, 542, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(1663, -275, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(2457, 1339, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(514, -807, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(1646, -1135, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(2530, -155, 25));

		// 'Rootcrystal_02' GenType 36 Spawn Points
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(1672, -1069, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(2508, -1138, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(935, -1041, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(553, -839, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(-253, -1332, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(542, -20, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(655, 447, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(1635, -312, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(1581, 409, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(1870, 813, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(909, 1105, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(2521, 1279, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(3190, 839, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(3010, 75, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(65, 362, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(-558, -3, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(-1501, 294, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(426, -1148, 100));
	}
}
