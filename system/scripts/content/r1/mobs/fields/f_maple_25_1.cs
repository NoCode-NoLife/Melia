//--- Melia Script -----------------------------------------------------------
// Nheto Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_maple_25_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FMaple251MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_maple_25_1", MonsterId.Rodenarcorng, Properties("MHP", 527238, "MINPATK", 7281, "MAXPATK", 8850, "MINMATK", 7281, "MAXMATK", 8850, "DEF", 91407, "MDEF", 91407));
		AddPropertyOverrides("f_maple_25_1", MonsterId.Rodenag, Properties("MHP", 528664, "MINPATK", 7299, "MAXPATK", 8872, "MINMATK", 7299, "MAXMATK", 8872, "DEF", 92112, "MDEF", 92112));
		AddPropertyOverrides("f_maple_25_1", MonsterId.Rodetad, Properties("MHP", 530281, "MINPATK", 7320, "MAXPATK", 8898, "MINMATK", 7320, "MAXMATK", 8898, "DEF", 92912, "MDEF", 92912));

		// Monster Spawners ---------------------------------

		AddSpawner("f_maple_25_1.Id1", MonsterId.Rodenarcorng, min: 27, max: 35);
		AddSpawner("f_maple_25_1.Id2", MonsterId.Rodenag, min: 15, max: 20);
		AddSpawner("f_maple_25_1.Id3", MonsterId.Rodetad, min: 23, max: 30);
		AddSpawner("f_maple_25_1.Id4", MonsterId.Rodenarcorng, min: 23, max: 30);
		AddSpawner("f_maple_25_1.Id5", MonsterId.Rootcrystal_05, min: 23, max: 30, respawn: TimeSpan.FromMilliseconds(30000));

		// Monster Spawn Points -----------------------------

		// 'Rodenarcorng' GenType 21 Spawn Points
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(203, 705, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(361, 402, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(267, 282, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(57, 300, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(127, 149, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(171, 368, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-67, 370, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-300, 365, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-410, 294, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-470, 148, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-500, -13, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-661, 194, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-847, 152, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-710, 281, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-425, 758, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-275, 823, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-240, 720, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-61, 843, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(60, 904, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(111, 997, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(134, 733, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(225, 874, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(310, 773, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(450, 794, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(556, 685, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(674, 816, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(793, 751, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(1143, 910, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(1215, 872, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(1270, 984, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(1427, 778, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(1440, 1029, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(2046, 1394, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(1882, 1551, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(2024, 1479, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(2183, 1461, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(2046, 1581, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(1556, 1682, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(1456, 1549, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(1335, 1645, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(1160, 1574, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(861, 1540, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(662, 1570, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(531, 1453, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(264, 1729, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(142, 1752, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(26, 1749, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-424, 1675, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-575, 1763, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-554, 1527, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-676, 1446, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-836, 1579, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-1261, 1641, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-1405, 1531, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-1511, 1696, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-1568, 1593, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-1494, 1384, 40));
		AddSpawnPoint("f_maple_25_1.Id1", "f_maple_25_1", Rectangle(-1797, 1565, 40));

		// 'Rodenag' GenType 25 Spawn Points
		AddSpawnPoint("f_maple_25_1.Id2", "f_maple_25_1", Rectangle(1180, 450, 40));
		AddSpawnPoint("f_maple_25_1.Id2", "f_maple_25_1", Rectangle(1452, 927, 40));
		AddSpawnPoint("f_maple_25_1.Id2", "f_maple_25_1", Rectangle(1260, 472, 40));
		AddSpawnPoint("f_maple_25_1.Id2", "f_maple_25_1", Rectangle(1350, 855, 40));
		AddSpawnPoint("f_maple_25_1.Id2", "f_maple_25_1", Rectangle(1481, 787, 40));
		AddSpawnPoint("f_maple_25_1.Id2", "f_maple_25_1", Rectangle(1534, 959, 40));
		AddSpawnPoint("f_maple_25_1.Id2", "f_maple_25_1", Rectangle(1395, 1013, 40));
		AddSpawnPoint("f_maple_25_1.Id2", "f_maple_25_1", Rectangle(231, 203, 40));
		AddSpawnPoint("f_maple_25_1.Id2", "f_maple_25_1", Rectangle(284, 357, 40));
		AddSpawnPoint("f_maple_25_1.Id2", "f_maple_25_1", Rectangle(-20, 395, 40));
		AddSpawnPoint("f_maple_25_1.Id2", "f_maple_25_1", Rectangle(854, 477, 40));
		AddSpawnPoint("f_maple_25_1.Id2", "f_maple_25_1", Rectangle(1042, 411, 40));
		AddSpawnPoint("f_maple_25_1.Id2", "f_maple_25_1", Rectangle(923, 354, 40));
		AddSpawnPoint("f_maple_25_1.Id2", "f_maple_25_1", Rectangle(604, 434, 40));
		AddSpawnPoint("f_maple_25_1.Id2", "f_maple_25_1", Rectangle(1224, 334, 40));
		AddSpawnPoint("f_maple_25_1.Id2", "f_maple_25_1", Rectangle(56, 334, 40));
		AddSpawnPoint("f_maple_25_1.Id2", "f_maple_25_1", Rectangle(24, 134, 40));
		AddSpawnPoint("f_maple_25_1.Id2", "f_maple_25_1", Rectangle(1221, 971, 40));
		AddSpawnPoint("f_maple_25_1.Id2", "f_maple_25_1", Rectangle(1332, 1054, 40));

		// 'Rodetad' GenType 26 Spawn Points
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-1114, 737, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-995, 643, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-900, 562, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-949, 928, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-888, 726, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-1716, 1357, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-1831, 1522, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-1448, 1411, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-1628, 1501, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-1451, 1570, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-1649, 1614, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-1345, 1693, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-1541, 1647, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-1561, 1342, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-1698, 793, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-1743, 638, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-1731, 490, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-1871, 549, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-1884, 691, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-1826, 856, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-2047, 868, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-2172, 766, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-1807, 712, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-1574, 738, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-1457, 799, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-873, 870, 35));
		AddSpawnPoint("f_maple_25_1.Id3", "f_maple_25_1", Rectangle(-729, 799, 35));

		// 'Rodenarcorng' GenType 27 Spawn Points
		AddSpawnPoint("f_maple_25_1.Id4", "f_maple_25_1", Rectangle(-859, 788, 9999));

		// 'Rootcrystal_05' GenType 28 Spawn Points
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(1436, 842, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(1022, 834, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(669, 748, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(340, 818, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(-8, 847, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(-242, 760, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(-506, 828, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(-874, 712, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(-1010, 931, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(-1044, 693, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(-1793, 566, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(-1955, 801, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(-1750, 874, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(-1748, 1475, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(-1471, 1285, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(-1380, 1609, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(-849, 1639, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(-689, 1375, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(-498, 1589, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(-551, 1826, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(194, 1790, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(429, 1604, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(708, 1475, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(1220, 1616, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(1530, 1612, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(1938, 1498, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(2104, 1593, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(1321, 362, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(871, 398, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(304, 264, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(58, 387, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(-343, 326, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(-551, 19, 15));
		AddSpawnPoint("f_maple_25_1.Id5", "f_maple_25_1", Rectangle(-813, 259, 15));
	}
}
