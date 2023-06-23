//--- Melia Script -----------------------------------------------------------
// ep13_2_d_prison_3
//
//--- Description -----------------------------------------------------------
// Sets up the ep13_2_d_prison_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep132DPrison3MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Populations
		AddMonsterPopulation("ep13_2_d_prison_3", "population_episode13_2_wendigo_dump_1", 133);
		AddMonsterPopulation("ep13_2_d_prison_3", "population_episode13_2_wendigo_2", 21);
		AddMonsterPopulation("ep13_2_d_prison_3", "population_episode13_2_dumaro_3", 16);
		AddMonsterPopulation("ep13_2_d_prison_3", "population_rootcrystal_01_4", 14);

		// RootCrystal Spawners
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_4", TimeSpan.FromMilliseconds(20000), "ep13_2_d_prison_3", Spot(381.49164, -862.3214, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_4", TimeSpan.FromMilliseconds(20000), "ep13_2_d_prison_3", Spot(558.1251, -332.7937, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_4", TimeSpan.FromMilliseconds(20000), "ep13_2_d_prison_3", Spot(670.177, 515.9076, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_4", TimeSpan.FromMilliseconds(20000), "ep13_2_d_prison_3", Spot(-148.77429, -1040.6105, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_4", TimeSpan.FromMilliseconds(20000), "ep13_2_d_prison_3", Spot(-849.64453, -1075.8342, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_4", TimeSpan.FromMilliseconds(20000), "ep13_2_d_prison_3", Spot(661.70715, 876.20703, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_4", TimeSpan.FromMilliseconds(20000), "ep13_2_d_prison_3", Spot(34.974396, 828.31366, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_4", TimeSpan.FromMilliseconds(20000), "ep13_2_d_prison_3", Spot(-808.87836, -644.00916, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_4", TimeSpan.FromMilliseconds(20000), "ep13_2_d_prison_3", Spot(-670.4543, 194.9031, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_4", TimeSpan.FromMilliseconds(20000), "ep13_2_d_prison_3", Spot(-377.6299, 477.33502, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_4", TimeSpan.FromMilliseconds(20000), "ep13_2_d_prison_3", Spot(-498.92114, 851.3449, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_4", TimeSpan.FromMilliseconds(20000), "ep13_2_d_prison_3", Spot(-229.92398, -155.13539, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_4", TimeSpan.FromMilliseconds(20000), "ep13_2_d_prison_3", Spot(198.28922, -365.977, 100));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_4", TimeSpan.FromMilliseconds(20000), "ep13_2_d_prison_3", Spot(-248.0099, 196.60365, 100));

		// Monster Spawners
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(279.46967, -1088.0493, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(233.95923, -729.58673, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(415.82123, -849.26733, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(598.9695, -718.99677, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(564.19904, -1084.9612, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(546.19525, 55.273224, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(598.63495, 259.7208, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(752.4231, -37.41585, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(770.18, 281.7255, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(907.12085, 100.28314, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(701.514, 736.4634, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(705.1215, 1040.4382, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(652.8431, 891.50366, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(520.8208, 746.1339, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(524.7722, 1003.1404, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(309.1122, 733.2297, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(311.45016, 998.2895, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-258.0763, 802.3962, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-334.36096, 595.7209, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-469.251, 718.04755, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-415.84897, 416.16208, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-574.58026, 535.58545, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-595.742, 823.1901, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-615.629, -104.11755, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-665.9532, -365.58374, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-864.7708, -379.81488, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-949.6958, -111.64709, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-949.6958, -220.3548, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-843.8072, -1194.0151, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-809.6433, -975.2217, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-677.7305, -1074.3754, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-638.8285, -1248.8031, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-478.3888, -1216.4443, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-461.25043, -974.82117, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-133.7634, -227.67006, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-143.99013, -38.079704, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-12.616996, 46.236485, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo_Dump, "population_episode13_2_wendigo_dump_1", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(50.80742, -158.87497, 60));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(234.4385, -1063.2164, 10));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(229.54219, -731.03656, 10));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(551.8329, -1055.9708, 10));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(553.12244, -721.09454, 10));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(751.5477, -30.724125, 10));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(548.5115, 51.812378, 10));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(611.2414, 255.8865, 10));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(771.4296, 274.98105, 10));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(692.6519, 732.51807, 10));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(677.8598, 897.00385, 10));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(694.6876, 1035.9753, 10));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(525.46484, 1007.7432, 10));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(322.05957, 742.5546, 10));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(508.78027, 738.29193, 10));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-131.57422, -220.74026, 10));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(14.360334, 36.710663, 10));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-677.6012, -1077.076, 10));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-488.85812, -978.3763, 10));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(394.30917, -855.8616, 10));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(910.0668, 109.20509, 10));
		AddSpawner(MonsterId.Episode13_2_Wendigo, "population_episode13_2_wendigo_2", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(327.53186, 988.91943, 10));
		AddSpawner(MonsterId.Episode13_2_Dumaro, "population_episode13_2_dumaro_3", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-482.49594, 715.8537, 10));
		AddSpawner(MonsterId.Episode13_2_Dumaro, "population_episode13_2_dumaro_3", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-850.6359, -1175.4081, 10));
		AddSpawner(MonsterId.Episode13_2_Dumaro, "population_episode13_2_dumaro_3", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-814.659, -971.47046, 10));
		AddSpawner(MonsterId.Episode13_2_Dumaro, "population_episode13_2_dumaro_3", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-501.8648, -1218.5594, 10));
		AddSpawner(MonsterId.Episode13_2_Dumaro, "population_episode13_2_dumaro_3", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-672.3178, -375.27194, 10));
		AddSpawner(MonsterId.Episode13_2_Dumaro, "population_episode13_2_dumaro_3", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-886.0865, -377.7279, 10));
		AddSpawner(MonsterId.Episode13_2_Dumaro, "population_episode13_2_dumaro_3", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-788.77686, -121.41272, 10));
		AddSpawner(MonsterId.Episode13_2_Dumaro, "population_episode13_2_dumaro_3", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-966.86237, -203.97705, 10));
		AddSpawner(MonsterId.Episode13_2_Dumaro, "population_episode13_2_dumaro_3", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-624.8486, -106.94025, 10));
		AddSpawner(MonsterId.Episode13_2_Dumaro, "population_episode13_2_dumaro_3", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-159.00903, -30.63983, 10));
		AddSpawner(MonsterId.Episode13_2_Dumaro, "population_episode13_2_dumaro_3", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(33.011673, -162.75592, 10));
		AddSpawner(MonsterId.Episode13_2_Dumaro, "population_episode13_2_dumaro_3", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-429.78253, 422.01074, 10));
		AddSpawner(MonsterId.Episode13_2_Dumaro, "population_episode13_2_dumaro_3", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-341.03653, 589.5505, 10));
		AddSpawner(MonsterId.Episode13_2_Dumaro, "population_episode13_2_dumaro_3", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-607.1061, 544.6932, 10));
		AddSpawner(MonsterId.Episode13_2_Dumaro, "population_episode13_2_dumaro_3", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-300.7247, 786.9748, 10));
		AddSpawner(MonsterId.Episode13_2_Dumaro, "population_episode13_2_dumaro_3", TimeSpan.FromMilliseconds(0), "ep13_2_d_prison_3", Spot(-613.426, 805.8004, 10));

	}
}
