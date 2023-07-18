//--- Melia Script -----------------------------------------------------------
// f_pilgrimroad_46
//
//--- Description -----------------------------------------------------------
// Sets up the f_pilgrimroad_46 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad46MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_pilgrimroad_46", MonsterId.Kepari, Properties("MHP", 125041, "MINPATK", 2109, "MAXPATK", 2494, "MINMATK", 2109, "MAXMATK", 2494, "DEF", 1994, "MDEF", 1994));
		AddPropertyOverrides("f_pilgrimroad_46", MonsterId.Kepo_Seed, Properties("MHP", 125299, "MINPATK", 2112, "MAXPATK", 2498, "MINMATK", 2112, "MAXMATK", 2498, "DEF", 2009, "MDEF", 2009));
		AddPropertyOverrides("f_pilgrimroad_46", MonsterId.Kepo, Properties("MHP", 126384, "MINPATK", 2126, "MAXPATK", 2515, "MINMATK", 2126, "MAXMATK", 2515, "DEF", 2071, "MDEF", 2071));
		AddPropertyOverrides("f_pilgrimroad_46", MonsterId.Wood_Goblin_Red, Properties("MHP", 125772, "MINPATK", 2118, "MAXPATK", 2506, "MINMATK", 2118, "MAXMATK", 2506, "DEF", 2036, "MDEF", 2036));

		// Monster Spawners --------------------------------

		AddSpawner("f_pilgrimroad_46.Id1", MonsterId.Rootcrystal_01, 14, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id2", MonsterId.Kepari, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id3", MonsterId.Kepo_Seed, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id4", MonsterId.Kepari, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id5", MonsterId.Kepo_Seed, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id6", MonsterId.Kepari, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id7", MonsterId.Kepo, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id8", MonsterId.Kepo, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id9", MonsterId.Kepo, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id10", MonsterId.Wood_Goblin_Red, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Spot(-1816.7163, -1913.9637, 40));
		AddSpawnPoint( "f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Spot(-1933.0756, -1051.4459, 40));
		AddSpawnPoint( "f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Spot(-1040.3562, -749.8858, 40));
		AddSpawnPoint( "f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Spot(-1311.1724, -172.15028, 40));
		AddSpawnPoint( "f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Spot(-365.1689, -1148.7295, 40));
		AddSpawnPoint( "f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Spot(241.37259, -1041.9418, 40));
		AddSpawnPoint( "f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Spot(448.08194, -342.28644, 40));
		AddSpawnPoint( "f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Spot(554.72485, 176.58028, 40));
		AddSpawnPoint( "f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Spot(338.11932, 717.62756, 40));
		AddSpawnPoint( "f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Spot(1344.7881, 88.921265, 40));
		AddSpawnPoint( "f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Spot(1889.5366, 189.17409, 40));
		AddSpawnPoint( "f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Spot(1812.2513, 1019.256, 40));
		AddSpawnPoint( "f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Spot(1285.3344, 825.3493, 40));
		AddSpawnPoint( "f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Spot(618.98047, 1387.9956, 40));

		// Kepari Spawn Points
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(540.8157, 336.89246, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(301.9332, 594.594, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(16.117188, 771.19104, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(83.902855, 551.4256, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(148.47517, 678.99475, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(181.9604, 808.55475, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(1537.2004, -329.67563, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(1772.0273, -376.05957, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(1995.2882, -317.32364, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(2067.7917, -77.447845, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(1721.2559, -193.32808, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(1877.7076, 36.671722, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(1644.409, 13.505814, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(1864.1654, 208.62308, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(1376.065, 21.321215, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(1793.596, -109.50809, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(1982.7877, -96.02672, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(1435.5555, -202.16919, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(1668.1561, 202.90002, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(507.77997, 622.907, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(287.29517, 719.6351, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(227.92415, 532.4565, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(513.24896, 447.82227, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(1215.897, 58.76411, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Spot(1314.3289, 162.35693, 25));

		// Kepo_Seed Spawn Points
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(-1840.6755, -1789.9282, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(-1380.9435, -1848.9716, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(-1528.6123, -2022.3357, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(-1604.9429, -1683.9608, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(-2093.9446, -1255.051, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(-1913.1727, -1021.4849, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(-1696.1758, -1171.4694, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(-881.52594, -872.07263, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(-199.6909, -1251.5964, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(253.0682, -961.7885, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(61.713753, -1204.7433, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(-1162.6761, -801.3727, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(-827.1261, -532.31085, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(-1859.5638, -1375.0872, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(-2190.4783, -971.16943, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(-1102.5421, -617.03973, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(-1230.1471, -985.05096, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(-284.07706, -965.82886, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(-39.65556, -955.6743, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(199.32193, -655.52997, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(57.110893, -682.3474, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(16.99284, -1428.6306, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(283.36722, -1187.2386, 50));
		AddSpawnPoint( "f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Spot(-318.07397, -1350.8408, 50));

		// Kepari Spawn Points
		AddSpawnPoint( "f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Spot(58.4494, -70.15125, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Spot(364.92743, -355.29797, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Spot(714.019, -130.13438, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Spot(568.9863, 101.88119, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Spot(640.0848, 1347.09, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Spot(844.7658, 1365.1249, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Spot(1410.0374, 887.4952, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Spot(273.67453, -258.6258, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Spot(55.509888, 42.085182, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Spot(573.26276, -66.43984, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Spot(480.9249, -237.20544, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Spot(5.529934, -283.4947, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Spot(332.73483, 191.62778, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Spot(611.7602, -202.3158, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Spot(754.5686, 150.08385, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Spot(1899.7706, 671.5776, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Spot(398.05032, -463.74484, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Spot(557.17694, -346.42282, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Spot(1809.2573, 1011.4368, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Spot(134.78165, 142.32861, 30));

		// Kepo_Seed Spawn Points
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(1300.2782, 913.8391, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(1931.5613, 772.4967, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(1804.8387, 648.06195, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(1321.8562, 1158.9425, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(1581.6113, 901.50073, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(861.58453, 163.24721, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(1975.4377, 1006.2004, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(1822.1794, 1044.4264, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(126.16164, 648.1373, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(424.7435, 594.7307, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(118.16637, 838.9589, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(329.66064, 182.60693, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(1470.3584, 1018.9169, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(685.7116, 182.24454, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(1635.8416, 1097.3405, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(2087.9456, 1138.4181, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(347.33978, -278.28528, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(91.706345, -49.4392, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(584.17163, -144.97552, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(1591.6897, 715.3675, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(1448.8992, 645.03217, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(1712.71, 717.3297, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(1886.2555, 945.4282, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(2112.1467, 876.1044, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Spot(1883.7892, 515.412, 30));

		// Kepari Spawn Points
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(-13.035065, -1255.0538, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(237.26703, -926.4242, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(-273.31625, -1144.175, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(-303.98615, -1305.5106, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(-26.420734, -1417.0658, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(263.266, -1108.3916, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(276.04504, -1299.8724, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(-157.35028, -1449.2283, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(-115.88911, -1269.4486, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(27.312227, -1108.5455, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(146.20854, -1263.2964, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(180.51936, -1382.4762, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(215.63641, -1169.9248, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(169.7111, -1040.0194, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(143.56369, -741.80743, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(-71.74532, -855.775, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(-186.35388, -933.60034, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(-326.6498, -943.6748, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(-414.36398, -1203.1302, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(-473.7305, -1078.0852, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(-801.36774, -955.0712, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Spot(-119.70203, -1169.6244, 25));

		// Kepo Spawn Points
		AddSpawnPoint( "f_pilgrimroad_46.Id7", "f_pilgrimroad_46", Spot(267.04187, -260.77466, 9999));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-2106.0679, -1237.0458, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-1925.328, -980.2525, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-1216.1166, -711.5816, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-1850.7633, -1290.0679, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-1061.8298, -898.5639, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-1956.4194, -1090.5004, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-2082.7488, -1055.6984, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-1732.4185, -1215.8318, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-1691.1703, -1116.5148, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-1230.2532, -837.9441, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-1041.59, -638.7179, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-931.3287, -720.68414, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-761.97833, -401.99844, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-818.49634, -298.98056, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-1062.789, -317.19077, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-969.3308, -807.41144, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-1115.2837, -539.6507, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-775.5452, -624.83264, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-918.1368, -551.00806, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-753.5604, -506.65512, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-1248.0044, -962.90063, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-850.1996, -915.1921, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-740.2904, -806.7807, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Spot(-1082.5266, -760.9034, 25));
		AddSpawnPoint( "f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Spot(425.43207, -335.90717, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Spot(17.261768, -81.00122, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Spot(76.15777, 105.58813, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Spot(556.13885, 122.42268, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Spot(635.14923, -91.372765, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Spot(229.33002, -289.82675, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Spot(567.0795, -220.69426, 30));
		AddSpawnPoint( "f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Spot(248.23344, 155.685, 30));

		// Wood_Goblin_Red Spawn Points
		AddSpawnPoint( "f_pilgrimroad_46.Id10", "f_pilgrimroad_46", Spot(322.33435, 125.13283, 2000));

	}
}
