//--- Melia Script -----------------------------------------------------------
// Yudejan Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_whitetrees_21_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FWhitetrees211MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_whitetrees_21_1.Id1", MonsterId.Moringaga, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_1.Id2", MonsterId.Nabu, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_1.Id3", MonsterId.Moringbird, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_1.Id4", MonsterId.Moringbird, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_1.Id5", MonsterId.Rootcrystal_01, 9, 12, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Moringaga' GenType 1 Spawn Points
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(663, 202, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(768, 270, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(847, 81, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(613, 463, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(761, 790, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(705, 972, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(561, 992, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(328, 997, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(29, 861, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(53, 1065, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-236, 961, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-330, 1122, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-458, 1024, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-349, 904, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(466, 275, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(815, 635, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(518, 83, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(785, 510, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(840, 345, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-88, 295, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(46, 416, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-220, 431, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-113, 517, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-1, 559, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(177, 325, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-56, 413, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-83, 86, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-9, 1, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(127, -336, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(101, -496, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-119, -453, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-101, -596, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(332, -280, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(246, -316, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(433, -370, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-465, 445, 30));

		// 'Nabu' GenType 2 Spawn Points
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-685, -119, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-939, -238, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-927, -411, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-685, -448, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-575, -342, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-412, -510, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-203, -640, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(23, -421, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(79, -257, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(360, -399, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(601, -484, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(622, -612, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(918, -436, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(877, -706, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(1046, -606, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(749, -360, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-193, -515, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-139, -345, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-4, -57, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(811, -543, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(1118, -527, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(1517, -357, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(1427, -186, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(1611, -432, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(1554, -553, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(1348, -574, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(331, -309, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-1104, -308, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-870, -86, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-741, -253, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-533, 26, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(1392, -461, 30));

		// 'Moringbird' GenType 3 Spawn Points
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1149, 731, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1115, 300, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1324, 197, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1191, 390, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1236, 215, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1035, 350, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1612, 998, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1056, 1178, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1243, 1083, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-903, 885, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-810, 784, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(612, 903, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(711, 981, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(905, 833, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(848, 966, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(780, 698, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(734, 611, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(584, 421, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(832, 456, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(806, 258, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(682, 289, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(566, 226, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(716, 31, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(821, 85, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(662, 112, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(269, 335, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-112, 285, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1403, 964, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-993, 793, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-805, 422, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-582, 459, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-515, 416, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-407, 459, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-289, 388, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-115, 527, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1186, 937, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1020, 996, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(55, 338, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(10, 502, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1040, 198, 30));

		// 'Moringbird' GenType 4 Spawn Points
		AddSpawnPoint("f_whitetrees_21_1.Id4", "f_whitetrees_21_1", Rectangle(-76, 459, 9999));

		// 'Rootcrystal_01' GenType 7 Spawn Points
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(-1730, 1038, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(-1086, 912, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(-1268, 183, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(-679, -451, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(-380, 921, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(298, 996, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(778, 635, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(1401, -86, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(1215, -532, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(375, -345, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(403, 279, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(-840, 427, 100));
	}
}
