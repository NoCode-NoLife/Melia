//--- Melia Script -----------------------------------------------------------
// Viltis Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_thorn_39_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DThorn391MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_thorn_39_1.Id1", MonsterId.Rootcrystal_01, min: 8, max: 10, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("d_thorn_39_1.Id2", MonsterId.Chafperor_Mage, min: 15, max: 20);
		AddSpawner("d_thorn_39_1.Id3", MonsterId.Wood_Lwa, min: 23, max: 30);
		AddSpawner("d_thorn_39_1.Id4", MonsterId.Infrogalas_Mage, min: 9, max: 12);
		AddSpawner("d_thorn_39_1.Id5", MonsterId.Pandroceum, min: 30, max: 40);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 3 Spawn Points
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(-919, 1251, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(-1957, 1079, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(-995, 669, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(-1147, 131, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(-604, 147, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(357, 611, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(1034, 906, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(63, -968, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(-374, -1785, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(-748, -1923, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(1060, -129, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(1585, -376, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(1337, -1496, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(1070, -2361, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(1430, 871, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(242, -425, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(-45, -1256, 50));
		AddSpawnPoint("d_thorn_39_1.Id1", "d_thorn_39_1", Rectangle(1711, -1038, 50));

		// 'Chafperor_Mage' GenType 16 Spawn Points
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(1290, 1026, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(1214, 770, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(1500, 789, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(353, 635, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(373, 875, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-785, -1932, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-232, -2012, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-477, -1832, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-153, -1038, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(139, -1104, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-457, -2106, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-63, -1172, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(1078, -195, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(1254, 87, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(1167, -474, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(1358, -263, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(880, -183, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(1257, -1468, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(1469, -1246, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(1345, -1305, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-1161, 143, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-1041, -3, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-736, 179, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-962, 489, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-1324, 402, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-915, 261, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-704, 441, 30));
		AddSpawnPoint("d_thorn_39_1.Id2", "d_thorn_39_1", Rectangle(-1231, -44, 30));

		// 'Wood_Lwa' GenType 20 Spawn Points
		AddSpawnPoint("d_thorn_39_1.Id3", "d_thorn_39_1", Rectangle(163, -616, 9999));

		// 'Infrogalas_Mage' GenType 21 Spawn Points
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1287, -1366, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1161, -1577, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1172, 948, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(-81, -1149, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1172, -122, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1268, -452, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1106, -2452, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(-593, -1907, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1047, -349, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(8, -979, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(71, -1134, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(-529, -2073, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(-820, -2011, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(-604, -1791, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1266, 712, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1344, 1040, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(993, -2328, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1179, -2184, 40));
		AddSpawnPoint("d_thorn_39_1.Id4", "d_thorn_39_1", Rectangle(1244, -2540, 40));

		// 'Pandroceum' GenType 28 Spawn Points
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1564, 718, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1470, 637, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1581, 786, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1576, 791, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1197, 1173, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1246, 1167, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1305, 1184, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(524, 669, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(549, 724, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(471, 1012, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(214, 874, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1531, -288, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1406, -381, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1184, 170, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1111, 89, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(813, -98, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1490, -185, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1473, -368, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(140, -507, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(1, -789, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(70, -655, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(275, -570, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(247, -678, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(275, -530, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(298, -419, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(156, -319, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-1454, 1368, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-1222, 1099, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-1313, 1152, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-1260, 1415, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-1077, 1418, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-1321, 1368, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-1418, 144, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-1228, 4, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-1111, 366, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-1045, 216, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-970, 367, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-747, 412, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-691, 540, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-627, 356, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(230, -728, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(247, -617, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(155, -459, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(103, -567, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-859, -1794, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-892, -1919, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-402, -2056, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-310, -1947, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-687, -1683, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-850, -1877, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-378, -1986, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-512, -2089, 10));
		AddSpawnPoint("d_thorn_39_1.Id5", "d_thorn_39_1", Rectangle(-283, -2082, 10));
	}
}
