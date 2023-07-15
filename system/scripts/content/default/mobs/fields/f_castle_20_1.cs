//--- Melia Script -----------------------------------------------------------
// f_castle_20_1
//
//--- Description -----------------------------------------------------------
// Sets up the f_castle_20_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle201MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_castle_20_1", MonsterId.Aklaspetal, Properties("MHP", 597735, "MINPATK", 8187, "MAXPATK", 9964, "MINMATK", 8187, "MAXMATK", 9964, "DEF", 126453, "MDEF", 126453));
		AddPropertyOverrides("f_castle_20_1", MonsterId.Aklaschurl, Properties("MHP", 598446, "MINPATK", 8196, "MAXPATK", 9976, "MINMATK", 8196, "MAXMATK", 9976, "DEF", 126879, "MDEF", 126879));
		AddPropertyOverrides("f_castle_20_1", MonsterId.Aklasia, Properties("MHP", 599233, "MINPATK", 8206, "MAXPATK", 9988, "MINMATK", 8206, "MAXMATK", 9988, "DEF", 127350, "MDEF", 127350));
		AddPropertyOverrides("f_castle_20_1", MonsterId.Aklascountess, Properties("MHP", 600088, "MINPATK", 8217, "MAXPATK", 10001, "MINMATK", 8217, "MAXMATK", 10001, "DEF", 127862, "MDEF", 127862));

		// Monster Spawners --------------------------------

		AddSpawner("f_castle_20_1.Id1", MonsterId.Rootcrystal_01, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_20_1.Id2", MonsterId.Aklaspetal, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_castle_20_1.Id3", MonsterId.Aklaschurl, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_castle_20_1.Id4", MonsterId.Aklasia, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_castle_20_1.Id5", MonsterId.Aklascountess, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_castle_20_1.Id1", "f_castle_20_1", Spot(-886.494, -525.9811, 100));
		AddSpawnPoint( "f_castle_20_1.Id1", "f_castle_20_1", Spot(-484.29565, -591.6181, 100));
		AddSpawnPoint( "f_castle_20_1.Id1", "f_castle_20_1", Spot(55.865997, -347.43784, 100));
		AddSpawnPoint( "f_castle_20_1.Id1", "f_castle_20_1", Spot(255.5886, -724.489, 100));
		AddSpawnPoint( "f_castle_20_1.Id1", "f_castle_20_1", Spot(824.6736, -720.31354, 100));
		AddSpawnPoint( "f_castle_20_1.Id1", "f_castle_20_1", Spot(-1124.7842, 343.08533, 100));
		AddSpawnPoint( "f_castle_20_1.Id1", "f_castle_20_1", Spot(-445.574, 346.26257, 100));
		AddSpawnPoint( "f_castle_20_1.Id1", "f_castle_20_1", Spot(-101.33011, 325.38046, 100));
		AddSpawnPoint( "f_castle_20_1.Id1", "f_castle_20_1", Spot(448.29602, 337.0285, 100));
		AddSpawnPoint( "f_castle_20_1.Id1", "f_castle_20_1", Spot(926.7045, 326.2113, 100));
		AddSpawnPoint( "f_castle_20_1.Id1", "f_castle_20_1", Spot(697.1227, 744.8302, 100));
		AddSpawnPoint( "f_castle_20_1.Id1", "f_castle_20_1", Spot(4.025114, 788.28766, 100));
		AddSpawnPoint( "f_castle_20_1.Id1", "f_castle_20_1", Spot(-279.15704, 1149.6644, 100));
		AddSpawnPoint( "f_castle_20_1.Id1", "f_castle_20_1", Spot(29.552103, 1102.1584, 100));
		AddSpawnPoint( "f_castle_20_1.Id1", "f_castle_20_1", Spot(520.7424, -487.01324, 100));

		// Aklaspetal Spawn Points
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(-640.12, 270.87, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(-658.94, 431.23, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(-502.28, 420.48, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(-461.6, 272.36, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(-138.43, 362.51, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(9.3, 433.82, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(124.41, 277.65, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(72.74, 196.27, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(297.35, 337.04, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(539.97, 302.72, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(626.05, 388.81, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(832.09, 336.07, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(939.35, 421.42, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(858.08453, 408.53812, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(879.35, 197.34, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(667.54, 233.08, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(580.27, 145.82, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(343.5, 262.77, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(681.16, 649.2, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(834.78, 884.16, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(825.83, 745.11, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(893.91, 602.86, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(896.63, 530.58, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(928.7, 481.84, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(65.86, 364.17, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(-228.07, 226.31, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(-154.87, 424.4, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(-765.96, 360.56, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(-1038.8, 373.26, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(-1192, 410.1, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(-1193.76, 268.64, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(-1039.91, 235.13, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(815.85, 161.19, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(254.66, 738.75, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(387.23, 868.17, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(408.24, 732.55, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(475.22, 756.61, 40));
		AddSpawnPoint( "f_castle_20_1.Id2", "f_castle_20_1", Spot(330.39, 881.56, 40));

		// Aklaschurl Spawn Points
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(-396.07, -696.25, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(-309.88, -498.38, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(-256.4, -698.89, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(-209, -340.49, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(-23.82, -285.32, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(126.1, -337.58, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(253.37, -312.41, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(165.57, -542.28, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(88.91, -733.08, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(208.81, -853.26, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(357.11, -634.72, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(235.61, -773.66, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(349.98, -804.09, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(512.15, -696.73, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(618.52, -631.54, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(791.14, -626.72, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(985.03, -661.66, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(905.89, -835.13, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(791.29, -750.36, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(638.85, -796.08, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(403.57, -709.38, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(510.62, -826.82, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(-163.87, -290.93, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(-551.06, -586.71, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(-597.74, -418.62, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(-867.34, -473.26, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(-706.1, -581.72, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(-738.81, -448.08, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(-849.83, -359.61, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(-719.57, -300.37, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(-679, -382.37, 40));
		AddSpawnPoint( "f_castle_20_1.Id3", "f_castle_20_1", Spot(431.03, -361.57, 40));

		// Aklasia Spawn Points
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(742.06, 262.29, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(472.01, 390.77, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(166.59, 398.76, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(-237.21, 358.57, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(-184.19, 194.8, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(161.49, 208.82, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(511.5, 261.43, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(723.7, 165.6, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(822.33, 683.47, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(815.26, 875.8, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(626.28, 807.81, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(342.55, 809.86, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(1.05, 806.98, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(-59.8, 1057.07, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(-346.3, 1218.63, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(-207.52, 1362.88, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(-113.75, 1199.9, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(195.53, 711, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(973.5519, 246.74034, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(-1283.27, 298.68, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(-831.86, 369.56, 40));
		AddSpawnPoint( "f_castle_20_1.Id4", "f_castle_20_1", Spot(-802.65, 412.72, 40));

		// Aklascountess Spawn Points
		AddSpawnPoint( "f_castle_20_1.Id5", "f_castle_20_1", Spot(268.9703, -641.1311, 9999));

	}
}
