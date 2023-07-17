//--- Melia Script -----------------------------------------------------------
// f_whitetrees_56_1
//
//--- Description -----------------------------------------------------------
// Sets up the f_whitetrees_56_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FWhitetrees561MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_whitetrees_56_1.Id1", MonsterId.Rootcrystal_03, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_56_1.Id2", MonsterId.Floron, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_56_1.Id3", MonsterId.Florabbi, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_56_1.Id4", MonsterId.Budny, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_56_1.Id5", MonsterId.Bloom, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_56_1.Id6", MonsterId.Castle_Gardner, 1, TimeSpan.FromMilliseconds(1800000), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_56_1.Id7", MonsterId.Florabbi, 9, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint( "f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Spot(-170.76282, 287.8975, 10));
		AddSpawnPoint( "f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Spot(-626.49, 857.86, 10));
		AddSpawnPoint( "f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Spot(-1058.79, 356.2, 10));
		AddSpawnPoint( "f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Spot(-1357.28, 1199.95, 10));
		AddSpawnPoint( "f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Spot(177.85, 1201.58, 10));
		AddSpawnPoint( "f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Spot(867.13, 913.64, 10));
		AddSpawnPoint( "f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Spot(876.32, 137.79, 10));
		AddSpawnPoint( "f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Spot(558.1172, -569.5097, 10));
		AddSpawnPoint( "f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Spot(907.3109, -640.18756, 10));
		AddSpawnPoint( "f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Spot(-31.7, -515.24, 10));
		AddSpawnPoint( "f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Spot(1301.36, -417.45, 10));
		AddSpawnPoint( "f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Spot(1518.6241, 224.8606, 10));
		AddSpawnPoint( "f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Spot(1472.0232, 1223.0193, 10));
		AddSpawnPoint( "f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Spot(1495.9393, 588.7888, 10));
		AddSpawnPoint( "f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Spot(-8.673475, 521.20294, 10));

		// Floron Spawn Points
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(846.79, 28.69, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(832.16, 277.19, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(958.1, 167.22, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(1014.79, 28.3, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(307.5255, -26.234154, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(193.4421, 38.22402, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(0.6645268, 323.8976, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(-81.915634, 552.0246, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(31.09, 644.4, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(41.51, 1037.86, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(47.95, 1334.67, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(630.88, 1186.79, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(862.68, 937.3, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(775.91, 839.89, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(776.04, 453.7, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(690.83, 248.07, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(1395.32, 374.91, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(1551.15, 224.97, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(1673.2006, 396.4868, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(1514.8741, 515.05865, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(1459.6, 660.3, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(1518.2, 990.57, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(1439.8463, 1096.9077, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(1355.46, 1161.78, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(1539.44, 1166.34, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(1405.18, 1002.77, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(284.37054, 87.33751, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(1548.001, 363.74246, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Spot(1440.8536, 1195.4515, 30));

		// Florabbi Spawn Points
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(820.8, -488.39, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(772.47284, -730.3068, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(619.58, -494.03, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(591.84, -647.82, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(921.1, -733.91, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(968.62, -565.47, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(757.89, -617.51, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-96.37, -562.71, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-7.21, -481.36, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(123.16, -571.21, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(191.29, -688.65, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(484.57, -581.61, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(1239.59, -423.37, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(1277.96, -313.29, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(1332.68, -346.51, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(1299.04, -562.06, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(1429, -552.4, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(1446.66, -414.44, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(1208.77, -213.04, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-764.21, -754.35, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-810.73, -675.77, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-729.33, -592.33, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-793.13, -563.75, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-903.99, -693.94, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-922.38, -773.09, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-975.8, -620.63, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-854.62, -499.46, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-912.97, -553.13, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-1217.63, 1164.83, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-1407.87, 1245.62, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-1312.84, 1136.11, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-1323.56, 1268.92, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-1297.54, 1364.2, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-1081.82, 452.59, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-1193.34, 329.59, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-944.43, 291.86, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-1037.74, 357.48, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-904.14, 461.7, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-1066.4496, 540.93115, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(-114.48, -435.8, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Spot(770.39, -321.21, 30));

		// Budny Spawn Points
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-605.37, -268.51, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-450.26, -132.84, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-446.18, -270.74, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-343.95, -130.27, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-974.5, 354.99, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-993.32, 526.92, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-912.24, 535.89, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-798.63, 811.05, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-1296.74, 1123.5, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-1266.25, 1347.42, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-1031, 1144.17, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-725.5984, 957.8612, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-385.53, 717.43, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-292.57, 709.02, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-192.49188, 513.0805, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-87.69903, 437.00638, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-274.36, 145.15, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(11.53, 509.87, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(129.77, 338.72, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-233.47, -271.05, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-70.52, -503.35, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(264.34, -557.53, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(415.12, -527.54, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(639.98, -512.58, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(815.82, -422.27, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(840.63, -164.86, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(1146.3, -54.21, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(1152.34, -50.87, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(1316.8, -394.95, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(820.89, 102.59, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(873.12, 255.74, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(965.66, 434, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(824.85, 487.13, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(879.8, 839.12, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(721.36, 1071.95, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(540.69, 1019.14, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(494.23, 1057.55, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(39.35, 948.01, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(26.19, 1207.91, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(173.08, 1393.13, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(226.42, 1290.31, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(40.41, 732.95, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-136.57469, 609.5454, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-608.3379, 1064.3691, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-622.1696, 741.05005, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-493.0237, 951.0576, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-617.7947, 879.81903, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Spot(-485.59906, 801.641, 30));

		// Bloom Spawn Points
		AddSpawnPoint( "f_whitetrees_56_1.Id5", "f_whitetrees_56_1", Spot(173.43, -550.8, 9999));

		// Castle_Gardner Spawn Points
		AddSpawnPoint( "f_whitetrees_56_1.Id6", "f_whitetrees_56_1", Spot(-184.51492, 593.7529, 9999));

		// Florabbi Spawn Points
		AddSpawnPoint( "f_whitetrees_56_1.Id7", "f_whitetrees_56_1", Spot(105.12, 1438.63, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id7", "f_whitetrees_56_1", Spot(187.28, 1260.49, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id7", "f_whitetrees_56_1", Spot(118.04, 1109.74, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id7", "f_whitetrees_56_1", Spot(-146.82, 456.06, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id7", "f_whitetrees_56_1", Spot(61.92, 357.33, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id7", "f_whitetrees_56_1", Spot(5.9, 609.79, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id7", "f_whitetrees_56_1", Spot(-751.91, 857.96, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id7", "f_whitetrees_56_1", Spot(-581.8, 1037.08, 30));
		AddSpawnPoint( "f_whitetrees_56_1.Id7", "f_whitetrees_56_1", Spot(-496.12, 842.72, 30));

	}
}
