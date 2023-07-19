//--- Melia Script -----------------------------------------------------------
// d_limestonecave_52_5
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Tevhrin Stalactite Cave Section 5' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DLimestonecave525MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_limestonecave_52_5", MonsterId.Wood_Goblin_Green, Properties("MHP", 510123, "MINPATK", 7061, "MAXPATK", 8579, "MINMATK", 7061, "MAXMATK", 8579, "DEF", 84293, "MDEF", 84293));
		AddPropertyOverrides("d_limestonecave_52_5", MonsterId.Rockoff_Orange, Properties("MHP", 512925, "MINPATK", 7097, "MAXPATK", 8624, "MINMATK", 7097, "MAXMATK", 8624, "DEF", 85417, "MDEF", 85417));
		AddPropertyOverrides("d_limestonecave_52_5", MonsterId.Flamil_Green, Properties("MHP", 515774, "MINPATK", 7134, "MAXPATK", 8669, "MINMATK", 7134, "MAXMATK", 8669, "DEF", 86560, "MDEF", 86560));
		AddPropertyOverrides("d_limestonecave_52_5", MonsterId.Rondo, Properties("MHP", 518669, "MINPATK", 7171, "MAXPATK", 8714, "MINMATK", 7171, "MAXMATK", 8714, "DEF", 87722, "MDEF", 87722));
		AddPropertyOverrides("d_limestonecave_52_5", MonsterId.Boss_Rambandgad, Properties("MHP", 3035767, "MINPATK", 11534, "MAXPATK", 14017, "MINMATK", 11534, "MAXMATK", 14017, "DEF", 277374, "MDEF", 277374));
		AddPropertyOverrides("d_limestonecave_52_5", MonsterId.Boss_Gesti_Q1, Properties("MHP", 4380368, "MINPATK", 14268, "MAXPATK", 17341, "MINMATK", 14268, "MAXMATK", 17341, "DEF", 177384, "MDEF", 177384));

		// Monster Spawners ---------------------------------

		AddSpawner("d_limestonecave_52_5.Id1", MonsterId.Wood_Goblin_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_5.Id2", MonsterId.Rockoff_Orange, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_5.Id3", MonsterId.Flamil_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_5.Id4", MonsterId.Rondo, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_5.Id5", MonsterId.Wood_Goblin_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_5.Id6", MonsterId.Rootcrystal_04, 19, 25, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Wood_Goblin_Green' GenType 19 Spawn Points
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(-447.5711, -1295.7384, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(-522.09656, -995.2058, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(-779.93475, -490.38684, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(-1351.9154, -628.8639, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(-833.3625, 79.16193, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(135.60094, 241.89105, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(392.83466, -509.23178, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(855.1975, -1430.3328, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(1079.0972, -573.3137, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(1083.94, 270.8413, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(521.40125, 869.18384, 200));
		AddSpawnPoint("d_limestonecave_52_5.Id1", "d_limestonecave_52_5", Rectangle(-177.98941, 907.91296, 200));

		// 'Rockoff_Orange' GenType 20 Spawn Points
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(500.36914, -761.7191, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-519.1552, -1167.4034, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-416.17316, -980.86273, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-722.9455, -412.61685, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-1451.5449, -614.67426, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-812.78613, -95.697975, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(187.27347, 83.626144, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(724.5929, -1196.69, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(1069.2112, -274.61536, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(930.0855, 253.33107, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(307.51212, 1031.4332, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-307.177, 807.3386, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-1415.2332, -434.05286, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-1261.5906, -660.1206, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-1212.2917, -507.18753, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-764.05237, -516.6074, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-602.8545, -608.72186, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-626.6394, -50.63488, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-749.27594, 58.84763, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-5.6346188, 79.04933, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-38.583687, 251.55446, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(241.75967, 277.33298, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-26.946068, -62.366043, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(171.54065, -124.2579, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-57.37853, 838.5353, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-149.27417, 719.46484, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(277.83762, 987.7273, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(366.35895, 781.2807, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(812.25507, 430.29205, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(938.0101, 555.9665, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(1072.62, 479.00418, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(1069.8003, 280.5271, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(1093.3236, -383.84637, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(908.9826, -458.64096, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(1008.8414, -598.00806, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(1134.8982, -620.76056, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(1148.0272, -503.38898, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(241.9604, -724.1943, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(365.66113, -471.02686, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(565.35474, -541.683, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-635.6224, -1126.9762, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-693.7703, -1345.3258, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(-441.79736, -1380.7262, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(880.49585, -1433.7589, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id2", "d_limestonecave_52_5", Rectangle(936.02, -1249.1627, 30));

		// 'Flamil_Green' GenType 21 Spawn Points
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(286.05298, -680.15704, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(594.90955, -642.184, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(12.371845, 282.59085, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-55.807217, 70.61102, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-602.6574, 33.788654, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-1173.388, -551.4642, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-613.77594, -635.3908, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-387.31332, -1135.9456, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-641.5334, -1158.5751, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(903.4643, -1194.8876, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(995.2866, 517.55194, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(1069.5706, -586.8447, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(351.64484, 813.6987, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(959.23706, -389.36444, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(1111.7732, -313.18442, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(226.51628, 47.204742, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-242.48976, 85.37398, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(397.88263, -548.9817, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(509.32358, -816.0636, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(735.0047, -1134.7657, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(704.93756, -1316.5903, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(887.05115, -1380.5575, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-472.0647, -1409.1042, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-476.8479, -994.7898, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-752.65594, -1102.0768, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-836.2935, -1328.2139, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-844.8255, -461.92792, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-647.6324, -376.24664, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-821.91626, -148.61847, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-887.5761, 46.35952, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-1295.6201, -451.8556, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-1471.2957, -562.15857, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-1586.7643, -124.85803, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-1489.0015, 79.22628, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-362.80667, 813.71375, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-215.91566, 697.2375, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(-128.08063, 890.09393, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(397.40356, 1098.7869, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id3", "d_limestonecave_52_5", Rectangle(226.13965, 966.0419, 30));

		// 'Rondo' GenType 23 Spawn Points
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-660.8969, -1267.1028, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-580.5755, -1092.1759, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-540.8847, -1351.8208, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-539.1717, -1473.7212, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-640.54095, -1498.9525, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-307.13242, -1387.3846, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(866.5869, 211.87325, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(810.98596, 401.66147, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(1002.785, 539.8973, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(1093.6987, 370.0419, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(1039.5315, 188.34756, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(854.4309, 529.0089, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(72.07866, 257.18976, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-78.101776, 101.42022, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(153.34541, -32.809933, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(303.05298, 158.40726, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(315.57855, 847.818, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(277.64948, 1111.2106, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(417.0673, 1025.3892, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(531.16986, 761.6664, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(198.05751, 964.8187, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-313.1804, 791.36993, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-224.94878, 714.5061, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-82.22545, 901.3936, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-816.86035, -158.75504, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-840.37964, 103.97778, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-673.2066, 85.94536, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-549.65405, -37.119514, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-648.0425, -150.70456, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-877.2113, -5.771923, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-1602.2728, 4.3681974, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-1626.0095, -140.77545, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-1405.6685, -38.84799, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-1384.8999, 122.6114, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-1325.8988, 195.37091, 30));
		AddSpawnPoint("d_limestonecave_52_5.Id4", "d_limestonecave_52_5", Rectangle(-1225.3204, 255.69333, 30));

		// 'Wood_Goblin_Green' GenType 24 Spawn Points
		AddSpawnPoint("d_limestonecave_52_5.Id5", "d_limestonecave_52_5", Rectangle(-1340.9868, -1324.0662, 9999));

		// 'Rootcrystal_04' GenType 26 Spawn Points
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-1271.81, -1352.29, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-715.88, -1366.25, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-346.51, -1343.56, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-531.91, -930.96, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(305.48, -755.18, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-647.7, -532.82, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-1126.61, -540.92, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-1450.25, -579.82, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-1519.61, -144.14, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-1141.01, 283.25, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-798.44, -0.25, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-590.46, -156.8, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-141, 74.94, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(159.18, 371.53, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(294.18, -9.57, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(347.42, -589.52, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(425.3, -847.52, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(937.89, -535.74, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(1095.8, -162.24, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(992.5, 324.29, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(1126.33, 542.19, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(1560.12, 728.16, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(1644.85, 960.52, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(491.69, 972.53, 15));
		AddSpawnPoint("d_limestonecave_52_5.Id6", "d_limestonecave_52_5", Rectangle(-275.98, 871.65, 15));
	}
}
