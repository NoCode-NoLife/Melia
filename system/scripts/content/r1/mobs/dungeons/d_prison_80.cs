//--- Melia Script -----------------------------------------------------------
// Solitary Cells Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_prison_80'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DPrison80MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_prison_80", MonsterId.Defender_Spider_Blue, Properties("MHP", 424995, "MINPATK", 5966, "MAXPATK", 7234, "MINMATK", 5966, "MAXMATK", 7234, "DEF", 52724, "MDEF", 52724));
		AddPropertyOverrides("d_prison_80", MonsterId.Socket_Mage_Red, Properties("MHP", 427818, "MINPATK", 6002, "MAXPATK", 7279, "MINMATK", 6002, "MAXMATK", 7279, "DEF", 53624, "MDEF", 53624));
		AddPropertyOverrides("d_prison_80", MonsterId.NightMaiden_Bow_Red, Properties("MHP", 430718, "MINPATK", 6039, "MAXPATK", 7325, "MINMATK", 6039, "MAXMATK", 7325, "DEF", 54549, "MDEF", 54549));
		AddPropertyOverrides("d_prison_80", MonsterId.Boss_Grinender_Q1, Properties("MHP", 2211819, "MINPATK", 14586, "MAXPATK", 17692, "MINMATK", 14586, "MAXMATK", 17692, "DEF", 133191, "MDEF", 133191));

		// Monster Spawners ---------------------------------

		AddSpawner("d_prison_80.Id1", MonsterId.Defender_Spider_Blue, min: 30, max: 40, tendency: TendencyType.Aggressive);
		AddSpawner("d_prison_80.Id2", MonsterId.Socket_Mage_Red, min: 19, max: 25, tendency: TendencyType.Aggressive);
		AddSpawner("d_prison_80.Id3", MonsterId.NightMaiden_Bow_Red, min: 19, max: 25, tendency: TendencyType.Aggressive);
		AddSpawner("d_prison_80.Id4", MonsterId.Rootcrystal_05, min: 9, max: 12, respawn: TimeSpan.FromMilliseconds(60000), tendency: TendencyType.Peaceful);
		AddSpawner("d_prison_80.Id5", MonsterId.Defender_Spider_Blue, min: 6, max: 8, tendency: TendencyType.Aggressive);
		AddSpawner("d_prison_80.Id6", MonsterId.Socket_Mage_Red, min: 6, max: 8, tendency: TendencyType.Aggressive);
		AddSpawner("d_prison_80.Id7", MonsterId.NightMaiden_Bow_Red, min: 8, max: 10, tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Defender_Spider_Blue' GenType 1 Spawn Points
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(392, -319, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(216, -214, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(570, -791, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(559, -911, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(645, -731, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(788, -733, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(130, -412, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(327, -209, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(493, -1049, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(243, -1109, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(1020, -1849, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(780, -387, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(788, -1258, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(793, -1511, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-746, -348, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-627, -471, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-656, -251, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-905, -464, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-973, -270, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-1249, -364, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-1162, -222, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-1087, -48, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-982, 45, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-1007, 368, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-1102, 218, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-875, 191, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-107, -1, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(1086, 574, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(29, 60, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(889, 297, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(226, 174, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(981, 300, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(147, 352, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(336, 277, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(1178, 33, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-316, 991, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-172, 1130, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-39, 861, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(438, 300, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(230, 312, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(1227, 593, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(1408, 68, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(1007, 60, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(800, -499, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(860, -351, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(495, -295, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(248, -321, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(94, -259, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(167, -45, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(819, -1393, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(775, -1668, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(825, -1858, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-1263, -739, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-1278, -509, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-455, -176, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-503, -304, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-902, -116, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-108, 83, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-36, 49, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-670, 186, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-794, 378, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(-319, 1256, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(11, 1246, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(1315, 586, 25));
		AddSpawnPoint("d_prison_80.Id1", "d_prison_80", Rectangle(222, 57, 25));

		// 'Socket_Mage_Red' GenType 2 Spawn Points
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-40, -641, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(118, -72, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-165, -763, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(243, -383, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-254, -965, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-136, -988, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(117, -422, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-270, -829, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(218, -113, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(55, -902, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(1021, -843, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-255, -1058, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(839, -790, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(586, -727, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-291, -690, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-44, -757, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(117, -298, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(294, -39, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(36, -215, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(269, -240, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(399, -240, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(800, -328, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(799, -558, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(758, -771, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-114, -1090, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(68, -727, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(24, -1079, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(352, -326, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-179, -649, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(-30, -997, 25));
		AddSpawnPoint("d_prison_80.Id2", "d_prison_80", Rectangle(175, -214, 25));

		// 'NightMaiden_Bow_Red' GenType 3 Spawn Points
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(1027, 64, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(1055, 479, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(1379, 476, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(1139, 357, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(1049, 193, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(1403, 37, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(745, 295, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(655, 275, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(221, 404, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(712, 373, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(169, 239, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(172, 128, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(88, 179, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(20, 1116, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-43, -50, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-257, 1121, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-129, 1285, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-52, 951, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-218, 932, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-903, 248, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-173, -59, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-696, 115, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-667, 394, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-1100, 257, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-179, 36, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-973, 352, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-1206, 370, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-1216, 139, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-1183, -27, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(-943, 21, 25));
		AddSpawnPoint("d_prison_80.Id3", "d_prison_80", Rectangle(106, 82, 25));

		// 'Rootcrystal_05' GenType 6 Spawn Points
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(400, 313, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(925, -1843, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(801, -1521, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(791, -1251, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(699, -998, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(522, -1097, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(-686, -453, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(-12, -1078, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(-259, -732, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(-1174, -239, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(157, -377, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(684, 310, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(1186, 138, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(1173, 477, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(-45, 107, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(164, 294, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(-625, 271, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(-784, 352, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(-1038, -957, 100));
		AddSpawnPoint("d_prison_80.Id4", "d_prison_80", Rectangle(-26, 1093, 100));

		// 'Defender_Spider_Blue' GenType 32 Spawn Points
		AddSpawnPoint("d_prison_80.Id5", "d_prison_80", Rectangle(1210, 338, 25));
		AddSpawnPoint("d_prison_80.Id5", "d_prison_80", Rectangle(1062, 525, 25));
		AddSpawnPoint("d_prison_80.Id5", "d_prison_80", Rectangle(1043, 349, 25));
		AddSpawnPoint("d_prison_80.Id5", "d_prison_80", Rectangle(914, 290, 25));
		AddSpawnPoint("d_prison_80.Id5", "d_prison_80", Rectangle(1038, 182, 25));
		AddSpawnPoint("d_prison_80.Id5", "d_prison_80", Rectangle(1311, 465, 25));
		AddSpawnPoint("d_prison_80.Id5", "d_prison_80", Rectangle(1387, 271, 25));
		AddSpawnPoint("d_prison_80.Id5", "d_prison_80", Rectangle(1366, 112, 25));
		AddSpawnPoint("d_prison_80.Id5", "d_prison_80", Rectangle(1111, 6, 25));
		AddSpawnPoint("d_prison_80.Id5", "d_prison_80", Rectangle(1239, 600, 25));

		// 'Socket_Mage_Red' GenType 33 Spawn Points
		AddSpawnPoint("d_prison_80.Id6", "d_prison_80", Rectangle(-128, -975, 20));
		AddSpawnPoint("d_prison_80.Id6", "d_prison_80", Rectangle(-218, -839, 20));
		AddSpawnPoint("d_prison_80.Id6", "d_prison_80", Rectangle(-66, -701, 20));
		AddSpawnPoint("d_prison_80.Id6", "d_prison_80", Rectangle(17, -875, 20));
		AddSpawnPoint("d_prison_80.Id6", "d_prison_80", Rectangle(-78, -872, 20));
		AddSpawnPoint("d_prison_80.Id6", "d_prison_80", Rectangle(-1, -1067, 20));
		AddSpawnPoint("d_prison_80.Id6", "d_prison_80", Rectangle(59, -693, 20));
		AddSpawnPoint("d_prison_80.Id6", "d_prison_80", Rectangle(-271, -1028, 20));

		// 'NightMaiden_Bow_Red' GenType 34 Spawn Points
		AddSpawnPoint("d_prison_80.Id7", "d_prison_80", Rectangle(1061, 301, 25));
		AddSpawnPoint("d_prison_80.Id7", "d_prison_80", Rectangle(1214, 345, 25));
		AddSpawnPoint("d_prison_80.Id7", "d_prison_80", Rectangle(1191, 506, 25));
		AddSpawnPoint("d_prison_80.Id7", "d_prison_80", Rectangle(1073, 540, 25));
		AddSpawnPoint("d_prison_80.Id7", "d_prison_80", Rectangle(1306, 605, 25));
		AddSpawnPoint("d_prison_80.Id7", "d_prison_80", Rectangle(1285, 511, 25));
		AddSpawnPoint("d_prison_80.Id7", "d_prison_80", Rectangle(1365, 371, 25));
		AddSpawnPoint("d_prison_80.Id7", "d_prison_80", Rectangle(1363, 220, 25));
		AddSpawnPoint("d_prison_80.Id7", "d_prison_80", Rectangle(1332, 35, 25));
		AddSpawnPoint("d_prison_80.Id7", "d_prison_80", Rectangle(1036, 41, 25));
	}
}
