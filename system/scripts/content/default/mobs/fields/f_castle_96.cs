//--- Melia Script -----------------------------------------------------------
// f_castle_96
//
//--- Description -----------------------------------------------------------
// Sets up the f_castle_96 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle96MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_castle_96", MonsterId.ArchGargoyle, Properties("MHP", 706264, "MINPATK", 9583, "MAXPATK", 11680, "MINMATK", 9583, "MAXMATK", 11680, "DEF", 195607, "MDEF", 195607));
		AddPropertyOverrides("f_castle_96", MonsterId.Ghoscat, Properties("MHP", 704041, "MINPATK", 9554, "MAXPATK", 11645, "MINMATK", 9554, "MAXMATK", 11645, "DEF", 194019, "MDEF", 194019));
		AddPropertyOverrides("f_castle_96", MonsterId.Gigglecat, Properties("MHP", 701867, "MINPATK", 9526, "MAXPATK", 11610, "MINMATK", 9526, "MAXMATK", 11610, "DEF", 192465, "MDEF", 192465));

		// Monster Spawners --------------------------------

		AddSpawner("f_castle_96.Id1", MonsterId.ArchGargoyle, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_96.Id2", MonsterId.Ghoscat, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_96.Id3", MonsterId.Gigglecat, 90, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_96.Id4", MonsterId.Ghoscat, 21, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);
		AddSpawner("f_castle_96.Id5", MonsterId.Rootcrystal_04, 30, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// ArchGargoyle Spawn Points
		AddSpawnPoint( "f_castle_96.Id1", "f_castle_96", Spot(-1201.2115, -867.0052, 40));
		AddSpawnPoint( "f_castle_96.Id1", "f_castle_96", Spot(-136.05667, 450.19684, 40));
		AddSpawnPoint( "f_castle_96.Id1", "f_castle_96", Spot(-1.3632741, -1571.4739, 40));
		AddSpawnPoint( "f_castle_96.Id1", "f_castle_96", Spot(-208.0801, -13.589375, 40));
		AddSpawnPoint( "f_castle_96.Id1", "f_castle_96", Spot(203.32172, 411.9818, 40));
		AddSpawnPoint( "f_castle_96.Id1", "f_castle_96", Spot(-1381.5096, -31.895267, 40));
		AddSpawnPoint( "f_castle_96.Id1", "f_castle_96", Spot(-1314.482, 548.67883, 40));
		AddSpawnPoint( "f_castle_96.Id1", "f_castle_96", Spot(-63.28558, 997.2786, 40));
		AddSpawnPoint( "f_castle_96.Id1", "f_castle_96", Spot(1396.297, 1124.2067, 40));
		AddSpawnPoint( "f_castle_96.Id1", "f_castle_96", Spot(944.74744, 132.03897, 40));
		AddSpawnPoint( "f_castle_96.Id1", "f_castle_96", Spot(1429.5277, 199.94556, 40));
		AddSpawnPoint( "f_castle_96.Id1", "f_castle_96", Spot(-918.31696, -658.5719, 40));
		AddSpawnPoint( "f_castle_96.Id1", "f_castle_96", Spot(257.64072, 1166.568, 40));
		AddSpawnPoint( "f_castle_96.Id1", "f_castle_96", Spot(1053.6547, 388.5497, 40));
		AddSpawnPoint( "f_castle_96.Id1", "f_castle_96", Spot(-1275.9312, 857.48724, 40));

		// Ghoscat Spawn Points
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-53.386017, -1713.2478, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(144.88599, -1503.2623, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(131.47449, -1700.6445, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-82.73631, -1486.5411, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-75.51761, -1899.6661, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-155.43033, -1119.8845, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-446.58362, 102.34222, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(860.7234, 79.62172, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(53.08194, -40.207928, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-541.0469, -782.8332, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(54.178818, -312.80136, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(18.271, -56.329903, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(283.49643, 175.9741, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-70.54714, 151.93997, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-381.56842, 142.19092, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-357.66446, -105.60995, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(873.45514, 286.13162, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(1062.7083, -27.920757, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-139.04977, 370.50806, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(253.8854, 542.7381, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(60.642097, 957.2105, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-37.43597, 1135.6544, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(251.56593, 965.4444, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(545.8673, 1167.752, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(1053.2782, 1150.0177, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(1327.1527, 1006.0068, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(1336.2335, 1208.2793, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(1463.6865, 1271.4241, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(1505.5953, 971.60846, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(1594.0891, 268.11322, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(1577.3734, 42.356453, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(1370.666, 78.01363, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(1208.2695, -145.38617, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-929.1564, -861.89636, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-875.6318, -748.4165, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-1195.9738, -746.8822, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-1234.6805, -968.269, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-1287.2303, -872.1591, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-1210.5583, -10.440727, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-1318.3564, -128.83229, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-1389.1433, 56.10643, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-1188.6329, 566.8826, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-1402.8906, 463.22345, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-1431.096, 703.5366, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-1295.9867, 688.98804, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-1345.8577, 857.25995, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(-1169.6036, 683.9943, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(873.9998, -27.843422, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(62.774666, 1266.9003, 20));
		AddSpawnPoint( "f_castle_96.Id2", "f_castle_96", Spot(763.57556, 1154.3989, 20));

		// Gigglecat Spawn Points
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-1349.1841, 781.3801, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-1307.0027, 955.11816, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-1461.18, 770.1278, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-1465.8992, 648.87646, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-1222.9125, 714.2479, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-1250.8091, 342.0402, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-1260.8629, 255.6131, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-1215.5874, 60.38239, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-1172.3041, -150.73624, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-1411.1292, -170.61334, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-1470.0327, -27.89285, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-1134.4537, 2.0205994, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-963.0602, -39.879814, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-897.86163, -2.5272713, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-568.8926, -49.767532, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-531.2304, -14.643478, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-70.41973, -116.84832, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-414.1018, 349.4458, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-189.50858, 433.55972, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-164.85522, 233.32568, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(117.14716, -101.04282, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(268.30518, -99.08298, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(267.22458, 318.01535, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(145.20459, 253.13658, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(62.27217, 608.65137, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(181.91501, 605.16895, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(321.55463, 438.29407, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-1058.2914, -663.9125, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-1062.4388, -794.28625, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-1005.5058, -961.08685, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-885.96643, -941.31903, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-812.0423, -821.31836, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-747.0442, -793.8856, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-667.1265, -762.2741, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-658.2928, -784.54004, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-438.85892, -8.90741, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(61.23447, -1550.6552, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(1084.8846, -95.45143, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(126.34896, -1407.4452, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-103.0907, -1404.2916, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-158.16571, -1270.0729, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-114.16106, -1610.4093, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-136.32536, -1693.0576, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-0.2761631, -1702.0115, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(76.81782, -1455.8708, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(115.93239, -1608.8383, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(104.02261, 1111.4235, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-130.99399, 1139.4087, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(-67.36351, 1249.827, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(190.24115, 916.93304, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(377.9856, 1001.5533, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(356.23145, 803.4603, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(669.53217, 1164.3953, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(872.8279, 1192.514, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(1276.4473, 1116.9928, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(1400.6423, 943.23883, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(1261.4579, 883.44714, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(1528.6257, 1127.2605, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(1511.4739, 296.19296, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(1335.4564, 208.94632, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(1070.2618, 92.661606, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(941.40283, 371.69043, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(832.3507, 130.95898, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(956.88324, -21.883835, 60));
		AddSpawnPoint( "f_castle_96.Id3", "f_castle_96", Spot(560.8763, -20.441984, 60));

		// Ghoscat Spawn Points
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(-166.87312, -143.77713, 20));
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(-68.20155, 4.36162, 20));
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(-242.42961, 146.3308, 20));
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(-429.6744, 239.7204, 20));
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(-265.18152, 336.59314, 20));
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(42.68213, 459.31003, 20));
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(371.28748, -167.26065, 20));
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(370.59894, 16.444775, 20));
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(235.18924, 67.24627, 20));
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(69.96294, -181.9904, 20));
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(33.70602, 56.35526, 20));
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(-121.92125, 70.37584, 20));
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(69.63928, -1660.4883, 20));
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(-41.231453, -1500.933, 20));
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(-978.9551, -769.01013, 20));
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(-131.37407, -31.613087, 20));
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(-26.72017, -82.845245, 20));
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(325.61813, 336.03964, 20));
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(170.36852, -1634.7996, 20));
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(298.888, 544.655, 20));
		AddSpawnPoint( "f_castle_96.Id4", "f_castle_96", Spot(109.46986, 501.32962, 20));

		// Rootcrystal_04 Spawn Points
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(230.72911, -1910.9863, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(-98.47353, -1785.9338, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(130.25096, -1649.6547, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(-55.08384, -1461.7961, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(-12.923962, -1078.0946, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(-347.3442, -780.1899, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(159.00499, -552.2418, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(-236.04646, -43.448277, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(151.07312, -81.65144, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(243.91309, 274.87643, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(-205.79684, 297.50696, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(144.67259, 646.273, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(52.230537, 955.21356, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(295.32697, 1107.4801, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(860.9647, 1193.319, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(1497.3076, 1212.8348, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(1392.0287, 982.6652, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(1600.1667, 252.58897, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(1319.2485, 123.37804, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(1092.1504, -117.85757, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(857.8188, 129.12068, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(1061.8389, 339.0949, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(-709.3317, -27.57086, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(-1384.2455, -106.94247, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(-1210.8541, -6.352379, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(-1265.4409, 383.38156, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(-1421.1632, 709.18494, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(-1164.8356, 799.652, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(-1199.0784, -895.8266, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(-909.6087, -731.71423, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(-611.38904, -767.104, 200));
		AddSpawnPoint( "f_castle_96.Id5", "f_castle_96", Spot(197.3301, -838.96796, 200));

	}
}
