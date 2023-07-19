//--- Melia Script -----------------------------------------------------------
// f_castle_20_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Outer Wall District 9' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle201MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_castle_20_1", MonsterId.Aklaspetal, Properties("MHP", 597735, "MINPATK", 8187, "MAXPATK", 9964, "MINMATK", 8187, "MAXMATK", 9964, "DEF", 126453, "MDEF", 126453));
		AddPropertyOverrides("f_castle_20_1", MonsterId.Aklaschurl, Properties("MHP", 598446, "MINPATK", 8196, "MAXPATK", 9976, "MINMATK", 8196, "MAXMATK", 9976, "DEF", 126879, "MDEF", 126879));
		AddPropertyOverrides("f_castle_20_1", MonsterId.Aklasia, Properties("MHP", 599233, "MINPATK", 8206, "MAXPATK", 9988, "MINMATK", 8206, "MAXMATK", 9988, "DEF", 127350, "MDEF", 127350));
		AddPropertyOverrides("f_castle_20_1", MonsterId.Aklascountess, Properties("MHP", 600088, "MINPATK", 8217, "MAXPATK", 10001, "MINMATK", 8217, "MAXMATK", 10001, "DEF", 127862, "MDEF", 127862));

		// Monster Spawners ---------------------------------

		AddSpawner("f_castle_20_1.Id1", MonsterId.Rootcrystal_01, 12, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_20_1.Id2", MonsterId.Aklaspetal, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_castle_20_1.Id3", MonsterId.Aklaschurl, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_castle_20_1.Id4", MonsterId.Aklasia, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_castle_20_1.Id5", MonsterId.Aklascountess, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 30 Spawn Points
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(-886.494, -525.9811, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(-484.29565, -591.6181, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(55.865997, -347.43784, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(255.5886, -724.489, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(824.6736, -720.31354, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(-1124.7842, 343.08533, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(-445.574, 346.26257, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(-101.33011, 325.38046, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(448.29602, 337.0285, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(926.7045, 326.2113, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(697.1227, 744.8302, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(4.025114, 788.28766, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(-279.15704, 1149.6644, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(29.552103, 1102.1584, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(520.7424, -487.01324, 100));

		// 'Aklaspetal' GenType 31 Spawn Points
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-640.12, 270.87, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-658.94, 431.23, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-502.28, 420.48, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-461.6, 272.36, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-138.43, 362.51, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(9.3, 433.82, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(124.41, 277.65, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(72.74, 196.27, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(297.35, 337.04, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(539.97, 302.72, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(626.05, 388.81, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(832.09, 336.07, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(939.35, 421.42, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(858.08453, 408.53812, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(879.35, 197.34, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(667.54, 233.08, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(580.27, 145.82, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(343.5, 262.77, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(681.16, 649.2, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(834.78, 884.16, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(825.83, 745.11, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(893.91, 602.86, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(896.63, 530.58, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(928.7, 481.84, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(65.86, 364.17, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-228.07, 226.31, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-154.87, 424.4, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-765.96, 360.56, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-1038.8, 373.26, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-1192, 410.1, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-1193.76, 268.64, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-1039.91, 235.13, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(815.85, 161.19, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(254.66, 738.75, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(387.23, 868.17, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(408.24, 732.55, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(475.22, 756.61, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(330.39, 881.56, 40));

		// 'Aklaschurl' GenType 32 Spawn Points
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-396.07, -696.25, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-309.88, -498.38, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-256.4, -698.89, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-209, -340.49, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-23.82, -285.32, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(126.1, -337.58, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(253.37, -312.41, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(165.57, -542.28, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(88.91, -733.08, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(208.81, -853.26, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(357.11, -634.72, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(235.61, -773.66, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(349.98, -804.09, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(512.15, -696.73, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(618.52, -631.54, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(791.14, -626.72, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(985.03, -661.66, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(905.89, -835.13, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(791.29, -750.36, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(638.85, -796.08, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(403.57, -709.38, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(510.62, -826.82, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-163.87, -290.93, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-551.06, -586.71, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-597.74, -418.62, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-867.34, -473.26, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-706.1, -581.72, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-738.81, -448.08, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-849.83, -359.61, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-719.57, -300.37, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-679, -382.37, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(431.03, -361.57, 40));

		// 'Aklasia' GenType 33 Spawn Points
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(742.06, 262.29, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(472.01, 390.77, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(166.59, 398.76, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(-237.21, 358.57, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(-184.19, 194.8, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(161.49, 208.82, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(511.5, 261.43, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(723.7, 165.6, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(822.33, 683.47, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(815.26, 875.8, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(626.28, 807.81, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(342.55, 809.86, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(1.05, 806.98, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(-59.8, 1057.07, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(-346.3, 1218.63, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(-207.52, 1362.88, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(-113.75, 1199.9, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(195.53, 711, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(973.5519, 246.74034, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(-1283.27, 298.68, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(-831.86, 369.56, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(-802.65, 412.72, 40));

		// 'Aklascountess' GenType 34 Spawn Points
		AddSpawnPoint("f_castle_20_1.Id5", "f_castle_20_1", Rectangle(268.9703, -641.1311, 9999));
	}
}
