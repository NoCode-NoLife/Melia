//--- Melia Script -----------------------------------------------------------
// Forest of Prayer Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_pilgrimroad_51'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad51MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_pilgrimroad_51", MonsterId.Prisonfighter, Properties("MHP", 134471, "MINPATK", 2230, "MAXPATK", 2643, "MINMATK", 2230, "MAXMATK", 2643, "DEF", 2538, "MDEF", 2538));
		AddPropertyOverrides("f_pilgrimroad_51", MonsterId.Kowak, Properties("MHP", 135786, "MINPATK", 2247, "MAXPATK", 2664, "MINMATK", 2247, "MAXMATK", 2664, "DEF", 2614, "MDEF", 2614));
		AddPropertyOverrides("f_pilgrimroad_51", MonsterId.Stoulet_Bow, Properties("MHP", 137156, "MINPATK", 2265, "MAXPATK", 2685, "MINMATK", 2265, "MAXMATK", 2685, "DEF", 2693, "MDEF", 2693));

		// Monster Spawners ---------------------------------

		AddSpawner("f_pilgrimroad_51.Id1", MonsterId.Prisonfighter, 15, 20, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id2", MonsterId.Kowak, 19, 25, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id3", MonsterId.Prisonfighter, 9, 12, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id4", MonsterId.Kowak, 8, 10, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id5", MonsterId.Rootcrystal_01, 11, 14, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id6", MonsterId.Stoulet_Bow, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id7", MonsterId.Stoulet_Bow, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id8", MonsterId.Stoulet_Bow, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id9", MonsterId.Kowak, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_51.Id10", MonsterId.Prisonfighter, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Prisonfighter' GenType 5 Spawn Points
		AddSpawnPoint("f_pilgrimroad_51.Id1", "f_pilgrimroad_51", Rectangle(-139, 334, 9999));

		// 'Kowak' GenType 6 Spawn Points
		AddSpawnPoint("f_pilgrimroad_51.Id2", "f_pilgrimroad_51", Rectangle(-765, 182, 9999));

		// 'Prisonfighter' GenType 8 Spawn Points
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-96, 210, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-787, -309, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-1227, 134, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-661, 340, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-937, 116, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-653, 60, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-350, -429, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-104, 513, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(38, -93, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-284, 265, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-170, -196, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-618, -551, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-473, -230, 35));
		AddSpawnPoint("f_pilgrimroad_51.Id3", "f_pilgrimroad_51", Rectangle(-268, 529, 35));

		// 'Kowak' GenType 9 Spawn Points
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-1159, -1838, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-1349, -1516, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-1309, -1931, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-985, -1798, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-911, -2007, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-790, -1842, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-1157, -1687, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-1371, -1256, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-1424, -1706, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-1271, -1032, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id4", "f_pilgrimroad_51", Rectangle(-1497, -1407, 30));

		// 'Rootcrystal_01' GenType 24 Spawn Points
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(-1444, -1440, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(-116, -1352, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(-803, -709, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(-57, -211, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(-1223, 128, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(-1373, 1131, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(-70, 566, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(1035, 836, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(1180, -10, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(1673, -1067, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(1957, -1649, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(1557, 1210, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(1274, 1994, 30));
		AddSpawnPoint("f_pilgrimroad_51.Id5", "f_pilgrimroad_51", Rectangle(742, 1896, 30));

		// 'Stoulet_Bow' GenType 42 Spawn Points
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-1087, -942, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-733, -860, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-1617, 358, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-1340, 309, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-583, -655, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-534, -47, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-931, -105, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(54, -166, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(58, 309, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-11, -1517, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-1123, -1693, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-801, -1730, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-369, -1567, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(4, -1190, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-328, 478, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-259, 5, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-217, -499, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-747, 414, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id6", "f_pilgrimroad_51", Rectangle(-725, -1337, 25));

		// 'Stoulet_Bow' GenType 50 Spawn Points
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1679, -1135, 20));
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1688, -890, 20));
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1593, -418, 20));
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1636, -38, 20));
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1797, -231, 20));
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1306, -189, 20));
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1318, 232, 20));
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1397, 657, 20));
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1004, 919, 20));
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1205, 652, 20));
		AddSpawnPoint("f_pilgrimroad_51.Id7", "f_pilgrimroad_51", Rectangle(1138, -64, 20));

		// 'Stoulet_Bow' GenType 51 Spawn Points
		AddSpawnPoint("f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Rectangle(1742, -1590, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Rectangle(1679, -1745, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Rectangle(1598, -1637, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Rectangle(1861, -1606, 25));
		AddSpawnPoint("f_pilgrimroad_51.Id8", "f_pilgrimroad_51", Rectangle(1894, -1748, 25));

		// 'Kowak' GenType 58 Spawn Points
		AddSpawnPoint("f_pilgrimroad_51.Id9", "f_pilgrimroad_51", Rectangle(-123, -1225, 40));
		AddSpawnPoint("f_pilgrimroad_51.Id9", "f_pilgrimroad_51", Rectangle(-187, -1292, 40));
		AddSpawnPoint("f_pilgrimroad_51.Id9", "f_pilgrimroad_51", Rectangle(-173, -1405, 40));
		AddSpawnPoint("f_pilgrimroad_51.Id9", "f_pilgrimroad_51", Rectangle(-44, -1278, 40));
		AddSpawnPoint("f_pilgrimroad_51.Id9", "f_pilgrimroad_51", Rectangle(-24, -1367, 40));
		AddSpawnPoint("f_pilgrimroad_51.Id9", "f_pilgrimroad_51", Rectangle(-85, -1420, 40));

		// 'Prisonfighter' GenType 59 Spawn Points
		AddSpawnPoint("f_pilgrimroad_51.Id10", "f_pilgrimroad_51", Rectangle(-179, -1232, 40));
		AddSpawnPoint("f_pilgrimroad_51.Id10", "f_pilgrimroad_51", Rectangle(-202, -1349, 40));
		AddSpawnPoint("f_pilgrimroad_51.Id10", "f_pilgrimroad_51", Rectangle(-111, -1297, 40));
		AddSpawnPoint("f_pilgrimroad_51.Id10", "f_pilgrimroad_51", Rectangle(-78, -1342, 40));
		AddSpawnPoint("f_pilgrimroad_51.Id10", "f_pilgrimroad_51", Rectangle(-126, -1397, 40));
		AddSpawnPoint("f_pilgrimroad_51.Id10", "f_pilgrimroad_51", Rectangle(-143, -1461, 40));
	}
}
