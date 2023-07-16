//--- Melia Script -----------------------------------------------------------
// f_pilgrimroad_55
//
//--- Description -----------------------------------------------------------
// Sets up the f_pilgrimroad_55 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad55MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_pilgrimroad_55", MonsterId.Infro_Blud_Red, Properties("MHP", 153552, "MINPATK", 2476, "MAXPATK", 2945, "MINMATK", 2476, "MAXMATK", 2945, "DEF", 3638, "MDEF", 3638));
		AddPropertyOverrides("f_pilgrimroad_55", MonsterId.InfroHoglan_Red, Properties("MHP", 155431, "MINPATK", 2500, "MAXPATK", 2974, "MINMATK", 2500, "MAXMATK", 2974, "DEF", 3747, "MDEF", 3747));
		AddPropertyOverrides("f_pilgrimroad_55", MonsterId.Burialer, Properties("MHP", 157350, "MINPATK", 2525, "MAXPATK", 3005, "MINMATK", 2525, "MAXMATK", 3005, "DEF", 3857, "MDEF", 3857));

		// Monster Spawners --------------------------------

		AddSpawner("f_pilgrimroad_55.Id1", MonsterId.Infro_Blud_Red, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_55.Id2", MonsterId.InfroHoglan_Red, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_55.Id3", MonsterId.Rootcrystal_03, 12, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_55.Id4", MonsterId.Infro_Blud_Red, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_55.Id5", MonsterId.Burialer, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Infro_Blud_Red Spawn Points
		AddSpawnPoint( "f_pilgrimroad_55.Id1", "f_pilgrimroad_55", Spot(-723.02014, 189.75775, 9999));

		// InfroHoglan_Red Spawn Points
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(1331.5688, -129.42331, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(383.1402, -382.8172, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(975.52155, -709.0862, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(790.7411, -456.0045, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(1059.7958, -660.5695, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(703.87756, -483.08615, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(1291.067, -307.6932, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(1495.9191, -187.1565, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(472.56332, -403.55453, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(1432.4889, -514.93024, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(1394.303, -224.26617, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(1450.4712, -68.18451, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(1264.8533, -196.6284, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(1491.8433, -364.64865, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(1323.4723, -387.67926, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(1195.0627, -319.5944, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(1247.5525, -736.0549, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(1134.7665, -731.197, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(1022.1263, -561.4367, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(942.91254, -522.7706, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(852.7415, -655.884, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(865.2277, -456.7541, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(750.3308, -683.9512, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(798.44556, -580.4015, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(991.1814, -433.72034, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(1136.016, -481.3983, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(1189.6644, -638.9994, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(1430.9559, -643.41974, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(1268.0723, -536.23303, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(1089.2697, -388.14236, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(666.8941, -667.43976, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(559.88245, -637.67065, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(563.0218, -556.27136, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(625.76154, -499.6762, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(464.45215, -634.90076, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(472.25845, -510.03946, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(232.42426, -597.7571, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(172.15858, -520.8206, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(355.82965, -624.1173, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(275.47122, -669.7057, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(273.2229, -484.47382, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(129.32185, -297.8068, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(36.652435, -145.26624, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(209.09903, -263.5262, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-13.274338, -62.97768, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(33.45102, -346.29242, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-224.68367, -465.80142, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-236.83963, -147.77414, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-56.6102, -328.40082, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-104.7212, -112.05482, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-120.56798, 14.505878, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-151.70493, -263.8902, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-338.3154, -180.95631, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-423.24088, -285.29642, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-490.21027, -400.95633, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-422.49094, -527.9959, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-338.31796, -528.29034, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-370.07416, -71.15909, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-247.87646, -768.61127, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-165.92778, -769.3257, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-167.6727, -660.6982, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-289.182, -633.1076, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-18.466555, -625.65875, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(78.87493, -413.28174, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(22.198029, -497.25122, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-154.1085, -549.3853, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-70.4738, -443.01456, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(113.53194, -502.26544, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-286.35922, -400.63205, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-228.34772, -605.5774, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-616.25867, -18.500317, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-749.7761, -82.02611, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-515.27423, 101.42685, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-870.97473, -95.122604, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-919.2579, 6.171219, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-509.90625, 221.27847, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-737.528, 313.48132, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-982.89746, 88.411156, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-813.30743, 180.8216, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-1038.3275, 205.9537, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-1090.0808, 259.00403, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-1006.3759, 320.9577, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-399.8277, 332.07114, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-715.22504, 468.53488, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-841.0708, 357.5137, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-538.01697, 446.24585, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-626.2489, 363.7425, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-607.1476, 530.2226, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-437.4231, 602.602, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(-416.6953, 458.51337, 30));
		AddSpawnPoint( "f_pilgrimroad_55.Id2", "f_pilgrimroad_55", Spot(550.18286, -405.81866, 30));

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint( "f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Spot(1523.9097, -180.4932, 10));
		AddSpawnPoint( "f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Spot(1357.4326, -514.2827, 10));
		AddSpawnPoint( "f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Spot(957.1966, -564.70026, 10));
		AddSpawnPoint( "f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Spot(1094.8615, -696.4164, 10));
		AddSpawnPoint( "f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Spot(594.0869, -609.62744, 10));
		AddSpawnPoint( "f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Spot(237.27522, -357.83572, 10));
		AddSpawnPoint( "f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Spot(-233.40475, -404.60486, 10));
		AddSpawnPoint( "f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Spot(7.8986053, -158.91, 10));
		AddSpawnPoint( "f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Spot(-414.85004, 294.15433, 10));
		AddSpawnPoint( "f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Spot(-727.6111, 110.67187, 10));
		AddSpawnPoint( "f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Spot(-649.51843, 363.4472, 10));
		AddSpawnPoint( "f_pilgrimroad_55.Id3", "f_pilgrimroad_55", Spot(-499.48004, 613.8515, 10));

		// Infro_Blud_Red Spawn Points
		AddSpawnPoint( "f_pilgrimroad_55.Id4", "f_pilgrimroad_55", Spot(-70.991745, -553.3052, 35));
		AddSpawnPoint( "f_pilgrimroad_55.Id4", "f_pilgrimroad_55", Spot(-288.37592, -275.31366, 35));
		AddSpawnPoint( "f_pilgrimroad_55.Id4", "f_pilgrimroad_55", Spot(53.648815, -242.92209, 35));
		AddSpawnPoint( "f_pilgrimroad_55.Id4", "f_pilgrimroad_55", Spot(372.13177, -508.25238, 35));
		AddSpawnPoint( "f_pilgrimroad_55.Id4", "f_pilgrimroad_55", Spot(-258.18323, -679.49, 35));
		AddSpawnPoint( "f_pilgrimroad_55.Id4", "f_pilgrimroad_55", Spot(194.65128, -389.3437, 35));

		// Burialer Spawn Points
		AddSpawnPoint( "f_pilgrimroad_55.Id5", "f_pilgrimroad_55", Spot(-644.38544, 280.40823, 25));
		AddSpawnPoint( "f_pilgrimroad_55.Id5", "f_pilgrimroad_55", Spot(-885.318, 240.57275, 25));
		AddSpawnPoint( "f_pilgrimroad_55.Id5", "f_pilgrimroad_55", Spot(-255.6935, -20.658106, 25));
		AddSpawnPoint( "f_pilgrimroad_55.Id5", "f_pilgrimroad_55", Spot(-794.16656, 52.298744, 25));
		AddSpawnPoint( "f_pilgrimroad_55.Id5", "f_pilgrimroad_55", Spot(-558.0269, 648.06683, 25));
		AddSpawnPoint( "f_pilgrimroad_55.Id5", "f_pilgrimroad_55", Spot(-392.9651, -389.957, 25));
		AddSpawnPoint( "f_pilgrimroad_55.Id5", "f_pilgrimroad_55", Spot(122.76793, -190.65895, 25));

	}
}
