//--- Melia Script -----------------------------------------------------------
// f_nicopolis_81_2
//
//--- Description -----------------------------------------------------------
// Sets up the f_nicopolis_81_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FNicopolis812MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_nicopolis_81_2.Id1", MonsterId.Wiza_Moya, 49, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_nicopolis_81_2.Id2", MonsterId.Mimorat_Pink, 33, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_nicopolis_81_2.Id3", MonsterId.Mimorat_White, 39, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_nicopolis_81_2.Id4", MonsterId.Vine_Walker, 14, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_nicopolis_81_2.Id5", MonsterId.Rootcrystal_02, 20, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Wiza_Moya Spawn Points
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-1991.0795, -983.10406, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-1584.2804, -805.838, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-1267.1174, -1275.1072, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-1838.018, -1914.8577, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-1546.5576, -2188.0583, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-1303.0453, -1697.2196, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-754.9009, -1360.9216, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-575.8506, -1692.1027, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-375.8407, -2682.276, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(205.915, -2096.1682, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-363.00415, -2225.0615, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(274.11258, -1505.5587, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(1669.5424, -1657.973, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(2146.5776, -1487.3604, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(1775.3958, -796.25916, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(1946.183, -1176.514, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(1482.948, -1327.5948, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(1176.5347, -1731.489, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(745.0407, -1366.3026, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(896.1747, -911.83777, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(862.2978, 68.33798, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(794.1016, -288.8219, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(1800.6642, -1434.2307, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-707.72314, -915.93066, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-708.38995, -461.076, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-1029.5145, -83.962814, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-1053.3254, 326.8441, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-378.55658, 271.86502, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(37.542942, 315.39935, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(440.5198, 613.57263, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(397.04147, 918.5732, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-527.6269, 1272.9135, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(90.57697, 1381.2622, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(574.3266, 1302.4341, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-78.44719, -2692.7212, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-95.23775, -2108.5435, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(107.69147, -2521.0671, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-1790.2634, -1028.7128, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-1581.1249, -956.5537, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-860.1736, -1442.1116, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-673.30005, -1764.5044, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(514.4772, 1121.7448, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-16.75113, 188.91946, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(690.87427, -1804.2457, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(972.4815, -1784.9597, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(555.95465, -1489.5217, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(291.203, -2267.1482, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-451.3543, -2461.1926, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-525.78107, -2101.6372, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(772.44305, -1615.2274, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(1047.9297, -633.038, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(1156.6515, -593.2191, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(446.87677, 122.60009, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(338.60388, 342.46527, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-796.8035, 29.288269, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-660.68115, 189.50206, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-541.35126, -1439.5247, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id1", "f_nicopolis_81_2", Spot(-91.22102, -2403.1978, 25));

		// Mimorat_Pink Spawn Points
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(1632.4734, -1883.4635, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(1980.3336, -1600.778, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(1795.017, -1430.2954, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(1614.675, -1189.3407, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(1925.3378, -939.3157, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(2018.6091, -710.526, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(973.73895, -1787.1578, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(570.34827, -1755.7958, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(716.6026, -1558.6854, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(573.25183, -1115.7754, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(1047.908, -650.97705, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(981.3183, -363.61542, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(457.07193, 13.651529, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(167.08047, 486.02646, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(677.53485, 494.08572, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(338.77295, 1154.8872, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(438.97824, 1451.3245, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(-486.39273, 1458.4955, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(-226.49194, 1326.0643, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(449.768, 2035.9718, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(766.4271, 2595.8003, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(669.8359, 2117.1646, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(1145.8649, 2216.14, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(1568.7592, 2034.8903, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(1466.8234, 2447.8347, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(-1141.4412, 64.20187, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(-845.4292, 190.24672, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(-743.6116, -146.64032, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(-484.3004, -768.5396, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(-801.17267, -648.49036, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(326.46686, 2339.5063, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(951.68744, -889.7221, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(1242.1426, -743.24493, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(1249.5353, -456.11346, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(393.7711, 243.49646, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(501.57764, 404.9834, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(157.86949, 1365.2944, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(-586.00366, 1240.9318, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id2", "f_nicopolis_81_2", Spot(638.93005, 2312.6763, 25));

		// Mimorat_White Spawn Points
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(201.18076, -2665.5637, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-58.025146, -2417.9568, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-54.235966, -2154.9749, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-484.44336, -2518.3208, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-128.27399, -2773.033, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-807.1512, -1633.2017, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-247.26807, -1451.6683, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-1796.5016, -2154.1675, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-1311.9536, -1956.1884, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-2129.878, -991.5173, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-1774.1204, -799.5771, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-1386.3807, -1100.8091, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-1105.6844, -1562.8152, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-617.729, -801.59106, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-1151.4404, 278.41223, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-889.28973, 51.152927, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-486.5806, 120.08357, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(612.9212, 334.48456, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-145.20175, 374.65842, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(302.05823, 1306.2795, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(386.77454, 1574.5316, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-651.32135, 1380.7511, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(353.81934, 2093.9302, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(583.7594, 2249.7273, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(657.2342, 2519.427, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(1353.5428, 1963.7468, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(1280.293, 2442.001, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(1461.3901, 2187.038, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(285.48502, 9.419742, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(506.558, 1167.3763, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(574.2741, 2035.8652, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(337.10733, 255.7265, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(128.13087, 211.34213, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(265.62738, 483.13135, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-783.1024, -193.15317, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-642.373, -606.32556, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-573.8112, -1432.4471, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-579.9322, -1648.4506, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-799.55634, -1386.0398, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-673.7694, -1512.0575, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-222.14256, -2504.7703, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(179.40869, -2259.4683, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(-303.0734, -2204.7983, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id3", "f_nicopolis_81_2", Spot(123.17038, -2570.123, 25));

		// Vine_Walker Spawn Points
		AddSpawnPoint( "f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Spot(327.9992, 66.83794, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Spot(571.03973, 257.1537, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Spot(-833.6322, 225.23082, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Spot(-918.2254, -31.166386, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Spot(909.9607, -538.8121, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Spot(1246.1487, -680.788, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Spot(590.8846, -1513.6982, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Spot(798.7386, -1180.8522, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Spot(1713.0095, -1445.3461, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Spot(1755.268, -1173.4861, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Spot(-623.826, -632.6327, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Spot(-62.156467, -2201.422, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Spot(84.40648, -2565.4792, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Spot(-824.7023, -1629.0093, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Spot(-581.259, -1408.3806, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Spot(303.0844, 476.13324, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Spot(352.02237, 1138.6821, 25));
		AddSpawnPoint( "f_nicopolis_81_2.Id4", "f_nicopolis_81_2", Spot(-312.34128, -2482.0708, 25));

		// Rootcrystal_02 Spawn Points
		AddSpawnPoint( "f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Spot(1720.8358, -1653.8127, 150));
		AddSpawnPoint( "f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Spot(1951.9944, -844.5667, 150));
		AddSpawnPoint( "f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Spot(764.6754, -1729.1885, 150));
		AddSpawnPoint( "f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Spot(1014.2901, -891.5785, 150));
		AddSpawnPoint( "f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Spot(1016.3511, -473.57806, 150));
		AddSpawnPoint( "f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Spot(631.2667, 282.0958, 150));
		AddSpawnPoint( "f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Spot(139.48883, 252.21866, 150));
		AddSpawnPoint( "f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Spot(412.98544, 1238.8539, 150));
		AddSpawnPoint( "f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Spot(-352.3749, 1350.777, 150));
		AddSpawnPoint( "f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Spot(605.7047, 2212.94, 150));
		AddSpawnPoint( "f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Spot(1482.3387, 2146.3684, 150));
		AddSpawnPoint( "f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Spot(-405.35074, -1457.8967, 150));
		AddSpawnPoint( "f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Spot(-890.13306, -1556.2853, 150));
		AddSpawnPoint( "f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Spot(-651.9489, -736.3492, 150));
		AddSpawnPoint( "f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Spot(-1065.2837, 159.65425, 150));
		AddSpawnPoint( "f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Spot(-526.27527, 61.919903, 150));
		AddSpawnPoint( "f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Spot(-1639.4985, -2119.8125, 150));
		AddSpawnPoint( "f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Spot(-1559.314, -897.14294, 150));
		AddSpawnPoint( "f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Spot(-30.306732, -2687.3208, 150));
		AddSpawnPoint( "f_nicopolis_81_2.Id5", "f_nicopolis_81_2", Spot(-201.44751, -2169.2852, 150));

	}
}
