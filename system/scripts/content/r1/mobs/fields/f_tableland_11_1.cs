//--- Melia Script -----------------------------------------------------------
// Vedas Plateau Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_tableland_11_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FTableland111MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_tableland_11_1.Id1", MonsterId.Saltisdaughter_Red, min: 23, max: 30, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("f_tableland_11_1.Id2", MonsterId.Saltisdaughter_Bow_Green, min: 15, max: 20, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("f_tableland_11_1.Id3", MonsterId.Repusbunny_Mage_Green, min: 15, max: 20, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("f_tableland_11_1.Id4", MonsterId.Groll_White, min: 19, max: 25, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("f_tableland_11_1.Id5", MonsterId.Groll_White, min: 30, max: 40, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("f_tableland_11_1.Id6", MonsterId.Rootcrystal_01, min: 14, max: 18, respawn: TimeSpan.FromMilliseconds(60000));

		// Monster Spawn Points -----------------------------

		// 'Saltisdaughter_Red' GenType 7 Spawn Points
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(-158, -92, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(-62, 1309, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(19, -131, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(-198, 1206, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(46, 1266, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(-92, 1106, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(270, 1085, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(688, 580, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(749, 736, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(1058, 515, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(1020, 420, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(887, 583, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(802, 167, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(503, 88, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(113, -225, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(-51, 122, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(-246, -83, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(-171, 72, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(254, -4, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(-361, -280, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(-461, -112, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(-76, -131, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(83, -73, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(241, -169, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(1034, 644, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(1099, 393, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(179, 1308, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(95, 1046, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(-156, 1375, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(136, 1147, 30));
		AddSpawnPoint("f_tableland_11_1.Id1", "f_tableland_11_1", Rectangle(352, 934, 30));

		// 'Saltisdaughter_Bow_Green' GenType 8 Spawn Points
		AddSpawnPoint("f_tableland_11_1.Id2", "f_tableland_11_1", Rectangle(-125, 1188, 30));
		AddSpawnPoint("f_tableland_11_1.Id2", "f_tableland_11_1", Rectangle(148, 1165, 30));
		AddSpawnPoint("f_tableland_11_1.Id2", "f_tableland_11_1", Rectangle(-266, -255, 30));
		AddSpawnPoint("f_tableland_11_1.Id2", "f_tableland_11_1", Rectangle(-117, 5, 30));
		AddSpawnPoint("f_tableland_11_1.Id2", "f_tableland_11_1", Rectangle(132, -120, 30));
		AddSpawnPoint("f_tableland_11_1.Id2", "f_tableland_11_1", Rectangle(705, 673, 30));
		AddSpawnPoint("f_tableland_11_1.Id2", "f_tableland_11_1", Rectangle(1003, 507, 30));
		AddSpawnPoint("f_tableland_11_1.Id2", "f_tableland_11_1", Rectangle(-938, -358, 30));
		AddSpawnPoint("f_tableland_11_1.Id2", "f_tableland_11_1", Rectangle(-806, -222, 30));
		AddSpawnPoint("f_tableland_11_1.Id2", "f_tableland_11_1", Rectangle(-635, -386, 30));
		AddSpawnPoint("f_tableland_11_1.Id2", "f_tableland_11_1", Rectangle(-344, -856, 30));
		AddSpawnPoint("f_tableland_11_1.Id2", "f_tableland_11_1", Rectangle(-161, -691, 30));
		AddSpawnPoint("f_tableland_11_1.Id2", "f_tableland_11_1", Rectangle(-71, -786, 30));
		AddSpawnPoint("f_tableland_11_1.Id2", "f_tableland_11_1", Rectangle(-175, -879, 30));
		AddSpawnPoint("f_tableland_11_1.Id2", "f_tableland_11_1", Rectangle(-398, -686, 30));
		AddSpawnPoint("f_tableland_11_1.Id2", "f_tableland_11_1", Rectangle(-757, -455, 30));
		AddSpawnPoint("f_tableland_11_1.Id2", "f_tableland_11_1", Rectangle(-978, -231, 30));
		AddSpawnPoint("f_tableland_11_1.Id2", "f_tableland_11_1", Rectangle(-586, -195, 30));
		AddSpawnPoint("f_tableland_11_1.Id2", "f_tableland_11_1", Rectangle(-270, -754, 30));
		AddSpawnPoint("f_tableland_11_1.Id2", "f_tableland_11_1", Rectangle(-89, -586, 30));

		// 'Repusbunny_Mage_Green' GenType 9 Spawn Points
		AddSpawnPoint("f_tableland_11_1.Id3", "f_tableland_11_1", Rectangle(-748, -989, 30));
		AddSpawnPoint("f_tableland_11_1.Id3", "f_tableland_11_1", Rectangle(-914, -963, 30));
		AddSpawnPoint("f_tableland_11_1.Id3", "f_tableland_11_1", Rectangle(-649, -1133, 30));
		AddSpawnPoint("f_tableland_11_1.Id3", "f_tableland_11_1", Rectangle(-824, -1039, 30));
		AddSpawnPoint("f_tableland_11_1.Id3", "f_tableland_11_1", Rectangle(-643, -1448, 30));
		AddSpawnPoint("f_tableland_11_1.Id3", "f_tableland_11_1", Rectangle(-512, -1228, 30));
		AddSpawnPoint("f_tableland_11_1.Id3", "f_tableland_11_1", Rectangle(-758, -1475, 30));
		AddSpawnPoint("f_tableland_11_1.Id3", "f_tableland_11_1", Rectangle(-945, -1119, 30));
		AddSpawnPoint("f_tableland_11_1.Id3", "f_tableland_11_1", Rectangle(-522, -1330, 30));
		AddSpawnPoint("f_tableland_11_1.Id3", "f_tableland_11_1", Rectangle(-282, -1297, 30));
		AddSpawnPoint("f_tableland_11_1.Id3", "f_tableland_11_1", Rectangle(-907, -290, 30));
		AddSpawnPoint("f_tableland_11_1.Id3", "f_tableland_11_1", Rectangle(-712, -284, 30));
		AddSpawnPoint("f_tableland_11_1.Id3", "f_tableland_11_1", Rectangle(-318, -76, 30));
		AddSpawnPoint("f_tableland_11_1.Id3", "f_tableland_11_1", Rectangle(-327, -326, 30));
		AddSpawnPoint("f_tableland_11_1.Id3", "f_tableland_11_1", Rectangle(-149, -528, 30));
		AddSpawnPoint("f_tableland_11_1.Id3", "f_tableland_11_1", Rectangle(-277, -837, 30));
		AddSpawnPoint("f_tableland_11_1.Id3", "f_tableland_11_1", Rectangle(-833, -1161, 30));
		AddSpawnPoint("f_tableland_11_1.Id3", "f_tableland_11_1", Rectangle(-668, -1317, 30));

		// 'Groll_White' GenType 10 Spawn Points
		AddSpawnPoint("f_tableland_11_1.Id4", "f_tableland_11_1", Rectangle(90, -1214, 30));
		AddSpawnPoint("f_tableland_11_1.Id4", "f_tableland_11_1", Rectangle(296, -1109, 30));
		AddSpawnPoint("f_tableland_11_1.Id4", "f_tableland_11_1", Rectangle(421, -1045, 30));
		AddSpawnPoint("f_tableland_11_1.Id4", "f_tableland_11_1", Rectangle(584, -1222, 30));
		AddSpawnPoint("f_tableland_11_1.Id4", "f_tableland_11_1", Rectangle(503, -1214, 30));
		AddSpawnPoint("f_tableland_11_1.Id4", "f_tableland_11_1", Rectangle(238, -1409, 30));
		AddSpawnPoint("f_tableland_11_1.Id4", "f_tableland_11_1", Rectangle(130, -1429, 30));
		AddSpawnPoint("f_tableland_11_1.Id4", "f_tableland_11_1", Rectangle(53, -1305, 30));
		AddSpawnPoint("f_tableland_11_1.Id4", "f_tableland_11_1", Rectangle(522, -1143, 30));
		AddSpawnPoint("f_tableland_11_1.Id4", "f_tableland_11_1", Rectangle(374, -1481, 30));

		// 'Groll_White' GenType 11 Spawn Points
		AddSpawnPoint("f_tableland_11_1.Id5", "f_tableland_11_1", Rectangle(-359, -43, 9999));

		// 'Rootcrystal_01' GenType 16 Spawn Points
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(-373, -706, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(-131, -840, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(104, -261, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(-232, -150, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(394, 5, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(716, 667, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(1055, 542, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(200, 1120, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(-146, 1049, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(128, 1317, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(-61, 1824, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(-20, 99, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(-722, 286, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(-870, -493, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(-769, -249, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(-882, -986, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(-913, -1352, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(-521, -1299, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(408, -1179, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(48, -1346, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(448, -1437, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(-887, 449, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(-162, 1293, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(55, 2016, 100));
		AddSpawnPoint("f_tableland_11_1.Id6", "f_tableland_11_1", Rectangle(-2232, 2112, 100));
	}
}
