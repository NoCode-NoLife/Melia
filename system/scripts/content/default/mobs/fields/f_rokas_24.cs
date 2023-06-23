//--- Melia Script -----------------------------------------------------------
// f_rokas_24
//
//--- Description -----------------------------------------------------------
// Sets up the f_rokas_24 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FRokas24MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Populations
		AddMonsterPopulation("f_rokas_24", "population_rootcrystal_05_1", 16);
		AddMonsterPopulation("f_rokas_24", "population_tontus_2", 10);
		AddMonsterPopulation("f_rokas_24", "population_pino_3", 12);
		AddMonsterPopulation("f_rokas_24", "population_geppetto_4", 20);
		AddMonsterPopulation("f_rokas_24", "population_dandel_5", 7);
		AddMonsterPopulation("f_rokas_24", "population_tontus_6", 15);
		AddMonsterPopulation("f_rokas_24", "population_dandel_7", 35);
		AddMonsterPopulation("f_rokas_24", "population_tontus_8", 15);
		AddMonsterPopulation("f_rokas_24", "population_dandel_9", 10);

		// RootCrystal Spawners
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(-424, -3381, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(-1389, -1593, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(-150, -39, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(-2093.9302, -17.369675, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(685, -935, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(963, 72, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(-178, 1294, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(-457.6898, -2061.4604, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(-368.97058, -2650.1384, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(219.54692, -2952.7075, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(747.31696, -2240.6975, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(1653.6085, -106.67441, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(1138.1848, 750.4171, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(791.4284, 728.42084, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(-453.9842, 89.885254, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(-831.00464, -27.57958, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(-1209.23, -530.7189, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(-1817.0934, -946.6698, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(-934.88165, -2266.7544, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(481.40833, 450.51657, 30));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(5000), "f_rokas_24", Spot(296.1962, -1911.1422, 30));

		// Monster Spawners
		AddSpawner(MonsterId.Tontus, "population_tontus_2", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-213.81676, -612.3331, 200));
		AddSpawner(MonsterId.Tontus, "population_tontus_2", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-633.3946, 68.81155, 200));
		AddSpawner(MonsterId.Tontus, "population_tontus_2", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-967.138, -737.1952, 200));
		AddSpawner(MonsterId.Tontus, "population_tontus_2", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-779.95654, -368.1134, 200));
		AddSpawner(MonsterId.Tontus, "population_tontus_2", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-80.76819, -111.006, 200));
		AddSpawner(MonsterId.Tontus, "population_tontus_2", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-137.54143, -2029.0577, 200));
		AddSpawner(MonsterId.Tontus, "population_tontus_2", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-465.63278, -3324.6436, 200));
		AddSpawner(MonsterId.Tontus, "population_tontus_2", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-476.89355, -2671.3926, 200));
		AddSpawner(MonsterId.Pino, "population_pino_3", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-230.93312, -1756.1863, 25));
		AddSpawner(MonsterId.Pino, "population_pino_3", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-623.4417, -2666.569, 25));
		AddSpawner(MonsterId.Pino, "population_pino_3", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-251.28525, -2695.6794, 25));
		AddSpawner(MonsterId.Pino, "population_pino_3", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-136.22395, -2115.712, 25));
		AddSpawner(MonsterId.Pino, "population_pino_3", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(294.48502, -125.92965, 25));
		AddSpawner(MonsterId.Pino, "population_pino_3", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-809.5451, -2620.3645, 25));
		AddSpawner(MonsterId.Pino, "population_pino_3", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-486.61465, -2473.1367, 25));
		AddSpawner(MonsterId.Pino, "population_pino_3", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-432.3534, -2892.629, 25));
		AddSpawner(MonsterId.Pino, "population_pino_3", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-247.01787, -2864.771, 25));
		AddSpawner(MonsterId.Pino, "population_pino_3", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-384.45337, -2704.0361, 25));
		AddSpawner(MonsterId.Pino, "population_pino_3", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-376.42682, -2107.804, 25));
		AddSpawner(MonsterId.Pino, "population_pino_3", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-517.22253, -1914.432, 25));
		AddSpawner(MonsterId.Pino, "population_pino_3", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-350.9479, -1727.2378, 25));
		AddSpawner(MonsterId.Pino, "population_pino_3", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(51.584606, -2084.1487, 25));
		AddSpawner(MonsterId.Pino, "population_pino_3", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-26.751713, -1739.575, 25));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-210.08438, -1973.6403, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-486.78247, -3301.728, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-436.0404, -2692.7776, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(982.2972, -922.9892, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(653.93787, -756.099, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(679.744, -314.10574, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-658.8242, -2608.5178, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-571.2404, -2822.336, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-271.83066, -2865.185, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-209.11462, -2641.2627, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-422.36722, -2452.9878, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-895.14185, -2006.4275, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-829.31714, -2184.589, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-632.4444, -1983.4569, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-394.464, -1824.741, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(34.948204, -1837.1277, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(54.260162, -2152.9587, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-102.06416, -2252.9075, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-256.20587, -1682.3555, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-438.11932, -2092.0696, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(791.73724, -1140.6453, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(1210.8862, -877.33167, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(1140.617, -532.3471, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(561.5747, -574.7298, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(720.51556, -983.5102, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(947.3669, -1049.6816, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(962.8267, -476.53836, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(1098.814, -700.1723, 20));
		AddSpawner(MonsterId.Geppetto, "population_geppetto_4", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(868.4334, -671.078, 20));
		AddSpawner(MonsterId.Dandel, "population_dandel_5", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-459.0937, -1904.2373, 25));
		AddSpawner(MonsterId.Dandel, "population_dandel_5", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-19.591354, -1822.6411, 25));
		AddSpawner(MonsterId.Dandel, "population_dandel_5", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-50.50488, -2170.276, 25));
		AddSpawner(MonsterId.Dandel, "population_dandel_5", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-736.17065, -2705.5732, 25));
		AddSpawner(MonsterId.Dandel, "population_dandel_5", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-722.1881, -2635.316, 25));
		AddSpawner(MonsterId.Dandel, "population_dandel_5", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-542.6788, -2867.0388, 25));
		AddSpawner(MonsterId.Dandel, "population_dandel_5", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-458.14536, -2591.2473, 25));
		AddSpawner(MonsterId.Dandel, "population_dandel_5", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-285.67584, -2792.526, 25));
		AddSpawner(MonsterId.Dandel, "population_dandel_5", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-281.2108, -2641.218, 25));
		AddSpawner(MonsterId.Dandel, "population_dandel_5", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-120.43071, -2754.42, 25));
		AddSpawner(MonsterId.Dandel, "population_dandel_5", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-885.2203, -2163.1514, 25));
		AddSpawner(MonsterId.Dandel, "population_dandel_5", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-253.25346, -2165.9553, 25));
		AddSpawner(MonsterId.Dandel, "population_dandel_5", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-253.45706, -1638.1163, 25));
		AddSpawner(MonsterId.Dandel, "population_dandel_5", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-284.98862, -1827.6963, 25));
		AddSpawner(MonsterId.Dandel, "population_dandel_5", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(106.34071, -2109.64, 25));
		AddSpawner(MonsterId.Dandel, "population_dandel_5", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-1309.021, -1486.2302, 25));
		AddSpawner(MonsterId.Dandel, "population_dandel_5", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-1710.6495, -1346.8441, 25));
		AddSpawner(MonsterId.Dandel, "population_dandel_5", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-1465.5135, -1275.1289, 25));
		AddSpawner(MonsterId.Dandel, "population_dandel_5", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-1651.9961, -1109.8832, 25));
		AddSpawner(MonsterId.Dandel, "population_dandel_5", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-1221.6825, -1254.5701, 25));
		AddSpawner(MonsterId.Tontus, "population_tontus_6", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-716.14514, -217.63432, 9999));
		AddSpawner(MonsterId.Dandel, "population_dandel_7", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-48.488506, 1338.2025, 9999));
		AddSpawner(MonsterId.Tontus, "population_tontus_8", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-118.11904, -66.01437, 40));
		AddSpawner(MonsterId.Tontus, "population_tontus_8", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-57.69225, -356.3601, 40));
		AddSpawner(MonsterId.Tontus, "population_tontus_8", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-921.33905, -261.1131, 40));
		AddSpawner(MonsterId.Tontus, "population_tontus_8", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(151.90355, -57.233116, 40));
		AddSpawner(MonsterId.Tontus, "population_tontus_8", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-401.64062, 12.189072, 40));
		AddSpawner(MonsterId.Tontus, "population_tontus_8", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-452.12305, -306.11798, 40));
		AddSpawner(MonsterId.Tontus, "population_tontus_8", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-662.0149, 13.29623, 40));
		AddSpawner(MonsterId.Tontus, "population_tontus_8", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-582.102, -773.7753, 40));
		AddSpawner(MonsterId.Tontus, "population_tontus_8", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-267.14105, -631.1138, 40));
		AddSpawner(MonsterId.Tontus, "population_tontus_8", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-701.7245, -466.14273, 40));
		AddSpawner(MonsterId.Tontus, "population_tontus_8", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-2123.1626, -294.07675, 40));
		AddSpawner(MonsterId.Tontus, "population_tontus_8", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-1976.4003, 118.67117, 40));
		AddSpawner(MonsterId.Tontus, "population_tontus_8", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-1542.1348, -185.35149, 40));
		AddSpawner(MonsterId.Tontus, "population_tontus_8", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-1527.0303, -175.34155, 40));
		AddSpawner(MonsterId.Tontus, "population_tontus_8", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-1532.7852, -145.9143, 40));
		AddSpawner(MonsterId.Tontus, "population_tontus_8", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-2057.3525, -92.3089, 40));
		AddSpawner(MonsterId.Tontus, "population_tontus_8", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-1786.115, -199.76729, 40));
		AddSpawner(MonsterId.Tontus, "population_tontus_8", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(-1785.9487, -2.4954605, 40));
		AddSpawner(MonsterId.Dandel, "population_dandel_9", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(722.6565, -591.7834, 30));
		AddSpawner(MonsterId.Dandel, "population_dandel_9", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(1092.6458, -963.3998, 30));
		AddSpawner(MonsterId.Dandel, "population_dandel_9", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(878.5002, -954.6343, 30));
		AddSpawner(MonsterId.Dandel, "population_dandel_9", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(985.9741, -488.19855, 30));
		AddSpawner(MonsterId.Dandel, "population_dandel_9", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(1113.1932, -654.81604, 30));
		AddSpawner(MonsterId.Dandel, "population_dandel_9", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(665.8417, -847.764, 30));
		AddSpawner(MonsterId.Dandel, "population_dandel_9", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(743.5269, -348.3849, 30));
		AddSpawner(MonsterId.Dandel, "population_dandel_9", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(754.5592, -1174.1998, 30));
		AddSpawner(MonsterId.Dandel, "population_dandel_9", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(498.58566, -681.4946, 30));
		AddSpawner(MonsterId.Dandel, "population_dandel_9", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(1256.3411, -847.28864, 30));
		AddSpawner(MonsterId.Dandel, "population_dandel_9", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(900.4066, -0.26140213, 30));
		AddSpawner(MonsterId.Dandel, "population_dandel_9", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(931.1891, -829.3478, 30));
		AddSpawner(MonsterId.Dandel, "population_dandel_9", TimeSpan.FromMilliseconds(0), "f_rokas_24", Spot(738.9697, -749.75903, 30));

	}
}
