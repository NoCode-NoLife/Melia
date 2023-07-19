//--- Melia Script -----------------------------------------------------------
// f_3cmlake_87
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Barynwell 87 Waters' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class F3Cmlake87MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_3cmlake_87", MonsterId.Humming_Duke, Properties("MHP", 604106, "MINPATK", 8269, "MAXPATK", 10065, "MINMATK", 8269, "MAXMATK", 10065, "DEF", 130268, "MDEF", 130268));
		AddPropertyOverrides("f_3cmlake_87", MonsterId.Mutt, Properties("MHP", 605244, "MINPATK", 8284, "MAXPATK", 10083, "MINMATK", 8284, "MAXMATK", 10083, "DEF", 130950, "MDEF", 130950));
		AddPropertyOverrides("f_3cmlake_87", MonsterId.Beissen, Properties("MHP", 606430, "MINPATK", 8299, "MAXPATK", 10102, "MINMATK", 8299, "MAXMATK", 10102, "DEF", 131660, "MDEF", 131660));
		AddPropertyOverrides("f_3cmlake_87", MonsterId.KindronShooter, Properties("MHP", 607663, "MINPATK", 8315, "MAXPATK", 10121, "MINMATK", 8315, "MAXMATK", 10121, "DEF", 132398, "MDEF", 132398));
		AddPropertyOverrides("f_3cmlake_87", MonsterId.KindronBoor, Properties("MHP", 608940, "MINPATK", 8331, "MAXPATK", 10141, "MINMATK", 8331, "MAXMATK", 10141, "DEF", 133163, "MDEF", 133163));
		AddPropertyOverrides("f_3cmlake_87", MonsterId.Boss_Pbeta, Properties("MHP", 2185563, "MINPATK", 21037, "MAXPATK", 25609, "MINMATK", 21037, "MAXMATK", 25609, "DEF", 337565, "MDEF", 337565));

		// Monster Spawners ---------------------------------

		AddSpawner("f_3cmlake_87.Id1", MonsterId.Humming_Duke, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_87.Id2", MonsterId.Mutt, 13, 17, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_87.Id3", MonsterId.Beissen, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_87.Id4", MonsterId.KindronShooter, 18, 23, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_87.Id5", MonsterId.KindronBoor, 19, 25, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_87.Id6", MonsterId.Rootcrystal_02, 23, 30, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Humming_Duke' GenType 45 Spawn Points
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-305.4452, -1136.1312, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-221.10931, -1291.6437, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-62.100136, -1215.2865, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(140.18382, -1264.8027, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-147.11935, -986.03644, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(41.107227, -1074.1774, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-92.200386, -809.4952, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(196.60732, -940.1962, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(239.61461, -1134.8809, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(371.16757, -1008.3056, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(1092.8729, -640.5129, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(1098.0421, -821.315, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(1313.489, -723.11975, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(1295.4221, -885.4124, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(868.4852, -636.92773, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(485.04486, 668.0528, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(475.15424, 588.1419, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(609.7243, 682.12854, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-75.51522, 1401.3458, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-126.71141, 1241.6509, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(59.395336, 1431.9321, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(105.50375, 1162.7557, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-47.075233, 1278.0077, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-633.1207, 491.11548, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-983.89966, 215.10388, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-703.6714, 254.77788, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-742.20184, -11.343126, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-972.5297, 20.172295, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-170.62006, 247.2081, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-299.9283, 516.9346, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-172.29457, 670.808, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-47.644028, 909.74146, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(42.219673, 686.00244, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(285.61563, 502.8444, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(166.4773, 348.49142, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(23.103281, 234.43779, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-109.58185, 498.51096, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(86.767365, 452.66144, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(-426.32202, 1115.153, 45));
		AddSpawnPoint("f_3cmlake_87.Id1", "f_3cmlake_87", Rectangle(637.9391, -676.96014, 45));

		// 'Mutt' GenType 47 Spawn Points
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-839.47986, -73.70826, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-835.71027, 141.05803, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-825.5819, 367.09088, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-55.405823, 1053.8296, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-242.70445, 1300.1237, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-34.325237, 1513.848, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-39.952503, 1226.7089, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(301.72504, 1178.3252, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(1027.0181, 1002.1262, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(750.7777, 1279.9689, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(1055.4357, 1286.2675, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-617.12756, 1172.8804, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-1024.2788, 1390.1663, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-1108.2527, 1134.7587, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-1213.9651, 786.5619, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-773.01624, 756.72064, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-766.21204, 976.58014, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-1187.7047, 969.92444, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-1018.462, 859.1649, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-151.48708, 1859.5364, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-110.42467, 2190.7205, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(100.15769, 2122.7644, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(97.994965, 1882.5356, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-25.138973, 2036.0474, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(251.80153, 2393.9385, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(503.01367, 1417.4034, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(782.0314, 1080.7822, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(933.4886, 1306.1709, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(926.67035, 1162.3254, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-59.61113, 1323.0397, 45));
		AddSpawnPoint("f_3cmlake_87.Id2", "f_3cmlake_87", Rectangle(-881.5664, 873.1085, 45));

		// 'Beissen' GenType 49 Spawn Points
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(-266.68268, 2303.2722, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(-26.242762, 1875.2926, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(-1073.6205, 1258.6797, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(-63.92641, 1405.6013, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(30.603844, 1178.4459, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(-210.92729, 1127.2219, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(-1080.1061, 734.9407, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(-770.6749, 861.3819, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(349.46127, 1367.9957, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(815.6153, 1019.1182, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(927.2152, 1225.7197, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(13.295009, 2239.088, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(-1001.6341, 79.52759, 45));
		AddSpawnPoint("f_3cmlake_87.Id3", "f_3cmlake_87", Rectangle(-750.8816, 260.173, 45));

		// 'KindronShooter' GenType 51 Spawn Points
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(-1170.5366, -979.25244, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(-1010.0494, -842.4607, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(-843.1714, -1160.7886, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(-739.31384, -939.159, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(-689.97986, -527.41205, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(1147.0272, -889.8505, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(1103.551, -675.33936, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(1322.8845, -805.7669, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(662.9584, -683.1457, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(-90.93379, -912.9339, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(347.65988, -998.091, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(-256.9731, -1222.4408, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(72.17376, -1115.5403, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(128.17525, -1286.1588, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(555.0063, -344.4006, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(703.2439, -90.64871, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(592.45245, 200.13377, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(836.0038, 129.2025, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(760.7901, 451.95493, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(-183.96242, 311.4662, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(137.13242, 303.4311, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(-184.03404, 624.5853, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(193.00075, 604.0387, 45));
		AddSpawnPoint("f_3cmlake_87.Id4", "f_3cmlake_87", Rectangle(-56.867096, 60.22417, 45));

		// 'KindronBoor' GenType 53 Spawn Points
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-33.867577, -1295.5042, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-110.1735, -1063.0607, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(151.18393, -975.26306, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(264.18167, -1169.9425, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-88.798294, -741.32947, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-935.0508, -571.99805, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-1018.0156, -1089.2664, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-1150.1991, -851.4315, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-758.7636, -993.09015, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-488.8661, -412.76465, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(805.3126, -734.3268, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(1361.0521, -646.9531, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(1185.7432, -850.14026, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(817.4826, -3.5516481, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(606.22894, 47.179424, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(725.41406, 245.09055, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(656.12665, 639.3582, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-40.314682, 238.46492, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-240.71547, 495.3003, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(249.02127, 423.16324, 45));
		AddSpawnPoint("f_3cmlake_87.Id5", "f_3cmlake_87", Rectangle(-11.169237, 703.3297, 45));

		// 'Rootcrystal_02' GenType 56 Spawn Points
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-139.65927, -1713.0007, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-151.3441, -1282.4756, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(168.9552, -1087.5052, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-124.65905, -608.81104, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-29.827635, -162.94824, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(451.75342, -329.98605, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(635.0537, -719.4188, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(1103.9578, -710.03705, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(1376.1481, -884.6916, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-450.6396, -380.90384, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-925.79803, -529.4195, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-1193.3481, -904.286, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-914.9195, -1143.645, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-12.595631, 315.0627, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-594.1941, 478.4986, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-930.9022, 340.05902, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-1069.6483, 80.64974, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-734.71564, -50.11268, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(26.812595, 665.1641, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(420.53204, 682.5058, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(664.3171, 279.46826, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(836.63354, 23.749134, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-21.412579, 1066.4329, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(91.36441, 1423.6698, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-240.70541, 1342.3567, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-574.4872, 1122.9258, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-741.5371, 934.75073, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-1086.9281, 1322.446, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-1210.7363, 828.4004, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(308.8825, 1334.5912, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(823.6428, 1356.4265, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(961.7927, 1084.4325, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-75.72436, 1809.3674, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(59.911945, 2108.2458, 200));
		AddSpawnPoint("f_3cmlake_87.Id6", "f_3cmlake_87", Rectangle(-781.5827, -856.14667, 200));
	}
}
