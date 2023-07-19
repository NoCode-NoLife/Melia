//--- Melia Script -----------------------------------------------------------
// f_siauliai_46_4
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Dina Bee Farm' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliai464MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_siauliai_46_4", MonsterId.Lantern_Mushroom_Orange, Properties("MHP", 223995, "MINPATK", 3381, "MAXPATK", 4057, "MINMATK", 3381, "MAXMATK", 4057, "DEF", 9733, "MDEF", 9733));
		AddPropertyOverrides("f_siauliai_46_4", MonsterId.Siaulamb, Properties("MHP", 225106, "MINPATK", 3396, "MAXPATK", 4075, "MINMATK", 3396, "MAXMATK", 4075, "DEF", 9882, "MDEF", 9882));
		AddPropertyOverrides("f_siauliai_46_4", MonsterId.Siaulogre, Properties("MHP", 226289, "MINPATK", 3411, "MAXPATK", 4093, "MINMATK", 3411, "MAXMATK", 4093, "DEF", 10040, "MDEF", 10040));
		AddPropertyOverrides("f_siauliai_46_4", MonsterId.Rabbee, Properties("MHP", 227540, "MINPATK", 3427, "MAXPATK", 4113, "MINMATK", 3427, "MAXMATK", 4113, "DEF", 10207, "MDEF", 10207));
		AddPropertyOverrides("f_siauliai_46_4", MonsterId.Honeybean, Properties("MHP", 228855, "MINPATK", 3444, "MAXPATK", 4134, "MINMATK", 3444, "MAXMATK", 4134, "DEF", 10383, "MDEF", 10383));
		AddPropertyOverrides("f_siauliai_46_4", MonsterId.Pendinmire, Properties("MHP", 230231, "MINPATK", 3462, "MAXPATK", 4156, "MINMATK", 3462, "MAXMATK", 4156, "DEF", 10566, "MDEF", 10566));
		AddPropertyOverrides("f_siauliai_46_4", MonsterId.Boss_Sparnas_Q1, Properties("MHP", 1181493, "MINPATK", 8352, "MAXPATK", 10028, "MINMATK", 8352, "MAXMATK", 10028, "DEF", 25819, "MDEF", 25819));
		AddPropertyOverrides("f_siauliai_46_4", MonsterId.Boss_BiteRegina_Q4, Properties("MHP", 1189096, "MINPATK", 8398, "MAXPATK", 10085, "MINMATK", 8398, "MAXMATK", 10085, "DEF", 26297, "MDEF", 26297));

		// Monster Spawners ---------------------------------

		AddSpawner("f_siauliai_46_4.Id1", MonsterId.Lantern_Mushroom_Orange, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_4.Id2", MonsterId.Lantern_Mushroom_Orange, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_4.Id3", MonsterId.Siaulamb, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_4.Id4", MonsterId.Siaulogre, 3, 4, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_4.Id5", MonsterId.Rabbee, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_4.Id6", MonsterId.Honeybean, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_4.Id7", MonsterId.Rabbee, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_4.Id8", MonsterId.Rootcrystal_01, 12, 16, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_4.Id9", MonsterId.Pendinmire, 1, 1, TimeSpan.FromMilliseconds(3600000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_4.Id10", MonsterId.Siaulamb, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_4.Id11", MonsterId.Rabbee, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_46_4.Id12", MonsterId.Honeybean, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Lantern_Mushroom_Orange' GenType 8 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id1", "f_siauliai_46_4", Rectangle(276.90982, 2.2976265, 30));
		AddSpawnPoint("f_siauliai_46_4.Id1", "f_siauliai_46_4", Rectangle(456.9365, -89.653275, 30));
		AddSpawnPoint("f_siauliai_46_4.Id1", "f_siauliai_46_4", Rectangle(196.51338, -92.70337, 30));
		AddSpawnPoint("f_siauliai_46_4.Id1", "f_siauliai_46_4", Rectangle(216.2296, -239.69543, 30));
		AddSpawnPoint("f_siauliai_46_4.Id1", "f_siauliai_46_4", Rectangle(353.6979, -342.46518, 30));
		AddSpawnPoint("f_siauliai_46_4.Id1", "f_siauliai_46_4", Rectangle(473.03424, -261.55124, 30));
		AddSpawnPoint("f_siauliai_46_4.Id1", "f_siauliai_46_4", Rectangle(363.7529, -158.18048, 30));
		AddSpawnPoint("f_siauliai_46_4.Id1", "f_siauliai_46_4", Rectangle(592.0852, -19.248587, 30));

		// 'Lantern_Mushroom_Orange' GenType 21 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id2", "f_siauliai_46_4", Rectangle(439.17435, 199.01242, 9999));
		AddSpawnPoint("f_siauliai_46_4.Id2", "f_siauliai_46_4", Rectangle(343.3728, -349.56528, 9999));
		AddSpawnPoint("f_siauliai_46_4.Id2", "f_siauliai_46_4", Rectangle(343.3728, -349.56528, 9999));
		AddSpawnPoint("f_siauliai_46_4.Id2", "f_siauliai_46_4", Rectangle(-1151.6113, 159.19933, 9999));
		AddSpawnPoint("f_siauliai_46_4.Id2", "f_siauliai_46_4", Rectangle(187.97266, -859.8214, 9999));

		// 'Siaulamb' GenType 25 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-356.04013, 360.16257, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(1271.3251, 1906.8903, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-298.77985, 152.21057, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(662.9985, 1669.5115, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(448.06775, 1753.8748, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-269.5324, 907.2461, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-145.0773, 773.13385, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-360.79507, 755.45776, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(1207.8118, 1609.8082, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-548.6508, 292.72073, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(110.3297, 306.69382, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(634.72003, 222.30301, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(1060.8629, 1615.3123, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(420.4515, 173.75519, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-169.24515, 242.98637, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-394.9705, 243.27182, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(292.041, 280.18607, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(148.95886, -205.70302, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(148.95886, -205.70302, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-971.672, 256.11993, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-1020.262, 319.94266, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-903.3399, 294.98325, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-1042.7717, 78.491425, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-974.9489, 424.33054, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-881.97565, 389.53232, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-813.13214, 365.03708, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-1177.989, 263.03445, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-1107.4508, 284.17297, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-1004.2309, 516.92426, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-432.99585, 295.17307, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-408.98477, 405.06448, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-455.7049, 125.26946, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-376.42255, 156.61086, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-272.41718, 260.8366, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-224.22556, 160.72838, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-321.21713, 215.6645, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-198.7853, 282.9402, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-239.8858, 736.015, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-210.21387, 805.3004, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-210.08257, 876.0204, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-317.3794, 943.10785, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-379.0996, 828.9023, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-285.05957, 791.52795, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-177.40294, 705.9783, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-95.84045, 741.91315, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-421.4054, 752.55695, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-370.6625, 900.1399, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(213.25621, 190.47467, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(175.30142, 65.39279, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(69.10922, -106.42803, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(355.66275, 380.6054, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(335.01523, 158.14847, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(564.93427, 321.86255, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(489.1453, 168.55063, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(1173.3405, 1683.4589, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(577.8842, 132.68852, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(248.44649, 396.4678, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(409.9194, 342.98846, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(111.13348, -4.001791, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(286.3478, 1426.3209, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(173.55022, 1475.2612, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(287.97656, 1616.4822, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(352.81085, 1524.2173, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(188.99385, 1600.3606, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(373.6004, 1661.761, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(559.9837, 1765.1985, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(927.87384, 1627.1415, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(504.42767, 1605.3691, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(655.154, 1757.9939, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(1094.4333, 1821.7876, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(750.34576, 1690.7772, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(1286.3999, 1807.1769, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(1034.6622, 1487.8616, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(1001.3138, 1744.05, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(283.46167, -85.59299, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(389.86548, -59.08262, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(552.7036, -96.65184, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(454.67935, -214.49275, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(305.5094, -235.13676, 65));

		// 'Siaulogre' GenType 27 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id4", "f_siauliai_46_4", Rectangle(428.13293, 233.34436, 4000));

		// 'Rabbee' GenType 28 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(294.7493, -769.3384, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(151.43536, -925.09094, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(427.5225, -651.9985, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(68.29898, -936.7909, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(103.96864, -852.1436, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(2.7663612, -968.784, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(259.07083, -980.8507, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(233.05257, -1051.0372, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(325.41336, -1076.0449, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(374.5046, -1010.2429, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(398.22803, -943.0613, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(308.29865, -1003.9792, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(295.86963, -579.6646, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(45.59632, -809.05255, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(66.28506, -743.6466, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(103.29675, -666.8727, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(152.934, -608.9413, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(168.32047, -697.3012, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(245.32607, -718.98724, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(403.73892, -545.0004, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(260.15393, -517.4209, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(367.25195, -694.3342, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(457.38733, -755.5561, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(909.4848, -836.8708, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(907.7004, -699.4718, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1029.7761, -604.6781, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1251.8881, -630.9042, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1342.4885, -778.42487, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1373.6202, -894.25525, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1328.3469, -1017.4717, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1124.2207, -1056.9601, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1094.1686, -1007.4665, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1177.046, -992.75854, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1124.7577, -831.53284, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1157.3589, -701.68506, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1327.4314, -652.42834, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1412.3114, -959.6268, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1309.476, -1054.5746, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(965.6098, -884.9418, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(967.69165, -812.3507, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(830.9219, -832.4287, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(971.5224, -663.22363, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1106.2092, -582.7263, 25));

		// 'Honeybean' GenType 29 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(429.22168, -650.3936, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(333.3592, -860.20764, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(215.05133, -614.6726, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(12.73279, -879.4584, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(115.79884, -771.1611, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(54.04925, -1010.3282, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(169.15292, -996.34265, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(271.97284, -871.5244, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(313.24475, -925.5208, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(365.2029, -782.6045, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(396.11676, -849.5111, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(333.31314, -593.19183, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(454.9094, -720.0085, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(232.35265, -934.58966, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(766.30536, -776.081, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(791.3144, -719.7636, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(859.0048, -792.5112, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(931.89734, -733.24835, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1017.6171, -725.4807, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(950.2513, -859.40607, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1015.5308, -816.4742, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1065.6035, -855.83887, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1154.7678, -898.14453, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1127.4869, -1023.0509, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1157.5692, -1079.9926, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1233.138, -1025.7504, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1220.7876, -958.5911, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1251.4481, -908.1973, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1293.7461, -911.47986, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1383.4153, -929.1099, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1196.058, -877.78296, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1304.287, -836.4069, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1186.9832, -776.0612, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1170.3248, -658.1096, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(798.71857, 148.22467, 25));

		// 'Rabbee' GenType 30 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id7", "f_siauliai_46_4", Rectangle(916.1989, -60.432365, 9999));

		// 'Rootcrystal_01' GenType 31 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(927.24023, -738.1808, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(320.08304, -936.2105, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(-240.03525, -1143.7585, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(355.86542, -146.75392, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(1279.7974, -259.41846, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(-983.6338, 288.4217, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(-325.00296, 225.53725, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(-244.05438, 800.63617, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(196.48737, 341.49957, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(552.85645, 227.67226, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(1053.9537, 213.02873, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(248.89545, 1580.4396, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(1102.2045, 1716.0586, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(1360.926, 2698.833, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(1355.6769, 2391.7153, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(1325.6825, -949.69806, 150));

		// 'Pendinmire' GenType 33 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id9", "f_siauliai_46_4", Rectangle(220.827, 1433.1941, 10));

		// 'Siaulamb' GenType 35 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id10", "f_siauliai_46_4", Rectangle(-1057.5651, 193.74162, 25));
		AddSpawnPoint("f_siauliai_46_4.Id10", "f_siauliai_46_4", Rectangle(-1129.0568, 398.62173, 25));
		AddSpawnPoint("f_siauliai_46_4.Id10", "f_siauliai_46_4", Rectangle(-1061.7264, 436.32532, 25));
		AddSpawnPoint("f_siauliai_46_4.Id10", "f_siauliai_46_4", Rectangle(-893.03595, 471.501, 25));
		AddSpawnPoint("f_siauliai_46_4.Id10", "f_siauliai_46_4", Rectangle(-912.8106, 190.7921, 25));
		AddSpawnPoint("f_siauliai_46_4.Id10", "f_siauliai_46_4", Rectangle(-961.9991, 118.11208, 25));

		// 'Rabbee' GenType 36 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id11", "f_siauliai_46_4", Rectangle(834.64166, -751.5061, 25));
		AddSpawnPoint("f_siauliai_46_4.Id11", "f_siauliai_46_4", Rectangle(1050.3492, -756.40814, 25));
		AddSpawnPoint("f_siauliai_46_4.Id11", "f_siauliai_46_4", Rectangle(1137.3726, -641.83484, 25));
		AddSpawnPoint("f_siauliai_46_4.Id11", "f_siauliai_46_4", Rectangle(1219.7675, -810.6421, 25));
		AddSpawnPoint("f_siauliai_46_4.Id11", "f_siauliai_46_4", Rectangle(1120.3735, -921.61383, 25));
		AddSpawnPoint("f_siauliai_46_4.Id11", "f_siauliai_46_4", Rectangle(1293.1146, -956.00793, 25));
		AddSpawnPoint("f_siauliai_46_4.Id11", "f_siauliai_46_4", Rectangle(1201.6136, -1046.6921, 25));
		AddSpawnPoint("f_siauliai_46_4.Id11", "f_siauliai_46_4", Rectangle(1357.8141, -846.2986, 25));
		AddSpawnPoint("f_siauliai_46_4.Id11", "f_siauliai_46_4", Rectangle(1332.7656, -719.47076, 25));

		// 'Honeybean' GenType 37 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id12", "f_siauliai_46_4", Rectangle(954.2181, -753.5791, 25));
		AddSpawnPoint("f_siauliai_46_4.Id12", "f_siauliai_46_4", Rectangle(1067.9904, -660.9697, 25));
		AddSpawnPoint("f_siauliai_46_4.Id12", "f_siauliai_46_4", Rectangle(1108.5839, -781.8514, 25));
		AddSpawnPoint("f_siauliai_46_4.Id12", "f_siauliai_46_4", Rectangle(1238.9587, -694.0622, 25));
		AddSpawnPoint("f_siauliai_46_4.Id12", "f_siauliai_46_4", Rectangle(1268.6122, -824.9149, 25));
		AddSpawnPoint("f_siauliai_46_4.Id12", "f_siauliai_46_4", Rectangle(1182.5398, -920.34106, 25));
		AddSpawnPoint("f_siauliai_46_4.Id12", "f_siauliai_46_4", Rectangle(1329.7574, -960.8223, 25));
		AddSpawnPoint("f_siauliai_46_4.Id12", "f_siauliai_46_4", Rectangle(1236.0942, -1060.6285, 25));
		AddSpawnPoint("f_siauliai_46_4.Id12", "f_siauliai_46_4", Rectangle(1394.1714, -826.5211, 25));
		AddSpawnPoint("f_siauliai_46_4.Id12", "f_siauliai_46_4", Rectangle(1370.3815, -723.7696, 25));
	}
}
