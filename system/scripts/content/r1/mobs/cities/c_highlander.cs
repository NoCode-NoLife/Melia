//--- Melia Script -----------------------------------------------------------
// Highlander Master's Training Hall Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'c_highlander'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class CHighlanderMobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("c_highlander.Id1", MonsterId.Wood_Carving_Fire, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("c_highlander.Id2", MonsterId.Wood_Carving_Poison, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("c_highlander.Id3", MonsterId.Wood_Carving_Lightning, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("c_highlander.Id4", MonsterId.Wood_Carving_Earth, amount: 1, respawn: TimeSpan.FromMilliseconds(60000));

		// Monster Spawn Points -----------------------------

		// 'Wood_Carving_Fire' GenType 24 Spawn Points
		AddSpawnPoint("c_highlander.Id1", "c_highlander", Rectangle(-32, -31, 10));

		// 'Wood_Carving_Poison' GenType 25 Spawn Points
		AddSpawnPoint("c_highlander.Id2", "c_highlander", Rectangle(28, -31, 10));

		// 'Wood_Carving_Lightning' GenType 26 Spawn Points
		AddSpawnPoint("c_highlander.Id3", "c_highlander", Rectangle(146, 92, 10));

		// 'Wood_Carving_Earth' GenType 27 Spawn Points
		AddSpawnPoint("c_highlander.Id4", "c_highlander", Rectangle(142, 28, 10));
	}
}
