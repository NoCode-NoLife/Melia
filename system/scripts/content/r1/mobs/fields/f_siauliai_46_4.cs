//--- Melia Script -----------------------------------------------------------
// Dina Bee Farm Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_siauliai_46_4'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliai464MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_siauliai_46_4", MonsterId.Lantern_Mushroom_Orange, Properties("MHP", 223995, "MINPATK", 3381, "MAXPATK", 4057, "MINMATK", 3381, "MAXMATK", 4057, "DEF", 9733, "MDEF", 9733));
		AddPropertyOverrides("f_siauliai_46_4", MonsterId.Siaulamb, Properties("MHP", 225106, "MINPATK", 3396, "MAXPATK", 4075, "MINMATK", 3396, "MAXMATK", 4075, "DEF", 9882, "MDEF", 9882));
		AddPropertyOverrides("f_siauliai_46_4", MonsterId.Siaulogre, Properties("MHP", 226289, "MINPATK", 3411, "MAXPATK", 4093, "MINMATK", 3411, "MAXMATK", 4093, "DEF", 10040, "MDEF", 10040));
		AddPropertyOverrides("f_siauliai_46_4", MonsterId.Rabbee, Properties("MHP", 227540, "MINPATK", 3427, "MAXPATK", 4113, "MINMATK", 3427, "MAXMATK", 4113, "DEF", 10207, "MDEF", 10207));
		AddPropertyOverrides("f_siauliai_46_4", MonsterId.Honeybean, Properties("MHP", 228855, "MINPATK", 3444, "MAXPATK", 4134, "MINMATK", 3444, "MAXMATK", 4134, "DEF", 10383, "MDEF", 10383));
		AddPropertyOverrides("f_siauliai_46_4", MonsterId.Pendinmire, Properties("MHP", 230231, "MINPATK", 3462, "MAXPATK", 4156, "MINMATK", 3462, "MAXMATK", 4156, "DEF", 10566, "MDEF", 10566));
		AddPropertyOverrides("f_siauliai_46_4", MonsterId.Boss_Sparnas_Q1, Properties("MHP", 1181493, "MINPATK", 8352, "MAXPATK", 10028, "MINMATK", 8352, "MAXMATK", 10028, "DEF", 25819, "MDEF", 25819));
		AddPropertyOverrides("f_siauliai_46_4", MonsterId.Boss_BiteRegina_Q4, Properties("MHP", 1189096, "MINPATK", 8398, "MAXPATK", 10085, "MINMATK", 8398, "MAXMATK", 10085, "DEF", 26297, "MDEF", 26297));

		// Monster Spawners ---------------------------------

		AddSpawner("f_siauliai_46_4.Id1", MonsterId.Lantern_Mushroom_Orange, min: 8, max: 10);
		AddSpawner("f_siauliai_46_4.Id2", MonsterId.Lantern_Mushroom_Orange, min: 15, max: 20);
		AddSpawner("f_siauliai_46_4.Id3", MonsterId.Siaulamb, min: 15, max: 20);
		AddSpawner("f_siauliai_46_4.Id4", MonsterId.Siaulogre, min: 3, max: 4);
		AddSpawner("f_siauliai_46_4.Id5", MonsterId.Rabbee, min: 15, max: 20);
		AddSpawner("f_siauliai_46_4.Id6", MonsterId.Honeybean, min: 15, max: 20);
		AddSpawner("f_siauliai_46_4.Id7", MonsterId.Rabbee, min: 12, max: 15);
		AddSpawner("f_siauliai_46_4.Id8", MonsterId.Rootcrystal_01, min: 12, max: 16, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("f_siauliai_46_4.Id9", MonsterId.Pendinmire, amount: 1, respawn: TimeSpan.FromMilliseconds(3600000));
		AddSpawner("f_siauliai_46_4.Id10", MonsterId.Siaulamb, min: 12, max: 15);
		AddSpawner("f_siauliai_46_4.Id11", MonsterId.Rabbee, min: 15, max: 20);
		AddSpawner("f_siauliai_46_4.Id12", MonsterId.Honeybean, min: 15, max: 20);

		// Monster Spawn Points -----------------------------

		// 'Lantern_Mushroom_Orange' GenType 8 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id1", "f_siauliai_46_4", Rectangle(276, 2, 30));
		AddSpawnPoint("f_siauliai_46_4.Id1", "f_siauliai_46_4", Rectangle(456, -89, 30));
		AddSpawnPoint("f_siauliai_46_4.Id1", "f_siauliai_46_4", Rectangle(196, -92, 30));
		AddSpawnPoint("f_siauliai_46_4.Id1", "f_siauliai_46_4", Rectangle(216, -239, 30));
		AddSpawnPoint("f_siauliai_46_4.Id1", "f_siauliai_46_4", Rectangle(353, -342, 30));
		AddSpawnPoint("f_siauliai_46_4.Id1", "f_siauliai_46_4", Rectangle(473, -261, 30));
		AddSpawnPoint("f_siauliai_46_4.Id1", "f_siauliai_46_4", Rectangle(363, -158, 30));
		AddSpawnPoint("f_siauliai_46_4.Id1", "f_siauliai_46_4", Rectangle(592, -19, 30));

		// 'Lantern_Mushroom_Orange' GenType 21 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id2", "f_siauliai_46_4", Rectangle(439, 199, 9999));
		AddSpawnPoint("f_siauliai_46_4.Id2", "f_siauliai_46_4", Rectangle(343, -349, 9999));
		AddSpawnPoint("f_siauliai_46_4.Id2", "f_siauliai_46_4", Rectangle(343, -349, 9999));
		AddSpawnPoint("f_siauliai_46_4.Id2", "f_siauliai_46_4", Rectangle(-1151, 159, 9999));
		AddSpawnPoint("f_siauliai_46_4.Id2", "f_siauliai_46_4", Rectangle(187, -859, 9999));

		// 'Siaulamb' GenType 25 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-356, 360, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(1271, 1906, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-298, 152, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(662, 1669, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(448, 1753, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-269, 907, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-145, 773, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-360, 755, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(1207, 1609, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-548, 292, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(110, 306, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(634, 222, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(1060, 1615, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(420, 173, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-169, 242, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-394, 243, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(292, 280, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(148, -205, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(148, -205, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-971, 256, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-1020, 319, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-903, 294, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-1042, 78, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-974, 424, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-881, 389, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-813, 365, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-1177, 263, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-1107, 284, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-1004, 516, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-432, 295, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-408, 405, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-455, 125, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-376, 156, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-272, 260, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-224, 160, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-321, 215, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-198, 282, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-239, 736, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-210, 805, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-210, 876, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-317, 943, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-379, 828, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-285, 791, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-177, 705, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-95, 741, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-421, 752, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(-370, 900, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(213, 190, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(175, 65, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(69, -106, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(355, 380, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(335, 158, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(564, 321, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(489, 168, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(1173, 1683, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(577, 132, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(248, 396, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(409, 342, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(111, -4, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(286, 1426, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(173, 1475, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(287, 1616, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(352, 1524, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(188, 1600, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(373, 1661, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(559, 1765, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(927, 1627, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(504, 1605, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(655, 1757, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(1094, 1821, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(750, 1690, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(1286, 1807, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(1034, 1487, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(1001, 1744, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(283, -85, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(389, -59, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(552, -96, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(454, -214, 65));
		AddSpawnPoint("f_siauliai_46_4.Id3", "f_siauliai_46_4", Rectangle(305, -235, 65));

		// 'Siaulogre' GenType 27 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id4", "f_siauliai_46_4", Rectangle(428, 233, 4000));

		// 'Rabbee' GenType 28 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(294, -769, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(151, -925, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(427, -651, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(68, -936, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(103, -852, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(2, -968, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(259, -980, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(233, -1051, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(325, -1076, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(374, -1010, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(398, -943, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(308, -1003, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(295, -579, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(45, -809, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(66, -743, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(103, -666, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(152, -608, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(168, -697, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(245, -718, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(403, -545, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(260, -517, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(367, -694, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(457, -755, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(909, -836, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(907, -699, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1029, -604, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1251, -630, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1342, -778, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1373, -894, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1328, -1017, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1124, -1056, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1094, -1007, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1177, -992, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1124, -831, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1157, -701, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1327, -652, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1412, -959, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1309, -1054, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(965, -884, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(967, -812, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(830, -832, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(971, -663, 25));
		AddSpawnPoint("f_siauliai_46_4.Id5", "f_siauliai_46_4", Rectangle(1106, -582, 25));

		// 'Honeybean' GenType 29 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(429, -650, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(333, -860, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(215, -614, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(12, -879, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(115, -771, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(54, -1010, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(169, -996, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(271, -871, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(313, -925, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(365, -782, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(396, -849, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(333, -593, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(454, -720, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(232, -934, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(766, -776, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(791, -719, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(859, -792, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(931, -733, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1017, -725, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(950, -859, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1015, -816, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1065, -855, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1154, -898, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1127, -1023, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1157, -1079, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1233, -1025, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1220, -958, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1251, -908, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1293, -911, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1383, -929, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1196, -877, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1304, -836, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1186, -776, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(1170, -658, 25));
		AddSpawnPoint("f_siauliai_46_4.Id6", "f_siauliai_46_4", Rectangle(798, 148, 25));

		// 'Rabbee' GenType 30 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id7", "f_siauliai_46_4", Rectangle(916, -60, 9999));

		// 'Rootcrystal_01' GenType 31 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(927, -738, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(320, -936, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(-240, -1143, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(355, -146, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(1279, -259, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(-983, 288, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(-325, 225, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(-244, 800, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(196, 341, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(552, 227, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(1053, 213, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(248, 1580, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(1102, 1716, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(1360, 2698, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(1355, 2391, 150));
		AddSpawnPoint("f_siauliai_46_4.Id8", "f_siauliai_46_4", Rectangle(1325, -949, 150));

		// 'Pendinmire' GenType 33 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id9", "f_siauliai_46_4", Rectangle(220, 1433, 10));

		// 'Siaulamb' GenType 35 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id10", "f_siauliai_46_4", Rectangle(-1057, 193, 25));
		AddSpawnPoint("f_siauliai_46_4.Id10", "f_siauliai_46_4", Rectangle(-1129, 398, 25));
		AddSpawnPoint("f_siauliai_46_4.Id10", "f_siauliai_46_4", Rectangle(-1061, 436, 25));
		AddSpawnPoint("f_siauliai_46_4.Id10", "f_siauliai_46_4", Rectangle(-893, 471, 25));
		AddSpawnPoint("f_siauliai_46_4.Id10", "f_siauliai_46_4", Rectangle(-912, 190, 25));
		AddSpawnPoint("f_siauliai_46_4.Id10", "f_siauliai_46_4", Rectangle(-961, 118, 25));

		// 'Rabbee' GenType 36 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id11", "f_siauliai_46_4", Rectangle(834, -751, 25));
		AddSpawnPoint("f_siauliai_46_4.Id11", "f_siauliai_46_4", Rectangle(1050, -756, 25));
		AddSpawnPoint("f_siauliai_46_4.Id11", "f_siauliai_46_4", Rectangle(1137, -641, 25));
		AddSpawnPoint("f_siauliai_46_4.Id11", "f_siauliai_46_4", Rectangle(1219, -810, 25));
		AddSpawnPoint("f_siauliai_46_4.Id11", "f_siauliai_46_4", Rectangle(1120, -921, 25));
		AddSpawnPoint("f_siauliai_46_4.Id11", "f_siauliai_46_4", Rectangle(1293, -956, 25));
		AddSpawnPoint("f_siauliai_46_4.Id11", "f_siauliai_46_4", Rectangle(1201, -1046, 25));
		AddSpawnPoint("f_siauliai_46_4.Id11", "f_siauliai_46_4", Rectangle(1357, -846, 25));
		AddSpawnPoint("f_siauliai_46_4.Id11", "f_siauliai_46_4", Rectangle(1332, -719, 25));

		// 'Honeybean' GenType 37 Spawn Points
		AddSpawnPoint("f_siauliai_46_4.Id12", "f_siauliai_46_4", Rectangle(954, -753, 25));
		AddSpawnPoint("f_siauliai_46_4.Id12", "f_siauliai_46_4", Rectangle(1067, -660, 25));
		AddSpawnPoint("f_siauliai_46_4.Id12", "f_siauliai_46_4", Rectangle(1108, -781, 25));
		AddSpawnPoint("f_siauliai_46_4.Id12", "f_siauliai_46_4", Rectangle(1238, -694, 25));
		AddSpawnPoint("f_siauliai_46_4.Id12", "f_siauliai_46_4", Rectangle(1268, -824, 25));
		AddSpawnPoint("f_siauliai_46_4.Id12", "f_siauliai_46_4", Rectangle(1182, -920, 25));
		AddSpawnPoint("f_siauliai_46_4.Id12", "f_siauliai_46_4", Rectangle(1329, -960, 25));
		AddSpawnPoint("f_siauliai_46_4.Id12", "f_siauliai_46_4", Rectangle(1236, -1060, 25));
		AddSpawnPoint("f_siauliai_46_4.Id12", "f_siauliai_46_4", Rectangle(1394, -826, 25));
		AddSpawnPoint("f_siauliai_46_4.Id12", "f_siauliai_46_4", Rectangle(1370, -723, 25));
	}
}
