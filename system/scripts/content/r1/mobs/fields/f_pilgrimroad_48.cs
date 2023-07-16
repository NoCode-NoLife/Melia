//--- Melia Script -----------------------------------------------------------
// f_pilgrimroad_48
//
//--- Description -----------------------------------------------------------
// Sets up the f_pilgrimroad_48 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad48MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_pilgrimroad_48.Id1", MonsterId.Rootcrystal_05, 15, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_48.Id2", MonsterId.Sec_Lizardman, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_48.Id3", MonsterId.Sec_Lizardman, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_48.Id4", MonsterId.Sec_InfroBurk, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_48.Id5", MonsterId.Sec_Operor, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_48.Id6", MonsterId.Sec_Operor, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Spot(-1144.2448, -1733.941, 150));
		AddSpawnPoint( "f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Spot(-663.62305, -1411.2712, 150));
		AddSpawnPoint( "f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Spot(-1031.4519, -601.70795, 150));
		AddSpawnPoint( "f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Spot(-1061.7578, 77.43785, 150));
		AddSpawnPoint( "f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Spot(-74.2526, -73.741486, 150));
		AddSpawnPoint( "f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Spot(-78.0661, -952.7837, 150));
		AddSpawnPoint( "f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Spot(491.6069, -1341.308, 150));
		AddSpawnPoint( "f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Spot(200.21112, 396.48172, 150));
		AddSpawnPoint( "f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Spot(1094.9124, 103.97351, 150));
		AddSpawnPoint( "f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Spot(1707.8159, 286.13458, 150));
		AddSpawnPoint( "f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Spot(1141.2457, 1139.0928, 150));
		AddSpawnPoint( "f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Spot(342.36954, 1141.765, 150));
		AddSpawnPoint( "f_pilgrimroad_48.Id1", "f_pilgrimroad_48", Spot(-376.5676, 1302.4535, 150));

		// Sec_Lizardman Spawn Points
		AddSpawnPoint( "f_pilgrimroad_48.Id2", "f_pilgrimroad_48", Spot(110.88483, -1274.9713, 200));
		AddSpawnPoint( "f_pilgrimroad_48.Id2", "f_pilgrimroad_48", Spot(1034.5459, 1040.7234, 200));
		AddSpawnPoint( "f_pilgrimroad_48.Id2", "f_pilgrimroad_48", Spot(312.4499, 1044.6622, 200));
		AddSpawnPoint( "f_pilgrimroad_48.Id2", "f_pilgrimroad_48", Spot(447.87494, -1027.5662, 200));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-1064.9747, -1196.9468, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-1047.0796, -1415.1681, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-728.2459, -1461.8585, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-837.91876, -1620.617, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-997.13635, -1722.4812, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-1119.7991, -1584.1976, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-1004.8463, -1572.5929, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-890.0158, -1364.2068, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-1110.4979, -957.7657, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-948.3428, -21.682318, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-810.7551, 129.00858, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-896.43964, 244.90471, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-660.7233, 427.8282, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-713.2485, 326.98486, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-813.2202, 422.36755, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-989.54675, 497.3472, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-681.31824, 695.79, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-716.3368, 538.5299, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-1074.6682, -1296.6493, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-790.14624, -1479.726, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-1044.85, -429.19196, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-1057.7487, -719.9316, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-1268.501, -1634.4441, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-1276.816, -1799.0265, 30));
		AddSpawnPoint( "f_pilgrimroad_48.Id3", "f_pilgrimroad_48", Spot(-1190.1528, -1654.562, 30));

		// Sec_InfroBurk Spawn Points
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1454.2924, -30.316, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1580.1744, -60.79458, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1506.5524, 78.503586, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1647.0753, 54.275986, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1551.0742, 187.60466, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1602.8801, 386.71484, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1657.5839, 470.38962, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1445.1567, 474.76657, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1509.4004, 603.6205, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1803.0052, 156.75127, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1452.1902, 261.75873, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1269.2231, 28.788645, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1244.9131, 178.28185, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1077.5574, 178.93286, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1033.4127, 11.223513, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(930.23145, -62.193974, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(884.24414, 75.09412, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1442.3457, -117.69217, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(835.0647, 1000.4085, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(925.0902, 1147.7355, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1009.0162, 1025.5504, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1157.6102, 945.00464, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1129.5304, 808.7879, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1242.8503, 780.35236, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1256.3175, 1042.7501, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1127.3073, 1156.026, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1676.0386, 222.54822, 25));
		AddSpawnPoint( "f_pilgrimroad_48.Id4", "f_pilgrimroad_48", Spot(1759.3773, 296.22116, 25));

		// Sec_Operor Spawn Points
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(45.57094, 559.1171, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(186.33731, 494.5317, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(118.24187, 599.6589, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(245.91304, 679.89996, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(288.62653, 570.93744, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(431.6938, 533.6655, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(494.88992, 364.36633, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(486.47498, 248.34254, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(519.0302, 159.1358, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(424.35242, 281.6182, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(470.61252, 645.14026, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(454.25555, 803.6054, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(231.3844, 757.0397, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(-9.032734, 697.5576, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(225.17635, -1238.8844, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(102.8041, -1340.2507, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(408.11935, -1346.3904, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(525.7113, -1093.2224, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(375.5073, -979.92944, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(-57.09842, -1018.6332, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(189.6932, -973.5131, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(463.18994, -1244.9814, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(591.23444, -927.9112, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(404.7926, -825.82465, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id5", "f_pilgrimroad_48", Spot(8.496807, -865.0793, 20));
		AddSpawnPoint( "f_pilgrimroad_48.Id6", "f_pilgrimroad_48", Spot(1075.122, 1019.3548, 200));
		AddSpawnPoint( "f_pilgrimroad_48.Id6", "f_pilgrimroad_48", Spot(-120.18462, 1024.1465, 200));

	}
}
