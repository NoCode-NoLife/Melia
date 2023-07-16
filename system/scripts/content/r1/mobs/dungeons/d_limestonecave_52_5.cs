//--- Melia Script -----------------------------------------------------------
// d_limestonecave_52_5
//
//--- Description -----------------------------------------------------------
// Sets up the d_limestonecave_52_5 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DLimestonecave525MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_limestonecave_52_5", MonsterId.Wood_Goblin_Green, Properties("MHP", 510123, "MINPATK", 7061, "MAXPATK", 8579, "MINMATK", 7061, "MAXMATK", 8579, "DEF", 84293, "MDEF", 84293));
		AddPropertyOverrides("d_limestonecave_52_5", MonsterId.Rockoff_Orange, Properties("MHP", 512925, "MINPATK", 7097, "MAXPATK", 8624, "MINMATK", 7097, "MAXMATK", 8624, "DEF", 85417, "MDEF", 85417));
		AddPropertyOverrides("d_limestonecave_52_5", MonsterId.Flamil_Green, Properties("MHP", 515774, "MINPATK", 7134, "MAXPATK", 8669, "MINMATK", 7134, "MAXMATK", 8669, "DEF", 86560, "MDEF", 86560));
		AddPropertyOverrides("d_limestonecave_52_5", MonsterId.Rondo, Properties("MHP", 518669, "MINPATK", 7171, "MAXPATK", 8714, "MINMATK", 7171, "MAXMATK", 8714, "DEF", 87722, "MDEF", 87722));

		// Monster Spawners --------------------------------

		AddSpawner("d_limestonecave_52_5.Id1", MonsterId.Wood_Goblin_Green, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_5.Id2", MonsterId.Rockoff_Orange, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_5.Id3", MonsterId.Flamil_Green, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_5.Id4", MonsterId.Rondo, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_5.Id5", MonsterId.Wood_Goblin_Green, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_5.Id6", MonsterId.Rootcrystal_04, 25, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Wood_Goblin_Green Spawn Points
		AddSpawnPoint( "d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Spot(-447.5711, -1295.7384, 200));
		AddSpawnPoint( "d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Spot(-522.09656, -995.2058, 200));
		AddSpawnPoint( "d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Spot(-779.93475, -490.38684, 200));
		AddSpawnPoint( "d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Spot(-1351.9154, -628.8639, 200));
		AddSpawnPoint( "d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Spot(-833.3625, 79.16193, 200));
		AddSpawnPoint( "d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Spot(135.60094, 241.89105, 200));
		AddSpawnPoint( "d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Spot(392.83466, -509.23178, 200));
		AddSpawnPoint( "d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Spot(855.1975, -1430.3328, 200));
		AddSpawnPoint( "d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Spot(1079.0972, -573.3137, 200));
		AddSpawnPoint( "d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Spot(1083.94, 270.8413, 200));
		AddSpawnPoint( "d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Spot(521.40125, 869.18384, 200));
		AddSpawnPoint( "d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Spot(-177.98941, 907.91296, 200));

		// Rockoff_Orange Spawn Points
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(500.36914, -761.7191, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-519.1552, -1167.4034, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-416.17316, -980.86273, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-722.9455, -412.61685, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-1451.5449, -614.67426, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-812.78613, -95.697975, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(187.27347, 83.626144, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(724.5929, -1196.69, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(1069.2112, -274.61536, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(930.0855, 253.33107, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(307.51212, 1031.4332, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-307.177, 807.3386, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-1415.2332, -434.05286, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-1261.5906, -660.1206, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-1212.2917, -507.18753, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-764.05237, -516.6074, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-602.8545, -608.72186, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-626.6394, -50.63488, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-749.27594, 58.84763, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-5.6346188, 79.04933, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-38.583687, 251.55446, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(241.75967, 277.33298, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-26.946068, -62.366043, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(171.54065, -124.2579, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-57.37853, 838.5353, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-149.27417, 719.46484, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(277.83762, 987.7273, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(366.35895, 781.2807, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(812.25507, 430.29205, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(938.0101, 555.9665, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(1072.62, 479.00418, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(1069.8003, 280.5271, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(1093.3236, -383.84637, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(908.9826, -458.64096, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(1008.8414, -598.00806, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(1134.8982, -620.76056, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(1148.0272, -503.38898, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(241.9604, -724.1943, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(365.66113, -471.02686, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(565.35474, -541.683, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-635.6224, -1126.9762, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-693.7703, -1345.3258, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(-441.79736, -1380.7262, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(880.49585, -1433.7589, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Spot(936.02, -1249.1627, 30));

		// Flamil_Green Spawn Points
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(286.05298, -680.15704, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(594.90955, -642.184, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(12.371845, 282.59085, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-55.807217, 70.61102, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-602.6574, 33.788654, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-1173.388, -551.4642, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-613.77594, -635.3908, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-387.31332, -1135.9456, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-641.5334, -1158.5751, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(903.4643, -1194.8876, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(995.2866, 517.55194, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(1069.5706, -586.8447, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(351.64484, 813.6987, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(959.23706, -389.36444, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(1111.7732, -313.18442, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(226.51628, 47.204742, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-242.48976, 85.37398, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(397.88263, -548.9817, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(509.32358, -816.0636, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(735.0047, -1134.7657, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(704.93756, -1316.5903, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(887.05115, -1380.5575, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-472.0647, -1409.1042, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-476.8479, -994.7898, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-752.65594, -1102.0768, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-836.2935, -1328.2139, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-844.8255, -461.92792, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-647.6324, -376.24664, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-821.91626, -148.61847, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-887.5761, 46.35952, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-1295.6201, -451.8556, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-1471.2957, -562.15857, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-1586.7643, -124.85803, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-1489.0015, 79.22628, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-362.80667, 813.71375, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-215.91566, 697.2375, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(-128.08063, 890.09393, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(397.40356, 1098.7869, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Spot(226.13965, 966.0419, 30));

		// Rondo Spawn Points
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-660.8969, -1267.1028, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-580.5755, -1092.1759, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-540.8847, -1351.8208, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-539.1717, -1473.7212, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-640.54095, -1498.9525, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-307.13242, -1387.3846, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(866.5869, 211.87325, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(810.98596, 401.66147, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(1002.785, 539.8973, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(1093.6987, 370.0419, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(1039.5315, 188.34756, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(854.4309, 529.0089, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(72.07866, 257.18976, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-78.101776, 101.42022, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(153.34541, -32.809933, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(303.05298, 158.40726, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(315.57855, 847.818, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(277.64948, 1111.2106, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(417.0673, 1025.3892, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(531.16986, 761.6664, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(198.05751, 964.8187, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-313.1804, 791.36993, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-224.94878, 714.5061, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-82.22545, 901.3936, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-816.86035, -158.75504, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-840.37964, 103.97778, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-673.2066, 85.94536, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-549.65405, -37.119514, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-648.0425, -150.70456, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-877.2113, -5.771923, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-1602.2728, 4.3681974, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-1626.0095, -140.77545, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-1405.6685, -38.84799, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-1384.8999, 122.6114, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-1325.8988, 195.37091, 30));
		AddSpawnPoint( "d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Spot(-1225.3204, 255.69333, 30));

		// Wood_Goblin_Green Spawn Points
		AddSpawnPoint( "d_limestonecave_52_5.Id5", "d_limestonecave_52_5", Spot(-1340.9868, -1324.0662, 9999));

		// Rootcrystal_04 Spawn Points
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(-1271.81, -1352.29, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(-715.88, -1366.25, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(-346.51, -1343.56, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(-531.91, -930.96, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(305.48, -755.18, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(-647.7, -532.82, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(-1126.61, -540.92, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(-1450.25, -579.82, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(-1519.61, -144.14, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(-1141.01, 283.25, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(-798.44, -0.25, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(-590.46, -156.8, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(-141, 74.94, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(159.18, 371.53, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(294.18, -9.57, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(347.42, -589.52, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(425.3, -847.52, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(937.89, -535.74, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(1095.8, -162.24, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(992.5, 324.29, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(1126.33, 542.19, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(1560.12, 728.16, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(1644.85, 960.52, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(491.69, 972.53, 15));
		AddSpawnPoint( "d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Spot(-275.98, 871.65, 15));

	}
}
