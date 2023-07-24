//--- Melia Script -----------------------------------------------------------
// Zachariel Crossroads Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_rokas_31'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRokas31MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_rokas_31", MonsterId.Warleader_Hogma, Properties("MHP", 56379, "MINPATK", 1226, "MAXPATK", 1408, "MINMATK", 1226, "MAXMATK", 1408, "DEF", 264, "MDEF", 264));
		AddPropertyOverrides("f_rokas_31", MonsterId.Tontulia, Properties("MHP", 56920, "MINPATK", 1233, "MAXPATK", 1417, "MINMATK", 1233, "MAXMATK", 1417, "DEF", 273, "MDEF", 273));
		AddPropertyOverrides("f_rokas_31", MonsterId.Repusbunny_Mage, Properties("MHP", 57485, "MINPATK", 1240, "MAXPATK", 1426, "MINMATK", 1240, "MAXMATK", 1426, "DEF", 281, "MDEF", 281));
		AddPropertyOverrides("f_rokas_31", MonsterId.Boss_Bearkaras_Q1, Properties("MHP", 282228, "MINPATK", 2695, "MAXPATK", 3100, "MINMATK", 2695, "MAXMATK", 3100, "DEF", 627, "MDEF", 627));
		AddPropertyOverrides("f_rokas_31", MonsterId.Boss_Cactusvel, Properties("MHP", 285184, "MINPATK", 2712, "MAXPATK", 3121, "MINMATK", 2712, "MAXMATK", 3121, "DEF", 647, "MDEF", 647));
		AddPropertyOverrides("f_rokas_31", MonsterId.Hogma_Warrior, Properties("MHP", 59308, "MINPATK", 1264, "MAXPATK", 1455, "MINMATK", 1264, "MAXMATK", 1455, "DEF", 309, "MDEF", 309));
		AddPropertyOverrides("f_rokas_31", MonsterId.Hogma_Sorcerer, Properties("MHP", 59957, "MINPATK", 1272, "MAXPATK", 1465, "MINMATK", 1272, "MAXMATK", 1465, "DEF", 319, "MDEF", 319));

		// Monster Spawners ---------------------------------

		AddSpawner("f_rokas_31.Id1", MonsterId.Warleader_Hogma, min: 4, max: 5);
		AddSpawner("f_rokas_31.Id2", MonsterId.Rootcrystal_03, min: 3, max: 4, respawn: TimeSpan.FromMilliseconds(5000));
		AddSpawner("f_rokas_31.Id3", MonsterId.Tontulia, min: 12, max: 15);
		AddSpawner("f_rokas_31.Id4", MonsterId.Warleader_Hogma, amount: 3);
		AddSpawner("f_rokas_31.Id5", MonsterId.Repusbunny_Mage, min: 4, max: 5);

		// Monster Spawn Points -----------------------------

		// 'Warleader_Hogma' GenType 11 Spawn Points
		AddSpawnPoint("f_rokas_31.Id1", "f_rokas_31", Rectangle(-661, 6, 9999));

		// 'Rootcrystal_03' GenType 600 Spawn Points
		AddSpawnPoint("f_rokas_31.Id2", "f_rokas_31", Rectangle(-30, -489, 30));
		AddSpawnPoint("f_rokas_31.Id2", "f_rokas_31", Rectangle(-621, -984, 30));
		AddSpawnPoint("f_rokas_31.Id2", "f_rokas_31", Rectangle(869, -1061, 30));
		AddSpawnPoint("f_rokas_31.Id2", "f_rokas_31", Rectangle(513, -1375, 30));
		AddSpawnPoint("f_rokas_31.Id2", "f_rokas_31", Rectangle(507, -37, 30));
		AddSpawnPoint("f_rokas_31.Id2", "f_rokas_31", Rectangle(-565, -343, 30));
		AddSpawnPoint("f_rokas_31.Id2", "f_rokas_31", Rectangle(-695, 150, 30));
		AddSpawnPoint("f_rokas_31.Id2", "f_rokas_31", Rectangle(-917, 387, 30));

		// 'Tontulia' GenType 615 Spawn Points
		AddSpawnPoint("f_rokas_31.Id3", "f_rokas_31", Rectangle(373, -942, 40));
		AddSpawnPoint("f_rokas_31.Id3", "f_rokas_31", Rectangle(-845, 271, 40));
		AddSpawnPoint("f_rokas_31.Id3", "f_rokas_31", Rectangle(-697, -983, 40));
		AddSpawnPoint("f_rokas_31.Id3", "f_rokas_31", Rectangle(-537, -1100, 40));
		AddSpawnPoint("f_rokas_31.Id3", "f_rokas_31", Rectangle(-417, -882, 40));
		AddSpawnPoint("f_rokas_31.Id3", "f_rokas_31", Rectangle(-579, -248, 40));
		AddSpawnPoint("f_rokas_31.Id3", "f_rokas_31", Rectangle(-417, -12, 40));
		AddSpawnPoint("f_rokas_31.Id3", "f_rokas_31", Rectangle(-700, 84, 40));
		AddSpawnPoint("f_rokas_31.Id3", "f_rokas_31", Rectangle(-271, -1040, 40));

		// 'Warleader_Hogma' GenType 620 Spawn Points
		AddSpawnPoint("f_rokas_31.Id4", "f_rokas_31", Rectangle(-73, -581, 400));

		// 'Repusbunny_Mage' GenType 622 Spawn Points
		AddSpawnPoint("f_rokas_31.Id5", "f_rokas_31", Rectangle(-582, -1092, 40));
		AddSpawnPoint("f_rokas_31.Id5", "f_rokas_31", Rectangle(-548, -939, 40));
		AddSpawnPoint("f_rokas_31.Id5", "f_rokas_31", Rectangle(-22, -545, 40));
		AddSpawnPoint("f_rokas_31.Id5", "f_rokas_31", Rectangle(-441, -103, 40));
		AddSpawnPoint("f_rokas_31.Id5", "f_rokas_31", Rectangle(-750, 174, 40));
	}
}
