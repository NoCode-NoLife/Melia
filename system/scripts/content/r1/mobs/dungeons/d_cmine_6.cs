//--- Melia Script -----------------------------------------------------------
// d_cmine_6
//
//--- Description -----------------------------------------------------------
// Sets up the d_cmine_6 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCmine6MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_cmine_6", MonsterId.Quartz_Weaver, Properties("MHP", 11142, "MINPATK", 590, "MAXPATK", 637, "MINMATK", 590, "MAXMATK", 637, "DEF", 59, "MDEF", 59));
		AddPropertyOverrides("d_cmine_6", MonsterId.GoblinWarrior, Properties("MHP", 12248, "MINPATK", 640, "MAXPATK", 692, "MINMATK", 640, "MAXMATK", 692, "DEF", 64, "MDEF", 64));
		AddPropertyOverrides("d_cmine_6", MonsterId.Bubbe_Mage_Priest, Properties("MHP", 11690, "MINPATK", 615, "MAXPATK", 664, "MINMATK", 615, "MAXMATK", 664, "DEF", 62, "MDEF", 62));

		// Monster Spawners --------------------------------

		AddSpawner("d_cmine_6.Id1", MonsterId.Rootcrystal_01, 13, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_cmine_6.Id2", MonsterId.Quartz_Weaver, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_6.Id3", MonsterId.GoblinWarrior, 3, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_cmine_6.Id4", MonsterId.Bubbe_Mage_Priest, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_6.Id5", MonsterId.Quartz_Weaver, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_cmine_6.Id6", MonsterId.Bubbe_Mage_Priest, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-2068, -1572, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-1918, -1959, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-1650, -1720, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-1646, -1899, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-1149, -1806, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-1122, -1612, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-1224, -1216, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-476, -1559, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-446, -1189, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-789, -916, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-530, -834, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-419, -752, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-422, -605, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-687, -125, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-715, 12, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-609, 140, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-949.68506, -94.36801, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-838, 238, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-1079, 176, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(49, -1133, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(94, -981, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-347, -1136, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-50, -1305, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(-167, -137, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(54, -17, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(1763, 2101, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(2042, 2127, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(1705, 1478, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(1725, 1357, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(1804, 1634, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(1662, 1612, 10));
		AddSpawnPoint( "d_cmine_6.Id1", "d_cmine_6", Spot(2012, 1711, 10));

		// Quartz_Weaver Spawn Points
		AddSpawnPoint( "d_cmine_6.Id2", "d_cmine_6", Spot(-1067.9858, -1262.6368, 2000));

		// GoblinWarrior Spawn Points
		AddSpawnPoint( "d_cmine_6.Id3", "d_cmine_6", Spot(-819.628, -1192.3961, 2000));

		// Bubbe_Mage_Priest Spawn Points
		AddSpawnPoint( "d_cmine_6.Id4", "d_cmine_6", Spot(-851.20337, -1298.5792, 2000));

		// Quartz_Weaver Spawn Points
		AddSpawnPoint( "d_cmine_6.Id5", "d_cmine_6", Spot(-1158.4915, -1571.4525, 40));
		AddSpawnPoint( "d_cmine_6.Id5", "d_cmine_6", Spot(-1155.641, -1281.355, 40));
		AddSpawnPoint( "d_cmine_6.Id5", "d_cmine_6", Spot(-794.7901, -1203.5465, 40));
		AddSpawnPoint( "d_cmine_6.Id5", "d_cmine_6", Spot(-454.9373, -1489.2084, 40));
		AddSpawnPoint( "d_cmine_6.Id5", "d_cmine_6", Spot(53.28093, -1008.2537, 40));
		AddSpawnPoint( "d_cmine_6.Id5", "d_cmine_6", Spot(-663.6857, -859.00183, 40));
		AddSpawnPoint( "d_cmine_6.Id5", "d_cmine_6", Spot(16.954464, -1267.2732, 40));
		AddSpawnPoint( "d_cmine_6.Id5", "d_cmine_6", Spot(-869.7694, -194.795, 40));
		AddSpawnPoint( "d_cmine_6.Id5", "d_cmine_6", Spot(-630.5578, -247.6927, 40));
		AddSpawnPoint( "d_cmine_6.Id5", "d_cmine_6", Spot(-632.376, 85.749115, 40));
		AddSpawnPoint( "d_cmine_6.Id5", "d_cmine_6", Spot(-187.01031, -83.010796, 40));
		AddSpawnPoint( "d_cmine_6.Id5", "d_cmine_6", Spot(-375.92035, -516.4829, 40));

		// Bubbe_Mage_Priest Spawn Points
		AddSpawnPoint( "d_cmine_6.Id6", "d_cmine_6", Spot(-925.3166, -1356.7808, 50));
		AddSpawnPoint( "d_cmine_6.Id6", "d_cmine_6", Spot(-529.6133, -1503.4279, 50));
		AddSpawnPoint( "d_cmine_6.Id6", "d_cmine_6", Spot(-458.68396, -1625.8433, 50));
		AddSpawnPoint( "d_cmine_6.Id6", "d_cmine_6", Spot(-395.51712, -1230.865, 50));
		AddSpawnPoint( "d_cmine_6.Id6", "d_cmine_6", Spot(-234.52835, -1080.4702, 50));
		AddSpawnPoint( "d_cmine_6.Id6", "d_cmine_6", Spot(-58.138832, -1270.1907, 50));
		AddSpawnPoint( "d_cmine_6.Id6", "d_cmine_6", Spot(30.109444, -1130.2517, 50));
		AddSpawnPoint( "d_cmine_6.Id6", "d_cmine_6", Spot(148.13945, -1247.0809, 50));
		AddSpawnPoint( "d_cmine_6.Id6", "d_cmine_6", Spot(-599.63416, -857.7218, 50));
		AddSpawnPoint( "d_cmine_6.Id6", "d_cmine_6", Spot(-394.3488, -636.747, 50));
		AddSpawnPoint( "d_cmine_6.Id6", "d_cmine_6", Spot(-257.29843, -322.31033, 50));
		AddSpawnPoint( "d_cmine_6.Id6", "d_cmine_6", Spot(-119.86919, -116.63756, 50));
		AddSpawnPoint( "d_cmine_6.Id6", "d_cmine_6", Spot(-782.06335, -216.13513, 50));
		AddSpawnPoint( "d_cmine_6.Id6", "d_cmine_6", Spot(-763.97144, -24.787132, 50));
		AddSpawnPoint( "d_cmine_6.Id6", "d_cmine_6", Spot(-632.6656, -79.23552, 50));

	}
}
