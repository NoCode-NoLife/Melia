//--- Melia Script -----------------------------------------------------------
// Mage Tower 3F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_firetower_43'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFiretower43MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_firetower_43", MonsterId.InfroRocktor_Red, Properties("MHP", 104267, "MINPATK", 1842, "MAXPATK", 2165, "MINMATK", 1842, "MAXMATK", 2165, "DEF", 1317, "MDEF", 1317));
		AddPropertyOverrides("d_firetower_43", MonsterId.Arma, Properties("MHP", 105676, "MINPATK", 1860, "MAXPATK", 2188, "MINMATK", 1860, "MAXMATK", 2188, "DEF", 1363, "MDEF", 1363));
		AddPropertyOverrides("d_firetower_43", MonsterId.Flask_Mage, Properties("MHP", 107119, "MINPATK", 1878, "MAXPATK", 2211, "MINMATK", 1878, "MAXMATK", 2211, "DEF", 1410, "MDEF", 1410));
		AddPropertyOverrides("d_firetower_43", MonsterId.Pyran, Properties("MHP", 108595, "MINPATK", 1897, "MAXPATK", 2234, "MINMATK", 1897, "MAXMATK", 2234, "DEF", 1458, "MDEF", 1458));

		// Monster Spawners ---------------------------------

		AddSpawner("d_firetower_43.Id1", MonsterId.InfroRocktor_Red, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_43.Id2", MonsterId.Rootcrystal_01, 8, 10, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_firetower_43.Id3", MonsterId.Arma, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_43.Id4", MonsterId.InfroRocktor_Red, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_43.Id5", MonsterId.Arma, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_43.Id6", MonsterId.Flask_Mage, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_43.Id7", MonsterId.Flask_Mage, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_43.Id8", MonsterId.TerraNymph_Mage, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_firetower_43.Id9", MonsterId.Pyran, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'InfroRocktor_Red' GenType 1 Spawn Points
		AddSpawnPoint("d_firetower_43.Id1", "d_firetower_43", Rectangle(676, -842, 9999));

		// 'Rootcrystal_01' GenType 2 Spawn Points
		AddSpawnPoint("d_firetower_43.Id2", "d_firetower_43", Rectangle(-2334, 58, 100));
		AddSpawnPoint("d_firetower_43.Id2", "d_firetower_43", Rectangle(-1577, 348, 100));
		AddSpawnPoint("d_firetower_43.Id2", "d_firetower_43", Rectangle(-909, 474, 100));
		AddSpawnPoint("d_firetower_43.Id2", "d_firetower_43", Rectangle(-783, 16, 100));
		AddSpawnPoint("d_firetower_43.Id2", "d_firetower_43", Rectangle(-368, -611, 100));
		AddSpawnPoint("d_firetower_43.Id2", "d_firetower_43", Rectangle(-1100, -773, 100));
		AddSpawnPoint("d_firetower_43.Id2", "d_firetower_43", Rectangle(-279, -1474, 100));
		AddSpawnPoint("d_firetower_43.Id2", "d_firetower_43", Rectangle(577, -1275, 100));
		AddSpawnPoint("d_firetower_43.Id2", "d_firetower_43", Rectangle(748, -128, 100));
		AddSpawnPoint("d_firetower_43.Id2", "d_firetower_43", Rectangle(1296, -99, 100));

		// 'Arma' GenType 212 Spawn Points
		AddSpawnPoint("d_firetower_43.Id3", "d_firetower_43", Rectangle(-1556, 810, 9999));

		// 'InfroRocktor_Red' GenType 213 Spawn Points
		AddSpawnPoint("d_firetower_43.Id4", "d_firetower_43", Rectangle(-296, -1248, 30));
		AddSpawnPoint("d_firetower_43.Id4", "d_firetower_43", Rectangle(-200, -504, 30));
		AddSpawnPoint("d_firetower_43.Id4", "d_firetower_43", Rectangle(-524, -282, 30));
		AddSpawnPoint("d_firetower_43.Id4", "d_firetower_43", Rectangle(117, -685, 30));
		AddSpawnPoint("d_firetower_43.Id4", "d_firetower_43", Rectangle(-486, -718, 30));
		AddSpawnPoint("d_firetower_43.Id4", "d_firetower_43", Rectangle(-248, -1506, 30));
		AddSpawnPoint("d_firetower_43.Id4", "d_firetower_43", Rectangle(-328, -1399, 30));
		AddSpawnPoint("d_firetower_43.Id4", "d_firetower_43", Rectangle(-388, -836, 30));
		AddSpawnPoint("d_firetower_43.Id4", "d_firetower_43", Rectangle(-370, -526, 30));
		AddSpawnPoint("d_firetower_43.Id4", "d_firetower_43", Rectangle(284, -665, 30));
		AddSpawnPoint("d_firetower_43.Id4", "d_firetower_43", Rectangle(-575, -82, 30));
		AddSpawnPoint("d_firetower_43.Id4", "d_firetower_43", Rectangle(-945, -810, 30));
		AddSpawnPoint("d_firetower_43.Id4", "d_firetower_43", Rectangle(-286, -656, 30));
		AddSpawnPoint("d_firetower_43.Id4", "d_firetower_43", Rectangle(-1283, -920, 30));
		AddSpawnPoint("d_firetower_43.Id4", "d_firetower_43", Rectangle(-1250, -662, 30));
		AddSpawnPoint("d_firetower_43.Id4", "d_firetower_43", Rectangle(-1369, -757, 30));

		// 'Arma' GenType 214 Spawn Points
		AddSpawnPoint("d_firetower_43.Id5", "d_firetower_43", Rectangle(-1228, -820, 25));
		AddSpawnPoint("d_firetower_43.Id5", "d_firetower_43", Rectangle(-1116, -706, 25));
		AddSpawnPoint("d_firetower_43.Id5", "d_firetower_43", Rectangle(-695, -756, 25));
		AddSpawnPoint("d_firetower_43.Id5", "d_firetower_43", Rectangle(-1115, -83, 25));
		AddSpawnPoint("d_firetower_43.Id5", "d_firetower_43", Rectangle(-797, 1, 25));
		AddSpawnPoint("d_firetower_43.Id5", "d_firetower_43", Rectangle(-420, -624, 25));
		AddSpawnPoint("d_firetower_43.Id5", "d_firetower_43", Rectangle(-1250, 445, 25));
		AddSpawnPoint("d_firetower_43.Id5", "d_firetower_43", Rectangle(-782, 514, 25));
		AddSpawnPoint("d_firetower_43.Id5", "d_firetower_43", Rectangle(-299, -1108, 25));
		AddSpawnPoint("d_firetower_43.Id5", "d_firetower_43", Rectangle(-409, -1361, 25));
		AddSpawnPoint("d_firetower_43.Id5", "d_firetower_43", Rectangle(-35, -1418, 25));
		AddSpawnPoint("d_firetower_43.Id5", "d_firetower_43", Rectangle(63, -710, 25));
		AddSpawnPoint("d_firetower_43.Id5", "d_firetower_43", Rectangle(-76, -1239, 25));
		AddSpawnPoint("d_firetower_43.Id5", "d_firetower_43", Rectangle(-422, -827, 25));
		AddSpawnPoint("d_firetower_43.Id5", "d_firetower_43", Rectangle(-1032, -851, 25));
		AddSpawnPoint("d_firetower_43.Id5", "d_firetower_43", Rectangle(-249, -765, 25));
		AddSpawnPoint("d_firetower_43.Id5", "d_firetower_43", Rectangle(-1192, 214, 25));
		AddSpawnPoint("d_firetower_43.Id5", "d_firetower_43", Rectangle(-679, 285, 25));

		// 'Flask_Mage' GenType 216 Spawn Points
		AddSpawnPoint("d_firetower_43.Id6", "d_firetower_43", Rectangle(1265, 74, 9999));

		// 'Flask_Mage' GenType 218 Spawn Points
		AddSpawnPoint("d_firetower_43.Id7", "d_firetower_43", Rectangle(1460, -761, 25));
		AddSpawnPoint("d_firetower_43.Id7", "d_firetower_43", Rectangle(1394, -904, 25));
		AddSpawnPoint("d_firetower_43.Id7", "d_firetower_43", Rectangle(1297, -747, 25));
		AddSpawnPoint("d_firetower_43.Id7", "d_firetower_43", Rectangle(1453, -634, 25));
		AddSpawnPoint("d_firetower_43.Id7", "d_firetower_43", Rectangle(1556, -852, 25));
		AddSpawnPoint("d_firetower_43.Id7", "d_firetower_43", Rectangle(423, -1338, 25));
		AddSpawnPoint("d_firetower_43.Id7", "d_firetower_43", Rectangle(700, -1330, 25));
		AddSpawnPoint("d_firetower_43.Id7", "d_firetower_43", Rectangle(565, -1332, 25));
		AddSpawnPoint("d_firetower_43.Id7", "d_firetower_43", Rectangle(489, -1590, 25));
		AddSpawnPoint("d_firetower_43.Id7", "d_firetower_43", Rectangle(644, -1575, 25));

		// 'TerraNymph_Mage' GenType 237 Spawn Points
		AddSpawnPoint("d_firetower_43.Id8", "d_firetower_43", Rectangle(-384, -1292, 30));
		AddSpawnPoint("d_firetower_43.Id8", "d_firetower_43", Rectangle(-590, -620, 30));
		AddSpawnPoint("d_firetower_43.Id8", "d_firetower_43", Rectangle(-82, -626, 30));
		AddSpawnPoint("d_firetower_43.Id8", "d_firetower_43", Rectangle(-328, -681, 30));
		AddSpawnPoint("d_firetower_43.Id8", "d_firetower_43", Rectangle(-560, -231, 30));
		AddSpawnPoint("d_firetower_43.Id8", "d_firetower_43", Rectangle(-713, 465, 30));
		AddSpawnPoint("d_firetower_43.Id8", "d_firetower_43", Rectangle(-1227, 431, 30));
		AddSpawnPoint("d_firetower_43.Id8", "d_firetower_43", Rectangle(-1073, -1, 30));

		// 'Pyran' GenType 238 Spawn Points
		AddSpawnPoint("d_firetower_43.Id9", "d_firetower_43", Rectangle(-741, -817, 9999));
	}
}
