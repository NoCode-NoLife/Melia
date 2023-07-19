//--- Melia Script -----------------------------------------------------------
// f_nicopolis_81_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Starry Town' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FNicopolis811MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_nicopolis_81_1.Id1", MonsterId.Cresent_Moya, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_nicopolis_81_1.Id2", MonsterId.Mimorat_Purple, 24, 31, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_nicopolis_81_1.Id3", MonsterId.Mimorat_Green, 24, 31, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_nicopolis_81_1.Id4", MonsterId.Haunted_House, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_nicopolis_81_1.Id5", MonsterId.Rootcrystal_02, 13, 17, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Cresent_Moya' GenType 22 Spawn Points
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(-844.5347, 201.6146, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(-644.12225, -111.36785, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(-505.72986, 61.99442, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(-239.71921, 228.98666, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(-214.91763, 539.44556, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(118.28345, 278.3266, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(471.6277, 512.3971, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(488.45602, 165.01363, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(619.1172, 337.47403, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(913.0336, 397.79745, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(527.77466, -102.7515, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(-282.93384, -1046.1194, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(-209.79811, -1386.4314, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(-63.518215, -1105.4938, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(220.63545, -789.3582, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(371.2538, -1047.6559, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(552.0885, -769.02295, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(404.24493, -395.63165, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(757.26874, -661.17834, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1044.8883, -1222.6519, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1197.7189, -976.23, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1460.4944, -1064.7451, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1550.1709, -738.3106, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1605.8889, -257.96085, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1881.008, 210.62332, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1432.8799, 174.49323, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(762.1753, 1122.3756, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1013.7807, 814.7435, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(917.30084, 1204.1575, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(3073.5083, 529.91327, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1445.5674, 689.6375, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1652.0232, 1122.5747, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1563.8651, 1400.8091, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2004.8398, 1095.4994, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2505.6914, 1287.6122, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2957.3784, 1145.9648, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(3272.3674, 874.9827, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(3161.4495, 586.38666, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(3539.73, 443.0434, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(3097.1636, 190.19748, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2880.399, -31.905037, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2265.7715, -152.4319, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2634.7583, -110.06591, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1080.7559, 1247.131, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2238.3154, 1386.0862, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(1904.5183, 1013.5798, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2411.4133, -1232.3813, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2431.22, -1095.6559, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2706.5723, -1140.5026, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2809.576, -940.51135, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2914.723, -987.5068, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id1", "f_nicopolis_81_1", Rectangle(2553.4531, -1130.5146, 25));

		// 'Mimorat_Purple' GenType 23 Spawn Points
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(-1575.5525, 583.9586, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(-1575.0724, 173.01942, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(-1454.068, 347.85373, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(-866.0656, 360.92017, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(-688.4752, 68.44554, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(-427.006, 324.22125, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(-490.54657, -61.148525, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(-68.49364, 412.82025, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(164.8803, 618.03827, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(816.7281, 422.2256, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(362.09293, 424.56363, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(597.9021, 95.39641, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(681.66626, -335.87204, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(499.7178, -662.65094, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(1219.0358, 498.19928, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(1769.7386, 395.0728, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(2355.0217, 1260.8018, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(3116.8237, 1030.0192, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(1955.6649, 733.2883, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(867.2254, 868.76013, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(926.3583, 1075.7258, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(2044.1221, 1358.802, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(2801.198, 1264.5404, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(3036.003, 430.2334, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(2973.778, 149.94461, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(3016.13, 804.51, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(3438.8704, 541.0184, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(1326.7422, 1328.5779, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(2599.9458, -158.04942, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(1546.3387, 102.23921, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id2", "f_nicopolis_81_1", Rectangle(1725.8031, -136.73508, 25));

		// 'Mimorat_Green' GenType 24 Spawn Points
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(958.19714, -1036.0496, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1238.6699, -1229.4532, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(977.77075, -774.18365, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(2104.0408, -1243.8153, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(2365.4087, -1179.7927, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(2577.2927, -1169.5281, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(373.83896, -849.5769, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(486.63605, -934.30414, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(644.19855, -1066.3931, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(612.91736, -475.00436, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(156.76823, -1067.9761, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(-330.122, -1334.5771, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(-229.14632, -1179.2045, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(-91.57091, -1008.4174, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(-11.936096, -1310.3256, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1328.2606, -824.59705, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1528.1648, -533.399, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1748.2769, -391.4862, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1564.3806, -68.223335, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1750.0691, 233.06755, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1144.3351, 370.46396, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1431.366, 570.801, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1565.8923, 420.05475, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1733.4952, 549.0148, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1987.4221, 479.41418, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1315.2146, 1466.4594, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(812.1363, 992.71466, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1849.3275, 1214.9672, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1505.1527, 743.497, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(1773.5404, 865.51373, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id3", "f_nicopolis_81_1", Rectangle(2048.1057, 669.5932, 25));

		// 'Haunted_House' GenType 25 Spawn Points
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(733.774, 460.70303, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(1431, 346.6917, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(1702.5833, 606.2792, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(1720.2511, 1422.3374, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(3247.2483, 780.0619, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(3173.3635, 279.84488, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(1860.1991, 562.19476, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(1176.7062, 1369.0828, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(500.45898, 36.861412, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(3648.2866, 542.96643, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(1663.3888, -275.59128, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(2457.1333, 1339.5442, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(514.8906, -807.5915, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(1646.2959, -1135.3082, 25));
		AddSpawnPoint("f_nicopolis_81_1.Id4", "f_nicopolis_81_1", Rectangle(2530.2483, -155.21402, 25));

		// 'Rootcrystal_02' GenType 36 Spawn Points
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(1672.4302, -1069.836, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(2508.021, -1138.9358, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(935.1432, -1041.0602, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(553.70807, -839.10986, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(-253.82141, -1332.575, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(542.87146, -20.180971, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(655.23584, 447.092, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(1635.2548, -312.49918, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(1581.1929, 409.07132, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(1870.2258, 813.0467, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(909.866, 1105.1661, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(2521.923, 1279.4241, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(3190.138, 839.6591, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(3010.2722, 75.872055, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(65.75467, 362.40442, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(-558.6126, -3.707199, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(-1501.828, 294.34348, 100));
		AddSpawnPoint("f_nicopolis_81_1.Id5", "f_nicopolis_81_1", Rectangle(426.4467, -1148.2609, 100));
	}
}
