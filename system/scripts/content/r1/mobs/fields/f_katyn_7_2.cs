//--- Melia Script -----------------------------------------------------------
// Owl Burial Ground Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_katyn_7_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn72MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_katyn_7_2.Id1", MonsterId.Rootcrystal_02, 15, 20, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_katyn_7_2.Id2", MonsterId.Ellomago, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7_2.Id3", MonsterId.Ridimed, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7_2.Id4", MonsterId.Jellyfish_Red, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7_2.Id5", MonsterId.Sakmoli, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7_2.Id6", MonsterId.Ridimed, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7_2.Id7", MonsterId.Sakmoli, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7_2.Id8", MonsterId.Ellomago, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7_2.Id9", MonsterId.Ridimed, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7_2.Id10", MonsterId.Sakmoli, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7_2.Id11", MonsterId.Jellyfish_Red, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_02' GenType 800 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id1", "f_katyn_7_2", Rectangle(2311, -2971, 9999));

		// 'Ellomago' GenType 10010 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id2", "f_katyn_7_2", Rectangle(725, -3299, 9999));

		// 'Ridimed' GenType 10011 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id3", "f_katyn_7_2", Rectangle(1319, -1858, 9999));

		// 'Jellyfish_Red' GenType 10012 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id4", "f_katyn_7_2", Rectangle(1830, -139, 9999));

		// 'Sakmoli' GenType 10013 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id5", "f_katyn_7_2", Rectangle(1852, 2080, 9999));

		// 'Ridimed' GenType 10015 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id6", "f_katyn_7_2", Rectangle(814, -668, 30));
		AddSpawnPoint("f_katyn_7_2.Id6", "f_katyn_7_2", Rectangle(555, -688, 30));
		AddSpawnPoint("f_katyn_7_2.Id6", "f_katyn_7_2", Rectangle(5, -807, 30));
		AddSpawnPoint("f_katyn_7_2.Id6", "f_katyn_7_2", Rectangle(246, -655, 30));
		AddSpawnPoint("f_katyn_7_2.Id6", "f_katyn_7_2", Rectangle(163, -403, 30));
		AddSpawnPoint("f_katyn_7_2.Id6", "f_katyn_7_2", Rectangle(134, -1049, 30));
		AddSpawnPoint("f_katyn_7_2.Id6", "f_katyn_7_2", Rectangle(600, -430, 30));
		AddSpawnPoint("f_katyn_7_2.Id6", "f_katyn_7_2", Rectangle(304, -452, 30));
		AddSpawnPoint("f_katyn_7_2.Id6", "f_katyn_7_2", Rectangle(406, -911, 30));

		// 'Sakmoli' GenType 10016 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(3652, -606, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(2436, -774, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(1815, 193, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(2749, 679, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(1896, 682, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(1580, -692, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(3296, 995, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(3591, 1071, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(2583, -465, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(3262, -566, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(3640, -780, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(4013, -329, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(3978, -738, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(3839, 954, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(3719, 704, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(3333, 1325, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(654, 1663, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(556, 1967, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(949, 2180, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(872, 1897, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(2642, 2310, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(2793, 2637, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(3013, 2410, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(1935, 2258, 30));

		// 'Ellomago' GenType 10017 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(2464, -2739, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(1592, -3334, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(1982, -3039, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(2343, -3172, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(2089, -2862, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(2743, -2775, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(2527, -3175, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(2897, -3314, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(2727, -3069, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(2582, -2610, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(3386, -3503, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(2332, -2893, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(2130, -2599, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(1783, -2648, 40));

		// 'Ridimed' GenType 10021 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(1961, -2980, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(1835, -129, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(2347, -2738, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(2462, -3123, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(2688, -2691, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(1345, -2146, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(1580, -3330, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(1526, -790, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(687, -3253, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(2414, -696, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(2640, -498, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(2789, -524, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(3648, -550, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(3761, -727, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(3992, -299, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(243, -959, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(319, -499, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(637, -666, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(1738, 1338, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(2566, 2413, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(2929, 2611, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(2890, 2226, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(912, 1936, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(654, 1568, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(711, 2128, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(1064, 1723, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(1743, 2072, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(3191, 1008, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(3740, 1132, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(3740, 662, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(3532, 991, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(3365, 1390, 40));

		// 'Sakmoli' GenType 10022 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(1365, -690, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(2607, -2694, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(2272, -2944, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(2708, -3275, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(1281, -1447, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(2617, -622, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(2027, -2571, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(1797, -81, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(1618, -3355, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(779, -676, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(1312, -2194, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(1591, -701, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(617, -3059, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(743, -3365, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(3566, -629, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(3711, -3216, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(3660, -3482, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(3633, -3961, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(3354, -4466, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(3530, -4680, 30));

		// 'Jellyfish_Red' GenType 10028 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(3193, 964, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(3653, 1153, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(3673, 867, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(3378, 1142, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(2860, 2369, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(2474, 2283, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(2808, 2678, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(1877, 2107, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(1572, 2034, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(960, 1980, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(2077, 649, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(2442, -719, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(2636, -444, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(3228, -626, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(3832, -699, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(3918, -352, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(3623, -633, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(2950, -544, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(1792, 2315, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(587, 1602, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(1735, 1405, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(1756, 1207, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(1838, 932, 30));
	}
}
