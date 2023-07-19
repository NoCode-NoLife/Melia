//--- Melia Script -----------------------------------------------------------
// ep15_1_f_abbey_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Novaha Institute' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep151FAbbey1MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep15_1_f_abbey_1", MonsterId.Ep15_1_Goblin_Chaser, Properties("MHP", 48750000, "MINPATK", 120000, "MAXPATK", 120000, "MINMATK", 120000, "MAXMATK", 120000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep15_1_f_abbey_1", MonsterId.Ep15_1_Goblin_Rider, Properties("MHP", 48750000, "MINPATK", 120000, "MAXPATK", 120000, "MINMATK", 120000, "MAXMATK", 120000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep15_1_f_abbey_1", MonsterId.Ep15_1_Pokubu_Ferocious, Properties("MHP", 48750000, "MINPATK", 120000, "MAXPATK", 120000, "MINMATK", 120000, "MAXMATK", 120000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep15_1_f_abbey_1", MonsterId.Ep15_1_Boss_Bubas, Properties("MHP", 146250000, "MINPATK", 120000, "MAXPATK", 120000, "MINMATK", 120000, "MAXMATK", 120000, "DEF", 3000000, "MDEF", 3000000));

		// Monster Spawners ---------------------------------

		AddSpawner("ep15_1_f_abbey_1.Id1", MonsterId.Ep15_1_Pokubu_Ferocious, 60, 80, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("ep15_1_f_abbey_1.Id2", MonsterId.Ep15_1_Goblin_Chaser, 60, 80, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("ep15_1_f_abbey_1.Id3", MonsterId.Ep15_1_Goblin_Rider, 60, 80, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Ep15_1_Pokubu_Ferocious' GenType 10 Spawn Points
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1522.8496, -752.3644, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1474.6874, -948.1848, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1436.5652, -1215.0684, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1554.1797, -1086.97, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1529.9983, -1240.6162, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1583.9899, -1427.3162, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1013.0619, -1372.4312, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1153.9918, -1402.0222, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1295.7919, -1432.2611, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1591.5156, -793.3597, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1608.444, -624.2425, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1436.9847, -578.53955, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1462.1901, -336.23962, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1298.1166, -1089.2983, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-865.8167, -1301.357, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-610.9062, -1341.119, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-405.653, -1351.0891, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(19.144444, -1381.7487, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-80.65999, -1546.4526, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1518.2911, -131.73083, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-952.81744, -1236.5482, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-399.67667, -1434.4094, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-171.75179, -1320.9017, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-277.70605, -1139.69, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-253.45201, -996.42426, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1516.4261, -307.1308, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1530.019, -222.01479, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1459.2458, -455.4042, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1400.8689, -687.2257, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1371.2448, -789.82324, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1586.5763, -883.2255, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id1", "ep15_1_f_abbey_1", Rectangle(-1438.7435, -1098.7699, 60));

		// 'Ep15_1_Goblin_Chaser' GenType 12 Spawn Points
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(694.0681, 42.669502, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(576.25854, 98.91668, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(159.71315, 253.00407, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(380.35715, 260.48108, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(138.05064, -100.09683, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(728.5412, -560.9488, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(714.712, -761.99335, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(796.7492, -449.16983, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-199.51495, -798.02625, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-188.72272, -555.3832, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-773.7285, -175.73671, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-829.8594, 104.44521, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-755.65094, 206.06941, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-1012.4067, 222.22726, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-825.76495, -589.5188, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-148.86075, -1368.5793, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-14.027542, -1402.3448, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-867.08685, 1271.8523, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-671.87354, 1187.5504, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-142.28708, 61.63268, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-282.04187, 276.99548, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-346.36404, 119.38061, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(445.76773, -548.5713, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(182.30853, -521.4203, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-207.32468, 1235.5468, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-49.934616, 1136.4586, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(88.0005, 1241.6874, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(920.45715, -92.58329, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(1154.0122, -93.68633, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(1229.8972, 55.687626, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(1240.892, 326.1174, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(1115.1754, 458.1604, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(708.1145, 540.0833, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(910.05054, 556.1369, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(800.9709, -789.28546, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(573.2833, -681.15393, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(623.9304, -503.92606, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(732.15405, -260.83286, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(773.3888, -84.15772, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(188.55612, 69.50462, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-125.3141, -166.98819, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-282.14365, -355.38568, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-414.66766, 0.7811122, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-356.72495, -616.7201, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-311.0284, -536.1288, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-369.0023, -367.39334, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-91.23284, -415.26743, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(1044.782, 403.76132, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(1104.1494, 8.008242, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(1008.696, -15.137972, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(866.895, 59.48004, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(1042.6826, 228.47346, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(1013.6494, 119.38507, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(683.7254, -408.4864, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(804.7002, -637.97144, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(41.093918, -572.0534, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id2", "ep15_1_f_abbey_1", Rectangle(-163.62988, -646.0125, 60));

		// 'Ep15_1_Goblin_Rider' GenType 13 Spawn Points
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-777.72675, -171.12666, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-754.6061, 263.35483, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-1178.6099, 293.93506, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-819.4787, 882.1105, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-904.97754, 1151.5352, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-1095.4576, 1232.6812, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-47.736393, 1264.1852, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-767.79663, 1294.9991, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-918.38983, 1394.8868, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-951.17664, -373.48752, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-645.89514, -418.579, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-181.103, -392.64822, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-769.3542, 112.8066, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-217.78954, -839.4755, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-83.10122, -585.01013, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-17.351, -145.38846, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-70.8017, -393.84344, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-823.82623, -642.88617, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-642.40186, -657.87476, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-358.66086, -390.898, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-644.9502, 84.454834, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-805.17004, 419.80743, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-820.4872, 996.539, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-559.14636, 1247.7251, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-412.1765, -171.245, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-251.50743, -110.08945, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-209.55478, 39.618034, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-331.7105, 17.589025, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-94.765274, 153.7694, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-161.65323, 225.03427, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-611.2154, -210.63933, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-945.21985, -140.9195, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-815.4985, -421.3539, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-985.1541, -577.8309, 60));
		AddSpawnPoint("ep15_1_f_abbey_1.Id3", "ep15_1_f_abbey_1", Rectangle(-920.4604, 153.79872, 60));
	}
}
