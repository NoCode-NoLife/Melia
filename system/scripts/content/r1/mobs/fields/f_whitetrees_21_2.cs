//--- Melia Script -----------------------------------------------------------
// Nobreer Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_whitetrees_21_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FWhitetrees212MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_whitetrees_21_2", MonsterId.Kucarry_Symbani, Properties("MHP", 524595, "MINPATK", 7247, "MAXPATK", 8808, "MINMATK", 7247, "MAXMATK", 8808, "DEF", 90100, "MDEF", 90100));
		AddPropertyOverrides("f_whitetrees_21_2", MonsterId.Kucarry_Balzer, Properties("MHP", 525104, "MINPATK", 7254, "MAXPATK", 8816, "MINMATK", 7254, "MAXMATK", 8816, "DEF", 90351, "MDEF", 90351));
		AddPropertyOverrides("f_whitetrees_21_2", MonsterId.Kucarry_Zeffi, Properties("MHP", 526033, "MINPATK", 7265, "MAXPATK", 8831, "MINMATK", 7265, "MAXMATK", 8831, "DEF", 90811, "MDEF", 90811));

		// Monster Spawners ---------------------------------

		AddSpawner("f_whitetrees_21_2.Id1", MonsterId.Kucarry_Symbani, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_2.Id2", MonsterId.Kucarry_Balzer, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_2.Id3", MonsterId.Kucarry_Zeffi, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_2.Id4", MonsterId.Kucarry_Zeffi, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_2.Id5", MonsterId.Kucarry_Balzer, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_2.Id6", MonsterId.Kucarry_Symbani, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_2.Id7", MonsterId.Kucarry_Zeffi, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_2.Id8", MonsterId.Rootcrystal_01, 8, 10, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Kucarry_Symbani' GenType 1 Spawn Points
		AddSpawnPoint("f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Rectangle(-696, -578, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Rectangle(-829, -778, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Rectangle(-819, -783, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Rectangle(-668, -444, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Rectangle(-736, -703, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Rectangle(-940, 196, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Rectangle(-907, 335, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Rectangle(-1113, 142, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Rectangle(-1364, 314, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Rectangle(-1319, -262, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Rectangle(-1063, -670, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Rectangle(-874, -472, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Rectangle(-1094, -436, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Rectangle(-1096, 276, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Rectangle(-1276, 476, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Rectangle(-1110, 499, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Rectangle(-832, 193, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id1", "f_whitetrees_21_2", Rectangle(-1400, 19, 40));

		// 'Kucarry_Balzer' GenType 2 Spawn Points
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(-225, -900, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(39, -944, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(-356, -707, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(-162, -375, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(-397, -2, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(-104, 419, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(-40, 57, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(-87, -863, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(558, -1095, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(522, -1235, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(722, -1239, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(829, -1125, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(338, -1130, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(229, 180, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(523, -115, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(629, 9, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(829, -80, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(991, 197, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(1038, 54, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(503, 84, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(-191, 74, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(-334, 173, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(-62, 237, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(-244, -152, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(-133, -110, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(226, -955, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id2", "f_whitetrees_21_2", Rectangle(55, -815, 40));

		// 'Kucarry_Zeffi' GenType 3 Spawn Points
		AddSpawnPoint("f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Rectangle(1504, 382, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Rectangle(905, 1845, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Rectangle(1018, 1588, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Rectangle(-40, 1082, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Rectangle(93, 1219, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Rectangle(104, 1067, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Rectangle(116, 962, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Rectangle(251, 1063, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Rectangle(216, 1528, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Rectangle(86, 1710, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Rectangle(285, 1780, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Rectangle(438, 1681, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Rectangle(322, 1616, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Rectangle(455, 1489, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Rectangle(805, 1702, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Rectangle(1014, 1727, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Rectangle(905, 1587, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id3", "f_whitetrees_21_2", Rectangle(352, 1450, 40));

		// 'Kucarry_Zeffi' GenType 4 Spawn Points
		AddSpawnPoint("f_whitetrees_21_2.Id4", "f_whitetrees_21_2", Rectangle(-1034, -1319, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id4", "f_whitetrees_21_2", Rectangle(-876, -1286, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id4", "f_whitetrees_21_2", Rectangle(-717, -1281, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id4", "f_whitetrees_21_2", Rectangle(-558, -1265, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id4", "f_whitetrees_21_2", Rectangle(-903, -1538, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id4", "f_whitetrees_21_2", Rectangle(-723, -1482, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id4", "f_whitetrees_21_2", Rectangle(-910, -1068, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id4", "f_whitetrees_21_2", Rectangle(-709, -1075, 40));

		// 'Kucarry_Balzer' GenType 5 Spawn Points
		AddSpawnPoint("f_whitetrees_21_2.Id5", "f_whitetrees_21_2", Rectangle(-1034, -1512, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id5", "f_whitetrees_21_2", Rectangle(-896, -1281, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id5", "f_whitetrees_21_2", Rectangle(-585, -1069, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id5", "f_whitetrees_21_2", Rectangle(-949, -1083, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id5", "f_whitetrees_21_2", Rectangle(-691, -1318, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id5", "f_whitetrees_21_2", Rectangle(-538, -1464, 40));

		// 'Kucarry_Symbani' GenType 6 Spawn Points
		AddSpawnPoint("f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Rectangle(-806, -1474, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Rectangle(-669, -1470, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Rectangle(-742, -1043, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Rectangle(-583, -1042, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Rectangle(-683, -1136, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Rectangle(-694, -1313, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Rectangle(-885, -1210, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Rectangle(-898, -1361, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Rectangle(-1069, -1319, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Rectangle(143, 1530, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Rectangle(485, 1647, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Rectangle(253, 1633, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Rectangle(11, 1123, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Rectangle(92, 982, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Rectangle(203, 1084, 40));
		AddSpawnPoint("f_whitetrees_21_2.Id6", "f_whitetrees_21_2", Rectangle(390, 1510, 40));

		// 'Kucarry_Zeffi' GenType 7 Spawn Points
		AddSpawnPoint("f_whitetrees_21_2.Id7", "f_whitetrees_21_2", Rectangle(696, 10, 9999));

		// 'Rootcrystal_01' GenType 12 Spawn Points
		AddSpawnPoint("f_whitetrees_21_2.Id8", "f_whitetrees_21_2", Rectangle(-1074, -1301, 100));
		AddSpawnPoint("f_whitetrees_21_2.Id8", "f_whitetrees_21_2", Rectangle(-1322, -203, 100));
		AddSpawnPoint("f_whitetrees_21_2.Id8", "f_whitetrees_21_2", Rectangle(-713, 12, 100));
		AddSpawnPoint("f_whitetrees_21_2.Id8", "f_whitetrees_21_2", Rectangle(333, 135, 100));
		AddSpawnPoint("f_whitetrees_21_2.Id8", "f_whitetrees_21_2", Rectangle(378, 1571, 100));
		AddSpawnPoint("f_whitetrees_21_2.Id8", "f_whitetrees_21_2", Rectangle(-23, 1091, 100));
		AddSpawnPoint("f_whitetrees_21_2.Id8", "f_whitetrees_21_2", Rectangle(1215, 462, 100));
		AddSpawnPoint("f_whitetrees_21_2.Id8", "f_whitetrees_21_2", Rectangle(445, -1126, 100));
		AddSpawnPoint("f_whitetrees_21_2.Id8", "f_whitetrees_21_2", Rectangle(-103, -957, 100));
		AddSpawnPoint("f_whitetrees_21_2.Id8", "f_whitetrees_21_2", Rectangle(-601, -577, 100));
	}
}
