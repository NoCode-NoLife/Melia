//--- Melia Script -----------------------------------------------------------
// ep13_f_siauliai_5
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Kirtimas Forest' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep13FSiauliai5MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep13_f_siauliai_5", MonsterId.Elgesys_Guard, Properties("MHP", 977580, "MINPATK", 13071, "MAXPATK", 15968, "MINMATK", 13071, "MAXMATK", 15968, "DEF", 449889, "MDEF", 449889));
		AddPropertyOverrides("ep13_f_siauliai_5", MonsterId.Elgesys_Malkos, Properties("MHP", 983576, "MINPATK", 13148, "MAXPATK", 16063, "MINMATK", 13148, "MAXMATK", 16063, "DEF", 456685, "MDEF", 456685));
		AddPropertyOverrides("ep13_f_siauliai_5", MonsterId.Elgesys_Collecter, Properties("MHP", 989741, "MINPATK", 13228, "MAXPATK", 16160, "MINMATK", 13228, "MAXMATK", 16160, "DEF", 463672, "MDEF", 463672));
		AddPropertyOverrides("ep13_f_siauliai_5", MonsterId.Darbas_Smuggler, Properties("MHP", 996070, "MINPATK", 13309, "MAXPATK", 16260, "MINMATK", 13309, "MAXMATK", 16260, "DEF", 470846, "MDEF", 470846));

		// Monster Spawners ---------------------------------

		AddSpawner("ep13_f_siauliai_5.Id1", MonsterId.Rootcrystal_01, 19, 25, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id2", MonsterId.Elgesys_Guard, 3, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id3", MonsterId.Elgesys_Guard, 3, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id4", MonsterId.Elgesys_Guard, 3, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id5", MonsterId.Elgesys_Guard, 3, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id6", MonsterId.Elgesys_Guard, 3, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id7", MonsterId.Elgesys_Guard, 3, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id8", MonsterId.Elgesys_Malkos, 8, 10, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id9", MonsterId.Elgesys_Malkos, 8, 10, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id10", MonsterId.Elgesys_Malkos, 4, 5, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id11", MonsterId.Elgesys_Malkos, 15, 20, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id12", MonsterId.Elgesys_Collecter, 38, 50, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id13", MonsterId.Darbas_Smuggler, 6, 7, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id14", MonsterId.Darbas_Smuggler, 3, 3, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id15", MonsterId.Darbas_Smuggler, 4, 5, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id16", MonsterId.Darbas_Smuggler, 4, 5, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id17", MonsterId.Darbas_Smuggler, 3, 3, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id18", MonsterId.Darbas_Smuggler, 3, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id19", MonsterId.Darbas_Smuggler, 4, 5, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id20", MonsterId.Darbas_Smuggler, 3, 3, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id21", MonsterId.Elgesys_Malkos, 3, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 2 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(49.89821, -851.542, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-205.20706, -813.4324, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-454.71667, -743.6953, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-811.90204, -688.681, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-735.1485, -486.02008, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-1019.5267, -511.829, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-711.497, -261.17584, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-736.5533, -29.856749, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-815.8691, 188.06247, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-631.7733, 221.65501, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-769.4127, 434.81097, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-706.0164, 717.18256, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-426.97977, 681.7888, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(-115.58217, 754.9208, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(131.83041, 858.35724, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(100.02028, 609.03644, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(307.63336, 680.99335, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(521.4702, 462.92404, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(717.85364, 269.62082, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(980.29767, 124.45446, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(112.98901, 2.923418, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(63.08525, -301.9678, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(868.4773, -63.23078, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(338.15134, -750.3728, 200));
		AddSpawnPoint("ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Rectangle(446.35278, -17.772694, 200));

		// 'Elgesys_Guard' GenType 1000 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id2", "ep13_f_siauliai_5", Rectangle(-64.32052, -847.0545, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id2", "ep13_f_siauliai_5", Rectangle(156.96066, -888.7449, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id2", "ep13_f_siauliai_5", Rectangle(53.450226, -609.72705, 20));

		// 'Elgesys_Guard' GenType 1001 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id3", "ep13_f_siauliai_5", Rectangle(-974.11865, -619.2698, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id3", "ep13_f_siauliai_5", Rectangle(-642.6138, -723.56824, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id3", "ep13_f_siauliai_5", Rectangle(-733.9013, -444.436, 20));

		// 'Elgesys_Guard' GenType 1002 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id4", "ep13_f_siauliai_5", Rectangle(-764.59753, 54.931892, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id4", "ep13_f_siauliai_5", Rectangle(-735.41296, 295.2749, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id4", "ep13_f_siauliai_5", Rectangle(-442.37436, 24.25875, 20));

		// 'Elgesys_Guard' GenType 1003 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id5", "ep13_f_siauliai_5", Rectangle(-59.625828, -135.9289, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id5", "ep13_f_siauliai_5", Rectangle(279.9938, -64.63391, 20));

		// 'Elgesys_Guard' GenType 1004 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id6", "ep13_f_siauliai_5", Rectangle(762.2344, 62.71357, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id6", "ep13_f_siauliai_5", Rectangle(923.013, 82.58544, 20));

		// 'Elgesys_Guard' GenType 1005 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id7", "ep13_f_siauliai_5", Rectangle(173.76044, 735.2063, 20));

		// 'Elgesys_Malkos' GenType 1006 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Rectangle(-904.2756, -715.05963, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Rectangle(-831.1065, -384.04874, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Rectangle(-563.07935, -635.5845, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Rectangle(-729.4796, -763.5824, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Rectangle(-842.292, -579.217, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Rectangle(-15.401414, -1136.3518, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Rectangle(-719.88116, -348.6164, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Rectangle(-734.3514, -150.14104, 20));

		// 'Elgesys_Malkos' GenType 1007 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id9", "ep13_f_siauliai_5", Rectangle(-20.995852, -935.9913, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id9", "ep13_f_siauliai_5", Rectangle(260.58032, -875.2324, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id9", "ep13_f_siauliai_5", Rectangle(60.888756, -716.6498, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id9", "ep13_f_siauliai_5", Rectangle(-709.33, -616.5356, 20));

		// 'Elgesys_Malkos' GenType 1008 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id10", "ep13_f_siauliai_5", Rectangle(47.654785, -170.279, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id10", "ep13_f_siauliai_5", Rectangle(218.80449, 56.304474, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id10", "ep13_f_siauliai_5", Rectangle(99.00275, 165.11975, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id10", "ep13_f_siauliai_5", Rectangle(161.9745, -142.97876, 20));

		// 'Elgesys_Malkos' GenType 1009 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-552.0689, -39.479782, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-574.97974, 226.83421, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-836.9941, 334.48056, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-1228.3274, -439.8136, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(134.43779, -1003.5569, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(110.90753, -345.33887, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-647.23846, 89.498634, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-206.98093, -845.1129, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-365.89804, -742.69086, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-688.20026, -45.44609, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-771.622, 194.73683, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-780.2124, -253.03622, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Rectangle(-1098.4797, -535.97266, 20));

		// 'Elgesys_Collecter' GenType 1010 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(-114.36336, -24.84742, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(-3.6575012, 40.969597, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(286.55542, -169.70786, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(357.30414, -7.8781357, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(149.53487, -3.6994553, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(926.70056, -32.12438, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(820.2569, 6.580879, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(704.8569, 194.09715, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(831.37665, 141.11449, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(728.1972, 358.05847, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(844.6016, 247.20276, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(634.0914, 363.65295, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(508.89575, 427.66858, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(370.3384, 568.3883, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(36.073006, 649.9277, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(177.9017, 652.8136, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(242.18051, 784.3325, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(62.53453, 777.18207, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(171.96393, 956.3067, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(-484.59097, 783.74054, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(-321.35428, 678.87915, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(122.25, -246.71573, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(2.0113297, -319.50388, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(97.955215, 312.43774, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(1173.949, 179.14412, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(-626.50964, 760.89777, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(488.9818, 575.55475, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(975.85925, -166.7263, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(936.35205, -288.68015, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Rectangle(-330.62894, 23.495735, 20));

		// 'Darbas_Smuggler' GenType 1011 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Rectangle(196.10718, -689.01196, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Rectangle(278.81982, -757.6525, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Rectangle(-258.59277, -700.15344, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Rectangle(-160.25296, -633.94653, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Rectangle(330.19595, -858.52704, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Rectangle(197.50241, -783.6522, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Rectangle(-163.94719, -734.0629, 20));

		// 'Darbas_Smuggler' GenType 1012 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id14", "ep13_f_siauliai_5", Rectangle(-110.36999, -1020.5253, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id14", "ep13_f_siauliai_5", Rectangle(-144.92197, -929.99585, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id14", "ep13_f_siauliai_5", Rectangle(-43.786694, -1016.8705, 20));

		// 'Darbas_Smuggler' GenType 1013 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id15", "ep13_f_siauliai_5", Rectangle(-663.6493, -443.25238, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id15", "ep13_f_siauliai_5", Rectangle(-631.10144, -548.8885, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id15", "ep13_f_siauliai_5", Rectangle(-980.55804, -390.1883, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id15", "ep13_f_siauliai_5", Rectangle(-1050.472, -434.48413, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id15", "ep13_f_siauliai_5", Rectangle(-928.79956, -475.29413, 20));

		// 'Darbas_Smuggler' GenType 1014 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id16", "ep13_f_siauliai_5", Rectangle(-566.06714, 320.7806, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id16", "ep13_f_siauliai_5", Rectangle(-597.8533, 435.97223, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id16", "ep13_f_siauliai_5", Rectangle(-860.48114, -123.8692, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id16", "ep13_f_siauliai_5", Rectangle(-819.6799, -69.51857, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id16", "ep13_f_siauliai_5", Rectangle(-691.2564, 410.65683, 20));

		// 'Darbas_Smuggler' GenType 1015 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id17", "ep13_f_siauliai_5", Rectangle(-906.99713, 58.9837, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id17", "ep13_f_siauliai_5", Rectangle(-851.5561, 93.05151, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id17", "ep13_f_siauliai_5", Rectangle(-865.4743, 198.94582, 20));

		// 'Darbas_Smuggler' GenType 1016 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id18", "ep13_f_siauliai_5", Rectangle(-780.0026, 764.84827, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id18", "ep13_f_siauliai_5", Rectangle(-845.2846, 775.3874, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id18", "ep13_f_siauliai_5", Rectangle(-723.2574, 807.8091, 20));

		// 'Darbas_Smuggler' GenType 1017 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id19", "ep13_f_siauliai_5", Rectangle(39.37888, 881.08057, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id19", "ep13_f_siauliai_5", Rectangle(-58.67925, 829.69714, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id19", "ep13_f_siauliai_5", Rectangle(316.0537, 772.208, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id19", "ep13_f_siauliai_5", Rectangle(360.31906, 695.78827, 20));

		// 'Darbas_Smuggler' GenType 1018 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id20", "ep13_f_siauliai_5", Rectangle(1021.9748, 93.06753, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id20", "ep13_f_siauliai_5", Rectangle(1013.9377, -13.71647, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id20", "ep13_f_siauliai_5", Rectangle(1069.3862, 161.10046, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id20", "ep13_f_siauliai_5", Rectangle(-780.06537, 437.66855, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id20", "ep13_f_siauliai_5", Rectangle(-743.8825, 542.86694, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id20", "ep13_f_siauliai_5", Rectangle(-725.72705, 664.4087, 20));

		// 'Elgesys_Malkos' GenType 1019 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_5.Id21", "ep13_f_siauliai_5", Rectangle(645.3276, -657.4748, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id21", "ep13_f_siauliai_5", Rectangle(882.71295, -401.06393, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id21", "ep13_f_siauliai_5", Rectangle(519.52515, -687.57275, 20));
		AddSpawnPoint("ep13_f_siauliai_5.Id21", "ep13_f_siauliai_5", Rectangle(840.2, -521.0216, 20));
	}
}
