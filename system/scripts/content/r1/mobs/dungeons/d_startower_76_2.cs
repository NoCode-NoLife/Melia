//--- Melia Script -----------------------------------------------------------
// d_startower_76_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Nazarene Tower' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DStartower762MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_startower_76_2.Id1", MonsterId.ERD_Tiny, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id2", MonsterId.ERD_Hook_Remain, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id3", MonsterId.ERD_Operor, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id4", MonsterId.ERD_Rafflesia_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id5", MonsterId.ERD_TerraNymph, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id6", MonsterId.ERD_Hohen_Orben_Green, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id7", MonsterId.ERD_Ragged_Bird, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id8", MonsterId.ERD_Truffle, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id9", MonsterId.ERD_Hohen_Orben_Red, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id10", MonsterId.ERD_Big_Cockatries_Red, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id11", MonsterId.ERD_Nuo_Purple, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id12", MonsterId.ERD_Quartz_Weaver, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id13", MonsterId.ERD_Jukotail, 60, 80, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id14", MonsterId.ERD_Jukotail, 3, 3, TimeSpan.FromMilliseconds(30000), TendencyType.Aggressive);
		AddSpawner("d_startower_76_2.Id15", MonsterId.Rootcrystal_02, 23, 30, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'ERD_Tiny' GenType 19 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-760.3872, 855.8056, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-649.371, 878.1699, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-549.30444, 810.2288, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-668.5881, 763.3654, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-577.35815, 742.00903, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-572.42645, 891.78754, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-658.34985, 681.61035, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-690.2356, 814.2895, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-617.0581, 808.34937, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-531.3247, 1048.2162, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-471.2097, 961.0096, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-411.04123, 868.9174, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-356.84613, 772.90137, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-581.25604, 595.015, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-503.75616, 541.65485, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-481.26227, 642.1003, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-376.2455, 620.16016, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-292.35754, 687.27875, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-1230.47, -411.7004, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-1246.1241, -218.46742, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-1285.3153, 7.0263405, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-934.2816, 58.793015, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-875.6927, -356.81088, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-541.0522, -293.37698, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-584.1863, -100.68056, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(-600.85645, 110.46975, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(1281.7057, -822.4201, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(1256.076, -624.5177, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(1214.6018, -405.9706, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(1577.5619, -356.6572, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(1624.534, -773.94684, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(1954.5243, -720.9199, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(1930.0858, -533.50604, 40));
		AddSpawnPoint("d_startower_76_2.Id1", "d_startower_76_2", Rectangle(1911.4232, -306.72342, 40));

		// 'ERD_Hook_Remain' GenType 20 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-960.17865, -946.6078, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-834.1776, -940.1897, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-903.0118, -861.0516, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-752.82904, -802.811, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-771.8432, -704.14557, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-638.4909, -697.27264, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-943.043, -784.3041, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-849.03906, -1121.9788, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-751.40436, -1049.4658, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-681.1658, -1145.2842, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-649.8599, -996.75696, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-481.05188, -954.7538, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-575.8137, -896.1867, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-609.7788, -759.6964, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-668.09705, -887.32043, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-473.90308, -1701.2554, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-357.7942, -1700.0393, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-374.59235, -1843.013, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-215.55441, -1721.0535, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-267.52615, -1594.4619, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-285.39694, -1757.9205, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(218.7742, -1525.9662, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(358.37634, -1581.7261, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(244.1071, -1478.0103, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(414.74652, -1510.7744, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(247.1454, -1390.317, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(277.4929, -1246.6747, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(377.18713, -1286.7439, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(474.93964, -1273.1382, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(477.1231, -1409.88, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(373.251, -1227.2003, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(302.87378, -1145.7612, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(239.63472, -1311.9725, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-349.17136, -1541.3312, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-339.26263, -887.7488, 40));
		AddSpawnPoint("d_startower_76_2.Id2", "d_startower_76_2", Rectangle(-224.95685, -903.6156, 40));

		// 'ERD_Operor' GenType 21 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-2086.4822, -460.30768, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-2067.747, -320.44418, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1991.4767, -417.38495, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1830.4653, -298.41876, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1975.1385, -198.09846, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1867.6702, -68.4334, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-2048.779, -72.15875, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1785.3551, -128.38481, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1695.9606, -355.50165, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1791.2117, -505.2758, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1971.8855, -547.8585, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1855.0302, -452.52213, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1894.8165, -351.50336, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1784.776, -353.8005, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1742.1078, -10.845291, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1630.327, -129.01149, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1576.0571, -309.22992, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1714.3851, -647.9318, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1807.7261, -782.92126, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1607.4456, -668.4055, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1677.9553, -808.20215, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1444.8804, -756.09686, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1819.2559, -923.45905, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1743.9274, -1034.6444, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1658.3103, -951.1854, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1606.2711, -1071.05, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1458.4291, -1073.8883, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1498.1002, -969.7218, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1380.7572, -999.8426, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1318.5908, -906.1654, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1480.2452, -866.25037, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1137.5492, -858.5013, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1566.4764, -789.0585, 40));
		AddSpawnPoint("d_startower_76_2.Id3", "d_startower_76_2", Rectangle(-1685.6504, -1143.0565, 40));

		// 'ERD_Rafflesia_Green' GenType 22 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-219.6618, -1418.7319, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-109.54192, -1320.1478, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(20.106943, -1326.8542, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(123.10709, -1312.3784, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-137.06822, -1146.3967, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-68.066925, -1072.8209, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-112.35557, -982.0191, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-54.69742, -763.0097, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-105.71759, -706.7307, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-50.167465, -551.5352, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(66.19516, -510.28333, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(126.66095, -538.4385, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-120.81911, -458.34048, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-86.20522, -314.43817, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-171.35538, -270.3268, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-138.27834, -71.59732, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-224.88435, 56.086605, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-132.13318, 152.18661, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-30.766304, 103.62439, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-296.60764, 265.7021, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-312.86716, 439.5195, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-466.5558, -371.17172, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-409.29428, -288.31287, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-482.05432, -268.32376, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-416.96582, -209.93085, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-566.83093, -383.5224, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(-337.38904, -327.64746, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(644.8539, 354.5679, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(725.96185, 369.0471, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(682.73694, 272.51096, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(763.4665, 271.93802, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(809.3998, 385.99472, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(835.3435, 228.26003, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(908.1114, 198.1492, 40));
		AddSpawnPoint("d_startower_76_2.Id4", "d_startower_76_2", Rectangle(873.73096, 445.3714, 40));

		// 'ERD_TerraNymph' GenType 23 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(280.72708, -350.28473, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(298.6929, -512.68677, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(369.39807, -477.2687, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(450.45035, -410.79437, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(435.02466, -494.94333, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(570.13855, -350.15475, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(490.62808, -556.0699, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(390.87827, -567.47815, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(308.88086, -770.2021, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(416.22064, -686.1446, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(520.5564, -622.0875, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(554.33417, -777.12524, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(426.85428, -786.32697, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(576.88715, -563.0614, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(225.68124, -51.776627, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(245.2017, 36.901604, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(193.10782, 95.5188, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(180.47766, 233.47885, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(260.74573, 349.75812, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(349.26935, 313.25598, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(372.45905, 404.65765, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(417.1714, 250.84561, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(434.21582, 146.5714, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(338.6767, 58.3904, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(370.8234, -13.390992, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(462.4209, 45.909718, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(161.02711, 362.31543, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(69.23372, 172.99583, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(-92.01532, 633.61053, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(59.189457, 691.26, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(-57.374504, 748.0082, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(-92.34834, 906.67346, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(163.16913, 777.27765, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(41.124866, 1025.7756, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(241.20992, 1053.8818, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(312.91696, 873.7679, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(-60.779465, 1075.6797, 40));
		AddSpawnPoint("d_startower_76_2.Id5", "d_startower_76_2", Rectangle(92.29674, 1148.9048, 40));

		// 'ERD_Hohen_Orben_Green' GenType 24 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id6", "d_startower_76_2", Rectangle(-1124.0903, -274.2597, 40));
		AddSpawnPoint("d_startower_76_2.Id6", "d_startower_76_2", Rectangle(-1146.1646, -89.409035, 40));
		AddSpawnPoint("d_startower_76_2.Id6", "d_startower_76_2", Rectangle(-735.2773, -211.68347, 40));
		AddSpawnPoint("d_startower_76_2.Id6", "d_startower_76_2", Rectangle(-751.1652, -46.036045, 40));
		AddSpawnPoint("d_startower_76_2.Id6", "d_startower_76_2", Rectangle(-1583.3951, -892.9298, 40));
		AddSpawnPoint("d_startower_76_2.Id6", "d_startower_76_2", Rectangle(-734.7035, -971.8405, 40));
		AddSpawnPoint("d_startower_76_2.Id6", "d_startower_76_2", Rectangle(-1977.2291, -316.03357, 40));

		// 'ERD_Ragged_Bird' GenType 25 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1296.6953, -375.43915, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1277.1622, -276.69022, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1130.5458, -385.75418, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1113.8933, -177.9462, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1349.2969, -168.52487, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1330.2789, -103.95956, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1172.3129, 0.69656396, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1054.3573, 33.510895, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1028.86, -337.1914, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-921.0851, -267.8194, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-775.2371, -330.79773, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-808.9974, -151.20279, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-837.93524, -37.91855, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-996.0908, -105.64513, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-663.0099, -306.47052, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-570.723, -186.3335, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-675.93634, -135.15056, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-616.51373, -16.732937, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-472.7611, -51.61573, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-487.81985, 68.353775, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-716.775, 94.85655, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-816.3659, 79.398964, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-928.70245, -43.446274, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1382.2911, -3.9162827, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-1334.5106, -448.59784, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-998.8535, -203.55527, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-495.98212, 177.27412, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-164.44626, 837.77783, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-123.94967, 1001.7418, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-35.758057, 864.7808, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(-9.326549, 988.4732, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(127.03257, 1093.6575, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(3.490631, 1184.0961, 40));
		AddSpawnPoint("d_startower_76_2.Id7", "d_startower_76_2", Rectangle(2.354828, 766.3188, 40));

		// 'ERD_Truffle' GenType 26 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(75.722015, 837.7288, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(168.91217, 873.9808, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(168.52428, 999.33124, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(247.28784, 951.8399, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(261.46606, 1139.1156, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(344.96207, 1021.7671, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(242.94556, 817.86664, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(193.71664, 685.3346, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1140.6365, -892.1424, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1182.6694, -746.17255, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1329.233, -720.6778, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1167.138, -620.9783, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1225.1891, -525.0559, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1374.8019, -537.34503, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1112.4855, -402.3983, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1399.9169, -395.55267, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1578.6263, -506.11972, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1511.3334, -684.97864, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1437.2368, -817.8888, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1670.6013, -579.2992, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1510.9174, -581.6245, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1659.793, -454.6179, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1854.6554, -678.1546, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1758.7112, -779.4011, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1831.1987, -490.2975, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1753.0509, -324.29175, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1971.9192, -396.36664, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(2026.4143, -232.8259, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(2091.3833, -571.0304, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(2084.4768, -740.6061, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1696.7067, -686.25757, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1488.22, -466.7782, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1310.7983, -422.17752, 40));
		AddSpawnPoint("d_startower_76_2.Id8", "d_startower_76_2", Rectangle(1303.1187, -280.0489, 40));

		// 'ERD_Hohen_Orben_Red' GenType 27 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id9", "d_startower_76_2", Rectangle(1434.3893, -675.6538, 40));
		AddSpawnPoint("d_startower_76_2.Id9", "d_startower_76_2", Rectangle(1400.4836, -474.19376, 40));
		AddSpawnPoint("d_startower_76_2.Id9", "d_startower_76_2", Rectangle(1802.8234, -621.5607, 40));
		AddSpawnPoint("d_startower_76_2.Id9", "d_startower_76_2", Rectangle(1781.3138, -438.3783, 40));
		AddSpawnPoint("d_startower_76_2.Id9", "d_startower_76_2", Rectangle(1054.707, 230.4726, 40));
		AddSpawnPoint("d_startower_76_2.Id9", "d_startower_76_2", Rectangle(1038.8235, 392.59982, 40));
		AddSpawnPoint("d_startower_76_2.Id9", "d_startower_76_2", Rectangle(1272.131, 318.27957, 40));
		AddSpawnPoint("d_startower_76_2.Id9", "d_startower_76_2", Rectangle(1299.9408, 551.3408, 40));

		// 'ERD_Big_Cockatries_Red' GenType 28 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id10", "d_startower_76_2", Rectangle(818.24316, -1696.1718, 40));
		AddSpawnPoint("d_startower_76_2.Id10", "d_startower_76_2", Rectangle(782.5653, -1455.9382, 40));
		AddSpawnPoint("d_startower_76_2.Id10", "d_startower_76_2", Rectangle(1088.9093, -1684.126, 40));
		AddSpawnPoint("d_startower_76_2.Id10", "d_startower_76_2", Rectangle(1121.2057, -1439.868, 40));
		AddSpawnPoint("d_startower_76_2.Id10", "d_startower_76_2", Rectangle(927.2642, -1183.2228, 40));

		// 'ERD_Nuo_Purple' GenType 29 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1006.4818, 547.61536, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1137.74, 684.85126, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1146.111, 525.8569, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1141.4673, 817.4328, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1333.599, 644.68195, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1245.6599, 471.33893, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1382.3883, 461.59555, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1362.4309, 311.23758, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1476.9176, 401.25452, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1180.323, 360.3497, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1181.3925, 191.16934, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1344.6322, 241.64117, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1297.1119, 122.94817, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1134.1846, 75.53427, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1014.4174, 106.21677, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(955.2205, 327.326, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(968.1865, 454.45407, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1113.6915, 457.64575, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1217.4364, 617.25287, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1023.1516, 637.1056, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(916.6798, 545.2906, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1425.241, 200.78516, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1253.564, -65.307106, 40));
		AddSpawnPoint("d_startower_76_2.Id11", "d_startower_76_2", Rectangle(1291.6125, -179.13663, 40));

		// 'ERD_Quartz_Weaver' GenType 30 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(848.4203, -1332.5482, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1014.3915, -1380.5192, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(695.1373, -1417.0541, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(671.92957, -1565.8606, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(767.6205, -1560.5623, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(729.33746, -1683.2039, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(804.9382, -1787.0695, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(896.365, -1693.9098, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1030.7997, -1824.1128, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1011.0717, -1639.8306, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1123.2408, -1588.0038, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1220.6603, -1562.6385, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1058.6262, -1517.9442, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(970.9862, -1451.1553, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(881.6404, -1603.37, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(906.88983, -1409.9922, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1076.8705, -1236.3406, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1137.941, -1153.8589, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1238.7213, -1165.3254, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1363.0652, -1083.6716, 40));
		AddSpawnPoint("d_startower_76_2.Id12", "d_startower_76_2", Rectangle(1443.6674, -992.21594, 40));

		// 'ERD_Jukotail' GenType 31 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id13", "d_startower_76_2", Rectangle(-76.05017, -458.8371, 9999));

		// 'ERD_Jukotail' GenType 33 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id14", "d_startower_76_2", Rectangle(-103.73143, -506.78748, 9999));

		// 'Rootcrystal_02' GenType 34 Spawn Points
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-442.7534, -1701.3809, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-217.36613, -1707.4668, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-124.71066, -1272.4277, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(359.02325, -1540.0839, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(336.85602, -1237.2206, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-86.28822, -759.1389, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-586.13904, -900.59436, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-974.32196, -909.62744, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-1448.7211, -983.3011, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-1724.4614, -832.07605, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-1580.9156, -269.63113, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-1870.0531, -110.04373, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-2158.9966, -259.7165, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-1887.9171, -435.75732, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-1257.0686, -64.985054, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-852.3071, -303.60193, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-561.0368, 35.888245, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-144.96686, -262.52197, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-322.80984, 344.79544, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-649.69385, 892.7307, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-354.8812, 751.9586, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(130.39081, 1060.6602, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(5.2650757, 714.7108, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(-8.479115, 114.74902, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(354.10794, 197.35109, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(833.20123, 306.85406, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(1283.5552, 253.46175, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(1270.4415, -164.63797, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(1244.0979, -564.9174, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(1956.4916, -423.7907, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(1250.7714, -1163.2311, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(1110.169, -1538.4585, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(777.656, -1551.7433, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(1639.5259, -718.65546, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(1169.6459, 681.6421, 200));
		AddSpawnPoint("d_startower_76_2.Id15", "d_startower_76_2", Rectangle(429.6848, -571.3829, 200));
	}
}
