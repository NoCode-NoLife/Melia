//--- Melia Script -----------------------------------------------------------
// f_nicopolis_81_1
//
//--- Description -----------------------------------------------------------
// Sets up the f_nicopolis_81_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FNicopolis811MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_nicopolis_81_1.Id1", MonsterId.Cresent_Moya, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_nicopolis_81_1.Id2", MonsterId.Mimorat_Purple, 31, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_nicopolis_81_1.Id3", MonsterId.Mimorat_Green, 31, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_nicopolis_81_1.Id4", MonsterId.Haunted_House, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_nicopolis_81_1.Id5", MonsterId.Rootcrystal_02, 17, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Cresent_Moya Spawn Points
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(-844.5347, 201.6146, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(-644.12225, -111.36785, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(-505.72986, 61.99442, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(-239.71921, 228.98666, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(-214.91763, 539.44556, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(118.28345, 278.3266, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(471.6277, 512.3971, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(488.45602, 165.01363, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(619.1172, 337.47403, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(913.0336, 397.79745, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(527.77466, -102.7515, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(-282.93384, -1046.1194, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(-209.79811, -1386.4314, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(-63.518215, -1105.4938, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(220.63545, -789.3582, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(371.2538, -1047.6559, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(552.0885, -769.02295, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(404.24493, -395.63165, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(757.26874, -661.17834, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(1044.8883, -1222.6519, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(1197.7189, -976.23, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(1460.4944, -1064.7451, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(1550.1709, -738.3106, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(1605.8889, -257.96085, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(1881.008, 210.62332, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(1432.8799, 174.49323, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(762.1753, 1122.3756, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(1013.7807, 814.7435, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(917.30084, 1204.1575, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(3073.5083, 529.91327, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(1445.5674, 689.6375, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(1652.0232, 1122.5747, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(1563.8651, 1400.8091, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(2004.8398, 1095.4994, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(2505.6914, 1287.6122, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(2957.3784, 1145.9648, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(3272.3674, 874.9827, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(3161.4495, 586.38666, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(3539.73, 443.0434, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(3097.1636, 190.19748, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(2880.399, -31.905037, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(2265.7715, -152.4319, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(2634.7583, -110.06591, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(1080.7559, 1247.131, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(2238.3154, 1386.0862, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(1904.5183, 1013.5798, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(2411.4133, -1232.3813, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(2431.22, -1095.6559, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(2706.5723, -1140.5026, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(2809.576, -940.51135, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(2914.723, -987.5068, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Spot(2553.4531, -1130.5146, 25));

		// Mimorat_Purple Spawn Points
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(-1575.5525, 583.9586, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(-1575.0724, 173.01942, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(-1454.068, 347.85373, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(-866.0656, 360.92017, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(-688.4752, 68.44554, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(-427.006, 324.22125, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(-490.54657, -61.148525, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(-68.49364, 412.82025, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(164.8803, 618.03827, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(816.7281, 422.2256, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(362.09293, 424.56363, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(597.9021, 95.39641, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(681.66626, -335.87204, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(499.7178, -662.65094, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(1219.0358, 498.19928, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(1769.7386, 395.0728, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(2355.0217, 1260.8018, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(3116.8237, 1030.0192, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(1955.6649, 733.2883, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(867.2254, 868.76013, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(926.3583, 1075.7258, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(2044.1221, 1358.802, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(2801.198, 1264.5404, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(3036.003, 430.2334, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(2973.778, 149.94461, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(3016.13, 804.51, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(3438.8704, 541.0184, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(1326.7422, 1328.5779, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(2599.9458, -158.04942, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(1546.3387, 102.23921, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Spot(1725.8031, -136.73508, 25));

		// Mimorat_Green Spawn Points
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(958.19714, -1036.0496, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(1238.6699, -1229.4532, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(977.77075, -774.18365, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(2104.0408, -1243.8153, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(2365.4087, -1179.7927, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(2577.2927, -1169.5281, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(373.83896, -849.5769, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(486.63605, -934.30414, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(644.19855, -1066.3931, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(612.91736, -475.00436, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(156.76823, -1067.9761, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(-330.122, -1334.5771, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(-229.14632, -1179.2045, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(-91.57091, -1008.4174, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(-11.936096, -1310.3256, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(1328.2606, -824.59705, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(1528.1648, -533.399, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(1748.2769, -391.4862, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(1564.3806, -68.223335, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(1750.0691, 233.06755, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(1144.3351, 370.46396, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(1431.366, 570.801, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(1565.8923, 420.05475, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(1733.4952, 549.0148, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(1987.4221, 479.41418, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(1315.2146, 1466.4594, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(812.1363, 992.71466, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(1849.3275, 1214.9672, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(1505.1527, 743.497, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(1773.5404, 865.51373, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Spot(2048.1057, 669.5932, 25));

		// Haunted_House Spawn Points
		AddSpawnPoint( "f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Spot(733.774, 460.70303, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Spot(1431, 346.6917, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Spot(1702.5833, 606.2792, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Spot(1720.2511, 1422.3374, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Spot(3247.2483, 780.0619, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Spot(3173.3635, 279.84488, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Spot(1860.1991, 562.19476, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Spot(1176.7062, 1369.0828, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Spot(500.45898, 36.861412, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Spot(3648.2866, 542.96643, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Spot(1663.3888, -275.59128, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Spot(2457.1333, 1339.5442, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Spot(514.8906, -807.5915, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Spot(1646.2959, -1135.3082, 25));
		AddSpawnPoint( "f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Spot(2530.2483, -155.21402, 25));

		// Rootcrystal_02 Spawn Points
		AddSpawnPoint( "f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Spot(1672.4302, -1069.836, 100));
		AddSpawnPoint( "f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Spot(2508.021, -1138.9358, 100));
		AddSpawnPoint( "f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Spot(935.1432, -1041.0602, 100));
		AddSpawnPoint( "f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Spot(553.70807, -839.10986, 100));
		AddSpawnPoint( "f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Spot(-253.82141, -1332.575, 100));
		AddSpawnPoint( "f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Spot(542.87146, -20.180971, 100));
		AddSpawnPoint( "f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Spot(655.23584, 447.092, 100));
		AddSpawnPoint( "f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Spot(1635.2548, -312.49918, 100));
		AddSpawnPoint( "f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Spot(1581.1929, 409.07132, 100));
		AddSpawnPoint( "f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Spot(1870.2258, 813.0467, 100));
		AddSpawnPoint( "f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Spot(909.866, 1105.1661, 100));
		AddSpawnPoint( "f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Spot(2521.923, 1279.4241, 100));
		AddSpawnPoint( "f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Spot(3190.138, 839.6591, 100));
		AddSpawnPoint( "f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Spot(3010.2722, 75.872055, 100));
		AddSpawnPoint( "f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Spot(65.75467, 362.40442, 100));
		AddSpawnPoint( "f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Spot(-558.6126, -3.707199, 100));
		AddSpawnPoint( "f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Spot(-1501.828, 294.34348, 100));
		AddSpawnPoint( "f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Spot(426.4467, -1148.2609, 100));

	}
}
