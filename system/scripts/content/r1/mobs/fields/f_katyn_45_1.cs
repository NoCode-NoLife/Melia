//--- Melia Script -----------------------------------------------------------
// Grynas Trails Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_katyn_45_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn451MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_katyn_45_1.Id1", MonsterId.Stoulet_Bow_Blue, min: 38, max: 50, tendency: TendencyType.Peaceful);
		AddSpawner("f_katyn_45_1.Id2", MonsterId.Socket_Green, min: 9, max: 12, tendency: TendencyType.Peaceful);
		AddSpawner("f_katyn_45_1.Id3", MonsterId.Socket_Mage_Green, min: 9, max: 12, tendency: TendencyType.Aggressive);
		AddSpawner("f_katyn_45_1.Id4", MonsterId.Socket_Green, min: 8, max: 10, tendency: TendencyType.Peaceful);
		AddSpawner("f_katyn_45_1.Id5", MonsterId.Rootcrystal_04, min: 15, max: 19, respawn: TimeSpan.FromMilliseconds(30000), tendency: TendencyType.Peaceful);
		AddSpawner("f_katyn_45_1.Id6", MonsterId.Stoulet_Gray, min: 12, max: 15, tendency: TendencyType.Peaceful);
		AddSpawner("f_katyn_45_1.Id7", MonsterId.Stoulet_Bow_Blue, min: 30, max: 40, tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Stoulet_Bow_Blue' GenType 1 Spawn Points
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-804, 375, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-805, -61, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-1023, -395, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-789, -391, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-823, -760, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-1058, -1205, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-755, -1253, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-337, -1233, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-83, -747, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-101, -1064, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(218, -1091, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(647, -938, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(330, -595, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(713, -583, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(651, -79, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(647, 300, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(268, 427, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-66, 413, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-435, 437, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-405, 181, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(920, -554, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(375, -1017, 30));

		// 'Socket_Green' GenType 2 Spawn Points
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-969, -357, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-1331, -474, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-810, -715, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-761, -15, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-1505, 401, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-1872, 386, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-1659, 583, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-1174, 614, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-906, 702, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-715, 292, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-439, 364, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-400, 91, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-205, 221, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-166, 213, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(334, 245, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-884, -1113, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-763, -1232, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-1108, -1246, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-928, -1417, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-315, -1287, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-73, -1165, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-181, -1024, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-63, -1053, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-9, -900, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(236, -932, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(364, -1075, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(425, -806, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(599, -577, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(667, -427, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-261, 454, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-70, 405, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(514, 377, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(638, 114, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(755, 380, 30));

		// 'Socket_Mage_Green' GenType 8 Spawn Points
		AddSpawnPoint("f_katyn_45_1.Id3", "f_katyn_45_1", Rectangle(-573, 236, 9999));

		// 'Socket_Green' GenType 9 Spawn Points
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1523, -804, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1730, -473, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1352, -592, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1523, -361, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1393, -726, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1715, -754, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1223, -463, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-809, -88, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-811, -419, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-863, 133, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-930, 421, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1804, 320, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1703, 521, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1554, 395, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1687, 702, 30));

		// 'Rootcrystal_04' GenType 14 Spawn Points
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(-1722, -595, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(-1090, -458, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(-762, -976, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(-894, 467, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(-1763, 464, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(-318, 437, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(392, 351, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(1123, 784, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(907, 358, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(574, -36, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(922, -165, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(908, -450, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(415, -654, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(682, -833, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(302, -1139, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(-112, -847, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(-323, -1174, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(-1020, -1392, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(-851, -340, 50));

		// 'Stoulet_Gray' GenType 18 Spawn Points
		AddSpawnPoint("f_katyn_45_1.Id6", "f_katyn_45_1", Rectangle(-442, 371, 9999));

		// 'Stoulet_Bow_Blue' GenType 19 Spawn Points
		AddSpawnPoint("f_katyn_45_1.Id7", "f_katyn_45_1", Rectangle(-340, 233, 9999));
	}
}
