//--- Melia Script -----------------------------------------------------------
// ep15_1_f_abbey_1
//
//--- Description -----------------------------------------------------------
// Sets up the ep15_1_f_abbey_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep151FAbbey1MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("ep15_1_f_abbey_1", MonsterId.Ep15_1_Pokubu_Ferocious, Properties("MHP", 48750000, "MINPATK", 120000, "MAXPATK", 120000, "MINMATK", 120000, "MAXMATK", 120000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep15_1_f_abbey_1", MonsterId.Ep15_1_Goblin_Chaser, Properties("MHP", 48750000, "MINPATK", 120000, "MAXPATK", 120000, "MINMATK", 120000, "MAXMATK", 120000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep15_1_f_abbey_1", MonsterId.Ep15_1_Goblin_Rider, Properties("MHP", 48750000, "MINPATK", 120000, "MAXPATK", 120000, "MINMATK", 120000, "MAXMATK", 120000, "DEF", 3000000, "MDEF", 3000000));

		// Monster Spawners --------------------------------

		AddSpawner("ep15_1_f_abbey_1.Id1", MonsterId.Ep15_1_Pokubu_Ferocious, 80, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("ep15_1_f_abbey_1.Id2", MonsterId.Ep15_1_Goblin_Chaser, 80, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("ep15_1_f_abbey_1.Id3", MonsterId.Ep15_1_Goblin_Rider, 80, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Ep15_1_Pokubu_Ferocious Spawn Points
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1522.8496, -752.3644, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1474.6874, -948.1848, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1436.5652, -1215.0684, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1554.1797, -1086.97, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1529.9983, -1240.6162, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1583.9899, -1427.3162, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1013.0619, -1372.4312, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1153.9918, -1402.0222, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1295.7919, -1432.2611, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1591.5156, -793.3597, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1608.444, -624.2425, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1436.9847, -578.53955, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1462.1901, -336.23962, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1298.1166, -1089.2983, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-865.8167, -1301.357, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-610.9062, -1341.119, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-405.653, -1351.0891, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(19.144444, -1381.7487, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-80.65999, -1546.4526, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1518.2911, -131.73083, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-952.81744, -1236.5482, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-399.67667, -1434.4094, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-171.75179, -1320.9017, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-277.70605, -1139.69, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-253.45201, -996.42426, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1516.4261, -307.1308, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1530.019, -222.01479, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1459.2458, -455.4042, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1400.8689, -687.2257, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1371.2448, -789.82324, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1586.5763, -883.2255, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Spot(-1438.7435, -1098.7699, 60));

		// Ep15_1_Goblin_Chaser Spawn Points
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(694.0681, 42.669502, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(576.25854, 98.91668, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(159.71315, 253.00407, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(380.35715, 260.48108, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(138.05064, -100.09683, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(728.5412, -560.9488, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(714.712, -761.99335, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(796.7492, -449.16983, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-199.51495, -798.02625, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-188.72272, -555.3832, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-773.7285, -175.73671, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-829.8594, 104.44521, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-755.65094, 206.06941, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-1012.4067, 222.22726, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-825.76495, -589.5188, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-148.86075, -1368.5793, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-14.027542, -1402.3448, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-867.08685, 1271.8523, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-671.87354, 1187.5504, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-142.28708, 61.63268, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-282.04187, 276.99548, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-346.36404, 119.38061, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(445.76773, -548.5713, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(182.30853, -521.4203, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-207.32468, 1235.5468, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-49.934616, 1136.4586, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(88.0005, 1241.6874, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(920.45715, -92.58329, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(1154.0122, -93.68633, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(1229.8972, 55.687626, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(1240.892, 326.1174, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(1115.1754, 458.1604, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(708.1145, 540.0833, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(910.05054, 556.1369, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(800.9709, -789.28546, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(573.2833, -681.15393, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(623.9304, -503.92606, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(732.15405, -260.83286, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(773.3888, -84.15772, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(188.55612, 69.50462, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-125.3141, -166.98819, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-282.14365, -355.38568, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-414.66766, 0.7811122, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-356.72495, -616.7201, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-311.0284, -536.1288, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-369.0023, -367.39334, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-91.23284, -415.26743, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(1044.782, 403.76132, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(1104.1494, 8.008242, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(1008.696, -15.137972, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(866.895, 59.48004, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(1042.6826, 228.47346, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(1013.6494, 119.38507, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(683.7254, -408.4864, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(804.7002, -637.97144, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(41.093918, -572.0534, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Spot(-163.62988, -646.0125, 60));

		// Ep15_1_Goblin_Rider Spawn Points
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-777.72675, -171.12666, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-754.6061, 263.35483, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-1178.6099, 293.93506, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-819.4787, 882.1105, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-904.97754, 1151.5352, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-1095.4576, 1232.6812, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-47.736393, 1264.1852, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-767.79663, 1294.9991, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-918.38983, 1394.8868, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-951.17664, -373.48752, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-645.89514, -418.579, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-181.103, -392.64822, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-769.3542, 112.8066, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-217.78954, -839.4755, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-83.10122, -585.01013, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-17.351, -145.38846, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-70.8017, -393.84344, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-823.82623, -642.88617, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-642.40186, -657.87476, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-358.66086, -390.898, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-644.9502, 84.454834, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-805.17004, 419.80743, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-820.4872, 996.539, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-559.14636, 1247.7251, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-412.1765, -171.245, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-251.50743, -110.08945, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-209.55478, 39.618034, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-331.7105, 17.589025, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-94.765274, 153.7694, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-161.65323, 225.03427, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-611.2154, -210.63933, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-945.21985, -140.9195, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-815.4985, -421.3539, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-985.1541, -577.8309, 60));
		AddSpawnPoint( "ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Spot(-920.4604, 153.79872, 60));

	}
}
