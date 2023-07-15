//--- Melia Script -----------------------------------------------------------
// ep15_1_f_abbey_2
//
//--- Description -----------------------------------------------------------
// Sets up the ep15_1_f_abbey_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep151FAbbey2MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("ep15_1_f_abbey_2", MonsterId.Ep15_1_Goblin_Rider, Properties("MHP", 53625000, "MINPATK", 130000, "MAXPATK", 130000, "MINMATK", 130000, "MAXMATK", 130000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep15_1_f_abbey_2", MonsterId.Ep15_1_Goblin_Fighter, Properties("MHP", 53625000, "MINPATK", 130000, "MAXPATK", 130000, "MINMATK", 130000, "MAXMATK", 130000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep15_1_f_abbey_2", MonsterId.Ep15_1_Goblin_Saman, Properties("MHP", 53625000, "MINPATK", 130000, "MAXPATK", 130000, "MINMATK", 130000, "MAXMATK", 130000, "DEF", 3000000, "MDEF", 3000000));

		// Monster Spawners --------------------------------

		AddSpawner("ep15_1_f_abbey_2.Id1", MonsterId.Ep15_1_Goblin_Rider, 60, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("ep15_1_f_abbey_2.Id2", MonsterId.Ep15_1_Goblin_Fighter, 60, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("ep15_1_f_abbey_2.Id3", MonsterId.Ep15_1_Goblin_Saman, 60, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Ep15_1_Goblin_Rider Spawn Points
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(80.582344, -142.64975, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(42.622547, -34.448975, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(-179.70035, -1167.0277, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(-45.20684, -1108.9502, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(-202.56645, -963.16675, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(-79.39059, -708.04236, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(-195.19353, -343.0303, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(-516.9449, -158.55994, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(-285.99753, -31.379639, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(-130.39577, 108.23129, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(-79.92603, 369.6563, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(119.37188, 692.0494, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(-41.05498, 845.2124, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(-316.6412, 688.474, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(-213.13823, 858.92017, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(-335.04483, 607.35394, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(473.6032, -192.79402, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(365.05774, -185.493, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(70.61568, -259.07443, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(-94.84483, -358.08237, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(-366.92065, -124.30956, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id1", "ep15_1_f_abbey_2", Spot(-187.7793, 77.87219, 20));

		// Ep15_1_Goblin_Fighter Spawn Points
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-84.68307, 352.81638, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(188.87106, 797.0332, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(350.70294, 738.9471, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(95.23461, 562.66266, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(23.33272, 782.65674, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-50.037758, 124.38875, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-125.87859, -525.3381, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-339.38248, -263.21182, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-706.8476, -126.87222, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-840.6726, -157.6718, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-974.8484, -177.60754, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-1019.5536, -338.55554, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-1076.729, -97.04154, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-991.6897, -21.177689, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-976.4592, 50.659744, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-968.1651, 111.00181, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-963.43555, 279.3454, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-970.97876, 463.66275, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(144.04077, -99.14324, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(10.584502, 30.228941, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-238.53844, 29.087376, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(1.8717518, -323.23773, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(115.72579, -1003.949, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-271.8363, -1072.4031, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-75.661064, -949.15076, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(67.50464, -1135.716, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-288.5688, -384.18616, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-257.89532, -143.0549, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-67.89673, 481.50403, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-75.10591, 626.1374, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-559.02234, 639.3897, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-882.80194, 755.07776, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-322.55124, 922.0592, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-1213.7866, 1548.8357, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-1304.3376, 1801.3116, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(-1273.7601, 1665.2009, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(567.20776, 754.6401, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(578.9396, 971.12213, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(567.814, 1070.8041, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id2", "ep15_1_f_abbey_2", Spot(582.20337, 885.75726, 20));

		// Ep15_1_Goblin_Saman Spawn Points
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-722.6187, 632.2692, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-663.2487, 828.7334, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-1164.2223, 733.46045, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-1197.4001, 864.90344, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-894.77295, 863.28815, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-986.4664, 997.80963, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-378.24994, 800.5585, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-180.95197, 939.13947, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-132.57413, 688.23444, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-528.8895, 792.47327, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-706.3204, 745.243, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-898.2479, 612.42303, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-958.25854, 467.6576, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-966.425, 368.6695, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-955.2253, 279.84558, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-1220.2948, 631.425, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-1001.5936, 1103.3485, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-1038.8123, 1290.6908, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-1158.7025, 1582.4227, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-1203.4669, 1707.6611, 20));
		AddSpawnPoint( "ep15_1_f_abbey_2.Id3", "ep15_1_f_abbey_2", Spot(-1207.3436, 1785.3635, 20));

	}
}
