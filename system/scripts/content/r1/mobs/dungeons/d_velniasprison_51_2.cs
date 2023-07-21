//--- Melia Script -----------------------------------------------------------
// Demon Prison District 2 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_velniasprison_51_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DVelniasprison512MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_velniasprison_51_2", MonsterId.Defender_Spider, Properties("MHP", 189776, "MINPATK", 2942, "MAXPATK", 3517, "MINMATK", 2942, "MAXMATK", 3517, "DEF", 6401, "MDEF", 6401));
		AddPropertyOverrides("d_velniasprison_51_2", MonsterId.Nuka, Properties("MHP", 191163, "MINPATK", 2959, "MAXPATK", 3539, "MINMATK", 2959, "MAXMATK", 3539, "DEF", 6528, "MDEF", 6528));
		AddPropertyOverrides("d_velniasprison_51_2", MonsterId.Harugal, Properties("MHP", 192581, "MINPATK", 2978, "MAXPATK", 3561, "MINMATK", 2978, "MAXMATK", 3561, "DEF", 6657, "MDEF", 6657));
		AddPropertyOverrides("d_velniasprison_51_2", MonsterId.Elet, Properties("MHP", 194029, "MINPATK", 2996, "MAXPATK", 3584, "MINMATK", 2996, "MAXMATK", 3584, "DEF", 6789, "MDEF", 6789));
		AddPropertyOverrides("d_velniasprison_51_2", MonsterId.Boss_Nuaelle, Properties("MHP", 997079, "MINPATK", 7237, "MAXPATK", 8657, "MINMATK", 7237, "MAXMATK", 8657, "DEF", 16617, "MDEF", 16617));

		// Monster Spawners ---------------------------------

		AddSpawner("d_velniasprison_51_2.Id1", MonsterId.Defender_Spider, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_2.Id2", MonsterId.Nuka, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_2.Id3", MonsterId.Defender_Spider, min: 30, max: 40, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_2.Id4", MonsterId.Harugal, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_2.Id5", MonsterId.Rootcrystal_05, min: 14, max: 18, respawn: TimeSpan.FromMilliseconds(30000), tendency: TendencyType.Peaceful);
		AddSpawner("d_velniasprison_51_2.Id6", MonsterId.Nuka, min: 30, max: 40, tendency: TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_2.Id7", MonsterId.Elet, min: 23, max: 30, tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Defender_Spider' GenType 12 Spawn Points
		AddSpawnPoint("d_velniasprison_51_2.Id1", "d_velniasprison_51_2", Rectangle(-1517, -147, 150));
		AddSpawnPoint("d_velniasprison_51_2.Id1", "d_velniasprison_51_2", Rectangle(-796, 1020, 150));

		// 'Nuka' GenType 13 Spawn Points
		AddSpawnPoint("d_velniasprison_51_2.Id2", "d_velniasprison_51_2", Rectangle(-1491, 908, 200));
		AddSpawnPoint("d_velniasprison_51_2.Id2", "d_velniasprison_51_2", Rectangle(-776, -235, 200));

		// 'Defender_Spider' GenType 17 Spawn Points
		AddSpawnPoint("d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Rectangle(-1555, 984, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Rectangle(-776, 964, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Rectangle(-596, 985, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Rectangle(-933, 1132, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Rectangle(-754, 421, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Rectangle(-1371, 380, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Rectangle(1683, -1444, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Rectangle(1686, -1703, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Rectangle(1337, -1526, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Rectangle(896, -1582, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id3", "d_velniasprison_51_2", Rectangle(743, -1731, 30));

		// 'Harugal' GenType 18 Spawn Points
		AddSpawnPoint("d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Rectangle(-1515, 1210, 100));
		AddSpawnPoint("d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Rectangle(-1565, -148, 100));
		AddSpawnPoint("d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Rectangle(-740, -282, 100));
		AddSpawnPoint("d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Rectangle(-774, 923, 100));
		AddSpawnPoint("d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Rectangle(-726, 407, 100));
		AddSpawnPoint("d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Rectangle(-1551, 406, 100));
		AddSpawnPoint("d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Rectangle(534, -1475, 100));
		AddSpawnPoint("d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Rectangle(733, -1729, 100));
		AddSpawnPoint("d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Rectangle(1498, -1439, 100));
		AddSpawnPoint("d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Rectangle(1593, -1694, 100));
		AddSpawnPoint("d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Rectangle(-1471, 1088, 100));
		AddSpawnPoint("d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Rectangle(-1631, 1044, 100));
		AddSpawnPoint("d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Rectangle(-1543, 866, 100));
		AddSpawnPoint("d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Rectangle(-1429, 817, 100));
		AddSpawnPoint("d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Rectangle(-1704, -60, 100));
		AddSpawnPoint("d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Rectangle(-1647, -280, 100));
		AddSpawnPoint("d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Rectangle(-1450, -163, 100));
		AddSpawnPoint("d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Rectangle(-1461, 18, 100));
		AddSpawnPoint("d_velniasprison_51_2.Id4", "d_velniasprison_51_2", Rectangle(-1532, 724, 100));

		// 'Rootcrystal_05' GenType 19 Spawn Points
		AddSpawnPoint("d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Rectangle(-1498, 929, 200));
		AddSpawnPoint("d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Rectangle(-1644, -75, 200));
		AddSpawnPoint("d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Rectangle(-752, 428, 200));
		AddSpawnPoint("d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Rectangle(-1540, 425, 200));
		AddSpawnPoint("d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Rectangle(-745, 911, 200));
		AddSpawnPoint("d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Rectangle(-708, -224, 200));
		AddSpawnPoint("d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Rectangle(1288, 402, 200));
		AddSpawnPoint("d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Rectangle(1195, 1618, 200));
		AddSpawnPoint("d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Rectangle(1656, -1352, 200));
		AddSpawnPoint("d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Rectangle(1532, -1650, 200));
		AddSpawnPoint("d_velniasprison_51_2.Id5", "d_velniasprison_51_2", Rectangle(756, -1615, 200));

		// 'Nuka' GenType 20 Spawn Points
		AddSpawnPoint("d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Rectangle(-421, 397, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Rectangle(-805, -387, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Rectangle(-735, -267, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Rectangle(-593, -284, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Rectangle(-951, -260, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Rectangle(-1546, 1017, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Rectangle(-1512, 21, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Rectangle(-952, 1029, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Rectangle(-658, 1057, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Rectangle(-688, -144, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Rectangle(-1709, -82, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Rectangle(-1609, -328, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Rectangle(-746, 864, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Rectangle(-1574, 854, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Rectangle(-776, 418, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Rectangle(-1591, 429, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Rectangle(-1078, 433, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id6", "d_velniasprison_51_2", Rectangle(-819, -130, 30));

		// 'Elet' GenType 21 Spawn Points
		AddSpawnPoint("d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Rectangle(-1519, -141, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Rectangle(-652, -159, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Rectangle(-711, -445, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Rectangle(-1410, -5, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Rectangle(-1459, -324, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Rectangle(-1650, -201, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Rectangle(-1629, 6, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Rectangle(-1539, 594, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Rectangle(629, -1728, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Rectangle(671, -1483, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Rectangle(1068, -1536, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Rectangle(1568, -1796, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Rectangle(1655, -1352, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Rectangle(-887, 910, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Rectangle(-662, 969, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Rectangle(-908, 1085, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Rectangle(-782, 1074, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Rectangle(-849, -104, 30));
		AddSpawnPoint("d_velniasprison_51_2.Id7", "d_velniasprison_51_2", Rectangle(-964, -282, 30));
	}
}
