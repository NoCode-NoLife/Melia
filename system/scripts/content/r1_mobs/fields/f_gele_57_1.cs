//--- Melia Script -----------------------------------------------------------
// Srautas Gorge Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_gele_57_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FGele571MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_gele_57_1", MonsterId.Zignuts, Properties("MHP", 12818, "MINPATK", 666, "MAXPATK", 720, "MINMATK", 666, "MAXMATK", 720, "DEF", 67, "MDEF", 67));
		AddPropertyOverrides("f_gele_57_1", MonsterId.Npanto_Baby, Properties("MHP", 12870, "MINPATK", 667, "MAXPATK", 721, "MINMATK", 667, "MAXMATK", 721, "DEF", 67, "MDEF", 67));
		AddPropertyOverrides("f_gele_57_1", MonsterId.Grummer, Properties("MHP", 12964, "MINPATK", 668, "MAXPATK", 722, "MINMATK", 668, "MAXMATK", 722, "DEF", 67, "MDEF", 67));
		AddPropertyOverrides("f_gele_57_1", MonsterId.Panto_Javelin_Gele, Properties("MHP", 13086, "MINPATK", 669, "MAXPATK", 724, "MINMATK", 669, "MAXMATK", 724, "DEF", 67, "MDEF", 67));

		// Monster Spawners ---------------------------------

		AddSpawner("f_gele_57_1.Id1", MonsterId.Npanto_Baby, 11, 14, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_1.Id2", MonsterId.Zignuts, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_1.Id3", MonsterId.Zignuts, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_1.Id4", MonsterId.Npanto_Baby, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_1.Id5", MonsterId.Rootcrystal_01, 10, 13, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_gele_57_1.Id6", MonsterId.Grummer, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_1.Id7", MonsterId.Npanto_Baby, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_1.Id8", MonsterId.Npanto_Baby, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_1.Id9", MonsterId.Grummer, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_1.Id10", MonsterId.Panto_Javelin_Gele, 1, 1, TimeSpan.FromMilliseconds(1800000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Npanto_Baby' GenType 111 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1399, -44, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1411, 522, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1560, -24, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1467, 89, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1345, 148, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1316, 16, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1214, -92, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1336, -190, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1489, -161, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1508, 468, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1393, 621, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1225, 575, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1296, 442, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1389, 317, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1510, 356, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1306, 528, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1398, 422, 30));

		// 'Zignuts' GenType 126 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id2", "f_gele_57_1", Rectangle(639, -546, 9999));

		// 'Zignuts' GenType 128 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id3", "f_gele_57_1", Rectangle(-218, -1569, 200));
		AddSpawnPoint("f_gele_57_1.Id3", "f_gele_57_1", Rectangle(659, -517, 200));

		// 'Npanto_Baby' GenType 129 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id4", "f_gele_57_1", Rectangle(-1354, 29, 9999));

		// 'Rootcrystal_01' GenType 134 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(-1185, -898, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(-1223, -536, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(-1308, -20, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(-1380, 523, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(-437, -702, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(-150, -946, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(-207, -1519, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(581, -1461, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(509, -534, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(-24, -629, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(197, 447, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(766, 478, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(1320, 782, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(1510, 431, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(1795, 94, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(741, 1134, 10));

		// 'Grummer' GenType 140 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id6", "f_gele_57_1", Rectangle(-225, -1594, 200));

		// 'Npanto_Baby' GenType 142 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(40, 411, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(686, 431, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1757, 135, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1395, 654, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1069, 936, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(35, 321, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(233, 442, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(241, 321, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(381, 277, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(410, 448, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(141, 390, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(341, 366, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(631, 317, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(783, 304, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(819, 475, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(631, 526, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(705, 586, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(512, 405, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1176, 697, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1293, 574, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1341, 750, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1435, 822, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1501, 641, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1788, 237, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1659, 103, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1742, 36, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1905, 165, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1857, 25, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1666, 240, 20));

		// 'Npanto_Baby' GenType 143 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id8", "f_gele_57_1", Rectangle(330, -602, 20));
		AddSpawnPoint("f_gele_57_1.Id8", "f_gele_57_1", Rectangle(665, -454, 20));
		AddSpawnPoint("f_gele_57_1.Id8", "f_gele_57_1", Rectangle(542, -428, 20));
		AddSpawnPoint("f_gele_57_1.Id8", "f_gele_57_1", Rectangle(664, -568, 20));
		AddSpawnPoint("f_gele_57_1.Id8", "f_gele_57_1", Rectangle(557, -664, 20));
		AddSpawnPoint("f_gele_57_1.Id8", "f_gele_57_1", Rectangle(534, -567, 20));
		AddSpawnPoint("f_gele_57_1.Id8", "f_gele_57_1", Rectangle(788, -409, 20));
		AddSpawnPoint("f_gele_57_1.Id8", "f_gele_57_1", Rectangle(790, -581, 20));

		// 'Grummer' GenType 144 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id9", "f_gele_57_1", Rectangle(504, -658, 30));
		AddSpawnPoint("f_gele_57_1.Id9", "f_gele_57_1", Rectangle(692, -421, 30));
		AddSpawnPoint("f_gele_57_1.Id9", "f_gele_57_1", Rectangle(659, -571, 30));
		AddSpawnPoint("f_gele_57_1.Id9", "f_gele_57_1", Rectangle(533, -502, 30));
		AddSpawnPoint("f_gele_57_1.Id9", "f_gele_57_1", Rectangle(820, -462, 30));
		AddSpawnPoint("f_gele_57_1.Id9", "f_gele_57_1", Rectangle(377, -592, 30));

		// 'Panto_Javelin_Gele' GenType 149 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id10", "f_gele_57_1", Rectangle(721, -514, 100));
	}
}
