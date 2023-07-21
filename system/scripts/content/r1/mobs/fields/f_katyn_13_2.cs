//--- Melia Script -----------------------------------------------------------
// Secret Room Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_katyn_13_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn132MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_katyn_13_2.Id1", MonsterId.Mushroom_Boy_Red, min: 30, max: 40, respawn: TimeSpan.FromMilliseconds(15000));
		AddSpawner("f_katyn_13_2.Id2", MonsterId.Mushroom_Ent, min: 15, max: 20, respawn: TimeSpan.FromMilliseconds(15000));
		AddSpawner("f_katyn_13_2.Id3", MonsterId.Mushroom_Boy_Red, amount: 3, respawn: TimeSpan.FromMilliseconds(20000));
		AddSpawner("f_katyn_13_2.Id4", MonsterId.Swordmaster, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("f_katyn_13_2.Id5", MonsterId.Archermaster, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("f_katyn_13_2.Id6", MonsterId.Wizardmaster, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("f_katyn_13_2.Id7", MonsterId.Mushroom_Boy_Red, min: 19, max: 25, respawn: TimeSpan.FromMilliseconds(5000));

		// Monster Spawn Points -----------------------------

		// 'Mushroom_Boy_Red' GenType 102 Spawn Points
		AddSpawnPoint("f_katyn_13_2.Id1", "f_katyn_13_2", Rectangle(-162, -1998, 9999));

		// 'Mushroom_Ent' GenType 105 Spawn Points
		AddSpawnPoint("f_katyn_13_2.Id2", "f_katyn_13_2", Rectangle(-1293, 1492, 9999));

		// 'Mushroom_Boy_Red' GenType 106 Spawn Points
		AddSpawnPoint("f_katyn_13_2.Id3", "f_katyn_13_2", Rectangle(-227, -1965, 300));

		// 'Swordmaster' GenType 202 Spawn Points
		AddSpawnPoint("f_katyn_13_2.Id4", "f_katyn_13_2", Rectangle(-403, -1878, 20));

		// 'Archermaster' GenType 203 Spawn Points
		AddSpawnPoint("f_katyn_13_2.Id5", "f_katyn_13_2", Rectangle(-313, -2113, 20));

		// 'Wizardmaster' GenType 204 Spawn Points
		AddSpawnPoint("f_katyn_13_2.Id6", "f_katyn_13_2", Rectangle(-312, -1747, 20));

		// 'Mushroom_Boy_Red' GenType 206 Spawn Points
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(-216, -1713, 30));
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(-327, -1848, 30));
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(-232, -2046, 30));
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(-70, -2023, 30));
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(-110, -1855, 30));
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(-19, -1690, 30));
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(55, -1930, 30));
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(-360, -2090, 30));
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(-595, -2054, 30));
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(-54, -1476, 30));
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(-40, -1268, 30));
	}
}
