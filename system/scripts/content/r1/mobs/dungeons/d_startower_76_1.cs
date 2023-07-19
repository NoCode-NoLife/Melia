//--- Melia Script -----------------------------------------------------------
// d_startower_76_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Natarh Watchtower' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DStartower761MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_startower_76_1.Id1", MonsterId.ERD_Slime_Dark_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id2", MonsterId.ERD_Flask_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id3", MonsterId.ERD_Defender_Spider_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id4", MonsterId.ERD_Belegg, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id5", MonsterId.ERD_Tombsinker, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id6", MonsterId.ERD_Bavon, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id7", MonsterId.ERD_Bubbe_Mage_Ice, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id8", MonsterId.ERD_Bagworm, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id9", MonsterId.ERD_Hogma_Warrior, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id10", MonsterId.ERD_Hogma_Warrior, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id11", MonsterId.ERD_Zinutekas, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_76_1.Id12", MonsterId.Rootcrystal_02, 19, 25, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'ERD_Slime_Dark_Blue' GenType 2 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1204.78, 375.6, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1053.01, 422.8, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-978.08, 329.81, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1051.2333, 269.26437, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1171.31, 255.39, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1150.18, 116.06, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1074.88, 145.23, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-936.68, 136.92, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-932.99, 26.33, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1038.9, 20.94, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1145.96, -8.46, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1193.81, -33.68, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1161.48, -94.1, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1049.16, -99.46, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-949.46, -93.36, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1213.54, 61.13, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1204.12, 229.83, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-1132.21, 418.7, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-975.18, 222.36, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-872.28, 507.1, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-463.43, 706.1, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-498.84818, 841.7057, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-396.96, 918.98, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-285.08713, 900.40967, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-287.9213, 803.268, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-297.02, 717.11, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-215.07, 688.11, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-144.1349, 699.1247, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-183.18, 759.45, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-233.88957, 844.3812, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-167.28775, 870.66095, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-135.42, 963.69, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-82.79, 873.74, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-84.61, 722.07, 40));
		AddSpawnPoint("d_startower_76_1.Id1", "d_startower_76_1", Rectangle(-392.70294, 804.4307, 40));

		// 'ERD_Flask_Blue' GenType 3 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1407.93, -543.03, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1371.96, -418.98, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1365.87, -297.96, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1226.92, -452.09, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1138.14, -619.08, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1047.04, -531.86, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1118.72, -414.3, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1187.97, -282.91, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1031.66, -242.83, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-893.80023, -280.88367, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-868.61945, -405.74905, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-699.54517, -537.22754, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-836.66473, -525.54065, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-683.3463, -613.8001, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-673.84, -475.4, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-685.19006, -348.98285, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-756.9697, -441.0835, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-963.6217, -366.48907, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-803.76, -245.69, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-726.24, -256.22, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-962.5, -450.36, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1234.48, -599.53, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1491.97, -454.36, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1513.58, -330.77, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-1559.83, -559.98, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-923.29, -606.03, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-776.9789, -606.1053, 40));
		AddSpawnPoint("d_startower_76_1.Id2", "d_startower_76_1", Rectangle(-763.0791, -353.12756, 40));

		// 'ERD_Defender_Spider_Blue' GenType 4 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1161.63, -1230.52, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1104.59, -1107.78, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-925.82, -1042.27, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-939.92, -1123.35, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1013.32, -1123.97, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-861.0453, -1312.5571, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1188.5098, -1293.1428, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1098.6025, -1372.3816, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1147.35, -1445.35, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-969.47, -1355.01, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-893.6, -1414.78, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1078.52, -1286.92, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1178.4, -1127.77, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-896.01, -1187.83, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1066.16, -1195.75, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-959.41, -979.49, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1113.98, -918.78, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-1194.09, -742.9, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-993.3548, -1423.3491, 40));
		AddSpawnPoint("d_startower_76_1.Id3", "d_startower_76_1", Rectangle(-956.4543, -1250.8606, 40));

		// 'ERD_Belegg' GenType 5 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(-193.15, 163.85, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(-74.12, 208.37, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(-142.3, 289.39, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(-103.83, 352.7, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(35.57, 415.52, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(29.9, 330.68, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(94.53, 229.56, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(116.63, 145.87, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(152.59, 138.72, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(179.16, 241.88, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(162.77, 370.45, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(-163.05, 412.51, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(24.67, 205.2, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(-47.9, 73.09, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(113.19, 434.56, 40));
		AddSpawnPoint("d_startower_76_1.Id4", "d_startower_76_1", Rectangle(-234.93, 232.72, 40));

		// 'ERD_Tombsinker' GenType 6 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(-138.15, -886.16, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(14.42, -930.56, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(111.93385, -965.53064, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(74.33389, -1074.5378, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(2.6034698, -1087.132, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(-164.75783, -977.1315, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(-154.28075, -1039.5013, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(-206.95558, -1061.2866, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(-92.5302, -1157.2593, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(-72.70656, -1110.5986, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(28.256165, -1189.2396, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(82.057304, -1143.6818, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(130.03516, -1153.372, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(125.03666, -1047.328, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(-22.03477, -1014.3254, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(95.95434, -914.28033, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(-85.15619, -982.5562, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(-75.622505, -1045.8827, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(42.888657, -982.6469, 40));
		AddSpawnPoint("d_startower_76_1.Id5", "d_startower_76_1", Rectangle(107.66344, -831.2142, 40));

		// 'ERD_Bavon' GenType 7 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(750.5, 496.68, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(845.65, 529.53, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(893.33, 456.13, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(965.17, 530.03, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(983.12, 604.5, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1005.8, 737.21, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(889.7, 719.87, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(762.83, 688.65, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(751.16, 565.67, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1045.8, 834.45, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1030.6, 448.09, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1547.26, -279.32, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1657.52, -256.31, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1617.6747, -338.4563, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1570.25, -387.5, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1564.39, -453.69, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1677.31, -453.1, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1770.81, -339.79, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1785.77, -438.2, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1834.25, -355.53, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1875.74, -447.81, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1958.53, -442.2, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1907.65, -379.22, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1901.74, -553.98, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(2070.25, -478.84, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1462.57, -357.68, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1367.0903, -320.85056, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(2213.73, -562.29, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1212.2, -319.19, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(1287, -347.09, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(2432.2, -554.85, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(2567.75, -461.64, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(2748.29, -309.99, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(2817.35, -171.03, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(2664.55, -417.9, 40));
		AddSpawnPoint("d_startower_76_1.Id6", "d_startower_76_1", Rectangle(2343.45, -561.76, 40));

		// 'ERD_Bubbe_Mage_Ice' GenType 8 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(746.05, -654.23, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(928.54, -645.02, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(1007.41, -477.14, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(878.67, -543.5, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(774.34, -419.22, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(707.16, -526.26, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(804.22, -760.75, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(949.53, -733.29, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(904.63, -398.66, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(901.78, -463.59, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(771.03, -306.83, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(923.96, -310.14, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(964.65, -248.17, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(893.1, -227.78, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(780.59, -174.47, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(815.06, -44.96, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(955.74, -114.93, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(1004.71, -38.94, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(919.37, 29.35, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(729.81, 115.95, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(925.55, 130.78, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(1000.18, 120.62, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(844.44, -134.2, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(687.5, -107.49, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(694.28, -243.91, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(1024.68, -371.66, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(701.05, -766.48, 40));
		AddSpawnPoint("d_startower_76_1.Id7", "d_startower_76_1", Rectangle(995.29, -663.66, 40));

		// 'ERD_Bagworm' GenType 9 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id8", "d_startower_76_1", Rectangle(830.18, -491.65, 9999));

		// 'ERD_Hogma_Warrior' GenType 10 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(-226.66, -621.45, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(-259.77, -429.08, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(-317.7081, -516.52826, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(-119.87, -342.96, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(22.625153, -533.7568, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(61.16, -663.35, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(279.55664, -476.20035, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(80.75, -319.09, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(-140.56, -230.43, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(-310.58, -323.2, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(6.59, -377.23, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(-110.15955, -575.04425, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(383.20142, -492.89017, 40));
		AddSpawnPoint("d_startower_76_1.Id9", "d_startower_76_1", Rectangle(9.280334, -207.76492, 40));

		// 'ERD_Hogma_Warrior' GenType 11 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2140.11, -99.74, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2281.82, 45.19, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2408.29, -46.14, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2468.06, -263.81, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2316.36, -347.34, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2213.99, -270.1, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2102.69, -348.28, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2218.52, -427.58, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2537.88, -372.48, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2659.55, -211.36, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2698.04, -63.83, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2677.41, 104.7, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2532.94, 72.21, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2351, 185.68, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2014.31, -61.08, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2105.97, -216.53, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2132.5, 109.46, 40));
		AddSpawnPoint("d_startower_76_1.Id10", "d_startower_76_1", Rectangle(2459.53, 60.99, 40));

		// 'ERD_Zinutekas' GenType 12 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2429.34, 788.66, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2458.15, 881.76, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2577.53, 919.74, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2513.7764, 811.4783, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2562.1018, 743.37195, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2452.08, 955.88, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2619.03, 954.77, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2661.87, 794.93, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2641.3513, 694.6405, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2463.07, 684.91, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2416.31, 604.37, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2449.77, 529.66, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2499.18, 464.83, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2588.21, 392.27, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2544.52, 349.16, 40));
		AddSpawnPoint("d_startower_76_1.Id11", "d_startower_76_1", Rectangle(2585.9412, 830.37164, 40));

		// 'Rootcrystal_02' GenType 17 Spawn Points
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(112.1716, -532.49915, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-1164.3083, 367.14197, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-1429.34, -478.2, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-875.17, -473.66, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-952.84216, -1119.5767, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-6.01, -1032.47, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(908.6082, -431.20502, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(903.52, -150.59, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(801.14, 565.13, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-93.46, 228.21, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-231.25, 841.2, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-1106.15, 787.53, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-1272.9332, 795.43475, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(1626.71, -220.52, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(2199.71, -249.24, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(2443.81, 18.43, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(2090.65, 59.05, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(2388.42, -431.98, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(2652.51, -416.69, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(2528.58, 415.16, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(2516.52, 887.59, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-202.88, -323.9, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-261.17, -626.52, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-1164.11, -123.87, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-977.61664, 128.1704, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-1021.2494, -554.1035, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(-1136.3632, -1338.4564, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(576.40894, -588.80475, 200));
		AddSpawnPoint("d_startower_76_1.Id12", "d_startower_76_1", Rectangle(740.15247, -314.08997, 200));
	}
}
