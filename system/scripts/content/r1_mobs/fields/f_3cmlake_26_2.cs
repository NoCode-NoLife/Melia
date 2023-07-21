//--- Melia Script -----------------------------------------------------------
// Lanko 22 Waters Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_3cmlake_26_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class F3Cmlake262MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_3cmlake_26_2.Id1", MonsterId.RootCrystal_A, 18, 23, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_26_2.Id2", MonsterId.Lakegolem, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_26_2.Id3", MonsterId.Pondus, 27, 36, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_26_2.Id4", MonsterId.Anchor_Golem, 13, 17, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_26_2.Id5", MonsterId.Lily_Belly, 33, 44, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_26_2.Id6", MonsterId.Jelly_Belly, 35, 46, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'RootCrystal_A' GenType 61 Spawn Points
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(765, 1451, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(594, 865, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(1224, 1092, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(383, 898, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(-222, 1104, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(-793, 1033, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(-1363, 1011, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(-1768, 1013, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(-238, 614, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(-313, -104, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(-297, -631, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(-285, -1196, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(-180, -1689, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(-553, -1775, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(248, -678, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(572, -866, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(999, -818, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(669, -244, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(646, 178, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(1425, -1104, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(1783, -743, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(1465, -347, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(1617, 62, 40));

		// 'Lakegolem' GenType 70 Spawn Points
		AddSpawnPoint("f_3cmlake_26_2.Id2", "f_3cmlake_26_2", Rectangle(677, 899, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id2", "f_3cmlake_26_2", Rectangle(-372, 49, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id2", "f_3cmlake_26_2", Rectangle(718, 38, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id2", "f_3cmlake_26_2", Rectangle(1390, -837, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id2", "f_3cmlake_26_2", Rectangle(1527, 52, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id2", "f_3cmlake_26_2", Rectangle(-336, -1634, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id2", "f_3cmlake_26_2", Rectangle(730, -808, 40));

		// 'Pondus' GenType 72 Spawn Points
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(466, 1035, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(525, 674, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(704, 748, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(961, 804, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(1290, 1127, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(1484, 893, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(1476, 1202, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-471, 162, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-433, -62, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-1577, 817, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-1678, 1092, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-1338, 864, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(859, 1091, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(491, 910, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(733, 1241, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(669, 1116, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(818, 869, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(184, 916, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(1026, 1103, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-250, 402, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-1039, 1053, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-674, 1024, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-1702, 901, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-1535, 1038, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-318, 609, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-1836, 791, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-1865, 1188, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-1276, 1196, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(827, 691, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(1151, 926, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(1415, 1021, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(1679, 1275, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(1320, 842, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-158, -63, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-598, -113, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-1884, 992, 20));

		// 'Anchor_Golem' GenType 73 Spawn Points
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(768, 1333, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(551, 781, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(757, 1002, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(1293, 964, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(1593, 1174, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-1514, 1153, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-1487, 905, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-508, 61, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-240, 213, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-167, -1466, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(157, -674, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-145, -1821, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-333, -736, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-498, -1772, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-286, -343, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-125, -710, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-183, -901, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-276, -1201, 20));

		// 'Lily_Belly' GenType 74 Spawn Points
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(563, -1003, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(740, -664, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(811, -904, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(515, 59, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(838, 169, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(927, -175, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1211, -809, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1429, -728, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1712, -1147, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1436, -998, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1591, -1256, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1028, -826, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1702, -985, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1363, -1109, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(692, -934, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(656, -388, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(425, -885, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1271, -1005, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1845, -1139, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1800, -868, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1472, -496, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1467, -273, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1301, -221, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1423, 67, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1320, 87, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1599, -181, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1612, -16, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1739, 3, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(541, -773, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(653, -145, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(942, 86, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(368, 87, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1193, -1090, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1939, -847, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1541, -880, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1695, -127, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1697, 139, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1548, -1113, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1331, -933, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1672, -779, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1382, -153, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(821, -1014, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1330, -26, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1562, 163, 40));

		// 'Jelly_Belly' GenType 75 Spawn Points
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-269, -1889, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-478, -1682, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-223, -1557, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-295, -214, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-102, -964, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-226, -705, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-297, -848, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(434, -705, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(712, -1054, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(652, -756, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(922, -57, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(700, 191, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(501, -184, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(467, -62, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(673, -496, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(571, -629, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-450, -1883, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-55, -1587, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-376, -1478, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-296, -1383, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-189, -1145, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-458, -856, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-59, -689, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-196, -584, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-391, -701, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-600, 130, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-502, -150, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-426, 281, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(54, -683, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(575, -24, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-185, 37, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-625, -9, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-338, 139, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-339, -570, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-532, -692, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-400, -950, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-193, -801, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-30, -1893, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(90, -1700, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-179, -1746, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-372, -1780, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-37, -801, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(450, 181, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(815, -151, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(807, -779, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(519, -888, 40));
	}
}
