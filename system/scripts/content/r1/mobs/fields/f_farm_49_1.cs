//--- Melia Script -----------------------------------------------------------
// Greene Manor Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_farm_49_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFarm491MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_farm_49_1", MonsterId.Lizardman_Orange, Properties("MHP", 218985, "MINPATK", 3317, "MAXPATK", 3978, "MINMATK", 3317, "MAXMATK", 3978, "DEF", 9064, "MDEF", 9064));
		AddPropertyOverrides("f_farm_49_1", MonsterId.Tama_Orange, Properties("MHP", 219256, "MINPATK", 3320, "MAXPATK", 3982, "MINMATK", 3320, "MAXMATK", 3982, "DEF", 9100, "MDEF", 9100));
		AddPropertyOverrides("f_farm_49_1", MonsterId.Rambear_Bow, Properties("MHP", 219750, "MINPATK", 3327, "MAXPATK", 3990, "MINMATK", 3327, "MAXMATK", 3990, "DEF", 9166, "MDEF", 9166));

		// Monster Spawners ---------------------------------

		AddSpawner("f_farm_49_1.Id1", MonsterId.Lizardman_Orange, 12, 15, TimeSpan.FromMilliseconds(20000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_1.Id2", MonsterId.Lizardman_Orange, 15, 20, TimeSpan.FromMilliseconds(20000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_1.Id3", MonsterId.Tama_Orange, 19, 25, TimeSpan.FromMilliseconds(20000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_1.Id4", MonsterId.Tama_Orange, 23, 30, TimeSpan.FromMilliseconds(20000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_1.Id5", MonsterId.Rambear_Bow, 12, 15, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_farm_49_1.Id6", MonsterId.Rootcrystal_01, 9, 12, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Lizardman_Orange' GenType 4 Spawn Points
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-235, -1334, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(55, -1238, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-248, -1188, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-1176, -415, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-1208, -625, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-1053, -597, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-1018, -432, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-1412, -519, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-1075, -800, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-1125, -205, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-890, -553, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-48, -1278, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-301, -1421, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-85, -1464, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(77, -1462, 25));

		// 'Lizardman_Orange' GenType 5 Spawn Points
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2227, -402, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2404, -391, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1744, -114, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2265, -199, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2430, -16, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2287, 20, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1201, -915, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1376, -1246, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1541, -1046, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1148, -1143, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1436, -243, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1328, -30, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1633, -237, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1519, -61, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1352, -1017, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1723, 33, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2488, -203, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2103, -514, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2407, 105, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1362, -1120, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1362, -858, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1168, -1008, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1568, 43, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1514, -149, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2411, -141, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2360, -288, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2102, -248, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1162, -100, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1593, 329, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1323, 246, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1127, 58, 30));

		// 'Tama_Orange' GenType 6 Spawn Points
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(599, 850, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(796, 689, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(595, 488, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(445, 747, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(366, 484, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(173, 933, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(476, 1097, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-619, 604, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-687, 868, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-360, 803, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-295, 555, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(599, -581, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(665, -363, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(870, -615, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(932, -368, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-476, 712, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-602, 428, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-349, 498, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-737, 540, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-776, 715, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-469, 881, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-230, 781, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(581, 650, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(758, 410, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(276, 703, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(791, -480, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(710, -125, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(1027, -250, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(482, -465, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(689, -722, 25));

		// 'Tama_Orange' GenType 7 Spawn Points
		AddSpawnPoint("f_farm_49_1.Id4", "f_farm_49_1", Rectangle(568, 246, 9999));

		// 'Rambear_Bow' GenType 8 Spawn Points
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1049, -449, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-935, -1422, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-736, -1375, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-827, -1117, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-958, -1180, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1272, -568, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1183, 260, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1162, 652, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-944, 300, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1927, 310, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1898, -58, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-820, -1591, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-731, -1249, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1287, -378, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1060, 437, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1098, 61, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1291, 484, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-910, 538, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1068, -627, 25));

		// 'Rootcrystal_01' GenType 33 Spawn Points
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(290, 550, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(1576, -14, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(1527, -255, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(1298, -1054, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(1450, -1153, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(2316, -378, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(2389, -123, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(896, 675, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(496, 917, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(659, 478, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-344, 740, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-638, 548, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(789, -289, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(974, -592, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(692, -547, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-89, -1137, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-69, -1406, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-1026, -499, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-1258, -648, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-840, -1256, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-819, -1531, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-1044, 192, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-1141, 676, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-1811, 309, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-1826, -186, 50));
	}
}
