//--- Melia Script -----------------------------------------------------------
// d_fantasylibrary_48_2
//
//--- Description -----------------------------------------------------------
// Sets up the d_fantasylibrary_48_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFantasylibrary482MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_fantasylibrary_48_2", MonsterId.Levada, Properties("MHP", 534014, "MINPATK", 7368, "MAXPATK", 8957, "MINMATK", 7368, "MAXMATK", 8957, "DEF", 94757, "MDEF", 94757));
		AddPropertyOverrides("d_fantasylibrary_48_2", MonsterId.Marte_Book, Properties("MHP", 536103, "MINPATK", 7395, "MAXPATK", 8990, "MINMATK", 7395, "MAXMATK", 8990, "DEF", 95790, "MDEF", 95790));
		AddPropertyOverrides("d_fantasylibrary_48_2", MonsterId.Aclis_Angel, Properties("MHP", 538326, "MINPATK", 7423, "MAXPATK", 9025, "MINMATK", 7423, "MAXMATK", 9025, "DEF", 96890, "MDEF", 96890));
		AddPropertyOverrides("d_fantasylibrary_48_2", MonsterId.Luna_Angel, Properties("MHP", 540677, "MINPATK", 7454, "MAXPATK", 9062, "MINMATK", 7454, "MAXMATK", 9062, "DEF", 98052, "MDEF", 98052));

		// Monster Spawners --------------------------------

		AddSpawner("d_fantasylibrary_48_2.Id1", MonsterId.Rootcrystal_03, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_2.Id2", MonsterId.Levada, 60, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_2.Id3", MonsterId.Marte_Book, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_2.Id4", MonsterId.Aclis_Angel, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_2.Id5", MonsterId.Luna_Angel, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-70.96192, -912.533, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-155.2776, -668.3207, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(97.47767, -697.5531, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(6.2911816, -781.4941, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-150.67712, -235.11691, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(86.87434, -233.9829, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-828.4747, -133.20898, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-778.9827, -326.1649, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-530.2745, -180.12325, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-1317.2214, 368.72226, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-1450.717, 588.1688, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-1250.6185, 625.1411, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-1467.4485, 419.50104, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-725.63074, 293.5204, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-869.2427, 521.8553, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-673.6422, 601.9028, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-526.78546, 479.4915, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-709.6604, 461.72977, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(60.040237, 475.96124, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(121.64323, 820.0566, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(220.34973, 807.10187, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(466.86877, 645.04474, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(399.6458, 479.95435, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(900.2185, 519.7396, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(776.0543, 597.3585, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(883.17365, 727.32153, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(1000.3585, 704.9067, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(258.05322, 1358.8492, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(77.05518, 1301.4846, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(120.52112, 1501.7579, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(363.2575, 1468.4702, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-637.8186, 1801.4354, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-662.7879, 1558.08, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-551.1934, 1417.5342, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-367.16147, 1491.4899, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-384.01114, 1812.6871, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(-550.9521, 1664.0068, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(883.0411, -394.78387, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(962.8848, -117.85939, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(1044.9413, -333.63696, 100));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Spot(1450.4387, -306.6712, 100));

		// Levada Spawn Points
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(822.3179, 663.3762, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(820.3102, 556.54456, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(941.8388, 557.52124, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(919.64514, 750.90576, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(1339.0513, -199.84023, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(1358.0483, -333.32077, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(1452.5996, -327.31613, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(1566.2172, -254.73404, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-140.66412, -263.55096, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-72.51198, -157.80635, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(39.429714, -217.65445, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(49.868378, -114.39581, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(114.35773, 1460.5845, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(157.23775, 1357.9518, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(268.8048, 1321.6941, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(391.5023, 1451.2675, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(786.2051, -166.46565, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(845.4296, -364.9097, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(958.2307, -305.2716, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(1072.1633, -403.46954, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(996.2415, -130.02591, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-136.73123, -650.9275, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-78.80372, -749.3242, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(35.799103, -749.93207, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-131.48775, -861.062, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(32.259335, -862.52527, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-820.3349, -97.07361, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-634.23566, -160.17986, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-759.558, -211.05145, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-771.8323, -345.28622, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-636.82184, -306.2661, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-1441.9326, 575.0445, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-1513.0854, 458.17023, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-1412.7432, 426.96985, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-1263.5958, 369.58868, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-1258.4388, 551.61945, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-867.5617, 517.7297, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-890.37, 381.1024, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-752.9416, 325.9573, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-608.8672, 396.67755, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-575.4143, 535.8687, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-692.6803, 600.2355, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-715.90875, 1472.2393, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-664.7269, 1573.5272, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-616.36707, 1487.9996, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-530.88434, 1563.0027, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-470.51453, 1468.0327, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-643.5997, 1819.853, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-607.5745, 1736.8436, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-536.13794, 1812.8721, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-370.14767, 1779.8011, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-45.481243, 707.1347, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-2.7178307, 886.63885, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(117.28342, 863.5361, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(-16.839767, 534.955, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(125.13266, 463.09656, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(296.3425, 741.4549, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(369.46603, 829.0735, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(282.60712, 533.219, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Spot(344.09882, 443.6003, 20));

		// Marte_Book Spawn Points
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(962.3625, -402.96683, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(1064.6766, -315.8333, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(949.03815, -214.66484, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(1089.5968, -138.2683, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(895.1554, -120.34629, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(779.65704, -245.14175, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(736.322, -136.32349, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(711.31476, -374.57544, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(877.97565, -443.9972, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(880.85583, -278.5189, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-62.108925, -958.8249, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-168.87747, -780.383, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(117.63388, -875.47595, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(125.12289, -715.8728, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(8.763493, -698.001, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(118.03356, -609.48834, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-189.18195, -611.23846, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-34.88288, -522.6187, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-28.54977, -1043.928, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-185.04613, -909.91534, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-807.5151, 1384.9711, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-745.77924, 1536.282, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-638.96063, 1392.1276, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-518.9718, 1374.3907, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-387.9372, 1381.4296, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-350.6637, 1552.8326, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-737.283, 1757.8782, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-711.1171, 1887.3864, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-656.94666, 1656.7938, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-506.72006, 1907.0251, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-605.46576, 1896.0996, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-524.5187, 1651.4014, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-355.00107, 1863.7227, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-329.14783, 1658.8145, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Spot(-480.8953, 1778.991, 20));

		// Aclis_Angel Spawn Points
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-849.7656, -160.04723, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-792.0871, -12.029038, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-712.4703, -140.97081, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-597.30414, 20.808523, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-544.5938, -134.16917, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-591.9926, -234.24371, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-563.08905, -361.14932, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-696.06226, -383.30508, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-830.64197, -239.06682, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-855.7189, -354.75626, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-1500.399, 365.5162, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-1430.3447, 299.66238, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-1313.3066, 439.61392, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-1201.8506, 454.34988, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-1154.9167, 572.4668, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-1258.2402, 672.8845, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-1358.007, 547.7947, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-1424.2532, 682.58496, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-1504.2518, 622.26514, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-1431.2605, 490.74936, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-814.85864, 438.37265, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-761.85815, 539.5105, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-653.3397, 511.14194, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-711.11865, 389.46732, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Spot(-647.3402, 271.1129, 20));

		// Luna_Angel Spawn Points
		AddSpawnPoint( "d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Spot(141.03806, 735.71985, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Spot(124.8685, 592.7641, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Spot(192.12994, 561.42096, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Spot(236.81116, 826.9497, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Spot(351.26712, 903.5413, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Spot(-41.07856, 413.4047, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Spot(218.33401, 470.5258, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Spot(422.10864, 522.3843, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Spot(473.41318, 654.2229, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Spot(63.330486, 513.9513, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Spot(168.47397, 1255.8257, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Spot(79.98819, 1379.2799, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Spot(241.90509, 1094.7408, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Spot(366.61124, 1330.2312, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Spot(203.81583, 1484.526, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Spot(418.17014, 1536.2068, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Spot(63.5167, 1536.7682, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Spot(-39.150803, -272.97495, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Spot(-130.14868, -102.22387, 20));
		AddSpawnPoint( "d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Spot(-23.547382, -109.39149, 20));

	}
}
