//--- Melia Script -----------------------------------------------------------
// Mage Tower 4F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_firetower_44'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFiretower44MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_firetower_44", MonsterId.New_Desmodus_Black, Properties("MHP", 110104, "MINPATK", 1917, "MAXPATK", 2258, "MINMATK", 1917, "MAXMATK", 2258, "DEF", 1508, "MDEF", 1508));
		AddPropertyOverrides("d_firetower_44", MonsterId.Wizards_Marmotte, Properties("MHP", 111644, "MINPATK", 1937, "MAXPATK", 2282, "MINMATK", 1937, "MAXMATK", 2282, "DEF", 1558, "MDEF", 1558));
		AddPropertyOverrides("d_firetower_44", MonsterId.Flask, Properties("MHP", 113215, "MINPATK", 1957, "MAXPATK", 2307, "MINMATK", 1957, "MAXMATK", 2307, "DEF", 1609, "MDEF", 1609));
		AddPropertyOverrides("d_firetower_44", MonsterId.Minivern, Properties("MHP", 114818, "MINPATK", 1977, "MAXPATK", 2332, "MINMATK", 1977, "MAXMATK", 2332, "DEF", 1661, "MDEF", 1661));
		AddPropertyOverrides("d_firetower_44", MonsterId.Minivern_Elite, Properties("MHP", 116450, "MINPATK", 1998, "MAXPATK", 2358, "MINMATK", 1998, "MAXMATK", 2358, "DEF", 1714, "MDEF", 1714));
		AddPropertyOverrides("d_firetower_44", MonsterId.Boss_Grinender, Properties("MHP", 588193, "MINPATK", 4605, "MAXPATK", 5436, "MINMATK", 4605, "MAXMATK", 5436, "DEF", 4032, "MDEF", 4032));

		// Monster Spawners ---------------------------------

		AddSpawner("d_firetower_44.Id1", MonsterId.Rootcrystal_01, 9, 11, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_firetower_44.Id2", MonsterId.New_Desmodus_Black, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_44.Id3", MonsterId.Wizards_Marmotte, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_44.Id4", MonsterId.Flask, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_44.Id5", MonsterId.Minivern, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_44.Id6", MonsterId.Minivern_Elite, 3, 3, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 1 Spawn Points
		AddSpawnPoint("d_firetower_44.Id1", "d_firetower_44", Rectangle(-2322, -83, 100));
		AddSpawnPoint("d_firetower_44.Id1", "d_firetower_44", Rectangle(-1583, 394, 100));
		AddSpawnPoint("d_firetower_44.Id1", "d_firetower_44", Rectangle(-956, 478, 100));
		AddSpawnPoint("d_firetower_44.Id1", "d_firetower_44", Rectangle(-1053, -47, 100));
		AddSpawnPoint("d_firetower_44.Id1", "d_firetower_44", Rectangle(-325, -1118, 100));
		AddSpawnPoint("d_firetower_44.Id1", "d_firetower_44", Rectangle(86, 11, 100));
		AddSpawnPoint("d_firetower_44.Id1", "d_firetower_44", Rectangle(1761, 416, 100));
		AddSpawnPoint("d_firetower_44.Id1", "d_firetower_44", Rectangle(602, -1589, 100));
		AddSpawnPoint("d_firetower_44.Id1", "d_firetower_44", Rectangle(923, -780, 100));
		AddSpawnPoint("d_firetower_44.Id1", "d_firetower_44", Rectangle(714, -302, 100));
		AddSpawnPoint("d_firetower_44.Id1", "d_firetower_44", Rectangle(1103, 455, 100));

		// 'New_Desmodus_Black' GenType 2 Spawn Points
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(-80, -1357, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(-740, 522, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(-639, 0, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(1290, 295, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(827, 549, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(1829, 653, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(1378, -861, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(513, -620, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(-555, -771, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(-320, -702, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(-333, -506, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(-1061, -106, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(-623, 91, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(-1134, -37, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(-1335, 411, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(-291, -1224, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(-50, -1260, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(-345, -1278, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(624, -911, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(454, -804, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(627, -521, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(852, -720, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(1600, -823, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(1332, -734, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(1051, 454, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(1203, 442, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(1502, 382, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(1653, 639, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(1859, 825, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(669, 26, 25));
		AddSpawnPoint("d_firetower_44.Id2", "d_firetower_44", Rectangle(1153, -786, 25));

		// 'Wizards_Marmotte' GenType 3 Spawn Points
		AddSpawnPoint("d_firetower_44.Id3", "d_firetower_44", Rectangle(661, -777, 20));
		AddSpawnPoint("d_firetower_44.Id3", "d_firetower_44", Rectangle(-562, -591, 20));
		AddSpawnPoint("d_firetower_44.Id3", "d_firetower_44", Rectangle(-752, 505, 20));
		AddSpawnPoint("d_firetower_44.Id3", "d_firetower_44", Rectangle(1723, 806, 20));
		AddSpawnPoint("d_firetower_44.Id3", "d_firetower_44", Rectangle(1280, 384, 20));
		AddSpawnPoint("d_firetower_44.Id3", "d_firetower_44", Rectangle(-84, -1206, 20));
		AddSpawnPoint("d_firetower_44.Id3", "d_firetower_44", Rectangle(1449, -783, 20));
		AddSpawnPoint("d_firetower_44.Id3", "d_firetower_44", Rectangle(762, 28, 20));
		AddSpawnPoint("d_firetower_44.Id3", "d_firetower_44", Rectangle(-527, -842, 20));
		AddSpawnPoint("d_firetower_44.Id3", "d_firetower_44", Rectangle(614, 90, 20));
		AddSpawnPoint("d_firetower_44.Id3", "d_firetower_44", Rectangle(513, -790, 20));
		AddSpawnPoint("d_firetower_44.Id3", "d_firetower_44", Rectangle(-27, -1453, 20));
		AddSpawnPoint("d_firetower_44.Id3", "d_firetower_44", Rectangle(-986, -50, 20));
		AddSpawnPoint("d_firetower_44.Id3", "d_firetower_44", Rectangle(222, 146, 20));
		AddSpawnPoint("d_firetower_44.Id3", "d_firetower_44", Rectangle(117, 87, 20));
		AddSpawnPoint("d_firetower_44.Id3", "d_firetower_44", Rectangle(-707, -793, 20));
		AddSpawnPoint("d_firetower_44.Id3", "d_firetower_44", Rectangle(666, -562, 20));
		AddSpawnPoint("d_firetower_44.Id3", "d_firetower_44", Rectangle(1045, 437, 20));
		AddSpawnPoint("d_firetower_44.Id3", "d_firetower_44", Rectangle(728, -870, 20));
		AddSpawnPoint("d_firetower_44.Id3", "d_firetower_44", Rectangle(-1235, 399, 20));

		// 'Flask' GenType 6 Spawn Points
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(-584, -619, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(-1119, 3, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(675, -247, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(-455, -805, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(-1007, -69, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(995, -774, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(842, 496, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(795, -6, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(-312, -661, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(-724, 506, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(-33, -1385, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(-245, -1233, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(707, -775, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(758, -659, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(1593, -723, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(1509, -908, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(135, -18, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(-26, 147, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(109, 240, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(-33, -1387, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(552, -817, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(600, -1301, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(504, -645, 20));
		AddSpawnPoint("d_firetower_44.Id4", "d_firetower_44", Rectangle(624, -689, 20));

		// 'Minivern' GenType 212 Spawn Points
		AddSpawnPoint("d_firetower_44.Id5", "d_firetower_44", Rectangle(-612, 18, 9999));

		// 'Minivern_Elite' GenType 228 Spawn Points
		AddSpawnPoint("d_firetower_44.Id6", "d_firetower_44", Rectangle(601, -732, 9999));
	}
}
