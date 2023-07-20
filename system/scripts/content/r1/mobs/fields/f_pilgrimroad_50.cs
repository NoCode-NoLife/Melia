//--- Melia Script -----------------------------------------------------------
// Altar Way Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_pilgrimroad_50'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad50MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_pilgrimroad_50", MonsterId.Kodomor, Properties("MHP", 129828, "MINPATK", 2171, "MAXPATK", 2570, "MINMATK", 2171, "MAXMATK", 2570, "DEF", 2270, "MDEF", 2270));
		AddPropertyOverrides("f_pilgrimroad_50", MonsterId.Romor, Properties("MHP", 130890, "MINPATK", 2184, "MAXPATK", 2586, "MINMATK", 2184, "MAXMATK", 2586, "DEF", 2331, "MDEF", 2331));
		AddPropertyOverrides("f_pilgrimroad_50", MonsterId.Lapasape_Bow, Properties("MHP", 132020, "MINPATK", 2199, "MAXPATK", 2604, "MINMATK", 2199, "MAXMATK", 2604, "DEF", 2396, "MDEF", 2396));
		AddPropertyOverrides("f_pilgrimroad_50", MonsterId.Siaulav_Mage, Properties("MHP", 133215, "MINPATK", 2214, "MAXPATK", 2623, "MINMATK", 2214, "MAXMATK", 2623, "DEF", 2465, "MDEF", 2465));

		// Monster Spawners ---------------------------------

		AddSpawner("f_pilgrimroad_50.Id1", MonsterId.Kodomor, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_50.Id2", MonsterId.Romor, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_50.Id3", MonsterId.Rootcrystal_01, 6, 8, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_50.Id4", MonsterId.Lapasape_Bow, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_50.Id5", MonsterId.Siaulav_Mage, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Kodomor' GenType 8 Spawn Points
		AddSpawnPoint("f_pilgrimroad_50.Id1", "f_pilgrimroad_50", Rectangle(-564, -49, 9999));

		// 'Romor' GenType 9 Spawn Points
		AddSpawnPoint("f_pilgrimroad_50.Id2", "f_pilgrimroad_50", Rectangle(71, -276, 9999));

		// 'Rootcrystal_01' GenType 13 Spawn Points
		AddSpawnPoint("f_pilgrimroad_50.Id3", "f_pilgrimroad_50", Rectangle(-1447, -1027, 30));
		AddSpawnPoint("f_pilgrimroad_50.Id3", "f_pilgrimroad_50", Rectangle(-1177, 55, 30));
		AddSpawnPoint("f_pilgrimroad_50.Id3", "f_pilgrimroad_50", Rectangle(-511, 386, 30));
		AddSpawnPoint("f_pilgrimroad_50.Id3", "f_pilgrimroad_50", Rectangle(156, 1121, 30));
		AddSpawnPoint("f_pilgrimroad_50.Id3", "f_pilgrimroad_50", Rectangle(-490, -111, 30));
		AddSpawnPoint("f_pilgrimroad_50.Id3", "f_pilgrimroad_50", Rectangle(427, 236, 30));
		AddSpawnPoint("f_pilgrimroad_50.Id3", "f_pilgrimroad_50", Rectangle(1086, -779, 30));
		AddSpawnPoint("f_pilgrimroad_50.Id3", "f_pilgrimroad_50", Rectangle(2058, -929, 30));

		// 'Lapasape_Bow' GenType 35 Spawn Points
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(-623, 508, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(-723, 791, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(136, 1110, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(244, 1437, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(844, 1683, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(45, 1415, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(-508, 770, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(-820, 1041, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(444, 1189, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(1028, 1009, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(590, 1666, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(860, -793, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(1123, -508, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(2209, -858, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(1067, -737, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(2076, -1159, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(1904, -965, 40));

		// 'Siaulav_Mage' GenType 36 Spawn Points
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(549, 449, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(497, 13, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(715, -27, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(1021, 696, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(710, 238, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(805, 477, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(1009, 452, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(427, 215, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(58, 1450, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(134, 1069, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(986, 1128, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(364, 1443, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(1261, -791, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(947, -557, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(2276, -1081, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(2102, -1019, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(2054, -843, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(1023, -910, 40));
	}
}
