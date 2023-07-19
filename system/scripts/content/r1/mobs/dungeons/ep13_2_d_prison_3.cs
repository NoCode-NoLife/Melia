//--- Melia Script -----------------------------------------------------------
// ep13_2_d_prison_3
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Ashaq Underground Prison Containment Area' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep132DPrison3MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep13_2_d_prison_3", MonsterId.Episode13_2_Wendigo_Dump, Properties("MHP", 1007073, "MINPATK", 13451, "MAXPATK", 16434, "MINMATK", 13451, "MAXMATK", 16434, "DEF", 485122, "MDEF", 485122));
		AddPropertyOverrides("ep13_2_d_prison_3", MonsterId.Episode13_2_Wendigo, Properties("MHP", 1013010, "MINPATK", 13527, "MAXPATK", 16528, "MINMATK", 13527, "MAXMATK", 16528, "DEF", 492826, "MDEF", 492826));
		AddPropertyOverrides("ep13_2_d_prison_3", MonsterId.Episode13_2_Dumaro, Properties("MHP", 1019744, "MINPATK", 13613, "MAXPATK", 16634, "MINMATK", 13613, "MAXMATK", 16634, "DEF", 501563, "MDEF", 501563));
		AddPropertyOverrides("ep13_2_d_prison_3", MonsterId.Boss_Insane_Marnoks, Properties("MHP", 5608458, "MINPATK", 37837, "MAXPATK", 46235, "MINMATK", 37837, "MAXMATK", 46235, "DEF", 1410981, "MDEF", 1410981));

		// Monster Spawners ---------------------------------

		AddSpawner("ep13_2_d_prison_3.Id1", MonsterId.Episode13_2_Wendigo_Dump, 100, 133, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("ep13_2_d_prison_3.Id2", MonsterId.Episode13_2_Wendigo, 16, 21, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("ep13_2_d_prison_3.Id3", MonsterId.Episode13_2_Dumaro, 12, 16, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("ep13_2_d_prison_3.Id4", MonsterId.Rootcrystal_01, 11, 14, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Episode13_2_Wendigo_Dump' GenType 1 Spawn Points
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(279.46967, -1088.0493, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(233.95923, -729.58673, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(415.82123, -849.26733, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(598.9695, -718.99677, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(564.19904, -1084.9612, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(546.19525, 55.273224, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(598.63495, 259.7208, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(752.4231, -37.41585, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(770.18, 281.7255, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(907.12085, 100.28314, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(701.514, 736.4634, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(705.1215, 1040.4382, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(652.8431, 891.50366, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(520.8208, 746.1339, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(524.7722, 1003.1404, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(309.1122, 733.2297, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(311.45016, 998.2895, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-258.0763, 802.3962, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-334.36096, 595.7209, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-469.251, 718.04755, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-415.84897, 416.16208, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-574.58026, 535.58545, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-595.742, 823.1901, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-615.629, -104.11755, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-665.9532, -365.58374, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-864.7708, -379.81488, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-949.6958, -111.64709, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-949.6958, -220.3548, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-843.8072, -1194.0151, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-809.6433, -975.2217, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-677.7305, -1074.3754, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-638.8285, -1248.8031, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-478.3888, -1216.4443, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-461.25043, -974.82117, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-133.7634, -227.67006, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-143.99013, -38.079704, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(-12.616996, 46.236485, 60));
		AddSpawnPoint("ep13_2_d_prison_3.Id1", "ep13_2_d_prison_3", Rectangle(50.80742, -158.87497, 60));

		// 'Episode13_2_Wendigo' GenType 2 Spawn Points
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(234.4385, -1063.2164, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(229.54219, -731.03656, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(551.8329, -1055.9708, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(553.12244, -721.09454, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(751.5477, -30.724125, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(548.5115, 51.812378, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(611.2414, 255.8865, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(771.4296, 274.98105, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(692.6519, 732.51807, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(677.8598, 897.00385, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(694.6876, 1035.9753, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(525.46484, 1007.7432, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(322.05957, 742.5546, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(508.78027, 738.29193, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(-131.57422, -220.74026, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(14.360334, 36.710663, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(-677.6012, -1077.076, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(-488.85812, -978.3763, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(394.30917, -855.8616, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(910.0668, 109.20509, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id2", "ep13_2_d_prison_3", Rectangle(327.53186, 988.91943, 10));

		// 'Episode13_2_Dumaro' GenType 3 Spawn Points
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-482.49594, 715.8537, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-850.6359, -1175.4081, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-814.659, -971.47046, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-501.8648, -1218.5594, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-672.3178, -375.27194, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-886.0865, -377.7279, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-788.77686, -121.41272, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-966.86237, -203.97705, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-624.8486, -106.94025, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-159.00903, -30.63983, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(33.011673, -162.75592, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-429.78253, 422.01074, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-341.03653, 589.5505, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-607.1061, 544.6932, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-300.7247, 786.9748, 10));
		AddSpawnPoint("ep13_2_d_prison_3.Id3", "ep13_2_d_prison_3", Rectangle(-613.426, 805.8004, 10));

		// 'Rootcrystal_01' GenType 53 Spawn Points
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(381.49164, -862.3214, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(558.1251, -332.7937, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(670.177, 515.9076, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(-148.77429, -1040.6105, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(-849.64453, -1075.8342, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(661.70715, 876.20703, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(34.974396, 828.31366, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(-808.87836, -644.00916, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(-670.4543, 194.9031, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(-377.6299, 477.33502, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(-498.92114, 851.3449, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(-229.92398, -155.13539, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(198.28922, -365.977, 100));
		AddSpawnPoint("ep13_2_d_prison_3.Id4", "ep13_2_d_prison_3", Rectangle(-248.0099, 196.60365, 100));
	}
}
