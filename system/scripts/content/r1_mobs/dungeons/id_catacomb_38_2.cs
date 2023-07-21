//--- Melia Script -----------------------------------------------------------
// Mokusul Chamber Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'id_catacomb_38_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class IdCatacomb382MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("id_catacomb_38_2.Id1", MonsterId.Rootcrystal_01, 9, 11, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("id_catacomb_38_2.Id2", MonsterId.Rambear_Mage, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("id_catacomb_38_2.Id3", MonsterId.Ticen_Bow, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("id_catacomb_38_2.Id4", MonsterId.Hepatica_Purple, 21, 28, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 4 Spawn Points
		AddSpawnPoint("id_catacomb_38_2.Id1", "id_catacomb_38_2", Rectangle(1038, -869, 150));
		AddSpawnPoint("id_catacomb_38_2.Id1", "id_catacomb_38_2", Rectangle(1456, -627, 150));
		AddSpawnPoint("id_catacomb_38_2.Id1", "id_catacomb_38_2", Rectangle(2224, -85, 150));
		AddSpawnPoint("id_catacomb_38_2.Id1", "id_catacomb_38_2", Rectangle(-176, -1712, 150));
		AddSpawnPoint("id_catacomb_38_2.Id1", "id_catacomb_38_2", Rectangle(257, -783, 150));
		AddSpawnPoint("id_catacomb_38_2.Id1", "id_catacomb_38_2", Rectangle(-346, -536, 150));
		AddSpawnPoint("id_catacomb_38_2.Id1", "id_catacomb_38_2", Rectangle(7, 441, 150));
		AddSpawnPoint("id_catacomb_38_2.Id1", "id_catacomb_38_2", Rectangle(-178, 1160, 150));
		AddSpawnPoint("id_catacomb_38_2.Id1", "id_catacomb_38_2", Rectangle(243, 1550, 150));
		AddSpawnPoint("id_catacomb_38_2.Id1", "id_catacomb_38_2", Rectangle(-2163, -444, 150));
		AddSpawnPoint("id_catacomb_38_2.Id1", "id_catacomb_38_2", Rectangle(-1078, -756, 150));

		// 'Rambear_Mage' GenType 15 Spawn Points
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(-118, -1390, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(-245, -1445, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(-273, -1751, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(70, -1747, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(74, -1494, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(-113, -1804, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(-1351, -602, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(-1091, -565, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(-1219, -671, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(-1025, -785, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(-2222, -677, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(-2219, -419, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(-2012, -695, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(-160, -764, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(230, -371, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(207, -952, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(-43, -736, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(-245, -340, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(-41, -558, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(1088, -688, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(1274, -578, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(1239, -860, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(1953, -66, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(2120, 252, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(2214, 32, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(852, -701, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(39, 422, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(-160, 362, 25));
		AddSpawnPoint("id_catacomb_38_2.Id2", "id_catacomb_38_2", Rectangle(-2080, -525, 25));

		// 'Ticen_Bow' GenType 16 Spawn Points
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(1045, -753, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(1174, -496, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(1390, -837, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(1871, -273, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(2004, 105, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(2186, -213, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(2216, -1, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(2380, 204, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(-42, -417, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(-14, -923, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(-283, -685, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(177, -669, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(2172, 360, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(-87, 327, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(-227, 450, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(4, 527, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(27, 366, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(167, 250, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(-67, -682, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(-275, -941, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(236, -937, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(225, -376, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(-279, -341, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(1298, -703, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(1434, -534, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(2056, -105, 30));
		AddSpawnPoint("id_catacomb_38_2.Id3", "id_catacomb_38_2", Rectangle(2007, 343, 30));

		// 'Hepatica_Purple' GenType 17 Spawn Points
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(-329, 1078, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(-308, 377, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(-328, 192, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(253, 193, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(264, 509, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(-97, -200, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(106, -214, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(-431, -626, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(-431, -874, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(468, -772, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(852, -769, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(1346, -377, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(1413, -380, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(2359, -326, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(2431, -170, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(-1361, -957, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(-857, -791, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(-1312, -477, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(-1226, -464, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(-1379, -480, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(-2370, -314, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(-2467, -689, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(-1834, -797, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(-549, -1371, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(-472, -1502, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(-330, -1326, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(62, -1339, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(1621, -94, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(1831, 484, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(1944, 494, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(2154, 505, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(2419, 405, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(962, -539, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(944, -483, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(178, -411, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(-251, -411, 20));
		AddSpawnPoint("id_catacomb_38_2.Id4", "id_catacomb_38_2", Rectangle(-249, -878, 20));
	}
}
