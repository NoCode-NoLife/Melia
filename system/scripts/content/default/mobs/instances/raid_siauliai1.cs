//--- Melia Script -----------------------------------------------------------
// raid_siauliai1
//
//--- Description -----------------------------------------------------------
// Sets up the raid_siauliai1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class RaidSiauliai1MobScript : GeneralScript
{
	public override void Load()
	{
		AddSpawner("raid_siauliai1.Id1", MonsterId.Rootcrystal_01, 1, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "raid_siauliai1.Id1", "raid_siauliai1", Spot(-464.7043, -1298.4799, 100));
		AddSpawnPoint( "raid_siauliai1.Id1", "raid_siauliai1", Spot(-301.05234, -1335.3169, 100));
		AddSpawnPoint( "raid_siauliai1.Id1", "raid_siauliai1", Spot(-416.9353, -686.42535, 100));
		AddSpawnPoint( "raid_siauliai1.Id1", "raid_siauliai1", Spot(-118.94096, -623.6209, 100));
		AddSpawnPoint( "raid_siauliai1.Id1", "raid_siauliai1", Spot(-167.15977, 13.694931, 100));
		AddSpawnPoint( "raid_siauliai1.Id1", "raid_siauliai1", Spot(-89.57201, 260.67822, 100));
		AddSpawnPoint( "raid_siauliai1.Id1", "raid_siauliai1", Spot(121.61159, 1.2747784, 100));
		AddSpawnPoint( "raid_siauliai1.Id1", "raid_siauliai1", Spot(25.610964, 845.4364, 100));
		AddSpawnPoint( "raid_siauliai1.Id1", "raid_siauliai1", Spot(262.95966, 769.5088, 100));
		AddSpawnPoint( "raid_siauliai1.Id1", "raid_siauliai1", Spot(378.44647, 1080.6187, 100));
		AddSpawnPoint( "raid_siauliai1.Id1", "raid_siauliai1", Spot(118.64677, 1216.3112, 100));

	}
}
