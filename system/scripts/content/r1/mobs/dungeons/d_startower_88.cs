//--- Melia Script -----------------------------------------------------------
// Astral Tower 1F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_startower_88'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DStartower88MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_startower_88", MonsterId.NightPanto_Stellar, Properties("MHP", 611624, "MINPATK", 8366, "MAXPATK", 10184, "MINMATK", 8366, "MAXMATK", 10184, "DEF", 134770, "MDEF", 134770));
		AddPropertyOverrides("d_startower_88", MonsterId.NightPanto_Archer, Properties("MHP", 613028, "MINPATK", 8384, "MAXPATK", 10206, "MINMATK", 8384, "MAXMATK", 10206, "DEF", 135611, "MDEF", 135611));
		AddPropertyOverrides("d_startower_88", MonsterId.NightPanto_Mage, Properties("MHP", 614471, "MINPATK", 8402, "MAXPATK", 10229, "MINMATK", 8402, "MAXMATK", 10229, "DEF", 136475, "MDEF", 136475));
		AddPropertyOverrides("d_startower_88", MonsterId.Mushuta, Properties("MHP", 615952, "MINPATK", 8421, "MAXPATK", 10252, "MINMATK", 8421, "MAXMATK", 10252, "DEF", 137363, "MDEF", 137363));

		// Monster Spawners ---------------------------------

		AddSpawner("d_startower_88.Id1", MonsterId.NightPanto_Stellar, min: 12, max: 15);
		AddSpawner("d_startower_88.Id2", MonsterId.NightPanto_Archer, min: 17, max: 22);
		AddSpawner("d_startower_88.Id3", MonsterId.NightPanto_Mage, min: 9, max: 11);
		AddSpawner("d_startower_88.Id4", MonsterId.NightPanto_Mage, min: 8, max: 10);
		AddSpawner("d_startower_88.Id5", MonsterId.Mushuta, min: 30, max: 39);
		AddSpawner("d_startower_88.Id6", MonsterId.Rootcrystal_02, min: 12, max: 16, respawn: TimeSpan.FromMilliseconds(10000));
		AddSpawner("d_startower_88.Id7", MonsterId.Mushuta, min: 30, max: 40, respawn: TimeSpan.FromMilliseconds(25000));

		// Monster Spawn Points -----------------------------

		// 'NightPanto_Stellar' GenType 25 Spawn Points
		AddSpawnPoint("d_startower_88.Id1", "d_startower_88", Rectangle(-96, 60, 25));
		AddSpawnPoint("d_startower_88.Id1", "d_startower_88", Rectangle(-126, -152, 25));
		AddSpawnPoint("d_startower_88.Id1", "d_startower_88", Rectangle(-116, -435, 25));
		AddSpawnPoint("d_startower_88.Id1", "d_startower_88", Rectangle(367, -479, 25));
		AddSpawnPoint("d_startower_88.Id1", "d_startower_88", Rectangle(389, -286, 25));
		AddSpawnPoint("d_startower_88.Id1", "d_startower_88", Rectangle(400, 30, 25));
		AddSpawnPoint("d_startower_88.Id1", "d_startower_88", Rectangle(250, -375, 25));
		AddSpawnPoint("d_startower_88.Id1", "d_startower_88", Rectangle(60, -55, 25));
		AddSpawnPoint("d_startower_88.Id1", "d_startower_88", Rectangle(145, 251, 25));
		AddSpawnPoint("d_startower_88.Id1", "d_startower_88", Rectangle(-108, 280, 25));
		AddSpawnPoint("d_startower_88.Id1", "d_startower_88", Rectangle(-188, 653, 25));
		AddSpawnPoint("d_startower_88.Id1", "d_startower_88", Rectangle(150, 641, 25));
		AddSpawnPoint("d_startower_88.Id1", "d_startower_88", Rectangle(-94, 496, 25));
		AddSpawnPoint("d_startower_88.Id1", "d_startower_88", Rectangle(-174, 895, 25));
		AddSpawnPoint("d_startower_88.Id1", "d_startower_88", Rectangle(154, 114, 25));

		// 'NightPanto_Archer' GenType 27 Spawn Points
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(-366, 2511, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(-454, 2698, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(-408, 2889, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(-304, 2671, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(-125, 2898, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(-31, 2698, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(-138, 2598, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(109, 2778, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(103, 2553, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(-26, 2358, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(-314, 2295, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(-163, 2128, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(-173, 1881, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(-197, 1648, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(247, 2489, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(394, 2700, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(489, 2495, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(641, 2617, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(1021, 2515, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(936, 3051, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(1118, 2824, 25));
		AddSpawnPoint("d_startower_88.Id2", "d_startower_88", Rectangle(1264, 3120, 25));

		// 'NightPanto_Mage' GenType 28 Spawn Points
		AddSpawnPoint("d_startower_88.Id3", "d_startower_88", Rectangle(1640, 1086, 25));
		AddSpawnPoint("d_startower_88.Id3", "d_startower_88", Rectangle(1515, 1089, 25));
		AddSpawnPoint("d_startower_88.Id3", "d_startower_88", Rectangle(1335, 1084, 25));
		AddSpawnPoint("d_startower_88.Id3", "d_startower_88", Rectangle(1373, 1214, 25));
		AddSpawnPoint("d_startower_88.Id3", "d_startower_88", Rectangle(1498, 1215, 25));
		AddSpawnPoint("d_startower_88.Id3", "d_startower_88", Rectangle(1666, 1234, 25));
		AddSpawnPoint("d_startower_88.Id3", "d_startower_88", Rectangle(1079, 1233, 25));
		AddSpawnPoint("d_startower_88.Id3", "d_startower_88", Rectangle(862, 1258, 25));
		AddSpawnPoint("d_startower_88.Id3", "d_startower_88", Rectangle(789, 1088, 25));
		AddSpawnPoint("d_startower_88.Id3", "d_startower_88", Rectangle(686, 1210, 25));
		AddSpawnPoint("d_startower_88.Id3", "d_startower_88", Rectangle(468, 1230, 25));

		// 'NightPanto_Mage' GenType 29 Spawn Points
		AddSpawnPoint("d_startower_88.Id4", "d_startower_88", Rectangle(983, 3244, 25));
		AddSpawnPoint("d_startower_88.Id4", "d_startower_88", Rectangle(799, 3010, 25));
		AddSpawnPoint("d_startower_88.Id4", "d_startower_88", Rectangle(1014, 2782, 25));
		AddSpawnPoint("d_startower_88.Id4", "d_startower_88", Rectangle(1013, 2650, 25));
		AddSpawnPoint("d_startower_88.Id4", "d_startower_88", Rectangle(1331, 2894, 25));
		AddSpawnPoint("d_startower_88.Id4", "d_startower_88", Rectangle(1080, 3082, 25));
		AddSpawnPoint("d_startower_88.Id4", "d_startower_88", Rectangle(1432, 3154, 25));
		AddSpawnPoint("d_startower_88.Id4", "d_startower_88", Rectangle(1332, 2669, 25));
		AddSpawnPoint("d_startower_88.Id4", "d_startower_88", Rectangle(1479, 2941, 25));

		// 'Mushuta' GenType 31 Spawn Points
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(1376, 1307, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(1566, 1330, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(1585, 1131, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(898, 1073, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(776, 1292, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(358, 1243, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(102, 542, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(49, 238, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(-181, 771, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(309, 36, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(250, -261, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(28, -506, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(-141, -234, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(-199, 45, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(258, -537, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(-176, 1768, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(-212, 2197, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(-144, 2331, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(195, 2346, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(43, 2494, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(86, 2667, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(-105, 2795, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(-391, 2785, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(-352, 2598, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(-113, 2517, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(271, 2615, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(456, 2574, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(676, 2690, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(1176, 2503, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(1605, 3049, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(1432, 2805, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(1175, 2627, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(841, 2889, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(1251, 2794, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(1343, 2977, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(914, 3197, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(1199, 3277, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(1456, 2643, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(1587, 2891, 25));
		AddSpawnPoint("d_startower_88.Id5", "d_startower_88", Rectangle(542, 2668, 25));

		// 'Rootcrystal_02' GenType 35 Spawn Points
		AddSpawnPoint("d_startower_88.Id6", "d_startower_88", Rectangle(1923, 1207, 200));
		AddSpawnPoint("d_startower_88.Id6", "d_startower_88", Rectangle(1422, 1216, 200));
		AddSpawnPoint("d_startower_88.Id6", "d_startower_88", Rectangle(847, 1231, 200));
		AddSpawnPoint("d_startower_88.Id6", "d_startower_88", Rectangle(417, 1242, 200));
		AddSpawnPoint("d_startower_88.Id6", "d_startower_88", Rectangle(-124, 769, 200));
		AddSpawnPoint("d_startower_88.Id6", "d_startower_88", Rectangle(31, 335, 200));
		AddSpawnPoint("d_startower_88.Id6", "d_startower_88", Rectangle(8, -348, 200));
		AddSpawnPoint("d_startower_88.Id6", "d_startower_88", Rectangle(344, 5, 200));
		AddSpawnPoint("d_startower_88.Id6", "d_startower_88", Rectangle(174, 176, 200));
		AddSpawnPoint("d_startower_88.Id6", "d_startower_88", Rectangle(-174, 1705, 200));
		AddSpawnPoint("d_startower_88.Id6", "d_startower_88", Rectangle(-277, 2259, 200));
		AddSpawnPoint("d_startower_88.Id6", "d_startower_88", Rectangle(255, 2649, 200));
		AddSpawnPoint("d_startower_88.Id6", "d_startower_88", Rectangle(-249, 2710, 200));
		AddSpawnPoint("d_startower_88.Id6", "d_startower_88", Rectangle(970, 2559, 200));
		AddSpawnPoint("d_startower_88.Id6", "d_startower_88", Rectangle(1086, 2731, 200));
		AddSpawnPoint("d_startower_88.Id6", "d_startower_88", Rectangle(1430, 3208, 200));

		// 'Mushuta' GenType 36 Spawn Points
		AddSpawnPoint("d_startower_88.Id7", "d_startower_88", Rectangle(-231, 2146, 300));
		AddSpawnPoint("d_startower_88.Id7", "d_startower_88", Rectangle(-221, 2701, 300));
		AddSpawnPoint("d_startower_88.Id7", "d_startower_88", Rectangle(-186, 1580, 300));
		AddSpawnPoint("d_startower_88.Id7", "d_startower_88", Rectangle(155, 2441, 300));
	}
}
