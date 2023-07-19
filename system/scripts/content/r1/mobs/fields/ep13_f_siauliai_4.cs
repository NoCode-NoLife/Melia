//--- Melia Script -----------------------------------------------------------
// ep13_f_siauliai_4
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Issaugoti Forest' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep13FSiauliai4MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep13_f_siauliai_4", MonsterId.Saugumas_Guardion, Properties("MHP", 955391, "MINPATK", 12786, "MAXPATK", 15617, "MINMATK", 12786, "MAXMATK", 15617, "DEF", 424741, "MDEF", 424741));
		AddPropertyOverrides("ep13_f_siauliai_4", MonsterId.Saugumas_Sentinel, Properties("MHP", 960657, "MINPATK", 12854, "MAXPATK", 15700, "MINMATK", 12854, "MAXMATK", 15700, "DEF", 430709, "MDEF", 430709));
		AddPropertyOverrides("ep13_f_siauliai_4", MonsterId.Saugumas_Defender, Properties("MHP", 966115, "MINPATK", 12924, "MAXPATK", 15787, "MINMATK", 12924, "MAXMATK", 15787, "DEF", 436895, "MDEF", 436895));
		AddPropertyOverrides("ep13_f_siauliai_4", MonsterId.Boss_Saugumas_Executor, Properties("MHP", 8609773, "MINPATK", 47567, "MAXPATK", 58105, "MINMATK", 47567, "MAXMATK", 58105, "DEF", 1622444, "MDEF", 1622444));

		// Monster Spawners ---------------------------------

		AddSpawner("ep13_f_siauliai_4.Id1", MonsterId.Rootcrystal_01, 19, 25, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_4.Id2", MonsterId.Saugumas_Guardion, 2, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_4.Id3", MonsterId.Saugumas_Guardion, 2, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_4.Id4", MonsterId.Saugumas_Guardion, 2, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_4.Id5", MonsterId.Saugumas_Guardion, 2, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_4.Id6", MonsterId.Saugumas_Guardion, 2, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_4.Id7", MonsterId.Saugumas_Guardion, 2, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_4.Id8", MonsterId.Saugumas_Guardion, 2, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_4.Id9", MonsterId.Saugumas_Guardion, 2, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_4.Id10", MonsterId.Saugumas_Guardion, 2, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_4.Id11", MonsterId.Saugumas_Sentinel, 68, 90, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_4.Id12", MonsterId.Saugumas_Defender, 27, 35, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_4.Id13", MonsterId.Saugumas_Guardion, 2, 2, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 11 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(119.85496, -985.5554, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(251.20537, -741.13873, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(-281.40894, -536.8426, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(-590.81805, -487.7263, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(-755.11395, -346.36282, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(-647.9477, -60.27737, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(-770.98956, 225.63498, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(-357.9393, 535.0342, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(-262.4229, 774.37976, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(-90.67547, 577.82367, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(85.10666, 815.4945, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(82.52938, 436.7697, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(330.7303, 841.8602, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(294.1412, 594.3959, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(717.9835, 618.8701, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(995.3725, 517.36774, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(851.06384, 312.1059, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(728.32513, 122.5665, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(714.2883, -106.89146, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(530.947, -266.93945, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(380.69727, -129.84381, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(160.51613, 27.99173, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(9.539738, -109.36925, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(-195.28552, -287.18823, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(137.18513, -650.55255, 200));

		// 'Saugumas_Guardion' GenType 1000 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id2", "ep13_f_siauliai_4", Rectangle(-648.5305, -380.65308, 20));

		// 'Saugumas_Guardion' GenType 1001 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id3", "ep13_f_siauliai_4", Rectangle(-658.82904, 92.39458, 20));

		// 'Saugumas_Guardion' GenType 1002 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id4", "ep13_f_siauliai_4", Rectangle(74.481285, -182.18466, 20));

		// 'Saugumas_Guardion' GenType 1003 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id5", "ep13_f_siauliai_4", Rectangle(589.3727, -158.13722, 20));

		// 'Saugumas_Guardion' GenType 1004 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id6", "ep13_f_siauliai_4", Rectangle(794.0802, 528.3684, 20));

		// 'Saugumas_Guardion' GenType 1005 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id7", "ep13_f_siauliai_4", Rectangle(324.55417, 867.0231, 20));

		// 'Saugumas_Guardion' GenType 1006 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id8", "ep13_f_siauliai_4", Rectangle(-171.13391, 753.0979, 20));

		// 'Saugumas_Guardion' GenType 1007 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id9", "ep13_f_siauliai_4", Rectangle(-270.13422, 539.79315, 20));

		// 'Saugumas_Guardion' GenType 1008 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id10", "ep13_f_siauliai_4", Rectangle(158.64891, -44.508636, 20));

		// 'Saugumas_Sentinel' GenType 1009 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-349.9322, -471.79053, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-563.9135, -447.53152, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-809.11066, -327.5369, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-518.834, -556.48975, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-173.58904, -341.48264, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(160.69806, -322.5891, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-17.818596, -71.83484, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(77.36954, 145.41876, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(299.1364, -25.879595, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(522.4997, -273.54944, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(691.9367, -131.43939, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(736.16956, 208.36101, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(693.2836, 387.35065, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(802.381, 705.703, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(911.39044, 600.8533, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(459.36053, 872.7356, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(250.79158, 444.12885, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-495.64365, 509.78052, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-260.78406, 790.9757, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-198.45206, 905.24524, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-99.715805, 924.71576, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-81.64494, 676.7748, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-851.466, 266.2031, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-791.2675, 341.13525, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-415.89243, 177.1126, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-474.4585, -3.9422693, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-526.8323, 138.61507, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(423.2359, -198.40561, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(52.177204, 476.53406, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(68.01436, 725.0887, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(1015.0443, 417.1549, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(1095.3604, 557.31384, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(581.6096, 637.6692, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-673.96985, -139.7485, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-489.74408, -269.1511, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(887.3599, 228.85107, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-473.1054, -400.7996, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-805.8764, 16.117912, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(417.926, -325.22208, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(373.17313, 457.29395, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(168.76564, -161.75656, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-214.09068, -198.17397, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-116.02521, -157.21155, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-493.8307, -123.21786, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-714.86975, 207.13335, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-418.51477, 35.774536, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-684.7001, -468.65137, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-153.31915, 598.6681, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(391.46353, 790.03076, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(244.01625, 916.5369, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(644.09265, 752.2861, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(892.35376, 461.5815, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(304.62408, 543.3687, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(255.64603, 719.0877, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(80.25458, 915.2505, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-371.53516, 447.81885, 20));

		// 'Saugumas_Defender' GenType 1010 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-614.53394, -556.9346, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-279.8188, -542.499, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-600.1554, -292.69858, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-835.9666, 156.69417, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-337.47903, 121.08392, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-568.9893, -33.594276, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-576.9669, 259.15506, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-270.9161, 422.66187, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-314.4788, 692.96484, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-90.74655, 817.56287, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(75.51579, 309.18347, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(235.99872, 631.77246, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(402.04706, 572.0211, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(1028.0062, 536.7006, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(728.00073, 615.2015, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(867.79456, 351.6511, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(688.78503, 29.417393, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(459.85934, -126.66427, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(302.16428, -361.08926, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-8.398495, -278.2628, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(308.9786, -150.3787, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(1037.8502, 287.03235, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-314.36066, -308.20483, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(77.189514, 37.241745, 20));

		// 'Saugumas_Guardion' GenType 1011 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id13", "ep13_f_siauliai_4", Rectangle(783.6974, 330.52255, 20));
	}
}
