//--- Melia Script -----------------------------------------------------------
// mission_gele_01
//
//--- Description -----------------------------------------------------------
// Sets up the mission_gele_01 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class MissionGele01MobScript : GeneralScript
{
	public override void Load()
	{
		AddMonsterPopulation("mission_gele_01", "population_rootcrystal_01_1", 15);

		// RootCrystal Spawners
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(15000), "mission_gele_01", Spot(-95.009, -929.8088, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(15000), "mission_gele_01", Spot(231.64508, -883.62427, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(15000), "mission_gele_01", Spot(175.36555, -5.177535, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(15000), "mission_gele_01", Spot(239.722, 154.4829, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(15000), "mission_gele_01", Spot(742.38605, -22.150063, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(15000), "mission_gele_01", Spot(964.5252, 180.74976, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(15000), "mission_gele_01", Spot(726.8989, 209.88397, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(15000), "mission_gele_01", Spot(915.8323, 700.65247, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(15000), "mission_gele_01", Spot(924.107, 944.0666, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(15000), "mission_gele_01", Spot(1260.5366, 605.22736, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(15000), "mission_gele_01", Spot(402.4784, 888.89246, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(15000), "mission_gele_01", Spot(173.53911, 830.22595, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(15000), "mission_gele_01", Spot(-13.768617, 833.5725, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(15000), "mission_gele_01", Spot(-225.97227, 838.0146, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(15000), "mission_gele_01", Spot(-607.3291, 1059.6671, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(15000), "mission_gele_01", Spot(-885.4174, 478.6022, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(15000), "mission_gele_01", Spot(-979.113, 260.32617, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(15000), "mission_gele_01", Spot(-771.05475, 164.05145, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(15000), "mission_gele_01", Spot(-597.94574, -579.91, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(15000), "mission_gele_01", Spot(-441.26657, -501.85672, 100));

	}
}
