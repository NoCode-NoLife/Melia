//--- Melia Script -----------------------------------------------------------
// d_abbey_35_3
//
//--- Description -----------------------------------------------------------
// Sets up the d_abbey_35_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DAbbey353MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_abbey_35_3", MonsterId.Hohen_Mage_Red, Properties("MHP", 354468, "MINPATK", 5059, "MAXPATK", 6120, "MINMATK", 5059, "MAXMATK", 6120, "DEF", 32899, "MDEF", 32899));
		AddPropertyOverrides("d_abbey_35_3", MonsterId.Hohen_Ritter_Green, Properties("MHP", 359843, "MINPATK", 5128, "MAXPATK", 6205, "MINMATK", 5128, "MAXMATK", 6205, "DEF", 34227, "MDEF", 34227));
		AddPropertyOverrides("d_abbey_35_3", MonsterId.Hohen_Barkle_Green, Properties("MHP", 365565, "MINPATK", 5201, "MAXPATK", 6295, "MINMATK", 5201, "MAXMATK", 6295, "DEF", 35640, "MDEF", 35640));

		// Monster Spawners --------------------------------

		AddSpawner("d_abbey_35_3.Id1", MonsterId.Hohen_Mage_Red, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_35_3.Id2", MonsterId.Hohen_Ritter_Green, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_35_3.Id3", MonsterId.Hohen_Barkle_Green, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_35_3.Id4", MonsterId.Rootcrystal_01, 18, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_abbey_35_3.Id5", MonsterId.Hohen_Ritter_Green, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Hohen_Mage_Red Spawn Points
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-102.74207, -199.01352, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-176.89716, -405.0318, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-7.415283, -427.704, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-193.40952, -230.34367, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(39.476433, -87.77057, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(254.73347, -287.30115, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(157.93161, -383.4896, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-954.60034, -271.31924, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-941.52167, -178.39708, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-792.8008, -492.36652, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-730.0348, -370.4285, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-1396.6998, -318.861, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-1440.7238, -121.29242, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-1352.9844, -198.72762, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-1393.9204, -249.50792, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-1383.633, -82.61599, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-1345.8303, 65.00165, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-1017.7432, 221.53778, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-999.9219, 349.53403, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-845.2797, 226.37622, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-812.1466, 318.5822, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-675.4645, 209.15787, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-640.2117, 340.0784, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-977.12634, 789.64154, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-981.22363, 664.73303, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-1131.7002, 274.4819, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-331.2336, 315.8559, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-103.6722, 310.27444, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-34.370243, 563.4661, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(73.16508, 636.55963, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(30.7215, 382.41583, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-582.34485, 1037.6348, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-617.7334, 501.98923, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-622.2387, 811.94666, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(480.12885, 627.5262, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(27.274792, 230.06006, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(330.70346, 570.4823, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(520.76935, 580.514, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(757.53, 486.65717, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(817.64624, 652.2969, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(923.3987, 517.3201, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(940.92804, 650.63434, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(715.80206, 1072.0302, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(794.61816, 1289.7418, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(896.919, 1126.641, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(949.3838, 1343.3962, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(281.6875, 1220.1542, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(471.42825, 1201.7001, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(514.29236, -246.3005, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(728.07385, -257.55014, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(812.82874, -387.06894, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(853.6436, -175.24738, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(1001.2369, -366.52234, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(1008.6204, -131.20459, 25));
		AddSpawnPoint( "d_abbey_35_3.Id1", "d_abbey_35_3", Spot(-240.41472, -301.72507, 25));

		// Hohen_Ritter_Green Spawn Points
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(776.17676, -278.09244, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(839.88275, -139.2481, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(931.8207, -327.53485, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(966.52954, -465.19867, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(1034.5215, -159.67267, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-806.47815, -399.3993, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-866.8949, -396.8148, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-693.4856, -337.67828, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-858.37054, -333.17435, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-696.8279, -461.93066, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-1597.4482, -293.0877, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-1518.878, -221.37582, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-1327.7277, -313.4944, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-1358.0297, -127.70454, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-1309.2878, 0.30077744, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-2172.359, 168.13293, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-2270.949, 308.22665, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-2175.7466, 462.99792, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-2043.3594, 509.8855, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-1948.8372, 293.79843, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-2056.349, 372.37607, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-1816.0497, 445.7154, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-927.177, 223.6502, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-864.1212, 315.22775, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-708.5071, 198.86595, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-679.4936, 307.01135, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(81.07263, 565.56445, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(243.53001, 593.78, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-681.1991, 1129.3434, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-545.58624, 1088.647, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-618.27106, 904.77496, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(781.7072, 558.825, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(851.3292, 672.2095, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(956.4114, 614.45795, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(897.6662, 467.17847, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(768.8282, 1167.9619, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(872.93066, 1323.39, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(711.74915, 1255.9025, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(956.44446, 1214.3923, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(-65.69229, 490.68442, 25));
		AddSpawnPoint( "d_abbey_35_3.Id2", "d_abbey_35_3", Spot(3.5957146, 309.23532, 25));

		// Hohen_Barkle_Green Spawn Points
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(-14.387817, 535.49274, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(17.595562, 465.17365, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(-4.7471123, 144.54721, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(141.40598, 748.75006, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(780.7488, 1188.8494, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(910.0038, 1224.4125, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(781.4344, 437.94714, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(886.00305, 542.5212, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(764.9126, 643.11554, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(-1068.3049, 729.6516, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(-982.1177, 829.1317, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(-927.26196, 717.28973, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(-722.8599, 299.55453, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(-983.74976, 273.58054, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(-653.82043, 160.44566, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(-1966.7264, 274.7805, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(-2258.6218, 270.99927, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(-2156.3525, 129.01819, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(-2127.2302, 445.228, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(-1305.3202, -121.68472, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(-1530.9729, -301.18777, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(-1321.1859, -156.75713, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(-1368.8783, -16.615364, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(-145.36531, 477.89352, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(-654.3421, 1046.7562, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(597.3005, 1213.3513, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(372.19577, 1218.4844, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(-111.05345, 256.73334, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(74.08033, 281.87183, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(-154.25499, 389.13678, 25));
		AddSpawnPoint( "d_abbey_35_3.Id3", "d_abbey_35_3", Spot(131.20595, 416.12305, 25));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(770.08234, 1143.4597, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(417.42178, 1222.6403, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(-142.35336, 591.1371, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(103.06271, 490.71973, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(-12.573333, 267.84348, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(-96.79644, -132.72685, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(-161.37906, -416.13522, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(96.37218, -345.58453, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(729.5206, -245.21223, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(1027.3547, -119.43217, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(1032.1221, -401.13483, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(-626.6338, 245.98979, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(-926.0125, 250.13684, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(-1007.7414, 761.97974, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(-614.364, 1100.799, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(-635.2866, 682.8745, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(-885.90515, -489.71793, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(81.06366, -511.8751, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(-2089.0808, 486.2547, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(-2008.6545, 250.19296, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(-453.48776, -262.2834, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(-689.703, -438.80914, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(-125.91309, -1338.8287, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(128.05496, -1121.5984, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(750.9271, 644.94696, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(928.37354, 512.1576, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(937.72363, 1362.9646, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(426.82913, 578.99615, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(-2221.3962, 180.11424, 100));
		AddSpawnPoint( "d_abbey_35_3.Id4", "d_abbey_35_3", Spot(-930.40454, -318.33472, 100));

		// Hohen_Ritter_Green Spawn Points
		AddSpawnPoint( "d_abbey_35_3.Id5", "d_abbey_35_3", Spot(8.835764, -24.208357, 9999));

	}
}
