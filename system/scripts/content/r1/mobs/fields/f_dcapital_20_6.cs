//--- Melia Script -----------------------------------------------------------
// f_dcapital_20_6
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Jonael Commemorative Orb' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FDcapital206MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_dcapital_20_6.Id1", MonsterId.Wood_Lwa_Green, 45, 60, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_20_6.Id2", MonsterId.Ellomago_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_20_6.Id3", MonsterId.Ragged_Bird, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_20_6.Id4", MonsterId.Ragged_Butcher, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_20_6.Id5", MonsterId.Rootcrystal_04, 15, 20, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Wood_Lwa_Green' GenType 12 Spawn Points
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-335.50073, -33.990494, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-345.42255, 129.37094, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-315.01587, 271.6715, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-441.53354, 420.99033, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-519.8182, 253.0945, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-628.81665, 396.66757, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-712.0942, 255.83295, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-843.4579, 326.53006, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-1062.1465, 328.61038, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-1110.4752, 470.03766, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-1111.6327, 601.8513, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-1127.1461, 796.89545, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-1092.5679, 1001.8478, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-1093.7336, 1157.3488, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-915.4442, 1233.1211, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-915.10425, 1395.1295, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-1000.5898, 1440.519, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-930.1112, 1545.8451, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-1020.6581, 1609.8263, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-715.586, 1304.9116, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-643.78064, 1138.2167, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-724.52704, 1523.0908, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-744.3162, 1708.4961, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-889.53937, 777.25964, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-661.8126, 683.69446, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-642.86505, 820.603, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-420.16138, 776.5667, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-159.89813, 795.9353, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-430.06332, 681.64594, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-118.65824, 345.4275, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-198.60457, 293.9154, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-2.9183788, 50.637505, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-96.78854, -141.53621, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-29.211895, -376.2203, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-139.96628, -472.02463, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(299.7266, 339.06876, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(200.9935, 470.97156, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(322.02533, 917.4595, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(413.10715, 887.65765, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(420.23022, 1061.9955, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(448.83325, 1251.9855, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(292.6818, 1369.1422, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(363.0448, 1425.9326, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-15.884804, 1390.9706, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-111.75972, 1475.127, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-29.333078, 1585.7882, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(506.83136, -413.21765, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(694.10254, -447.57953, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(733.33856, -306.48904, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(448.17343, -267.77148, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(218.04019, -93.658325, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(385.14896, -9.787209, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(618.85535, 26.369823, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(361.3098, 158.5748, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(202.64827, 546.585, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-89.549324, 492.46994, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-145.37541, -268.19098, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-451.98895, 338.1783, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-700.27155, 451.0008, 35));
		AddSpawnPoint("f_dcapital_20_6.Id1", "f_dcapital_20_6", Rectangle(-610.8207, 275.7179, 35));

		// 'Ellomago_Green' GenType 16 Spawn Points
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-723.9323, 292.45667, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-602.22076, 383.55054, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-384.07553, 322.35986, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-64.543205, 304.42352, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-146.212, 580.4963, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-217.70709, 801.59375, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(146.46063, 744.3731, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(351.07907, 442.5647, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(105.75789, 332.59576, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(287.59393, 270.43536, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(413.85233, 805.0092, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(425.93964, 1067.6545, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(339.63898, 1193.9519, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(466.72534, 1338.74, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(288.32388, 1315.9508, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-96.64238, 1335.0847, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-163.43396, 1442.7926, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-180.14735, 1398.0151, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-646.86206, 442.17258, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-846.46094, 321.42462, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-1026.7864, 322.17093, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-1094.4254, 735.1729, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-1131.3823, 576.45905, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-1167.4338, 890.66327, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-1076.0634, 891.3921, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-1063.6787, 1000.8317, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-994.3766, 1175.4858, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-843.341, 1227.4238, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-777.55304, 1492.9241, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-702.5496, 1227.1045, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-805.0485, 830.23474, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-810.431, 721.50525, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-724.97943, 760.73175, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-611.45856, 877.3489, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-755.1588, 924.8732, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-646.9145, 569.99725, 40));
		AddSpawnPoint("f_dcapital_20_6.Id2", "f_dcapital_20_6", Rectangle(-712.8704, 457.93344, 40));

		// 'Ragged_Bird' GenType 17 Spawn Points
		AddSpawnPoint("f_dcapital_20_6.Id3", "f_dcapital_20_6", Rectangle(-702.9806, 829.8194, 9999));

		// 'Ragged_Butcher' GenType 18 Spawn Points
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-164.8611, 405.81967, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-25.848045, 374.3786, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-201.24326, 688.85474, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-236.01808, 581.5776, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-211.36366, 901.83185, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(203.0992, 350.93002, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(384.11343, 362.26434, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(174.3188, 613.8389, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(465.43317, 725.07306, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(78.767334, 853.58844, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(339.08682, 548.8295, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(401.928, 963.422, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-184.83316, -174.89845, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-37.436398, -292.37216, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-46.389584, -409.61157, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-654.24524, 330.14072, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-412.91046, 353.37115, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-895.9116, 876.5624, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-683.1166, 772.5186, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-820.95355, 721.82916, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-767.9847, 1387.9902, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-770.0084, 1201.2064, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(192.7843, 1424.7623, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(178.9453, 1337.0895, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(320.65512, 725.73926, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(536.29266, -534.4842, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(846.3862, -302.21893, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(449.38312, -256.38055, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(506.84235, -23.639019, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(622.25037, -370.3769, 40));
		AddSpawnPoint("f_dcapital_20_6.Id4", "f_dcapital_20_6", Rectangle(-20.073704, 102.5078, 40));

		// 'Rootcrystal_04' GenType 22 Spawn Points
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-356.48, -140.46, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-476.08, 292.12, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-771.28, 304.5, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-982.01, 291.63, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-1103.72, 513.72, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-1071.95, 962.08, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-1055.38, 1484.42, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-790.39, 1175.08, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-789.11, 1512.03, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-173.36, 496.07, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-142.95, 865.57, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-102.83, -333.38, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(218.16, 415.74, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(425.99, 643.32, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(162.37, 842.46, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(483.29, 1011.87, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(297.76, 1445.79, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(-4.8, 1298.24, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(566.6, -10.18, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(478.1, -289.15, 15));
		AddSpawnPoint("f_dcapital_20_6.Id5", "f_dcapital_20_6", Rectangle(829.52, -328.74, 15));
	}
}
