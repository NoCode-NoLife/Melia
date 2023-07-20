//--- Melia Script -----------------------------------------------------------
// Siauliai Raid Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'raid_siauliai1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class RaidSiauliai1MobScript : GeneralScript
{
	public override void Load()
	{
		AddSpawner("raid_siauliai1.Id1", MonsterId.Rootcrystal_01, 1, 1, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);

		// 'Rootcrystal_01' GenType 1 Spawn Points
		AddSpawnPoint("raid_siauliai1.Id1", "raid_siauliai1", Rectangle(-464, -1298, 100));
		AddSpawnPoint("raid_siauliai1.Id1", "raid_siauliai1", Rectangle(-301, -1335, 100));
		AddSpawnPoint("raid_siauliai1.Id1", "raid_siauliai1", Rectangle(-416, -686, 100));
		AddSpawnPoint("raid_siauliai1.Id1", "raid_siauliai1", Rectangle(-118, -623, 100));
		AddSpawnPoint("raid_siauliai1.Id1", "raid_siauliai1", Rectangle(-167, 13, 100));
		AddSpawnPoint("raid_siauliai1.Id1", "raid_siauliai1", Rectangle(-89, 260, 100));
		AddSpawnPoint("raid_siauliai1.Id1", "raid_siauliai1", Rectangle(121, 1, 100));
		AddSpawnPoint("raid_siauliai1.Id1", "raid_siauliai1", Rectangle(25, 845, 100));
		AddSpawnPoint("raid_siauliai1.Id1", "raid_siauliai1", Rectangle(262, 769, 100));
		AddSpawnPoint("raid_siauliai1.Id1", "raid_siauliai1", Rectangle(378, 1080, 100));
		AddSpawnPoint("raid_siauliai1.Id1", "raid_siauliai1", Rectangle(118, 1216, 100));
	}
}
