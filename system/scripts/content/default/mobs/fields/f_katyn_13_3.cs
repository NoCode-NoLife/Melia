//--- Melia Script -----------------------------------------------------------
// f_katyn_13_3
//
//--- Description -----------------------------------------------------------
// Sets up the f_katyn_13_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn133MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Populations
		var NewDesmodus_1_20 = AddMonsterGenerator(MonsterId.New_Desmodus, "f_katyn_13_3", 20);
		var EllomGreen_2_10 = AddMonsterGenerator(MonsterId.Ellom_Green, "f_katyn_13_3", 10);
		var InfrorocktorRed_3_15 = AddMonsterGenerator(MonsterId.InfroRocktor_Red, "f_katyn_13_3", 15);
		var InfrorocktorRed_4_20 = AddMonsterGenerator(MonsterId.InfroRocktor_Red, "f_katyn_13_3", 20);
		var NewDesmodus_5_20 = AddMonsterGenerator(MonsterId.New_Desmodus, "f_katyn_13_3", 20);

		// Monster Spawners
		AddSpawnPoint(NewDesmodus_1_20, TimeSpan.FromMilliseconds(15000), "f_katyn_13_3", Spot(1755.9845, 283.45026, 9999));
		AddSpawnPoint(EllomGreen_2_10, TimeSpan.FromMilliseconds(15000), "f_katyn_13_3", Spot(277.87488, 243.53528, 9999));
		AddSpawnPoint(InfrorocktorRed_3_15, TimeSpan.FromMilliseconds(15000), "f_katyn_13_3", Spot(-1401.751, 379.45532, 9999));
		AddSpawnPoint(InfrorocktorRed_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1301.7783, 298.5942, 30));
		AddSpawnPoint(InfrorocktorRed_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1579.7003, 246.58012, 30));
		AddSpawnPoint(InfrorocktorRed_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1724.1985, 121.16917, 30));
		AddSpawnPoint(InfrorocktorRed_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1741.9368, 576.2671, 30));
		AddSpawnPoint(InfrorocktorRed_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1917.9528, 385.7499, 30));
		AddSpawnPoint(InfrorocktorRed_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1744.9395, 262.5108, 30));
		AddSpawnPoint(InfrorocktorRed_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1635.6881, 499.0037, 30));
		AddSpawnPoint(InfrorocktorRed_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1874.808, 572.55164, 30));
		AddSpawnPoint(InfrorocktorRed_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1783.8633, 414.26562, 30));
		AddSpawnPoint(NewDesmodus_5_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1518.3115, 283.14474, 30));
		AddSpawnPoint(NewDesmodus_5_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1694.0133, 199.92749, 30));
		AddSpawnPoint(NewDesmodus_5_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1644.1213, 397.5618, 30));
		AddSpawnPoint(NewDesmodus_5_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1691.9999, 578.1614, 30));
		AddSpawnPoint(NewDesmodus_5_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1826.4536, 478.1889, 30));
		AddSpawnPoint(NewDesmodus_5_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1993.1733, 412.3926, 30));
		AddSpawnPoint(NewDesmodus_5_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1783.1538, 119.99742, 30));
		AddSpawnPoint(NewDesmodus_5_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1756.9548, 300.27124, 30));
		AddSpawnPoint(NewDesmodus_5_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1918.4325, 308.71857, 30));
		AddSpawnPoint(NewDesmodus_5_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1506.6051, 438.11392, 30));
		AddSpawnPoint(NewDesmodus_5_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1168.9093, 320.50067, 30));
		AddSpawnPoint(NewDesmodus_5_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1449.715, 145.5412, 30));
		AddSpawnPoint(NewDesmodus_5_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1383.36, 255.07632, 30));
		AddSpawnPoint(NewDesmodus_5_20, TimeSpan.FromMilliseconds(5000), "f_katyn_13_3", Spot(1621.4419, 117.26129, 30));

	}
}
