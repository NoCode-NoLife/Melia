//--- Melia Script -----------------------------------------------------------
// Entrance of Kateen Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_katyn_7'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn7MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_katyn_7.Id1", MonsterId.Rootcrystal_02, 15, 20, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_katyn_7.Id2", MonsterId.Ellom, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7.Id3", MonsterId.Pappus_Kepa, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7.Id4", MonsterId.Bushspider, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7.Id5", MonsterId.Ellom, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7.Id6", MonsterId.Pappus_Kepa, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7.Id7", MonsterId.Bushspider, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7.Id8", MonsterId.Fisherman, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7.Id9", MonsterId.Ellom, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7.Id10", MonsterId.Fisherman, 3, 3, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_02' GenType 600 Spawn Points
		AddSpawnPoint("f_katyn_7.Id1", "f_katyn_7", Rectangle(-1223, 3370, 30));

		// 'Ellom' GenType 10007 Spawn Points
		AddSpawnPoint("f_katyn_7.Id2", "f_katyn_7", Rectangle(927, -2268, 9999));

		// 'Pappus_Kepa' GenType 10008 Spawn Points
		AddSpawnPoint("f_katyn_7.Id3", "f_katyn_7", Rectangle(-1008, 34, 9999));

		// 'Bushspider' GenType 10009 Spawn Points
		AddSpawnPoint("f_katyn_7.Id4", "f_katyn_7", Rectangle(-1258, 1744, 9999));

		// 'Ellom' GenType 10010 Spawn Points
		AddSpawnPoint("f_katyn_7.Id5", "f_katyn_7", Rectangle(-766, 3256, 275));

		// 'Pappus_Kepa' GenType 10011 Spawn Points
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-195, 1798, 30));
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-408, 1903, 30));
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-357, 2160, 30));
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-447, 2034, 30));
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-212, 1626, 30));
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-77, 1555, 30));
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-165, 1424, 30));
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-177, 1222, 30));
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-2, 890, 30));
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-168, 660, 30));
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-377, 1053, 30));

		// 'Bushspider' GenType 10012 Spawn Points
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-227, 958, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-438, 920, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-333, 1109, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-399, 614, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-178, 670, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-371, 747, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-63, 1058, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-32, 1271, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-184, 1310, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(33, 776, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-179, 1660, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-502, 1086, 30));

		// 'Fisherman' GenType 10013 Spawn Points
		AddSpawnPoint("f_katyn_7.Id8", "f_katyn_7", Rectangle(-281, -737, 9999));

		// 'Ellom' GenType 10017 Spawn Points
		AddSpawnPoint("f_katyn_7.Id9", "f_katyn_7", Rectangle(-742, 3321, 20));
		AddSpawnPoint("f_katyn_7.Id9", "f_katyn_7", Rectangle(-933, 3145, 20));
		AddSpawnPoint("f_katyn_7.Id9", "f_katyn_7", Rectangle(-1172, 3226, 20));
		AddSpawnPoint("f_katyn_7.Id9", "f_katyn_7", Rectangle(-924, 3302, 20));
		AddSpawnPoint("f_katyn_7.Id9", "f_katyn_7", Rectangle(-921, 3545, 20));
		AddSpawnPoint("f_katyn_7.Id9", "f_katyn_7", Rectangle(-484, 3375, 20));
		AddSpawnPoint("f_katyn_7.Id9", "f_katyn_7", Rectangle(-479, 3502, 20));
		AddSpawnPoint("f_katyn_7.Id9", "f_katyn_7", Rectangle(-1328, 3419, 20));
		AddSpawnPoint("f_katyn_7.Id9", "f_katyn_7", Rectangle(-849, 3723, 20));
		AddSpawnPoint("f_katyn_7.Id9", "f_katyn_7", Rectangle(-299, 3409, 20));

		// 'Fisherman' GenType 10022 Spawn Points
		AddSpawnPoint("f_katyn_7.Id10", "f_katyn_7", Rectangle(-2046, 1274, 400));
	}
}
