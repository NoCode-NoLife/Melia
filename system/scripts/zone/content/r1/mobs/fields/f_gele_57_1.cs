//--- Melia Script -----------------------------------------------------------
// Srautas Gorge Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_gele_57_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Game.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FGele571MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_gele_57_1", MonsterId.Zignuts, Properties("MHP", 12818, "MINPATK", 666, "MAXPATK", 720, "MINMATK", 666, "MAXMATK", 720, "DEF", 67, "MDEF", 67));
		AddPropertyOverrides("f_gele_57_1", MonsterId.Npanto_Baby, Properties("MHP", 12870, "MINPATK", 667, "MAXPATK", 721, "MINMATK", 667, "MAXMATK", 721, "DEF", 67, "MDEF", 67));
		AddPropertyOverrides("f_gele_57_1", MonsterId.Grummer, Properties("MHP", 12964, "MINPATK", 668, "MAXPATK", 722, "MINMATK", 668, "MAXMATK", 722, "DEF", 67, "MDEF", 67));
		AddPropertyOverrides("f_gele_57_1", MonsterId.Panto_Javelin_Gele, Properties("MHP", 13086, "MINPATK", 669, "MAXPATK", 724, "MINMATK", 669, "MAXMATK", 724, "DEF", 67, "MDEF", 67));

		// Monster Spawners ---------------------------------

		AddSpawner("f_gele_57_1.Id7", MonsterId.Npanto_Baby, min: 1, max: 1);


		// Monster Spawn Points -----------------------------

		// 'Npanto_Baby' GenType 142 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(-1184, -627, 1));

	}
}
