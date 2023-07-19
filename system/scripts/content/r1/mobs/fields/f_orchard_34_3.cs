//--- Melia Script -----------------------------------------------------------
// f_orchard_34_3
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Barha Forest' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FOrchard343MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_orchard_34_3", MonsterId.Mushroom_Ent_Red, Properties("MHP", 330232, "MINPATK", 4747, "MAXPATK", 5737, "MINMATK", 4747, "MAXMATK", 5737, "DEF", 26911, "MDEF", 26911));
		AddPropertyOverrides("f_orchard_34_3", MonsterId.Rafflesia_Green, Properties("MHP", 331541, "MINPATK", 4764, "MAXPATK", 5758, "MINMATK", 4764, "MAXMATK", 5758, "DEF", 27234, "MDEF", 27234));
		AddPropertyOverrides("f_orchard_34_3", MonsterId.Big_Cockatries_Red, Properties("MHP", 333933, "MINPATK", 4795, "MAXPATK", 5795, "MINMATK", 4795, "MAXMATK", 5795, "DEF", 27825, "MDEF", 27825));
		AddPropertyOverrides("f_orchard_34_3", MonsterId.Flying_Flog_White, Properties("MHP", 337032, "MINPATK", 4834, "MAXPATK", 5844, "MINMATK", 4834, "MAXMATK", 5844, "DEF", 28591, "MDEF", 28591));

		// Monster Spawners ---------------------------------

		AddSpawner("f_orchard_34_3.Id1", MonsterId.Mushroom_Ent_Red, 3, 4, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_orchard_34_3.Id2", MonsterId.Rafflesia_Green, 11, 14, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_orchard_34_3.Id3", MonsterId.Big_Cockatries_Red, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_orchard_34_3.Id4", MonsterId.Flying_Flog_White, 60, 80, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_orchard_34_3.Id5", MonsterId.Rafflesia_Green, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_orchard_34_3.Id6", MonsterId.Flying_Flog_White, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_orchard_34_3.Id7", MonsterId.Rootcrystal_01, 15, 19, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Mushroom_Ent_Red' GenType 26 Spawn Points
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(58.223755, 566.0202, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(-88.78932, 353.39835, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(-80.01297, 559.957, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(-300.65726, 564.6987, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(-465.9684, 453.30865, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(-514.3968, 635.67255, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(63.35736, 748.6088, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(192.72711, 442.4794, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(217.14589, 613.3694, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(357.51047, 527.0381, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(549.0534, 627.96204, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(-498.49207, 835.3807, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(-599.54755, 1158.1262, 50));
		AddSpawnPoint("f_orchard_34_3.Id1", "f_orchard_34_3", Rectangle(524.024, 453.85684, 50));

		// 'Rafflesia_Green' GenType 27 Spawn Points
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1103.9999, -281.1216, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(884.2685, -424.19632, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(789.9842, -214.31831, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(948.88, -230.77808, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(958.3405, -99.99507, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(919.5576, 30.785019, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1169.5116, -129.36261, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1349.5786, -142.61638, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1225.393, -355.9634, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1230.573, -501.35245, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1065.1019, -431.13968, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1007.9053, -621.15485, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(851.9688, -657.8981, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1131.8156, -606.74664, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1053.9435, -479.06372, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1300.0072, -539.69714, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1447.6875, -402.5556, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1355.6381, -392.65726, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1155.1094, -1.8139154, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1212.8737, -173.31915, 30));
		AddSpawnPoint("f_orchard_34_3.Id2", "f_orchard_34_3", Rectangle(1327.4902, -243.70363, 30));

		// 'Big_Cockatries_Red' GenType 28 Spawn Points
		AddSpawnPoint("f_orchard_34_3.Id3", "f_orchard_34_3", Rectangle(-357.88354, -184.01608, 9999));

		// 'Flying_Flog_White' GenType 29 Spawn Points
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-981.5997, -344.6827, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1468.7341, -203.30849, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1039.2614, -265.87247, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1443.421, -677.0205, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1593.5028, -846.0244, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1404.0583, -1003.7018, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1509.8475, -1150.7966, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1283.4379, -1170.594, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1195.659, -1056.9681, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1339.7501, -1121.63, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1499.6826, -892.49414, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(941.53174, -781.24286, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(822.34564, -973.3755, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1217.9534, -992.33356, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1172.5978, -927.3126, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1439.004, 670.7086, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1419.8584, 541.0531, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1220.2715, 477.66177, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1333.7468, 564.0008, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(987.3321, 610.0844, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(889.0485, 41.1455, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(789.74176, 126.01588, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(539.90576, 695.39264, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-283.51288, -371.74298, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-217.15941, 600.08374, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-785.6514, 587.9105, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-618.2395, 470.97385, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-496.8766, 1045.9598, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-609.9109, 1152.2314, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-531.05084, 1165.1855, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-470.2357, 784.27423, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(844.9469, 587.7239, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1117.1056, -537.07025, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(922.30493, -343.0899, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1075.3103, -2.9107056, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1600.4677, -78.92955, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1686.3848, -102.41921, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1644.1904, -477.38422, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1797.6575, -255.66599, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1657.6533, -348.40106, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1865.2727, -356.27094, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1760.8586, -418.06754, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1221.5309, -418.71027, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1836.2463, -108.58205, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1769.1902, -109.8, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1553.6333, -91.54741, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1757.007, -325.48813, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1728.2917, -233.45285, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1548.4572, -176.78867, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1081.2899, -439.2283, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1858.237, -229.48007, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-932.14545, -133.51872, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1115.8577, -369.0752, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1539.0287, -408.7987, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1562.6255, -294.65625, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1649.2101, -256.08026, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1478.9987, -729.86334, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1494.1968, -792.2295, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1512.3481, -680.8417, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1537.3468, -732.03174, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1511.547, -944.9394, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1274.9951, -1061.5625, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1204.7639, -1099.3452, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1237.1881, -1130.6731, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1269.791, -1105.2454, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1324.3083, -1066.2471, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1484.599, -973.1119, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1421.8689, -944.4174, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1185.8588, -139.02316, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1095.6707, -87.83058, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1089.1211, -138.60141, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1121.0685, -212.41443, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1144.9438, -173.22298, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-1187.3049, -237.59305, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-911.7987, -387.9983, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-877.5514, -451.30847, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-849.756, -351.96893, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-882.4058, -261.88428, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-771.1814, -203.7287, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-815.06476, -286.46255, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-790.9862, -425.94238, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-734.9931, -398.2698, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-310.60446, -343.4327, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-287.9275, -281.76486, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-289.2153, -233.48517, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-335.8328, -271.56686, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-368.03302, -232.02402, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-379.89294, -333.8103, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-349.09943, -384.82663, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-363.38016, -319.48776, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-399.33557, -271.87354, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-411.9994, -374.48947, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-785.7294, 525.8283, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-649.74274, 645.62823, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-722.7642, 567.97595, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-569.99994, 486.5218, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-510.5448, 559.8427, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-428.87164, 724.2892, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-373.10858, 674.9172, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-310.59076, 649.52167, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-363.37793, 570.83496, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-347.56635, 474.69458, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-381.45493, 525.7334, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-394.26343, 433.3153, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-290.6682, 550.4592, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-304.2465, 486.70798, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-216.33347, 527.24536, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-198.9645, 444.87555, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-286.46515, 440.1639, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-131.92348, 506.51498, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-149.08739, 597.98444, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-76.58421, 645.38055, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-15.385983, 682.7323, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(77.13176, 676.4375, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(63.843803, 469.2906, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(35.811325, 519.5746, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(116.90396, 502.0935, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(113.23567, 457.324, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(118.12009, 553.2983, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(74.73384, 609.41187, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(131.48267, 624.8666, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(185.07791, 568.3859, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(179.6796, 480.5579, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(247.27438, 501.91086, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(268.2882, 575.2836, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-566.70215, 1075.9146, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-491.83334, 1185.9156, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-553.2248, 1225.4517, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-602.72375, 1260.8971, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-664.2391, 1230.5503, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-636.6595, 1199.3811, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-686.66565, 1135.9078, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-653.6939, 1083.1211, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(-557.5586, 1120.1392, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(335.02078, 492.3647, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(382.92, 455.8333, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(473.9348, 621.58887, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(504.5277, 573.7807, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(562.2664, 431.11768, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(476.68002, 393.94055, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(553.94073, 537.1055, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(594.41504, 449.69147, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(632.696, 475.13632, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(703.8004, 535.72296, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(771.1622, 553.1042, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(766.47754, 594.3323, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(830.69775, 632.38416, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(889.4848, 595.0931, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(931.30994, 623.9978, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1015.9279, 579.8937, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1052.0701, 637.5814, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1276.8132, 588.69257, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1360.3496, 633.66895, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1390.1522, 583.2772, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1372.8667, 512.14655, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1436.1979, 609.4001, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1386.2373, 671.84357, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1419.5251, 714.5489, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1409.8246, 772.5407, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1352.9823, 732.8178, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1272.1228, 731.076, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1309.7242, 673.64233, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1283.6754, 634.8336, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1239.8813, -61.995586, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1281.4127, -121.45423, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1303.3757, -195.03268, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1214.5215, -111.00471, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1238.8551, -233.79985, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1167.6732, -238.7995, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(968.7964, -36.126907, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1099.5657, -127.73618, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1030.5021, -238.15112, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(957.721, -173.63715, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(870.4477, -201.24075, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(837.72955, -271.05078, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1018.7297, -375.3952, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(856.70795, -416.29443, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(965.578, -469.03415, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(943.25336, -588.57654, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1069.3665, -628.8689, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1128.5978, -351.20328, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1133.3185, -477.0667, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1194.1349, -417.17764, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1179.9067, -553.2223, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1260.8566, -434.1737, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1253.2688, -376.13712, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1389.4718, -435.3915, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1188.3533, -572.2456, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1516.796, -154.9428, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1862.741, -123.68058, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1723.5068, -216.47606, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1742.2136, -146.68332, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1816.0029, -341.89554, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1123.7577, -812.02515, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1036.9075, -785.74384, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1065.9901, -861.4755, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1083.4376, -950.7035, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(901.63544, -1021.8033, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1253.366, -885.01013, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1039.4772, -1050.0897, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(906.85956, -923.676, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(922.4896, -1099.7106, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1007.4984, -996.7206, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(987.3325, -907.3368, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(799.1143, -835.3565, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(853.2025, -788.2263, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(1004.977, -500.50476, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(559.9113, -755.11707, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(496.6529, -765.28204, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(377.7541, -823.28467, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(284.6281, -765.6575, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(351.84, -703.9518, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(372.2745, -549.34326, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(460.16724, -588.18756, 30));
		AddSpawnPoint("f_orchard_34_3.Id4", "f_orchard_34_3", Rectangle(512.8531, -639.51276, 30));

		// 'Rafflesia_Green' GenType 30 Spawn Points
		AddSpawnPoint("f_orchard_34_3.Id5", "f_orchard_34_3", Rectangle(-365.58777, -145.2789, 9999));

		// 'Flying_Flog_White' GenType 31 Spawn Points
		AddSpawnPoint("f_orchard_34_3.Id6", "f_orchard_34_3", Rectangle(444.31985, -693.07434, 200));

		// 'Rootcrystal_01' GenType 38 Spawn Points
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(-1459.7637, -979.88116, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(-1671.5911, -304.15982, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(-1147.2056, -248.8394, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(-797.53503, -271.24646, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(-378.3416, -254.94815, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(-262.13885, -855.83594, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(381.0048, -680.26904, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(1007.5905, -911.8131, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(1305.0881, -331.19144, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(965.7677, -419.12582, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(1758.4276, -288.10248, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(815.4593, 175.1571, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(1155.4761, 662.09033, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(655.5928, 582.63196, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(0.66023254, 504.34717, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(-77.80029, 128.10059, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(-598.6613, 1238.6108, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(-647.79553, 620.8363, 100));
		AddSpawnPoint("f_orchard_34_3.Id7", "f_orchard_34_3", Rectangle(-1366.9615, 500.8413, 100));
	}
}
