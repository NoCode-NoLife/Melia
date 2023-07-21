//--- Melia Script -----------------------------------------------------------
// Taniel I Commemorative Orb Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_dcapital_103'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FDcapital103MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_dcapital_103", MonsterId.Goblin2_Sword_Green, Properties("MHP", 747642, "MINPATK", 10115, "MAXPATK", 12334, "MINMATK", 10115, "MAXMATK", 12334, "DEF", 225179, "MDEF", 225179));
		AddPropertyOverrides("f_dcapital_103", MonsterId.Goblin2_Hammer_Green, Properties("MHP", 747899, "MINPATK", 10118, "MAXPATK", 12338, "MINMATK", 10118, "MAXMATK", 12338, "DEF", 225395, "MDEF", 225395));
		AddPropertyOverrides("f_dcapital_103", MonsterId.Goblin2_Wand1_Green, Properties("MHP", 748368, "MINPATK", 10124, "MAXPATK", 12345, "MINMATK", 10124, "MAXMATK", 12345, "DEF", 225791, "MDEF", 225791));
		AddPropertyOverrides("f_dcapital_103", MonsterId.Goblin2_Wand3_Green, Properties("MHP", 748976, "MINPATK", 10132, "MAXPATK", 12355, "MINMATK", 10132, "MAXMATK", 12355, "DEF", 226303, "MDEF", 226303));

		// Monster Spawners ---------------------------------

		AddSpawner("f_dcapital_103.Id1", MonsterId.Rootcrystal_01, 13, 17, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_dcapital_103.Id2", MonsterId.Goblin2_Sword_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_dcapital_103.Id3", MonsterId.Goblin2_Hammer_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_dcapital_103.Id4", MonsterId.Goblin2_Wand1_Green, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_dcapital_103.Id5", MonsterId.Goblin2_Wand3_Green, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_dcapital_103.Id6", MonsterId.Goblin2_Hammer_Green, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 5 Spawn Points
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(650, -1458, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(509, -1218, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(291, -1204, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(411, -761, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(625, -675, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(482, -246, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(-110, -1288, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(-400, -1228, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(-511, -546, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(-342, -258, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(-17, -492, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(1033, -676, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(1414, -608, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(1123, 314, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(1184, 676, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(-511, 248, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(-954, 217, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(-1332, 261, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(41, 390, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(306, 546, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(-172, 938, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(-106, 1307, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(272, 925, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(681, 1142, 50));
		AddSpawnPoint("f_dcapital_103.Id1", "f_dcapital_103", Rectangle(1061, 1155, 50));

		// 'Goblin2_Sword_Green' GenType 300 Spawn Points
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(481, -683, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(414, -1253, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-302, -424, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(427, -151, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(1235, 444, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-1219, 442, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(882, 1086, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(1053, 1234, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(777, 1264, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(638, 1111, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-1182, 254, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-1254, 77, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-1382, 307, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-933, 201, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-211, -362, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-253, -597, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-539, -482, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-403, -253, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(-23, -519, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(619, -668, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(497, -566, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(316, -740, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(468, -329, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(314, -125, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(496, -93, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(1208, 238, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(993, 296, 45));
		AddSpawnPoint("f_dcapital_103.Id2", "f_dcapital_103", Rectangle(1438, 473, 45));

		// 'Goblin2_Hammer_Green' GenType 301 Spawn Points
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(347, -1251, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-306, -1404, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-143, -1270, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-430, -1235, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(618, -1435, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(394, -1489, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(479, -1100, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-406, -587, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-545, -310, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-143, -281, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(1016, -675, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(1208, -545, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(1333, -713, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(1455, -533, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(1155, 331, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(1190, 721, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(1412, 383, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(986, 403, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(302, 494, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(99, 319, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-431, 303, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-1068, 315, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-1323, 207, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-205, 996, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(161, 1066, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(93, 850, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(168, 514, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(1189, -773, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(1319, -583, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(488, -1329, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-285, -1300, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(1321, 221, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(168, 417, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-41, 940, 40));
		AddSpawnPoint("f_dcapital_103.Id3", "f_dcapital_103", Rectangle(-1070, 169, 40));

		// 'Goblin2_Wand1_Green' GenType 302 Spawn Points
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(-125, -430, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(-453, -432, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(-448, -252, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(-470, -665, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(1126, 222, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(1124, 607, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(1292, 468, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(1388, 231, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(1471, 604, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(972, 566, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(-224, -628, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(-572, -629, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(-517, -1216, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(-305, -1232, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(-382, -1436, 40));
		AddSpawnPoint("f_dcapital_103.Id4", "f_dcapital_103", Rectangle(-151, -1356, 40));

		// 'Goblin2_Wand3_Green' GenType 303 Spawn Points
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(1147, 475, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(231, 316, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(-162, 978, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(569, 1048, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(885, 1291, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(1001, 1105, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(856, 1174, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(776, 995, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(36, 970, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(254, 890, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(-61, 1169, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(-589, 251, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(-417, 193, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(64, 449, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(353, 362, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(1502, 405, 40));
		AddSpawnPoint("f_dcapital_103.Id5", "f_dcapital_103", Rectangle(171, 645, 40));

		// 'Goblin2_Hammer_Green' GenType 304 Spawn Points
		AddSpawnPoint("f_dcapital_103.Id6", "f_dcapital_103", Rectangle(-152, 1073, 40));
		AddSpawnPoint("f_dcapital_103.Id6", "f_dcapital_103", Rectangle(-134, 844, 40));
		AddSpawnPoint("f_dcapital_103.Id6", "f_dcapital_103", Rectangle(173, 860, 40));
		AddSpawnPoint("f_dcapital_103.Id6", "f_dcapital_103", Rectangle(-115, 1224, 40));
		AddSpawnPoint("f_dcapital_103.Id6", "f_dcapital_103", Rectangle(303, 960, 40));
		AddSpawnPoint("f_dcapital_103.Id6", "f_dcapital_103", Rectangle(169, 995, 40));
		AddSpawnPoint("f_dcapital_103.Id6", "f_dcapital_103", Rectangle(394, 985, 40));
	}
}
