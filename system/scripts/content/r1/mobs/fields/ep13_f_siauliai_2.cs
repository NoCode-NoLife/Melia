//--- Melia Script -----------------------------------------------------------
// ep13_f_siauliai_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Woods of the Linked Bridges' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep13FSiauliai2MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep13_f_siauliai_2", MonsterId.Darbas_Miner, Properties("MHP", 921285, "MINPATK", 12347, "MAXPATK", 15078, "MINMATK", 12347, "MAXMATK", 15078, "DEF", 386086, "MDEF", 386086));
		AddPropertyOverrides("ep13_f_siauliai_2", MonsterId.Darbas_Carrier, Properties("MHP", 924645, "MINPATK", 12391, "MAXPATK", 15131, "MINMATK", 12391, "MAXMATK", 15131, "DEF", 389894, "MDEF", 389894));
		AddPropertyOverrides("ep13_f_siauliai_2", MonsterId.Darbas_Loader, Properties("MHP", 928298, "MINPATK", 12438, "MAXPATK", 15189, "MINMATK", 12438, "MAXMATK", 15189, "DEF", 394035, "MDEF", 394035));
		AddPropertyOverrides("ep13_f_siauliai_2", MonsterId.Boss_Darbas_Smasher, Properties("MHP", 5089938, "MINPATK", 34467, "MAXPATK", 42092, "MINMATK", 34467, "MAXMATK", 42092, "DEF", 1099813, "MDEF", 1099813));

		// Monster Spawners ---------------------------------

		AddSpawner("ep13_f_siauliai_2.Id1", MonsterId.Rootcrystal_01, 17, 22, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_2.Id2", MonsterId.Darbas_Miner, 30, 40, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_2.Id3", MonsterId.Darbas_Carrier, 68, 90, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_2.Id4", MonsterId.Darbas_Loader, 68, 90, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_2.Id5", MonsterId.Darbas_Miner, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_2.Id6", MonsterId.Darbas_Miner, 2, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_2.Id7", MonsterId.Darbas_Miner, 2, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_2.Id8", MonsterId.Darbas_Miner, 2, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_2.Id9", MonsterId.Darbas_Miner, 2, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_2.Id10", MonsterId.Darbas_Miner, 2, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 3 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(2794.962, -731.8422, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(2365.6511, -1216.4115, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(1879.7211, -704.17847, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(1387.8823, -1026.0297, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(1042.6975, -801.7676, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(1405.982, 133.7756, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(966.08905, 353.14807, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(1418.2528, 825.5219, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(965.9754, 1159.6167, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(568.1975, 1491.0067, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(107.07793, 1595.6724, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(-217.30365, 2005.2997, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(-427.66983, 1521.6234, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(-483.53244, 424.14548, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(-1001.5187, 463.969, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(82.00029, 184.8484, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(-1034.0455, -617.97034, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(-1518.9531, -570.179, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(-1369.4738, -1057.8624, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(-1972.5089, -1009.2802, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(-42.643726, -1454.2603, 100));
		AddSpawnPoint("ep13_f_siauliai_2.Id1", "ep13_f_siauliai_2", Rectangle(509.8534, -964.9967, 100));

		// 'Darbas_Miner' GenType 1034 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(2859.8784, -664.68146, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(1399.4944, -810.6732, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(1291.8315, 193.37704, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(1049.6074, 267.89734, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(629.4764, 457.67508, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(94.57822, 137.14145, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-509.3573, 485.8727, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-1027.4519, 427.06516, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-361.76807, 1464.9525, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(504.13507, 1390.3499, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(1497.199, 884.37756, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(0.26785278, -1258.4031, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-1707.9314, -719.45996, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-1467.0444, -546.7075, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-2288.675, -828.7597, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(1066.6171, -901.4491, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(2123.8416, -733.7941, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(497.49973, -1139.0784, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(670.56464, -1057.359, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-49.249283, -828.2639, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-1031.1329, -485.23642, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-72.15077, 1646.8447, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-1963.1956, -936.063, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-39.062447, -1866.6765, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-1234.4485, -776.44904, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(-1263.686, -1069.995, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id2", "ep13_f_siauliai_2", Rectangle(475.79276, 1665.2781, 20));

		// 'Darbas_Carrier' GenType 1035 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(2934.8787, -730.683, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(2149.1824, -856.4011, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1315.6238, -1054.1248, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1542.3804, -827.717, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1249.6304, -866.4083, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(846.8432, -684.1388, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1304.4056, 316.13513, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1495.5798, -100.13468, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1208.6353, -23.82954, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(991.351, 460.50024, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(488.1371, 402.32983, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(761.0062, 493.73514, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-58.241016, 168.00446, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(142.79692, 258.02014, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-474.21686, 351.53864, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-418.07687, 592.229, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-897.6308, 478.8164, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1177.5049, 435.5163, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-533.942, 1588.733, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-280.1836, 1470.205, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-297.76117, 2019.5656, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-73.44104, 1897.7699, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(344.99023, 1617.1624, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(702.61005, 1316.8145, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1368.4738, 907.9902, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1639.3009, 951.3814, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(86.12025, -1535.546, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-14.765686, -1134.3915, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-81.78574, -1780.5883, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-2250.0342, -949.4517, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-2109.028, -901.611, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1781.9104, -827.0719, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1755.1184, -554.44464, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1439.2211, -673.52026, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1421.1206, -453.03784, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1402.0914, -1013.027, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-887.69104, -715.9657, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-761.7731, -936.9157, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(813.25287, 1449.76, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(48.69342, -1341.2781, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(2455.647, -1321.1128, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1303.9965, -887.15436, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-2157.5188, -1195.4319, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(3228.7095, -718.18164, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(3055.9766, -820.6359, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1999.1632, -704.5836, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(2365.4985, -1191.6913, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1379.9176, 724.5259, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(857.0171, 1619.3313, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-401.9123, 850.9296, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-994.5588, -247.2751, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1052.144, -630.01245, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-2428.998, -1178.934, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1399.6434, 499.01038, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1906.8474, 1000.2763, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-278.84113, 120.86132, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-96.50902, -1.3293419, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(2770.4631, -875.9572, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(2850.7534, -777.04395, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(2307.0105, -699.2529, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(2427.292, -677.24884, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(2627.7217, -720.28925, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1290.7113, -595.2654, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1325.4072, -434.41415, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(376.49484, -355.27338, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(111.69835, -136.36613, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(609.8521, -1222.5193, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(354.00525, -1077.8517, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(545.88324, -1020.1241, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(715.3497, -917.2883, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-33.723343, -960.1632, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-552.2844, -859.04944, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-862.7732, -856.6297, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-989.5136, -35.08694, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(168.84985, 1676.6506, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1082.5586, 875.8108, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1389.9553, 1022.1274, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1680.0212, 842.25934, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1609.1729, -546.3194, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1990.9341, -935.0529, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1915.3232, -1060.1724, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-469.76855, 1457.2546, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1407.002, 69.5188, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(2323.4473, -1302.5582, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1623.8147, -718.9595, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1533.3778, -966.23346, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-2430.1404, -897.3333, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(261.33713, -921.2979, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(35.19913, -1594.2855, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(-1446.6316, -810.10315, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(884.75555, 1179.8159, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(933.31836, 937.2622, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(599.2286, 1333.8422, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(604.6723, 1495.3026, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id3", "ep13_f_siauliai_2", Rectangle(1047.7074, -739.95966, 20));

		// 'Darbas_Loader' GenType 1036 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(3202.3418, -809.2227, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(2161.3535, -646.92596, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(2232.807, -1328.365, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1433.4763, -1125.6318, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1171.8624, -1012.4012, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1202.8629, -715.05786, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(26.02602, -1848.4023, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-175.59659, -831.66174, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(355.09576, -955.272, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(114.3068, -1428.9757, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-969.1714, -794.06134, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-760.8254, -796.74677, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1559.1228, -447.11017, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1344.425, -589.6936, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1893.2092, -663.44794, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1621.4376, -869.09863, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-2414.6545, -786.8303, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-2184.4958, -768.28406, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1821.3828, -1052.7659, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1499.9349, -1063.5966, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-960.61224, 119.29574, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1180.3435, -487.77118, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(174.26636, -253.4897, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(670.01624, 310.57703, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(610.6978, 635.7109, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(908.03503, 255.69453, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1162.3646, 292.66132, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1378.4915, -71.42648, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1422.0432, 310.79486, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1506.6327, 755.0784, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1487.0322, 1023.3499, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(456.26852, 1491.8, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(578.3862, 1604.5258, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(724.6445, 1635.9108, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(41.254246, 1626.2456, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-149.96323, 2046.5293, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-389.1212, 1358.3564, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-491.36765, 1734.4277, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-402.42783, 1038.115, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-654.1326, 499.4972, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-319.1998, 383.18402, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-952.7089, 303.5332, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1121.2124, 568.4414, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-2270.64, -1263.1311, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-344.48325, -841.1939, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(16.659508, -815.5063, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1205.076, 687.5085, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(998.9344, 984.31384, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(229.9978, 1591.4355, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1684.0287, -1069.4318, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-2285.7668, -1127.6786, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1761.7732, -711.6873, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1436.268, -358.3418, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1805.8566, 972.48425, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1225.139, 799.83417, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-192.33598, -4.682247, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(961.8885, 1250.7885, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(169.457, 427.59195, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(323.98123, 243.31316, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(2285.8716, -1117.6704, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(2465.6912, -1207.9591, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(2533.825, -1091.0637, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(2249.2322, -939.6223, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(2225.3088, -775.3761, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(3029.617, -734.96606, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(2755.7583, -736.28955, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(3326.3677, -679.92413, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1411.0005, -939.6669, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(723.6993, -1228.838, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(618.6425, -1125.751, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(734.2918, -779.2414, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(895.2767, -813.8662, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(618.0545, -895.31964, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-386.75613, 1585.2098, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1472.5347, 176.6578, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1229.9873, 125.51886, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(1510.9225, -726.237, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-363.951, 258.7339, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1364.1484, -1111.0515, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1186.2286, -1122.6843, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-1573.9032, -743.8884, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(501.9328, 1313.4047, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(887.1701, 1473.96, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(927.5474, 1627.1241, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(777.0558, 1273.7545, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-168.89505, 1919.1923, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-300.07248, 1943.3448, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id4", "ep13_f_siauliai_2", Rectangle(-402.27933, 739.88104, 20));

		// 'Darbas_Miner' GenType 1037 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_2.Id5", "ep13_f_siauliai_2", Rectangle(-1256.3351, 487.894, 20));

		// 'Darbas_Miner' GenType 1038 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_2.Id6", "ep13_f_siauliai_2", Rectangle(-551.3528, 1760.9244, 20));

		// 'Darbas_Miner' GenType 1039 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_2.Id7", "ep13_f_siauliai_2", Rectangle(1625.8811, 762.1877, 20));

		// 'Darbas_Miner' GenType 1040 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_2.Id8", "ep13_f_siauliai_2", Rectangle(1120.555, 80.972885, 20));

		// 'Darbas_Miner' GenType 1041 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_2.Id9", "ep13_f_siauliai_2", Rectangle(451.0514, -1015.0561, 20));

		// 'Darbas_Miner' GenType 1043 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_2.Id10", "ep13_f_siauliai_2", Rectangle(-1788.2191, -365.2442, 20));
		AddSpawnPoint("ep13_f_siauliai_2.Id10", "ep13_f_siauliai_2", Rectangle(-2087.4556, -1066.514, 20));
	}
}
