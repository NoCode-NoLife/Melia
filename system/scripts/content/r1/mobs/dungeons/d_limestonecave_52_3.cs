//--- Melia Script -----------------------------------------------------------
// d_limestonecave_52_3
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Tevhrin Stalactite Cave Section 3' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DLimestonecave523MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_limestonecave_52_3", MonsterId.Flamme_Priest_Green, Properties("MHP", 482680, "MINPATK", 6708, "MAXPATK", 8146, "MINMATK", 6708, "MAXMATK", 8146, "DEF", 73282, "MDEF", 73282));
		AddPropertyOverrides("d_limestonecave_52_3", MonsterId.Flamme_Mage_Green, Properties("MHP", 484899, "MINPATK", 6736, "MAXPATK", 8181, "MINMATK", 6736, "MAXMATK", 8181, "DEF", 74172, "MDEF", 74172));
		AddPropertyOverrides("d_limestonecave_52_3", MonsterId.Bavon_Green, Properties("MHP", 487176, "MINPATK", 6766, "MAXPATK", 8217, "MINMATK", 6766, "MAXMATK", 8217, "DEF", 75086, "MDEF", 75086));
		AddPropertyOverrides("d_limestonecave_52_3", MonsterId.Rubblem_Green, Properties("MHP", 489512, "MINPATK", 6796, "MAXPATK", 8254, "MINMATK", 6796, "MAXMATK", 8254, "DEF", 76023, "MDEF", 76023));
		AddPropertyOverrides("d_limestonecave_52_3", MonsterId.Rocktanon, Properties("MHP", 491904, "MINPATK", 6826, "MAXPATK", 8292, "MINMATK", 6826, "MAXMATK", 8292, "DEF", 76983, "MDEF", 76983));
		AddPropertyOverrides("d_limestonecave_52_3", MonsterId.Boss_Stalakan, Properties("MHP", 2521187, "MINPATK", 16459, "MAXPATK", 19993, "MINMATK", 16459, "MAXMATK", 19993, "DEF", 187115, "MDEF", 187115));

		// Monster Spawners ---------------------------------

		AddSpawner("d_limestonecave_52_3.Id1", MonsterId.Flamme_Priest_Green, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_3.Id2", MonsterId.Flamme_Mage_Green, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_3.Id3", MonsterId.Bavon_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_3.Id4", MonsterId.Rubblem_Green, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_3.Id5", MonsterId.Bavon_Green, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_3.Id6", MonsterId.Flamme_Priest_Green, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_3.Id7", MonsterId.Rootcrystal_04, 19, 25, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_limestonecave_52_3.Id8", MonsterId.Rocktanon, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Flamme_Priest_Green' GenType 20 Spawn Points
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1822.918, -276.20517, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1850.627, 432.6938, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1960.5896, -184.09651, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1878.9836, -31.786081, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-2102.9746, 486.45352, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1972.5902, 569.47186, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1882.934, 659.1721, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1843.513, 538.9344, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1953.2347, -314.4797, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1960.3654, -685.89325, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-2116.4163, -940.02386, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-2004.9653, -1031.0662, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1862.779, -913.77686, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Rectangle(-1837.8253, -773.15344, 30));

		// 'Flamme_Mage_Green' GenType 21 Spawn Points
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-1207.5293, -101.90356, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-1939.8303, -144.52919, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-1982.2693, 586.2672, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-1220.6505, 48.754135, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-1029.4529, 12.60233, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-1157.943, -359.87946, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-748.79456, 187.07953, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-272.80768, -417.27728, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-389.49496, -501.01657, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(1141.9314, -528.6318, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-4.733101, -1438.057, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(85.951065, -1374.186, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(337.77545, -562.4278, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(1229.9528, 3.3099525, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(1105.631, 263.66064, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(1294.6536, 551.6924, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(97.30046, 386.43878, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(188.3407, 545.5392, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-454.06088, 190.68187, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-508.7755, 431.60266, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-279.85773, 377.09073, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-408.67014, 285.16766, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-2045.0656, -172.00691, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-1932.7089, 413.9841, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-481.24008, -358.05533, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(253.45941, -702.9854, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(1259.7588, -315.74045, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-1060.9425, -196.38864, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Rectangle(-1126.2074, 238.36668, 30));

		// 'Bavon_Green' GenType 22 Spawn Points
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-682.53125, -666.74414, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-7.838619, -1454.5829, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(15.583963, -1321.5673, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(12.42955, -1437.056, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(246.2413, -1467.5687, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(286.57562, -1490.6975, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(535.38983, -1322.3516, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-0.4986148, -1220.6365, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(470.08258, -867.67163, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-573.8659, -750.2539, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-525.5801, -571.5688, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-465.4162, -659.8184, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-275.1703, -472.9236, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-300.2811, -617.4614, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(129.79305, -524.6356, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(177.00204, -691.564, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(368.48044, -568.7533, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(382.4504, -750.5115, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(546.45624, -678.7522, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(1036.0029, -567.1096, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(1264.0972, -427.98737, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(1190.1317, -603.1982, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(1332.1448, -601.29266, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(1390.5164, -399.2193, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-1328.7583, -746.01447, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-1330.183, -593.6111, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-1171.8418, -665.70325, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-1180.5884, -796.7641, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-1043.8481, -667.8395, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(-1141.8717, -559.261, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(11.242166, -1125.1985, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Rectangle(231.43198, -992.8441, 30));

		// 'Rubblem_Green' GenType 25 Spawn Points
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-99.80672, -1487.5884, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(3.1712599, -1363.7494, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(13.940241, -1490.2506, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-98.343605, -1378.1871, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(157.34584, -1479.6234, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(81.92562, -1359.7307, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(160.41493, -1407.2511, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(40.18935, -1452.27, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(90.56396, -1434.7396, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-178.65436, -1417.0035, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(399.76758, -469.36673, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(998.3905, -598.2353, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1177.4934, -428.87497, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1228.1139, -512.581, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1234.0406, -648.82074, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1360.4956, -470.08438, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1147.404, 121.86687, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1200.8317, 290.402, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1339.4077, 403.3701, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1232.3973, 155.35036, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1353.2566, 165.71027, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1626.9344, 433.98422, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(162.88177, 215.3377, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(66.471306, 303.86166, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(184.75195, 484.05576, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(2.3121758, 395.10507, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(297.96454, 356.67526, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-542.9016, 146.08923, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-529.2816, 256.59427, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-421.85617, 436.66968, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-340.50037, 264.46863, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-371.68262, 139.70734, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-264.9776, 213.41203, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-215.4278, 335.01547, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(-347.59818, 522.7888, 30));
		AddSpawnPoint("d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Rectangle(1462.3762, 277.0056, 30));

		// 'Bavon_Green' GenType 26 Spawn Points
		AddSpawnPoint("d_limestonecave_52_3.Id5", "d_limestonecave_52_3", Rectangle(25.884827, -453.6006, 9999));

		// 'Flamme_Priest_Green' GenType 27 Spawn Points
		AddSpawnPoint("d_limestonecave_52_3.Id6", "d_limestonecave_52_3", Rectangle(822.9344, -526.85175, 9999));

		// 'Rootcrystal_04' GenType 30 Spawn Points
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-2331.85, -870.65, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-2028.57, -1076.49, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-1891.67, -775.59, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-2017.16, -309.71, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-1892.06, -109.56, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-1864.32, 325.79, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-1957.4, 664.58, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-1345.71, -687.9, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-1109.14, -605.63, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-574.44354, -821.0819, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-484.83286, -431.44177, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-1166.14, -188.59, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-980.99, 122.86, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-694.24, 215.82, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-210.72, 456.33, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(130.89, 285.89, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(288.17, 637.75, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(521.43, -1438.8, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-87.45, -1432.68, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(245.71, -1399, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(418.94, -937.92, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(270.33, -590.16, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(744.14, -539.15, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(1093.96, -459.75, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(1291.03, -513.4, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(1147.66, 24.81, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(1213.07, 368.45, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(1560.71, 273.3, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(1348.95, 675.56, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(1330.45, 880.93, 15));
		AddSpawnPoint("d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Rectangle(-128.03, -400.98, 15));

		// 'Rocktanon' GenType 1001 Spawn Points
		AddSpawnPoint("d_limestonecave_52_3.Id8", "d_limestonecave_52_3", Rectangle(758.45, -563.09, 9999));
	}
}
