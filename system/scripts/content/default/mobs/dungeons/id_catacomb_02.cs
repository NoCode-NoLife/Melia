//--- Melia Script -----------------------------------------------------------
// id_catacomb_02
//
//--- Description -----------------------------------------------------------
// Sets up the id_catacomb_02 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class IdCatacomb02MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("id_catacomb_02.Id1", MonsterId.Deadbornscab_Bow_Green, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("id_catacomb_02.Id2", MonsterId.Deadbornscab_Green, 6, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("id_catacomb_02.Id3", MonsterId.Pyran_Green, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("id_catacomb_02.Id4", MonsterId.Pyran_Green, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("id_catacomb_02.Id5", MonsterId.Rootcrystal_01, 13, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Deadbornscab_Bow_Green Spawn Points
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-2206.8745, -1449.9753, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-2173.1306, -1124.685, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-1877.223, -1141.9381, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-1967.5593, -1436.3685, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-1923.7684, -617.53094, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-1506.2163, -500.77365, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-1895.172, -438.64542, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-1948.5903, 286.32874, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-1145.682, 317.11798, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-232.43404, -755.55, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-234.07582, -1034.6196, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(36.075336, -786.8546, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(309.20886, -460.84207, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(294.62726, -1013.8564, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-1415.487, -479.3994, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-2072.3228, -1428.6577, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-2009.0101, -1141.3528, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-1930.7496, 27.931831, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-1604.1761, 367.18564, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-721.0568, 332.38336, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-951.244, 340.82062, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-1082.0317, 474.54654, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-1105.2501, -40.66524, 25));
		AddSpawnPoint( "id_catacomb_02.Id1", "id_catacomb_02", Spot(-1288.253, 322.12976, 25));

		// Deadbornscab_Green Spawn Points
		AddSpawnPoint( "id_catacomb_02.Id2", "id_catacomb_02", Spot(104.27712, 1310.7137, 30));
		AddSpawnPoint( "id_catacomb_02.Id2", "id_catacomb_02", Spot(333.40793, 1260.5486, 30));
		AddSpawnPoint( "id_catacomb_02.Id2", "id_catacomb_02", Spot(32.937565, 933.5506, 30));
		AddSpawnPoint( "id_catacomb_02.Id2", "id_catacomb_02", Spot(-208.35577, 997.085, 30));
		AddSpawnPoint( "id_catacomb_02.Id2", "id_catacomb_02", Spot(-210.45926, 1531.7358, 30));
		AddSpawnPoint( "id_catacomb_02.Id2", "id_catacomb_02", Spot(-161.50851, 1250.6129, 30));
		AddSpawnPoint( "id_catacomb_02.Id2", "id_catacomb_02", Spot(378.57782, 985.4429, 30));
		AddSpawnPoint( "id_catacomb_02.Id2", "id_catacomb_02", Spot(73.97392, 1508.4166, 30));
		AddSpawnPoint( "id_catacomb_02.Id2", "id_catacomb_02", Spot(387.61694, 1529.1296, 30));
		AddSpawnPoint( "id_catacomb_02.Id2", "id_catacomb_02", Spot(692.58344, 1563.8284, 30));

		// Pyran_Green Spawn Points
		AddSpawnPoint( "id_catacomb_02.Id3", "id_catacomb_02", Spot(-289.47296, -506.0708, 9999));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(1984.0942, 667.6775, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(2068.214, 806.1671, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(1901.0309, 756.3326, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(2156.1536, 602.87585, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(2081.5479, 1235.499, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(2029.7972, 1471.2462, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(1215.8392, 1526.0825, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(762.53973, 1474.2865, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(423.54248, 1559.0497, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(351.8955, 1338.3553, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(83.334435, 1250.8188, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(88.69253, 1511.9918, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(-369.98032, 1532.9271, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(-184.38562, 1189.998, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(384.6721, 1021.5825, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(39.002365, 996.06915, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(2425.0857, 1545.3785, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(3083.5806, 1240.7941, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(2955.2493, 1397.3239, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(3190.7478, 1360.0597, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(3109.2317, 1484.9136, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(3201.7815, 1672.5499, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(3265.4668, 1861.3103, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(3434.6936, 1842.1328, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(3297.7676, 2039.4609, 20));
		AddSpawnPoint( "id_catacomb_02.Id4", "id_catacomb_02", Spot(3444.313, 2005.6954, 20));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "id_catacomb_02.Id5", "id_catacomb_02", Spot(-728.22485, -1050.7921, 100));
		AddSpawnPoint( "id_catacomb_02.Id5", "id_catacomb_02", Spot(-527.24, -444.10147, 100));
		AddSpawnPoint( "id_catacomb_02.Id5", "id_catacomb_02", Spot(-25.750477, -723.7561, 100));
		AddSpawnPoint( "id_catacomb_02.Id5", "id_catacomb_02", Spot(-2224.518, -1159.9884, 100));
		AddSpawnPoint( "id_catacomb_02.Id5", "id_catacomb_02", Spot(-1955.507, -481.2277, 100));
		AddSpawnPoint( "id_catacomb_02.Id5", "id_catacomb_02", Spot(-1806.3463, 339.78748, 100));
		AddSpawnPoint( "id_catacomb_02.Id5", "id_catacomb_02", Spot(-1046.5482, 377.1038, 100));
		AddSpawnPoint( "id_catacomb_02.Id5", "id_catacomb_02", Spot(-435.06287, 1169.882, 100));
		AddSpawnPoint( "id_catacomb_02.Id5", "id_catacomb_02", Spot(78.86059, 1196.4287, 100));
		AddSpawnPoint( "id_catacomb_02.Id5", "id_catacomb_02", Spot(1773.8698, 328.37726, 100));
		AddSpawnPoint( "id_catacomb_02.Id5", "id_catacomb_02", Spot(2825.6404, 1427.7043, 100));
		AddSpawnPoint( "id_catacomb_02.Id5", "id_catacomb_02", Spot(1484.1049, 1553.8405, 100));
		AddSpawnPoint( "id_catacomb_02.Id5", "id_catacomb_02", Spot(-1072.6086, 1219.104, 100));

	}
}
