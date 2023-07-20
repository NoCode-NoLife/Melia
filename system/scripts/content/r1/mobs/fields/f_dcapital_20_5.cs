//--- Melia Script -----------------------------------------------------------
// Jeromel Park Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_dcapital_20_5'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FDcapital205MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_dcapital_20_5.Id1", MonsterId.Pumpkin_Dog, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_20_5.Id2", MonsterId.Scare_Crow, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_20_5.Id3", MonsterId.Straw_Walker, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_20_5.Id4", MonsterId.Straw_Walker, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_20_5.Id5", MonsterId.Rootcrystal_04, 15, 20, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Pumpkin_Dog' GenType 8 Spawn Points
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(38, -110, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-71, -205, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-55, -388, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(153, -466, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(271, -349, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(193, -191, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-101, -719, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-328, -129, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(80, 187, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(396, 114, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(753, 23, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(916, -95, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(942, 41, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(1100, 180, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(1181, -15, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(1310, 174, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(512, 651, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(641, 701, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(574, 766, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(407, 414, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(446, 278, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-109, 254, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-368, 459, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-423, 687, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-542, 836, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-884, 588, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-1131, 573, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-1274, 36, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-1140, -281, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-1294, -275, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-1064, 54, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-826, -245, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-599, -138, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(487, -603, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(117, -738, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(573, -123, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(1107, -686, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(1312, -703, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(582, -335, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-592, 644, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-1230, -736, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-1106, -824, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-764, -637, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-592, -754, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-543, -578, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-395, -300, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(618, 581, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-1107, -675, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-977, -589, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-955, -767, 35));
		AddSpawnPoint("f_dcapital_20_5.Id1", "f_dcapital_20_5", Rectangle(-627, -636, 35));

		// 'Scare_Crow' GenType 9 Spawn Points
		AddSpawnPoint("f_dcapital_20_5.Id2", "f_dcapital_20_5", Rectangle(-976, 453, 35));
		AddSpawnPoint("f_dcapital_20_5.Id2", "f_dcapital_20_5", Rectangle(-217, 58, 35));
		AddSpawnPoint("f_dcapital_20_5.Id2", "f_dcapital_20_5", Rectangle(-1062, 529, 35));
		AddSpawnPoint("f_dcapital_20_5.Id2", "f_dcapital_20_5", Rectangle(-604, 662, 35));
		AddSpawnPoint("f_dcapital_20_5.Id2", "f_dcapital_20_5", Rectangle(-587, 765, 35));
		AddSpawnPoint("f_dcapital_20_5.Id2", "f_dcapital_20_5", Rectangle(-458, 610, 35));
		AddSpawnPoint("f_dcapital_20_5.Id2", "f_dcapital_20_5", Rectangle(-314, 326, 35));
		AddSpawnPoint("f_dcapital_20_5.Id2", "f_dcapital_20_5", Rectangle(-223, 417, 35));
		AddSpawnPoint("f_dcapital_20_5.Id2", "f_dcapital_20_5", Rectangle(-203, 252, 35));
		AddSpawnPoint("f_dcapital_20_5.Id2", "f_dcapital_20_5", Rectangle(9, -454, 35));
		AddSpawnPoint("f_dcapital_20_5.Id2", "f_dcapital_20_5", Rectangle(-89, -305, 35));
		AddSpawnPoint("f_dcapital_20_5.Id2", "f_dcapital_20_5", Rectangle(158, -390, 35));
		AddSpawnPoint("f_dcapital_20_5.Id2", "f_dcapital_20_5", Rectangle(253, -440, 35));
		AddSpawnPoint("f_dcapital_20_5.Id2", "f_dcapital_20_5", Rectangle(243, -744, 35));
		AddSpawnPoint("f_dcapital_20_5.Id2", "f_dcapital_20_5", Rectangle(103, -347, 35));

		// 'Straw_Walker' GenType 19 Spawn Points
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(718, -101, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(846, -14, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(716, 76, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(955, 139, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(1118, 0, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(1275, 149, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(1255, 49, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(1200, 253, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(1177, 92, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(434, -50, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(224, 164, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(301, 222, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(531, -408, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(363, -691, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(175, -787, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(-232, -708, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(-239, -540, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(-435, -151, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(-703, -214, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(-360, -467, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(-108, -290, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(257, -603, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(304, -238, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(-16, -126, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(211, -74, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(145, -95, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(19, -263, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(-101, -497, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(-1240, -290, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(-1028, -233, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(-1367, -5, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(-1139, -3, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(119, -437, 35));
		AddSpawnPoint("f_dcapital_20_5.Id3", "f_dcapital_20_5", Rectangle(-434, -638, 35));

		// 'Straw_Walker' GenType 20 Spawn Points
		AddSpawnPoint("f_dcapital_20_5.Id4", "f_dcapital_20_5", Rectangle(308, -380, 9999));

		// 'Rootcrystal_04' GenType 25 Spawn Points
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(-1061, -802, 15));
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(-694, -618, 15));
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(-440, -720, 15));
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(-331, -316, 15));
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(-653, -189, 15));
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(-1217, -90, 15));
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(-87, 159, 15));
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(8, -364, 15));
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(262, -165, 15));
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(326, -725, 15));
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(596, -272, 15));
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(794, 94, 15));
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(1212, -43, 15));
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(537, 314, 15));
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(511, 748, 15));
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(-515, 719, 15));
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(-1013, 537, 15));
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(1227, -665, 15));
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(-379, 411, 15));
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(339, 94, 15));
		AddSpawnPoint("f_dcapital_20_5.Id5", "f_dcapital_20_5", Rectangle(-75, -733, 15));
	}
}
