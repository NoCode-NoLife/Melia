//--- Melia Script -----------------------------------------------------------
// d_startower_89
//
//--- Description -----------------------------------------------------------
// Sets up the d_startower_89 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DStartower89MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_startower_89", MonsterId.Naste, Properties("MHP", 617472, "MINPATK", 8441, "MAXPATK", 10276, "MINMATK", 8441, "MAXMATK", 10276, "DEF", 138272, "MDEF", 138272));
		AddPropertyOverrides("d_startower_89", MonsterId.Gleamlens, Properties("MHP", 619027, "MINPATK", 8461, "MAXPATK", 10301, "MINMATK", 8461, "MAXMATK", 10301, "DEF", 139204, "MDEF", 139204));
		AddPropertyOverrides("d_startower_89", MonsterId.Wryer, Properties("MHP", 620619, "MINPATK", 8481, "MAXPATK", 10326, "MINMATK", 8481, "MAXMATK", 10326, "DEF", 140157, "MDEF", 140157));
		AddPropertyOverrides("d_startower_89", MonsterId.Rabbler, Properties("MHP", 622245, "MINPATK", 8502, "MAXPATK", 10352, "MINMATK", 8502, "MAXMATK", 10352, "DEF", 141131, "MDEF", 141131));

		// Monster Spawners --------------------------------

		AddSpawner("d_startower_89.Id1", MonsterId.Naste, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_89.Id2", MonsterId.Gleamlens, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_89.Id3", MonsterId.Wryer, 27, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_89.Id4", MonsterId.Rabbler, 47, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_89.Id5", MonsterId.Naste, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_89.Id6", MonsterId.Rootcrystal_02, 15, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Naste Spawn Points
		AddSpawnPoint( "d_startower_89.Id1", "d_startower_89", Spot(1358.7094, -1740.7318, 25));
		AddSpawnPoint( "d_startower_89.Id1", "d_startower_89", Spot(1531.8864, -1645.7468, 25));
		AddSpawnPoint( "d_startower_89.Id1", "d_startower_89", Spot(1516.9968, -1424.1412, 25));
		AddSpawnPoint( "d_startower_89.Id1", "d_startower_89", Spot(1428.0453, -1210.522, 25));
		AddSpawnPoint( "d_startower_89.Id1", "d_startower_89", Spot(1297.2863, -1270.9579, 25));
		AddSpawnPoint( "d_startower_89.Id1", "d_startower_89", Spot(1283.3931, -1038.8431, 25));
		AddSpawnPoint( "d_startower_89.Id1", "d_startower_89", Spot(1418.203, -959.3556, 25));
		AddSpawnPoint( "d_startower_89.Id1", "d_startower_89", Spot(1432.0922, -695.853, 25));
		AddSpawnPoint( "d_startower_89.Id1", "d_startower_89", Spot(1187.865, -842.0383, 25));
		AddSpawnPoint( "d_startower_89.Id1", "d_startower_89", Spot(1046.9088, -808.0726, 25));
		AddSpawnPoint( "d_startower_89.Id1", "d_startower_89", Spot(689.7312, -668.01056, 25));
		AddSpawnPoint( "d_startower_89.Id1", "d_startower_89", Spot(528.2718, -860.0183, 25));
		AddSpawnPoint( "d_startower_89.Id1", "d_startower_89", Spot(332.22842, -793.59595, 25));
		AddSpawnPoint( "d_startower_89.Id1", "d_startower_89", Spot(743.3558, -525.5979, 25));
		AddSpawnPoint( "d_startower_89.Id1", "d_startower_89", Spot(1622.6898, -1798.4824, 25));

		// Gleamlens Spawn Points
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(731.4824, 461.69165, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(981.1652, 861.2053, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(765.21704, 955.33026, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(816.0649, 646.35333, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(727.7975, 1189.6149, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(520.744, 1509.1055, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(784.0284, 1416.6544, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(963.6727, 1491.1132, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(54.30999, 1864.052, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(-104.13045, 1865.0834, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(-18.788948, 1701.85, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(-537.25146, 1696.5812, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(-406.13345, 1595.6626, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(-174.29422, 1339.5978, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(-304.87613, 1260.1926, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(30.664131, 951.149, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(19.856337, 1244.829, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(-138.15506, 988.4276, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(-110.74074, 710.8865, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(98.35194, 792.02936, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(45.61685, 586.97144, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(302.72437, 564.3037, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(436.4557, 825.0392, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(-173.16483, 838.4235, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(627.2128, 15.457489, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(700.97626, -89.481964, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(661.90216, -216.22012, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(913.0797, -179.42609, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(818.6555, 47.210033, 25));
		AddSpawnPoint( "d_startower_89.Id2", "d_startower_89", Spot(622.08606, 1346.7937, 25));

		// Wryer Spawn Points
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-490.8936, 1125.7323, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-818.52997, 962.2132, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-662.70264, 852.6727, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-818.4496, 715.7115, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-1068.3352, 739.12476, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-1237.7686, 711.65765, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-1199.8304, 567.9194, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-915.68945, 265.51962, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-927.38306, -2.3044891, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-671.96344, -353.8631, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-659.69165, -89.91464, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-445.1749, -393.83545, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-535.73804, -213.11691, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-538.59814, 200.69067, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-372.34674, 425.42416, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-172.03818, 211.94693, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(80.20971, 130.5483, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-249.3543, 12.943287, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(44.038864, -163.88972, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(326.05975, -103.0989, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(419.703, -441.826, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(297.40894, -270.21796, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-231.07181, 1156.2673, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-280.69235, 967.98395, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-179.50748, -166.06905, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(112.69632, -49.66236, 25));
		AddSpawnPoint( "d_startower_89.Id3", "d_startower_89", Spot(-80.43331, 115.95756, 25));

		// Rabbler Spawn Points
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(1368.05, -1640.381, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(1531.7682, -1553.3652, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(1563.8959, -1329.1171, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(1295.108, -1323.3842, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(1369.4381, -938.55023, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(1269.0383, -709.1404, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(905.8388, -865.5707, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(641.19617, -867.67883, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(690.35736, -609.02563, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(765.3591, -124.46976, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(725.9603, 269.81454, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(557.66254, -128.38736, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(691.7378, 131.72638, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(803.75476, 759.0924, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(636.7676, 1527.9208, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(907.8005, 965.49945, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(652.0838, 935.0558, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(336.09592, 683.01526, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(163.09772, 616.5009, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(-41.909504, 628.5475, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(-17.70615, 748.1682, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(-128.93213, 1149.3152, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(123.84647, 1060.5944, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(-125.25072, 1721.892, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(70.63126, 1755.5743, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(-553.43286, 1619.7559, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(-204.66034, 1491.8898, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(-485.16556, 1224.091, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(-635.49524, 971.7133, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(-791.5216, 833.54816, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(-645.90686, 746.5639, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(-956.74994, 557.45416, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(-913.8147, 355.4355, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(-713.4593, -154.9056, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(-850.43463, -212.58205, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(-576.1272, 67.99803, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(-420.59537, -167.81387, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(-537.90546, -367.53925, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(321.76633, -383.20248, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(-420.80118, 339.52795, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(452.53925, -524.28345, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(1408.2316, -1469.8684, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(1630.195, -1172.409, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(1424.9391, -813.60956, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(781.1417, -820.776, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(709.465, -326.87573, 25));
		AddSpawnPoint( "d_startower_89.Id4", "d_startower_89", Spot(956.6646, -10.16881, 25));

		// Naste Spawn Points
		AddSpawnPoint( "d_startower_89.Id5", "d_startower_89", Spot(-745.2985, -98.80849, 25));
		AddSpawnPoint( "d_startower_89.Id5", "d_startower_89", Spot(-529.2737, -120.13634, 25));
		AddSpawnPoint( "d_startower_89.Id5", "d_startower_89", Spot(-436.1593, -289.44427, 25));
		AddSpawnPoint( "d_startower_89.Id5", "d_startower_89", Spot(-880.93854, 82.93866, 25));
		AddSpawnPoint( "d_startower_89.Id5", "d_startower_89", Spot(-861.8495, 205.72336, 25));
		AddSpawnPoint( "d_startower_89.Id5", "d_startower_89", Spot(-874.128, 505.84167, 25));
		AddSpawnPoint( "d_startower_89.Id5", "d_startower_89", Spot(-959.45215, -126.4763, 25));
		AddSpawnPoint( "d_startower_89.Id5", "d_startower_89", Spot(-579.1515, -336.0197, 25));
		AddSpawnPoint( "d_startower_89.Id5", "d_startower_89", Spot(-464.33472, 264.63885, 25));
		AddSpawnPoint( "d_startower_89.Id5", "d_startower_89", Spot(-271.8343, 493.27954, 25));

		// Rootcrystal_02 Spawn Points
		AddSpawnPoint( "d_startower_89.Id6", "d_startower_89", Spot(1453.236, -1589.4448, 200));
		AddSpawnPoint( "d_startower_89.Id6", "d_startower_89", Spot(1323.9474, -1009.5785, 200));
		AddSpawnPoint( "d_startower_89.Id6", "d_startower_89", Spot(717.7069, -858.3199, 200));
		AddSpawnPoint( "d_startower_89.Id6", "d_startower_89", Spot(727.3422, -95.72142, 200));
		AddSpawnPoint( "d_startower_89.Id6", "d_startower_89", Spot(776.49615, 904.36755, 200));
		AddSpawnPoint( "d_startower_89.Id6", "d_startower_89", Spot(757.10443, 1425.1978, 200));
		AddSpawnPoint( "d_startower_89.Id6", "d_startower_89", Spot(-25.65467, 738.78815, 200));
		AddSpawnPoint( "d_startower_89.Id6", "d_startower_89", Spot(-294.67917, 1163.4808, 200));
		AddSpawnPoint( "d_startower_89.Id6", "d_startower_89", Spot(-380.2395, 1716.0507, 200));
		AddSpawnPoint( "d_startower_89.Id6", "d_startower_89", Spot(47.463028, 1847.6302, 200));
		AddSpawnPoint( "d_startower_89.Id6", "d_startower_89", Spot(-756.3906, 857.70825, 200));
		AddSpawnPoint( "d_startower_89.Id6", "d_startower_89", Spot(-1202.609, 576.415, 200));
		AddSpawnPoint( "d_startower_89.Id6", "d_startower_89", Spot(-864.46985, 42.99451, 200));
		AddSpawnPoint( "d_startower_89.Id6", "d_startower_89", Spot(-486.20224, -359.17972, 200));
		AddSpawnPoint( "d_startower_89.Id6", "d_startower_89", Spot(407.89697, -474.26312, 200));

	}
}
