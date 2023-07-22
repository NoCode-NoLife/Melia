//--- Melia Script -----------------------------------------------------------
// Guards Graveyard Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'id_catacomb_01'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class IdCatacomb01MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("id_catacomb_01.Id1", MonsterId.FD_Leaf_Diving_Purple, min: 15, max: 20, respawn: TimeSpan.FromMilliseconds(10000), tendency: TendencyType.Aggressive);
		AddSpawner("id_catacomb_01.Id2", MonsterId.FD_Maggot, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(10000), tendency: TendencyType.Aggressive);
		AddSpawner("id_catacomb_01.Id3", MonsterId.FD_Mushcarfung, min: 15, max: 20, respawn: TimeSpan.FromMilliseconds(25000), tendency: TendencyType.Aggressive);
		AddSpawner("id_catacomb_01.Id4", MonsterId.FD_Candlespider, min: 15, max: 20, respawn: TimeSpan.FromMilliseconds(30000), tendency: TendencyType.Aggressive);
		AddSpawner("id_catacomb_01.Id5", MonsterId.Rootcrystal_01, min: 21, max: 28, respawn: TimeSpan.FromMilliseconds(5000), tendency: TendencyType.Peaceful);
		AddSpawner("id_catacomb_01.Id6", MonsterId.Cronewt_Bow_Brown, min: 9, max: 12, respawn: TimeSpan.FromMilliseconds(25000), tendency: TendencyType.Aggressive);
		AddSpawner("id_catacomb_01.Id7", MonsterId.Colifly_Bow_Purple, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(20000), tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'FD_Leaf_Diving_Purple' GenType 1 Spawn Points
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(25, -969, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(993, -735, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(-238, -1814, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(-207, -2521, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(-305, -2312, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(-417, -802, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(15, -530, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(1421, -995, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(1637, -715, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(482, -761, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(-246, -1248, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(-232, -2026, 50));

		// 'FD_Maggot' GenType 2 Spawn Points
		AddSpawnPoint("id_catacomb_01.Id2", "id_catacomb_01", Rectangle(-226, -2182, 500));
		AddSpawnPoint("id_catacomb_01.Id2", "id_catacomb_01", Rectangle(75, -1088, 500));
		AddSpawnPoint("id_catacomb_01.Id2", "id_catacomb_01", Rectangle(1403, -781, 500));
		AddSpawnPoint("id_catacomb_01.Id2", "id_catacomb_01", Rectangle(-440, -513, 500));

		// 'FD_Mushcarfung' GenType 3 Spawn Points
		AddSpawnPoint("id_catacomb_01.Id3", "id_catacomb_01", Rectangle(580, 2804, 40));
		AddSpawnPoint("id_catacomb_01.Id3", "id_catacomb_01", Rectangle(322, 2824, 40));
		AddSpawnPoint("id_catacomb_01.Id3", "id_catacomb_01", Rectangle(337, 2531, 40));
		AddSpawnPoint("id_catacomb_01.Id3", "id_catacomb_01", Rectangle(652, 2531, 40));
		AddSpawnPoint("id_catacomb_01.Id3", "id_catacomb_01", Rectangle(463, 2040, 40));
		AddSpawnPoint("id_catacomb_01.Id3", "id_catacomb_01", Rectangle(-93, 1919, 40));
		AddSpawnPoint("id_catacomb_01.Id3", "id_catacomb_01", Rectangle(-226, 1767, 40));
		AddSpawnPoint("id_catacomb_01.Id3", "id_catacomb_01", Rectangle(-527, 1422, 40));
		AddSpawnPoint("id_catacomb_01.Id3", "id_catacomb_01", Rectangle(-541, 876, 40));
		AddSpawnPoint("id_catacomb_01.Id3", "id_catacomb_01", Rectangle(55, 869, 40));
		AddSpawnPoint("id_catacomb_01.Id3", "id_catacomb_01", Rectangle(72, 1396, 40));
		AddSpawnPoint("id_catacomb_01.Id3", "id_catacomb_01", Rectangle(-245, 1385, 40));
		AddSpawnPoint("id_catacomb_01.Id3", "id_catacomb_01", Rectangle(-234, 1124, 40));
		AddSpawnPoint("id_catacomb_01.Id3", "id_catacomb_01", Rectangle(-237, 827, 40));

		// 'FD_Candlespider' GenType 4 Spawn Points
		AddSpawnPoint("id_catacomb_01.Id4", "id_catacomb_01", Rectangle(171, 1925, 1500));

		// 'Rootcrystal_01' GenType 600 Spawn Points
		AddSpawnPoint("id_catacomb_01.Id5", "id_catacomb_01", Rectangle(-243, -3206, 30));
		AddSpawnPoint("id_catacomb_01.Id5", "id_catacomb_01", Rectangle(-125, -2422, 30));
		AddSpawnPoint("id_catacomb_01.Id5", "id_catacomb_01", Rectangle(-188, -1148, 30));
		AddSpawnPoint("id_catacomb_01.Id5", "id_catacomb_01", Rectangle(1126, -730, 30));
		AddSpawnPoint("id_catacomb_01.Id5", "id_catacomb_01", Rectangle(1661, -766, 30));
		AddSpawnPoint("id_catacomb_01.Id5", "id_catacomb_01", Rectangle(49, 1178, 30));
		AddSpawnPoint("id_catacomb_01.Id5", "id_catacomb_01", Rectangle(454, 1889, 30));

		// 'Cronewt_Bow_Brown' GenType 614 Spawn Points
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(-193, -1043, 30));
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(79, -778, 30));
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(-242, -739, 30));
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(-542, -768, 30));
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(-310, -2417, 30));
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(-128, -2301, 30));
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(-158, -2575, 30));
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(1442, -738, 30));
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(1649, -718, 30));
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(1618, -996, 30));
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(1353, -980, 30));

		// 'Colifly_Bow_Purple' GenType 615 Spawn Points
		AddSpawnPoint("id_catacomb_01.Id7", "id_catacomb_01", Rectangle(-211, 1412, 35));
		AddSpawnPoint("id_catacomb_01.Id7", "id_catacomb_01", Rectangle(-187, 1119, 35));
		AddSpawnPoint("id_catacomb_01.Id7", "id_catacomb_01", Rectangle(-262, 826, 35));
		AddSpawnPoint("id_catacomb_01.Id7", "id_catacomb_01", Rectangle(-86, 1892, 35));
		AddSpawnPoint("id_catacomb_01.Id7", "id_catacomb_01", Rectangle(392, 2513, 35));
		AddSpawnPoint("id_catacomb_01.Id7", "id_catacomb_01", Rectangle(635, 2443, 35));
		AddSpawnPoint("id_catacomb_01.Id7", "id_catacomb_01", Rectangle(396, 2730, 35));
		AddSpawnPoint("id_catacomb_01.Id7", "id_catacomb_01", Rectangle(428, 1964, 35));
	}
}
