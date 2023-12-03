//--- Melia Script -----------------------------------------------------------
// Unknown Sanctuary 3F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'id_Unknownsanctuary_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class IdUnknownsanctuary3MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("id_Unknownsanctuary_3", MonsterId.RE_Boss_Helga, Properties("MHP", 6000000, "MINPATK", 350000, "MAXPATK", 350000, "MINMATK", 350000, "MAXMATK", 350000, "DEF", 6500000, "MDEF", 6500000));
		AddPropertyOverrides("id_Unknownsanctuary_3", MonsterId.RE_Boss_Lecifer, Properties("MHP", 6000000, "MINPATK", 350000, "MAXPATK", 350000, "MINMATK", 350000, "MAXMATK", 350000, "DEF", 6500000, "MDEF", 6500000));
		AddPropertyOverrides("id_Unknownsanctuary_3", MonsterId.RE_Boss_Solcomm, Properties("MHP", 6000000, "MINPATK", 350000, "MAXPATK", 350000, "MINMATK", 350000, "MAXMATK", 350000, "DEF", 6500000, "MDEF", 6500000));
		AddPropertyOverrides("id_Unknownsanctuary_3", MonsterId.RE_Boss_Zawra, Properties("MHP", 6000000, "MINPATK", 350000, "MAXPATK", 350000, "MINMATK", 350000, "MAXMATK", 350000, "DEF", 6500000, "MDEF", 6500000));
		AddPropertyOverrides("id_Unknownsanctuary_3", MonsterId.RE_Boss_Gresmetruth, Properties("MHP", 6000000, "MINPATK", 350000, "MAXPATK", 350000, "MINMATK", 350000, "MAXMATK", 350000, "DEF", 6500000, "MDEF", 6500000));

		// Monster Spawners ---------------------------------

		AddSpawner("id_Unknownsanctuary_3.Id1", MonsterId.RE_Boss_Helga, amount: 1, respawn: TimeSpan.FromMilliseconds(5000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id2", MonsterId.RE_Boss_Lecifer, amount: 1, respawn: TimeSpan.FromMilliseconds(5000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id3", MonsterId.RE_Boss_Solcomm, amount: 1, respawn: TimeSpan.FromMilliseconds(5000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id4", MonsterId.RE_Boss_Zawra, amount: 1, respawn: TimeSpan.FromMilliseconds(5000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id5", MonsterId.RE_Boss_Gresmetruth, amount: 1, respawn: TimeSpan.FromMilliseconds(5000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id6", MonsterId.RE_Boss_Gresmetruth, amount: 1, respawn: TimeSpan.FromMilliseconds(5000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id7", MonsterId.RE_Boss_Lecifer, amount: 1, respawn: TimeSpan.FromMilliseconds(5000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id8", MonsterId.RE_Boss_Solcomm, amount: 1, respawn: TimeSpan.FromMilliseconds(5000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id9", MonsterId.RE_Boss_Zawra, amount: 1, respawn: TimeSpan.FromMilliseconds(5000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id10", MonsterId.RE_Boss_Gresmetruth, amount: 1, respawn: TimeSpan.FromMilliseconds(5000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id11", MonsterId.RE_Boss_Helga, amount: 1, respawn: TimeSpan.FromMilliseconds(5000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_3.Id12", MonsterId.RE_Boss_Solcomm, amount: 1, respawn: TimeSpan.FromMilliseconds(5000), tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'RE_Boss_Helga' GenType 1 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id1", "id_Unknownsanctuary_3", Rectangle(-1217, 269, 20));

		// 'RE_Boss_Lecifer' GenType 2 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id2", "id_Unknownsanctuary_3", Rectangle(-623, 273, 20));

		// 'RE_Boss_Solcomm' GenType 3 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id3", "id_Unknownsanctuary_3", Rectangle(-1529, 1054, 20));

		// 'RE_Boss_Zawra' GenType 4 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id4", "id_Unknownsanctuary_3", Rectangle(-759, 1215, 20));

		// 'RE_Boss_Gresmetruth' GenType 5 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id5", "id_Unknownsanctuary_3", Rectangle(-754, 1839, 20));

		// 'RE_Boss_Gresmetruth' GenType 7 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id6", "id_Unknownsanctuary_3", Rectangle(-124, 1851, 20));

		// 'RE_Boss_Lecifer' GenType 8 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id7", "id_Unknownsanctuary_3", Rectangle(-121, 1220, 20));

		// 'RE_Boss_Solcomm' GenType 9 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id8", "id_Unknownsanctuary_3", Rectangle(386, 250, 20));

		// 'RE_Boss_Zawra' GenType 10 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id9", "id_Unknownsanctuary_3", Rectangle(1620, 1201, 20));

		// 'RE_Boss_Gresmetruth' GenType 11 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id10", "id_Unknownsanctuary_3", Rectangle(1128, -978, 20));

		// 'RE_Boss_Helga' GenType 12 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id11", "id_Unknownsanctuary_3", Rectangle(452, -727, 20));

		// 'RE_Boss_Solcomm' GenType 13 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_3.Id12", "id_Unknownsanctuary_3", Rectangle(445, -1265, 20));
	}
}
