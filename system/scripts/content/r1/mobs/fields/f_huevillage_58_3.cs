//--- Melia Script -----------------------------------------------------------
// Cobalt Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_huevillage_58_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FHuevillage583MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_huevillage_58_3", MonsterId.Caro, Properties("MHP", 30545, "MINPATK", 894, "MAXPATK", 1000, "MINMATK", 894, "MAXMATK", 1000, "DEF", 172, "MDEF", 172));
		AddPropertyOverrides("f_huevillage_58_3", MonsterId.Upent, Properties("MHP", 31061, "MINPATK", 900, "MAXPATK", 1009, "MINMATK", 900, "MAXMATK", 1009, "DEF", 173, "MDEF", 173));
		AddPropertyOverrides("f_huevillage_58_3", MonsterId.Tiny_Bow, Properties("MHP", 31598, "MINPATK", 907, "MAXPATK", 1017, "MINMATK", 907, "MAXMATK", 1017, "DEF", 174, "MDEF", 174));
		AddPropertyOverrides("f_huevillage_58_3", MonsterId.Boss_Colimencia, Properties("MHP", 152424, "MINPATK", 1865, "MAXPATK", 2093, "MINMATK", 1865, "MAXMATK", 2093, "DEF", 357, "MDEF", 357));
		AddPropertyOverrides("f_huevillage_58_3", MonsterId.Banshee_Pink, Properties("MHP", 32736, "MINPATK", 922, "MAXPATK", 1035, "MINMATK", 922, "MAXMATK", 1035, "DEF", 176, "MDEF", 176));

		// Monster Spawners ---------------------------------

		AddSpawner("f_huevillage_58_3.Id1", MonsterId.Caro, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_3.Id2", MonsterId.Upent, 2, 2, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_3.Id3", MonsterId.Caro, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_3.Id4", MonsterId.Rootcrystal_01, 9, 12, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_3.Id5", MonsterId.Caro, 45, 60, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_huevillage_58_3.Id6", MonsterId.Tiny_Bow, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Caro' GenType 23 Spawn Points
		AddSpawnPoint("f_huevillage_58_3.Id1", "f_huevillage_58_3", Rectangle(1106, -482, 35));
		AddSpawnPoint("f_huevillage_58_3.Id1", "f_huevillage_58_3", Rectangle(1119, -1005, 35));
		AddSpawnPoint("f_huevillage_58_3.Id1", "f_huevillage_58_3", Rectangle(1148, -341, 35));
		AddSpawnPoint("f_huevillage_58_3.Id1", "f_huevillage_58_3", Rectangle(1024, -862, 35));
		AddSpawnPoint("f_huevillage_58_3.Id1", "f_huevillage_58_3", Rectangle(-967, -439, 35));
		AddSpawnPoint("f_huevillage_58_3.Id1", "f_huevillage_58_3", Rectangle(-298, -410, 35));
		AddSpawnPoint("f_huevillage_58_3.Id1", "f_huevillage_58_3", Rectangle(-983, -585, 35));
		AddSpawnPoint("f_huevillage_58_3.Id1", "f_huevillage_58_3", Rectangle(-961, -247, 35));
		AddSpawnPoint("f_huevillage_58_3.Id1", "f_huevillage_58_3", Rectangle(-455, -746, 35));
		AddSpawnPoint("f_huevillage_58_3.Id1", "f_huevillage_58_3", Rectangle(-506, -479, 35));
		AddSpawnPoint("f_huevillage_58_3.Id1", "f_huevillage_58_3", Rectangle(1054, -226, 35));
		AddSpawnPoint("f_huevillage_58_3.Id1", "f_huevillage_58_3", Rectangle(965, -395, 35));
		AddSpawnPoint("f_huevillage_58_3.Id1", "f_huevillage_58_3", Rectangle(1257, -975, 35));
		AddSpawnPoint("f_huevillage_58_3.Id1", "f_huevillage_58_3", Rectangle(983, -1046, 35));

		// 'Upent' GenType 24 Spawn Points
		AddSpawnPoint("f_huevillage_58_3.Id2", "f_huevillage_58_3", Rectangle(1090, -340, 150));
		AddSpawnPoint("f_huevillage_58_3.Id2", "f_huevillage_58_3", Rectangle(1119, -1005, 150));

		// 'Caro' GenType 26 Spawn Points
		AddSpawnPoint("f_huevillage_58_3.Id3", "f_huevillage_58_3", Rectangle(-975, -749, 9999));

		// 'Rootcrystal_01' GenType 32 Spawn Points
		AddSpawnPoint("f_huevillage_58_3.Id4", "f_huevillage_58_3", Rectangle(235, -1400, 200));
		AddSpawnPoint("f_huevillage_58_3.Id4", "f_huevillage_58_3", Rectangle(939, -975, 200));
		AddSpawnPoint("f_huevillage_58_3.Id4", "f_huevillage_58_3", Rectangle(258, -955, 200));
		AddSpawnPoint("f_huevillage_58_3.Id4", "f_huevillage_58_3", Rectangle(-1262, -1098, 200));
		AddSpawnPoint("f_huevillage_58_3.Id4", "f_huevillage_58_3", Rectangle(-700, -1040, 200));
		AddSpawnPoint("f_huevillage_58_3.Id4", "f_huevillage_58_3", Rectangle(-954, -596, 200));
		AddSpawnPoint("f_huevillage_58_3.Id4", "f_huevillage_58_3", Rectangle(-289, -128, 200));
		AddSpawnPoint("f_huevillage_58_3.Id4", "f_huevillage_58_3", Rectangle(9, 343, 200));
		AddSpawnPoint("f_huevillage_58_3.Id4", "f_huevillage_58_3", Rectangle(518, 257, 200));
		AddSpawnPoint("f_huevillage_58_3.Id4", "f_huevillage_58_3", Rectangle(981, -388, 200));
		AddSpawnPoint("f_huevillage_58_3.Id4", "f_huevillage_58_3", Rectangle(1729, -562, 200));
		AddSpawnPoint("f_huevillage_58_3.Id4", "f_huevillage_58_3", Rectangle(-251, -611, 200));

		// 'Caro' GenType 44 Spawn Points
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1562, -952, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1292, -296, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1202, -983, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1605, -873, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1177, -422, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1500, -866, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1578, -790, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1584, -728, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1400, -886, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1301, -965, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1187, -1071, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1028, -1124, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1097, -1043, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(933, -994, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(949, -932, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(993, -917, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1071, -839, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1030, -974, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1121, -950, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1180, -849, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1285, -880, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1172, -302, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1057, -268, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1062, -497, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1150, -489, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1217, -437, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1342, -299, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1300, -272, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1226, -249, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1104, -359, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(982, -364, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(995, -419, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(925, -311, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(946, -227, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(987, -173, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1028, -146, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1092, -157, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(1411, -258, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(868, -66, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(822, -15, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(775, -4, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(687, 70, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(518, 158, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(463, 233, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(364, 179, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(436, 374, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(522, 385, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(535, 236, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(629, 265, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(597, 160, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(505, 293, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(504, 479, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(380, 278, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(419, 60, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(536, 20, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(239, -615, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(165, -504, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(372, -610, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(290, -779, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(261, -681, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(136, -688, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(293, -512, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(483, -672, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(212, -871, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(161, -764, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(347, -825, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(416, -676, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-353, -799, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-457, -784, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-419, -707, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-284, -718, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-310, -642, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-391, -685, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-491, -573, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-442, -527, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-440, -497, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-221, -566, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-289, -470, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-332, -458, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(10, 405, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-42, 408, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-22, 312, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-129, 338, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-168, 199, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-6, 248, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-125, 284, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-230, 300, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-241, 236, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-210, 119, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-262, 135, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-359, 159, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-301, 60, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-239, 54, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-599, -380, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-643, -375, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-550, -316, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-471, -329, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-1240, -1070, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-1201, -1012, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-1236, -983, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-1205, -897, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-1087, -883, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-1127, -812, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-1014, -784, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-1004, -700, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-895, -778, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-680, -680, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-707, -727, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-762, -760, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-803, -672, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-801, -594, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-972, -628, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-918, -598, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-880, -563, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-1006, -430, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-1032, -341, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-985, -302, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-908, -174, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-830, -157, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-874, -278, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-769, -307, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-867, -348, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-900, -442, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-722, -485, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-713, -607, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-714, -425, 25));
		AddSpawnPoint("f_huevillage_58_3.Id5", "f_huevillage_58_3", Rectangle(-827, -477, 25));

		// 'Tiny_Bow' GenType 46 Spawn Points
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(-1151, -851, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(1632, -817, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(-948, -459, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(-413, -815, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(1677, -758, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(1483, -234, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(-258, -458, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(-949, -732, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(-1014, -294, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(-958, -598, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(-835, -768, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(-1249, -1028, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(-589, -344, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(-336, 118, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(-149, 154, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(-160, 318, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(53, 405, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(-278, 223, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(494, 228, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(581, 366, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(684, 193, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(684, 193, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(649, 91, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(846, -32, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(430, 438, 25));
		AddSpawnPoint("f_huevillage_58_3.Id6", "f_huevillage_58_3", Rectangle(329, 224, 25));
	}
}
