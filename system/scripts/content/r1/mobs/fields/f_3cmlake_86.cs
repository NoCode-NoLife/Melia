//--- Melia Script -----------------------------------------------------------
// f_3cmlake_86
//
//--- Description -----------------------------------------------------------
// Sets up the f_3cmlake_86 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class F3Cmlake86MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_3cmlake_86", MonsterId.Spinacho, Properties("MHP", 599233, "MINPATK", 8206, "MAXPATK", 9988, "MINMATK", 8206, "MAXMATK", 9988, "DEF", 127350, "MDEF", 127350));
		AddPropertyOverrides("f_3cmlake_86", MonsterId.Rubeta, Properties("MHP", 600088, "MINPATK", 8217, "MAXPATK", 10001, "MINMATK", 8217, "MAXMATK", 10001, "DEF", 127862, "MDEF", 127862));
		AddPropertyOverrides("f_3cmlake_86", MonsterId.Lilymaid, Properties("MHP", 601007, "MINPATK", 8229, "MAXPATK", 10016, "MINMATK", 8229, "MAXMATK", 10016, "DEF", 128412, "MDEF", 128412));
		AddPropertyOverrides("f_3cmlake_86", MonsterId.Little_Rubeta, Properties("MHP", 601985, "MINPATK", 8242, "MAXPATK", 10031, "MINMATK", 8242, "MAXMATK", 10031, "DEF", 128998, "MDEF", 128998));

		// Monster Spawners --------------------------------

		AddSpawner("f_3cmlake_86.Id1", MonsterId.Spinacho, 28, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_86.Id2", MonsterId.Rubeta, 18, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_86.Id3", MonsterId.Lilymaid, 21, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_86.Id4", MonsterId.Nolimaid, 17, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_86.Id5", MonsterId.Little_Rubeta, 51, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_86.Id6", MonsterId.Rootcrystal_02, 1, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Spinacho Spawn Points
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(367.39163, -664.6392, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(360.8278, -389.6175, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(559.3043, -108.37914, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(806.7785, -111.53719, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(634.8851, -344.4725, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(620.977, -779.4124, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(716.3576, -1053.7854, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(1103.4634, -1068.5814, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(1301.3535, -960.0156, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(1252.2612, -546.48145, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(1311.2648, -207.9446, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(1461.7034, -687.75793, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(1568.7748, -1063.1469, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(1765.4785, -997.2484, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(2164.671, -832.5583, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(2200.3955, -330.08655, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(1949.1053, -184.24454, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(1725.3903, -326.8343, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(1760.5693, -598.693, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(2319.9663, -172.65352, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(1488.1482, -73.80604, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(1336.307, 389.9571, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(1593.7394, 341.85556, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(1462.5195, 760.60516, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(1733.4813, 613.8824, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(924.6534, -109.84906, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(2151.304, -562.45325, 45));
		AddSpawnPoint( "f_3cmlake_86.Id1", "f_3cmlake_86", Spot(352.56354, -138.99226, 45));

		// Rubeta Spawn Points
		AddSpawnPoint( "f_3cmlake_86.Id2", "f_3cmlake_86", Spot(-1161.8372, -1022.0215, 45));
		AddSpawnPoint( "f_3cmlake_86.Id2", "f_3cmlake_86", Spot(-975.03314, -824.54987, 45));
		AddSpawnPoint( "f_3cmlake_86.Id2", "f_3cmlake_86", Spot(-1372.4049, -800.12756, 45));
		AddSpawnPoint( "f_3cmlake_86.Id2", "f_3cmlake_86", Spot(-1164.4939, -537.5855, 45));
		AddSpawnPoint( "f_3cmlake_86.Id2", "f_3cmlake_86", Spot(-1311.986, 127.04548, 45));
		AddSpawnPoint( "f_3cmlake_86.Id2", "f_3cmlake_86", Spot(-918.93384, 161.2137, 45));
		AddSpawnPoint( "f_3cmlake_86.Id2", "f_3cmlake_86", Spot(-706.37463, 100.94112, 45));
		AddSpawnPoint( "f_3cmlake_86.Id2", "f_3cmlake_86", Spot(-1128.8317, 558.12823, 45));
		AddSpawnPoint( "f_3cmlake_86.Id2", "f_3cmlake_86", Spot(-721.6366, 342.96536, 45));
		AddSpawnPoint( "f_3cmlake_86.Id2", "f_3cmlake_86", Spot(-480.65085, 581.33356, 45));
		AddSpawnPoint( "f_3cmlake_86.Id2", "f_3cmlake_86", Spot(-358.1198, 259.3511, 45));
		AddSpawnPoint( "f_3cmlake_86.Id2", "f_3cmlake_86", Spot(-145.83719, 415.64505, 45));
		AddSpawnPoint( "f_3cmlake_86.Id2", "f_3cmlake_86", Spot(-38.820038, 622.19183, 45));
		AddSpawnPoint( "f_3cmlake_86.Id2", "f_3cmlake_86", Spot(-1502.366, 427.13916, 45));
		AddSpawnPoint( "f_3cmlake_86.Id2", "f_3cmlake_86", Spot(-1163.7966, -348.85242, 45));
		AddSpawnPoint( "f_3cmlake_86.Id2", "f_3cmlake_86", Spot(-1098.6044, 354.55353, 45));
		AddSpawnPoint( "f_3cmlake_86.Id2", "f_3cmlake_86", Spot(-1414.7299, -164.03242, 45));
		AddSpawnPoint( "f_3cmlake_86.Id2", "f_3cmlake_86", Spot(-799.47235, -733.0398, 45));

		// Lilymaid Spawn Points
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(-1313.7161, 1287.3655, 45));
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(-1263.7031, 1085.256, 45));
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(-1146.8754, 942.52313, 45));
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(-921.21545, 1045.2343, 45));
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(-873.5342, 1229.0648, 45));
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(-1110.5488, 1348.66, 45));
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(-544.42346, 1163.7406, 45));
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(-606.49194, 869.7654, 45));
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(-48.38587, 1696.3243, 45));
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(-286.5534, 972.5701, 45));
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(-33.685974, 1237.2252, 45));
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(213.3189, 1215.2242, 45));
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(639.6883, 857.2069, 45));
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(851.5275, 845.09595, 45));
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(858.86926, 426.57526, 45));
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(792.5865, 119.10176, 45));
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(587.58435, 114.25576, 45));
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(295.75314, 381.87238, 45));
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(295.11212, 580.9395, 45));
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(477.84552, 619.58044, 45));
		AddSpawnPoint( "f_3cmlake_86.Id3", "f_3cmlake_86", Spot(750.5448, 624.58057, 45));

		// Nolimaid Spawn Points
		AddSpawnPoint( "f_3cmlake_86.Id4", "f_3cmlake_86", Spot(-1022.6713, 971.8636, 45));
		AddSpawnPoint( "f_3cmlake_86.Id4", "f_3cmlake_86", Spot(-892.87054, 1346.083, 45));
		AddSpawnPoint( "f_3cmlake_86.Id4", "f_3cmlake_86", Spot(-1171.3523, 1151.2382, 45));
		AddSpawnPoint( "f_3cmlake_86.Id4", "f_3cmlake_86", Spot(-1248.6927, 1408.5328, 45));
		AddSpawnPoint( "f_3cmlake_86.Id4", "f_3cmlake_86", Spot(-629.0067, 990.7897, 45));
		AddSpawnPoint( "f_3cmlake_86.Id4", "f_3cmlake_86", Spot(-159.69043, 1169.4241, 45));
		AddSpawnPoint( "f_3cmlake_86.Id4", "f_3cmlake_86", Spot(243.24033, 1049.3896, 45));
		AddSpawnPoint( "f_3cmlake_86.Id4", "f_3cmlake_86", Spot(-56.66873, 1546.8655, 45));
		AddSpawnPoint( "f_3cmlake_86.Id4", "f_3cmlake_86", Spot(-22.716965, 1775.1979, 45));
		AddSpawnPoint( "f_3cmlake_86.Id4", "f_3cmlake_86", Spot(732.1645, 952.9949, 45));
		AddSpawnPoint( "f_3cmlake_86.Id4", "f_3cmlake_86", Spot(807.3618, 271.28625, 45));
		AddSpawnPoint( "f_3cmlake_86.Id4", "f_3cmlake_86", Spot(434.513, 122.2156, 45));
		AddSpawnPoint( "f_3cmlake_86.Id4", "f_3cmlake_86", Spot(252.12172, 202.7014, 45));
		AddSpawnPoint( "f_3cmlake_86.Id4", "f_3cmlake_86", Spot(221.56041, 669.808, 45));
		AddSpawnPoint( "f_3cmlake_86.Id4", "f_3cmlake_86", Spot(560.87054, 728.3667, 45));
		AddSpawnPoint( "f_3cmlake_86.Id4", "f_3cmlake_86", Spot(925.72394, 65.28633, 45));
		AddSpawnPoint( "f_3cmlake_86.Id4", "f_3cmlake_86", Spot(74.906525, 1400.5028, 45));

		// Little_Rubeta Spawn Points
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(-1368.9415, -889.7004, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(-1295.2631, -532.1375, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(-1033.0262, -505.31033, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(-985.8799, -730.3051, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(-1022.587, -1016.7254, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(-549.6535, -711.64545, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(-1128.7124, -197.22865, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(-1472.7966, -39.801785, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(-1574.7697, 281.57114, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(-1288.2882, 543.38043, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(-867.4275, 464.09448, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(-822.5852, 265.77228, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(-949.4314, 71.64094, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(-1214.2867, 117.30964, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(-627.3036, 428.1594, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(-351.35785, 652.28754, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(-439.95163, 322.2853, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(13.44068, 586.6819, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(-335.7357, 478.2433, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(390.15582, -537.4498, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(412.31714, -814.75977, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(760.9495, -112.88245, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(1197.0774, -106.02232, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(1245.124, -357.48193, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(870.8696, -261.6374, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(642.4137, -539.68066, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(619.726, -948.69116, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(865.6758, -1001.9961, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(1007.0611, -1092.6178, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(1196.2908, -981.51465, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(1217.3499, -771.68164, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(1439.5289, -482.0768, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(1385.9387, -800.84326, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(1919.8418, -1064.4327, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(1952.5852, -834.5633, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(2211.2996, -451.3992, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(1994.1428, -57.158768, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(2117.7305, -231.69418, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(1741.1034, -440.21933, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(1947.7217, -570.23627, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(2401.0603, -56.536396, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(1465.3904, 19.655254, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(1491.7407, 297.01654, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(1378.4661, 540.3698, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(1615.7284, 783.99097, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(1784.7567, 463.52133, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(478.25555, -124.93717, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(1695.8689, -1093.5626, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(-471.17838, -600.7186, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(914.90356, -105.85167, 45));
		AddSpawnPoint( "f_3cmlake_86.Id5", "f_3cmlake_86", Spot(769.29877, 138.41592, 45));

		// Rootcrystal_02 Spawn Points
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(-208.22647, -1282.1592, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(-220.12204, -939.56775, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(-124.61271, -472.81082, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(-219.67554, 34.472363, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(-876.0568, -704.4965, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(-1322.8835, -972.3038, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(-1094.0361, -514.72424, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(-1105.0043, -133.38904, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(-1542.7068, 341.46948, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(-790.46765, -23.32432, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(-1040.9384, 373.162, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(-1093.407, 887.1508, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(-1279.0264, 1255.9683, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(-876.9801, 1275.816, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(-252.85117, 1082.7408, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(-560.98785, 869.09045, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(-498.77087, 462.22586, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(-26.294098, 605.03705, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(486.52, 563.22015, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(760.4359, 218.91742, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(401.2781, 82.30797, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(718.32874, -366.30203, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(765.4268, -1094.6873, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(853.6738, -117.70084, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(1249.0552, -818.58124, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(1295.3673, -368.61258, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(360.2173, -366.56274, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(1580.3667, -995.036, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(1917.5863, -783.5546, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(2277.5173, -575.9211, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(1946.2687, -134.14656, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(1387.1088, 109.11802, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(1415.1389, 638.2229, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(1726.0317, 554.3591, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(823.2388, 766.4486, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(444.39862, 1069.2958, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(327.60345, 1392.66, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(-128.8979, 1720.0142, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(734.0789, 1497.3064, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(1061.762, 1576.9573, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(1050.6753, 1904.1489, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(1415.9998, 1600.9368, 200));
		AddSpawnPoint( "f_3cmlake_86.Id6", "f_3cmlake_86", Spot(1271.38, 1237.037, 200));

	}
}
