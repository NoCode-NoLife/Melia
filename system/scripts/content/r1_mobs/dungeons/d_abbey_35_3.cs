//--- Melia Script -----------------------------------------------------------
// Elgos Monastery Annex Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_abbey_35_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DAbbey353MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_abbey_35_3", MonsterId.Hohen_Mage_Red, Properties("MHP", 354468, "MINPATK", 5059, "MAXPATK", 6120, "MINMATK", 5059, "MAXMATK", 6120, "DEF", 32899, "MDEF", 32899));
		AddPropertyOverrides("d_abbey_35_3", MonsterId.Hohen_Ritter_Green, Properties("MHP", 359843, "MINPATK", 5128, "MAXPATK", 6205, "MINMATK", 5128, "MAXMATK", 6205, "DEF", 34227, "MDEF", 34227));
		AddPropertyOverrides("d_abbey_35_3", MonsterId.Hohen_Barkle_Green, Properties("MHP", 365565, "MINPATK", 5201, "MAXPATK", 6295, "MINMATK", 5201, "MAXMATK", 6295, "DEF", 35640, "MDEF", 35640));

		// Monster Spawners ---------------------------------

		AddSpawner("d_abbey_35_3.Id1", MonsterId.Hohen_Mage_Red, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_35_3.Id2", MonsterId.Hohen_Ritter_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_35_3.Id3", MonsterId.Hohen_Barkle_Green, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_35_3.Id4", MonsterId.Rootcrystal_01, 14, 18, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_abbey_35_3.Id5", MonsterId.Hohen_Ritter_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Hohen_Mage_Red' GenType 7 Spawn Points
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-102, -199, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-176, -405, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-7, -427, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-193, -230, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(39, -87, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(254, -287, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(157, -383, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-954, -271, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-941, -178, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-792, -492, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-730, -370, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-1396, -318, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-1440, -121, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-1352, -198, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-1393, -249, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-1383, -82, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-1345, 65, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-1017, 221, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-999, 349, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-845, 226, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-812, 318, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-675, 209, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-640, 340, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-977, 789, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-981, 664, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-1131, 274, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-331, 315, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-103, 310, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-34, 563, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(73, 636, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(30, 382, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-582, 1037, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-617, 501, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-622, 811, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(480, 627, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(27, 230, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(330, 570, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(520, 580, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(757, 486, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(817, 652, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(923, 517, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(940, 650, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(715, 1072, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(794, 1289, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(896, 1126, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(949, 1343, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(281, 1220, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(471, 1201, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(514, -246, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(728, -257, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(812, -387, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(853, -175, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(1001, -366, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(1008, -131, 25));
		AddSpawnPoint("d_abbey_35_3.Id1", "d_abbey_35_3", Rectangle(-240, -301, 25));

		// 'Hohen_Ritter_Green' GenType 8 Spawn Points
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(776, -278, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(839, -139, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(931, -327, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(966, -465, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(1034, -159, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-806, -399, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-866, -396, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-693, -337, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-858, -333, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-696, -461, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-1597, -293, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-1518, -221, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-1327, -313, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-1358, -127, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-1309, 0, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-2172, 168, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-2270, 308, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-2175, 462, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-2043, 509, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-1948, 293, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-2056, 372, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-1816, 445, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-927, 223, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-864, 315, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-708, 198, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-679, 307, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(81, 565, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(243, 593, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-681, 1129, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-545, 1088, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-618, 904, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(781, 558, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(851, 672, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(956, 614, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(897, 467, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(768, 1167, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(872, 1323, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(711, 1255, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(956, 1214, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(-65, 490, 25));
		AddSpawnPoint("d_abbey_35_3.Id2", "d_abbey_35_3", Rectangle(3, 309, 25));

		// 'Hohen_Barkle_Green' GenType 9 Spawn Points
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(-14, 535, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(17, 465, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(-4, 144, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(141, 748, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(780, 1188, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(910, 1224, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(781, 437, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(886, 542, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(764, 643, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(-1068, 729, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(-982, 829, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(-927, 717, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(-722, 299, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(-983, 273, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(-653, 160, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(-1966, 274, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(-2258, 270, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(-2156, 129, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(-2127, 445, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(-1305, -121, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(-1530, -301, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(-1321, -156, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(-1368, -16, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(-145, 477, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(-654, 1046, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(597, 1213, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(372, 1218, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(-111, 256, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(74, 281, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(-154, 389, 25));
		AddSpawnPoint("d_abbey_35_3.Id3", "d_abbey_35_3", Rectangle(131, 416, 25));

		// 'Rootcrystal_01' GenType 18 Spawn Points
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(770, 1143, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(417, 1222, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(-142, 591, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(103, 490, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(-12, 267, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(-96, -132, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(-161, -416, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(96, -345, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(729, -245, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(1027, -119, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(1032, -401, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(-626, 245, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(-926, 250, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(-1007, 761, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(-614, 1100, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(-635, 682, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(-885, -489, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(81, -511, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(-2089, 486, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(-2008, 250, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(-453, -262, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(-689, -438, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(-125, -1338, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(128, -1121, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(750, 644, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(928, 512, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(937, 1362, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(426, 578, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(-2221, 180, 100));
		AddSpawnPoint("d_abbey_35_3.Id4", "d_abbey_35_3", Rectangle(-930, -318, 100));

		// 'Hohen_Ritter_Green' GenType 19 Spawn Points
		AddSpawnPoint("d_abbey_35_3.Id5", "d_abbey_35_3", Rectangle(8, -24, 9999));
	}
}
