//--- Melia Script -----------------------------------------------------------
// f_rokas_24
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Gateway of the Great King' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRokas24MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_rokas_24.Id1", MonsterId.Rootcrystal_05, 12, 16, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_rokas_24.Id2", MonsterId.Tontus, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_24.Id3", MonsterId.Dandel, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_24.Id4", MonsterId.Tontus, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_24.Id5", MonsterId.Pino, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_24.Id6", MonsterId.Geppetto, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_24.Id7", MonsterId.Dandel, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_24.Id8", MonsterId.Tontus, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_24.Id9", MonsterId.Dandel, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 600 Spawn Points
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-424, -3381, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-1389, -1593, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-150, -39, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-2093.9302, -17.369675, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(685, -935, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(963, 72, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-178, 1294, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-457.6898, -2061.4604, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-368.97058, -2650.1384, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(219.54692, -2952.7075, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(747.31696, -2240.6975, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(1653.6085, -106.67441, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(1138.1848, 750.4171, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(791.4284, 728.42084, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-453.9842, 89.885254, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-831.00464, -27.57958, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-1209.23, -530.7189, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-1817.0934, -946.6698, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-934.88165, -2266.7544, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(481.40833, 450.51657, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(296.1962, -1911.1422, 30));

		// 'Tontus' GenType 627 Spawn Points
		AddSpawnPoint("f_rokas_24.Id2", "f_rokas_24", Rectangle(-716.14514, -217.63432, 9999));

		// 'Dandel' GenType 628 Spawn Points
		AddSpawnPoint("f_rokas_24.Id3", "f_rokas_24", Rectangle(-48.488506, 1338.2025, 9999));

		// 'Tontus' GenType 631 Spawn Points
		AddSpawnPoint("f_rokas_24.Id4", "f_rokas_24", Rectangle(-213.81676, -612.3331, 200));
		AddSpawnPoint("f_rokas_24.Id4", "f_rokas_24", Rectangle(-633.3946, 68.81155, 200));
		AddSpawnPoint("f_rokas_24.Id4", "f_rokas_24", Rectangle(-967.138, -737.1952, 200));
		AddSpawnPoint("f_rokas_24.Id4", "f_rokas_24", Rectangle(-779.95654, -368.1134, 200));
		AddSpawnPoint("f_rokas_24.Id4", "f_rokas_24", Rectangle(-80.76819, -111.006, 200));
		AddSpawnPoint("f_rokas_24.Id4", "f_rokas_24", Rectangle(-137.54143, -2029.0577, 200));
		AddSpawnPoint("f_rokas_24.Id4", "f_rokas_24", Rectangle(-465.63278, -3324.6436, 200));
		AddSpawnPoint("f_rokas_24.Id4", "f_rokas_24", Rectangle(-476.89355, -2671.3926, 200));

		// 'Pino' GenType 632 Spawn Points
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-230.93312, -1756.1863, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-623.4417, -2666.569, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-251.28525, -2695.6794, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-136.22395, -2115.712, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(294.48502, -125.92965, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-809.5451, -2620.3645, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-486.61465, -2473.1367, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-432.3534, -2892.629, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-247.01787, -2864.771, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-384.45337, -2704.0361, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-376.42682, -2107.804, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-517.22253, -1914.432, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-350.9479, -1727.2378, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(51.584606, -2084.1487, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-26.751713, -1739.575, 25));

		// 'Geppetto' GenType 633 Spawn Points
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-210.08438, -1973.6403, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-486.78247, -3301.728, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-436.0404, -2692.7776, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(982.2972, -922.9892, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(653.93787, -756.099, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(679.744, -314.10574, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-658.8242, -2608.5178, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-571.2404, -2822.336, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-271.83066, -2865.185, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-209.11462, -2641.2627, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-422.36722, -2452.9878, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-895.14185, -2006.4275, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-829.31714, -2184.589, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-632.4444, -1983.4569, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-394.464, -1824.741, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(34.948204, -1837.1277, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(54.260162, -2152.9587, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-102.06416, -2252.9075, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-256.20587, -1682.3555, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-438.11932, -2092.0696, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(791.73724, -1140.6453, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(1210.8862, -877.33167, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(1140.617, -532.3471, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(561.5747, -574.7298, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(720.51556, -983.5102, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(947.3669, -1049.6816, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(962.8267, -476.53836, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(1098.814, -700.1723, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(868.4334, -671.078, 20));

		// 'Dandel' GenType 634 Spawn Points
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-459.0937, -1904.2373, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-19.591354, -1822.6411, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-50.50488, -2170.276, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-736.17065, -2705.5732, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-722.1881, -2635.316, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-542.6788, -2867.0388, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-458.14536, -2591.2473, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-285.67584, -2792.526, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-281.2108, -2641.218, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-120.43071, -2754.42, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-885.2203, -2163.1514, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-253.25346, -2165.9553, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-253.45706, -1638.1163, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-284.98862, -1827.6963, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(106.34071, -2109.64, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-1309.021, -1486.2302, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-1710.6495, -1346.8441, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-1465.5135, -1275.1289, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-1651.9961, -1109.8832, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-1221.6825, -1254.5701, 25));

		// 'Tontus' GenType 701 Spawn Points
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-118.11904, -66.01437, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-57.69225, -356.3601, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-921.33905, -261.1131, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(151.90355, -57.233116, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-401.64062, 12.189072, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-452.12305, -306.11798, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-662.0149, 13.29623, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-582.102, -773.7753, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-267.14105, -631.1138, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-701.7245, -466.14273, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-2123.1626, -294.07675, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-1976.4003, 118.67117, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-1542.1348, -185.35149, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-1527.0303, -175.34155, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-1532.7852, -145.9143, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-2057.3525, -92.3089, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-1786.115, -199.76729, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-1785.9487, -2.4954605, 40));

		// 'Dandel' GenType 706 Spawn Points
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(722.6565, -591.7834, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(1092.6458, -963.3998, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(878.5002, -954.6343, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(985.9741, -488.19855, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(1113.1932, -654.81604, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(665.8417, -847.764, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(743.5269, -348.3849, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(754.5592, -1174.1998, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(498.58566, -681.4946, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(1256.3411, -847.28864, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(900.4066, -0.26140213, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(931.1891, -829.3478, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(738.9697, -749.75903, 30));
	}
}
