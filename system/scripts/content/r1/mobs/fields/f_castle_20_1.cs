//--- Melia Script -----------------------------------------------------------
// Outer Wall District 9 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_castle_20_1'.
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

		AddSpawner("f_castle_20_1.Id1", MonsterId.Rootcrystal_01, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(60000), tendency: TendencyType.Peaceful);
		AddSpawner("f_castle_20_1.Id2", MonsterId.Aklaspetal, min: 19, max: 25, tendency: TendencyType.Aggressive);
		AddSpawner("f_castle_20_1.Id3", MonsterId.Aklaschurl, min: 19, max: 25, tendency: TendencyType.Aggressive);
		AddSpawner("f_castle_20_1.Id4", MonsterId.Aklasia, min: 19, max: 25, tendency: TendencyType.Aggressive);
		AddSpawner("f_castle_20_1.Id5", MonsterId.Aklascountess, min: 30, max: 40, tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 30 Spawn Points
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(-886, -525, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(-484, -591, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(55, -347, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(255, -724, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(824, -720, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(-1124, 343, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(-445, 346, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(-101, 325, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(448, 337, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(926, 326, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(697, 744, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(4, 788, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(-279, 1149, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(29, 1102, 100));
		AddSpawnPoint("f_castle_20_1.Id1", "f_castle_20_1", Rectangle(520, -487, 100));

		// 'Aklaspetal' GenType 31 Spawn Points
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-640, 270, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-658, 431, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-502, 420, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-461, 272, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-138, 362, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(9, 433, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(124, 277, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(72, 196, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(297, 337, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(539, 302, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(626, 388, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(832, 336, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(939, 421, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(858, 408, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(879, 197, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(667, 233, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(580, 145, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(343, 262, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(681, 649, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(834, 884, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(825, 745, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(893, 602, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(896, 530, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(928, 481, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(65, 364, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-228, 226, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-154, 424, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-765, 360, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-1038, 373, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-1192, 410, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-1193, 268, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(-1039, 235, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(815, 161, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(254, 738, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(387, 868, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(408, 732, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(475, 756, 40));
		AddSpawnPoint("f_castle_20_1.Id2", "f_castle_20_1", Rectangle(330, 881, 40));

		// 'Aklaschurl' GenType 32 Spawn Points
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-396, -696, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-309, -498, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-256, -698, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-209, -340, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-23, -285, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(126, -337, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(253, -312, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(165, -542, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(88, -733, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(208, -853, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(357, -634, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(235, -773, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(349, -804, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(512, -696, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(618, -631, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(791, -626, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(985, -661, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(905, -835, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(791, -750, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(638, -796, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(403, -709, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(510, -826, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-163, -290, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-551, -586, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-597, -418, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-867, -473, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-706, -581, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-738, -448, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-849, -359, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-719, -300, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(-679, -382, 40));
		AddSpawnPoint("f_castle_20_1.Id3", "f_castle_20_1", Rectangle(431, -361, 40));

		// 'Aklasia' GenType 33 Spawn Points
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(742, 262, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(472, 390, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(166, 398, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(-237, 358, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(-184, 194, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(161, 208, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(511, 261, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(723, 165, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(822, 683, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(815, 875, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(626, 807, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(342, 809, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(1, 806, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(-59, 1057, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(-346, 1218, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(-207, 1362, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(-113, 1199, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(195, 711, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(973, 246, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(-1283, 298, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(-831, 369, 40));
		AddSpawnPoint("f_castle_20_1.Id4", "f_castle_20_1", Rectangle(-802, 412, 40));

		// 'Aklascountess' GenType 34 Spawn Points
		AddSpawnPoint("f_castle_20_1.Id5", "f_castle_20_1", Rectangle(268, -641, 9999));
	}
}
