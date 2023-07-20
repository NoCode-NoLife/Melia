//--- Melia Script -----------------------------------------------------------
// Crystal Mine 3F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_cmine_6'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCmine6MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_cmine_6", MonsterId.Quartz_Weaver, Properties("MHP", 11142, "MINPATK", 590, "MAXPATK", 637, "MINMATK", 590, "MAXMATK", 637, "DEF", 59, "MDEF", 59));
		AddPropertyOverrides("d_cmine_6", MonsterId.Bubbe_Mage_Priest, Properties("MHP", 11690, "MINPATK", 615, "MAXPATK", 664, "MINMATK", 615, "MAXMATK", 664, "DEF", 62, "MDEF", 62));
		AddPropertyOverrides("d_cmine_6", MonsterId.GoblinWarrior, Properties("MHP", 12248, "MINPATK", 640, "MAXPATK", 692, "MINMATK", 640, "MAXMATK", 692, "DEF", 64, "MDEF", 64));
		AddPropertyOverrides("d_cmine_6", MonsterId.Boss_Mirtis, Properties("MHP", 96135, "MINPATK", 1532, "MAXPATK", 1656, "MINMATK", 1532, "MAXMATK", 1656, "DEF", 154, "MDEF", 154));

		// Monster Spawners ---------------------------------

		AddSpawner("d_cmine_6.Id1", MonsterId.Rootcrystal_01, 10, 13, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_cmine_6.Id2", MonsterId.Quartz_Weaver, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_6.Id3", MonsterId.Bubbe_Mage_Priest, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cmine_6.Id4", MonsterId.GoblinWarrior, 3, 3, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_cmine_6.Id5", MonsterId.Quartz_Weaver, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_cmine_6.Id6", MonsterId.Bubbe_Mage_Priest, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 500 Spawn Points
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-2068, -1572, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-1918, -1959, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-1650, -1720, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-1646, -1899, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-1149, -1806, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-1122, -1612, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-1224, -1216, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-476, -1559, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-446, -1189, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-789, -916, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-530, -834, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-419, -752, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-422, -605, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-687, -125, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-715, 12, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-609, 140, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-949, -94, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-838, 238, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-1079, 176, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(49, -1133, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(94, -981, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-347, -1136, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-50, -1305, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(-167, -137, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(54, -17, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(1763, 2101, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(2042, 2127, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(1705, 1478, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(1725, 1357, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(1804, 1634, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(1662, 1612, 10));
		AddSpawnPoint("d_cmine_6.Id1", "d_cmine_6", Rectangle(2012, 1711, 10));

		// 'Quartz_Weaver' GenType 502 Spawn Points
		AddSpawnPoint("d_cmine_6.Id2", "d_cmine_6", Rectangle(-1067, -1262, 2000));

		// 'Bubbe_Mage_Priest' GenType 510 Spawn Points
		AddSpawnPoint("d_cmine_6.Id3", "d_cmine_6", Rectangle(-851, -1298, 2000));

		// 'GoblinWarrior' GenType 521 Spawn Points
		AddSpawnPoint("d_cmine_6.Id4", "d_cmine_6", Rectangle(-819, -1192, 2000));

		// 'Quartz_Weaver' GenType 537 Spawn Points
		AddSpawnPoint("d_cmine_6.Id5", "d_cmine_6", Rectangle(-1158, -1571, 40));
		AddSpawnPoint("d_cmine_6.Id5", "d_cmine_6", Rectangle(-1155, -1281, 40));
		AddSpawnPoint("d_cmine_6.Id5", "d_cmine_6", Rectangle(-794, -1203, 40));
		AddSpawnPoint("d_cmine_6.Id5", "d_cmine_6", Rectangle(-454, -1489, 40));
		AddSpawnPoint("d_cmine_6.Id5", "d_cmine_6", Rectangle(53, -1008, 40));
		AddSpawnPoint("d_cmine_6.Id5", "d_cmine_6", Rectangle(-663, -859, 40));
		AddSpawnPoint("d_cmine_6.Id5", "d_cmine_6", Rectangle(16, -1267, 40));
		AddSpawnPoint("d_cmine_6.Id5", "d_cmine_6", Rectangle(-869, -194, 40));
		AddSpawnPoint("d_cmine_6.Id5", "d_cmine_6", Rectangle(-630, -247, 40));
		AddSpawnPoint("d_cmine_6.Id5", "d_cmine_6", Rectangle(-632, 85, 40));
		AddSpawnPoint("d_cmine_6.Id5", "d_cmine_6", Rectangle(-187, -83, 40));
		AddSpawnPoint("d_cmine_6.Id5", "d_cmine_6", Rectangle(-375, -516, 40));

		// 'Bubbe_Mage_Priest' GenType 538 Spawn Points
		AddSpawnPoint("d_cmine_6.Id6", "d_cmine_6", Rectangle(-925, -1356, 50));
		AddSpawnPoint("d_cmine_6.Id6", "d_cmine_6", Rectangle(-529, -1503, 50));
		AddSpawnPoint("d_cmine_6.Id6", "d_cmine_6", Rectangle(-458, -1625, 50));
		AddSpawnPoint("d_cmine_6.Id6", "d_cmine_6", Rectangle(-395, -1230, 50));
		AddSpawnPoint("d_cmine_6.Id6", "d_cmine_6", Rectangle(-234, -1080, 50));
		AddSpawnPoint("d_cmine_6.Id6", "d_cmine_6", Rectangle(-58, -1270, 50));
		AddSpawnPoint("d_cmine_6.Id6", "d_cmine_6", Rectangle(30, -1130, 50));
		AddSpawnPoint("d_cmine_6.Id6", "d_cmine_6", Rectangle(148, -1247, 50));
		AddSpawnPoint("d_cmine_6.Id6", "d_cmine_6", Rectangle(-599, -857, 50));
		AddSpawnPoint("d_cmine_6.Id6", "d_cmine_6", Rectangle(-394, -636, 50));
		AddSpawnPoint("d_cmine_6.Id6", "d_cmine_6", Rectangle(-257, -322, 50));
		AddSpawnPoint("d_cmine_6.Id6", "d_cmine_6", Rectangle(-119, -116, 50));
		AddSpawnPoint("d_cmine_6.Id6", "d_cmine_6", Rectangle(-782, -216, 50));
		AddSpawnPoint("d_cmine_6.Id6", "d_cmine_6", Rectangle(-763, -24, 50));
		AddSpawnPoint("d_cmine_6.Id6", "d_cmine_6", Rectangle(-632, -79, 50));
	}
}
