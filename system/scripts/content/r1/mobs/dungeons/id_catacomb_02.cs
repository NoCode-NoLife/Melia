//--- Melia Script -----------------------------------------------------------
// id_catacomb_02
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Valius' Eternal Resting Place' map.
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
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(-728.22485, -1050.7921, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(-527.24, -444.10147, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(-25.750477, -723.7561, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(-2224.518, -1159.9884, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(-1955.507, -481.2277, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(-1806.3463, 339.78748, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(-1046.5482, 377.1038, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(-435.06287, 1169.882, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(78.86059, 1196.4287, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(1773.8698, 328.37726, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(2825.6404, 1427.7043, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(1484.1049, 1553.8405, 100));
		AddSpawnPoint("id_catacomb_02.Id1", "id_catacomb_02", Rectangle(-1072.6086, 1219.104, 100));

		// 'Deadbornscab_Bow_Green' GenType 30 Spawn Points
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-2206.8745, -1449.9753, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-2173.1306, -1124.685, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1877.223, -1141.9381, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1967.5593, -1436.3685, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1923.7684, -617.53094, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1506.2163, -500.77365, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1895.172, -438.64542, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1948.5903, 286.32874, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1145.682, 317.11798, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-232.43404, -755.55, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-234.07582, -1034.6196, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(36.075336, -786.8546, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(309.20886, -460.84207, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(294.62726, -1013.8564, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1415.487, -479.3994, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-2072.3228, -1428.6577, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-2009.0101, -1141.3528, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1930.7496, 27.931831, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1604.1761, 367.18564, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-721.0568, 332.38336, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-951.244, 340.82062, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1082.0317, 474.54654, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1105.2501, -40.66524, 25));
		AddSpawnPoint("id_catacomb_02.Id2", "id_catacomb_02", Rectangle(-1288.253, 322.12976, 25));

		// 'Deadbornscab_Green' GenType 31 Spawn Points
		AddSpawnPoint("id_catacomb_02.Id3", "id_catacomb_02", Rectangle(104.27712, 1310.7137, 30));
		AddSpawnPoint("id_catacomb_02.Id3", "id_catacomb_02", Rectangle(333.40793, 1260.5486, 30));
		AddSpawnPoint("id_catacomb_02.Id3", "id_catacomb_02", Rectangle(32.937565, 933.5506, 30));
		AddSpawnPoint("id_catacomb_02.Id3", "id_catacomb_02", Rectangle(-208.35577, 997.085, 30));
		AddSpawnPoint("id_catacomb_02.Id3", "id_catacomb_02", Rectangle(-210.45926, 1531.7358, 30));
		AddSpawnPoint("id_catacomb_02.Id3", "id_catacomb_02", Rectangle(-161.50851, 1250.6129, 30));
		AddSpawnPoint("id_catacomb_02.Id3", "id_catacomb_02", Rectangle(378.57782, 985.4429, 30));
		AddSpawnPoint("id_catacomb_02.Id3", "id_catacomb_02", Rectangle(73.97392, 1508.4166, 30));
		AddSpawnPoint("id_catacomb_02.Id3", "id_catacomb_02", Rectangle(387.61694, 1529.1296, 30));
		AddSpawnPoint("id_catacomb_02.Id3", "id_catacomb_02", Rectangle(692.58344, 1563.8284, 30));

		// 'Pyran_Green' GenType 32 Spawn Points
		AddSpawnPoint("id_catacomb_02.Id4", "id_catacomb_02", Rectangle(-289.47296, -506.0708, 9999));

		// 'Pyran_Green' GenType 35 Spawn Points
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(1984.0942, 667.6775, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(2068.214, 806.1671, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(1901.0309, 756.3326, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(2156.1536, 602.87585, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(2081.5479, 1235.499, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(2029.7972, 1471.2462, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(1215.8392, 1526.0825, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(762.53973, 1474.2865, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(423.54248, 1559.0497, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(351.8955, 1338.3553, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(83.334435, 1250.8188, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(88.69253, 1511.9918, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(-369.98032, 1532.9271, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(-184.38562, 1189.998, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(384.6721, 1021.5825, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(39.002365, 996.06915, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(2425.0857, 1545.3785, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(3083.5806, 1240.7941, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(2955.2493, 1397.3239, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(3190.7478, 1360.0597, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(3109.2317, 1484.9136, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(3201.7815, 1672.5499, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(3265.4668, 1861.3103, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(3434.6936, 1842.1328, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(3297.7676, 2039.4609, 20));
		AddSpawnPoint("id_catacomb_02.Id5", "id_catacomb_02", Rectangle(3444.313, 2005.6954, 20));
	}
}
