//--- Melia Script -----------------------------------------------------------
// Sirdgela Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_thorn_20'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DThorn20MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_thorn_20", MonsterId.Flower_Blue, Properties("MHP", 42680, "MINPATK", 1050, "MAXPATK", 1192, "MINMATK", 1050, "MAXMATK", 1192, "DEF", 190, "MDEF", 190));
		AddPropertyOverrides("d_thorn_20", MonsterId.Groll, Properties("MHP", 43506, "MINPATK", 1060, "MAXPATK", 1205, "MINMATK", 1060, "MAXMATK", 1205, "DEF", 192, "MDEF", 192));
		AddPropertyOverrides("d_thorn_20", MonsterId.Merog_Wogu, Properties("MHP", 44345, "MINPATK", 1071, "MAXPATK", 1218, "MINMATK", 1071, "MAXMATK", 1218, "DEF", 193, "MDEF", 193));
		AddPropertyOverrides("d_thorn_20", MonsterId.Merog_Wizzard, Properties("MHP", 45199, "MINPATK", 1082, "MAXPATK", 1232, "MINMATK", 1082, "MAXMATK", 1232, "DEF", 194, "MDEF", 194));
		AddPropertyOverrides("d_thorn_20", MonsterId.Bagworm, Properties("MHP", 46066, "MINPATK", 1093, "MAXPATK", 1245, "MINMATK", 1093, "MAXMATK", 1245, "DEF", 195, "MDEF", 195));

		// Monster Spawners ---------------------------------

		AddSpawner("d_thorn_20.Id1", MonsterId.Flower_Blue, min: 9, max: 12);
		AddSpawner("d_thorn_20.Id2", MonsterId.Groll, min: 57, max: 75);
		AddSpawner("d_thorn_20.Id3", MonsterId.Rootcrystal_01, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("d_thorn_20.Id4", MonsterId.Groll, min: 15, max: 20);
		AddSpawner("d_thorn_20.Id5", MonsterId.Merog_Wizzard, min: 12, max: 15);
		AddSpawner("d_thorn_20.Id6", MonsterId.Bagworm, min: 15, max: 20);
		AddSpawner("d_thorn_20.Id7", MonsterId.Flower_Blue, min: 12, max: 15);
		AddSpawner("d_thorn_20.Id8", MonsterId.Merog_Wogu, min: 8, max: 10);

		// Monster Spawn Points -----------------------------

		// 'Flower_Blue' GenType 301 Spawn Points
		AddSpawnPoint("d_thorn_20.Id1", "d_thorn_20", Rectangle(-979, -1948, 9999));

		// 'Groll' GenType 308 Spawn Points
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-365, -1128, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-438, -981, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-939, -1966, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-836, -1847, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-738, -1958, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-261, -1649, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-344, -1825, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-331, -2125, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-435, -1699, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-571, -1831, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-447, -2024, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-199, -1808, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-69, -2078, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-380, -1954, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-64, -2230, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-465, -2203, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-198, -2228, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-154, -1945, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(115, -2073, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(358, -1990, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(314, -1920, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(143, -1950, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(5, -1824, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-172, -1594, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-262, -1066, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-222, -954, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-340, -859, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-495, -784, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-364, -688, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-118, -715, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-64, -969, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-246, -791, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-46, -1066, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(70, -922, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-206, -1210, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-721, -527, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-868, -583, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1366, 323, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1072, -331, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1160, -386, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1521, 383, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1347, -144, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1115, -87, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1460, 224, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1200, -284, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1332, 173, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1145, 131, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1223, 186, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1289, 411, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1040, 976, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1186, 935, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-722, 946, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1123, 1165, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1035, 1362, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-880, 1429, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-908, 1295, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-782, 1253, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-607, 899, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-677, 788, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-806, 758, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-612, 1058, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-896, 925, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-941, 1163, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-185, 472, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-827, 1070, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-1048, 815, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-230, 273, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(11, 326, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-406, 310, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-429, 100, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(176, 51, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(212, -81, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(-74, -111, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(1460, -1174, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(1854, -1192, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(1671, -1214, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(1896, -1338, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(1751, -1329, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(1543, -1340, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(1598, -1480, 25));
		AddSpawnPoint("d_thorn_20.Id2", "d_thorn_20", Rectangle(1859, -1449, 25));

		// 'Rootcrystal_01' GenType 514 Spawn Points
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-242, -1817, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-431, -1927, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-403, -2133, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-200, -2212, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-6, -2023, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-218, -2043, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-249, -1113, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-384, -1019, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-193, -860, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-321, -796, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-898, -511, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-1105, -372, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-1363, 203, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-1427, 255, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-886, 1130, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-931, 960, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-683, 867, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-251, 381, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-278, 220, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-22, 18, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(141, 169, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(710, -909, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(1679, -1271, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(1798, -1362, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(1656, -1459, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2778, -1306, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2650, -1213, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2640, -1309, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2637, -1070, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2046, -173, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2213, -445, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2623, 656, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2851, 605, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2848, 408, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2577, 411, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(2856, -1189, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(1055, -1074, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(5, -967, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-1291, -1825, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-1214, -298, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-160, -27, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(1572, -1317, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(636, -930, 200));
		AddSpawnPoint("d_thorn_20.Id3", "d_thorn_20", Rectangle(-773, 1022, 200));

		// 'Groll' GenType 821 Spawn Points
		AddSpawnPoint("d_thorn_20.Id4", "d_thorn_20", Rectangle(-240, -560, 9999));

		// 'Merog_Wizzard' GenType 842 Spawn Points
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-1026, -469, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-886, 1167, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-800, 836, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-684, 1043, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-1154, -223, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-296, 430, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(148, 37, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-132, 58, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-1281, -332, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-1306, -188, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-858, 1014, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-397, 215, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-79, 365, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-245, -74, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-987, -336, 25));
		AddSpawnPoint("d_thorn_20.Id5", "d_thorn_20", Rectangle(-9, -106, 25));

		// 'Bagworm' GenType 843 Spawn Points
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(42, -901, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(1448, -1466, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(1503, -1209, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(1237, -1062, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(1174, -1123, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(1127, -1032, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(1101, -1112, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(1288, -1154, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(1261, -1180, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-1041, -298, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-878, 883, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-154, 215, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-439, -1004, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(0, -1090, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-235, -712, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-824, -522, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-1393, -110, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-1401, 319, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-1018, 1190, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-702, 1053, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-265, 179, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-426, 68, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-139, 422, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(94, -65, 30));
		AddSpawnPoint("d_thorn_20.Id6", "d_thorn_20", Rectangle(-269, -1206, 30));

		// 'Flower_Blue' GenType 846 Spawn Points
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(-182, -1890, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(-434, -2102, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(-201, -1459, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(-120, -2201, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(-4, -2011, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(213, -1984, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(267, -1896, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(284, -2008, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(262, -1962, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(-212, -1512, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(-64, -1547, 30));
		AddSpawnPoint("d_thorn_20.Id7", "d_thorn_20", Rectangle(-142, -1518, 30));

		// 'Merog_Wogu' GenType 850 Spawn Points
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-208, -1690, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-190, -2164, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-195, -1144, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-386, -865, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-153, -651, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-10, -862, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-468, -1950, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(86, -1973, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-524, -2221, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-177, -894, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-799, -633, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-671, -619, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-183, -414, 25));
		AddSpawnPoint("d_thorn_20.Id8", "d_thorn_20", Rectangle(-120, -313, 25));
	}
}
