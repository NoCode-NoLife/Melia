//--- Melia Script -----------------------------------------------------------
// Royal Mausoleum 5F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_zachariel_36'.
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

		AddSpawner("d_zachariel_36.Id1", MonsterId.Rootcrystal_05, min: 8, max: 10, respawn: TimeSpan.FromMilliseconds(15000), tendency: TendencyType.Peaceful);
		AddSpawner("d_zachariel_36.Id2", MonsterId.Schlesien_Darkmage, min: 5, max: 6, tendency: TendencyType.Aggressive);
		AddSpawner("d_zachariel_36.Id3", MonsterId.Schlesien_Heavycavarly, amount: 3, tendency: TendencyType.Peaceful);
		AddSpawner("d_zachariel_36.Id4", MonsterId.Schlesien_Claw, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_zachariel_36.Id5", MonsterId.Schlesien_Darkmage, min: 12, max: 15, tendency: TendencyType.Peaceful);
		AddSpawner("d_zachariel_36.Id6", MonsterId.Schlesien_Darkmage, min: 4, max: 5, tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 600 Spawn Points
		AddSpawnPoint("d_zachariel_36.Id1", "d_zachariel_36", Rectangle(-2596, -4677, 30));
		AddSpawnPoint("d_zachariel_36.Id1", "d_zachariel_36", Rectangle(-2412, -2689, 30));
		AddSpawnPoint("d_zachariel_36.Id1", "d_zachariel_36", Rectangle(-2468, -1043, 30));
		AddSpawnPoint("d_zachariel_36.Id1", "d_zachariel_36", Rectangle(-3548, -2598, 30));
		AddSpawnPoint("d_zachariel_36.Id1", "d_zachariel_36", Rectangle(-2483, -3645, 30));
		AddSpawnPoint("d_zachariel_36.Id1", "d_zachariel_36", Rectangle(-2744, -4492, 30));
		AddSpawnPoint("d_zachariel_36.Id1", "d_zachariel_36", Rectangle(-2655, -5529, 30));
		AddSpawnPoint("d_zachariel_36.Id1", "d_zachariel_36", Rectangle(-1584, -2551, 30));
		AddSpawnPoint("d_zachariel_36.Id1", "d_zachariel_36", Rectangle(-2609, -1073, 30));
		AddSpawnPoint("d_zachariel_36.Id1", "d_zachariel_36", Rectangle(-2755, -2496, 30));

		// 'Schlesien_Darkmage' GenType 720 Spawn Points
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2498, -2577, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2504, -5413, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2593, -5535, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2535, -5683, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2493, -5573, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2413, -5478, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2521, -5296, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2588, -2733, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2614, -2511, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2390, -2462, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2408, -2752, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2714, -2611, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2218, -2606, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2645, -2857, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2490, -2347, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2514, -2999, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2064, -2578, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2947, -2578, 250));
		AddSpawnPoint("d_zachariel_36.Id2", "d_zachariel_36", Rectangle(-2491, -2191, 250));

		// 'Schlesien_Heavycavarly' GenType 721 Spawn Points
		AddSpawnPoint("d_zachariel_36.Id3", "d_zachariel_36", Rectangle(-2669, -2596, 9999));

		// 'Schlesien_Claw' GenType 723 Spawn Points
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2405, -2705, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2693, -4590, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2510, -4346, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2354, -4544, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2493, -4544, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2535, -4726, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2551, -3721, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2571, -3518, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2419, -3530, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2616, -3597, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2496, -3387, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2605, -2686, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2578, -2523, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2897, -2589, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2514, -3053, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2526, -3138, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2473, -2154, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2513, -1799, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2136, -2587, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-1809, -2542, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-1640, -2572, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-1697, -2678, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-3354, -2707, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-3515, -2663, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-3464, -2482, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-3503, -2554, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2402, -2505, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2532, -1293, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2625, -1086, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2485, -886, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2240, -1118, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2373, -1240, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2803, -1239, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2730, -1000, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2146, -1324, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2146, -980, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2499, -208, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-2500, -484, 40));
		AddSpawnPoint("d_zachariel_36.Id4", "d_zachariel_36", Rectangle(-3068, -2585, 40));

		// 'Schlesien_Darkmage' GenType 3002 Spawn Points
		AddSpawnPoint("d_zachariel_36.Id5", "d_zachariel_36", Rectangle(-2476, -2588, 9999));

		// 'Schlesien_Darkmage' GenType 3018 Spawn Points
		AddSpawnPoint("d_zachariel_36.Id6", "d_zachariel_36", Rectangle(-2497, -4520, 30));
		AddSpawnPoint("d_zachariel_36.Id6", "d_zachariel_36", Rectangle(-2643, -4760, 30));
		AddSpawnPoint("d_zachariel_36.Id6", "d_zachariel_36", Rectangle(-2700, -4529, 30));
		AddSpawnPoint("d_zachariel_36.Id6", "d_zachariel_36", Rectangle(-2447, -4361, 30));
		AddSpawnPoint("d_zachariel_36.Id6", "d_zachariel_36", Rectangle(-2281, -4544, 30));
		AddSpawnPoint("d_zachariel_36.Id6", "d_zachariel_36", Rectangle(-2362, -4726, 30));
		AddSpawnPoint("d_zachariel_36.Id6", "d_zachariel_36", Rectangle(-2488, -4659, 30));
	}
}
