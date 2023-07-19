//--- Melia Script -----------------------------------------------------------
// f_katyn_13_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Secret Room' map.
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

		AddSpawner("f_katyn_13_2.Id1", MonsterId.Mushroom_Boy_Red, 30, 40, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("f_katyn_13_2.Id2", MonsterId.Mushroom_Ent, 15, 20, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("f_katyn_13_2.Id3", MonsterId.Mushroom_Boy_Red, 3, 3, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_katyn_13_2.Id4", MonsterId.Swordmaster, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_katyn_13_2.Id5", MonsterId.Archermaster, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_katyn_13_2.Id6", MonsterId.Wizardmaster, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_katyn_13_2.Id7", MonsterId.Mushroom_Boy_Red, 19, 25, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Mushroom_Boy_Red' GenType 102 Spawn Points
		AddSpawnPoint("f_katyn_13_2.Id1", "f_katyn_13_2", Rectangle(-162.46576, -1998.9631, 9999));

		// 'Mushroom_Ent' GenType 105 Spawn Points
		AddSpawnPoint("f_katyn_13_2.Id2", "f_katyn_13_2", Rectangle(-1293.4271, 1492.9653, 9999));

		// 'Mushroom_Boy_Red' GenType 106 Spawn Points
		AddSpawnPoint("f_katyn_13_2.Id3", "f_katyn_13_2", Rectangle(-227.26, -1965.17, 300));

		// 'Swordmaster' GenType 202 Spawn Points
		AddSpawnPoint("f_katyn_13_2.Id4", "f_katyn_13_2", Rectangle(-403, -1878.91, 20));

		// 'Archermaster' GenType 203 Spawn Points
		AddSpawnPoint("f_katyn_13_2.Id5", "f_katyn_13_2", Rectangle(-313.73, -2113.53, 20));

		// 'Wizardmaster' GenType 204 Spawn Points
		AddSpawnPoint("f_katyn_13_2.Id6", "f_katyn_13_2", Rectangle(-312.74, -1747.03, 20));

		// 'Mushroom_Boy_Red' GenType 206 Spawn Points
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(-216.52788, -1713.0366, 30));
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(-327.94702, -1848.8572, 30));
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(-232.98715, -2046.5466, 30));
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(-70.585236, -2023.15, 30));
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(-110.33405, -1855.1942, 30));
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(-19.71203, -1690.4005, 30));
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(55.91324, -1930.4796, 30));
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(-360.7234, -2090.9502, 30));
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(-595.2442, -2054.4976, 30));
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(-54.833138, -1476.0273, 30));
		AddSpawnPoint("f_katyn_13_2.Id7", "f_katyn_13_2", Rectangle(-40.26753, -1268.6481, 30));
	}
}
