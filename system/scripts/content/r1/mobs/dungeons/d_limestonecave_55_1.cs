//--- Melia Script -----------------------------------------------------------
// Alembique Cave Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_limestonecave_55_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DLimestonecave551MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_limestonecave_55_1.Id1", MonsterId.Charog_Green, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("d_limestonecave_55_1.Id2", MonsterId.Charcoal_Walker_Green, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("d_limestonecave_55_1.Id3", MonsterId.Blindlem_Green, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("d_limestonecave_55_1.Id4", MonsterId.Charog_Green, min: 30, max: 40, tendency: TendencyType.Aggressive);
		AddSpawner("d_limestonecave_55_1.Id5", MonsterId.RavineLerva_Cave, min: 15, max: 20, respawn: TimeSpan.FromMilliseconds(2500), tendency: TendencyType.Aggressive);
		AddSpawner("d_limestonecave_55_1.Id6", MonsterId.Rootcrystal_04, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(30000), tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Charog_Green' GenType 1 Spawn Points
		AddSpawnPoint("d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Rectangle(-1798, 47, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Rectangle(-1607, 261, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Rectangle(-1613, 84, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Rectangle(-1090, -19, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Rectangle(-1023, -175, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Rectangle(-793, -283, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Rectangle(-740, -62, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Rectangle(-572, -734, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Rectangle(-550, -931, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Rectangle(-356, -985, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Rectangle(-178, -813, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Rectangle(-321, -819, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Rectangle(-1032, 806, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Rectangle(-884, 982, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Rectangle(-673, 826, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Rectangle(-880, 689, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Rectangle(-1006, 621, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Rectangle(-1441, 593, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Rectangle(-1824, 255, 40));

		// 'Charcoal_Walker_Green' GenType 2 Spawn Points
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(-45, 85, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(177, 437, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(458, 186, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(326, -146, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(144, 42, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(23, 320, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(-140, 233, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(496, -443, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(662, -784, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(806, -940, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(1022, -802, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(767, -635, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(823, -781, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(803, -62, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(1173, -210, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(1355, -157, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(1487, -321, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(1254, -452, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(1343, -414, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(1493, -537, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Rectangle(1602, -397, 40));

		// 'Blindlem_Green' GenType 3 Spawn Points
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(1344, 1007, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(1394, 615, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(1520, 784, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(1458, 921, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(636, 1518, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(701, 1757, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(799, 1595, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(53, 1606, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(-246, 1342, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(-109, 1644, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(181, 1346, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(57, -115, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(-100, 180, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(100, 510, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(532, 356, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(310, 249, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(581, 54, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(413, -96, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(15, 1278, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(128, 54, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(46, 393, 40));
		AddSpawnPoint("d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Rectangle(1278, 749, 40));

		// 'Charog_Green' GenType 4 Spawn Points
		AddSpawnPoint("d_limestonecave_55_1.Id4", "d_limestonecave_55_1", Rectangle(371, 278, 9999));

		// 'RavineLerva_Cave' GenType 5 Spawn Points
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(843, -1032, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(648, -794, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(649, -619, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(901, -576, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(1117, -783, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(1014, -851, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(830, -769, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(894, -934, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(962, -753, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(489, -546, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(449, -410, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(1710, -426, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(1654, -268, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(1541, -330, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(1348, -445, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(1182, -432, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(1433, -587, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(1510, -618, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(1691, -472, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(1377, -189, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(1150, -171, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(1264, -548, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Rectangle(1155, -331, 100));

		// 'Rootcrystal_04' GenType 17 Spawn Points
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(-1824, 225, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(-1510, 104, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(-1304, 681, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(-834, 826, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(-991, 931, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(-298, 1402, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(6, 1634, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(53, 1285, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(698, 1808, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(953, 1658, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(677, 1502, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(1113, 1217, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(207, 882, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(1459, 1059, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(1563, 699, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(1345, 729, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(157, 452, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(90, 42, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(284, -59, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(678, 324, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(593, 21, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(1657, -399, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(1372, -523, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(1207, -344, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(1409, -213, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(1132, -835, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(895, -610, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(646, -683, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(866, -1007, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(-184, -890, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(-269, -999, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(-523, -1036, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(-539, -728, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(-371, -843, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(-735, -174, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(-835, -334, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(-1032, -145, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(-811, -79, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(-362, 184, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(-618, -462, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(954, -142, 100));
		AddSpawnPoint("d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Rectangle(-544, 1216, 100));
	}
}
