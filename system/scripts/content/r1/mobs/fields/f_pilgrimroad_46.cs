//--- Melia Script -----------------------------------------------------------
// f_pilgrimroad_46
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Starving Demon's Way' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad46MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_pilgrimroad_46", MonsterId.Kepari, Properties("MHP", 125041, "MINPATK", 2109, "MAXPATK", 2494, "MINMATK", 2109, "MAXMATK", 2494, "DEF", 1994, "MDEF", 1994));
		AddPropertyOverrides("f_pilgrimroad_46", MonsterId.Kepo_Seed, Properties("MHP", 125299, "MINPATK", 2112, "MAXPATK", 2498, "MINMATK", 2112, "MAXMATK", 2498, "DEF", 2009, "MDEF", 2009));
		AddPropertyOverrides("f_pilgrimroad_46", MonsterId.Wood_Goblin_Red, Properties("MHP", 125772, "MINPATK", 2118, "MAXPATK", 2506, "MINMATK", 2118, "MAXMATK", 2506, "DEF", 2036, "MDEF", 2036));
		AddPropertyOverrides("f_pilgrimroad_46", MonsterId.Kepo, Properties("MHP", 126384, "MINPATK", 2126, "MAXPATK", 2515, "MINMATK", 2126, "MAXMATK", 2515, "DEF", 2071, "MDEF", 2071));

		// Monster Spawners ---------------------------------

		AddSpawner("f_pilgrimroad_46.Id1", MonsterId.Kepari, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id2", MonsterId.Rootcrystal_01, 11, 14, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id3", MonsterId.Kepari, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id4", MonsterId.Kepo_Seed, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id5", MonsterId.Kepo_Seed, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id6", MonsterId.Kepari, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id7", MonsterId.Kepo, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id8", MonsterId.Kepo, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id9", MonsterId.Kepo, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_46.Id10", MonsterId.Wood_Goblin_Red, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Kepari' GenType 16 Spawn Points
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(58.4494, -70.15125, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(364.92743, -355.29797, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(714.019, -130.13438, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(568.9863, 101.88119, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(640.0848, 1347.09, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(844.7658, 1365.1249, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(1410.0374, 887.4952, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(273.67453, -258.6258, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(55.509888, 42.085182, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(573.26276, -66.43984, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(480.9249, -237.20544, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(5.529934, -283.4947, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(332.73483, 191.62778, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(611.7602, -202.3158, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(754.5686, 150.08385, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(1899.7706, 671.5776, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(398.05032, -463.74484, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(557.17694, -346.42282, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(1809.2573, 1011.4368, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id1", "f_pilgrimroad_46", Rectangle(134.78165, 142.32861, 30));

		// 'Rootcrystal_01' GenType 30 Spawn Points
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(-1816.7163, -1913.9637, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(-1933.0756, -1051.4459, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(-1040.3562, -749.8858, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(-1311.1724, -172.15028, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(-365.1689, -1148.7295, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(241.37259, -1041.9418, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(448.08194, -342.28644, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(554.72485, 176.58028, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(338.11932, 717.62756, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(1344.7881, 88.921265, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(1889.5366, 189.17409, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(1812.2513, 1019.256, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(1285.3344, 825.3493, 40));
		AddSpawnPoint("f_pilgrimroad_46.Id2", "f_pilgrimroad_46", Rectangle(618.98047, 1387.9956, 40));

		// 'Kepari' GenType 36 Spawn Points
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(540.8157, 336.89246, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(301.9332, 594.594, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(16.117188, 771.19104, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(83.902855, 551.4256, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(148.47517, 678.99475, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(181.9604, 808.55475, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1537.2004, -329.67563, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1772.0273, -376.05957, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1995.2882, -317.32364, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(2067.7917, -77.447845, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1721.2559, -193.32808, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1877.7076, 36.671722, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1644.409, 13.505814, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1864.1654, 208.62308, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1376.065, 21.321215, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1793.596, -109.50809, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1982.7877, -96.02672, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1435.5555, -202.16919, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1668.1561, 202.90002, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(507.77997, 622.907, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(287.29517, 719.6351, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(227.92415, 532.4565, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(513.24896, 447.82227, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1215.897, 58.76411, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id3", "f_pilgrimroad_46", Rectangle(1314.3289, 162.35693, 25));

		// 'Kepo_Seed' GenType 44 Spawn Points
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-1840.6755, -1789.9282, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-1380.9435, -1848.9716, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-1528.6123, -2022.3357, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-1604.9429, -1683.9608, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-2093.9446, -1255.051, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-1913.1727, -1021.4849, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-1696.1758, -1171.4694, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-881.52594, -872.07263, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-199.6909, -1251.5964, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(253.0682, -961.7885, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(61.713753, -1204.7433, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-1162.6761, -801.3727, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-827.1261, -532.31085, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-1859.5638, -1375.0872, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-2190.4783, -971.16943, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-1102.5421, -617.03973, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-1230.1471, -985.05096, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-284.07706, -965.82886, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-39.65556, -955.6743, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(199.32193, -655.52997, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(57.110893, -682.3474, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(16.99284, -1428.6306, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(283.36722, -1187.2386, 50));
		AddSpawnPoint("f_pilgrimroad_46.Id4", "f_pilgrimroad_46", Rectangle(-318.07397, -1350.8408, 50));

		// 'Kepo_Seed' GenType 45 Spawn Points
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1300.2782, 913.8391, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1931.5613, 772.4967, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1804.8387, 648.06195, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1321.8562, 1158.9425, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1581.6113, 901.50073, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(861.58453, 163.24721, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1975.4377, 1006.2004, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1822.1794, 1044.4264, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(126.16164, 648.1373, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(424.7435, 594.7307, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(118.16637, 838.9589, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(329.66064, 182.60693, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1470.3584, 1018.9169, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(685.7116, 182.24454, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1635.8416, 1097.3405, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(2087.9456, 1138.4181, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(347.33978, -278.28528, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(91.706345, -49.4392, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(584.17163, -144.97552, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1591.6897, 715.3675, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1448.8992, 645.03217, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1712.71, 717.3297, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1886.2555, 945.4282, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(2112.1467, 876.1044, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id5", "f_pilgrimroad_46", Rectangle(1883.7892, 515.412, 30));

		// 'Kepari' GenType 46 Spawn Points
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-13.035065, -1255.0538, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(237.26703, -926.4242, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-273.31625, -1144.175, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-303.98615, -1305.5106, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-26.420734, -1417.0658, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(263.266, -1108.3916, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(276.04504, -1299.8724, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-157.35028, -1449.2283, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-115.88911, -1269.4486, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(27.312227, -1108.5455, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(146.20854, -1263.2964, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(180.51936, -1382.4762, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(215.63641, -1169.9248, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(169.7111, -1040.0194, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(143.56369, -741.80743, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-71.74532, -855.775, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-186.35388, -933.60034, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-326.6498, -943.6748, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-414.36398, -1203.1302, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-473.7305, -1078.0852, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-801.36774, -955.0712, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id6", "f_pilgrimroad_46", Rectangle(-119.70203, -1169.6244, 25));

		// 'Kepo' GenType 49 Spawn Points
		AddSpawnPoint("f_pilgrimroad_46.Id7", "f_pilgrimroad_46", Rectangle(267.04187, -260.77466, 9999));

		// 'Kepo' GenType 50 Spawn Points
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-2106.0679, -1237.0458, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1925.328, -980.2525, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1216.1166, -711.5816, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1850.7633, -1290.0679, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1061.8298, -898.5639, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1956.4194, -1090.5004, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-2082.7488, -1055.6984, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1732.4185, -1215.8318, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1691.1703, -1116.5148, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1230.2532, -837.9441, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1041.59, -638.7179, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-931.3287, -720.68414, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-761.97833, -401.99844, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-818.49634, -298.98056, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1062.789, -317.19077, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-969.3308, -807.41144, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1115.2837, -539.6507, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-775.5452, -624.83264, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-918.1368, -551.00806, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-753.5604, -506.65512, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1248.0044, -962.90063, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-850.1996, -915.1921, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-740.2904, -806.7807, 25));
		AddSpawnPoint("f_pilgrimroad_46.Id8", "f_pilgrimroad_46", Rectangle(-1082.5266, -760.9034, 25));

		// 'Kepo' GenType 51 Spawn Points
		AddSpawnPoint("f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Rectangle(425.43207, -335.90717, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Rectangle(17.261768, -81.00122, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Rectangle(76.15777, 105.58813, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Rectangle(556.13885, 122.42268, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Rectangle(635.14923, -91.372765, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Rectangle(229.33002, -289.82675, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Rectangle(567.0795, -220.69426, 30));
		AddSpawnPoint("f_pilgrimroad_46.Id9", "f_pilgrimroad_46", Rectangle(248.23344, 155.685, 30));

		// 'Wood_Goblin_Red' GenType 58 Spawn Points
		AddSpawnPoint("f_pilgrimroad_46.Id10", "f_pilgrimroad_46", Rectangle(322.33435, 125.13283, 2000));
	}
}
