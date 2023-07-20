//--- Melia Script -----------------------------------------------------------
// Arrow Path Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_katyn_13_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn133MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_katyn_13_3.Id1", MonsterId.New_Desmodus, 15, 20, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("f_katyn_13_3.Id2", MonsterId.Ellom_Green, 8, 10, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("f_katyn_13_3.Id3", MonsterId.InfroRocktor_Red, 12, 15, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("f_katyn_13_3.Id4", MonsterId.InfroRocktor_Red, 15, 20, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_katyn_13_3.Id5", MonsterId.New_Desmodus, 15, 20, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'New_Desmodus' GenType 3 Spawn Points
		AddSpawnPoint("f_katyn_13_3.Id1", "f_katyn_13_3", Rectangle(1755, 283, 9999));

		// 'Ellom_Green' GenType 4 Spawn Points
		AddSpawnPoint("f_katyn_13_3.Id2", "f_katyn_13_3", Rectangle(277, 243, 9999));

		// 'InfroRocktor_Red' GenType 6 Spawn Points
		AddSpawnPoint("f_katyn_13_3.Id3", "f_katyn_13_3", Rectangle(-1401, 379, 9999));

		// 'InfroRocktor_Red' GenType 7 Spawn Points
		AddSpawnPoint("f_katyn_13_3.Id4", "f_katyn_13_3", Rectangle(1301, 298, 30));
		AddSpawnPoint("f_katyn_13_3.Id4", "f_katyn_13_3", Rectangle(1579, 246, 30));
		AddSpawnPoint("f_katyn_13_3.Id4", "f_katyn_13_3", Rectangle(1724, 121, 30));
		AddSpawnPoint("f_katyn_13_3.Id4", "f_katyn_13_3", Rectangle(1741, 576, 30));
		AddSpawnPoint("f_katyn_13_3.Id4", "f_katyn_13_3", Rectangle(1917, 385, 30));
		AddSpawnPoint("f_katyn_13_3.Id4", "f_katyn_13_3", Rectangle(1744, 262, 30));
		AddSpawnPoint("f_katyn_13_3.Id4", "f_katyn_13_3", Rectangle(1635, 499, 30));
		AddSpawnPoint("f_katyn_13_3.Id4", "f_katyn_13_3", Rectangle(1874, 572, 30));
		AddSpawnPoint("f_katyn_13_3.Id4", "f_katyn_13_3", Rectangle(1783, 414, 30));

		// 'New_Desmodus' GenType 8 Spawn Points
		AddSpawnPoint("f_katyn_13_3.Id5", "f_katyn_13_3", Rectangle(1518, 283, 30));
		AddSpawnPoint("f_katyn_13_3.Id5", "f_katyn_13_3", Rectangle(1694, 199, 30));
		AddSpawnPoint("f_katyn_13_3.Id5", "f_katyn_13_3", Rectangle(1644, 397, 30));
		AddSpawnPoint("f_katyn_13_3.Id5", "f_katyn_13_3", Rectangle(1691, 578, 30));
		AddSpawnPoint("f_katyn_13_3.Id5", "f_katyn_13_3", Rectangle(1826, 478, 30));
		AddSpawnPoint("f_katyn_13_3.Id5", "f_katyn_13_3", Rectangle(1993, 412, 30));
		AddSpawnPoint("f_katyn_13_3.Id5", "f_katyn_13_3", Rectangle(1783, 119, 30));
		AddSpawnPoint("f_katyn_13_3.Id5", "f_katyn_13_3", Rectangle(1756, 300, 30));
		AddSpawnPoint("f_katyn_13_3.Id5", "f_katyn_13_3", Rectangle(1918, 308, 30));
		AddSpawnPoint("f_katyn_13_3.Id5", "f_katyn_13_3", Rectangle(1506, 438, 30));
		AddSpawnPoint("f_katyn_13_3.Id5", "f_katyn_13_3", Rectangle(1168, 320, 30));
		AddSpawnPoint("f_katyn_13_3.Id5", "f_katyn_13_3", Rectangle(1449, 145, 30));
		AddSpawnPoint("f_katyn_13_3.Id5", "f_katyn_13_3", Rectangle(1383, 255, 30));
		AddSpawnPoint("f_katyn_13_3.Id5", "f_katyn_13_3", Rectangle(1621, 117, 30));
	}
}
