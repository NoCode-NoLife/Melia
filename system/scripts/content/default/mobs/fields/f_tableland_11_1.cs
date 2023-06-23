//--- Melia Script -----------------------------------------------------------
// f_tableland_11_1
//
//--- Description -----------------------------------------------------------
// Sets up the f_tableland_11_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FTableland111MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Populations
		AddMonsterPopulation("f_tableland_11_1", "population_saltisdaughter_red_1", 30);
		AddMonsterPopulation("f_tableland_11_1", "population_saltisdaughter_bow_green_2", 20);
		AddMonsterPopulation("f_tableland_11_1", "population_repusbunny_mage_green_3", 20);
		AddMonsterPopulation("f_tableland_11_1", "population_groll_white_4", 25);
		AddMonsterPopulation("f_tableland_11_1", "population_groll_white_5", 40);
		AddMonsterPopulation("f_tableland_11_1", "population_rootcrystal_01_6", 18);

		// RootCrystal Spawners
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-373.0001, -706.0391, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-131.74783, -840.2046, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(104.41075, -261.09555, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-232.3663, -150.70659, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(394.10696, 5.818326, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(716.75665, 667.77277, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(1055.426, 542.6883, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(200.49905, 1120.6213, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-146.3876, 1049.8829, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(128.13594, 1317.722, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-61.46218, 1824.8625, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-20.105814, 99.77384, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-722.73535, 286.8463, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-870.9428, -493.19318, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-769.78265, -249.56409, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-882.2607, -986.80896, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-913.3962, -1352.2517, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-521.12744, -1299.8481, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(408.7337, -1179.6819, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(48.138493, -1346.5212, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(448.46933, -1437.7593, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-887.0003, 449.502, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-162.13483, 1293.066, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(55.45481, 2016.058, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_6", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-2232.3184, 2112.98, 100));

		// Monster Spawners
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-158.11053, -92.89298, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-62.32468, 1309.7648, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(19.728264, -131.39407, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-198.09668, 1206.7544, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(46.152634, 1266.6785, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-92.161156, 1106.7717, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(270.36566, 1085.6046, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(688.1033, 580.1842, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(749.4871, 736.2224, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(1058.6438, 515.7305, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(1020.2498, 420.64102, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(887.32983, 583.0008, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(802.6167, 167.42284, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(503.3966, 88.21856, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(113.8606, -225.47728, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-51.560574, 122.73868, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-246.2449, -83.03145, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-171.49654, 72.41771, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(254.15918, -4.1304703, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-361.8435, -280.64822, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-461.94193, -112.12851, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-76.30927, -131.33652, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(83.701195, -73.06533, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(241.80185, -169.73785, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(1034.3956, 644.80194, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(1099.5558, 393.3105, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(179.55627, 1308.687, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(95.551285, 1046.977, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-156.16382, 1375.0912, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(136.5339, 1147.6222, 30));
		AddSpawner(MonsterId.Saltisdaughter_Red, "population_saltisdaughter_red_1", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(352.38168, 934.63464, 30));
		AddSpawner(MonsterId.Saltisdaughter_Bow_Green, "population_saltisdaughter_bow_green_2", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-125.8777, 1188.5304, 30));
		AddSpawner(MonsterId.Saltisdaughter_Bow_Green, "population_saltisdaughter_bow_green_2", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(148.90616, 1165.6213, 30));
		AddSpawner(MonsterId.Saltisdaughter_Bow_Green, "population_saltisdaughter_bow_green_2", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-266.12445, -255.47084, 30));
		AddSpawner(MonsterId.Saltisdaughter_Bow_Green, "population_saltisdaughter_bow_green_2", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-117.29712, 5.9211645, 30));
		AddSpawner(MonsterId.Saltisdaughter_Bow_Green, "population_saltisdaughter_bow_green_2", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(132.90225, -120.44523, 30));
		AddSpawner(MonsterId.Saltisdaughter_Bow_Green, "population_saltisdaughter_bow_green_2", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(705.68964, 673.30994, 30));
		AddSpawner(MonsterId.Saltisdaughter_Bow_Green, "population_saltisdaughter_bow_green_2", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(1003.1226, 507.5144, 30));
		AddSpawner(MonsterId.Saltisdaughter_Bow_Green, "population_saltisdaughter_bow_green_2", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-938.29266, -358.35883, 30));
		AddSpawner(MonsterId.Saltisdaughter_Bow_Green, "population_saltisdaughter_bow_green_2", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-806.6802, -222.21606, 30));
		AddSpawner(MonsterId.Saltisdaughter_Bow_Green, "population_saltisdaughter_bow_green_2", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-635.6353, -386.34763, 30));
		AddSpawner(MonsterId.Saltisdaughter_Bow_Green, "population_saltisdaughter_bow_green_2", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-344.75977, -856.7908, 30));
		AddSpawner(MonsterId.Saltisdaughter_Bow_Green, "population_saltisdaughter_bow_green_2", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-161.04425, -691.3743, 30));
		AddSpawner(MonsterId.Saltisdaughter_Bow_Green, "population_saltisdaughter_bow_green_2", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-71.965, -786.40845, 30));
		AddSpawner(MonsterId.Saltisdaughter_Bow_Green, "population_saltisdaughter_bow_green_2", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-175.96307, -879.0983, 30));
		AddSpawner(MonsterId.Saltisdaughter_Bow_Green, "population_saltisdaughter_bow_green_2", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-398.17218, -686.19495, 30));
		AddSpawner(MonsterId.Saltisdaughter_Bow_Green, "population_saltisdaughter_bow_green_2", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-757.07794, -455.90848, 30));
		AddSpawner(MonsterId.Saltisdaughter_Bow_Green, "population_saltisdaughter_bow_green_2", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-978.59235, -231.49483, 30));
		AddSpawner(MonsterId.Saltisdaughter_Bow_Green, "population_saltisdaughter_bow_green_2", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-586.70166, -195.46362, 30));
		AddSpawner(MonsterId.Saltisdaughter_Bow_Green, "population_saltisdaughter_bow_green_2", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-270.9005, -754.02057, 30));
		AddSpawner(MonsterId.Saltisdaughter_Bow_Green, "population_saltisdaughter_bow_green_2", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-89.12376, -586.76697, 30));
		AddSpawner(MonsterId.Repusbunny_Mage_Green, "population_repusbunny_mage_green_3", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-748.944, -989.9578, 30));
		AddSpawner(MonsterId.Repusbunny_Mage_Green, "population_repusbunny_mage_green_3", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-914.5619, -963.21265, 30));
		AddSpawner(MonsterId.Repusbunny_Mage_Green, "population_repusbunny_mage_green_3", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-649.6726, -1133.4911, 30));
		AddSpawner(MonsterId.Repusbunny_Mage_Green, "population_repusbunny_mage_green_3", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-824.7467, -1039.9314, 30));
		AddSpawner(MonsterId.Repusbunny_Mage_Green, "population_repusbunny_mage_green_3", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-643.8955, -1448.3817, 30));
		AddSpawner(MonsterId.Repusbunny_Mage_Green, "population_repusbunny_mage_green_3", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-512.3778, -1228.2216, 30));
		AddSpawner(MonsterId.Repusbunny_Mage_Green, "population_repusbunny_mage_green_3", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-758.13574, -1475.7538, 30));
		AddSpawner(MonsterId.Repusbunny_Mage_Green, "population_repusbunny_mage_green_3", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-945.0515, -1119.8921, 30));
		AddSpawner(MonsterId.Repusbunny_Mage_Green, "population_repusbunny_mage_green_3", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-522.7136, -1330.1458, 30));
		AddSpawner(MonsterId.Repusbunny_Mage_Green, "population_repusbunny_mage_green_3", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-282.4667, -1297.3766, 30));
		AddSpawner(MonsterId.Repusbunny_Mage_Green, "population_repusbunny_mage_green_3", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-907.6201, -290.70544, 30));
		AddSpawner(MonsterId.Repusbunny_Mage_Green, "population_repusbunny_mage_green_3", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-712.251, -284.34155, 30));
		AddSpawner(MonsterId.Repusbunny_Mage_Green, "population_repusbunny_mage_green_3", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-318.54395, -76.97026, 30));
		AddSpawner(MonsterId.Repusbunny_Mage_Green, "population_repusbunny_mage_green_3", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-327.10785, -326.89633, 30));
		AddSpawner(MonsterId.Repusbunny_Mage_Green, "population_repusbunny_mage_green_3", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-149.79248, -528.181, 30));
		AddSpawner(MonsterId.Repusbunny_Mage_Green, "population_repusbunny_mage_green_3", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-277.26755, -837.2532, 30));
		AddSpawner(MonsterId.Repusbunny_Mage_Green, "population_repusbunny_mage_green_3", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-833.31744, -1161.2706, 30));
		AddSpawner(MonsterId.Repusbunny_Mage_Green, "population_repusbunny_mage_green_3", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-668.20703, -1317.9639, 30));
		AddSpawner(MonsterId.Groll_White, "population_groll_white_4", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(90.3065, -1214.1735, 30));
		AddSpawner(MonsterId.Groll_White, "population_groll_white_4", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(296.7003, -1109.8503, 30));
		AddSpawner(MonsterId.Groll_White, "population_groll_white_4", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(421.34305, -1045.3802, 30));
		AddSpawner(MonsterId.Groll_White, "population_groll_white_4", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(584.0241, -1222.9761, 30));
		AddSpawner(MonsterId.Groll_White, "population_groll_white_4", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(503.52762, -1214.7828, 30));
		AddSpawner(MonsterId.Groll_White, "population_groll_white_4", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(238.44, -1409.0165, 30));
		AddSpawner(MonsterId.Groll_White, "population_groll_white_4", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(130.81241, -1429.0289, 30));
		AddSpawner(MonsterId.Groll_White, "population_groll_white_4", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(53.83175, -1305.7418, 30));
		AddSpawner(MonsterId.Groll_White, "population_groll_white_4", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(522.85077, -1143.5045, 30));
		AddSpawner(MonsterId.Groll_White, "population_groll_white_4", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(374.2754, -1481.5963, 30));
		AddSpawner(MonsterId.Groll_White, "population_groll_white_5", TimeSpan.FromMilliseconds(60000), "f_tableland_11_1", Spot(-359.2051, -43.78154, 9999));

	}
}
