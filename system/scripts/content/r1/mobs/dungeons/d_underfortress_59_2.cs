//--- Melia Script -----------------------------------------------------------
// Royal Mausoleum Constructors' Chapel Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_underfortress_59_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DUnderfortress592MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_underfortress_59_2.Id1", MonsterId.FD_Spectra, 34, 45, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_2.Id2", MonsterId.FD_Spector_Gh_Purple, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_2.Id3", MonsterId.FD_Whip_Vine_Purple, 19, 25, TimeSpan.FromMilliseconds(120000), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_2.Id4", MonsterId.FD_Boss_Canceril, 0, 0, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_2.Id5", MonsterId.Rootcrystal_03, 19, 25, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_underfortress_59_2.Id6", MonsterId.FD_Spectra, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_2.Id7", MonsterId.FD_Spectra, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_2.Id8", MonsterId.FD_Colimen_Mage, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'FD_Spectra' GenType 31 Spawn Points
		AddSpawnPoint("d_underfortress_59_2.Id1", "d_underfortress_59_2", Rectangle(139, -134, 9999));

		// 'FD_Spector_Gh_Purple' GenType 32 Spawn Points
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(340, 238, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(-60, 759, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(-197, 763, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(-169, -737, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(423, -762, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(-998, -722, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(-902, -211, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(-960, 92, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(978, 220, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(1277, 147, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(141, 124, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(-55, 640, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(-39, 117, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(-147, -334, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(-1307, -709, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(-676, -704, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(-1341, -284, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(-1334, 165, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(-144, 606, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(-999, -440, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(-649, 144, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(-225, 683, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(-569, -281, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(-119, -220, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(-178, -873, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(162, -701, 200));
		AddSpawnPoint("d_underfortress_59_2.Id2", "d_underfortress_59_2", Rectangle(121, -836, 200));

		// 'FD_Whip_Vine_Purple' GenType 33 Spawn Points
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(50, -793, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-388, -220, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-391, -245, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-436, -222, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-435, -247, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-421, -232, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-477, -223, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-479, -249, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-471, -239, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-678, -220, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-691, -264, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-680, -248, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-729, -218, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-709, -233, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-731, -251, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-765, -222, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-775, -247, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-801, -224, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-975, 400, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-974, 429, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-967, 455, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-936, 481, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-942, 451, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-939, 411, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-954, 395, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(-968, 496, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(57, -739, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(90, -730, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(118, -710, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(155, -731, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(133, -761, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(170, -758, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(99, -807, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(64, -772, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(133, -816, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(93, -759, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(153, -792, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(113, -785, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(186, -795, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(591, 220, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(593, 197, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(591, 165, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(632, 164, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(625, 192, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(634, 220, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(661, 217, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(655, 189, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(663, 166, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(664, 151, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(700, 162, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(694, 187, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(701, 215, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(614, 215, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(734, 224, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(725, 194, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(721, 170, 10));
		AddSpawnPoint("d_underfortress_59_2.Id3", "d_underfortress_59_2", Rectangle(717, 155, 10));

		// 'FD_Boss_Canceril' GenType 34 Spawn Points
		AddSpawnPoint("d_underfortress_59_2.Id4", "d_underfortress_59_2", Rectangle(811, 1155, 20));

		// 'Rootcrystal_03' GenType 35 Spawn Points
		AddSpawnPoint("d_underfortress_59_2.Id5", "d_underfortress_59_2", Rectangle(124, 206, 100));
		AddSpawnPoint("d_underfortress_59_2.Id5", "d_underfortress_59_2", Rectangle(91, -244, 100));
		AddSpawnPoint("d_underfortress_59_2.Id5", "d_underfortress_59_2", Rectangle(148, -766, 100));
		AddSpawnPoint("d_underfortress_59_2.Id5", "d_underfortress_59_2", Rectangle(-174, -770, 100));
		AddSpawnPoint("d_underfortress_59_2.Id5", "d_underfortress_59_2", Rectangle(432, -800, 100));
		AddSpawnPoint("d_underfortress_59_2.Id5", "d_underfortress_59_2", Rectangle(997, -768, 100));
		AddSpawnPoint("d_underfortress_59_2.Id5", "d_underfortress_59_2", Rectangle(975, -211, 100));
		AddSpawnPoint("d_underfortress_59_2.Id5", "d_underfortress_59_2", Rectangle(1292, 183, 100));
		AddSpawnPoint("d_underfortress_59_2.Id5", "d_underfortress_59_2", Rectangle(874, 190, 100));
		AddSpawnPoint("d_underfortress_59_2.Id5", "d_underfortress_59_2", Rectangle(395, 188, 100));
		AddSpawnPoint("d_underfortress_59_2.Id5", "d_underfortress_59_2", Rectangle(547, 1115, 100));
		AddSpawnPoint("d_underfortress_59_2.Id5", "d_underfortress_59_2", Rectangle(737, 921, 100));
		AddSpawnPoint("d_underfortress_59_2.Id5", "d_underfortress_59_2", Rectangle(599, 944, 100));
		AddSpawnPoint("d_underfortress_59_2.Id5", "d_underfortress_59_2", Rectangle(89, 1092, 100));
		AddSpawnPoint("d_underfortress_59_2.Id5", "d_underfortress_59_2", Rectangle(-89, 711, 100));
		AddSpawnPoint("d_underfortress_59_2.Id5", "d_underfortress_59_2", Rectangle(328, 684, 100));
		AddSpawnPoint("d_underfortress_59_2.Id5", "d_underfortress_59_2", Rectangle(-977, 161, 100));
		AddSpawnPoint("d_underfortress_59_2.Id5", "d_underfortress_59_2", Rectangle(-953, -344, 100));
		AddSpawnPoint("d_underfortress_59_2.Id5", "d_underfortress_59_2", Rectangle(-912, -755, 100));
		AddSpawnPoint("d_underfortress_59_2.Id5", "d_underfortress_59_2", Rectangle(-459, -243, 100));

		// 'FD_Spectra' GenType 36 Spawn Points
		AddSpawnPoint("d_underfortress_59_2.Id6", "d_underfortress_59_2", Rectangle(-953, -810, 30));
		AddSpawnPoint("d_underfortress_59_2.Id6", "d_underfortress_59_2", Rectangle(-951, -584, 30));
		AddSpawnPoint("d_underfortress_59_2.Id6", "d_underfortress_59_2", Rectangle(-960, -367, 30));
		AddSpawnPoint("d_underfortress_59_2.Id6", "d_underfortress_59_2", Rectangle(-967, -70, 30));
		AddSpawnPoint("d_underfortress_59_2.Id6", "d_underfortress_59_2", Rectangle(-940, 302, 30));

		// 'FD_Spectra' GenType 40 Spawn Points
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(516, -767, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(325, -760, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(404, -859, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(-243, -780, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(-189, -629, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(-153, -878, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(-909, -244, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(864, -781, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(978, -695, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(-765, -246, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(1093, -853, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(27, 82, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(320, 741, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(-134, 117, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(1006, -88, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(867, -194, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(1065, -220, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(1097, 139, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(1026, 224, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(-97, 697, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(1201, 163, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(722, 1010, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(433, 655, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(916, 220, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(726, 188, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(77, 543, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(112, 248, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(-1015, 181, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(111, 803, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(-165, 1019, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(-33, 1136, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(442, 950, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(-189, -299, 25));
		AddSpawnPoint("d_underfortress_59_2.Id7", "d_underfortress_59_2", Rectangle(373, 200, 25));

		// 'FD_Colimen_Mage' GenType 41 Spawn Points
		AddSpawnPoint("d_underfortress_59_2.Id8", "d_underfortress_59_2", Rectangle(-47, -235, 9999));
	}
}
