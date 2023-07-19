//--- Melia Script -----------------------------------------------------------
// d_zachariel_35
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Royal Mausoleum 4F' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DZachariel35MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_zachariel_35", MonsterId.Dog_Of_King, Properties("MHP", 74539, "MINPATK", 1459, "MAXPATK", 1695, "MINMATK", 1459, "MAXMATK", 1695, "DEF", 542, "MDEF", 542));
		AddPropertyOverrides("d_zachariel_35", MonsterId.Schlesien_Guard, Properties("MHP", 75490, "MINPATK", 1472, "MAXPATK", 1710, "MINMATK", 1472, "MAXMATK", 1710, "DEF", 557, "MDEF", 557));
		AddPropertyOverrides("d_zachariel_35", MonsterId.Wolf_Statue_Bow, Properties("MHP", 76455, "MINPATK", 1484, "MAXPATK", 1726, "MINMATK", 1484, "MAXMATK", 1726, "DEF", 571, "MDEF", 571));
		AddPropertyOverrides("d_zachariel_35", MonsterId.Karas_Mage, Properties("MHP", 77433, "MINPATK", 1497, "MAXPATK", 1741, "MINMATK", 1497, "MAXMATK", 1741, "DEF", 586, "MDEF", 586));
		AddPropertyOverrides("d_zachariel_35", MonsterId.Shtayim, Properties("MHP", 78424, "MINPATK", 1509, "MAXPATK", 1757, "MINMATK", 1509, "MAXMATK", 1757, "DEF", 602, "MDEF", 602));
		AddPropertyOverrides("d_zachariel_35", MonsterId.Wolf_Statue, Properties("MHP", 79427, "MINPATK", 1522, "MAXPATK", 1773, "MINMATK", 1522, "MAXMATK", 1773, "DEF", 617, "MDEF", 617));
		AddPropertyOverrides("d_zachariel_35", MonsterId.Karas, Properties("MHP", 80444, "MINPATK", 1535, "MAXPATK", 1789, "MINMATK", 1535, "MAXMATK", 1789, "DEF", 632, "MDEF", 632));
		AddPropertyOverrides("d_zachariel_35", MonsterId.Boss_Bearkaras_Q2, Properties("MHP", 395956, "MINPATK", 3345, "MAXPATK", 3899, "MINMATK", 3345, "MAXMATK", 3899, "DEF", 1400, "MDEF", 1400));

		// Monster Spawners ---------------------------------

		AddSpawner("d_zachariel_35.Id1", MonsterId.Rootcrystal_05, 6, 8, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("d_zachariel_35.Id2", MonsterId.Dog_Of_King, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_35.Id3", MonsterId.Schlesien_Guard, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_35.Id4", MonsterId.Schlesien_Guard, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_35.Id5", MonsterId.Dog_Of_King, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_35.Id6", MonsterId.Schlesien_Guard, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_35.Id7", MonsterId.Dog_Of_King, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_35.Id8", MonsterId.Wolf_Statue_Bow, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_zachariel_35.Id9", MonsterId.Karas_Mage, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 600 Spawn Points
		AddSpawnPoint("d_zachariel_35.Id1", "d_zachariel_35", Rectangle(1059, -1508, 30));
		AddSpawnPoint("d_zachariel_35.Id1", "d_zachariel_35", Rectangle(1212, -118, 30));
		AddSpawnPoint("d_zachariel_35.Id1", "d_zachariel_35", Rectangle(1084, 1432, 30));
		AddSpawnPoint("d_zachariel_35.Id1", "d_zachariel_35", Rectangle(-56, -112, 30));
		AddSpawnPoint("d_zachariel_35.Id1", "d_zachariel_35", Rectangle(-669, 1159, 30));
		AddSpawnPoint("d_zachariel_35.Id1", "d_zachariel_35", Rectangle(-962, -1449, 30));
		AddSpawnPoint("d_zachariel_35.Id1", "d_zachariel_35", Rectangle(-1049.58, -50.64, 30));
		AddSpawnPoint("d_zachariel_35.Id1", "d_zachariel_35", Rectangle(496.63, 1507.51, 30));

		// 'Dog_Of_King' GenType 608 Spawn Points
		AddSpawnPoint("d_zachariel_35.Id2", "d_zachariel_35", Rectangle(1115.39, -54.95, 9999));

		// 'Schlesien_Guard' GenType 3006 Spawn Points
		AddSpawnPoint("d_zachariel_35.Id3", "d_zachariel_35", Rectangle(1142.77, 378.01, 9999));

		// 'Schlesien_Guard' GenType 3009 Spawn Points
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-1127.2925, -5.237278, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-382.68744, 1073.2947, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-456.90237, -1514.6917, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-706.53326, -1387.3633, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-710.90137, -1164.4236, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-39.386482, 10.010991, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-1043.3499, 220.38158, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-717.3054, -37.763077, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-632.5436, 1109.9404, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-409.6889, 1220.4052, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-826.5206, 1535.3662, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-1035.802, 639.2919, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-21.363338, -1609.1919, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(37.87052, -1459.0496, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-196.22528, -1636.496, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-933.7402, -1484.4596, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-974.2219, -1159.6562, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-1059.7401, -792.7415, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-1127.8577, -149.7472, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-1030.4664, 1111.7909, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-1007.0706, 1435.932, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-461.3912, 1518.5935, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-348.24167, 842.8931, 40));

		// 'Dog_Of_King' GenType 3010 Spawn Points
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(1202, -130.81, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(47.011475, -23.668524, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(-1078.7739, -38.961216, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(-88.466644, -18.589546, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(-714.6783, 21.319424, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(-1093.767, 142.75584, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(-1232.0343, -25.201832, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(-1165.3533, 79.384384, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(-1099.8643, -184.10295, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(-766.1857, -27.042217, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(-512.28436, 2.1103578, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(-4.0336475, -151.2605, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(68.13842, 61.295662, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(204.32904, -125.68238, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(295.11035, 13.622854, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(703.3033, -46.698463, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(895.97314, -46.759758, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(1175.6902, 8.549145, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(1316.9564, -29.732481, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(1009.8594, -127.74527, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(1083.2496, 49.328735, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(1101.278, -35.59607, 250));

		// 'Schlesien_Guard' GenType 3012 Spawn Points
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(949.13855, -1220.0088, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(815.02136, -1013.9138, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(799.7737, -1209.8016, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(915.2967, -1500.8888, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(1102.3961, -1539.8276, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(1175.8735, -1372.4368, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(727.497, -1579.2648, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(1159.4231, -856.41364, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(900.6339, -1104.533, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(1142.0171, -567.2915, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(1158.4218, -234.54208, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(449.29117, -1569.1431, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(1104.8287, -1434.1208, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(919.6759, -1386.5553, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(1028.3838, -1027.7965, 30));

		// 'Dog_Of_King' GenType 3016 Spawn Points
		AddSpawnPoint("d_zachariel_35.Id7", "d_zachariel_35", Rectangle(589.1893, 1077.7766, 300));
		AddSpawnPoint("d_zachariel_35.Id7", "d_zachariel_35", Rectangle(-504.60687, 1076.8198, 300));

		// 'Wolf_Statue_Bow' GenType 3021 Spawn Points
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-501.58447, 1107.3938, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-737.3651, -1401.9734, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-748.31415, -1176.2185, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-1084.0148, 236.27078, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(174.7642, -93.79431, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(1017.3524, -51.811123, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(1239.3823, -43.215183, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(95.730644, 51.351112, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(1073.9929, 1386.8269, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(550.26184, 929.5886, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(723.68634, 1167.3525, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-1082.2452, -347.62518, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-1067.0808, 589.0011, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-994.64343, 1121.0537, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-862.5121, 1496.215, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(1184.7333, 531.2772, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-1040.0417, -934.6595, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(1201.4207, -446.2313, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(711.3757, -54.61299, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-690.45764, -38.37567, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-1165.8862, -30.540737, 30));

		// 'Karas_Mage' GenType 3022 Spawn Points
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(-558.3685, 1113.7148, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(-378.97174, 1045.5791, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(19.21125, -1562.7427, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(-174.27927, -1570.0808, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(696.4939, 965.32074, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(788.87134, 1210.1826, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(-1089.062, -29.186546, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(-801.77344, -1456.5967, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(-719.53894, -1171.7874, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(-1051.8967, -734.0041, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(-1035.099, 467.80963, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(427.63116, 1414.5299, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(1001.3181, 1483.2828, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(1179.8342, 950.8537, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(1136.946, 382.73593, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(651.7399, -51.015175, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(903.3743, -60.422195, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(-14.996721, -70.16816, 30));
	}
}
