//--- Melia Script -----------------------------------------------------------
// Royal Mausoleum 4F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_zachariel_35'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DZachariel35MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_zachariel_35", MonsterId.Dog_Of_King, Properties("MHP", 74539, "MINPATK", 1459, "MAXPATK", 1695, "MINMATK", 1459, "MAXMATK", 1695, "DEF", 542, "MDEF", 542));
		AddPropertyOverrides("d_zachariel_35", MonsterId.Schlesien_Guard, Properties("MHP", 75490, "MINPATK", 1472, "MAXPATK", 1710, "MINMATK", 1472, "MAXMATK", 1710, "DEF", 557, "MDEF", 557));
		AddPropertyOverrides("d_zachariel_35", MonsterId.Wolf_Statue_Bow, Properties("MHP", 76455, "MINPATK", 1484, "MAXPATK", 1726, "MINMATK", 1484, "MAXMATK", 1726, "DEF", 571, "MDEF", 571));
		AddPropertyOverrides("d_zachariel_35", MonsterId.Karas_Mage, Properties("MHP", 77433, "MINPATK", 1497, "MAXPATK", 1741, "MINMATK", 1497, "MAXMATK", 1741, "DEF", 586, "MDEF", 586));
		AddPropertyOverrides("d_zachariel_35", MonsterId.Shtayim, Properties("MHP", 78424, "MINPATK", 1509, "MAXPATK", 1757, "MINMATK", 1509, "MAXMATK", 1757, "DEF", 602, "MDEF", 602));
		AddPropertyOverrides("d_zachariel_35", MonsterId.Wolf_Statue, Properties("MHP", 79427, "MINPATK", 1522, "MAXPATK", 1773, "MINMATK", 1522, "MAXMATK", 1773, "DEF", 617, "MDEF", 617));
		AddPropertyOverrides("d_zachariel_35", MonsterId.Karas, Properties("MHP", 80444, "MINPATK", 1535, "MAXPATK", 1789, "MINMATK", 1535, "MAXMATK", 1789, "DEF", 632, "MDEF", 632));
		AddPropertyOverrides("d_zachariel_35", MonsterId.Boss_Bearkaras_Q2, Properties("MHP", 395956, "MINPATK", 3345, "MAXPATK", 3899, "MINMATK", 3345, "MAXMATK", 3899, "DEF", 1400, "MDEF", 1400));

		// Monster Spawners ---------------------------------

		AddSpawner("d_zachariel_35.Id1", MonsterId.Rootcrystal_05, 6, 8, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("d_zachariel_35.Id2", MonsterId.Dog_Of_King, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_35.Id3", MonsterId.Schlesien_Guard, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_35.Id4", MonsterId.Schlesien_Guard, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_35.Id5", MonsterId.Dog_Of_King, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_35.Id6", MonsterId.Schlesien_Guard, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_35.Id7", MonsterId.Dog_Of_King, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_35.Id8", MonsterId.Wolf_Statue_Bow, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_zachariel_35.Id9", MonsterId.Karas_Mage, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 600 Spawn Points
		AddSpawnPoint("d_zachariel_35.Id1", "d_zachariel_35", Rectangle(1059, -1508, 30));
		AddSpawnPoint("d_zachariel_35.Id1", "d_zachariel_35", Rectangle(1212, -118, 30));
		AddSpawnPoint("d_zachariel_35.Id1", "d_zachariel_35", Rectangle(1084, 1432, 30));
		AddSpawnPoint("d_zachariel_35.Id1", "d_zachariel_35", Rectangle(-56, -112, 30));
		AddSpawnPoint("d_zachariel_35.Id1", "d_zachariel_35", Rectangle(-669, 1159, 30));
		AddSpawnPoint("d_zachariel_35.Id1", "d_zachariel_35", Rectangle(-962, -1449, 30));
		AddSpawnPoint("d_zachariel_35.Id1", "d_zachariel_35", Rectangle(-1049, -50, 30));
		AddSpawnPoint("d_zachariel_35.Id1", "d_zachariel_35", Rectangle(496, 1507, 30));

		// 'Dog_Of_King' GenType 608 Spawn Points
		AddSpawnPoint("d_zachariel_35.Id2", "d_zachariel_35", Rectangle(1115, -54, 9999));

		// 'Schlesien_Guard' GenType 3006 Spawn Points
		AddSpawnPoint("d_zachariel_35.Id3", "d_zachariel_35", Rectangle(1142, 378, 9999));

		// 'Schlesien_Guard' GenType 3009 Spawn Points
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-1127, -5, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-382, 1073, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-456, -1514, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-706, -1387, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-710, -1164, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-39, 10, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-1043, 220, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-717, -37, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-632, 1109, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-409, 1220, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-826, 1535, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-1035, 639, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-21, -1609, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(37, -1459, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-196, -1636, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-933, -1484, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-974, -1159, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-1059, -792, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-1127, -149, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-1030, 1111, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-1007, 1435, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-461, 1518, 40));
		AddSpawnPoint("d_zachariel_35.Id4", "d_zachariel_35", Rectangle(-348, 842, 40));

		// 'Dog_Of_King' GenType 3010 Spawn Points
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(1202, -130, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(47, -23, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(-1078, -38, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(-88, -18, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(-714, 21, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(-1093, 142, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(-1232, -25, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(-1165, 79, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(-1099, -184, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(-766, -27, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(-512, 2, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(-4, -151, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(68, 61, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(204, -125, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(295, 13, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(703, -46, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(895, -46, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(1175, 8, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(1316, -29, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(1009, -127, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(1083, 49, 250));
		AddSpawnPoint("d_zachariel_35.Id5", "d_zachariel_35", Rectangle(1101, -35, 250));

		// 'Schlesien_Guard' GenType 3012 Spawn Points
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(949, -1220, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(815, -1013, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(799, -1209, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(915, -1500, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(1102, -1539, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(1175, -1372, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(727, -1579, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(1159, -856, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(900, -1104, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(1142, -567, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(1158, -234, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(449, -1569, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(1104, -1434, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(919, -1386, 30));
		AddSpawnPoint("d_zachariel_35.Id6", "d_zachariel_35", Rectangle(1028, -1027, 30));

		// 'Dog_Of_King' GenType 3016 Spawn Points
		AddSpawnPoint("d_zachariel_35.Id7", "d_zachariel_35", Rectangle(589, 1077, 300));
		AddSpawnPoint("d_zachariel_35.Id7", "d_zachariel_35", Rectangle(-504, 1076, 300));

		// 'Wolf_Statue_Bow' GenType 3021 Spawn Points
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-501, 1107, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-737, -1401, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-748, -1176, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-1084, 236, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(174, -93, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(1017, -51, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(1239, -43, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(95, 51, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(1073, 1386, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(550, 929, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(723, 1167, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-1082, -347, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-1067, 589, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-994, 1121, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-862, 1496, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(1184, 531, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-1040, -934, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(1201, -446, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(711, -54, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-690, -38, 30));
		AddSpawnPoint("d_zachariel_35.Id8", "d_zachariel_35", Rectangle(-1165, -30, 30));

		// 'Karas_Mage' GenType 3022 Spawn Points
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(-558, 1113, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(-378, 1045, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(19, -1562, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(-174, -1570, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(696, 965, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(788, 1210, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(-1089, -29, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(-801, -1456, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(-719, -1171, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(-1051, -734, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(-1035, 467, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(427, 1414, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(1001, 1483, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(1179, 950, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(1136, 382, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(651, -51, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(903, -60, 30));
		AddSpawnPoint("d_zachariel_35.Id9", "d_zachariel_35", Rectangle(-14, -70, 30));
	}
}
