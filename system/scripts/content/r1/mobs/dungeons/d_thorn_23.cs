//--- Melia Script -----------------------------------------------------------
// d_thorn_23
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Sunset Flag Forest' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DThorn23MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_thorn_23.Id1", MonsterId.Rootcrystal_01, 8, 10, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id2", MonsterId.Raider, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id3", MonsterId.Infroholder, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id4", MonsterId.Raider, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id5", MonsterId.Infroholder, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id6", MonsterId.Duckey, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id7", MonsterId.InfroHoglan, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id8", MonsterId.Cronewt, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id9", MonsterId.InfroHoglan, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id10", MonsterId.Cronewt, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id11", MonsterId.Duckey, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id12", MonsterId.Infroholder, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id13", MonsterId.Duckey, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_thorn_23.Id14", MonsterId.Raider, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 600 Spawn Points
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-1824, -2731, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-1910, -2511, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-1595, -2641, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-1346, -1098, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-2031.7213, -436.15097, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-1870, 253, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-846.99084, 204.8135, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-338, 310, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-816, -664, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-552, -950, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(608, 688, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(1305.6753, 129.96463, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(1130.2466, -143.00745, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(1821.6901, 562.15204, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(1795.6863, 829.0664, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(2155, 569, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(2415.202, 1948.078, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(2117, 1754, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(2554, 1444, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-1619.7797, -1437.0828, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(-1921, -167, 50));
		AddSpawnPoint("d_thorn_23.Id1", "d_thorn_23", Rectangle(384, 372, 50));

		// 'Raider' GenType 605 Spawn Points
		AddSpawnPoint("d_thorn_23.Id2", "d_thorn_23", Rectangle(-1373.99, -2289.86, 9999));

		// 'Infroholder' GenType 606 Spawn Points
		AddSpawnPoint("d_thorn_23.Id3", "d_thorn_23", Rectangle(-1343.51, -1035.27, 9999));

		// 'Raider' GenType 607 Spawn Points
		AddSpawnPoint("d_thorn_23.Id4", "d_thorn_23", Rectangle(-1760.7244, -2740.6445, 30));
		AddSpawnPoint("d_thorn_23.Id4", "d_thorn_23", Rectangle(-1819.4385, -2144.4124, 30));
		AddSpawnPoint("d_thorn_23.Id4", "d_thorn_23", Rectangle(-1453.1504, -887.2419, 30));
		AddSpawnPoint("d_thorn_23.Id4", "d_thorn_23", Rectangle(-1954.26, -94.54, 30));
		AddSpawnPoint("d_thorn_23.Id4", "d_thorn_23", Rectangle(-1813.26, 316.79, 30));
		AddSpawnPoint("d_thorn_23.Id4", "d_thorn_23", Rectangle(-902.80615, -1378.9331, 30));
		AddSpawnPoint("d_thorn_23.Id4", "d_thorn_23", Rectangle(-1565.24, -1392.74, 30));

		// 'Infroholder' GenType 616 Spawn Points
		AddSpawnPoint("d_thorn_23.Id5", "d_thorn_23", Rectangle(-1804.5814, -2585.8125, 30));
		AddSpawnPoint("d_thorn_23.Id5", "d_thorn_23", Rectangle(-1994.4603, -2603.8208, 30));
		AddSpawnPoint("d_thorn_23.Id5", "d_thorn_23", Rectangle(-1729.309, -2865.6157, 30));
		AddSpawnPoint("d_thorn_23.Id5", "d_thorn_23", Rectangle(-1552.1726, -2723.495, 30));
		AddSpawnPoint("d_thorn_23.Id5", "d_thorn_23", Rectangle(-2019.0951, -2864.6743, 30));
		AddSpawnPoint("d_thorn_23.Id5", "d_thorn_23", Rectangle(-1946.5099, -2194.904, 30));
		AddSpawnPoint("d_thorn_23.Id5", "d_thorn_23", Rectangle(-1506.0367, -2395.0193, 30));
		AddSpawnPoint("d_thorn_23.Id5", "d_thorn_23", Rectangle(-1642.9357, -2527.1519, 30));

		// 'Duckey' GenType 619 Spawn Points
		AddSpawnPoint("d_thorn_23.Id6", "d_thorn_23", Rectangle(-1616.08, -1503.36, 9999));

		// 'InfroHoglan' GenType 620 Spawn Points
		AddSpawnPoint("d_thorn_23.Id7", "d_thorn_23", Rectangle(-339.61, -1219, 9999));

		// 'Cronewt' GenType 621 Spawn Points
		AddSpawnPoint("d_thorn_23.Id8", "d_thorn_23", Rectangle(-625.35, -241.82, 9999));

		// 'InfroHoglan' GenType 622 Spawn Points
		AddSpawnPoint("d_thorn_23.Id9", "d_thorn_23", Rectangle(-355.74838, 341.96207, 30));
		AddSpawnPoint("d_thorn_23.Id9", "d_thorn_23", Rectangle(-843.96277, 250.66608, 30));
		AddSpawnPoint("d_thorn_23.Id9", "d_thorn_23", Rectangle(-369.99896, 594.026, 30));
		AddSpawnPoint("d_thorn_23.Id9", "d_thorn_23", Rectangle(-679.8226, -59.717934, 30));
		AddSpawnPoint("d_thorn_23.Id9", "d_thorn_23", Rectangle(-92.8905, 548.32117, 30));
		AddSpawnPoint("d_thorn_23.Id9", "d_thorn_23", Rectangle(244.67934, 639.5874, 30));
		AddSpawnPoint("d_thorn_23.Id9", "d_thorn_23", Rectangle(397.45166, 377.12387, 30));
		AddSpawnPoint("d_thorn_23.Id9", "d_thorn_23", Rectangle(-1350.8917, 362.52377, 30));

		// 'Cronewt' GenType 623 Spawn Points
		AddSpawnPoint("d_thorn_23.Id10", "d_thorn_23", Rectangle(-2137.174, -46.905, 30));
		AddSpawnPoint("d_thorn_23.Id10", "d_thorn_23", Rectangle(-1876.8945, -702.831, 30));
		AddSpawnPoint("d_thorn_23.Id10", "d_thorn_23", Rectangle(-1717.1622, -701.9787, 30));
		AddSpawnPoint("d_thorn_23.Id10", "d_thorn_23", Rectangle(-2159.0305, -270.35956, 30));
		AddSpawnPoint("d_thorn_23.Id10", "d_thorn_23", Rectangle(-1728.9342, 250.06274, 30));
		AddSpawnPoint("d_thorn_23.Id10", "d_thorn_23", Rectangle(-1776.7732, 37.58861, 30));
		AddSpawnPoint("d_thorn_23.Id10", "d_thorn_23", Rectangle(-1991.4808, 199.83517, 30));
		AddSpawnPoint("d_thorn_23.Id10", "d_thorn_23", Rectangle(-1901.379, -116.90331, 30));

		// 'Duckey' GenType 624 Spawn Points
		AddSpawnPoint("d_thorn_23.Id11", "d_thorn_23", Rectangle(-1099.2568, -1206.7878, 30));
		AddSpawnPoint("d_thorn_23.Id11", "d_thorn_23", Rectangle(-1593.1708, -1321.9813, 30));
		AddSpawnPoint("d_thorn_23.Id11", "d_thorn_23", Rectangle(-1598.4993, -786.76984, 30));
		AddSpawnPoint("d_thorn_23.Id11", "d_thorn_23", Rectangle(-803.17883, -1345.9825, 30));
		AddSpawnPoint("d_thorn_23.Id11", "d_thorn_23", Rectangle(-847.6821, -1494.0217, 30));
		AddSpawnPoint("d_thorn_23.Id11", "d_thorn_23", Rectangle(-1012.4822, -1251.6713, 30));
		AddSpawnPoint("d_thorn_23.Id11", "d_thorn_23", Rectangle(-1910.3602, -558.8174, 30));

		// 'Infroholder' GenType 625 Spawn Points
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-712.6937, -129.95483, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1911.188, -45.091923, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(296.92566, 632.56537, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(580.3351, 819.79034, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1288.214, -2172.977, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-2024.8302, -428.52066, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(568.68506, 587.7272, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(867.3464, 429.39465, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(819.8201, 323.69672, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(728.99896, 434.89627, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-2091.8633, -2380.8625, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-632.29706, -230.7458, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-2143.8667, -278.89014, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1603.3442, -1275.9476, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(660.57056, 725.663, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-471.8239, -1078.4799, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1668.3378, -1419.4468, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1658.4302, 145.1415, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1904.2751, -609.7623, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1858.9028, 214.11725, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(544.54706, 369.9322, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-548.87195, -911.8836, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(608.9675, 463.42505, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-2080.5503, -128.11536, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-440.70462, -903.2081, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(388.17188, 303.01767, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1535.3335, -2553.1895, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1702.8861, -2259.11, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-671.28503, 1.7575533, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(467.86816, 447.13727, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(451.53513, 340.65723, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1978.588, -2669.5237, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-440.87314, 561.1195, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1495.1521, -1241.1597, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(566.22253, 700.4858, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1793.2007, -709.08075, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-667.3563, 277.57886, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1397.4554, -1954.722, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(763.29675, 717.5764, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-959.3758, -1274.1656, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1135.5535, -1166.2748, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1999.5267, -263.90768, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1345.9159, -1076.4232, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-729.1348, 492.03082, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1972.9197, -2354.0117, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1244.1384, -1201.2141, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-479.4321, 188.57349, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1576.3168, -868.25116, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(799.27454, 813.38293, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1589.2876, -1360.355, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(345.047, 624.5176, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-769.13727, 107.3193, 30));
		AddSpawnPoint("d_thorn_23.Id12", "d_thorn_23", Rectangle(-1646.4998, -2747.6255, 30));

		// 'Duckey' GenType 627 Spawn Points
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-1131.9987, 326.04385, 30));
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-1023.6309, 195.97217, 30));
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-783.8198, -18.01628, 30));
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-632.95197, -189.0316, 30));
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-708.41626, -288.9838, 30));
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-693.48236, 117.36983, 30));
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-694.52124, 347.74463, 30));
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-617.5734, 579.4446, 30));
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-250.23822, 424.94223, 30));
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-417.48663, 541.6535, 30));
		AddSpawnPoint("d_thorn_23.Id13", "d_thorn_23", Rectangle(-396.84824, 283.3022, 30));

		// 'Raider' GenType 628 Spawn Points
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-1512.1764, -884.1146, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-1631.8242, -1329.7943, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-982.9622, -1292.1564, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-659.2467, 208.03366, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-1224.5986, -1208.1992, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-1282.631, -1047.0851, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-511.0037, 646.3681, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-774.72675, 8.226215, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-762.236, 346.74704, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-996.28436, 250.48212, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-328.0668, 337.90933, 30));
		AddSpawnPoint("d_thorn_23.Id14", "d_thorn_23", Rectangle(-85.91797, 559.1737, 30));
	}
}
