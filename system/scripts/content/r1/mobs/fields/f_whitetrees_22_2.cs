//--- Melia Script -----------------------------------------------------------
// f_whitetrees_22_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Tekel Shelter' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FWhitetrees222MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_whitetrees_22_2.Id1", MonsterId.Rootcrystal_01, 12, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_2.Id2", MonsterId.Yakyak, 18, 24, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_2.Id3", MonsterId.Yak_Magician, 18, 24, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_2.Id4", MonsterId.Yak_Warrior, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_whitetrees_22_2.Id5", MonsterId.Yak_Druid, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_2.Id6", MonsterId.Hohen_Barkle_Black, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_whitetrees_22_2.Id7", MonsterId.Hohen_Ritter_Black, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 14 Spawn Points
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(23.892302, -486.4325, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(-559.91595, -1104.9387, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(-86.72401, -1021.1157, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(-243.21776, -1515.7671, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(289.16553, -1041.8911, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(400.82288, -1525.5568, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(1056.345, -1093.7655, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(1361.6931, -876.6885, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(139.85358, -82.38066, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(77.14155, 466.7312, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(-384.26886, 544.1305, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(-490.59082, 1059.8574, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(391.9314, 1288.6122, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(880.0609, 620.5816, 10));
		AddSpawnPoint("f_whitetrees_22_2.Id1", "f_whitetrees_22_2", Rectangle(1080.5741, 169.26852, 10));

		// 'Yakyak' GenType 42 Spawn Points
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(265.81097, 1425.2349, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(407.3732, 1509.6667, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(384.44678, 1396.9448, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(522.6968, 1374.1909, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(561.1624, 1258.052, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(433.78836, 1191.2582, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(294.18237, 1202.7485, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(238.5705, 1295.4049, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-387.45572, 1126.6355, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-339.70163, 1046.427, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-779.6827, 1061.3152, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-670.19403, 1050.9845, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-807.7651, 948.0584, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-706.85394, 862.4574, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-576.60126, 808.66693, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-705.66956, 1165.1565, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-471.93283, 619.1973, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-454.6732, 467.47745, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-292.5938, 459.0091, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(-289.57687, 608.7099, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(997.3797, 582.6924, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(1019.4185, 466.77545, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(1122.1748, 576.91943, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id2", "f_whitetrees_22_2", Rectangle(1053.0997, 758.8409, 40));

		// 'Yak_Magician' GenType 43 Spawn Points
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(16.850494, 1297.3308, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(119.47845, 1236.7268, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(46.51452, 1132.6229, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(185.81737, 1105.7161, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(156.68785, 1378.1027, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(270.8069, 1534.1897, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(359.105, 1626.0739, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(361.369, 1093.54, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-595.7625, 928.1443, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-518.49365, 855.6575, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-489.85287, 964.5551, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-377.25287, 915.5054, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-567.36395, 1172.2854, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-241.80313, 1181.6328, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-272.87448, 973.42175, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-133.27386, 1035.879, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-187.93512, 575.7614, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-110.54195, 679.96277, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(116.17638, -483.67584, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(35.97109, 540.53265, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-219.56926, -432.8879, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(-90.96248, -478.72232, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(274.4841, -481.93207, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id3", "f_whitetrees_22_2", Rectangle(397.88013, -397.9857, 40));

		// 'Yak_Warrior' GenType 44 Spawn Points
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(139.37358, 586.75323, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(-44.56436, 318.29736, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(45.611015, 250.63751, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(234.16876, 518.3563, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(139.5261, 307.82318, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(122.70179, -231.01666, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(401.78812, 612.0765, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(235.36551, -186.49773, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(16.816097, -176.82816, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(548.61725, 615.78766, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(644.1687, 727.55554, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(629.59863, 521.64197, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(734.53217, 810.00586, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(804.7553, 710.5944, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(923.902, 734.97015, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(720.2328, 453.8089, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(765.8997, 529.4291, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(899.01624, 532.59424, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(906.02765, 444.95306, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(695.0214, 626.0423, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(-177.1435, -314.7908, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(48.067554, -364.07486, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(154.83902, -368.77118, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(364.27286, -297.01144, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(31.394688, 516.04175, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(876.71985, 628.97943, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(99.45753, -71.01497, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(120.80423, 171.79192, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(199.44968, 410.36545, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(-183.46375, 570.9029, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(-287.8657, 498.54614, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(-275.34137, 602.97736, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(157.166, 467.4363, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(1023.356, 676.20874, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id4", "f_whitetrees_22_2", Rectangle(1068.4813, 570.66754, 40));

		// 'Yak_Druid' GenType 45 Spawn Points
		AddSpawnPoint("f_whitetrees_22_2.Id5", "f_whitetrees_22_2", Rectangle(722.54346, 711.90924, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id5", "f_whitetrees_22_2", Rectangle(1059.7983, 659.719, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id5", "f_whitetrees_22_2", Rectangle(99.0084, 423.8185, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id5", "f_whitetrees_22_2", Rectangle(-361.57947, 533.4554, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id5", "f_whitetrees_22_2", Rectangle(-547.1771, 1026.6467, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id5", "f_whitetrees_22_2", Rectangle(-45.031883, -309.67932, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id5", "f_whitetrees_22_2", Rectangle(249.90248, -307.32788, 40));

		// 'Hohen_Barkle_Black' GenType 46 Spawn Points
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(814.27747, 195.63704, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1211.2015, 363.45532, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(931.31885, 54.217896, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1351.6055, 178.0959, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(897.2955, 134.6257, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(971.34033, 242.93587, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1128.5901, 293.887, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1208.0532, 232.71019, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(961.0994, -650.23944, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1151.9883, -694.4319, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1066.9017, -865.99164, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1279.7386, -794.70685, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1209.9337, -965.267, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1352.6239, -1050.9338, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1429.0825, -912.1024, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(779.5422, -1240.4098, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(979.11035, -1230.4832, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(268.2413, -991.4337, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(381.84067, -957.3306, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(444.8041, -1067.969, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(245.48027, -1215.1925, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(-6.988259, -1448.8777, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(201.50558, -1616.748, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(-159.25662, -1559.6138, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1089.0789, -992.008, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1060.5105, -1141.8657, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(362.2638, -1496.7865, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(114.76849, -1561.8346, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(40.57426, -1644.1921, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1181.3337, 139.80002, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(847.29974, 88.69331, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1128.5724, 190.62169, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(1247.7073, -851.5128, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(273.10257, -1460.1022, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id6", "f_whitetrees_22_2", Rectangle(43.41181, -1538.3307, 40));

		// 'Hohen_Ritter_Black' GenType 47 Spawn Points
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-189.38681, -689.5045, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-53.236923, -881.03577, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-206.3198, -991.96204, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-193.30217, -1122.8223, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-587.596, -1010.3234, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-650.5559, -1144.8201, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-537.97363, -1239.652, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-451.6643, -1031.2003, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-332.42908, -1085.3141, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-357.4921, -1440.157, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-86.05537, -1460.3668, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-27.07647, -1588.7601, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(88.320045, -1544.2625, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(278.40192, -1520.5292, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(123.57137, -1392.8566, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(576.0024, -1406.7762, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(880.3736, -1301.3877, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(1096.5372, -984.31537, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(1211.0171, -865.66064, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(1062.9167, -758.58746, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(1217.162, 136.42297, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(998.09753, 174.6156, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(1074.3446, 99.746506, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(273.99945, -1100.7402, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-42.03868, -1021.6862, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(-176.97054, -1534.317, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(215.93584, -1593.4368, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(229.53206, -1287.911, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(390.699, -958.1054, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(283.08194, -896.32, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(767.11005, -1246.1029, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(1004.8638, -1126.7185, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(1004.7878, -930.7605, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(1048.0839, -635.2026, 40));
		AddSpawnPoint("f_whitetrees_22_2.Id7", "f_whitetrees_22_2", Rectangle(1299.8914, -793.0979, 40));
	}
}
