//--- Melia Script -----------------------------------------------------------
// d_fantasylibrary_48_3
//
//--- Description -----------------------------------------------------------
// Sets up the d_fantasylibrary_48_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFantasylibrary483MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_fantasylibrary_48_3", MonsterId.Rotacion, Properties("MHP", 545736, "MINPATK", 7519, "MAXPATK", 9142, "MINMATK", 7519, "MAXMATK", 9142, "DEF", 100554, "MDEF", 100554));
		AddPropertyOverrides("d_fantasylibrary_48_3", MonsterId.Crobasia, Properties("MHP", 543149, "MINPATK", 7485, "MAXPATK", 9101, "MINMATK", 7485, "MAXMATK", 9101, "DEF", 99275, "MDEF", 99275));
		AddPropertyOverrides("d_fantasylibrary_48_3", MonsterId.Gear, Properties("MHP", 551235, "MINPATK", 7589, "MAXPATK", 9229, "MINMATK", 7589, "MAXMATK", 9229, "DEF", 103273, "MDEF", 103273));
		AddPropertyOverrides("d_fantasylibrary_48_3", MonsterId.Boogie_Box, Properties("MHP", 548433, "MINPATK", 7553, "MAXPATK", 9185, "MINMATK", 7553, "MAXMATK", 9185, "DEF", 101887, "MDEF", 101887));

		// Monster Spawners --------------------------------

		AddSpawner("d_fantasylibrary_48_3.Id1", MonsterId.Rootcrystal_03, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_3.Id2", MonsterId.Rotacion, 45, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_3.Id3", MonsterId.Crobasia, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_3.Id4", MonsterId.Gear, 60, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_3.Id5", MonsterId.Boogie_Box, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-674.2201, -626.11584, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-586.96155, -440.90433, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-529.318, -587.66833, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-200.9243, -432.3648, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-80.22764, -510.7578, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(89.30983, -414.58682, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(13.052742, -288.75302, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-180.55327, -213.03922, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-93.38416, -84.63515, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-239.50395, -38.185036, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-217.68283, 110.02878, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-92.07831, 52.567646, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-118.00745, 202.70271, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(7.8705378, 183.21323, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(50.420815, 21.00711, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(529.58673, 237.39465, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(731.09546, 22.582005, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(692.1497, 164.03261, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(596.47876, 98.90301, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(580.23413, -603.0411, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(561.5618, -339.4451, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(698.89795, -456.92865, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(833.1028, -266.85843, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(288.19882, -498.19482, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(1327.8198, -347.96048, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(1186.3422, -334.7439, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(1004.1372, -465.4477, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-68.02734, 430.90662, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-58.543926, 728.79205, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-79.29452, 1104.2872, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-190.46182, 1243.4434, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-62.738796, 1357.5436, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(45.642067, 1224.8341, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(565.77405, 1255.7034, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(679.10657, 1303.1654, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(926.3635, 1312.545, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(860.64514, 1175.6342, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(707.0578, 1118.5015, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(601.1827, 945.05695, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(838.1384, 978.8375, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-77.67175, 1599.5787, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-130.6246, 1852.8942, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-151.08153, 1989.4348, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-22.825779, 2067.8958, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(134.10873, 1964.8345, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(43.92355, 1793.0481, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-494.00336, 2030.5798, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-932.9582, 1908.8573, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-1080.9117, 2028.5186, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-1110.5498, 2205.3054, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-906.0909, 2366.6936, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-671.41394, 2170.7285, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-717.9606, 2036.1245, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-756.499, 1936.6119, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-1218.0851, 1948.0326, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-1536.717, 1918.7472, 100));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id1", "d_fantasylibrary_48_3", Spot(-1368.2689, 1750.8403, 100));

		// Rotacion Spawn Points
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-1579.9689, 1950.7627, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-1561.768, 2009.3381, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-1474.4856, 1873.2328, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-1315.8562, 1911.2197, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-1383.4218, 1996.7896, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-1065.0261, 2091.096, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-950.2684, 2033.17, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-1006.2543, 2188.2927, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-867.62695, 2140.46, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-879.6085, 2046.7203, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-931.35034, 2224.4146, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-891.5723, 2340.9014, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-696.43665, 2247.634, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-755.4152, 2010.7761, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-778.86957, 2177.5293, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-74.86669, 1808.9349, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(14.102148, 1842.668, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-94.32822, 1869.6936, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-96.77471, 1957.1718, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(59.58705, 1913.0573, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-35.900646, 2004.5658, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-94.70525, 1257.1934, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-130.44397, 1187.0793, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-31.511463, 1181.2274, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(-38.663635, 1343.9965, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(532.27014, 1170.0881, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(580.5571, 1330.7501, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(676.9365, 1241.1573, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(585.29987, 1015.0144, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(666.46625, 958.7226, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(800.6909, 1050.3512, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(737.3052, 1130.7719, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(672.1178, 1169.9377, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(761.6097, 1212.2689, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(876.0225, 1201.322, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(892.80176, 1077.367, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(1171.8898, -309.56842, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(1209.4609, -259.14676, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(1259.7354, -350.7337, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(1215.101, -457.13672, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(1385.1095, -366.0781, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(1341.7084, -265.55563, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(666.6525, 106.41539, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(663.12415, 205.26141, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id2", "d_fantasylibrary_48_3", Spot(735.95, 137.43901, 40));

		// Crobasia Spawn Points
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(-642.9049, -560.3417, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(-546.216, -581.60834, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(-623.23254, -429.81857, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(-473.7166, -604.9214, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(-234.7018, -437.8658, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(-144.33646, -428.56717, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(-51.51194, -485.9563, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(29.178389, -409.8562, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(6.9107437, -288.7635, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(-129.6821, -240.94214, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(-217.28549, -164.55772, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(-25.372093, -145.38623, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(-164.50516, 7.633771, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(-82.99832, 33.082977, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(-116.07941, 123.47914, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(2.1984553, 188.72844, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(-50.482044, 261.42212, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(112.89094, 57.99047, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(530.6905, -349.84692, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(516.3367, -483.3565, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(523.141, -601.2462, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(651.2505, -491.15222, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(595.2908, -413.32596, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(699.3733, -330.83936, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(586.7577, -244.35085, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(724.3374, -480.83594, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(790.9817, -621.8854, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(884.1103, -474.74323, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(1257.7903, -415.0983, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(1401.6694, -297.4334, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(528.0254, 166.81075, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(516.8487, 284.1009, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(617.27026, 303.02228, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(751.10315, 325.01196, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(868.401, 206.01813, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(-180.64632, 1127.4768, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(-190.1819, 1319.4691, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(84.89279, 1175.367, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(-160.30017, 238.83498, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id3", "d_fantasylibrary_48_3", Spot(-68.44447, 1016.9084, 40));

		// Gear Spawn Points
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-672.0736, -651.9528, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-571.31354, -507.5201, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-520.0795, -662.002, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-203.01328, -353.22003, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-125.65784, -549.7378, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(101.41106, -319.8749, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-175.10213, -102.41116, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(84.95, 116.43277, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-89.99231, 189.90587, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(518.89233, -401.06287, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(603.4607, -557.4249, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(705.85486, -584.3753, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(729.9457, -401.23648, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(621.4537, -333.19946, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(815.3263, -300.96756, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(852.6107, -547.74274, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(1169.279, -395.5252, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(1344.2396, -417.84888, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(1280.5586, -249.18611, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(749.4875, 45.676308, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(636.7754, 32.65928, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(592.94653, 207.17355, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(709.6307, 267.35382, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(799.37683, 230.32065, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(836.92975, 105.04769, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(555.31494, 1082.3231, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(546.8208, 935.6257, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(534.80634, 1289.0659, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(761.30914, 944.0804, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(888.8607, 976.0464, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(835.41003, 1143.4305, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(828.8013, 1315.5952, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(952.21094, 1293.1271, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(583.33405, 1209.4243, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(27.030052, 1099.5979, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-76.482834, 1092.409, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-198.46497, 1210.6896, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-120.82721, 1344.1906, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(23.749292, 1255.0106, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-160.1639, 1812.1736, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-171.05104, 1954.7639, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-140.8204, 2041.6052, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(33.098396, 2010.2036, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(124.8408, 1964.6864, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(89.67515, 1766.4038, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-974.308, 1950.8704, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-842.85, 1907.4548, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-716.5609, 2092.8865, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-799.51434, 2265.6912, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-991.99976, 2291.6187, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-1088.3799, 2216.117, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-941.1997, 2105.4226, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-1445.7488, 1964.8309, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-1573.0155, 1840.4539, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-1426.1888, 69.88803, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-1335.1912, 158.07498, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-1465.78, 203.69092, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-1354.4695, 299.16843, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-1474.4519, 338.9049, 40));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id4", "d_fantasylibrary_48_3", Spot(-1299.7892, 395.72055, 40));

		// Boogie_Box Spawn Points
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-763.17596, -524.37756, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-705.2777, -487.81567, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-719.8538, -426.84915, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-587.754, -652.2606, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-474.3739, -504.10916, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-525.4644, -404.691, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-267.50677, -572.22815, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(218.25778, -283.24286, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(285.8978, -289.46344, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(212.32536, -372.1292, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(237.81842, -462.03842, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(349.49594, -448.52243, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(331.57495, -550.2106, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(450.17407, -515.0918, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(960.0543, -457.8413, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(1093.0957, -446.32825, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-275.24924, 127.31818, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-203.59882, 187.53012, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(166.01575, 258.12607, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(237.32106, 288.0452, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(312.82086, 253.3944, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(379.48206, 284.59827, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-80.35148, 325.68927, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-36.67802, 497.84454, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-78.01691, 597.49774, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-33.42377, 787.2671, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-66.22125, 942.49243, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(293.41705, 1238.6676, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(376.71918, 1197.6473, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-88.53622, 1494.2219, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-336.66376, 1997.2023, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-325.81232, 2041.4014, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-553.6032, 2040.6106, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-470.19534, 2067.4397, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-564.2507, 2098.8098, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-1164.6893, 1895.9355, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-1214.1167, 2027.1777, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-1307.0037, 1971.395, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-1391.5334, 1873.5844, 20));
		AddSpawnPoint( "d_fantasylibrary_48_3.Id5", "d_fantasylibrary_48_3", Spot(-1497.094, 1760.7163, 20));

	}
}
