//--- Melia Script -----------------------------------------------------------
// mission_chaple_01
//
//--- Description -----------------------------------------------------------
// Sets up the mission_chaple_01 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class MissionChaple01MobScript : GeneralScript
{
	public override void Load()
	{
		AddSpawner("mission_chaple_01.Id1", MonsterId.Rootcrystal_01, 1, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "mission_chaple_01.Id1", "mission_chaple_01", Spot(-148.58258, -891.9434, 100));
		AddSpawnPoint( "mission_chaple_01.Id1", "mission_chaple_01", Spot(-157.27663, -522.0643, 100));
		AddSpawnPoint( "mission_chaple_01.Id1", "mission_chaple_01", Spot(-157.39291, -139.19846, 100));
		AddSpawnPoint( "mission_chaple_01.Id1", "mission_chaple_01", Spot(-151.13141, 394.47, 100));
		AddSpawnPoint( "mission_chaple_01.Id1", "mission_chaple_01", Spot(-811.625, -445.343, 100));
		AddSpawnPoint( "mission_chaple_01.Id1", "mission_chaple_01", Spot(-1132.8901, -481.32266, 100));
		AddSpawnPoint( "mission_chaple_01.Id1", "mission_chaple_01", Spot(-953.7954, 145.40656, 100));
		AddSpawnPoint( "mission_chaple_01.Id1", "mission_chaple_01", Spot(-917.4607, 460.85962, 100));
		AddSpawnPoint( "mission_chaple_01.Id1", "mission_chaple_01", Spot(-402.20044, -101.58805, 100));
		AddSpawnPoint( "mission_chaple_01.Id1", "mission_chaple_01", Spot(93.64743, -117.63123, 100));
		AddSpawnPoint( "mission_chaple_01.Id1", "mission_chaple_01", Spot(692.2395, -611.62787, 100));
		AddSpawnPoint( "mission_chaple_01.Id1", "mission_chaple_01", Spot(699.57263, -257.33868, 100));
		AddSpawnPoint( "mission_chaple_01.Id1", "mission_chaple_01", Spot(696.42096, 168.37576, 100));
		AddSpawnPoint( "mission_chaple_01.Id1", "mission_chaple_01", Spot(782.89825, 497.58707, 100));
		AddSpawnPoint( "mission_chaple_01.Id1", "mission_chaple_01", Spot(-342.94745, 1026.144, 100));
		AddSpawnPoint( "mission_chaple_01.Id1", "mission_chaple_01", Spot(-341.34805, 1262.7799, 100));
		AddSpawnPoint( "mission_chaple_01.Id1", "mission_chaple_01", Spot(36.199104, 1241.915, 100));
		AddSpawnPoint( "mission_chaple_01.Id1", "mission_chaple_01", Spot(12.125877, 1019.7944, 100));

	}
}
