//--- Melia Script -----------------------------------------------------------
// Cathedral Mission Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'mission_chaple_01'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class MissionChaple01MobScript : GeneralScript
{
	public override void Load()
	{
		AddSpawner("mission_chaple_01.Id1", MonsterId.Rootcrystal_01, amount: 1, respawn: TimeSpan.FromMilliseconds(15000));

		// 'Rootcrystal_01' GenType 1 Spawn Points
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-148, -891, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-157, -522, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-157, -139, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-151, 394, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-811, -445, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-1132, -481, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-953, 145, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-917, 460, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-402, -101, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(93, -117, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(692, -611, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(699, -257, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(696, 168, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(782, 497, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-342, 1026, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(-341, 1262, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(36, 1241, 100));
		AddSpawnPoint("mission_chaple_01.Id1", "mission_chaple_01", Rectangle(12, 1019, 100));
	}
}
