//--- Melia Script -----------------------------------------------------------
// Demon Prison District 4 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_velniasprison_51_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DVelniasprison513MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_velniasprison_51_3", MonsterId.Hohen_Ritter, Properties("MHP", 206620, "MINPATK", 3158, "MAXPATK", 3783, "MINMATK", 3158, "MAXMATK", 3783, "DEF", 7937, "MDEF", 7937));
		AddPropertyOverrides("d_velniasprison_51_3", MonsterId.Hohen_Barkle, Properties("MHP", 208313, "MINPATK", 3180, "MAXPATK", 3809, "MINMATK", 3180, "MAXMATK", 3809, "DEF", 8091, "MDEF", 8091));
		AddPropertyOverrides("d_velniasprison_51_3", MonsterId.Hohen_Orben, Properties("MHP", 210031, "MINPATK", 3202, "MAXPATK", 3837, "MINMATK", 3202, "MAXMATK", 3837, "DEF", 8248, "MDEF", 8248));
		AddPropertyOverrides("d_velniasprison_51_3", MonsterId.Hohen_Mane, Properties("MHP", 211774, "MINPATK", 3224, "MAXPATK", 3864, "MINMATK", 3224, "MAXMATK", 3864, "DEF", 8407, "MDEF", 8407));
		AddPropertyOverrides("d_velniasprison_51_3", MonsterId.Boss_Hauberk, Properties("MHP", 1783065, "MINPATK", 10228, "MAXPATK", 12260, "MINMATK", 10228, "MAXMATK", 12260, "DEF", 26988, "MDEF", 26988));

		// Monster Spawners ---------------------------------

		AddSpawner("d_velniasprison_51_3.Id1", MonsterId.Hohen_Ritter, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_3.Id2", MonsterId.Hohen_Barkle, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_3.Id3", MonsterId.Rootcrystal_05, 14, 18, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_velniasprison_51_3.Id4", MonsterId.Hohen_Orben, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_3.Id5", MonsterId.Hohen_Mane, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_3.Id6", MonsterId.Hohen_Ritter, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Hohen_Ritter' GenType 7 Spawn Points
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(-2470, -1210, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(-2437, -368, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(-2544, -214, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(-2639, -313, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(-2548, -1051, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(-2654, -1206, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(-2862, -1182, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(-2320, -1148, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(-2514, 534, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(-2608, 300, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(-2139, 908, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(-1487, 929, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(-1324, 931, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(-256, 899, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(40, 903, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(301, 879, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(423, 797, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(474, 484, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(536, 442, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(1120, 345, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(1065, 292, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(929, 461, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(1710, 745, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(1731, -47, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(1692, -831, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(1583, -672, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(1783, -624, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(1906, -1122, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(1790, -1117, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(2293, -1012, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(2285, -269, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(2175, -299, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(2136, -89, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(2179, 396, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(2186, 372, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(1996, 326, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(2308, 874, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(2147, 910, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(2540, -630, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id1", "d_velniasprison_51_3", Rectangle(2306, -650, 40));

		// 'Hohen_Barkle' GenType 9 Spawn Points
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(1664, -659, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(2261, -175, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(2286, -331, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(1862, -1142, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(2137, -1135, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(2375, -1002, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(1713, -32, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(1701, 201, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(2503, 905, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(2792, 900, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(2113, 526, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(2113, 352, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(2335, 369, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(-717, 907, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(1198, 338, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(1012, 367, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(-798, 540, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(-1455, 359, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(559, 937, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(458, 898, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(11, 869, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(551, 476, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(315, 510, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(-1938, 939, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(-1658, 419, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(-573, 591, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(-729, 296, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(-2497, 874, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(-2452, 540, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(-2619, 344, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(-2420, 221, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(-1910, -226, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(-1910, -226, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(-1936, 256, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(-1910, -16, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(-1938, 585, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(-1272, 885, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(1707, -261, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(1773, 441, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(1692, 773, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(2277, 506, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(2118, -310, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(2060, -162, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(1679, -857, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(1947, -665, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(2259, -596, 40));
		AddSpawnPoint("d_velniasprison_51_3.Id2", "d_velniasprison_51_3", Rectangle(2153, -907, 40));

		// 'Rootcrystal_05' GenType 11 Spawn Points
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(-2533, -1134, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(-2692, -703, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(-2442, -288, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(-1906, -710, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(-1907, -162, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(-1904, 442, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(-1932, 952, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(-2519, 894, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(-2662, 303, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(-1391, 921, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(-1313, 365, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(-674, 910, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(-660, 450, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(37, 967, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(755, 923, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(1657, 951, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(484, 501, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(2046, 331, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(2257, 534, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(2123, -207, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(2222, -637, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(2280, -1005, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(1868, -1102, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(2903, -699, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(1735, -740, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(952, 421, 200));
		AddSpawnPoint("d_velniasprison_51_3.Id3", "d_velniasprison_51_3", Rectangle(1190, 299, 200));

		// 'Hohen_Orben' GenType 14 Spawn Points
		AddSpawnPoint("d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Rectangle(-2513, -652, 50));
		AddSpawnPoint("d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Rectangle(-2550, -1144, 50));
		AddSpawnPoint("d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Rectangle(-2936, -1176, 50));
		AddSpawnPoint("d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Rectangle(-2515, -335, 50));
		AddSpawnPoint("d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Rectangle(-3206, -698, 50));
		AddSpawnPoint("d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Rectangle(-1925, -710, 50));
		AddSpawnPoint("d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Rectangle(-2617, 250, 50));
		AddSpawnPoint("d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Rectangle(-1550, 315, 50));
		AddSpawnPoint("d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Rectangle(-1449, 474, 50));
		AddSpawnPoint("d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Rectangle(-2435, 323, 50));
		AddSpawnPoint("d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Rectangle(-2495, 790, 50));
		AddSpawnPoint("d_velniasprison_51_3.Id4", "d_velniasprison_51_3", Rectangle(-2715, 235, 50));

		// 'Hohen_Mane' GenType 15 Spawn Points
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-3230, -736, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-2568, -368, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-2477, 569, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-2537, 323, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-1902, -19, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(998, 284, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(2150, 409, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(1043, 566, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(498, 538, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-1540, 495, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-1923, 547, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-2546, -1169, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-2408, -254, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-1551, 270, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(2096, -229, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(2310, -228, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(2218, -371, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(1637, -793, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(1723, -618, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-2564, -1046, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-2370, -1076, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-2664, -220, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-2539, -625, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-2231, -679, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-1957, -748, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-1901, -844, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-1785, -733, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-1961, -470, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-1929, 341, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-2446, 764, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-2633, 437, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-2210, 875, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-1566, 914, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-1398, 407, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-1352, 269, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-749, 921, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-643, 696, 35));
		AddSpawnPoint("d_velniasprison_51_3.Id5", "d_velniasprison_51_3", Rectangle(-772, 414, 35));

		// 'Hohen_Ritter' GenType 16 Spawn Points
		AddSpawnPoint("d_velniasprison_51_3.Id6", "d_velniasprison_51_3", Rectangle(1696, 293, 9999));
	}
}
