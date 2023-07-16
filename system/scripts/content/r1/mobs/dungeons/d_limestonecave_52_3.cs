//--- Melia Script -----------------------------------------------------------
// d_limestonecave_52_3
//
//--- Description -----------------------------------------------------------
// Sets up the d_limestonecave_52_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DLimestonecave523MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_limestonecave_52_3", MonsterId.Flamme_Priest_Green, Properties("MHP", 482680, "MINPATK", 6708, "MAXPATK", 8146, "MINMATK", 6708, "MAXMATK", 8146, "DEF", 73282, "MDEF", 73282));
		AddPropertyOverrides("d_limestonecave_52_3", MonsterId.Flamme_Mage_Green, Properties("MHP", 484899, "MINPATK", 6736, "MAXPATK", 8181, "MINMATK", 6736, "MAXMATK", 8181, "DEF", 74172, "MDEF", 74172));
		AddPropertyOverrides("d_limestonecave_52_3", MonsterId.Bavon_Green, Properties("MHP", 487176, "MINPATK", 6766, "MAXPATK", 8217, "MINMATK", 6766, "MAXMATK", 8217, "DEF", 75086, "MDEF", 75086));
		AddPropertyOverrides("d_limestonecave_52_3", MonsterId.Rubblem_Green, Properties("MHP", 489512, "MINPATK", 6796, "MAXPATK", 8254, "MINMATK", 6796, "MAXMATK", 8254, "DEF", 76023, "MDEF", 76023));
		AddPropertyOverrides("d_limestonecave_52_3", MonsterId.Rocktanon, Properties("MHP", 491904, "MINPATK", 6826, "MAXPATK", 8292, "MINMATK", 6826, "MAXMATK", 8292, "DEF", 76983, "MDEF", 76983));

		// Monster Spawners --------------------------------

		AddSpawner("d_limestonecave_52_3.Id1", MonsterId.Flamme_Priest_Green, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_3.Id2", MonsterId.Flamme_Mage_Green, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_3.Id3", MonsterId.Bavon_Green, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_3.Id4", MonsterId.Rubblem_Green, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_3.Id5", MonsterId.Bavon_Green, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_3.Id6", MonsterId.Flamme_Priest_Green, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_3.Id7", MonsterId.Rootcrystal_04, 25, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_limestonecave_52_3.Id8", MonsterId.Rocktanon, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// Flamme_Priest_Green Spawn Points
		AddSpawnPoint( "d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Spot(-1822.918, -276.20517, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Spot(-1850.627, 432.6938, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Spot(-1960.5896, -184.09651, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Spot(-1878.9836, -31.786081, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Spot(-2102.9746, 486.45352, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Spot(-1972.5902, 569.47186, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Spot(-1882.934, 659.1721, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Spot(-1843.513, 538.9344, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Spot(-1953.2347, -314.4797, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Spot(-1960.3654, -685.89325, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Spot(-2116.4163, -940.02386, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Spot(-2004.9653, -1031.0662, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Spot(-1862.779, -913.77686, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id1", "d_limestonecave_52_3", Spot(-1837.8253, -773.15344, 30));

		// Flamme_Mage_Green Spawn Points
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(-1207.5293, -101.90356, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(-1939.8303, -144.52919, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(-1982.2693, 586.2672, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(-1220.6505, 48.754135, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(-1029.4529, 12.60233, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(-1157.943, -359.87946, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(-748.79456, 187.07953, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(-272.80768, -417.27728, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(-389.49496, -501.01657, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(1141.9314, -528.6318, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(-4.733101, -1438.057, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(85.951065, -1374.186, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(337.77545, -562.4278, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(1229.9528, 3.3099525, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(1105.631, 263.66064, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(1294.6536, 551.6924, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(97.30046, 386.43878, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(188.3407, 545.5392, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(-454.06088, 190.68187, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(-508.7755, 431.60266, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(-279.85773, 377.09073, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(-408.67014, 285.16766, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(-2045.0656, -172.00691, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(-1932.7089, 413.9841, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(-481.24008, -358.05533, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(253.45941, -702.9854, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(1259.7588, -315.74045, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(-1060.9425, -196.38864, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id2", "d_limestonecave_52_3", Spot(-1126.2074, 238.36668, 30));

		// Bavon_Green Spawn Points
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(-682.53125, -666.74414, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(-7.838619, -1454.5829, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(15.583963, -1321.5673, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(12.42955, -1437.056, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(246.2413, -1467.5687, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(286.57562, -1490.6975, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(535.38983, -1322.3516, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(-0.4986148, -1220.6365, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(470.08258, -867.67163, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(-573.8659, -750.2539, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(-525.5801, -571.5688, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(-465.4162, -659.8184, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(-275.1703, -472.9236, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(-300.2811, -617.4614, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(129.79305, -524.6356, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(177.00204, -691.564, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(368.48044, -568.7533, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(382.4504, -750.5115, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(546.45624, -678.7522, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(1036.0029, -567.1096, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(1264.0972, -427.98737, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(1190.1317, -603.1982, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(1332.1448, -601.29266, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(1390.5164, -399.2193, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(-1328.7583, -746.01447, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(-1330.183, -593.6111, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(-1171.8418, -665.70325, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(-1180.5884, -796.7641, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(-1043.8481, -667.8395, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(-1141.8717, -559.261, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(11.242166, -1125.1985, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id3", "d_limestonecave_52_3", Spot(231.43198, -992.8441, 30));

		// Rubblem_Green Spawn Points
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(-99.80672, -1487.5884, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(3.1712599, -1363.7494, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(13.940241, -1490.2506, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(-98.343605, -1378.1871, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(157.34584, -1479.6234, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(81.92562, -1359.7307, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(160.41493, -1407.2511, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(40.18935, -1452.27, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(90.56396, -1434.7396, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(-178.65436, -1417.0035, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(399.76758, -469.36673, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(998.3905, -598.2353, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(1177.4934, -428.87497, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(1228.1139, -512.581, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(1234.0406, -648.82074, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(1360.4956, -470.08438, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(1147.404, 121.86687, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(1200.8317, 290.402, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(1339.4077, 403.3701, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(1232.3973, 155.35036, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(1353.2566, 165.71027, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(1626.9344, 433.98422, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(162.88177, 215.3377, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(66.471306, 303.86166, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(184.75195, 484.05576, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(2.3121758, 395.10507, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(297.96454, 356.67526, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(-542.9016, 146.08923, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(-529.2816, 256.59427, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(-421.85617, 436.66968, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(-340.50037, 264.46863, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(-371.68262, 139.70734, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(-264.9776, 213.41203, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(-215.4278, 335.01547, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(-347.59818, 522.7888, 30));
		AddSpawnPoint( "d_limestonecave_52_3.Id4", "d_limestonecave_52_3", Spot(1462.3762, 277.0056, 30));

		// Bavon_Green Spawn Points
		AddSpawnPoint( "d_limestonecave_52_3.Id5", "d_limestonecave_52_3", Spot(25.884827, -453.6006, 9999));

		// Flamme_Priest_Green Spawn Points
		AddSpawnPoint( "d_limestonecave_52_3.Id6", "d_limestonecave_52_3", Spot(822.9344, -526.85175, 9999));

		// Rootcrystal_04 Spawn Points
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(-2331.85, -870.65, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(-2028.57, -1076.49, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(-1891.67, -775.59, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(-2017.16, -309.71, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(-1892.06, -109.56, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(-1864.32, 325.79, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(-1957.4, 664.58, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(-1345.71, -687.9, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(-1109.14, -605.63, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(-574.44354, -821.0819, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(-484.83286, -431.44177, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(-1166.14, -188.59, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(-980.99, 122.86, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(-694.24, 215.82, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(-210.72, 456.33, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(130.89, 285.89, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(288.17, 637.75, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(521.43, -1438.8, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(-87.45, -1432.68, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(245.71, -1399, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(418.94, -937.92, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(270.33, -590.16, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(744.14, -539.15, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(1093.96, -459.75, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(1291.03, -513.4, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(1147.66, 24.81, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(1213.07, 368.45, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(1560.71, 273.3, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(1348.95, 675.56, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(1330.45, 880.93, 15));
		AddSpawnPoint( "d_limestonecave_52_3.Id7", "d_limestonecave_52_3", Spot(-128.03, -400.98, 15));

		// Rocktanon Spawn Points
		AddSpawnPoint( "d_limestonecave_52_3.Id8", "d_limestonecave_52_3", Spot(758.45, -563.09, 9999));

	}
}
