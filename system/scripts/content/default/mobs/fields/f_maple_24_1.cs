//--- Melia Script -----------------------------------------------------------
// f_maple_24_1
//
//--- Description -----------------------------------------------------------
// Sets up the f_maple_24_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FMaple241MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_maple_24_1", MonsterId.Grievous_Wheel_Red, Properties("MHP", 730917, "MINPATK", 9900, "MAXPATK", 12070, "MINMATK", 9900, "MAXMATK", 12070, "DEF", 213226, "MDEF", 213226));
		AddPropertyOverrides("f_maple_24_1", MonsterId.Rudas_Elavine, Properties("MHP", 733610, "MINPATK", 9935, "MAXPATK", 12112, "MINMATK", 9935, "MAXMATK", 12112, "DEF", 215150, "MDEF", 215150));
		AddPropertyOverrides("f_maple_24_1", MonsterId.Delione, Properties("MHP", 736341, "MINPATK", 9970, "MAXPATK", 12155, "MINMATK", 9970, "MAXMATK", 12155, "DEF", 217102, "MDEF", 217102));
		AddPropertyOverrides("f_maple_24_1", MonsterId.Cloverin, Properties("MHP", 739110, "MINPATK", 10005, "MAXPATK", 12199, "MINMATK", 10005, "MAXMATK", 12199, "DEF", 219081, "MDEF", 219081));

		// Monster Spawners --------------------------------

		AddSpawner("f_maple_24_1.Id1", MonsterId.Grievous_Wheel_Red, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_24_1.Id2", MonsterId.Rudas_Elavine, 80, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_24_1.Id3", MonsterId.Delione, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_24_1.Id4", MonsterId.Cloverin, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_24_1.Id5", MonsterId.Rootcrystal_01, 25, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_maple_24_1.Id6", MonsterId.Cloverin, 20, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);
		AddSpawner("f_maple_24_1.Id7", MonsterId.Delione, 15, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);
		AddSpawner("f_maple_24_1.Id8", MonsterId.Rudas_Elavine, 12, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Grievous_Wheel_Red Spawn Points
		AddSpawnPoint( "f_maple_24_1.Id1", "f_maple_24_1", Spot(-1335.2435, -569.4602, 20));
		AddSpawnPoint( "f_maple_24_1.Id1", "f_maple_24_1", Spot(-1290.2433, -753.61334, 20));
		AddSpawnPoint( "f_maple_24_1.Id1", "f_maple_24_1", Spot(-1225.5337, -655.222, 20));
		AddSpawnPoint( "f_maple_24_1.Id1", "f_maple_24_1", Spot(-1093.29, -618.70386, 20));
		AddSpawnPoint( "f_maple_24_1.Id1", "f_maple_24_1", Spot(-1142.3176, -776.4562, 20));
		AddSpawnPoint( "f_maple_24_1.Id1", "f_maple_24_1", Spot(-1126.1837, -911.9281, 20));
		AddSpawnPoint( "f_maple_24_1.Id1", "f_maple_24_1", Spot(-1037.1945, -867.48376, 20));
		AddSpawnPoint( "f_maple_24_1.Id1", "f_maple_24_1", Spot(-983.58466, -942.53796, 20));
		AddSpawnPoint( "f_maple_24_1.Id1", "f_maple_24_1", Spot(-840.9615, -892.8726, 20));
		AddSpawnPoint( "f_maple_24_1.Id1", "f_maple_24_1", Spot(-1097.151, -495.33536, 20));
		AddSpawnPoint( "f_maple_24_1.Id1", "f_maple_24_1", Spot(569.84045, 1279.1827, 20));
		AddSpawnPoint( "f_maple_24_1.Id1", "f_maple_24_1", Spot(439.67596, 1382.4348, 20));
		AddSpawnPoint( "f_maple_24_1.Id1", "f_maple_24_1", Spot(588.1686, 1502.1611, 20));
		AddSpawnPoint( "f_maple_24_1.Id1", "f_maple_24_1", Spot(542.30615, 1582.7471, 20));
		AddSpawnPoint( "f_maple_24_1.Id1", "f_maple_24_1", Spot(599.32605, 1401.0828, 20));
		AddSpawnPoint( "f_maple_24_1.Id1", "f_maple_24_1", Spot(704.5289, 1325.4609, 20));
		AddSpawnPoint( "f_maple_24_1.Id1", "f_maple_24_1", Spot(799.51965, 1346.975, 20));
		AddSpawnPoint( "f_maple_24_1.Id1", "f_maple_24_1", Spot(925.6645, 1288.1843, 20));
		AddSpawnPoint( "f_maple_24_1.Id1", "f_maple_24_1", Spot(1030.4244, 1256.2026, 20));
		AddSpawnPoint( "f_maple_24_1.Id1", "f_maple_24_1", Spot(1107.407, 1339.0697, 20));

		// Rudas_Elavine Spawn Points
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-1268.9982, -605.894, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-1148.5037, -721.6933, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-1184.1243, -907.238, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-900.956, -904.36554, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-572.8179, -859.83344, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-489.95874, -1037.2354, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-1143.8779, 797.6234, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-1297.188, 680.3004, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-172.419, -972.66583, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-37.755596, -859.5054, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-1045.7631, 599.12946, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(129.02254, -915.5587, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(270.9735, -917.8159, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-770.78406, 1269.3054, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(470.07022, -831.44104, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-721.189, 1166.9384, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(465.6361, -949.1441, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(594.79425, -898.57416, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(765.20526, -916.6154, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-445.6322, 921.3832, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1057.6433, -838.549, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1128.1768, -796.84045, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1160.1136, -523.0313, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1149.4316, -331.003, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1300.4347, -483.0002, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1457.835, -392.67517, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1495.4702, -180.96622, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1729.4961, -181.7103, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1780.4746, -229.47948, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1355.2119, -104.27586, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1219.6088, -91.6283, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1130.4192, -110.96966, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-355.78278, 783.0542, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1238.6969, 53.35948, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1199.3204, 170.45604, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1205.3643, 307.12408, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1267.1161, 420.48514, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1160.6471, 392.88663, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1250.6, 303.4083, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1271.7366, 561.26764, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1229.5704, 698.47034, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1208.4115, 545.83923, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1054.948, 517.80084, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(996.52625, 609.53125, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1217.1725, 823.4888, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1271.1436, 728.2092, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1087.1267, 790.4883, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1220.071, 1052.7494, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1150.222, 1210.3531, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1338.0637, 1275.4026, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(1039.8302, 1379.5933, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(677.2463, 1281.2823, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(558.7989, 1445.1686, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(863.7486, 1298.8008, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(817.8882, 684.3832, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(722.55225, 664.59644, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(627.4301, 773.61194, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-139.11082, 396.13306, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-207.50786, 581.3306, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(255.46576, 663.15234, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(242.7316, 538.74774, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(137.82932, 593.95435, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(26.768433, 464.76218, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(135.21274, 359.97, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(283.3974, 285.86206, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(376.66907, 300.87515, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-857.8015, -173.22542, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-1006.1124, -8.922676, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-773.38696, -57.71411, 20));
		AddSpawnPoint( "f_maple_24_1.Id2", "f_maple_24_1", Spot(-702.84503, 68.39212, 20));

		// Delione Spawn Points
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(970.8817, -800.4553, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(1115.7118, -726.5475, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(827.1701, -860.27124, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(561.16125, -821.9459, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(494.16785, -696.95825, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(367.6153, -748.8164, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(359.03067, -855.01855, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(439.81894, -997.2107, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-1.9165668, -1025.2363, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(15.63795, -909.3394, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-91.1523, -948.1828, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-168.47208, -849.6615, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-275.7341, -916.78564, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-345.0708, -894.9543, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-301.34894, -1017.5422, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-497.024, -958.6254, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-589.45355, -908.1338, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-934.96295, -148.88812, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-827.0523, -78.10622, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-689.31854, -132.46034, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-854.68475, -251.62698, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-988.1986, -72.47731, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-1032.4226, 107.59598, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-954.8712, 184.49132, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-838.8363, 71.46567, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-750.2886, 22.047766, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-921.2421, 64.52242, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-791.2739, 193.01407, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-1006.2532, 342.27176, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-966.2948, 484.80682, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-1067.049, 498.69833, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-956.59326, 624.16077, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-1132.374, 693.73663, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-1203.0605, 661.59924, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-1225.2456, 865.4612, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-1301.4441, 865.3695, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-1396.7601, 735.4211, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-1431.4188, 672.00397, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-1128.8263, 862.1774, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-1258.4467, 760.1327, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-643.0619, 261.2985, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-402.00742, 383.0085, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-296.68088, 499.3106, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-309.5773, 388.439, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-156.38998, 491.36945, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-412.06168, 675.6796, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-233.00282, 729.254, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-244.10999, 848.79004, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(-27.245453, 909.8488, 20));
		AddSpawnPoint( "f_maple_24_1.Id3", "f_maple_24_1", Spot(12.273661, 778.2866, 20));

		// Cloverin Spawn Points
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(-885.08167, 1180.9938, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(-865.5317, 1279.0093, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(-775.0912, 1215.5607, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(-770.1459, 1121.807, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(1243.1504, 750.38, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(1062.828, 695.528, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(-726.78986, 1361.0864, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(-702.6305, 1418.6969, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(-590.6443, 1116.8513, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(1025.6074, 565.2158, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(1184.1444, 327.34198, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(-371.94736, 887.49243, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(-444.46216, 652.5481, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(-291.77826, 731.5314, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(-204.62253, 429.23718, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(-48.13673, 317.33176, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(-115.23464, 254.91924, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(4.7627125, 256.1119, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(106.2588, 406.66263, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(222.93771, 326.16537, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(267.14316, 460.02765, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(29.497131, 709.0791, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(49.976074, 603.6182, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(38.84487, 884.0135, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(-106.37225, 908.59406, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(-14.04215, 1034.9458, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(342.65952, 693.34204, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(149.27823, 701.2534, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(473.0131, 729.75665, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(1268.5448, -417.3298, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(1155.6569, -397.19336, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(1140.4944, -210.60867, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(1420.9962, -129.94734, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(1415.5295, -196.86533, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(1240.6357, 453.6495, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(1714.0181, -142.02457, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(1288.4473, -36.656826, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(1185.8488, -24.710257, 20));
		AddSpawnPoint( "f_maple_24_1.Id4", "f_maple_24_1", Spot(1211.4617, 893.58777, 20));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(-974.5617, 594.5404, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(-1272.2811, 801.7412, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(-955.6224, 242.25713, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(-810.39294, -49.39796, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(-943.2078, -375.05212, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(-1130.4156, -891.21265, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(-730.22296, -878.80273, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(-336.0391, -943.3128, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(68.69804, -940.6865, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(485.32043, -852.2884, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(902.65436, -858.95917, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(1160.9706, -571.05383, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(1431.8517, -290.98447, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(1238.4954, -56.344635, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(1223.2845, 356.74722, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(1183.9828, 723.4393, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(1221.3198, 1129.576, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(912.2424, 1341.9667, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(578.3806, 1386.576, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(822.04706, 601.86456, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(419.54962, 701.28485, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(81.24063, 442.74677, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(-8.729477, 821.8772, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(-454.44568, 965.10913, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(-721.37634, 1231.5256, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(416.06757, 232.50563, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(567.1173, -100.7143, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(-297.70935, 546.96936, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(-533.83057, 258.36957, 200));
		AddSpawnPoint( "f_maple_24_1.Id5", "f_maple_24_1", Spot(-1213.9221, -586.4412, 200));

		// Cloverin Spawn Points
		AddSpawnPoint( "f_maple_24_1.Id6", "f_maple_24_1", Spot(-548.9226, -985.1871, 20));
		AddSpawnPoint( "f_maple_24_1.Id6", "f_maple_24_1", Spot(-525.35974, -892.82605, 20));
		AddSpawnPoint( "f_maple_24_1.Id6", "f_maple_24_1", Spot(-509.39154, -807.09644, 20));
		AddSpawnPoint( "f_maple_24_1.Id6", "f_maple_24_1", Spot(-436.41202, -996.1609, 20));
		AddSpawnPoint( "f_maple_24_1.Id6", "f_maple_24_1", Spot(-432.50732, -907.9921, 20));
		AddSpawnPoint( "f_maple_24_1.Id6", "f_maple_24_1", Spot(-446.1143, -1076.6309, 20));
		AddSpawnPoint( "f_maple_24_1.Id6", "f_maple_24_1", Spot(-372.8388, -1035.1351, 20));
		AddSpawnPoint( "f_maple_24_1.Id6", "f_maple_24_1", Spot(-341.26007, -964.7004, 20));
		AddSpawnPoint( "f_maple_24_1.Id6", "f_maple_24_1", Spot(-317.3509, -835.19464, 20));
		AddSpawnPoint( "f_maple_24_1.Id6", "f_maple_24_1", Spot(-290.28607, -970.0122, 20));
		AddSpawnPoint( "f_maple_24_1.Id6", "f_maple_24_1", Spot(-215.90605, -1000.886, 20));
		AddSpawnPoint( "f_maple_24_1.Id6", "f_maple_24_1", Spot(-176.79346, -901.5369, 20));
		AddSpawnPoint( "f_maple_24_1.Id6", "f_maple_24_1", Spot(-124.11702, -1038.8362, 20));
		AddSpawnPoint( "f_maple_24_1.Id6", "f_maple_24_1", Spot(-92.9456, -814.7133, 20));
		AddSpawnPoint( "f_maple_24_1.Id6", "f_maple_24_1", Spot(-96.77649, -1002.515, 20));
		AddSpawnPoint( "f_maple_24_1.Id6", "f_maple_24_1", Spot(-49.52516, -917.7499, 20));
		AddSpawnPoint( "f_maple_24_1.Id6", "f_maple_24_1", Spot(-23.153717, -1056.1956, 20));
		AddSpawnPoint( "f_maple_24_1.Id6", "f_maple_24_1", Spot(38.71438, -974.6556, 20));
		AddSpawnPoint( "f_maple_24_1.Id6", "f_maple_24_1", Spot(65.34323, -870.78876, 20));
		AddSpawnPoint( "f_maple_24_1.Id6", "f_maple_24_1", Spot(-108.51923, -887.7838, 20));

		// Delione Spawn Points
		AddSpawnPoint( "f_maple_24_1.Id7", "f_maple_24_1", Spot(204.47969, -946.1294, 20));
		AddSpawnPoint( "f_maple_24_1.Id7", "f_maple_24_1", Spot(254.90092, -875.83527, 20));
		AddSpawnPoint( "f_maple_24_1.Id7", "f_maple_24_1", Spot(276.71182, -970.5583, 20));
		AddSpawnPoint( "f_maple_24_1.Id7", "f_maple_24_1", Spot(331.54016, -1001.0027, 20));
		AddSpawnPoint( "f_maple_24_1.Id7", "f_maple_24_1", Spot(343.13458, -919.31616, 20));
		AddSpawnPoint( "f_maple_24_1.Id7", "f_maple_24_1", Spot(405.92242, -890.4445, 20));
		AddSpawnPoint( "f_maple_24_1.Id7", "f_maple_24_1", Spot(425.31763, -802.3071, 20));
		AddSpawnPoint( "f_maple_24_1.Id7", "f_maple_24_1", Spot(411.04343, -678.7229, 20));
		AddSpawnPoint( "f_maple_24_1.Id7", "f_maple_24_1", Spot(526.314, -740.60956, 20));
		AddSpawnPoint( "f_maple_24_1.Id7", "f_maple_24_1", Spot(509.9495, -808.1414, 20));
		AddSpawnPoint( "f_maple_24_1.Id7", "f_maple_24_1", Spot(535.89124, -951.90564, 20));
		AddSpawnPoint( "f_maple_24_1.Id7", "f_maple_24_1", Spot(558.79895, -892.908, 20));
		AddSpawnPoint( "f_maple_24_1.Id7", "f_maple_24_1", Spot(645.9054, -922.7156, 20));
		AddSpawnPoint( "f_maple_24_1.Id7", "f_maple_24_1", Spot(628.42676, -826.5556, 20));
		AddSpawnPoint( "f_maple_24_1.Id7", "f_maple_24_1", Spot(739.00867, -856.2993, 20));

		// Rudas_Elavine Spawn Points
		AddSpawnPoint( "f_maple_24_1.Id8", "f_maple_24_1", Spot(878.5434, -890.8528, 20));
		AddSpawnPoint( "f_maple_24_1.Id8", "f_maple_24_1", Spot(886.64, -807.8839, 20));
		AddSpawnPoint( "f_maple_24_1.Id8", "f_maple_24_1", Spot(929.2945, -850.9992, 20));
		AddSpawnPoint( "f_maple_24_1.Id8", "f_maple_24_1", Spot(988.7649, -841.4532, 20));
		AddSpawnPoint( "f_maple_24_1.Id8", "f_maple_24_1", Spot(1028.1185, -777.415, 20));
		AddSpawnPoint( "f_maple_24_1.Id8", "f_maple_24_1", Spot(1087.2545, -898.30634, 20));
		AddSpawnPoint( "f_maple_24_1.Id8", "f_maple_24_1", Spot(1136.5648, -847.38635, 20));
		AddSpawnPoint( "f_maple_24_1.Id8", "f_maple_24_1", Spot(1092.5885, -766.9049, 20));
		AddSpawnPoint( "f_maple_24_1.Id8", "f_maple_24_1", Spot(1096.5834, -809.7657, 20));
		AddSpawnPoint( "f_maple_24_1.Id8", "f_maple_24_1", Spot(716.1533, -884.4865, 20));
		AddSpawnPoint( "f_maple_24_1.Id8", "f_maple_24_1", Spot(424.74768, -954.7047, 20));
		AddSpawnPoint( "f_maple_24_1.Id8", "f_maple_24_1", Spot(679.5964, -853.37286, 20));

	}
}
