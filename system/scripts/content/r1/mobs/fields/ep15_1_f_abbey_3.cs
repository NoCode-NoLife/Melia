//--- Melia Script -----------------------------------------------------------
// ep15_1_f_abbey_3
//
//--- Description -----------------------------------------------------------
// Sets up the ep15_1_f_abbey_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep151FAbbey3MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("ep15_1_f_abbey_3", MonsterId.Ep15_1_Goblin_Saman, Properties("MHP", 58987500, "MINPATK", 140000, "MAXPATK", 140000, "MINMATK", 140000, "MAXMATK", 140000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep15_1_f_abbey_3", MonsterId.Ep15_1_Goblin_Fighter, Properties("MHP", 58987500, "MINPATK", 140000, "MAXPATK", 140000, "MINMATK", 140000, "MAXMATK", 140000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("ep15_1_f_abbey_3", MonsterId.Ep15_1_Goblin_Elite, Properties("MHP", 58987500, "MINPATK", 140000, "MAXPATK", 140000, "MINMATK", 140000, "MAXMATK", 140000, "DEF", 3000000, "MDEF", 3000000));

		// Monster Spawners --------------------------------

		AddSpawner("ep15_1_f_abbey_3.Id1", MonsterId.Ep15_1_Goblin_Saman, 22, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("ep15_1_f_abbey_3.Id2", MonsterId.Ep15_1_Goblin_Fighter, 24, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("ep15_1_f_abbey_3.Id3", MonsterId.Ep15_1_Goblin_Elite, 20, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Ep15_1_Goblin_Saman Spawn Points
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(34.431885, -956.39307, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(78.415695, -860.18463, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(-34.298996, -871.99896, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(-108.91655, -968.14307, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(105.01773, -691.18524, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(-111.15063, -718.2157, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(-16.532387, -552.4167, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(5.3601685, -433.14563, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(251.93137, -846.6369, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(-212.75916, -956.0577, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(25.503796, -350.066, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(-184.45876, -646.5539, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(195.86606, -587.3948, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(-179.82664, -815.8679, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(232.3094, -731.2965, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(-4.2522507, 50.26711, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(114.18931, 218.92123, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(616.3046, 169.30649, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(-244.98634, 1293.1952, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(-123.37086, 1260.8483, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(240.06024, 1370.2319, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id1", "ep15_1_f_abbey_3", Spot(738.42017, -162.19696, 20));

		// Ep15_1_Goblin_Fighter Spawn Points
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(-182.85233, 271.4045, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(-192.25368, -65.19228, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(-0.7689285, -52.884666, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(124.94912, -70.52883, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(60.49295, 127.69231, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(-166.15213, 89.62076, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(139.23076, 117.29974, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(8.099499, -462.15192, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(-391.5939, 195.76709, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(-711.774, 134.45622, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(-831.2315, -135.11119, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(-845.9042, -385.21198, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(401.73865, 149.89778, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(623.67926, 150.95433, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(751.74146, 132.64578, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(746.9599, -122.16235, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(5.570281, 532.7529, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(-13.746941, 923.99774, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(-37.796967, 1093.0044, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(72.935776, -726.3148, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(15.816949, -1024.2217, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(-24.803085, 1207.8759, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(141.2012, 1198.9429, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id2", "ep15_1_f_abbey_3", Spot(-160.28783, 1151.2983, 20));

		// Ep15_1_Goblin_Elite Spawn Points
		AddSpawnPoint( "ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Spot(-139.50188, 1103.6653, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Spot(6.5619125, 692.6895, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Spot(-78.77284, 275.0356, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Spot(-68.10745, 19.384005, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Spot(9.035488, -383.5267, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Spot(-404.27216, 162.44734, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Spot(-766.22876, 75.71933, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Spot(-845.0654, -409.75558, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Spot(391.86923, 167.33774, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Spot(702.19214, 186.32133, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Spot(745.2682, -166.39516, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Spot(596.8919, -436.5135, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Spot(869.5351, -427.9405, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Spot(726.94446, -320.68158, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Spot(163.90384, -777.4642, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Spot(-110.94151, -688.8041, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Spot(-911.11365, -581.4118, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Spot(104.06271, 112.99251, 20));
		AddSpawnPoint( "ep15_1_f_abbey_3.Id3", "ep15_1_f_abbey_3", Spot(39.275642, 1282.5717, 20));

	}
}
