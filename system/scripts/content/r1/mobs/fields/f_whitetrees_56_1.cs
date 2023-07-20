//--- Melia Script -----------------------------------------------------------
// Mishekan Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_whitetrees_56_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FWhitetrees561MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_whitetrees_56_1.Id1", MonsterId.Rootcrystal_03, 12, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_56_1.Id2", MonsterId.Floron, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_56_1.Id3", MonsterId.Florabbi, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_56_1.Id4", MonsterId.Budny, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_56_1.Id5", MonsterId.Bloom, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_56_1.Id6", MonsterId.Castle_Gardner, 1, 1, TimeSpan.FromMilliseconds(1800000), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_56_1.Id7", MonsterId.Florabbi, 7, 9, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 46 Spawn Points
		AddSpawnPoint("f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Rectangle(-170, 287, 10));
		AddSpawnPoint("f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Rectangle(-626, 857, 10));
		AddSpawnPoint("f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Rectangle(-1058, 356, 10));
		AddSpawnPoint("f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Rectangle(-1357, 1199, 10));
		AddSpawnPoint("f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Rectangle(177, 1201, 10));
		AddSpawnPoint("f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Rectangle(867, 913, 10));
		AddSpawnPoint("f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Rectangle(876, 137, 10));
		AddSpawnPoint("f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Rectangle(558, -569, 10));
		AddSpawnPoint("f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Rectangle(907, -640, 10));
		AddSpawnPoint("f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Rectangle(-31, -515, 10));
		AddSpawnPoint("f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Rectangle(1301, -417, 10));
		AddSpawnPoint("f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Rectangle(1518, 224, 10));
		AddSpawnPoint("f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Rectangle(1472, 1223, 10));
		AddSpawnPoint("f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Rectangle(1495, 588, 10));
		AddSpawnPoint("f_whitetrees_56_1.Id1", "f_whitetrees_56_1", Rectangle(-8, 521, 10));

		// 'Floron' GenType 67 Spawn Points
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(846, 28, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(832, 277, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(958, 167, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(1014, 28, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(307, -26, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(193, 38, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(0, 323, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(-81, 552, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(31, 644, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(41, 1037, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(47, 1334, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(630, 1186, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(862, 937, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(775, 839, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(776, 453, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(690, 248, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(1395, 374, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(1551, 224, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(1673, 396, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(1514, 515, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(1459, 660, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(1518, 990, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(1439, 1096, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(1355, 1161, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(1539, 1166, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(1405, 1002, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(284, 87, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(1548, 363, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id2", "f_whitetrees_56_1", Rectangle(1440, 1195, 30));

		// 'Florabbi' GenType 68 Spawn Points
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(820, -488, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(772, -730, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(619, -494, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(591, -647, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(921, -733, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(968, -565, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(757, -617, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-96, -562, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-7, -481, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(123, -571, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(191, -688, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(484, -581, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(1239, -423, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(1277, -313, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(1332, -346, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(1299, -562, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(1429, -552, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(1446, -414, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(1208, -213, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-764, -754, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-810, -675, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-729, -592, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-793, -563, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-903, -693, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-922, -773, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-975, -620, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-854, -499, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-912, -553, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-1217, 1164, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-1407, 1245, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-1312, 1136, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-1323, 1268, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-1297, 1364, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-1081, 452, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-1193, 329, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-944, 291, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-1037, 357, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-904, 461, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-1066, 540, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(-114, -435, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id3", "f_whitetrees_56_1", Rectangle(770, -321, 30));

		// 'Budny' GenType 69 Spawn Points
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-605, -268, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-450, -132, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-446, -270, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-343, -130, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-974, 354, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-993, 526, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-912, 535, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-798, 811, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-1296, 1123, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-1266, 1347, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-1031, 1144, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-725, 957, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-385, 717, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-292, 709, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-192, 513, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-87, 437, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-274, 145, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(11, 509, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(129, 338, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-233, -271, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-70, -503, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(264, -557, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(415, -527, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(639, -512, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(815, -422, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(840, -164, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(1146, -54, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(1152, -50, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(1316, -394, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(820, 102, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(873, 255, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(965, 434, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(824, 487, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(879, 839, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(721, 1071, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(540, 1019, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(494, 1057, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(39, 948, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(26, 1207, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(173, 1393, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(226, 1290, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(40, 732, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-136, 609, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-608, 1064, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-622, 741, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-493, 951, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-617, 879, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id4", "f_whitetrees_56_1", Rectangle(-485, 801, 30));

		// 'Bloom' GenType 71 Spawn Points
		AddSpawnPoint("f_whitetrees_56_1.Id5", "f_whitetrees_56_1", Rectangle(173, -550, 9999));

		// 'Castle_Gardner' GenType 72 Spawn Points
		AddSpawnPoint("f_whitetrees_56_1.Id6", "f_whitetrees_56_1", Rectangle(-184, 593, 9999));

		// 'Florabbi' GenType 73 Spawn Points
		AddSpawnPoint("f_whitetrees_56_1.Id7", "f_whitetrees_56_1", Rectangle(105, 1438, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id7", "f_whitetrees_56_1", Rectangle(187, 1260, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id7", "f_whitetrees_56_1", Rectangle(118, 1109, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id7", "f_whitetrees_56_1", Rectangle(-146, 456, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id7", "f_whitetrees_56_1", Rectangle(61, 357, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id7", "f_whitetrees_56_1", Rectangle(5, 609, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id7", "f_whitetrees_56_1", Rectangle(-751, 857, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id7", "f_whitetrees_56_1", Rectangle(-581, 1037, 30));
		AddSpawnPoint("f_whitetrees_56_1.Id7", "f_whitetrees_56_1", Rectangle(-496, 842, 30));
	}
}
