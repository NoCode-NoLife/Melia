//--- Melia Script -----------------------------------------------------------
// EP18 Kadumel Cliff Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'ep18_1_f_tableland_73'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Game.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep181FTableland73MobScript : GeneralScript
{
	protected override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep18_1_f_tableland_73", MonsterId.Ep18_1_Wendigo_Archer_Gray, Properties("MHP", 207536256, "MINPATK", 355000, "MAXPATK", 355000, "MINMATK", 355000, "MAXMATK", 355000, "DEF", 17090000, "MDEF", 17090000));
		AddPropertyOverrides("ep18_1_f_tableland_73", MonsterId.Ep18_1_Tiny_Bow_Blue, Properties("MHP", 207536256, "MINPATK", 355000, "MAXPATK", 355000, "MINMATK", 355000, "MAXMATK", 355000, "DEF", 17090000, "MDEF", 17090000));
		AddPropertyOverrides("ep18_1_f_tableland_73", MonsterId.Ep18_1_Hohen_Gulak_Blue, Properties("MHP", 207536256, "MINPATK", 355000, "MAXPATK", 355000, "MINMATK", 355000, "MAXMATK", 355000, "DEF", 17090000, "MDEF", 17090000));

		// Monster Spawners ---------------------------------

		AddSpawner("ep18_1_f_tableland_73.Id1", MonsterId.Ep18_1_Wendigo_Archer_Gray, min: 15, max: 20);
		AddSpawner("ep18_1_f_tableland_73.Id2", MonsterId.Ep18_1_Tiny_Bow_Blue, min: 45, max: 60);
		AddSpawner("ep18_1_f_tableland_73.Id3", MonsterId.Ep18_1_Hohen_Gulak_Blue, min: 8, max: 10);
		AddSpawner("ep18_1_f_tableland_73.Id4", MonsterId.Rootcrystal_03, min: 19, max: 25, respawn: Minutes(1));

		// Monster Spawn Points -----------------------------

		// 'Ep18_1_Wendigo_Archer_Gray' GenType 1 Spawn Points
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(1163, -182, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(928, -243, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(342, 13, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(-123, 153, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(-358, 578, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(-1407, -388, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(-1155, -288, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(-845, -208, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(-735, -664, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(-842, -987, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(-852, -1228, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(320, -1360, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(392, -1162, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(115, -1147, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(116, -731, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(41, -461, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(1445, 196, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(1277, 758, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(1005, 507, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(897, 783, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(738, 512, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(238, 706, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(327, 975, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(514, 946, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(150, 846, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(-606, 670, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(540, 251, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(243, 178, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(848, -90, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(1079, 53, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id1", "ep18_1_f_tableland_73", Rectangle(1376, 495, 30));

		// 'Ep18_1_Tiny_Bow_Blue' GenType 2 Spawn Points
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-93, -616, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(395, -158, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-83, 168, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-370, 462, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-296, 690, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-603, 643, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-948, -202, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-815, -490, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-700, -803, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-983, -1055, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-779, -1261, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-788, -871, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-1473, -461, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-1581, -216, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-1099, -312, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(371, 156, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(1143, 38, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(1392, 192, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(1265, 770, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(738, 626, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(738, 626, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(867, 1106, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(496, 926, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(324, 1046, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(204, 729, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(72, -420, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(239, -363, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-39, -168, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(256, -47, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(1203, 522, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(1057, 814, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(1248, 1046, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(1074, 1081, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(1179, 1275, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(1337, 1264, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(1222, 1165, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(1404, 1063, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(873, 461, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(974, 662, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(1002, -220, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(1340, -185, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(1320, -36, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(830, -172, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(1168, -264, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(1089, -113, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-738, -315, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-229, 367, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-488, -295, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(82, -600, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(153, -1018, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(151, -1197, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(187, -1314, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(396, -1321, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(315, -1192, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(244, -1054, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-956, -1261, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-833, -1180, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-1643, -384, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-1369, -323, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-1461, -320, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id2", "ep18_1_f_tableland_73", Rectangle(-851, -337, 30));

		// 'Ep18_1_Hohen_Gulak_Blue' GenType 3 Spawn Points
		AddSpawnPoint("ep18_1_f_tableland_73.Id3", "ep18_1_f_tableland_73", Rectangle(250, -1192, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id3", "ep18_1_f_tableland_73", Rectangle(143, -459, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id3", "ep18_1_f_tableland_73", Rectangle(-1500, -357, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id3", "ep18_1_f_tableland_73", Rectangle(-886, -1163, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id3", "ep18_1_f_tableland_73", Rectangle(-744, -328, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id3", "ep18_1_f_tableland_73", Rectangle(-354, 567, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id3", "ep18_1_f_tableland_73", Rectangle(1052, -233, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id3", "ep18_1_f_tableland_73", Rectangle(1207, 618, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id3", "ep18_1_f_tableland_73", Rectangle(293, 61, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id3", "ep18_1_f_tableland_73", Rectangle(-804, -890, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id3", "ep18_1_f_tableland_73", Rectangle(-823, -874, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id3", "ep18_1_f_tableland_73", Rectangle(-180, 299, 30));
		AddSpawnPoint("ep18_1_f_tableland_73.Id3", "ep18_1_f_tableland_73", Rectangle(297, 890, 30));

		// 'Rootcrystal_03' GenType 8 Spawn Points
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(1235, -1296, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(926, -1280, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(600, -1315, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(262, -1227, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(146, -782, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(168, -399, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(-151, -139, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(441, -176, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(307, 181, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(-496, -365, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(-896, -1191, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(-754, -928, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(-803, -457, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(-1065, -214, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(-1494, -301, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(-1515, -525, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(-124, 301, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(-357, 506, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(-533, 743, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(-98, 759, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(241, 711, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(417, 933, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(721, 982, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(1052, 1124, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(1358, 1423, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(1313, 1059, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(884, 480, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(915, -240, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(1278, -195, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(1320, 88, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(1399, 537, 40));
		AddSpawnPoint("ep18_1_f_tableland_73.Id4", "ep18_1_f_tableland_73", Rectangle(1204, 700, 40));
	}
}
