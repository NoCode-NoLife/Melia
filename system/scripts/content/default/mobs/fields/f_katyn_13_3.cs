//--- Melia Script -----------------------------------------------------------
// f_katyn_13_3
//
//--- Description -----------------------------------------------------------
// Sets up the f_katyn_13_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn133MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner(MonsterId.New_Desmodus, 20, "SpawnPointCollection1.f_katyn_13_3", TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Ellom_Green, 10, "SpawnPointCollection2.f_katyn_13_3", TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner(MonsterId.InfroRocktor_Red, 15, "SpawnPointCollection3.f_katyn_13_3", TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner(MonsterId.InfroRocktor_Red, 20, "SpawnPointCollection4.f_katyn_13_3", TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner(MonsterId.New_Desmodus, 20, "SpawnPointCollection5.f_katyn_13_3", TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// New_Desmodus Spawn Points
		AddSpawnPoint("f_katyn_13_3", Spot(1755.9845, 283.45026, 9999), "SpawnPointCollection1.f_katyn_13_3");

		// Ellom_Green Spawn Points
		AddSpawnPoint("f_katyn_13_3", Spot(277.87488, 243.53528, 9999), "SpawnPointCollection2.f_katyn_13_3");

		// InfroRocktor_Red Spawn Points
		AddSpawnPoint("f_katyn_13_3", Spot(-1401.751, 379.45532, 9999), "SpawnPointCollection3.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1301.7783, 298.5942, 30), "SpawnPointCollection4.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1579.7003, 246.58012, 30), "SpawnPointCollection4.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1724.1985, 121.16917, 30), "SpawnPointCollection4.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1741.9368, 576.2671, 30), "SpawnPointCollection4.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1917.9528, 385.7499, 30), "SpawnPointCollection4.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1744.9395, 262.5108, 30), "SpawnPointCollection4.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1635.6881, 499.0037, 30), "SpawnPointCollection4.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1874.808, 572.55164, 30), "SpawnPointCollection4.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1783.8633, 414.26562, 30), "SpawnPointCollection4.f_katyn_13_3");

		// New_Desmodus Spawn Points
		AddSpawnPoint("f_katyn_13_3", Spot(1518.3115, 283.14474, 30), "SpawnPointCollection5.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1694.0133, 199.92749, 30), "SpawnPointCollection5.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1644.1213, 397.5618, 30), "SpawnPointCollection5.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1691.9999, 578.1614, 30), "SpawnPointCollection5.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1826.4536, 478.1889, 30), "SpawnPointCollection5.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1993.1733, 412.3926, 30), "SpawnPointCollection5.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1783.1538, 119.99742, 30), "SpawnPointCollection5.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1756.9548, 300.27124, 30), "SpawnPointCollection5.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1918.4325, 308.71857, 30), "SpawnPointCollection5.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1506.6051, 438.11392, 30), "SpawnPointCollection5.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1168.9093, 320.50067, 30), "SpawnPointCollection5.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1449.715, 145.5412, 30), "SpawnPointCollection5.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1383.36, 255.07632, 30), "SpawnPointCollection5.f_katyn_13_3");
		AddSpawnPoint("f_katyn_13_3", Spot(1621.4419, 117.26129, 30), "SpawnPointCollection5.f_katyn_13_3");

	}
}
