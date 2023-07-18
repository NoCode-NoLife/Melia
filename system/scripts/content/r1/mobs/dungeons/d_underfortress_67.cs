//--- Melia Script -----------------------------------------------------------
// d_underfortress_67
//
//--- Description -----------------------------------------------------------
// Sets up the d_underfortress_67 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DUnderfortress67MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_underfortress_67", MonsterId.Rambear_Brown, Properties("MHP", 303247, "MINPATK", 4400, "MAXPATK", 5310, "MINMATK", 4400, "MAXMATK", 5310, "DEF", 21908, "MDEF", 21908));
		AddPropertyOverrides("d_underfortress_67", MonsterId.Dandel_White, Properties("MHP", 305461, "MINPATK", 4429, "MAXPATK", 5345, "MINMATK", 4429, "MAXMATK", 5345, "DEF", 22318, "MDEF", 22318));
		AddPropertyOverrides("d_underfortress_67", MonsterId.Rambear_Bow_Brown, Properties("MHP", 307725, "MINPATK", 4458, "MAXPATK", 5381, "MINMATK", 4458, "MAXMATK", 5381, "DEF", 22738, "MDEF", 22738));
		AddPropertyOverrides("d_underfortress_67", MonsterId.Rambear_Mage_Brown, Properties("MHP", 310039, "MINPATK", 4488, "MAXPATK", 5418, "MINMATK", 4488, "MAXMATK", 5418, "DEF", 23167, "MDEF", 23167));

		// Monster Spawners --------------------------------

		AddSpawner("d_underfortress_67.Id1", MonsterId.Rambear_Brown, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_67.Id2", MonsterId.Dandel_White, 75, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_67.Id3", MonsterId.Rambear_Bow_Brown, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_67.Id4", MonsterId.Rambear_Mage_Brown, 12, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_67.Id5", MonsterId.Rootcrystal_03, 23, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("d_underfortress_67.Id6", MonsterId.Dandel_White, 8, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rambear_Brown Spawn Points
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-1004.0195, 782.208, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-339.61447, 1522.2462, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-379.46948, 348.24197, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-641.4392, -274.09543, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-958.4363, -525.42163, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-1374.7739, -1128.3773, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-366.03018, -1011.6506, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(327.69583, -729.7559, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(786.85956, -893.5168, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-176.47577, -1073.5413, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(494.62534, -1054.1866, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(310.7217, -907.73126, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(275.96262, 928.0767, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(469.0451, 990.0479, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-295.36746, 936.0849, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(334.47504, 661.0695, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1113.2435, 711.2624, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1400.5927, 357.64874, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1275.2844, -106.2543, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1338.5654, -265.83304, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1310.7538, 108.07147, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1591.8857, -612.31635, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1259.7335, -761.85187, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1410.8392, -838.60535, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-901.9565, -738.1001, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-725.7336, -487.04962, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-656.84674, 168.60858, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-661.41754, 588.9189, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-1438.3904, 853.01544, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-1160.5199, 759.6777, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-316.39185, 599.1248, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-185.53012, 1396.4363, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(836.0076, 589.8488, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(117.6416, 119.13939, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(83.98499, -93.148575, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(417.6654, -0.46158218, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(565.7325, 84.295944, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(159.24525, 320.09332, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1686.0892, -1684.9376, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1781.5596, -1425.4176, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1714.4158, -1344.8954, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1638.7333, -1384.038, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1488.7988, -850.45105, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1369.4556, -815.27295, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1231.118, -648.5792, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1725.6437, -651.59753, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1607.3439, -248.36548, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1295.8325, 415.30765, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1444.9348, 451.9513, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1515.9955, 332.29202, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1181.5234, 831.48346, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1222.9175, 776.11725, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1311.7081, 785.15314, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1376.1775, 828.77795, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1684.2052, 664.31274, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1861.674, 638.0253, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1944.9963, 663.72815, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(1780.9393, 681.78687, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(916.2751, 605.9115, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(427.09064, 691.1082, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(352.5785, 948.53326, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(294.93222, 866.0209, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(373.51416, 879.2928, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(480.71826, 680.54315, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(471.0025, 611.8425, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(344.30222, -762.14734, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(376.97458, -853.9231, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(512.4399, -949.5471, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(633.1216, -1021.7387, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(463.57678, -999.453, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(419.12817, -911.17914, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(434.68814, -854.09534, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(579.68585, -951.04675, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-16.337566, -1044.6411, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(61.77394, -1152.9822, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(76.8562, -982.20197, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(57.18787, -907.3731, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(29.679169, -1006.8257, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-306.1295, -1059.5925, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-301.3011, -1012.2607, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-1198.2517, -1166.2673, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-1079.5771, -1022.8908, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-1105.3712, -1166.9326, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-1320.167, -1165.3998, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-1266.1246, -1137.8074, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-1528.3365, -1117.8828, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-1502.2993, -992.3553, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-1644.0856, -1079.5452, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-897.10376, 481.26312, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-669.3827, 526.35364, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-638.20874, 553.66925, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-824.79645, 784.98334, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-886.13947, 779.732, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-893.7796, 863.51526, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-827.5267, 865.2904, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-1418.6741, 696.3016, 30));
		AddSpawnPoint( "d_underfortress_67.Id1", "d_underfortress_67", Spot(-1364.2235, 729.3496, 30));

		// Dandel_White Spawn Points
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-1087.9819, -1091.356, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-703.23267, -489.2697, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(676.0065, -932.6427, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1420.814, 569.6826, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1362.1746, -666.42096, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1522.9039, 275.4983, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1725.0908, -1476.4961, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(336.7772, 815.71967, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(945.2637, 541.32996, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-638.52814, 615.28375, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-1408.4725, 754.84155, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-278.055, 1862.299, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(404.52264, -977.3374, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-596.87585, 61.384216, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-1555.243, -1289.9117, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(506.31906, -864.12885, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(71.406586, -1059.1206, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(157.30316, 205.84898, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(233.26202, 554.73584, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(809.053, 506.6249, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(89.18606, -940.77515, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-974.9929, -716.4389, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-216.53395, -1050.5939, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1353.1097, -872.3561, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1623.5778, -968.9478, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1633.473, -1644.9849, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1837.1815, -1672.643, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1787.259, -1556.7051, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1276.6921, 838.05505, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1342.854, 298.52905, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1261.6935, 70.27436, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1276.2467, -232.6096, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1541.0769, -290.14066, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(697.7532, 600.56946, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(455.95505, 641.4332, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(418.31696, 910.8029, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(286.1551, 969.4211, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(141.13466, 362.75317, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(951.9015, -785.26013, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1223.493, -725.57245, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1582.6527, -437.32742, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1597.8579, -680.06854, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1273.1205, 554.3315, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1641.4052, 814.2518, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1826.6876, 550.5843, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-358.33582, 1576.2579, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-203.44801, 1323.0619, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-281.07907, 919.79224, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-397.06168, 436.98773, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-672.9909, 197.52542, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-666.687, -261.77002, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-436.04617, 259.96002, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-865.6717, 813.8964, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-1051.2404, 733.9735, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-1446.9838, 653.3911, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-962.47144, -545.8096, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-374.25555, -1062.1445, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(94.64194, -754.1846, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(107.47602, -40.15579, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-588.88007, 4.8738384, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(165.68935, -463.46658, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-339.8361, 1289.2355, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(43.450344, -373.48413, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-713.07556, -292.3538, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1762.5424, -1697.618, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1645.9844, -1581.8273, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1717.4266, -1551.7427, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1832.5834, -1478.4918, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1843.8506, -1603.9617, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1823.0525, -1385.7223, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1822.3141, -1330.405, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1664.5598, -1427.4598, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1625.2906, -1489.8884, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1597.3608, -1431.5269, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1543.415, -905.98486, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1464.3134, -890.62427, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1425.0901, -856.1412, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1533.5033, -809.58875, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1385.0459, -769.01044, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1287.9535, -733.25183, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1248.27, -827.3427, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1298.2668, -892.6475, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1222.3173, -861.178, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1172.4979, -847.5565, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1297.246, -661.2131, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1382.5243, -719.51276, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1318.2338, -775.8336, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1208.9202, -751.7268, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1519.2325, -679.8383, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1525.756, -584.6706, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1663.8939, -646.8922, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1568.3026, -561.00336, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1721.5723, -586.0644, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1647.6752, -569.86597, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1587.4309, -408.23297, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1658.541, -352.76025, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1614.1582, -296.29172, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1686.2747, -308.95776, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1579.3375, -344.4118, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1298.3115, -284.26752, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1308.822, -197.65508, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1321.8789, -254.41454, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1284.6993, 19.549461, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1284.2231, 99.69765, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1320.2291, 56.98366, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1500.9492, 213.00375, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1527.3248, 398.38486, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1431.808, 275.76508, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1283.9473, 356.9162, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1359.4586, 547.9981, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1294.3177, 624.3389, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1481.5, 522.1152, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1345.0862, 461.7209, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1633.2511, 620.745, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1641.0065, 711.9128, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1713.2507, 798.53485, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1922.7972, 533.8279, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1833.943, 748.3382, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1944.1882, 603.3784, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1726.466, 587.45056, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1921.6637, 762.1481, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1176.4567, 727.1902, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1240.3752, 901.365, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(1335.5728, 886.2825, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-260.85632, 1891.4298, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-298.6067, 1832.6896, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-317.68854, 1885.8398, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-287.40506, 1929.8909, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-233.48097, 1929.3724, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-365.41275, 1507.5525, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-403.74744, 1547.1471, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-279.6014, 1555.2286, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-207.981, 1483.6825, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-182.21733, 1371.9572, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-231.93265, 1345.0516, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-223.84207, 1265.2676, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-276.60822, 1304.1082, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-329.71024, 1381.4668, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-362.828, 1472.0371, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-204.95613, 1531.9414, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-142.85808, 1442.002, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-248.37761, 1398.8094, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-237.06328, 1484.5337, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-237.16954, 1585.6632, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-272.92056, 1246.4624, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-313.4422, 1223.4807, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-211.04651, 1207.5116, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-157.70749, 1543.1433, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-293.5459, 1416.0847, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-273.0374, 868.72565, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-286.92578, 966.8607, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-312.1922, 886.43195, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-378.18033, 479.80835, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-328.01782, 424.6917, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-367.72473, 368.87845, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-383.63446, 251.19284, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-433.85895, 217.35683, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-389.86038, 295.2303, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-443.69598, 321.51663, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-680.65894, 143.88226, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-719.85144, 209.28024, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-642.76385, 247.80713, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-595.3101, 164.29129, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-633.7645, 28.167786, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-700.1412, -240.3769, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-633.0562, -214.43018, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-604.6337, -302.38522, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-663.73663, -342.5268, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-685.6948, -544.0865, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-742.47504, -468.49384, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-650.56793, -483.4546, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-671.6817, -406.59622, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-727.0313, -357.5258, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-602.61035, -351.06522, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-946.21985, -678.9528, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-988.59784, -654.3245, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-960.20056, -592.8563, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-971.7583, -506.60406, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-1005.213, -568.608, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-949.028, -466.9345, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-1024.6342, -1085.6909, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-1157.218, -1130.2585, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-1378.1868, -1204.5936, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-1130.4453, -1061.9512, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-1496.506, -1316.3849, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-1469.3438, -1231.0934, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-1599.2261, -1129.2458, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-1590.899, -1168.8876, 30));
		AddSpawnPoint( "d_underfortress_67.Id2", "d_underfortress_67", Spot(-1444.8063, -1188.559, 30));

		// Rambear_Bow_Brown Spawn Points
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(-619.45844, 516.52734, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(-656.56537, 255.1579, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(-664.9862, 120.83253, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(-608.8925, 409.71024, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(-850.6456, 480.3331, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(-473.76004, 225.13762, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(-365.42224, 507.48007, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(-279.7257, 837.17224, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(359.06982, 601.1551, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(464.07214, 719.8502, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(257.39365, 694.60846, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(899.547, 449.098, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(733.096, 410.30292, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(907.439, 187.52966, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(1449.264, 382.44446, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(1453.0923, -291.54276, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(1123.5074, 784.5908, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(-1559.3011, -1206.024, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(-1578.997, -1052.5541, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(-919.6868, -550.3981, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(-723.6813, -615.92487, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(-766.7984, -345.18378, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(-579.3898, -249.51942, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(629.7936, -883.4429, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(-14.660513, -1114.4119, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(463.93692, 38.072716, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(923.0283, -795.074, 30));
		AddSpawnPoint( "d_underfortress_67.Id3", "d_underfortress_67", Spot(354.0536, -730.0383, 30));

		// Rambear_Mage_Brown Spawn Points
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(560.0137, -1020.8819, 30));
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(161.50002, 305.29065, 30));
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(-1600.2048, -1253.4951, 30));
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(-1267.7253, -1222.3602, 30));
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(-706.42773, -658.3786, 30));
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(-892.8044, -458.7049, 30));
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(-645.96967, 227.58324, 30));
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(-605.495, 584.35406, 30));
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(-377.28418, 588.2622, 30));
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(-567.5995, 386.56064, 30));
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(-909.96857, 513.95197, 30));
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(-874.4228, 824.88226, 30));
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(-1377.5931, 687.7117, 30));
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(-1382.125, 847.2995, 30));
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(-1055.0057, 798.3925, 30));
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(-173.10587, 1411.008, 30));
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(-172.21571, 1554.6903, 30));
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(-301.03848, 989.2574, 30));
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(-313.58447, 1340.7996, 30));
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(-320.6575, 1686.4335, 30));
		AddSpawnPoint( "d_underfortress_67.Id4", "d_underfortress_67", Spot(-715.69385, -134.32074, 30));

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(258.34622, -1359.3303, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(53.326614, -849.6376, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(128.62766, -157.39957, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(420.59586, 702.6857, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(368.49893, 934.81036, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(853.6138, 581.02637, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(552.405, 385.6705, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(580.4613, -1023.889, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(1384.0961, -781.23804, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(1744.9093, -1620.6298, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(1658.0817, -605.2982, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(1302.4271, -189.83403, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(1522.5808, 212.26723, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(1417.8754, 667.8966, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(-1335.8289, -1172.2981, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(-860.75946, -737.7344, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(-628.33734, -242.18239, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(-755.92615, 868.97266, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(-1425.4608, 728.2206, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(-350.45453, 330.03217, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(-287.50757, 902.3043, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(-274.59995, 1490.6091, 40));
		AddSpawnPoint( "d_underfortress_67.Id5", "d_underfortress_67", Spot(-403.78543, 1990.8446, 40));

		// Dandel_White Spawn Points
		AddSpawnPoint( "d_underfortress_67.Id6", "d_underfortress_67", Spot(1763.5991, -1624.5828, 20));
		AddSpawnPoint( "d_underfortress_67.Id6", "d_underfortress_67", Spot(1725.7094, -1403.0344, 20));
		AddSpawnPoint( "d_underfortress_67.Id6", "d_underfortress_67", Spot(1315.0298, -858.18176, 20));
		AddSpawnPoint( "d_underfortress_67.Id6", "d_underfortress_67", Spot(1609.2303, -1013.9641, 20));
		AddSpawnPoint( "d_underfortress_67.Id6", "d_underfortress_67", Spot(1320.73, -164.69, 20));
		AddSpawnPoint( "d_underfortress_67.Id6", "d_underfortress_67", Spot(1298.18, 39.28, 20));
		AddSpawnPoint( "d_underfortress_67.Id6", "d_underfortress_67", Spot(1125.8956, 881.95056, 20));
		AddSpawnPoint( "d_underfortress_67.Id6", "d_underfortress_67", Spot(1263.3887, 703.6056, 20));

	}
}