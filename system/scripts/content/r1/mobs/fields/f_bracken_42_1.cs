//--- Melia Script -----------------------------------------------------------
// Khonot Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_bracken_42_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FBracken421MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_bracken_42_1", MonsterId.Tanu_Blue, Properties("MHP", 462787, "MINPATK", 6452, "MAXPATK", 7832, "MINMATK", 6452, "MAXMATK", 7832, "DEF", 65300, "MDEF", 65300));
		AddPropertyOverrides("f_bracken_42_1", MonsterId.Doyor_Blue, Properties("MHP", 464199, "MINPATK", 6470, "MAXPATK", 7854, "MINMATK", 6470, "MAXMATK", 7854, "DEF", 65866, "MDEF", 65866));
		AddPropertyOverrides("f_bracken_42_1", MonsterId.Gosaru_Blue, Properties("MHP", 465703, "MINPATK", 6489, "MAXPATK", 7878, "MINMATK", 6489, "MAXMATK", 7878, "DEF", 66470, "MDEF", 66470));
		AddPropertyOverrides("f_bracken_42_1", MonsterId.Folibu_Yellow, Properties("MHP", 467293, "MINPATK", 6510, "MAXPATK", 7903, "MINMATK", 6510, "MAXMATK", 7903, "DEF", 67107, "MDEF", 67107));

		// Monster Spawners ---------------------------------

		AddSpawner("f_bracken_42_1.Id1", MonsterId.Rootcrystal_01, 12, 15, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_bracken_42_1.Id2", MonsterId.Tanu_Blue, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_42_1.Id3", MonsterId.Doyor_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_42_1.Id4", MonsterId.Gosaru_Blue, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_42_1.Id5", MonsterId.Folibu_Yellow, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_42_1.Id6", MonsterId.Gosaru_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 5 Spawn Points
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(-1019, -528, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(-813, -482, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(-824, -295, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(-506, 85, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(-467, 448, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(-1183, 289, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(-344, -341, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(-446, -625, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(-743, 893, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(63, 822, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(168, 961, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(762, 674, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(1079, 563, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(274, 422, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(356, -178, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(92, 86, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(134, -450, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(905, -599, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(711, -172, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(1004, -2, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(1787, -172, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(2007, -389, 50));

		// 'Tanu_Blue' GenType 100 Spawn Points
		AddSpawnPoint("f_bracken_42_1.Id2", "f_bracken_42_1", Rectangle(-906, -327, 30));
		AddSpawnPoint("f_bracken_42_1.Id2", "f_bracken_42_1", Rectangle(-991, -582, 30));
		AddSpawnPoint("f_bracken_42_1.Id2", "f_bracken_42_1", Rectangle(-1044, -572, 30));
		AddSpawnPoint("f_bracken_42_1.Id2", "f_bracken_42_1", Rectangle(-913, -519, 30));
		AddSpawnPoint("f_bracken_42_1.Id2", "f_bracken_42_1", Rectangle(-898, -429, 30));
		AddSpawnPoint("f_bracken_42_1.Id2", "f_bracken_42_1", Rectangle(-861, 174, 30));
		AddSpawnPoint("f_bracken_42_1.Id2", "f_bracken_42_1", Rectangle(-728, 218, 30));
		AddSpawnPoint("f_bracken_42_1.Id2", "f_bracken_42_1", Rectangle(-572, 223, 30));
		AddSpawnPoint("f_bracken_42_1.Id2", "f_bracken_42_1", Rectangle(-1152, 341, 30));
		AddSpawnPoint("f_bracken_42_1.Id2", "f_bracken_42_1", Rectangle(-963, 272, 30));

		// 'Doyor_Blue' GenType 101 Spawn Points
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-603, 239, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-554, 57, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-415, 226, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-475, -547, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-416, -717, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-369, -516, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-223, -510, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-213, -580, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-498, -480, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-882, 848, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-766, 936, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-687, 619, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-646, 795, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-290, -453, 30));

		// 'Gosaru_Blue' GenType 103 Spawn Points
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-22, -142, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(146, -255, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(325, -277, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(417, -174, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(208, 220, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-4, 767, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(68, 891, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(104, 799, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(192, 532, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(213, 346, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(854, -601, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(797, -524, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(722, -348, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(706, -221, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(853, -431, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(1023, -414, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(860, -341, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(673, -109, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(900, -90, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(833, -184, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(1008, -168, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(820, 2, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(949, 17, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(1036, -47, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(910, 339, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(767, 384, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(733, 527, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(767, 729, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(914, 736, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(1102, 656, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(1132, 597, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(1064, 469, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(963, 472, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(874, 486, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(832, 574, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(994, 638, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(351, -141, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(164, -354, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(23, -338, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-63, -6, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(0, 50, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(225, -114, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(256, 24, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(230, 119, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(124, 31, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(110, -139, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-413, -591, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-465, -625, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-288, -416, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-412, -460, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-396, -362, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-289, -570, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-188, -459, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-1019, -646, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-1032, -529, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-918, -555, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-1019, -479, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-947, -443, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-981, -390, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-810, -511, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-772, -346, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-806, -293, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-338, -99, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-367, -175, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-403, 34, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-463, -4, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-547, 29, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-607, 81, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-593, 157, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-515, 167, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-392, 261, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-688, 231, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-636, 225, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-710, 181, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-889, 224, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-927, 292, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-956, 229, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-1190, 320, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-1229, 222, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-1300, 240, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-1250, 181, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-839, 894, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-829, 802, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-771, 734, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-633, 633, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-698, 785, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-743, 967, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-723, 879, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-647, 839, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(212, 446, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(286, 427, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(244, 482, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(245, 411, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(221, 389, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(10, 819, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(272, 926, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(199, 811, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(211, 960, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(119, 989, 30));

		// 'Folibu_Yellow' GenType 104 Spawn Points
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(843, 739, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(731, 603, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(1079, 660, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(956, 674, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(1080, 791, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(878, 318, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(1110, 473, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(748, -411, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(880, -533, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(730, -129, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(887, 12, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(1043, -126, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(854, -146, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(750, 8, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(993, -271, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(855, -255, 30));

		// 'Gosaru_Blue' GenType 105 Spawn Points
		AddSpawnPoint("f_bracken_42_1.Id6", "f_bracken_42_1", Rectangle(188, 362, 9999));
	}
}
