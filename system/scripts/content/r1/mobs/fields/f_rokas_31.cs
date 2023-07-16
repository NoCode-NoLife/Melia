//--- Melia Script -----------------------------------------------------------
// f_rokas_31
//
//--- Description -----------------------------------------------------------
// Sets up the f_rokas_31 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRokas31MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_rokas_31", MonsterId.Warleader_Hogma, Properties("MHP", 56379, "MINPATK", 1226, "MAXPATK", 1408, "MINMATK", 1226, "MAXMATK", 1408, "DEF", 264, "MDEF", 264));
		AddPropertyOverrides("f_rokas_31", MonsterId.Tontulia, Properties("MHP", 56920, "MINPATK", 1233, "MAXPATK", 1417, "MINMATK", 1233, "MAXMATK", 1417, "DEF", 273, "MDEF", 273));
		AddPropertyOverrides("f_rokas_31", MonsterId.Repusbunny_Mage, Properties("MHP", 57485, "MINPATK", 1240, "MAXPATK", 1426, "MINMATK", 1240, "MAXMATK", 1426, "DEF", 281, "MDEF", 281));

		// Monster Spawners --------------------------------

		AddSpawner("f_rokas_31.Id1", MonsterId.Warleader_Hogma, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_31.Id2", MonsterId.Rootcrystal_03, 4, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_rokas_31.Id3", MonsterId.Tontulia, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_31.Id4", MonsterId.Warleader_Hogma, 3, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_rokas_31.Id5", MonsterId.Repusbunny_Mage, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Warleader_Hogma Spawn Points
		AddSpawnPoint( "f_rokas_31.Id1", "f_rokas_31", Spot(-661.9323, 6.6517134, 9999));

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint( "f_rokas_31.Id2", "f_rokas_31", Spot(-30, -489, 30));
		AddSpawnPoint( "f_rokas_31.Id2", "f_rokas_31", Spot(-621.8926, -984.72217, 30));
		AddSpawnPoint( "f_rokas_31.Id2", "f_rokas_31", Spot(869.9075, -1061.6787, 30));
		AddSpawnPoint( "f_rokas_31.Id2", "f_rokas_31", Spot(513.6644, -1375.4624, 30));
		AddSpawnPoint( "f_rokas_31.Id2", "f_rokas_31", Spot(507.52057, -37.26681, 30));
		AddSpawnPoint( "f_rokas_31.Id2", "f_rokas_31", Spot(-565.5139, -343.06253, 30));
		AddSpawnPoint( "f_rokas_31.Id2", "f_rokas_31", Spot(-695.4375, 150.73772, 30));
		AddSpawnPoint( "f_rokas_31.Id2", "f_rokas_31", Spot(-917.90125, 387.19186, 30));

		// Tontulia Spawn Points
		AddSpawnPoint( "f_rokas_31.Id3", "f_rokas_31", Spot(373.95923, -942.1163, 40));
		AddSpawnPoint( "f_rokas_31.Id3", "f_rokas_31", Spot(-845.2819, 271.82907, 40));
		AddSpawnPoint( "f_rokas_31.Id3", "f_rokas_31", Spot(-697.2455, -983.0076, 40));
		AddSpawnPoint( "f_rokas_31.Id3", "f_rokas_31", Spot(-537.3152, -1100.8308, 40));
		AddSpawnPoint( "f_rokas_31.Id3", "f_rokas_31", Spot(-417.83844, -882.71295, 40));
		AddSpawnPoint( "f_rokas_31.Id3", "f_rokas_31", Spot(-579.6922, -248.38739, 40));
		AddSpawnPoint( "f_rokas_31.Id3", "f_rokas_31", Spot(-417.93225, -12.539894, 40));
		AddSpawnPoint( "f_rokas_31.Id3", "f_rokas_31", Spot(-700.0269, 84.44062, 40));
		AddSpawnPoint( "f_rokas_31.Id3", "f_rokas_31", Spot(-271.88046, -1040.361, 40));

		// Warleader_Hogma Spawn Points
		AddSpawnPoint( "f_rokas_31.Id4", "f_rokas_31", Spot(-73.18795, -581.4615, 400));

		// Repusbunny_Mage Spawn Points
		AddSpawnPoint( "f_rokas_31.Id5", "f_rokas_31", Spot(-582.158, -1092.7369, 40));
		AddSpawnPoint( "f_rokas_31.Id5", "f_rokas_31", Spot(-548.96716, -939.43567, 40));
		AddSpawnPoint( "f_rokas_31.Id5", "f_rokas_31", Spot(-22.125946, -545.1729, 40));
		AddSpawnPoint( "f_rokas_31.Id5", "f_rokas_31", Spot(-441.24307, -103.70015, 40));
		AddSpawnPoint( "f_rokas_31.Id5", "f_rokas_31", Spot(-750.4022, 174.83809, 40));

	}
}
