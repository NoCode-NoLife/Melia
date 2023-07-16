//--- Melia Script -----------------------------------------------------------
// f_whitetrees_21_2
//
//--- Description -----------------------------------------------------------
// Sets up the f_whitetrees_21_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FWhitetrees212MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_whitetrees_21_2", MonsterId.Kucarry_Symbani, Properties("MHP", 524595, "MINPATK", 7247, "MAXPATK", 8808, "MINMATK", 7247, "MAXMATK", 8808, "DEF", 90100, "MDEF", 90100));
		AddPropertyOverrides("f_whitetrees_21_2", MonsterId.Kucarry_Balzer, Properties("MHP", 525104, "MINPATK", 7254, "MAXPATK", 8816, "MINMATK", 7254, "MAXMATK", 8816, "DEF", 90351, "MDEF", 90351));
		AddPropertyOverrides("f_whitetrees_21_2", MonsterId.Kucarry_Zeffi, Properties("MHP", 526033, "MINPATK", 7265, "MAXPATK", 8831, "MINMATK", 7265, "MAXMATK", 8831, "DEF", 90811, "MDEF", 90811));

		// Monster Spawners --------------------------------

		AddSpawner("f_whitetrees_21_2.Id1", MonsterId.Kucarry_Symbani, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_2.Id2", MonsterId.Kucarry_Balzer, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_2.Id3", MonsterId.Kucarry_Zeffi, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_2.Id4", MonsterId.Kucarry_Zeffi, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_2.Id5", MonsterId.Kucarry_Balzer, 6, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_2.Id6", MonsterId.Kucarry_Symbani, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_2.Id7", MonsterId.Kucarry_Zeffi, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_2.Id8", MonsterId.Rootcrystal_01, 10, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Kucarry_Symbani Spawn Points
		AddSpawnPoint( "f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Spot(-696.17267, -578.4887, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Spot(-829.37, -778.58, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Spot(-819.8046, -783.5901, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Spot(-668.15, -444.48, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Spot(-736.62, -703.43, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Spot(-940.42, 196.68, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Spot(-907.52, 335.72, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Spot(-1113.6274, 142.00214, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Spot(-1364.32, 314.22, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Spot(-1319.97, -262.15, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Spot(-1063.3, -670.94, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Spot(-874.55, -472.75, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Spot(-1094.2931, -436.23712, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Spot(-1096.2598, 276.61102, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Spot(-1276.7303, 476.0331, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Spot(-1110.3308, 499.69208, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Spot(-832.48865, 193.04001, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Spot(-1400.7471, 19.260706, 40));

		// Kucarry_Balzer Spawn Points
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(-225.95, -900.74, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(39.878128, -944.2127, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(-356.43073, -707.2965, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(-162.01619, -375.26642, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(-397.07047, -2.3553314, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(-104.6418, 419.03943, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(-40.572342, 57.032448, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(-87.04341, -863.7772, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(558.22, -1095.99, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(522.41, -1235.2, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(722.7, -1239.44, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(829.02, -1125.78, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(338.85, -1130.57, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(229.98, 180.68, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(523.35, -115.29, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(629.37, 9.69, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(829.97, -80.18, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(991.06, 197.97, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(1038.27, 54.48, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(503.01, 84.71, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(-191.20767, 74.113625, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(-334.2644, 173.74074, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(-62.656765, 237.92851, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(-244.3581, -152.97993, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(-133.72343, -110.82402, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(226.17032, -955.6995, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Spot(55.625927, -815.7873, 40));

		// Kucarry_Zeffi Spawn Points
		AddSpawnPoint( "f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Spot(1504.44, 382.56, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Spot(905.32, 1845.81, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Spot(1018.17, 1588.49, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Spot(-40.38, 1082.79, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Spot(93.67, 1219.79, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Spot(104.7, 1067.44, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Spot(116.14, 962.15, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Spot(251.42, 1063.84, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Spot(216.6, 1528.68, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Spot(86.66, 1710.4, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Spot(285.22, 1780.21, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Spot(438.16, 1681.05, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Spot(322.38, 1616.69, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Spot(455.09, 1489.58, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Spot(805.77, 1702.66, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Spot(1014.59, 1727.2, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Spot(905.76, 1587.99, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Spot(352.96, 1450.4, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id4", "f_whitetrees_21_2", Spot(-1034.49, -1319.1, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id4", "f_whitetrees_21_2", Spot(-876.53, -1286.75, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id4", "f_whitetrees_21_2", Spot(-717.39, -1281.5, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id4", "f_whitetrees_21_2", Spot(-558.3, -1265.62, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id4", "f_whitetrees_21_2", Spot(-903.19, -1538.88, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id4", "f_whitetrees_21_2", Spot(-723.98, -1482.24, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id4", "f_whitetrees_21_2", Spot(-910.23, -1068.53, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id4", "f_whitetrees_21_2", Spot(-709.24, -1075.1, 40));

		// Kucarry_Balzer Spawn Points
		AddSpawnPoint( "f_whitetrees_21_2.Id5", "f_whitetrees_21_2", Spot(-1034.46, -1512.55, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id5", "f_whitetrees_21_2", Spot(-896.5, -1281.54, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id5", "f_whitetrees_21_2", Spot(-585.11, -1069.06, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id5", "f_whitetrees_21_2", Spot(-949.45, -1083.06, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id5", "f_whitetrees_21_2", Spot(-691.07, -1318.22, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id5", "f_whitetrees_21_2", Spot(-538.93, -1464.18, 40));

		// Kucarry_Symbani Spawn Points
		AddSpawnPoint( "f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Spot(-806.17, -1474.6, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Spot(-669.58, -1470.87, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Spot(-742.78, -1043.54, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Spot(-583.57, -1042.14, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Spot(-683.94, -1136.99, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Spot(-694.87, -1313.62, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Spot(-885.89, -1210.45, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Spot(-898.54, -1361.38, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Spot(-1069.19, -1319.36, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Spot(143.59, 1530.62, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Spot(485.56, 1647.99, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Spot(253.19, 1633.57, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Spot(11.65, 1123.59, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Spot(92.14, 982.64, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Spot(203.67, 1084.2, 40));
		AddSpawnPoint( "f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Spot(390.19, 1510.24, 40));

		// Kucarry_Zeffi Spawn Points
		AddSpawnPoint( "f_whitetrees_21_2.Id7", "f_whitetrees_21_2", Spot(696.42584, 10.6974, 9999));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_whitetrees_21_2.Id8", "f_whitetrees_21_2", Spot(-1074.41, -1301.22, 100));
		AddSpawnPoint( "f_whitetrees_21_2.Id8", "f_whitetrees_21_2", Spot(-1322.85, -203.36, 100));
		AddSpawnPoint( "f_whitetrees_21_2.Id8", "f_whitetrees_21_2", Spot(-713.48, 12.27, 100));
		AddSpawnPoint( "f_whitetrees_21_2.Id8", "f_whitetrees_21_2", Spot(333.11, 135.2, 100));
		AddSpawnPoint( "f_whitetrees_21_2.Id8", "f_whitetrees_21_2", Spot(378.5, 1571.4, 100));
		AddSpawnPoint( "f_whitetrees_21_2.Id8", "f_whitetrees_21_2", Spot(-23.57, 1091.91, 100));
		AddSpawnPoint( "f_whitetrees_21_2.Id8", "f_whitetrees_21_2", Spot(1215.04, 462.3, 100));
		AddSpawnPoint( "f_whitetrees_21_2.Id8", "f_whitetrees_21_2", Spot(445.04, -1126.3, 100));
		AddSpawnPoint( "f_whitetrees_21_2.Id8", "f_whitetrees_21_2", Spot(-103.03, -957.56, 100));
		AddSpawnPoint( "f_whitetrees_21_2.Id8", "f_whitetrees_21_2", Spot(-601.47, -577.89, 100));

	}
}
