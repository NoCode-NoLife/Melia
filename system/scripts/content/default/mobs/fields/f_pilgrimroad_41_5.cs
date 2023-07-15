//--- Melia Script -----------------------------------------------------------
// f_pilgrimroad_41_5
//
//--- Description -----------------------------------------------------------
// Sets up the f_pilgrimroad_41_5 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad415MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_pilgrimroad_41_5.Id1", MonsterId.Rootcrystal_05, 16, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_41_5.Id2", MonsterId.Nuka_Brown, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_41_5.Id3", MonsterId.Lapasape_Bow_Brown, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_41_5.Id4", MonsterId.Elma_Red, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_41_5.Id5", MonsterId.Lapasape_Bow_Brown, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(-1709.8447, 472.86575, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(-1449.1157, 488.82462, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(-1018.1002, 382.09955, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(-834.3419, 134.67421, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(-689.16583, 409.32642, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(-445.36987, 864.70276, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(-186.4937, 875.1436, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(-852.8792, -266.31332, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(-817.97406, -564.5253, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(-1051.1049, -951.26935, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(-174.13489, 100.12817, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(-56.06346, -210.21228, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(179.95544, 74.05412, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(-62.607903, -673.8705, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(101.86656, -947.63525, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(588.5701, 380.422, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(707.10126, -405.04675, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(1000.6989, -367.6134, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(1145.0411, 80.8928, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(1229.1825, 412.2823, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(1540.1917, 155.1247, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(1868.1455, 294.26404, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(1119.3175, -905.8885, 50));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id1", "f_pilgrimroad_41_5", Spot(1400.684, -1058.575, 50));

		// Nuka_Brown Spawn Points
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-205.84795, -211.69676, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-214.82715, 8.597209, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(253.13785, -186.94972, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(58.98812, -279.42712, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(300.2322, 198.38039, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(508.33194, 371.90305, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(630.3546, 503.04208, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(765.056, 396.2276, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(695.8789, 343.99496, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1112.4806, 92.36174, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1048.9832, 275.25623, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1253.5576, 556.24384, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1308.5895, 258.09265, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1572.4083, 39.782158, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1475.0029, 240.0422, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(448.85297, -303.135, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(645.5752, -336.341, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(863.4205, -281.50473, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(961.83276, -444.92654, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(874.01575, -515.92676, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(822.21783, -458.4909, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(741.76117, -515.3307, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(5.0226517, -626.15424, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-88.27244, -945.24146, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(119.59507, -965.2029, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1119.2313, -884.85474, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1178.1825, -1122.721, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1388.8849, -1083.0037, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1358.7421, -875.5664, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1274.9369, -1008.7655, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1090.3455, -961.4658, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-725.776, 101.27617, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-1124.2966, 382.30167, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-970.22473, 560.96356, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-691.7607, 555.34174, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-600.23126, 250.141, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-471.77316, 207.54706, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(223.74333, 29.634739, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-502.64627, 798.4671, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-494.29803, 996.79224, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-187.54544, 1030.6809, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-296.71432, 747.75464, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-325.2098, 827.58453, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-1099.4219, -282.0042, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-688.0453, -217.47629, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-838.80975, -397.49844, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-963.4967, -537.7594, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-833.0841, -652.94293, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-928.7583, -737.89954, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-1190.9928, -949.5723, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1059.1052, 441.3634, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1237.5143, 394.11163, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1364.1356, 123.94168, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-669.80225, -546.95404, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-122.7769, 157.38011, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(56.545116, 110.62978, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(39.47939, -1005.9026, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-1044.9125, -1219.7622, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1209.715, 246.82834, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-961.5054, -1029.4822, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-901.8751, -308.9185, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-955.3542, 450.22873, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-1065.857, -1086.5767, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-297.72272, 119.76287, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-806.0078, -242.5839, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-999.84717, -376.572, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1644.3508, 206.2815, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(55.3728, -25.888062, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-161.9945, -764.19476, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-659.8797, -378.3518, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-1177.9725, -860.3284, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-963.13666, -215.70508, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1613.3759, 308.27112, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-953.18494, -931.0856, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-1030.5925, -850.0205, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-976.87665, -855.2758, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1400.5421, 443.536, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(149.4226, -81.513115, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1366.635, -824.6226, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-272.85376, 191.52327, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-765.1732, 239.75769, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(760.9845, -360.07007, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-66.719894, -640.7037, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-895.4027, -939.8642, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1272.2391, -891.29297, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1355.6826, -44.672405, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-155.65958, -878.421, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-847.22833, 115.93233, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-836.31683, 431.74255, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(1126.8773, -1082.1086, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-298.3362, -140.99055, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id2", "f_pilgrimroad_41_5", Spot(-1166.7582, -1223.3394, 25));

		// Lapasape_Bow_Brown Spawn Points
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(686.9813, -422.0639, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(806.1514, -277.03125, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(942.3174, -331.55844, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(841.6269, -414.13632, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(815.5464, -535.2765, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(940.84406, -540.2787, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(517.55853, 383.6621, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(588.6195, 514.61304, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(695.3546, 552.34955, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(697.69714, 369.55304, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(678.8352, 245.79424, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1341.6903, 126.76852, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1241.8175, 291.34982, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1117.7817, 237.27824, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1201.8536, 89.869255, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1388.999, 338.7826, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1160.8116, 485.1712, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1120.3762, -947.4123, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1240.9921, -887.2743, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1358.3442, -883.6027, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1377.6407, -1047.4547, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1259.9528, -1049.3004, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1173.9333, -1093.484, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1266.318, -1210.7012, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(263.86584, 233.97372, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(453.292, -246.33714, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(535.04285, -272.79056, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1541.0569, 115.64298, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1580.0701, 232.05133, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1442.5789, 199.18553, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1060.9683, 375.02908, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1004.5103, 170.84827, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(731.6154, -344.81674, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1037.21, -409.80212, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1092.6063, -849.6152, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(983.595, -717.9383, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1069.7279, -1040.9711, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id3", "f_pilgrimroad_41_5", Spot(1421.5339, -956.3463, 25));

		// Elma_Red Spawn Points
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-1172.4209, -1072.005, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-1133.8378, -952.7166, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-1029.8439, -973.34064, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(139.0486, -918.05493, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-899.8234, -596.4592, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-851.5656, -402.89398, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-1012.1726, -350.2707, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-834.3762, -188.32503, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-729.7438, -391.67798, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-890.292, -261.0501, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-511.13446, 902.83435, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-331.78622, 980.08185, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-161.2013, 881.5744, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-281.6498, 749.12036, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-259.32565, 667.3936, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-492.25632, 813.94495, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-142.97362, 1019.7617, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(655.6351, 440.90808, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(517.47296, 476.41495, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(627.3541, 310.09897, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(747.54834, 305.3276, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(814.87964, 401.2977, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(740.7745, 493.0276, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(544.9238, 292.80768, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-182.84924, 108.6391, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-181.274, -43.376057, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-76.858505, -187.76137, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-117.47657, -786.26556, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(46.355995, -752.32385, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(35.70121, -850.11536, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-39.470642, -964.7772, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(71.05475, -1030.7999, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(185.65585, -997.70715, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-55.036957, -620.7266, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-229.60278, -158.98973, 25));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id4", "f_pilgrimroad_41_5", Spot(-16.519808, -2.7482605, 25));

		// Lapasape_Bow_Brown Spawn Points
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-1140.8081, -1031.269, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-1178.3403, -905.9884, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-1046.9592, -1032.3754, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-914.5267, -828.9815, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-938.32043, -665.96704, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-766.5919, -559.31616, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-904.8673, -402.6649, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-1003.7281, -474.42386, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-738.7295, -379.36444, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-873.823, -278.62146, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-834.7689, -189.33565, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-872.2342, 18.524399, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-626.57635, 113.66556, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-594.77313, 381.19357, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-757.0176, 30.088024, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-1098.2317, 469.6988, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-1077.7349, 257.14807, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-803.0828, 545.6654, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-499.8901, 748.6763, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-566.20123, 1013.2734, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-464.8439, 1082.2351, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-353.22125, 970.0949, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-433.48746, 854.7406, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-222.962, 733.25543, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-161.1568, 923.8892, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-36.942463, -936.5821, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(220.77286, -886.1639, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(99.42034, -1004.3033, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(16.095873, -859.05615, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-164.36081, -823.58295, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-61.847404, -721.0702, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-65.19563, -587.6961, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-67.34667, -388.76923, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-104.67104, -358.83945, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(39.075523, -153.16109, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-193.33116, -119.38867, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-176.8014, -245.849, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-206.44208, 63.751698, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(-142.12036, 233.59286, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(5.987503, 70.187744, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(107.87783, 162.3663, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(134.37056, -30.924232, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(228.38727, -212.31114, 30));
		AddSpawnPoint( "f_pilgrimroad_41_5.Id5", "f_pilgrimroad_41_5", Spot(329.19812, -206.48502, 30));

	}
}
