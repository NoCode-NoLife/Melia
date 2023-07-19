//--- Melia Script -----------------------------------------------------------
// f_castle_20_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Inner Wall District 9' map.
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

		AddSpawner("f_castle_20_2.Id1", MonsterId.Rootcrystal_01, 11, 14, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_20_2.Id2", MonsterId.Aklascenser, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_castle_20_2.Id3", MonsterId.Aklasbishop, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_castle_20_2.Id4", MonsterId.Aklashump, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_castle_20_2.Id5", MonsterId.Siaria, 1, 1, TimeSpan.FromMilliseconds(1800000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 35 Spawn Points
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(-1526.1594, 218.42545, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(-1261.4032, -68.49179, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(-844.7812, -118.81234, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(-818.3854, -564.75995, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(-69.21082, -1108.6007, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(539.8092, -573.62213, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(-467.08472, -93.80363, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(-773.5482, 883.692, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(-463.59354, 284.45764, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(-109.47452, 939.61145, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(1000.0673, 954.7131, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(1140.3602, 369.5439, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(1419.9187, -267.8655, 100));
		AddSpawnPoint("f_castle_20_2.Id1", "f_castle_20_2", Rectangle(1017.2308, -486.85315, 100));

		// 'Aklascenser' GenType 46 Spawn Points
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-516.33, -560.9, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-711.35, -574.07, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-874.54, -339.3, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-805.83, -177.51, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-1272.59, -156.51, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-1457.09, -78.13, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-1339.43, 102.4, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-1624.4, -0.18, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-1411.84, 245.54, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-1220.86, 160.19, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-1057.38, 50.98, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-726.50995, 350.21576, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-559.53, -177.32, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-379.01, -220.03, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-390.92, 32.76, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-419.25412, 276.09424, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-7.454055, 316.479, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(9.848435, 602.04785, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-448.00586, 495.7502, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-594.24976, 546.25214, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-481.06638, 919.9491, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-809.448, 587.58453, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-114.2536, 1001.5703, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(183.52367, 264.21713, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(289.64896, -171.74866, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(203.8599, -349.42923, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(35.92333, -292.27603, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(111.68148, -159.12283, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(271.17923, -63.02382, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-102.4471, -617.7099, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(143.06915, -516.33276, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(378.53836, -817.4452, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(534.84515, -759.5316, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(544.7553, -520.3237, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(382.07886, -672.12885, 40));
		AddSpawnPoint("f_castle_20_2.Id2", "f_castle_20_2", Rectangle(-171.43176, -562.0111, 40));

		// 'Aklasbishop' GenType 47 Spawn Points
		AddSpawnPoint("f_castle_20_2.Id3", "f_castle_20_2", Rectangle(201.06862, -223.18442, 9999));

		// 'Aklashump' GenType 48 Spawn Points
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(400.08, -583.61, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(969.94, -242, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1308.15, -368.33, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1533.03, -407.48, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1546.89, -143.01, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1428.72, -309.3, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1272.66, -252.77, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1055.69, -43.98, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(966.6286, 192.53195, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1081.7, 501.54, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(949.49, 868.05, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(445.3, 710.95, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(342.29, 573.39, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(549.91, 514.47, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(496.12, 958.88, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(139.65, 958.6, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(-312.04, 964.41, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(-694.11, 947.3, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(440.88, 876.98, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1355.75, 413.54, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1574.9, 488.15, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1490.21, 216.74, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1407.13, 325.7, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1196.22, 281.72, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1363.41, 218.52, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(1571.19, 428.35, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(984.72, 620.14, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(154.24016, -291.632, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(452.96283, -661.32214, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(-3.8402405, -565.4324, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(-509.6164, -69.38885, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(-547.1038, 601.67126, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(-308.43655, 674.084, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(-58.702847, 479.4422, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(212.9373, -222.51265, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(-451.1237, -11.16478, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(-972.34735, 92.24658, 40));
		AddSpawnPoint("f_castle_20_2.Id4", "f_castle_20_2", Rectangle(-1214.6698, 102.92072, 40));

		// 'Siaria' GenType 49 Spawn Points
		AddSpawnPoint("f_castle_20_2.Id5", "f_castle_20_2", Rectangle(-504.05286, 505.93903, 9999));
	}
}
