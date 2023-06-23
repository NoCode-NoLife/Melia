//--- Melia Script -----------------------------------------------------------
// f_bracken_43_2
//
//--- Description -----------------------------------------------------------
// Sets up the f_bracken_43_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FBracken432MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Populations
		AddMonsterPopulation("f_bracken_43_2", "population_dorong_1", 30);
		AddMonsterPopulation("f_bracken_43_2", "population_darong_2", 25);
		AddMonsterPopulation("f_bracken_43_2", "population_rootcrystal_03_3", 15);
		AddMonsterPopulation("f_bracken_43_2", "population_nukarong_4", 5);
		AddMonsterPopulation("f_bracken_43_2", "population_dorong_5", 3);
		AddMonsterPopulation("f_bracken_43_2", "population_darong_6", 4);
		AddMonsterPopulation("f_bracken_43_2", "population_dorong_7", 8);

		// RootCrystal Spawners
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_3", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(-1792.424, 711.591, 10));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_3", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(-1915.1549, -70.26795, 10));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_3", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(-1030.8273, -467.71533, 10));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_3", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(-563.593, -985.0532, 10));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_3", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(-578.80774, -80.71513, 10));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_3", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(632.6458, 338.243, 10));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_3", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(1376.6831, 272.72107, 10));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_3", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(1159.5901, -550.7802, 10));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_3", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(1345.4817, 864.93964, 10));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_3", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(-111.03139, 868.94836, 10));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_3", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(386.5256, 920.05646, 10));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_3", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(-24.297176, 232.30795, 10));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_3", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(-2021.6886, 223.73126, 10));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_3", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(-808.92676, 780.93286, 10));
		AddSpawner(MonsterId.Rootcrystal_03, "population_rootcrystal_03_3", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(-1266.0018, 918.21796, 10));

		// Monster Spawners
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-654.18835, -805.9407, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-484.22397, -1227.8357, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1855.2622, -187.36934, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-2059.0688, -157.89699, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1984.8293, 614.8455, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1773.3805, 258.81512, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1943.5804, 316.77454, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1721.2979, 763.3056, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1229.1277, 788.89484, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1239.2493, 976.906, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-839.0458, 1034.5641, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(42.39817, 751.00104, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(305.79926, 835.21826, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-20.53629, 916.6449, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(386.94943, 1013.018, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(1102.2266, 794.6667, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(1326.185, 792.0694, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(1362.255, 942.6011, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(1281.7019, 416.59476, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(1440.7592, 218.1153, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(844.6998, -560.7957, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(1089.0328, -648.5753, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(1017.0417, -415.58804, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(484.90237, 245.05885, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(420.5523, 397.78467, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(139.74817, 40.320686, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-110.4249, 83.21558, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-92.14546, 377.7483, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-480.2938, -1044.6771, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-328.78607, -952.38965, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(1332.564, -478.43228, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(1368.8428, -116.33749, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1899.6854, 44.165115, 50));
		AddSpawner(MonsterId.Dorong, "population_dorong_1", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(109.49186, 173.71686, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(115.76257, 514.12134, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-964.56866, -486.07544, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1566.9521, -417.44955, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-2117.4258, -166.24136, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-710.1329, -921.1406, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-2078.549, 33.880646, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1886.8817, 418.015, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1775.991, 520.7555, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1032.223, 889.3396, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-750.7211, 718.20135, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-605.96826, 811.5491, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-104.77155, 873.5029, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(168.59404, 885.31226, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(1281.0936, 675.3859, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(1434.7986, 772.36395, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(1438.5721, 293.91876, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(1020.2137, -527.6776, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1304.1654, -493.68896, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-429.2153, -836.89575, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(127.79771, 340.23093, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1905.2965, -98.98149, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1949.2915, 255.4442, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1998.0015, 667.59314, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1849.8292, 849.9632, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1700.5015, 710.88586, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1254.4675, 868.73315, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1029.6171, 1142.21, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-770.6467, 552.4464, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-754.24335, 990.8935, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-423.59418, 842.9524, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(209.33957, 1092.4752, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(61.27321, 1102.7762, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(196.08765, 779.44366, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(1287.0573, 966.9393, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(1330.3481, 18.183994, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(1125.8783, 422.89966, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(686.6998, 331.01816, 50));
		AddSpawner(MonsterId.Darong, "population_darong_2", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(426.011, 303.129, 50));
		AddSpawner(MonsterId.Nukarong, "population_nukarong_4", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(1265.1232, 851.88135, 100));
		AddSpawner(MonsterId.Nukarong, "population_nukarong_4", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-146.98474, 863.9316, 100));
		AddSpawner(MonsterId.Nukarong, "population_nukarong_4", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1046.4653, 745.3576, 100));
		AddSpawner(MonsterId.Nukarong, "population_nukarong_4", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1863.203, 573.6639, 100));
		AddSpawner(MonsterId.Nukarong, "population_nukarong_4", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-1955.0134, -70.24289, 100));
		AddSpawner(MonsterId.Nukarong, "population_nukarong_4", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(-521.78314, -958.3266, 100));
		AddSpawner(MonsterId.Nukarong, "population_nukarong_4", TimeSpan.FromMilliseconds(0), "f_bracken_43_2", Spot(970.6818, -506.4148, 100));
		AddSpawner(MonsterId.Dorong, "population_dorong_5", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(119.25311, 45.227417, 20));
		AddSpawner(MonsterId.Dorong, "population_dorong_5", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(109.89546, 409.069, 20));
		AddSpawner(MonsterId.Dorong, "population_dorong_5", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(352.80417, 197.76358, 20));
		AddSpawner(MonsterId.Darong, "population_darong_6", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(24.91027, 316.68085, 20));
		AddSpawner(MonsterId.Darong, "population_darong_6", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(226.28625, 78.4247, 20));
		AddSpawner(MonsterId.Darong, "population_darong_6", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(279.89713, 389.34, 20));
		AddSpawner(MonsterId.Darong, "population_darong_6", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(50.435143, 153.32701, 20));
		AddSpawner(MonsterId.Dorong, "population_dorong_7", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(-1034.9126, -567.08026, 20));
		AddSpawner(MonsterId.Dorong, "population_dorong_7", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(-848.38336, -433.90918, 20));
		AddSpawner(MonsterId.Dorong, "population_dorong_7", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(-978.9737, -284.19058, 20));
		AddSpawner(MonsterId.Dorong, "population_dorong_7", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(-1208.3949, -461.7699, 20));
		AddSpawner(MonsterId.Dorong, "population_dorong_7", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(-1003.2996, -431.84354, 20));
		AddSpawner(MonsterId.Dorong, "population_dorong_7", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(-1109.5474, -339.1805, 20));
		AddSpawner(MonsterId.Dorong, "population_dorong_7", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(-1169.2683, -562.09717, 20));
		AddSpawner(MonsterId.Dorong, "population_dorong_7", TimeSpan.FromMilliseconds(60000), "f_bracken_43_2", Spot(-928.1038, -567.6576, 20));

	}
}
