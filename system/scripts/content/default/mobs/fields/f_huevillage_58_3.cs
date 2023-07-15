//--- Melia Script -----------------------------------------------------------
// f_huevillage_58_3
//
//--- Description -----------------------------------------------------------
// Sets up the f_huevillage_58_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FHuevillage583MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_huevillage_58_3", MonsterId.Caro, Properties("MHP", 30545, "MINPATK", 894, "MAXPATK", 1000, "MINMATK", 894, "MAXMATK", 1000, "DEF", 172, "MDEF", 172));
		AddPropertyOverrides("f_huevillage_58_3", MonsterId.Upent, Properties("MHP", 31061, "MINPATK", 900, "MAXPATK", 1009, "MINMATK", 900, "MAXMATK", 1009, "DEF", 173, "MDEF", 173));
		AddPropertyOverrides("f_huevillage_58_3", MonsterId.Tiny_Bow, Properties("MHP", 31598, "MINPATK", 907, "MAXPATK", 1017, "MINMATK", 907, "MAXMATK", 1017, "DEF", 174, "MDEF", 174));

		// Monster Spawners --------------------------------

		AddSpawner("f_huevillage_58_3.Id1", MonsterId.Caro, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_3.Id2", MonsterId.Upent, 2, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_3.Id3", MonsterId.Caro, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_3.Id4", MonsterId.Rootcrystal_01, 12, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_3.Id5", MonsterId.Caro, 60, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_3.Id6", MonsterId.Tiny_Bow, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Caro Spawn Points
		AddSpawnPoint( "f_huevillage_58_3.Id1", "f_huevillage_58_3", Spot(1106.0099, -482.92383, 35));
		AddSpawnPoint( "f_huevillage_58_3.Id1", "f_huevillage_58_3", Spot(1119, -1005, 35));
		AddSpawnPoint( "f_huevillage_58_3.Id1", "f_huevillage_58_3", Spot(1148.0642, -341.0403, 35));
		AddSpawnPoint( "f_huevillage_58_3.Id1", "f_huevillage_58_3", Spot(1024.7644, -862.1282, 35));
		AddSpawnPoint( "f_huevillage_58_3.Id1", "f_huevillage_58_3", Spot(-967.9277, -439.44873, 35));
		AddSpawnPoint( "f_huevillage_58_3.Id1", "f_huevillage_58_3", Spot(-298.3932, -410.11722, 35));
		AddSpawnPoint( "f_huevillage_58_3.Id1", "f_huevillage_58_3", Spot(-983.3752, -585.0267, 35));
		AddSpawnPoint( "f_huevillage_58_3.Id1", "f_huevillage_58_3", Spot(-961.13806, -247.62074, 35));
		AddSpawnPoint( "f_huevillage_58_3.Id1", "f_huevillage_58_3", Spot(-455.18228, -746.47217, 35));
		AddSpawnPoint( "f_huevillage_58_3.Id1", "f_huevillage_58_3", Spot(-506.471, -479.69498, 35));
		AddSpawnPoint( "f_huevillage_58_3.Id1", "f_huevillage_58_3", Spot(1054.4989, -226.38123, 35));
		AddSpawnPoint( "f_huevillage_58_3.Id1", "f_huevillage_58_3", Spot(965.6268, -395.84753, 35));
		AddSpawnPoint( "f_huevillage_58_3.Id1", "f_huevillage_58_3", Spot(1257.9409, -975.0002, 35));
		AddSpawnPoint( "f_huevillage_58_3.Id1", "f_huevillage_58_3", Spot(983.9659, -1046.7662, 35));

		// Upent Spawn Points
		AddSpawnPoint( "f_huevillage_58_3.Id2", "f_huevillage_58_3", Spot(1090, -340, 150));
		AddSpawnPoint( "f_huevillage_58_3.Id2", "f_huevillage_58_3", Spot(1119, -1005, 150));

		// Caro Spawn Points
		AddSpawnPoint( "f_huevillage_58_3.Id3", "f_huevillage_58_3", Spot(-975.7455, -749.9262, 9999));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_huevillage_58_3.Id4", "f_huevillage_58_3", Spot(235.58908, -1400.6501, 200));
		AddSpawnPoint( "f_huevillage_58_3.Id4", "f_huevillage_58_3", Spot(939.82886, -975.5754, 200));
		AddSpawnPoint( "f_huevillage_58_3.Id4", "f_huevillage_58_3", Spot(258.0291, -955.3603, 200));
		AddSpawnPoint( "f_huevillage_58_3.Id4", "f_huevillage_58_3", Spot(-1262.9595, -1098.0154, 200));
		AddSpawnPoint( "f_huevillage_58_3.Id4", "f_huevillage_58_3", Spot(-700.29364, -1040.4187, 200));
		AddSpawnPoint( "f_huevillage_58_3.Id4", "f_huevillage_58_3", Spot(-954.4085, -596.06525, 200));
		AddSpawnPoint( "f_huevillage_58_3.Id4", "f_huevillage_58_3", Spot(-289.2654, -128.32478, 200));
		AddSpawnPoint( "f_huevillage_58_3.Id4", "f_huevillage_58_3", Spot(9.637512, 343.21805, 200));
		AddSpawnPoint( "f_huevillage_58_3.Id4", "f_huevillage_58_3", Spot(518.2236, 257.3068, 200));
		AddSpawnPoint( "f_huevillage_58_3.Id4", "f_huevillage_58_3", Spot(981.879, -388.81924, 200));
		AddSpawnPoint( "f_huevillage_58_3.Id4", "f_huevillage_58_3", Spot(1729.4762, -562.99335, 200));
		AddSpawnPoint( "f_huevillage_58_3.Id4", "f_huevillage_58_3", Spot(-251.21936, -611.3365, 200));

		// Caro Spawn Points
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1562.3308, -952.04126, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1292.1913, -296.416, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1202.3827, -983.8003, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1605.4946, -873.5709, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1177.7761, -422.0082, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1500.2704, -866.06744, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1578.0095, -790.1976, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1584.3055, -728.7957, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1400.091, -886.24603, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1301.5018, -965.4189, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1187.7968, -1071.6239, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1028.4583, -1124.4148, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1097.6139, -1043.5422, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(933.7082, -994.4426, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(949.07947, -932.091, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(993.9087, -917.20734, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1071.7933, -839.0616, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1030.0298, -974.9084, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1121.9146, -950.22, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1180.353, -849.98883, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1285.0089, -880.91376, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1172.3812, -302.91608, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1057.1522, -268.70248, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1062.0203, -497.9092, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1150.5737, -489.89594, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1217.8945, -437.2843, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1342.722, -299.3457, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1300.2507, -272.8719, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1226.6204, -249.8034, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1104.5294, -359.87378, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(982.6186, -364.95554, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(995.8103, -419.58932, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(925.8941, -311.78104, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(946.3009, -227.95692, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(987.0474, -173.28586, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1028.0414, -146.92888, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1092.999, -157.77292, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(1411.7877, -258.66916, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(868.636, -66.124146, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(822.28595, -15.436359, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(775.1584, -4.295349, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(687.19855, 70.24036, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(518.05304, 158.26462, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(463.14658, 233.46246, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(364.06958, 179.16055, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(436.36734, 374.55862, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(522.2333, 385.19913, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(535.2101, 236.09406, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(629.00397, 265.8026, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(597.10443, 160.85107, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(505.1591, 293.9907, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(504.1557, 479.13632, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(380.4779, 278.54102, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(419.75024, 60.14829, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(536.3659, 20.758343, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(239.70834, -615.44946, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(165.58296, -504.4633, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(372.12445, -610.60724, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(290.14774, -779.76434, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(261.4947, -681.51074, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(136.14287, -688.8738, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(293.23422, -512.0294, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(483.29108, -672.16876, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(212.88673, -871.95123, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(161.5509, -764.1191, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(347.06226, -825.0176, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(416.68134, -676.30963, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-353.71948, -799.95654, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-457.37735, -784.50415, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-419.4426, -707.5448, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-284.08813, -718.869, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-310.0699, -642.9372, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-391.20383, -685.7099, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-491.90768, -573.8038, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-442.86743, -527.1078, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-440.66925, -497.91415, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-221.60265, -566.2097, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-289.20267, -470.86588, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-332.7663, -458.94485, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(10.19754, 405.9046, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-42.096176, 408.97543, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-22.059883, 312.62332, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-129.03598, 338.6635, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-168.54575, 199.9341, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-6.840643, 248.75084, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-125.0537, 284.8748, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-230.5475, 300.5348, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-241.52907, 236.82098, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-210.97748, 119.77104, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-262.47488, 135.29172, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-359.91162, 159.88615, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-301.42133, 60.9741, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-239.95657, 54.678745, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-599.60895, -380.63135, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-643.2999, -375.1074, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-550.52814, -316.4575, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-471.69052, -329.65262, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-1240.0635, -1070.7552, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-1201.364, -1012.1073, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-1236.848, -983.6629, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-1205.0486, -897.0456, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-1087.662, -883.8477, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-1127.8634, -812.0754, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-1014.0263, -784.99304, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-1004.0192, -700.17896, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-895.99695, -778.5259, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-680.10345, -680.96216, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-707.15765, -727.3416, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-762.4818, -760.26544, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-803.2158, -672.19147, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-801.7957, -594.1728, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-972.18286, -628.0254, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-918.04034, -598.2373, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-880.4307, -563.8255, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-1006.6019, -430.14624, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-1032.5538, -341.23633, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-985.74255, -302.8886, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-908.1849, -174.21567, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-830.26306, -157.73788, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-874.93945, -278.84882, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-769.5553, -307.00635, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-867.36584, -348.88348, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-900.9658, -442.9273, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-722.5363, -485.37265, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-713.2359, -607.97955, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-714.9129, -425.32834, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id5", "f_huevillage_58_3", Spot(-827.9012, -477.93683, 25));

		// Tiny_Bow Spawn Points
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(-1151.6173, -851.0912, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(1632.2732, -817.3584, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(-948.5057, -459.5143, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(-413.49255, -815.3292, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(1677.4858, -758.4962, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(1483.1642, -234.66454, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(-258.27545, -458.5359, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(-949.0256, -732.1624, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(-1014.0151, -294.76785, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(-958.3556, -598.88715, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(-835.8246, -768.7951, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(-1249.3403, -1028.3901, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(-589.88104, -344.29572, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(-336.7187, 118.94373, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(-149.94272, 154.25177, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(-160.56038, 318.33597, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(53.154663, 405.27365, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(-278.7385, 223.5657, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(494.6144, 228.47232, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(581.4776, 366.65652, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(684.09033, 193.59966, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(684.09033, 193.59966, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(649.0171, 91.03652, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(846.68506, -32.962982, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(430.3633, 438.95764, 25));
		AddSpawnPoint( "f_huevillage_58_3.Id6", "f_huevillage_58_3", Spot(329.24716, 224.60875, 25));

	}
}
