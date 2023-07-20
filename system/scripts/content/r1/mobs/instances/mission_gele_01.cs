//--- Melia Script -----------------------------------------------------------
// Gele Plateau Mission Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'mission_gele_01'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class MissionGele01MobScript : GeneralScript
{
	public override void Load()
	{
		AddSpawner("mission_gele_01.Id1", MonsterId.Rootcrystal_01, 12, 15, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);

		// 'Rootcrystal_01' GenType 1 Spawn Points
		AddSpawnPoint("mission_gele_01.Id1", "mission_gele_01", Rectangle(-95, -929, 100));
		AddSpawnPoint("mission_gele_01.Id1", "mission_gele_01", Rectangle(231, -883, 100));
		AddSpawnPoint("mission_gele_01.Id1", "mission_gele_01", Rectangle(175, -5, 100));
		AddSpawnPoint("mission_gele_01.Id1", "mission_gele_01", Rectangle(239, 154, 100));
		AddSpawnPoint("mission_gele_01.Id1", "mission_gele_01", Rectangle(742, -22, 100));
		AddSpawnPoint("mission_gele_01.Id1", "mission_gele_01", Rectangle(964, 180, 100));
		AddSpawnPoint("mission_gele_01.Id1", "mission_gele_01", Rectangle(726, 209, 100));
		AddSpawnPoint("mission_gele_01.Id1", "mission_gele_01", Rectangle(915, 700, 100));
		AddSpawnPoint("mission_gele_01.Id1", "mission_gele_01", Rectangle(924, 944, 100));
		AddSpawnPoint("mission_gele_01.Id1", "mission_gele_01", Rectangle(1260, 605, 100));
		AddSpawnPoint("mission_gele_01.Id1", "mission_gele_01", Rectangle(402, 888, 100));
		AddSpawnPoint("mission_gele_01.Id1", "mission_gele_01", Rectangle(173, 830, 100));
		AddSpawnPoint("mission_gele_01.Id1", "mission_gele_01", Rectangle(-13, 833, 100));
		AddSpawnPoint("mission_gele_01.Id1", "mission_gele_01", Rectangle(-225, 838, 100));
		AddSpawnPoint("mission_gele_01.Id1", "mission_gele_01", Rectangle(-607, 1059, 100));
		AddSpawnPoint("mission_gele_01.Id1", "mission_gele_01", Rectangle(-885, 478, 100));
		AddSpawnPoint("mission_gele_01.Id1", "mission_gele_01", Rectangle(-979, 260, 100));
		AddSpawnPoint("mission_gele_01.Id1", "mission_gele_01", Rectangle(-771, 164, 100));
		AddSpawnPoint("mission_gele_01.Id1", "mission_gele_01", Rectangle(-597, -579, 100));
		AddSpawnPoint("mission_gele_01.Id1", "mission_gele_01", Rectangle(-441, -501, 100));
	}
}
