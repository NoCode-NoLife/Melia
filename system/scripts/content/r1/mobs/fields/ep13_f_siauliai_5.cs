//--- Melia Script -----------------------------------------------------------
// ep13_f_siauliai_5
//
//--- Description -----------------------------------------------------------
// Sets up the ep13_f_siauliai_5 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep13FSiauliai5MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("ep13_f_siauliai_5", MonsterId.Elgesys_Guard, Properties("MHP", 977580, "MINPATK", 13071, "MAXPATK", 15968, "MINMATK", 13071, "MAXMATK", 15968, "DEF", 449889, "MDEF", 449889));
		AddPropertyOverrides("ep13_f_siauliai_5", MonsterId.Elgesys_Malkos, Properties("MHP", 983576, "MINPATK", 13148, "MAXPATK", 16063, "MINMATK", 13148, "MAXMATK", 16063, "DEF", 456685, "MDEF", 456685));
		AddPropertyOverrides("ep13_f_siauliai_5", MonsterId.Elgesys_Collecter, Properties("MHP", 989741, "MINPATK", 13228, "MAXPATK", 16160, "MINMATK", 13228, "MAXMATK", 16160, "DEF", 463672, "MDEF", 463672));
		AddPropertyOverrides("ep13_f_siauliai_5", MonsterId.Darbas_Smuggler, Properties("MHP", 996070, "MINPATK", 13309, "MAXPATK", 16260, "MINMATK", 13309, "MAXMATK", 16260, "DEF", 470846, "MDEF", 470846));

		// Monster Spawners --------------------------------

		AddSpawner("ep13_f_siauliai_5.Id1", MonsterId.Rootcrystal_01, 25, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id2", MonsterId.Elgesys_Guard, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id3", MonsterId.Elgesys_Guard, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id4", MonsterId.Elgesys_Guard, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id5", MonsterId.Elgesys_Guard, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id6", MonsterId.Elgesys_Guard, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id7", MonsterId.Elgesys_Guard, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id8", MonsterId.Elgesys_Malkos, 10, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id9", MonsterId.Elgesys_Malkos, 10, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id10", MonsterId.Elgesys_Malkos, 5, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id11", MonsterId.Elgesys_Malkos, 20, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id12", MonsterId.Elgesys_Collecter, 50, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id13", MonsterId.Darbas_Smuggler, 7, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id14", MonsterId.Darbas_Smuggler, 5, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id15", MonsterId.Darbas_Smuggler, 5, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id16", MonsterId.Darbas_Smuggler, 3, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id17", MonsterId.Darbas_Smuggler, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id18", MonsterId.Darbas_Smuggler, 5, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id19", MonsterId.Darbas_Smuggler, 3, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id20", MonsterId.Darbas_Smuggler, 3, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_5.Id21", MonsterId.Elgesys_Malkos, 4, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(49.89821, -851.542, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(-205.20706, -813.4324, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(-454.71667, -743.6953, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(-811.90204, -688.681, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(-735.1485, -486.02008, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(-1019.5267, -511.829, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(-711.497, -261.17584, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(-736.5533, -29.856749, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(-815.8691, 188.06247, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(-631.7733, 221.65501, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(-769.4127, 434.81097, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(-706.0164, 717.18256, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(-426.97977, 681.7888, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(-115.58217, 754.9208, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(131.83041, 858.35724, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(100.02028, 609.03644, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(307.63336, 680.99335, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(521.4702, 462.92404, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(717.85364, 269.62082, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(980.29767, 124.45446, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(112.98901, 2.923418, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(63.08525, -301.9678, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(868.4773, -63.23078, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(338.15134, -750.3728, 200));
		AddSpawnPoint( "ep13_f_siauliai_5.Id1", "ep13_f_siauliai_5", Spot(446.35278, -17.772694, 200));

		// Elgesys_Guard Spawn Points
		AddSpawnPoint( "ep13_f_siauliai_5.Id2", "ep13_f_siauliai_5", Spot(-64.32052, -847.0545, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id2", "ep13_f_siauliai_5", Spot(156.96066, -888.7449, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id2", "ep13_f_siauliai_5", Spot(53.450226, -609.72705, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id3", "ep13_f_siauliai_5", Spot(-974.11865, -619.2698, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id3", "ep13_f_siauliai_5", Spot(-642.6138, -723.56824, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id3", "ep13_f_siauliai_5", Spot(-733.9013, -444.436, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id4", "ep13_f_siauliai_5", Spot(-764.59753, 54.931892, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id4", "ep13_f_siauliai_5", Spot(-735.41296, 295.2749, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id4", "ep13_f_siauliai_5", Spot(-442.37436, 24.25875, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id5", "ep13_f_siauliai_5", Spot(-59.625828, -135.9289, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id5", "ep13_f_siauliai_5", Spot(279.9938, -64.63391, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id6", "ep13_f_siauliai_5", Spot(762.2344, 62.71357, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id6", "ep13_f_siauliai_5", Spot(923.013, 82.58544, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id7", "ep13_f_siauliai_5", Spot(173.76044, 735.2063, 20));

		// Elgesys_Malkos Spawn Points
		AddSpawnPoint( "ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Spot(-904.2756, -715.05963, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Spot(-831.1065, -384.04874, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Spot(-563.07935, -635.5845, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Spot(-729.4796, -763.5824, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Spot(-842.292, -579.217, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Spot(-15.401414, -1136.3518, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Spot(-719.88116, -348.6164, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id8", "ep13_f_siauliai_5", Spot(-734.3514, -150.14104, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id9", "ep13_f_siauliai_5", Spot(-20.995852, -935.9913, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id9", "ep13_f_siauliai_5", Spot(260.58032, -875.2324, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id9", "ep13_f_siauliai_5", Spot(60.888756, -716.6498, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id9", "ep13_f_siauliai_5", Spot(-709.33, -616.5356, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id10", "ep13_f_siauliai_5", Spot(47.654785, -170.279, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id10", "ep13_f_siauliai_5", Spot(218.80449, 56.304474, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id10", "ep13_f_siauliai_5", Spot(99.00275, 165.11975, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id10", "ep13_f_siauliai_5", Spot(161.9745, -142.97876, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Spot(-552.0689, -39.479782, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Spot(-574.97974, 226.83421, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Spot(-836.9941, 334.48056, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Spot(-1228.3274, -439.8136, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Spot(134.43779, -1003.5569, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Spot(110.90753, -345.33887, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Spot(-647.23846, 89.498634, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Spot(-206.98093, -845.1129, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Spot(-365.89804, -742.69086, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Spot(-688.20026, -45.44609, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Spot(-771.622, 194.73683, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Spot(-780.2124, -253.03622, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id11", "ep13_f_siauliai_5", Spot(-1098.4797, -535.97266, 20));

		// Elgesys_Collecter Spawn Points
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(-114.36336, -24.84742, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(-3.6575012, 40.969597, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(286.55542, -169.70786, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(357.30414, -7.8781357, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(149.53487, -3.6994553, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(926.70056, -32.12438, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(820.2569, 6.580879, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(704.8569, 194.09715, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(831.37665, 141.11449, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(728.1972, 358.05847, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(844.6016, 247.20276, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(634.0914, 363.65295, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(508.89575, 427.66858, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(370.3384, 568.3883, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(36.073006, 649.9277, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(177.9017, 652.8136, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(242.18051, 784.3325, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(62.53453, 777.18207, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(171.96393, 956.3067, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(-484.59097, 783.74054, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(-321.35428, 678.87915, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(122.25, -246.71573, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(2.0113297, -319.50388, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(97.955215, 312.43774, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(1173.949, 179.14412, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(-626.50964, 760.89777, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(488.9818, 575.55475, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(975.85925, -166.7263, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(936.35205, -288.68015, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id12", "ep13_f_siauliai_5", Spot(-330.62894, 23.495735, 20));

		// Darbas_Smuggler Spawn Points
		AddSpawnPoint( "ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Spot(196.10718, -689.01196, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Spot(278.81982, -757.6525, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Spot(-258.59277, -700.15344, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Spot(-160.25296, -633.94653, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Spot(330.19595, -858.52704, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Spot(197.50241, -783.6522, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id13", "ep13_f_siauliai_5", Spot(-163.94719, -734.0629, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id14", "ep13_f_siauliai_5", Spot(-663.6493, -443.25238, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id14", "ep13_f_siauliai_5", Spot(-631.10144, -548.8885, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id14", "ep13_f_siauliai_5", Spot(-980.55804, -390.1883, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id14", "ep13_f_siauliai_5", Spot(-1050.472, -434.48413, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id14", "ep13_f_siauliai_5", Spot(-928.79956, -475.29413, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id15", "ep13_f_siauliai_5", Spot(-566.06714, 320.7806, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id15", "ep13_f_siauliai_5", Spot(-597.8533, 435.97223, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id15", "ep13_f_siauliai_5", Spot(-860.48114, -123.8692, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id15", "ep13_f_siauliai_5", Spot(-819.6799, -69.51857, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id15", "ep13_f_siauliai_5", Spot(-691.2564, 410.65683, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id16", "ep13_f_siauliai_5", Spot(-906.99713, 58.9837, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id16", "ep13_f_siauliai_5", Spot(-851.5561, 93.05151, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id16", "ep13_f_siauliai_5", Spot(-865.4743, 198.94582, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id17", "ep13_f_siauliai_5", Spot(-780.0026, 764.84827, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id17", "ep13_f_siauliai_5", Spot(-845.2846, 775.3874, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id17", "ep13_f_siauliai_5", Spot(-723.2574, 807.8091, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id18", "ep13_f_siauliai_5", Spot(39.37888, 881.08057, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id18", "ep13_f_siauliai_5", Spot(-58.67925, 829.69714, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id18", "ep13_f_siauliai_5", Spot(316.0537, 772.208, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id18", "ep13_f_siauliai_5", Spot(360.31906, 695.78827, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id19", "ep13_f_siauliai_5", Spot(1021.9748, 93.06753, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id19", "ep13_f_siauliai_5", Spot(1013.9377, -13.71647, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id19", "ep13_f_siauliai_5", Spot(1069.3862, 161.10046, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id19", "ep13_f_siauliai_5", Spot(-780.06537, 437.66855, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id19", "ep13_f_siauliai_5", Spot(-743.8825, 542.86694, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id19", "ep13_f_siauliai_5", Spot(-725.72705, 664.4087, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id20", "ep13_f_siauliai_5", Spot(-110.36999, -1020.5253, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id20", "ep13_f_siauliai_5", Spot(-144.92197, -929.99585, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id20", "ep13_f_siauliai_5", Spot(-43.786694, -1016.8705, 20));

		// Elgesys_Malkos Spawn Points
		AddSpawnPoint( "ep13_f_siauliai_5.Id21", "ep13_f_siauliai_5", Spot(645.3276, -657.4748, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id21", "ep13_f_siauliai_5", Spot(882.71295, -401.06393, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id21", "ep13_f_siauliai_5", Spot(519.52515, -687.57275, 20));
		AddSpawnPoint( "ep13_f_siauliai_5.Id21", "ep13_f_siauliai_5", Spot(840.2, -521.0216, 20));

	}
}
