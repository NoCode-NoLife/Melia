//--- Melia Script -----------------------------------------------------------
// f_coral_32_1
//
//--- Description -----------------------------------------------------------
// Sets up the f_coral_32_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCoral321MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_coral_32_1.Id1", MonsterId.TerraNymph_Blue, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_32_1.Id2", MonsterId.Greentoshell, 70, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_32_1.Id3", MonsterId.Lapasape_Mage_Blue, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_32_1.Id4", MonsterId.Greentoshell, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_coral_32_1.Id5", MonsterId.Rootcrystal_01, 12, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// TerraNymph_Blue Spawn Points
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(428.6889, -832.4957, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(957.2192, -284.9651, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(905.5864, -473.55176, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(891.3563, -351.67706, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(317.24164, -741.11255, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(645.8351, -1139.9755, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(771.47003, -978.07556, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(266.65405, -959.34045, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(841.7229, -1133.954, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(204.2631, -786.8196, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(10.732574, -65.56866, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(451.21567, -138.32924, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(895.1295, 773.0369, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(1056.945, 1039.6951, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(1207.8573, 1182.27, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(1091.6283, 663.69666, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(-1.9367256, 169.96155, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(-472.29706, -235.80212, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(-355.04218, 272.31995, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(-584.0454, -44.04671, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(-229.27208, -229.41473, 25));
		AddSpawnPoint( "f_coral_32_1.Id1", "f_coral_32_1", Spot(1294.1598, 863.4395, 25));

		// Greentoshell Spawn Points
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(434.34637, -812.5621, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(539.62195, 142.62126, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(76.635254, 145.96808, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(28.567884, 366.64322, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(-301.3149, 616.60565, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(-79.48471, 805.0726, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(-196.60506, 611.0827, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(-174.36546, 726.4115, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(504.97168, 270.6894, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(765.3441, 485.65628, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(551.43036, -207.96768, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(78.99919, -89.46593, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(-388.78723, 497.54102, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(-211.84119, 114.0751, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(366.29065, -904.14166, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(478.5501, -476.9796, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(485.89453, -637.3577, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(960.9409, 793.4156, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(1073.2787, 1165.9238, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(1281.0248, 760.8054, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(1410.3313, 972.3665, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(839.9948, 591.5356, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(1157.7074, -309.54672, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(908.86945, -322.84567, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(1108.0626, -236.68396, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(1424.3223, -49.83526, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(987.2585, -371.57733, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(802.825, -455.12616, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(882.00146, -246.65654, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(-355.12433, 6.706127, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(-651.9579, -157.59926, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(-388.00882, -336.1329, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(328.56326, -838.2338, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(214.81693, -679.01337, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(1207.0479, 862.0129, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(729.30676, -1085.9814, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(854.64105, -1030.1022, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(1156.4221, 1020.8922, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(368.89618, 183.86966, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(390.59372, -390.07446, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(-47.414696, -38.71925, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(1262.759, 1064.8646, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(168.49886, -904.01404, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(640.01746, -1247.088, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(841.15533, -383.8366, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(846.1668, 795.37976, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(-278.344, 829.86774, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(385.0522, 344.52185, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(-60.254154, 634.6289, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(149.69693, -789.9175, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(819.3013, -875.15015, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(773.6997, -943.685, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(355.1347, -723.78436, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(817.44446, -1144.3916, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(640.62354, -1060.9109, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(372.6221, 0.38910484, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(-275.0379, -89.47915, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(734.92896, -1310.608, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(-582.16376, -272.34845, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(670.8514, -25.08035, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(885.5439, -1282.6595, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(1096.738, 654.4617, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(715.5963, 406.8626, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(879.2366, -1205.1, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(952.8186, 998.57336, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(991.596, -1172.4977, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(760.46625, 151.46463, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(-222.97919, -287.52185, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(939.20807, -1032.6935, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(1144.033, -457.78015, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(608.64075, -1172.7404, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(402.333, -232.07326, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(503.44788, -979.2716, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(523.658, -907.7953, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(218.48827, -984.7667, 25));
		AddSpawnPoint( "f_coral_32_1.Id2", "f_coral_32_1", Spot(404.21365, -903.0741, 25));

		// Lapasape_Mage_Blue Spawn Points
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(457.06738, -984.31836, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(809.069, -354.25793, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(396.93607, 267.72437, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(1005.8244, -462.34445, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(1234.1495, -394.18445, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(1233.1365, -243.22977, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(1478.7408, -15.596283, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(1120.5306, 849.5473, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(1242.9166, 1027.9349, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(-27.492495, 113.79046, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(388.2475, -276.6311, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(534.3728, -354.83298, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(151.75302, -865.8903, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(759.23865, -1043.5292, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(796.9939, -1224.646, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(75.16781, 221.4825, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(-101.04425, -77.521065, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(564.0029, 94.23512, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(653.33154, 412.15967, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(227.6126, -678.0264, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(674.9648, -1250.2742, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(-210.69109, 746.4398, 25));
		AddSpawnPoint( "f_coral_32_1.Id3", "f_coral_32_1", Spot(741.8089, -1128.4291, 25));

		// Greentoshell Spawn Points
		AddSpawnPoint( "f_coral_32_1.Id4", "f_coral_32_1", Spot(-384.94904, -17.679047, 25));
		AddSpawnPoint( "f_coral_32_1.Id4", "f_coral_32_1", Spot(-387.15247, -183.2413, 25));
		AddSpawnPoint( "f_coral_32_1.Id4", "f_coral_32_1", Spot(-627.6507, -180.29129, 25));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_coral_32_1.Id5", "f_coral_32_1", Spot(-277.4293, 256.91095, 150));
		AddSpawnPoint( "f_coral_32_1.Id5", "f_coral_32_1", Spot(258.92206, -866.89056, 150));
		AddSpawnPoint( "f_coral_32_1.Id5", "f_coral_32_1", Spot(1549.3285, -36.423958, 150));
		AddSpawnPoint( "f_coral_32_1.Id5", "f_coral_32_1", Spot(891.5041, -1069.7263, 150));
		AddSpawnPoint( "f_coral_32_1.Id5", "f_coral_32_1", Spot(404.93774, -378.19305, 150));
		AddSpawnPoint( "f_coral_32_1.Id5", "f_coral_32_1", Spot(832.344, -338.8279, 150));
		AddSpawnPoint( "f_coral_32_1.Id5", "f_coral_32_1", Spot(635.24945, 199.4323, 150));
		AddSpawnPoint( "f_coral_32_1.Id5", "f_coral_32_1", Spot(1301.1882, 959.4325, 150));
		AddSpawnPoint( "f_coral_32_1.Id5", "f_coral_32_1", Spot(-55.64003, 728.9261, 150));
		AddSpawnPoint( "f_coral_32_1.Id5", "f_coral_32_1", Spot(33.318428, 308.41766, 150));
		AddSpawnPoint( "f_coral_32_1.Id5", "f_coral_32_1", Spot(-567.2186, -264.79767, 150));

	}
}
