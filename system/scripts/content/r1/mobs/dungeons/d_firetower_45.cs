//--- Melia Script -----------------------------------------------------------
// Mage Tower 5F Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_firetower_45'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFiretower45MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_firetower_45", MonsterId.Dimmer, Properties("MHP", 119801, "MINPATK", 2042, "MAXPATK", 2411, "MINMATK", 2042, "MAXMATK", 2411, "DEF", 1823, "MDEF", 1823));
		AddPropertyOverrides("d_firetower_45", MonsterId.Tower_Of_Firepuppet_Black, Properties("MHP", 121520, "MINPATK", 2064, "MAXPATK", 2438, "MINMATK", 2064, "MAXMATK", 2438, "DEF", 1879, "MDEF", 1879));
		AddPropertyOverrides("d_firetower_45", MonsterId.Fire_Dragon_Purple, Properties("MHP", 123267, "MINPATK", 2086, "MAXPATK", 2466, "MINMATK", 2086, "MAXMATK", 2466, "DEF", 1936, "MDEF", 1936));
		AddPropertyOverrides("d_firetower_45", MonsterId.Boss_Helgasercle, Properties("MHP", 1022835, "MINPATK", 6285, "MAXPATK", 7432, "MINMATK", 6285, "MAXMATK", 7432, "DEF", 5942, "MDEF", 5942));

		// Monster Spawners ---------------------------------

		AddSpawner("d_firetower_45.Id1", MonsterId.Rootcrystal_01, 9, 12, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_firetower_45.Id2", MonsterId.Dimmer, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_45.Id3", MonsterId.Tower_Of_Firepuppet_Black, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_45.Id4", MonsterId.Fire_Dragon_Purple, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_45.Id5", MonsterId.Fire_Dragon_Purple, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_45.Id6", MonsterId.Dimmer, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_45.Id7", MonsterId.Tower_Of_Firepuppet_Black, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_45.Id8", MonsterId.Fire_Dragon_Purple, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_firetower_45.Id9", MonsterId.Dimmer, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 1 Spawn Points
		AddSpawnPoint("d_firetower_45.Id1", "d_firetower_45", Rectangle(-1254, -1707, 100));
		AddSpawnPoint("d_firetower_45.Id1", "d_firetower_45", Rectangle(-1617, -1272, 100));
		AddSpawnPoint("d_firetower_45.Id1", "d_firetower_45", Rectangle(-854, -1269, 100));
		AddSpawnPoint("d_firetower_45.Id1", "d_firetower_45", Rectangle(-1251, -754, 100));
		AddSpawnPoint("d_firetower_45.Id1", "d_firetower_45", Rectangle(-576, -645, 100));
		AddSpawnPoint("d_firetower_45.Id1", "d_firetower_45", Rectangle(-1569, -194, 100));
		AddSpawnPoint("d_firetower_45.Id1", "d_firetower_45", Rectangle(45, 120, 100));
		AddSpawnPoint("d_firetower_45.Id1", "d_firetower_45", Rectangle(-96, 1038, 100));
		AddSpawnPoint("d_firetower_45.Id1", "d_firetower_45", Rectangle(483, 641, 100));
		AddSpawnPoint("d_firetower_45.Id1", "d_firetower_45", Rectangle(-28, 1524, 100));
		AddSpawnPoint("d_firetower_45.Id1", "d_firetower_45", Rectangle(773, 1890, 100));
		AddSpawnPoint("d_firetower_45.Id1", "d_firetower_45", Rectangle(985, 1263, 100));

		// 'Dimmer' GenType 2 Spawn Points
		AddSpawnPoint("d_firetower_45.Id2", "d_firetower_45", Rectangle(-98, 41, 9999));

		// 'Tower_Of_Firepuppet_Black' GenType 3 Spawn Points
		AddSpawnPoint("d_firetower_45.Id3", "d_firetower_45", Rectangle(-73, 100, 9999));

		// 'Fire_Dragon_Purple' GenType 206 Spawn Points
		AddSpawnPoint("d_firetower_45.Id4", "d_firetower_45", Rectangle(-1240, -701, 9999));

		// 'Fire_Dragon_Purple' GenType 207 Spawn Points
		AddSpawnPoint("d_firetower_45.Id5", "d_firetower_45", Rectangle(-1243, -727, 25));
		AddSpawnPoint("d_firetower_45.Id5", "d_firetower_45", Rectangle(-957, -1269, 25));
		AddSpawnPoint("d_firetower_45.Id5", "d_firetower_45", Rectangle(-825, -56, 25));
		AddSpawnPoint("d_firetower_45.Id5", "d_firetower_45", Rectangle(-1201, -1284, 25));
		AddSpawnPoint("d_firetower_45.Id5", "d_firetower_45", Rectangle(-1276, -1407, 25));
		AddSpawnPoint("d_firetower_45.Id5", "d_firetower_45", Rectangle(-1347, -1263, 25));
		AddSpawnPoint("d_firetower_45.Id5", "d_firetower_45", Rectangle(-1259, -1204, 25));
		AddSpawnPoint("d_firetower_45.Id5", "d_firetower_45", Rectangle(-800, -1230, 25));
		AddSpawnPoint("d_firetower_45.Id5", "d_firetower_45", Rectangle(-661, -1332, 25));
		AddSpawnPoint("d_firetower_45.Id5", "d_firetower_45", Rectangle(-591, -1162, 25));
		AddSpawnPoint("d_firetower_45.Id5", "d_firetower_45", Rectangle(-1219, -900, 25));
		AddSpawnPoint("d_firetower_45.Id5", "d_firetower_45", Rectangle(-849, -664, 25));
		AddSpawnPoint("d_firetower_45.Id5", "d_firetower_45", Rectangle(-1219, -607, 25));
		AddSpawnPoint("d_firetower_45.Id5", "d_firetower_45", Rectangle(-1070, -623, 25));
		AddSpawnPoint("d_firetower_45.Id5", "d_firetower_45", Rectangle(-1224, -455, 25));
		AddSpawnPoint("d_firetower_45.Id5", "d_firetower_45", Rectangle(-1226, -1028, 25));

		// 'Dimmer' GenType 208 Spawn Points
		AddSpawnPoint("d_firetower_45.Id6", "d_firetower_45", Rectangle(-1228, -266, 100));
		AddSpawnPoint("d_firetower_45.Id6", "d_firetower_45", Rectangle(-1232, -1621, 100));
		AddSpawnPoint("d_firetower_45.Id6", "d_firetower_45", Rectangle(-576, -689, 100));

		// 'Tower_Of_Firepuppet_Black' GenType 209 Spawn Points
		AddSpawnPoint("d_firetower_45.Id7", "d_firetower_45", Rectangle(-927, -78, 200));
		AddSpawnPoint("d_firetower_45.Id7", "d_firetower_45", Rectangle(-1540, -187, 200));
		AddSpawnPoint("d_firetower_45.Id7", "d_firetower_45", Rectangle(-907, -688, 200));

		// 'Fire_Dragon_Purple' GenType 216 Spawn Points
		AddSpawnPoint("d_firetower_45.Id8", "d_firetower_45", Rectangle(-144, 977, 25));
		AddSpawnPoint("d_firetower_45.Id8", "d_firetower_45", Rectangle(-112, 1118, 25));
		AddSpawnPoint("d_firetower_45.Id8", "d_firetower_45", Rectangle(-10, 1016, 25));
		AddSpawnPoint("d_firetower_45.Id8", "d_firetower_45", Rectangle(578, 800, 25));
		AddSpawnPoint("d_firetower_45.Id8", "d_firetower_45", Rectangle(592, 966, 25));
		AddSpawnPoint("d_firetower_45.Id8", "d_firetower_45", Rectangle(477, 886, 25));
		AddSpawnPoint("d_firetower_45.Id8", "d_firetower_45", Rectangle(704, 861, 25));
		AddSpawnPoint("d_firetower_45.Id8", "d_firetower_45", Rectangle(50, 1414, 25));
		AddSpawnPoint("d_firetower_45.Id8", "d_firetower_45", Rectangle(24, 1553, 25));
		AddSpawnPoint("d_firetower_45.Id8", "d_firetower_45", Rectangle(-155, 1531, 25));
		AddSpawnPoint("d_firetower_45.Id8", "d_firetower_45", Rectangle(991, 1233, 25));
		AddSpawnPoint("d_firetower_45.Id8", "d_firetower_45", Rectangle(855, 1318, 25));
		AddSpawnPoint("d_firetower_45.Id8", "d_firetower_45", Rectangle(634, 1271, 25));
		AddSpawnPoint("d_firetower_45.Id8", "d_firetower_45", Rectangle(408, 1459, 25));
		AddSpawnPoint("d_firetower_45.Id8", "d_firetower_45", Rectangle(702, 1455, 25));

		// 'Dimmer' GenType 217 Spawn Points
		AddSpawnPoint("d_firetower_45.Id9", "d_firetower_45", Rectangle(996, 1290, 25));
		AddSpawnPoint("d_firetower_45.Id9", "d_firetower_45", Rectangle(59, 1518, 25));
		AddSpawnPoint("d_firetower_45.Id9", "d_firetower_45", Rectangle(-99, 1037, 25));
		AddSpawnPoint("d_firetower_45.Id9", "d_firetower_45", Rectangle(-219, 1043, 25));
		AddSpawnPoint("d_firetower_45.Id9", "d_firetower_45", Rectangle(960, 815, 25));
		AddSpawnPoint("d_firetower_45.Id9", "d_firetower_45", Rectangle(561, 863, 25));
		AddSpawnPoint("d_firetower_45.Id9", "d_firetower_45", Rectangle(726, 1603, 25));
		AddSpawnPoint("d_firetower_45.Id9", "d_firetower_45", Rectangle(779, 1866, 25));
		AddSpawnPoint("d_firetower_45.Id9", "d_firetower_45", Rectangle(660, 1364, 25));
		AddSpawnPoint("d_firetower_45.Id9", "d_firetower_45", Rectangle(353, 1408, 25));
		AddSpawnPoint("d_firetower_45.Id9", "d_firetower_45", Rectangle(646, 1169, 25));
	}
}
