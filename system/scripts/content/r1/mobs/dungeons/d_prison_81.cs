//--- Melia Script -----------------------------------------------------------
// d_prison_81
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Workshop' map.
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

		AddSpawner("d_prison_81.Id1", MonsterId.Nuka_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_81.Id2", MonsterId.Elma_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_81.Id3", MonsterId.TerraNymph_Bow_Brown, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_prison_81.Id4", MonsterId.Rootcrystal_05, 9, 12, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_prison_81.Id5", MonsterId.TerraNymph_Bow_Brown, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Nuka_Blue' GenType 1 Spawn Points
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(974.05786, 494.81848, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(1025.9553, 254.36548, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(969.1659, 327.09146, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(703.3568, 322.1651, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(958.92596, 415.60574, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(611.1878, 311.64035, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(561.65454, -225.28725, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(609.27155, -143.00473, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(518.55054, -89.03827, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(617.8846, -14.512952, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(626.99725, 167.84233, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(657.41986, 402.00143, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(868.67426, 477.29913, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(654.4534, 250.27022, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(913.223, 241.1172, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(1039.1251, 386.94684, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(713.17975, 466.84933, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(1482.3405, 857.80615, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(1329.7034, 766.76483, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(1407.1548, 930.279, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(1420.8422, 746.9436, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(513.6011, 807.4423, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(583.9111, 889.9893, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(1300.8801, 847.33386, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(419.8652, 843.1946, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(890.5078, 363.59888, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(85.275345, 789.2106, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(17.067917, 860.7611, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-62.187347, 730.0842, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-160.55255, 892.83344, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-289.5906, 783.0369, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-499.36685, 719.73254, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-740.76794, 736.5505, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-760.926, 548.0357, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1161.3898, 566.65314, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-960.73926, 734.712, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-965.01776, 449.92932, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1012.1022, 923.20715, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-845.3816, 804.7771, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-672.93854, 561.8323, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-843.8324, 709.05914, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-579.3579, 448.3003, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-415.2619, 231.49312, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-299.0598, 109.84174, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-363.19373, -27.927143, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-150.50504, 14.134575, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-35.771748, 175.79102, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-158.65063, 160.16566, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-72.850174, 24.683407, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-238.14706, 348.75153, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-47.40948, 323.50156, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-405.86456, -245.34145, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-379.02753, -500.50647, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-444.0863, -516.97375, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-121.57349, 85.5293, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-279.94217, 16.375141, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-410.66254, -124.78656, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-424.68048, -30.871635, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-904.5614, -758.812, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-868.3806, -487.11053, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1082.3717, -598.6884, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1256.9154, -609.51105, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1217.4412, -522.3831, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1113.4073, -389.06195, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-887.29364, -619.4525, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1024.8595, -264.3351, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1242.097, -283.45862, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-851.27277, -269.056, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1151.7429, -637.419, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1022.2352, -762.73724, 25));
		AddSpawnPoint("d_prison_81.Id1", "d_prison_81", Rectangle(-1235.3514, -423.3677, 25));

		// 'Elma_Blue' GenType 2 Spawn Points
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-232.28235, 866.9786, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(476.0324, 916.5398, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(602.37195, 791.3789, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(635.7234, 25.930853, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(541.70544, 740.2201, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(959.2873, 334.31943, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(433.94174, 754.3189, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(264.6612, 747.51086, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(1265.9856, 774.48285, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(1358.337, 855.3169, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(1469.2767, 788.60034, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(1455.9038, 909.73694, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-321.55347, 748.8774, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-107.9812, 897.5011, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-1.3336906, 731.3378, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-740.59326, 655.609, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-635.7513, 440.46182, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-917.4807, 605.9066, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-677.18695, 779.2946, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-1047.3182, 907.4691, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-623.39136, 639.4054, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-411.6988, 73.0953, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-62.466736, 169.92738, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-131.98433, -48.36979, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(-239.7438, 76.33732, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(572.79486, 76.62615, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(817.1562, 368.18823, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(721.1771, 235.02278, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(988.9286, 452.92795, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(954.08496, 235.2444, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(1359.4534, 726.52783, 25));
		AddSpawnPoint("d_prison_81.Id2", "d_prison_81", Rectangle(628.7078, 408.7019, 25));

		// 'TerraNymph_Bow_Brown' GenType 3 Spawn Points
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-356.71585, -19.877026, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-380.01846, 189.76685, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-172.96611, 182.54288, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-223.9187, 66.78145, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-89.22376, -24.961517, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-40.586548, 99.39953, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-565.3214, 442.7174, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-883.5279, 601.1176, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-1031.8066, 631.44836, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-972.6527, 814.0072, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-763.40533, 645.81683, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-646.76794, 779.8183, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-411.1007, 731.505, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-282.05505, 898.1632, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-117.40588, 748.47534, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-45.807735, 899.6703, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(58.37774, 742.74445, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(115.3787, 874.91437, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-912.6555, 677.07294, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-1059.6846, 718.8009, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-821.5893, 497.0533, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-1105.2648, 620.69415, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-1183.6237, 519.3299, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-930.216, 459.88754, 25));
		AddSpawnPoint("d_prison_81.Id3", "d_prison_81", Rectangle(-672.3116, 483.96777, 25));

		// 'Rootcrystal_05' GenType 7 Spawn Points
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(834.9429, -634.1702, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(915.7879, -875.48376, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(522.1619, -345.48706, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(628.8077, 310.0136, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(991.79016, 330.0734, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(1309.9178, 677.39374, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(1017.1938, 735.5558, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(340.657, 723.8002, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(-67.97107, 814.5092, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(-338.36035, 820.6375, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(-492.91077, 339.9631, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(-205.4164, -29.041313, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(-408.7644, -367.21634, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(-1151.1638, -581.97906, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(-823.61896, -418.2342, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(-1261.2043, -986.8822, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(-711.8701, 506.43918, 100));
		AddSpawnPoint("d_prison_81.Id4", "d_prison_81", Rectangle(-1014.515, 744.3171, 100));

		// 'TerraNymph_Bow_Brown' GenType 13 Spawn Points
		AddSpawnPoint("d_prison_81.Id5", "d_prison_81", Rectangle(536.8377, -99.86342, 9999));
	}
}
