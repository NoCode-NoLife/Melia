//--- Melia Script -----------------------------------------------------------
// d_zachariel_36
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Royal Mausoleum 5F' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DZachariel36MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_zachariel_36", MonsterId.Schlesien_Darkmage, Properties("MHP", 82513, "MINPATK", 1562, "MAXPATK", 1821, "MINMATK", 1562, "MAXMATK", 1821, "DEF", 664, "MDEF", 664));
		AddPropertyOverrides("d_zachariel_36", MonsterId.Schlesien_Heavycavarly, Properties("MHP", 83567, "MINPATK", 1575, "MAXPATK", 1838, "MINMATK", 1575, "MAXMATK", 1838, "DEF", 680, "MDEF", 680));
		AddPropertyOverrides("d_zachariel_36", MonsterId.Schlesien_Claw, Properties("MHP", 84632, "MINPATK", 1589, "MAXPATK", 1855, "MINMATK", 1589, "MAXMATK", 1855, "DEF", 697, "MDEF", 697));
		AddPropertyOverrides("d_zachariel_36", MonsterId.Boss_Lecifer, Properties("MHP", 686529, "MINPATK", 4504, "MAXPATK", 5260, "MINMATK", 4504, "MAXMATK", 5260, "DEF", 2004, "MDEF", 2004));

		// Monster Spawners ---------------------------------

		AddSpawner("d_zachariel_36.Id1", MonsterId.Rootcrystal_05, 8, 10, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("d_zachariel_36.Id2", MonsterId.Schlesien_Darkmage, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_36.Id3", MonsterId.Schlesien_Heavycavarly, 3, 3, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_zachariel_36.Id4", MonsterId.Schlesien_Claw, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_36.Id5", MonsterId.Schlesien_Darkmage, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_zachariel_36.Id6", MonsterId.Schlesien_Darkmage, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 600 Spawn Points
		AddSpawnPoint("d_zachariel_36.Id1", "d_zachariel_36", Rectangle(-2596, -4677, 30));
		AddSpawnPoint("d_zachariel_36.Id1", "d_zachariel_36", Rectangle(-2412, -2689, 30));
		AddSpawnPoint("d_zachariel_36.Id1", "d_zachariel_36", Rectangle(-2468, -1043, 30));
		AddSpawnPoint("d_zachariel_36.Id1", "d_zachariel_36", Rectangle(-3548.7715, -2598.056, 30));
		AddSpawnPoint("d_zachariel_36.Id1", "d_zachariel_36", Rectangle(-2483.231, -3645.55, 30));
		AddSpawnPoint("d_zachariel_36.Id1", "d_zachariel_36", Rectangle(-2744.1929, -4492.2397, 30));
		AddSpawnPoint("d_zachariel_36.Id1", "d_zachariel_36", Rectangle(-2655.8499, -5529.755, 30));
		AddSpawnPoint("d_zachariel_36.Id1", "d_zachariel_36", Rectangle(-1584.2416, -2551.1887, 30));
		AddSpawnPoint("d_zachariel_36.Id1", "d_zachariel_36", Rectangle(-2609.7756, -1073.0471, 30));
		AddSpawnPoint("d_zachariel_36.Id1", "d_zachariel_36", Rectangle(-2755.5, -2496.7476, 30));

		// 'Schlesien_Darkmage' GenType 720 Spawn Points
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2498, -2577, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2504.7087, -5413.427, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2593.7822, -5535.954, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2535.3142, -5683.9365, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2493.4426, -5573.212, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2413.1768, -5478.0034, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2521.4932, -5296.32, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2588.4192, -2733.0122, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2614.373, -2511.2717, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2390.667, -2462.689, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2408.651, -2752.6826, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2714.9482, -2611.869, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2218.605, -2606.3662, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2645.919, -2857.8042, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2490.7466, -2347.6702, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2514.9072, -2999.8071, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2064.6074, -2578.213, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2947.5066, -2578.6873, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2491.9778, -2191.5103, 250));

		// 'Schlesien_Heavycavarly' GenType 721 Spawn Points
		AddSpawnPoint("d_zachariel_36.Id3", "d_zachariel_36", Rectangle(-2669.965, -2596.03, 9999));

		// 'Schlesien_Claw' GenType 723 Spawn Points
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2405.978, -2705.7886, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2693.6946, -4590.1465, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2510.967, -4346.984, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2354.368, -4544.877, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2493.0967, -4544.013, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2535.5217, -4726.055, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2551.2236, -3721.2573, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2571.3164, -3518.628, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2419.295, -3530.8596, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2616.8357, -3597.5903, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2496.4773, -3387.381, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2605.8696, -2686.7808, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2578.7576, -2523.837, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2897.956, -2589.39, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2514.921, -3053.3235, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2526.9734, -3138.6611, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2473.9578, -2154.853, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2513.4104, -1799.9315, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2136.7048, -2587.069, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-1809.4679, -2542.312, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-1640.4958, -2572.5945, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-1697.6233, -2678.7073, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-3354.0786, -2707.0693, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-3515.0388, -2663.5317, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-3464.3147, -2482.074, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-3503.1533, -2554.6287, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2402.707, -2505.0432, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2532.9692, -1293.729, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2625.794, -1086.5596, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2485.7861, -886.6449, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2240.5007, -1118.4352, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2373.9363, -1240.6173, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2803.3503, -1239.9849, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2730.813, -1000.7232, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2146.996, -1324.1758, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2146.7327, -980.8198, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2499.7986, -208.08728, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2500.977, -484.0982, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-3068.3877, -2585.3364, 40));

		// 'Schlesien_Darkmage' GenType 3002 Spawn Points
		AddSpawnPoint("d_zachariel_36.Id5", "d_zachariel_36", Rectangle(-2476, -2588, 9999));

		// 'Schlesien_Darkmage' GenType 3018 Spawn Points
		AddSpawnPoint("d_zachariel_36.Id6", "d_zachariel_36", Rectangle(-2497.8655, -4520.8525, 30));
		AddSpawnPoint("d_zachariel_36.Id6", "d_zachariel_36", Rectangle(-2643.1138, -4760.868, 30));
		AddSpawnPoint("d_zachariel_36.Id6", "d_zachariel_36", Rectangle(-2700.9414, -4529.9883, 30));
		AddSpawnPoint("d_zachariel_36.Id6", "d_zachariel_36", Rectangle(-2447.1936, -4361.7485, 30));
		AddSpawnPoint("d_zachariel_36.Id6", "d_zachariel_36", Rectangle(-2281.8254, -4544.513, 30));
		AddSpawnPoint("d_zachariel_36.Id6", "d_zachariel_36", Rectangle(-2362.993, -4726.092, 30));
		AddSpawnPoint("d_zachariel_36.Id6", "d_zachariel_36", Rectangle(-2488.8162, -4659.378, 30));
	}
}
