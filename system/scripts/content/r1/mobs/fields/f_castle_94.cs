//--- Melia Script -----------------------------------------------------------
// Inner Wall District 10 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_castle_94'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle94MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_castle_94", MonsterId.Gland, Properties("MHP", 686342, "MINPATK", 9327, "MAXPATK", 11365, "MINMATK", 9327, "MAXMATK", 11365, "DEF", 181369, "MDEF", 181369));
		AddPropertyOverrides("f_castle_94", MonsterId.Grievous_Wheel, Properties("MHP", 688087, "MINPATK", 9349, "MAXPATK", 11393, "MINMATK", 9349, "MAXMATK", 11393, "DEF", 182617, "MDEF", 182617));
		AddPropertyOverrides("f_castle_94", MonsterId.Ghosnatus, Properties("MHP", 689892, "MINPATK", 9372, "MAXPATK", 11421, "MINMATK", 9372, "MAXMATK", 11421, "DEF", 183906, "MDEF", 183906));
		AddPropertyOverrides("f_castle_94", MonsterId.Boss_Velschariot_Q1, Properties("MHP", 3610953, "MINPATK", 23679, "MAXPATK", 28855, "MINMATK", 23679, "MAXMATK", 28855, "DEF", 466797, "MDEF", 466797));

		// Monster Spawners ---------------------------------

		AddSpawner("f_castle_94.Id1", MonsterId.Gland, 40, 53, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_94.Id2", MonsterId.Grievous_Wheel, 32, 42, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_94.Id3", MonsterId.Ghosnatus, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_94.Id4", MonsterId.Gland, 19, 25, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);
		AddSpawner("f_castle_94.Id5", MonsterId.Grievous_Wheel, 15, 20, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);
		AddSpawner("f_castle_94.Id6", MonsterId.Ghosnatus, 12, 15, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Gland' GenType 1 Spawn Points
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-756, -696, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-626, -664, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-721, -505, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-632, -485, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-639, -364, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-700, -243, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-525, -238, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-378, -178, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-213, -223, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-15, -192, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(444, -195, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(594, -251, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(829, -194, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(918, -243, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(1152, -249, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(1298, -315, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(1400, -187, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(1370, 1, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(1223, -19, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(1084, 15, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(1086, -330, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(1212, -436, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(467, 50, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(426, 74, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(468, 559, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(418, 655, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(488, 688, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(1045, 1025, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(1131, 983, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(1304, 877, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(1339, 832, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(1397, 931, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(1235, 1260, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(1341, 1191, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(650, 971, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(590, 1002, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(121, 1161, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(67, 1193, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(118, 1224, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(3, 864, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-223, 890, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-260, 962, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-504, 853, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-509, 1093, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-788, 832, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-870, 1074, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-709, 1058, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-582, 1347, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-464, 1294, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-495, 1561, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-436, 2789, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-617, 2855, 20));
		AddSpawnPoint("f_castle_94.Id1", "f_castle_94", Rectangle(-421, 3015, 20));

		// 'Grievous_Wheel' GenType 2 Spawn Points
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(-737, -355, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(-808, -249, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(-848, -499, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(-590, -159, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(104, -252, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(569, -174, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(295, 47, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(445, 304, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(291, 537, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(420, 763, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(1022, -433, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(1393, -426, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(1250, -139, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(1028, -159, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(1414, -83, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(756, 1025, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(930, 917, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(1030, 1222, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(1260, 1101, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(1440, 731, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(1460, 1181, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(204, 1208, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(87, 973, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(5, 1076, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(-76, 1249, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(-117, 821, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(-122, 1007, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(-261, 1236, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(-395, 824, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(-657, 820, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(-922, 855, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(-810, 983, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(-888, 1272, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(-719, 1233, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(-500, 2445, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(-644, 3031, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(-484, 2964, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(-364, 1118, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(-528, 991, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(283, 729, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(404, 362, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(952, 1085, 20));
		AddSpawnPoint("f_castle_94.Id2", "f_castle_94", Rectangle(403, 302, 20));

		// 'Ghosnatus' GenType 3 Spawn Points
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-795, 1822, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-638, 2044, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-781, 2198, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-508, 1856, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-393, 1997, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-47, 1943, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-218, 2065, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(230, 2355, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(198, 2683, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(271, 2883, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(591, 2583, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(431, 2901, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-555, 2776, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-707, 2776, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-725, 2956, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-582, 2951, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-477, 3161, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-679, 3141, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-265, 3081, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-292, 2905, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-309, 2729, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-451, 2340, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-513, 2630, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-1173, 933, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-1224, 1029, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-1137, 1179, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-1247, 1234, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-1337, 824, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-1315, 1131, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-410, 990, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(77, 1956, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(603, 2766, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-775, 3099, 20));
		AddSpawnPoint("f_castle_94.Id3", "f_castle_94", Rectangle(-541, 2201, 20));

		// 'Gland' GenType 4 Spawn Points
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(566, 2836, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(363, 2911, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(260, 2823, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(398, 2616, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(499, 2601, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(573, 2522, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(193, 2610, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(205, 2502, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(174, 2342, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(149, 2230, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(198, 1975, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(571, 2912, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(148, 2041, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(141, 2125, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(52, 2104, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(364, 2498, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(348, 2578, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(183, 2797, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(-10, 2169, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(-87, 2207, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(-133, 1995, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(-258, 1842, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(278, 2563, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(449, 2812, 20));
		AddSpawnPoint("f_castle_94.Id4", "f_castle_94", Rectangle(-511, 2013, 20));

		// 'Grievous_Wheel' GenType 5 Spawn Points
		AddSpawnPoint("f_castle_94.Id5", "f_castle_94", Rectangle(-113, 1907, 20));
		AddSpawnPoint("f_castle_94.Id5", "f_castle_94", Rectangle(-64, 2039, 20));
		AddSpawnPoint("f_castle_94.Id5", "f_castle_94", Rectangle(-195, 1834, 20));
		AddSpawnPoint("f_castle_94.Id5", "f_castle_94", Rectangle(-254, 1959, 20));
		AddSpawnPoint("f_castle_94.Id5", "f_castle_94", Rectangle(-159, 2138, 20));
		AddSpawnPoint("f_castle_94.Id5", "f_castle_94", Rectangle(-203, 2226, 20));
		AddSpawnPoint("f_castle_94.Id5", "f_castle_94", Rectangle(-322, 2217, 20));
		AddSpawnPoint("f_castle_94.Id5", "f_castle_94", Rectangle(-299, 2112, 20));
		AddSpawnPoint("f_castle_94.Id5", "f_castle_94", Rectangle(-417, 2055, 20));
		AddSpawnPoint("f_castle_94.Id5", "f_castle_94", Rectangle(-373, 1872, 20));
		AddSpawnPoint("f_castle_94.Id5", "f_castle_94", Rectangle(8, 1898, 20));
		AddSpawnPoint("f_castle_94.Id5", "f_castle_94", Rectangle(-694, 1992, 20));
		AddSpawnPoint("f_castle_94.Id5", "f_castle_94", Rectangle(-842, 1907, 20));
		AddSpawnPoint("f_castle_94.Id5", "f_castle_94", Rectangle(-849, 1995, 20));
		AddSpawnPoint("f_castle_94.Id5", "f_castle_94", Rectangle(-682, 2226, 20));
		AddSpawnPoint("f_castle_94.Id5", "f_castle_94", Rectangle(-965, 1841, 20));
		AddSpawnPoint("f_castle_94.Id5", "f_castle_94", Rectangle(-916, 1995, 20));
		AddSpawnPoint("f_castle_94.Id5", "f_castle_94", Rectangle(-991, 2072, 20));
		AddSpawnPoint("f_castle_94.Id5", "f_castle_94", Rectangle(-732, 2084, 20));
		AddSpawnPoint("f_castle_94.Id5", "f_castle_94", Rectangle(-757, 1912, 20));

		// 'Ghosnatus' GenType 6 Spawn Points
		AddSpawnPoint("f_castle_94.Id6", "f_castle_94", Rectangle(-904, 1816, 20));
		AddSpawnPoint("f_castle_94.Id6", "f_castle_94", Rectangle(-911, 2057, 20));
		AddSpawnPoint("f_castle_94.Id6", "f_castle_94", Rectangle(-686, 1803, 20));
		AddSpawnPoint("f_castle_94.Id6", "f_castle_94", Rectangle(-758, 1979, 20));
		AddSpawnPoint("f_castle_94.Id6", "f_castle_94", Rectangle(-703, 2131, 20));
		AddSpawnPoint("f_castle_94.Id6", "f_castle_94", Rectangle(-826, 2097, 20));
		AddSpawnPoint("f_castle_94.Id6", "f_castle_94", Rectangle(-845, 2226, 20));
		AddSpawnPoint("f_castle_94.Id6", "f_castle_94", Rectangle(-952, 2239, 20));
		AddSpawnPoint("f_castle_94.Id6", "f_castle_94", Rectangle(-633, 1962, 20));
		AddSpawnPoint("f_castle_94.Id6", "f_castle_94", Rectangle(-711, 1895, 20));
		AddSpawnPoint("f_castle_94.Id6", "f_castle_94", Rectangle(407, 2710, 20));
		AddSpawnPoint("f_castle_94.Id6", "f_castle_94", Rectangle(297, 2652, 20));
		AddSpawnPoint("f_castle_94.Id6", "f_castle_94", Rectangle(314, 2756, 20));
		AddSpawnPoint("f_castle_94.Id6", "f_castle_94", Rectangle(527, 2784, 20));
		AddSpawnPoint("f_castle_94.Id6", "f_castle_94", Rectangle(457, 2514, 20));
	}
}
