//--- Melia Script -----------------------------------------------------------
// Bladelight Basin Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_katyn_17'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn17MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_katyn_17.Id1", MonsterId.Jellyfish, 15, 20, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("f_katyn_17.Id2", MonsterId.TerraNymph, 12, 15, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("f_katyn_17.Id3", MonsterId.Woodgoblin_Black, 23, 30, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("f_katyn_17.Id4", MonsterId.TerraNymph, 15, 20, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_katyn_17.Id5", MonsterId.Woodgoblin_Black, 23, 30, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Jellyfish' GenType 3 Spawn Points
		AddSpawnPoint("f_katyn_17.Id1", "f_katyn_17", Rectangle(2157, -3368, 9999));

		// 'TerraNymph' GenType 10 Spawn Points
		AddSpawnPoint("f_katyn_17.Id2", "f_katyn_17", Rectangle(2088, -3363, 9999));

		// 'Woodgoblin_Black' GenType 11 Spawn Points
		AddSpawnPoint("f_katyn_17.Id3", "f_katyn_17", Rectangle(856, -2556, 9999));

		// 'TerraNymph' GenType 12 Spawn Points
		AddSpawnPoint("f_katyn_17.Id4", "f_katyn_17", Rectangle(-365, 575, 30));
		AddSpawnPoint("f_katyn_17.Id4", "f_katyn_17", Rectangle(-211, 772, 30));
		AddSpawnPoint("f_katyn_17.Id4", "f_katyn_17", Rectangle(-95, 984, 30));
		AddSpawnPoint("f_katyn_17.Id4", "f_katyn_17", Rectangle(-446, 2912, 30));
		AddSpawnPoint("f_katyn_17.Id4", "f_katyn_17", Rectangle(-129, 480, 30));
		AddSpawnPoint("f_katyn_17.Id4", "f_katyn_17", Rectangle(-567, 2572, 30));
		AddSpawnPoint("f_katyn_17.Id4", "f_katyn_17", Rectangle(2, 759, 30));
		AddSpawnPoint("f_katyn_17.Id4", "f_katyn_17", Rectangle(-686, 709, 30));
		AddSpawnPoint("f_katyn_17.Id4", "f_katyn_17", Rectangle(-659, 886, 30));
		AddSpawnPoint("f_katyn_17.Id4", "f_katyn_17", Rectangle(-641, 486, 30));
		AddSpawnPoint("f_katyn_17.Id4", "f_katyn_17", Rectangle(-354, 2655, 30));
		AddSpawnPoint("f_katyn_17.Id4", "f_katyn_17", Rectangle(-718, 2738, 30));

		// 'Woodgoblin_Black' GenType 13 Spawn Points
		AddSpawnPoint("f_katyn_17.Id5", "f_katyn_17", Rectangle(-910, 2486, 30));
		AddSpawnPoint("f_katyn_17.Id5", "f_katyn_17", Rectangle(-226, 489, 30));
		AddSpawnPoint("f_katyn_17.Id5", "f_katyn_17", Rectangle(-872, 2844, 30));
		AddSpawnPoint("f_katyn_17.Id5", "f_katyn_17", Rectangle(10, 821, 30));
		AddSpawnPoint("f_katyn_17.Id5", "f_katyn_17", Rectangle(-643, 2700, 30));
		AddSpawnPoint("f_katyn_17.Id5", "f_katyn_17", Rectangle(-415, 2961, 30));
		AddSpawnPoint("f_katyn_17.Id5", "f_katyn_17", Rectangle(-388, 3172, 30));
		AddSpawnPoint("f_katyn_17.Id5", "f_katyn_17", Rectangle(-202, 3037, 30));
		AddSpawnPoint("f_katyn_17.Id5", "f_katyn_17", Rectangle(-126, 2574, 30));
		AddSpawnPoint("f_katyn_17.Id5", "f_katyn_17", Rectangle(-467, 2532, 30));
		AddSpawnPoint("f_katyn_17.Id5", "f_katyn_17", Rectangle(-631, 528, 30));
		AddSpawnPoint("f_katyn_17.Id5", "f_katyn_17", Rectangle(-321, 711, 30));
	}
}
