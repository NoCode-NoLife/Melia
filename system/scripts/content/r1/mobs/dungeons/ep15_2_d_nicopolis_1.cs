//--- Melia Script -----------------------------------------------------------
// Secret Laboratory Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'ep15_2_d_nicopolis_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep152DNicopolis1MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep15_2_d_nicopolis_1", MonsterId.Ep15_2_Papillon_Solider, Properties("MHP", 62078216, "MINPATK", 100000, "MAXPATK", 100000, "MINMATK", 100000, "MAXMATK", 100000, "DEF", 4500000, "MDEF", 4500000));
		AddPropertyOverrides("ep15_2_d_nicopolis_1", MonsterId.Ep15_2_Papillon_Assassin, Properties("MHP", 62078216, "MINPATK", 100000, "MAXPATK", 100000, "MINMATK", 100000, "MAXMATK", 100000, "DEF", 4500000, "MDEF", 4500000));
		AddPropertyOverrides("ep15_2_d_nicopolis_1", MonsterId.Ep15_2_Papillon_Leader, Properties("MHP", 62078216, "MINPATK", 170000, "MAXPATK", 170000, "MINMATK", 170000, "MAXMATK", 170000, "DEF", 4500000, "MDEF", 4500000));
		AddPropertyOverrides("ep15_2_d_nicopolis_1", MonsterId.Boss_Upinis_Q1, Properties("MHP", 216234656, "MINPATK", 180000, "MAXPATK", 180000, "MINMATK", 180000, "MAXMATK", 180000, "DEF", 4500000, "MDEF", 4500000));

		// Monster Spawners ---------------------------------

		AddSpawner("ep15_2_d_nicopolis_1.Id1", MonsterId.Ep15_2_Papillon_Solider, min: 34, max: 45, respawn: TimeSpan.FromMilliseconds(15000));
		AddSpawner("ep15_2_d_nicopolis_1.Id2", MonsterId.Ep15_2_Papillon_Assassin, min: 34, max: 45, respawn: TimeSpan.FromMilliseconds(15000));
		AddSpawner("ep15_2_d_nicopolis_1.Id3", MonsterId.Ep15_2_Papillon_Leader, min: 4, max: 5, respawn: TimeSpan.FromMilliseconds(15000));

		// Monster Spawn Points -----------------------------

		// 'Ep15_2_Papillon_Solider' GenType 9 Spawn Points
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(402, -907, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(458, -970, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(301, -782, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(177, -663, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(25, -668, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(-100, -785, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(-107, -1029, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(-246, -637, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(-111, -1257, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(-99, -1429, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(-128, -1566, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(-76, -1184, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(-105, -887, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(242, -517, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(323, -512, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(294, -356, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(312, -247, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(-50, 138, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(-4, 367, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(40, 657, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(325, 637, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(527, 750, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(262, -652, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(74, -291, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(-173, -253, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(-207, -394, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(-94, -534, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(-14, -93, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(132, 839, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(458, 879, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(579, -1021, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id1", "ep15_2_d_nicopolis_1", Rectangle(538, -1059, 20));

		// 'Ep15_2_Papillon_Assassin' GenType 14 Spawn Points
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(683, 668, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(684, 833, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(460, 664, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(438, 799, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(341, 864, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(262, 767, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(-91, 390, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(-69, 683, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(42, 828, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(171, 702, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(-166, 884, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(-38, 889, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(-317, 692, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(-263, 854, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(-441, 841, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(-469, 701, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(-674, 687, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(-563, 889, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(-680, 918, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(-797, 660, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(-798, 964, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(-111, 35, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(25, -9, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(111, -161, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(-157, -178, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(22, 246, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id2", "ep15_2_d_nicopolis_1", Rectangle(-107, 546, 20));

		// 'Ep15_2_Papillon_Leader' GenType 15 Spawn Points
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id3", "ep15_2_d_nicopolis_1", Rectangle(-556, 791, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id3", "ep15_2_d_nicopolis_1", Rectangle(-700, 813, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id3", "ep15_2_d_nicopolis_1", Rectangle(-682, 591, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id3", "ep15_2_d_nicopolis_1", Rectangle(-805, 786, 20));
		AddSpawnPoint("ep15_2_d_nicopolis_1.Id3", "ep15_2_d_nicopolis_1", Rectangle(-835, 917, 20));
	}
}
