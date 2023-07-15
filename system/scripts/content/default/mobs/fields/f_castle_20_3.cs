//--- Melia Script -----------------------------------------------------------
// f_castle_20_3
//
//--- Description -----------------------------------------------------------
// Sets up the f_castle_20_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle203MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_castle_20_3", MonsterId.Aklasdame, Properties("MHP", 524595, "MINPATK", 7247, "MAXPATK", 8808, "MINMATK", 7247, "MAXMATK", 8808, "DEF", 90100, "MDEF", 90100));
		AddPropertyOverrides("f_castle_20_3", MonsterId.Aklastyke, Properties("MHP", 525104, "MINPATK", 7254, "MAXPATK", 8816, "MINMATK", 7254, "MAXMATK", 8816, "DEF", 90351, "MDEF", 90351));
		AddPropertyOverrides("f_castle_20_3", MonsterId.Aklasbairn, Properties("MHP", 526033, "MINPATK", 7265, "MAXPATK", 8831, "MINMATK", 7265, "MAXMATK", 8831, "DEF", 90811, "MDEF", 90811));

		// Monster Spawners --------------------------------

		AddSpawner("f_castle_20_3.Id1", MonsterId.Rootcrystal_01, 12, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_20_3.Id2", MonsterId.Aklasdame, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_castle_20_3.Id3", MonsterId.Aklastyke, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_castle_20_3.Id4", MonsterId.Aklasbairn, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_castle_20_3.Id1", "f_castle_20_3", Spot(-1541.0963, -529.34467, 100));
		AddSpawnPoint( "f_castle_20_3.Id1", "f_castle_20_3", Spot(-1197.7561, -1037.2322, 100));
		AddSpawnPoint( "f_castle_20_3.Id1", "f_castle_20_3", Spot(-1184.5298, -481.73285, 100));
		AddSpawnPoint( "f_castle_20_3.Id1", "f_castle_20_3", Spot(-1127.7526, -149.79298, 100));
		AddSpawnPoint( "f_castle_20_3.Id1", "f_castle_20_3", Spot(-686.1157, 283.56226, 100));
		AddSpawnPoint( "f_castle_20_3.Id1", "f_castle_20_3", Spot(-117.70576, -147.61577, 100));
		AddSpawnPoint( "f_castle_20_3.Id1", "f_castle_20_3", Spot(407.82693, -669.0407, 100));
		AddSpawnPoint( "f_castle_20_3.Id1", "f_castle_20_3", Spot(340.69525, -86.488365, 100));
		AddSpawnPoint( "f_castle_20_3.Id1", "f_castle_20_3", Spot(927.3135, -262.92822, 100));
		AddSpawnPoint( "f_castle_20_3.Id1", "f_castle_20_3", Spot(250.3851, 391.70633, 100));
		AddSpawnPoint( "f_castle_20_3.Id1", "f_castle_20_3", Spot(-664.68225, 1082.7627, 100));
		AddSpawnPoint( "f_castle_20_3.Id1", "f_castle_20_3", Spot(-168.11142, 613.2107, 100));

		// Aklasdame Spawn Points
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-1456.93, -755.63, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-1383.44, -977.3, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-1502.22, -1015.3, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-1196.94, -1041.38, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-1163.03, -930.02, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-1347.19, -887.82, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-1304.65, -778.05, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-1066.85, -784.38, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-1180.99, -509.85, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-1189.5, -273.98, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-1243.36, -116.95, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-1101.14, -39.5, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-1114.3, -159.92, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-939.68, -85.98, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-695.37, -559.18, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-711.75, -205.88, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-783.4, -21.16, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-651.39, 21.17, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-614.49, -112.58, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-716.97, -632.07, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-608.08, -717.81, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-680.57, -469.33, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-717.52, -310.25, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-425.23, -95.63, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-190.03, -81.37, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-83.19, -111.83, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-163.18, -217.88, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-158.74, -433.09, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-113.39, -577.86, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-217.3, -595.81, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-207.61, -678.71, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-110.01, -706.17, 40));
		AddSpawnPoint( "f_castle_20_3.Id2", "f_castle_20_3", Spot(-59.57, -558.99, 40));

		// Aklastyke Spawn Points
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-682.6, 454.83, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-771.95, 594.16, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-667.93, 929.21, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-638.26, 665.86, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-774.07, 721.61, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-528.36, 722.95, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-218.42, 1004.84, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-266.9, 1064.73, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-355.18, 992.85, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-280.27, 850.33, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-286.57, 712.82, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-315.56, 634.99, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-186.38, 599.01, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-40.62, 489.17, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(126.11, 586.67, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(42.31, 438.67, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(131.36, 426.89, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(343.03, 292.49, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(297.3, 144.14, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(371.92, 51.22, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(416.27, -45.42, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(407.69, -189.95, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(244.78, -204.58, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(258.51, -29.32, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(309.8, -125.24, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(70.35487, 565.6595, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(60.233955, -94.1298, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(798.1, -382.64, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(1005.65, -353.74, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(899.16, -328.06, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(818.66, -230.72, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(945.02, -149.25, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-1490.54, -1126.4, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-1581.33, -1133.68, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-1572.46, -950.91, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-1676.58, -819, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-1625.49, -630.8, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-1405.16, -629.86, 40));
		AddSpawnPoint( "f_castle_20_3.Id3", "f_castle_20_3", Spot(-1310.73, -1135.94, 40));

		// Aklasbairn Spawn Points
		AddSpawnPoint( "f_castle_20_3.Id4", "f_castle_20_3", Spot(228.89, -79.33, 9999));

	}
}
