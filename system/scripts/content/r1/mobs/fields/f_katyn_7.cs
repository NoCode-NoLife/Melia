//--- Melia Script -----------------------------------------------------------
// f_katyn_7
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Entrance of Kateen Forest' map.
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
		AddSpawnPoint("f_katyn_7.Id2", "f_katyn_7", Rectangle(927.6994, -2268.3066, 9999));

		// 'Pappus_Kepa' GenType 10008 Spawn Points
		AddSpawnPoint("f_katyn_7.Id3", "f_katyn_7", Rectangle(-1008.579, 34.71529, 9999));

		// 'Bushspider' GenType 10009 Spawn Points
		AddSpawnPoint("f_katyn_7.Id4", "f_katyn_7", Rectangle(-1258.1116, 1744.982, 9999));

		// 'Ellom' GenType 10010 Spawn Points
		AddSpawnPoint("f_katyn_7.Id5", "f_katyn_7", Rectangle(-766.02924, 3256.867, 275));

		// 'Pappus_Kepa' GenType 10011 Spawn Points
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-195, 1798, 30));
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-408.50067, 1903.7605, 30));
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-357.05298, 2160.783, 30));
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-447.0964, 2034.5729, 30));
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-212.75533, 1626.2478, 30));
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-77.39426, 1555.8328, 30));
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-165.34433, 1424.4225, 30));
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-177.28043, 1222.3451, 30));
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-2.4099197, 890.81885, 30));
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-168.38225, 660.0151, 30));
		AddSpawnPoint("f_katyn_7.Id6", "f_katyn_7", Rectangle(-377.47775, 1053.2151, 30));

		// 'Bushspider' GenType 10012 Spawn Points
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-227.57834, 958.3283, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-438.8225, 920.1881, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-333.58322, 1109.5657, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-399.75397, 614.409, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-178.58769, 670.884, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-371.37378, 747.3366, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-63.39987, 1058.0623, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-32.866924, 1271.0573, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-184.69601, 1310.3783, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(33.831566, 776.466, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-179.23944, 1660.6945, 30));
		AddSpawnPoint("f_katyn_7.Id7", "f_katyn_7", Rectangle(-502.4433, 1086.6884, 30));

		// 'Fisherman' GenType 10013 Spawn Points
		AddSpawnPoint("f_katyn_7.Id8", "f_katyn_7", Rectangle(-281.53958, -737.38257, 9999));

		// 'Ellom' GenType 10017 Spawn Points
		AddSpawnPoint("f_katyn_7.Id9", "f_katyn_7", Rectangle(-742.2518, 3321.5752, 20));
		AddSpawnPoint("f_katyn_7.Id9", "f_katyn_7", Rectangle(-933.58466, 3145.1191, 20));
		AddSpawnPoint("f_katyn_7.Id9", "f_katyn_7", Rectangle(-1172.1798, 3226.943, 20));
		AddSpawnPoint("f_katyn_7.Id9", "f_katyn_7", Rectangle(-924.4441, 3302.0566, 20));
		AddSpawnPoint("f_katyn_7.Id9", "f_katyn_7", Rectangle(-921.4084, 3545.3196, 20));
		AddSpawnPoint("f_katyn_7.Id9", "f_katyn_7", Rectangle(-484.0555, 3375.5715, 20));
		AddSpawnPoint("f_katyn_7.Id9", "f_katyn_7", Rectangle(-479.45477, 3502.4744, 20));
		AddSpawnPoint("f_katyn_7.Id9", "f_katyn_7", Rectangle(-1328.2063, 3419.2942, 20));
		AddSpawnPoint("f_katyn_7.Id9", "f_katyn_7", Rectangle(-849.8979, 3723.3157, 20));
		AddSpawnPoint("f_katyn_7.Id9", "f_katyn_7", Rectangle(-299.75748, 3409.9426, 20));

		// 'Fisherman' GenType 10022 Spawn Points
		AddSpawnPoint("f_katyn_7.Id10", "f_katyn_7", Rectangle(-2046.5919, 1274.36, 400));
	}
}
