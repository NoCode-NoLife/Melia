//--- Melia Script -----------------------------------------------------------
// Arcus Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_bracken_43_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FBracken431MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_bracken_43_1.Id1", MonsterId.Rakon, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_1.Id2", MonsterId.Rootcrystal_01, 12, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_1.Id3", MonsterId.Toothrikon, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_1.Id4", MonsterId.Horn_Golem, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_1.Id5", MonsterId.Rakon, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_1.Id6", MonsterId.Rakon, 9, 12, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rakon' GenType 27 Spawn Points
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-201, -1565, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-182, -1419, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-268, -1742, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-425, -1547, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1320, -1054, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1158, -1395, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1068, -1079, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(93, -1351, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(293, -1153, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-137, -833, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-119, -237, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(95, -700, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-287, -51, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(355, 923, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-792, 200, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1098, 350, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1324, 409, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1439, -125, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1612, -183, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-2082, -284, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1235, -209, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1276, 532, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-652, 773, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-421, 777, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-261, 795, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(321, 741, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(456, 644, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(555, 824, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(685, 764, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(1093, 734, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(912, -12, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(697, 46, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(1051, 158, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(927, -670, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(702, -650, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(688, -888, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(942, -831, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(1064, -538, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1638, -344, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1867, -326, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1619, 426, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1386, 677, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-278, -242, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-333, -417, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-10, -471, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-138, -409, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1067, -1233, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(-1109, -851, 40));
		AddSpawnPoint("f_bracken_43_1.Id1", "f_bracken_43_1", Rectangle(853, -488, 40));

		// 'Rootcrystal_01' GenType 28 Spawn Points
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(976, 51, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(674, 109, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(1141, 767, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(1071, 1284, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(592, 688, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(-500, 776, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(-1355, 489, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(-1454, -257, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(-1090, -1211, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(-154, -1577, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(247, -1201, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(-138, -819, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(-168, -452, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(-356, -95, 40));
		AddSpawnPoint("f_bracken_43_1.Id2", "f_bracken_43_1", Rectangle(291, 852, 40));

		// 'Toothrikon' GenType 29 Spawn Points
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-236, -307, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-1126, -1204, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-113, -1552, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-210, -830, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(455, -1105, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(644, -667, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(1175, 756, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(1121, 1128, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-1225, -1302, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-403, -1567, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(1037, -684, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(908, 1502, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-19, -712, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-320, -440, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-350, -39, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(12, -581, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(658, -937, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(911, -491, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(646, 43, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(900, 297, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(928, 61, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(745, 171, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-238, -1484, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-255, -1704, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-1116, -966, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(-1265, -1074, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(211, -1231, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(894, 1095, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(1098, 1422, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(984, 1314, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(1021, 734, 40));
		AddSpawnPoint("f_bracken_43_1.Id3", "f_bracken_43_1", Rectangle(1100, 928, 40));

		// 'Horn_Golem' GenType 33 Spawn Points
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(-1133, -994, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(-409, -1577, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(-26, -840, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(-297, -191, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(-1465, -283, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(-1425, 768, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(-534, 850, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(762, 175, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(912, 267, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(829, -643, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(700, -970, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(174, -1288, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(-96, -1523, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(-1077, -1249, 100));
		AddSpawnPoint("f_bracken_43_1.Id4", "f_bracken_43_1", Rectangle(-1365, 418, 100));

		// 'Rakon' GenType 34 Spawn Points
		AddSpawnPoint("f_bracken_43_1.Id5", "f_bracken_43_1", Rectangle(-267, -279, 9999));

		// 'Rakon' GenType 35 Spawn Points
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-253, -1618, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-58, -1644, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-133, -1471, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-399, -1640, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-412, -1433, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-221, -1767, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-1145, -1385, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-1178, -978, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-932, -1248, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-1152, -1186, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-1359, -1218, 40));
		AddSpawnPoint("f_bracken_43_1.Id6", "f_bracken_43_1", Rectangle(-1015, -1082, 40));
	}
}
