//--- Melia Script -----------------------------------------------------------
// id_catacomb_01
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Guards Graveyard' map.
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

		AddSpawner("id_catacomb_01.Id1", MonsterId.FD_Leaf_Diving_Purple, 15, 20, TimeSpan.FromMilliseconds(10000), TendencyType.Aggressive);
		AddSpawner("id_catacomb_01.Id2", MonsterId.FD_Maggot, 12, 15, TimeSpan.FromMilliseconds(10000), TendencyType.Aggressive);
		AddSpawner("id_catacomb_01.Id3", MonsterId.FD_Mushcarfung, 15, 20, TimeSpan.FromMilliseconds(25000), TendencyType.Aggressive);
		AddSpawner("id_catacomb_01.Id4", MonsterId.FD_Candlespider, 15, 20, TimeSpan.FromMilliseconds(30000), TendencyType.Aggressive);
		AddSpawner("id_catacomb_01.Id5", MonsterId.Rootcrystal_01, 21, 28, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("id_catacomb_01.Id6", MonsterId.Cronewt_Bow_Brown, 9, 12, TimeSpan.FromMilliseconds(25000), TendencyType.Aggressive);
		AddSpawner("id_catacomb_01.Id7", MonsterId.Colifly_Bow_Purple, 12, 15, TimeSpan.FromMilliseconds(20000), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'FD_Leaf_Diving_Purple' GenType 1 Spawn Points
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(25.099253, -969.2064, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(993.1435, -735.9285, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(-238.0458, -1814.5244, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(-207.67003, -2521.1575, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(-305.288, -2312.8325, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(-417.5073, -802.3178, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(15.577894, -530.9457, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(1421.3363, -995.4134, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(1637.6654, -715.1979, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(482.4153, -761.3024, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(-246.76855, -1248.5411, 50));
		AddSpawnPoint("id_catacomb_01.Id1", "id_catacomb_01", Rectangle(-232.76605, -2026.767, 50));

		// 'FD_Maggot' GenType 2 Spawn Points
		AddSpawnPoint("id_catacomb_01.Id2", "id_catacomb_01", Rectangle(-226.08269, -2182.7214, 500));
		AddSpawnPoint("id_catacomb_01.Id2", "id_catacomb_01", Rectangle(75.04292, -1088.9226, 500));
		AddSpawnPoint("id_catacomb_01.Id2", "id_catacomb_01", Rectangle(1403.7295, -781.1569, 500));
		AddSpawnPoint("id_catacomb_01.Id2", "id_catacomb_01", Rectangle(-440.2174, -513.6892, 500));

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
		AddSpawnPoint("id_catacomb_01.Id3", "id_catacomb_01", Rectangle(72.423775, 1396.1799, 40));
		AddSpawnPoint("id_catacomb_01.Id3", "id_catacomb_01", Rectangle(-245, 1385, 40));
		AddSpawnPoint("id_catacomb_01.Id3", "id_catacomb_01", Rectangle(-234, 1124, 40));
		AddSpawnPoint("id_catacomb_01.Id3", "id_catacomb_01", Rectangle(-237, 827, 40));

		// 'FD_Candlespider' GenType 4 Spawn Points
		AddSpawnPoint("id_catacomb_01.Id4", "id_catacomb_01", Rectangle(171.16058, 1925.6389, 1500));

		// 'Rootcrystal_01' GenType 600 Spawn Points
		AddSpawnPoint("id_catacomb_01.Id5", "id_catacomb_01", Rectangle(-243, -3206, 30));
		AddSpawnPoint("id_catacomb_01.Id5", "id_catacomb_01", Rectangle(-125, -2422, 30));
		AddSpawnPoint("id_catacomb_01.Id5", "id_catacomb_01", Rectangle(-188, -1148, 30));
		AddSpawnPoint("id_catacomb_01.Id5", "id_catacomb_01", Rectangle(1126, -730, 30));
		AddSpawnPoint("id_catacomb_01.Id5", "id_catacomb_01", Rectangle(1661.2123, -766.8322, 30));
		AddSpawnPoint("id_catacomb_01.Id5", "id_catacomb_01", Rectangle(49, 1178, 30));
		AddSpawnPoint("id_catacomb_01.Id5", "id_catacomb_01", Rectangle(454, 1889, 30));

		// 'Cronewt_Bow_Brown' GenType 614 Spawn Points
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(-193.52856, -1043.9053, 30));
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(79.43886, -778.56335, 30));
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(-242.41203, -739.8254, 30));
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(-542.6846, -768.84863, 30));
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(-310.9554, -2417.616, 30));
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(-128.50162, -2301.7847, 30));
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(-158.57544, -2575.3152, 30));
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(1442.3303, -738.5314, 30));
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(1649.2509, -718.18195, 30));
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(1618.3103, -996.1, 30));
		AddSpawnPoint("id_catacomb_01.Id6", "id_catacomb_01", Rectangle(1353.556, -980.2737, 30));

		// 'Colifly_Bow_Purple' GenType 615 Spawn Points
		AddSpawnPoint("id_catacomb_01.Id7", "id_catacomb_01", Rectangle(-211.85512, 1412.2667, 35));
		AddSpawnPoint("id_catacomb_01.Id7", "id_catacomb_01", Rectangle(-187.05127, 1119.0054, 35));
		AddSpawnPoint("id_catacomb_01.Id7", "id_catacomb_01", Rectangle(-262.45566, 826.97723, 35));
		AddSpawnPoint("id_catacomb_01.Id7", "id_catacomb_01", Rectangle(-86.748405, 1892.8483, 35));
		AddSpawnPoint("id_catacomb_01.Id7", "id_catacomb_01", Rectangle(392.02155, 2513.5105, 35));
		AddSpawnPoint("id_catacomb_01.Id7", "id_catacomb_01", Rectangle(635.2765, 2443.142, 35));
		AddSpawnPoint("id_catacomb_01.Id7", "id_catacomb_01", Rectangle(396.5722, 2730.326, 35));
		AddSpawnPoint("id_catacomb_01.Id7", "id_catacomb_01", Rectangle(428.67487, 1964.5251, 35));
	}
}
