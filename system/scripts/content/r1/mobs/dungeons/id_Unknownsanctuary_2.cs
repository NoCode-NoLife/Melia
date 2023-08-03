//--- Melia Script -----------------------------------------------------------
// Unknown Sanctuary 2F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'id_Unknownsanctuary_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class IdUnknownsanctuary2MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Froster_Lord, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Kucarry_Balzermancer, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Wastrel, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Ignas, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Asiomage, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Skiaclipse, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Moringponia, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Tantaliser, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Pbeta, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Glacier, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Velcoffer, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));

		// Monster Spawners ---------------------------------

		AddSpawner("id_Unknownsanctuary_2.Id1", MonsterId.FD_Boss_Froster_Lord, amount: 1, respawn: TimeSpan.FromMilliseconds(15000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id2", MonsterId.FD_Boss_Kucarry_Balzermancer, amount: 1, respawn: TimeSpan.FromMilliseconds(15000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id3", MonsterId.FD_Boss_Wastrel, amount: 1, respawn: TimeSpan.FromMilliseconds(15000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id4", MonsterId.FD_Boss_Ignas, amount: 1, respawn: TimeSpan.FromMilliseconds(15000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id5", MonsterId.FD_Boss_Asiomage, amount: 1, respawn: TimeSpan.FromMilliseconds(15000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id6", MonsterId.FD_Boss_Skiaclipse, amount: 1, respawn: TimeSpan.FromMilliseconds(15000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id7", MonsterId.FD_Boss_Moringponia, amount: 1, respawn: TimeSpan.FromMilliseconds(15000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id8", MonsterId.FD_Boss_Tantaliser, amount: 1, respawn: TimeSpan.FromMilliseconds(15000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id9", MonsterId.FD_Boss_Pbeta, amount: 1, respawn: TimeSpan.FromMilliseconds(15000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id10", MonsterId.FD_Boss_Glacier, amount: 1, respawn: TimeSpan.FromMilliseconds(15000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id11", MonsterId.FD_Boss_Velcoffer, amount: 1, respawn: TimeSpan.FromMilliseconds(15000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id12", MonsterId.FD_Boss_Skiaclipse, amount: 1, respawn: TimeSpan.FromMilliseconds(15000), tendency: TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id13", MonsterId.FD_Boss_Skiaclipse, amount: 1, respawn: TimeSpan.FromMilliseconds(15000), tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'FD_Boss_Froster_Lord' GenType 1 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id1", "id_Unknownsanctuary_2", Rectangle(198, 1156, 20));

		// 'FD_Boss_Kucarry_Balzermancer' GenType 2 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id2", "id_Unknownsanctuary_2", Rectangle(-1055, -135, 20));

		// 'FD_Boss_Wastrel' GenType 3 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id3", "id_Unknownsanctuary_2", Rectangle(866, 1069, 20));

		// 'FD_Boss_Ignas' GenType 4 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id4", "id_Unknownsanctuary_2", Rectangle(-426, -1035, 20));

		// 'FD_Boss_Asiomage' GenType 5 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id5", "id_Unknownsanctuary_2", Rectangle(68, -1364, 20));

		// 'FD_Boss_Skiaclipse' GenType 6 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id6", "id_Unknownsanctuary_2", Rectangle(-372, -435, 20));

		// 'FD_Boss_Moringponia' GenType 7 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id7", "id_Unknownsanctuary_2", Rectangle(-1057, -807, 20));

		// 'FD_Boss_Tantaliser' GenType 8 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id8", "id_Unknownsanctuary_2", Rectangle(1055, 561, 20));

		// 'FD_Boss_Pbeta' GenType 9 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id9", "id_Unknownsanctuary_2", Rectangle(541, -1062, 20));

		// 'FD_Boss_Glacier' GenType 10 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id10", "id_Unknownsanctuary_2", Rectangle(-803, 767, 20));

		// 'FD_Boss_Velcoffer' GenType 11 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id11", "id_Unknownsanctuary_2", Rectangle(86, -17, 20));

		// 'FD_Boss_Skiaclipse' GenType 13 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id12", "id_Unknownsanctuary_2", Rectangle(591, -383, 20));

		// 'FD_Boss_Skiaclipse' GenType 14 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id13", "id_Unknownsanctuary_2", Rectangle(-66, 534, 20));
	}
}
