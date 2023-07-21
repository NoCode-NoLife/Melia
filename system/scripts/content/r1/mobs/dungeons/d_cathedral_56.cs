//--- Melia Script -----------------------------------------------------------
// Sanctuary Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_cathedral_56'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCathedral56MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_cathedral_56", MonsterId.Pawnd_Purple, Properties("MHP", 159308, "MINPATK", 2550, "MAXPATK", 3036, "MINMATK", 2550, "MAXMATK", 3036, "DEF", 3970, "MDEF", 3970));
		AddPropertyOverrides("d_cathedral_56", MonsterId.Pawndel_Blue, Properties("MHP", 161304, "MINPATK", 2576, "MAXPATK", 3067, "MINMATK", 2576, "MAXMATK", 3067, "DEF", 4085, "MDEF", 4085));
		AddPropertyOverrides("d_cathedral_56", MonsterId.NightMaiden_Bow, Properties("MHP", 163337, "MINPATK", 2602, "MAXPATK", 3099, "MINMATK", 2602, "MAXMATK", 3099, "DEF", 4203, "MDEF", 4203));
		AddPropertyOverrides("d_cathedral_56", MonsterId.Stoulet_Blue, Properties("MHP", 165407, "MINPATK", 2628, "MAXPATK", 3132, "MINMATK", 2628, "MAXMATK", 3132, "DEF", 4322, "MDEF", 4322));
		AddPropertyOverrides("d_cathedral_56", MonsterId.Boss_Naktis, Properties("MHP", 1398732, "MINPATK", 8365, "MAXPATK", 9970, "MINMATK", 8365, "MAXMATK", 9970, "DEF", 13997, "MDEF", 13997));

		// Monster Spawners ---------------------------------

		AddSpawner("d_cathedral_56.Id1", MonsterId.Pawnd_Purple, min: 8, max: 10, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_56.Id2", MonsterId.Pawndel_Blue, min: 38, max: 50, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_56.Id3", MonsterId.Rootcrystal_03, min: 19, max: 25, respawn: TimeSpan.FromMilliseconds(60000), tendency: TendencyType.Peaceful);
		AddSpawner("d_cathedral_56.Id4", MonsterId.Pawnd_Purple, min: 6, max: 8, tendency: TendencyType.Aggressive);
		AddSpawner("d_cathedral_56.Id5", MonsterId.NightMaiden_Bow, min: 6, max: 8, tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Pawnd_Purple' GenType 2 Spawn Points
		AddSpawnPoint("d_cathedral_56.Id1", "d_cathedral_56", Rectangle(-965, -50, 25));
		AddSpawnPoint("d_cathedral_56.Id1", "d_cathedral_56", Rectangle(-1599, -724, 25));
		AddSpawnPoint("d_cathedral_56.Id1", "d_cathedral_56", Rectangle(-1111, 96, 25));
		AddSpawnPoint("d_cathedral_56.Id1", "d_cathedral_56", Rectangle(-925, 143, 25));
		AddSpawnPoint("d_cathedral_56.Id1", "d_cathedral_56", Rectangle(-624, -46, 25));
		AddSpawnPoint("d_cathedral_56.Id1", "d_cathedral_56", Rectangle(-1504, 248, 25));
		AddSpawnPoint("d_cathedral_56.Id1", "d_cathedral_56", Rectangle(-256, -52, 25));
		AddSpawnPoint("d_cathedral_56.Id1", "d_cathedral_56", Rectangle(-1062, -307, 25));
		AddSpawnPoint("d_cathedral_56.Id1", "d_cathedral_56", Rectangle(-1632, -257, 25));
		AddSpawnPoint("d_cathedral_56.Id1", "d_cathedral_56", Rectangle(-1534, -275, 25));

		// 'Pawndel_Blue' GenType 4 Spawn Points
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-129, -139, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1029, -72, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(670, 212, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(508, 646, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1124, 893, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1425, 604, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(768, 927, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(141, -63, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-432, -96, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-542, -148, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(341, 192, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2092, -538, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2055, -495, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2107, -416, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2153, -483, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2142, -536, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2066, -431, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1877, -421, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1831, -373, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1790, -425, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1733, -480, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1713, -542, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1619, -552, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1521, -516, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1473, -549, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1412, -534, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1430, -440, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1437, -364, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1491, -465, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1572, -389, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1581, -479, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1642, -361, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1636, -432, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1757, -366, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1848, -537, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1862, -472, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2156, 137, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2108, 128, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2097, 79, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2122, 208, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2093, 254, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1899, 191, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1950, 301, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1865, 311, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1825, 406, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1955, 426, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1969, 102, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1900, 115, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1984, 154, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1902, 50, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1994, 44, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2043, 438, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1975, 504, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1866, 526, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1804, 464, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1760, 520, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1886, 606, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1987, 623, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2004, 553, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2070, 601, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2106, 513, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2137, 440, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2102, 357, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2150, 299, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2046, 377, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2017, 295, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1898, 402, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1903, 479, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(2161, 572, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1799, 287, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1719, 364, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1489, 382, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1514, 420, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1564, 405, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1586, 370, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1390, 455, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1437, 500, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1401, 544, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1353, 504, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1458, 610, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1412, 652, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1375, 616, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1446, 567, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1445, 784, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1415, 828, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1385, 749, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1366, 816, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1166, 899, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1130, 946, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1081, 912, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(1092, 865, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(873, 898, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(810, 942, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(733, 950, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(707, 912, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(756, 886, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(817, 887, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(509, 610, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(556, 656, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(523, 690, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(463, 641, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(754, 173, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(517, 261, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(407, 253, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(265, 142, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(188, 86, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(189, 17, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-31, -99, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(83, -157, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-195, -64, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(224, -408, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(171, -315, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-108, -47, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(175, -213, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-368, -124, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-289, -126, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-364, -51, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-478, -140, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-495, -55, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-587, -93, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-637, -133, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-753, -125, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-714, -74, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-972, -280, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-945, -190, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-885, -149, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1096, -267, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1088, -178, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1095, -48, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-998, 35, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1028, 151, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-881, 113, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-886, 216, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-972, 246, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1101, 219, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-898, 39, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1428, -716, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1439, -548, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1469, -474, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1582, -547, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1574, -479, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1427, -378, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1442, -227, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1609, -342, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1510, -609, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1523, -382, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1547, -159, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1552, -47, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1493, -92, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1541, 49, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1627, 123, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1602, 224, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1467, 81, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2038, -721, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2049, -576, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1968, -630, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2151, -551, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1954, -526, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2103, -421, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1963, -421, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2102, -310, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2098, -230, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1973, -296, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-1964, -175, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2133, -91, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2057, -179, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2310, 379, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2249, 355, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2200, 322, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2183, 359, 30));
		AddSpawnPoint("d_cathedral_56.Id2", "d_cathedral_56", Rectangle(-2141, 393, 30));

		// 'Rootcrystal_03' GenType 32 Spawn Points
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(1672, -469, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(2049, -538, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(1911, -84, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(1956, 445, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(1622, 386, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(1425, 632, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(1243, 893, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(746, 906, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(496, 671, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(757, 186, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(215, 89, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-120, -131, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-434, -111, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-1027, -43, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-926, -536, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-468, -635, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-207, -965, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-1282, -523, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-1541, -699, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-1837, -638, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-2084, -506, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-2057, -124, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-1503, -305, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-1567, -77, 10));
		AddSpawnPoint("d_cathedral_56.Id3", "d_cathedral_56", Rectangle(-1571, 171, 10));

		// 'Pawnd_Purple' GenType 33 Spawn Points
		AddSpawnPoint("d_cathedral_56.Id4", "d_cathedral_56", Rectangle(1703, -403, 30));
		AddSpawnPoint("d_cathedral_56.Id4", "d_cathedral_56", Rectangle(1766, 413, 30));
		AddSpawnPoint("d_cathedral_56.Id4", "d_cathedral_56", Rectangle(-2035, -484, 30));
		AddSpawnPoint("d_cathedral_56.Id4", "d_cathedral_56", Rectangle(-2291, 428, 30));
		AddSpawnPoint("d_cathedral_56.Id4", "d_cathedral_56", Rectangle(-2136, -742, 30));
		AddSpawnPoint("d_cathedral_56.Id4", "d_cathedral_56", Rectangle(-2166, -296, 30));
		AddSpawnPoint("d_cathedral_56.Id4", "d_cathedral_56", Rectangle(-2011, -97, 30));
		AddSpawnPoint("d_cathedral_56.Id4", "d_cathedral_56", Rectangle(-2027, -296, 30));
		AddSpawnPoint("d_cathedral_56.Id4", "d_cathedral_56", Rectangle(-2176, 436, 30));

		// 'NightMaiden_Bow' GenType 42 Spawn Points
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(1535, 378, 30));
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(1806, -499, 30));
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(1384, 496, 30));
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(1779, 574, 30));
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(1486, -378, 30));
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(1547, -578, 30));
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(1885, -369, 30));
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(1397, 787, 30));
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(820, 912, 30));
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(1874, 248, 30));
		AddSpawnPoint("d_cathedral_56.Id5", "d_cathedral_56", Rectangle(2138, 95, 30));
	}
}
