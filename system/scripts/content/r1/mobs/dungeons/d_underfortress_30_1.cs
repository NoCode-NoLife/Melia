//--- Melia Script -----------------------------------------------------------
// Ruklys Hall of Fame Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_underfortress_30_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DUnderfortress301MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_underfortress_30_1.Id1", MonsterId.Wendigo_Archer_Blue, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_30_1.Id2", MonsterId.Minos_Bow_Orange, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_30_1.Id3", MonsterId.Colifly_Yellow, 42, 55, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_30_1.Id4", MonsterId.Rootcrystal_05, 17, 22, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Wendigo_Archer_Blue' GenType 1 Spawn Points
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-1265, -657, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-1217, -322, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-1447, -836, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-1509, -676, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-689, -61, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-669, -200, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-747, -695, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-559, -708, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-565, -833, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-748, -873, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-606, -376, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-875, -28, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-789, -158, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-236, 101, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(40, 60, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-2, -247, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(17, -614, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(40, -888, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(279, -677, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(278, -861, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(581, -929, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(580, -724, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(835, -55, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(1050, -130, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(724, -199, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(667, -40, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(291, 44, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-13, 551, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(18, 840, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-912, 831, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-1350, 750, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-749, 684, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-578, 850, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-215, 862, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(23, 1218, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(-38, 1483, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(600, 543, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(806, 604, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(818, 475, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(694, 385, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(1598, 615, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(1784, 769, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(1467, 898, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(1550, 1088, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(1637, 1360, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(1394, 1164, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(1164, 1183, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(931, 1115, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(660, 1088, 30));
		AddSpawnPoint("d_underfortress_30_1.Id1", "d_underfortress_30_1", Rectangle(389, 1153, 30));

		// 'Minos_Bow_Orange' GenType 2 Spawn Points
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(727, 522, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(906, 583, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(773, 621, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(981, 654, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(1559, 1032, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(1596, 779, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(1097, 559, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(1114, 1137, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(858, 1139, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(527, 1154, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-19, 1314, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-25, 1071, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-9, 777, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-481, 885, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-927, 746, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-1275, 751, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-983, 905, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-570, 673, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-103, 812, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(601, 612, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-151, 373, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(0, 112, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-309, 71, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-643, -6, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(9, 48, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(383, 32, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(661, -4, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(778, -181, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(1086, -80, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(1037, 32, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(688, 78, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(700, 154, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(1453, 978, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(1581, 1479, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(142, -725, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(163, -905, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(485, -834, 30));
		AddSpawnPoint("d_underfortress_30_1.Id2", "d_underfortress_30_1", Rectangle(-6, -722, 30));

		// 'Colifly_Yellow' GenType 3 Spawn Points
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-1584, -798, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-1518, -984, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-1221, -917, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-1209, -650, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-1292, -276, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-1271, -48, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-832, 30, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-751, -182, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-807, -255, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-659, -648, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-607, -809, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-359, 81, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-63, 158, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-26, -58, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(51, -367, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(55, -653, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(51, -835, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(191, -952, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(453, -749, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(301, -690, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(58, -1013, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(598, -856, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(410, 60, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(728, 23, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(889, -8, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(999, -205, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1188, -39, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1229, 44, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1004, 9, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(721, 331, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1059, 593, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(542, 533, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(638, 629, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-50, 560, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(8, 881, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-74, 450, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-139, 225, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-338, 879, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-646, 794, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-1126, 822, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-1384, 698, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-746, 671, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-722, 805, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-8, 1194, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-53, 1624, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-73, 1605, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-73, 1605, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(-28, 1428, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(78, 872, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1561, 669, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1542, 927, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1587, 1155, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1383, 1091, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1481, 839, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1352, 613, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(1134, 1176, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(844, 1104, 30));
		AddSpawnPoint("d_underfortress_30_1.Id3", "d_underfortress_30_1", Rectangle(575, 1117, 30));

		// 'Rootcrystal_05' GenType 9 Spawn Points
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(642, -981, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-97, -767, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-30, 28, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(672, -54, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(1202, -108, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(1409, 149, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(547, 557, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(862, 642, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(1506, 700, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(1545, 1539, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(1364, 1016, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(833, 1058, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(458, 1096, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-128, 1589, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-30, 801, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-686, -160, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-606, -748, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-1348, -948, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-1117, -22, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-1533, -398, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-628, 775, 10));
		AddSpawnPoint("d_underfortress_30_1.Id4", "d_underfortress_30_1", Rectangle(-1296, 792, 10));
	}
}
