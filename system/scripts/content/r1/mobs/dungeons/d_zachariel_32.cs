//--- Melia Script -----------------------------------------------------------
// Royal Mausoleum 1F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_zachariel_32'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DZachariel32MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_zachariel_32", MonsterId.Zinutekas, Properties("MHP", 60625, "MINPATK", 1281, "MAXPATK", 1476, "MINMATK", 1281, "MAXMATK", 1476, "DEF", 329, "MDEF", 329));
		AddPropertyOverrides("d_zachariel_32", MonsterId.Varv, Properties("MHP", 61312, "MINPATK", 1289, "MAXPATK", 1486, "MINMATK", 1289, "MAXMATK", 1486, "DEF", 340, "MDEF", 340));
		AddPropertyOverrides("d_zachariel_32", MonsterId.Moving_Trap, Properties("MHP", 62017, "MINPATK", 1298, "MAXPATK", 1498, "MINMATK", 1298, "MAXMATK", 1498, "DEF", 351, "MDEF", 351));
		AddPropertyOverrides("d_zachariel_32", MonsterId.Zinutekas_Elite, Properties("MHP", 62740, "MINPATK", 1308, "MAXPATK", 1509, "MINMATK", 1308, "MAXMATK", 1509, "DEF", 362, "MDEF", 362));
		AddPropertyOverrides("d_zachariel_32", MonsterId.Karas, Properties("MHP", 63480, "MINPATK", 1317, "MAXPATK", 1521, "MINMATK", 1317, "MAXMATK", 1521, "DEF", 373, "MDEF", 373));

		// Monster Spawners ---------------------------------

		AddSpawner("d_zachariel_32.Id1", MonsterId.Rootcrystal_05, min: 12, max: 16, respawn: TimeSpan.FromMilliseconds(5000), tendency: TendencyType.Peaceful);
		AddSpawner("d_zachariel_32.Id2", MonsterId.Zinutekas, min: 6, max: 8, tendency: TendencyType.Aggressive);
		AddSpawner("d_zachariel_32.Id3", MonsterId.Zinutekas, min: 8, max: 10, tendency: TendencyType.Aggressive);
		AddSpawner("d_zachariel_32.Id4", MonsterId.Varv, min: 8, max: 10, tendency: TendencyType.Aggressive);
		AddSpawner("d_zachariel_32.Id5", MonsterId.Moving_Trap, min: 8, max: 10, tendency: TendencyType.Aggressive);
		AddSpawner("d_zachariel_32.Id6", MonsterId.Moving_Trap, min: 5, max: 6, tendency: TendencyType.Aggressive);
		AddSpawner("d_zachariel_32.Id7", MonsterId.Varv, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("d_zachariel_32.Id8", MonsterId.Karas, min: 8, max: 10, tendency: TendencyType.Peaceful);
		AddSpawner("d_zachariel_32.Id9", MonsterId.Zinutekas_Elite, min: 3, max: 4, tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 600 Spawn Points
		AddSpawnPoint("d_zachariel_32.Id1", "d_zachariel_32", Rectangle(-42, -1123, 30));
		AddSpawnPoint("d_zachariel_32.Id1", "d_zachariel_32", Rectangle(1230, 72, 30));
		AddSpawnPoint("d_zachariel_32.Id1", "d_zachariel_32", Rectangle(-872, 75, 30));
		AddSpawnPoint("d_zachariel_32.Id1", "d_zachariel_32", Rectangle(52, 1357, 30));

		// 'Zinutekas' GenType 1020 Spawn Points
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(-122, 171, 350));
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(-105, 1393, 350));
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(1262, 51, 350));
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(-41, 25, 350));
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(-4, -86, 350));
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(203, 86, 350));
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(22, 256, 350));
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(914, 95, 350));
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(1115, -27, 350));
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(1208, 188, 350));
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(1075, 251, 350));
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(1100, 131, 350));
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(979, -8, 350));
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(15, 102, 350));
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(73, 1453, 350));
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(47, 1404, 350));
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(47, 1678, 350));
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(215, 1407, 350));
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(56, 1154, 350));
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(-250, 1408, 350));
		AddSpawnPoint("d_zachariel_32.Id2", "d_zachariel_32", Rectangle(371, 1410, 350));

		// 'Zinutekas' GenType 3005 Spawn Points
		AddSpawnPoint("d_zachariel_32.Id3", "d_zachariel_32", Rectangle(49, 1420, 9999));

		// 'Varv' GenType 3006 Spawn Points
		AddSpawnPoint("d_zachariel_32.Id4", "d_zachariel_32", Rectangle(62, 1415, 9999));

		// 'Moving_Trap' GenType 3008 Spawn Points
		AddSpawnPoint("d_zachariel_32.Id5", "d_zachariel_32", Rectangle(41, 187, 9999));

		// 'Moving_Trap' GenType 3009 Spawn Points
		AddSpawnPoint("d_zachariel_32.Id6", "d_zachariel_32", Rectangle(56, 145, 350));
		AddSpawnPoint("d_zachariel_32.Id6", "d_zachariel_32", Rectangle(1133, 129, 350));
		AddSpawnPoint("d_zachariel_32.Id6", "d_zachariel_32", Rectangle(-192, 97, 350));
		AddSpawnPoint("d_zachariel_32.Id6", "d_zachariel_32", Rectangle(49, -89, 350));
		AddSpawnPoint("d_zachariel_32.Id6", "d_zachariel_32", Rectangle(947, 72, 350));
		AddSpawnPoint("d_zachariel_32.Id6", "d_zachariel_32", Rectangle(1157, -99, 350));
		AddSpawnPoint("d_zachariel_32.Id6", "d_zachariel_32", Rectangle(1257, 260, 350));
		AddSpawnPoint("d_zachariel_32.Id6", "d_zachariel_32", Rectangle(1049, 293, 350));
		AddSpawnPoint("d_zachariel_32.Id6", "d_zachariel_32", Rectangle(-992, 269, 350));
		AddSpawnPoint("d_zachariel_32.Id6", "d_zachariel_32", Rectangle(-1080, -55, 350));
		AddSpawnPoint("d_zachariel_32.Id6", "d_zachariel_32", Rectangle(-797, 58, 350));
		AddSpawnPoint("d_zachariel_32.Id6", "d_zachariel_32", Rectangle(-1136, 125, 350));
		AddSpawnPoint("d_zachariel_32.Id6", "d_zachariel_32", Rectangle(-789, 197, 350));
		AddSpawnPoint("d_zachariel_32.Id6", "d_zachariel_32", Rectangle(35, 367, 350));
		AddSpawnPoint("d_zachariel_32.Id6", "d_zachariel_32", Rectangle(272, 108, 350));

		// 'Varv' GenType 3010 Spawn Points
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(-895, 1393, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(-982, -880, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(-1084, -1109, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(-1099, -927, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(-936, -1029, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(-959, 22, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(-937, 269, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(-1090, 154, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(-776, 122, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(-978, 1229, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(-955, 1583, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(-1068, 1501, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(1089, 1333, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(1180, 1562, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(991, 1426, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(1086, 246, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(981, 31, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(1086, -111, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(1124, 124, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(1045, -837, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(966, -981, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(1095, -1150, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(1237, -979, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(1113, -1011, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(560, -936, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(64, -1279, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(25, -45, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(-161, 108, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(75, 1392, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(318, 1456, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(46, 729, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(-377, 1411, 350));
		AddSpawnPoint("d_zachariel_32.Id7", "d_zachariel_32", Rectangle(-439, -990, 350));

		// 'Karas' GenType 3019 Spawn Points
		AddSpawnPoint("d_zachariel_32.Id8", "d_zachariel_32", Rectangle(37, 943, 40));
		AddSpawnPoint("d_zachariel_32.Id8", "d_zachariel_32", Rectangle(450, 1388, 40));
		AddSpawnPoint("d_zachariel_32.Id8", "d_zachariel_32", Rectangle(-427, 1398, 40));
		AddSpawnPoint("d_zachariel_32.Id8", "d_zachariel_32", Rectangle(1215, 1290, 40));
		AddSpawnPoint("d_zachariel_32.Id8", "d_zachariel_32", Rectangle(979, 84, 40));
		AddSpawnPoint("d_zachariel_32.Id8", "d_zachariel_32", Rectangle(1115, 1343, 40));
		AddSpawnPoint("d_zachariel_32.Id8", "d_zachariel_32", Rectangle(-898, 1292, 40));
		AddSpawnPoint("d_zachariel_32.Id8", "d_zachariel_32", Rectangle(-925, 1507, 40));
		AddSpawnPoint("d_zachariel_32.Id8", "d_zachariel_32", Rectangle(35, 1145, 40));
		AddSpawnPoint("d_zachariel_32.Id8", "d_zachariel_32", Rectangle(-1108, 1277, 40));
		AddSpawnPoint("d_zachariel_32.Id8", "d_zachariel_32", Rectangle(1001, 1525, 40));
		AddSpawnPoint("d_zachariel_32.Id8", "d_zachariel_32", Rectangle(-1109, 1520, 40));
		AddSpawnPoint("d_zachariel_32.Id8", "d_zachariel_32", Rectangle(-638, 1388, 40));
		AddSpawnPoint("d_zachariel_32.Id8", "d_zachariel_32", Rectangle(645, 1386, 40));
		AddSpawnPoint("d_zachariel_32.Id8", "d_zachariel_32", Rectangle(1012, 1281, 40));
		AddSpawnPoint("d_zachariel_32.Id8", "d_zachariel_32", Rectangle(1205, 1517, 40));
		AddSpawnPoint("d_zachariel_32.Id8", "d_zachariel_32", Rectangle(-1000, 1446, 40));
		AddSpawnPoint("d_zachariel_32.Id8", "d_zachariel_32", Rectangle(1136, 1451, 40));
		AddSpawnPoint("d_zachariel_32.Id8", "d_zachariel_32", Rectangle(-1002, 1341, 40));

		// 'Zinutekas_Elite' GenType 3021 Spawn Points
		AddSpawnPoint("d_zachariel_32.Id9", "d_zachariel_32", Rectangle(56, 94, 9999));
	}
}
