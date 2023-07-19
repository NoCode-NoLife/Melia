//--- Melia Script -----------------------------------------------------------
// ep13_f_siauliai_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Lemprasa Pond' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep13FSiauliai1MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep13_f_siauliai_1", MonsterId.Liepsna_Invader, Properties("MHP", 910601, "MINPATK", 12210, "MAXPATK", 14909, "MINMATK", 12210, "MAXMATK", 14909, "DEF", 373977, "MDEF", 373977));
		AddPropertyOverrides("ep13_f_siauliai_1", MonsterId.Liepsna_Destroyer, Properties("MHP", 911557, "MINPATK", 12222, "MAXPATK", 14924, "MINMATK", 12222, "MAXMATK", 14924, "DEF", 375060, "MDEF", 375060));
		AddPropertyOverrides("ep13_f_siauliai_1", MonsterId.Liepsna_Chaser, Properties("MHP", 913304, "MINPATK", 12245, "MAXPATK", 14952, "MINMATK", 12245, "MAXMATK", 14952, "DEF", 377040, "MDEF", 377040));
		AddPropertyOverrides("ep13_f_siauliai_1", MonsterId.Liepsna_Spreader, Properties("MHP", 915566, "MINPATK", 12274, "MAXPATK", 14987, "MINMATK", 12274, "MAXMATK", 14987, "DEF", 379605, "MDEF", 379605));
		AddPropertyOverrides("ep13_f_siauliai_1", MonsterId.Boss_Liepsna_Firebug, Properties("MHP", 5013621, "MINPATK", 33971, "MAXPATK", 41482, "MINMATK", 33971, "MAXMATK", 41482, "DEF", 1056090, "MDEF", 1056090));

		// Monster Spawners ---------------------------------

		AddSpawner("ep13_f_siauliai_1.Id1", MonsterId.Rootcrystal_01, 15, 20, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id2", MonsterId.Liepsna_Invader, 60, 80, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id3", MonsterId.Liepsna_Destroyer, 30, 40, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id4", MonsterId.Liepsna_Chaser, 60, 80, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id5", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id6", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id7", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id8", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id9", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id10", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id11", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id12", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id13", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id14", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id15", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id16", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id17", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id18", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id19", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id20", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id21", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id22", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id23", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id24", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id25", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id26", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id27", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id28", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id29", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id30", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id31", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id32", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id33", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id34", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id35", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id36", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id37", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id38", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id39", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id40", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id41", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id42", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id43", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id44", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id45", MonsterId.Liepsna_Invader, 15, 20, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id46", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id47", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_1.Id48", MonsterId.Liepsna_Spreader, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 4 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(329.48898, -300.50092, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(371.20502, 128.16537, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(760.30237, 544.79553, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(722.057, 1229.0355, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(250.99806, 1572.3615, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-511.34366, 1584.9939, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-863.1563, 1551.2291, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-669.0167, 1010.5892, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-362.57297, 562.1141, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-429.312, 136.39116, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-389.99014, -443.7227, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-767.2565, -547.33405, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-890.44476, -806.70184, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-1710.1826, -1188.1558, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-1547.4829, -1449.5396, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-351.53076, -1623.7228, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(-13.278793, -1109.5298, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(71.233765, -1538.2854, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(1358.4744, 104.19524, 100));
		AddSpawnPoint("ep13_f_siauliai_1.Id1", "ep13_f_siauliai_1", Rectangle(1859.0321, 155.81516, 100));

		// 'Liepsna_Invader' GenType 1000 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-1665.8967, -1578.4231, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-1794.4856, -1398.4061, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-1553.4995, -1436.6549, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-1362.7512, -1473.5576, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-1635.5487, -1237.7104, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-1673.1246, -1042.6683, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-822.7511, -726.93353, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-708.4674, -650.4605, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-791.87646, -513.66876, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-726.15454, -435.45145, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-214.4514, -1548.5117, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-7.3271713, -1567.1467, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-73.07115, -1842.6959, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(54.640533, -1965.7288, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(124.15184, -1284.6624, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(73.597496, -1003.9662, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(158.36288, -310.5187, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(259.4801, -141.20996, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(878.8103, 993.7237, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(668.7957, 1213.9985, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(756.6472, 1771.1727, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(965.97534, 1748.8462, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(192.8952, 1675.5171, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(391.06696, 1556.5829, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(139.99112, 992.8429, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(188.60507, 1186.406, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-442.59384, 942.8201, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-251.24261, 839.29004, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-549.206, 1617.0361, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-470.61194, 1821.3372, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-871.1676, 1678.5686, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-936.9555, 1925.4238, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-703.6294, 1103.1199, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-820.4229, 1424.8567, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-976.7155, 998.5989, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-765.8126, 1030.8088, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(390.983, 109.39833, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(504.45834, 263.6942, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(1901.7977, 114.97591, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(1515.603, 114.39378, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(474.1927, -328.50626, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(624.34235, -340.6811, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(861.2309, 1441.7886, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-506.9128, -529.7548, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-249.36772, -860.7876, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-299.98557, -687.1469, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-45.65896, -1044.917, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-541.22565, 312.82983, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-117.68803, 197.47281, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-420.01248, 95.64795, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(754.4974, -166.42633, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-831.61633, 1563.5276, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-931.47235, 1262.358, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-598.08734, 1159.8007, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(1778.3408, 95.63854, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(1834.5898, 164.86365, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(758.3734, 1542.577, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(677.7303, 1123.9349, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(152.56859, 1389.9471, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(216.8225, 1439.526, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(100.27995, 1226.3911, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(260.51193, 926.34564, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-675.8606, 885.66156, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-1137.7556, -1527.6273, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(-1233.704, -1006.2504, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(66.15788, -860.57764, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(87.541595, -590.31866, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id2", "ep13_f_siauliai_1", Rectangle(191.4006, -449.44107, 20));

		// 'Liepsna_Destroyer' GenType 1001 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-1753.5977, -1504.8285, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-1456.174, -1471.8419, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-1676.1628, -1169.1843, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-737.04175, -730.51935, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-815.4513, -379.00168, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-16.91903, -2037.6649, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(81.474724, -1146.1113, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(212.43008, -235.30475, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(439.6805, 200.41199, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-552.1679, 679.7075, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-344.8424, 891.6775, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-874.628, 1021.9415, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-774.5009, 1312.432, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-941.468, 1791.4553, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-531.2647, 1728.0356, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(182.14621, 1063.5536, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(295.40723, 1602.9263, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(871.2131, 1736.2281, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(757.21497, 1191.9335, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-112.79036, -1567.6534, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(891.89716, -238.56233, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(742.2522, -279.3985, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(510.52405, 1354.5002, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(667.1023, 1533.5702, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-584.8484, 957.97546, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-463.3419, 1138.8848, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(207.32578, -1368.1174, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-947.8688, -784.0531, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(407.7443, -55.471626, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(314.13016, 1334.957, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-718.33386, 1611.3007, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-1070.2882, 1144.9246, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-115.96567, -1259.5181, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(125.50087, 1447.6031, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(-875.54504, -586.8585, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(36.156563, -1741.1353, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id3", "ep13_f_siauliai_1", Rectangle(1746.6495, 160.93362, 20));

		// 'Liepsna_Chaser' GenType 1002 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1775.5518, -1592.9911, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1681.4548, -1455.4128, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1431.8677, -1563.5721, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1443.2838, -1360.4517, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1786.9872, -1206.0897, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1577.1605, -1035.296, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-908.129, -450.44025, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-719.8349, -337.80063, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-807.70337, -823.6707, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-638.4696, -663.1844, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-64.07443, -1929.2103, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-82.18974, -1658.7751, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-212.09407, -1417.545, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-19.50843, -1194.4471, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(194.56265, -1118.706, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(140.82516, -138.39478, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(269.2527, -325.87692, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(303.2139, 240.07712, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(514.4721, 120.61481, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(779.60547, 1087.4244, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(744.2547, 1335.3309, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(829.5043, 1642.2928, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(914.8029, 1866.885, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(235.54033, 1518.8558, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(350.35226, 1696.022, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(73.71442, 1071.4651, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(297.00385, 1016.7698, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-514.69604, 586.86615, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-587.7018, 780.363, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-323.81363, 1024.9855, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-844.1856, 897.2665, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-941.48883, 1123.71, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-837.52844, 1235.0554, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-734.0923, 1466.0563, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1079.1233, 1863.0386, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-831.0358, 1800.0786, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-661.5538, 1756.4971, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-443.7163, 1659.1606, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(1833.1455, 263.8395, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(1748.0841, 55.738747, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(1834.5448, 63.1315, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(1631.1217, 87.404755, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(1743.6174, 239.40054, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(1397.5095, 112.97771, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(492.91852, -183.55118, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(620.81506, -233.0115, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(749.64844, -399.48102, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(837.1795, -314.7945, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(669.8516, 344.40173, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(720.61005, 779.65283, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(521.2342, 1482.2407, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(628.0263, 1370.3245, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-406.56137, 1162.2599, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-487.0252, 1034.167, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-630.24646, 1026.3024, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-574.4477, 882.4154, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-369.51712, -464.7421, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-340.02505, -350.33658, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-419.48053, -192.0788, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-154.79562, -156.79819, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(101.72034, -1552.1136, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(191.76846, -1470.3733, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-488.47842, -1785.7234, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-303.06686, -1638.1028, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-696.9413, -1559.1829, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1350.919, -1076.1003, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1033.2747, -897.5877, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-301.7512, 188.96754, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-307.90393, 386.54968, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-274.22488, 529.42773, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-479.5555, 426.8715, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(367.34323, -118.9154, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(694.7957, 1676.0841, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(231.28291, 1355.7258, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(391.65, 1352.0132, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1091.6295, 1065.1973, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1020.8062, 1207.7946, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-992.41614, 1707.3342, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(796.39886, -554.3264, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(930.6892, -578.4655, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(565.1232, 1285.4786, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-462.54285, 1537.101, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-46.074394, 1518.9523, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-728.1183, 1188.8263, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-657.98804, 1266.4119, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-934.52747, -614.41656, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-710.04504, -573.38007, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1515.984, -1543.186, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1600.5818, -1530.4698, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1728.3724, -1324.855, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-1546.529, -1331.8604, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-154.81624, -1121.0497, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-123.09649, -923.2578, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-16.643616, -940.4032, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(-404.44666, -1783.8899, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id4", "ep13_f_siauliai_1", Rectangle(10.419476, -1954.8568, 20));

		// 'Liepsna_Spreader' GenType 1003 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id5", "ep13_f_siauliai_1", Rectangle(-1877.1318, -1401.649, 20));

		// 'Liepsna_Spreader' GenType 1004 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id6", "ep13_f_siauliai_1", Rectangle(-1847.3365, -1203.1738, 20));

		// 'Liepsna_Spreader' GenType 1005 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id7", "ep13_f_siauliai_1", Rectangle(-1542.408, -1637.5466, 20));

		// 'Liepsna_Spreader' GenType 1006 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id8", "ep13_f_siauliai_1", Rectangle(-1526.3811, -1251.8658, 20));

		// 'Liepsna_Spreader' GenType 1007 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id9", "ep13_f_siauliai_1", Rectangle(-1330.4296, -1184.6859, 20));

		// 'Liepsna_Spreader' GenType 1008 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id10", "ep13_f_siauliai_1", Rectangle(-895.46265, -915.07056, 20));

		// 'Liepsna_Spreader' GenType 1009 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id11", "ep13_f_siauliai_1", Rectangle(-998.30536, -631.4204, 20));

		// 'Liepsna_Spreader' GenType 1010 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id12", "ep13_f_siauliai_1", Rectangle(-635.0888, -526.64105, 20));

		// 'Liepsna_Spreader' GenType 1011 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id13", "ep13_f_siauliai_1", Rectangle(-421.0694, -416.123, 20));

		// 'Liepsna_Spreader' GenType 1012 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id14", "ep13_f_siauliai_1", Rectangle(-231.32494, -960.90967, 20));

		// 'Liepsna_Spreader' GenType 1013 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id15", "ep13_f_siauliai_1", Rectangle(-583.39746, -1734.4144, 20));

		// 'Liepsna_Spreader' GenType 1014 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id16", "ep13_f_siauliai_1", Rectangle(-367.97034, -1534.3229, 20));

		// 'Liepsna_Spreader' GenType 1015 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id17", "ep13_f_siauliai_1", Rectangle(58.432583, -1888.5396, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id17", "ep13_f_siauliai_1", Rectangle(565.1698, 335.26096, 20));

		// 'Liepsna_Spreader' GenType 1016 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id18", "ep13_f_siauliai_1", Rectangle(40.50522, -1414.463, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id18", "ep13_f_siauliai_1", Rectangle(119.58994, 304.02277, 20));

		// 'Liepsna_Spreader' GenType 1017 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id19", "ep13_f_siauliai_1", Rectangle(-238.46396, -1263.1016, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id19", "ep13_f_siauliai_1", Rectangle(248.93022, 85.79149, 20));

		// 'Liepsna_Spreader' GenType 1018 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id20", "ep13_f_siauliai_1", Rectangle(-495.07346, 144.16199, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id20", "ep13_f_siauliai_1", Rectangle(806.82886, -629.6574, 20));

		// 'Liepsna_Spreader' GenType 1019 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id21", "ep13_f_siauliai_1", Rectangle(91.543915, 19.59885, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id21", "ep13_f_siauliai_1", Rectangle(882.6289, -410.42618, 20));

		// 'Liepsna_Spreader' GenType 1020 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id22", "ep13_f_siauliai_1", Rectangle(71.10203, -158.04453, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id22", "ep13_f_siauliai_1", Rectangle(535.1203, -392.99457, 20));

		// 'Liepsna_Spreader' GenType 1021 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id23", "ep13_f_siauliai_1", Rectangle(298.8532, -469.6713, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id23", "ep13_f_siauliai_1", Rectangle(841.9558, 434.62503, 20));

		// 'Liepsna_Spreader' GenType 1022 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id24", "ep13_f_siauliai_1", Rectangle(730.12634, -494.58337, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id24", "ep13_f_siauliai_1", Rectangle(696.2347, 613.65717, 20));

		// 'Liepsna_Spreader' GenType 1023 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id25", "ep13_f_siauliai_1", Rectangle(941.7795, -506.36734, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id25", "ep13_f_siauliai_1", Rectangle(876.14905, 920.6615, 20));

		// 'Liepsna_Spreader' GenType 1024 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id26", "ep13_f_siauliai_1", Rectangle(902.1524, -658.0071, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id26", "ep13_f_siauliai_1", Rectangle(623.8796, 968.4949, 20));

		// 'Liepsna_Spreader' GenType 1025 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id27", "ep13_f_siauliai_1", Rectangle(538.60004, 1092.7405, 20));

		// 'Liepsna_Spreader' GenType 1026 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id28", "ep13_f_siauliai_1", Rectangle(541.96765, 1669.9729, 20));

		// 'Liepsna_Spreader' GenType 1027 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id29", "ep13_f_siauliai_1", Rectangle(723.1014, 1870.8555, 20));

		// 'Liepsna_Spreader' GenType 1028 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id30", "ep13_f_siauliai_1", Rectangle(960.7294, 1612.4421, 20));

		// 'Liepsna_Spreader' GenType 1029 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id31", "ep13_f_siauliai_1", Rectangle(130.46643, 1643.1395, 20));

		// 'Liepsna_Spreader' GenType 1030 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id32", "ep13_f_siauliai_1", Rectangle(265.80627, 1780.8611, 20));

		// 'Liepsna_Spreader' GenType 1031 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id33", "ep13_f_siauliai_1", Rectangle(50.688976, 1176.658, 20));

		// 'Liepsna_Spreader' GenType 1032 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id34", "ep13_f_siauliai_1", Rectangle(105.46303, 928.85175, 20));

		// 'Liepsna_Spreader' GenType 1033 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id35", "ep13_f_siauliai_1", Rectangle(335.40668, 1059.3456, 20));

		// 'Liepsna_Spreader' GenType 1034 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id36", "ep13_f_siauliai_1", Rectangle(107.42364, 1342.2222, 20));

		// 'Liepsna_Spreader' GenType 1035 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id37", "ep13_f_siauliai_1", Rectangle(-629.35126, 1348.1434, 20));

		// 'Liepsna_Spreader' GenType 1036 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id38", "ep13_f_siauliai_1", Rectangle(-460.68896, 1308.6558, 20));

		// 'Liepsna_Spreader' GenType 1037 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id39", "ep13_f_siauliai_1", Rectangle(-575.7602, 1464.2295, 20));

		// 'Liepsna_Spreader' GenType 1038 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id40", "ep13_f_siauliai_1", Rectangle(-428.94675, 1401.306, 20));

		// 'Liepsna_Spreader' GenType 1039 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id41", "ep13_f_siauliai_1", Rectangle(-1032.3534, 949.1313, 20));

		// 'Liepsna_Spreader' GenType 1040 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id42", "ep13_f_siauliai_1", Rectangle(-483.0673, 352.59567, 20));

		// 'Liepsna_Spreader' GenType 1041 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id43", "ep13_f_siauliai_1", Rectangle(-305.4939, 475.0126, 20));

		// 'Liepsna_Spreader' GenType 1042 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id44", "ep13_f_siauliai_1", Rectangle(-615.4685, 635.6584, 20));

		// 'Liepsna_Invader' GenType 1043 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-747.97, 803.2179, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-549.3344, 1482.5978, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-513.9815, 1248.8839, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-161.19495, 1526.2416, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-390.99612, 1442.5404, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-415.192, -355.55267, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-414.3567, -1728.4501, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-923.05774, -1509.5555, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-984.9229, -687.11414, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-947.99664, -897.3285, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-1499.0063, -1225.484, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(253.5404, 36.467087, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(535.70447, -295.41428, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(848.22015, -525.73083, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(564.75214, 1194.1833, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id45", "ep13_f_siauliai_1", Rectangle(-425.7349, 199.41095, 20));

		// 'Liepsna_Spreader' GenType 1044 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id46", "ep13_f_siauliai_1", Rectangle(-251.73038, 641.8928, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id46", "ep13_f_siauliai_1", Rectangle(1853.5072, 360.55936, 20));

		// 'Liepsna_Spreader' GenType 1045 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id47", "ep13_f_siauliai_1", Rectangle(-695.26697, 1873.3992, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id47", "ep13_f_siauliai_1", Rectangle(1751.344, 287.7245, 20));

		// 'Liepsna_Spreader' GenType 1046 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_1.Id48", "ep13_f_siauliai_1", Rectangle(-827.52057, 1876.4778, 20));
		AddSpawnPoint("ep13_f_siauliai_1.Id48", "ep13_f_siauliai_1", Rectangle(298.78775, -1362.5258, 20));
	}
}
