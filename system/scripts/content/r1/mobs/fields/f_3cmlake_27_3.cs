//--- Melia Script -----------------------------------------------------------
// Maven 32 Waters Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_3cmlake_27_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class F3Cmlake273MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_3cmlake_27_3", MonsterId.Frocoli, Properties("MHP", 675994, "MINPATK", 9194, "MAXPATK", 11201, "MINMATK", 9194, "MAXMATK", 11201, "DEF", 173974, "MDEF", 173974));
		AddPropertyOverrides("f_3cmlake_27_3", MonsterId.Infro_Crabil, Properties("MHP", 677249, "MINPATK", 9210, "MAXPATK", 11221, "MINMATK", 9210, "MAXMATK", 11221, "DEF", 174871, "MDEF", 174871));
		AddPropertyOverrides("f_3cmlake_27_3", MonsterId.Boss_Kurmis_3cmlake_27_3, Properties("MHP", 3542213, "MINPATK", 23252, "MAXPATK", 28331, "MINMATK", 23252, "MAXMATK", 28331, "DEF", 443081, "MDEF", 443081));

		// Monster Spawners ---------------------------------

		AddSpawner("f_3cmlake_27_3.Id1", MonsterId.Frocoli, 49, 65, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_27_3.Id2", MonsterId.Infro_Crabil, 62, 82, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_27_3.Id3", MonsterId.Frocoli, 21, 27, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_27_3.Id4", MonsterId.Rootcrystal_02, 15, 20, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Frocoli' GenType 1 Spawn Points
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1844, -790, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1649, -863, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1586, -820, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1476, -667, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1607, -757, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1534, -585, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1774, -717, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1835, -627, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1895, -682, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1719, -807, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1522, -715, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1797, 21, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1665, 14, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1696, 155, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1859, 174, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1930, 115, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1920, 398, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1689, 373, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1673, 499, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1423, 366, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1520, 76, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1354, 207, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1505, 278, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1791, 465, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1817, 1129, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1662, 1043, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1450, 1078, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1451, 1222, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1582, 1174, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1730, 1218, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1845, 1313, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1695, 1329, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1559, 1338, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1424, 1358, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-1321, 1233, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-64, 1238, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(18, 1197, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(177, 1238, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(76, 1376, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(31, 1304, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-40, 1336, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(-176, 1248, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(24, 1064, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(235, 1283, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(923, -131, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(850, -141, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(786, -400, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(944, -266, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(843, -339, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(949, -355, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(942, -199, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(695, -287, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(652, -372, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(709, -210, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(795, -214, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(1616, 399, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(1586, 508, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(1708, 577, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(1883, 539, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(1769, 363, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(1731, 449, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(1765, 226, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(2020, 327, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(1931, 427, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id1", "f_3cmlake_27_3", Rectangle(1942, 302, 20));

		// 'Infro_Crabil' GenType 2 Spawn Points
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(301, -292, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(137, -364, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(28, -413, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(233, -335, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(93, -495, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(191, -200, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(133, -265, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(207, -505, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-84, -350, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-52, -458, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(721, 512, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(791, 632, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(867, 507, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1086, 614, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1025, 474, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(948, 656, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1105, -242, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1120, -311, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1121, 486, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(942, -528, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(978, -507, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1603, -935, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1643, -847, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1667, -331, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1740, -595, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1801, -807, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1853, -857, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1914, -508, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1817, -571, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1587, -304, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1868, -430, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1995, -488, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(2032, -755, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(2089, -815, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(2004, -827, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1876, -765, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1571, -389, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-249, 498, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-254, 350, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-44, 256, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-84, 397, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-148, 380, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-126, 581, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-164, 684, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(36, 699, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(63, 516, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(365, 606, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(301, 488, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(215, 318, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(221, 609, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-921, 310, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-893, 168, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-776, 160, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-669, 204, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-655, 340, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-768, 351, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-822, 425, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-986, 291, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-907, -322, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-904, -439, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-654, -516, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-603, -342, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-714, -291, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-738, -410, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-794, -556, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-800, -219, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-1006, -349, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-1662, -790, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-1688, -516, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1472, -764, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1406, -490, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1371, -566, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1460, -562, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-1824, -704, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1647, -656, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1585, -611, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1446, -842, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1407, -741, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1575, -682, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1054, -295, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1741, -522, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(1689, -935, 25));
		AddSpawnPoint("f_3cmlake_27_3.Id2", "f_3cmlake_27_3", Rectangle(-1542, -647, 25));

		// 'Frocoli' GenType 3 Spawn Points
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-826, 265, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-911, 405, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-969, 390, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-939, 242, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-722, 259, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-720, 415, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-773, 476, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-793, -309, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-801, -448, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-581, -452, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-665, -405, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-686, -193, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-916, -212, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-747, -100, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-520, -388, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-133, 484, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-52, 509, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(112, 446, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(103, 294, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(209, 403, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(97, 605, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-25, 621, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(91, 783, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(200, 722, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-269, 622, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-344, 455, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(-172, 269, 20));
		AddSpawnPoint("f_3cmlake_27_3.Id3", "f_3cmlake_27_3", Rectangle(357, 419, 20));

		// 'Rootcrystal_02' GenType 17 Spawn Points
		AddSpawnPoint("f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Rectangle(33, -1291, 200));
		AddSpawnPoint("f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Rectangle(49, -861, 200));
		AddSpawnPoint("f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Rectangle(211, -442, 200));
		AddSpawnPoint("f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Rectangle(850, -263, 200));
		AddSpawnPoint("f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Rectangle(1391, -809, 200));
		AddSpawnPoint("f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Rectangle(1953, -740, 200));
		AddSpawnPoint("f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Rectangle(874, 294, 200));
		AddSpawnPoint("f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Rectangle(1204, 555, 200));
		AddSpawnPoint("f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Rectangle(1732, 455, 200));
		AddSpawnPoint("f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Rectangle(342, 515, 200));
		AddSpawnPoint("f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Rectangle(-112, 512, 200));
		AddSpawnPoint("f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Rectangle(29, 1207, 200));
		AddSpawnPoint("f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Rectangle(-200, -342, 200));
		AddSpawnPoint("f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Rectangle(-1431, 396, 200));
		AddSpawnPoint("f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Rectangle(-1654, -579, 200));
		AddSpawnPoint("f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Rectangle(-1593, 1073, 200));
		AddSpawnPoint("f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Rectangle(-710, -330, 200));
		AddSpawnPoint("f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Rectangle(-1682, 23, 200));
		AddSpawnPoint("f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Rectangle(-751, 280, 200));
		AddSpawnPoint("f_3cmlake_27_3.Id4", "f_3cmlake_27_3", Rectangle(1665, -409, 200));
	}
}
