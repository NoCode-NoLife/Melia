//--- Melia Script -----------------------------------------------------------
// d_startower_92
//
//--- Description -----------------------------------------------------------
// Sets up the d_startower_92 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DStartower92MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_startower_92", MonsterId.Pipi, Properties("MHP", 659019, "MINPATK", 8975, "MAXPATK", 10933, "MINMATK", 8975, "MAXMATK", 10933, "DEF", 163153, "MDEF", 163153));
		AddPropertyOverrides("d_startower_92", MonsterId.Piang, Properties("MHP", 661232, "MINPATK", 9004, "MAXPATK", 10968, "MINMATK", 9004, "MAXMATK", 10968, "DEF", 164478, "MDEF", 164478));
		AddPropertyOverrides("d_startower_92", MonsterId.Vespera, Properties("MHP", 663470, "MINPATK", 9033, "MAXPATK", 11003, "MINMATK", 9033, "MAXMATK", 11003, "DEF", 165819, "MDEF", 165819));
		AddPropertyOverrides("d_startower_92", MonsterId.Vesperia, Properties("MHP", 665733, "MINPATK", 9062, "MAXPATK", 11039, "MINMATK", 9062, "MAXMATK", 11039, "DEF", 167174, "MDEF", 167174));

		// Monster Spawners --------------------------------

		AddSpawner("d_startower_92.Id1", MonsterId.Pipi, 60, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_92.Id2", MonsterId.Piang, 55, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_92.Id3", MonsterId.Vespera, 29, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_92.Id4", MonsterId.Vesperia, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_startower_92.Id5", MonsterId.Rootcrystal_02, 22, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Pipi Spawn Points
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-138.70074, 600.4655, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-208.28793, 811.63226, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-623.11444, 1492.0134, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-456.94965, 1421.6609, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-476.74084, 1295.3057, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-235.2241, 1153.2214, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(94.81542, 1283.16, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(103.97581, 1599.0314, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(68.16197, 1465.7506, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(464.28418, 1149.5797, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(555.175, 1290.0234, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(705.4969, 1496.4088, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(690.9829, 1738.4183, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(952.73035, 1312.4868, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(704.1966, 1127.8192, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(882.8374, 985.8547, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(1141.5498, 650.59766, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(1367.3901, 967.8271, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(1575.9899, 896.9344, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(1530.9929, 584.73846, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(1655.762, 985.34564, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(1753.0997, 652.8899, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(1124.3813, 224.4747, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(1222.1989, 7.72898, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(1154.5308, -171.11919, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(1827.7872, 258.31006, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(1553.898, -102.90243, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(1760.2522, -179.1226, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(1101.6234, -468.626, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(1506.3495, -599.3219, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(1427.9603, -890.33923, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(1776.8014, -654.3797, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(1716.5237, -999.98956, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(881.5995, -1266.6818, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(772.64026, -1160.9208, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(906.3573, -931.2807, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(618.35004, -820.6729, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(531.8924, -1109.3901, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(332.3885, -1062.0978, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-32.41356, -1043.8099, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(317.24646, -854.70514, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(317.9002, -616.4529, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(68.80677, -768.9745, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(490.8065, -799.60596, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(386.7921, -546.83545, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-51.601387, -462.1363, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-220.39348, -727.6046, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-200.49399, -626.7093, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-212.16563, -1242.7908, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-429.5409, -1371.8002, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-551.4224, -1676.8657, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-93.062645, -1573.9012, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-104.24129, -1765.8192, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-1229.6083, -581.82904, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-1058.6357, -461.82693, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-1441.7914, -969.8527, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-1584.903, -1308.0862, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-1627.1733, -914.5559, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-1527.2344, -466.81454, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-1334.1687, -270.56622, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-1460.6311, 229.38121, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-1415.3833, 398.08896, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-1232.2465, 415.03592, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-1522.405, 750.22284, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-1195.6829, 664.99646, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-1176.148, 871.8301, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-974.6178, 1186.7441, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-1082.863, 1297.2283, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-1215.6448, 1635.6426, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-1301.7357, 1384.8766, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-1503.6216, 1270.8757, 40));
		AddSpawnPoint( "d_startower_92.Id1", "d_startower_92", Spot(-1290.1643, 1173.5397, 40));

		// Piang Spawn Points
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-113.12392, 690.4054, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-189.1344, 929.7921, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-304.40768, 1125.0438, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-542.89075, 1413.2162, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-67.2215, 1215.964, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-33.69035, 1473.577, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(191.03023, 1529.1704, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(268.2619, 1036.5494, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(503.70255, 1227.3982, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(537.7196, 1382.262, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(751.31256, 1385.4916, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(650.27313, 1595.869, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(454.99545, 1545.1221, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(776.3384, 1578.0645, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(908.8876, 1352.8224, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(705.4835, 1196.422, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(959.28, 1036.7089, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(990.8137, 816.6796, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(1067.7262, 480.45218, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(1151.8982, 320.2245, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(1318.8557, 695.2316, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(1443.6775, 903.2849, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(1634.9547, 594.3095, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(1604.6915, 772.4108, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(1192.231, 70.64731, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(1399.4441, 41.04399, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(1650.7957, 236.34576, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(1667.1655, 20.994488, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(1708.4135, -108.218, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(1168.4082, -367.22784, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(1279.3214, -718.5194, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(1645.782, -679.44904, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(896.90576, -1097.9443, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(813.79956, -985.77484, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(1094.1583, -1020.0165, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(369.63785, -1166.7196, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(624.7726, -904.21936, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(164.06555, -603.9181, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(159.52362, -831.634, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(390.28128, -708.8032, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-113.01408, -937.1799, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-402.6688, -1193.0021, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-309.2611, -1790.0092, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-213.9176, -1394.6117, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-115.36789, -442.20035, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-1132.5392, -659.56104, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-1151.9017, -501.2251, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-1709.7313, -1380.3807, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-1521.3676, -1211.798, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-1626.932, -1026.8573, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-1477.8326, -704.76135, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-1533.8538, -189.84961, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-1409.5562, -6.1280394, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-1503.0496, 131.1338, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-1339.2268, 722.8924, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-1198.1833, 931.11145, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-1371.7778, 477.0907, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-1037.1666, 1559.9456, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-1415.2207, 1134.2246, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-1281.2319, 1523.9708, 25));
		AddSpawnPoint( "d_startower_92.Id2", "d_startower_92", Spot(-1083.7982, 1188.9758, 25));

		// Vespera Spawn Points
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(1590.5588, -700.06146, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(1702.1417, -874.4726, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(1500.9946, -875.97095, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(1077.786, -825.3664, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(1032.1326, -1198.0358, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(1003.4594, -987.6931, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(739.3321, -1018.1403, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(419.7016, -931.41956, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(201.76752, -915.5003, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(17.373466, -708.30963, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(86.93596, -1053.027, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(-132.96037, -851.1641, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(-209.7613, -1049.7614, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(-334.69324, -1305.403, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(-568.96136, -1444.6256, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(-432.85474, -1801.8096, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(-272.13327, -1638.6438, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(-201.17084, -1766.2898, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(-502.91525, -1608.4507, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(-101.93848, -631.47253, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(-98.550156, -316.88193, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(-1103.1432, -581.423, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(1760.6794, 137.58287, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(1540.8512, 161.18053, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(1619.5618, -987.85236, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(1166.396, -567.28973, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(496.6961, -1004.3231, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(-368.04742, -1483.8009, 25));
		AddSpawnPoint( "d_startower_92.Id3", "d_startower_92", Spot(227.72862, -572.78436, 25));

		// Vesperia Spawn Points
		AddSpawnPoint( "d_startower_92.Id4", "d_startower_92", Spot(-1664.016, -1325.3158, 25));
		AddSpawnPoint( "d_startower_92.Id4", "d_startower_92", Spot(-1537.4767, -1089.0726, 25));
		AddSpawnPoint( "d_startower_92.Id4", "d_startower_92", Spot(-1580.2401, -764.2798, 25));
		AddSpawnPoint( "d_startower_92.Id4", "d_startower_92", Spot(-1366.6836, -554.23944, 25));
		AddSpawnPoint( "d_startower_92.Id4", "d_startower_92", Spot(-1341.0289, -135.94719, 25));
		AddSpawnPoint( "d_startower_92.Id4", "d_startower_92", Spot(-1522.8246, -380.20337, 25));
		AddSpawnPoint( "d_startower_92.Id4", "d_startower_92", Spot(-1372.7705, 115.45313, 25));
		AddSpawnPoint( "d_startower_92.Id4", "d_startower_92", Spot(-1565.2524, -27.302814, 25));
		AddSpawnPoint( "d_startower_92.Id4", "d_startower_92", Spot(-1542.4551, 600.0651, 25));
		AddSpawnPoint( "d_startower_92.Id4", "d_startower_92", Spot(-1296.5098, 656.49426, 25));
		AddSpawnPoint( "d_startower_92.Id4", "d_startower_92", Spot(-1346.9253, 1071.438, 25));
		AddSpawnPoint( "d_startower_92.Id4", "d_startower_92", Spot(-1025.3916, 1076.8629, 25));
		AddSpawnPoint( "d_startower_92.Id4", "d_startower_92", Spot(-1121.8812, 1396.7275, 25));
		AddSpawnPoint( "d_startower_92.Id4", "d_startower_92", Spot(-1410.3948, 1515.916, 25));
		AddSpawnPoint( "d_startower_92.Id4", "d_startower_92", Spot(-998.0194, 1507.071, 25));

		// Rootcrystal_02 Spawn Points
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(-102.77535, 580.20166, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(-1616.8398, -1194.0547, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(314.60416, 1062.8297, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(20.926403, 1298.0807, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(-82.268456, -425.0272, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(-319.7501, 1172.9103, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(668.9611, 1496.1654, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(-1132.8298, 987.4729, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(1004.8852, 873.4487, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(-1374.2388, 490.9721, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(-1469.9749, -195.14462, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(-349.2227, -1628.0577, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(-1125.6488, -564.80786, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(1704.3539, 44.5532, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(-245.74625, -1063.5676, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(1567.6195, 763.5314, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(929.6174, -1109.3148, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(1584.7325, -786.645, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(284.39996, -761.0305, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(-1253.1238, 1295.0997, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(1141.2112, -481.11688, 200));
		AddSpawnPoint( "d_startower_92.Id5", "d_startower_92", Spot(1167.0369, 163.46893, 200));

	}
}
