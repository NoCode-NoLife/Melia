//--- Melia Script -----------------------------------------------------------
// Workshop Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_prison_81'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DPrison81MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_prison_81", MonsterId.Nuka_Blue, Properties("MHP", 436734, "MINPATK", 6117, "MAXPATK", 7420, "MINMATK", 6117, "MAXMATK", 7420, "DEF", 56467, "MDEF", 56467));
		AddPropertyOverrides("d_prison_81", MonsterId.Elma_Blue, Properties("MHP", 439848, "MINPATK", 6157, "MAXPATK", 7469, "MINMATK", 6157, "MAXMATK", 7469, "DEF", 57460, "MDEF", 57460));
		AddPropertyOverrides("d_prison_81", MonsterId.TerraNymph_Bow_Brown, Properties("MHP", 443031, "MINPATK", 6198, "MAXPATK", 7519, "MINMATK", 6198, "MAXMATK", 7519, "DEF", 58475, "MDEF", 58475));

		// Monster Spawners ---------------------------------

		AddSpawner("d_prison_81.Id1", MonsterId.Nuka_Blue, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("d_prison_81.Id2", MonsterId.Elma_Blue, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("d_prison_81.Id3", MonsterId.TerraNymph_Bow_Brown, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_prison_81.Id4", MonsterId.Rootcrystal_05, min: 9, max: 12, respawn: TimeSpan.FromMilliseconds(60000), tendency: TendencyType.Peaceful);
		AddSpawner("d_prison_81.Id5", MonsterId.TerraNymph_Bow_Brown, min: 23, max: 30, tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Nuka_Blue' GenType 1 Spawn Points
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(974, 494, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(1025, 254, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(969, 327, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(703, 322, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(958, 415, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(611, 311, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(561, -225, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(609, -143, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(518, -89, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(617, -14, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(626, 167, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(657, 402, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(868, 477, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(654, 250, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(913, 241, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(1039, 386, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(713, 466, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(1482, 857, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(1329, 766, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(1407, 930, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(1420, 746, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(513, 807, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(583, 889, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(1300, 847, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(419, 843, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(890, 363, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(85, 789, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(17, 860, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-62, 730, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-160, 892, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-289, 783, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-499, 719, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-740, 736, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-760, 548, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1161, 566, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-960, 734, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-965, 449, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1012, 923, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-845, 804, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-672, 561, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-843, 709, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-579, 448, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-415, 231, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-299, 109, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-363, -27, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-150, 14, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-35, 175, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-158, 160, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-72, 24, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-238, 348, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-47, 323, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-405, -245, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-379, -500, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-444, -516, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-121, 85, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-279, 16, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-410, -124, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-424, -30, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-904, -758, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-868, -487, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1082, -598, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1256, -609, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1217, -522, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1113, -389, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-887, -619, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1024, -264, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1242, -283, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-851, -269, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1151, -637, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1022, -762, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1235, -423, 25));

		// 'Elma_Blue' GenType 2 Spawn Points
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-232, 866, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(476, 916, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(602, 791, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(635, 25, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(541, 740, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(959, 334, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(433, 754, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(264, 747, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(1265, 774, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(1358, 855, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(1469, 788, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(1455, 909, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-321, 748, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-107, 897, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-1, 731, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-740, 655, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-635, 440, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-917, 605, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-677, 779, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-1047, 907, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-623, 639, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-411, 73, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-62, 169, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-131, -48, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-239, 76, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(572, 76, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(817, 368, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(721, 235, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(988, 452, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(954, 235, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(1359, 726, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(628, 408, 25));

		// 'TerraNymph_Bow_Brown' GenType 3 Spawn Points
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-356, -19, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-380, 189, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-172, 182, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-223, 66, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-89, -24, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-40, 99, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-565, 442, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-883, 601, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-1031, 631, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-972, 814, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-763, 645, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-646, 779, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-411, 731, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-282, 898, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-117, 748, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-45, 899, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(58, 742, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(115, 874, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-912, 677, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-1059, 718, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-821, 497, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-1105, 620, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-1183, 519, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-930, 459, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-672, 483, 25));

		// 'Rootcrystal_05' GenType 7 Spawn Points
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(834, -634, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(915, -875, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(522, -345, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(628, 310, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(991, 330, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(1309, 677, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(1017, 735, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(340, 723, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(-67, 814, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(-338, 820, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(-492, 339, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(-205, -29, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(-408, -367, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(-1151, -581, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(-823, -418, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(-1261, -986, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(-711, 506, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(-1014, 744, 100));

		// 'TerraNymph_Bow_Brown' GenType 13 Spawn Points
		AddSpawnPoint("d_prison_81.Id5", "d_prison_81", Rectangle(536, -99, 9999));
	}
}
