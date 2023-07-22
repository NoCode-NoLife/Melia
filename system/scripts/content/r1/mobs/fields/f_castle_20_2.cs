//--- Melia Script -----------------------------------------------------------
// Inner Wall District 9 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_castle_20_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle202MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_castle_20_2", MonsterId.Aklascenser, Properties("MHP", 595945, "MINPATK", 8164, "MAXPATK", 9936, "MINMATK", 8164, "MAXMATK", 9936, "DEF", 125381, "MDEF", 125381));
		AddPropertyOverrides("f_castle_20_2", MonsterId.Aklasbishop, Properties("MHP", 596169, "MINPATK", 8167, "MAXPATK", 9940, "MINMATK", 8167, "MAXMATK", 9940, "DEF", 125515, "MDEF", 125515));
		AddPropertyOverrides("f_castle_20_2", MonsterId.Aklashump, Properties("MHP", 596578, "MINPATK", 8172, "MAXPATK", 9946, "MINMATK", 8172, "MAXMATK", 9946, "DEF", 125760, "MDEF", 125760));
		AddPropertyOverrides("f_castle_20_2", MonsterId.Siaria, Properties("MHP", 597107, "MINPATK", 8179, "MAXPATK", 9954, "MINMATK", 8179, "MAXMATK", 9954, "DEF", 126077, "MDEF", 126077));

		// Monster Spawners ---------------------------------

		AddSpawner("f_castle_20_2.Id1", MonsterId.Rootcrystal_01, min: 11, max: 14, respawn: TimeSpan.FromMilliseconds(60000), tendency: TendencyType.Peaceful);
		AddSpawner("f_castle_20_2.Id2", MonsterId.Aklascenser, min: 27, max: 35, tendency: TendencyType.Aggressive);
		AddSpawner("f_castle_20_2.Id3", MonsterId.Aklasbishop, min: 19, max: 25, tendency: TendencyType.Aggressive);
		AddSpawner("f_castle_20_2.Id4", MonsterId.Aklashump, min: 27, max: 35, tendency: TendencyType.Aggressive);
		AddSpawner("f_castle_20_2.Id5", MonsterId.Siaria, amount: 1, respawn: TimeSpan.FromMilliseconds(1800000), tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 35 Spawn Points
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(-1526, 218, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(-1261, -68, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(-844, -118, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(-818, -564, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(-69, -1108, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(539, -573, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(-467, -93, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(-773, 883, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(-463, 284, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(-109, 939, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(1000, 954, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(1140, 369, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(1419, -267, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(1017, -486, 100));

		// 'Aklascenser' GenType 46 Spawn Points
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-516, -560, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-711, -574, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-874, -339, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-805, -177, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-1272, -156, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-1457, -78, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-1339, 102, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-1624, 0, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-1411, 245, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-1220, 160, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-1057, 50, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-726, 350, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-559, -177, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-379, -220, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-390, 32, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-419, 276, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-7, 316, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(9, 602, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-448, 495, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-594, 546, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-481, 919, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-809, 587, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-114, 1001, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(183, 264, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(289, -171, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(203, -349, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(35, -292, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(111, -159, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(271, -63, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-102, -617, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(143, -516, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(378, -817, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(534, -759, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(544, -520, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(382, -672, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-171, -562, 40));

		// 'Aklasbishop' GenType 47 Spawn Points
		AddSpawnPoint("f_castle_20_2.Id3", "f_castle_20_2", Rectangle(201, -223, 9999));

		// 'Aklashump' GenType 48 Spawn Points
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(400, -583, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(969, -242, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1308, -368, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1533, -407, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1546, -143, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1428, -309, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1272, -252, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1055, -43, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(966, 192, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1081, 501, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(949, 868, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(445, 710, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(342, 573, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(549, 514, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(496, 958, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(139, 958, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(-312, 964, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(-694, 947, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(440, 876, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1355, 413, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1574, 488, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1490, 216, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1407, 325, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1196, 281, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1363, 218, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1571, 428, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(984, 620, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(154, -291, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(452, -661, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(-3, -565, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(-509, -69, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(-547, 601, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(-308, 674, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(-58, 479, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(212, -222, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(-451, -11, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(-972, 92, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(-1214, 102, 40));

		// 'Siaria' GenType 49 Spawn Points
		AddSpawnPoint("f_castle_20_2.Id5", "f_castle_20_2", Rectangle(-504, 505, 9999));
	}
}
