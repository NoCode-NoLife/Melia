//--- Melia Script -----------------------------------------------------------
// ep14_2_d_castle_2
//
//--- Description -----------------------------------------------------------
// Sets up the ep14_2_d_castle_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep142DCastle2MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("ep14_2_d_castle_2", MonsterId.Episode14_2_GresmeCrow, Properties("MHP", 48750000, "MINPATK", 110000, "MAXPATK", 110000, "MINMATK", 110000, "MAXMATK", 110000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep14_2_d_castle_2", MonsterId.Episode14_2_Bleakferret_Lancer, Properties("MHP", 48750000, "MINPATK", 110000, "MAXPATK", 110000, "MINMATK", 110000, "MAXMATK", 110000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep14_2_d_castle_2", MonsterId.Episode14_2_Bleakferret_Strange, Properties("MHP", 48750000, "MINPATK", 110000, "MAXPATK", 110000, "MINMATK", 110000, "MAXMATK", 110000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep14_2_d_castle_2", MonsterId.Episode14_2_Bleakferret_Scout, Properties("MHP", 48750000, "MINPATK", 110000, "MAXPATK", 110000, "MINMATK", 110000, "MAXMATK", 110000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep14_2_d_castle_2", MonsterId.Episode14_2_GresmeBird, Properties("MHP", 48750000, "MINPATK", 110000, "MAXPATK", 110000, "MINMATK", 110000, "MAXMATK", 110000, "DEF", 3000000, "MDEF", 3000000));

		// Monster Populations
		AddMonsterPopulation("ep14_2_d_castle_2", "population_rootcrystal_05_1", 19);
		AddMonsterPopulation("ep14_2_d_castle_2", "population_episode14_2_gresmecrow_2", 25);
		AddMonsterPopulation("ep14_2_d_castle_2", "population_episode14_2_bleakferret_lancer_3", 30);
		AddMonsterPopulation("ep14_2_d_castle_2", "population_episode14_2_bleakferret_strange_4", 15);
		AddMonsterPopulation("ep14_2_d_castle_2", "population_episode14_2_bleakferret_scout_5", 30);
		AddMonsterPopulation("ep14_2_d_castle_2", "population_episode14_2_gresmebird_6", 25);

		// RootCrystal Spawners
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(20000), "ep14_2_d_castle_2", Spot(940.5367, -587.7605, 200));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(20000), "ep14_2_d_castle_2", Spot(910.6065, 638.28754, 200));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(20000), "ep14_2_d_castle_2", Spot(311.11664, 637.208, 200));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(20000), "ep14_2_d_castle_2", Spot(-585.1591, 663.2149, 200));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(20000), "ep14_2_d_castle_2", Spot(-835.47864, 688.13245, 200));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(20000), "ep14_2_d_castle_2", Spot(-783.2917, -906.9025, 200));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(20000), "ep14_2_d_castle_2", Spot(942.99884, 37.622707, 200));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(20000), "ep14_2_d_castle_2", Spot(-793.2637, -216.16153, 200));
		AddSpawner(MonsterId.Rootcrystal_05, "population_rootcrystal_05_1", TimeSpan.FromMilliseconds(20000), "ep14_2_d_castle_2", Spot(-152.82462, 635.01056, 200));

		// Monster Spawners
		AddSpawner(MonsterId.Episode14_2_GresmeCrow, "population_episode14_2_gresmecrow_2", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(447.92038, -1029.6832, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeCrow, "population_episode14_2_gresmecrow_2", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(532.4943, -743.59546, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeCrow, "population_episode14_2_gresmecrow_2", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(922.7152, -1151.1318, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeCrow, "population_episode14_2_gresmecrow_2", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(759.0044, -602.19666, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeCrow, "population_episode14_2_gresmecrow_2", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(1016.9126, -175.90854, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeCrow, "population_episode14_2_gresmecrow_2", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(876.6878, 260.23044, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeCrow, "population_episode14_2_gresmecrow_2", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(946.338, 431.26978, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeCrow, "population_episode14_2_gresmecrow_2", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(836.0472, 723.73975, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeCrow, "population_episode14_2_gresmecrow_2", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(1113.8759, 587.0562, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeCrow, "population_episode14_2_gresmecrow_2", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(353.63428, 470.13947, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeCrow, "population_episode14_2_gresmecrow_2", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(81.2879, 934.7153, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeCrow, "population_episode14_2_gresmecrow_2", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-239.6982, 415.6793, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeCrow, "population_episode14_2_gresmecrow_2", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-1280.2949, 569.4791, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeCrow, "population_episode14_2_gresmecrow_2", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-731.51276, 687.4318, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeCrow, "population_episode14_2_gresmecrow_2", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-867.4575, 380.182, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeCrow, "population_episode14_2_gresmecrow_2", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-738.0439, -504.44678, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeCrow, "population_episode14_2_gresmecrow_2", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-734.1893, -1142.0154, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeCrow, "population_episode14_2_gresmecrow_2", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-1256.7598, -845.13, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Lancer, "population_episode14_2_bleakferret_lancer_3", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(843.36597, -860.09753, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Lancer, "population_episode14_2_bleakferret_lancer_3", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(840.9878, -662.1172, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Lancer, "population_episode14_2_bleakferret_lancer_3", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(1026.4318, -569.4005, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Lancer, "population_episode14_2_bleakferret_lancer_3", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(863.4343, -424.87082, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Lancer, "population_episode14_2_bleakferret_lancer_3", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(1019.2653, -370.29492, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Lancer, "population_episode14_2_bleakferret_lancer_3", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(659.4847, -728.01904, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Lancer, "population_episode14_2_bleakferret_lancer_3", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(1235.4192, -576.3789, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Lancer, "population_episode14_2_bleakferret_lancer_3", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(94.68561, 350.82623, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Lancer, "population_episode14_2_bleakferret_lancer_3", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-189.74106, 810.7109, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Lancer, "population_episode14_2_bleakferret_lancer_3", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(15.249821, 892.7163, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Lancer, "population_episode14_2_bleakferret_lancer_3", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-949.0721, 567.87195, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Lancer, "population_episode14_2_bleakferret_lancer_3", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(1558.9236, 711.0329, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Strange, "population_episode14_2_bleakferret_strange_4", TimeSpan.FromMilliseconds(15000), "ep14_2_d_castle_2", Spot(783.57465, -1155.2202, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Strange, "population_episode14_2_bleakferret_strange_4", TimeSpan.FromMilliseconds(15000), "ep14_2_d_castle_2", Spot(907.77026, -1031.7345, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Strange, "population_episode14_2_bleakferret_strange_4", TimeSpan.FromMilliseconds(15000), "ep14_2_d_castle_2", Spot(1469.6937, -495.361, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Strange, "population_episode14_2_bleakferret_strange_4", TimeSpan.FromMilliseconds(15000), "ep14_2_d_castle_2", Spot(1299.2819, -644.32513, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Strange, "population_episode14_2_bleakferret_strange_4", TimeSpan.FromMilliseconds(15000), "ep14_2_d_castle_2", Spot(413.44217, -1146.0428, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Strange, "population_episode14_2_bleakferret_strange_4", TimeSpan.FromMilliseconds(15000), "ep14_2_d_castle_2", Spot(520.16235, -573.451, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Strange, "population_episode14_2_bleakferret_strange_4", TimeSpan.FromMilliseconds(15000), "ep14_2_d_castle_2", Spot(870.83563, -135.42326, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Strange, "population_episode14_2_bleakferret_strange_4", TimeSpan.FromMilliseconds(15000), "ep14_2_d_castle_2", Spot(1032.3689, 246.96336, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Strange, "population_episode14_2_bleakferret_strange_4", TimeSpan.FromMilliseconds(15000), "ep14_2_d_castle_2", Spot(1566.4048, 557.26917, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Strange, "population_episode14_2_bleakferret_strange_4", TimeSpan.FromMilliseconds(15000), "ep14_2_d_castle_2", Spot(1408.0525, 719.65686, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Strange, "population_episode14_2_bleakferret_strange_4", TimeSpan.FromMilliseconds(15000), "ep14_2_d_castle_2", Spot(-146.55722, 372.14526, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Strange, "population_episode14_2_bleakferret_strange_4", TimeSpan.FromMilliseconds(15000), "ep14_2_d_castle_2", Spot(345.06577, 362.8435, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Strange, "population_episode14_2_bleakferret_strange_4", TimeSpan.FromMilliseconds(15000), "ep14_2_d_castle_2", Spot(319.44046, 893.8298, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Strange, "population_episode14_2_bleakferret_strange_4", TimeSpan.FromMilliseconds(15000), "ep14_2_d_castle_2", Spot(-127.64193, 904.88184, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Strange, "population_episode14_2_bleakferret_strange_4", TimeSpan.FromMilliseconds(15000), "ep14_2_d_castle_2", Spot(-947.99164, 667.0899, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Strange, "population_episode14_2_bleakferret_strange_4", TimeSpan.FromMilliseconds(15000), "ep14_2_d_castle_2", Spot(-654.6544, 678.5796, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Strange, "population_episode14_2_bleakferret_strange_4", TimeSpan.FromMilliseconds(15000), "ep14_2_d_castle_2", Spot(-804.37836, -19.900267, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Strange, "population_episode14_2_bleakferret_strange_4", TimeSpan.FromMilliseconds(15000), "ep14_2_d_castle_2", Spot(-803.65137, -684.5064, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Strange, "population_episode14_2_bleakferret_strange_4", TimeSpan.FromMilliseconds(15000), "ep14_2_d_castle_2", Spot(-1353.9746, -750.0806, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Strange, "population_episode14_2_bleakferret_strange_4", TimeSpan.FromMilliseconds(15000), "ep14_2_d_castle_2", Spot(-1458.0928, 572.6065, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Scout, "population_episode14_2_bleakferret_scout_5", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(1404.5548, 535.0668, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Scout, "population_episode14_2_bleakferret_scout_5", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-49.36698, 824.37024, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Scout, "population_episode14_2_bleakferret_scout_5", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-180.32353, 492.47556, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Scout, "population_episode14_2_bleakferret_scout_5", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(259.74847, 386.19705, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Scout, "population_episode14_2_bleakferret_scout_5", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-790.178, 552.661, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Scout, "population_episode14_2_bleakferret_scout_5", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(342.4493, 820.6413, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Scout, "population_episode14_2_bleakferret_scout_5", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-1284.8197, 742.76636, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Scout, "population_episode14_2_bleakferret_scout_5", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-808.4646, 947.7677, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Scout, "population_episode14_2_bleakferret_scout_5", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-850.8457, -359.34183, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Scout, "population_episode14_2_bleakferret_scout_5", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-720.5261, 187.83629, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Scout, "population_episode14_2_bleakferret_scout_5", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-711.588, -896.7641, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Scout, "population_episode14_2_bleakferret_scout_5", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-866.88715, -1156.4207, 20));
		AddSpawner(MonsterId.Episode14_2_Bleakferret_Scout, "population_episode14_2_bleakferret_scout_5", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-1423.5482, -861.5344, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeBird, "population_episode14_2_gresmebird_6", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(388.5844, -571.7109, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeBird, "population_episode14_2_gresmebird_6", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(748.71875, -1007.9855, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeBird, "population_episode14_2_gresmebird_6", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(862.5493, -255.13205, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeBird, "population_episode14_2_gresmebird_6", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(972.5347, -684.88116, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeBird, "population_episode14_2_gresmebird_6", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(1312.4838, -459.30844, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeBird, "population_episode14_2_gresmebird_6", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(868.079, 81.81081, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeBird, "population_episode14_2_gresmebird_6", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(845.51337, 554.69055, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeBird, "population_episode14_2_gresmebird_6", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(1033.8523, 724.2484, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeBird, "population_episode14_2_gresmebird_6", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(943.93567, 966.7089, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeBird, "population_episode14_2_gresmebird_6", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-71.336555, 413.2356, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeBird, "population_episode14_2_gresmebird_6", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(247.93245, 407.4597, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeBird, "population_episode14_2_gresmebird_6", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(229.15987, 859.27026, 20));
		AddSpawner(MonsterId.Episode14_2_GresmeBird, "population_episode14_2_gresmebird_6", TimeSpan.FromMilliseconds(10000), "ep14_2_d_castle_2", Spot(-27.556389, 810.18555, 20));

	}
}
