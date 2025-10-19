//--- Melia Script -----------------------------------------------------------
// Unknown Sanctuary 3F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'id_Unknownsanctuary_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Game.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class IdUnknownsanctuary3MobScript : GeneralScript
{
	protected override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("id_Unknownsanctuary_3", MonsterId.RE_Boss_Bearkaras, Properties("MHP", 18000000, "MINPATK", 300000, "MAXPATK", 300000, "MINMATK", 300000, "MAXMATK", 300000, "DEF", 30000000, "MDEF", 30000000));
		AddPropertyOverrides("id_Unknownsanctuary_3", MonsterId.RE_Boss_Poata, Properties("MHP", 18000000, "MINPATK", 300000, "MAXPATK", 300000, "MINMATK", 300000, "MAXMATK", 300000, "DEF", 30000000, "MDEF", 30000000));
		AddPropertyOverrides("id_Unknownsanctuary_3", MonsterId.RE_Boss_Salamander, Properties("MHP", 18000000, "MINPATK", 300000, "MAXPATK", 300000, "MINMATK", 300000, "MAXMATK", 300000, "DEF", 30000000, "MDEF", 30000000));
		AddPropertyOverrides("id_Unknownsanctuary_3", MonsterId.RE_Boss_Bebraspion, Properties("MHP", 18000000, "MINPATK", 300000, "MAXPATK", 300000, "MINMATK", 300000, "MAXMATK", 300000, "DEF", 30000000, "MDEF", 30000000));
		AddPropertyOverrides("id_Unknownsanctuary_3", MonsterId.RE_Boss_Mushwort, Properties("MHP", 18000000, "MINPATK", 300000, "MAXPATK", 300000, "MINMATK", 300000, "MAXMATK", 300000, "DEF", 30000000, "MDEF", 30000000));
		AddPropertyOverrides("id_Unknownsanctuary_3", MonsterId.RE_Boss_Molich, Properties("MHP", 18000000, "MINPATK", 300000, "MAXPATK", 300000, "MINMATK", 300000, "MAXMATK", 300000, "DEF", 30000000, "MDEF", 30000000));
		AddPropertyOverrides("id_Unknownsanctuary_3", MonsterId.RE_Boss_Glass_Mole, Properties("MHP", 18000000, "MINPATK", 300000, "MAXPATK", 300000, "MINMATK", 300000, "MAXMATK", 300000, "DEF", 30000000, "MDEF", 30000000));
		AddPropertyOverrides("id_Unknownsanctuary_3", MonsterId.RE_Boss_Lilymaid, Properties("MHP", 18000000, "MINPATK", 300000, "MAXPATK", 300000, "MINMATK", 300000, "MAXMATK", 300000, "DEF", 30000000, "MDEF", 30000000));
		AddPropertyOverrides("id_Unknownsanctuary_3", MonsterId.RE_Boss_Varleking, Properties("MHP", 18000000, "MINPATK", 300000, "MAXPATK", 300000, "MINMATK", 300000, "MAXMATK", 300000, "DEF", 30000000, "MDEF", 30000000));
		AddPropertyOverrides("id_Unknownsanctuary_3", MonsterId.RE_Boss_Genmagnus, Properties("MHP", 18000000, "MINPATK", 300000, "MAXPATK", 300000, "MINMATK", 300000, "MAXMATK", 300000, "DEF", 30000000, "MDEF", 30000000));
		AddPropertyOverrides("id_Unknownsanctuary_3", MonsterId.RE_Boss_Spector_Gh, Properties("MHP", 18000000, "MINPATK", 300000, "MAXPATK", 300000, "MINMATK", 300000, "MAXMATK", 300000, "DEF", 30000000, "MDEF", 30000000));
		AddPropertyOverrides("id_Unknownsanctuary_3", MonsterId.RE_Boss_Ellaganos, Properties("MHP", 18000000, "MINPATK", 300000, "MAXPATK", 300000, "MINMATK", 300000, "MAXMATK", 300000, "DEF", 30000000, "MDEF", 30000000));

		// Monster Spawners ---------------------------------

		AddSpawner("id_Unknownsanctuary_3.Id1", MonsterId.RE_Boss_Bearkaras, amount: 1, respawn: Seconds(5), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id2", MonsterId.RE_Boss_Poata, amount: 1, respawn: Seconds(5), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id3", MonsterId.RE_Boss_Salamander, amount: 1, respawn: Seconds(5), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id4", MonsterId.RE_Boss_Bebraspion, amount: 1, respawn: Seconds(5), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id5", MonsterId.RE_Boss_Mushwort, amount: 1, respawn: Seconds(5), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id6", MonsterId.RE_Boss_Molich, amount: 1, respawn: Seconds(5), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id7", MonsterId.RE_Boss_Glass_Mole, amount: 1, respawn: Seconds(5), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id8", MonsterId.RE_Boss_Lilymaid, amount: 1, respawn: Seconds(5), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id9", MonsterId.RE_Boss_Varleking, amount: 1, respawn: Seconds(5), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id10", MonsterId.RE_Boss_Genmagnus, amount: 1, respawn: Seconds(5), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id11", MonsterId.RE_Boss_Spector_Gh, amount: 1, respawn: Seconds(5), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id12", MonsterId.RE_Boss_Ellaganos, amount: 1, respawn: Seconds(5), tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'RE_Boss_Bearkaras' GenType 1 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id1", "id_Unknownsanctuary_3", Rectangle(-1217, 269, 20));

		// 'RE_Boss_Poata' GenType 2 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id2", "id_Unknownsanctuary_3", Rectangle(-623, 273, 20));

		// 'RE_Boss_Salamander' GenType 3 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id3", "id_Unknownsanctuary_3", Rectangle(-1529, 1054, 20));

		// 'RE_Boss_Bebraspion' GenType 4 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id4", "id_Unknownsanctuary_3", Rectangle(-759, 1215, 20));

		// 'RE_Boss_Mushwort' GenType 5 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id5", "id_Unknownsanctuary_3", Rectangle(-754, 1839, 20));

		// 'RE_Boss_Molich' GenType 7 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id6", "id_Unknownsanctuary_3", Rectangle(-124, 1851, 20));

		// 'RE_Boss_Glass_Mole' GenType 8 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id7", "id_Unknownsanctuary_3", Rectangle(-121, 1220, 20));

		// 'RE_Boss_Lilymaid' GenType 9 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id8", "id_Unknownsanctuary_3", Rectangle(386, 250, 20));

		// 'RE_Boss_Varleking' GenType 10 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id9", "id_Unknownsanctuary_3", Rectangle(1620, 1201, 20));

		// 'RE_Boss_Genmagnus' GenType 11 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id10", "id_Unknownsanctuary_3", Rectangle(1128, -978, 20));

		// 'RE_Boss_Spector_Gh' GenType 12 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id11", "id_Unknownsanctuary_3", Rectangle(452, -727, 20));

		// 'RE_Boss_Ellaganos' GenType 13 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id12", "id_Unknownsanctuary_3", Rectangle(445, -1265, 20));
	}
}
