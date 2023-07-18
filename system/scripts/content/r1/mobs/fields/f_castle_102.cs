//--- Melia Script -----------------------------------------------------------
// f_castle_102
//
//--- Description -----------------------------------------------------------
// Sets up the f_castle_102 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle102MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_castle_102", MonsterId.Castle_Goblin_Archer, Properties("MHP", 796325, "MINPATK", 10741, "MAXPATK", 13103, "MINMATK", 10741, "MAXMATK", 13103, "DEF", 266180, "MDEF", 266180));
		AddPropertyOverrides("f_castle_102", MonsterId.Wolf, Properties("MHP", 798555, "MINPATK", 10770, "MAXPATK", 13138, "MINMATK", 10770, "MAXMATK", 13138, "DEF", 268057, "MDEF", 268057));
		AddPropertyOverrides("f_castle_102", MonsterId.Wolf_Leader, Properties("MHP", 800818, "MINPATK", 10799, "MAXPATK", 13174, "MINMATK", 10799, "MAXMATK", 13174, "DEF", 269963, "MDEF", 269963));
		AddPropertyOverrides("f_castle_102", MonsterId.Neckko, Properties("MHP", 803113, "MINPATK", 10828, "MAXPATK", 13210, "MINMATK", 10828, "MAXMATK", 13210, "DEF", 271896, "MDEF", 271896));
		AddPropertyOverrides("f_castle_102", MonsterId.Goblin_Sword_Rider, Properties("MHP", 805440, "MINPATK", 10858, "MAXPATK", 13247, "MINMATK", 10858, "MAXMATK", 13247, "DEF", 273856, "MDEF", 273856));

		// Monster Spawners --------------------------------

		AddSpawner("f_castle_102.Id1", MonsterId.Castle_Goblin_Archer, 60, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_102.Id2", MonsterId.Wolf, 50, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_102.Id3", MonsterId.Wolf_Leader, 8, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_102.Id4", MonsterId.Neckko, 30, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_102.Id5", MonsterId.Goblin_Sword_Rider, 40, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_castle_102.Id6", MonsterId.Rootcrystal_02, 30, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Castle_Goblin_Archer Spawn Points
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-2116.873, -973.1005, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-2105.444, -711.31647, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-2436.6138, -899.62787, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-386.24945, -717.01447, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-182.45688, -239.07074, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-116.29701, -451.8723, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-227.97102, -634.04443, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-418.85495, -925.183, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-461.74942, -1175.7607, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-1065.5045, -396.083, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-888.8549, -210.82639, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-937.2593, 93.12419, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-409.62106, 232.25812, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-1705.6305, 184.5285, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-3004.7278, 351.637, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-498.8579, 181.10776, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-599.3376, 77.431725, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-254.51012, 234.722, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-217.28993, 136.199, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-363.98468, 152.5975, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-1475.3878, 115.52884, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-1611.8696, 197.04707, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-1738.7532, 103.82915, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-1737.767, 282.09644, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-2201.9878, 315.68863, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-2173.9712, 132.1769, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-1996.7339, 383.3338, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-2012.4026, 156.77048, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-2488.7048, 332.269, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-2805.945, 96.17943, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-3007.1753, 232.76115, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-2645.2385, 180.60175, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-2890.197, 269.93848, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-2791.5786, 379.133, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-2625.1162, 336.15326, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-1903.6964, 311.95526, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-1073.6249, 44.912407, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-1032.2538, -111.52621, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-798.665, -35.990063, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-1064.195, -528.752, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-954.3105, -753.9682, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-1106.9318, -938.1942, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-620.42114, -632.74365, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-1159.0205, -1064.7539, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-1292.7642, -734.8708, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-1551.3364, -706.0475, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-1823.4606, -958.1483, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-2514.2744, -689.76044, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-2555.9482, -790.92737, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-827.50214, -1428.4664, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-694.0725, -1555.8466, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-557.9463, -1394.3007, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-276.43784, -1387.4749, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-460.85544, -1289.8478, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-807.46185, -525.2686, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-690.4639, -1427.5455, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-2025.7488, -1401.7167, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-2136.07, -1436.5442, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-2124.5251, -1221.3577, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-2002.9064, -1093.5823, 35));
		AddSpawnPoint( "f_castle_102.Id1", "f_castle_102", Spot(-1894.1702, -1416.0887, 35));

		// Wolf Spawn Points
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-1265.0009, 119.01871, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-121.14182, 292.16992, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-2254.04, 199.42876, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-2080.2974, 430.91296, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-39.00509, 212.51512, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-587.96783, 259.3994, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-703.2129, 41.373283, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-273.02786, 71.75211, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-1516.7356, 192.8244, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-1859.7948, 389.64355, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-1839.8129, 193.05698, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-1985.8805, 318.6701, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-2173.4343, 235.89032, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-1992.3788, 90.47905, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-2749.945, 179.12201, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-3018.8975, 231.64236, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-2910.157, 398.05075, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-2794.5405, 441.88565, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-2787.217, 297.3106, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-2539.787, 246.15828, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-2381.4773, 267.00287, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-2108.415, 360.22156, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-1937.8069, 225.47127, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-850.5063, 41.365665, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-1121.3424, 152.14362, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-1130.0265, -57.394325, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-1104.3597, -613.36475, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-806.7859, -676.4397, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-1052.4087, -257.63837, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-906.8635, -390.06183, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-1216.2051, -716.7002, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-1517.9177, -718.0091, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-1628.9862, -857.2938, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-1707.2938, -951.61584, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-2196.6235, -876.7406, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-2365.3513, -753.4155, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-2290.664, -689.6467, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-1845.2002, -647.1049, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-1991.8494, -785.1614, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-476.69907, -628.4313, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-346.65594, -338.2206, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-227.90042, -528.87585, 25));
		AddSpawnPoint( "f_castle_102.Id2", "f_castle_102", Spot(-405.28217, -511.11096, 25));

		// Wolf_Leader Spawn Points
		AddSpawnPoint( "f_castle_102.Id3", "f_castle_102", Spot(-941.56854, -623.07385, 25));
		AddSpawnPoint( "f_castle_102.Id3", "f_castle_102", Spot(-2193.5332, -817.2716, 25));
		AddSpawnPoint( "f_castle_102.Id3", "f_castle_102", Spot(-1855.9891, -852.5342, 25));
		AddSpawnPoint( "f_castle_102.Id3", "f_castle_102", Spot(-2692.9062, 252.15652, 25));
		AddSpawnPoint( "f_castle_102.Id3", "f_castle_102", Spot(-2063.859, 248.93752, 25));
		AddSpawnPoint( "f_castle_102.Id3", "f_castle_102", Spot(-1363.4924, 121.53156, 25));
		AddSpawnPoint( "f_castle_102.Id3", "f_castle_102", Spot(-1841.2013, 86.62546, 25));
		AddSpawnPoint( "f_castle_102.Id3", "f_castle_102", Spot(-925.973, -48.25721, 25));
		AddSpawnPoint( "f_castle_102.Id3", "f_castle_102", Spot(-254.30664, -405.53586, 25));
		AddSpawnPoint( "f_castle_102.Id3", "f_castle_102", Spot(-516.4788, -551.92413, 25));

		// Neckko Spawn Points
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-2016.1174, -884.047, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-1966.7864, -1481.6931, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-1801.7104, -1613.9877, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-506.7155, -699.39624, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-2153.521, -934.86633, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-1723.2648, -936.1785, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-1921.3073, -674.2259, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-886.4298, -698.9151, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-1660.676, -740.77094, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-760.6383, -1433.2747, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-864.2394, -1487.3759, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-670.9705, -1605.7975, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-448.0072, -1440.2719, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-328.8756, -1616.3145, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-238.47021, -1579.3756, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-222.64839, -1433.6287, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-752.20996, -668.35657, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-455.53918, -1303.5111, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-1125.0181, -937.7619, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-779.1992, -1547.5015, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-2023.5566, -1638.9202, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-2159.205, -772.2567, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-2143.3003, -1336.9591, 25));
		AddSpawnPoint( "f_castle_102.Id4", "f_castle_102", Spot(-1257.8363, -893.0068, 25));

		// Goblin_Sword_Rider Spawn Points
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-326.22693, -479.59515, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-339.71902, -593.5517, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-402.30173, -403.34958, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-264.2065, -311.71143, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-143.04063, -384.92435, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-167.8515, -537.17377, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-902.704, -546.3819, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-1047.2361, -671.9956, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-801.8788, -751.7855, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-918.8163, -306.87335, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-1007.5336, -444.4811, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-1123.711, -465.90097, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-946.78253, -175.17085, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-822.94104, -68.804504, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-1047.1647, 167.25043, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-1149.4966, 81.42566, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-1412.0599, -713.2345, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-1549.6693, -821.4543, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-1654.6106, -745.76373, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-1792.1342, -781.4718, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-1990.74, -644.3913, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-1998.2814, -924.76917, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-2265.6438, -915.42957, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-2438.046, -807.9364, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-2418.1846, -685.75464, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-2196.5718, -636.05835, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-2222.9844, -755.13025, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-2039.1022, -811.38416, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-1731.245, -883.44836, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-1096.0815, -820.6345, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-1052.2025, -332.19052, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-948.78595, 28.111778, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-875.46466, -1579.3483, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-539.9564, -1458.6956, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-451.2117, -1054.6846, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-484.54453, -1262.4114, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-318.7139, -1476.6869, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-485.08472, -1554.0881, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-2122.1472, -1579.0834, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-118.46747, -299.70203, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-931.13086, -473.51614, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-329.40265, -1541.5292, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-1738.5273, -687.679, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-2337.791, -984.37506, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-1993.495, -1561.1226, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-2047.633, -1486.634, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-2150.9114, -1280.7977, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-2070.5518, -1089.6687, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-1910.4048, -1542.8398, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-1840.715, -1496.2975, 30));
		AddSpawnPoint( "f_castle_102.Id5", "f_castle_102", Spot(-1921.421, -1611.582, 30));

		// Rootcrystal_02 Spawn Points
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1005.9974, -17.182648, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1030.083, 412.0697, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1047.9579, 191.45938, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1288.3563, 556.3632, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-858.40265, 632.34546, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-262.24933, -1450.1387, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-373.0874, -1587.8972, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-528.14087, -1447.0309, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-650.05664, -1588.6232, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-847.3031, -1440.515, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1180.2981, -1448.4259, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1314.4336, -1599.656, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1595.284, -1547.7405, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1838.8763, -1574.7759, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-2058.49, -1574.507, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-2034.716, -1407.4595, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1903.3335, -1433.0713, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1488.8282, -1423.642, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1321.3938, -1430.5511, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1134.101, -1598.4398, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1207.5511, -1250.742, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1218.7664, -854.6843, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1023.8756, -852.4026, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-815.0716, -845.5617, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-650.2276, -663.04834, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-926.83105, -583.42285, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-973.55115, -280.68634, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-555.5106, -559.5924, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-293.80948, -629.4273, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-310.9479, -352.03003, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-103.2112, -391.4092, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-136.17131, -542.9245, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-449.7054, -1032.2434, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-453.87802, -1273.591, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-415.35605, -818.7203, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1577.1123, -744.72626, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1732.6151, -944.63684, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1784.0695, -764.01776, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-2010.9371, -969.7778, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-2085.2605, -759.5138, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-2270.4116, -994.96954, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-2324.9014, -714.96295, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-2560.8208, -832.25055, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-2330.2344, -853.0038, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-2903.5154, 160.63162, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-2913.2537, 382.8159, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-2727.7795, 303.3799, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-2668.7732, 121.68873, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-2511.8706, 242.30313, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-2325.3909, 287.35284, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-2186.233, 187.1177, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-2033.1222, 391.3373, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1992.5338, 130.90178, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1835.3823, 389.00146, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1785.3065, 215.25552, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1517.6637, 137.15654, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1266.7603, 104.95599, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-1122.8379, 688.41614, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-748.4978, -12.79987, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-560.6784, 165.38972, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-388.99164, 136.92816, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(-177.2168, 182.46857, 100));
		AddSpawnPoint( "f_castle_102.Id6", "f_castle_102", Spot(12.702027, 319.2865, 100));

	}
}
