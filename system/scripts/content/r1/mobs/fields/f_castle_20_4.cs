//--- Melia Script -----------------------------------------------------------
// City Wall District 8 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_castle_20_4'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle204MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_castle_20_4.Id1", MonsterId.Rootcrystal_01, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("f_castle_20_4.Id2", MonsterId.Shardstatue_Black, min: 15, max: 20);
		AddSpawner("f_castle_20_4.Id3", MonsterId.Templeslave_Black, min: 15, max: 20);
		AddSpawner("f_castle_20_4.Id4", MonsterId.Templeslave_Sword_Black, min: 15, max: 20);
		AddSpawner("f_castle_20_4.Id5", MonsterId.Templeslave_Sword_Black, min: 19, max: 25);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 25 Spawn Points
		AddSpawnPoint("f_castle_20_4.Id1", "f_castle_20_4", Rectangle(34, -868, 100));
		AddSpawnPoint("f_castle_20_4.Id1", "f_castle_20_4", Rectangle(-1445, -263, 100));
		AddSpawnPoint("f_castle_20_4.Id1", "f_castle_20_4", Rectangle(-1175, -115, 100));
		AddSpawnPoint("f_castle_20_4.Id1", "f_castle_20_4", Rectangle(-410, -374, 100));
		AddSpawnPoint("f_castle_20_4.Id1", "f_castle_20_4", Rectangle(-763, 81, 100));
		AddSpawnPoint("f_castle_20_4.Id1", "f_castle_20_4", Rectangle(-743, 761, 100));
		AddSpawnPoint("f_castle_20_4.Id1", "f_castle_20_4", Rectangle(-1150, 1097, 100));
		AddSpawnPoint("f_castle_20_4.Id1", "f_castle_20_4", Rectangle(-1437, 904, 100));
		AddSpawnPoint("f_castle_20_4.Id1", "f_castle_20_4", Rectangle(4, 395, 100));
		AddSpawnPoint("f_castle_20_4.Id1", "f_castle_20_4", Rectangle(-551, 704, 100));
		AddSpawnPoint("f_castle_20_4.Id1", "f_castle_20_4", Rectangle(797, 546, 100));
		AddSpawnPoint("f_castle_20_4.Id1", "f_castle_20_4", Rectangle(438, 67, 100));
		AddSpawnPoint("f_castle_20_4.Id1", "f_castle_20_4", Rectangle(1247, -384, 100));
		AddSpawnPoint("f_castle_20_4.Id1", "f_castle_20_4", Rectangle(1241, 1055, 100));
		AddSpawnPoint("f_castle_20_4.Id1", "f_castle_20_4", Rectangle(73, 1097, 100));

		// 'Shardstatue_Black' GenType 26 Spawn Points
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(-702, -380, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(-207, -387, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(25, -304, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(-10, 281, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(77, 661, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(-224, 676, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(-407, 841, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(-555, 719, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(-310, 551, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(-380, 681, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(-302, 82, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(-395, 253, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(-553, 112, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(-490, -76, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(-291, -55, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(-431, 116, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(47, 107, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(-7, -92, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(4, 815, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(35, 443, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(-494, -352, 35));
		AddSpawnPoint("f_castle_20_4.Id2", "f_castle_20_4", Rectangle(-2, 1023, 35));

		// 'Templeslave_Black' GenType 27 Spawn Points
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-805, -298, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-702, -118, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-771, 69, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-683, 199, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-757, 490, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-721, 655, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-782, 909, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-744, 1121, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-1034, 1026, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-1273, 1134, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-1425, 994, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-1276, 878, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-1363, 476, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-1466, 367, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-1389, 264, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-1288, -361, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-1428, -243, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-1307, -92, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-1184, -241, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-1339, 377, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-1219, 978, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-800, -84, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-776, 284, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-976, 1041, 35));
		AddSpawnPoint("f_castle_20_4.Id3", "f_castle_20_4", Rectangle(-1285, 456, 35));

		// 'Templeslave_Sword_Black' GenType 28 Spawn Points
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(190, -420, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(359, -346, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(613, -414, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(917, -405, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(1297, -283, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(1241, 9, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(1313, 191, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(1203, 273, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(1239, 586, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(1282, 774, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(1208, 870, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(1249, 993, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(1113, 1076, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(1293, 1187, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(1382, 1014, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(-47, -399, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(40, 27, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(-26, 188, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(-12, 636, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(35, 934, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(394, 1194, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(-532, 1155, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(-423, 1216, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(-282, 1141, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(-178, 1213, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(-132, 1121, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(53, 1212, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(150, 1137, 35));
		AddSpawnPoint("f_castle_20_4.Id4", "f_castle_20_4", Rectangle(341, 1169, 35));

		// 'Templeslave_Sword_Black' GenType 29 Spawn Points
		AddSpawnPoint("f_castle_20_4.Id5", "f_castle_20_4", Rectangle(16, -248, 9999));
	}
}
