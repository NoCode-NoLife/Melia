//--- Melia Script -----------------------------------------------------------
// f_gele_57_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Srautas Gorge' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FGele571MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_gele_57_1", MonsterId.Zignuts, Properties("MHP", 12818, "MINPATK", 666, "MAXPATK", 720, "MINMATK", 666, "MAXMATK", 720, "DEF", 67, "MDEF", 67));
		AddPropertyOverrides("f_gele_57_1", MonsterId.Npanto_Baby, Properties("MHP", 12870, "MINPATK", 667, "MAXPATK", 721, "MINMATK", 667, "MAXMATK", 721, "DEF", 67, "MDEF", 67));
		AddPropertyOverrides("f_gele_57_1", MonsterId.Grummer, Properties("MHP", 12964, "MINPATK", 668, "MAXPATK", 722, "MINMATK", 668, "MAXMATK", 722, "DEF", 67, "MDEF", 67));
		AddPropertyOverrides("f_gele_57_1", MonsterId.Panto_Javelin_Gele, Properties("MHP", 13086, "MINPATK", 669, "MAXPATK", 724, "MINMATK", 669, "MAXMATK", 724, "DEF", 67, "MDEF", 67));

		// Monster Spawners ---------------------------------

		AddSpawner("f_gele_57_1.Id1", MonsterId.Npanto_Baby, 11, 14, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_1.Id2", MonsterId.Zignuts, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_1.Id3", MonsterId.Zignuts, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_1.Id4", MonsterId.Npanto_Baby, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_1.Id5", MonsterId.Rootcrystal_01, 10, 13, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_gele_57_1.Id6", MonsterId.Grummer, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_1.Id7", MonsterId.Npanto_Baby, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_1.Id8", MonsterId.Npanto_Baby, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_1.Id9", MonsterId.Grummer, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_gele_57_1.Id10", MonsterId.Panto_Javelin_Gele, 1, 1, TimeSpan.FromMilliseconds(1800000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Npanto_Baby' GenType 111 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1399.7583, -44.12083, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1411.7942, 522.7712, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1560.4501, -24.263607, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1467.9062, 89.17064, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1345.2927, 148.55746, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1316.5066, 16.225428, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1214.13, -92.44729, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1336.7306, -190.83617, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1489.2483, -161.42554, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1508.4558, 468.72015, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1393.4464, 621.455, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1225.7021, 575.03125, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1296.1957, 442.07513, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1389.6091, 317.04657, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1510.9475, 356.9562, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1306.575, 528.8367, 30));
		AddSpawnPoint("f_gele_57_1.Id1", "f_gele_57_1", Rectangle(-1398.059, 422.56033, 30));

		// 'Zignuts' GenType 126 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id2", "f_gele_57_1", Rectangle(639.3038, -546.13257, 9999));

		// 'Zignuts' GenType 128 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id3", "f_gele_57_1", Rectangle(-218.40988, -1569.1755, 200));
		AddSpawnPoint("f_gele_57_1.Id3", "f_gele_57_1", Rectangle(659.0181, -517.552, 200));

		// 'Npanto_Baby' GenType 129 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id4", "f_gele_57_1", Rectangle(-1354.86, 29.04, 9999));

		// 'Rootcrystal_01' GenType 134 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(-1185.13, -898.58, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(-1223.42, -536.13, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(-1308.3, -20.84, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(-1380.32, 523.34, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(-437.83, -702.27, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(-150.24, -946.61, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(-207.17, -1519.87, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(581.2, -1461.42, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(509.18, -534.3, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(-24.11, -629.78, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(197.05, 447.53, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(766.68, 478.56, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(1320.63, 782.03, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(1510.2, 431.15, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(1795.64, 94.29, 10));
		AddSpawnPoint("f_gele_57_1.Id5", "f_gele_57_1", Rectangle(741.62, 1134.57, 10));

		// 'Grummer' GenType 140 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id6", "f_gele_57_1", Rectangle(-225.5867, -1594.7148, 200));

		// 'Npanto_Baby' GenType 142 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(40.96863, 411.78735, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(686.9008, 431.2523, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1757.9934, 135.30379, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1395.0591, 654.1738, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1069.9984, 936.804, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(35.17469, 321.6129, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(233.65234, 442.3176, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(241.16638, 321.85513, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(381.20468, 277.16727, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(410.51077, 448.965, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(141.61261, 390.53793, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(341.14517, 366.79044, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(631.882, 317.13873, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(783.34045, 304.3966, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(819.9591, 475.2583, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(631.50336, 526.3478, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(705.6794, 586.5405, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(512.77637, 405.63876, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1176.9749, 697.7831, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1293.7582, 574.37994, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1341.6038, 750.2809, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1435.097, 822.64923, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1501.7394, 641.75745, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1788.9845, 237.83397, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1659.8701, 103.34049, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1742.3783, 36.151424, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1905.9004, 165.0033, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1857.7269, 25.665667, 20));
		AddSpawnPoint("f_gele_57_1.Id7", "f_gele_57_1", Rectangle(1666.0602, 240.6097, 20));

		// 'Npanto_Baby' GenType 143 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id8", "f_gele_57_1", Rectangle(330.0985, -602.9194, 20));
		AddSpawnPoint("f_gele_57_1.Id8", "f_gele_57_1", Rectangle(665.8473, -454.62936, 20));
		AddSpawnPoint("f_gele_57_1.Id8", "f_gele_57_1", Rectangle(542.905, -428.18756, 20));
		AddSpawnPoint("f_gele_57_1.Id8", "f_gele_57_1", Rectangle(664.4, -568.1398, 20));
		AddSpawnPoint("f_gele_57_1.Id8", "f_gele_57_1", Rectangle(557.7841, -664.31537, 20));
		AddSpawnPoint("f_gele_57_1.Id8", "f_gele_57_1", Rectangle(534.10034, -567.97125, 20));
		AddSpawnPoint("f_gele_57_1.Id8", "f_gele_57_1", Rectangle(788.3128, -409.16138, 20));
		AddSpawnPoint("f_gele_57_1.Id8", "f_gele_57_1", Rectangle(790.245, -581.067, 20));

		// 'Grummer' GenType 144 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id9", "f_gele_57_1", Rectangle(504.5816, -658.6849, 30));
		AddSpawnPoint("f_gele_57_1.Id9", "f_gele_57_1", Rectangle(692.91315, -421.07605, 30));
		AddSpawnPoint("f_gele_57_1.Id9", "f_gele_57_1", Rectangle(659.53174, -571.6743, 30));
		AddSpawnPoint("f_gele_57_1.Id9", "f_gele_57_1", Rectangle(533.9211, -502.57013, 30));
		AddSpawnPoint("f_gele_57_1.Id9", "f_gele_57_1", Rectangle(820.5499, -462.34274, 30));
		AddSpawnPoint("f_gele_57_1.Id9", "f_gele_57_1", Rectangle(377.09106, -592.18823, 30));

		// 'Panto_Javelin_Gele' GenType 149 Spawn Points
		AddSpawnPoint("f_gele_57_1.Id10", "f_gele_57_1", Rectangle(721.9436, -514.4319, 100));
	}
}
