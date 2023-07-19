//--- Melia Script -----------------------------------------------------------
// mission_chaple_01
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Cathedral Mission' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class MissionChaple01MobScript : GeneralScript
{
	public override void Load()
	{
		AddSpawner("mission_chaple_01.Id1", MonsterId.Rootcrystal_01, 1, 1, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);

		// 'Rootcrystal_01' GenType 1 Spawn Points
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-148.58258, -891.9434, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-157.27663, -522.0643, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-157.39291, -139.19846, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-151.13141, 394.47, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-811.625, -445.343, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-1132.8901, -481.32266, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-953.7954, 145.40656, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-917.4607, 460.85962, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-402.20044, -101.58805, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(93.64743, -117.63123, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(692.2395, -611.62787, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(699.57263, -257.33868, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(696.42096, 168.37576, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(782.89825, 497.58707, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-342.94745, 1026.144, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-341.34805, 1262.7799, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(36.199104, 1241.915, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(12.125877, 1019.7944, 100));
	}
}
