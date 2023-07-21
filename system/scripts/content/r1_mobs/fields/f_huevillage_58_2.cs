//--- Melia Script -----------------------------------------------------------
// Vieta Gorge Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_huevillage_58_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FHuevillage582MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_huevillage_58_2", MonsterId.Ultanun, Properties("MHP", 28724, "MINPATK", 870, "MAXPATK", 972, "MINMATK", 870, "MAXMATK", 972, "DEF", 170, "MDEF", 170));
		AddPropertyOverrides("f_huevillage_58_2", MonsterId.Zibu_Maize, Properties("MHP", 29140, "MINPATK", 876, "MAXPATK", 978, "MINMATK", 876, "MAXMATK", 978, "DEF", 170, "MDEF", 170));
		AddPropertyOverrides("f_huevillage_58_2", MonsterId.Rudas_Loxodon, Properties("MHP", 29583, "MINPATK", 881, "MAXPATK", 985, "MINMATK", 881, "MAXMATK", 985, "DEF", 171, "MDEF", 171));
		AddPropertyOverrides("f_huevillage_58_2", MonsterId.Boss_Woodspirit_Blue, Properties("MHP", 142447, "MINPATK", 1810, "MAXPATK", 2025, "MINMATK", 1810, "MAXMATK", 2025, "DEF", 350, "MDEF", 350));

		// Monster Spawners ---------------------------------

		AddSpawner("f_huevillage_58_2.Id1", MonsterId.Ultanun, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_2.Id2", MonsterId.Zibu_Maize, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_2.Id3", MonsterId.Zibu_Maize, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_2.Id4", MonsterId.Ultanun, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_2.Id5", MonsterId.Zibu_Maize, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_2.Id6", MonsterId.Rootcrystal_01, 9, 11, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_2.Id7", MonsterId.Ultanun, 60, 80, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_2.Id8", MonsterId.Zibu_Maize, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_2.Id9", MonsterId.Rudas_Loxodon, 3, 3, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Ultanun' GenType 29 Spawn Points
		AddSpawnPoint("f_huevillage_58_2.Id1", "f_huevillage_58_2", Rectangle(702, 119, 9999));

		// 'Zibu_Maize' GenType 31 Spawn Points
		AddSpawnPoint("f_huevillage_58_2.Id2", "f_huevillage_58_2", Rectangle(636, 19, 9999));

		// 'Zibu_Maize' GenType 32 Spawn Points
		AddSpawnPoint("f_huevillage_58_2.Id3", "f_huevillage_58_2", Rectangle(-820, -122, 35));
		AddSpawnPoint("f_huevillage_58_2.Id3", "f_huevillage_58_2", Rectangle(-944, -452, 35));
		AddSpawnPoint("f_huevillage_58_2.Id3", "f_huevillage_58_2", Rectangle(-154, 13, 35));
		AddSpawnPoint("f_huevillage_58_2.Id3", "f_huevillage_58_2", Rectangle(-5, -139, 35));
		AddSpawnPoint("f_huevillage_58_2.Id3", "f_huevillage_58_2", Rectangle(-6, 185, 35));
		AddSpawnPoint("f_huevillage_58_2.Id3", "f_huevillage_58_2", Rectangle(-393, -81, 35));
		AddSpawnPoint("f_huevillage_58_2.Id3", "f_huevillage_58_2", Rectangle(-757, -340, 35));
		AddSpawnPoint("f_huevillage_58_2.Id3", "f_huevillage_58_2", Rectangle(-653, -511, 35));
		AddSpawnPoint("f_huevillage_58_2.Id3", "f_huevillage_58_2", Rectangle(-540, -294, 35));

		// 'Ultanun' GenType 38 Spawn Points
		AddSpawnPoint("f_huevillage_58_2.Id4", "f_huevillage_58_2", Rectangle(-864, -353, 30));
		AddSpawnPoint("f_huevillage_58_2.Id4", "f_huevillage_58_2", Rectangle(343, -855, 30));
		AddSpawnPoint("f_huevillage_58_2.Id4", "f_huevillage_58_2", Rectangle(477, -1103, 30));
		AddSpawnPoint("f_huevillage_58_2.Id4", "f_huevillage_58_2", Rectangle(677, -770, 30));
		AddSpawnPoint("f_huevillage_58_2.Id4", "f_huevillage_58_2", Rectangle(565, -939, 30));
		AddSpawnPoint("f_huevillage_58_2.Id4", "f_huevillage_58_2", Rectangle(580, -624, 30));
		AddSpawnPoint("f_huevillage_58_2.Id4", "f_huevillage_58_2", Rectangle(-688, -169, 30));
		AddSpawnPoint("f_huevillage_58_2.Id4", "f_huevillage_58_2", Rectangle(397, -596, 30));
		AddSpawnPoint("f_huevillage_58_2.Id4", "f_huevillage_58_2", Rectangle(-339, -78, 30));
		AddSpawnPoint("f_huevillage_58_2.Id4", "f_huevillage_58_2", Rectangle(-794, -98, 30));

		// 'Zibu_Maize' GenType 39 Spawn Points
		AddSpawnPoint("f_huevillage_58_2.Id5", "f_huevillage_58_2", Rectangle(414, -1103, 30));
		AddSpawnPoint("f_huevillage_58_2.Id5", "f_huevillage_58_2", Rectangle(598, -964, 30));
		AddSpawnPoint("f_huevillage_58_2.Id5", "f_huevillage_58_2", Rectangle(409, -791, 30));
		AddSpawnPoint("f_huevillage_58_2.Id5", "f_huevillage_58_2", Rectangle(250, -639, 30));
		AddSpawnPoint("f_huevillage_58_2.Id5", "f_huevillage_58_2", Rectangle(505, -536, 30));
		AddSpawnPoint("f_huevillage_58_2.Id5", "f_huevillage_58_2", Rectangle(587, -800, 30));
		AddSpawnPoint("f_huevillage_58_2.Id5", "f_huevillage_58_2", Rectangle(286, -944, 30));

		// 'Rootcrystal_01' GenType 40 Spawn Points
		AddSpawnPoint("f_huevillage_58_2.Id6", "f_huevillage_58_2", Rectangle(246, -1747, 200));
		AddSpawnPoint("f_huevillage_58_2.Id6", "f_huevillage_58_2", Rectangle(-348, -1390, 200));
		AddSpawnPoint("f_huevillage_58_2.Id6", "f_huevillage_58_2", Rectangle(-634, -1128, 200));
		AddSpawnPoint("f_huevillage_58_2.Id6", "f_huevillage_58_2", Rectangle(497, -603, 200));
		AddSpawnPoint("f_huevillage_58_2.Id6", "f_huevillage_58_2", Rectangle(-853, -557, 200));
		AddSpawnPoint("f_huevillage_58_2.Id6", "f_huevillage_58_2", Rectangle(-369, -111, 200));
		AddSpawnPoint("f_huevillage_58_2.Id6", "f_huevillage_58_2", Rectangle(-161, 1099, 200));
		AddSpawnPoint("f_huevillage_58_2.Id6", "f_huevillage_58_2", Rectangle(849, 754, 200));
		AddSpawnPoint("f_huevillage_58_2.Id6", "f_huevillage_58_2", Rectangle(705, -8, 200));
		AddSpawnPoint("f_huevillage_58_2.Id6", "f_huevillage_58_2", Rectangle(1575, 672, 200));
		AddSpawnPoint("f_huevillage_58_2.Id6", "f_huevillage_58_2", Rectangle(113, 461, 200));

		// 'Ultanun' GenType 43 Spawn Points
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-440, 253, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-77, 1188, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-219, 1117, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-78, 1349, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(60, 1118, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(198, 1266, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-251, 1253, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-284, 212, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-557, 246, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(199, 1222, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(263, 1226, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(222, 1170, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(241, 1358, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(163, 1298, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(111, 1305, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(140, 1202, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(40, 1170, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(78, 1049, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-10, 1080, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-28, 1014, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-96, 963, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-149, 891, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-176, 938, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-210, 988, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-130, 1050, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-209, 1036, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-134, 1126, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-61, 1085, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-38, 1326, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-134, 1300, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(63, 976, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(739, 96, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(700, 26, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(624, -62, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(594, 53, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(791, -8, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(820, 99, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(640, 109, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(663, 62, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(552, 96, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(583, -39, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(522, -53, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(492, 58, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(721, 246, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(578, 183, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-256, 277, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-444, 416, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-446, 329, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-261, 11, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-338, -11, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-262, -96, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-68, -132, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(16, -67, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-61, -40, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-140, -126, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-159, -50, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-245, -40, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-199, -4, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-95, 41, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-542, -378, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-599, -416, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-669, -455, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-624, -334, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-696, -562, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-849, -530, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-957, -528, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-825, -451, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-777, -394, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-665, -269, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-842, -278, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-978, -388, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-1047, -395, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-997, -283, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-910, -147, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-878, -16, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-934, 54, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-845, 105, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-826, -10, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-822, -350, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-643, -391, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-567, -167, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-338, -182, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-382, -111, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(-349, -38, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(936, 237, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(1019, 181, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(884, 242, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(813, 255, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(1012, 267, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(920, 384, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(848, 401, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(788, 448, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(718, 350, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(671, 448, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(738, 467, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(845, 622, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(885, 592, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(751, 632, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(794, 720, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(886, 706, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(566, -550, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(621, -623, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(633, -675, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(638, -728, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(642, -813, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(623, -879, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(641, -917, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(540, -995, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(454, -971, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(504, -901, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(527, -826, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(558, -760, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(369, -719, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(348, -638, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(329, -588, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(358, -530, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(295, -803, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(352, -789, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(317, -983, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(358, -1007, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(396, -1022, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(842, 739, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(751, 788, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(714, 700, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(807, 657, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(753, 529, 30));
		AddSpawnPoint("f_huevillage_58_2.Id7", "f_huevillage_58_2", Rectangle(928, 442, 30));

		// 'Zibu_Maize' GenType 44 Spawn Points
		AddSpawnPoint("f_huevillage_58_2.Id8", "f_huevillage_58_2", Rectangle(-444, 229, 100));

		// 'Rudas_Loxodon' GenType 45 Spawn Points
		AddSpawnPoint("f_huevillage_58_2.Id9", "f_huevillage_58_2", Rectangle(-57, 81, 9999));
	}
}
