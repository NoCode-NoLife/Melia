//--- Melia Script -----------------------------------------------------------
// Valius' Eternal Resting Place Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'id_catacomb_02'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class IdCatacomb02MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("id_catacomb_02.Id1", MonsterId.Rootcrystal_01, 10, 13, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("id_catacomb_02.Id2", MonsterId.Deadbornscab_Bow_Green, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("id_catacomb_02.Id3", MonsterId.Deadbornscab_Green, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("id_catacomb_02.Id4", MonsterId.Pyran_Green, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("id_catacomb_02.Id5", MonsterId.Pyran_Green, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 3 Spawn Points
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(-728, -1050, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(-527, -444, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(-25, -723, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(-2224, -1159, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(-1955, -481, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(-1806, 339, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(-1046, 377, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(-435, 1169, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(78, 1196, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(1773, 328, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(2825, 1427, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(1484, 1553, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(-1072, 1219, 100));

		// 'Deadbornscab_Bow_Green' GenType 30 Spawn Points
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-2206, -1449, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-2173, -1124, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1877, -1141, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1967, -1436, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1923, -617, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1506, -500, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1895, -438, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1948, 286, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1145, 317, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-232, -755, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-234, -1034, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(36, -786, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(309, -460, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(294, -1013, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1415, -479, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-2072, -1428, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-2009, -1141, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1930, 27, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1604, 367, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-721, 332, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-951, 340, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1082, 474, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1105, -40, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1288, 322, 25));

		// 'Deadbornscab_Green' GenType 31 Spawn Points
		AddSpawnPoint("id_catacomb_02.Id3", "id_catacomb_02", Rectangle(104, 1310, 30));
		AddSpawnPoint("id_catacomb_02.Id3", "id_catacomb_02", Rectangle(333, 1260, 30));
		AddSpawnPoint("id_catacomb_02.Id3", "id_catacomb_02", Rectangle(32, 933, 30));
		AddSpawnPoint("id_catacomb_02.Id3", "id_catacomb_02", Rectangle(-208, 997, 30));
		AddSpawnPoint("id_catacomb_02.Id3", "id_catacomb_02", Rectangle(-210, 1531, 30));
		AddSpawnPoint("id_catacomb_02.Id3", "id_catacomb_02", Rectangle(-161, 1250, 30));
		AddSpawnPoint("id_catacomb_02.Id3", "id_catacomb_02", Rectangle(378, 985, 30));
		AddSpawnPoint("id_catacomb_02.Id3", "id_catacomb_02", Rectangle(73, 1508, 30));
		AddSpawnPoint("id_catacomb_02.Id3", "id_catacomb_02", Rectangle(387, 1529, 30));
		AddSpawnPoint("id_catacomb_02.Id3", "id_catacomb_02", Rectangle(692, 1563, 30));

		// 'Pyran_Green' GenType 32 Spawn Points
		AddSpawnPoint("id_catacomb_02.Id4", "id_catacomb_02", Rectangle(-289, -506, 9999));

		// 'Pyran_Green' GenType 35 Spawn Points
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(1984, 667, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(2068, 806, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(1901, 756, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(2156, 602, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(2081, 1235, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(2029, 1471, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(1215, 1526, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(762, 1474, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(423, 1559, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(351, 1338, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(83, 1250, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(88, 1511, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(-369, 1532, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(-184, 1189, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(384, 1021, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(39, 996, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(2425, 1545, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(3083, 1240, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(2955, 1397, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(3190, 1360, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(3109, 1484, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(3201, 1672, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(3265, 1861, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(3434, 1842, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(3297, 2039, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(3444, 2005, 20));
	}
}
