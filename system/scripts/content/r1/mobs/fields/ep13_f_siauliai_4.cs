//--- Melia Script -----------------------------------------------------------
// Issaugoti Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'ep13_f_siauliai_4'.
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
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(119, -985, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(251, -741, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(-281, -536, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(-590, -487, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(-755, -346, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(-647, -60, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(-770, 225, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(-357, 535, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(-262, 774, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(-90, 577, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(85, 815, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(82, 436, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(330, 841, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(294, 594, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(717, 618, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(995, 517, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(851, 312, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(728, 122, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(714, -106, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(530, -266, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(380, -129, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(160, 27, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(9, -109, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(-195, -287, 200));
		AddSpawnPoint("ep13_f_siauliai_4.Id1", "ep13_f_siauliai_4", Rectangle(137, -650, 200));

		// 'Saugumas_Guardion' GenType 1000 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id2", "ep13_f_siauliai_4", Rectangle(-648, -380, 20));

		// 'Saugumas_Guardion' GenType 1001 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id3", "ep13_f_siauliai_4", Rectangle(-658, 92, 20));

		// 'Saugumas_Guardion' GenType 1002 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id4", "ep13_f_siauliai_4", Rectangle(74, -182, 20));

		// 'Saugumas_Guardion' GenType 1003 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id5", "ep13_f_siauliai_4", Rectangle(589, -158, 20));

		// 'Saugumas_Guardion' GenType 1004 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id6", "ep13_f_siauliai_4", Rectangle(794, 528, 20));

		// 'Saugumas_Guardion' GenType 1005 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id7", "ep13_f_siauliai_4", Rectangle(324, 867, 20));

		// 'Saugumas_Guardion' GenType 1006 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id8", "ep13_f_siauliai_4", Rectangle(-171, 753, 20));

		// 'Saugumas_Guardion' GenType 1007 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id9", "ep13_f_siauliai_4", Rectangle(-270, 539, 20));

		// 'Saugumas_Guardion' GenType 1008 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id10", "ep13_f_siauliai_4", Rectangle(158, -44, 20));

		// 'Saugumas_Sentinel' GenType 1009 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-349, -471, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-563, -447, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-809, -327, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-518, -556, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-173, -341, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(160, -322, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-17, -71, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(77, 145, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(299, -25, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(522, -273, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(691, -131, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(736, 208, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(693, 387, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(802, 705, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(911, 600, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(459, 872, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(250, 444, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-495, 509, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-260, 790, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-198, 905, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-99, 924, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-81, 676, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-851, 266, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-791, 341, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-415, 177, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-474, -3, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-526, 138, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(423, -198, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(52, 476, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(68, 725, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(1015, 417, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(1095, 557, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(581, 637, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-673, -139, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-489, -269, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(887, 228, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-473, -400, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-805, 16, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(417, -325, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(373, 457, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(168, -161, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-214, -198, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-116, -157, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-493, -123, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-714, 207, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-418, 35, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-684, -468, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-153, 598, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(391, 790, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(244, 916, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(644, 752, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(892, 461, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(304, 543, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(255, 719, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(80, 915, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id11", "ep13_f_siauliai_4", Rectangle(-371, 447, 20));

		// 'Saugumas_Defender' GenType 1010 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-614, -556, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-279, -542, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-600, -292, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-835, 156, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-337, 121, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-568, -33, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-576, 259, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-270, 422, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-314, 692, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-90, 817, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(75, 309, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(235, 631, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(402, 572, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(1028, 536, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(728, 615, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(867, 351, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(688, 29, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(459, -126, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(302, -361, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-8, -278, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(308, -150, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(1037, 287, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(-314, -308, 20));
		AddSpawnPoint("ep13_f_siauliai_4.Id12", "ep13_f_siauliai_4", Rectangle(77, 37, 20));

		// 'Saugumas_Guardion' GenType 1011 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_4.Id13", "ep13_f_siauliai_4", Rectangle(783, 330, 20));
	}
}
