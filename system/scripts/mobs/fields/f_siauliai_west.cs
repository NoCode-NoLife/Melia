using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

internal class FieldSialuliaiWestMobScript : GeneralScript
{
	public override void Load()
	{
		// Kepa Test Spawn
		AddSpawner("Onion", 5, TimeSpan.FromSeconds(5), "f_siauliai_west", Area(-555, -1105, -655, -1105, -655, -1205, -555, -1205));
		AddSpawner("Onion_Big", 1, TimeSpan.FromSeconds(60), "f_siauliai_west", Spot(-575, -1300));
	}
}
