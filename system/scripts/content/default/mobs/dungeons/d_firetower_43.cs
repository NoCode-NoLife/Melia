//--- Melia Script -----------------------------------------------------------
// d_firetower_43
//
//--- Description -----------------------------------------------------------
// Sets up the d_firetower_43 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFiretower43MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_firetower_43", MonsterId.InfroRocktor_Red, Properties("MHP", 104267, "MINPATK", 1842, "MAXPATK", 2165, "MINMATK", 1842, "MAXMATK", 2165, "DEF", 1317, "MDEF", 1317));
		AddPropertyOverrides("d_firetower_43", MonsterId.Arma, Properties("MHP", 105676, "MINPATK", 1860, "MAXPATK", 2188, "MINMATK", 1860, "MAXMATK", 2188, "DEF", 1363, "MDEF", 1363));
		AddPropertyOverrides("d_firetower_43", MonsterId.Flask_Mage, Properties("MHP", 107119, "MINPATK", 1878, "MAXPATK", 2211, "MINMATK", 1878, "MAXMATK", 2211, "DEF", 1410, "MDEF", 1410));
		AddPropertyOverrides("d_firetower_43", MonsterId.Pyran, Properties("MHP", 108595, "MINPATK", 1897, "MAXPATK", 2234, "MINMATK", 1897, "MAXMATK", 2234, "DEF", 1458, "MDEF", 1458));

		// Monster Spawners --------------------------------

		AddSpawner("d_firetower_43.Id1", MonsterId.InfroRocktor_Red, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_43.Id2", MonsterId.Arma, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_43.Id3", MonsterId.InfroRocktor_Red, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_43.Id4", MonsterId.Arma, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_43.Id5", MonsterId.Flask_Mage, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_43.Id6", MonsterId.Flask_Mage, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_43.Id7", MonsterId.Rootcrystal_01, 10, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_firetower_43.Id8", MonsterId.TerraNymph_Mage, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_firetower_43.Id9", MonsterId.Pyran, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// InfroRocktor_Red Spawn Points
		AddSpawnPoint( "d_firetower_43.Id1", "d_firetower_43", Spot(676.36, -842.49, 9999));

		// Arma Spawn Points
		AddSpawnPoint( "d_firetower_43.Id2", "d_firetower_43", Spot(-1556.8, 810.04, 9999));

		// InfroRocktor_Red Spawn Points
		AddSpawnPoint( "d_firetower_43.Id3", "d_firetower_43", Spot(-296.8105, -1248.625, 30));
		AddSpawnPoint( "d_firetower_43.Id3", "d_firetower_43", Spot(-200.1685, -504.59277, 30));
		AddSpawnPoint( "d_firetower_43.Id3", "d_firetower_43", Spot(-524.81, -282.31, 30));
		AddSpawnPoint( "d_firetower_43.Id3", "d_firetower_43", Spot(117.9614, -685.6401, 30));
		AddSpawnPoint( "d_firetower_43.Id3", "d_firetower_43", Spot(-486.7589, -718.70514, 30));
		AddSpawnPoint( "d_firetower_43.Id3", "d_firetower_43", Spot(-248.708, -1506.9589, 30));
		AddSpawnPoint( "d_firetower_43.Id3", "d_firetower_43", Spot(-328.40494, -1399.7872, 30));
		AddSpawnPoint( "d_firetower_43.Id3", "d_firetower_43", Spot(-388.24258, -836.2451, 30));
		AddSpawnPoint( "d_firetower_43.Id3", "d_firetower_43", Spot(-370.91028, -526.20715, 30));
		AddSpawnPoint( "d_firetower_43.Id3", "d_firetower_43", Spot(284.6138, -665.42426, 30));
		AddSpawnPoint( "d_firetower_43.Id3", "d_firetower_43", Spot(-575.9122, -82.52749, 30));
		AddSpawnPoint( "d_firetower_43.Id3", "d_firetower_43", Spot(-945.9964, -810.97296, 30));
		AddSpawnPoint( "d_firetower_43.Id3", "d_firetower_43", Spot(-286.3348, -656.8763, 30));
		AddSpawnPoint( "d_firetower_43.Id3", "d_firetower_43", Spot(-1283.4218, -920.57263, 30));
		AddSpawnPoint( "d_firetower_43.Id3", "d_firetower_43", Spot(-1250.3823, -662.849, 30));
		AddSpawnPoint( "d_firetower_43.Id3", "d_firetower_43", Spot(-1369.5116, -757.95667, 30));

		// Arma Spawn Points
		AddSpawnPoint( "d_firetower_43.Id4", "d_firetower_43", Spot(-1228.7, -820.35, 25));
		AddSpawnPoint( "d_firetower_43.Id4", "d_firetower_43", Spot(-1116.71, -706.79, 25));
		AddSpawnPoint( "d_firetower_43.Id4", "d_firetower_43", Spot(-695.5652, -756.50616, 25));
		AddSpawnPoint( "d_firetower_43.Id4", "d_firetower_43", Spot(-1115.605, -83.719406, 25));
		AddSpawnPoint( "d_firetower_43.Id4", "d_firetower_43", Spot(-797.61646, 1.8507881, 25));
		AddSpawnPoint( "d_firetower_43.Id4", "d_firetower_43", Spot(-420.89725, -624.9092, 25));
		AddSpawnPoint( "d_firetower_43.Id4", "d_firetower_43", Spot(-1250.0809, 445.8478, 25));
		AddSpawnPoint( "d_firetower_43.Id4", "d_firetower_43", Spot(-782.1664, 514.07104, 25));
		AddSpawnPoint( "d_firetower_43.Id4", "d_firetower_43", Spot(-299.3565, -1108.5522, 25));
		AddSpawnPoint( "d_firetower_43.Id4", "d_firetower_43", Spot(-409.30157, -1361.8363, 25));
		AddSpawnPoint( "d_firetower_43.Id4", "d_firetower_43", Spot(-35.49958, -1418.1425, 25));
		AddSpawnPoint( "d_firetower_43.Id4", "d_firetower_43", Spot(63.073597, -710.17255, 25));
		AddSpawnPoint( "d_firetower_43.Id4", "d_firetower_43", Spot(-76.77449, -1239.9128, 25));
		AddSpawnPoint( "d_firetower_43.Id4", "d_firetower_43", Spot(-422.59122, -827.5915, 25));
		AddSpawnPoint( "d_firetower_43.Id4", "d_firetower_43", Spot(-1032.8218, -851.7321, 25));
		AddSpawnPoint( "d_firetower_43.Id4", "d_firetower_43", Spot(-249.12991, -765.7179, 25));
		AddSpawnPoint( "d_firetower_43.Id4", "d_firetower_43", Spot(-1192.9149, 214.46321, 25));
		AddSpawnPoint( "d_firetower_43.Id4", "d_firetower_43", Spot(-679.8109, 285.65857, 25));

		// Flask_Mage Spawn Points
		AddSpawnPoint( "d_firetower_43.Id5", "d_firetower_43", Spot(1265.03, 74.42, 9999));
		AddSpawnPoint( "d_firetower_43.Id6", "d_firetower_43", Spot(1460.343, -761.3891, 25));
		AddSpawnPoint( "d_firetower_43.Id6", "d_firetower_43", Spot(1394.681, -904.0028, 25));
		AddSpawnPoint( "d_firetower_43.Id6", "d_firetower_43", Spot(1297.2887, -747.93506, 25));
		AddSpawnPoint( "d_firetower_43.Id6", "d_firetower_43", Spot(1453.2339, -634.3694, 25));
		AddSpawnPoint( "d_firetower_43.Id6", "d_firetower_43", Spot(1556.6426, -852.01526, 25));
		AddSpawnPoint( "d_firetower_43.Id6", "d_firetower_43", Spot(423.8532, -1338.4875, 25));
		AddSpawnPoint( "d_firetower_43.Id6", "d_firetower_43", Spot(700.08105, -1330.8036, 25));
		AddSpawnPoint( "d_firetower_43.Id6", "d_firetower_43", Spot(565.5566, -1332.915, 25));
		AddSpawnPoint( "d_firetower_43.Id6", "d_firetower_43", Spot(489.94202, -1590.1069, 25));
		AddSpawnPoint( "d_firetower_43.Id6", "d_firetower_43", Spot(644.974, -1575.9529, 25));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "d_firetower_43.Id7", "d_firetower_43", Spot(-2334.3765, 58.91771, 100));
		AddSpawnPoint( "d_firetower_43.Id7", "d_firetower_43", Spot(-1577.9647, 348.98038, 100));
		AddSpawnPoint( "d_firetower_43.Id7", "d_firetower_43", Spot(-909.0174, 474.11475, 100));
		AddSpawnPoint( "d_firetower_43.Id7", "d_firetower_43", Spot(-783.52716, 16.971859, 100));
		AddSpawnPoint( "d_firetower_43.Id7", "d_firetower_43", Spot(-368.2991, -611.09015, 100));
		AddSpawnPoint( "d_firetower_43.Id7", "d_firetower_43", Spot(-1100.6842, -773.42676, 100));
		AddSpawnPoint( "d_firetower_43.Id7", "d_firetower_43", Spot(-279.95816, -1474.5376, 100));
		AddSpawnPoint( "d_firetower_43.Id7", "d_firetower_43", Spot(577.347, -1275.0453, 100));
		AddSpawnPoint( "d_firetower_43.Id7", "d_firetower_43", Spot(748.3906, -128.82649, 100));
		AddSpawnPoint( "d_firetower_43.Id7", "d_firetower_43", Spot(1296.5668, -99.261856, 100));

		// TerraNymph_Mage Spawn Points
		AddSpawnPoint( "d_firetower_43.Id8", "d_firetower_43", Spot(-384.1441, -1292.6299, 30));
		AddSpawnPoint( "d_firetower_43.Id8", "d_firetower_43", Spot(-590.5052, -620.94946, 30));
		AddSpawnPoint( "d_firetower_43.Id8", "d_firetower_43", Spot(-82.519135, -626.1879, 30));
		AddSpawnPoint( "d_firetower_43.Id8", "d_firetower_43", Spot(-328.5019, -681.63666, 30));
		AddSpawnPoint( "d_firetower_43.Id8", "d_firetower_43", Spot(-560.2849, -231.55135, 30));
		AddSpawnPoint( "d_firetower_43.Id8", "d_firetower_43", Spot(-713.9762, 465.56598, 30));
		AddSpawnPoint( "d_firetower_43.Id8", "d_firetower_43", Spot(-1227.2715, 431.53757, 30));
		AddSpawnPoint( "d_firetower_43.Id8", "d_firetower_43", Spot(-1073.162, -1.9680538, 30));

		// Pyran Spawn Points
		AddSpawnPoint( "d_firetower_43.Id9", "d_firetower_43", Spot(-741.3048, -817.0755, 9999));

	}
}
