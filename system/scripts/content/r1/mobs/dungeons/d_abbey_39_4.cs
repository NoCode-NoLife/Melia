//--- Melia Script -----------------------------------------------------------
// d_abbey_39_4
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Tyla Monastery' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DAbbey394MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_abbey_39_4.Id1", MonsterId.Rootcrystal_01, 9, 11, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("d_abbey_39_4.Id2", MonsterId.Malstatue, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_39_4.Id3", MonsterId.Malstatue, 17, 22, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_39_4.Id4", MonsterId.Velaphid_Red, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_39_4.Id5", MonsterId.Pumpflap, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_39_4.Id6", MonsterId.Kowak_Orange, 53, 70, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 2 Spawn Points
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(1325.0165, -1512.898, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(1528.3896, -1293.7058, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(1345.5972, -867.70807, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(883.11597, -894.72156, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(718.3438, -564.2074, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(918.94446, -170.31346, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(999.5043, 236.75098, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(707.1797, 363.06927, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(178.71762, 1042.196, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(-92.34607, 1357.33, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(-286.8551, 1044.4973, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(-1040.1747, 409.22668, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(-1585.3436, 184.89128, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(-1169.0027, 165.18596, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(-340.30466, 221.53937, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(71.65028, -758.2885, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(-102.84457, -1254.9172, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(695.41113, -1285.9137, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(140.24788, 241.51968, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(-45.812862, -520.64343, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(295.0653, -1551.2839, 50));

		// 'Malstatue' GenType 30 Spawn Points
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(629.4522, -670.57965, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(585.8745, -602.67896, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(600.5594, -851.0946, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(599.13324, -782.2673, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(713.0823, -1000.7375, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(1383.2473, -985.1598, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(1300.1097, -680.0886, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(1526.7551, -803.51215, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(1515.6931, -932.8676, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(1375.2767, -1542.9774, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(1379.4263, -1270.2123, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(1492.4451, -1564.7958, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(501.6768, -1238.9701, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(567.6688, -1238.1177, 20));

		// 'Malstatue' GenType 31 Spawn Points
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(-125.95502, 17.70446, 20));
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(167.79805, 309.57452, 20));
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(-247.66902, 136.6854, 20));
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(45.281994, 435.0268, 20));
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(873.86084, 315.4781, 20));
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(873.4475, 171.28578, 20));
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(1015.0648, 172.12146, 20));
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(1017.5065, 314.39795, 20));
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(1074.6802, 375.98843, 20));
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(1076.0096, 111.99606, 20));
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(-98.58745, 1133.2341, 20));

		// 'Velaphid_Red' GenType 34 Spawn Points
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-104.01865, 512.69214, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-376.0268, 74.21886, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(303.98492, 390.02484, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-15.25614, 231.84909, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-436.1286, 912.54565, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-27.590149, 1392.1963, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(109.85012, 1009.4448, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(941.41547, 230.66998, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(1123.6057, 49.987152, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(765.4575, 12.932274, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(1118.2788, 467.16855, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-41.205727, 1265.6322, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(117.37119, -30.251741, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(754.6531, 387.8573, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(496.52484, 705.0331, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(393.07166, 836.7412, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-614.8845, 699.7878, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-250.76154, 1160.2009, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(263.44986, 165.38928, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-323.08084, 336.99545, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-248.2095, 188.09518, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(209.97534, 244.29938, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(125.38284, 1150.7081, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-253.64764, 1378.2078, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(292.50302, 946.81946, 25));

		// 'Pumpflap' GenType 37 Spawn Points
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(92.638306, -88.4821, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(-272.30646, -47.29164, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(-140.0864, 204.62433, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(-261.43457, 445.3523, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(292.02563, 267.05377, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(-1175.1185, 407.65582, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(718.79895, 495.50156, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(1174.5039, 253.70845, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(941.47577, 240.67384, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(699.85583, 178.23438, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(1074.4572, 506.72122, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(51.3035, 333.7625, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(116.19007, 550.9102, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(241.45976, -5.819615, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(-357.49344, 317.23947, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(902.49316, -152.01291, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(964.0667, 443.84116, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(-33.52031, 18.34021, 25));

		// 'Kowak_Orange' GenType 58 Spawn Points
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-88.83606, -1242.9182, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(108.24899, -1254.2236, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-78.02999, -1466.3185, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(252.2865, -1357.8977, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(82.47526, -1619.8759, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-108.49754, -1636.4335, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-91.95839, -768.69165, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-82.09838, -605.85095, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(104.06491, -1512.8418, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-118.87949, -1525.346, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-130.76454, -1331.6199, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(14.461881, -1343.2965, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(159.55, -1395.1656, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(341.14157, -1320.6804, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(42.848965, -1274.7778, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(274.1847, -1237.965, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(300.58633, -1472.228, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(326.30173, -1658.2509, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(143.2884, -1644.1727, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(18.079388, -1663.2988, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-20.053913, -1496.7922, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(153.38487, -1451.2133, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(296.461, -1584.8262, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(496.69547, -1282.4895, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(583.95734, -1274.3107, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(528.8191, -1318.6536, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(723.43884, -861.1225, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(641.92053, -769.8752, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(829.92804, -809.0427, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(937.2171, -689.51843, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(955.8803, -830.59155, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(961.85864, -522.11487, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(748.62335, -647.36774, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(604.5883, -683.9311, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(724.2909, -554.8966, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(624.6094, -484.60886, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(776.6316, -483.7848, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(849.9665, -632.6512, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(95.19947, -743.2368, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(47.70546, -794.67126, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-123.83437, -676.67145, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-128.26662, -536.5546, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(130.9432, -567.23676, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-141.54683, -774.9068, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-162.69885, -738.8336, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(28.92974, -728.87756, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-15.87425, -687.1285, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-69.12561, -649.83295, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(2.971808, -620.56537, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(61.94286, -603.64044, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-236.51483, 49.896545, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-356.5828, 187.92082, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-26.090687, 151.15257, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-168.4449, 407.8212, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(8.174843, 353.53363, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-6.7714834, 514.60516, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(207.36755, 342.2619, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(279.05475, 216.9919, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(302.06418, 100.27697, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(175.36446, -25.037167, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-25.959118, -95.5048, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-112.68765, -111.88781, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-196.374, -36.542923, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-85.67053, -51.2797, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(80.78543, 73.48491, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(55.177673, 192.52649, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(111.7764, 273.01782, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(207.71136, 454.70813, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-70.95859, 409.46606, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-157.69115, 292.4514, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-261.25018, 227.68031, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-327.5177, 262.42795, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-251.99744, 16.095295, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(838.7422, -99.56026, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(934.89404, -99.59244, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(826.76855, -9.402438, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(771.4326, 83.04825, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(721.1117, 113.81984, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(891.05206, 18.864517, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(998.96014, -16.233665, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1122.6722, 163.89229, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1015.5342, 116.07243, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1121.1556, 255.71507, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1104.7911, 392.86716, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(817.2438, 157.38048, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(721.2977, 260.08664, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(700.41766, 338.44733, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(834.6089, 312.30994, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(929.5758, 236.19286, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(923.4809, 108.42441, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(982.52313, 390.05264, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(994.8229, 483.74265, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1123.4279, 486.80118, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1172.4579, 475.11237, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1108.1853, 309.21655, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(849.7112, 447.9941, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(781.00854, 479.56317, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(720.9572, 414.86652, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(443.3974, 765.96564, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(524.3973, 738.6056, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(529.7211, 686.5916, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(484.26932, 772.76355, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(376.8461, 831.6934, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(330.69522, 907.4147, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(408.38132, 855.3827, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(267.2499, 929.02563, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(211.95312, 1013.6635, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(196.90091, 1153.5369, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(57.63915, 1179.8239, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(11.031403, 1097.8236, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-204.32132, 1027.9847, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-269.95724, 1127.7771, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-292.1985, 1209.1, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-154.03683, 1245.7455, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-208.1616, 1354.2277, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-265.67337, 1326.0347, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-165.56328, 1410.2557, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(129.73567, 1365.8655, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(267.40662, 1292.594, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(166.92227, 1294.086, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-35.24913, 978.1438, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-87.00549, 1056.2214, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-23.033379, 1297.5696, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1293.7755, 171.5707, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1289.0963, 370.57962, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1102.7145, 251.45915, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1062.5433, 492.48184, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-887.9692, 500.3267, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-827.80804, 400.77292, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-802.20825, 307.30673, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-884.8221, 134.7432, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-961.2556, 148.03026, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-953.6414, 233.55894, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1022.0158, 427.83255, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1156.4175, 512.1317, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1245.849, 493.56058, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1227.4165, 278.4897, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1175.9379, 374.2327, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1179.2806, 126.87157, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1017.847, 343.47144, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-783.42615, 210.82353, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-585.92883, 727.03235, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-550.4583, 775.382, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-512.622, 801.9634, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-477.2921, 847.9314, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-445.43536, 866.0459, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1440.9915, -1567.4569, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1402.8494, -1489.0354, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1276.1844, -1541.6743, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1320.7107, -1447.8021, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1319.1093, -1371.0214, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1262.8763, -1269.0146, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1361.908, -1295.4949, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1408.4132, -1219.3981, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1529.2554, -1252.8058, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1627.601, -1385.6321, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1468.7823, -1335.7957, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1572.0266, -1277.7803, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1592.6785, -1481.9886, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1576.0327, -1549.6964, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1438.8212, -972.90424, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1381.1633, -935.91504, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1375.7644, -640.3462, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1499.4048, -789.2572, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1474.6099, -645.79065, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1554.7871, -588.8056, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1503.1472, -695.1457, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1347.4247, -861.4291, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1261.4663, -872.74634, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1552.1222, -976.0315, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1633.753, -838.83716, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1505.0842, -874.15393, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1605.0613, -648.563, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1536.5723, -537.011, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1298.6241, -741.0802, 25));
	}
}
