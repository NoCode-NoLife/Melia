//--- Melia Script -----------------------------------------------------------
// d_fantasylibrary_48_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Sausis Room 10' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFantasylibrary482MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_fantasylibrary_48_2", MonsterId.Levada, Properties("MHP", 534014, "MINPATK", 7368, "MAXPATK", 8957, "MINMATK", 7368, "MAXMATK", 8957, "DEF", 94757, "MDEF", 94757));
		AddPropertyOverrides("d_fantasylibrary_48_2", MonsterId.Marte_Book, Properties("MHP", 536103, "MINPATK", 7395, "MAXPATK", 8990, "MINMATK", 7395, "MAXMATK", 8990, "DEF", 95790, "MDEF", 95790));
		AddPropertyOverrides("d_fantasylibrary_48_2", MonsterId.Aclis_Angel, Properties("MHP", 538326, "MINPATK", 7423, "MAXPATK", 9025, "MINMATK", 7423, "MAXMATK", 9025, "DEF", 96890, "MDEF", 96890));
		AddPropertyOverrides("d_fantasylibrary_48_2", MonsterId.Luna_Angel, Properties("MHP", 540677, "MINPATK", 7454, "MAXPATK", 9062, "MINMATK", 7454, "MAXMATK", 9062, "DEF", 98052, "MDEF", 98052));

		// Monster Spawners ---------------------------------

		AddSpawner("d_fantasylibrary_48_2.Id1", MonsterId.Rootcrystal_03, 12, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_2.Id2", MonsterId.Levada, 45, 60, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_2.Id3", MonsterId.Marte_Book, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_2.Id4", MonsterId.Aclis_Angel, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_2.Id5", MonsterId.Luna_Angel, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 8 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-70.96192, -912.533, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-155.2776, -668.3207, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(97.47767, -697.5531, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(6.2911816, -781.4941, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-150.67712, -235.11691, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(86.87434, -233.9829, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-828.4747, -133.20898, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-778.9827, -326.1649, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-530.2745, -180.12325, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-1317.2214, 368.72226, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-1450.717, 588.1688, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-1250.6185, 625.1411, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-1467.4485, 419.50104, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-725.63074, 293.5204, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-869.2427, 521.8553, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-673.6422, 601.9028, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-526.78546, 479.4915, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-709.6604, 461.72977, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(60.040237, 475.96124, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(121.64323, 820.0566, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(220.34973, 807.10187, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(466.86877, 645.04474, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(399.6458, 479.95435, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(900.2185, 519.7396, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(776.0543, 597.3585, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(883.17365, 727.32153, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(1000.3585, 704.9067, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(258.05322, 1358.8492, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(77.05518, 1301.4846, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(120.52112, 1501.7579, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(363.2575, 1468.4702, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-637.8186, 1801.4354, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-662.7879, 1558.08, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-551.1934, 1417.5342, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-367.16147, 1491.4899, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-384.01114, 1812.6871, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-550.9521, 1664.0068, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(883.0411, -394.78387, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(962.8848, -117.85939, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(1044.9413, -333.63696, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(1450.4387, -306.6712, 100));

		// 'Levada' GenType 21 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(822.3179, 663.3762, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(820.3102, 556.54456, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(941.8388, 557.52124, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(919.64514, 750.90576, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(1339.0513, -199.84023, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(1358.0483, -333.32077, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(1452.5996, -327.31613, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(1566.2172, -254.73404, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-140.66412, -263.55096, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-72.51198, -157.80635, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(39.429714, -217.65445, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(49.868378, -114.39581, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(114.35773, 1460.5845, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(157.23775, 1357.9518, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(268.8048, 1321.6941, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(391.5023, 1451.2675, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(786.2051, -166.46565, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(845.4296, -364.9097, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(958.2307, -305.2716, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(1072.1633, -403.46954, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(996.2415, -130.02591, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-136.73123, -650.9275, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-78.80372, -749.3242, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(35.799103, -749.93207, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-131.48775, -861.062, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(32.259335, -862.52527, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-820.3349, -97.07361, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-634.23566, -160.17986, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-759.558, -211.05145, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-771.8323, -345.28622, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-636.82184, -306.2661, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-1441.9326, 575.0445, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-1513.0854, 458.17023, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-1412.7432, 426.96985, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-1263.5958, 369.58868, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-1258.4388, 551.61945, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-867.5617, 517.7297, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-890.37, 381.1024, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-752.9416, 325.9573, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-608.8672, 396.67755, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-575.4143, 535.8687, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-692.6803, 600.2355, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-715.90875, 1472.2393, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-664.7269, 1573.5272, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-616.36707, 1487.9996, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-530.88434, 1563.0027, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-470.51453, 1468.0327, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-643.5997, 1819.853, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-607.5745, 1736.8436, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-536.13794, 1812.8721, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-370.14767, 1779.8011, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-45.481243, 707.1347, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-2.7178307, 886.63885, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(117.28342, 863.5361, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-16.839767, 534.955, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(125.13266, 463.09656, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(296.3425, 741.4549, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(369.46603, 829.0735, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(282.60712, 533.219, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(344.09882, 443.6003, 20));

		// 'Marte_Book' GenType 22 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(962.3625, -402.96683, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(1064.6766, -315.8333, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(949.03815, -214.66484, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(1089.5968, -138.2683, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(895.1554, -120.34629, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(779.65704, -245.14175, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(736.322, -136.32349, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(711.31476, -374.57544, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(877.97565, -443.9972, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(880.85583, -278.5189, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-62.108925, -958.8249, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-168.87747, -780.383, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(117.63388, -875.47595, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(125.12289, -715.8728, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(8.763493, -698.001, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(118.03356, -609.48834, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-189.18195, -611.23846, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-34.88288, -522.6187, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-28.54977, -1043.928, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-185.04613, -909.91534, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-807.5151, 1384.9711, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-745.77924, 1536.282, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-638.96063, 1392.1276, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-518.9718, 1374.3907, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-387.9372, 1381.4296, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-350.6637, 1552.8326, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-737.283, 1757.8782, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-711.1171, 1887.3864, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-656.94666, 1656.7938, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-506.72006, 1907.0251, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-605.46576, 1896.0996, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-524.5187, 1651.4014, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-355.00107, 1863.7227, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-329.14783, 1658.8145, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-480.8953, 1778.991, 20));

		// 'Aclis_Angel' GenType 23 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-849.7656, -160.04723, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-792.0871, -12.029038, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-712.4703, -140.97081, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-597.30414, 20.808523, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-544.5938, -134.16917, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-591.9926, -234.24371, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-563.08905, -361.14932, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-696.06226, -383.30508, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-830.64197, -239.06682, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-855.7189, -354.75626, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-1500.399, 365.5162, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-1430.3447, 299.66238, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-1313.3066, 439.61392, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-1201.8506, 454.34988, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-1154.9167, 572.4668, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-1258.2402, 672.8845, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-1358.007, 547.7947, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-1424.2532, 682.58496, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-1504.2518, 622.26514, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-1431.2605, 490.74936, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-814.85864, 438.37265, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-761.85815, 539.5105, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-653.3397, 511.14194, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-711.11865, 389.46732, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-647.3402, 271.1129, 20));

		// 'Luna_Angel' GenType 24 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(141.03806, 735.71985, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(124.8685, 592.7641, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(192.12994, 561.42096, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(236.81116, 826.9497, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(351.26712, 903.5413, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(-41.07856, 413.4047, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(218.33401, 470.5258, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(422.10864, 522.3843, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(473.41318, 654.2229, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(63.330486, 513.9513, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(168.47397, 1255.8257, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(79.98819, 1379.2799, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(241.90509, 1094.7408, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(366.61124, 1330.2312, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(203.81583, 1484.526, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(418.17014, 1536.2068, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(63.5167, 1536.7682, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(-39.150803, -272.97495, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(-130.14868, -102.22387, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(-23.547382, -109.39149, 20));
	}
}
