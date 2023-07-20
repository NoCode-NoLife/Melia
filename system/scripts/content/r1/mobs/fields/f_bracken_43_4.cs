//--- Melia Script -----------------------------------------------------------
// Mollogheo Forest Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_bracken_43_4'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FBracken434MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_bracken_43_4.Id1", MonsterId.Vilkas_Warrior, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_4.Id2", MonsterId.Rootcrystal_03, 12, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_4.Id3", MonsterId.Vilkas_Spearman, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_4.Id4", MonsterId.Vilkas_Fighter, 1, 1, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_43_4.Id5", MonsterId.Vilkas_Mage, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Vilkas_Warrior' GenType 30 Spawn Points
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(1072, -780, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-112, -1248, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(765, -1043, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(1148, -464, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(1622, -412, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(1804, -322, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(1464, 168, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(1227, 707, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-537, -900, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-867, -1106, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-1410, -1322, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-1117, -1375, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-892, -861, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(632, -358, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(414, -310, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(316, -100, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-736, -189, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-1190, -433, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-1189, -102, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-1415, 439, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-73, -1059, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(718, 833, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(286, 906, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(54, -230, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-203, 215, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-600, 451, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(449, 762, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(927, 572, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(1137, 36, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(1462, -501, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-627, 662, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(106, -1097, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-410, 634, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-414, 330, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-1265, 579, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-1237, 248, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-1106, 364, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-1031, 179, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-1308, -233, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(-1180, -605, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(113, -101, 30));
		AddSpawnPoint("f_bracken_43_4.Id1", "f_bracken_43_4", Rectangle(267, -246, 30));

		// 'Rootcrystal_03' GenType 31 Spawn Points
		AddSpawnPoint("f_bracken_43_4.Id2", "f_bracken_43_4", Rectangle(-1208, -1186, 40));
		AddSpawnPoint("f_bracken_43_4.Id2", "f_bracken_43_4", Rectangle(-1227, -1489, 40));
		AddSpawnPoint("f_bracken_43_4.Id2", "f_bracken_43_4", Rectangle(-582, -940, 40));
		AddSpawnPoint("f_bracken_43_4.Id2", "f_bracken_43_4", Rectangle(-427, -285, 40));
		AddSpawnPoint("f_bracken_43_4.Id2", "f_bracken_43_4", Rectangle(450, -366, 40));
		AddSpawnPoint("f_bracken_43_4.Id2", "f_bracken_43_4", Rectangle(190, -1126, 40));
		AddSpawnPoint("f_bracken_43_4.Id2", "f_bracken_43_4", Rectangle(990, -899, 40));
		AddSpawnPoint("f_bracken_43_4.Id2", "f_bracken_43_4", Rectangle(1525, -485, 40));
		AddSpawnPoint("f_bracken_43_4.Id2", "f_bracken_43_4", Rectangle(1490, 150, 40));
		AddSpawnPoint("f_bracken_43_4.Id2", "f_bracken_43_4", Rectangle(1318, 703, 40));
		AddSpawnPoint("f_bracken_43_4.Id2", "f_bracken_43_4", Rectangle(475, 831, 40));
		AddSpawnPoint("f_bracken_43_4.Id2", "f_bracken_43_4", Rectangle(883, 166, 40));
		AddSpawnPoint("f_bracken_43_4.Id2", "f_bracken_43_4", Rectangle(-341, 420, 40));
		AddSpawnPoint("f_bracken_43_4.Id2", "f_bracken_43_4", Rectangle(-1241, 382, 40));
		AddSpawnPoint("f_bracken_43_4.Id2", "f_bracken_43_4", Rectangle(-1157, -336, 40));

		// 'Vilkas_Spearman' GenType 43 Spawn Points
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-1000, -1149, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-608, -187, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-509, -112, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-568, -359, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-568, -510, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-837, -202, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-577, -621, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(35, -142, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(145, -203, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-1265, -514, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-1304, -14, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-1098, 205, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-989, 321, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-1264, 526, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-1147, 76, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-1323, -408, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-725, -929, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-656, -1093, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-1329, -1483, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-1239, -1371, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-1493, -1305, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-1096, -1523, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-1084, -1227, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-432, -1057, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-139, -1165, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(22, -872, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(-102, -923, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(168, -950, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(69, -1198, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(416, -1084, 30));
		AddSpawnPoint("f_bracken_43_4.Id3", "f_bracken_43_4", Rectangle(635, -1052, 30));

		// 'Vilkas_Fighter' GenType 44 Spawn Points
		AddSpawnPoint("f_bracken_43_4.Id4", "f_bracken_43_4", Rectangle(1018, -628, 9999));

		// 'Vilkas_Mage' GenType 45 Spawn Points
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(0, 897, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(87, 979, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(393, 744, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(388, 1055, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(565, 1010, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(416, 896, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(619, 728, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(588, 609, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(1025, 641, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(1150, 849, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(1238, 600, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(889, -688, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(1062, -671, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(1070, -538, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(1228, -595, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(1355, -455, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(1644, -530, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(1668, -297, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(1799, -397, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(727, -1119, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(1003, -1172, 30));
		AddSpawnPoint("f_bracken_43_4.Id5", "f_bracken_43_4", Rectangle(947, -874, 30));
	}
}
