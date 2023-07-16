//--- Melia Script -----------------------------------------------------------
// id_catacomb_01
//
//--- Description -----------------------------------------------------------
// Sets up the id_catacomb_01 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class IdCatacomb01MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("id_catacomb_01.Id1", MonsterId.FD_Mushcarfung, 20, TimeSpan.FromMilliseconds(25000), TendencyType.Aggressive);
		AddSpawner("id_catacomb_01.Id2", MonsterId.FD_Candlespider, 20, TimeSpan.FromMilliseconds(30000), TendencyType.Aggressive);
		AddSpawner("id_catacomb_01.Id3", MonsterId.Rootcrystal_01, 28, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("id_catacomb_01.Id4", MonsterId.FD_Maggot, 15, TimeSpan.FromMilliseconds(10000), TendencyType.Aggressive);
		AddSpawner("id_catacomb_01.Id5", MonsterId.FD_Leaf_Diving_Purple, 20, TimeSpan.FromMilliseconds(10000), TendencyType.Aggressive);
		AddSpawner("id_catacomb_01.Id6", MonsterId.Cronewt_Bow_Brown, 12, TimeSpan.FromMilliseconds(25000), TendencyType.Aggressive);
		AddSpawner("id_catacomb_01.Id7", MonsterId.Colifly_Bow_Purple, 15, TimeSpan.FromMilliseconds(20000), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// FD_Mushcarfung Spawn Points
		AddSpawnPoint( "id_catacomb_01.Id1", "id_catacomb_01", Spot(580, 2804, 40));
		AddSpawnPoint( "id_catacomb_01.Id1", "id_catacomb_01", Spot(322, 2824, 40));
		AddSpawnPoint( "id_catacomb_01.Id1", "id_catacomb_01", Spot(337, 2531, 40));
		AddSpawnPoint( "id_catacomb_01.Id1", "id_catacomb_01", Spot(652, 2531, 40));
		AddSpawnPoint( "id_catacomb_01.Id1", "id_catacomb_01", Spot(463, 2040, 40));
		AddSpawnPoint( "id_catacomb_01.Id1", "id_catacomb_01", Spot(-93, 1919, 40));
		AddSpawnPoint( "id_catacomb_01.Id1", "id_catacomb_01", Spot(-226, 1767, 40));
		AddSpawnPoint( "id_catacomb_01.Id1", "id_catacomb_01", Spot(-527, 1422, 40));
		AddSpawnPoint( "id_catacomb_01.Id1", "id_catacomb_01", Spot(-541, 876, 40));
		AddSpawnPoint( "id_catacomb_01.Id1", "id_catacomb_01", Spot(55, 869, 40));
		AddSpawnPoint( "id_catacomb_01.Id1", "id_catacomb_01", Spot(72.423775, 1396.1799, 40));
		AddSpawnPoint( "id_catacomb_01.Id1", "id_catacomb_01", Spot(-245, 1385, 40));
		AddSpawnPoint( "id_catacomb_01.Id1", "id_catacomb_01", Spot(-234, 1124, 40));
		AddSpawnPoint( "id_catacomb_01.Id1", "id_catacomb_01", Spot(-237, 827, 40));

		// FD_Candlespider Spawn Points
		AddSpawnPoint( "id_catacomb_01.Id2", "id_catacomb_01", Spot(171.16058, 1925.6389, 1500));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "id_catacomb_01.Id3", "id_catacomb_01", Spot(-243, -3206, 30));
		AddSpawnPoint( "id_catacomb_01.Id3", "id_catacomb_01", Spot(-125, -2422, 30));
		AddSpawnPoint( "id_catacomb_01.Id3", "id_catacomb_01", Spot(-188, -1148, 30));
		AddSpawnPoint( "id_catacomb_01.Id3", "id_catacomb_01", Spot(1126, -730, 30));
		AddSpawnPoint( "id_catacomb_01.Id3", "id_catacomb_01", Spot(1661.2123, -766.8322, 30));
		AddSpawnPoint( "id_catacomb_01.Id3", "id_catacomb_01", Spot(49, 1178, 30));
		AddSpawnPoint( "id_catacomb_01.Id3", "id_catacomb_01", Spot(454, 1889, 30));

		// FD_Maggot Spawn Points
		AddSpawnPoint( "id_catacomb_01.Id4", "id_catacomb_01", Spot(-226.08269, -2182.7214, 500));
		AddSpawnPoint( "id_catacomb_01.Id4", "id_catacomb_01", Spot(75.04292, -1088.9226, 500));
		AddSpawnPoint( "id_catacomb_01.Id4", "id_catacomb_01", Spot(1403.7295, -781.1569, 500));
		AddSpawnPoint( "id_catacomb_01.Id4", "id_catacomb_01", Spot(-440.2174, -513.6892, 500));

		// FD_Leaf_Diving_Purple Spawn Points
		AddSpawnPoint( "id_catacomb_01.Id5", "id_catacomb_01", Spot(25.099253, -969.2064, 50));
		AddSpawnPoint( "id_catacomb_01.Id5", "id_catacomb_01", Spot(993.1435, -735.9285, 50));
		AddSpawnPoint( "id_catacomb_01.Id5", "id_catacomb_01", Spot(-238.0458, -1814.5244, 50));
		AddSpawnPoint( "id_catacomb_01.Id5", "id_catacomb_01", Spot(-207.67003, -2521.1575, 50));
		AddSpawnPoint( "id_catacomb_01.Id5", "id_catacomb_01", Spot(-305.288, -2312.8325, 50));
		AddSpawnPoint( "id_catacomb_01.Id5", "id_catacomb_01", Spot(-417.5073, -802.3178, 50));
		AddSpawnPoint( "id_catacomb_01.Id5", "id_catacomb_01", Spot(15.577894, -530.9457, 50));
		AddSpawnPoint( "id_catacomb_01.Id5", "id_catacomb_01", Spot(1421.3363, -995.4134, 50));
		AddSpawnPoint( "id_catacomb_01.Id5", "id_catacomb_01", Spot(1637.6654, -715.1979, 50));
		AddSpawnPoint( "id_catacomb_01.Id5", "id_catacomb_01", Spot(482.4153, -761.3024, 50));
		AddSpawnPoint( "id_catacomb_01.Id5", "id_catacomb_01", Spot(-246.76855, -1248.5411, 50));
		AddSpawnPoint( "id_catacomb_01.Id5", "id_catacomb_01", Spot(-232.76605, -2026.767, 50));

		// Cronewt_Bow_Brown Spawn Points
		AddSpawnPoint( "id_catacomb_01.Id6", "id_catacomb_01", Spot(-193.52856, -1043.9053, 30));
		AddSpawnPoint( "id_catacomb_01.Id6", "id_catacomb_01", Spot(79.43886, -778.56335, 30));
		AddSpawnPoint( "id_catacomb_01.Id6", "id_catacomb_01", Spot(-242.41203, -739.8254, 30));
		AddSpawnPoint( "id_catacomb_01.Id6", "id_catacomb_01", Spot(-542.6846, -768.84863, 30));
		AddSpawnPoint( "id_catacomb_01.Id6", "id_catacomb_01", Spot(-310.9554, -2417.616, 30));
		AddSpawnPoint( "id_catacomb_01.Id6", "id_catacomb_01", Spot(-128.50162, -2301.7847, 30));
		AddSpawnPoint( "id_catacomb_01.Id6", "id_catacomb_01", Spot(-158.57544, -2575.3152, 30));
		AddSpawnPoint( "id_catacomb_01.Id6", "id_catacomb_01", Spot(1442.3303, -738.5314, 30));
		AddSpawnPoint( "id_catacomb_01.Id6", "id_catacomb_01", Spot(1649.2509, -718.18195, 30));
		AddSpawnPoint( "id_catacomb_01.Id6", "id_catacomb_01", Spot(1618.3103, -996.1, 30));
		AddSpawnPoint( "id_catacomb_01.Id6", "id_catacomb_01", Spot(1353.556, -980.2737, 30));

		// Colifly_Bow_Purple Spawn Points
		AddSpawnPoint( "id_catacomb_01.Id7", "id_catacomb_01", Spot(-211.85512, 1412.2667, 35));
		AddSpawnPoint( "id_catacomb_01.Id7", "id_catacomb_01", Spot(-187.05127, 1119.0054, 35));
		AddSpawnPoint( "id_catacomb_01.Id7", "id_catacomb_01", Spot(-262.45566, 826.97723, 35));
		AddSpawnPoint( "id_catacomb_01.Id7", "id_catacomb_01", Spot(-86.748405, 1892.8483, 35));
		AddSpawnPoint( "id_catacomb_01.Id7", "id_catacomb_01", Spot(392.02155, 2513.5105, 35));
		AddSpawnPoint( "id_catacomb_01.Id7", "id_catacomb_01", Spot(635.2765, 2443.142, 35));
		AddSpawnPoint( "id_catacomb_01.Id7", "id_catacomb_01", Spot(396.5722, 2730.326, 35));
		AddSpawnPoint( "id_catacomb_01.Id7", "id_catacomb_01", Spot(428.67487, 1964.5251, 35));

	}
}
