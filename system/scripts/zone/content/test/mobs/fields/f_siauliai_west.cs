using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

internal class FieldSialuliaiWestMobScript : GeneralScript
{
	public override void Load()
	{
		AddPropertyOverrides("f_siauliai_west", MonsterId.Onion, Properties("MHP", 660, "MINPATK", 112, "MAXPATK", 120, "MINMATK", 112, "MAXMATK", 120, "DEF", 10, "MDEF", 10));
		AddPropertyOverrides("f_siauliai_west", MonsterId.Onion_Big, Properties("MHP", 1385, "MINPATK", 145, "MAXPATK", 156, "MINMATK", 145, "MAXMATK", 156, "DEF", 14, "MDEF", 14));

		// Kepa Test Spawn
		AddSpawner(MonsterId.Onion, 5, TimeSpan.FromSeconds(5), "f_siauliai_west", Area(-555, -1105, -655, -1105, -655, -1205, -555, -1205));
		AddSpawner(MonsterId.Onion_Big, 1, TimeSpan.FromSeconds(60), "f_siauliai_west", Spot(-575, -1300));
	}
}
