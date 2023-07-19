//--- Melia Script -----------------------------------------------------------
// f_maple_25_3
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Lhadar Forest' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FMaple253MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_maple_25_3.Id1", MonsterId.Nacorngfly, 42, 55, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_3.Id2", MonsterId.Nacorngbug, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_3.Id3", MonsterId.Rodeyokel, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_3.Id4", MonsterId.Nacorngbug, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_25_3.Id5", MonsterId.Rodevassal, 1, 1, TimeSpan.FromMilliseconds(1800000), TendencyType.Peaceful);
		AddSpawner("f_maple_25_3.Id6", MonsterId.Rootcrystal_05, 19, 25, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Nacorngfly' GenType 22 Spawn Points
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1397.6571, 589.66516, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1693.7468, 528.1199, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1594.596, 442.42355, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1472.3661, 436.23727, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1538.3607, 650.2391, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1474.7689, 795.51587, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1396.5858, 688.31165, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1308.7935, 618.27985, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1324.5883, 513.1818, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1522.171, 583.98584, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1283.5032, 240.09619, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1094.781, 109.11785, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1042.718, -114.17255, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-797.9588, -229.67351, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-595.37286, -214.58894, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-379.20166, -63.800682, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-556.59503, 176.77724, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-85.857254, 614.2279, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(197.37762, 632.20996, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(47.386703, 774.63055, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(278.85324, 833.10254, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(431.02823, 653.8378, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(464.5857, 842.0612, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(625.1705, 724.1744, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(869.8043, 720.9204, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1098.5695, 682.32556, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1287.6472, 633.6624, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1525.4406, 600.29517, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1340.078, 540.06445, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1240.3097, 697.0324, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-157.19965, 964.5878, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-68.56966, 865.32196, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-346.4576, 1114.8273, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-521.60864, 1065.2593, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-606.3473, 1277.7991, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-645.55853, 1172.935, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(447.1659, -350.16827, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(585.34924, -244.69608, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(429.10867, -243.88852, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(475.93497, -76.43015, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(317.0537, -158.90399, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(192.58917, -197.57841, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(11.590961, -122.33221, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(791.50696, -155.81395, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1051.0765, -184.11029, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1219.9652, -235.85625, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1375.6898, -365.3679, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1299.4502, -83.40658, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1470.679, 44.425995, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1310.1074, -1071.3168, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1452.263, -1091.5781, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1330.0604, -1199.9867, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1279.2253, -937.2659, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-1345.0791, -792.84216, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-955.56195, -805.651, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-815.60455, -1018.2319, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-776.2155, -752.27527, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-648.65265, -911.117, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-639.3964, -1352.1913, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-722.4316, -1483.7494, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-532.1275, -1460.9235, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-436.68286, -792.7642, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-257.52127, -909.1126, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-83.22732, -688.97375, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(18.799099, -942.9553, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(69.3788, -752.4495, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(-90.01791, -550.9235, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(275.4852, -920.89166, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(485.55975, -955.2064, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(364.76718, -726.01337, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(344.26913, -1233.5034, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(209.26974, -1478.9497, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(397.7574, -1427.6448, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(341.88293, -1587.8889, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(548.4322, -1609.9801, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1068.8917, -883.1573, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1248.7899, -893.67004, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1211.1686, -664.0564, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1447.2128, -579.4834, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1414.5392, -814.50336, 30));
		AddSpawnPoint("f_maple_25_3.Id1", "f_maple_25_3", Rectangle(1061.4827, -648.6344, 30));

		// 'Nacorngbug' GenType 23 Spawn Points
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(280.86865, -281.24588, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(138.63745, -185.88545, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(291.8119, -139.20352, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(412.8028, -250.65298, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(582.42474, -126.1067, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(926.71936, -126.37457, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1065.1956, -101.70953, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1124.238, -298.34198, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1212.1907, -75.178734, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1219.2546, -182.08653, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1349.3834, -381.22977, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1374.3235, -394.0093, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1409.9741, -195.8092, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1347.1893, -257.98514, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1234.7117, -292.21228, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1294.0563, -435.23273, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-71.93865, -86.084175, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-948.8724, -287.6929, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-1071.3635, -76.59694, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-881.2719, -106.34582, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-675.0387, -281.73712, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-541.7897, -184.90063, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-503.76334, 64.7118, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-1010.5178, -35.206028, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-1027.6799, 85.58077, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-479.52863, 244.35475, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-378.3664, 428.3023, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-344.4004, -65.32788, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-412.06204, -130.0574, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-651.27264, -89.296425, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1332.6494, -76.82966, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1526.3007, -0.10031509, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1600.433, -39.007244, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1401.0375, 35.999676, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(1406.8804, -25.663506, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(692.3121, -207.253, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-1305.2476, 237.95706, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-1613.25, 441.9669, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-1495.8529, 710.8153, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-1442.646, 494.61734, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-1560.126, 554.4355, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-1654.1998, 525.74115, 40));
		AddSpawnPoint("f_maple_25_3.Id2", "f_maple_25_3", Rectangle(-1670.9606, 374.59088, 40));

		// 'Rodeyokel' GenType 24 Spawn Points
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(-39.90838, 866.0873, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(-576.3392, 1012.8211, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(-621.76843, 1084.083, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(-575.238, 1246.459, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(-426.85327, 1047.5321, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(-188.71465, 987.64844, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(-82.45089, 700.4418, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(149.27762, 856.87604, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(55.545033, 740.0168, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(172.62431, 657.36523, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(392.8572, 861.307, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(358.08878, 734.1731, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(492.62592, 760.0003, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(490.7153, 638.9055, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(685.93414, 755.3896, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(646.411, 655.52814, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(848.8465, 758.2364, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(1053.3359, 659.0492, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(1170.0524, 666.79596, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(1205.005, 528.41284, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(1328.1693, 478.77075, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(1395.9358, 604.2003, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(1428.0452, 495.4124, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(1392.6122, 769.0657, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(-421.19138, 1182.3468, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(-707.46106, 1211.6453, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(-539.3006, 1129.4163, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(32.936474, 591.70416, 40));
		AddSpawnPoint("f_maple_25_3.Id3", "f_maple_25_3", Rectangle(560.53973, 878.64923, 40));

		// 'Nacorngbug' GenType 25 Spawn Points
		AddSpawnPoint("f_maple_25_3.Id4", "f_maple_25_3", Rectangle(-576.67, -11.86, 9999));

		// 'Rodevassal' GenType 31 Spawn Points
		AddSpawnPoint("f_maple_25_3.Id5", "f_maple_25_3", Rectangle(-1536.2421, -1273.2649, 20));

		// 'Rootcrystal_05' GenType 32 Spawn Points
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(1567.29, 645.68, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(1331.57, 709.16, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(957.19, 698.87, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(696.53, 705.37, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(329.15, 826.39, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(65.83, 605.28, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-120.36, 936.35, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-469.03, 1141.62, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-426.63, 296.23, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-486.64, -83.48, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-923.68, 132.7, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-873.38, -296.69, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-1315.99, 266.58, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-1326.34, 571.26, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-1792.35, 537.39, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-880.36, -653.65, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-1378.44, -1134.22, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-866.97, -922.66, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-1636.8, -1288.07, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-686.29, -1589.68, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-638.64, -1248.09, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-350.32, -887.97, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(-11.74, -644.62, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(119.53, -894.25, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(413.06, -1029.12, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(464.4, -1629.05, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(141.28, -1571.04, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(1141.02, -843.33, 15));
		AddSpawnPoint("f_maple_25_3.Id6", "f_maple_25_3", Rectangle(1403.77, -927, 15));
	}
}
